[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]

namespace JetBrains.ReSharper.Psi.Web.WinRT.AppxManifest
{
    
    public class static AppxManifestExtensions
    {
        public static string GetAppxManifestIdentity([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ProjectModel.IProject project) { }
    }
    [JetBrains.ReSharper.Psi.LanguageDefinitionAttribute("AppxManifest")]
    public class AppxManifestLanguage : JetBrains.ReSharper.Psi.Xml.XmlLanguage
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static readonly JetBrains.ReSharper.Psi.Web.WinRT.AppxManifest.AppxManifestLanguage Instance;
        public const string Name = "AppxManifest";
        public AppxManifestLanguage() { }
        protected AppxManifestLanguage([JetBrains.Annotations.NotNullAttribute()] string name) { }
        protected AppxManifestLanguage([JetBrains.Annotations.NotNullAttribute()] string name, [JetBrains.Annotations.NotNullAttribute()] string presentableName) { }
    }
    [JetBrains.ProjectModel.ProjectFileTypeAttribute(typeof(JetBrains.ProjectModel.AppxManifestProjectFileType))]
    public class AppxManifestProjectFileLanguageService : JetBrains.ReSharper.Psi.Xml.XmlProjectFileLanguageService
    {
        public AppxManifestProjectFileLanguageService(JetBrains.ProjectModel.AppxManifestProjectFileType appxManifestProjectFileType) { }
        public override JetBrains.ReSharper.Psi.PsiLanguageType GetPsiLanguageType(JetBrains.ProjectModel.IProjectFile projectFile) { }
        public override JetBrains.ReSharper.Psi.PsiLanguageType GetPsiLanguageType(JetBrains.ProjectModel.ProjectFileType languageType) { }
    }
}
namespace JetBrains.ReSharper.Psi.Web.WinRT.AppxManifest.Tree
{
    
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.Web.WinRT.AppxManifest.AppxManifestLanguage))]
    public class AppxManifestElementTypes : JetBrains.ReSharper.Psi.Xml.Tree.XmlElementTypes
    {
        public readonly JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType IDENTITY_TAG;
        public readonly JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType IDENTITY_TAG_NAME_ATTRIBUTE;
        public readonly JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType IDENTITY_TAG_VERSION_ATTRIBUTE;
        public readonly JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType PACKAGE_TAG;
        public AppxManifestElementTypes(JetBrains.ReSharper.Psi.Parsing.XmlTokenTypes xmlTokenTypes) { }
    }
    public class AppxManifestFile : JetBrains.ReSharper.Psi.Xml.Impl.Tree.XmlFile, JetBrains.ReSharper.Psi.Tree.IFile, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.WinRT.AppxManifest.Tree.IAppxManifestFile, JetBrains.ReSharper.Psi.Web.WinRT.AppxManifest.Tree.IIdentityProvider, JetBrains.ReSharper.Psi.Xml.Tree.IXmlDocumentNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlFile, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagContainer, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        public AppxManifestFile(JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType elementType) { }
        public string Identity { get; }
    }
    public class static AppxManifestKeywords
    {
        public const string IDENTITY_TAG = "Identity";
        public const string IDENTITY_TAG_NAME_ATTRIBUTE = "Name";
        public const string IDENTITY_TAG_VERSION_ATTRIBUTE = "Version";
        public const string PACKAGE_TAG = "Package";
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.Web.WinRT.AppxManifest.AppxManifestLanguage))]
    public sealed class AppxManifestTreeNodeFactory : JetBrains.ReSharper.Psi.Xml.Parsing.XmlTreeNodeFactory
    {
        public AppxManifestTreeNodeFactory([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Web.WinRT.AppxManifest.AppxManifestLanguage languageType, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Parsing.XmlTokenTypes tokenTypes, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Web.WinRT.AppxManifest.Tree.AppxManifestElementTypes elementTypes) { }
        public override JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttribute CreateAttribute(JetBrains.ReSharper.Psi.Xml.Tree.IXmlIdentifier nameIdentifier, JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttributeContainer attributeContainer, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagContainer parentTag, JetBrains.ReSharper.Psi.Xml.Parsing.IXmlElementFactoryContext context) { }
        public override JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag CreateRootTag(JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagHeader header, JetBrains.ReSharper.Psi.Xml.Parsing.IXmlElementFactoryContext context) { }
        public override JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag CreateTag(JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagHeader header, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag parentTag, JetBrains.ReSharper.Psi.Xml.Parsing.IXmlElementFactoryContext context) { }
    }
    public interface IAppxManifestFile : JetBrains.ReSharper.Psi.Tree.IFile, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.WinRT.AppxManifest.Tree.IIdentityProvider, JetBrains.ReSharper.Psi.Xml.Tree.IXmlDocumentNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlFile, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagContainer, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode { }
    public interface IAppxManifestTag : JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagContainer, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode { }
    public class IdentityNameAttribute : JetBrains.ReSharper.Psi.Xml.Impl.Tree.XmlAttribute, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.WinRT.AppxManifest.Tree.IIdentityNameAttribute, JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttribute, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        public IdentityNameAttribute(JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType type) { }
    }
    public class IdentityTag : JetBrains.ReSharper.Psi.Xml.Impl.Tree.XmlTag, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.WinRT.AppxManifest.Tree.IAppxManifestTag, JetBrains.ReSharper.Psi.Web.WinRT.AppxManifest.Tree.IIdentityProvider, JetBrains.ReSharper.Psi.Web.WinRT.AppxManifest.Tree.IIdentityTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagContainer, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        public IdentityTag(JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType type) { }
        public string Identity { get; }
    }
    public class IdentityVersionAttribute : JetBrains.ReSharper.Psi.Xml.Impl.Tree.XmlAttribute, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.WinRT.AppxManifest.Tree.IIdentityVersionAttribute, JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttribute, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        public IdentityVersionAttribute(JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType type) { }
    }
    public interface IIdentityNameAttribute : JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttribute, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode { }
    public interface IIdentityProvider
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        string Identity { get; }
    }
    public interface IIdentityTag : JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.WinRT.AppxManifest.Tree.IAppxManifestTag, JetBrains.ReSharper.Psi.Web.WinRT.AppxManifest.Tree.IIdentityProvider, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagContainer, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode { }
    public interface IIdentityVersionAttribute : JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttribute, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode { }
    public interface IPackageTag : JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.WinRT.AppxManifest.Tree.IAppxManifestTag, JetBrains.ReSharper.Psi.Web.WinRT.AppxManifest.Tree.IIdentityProvider, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagContainer, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode { }
    public class PackageTag : JetBrains.ReSharper.Psi.Xml.Impl.Tree.XmlTag, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.WinRT.AppxManifest.Tree.IAppxManifestTag, JetBrains.ReSharper.Psi.Web.WinRT.AppxManifest.Tree.IIdentityProvider, JetBrains.ReSharper.Psi.Web.WinRT.AppxManifest.Tree.IPackageTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagContainer, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        public PackageTag(JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType type) { }
        public string Identity { get; }
    }
}
namespace JetBrains.ReSharper.Psi.Web.WinRT.Html
{
    
