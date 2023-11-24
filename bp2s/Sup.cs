using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bp2s
{

    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class IgnoreDiagnostics
    {

        private string nameField;

        private IgnoreDiagnosticsDiagnostic[] itemsField;

        /// <remarks/>
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Diagnostic", IsNullable = false)]
        public IgnoreDiagnosticsDiagnostic[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class IgnoreDiagnosticsDiagnostic
    {

        private string diagnosticTypeField;

        private string severityField;

        private string pathField;

        private string elementTypeField;

        private string monikerField;

        private string justificationField;

        /// <remarks/>
        public string DiagnosticType
        {
            get
            {
                return this.diagnosticTypeField;
            }
            set
            {
                this.diagnosticTypeField = value;
            }
        }

        /// <remarks/>
        public string Severity
        {
            get
            {
                return this.severityField;
            }
            set
            {
                this.severityField = value;
            }
        }

        /// <remarks/>
        public string Path
        {
            get
            {
                return this.pathField;
            }
            set
            {
                this.pathField = value;
            }
        }

        /// <remarks/>
        public string ElementType
        {
            get
            {
                return this.elementTypeField;
            }
            set
            {
                this.elementTypeField = value;
            }
        }

        /// <remarks/>
        public string Moniker
        {
            get
            {
                return this.monikerField;
            }
            set
            {
                this.monikerField = value;
            }
        }

        /// <remarks/>
        public string Justification
        {
            get
            {
                return this.justificationField;
            }
            set
            {
                this.justificationField = value;
            }
        }
    }


}
