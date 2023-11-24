using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bp2s.b
{

    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class Diagnostics
    {

        private DiagnosticsDiagnostic[] itemsField;

        private object aliasesField;

        private System.DateTime generationTimeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Diagnostic", IsNullable = false)]
        public DiagnosticsDiagnostic[] Items
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

        /// <remarks/>
        public object Aliases
        {
            get
            {
                return this.aliasesField;
            }
            set
            {
                this.aliasesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime GenerationTime
        {
            get
            {
                return this.generationTimeField;
            }
            set
            {
                this.generationTimeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class DiagnosticsDiagnostic
    {

        private string diagnosticTypeField;

        private string severityField;

        private string pathField;

        private string elementTypeField;

        private string monikerField;

        private ushort lineField;

        private bool lineFieldSpecified;

        private ushort columnField;

        private bool columnFieldSpecified;

        private ushort endLineField;

        private bool endLineFieldSpecified;

        private ushort endColumnField;

        private bool endColumnFieldSpecified;

        private string messageField;

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
        public ushort Line
        {
            get
            {
                return this.lineField;
            }
            set
            {
                this.lineField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LineSpecified
        {
            get
            {
                return this.lineFieldSpecified;
            }
            set
            {
                this.lineFieldSpecified = value;
            }
        }

        /// <remarks/>
        public ushort Column
        {
            get
            {
                return this.columnField;
            }
            set
            {
                this.columnField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ColumnSpecified
        {
            get
            {
                return this.columnFieldSpecified;
            }
            set
            {
                this.columnFieldSpecified = value;
            }
        }

        /// <remarks/>
        public ushort EndLine
        {
            get
            {
                return this.endLineField;
            }
            set
            {
                this.endLineField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool EndLineSpecified
        {
            get
            {
                return this.endLineFieldSpecified;
            }
            set
            {
                this.endLineFieldSpecified = value;
            }
        }

        /// <remarks/>
        public ushort EndColumn
        {
            get
            {
                return this.endColumnField;
            }
            set
            {
                this.endColumnField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool EndColumnSpecified
        {
            get
            {
                return this.endColumnFieldSpecified;
            }
            set
            {
                this.endColumnFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string Message
        {
            get
            {
                return this.messageField;
            }
            set
            {
                this.messageField = value;
            }
        }
    }


}
