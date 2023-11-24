using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using Diag = bp2s.b.Diagnostics;

namespace bp2s
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Count() < 1)
            {
                Console.WriteLine("Specify model as bp2s <model id>");

                return;
            }

            string modelName = args[0];
            string path = @"k:\AosService\PackagesLocalDirectory\";

            if (!System.IO.Directory.Exists(path))
            {
                path = @"c:\AosService\PackagesLocalDirectory\";
            }

            string bpfile = path + modelName + "\\BPCheck.xml";
            string bfile = path + modelName + "\\BuildModelResult.xml";
            string supfile = path + modelName + "\\" + modelName + "\\AxIgnoreDiagnosticList\\" + modelName + "_BPSuppressions.xml";

            XmlSerializer serializer = new XmlSerializer(typeof(Diagnostics));
            Diagnostics diag = (Diagnostics)serializer.Deserialize(new XmlTextReader(bpfile));

            List<IgnoreDiagnosticsDiagnostic> ignoreList = new List<IgnoreDiagnosticsDiagnostic>();

            foreach (var item in diag.Items)
            {
                IgnoreDiagnosticsDiagnostic ignore = new IgnoreDiagnosticsDiagnostic()
                {
                    DiagnosticType = item.DiagnosticType,
                    Severity = item.Severity,
                    Path = item.Path,
                    Moniker = item.Moniker,
                    Justification = "Automatically suppressed BP. Recommended to resolve manually."
                };

                ignoreList.Add(ignore);
            }

            XmlSerializer serializer2 = new XmlSerializer(typeof(b.Diagnostics));
            b.Diagnostics diag2 = (b.Diagnostics)serializer2.Deserialize(new XmlTextReader(bfile));

            foreach (var item in diag2.Items)
            {
                IgnoreDiagnosticsDiagnostic ignore = new IgnoreDiagnosticsDiagnostic()
                {
                    DiagnosticType = item.DiagnosticType,
                    Severity = item.Severity,
                    Path = item.Path,
                    Moniker = item.Moniker,
                    Justification = "Automatically suppressed BuildModelResult. Recommended to resolve manually."
                };

                ignoreList.Add(ignore);
            }

            IgnoreDiagnostics res = new IgnoreDiagnostics() { Name = modelName + "_BPSuppressions" };
            res.Items = ignoreList.ToArray();

            StringWriter writer = new Utf8StringWriter();
            XmlWriterSettings settings = new XmlWriterSettings() { Encoding = new System.Text.UTF8Encoding(true), Indent = true };
            XmlWriter xwriter = XmlWriter.Create(supfile, settings);
            StringBuilder sb = new StringBuilder();
            XmlWriter xwriter2 = XmlWriter.Create(sb, settings);
            XmlSerializer resSerializer = new XmlSerializer(res.GetType());
            XmlSerializerNamespaces xns = new XmlSerializerNamespaces();
            xns.Add(string.Empty, string.Empty);
            resSerializer.Serialize(xwriter, res, xns);
            resSerializer.Serialize(xwriter2, res, xns);
        }
    }

    public class Utf8StringWriter : StringWriter
    {
        public override Encoding Encoding
        {
            get { return new UTF8Encoding(false); }
        }
    }
}
