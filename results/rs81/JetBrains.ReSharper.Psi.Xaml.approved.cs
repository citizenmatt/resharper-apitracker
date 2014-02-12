[assembly: JetBrains.UI.Icons.CompiledIcons.CompiledIconsPackAttribute(IconNames=new string[] {
        "XamlAttachedProperty",
        "XamlTemplateField",
        "XamlPredefinedAttributeElement",
        "XamlAttachedEvent",
        "XamlFile",
        "XamlPredefinedObjectElement",
        "XamlMarkupExtension",
        "XamlResource",
        "XamlNamespaceAlias"}, IconPackResourceIdentification="JetBrains.ReSharper.Psi.Xaml;component/resources/PsiXamlThemedIcons/ThemedIcons.P" +
    "siXaml.Generated.Xaml")]
[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]
[assembly: System.Windows.Markup.XmlnsDefinitionAttribute("urn:shemas-jetbrains-com:ui-application-icons-psi-xaml", "JetBrains.ReSharper.Psi.Xaml.Resources")]

namespace JetBrains.ReSharper.Psi.Xaml.Caches
{
    
    public interface IXamlAssemblyResourcesCache
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        string GetBamlPathForType([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IPsiAssembly assembly, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IClrTypeName typeName);
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.IList<JetBrains.Decompiler.Baml.CacheBuilder.IResourceDictionaryRecord> GetBamlResources([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IPsiAssembly assembly, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.FileSystemPath bamlPath);
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.ICollection<JetBrains.Util.FileSystemPath> GetResourceFiles([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IPsiAssembly assembly);
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.ICollection<JetBrains.Util.FileSystemPath> GetResourceFolders([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IPsiAssembly assembly);
        bool HasResources([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IPsiAssembly assembly);
    }
}
namespace JetBrains.ReSharper.Psi.Xaml.CodeStyle
{
    
    [JetBrains.ReSharper.Psi.CodeStyle.SettingsUpgrade.CodeStyleSettingsAttribute("Xaml")]
    [System.ObsoleteAttribute("Deprecated, use XamlNamingSettingsKey")]
    public class XamlCodeStyleSettings : JetBrains.Application.Configuration.IXmlReadable, System.ICloneable
    {
        public XamlCodeStyleSettings() { }
        [System.ObsoleteAttribute("Deprecated, use XamlNamingSettingsKey")]
        public JetBrains.ReSharper.Psi.Xaml.Naming.XamlNamingStyleSettings NamingSettings { get; }
        public object Clone() { }
        public void ReadFromXml(System.Xml.XmlElement element) { }
    }
}
namespace JetBrains.ReSharper.Psi.Xaml.DeclaredElements
{
    
    public interface IXamlAttachedEvent : JetBrains.ReSharper.Psi.IAccessRightsOwner, JetBrains.ReSharper.Psi.IAttributesOwner, JetBrains.ReSharper.Psi.IAttributesSet, JetBrains.ReSharper.Psi.IClrDeclaredElement, JetBrains.ReSharper.Psi.IDeclaredElement, JetBrains.ReSharper.Psi.IEvent, JetBrains.ReSharper.Psi.IModifiersOwner, JetBrains.ReSharper.Psi.IOverridableMember, JetBrains.ReSharper.Psi.ITypeMember, JetBrains.ReSharper.Psi.ITypeOwner, JetBrains.ReSharper.Psi.IXmlDocIdOwner { }
    public interface IXamlAttachedProperty : JetBrains.ReSharper.Psi.IAccessRightsOwner, JetBrains.ReSharper.Psi.IAttributesOwner, JetBrains.ReSharper.Psi.IAttributesSet, JetBrains.ReSharper.Psi.IClrDeclaredElement, JetBrains.ReSharper.Psi.IDeclaredElement, JetBrains.ReSharper.Psi.IModifiersOwner, JetBrains.ReSharper.Psi.IOverridableMember, JetBrains.ReSharper.Psi.IParametersOwner, JetBrains.ReSharper.Psi.IProperty, JetBrains.ReSharper.Psi.ITypeMember, JetBrains.ReSharper.Psi.ITypeOwner, JetBrains.ReSharper.Psi.IXmlDocIdOwner { }
    public interface IXamlAttributeDeclaredElement : JetBrains.ReSharper.Psi.IDeclaredElement, JetBrains.ReSharper.Psi.Xaml.DeclaredElements.IXamlDeclaredElement, JetBrains.ReSharper.Psi.Xaml.DeclaredElements.IXamlPredefinedDeclaredElement { }
    public interface IXamlDeclaredElement : JetBrains.ReSharper.Psi.IDeclaredElement { }
    public interface IXamlDeclaredElementsCache
    {
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Xaml.DeclaredElements.IXamlObjectDeclaredElement Choice { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Xaml.DeclaredElements.IXamlAttributeDeclaredElement ChoiceRequires { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Xaml.DeclaredElements.IXamlAttributeDeclaredElement DataContextAttribute { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Xaml.DeclaredElements.IXamlObjectDeclaredElement DesignData { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Xaml.DeclaredElements.IXamlAttributeDeclaredElement DesignDataSourceAttribute { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Xaml.DeclaredElements.IXamlAttributeDeclaredElement DesignDesignSourceAttribute { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Xaml.DeclaredElements.IXamlAttributeDeclaredElement DesignHeight { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Xaml.DeclaredElements.IXamlObjectDeclaredElement DesignInstance { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Xaml.DeclaredElements.IXamlAttributeDeclaredElement DesignInstanceCreateListAttribute { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Xaml.DeclaredElements.IXamlAttributeDeclaredElement DesignInstanceIsDesignTimeCreatableAttribute { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Xaml.DeclaredElements.IXamlAttributeDeclaredElement DesignInstanceTypeAttribute { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Xaml.DeclaredElements.IXamlAttributeDeclaredElement DesignSourceAttribute { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Xaml.DeclaredElements.IXamlAttributeDeclaredElement DesignWidth { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Xaml.DeclaredElements.IXamlAttributeDeclaredElement FreezeAttribute { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Xaml.DeclaredElements.IXamlAttributeDeclaredElement IgnorableAttribute { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Xaml.DeclaredElements.IXamlAttributeDeclaredElement ProcessContentAttribute { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Xaml.DeclaredElements.IXamlAttributeDeclaredElement XArgumentsAttribute { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Xaml.DeclaredElements.IXamlObjectDeclaredElement XArgumentsElement { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Xaml.DeclaredElements.IXamlObjectDeclaredElement XAttributes { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Xaml.DeclaredElements.IXamlObjectDeclaredElement XClassAttributes { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Xaml.DeclaredElements.IXamlAttributeDeclaredElement XFactoryMethodAttribute { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Xaml.DeclaredElements.IXamlObjectDeclaredElement XFactoryMethodElement { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Xaml.DeclaredElements.IXamlObjectDeclaredElement XMembers { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Xaml.DeclaredElements.IXamlNamespaceAlias XmlNamespaceAlias { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Xaml.DeclaredElements.IXamlNamespaceAlias XmlnsNamespaceAlias { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Xaml.DeclaredElements.IXamlObjectDeclaredElement XProperty { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Xaml.DeclaredElements.IXamlAttributeDeclaredElement XPropertyAttributes { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Xaml.DeclaredElements.IXamlAttributeDeclaredElement> GetAttributeDeclaredElements(string uri);
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Xaml.DeclaredElements.IXamlObjectDeclaredElement> GetObjectDeclaredElements(string uri);
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.IEnumerable<string> GetXmlns();
    }
    public interface IXamlExternalResource : JetBrains.ReSharper.Psi.IDeclaredElement, JetBrains.ReSharper.Psi.Xaml.DeclaredElements.IXamlDeclaredElement, JetBrains.ReSharper.Psi.Xaml.DeclaredElements.IXamlResource
    {
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Modules.IPsiModule ExternalModule { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.Util.FileSystemPath ResourcePath { get; }
    }
    public interface IXamlField : JetBrains.ReSharper.Psi.IAccessRightsOwner, JetBrains.ReSharper.Psi.IAttributesOwner, JetBrains.ReSharper.Psi.IAttributesSet, JetBrains.ReSharper.Psi.IClrDeclaredElement, JetBrains.ReSharper.Psi.IConstantValueOwner, JetBrains.ReSharper.Psi.IDeclaredElement, JetBrains.ReSharper.Psi.IField, JetBrains.ReSharper.Psi.IModifiersOwner, JetBrains.ReSharper.Psi.ITypeMember, JetBrains.ReSharper.Psi.ITypeOwner, JetBrains.ReSharper.Psi.IXmlDocIdOwner, JetBrains.ReSharper.Psi.Xaml.DeclaredElements.IXamlDeclaredElement { }
    public interface IXamlMarkupDeclaredElement : JetBrains.ReSharper.Psi.IDeclaredElement, JetBrains.ReSharper.Psi.Xaml.DeclaredElements.IXamlDeclaredElement, JetBrains.ReSharper.Psi.Xaml.DeclaredElements.IXamlObjectDeclaredElementWithType, JetBrains.ReSharper.Psi.Xaml.DeclaredElements.IXamlPredefinedDeclaredElement { }
    public interface IXamlNamespaceAlias : JetBrains.ReSharper.Psi.IDeclaredElement, JetBrains.ReSharper.Psi.Xaml.DeclaredElements.IXamlDeclaredElement
    {
        bool CanBeIgnored { get; }
        bool IsCLRNamespaceAlias { get; }
        bool IsDefault { get; }
        bool IsUsingAlias { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Modules.IPsiModule Module { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        string Value { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Xaml.Tree.INamespaceAlias GetDeclaration();
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Xaml.Tree.ReferencedNamespace> GetReferencedNamespaces();
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Modules.IPsiModule GetTargetModule();
    }
    public interface IXamlObjectDeclaredElement : JetBrains.ReSharper.Psi.IDeclaredElement, JetBrains.ReSharper.Psi.Xaml.DeclaredElements.IXamlDeclaredElement, JetBrains.ReSharper.Psi.Xaml.DeclaredElements.IXamlPredefinedDeclaredElement
    {
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Xaml.DeclaredElements.IXamlAttributeDeclaredElement> GetPredefinedAttributes();
    }
    public interface IXamlObjectDeclaredElementWithType : JetBrains.ReSharper.Psi.IDeclaredElement, JetBrains.ReSharper.Psi.Xaml.DeclaredElements.IXamlDeclaredElement, JetBrains.ReSharper.Psi.Xaml.DeclaredElements.IXamlPredefinedDeclaredElement
    {
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext ResolveContext { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IDeclaredType GetType([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode context);
    }
    public interface IXamlPredefinedDeclaredElement : JetBrains.ReSharper.Psi.IDeclaredElement, JetBrains.ReSharper.Psi.Xaml.DeclaredElements.IXamlDeclaredElement
    {
        [JetBrains.Annotations.NotNullAttribute()]
        string DefaultXmlNsName { get; }
        JetBrains.ReSharper.Psi.Xaml.Impl.XamlLanguageLevel LanguageLevel { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Modules.IPsiModule Module { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        string XmlNsUri { get; }
        bool CanReferenceDeclaredElement(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement);
    }
    public interface IXamlPredefinedNamespaceAlias : JetBrains.ReSharper.Psi.IDeclaredElement, JetBrains.ReSharper.Psi.Xaml.DeclaredElements.IXamlDeclaredElement, JetBrains.ReSharper.Psi.Xaml.DeclaredElements.IXamlNamespaceAlias, JetBrains.ReSharper.Psi.Xaml.DeclaredElements.IXamlPredefinedDeclaredElement
    {
        [JetBrains.Annotations.NotNullAttribute()]
        new JetBrains.ReSharper.Psi.Modules.IPsiModule Module { get; }
    }
    public interface IXamlPredefinedResourcesCache
    {
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetSymbolTable();
    }
    public interface IXamlPredefinedTypeDeclaredElement : JetBrains.ReSharper.Psi.IDeclaredElement, JetBrains.ReSharper.Psi.Xaml.DeclaredElements.IXamlDeclaredElement, JetBrains.ReSharper.Psi.Xaml.DeclaredElements.IXamlObjectDeclaredElementWithType, JetBrains.ReSharper.Psi.Xaml.DeclaredElements.IXamlPredefinedDeclaredElement { }
    public interface IXamlProperty : JetBrains.ReSharper.Psi.IAccessRightsOwner, JetBrains.ReSharper.Psi.IAttributesOwner, JetBrains.ReSharper.Psi.IAttributesSet, JetBrains.ReSharper.Psi.IClrDeclaredElement, JetBrains.ReSharper.Psi.IDeclaredElement, JetBrains.ReSharper.Psi.IModifiersOwner, JetBrains.ReSharper.Psi.IOverridableMember, JetBrains.ReSharper.Psi.IParametersOwner, JetBrains.ReSharper.Psi.IProperty, JetBrains.ReSharper.Psi.ITypeMember, JetBrains.ReSharper.Psi.ITypeOwner, JetBrains.ReSharper.Psi.IXmlDocIdOwner, JetBrains.ReSharper.Psi.Xaml.DeclaredElements.IXamlDeclaredElement { }
    public interface IXamlResource : JetBrains.ReSharper.Psi.IDeclaredElement, JetBrains.ReSharper.Psi.Xaml.DeclaredElements.IXamlDeclaredElement
    {
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IType ResourceType { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.IDeclaredElement StaticMemberKey { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.IType TargetType { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.IType TypeKey { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Xaml.Tree.IResourceDeclaration GetDeclaration();
    }
    public interface IXamlTemplateField : JetBrains.ReSharper.Psi.IClrDeclaredElement, JetBrains.ReSharper.Psi.IDeclaredElement, JetBrains.ReSharper.Psi.ITypeOwner, JetBrains.ReSharper.Psi.Xaml.DeclaredElements.IXamlDeclaredElement { }
    [JetBrains.ReSharper.Psi.PsiComponentAttribute()]
    public class XamlDeclaredElementsCache : JetBrains.ReSharper.Psi.Xaml.Impl.Resolve.XamlModuleTypeCache<JetBrains.ReSharper.Psi.Xaml.DeclaredElements.IXamlDeclaredElementsCache, JetBrains.ReSharper.Psi.Xaml.DeclaredElements.XamlDeclaredElementsCache>
    {
        public XamlDeclaredElementsCache([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Modules.IPsiModules psiModules, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.ChangeManager changeManager) { }
    }
    public class static XamlDeclaredElementsCacheExtensions
    {
        public static System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Xaml.DeclaredElements.IXamlAttributeDeclaredElement> GetAttributeDeclaredElements([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Xaml.DeclaredElements.IXamlDeclaredElementsCache cache, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xaml.DeclaredElements.IXamlNamespaceAlias alias) { }
        public static System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Xaml.DeclaredElements.IXamlObjectDeclaredElement> GetObjectDeclaredElements([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Xaml.DeclaredElements.IXamlDeclaredElementsCache cache, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xaml.DeclaredElements.IXamlNamespaceAlias alias) { }
        public static System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Xaml.DeclaredElements.IXamlObjectDeclaredElementWithType> GetObjectDeclaredElementsByTypeElement([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Xaml.DeclaredElements.IXamlDeclaredElementsCache cache, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.ITypeElement typeElement) { }
    }
    [JetBrains.ReSharper.Psi.PsiComponentAttribute()]
    public sealed class XamlPredefinedResourcesCache : JetBrains.ReSharper.Psi.Xaml.Impl.Resolve.XamlModuleTypeCache<JetBrains.ReSharper.Psi.Xaml.DeclaredElements.IXamlPredefinedResourcesCache, JetBrains.ReSharper.Psi.Xaml.DeclaredElements.XamlPredefinedResourcesCache>
    {
        public XamlPredefinedResourcesCache([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Modules.IPsiModules psiModules, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.ChangeManager changeManager) { }
    }
    public class XamlPredefinedResourcesCacheImpl : JetBrains.ReSharper.Psi.Xaml.DeclaredElements.IXamlPredefinedResourcesCache
    {
        public XamlPredefinedResourcesCacheImpl([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Modules.IPsiModule module, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext context) { }
        public JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetSymbolTable() { }
    }
    public class static XamlResourceExtensions
    {
        public const string EMPTY_STRING_NAME = "__RESHARPER_EMPTY_STRING";
        public const string XSTATIC_NAME = "__XSTATIC_NAME_";
        public const string XTYPE_NAME = "__XTYPE_NAME_";
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static object GetResourceKeyValue([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Xaml.DeclaredElements.IXamlResource resource) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static string GetXStaticName(JetBrains.ReSharper.Psi.Xaml.Tree.IXStatic xStatic) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static string GetXTypeName(JetBrains.ReSharper.Psi.Xaml.Impl.Tree.ITypeUsage typeUsage) { }
        public static bool IsXStatic(string shortName) { }
        public static bool IsXType(string shortName) { }
    }
}
namespace JetBrains.ReSharper.Psi.Xaml.Impl.Cache2
{
    
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class ApplicationTypePartCache : System.IDisposable
    {
        public ApplicationTypePartCache(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.IShellLocks shellLocks) { }
        public void Dispose() { }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Xaml.Tree.IXamlTypeDeclaration> GetApplicationTypeDeclarations(JetBrains.ReSharper.Psi.Modules.IPsiModule module) { }
        public static JetBrains.ReSharper.Psi.Xaml.Impl.Cache2.ApplicationTypePartCache GetInstance(JetBrains.ProjectModel.ISolution solution) { }
    }
    public class static XamlAttributeInstanceUtil
    {
        public static string[] GetAttributeClassNames([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Xaml.Tree.IXamlObjectElement objectElement) { }
        public static System.Collections.Generic.IList<JetBrains.ReSharper.Psi.IAttributeInstance> GetAttributeInstances([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Xaml.Tree.IXamlObjectElement objectElement) { }
        public static bool IsAttributesTag([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xaml.Tree.IXamlTag tag) { }
    }
    public class XamlQualifiedNamespacePart : JetBrains.ReSharper.Psi.ExtensionsAPI.Caches2.NamespacePart
    {
        public XamlQualifiedNamespacePart(JetBrains.ReSharper.Psi.ExtensionsAPI.Caches2.IReader reader) { }
        public XamlQualifiedNamespacePart(string shortName, JetBrains.ReSharper.Psi.TreeOffset offset) { }
        protected override byte SerializationTag { get; }
        protected override JetBrains.ReSharper.Psi.ExtensionsAPI.Caches2.ICachedDeclaration2 FindDeclaration(JetBrains.ReSharper.Psi.Tree.IFile file, JetBrains.ReSharper.Psi.ExtensionsAPI.Caches2.ICachedDeclaration2 candidateDeclaration) { }
    }
}
namespace JetBrains.ReSharper.Psi.Xaml.Impl.DeclaredElements
{
    
    public class XamlDeclaredElementType : JetBrains.ReSharper.Psi.DeclaredElementType
    {
        public static readonly JetBrains.ReSharper.Psi.Xaml.Impl.DeclaredElements.XamlDeclaredElementType AttachedEvent;
        public static readonly JetBrains.ReSharper.Psi.Xaml.Impl.DeclaredElements.XamlDeclaredElementType AttachedProperty;
        public static readonly JetBrains.ReSharper.Psi.Xaml.Impl.DeclaredElements.XamlDeclaredElementType NamespaceAlias;
        public static readonly JetBrains.ReSharper.Psi.Xaml.Impl.DeclaredElements.XamlDeclaredElementType Resource;
        public static readonly JetBrains.ReSharper.Psi.Xaml.Impl.DeclaredElements.XamlDeclaredElementType TemplateField;
        public static readonly JetBrains.ReSharper.Psi.Xaml.Impl.DeclaredElements.XamlDeclaredElementType XamlMarkupAttribute;
        public static readonly JetBrains.ReSharper.Psi.Xaml.Impl.DeclaredElements.XamlDeclaredElementType XamlMarkupObjectElement;
        protected override JetBrains.ReSharper.Psi.IDeclaredElementPresenter DefaultPresenter { get; }
        public override string PresentableName { get; }
        protected override JetBrains.UI.Icons.IconId GetImage() { }
        public override bool IsPresentable(JetBrains.ReSharper.Psi.PsiLanguageType language) { }
    }
}
namespace JetBrains.ReSharper.Psi.Xaml.Impl
{
    
    public interface IXamlTypeConversionRule : JetBrains.ReSharper.Psi.ITypeConversionRule { }
    public class XamlElementFactory : JetBrains.ReSharper.Psi.Xml.Parsing.XmlElementFactory<JetBrains.ReSharper.Psi.Xaml.XamlLanguage>
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ReSharper.Psi.Xaml.Tree.IXamlAttribute CreateAttributeForTag([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xaml.Tree.IXamlTag contextTag, [JetBrains.Annotations.NotNullAttribute()] string attributeText) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ReSharper.Psi.Xaml.Tree.IXamlFile CreateFile([JetBrains.Annotations.NotNullAttribute()] string xmlText) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public TMarkup CreateMarkup<TMarkup>([JetBrains.Annotations.NotNullAttribute()] string markupContent, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.IDeclaredType markupType = null)
            where TMarkup :  class, JetBrains.ReSharper.Psi.Xaml.Tree.MarkupExtensions.IMarkup { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ReSharper.Psi.Xaml.Tree.INamespaceAlias CreateNamespaceAlias([JetBrains.Annotations.NotNullAttribute()] string aliasName, [JetBrains.Annotations.NotNullAttribute()] string value) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ReSharper.Psi.Xaml.Tree.IXamlObjectElement CreateObjectElement([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xaml.Tree.IXamlTag contextTag, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IDeclaredType type) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public TObjectElement CreateObjectElement<TObjectElement>([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xaml.Tree.IXamlTag contextTag, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IDeclaredElement element, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution = null)
            where TObjectElement :  class, JetBrains.ReSharper.Psi.Xaml.Tree.IXamlObjectElement { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ReSharper.Psi.Xaml.Tree.IPropertyAttribute CreatePropertyAttribute([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xaml.Tree.IXamlObjectElement contextElement, [JetBrains.Annotations.NotNullAttribute()] string propertyName, [JetBrains.Annotations.CanBeNullAttribute()] string value = null, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.IDeclaredType qualifier = null) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ReSharper.Psi.Xaml.Tree.IXamlPropertyElement CreatePropertyElement([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xaml.Tree.IXamlObjectElement contextElement, [JetBrains.Annotations.NotNullAttribute()] string propertyName, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.IDeclaredType ownerType = null) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ReSharper.Psi.Xaml.Tree.IXamlAttribute CreateRootAttribute([JetBrains.Annotations.NotNullAttribute()] string attributeText) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ReSharper.Psi.Xaml.Tree.IXamlTypeDeclaration CreateRootTag([JetBrains.Annotations.NotNullAttribute()] string tagText) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ReSharper.Psi.Xaml.Tree.IStyleDeclaration CreateStyleDeclaration([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xaml.Tree.IXamlTag contextTag, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IDeclaredType type) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ReSharper.Psi.Xaml.Tree.IXamlTag CreateTagForTag([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag contextTag, [JetBrains.Annotations.NotNullAttribute()] string tagText, [JetBrains.Annotations.CanBeNullAttribute()] string rootTagText = null) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ReSharper.Psi.Xaml.Tree.IXKeyAttribute CreateXKeyAttribute([JetBrains.Annotations.NotNullAttribute()] string value) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.ReSharper.Psi.Xaml.Impl.XamlElementFactory GetInstance([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Modules.IPsiModule module, bool applyFormatter = True) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.ReSharper.Psi.Xaml.Impl.XamlElementFactory GetInstance([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode context, bool applyFormatter = True) { }
    }
    public class static XamlKeywords
    {
        public const string ACTIVITY = "Activity";
        public const string ALTERNATE_CONTENT = "AlternateContent";
        public const string ANCESTOR_LEVEL_ATTRIBUTE = "AncestorLevel";
        public const string ANCESTOR_TYPE_ATTRIBUTE = "AncestorType";
        public const string APPLICATION = "Application";
        public const string ARGUMENTS = "Arguments";
        public const string ATTRIBUTES = "Attributes";
        public const string BASED_ON_ATTRIBUTE = "BasedOn";
        public const string BASED_ON_TYPE = "Style.BasedOn";
        public const string BINDING = "Binding";
        public const string BINDING_MODE_ATTRIBUTE = "Mode";
        public const string BINDING_MODE_DEFAULT = "Default";
        public const string BINDING_MODE_ONE_TIME = "OneTime";
        public const string BINDING_MODE_ONE_WAY = "OneWay";
        public const string BINDING_MODE_ONE_WAY_TO_SOURCE = "OneWayToSource";
        public const string BINDING_MODE_TWO_WAY = "TwoWay";
        public const string BUTTON = "Button";
        public const string CHOICE = "Choice";
        public const string CLASS_ATTRIBUTES = "ClassAttributes";
        public const string COLOR = "Color";
        public const string COMMAND_ATTRIBUTE = "Command";
        public const string COMPONENT_RESOURCE_KEY = "ComponentResourceKey";
        public const string CONDITION = "Condition";
        public const string CONDITION_PROPERTY = "Condition.Property";
        public const string CONNECT = "Connect";
        public const string CONNECT_WINRT_VB = "IComponentConnector_Connect";
        public const string CONNECT_WPF_VB = "System_Windows_Markup_IComponentConnector_Connect";
        public const string CONSTRUCTOR_PARAMETERS_ATTRIBUTE = "ConstructorParameters";
        public const string CONTROL_TEMPLATE = "ControlTemplate";
        public const string CONVERTER_PROPERTY = "Converter";
        public const string CREATE_LIST = "CreateList";
        public const string DATA_CONTEXT = "DataContext";
        public const string DATA_TEMPLATE = "DataTemplate";
        public const string DATA_TYPE_ATTRIBUTE = "DataType";
        public const string DESIGN_DATA = "DesignData";
        public const string DESIGN_HEIGHT = "DesignHeight";
        public const string DESIGN_INSTANCE = "DesignInstance";
        public const string DESIGN_SOURCE = "DesignSource";
        public const string DESIGN_WIDTH = "DesignWidth";
        public const string DYNAMIC_RESOURCE = "DynamicResource";
        public const string ELEMENT_NAME_ATTRIBUTE = "ElementName";
        public const string EVENT_ATTRIBUTE = "Event";
        public const string EVENT_SETTER = "EventSetter";
        public const string EVENT_SETTER_EVENT = "EventSetter.Event";
        public const string EVENT_SETTER_HANDLER = "EventSetter.Handler";
        public const string EVENT_TRIGGER = "EventTrigger";
        public const string EVENT_TRIGGER_ROUTED_EVENT = "EventTrigger.RoutedEvent";
        public const string EXTENSION = "Extension";
        public const string FACTORY_METHOD = "FactoryMethod";
        public const string FALLBACK = "Fallback";
        public static readonly string[] FIELD_ATTRIBUTE_NAMES;
        public const string FIND_ANCESTOR = "FindAncestor";
        public const string FREEZE_ATTRIBUTE = "Freeze";
        public const string HANDLER_ATTRIBUTE = "Handler";
        public const string HIERARCHIAL_DATA_TEMPLATE = "HierarchicalDataTemplate";
        public const string I_COMPONENT_CONNECTOR = "IComponentConnector";
        public const string I_SUPPORT_INITIALIZE = "ISupportInitialize";
        public const string IGNORABLE_ATTRIBUTE = "Ignorable";
        public const string IMAGE = "Image";
        public const string INITIALIZE_COMPONENT = "InitializeComponent";
        public const string INVALID_TYPE_DECLARATION = "__RESHAPER_INVALID_TYPE_DECLARATION";
        public const string IS_DESIGN_TIME_CREATABLE = "IsDesignTimeCreatable";
        public const string ITEM_TEMPLATE = "ItemTemplate";
        public const string ITEMS_SOURCE = "ItemsSource";
        public const string MAIN = "Main";
        public const string MEMBERS = "Members";
        public const string MENU_ITEM = "MenuItem";
        public const string MERGED_DICTIONARIES_ATTRIBUTE = "MergedDictionaries";
        public const string METHOD_NAME_ATTRIBUTE = "MethodName";
        public const string METHOD_PARAMETERS_ATTRIBUTE = "MethodParameters";
        public const string MODE_ATTRIBUTE = "Mode";
        public const string MULTI_BINDING = "MultiBinding";
        public const string NAME_ATTRIBUTE = "Name";
        public const string NULL = "Null";
        public const string OBJECT_DATA_PROVIDER = "ObjectDataProvider";
        public const string OBJECT_INSTANCE_ATTRIBUTE = "ObjectInstance";
        public const string OBJECT_TYPE_ATTRIBUTE = "ObjectType";
        public const string PATH_ATTRIBUTE = "Path";
        public const string PREVIOUS_DATA = "PreviousData";
        public const string PRIORITY_BINDING = "PriorityBinding";
        public const string PROCESS_CONTENT_ATTRIBUTE = "ProcessContent";
        public const string PROPERTY = "Property";
        public const string PROPERTY_ATTRIBUTE = "Property";
        public const string REFERENCE = "Reference";
        public const string RELATIVE_SOURCE = "RelativeSource";
        public const string RELATIVE_SOURCE_MODE_FIND_ANCESTOR = "FindAncestor";
        public const string RELATIVE_SOURCE_MODE_PREVIOUS_DATA = "PreviousData";
        public const string RELATIVE_SOURCE_MODE_SELF = "Self";
        public const string RELATIVE_SOURCE_MODE_TEMPLATED_PARENT = "TemplatedParent";
        public const string REQUIRES = "Requires";
        public const string RESOURCE_ATTRIBUTE_NAME = "ResourceKey";
        public const string RESOURCE_DICTIONARY = "ResourceDictionary";
        public const string RESOURCE_ID_ATTRIBUTE = "ResourceId";
        public const string RESOURCES_PROPERTY = "Resources";
        public const string ROUTED_EVENT_ATTRIBUTE = "RoutedEvent";
        public const string SELF = "Self";
        public const string SETTER = "Setter";
        public const string SETTER_PROPERTY = "Setter.Property";
        public const string SETTERS = "Setters";
        public const string SOURCE_ATTRIBUTE = "Source";
        public const string SOURCE_NAME_ATTRIBUTE = "SourceName";
        public const string STARTUP_URI = "StartupUri";
        public const string STATIC = "Static";
        public const string STATIC_RESOURCE = "StaticResource";
        public const string STORYBOARD = "Storyboard";
        public const string STYLE = "Style";
        public const string STYLE_TARGET_TYPE = "Style.TargetType";
        public const string TARGET_NAME_ATTRIBUTE = "TargetName";
        public const string TARGET_PROPERTY_ATTRIBUTE = "TargetProperty";
        public const string TARGET_TYPE_ATTRIBUTE = "TargetType";
        public const string TEMPLATE_BINDING = "TemplateBinding";
        public const string TEMPLATED_PARENT = "TemplatedParent";
        public const string THEME_DICTIONARIES_ATTRIBUTE = "ThemeDictionaries";
        public const string THEME_RESOURCE = "ThemeResource";
        public const string TRIGGER = "Trigger";
        public const string TRIGGER_PROPERTY = "Trigger.Property";
        public const string TYPE = "Type";
        public const string VALUE_ATTRIBUTE = "Value";
        public const string XARGUMENTS = "x:Arguments";
        public const string XARRAY = "x:Array";
        public const string XARRAY_EXTENSION = "x:ArrayExtension";
        public const string XCLASS_ATTRIBUTE = "x:Class";
        public const string XCLASS_MODIFIER = "x:ClassModifier";
        public const string XCODE = "x:Code";
        public const string XDATA = "x:XData";
        public const string XFIELD_MODIFIER = "x:FieldModifier";
        public const string XKEY = "x:Key";
        public const string XMEMBERS = "x:Members";
        public const string XML = "xml";
        public const string XML_DATA_PROVIDER = "XmlDataProvider";
        public const string XML_LANG = "xml:lang";
        public const string XML_SPACE = "xml:space";
        public const string XMLNS_ATTRIBUTE = "xmlns";
        public const string XMLNS_D = "http://schemas.microsoft.com/expression/blend/2008";
        public const string XMLNS_DEFAULT = "http://schemas.microsoft.com/winfx/2006/xaml/presentation";
        public const string XMLNS_MARKUP_COMPATIBILITY = "http://schemas.openxmlformats.org/markup-compatibility/2006";
        public const string XMLNS_PRESENTATION_OPTIONS = "http://schemas.microsoft.com/winfx/2006/xaml/presentation/options";
        public const string XMLNS_WORKFLOW = "http://schemas.microsoft.com/netfx/2009/xaml/activities";
        public const string XMLNS_X = "http://schemas.microsoft.com/winfx/2006/xaml";
        public const string XNAME_ATTRIBUTE = "x:Name";
        public const string XNULL = "x:Null";
        public const string XPATH_ATTRIBUTE = "XPath";
        public const string XPROPERTY = "x:Property";
        public const string XREFERENCE = "x:Reference";
        public const string XSHARED_ATTRIBUTE = "x:Shared";
        public const string XSTATIC = "x:Static";
        public const string XSTATIC_EXTENSION = "x:StaticExtension";
        public const string XSTATIC_MEMBER_ATTRIBUTE = "Member";
        public const string XSTATIC_MEMBER_TYPE_ATTRIBUTE = "MemberType";
        public const string XSUBCLASS = "x:Subclass";
        public const string XTYPE = "x:Type";
        public const string XTYPE_ARGUMENTS = "x:TypeArguments";
        public const string XTYPE_ATTRIBUTE_NAME = "TypeName";
        public const string XTYPE_EXTENSION = "x:TypeExtension";
        public const string XUID = "x:Uid";
        public static string GetMarkupExtensionName(string name) { }
        public static bool IsBindingExtension(string markupName) { }
        public static bool IsMarkupExtension(string markupName, string shortName) { }
        public static bool IsResourceDictionary(JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagContainer tagContainer) { }
        public static bool IsResourceKeyword(string keyword) { }
        public static bool IsTargetTypeAttribute(string attributeName) { }
    }
    [System.FlagsAttribute()]
    public enum XamlLanguageLevel
    {
        NO_XAML = 0,
        FLG_XAML_2006 = 1,
        FLG_XAML_2009 = 2,
        FLG_XAML_2009_PLUS = 4,
        FLG_XAML_2009_WORKFLOW = 8,
        XAML_2006 = 1,
        XAML_2009 = 3,
        XAML_2009_PLUS = 7,
        XAML_2009_WORKFLOW = 11,
        ALL = 15,
    }
    public class static XamlLanguageLevelExtensions
    {
        public static JetBrains.ReSharper.Psi.Xaml.Impl.XamlLanguageLevel GetLanguageLevel(this JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public static bool IsAllowedIn(this JetBrains.ReSharper.Psi.Xaml.DeclaredElements.IXamlPredefinedDeclaredElement declaredElement, JetBrains.ReSharper.Psi.Xaml.Impl.XamlLanguageLevel projectFileLevel) { }
        public static bool IsAllowedIn(this JetBrains.ReSharper.Psi.Xaml.DeclaredElements.IXamlPredefinedDeclaredElement declaredElement, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public static bool IsAllowedIn(this JetBrains.ReSharper.Psi.Xaml.Impl.XamlLanguageLevel constructLevel, JetBrains.ReSharper.Psi.Xaml.Impl.XamlLanguageLevel projectFileLevel) { }
    }
    [JetBrains.Application.ShellComponentAttribute(JetBrains.Application.Components.ProgramConfigurations.NONE | JetBrains.Application.Components.ProgramConfigurations.STANDALONE | JetBrains.Application.Components.ProgramConfigurations.COMMAND_LINE | JetBrains.Application.Components.ProgramConfigurations.ALL)]
    public class XamlLanguageLevelProvider
    {
        public static JetBrains.ReSharper.Psi.Xaml.Impl.XamlLanguageLevelProvider Instance { get; }
        public virtual JetBrains.ReSharper.Psi.Xaml.Impl.XamlLanguageLevel GetLanguageLevel(JetBrains.ProjectModel.IProjectItem projectItem) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.Xaml.XamlLanguage))]
    public class XamlLanguageService : JetBrains.ReSharper.Psi.Xml.XmlLanguageService
    {
        public XamlLanguageService(JetBrains.ReSharper.Psi.Xaml.XamlLanguage languageType, JetBrains.ReSharper.Psi.IConstantValueService constantValueService, JetBrains.ReSharper.Psi.Parsing.XmlTokenTypes tokenTypes, JetBrains.ReSharper.Psi.Xml.Parsing.IXmlElementFactory elementFactory, JetBrains.ReSharper.Psi.Xml.Impl.CodeStyle.XmlCodeFormatter codeFormatter, JetBrains.ReSharper.Psi.Util.CommonIdentifierIntern commonIdentifierIntern) { }
        public override JetBrains.ReSharper.Psi.ExtensionsAPI.Caches2.ILanguageCacheProvider CacheProvider { get; }
        public override bool SupportTypeMemberCache { get; }
        public override JetBrains.ReSharper.Psi.ITypePresenter TypePresenter { get; }
        public override bool CanContainCachableDeclarations(JetBrains.ReSharper.Psi.Tree.ITreeNode node) { }
        public override JetBrains.ReSharper.Psi.Pointers.IDeclaredElementPointer<T> CreateElementPointer<T>(T declaredElement)
            where T : JetBrains.ReSharper.Psi.IDeclaredElement { }
        public override JetBrains.ReSharper.Psi.Parsing.IParser CreateParser(JetBrains.ReSharper.Psi.Parsing.ILexer lexer, JetBrains.ReSharper.Psi.Modules.IPsiModule module, JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
        public override JetBrains.ReSharper.Psi.ExtensionsAPI.IReferenceContextCodec CreateReferenceContextCodec() { }
        public override JetBrains.ReSharper.Psi.ReferenceAccessType GetReferenceAccessType(JetBrains.ReSharper.Psi.IDeclaredElement target, JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public override bool IsValidName(JetBrains.ReSharper.Psi.DeclaredElementType elementType, string name) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.Xaml.XamlLanguage))]
    public class XamlLanguageSupport : JetBrains.ReSharper.Psi.Xml.XmlLanguageSupport
    {
        public override bool CanConvertAttributeToTag(JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttribute attribute) { }
        public static bool CanConvertAttributeToTag([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xaml.Tree.IXamlAttribute attribute, bool checkConstructorArguments = False) { }
        public static bool CanConvertMarkupToTag([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xaml.Tree.MarkupExtensions.IMarkup markup, bool checkConstructorArguments = False) { }
        public override bool CanConvertTagToAttribute(JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag tag) { }
        public override bool CanMakeTagEmpty(JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag tag) { }
        public override bool CanRemoveAllTags(JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag tagToRemove) { }
        public override bool CanRemoveTagAndKeepChildren(JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag tagToRemove) { }
        public override string ConvertAttributeValue(JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttribute attribute, out bool preserveRequired) { }
        public override string ConvertTagToValue(JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag tag) { }
        public override JetBrains.ReSharper.Psi.Xml.Parsing.XmlTreeBuilder CreateTreeBuilder(JetBrains.ReSharper.Psi.Xml.Parsing.IXmlElementFactory factory, JetBrains.ReSharper.Psi.Xml.Parsing.IXmlElementFactoryContext factoryContext, JetBrains.ReSharper.Psi.Util.ITokenIntern intern) { }
        public override string GetAttributeName(JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag tag) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Psi.IProperty GetPropertyByConstructorArgument([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xaml.Tree.MarkupExtensions.IMarkupAttribute attribute) { }
        public override string GetTagName(JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttribute attribute) { }
        public override bool IsValidTagName(string name) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class XamlModulePlatformCache
    {
        public XamlModulePlatformCache([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.ISolution solution, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.ChangeManager changeManager, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public string GetDefaultNamespace([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IModule module) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.ReSharper.Psi.Xaml.Impl.XamlModulePlatformCache GetInstance([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.ISolution solution) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.ReSharper.Psi.Xaml.Impl.XamlModulePlatformCache GetInstance([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IModule module) { }
        public JetBrains.ReSharper.Psi.Xaml.Impl.Util.XamlPlatform GetXamlPlatform([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IModule module) { }
        public bool UpdateDefaultNamespaceIfNecessary([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IModule module) { }
        public bool UpdateXamlPlatformIfNecessary([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IModule module) { }
    }
    [JetBrains.ProjectModel.ProjectFileTypeAttribute(typeof(JetBrains.ProjectModel.XamlProjectFileType))]
    public class XamlProjectFileLanguageService : JetBrains.ReSharper.Psi.Xml.XmlProjectFileLanguageService
    {
        public XamlProjectFileLanguageService(JetBrains.ProjectModel.XamlProjectFileType xamlProjectFileType) { }
        public override JetBrains.UI.Icons.IconId Icon { get; }
        public JetBrains.ReSharper.Psi.Xaml.Impl.XamlLanguageLevel GetLanguageLevel(JetBrains.ProjectModel.IProjectItem projectItem) { }
        public override JetBrains.ReSharper.Psi.PsiLanguageType GetPsiLanguageType(JetBrains.ProjectModel.IProjectFile projectFile) { }
        public override JetBrains.ReSharper.Psi.PsiLanguageType GetPsiLanguageType(JetBrains.ProjectModel.ProjectFileType languageType) { }
        public override JetBrains.ReSharper.Psi.IPsiSourceFileProperties GetPsiProperties(JetBrains.ProjectModel.IProjectFile projectFile, JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.Xaml.XamlLanguage))]
    public class XamlTextOccurenceSearcherFactory : JetBrains.ReSharper.Psi.Xml.Impl.XmlTextOccurenceSearcherFactory
    {
        public override JetBrains.ReSharper.Psi.Xml.Impl.XmlTextOccurenceSearchHelper<TResult> CreateHelper<TResult>(System.Collections.Generic.JetHashSet<string> names, JetBrains.ReSharper.Psi.Search.IFindResultConsumer<TResult> consumer) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.Xaml.XamlLanguage))]
    public class XamlTreeNodeFactory : JetBrains.ReSharper.Psi.Xml.Parsing.XmlTreeNodeFactory
    {
        public XamlTreeNodeFactory([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xaml.XamlLanguage languageType, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Parsing.XmlTokenTypes tokenTypes, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xaml.Tree.XamlElementTypes elementTypes) { }
        public override JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttribute CreateAttribute(JetBrains.ReSharper.Psi.Xml.Tree.IXmlIdentifier nameIdentifier, JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttributeContainer attributeContainer, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagContainer parentTag, JetBrains.ReSharper.Psi.Xml.Parsing.IXmlElementFactoryContext context) { }
        public override JetBrains.ReSharper.Psi.Xml.Tree.IXmlIdentifier CreateIdentifier(JetBrains.ReSharper.Psi.Util.ITokenIntern internalizer, JetBrains.ReSharper.Psi.Parsing.XmlTokenNodeType tokenType, JetBrains.Text.IBuffer buffer, int startOffset, int endOffset) { }
        public override JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag CreateRootTag(JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagHeader header, JetBrains.ReSharper.Psi.Xml.Parsing.IXmlElementFactoryContext context) { }
        public override JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag CreateTag(JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagHeader header, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag parentTag, JetBrains.ReSharper.Psi.Xml.Parsing.IXmlElementFactoryContext context) { }
        public override JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagFooter CreateTagFooter(JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagContainer parentTag, JetBrains.ReSharper.Psi.Xml.Parsing.IXmlElementFactoryContext context) { }
    }
    public class XamlTypeConversionRule : JetBrains.ReSharper.Psi.ITypeConversionRule, JetBrains.ReSharper.Psi.Xaml.Impl.IXamlTypeConversionRule
    {
        public static readonly JetBrains.ReSharper.Psi.Xaml.Impl.XamlTypeConversionRule Instance;
        public virtual bool IdentityConvertionExist([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IType from, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IType to) { }
        public virtual bool ImplicitNumericConversionExist([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IType from, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IType to) { }
        public bool IsExplicitlyConvertiblePredefined(JetBrains.ReSharper.Psi.IType from, JetBrains.ReSharper.Psi.IType to) { }
        protected virtual bool IsExplicitlyConvertiblePredefinedImpl(JetBrains.ReSharper.Psi.IType from, JetBrains.ReSharper.Psi.IType to) { }
        public bool IsExplicitlyConvertibleTo(JetBrains.ReSharper.Psi.IType from, JetBrains.ReSharper.Psi.IType to) { }
        public bool IsImplicitlyConvertiblePredefined(JetBrains.ReSharper.Psi.IType from, JetBrains.ReSharper.Psi.IType to) { }
        protected virtual bool IsImplicitlyConvertiblePredefinedImpl([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IType from, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IType to, bool allowNumeric) { }
        public bool IsImplicitlyConvertibleTo(JetBrains.ReSharper.Psi.IType from, JetBrains.ReSharper.Psi.IType to) { }
    }
    public class static XamlTypeConversionRuleExtensions
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.ITypeConversionRule GetCodeBehindTypeConversionRule([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Tree.ITreeNode node) { }
        [JetBrains.Annotations.NotNullAttribute()]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.Xaml.Impl.IXamlTypeConversionRule GetTypeConversionRule([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Tree.ITreeNode node) { }
    }
    public sealed class XamlWinRTTypeConversionRule : JetBrains.ReSharper.Psi.Xaml.Impl.XamlTypeConversionRule
    {
        public XamlWinRTTypeConversionRule([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Modules.IPsiModule module, JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext resolveContext) { }
        public override bool IdentityConvertionExist(JetBrains.ReSharper.Psi.IType from, JetBrains.ReSharper.Psi.IType to) { }
        public override bool ImplicitNumericConversionExist(JetBrains.ReSharper.Psi.IType from, JetBrains.ReSharper.Psi.IType to) { }
        protected override bool IsExplicitlyConvertiblePredefinedImpl(JetBrains.ReSharper.Psi.IType from, JetBrains.ReSharper.Psi.IType to) { }
        protected override bool IsImplicitlyConvertiblePredefinedImpl(JetBrains.ReSharper.Psi.IType from, JetBrains.ReSharper.Psi.IType to, bool allowNumeric) { }
    }
}
namespace JetBrains.ReSharper.Psi.Xaml.Impl.Resolve
{
    
    public interface IXamlFunctionResolver
    {
        JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.ResolveResultWithInfo ResolveMethod(JetBrains.ReSharper.Psi.Xaml.Tree.IXamlFunctionReference functionReference, bool filterByName, JetBrains.ReSharper.Psi.Resolve.ISymbolTable symbolTable, JetBrains.ReSharper.Psi.Resolve.IAccessContext context);
    }
    public interface IXamlInvalidatingTypeCache
    {
        void DropTypes();
    }
    public interface IXamlMethodGroupConvertibleFilterFactory
    {
        JetBrains.ReSharper.Psi.Resolve.SimpleSymbolFilter CreateMethodGroupConvertibleFilter([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode context, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.DeclaredElementInstance<JetBrains.ReSharper.Psi.IDelegate> eventTypeInstance);
    }
    public interface IXamlModifiersSupport
    {
        [JetBrains.Annotations.NotNullAttribute()]
        string InternalString { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        string PrivateString { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        string ProtectedString { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        string PublicString { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.IEqualityComparer<string> GetModifierComparer([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode context);
    }
    public interface IXamlTypeCache : JetBrains.ReSharper.Psi.Xaml.Impl.Resolve.IXamlInvalidatingTypeCache
    {
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IDeclaredType Application { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IDeclaredType ApplicationCommands { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IDeclaredType ArrayExtension { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IDeclaredType Attribute { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IDeclaredType Binding { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IDeclaredType BindingBase { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IDeclaredType Bool { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IDeclaredType Brush { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IDeclaredType Brushes { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IDeclaredType Brushes2 { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IDeclaredType Canvas { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IDeclaredType CollectionViewSource { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IDeclaredType Color { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IDeclaredType Colors { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IDeclaredType ColumnDefinition { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IDeclaredType ComponentCommands { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IDeclaredType ConstructorArgumentAttribute { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IDeclaredType ContentPropertyAttribute { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IDeclaredType Control { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IDeclaredType ControlTemplate { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IDeclaredType DataTemplate { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IDeclaredType DependencyObject { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IDeclaredType DependencyProperty { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IDeclaredType DependencyPropertyKey { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IDeclaredType Dock { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IDeclaredType DockPanel { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IDeclaredType DynamicResourceExtension { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IDeclaredType EditingCommands { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IDeclaredType EventSetter { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IDeclaredType EventTrigger { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IDeclaredType FlowDocument { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IDeclaredType FontFamily { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IDeclaredType FontStretch { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IDeclaredType FontStretches { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IDeclaredType FontStyle { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IDeclaredType FontStyles { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IDeclaredType FontWeight { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IDeclaredType FontWeights { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IDeclaredType Frame { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IDeclaredType FrameworkContentElement { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IDeclaredType FrameworkElement { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IDeclaredType FrameworkTemplate { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IDeclaredType Freezable { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IDeclaredType GenericICollectionType { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IDeclaredType GenericIDictionaryType { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IDeclaredType GenericIEnumerableType { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IDeclaredType GenericIListType { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IDeclaredType GenericIObservableMap { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IDeclaredType Geometry { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IDeclaredType Grid { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IDeclaredType GridLength { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IDeclaredType HierarchicalDataTemplate { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IDeclaredType IAddChildType { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IDeclaredType ICommand { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IDeclaredType IComponentConnector { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IDeclaredType ICustomTypeProvider { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IDeclaredType IDictionaryType { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IDeclaredType IEnumerableType { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IDeclaredType IListType { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IDeclaredType ImageSource { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IDeclaredType IMarkupExtension { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IDeclaredType InlineCollection { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IDeclaredType ISupportInitialize { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IDeclaredType ItemsControl { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IDeclaredType Key { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IDeclaredType MarkupExtension { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IDeclaredType MarkupExtensionReturnType { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IDeclaredType MediaCommands { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IDeclaredType ModifierKeys { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IDeclaredType MultiBinding { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IDeclaredType NavigationCommands { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IDeclaredType NavigationWindow { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IDeclaredType Object { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IDeclaredType ObjectDataProvider { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IDeclaredType Page { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IDeclaredType PageFuction { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IDeclaredType Panel { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IDeclaredType RelativeSource { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IDeclaredType RelativeSourceMode { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IDeclaredType RepeatBehavior { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IDeclaredType ResourceDictionary { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IDeclaredType ResourceKey { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IDeclaredType RichTextBox { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IDeclaredType RoutedEvent { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IDeclaredType RoutedEventArgs { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IDeclaredType RoutedEventHandler { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IDeclaredType RowDefinition { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IDeclaredType SelectionChangedEventHandler { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IDeclaredType Setter { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Resolve.ISymbolTable SilverlightBrushes { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Resolve.ISymbolTable SilverlightColors { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Resolve.ISymbolTable SilverlightFontStyles { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IDeclaredType SolidColorBrush { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IDeclaredType StaticResourceExtension { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IDeclaredType Storyboard { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IDeclaredType Style { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IDeclaredType SystemColors { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IDeclaredType TextBlock { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IDeclaredType TextBox { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IDeclaredType TextBoxBase { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IDeclaredType Thickness { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IDeclaredType Trigger { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IDeclaredType TypeConverterAttribute { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IDeclaredType UIElement { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IDeclaredType Uri { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IDeclaredType UriMapping { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IDeclaredType UserControl { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IDeclaredType ValueConversionAttribute { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IDeclaredType Visibility { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IDeclaredType VisualState { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IDeclaredType VisualStateGroup { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IDeclaredType VisualStateManager { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IDeclaredType Window { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IDeclaredType WinRTColor { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IDeclaredType WinRTColors { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IDeclaredType XamlDeferLoadAttribute { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.IList<JetBrains.ReSharper.Psi.IType> GetContentTypes([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IType type, [JetBrains.Annotations.CanBeNullAttribute()] out string contentProperty);
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IDeclaredType GetType(string fullyQualifiedName, string[] assemblyNames = null);
        bool HasAttachedMembers([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.ITypeElement type);
        bool HasXStaticMembers([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.ITypeElement type);
        bool IsCollectionType([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IType type, [JetBrains.Annotations.NotNullAttribute()] out JetBrains.ReSharper.Psi.IType elementType);
        bool IsEnumerableType([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IType type, [JetBrains.Annotations.NotNullAttribute()] out JetBrains.ReSharper.Psi.IType elementType);
        bool IsEnumType([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IType type);
        bool IsMarkupExtension([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IType type, [JetBrains.Annotations.NotNullAttribute()] out JetBrains.ReSharper.Psi.IType returnType);
        bool IsXamlInstantiable([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.ITypeElement type, out bool hasDefault);
    }
    public class static XamlAccessFilters
    {
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.Filters.AccessRightsFilter CreateAccessRightsFilter(JetBrains.ReSharper.Psi.Resolve.IAccessContext context, JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext resolveContext) { }
        public sealed class PropertyAccessorAccessRightsFilter : JetBrains.ReSharper.Psi.Resolve.SimpleSymbolFilter
        {
            public PropertyAccessorAccessRightsFilter([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Resolve.IAccessContext accessContext, bool isSetter) { }
            public override JetBrains.ReSharper.Psi.Resolve.ResolveErrorType ErrorType { get; }
            public override bool Accepts(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution) { }
        }
    }
    public class static XamlEventFilters
    {
        public static readonly JetBrains.ReSharper.Psi.Resolve.SimpleSymbolFilter IsEvent;
        public static readonly JetBrains.ReSharper.Psi.Resolve.SimpleSymbolFilter IsNotEvent;
        public class ExactEventSubscriptionFilter : JetBrains.ReSharper.Psi.Resolve.SimpleSymbolFilter
        {
            public ExactEventSubscriptionFilter([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.DeclaredElementInstance<JetBrains.ReSharper.Psi.IDelegate> @delegate) { }
            public override JetBrains.ReSharper.Psi.Resolve.ResolveErrorType ErrorType { get; }
            public override bool Accepts(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution) { }
        }
    }
    public class XamlMethodGroupConvertibleFilter : JetBrains.ReSharper.Psi.Resolve.SimpleSymbolFilter
    {
        public XamlMethodGroupConvertibleFilter(JetBrains.ReSharper.Psi.Tree.ITreeNode context, JetBrains.ReSharper.Psi.Resolve.SimpleSymbolFilter methodGroupConvertibleFilter, JetBrains.ReSharper.Psi.Resolve.SimpleSymbolFilter exactSignatureFilter) { }
        public override JetBrains.ReSharper.Psi.Resolve.ResolveErrorType ErrorType { get; }
        public override bool Accepts(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution) { }
    }
    public abstract class XamlModuleTypeCache<TCache, TSelf> : JetBrains.ReSharper.Psi.Caches.InvalidatingPsiCache
    
        where TSelf : JetBrains.ReSharper.Psi.Xaml.Impl.Resolve.XamlModuleTypeCache<, >
    {
        protected XamlModuleTypeCache([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Modules.IPsiModules psiModules, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.ChangeManager changeManager) { }
        [JetBrains.Annotations.NotNullAttribute()]
        [JetBrains.Annotations.PureAttribute()]
        public static TCache GetCache([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Modules.IPsiModule module, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext context) { }
        [JetBrains.Annotations.NotNullAttribute()]
        [JetBrains.Annotations.PureAttribute()]
        public static TCache GetCache([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        protected TCache GetModuleCache([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Modules.IPsiModule module, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext context) { }
        protected override void InvalidateOnPhysicalChange() { }
    }
    public class static XamlNamespaceFilters
    {
        public static readonly JetBrains.ReSharper.Psi.Resolve.SimpleSymbolFilter IsNamespaceAlias;
        public static readonly JetBrains.ReSharper.Psi.Resolve.SimpleSymbolFilter IsNotNamespaceAlias;
        public class AttributePredefinedNamespaceAliasFilter : JetBrains.ReSharper.Psi.Resolve.SimpleSymbolFilter
        {
            public AttributePredefinedNamespaceAliasFilter([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
            public override JetBrains.ReSharper.Psi.Resolve.ResolveErrorType ErrorType { get; }
            public override bool Accepts(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution) { }
        }
    }
    public enum XamlRelatedMemberKind
    {
        DEPENDENCY_PROPERTY_DESCRIPTOR = 0,
        DEPENDENCY_PROPERTY_ACCESSOR = 1,
        ATTACHED_PROPERTY_GETTER = 2,
        ATTACHED_PROPERTY_SETTER = 3,
        ROUTED_EVENT_DESCRIPTOR = 4,
        ROUTED_EVENT_ACCESSOR = 5,
        ATTACHED_EVENT_ADDER = 6,
        ATTACHED_EVENT_REMOVER = 7,
    }
    public class XamlResolveErrorType : JetBrains.ReSharper.Psi.Xml.Impl.Resolve.XmlResolveErrorType
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public static readonly JetBrains.ReSharper.Psi.Resolve.ResolveErrorType ASSEMBLY_NAME_EXPECTED;
        public const string ASSEMBLY_NAME_EXPECTED_TOOLTIP = "Assembly name expected instead of project name";
        [JetBrains.Annotations.NotNullAttribute()]
        public static readonly JetBrains.ReSharper.Psi.Resolve.ResolveErrorType ATTACHED_EVENT_FIELD_MISSING;
        [JetBrains.Annotations.NotNullAttribute()]
        public static readonly JetBrains.ReSharper.Psi.Resolve.ResolveErrorType ATTACHED_EVENT_HAS_NO_ADD_HANDLER;
        [JetBrains.Annotations.NotNullAttribute()]
        public static readonly JetBrains.ReSharper.Psi.Resolve.ResolveErrorType ATTACHED_PROPERTY_HAS_NO_GETTER;
        [JetBrains.Annotations.NotNullAttribute()]
        public static readonly JetBrains.ReSharper.Psi.Resolve.ResolveErrorType ATTACHED_PROPERTY_HAS_NO_SETTER;
        [JetBrains.Annotations.NotNullAttribute()]
        public static readonly JetBrains.ReSharper.Psi.Resolve.ResolveErrorType ATTACHED_PROPERTY_READONLY;
        [JetBrains.Annotations.NotNullAttribute()]
        public static readonly JetBrains.ReSharper.Psi.Resolve.ResolveErrorType ATTACHED_PROPERTY_SETTER_INACCESSIBLE;
        [JetBrains.Annotations.NotNullAttribute()]
        public static readonly JetBrains.ReSharper.Psi.Resolve.ResolveErrorType BAD_SIGNATURE;
        [JetBrains.Annotations.NotNullAttribute()]
        public static readonly JetBrains.ReSharper.Psi.Resolve.ResolveErrorType DEFAULT_PROPERTY_EXPECTED;
        [JetBrains.Annotations.NotNullAttribute()]
        public static readonly JetBrains.ReSharper.Psi.Resolve.ResolveErrorType DEPENDENCY_PROPERTY_FIELD_MISSING;
        [JetBrains.Annotations.NotNullAttribute()]
        public static readonly JetBrains.ReSharper.Psi.Resolve.ResolveErrorType DEPENDENCY_PROPERTY_HAS_NO_GETTER;
        [JetBrains.Annotations.NotNullAttribute()]
        public static readonly JetBrains.ReSharper.Psi.Resolve.ResolveErrorType DEPENDENCY_PROPERTY_HAS_NO_SETTER;
        [JetBrains.Annotations.NotNullAttribute()]
        public static readonly JetBrains.ReSharper.Psi.Resolve.ResolveErrorType ENUM_MEMBER_EXPECTED;
        [JetBrains.Annotations.NotNullAttribute()]
        public static readonly JetBrains.ReSharper.Psi.Resolve.ResolveErrorType EVENT_EXPECTED;
        [JetBrains.Annotations.NotNullAttribute()]
        public static readonly JetBrains.ReSharper.Psi.Resolve.ResolveErrorType FIELD_EXPECTED;
        [JetBrains.Annotations.NotNullAttribute()]
        public static readonly JetBrains.ReSharper.Psi.Resolve.ResolveErrorType FIELD_OR_PROPERTY_EXPECTED;
        [JetBrains.Annotations.NotNullAttribute()]
        public static readonly JetBrains.ReSharper.Psi.Resolve.ResolveErrorType FIELD_OR_TEMPLATE_FIELD_EXPECTED;
        [JetBrains.Annotations.NotNullAttribute()]
        public static readonly JetBrains.ReSharper.Psi.Resolve.ResolveErrorType INCORRECT_RETURN_TYPE;
        [JetBrains.Annotations.NotNullAttribute()]
        public static readonly JetBrains.ReSharper.Psi.Resolve.ResolveErrorType INSTANTIABLE_EXPECTED;
        [JetBrains.Annotations.NotNullAttribute()]
        public static readonly JetBrains.ReSharper.Psi.Resolve.ResolveErrorType INVALID_MARKUP_TYPE;
        [JetBrains.Annotations.NotNullAttribute()]
        public static readonly JetBrains.ReSharper.Psi.Resolve.ResolveErrorType INVALID_RESOURCE_TYPE;
        [JetBrains.Annotations.NotNullAttribute()]
        public static readonly JetBrains.ReSharper.Psi.Resolve.ResolveErrorType INVALID_TYPE;
        [JetBrains.Annotations.NotNullAttribute()]
        public static readonly JetBrains.ReSharper.Psi.Resolve.ResolveErrorType METHOD_EXPECTED;
        [JetBrains.Annotations.NotNullAttribute()]
        public static readonly JetBrains.ReSharper.Psi.Resolve.ResolveErrorType MISPLACED_EVENT_HANDLER;
        [JetBrains.Annotations.NotNullAttribute()]
        public static readonly JetBrains.ReSharper.Psi.Resolve.ResolveErrorType NAMESPACE_ALIAS_EXPECTED;
        [JetBrains.Annotations.NotNullAttribute()]
        public static readonly JetBrains.ReSharper.Psi.Resolve.ResolveErrorType NAMESPACE_OR_NOT_NESTED_TYPE_EXPECTED;
        [JetBrains.Annotations.NotNullAttribute()]
        public static readonly JetBrains.ReSharper.Psi.Resolve.ResolveErrorType NESTED_TYPE_EXPECTED;
        [JetBrains.Annotations.NotNullAttribute()]
        public static readonly JetBrains.ReSharper.Psi.Resolve.ResolveErrorType NOT_NESTED_TYPE_EXPECTED;
        [JetBrains.Annotations.NotNullAttribute()]
        public static readonly JetBrains.ReSharper.Psi.Resolve.ResolveErrorType NOT_PUBLIC;
        [JetBrains.Annotations.NotNullAttribute()]
        public static readonly JetBrains.ReSharper.Psi.Resolve.ResolveErrorType NOT_STATIC;
        [JetBrains.Annotations.NotNullAttribute()]
        public static readonly JetBrains.ReSharper.Psi.Resolve.ResolveErrorType PARAMETER_COUNT_MISMATCH;
        [JetBrains.Annotations.NotNullAttribute()]
        public static readonly JetBrains.ReSharper.Psi.Resolve.ResolveErrorType PARAMETER_TYPES_MISMATCH;
        [JetBrains.Annotations.NotNullAttribute()]
        public static readonly JetBrains.ReSharper.Psi.Resolve.ResolveErrorType PROPERTY_EXPECTED;
        [JetBrains.Annotations.NotNullAttribute()]
        public static readonly JetBrains.ReSharper.Psi.Resolve.ResolveErrorType PROPERTY_OR_EVENT_EXPECTED;
        [JetBrains.Annotations.NotNullAttribute()]
        public static readonly JetBrains.ReSharper.Psi.Resolve.ResolveErrorType READABLE_PROPERTY_EXPECTED;
        [JetBrains.Annotations.NotNullAttribute()]
        public static readonly JetBrains.ReSharper.Psi.Resolve.ResolveErrorType RESOURCE_DICTIONARY_EXPECTED;
        [JetBrains.Annotations.NotNullAttribute()]
        public static readonly JetBrains.ReSharper.Psi.Resolve.ResolveErrorType RESOURCE_EXPECTED;
        [JetBrains.Annotations.NotNullAttribute()]
        public static readonly JetBrains.ReSharper.Psi.Resolve.ResolveErrorType STATIC_RESOURCE_NOT_FOUND;
        [JetBrains.Annotations.NotNullAttribute()]
        public static readonly JetBrains.ReSharper.Psi.Resolve.ResolveErrorType TYPE_OR_PROPERTY_EXPECTED;
        [JetBrains.Annotations.NotNullAttribute()]
        public static readonly JetBrains.ReSharper.Psi.Resolve.ResolveErrorType WRITABLE_PROPERTY_EXPECTED;
        [JetBrains.Annotations.NotNullAttribute()]
        public static readonly JetBrains.ReSharper.Psi.Resolve.ResolveErrorType WRITABLE_PROPERTY_OR_COLLECTION_EXPECTED;
        [JetBrains.Annotations.NotNullAttribute()]
        public static readonly JetBrains.ReSharper.Psi.Resolve.ResolveErrorType XAML_LANGUAGE_LEVEL_ERROR;
        public XamlResolveErrorType(string name, string tooltip) { }
    }
    public class static XamlResolveFilters
    {
        public static readonly JetBrains.ReSharper.Psi.Resolve.SimpleSymbolFilter CanBeInstantiated;
        public static readonly JetBrains.ReSharper.Psi.Resolve.SimpleSymbolFilter CanContainsDependencyProperties;
        public static readonly JetBrains.ReSharper.Psi.Resolve.SimpleSymbolFilter DefaultProperty;
        public static readonly JetBrains.ReSharper.Psi.Resolve.SimpleSymbolFilter FileExists;
        public static readonly JetBrains.ReSharper.Psi.Resolve.SimpleSymbolFilter IsEnumMember;
        public static readonly JetBrains.ReSharper.Psi.Resolve.SimpleSymbolFilter IsField;
        public static readonly JetBrains.ReSharper.Psi.Resolve.SimpleSymbolFilter IsFieldOrProperty;
        public static readonly JetBrains.ReSharper.Psi.Resolve.SimpleSymbolFilter IsFieldOrTemplateField;
        public static readonly JetBrains.ReSharper.Psi.Resolve.SimpleSymbolFilter IsInstance;
        public static readonly JetBrains.ReSharper.Psi.Resolve.SimpleSymbolFilter IsMarkupAttribute;
        public static readonly JetBrains.ReSharper.Psi.Resolve.SimpleSymbolFilter IsMethod;
        public static readonly JetBrains.ReSharper.Psi.Resolve.SimpleSymbolFilter IsNamespaceOrNotNestedType;
        public static readonly JetBrains.ReSharper.Psi.Resolve.SimpleSymbolFilter IsNestedType;
        public static readonly JetBrains.ReSharper.Psi.Resolve.SimpleSymbolFilter IsNotNestedType;
        public static readonly JetBrains.ReSharper.Psi.Resolve.SimpleSymbolFilter IsNotPredefinedAttributeElement;
        public static readonly JetBrains.ReSharper.Psi.Resolve.SimpleSymbolFilter IsNotPredefinedObjectElement;
        public static readonly JetBrains.ReSharper.Psi.Resolve.SimpleSymbolFilter IsProjectFolderOrModule;
        public static readonly JetBrains.ReSharper.Psi.Resolve.SimpleSymbolFilter IsProperty;
        public static readonly JetBrains.ReSharper.Psi.Resolve.SimpleSymbolFilter IsPropertyOrEvent;
        public static readonly JetBrains.ReSharper.Psi.Resolve.SimpleSymbolFilter IsPublic;
        public static readonly JetBrains.ReSharper.Psi.Resolve.SimpleSymbolFilter IsPublicOrInternal;
        public static readonly JetBrains.ReSharper.Psi.Resolve.SimpleSymbolFilter IsStatic;
        public static readonly JetBrains.ReSharper.Psi.Resolve.SimpleSymbolFilter NonGeneric;
        public static readonly JetBrains.ReSharper.Psi.Resolve.ISymbolFilter SymbolLevel;
        public static JetBrains.ReSharper.Psi.Resolve.ISymbolFilter CreateGenericsFilter(JetBrains.ReSharper.Psi.Tree.ITreeNode context) { }
        public static JetBrains.ReSharper.Psi.Resolve.ISymbolFilter IsWritablePropertyOrCollection(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public class IsClassFilter : JetBrains.ReSharper.Psi.Resolve.SimpleSymbolFilter
        {
            public IsClassFilter([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
            public override JetBrains.ReSharper.Psi.Resolve.ResolveErrorType ErrorType { get; }
            public override bool Accepts(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution) { }
        }
        public class IsMarkupExtensionTypeConvertibleTo : JetBrains.ReSharper.Psi.Xaml.Impl.Resolve.XamlResolveFilters.IsTypeConvertibleBase
        {
            public IsMarkupExtensionTypeConvertibleTo([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode context, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IType[] expectedTypes) { }
            public override JetBrains.ReSharper.Psi.Resolve.ResolveErrorType ErrorType { get; }
            public override bool Accepts(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution) { }
        }
        public sealed class IsModuleWithResourcesFilter : JetBrains.ReSharper.Psi.Resolve.SimpleSymbolFilter
        {
            public IsModuleWithResourcesFilter([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.ISolution solution) { }
            public override JetBrains.ReSharper.Psi.Resolve.ResolveErrorType ErrorType { get; }
            public override bool Accepts(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution) { }
        }
        public abstract class IsTypeConvertibleBase : JetBrains.ReSharper.Psi.Resolve.SimpleSymbolFilter
        {
            protected JetBrains.ReSharper.Psi.Tree.ITreeNode Context;
            protected readonly JetBrains.ReSharper.Psi.IType[] ExpectedTypes;
            protected JetBrains.ReSharper.Psi.Xaml.Impl.IXamlTypeConversionRule Rule;
            protected JetBrains.ReSharper.Psi.Xaml.Impl.Resolve.IXamlTypeCache TypeCache;
            protected IsTypeConvertibleBase(JetBrains.ReSharper.Psi.Tree.ITreeNode context, JetBrains.ReSharper.Psi.IType[] expectedTypes) { }
            protected bool CheckMarkupExtension(JetBrains.ReSharper.Psi.IType type) { }
        }
        public class IsTypeConvertibleTo : JetBrains.ReSharper.Psi.Xaml.Impl.Resolve.XamlResolveFilters.IsTypeConvertibleBase
        {
            public IsTypeConvertibleTo([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode context, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IType[] expectedTypes, bool allowMarkupExtensions, bool checkSubstitution) { }
            public override JetBrains.ReSharper.Psi.Resolve.ResolveErrorType ErrorType { get; }
            public override bool Accepts(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution) { }
        }
        public class IsTypeFilter : JetBrains.ReSharper.Psi.Resolve.SimpleSymbolFilter
        {
            public IsTypeFilter([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
            public override JetBrains.ReSharper.Psi.Resolve.ResolveErrorType ErrorType { get; }
            public override bool Accepts(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution) { }
        }
        public class IsTypeOwnerCLRConvertibleTo : JetBrains.ReSharper.Psi.Resolve.SimpleSymbolFilter
        {
            public IsTypeOwnerCLRConvertibleTo([JetBrains.Annotations.NotNullAttribute()] params JetBrains.ReSharper.Psi.IType[] expectedTypes) { }
            public override JetBrains.ReSharper.Psi.Resolve.ResolveErrorType ErrorType { get; }
            public override bool Accepts(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution) { }
        }
        public class IsTypeOwnerConvertibleTo : JetBrains.ReSharper.Psi.Resolve.SimpleSymbolFilter
        {
            public IsTypeOwnerConvertibleTo([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.ITypeConversionRule rule, [JetBrains.Annotations.NotNullAttribute()] params JetBrains.ReSharper.Psi.IType[] expectedTypes) { }
            public override JetBrains.ReSharper.Psi.Resolve.ResolveErrorType ErrorType { get; }
            public override bool Accepts(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution) { }
        }
        public class IsTypeOwnerTypeConvertiblePredefined : JetBrains.ReSharper.Psi.Resolve.SimpleSymbolFilter
        {
            public IsTypeOwnerTypeConvertiblePredefined([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.ITypeConversionRule rule, params JetBrains.ReSharper.Psi.IType[] types) { }
            public override JetBrains.ReSharper.Psi.Resolve.ResolveErrorType ErrorType { get; }
            public override bool Accepts(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution) { }
        }
        public class IsXamlClassInstantiable : JetBrains.ReSharper.Psi.Resolve.SimpleSymbolFilter
        {
            public IsXamlClassInstantiable([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode node) { }
            public override JetBrains.ReSharper.Psi.Resolve.ResolveErrorType ErrorType { get; }
            public override bool Accepts(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution) { }
        }
        public class ParameterCountFilter : JetBrains.ReSharper.Psi.Resolve.SimpleSymbolFilter
        {
            public ParameterCountFilter(int count) { }
            public override JetBrains.ReSharper.Psi.Resolve.ResolveErrorType ErrorType { get; }
            public override bool Accepts(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution) { }
        }
        public class ParameterTypesFilter : JetBrains.ReSharper.Psi.Resolve.SimpleSymbolFilter
        {
            public ParameterTypesFilter([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IType[] parameterTypes) { }
            public override JetBrains.ReSharper.Psi.Resolve.ResolveErrorType ErrorType { get; }
            public override bool Accepts(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution) { }
        }
        public class XamlLanguageLevelFilter : JetBrains.ReSharper.Psi.Resolve.SimpleSymbolFilter
        {
            public XamlLanguageLevelFilter([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
            public override JetBrains.ReSharper.Psi.Resolve.ResolveErrorType ErrorType { get; }
            public override bool Accepts(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution) { }
        }
    }
    public class static XamlResolveUtil
    {
        public static JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetNamespaceAliasSymbolTable([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xaml.DeclaredElements.IXamlNamespaceAlias alias, JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext context) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetNamespaceAliasSymbolTable([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Xaml.Tree.IXamlNamespaceAliasReference reference) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Psi.IType GetQualifierType([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Resolve.IReference qualifierReference) { }
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        public static JetBrains.ReSharper.Psi.ITypeElement GetQualifierTypeElement(JetBrains.ReSharper.Psi.Resolve.IReference qualifierReference) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Psi.IType GetUsedMemberType([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Xaml.Impl.Tree.ITypeMemberUsage typeMemberUsage) { }
        public static bool HasTypeConverterAnnotation(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public static bool IsElementInXmlData([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public static bool IsReferenceInXmlData([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
    }
    public class static XamlResourceFilters
    {
        public static readonly JetBrains.ReSharper.Psi.Resolve.SimpleSymbolFilter IsResource;
        public static readonly JetBrains.ReSharper.Psi.Resolve.SimpleSymbolFilter IsSimpleKeyResource;
        public static readonly JetBrains.ReSharper.Psi.Resolve.ISymbolFilter ResourceKeyOverride;
        public class ResourceKeyFilter : JetBrains.ReSharper.Psi.Resolve.ISymbolFilter
        {
            public ResourceKeyFilter([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IType typeKey) { }
            public ResourceKeyFilter([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IDeclaredElement staticMemberKey) { }
            public JetBrains.ReSharper.Psi.Resolve.ResolveErrorType ErrorType { get; }
            public JetBrains.ReSharper.Psi.Resolve.FilterRunType RunType { get; }
            public System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Resolve.ISymbolInfo> FilterArray(System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Resolve.ISymbolInfo> data) { }
        }
        public class ResourceTypeFilter : JetBrains.ReSharper.Psi.Resolve.SimpleSymbolFilter
        {
            public ResourceTypeFilter([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xaml.Impl.IXamlTypeConversionRule rule, [JetBrains.Annotations.NotNullAttribute()] params JetBrains.ReSharper.Psi.IType[] expectedTypes) { }
            public override JetBrains.ReSharper.Psi.Resolve.ResolveErrorType ErrorType { get; }
            public override bool Accepts(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution) { }
        }
        public class StaticResourceFilter : JetBrains.ReSharper.Psi.Resolve.ISymbolFilter
        {
            public StaticResourceFilter([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode node) { }
            public JetBrains.ReSharper.Psi.Resolve.ResolveErrorType ErrorType { get; }
            public JetBrains.ReSharper.Psi.Resolve.FilterRunType RunType { get; }
            public System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Resolve.ISymbolInfo> FilterArray(System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Resolve.ISymbolInfo> data) { }
        }
    }
    [JetBrains.ReSharper.Psi.PsiComponentAttribute()]
    public class XamlTypeCache : JetBrains.ReSharper.Psi.Xaml.Impl.Resolve.XamlModuleTypeCache<JetBrains.ReSharper.Psi.Xaml.Impl.Resolve.IXamlTypeCache, JetBrains.ReSharper.Psi.Xaml.Impl.Resolve.XamlTypeCache>
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public static readonly JetBrains.ReSharper.Psi.IClrTypeName CONSTRUCTOR_ARGUMENT_ATTRIBUTE_CLASS;
        [JetBrains.Annotations.NotNullAttribute()]
        public static readonly JetBrains.ReSharper.Psi.IClrTypeName MARKUP_EXTENSION_RETURN_TYPE_ATTRIBUTE_CLASS;
        [JetBrains.Annotations.NotNullAttribute()]
        public static readonly JetBrains.ReSharper.Psi.IClrTypeName TYPE_CONVERTER_ATTRIBUTE_CLASS;
        [JetBrains.Annotations.NotNullAttribute()]
        public static readonly JetBrains.ReSharper.Psi.IClrTypeName VALUE_CONVERSION_ATTRIBUTE_CLASS;
        [JetBrains.Annotations.NotNullAttribute()]
        public static readonly JetBrains.ReSharper.Psi.IClrTypeName XAML_DEFER_LOAD_ATTRIBUTE_CLASS;
        public XamlTypeCache([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Modules.IPsiModules psiModules, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.ChangeManager changeManager) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.ReSharper.Psi.IDeclaredType UnknownType([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
    }
    public class static XamlTypeCacheExtensions
    {
        public static System.Collections.Generic.IList<JetBrains.ReSharper.Psi.IType> GetContentTypes(this JetBrains.ReSharper.Psi.Xaml.Impl.Resolve.IXamlTypeCache cache, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IType type) { }
        public static bool IsCollectionTypeExceptArray(this JetBrains.ReSharper.Psi.Xaml.Impl.Resolve.IXamlTypeCache cache, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IType type, out JetBrains.ReSharper.Psi.IType elementType) { }
    }
}
namespace JetBrains.ReSharper.Psi.Xaml.Impl.Tree
{
    
    public interface IPropertySetter : JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xaml.Impl.Tree.ITypeMemberUsage, JetBrains.ReSharper.Psi.Xaml.Impl.Tree.ITypeUsage
    {
        [JetBrains.Annotations.NotNullAttribute()]
        string PropertyName { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Tree.ITreeNode ValueElement { get; }
    }
    public interface ITypeMemberReference : JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IQualifiableReferenceBase, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IQualifiableReferenceWithGlobalSymbolTable, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IReferenceWithGlobalSymbolTable, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IReferenceWithQualifier, JetBrains.ReSharper.Psi.Resolve.ICompleteableReference, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.ReSharper.Psi.Xaml.Tree.ISmartCompleteableReference, JetBrains.ReSharper.Psi.Xaml.Tree.IXamlReference, JetBrains.ReSharper.Psi.Xml.Tree.References.IXmlCompleteableReference, JetBrains.ReSharper.Psi.Xml.Tree.References.IXmlReference, JetBrains.ReSharper.Psi.Xml.Tree.References.IXmlSmartCompleteableReference, JetBrains.Util.IUserDataHolder
    {
        JetBrains.ReSharper.Psi.Xaml.Impl.Tree.IValueReferenceData ValueReferenceData { get; }
    }
    public interface ITypeMemberUsage : JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xaml.Impl.Tree.ITypeUsage
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Resolve.IReference ContainingTypeReference { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Xaml.Impl.Tree.ITypeMemberReference MemberReference { get; }
    }
    public interface ITypeUsage : JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Resolve.IReference TypeReference { get; }
    }
    public interface IValueReferenceData
    {
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IType GetExpectedType();
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.IDeclaredType GetReferencedEventType();
        JetBrains.ReSharper.Psi.Xaml.Tree.ValueReferenceType GetValueReferenceType();
    }
    public interface IXamlHashableDeclaration : JetBrains.ReSharper.Psi.Dependencies.IHashableDeclaration, JetBrains.ReSharper.Psi.Tree.IDeclaration, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Tree.IXmlDocOwnerTreeNode, JetBrains.ReSharper.Psi.Xaml.Impl.Tree.IXamlHashableEntity { }
    public interface IXamlHashableEntity
    {
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Xaml.Impl.Tree.IXamlHashableEntity> Children { get; }
        bool IsInternal { get; }
        JetBrains.ReSharper.Psi.Dependencies.IHashableEntityInfo[] CalcAllHashes(string parentQualifiedName, out string qualifiedName);
    }
    public interface IXDataElement : JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IIncrementalScope, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IScope, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xaml.Impl.Tree.ITypeUsage, JetBrains.ReSharper.Psi.Xaml.Tree.IXamlObjectElement, JetBrains.ReSharper.Psi.Xaml.Tree.IXamlTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagContainer, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode { }
    public class static PropertyAttributeNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.Xaml.Tree.IPropertyAttribute GetByAttributeValue(JetBrains.ReSharper.Psi.Xaml.Tree.IPropertyAttributeValue value) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.Xaml.Tree.IPropertyAttribute GetByMarkup(JetBrains.ReSharper.Psi.Xaml.Tree.MarkupExtensions.IMarkup value) { }
    }
    public class static StyleDeclarationExtensions
    {
        public static JetBrains.ReSharper.Psi.Resolve.IReference GetStyleTargetTypeReference([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Xaml.Tree.IResourceDeclaration resourceDeclaration) { }
    }
    public class static XamlObjectElementNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.Xaml.Tree.IXamlObjectElement GetByAttribute(JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttribute attribute) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.Xaml.Tree.IXamlObjectElement GetBySetter(JetBrains.ReSharper.Psi.Xaml.Impl.Tree.IPropertySetter setter) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.Xaml.Tree.IXamlObjectElement GetByTag(JetBrains.ReSharper.Psi.Xaml.Tree.IXamlTag tag) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.Xaml.Tree.IXamlObjectElement GetByTagFooter(JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagFooter footer) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.Xaml.Tree.IXamlObjectElement GetByTagHeader(JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagHeader header) { }
    }
    public class static XamlPropertyElementNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.Xaml.Tree.IXamlPropertyElement GetByTag(JetBrains.ReSharper.Psi.Xaml.Tree.IXamlTag tag) { }
    }
    public class static XamlTagExtensions
    {
        public static string GetInnerText(this JetBrains.ReSharper.Psi.Xaml.Tree.IXamlTag xamlTag) { }
        public static JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken GetSingleInnerToken(this JetBrains.ReSharper.Psi.Xaml.Tree.IXamlTag xamlTag, out JetBrains.ReSharper.Psi.TreeTextRange rangeWithin) { }
        public static bool IsAllTokens(this JetBrains.ReSharper.Psi.Xaml.Tree.IXamlTag xamlTag) { }
    }
    public class static XamlTagNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.Xaml.Tree.IXamlTag GetByAttribute(JetBrains.ReSharper.Psi.Xaml.Tree.IXamlAttribute attribute) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.Xaml.Tree.IXamlTag GetByTag(JetBrains.ReSharper.Psi.Xaml.Tree.IXamlTag tag) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.Xaml.Tree.IXamlTag GetByTagHeader(JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagHeader header) { }
    }
    public class XamlToken : JetBrains.ReSharper.Psi.Xml.Impl.Tree.XmlToken, JetBrains.ReSharper.Psi.Tree.ITokenNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xaml.Tree.IXamlToken, JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        public XamlToken(JetBrains.ReSharper.Psi.Parsing.XmlTokenNodeType type, JetBrains.Text.IBuffer buffer, JetBrains.ReSharper.Psi.TreeOffset startOffset, JetBrains.ReSharper.Psi.TreeOffset endOffset) { }
        public JetBrains.ReSharper.Psi.Xaml.Parsing.XamlTokenTypes XamlTokenTypes { get; }
    }
    public sealed class XamlValueToken : JetBrains.ReSharper.Psi.Xml.Impl.Tree.XmlValueToken, JetBrains.ReSharper.Psi.Tree.ITokenNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xaml.Tree.IXamlToken, JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        public XamlValueToken(JetBrains.ReSharper.Psi.Parsing.XmlTokenNodeType type, JetBrains.Text.IBuffer buffer, JetBrains.ReSharper.Psi.TreeOffset startOffset, JetBrains.ReSharper.Psi.TreeOffset endOffset) { }
        public JetBrains.ReSharper.Psi.Xaml.Parsing.XamlTokenTypes XamlTokenTypes { get; }
    }
}
namespace JetBrains.ReSharper.Psi.Xaml.Impl.Tree.References
{
    
    public interface IXamlNamespaceReference : JetBrains.ReSharper.Psi.Resolve.ICompleteableReference, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.ReSharper.Psi.Xaml.Tree.IXamlReference, JetBrains.ReSharper.Psi.Xml.Tree.References.IXmlCompleteableReference, JetBrains.ReSharper.Psi.Xml.Tree.References.IXmlReference, JetBrains.Util.IUserDataHolder
    {
        JetBrains.ReSharper.Psi.TreeTextRange RangeWithin { get; }
        JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken Token { get; }
        JetBrains.ReSharper.Psi.Xaml.Impl.Tree.References.IXamlNamespaceReference BindModuleTo(JetBrains.ReSharper.Psi.Modules.IPsiModule module);
    }
    public abstract class XamlConstructorReferenceBase<T> : JetBrains.ReSharper.Psi.Xaml.Impl.Tree.References.XamlReferenceWithTokenBase<T>, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.ReSharper.Psi.Xaml.Tree.IXamlConstructorReference, JetBrains.ReSharper.Psi.Xaml.Tree.IXamlFunctionReference, JetBrains.ReSharper.Psi.Xaml.Tree.IXamlReference, JetBrains.ReSharper.Psi.Xml.Tree.References.IXmlReference, JetBrains.Util.IUserDataHolder
        where T : JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        protected XamlConstructorReferenceBase(T owner, JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken token, JetBrains.ReSharper.Psi.TreeTextRange rangeWithin) { }
        public abstract System.Collections.Generic.IList<JetBrains.ReSharper.Psi.IType> ParameterTypes { get; }
        public abstract JetBrains.ReSharper.Psi.Resolve.IReference TypeReference { get; }
        protected override JetBrains.ReSharper.Psi.Resolve.IReference BindToInternal(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution) { }
        public override string GetName() { }
        public virtual JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetReferenceSymbolTable(bool useReferenceName) { }
        protected override JetBrains.ReSharper.Psi.Resolve.ISymbolFilter[] GetSmartSymbolFilters(out bool applyAllFilters) { }
        protected virtual JetBrains.ReSharper.Psi.Resolve.ISubstitution GetSubstitution(JetBrains.ReSharper.Psi.ITypeElement typeElement) { }
        protected virtual JetBrains.ReSharper.Psi.ITypeElement GetTypeElement() { }
        public override JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.ResolveResultWithInfo ResolveWithoutCache() { }
    }
    public class XamlNamespaceAliasReference : JetBrains.ReSharper.Psi.Xaml.Impl.Tree.References.XamlReferenceWithDefaultSymbolTable<JetBrains.ReSharper.Psi.Tree.ITreeNode>, JetBrains.ReSharper.Psi.Resolve.ICompleteableReference, JetBrains.ReSharper.Psi.Resolve.IQualifier, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.ReSharper.Psi.Xaml.Tree.ISmartCompleteableReference, JetBrains.ReSharper.Psi.Xaml.Tree.IXamlNamespaceAliasReference, JetBrains.ReSharper.Psi.Xaml.Tree.IXamlReference, JetBrains.ReSharper.Psi.Xml.Tree.References.IXmlCompleteableReference, JetBrains.ReSharper.Psi.Xml.Tree.References.IXmlReference, JetBrains.ReSharper.Psi.Xml.Tree.References.IXmlSmartCompleteableReference, JetBrains.Util.IUserDataHolder
    {
        public XamlNamespaceAliasReference(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken token, bool ignorable = False) { }
        public XamlNamespaceAliasReference(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken token, JetBrains.ReSharper.Psi.TreeTextRange rangeWithin, bool ignorable = False) { }
        public bool Resolved { get; }
        protected override JetBrains.ReSharper.Psi.Resolve.IReference BindToInternal(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution) { }
        public override JetBrains.ReSharper.Psi.ITypeElement GetAccessContainingTypeElement() { }
        protected override JetBrains.ReSharper.Psi.Resolve.ISymbolFilter[] GetCompletionFilters() { }
        public JetBrains.ReSharper.Psi.Resolve.QualifierKind GetKind() { }
        public override JetBrains.ReSharper.Psi.Resolve.QualifierKind GetQualifierKind() { }
        protected override JetBrains.ReSharper.Psi.Resolve.ISymbolFilter[] GetSmartSymbolFilters(out bool applyAllFilters) { }
        public override JetBrains.ReSharper.Psi.Resolve.Staticness GetStaticness() { }
        public JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetSymbolTable(JetBrains.ReSharper.Psi.Resolve.SymbolTableMode mode) { }
        public override JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.ResolveResultWithInfo ResolveWithoutCache() { }
    }
    public class XamlPlainNamespaceAliasReference : JetBrains.ReSharper.Psi.Xaml.Impl.Tree.References.XamlNamespaceAliasReference
    {
        public XamlPlainNamespaceAliasReference(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken token, JetBrains.ReSharper.Psi.TreeTextRange rangeWithin) { }
    }
    public abstract class XamlReferenceWithDefaultSymbolTable<T> : JetBrains.ReSharper.Psi.Xaml.Impl.Tree.References.XamlReferenceWithTokenBase<T>, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IQualifiableReferenceBase, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IQualifiableReferenceWithGlobalSymbolTable, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IReferenceWithGlobalSymbolTable, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IReferenceWithQualifier, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.Util.IUserDataHolder
        where T : JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        protected XamlReferenceWithDefaultSymbolTable(T owner, JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken token, JetBrains.ReSharper.Psi.TreeTextRange rangeWithin) { }
        public bool IsQualified { get; }
        public JetBrains.ReSharper.Psi.Resolve.IQualifier GetQualifier() { }
        public override JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetReferenceSymbolTable(bool useReferenceName) { }
        public JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.ResolveResultWithInfo Resolve(JetBrains.ReSharper.Psi.Resolve.ISymbolTable symbolTable, JetBrains.ReSharper.Psi.Resolve.IAccessContext context) { }
    }
    public abstract class XamlReferenceWithTokenBase<T> : JetBrains.ReSharper.Psi.Xml.Impl.Tree.References.XmlReferenceWithTokenBase<T>, JetBrains.ReSharper.Psi.Impl.Shared.References.IReferenceWithinElement<JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken>, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.ReSharper.Psi.Xaml.Tree.IXamlReference, JetBrains.ReSharper.Psi.Xaml.Tree.IXamlReferenceWithToken, JetBrains.ReSharper.Psi.Xml.Tree.References.IReferenceWithToken, JetBrains.ReSharper.Psi.Xml.Tree.References.IXmlReference, JetBrains.Util.IUserDataHolder
        where T : JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        protected XamlReferenceWithTokenBase(T owner, JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken token, JetBrains.ReSharper.Psi.TreeTextRange rangeWithin) { }
        public override JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.ResolveResultWithInfo ResolveWithoutCache() { }
    }
    public class XamlResourceByStaticMemberReference : JetBrains.ReSharper.Psi.Xaml.Impl.Tree.References.XamlResourceReference, JetBrains.ReSharper.Psi.Resolve.ICompleteableReference, JetBrains.ReSharper.Psi.Resolve.ILateBoundReference, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.ReSharper.Psi.Xaml.Tree.IResourceByStaticMemberReference, JetBrains.ReSharper.Psi.Xaml.Tree.IResourceReference, JetBrains.ReSharper.Psi.Xaml.Tree.ISmartCompleteableReference, JetBrains.ReSharper.Psi.Xaml.Tree.IXamlReference, JetBrains.ReSharper.Psi.Xml.Tree.References.IXmlCompleteableReference, JetBrains.ReSharper.Psi.Xml.Tree.References.IXmlReference, JetBrains.ReSharper.Psi.Xml.Tree.References.IXmlSmartCompleteableReference, JetBrains.Util.IUserDataHolder
    {
        protected override JetBrains.ReSharper.Psi.Resolve.IReference BindToInternal(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution) { }
        public override string GetName() { }
        protected override JetBrains.ReSharper.Psi.Resolve.ISymbolFilter[] GetResourceSymbolFilters(bool isResolve) { }
        public JetBrains.ReSharper.Psi.IDeclaredElement GetStaticMember() { }
        public override JetBrains.ReSharper.Psi.TreeTextRange GetTreeTextRange() { }
        public override JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.ResolveResultWithInfo ResolveWithoutCache() { }
    }
    public class XamlResourceByTypeReference : JetBrains.ReSharper.Psi.Xaml.Impl.Tree.References.XamlResourceReference, JetBrains.ReSharper.Psi.Resolve.ICompleteableReference, JetBrains.ReSharper.Psi.Resolve.ILateBoundReference, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.ReSharper.Psi.Xaml.Tree.IResourceByTypeReference, JetBrains.ReSharper.Psi.Xaml.Tree.IResourceReference, JetBrains.ReSharper.Psi.Xaml.Tree.ISmartCompleteableReference, JetBrains.ReSharper.Psi.Xaml.Tree.IXamlReference, JetBrains.ReSharper.Psi.Xml.Tree.References.IXmlCompleteableReference, JetBrains.ReSharper.Psi.Xml.Tree.References.IXmlReference, JetBrains.ReSharper.Psi.Xml.Tree.References.IXmlSmartCompleteableReference, JetBrains.Util.IUserDataHolder
    {
        public XamlResourceByTypeReference(JetBrains.ReSharper.Psi.Xaml.Impl.Tree.ITypeUsage owner) { }
        protected override JetBrains.ReSharper.Psi.Resolve.IReference BindToInternal(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution) { }
        [JetBrains.Annotations.NotNullAttribute()]
        protected JetBrains.ReSharper.Psi.IType GetExpectedKeyType() { }
        public JetBrains.ReSharper.Psi.IType GetKeyType() { }
        public override string GetName() { }
        protected override JetBrains.ReSharper.Psi.Resolve.ISymbolFilter[] GetResourceSymbolFilters(bool isResolve) { }
        public override JetBrains.ReSharper.Psi.TreeTextRange GetTreeTextRange() { }
        public override JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.ResolveResultWithInfo ResolveWithoutCache() { }
    }
    public class XamlResourceInSpecificDictionaryReference : JetBrains.ReSharper.Psi.Xaml.Impl.Tree.References.XamlResourceReference, JetBrains.ReSharper.Psi.Resolve.ICompleteableReference, JetBrains.ReSharper.Psi.Resolve.ILateBoundReference, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.ReSharper.Psi.Xaml.Tree.IResourceInSpecificContainerReference, JetBrains.ReSharper.Psi.Xaml.Tree.IResourceReference, JetBrains.ReSharper.Psi.Xaml.Tree.ISmartCompleteableReference, JetBrains.ReSharper.Psi.Xaml.Tree.IXamlReference, JetBrains.ReSharper.Psi.Xml.Tree.References.IXmlCompleteableReference, JetBrains.ReSharper.Psi.Xml.Tree.References.IXmlReference, JetBrains.ReSharper.Psi.Xml.Tree.References.IXmlSmartCompleteableReference, JetBrains.Util.IUserDataHolder
    {
        public XamlResourceInSpecificDictionaryReference(JetBrains.ReSharper.Psi.Xaml.Tree.MarkupExtensions.IIndexerParameter owner, JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken token, JetBrains.ReSharper.Psi.TreeTextRange rangeWithin) { }
        public override bool IsStatic { get; }
        public JetBrains.ReSharper.Psi.Xaml.Tree.IXamlObjectElement TargetContainer { get; }
        protected override JetBrains.ReSharper.Psi.IType[] GetExpectedTypes() { }
        public override JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetReferenceSymbolTable(bool useReferenceName) { }
        public override JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.ResolveResultWithInfo ResolveWithoutCache() { }
    }
    public class XamlResourceReference : JetBrains.ReSharper.Psi.Xaml.Impl.Tree.References.XamlReferenceWithTokenBase<JetBrains.ReSharper.Psi.Tree.ITreeNode>, JetBrains.ReSharper.Psi.Resolve.ICompleteableReference, JetBrains.ReSharper.Psi.Resolve.ILateBoundReference, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.ReSharper.Psi.Xaml.Tree.IResourceReference, JetBrains.ReSharper.Psi.Xaml.Tree.ISmartCompleteableReference, JetBrains.ReSharper.Psi.Xaml.Tree.IXamlReference, JetBrains.ReSharper.Psi.Xml.Tree.References.IXmlCompleteableReference, JetBrains.ReSharper.Psi.Xml.Tree.References.IXmlReference, JetBrains.ReSharper.Psi.Xml.Tree.References.IXmlSmartCompleteableReference, JetBrains.Util.IUserDataHolder
    {
        public XamlResourceReference(JetBrains.ReSharper.Psi.Tree.ITreeNode owner, JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken token, JetBrains.ReSharper.Psi.TreeTextRange rangeWithin) { }
        protected bool CanBeComplexKey { get; }
        public virtual bool IsStatic { get; }
        public JetBrains.ReSharper.Psi.Xaml.Impl.Tree.ITypeMemberReference TargetMemberReference { get; }
        protected override JetBrains.ReSharper.Psi.Resolve.IReference BindToInternal(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution) { }
        protected override JetBrains.ReSharper.Psi.Resolve.ISymbolFilter[] GetCompletionFilters() { }
        public JetBrains.ReSharper.Psi.IType GetExpectedType() { }
        [JetBrains.Annotations.NotNullAttribute()]
        protected virtual JetBrains.ReSharper.Psi.IType[] GetExpectedTypes() { }
        public override string GetName() { }
        public override JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetReferenceSymbolTable(bool useReferenceName) { }
        protected virtual JetBrains.ReSharper.Psi.Resolve.ISymbolFilter[] GetResourceSymbolFilters(bool isResolve) { }
        protected virtual JetBrains.ReSharper.Psi.Resolve.ISymbolFilter[] GetSmartSymbolFilters(out bool applyAllFilters) { }
        public override JetBrains.ReSharper.Psi.Resolve.ISymbolFilter[] GetSymbolFilters() { }
        public JetBrains.ReSharper.Psi.Resolve.Refers RefersToDeclaredElement(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
        public override JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.ResolveResultWithInfo ResolveWithoutCache() { }
    }
    public class XamlTypeDeclarationConstructorReference : JetBrains.ReSharper.Psi.Xaml.Impl.Tree.References.XamlConstructorReferenceBase<JetBrains.ReSharper.Psi.Xaml.Tree.IXClassAttribute>
    {
        public XamlTypeDeclarationConstructorReference(JetBrains.ReSharper.Psi.Xaml.Tree.IXClassAttribute owner, JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken token, JetBrains.ReSharper.Psi.TreeTextRange rangeWithin) { }
        public override System.Collections.Generic.IList<JetBrains.ReSharper.Psi.IType> ParameterTypes { get; }
        public override JetBrains.ReSharper.Psi.Resolve.IReference TypeReference { get; }
        protected override JetBrains.ReSharper.Psi.ITypeElement GetTypeElement() { }
        public override bool IsValid() { }
    }
    [System.FlagsAttribute()]
    public enum XamlTypeReferenceType
    {
        ANY = 0,
        CLASS = 1,
        INSTANTIATABLE = 2,
    }
}
namespace JetBrains.ReSharper.Psi.Xaml.Impl.Util
{
    
    public class static AttachedEventUtil
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Resolve.ISymbolFilter> CreateAddHandlerFilters([JetBrains.Annotations.CanBeNullAttribute()] string referenceName, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode element, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Resolve.ISymbolFilter accessFilter, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.IType ownerType) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Resolve.ISymbolFilter> CreateAddHandlerFilters([JetBrains.Annotations.CanBeNullAttribute()] string referenceName, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Modules.IPsiModule module, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Resolve.ISymbolFilter accessFilter, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.IType ownerType) { }
        public static System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Resolve.ISymbolFilter> CreateRemoveHandlerFilters([JetBrains.Annotations.CanBeNullAttribute()] string referenceName, JetBrains.ReSharper.Psi.Tree.ITreeNode element, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Resolve.ISymbolFilter accessFilter, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.IType ownerType) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Resolve.ISymbolFilter> CreateRoutedEventFieldFilters([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Modules.IPsiModule module, JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext context) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Resolve.ISymbolFilter> CreateRoutedEventFilters([JetBrains.Annotations.CanBeNullAttribute()] string referenceName, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode element, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Resolve.ISymbolFilter accessFilter) { }
        public static System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Resolve.ISymbolFilter> CreateRoutedEventFilters([JetBrains.Annotations.CanBeNullAttribute()] string referenceName, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Modules.IPsiModule module, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Resolve.ISymbolFilter accessFilter) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static string GetAddHandlerName([JetBrains.Annotations.NotNullAttribute()] string referenceName) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Psi.IType GetAttachedEventType(JetBrains.ReSharper.Psi.IDeclaredElement accessor, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static string GetEventFieldName([JetBrains.Annotations.NotNullAttribute()] string referenceName) { }
        public static string GetReferenceName(string accessorOrEventName) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static string GetRemoveHandlerName([JetBrains.Annotations.NotNullAttribute()] string referenceName) { }
        public static bool IsAddHandler([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public static bool IsAddHandlerName([JetBrains.Annotations.NotNullAttribute()] string methodName) { }
        public static bool IsRemoveHandler([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public static bool IsRemoveHandlerName([JetBrains.Annotations.NotNullAttribute()] string methodName) { }
        public static bool IsRoutedEventField([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IDeclaredElement element, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution) { }
        public static bool IsRoutedEventFieldName(string eventName) { }
        public static JetBrains.ReSharper.Psi.Xaml.DeclaredElements.IXamlAttachedEvent WrapAccessorToEvent([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IMethod addMethod) { }
        public class HasRoutedEventFieldFilter : JetBrains.ReSharper.Psi.Resolve.SimpleSymbolFilter
        {
            public HasRoutedEventFieldFilter([JetBrains.Annotations.CanBeNullAttribute()] string referenceName, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Modules.IPsiModule module, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Resolve.ISymbolFilter accessFilter) { }
            public HasRoutedEventFieldFilter([JetBrains.Annotations.CanBeNullAttribute()] string referenceName, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode element, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Resolve.ISymbolFilter accessFilter) { }
            public override JetBrains.ReSharper.Psi.Resolve.ResolveErrorType ErrorType { get; }
            public override bool Accepts(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution) { }
        }
    }
    public class static AttachedMembersUtil
    {
        public static bool IsTypeAttachable([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode element, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IType type) { }
        public class AttachedDefiningTypeFilter : JetBrains.ReSharper.Psi.Resolve.SimpleSymbolFilter
        {
            public AttachedDefiningTypeFilter(JetBrains.ReSharper.Psi.ITypeElement attachedOwnerType) { }
            public override JetBrains.ReSharper.Psi.Resolve.ResolveErrorType ErrorType { get; }
            public override bool Accepts(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution) { }
        }
        public class HasXStaticMembersFilter : JetBrains.ReSharper.Psi.Resolve.SimpleSymbolFilter
        {
            public HasXStaticMembersFilter([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode context) { }
            public override JetBrains.ReSharper.Psi.Resolve.ResolveErrorType ErrorType { get; }
            public override bool Accepts(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution) { }
        }
        public class OwnerTypesFilter : JetBrains.ReSharper.Psi.Resolve.SimpleSymbolFilter
        {
            public OwnerTypesFilter([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode element, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.IType receiverType = null) { }
            public override JetBrains.ReSharper.Psi.Resolve.ResolveErrorType ErrorType { get; }
            public override bool Accepts(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution) { }
        }
    }
    public class static AttachedPropertyUtil
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.ReSharper.Psi.IType GetAttachedPropertyType(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution) { }
        public static string GetRefenceName(string name) { }
        public static string GetterName(string referenceName) { }
        public static bool IsGetterName(string name) { }
        public static string SetterName(string referenceName) { }
    }
    public class static AttachedPropertyUtilNew
    {
        public const string GET_PREFIX = "Get";
        public const string SET_PREFIX = "Set";
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Collections.Generic.List<JetBrains.ReSharper.Psi.Resolve.ISymbolFilter> CreateGetterFilters([JetBrains.Annotations.CanBeNullAttribute()] string referenceName, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode element, bool dependencyPropertyFieldRequired, JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext context, bool requireCollectionReturn = False) { }
        public static System.Collections.Generic.List<JetBrains.ReSharper.Psi.Resolve.ISymbolFilter> CreateGetterFilters([JetBrains.Annotations.CanBeNullAttribute()] string referenceName, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Modules.IPsiModule module, bool dependencyPropertyFieldRequired, JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext context, bool requireCollectionReturn = False) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Collections.Generic.List<JetBrains.ReSharper.Psi.Resolve.ISymbolFilter> CreateSetterFilters([JetBrains.Annotations.CanBeNullAttribute()] string referenceName, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Modules.IPsiModule module, bool dependencyPropertyFieldRequired) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Collections.Generic.List<JetBrains.ReSharper.Psi.Resolve.ISymbolFilter> CreateSetterFilters([JetBrains.Annotations.CanBeNullAttribute()] string referenceName, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode element, bool dependencyPropertyFieldRequired) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.ReSharper.Psi.IType GetAttachedPropertyType(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution, JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext context) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.ReSharper.Psi.IType GetExpectedPropertyValueType([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xaml.Tree.IXamlObjectElement @object) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static string GetGetterName([JetBrains.Annotations.NotNullAttribute()] string referenceName) { }
        public static string GetReferenceName([JetBrains.Annotations.NotNullAttribute()] string methodName) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static string GetSetterName([JetBrains.Annotations.NotNullAttribute()] string referenceName) { }
        public static bool IsGetter([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public static bool IsGetterName([JetBrains.Annotations.NotNullAttribute()] string shortName) { }
        public static bool IsSetter([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public static bool IsSetterName([JetBrains.Annotations.NotNullAttribute()] string shortName) { }
        public static JetBrains.ReSharper.Psi.Xaml.DeclaredElements.IXamlAttachedProperty WrapSetterToProperty([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IMethod setMethod) { }
        public class HasNoPropertyFilter : JetBrains.ReSharper.Psi.Resolve.SimpleSymbolFilter
        {
            public static readonly JetBrains.ReSharper.Psi.Xaml.Impl.Util.AttachedPropertyUtilNew.HasNoPropertyFilter Instance;
            public override JetBrains.ReSharper.Psi.Resolve.ResolveErrorType ErrorType { get; }
            public override bool Accepts(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution) { }
        }
    }
    public class static AttributeUtil { }
    public class static BindingUtil
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.ReSharper.Psi.IType CalculateSourceType(JetBrains.ReSharper.Psi.Tree.ITreeNode binding, out JetBrains.ReSharper.Psi.Xaml.Tree.IXamlObjectElement objectElement) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Psi.IType CalculateSourceTypeLocal([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xaml.Tree.IBinding binding, JetBrains.ReSharper.Psi.Tree.ITreeNode originalBinding, out JetBrains.ReSharper.Psi.Xaml.Tree.IXamlObjectElement objectElement) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Psi.IType CalculateTypeByMarkup(JetBrains.ReSharper.Psi.Xaml.Tree.MarkupExtensions.IMarkup markup, out JetBrains.ReSharper.Psi.Xaml.Tree.IXamlObjectElement element, bool allowDataProviders = False) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Psi.IType CalculateTypeByPropertyValue(JetBrains.ReSharper.Psi.Tree.ITreeNode propertySetter, out JetBrains.ReSharper.Psi.Xaml.Tree.IXamlObjectElement objectElement, bool allowDataProviders = False) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Psi.Xaml.Tree.IBinding GetContainingBinding(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Psi.Xaml.Tree.IElementNameReference GetElementNameReference(JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.TreeElement element) { }
        public static JetBrains.ReSharper.Psi.Xaml.Tree.BindingMode GetMode([JetBrains.Annotations.CanBeNullAttribute()] string modeValue) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Psi.Tree.ITreeNode GetParentDataContextValue(JetBrains.ReSharper.Psi.Tree.ITreeNode binding) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Psi.IType GetTypeByResourceUsage([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xaml.Tree.IResourceUsage resourceUsage, out JetBrains.ReSharper.Psi.Xaml.Tree.IXamlObjectElement objectElement, bool allowDataProviders = False) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Psi.Xaml.Tree.IXamlObjectElement TryGetOtherElementDataContext([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xaml.Tree.IBinding binding) { }
    }
    public class static DependencyPropertyUtil
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Resolve.ISymbolFilter> CreateDependencyPropertyFilters([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public static JetBrains.ReSharper.Psi.Tree.ReferenceCollection CreateDependencyPropertyReferences([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode element, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken token, JetBrains.ReSharper.Psi.TreeTextRange rangeWithin) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static string GetDependencyFieldName([JetBrains.Annotations.NotNullAttribute()] string referenceName) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.ReSharper.Psi.IType GetDependencyPropertyType([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IDeclaredElement dependencyProperty, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Psi.ITypeMember GetFieldByProperty(JetBrains.ReSharper.Psi.IProperty property, JetBrains.ReSharper.Psi.Tree.ITreeNode context) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Psi.IProperty GetProperty([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, [JetBrains.Annotations.NotNullAttribute()] string name, bool readable) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static string GetReferenceName([JetBrains.Annotations.NotNullAttribute()] string propertyName) { }
        public static bool IsDependencyFieldName([JetBrains.Annotations.NotNullAttribute()] string name) { }
        public static bool IsDependencyProperty([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public static void SplitText(string text, out JetBrains.ReSharper.Psi.TreeTextRange namespaceRange, out JetBrains.ReSharper.Psi.TreeTextRange typeRange, out JetBrains.ReSharper.Psi.TreeTextRange propertyRange) { }
    }
    public class static DependencyPropertyUtilNew
    {
        public static System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Resolve.ISymbolFilter> CreateDependencyPropertyFieldFilters([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Modules.IPsiModule module, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext context) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Resolve.ISymbolFilter> CreateDependencyPropertyFieldFilters([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode element, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Modules.IPsiModule module) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static string GetFieldName([JetBrains.Annotations.NotNullAttribute()] string referenceName) { }
        public class HasDependencyPropertyField : JetBrains.ReSharper.Psi.Resolve.SimpleSymbolFilter
        {
            public HasDependencyPropertyField([JetBrains.Annotations.CanBeNullAttribute()] string referenceName, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
            public HasDependencyPropertyField([JetBrains.Annotations.CanBeNullAttribute()] string referenceName, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Modules.IPsiModule module) { }
            public HasDependencyPropertyField([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IDeclaredElement dependencyOrAttachedProperty, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
            public HasDependencyPropertyField([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IDeclaredElement dependencyOrAttachedProperty, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Modules.IPsiModule module) { }
            public override JetBrains.ReSharper.Psi.Resolve.ResolveErrorType ErrorType { get; }
            public override bool Accepts(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution) { }
        }
        public class HasNoAccessorsFilter : JetBrains.ReSharper.Psi.Resolve.SimpleSymbolFilter
        {
            public static readonly JetBrains.ReSharper.Psi.Xaml.Impl.Util.DependencyPropertyUtilNew.HasNoAccessorsFilter Instance;
            public override JetBrains.ReSharper.Psi.Resolve.ResolveErrorType ErrorType { get; }
            public override bool Accepts(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution) { }
        }
    }
    public class static DesignTimeMarkupUtil
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Psi.IType GetDesignDataContextType([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Xaml.Tree.MarkupExtensions.IMarkup markup) { }
        public static bool IsDesignDataMarkup([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Xaml.Tree.MarkupExtensions.IMarkup markup) { }
        public static bool IsDesignDataSourceAttribute([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Xaml.Tree.MarkupExtensions.IMarkupAttribute markupAttribute) { }
        public static bool IsDesignDesignSourceAttribute([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Xaml.Impl.Tree.IPropertySetter propertySetter) { }
        public static bool IsDesignInstanceCreateListAttribute([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Xaml.Tree.MarkupExtensions.IMarkupAttribute markupAttribute) { }
        public static bool IsDesignInstanceMarkup([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Xaml.Tree.MarkupExtensions.IMarkup markup) { }
        public static bool IsDesignInstanceTypeAttribute([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Xaml.Tree.MarkupExtensions.IMarkupAttribute markupAttribute) { }
        public static bool IsDesignInstanceTypeValue([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Xaml.Tree.MarkupExtensions.IIdentifierMarkupValue value) { }
        public static bool IsDesignSourceAttribute([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Xaml.Impl.Tree.IPropertySetter propertySetter) { }
        public static bool IsDesignTimeDataContextSetter([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Xaml.Impl.Tree.IPropertySetter propertySetter) { }
        public static bool IsDesignTimeMarkup([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Xaml.Tree.MarkupExtensions.IMarkup markup) { }
        public static bool IsDesignTimeNamespaceAlias([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Xaml.DeclaredElements.IXamlNamespaceAlias alias) { }
    }
    public class static ElementValueUtil
    {
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        public static JetBrains.ReSharper.Psi.Xaml.Tree.IXamlObjectElement GetElementValue(this JetBrains.ReSharper.Psi.Xaml.Tree.IXamlPropertyElement propertyElement) { }
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        public static JetBrains.ReSharper.Psi.Xaml.Tree.MarkupExtensions.IMarkup GetMarkupValue(this JetBrains.ReSharper.Psi.Xaml.Tree.IPropertyAttributeValue propertyValue) { }
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        public static JetBrains.ReSharper.Psi.Xaml.Tree.MarkupExtensions.IMarkup GetMarkupValue(this JetBrains.ReSharper.Psi.Xaml.Tree.MarkupExtensions.IMarkupAttributeValue markupValue) { }
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        public static JetBrains.ReSharper.Psi.Tree.ITreeNode GetNodeValue(this JetBrains.ReSharper.Psi.Xaml.Impl.Tree.IPropertySetter propertySetter) { }
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null;")]
        public static JetBrains.ReSharper.Psi.Tree.ITreeNode GetNodeValue(this JetBrains.ReSharper.Psi.Tree.ITreeNode propertyNode) { }
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        public static string GetStringValue(this JetBrains.ReSharper.Psi.Xaml.Tree.IPropertyAttribute propertyAttribute) { }
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        public static string GetStringValue(this JetBrains.ReSharper.Psi.Xaml.Tree.IXamlObjectElement objectElement) { }
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        public static string GetStringValue(this JetBrains.ReSharper.Psi.Xaml.Tree.IXamlPropertyElement propertyElement) { }
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        public static string GetStringValue(this JetBrains.ReSharper.Psi.Xaml.Impl.Tree.IPropertySetter propertySetter) { }
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        public static string GetStringValue(this JetBrains.ReSharper.Psi.Xaml.Tree.MarkupExtensions.IMarkupAttribute markupAttribute) { }
        [JetBrains.Annotations.ContractAnnotationAttribute("value: null => null")]
        public static string GetStringValue(this JetBrains.ReSharper.Psi.Xaml.Tree.MarkupExtensions.IMarkupAttributeValue value, bool anyToText = False) { }
        public static void SetInnerXmlValue([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Xaml.Tree.IXamlTag element, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xaml.Tree.IXamlTag valueTag) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static TMarkupValue SetMarkupAttributeValue<TMarkupValue>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Xaml.Tree.IPropertyAttribute attribute, [JetBrains.Annotations.NotNullAttribute()] TMarkupValue attributeValue)
            where TMarkupValue :  class, JetBrains.ReSharper.Psi.Xaml.Tree.MarkupExtensions.IMarkupAttributeValue { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static TMarkup SetMarkupValue<TMarkup>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Xaml.Tree.IPropertyAttribute attribute, [JetBrains.Annotations.NotNullAttribute()] TMarkup markup)
            where TMarkup :  class, JetBrains.ReSharper.Psi.Xaml.Tree.MarkupExtensions.IMarkup { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.ReSharper.Psi.Xaml.Tree.IPropertyAttributeValue SetStringValue([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Xaml.Tree.IPropertyAttribute attribute, [JetBrains.Annotations.NotNullAttribute()] string unquotedValue, bool disableEscaping = False) { }
        public static void SetStringValue([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Xaml.Tree.MarkupExtensions.IMarkupAttribute attribute, [JetBrains.Annotations.NotNullAttribute()] string unquotedValue, bool disableEscaping = False) { }
        public static void SetStringValue([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Xaml.Tree.IXamlTag element, [JetBrains.Annotations.NotNullAttribute()] string unquotedValue, bool disableEscaping = False, bool preserveSpaceIfNot = False) { }
    }
    public class static FactoryMethodUtil
    {
        public static JetBrains.ReSharper.Psi.Tree.ReferenceCollection CreateFactoryMethodReference([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode owner, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken token, JetBrains.ReSharper.Psi.TreeTextRange rangeWithin) { }
    }
    public interface IXamlCodeBehindTypeConversionRuleProvider
    {
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.ITypeConversionRule GetTypeConversionRule(JetBrains.ReSharper.Psi.Tree.ITreeNode xamlNode);
    }
    public class static MarkupCompatibilityUtil
    {
        public static bool IsChoiceRequiredAttribute([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Xaml.Tree.IXamlAttribute attribute) { }
        public static bool IsIgnorableAttribute([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Xaml.Tree.IXamlAttribute attribute) { }
        public static bool IsIgnorableReference([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IQualifiableReferenceWithGlobalSymbolTable reference) { }
        public static bool IsIgnoredAttribute([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Xaml.Tree.IXamlAttribute attribute) { }
    }
    public class static MarkupReferenceUtil
    {
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.ResolveResultWithInfo FixResolvePropertyReference(JetBrains.ReSharper.Psi.Resolve.ILateBoundReference reference, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.IDeclaredType contextType, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.ResolveResultWithInfo result) { }
    }
    public class static ModifierKeysUtil
    {
        public const string MODIFIERS_KEY = "ModifierKeys";
        public static System.Collections.Generic.IList<string> GetAllNames(string name) { }
        public static string GetOriginalName([JetBrains.Annotations.NotNullAttribute()] string name) { }
        public static bool IsModifierKeysType([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IType type, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext context) { }
        public static bool IsShortAlias([JetBrains.Annotations.NotNullAttribute()] string name) { }
    }
    public class static ModifiersUtil
    {
        public static JetBrains.ReSharper.Psi.AccessRights GetDefaultRights([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode context, [JetBrains.Annotations.NotNullAttribute()] string attributeName) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static string GetDefaultValue([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xaml.Tree.IXamlAttribute attribute) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static string GetInternalString([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode context) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static string GetPrivateString([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode context) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static string GetProtectedString([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode context) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static string GetPublicString([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode context) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Collections.Generic.IList<string> GetValidModifierStrings([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xaml.Tree.IModifiersAttribute attribute) { }
        public static bool IsDefaultValue([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xaml.Tree.IXamlAttribute attribute) { }
        public static JetBrains.ReSharper.Psi.AccessRights ResolveAccessRight([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xaml.Tree.IXamlObjectElement objectElement, [JetBrains.Annotations.NotNullAttribute()] string attributeName, System.Nullable<JetBrains.ReSharper.Psi.AccessRights> defaultRights = null) { }
        public static void SetAccessRight([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xaml.Tree.IXamlObjectElement objectElement, string attributeName, JetBrains.ReSharper.Psi.AccessRights rights) { }
        public static System.Nullable<JetBrains.ReSharper.Psi.AccessRights> TryResolveAccessRight([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xaml.Tree.IModifiersAttribute attribute) { }
    }
    public class static NameInClassOrResourceAttributeUtil
    {
        public static JetBrains.ReSharper.Psi.AccessRights GetAccessRights([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xaml.Tree.INameInClassOrResourceAttribute attribute) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.ReSharper.Psi.IType GetType([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xaml.Tree.INameInClassOrResourceAttribute attribute) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static string GetTypeName([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Xaml.Tree.INameInClassOrResourceAttribute attribute) { }
        public static void SetAccessRights([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Xaml.Tree.INameInClassOrResourceAttribute attribute, JetBrains.ReSharper.Psi.AccessRights accessRights) { }
    }
    public class static NamespaceAliasesUtil
    {
        public static System.Collections.Generic.Dictionary<JetBrains.ReSharper.Psi.Xaml.Tree.INamespaceAlias, bool> GetRedundantNamespaceAliases([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xaml.Tree.IXamlFile file) { }
    }
    public class static NamespaceAliasUtil
    {
        public const string ASSEMBLY_QUALIFIER = "assembly=";
        public const string CLR_NAMESPACE = "clr-namespace:";
        public const string DEFAULT_NAME = "<DEFAULT_NAMESPACE_ALIAS>";
        public const string TEMPORARY_NAME = "__TEMP_NAMESPACE_ALIAS";
        public const string USING_NAMESPACE = "using:";
        public static void BindNamespaceAliasReferences([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.INamespace @namespace, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Modules.IPsiModule module, bool preserverAliasName, [JetBrains.Annotations.NotNullAttribute()] params JetBrains.ReSharper.Psi.Resolve.IReference[] aliasReferences) { }
        public static System.Collections.Generic.IList<string> GetAvailableUriNamespaces([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xaml.Tree.INamespaceAlias namespaceAlias) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.ReSharper.Psi.Resolve.ISymbolFilter[] GetNamespaceAliasFilters(string aliasName) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.ReSharper.Psi.Resolve.ISymbolFilter[] GetNamespaceAliasFilters(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public static System.Collections.Generic.IList<string> GetNamespaceAliasValues(JetBrains.ReSharper.Psi.Xaml.Tree.IXamlTag tag, string name) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static string GetXamlModuleName([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Modules.IPsiModule module, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Modules.IPsiModule currentModule) { }
        public static bool IsReferenceBound(JetBrains.ReSharper.Psi.Xaml.Tree.IXamlNamespaceAliasReference aliasReference, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.INamespace nameSpace, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Modules.IPsiModule psiModule) { }
        public static JetBrains.ReSharper.Psi.TreeTextRange ParseModuleRange([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xaml.Tree.INamespaceAlias alias) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Collections.Generic.IList<JetBrains.ReSharper.Psi.TreeTextRange> ParseNamespaceRanges([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xaml.Tree.INamespaceAlias alias) { }
    }
    public class static PresentationOptionsUtil
    {
        public static bool IsFreezeAttribute(this JetBrains.ReSharper.Psi.Xaml.Tree.IXamlAttribute attribute) { }
    }
    public class static ReferenceUtil
    {
        public static JetBrains.ReSharper.Psi.Tree.ReferenceCollection CreateTypeReferences(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken token, JetBrains.ReSharper.Psi.Xaml.Impl.Tree.References.XamlTypeReferenceType typeReferenceType) { }
        public static JetBrains.ReSharper.Psi.Tree.ReferenceCollection CreateTypeReferences(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken token, JetBrains.ReSharper.Psi.TreeTextRange typeRange, JetBrains.ReSharper.Psi.Xaml.Impl.Tree.References.XamlTypeReferenceType typeReferenceType) { }
        public static JetBrains.ReSharper.Psi.Tree.ReferenceCollection CreateValueReferences([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xaml.Impl.Tree.IValueReferenceData valueReferenceData, JetBrains.ReSharper.Psi.TreeTextRange rangeWithin, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken token, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode owner) { }
        public static JetBrains.ReSharper.Psi.Tree.ReferenceCollection CreateValueReferences(JetBrains.ReSharper.Psi.Xaml.Impl.Tree.ITypeMemberReference reference, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode owner, JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken token, JetBrains.ReSharper.Psi.TreeTextRange rangeWithin) { }
        public static JetBrains.ProjectModel.BuildAction GetBuildAction([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        public static JetBrains.ReSharper.Psi.IType GetContainerType(JetBrains.ReSharper.Psi.Xaml.Tree.IXamlTag parentTag) { }
        public static JetBrains.ReSharper.Psi.INamespace GetCurrentProjectNamespace(JetBrains.ReSharper.Psi.Tree.ITreeNode element, string namespaceName) { }
        public static TReference GetFirstClassReference<TReference>([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode element)
            where TReference :  class, JetBrains.ReSharper.Psi.Resolve.IReference { }
        public static JetBrains.ReSharper.Psi.PsiLanguageType GetProjectLanguage([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public static JetBrains.ProjectModel.ProjectFileType GetProjectLanguageType([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.ReSharper.Psi.IType GetPropertyType([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xaml.Impl.Tree.ITypeMemberUsage memberUsage) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.ReSharper.Psi.IType GetPropertyType([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public static TReference GetReference<TReference>([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode element)
            where TReference :  class, JetBrains.ReSharper.Psi.Resolve.IReference { }
        public static JetBrains.ReSharper.Psi.Modules.IPsiModule GetReferencedModule([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode element, string moduleName) { }
        public static JetBrains.ReSharper.Psi.Modules.IPsiModule GetReferencedModule([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Modules.IPsiModule currentModule, string moduleName, JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext context) { }
        public static T GetReferenceRecursive<T>([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.TreeElement element, [JetBrains.Annotations.InstantHandleAttribute()] System.Predicate<T> predicate)
            where T :  class, JetBrains.ReSharper.Psi.Resolve.IReference { }
        public static TReference GetSecondClassReference<TReference>([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode element)
            where TReference :  class, JetBrains.ReSharper.Psi.Resolve.IReference { }
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        public static JetBrains.ReSharper.Psi.IType GetType([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Resolve.IReference typeReference) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Psi.IType GetType([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Resolve.IReference typeReference, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Resolve.IResolveResult resolveResult) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.ReSharper.Psi.IType GetType([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xaml.Tree.IXamlObjectElement objectElement) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.ReSharper.Psi.IType GetType([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xaml.Impl.Tree.ITypeUsage typeUsage) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.ReSharper.Psi.IType GetType([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xaml.Tree.MarkupExtensions.IMarkup markup) { }
        public static bool IsSubtypeOf(JetBrains.ReSharper.Psi.IType child, JetBrains.ReSharper.Psi.IDeclaredType parent) { }
        public static bool PsiModuleMatchesName(JetBrains.ReSharper.Psi.Modules.IPsiModule module, string moduleName) { }
        public static void ResetReferencesRecursively<TNode>(JetBrains.ReSharper.Psi.Tree.ITreeNode root)
            where TNode : JetBrains.ReSharper.Psi.Impl.Shared.Tree.CompositeElementWithReferences { }
    }
    public class static RelativeSourceUtil
    {
        public const int UNKNOWN_ANCESTOR_LEVEL = 2147483647;
        public static int GetAncestorLevel(string text) { }
        public static JetBrains.ReSharper.Psi.Xaml.Tree.RelativeSourceMode GetDefaultMode([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode context) { }
        public static JetBrains.ReSharper.Psi.Xaml.Tree.RelativeSourceMode GetMode([JetBrains.Annotations.NotNullAttribute()] string text) { }
        public static JetBrains.ReSharper.Psi.Xaml.Tree.RelativeSourceMode GetMode([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xaml.Tree.IXStatic staticMarkup) { }
    }
    [System.Diagnostics.DebuggerDisplayAttribute("ResourcesSymbolTable ({myResources.Count,nq} resources)")]
    public class ResourcesSymbolTable : JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.SymbolTableBase
    {
        public static JetBrains.ReSharper.Psi.Resolve.ISymbolFilter ExpandFilter { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.ReSharper.Psi.Resolve.ISymbolTable Create([JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Xaml.DeclaredElements.IXamlResource> resources) { }
        public override void ForAllSymbolInfos(System.Action<JetBrains.ReSharper.Psi.Resolve.ISymbolInfo> processor) { }
        public override JetBrains.ReSharper.Psi.Dependencies.ISymbolTableDependencySet GetDependencySet() { }
        public override System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Resolve.ISymbolInfo> GetSymbolInfos(string name) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.ReSharper.Psi.Resolve.ISymbolTable MergeInherited([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Resolve.ISymbolTable tableToHide, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Resolve.ISymbolTable newTable) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.ReSharper.Psi.Resolve.ISymbolTable MergeSameLevel([JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Resolve.ISymbolTable> tables) { }
        public override System.Collections.Generic.IEnumerable<string> Names() { }
    }
    public class static StoryboardUtil
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetSymbolTableByStoryboard([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public static bool IsStoryboardTargetName([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Xaml.Tree.IXamlAttribute attribute) { }
        public static bool IsStoryboardTargetName([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Xaml.Tree.IXamlPropertyElement propertyElement) { }
        public static bool IsStoryboardTargetProperty([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Xaml.Tree.IXamlAttribute attribute) { }
        public static bool IsStoryboardTargetProperty([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Xaml.Tree.IXamlPropertyElement propertyElement) { }
    }
    public class static StyleUtil
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Xaml.Impl.Util.StyleUtil.SetterInfo> GetStyleSetters([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Xaml.Tree.IResourceReference styleReference, bool includeBaseStyle = False) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Xaml.Impl.Util.StyleUtil.SetterInfo> GetStyleSetters([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Xaml.Tree.IXamlObjectElement styleElement, bool includeBaseStyle = False) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Collections.Generic.Dictionary<JetBrains.ReSharper.Psi.DeclaredElementInstance<JetBrains.ReSharper.Psi.ITypeMember>, JetBrains.ReSharper.Psi.Xaml.Impl.Util.StyleUtil.SetterInfo> RemoveOverridenSetters([JetBrains.Annotations.NotNullAttribute()] this System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Xaml.Impl.Util.StyleUtil.SetterInfo> styleSetters) { }
        public struct SetterInfo
        {
            [JetBrains.Annotations.NotNullAttribute()]
            public readonly JetBrains.ReSharper.Psi.DeclaredElementInstance<JetBrains.ReSharper.Psi.ITypeMember> Member;
            [JetBrains.Annotations.NotNullAttribute()]
            public readonly JetBrains.ReSharper.Psi.Xaml.Impl.Tree.IPropertySetter PropertySetter;
            [JetBrains.Annotations.CanBeNullAttribute()]
            public readonly JetBrains.ReSharper.Psi.Xaml.Impl.Tree.IPropertySetter ValueSetter;
            public bool IsEventSetter { get; }
            public static System.Nullable<JetBrains.ReSharper.Psi.Xaml.Impl.Util.StyleUtil.SetterInfo> FromSetter<T>([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xaml.Impl.Tree.IPropertySetter propertyProperty, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Xaml.Impl.Tree.IPropertySetter valueProperty)
                where T :  class, JetBrains.ReSharper.Psi.Resolve.IReference { }
        }
    }
    public class static TypeArgumentUtil
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.ReSharper.Psi.Resolve.ISubstitution GetSubstitution([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.ITypeElement typeElement, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode context) { }
        public static System.Collections.Generic.IList<JetBrains.ReSharper.Psi.IType> GetTypeArguments(JetBrains.ReSharper.Psi.Xaml.Tree.IXamlTypeReference typeReference) { }
        public static System.Collections.Generic.IList<JetBrains.ReSharper.Psi.IType> GetTypeArguments([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
    }
    public class TypeMemberInfo
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly JetBrains.ReSharper.Psi.IDeclaredType ContainingType;
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly JetBrains.ReSharper.Psi.Resolve.ISubstitution Substitution;
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly JetBrains.ReSharper.Psi.ITypeMember TypeMember;
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Psi.Xaml.Impl.Util.TypeMemberInfo Create([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xaml.Impl.Tree.ITypeMemberReference memberReference) { }
        public bool Is(string typeMemberName, JetBrains.ReSharper.Psi.IDeclaredType containingType) { }
    }
    public class static TypeReferenceUtil
    {
        public static System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.Xaml.Tree.IXamlTypeReference> CollectTypeReferences(JetBrains.ReSharper.Psi.Xaml.Tree.IXamlTypeReference typeReference) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Psi.Tree.IDeclaration GetDeclarationByResourceUsage(JetBrains.ReSharper.Psi.Xml.Impl.Tree.XmlCompositeElement element) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Psi.Resolve.IReference GetTypeReference([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xaml.Tree.IXamlObjectElement objectElement, [JetBrains.Annotations.NotNullAttribute()] string propertyName, bool processStyleReference, params string[] typeNames) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Psi.Resolve.IReference GetTypeReferenceByResourceUsage(JetBrains.ReSharper.Psi.Xml.Impl.Tree.XmlCompositeElement compositeElement) { }
    }
    public class static XamlDeclaredElementUtil
    {
        public static bool CanDeclareElement(JetBrains.ReSharper.Psi.Xaml.Tree.IXamlAttribute nameAttribute) { }
        public static bool CanDeclareTypeMember([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITypeMemberDeclaration declaration, string declaredName) { }
    }
    public class static XamlEqualityUtil
    {
        public static bool AreValuesEqual([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Xaml.Impl.Tree.IPropertySetter lhs, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Xaml.Impl.Tree.IPropertySetter rhs, bool compareWithStyle = False) { }
        public static bool AreValuesEqual([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Xaml.Tree.MarkupExtensions.IMarkupAttribute lhs, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Xaml.Tree.MarkupExtensions.IMarkupAttribute rhs) { }
        public static bool AreValuesEqual([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Xaml.Impl.Tree.IPropertySetter lhs, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Xaml.Tree.MarkupExtensions.IMarkupAttribute rhs, bool compareWithStyle = False) { }
        public static bool AreValuesEqual([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Xaml.Tree.MarkupExtensions.IMarkupAttribute lhs, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Xaml.Impl.Tree.IPropertySetter rhs, bool compareWithStyle = False) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Psi.Resolve.IReference GetPropertyReferenceByStyleSetter([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Xaml.Impl.Tree.IPropertySetter setter) { }
    }
    public class static XamlFieldUtil
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null => null")]
        public static JetBrains.ReSharper.Psi.Xaml.Tree.IXamlObjectElement GetControlOrDataTemplate(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Xaml.Tree.ITemplateFieldDeclaration> GetTemplateFields([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode context) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Xaml.Tree.IXamlDeclaration> GetXamlFields([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode context) { }
    }
    public class static XamlObjectElementExtensions
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.ReSharper.Psi.Xaml.Tree.INamespaceAlias AddNamespaceAlias([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Xaml.Tree.IXamlObjectElement objectElement, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xaml.Tree.INamespaceAlias alias) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Psi.Xaml.Impl.Tree.IPropertySetter GetKnownSetter([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Xaml.Tree.IXamlObjectElement objectElement, [JetBrains.Annotations.NotNullAttribute()] string propertyName, [JetBrains.Annotations.InstantHandleAttribute()] [JetBrains.Annotations.NotNullAttribute()] System.Func<JetBrains.ReSharper.Psi.Xaml.Impl.Resolve.IXamlTypeCache, JetBrains.ReSharper.Psi.IDeclaredType> typeSelector) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Psi.Xaml.Impl.Tree.IPropertySetter GetKnownSetter([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Xaml.Tree.IXamlObjectElement objectElement, [JetBrains.Annotations.NotNullAttribute()] string propertyName, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IDeclaredType ownerType) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Collections.Generic.IEnumerable<object> GetMeaningfulContents([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Xaml.Tree.IXamlTag xamlTag) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Psi.Xaml.Impl.Tree.IPropertySetter GetResourcesSetter([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Xaml.Tree.IXamlObjectElement objectElement) { }
        public static bool IsKnownSetter([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Xaml.Impl.Tree.IPropertySetter propertySetter, [JetBrains.Annotations.NotNullAttribute()] string propertyName, [JetBrains.Annotations.InstantHandleAttribute()] [JetBrains.Annotations.NotNullAttribute()] System.Func<JetBrains.ReSharper.Psi.Xaml.Impl.Resolve.IXamlTypeCache, JetBrains.ReSharper.Psi.IDeclaredType> typeSelector) { }
        public static bool IsKnownSetter([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Xaml.Impl.Tree.IPropertySetter propertySetter, [JetBrains.Annotations.NotNullAttribute()] string propertyName, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IDeclaredType ownerType) { }
    }
    public class static XamlPathReferenceUtil
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.ResolveResultWithInfo CheckResolveResult([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xaml.Tree.IXamlPathReference pathReference, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.ResolveResultWithInfo resolveResult) { }
        public static JetBrains.ReSharper.Psi.Tree.ReferenceCollection CreatePathReferences([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode element, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken token, JetBrains.ReSharper.Psi.TreeTextRange rangeWithin, bool useRootFolder, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xaml.Impl.Util.XamlPathReferenceUtil.CreateFileReferenceDelegate createLast) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.Util.FileSystemPath GetBasePath([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xaml.Tree.IXamlPathReference pathReference) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetReferenceSymbolTable([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xaml.Tree.IXamlPathReference pathReference, bool useReferenceName) { }
        public delegate JetBrains.ReSharper.Psi.Resolve.IReference CreateFileReferenceDelegate(JetBrains.ReSharper.Psi.Resolve.IQualifier qualifier, JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken token, JetBrains.ReSharper.Psi.TreeTextRange range, bool useRootFolder);
    }
    [System.FlagsAttribute()]
    public enum XamlPlatform
    {
        NO_PLATFORM = 0,
        SILVERLIGHT_1 = 1,
        SILVERLIGHT_2 = 2,
        SILVERLIGHT = 3,
        WINDOWS_PHONE = 4,
        WINRT = 8,
        WPF = 16,
        ALL = 31,
    }
    public class static XamlPlatformUtil
    {
        public static JetBrains.ReSharper.Psi.Xaml.Impl.Util.XamlPlatform GetPlatform([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Modules.IPsiModule module) { }
        public static bool IsSilverlightXaml([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Tree.ITreeNode node) { }
        public static bool IsSilverlightXaml([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Modules.IPsiModule module) { }
        public static bool IsWinRTXaml([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Tree.ITreeNode node) { }
        public static bool IsWinRTXaml([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Modules.IPsiModule module) { }
        public static bool IsWPFXaml([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Tree.ITreeNode node) { }
        public static bool IsWPFXaml([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Modules.IPsiModule module) { }
    }
    [JetBrains.ReSharper.Psi.PsiComponentAttribute()]
    public class XamlResourcesCache : JetBrains.ReSharper.Psi.Caches.InvalidatingPsiCache
    {
        public XamlResourcesCache([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Modules.IPsiModules psiModules, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xaml.Caches.IXamlAssemblyResourcesCache resourcesCache, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.ChangeManager changeManager) { }
        public void Clear() { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetApplicationResources([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.ReSharper.Psi.Xaml.Impl.Util.XamlResourcesCache GetCache(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetResourcesDefinedInElement([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xaml.Tree.IXamlObjectElement element) { }
        protected override void InvalidateOnPhysicalChange() { }
    }
    public class static XamlResourceUtil
    {
        public static bool CheckResourceKeyAvailable([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xaml.Tree.IXamlObjectElement target, [JetBrains.Annotations.CanBeNullAttribute()] string resourceName = null, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.IType resourceKeyType = null) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetBaseResources([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xaml.Tree.IXamlTypeDeclaration topElement) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Psi.Xaml.Tree.IXamlObjectElement GetResourceContainer([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public static JetBrains.ReSharper.Psi.Xaml.Tree.IXamlTag GetResourcesElement(JetBrains.ReSharper.Psi.Xaml.Tree.IXamlObjectElement objectElement) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetResourcesSymbolTable([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode node, bool skipFirstElement) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Psi.Xaml.Tree.INameInClassOrResourceAttribute GetXNameAttributeDeclaringResource([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xaml.Tree.IResourceDeclaration declaration) { }
        public static bool IsFromThemeDictionary([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xaml.Tree.IXamlTag resourcesElement, out JetBrains.ReSharper.Psi.Xaml.Tree.IXamlTag resourceDictionary) { }
        public static bool IsGlobalResource([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xaml.Tree.IResourceDeclaration resourcedDeclaration) { }
        public static bool IsResourceDictionary([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xaml.Tree.IXamlObjectElement objectElement) { }
        public static bool IsResourceDictionary([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Resolve.IReference typeReference) { }
        public static bool IsResourceDictionaryGroupingElement([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xaml.Tree.IResourceDeclaration resourceDeclaration) { }
        public static bool IsResourceDictionaryResource(JetBrains.ReSharper.Psi.Xaml.Tree.IXamlObjectElement objectElement) { }
    }
    public class static XArrayUtil
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.ReSharper.Psi.IType GetArrayType([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xaml.Tree.IXamlObjectElement objectElement) { }
        [JetBrains.Annotations.ContractAnnotationAttribute("null => false")]
        public static bool IsXArray(JetBrains.ReSharper.Psi.Xaml.Tree.IXamlObjectElement objectElement) { }
    }
}
namespace JetBrains.ReSharper.Psi.Xaml.Naming
{
    
    [JetBrains.Application.Configuration.Upgrade.GlobalSettingsUpgraderAttribute()]
    [JetBrains.ProjectModel.Settings.Upgrade.SolutionSettingsUpgraderAttribute()]
    public class XamlCustomRulesNamingSettingsUpgrade : JetBrains.ReSharper.Psi.Naming.Settings.Upgrade.CustomRulesNamingSettingsUpgrade<JetBrains.ReSharper.Psi.Xaml.Naming.XamlNamingSettingsKey>
    {
        public XamlCustomRulesNamingSettingsUpgrade(JetBrains.Application.Parts.IPartsCatalogueSet partsSet, JetBrains.ProjectModel.ISolution solution = null) { }
        protected override JetBrains.ReSharper.Psi.Naming.Settings.CustomRulesNamingSettingsBase GetSpecificSettings(JetBrains.ReSharper.Psi.CodeStyle.SettingsUpgrade.CodeStyleSettingsObsolete codeStyleSettings) { }
    }
    public class XamlNameCompletionUtil : JetBrains.ReSharper.Psi.Naming.Extentions.NameCompletionUtil
    {
        public static System.Collections.Generic.IEnumerable<string> SuggestNamesForField([JetBrains.Annotations.NotNullAttribute()] string tagName, [JetBrains.Annotations.NotNullAttribute()] string prefix, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.PsiLanguageType language, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.ISolution solution, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
    }
    [JetBrains.ReSharper.Psi.Naming.Elements.NamedElementsBagAttribute(typeof(JetBrains.ReSharper.Psi.Xaml.XamlLanguage))]
    public class XamlNamedElements : JetBrains.ReSharper.Psi.Naming.Elements.ElementKindOfElementType
    {
        public static readonly JetBrains.ReSharper.Psi.Naming.Elements.IElementKind NAMESPACE_ALIAS;
        public static readonly JetBrains.ReSharper.Psi.Naming.Elements.IElementKind XAML_FIELD;
        public static readonly JetBrains.ReSharper.Psi.Naming.Elements.IElementKind XAML_RESOURCE;
        protected XamlNamedElements([JetBrains.Annotations.NotNullAttribute()] string name, string presentableName, System.Func<JetBrains.ReSharper.Psi.IDeclaredElement, bool> isApplicable, JetBrains.ReSharper.Psi.Naming.Settings.NamingRule namingRule) { }
        public override JetBrains.ReSharper.Psi.PsiLanguageType Language { get; }
        public override JetBrains.ReSharper.Psi.Naming.Settings.NamingRule GetDefaultRule() { }
    }
    [JetBrains.ReSharper.Psi.Naming.Interfaces.NamingConsistencyCheckerAttribute(typeof(JetBrains.ReSharper.Psi.Xaml.XamlLanguage))]
    public class XamlNamingConsistencyChecker : JetBrains.ReSharper.Psi.Naming.Interfaces.INamingConsistencyChecker
    {
        public void Check(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration, JetBrains.ReSharper.Psi.Naming.Interfaces.INamingPolicyProvider namingPolicyProvider, out bool isFinalResult, out JetBrains.ReSharper.Psi.Naming.Impl.NamingConsistencyCheckResult result) { }
        public static JetBrains.ReSharper.Psi.Naming.Impl.NamingConsistencyCheckResult GetCheckResult(JetBrains.ReSharper.Psi.Naming.NamingManager namingManager, JetBrains.ReSharper.Psi.Naming.Settings.NamingPolicy policy, string shortName, string ruleName, JetBrains.ReSharper.Psi.Naming.Interfaces.INamingPolicyProvider policyProvider) { }
        public bool IsApplicable(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
    }
    [JetBrains.Application.Settings.SettingsKeyAttribute(typeof(JetBrains.ReSharper.Psi.Naming.Settings.NamingSettings), "XAML naming settings")]
    public class XamlNamingSettingsKey : JetBrains.ReSharper.Psi.Naming.Settings.CustomRulesNamingSettingsKeyBase { }
    [System.ObsoleteAttribute("Deprecated, use XamlNamingSettingsKey")]
    public class XamlNamingStyleSettings : JetBrains.ReSharper.Psi.Naming.Settings.CustomRulesNamingSettingsBase
    {
        public override object Clone() { }
    }
    public class XamlPolicyProvider : JetBrains.ReSharper.Psi.Naming.Impl.CustomRulesBasedPolicyProvider<JetBrains.ReSharper.Psi.Xaml.Naming.XamlNamingSettingsKey>
    {
        public XamlPolicyProvider(JetBrains.ReSharper.Psi.PsiLanguageType language, JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, JetBrains.Application.Settings.IContextBoundSettingsStore settingsStore) { }
        protected override JetBrains.ReSharper.Psi.Naming.Settings.NamingPolicy UndefinedPolicy { get; }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.Xaml.XamlLanguage))]
    public class XamlPolicyProviderFactory : JetBrains.ReSharper.Psi.Naming.Interfaces.INamingPolicyProviderFactory
    {
        public XamlPolicyProviderFactory(JetBrains.ReSharper.Psi.PsiLanguageType language) { }
        public JetBrains.ReSharper.Psi.Naming.Interfaces.INamingPolicyProvider CreatePolicyProvider(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, JetBrains.Application.Settings.IContextBoundSettingsStore settingsStore) { }
    }
}
namespace JetBrains.ReSharper.Psi.Xaml.Parsing
{
    
    public struct MarkupExtensionLexerState
    {
        public JetBrains.ReSharper.Psi.Parsing.TokenNodeType currTokenType;
        public int yy_buffer_end;
        public int yy_buffer_index;
        public int yy_buffer_start;
        public int yy_lexical_state;
    }
    public class MarkupExtensionsAttributeValueLexerGenerated : JetBrains.ReSharper.Psi.Parsing.IIncrementalLexer, JetBrains.ReSharper.Psi.Parsing.ILexer, JetBrains.ReSharper.Psi.Parsing.ILexer<JetBrains.ReSharper.Psi.Xaml.Parsing.MarkupExtensionLexerState>, JetBrains.ReSharper.Psi.Parsing.ILexerEx
    {
        protected JetBrains.ReSharper.Psi.Parsing.TokenNodeType currTokenType;
        protected const int YYINITIAL = 0;
        public MarkupExtensionsAttributeValueLexerGenerated(JetBrains.Text.IBuffer buffer, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xaml.Parsing.XamlTokenTypes xamlTokenTypes) { }
        public JetBrains.Text.IBuffer Buffer { get; }
        public JetBrains.ReSharper.Psi.Xaml.Parsing.MarkupExtensionLexerState CurrentPosition { get; set; }
        public int EOFPos { get; }
        public int LexemIndent { get; }
        public uint LexerStateEx { get; }
        public int TokenEnd { get; }
        public int TokenStart { get; }
        public JetBrains.ReSharper.Psi.Parsing.TokenNodeType TokenType { get; }
        public JetBrains.ReSharper.Psi.Xaml.Parsing.XamlTokenTypes XamlTokenType { get; }
        public JetBrains.ReSharper.Psi.Parsing.TokenNodeType _locateToken() { }
        public void Advance() { }
        protected void locateToken() { }
        protected JetBrains.ReSharper.Psi.Parsing.TokenNodeType makeToken(JetBrains.ReSharper.Psi.Parsing.TokenNodeType type) { }
        public void Start() { }
        public void Start(int startOffset, int endOffset, uint state) { }
    }
    public class MarkupExtensionsLexerGenerated : JetBrains.ReSharper.Psi.Parsing.IIncrementalLexer, JetBrains.ReSharper.Psi.Parsing.ILexer, JetBrains.ReSharper.Psi.Parsing.ILexer<JetBrains.ReSharper.Psi.Xaml.Parsing.MarkupExtensionLexerState>, JetBrains.ReSharper.Psi.Parsing.ILexerEx
    {
        protected JetBrains.ReSharper.Psi.Parsing.TokenNodeType currTokenType;
        protected const int WORK = 1;
        protected const int YYINITIAL = 0;
        public MarkupExtensionsLexerGenerated(JetBrains.Text.IBuffer buffer, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xaml.Parsing.XamlTokenTypes xamlTokenTypes) { }
        public JetBrains.Text.IBuffer Buffer { get; }
        public JetBrains.ReSharper.Psi.Xaml.Parsing.MarkupExtensionLexerState CurrentPosition { get; set; }
        public int EOFPos { get; }
        public int LexemIndent { get; }
        public uint LexerStateEx { get; }
        public int TokenEnd { get; }
        public int TokenStart { get; }
        public JetBrains.ReSharper.Psi.Parsing.TokenNodeType TokenType { get; }
        public JetBrains.ReSharper.Psi.Xaml.Parsing.XamlTokenTypes XamlTokenType { get; }
        public JetBrains.ReSharper.Psi.Parsing.TokenNodeType _locateToken() { }
        public void Advance() { }
        protected void locateToken() { }
        protected JetBrains.ReSharper.Psi.Parsing.TokenNodeType makeToken(JetBrains.ReSharper.Psi.Parsing.TokenNodeType type) { }
        public void Start() { }
        public void Start(int startOffset, int endOffset, uint state) { }
    }
    public class MarkupExtensionsTreeBuilder
    {
        protected JetBrains.ReSharper.Psi.Xaml.Parsing.MarkupExtensionsTreeBuilder.TokenEntry CurrentEntry { get; }
        public static JetBrains.ReSharper.Psi.Xaml.Tree.IPropertyAttributeValue ParsePathAttributeValue(JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttributeValue value) { }
        public static JetBrains.ReSharper.Psi.Xaml.Tree.IPropertyAttributeValue ParsePropertyAttribute(JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttributeValue value) { }
        public static JetBrains.ReSharper.Psi.Xaml.Tree.IPropertyAttributeValue ParseStaticAttributeValue(JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttributeValue value) { }
        public static JetBrains.ReSharper.Psi.Xaml.Tree.IPropertyAttributeValue ParseTypeNameAttributeValue(JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttributeValue value) { }
        public static JetBrains.ReSharper.Psi.Xaml.Tree.IPropertyAttributeValue ParseTypeNameOrMarkupAttributeValue(JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttributeValue value) { }
        protected class TokenEntry
        {
            public readonly JetBrains.ReSharper.Psi.TreeOffset TokenEnd;
            public readonly JetBrains.ReSharper.Psi.TreeOffset TokenStart;
            public readonly JetBrains.ReSharper.Psi.Parsing.XmlTokenNodeType TokenType;
            public TokenEntry(JetBrains.ReSharper.Psi.Parsing.ILexer lexer) { }
        }
    }
    public class XamlTokenNodeType : JetBrains.ReSharper.Psi.Parsing.XmlTokenNodeType
    {
        public XamlTokenNodeType(string s, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Parsing.XmlTokenTypes xmlTokenTypes, int index) { }
        public override bool IsComment { get; }
        public override bool IsConstantLiteral { get; }
        public override bool IsIdentifier { get; }
        public override bool IsKeyword { get; }
        public override bool IsStringLiteral { get; }
        public override bool IsWhitespace { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ReSharper.Psi.Xaml.Parsing.XamlTokenTypes XamlTokenTypes { get; }
        public override JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.LeafElementBase Create(JetBrains.Text.IBuffer buffer, JetBrains.ReSharper.Psi.TreeOffset startOffset, JetBrains.ReSharper.Psi.TreeOffset endOffset) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.Xaml.XamlLanguage))]
    public class XamlTokenTypes : JetBrains.ReSharper.Psi.Xml.XmlTokenTypesImpl
    {
        public readonly JetBrains.ReSharper.Psi.Xaml.Parsing.XamlTokenNodeType MARKUP_COLON;
        public readonly JetBrains.ReSharper.Psi.Xaml.Parsing.XamlTokenNodeType MARKUP_COMMA;
        public readonly JetBrains.ReSharper.Psi.Xaml.Parsing.XamlTokenNodeType MARKUP_DOT;
        public readonly JetBrains.ReSharper.Psi.Xaml.Parsing.XamlTokenNodeType MARKUP_EQ;
        public readonly JetBrains.ReSharper.Psi.Xaml.Parsing.XamlTokenNodeType MARKUP_ERROR;
        public readonly JetBrains.ReSharper.Psi.Xaml.Parsing.XamlTokenNodeType MARKUP_ESC_AMP;
        public readonly JetBrains.ReSharper.Psi.Xaml.Parsing.XamlTokenNodeType MARKUP_ESC_BACKSLASH;
        public readonly JetBrains.ReSharper.Psi.Xaml.Parsing.XamlTokenNodeType MARKUP_ESC_COMMA;
        public readonly JetBrains.ReSharper.Psi.Xaml.Parsing.XamlTokenNodeType MARKUP_ESC_DOUBLEQUOTE;
        public readonly JetBrains.ReSharper.Psi.Xaml.Parsing.XamlTokenNodeType MARKUP_ESC_EQ;
        public readonly JetBrains.ReSharper.Psi.Xaml.Parsing.XamlTokenNodeType MARKUP_ESC_GT;
        public readonly JetBrains.ReSharper.Psi.Xaml.Parsing.XamlTokenNodeType MARKUP_ESC_GT_EQ;
        public readonly JetBrains.ReSharper.Psi.Xaml.Parsing.XamlTokenNodeType MARKUP_ESC_LBRACE;
        public readonly JetBrains.ReSharper.Psi.Xaml.Parsing.XamlTokenNodeType MARKUP_ESC_LT;
        public readonly JetBrains.ReSharper.Psi.Xaml.Parsing.XamlTokenNodeType MARKUP_ESC_LT_EQ;
        public readonly JetBrains.ReSharper.Psi.Xaml.Parsing.XamlTokenNodeType MARKUP_ESC_RBRACE;
        public readonly JetBrains.ReSharper.Psi.Xaml.Parsing.XamlTokenNodeType MARKUP_ESC_SINGLEQUOTE;
        public readonly JetBrains.ReSharper.Psi.Xaml.Parsing.XamlTokenNodeType MARKUP_ESCAPE_START;
        public readonly JetBrains.ReSharper.Psi.Xaml.Parsing.XamlTokenNodeType MARKUP_IDENTIFIER;
        public readonly JetBrains.ReSharper.Psi.Xaml.Parsing.XamlTokenNodeType MARKUP_LBRACE;
        public readonly JetBrains.ReSharper.Psi.Xaml.Parsing.XamlTokenNodeType MARKUP_LBRAKET;
        public readonly JetBrains.ReSharper.Psi.Xaml.Parsing.XamlTokenNodeType MARKUP_LPARENTH;
        public readonly JetBrains.ReSharper.Psi.Xaml.Parsing.XamlTokenNodeType MARKUP_NUMBER;
        public readonly JetBrains.ReSharper.Psi.Xaml.Parsing.XamlTokenNodeType MARKUP_PERCENT;
        public readonly JetBrains.ReSharper.Psi.Xaml.Parsing.XamlTokenNodeType MARKUP_QUOTE;
        public readonly JetBrains.ReSharper.Psi.Xaml.Parsing.XamlTokenNodeType MARKUP_RBRACE;
        public readonly JetBrains.ReSharper.Psi.Xaml.Parsing.XamlTokenNodeType MARKUP_RBRAKET;
        public readonly JetBrains.ReSharper.Psi.Xaml.Parsing.XamlTokenNodeType MARKUP_RPARENTH;
        public readonly JetBrains.ReSharper.Psi.Xaml.Parsing.XamlTokenNodeType MARKUP_SLASH;
        public readonly JetBrains.ReSharper.Psi.Xaml.Parsing.XamlTokenNodeType MARKUP_SPACE;
        public readonly JetBrains.ReSharper.Psi.Xaml.Parsing.XamlTokenNodeType MARKUP_TEXT;
        public readonly JetBrains.ReSharper.Psi.Xaml.Parsing.XamlTokenNodeType MARKUP_XNUMBER;
        public readonly JetBrains.ReSharper.Psi.Xaml.Parsing.XamlTokenNodeType XPATH_ADD;
        public readonly JetBrains.ReSharper.Psi.Xaml.Parsing.XamlTokenNodeType XPATH_ASTERISK;
        public readonly JetBrains.ReSharper.Psi.Xaml.Parsing.XamlTokenNodeType XPATH_AT;
        public readonly JetBrains.ReSharper.Psi.Xaml.Parsing.XamlTokenNodeType XPATH_NOT_EQ;
        public readonly JetBrains.ReSharper.Psi.Xaml.Parsing.XamlTokenNodeType XPATH_SET_OP;
        public readonly JetBrains.ReSharper.Psi.Xaml.Parsing.XamlTokenNodeType XPATH_SUB;
        public XamlTokenTypes(JetBrains.ReSharper.Psi.PsiLanguageType languageType, JetBrains.ReSharper.Psi.Parsing.IXmlTokenBuilder xmlTokenBuilder) { }
        public static JetBrains.ReSharper.Psi.Xaml.Parsing.XamlTokenTypes GetInstance(JetBrains.ReSharper.Psi.PsiLanguageType languageType) { }
        public static JetBrains.ReSharper.Psi.Xaml.Parsing.XamlTokenTypes GetInstance<TLanguage>()
            where TLanguage : JetBrains.ReSharper.Psi.PsiLanguageType { }
    }
    public class XamlTreeBuilder : JetBrains.ReSharper.Psi.Xml.Parsing.XmlTreeBuilder
    {
        public XamlTreeBuilder(JetBrains.ReSharper.Psi.Xml.Parsing.IXmlElementFactory elementFactory, JetBrains.ReSharper.Psi.Xml.Parsing.IXmlElementFactoryContext factoryContext, JetBrains.ReSharper.Psi.Util.ITokenIntern intern) { }
        protected JetBrains.ReSharper.Psi.Xaml.Parsing.XamlTokenTypes XamlTokenTypes { get; }
        protected override void AppendNewChild(JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttribute parent, JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttributeValue child) { }
        protected override void OnTagContainerCreated(JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagContainer container) { }
    }
}
namespace JetBrains.ReSharper.Psi.Xaml.Resources
{
    
    public sealed class PsiXamlThemedIcons
    {
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Psi.Xaml;component/resources/PsiXamlThemedIcons/ThemedIcons.P" +
            "siXaml.Generated.Xaml", 3, "XamlAttachedEvent")]
        public sealed class XamlAttachedEvent : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Psi.Xaml;component/resources/PsiXamlThemedIcons/ThemedIcons.P" +
            "siXaml.Generated.Xaml", 0, "XamlAttachedProperty")]
        public sealed class XamlAttachedProperty : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Psi.Xaml;component/resources/PsiXamlThemedIcons/ThemedIcons.P" +
            "siXaml.Generated.Xaml", 4, "XamlFile")]
        public sealed class XamlFile : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Psi.Xaml;component/resources/PsiXamlThemedIcons/ThemedIcons.P" +
            "siXaml.Generated.Xaml", 6, "XamlMarkupExtension")]
        public sealed class XamlMarkupExtension : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Psi.Xaml;component/resources/PsiXamlThemedIcons/ThemedIcons.P" +
            "siXaml.Generated.Xaml", 8, "XamlNamespaceAlias")]
        public sealed class XamlNamespaceAlias : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Psi.Xaml;component/resources/PsiXamlThemedIcons/ThemedIcons.P" +
            "siXaml.Generated.Xaml", 2, "XamlPredefinedAttributeElement")]
        public sealed class XamlPredefinedAttributeElement : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Psi.Xaml;component/resources/PsiXamlThemedIcons/ThemedIcons.P" +
            "siXaml.Generated.Xaml", 5, "XamlPredefinedObjectElement")]
        public sealed class XamlPredefinedObjectElement : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Psi.Xaml;component/resources/PsiXamlThemedIcons/ThemedIcons.P" +
            "siXaml.Generated.Xaml", 7, "XamlResource")]
        public sealed class XamlResource : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Psi.Xaml;component/resources/PsiXamlThemedIcons/ThemedIcons.P" +
            "siXaml.Generated.Xaml", 1, "XamlTemplateField")]
        public sealed class XamlTemplateField : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
    }
}
namespace JetBrains.ReSharper.Psi.Xaml.Tree
{
    
    public class static BindingExtension
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.ReSharper.Psi.IType GetBindingSourceType([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Tree.ITreeNode binding) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.ReSharper.Psi.IType GetBindingSourceType([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Tree.ITreeNode binding, out JetBrains.ReSharper.Psi.Xaml.Tree.IXamlObjectElement objectElement) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Psi.Tree.ITreeNode GetConverterSetter([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Xaml.Tree.IBinding binding) { }
        [JetBrains.Annotations.NotNullAttribute()]
        [System.ObsoleteAttribute("Use GetBindingSourceType without node restriction to be IBinding")]
        public static JetBrains.ReSharper.Psi.IType GetSourceType([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Xaml.Tree.IBinding binding, out JetBrains.ReSharper.Psi.Xaml.Tree.IXamlObjectElement objectElement) { }
    }
    public enum BindingMode
    {
        UNKNOWN = 0,
        ONE_WAY = 1,
        ONE_TIME = 2,
        TWO_WAY = 3,
        ONE_WAY_TO_SOURCE = 4,
        DEFAULT = 5,
    }
    public interface IArgumentsAttribute : JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xaml.Tree.IKeywordAttribute, JetBrains.ReSharper.Psi.Xaml.Tree.IXamlAttribute, JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttribute, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode { }
    public interface IAuthorityReference : JetBrains.ReSharper.Psi.Resolve.ICompleteableReference, JetBrains.ReSharper.Psi.Resolve.IQualifier, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.ReSharper.Psi.Xaml.Tree.IPathQualifier, JetBrains.ReSharper.Psi.Xaml.Tree.ISmartCompleteableReference, JetBrains.ReSharper.Psi.Xaml.Tree.IXamlReference, JetBrains.ReSharper.Psi.Xml.Tree.References.IXmlCompleteableReference, JetBrains.ReSharper.Psi.Xml.Tree.References.IXmlReference, JetBrains.ReSharper.Psi.Xml.Tree.References.IXmlSmartCompleteableReference, JetBrains.Util.IUserDataHolder { }
    public interface IBinding : JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Xaml.Tree.IElementNameUsage ElementName { get; }
        JetBrains.ReSharper.Psi.Xaml.Tree.BindingMode Mode { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Xaml.Tree.MarkupExtensions.IPathValue Path { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Xaml.Tree.IRelativeSourceUsage RelativeSource { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Xaml.Tree.ISourceUsage Source { get; }
    }
    public interface IBindingElement : JetBrains.ReSharper.Psi.ExtensionsAPI.Caches2.ICachedTypeMemberDeclaration, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IIncrementalScope, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IScope, JetBrains.ReSharper.Psi.IAccessRightsOwner, JetBrains.ReSharper.Psi.IModifiersOwner, JetBrains.ReSharper.Psi.Tree.IAccessRightsOwnerDeclaration, JetBrains.ReSharper.Psi.Tree.IDeclaration, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Tree.IXmlDocOwnerTreeNode, JetBrains.ReSharper.Psi.Xaml.Impl.Tree.ITypeUsage, JetBrains.ReSharper.Psi.Xaml.Tree.IBinding, JetBrains.ReSharper.Psi.Xaml.Tree.IXamlDeclaration, JetBrains.ReSharper.Psi.Xaml.Tree.IXamlObjectElement, JetBrains.ReSharper.Psi.Xaml.Tree.IXamlObjectElementDeclaration, JetBrains.ReSharper.Psi.Xaml.Tree.IXamlObjectElementDeclaration<JetBrains.ReSharper.Psi.Xaml.Tree.IDeclarationNameAttribute>, JetBrains.ReSharper.Psi.Xaml.Tree.IXamlTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagContainer, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode { }
    public interface IControlTemplateDeclaration : JetBrains.ReSharper.Psi.ExtensionsAPI.Caches2.ICachedTypeMemberDeclaration, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IIncrementalScope, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IScope, JetBrains.ReSharper.Psi.IAccessRightsOwner, JetBrains.ReSharper.Psi.IModifiersOwner, JetBrains.ReSharper.Psi.Tree.IAccessRightsOwnerDeclaration, JetBrains.ReSharper.Psi.Tree.IDeclaration, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Tree.ITypeOwnerDeclaration, JetBrains.ReSharper.Psi.Tree.IXmlDocOwnerTreeNode, JetBrains.ReSharper.Psi.Xaml.Impl.Tree.ITypeUsage, JetBrains.ReSharper.Psi.Xaml.Tree.IResourceDeclaration, JetBrains.ReSharper.Psi.Xaml.Tree.ITargetTypeContainerDeclaration, JetBrains.ReSharper.Psi.Xaml.Tree.IXamlDeclaration, JetBrains.ReSharper.Psi.Xaml.Tree.IXamlObjectElement, JetBrains.ReSharper.Psi.Xaml.Tree.IXamlObjectElementDeclaration, JetBrains.ReSharper.Psi.Xaml.Tree.IXamlObjectElementDeclaration<JetBrains.ReSharper.Psi.Xaml.Tree.IXKeyElement>, JetBrains.ReSharper.Psi.Xaml.Tree.IXamlTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagContainer, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode { }
    public interface IDataTemplateDeclaration : JetBrains.ReSharper.Psi.ExtensionsAPI.Caches2.ICachedTypeMemberDeclaration, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IIncrementalScope, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IScope, JetBrains.ReSharper.Psi.IAccessRightsOwner, JetBrains.ReSharper.Psi.IModifiersOwner, JetBrains.ReSharper.Psi.Tree.IAccessRightsOwnerDeclaration, JetBrains.ReSharper.Psi.Tree.IDeclaration, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Tree.ITypeOwnerDeclaration, JetBrains.ReSharper.Psi.Tree.IXmlDocOwnerTreeNode, JetBrains.ReSharper.Psi.Xaml.Impl.Tree.ITypeUsage, JetBrains.ReSharper.Psi.Xaml.Tree.IResourceDeclaration, JetBrains.ReSharper.Psi.Xaml.Tree.IXamlDeclaration, JetBrains.ReSharper.Psi.Xaml.Tree.IXamlObjectElement, JetBrains.ReSharper.Psi.Xaml.Tree.IXamlObjectElementDeclaration, JetBrains.ReSharper.Psi.Xaml.Tree.IXamlObjectElementDeclaration<JetBrains.ReSharper.Psi.Xaml.Tree.IXKeyElement>, JetBrains.ReSharper.Psi.Xaml.Tree.IXamlTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagContainer, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Resolve.IReference DataTypeReference { get; }
    }
    public interface IDeclarationNameAttribute : JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xaml.Tree.IDeclarationNameElement, JetBrains.ReSharper.Psi.Xaml.Tree.IXamlAttribute, JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttribute, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode { }
    public interface IDeclarationNameElement : JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        [JetBrains.Annotations.NotNullAttribute()]
        string DeclaredName { get; }
        JetBrains.ReSharper.Psi.TreeTextRange GetNameRange();
        void SetName([JetBrains.Annotations.NotNullAttribute()] string newName);
    }
    public interface IDependencyPropertyReference : JetBrains.ReSharper.Psi.Resolve.ICompleteableReference, JetBrains.ReSharper.Psi.Resolve.ILateBoundReference, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.ReSharper.Psi.Xaml.Tree.ISmartCompleteableReference, JetBrains.ReSharper.Psi.Xaml.Tree.IXamlReference, JetBrains.ReSharper.Psi.Xml.Tree.References.IXmlCompleteableReference, JetBrains.ReSharper.Psi.Xml.Tree.References.IXmlReference, JetBrains.ReSharper.Psi.Xml.Tree.References.IXmlSmartCompleteableReference, JetBrains.Util.IUserDataHolder
    {
        bool CanBeAttachedProperty { get; }
        bool CanBeDependencyProperty { get; }
        bool CanBeRegularProperty { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.ResolveResultWithInfo ResolveAsUnqualified();
    }
    public interface IElementNameReference : JetBrains.ReSharper.Psi.Resolve.ICompleteableReference, JetBrains.ReSharper.Psi.Resolve.ILateBoundReference, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.ReSharper.Psi.Xaml.Tree.ISmartCompleteableReference, JetBrains.ReSharper.Psi.Xaml.Tree.IXamlReference, JetBrains.ReSharper.Psi.Xml.Tree.References.IXmlCompleteableReference, JetBrains.ReSharper.Psi.Xml.Tree.References.IXmlReference, JetBrains.ReSharper.Psi.Xml.Tree.References.IXmlSmartCompleteableReference, JetBrains.Util.IUserDataHolder { }
    public interface IElementNameUsage : JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Xaml.Tree.IElementNameReference ElementNameReference { get; }
    }
    public interface IFieldDeclaration : JetBrains.ReSharper.Psi.Tree.IDeclaration, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Tree.ITypeMemberDeclaration, JetBrains.ReSharper.Psi.Tree.ITypeOwnerDeclaration, JetBrains.ReSharper.Psi.Tree.IXmlDocOwnerTreeNode
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.IField DeclaredElement { get; }
    }
    public interface IFolderOrAssemblyReference : JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IQualifiableReferenceBase, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IQualifiableReferenceWithGlobalSymbolTable, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IReferenceWithGlobalSymbolTable, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IReferenceWithQualifier, JetBrains.ReSharper.Psi.Resolve.ICompleteableReference, JetBrains.ReSharper.Psi.Resolve.IPathReference, JetBrains.ReSharper.Psi.Resolve.IQualifier, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.ReSharper.Psi.Xaml.Tree.IPathQualifier, JetBrains.Util.IUserDataHolder
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ProjectModel.IModule GetResolvedModule();
    }
    public interface IHiearchialDataTemplateDeclaration : JetBrains.ReSharper.Psi.ExtensionsAPI.Caches2.ICachedTypeMemberDeclaration, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IIncrementalScope, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IScope, JetBrains.ReSharper.Psi.IAccessRightsOwner, JetBrains.ReSharper.Psi.IModifiersOwner, JetBrains.ReSharper.Psi.Tree.IAccessRightsOwnerDeclaration, JetBrains.ReSharper.Psi.Tree.IDeclaration, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Tree.ITypeOwnerDeclaration, JetBrains.ReSharper.Psi.Tree.IXmlDocOwnerTreeNode, JetBrains.ReSharper.Psi.Xaml.Impl.Tree.ITypeUsage, JetBrains.ReSharper.Psi.Xaml.Tree.IDataTemplateDeclaration, JetBrains.ReSharper.Psi.Xaml.Tree.IResourceDeclaration, JetBrains.ReSharper.Psi.Xaml.Tree.IXamlDeclaration, JetBrains.ReSharper.Psi.Xaml.Tree.IXamlObjectElement, JetBrains.ReSharper.Psi.Xaml.Tree.IXamlObjectElementDeclaration, JetBrains.ReSharper.Psi.Xaml.Tree.IXamlObjectElementDeclaration<JetBrains.ReSharper.Psi.Xaml.Tree.IXKeyElement>, JetBrains.ReSharper.Psi.Xaml.Tree.IXamlTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagContainer, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode { }
    public interface IKeywordAttribute : JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xaml.Tree.IXamlAttribute, JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttribute, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode { }
    public interface IMarkupAttributeValueReference : JetBrains.ReSharper.Psi.Resolve.ICompleteableReference, JetBrains.ReSharper.Psi.Resolve.ILateBoundReference, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.ReSharper.Psi.Xaml.Tree.ISmartCompleteableReference, JetBrains.ReSharper.Psi.Xaml.Tree.IXamlReference, JetBrains.ReSharper.Psi.Xml.Tree.References.IXmlCompleteableReference, JetBrains.ReSharper.Psi.Xml.Tree.References.IXmlReference, JetBrains.ReSharper.Psi.Xml.Tree.References.IXmlSmartCompleteableReference, JetBrains.Util.IUserDataHolder { }
    public interface IMarkupPropertyReference : JetBrains.ReSharper.Psi.Resolve.ICompleteableReference, JetBrains.ReSharper.Psi.Resolve.ILateBoundReference, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.ReSharper.Psi.Xaml.Tree.ISmartCompleteableReference, JetBrains.ReSharper.Psi.Xaml.Tree.IXamlReference, JetBrains.ReSharper.Psi.Xml.Tree.References.IXmlCompleteableReference, JetBrains.ReSharper.Psi.Xml.Tree.References.IXmlReference, JetBrains.ReSharper.Psi.Xml.Tree.References.IXmlSmartCompleteableReference, JetBrains.Util.IUserDataHolder { }
    public interface IModifiersAttribute : JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xaml.Tree.IKeywordAttribute, JetBrains.ReSharper.Psi.Xaml.Tree.IXamlAttribute, JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttribute, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode { }
    public interface INameAttribute : JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xaml.Impl.Tree.IPropertySetter, JetBrains.ReSharper.Psi.Xaml.Impl.Tree.ITypeMemberUsage, JetBrains.ReSharper.Psi.Xaml.Impl.Tree.ITypeUsage, JetBrains.ReSharper.Psi.Xaml.Tree.IDeclarationNameAttribute, JetBrains.ReSharper.Psi.Xaml.Tree.IDeclarationNameElement, JetBrains.ReSharper.Psi.Xaml.Tree.IPropertyAttribute, JetBrains.ReSharper.Psi.Xaml.Tree.IXamlAttribute, JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttribute, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode { }
    public interface INameInClassOrResourceAttribute : JetBrains.ReSharper.Psi.ExtensionsAPI.Caches2.ICachedTypeMemberDeclaration, JetBrains.ReSharper.Psi.IAccessRightsOwner, JetBrains.ReSharper.Psi.IModifiersOwner, JetBrains.ReSharper.Psi.Tree.IAccessRightsOwnerDeclaration, JetBrains.ReSharper.Psi.Tree.IDeclaration, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Tree.ITypeMemberDeclaration, JetBrains.ReSharper.Psi.Tree.IXmlDocOwnerTreeNode, JetBrains.ReSharper.Psi.Xaml.Tree.IXamlAttribute, JetBrains.ReSharper.Psi.Xaml.Tree.IXamlDeclaration, JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttribute, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode { }
    public interface INamespaceAlias : JetBrains.ReSharper.Psi.Tree.IDeclaration, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Tree.IXmlDocOwnerTreeNode, JetBrains.ReSharper.Psi.Xaml.Tree.IXamlAttribute, JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttribute, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Xaml.DeclaredElements.IXamlNamespaceAlias DeclaredElement { get; }
        bool IsDefault { get; }
    }
    public interface IObjectDataProviderDeclaration : JetBrains.ReSharper.Psi.ExtensionsAPI.Caches2.ICachedTypeMemberDeclaration, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IIncrementalScope, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IScope, JetBrains.ReSharper.Psi.IAccessRightsOwner, JetBrains.ReSharper.Psi.IModifiersOwner, JetBrains.ReSharper.Psi.Tree.IAccessRightsOwnerDeclaration, JetBrains.ReSharper.Psi.Tree.IDeclaration, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Tree.ITypeOwnerDeclaration, JetBrains.ReSharper.Psi.Tree.IXmlDocOwnerTreeNode, JetBrains.ReSharper.Psi.Xaml.Impl.Tree.ITypeUsage, JetBrains.ReSharper.Psi.Xaml.Tree.IResourceDeclaration, JetBrains.ReSharper.Psi.Xaml.Tree.IXamlDeclaration, JetBrains.ReSharper.Psi.Xaml.Tree.IXamlObjectElement, JetBrains.ReSharper.Psi.Xaml.Tree.IXamlObjectElementDeclaration, JetBrains.ReSharper.Psi.Xaml.Tree.IXamlObjectElementDeclaration<JetBrains.ReSharper.Psi.Xaml.Tree.IXKeyElement>, JetBrains.ReSharper.Psi.Xaml.Tree.IXamlTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagContainer, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        JetBrains.ReSharper.Psi.Tree.TreeNodeEnumerable<JetBrains.ReSharper.Psi.Xaml.Tree.IXamlObjectElement> ConstuctorParameters { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeEnumerable<JetBrains.ReSharper.Psi.Xaml.Tree.IXamlObjectElement> MethodParameters { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Resolve.IReference MethodReference { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Xaml.Impl.Tree.IPropertySetter ObjectInstance { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Resolve.IReference ObjectTypeReference { get; }
    }
    public interface IPathQualifier : JetBrains.ReSharper.Psi.Resolve.IQualifier
    {
        JetBrains.Util.FileSystemPath GetQualifierPath();
    }
    public interface IPredefinedAttributeReference : JetBrains.ReSharper.Psi.Resolve.ICompleteableReference, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.ReSharper.Psi.Xaml.Tree.ISmartCompleteableReference, JetBrains.ReSharper.Psi.Xaml.Tree.IXamlReference, JetBrains.ReSharper.Psi.Xml.Tree.References.IXmlCompleteableReference, JetBrains.ReSharper.Psi.Xml.Tree.References.IXmlReference, JetBrains.ReSharper.Psi.Xml.Tree.References.IXmlSmartCompleteableReference, JetBrains.Util.IUserDataHolder { }
    public interface IPropertyAttribute : JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xaml.Impl.Tree.IPropertySetter, JetBrains.ReSharper.Psi.Xaml.Impl.Tree.ITypeMemberUsage, JetBrains.ReSharper.Psi.Xaml.Impl.Tree.ITypeUsage, JetBrains.ReSharper.Psi.Xaml.Tree.IXamlAttribute, JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttribute, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Xaml.Tree.IPropertyAttributeValue Value { get; }
    }
    public interface IPropertyAttributeValue : JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xaml.Impl.Tree.ITypeUsage, JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttributeValue, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken LQuote { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Xaml.Tree.MarkupExtensions.IMarkupAttributeValue MarkupAttributeValue { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken RQuote { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<JetBrains.ReSharper.Psi.Xaml.Tree.MarkupExtensions.IMarkupAttributeValue> GetMarkupAttributeValues();
        JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<JetBrains.ReSharper.Psi.Xaml.Tree.MarkupExtensions.IMarkup> GetMarkups();
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken GetTextToken();
    }
    public interface IPropertyReference : JetBrains.ReSharper.Psi.Resolve.ICompleteableReference, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.ReSharper.Psi.Xaml.Tree.ISmartCompleteableReference, JetBrains.ReSharper.Psi.Xaml.Tree.IXamlReference, JetBrains.ReSharper.Psi.Xml.Tree.References.IXmlCompleteableReference, JetBrains.ReSharper.Psi.Xml.Tree.References.IXmlReference, JetBrains.ReSharper.Psi.Xml.Tree.References.IXmlSmartCompleteableReference, JetBrains.Util.IUserDataHolder
    {
        bool CanBeAttachedProperty();
        bool CanBeRoutedOrAttachedEvent();
        bool CanBeSelfProperty(out bool mustBeDefinedInXaml);
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.ResolveResultWithInfo ResolveAsUnqualified();
    }
    public interface IRelativeSourceUsage : JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        int AncestorLevel { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Xaml.Impl.Tree.ITypeUsage AncestorType { get; }
        JetBrains.ReSharper.Psi.Xaml.Tree.RelativeSourceMode Mode { get; }
    }
    public interface IResourceByStaticMemberReference : JetBrains.ReSharper.Psi.Resolve.ICompleteableReference, JetBrains.ReSharper.Psi.Resolve.ILateBoundReference, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.ReSharper.Psi.Xaml.Tree.IResourceReference, JetBrains.ReSharper.Psi.Xaml.Tree.ISmartCompleteableReference, JetBrains.ReSharper.Psi.Xaml.Tree.IXamlReference, JetBrains.ReSharper.Psi.Xml.Tree.References.IXmlCompleteableReference, JetBrains.ReSharper.Psi.Xml.Tree.References.IXmlReference, JetBrains.ReSharper.Psi.Xml.Tree.References.IXmlSmartCompleteableReference, JetBrains.Util.IUserDataHolder
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.IDeclaredElement GetStaticMember();
    }
    public interface IResourceByTypeReference : JetBrains.ReSharper.Psi.Resolve.ICompleteableReference, JetBrains.ReSharper.Psi.Resolve.ILateBoundReference, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.ReSharper.Psi.Xaml.Tree.IResourceReference, JetBrains.ReSharper.Psi.Xaml.Tree.ISmartCompleteableReference, JetBrains.ReSharper.Psi.Xaml.Tree.IXamlReference, JetBrains.ReSharper.Psi.Xml.Tree.References.IXmlCompleteableReference, JetBrains.ReSharper.Psi.Xml.Tree.References.IXmlReference, JetBrains.ReSharper.Psi.Xml.Tree.References.IXmlSmartCompleteableReference, JetBrains.Util.IUserDataHolder
    {
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IType GetKeyType();
    }
    public interface IResourceDeclaration : JetBrains.ReSharper.Psi.ExtensionsAPI.Caches2.ICachedTypeMemberDeclaration, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IIncrementalScope, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IScope, JetBrains.ReSharper.Psi.IAccessRightsOwner, JetBrains.ReSharper.Psi.IModifiersOwner, JetBrains.ReSharper.Psi.Tree.IAccessRightsOwnerDeclaration, JetBrains.ReSharper.Psi.Tree.IDeclaration, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Tree.ITypeOwnerDeclaration, JetBrains.ReSharper.Psi.Tree.IXmlDocOwnerTreeNode, JetBrains.ReSharper.Psi.Xaml.Impl.Tree.ITypeUsage, JetBrains.ReSharper.Psi.Xaml.Tree.IXamlDeclaration, JetBrains.ReSharper.Psi.Xaml.Tree.IXamlObjectElement, JetBrains.ReSharper.Psi.Xaml.Tree.IXamlObjectElementDeclaration, JetBrains.ReSharper.Psi.Xaml.Tree.IXamlObjectElementDeclaration<JetBrains.ReSharper.Psi.Xaml.Tree.IXKeyElement>, JetBrains.ReSharper.Psi.Xaml.Tree.IXamlTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagContainer, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Xaml.DeclaredElements.IXamlResource DeclaredElement { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Resolve.IReference KeyTypeReference { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Resolve.IReference StaticMemberReference { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Xaml.Tree.IXKeyElement> GetXKeyElements();
    }
    public interface IResourceInSpecificContainerReference : JetBrains.ReSharper.Psi.Resolve.ICompleteableReference, JetBrains.ReSharper.Psi.Resolve.ILateBoundReference, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.ReSharper.Psi.Xaml.Tree.IResourceReference, JetBrains.ReSharper.Psi.Xaml.Tree.ISmartCompleteableReference, JetBrains.ReSharper.Psi.Xaml.Tree.IXamlReference, JetBrains.ReSharper.Psi.Xml.Tree.References.IXmlCompleteableReference, JetBrains.ReSharper.Psi.Xml.Tree.References.IXmlReference, JetBrains.ReSharper.Psi.Xml.Tree.References.IXmlSmartCompleteableReference, JetBrains.Util.IUserDataHolder
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Xaml.Tree.IXamlObjectElement TargetContainer { get; }
    }
    public interface IResourceReference : JetBrains.ReSharper.Psi.Resolve.ICompleteableReference, JetBrains.ReSharper.Psi.Resolve.ILateBoundReference, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.ReSharper.Psi.Xaml.Tree.ISmartCompleteableReference, JetBrains.ReSharper.Psi.Xaml.Tree.IXamlReference, JetBrains.ReSharper.Psi.Xml.Tree.References.IXmlCompleteableReference, JetBrains.ReSharper.Psi.Xml.Tree.References.IXmlReference, JetBrains.ReSharper.Psi.Xml.Tree.References.IXmlSmartCompleteableReference, JetBrains.Util.IUserDataHolder
    {
        bool IsStatic { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Xaml.Impl.Tree.ITypeMemberReference TargetMemberReference { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IType GetExpectedType();
    }
    public interface IResourceUsage : JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        bool IsStaticResource { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Xaml.Tree.IResourceReference ResourceReference { get; }
    }
    public interface IRoutedEventReference : JetBrains.ReSharper.Psi.Resolve.ICompleteableReference, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.ReSharper.Psi.Xaml.Tree.ISmartCompleteableReference, JetBrains.ReSharper.Psi.Xaml.Tree.IXamlReference, JetBrains.ReSharper.Psi.Xml.Tree.References.IXmlCompleteableReference, JetBrains.ReSharper.Psi.Xml.Tree.References.IXmlReference, JetBrains.ReSharper.Psi.Xml.Tree.References.IXmlSmartCompleteableReference, JetBrains.Util.IUserDataHolder
    {
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.ResolveResultWithInfo ResolveAsUnqualified();
    }
    public interface ISharedAttribute : JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xaml.Tree.IKeywordAttribute, JetBrains.ReSharper.Psi.Xaml.Tree.IXamlAttribute, JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttribute, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode { }
    public interface ISmartCompleteableReference : JetBrains.ReSharper.Psi.Resolve.ICompleteableReference, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.ReSharper.Psi.Xaml.Tree.IXamlReference, JetBrains.ReSharper.Psi.Xml.Tree.References.IXmlCompleteableReference, JetBrains.ReSharper.Psi.Xml.Tree.References.IXmlReference, JetBrains.ReSharper.Psi.Xml.Tree.References.IXmlSmartCompleteableReference, JetBrains.Util.IUserDataHolder { }
    public interface ISourceUsage : JetBrains.ReSharper.Psi.Tree.ITreeNode { }
    public interface IStyleDeclaration : JetBrains.ReSharper.Psi.ExtensionsAPI.Caches2.ICachedTypeMemberDeclaration, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IIncrementalScope, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IScope, JetBrains.ReSharper.Psi.IAccessRightsOwner, JetBrains.ReSharper.Psi.IModifiersOwner, JetBrains.ReSharper.Psi.Tree.IAccessRightsOwnerDeclaration, JetBrains.ReSharper.Psi.Tree.IDeclaration, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Tree.ITypeOwnerDeclaration, JetBrains.ReSharper.Psi.Tree.IXmlDocOwnerTreeNode, JetBrains.ReSharper.Psi.Xaml.Impl.Tree.ITypeUsage, JetBrains.ReSharper.Psi.Xaml.Tree.IResourceDeclaration, JetBrains.ReSharper.Psi.Xaml.Tree.ITargetTypeContainerDeclaration, JetBrains.ReSharper.Psi.Xaml.Tree.IXamlDeclaration, JetBrains.ReSharper.Psi.Xaml.Tree.IXamlObjectElement, JetBrains.ReSharper.Psi.Xaml.Tree.IXamlObjectElementDeclaration, JetBrains.ReSharper.Psi.Xaml.Tree.IXamlObjectElementDeclaration<JetBrains.ReSharper.Psi.Xaml.Tree.IXKeyElement>, JetBrains.ReSharper.Psi.Xaml.Tree.IXamlTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagContainer, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Resolve.IReference BasedOnTypeReference { get; }
    }
    public interface ITargetNameReference : JetBrains.ReSharper.Psi.Resolve.ICompleteableReference, JetBrains.ReSharper.Psi.Resolve.ILateBoundReference, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.ReSharper.Psi.Xaml.Tree.IElementNameReference, JetBrains.ReSharper.Psi.Xaml.Tree.ISmartCompleteableReference, JetBrains.ReSharper.Psi.Xaml.Tree.IXamlReference, JetBrains.ReSharper.Psi.Xml.Tree.References.IXmlCompleteableReference, JetBrains.ReSharper.Psi.Xml.Tree.References.IXmlReference, JetBrains.ReSharper.Psi.Xml.Tree.References.IXmlSmartCompleteableReference, JetBrains.Util.IUserDataHolder { }
    public interface ITargetTypeContainerDeclaration : JetBrains.ReSharper.Psi.ExtensionsAPI.Caches2.ICachedTypeMemberDeclaration, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IIncrementalScope, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IScope, JetBrains.ReSharper.Psi.IAccessRightsOwner, JetBrains.ReSharper.Psi.IModifiersOwner, JetBrains.ReSharper.Psi.Tree.IAccessRightsOwnerDeclaration, JetBrains.ReSharper.Psi.Tree.IDeclaration, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Tree.ITypeOwnerDeclaration, JetBrains.ReSharper.Psi.Tree.IXmlDocOwnerTreeNode, JetBrains.ReSharper.Psi.Xaml.Impl.Tree.ITypeUsage, JetBrains.ReSharper.Psi.Xaml.Tree.IResourceDeclaration, JetBrains.ReSharper.Psi.Xaml.Tree.IXamlDeclaration, JetBrains.ReSharper.Psi.Xaml.Tree.IXamlObjectElement, JetBrains.ReSharper.Psi.Xaml.Tree.IXamlObjectElementDeclaration, JetBrains.ReSharper.Psi.Xaml.Tree.IXamlObjectElementDeclaration<JetBrains.ReSharper.Psi.Xaml.Tree.IXKeyElement>, JetBrains.ReSharper.Psi.Xaml.Tree.IXamlTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagContainer, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Resolve.IReference TargetTypeReference { get; }
    }
    public interface ITemplateFieldDeclaration : JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IIncrementalScope, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IScope, JetBrains.ReSharper.Psi.Tree.IDeclaration, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Tree.ITypeOwnerDeclaration, JetBrains.ReSharper.Psi.Tree.IXmlDocOwnerTreeNode, JetBrains.ReSharper.Psi.Xaml.Impl.Tree.ITypeUsage, JetBrains.ReSharper.Psi.Xaml.Tree.IXamlObjectElement, JetBrains.ReSharper.Psi.Xaml.Tree.IXamlTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagContainer, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode { }
    public interface ITypeArgumentsAttribute : JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xaml.Tree.IKeywordAttribute, JetBrains.ReSharper.Psi.Xaml.Tree.IXamlAttribute, JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttribute, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Xaml.Tree.IXamlTypeReference> TypeReferences { get; }
    }
    public interface IUriPrefixReference : JetBrains.ReSharper.Psi.Resolve.ICompleteableReference, JetBrains.ReSharper.Psi.Resolve.IQualifier, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.ReSharper.Psi.Xaml.Tree.IPathQualifier, JetBrains.ReSharper.Psi.Xaml.Tree.ISmartCompleteableReference, JetBrains.ReSharper.Psi.Xaml.Tree.IXamlReference, JetBrains.ReSharper.Psi.Xml.Tree.References.IXmlCompleteableReference, JetBrains.ReSharper.Psi.Xml.Tree.References.IXmlReference, JetBrains.ReSharper.Psi.Xml.Tree.References.IXmlSmartCompleteableReference, JetBrains.Util.IUserDataHolder
    {
        bool IsURL { get; }
    }
    public interface IValueReference : JetBrains.ReSharper.Psi.Resolve.ICompleteableReference, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.ReSharper.Psi.Resolve.IReferenceToDelegateCreation, JetBrains.ReSharper.Psi.Xaml.Tree.ISmartCompleteableReference, JetBrains.ReSharper.Psi.Xaml.Tree.IXamlReference, JetBrains.ReSharper.Psi.Xml.Tree.References.IXmlCompleteableReference, JetBrains.ReSharper.Psi.Xml.Tree.References.IXmlReference, JetBrains.ReSharper.Psi.Xml.Tree.References.IXmlSmartCompleteableReference, JetBrains.Util.IUserDataHolder
    {
        JetBrains.ReSharper.Psi.IType GetExpectedType();
        JetBrains.ReSharper.Psi.IDeclaredType GetReferencedEventType();
        JetBrains.ReSharper.Psi.Xaml.Tree.ValueReferenceType GetValueReferenceType();
        JetBrains.ReSharper.Psi.Resolve.IReference SetValue(string text);
    }
    public interface IXamlAttribute : JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttribute, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Xaml.Tree.IXamlIdentifier Identifier { get; }
    }
    public interface IXamlConstructorReference : JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.ReSharper.Psi.Xaml.Tree.IXamlFunctionReference, JetBrains.ReSharper.Psi.Xaml.Tree.IXamlReference, JetBrains.ReSharper.Psi.Xml.Tree.References.IXmlReference, JetBrains.Util.IUserDataHolder { }
    public interface IXamlDeclaration : JetBrains.ReSharper.Psi.ExtensionsAPI.Caches2.ICachedTypeMemberDeclaration, JetBrains.ReSharper.Psi.IAccessRightsOwner, JetBrains.ReSharper.Psi.IModifiersOwner, JetBrains.ReSharper.Psi.Tree.IAccessRightsOwnerDeclaration, JetBrains.ReSharper.Psi.Tree.IDeclaration, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Tree.IXmlDocOwnerTreeNode
    {
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IType Type { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        string TypeName { get; }
        bool CanBeBoundTo(JetBrains.ReSharper.Psi.IDeclaredElement element);
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.IEnumerable<string> GetPossibleDeclaredNames();
    }
    public interface IXamlFactoryMethodReference : JetBrains.ReSharper.Psi.Resolve.ICompleteableReference, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.ReSharper.Psi.Xaml.Tree.ISmartCompleteableReference, JetBrains.ReSharper.Psi.Xaml.Tree.IXamlFunctionReference, JetBrains.ReSharper.Psi.Xaml.Tree.IXamlMethodReference, JetBrains.ReSharper.Psi.Xaml.Tree.IXamlReference, JetBrains.ReSharper.Psi.Xml.Tree.References.IXmlCompleteableReference, JetBrains.ReSharper.Psi.Xml.Tree.References.IXmlReference, JetBrains.ReSharper.Psi.Xml.Tree.References.IXmlSmartCompleteableReference, JetBrains.Util.IUserDataHolder
    {
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IType ExpectedReturnType { get; }
    }
    public interface IXamlFile : JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IScope, JetBrains.ReSharper.Psi.Tree.IFile, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlDocumentNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlFile, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagContainer, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        JetBrains.ReSharper.Psi.Tree.TreeNodeEnumerable<JetBrains.ReSharper.Psi.Xaml.Tree.IXamlTypeDeclaration> GetTypeDeclarations();
    }
    public interface IXamlFunctionReference : JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.ReSharper.Psi.Xaml.Tree.IXamlReference, JetBrains.ReSharper.Psi.Xml.Tree.References.IXmlReference, JetBrains.Util.IUserDataHolder
    {
        bool CaseSensitive { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.IList<JetBrains.ReSharper.Psi.IType> ParameterTypes { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Resolve.IReference TypeReference { get; }
    }
    public interface IXamlIdentifier : JetBrains.ReSharper.Psi.Tree.ITokenNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlIdentifier, JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        [JetBrains.Annotations.NotNullAttribute()]
        string Id { get; }
        JetBrains.ReSharper.Psi.TreeTextRange IdRange { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        string Qualifier { get; }
        JetBrains.ReSharper.Psi.TreeTextRange QualifierRange { get; }
    }
    public interface IXamlMethodReference : JetBrains.ReSharper.Psi.Resolve.ICompleteableReference, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.ReSharper.Psi.Xaml.Tree.ISmartCompleteableReference, JetBrains.ReSharper.Psi.Xaml.Tree.IXamlFunctionReference, JetBrains.ReSharper.Psi.Xaml.Tree.IXamlReference, JetBrains.ReSharper.Psi.Xml.Tree.References.IXmlCompleteableReference, JetBrains.ReSharper.Psi.Xml.Tree.References.IXmlReference, JetBrains.ReSharper.Psi.Xml.Tree.References.IXmlSmartCompleteableReference, JetBrains.Util.IUserDataHolder { }
    public interface IXamlNamespaceAliasReference : JetBrains.ReSharper.Psi.Resolve.ICompleteableReference, JetBrains.ReSharper.Psi.Resolve.IQualifier, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.Util.IUserDataHolder { }
    public interface IXamlNestedTypeReference : JetBrains.ReSharper.Psi.Resolve.ICompleteableReference, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.ReSharper.Psi.Xaml.Tree.IXamlReference, JetBrains.ReSharper.Psi.Xaml.Tree.IXamlTypeReference, JetBrains.ReSharper.Psi.Xml.Tree.References.IXmlCompleteableReference, JetBrains.ReSharper.Psi.Xml.Tree.References.IXmlReference, JetBrains.ReSharper.Psi.Xml.Tree.References.IXmlTypeNameCompleteableReference, JetBrains.Util.IUserDataHolder { }
    public interface IXamlObjectElement : JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IIncrementalScope, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IScope, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xaml.Impl.Tree.ITypeUsage, JetBrains.ReSharper.Psi.Xaml.Tree.IXamlTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagContainer, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Resolve.IReference ContentPropertyReference { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.IList<JetBrains.ReSharper.Psi.IType> TypeArguments { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Xaml.Impl.Tree.IPropertySetter GetPropertySetter(string propertyName, System.Predicate<JetBrains.ReSharper.Psi.Xaml.Impl.Tree.IPropertySetter> predicate = null);
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Xaml.Impl.Tree.IPropertySetter> GetPropertySetters();
    }
    public interface IXamlObjectElementDeclaration : JetBrains.ReSharper.Psi.ExtensionsAPI.Caches2.ICachedTypeMemberDeclaration, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IIncrementalScope, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IScope, JetBrains.ReSharper.Psi.IAccessRightsOwner, JetBrains.ReSharper.Psi.IModifiersOwner, JetBrains.ReSharper.Psi.Tree.IAccessRightsOwnerDeclaration, JetBrains.ReSharper.Psi.Tree.IDeclaration, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Tree.IXmlDocOwnerTreeNode, JetBrains.ReSharper.Psi.Xaml.Impl.Tree.ITypeUsage, JetBrains.ReSharper.Psi.Xaml.Tree.IXamlDeclaration, JetBrains.ReSharper.Psi.Xaml.Tree.IXamlObjectElement, JetBrains.ReSharper.Psi.Xaml.Tree.IXamlTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagContainer, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode { }
    public interface IXamlObjectElementDeclaration<out TNameElement> : JetBrains.ReSharper.Psi.ExtensionsAPI.Caches2.ICachedTypeMemberDeclaration, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IIncrementalScope, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IScope, JetBrains.ReSharper.Psi.IAccessRightsOwner, JetBrains.ReSharper.Psi.IModifiersOwner, JetBrains.ReSharper.Psi.Tree.IAccessRightsOwnerDeclaration, JetBrains.ReSharper.Psi.Tree.IDeclaration, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Tree.IXmlDocOwnerTreeNode, JetBrains.ReSharper.Psi.Xaml.Impl.Tree.ITypeUsage, JetBrains.ReSharper.Psi.Xaml.Tree.IXamlDeclaration, JetBrains.ReSharper.Psi.Xaml.Tree.IXamlObjectElement, JetBrains.ReSharper.Psi.Xaml.Tree.IXamlObjectElementDeclaration, JetBrains.ReSharper.Psi.Xaml.Tree.IXamlTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagContainer, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
        where out TNameElement : JetBrains.ReSharper.Psi.Xaml.Tree.IDeclarationNameElement
    {
        [JetBrains.Annotations.NotNullAttribute()]
        string Name { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        TNameElement GetDeclarationNameElement();
    }
    public interface IXamlOdpMethodReference : JetBrains.ReSharper.Psi.Resolve.ICompleteableReference, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.ReSharper.Psi.Xaml.Tree.ISmartCompleteableReference, JetBrains.ReSharper.Psi.Xaml.Tree.IXamlFunctionReference, JetBrains.ReSharper.Psi.Xaml.Tree.IXamlMethodReference, JetBrains.ReSharper.Psi.Xaml.Tree.IXamlReference, JetBrains.ReSharper.Psi.Xml.Tree.References.IXmlCompleteableReference, JetBrains.ReSharper.Psi.Xml.Tree.References.IXmlReference, JetBrains.ReSharper.Psi.Xml.Tree.References.IXmlSmartCompleteableReference, JetBrains.Util.IUserDataHolder { }
    public interface IXamlPathReference : JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IQualifiableReferenceBase, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IQualifiableReferenceWithGlobalSymbolTable, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IReferenceWithGlobalSymbolTable, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IReferenceWithQualifier, JetBrains.ReSharper.Psi.Resolve.ICompleteableReference, JetBrains.ReSharper.Psi.Resolve.IPathReference, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.Util.IUserDataHolder
    {
        bool CanBeMappedOrIgnored { get; }
        bool IsEmptyNameAllowed { get; }
        bool UseRootFolder { get; }
    }
    public interface IXamlPropertyElement : JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IIncrementalScope, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IScope, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xaml.Impl.Tree.IPropertySetter, JetBrains.ReSharper.Psi.Xaml.Impl.Tree.ITypeMemberUsage, JetBrains.ReSharper.Psi.Xaml.Impl.Tree.ITypeUsage, JetBrains.ReSharper.Psi.Xaml.Tree.IXamlTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagContainer, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IType ExpectedElementType { get; }
        JetBrains.Util.TextRange PropertyNameRange { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        string TypeName { get; }
        JetBrains.Util.TextRange TypeNameRange { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Xaml.Tree.MarkupExtensions.IMarkupAttributeValue Value { get; }
    }
    public interface IXamlReference : JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.ReSharper.Psi.Xml.Tree.References.IXmlReference, JetBrains.Util.IUserDataHolder { }
    public interface IXamlReferenceWithExpectedType
    {
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.IList<JetBrains.ReSharper.Psi.IType> GetExpectedTypes();
    }
    public interface IXamlReferenceWithToken : JetBrains.ReSharper.Psi.Impl.Shared.References.IReferenceWithinElement<JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken>, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.ReSharper.Psi.Xaml.Tree.IXamlReference, JetBrains.ReSharper.Psi.Xml.Tree.References.IReferenceWithToken, JetBrains.ReSharper.Psi.Xml.Tree.References.IXmlReference, JetBrains.Util.IUserDataHolder { }
    public interface IXamlTag : JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IIncrementalScope, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IScope, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagContainer, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<JetBrains.ReSharper.Psi.Xaml.Tree.INamespaceAlias> NamespaceAliases { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeEnumerable<JetBrains.ReSharper.Psi.Xaml.Tree.INamespaceAlias> NamespaceAliasesEnumerable { get; }
    }
    public interface IXamlToken : JetBrains.ReSharper.Psi.Tree.ITokenNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Xaml.Parsing.XamlTokenTypes XamlTokenTypes { get; }
    }
    public interface IXamlTypeDeclaration : JetBrains.ReSharper.Psi.ExtensionsAPI.Caches2.ICachedDeclaration2, JetBrains.ReSharper.Psi.ExtensionsAPI.Caches2.ICachedTypeMemberDeclaration, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IIncrementalScope, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IScope, JetBrains.ReSharper.Psi.IAccessRightsOwner, JetBrains.ReSharper.Psi.IModifiersOwner, JetBrains.ReSharper.Psi.Tree.IAccessRightsOwnerDeclaration, JetBrains.ReSharper.Psi.Tree.IDeclaration, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Tree.ITypeDeclaration, JetBrains.ReSharper.Psi.Tree.ITypeDeclarationHolder, JetBrains.ReSharper.Psi.Tree.IXmlDocOwnerTreeNode, JetBrains.ReSharper.Psi.Xaml.Impl.Tree.ITypeUsage, JetBrains.ReSharper.Psi.Xaml.Tree.IXamlDeclaration, JetBrains.ReSharper.Psi.Xaml.Tree.IXamlObjectElement, JetBrains.ReSharper.Psi.Xaml.Tree.IXamlObjectElementDeclaration, JetBrains.ReSharper.Psi.Xaml.Tree.IXamlTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagContainer, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        [JetBrains.Annotations.NotNullAttribute()]
        string[] ExtendsList { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        string[] NamespaceNames { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.TreeTextRange[] NamespaceRanges { get; }
        void SetNamespaceName(int namespacePartsCount, [JetBrains.Annotations.NotNullAttribute()] string newName);
        void SetNamespaceName([JetBrains.Annotations.NotNullAttribute()] string newName);
    }
    public interface IXamlTypeReference : JetBrains.ReSharper.Psi.Resolve.ICompleteableReference, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.ReSharper.Psi.Xaml.Tree.IXamlReference, JetBrains.ReSharper.Psi.Xml.Tree.References.IXmlCompleteableReference, JetBrains.ReSharper.Psi.Xml.Tree.References.IXmlReference, JetBrains.ReSharper.Psi.Xml.Tree.References.IXmlTypeNameCompleteableReference, JetBrains.Util.IUserDataHolder
    {
        bool CanBeMarkupExtensionReference { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Xaml.Tree.ReferencedNamespace> ContainingNamespaces { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Resolve.ISymbolFilter[] GetCompletionFilters();
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Resolve.ISymbolFilter[] GetSmartSymbolFilters();
    }
    public interface IXClassAttribute : JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xaml.Tree.IDeclarationNameAttribute, JetBrains.ReSharper.Psi.Xaml.Tree.IDeclarationNameElement, JetBrains.ReSharper.Psi.Xaml.Tree.IXamlAttribute, JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttribute, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        [JetBrains.Annotations.NotNullAttribute()]
        string[] NamespaceNames { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.TreeTextRange[] NamespaceTreeTextRanges { get; }
        void SetNamespaceName([JetBrains.Annotations.NotNullAttribute()] string newName);
        void SetNamespaceName(int namespacePartsCount, [JetBrains.Annotations.NotNullAttribute()] string newName);
    }
    public interface IXKeyAttribute : JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xaml.Tree.IDeclarationNameAttribute, JetBrains.ReSharper.Psi.Xaml.Tree.IDeclarationNameElement, JetBrains.ReSharper.Psi.Xaml.Tree.IXamlAttribute, JetBrains.ReSharper.Psi.Xaml.Tree.IXKeyElement, JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttribute, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode { }
    public interface IXKeyElement : JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xaml.Tree.IDeclarationNameElement
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Resolve.IReference KeyTypeReference { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Resolve.IReference StaticMemberReference { get; }
    }
    public interface IXKeyObjectElement : JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IIncrementalScope, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IScope, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xaml.Impl.Tree.ITypeUsage, JetBrains.ReSharper.Psi.Xaml.Tree.IDeclarationNameElement, JetBrains.ReSharper.Psi.Xaml.Tree.IXamlObjectElement, JetBrains.ReSharper.Psi.Xaml.Tree.IXamlTag, JetBrains.ReSharper.Psi.Xaml.Tree.IXKeyElement, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagContainer, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode { }
    public interface IXmlDataProviderDeclaration : JetBrains.ReSharper.Psi.ExtensionsAPI.Caches2.ICachedTypeMemberDeclaration, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IIncrementalScope, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IScope, JetBrains.ReSharper.Psi.IAccessRightsOwner, JetBrains.ReSharper.Psi.IModifiersOwner, JetBrains.ReSharper.Psi.Tree.IAccessRightsOwnerDeclaration, JetBrains.ReSharper.Psi.Tree.IDeclaration, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Tree.ITypeOwnerDeclaration, JetBrains.ReSharper.Psi.Tree.IXmlDocOwnerTreeNode, JetBrains.ReSharper.Psi.Xaml.Impl.Tree.ITypeUsage, JetBrains.ReSharper.Psi.Xaml.Tree.IResourceDeclaration, JetBrains.ReSharper.Psi.Xaml.Tree.IXamlDeclaration, JetBrains.ReSharper.Psi.Xaml.Tree.IXamlObjectElement, JetBrains.ReSharper.Psi.Xaml.Tree.IXamlObjectElementDeclaration, JetBrains.ReSharper.Psi.Xaml.Tree.IXamlObjectElementDeclaration<JetBrains.ReSharper.Psi.Xaml.Tree.IXKeyElement>, JetBrains.ReSharper.Psi.Xaml.Tree.IXamlTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagContainer, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode { }
    public interface IXmlSpaceAttribute : JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xaml.Tree.IKeywordAttribute, JetBrains.ReSharper.Psi.Xaml.Tree.IXamlAttribute, JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttribute, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode { }
    public interface IXNameAttribute : JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xaml.Tree.IDeclarationNameAttribute, JetBrains.ReSharper.Psi.Xaml.Tree.IDeclarationNameElement, JetBrains.ReSharper.Psi.Xaml.Tree.IXamlAttribute, JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttribute, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode { }
    public interface IXNull : JetBrains.ReSharper.Psi.Tree.ITreeNode { }
    public interface IXReference : JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xaml.Tree.IElementNameUsage { }
    public interface IXStatic : JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xaml.Impl.Tree.ITypeMemberUsage, JetBrains.ReSharper.Psi.Xaml.Impl.Tree.ITypeUsage
    {
        [JetBrains.Annotations.NotNullAttribute()]
        string MemberName { get; }
    }
    public interface IXType : JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xaml.Impl.Tree.ITypeUsage { }
    public struct ReferencedNamespace : System.IEquatable<JetBrains.ReSharper.Psi.Xaml.Tree.ReferencedNamespace>
    {
        public ReferencedNamespace([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.INamespace nameSpace, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Modules.IPsiModule targetModule) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ReSharper.Psi.INamespace Namespace { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Psi.Modules.IPsiModule TargetModule { get; }
        public bool Equals(JetBrains.ReSharper.Psi.Xaml.Tree.ReferencedNamespace other) { }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Modules.IPsiModule> GetModulesTable([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.INamespace nameSpace, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode context) { }
        public JetBrains.Util.DataStructures.HybridCollection<JetBrains.ReSharper.Psi.Modules.IPsiModule> GetReferencedModules([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode context) { }
        public JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetSymbolTable([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Modules.IPsiModule module, JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext context) { }
        public override string ToString() { }
    }
    public enum RelativeSourceMode
    {
        UNKNOWN = 0,
        DEFAULT = 1,
        FIND_ANCESTOR = 2,
        PREVIOUS_DATA = 3,
        SELF = 4,
        TEMPLATED_PARENT = 5,
    }
    public enum ValueReferenceType
    {
        NONE = 0,
        EVENT = 1,
        ENUM = 2,
        BRUSH = 3,
        COLOR = 4,
        FONT_WEIGHT = 5,
        FONT_STYLE = 6,
        FONT_STRETCH = 7,
        STARTUP_URI = 8,
        GRID_LENGTH = 9,
        BOOL = 10,
        SILVERLIGHT_BRUSH = 11,
        SILVERLIGHT_COLOR = 12,
        SILVERLIGHT_FONT_STYLE = 13,
        STORYBOARD_TARGET_NAME = 14,
        STORYBOARD_TARGET_PROPERTY = 15,
        REPEAT_BEHAVIOUR = 16,
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.Xaml.XamlLanguage))]
    public class XamlElementTypes : JetBrains.ReSharper.Psi.Xml.Tree.XmlElementTypes
    {
        public XamlElementTypes(JetBrains.ReSharper.Psi.Parsing.XmlTokenTypes xmlTokenTypes) { }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType ATTRIBUTE_ATTACHED_PROPERTY_VALUE { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType ATTRIBUTE_INDEXER_CASTED_PARAMETER { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType ATTRIBUTE_INDEXER_PARAMETER { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType ATTRIBUTE_INDEXER_PARAMETER_LIST { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType ATTRIBUTE_INDEXER_VALUE { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType ATTRIBUTE_LIST_MARKUP_VALUE { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType BINDING_ELEMENT { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType BINDING_MARKUP { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType CLASS_MODIFIER_ATTRIBUTE { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType CODE_ELEMENT { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType CONTROL_TEMPLATE_DECL { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType DATA_TEMPLATE_DECL { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType DEPENDECY_PROPERTY_ELEMENT { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType DEPENDENCY_PROPERTY_ATTRIBUTE_VALUE { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType ELEMENT_NAME_ATTRIBUTE { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType ELEMENT_NAME_ELEMENT { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType ERROR_VALUE { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType ESCAPED_VALUE { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType EVENT_SETTER_ELEMENT { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType EVENT_SETTER_PROPERTY_ATTRIBUTE_VALUE { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType FIELD_DECL { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType FIELD_MODIFIER_ATTRIBUTE { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType IDENTIFIER_MARKUP_VALUE { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType MARKUP { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType MARKUP_ANCESTOR_TYPE_ATTRIBUTE { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType MARKUP_ATTRIBUTE { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType MARKUP_ELEMENT_NAME_ATTRIBUTE { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType MARKUP_RELATIVE_SOURCE_ATTRIBUTE { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType MARKUP_SOURCE_ATTRIBUTE { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType NAME_ATTRIBUTE { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType NAME_IN_CLASS_OR_RESOURCE_ATTRIBUTE { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType NAME_IN_XPROPERTY_ATTRIBUTE { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType NAMESPACE_ALIAS { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType NESTED_TYPE { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType NULL_ELEMENT { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType NULL_MARKUP { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType NUMBER_VALUE { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType OBJECT_DATA_PROVIDER_DECL { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType OBJECT_TYPE_ATTRIBUTE { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType PATH_PROPERTY_EXPRESSION { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType PATH_SOURCE_TRAVERSAL_VALUE { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType PATH_TYPE_EXPRESSION { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType PATH_TYPE_OR_PROPERTY_EXPRESSION { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType PI_ATTRIBUTE { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType PROPERTY_ATTRIBUTE { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType PROPERTY_ATTRIBUTE_VALUE { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType PROPERTY_DECL { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType PROPERTY_ELEMENT { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType QUOTED_VALUE { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType RELATIVE_SOURCE_ATTRIBUTE { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType RELATIVE_SOURCE_ELEMENT { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType RELATIVE_SOURCE_MARKUP { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType RESOURCE_DECL { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType RESOURCE_KEY_ATTRIBUTE { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType RESOURCE_MARKUP { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType RESOURCE_USAGE { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType SHARED_ATTRIBUTE { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType SOURCE_ATTRIBUTE { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType SOURCE_ELEMENT { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType STATIC_ELEMENT { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType STATIC_EXPRESSION { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType STATIC_MARKUP { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType STATIC_MEMBER_ATTRIBUTE { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType STATIC_NAMESPACE_ALIAS { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType STATIC_RESOURCE_DECL_ELEMENT { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType STATIC_TYPE_OR_NAMESPACE { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType STRING_VALUE { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType STYLE_DECL { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType TARGET_NAME_ATTRIBUTE { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType TEMPLATE_BINDING_MARKUP { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType TEMPLATE_FIELD_DECL { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType TEXT_VALUE { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType TYPE_ARGUMENTS_ATTRIBUTE { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType TYPE_ATTRIBUTE { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType TYPE_DECL { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType TYPE_EXPRESSION_RANK_SPECIFIER { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType TYPE_EXPRESSION_TYPE_ARGUMENTS { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType TYPE_NAME_ATTRIBUTE { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType XCLASS_ATTRIBUTE { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType XDATA_ELEMENT { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType XKEY_ATTRIBUTE { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType XKEY_ELEMENT { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType XML_DATA_PROVIDER_DECL { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType XML_LANG_ATTRIBUTE { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType XML_SPACE_ATTRIBUTE { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType XNAME_ATTRIBUTE { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType XNAME_IN_CLASS_OR_RESOURCE_ATTRIBUTE { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType XPATH_VALUE { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType XREFERENCE_ELEMENT { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType XREFERENCE_MARKUP { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType XSUBCLASS_ATTRIBUTE { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType XTYPE_ELEMENT { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType XTYPE_MARKUP { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType XUID_ATTRIBUTE { get; }
        public abstract class XamlCompositeNodeType : JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType
        {
            protected XamlCompositeNodeType(string s, JetBrains.ReSharper.Psi.Xml.Tree.XmlElementTypes types, int index) { }
            public JetBrains.ReSharper.Psi.Xaml.Parsing.XamlTokenTypes XamlTokenTypes { get; }
        }
    }
    public class XamlSyntaxErrorType : JetBrains.ReSharper.Psi.Xml.Tree.XmlSyntaxErrorType
    {
        public static readonly JetBrains.ReSharper.Psi.Xml.Tree.XmlSyntaxErrorType BRACE_EXPECTED;
        public static readonly JetBrains.ReSharper.Psi.Xml.Tree.XmlSyntaxErrorType BRACKET_EXPECTED;
        public static readonly JetBrains.ReSharper.Psi.Xml.Tree.XmlSyntaxErrorType COLON_EXPECTED;
        public static readonly JetBrains.ReSharper.Psi.Xml.Tree.XmlSyntaxErrorType COMMA_EXPECTED;
        public static readonly JetBrains.ReSharper.Psi.Xml.Tree.XmlSyntaxErrorType DOT_EXPECTED;
        public static readonly JetBrains.ReSharper.Psi.Xml.Tree.XmlSyntaxErrorType DOUBLE_QUOTE_EXPECTED;
        public static readonly JetBrains.ReSharper.Psi.Xml.Tree.XmlSyntaxErrorType MARKUP_NAME_EXPECTED;
        public static readonly JetBrains.ReSharper.Psi.Xml.Tree.XmlSyntaxErrorType MISMATCHED_BRACE;
        public static readonly JetBrains.ReSharper.Psi.Xml.Tree.XmlSyntaxErrorType PARAMETER_EXPECTED;
        public static readonly JetBrains.ReSharper.Psi.Xml.Tree.XmlSyntaxErrorType PARAMETER_VALUE_EXPECTED;
        public static readonly JetBrains.ReSharper.Psi.Xml.Tree.XmlSyntaxErrorType PARENTH_EXPECTED;
        public static readonly JetBrains.ReSharper.Psi.Xml.Tree.XmlSyntaxErrorType PROPERTY_EXPECTED;
        public static readonly JetBrains.ReSharper.Psi.Xml.Tree.XmlSyntaxErrorType PROPERTY_NAME_EXPECTED;
        public static readonly JetBrains.ReSharper.Psi.Xml.Tree.XmlSyntaxErrorType SINGLE_QUOTE_EXPECTED;
        public static readonly JetBrains.ReSharper.Psi.Xml.Tree.XmlSyntaxErrorType STATIC_MEMBER_EXPECTED;
        public static readonly JetBrains.ReSharper.Psi.Xml.Tree.XmlSyntaxErrorType TEXT_AFTER_MARKUP_NOT_ALLOWED;
        public static readonly JetBrains.ReSharper.Psi.Xml.Tree.XmlSyntaxErrorType TYPE_EXPECTED;
        public static readonly JetBrains.ReSharper.Psi.Xml.Tree.XmlSyntaxErrorType TYPE_NAME_EXPECTED;
        public static readonly JetBrains.ReSharper.Psi.Xml.Tree.XmlSyntaxErrorType UNFINISHED_STRING;
        public static readonly JetBrains.ReSharper.Psi.Xml.Tree.XmlSyntaxErrorType UNMATCHED_ATTACHED_PROPERTY;
        public static readonly JetBrains.ReSharper.Psi.Xml.Tree.XmlSyntaxErrorType UNMATCHED_MARKUP;
        public static readonly JetBrains.ReSharper.Psi.Xml.Tree.XmlSyntaxErrorType VALUE_EXPECTED;
        protected XamlSyntaxErrorType(string description) { }
    }
    public class static XamlTypeDeclarationExtensions
    {
        public static bool IsApplicationDefinition([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Xaml.Tree.IXamlTypeDeclaration typeDeclaration) { }
    }
}
namespace JetBrains.ReSharper.Psi.Xaml.Tree.MarkupExtensions
{
    
    public interface IAttachedPropertyExpression : JetBrains.ReSharper.Psi.Resolve.IQualifier, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xaml.Tree.MarkupExtensions.IMarkupAttributeValue, JetBrains.ReSharper.Psi.Xaml.Tree.MarkupExtensions.IMarkupValue, JetBrains.ReSharper.Psi.Xaml.Tree.MarkupExtensions.IPathValue, JetBrains.ReSharper.Psi.Xaml.Tree.MarkupExtensions.IPropertyExpression, JetBrains.ReSharper.Psi.Xaml.Tree.MarkupExtensions.IQualifierExpression, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken LParenth { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Xaml.Tree.MarkupExtensions.ISimplePropertyExpression Property { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken RParenth { get; }
    }
    public interface IAttributeListMarkupValue : JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xaml.Tree.MarkupExtensions.IMarkupValue, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<JetBrains.ReSharper.Psi.Xaml.Tree.MarkupExtensions.IMarkupAttribute> Attributes { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Xaml.Tree.MarkupExtensions.IMarkupAttribute AddAttributeAfter([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xaml.Tree.MarkupExtensions.IMarkupAttribute child, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Xaml.Tree.MarkupExtensions.IMarkupAttribute anchor);
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Xaml.Tree.MarkupExtensions.IMarkupAttribute AddAttributeBefore([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xaml.Tree.MarkupExtensions.IMarkupAttribute child, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Xaml.Tree.MarkupExtensions.IMarkupAttribute anchor);
        void RemoveAttribute([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xaml.Tree.MarkupExtensions.IMarkupAttribute attribute);
    }
    public interface IBindingMarkup : JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xaml.Impl.Tree.ITypeUsage, JetBrains.ReSharper.Psi.Xaml.Tree.IBinding, JetBrains.ReSharper.Psi.Xaml.Tree.MarkupExtensions.IMarkup, JetBrains.ReSharper.Psi.Xaml.Tree.MarkupExtensions.IMarkupAttributeValue, JetBrains.ReSharper.Psi.Xaml.Tree.MarkupExtensions.IMarkupValue, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode { }
    public interface ICastedIndexerParameter : JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xaml.Tree.MarkupExtensions.IIndexerParameter, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken LParenth { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Xaml.Tree.MarkupExtensions.IIndexerParameter Parameter { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken RParenth { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Xaml.Tree.MarkupExtensions.ITypeExpression TypeExpression { get; }
    }
    public interface IEscapedValue : JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xaml.Tree.MarkupExtensions.IMarkupAttributeValue, JetBrains.ReSharper.Psi.Xaml.Tree.MarkupExtensions.IMarkupValue, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode { }
    public interface IEscapedValueNode : JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken EscapeToken { get; }
    }
    public interface IIdentifierMarkupValue : JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xaml.Tree.MarkupExtensions.IMarkupAttributeValue, JetBrains.ReSharper.Psi.Xaml.Tree.MarkupExtensions.IMarkupValue, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Xaml.Tree.IXamlIdentifier Identifier { get; }
    }
    public interface IIndexerExpression : JetBrains.ReSharper.Psi.Resolve.IQualifier, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xaml.Tree.MarkupExtensions.IMarkupAttributeValue, JetBrains.ReSharper.Psi.Xaml.Tree.MarkupExtensions.IMarkupValue, JetBrains.ReSharper.Psi.Xaml.Tree.MarkupExtensions.IPathValue, JetBrains.ReSharper.Psi.Xaml.Tree.MarkupExtensions.IQualifierExpression, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Xaml.Tree.MarkupExtensions.IIndexerParameterList ParameterList { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Xaml.Tree.MarkupExtensions.IQualifierExpression Qualifier { get; }
    }
    public interface IIndexerExpressionNode : JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken Dot { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken LBracket { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken RBracket { get; }
    }
    public interface IIndexerParameter : JetBrains.ReSharper.Psi.Tree.ITreeNode { }
    public interface IIndexerParameterList : JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<JetBrains.ReSharper.Psi.Xaml.Tree.MarkupExtensions.IIndexerParameter> Parameters { get; }
    }
    public interface IMarkup : JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xaml.Impl.Tree.ITypeUsage, JetBrains.ReSharper.Psi.Xaml.Tree.MarkupExtensions.IMarkupAttributeValue, JetBrains.ReSharper.Psi.Xaml.Tree.MarkupExtensions.IMarkupValue, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken LBrace { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        string Name { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Xaml.Tree.IXamlIdentifier NameNode { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken RBrace { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Xaml.Tree.MarkupExtensions.IMarkupValue Value { get; }
    }
    public interface IMarkupAttribute : JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xaml.Impl.Tree.ITypeMemberUsage, JetBrains.ReSharper.Psi.Xaml.Impl.Tree.ITypeUsage, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken Eq { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        string Name { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Xaml.Tree.IXamlIdentifier NameNode { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Xaml.Tree.MarkupExtensions.IMarkupAttributeValue Value { get; }
    }
    public interface IMarkupAttributeValue : JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xaml.Tree.MarkupExtensions.IMarkupValue, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode { }
    public interface IMarkupValue : JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode { }
    public interface INamespaceAliaceQualifier : JetBrains.ReSharper.Psi.Resolve.IQualifier, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xaml.Tree.MarkupExtensions.IQualifierExpression
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Xaml.Tree.IXamlIdentifier NamespaceAliace { get; }
    }
    public interface INestedTypeExpression : JetBrains.ReSharper.Psi.Resolve.IQualifier, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xaml.Impl.Tree.ITypeUsage, JetBrains.ReSharper.Psi.Xaml.Tree.MarkupExtensions.IMarkupAttributeValue, JetBrains.ReSharper.Psi.Xaml.Tree.MarkupExtensions.IMarkupValue, JetBrains.ReSharper.Psi.Xaml.Tree.MarkupExtensions.IQualifierExpression, JetBrains.ReSharper.Psi.Xaml.Tree.MarkupExtensions.ITypeExpressionBase, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Xaml.Tree.IXamlIdentifier NestedType { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken Plus { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Xaml.Tree.MarkupExtensions.ITypeExpressionBase Qualifier { get; }
    }
    public interface INumberValue : JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xaml.Tree.MarkupExtensions.IMarkupAttributeValue, JetBrains.ReSharper.Psi.Xaml.Tree.MarkupExtensions.IMarkupValue, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken NumberToken { get; }
    }
    public interface IPathValue : JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xaml.Tree.MarkupExtensions.IMarkupAttributeValue, JetBrains.ReSharper.Psi.Xaml.Tree.MarkupExtensions.IMarkupValue, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IType GetExpressionType();
    }
    public interface IPropertyExpression : JetBrains.ReSharper.Psi.Resolve.IQualifier, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xaml.Tree.MarkupExtensions.IMarkupAttributeValue, JetBrains.ReSharper.Psi.Xaml.Tree.MarkupExtensions.IMarkupValue, JetBrains.ReSharper.Psi.Xaml.Tree.MarkupExtensions.IPathValue, JetBrains.ReSharper.Psi.Xaml.Tree.MarkupExtensions.IQualifierExpression, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken Dot { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Xaml.Tree.MarkupExtensions.IQualifierExpression Qualifier { get; }
    }
    public interface IQualifierExpression : JetBrains.ReSharper.Psi.Resolve.IQualifier, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Resolve.IReference PropertyReference { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IType GetExpressionType();
    }
    public interface IQuotedValue : JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xaml.Tree.MarkupExtensions.IMarkupAttributeValue, JetBrains.ReSharper.Psi.Xaml.Tree.MarkupExtensions.IMarkupValue, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken LQuote { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken RQuote { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Xaml.Tree.MarkupExtensions.IMarkupAttributeValue Value { get; }
    }
    public interface IResourceMarkup : JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xaml.Impl.Tree.ITypeUsage, JetBrains.ReSharper.Psi.Xaml.Tree.IResourceUsage, JetBrains.ReSharper.Psi.Xaml.Tree.MarkupExtensions.IMarkup, JetBrains.ReSharper.Psi.Xaml.Tree.MarkupExtensions.IMarkupAttributeValue, JetBrains.ReSharper.Psi.Xaml.Tree.MarkupExtensions.IMarkupValue, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode { }
    public interface ISimplePropertyExpression : JetBrains.ReSharper.Psi.Resolve.IQualifier, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xaml.Tree.MarkupExtensions.IMarkupAttributeValue, JetBrains.ReSharper.Psi.Xaml.Tree.MarkupExtensions.IMarkupValue, JetBrains.ReSharper.Psi.Xaml.Tree.MarkupExtensions.IPathValue, JetBrains.ReSharper.Psi.Xaml.Tree.MarkupExtensions.IPropertyExpression, JetBrains.ReSharper.Psi.Xaml.Tree.MarkupExtensions.IQualifierExpression, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Xaml.Tree.IXamlIdentifier Property { get; }
    }
    public interface ISourceTraversalValue : JetBrains.ReSharper.Psi.Resolve.IQualifier, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xaml.Tree.MarkupExtensions.IMarkupAttributeValue, JetBrains.ReSharper.Psi.Xaml.Tree.MarkupExtensions.IMarkupValue, JetBrains.ReSharper.Psi.Xaml.Tree.MarkupExtensions.IPathValue, JetBrains.ReSharper.Psi.Xaml.Tree.MarkupExtensions.IQualifierExpression, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Xaml.Tree.MarkupExtensions.IQualifierExpression Qualifier { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken Slash { get; }
    }
    public interface IStaticExpression : JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xaml.Impl.Tree.ITypeMemberUsage, JetBrains.ReSharper.Psi.Xaml.Impl.Tree.ITypeUsage, JetBrains.ReSharper.Psi.Xaml.Tree.MarkupExtensions.IMarkupAttributeValue, JetBrains.ReSharper.Psi.Xaml.Tree.MarkupExtensions.IMarkupValue, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Xaml.Tree.IXamlIdentifier MemberName { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Xaml.Tree.MarkupExtensions.ITypeExpressionBase Qualifier { get; }
    }
    public interface IStaticExpressionNode : JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken Dot { get; }
    }
    public interface IStringValue : JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xaml.Tree.MarkupExtensions.IMarkupAttributeValue, JetBrains.ReSharper.Psi.Xaml.Tree.MarkupExtensions.IMarkupValue, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken StringToken { get; }
        JetBrains.ReSharper.Psi.TreeTextRange UnquotedRange { get; }
    }
    public interface ITextValue : JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xaml.Tree.MarkupExtensions.IMarkupAttributeValue, JetBrains.ReSharper.Psi.Xaml.Tree.MarkupExtensions.IMarkupValue, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken TextToken { get; }
    }
    public interface ITypeExpression : JetBrains.ReSharper.Psi.Resolve.IQualifier, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xaml.Impl.Tree.ITypeUsage, JetBrains.ReSharper.Psi.Xaml.Tree.MarkupExtensions.IMarkupAttributeValue, JetBrains.ReSharper.Psi.Xaml.Tree.MarkupExtensions.IMarkupValue, JetBrains.ReSharper.Psi.Xaml.Tree.MarkupExtensions.IQualifierExpression, JetBrains.ReSharper.Psi.Xaml.Tree.MarkupExtensions.ITypeExpressionBase, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken DotOrColon { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Xaml.Tree.MarkupExtensions.IQualifierExpression Qualifier { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Xaml.Tree.IXamlIdentifier TypeName { get; }
    }
    public interface ITypeExpressionBase : JetBrains.ReSharper.Psi.Resolve.IQualifier, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xaml.Impl.Tree.ITypeUsage, JetBrains.ReSharper.Psi.Xaml.Tree.MarkupExtensions.IMarkupAttributeValue, JetBrains.ReSharper.Psi.Xaml.Tree.MarkupExtensions.IMarkupValue, JetBrains.ReSharper.Psi.Xaml.Tree.MarkupExtensions.IQualifierExpression, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<JetBrains.ReSharper.Psi.Xaml.Tree.MarkupExtensions.ITypeExpressionRankSpecifier> RankSpecifiers { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Xaml.Tree.MarkupExtensions.ITypeExpressionTypeArguments TypeArguments { get; }
    }
    public interface ITypeExpressionRankSpecifier : JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken LBracket { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken RBracket { get; }
    }
    public interface ITypeExpressionTypeArguments : JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken> Commas { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken LParenth { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken RParenth { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Xaml.Tree.MarkupExtensions.ITypeExpressionBase> TypeArguments { get; }
    }
    public interface ITypeOrNamespaceExpression : JetBrains.ReSharper.Psi.Resolve.IQualifier, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xaml.Tree.MarkupExtensions.IMarkupAttributeValue, JetBrains.ReSharper.Psi.Xaml.Tree.MarkupExtensions.IMarkupValue, JetBrains.ReSharper.Psi.Xaml.Tree.MarkupExtensions.IQualifierExpression, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken DotOrColon { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Xaml.Tree.MarkupExtensions.IQualifierExpression Qualifier { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Xaml.Tree.IXamlIdentifier TypeOrNamespace { get; }
    }
    public interface IXPathValue : JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xaml.Tree.MarkupExtensions.IMarkupAttributeValue, JetBrains.ReSharper.Psi.Xaml.Tree.MarkupExtensions.IMarkupValue, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode { }
    public interface IXReferenceMarkup : JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xaml.Impl.Tree.ITypeUsage, JetBrains.ReSharper.Psi.Xaml.Tree.IElementNameUsage, JetBrains.ReSharper.Psi.Xaml.Tree.IXReference, JetBrains.ReSharper.Psi.Xaml.Tree.MarkupExtensions.IMarkup, JetBrains.ReSharper.Psi.Xaml.Tree.MarkupExtensions.IMarkupAttributeValue, JetBrains.ReSharper.Psi.Xaml.Tree.MarkupExtensions.IMarkupValue, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode { }
    public class static MarkupAttributeExtensions
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Psi.Xaml.Tree.MarkupExtensions.IMarkupAttributeValue GetUnquotedValue([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Xaml.Tree.MarkupExtensions.IMarkupAttribute markupAttribute) { }
    }
    public class static MarkupAttributeListValueNavigator
    {
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        public static JetBrains.ReSharper.Psi.Xaml.Tree.MarkupExtensions.IAttributeListMarkupValue GetByAttribute(JetBrains.ReSharper.Psi.Xaml.Tree.MarkupExtensions.IMarkupAttribute attribute) { }
    }
    public class static MarkupAttributeNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.Xaml.Tree.MarkupExtensions.IMarkupAttribute GetByUnquotedValue(JetBrains.ReSharper.Psi.Xaml.Tree.MarkupExtensions.IMarkupAttributeValue value) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.Xaml.Tree.MarkupExtensions.IMarkupAttribute GetByValue(JetBrains.ReSharper.Psi.Xaml.Tree.MarkupExtensions.IMarkupAttributeValue value) { }
    }
    public class static MarkupExtensions
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Psi.Xaml.Tree.MarkupExtensions.IMarkupAttribute GetAttribute([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Xaml.Tree.MarkupExtensions.IMarkup markup, [JetBrains.Annotations.NotNullAttribute()] System.Predicate<JetBrains.ReSharper.Psi.Xaml.Tree.MarkupExtensions.IMarkupAttribute> accept) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Psi.Xaml.Tree.MarkupExtensions.IMarkupAttribute GetAttribute([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Xaml.Tree.MarkupExtensions.IMarkup markup, string attributeName) { }
        public static JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<JetBrains.ReSharper.Psi.Xaml.Tree.MarkupExtensions.IMarkupAttribute> GetAttributes([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Xaml.Tree.MarkupExtensions.IMarkup markup) { }
    }
    public class static MarkupNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.Xaml.Tree.MarkupExtensions.IMarkup GetByAttribute(JetBrains.ReSharper.Psi.Xaml.Tree.MarkupExtensions.IMarkupAttribute attribute) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.Xaml.Tree.MarkupExtensions.IMarkup GetByValue(JetBrains.ReSharper.Psi.Xaml.Tree.MarkupExtensions.IMarkupValue value) { }
    }
}
namespace JetBrains.ReSharper.Psi.Xaml
{
    
    [JetBrains.ReSharper.Psi.LanguageDefinitionAttribute("XAML")]
    public class XamlLanguage : JetBrains.ReSharper.Psi.Xml.XmlLanguage
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static readonly JetBrains.ReSharper.Psi.Xaml.XamlLanguage Instance;
        public const string Name = "XAML";
        protected XamlLanguage([JetBrains.Annotations.NotNullAttribute()] string name) { }
        protected XamlLanguage([JetBrains.Annotations.NotNullAttribute()] string name, [JetBrains.Annotations.NotNullAttribute()] string presentableName) { }
    }
}