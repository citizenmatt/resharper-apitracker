[assembly: JetBrains.UI.Icons.CompiledIcons.CompiledIconsPackAttribute(IconNames=new string[] {
        "AspContentPlaceholder",
        "AspNet",
        "AspTag",
        "AspUserControl",
        "AspMasterPage",
        "AspContent"}, IconPackResourceIdentification="JetBrains.ReSharper.Psi.Asp;component/resources/PsiAspThemedIcons/ThemedIcons.Psi" +
    "Asp.Generated.Xaml")]
[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]
[assembly: System.Windows.Markup.XmlnsDefinitionAttribute("urn:shemas-jetbrains-com:ui-application-icons-psi-asp", "JetBrains.ReSharper.Psi.Asp.Resources")]

namespace JetBrains.ReSharper.Psi.Asp
{
    
    public class AspCodeBehindSecondaryLexerProcess : JetBrains.ReSharper.Psi.Web.WebCodeBehindSecondaryLexerProcess
    {
        public AspCodeBehindSecondaryLexerProcess(JetBrains.ProjectModel.AspProjectFileType projectFileType, JetBrains.ReSharper.Psi.Web.Util.WebPsiLanguageUtil webPsiLanguageUtil, JetBrains.ReSharper.Psi.Parsing.MixedLexer parentLexer, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile = null) { }
        public override JetBrains.ReSharper.Psi.Parsing.ILexer TryCreateCodeBehindLexer(JetBrains.ReSharper.Psi.Parsing.ILexer baseLexer) { }
    }
    public class static AspExtensions
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Psi.Asp.Tree.IAspFile GetAspFile([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Asp.Tree.IAspFile> GetAspFiles([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.ReSharper.Psi.IType GetAspType([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Psi.ITypeElement GetAspTypeElement([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Psi.ITypeElement GetCodeBehindTypeElement([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
    }
    [JetBrains.ReSharper.Psi.LanguageDefinitionAttribute("ASPX")]
    public class AspLanguage : JetBrains.ReSharper.Psi.Html.HtmlLanguage
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static readonly JetBrains.ReSharper.Psi.Asp.AspLanguage Instance;
        public const string Name = "ASPX";
        protected AspLanguage([JetBrains.Annotations.NotNullAttribute()] string name, [JetBrains.Annotations.NotNullAttribute()] string presentableName) { }
        protected AspLanguage([JetBrains.Annotations.NotNullAttribute()] string name) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.Asp.AspLanguage))]
    public class AspLanguageService : JetBrains.ReSharper.Psi.Html.HtmlLanguageService
    {
        public AspLanguageService(JetBrains.ReSharper.Psi.Asp.AspLanguage aspLanguage, JetBrains.ReSharper.Psi.IConstantValueService constantValueService, JetBrains.ReSharper.Psi.Asp.Parsing.IAspTokenNodeTypes tokenTypes, JetBrains.ReSharper.Psi.Html.IHtmlCodeFormatter codeFormatter, JetBrains.ReSharper.Psi.Html.Parsing.IWebTreeBuilderFactory webTreeBuilderFactory) { }
        public override JetBrains.ReSharper.Psi.ExtensionsAPI.Caches2.ILanguageCacheProvider CacheProvider { get; }
        public override JetBrains.ReSharper.Psi.Parsing.ILexer CreateFilteringLexer(JetBrains.ReSharper.Psi.Parsing.ILexer lexer) { }
        public override JetBrains.ReSharper.Psi.ExtensionsAPI.IReferenceContextCodec CreateReferenceContextCodec() { }
        public override JetBrains.ReSharper.Psi.Parsing.ILexerFactory GetPrimaryLexerFactory() { }
        public override JetBrains.ReSharper.Psi.ReferenceAccessType GetReferenceAccessType(JetBrains.ReSharper.Psi.IDeclaredElement target, JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
    }
    [JetBrains.ProjectModel.ProjectFileTypeAttribute(typeof(JetBrains.ProjectModel.AspProjectFileType))]
    public class AspProjectFileLanguageService : JetBrains.ReSharper.Psi.Html.HtmlProjectFileLanguageService, JetBrains.ReSharper.Psi.IProjectFileLanguageService, JetBrains.ReSharper.Psi.Web.IWebProjectFileLanguageService
    {
        public AspProjectFileLanguageService(JetBrains.ProjectModel.AspProjectFileType aspProjectFileType, JetBrains.ReSharper.Psi.ILanguageManager languageManager, JetBrains.ReSharper.Psi.Web.Util.WebPsiLanguageUtil webPsiLanguageUtil) { }
        public override JetBrains.UI.Icons.IconId Icon { get; }
        protected override JetBrains.ReSharper.Psi.PsiLanguageType PsiLanguageType { get; }
        public static JetBrains.ReSharper.Psi.Web.AspNetVersion GetAspNetVersion([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Modules.IPsiModule psiModule) { }
        public JetBrains.ReSharper.Psi.PsiLanguageType GetCodeBehindLanguage(JetBrains.Text.IBuffer buffer) { }
        public override JetBrains.ReSharper.Psi.IPsiSourceFileProperties GetPsiProperties(JetBrains.ProjectModel.IProjectFile projectFile, JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
    }
    [JetBrains.ReSharper.Psi.LanguageDefinitionAttribute("Skin")]
    public class SkinLanguage : JetBrains.ReSharper.Psi.Asp.AspLanguage
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static readonly JetBrains.ReSharper.Psi.Asp.SkinLanguage Instance;
        public const string Name = "Skin";
        protected SkinLanguage([JetBrains.Annotations.NotNullAttribute()] string name, [JetBrains.Annotations.NotNullAttribute()] string presentableName) { }
        protected SkinLanguage([JetBrains.Annotations.NotNullAttribute()] string name) { }
    }
    [JetBrains.ProjectModel.ProjectFileTypeAttribute(typeof(JetBrains.ProjectModel.SkinProjectFileType))]
    public class SkinProjectFileLanguageService : JetBrains.ReSharper.Psi.Asp.AspProjectFileLanguageService
    {
        public SkinProjectFileLanguageService(JetBrains.ProjectModel.AspProjectFileType aspProjectFileType, JetBrains.ReSharper.Psi.ILanguageManager languageManager, JetBrains.ReSharper.Psi.Web.Util.WebPsiLanguageUtil webPsiLanguageUtil) { }
        protected override JetBrains.ReSharper.Psi.PsiLanguageType PsiLanguageType { get; }
    }
}
namespace JetBrains.ReSharper.Psi.Asp.Controls
{
    
    public abstract class DevExpressSupportManager
    {
        public static JetBrains.ReSharper.Psi.Asp.Controls.DevExpressSupportManager GetInstance(JetBrains.ProjectModel.ISolution solution) { }
        public static JetBrains.ReSharper.Psi.Asp.Controls.DevExpressSupportManager GetInstance(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static string GetTypeNamePropertyName([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.ITypeMember typeMember) { }
        protected abstract string GetTypeNamePropertyNameInternal(JetBrains.ReSharper.Psi.ITypeMember typeMember);
        public static bool IsTypeNameProperty([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.ITypeMember typeMember, out string targetNamespace, out string baseType) { }
        protected abstract bool IsTypeNamePropertyInternal(JetBrains.ReSharper.Psi.ITypeMember typeMember, out string targetNamespace, out string baseType);
    }
}
namespace JetBrains.ReSharper.Psi.Asp.Directives
{
    
    public interface IAspDeclaredElementsCache : JetBrains.ReSharper.Psi.Web.Directives.IWebDeclaredElementsCache
    {
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Web.Directives.IWebDirectiveEnumAttributeValueType DynamicMasterPageFileValueType { get; }
    }
}
namespace JetBrains.ReSharper.Psi.Asp.Html
{
    
    public class static AspContainerFieldExtensions
    {
        public static System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Asp.Html.IAspContainerField> GetRelatedContainerFields([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Asp.Html.IAspContainerField containerField) { }
    }
    public class static AspDeclaredElementTypesUtils
    {
        public static JetBrains.ReSharper.Psi.Asp.Html.IAspDeclaredElementTypes GetInstance(JetBrains.ProjectModel.ISolution solution) { }
        public static bool IsDataBoundControl([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Asp.Tree.IAspTag tag, JetBrains.ReSharper.Psi.Modules.IPsiModule psiModule, JetBrains.ReSharper.Psi.Asp.Html.IAspDeclaredElementTypes aspDeclaredElementTypes, out JetBrains.ReSharper.Psi.IType itemType) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Psi.ITypeMember IsInheritedTypeMember([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, [JetBrains.Annotations.NotNullAttribute()] System.Func<JetBrains.ReSharper.Psi.IDeclaredType> getContainingType, params string[] memberNames) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Psi.ITypeMember IsTypeMember([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, [JetBrains.Annotations.NotNullAttribute()] System.Func<JetBrains.ReSharper.Psi.IDeclaredType> getContainingType, params string[] memberNames) { }
    }
    [JetBrains.ReSharper.Psi.PsiIconManagerExtensionAttribute()]
    public class AspPsiIconManagerExtension : JetBrains.ReSharper.Psi.IPsiIconManagerExtension
    {
        public JetBrains.UI.Icons.IconId GetImageId(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, JetBrains.ReSharper.Psi.PsiLanguageType languageType, out bool canApplyExtensions) { }
    }
    public class static HtmlControlExtensions
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.ReSharper.Psi.Html.Tree.IHtmlTagContainer GetSearchScope([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Asp.Html.IHtmlControl control) { }
    }
    public interface IAspBindingExpressionField : JetBrains.ReSharper.Psi.IAccessRightsOwner, JetBrains.ReSharper.Psi.IAttributesOwner, JetBrains.ReSharper.Psi.IAttributesSet, JetBrains.ReSharper.Psi.IClrDeclaredElement, JetBrains.ReSharper.Psi.IConstantValueOwner, JetBrains.ReSharper.Psi.IDeclaredElement, JetBrains.ReSharper.Psi.IField, JetBrains.ReSharper.Psi.IModifiersOwner, JetBrains.ReSharper.Psi.ITypeMember, JetBrains.ReSharper.Psi.ITypeOwner, JetBrains.ReSharper.Psi.IXmlDocIdOwner
    {
        string Name { get; }
        JetBrains.ReSharper.Psi.Asp.Tree.IAspDataBinderExpression GetDeclaration();
    }
    public interface IAspContainerField : JetBrains.ReSharper.Psi.Asp.Html.IAspBindingExpressionField, JetBrains.ReSharper.Psi.IAccessRightsOwner, JetBrains.ReSharper.Psi.IAttributesOwner, JetBrains.ReSharper.Psi.IAttributesSet, JetBrains.ReSharper.Psi.IClrDeclaredElement, JetBrains.ReSharper.Psi.IConstantValueOwner, JetBrains.ReSharper.Psi.IDeclaredElement, JetBrains.ReSharper.Psi.IField, JetBrains.ReSharper.Psi.IModifiersOwner, JetBrains.ReSharper.Psi.ITypeMember, JetBrains.ReSharper.Psi.ITypeOwner, JetBrains.ReSharper.Psi.IXmlDocIdOwner { }
    public interface IAspDeclaredElementTypes : JetBrains.ReSharper.Psi.Html.Html.IHtmlDeclaredElementTypesBase
    {
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Html.Html.IHtmlAttributeDeclaredElement MetaResourceKeyAttribute { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Html.Html.IHtmlAttributeDeclaredElement RunatAttribute { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IDeclaredType GetApplication(JetBrains.ReSharper.Psi.Modules.IPsiModule psiModule, JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext context);
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetAspAttributesSymbolTable();
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IDeclaredType GetASPxObjectContainer(JetBrains.ReSharper.Psi.Modules.IPsiModule psiModule, JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext context);
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IDeclaredType GetAssociatedControlConverter(JetBrains.ReSharper.Psi.Modules.IPsiModule psiModule, JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext context);
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IDeclaredType GetAsyncPostBackTrigger(JetBrains.ReSharper.Psi.Modules.IPsiModule psiModule, JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext context);
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IDeclaredType GetAudioObjectProperties(JetBrains.ReSharper.Psi.Modules.IPsiModule psiModule, JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext context);
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IDeclaredType GetBoundField(JetBrains.ReSharper.Psi.Modules.IPsiModule psiModule, JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext context);
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IDeclaredType GetContent(JetBrains.ReSharper.Psi.Modules.IPsiModule psiModule, JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext context);
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IDeclaredType GetContentBuilderInternal(JetBrains.ReSharper.Psi.Modules.IPsiModule psiModule, JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext context);
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IDeclaredType GetContentPlaceHolder(JetBrains.ReSharper.Psi.Modules.IPsiModule psiModule, JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext context);
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IDeclaredType GetControl(JetBrains.ReSharper.Psi.Modules.IPsiModule psiModule, JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext context);
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IDeclaredType GetControlIDConverter(JetBrains.ReSharper.Psi.Modules.IPsiModule psiModule, JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext context);
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IDeclaredType GetDataBoundControl(JetBrains.ReSharper.Psi.Modules.IPsiModule psiModule, JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext context);
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IDeclaredType GetDataSet(JetBrains.ReSharper.Psi.Modules.IPsiModule psiModule, JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext context);
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IDeclaredType GetDataSourceControl(JetBrains.ReSharper.Psi.Modules.IPsiModule psiModule, JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext context);
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IDeclaredType GetDataTable(JetBrains.ReSharper.Psi.Modules.IPsiModule psiModule, JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext context);
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IDeclaredType GetDataView(JetBrains.ReSharper.Psi.Modules.IPsiModule psiModule, JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext context);
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IDeclaredType GetDefaultProfile(JetBrains.ReSharper.Psi.Modules.IPsiModule psiModule, JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext context);
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IDeclaredType GetEventHandler(JetBrains.ReSharper.Psi.Modules.IPsiModule psiModule, JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext context);
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IDeclaredType GetFlashObjectProperties(JetBrains.ReSharper.Psi.Modules.IPsiModule psiModule, JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext context);
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IDeclaredType GetHtmlControl(JetBrains.ReSharper.Psi.Modules.IPsiModule psiModule, JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext context);
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IDeclaredType GetHtmlHeadControlBuilder(JetBrains.ReSharper.Psi.Modules.IPsiModule psiModule, JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext context);
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IDeclaredType GetHtmlImage(JetBrains.ReSharper.Psi.Modules.IPsiModule psiModule, JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext context);
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IDeclaredType GetHtmlInputControl(JetBrains.ReSharper.Psi.Modules.IPsiModule psiModule, JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext context);
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IDeclaredType GetIAttributeAccessor(JetBrains.ReSharper.Psi.Modules.IPsiModule psiModule, JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext context);
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IDeclaredType GetIDataItemContainer(JetBrains.ReSharper.Psi.Modules.IPsiModule psiModule, JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext context);
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IDeclaredType GetImage(JetBrains.ReSharper.Psi.Modules.IPsiModule psiModule, JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext context);
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IDeclaredType GetImageObjectProperties(JetBrains.ReSharper.Psi.Modules.IPsiModule psiModule, JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext context);
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IDeclaredType GetINamingContainer(JetBrains.ReSharper.Psi.Modules.IPsiModule psiModule, JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext context);
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IDeclaredType GetINonBindingContainer(JetBrains.ReSharper.Psi.Modules.IPsiModule psiModule, JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext context);
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IDeclaredType GetIStateManager(JetBrains.ReSharper.Psi.Modules.IPsiModule psiModule, JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext context);
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IDeclaredType GetITemplate(JetBrains.ReSharper.Psi.Modules.IPsiModule psiModule, JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext context);
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IDeclaredType GetMasterPage(JetBrains.ReSharper.Psi.Modules.IPsiModule psiModule, JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext context);
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IDeclaredType GetObjectDataSource(JetBrains.ReSharper.Psi.Modules.IPsiModule psiModule, JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext context);
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IDeclaredType GetObjectType(JetBrains.ReSharper.Psi.Modules.IPsiModule psiModule, JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext context);
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IDeclaredType GetPage(JetBrains.ReSharper.Psi.Modules.IPsiModule psiModule, JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext context);
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IDeclaredType GetParameter(JetBrains.ReSharper.Psi.Modules.IPsiModule psiModule, JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext context);
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IDeclaredType GetPlaceHolder(JetBrains.ReSharper.Psi.Modules.IPsiModule psiModule, JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext context);
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IDeclaredType GetProfileCommon(JetBrains.ReSharper.Psi.Modules.IPsiModule psiModule, JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext context);
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IDeclaredType GetQuickTimeObjectProperties(JetBrains.ReSharper.Psi.Modules.IPsiModule psiModule, JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext context);
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IDeclaredType GetRepeaterControl(JetBrains.ReSharper.Psi.Modules.IPsiModule psiModule, JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext context);
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IDeclaredType GetScriptReference(JetBrains.ReSharper.Psi.Modules.IPsiModule psiModule, JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext context);
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IDeclaredType GetScriptReferenceBase(JetBrains.ReSharper.Psi.Modules.IPsiModule psiModule, JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext context);
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IDeclaredType GetUserControl(JetBrains.ReSharper.Psi.Modules.IPsiModule psiModule, JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext context);
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IDeclaredType GetUserControlControlBuilder(JetBrains.ReSharper.Psi.Modules.IPsiModule psiModule, JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext context);
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IDeclaredType GetValidatedControlConverter(JetBrains.ReSharper.Psi.Modules.IPsiModule psiModule, JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext context);
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IDeclaredType GetVideoObjectProperties(JetBrains.ReSharper.Psi.Modules.IPsiModule psiModule, JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext context);
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IDeclaredType GetWebControl(JetBrains.ReSharper.Psi.Modules.IPsiModule psiModule, JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext context);
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IDeclaredType GetWizardStepControlBuilder(JetBrains.ReSharper.Psi.Modules.IPsiModule psiModule, JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext context);
    }
    public interface IAspField : JetBrains.ReSharper.Psi.Asp.Html.IHtmlControl, JetBrains.ReSharper.Psi.IAccessRightsOwner, JetBrains.ReSharper.Psi.IAttributesOwner, JetBrains.ReSharper.Psi.IAttributesSet, JetBrains.ReSharper.Psi.IClrDeclaredElement, JetBrains.ReSharper.Psi.IConstantValueOwner, JetBrains.ReSharper.Psi.IDeclaredElement, JetBrains.ReSharper.Psi.IField, JetBrains.ReSharper.Psi.IModifiersOwner, JetBrains.ReSharper.Psi.ITypeMember, JetBrains.ReSharper.Psi.ITypeOwner, JetBrains.ReSharper.Psi.IXmlDocIdOwner { }
    public interface IHtmlControl : JetBrains.ReSharper.Psi.IClrDeclaredElement, JetBrains.ReSharper.Psi.IDeclaredElement, JetBrains.ReSharper.Psi.ITypeOwner
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Asp.Tree.IAspTag GetTag();
    }
}
namespace JetBrains.ReSharper.Psi.Asp.Impl
{
    
    [JetBrains.ReSharper.Psi.ExtensionsAPI.GeneratedDocumentServiceAttribute(typeof(JetBrains.ProjectModel.AspProjectFileType))]
    public sealed class AspCodeBehindGeneratedDocumentService : JetBrains.ReSharper.Psi.Web.Generation.GeneratedDocumentServiceBase, JetBrains.ReSharper.Psi.ExtensionsAPI.IGeneratedDocumentService, JetBrains.ReSharper.Psi.Web.Generation.IConstrainedGeneratedDocumentService
    {
        public AspCodeBehindGeneratedDocumentService(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ProjectModel.AspProjectFileType aspProjectFileType, JetBrains.ReSharper.Psi.ILanguageManager languageManager, JetBrains.ReSharper.Psi.Asp.Impl.UniqueIdGenerator uniqueGenerator, JetBrains.ReSharper.Psi.ExtensionsAPI.FileDependency dependency, JetBrains.ReSharper.Psi.Web.Util.WebPsiLanguageUtil webPsiLanguageUtil) { }
        public JetBrains.ReSharper.Psi.ExtensionsAPI.FileDependency Dependencies { get; }
        public override JetBrains.ReSharper.Psi.ExtensionsAPI.ISecondaryLexingProcess CreateSecondaryLexingService(JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Psi.Parsing.MixedLexer mixedLexer, JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile = null) { }
        public override JetBrains.ReSharper.Psi.ExtensionsAPI.ISecondaryDocumentGenerationResult Generate(JetBrains.ReSharper.Psi.Files.PrimaryFileModificationInfo modificationInfo) { }
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.PsiLanguageType> GetSecondaryPsiLanguageTypes(JetBrains.ProjectModel.IProject project) { }
        public bool HasProjectedInnerElements(JetBrains.ReSharper.Psi.Tree.ITreeNode node) { }
        public bool HasProjectedOuterElements(JetBrains.ReSharper.Psi.Tree.ITreeNode node) { }
        public override bool IsSecondaryPsiLanguageType(JetBrains.ProjectModel.IProject project, JetBrains.ReSharper.Psi.PsiLanguageType language) { }
        public override JetBrains.ReSharper.Psi.Parsing.ILexerFactory LexerFactoryWithPreprocessor(JetBrains.ReSharper.Psi.PsiLanguageType primaryLanguage) { }
        protected override bool ReparseOriginalFile(JetBrains.ReSharper.Psi.TreeTextRange treeTextRange, string newText, JetBrains.ReSharper.Psi.Impl.Shared.RangeTranslatorWithGeneratedRangeMap rangeTranslator) { }
        protected override bool TransactionActionIsUnrelated(JetBrains.ReSharper.Psi.Transactions.IPsiTransactionAction transactionAction) { }
        public override JetBrains.DocumentModel.DocumentRange TryFindNavigationRangeInPrimaryDocument(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
    }
    public class static AspKeywords
    {
        public const string APPLICATION = "Application";
        public const string APPLICATION_INSTANCE_PROPERTY = "ApplicationInstance";
        public const string ASP_NAMESPACE_NAME = "ASP";
        public const string ASSEMBLY = "Assembly";
        public const string ASSEMBLY_ATTRIBUTE = "Assembly";
        public const string AUDIO = "Audio";
        public const string AUTO_EVENT_WIREUP_ATTRIBUTE = "AutoEventWireUp";
        public const string BIND = "Bind";
        public const string CACHED_PREFIX = "cached";
        public const string CLASS_ATTRIBUTE = "class";
        public const string CLASS_NAME_ATTRIBUTE = "ClassName";
        public const string CLASSNAME = "ClassName";
        public const string CODE_BEHIND_ATTRIBUTE = "CodeBehind";
        public const string CODE_FILE_ATTRIBUTE = "CodeFile";
        public const string CODE_FILE_BASE_CLASS_ATTRIBUTE = "CodeFileBaseClass";
        public const string CONTENT_PLACEHOLDER_ID_ATTRIBUTE = "ContentPlaceHolderID";
        public const string CONTROL = "Control";
        public const string CONTROL_ID = "ControlID";
        public const string DATA_FIELD = "DataField";
        public const string DATA_SOURCE_ID = "DataSourceID";
        public const string DYNAMIC_MASTER_PAGE_FILE_ATTRIBUTE = "DynamicMasterPageFile";
        public const string EVENT_PREFIX = "On";
        public const string EXPLICIT_ATTRIBUTE = "Explicit";
        public const string FLASH = "Flash";
        public const string HIC_TYPE = "Type";
        public const string IMAGE = "Image";
        public const string IMPLEMENTS = "Implements";
        public const string IMPORT = "Import";
        public const string INHERITS_ATTRIBUTE = "Inherits";
        public const string INTERFACE_ATTRIBUTE = "Interface";
        public const string ITEM_TYPE_FIELD = "ItemType";
        public const string LANGUAGE_ATTRIBUTE = "Language";
        public const string MASTER = "Master";
        public const string MASTER_PAGE_FILE_ATTRIBUTE = "MasterPageFile";
        public const string MASTER_PROPERTY = "Master";
        public const string MASTERTYPE = "MasterType";
        public const string META_COLON_PREFIX = "meta:";
        public const string META_PREFIX = "meta";
        public const string META_RESOURCE_KEY = "meta:resourcekey";
        public const string META_RESOURCEKEY_ATTRIBUTE = "meta:resourcekey";
        public const string NAME_ATTRIBUTE = "name";
        public const string NAMESPACE_ATTRIBUTE = "Namespace";
        public const string OBJECT_PROPERTIES = "ObjectProperties";
        public const string OBJECT_TYPE = "ObjectType";
        public const string OBJECT_URL = "ObjectUrl";
        public const string ODS_CONFLICT_DETECTION = "ConflictDetection";
        public const string ODS_DATA_OBJECT_TYPE_NAME = "DataObjectTypeName";
        public const string ODS_DELETE_METHOD = "DeleteMethod";
        public const string ODS_ENABLE_PAGING = "EnablePaging";
        public const string ODS_INSERT_METHOD = "InsertMethod";
        public const string ODS_MAXIMUM_ROWS_PARAMETER_NAME = "MaximumRowsParameterName";
        public const string ODS_MAXIMUM_ROWS_PARAMETER_NAME_DEFAULT_VALUE = "maximumRows";
        public const string ODS_SELECT_METHOD = "SelectMethod";
        public const string ODS_SORT_PARAMETER_NAME = "SortParameterName";
        public const string ODS_START_ROW_INDEX_PARAMETER_NAME = "StartRowIndexParameterName";
        public const string ODS_START_ROW_INDEX_PARAMETER_NAME_DEFAULT_VALUE = "startRowIndex";
        public const string ODS_TYPE_NAME = "TypeName";
        public const string ODS_UPDATE_METHOD = "UpdateMethod";
        public const string OUTPUTCACHE = "OutputCache";
        public const string PAGE = "Page";
        public const string PARAM_NAME = "Name";
        public const string PARAM_TYPE = "Type";
        public const string PATH = "Path";
        public const string PREVIOUS_PAGE_FILE_ATTRIBUTE = "PreviousPage";
        public const string PREVIOUS_PAGE_PROPERTY = "PreviousPage";
        public const string PREVIOUS_PAGE_TYPE = "PreviousPageType";
        public const string PROFILE_PROPERTY = "Profile";
        public const string QUICK_TIME = "QucikTime";
        public const string REFERENCE = "Reference";
        public const string REGISTER = "Register";
        public const string RESOURCE_KEY = "resourcekey";
        public const string SCOPE_APPINSTANCE_VALUE = "appInstance";
        public const string SCOPE_ATTRIBUTE = "scope";
        public const string SERVER_VALUE = "server";
        public const string SKIN_ID_ATTRIBUTE = "SkinID";
        public const string STRICT_ATTRIBUTE = "Strict";
        public const string STYLE_SHEET_THEME_ATTRIBUTE = "StyleSheetTheme";
        public const string TAG_NAME_ATTRIBUTE = "TagName";
        public const string TAG_PREFIX_ATTRIBUTE = "TagPrefix";
        public const string THEME_ATTRIBUTE = "Theme";
        public const string TYPE_NAME = "TypeName";
        public const string URL_SUFFIX = "Url";
        public const string VIDEO = "Video";
        public const string VIRTUAL_PATH = "VirtualPath";
        public const string WEB_CONTROLS_NAMESPACE = "System.Web.UI.WebControls";
        [JetBrains.Annotations.NotNullAttribute()]
        public static string GetOdsBeforeEventName(string methodPropertyName) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static string GetOdsMethodName(string parametersPropertyName) { }
        public static System.Collections.Generic.IEnumerable<string> GetOdsMethods() { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static string GetOdsParametersPropertyName(string methodPropertyName) { }
        public static bool IsClassDeclarationDirectiveName(string directiveName) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.Asp.AspLanguage))]
    public class AspNamedArgumentsCacheProvider : JetBrains.ReSharper.Psi.Impl.Caches2.INamedArgumentsCacheProvider
    {
        public bool CanBuildArgumentsFast(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
        public string[] GetPossibleNamedArguments(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class PureUniqueIdGenerator : JetBrains.ReSharper.Psi.Asp.Impl.UniqueIdGenerator
    {
        public const string PREFIX = "__TEMP_";
        public override string GenerateId() { }
        public static bool IsGeneratedString(string name) { }
        public static string ReplaceAllGeneratedIds(string text) { }
    }
    public abstract class UniqueIdGenerator
    {
        public abstract string GenerateId();
        public virtual void Reset() { }
    }
}
namespace JetBrains.ReSharper.Psi.Asp.Impl.CodeStyle
{
    
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.Asp.AspLanguage))]
    public class AspCodeFormatter : JetBrains.ReSharper.Psi.Html.Impl.CodeStyle.HtmlCodeFormatter
    {
        public AspCodeFormatter(JetBrains.ReSharper.Psi.Asp.AspLanguage language, JetBrains.ReSharper.Psi.Html.Parsing.IHtmlTokenNodeTypes tokenNodeTypes, JetBrains.Application.Settings.ISettingsStore settingsStore, JetBrains.Application.Settings.ISettingsOptimization settingsOptimization) { }
        protected override void DoIndent(JetBrains.ReSharper.Psi.Impl.CodeStyle.CodeFormattingContext context, JetBrains.ReSharper.Psi.Html.CodeStyle.HtmlCodeFormattingSettings settings, JetBrains.ReSharper.Psi.CodeStyle.CodeFormatProfile profile, JetBrains.Application.Progress.IProgressIndicator progress) { }
    }
    public class AspIndentingVisitor : JetBrains.ReSharper.Psi.Asp.Tree.AspTreeVisitor<JetBrains.ReSharper.Psi.Impl.CodeStyle.FormattingStageContext, string>
    {
        public AspIndentingVisitor(JetBrains.ReSharper.Psi.Html.Impl.CodeStyle.HtmlIndentingVisitor baseVisitor) { }
        public JetBrains.ReSharper.Psi.Html.Impl.CodeStyle.HtmlIndentingVisitor BaseVisitor { get; }
    }
    public interface IAspCustomFormattingInfoProvider
    {
        JetBrains.Util.Pair<JetBrains.ReSharper.Psi.TreeTextRange, JetBrains.ReSharper.Psi.Tree.ITreeNode> GetBlockInfo(JetBrains.ReSharper.Psi.Tree.ITreeNode token);
    }
}
namespace JetBrains.ReSharper.Psi.Asp.Impl.Controls
{
    
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class DevExpressSupportManagerImpl : JetBrains.ReSharper.Psi.Asp.Controls.DevExpressSupportManager, System.IDisposable
    {
        public DevExpressSupportManagerImpl() { }
        public void Dispose() { }
        protected override string GetTypeNamePropertyNameInternal(JetBrains.ReSharper.Psi.ITypeMember typeMember) { }
        protected override bool IsTypeNamePropertyInternal(JetBrains.ReSharper.Psi.ITypeMember typeMember, out string targetNamespace, out string baseType) { }
    }
}
namespace JetBrains.ReSharper.Psi.Asp.Impl.CustomHandlers
{
    
    public abstract class AspCustomModificationHandler : JetBrains.ReSharper.Psi.Web.CodeBehindSupport.CustomModificationHandler<JetBrains.ReSharper.Psi.Asp.Tree.IAspRenderBlock, JetBrains.ReSharper.Psi.Asp.Tree.IAspDirective>
    {
        protected const string ALIASES_IN_ASP_ARE_NOT_SUPPORTED = "ASP.NET namespace aliases are not supported by R#";
        protected AspCustomModificationHandler(JetBrains.ReSharper.Psi.ILanguageManager languageManager, JetBrains.ReSharper.Psi.Search.SearchDomainFactory searchDomainFactory) { }
        protected override void AddSuperClassDirectiveToOriginalFile(JetBrains.ReSharper.Psi.Tree.IFile originalFile, JetBrains.ReSharper.Psi.Tree.ITreeNode anchor, JetBrains.ReSharper.Psi.Tree.ITreeNode superClassGeneratedNode) { }
        protected bool CanRemoveAspDirectiveThatProducedUsing(JetBrains.ReSharper.Psi.Tree.ITreeNode importedNamespace) { }
        public bool CanUseAliases() { }
        protected override JetBrains.ReSharper.Psi.Asp.Tree.IAspRenderBlock CreateInlineCodeBlock(string text, JetBrains.ReSharper.Psi.Tree.ITreeNode anchor) { }
        protected override JetBrains.ReSharper.Psi.TreeTextRange CreateTypeMemberNode(JetBrains.ReSharper.Psi.Tree.IFile originalFile, string text, JetBrains.ReSharper.Psi.Tree.ITreeNode first, JetBrains.ReSharper.Psi.Tree.ITreeNode last) { }
        protected override JetBrains.ReSharper.Psi.TreeTextRange CreateUsingNode(bool before, JetBrains.ReSharper.Psi.Asp.Tree.IAspDirective anchor, JetBrains.ReSharper.Psi.Tree.ITreeNode usingDirective, JetBrains.ReSharper.Psi.Tree.IFile originalFile) { }
        protected void DeleteOriginalStatementBlock(JetBrains.ReSharper.Psi.Impl.Shared.RangeTranslatorWithGeneratedRangeMap rangeTranslator, JetBrains.ReSharper.Psi.Tree.ITreeNode statementBlock) { }
        protected override JetBrains.ReSharper.Psi.TreeTextRange GetCodeTreeTextRange(JetBrains.ReSharper.Psi.Asp.Tree.IAspRenderBlock codeBlock) { }
        protected override JetBrains.ReSharper.Psi.TreeTextRange GetExistingTypeMembersRange(JetBrains.ReSharper.Psi.Tree.IFile originalFile) { }
        protected abstract string GetQualifiedNameOfImport(JetBrains.ReSharper.Psi.Tree.ITreeNode usingDirective);
        protected override JetBrains.ReSharper.Psi.Tree.ITreeNode GetSuperClassNodeFromOriginalFile(JetBrains.ReSharper.Psi.Tree.IFile originalFile) { }
        protected void HandleRemoveStatementsRange(JetBrains.ReSharper.Psi.ITreeRange removedGeneratedTreeRange) { }
        public void HandleRemoveStatementsRange(JetBrains.ReSharper.Psi.IPsiServices psiServices, JetBrains.ReSharper.Psi.ITreeRange treeRange, System.Action action) { }
        protected override void ModifyAnchorForAddingStatements(bool before, ref JetBrains.ReSharper.Psi.Tree.ITreeNode anchor) { }
        protected abstract void PrepareRangeForInsertingIntoTypeMemberNode(JetBrains.ReSharper.Psi.Tree.ITreeNode first, JetBrains.ReSharper.Psi.Tree.ITreeNode last);
        protected override void RemoveUsingNode(JetBrains.ReSharper.Psi.Tree.IFile originalFile, JetBrains.ReSharper.Psi.Asp.Tree.IAspDirective directiveInOriginalFile) { }
    }
}
namespace JetBrains.ReSharper.Psi.Asp.Impl.Directives
{
    
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class AspDeclaredElementsCache : JetBrains.ReSharper.Psi.Web.Impl.Directives.WebDeclaredElementsCache, JetBrains.ReSharper.Psi.Asp.Directives.IAspDeclaredElementsCache, JetBrains.ReSharper.Psi.Web.Directives.IWebDeclaredElementsCache
    {
        public AspDeclaredElementsCache(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ReSharper.Psi.IPsiServices psiServices) { }
        public JetBrains.ReSharper.Psi.Web.Directives.IWebDirectiveEnumAttributeValueType DynamicMasterPageFileValueType { get; }
    }
}
namespace JetBrains.ReSharper.Psi.Asp.Impl.Generate
{
    
    public abstract class AspCodeBehindGenerator
    {
        protected const string DataBindingConversionMethod = "__ReSharper_Data_Bind__Conversion";
        protected const string DataBindingMethodPrefix = "__ReSharper_Data_Bind__";
        protected readonly JetBrains.ReSharper.Psi.Asp.Impl.UniqueIdGenerator IdGenerator;
        protected const string RenderMethod = "__ReSharper_Render";
        protected AspCodeBehindGenerator(JetBrains.ReSharper.Psi.PsiLanguageType language, JetBrains.ReSharper.Psi.Asp.Impl.UniqueIdGenerator idGenerator) { }
        protected abstract bool AppendLineInRenderBlock { get; }
        protected abstract string DelimiterComment { get; }
        protected abstract string EndOfExpression { get; }
        protected abstract bool IsCaseSensitive { get; }
        protected abstract string LeadingComment { get; }
        protected abstract string TrailerComment { get; }
        protected abstract string UsingFormatString { get; }
        protected JetBrains.ReSharper.Psi.Web.Generation.GenerationResults CreateGenerationResults(System.Text.StringBuilder text, JetBrains.ReSharper.Psi.Impl.Shared.IGeneratedRangeMap generatedRangeMap = null) { }
        protected JetBrains.ReSharper.Psi.Web.Generation.GenerationResults CreateGenerationResults(string text, JetBrains.ReSharper.Psi.Impl.Shared.IGeneratedRangeMap generatedRangeMap = null) { }
        protected abstract JetBrains.ReSharper.Psi.Web.Generation.GenerationResults GenerateClassDeclEnd(bool closeNamespace);
        protected abstract JetBrains.ReSharper.Psi.Web.Generation.GenerationResults GenerateClassDeclStart(string className, JetBrains.ReSharper.Psi.Impl.Shared.ElementRange<JetBrains.ReSharper.Psi.Html.Tree.IHtmlToken> classNameRange, JetBrains.ReSharper.Psi.Asp.Tree.IAspFile aspFile);
        protected abstract JetBrains.ReSharper.Psi.Web.Generation.GenerationResults GenerateDataBindingMethodEnd();
        protected abstract JetBrains.ReSharper.Psi.Web.Generation.GenerationResults GenerateDataBindingMethodStart(string name);
        protected abstract JetBrains.ReSharper.Psi.Web.Generation.GenerationResults GenerateDataBindingVariable(string name, System.Collections.Generic.IEnumerable<string> fieldNames);
        public JetBrains.ReSharper.Psi.Web.Generation.GenerationResults GenerateFile(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, JetBrains.ReSharper.Psi.Asp.Tree.IAspFile aspFile) { }
        protected abstract JetBrains.ReSharper.Psi.Web.Generation.GenerationResults GenerateMethodEnd();
        protected abstract JetBrains.ReSharper.Psi.Web.Generation.GenerationResults GenerateNamespaceStart(string namespaceName, JetBrains.ReSharper.Psi.Impl.Shared.ElementRange<JetBrains.ReSharper.Psi.Html.Tree.IHtmlToken> namespaceNameRange, JetBrains.ReSharper.Psi.Asp.Tree.IAspFile aspFile);
        protected abstract JetBrains.ReSharper.Psi.Web.Generation.GenerationResults GenerateScriptBody(JetBrains.ReSharper.Psi.Asp.Tree.IAspScriptTag scriptTag, JetBrains.ReSharper.Psi.Asp.Tree.IAspFile aspFile);
        protected JetBrains.ReSharper.Psi.Web.Generation.GenerationResults GenerateScriptBody(JetBrains.ReSharper.Psi.Asp.Tree.IAspScriptTag script, string prefix, string suffix, JetBrains.ReSharper.Psi.Asp.Tree.IAspFile aspFile) { }
        protected abstract JetBrains.ReSharper.Psi.Web.Generation.GenerationResults GenerateSyntheticMethodStart();
        protected virtual JetBrains.ReSharper.Psi.Web.Generation.GenerationResults GenerateUsingDirectives(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Asp.Impl.Generate.CodeBehindGeneratorData.NamespaceEntry> namespaces, JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, JetBrains.ReSharper.Psi.Asp.Tree.IAspFile aspFile) { }
    }
    public class static ASPConstants
    {
        public const string PAGE_CLASS_ATTRIBUTE_NAME = "_ReSharper_Page_Class";
    }
    public class CodeBehindGeneratorData : JetBrains.ReSharper.Psi.IRecursiveElementProcessor
    {
        public readonly JetBrains.ReSharper.Psi.Web.AspNetVersion AspNetVersion;
        public readonly string ClassName;
        public readonly JetBrains.ReSharper.Psi.Impl.Shared.ElementRange<JetBrains.ReSharper.Psi.Html.Tree.IHtmlToken> ClassNameRange;
        public readonly string NamespaceName;
        public readonly JetBrains.ReSharper.Psi.Impl.Shared.ElementRange<JetBrains.ReSharper.Psi.Html.Tree.IHtmlToken> NamespaceNameRange;
        public CodeBehindGeneratorData(JetBrains.ReSharper.Psi.Asp.Tree.IAspFile aspFile, JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Asp.Impl.Generate.CodeBehindGeneratorData.NamespaceEntry> Namespaces { get; }
        public bool ProcessingIsFinished { get; }
        public System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<JetBrains.ReSharper.Psi.Html.Tree.IHtmlTag, System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Asp.Tree.IAspRenderBlock>>> RenderBlocksByTag { get; }
        public System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.Asp.Tree.IAspRenderBlock> TopRenderBlocks { get; }
        public bool InteriorShouldBeProcessed(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public void ProcessAfterInterior(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public void ProcessBeforeInterior(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public class NamespaceEntry
        {
            public readonly JetBrains.ReSharper.Psi.Impl.Shared.ElementRange<JetBrains.ReSharper.Psi.Html.Tree.IHtmlToken> ElementRange;
            public readonly string NamespaceName;
            public NamespaceEntry(string namespaceName, JetBrains.ReSharper.Psi.Impl.Shared.ElementRange<JetBrains.ReSharper.Psi.Html.Tree.IHtmlToken> elementRange) { }
        }
    }
}
namespace JetBrains.ReSharper.Psi.Asp.Impl.Generate.LinqToXsd
{
    
    public class LinqToXsdDetector : JetBrains.Application.InterruptableReadActivity
    {
        public static readonly string[] DirProperties;
        protected readonly string myDevEnvDir;
        public LinqToXsdDetector(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ProjectModel.IProject project, string devEnvDir, JetBrains.ReSharper.Psi.Asp.Impl.Generate.LinqToXsd.LinqToXsdSupportManager manager, JetBrains.DocumentManagers.DocumentManager documentManager, System.Action onInterrupt, System.Action onSuccessfulFinish) { }
        protected JetBrains.Util.FileSystemPath ExePath { get; set; }
        protected JetBrains.ProjectModel.IProject Project { get; }
        protected override string ThreadName { get; }
        protected override void Finish() { }
        protected override void OnInterrupt() { }
        protected override void Start() { }
        protected override void Work() { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class LinqToXsdSupportManager
    {
        protected readonly string myDevEnvDir;
        protected readonly JetBrains.DataFlow.Lifetime myLifetime;
        public LinqToXsdSupportManager(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.IShellLocks locks, JetBrains.Application.ChangeManager changeManager, JetBrains.DocumentManagers.DocumentManager documentManager, JetBrains.DataFlow.Lifetime lifetime, JetBrains.DocumentManagers.impl.DocumentManagerOperations documentManagerOperations, JetBrains.ProjectModel.Model2.Transaction.IEnsureWritableHandler ensureWritableHandler, JetBrains.ProjectModel.Tasks.ISolutionLoadTasksScheduler scheduler) { }
        protected JetBrains.DocumentManagers.DocumentManager DocumentManager { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        protected virtual JetBrains.ReSharper.Psi.Asp.Impl.Generate.LinqToXsd.LinqToXsdDetector CreateLinqToXsdDetector(JetBrains.ProjectModel.IProject project, System.Action onInterrupt, System.Action onSuccessfulFinish) { }
        public bool IsLinqToXsdFile(JetBrains.ProjectModel.IProjectFile projectFile) { }
        public bool IsSupportFile(JetBrains.ProjectModel.IProjectFile projectFile) { }
    }
}
namespace JetBrains.ReSharper.Psi.Asp.Impl.Generate.Tools
{
    
    public abstract class DocumentGenerator
    {
        public abstract int Timeout { get; }
        public abstract bool CanHandle(JetBrains.ProjectModel.ProjectFileType projectFileType);
        [JetBrains.Annotations.CanBeNullAttribute()]
        public abstract string GenerateDocument(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, string tempFolder, JetBrains.ProjectModel.ProjectFileType language);
    }
    public abstract class ExternalDocumentGenerator : JetBrains.ReSharper.Psi.Asp.Impl.Generate.Tools.DocumentGenerator
    {
        protected ExternalDocumentGenerator(JetBrains.ProjectModel.ProjectFileType languageType) { }
        public override int Timeout { get; }
        public override bool CanHandle(JetBrains.ProjectModel.ProjectFileType projectFileType) { }
        protected virtual string CreateTemporaryFiles(JetBrains.ReSharper.Psi.IPsiSourceFile file, string tempFolder) { }
        public override string GenerateDocument(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, string tempFolder, JetBrains.ProjectModel.ProjectFileType language) { }
        protected abstract string GetArgs(string tempFilePath, string tempFolder, JetBrains.ReSharper.Psi.IPsiSourceFile psiSourceFile, JetBrains.ProjectModel.ProjectFileType language);
        protected virtual JetBrains.Util.FileSystemPath GetOutFilePath(string tempFilePath, JetBrains.ProjectModel.ProjectFileType language) { }
        protected abstract string GetUtilPath(JetBrains.ReSharper.Psi.IPsiSourceFile psiSourceFile);
    }
    public class static InterruptableProcessRunner
    {
        public static bool RunProcess(string exePath, string args, JetBrains.Util.FileSystemPath workingDir, int timeoutMilliseconds) { }
    }
}
namespace JetBrains.ReSharper.Psi.Asp.Impl.Html
{
    
    public class AspContainerRelatedField : JetBrains.ReSharper.Psi.Asp.Impl.Html.AspImplicitTypeMember, JetBrains.ReSharper.Psi.Asp.Html.IAspBindingExpressionField, JetBrains.ReSharper.Psi.IAccessRightsOwner, JetBrains.ReSharper.Psi.IAttributesOwner, JetBrains.ReSharper.Psi.IAttributesSet, JetBrains.ReSharper.Psi.IClrDeclaredElement, JetBrains.ReSharper.Psi.IConstantValueOwner, JetBrains.ReSharper.Psi.IDeclaredElement, JetBrains.ReSharper.Psi.IField, JetBrains.ReSharper.Psi.IModifiersOwner, JetBrains.ReSharper.Psi.ITypeMember, JetBrains.ReSharper.Psi.ITypeOwner, JetBrains.ReSharper.Psi.IXmlDocIdOwner
    {
        public AspContainerRelatedField([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Asp.Tree.IAspDataBinderExpression dataBinderExpression, string name) { }
        public JetBrains.ReSharper.Psi.ConstantValue ConstantValue { get; }
        public System.Nullable<int> FixedBufferSize { get; }
        public bool IsConstant { get; }
        public bool IsEnumMember { get; }
        public bool IsField { get; }
        public string Name { get; }
        public override string ShortName { get; }
        public JetBrains.ReSharper.Psi.IType Type { get; }
        public override System.Nullable<JetBrains.ReSharper.Psi.Dependencies.Hash> CalcHash() { }
        protected bool Equals(JetBrains.ReSharper.Psi.Asp.Impl.Html.AspContainerRelatedField other) { }
        public override bool Equals(object obj) { }
        public override JetBrains.ReSharper.Psi.AccessRights GetAccessRights() { }
        public JetBrains.ReSharper.Psi.Asp.Tree.IAspDataBinderExpression GetDeclaration() { }
        public virtual JetBrains.ReSharper.Psi.DeclaredElementType GetElementType() { }
        public override int GetHashCode() { }
        public override bool IsSynthetic() { }
        public override bool IsValid() { }
    }
    public class AspDataBindingExpressionBuilderTargetFiled : JetBrains.ReSharper.Psi.Asp.Impl.Html.AspImplicitTypeMember, JetBrains.ReSharper.Psi.Asp.Html.IAspBindingExpressionField, JetBrains.ReSharper.Psi.IAccessRightsOwner, JetBrains.ReSharper.Psi.IAttributesOwner, JetBrains.ReSharper.Psi.IAttributesSet, JetBrains.ReSharper.Psi.IClrDeclaredElement, JetBrains.ReSharper.Psi.IConstantValueOwner, JetBrains.ReSharper.Psi.IDeclaredElement, JetBrains.ReSharper.Psi.IField, JetBrains.ReSharper.Psi.IModifiersOwner, JetBrains.ReSharper.Psi.ITypeMember, JetBrains.ReSharper.Psi.ITypeOwner, JetBrains.ReSharper.Psi.IXmlDocIdOwner
    {
        public AspDataBindingExpressionBuilderTargetFiled([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Asp.Tree.IAspDataBinderExpression dataBinderExpression) { }
        public JetBrains.ReSharper.Psi.ConstantValue ConstantValue { get; }
        public System.Nullable<int> FixedBufferSize { get; }
        public bool IsConstant { get; }
        public bool IsEnumMember { get; }
        public bool IsField { get; }
        public string Name { get; }
        public override string ShortName { get; }
        public JetBrains.ReSharper.Psi.IType Type { get; }
        public override System.Nullable<JetBrains.ReSharper.Psi.Dependencies.Hash> CalcHash() { }
        protected bool Equals(JetBrains.ReSharper.Psi.Asp.Impl.Html.AspDataBindingExpressionBuilderTargetFiled other) { }
        public override bool Equals(object obj) { }
        public override JetBrains.ReSharper.Psi.AccessRights GetAccessRights() { }
        public JetBrains.ReSharper.Psi.Asp.Tree.IAspDataBinderExpression GetDeclaration() { }
        public virtual JetBrains.ReSharper.Psi.DeclaredElementType GetElementType() { }
        public override int GetHashCode() { }
        public static string GetName([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Asp.Tree.IAspDataBinderExpression dataBinderExpression) { }
        public override bool IsSynthetic() { }
        public override bool IsValid() { }
    }
    public abstract class AspImplicitTypeMember : JetBrains.ReSharper.Psi.IAccessRightsOwner, JetBrains.ReSharper.Psi.IAttributesOwner, JetBrains.ReSharper.Psi.IAttributesSet, JetBrains.ReSharper.Psi.IClrDeclaredElement, JetBrains.ReSharper.Psi.IDeclaredElement, JetBrains.ReSharper.Psi.IModifiersOwner, JetBrains.ReSharper.Psi.ITypeMember, JetBrains.ReSharper.Psi.IXmlDocIdOwner
    {
        protected AspImplicitTypeMember([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.ITypeElement aspTypeElement) { }
        public JetBrains.ReSharper.Psi.AccessibilityDomain AccessibilityDomain { get; }
        public bool CaseSensistiveName { get; }
        public JetBrains.ReSharper.Psi.MemberHidePolicy HidePolicy { get; }
        public JetBrains.ReSharper.Psi.Resolve.ISubstitution IdSubstitution { get; }
        public bool IsAbstract { get; }
        public bool IsExtern { get; }
        public bool IsOverride { get; }
        public bool IsReadonly { get; }
        public bool IsSealed { get; }
        public bool IsStatic { get; }
        public bool IsUnsafe { get; }
        public bool IsVirtual { get; }
        public bool IsVolatile { get; }
        public JetBrains.ReSharper.Psi.Modules.IPsiModule Module { get; }
        public JetBrains.ReSharper.Psi.PsiLanguageType PresentationLanguage { get; }
        public JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext ResolveContext { get; }
        public abstract string ShortName { get; }
        public virtual string XMLDocId { get; }
        public virtual System.Nullable<JetBrains.ReSharper.Psi.Dependencies.Hash> CalcHash() { }
        public abstract JetBrains.ReSharper.Psi.AccessRights GetAccessRights();
        [JetBrains.Annotations.CanBeNullAttribute()]
        protected JetBrains.ReSharper.Psi.Asp.Tree.IAspFile GetAspFile() { }
        public virtual System.Collections.Generic.IList<JetBrains.ReSharper.Psi.IAttributeInstance> GetAttributeInstances(bool inherit) { }
        public virtual System.Collections.Generic.IList<JetBrains.ReSharper.Psi.IAttributeInstance> GetAttributeInstances(JetBrains.ReSharper.Psi.IClrTypeName clrName, bool inherit) { }
        public JetBrains.ReSharper.Psi.ITypeElement GetContainingType() { }
        public JetBrains.ReSharper.Psi.ITypeMember GetContainingTypeMember() { }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Tree.IDeclaration> GetDeclarations() { }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Tree.IDeclaration> GetDeclarationsIn(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
        public virtual JetBrains.ReSharper.Psi.DeclaredElementType GetElementType() { }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Psi.TypeMemberInstance> GetHiddenMembers() { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Tree.IParametersOwnerDeclaration> GetParametersOwnerDeclarations() { }
        public JetBrains.ReSharper.Psi.IPsiServices GetPsiServices() { }
        public JetBrains.Util.DataStructures.HybridCollection<JetBrains.ReSharper.Psi.IPsiSourceFile> GetSourceFiles() { }
        public System.Xml.XmlNode GetXMLDescriptionSummary(bool inherit) { }
        public System.Xml.XmlNode GetXMLDoc(bool inherit) { }
        public virtual bool HasAttributeInstance(JetBrains.ReSharper.Psi.IClrTypeName clrName, bool inherit) { }
        public bool HasDeclarationsIn(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
        public virtual bool IsSynthetic() { }
        public virtual bool IsValid() { }
    }
}
namespace JetBrains.ReSharper.Psi.Asp.Impl.Parsing
{
    
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.Asp.AspLanguage))]
    public sealed class AspTokenNodeTypes : JetBrains.ReSharper.Psi.Html.Impl.Parsing.HtmlTokenNodeTypes, JetBrains.ReSharper.Psi.Asp.Parsing.IAspTokenNodeTypes, JetBrains.ReSharper.Psi.Html.Parsing.IHtmlCompoundTokenNodeTypes, JetBrains.ReSharper.Psi.Html.Parsing.IHtmlTokenNodeTypes
    {
        public AspTokenNodeTypes(JetBrains.ReSharper.Psi.Asp.AspLanguage lang) { }
        public JetBrains.ReSharper.Psi.Parsing.TokenNodeType ASP_BLOCK_END { get; }
        public JetBrains.ReSharper.Psi.Parsing.TokenNodeType ASP_BLOCK_START { get; }
        public JetBrains.ReSharper.Psi.Parsing.TokenNodeType ASP_COMMENT_BODY { get; }
        public JetBrains.ReSharper.Psi.Parsing.TokenNodeType ASP_COMMENT_END { get; }
        public JetBrains.ReSharper.Psi.Parsing.TokenNodeType ASP_COMMENT_START { get; }
        public JetBrains.ReSharper.Psi.Parsing.TokenNodeType ASP_DATA_BINDER_START { get; }
        public JetBrains.ReSharper.Psi.Parsing.TokenNodeType ASP_DIRECTIVE_START { get; }
        public JetBrains.ReSharper.Psi.Parsing.TokenNodeType ASP_ERROR_BLOCK_END { get; }
        public JetBrains.ReSharper.Psi.Parsing.TokenNodeType ASP_EXPR_START { get; }
        public JetBrains.ReSharper.Psi.Parsing.TokenNodeType ASP_HTML_ENCODED_DATA_BINDER_START { get; }
        public JetBrains.ReSharper.Psi.Parsing.TokenNodeType ASP_HTML_ENCODING_START { get; }
        public JetBrains.ReSharper.Psi.Parsing.TokenNodeType ASP_PREPROCESSOR_BLOCK_START { get; }
        public JetBrains.ReSharper.Psi.Parsing.TokenNodeType ASP_SUBSTITUTION_START { get; }
        public JetBrains.ReSharper.Psi.Parsing.TokenNodeType CODE { get; }
        public JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet CodeBlocksStart { get; }
        public JetBrains.ReSharper.Psi.Parsing.TokenNodeType RAW_HTML { get; }
        public JetBrains.ReSharper.Psi.Parsing.TokenNodeType SUBSTITUTION_BODY { get; }
        public override short GetChildRole(JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.TreeElement child) { }
        public override bool IsNonHtmlToken(JetBrains.ReSharper.Psi.Parsing.TokenNodeType tokenNodeType) { }
        public override bool IsTagLikeClose(JetBrains.ReSharper.Psi.Parsing.TokenNodeType tokenNodeType) { }
        public override bool IsTagLikeOpen(JetBrains.ReSharper.Psi.Parsing.TokenNodeType tokenNodeType) { }
    }
}
namespace JetBrains.ReSharper.Psi.Asp.Impl.PsiModules
{
    
    public class AspFileDataImpl : JetBrains.ReSharper.Psi.Web.PsiModules.IAspFileData
    {
        public static readonly JetBrains.ReSharper.Psi.Asp.Impl.PsiModules.AspFileDataImpl Empty;
        public AspFileDataImpl(System.IO.BinaryReader reader) { }
        public AspFileDataImpl(JetBrains.ReSharper.Psi.Asp.Tree.IAspFile aspFile) { }
        public string CodeFile { get; }
        public string LanguageDefinedInFile { get; }
        public System.Collections.Generic.IEnumerable<string> ReferencedFiles { get; }
        public System.Collections.Generic.IEnumerable<string> ReferencedModulesByName { get; }
        public System.Collections.Generic.IEnumerable<string> ReferencedModulesByPath { get; }
        public JetBrains.ReSharper.Psi.Web.PsiModules.IAspFileDataDiff GetDiff(JetBrains.ReSharper.Psi.Web.PsiModules.IAspFileData otherData) { }
        public void Read(System.IO.BinaryReader reader) { }
        public void Write(System.IO.BinaryWriter writer) { }
    }
    public class WebAspFilesHelperBase : JetBrains.ReSharper.Psi.Web.Impl.PsiModules.IAspFileDataChangeListener, JetBrains.ReSharper.Psi.Web.Impl.PsiModules.IWebCommonReferenceProvider, JetBrains.ReSharper.Psi.Web.Impl.PsiModules.IWebPsiModuleHandlerHelper
    {
        protected readonly JetBrains.ReSharper.Psi.Web.Impl.PsiModules.Website.Helpers.PsiSourceFilesContainer myFilesContainer;
        protected readonly JetBrains.ReSharper.Psi.PsiProjectFileTypeCoordinator myPsiProjectFileTypeCoordinator;
        public WebAspFilesHelperBase(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ReSharper.Psi.Web.Impl.PsiModules.IWebProjectPsiModuleHandler handler, JetBrains.ReSharper.Psi.Web.PsiModules.IWebAssemblyReferenceFactory assemblyReferenceFactory, JetBrains.ReSharper.Psi.Web.PsiModules.IAspFileDataCache aspFileDataCache, JetBrains.ReSharper.Psi.Web.Cache.IWebConfigCache webConfigCache, JetBrains.ReSharper.Psi.ILanguageManager languageManager, JetBrains.Application.IShellLocks shellLocks, JetBrains.ReSharper.Psi.Web.Impl.PsiModules.Website.WebProjectFileTypeClassifier projectFileClassifier, JetBrains.ReSharper.Psi.Web.Util.WebPsiLanguageUtil webPsiLanguageUtil, JetBrains.ReSharper.Psi.PsiProjectFileTypeCoordinator psiProjectFileTypeCoordinator, JetBrains.ReSharper.Psi.PsiSourceFilePropertiesManager propertiesManager) { }
        protected JetBrains.Util.OneToSetMap<JetBrains.Util.FileSystemPath, JetBrains.Util.FileSystemPath> CodeFilePathToAspFile { get; }
        public double Priority { get; }
        protected JetBrains.ProjectModel.IProject Project { get; }
        protected JetBrains.ReSharper.Psi.Web.Impl.PsiModules.Website.WebProjectFileTypeClassifier ProjectFileClassifier { get; }
        protected JetBrains.Util.OneToSetMap<JetBrains.Util.FileSystemPath, JetBrains.Util.FileSystemPath> ReferencedFilePathToAspFile { get; }
        public JetBrains.DataFlow.ISimpleSignal ReferencesChanged { get; }
        protected JetBrains.ReSharper.Psi.Web.Cache.IWebConfigCache WebConfigCache { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IPsiSourceFile> FindPsiSourceFiles(JetBrains.ProjectModel.IProjectFile projectFile) { }
        public virtual System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Modules.IPsiModule> GetAllModules() { }
        public void GetCommonReferencesFor(JetBrains.ReSharper.Psi.Modules.IPsiModule psiModule, JetBrains.ReSharper.Psi.Web.Impl.PsiModules.PsiModuleReferenceAccumulator referenceAccumulator) { }
        protected JetBrains.ReSharper.Psi.Asp.Impl.PsiModules.Website.Modules.IAspFilePsiModule GetOrCreateAspFilePsiModule(JetBrains.ProjectModel.IProjectFile projectFile, JetBrains.ReSharper.Psi.Modules.PsiModuleChangeBuilder changeBuilder, out JetBrains.ReSharper.Psi.Web.PsiModules.IAspFileDataDiff diffToApply) { }
        public bool InternalsVisibleTo(JetBrains.ReSharper.Psi.Modules.IPsiModule moduleTo, JetBrains.ReSharper.Psi.Modules.IPsiModule moduleFrom) { }
        public void OnExternalModuleSetChanged(JetBrains.ReSharper.Psi.Modules.PsiModuleChangeBuilder changeBuilder) { }
        public virtual bool OnProjectFileAdded(JetBrains.ProjectModel.IProjectFile projectFile, JetBrains.ReSharper.Psi.Modules.PsiModuleChangeBuilder changeBuilder, System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Web.Impl.PsiModules.IWebPsiModuleHandlerHelper> alreadyProcessedBy) { }
        public void OnProjectFileDataChanged(JetBrains.Util.Pair<JetBrains.Util.FileSystemPath, JetBrains.ReSharper.Psi.Web.PsiModules.IAspFileDataDiff> pair, JetBrains.ReSharper.Psi.Modules.PsiModuleChangeBuilder changeBuilder) { }
        public void OnProjectFileModified(JetBrains.ProjectModel.IProjectFile projectFile, JetBrains.ReSharper.Psi.Modules.PsiModuleChangeBuilder changeBuilder) { }
        public void OnProjectFileRemoved(JetBrains.ProjectModel.IProjectFile projectFile, JetBrains.ReSharper.Psi.Modules.PsiModuleChangeBuilder changeBuilder) { }
        public void OnProjectPropertiesChange(JetBrains.ReSharper.Psi.Modules.PsiModuleChangeBuilder changeBuilder) { }
        public JetBrains.ReSharper.Psi.Asp.Impl.PsiModules.Website.Modules.IAspFilePsiModule TryGetAspFileModule(JetBrains.ProjectModel.IProjectFile projectFile) { }
    }
    [JetBrains.ProjectModel.ProjectFileTypeAttribute(typeof(JetBrains.ProjectModel.AspProjectFileType))]
    public class WebAspProjectFileClassifier : JetBrains.ReSharper.Psi.Web.PsiModules.IWebProjectFileClassifier
    {
        public bool CanBeAppCodeFile(JetBrains.ProjectModel.IProjectFile projectFile) { }
        public bool CanBeAspFile(JetBrains.ProjectModel.IProjectFile projectFile) { }
        public bool CanBeCodeBehindFile(JetBrains.ProjectModel.IProjectFile projectFile) { }
    }
}
namespace JetBrains.ReSharper.Psi.Asp.Impl.PsiModules.WebApp.Helpers
{
    
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class SharepointPredefinedModulesFactory : JetBrains.Application.IChangeProvider, JetBrains.ReSharper.Psi.Modules.IPsiModuleFactory, JetBrains.ReSharper.Psi.Paths.IVirtualFilesProvider
    {
        public static readonly JetBrains.Util.FileSystemPath SharepointPredefinedFilesRoot;
        public SharepointPredefinedModulesFactory(JetBrains.DataFlow.Lifetime lifetime, JetBrains.DocumentManagers.DocumentManager documentManager, JetBrains.DocumentModel.IInMemoryDocumentFactory documentFactory, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Psi.Paths.IVirtualPathsService virtualPathsService, JetBrains.ProjectModel.Sharepoint.ISharepointFilesLocator locator, JetBrains.ProjectModel.IProjectFileExtensions fileExtensions, JetBrains.ReSharper.Psi.PsiProjectFileTypeCoordinator coordinator, JetBrains.Application.ChangeManager changeManager, JetBrains.Application.IShellLocks locks) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Modules.IPsiModule> Modules { get; }
        public object Execute(JetBrains.Application.IChangeMap changeMap) { }
        public void GetCommonReferencesFor(JetBrains.ReSharper.Psi.Modules.IPsiModule psiModule, JetBrains.ReSharper.Psi.Web.Impl.PsiModules.PsiModuleReferenceAccumulator referenceAccumulator, JetBrains.ProjectModel.IProject project) { }
        public void RegisterSharepointProject(JetBrains.DataFlow.Lifetime projectLifetime, JetBrains.ProjectModel.IProject project) { }
    }
    public class WebAppGlobalResourcesHelper : JetBrains.ReSharper.Psi.Web.Impl.PsiModules.IWebCommonReferenceProvider, JetBrains.ReSharper.Psi.Web.Impl.PsiModules.IWebPsiModuleHandlerHelper, JetBrains.ReSharper.Psi.Web.Impl.PsiModules.WebApp.Helpers.IWebAppSignificantModuleProvider
    {
        public WebAppGlobalResourcesHelper(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ReSharper.Psi.Web.Impl.PsiModules.IWebProjectPsiModuleHandler handler, JetBrains.ReSharper.Psi.PsiProjectFileTypeCoordinator psiProjectFileTypeCoordinator, JetBrains.ReSharper.Psi.PsiSourceFilePropertiesManager propertiesManager) { }
        public JetBrains.ReSharper.Psi.Modules.IProjectPsiModule PrimaryModule { get; }
        public double Priority { get; }
        public JetBrains.DataFlow.ISimpleSignal ReferencesChanged { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IPsiSourceFile> FindPsiSourceFiles(JetBrains.ProjectModel.IProjectFile projectFile) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Modules.IPsiModule> GetAllModules() { }
        public void GetCommonReferencesFor(JetBrains.ReSharper.Psi.Modules.IPsiModule psiModule, JetBrains.ReSharper.Psi.Web.Impl.PsiModules.PsiModuleReferenceAccumulator referenceAccumulator) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Modules.IPsiModule> GetPsiModulesToReference() { }
        public bool InternalsVisibleTo(JetBrains.ReSharper.Psi.Modules.IPsiModule moduleTo, JetBrains.ReSharper.Psi.Modules.IPsiModule moduleFrom) { }
        public void OnExternalModuleSetChanged(JetBrains.ReSharper.Psi.Modules.PsiModuleChangeBuilder changeBuilder) { }
        public bool OnProjectFileAdded(JetBrains.ProjectModel.IProjectFile projectFile, JetBrains.ReSharper.Psi.Modules.PsiModuleChangeBuilder changeBuilder, System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Web.Impl.PsiModules.IWebPsiModuleHandlerHelper> alreadyProcessedBy) { }
        public void OnProjectFileModified(JetBrains.ProjectModel.IProjectFile projectFile, JetBrains.ReSharper.Psi.Modules.PsiModuleChangeBuilder changeBuilder) { }
        public void OnProjectFileRemoved(JetBrains.ProjectModel.IProjectFile projectFile, JetBrains.ReSharper.Psi.Modules.PsiModuleChangeBuilder changeBuilder) { }
        public void OnProjectPropertiesChange(JetBrains.ReSharper.Psi.Modules.PsiModuleChangeBuilder changeBuilder) { }
    }
    [JetBrains.ReSharper.Psi.Web.Impl.PsiModules.WebApp.WebAppPsiModuleHandlerHelperFactoryAttribute()]
    public class WebAppGlobalResourcesHelperFactory : JetBrains.ReSharper.Psi.Web.Impl.PsiModules.IWebPsiModuleHandlerHelperFactory, JetBrains.ReSharper.Psi.Web.Impl.PsiModules.WebApp.IWebAppPsiModuleHandlerHelperFactory
    {
        public WebAppGlobalResourcesHelperFactory(JetBrains.ReSharper.Psi.PsiProjectFileTypeCoordinator psiProjectFileTypeCoordinator, JetBrains.ReSharper.Psi.PsiSourceFilePropertiesManager propertiesManager) { }
        public JetBrains.ReSharper.Psi.Web.Impl.PsiModules.IWebPsiModuleHandlerHelper CreateHelper(JetBrains.DataFlow.Lifetime helperLifetime, JetBrains.ReSharper.Psi.Web.Impl.PsiModules.IWebProjectPsiModuleHandler handler, JetBrains.ReSharper.Psi.Web.Cache.IWebConfigCache webConfigCache, JetBrains.ReSharper.Psi.Web.PsiModules.IAspFileDataCache aspFileDataCache) { }
    }
}
namespace JetBrains.ReSharper.Psi.Asp.Impl.PsiModules.WebApp.Modules
{
    
    public class SharepointPredefinedControlTemplatesModule : JetBrains.ReSharper.Psi.Asp.Impl.PsiModules.WebApp.Modules.SharepointPredefinedFilesModuleBase
    {
        public SharepointPredefinedControlTemplatesModule(JetBrains.ProjectModel.ISolution solution, JetBrains.ProjectModel.IModule projectModule, JetBrains.DocumentManagers.DocumentManager documentFactory, JetBrains.ProjectModel.Sharepoint.ISharepointFilesLocator locator, JetBrains.ProjectModel.IProjectFileExtensions fileExtensions, JetBrains.ReSharper.Psi.PsiProjectFileTypeCoordinator coordinator, JetBrains.DataFlow.CollectionEvents<JetBrains.ProjectModel.IProject> sharepointProjects, JetBrains.DocumentModel.IInMemoryDocumentFactory factory) { }
    }
    public class SharepointPredefinedFilesModuleBase : JetBrains.ReSharper.Psi.Modules.IPsiModule
    {
        public const string PREDEFINED_FILES_FOLDER = "~masterUrl";
        protected const string sharepointPrefix = "JetBrains.ReSharper.Psi.Asp.resources.Sharepoint.";
        protected SharepointPredefinedFilesModuleBase(JetBrains.ProjectModel.ISolution solution, JetBrains.ProjectModel.IModule projectModule, string name, System.Collections.Generic.ICollection<JetBrains.ProjectModel.IProject> sharepointProjects, JetBrains.DocumentModel.IInMemoryDocumentFactory factory) { }
        public JetBrains.ProjectModel.IModule ContainingProjectModule { get; }
        public string DisplayName { get; }
        public string Name { get; }
        public System.Collections.Generic.IDictionary<JetBrains.Util.FileSystemPath, JetBrains.ReSharper.Psi.IPsiSourceFileWithLocation> PredefinedFilesByRelativePath { get; }
        public JetBrains.ProjectModel.ProjectFileType ProjectFileType { get; }
        public JetBrains.ReSharper.Psi.PsiLanguageType PsiLanguage { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IPsiSourceFile> SourceFiles { get; }
        public System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.PreProcessingDirective> GetAllDefines() { }
        public string GetPersistentID() { }
        public JetBrains.ReSharper.Psi.IPsiServices GetPsiServices() { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Modules.IPsiModuleReference> GetReferences(JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext moduleReferenceResolveContext) { }
        public JetBrains.ProjectModel.ISolution GetSolution() { }
        protected bool InitializeFiles(JetBrains.Util.FileSystemPath folder, string resourcesPrefix, string namePattern, JetBrains.DocumentManagers.DocumentManager documentManager, JetBrains.ProjectModel.IProjectFileExtensions fileExtensions, JetBrains.ReSharper.Psi.PsiProjectFileTypeCoordinator coordinator) { }
        public bool IsValid() { }
        protected bool LoadFromFolder(JetBrains.Util.FileSystemPath folder, string namePattern, JetBrains.DocumentManagers.DocumentManager documentFactory, JetBrains.ProjectModel.IProjectFileExtensions fileExtensions, JetBrains.ReSharper.Psi.PsiProjectFileTypeCoordinator coordinator, System.Collections.Generic.Dictionary<string, JetBrains.ReSharper.Psi.Asp.Impl.PsiModules.WebApp.Modules.SharepointPredefinedPsiSourceFile> files) { }
    }
    public class SharepointPredefinedLayoutsModule : JetBrains.ReSharper.Psi.Asp.Impl.PsiModules.WebApp.Modules.SharepointPredefinedFilesModuleBase
    {
        public SharepointPredefinedLayoutsModule(JetBrains.ProjectModel.ISolution solution, JetBrains.ProjectModel.IModule projectModule, JetBrains.DocumentManagers.DocumentManager documentFactory, JetBrains.ProjectModel.Sharepoint.ISharepointFilesLocator locator, JetBrains.ProjectModel.IProjectFileExtensions fileExtensions, JetBrains.ReSharper.Psi.PsiProjectFileTypeCoordinator coordinator, System.Collections.Generic.ICollection<JetBrains.ProjectModel.IProject> sharepointProjects, JetBrains.DocumentModel.IInMemoryDocumentFactory factory) { }
    }
    public class SharepointPredefinedMasterFilesModule : JetBrains.ReSharper.Psi.Asp.Impl.PsiModules.WebApp.Modules.SharepointPredefinedFilesModuleBase
    {
        public SharepointPredefinedMasterFilesModule(JetBrains.ProjectModel.ISolution solution, JetBrains.ProjectModel.IModule projectModule, JetBrains.DocumentManagers.DocumentManager documentFactory, JetBrains.ProjectModel.Sharepoint.ISharepointFilesLocator locator, JetBrains.ProjectModel.IProjectFileExtensions fileExtensions, JetBrains.ReSharper.Psi.PsiProjectFileTypeCoordinator coordinator, System.Collections.Generic.ICollection<JetBrains.ProjectModel.IProject> sharepointProjects, JetBrains.DocumentModel.IInMemoryDocumentFactory factory) { }
    }
    public class SharepointPredefinedPsiSourceFile : JetBrains.Util.UserDataHolder, JetBrains.ReSharper.Psi.IPsiSourceFile, JetBrains.ReSharper.Psi.IPsiSourceFileWithLocation, JetBrains.Util.IUserDataHolder
    {
        public SharepointPredefinedPsiSourceFile(JetBrains.ReSharper.Psi.Modules.IPsiModule psiModule, string name, System.Func<JetBrains.DocumentModel.IDocument> createDocumentFunc, System.DateTime lastWriteTimeUtc, JetBrains.ProjectModel.IProjectFileExtensions fileExtensions, JetBrains.ReSharper.Psi.PsiProjectFileTypeCoordinator coordinator, JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext resolveContext) { }
        public string DisplayName { get; }
        public JetBrains.DocumentModel.IDocument Document { get; }
        public System.Nullable<int> InMemoryModificationStamp { get; }
        public JetBrains.ProjectModel.ProjectFileType LanguageType { get; }
        public System.DateTime LastWriteTimeUtc { get; }
        public JetBrains.Util.FileSystemPath Location { get; }
        public string Name { get; }
        public JetBrains.ReSharper.Psi.PsiLanguageType PrimaryPsiLanguage { get; }
        public JetBrains.ReSharper.Psi.IPsiSourceFileProperties Properties { get; }
        public JetBrains.ReSharper.Psi.Modules.IPsiModule PsiModule { get; }
        public JetBrains.ReSharper.Psi.IPsiSourceFileStorage PsiStorage { get; }
        public JetBrains.Util.FileSystemPath RelativePath { get; }
        public JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext ResolveContext { get; }
        public string GetPersistentID() { }
        public bool IsValid() { }
    }
    public class SharepointPredefinedResourcesModule : JetBrains.ReSharper.Psi.Asp.Impl.PsiModules.WebApp.Modules.SharepointPredefinedFilesModuleBase
    {
        public SharepointPredefinedResourcesModule(JetBrains.ProjectModel.ISolution solution, JetBrains.ProjectModel.IModule projectModule, JetBrains.DocumentManagers.DocumentManager documentFactory, JetBrains.ProjectModel.Sharepoint.ISharepointFilesLocator locator, JetBrains.ProjectModel.IProjectFileExtensions fileExtensions, JetBrains.ReSharper.Psi.PsiProjectFileTypeCoordinator coordinator, System.Collections.Generic.ICollection<JetBrains.ProjectModel.IProject> sharepointProjects, JetBrains.DocumentModel.IInMemoryDocumentFactory factory) { }
    }
    [JetBrains.ProjectModel.ProjectFileTypeAttribute(typeof(JetBrains.ProjectModel.ResxProjectFileType))]
    public class SharepointPredefinedResourcesProjectFileCustomPsiPropertiesProvider : JetBrains.ReSharper.Psi.IProjectFileCustomPsiPropertiesProvider
    {
        public T GetCustomProperties<T>(JetBrains.ProjectModel.IProjectFile projectFile, JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
    }
    public class SharePointResolveContext : JetBrains.ProjectModel.Assemblies.AssemblyToAssemblyResolvers.ProjectResolveContext
    {
        public SharePointResolveContext(System.Collections.Generic.ICollection<JetBrains.ProjectModel.IProject> sharepointProjects) { }
    }
    public class WebAppGlobalResourcesModule : JetBrains.ReSharper.Psi.Modules.ProjectPsiModuleBase
    {
        public WebAppGlobalResourcesModule(JetBrains.ReSharper.Psi.Web.Impl.PsiModules.IWebProjectPsiModuleHandler handler, JetBrains.ReSharper.Psi.PsiProjectFileTypeCoordinator psiProjectFileTypeCoordinator) { }
        protected override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Modules.IPsiModuleReference> GetReferencesInternal() { }
    }
}
namespace JetBrains.ReSharper.Psi.Asp.Impl.PsiModules.Website.Helpers
{
    
    public class WebCustomBuildProvidersOutputHelper : JetBrains.ReSharper.Psi.Web.Impl.PsiModules.IWebCommonReferenceProvider, JetBrains.ReSharper.Psi.Web.Impl.PsiModules.IWebPsiModuleHandlerHelper
    {
        public WebCustomBuildProvidersOutputHelper(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ReSharper.Psi.Web.Impl.PsiModules.IWebProjectPsiModuleHandler handler, JetBrains.ReSharper.Psi.Web.BuildProviders.IWebsiteBuilders builders, JetBrains.ProjectModel.IProjectFileExtensions projectFileExtensions, JetBrains.ReSharper.Psi.PsiProjectFileTypeCoordinator coordinator, JetBrains.Application.ChangeManager changeManager, JetBrains.Application.IShellLocks locks, JetBrains.DocumentManagers.DocumentManager documentManager, JetBrains.ReSharper.Psi.PsiProjectFileTypeCoordinator psiProjectFileTypeCoordinator, JetBrains.ReSharper.Psi.Web.PsiModules.IWebAssemblyReferenceFactory webAssemblyReferenceFactory) { }
        public double Priority { get; }
        public JetBrains.DataFlow.ISimpleSignal ReferencesChanged { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IPsiSourceFile> FindPsiSourceFiles(JetBrains.ProjectModel.IProjectFile projectFile) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Modules.IPsiModule> GetAllModules() { }
        public void GetCommonReferencesFor(JetBrains.ReSharper.Psi.Modules.IPsiModule psiModule, JetBrains.ReSharper.Psi.Web.Impl.PsiModules.PsiModuleReferenceAccumulator referenceAccumulator) { }
        public bool InternalsVisibleTo(JetBrains.ReSharper.Psi.Modules.IPsiModule moduleTo, JetBrains.ReSharper.Psi.Modules.IPsiModule moduleFrom) { }
        public void OnExternalModuleSetChanged(JetBrains.ReSharper.Psi.Modules.PsiModuleChangeBuilder changeBuilder) { }
        public bool OnProjectFileAdded(JetBrains.ProjectModel.IProjectFile projectFile, JetBrains.ReSharper.Psi.Modules.PsiModuleChangeBuilder changeBuilder, System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Web.Impl.PsiModules.IWebPsiModuleHandlerHelper> alreadyProcessedBy) { }
        public void OnProjectFileModified(JetBrains.ProjectModel.IProjectFile projectFile, JetBrains.ReSharper.Psi.Modules.PsiModuleChangeBuilder changeBuilder) { }
        public void OnProjectFileRemoved(JetBrains.ProjectModel.IProjectFile projectFile, JetBrains.ReSharper.Psi.Modules.PsiModuleChangeBuilder changeBuilder) { }
        public void OnProjectPropertiesChange(JetBrains.ReSharper.Psi.Modules.PsiModuleChangeBuilder changeBuilder) { }
    }
    [JetBrains.ReSharper.Psi.Web.Impl.PsiModules.WebApp.WebAppPsiModuleHandlerHelperFactoryAttribute()]
    [JetBrains.ReSharper.Psi.Web.Impl.PsiModules.Website.WebsitePsiModuleHandlerHelperFactoryAttribute()]
    public class WebCustomBuildProvidersOutputHelperFactory : JetBrains.ReSharper.Psi.Web.Impl.PsiModules.IWebPsiModuleHandlerHelperFactory, JetBrains.ReSharper.Psi.Web.Impl.PsiModules.WebApp.IWebAppPsiModuleHandlerHelperFactory, JetBrains.ReSharper.Psi.Web.Impl.PsiModules.Website.IWebsitePsiModuleHandlerHelperFactory
    {
        public WebCustomBuildProvidersOutputHelperFactory(JetBrains.ReSharper.Psi.Web.Impl.PsiModules.Website.WebProjectFileTypeClassifier webProjectFileTypeClassifier, JetBrains.ProjectModel.IProjectFileExtensions projectFileExtensions, JetBrains.ReSharper.Psi.PsiProjectFileTypeCoordinator coordinator, JetBrains.Application.ChangeManager changeManager, JetBrains.Application.IShellLocks shellLocks, JetBrains.ReSharper.Psi.Web.BuildProviders.IWebsiteBuilders websiteBuilders, JetBrains.DocumentManagers.DocumentManager documentManager, JetBrains.ReSharper.Psi.PsiProjectFileTypeCoordinator psiProjectFileTypeCoordinator, JetBrains.ReSharper.Psi.Web.PsiModules.IWebAssemblyReferenceFactory webAssemblyReferenceFactory) { }
        public JetBrains.ReSharper.Psi.Web.Impl.PsiModules.IWebPsiModuleHandlerHelper CreateHelper(JetBrains.DataFlow.Lifetime helperLifetime, JetBrains.ReSharper.Psi.Web.Impl.PsiModules.IWebProjectPsiModuleHandler handler, JetBrains.ReSharper.Psi.Web.Cache.IWebConfigCache webConfigCache, JetBrains.ReSharper.Psi.Web.PsiModules.IAspFileDataCache aspFileDataCache) { }
    }
    public class WebsiteAspFilesHelper : JetBrains.ReSharper.Psi.Asp.Impl.PsiModules.WebAspFilesHelperBase
    {
        public WebsiteAspFilesHelper(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ReSharper.Psi.Web.Impl.PsiModules.IWebProjectPsiModuleHandler handler, JetBrains.ReSharper.Psi.Web.PsiModules.IWebAssemblyReferenceFactory assemblyReferenceFactory, JetBrains.ReSharper.Psi.Web.PsiModules.IAspFileDataCache aspFileDataCache, JetBrains.ReSharper.Psi.Web.Cache.IWebConfigCache webConfigCache, JetBrains.ProjectModel.FileTypes.IProjectFileTypeServices projectFileTypeServices, JetBrains.ReSharper.Psi.ILanguageManager languageManager, JetBrains.Application.IShellLocks shellLocks, JetBrains.ReSharper.Psi.Web.Impl.PsiModules.Website.WebProjectFileTypeClassifier projectFileClassifier, JetBrains.ReSharper.Psi.Web.Util.WebPsiLanguageUtil webPsiLanguageUtil, JetBrains.ReSharper.Psi.PsiProjectFileTypeCoordinator psiProjectFileTypeCoordinator, JetBrains.ReSharper.Psi.PsiSourceFilePropertiesManager propertiesManager) { }
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Modules.IPsiModule> GetAllModules() { }
        public override bool OnProjectFileAdded(JetBrains.ProjectModel.IProjectFile projectFile, JetBrains.ReSharper.Psi.Modules.PsiModuleChangeBuilder changeBuilder, System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Web.Impl.PsiModules.IWebPsiModuleHandlerHelper> alreadyProcessedBy) { }
    }
    [JetBrains.ReSharper.Psi.Web.Impl.PsiModules.Website.WebsitePsiModuleHandlerHelperFactoryAttribute()]
    public class WebsiteAspFilesHelperFactory : JetBrains.ReSharper.Psi.Web.Impl.PsiModules.IWebPsiModuleHandlerHelperFactory, JetBrains.ReSharper.Psi.Web.Impl.PsiModules.Website.IWebsitePsiModuleHandlerHelperFactory
    {
        public WebsiteAspFilesHelperFactory(JetBrains.ReSharper.Psi.Web.PsiModules.IWebAssemblyReferenceFactory assemblyReferenceFactory, JetBrains.ProjectModel.FileTypes.IProjectFileTypeServices projectFileTypeServices, JetBrains.ReSharper.Psi.ILanguageManager languageManager, JetBrains.Application.IShellLocks shellLocks, JetBrains.ReSharper.Psi.Web.Impl.PsiModules.Website.WebProjectFileTypeClassifier projectFileTypeClassifier, JetBrains.ReSharper.Psi.Web.Util.WebPsiLanguageUtil webPsiLanguageUtil, JetBrains.ReSharper.Psi.PsiProjectFileTypeCoordinator psiProjectFileTypeCoordinator, JetBrains.ReSharper.Psi.PsiSourceFilePropertiesManager propertiesManager) { }
        public JetBrains.ReSharper.Psi.Web.Impl.PsiModules.IWebPsiModuleHandlerHelper CreateHelper(JetBrains.DataFlow.Lifetime helperLifetime, JetBrains.ReSharper.Psi.Web.Impl.PsiModules.IWebProjectPsiModuleHandler handler, JetBrains.ReSharper.Psi.Web.Cache.IWebConfigCache webConfigCache, JetBrains.ReSharper.Psi.Web.PsiModules.IAspFileDataCache aspFileDataCache) { }
    }
    public class WebsiteGlobalResourcesHelper : JetBrains.ReSharper.Psi.Web.Impl.PsiModules.IWebCommonReferenceProvider, JetBrains.ReSharper.Psi.Web.Impl.PsiModules.IWebPsiModuleHandlerHelper
    {
        public WebsiteGlobalResourcesHelper(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ReSharper.Psi.Web.Impl.PsiModules.IWebProjectPsiModuleHandler handler, JetBrains.ReSharper.Psi.Web.Impl.PsiModules.Website.WebProjectFileTypeClassifier projectFileClassifier, JetBrains.ProjectModel.IProjectFileExtensions projectFileExtensions, JetBrains.Application.ChangeManager changeManager, JetBrains.Application.IShellLocks locks, JetBrains.ReSharper.Psi.Web.BuildProviders.IWebsiteBuilders builders, JetBrains.DocumentManagers.DocumentManager documentManager, JetBrains.ReSharper.Psi.PsiProjectFileTypeCoordinator psiProjectFileTypeCoordinator, JetBrains.ReSharper.Psi.Web.PsiModules.IWebAssemblyReferenceFactory webAssemblyReferenceFactory, JetBrains.ReSharper.Psi.PsiSourceFilePropertiesManager propertiesManager) { }
        public double Priority { get; }
        public JetBrains.DataFlow.ISimpleSignal ReferencesChanged { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IPsiSourceFile> FindPsiSourceFiles(JetBrains.ProjectModel.IProjectFile projectFile) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Modules.IPsiModule> GetAllModules() { }
        public void GetCommonReferencesFor(JetBrains.ReSharper.Psi.Modules.IPsiModule psiModule, JetBrains.ReSharper.Psi.Web.Impl.PsiModules.PsiModuleReferenceAccumulator referenceAccumulator) { }
        public bool InternalsVisibleTo(JetBrains.ReSharper.Psi.Modules.IPsiModule moduleTo, JetBrains.ReSharper.Psi.Modules.IPsiModule moduleFrom) { }
        public void OnExternalModuleSetChanged(JetBrains.ReSharper.Psi.Modules.PsiModuleChangeBuilder changeBuilder) { }
        public bool OnProjectFileAdded(JetBrains.ProjectModel.IProjectFile projectFile, JetBrains.ReSharper.Psi.Modules.PsiModuleChangeBuilder changeBuilder, System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Web.Impl.PsiModules.IWebPsiModuleHandlerHelper> alreadyProcessedBy) { }
        public void OnProjectFileModified(JetBrains.ProjectModel.IProjectFile projectFile, JetBrains.ReSharper.Psi.Modules.PsiModuleChangeBuilder changeBuilder) { }
        public void OnProjectFileRemoved(JetBrains.ProjectModel.IProjectFile projectFile, JetBrains.ReSharper.Psi.Modules.PsiModuleChangeBuilder changeBuilder) { }
        public void OnProjectPropertiesChange(JetBrains.ReSharper.Psi.Modules.PsiModuleChangeBuilder changeBuilder) { }
    }
    [JetBrains.ReSharper.Psi.Web.Impl.PsiModules.Website.WebsitePsiModuleHandlerHelperFactoryAttribute()]
    public class WebsiteGlobalResourcesHelperFactory : JetBrains.ReSharper.Psi.Web.Impl.PsiModules.IWebPsiModuleHandlerHelperFactory, JetBrains.ReSharper.Psi.Web.Impl.PsiModules.Website.IWebsitePsiModuleHandlerHelperFactory
    {
        public WebsiteGlobalResourcesHelperFactory(JetBrains.ReSharper.Psi.Web.Impl.PsiModules.Website.WebProjectFileTypeClassifier webProjectFileTypeClassifier, JetBrains.ProjectModel.IProjectFileExtensions projectFileExtensions, JetBrains.Application.ChangeManager changeManager, JetBrains.Application.IShellLocks shellLocks, JetBrains.ReSharper.Psi.Web.BuildProviders.IWebsiteBuilders websiteBuilders, JetBrains.DocumentManagers.DocumentManager documentManager, JetBrains.ReSharper.Psi.PsiProjectFileTypeCoordinator psiProjectFileTypeCoordinator, JetBrains.ReSharper.Psi.Web.PsiModules.IWebAssemblyReferenceFactory webAssemblyReferenceFactory, JetBrains.ReSharper.Psi.PsiSourceFilePropertiesManager propertiesManager) { }
        public JetBrains.ReSharper.Psi.Web.Impl.PsiModules.IWebPsiModuleHandlerHelper CreateHelper(JetBrains.DataFlow.Lifetime helperLifetime, JetBrains.ReSharper.Psi.Web.Impl.PsiModules.IWebProjectPsiModuleHandler handler, JetBrains.ReSharper.Psi.Web.Cache.IWebConfigCache webConfigCache, JetBrains.ReSharper.Psi.Web.PsiModules.IAspFileDataCache aspFileDataCache) { }
    }
    public class WebsiteOtherFilesHelper : JetBrains.ReSharper.Psi.Web.Impl.PsiModules.IWebPsiModuleHandlerHelper
    {
        public WebsiteOtherFilesHelper(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ReSharper.Psi.Web.Impl.PsiModules.IWebProjectPsiModuleHandler handler, JetBrains.ReSharper.Psi.IPsiConfiguration psiConfiguration, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Psi.PsiProjectFileTypeCoordinator psiProjectFileTypeCoordinator, JetBrains.ReSharper.Psi.PsiSourceFilePropertiesManager propertiesManager) { }
        public double Priority { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IPsiSourceFile> FindPsiSourceFiles(JetBrains.ProjectModel.IProjectFile projectFile) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Modules.IPsiModule> GetAllModules() { }
        public bool InternalsVisibleTo(JetBrains.ReSharper.Psi.Modules.IPsiModule moduleTo, JetBrains.ReSharper.Psi.Modules.IPsiModule moduleFrom) { }
        public void OnExternalModuleSetChanged(JetBrains.ReSharper.Psi.Modules.PsiModuleChangeBuilder changeBuilder) { }
        public bool OnProjectFileAdded(JetBrains.ProjectModel.IProjectFile projectFile, JetBrains.ReSharper.Psi.Modules.PsiModuleChangeBuilder changeBuilder, System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Web.Impl.PsiModules.IWebPsiModuleHandlerHelper> alreadyProcessedBy) { }
        public void OnProjectFileModified(JetBrains.ProjectModel.IProjectFile projectFile, JetBrains.ReSharper.Psi.Modules.PsiModuleChangeBuilder changeBuilder) { }
        public void OnProjectFileRemoved(JetBrains.ProjectModel.IProjectFile projectFile, JetBrains.ReSharper.Psi.Modules.PsiModuleChangeBuilder changeBuilder) { }
        public void OnProjectPropertiesChange(JetBrains.ReSharper.Psi.Modules.PsiModuleChangeBuilder changeBuilder) { }
    }
    [JetBrains.ReSharper.Psi.Web.Impl.PsiModules.Website.WebsitePsiModuleHandlerHelperFactoryAttribute()]
    public class WebsiteOtherFilesHelperFactory : JetBrains.ReSharper.Psi.Web.Impl.PsiModules.IWebPsiModuleHandlerHelperFactory, JetBrains.ReSharper.Psi.Web.Impl.PsiModules.Website.IWebsitePsiModuleHandlerHelperFactory
    {
        public WebsiteOtherFilesHelperFactory(JetBrains.ReSharper.Psi.IPsiConfiguration psiConfiguration, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Psi.PsiProjectFileTypeCoordinator psiProjectFileTypeCoordinator, JetBrains.ReSharper.Psi.PsiSourceFilePropertiesManager propertiesManager) { }
        public JetBrains.ReSharper.Psi.Web.Impl.PsiModules.IWebPsiModuleHandlerHelper CreateHelper(JetBrains.DataFlow.Lifetime helperLifetime, JetBrains.ReSharper.Psi.Web.Impl.PsiModules.IWebProjectPsiModuleHandler handler, JetBrains.ReSharper.Psi.Web.Cache.IWebConfigCache webConfigCache, JetBrains.ReSharper.Psi.Web.PsiModules.IAspFileDataCache aspFileDataCache) { }
    }
}
namespace JetBrains.ReSharper.Psi.Asp.Impl.PsiModules.Website.Modules
{
    
    public class AspFilePsiModule : JetBrains.ReSharper.Psi.Modules.ProjectPsiModuleBase, JetBrains.ReSharper.Psi.Asp.Impl.PsiModules.Website.Modules.IAspFilePsiModule, JetBrains.ReSharper.Psi.Modules.IProjectPsiModule, JetBrains.ReSharper.Psi.Modules.IPsiModule, JetBrains.ReSharper.Psi.Web.Impl.PsiModules.Website.Modules.IWebsitePsiModule, JetBrains.ReSharper.Psi.Web.Impl.WebConfig.PsiModules.Website.Modules.IWebConfigReferenceConsumerModule, System.IDisposable
    {
        public AspFilePsiModule([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IProjectFile projectFile, JetBrains.ReSharper.Psi.Web.Impl.PsiModules.IWebProjectPsiModuleHandler handler, JetBrains.ReSharper.Psi.Asp.Impl.PsiModules.WebAspFilesHelperBase aspFilesHelper, JetBrains.ReSharper.Psi.Web.PsiModules.IWebAssemblyReferenceFactory assemblyReferenceFactory, JetBrains.ReSharper.Psi.Web.PsiModules.IAspFileDataCache aspFileDataCache, JetBrains.ReSharper.Psi.Web.Util.WebPsiLanguageUtil webPsiLanguageUtil, JetBrains.ReSharper.Psi.PsiProjectFileTypeCoordinator psiProjectFileTypeCoordinator) { }
        public override string DisplayName { get; }
        public JetBrains.ProjectModel.IProjectItem MainProjectItem { get; }
        public override JetBrains.ProjectModel.ProjectFileType ProjectFileType { get; }
        public override JetBrains.ReSharper.Psi.PsiLanguageType PsiLanguage { get; }
        public void Dispose() { }
        public override System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.PreProcessingDirective> GetAllDefines() { }
        protected override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Modules.IPsiModuleReference> GetReferencesInternal() { }
        public void OnProjectFileModified(JetBrains.ProjectModel.IProjectFile projectFile) { }
        public void ProcessDiff(JetBrains.ReSharper.Psi.Web.PsiModules.IAspFileDataDiff diff, JetBrains.ReSharper.Psi.Modules.PsiModuleChangeBuilder changeBuilder) { }
    }
    public interface IAspFilePsiModule : JetBrains.ReSharper.Psi.Modules.IProjectPsiModule, JetBrains.ReSharper.Psi.Modules.IPsiModule, JetBrains.ReSharper.Psi.Web.Impl.PsiModules.Website.Modules.IWebsitePsiModule, JetBrains.ReSharper.Psi.Web.Impl.WebConfig.PsiModules.Website.Modules.IWebConfigReferenceConsumerModule, System.IDisposable
    {
        void ProcessDiff(JetBrains.ReSharper.Psi.Web.PsiModules.IAspFileDataDiff diff, JetBrains.ReSharper.Psi.Modules.PsiModuleChangeBuilder changeBuilder);
    }
    public interface IOrphanFilesModule : JetBrains.ReSharper.Psi.Modules.IPsiModule, JetBrains.ReSharper.Psi.Web.Impl.PsiModules.Website.Modules.IWebsitePsiModule { }
    public class OrphanFilesPsiModule : JetBrains.ReSharper.Psi.Modules.ProjectPsiModuleBase, JetBrains.ReSharper.Psi.Asp.Impl.PsiModules.Website.Modules.IOrphanFilesModule, JetBrains.ReSharper.Psi.Modules.IPsiModule, JetBrains.ReSharper.Psi.Web.Impl.PsiModules.Website.Modules.IWebsitePsiModule
    {
        public OrphanFilesPsiModule([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IProject project, [JetBrains.Annotations.CanBeNullAttribute()] string additionalName, JetBrains.ReSharper.Psi.PsiProjectFileTypeCoordinator psiProjectFileTypeCoordinator) { }
        protected override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Modules.IPsiModuleReference> GetReferencesInternal() { }
    }
    public class WebCustomBuildProvidersOutputModule : JetBrains.ReSharper.Psi.Web.Impl.PsiModules.Website.Modules.WebModuleWithGeneratedFiles, JetBrains.ReSharper.Psi.Modules.IPsiModule, JetBrains.ReSharper.Psi.Web.Impl.PsiModules.Website.Modules.IWebsitePsiModule
    {
        public WebCustomBuildProvidersOutputModule(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ReSharper.Psi.Web.Impl.PsiModules.IWebProjectPsiModuleHandler handler, JetBrains.Util.FileSystemPath generatedFilesFolder, JetBrains.ProjectModel.IProjectFileExtensions projectFileExtensions, JetBrains.ReSharper.Psi.PsiProjectFileTypeCoordinator coordinator, JetBrains.DocumentManagers.DocumentManager documentManager, JetBrains.ReSharper.Psi.PsiProjectFileTypeCoordinator psiProjectFileTypeCoordinator, JetBrains.ReSharper.Psi.Web.PsiModules.IWebAssemblyReferenceFactory webAssemblyReferenceFactory) { }
        protected override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Modules.IPsiModuleReference> GetReferencesInternal() { }
    }
    public class WebsiteGlobalResourcesModule : JetBrains.ReSharper.Psi.Web.Impl.PsiModules.Website.Modules.WebModuleWithGeneratedFiles, JetBrains.ReSharper.Psi.Modules.IPsiModule, JetBrains.ReSharper.Psi.Web.Impl.PsiModules.Website.Modules.IWebsitePsiModule
    {
        public WebsiteGlobalResourcesModule(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ReSharper.Psi.Web.Impl.PsiModules.IWebProjectPsiModuleHandler handler, JetBrains.Util.FileSystemPath generatedFilesFolder, JetBrains.ProjectModel.IProjectFileExtensions projectFileExtensions, JetBrains.ReSharper.Psi.PsiProjectFileTypeCoordinator psiProjectFileTypeCoordinator, JetBrains.DocumentManagers.DocumentManager documentManager, JetBrains.ReSharper.Psi.Web.PsiModules.IWebAssemblyReferenceFactory webAssemblyReferenceFactory) { }
        protected override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Modules.IPsiModuleReference> GetReferencesInternal() { }
    }
    public class WebsiteOtherFilesModule : JetBrains.ReSharper.Psi.Modules.ProjectPsiModuleBase
    {
        public WebsiteOtherFilesModule(JetBrains.ReSharper.Psi.Web.Impl.PsiModules.IWebProjectPsiModuleHandler handler, JetBrains.ReSharper.Psi.PsiProjectFileTypeCoordinator psiProjectFileTypeCoordinator) { }
        protected override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Modules.IPsiModuleReference> GetReferencesInternal() { }
    }
}
namespace JetBrains.ReSharper.Psi.Asp.Impl.PsiModules.Website.Properties
{
    
    public interface IWebsiteAsxxPsiSourceFilePropertiesFactory
    {
        JetBrains.ReSharper.Psi.IPsiSourceFileProperties CreateProperties(JetBrains.ProjectModel.IProjectFile projectFile, JetBrains.ReSharper.Psi.IPsiSourceFile psiSourceFile, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.PsiSourceFilePropertiesManager defaulLanguageService, JetBrains.ReSharper.Psi.Web.Cache.IWebConfigCache webConfigCache);
    }
    public interface IWebsiteCodeBehindPsiSourceFilePropertiesFactory
    {
        JetBrains.ReSharper.Psi.IPsiSourceFileProperties CreateProperties(JetBrains.ProjectModel.IProjectFile projectFile, JetBrains.ReSharper.Psi.IPsiSourceFile psiSourceFile, JetBrains.ReSharper.Psi.PsiSourceFilePropertiesManager propertiesManager, JetBrains.ReSharper.Psi.Web.Cache.IWebConfigCache webConfigCache);
    }
    public class WebsiteAspPsiSourceFileProperties : JetBrains.ReSharper.Psi.Web.Impl.PsiModules.Website.Properties.WebsitePsiSourceFileProperties
    {
        public WebsiteAspPsiSourceFileProperties(JetBrains.ProjectModel.IProjectFile projectFile, JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, JetBrains.ReSharper.Psi.PsiSourceFilePropertiesManager propertiesManager, JetBrains.ReSharper.Psi.Web.Cache.IWebConfigCache configCache) { }
        public override string GetDefaultNamespace() { }
        public override System.Collections.Generic.IEnumerable<string> GetPreImportedNamespaces() { }
    }
    public class WebsiteCodeBehindPsiSourceFileProperties : JetBrains.ReSharper.Psi.Web.Impl.PsiModules.Website.Properties.WebsitePsiSourceFileProperties
    {
        public WebsiteCodeBehindPsiSourceFileProperties(JetBrains.ProjectModel.IProjectFile projectFile, JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, JetBrains.ReSharper.Psi.PsiSourceFilePropertiesManager propertiesManager) { }
        public override string GetDefaultNamespace() { }
        public override System.Collections.Generic.IEnumerable<string> GetPreImportedNamespaces() { }
    }
}
namespace JetBrains.ReSharper.Psi.Asp.Impl.References
{
    
    [JetBrains.ReSharper.Psi.Resolve.ReferenceProviderFactoryAttribute()]
    public class AspBoolAttributeValueReferenceProvider : JetBrains.ReSharper.Psi.Html.Impl.References.HtmlAttributeValueReferenceFactoryBase<JetBrains.ReSharper.Psi.Asp.Html.IAspDeclaredElementTypes, JetBrains.ProjectModel.AspProjectFileType>
    {
        public AspBoolAttributeValueReferenceProvider(JetBrains.ReSharper.Psi.Asp.Html.IAspDeclaredElementTypes aspDeclaredElementTypes) { }
        protected override JetBrains.ReSharper.Psi.Resolve.IReference[] CreateReferences(JetBrains.ReSharper.Psi.Html.Impl.References.HtmlAttributeValueEntry entry) { }
        public override bool IsApplicable(JetBrains.ReSharper.Psi.Html.Impl.References.HtmlAttributeValueEntry entry) { }
    }
    [JetBrains.ReSharper.Psi.Resolve.ReferenceProviderFactoryAttribute()]
    public class AspContentPlaceholderIdAttributeValueReferenceProvider : JetBrains.ReSharper.Psi.Html.Impl.References.HtmlAttributeValueReferenceFactoryBase<JetBrains.ReSharper.Psi.Asp.Html.IAspDeclaredElementTypes, JetBrains.ProjectModel.AspProjectFileType>, JetBrains.ReSharper.Psi.Asp.Impl.References.IAspControlIdReferenceOverride
    {
        public AspContentPlaceholderIdAttributeValueReferenceProvider(JetBrains.ReSharper.Psi.Asp.Html.IAspDeclaredElementTypes aspDeclaredElementTypes) { }
        protected override JetBrains.ReSharper.Psi.Resolve.IReference[] CreateReferences(JetBrains.ReSharper.Psi.Html.Impl.References.HtmlAttributeValueEntry entry) { }
        public override bool IsApplicable(JetBrains.ReSharper.Psi.Html.Impl.References.HtmlAttributeValueEntry entry) { }
    }
    [JetBrains.ReSharper.Psi.Resolve.ReferenceProviderFactoryAttribute()]
    public class AspControlIdReferenceAttributeValueReferenceProvider : JetBrains.ReSharper.Psi.Html.Impl.References.HtmlAttributeValueReferenceFactoryBase<System.Func<JetBrains.ReSharper.Psi.IDeclaredType, JetBrains.ReSharper.Psi.Resolve.ResolveErrorType>, JetBrains.ReSharper.Psi.Asp.Html.IAspDeclaredElementTypes, JetBrains.ProjectModel.AspProjectFileType>
    {
        public AspControlIdReferenceAttributeValueReferenceProvider(JetBrains.ReSharper.Psi.Asp.Html.IAspDeclaredElementTypes aspDeclaredElementTypes, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Asp.Impl.References.IAspControlIdReferenceOverride> overrides) { }
        protected override bool CanHaveReference(JetBrains.ReSharper.Psi.Html.Impl.References.HtmlAttributeValueEntry entry, System.Func<JetBrains.ReSharper.Psi.IDeclaredType, JetBrains.ReSharper.Psi.Resolve.ResolveErrorType> controlTypeValidator, System.Collections.Generic.IEnumerable<string> names) { }
        protected override JetBrains.ReSharper.Psi.Resolve.IReference[] CreateReferences(JetBrains.ReSharper.Psi.Html.Impl.References.HtmlAttributeValueEntry entry, System.Func<JetBrains.ReSharper.Psi.IDeclaredType, JetBrains.ReSharper.Psi.Resolve.ResolveErrorType> controlTypeValidator) { }
        public override bool IsApplicable(JetBrains.ReSharper.Psi.Html.Impl.References.HtmlAttributeValueEntry entry, out System.Func<, > controlTypeValidator) { }
    }
    [JetBrains.ReSharper.Psi.Resolve.ReferenceProviderFactoryAttribute()]
    public class AspCreateTypeReferenceAttributeValueReferenceProvider : JetBrains.ReSharper.Psi.Html.Impl.References.HtmlAttributeValueReferenceFactoryBase<bool, JetBrains.ReSharper.Psi.Asp.Html.IAspDeclaredElementTypes, JetBrains.ProjectModel.AspProjectFileType>
    {
        public AspCreateTypeReferenceAttributeValueReferenceProvider(JetBrains.ReSharper.Psi.Asp.Html.IAspDeclaredElementTypes aspDeclaredElementTypes, JetBrains.ReSharper.Psi.Asp.Utils.AspAttributesCache aspAttributesCache) { }
        protected override bool CanHaveReference(JetBrains.ReSharper.Psi.Html.Impl.References.HtmlAttributeValueEntry entry, bool doCreateConstructorReference, System.Collections.Generic.IEnumerable<string> names) { }
        protected override JetBrains.ReSharper.Psi.Resolve.IReference[] CreateReferences(JetBrains.ReSharper.Psi.Html.Impl.References.HtmlAttributeValueEntry entry, bool doCreateConstructorReference) { }
        public override bool IsApplicable(JetBrains.ReSharper.Psi.Html.Impl.References.HtmlAttributeValueEntry entry, out bool doCreateConstructorReference) { }
    }
    [JetBrains.ReSharper.Psi.Resolve.ReferenceProviderFactoryAttribute()]
    public class AspDataFieldAttributeValueReferenceProvider : JetBrains.ReSharper.Psi.Html.Impl.References.HtmlAttributeValueReferenceFactoryBase<JetBrains.ReSharper.Psi.Asp.Html.IAspDeclaredElementTypes, JetBrains.ProjectModel.AspProjectFileType>
    {
        public AspDataFieldAttributeValueReferenceProvider(JetBrains.ReSharper.Psi.Asp.Html.IAspDeclaredElementTypes aspDeclaredElementTypes, JetBrains.ReSharper.Psi.Asp.Utils.AspAttributesCache aspAttributesCache) { }
        protected override JetBrains.ReSharper.Psi.Resolve.IReference[] CreateReferences(JetBrains.ReSharper.Psi.Html.Impl.References.HtmlAttributeValueEntry entry) { }
        public override bool IsApplicable(JetBrains.ReSharper.Psi.Html.Impl.References.HtmlAttributeValueEntry entry) { }
    }
    [JetBrains.ReSharper.Psi.Resolve.ReferenceProviderFactoryAttribute()]
    public class AspDataFieldsAttributeValueReferenceProvider : JetBrains.ReSharper.Psi.Html.Impl.References.HtmlAttributeValueReferenceFactoryBase<JetBrains.ReSharper.Psi.Asp.Html.IAspDeclaredElementTypes, JetBrains.ProjectModel.AspProjectFileType>
    {
        public AspDataFieldsAttributeValueReferenceProvider(JetBrains.ReSharper.Psi.Asp.Html.IAspDeclaredElementTypes aspDeclaredElementTypes, JetBrains.ReSharper.Psi.Asp.Utils.AspAttributesCache aspAttributesCache) { }
        protected override bool CanHaveReference(JetBrains.ReSharper.Psi.Html.Impl.References.HtmlAttributeValueEntry entry, System.Collections.Generic.IEnumerable<string> names) { }
        protected override JetBrains.ReSharper.Psi.Resolve.IReference[] CreateReferences(JetBrains.ReSharper.Psi.Html.Impl.References.HtmlAttributeValueEntry entry) { }
        public override bool IsApplicable(JetBrains.ReSharper.Psi.Html.Impl.References.HtmlAttributeValueEntry entry) { }
    }
    [JetBrains.ReSharper.Psi.Resolve.ReferenceProviderFactoryAttribute()]
    public class AspDataSourceIdAttributeValueReferenceProvider : JetBrains.ReSharper.Psi.Html.Impl.References.HtmlAttributeValueReferenceFactoryBase<JetBrains.ReSharper.Psi.Asp.Html.IAspDeclaredElementTypes, JetBrains.ProjectModel.AspProjectFileType>, JetBrains.ReSharper.Psi.Asp.Impl.References.IAspControlIdReferenceOverride
    {
        public AspDataSourceIdAttributeValueReferenceProvider(JetBrains.ReSharper.Psi.Asp.Html.IAspDeclaredElementTypes aspDeclaredElementTypes) { }
        protected override JetBrains.ReSharper.Psi.Resolve.IReference[] CreateReferences(JetBrains.ReSharper.Psi.Html.Impl.References.HtmlAttributeValueEntry entry) { }
        public override bool IsApplicable(JetBrains.ReSharper.Psi.Html.Impl.References.HtmlAttributeValueEntry entry) { }
    }
    [JetBrains.ReSharper.Psi.Resolve.ReferenceProviderFactoryAttribute()]
    public class AspDevExpressTypeAttributeValueReferenceProvider : JetBrains.ReSharper.Psi.Html.Impl.References.HtmlAttributeValueReferenceFactoryBase<JetBrains.Util.Pair<string, string>, JetBrains.ReSharper.Psi.Asp.Html.IAspDeclaredElementTypes, JetBrains.ProjectModel.AspProjectFileType>
    {
        public AspDevExpressTypeAttributeValueReferenceProvider(JetBrains.ReSharper.Psi.Asp.Html.IAspDeclaredElementTypes aspDeclaredElementTypes) { }
        protected override JetBrains.ReSharper.Psi.Resolve.IReference[] CreateReferences(JetBrains.ReSharper.Psi.Html.Impl.References.HtmlAttributeValueEntry entry, JetBrains.Util.Pair<string, string> data) { }
        public override bool IsApplicable(JetBrains.ReSharper.Psi.Html.Impl.References.HtmlAttributeValueEntry entry, out JetBrains.Util.Pair<, > data) { }
    }
    [JetBrains.ReSharper.Psi.Resolve.ReferenceProviderFactoryAttribute()]
    public class AspEnumAttributeValueReferenceProvider : JetBrains.ReSharper.Psi.Html.Impl.References.HtmlAttributeValueReferenceFactoryBase<JetBrains.ReSharper.Psi.IEnum, JetBrains.ReSharper.Psi.Asp.Html.IAspDeclaredElementTypes, JetBrains.ProjectModel.AspProjectFileType>
    {
        public AspEnumAttributeValueReferenceProvider(JetBrains.ReSharper.Psi.Asp.Html.IAspDeclaredElementTypes aspDeclaredElementTypes) { }
        protected override bool CanHaveReference(JetBrains.ReSharper.Psi.Html.Impl.References.HtmlAttributeValueEntry entry, JetBrains.ReSharper.Psi.IEnum data, System.Collections.Generic.IEnumerable<string> names) { }
        protected override JetBrains.ReSharper.Psi.Resolve.IReference[] CreateReferences(JetBrains.ReSharper.Psi.Html.Impl.References.HtmlAttributeValueEntry entry, JetBrains.ReSharper.Psi.IEnum data) { }
        public override bool IsApplicable(JetBrains.ReSharper.Psi.Html.Impl.References.HtmlAttributeValueEntry entry, out JetBrains.ReSharper.Psi.IEnum data) { }
    }
    [JetBrains.ReSharper.Psi.Resolve.ReferenceProviderFactoryAttribute()]
    public class AspEventAttributeValueReferenceProvider : JetBrains.ReSharper.Psi.Html.Impl.References.HtmlAttributeValueReferenceFactoryBase<JetBrains.ReSharper.Psi.DeclaredElementInstance<JetBrains.ReSharper.Psi.IEvent>, JetBrains.ReSharper.Psi.Asp.Html.IAspDeclaredElementTypes, JetBrains.ProjectModel.AspProjectFileType>
    {
        public AspEventAttributeValueReferenceProvider(JetBrains.ReSharper.Psi.Asp.Html.IAspDeclaredElementTypes aspDeclaredElementTypes) { }
        protected override JetBrains.ReSharper.Psi.Resolve.IReference[] CreateReferences(JetBrains.ReSharper.Psi.Html.Impl.References.HtmlAttributeValueEntry entry, JetBrains.ReSharper.Psi.DeclaredElementInstance<JetBrains.ReSharper.Psi.IEvent> data) { }
        public override bool IsApplicable(JetBrains.ReSharper.Psi.Html.Impl.References.HtmlAttributeValueEntry entry, out JetBrains.ReSharper.Psi.DeclaredElementInstance<> data) { }
    }
    public sealed class AspFileLateBoundReference<TOwner, TToken> : JetBrains.ReSharper.Psi.Html.Impl.References.HtmlFileLateBoundReference<TOwner, TToken>
        where TOwner : JetBrains.ReSharper.Psi.Tree.ITreeNode
        where TToken :  class, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        public AspFileLateBoundReference(TOwner owner, JetBrains.ReSharper.Psi.Resolve.IQualifier qualifier, TToken token, JetBrains.ReSharper.Psi.TreeTextRange rangeWithin) { }
        public override bool CanBeMappedOrIgnored { get; }
        public override bool IsWebRootPathSupported() { }
    }
    public sealed class AspFileReference<TOwner, TToken> : JetBrains.ReSharper.Psi.Html.Impl.References.HtmlFileReference<TOwner, TToken>
        where TOwner : JetBrains.ReSharper.Psi.Tree.ITreeNode
        where TToken :  class, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        public AspFileReference(TOwner owner, JetBrains.ReSharper.Psi.Resolve.IQualifier qualifier, TToken token, JetBrains.ReSharper.Psi.TreeTextRange rangeWithin, JetBrains.ProjectModel.ProjectFileType expectedFileType, System.Collections.Generic.ICollection<string> expectedExtensions, bool noCircular) { }
        public override bool CanBeMappedOrIgnored { get; }
        public override bool IsWebRootPathSupported() { }
    }
    public sealed class AspFolderLateBoundReference<TOwner, TToken> : JetBrains.ReSharper.Psi.Html.Impl.References.HtmlFolderLateBoundReference<TOwner, TToken>
        where TOwner : JetBrains.ReSharper.Psi.Tree.ITreeNode
        where TToken :  class, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        public AspFolderLateBoundReference(TOwner owner, JetBrains.ReSharper.Psi.Resolve.IQualifier qualifier, TToken token, JetBrains.ReSharper.Psi.TreeTextRange rangeWithin) { }
        public override bool IsWebRootPathSupported() { }
    }
    public sealed class AspFolderReference<TOwner, TToken> : JetBrains.ReSharper.Psi.Html.Impl.References.HtmlFolderReference<TOwner, TToken>
        where TOwner : JetBrains.ReSharper.Psi.Tree.ITreeNode
        where TToken :  class, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        public AspFolderReference(TOwner owner, JetBrains.ReSharper.Psi.Resolve.IQualifier qualifier, TToken token, JetBrains.ReSharper.Psi.TreeTextRange rangeWithin) { }
        public override bool CanBeMappedOrIgnored { get; }
        public override bool IsWebRootPathSupported() { }
    }
    public class AspGeneratedCodeReferenceFactory : JetBrains.ReSharper.Psi.Resolve.IReferenceFactory
    {
        public AspGeneratedCodeReferenceFactory(JetBrains.ReSharper.Psi.Asp.Html.IAspDeclaredElementTypes aspDeclaredElementTypes) { }
        public JetBrains.ReSharper.Psi.Resolve.IReference[] GetReferences(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.Resolve.IReference[] oldReferences) { }
        public bool HasReference(JetBrains.ReSharper.Psi.Tree.ITreeNode element, System.Collections.Generic.ICollection<string> names) { }
    }
    public abstract class AspGeneratedCodeReferenceProviderFactory<TFile> : JetBrains.ReSharper.Psi.Resolve.IReferenceProviderFactory
        where TFile : JetBrains.ReSharper.Psi.Tree.IFile
    {
        protected AspGeneratedCodeReferenceProviderFactory(JetBrains.ReSharper.Psi.Asp.Html.IAspDeclaredElementTypes aspDeclaredElementTypes) { }
        public event System.Action OnChanged;
        public JetBrains.ReSharper.Psi.Resolve.IReferenceFactory CreateFactory(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, JetBrains.ReSharper.Psi.Tree.IFile file) { }
    }
    [JetBrains.ReSharper.Psi.Resolve.ReferenceProviderFactoryAttribute()]
    public class AspHtmlEnumAttributeValueReferenceProvider : JetBrains.ReSharper.Psi.Html.Impl.References.HtmlAttributeValueReferenceFactoryBase<JetBrains.ReSharper.Psi.Html.Html.IHtmlEnumAttributeValueType, JetBrains.ReSharper.Psi.Asp.Html.IAspDeclaredElementTypes, JetBrains.ProjectModel.AspProjectFileType>, JetBrains.ReSharper.Psi.Html.Impl.References.IHtmlEnumReferenceProviderOverride
    {
        public AspHtmlEnumAttributeValueReferenceProvider(JetBrains.ReSharper.Psi.Asp.Html.IAspDeclaredElementTypes aspDeclaredElementTypes) { }
        protected override JetBrains.ReSharper.Psi.Resolve.IReference[] CreateReferences(JetBrains.ReSharper.Psi.Html.Impl.References.HtmlAttributeValueEntry entry, JetBrains.ReSharper.Psi.Html.Html.IHtmlEnumAttributeValueType htmlEnumType) { }
        public override bool IsApplicable(JetBrains.ReSharper.Psi.Html.Impl.References.HtmlAttributeValueEntry entry, out JetBrains.ReSharper.Psi.Html.Html.IHtmlEnumAttributeValueType htmlEnumType) { }
    }
    public class AspMethodReference : JetBrains.ReSharper.Psi.Html.Impl.References.HtmlReferenceWithinElementBase<JetBrains.ReSharper.Psi.Html.Tree.IHtmlAttributeValue>, JetBrains.ReSharper.Psi.Asp.References.IAspMethodReference, JetBrains.ReSharper.Psi.Html.References.IHtmlCompleteableReference, JetBrains.ReSharper.Psi.Html.References.IHtmlSmartCompleteableReference, JetBrains.ReSharper.Psi.Resolve.ICompleteableReference, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.Util.IUserDataHolder
    {
        public AspMethodReference(JetBrains.ReSharper.Psi.Asp.Html.IAspDeclaredElementTypes declaredElementTypes, JetBrains.ReSharper.Psi.Html.Tree.IHtmlAttributeValue owner, JetBrains.ReSharper.Psi.Html.Tree.IHtmlToken token) { }
        protected override JetBrains.ReSharper.Psi.Resolve.ISymbolFilter[] GetCompletionFilters() { }
        public System.Collections.Generic.IEnumerable<JetBrains.Util.Pair<JetBrains.ReSharper.Psi.IType, string>> GetParameterTypes() { }
        public JetBrains.ReSharper.Psi.IDeclaredType GetQualifierType() { }
        public override JetBrains.ReSharper.Psi.ITypeElement GetQualifierTypeElement() { }
        public override JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetReferenceSymbolTable(bool useReferenceName) { }
        public JetBrains.ReSharper.Psi.IType GetReturnType() { }
        public override JetBrains.ReSharper.Psi.Resolve.Staticness GetStaticness() { }
    }
    [JetBrains.ReSharper.Psi.Resolve.ReferenceProviderFactoryAttribute()]
    public class AspMethodReferenceAttributeValueReferenceProvider : JetBrains.ReSharper.Psi.Html.Impl.References.HtmlAttributeValueReferenceFactoryBase<JetBrains.ReSharper.Psi.Asp.Html.IAspDeclaredElementTypes, JetBrains.ProjectModel.AspProjectFileType>
    {
        public AspMethodReferenceAttributeValueReferenceProvider(JetBrains.ReSharper.Psi.Asp.Html.IAspDeclaredElementTypes declaredElementTypes, JetBrains.ReSharper.Psi.Asp.Utils.AspAttributesCache aspAttributesCache) { }
        protected override JetBrains.ReSharper.Psi.Resolve.IReference[] CreateReferences(JetBrains.ReSharper.Psi.Html.Impl.References.HtmlAttributeValueEntry entry) { }
        public override bool IsApplicable(JetBrains.ReSharper.Psi.Html.Impl.References.HtmlAttributeValueEntry entry) { }
    }
    [JetBrains.ReSharper.Psi.Resolve.ReferenceProviderFactoryAttribute()]
    public class AspOdsMethodAttributeValueReferenceProvider : JetBrains.ReSharper.Psi.Html.Impl.References.HtmlAttributeValueReferenceFactoryBase<JetBrains.ReSharper.Psi.Asp.Html.IAspDeclaredElementTypes, JetBrains.ProjectModel.AspProjectFileType>
    {
        public AspOdsMethodAttributeValueReferenceProvider(JetBrains.ReSharper.Psi.Search.SearchDomainFactory searchDomainFactory, JetBrains.ReSharper.Psi.Asp.Html.IAspDeclaredElementTypes aspDeclaredElementTypes) { }
        protected override JetBrains.ReSharper.Psi.Resolve.IReference[] CreateReferences(JetBrains.ReSharper.Psi.Html.Impl.References.HtmlAttributeValueEntry entry) { }
        public override bool IsApplicable(JetBrains.ReSharper.Psi.Html.Impl.References.HtmlAttributeValueEntry entry) { }
    }
    [JetBrains.ReSharper.Psi.Resolve.ReferenceProviderFactoryAttribute()]
    public class AspOdsMethodParameterAttributeValueReferenceProvider : JetBrains.ReSharper.Psi.Html.Impl.References.HtmlAttributeValueReferenceFactoryBase<JetBrains.ReSharper.Psi.Asp.Html.IAspDeclaredElementTypes, JetBrains.ProjectModel.AspProjectFileType>
    {
        public AspOdsMethodParameterAttributeValueReferenceProvider(JetBrains.ReSharper.Psi.Asp.Html.IAspDeclaredElementTypes aspDeclaredElementTypes) { }
        protected override JetBrains.ReSharper.Psi.Resolve.IReference[] CreateReferences(JetBrains.ReSharper.Psi.Html.Impl.References.HtmlAttributeValueEntry entry) { }
        public override bool IsApplicable(JetBrains.ReSharper.Psi.Html.Impl.References.HtmlAttributeValueEntry entry) { }
    }
    public class static AspPathReferenceUtil
    {
        public static bool IsWebRootPathSupported([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Resolve.IPathReference reference) { }
    }
    [JetBrains.ReSharper.Psi.Resolve.ReferenceProviderFactoryAttribute()]
    public class AspSkinIdAttributeValueReferenceProvider : JetBrains.ReSharper.Psi.Html.Impl.References.HtmlAttributeValueReferenceFactoryBase<JetBrains.ReSharper.Psi.Asp.Html.IAspDeclaredElementTypes, JetBrains.ProjectModel.AspProjectFileType>
    {
        public AspSkinIdAttributeValueReferenceProvider(JetBrains.ReSharper.Psi.Asp.Html.IAspDeclaredElementTypes declaredElementTypes, JetBrains.ReSharper.Psi.Search.SearchDomainFactory searchDomainFactory) { }
        protected override JetBrains.ReSharper.Psi.Resolve.IReference[] CreateReferences(JetBrains.ReSharper.Psi.Html.Impl.References.HtmlAttributeValueEntry entry) { }
        public override bool IsApplicable(JetBrains.ReSharper.Psi.Html.Impl.References.HtmlAttributeValueEntry entry) { }
        public override bool IsApplicableToFile(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, JetBrains.ReSharper.Psi.Tree.IFile file) { }
    }
    [JetBrains.ReSharper.Psi.Resolve.ReferenceProviderFactoryAttribute()]
    public class AspUrlAttributeValueReferenceProvider : JetBrains.ReSharper.Psi.Html.Impl.References.HtmlAttributeValueReferenceFactoryBase<JetBrains.ReSharper.Psi.Asp.Html.IAspDeclaredElementTypes, JetBrains.ProjectModel.AspProjectFileType>, JetBrains.ReSharper.Psi.Html.Impl.References.IHtmlUrlReferenceProviderOverride
    {
        public AspUrlAttributeValueReferenceProvider(JetBrains.ReSharper.Psi.Asp.Html.IAspDeclaredElementTypes aspDeclaredElementTypes) { }
        protected override bool CanHaveReference(JetBrains.ReSharper.Psi.Html.Impl.References.HtmlAttributeValueEntry entry, System.Collections.Generic.IEnumerable<string> names) { }
        protected override JetBrains.ReSharper.Psi.Resolve.IReference[] CreateReferences(JetBrains.ReSharper.Psi.Html.Impl.References.HtmlAttributeValueEntry entry) { }
        public override bool IsApplicable(JetBrains.ReSharper.Psi.Html.Impl.References.HtmlAttributeValueEntry entry) { }
    }
    public class DataBindReference : JetBrains.ReSharper.Psi.Impl.Shared.References.ReferenceWithinElementBase<JetBrains.ReSharper.Psi.Tree.ILiteralExpression, JetBrains.ReSharper.Psi.Tree.ITokenNode>, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IQualifiableReferenceBase, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IReferenceWithQualifier, JetBrains.ReSharper.Psi.Resolve.ICompleteableReference, JetBrains.ReSharper.Psi.Resolve.IQualifier, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.Util.IUserDataHolder
    {
        public DataBindReference(JetBrains.ReSharper.Psi.Asp.Html.IAspDeclaredElementTypes aspDeclaredElementTypes, JetBrains.ReSharper.Psi.Tree.ILiteralExpression owner, JetBrains.ReSharper.Psi.TreeTextRange rangeWithin, JetBrains.ReSharper.Psi.Resolve.IQualifier qualifier = null) { }
        public bool IsQualified { get; }
        public bool Resolved { get; }
        protected override JetBrains.ReSharper.Psi.Resolve.IReference BindToInternal(JetBrains.ReSharper.Psi.IDeclaredElement element, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution) { }
        public JetBrains.ReSharper.Psi.Resolve.QualifierKind GetKind() { }
        public JetBrains.ReSharper.Psi.Resolve.IQualifier GetQualifier() { }
        public override JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetReferenceSymbolTable(bool useReferenceName) { }
        public override JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.ResolveResultWithInfo GetResolveResult(JetBrains.ReSharper.Psi.Resolve.ISymbolTable symbolTable, string referenceName) { }
        public override JetBrains.ReSharper.Psi.Resolve.ISymbolFilter[] GetSymbolFilters() { }
        public JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetSymbolTable(JetBrains.ReSharper.Psi.Resolve.SymbolTableMode mode) { }
        public override bool IsValid() { }
        public JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.ResolveResultWithInfo Resolve(JetBrains.ReSharper.Psi.Resolve.ISymbolTable symbolTable, JetBrains.ReSharper.Psi.Resolve.IAccessContext context) { }
    }
    public interface IAspControlIdReferenceOverride
    {
        bool IsApplicable(JetBrains.ReSharper.Psi.Html.Impl.References.HtmlAttributeValueEntry entry);
    }
    public interface IAspTypeReferenceDecorator
    {
        [JetBrains.Annotations.NotNullAttribute()]
        string TypeArgumentPrefix { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        string TypeArgumentsCountFormat { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        string TypeArgumentsPrefix { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        string TypeArgumentsSuffix { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        string TypeArgumentSuffix { get; }
    }
    public class IsWritableFilter : JetBrains.ReSharper.Psi.Resolve.SimpleSymbolFilter
    {
        public IsWritableFilter(JetBrains.ReSharper.Psi.Resolve.ResolveErrorType errorType, JetBrains.ReSharper.Psi.Resolve.IAccessContext accessContext) { }
        public override JetBrains.ReSharper.Psi.Resolve.ResolveErrorType ErrorType { get; }
        public override bool Accepts(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution) { }
    }
    public class ThemeReference : JetBrains.ReSharper.Psi.Html.Impl.References.HtmlReferenceWithinElementBase<JetBrains.ReSharper.Psi.Asp.Tree.IAspDirectiveAttribute>, JetBrains.ReSharper.Psi.Asp.References.IThemeReference, JetBrains.ReSharper.Psi.Html.References.IHtmlCompleteableReference, JetBrains.ReSharper.Psi.Html.References.IHtmlSmartCompleteableReference, JetBrains.ReSharper.Psi.Resolve.ICompleteableReference, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.Util.IUserDataHolder
    {
        public ThemeReference(JetBrains.ReSharper.Psi.Asp.Tree.IAspDirectiveAttribute owner, JetBrains.ReSharper.Psi.Html.Tree.IHtmlToken token) { }
        public override JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetReferenceSymbolTable(bool useReferenceName) { }
        public override JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.ResolveResultWithInfo GetResolveResult(JetBrains.ReSharper.Psi.Resolve.ISymbolTable symbolTable, string referenceName) { }
    }
}
namespace JetBrains.ReSharper.Psi.Asp.Impl.Resolve
{
    
    public class AspNamespaceSymbolTable : JetBrains.ReSharper.Psi.Impl.Resolve.NamespaceSymbolTable
    {
        public AspNamespaceSymbolTable(JetBrains.ReSharper.Psi.Asp.Tree.IAspDirective directive, JetBrains.ReSharper.Psi.INamespace @namespace, JetBrains.ReSharper.Psi.Modules.IPsiModule module, bool withReferences, int level) { }
        protected override JetBrains.ReSharper.Psi.Resolve.ISymbolInfo CreateSymbolInfo(JetBrains.ReSharper.Psi.IClrDeclaredElement declaredElement) { }
        public override System.Collections.Generic.IEnumerable<string> Names() { }
    }
    public class AspResolveErrorType : JetBrains.ReSharper.Psi.Web.Resolve.WebResolveErrorType
    {
        public static readonly JetBrains.ReSharper.Psi.Resolve.ResolveErrorType FIELD_EXPECTED;
        public static readonly JetBrains.ReSharper.Psi.Resolve.ResolveErrorType IGNORABLE_NOT_RESOLVED;
        public static readonly JetBrains.ReSharper.Psi.Resolve.ResolveErrorType INVALID_CONTROL_TYPE;
        public static readonly JetBrains.ReSharper.Psi.Resolve.ResolveErrorType INVALID_CONTROL_TYPE_TO_VALIDATE;
        public static readonly JetBrains.ReSharper.Psi.Resolve.ResolveErrorType MUST_BE_WRITABLE;
        public static readonly JetBrains.ReSharper.Psi.Resolve.ResolveErrorType PROPERTY_MUST_BE_ATTRIBUTE;
        public static readonly JetBrains.ReSharper.Psi.Resolve.ResolveErrorType TYPE_EXPECTED;
        protected AspResolveErrorType(string name, string tooltip) { }
    }
    public class AspResolveInfoWithUsings : JetBrains.ReSharper.Psi.Asp.Resolve.IAspResolveInfoWithUsings, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IResolveInfo
    {
        public AspResolveInfoWithUsings(JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IResolveInfo resolveInfo, JetBrains.ReSharper.Psi.Asp.Tree.IAspDirective directive) { }
        public AspResolveInfoWithUsings(JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IResolveInfo resolveInfo, System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Asp.Tree.IAspDirective> usingDirectives) { }
        public JetBrains.ReSharper.Psi.Resolve.ResolveErrorType ResolveErrorType { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Asp.Tree.IAspDirective> UsingDirectives { get; }
    }
    public interface IAspMethodGroupConvertibleFilterFactory
    {
        JetBrains.ReSharper.Psi.Resolve.ISymbolFilter CreateMethodGroupConvertibleFilter([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode context, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.DeclaredElementInstance<JetBrains.ReSharper.Psi.IDelegate> eventType);
    }
    public class TagPrefixSymbolTable : JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.SymbolTable
    {
        public TagPrefixSymbolTable(JetBrains.ReSharper.Psi.IPsiServices psiServices) { }
        public void AddTagName(JetBrains.ReSharper.Psi.Web.TagPrefixes.ITagName tagName, JetBrains.ReSharper.Psi.Web.TagPrefixes.ITagNameDeclaration declaration, int level) { }
        public override void ForAllSymbolInfos(System.Action<JetBrains.ReSharper.Psi.Resolve.ISymbolInfo> processor) { }
        public override System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Resolve.ISymbolInfo> GetSymbolInfos(string name) { }
        public override System.Collections.Generic.IEnumerable<string> Names() { }
    }
}
namespace JetBrains.ReSharper.Psi.Asp.Impl.Searching
{
    
    [JetBrains.ReSharper.Psi.PsiSharedComponentAttribute()]
    public class AspSearcherFactory : JetBrains.ReSharper.Psi.ExtensionsAPI.IDomainSpecificSearcherFactory
    {
        protected readonly JetBrains.ReSharper.Psi.Search.SearchDomainFactory mySearchDomainFactory;
        public AspSearcherFactory(JetBrains.ReSharper.Psi.Search.SearchDomainFactory searchDomainFactory) { }
        public JetBrains.ReSharper.Psi.ExtensionsAPI.IDomainSpecificSearcher CreateAnonymousTypeSearcher(System.Collections.Generic.IList<JetBrains.ReSharper.Psi.AnonymousTypeDescriptor> typeDescription, bool caseSensitive) { }
        public JetBrains.ReSharper.Psi.ExtensionsAPI.IDomainSpecificSearcher CreateConstantExpressionSearcher(JetBrains.ReSharper.Psi.ConstantValue constantValue, bool onlyLiteralExpression) { }
        public JetBrains.ReSharper.Psi.ExtensionsAPI.IDomainSpecificSearcher CreateConstructorSpecialReferenceSearcher(System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.IConstructor> constructors) { }
        public JetBrains.ReSharper.Psi.ExtensionsAPI.IDomainSpecificSearcher CreateLateBoundReferenceSearcher(System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.IDeclaredElement> elements) { }
        public JetBrains.ReSharper.Psi.ExtensionsAPI.IDomainSpecificSearcher CreateMethodsReferencedByDelegateSearcher(JetBrains.ReSharper.Psi.IDelegate @delegate) { }
        public JetBrains.ReSharper.Psi.ExtensionsAPI.IDomainSpecificSearcher CreateReferenceSearcher(System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.IDeclaredElement> elements, bool findCandidates) { }
        public JetBrains.ReSharper.Psi.ExtensionsAPI.IDomainSpecificSearcher CreateTextOccurenceSearcher(System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.IDeclaredElement> elements) { }
        public JetBrains.ReSharper.Psi.ExtensionsAPI.IDomainSpecificSearcher CreateTextOccurenceSearcher(string subject) { }
        public System.Collections.Generic.IEnumerable<string> GetAllPossibleWordsInFile(JetBrains.ReSharper.Psi.IDeclaredElement element) { }
        public virtual JetBrains.ReSharper.Psi.Search.ISearchDomain GetDeclaredElementSearchDomain(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
        public JetBrains.Util.JetTuple<System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.IDeclaredElement>, System.Predicate<JetBrains.ReSharper.Psi.Search.IFindResultReference>, bool> GetDerivedFindRequest(JetBrains.ReSharper.Psi.Search.IFindResultReference result) { }
        public JetBrains.Util.JetTuple<System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.IDeclaredElement>, bool> GetNavigateToTargets(JetBrains.ReSharper.Psi.IDeclaredElement element) { }
        public System.Collections.Generic.IEnumerable<JetBrains.Util.Pair<JetBrains.ReSharper.Psi.IDeclaredElement, System.Predicate<JetBrains.ReSharper.Psi.Search.FindResult>>> GetRelatedDeclaredElements(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
        public bool IsCompatibleWithLanguage(JetBrains.ReSharper.Psi.PsiLanguageType languageType) { }
        public System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.Search.FindResult> TransformNavigationTargets(System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.Search.FindResult> targets) { }
    }
    [JetBrains.ReSharper.Psi.PsiSharedComponentAttribute()]
    public class SkinSearcherFactory : JetBrains.ReSharper.Psi.Asp.Impl.Searching.AspSearcherFactory
    {
        public SkinSearcherFactory(JetBrains.ReSharper.Psi.Search.SearchDomainFactory searchDomainFactory) { }
        public override JetBrains.ReSharper.Psi.Search.ISearchDomain GetDeclaredElementSearchDomain(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
    }
}
namespace JetBrains.ReSharper.Psi.Asp.Impl.TagPrefixes
{
    
    public class AspDeclaredElementType : JetBrains.ReSharper.Psi.Html.Impl.TagPrefixes.HtmlDeclaredElementType
    {
        public static readonly JetBrains.ReSharper.Psi.DeclaredElementType HTML_CONTROL;
        protected override JetBrains.ReSharper.Psi.IDeclaredElementPresenter DefaultPresenter { get; }
        public override bool IsPresentable(JetBrains.ReSharper.Psi.PsiLanguageType language) { }
    }
}
namespace JetBrains.ReSharper.Psi.Asp.Impl.Tree
{
    
    public class AspAttributeValue : JetBrains.ReSharper.Psi.Html.Impl.Tree.HtmlAttributeValue, JetBrains.ReSharper.Psi.Asp.Tree.IAspAttributeValue, JetBrains.ReSharper.Psi.Asp.Tree.IAspTreeNode, JetBrains.ReSharper.Psi.Html.Tree.IHtmlAttributeValue, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode
    {
        public AspAttributeValue(JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType nodeType, JetBrains.ReSharper.Psi.Html.Parsing.IHtmlTokenNodeTypes tokenTypes) { }
        public JetBrains.ReSharper.Psi.Asp.Parsing.IAspTokenNodeTypes TokenTypes { get; }
        public override JetBrains.ReSharper.Psi.Html.Tree.IHtmlToken ValueToken { get; }
        protected override JetBrains.ReSharper.Psi.Tree.ReferenceCollection CreateFirstClassReferences() { }
    }
    public sealed class AspChildRole : JetBrains.ReSharper.Psi.Html.Impl.Tree.HtmlChildRole
    {
        public const short ASP_BLOCK_END = 141;
        public const short ASP_BLOCK_START = 140;
        public const short ASP_COMMENT_END = 11;
        public const short ASP_COMMENT_START = 10;
        public const short ASP_DIRECTIVE = 1;
        public const short ASP_DIRECTIVE_END = 131;
        public const short ASP_DIRECTIVE_START = 130;
        public const short ASP_SCRIPLET = 2;
    }
    public class AspCodeBlock : JetBrains.ReSharper.Psi.Asp.Impl.Tree.AspRenderBlock, JetBrains.ReSharper.Psi.Asp.Tree.IAspCodeBlock, JetBrains.ReSharper.Psi.Asp.Tree.IAspElementWithCodeBlock, JetBrains.ReSharper.Psi.Asp.Tree.IAspRenderBlock, JetBrains.ReSharper.Psi.Asp.Tree.IAspTreeNode, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebCodeBlock, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode
    {
        public AspCodeBlock(JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType nodeType, JetBrains.ReSharper.Psi.Asp.Parsing.IAspTokenNodeTypes tokenTypes) { }
        protected override JetBrains.ReSharper.Psi.Parsing.TokenNodeType StartTokenNodeType { get; }
    }
    public class AspComment : JetBrains.ReSharper.Psi.Asp.Impl.Tree.AspCompositeElement, JetBrains.ReSharper.Psi.Asp.Tree.IAspComment, JetBrains.ReSharper.Psi.Asp.Tree.IAspTreeNode, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode, JetBrains.ReSharper.Psi.Html.Tree.IWebComment, JetBrains.ReSharper.Psi.Tree.IChameleonNode, JetBrains.ReSharper.Psi.Tree.IComment, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode
    {
        public AspComment(JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType nodeType, JetBrains.ReSharper.Psi.Asp.Parsing.IAspTokenNodeTypes tokenTypes) { }
        public JetBrains.ReSharper.Psi.Tree.ITreeNode CommentEnd { get; }
        public JetBrains.ReSharper.Psi.Tree.ITreeNode CommentStart { get; }
        public string CommentText { get; }
        public bool IsOpened { get; }
        public override TReturn AcceptVisitor<TContext, TReturn>(JetBrains.ReSharper.Psi.Html.Tree.HtmlTreeVisitor<TContext, TReturn> visitor, TContext context) { }
        public override short GetChildRole(JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.TreeElement child) { }
        public JetBrains.ReSharper.Psi.TreeTextRange GetCommentRange() { }
        public JetBrains.ReSharper.Psi.Tree.IChameleonNode ReSync(JetBrains.ReSharper.Psi.Parsing.CachingLexer cachingLexer, JetBrains.ReSharper.Psi.TreeTextRange changedRange, int insertedTextLen) { }
    }
    public abstract class AspCompositeElement : JetBrains.ReSharper.Psi.Html.Impl.Tree.HtmlCompositeElement, JetBrains.ReSharper.Psi.Asp.Tree.IAspTreeNode, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode
    {
        protected readonly JetBrains.ReSharper.Psi.Asp.Parsing.IAspTokenNodeTypes myTokenTypes;
        protected AspCompositeElement(JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType nodeType, JetBrains.ReSharper.Psi.Asp.Parsing.IAspTokenNodeTypes tokenTypes) { }
        public JetBrains.ReSharper.Psi.Asp.Parsing.IAspTokenNodeTypes TokenTypes { get; }
    }
    public class AspDataBinderExpression : JetBrains.ReSharper.Psi.Asp.Impl.Tree.AspRenderBlock, JetBrains.ReSharper.Psi.Asp.Tree.IAspDataBinderExpression, JetBrains.ReSharper.Psi.Asp.Tree.IAspElementWithCodeBlock, JetBrains.ReSharper.Psi.Asp.Tree.IAspExpression, JetBrains.ReSharper.Psi.Asp.Tree.IAspRenderBlock, JetBrains.ReSharper.Psi.Asp.Tree.IAspTreeNode, JetBrains.ReSharper.Psi.ExtensionsAPI.Caches2.ICachedTypeMemberDeclaration, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode, JetBrains.ReSharper.Psi.Tree.IDeclaration, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Tree.IXmlDocOwnerTreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebCodeBlock, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode
    {
        public AspDataBinderExpression(JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType nodeType, JetBrains.ReSharper.Psi.Asp.Parsing.IAspTokenNodeTypes tokenTypes, JetBrains.ReSharper.Psi.Asp.Impl.UniqueIdGenerator uniqueIdGenerator) { }
        public JetBrains.ReSharper.Psi.IDeclaredElement CachedDeclaredElement { get; set; }
        public JetBrains.ReSharper.Psi.IDeclaredElement DeclaredElement { get; }
        public string DeclaredName { get; }
        protected override JetBrains.ReSharper.Psi.Parsing.TokenNodeType StartTokenNodeType { get; }
        public JetBrains.ReSharper.Psi.Asp.Tree.IAspTag GetEnclosingTag(out JetBrains.ReSharper.Psi.IType containerType, out JetBrains.ReSharper.Psi.Asp.Html.IAspDeclaredElementTypes declaredElementTypes) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Asp.Html.IAspBindingExpressionField> GetImplicitFields() { }
        public JetBrains.ReSharper.Psi.TreeTextRange GetNameRange() { }
        public System.Xml.XmlNode GetXMLDoc(bool inherit) { }
        public bool IsSynthetic() { }
        protected override void PreInit() { }
        public override JetBrains.ReSharper.Psi.Tree.IChameleonNode ReSync(JetBrains.ReSharper.Psi.Parsing.CachingLexer cachingLexer, JetBrains.ReSharper.Psi.TreeTextRange changedRange, int insertedTextLen) { }
        public void SetName(string name) { }
    }
    public class AspDirective : JetBrains.ReSharper.Psi.Asp.Impl.Tree.AspCompositeElement, JetBrains.ReSharper.Psi.Asp.Tree.IAspDirective, JetBrains.ReSharper.Psi.Asp.Tree.IAspTreeNode, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode, JetBrains.ReSharper.Psi.Tree.IChameleonNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebAttributeContainer<JetBrains.ReSharper.Psi.Asp.Tree.IAspDirectiveAttribute>, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode
    {
        public AspDirective(JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType nodeType, JetBrains.ReSharper.Psi.Asp.Parsing.IAspTokenNodeTypes tokenTypes) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Asp.Tree.IAspDirectiveAttribute> Attributes { get; }
        public string DirectiveName { get; }
        public JetBrains.ReSharper.Psi.Html.Tree.IHtmlToken EndToken { get; }
        public bool IsOpened { get; }
        public JetBrains.ReSharper.Psi.Html.Tree.IHtmlToken NameToken { get; }
        public JetBrains.ReSharper.Psi.Html.Tree.IHtmlToken StartToken { get; }
        public override TReturn AcceptVisitor<TContext, TReturn>(JetBrains.ReSharper.Psi.Html.Tree.HtmlTreeVisitor<TContext, TReturn> visitor, TContext context) { }
        public JetBrains.ReSharper.Psi.Asp.Tree.IAspDirectiveAttribute AddAttributeAfter(JetBrains.ReSharper.Psi.Asp.Tree.IAspDirectiveAttribute attribute, JetBrains.ReSharper.Psi.Asp.Tree.IAspDirectiveAttribute anchor = null) { }
        public JetBrains.ReSharper.Psi.Asp.Tree.IAspDirectiveAttribute AddAttributeBefore(JetBrains.ReSharper.Psi.Asp.Tree.IAspDirectiveAttribute attribute, JetBrains.ReSharper.Psi.Asp.Tree.IAspDirectiveAttribute anchor = null) { }
        protected override JetBrains.ReSharper.Psi.Tree.ReferenceCollection CreateFirstClassReferences() { }
        public override short GetChildRole(JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.TreeElement child) { }
        public void RemoveAttribute(JetBrains.ReSharper.Psi.Asp.Tree.IAspDirectiveAttribute attribute) { }
        public JetBrains.ReSharper.Psi.Tree.IChameleonNode ReSync(JetBrains.ReSharper.Psi.Parsing.CachingLexer cachingLexer, JetBrains.ReSharper.Psi.TreeTextRange changedRange, int insertedTextLen) { }
    }
    public class AspDirectiveAttribute : JetBrains.ReSharper.Psi.Asp.Impl.Tree.AspCompositeElement, JetBrains.ReSharper.Psi.Asp.Tree.IAspDirectiveAttribute, JetBrains.ReSharper.Psi.Asp.Tree.IAspTreeNode, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebAttribute, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode
    {
        public AspDirectiveAttribute(JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType nodeType, JetBrains.ReSharper.Psi.Asp.Parsing.IAspTokenNodeTypes tokenTypes) { }
        public string AttributeName { get; }
        public JetBrains.ReSharper.Psi.Html.Tree.IHtmlToken EqToken { get; }
        public string Name { get; }
        public JetBrains.ReSharper.Psi.Html.Tree.IHtmlToken NameToken { get; }
        public string Prefix { get; }
        public JetBrains.ReSharper.Psi.Html.Tree.IHtmlToken ValueToken { get; }
        public override TReturn AcceptVisitor<TContext, TReturn>(JetBrains.ReSharper.Psi.Html.Tree.HtmlTreeVisitor<TContext, TReturn> visitor, TContext context) { }
        public bool AttributeNameEqualsTo(string attributeName) { }
        protected override void ClearCachedData() { }
        protected virtual JetBrains.ReSharper.Psi.Tree.ReferenceCollection CreateFirstClassReferences() { }
        protected System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.Resolve.IReference> CreateNamespaceReferencesOnAttributeValue(JetBrains.ReSharper.Psi.Html.Tree.IHtmlToken valueToken, JetBrains.ReSharper.Psi.Asp.Tree.IAspDirective directive, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Web.Directives.IWebDirectiveDeclaredElement directiveDeclaredElement, bool supportAliases = False) { }
        protected virtual System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.Resolve.IReference> CreateReferencesOnAttributeName([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Html.Tree.IHtmlToken nameToken) { }
        protected virtual System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.Resolve.IReference> CreateReferencesOnAttributeValue([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Html.Tree.IHtmlToken valueToken) { }
        public override short GetChildRole(JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.TreeElement child) { }
        public override void SubTreeChanged(JetBrains.ReSharper.Psi.Tree.ITreeNode elementContainingChanges, JetBrains.ReSharper.Psi.PsiChangedElementType changeType) { }
    }
    public class AspDirectiveCodeFileBaseClassAttribute : JetBrains.ReSharper.Psi.Asp.Impl.Tree.AspDirectiveAttribute, JetBrains.ReSharper.Psi.Asp.Tree.IAspDirectiveAttribute, JetBrains.ReSharper.Psi.Asp.Tree.IAspDirectiveCodeFileBaseClassAttribute, JetBrains.ReSharper.Psi.Asp.Tree.IAspTreeNode, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebAttribute, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode
    {
        public AspDirectiveCodeFileBaseClassAttribute(JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType nodeType, JetBrains.ReSharper.Psi.Asp.Parsing.IAspTokenNodeTypes tokenTypes) { }
        protected override System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.Resolve.IReference> CreateReferencesOnAttributeValue(JetBrains.ReSharper.Psi.Html.Tree.IHtmlToken valueToken) { }
        public JetBrains.ReSharper.Psi.Web.WebConfig.Util.ParsedTypeInfo GetTypeInfo() { }
    }
    public class AspDirectiveInheritsAttribute : JetBrains.ReSharper.Psi.Asp.Impl.Tree.AspDirectiveAttribute, JetBrains.ReSharper.Psi.Asp.Impl.Tree.IAspHashableDeclaration, JetBrains.ReSharper.Psi.Asp.Tree.IAspDirectiveAttribute, JetBrains.ReSharper.Psi.Asp.Tree.IAspDirectiveInheritsAttribute, JetBrains.ReSharper.Psi.Asp.Tree.IAspTreeNode, JetBrains.ReSharper.Psi.Asp.Tree.IAspTypeDeclaration, JetBrains.ReSharper.Psi.Dependencies.IHashableDeclaration, JetBrains.ReSharper.Psi.ExtensionsAPI.Caches2.ICachedDeclaration2, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IScope, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode, JetBrains.ReSharper.Psi.Tree.IDeclaration, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Tree.ITypeDeclaration, JetBrains.ReSharper.Psi.Tree.ITypeDeclarationHolder, JetBrains.ReSharper.Psi.Tree.IXmlDocOwnerTreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebAttribute, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode
    {
        public AspDirectiveInheritsAttribute(JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType nodeType, JetBrains.ReSharper.Psi.Asp.Parsing.IAspTokenNodeTypes tokenTypes) { }
        public string CLRName { get; }
        public JetBrains.ReSharper.Psi.ITypeElement DeclaredElement { get; }
        public string DeclaredName { get; }
        public int LevelDelta { get; }
        public JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<JetBrains.ReSharper.Psi.Tree.ITypeMemberDeclaration> MemberDeclarations { get; }
        public JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<JetBrains.ReSharper.Psi.Tree.ITypeDeclaration> NestedTypeDeclarations { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IDeclaredType> SuperTypes { get; }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Tree.ITypeDeclaration> TypeDeclarations { get; }
        public JetBrains.ReSharper.Psi.Resolve.ISymbolTable AddGlobalDeclarations(JetBrains.ReSharper.Psi.Resolve.ISymbolTable parentTable, int level, JetBrains.ReSharper.Psi.Resolve.SymbolTableMode mode) { }
        public JetBrains.ReSharper.Psi.Dependencies.Hash CalcHash() { }
        protected override System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.Resolve.IReference> CreateReferencesOnAttributeValue(JetBrains.ReSharper.Psi.Html.Tree.IHtmlToken valueToken) { }
        public JetBrains.ReSharper.Psi.TreeTextRange GetNameRange() { }
        public JetBrains.ReSharper.Psi.Web.WebConfig.Util.ParsedTypeInfo GetTypeInfo() { }
        public System.Xml.XmlNode GetXMLDoc(bool inherit) { }
        public bool IsSynthetic() { }
        protected override void PreInit() { }
        public void SetName(string name) { }
        public void SetNamespaceName(string qualifiedName) { }
    }
    public class AspDirectiveNamespaceAttribute : JetBrains.ReSharper.Psi.Asp.Impl.Tree.AspDirectiveAttribute
    {
        public AspDirectiveNamespaceAttribute(JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType nodeType, JetBrains.ReSharper.Psi.Asp.Parsing.IAspTokenNodeTypes tokenTypes) { }
        protected override System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.Resolve.IReference> CreateReferencesOnAttributeValue(JetBrains.ReSharper.Psi.Html.Tree.IHtmlToken valueToken) { }
    }
    public class AspDirectiveTagNameAttribute : JetBrains.ReSharper.Psi.Asp.Impl.Tree.AspDirectiveTagPrefixNameAttributeBase, JetBrains.ReSharper.Psi.Asp.Tree.IAspDirectiveAttribute, JetBrains.ReSharper.Psi.Asp.Tree.IAspTagNameAttribute, JetBrains.ReSharper.Psi.Asp.Tree.IAspTreeNode, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode, JetBrains.ReSharper.Psi.Tree.IDeclaration, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Tree.IXmlDocOwnerTreeNode, JetBrains.ReSharper.Psi.Web.TagPrefixes.ITagNameDeclaration, JetBrains.ReSharper.Psi.Web.Tree.IWebAttribute, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode
    {
        public AspDirectiveTagNameAttribute(JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType nodeType, JetBrains.ReSharper.Psi.Asp.Parsing.IAspTokenNodeTypes tokenTypes) { }
        protected override JetBrains.ReSharper.Psi.IDeclaredElement CreateDeclaredElement() { }
    }
    public class AspDirectiveTagPrefixAttribute : JetBrains.ReSharper.Psi.Asp.Impl.Tree.AspDirectiveTagPrefixNameAttributeBase, JetBrains.ReSharper.Psi.Asp.Tree.IAspDirectiveAttribute, JetBrains.ReSharper.Psi.Asp.Tree.IAspTagPrefixAttribute, JetBrains.ReSharper.Psi.Asp.Tree.IAspTreeNode, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode, JetBrains.ReSharper.Psi.Tree.IDeclaration, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Tree.IXmlDocOwnerTreeNode, JetBrains.ReSharper.Psi.Web.TagPrefixes.ITagPrefixDeclaration, JetBrains.ReSharper.Psi.Web.Tree.IWebAttribute, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode
    {
        public AspDirectiveTagPrefixAttribute(JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType nodeType, JetBrains.ReSharper.Psi.Asp.Parsing.IAspTokenNodeTypes tokenTypes) { }
        protected override JetBrains.ReSharper.Psi.IDeclaredElement CreateDeclaredElement() { }
    }
    public abstract class AspDirectiveTagPrefixNameAttributeBase : JetBrains.ReSharper.Psi.Asp.Impl.Tree.AspDirectiveAttribute, JetBrains.ReSharper.Psi.ExtensionsAPI.Caches2.ICachedTypeMemberDeclaration, JetBrains.ReSharper.Psi.Tree.IDeclaration, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Tree.IXmlDocOwnerTreeNode
    {
        protected AspDirectiveTagPrefixNameAttributeBase(JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType nodeType, JetBrains.ReSharper.Psi.Asp.Parsing.IAspTokenNodeTypes tokenTypes) { }
        public JetBrains.ReSharper.Psi.IDeclaredElement CachedDeclaredElement { get; set; }
        public JetBrains.ReSharper.Psi.IDeclaredElement DeclaredElement { get; }
        public string DeclaredName { get; }
        public JetBrains.ReSharper.Psi.Web.TagPrefixes.ITagPrefixHolder Holder { get; }
        protected abstract JetBrains.ReSharper.Psi.IDeclaredElement CreateDeclaredElement();
        public JetBrains.ReSharper.Psi.TreeTextRange GetNameRange() { }
        public System.Xml.XmlNode GetXMLDoc(bool inherit) { }
        public bool IsSynthetic() { }
        protected override void PreInit() { }
        public void SetName(string name) { }
    }
    public class AspExpression : JetBrains.ReSharper.Psi.Asp.Impl.Tree.AspRenderBlock, JetBrains.ReSharper.Psi.Asp.Tree.IAspElementWithCodeBlock, JetBrains.ReSharper.Psi.Asp.Tree.IAspExpression, JetBrains.ReSharper.Psi.Asp.Tree.IAspRenderBlock, JetBrains.ReSharper.Psi.Asp.Tree.IAspTreeNode, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebCodeBlock, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode
    {
        public AspExpression(JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType nodeType, JetBrains.ReSharper.Psi.Asp.Parsing.IAspTokenNodeTypes tokenTypes) { }
        protected override JetBrains.ReSharper.Psi.Parsing.TokenNodeType StartTokenNodeType { get; }
    }
    public class AspFile : JetBrains.ReSharper.Psi.Html.Impl.Tree.HtmlFile, JetBrains.ReSharper.Psi.Asp.Impl.Tree.IAspHashableDeclaration, JetBrains.ReSharper.Psi.Asp.Tree.IAspFile, JetBrains.ReSharper.Psi.Asp.Tree.IAspTreeNode, JetBrains.ReSharper.Psi.Asp.Tree.IAspTypeDeclaration, JetBrains.ReSharper.Psi.Dependencies.IFileWithDependencies, JetBrains.ReSharper.Psi.Dependencies.IHashableDeclaration, JetBrains.ReSharper.Psi.ExtensionsAPI.Caches2.ICachedDeclaration2, JetBrains.ReSharper.Psi.Html.Tree.IHtmlFile, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTagContainer, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTagContainerMarker, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode, JetBrains.ReSharper.Psi.Tree.IDeclaration, JetBrains.ReSharper.Psi.Tree.IFile, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Tree.ITypeDeclaration, JetBrains.ReSharper.Psi.Tree.ITypeDeclarationHolder, JetBrains.ReSharper.Psi.Tree.IXmlDocOwnerTreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebFile, JetBrains.ReSharper.Psi.Web.Tree.IWebFileWithCodeBehind, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode
    {
        public AspFile(JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType nodeType, JetBrains.ReSharper.Psi.Asp.Parsing.IAspTokenNodeTypes tokenTypes) { }
        public JetBrains.ReSharper.Psi.Asp.Tree.IAspDirectiveAttribute ClassNameAttribute { get; }
        public string CLRName { get; }
        public JetBrains.ReSharper.Psi.ITypeElement DeclaredElement { get; }
        public string DeclaredName { get; }
        public bool HasCodeBehindPart { get; }
        public JetBrains.ReSharper.Psi.Asp.Tree.IAspDirectiveInheritsAttribute InheritsAttribute { get; }
        public bool IsControl { get; }
        public bool IsMasterPage { get; }
        public JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<JetBrains.ReSharper.Psi.Tree.ITypeMemberDeclaration> MemberDeclarations { get; }
        public JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<JetBrains.ReSharper.Psi.Tree.ITypeDeclaration> NestedTypeDeclarations { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IDeclaredType> SuperTypes { get; }
        public JetBrains.ReSharper.Psi.Asp.Parsing.IAspTokenNodeTypes TokenTypes { get; }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Tree.ITypeDeclaration> TypeDeclarations { get; }
        public bool UsesMasterPage { get; }
        public JetBrains.ReSharper.Psi.Asp.Tree.IAspDirective AddDirective(JetBrains.ReSharper.Psi.Asp.Tree.IAspDirective directive) { }
        public JetBrains.ReSharper.Psi.Asp.Tree.IAspDirective AddDirectiveAfter(JetBrains.ReSharper.Psi.Asp.Tree.IAspDirective directive, JetBrains.ReSharper.Psi.Asp.Tree.IAspDirective anchor) { }
        public JetBrains.ReSharper.Psi.Asp.Tree.IAspDirective AddDirectiveBefore(JetBrains.ReSharper.Psi.Asp.Tree.IAspDirective directive, JetBrains.ReSharper.Psi.Asp.Tree.IAspDirective anchor) { }
        public override JetBrains.ReSharper.Psi.Resolve.ISymbolTable AddGlobalDeclarations(JetBrains.ReSharper.Psi.Resolve.ISymbolTable parentTable, int level, JetBrains.ReSharper.Psi.Resolve.SymbolTableMode mode) { }
        public JetBrains.ReSharper.Psi.Dependencies.Hash CalcHash() { }
        protected override JetBrains.ReSharper.Psi.Html.Impl.Tree.HtmlFileData CreateData(JetBrains.ReSharper.Psi.Tree.IFile file) { }
        public JetBrains.ReSharper.Psi.Asp.Tree.CreateFieldsType DoCreateFields() { }
        public System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.Html.Tree.IHtmlTag> GetAllTagsWithId() { }
        public System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.Asp.Tree.IAspDataBinderExpression> GetDataBinderExpressions() { }
        public JetBrains.ReSharper.Psi.IType GetDefaultBaseType() { }
        public JetBrains.ReSharper.Psi.IType GetDefaultBaseTypefForDataBinding() { }
        public System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.Asp.Tree.IAspDirective> GetDirectives() { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Asp.Html.IHtmlControl> GetHtmlControls() { }
        public JetBrains.ReSharper.Psi.TreeTextRange GetNameRange() { }
        protected override JetBrains.ReSharper.Psi.Parsing.TokenNodeType GetReparsableNodeType(JetBrains.ReSharper.Psi.Tree.ITreeNode node) { }
        protected override JetBrains.ReSharper.Psi.Parsing.TokenNodeType GetReparsableNodeTypeByParent(JetBrains.ReSharper.Psi.Tree.ITreeNode node) { }
        public System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.Asp.Tree.IAspScriptTag> GetScriptTags() { }
        public string GetShortName(out System.Collections.Generic.IList<> namespaceNames, out System.Collections.Generic.IList<> namespaceRanges, out JetBrains.ReSharper.Psi.TreeTextRange nameRange) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IDeclaredType> GetSuperTypes() { }
        protected override JetBrains.Util.Pair<JetBrains.ReSharper.Psi.Tree.ITreeNode, bool> GetTagAnchor(JetBrains.ReSharper.Psi.Tree.ITreeNode anchor, bool after) { }
        public JetBrains.ReSharper.Psi.Tree.ITypeDeclaration GetTypeDeclaration() { }
        public System.Xml.XmlNode GetXMLDoc(bool inherit) { }
        public bool IsSynthetic() { }
        protected override void PreInit() { }
        public void RemoveDirective(JetBrains.ReSharper.Psi.Asp.Tree.IAspDirective directive) { }
        public void SetName(string name) { }
        public void SetNamespaceName(int nOldNamespacesToDelete, string newNamespaceName) { }
    }
    public class AspFileData : JetBrains.ReSharper.Psi.Html.Impl.Tree.HtmlFileData
    {
        public AspFileData(JetBrains.ReSharper.Psi.Tree.ITreeNode node) { }
        public System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.Html.Tree.IHtmlTag> GetAllTagsWithId() { }
        public JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetControlsSymbolTable(JetBrains.ReSharper.Psi.Asp.Tree.IAspFile aspFile) { }
        public System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.Asp.Tree.IAspDataBinderExpression> GetDataBinderExpressions() { }
        public System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.Asp.Tree.IAspDirective> GetDirectives() { }
        public System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.Asp.Tree.IAspScriptTag> GetScriptTags() { }
        protected override bool InteriorShouldBeProcessed(JetBrains.ReSharper.Psi.Tree.ITreeNode node) { }
        protected override bool ProcessNode(JetBrains.ReSharper.Psi.Tree.ITreeNode node) { }
        protected override void RemoveDeadElements() { }
        protected override void SortElements() { }
    }
    public class AspHtmlEncodedDataBinderExpression : JetBrains.ReSharper.Psi.Asp.Impl.Tree.AspDataBinderExpression, JetBrains.ReSharper.Psi.Web.IVersionRestricted
    {
        public AspHtmlEncodedDataBinderExpression(JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType nodeType, JetBrains.ReSharper.Psi.Asp.Parsing.IAspTokenNodeTypes tokenTypes, JetBrains.ReSharper.Psi.Asp.Impl.UniqueIdGenerator uniqueIdGenerator) { }
        protected override JetBrains.ReSharper.Psi.Parsing.TokenNodeType StartTokenNodeType { get; }
        public System.Nullable<JetBrains.ReSharper.Psi.Web.AspNetVersion> SupportedVersion { get; }
    }
    public class AspHtmlEncoding : JetBrains.ReSharper.Psi.Asp.Impl.Tree.AspExpression, JetBrains.ReSharper.Psi.Web.IVersionRestricted
    {
        public AspHtmlEncoding(JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType nodeType, JetBrains.ReSharper.Psi.Asp.Parsing.IAspTokenNodeTypes tokenTypes) { }
        protected override JetBrains.ReSharper.Psi.Parsing.TokenNodeType StartTokenNodeType { get; }
        public System.Nullable<JetBrains.ReSharper.Psi.Web.AspNetVersion> SupportedVersion { get; }
    }
    public class AspIdentifierToken : JetBrains.ReSharper.Psi.Asp.Impl.Tree.AspToken, JetBrains.ReSharper.Psi.Asp.Tree.IAspIdentifierTokenNode, JetBrains.ReSharper.Psi.Html.Tree.IHtmlToken, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode, JetBrains.ReSharper.Psi.Tree.IIdentifier, JetBrains.ReSharper.Psi.Tree.ITokenNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode
    {
        public AspIdentifierToken(JetBrains.ReSharper.Psi.Asp.Parsing.IAspTokenNodeTypes tokenTypes, JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType type, JetBrains.Text.IBuffer buffer, JetBrains.ReSharper.Psi.TreeOffset startOffset, JetBrains.ReSharper.Psi.TreeOffset endOffset) { }
        public string Name { get; }
    }
    public class AspMainDirective : JetBrains.ReSharper.Psi.Asp.Impl.Tree.AspDirective, JetBrains.ReSharper.Psi.Asp.Tree.IAspDirective, JetBrains.ReSharper.Psi.Asp.Tree.IAspMainDirective, JetBrains.ReSharper.Psi.Asp.Tree.IAspTreeNode, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebAttributeContainer<JetBrains.ReSharper.Psi.Asp.Tree.IAspDirectiveAttribute>, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode
    {
        public AspMainDirective(JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType nodeType, JetBrains.ReSharper.Psi.Asp.Parsing.IAspTokenNodeTypes tokenTypes) { }
        public JetBrains.ReSharper.Psi.Asp.Tree.IAspDirectiveAttribute AutoEventWireUpAttribute { get; }
        public JetBrains.ReSharper.Psi.Asp.Tree.IAspDirectiveAttribute ClassNameAttribute { get; }
        public JetBrains.ReSharper.Psi.Asp.Tree.IAspDirectiveAttribute CodeBehindAttribute { get; }
        public JetBrains.ReSharper.Psi.Asp.Tree.IAspDirectiveAttribute CodeFileAttribute { get; }
        public JetBrains.ReSharper.Psi.Asp.Tree.IAspDirectiveCodeFileBaseClassAttribute CodeFileBaseClassAttribute { get; }
        public JetBrains.ReSharper.Psi.Asp.Tree.IAspDirectiveAttribute DynamicMasterPageFileAttribute { get; }
        public JetBrains.ReSharper.Psi.Asp.Tree.IAspDirectiveAttribute ExplicitAttribute { get; }
        public JetBrains.ReSharper.Psi.Asp.Tree.IAspDirectiveInheritsAttribute InheritsAttribute { get; }
        public JetBrains.ReSharper.Psi.Asp.Tree.IAspDirectiveAttribute LanguageAttribute { get; }
        public JetBrains.ReSharper.Psi.Asp.Tree.IAspDirectiveAttribute MasterPageFileAttribute { get; }
        public JetBrains.ReSharper.Psi.Asp.Tree.IAspDirectiveAttribute SrcAttribute { get; }
        public JetBrains.ReSharper.Psi.Asp.Tree.IAspDirectiveAttribute StrictAttribute { get; }
        public JetBrains.ReSharper.Psi.Asp.Tree.IAspDirectiveAttribute StyleSheetThemeAttribute { get; }
        public JetBrains.ReSharper.Psi.Asp.Tree.IAspDirectiveAttribute ThemeAttribute { get; }
    }
    public class AspMasterTypeDirective : JetBrains.ReSharper.Psi.Asp.Impl.Tree.AspPropertyDirectiveBase
    {
        public AspMasterTypeDirective(JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType nodeType, JetBrains.ReSharper.Psi.Asp.Parsing.IAspTokenNodeTypes tokenTypes) { }
        public override string DeclaredName { get; }
        protected override JetBrains.ReSharper.Psi.IDeclaredElement CreateDeclaredElement() { }
    }
    public class AspPreProcessorCodeBlock : JetBrains.ReSharper.Psi.Asp.Impl.Tree.AspCodeBlock, JetBrains.ReSharper.Psi.Asp.Tree.IAspCodeBlock, JetBrains.ReSharper.Psi.Asp.Tree.IAspElementWithCodeBlock, JetBrains.ReSharper.Psi.Asp.Tree.IAspPreProcessorCodeBlock, JetBrains.ReSharper.Psi.Asp.Tree.IAspRenderBlock, JetBrains.ReSharper.Psi.Asp.Tree.IAspTreeNode, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebCodeBlock, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode
    {
        public AspPreProcessorCodeBlock(JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType nodeType, JetBrains.ReSharper.Psi.Asp.Parsing.IAspTokenNodeTypes tokenTypes) { }
        protected override JetBrains.ReSharper.Psi.Parsing.TokenNodeType StartTokenNodeType { get; }
    }
    public class AspPreviousPageTypeDirective : JetBrains.ReSharper.Psi.Asp.Impl.Tree.AspPropertyDirectiveBase
    {
        public AspPreviousPageTypeDirective(JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType nodeType, JetBrains.ReSharper.Psi.Asp.Parsing.IAspTokenNodeTypes tokenTypes) { }
        public override string DeclaredName { get; }
        protected override JetBrains.ReSharper.Psi.IDeclaredElement CreateDeclaredElement() { }
    }
    public abstract class AspPropertyDirectiveBase : JetBrains.ReSharper.Psi.Asp.Impl.Tree.AspDirective, JetBrains.ReSharper.Psi.Asp.Tree.IAspDirective, JetBrains.ReSharper.Psi.Asp.Tree.IAspPropertyDirective, JetBrains.ReSharper.Psi.Asp.Tree.IAspTreeNode, JetBrains.ReSharper.Psi.ExtensionsAPI.Caches2.ICachedTypeMemberDeclaration, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode, JetBrains.ReSharper.Psi.Tree.IDeclaration, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Tree.IXmlDocOwnerTreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebAttributeContainer<JetBrains.ReSharper.Psi.Asp.Tree.IAspDirectiveAttribute>, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode
    {
        protected AspPropertyDirectiveBase(JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType nodeType, JetBrains.ReSharper.Psi.Asp.Parsing.IAspTokenNodeTypes tokenTypes) { }
        public JetBrains.ReSharper.Psi.IDeclaredElement CachedDeclaredElement { get; set; }
        public JetBrains.ReSharper.Psi.IDeclaredElement DeclaredElement { get; }
        public abstract string DeclaredName { get; }
        protected abstract JetBrains.ReSharper.Psi.IDeclaredElement CreateDeclaredElement();
        public JetBrains.ReSharper.Psi.TreeTextRange GetNameRange() { }
        public System.Xml.XmlNode GetXMLDoc(bool inherit) { }
        public bool IsSynthetic() { }
        protected override void PreInit() { }
        public void SetName(string name) { }
    }
    public class AspReferenceDirective : JetBrains.ReSharper.Psi.Asp.Impl.Tree.AspDirective, JetBrains.ReSharper.Psi.Asp.Tree.IAspDirective, JetBrains.ReSharper.Psi.Asp.Tree.IAspReferenceDirective, JetBrains.ReSharper.Psi.Asp.Tree.IAspTreeNode, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebAttributeContainer<JetBrains.ReSharper.Psi.Asp.Tree.IAspDirectiveAttribute>, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode
    {
        public AspReferenceDirective(JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType nodeType, JetBrains.ReSharper.Psi.Asp.Parsing.IAspTokenNodeTypes tokenTypes) { }
        public JetBrains.ReSharper.Psi.Asp.Tree.IAspDirectiveAttribute ControlAttribute { get; }
        public JetBrains.ReSharper.Psi.Resolve.IReference ControlPathReference { get; }
        public JetBrains.ReSharper.Psi.Asp.Tree.IAspDirectiveAttribute PageAttribute { get; }
        public JetBrains.ReSharper.Psi.Resolve.IReference PagePathReference { get; }
        public JetBrains.ReSharper.Psi.Asp.Tree.IAspDirectiveAttribute VirtualPathAttribute { get; }
        public JetBrains.ReSharper.Psi.Resolve.IReference VirtualPathReference { get; }
    }
    public class AspRegisterDirective : JetBrains.ReSharper.Psi.Asp.Impl.Tree.AspDirective, JetBrains.ReSharper.Psi.Asp.Tree.IAspDirective, JetBrains.ReSharper.Psi.Asp.Tree.IAspRegisterDirective, JetBrains.ReSharper.Psi.Asp.Tree.IAspTreeNode, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.TagPrefixes.ITagPrefixHolder, JetBrains.ReSharper.Psi.Web.Tree.IWebAttributeContainer<JetBrains.ReSharper.Psi.Asp.Tree.IAspDirectiveAttribute>, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode
    {
        public AspRegisterDirective(JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType nodeType, JetBrains.ReSharper.Psi.Asp.Parsing.IAspTokenNodeTypes tokenTypes) { }
        public string Assembly { get; }
        public JetBrains.ReSharper.Psi.Resolve.IReference NamespaceReference { get; }
        public JetBrains.ReSharper.Psi.Resolve.IReference SrcPathReference { get; }
        public JetBrains.ReSharper.Psi.Web.TagPrefixes.ITagNameDeclaration TagNameDeclaration { get; }
        public JetBrains.ReSharper.Psi.Web.TagPrefixes.ITagPrefixDeclaration TagPrefixDeclaration { get; }
        public JetBrains.Util.FileSystemPath TargetPath { get; }
    }
    public abstract class AspRenderBlock : JetBrains.ReSharper.Psi.Asp.Impl.Tree.AspCompositeElement, JetBrains.ReSharper.Psi.Asp.Tree.IAspElementWithCodeBlock, JetBrains.ReSharper.Psi.Asp.Tree.IAspRenderBlock, JetBrains.ReSharper.Psi.Asp.Tree.IAspTreeNode, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode, JetBrains.ReSharper.Psi.Tree.IChameleonNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebCodeBlock, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode
    {
        protected AspRenderBlock(JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType nodeType, JetBrains.ReSharper.Psi.Asp.Parsing.IAspTokenNodeTypes tokenTypes) { }
        public string CodeText { get; set; }
        public JetBrains.ReSharper.Psi.ITreeRange CodeTokens { get; }
        public JetBrains.ReSharper.Psi.Html.Tree.IHtmlToken EndToken { get; }
        public bool IsOpened { get; }
        public JetBrains.ReSharper.Psi.Html.Tree.IHtmlToken StartToken { get; }
        protected abstract JetBrains.ReSharper.Psi.Parsing.TokenNodeType StartTokenNodeType { get; }
        public override TReturn AcceptVisitor<TContext, TReturn>(JetBrains.ReSharper.Psi.Html.Tree.HtmlTreeVisitor<TContext, TReturn> visitor, TContext context) { }
        public static JetBrains.ReSharper.Psi.Asp.Impl.Tree.AspRenderBlock Create(JetBrains.ReSharper.Psi.Html.Parsing.IHtmlTokenNodeType<JetBrains.ReSharper.Psi.Asp.Parsing.IAspTokenNodeTypes> tokenType, JetBrains.ReSharper.Psi.Asp.Tree.AspElementTypes elementTypes) { }
        public override short GetChildRole(JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.TreeElement child) { }
        public virtual JetBrains.ReSharper.Psi.Tree.IChameleonNode ReSync(JetBrains.ReSharper.Psi.Parsing.CachingLexer cachingLexer, JetBrains.ReSharper.Psi.TreeTextRange changedRange, int insertedTextLen) { }
    }
    public sealed class AspScriptTag : JetBrains.ReSharper.Psi.Asp.Impl.Tree.AspTag, JetBrains.ReSharper.Psi.Asp.Tree.IAspElementWithCodeBlock, JetBrains.ReSharper.Psi.Asp.Tree.IAspScriptTag, JetBrains.ReSharper.Psi.Asp.Tree.IAspTag, JetBrains.ReSharper.Psi.Asp.Tree.IAspTreeNode, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTag, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTagContainer, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTagContainerMarker, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode, JetBrains.ReSharper.Psi.Html.Tree.IScriptTag, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebAttributeContainer<JetBrains.ReSharper.Psi.Html.Tree.ITagAttribute>, JetBrains.ReSharper.Psi.Web.Tree.IWebCodeBlock, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode
    {
        public AspScriptTag(JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType nodeType, JetBrains.ReSharper.Psi.Asp.Parsing.IAspTokenNodeTypes tokenTypes) { }
        public string CodeText { get; set; }
        public JetBrains.ReSharper.Psi.ITreeRange CodeTokens { get; }
        public override JetBrains.ReSharper.Psi.Html.Tree.IHtmlTagFooter Footer { get; }
        public override bool HasRenderMethod { get; }
        public JetBrains.ReSharper.Psi.PsiLanguageType LanguageType { get; }
        public override short GetChildRole(JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.TreeElement child) { }
        protected override System.Collections.Generic.IList<JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.TreeElement> Indent(int parentIndent, int step) { }
        protected override void IndentContent(int indent, int step) { }
        protected override JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.TreeElement IndentFooter(int indent) { }
        public override void UpdateHeaderInformation() { }
    }
    public class AspSubstitution : JetBrains.ReSharper.Psi.Asp.Impl.Tree.AspCompositeElement, JetBrains.ReSharper.Psi.Asp.Tree.IAspSubstitution, JetBrains.ReSharper.Psi.Asp.Tree.IAspTreeNode, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode
    {
        public AspSubstitution(JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType nodeType, JetBrains.ReSharper.Psi.Asp.Parsing.IAspTokenNodeTypes tokenTypes) { }
        public JetBrains.ReSharper.Psi.Html.Tree.IHtmlToken BodyToken { get; }
        protected JetBrains.ReSharper.Psi.Parsing.TokenNodeType StartTokenNodeType { get; }
        public override TReturn AcceptVisitor<TContext, TReturn>(JetBrains.ReSharper.Psi.Html.Tree.HtmlTreeVisitor<TContext, TReturn> visitor, TContext context) { }
        public override short GetChildRole(JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.TreeElement child) { }
    }
    public class AspTag : JetBrains.ReSharper.Psi.Html.Impl.Tree.HtmlTag, JetBrains.ReSharper.Psi.Asp.Tree.IAspTag, JetBrains.ReSharper.Psi.Asp.Tree.IAspTreeNode, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTag, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTagContainer, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTagContainerMarker, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebAttributeContainer<JetBrains.ReSharper.Psi.Html.Tree.ITagAttribute>, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode
    {
        public AspTag(JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType nodeType, JetBrains.ReSharper.Psi.Html.Parsing.IHtmlTokenNodeTypes tokenTypes) { }
        public override bool AllowSelfClose { get; }
        public virtual bool HasRenderMethod { get; }
        public bool IsRunatServer { get; }
        public override bool ShouldBeEmpty { get; }
        public JetBrains.ReSharper.Psi.Asp.Parsing.IAspTokenNodeTypes TokenTypes { get; }
        public bool CanDeclareField() { }
        protected override JetBrains.ReSharper.Psi.Tree.ReferenceCollection CreateFirstClassReferences() { }
        public System.Nullable<bool> DoParseChildrenAsProperties() { }
        public JetBrains.ReSharper.Psi.IType GetTagType() { }
        protected override void PreInit() { }
        public override void UpdateHeaderInformation() { }
    }
    public class AspTagAttribute : JetBrains.ReSharper.Psi.Html.Impl.Tree.TagAttribute, JetBrains.ReSharper.Psi.Asp.Tree.IAspTagAttribute, JetBrains.ReSharper.Psi.Asp.Tree.IAspTreeNode, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode, JetBrains.ReSharper.Psi.Html.Tree.ITagAttribute, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebAttribute, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode
    {
        public AspTagAttribute(JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType nodeType, JetBrains.ReSharper.Psi.Html.Parsing.IHtmlTokenNodeTypes tokenTypes) { }
        public JetBrains.ReSharper.Psi.Asp.Parsing.IAspTokenNodeTypes TokenTypes { get; }
        protected override JetBrains.ReSharper.Psi.Tree.ReferenceCollection CreateFirstClassReferences() { }
    }
    public class AspTagFooter : JetBrains.ReSharper.Psi.Html.Impl.Tree.HtmlTagFooter, JetBrains.ReSharper.Psi.Asp.Tree.IAspTagFooter, JetBrains.ReSharper.Psi.Asp.Tree.IAspTagNameContainer, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTagFooter, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode, JetBrains.ReSharper.Psi.Html.Tree.ITagNameContainer, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode
    {
        public AspTagFooter(JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType nodeType, JetBrains.ReSharper.Psi.Html.Parsing.IHtmlTokenNodeTypes tokenTypes) { }
        public JetBrains.ReSharper.Psi.Asp.Tree.IAspTag Tag { get; }
        protected override JetBrains.ReSharper.Psi.Tree.ReferenceCollection CreateFirstClassReferences() { }
    }
    public sealed class AspTagHeader : JetBrains.ReSharper.Psi.Html.Impl.Tree.HtmlTagHeader, JetBrains.ReSharper.Psi.Asp.Tree.IAspTagHeader, JetBrains.ReSharper.Psi.Asp.Tree.IAspTagNameContainer, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTagHeader, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode, JetBrains.ReSharper.Psi.Html.Tree.ITagNameContainer, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebAttributeContainer<JetBrains.ReSharper.Psi.Html.Tree.ITagAttribute>, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode
    {
        public AspTagHeader(JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType nodeType, JetBrains.ReSharper.Psi.Html.Parsing.IHtmlTokenNodeTypes tokenTypes) { }
        public JetBrains.ReSharper.Psi.Asp.Tree.IAspTag Tag { get; }
    }
    public class AspToken : JetBrains.ReSharper.Psi.Html.Impl.Tree.HtmlToken<JetBrains.ReSharper.Psi.Asp.Parsing.IAspTokenNodeTypes>, JetBrains.ReSharper.Psi.Asp.Tree.IAspToken, JetBrains.ReSharper.Psi.Asp.Tree.IAspTreeNode, JetBrains.ReSharper.Psi.Html.Tree.IHtmlToken, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode, JetBrains.ReSharper.Psi.Tree.ITokenNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode { }
    public interface IAspHashableDeclaration : JetBrains.ReSharper.Psi.Dependencies.IHashableDeclaration, JetBrains.ReSharper.Psi.Tree.IDeclaration, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Tree.IXmlDocOwnerTreeNode
    {
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Asp.Impl.Tree.IAspHashableDeclaration> Children { get; }
        bool IsInternal { get; }
        JetBrains.ReSharper.Psi.Dependencies.IHashableEntityInfo[] CalcAllHashes(string parentQualifiedName, out string qualifiedName);
    }
    public class IdTagAttribute : JetBrains.ReSharper.Psi.Asp.Impl.Tree.AspTagAttribute, JetBrains.ReSharper.Psi.Asp.Impl.Tree.IAspHashableDeclaration, JetBrains.ReSharper.Psi.Asp.Tree.IAspTreeNode, JetBrains.ReSharper.Psi.Asp.Tree.IIdTagAttribute, JetBrains.ReSharper.Psi.Dependencies.IHashableDeclaration, JetBrains.ReSharper.Psi.ExtensionsAPI.Caches2.ICachedTypeMemberDeclaration, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode, JetBrains.ReSharper.Psi.Html.Tree.ITagAttribute, JetBrains.ReSharper.Psi.Tree.IDeclaration, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Tree.ITypeMemberDeclaration, JetBrains.ReSharper.Psi.Tree.IXmlDocOwnerTreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebAttribute, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode
    {
        public IdTagAttribute(JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType nodeType, JetBrains.ReSharper.Psi.Asp.Parsing.IAspTokenNodeTypes tokenTypes) { }
        public JetBrains.ReSharper.Psi.Asp.Html.IHtmlControl DeclaredElement { get; }
        public string DeclaredName { get; }
        public JetBrains.ReSharper.Psi.Dependencies.Hash CalcHash() { }
        public JetBrains.ReSharper.Psi.Tree.ITypeDeclaration GetContainingTypeDeclaration() { }
        public JetBrains.ReSharper.Psi.DeclaredElementType GetDeclaredElementType() { }
        public JetBrains.ReSharper.Psi.TreeTextRange GetNameRange() { }
        public System.Xml.XmlNode GetXMLDoc(bool inherit) { }
        public bool IsSynthetic() { }
        protected override void PreInit() { }
        public void SetName(string name) { }
    }
    public class SkinFile : JetBrains.ReSharper.Psi.Asp.Impl.Tree.AspFile, JetBrains.ReSharper.Psi.Asp.Tree.IAspFile, JetBrains.ReSharper.Psi.Asp.Tree.IAspTreeNode, JetBrains.ReSharper.Psi.Asp.Tree.IAspTypeDeclaration, JetBrains.ReSharper.Psi.Asp.Tree.ISkinFile, JetBrains.ReSharper.Psi.ExtensionsAPI.Caches2.ICachedDeclaration2, JetBrains.ReSharper.Psi.Html.Tree.IHtmlFile, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTagContainer, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTagContainerMarker, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode, JetBrains.ReSharper.Psi.Tree.IDeclaration, JetBrains.ReSharper.Psi.Tree.IFile, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Tree.ITypeDeclaration, JetBrains.ReSharper.Psi.Tree.ITypeDeclarationHolder, JetBrains.ReSharper.Psi.Tree.IXmlDocOwnerTreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebFile, JetBrains.ReSharper.Psi.Web.Tree.IWebFileWithCodeBehind, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode
    {
        public SkinFile(JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType nodeType, JetBrains.ReSharper.Psi.Asp.Parsing.IAspTokenNodeTypes tokenTypes) { }
        protected override JetBrains.ReSharper.Psi.Html.Impl.Tree.HtmlFileData CreateData(JetBrains.ReSharper.Psi.Tree.IFile file) { }
        public System.Collections.Generic.IDictionary<string, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTag> GetSkinTags() { }
    }
    public class SkinFileData : JetBrains.ReSharper.Psi.Asp.Impl.Tree.AspFileData
    {
        public SkinFileData(JetBrains.ReSharper.Psi.Tree.ITreeNode node) { }
        public System.Collections.Generic.IDictionary<string, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTag> GetSkinTags() { }
        protected override bool ProcessNode(JetBrains.ReSharper.Psi.Tree.ITreeNode node) { }
        protected override void RemoveDeadElements() { }
    }
}
namespace JetBrains.ReSharper.Psi.Asp.Modules
{
    
    [JetBrains.ReSharper.Psi.Modules.ModuleReferencerAttribute(Priority=1)]
    public class WebsiteWebModuleReferencer : JetBrains.ReSharper.Psi.Modules.IModuleReferencer
    {
        public bool CanReferenceModule(JetBrains.ReSharper.Psi.Modules.IPsiModule module, JetBrains.ReSharper.Psi.Modules.IPsiModule moduleToReference, JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext context) { }
        public bool ReferenceModule(JetBrains.ReSharper.Psi.Modules.IPsiModule module, JetBrains.ReSharper.Psi.Modules.IPsiModule moduleToReference) { }
        public bool ReferenceModuleWithType(JetBrains.ReSharper.Psi.Modules.IPsiModule module, JetBrains.ReSharper.Psi.ITypeElement typeToReference, JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext resolveContext) { }
    }
}
namespace JetBrains.ReSharper.Psi.Asp.Naming2
{
    
    public abstract class AspCodeBehindNamingConsistencyChecker : JetBrains.ReSharper.Psi.Naming.Interfaces.INamingConsistencyChecker
    {
        public void Check(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration, JetBrains.ReSharper.Psi.Naming.Interfaces.INamingPolicyProvider namingPolicyProvider, out bool isFinalResult, out JetBrains.ReSharper.Psi.Naming.Impl.NamingConsistencyCheckResult result) { }
        public bool IsApplicable(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.Asp.AspLanguage))]
    public class AspHasConfigurableWebProjectNamingSettings : JetBrains.ReSharper.Psi.Web.Naming.IConfigurableWebProjectNamingSettings { }
    [JetBrains.ReSharper.Psi.Naming.Elements.NamedElementsBagAttribute(typeof(JetBrains.ReSharper.Psi.Asp.AspLanguage))]
    public class AspNamedElements : JetBrains.ReSharper.Psi.Naming.Elements.ElementKindOfElementType
    {
        public static readonly JetBrains.ReSharper.Psi.Naming.Elements.IElementKind ASP_FIELD;
        public static readonly JetBrains.ReSharper.Psi.Naming.Elements.IElementKind ASP_HTML_CONTROL;
        public static readonly JetBrains.ReSharper.Psi.Naming.Elements.IElementKind ASP_TAG_NAME;
        public static readonly JetBrains.ReSharper.Psi.Naming.Elements.IElementKind ASP_TAG_PREFIX;
        protected AspNamedElements([JetBrains.Annotations.NotNullAttribute()] string name, string presentableName, System.Func<JetBrains.ReSharper.Psi.IDeclaredElement, bool> isApplicable, JetBrains.ReSharper.Psi.Naming.Settings.NamingRule namingRule) { }
        public override JetBrains.ReSharper.Psi.PsiLanguageType Language { get; }
        public override JetBrains.ReSharper.Psi.Naming.Settings.NamingRule GetDefaultRule() { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.Asp.AspLanguage))]
    public class AspNamingLanguageService : JetBrains.ReSharper.Psi.Naming.Impl.ClrNamingLanguageServiceBase
    {
        public AspNamingLanguageService(JetBrains.ReSharper.Psi.Asp.AspLanguage language) { }
    }
}
namespace JetBrains.ReSharper.Psi.Asp.Parsing
{
    
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.Asp.AspLanguage))]
    public class AspElementFactory : JetBrains.ReSharper.Psi.Html.Parsing.HtmlElementFactory
    {
        public AspElementFactory(JetBrains.ReSharper.Psi.Html.Parsing.IWebTreeBuilderFactory builderFactory) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ReSharper.Psi.Asp.Tree.IAspDirective CreateAspDirective(string directiveText, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode contextElement) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ReSharper.Psi.Asp.Tree.IAspDirective CreateAspDirective([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode contextElement, string directiveName, System.Collections.Generic.IDictionary<string, string> attributes) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ReSharper.Psi.Asp.Tree.IAspDirective CreateAspDirective([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode contextElement, string directiveName, params JetBrains.Util.Pair<, >[] attributes) { }
        public JetBrains.ReSharper.Psi.Html.Tree.IHtmlTag CreateCompoundRunatServerHtmlTag(string tagName, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode contextElement) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ReSharper.Psi.Asp.Tree.IAspRenderBlock CreateRenderBlock(string blockText, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode contextElement) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.ReSharper.Psi.Asp.Parsing.AspElementFactory GetInstance(JetBrains.ReSharper.Psi.PsiLanguageType lang, JetBrains.ReSharper.Psi.ILanguageManager languageManager = null) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.Util.JetTuple<JetBrains.ReSharper.Psi.Html.Tree.IHtmlTag, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTag, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTag> WrapChildrenAndCreateHead(JetBrains.ReSharper.Psi.Html.Tree.IHtmlFile aspFile) { }
    }
    public class AspTreeBuilder : JetBrains.ReSharper.Psi.Asp.Parsing.AspTreeBuilderBase<JetBrains.ReSharper.Psi.Asp.Tree.IAspFile, JetBrains.ReSharper.Psi.Asp.Impl.Tree.AspFile, JetBrains.ReSharper.Psi.Asp.Tree.AspElementTypes, JetBrains.ReSharper.Psi.Asp.Parsing.IAspTokenNodeTypes>
    {
        public AspTreeBuilder(JetBrains.ReSharper.Psi.Asp.AspLanguage language, JetBrains.ReSharper.Psi.Asp.Tree.AspElementTypes elementTypes, JetBrains.ReSharper.Psi.Asp.Parsing.IAspTokenNodeTypes tokenTypes, System.Collections.Generic.ICollection<string> templatesMimeTypes, int depthThreshold) { }
        protected override JetBrains.ReSharper.Psi.Asp.Impl.Tree.AspFile CreateFile(JetBrains.ReSharper.Psi.Html.Parsing.HtmlStackedLexer stackedLexer, out JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeElement compositeElement) { }
        protected override JetBrains.ReSharper.Psi.Html.Impl.Tree.HtmlToken<JetBrains.ReSharper.Psi.Asp.Parsing.IAspTokenNodeTypes> CreateToken(JetBrains.ReSharper.Psi.Html.Parsing.HtmlTokenNodeType<JetBrains.ReSharper.Psi.Asp.Parsing.IAspTokenNodeTypes> tokenType) { }
    }
    public abstract class AspTreeBuilderBase<TIAspFile, TAspFile, TAspElementTypes, TAspTokenNodeTypes> : JetBrains.ReSharper.Psi.Html.Parsing.HtmlTreeBuilderBase<TIAspFile, TAspFile, TAspElementTypes, TAspTokenNodeTypes>
        where TIAspFile : JetBrains.ReSharper.Psi.Asp.Tree.IAspFile
        where TAspFile : JetBrains.ReSharper.Psi.Asp.Impl.Tree.AspFile, TIAspFile
        where TAspElementTypes : JetBrains.ReSharper.Psi.Asp.Tree.AspElementTypes
        where TAspTokenNodeTypes :  class, JetBrains.ReSharper.Psi.Asp.Parsing.IAspTokenNodeTypes
    {
        protected AspTreeBuilderBase(JetBrains.ReSharper.Psi.Asp.AspLanguage language, TAspElementTypes elementTypes, TAspTokenNodeTypes tokenTypes, System.Collections.Generic.ICollection<string> templatesMimeTypes, int depthThreshold) { }
        public override bool CanHaveServerSideNodes { get; }
        protected override JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet HandlingTokens { get; }
        protected override JetBrains.ReSharper.Psi.Html.Impl.Tree.TagAttribute ConvertTagAttribute(JetBrains.ReSharper.Psi.Html.Impl.Tree.TagAttribute originalAttribute) { }
        protected override JetBrains.ReSharper.Psi.Html.Parsing.HtmlTreeBuilderBase<TIAspFile, TAspFile, TAspElementTypes, TAspTokenNodeTypes>.FindParentToClose DoFindParentToClose(JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeElement e) { }
        protected override bool ParseAdditionalConstruct(ref JetBrains.ReSharper.Psi.Html.Parsing.HtmlTokenNodeType<> tokenType, ref JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeElement compositeElement) { }
        protected override void ParseSpecialTag(JetBrains.ReSharper.Psi.Html.Impl.Tree.HtmlTag tag, JetBrains.ReSharper.Psi.Html.Impl.Tree.HtmlTagHeader header, JetBrains.ReSharper.Psi.Parsing.TokenNodeType bodyTokenType) { }
        protected override JetBrains.ReSharper.Psi.Html.Impl.Tree.HtmlTag ParseTag(JetBrains.ReSharper.Psi.Html.Impl.Tree.HtmlTagHeader tagHeader) { }
        public override System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Tree.ITreeNode> SearchServerSideNodes(JetBrains.ReSharper.Psi.Tree.ITreeNode nestedFile) { }
        protected override JetBrains.ReSharper.Psi.Html.Parsing.ServerSideNodeKinds ToNodeWithKind(JetBrains.ReSharper.Psi.Tree.ITreeNode node) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.Asp.AspLanguage))]
    public class AspTreeBuilderFactory : JetBrains.ReSharper.Psi.Html.Parsing.HtmlTreeBuilderFactory
    {
        public AspTreeBuilderFactory(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.Settings.ISettingsStore settingsStore, JetBrains.ReSharper.Psi.Asp.AspLanguage language, JetBrains.ReSharper.Psi.Asp.Tree.AspElementTypes elementTypes, JetBrains.ReSharper.Psi.Asp.Parsing.IAspTokenNodeTypes tokenTypes, JetBrains.ReSharper.Psi.PerformanceThreshold.PerformanceThresholds thresholds) { }
        public override JetBrains.ReSharper.Psi.Html.Parsing.IWebTreeBuilder CreateTreeBuilder() { }
    }
    public interface IAspTokenNodeType : JetBrains.ReSharper.Psi.Html.Parsing.IHtmlTokenNodeType<JetBrains.ReSharper.Psi.Asp.Parsing.IAspTokenNodeTypes>, JetBrains.ReSharper.Psi.Parsing.ITokenNodeType { }
    public interface IAspTokenNodeTypes : JetBrains.ReSharper.Psi.Html.Parsing.IHtmlCompoundTokenNodeTypes, JetBrains.ReSharper.Psi.Html.Parsing.IHtmlTokenNodeTypes
    {
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Parsing.TokenNodeType ASP_BLOCK_END { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Parsing.TokenNodeType ASP_BLOCK_START { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Parsing.TokenNodeType ASP_COMMENT_BODY { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Parsing.TokenNodeType ASP_COMMENT_END { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Parsing.TokenNodeType ASP_COMMENT_START { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Parsing.TokenNodeType ASP_DATA_BINDER_START { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Parsing.TokenNodeType ASP_DIRECTIVE_START { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Parsing.TokenNodeType ASP_ERROR_BLOCK_END { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Parsing.TokenNodeType ASP_EXPR_START { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Parsing.TokenNodeType ASP_HTML_ENCODED_DATA_BINDER_START { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Parsing.TokenNodeType ASP_HTML_ENCODING_START { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Parsing.TokenNodeType ASP_PREPROCESSOR_BLOCK_START { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Parsing.TokenNodeType ASP_SUBSTITUTION_START { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Parsing.TokenNodeType CODE { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet CodeBlocksStart { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Parsing.TokenNodeType SUBSTITUTION_BODY { get; }
    }
    public class SkinTreeBuilder : JetBrains.ReSharper.Psi.Asp.Parsing.AspTreeBuilderBase<JetBrains.ReSharper.Psi.Asp.Tree.ISkinFile, JetBrains.ReSharper.Psi.Asp.Impl.Tree.SkinFile, JetBrains.ReSharper.Psi.Asp.Tree.SkinElementTypes, JetBrains.ReSharper.Psi.Asp.Parsing.IAspTokenNodeTypes>
    {
        public SkinTreeBuilder(JetBrains.ReSharper.Psi.Asp.SkinLanguage language, JetBrains.ReSharper.Psi.Asp.Tree.SkinElementTypes elementTypes, JetBrains.ReSharper.Psi.Asp.Parsing.IAspTokenNodeTypes tokenTypes, System.Collections.Generic.ICollection<string> templatesMimeTypes, int depthThreshold) { }
        protected override JetBrains.ReSharper.Psi.Html.Impl.Tree.TagAttribute ConvertTagAttribute(JetBrains.ReSharper.Psi.Html.Impl.Tree.TagAttribute originalAttribute) { }
        protected override JetBrains.ReSharper.Psi.Asp.Impl.Tree.SkinFile CreateFile(JetBrains.ReSharper.Psi.Html.Parsing.HtmlStackedLexer stackedLexer, out JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeElement compositeElement) { }
        protected override JetBrains.ReSharper.Psi.Html.Impl.Tree.HtmlToken<JetBrains.ReSharper.Psi.Asp.Parsing.IAspTokenNodeTypes> CreateToken(JetBrains.ReSharper.Psi.Html.Parsing.HtmlTokenNodeType<JetBrains.ReSharper.Psi.Asp.Parsing.IAspTokenNodeTypes> tokenType) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.Asp.SkinLanguage))]
    public class SkinTreeBuilderFactory : JetBrains.ReSharper.Psi.Asp.Parsing.AspTreeBuilderFactory
    {
        public SkinTreeBuilderFactory(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.Settings.ISettingsStore settingsStore, JetBrains.ReSharper.Psi.Asp.SkinLanguage language, JetBrains.ReSharper.Psi.Asp.Tree.SkinElementTypes elementTypes, JetBrains.ReSharper.Psi.Asp.Parsing.IAspTokenNodeTypes tokenTypes, JetBrains.ReSharper.Psi.PerformanceThreshold.PerformanceThresholds thresholds) { }
        public override JetBrains.ReSharper.Psi.Html.Parsing.IWebTreeBuilder CreateTreeBuilder() { }
    }
}
namespace JetBrains.ReSharper.Psi.Asp.References
{
    
    [System.FlagsAttribute()]
    public enum AttributeOrPropertyReferenceResolveTarget
    {
        NONE = 0,
        PROPERTY = 1,
        EVENT = 2,
        HTML_ATTRIBUTE = 4,
    }
    public interface IAspMethodReference : JetBrains.ReSharper.Psi.Html.References.IHtmlCompleteableReference, JetBrains.ReSharper.Psi.Html.References.IHtmlSmartCompleteableReference, JetBrains.ReSharper.Psi.Resolve.ICompleteableReference, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.Util.IUserDataHolder
    {
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.IEnumerable<JetBrains.Util.Pair<JetBrains.ReSharper.Psi.IType, string>> GetParameterTypes();
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.IDeclaredType GetQualifierType();
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IType GetReturnType();
    }
    public interface IBaseFieldReference : JetBrains.ReSharper.Psi.Html.References.IHtmlCompleteableReference, JetBrains.ReSharper.Psi.Html.References.IHtmlSmartCompleteableReference, JetBrains.ReSharper.Psi.Resolve.ICompleteableReference, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.Util.IUserDataHolder { }
    public interface IContentPlaceholderReference : JetBrains.ReSharper.Psi.Asp.References.IControlIdReference, JetBrains.ReSharper.Psi.Html.References.IHtmlCompleteableReference, JetBrains.ReSharper.Psi.Html.References.IHtmlSmartCompleteableReference, JetBrains.ReSharper.Psi.Resolve.ICompleteableReference, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.Util.IUserDataHolder
    {
        JetBrains.ReSharper.Psi.Html.Tree.IHtmlAttributeValue GetElement();
    }
    public interface IControlIdReference : JetBrains.ReSharper.Psi.Html.References.IHtmlCompleteableReference, JetBrains.ReSharper.Psi.Html.References.IHtmlSmartCompleteableReference, JetBrains.ReSharper.Psi.Resolve.ICompleteableReference, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.Util.IUserDataHolder { }
    public interface IDevExpressTypeReference : JetBrains.ReSharper.Psi.Html.References.IHtmlCompleteableReference, JetBrains.ReSharper.Psi.Html.References.IHtmlImportCompleteableReference, JetBrains.ReSharper.Psi.Html.References.IHtmlImportTypeCompleteableReference, JetBrains.ReSharper.Psi.Html.References.IHtmlSmartCompleteableReference, JetBrains.ReSharper.Psi.Resolve.ICompleteableReference, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.Util.IUserDataHolder { }
    public interface IEnumMemberReference : JetBrains.ReSharper.Psi.Html.References.IHtmlCompleteableReference, JetBrains.ReSharper.Psi.Html.References.IHtmlReferenceWithCustomData, JetBrains.ReSharper.Psi.Html.References.IHtmlSmartCompleteableReference, JetBrains.ReSharper.Psi.Resolve.ICompleteableReference, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.Util.IUserDataHolder { }
    public interface IEventHandlerReference : JetBrains.ReSharper.Psi.Html.References.IHtmlCompleteableReference, JetBrains.ReSharper.Psi.Html.References.IHtmlReferenceWithCustomData, JetBrains.ReSharper.Psi.Html.References.IHtmlSmartCompleteableReference, JetBrains.ReSharper.Psi.Resolve.ICompleteableReference, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.ReSharper.Psi.Resolve.IReferenceToDelegateCreation, JetBrains.Util.IUserDataHolder
    {
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.DeclaredElementInstance<JetBrains.ReSharper.Psi.IEvent> Event { get; }
    }
    public interface IHtmlAttributeOrPropertyReference : JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IQualifiableReferenceBase, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IQualifiableReferenceWithGlobalSymbolTable, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IReferenceWithGlobalSymbolTable, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IReferenceWithQualifier, JetBrains.ReSharper.Psi.Html.References.IHtmlAttributeReference, JetBrains.ReSharper.Psi.Html.References.IHtmlCompleteableReference, JetBrains.ReSharper.Psi.Html.References.IHtmlSmartCompleteableReference, JetBrains.ReSharper.Psi.Resolve.ICompleteableReference, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.Util.IUserDataHolder
    {
        JetBrains.ReSharper.Psi.Asp.References.AttributeOrPropertyReferenceResolveTarget GetResolveTarget();
    }
    public interface IHtmlTagOrPropertyReference : JetBrains.ReSharper.Psi.Html.Impl.References.IQualifierReference, JetBrains.ReSharper.Psi.Html.References.IHtmlCompleteableReference, JetBrains.ReSharper.Psi.Html.References.IHtmlImportCompleteableReference, JetBrains.ReSharper.Psi.Html.References.IHtmlImportTypeCompleteableReference, JetBrains.ReSharper.Psi.Html.References.IHtmlSmartCompleteableReference, JetBrains.ReSharper.Psi.Html.References.IHtmlTagReference, JetBrains.ReSharper.Psi.Resolve.ICompleteableReference, JetBrains.ReSharper.Psi.Resolve.IQualifier, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.Util.IUserDataHolder
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Asp.Tree.IAspTag GetAspTag();
        JetBrains.ReSharper.Psi.Asp.References.TagOrPropertyReferenceResolveTarget GetResolveTarget();
    }
    public interface IOdsMethodParameterReference : JetBrains.ReSharper.Psi.Html.References.IHtmlCompleteableReference, JetBrains.ReSharper.Psi.Html.References.IHtmlSmartCompleteableReference, JetBrains.ReSharper.Psi.Resolve.ICompleteableReference, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.Util.IUserDataHolder { }
    public interface IOdsMethodReference : JetBrains.ReSharper.Psi.Asp.References.IAspMethodReference, JetBrains.ReSharper.Psi.Html.References.IHtmlCompleteableReference, JetBrains.ReSharper.Psi.Html.References.IHtmlSmartCompleteableReference, JetBrains.ReSharper.Psi.Resolve.ICompleteableReference, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.Util.IUserDataHolder { }
    public interface ISkinReference : JetBrains.ReSharper.Psi.Asp.References.IControlIdReference, JetBrains.ReSharper.Psi.Html.References.IHtmlCompleteableReference, JetBrains.ReSharper.Psi.Html.References.IHtmlSmartCompleteableReference, JetBrains.ReSharper.Psi.Resolve.ICompleteableReference, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.Util.IUserDataHolder
    {
        JetBrains.ReSharper.Psi.Html.Tree.IHtmlAttributeValue GetElement();
    }
    public interface ISubPropertyReference : JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IQualifiableReferenceBase, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IQualifiableReferenceWithGlobalSymbolTable, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IReferenceWithGlobalSymbolTable, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IReferenceWithQualifier, JetBrains.ReSharper.Psi.Html.Impl.References.IQualifierReference, JetBrains.ReSharper.Psi.Html.References.IHtmlCompleteableReference, JetBrains.ReSharper.Psi.Html.References.IHtmlSmartCompleteableReference, JetBrains.ReSharper.Psi.Resolve.ICompleteableReference, JetBrains.ReSharper.Psi.Resolve.IQualifier, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.Util.IUserDataHolder { }
    public interface ITagNameReference : JetBrains.ReSharper.Psi.Html.References.IHtmlCompleteableReference, JetBrains.ReSharper.Psi.Html.References.IHtmlImportCompleteableReference, JetBrains.ReSharper.Psi.Html.References.IHtmlImportTypeCompleteableReference, JetBrains.ReSharper.Psi.Html.References.IHtmlSmartCompleteableReference, JetBrains.ReSharper.Psi.Resolve.ICompleteableReference, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.Util.IUserDataHolder
    {
        string GetTagPrefix();
    }
    public interface ITagPrefixReference : JetBrains.ReSharper.Psi.Html.References.IHtmlCompleteableReference, JetBrains.ReSharper.Psi.Html.References.IHtmlSmartCompleteableReference, JetBrains.ReSharper.Psi.Resolve.ICompleteableReference, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.Util.IUserDataHolder { }
    public interface IThemeReference : JetBrains.ReSharper.Psi.Html.References.IHtmlCompleteableReference, JetBrains.ReSharper.Psi.Html.References.IHtmlSmartCompleteableReference, JetBrains.ReSharper.Psi.Resolve.ICompleteableReference, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.Util.IUserDataHolder { }
    public enum TagOrPropertyReferenceResolveTarget
    {
        UNKNOWN = 0,
        PROPERTY = 1,
        PROPERTY_OR_TAG = 2,
        TAG_WARNING = 3,
        TAG_IGNORABLE = 4,
        TAG_ERROR = 5,
    }
}
namespace JetBrains.ReSharper.Psi.Asp.Resolve
{
    
    public abstract class AspImportedNamespaces
    {
        public static System.Collections.Generic.IEnumerable<string> GetPreimportedNamespaces([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IProjectFile projectFile) { }
        protected abstract System.Collections.Generic.IEnumerable<string> GetPreimportedNamespacesFor([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IProjectFile projectFile);
    }
    public interface IAspResolveInfoWithUsings : JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IResolveInfo
    {
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Asp.Tree.IAspDirective> UsingDirectives { get; }
    }
}
namespace JetBrains.ReSharper.Psi.Asp.Resources
{
    
    public sealed class PsiAspThemedIcons
    {
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Psi.Asp;component/resources/PsiAspThemedIcons/ThemedIcons.Psi" +
            "Asp.Generated.Xaml", 5, "AspContent")]
        public sealed class AspContent : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Psi.Asp;component/resources/PsiAspThemedIcons/ThemedIcons.Psi" +
            "Asp.Generated.Xaml", 0, "AspContentPlaceholder")]
        public sealed class AspContentPlaceholder : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Psi.Asp;component/resources/PsiAspThemedIcons/ThemedIcons.Psi" +
            "Asp.Generated.Xaml", 4, "AspMasterPage")]
        public sealed class AspMasterPage : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Psi.Asp;component/resources/PsiAspThemedIcons/ThemedIcons.Psi" +
            "Asp.Generated.Xaml", 1, "AspNet")]
        public sealed class AspNet : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Psi.Asp;component/resources/PsiAspThemedIcons/ThemedIcons.Psi" +
            "Asp.Generated.Xaml", 2, "AspTag")]
        public sealed class AspTag : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Psi.Asp;component/resources/PsiAspThemedIcons/ThemedIcons.Psi" +
            "Asp.Generated.Xaml", 3, "AspUserControl")]
        public sealed class AspUserControl : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
    }
}
namespace JetBrains.ReSharper.Psi.Asp.Symbols
{
    
    public interface IAspClassSymbol : JetBrains.ReSharper.Psi.Html.Symbols.IHtmlClassSymbol, JetBrains.ReSharper.Psi.Web.Symbols.IWebClassSymbol, JetBrains.ReSharper.Psi.Web.Symbols.IWebSymbol { }
    public interface IAspTagIdSymbol : JetBrains.ReSharper.Psi.Html.Symbols.IHtmlTagIdSymbol, JetBrains.ReSharper.Psi.Web.Symbols.IWebSymbol, JetBrains.ReSharper.Psi.Web.Symbols.IWebTagIdSymbol { }
}
namespace JetBrains.ReSharper.Psi.Asp.Tree
{
    
    public class static AspDirectiveAttributeExtensions
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public static string GetUnquotedValue([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Asp.Tree.IAspDirectiveAttribute attribute) { }
        public static JetBrains.ReSharper.Psi.TreeTextRange GetUnquotedValueRange([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Asp.Tree.IAspDirectiveAttribute attribute) { }
        public static JetBrains.ReSharper.Psi.TreeTextRange GetUnquotedValueRangeWithin([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Asp.Tree.IAspDirectiveAttribute attribute) { }
    }
    public class static AspDirectiveAttributeNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Psi.Asp.Tree.IAspDirectiveAttribute GetByValue([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Html.Tree.IHtmlToken valueToken) { }
    }
    public class static AspDirectiveExtensions
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Psi.Web.Directives.IWebDirectiveDeclaredElement GetDeclaredElement([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Asp.Tree.IAspDirective aspDirective) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Psi.Web.Directives.IWebDirectiveDeclaredElement GetDeclaredElementNoResolve([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Asp.Tree.IAspDirective aspDirective) { }
    }
    public class static AspDirectiveNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Psi.Asp.Tree.IAspDirective GetByAttribute([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Asp.Tree.IAspDirectiveAttribute attribute) { }
    }
    public class static AspElementExtensions
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.ReSharper.Psi.IType GetAspType([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode htmlTreeNode) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Psi.ITypeElement GetAspTypeElement([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode htmlTreeNode) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Psi.ITypeElement GetCodeBehindTypeElement([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode htmlTreeNode) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Psi.IPsiSourceFile GetMasterPageFile([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode aspElement, out string masterPageFileName) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ProjectModel.IProjectFolder GetTheme([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode aspElement, out string themeName) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Tree.IDeclaration> GetUserCodeBehindDeclarations([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Asp.Tree.IAspFile webFile) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Psi.ITypeElement GetUserCodeBehindTypeElement([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Asp.Tree.IAspFile aspFile, bool checkDirectives = True) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.Asp.AspLanguage))]
    public class AspElementTypes : JetBrains.ReSharper.Psi.Html.Tree.HtmlElementTypes
    {
        public readonly JetBrains.ReSharper.Psi.Asp.Tree.AspElementTypes.ASP_CODE_BLOCK_NODE_TYPE ASP_CODE_BLOCK;
        public readonly JetBrains.ReSharper.Psi.Asp.Tree.AspElementTypes.ASP_COMMENT_NODE_TYPE ASP_COMMENT;
        public readonly JetBrains.ReSharper.Psi.Asp.Tree.AspElementTypes.ASP_DATA_BINDER_EXPRESSION_NODE_TYPE ASP_DATA_BINDER_EXPRESSION;
        public readonly JetBrains.ReSharper.Psi.Asp.Tree.AspElementTypes.ASP_DIRECTIVE_NODE_TYPE ASP_DIRECTIVE;
        public readonly JetBrains.ReSharper.Psi.Asp.Tree.AspElementTypes.ASP_DIRECTIVE_ATTRIBUTE_NODE_TYPE ASP_DIRECTIVE_ATTRIBUTE;
        public readonly JetBrains.ReSharper.Psi.Asp.Tree.AspElementTypes.ASP_DIRECTIVE_CODE_FILE_BASE_CLASS_ATTRIBUTE_NODE_TYPE ASP_DIRECTIVE_CODE_FILE_BASE_CLASS_ATTRIBUTE;
        public readonly JetBrains.ReSharper.Psi.Asp.Tree.AspElementTypes.ASP_DIRECTIVE_INHERITS_ATTRIBUTE_NODE_TYPE ASP_DIRECTIVE_INHERITS_ATTRIBUTE;
        public readonly JetBrains.ReSharper.Psi.Asp.Tree.AspElementTypes.ASP_DIRECTIVE_NAMESPACE_ATTRIBUTE_NODE_TYPE ASP_DIRECTIVE_NAMESPACE_ATTRIBUTE;
        public readonly JetBrains.ReSharper.Psi.Asp.Tree.AspElementTypes.ASP_DIRECTIVE_TAG_NAME_ATTRIBUTE_NODE_TYPE ASP_DIRECTIVE_TAG_NAME_ATTRIBUTE;
        public readonly JetBrains.ReSharper.Psi.Asp.Tree.AspElementTypes.ASP_DIRECTIVE_TAG_PREFIX_ATTRIBUTE_NODE_TYPE ASP_DIRECTIVE_TAG_PREFIX_ATTRIBUTE;
        public readonly JetBrains.ReSharper.Psi.Asp.Tree.AspElementTypes.ASP_EXPRESSION_NODE_TYPE ASP_EXPRESSION;
        public readonly JetBrains.ReSharper.Psi.Asp.Tree.AspElementTypes.ASP_FILE_NODE_TYPE ASP_FILE;
        public readonly JetBrains.ReSharper.Psi.Asp.Tree.AspElementTypes.ASP_HTML_ENCODED_DATA_BINDER_EXPRESSION_NODE_TYPE ASP_HTML_ENCODED_DATA_BINDER_EXPRESSION;
        public readonly JetBrains.ReSharper.Psi.Asp.Tree.AspElementTypes.ASP_HTML_ENCODING_NODE_TYPE ASP_HTML_ENCODING;
        public readonly JetBrains.ReSharper.Psi.Asp.Tree.AspElementTypes.ASP_MASTER_TYPE_DIRECTIVE_NODE_TYPE ASP_MASTER_TYPE_DIRECTIVE;
        public readonly JetBrains.ReSharper.Psi.Asp.Tree.AspElementTypes.ASP_PREPROCESSOR_CODE_BLOCK_NODE_TYPE ASP_PREPROCESSOR_CODE_BLOCK;
        public readonly JetBrains.ReSharper.Psi.Asp.Tree.AspElementTypes.ASP_PREVIOUS_PAGE_TYPE_DIRECTIVE_NODE_TYPE ASP_PREVIOUS_PAGE_TYPE_DIRECTIVE;
        public readonly JetBrains.ReSharper.Psi.Asp.Tree.AspElementTypes.ASP_REFERENCE_DIRECTIVE_NODE_TYPE ASP_REFERENCE_DIRECTIVE;
        public readonly JetBrains.ReSharper.Psi.Asp.Tree.AspElementTypes.ASP_REGISTER_DIRECTIVE_NODE_TYPE ASP_REGISTER_DIRECTIVE;
        public readonly JetBrains.ReSharper.Psi.Asp.Tree.AspElementTypes.ASP_SCRIPT_TAG_NODE_TYPE ASP_SCRIPT_TAG;
        public readonly JetBrains.ReSharper.Psi.Asp.Tree.AspElementTypes.ASP_SUBSTITUTION_NODE_TYPE ASP_SUBSTITUTION;
        public readonly JetBrains.ReSharper.Psi.Asp.Tree.AspElementTypes.ASP_TYPE_DECL_DIRECTIVE_NODE_TYPE ASP_TYPE_DECL_DIRECTIVE;
        public readonly JetBrains.ReSharper.Psi.Asp.Tree.AspElementTypes.HTML_ID_TAG_ATTRIBUTE_NODE_TYPE HTML_ID_TAG_ATTRIBUTE;
        public AspElementTypes(JetBrains.ReSharper.Psi.Asp.Impl.UniqueIdGenerator uniqueIdGenerator, JetBrains.ReSharper.Psi.Asp.Parsing.IAspTokenNodeTypes tokenTypes) { }
        public class ASP_ATTRIBUTE_VALUE_NODE_TYPE : JetBrains.ReSharper.Psi.Html.Tree.HtmlElementTypes.HTML_TAG_ATTRIBUTE_VALUE_NODE_TYPE
        {
            public ASP_ATTRIBUTE_VALUE_NODE_TYPE(JetBrains.ReSharper.Psi.Asp.Parsing.IAspTokenNodeTypes tokenTypes, int index) { }
            public override JetBrains.ReSharper.Psi.Html.Impl.Tree.HtmlAttributeValue Create() { }
        }
        public class ASP_CODE_BLOCK_NODE_TYPE : JetBrains.ReSharper.Psi.Asp.Tree.AspElementTypes.AspCompositeNodeType<JetBrains.ReSharper.Psi.Asp.Impl.Tree.AspCodeBlock>
        {
            public ASP_CODE_BLOCK_NODE_TYPE(JetBrains.ReSharper.Psi.Asp.Parsing.IAspTokenNodeTypes tokenTypes, int index) { }
            public override JetBrains.ReSharper.Psi.Asp.Impl.Tree.AspCodeBlock Create() { }
        }
        public class ASP_COMMENT_NODE_TYPE : JetBrains.ReSharper.Psi.Asp.Tree.AspElementTypes.AspCompositeNodeType<JetBrains.ReSharper.Psi.Asp.Impl.Tree.AspComment>
        {
            public ASP_COMMENT_NODE_TYPE(JetBrains.ReSharper.Psi.Asp.Parsing.IAspTokenNodeTypes tokenTypes, int index) { }
            public override JetBrains.ReSharper.Psi.Asp.Impl.Tree.AspComment Create() { }
        }
        public class ASP_DATA_BINDER_EXPRESSION_NODE_TYPE : JetBrains.ReSharper.Psi.Asp.Tree.AspElementTypes.AspCompositeNodeType<JetBrains.ReSharper.Psi.Asp.Impl.Tree.AspDataBinderExpression>
        {
            public ASP_DATA_BINDER_EXPRESSION_NODE_TYPE(JetBrains.ReSharper.Psi.Asp.Parsing.IAspTokenNodeTypes tokenTypes, JetBrains.ReSharper.Psi.Asp.Impl.UniqueIdGenerator uniqueIdGenerator, int index) { }
            public override JetBrains.ReSharper.Psi.Asp.Impl.Tree.AspDataBinderExpression Create() { }
        }
        public class ASP_DIRECTIVE_ATTRIBUTE_NODE_TYPE : JetBrains.ReSharper.Psi.Asp.Tree.AspElementTypes.AspCompositeNodeType<JetBrains.ReSharper.Psi.Asp.Impl.Tree.AspDirectiveAttribute>
        {
            public ASP_DIRECTIVE_ATTRIBUTE_NODE_TYPE(JetBrains.ReSharper.Psi.Asp.Parsing.IAspTokenNodeTypes tokenTypes, int index) { }
            public override JetBrains.ReSharper.Psi.Asp.Impl.Tree.AspDirectiveAttribute Create() { }
        }
        public class ASP_DIRECTIVE_CODE_FILE_BASE_CLASS_ATTRIBUTE_NODE_TYPE : JetBrains.ReSharper.Psi.Asp.Tree.AspElementTypes.AspCompositeNodeType<JetBrains.ReSharper.Psi.Asp.Impl.Tree.AspDirectiveCodeFileBaseClassAttribute>
        {
            public ASP_DIRECTIVE_CODE_FILE_BASE_CLASS_ATTRIBUTE_NODE_TYPE(JetBrains.ReSharper.Psi.Asp.Parsing.IAspTokenNodeTypes tokenTypes, int index) { }
            public override JetBrains.ReSharper.Psi.Asp.Impl.Tree.AspDirectiveCodeFileBaseClassAttribute Create() { }
        }
        public class ASP_DIRECTIVE_INHERITS_ATTRIBUTE_NODE_TYPE : JetBrains.ReSharper.Psi.Asp.Tree.AspElementTypes.AspCompositeNodeType<JetBrains.ReSharper.Psi.Asp.Impl.Tree.AspDirectiveInheritsAttribute>
        {
            public ASP_DIRECTIVE_INHERITS_ATTRIBUTE_NODE_TYPE(JetBrains.ReSharper.Psi.Asp.Parsing.IAspTokenNodeTypes tokenTypes, int index) { }
            public override JetBrains.ReSharper.Psi.Asp.Impl.Tree.AspDirectiveInheritsAttribute Create() { }
        }
        public class ASP_DIRECTIVE_NAMESPACE_ATTRIBUTE_NODE_TYPE : JetBrains.ReSharper.Psi.Asp.Tree.AspElementTypes.AspCompositeNodeType<JetBrains.ReSharper.Psi.Asp.Impl.Tree.AspDirectiveNamespaceAttribute>
        {
            public ASP_DIRECTIVE_NAMESPACE_ATTRIBUTE_NODE_TYPE(JetBrains.ReSharper.Psi.Asp.Parsing.IAspTokenNodeTypes tokenTypes, int index) { }
            public override JetBrains.ReSharper.Psi.Asp.Impl.Tree.AspDirectiveNamespaceAttribute Create() { }
        }
        public class ASP_DIRECTIVE_NODE_TYPE : JetBrains.ReSharper.Psi.Asp.Tree.AspElementTypes.AspCompositeNodeType<JetBrains.ReSharper.Psi.Asp.Impl.Tree.AspDirective>
        {
            public ASP_DIRECTIVE_NODE_TYPE(JetBrains.ReSharper.Psi.Asp.Parsing.IAspTokenNodeTypes tokenTypes, int index) { }
            public override JetBrains.ReSharper.Psi.Asp.Impl.Tree.AspDirective Create() { }
        }
        public class ASP_DIRECTIVE_TAG_NAME_ATTRIBUTE_NODE_TYPE : JetBrains.ReSharper.Psi.Asp.Tree.AspElementTypes.AspCompositeNodeType<JetBrains.ReSharper.Psi.Asp.Impl.Tree.AspDirectiveTagNameAttribute>
        {
            public ASP_DIRECTIVE_TAG_NAME_ATTRIBUTE_NODE_TYPE(JetBrains.ReSharper.Psi.Asp.Parsing.IAspTokenNodeTypes tokenTypes, int index) { }
            public override JetBrains.ReSharper.Psi.Asp.Impl.Tree.AspDirectiveTagNameAttribute Create() { }
        }
        public class ASP_DIRECTIVE_TAG_PREFIX_ATTRIBUTE_NODE_TYPE : JetBrains.ReSharper.Psi.Asp.Tree.AspElementTypes.AspCompositeNodeType<JetBrains.ReSharper.Psi.Asp.Impl.Tree.AspDirectiveTagPrefixAttribute>
        {
            public ASP_DIRECTIVE_TAG_PREFIX_ATTRIBUTE_NODE_TYPE(JetBrains.ReSharper.Psi.Asp.Parsing.IAspTokenNodeTypes tokenTypes, int index) { }
            public override JetBrains.ReSharper.Psi.Asp.Impl.Tree.AspDirectiveTagPrefixAttribute Create() { }
        }
        public class ASP_EXPRESSION_NODE_TYPE : JetBrains.ReSharper.Psi.Asp.Tree.AspElementTypes.AspCompositeNodeType<JetBrains.ReSharper.Psi.Asp.Impl.Tree.AspExpression>
        {
            public ASP_EXPRESSION_NODE_TYPE(JetBrains.ReSharper.Psi.Asp.Parsing.IAspTokenNodeTypes tokenTypes, int index) { }
            public override JetBrains.ReSharper.Psi.Asp.Impl.Tree.AspExpression Create() { }
        }
        public class ASP_FILE_NODE_TYPE : JetBrains.ReSharper.Psi.Asp.Tree.AspElementTypes.AspCompositeNodeType<JetBrains.ReSharper.Psi.Asp.Impl.Tree.AspFile>
        {
            public ASP_FILE_NODE_TYPE(JetBrains.ReSharper.Psi.Asp.Parsing.IAspTokenNodeTypes tokenTypes, int index) { }
            public override JetBrains.ReSharper.Psi.Asp.Impl.Tree.AspFile Create() { }
        }
        public class ASP_HTML_ENCODED_DATA_BINDER_EXPRESSION_NODE_TYPE : JetBrains.ReSharper.Psi.Asp.Tree.AspElementTypes.AspCompositeNodeType<JetBrains.ReSharper.Psi.Asp.Impl.Tree.AspHtmlEncodedDataBinderExpression>
        {
            public ASP_HTML_ENCODED_DATA_BINDER_EXPRESSION_NODE_TYPE(JetBrains.ReSharper.Psi.Asp.Parsing.IAspTokenNodeTypes tokenTypes, JetBrains.ReSharper.Psi.Asp.Impl.UniqueIdGenerator uniqueIdGenerator, int index) { }
            public override JetBrains.ReSharper.Psi.Asp.Impl.Tree.AspHtmlEncodedDataBinderExpression Create() { }
        }
        public class ASP_HTML_ENCODING_NODE_TYPE : JetBrains.ReSharper.Psi.Asp.Tree.AspElementTypes.AspCompositeNodeType<JetBrains.ReSharper.Psi.Asp.Impl.Tree.AspHtmlEncoding>
        {
            public ASP_HTML_ENCODING_NODE_TYPE(JetBrains.ReSharper.Psi.Asp.Parsing.IAspTokenNodeTypes tokenTypes, int index) { }
            public override JetBrains.ReSharper.Psi.Asp.Impl.Tree.AspHtmlEncoding Create() { }
        }
        public class ASP_MASTER_TYPE_DIRECTIVE_NODE_TYPE : JetBrains.ReSharper.Psi.Asp.Tree.AspElementTypes.AspCompositeNodeType<JetBrains.ReSharper.Psi.Asp.Impl.Tree.AspMasterTypeDirective>
        {
            public ASP_MASTER_TYPE_DIRECTIVE_NODE_TYPE(JetBrains.ReSharper.Psi.Asp.Parsing.IAspTokenNodeTypes tokenTypes, int index) { }
            public override JetBrains.ReSharper.Psi.Asp.Impl.Tree.AspMasterTypeDirective Create() { }
        }
        public class ASP_PREPROCESSOR_CODE_BLOCK_NODE_TYPE : JetBrains.ReSharper.Psi.Asp.Tree.AspElementTypes.AspCompositeNodeType<JetBrains.ReSharper.Psi.Asp.Impl.Tree.AspPreProcessorCodeBlock>
        {
            public ASP_PREPROCESSOR_CODE_BLOCK_NODE_TYPE(JetBrains.ReSharper.Psi.Asp.Parsing.IAspTokenNodeTypes tokenTypes, int index) { }
            public override JetBrains.ReSharper.Psi.Asp.Impl.Tree.AspPreProcessorCodeBlock Create() { }
        }
        public class ASP_PREVIOUS_PAGE_TYPE_DIRECTIVE_NODE_TYPE : JetBrains.ReSharper.Psi.Asp.Tree.AspElementTypes.AspCompositeNodeType<JetBrains.ReSharper.Psi.Asp.Impl.Tree.AspPreviousPageTypeDirective>
        {
            public ASP_PREVIOUS_PAGE_TYPE_DIRECTIVE_NODE_TYPE(JetBrains.ReSharper.Psi.Asp.Parsing.IAspTokenNodeTypes tokenTypes, int index) { }
            public override JetBrains.ReSharper.Psi.Asp.Impl.Tree.AspPreviousPageTypeDirective Create() { }
        }
        public class ASP_REFERENCE_DIRECTIVE_NODE_TYPE : JetBrains.ReSharper.Psi.Asp.Tree.AspElementTypes.AspCompositeNodeType<JetBrains.ReSharper.Psi.Asp.Impl.Tree.AspReferenceDirective>
        {
            public ASP_REFERENCE_DIRECTIVE_NODE_TYPE(JetBrains.ReSharper.Psi.Asp.Parsing.IAspTokenNodeTypes tokenTypes, int index) { }
            public override JetBrains.ReSharper.Psi.Asp.Impl.Tree.AspReferenceDirective Create() { }
        }
        public class ASP_REGISTER_DIRECTIVE_NODE_TYPE : JetBrains.ReSharper.Psi.Asp.Tree.AspElementTypes.AspCompositeNodeType<JetBrains.ReSharper.Psi.Asp.Impl.Tree.AspRegisterDirective>
        {
            public ASP_REGISTER_DIRECTIVE_NODE_TYPE(JetBrains.ReSharper.Psi.Asp.Parsing.IAspTokenNodeTypes tokenTypes, int index) { }
            public override JetBrains.ReSharper.Psi.Asp.Impl.Tree.AspRegisterDirective Create() { }
        }
        public class ASP_SCRIPT_TAG_NODE_TYPE : JetBrains.ReSharper.Psi.Asp.Tree.AspElementTypes.AspCompositeNodeType<JetBrains.ReSharper.Psi.Asp.Impl.Tree.AspScriptTag>
        {
            public ASP_SCRIPT_TAG_NODE_TYPE(JetBrains.ReSharper.Psi.Asp.Parsing.IAspTokenNodeTypes tokenTypes, int index) { }
            public override JetBrains.ReSharper.Psi.Asp.Impl.Tree.AspScriptTag Create() { }
        }
        public class ASP_SUBSTITUTION_NODE_TYPE : JetBrains.ReSharper.Psi.Asp.Tree.AspElementTypes.AspCompositeNodeType<JetBrains.ReSharper.Psi.Asp.Impl.Tree.AspSubstitution>
        {
            public ASP_SUBSTITUTION_NODE_TYPE(JetBrains.ReSharper.Psi.Asp.Parsing.IAspTokenNodeTypes tokenTypes, int index) { }
            public override JetBrains.ReSharper.Psi.Asp.Impl.Tree.AspSubstitution Create() { }
        }
        public class ASP_TAG_ATTRIBUTE_NODE_TYPE : JetBrains.ReSharper.Psi.Html.Tree.HtmlElementTypes.HTML_TAG_ATTRIBUTE_NODE_TYPE
        {
            public ASP_TAG_ATTRIBUTE_NODE_TYPE(JetBrains.ReSharper.Psi.Asp.Parsing.IAspTokenNodeTypes tokenTypes, int index) { }
            public override JetBrains.ReSharper.Psi.Html.Impl.Tree.TagAttribute Create() { }
        }
        public class ASP_TAG_FOOTER_NODE_TYPE : JetBrains.ReSharper.Psi.Html.Tree.HtmlElementTypes.HTML_TAG_FOOTER_NODE_TYPE
        {
            public ASP_TAG_FOOTER_NODE_TYPE(JetBrains.ReSharper.Psi.Asp.Parsing.IAspTokenNodeTypes tokenTypes, int index) { }
            public override JetBrains.ReSharper.Psi.Html.Impl.Tree.HtmlTagFooter Create() { }
        }
        public class ASP_TAG_HEADER_NODE_TYPE : JetBrains.ReSharper.Psi.Html.Tree.HtmlElementTypes.HTML_TAG_HEADER_NODE_TYPE
        {
            public ASP_TAG_HEADER_NODE_TYPE(JetBrains.ReSharper.Psi.Asp.Parsing.IAspTokenNodeTypes tokenTypes, int index) { }
            public override JetBrains.ReSharper.Psi.Html.Impl.Tree.HtmlTagHeader Create() { }
        }
        public class ASP_TAG_NODE_TYPE : JetBrains.ReSharper.Psi.Html.Tree.HtmlElementTypes.HTML_TAG_NODE_TYPE
        {
            public ASP_TAG_NODE_TYPE(JetBrains.ReSharper.Psi.Asp.Parsing.IAspTokenNodeTypes tokenTypes, int index) { }
            public override JetBrains.ReSharper.Psi.Html.Impl.Tree.HtmlTag Create() { }
        }
        public class ASP_TYPE_DECL_DIRECTIVE_NODE_TYPE : JetBrains.ReSharper.Psi.Asp.Tree.AspElementTypes.AspCompositeNodeType<JetBrains.ReSharper.Psi.Asp.Impl.Tree.AspMainDirective>
        {
            public ASP_TYPE_DECL_DIRECTIVE_NODE_TYPE(JetBrains.ReSharper.Psi.Asp.Parsing.IAspTokenNodeTypes tokenTypes, int index) { }
            public override JetBrains.ReSharper.Psi.Asp.Impl.Tree.AspMainDirective Create() { }
        }
        public abstract class AspCompositeNodeType<T> : JetBrains.ReSharper.Psi.Html.Tree.HtmlElementTypes.HtmlCompositeNodeType<T, JetBrains.ReSharper.Psi.Asp.Parsing.IAspTokenNodeTypes>
            where T : JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeElement
        {
            protected AspCompositeNodeType(string s, JetBrains.ReSharper.Psi.Asp.Parsing.IAspTokenNodeTypes tokenTypes, int index) { }
        }
        public class HTML_ID_TAG_ATTRIBUTE_NODE_TYPE : JetBrains.ReSharper.Psi.Asp.Tree.AspElementTypes.AspCompositeNodeType<JetBrains.ReSharper.Psi.Asp.Impl.Tree.IdTagAttribute>
        {
            public HTML_ID_TAG_ATTRIBUTE_NODE_TYPE(JetBrains.ReSharper.Psi.Asp.Parsing.IAspTokenNodeTypes tokenTypes, int index) { }
            public override JetBrains.ReSharper.Psi.Asp.Impl.Tree.IdTagAttribute Create() { }
        }
    }
    public class static AspTagExtensions
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public static string GetId([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Html.Tree.IHtmlTag tag) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Psi.Asp.Tree.IIdTagAttribute GetIdAttribute([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Html.Tree.IHtmlTag tag) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.ReSharper.Psi.Html.Tree.IHtmlTagContainer GetSearchByIdScope([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Asp.Tree.IAspTag tag) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.ReSharper.Psi.Html.Tree.IHtmlTagContainer GetSearchScope([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Asp.Tree.IAspTag tag, bool checkCanBeField, params JetBrains.ReSharper.Psi.IDeclaredType[] scopeTypes) { }
        public static System.Nullable<bool> RequiresRunAtAttribute(this JetBrains.ReSharper.Psi.Asp.Tree.IAspTag tag, JetBrains.ReSharper.Psi.Asp.Html.IAspDeclaredElementTypes aspDeclaredElementTypes) { }
    }
    public abstract class AspTreeVisitor<TContext, TReturn> : JetBrains.ReSharper.Psi.Html.Tree.IInheritedLanguageHtmlTreeVisitor<TContext, TReturn>
    
    
    {
        protected AspTreeVisitor(JetBrains.ReSharper.Psi.Html.Tree.HtmlTreeVisitor<TContext, TReturn> baseVisitor) { }
        public JetBrains.ReSharper.Psi.Html.Tree.HtmlTreeVisitor<TContext, TReturn> BaseVisitor { get; }
        public virtual TReturn VisitAspComment(JetBrains.ReSharper.Psi.Asp.Tree.IAspComment node, TContext context) { }
        public virtual TReturn VisitAspRenderBlock(JetBrains.ReSharper.Psi.Asp.Tree.IAspRenderBlock node, TContext context) { }
        public virtual TReturn VisitAspSubstitution(JetBrains.ReSharper.Psi.Asp.Tree.IAspSubstitution node, TContext context) { }
    }
    public class static AspTreeVisitorExtensions
    {
        public static JetBrains.ReSharper.Psi.Asp.Tree.AspTreeVisitor<TContext, TReturn> ToAsp<TContext, TReturn>(this JetBrains.ReSharper.Psi.Html.Tree.HtmlTreeVisitor<TContext, TReturn> visitor) { }
    }
    public enum CreateFieldsType
    {
        REFERENCE_ONLY = 0,
        REFERENCE_OR_CREATE_IN_ASP = 1,
        CREATE_ONLY = 2,
    }
    public class static HtmlObjectTagExtensions
    {
        public static JetBrains.ReSharper.Psi.AccessRights GetObjectTagAccessRights([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Html.Tree.IHtmlTag tag) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.ReSharper.Psi.IType GetObjectTagType([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Html.Tree.IHtmlTag tag) { }
        public static bool IsObjectTag([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Html.Tree.IHtmlTag tag) { }
    }
    public class static HtmlTagContainerExtensions
    {
        public static System.Collections.Generic.IEnumerable<T> GetChildTags<T>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Html.Tree.IHtmlTagContainer container, System.Predicate<T> predicate = null)
            where T : JetBrains.ReSharper.Psi.Html.Tree.IHtmlTag { }
        public static System.Collections.Generic.IEnumerable<T> GetNestedTags<T>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Html.Tree.IHtmlTagContainer container, System.Predicate<T> predicate)
            where T : JetBrains.ReSharper.Psi.Html.Tree.IHtmlTag { }
    }
    public interface IAspAttributeValue : JetBrains.ReSharper.Psi.Asp.Tree.IAspTreeNode, JetBrains.ReSharper.Psi.Html.Tree.IHtmlAttributeValue, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode { }
    public interface IAspCodeBlock : JetBrains.ReSharper.Psi.Asp.Tree.IAspElementWithCodeBlock, JetBrains.ReSharper.Psi.Asp.Tree.IAspRenderBlock, JetBrains.ReSharper.Psi.Asp.Tree.IAspTreeNode, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebCodeBlock, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode { }
    public interface IAspComment : JetBrains.ReSharper.Psi.Asp.Tree.IAspTreeNode, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode, JetBrains.ReSharper.Psi.Html.Tree.IWebComment, JetBrains.ReSharper.Psi.Tree.IComment, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode
    {
        JetBrains.ReSharper.Psi.Tree.ITreeNode CommentEnd { get; }
        JetBrains.ReSharper.Psi.Tree.ITreeNode CommentStart { get; }
    }
    public interface IAspDataBinderExpression : JetBrains.ReSharper.Psi.Asp.Tree.IAspElementWithCodeBlock, JetBrains.ReSharper.Psi.Asp.Tree.IAspExpression, JetBrains.ReSharper.Psi.Asp.Tree.IAspRenderBlock, JetBrains.ReSharper.Psi.Asp.Tree.IAspTreeNode, JetBrains.ReSharper.Psi.ExtensionsAPI.Caches2.ICachedTypeMemberDeclaration, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode, JetBrains.ReSharper.Psi.Tree.IDeclaration, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Tree.IXmlDocOwnerTreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebCodeBlock, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Asp.Tree.IAspTag GetEnclosingTag([JetBrains.Annotations.NotNullAttribute()] out JetBrains.ReSharper.Psi.IType containerType, [JetBrains.Annotations.CanBeNullAttribute()] out JetBrains.ReSharper.Psi.Asp.Html.IAspDeclaredElementTypes declaredElementTypes);
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Asp.Html.IAspBindingExpressionField> GetImplicitFields();
    }
    public interface IAspDirective : JetBrains.ReSharper.Psi.Asp.Tree.IAspTreeNode, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebAttributeContainer<JetBrains.ReSharper.Psi.Asp.Tree.IAspDirectiveAttribute>, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode
    {
        string DirectiveName { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Html.Tree.IHtmlToken EndToken { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Html.Tree.IHtmlToken NameToken { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Html.Tree.IHtmlToken StartToken { get; }
    }
    public interface IAspDirectiveAttribute : JetBrains.ReSharper.Psi.Asp.Tree.IAspTreeNode, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebAttribute, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Html.Tree.IHtmlToken EqToken { get; }
        string Name { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Html.Tree.IHtmlToken NameToken { get; }
        string Prefix { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Html.Tree.IHtmlToken ValueToken { get; }
    }
    public interface IAspDirectiveCodeFileBaseClassAttribute : JetBrains.ReSharper.Psi.Asp.Tree.IAspDirectiveAttribute, JetBrains.ReSharper.Psi.Asp.Tree.IAspTreeNode, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebAttribute, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Web.WebConfig.Util.ParsedTypeInfo GetTypeInfo();
    }
    public interface IAspDirectiveInheritsAttribute : JetBrains.ReSharper.Psi.Asp.Tree.IAspDirectiveAttribute, JetBrains.ReSharper.Psi.Asp.Tree.IAspTreeNode, JetBrains.ReSharper.Psi.Asp.Tree.IAspTypeDeclaration, JetBrains.ReSharper.Psi.ExtensionsAPI.Caches2.ICachedDeclaration2, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode, JetBrains.ReSharper.Psi.Tree.IDeclaration, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Tree.ITypeDeclaration, JetBrains.ReSharper.Psi.Tree.ITypeDeclarationHolder, JetBrains.ReSharper.Psi.Tree.IXmlDocOwnerTreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebAttribute, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Web.WebConfig.Util.ParsedTypeInfo GetTypeInfo();
        void SetNamespaceName(string qualifiedName);
    }
    public interface IAspElementWithCodeBlock : JetBrains.ReSharper.Psi.Asp.Tree.IAspTreeNode, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebCodeBlock, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode
    {
        [JetBrains.Annotations.NotNullAttribute()]
        string CodeText { get; set; }
        JetBrains.ReSharper.Psi.ITreeRange CodeTokens { get; }
    }
    public interface IAspExpression : JetBrains.ReSharper.Psi.Asp.Tree.IAspElementWithCodeBlock, JetBrains.ReSharper.Psi.Asp.Tree.IAspRenderBlock, JetBrains.ReSharper.Psi.Asp.Tree.IAspTreeNode, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebCodeBlock, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode { }
    public interface IAspFile : JetBrains.ReSharper.Psi.Asp.Tree.IAspTreeNode, JetBrains.ReSharper.Psi.Asp.Tree.IAspTypeDeclaration, JetBrains.ReSharper.Psi.ExtensionsAPI.Caches2.ICachedDeclaration2, JetBrains.ReSharper.Psi.Html.Tree.IHtmlFile, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTagContainer, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTagContainerMarker, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode, JetBrains.ReSharper.Psi.Tree.IDeclaration, JetBrains.ReSharper.Psi.Tree.IFile, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Tree.ITypeDeclaration, JetBrains.ReSharper.Psi.Tree.ITypeDeclarationHolder, JetBrains.ReSharper.Psi.Tree.IXmlDocOwnerTreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebFile, JetBrains.ReSharper.Psi.Web.Tree.IWebFileWithCodeBehind, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Asp.Tree.IAspDirectiveAttribute ClassNameAttribute { get; }
        bool HasCodeBehindPart { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Asp.Tree.IAspDirectiveInheritsAttribute InheritsAttribute { get; }
        bool IsControl { get; }
        bool IsMasterPage { get; }
        bool UsesMasterPage { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Asp.Tree.IAspDirective AddDirective([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Asp.Tree.IAspDirective directive);
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Asp.Tree.IAspDirective AddDirectiveAfter([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Asp.Tree.IAspDirective directive, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Asp.Tree.IAspDirective anchor);
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Asp.Tree.IAspDirective AddDirectiveBefore([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Asp.Tree.IAspDirective directive, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Asp.Tree.IAspDirective anchor);
        JetBrains.ReSharper.Psi.Asp.Tree.CreateFieldsType DoCreateFields();
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.Html.Tree.IHtmlTag> GetAllTagsWithId();
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.Asp.Tree.IAspDataBinderExpression> GetDataBinderExpressions();
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IType GetDefaultBaseType();
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IType GetDefaultBaseTypefForDataBinding();
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.Asp.Tree.IAspDirective> GetDirectives();
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Asp.Html.IHtmlControl> GetHtmlControls();
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.Asp.Tree.IAspScriptTag> GetScriptTags();
        string GetShortName(out System.Collections.Generic.IList<> namespaceNames, out System.Collections.Generic.IList<> namespaceRanges, out JetBrains.ReSharper.Psi.TreeTextRange nameRange);
        void RemoveDirective([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Asp.Tree.IAspDirective directive);
        void SetNamespaceName(int nOldNamespacesToDelete, string newNamespaceName);
    }
    public interface IAspIdentifierTokenNode : JetBrains.ReSharper.Psi.Html.Tree.IHtmlToken, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode, JetBrains.ReSharper.Psi.Tree.IIdentifier, JetBrains.ReSharper.Psi.Tree.ITokenNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode { }
    public interface IAspMainDirective : JetBrains.ReSharper.Psi.Asp.Tree.IAspDirective, JetBrains.ReSharper.Psi.Asp.Tree.IAspTreeNode, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebAttributeContainer<JetBrains.ReSharper.Psi.Asp.Tree.IAspDirectiveAttribute>, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Asp.Tree.IAspDirectiveAttribute AutoEventWireUpAttribute { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Asp.Tree.IAspDirectiveAttribute ClassNameAttribute { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Asp.Tree.IAspDirectiveAttribute CodeBehindAttribute { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Asp.Tree.IAspDirectiveAttribute CodeFileAttribute { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Asp.Tree.IAspDirectiveCodeFileBaseClassAttribute CodeFileBaseClassAttribute { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Asp.Tree.IAspDirectiveAttribute DynamicMasterPageFileAttribute { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Asp.Tree.IAspDirectiveAttribute ExplicitAttribute { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Asp.Tree.IAspDirectiveInheritsAttribute InheritsAttribute { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Asp.Tree.IAspDirectiveAttribute LanguageAttribute { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Asp.Tree.IAspDirectiveAttribute MasterPageFileAttribute { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Asp.Tree.IAspDirectiveAttribute SrcAttribute { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Asp.Tree.IAspDirectiveAttribute StrictAttribute { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Asp.Tree.IAspDirectiveAttribute StyleSheetThemeAttribute { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Asp.Tree.IAspDirectiveAttribute ThemeAttribute { get; }
    }
    public interface IAspMetaResourceKey : JetBrains.ReSharper.Psi.IDeclaredElement { }
    public interface IAspPreProcessorCodeBlock : JetBrains.ReSharper.Psi.Asp.Tree.IAspCodeBlock, JetBrains.ReSharper.Psi.Asp.Tree.IAspElementWithCodeBlock, JetBrains.ReSharper.Psi.Asp.Tree.IAspRenderBlock, JetBrains.ReSharper.Psi.Asp.Tree.IAspTreeNode, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebCodeBlock, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode { }
    public interface IAspPropertyDirective : JetBrains.ReSharper.Psi.Asp.Tree.IAspDirective, JetBrains.ReSharper.Psi.Asp.Tree.IAspTreeNode, JetBrains.ReSharper.Psi.ExtensionsAPI.Caches2.ICachedTypeMemberDeclaration, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode, JetBrains.ReSharper.Psi.Tree.IDeclaration, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Tree.IXmlDocOwnerTreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebAttributeContainer<JetBrains.ReSharper.Psi.Asp.Tree.IAspDirectiveAttribute>, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode { }
    public interface IAspReferenceDirective : JetBrains.ReSharper.Psi.Asp.Tree.IAspDirective, JetBrains.ReSharper.Psi.Asp.Tree.IAspTreeNode, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebAttributeContainer<JetBrains.ReSharper.Psi.Asp.Tree.IAspDirectiveAttribute>, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Asp.Tree.IAspDirectiveAttribute ControlAttribute { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Resolve.IReference ControlPathReference { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Asp.Tree.IAspDirectiveAttribute PageAttribute { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Resolve.IReference PagePathReference { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Asp.Tree.IAspDirectiveAttribute VirtualPathAttribute { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Resolve.IReference VirtualPathReference { get; }
    }
    public interface IAspRegisterDirective : JetBrains.ReSharper.Psi.Asp.Tree.IAspDirective, JetBrains.ReSharper.Psi.Asp.Tree.IAspTreeNode, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.TagPrefixes.ITagPrefixHolder, JetBrains.ReSharper.Psi.Web.Tree.IWebAttributeContainer<JetBrains.ReSharper.Psi.Asp.Tree.IAspDirectiveAttribute>, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode { }
    public interface IAspRenderBlock : JetBrains.ReSharper.Psi.Asp.Tree.IAspElementWithCodeBlock, JetBrains.ReSharper.Psi.Asp.Tree.IAspTreeNode, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebCodeBlock, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Html.Tree.IHtmlToken EndToken { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Html.Tree.IHtmlToken StartToken { get; }
    }
    public interface IAspScriptTag : JetBrains.ReSharper.Psi.Asp.Tree.IAspElementWithCodeBlock, JetBrains.ReSharper.Psi.Asp.Tree.IAspTag, JetBrains.ReSharper.Psi.Asp.Tree.IAspTreeNode, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTag, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTagContainer, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTagContainerMarker, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode, JetBrains.ReSharper.Psi.Html.Tree.IScriptTag, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebAttributeContainer<JetBrains.ReSharper.Psi.Html.Tree.ITagAttribute>, JetBrains.ReSharper.Psi.Web.Tree.IWebCodeBlock, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode { }
    public interface IAspSubstitution : JetBrains.ReSharper.Psi.Asp.Tree.IAspTreeNode, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Html.Tree.IHtmlToken BodyToken { get; }
    }
    public interface IAspTag : JetBrains.ReSharper.Psi.Asp.Tree.IAspTreeNode, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTag, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTagContainer, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTagContainerMarker, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebAttributeContainer<JetBrains.ReSharper.Psi.Html.Tree.ITagAttribute>, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode
    {
        bool HasRenderMethod { get; }
        bool IsRunatServer { get; }
        bool CanDeclareField();
        System.Nullable<bool> DoParseChildrenAsProperties();
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.IType GetTagType();
    }
    public interface IAspTagAttribute : JetBrains.ReSharper.Psi.Asp.Tree.IAspTreeNode, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode, JetBrains.ReSharper.Psi.Html.Tree.ITagAttribute, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebAttribute, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode { }
    public interface IAspTagFooter : JetBrains.ReSharper.Psi.Asp.Tree.IAspTagNameContainer, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTagFooter, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode, JetBrains.ReSharper.Psi.Html.Tree.ITagNameContainer, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode { }
    public interface IAspTagHeader : JetBrains.ReSharper.Psi.Asp.Tree.IAspTagNameContainer, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTagHeader, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode, JetBrains.ReSharper.Psi.Html.Tree.ITagNameContainer, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebAttributeContainer<JetBrains.ReSharper.Psi.Html.Tree.ITagAttribute>, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode { }
    public interface IAspTagNameAttribute : JetBrains.ReSharper.Psi.Asp.Tree.IAspDirectiveAttribute, JetBrains.ReSharper.Psi.Asp.Tree.IAspTreeNode, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode, JetBrains.ReSharper.Psi.Tree.IDeclaration, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Tree.IXmlDocOwnerTreeNode, JetBrains.ReSharper.Psi.Web.TagPrefixes.ITagNameDeclaration, JetBrains.ReSharper.Psi.Web.Tree.IWebAttribute, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode { }
    public interface IAspTagNameContainer : JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode, JetBrains.ReSharper.Psi.Html.Tree.ITagNameContainer, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Asp.Tree.IAspTag Tag { get; }
    }
    public interface IAspTagPrefixAttribute : JetBrains.ReSharper.Psi.Asp.Tree.IAspDirectiveAttribute, JetBrains.ReSharper.Psi.Asp.Tree.IAspTreeNode, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode, JetBrains.ReSharper.Psi.Tree.IDeclaration, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Tree.IXmlDocOwnerTreeNode, JetBrains.ReSharper.Psi.Web.TagPrefixes.ITagPrefixDeclaration, JetBrains.ReSharper.Psi.Web.Tree.IWebAttribute, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode { }
    public interface IAspToken : JetBrains.ReSharper.Psi.Asp.Tree.IAspTreeNode, JetBrains.ReSharper.Psi.Html.Tree.IHtmlToken, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode, JetBrains.ReSharper.Psi.Tree.ITokenNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode { }
    public interface IAspTreeNode : JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode
    {
        JetBrains.ReSharper.Psi.Asp.Parsing.IAspTokenNodeTypes TokenTypes { get; }
    }
    public interface IAspTypeDeclaration : JetBrains.ReSharper.Psi.Asp.Tree.IAspTreeNode, JetBrains.ReSharper.Psi.ExtensionsAPI.Caches2.ICachedDeclaration2, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode, JetBrains.ReSharper.Psi.Tree.IDeclaration, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Tree.ITypeDeclaration, JetBrains.ReSharper.Psi.Tree.ITypeDeclarationHolder, JetBrains.ReSharper.Psi.Tree.IXmlDocOwnerTreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode { }
    public interface IIdTagAttribute : JetBrains.ReSharper.Psi.Asp.Tree.IAspTreeNode, JetBrains.ReSharper.Psi.ExtensionsAPI.Caches2.ICachedTypeMemberDeclaration, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode, JetBrains.ReSharper.Psi.Html.Tree.ITagAttribute, JetBrains.ReSharper.Psi.Tree.IDeclaration, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Tree.ITypeMemberDeclaration, JetBrains.ReSharper.Psi.Tree.IXmlDocOwnerTreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebAttribute, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode
    {
        JetBrains.ReSharper.Psi.Asp.Html.IHtmlControl DeclaredElement { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.DeclaredElementType GetDeclaredElementType();
    }
    public interface ISkinFile : JetBrains.ReSharper.Psi.Asp.Tree.IAspFile, JetBrains.ReSharper.Psi.Asp.Tree.IAspTreeNode, JetBrains.ReSharper.Psi.Asp.Tree.IAspTypeDeclaration, JetBrains.ReSharper.Psi.ExtensionsAPI.Caches2.ICachedDeclaration2, JetBrains.ReSharper.Psi.Html.Tree.IHtmlFile, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTagContainer, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTagContainerMarker, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode, JetBrains.ReSharper.Psi.Tree.IDeclaration, JetBrains.ReSharper.Psi.Tree.IFile, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Tree.ITypeDeclaration, JetBrains.ReSharper.Psi.Tree.ITypeDeclarationHolder, JetBrains.ReSharper.Psi.Tree.IXmlDocOwnerTreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebFile, JetBrains.ReSharper.Psi.Web.Tree.IWebFileWithCodeBehind, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode
    {
        System.Collections.Generic.IDictionary<string, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTag> GetSkinTags();
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.Asp.SkinLanguage))]
    public class SkinElementTypes : JetBrains.ReSharper.Psi.Asp.Tree.AspElementTypes
    {
        public readonly JetBrains.ReSharper.Psi.Asp.Tree.SkinElementTypes.SKIN_FILE_NODE_TYPE SKIN_FILE;
        public SkinElementTypes(JetBrains.ReSharper.Psi.Asp.Impl.UniqueIdGenerator uniqueIdGenerator, JetBrains.ReSharper.Psi.Asp.Parsing.IAspTokenNodeTypes tokenTypes) { }
        public class SKIN_FILE_NODE_TYPE : JetBrains.ReSharper.Psi.Asp.Tree.AspElementTypes.AspCompositeNodeType<JetBrains.ReSharper.Psi.Asp.Impl.Tree.SkinFile>
        {
            public SKIN_FILE_NODE_TYPE(JetBrains.ReSharper.Psi.Asp.Parsing.IAspTokenNodeTypes tokenTypes, int index) { }
            public override JetBrains.ReSharper.Psi.Asp.Impl.Tree.SkinFile Create() { }
        }
    }
    public class static TagAttributeExtensions
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.ReSharper.Psi.IType GetTypeInValue([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Html.Tree.ITagAttribute tagAttribute) { }
        public static bool IsAspInnerProperty([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.ITypeMember property) { }
        public static bool IsMetaAttribute([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Web.Tree.IWebAttribute tagAttribute) { }
        public static JetBrains.ReSharper.Psi.Web.Directives.IWebDirectiveAttributeDeclaredElement ResolveAttribute([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Asp.Tree.IAspDirectiveAttribute attribute) { }
    }
}
namespace JetBrains.ReSharper.Psi.Asp.Utils
{
    
    [JetBrains.ReSharper.Psi.PsiComponentAttribute()]
    public class AspAttributesCache : JetBrains.ReSharper.Psi.Caches.InvalidatingPsiCache
    {
        public static readonly JetBrains.ReSharper.Psi.IClrTypeName AspDataFieldAttribute;
        public static readonly JetBrains.ReSharper.Psi.IClrTypeName AspDataFieldsAttribute;
        public AspAttributesCache(JetBrains.ReSharper.Psi.Asp.Html.IAspDeclaredElementTypes aspDeclaredElementTypes) { }
        public static bool DoPersistChildren([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.ITypeElement typeElement) { }
        public static JetBrains.Util.OneToSetMap<string, JetBrains.ReSharper.Psi.IType> GetChildControlTypes([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.ITypeElement typeElement) { }
        public static JetBrains.ReSharper.Psi.Asp.Utils.ControlInfo GetControlInfo([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.ITypeElement typeElement) { }
        public static JetBrains.ReSharper.Psi.Asp.Utils.PersistenceModeValue GetPersistenceMode([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.ITypeMember typeMember) { }
        public static JetBrains.ReSharper.Psi.IType GetTemplateContainerType([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.ITypeMember typeMember) { }
        public static JetBrains.ReSharper.Psi.Asp.Utils.TemplateInstanceValue GetTemplateInstance([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.ITypeMember typeMember) { }
        public static string GetValidationPropertyName([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.ITypeElement typeElement) { }
        public static bool HasInnerProperties([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.ITypeElement typeElement) { }
        public static bool HasTypeConverterAttribute([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.ITypeMember typeMember, [JetBrains.Annotations.CanBeNullAttribute()] out JetBrains.ReSharper.Psi.IType converterType) { }
        protected override void InvalidateOnPhysicalChange() { }
        public bool IsDataField([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.ITypeMember typeMember) { }
        public bool IsDataFields([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.ITypeMember typeMember) { }
        public static bool IsIdPropertyReference([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.ITypeMember typeMember, [JetBrains.Annotations.CanBeNullAttribute()] out JetBrains.ReSharper.Psi.IType referencedControlType) { }
        public static bool IsMergableProperty([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.ITypeMember typeMember) { }
        public bool IsMethodProperty([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.ITypeMember typeMember) { }
        public static bool IsTypeProperty([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.ITypeMember typeMember, out bool createConstructorReference) { }
        public bool IsTypePropertyInternal([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.ITypeMember typeMember, out bool createConstructorReference) { }
    }
    public class static AspCodeBehindLanguageUtil
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.ReSharper.Psi.PsiLanguageType GetCodeBehindLanguage([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Asp.Tree.IAspFile aspFile) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Psi.PsiLanguageType GetCodeBehindLanguageDefinedInFile([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Asp.Tree.IAspFile aspFile) { }
    }
    public class static AspDirectivesUtil
    {
        public static System.Collections.Generic.JetHashSet<JetBrains.ReSharper.Psi.Asp.Tree.IAspDirective> GetDirectivesUsedInInheritsAttribute([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Asp.Tree.IAspFile aspFile) { }
    }
    public abstract class AspEventsDetector
    {
        public const string APPLICATION_EVENT_PREFIX = "Application_";
        public const string PAGE_EVENT_PREFIX = "Page_";
        public abstract bool IsEmpty { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.ReSharper.Psi.Asp.Utils.AspEventsDetector GetInstance([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Modules.IPsiModule psiModule, JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext resolveContext) { }
        public abstract bool IsAutoBindingEvent(JetBrains.ReSharper.Psi.ITypeElement containingType, JetBrains.ReSharper.Psi.IMethod method, out JetBrains.ReSharper.Psi.IEvent @event);
        public abstract bool IsGlobalAsaxMethod(JetBrains.ReSharper.Psi.ITypeElement containingType, JetBrains.ReSharper.Psi.IMethod method);
        public abstract bool IsProperType(JetBrains.ReSharper.Psi.ITypeElement typeElement);
    }
    public class static AspFieldsUtil
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Psi.Asp.Tree.IIdTagAttribute FindIdTagAttribute([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Asp.Tree.IAspFile aspFile, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode searchScope) { }
    }
    public class static AspModificationUtil
    {
        public static bool FixAspDirective([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Asp.Tree.IAspDirective directive) { }
        public static bool FixAspDirectiveAttribute([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Asp.Tree.IAspDirectiveAttribute attribute) { }
    }
    public class static AspReferenceUtil
    {
        public static JetBrains.ReSharper.Psi.Resolve.ISymbolFilter[] CreatePropertySymbolFilters([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Resolve.IAccessContext referenceContext) { }
        public static JetBrains.ReSharper.Psi.Resolve.ISymbolFilter[] CreateWritablePropertySymbolFilters([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Resolve.IAccessContext referenceContext) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetDataFieldSymbolTable([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Asp.Tree.IAspTag innerTag, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Asp.Html.IAspDeclaredElementTypes aspDeclaredElementTypes, out JetBrains.ReSharper.Psi.Resolve.ResolveErrorType resolveErrorType) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Psi.Html.Tree.IHtmlTag GetDataSourceTag([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Asp.Tree.IAspFile aspFile, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.IDeclaredElement dataSourceDeclaredElement) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Psi.ITypeElement GetQualifierTypeElement([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Html.Impl.References.IQualifierReference qualifier) { }
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.ResolveResultWithInfo GetResolveResult(JetBrains.ReSharper.Psi.Resolve.ISymbolTable symbolTable, string referenceName) { }
        public static JetBrains.ReSharper.Psi.Resolve.ISymbolFilter[] GetTypeFilters() { }
    }
    public struct ControlInfo
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        public readonly JetBrains.ReSharper.Psi.IType ChildControlType;
        [JetBrains.Annotations.CanBeNullAttribute()]
        public readonly JetBrains.ReSharper.Psi.IType CustomControlBuilderType;
        public static readonly JetBrains.ReSharper.Psi.Asp.Utils.ControlInfo Default;
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly string DefaultPropertyName;
        public readonly bool HasParseChildrenAttribute;
        public readonly bool ParseChildrenAsProperties;
        public readonly bool PersistChildren;
        public ControlInfo(string defaultPropertyName, bool parseChildrenAsProperties, JetBrains.ReSharper.Psi.IType childControlType, bool persistChildren, JetBrains.ReSharper.Psi.IType customControlBuilderType, bool hasParseChildrenAttribute) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.KnownLanguage))]
    public class GenericComplexTypeParserFactory : JetBrains.ReSharper.Psi.Asp.Utils.IComplexTypeParserFactory
    {
        public virtual System.Func<string, JetBrains.ReSharper.Psi.TreeTextRange, JetBrains.ReSharper.Psi.Web.WebConfig.Util.ComplexTypeParser> CreateParserDelegate(bool isOpenRasta) { }
    }
    public interface IComplexTypeParserFactory
    {
        [JetBrains.Annotations.NotNullAttribute()]
        System.Func<string, JetBrains.ReSharper.Psi.TreeTextRange, JetBrains.ReSharper.Psi.Web.WebConfig.Util.ComplexTypeParser> CreateParserDelegate(bool isOpenRasta);
    }
    public enum PersistenceModeValue
    {
        Attribute = 0,
        InnerProperty = 1,
        InnerDefaultProperty = 2,
        EncodedInnerDefaultProperty = 3,
    }
    public enum TemplateInstanceValue
    {
        Multiple = 0,
        Single = 1,
    }
}