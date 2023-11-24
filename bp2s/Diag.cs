using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bp2s
{
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class Diagnostics
    {

        private DiagnosticsDiagnostic[] itemsField;

        private DiagnosticsAlias[] aliasesField;

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
        [System.Xml.Serialization.XmlArrayItemAttribute("Alias", IsNullable = false)]
        public DiagnosticsAlias[] Aliases
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

        private byte columnField;

        private bool columnFieldSpecified;

        private ushort endLineField;

        private bool endLineFieldSpecified;

        private byte endColumnField;

        private bool endColumnFieldSpecified;

        private string messageField;

        private DiagnosticsDiagnosticItemSpecific itemSpecificField;

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
        public byte Column
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
        public byte EndColumn
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

        /// <remarks/>
        public DiagnosticsDiagnosticItemSpecific ItemSpecific
        {
            get
            {
                return this.itemSpecificField;
            }
            set
            {
                this.itemSpecificField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class DiagnosticsDiagnosticItemSpecific
    {

        private DiagnosticsDiagnosticItemSpecificOriginatorType originatorTypeField;

        private DiagnosticsDiagnosticItemSpecificFields fieldsField;

        /// <remarks/>
        public DiagnosticsDiagnosticItemSpecificOriginatorType OriginatorType
        {
            get
            {
                return this.originatorTypeField;
            }
            set
            {
                this.originatorTypeField = value;
            }
        }

        /// <remarks/>
        public DiagnosticsDiagnosticItemSpecificFields Fields
        {
            get
            {
                return this.fieldsField;
            }
            set
            {
                this.fieldsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class DiagnosticsDiagnosticItemSpecificOriginatorType
    {

        private byte aliasField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte alias
        {
            get
            {
                return this.aliasField;
            }
            set
            {
                this.aliasField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class DiagnosticsDiagnosticItemSpecificFields
    {

        private string extensionClassField;

        private byte maxFormatSpecifierField;

        private bool maxFormatSpecifierFieldSpecified;

        private string actualNameField;

        private string expectedNameField;

        private string newRunBaseMethodNameField;

        private string currentRunBaseMethodNameField;

        private string deprecatedNameField;

        private string newNameField;

        private string rootElementNameField;

        private string rootElementTypeField;

        private string objectNameField;

        private string selectBufferNameField;

        private ushort lineField;

        private bool lineFieldSpecified;

        private byte actualColumnField;

        private bool actualColumnFieldSpecified;

        private byte expectedColumnField;

        private bool expectedColumnFieldSpecified;

        private string relationPropertyField;

        private string actualValueField;

        private string expectedValueField;

        private string tableNameField;

        private string otherTableNameField;

        private string relationNumField;

        private string missingParameterField;

        private string methodNameField;

        private string fixableField;

        private string indexNameField;

        private string missingPropertiesField;

        private string relationshipField;

        private string tableNameField1;

        private string fieldNameField;

        private string edtNameField;

        private string extendedDataTypesField;

        private string methodNameField1;

        private string classNameField;

        private string controlNameField;

        private string formNameField;

        private string tabField;

        private string textField;

        private string formNameField1;

        private string controlNameField1;

        private string subPatternNameField;

        private decimal subPatternVersionField;

        private bool subPatternVersionFieldSpecified;

        private string parameterNameField;

        private string parameterField;

        private string tagField;

        private string returnValueField;

        private string localTypeNameField;

        private string localNameField;

        private string resourceTypeField;

        private string resourceNameField;

        private string labelReferenceField;

        private string entryPointNameField;

        private string entityNameField;

        private string otherEntityNamesField;

        private string entityFieldNameField;

        private object entityFieldEDTField;

        private string stagingTableNameField;

        private string stagingTableFieldEDTField;

        private string propertyNameField;

        private string propertyValueField;

        private string elementNameField;

        /// <remarks/>
        public string ExtensionClass
        {
            get
            {
                return this.extensionClassField;
            }
            set
            {
                this.extensionClassField = value;
            }
        }

        /// <remarks/>
        public byte MaxFormatSpecifier
        {
            get
            {
                return this.maxFormatSpecifierField;
            }
            set
            {
                this.maxFormatSpecifierField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MaxFormatSpecifierSpecified
        {
            get
            {
                return this.maxFormatSpecifierFieldSpecified;
            }
            set
            {
                this.maxFormatSpecifierFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string ActualName
        {
            get
            {
                return this.actualNameField;
            }
            set
            {
                this.actualNameField = value;
            }
        }

        /// <remarks/>
        public string ExpectedName
        {
            get
            {
                return this.expectedNameField;
            }
            set
            {
                this.expectedNameField = value;
            }
        }

        /// <remarks/>
        public string NewRunBaseMethodName
        {
            get
            {
                return this.newRunBaseMethodNameField;
            }
            set
            {
                this.newRunBaseMethodNameField = value;
            }
        }

        /// <remarks/>
        public string CurrentRunBaseMethodName
        {
            get
            {
                return this.currentRunBaseMethodNameField;
            }
            set
            {
                this.currentRunBaseMethodNameField = value;
            }
        }

        /// <remarks/>
        public string DeprecatedName
        {
            get
            {
                return this.deprecatedNameField;
            }
            set
            {
                this.deprecatedNameField = value;
            }
        }

        /// <remarks/>
        public string NewName
        {
            get
            {
                return this.newNameField;
            }
            set
            {
                this.newNameField = value;
            }
        }

        /// <remarks/>
        public string RootElementName
        {
            get
            {
                return this.rootElementNameField;
            }
            set
            {
                this.rootElementNameField = value;
            }
        }

        /// <remarks/>
        public string RootElementType
        {
            get
            {
                return this.rootElementTypeField;
            }
            set
            {
                this.rootElementTypeField = value;
            }
        }

        /// <remarks/>
        public string ObjectName
        {
            get
            {
                return this.objectNameField;
            }
            set
            {
                this.objectNameField = value;
            }
        }

        /// <remarks/>
        public string SelectBufferName
        {
            get
            {
                return this.selectBufferNameField;
            }
            set
            {
                this.selectBufferNameField = value;
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
        public byte ActualColumn
        {
            get
            {
                return this.actualColumnField;
            }
            set
            {
                this.actualColumnField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ActualColumnSpecified
        {
            get
            {
                return this.actualColumnFieldSpecified;
            }
            set
            {
                this.actualColumnFieldSpecified = value;
            }
        }

        /// <remarks/>
        public byte ExpectedColumn
        {
            get
            {
                return this.expectedColumnField;
            }
            set
            {
                this.expectedColumnField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ExpectedColumnSpecified
        {
            get
            {
                return this.expectedColumnFieldSpecified;
            }
            set
            {
                this.expectedColumnFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string RelationProperty
        {
            get
            {
                return this.relationPropertyField;
            }
            set
            {
                this.relationPropertyField = value;
            }
        }

        /// <remarks/>
        public string ActualValue
        {
            get
            {
                return this.actualValueField;
            }
            set
            {
                this.actualValueField = value;
            }
        }

        /// <remarks/>
        public string ExpectedValue
        {
            get
            {
                return this.expectedValueField;
            }
            set
            {
                this.expectedValueField = value;
            }
        }

        /// <remarks/>
        public string tableName
        {
            get
            {
                return this.tableNameField;
            }
            set
            {
                this.tableNameField = value;
            }
        }

        /// <remarks/>
        public string otherTableName
        {
            get
            {
                return this.otherTableNameField;
            }
            set
            {
                this.otherTableNameField = value;
            }
        }

        /// <remarks/>
        public string relationNum
        {
            get
            {
                return this.relationNumField;
            }
            set
            {
                this.relationNumField = value;
            }
        }

        /// <remarks/>
        public string MissingParameter
        {
            get
            {
                return this.missingParameterField;
            }
            set
            {
                this.missingParameterField = value;
            }
        }

        /// <remarks/>
        public string MethodName
        {
            get
            {
                return this.methodNameField;
            }
            set
            {
                this.methodNameField = value;
            }
        }

        /// <remarks/>
        public string Fixable
        {
            get
            {
                return this.fixableField;
            }
            set
            {
                this.fixableField = value;
            }
        }

        /// <remarks/>
        public string IndexName
        {
            get
            {
                return this.indexNameField;
            }
            set
            {
                this.indexNameField = value;
            }
        }

        /// <remarks/>
        public string MissingProperties
        {
            get
            {
                return this.missingPropertiesField;
            }
            set
            {
                this.missingPropertiesField = value;
            }
        }

        /// <remarks/>
        public string Relationship
        {
            get
            {
                return this.relationshipField;
            }
            set
            {
                this.relationshipField = value;
            }
        }

        /// <remarks/>
        public string TableName
        {
            get
            {
                return this.tableNameField1;
            }
            set
            {
                this.tableNameField1 = value;
            }
        }

        /// <remarks/>
        public string FieldName
        {
            get
            {
                return this.fieldNameField;
            }
            set
            {
                this.fieldNameField = value;
            }
        }

        /// <remarks/>
        public string EdtName
        {
            get
            {
                return this.edtNameField;
            }
            set
            {
                this.edtNameField = value;
            }
        }

        /// <remarks/>
        public string ExtendedDataTypes
        {
            get
            {
                return this.extendedDataTypesField;
            }
            set
            {
                this.extendedDataTypesField = value;
            }
        }

        /// <remarks/>
        public string methodName
        {
            get
            {
                return this.methodNameField1;
            }
            set
            {
                this.methodNameField1 = value;
            }
        }

        /// <remarks/>
        public string className
        {
            get
            {
                return this.classNameField;
            }
            set
            {
                this.classNameField = value;
            }
        }

        /// <remarks/>
        public string controlName
        {
            get
            {
                return this.controlNameField;
            }
            set
            {
                this.controlNameField = value;
            }
        }

        /// <remarks/>
        public string formName
        {
            get
            {
                return this.formNameField;
            }
            set
            {
                this.formNameField = value;
            }
        }

        /// <remarks/>
        public string Tab
        {
            get
            {
                return this.tabField;
            }
            set
            {
                this.tabField = value;
            }
        }

        /// <remarks/>
        public string Text
        {
            get
            {
                return this.textField;
            }
            set
            {
                this.textField = value;
            }
        }

        /// <remarks/>
        public string FormName
        {
            get
            {
                return this.formNameField1;
            }
            set
            {
                this.formNameField1 = value;
            }
        }

        /// <remarks/>
        public string ControlName
        {
            get
            {
                return this.controlNameField1;
            }
            set
            {
                this.controlNameField1 = value;
            }
        }

        /// <remarks/>
        public string SubPatternName
        {
            get
            {
                return this.subPatternNameField;
            }
            set
            {
                this.subPatternNameField = value;
            }
        }

        /// <remarks/>
        public decimal SubPatternVersion
        {
            get
            {
                return this.subPatternVersionField;
            }
            set
            {
                this.subPatternVersionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SubPatternVersionSpecified
        {
            get
            {
                return this.subPatternVersionFieldSpecified;
            }
            set
            {
                this.subPatternVersionFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string ParameterName
        {
            get
            {
                return this.parameterNameField;
            }
            set
            {
                this.parameterNameField = value;
            }
        }

        /// <remarks/>
        public string Parameter
        {
            get
            {
                return this.parameterField;
            }
            set
            {
                this.parameterField = value;
            }
        }

        /// <remarks/>
        public string Tag
        {
            get
            {
                return this.tagField;
            }
            set
            {
                this.tagField = value;
            }
        }

        /// <remarks/>
        public string ReturnValue
        {
            get
            {
                return this.returnValueField;
            }
            set
            {
                this.returnValueField = value;
            }
        }

        /// <remarks/>
        public string LocalTypeName
        {
            get
            {
                return this.localTypeNameField;
            }
            set
            {
                this.localTypeNameField = value;
            }
        }

        /// <remarks/>
        public string LocalName
        {
            get
            {
                return this.localNameField;
            }
            set
            {
                this.localNameField = value;
            }
        }

        /// <remarks/>
        public string ResourceType
        {
            get
            {
                return this.resourceTypeField;
            }
            set
            {
                this.resourceTypeField = value;
            }
        }

        /// <remarks/>
        public string ResourceName
        {
            get
            {
                return this.resourceNameField;
            }
            set
            {
                this.resourceNameField = value;
            }
        }

        /// <remarks/>
        public string labelReference
        {
            get
            {
                return this.labelReferenceField;
            }
            set
            {
                this.labelReferenceField = value;
            }
        }

        /// <remarks/>
        public string EntryPointName
        {
            get
            {
                return this.entryPointNameField;
            }
            set
            {
                this.entryPointNameField = value;
            }
        }

        /// <remarks/>
        public string EntityName
        {
            get
            {
                return this.entityNameField;
            }
            set
            {
                this.entityNameField = value;
            }
        }

        /// <remarks/>
        public string OtherEntityNames
        {
            get
            {
                return this.otherEntityNamesField;
            }
            set
            {
                this.otherEntityNamesField = value;
            }
        }

        /// <remarks/>
        public string EntityFieldName
        {
            get
            {
                return this.entityFieldNameField;
            }
            set
            {
                this.entityFieldNameField = value;
            }
        }

        /// <remarks/>
        public object EntityFieldEDT
        {
            get
            {
                return this.entityFieldEDTField;
            }
            set
            {
                this.entityFieldEDTField = value;
            }
        }

        /// <remarks/>
        public string StagingTableName
        {
            get
            {
                return this.stagingTableNameField;
            }
            set
            {
                this.stagingTableNameField = value;
            }
        }

        /// <remarks/>
        public string StagingTableFieldEDT
        {
            get
            {
                return this.stagingTableFieldEDTField;
            }
            set
            {
                this.stagingTableFieldEDTField = value;
            }
        }

        /// <remarks/>
        public string PropertyName
        {
            get
            {
                return this.propertyNameField;
            }
            set
            {
                this.propertyNameField = value;
            }
        }

        /// <remarks/>
        public string PropertyValue
        {
            get
            {
                return this.propertyValueField;
            }
            set
            {
                this.propertyValueField = value;
            }
        }

        /// <remarks/>
        public string ElementName
        {
            get
            {
                return this.elementNameField;
            }
            set
            {
                this.elementNameField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class DiagnosticsAlias
    {

        private string assemblyField;

        private string nsField;

        private byte valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string assembly
        {
            get
            {
                return this.assemblyField;
            }
            set
            {
                this.assemblyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ns
        {
            get
            {
                return this.nsField;
            }
            set
            {
                this.nsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public byte Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }
}