    public class HtmlWinRTControlReference : JetBrains.ReSharper.Psi.Impl.Shared.References.QualifiableReferenceWithinElement<JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode, JetBrains.ReSharper.Psi.Html.Tree.IHtmlToken>, JetBrains.ReSharper.Psi.Html.References.IHtmlCompleteableReference, JetBrains.ReSharper.Psi.Resolve.ICompleteableReference, JetBrains.ReSharper.Psi.Resolve.IQualifier, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.Util.IUserDataHolder
    {
        public HtmlWinRTControlReference(JetBrains.ReSharper.Psi.Html.Tree.IHtmlAttributeValue htmlAttributeValue, JetBrains.ReSharper.Psi.Html.Tree.IHtmlToken valueToken, JetBrains.ReSharper.Psi.TreeTextRange rangeWithin, JetBrains.ReSharper.Psi.Resolve.IQualifier qualifier) { }
        public bool Resolved { get; }
        protected override JetBrains.ReSharper.Psi.Resolve.IReference BindToInternal(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution) { }
        public System.Collections.Generic.IEnumerable<string> GetFullCompletionList() { }
        public JetBrains.ReSharper.Psi.Resolve.QualifierKind GetKind() { }
        public override JetBrains.ReSharper.Psi.ITypeElement GetQualifierTypeElement() { }
        public override JetBrains.ReSharper.Psi.Resolve.Staticness GetStaticness() { }
        public JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetSymbolTable(JetBrains.ReSharper.Psi.Resolve.SymbolTableMode mode) { }
    }
    [JetBrains.ReSharper.Psi.PsiComponentAttribute()]
    public class HtmlWinRTDeclaredElementsProvider : JetBrains.ReSharper.Psi.Html.Impl.Html.HtmlDeclaredElementsProvider
    {
        public HtmlWinRTDeclaredElementsProvider(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ProjectModel.ISolution solution) { }
        public override bool IsApplicable(JetBrains.ReSharper.Psi.IPsiSourceFile file) { }
    }
    public class static HtmlWinRTUtils
    {
        public const string DataWinControlAttribute = "data-win-control";
        public const string DataWinOptionsAttribute = "data-win-options";
        public const string WinControlType = "%WinControl";
    }
    [JetBrains.ReSharper.Psi.Resolve.ReferenceProviderFactoryAttribute()]
    public class HtmlWinRTWinControlReferenceProvider : JetBrains.ReSharper.Psi.Html.Impl.References.HtmlAttributeValueReferenceFactoryBase<JetBrains.ReSharper.Psi.Html.Html.IHtmlDeclaredElementTypes, JetBrains.ProjectModel.HtmlProjectFileType>
    {
        public HtmlWinRTWinControlReferenceProvider(JetBrains.ReSharper.Psi.Html.Html.IHtmlDeclaredElementTypes htmlDeclaredElementTypes) { }
        protected override bool CanHaveReference(JetBrains.ReSharper.Psi.Html.Impl.References.HtmlAttributeValueEntry entry, System.Collections.Generic.IEnumerable<string> names) { }
        protected override JetBrains.ReSharper.Psi.Resolve.IReference[] CreateReferences(JetBrains.ReSharper.Psi.Html.Impl.References.HtmlAttributeValueEntry entry) { }
        public override bool IsApplicable(JetBrains.ReSharper.Psi.Html.Impl.References.HtmlAttributeValueEntry entry) { }
        public override bool IsApplicableToFile(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, JetBrains.ReSharper.Psi.Tree.IFile file) { }
    }
}
namespace JetBrains.ReSharper.Psi.Web.WinRT.JavaScript
{
    
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class JsonInWinRTExpectedTypeProvider : JetBrains.ReSharper.Psi.JavaScript.LanguageImpl.IObjectLiteralExpectedTypeProvider
    {
        public JetBrains.ReSharper.Psi.JavaScript.Resolve.IJavaScriptType GetJsType(JetBrains.ReSharper.Psi.JavaScript.Tree.IObjectLiteral objectLiteral, JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsLocalElementResolver context) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Resolve.ISymbolFilter> GetPropertyFilters(JetBrains.ReSharper.Psi.JavaScript.Tree.IObjectLiteral objectLiteral, JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.JavaScriptResolveContext resolveContext) { }
    }
}
namespace JetBrains.ReSharper.Psi.Web.WinRT.Json
{
    
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class JsonPsiProvider : JetBrains.ReSharper.Psi.Impl.Shared.InjectedPsi.IndependentInjectedPsiProvider
    {
        public override JetBrains.ReSharper.Psi.PsiLanguageType GeneratedLanguage { get; }
        protected override bool CanBeGeneratedNode(JetBrains.ReSharper.Psi.Tree.ITreeNode node) { }
        protected override bool CanBeOriginalNode(JetBrains.ReSharper.Psi.Tree.ITreeNode node) { }
        public override JetBrains.ReSharper.Psi.ExtensionsAPI.IInjectedFileContext CreateInjectedFileContext(JetBrains.ReSharper.Psi.Tree.IFile originalFile) { }
        public override JetBrains.ReSharper.Psi.ExtensionsAPI.IInjectedNodeContext CreateInjectedNodeContext(JetBrains.ReSharper.Psi.ExtensionsAPI.IInjectedFileContext fileContext, JetBrains.ReSharper.Psi.Tree.ITreeNode originalNode) { }
        public override bool IsApplicable(JetBrains.ReSharper.Psi.PsiLanguageType originalLanguage) { }
        public override bool IsApplicableToNode(JetBrains.ReSharper.Psi.Tree.ITreeNode node, JetBrains.ReSharper.Psi.ExtensionsAPI.IInjectedFileContext context) { }
        public override void Regenerate(JetBrains.ReSharper.Psi.Impl.Shared.InjectedPsi.IndependentInjectedNodeContext nodeContext) { }
    }
}
namespace JetBrains.ReSharper.Psi.Web.WinRT.Paths
{
    
