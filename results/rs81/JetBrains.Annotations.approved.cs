[assembly: System.CLSCompliantAttribute(true)]
[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]

namespace JetBrains.Annotations
{
    
    [System.AttributeUsageAttribute(System.AttributeTargets.Class | System.AttributeTargets.All, AllowMultiple=true, Inherited=true)]
    public class AspChildControlTypeAttribute : System.Attribute
    {
        public AspChildControlTypeAttribute(string tagName, System.Type controlType) { }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Method | System.AttributeTargets.Property | System.AttributeTargets.All, Inherited=true)]
    public class AspDataFieldAttribute : System.Attribute { }
    [System.AttributeUsageAttribute(System.AttributeTargets.Method | System.AttributeTargets.Property | System.AttributeTargets.All, Inherited=true)]
    public class AspDataFieldsAttribute : System.Attribute { }
    [System.AttributeUsageAttribute(System.AttributeTargets.Property | System.AttributeTargets.All, Inherited=true)]
    public class AspMethodPropertyAttribute : System.Attribute { }
    [System.AttributeUsageAttribute(System.AttributeTargets.Method | System.AttributeTargets.Parameter | System.AttributeTargets.All)]
    public sealed class AspMvcActionAttribute : System.Attribute
    {
        public AspMvcActionAttribute([JetBrains.Annotations.NotNullAttribute()] string anonymousProperty) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public string AnonymousProperty { get; }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Property | System.AttributeTargets.Parameter | System.AttributeTargets.All)]
    public sealed class AspMvcActionSelectorAttribute : System.Attribute { }
    [System.AttributeUsageAttribute(System.AttributeTargets.Parameter | System.AttributeTargets.All)]
    public sealed class AspMvcAreaAttribute : JetBrains.Annotations.PathReferenceAttribute
    {
        public AspMvcAreaAttribute([JetBrains.Annotations.NotNullAttribute()] string anonymousProperty) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public string AnonymousProperty { get; }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Method | System.AttributeTargets.Parameter | System.AttributeTargets.All)]
    public sealed class AspMvcControllerAttribute : System.Attribute
    {
        public AspMvcControllerAttribute([JetBrains.Annotations.NotNullAttribute()] string anonymousProperty) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public string AnonymousProperty { get; }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Parameter | System.AttributeTargets.All)]
    public sealed class AspMvcDisplayTemplateAttribute : System.Attribute { }
    [System.AttributeUsageAttribute(System.AttributeTargets.Parameter | System.AttributeTargets.All)]
    public sealed class AspMvcEditorTemplateAttribute : System.Attribute { }
    [System.AttributeUsageAttribute(System.AttributeTargets.Parameter | System.AttributeTargets.All)]
    public sealed class AspMvcMasterAttribute : System.Attribute { }
    [System.AttributeUsageAttribute(System.AttributeTargets.Parameter | System.AttributeTargets.All)]
    public sealed class AspMvcModelTypeAttribute : System.Attribute { }
    [System.AttributeUsageAttribute(System.AttributeTargets.Method | System.AttributeTargets.Parameter | System.AttributeTargets.All)]
    public sealed class AspMvcPartialViewAttribute : JetBrains.Annotations.PathReferenceAttribute { }
    [System.AttributeUsageAttribute(System.AttributeTargets.Class | System.AttributeTargets.Method | System.AttributeTargets.All)]
    public sealed class AspMvcSupressViewErrorAttribute : System.Attribute { }
    [System.AttributeUsageAttribute(System.AttributeTargets.Parameter | System.AttributeTargets.All)]
    public sealed class AspMvcTemplateAttribute : System.Attribute { }
    [System.AttributeUsageAttribute(System.AttributeTargets.Method | System.AttributeTargets.Parameter | System.AttributeTargets.All)]
    public sealed class AspMvcViewAttribute : JetBrains.Annotations.PathReferenceAttribute { }
    [System.AttributeUsageAttribute(System.AttributeTargets.Class | System.AttributeTargets.All, AllowMultiple=true, Inherited=true)]
    public class AspRequiredAttributeAttribute : System.Attribute
    {
        public AspRequiredAttributeAttribute(string attribute) { }
        public string Attribute { get; }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Property | System.AttributeTargets.All, Inherited=true)]
    public class AspTypePropertyAttribute : System.Attribute
    {
        public AspTypePropertyAttribute(bool createConstructorReferences) { }
        [JetBrains.Annotations.PublicAPIAttribute()]
        public bool CreateConstructorReferences { get; }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Parameter | System.AttributeTargets.All, AllowMultiple=false, Inherited=true)]
    [System.ObsoleteAttribute("Use ContractAnnotationAttribute instead")]
    public sealed class AssertionConditionAttribute : System.Attribute
    {
        public AssertionConditionAttribute(JetBrains.Annotations.AssertionConditionType conditionType) { }
        public JetBrains.Annotations.AssertionConditionType ConditionType { get; }
    }
    public enum AssertionConditionType
    {
        IS_TRUE = 0,
        IS_FALSE = 1,
        IS_NULL = 2,
        IS_NOT_NULL = 3,
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Method | System.AttributeTargets.All, AllowMultiple=false, Inherited=true)]
    public sealed class AssertionMethodAttribute : System.Attribute { }
    [JetBrains.Annotations.BaseTypeRequiredAttribute(typeof(System.Attribute))]
    [System.AttributeUsageAttribute(System.AttributeTargets.Class | System.AttributeTargets.All, AllowMultiple=true, Inherited=true)]
    public sealed class BaseTypeRequiredAttribute : System.Attribute
    {
        public BaseTypeRequiredAttribute([JetBrains.Annotations.NotNullAttribute()] System.Type baseType) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public System.Type BaseType { get; }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Method | System.AttributeTargets.Property | System.AttributeTargets.Field | System.AttributeTargets.Parameter | System.AttributeTargets.Delegate | System.AttributeTargets.All, AllowMultiple=false, Inherited=true)]
    public sealed class CanBeNullAttribute : System.Attribute { }
    [System.AttributeUsageAttribute(System.AttributeTargets.Class | System.AttributeTargets.Struct | System.AttributeTargets.Interface | System.AttributeTargets.All, AllowMultiple=false, Inherited=true)]
    public sealed class CannotApplyEqualityOperatorAttribute : System.Attribute { }
    [System.AttributeUsageAttribute(System.AttributeTargets.Method | System.AttributeTargets.All, AllowMultiple=true, Inherited=true)]
    public sealed class ContractAnnotationAttribute : System.Attribute
    {
        public ContractAnnotationAttribute([JetBrains.Annotations.NotNullAttribute()] string contract) { }
        public ContractAnnotationAttribute([JetBrains.Annotations.NotNullAttribute()] string contract, bool forceFullStates) { }
        public string Contract { get; }
        public bool ForceFullStates { get; }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Property | System.AttributeTargets.Field | System.AttributeTargets.Parameter | System.AttributeTargets.All, Inherited=true)]
    public sealed class HtmlAttributeValueAttribute : System.Attribute
    {
        public HtmlAttributeValueAttribute([JetBrains.Annotations.NotNullAttribute()] string name) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public string Name { get; }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Property | System.AttributeTargets.Field | System.AttributeTargets.Parameter | System.AttributeTargets.All, Inherited=true)]
    public sealed class HtmlElementAttributesAttribute : System.Attribute
    {
        public HtmlElementAttributesAttribute([JetBrains.Annotations.NotNullAttribute()] string name) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public string Name { get; }
    }
    [System.FlagsAttribute()]
    public enum ImplicitUseKindFlags
    {
        Default = 7,
        Access = 1,
        Assign = 2,
        InstantiatedWithFixedConstructorSignature = 4,
        InstantiatedNoFixedConstructorSignature = 8,
    }
    [System.FlagsAttribute()]
    public enum ImplicitUseTargetFlags
    {
        Default = 1,
        Itself = 1,
        Members = 2,
        WithMembers = 3,
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Parameter | System.AttributeTargets.All, Inherited=true)]
    public sealed class InstantHandleAttribute : System.Attribute { }
    [System.AttributeUsageAttribute(System.AttributeTargets.Parameter | System.AttributeTargets.All, AllowMultiple=false, Inherited=true)]
    public sealed class InvokerParameterNameAttribute : System.Attribute { }
    [System.AttributeUsageAttribute(System.AttributeTargets.Method | System.AttributeTargets.All)]
    public sealed class LinqTunnelAttribute : System.Attribute { }
    [System.AttributeUsageAttribute(System.AttributeTargets.Assembly | System.AttributeTargets.Module | System.AttributeTargets.Class | System.AttributeTargets.Struct | System.AttributeTargets.Enum | System.AttributeTargets.Constructor | System.AttributeTargets.Method | System.AttributeTargets.Property | System.AttributeTargets.Field | System.AttributeTargets.Event | System.AttributeTargets.Interface | System.AttributeTargets.Parameter | System.AttributeTargets.Delegate | System.AttributeTargets.ReturnValue | System.AttributeTargets.GenericParameter | System.AttributeTargets.All, AllowMultiple=false, Inherited=true)]
    public sealed class LocalizationRequiredAttribute : System.Attribute
    {
        public LocalizationRequiredAttribute() { }
        public LocalizationRequiredAttribute(bool required) { }
        public bool Required { get; }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Class | System.AttributeTargets.All, AllowMultiple=false, Inherited=true)]
    public sealed class MeansImplicitUseAttribute : System.Attribute
    {
        public MeansImplicitUseAttribute() { }
        public MeansImplicitUseAttribute(JetBrains.Annotations.ImplicitUseKindFlags useKindFlags) { }
        public MeansImplicitUseAttribute(JetBrains.Annotations.ImplicitUseTargetFlags targetFlags) { }
        public MeansImplicitUseAttribute(JetBrains.Annotations.ImplicitUseKindFlags useKindFlags, JetBrains.Annotations.ImplicitUseTargetFlags targetFlags) { }
        [JetBrains.Annotations.UsedImplicitlyAttribute()]
        public JetBrains.Annotations.ImplicitUseTargetFlags TargetFlags { get; }
        [JetBrains.Annotations.UsedImplicitlyAttribute()]
        public JetBrains.Annotations.ImplicitUseKindFlags UseKindFlags { get; }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Parameter | System.AttributeTargets.All)]
    public sealed class NoEnumerationAttribute : System.Attribute { }
    [System.AttributeUsageAttribute(System.AttributeTargets.Method | System.AttributeTargets.All, AllowMultiple=false, Inherited=true)]
    public sealed class NotifyPropertyChangedInvocatorAttribute : System.Attribute
    {
        public NotifyPropertyChangedInvocatorAttribute(string parameterName) { }
        public string ParameterName { get; }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Method | System.AttributeTargets.Property | System.AttributeTargets.Field | System.AttributeTargets.Parameter | System.AttributeTargets.Delegate | System.AttributeTargets.All, AllowMultiple=false, Inherited=true)]
    public sealed class NotNullAttribute : System.Attribute { }
    [System.AttributeUsageAttribute(System.AttributeTargets.Parameter | System.AttributeTargets.All)]
    public class PathReferenceAttribute : System.Attribute
    {
        public PathReferenceAttribute([JetBrains.Annotations.PathReferenceAttribute()] string basePath) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public string BasePath { get; }
    }
    [JetBrains.Annotations.MeansImplicitUseAttribute()]
    public sealed class PublicAPIAttribute : System.Attribute
    {
        public PublicAPIAttribute([JetBrains.Annotations.NotNullAttribute()] string comment) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public string Comment { get; }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Method | System.AttributeTargets.All, Inherited=true)]
    public sealed class PureAttribute : System.Attribute { }
    [System.AttributeUsageAttribute(System.AttributeTargets.Method | System.AttributeTargets.All, Inherited=true)]
    public sealed class RazorHelperCommonAttribute : System.Attribute { }
    [System.AttributeUsageAttribute(System.AttributeTargets.Assembly | System.AttributeTargets.All)]
    public sealed class RazorImportNamespaceAttribute : System.Attribute
    {
        public RazorImportNamespaceAttribute(string name) { }
        [JetBrains.Annotations.PublicAPIAttribute()]
        public string Name { get; }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Property | System.AttributeTargets.All, Inherited=true)]
    public sealed class RazorLayoutAttribute : System.Attribute { }
    [System.AttributeUsageAttribute(System.AttributeTargets.Method | System.AttributeTargets.Parameter | System.AttributeTargets.All, Inherited=true)]
    public sealed class RazorSectionAttribute : System.Attribute { }
    [System.AttributeUsageAttribute(System.AttributeTargets.Method | System.AttributeTargets.All, Inherited=true)]
    public sealed class RazorWriteLiteralMethodAttribute : System.Attribute { }
    [System.AttributeUsageAttribute(System.AttributeTargets.Method | System.AttributeTargets.All, Inherited=true)]
    public sealed class RazorWriteMethodAttribute : System.Attribute { }
    [System.AttributeUsageAttribute(System.AttributeTargets.Parameter | System.AttributeTargets.All, Inherited=true)]
    public sealed class RazorWriteMethodParameterAttribute : System.Attribute { }
    [System.AttributeUsageAttribute(System.AttributeTargets.Constructor | System.AttributeTargets.Method | System.AttributeTargets.All, AllowMultiple=false, Inherited=true)]
    public sealed class StringFormatMethodAttribute : System.Attribute
    {
        public StringFormatMethodAttribute(string formatParameterName) { }
        public string FormatParameterName { get; }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Method | System.AttributeTargets.All, AllowMultiple=false, Inherited=true)]
    [System.ObsoleteAttribute("Use ContractAnnotationAttribute instead")]
    public sealed class TerminatesProgramAttribute : System.Attribute { }
    [System.AttributeUsageAttribute(System.AttributeTargets.Assembly | System.AttributeTargets.Module | System.AttributeTargets.Class | System.AttributeTargets.Struct | System.AttributeTargets.Enum | System.AttributeTargets.Constructor | System.AttributeTargets.Method | System.AttributeTargets.Property | System.AttributeTargets.Field | System.AttributeTargets.Event | System.AttributeTargets.Interface | System.AttributeTargets.Parameter | System.AttributeTargets.Delegate | System.AttributeTargets.ReturnValue | System.AttributeTargets.GenericParameter | System.AttributeTargets.All, AllowMultiple=false, Inherited=true)]
    public sealed class UsedImplicitlyAttribute : System.Attribute
    {
        public UsedImplicitlyAttribute() { }
        public UsedImplicitlyAttribute(JetBrains.Annotations.ImplicitUseKindFlags useKindFlags) { }
        public UsedImplicitlyAttribute(JetBrains.Annotations.ImplicitUseTargetFlags targetFlags) { }
        public UsedImplicitlyAttribute(JetBrains.Annotations.ImplicitUseKindFlags useKindFlags, JetBrains.Annotations.ImplicitUseTargetFlags targetFlags) { }
        public JetBrains.Annotations.ImplicitUseTargetFlags TargetFlags { get; }
        public JetBrains.Annotations.ImplicitUseKindFlags UseKindFlags { get; }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Property | System.AttributeTargets.All, Inherited=true)]
    public sealed class XamlItemBindingOfItemsControlAttribute : System.Attribute { }
    [System.AttributeUsageAttribute(System.AttributeTargets.Class | System.AttributeTargets.All, Inherited=true)]
    public sealed class XamlItemsControlAttribute : System.Attribute { }
}