    public class SdkPathReference<TOwner, TToken> : JetBrains.ReSharper.Psi.Web.References.PathReferenceBase<TOwner, TToken>, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IQualifiableReferenceBase, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IQualifiableReferenceWithGlobalSymbolTable, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IReferenceWithGlobalSymbolTable, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IReferenceWithQualifier, JetBrains.ReSharper.Psi.JavaScript.WinRT.Resolve.ISdkPathReference, JetBrains.ReSharper.Psi.Resolve.ICompleteableReference, JetBrains.ReSharper.Psi.Resolve.IPathReference, JetBrains.ReSharper.Psi.Resolve.IQualifier, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.ReSharper.Psi.Web.References.IPathQualifier, JetBrains.Util.IUserDataHolder
        where TOwner : JetBrains.ReSharper.Psi.Tree.ITreeNode
        where TToken :  class, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        public SdkPathReference(JetBrains.ReSharper.Psi.IPsiServices psiServices, TOwner owner, TToken token, JetBrains.ReSharper.Psi.TreeTextRange rangeWithin) { }
        public bool AllowedOustideOfSite { get; }
        public override bool CanBeMappedOrIgnored { get; }
        public JetBrains.Util.FileSystemPath Path { get; }
        public bool Resolved { get; }
        protected override JetBrains.ReSharper.Psi.Resolve.IReference BindToInternal(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution) { }
        protected override JetBrains.ReSharper.Psi.Resolve.ISymbolFilter[] GetCompletionFilters() { }
        public JetBrains.ReSharper.Psi.Resolve.QualifierKind GetKind() { }
        public override JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetReferenceSymbolTable(bool useReferenceName) { }
        public JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetSymbolTable(JetBrains.ReSharper.Psi.Resolve.SymbolTableMode mode) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class SdkReferenceContentFilePathResolver : JetBrains.ReSharper.Psi.Resolve.IUriPathResolver
    {
        public SdkReferenceContentFilePathResolver(JetBrains.ReSharper.Psi.IPsiServices psiServices) { }
        public JetBrains.ReSharper.Psi.Resolve.IPathReference[] GetPathReferences<TOwner, TToken>(System.Uri uri, TOwner owner, TToken token, JetBrains.ReSharper.Psi.Resolve.IQualifier baseQualifier, System.Func<TOwner, JetBrains.ReSharper.Psi.Resolve.IQualifier, TToken, JetBrains.ReSharper.Psi.TreeTextRange, JetBrains.ReSharper.Psi.Resolve.IPathReference> createFolderReferenceDelegate, System.Func<TOwner, JetBrains.ReSharper.Psi.Resolve.IQualifier, TToken, JetBrains.ReSharper.Psi.TreeTextRange, JetBrains.ReSharper.Psi.Resolve.IPathReference> createFileReferenceDelegate, string stringValue, int valueStartOffset)
            where TOwner : JetBrains.ReSharper.Psi.Tree.ITreeNode
            where TToken :  class, JetBrains.ReSharper.Psi.Tree.ITreeNode { }
    }
    public class SdkReferenceDeclaredElement : JetBrains.ReSharper.Psi.Impl.Paths.ModuleDeclaredElement, JetBrains.ReSharper.Psi.IDeclaredElement, JetBrains.ReSharper.Psi.IPathDeclaredElement
    {
        public SdkReferenceDeclaredElement([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IProject project, [JetBrains.Annotations.NotNullAttribute()] string name) { }
        public JetBrains.Util.FileSystemPath Path { get; }
        public JetBrains.ProjectModel.IProjectItem GetProjectItem() { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class WebWinRTVirtualPathProvider : JetBrains.ReSharper.Psi.Paths.IVirtualFilesProvider, JetBrains.ReSharper.Psi.Paths.IVirtualFoldersProvider
    {
        public WebWinRTVirtualPathProvider(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ReSharper.Psi.Paths.IVirtualPathsService virtualPathsService) { }
        public System.Collections.Generic.IEnumerable<JetBrains.Util.FileSystemPath> GetAbsolutePathsToVirtualFiles(JetBrains.ProjectModel.IProject project) { }
        public System.Collections.Generic.IEnumerable<JetBrains.Util.FileSystemPath> GetAbsolutePathsToVirtualFolders(JetBrains.ProjectModel.IProject project) { }
        public JetBrains.ProjectModel.IProjectFile GetProjectFileByVirtualPath(JetBrains.ProjectModel.IProject project, JetBrains.Util.FileSystemPath virtualPath) { }
        public JetBrains.ProjectModel.IProjectFolder GetProjectFolderByVirtualPath(JetBrains.ProjectModel.IProject project, JetBrains.Util.FileSystemPath virtualPath) { }
        public JetBrains.ReSharper.Psi.IPsiSourceFile GetPsiSourceFileByVirtualPath(JetBrains.ProjectModel.IProject project, JetBrains.Util.FileSystemPath virtualPath) { }
    }
}