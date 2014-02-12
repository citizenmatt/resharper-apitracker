[assembly: JetBrains.UI.Icons.CompiledIcons.CompiledIconsPackAttribute(IconNames=new string[] {
        "Html",
        "HtmlTagId",
        "HtmlTagAttribute",
        "HtmlTagAttributeValue",
        "HtmlTag"}, IconPackResourceIdentification="JetBrains.ReSharper.Psi.Html;component/resources/PsiHtmlThemedIcons/ThemedIcons.P" +
    "siHtml.Generated.Xaml")]
[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]
[assembly: System.Windows.Markup.XmlnsDefinitionAttribute("urn:shemas-jetbrains-com:ui-application-icons-psi-html", "JetBrains.ReSharper.Psi.Html.Resources")]

namespace JetBrains.ReSharper.Psi.Html.CodeStyle
{
    
    public class HtmlCodeFormattingSettings
    {
        public readonly JetBrains.ReSharper.Psi.CodeStyle.CommonFormatterSettingsKey CommonSettings;
        public readonly JetBrains.ReSharper.Psi.CodeStyle.GlobalFormatSettings GlobalSettings;
        public readonly JetBrains.ReSharper.Psi.Html.Impl.CodeStyle.HtmlFormatterSettingsKey Settings;
        public HtmlCodeFormattingSettings(JetBrains.ReSharper.Psi.Html.Impl.CodeStyle.HtmlFormatterSettingsKey settings, JetBrains.ReSharper.Psi.CodeStyle.GlobalFormatSettings globalSettings, JetBrains.ReSharper.Psi.CodeStyle.CommonFormatterSettingsKey commonSettings) { }
    }
}
namespace JetBrains.ReSharper.Psi.Html.Generation
{
    
    public abstract class FromHtmlGeneratedDocumentServiceBase : JetBrains.ReSharper.Psi.Web.Generation.GeneratedDocumentServiceBase
    {
        protected readonly JetBrains.ProjectModel.HtmlProjectFileType myHtmlProjectFileType;
        protected FromHtmlGeneratedDocumentServiceBase(JetBrains.ProjectModel.HtmlProjectFileType htmlProjectFileType) { }
        protected override bool ReparseOriginalFile(JetBrains.ReSharper.Psi.TreeTextRange treeTextRange, string newText, JetBrains.ReSharper.Psi.Impl.Shared.RangeTranslatorWithGeneratedRangeMap rangeTranslator) { }
    }
    public class static FromHtmlSecondaryLexingProcessBase
    {
        public static TTag GetTagForValidation<TTag, TTokenTypes>(this JetBrains.ReSharper.Psi.ExtensionsAPI.ISecondaryLexingProcess lexingProcess, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Psi.Parsing.MixedLexer mixedLexer, JetBrains.ReSharper.Psi.Html.Parsing.IHtmlTokenNodeType<TTokenTypes> tokenNodeType, JetBrains.ReSharper.Psi.Parsing.TokenNodeType supportedToken, System.Collections.Generic.Dictionary<JetBrains.Util.TextRange, object> cachedTags, out int headerEndOffset)
            where TTag :  class, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTag
            where TTokenTypes :  class, JetBrains.ReSharper.Psi.Html.Parsing.IHtmlTokenNodeTypes { }
    }
    public abstract class FromHtmlSecondaryLexingProcessBase<TTokenTypes, TGeneratedDocumentService> : JetBrains.ReSharper.Psi.ExtensionsAPI.ISecondaryLexingProcess
        where TTokenTypes :  class, JetBrains.ReSharper.Psi.Html.Parsing.IHtmlTokenNodeTypes
        where TGeneratedDocumentService : JetBrains.ReSharper.Psi.ExtensionsAPI.IGeneratedDocumentService
    {
        protected readonly JetBrains.ReSharper.Psi.Parsing.MixedLexer myMixedLexer;
        protected FromHtmlSecondaryLexingProcessBase(JetBrains.ReSharper.Psi.Parsing.MixedLexer mixedLexer, JetBrains.ProjectModel.ISolution solution, JetBrains.ProjectModel.ProjectFileType projectFileType, TGeneratedDocumentService service) { }
        protected TGeneratedDocumentService Service { get; }
        protected JetBrains.ProjectModel.ISolution Solution { get; }
        public bool CanHandle(JetBrains.ProjectModel.ProjectFileType projectFileType) { }
        protected JetBrains.Util.JetTuple<int, int, JetBrains.Util.TextRange[]> FindTagEnd(JetBrains.ReSharper.Psi.Html.Parsing.IHtmlTokenNodeType<TTokenTypes> tokenNodeType, JetBrains.ReSharper.Psi.Parsing.TokenNodeType supportedToken, int headerEnd) { }
        protected abstract JetBrains.Util.JetTuple<int, int, JetBrains.Util.TextRange[]> GetInnerLexerRange([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Html.Parsing.IHtmlTokenNodeType<TTokenTypes> tokenNodeType);
        public virtual JetBrains.ReSharper.Psi.Parsing.ILexer TryCreateCodeBehindLexer(JetBrains.ReSharper.Psi.Parsing.ILexer baseLexer) { }
    }
    public class HtmlSecondaryDocumentGenerationResult : JetBrains.ReSharper.Psi.ExtensionsAPI.SecondaryDocumentGenerationResult
    {
        public HtmlSecondaryDocumentGenerationResult(string text, JetBrains.ReSharper.Psi.PsiLanguageType language, JetBrains.ReSharper.Psi.Files.ISecondaryRangeTranslator secondaryRangeTranslator, JetBrains.ReSharper.Psi.ExtensionsAPI.FileDependency dependencies, JetBrains.ReSharper.Psi.Html.Tree.IHtmlFile htmlFile, JetBrains.ReSharper.Psi.Parsing.ILexerFactory lexerFactory) { }
        public override void CommitChanges() { }
    }
}
namespace JetBrains.ReSharper.Psi.Html.Html
{
    
    public struct AttributeInfo : JetBrains.ReSharper.Psi.Web.IVersionRestricted
    {
        public readonly JetBrains.ReSharper.Psi.Html.Html.IHtmlAttributeDeclaredElement AttributeDeclaredElement;
        public readonly string DefaultValue;
        public readonly JetBrains.ReSharper.Psi.Html.Html.DefaultAttributeValueType DefaultValueType;
        public AttributeInfo(JetBrains.ReSharper.Psi.Html.Html.IHtmlAttributeDeclaredElement attributeDeclaredElement, JetBrains.ReSharper.Psi.Html.Html.DefaultAttributeValueType defaultValueType, string defaultValue) { }
        public System.Nullable<JetBrains.ReSharper.Psi.Web.AspNetVersion> SupportedVersion { get; }
    }
    public enum DefaultAttributeValueType
    {
        REQUIRED = 0,
        IMPLIED = 1,
        FIXED = 2,
    }
    public class static HtmlDeclaredElementsCacheUtils
    {
        public static JetBrains.ReSharper.Psi.Html.Html.IHtmlDeclaredElementsCache GetInstance(JetBrains.ProjectModel.ISolution solution) { }
    }
    public class static HtmlEnumAttributeValueTypeExtensions
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Psi.Html.Html.IHtmlAttributeEnumValue GetMember(this JetBrains.ReSharper.Psi.Html.Html.IHtmlEnumAttributeValueType type, string name) { }
    }
    public interface IHtmlAttributeDeclaredElement : JetBrains.ReSharper.Psi.Html.Html.IHtmlDeclaredElement, JetBrains.ReSharper.Psi.Html.Html.IObsoletable, JetBrains.ReSharper.Psi.IDeclaredElement, JetBrains.ReSharper.Psi.Web.IVersionRestricted
    {
        bool RequiresValue { get; }
        JetBrains.ReSharper.Psi.Html.Html.IHtmlTagDeclaredElement Tag { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Html.Html.IHtmlAttributeValueType ValueType { get; }
    }
    public interface IHtmlAttributeEnumValue : JetBrains.ReSharper.Psi.Html.Html.IHtmlDeclaredElement, JetBrains.ReSharper.Psi.IDeclaredElement
    {
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Html.Html.IHtmlEnumAttributeValueType Type { get; }
    }
    public interface IHtmlAttributeValueType
    {
        string Name { get; }
    }
    public interface IHtmlDeclaredElement : JetBrains.ReSharper.Psi.IDeclaredElement { }
    public interface IHtmlDeclaredElementsCache
    {
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetAllAttributesSymbolTable([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile);
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetAllTagsSymbolTable([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.IPsiSourceFile projectFile);
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Html.Html.IHtmlAttributeDeclaredElement> GetAttributes(string name, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile);
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Html.Html.IHtmlAttributeValueType GetAttributeValueType(string typeName, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile);
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetCommonAttributesSymbolTable([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile);
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Html.Html.IHtmlEventDeclaredElement GetEvent(string name, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile);
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetEventsSymbolTable([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile);
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetLegacyEventsSymbolTable([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile);
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Html.Html.IHtmlTagDeclaredElement GetTag(string name, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile);
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetTagAttributesSymbolTable([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Html.Html.IHtmlTagDeclaredElement tag, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, bool strict = False);
    }
    public interface IHtmlDeclaredElementsProvider
    {
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetAllAttributesSymbolTable();
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetAllTagsSymbolTable();
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Html.Html.AttributeInfo> GetAttributeInfos(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, JetBrains.ReSharper.Psi.Html.Html.IHtmlTagDeclaredElement tag, bool strict);
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Html.Html.IHtmlAttributeDeclaredElement> GetAttributes(string name);
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Html.Html.IHtmlAttributeValueType GetAttributeValueType(string typeName);
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetCommonAttributesSymbolTable();
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Html.Html.IHtmlEventDeclaredElement GetEvent(string name);
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetEventsSymbolTable();
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetLegacyEventsSymbolTable();
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Html.Html.IHtmlTagDeclaredElement GetTag(string name);
        bool IsApplicable([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.IPsiSourceFile file);
    }
    public interface IHtmlDeclaredElementTypes : JetBrains.ReSharper.Psi.Html.Html.IHtmlDeclaredElementTypesBase { }
    public interface IHtmlDeclaredElementTypesBase
    {
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Html.Html.IHtmlEnumAttributeValueType BoolType { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Html.Html.IHtmlDeclaredElementsCache ElementsCache { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Html.Html.IHtmlAttributeDeclaredElement ForAttribute { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Html.Html.IHtmlAttributeDeclaredElement IdAttribute { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Html.Html.IHtmlEnumAttributeValueType InputType { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Html.Html.IHtmlEnumAttributeValueType LanguageType { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Html.Html.IHtmlAttributeDeclaredElement NameAttribute { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Html.Html.IHtmlAttributeValueType UrlType { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Html.Html.IHtmlTagDeclaredElement GetObjectTag();
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Html.Html.IHtmlTagDeclaredElement GetTableTag();
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Html.Html.IHtmlTagDeclaredElement GetTdTag();
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Html.Html.IHtmlTagDeclaredElement GetTrTag();
        bool IsEvent([JetBrains.Annotations.NotNullAttribute()] string attributeName, [JetBrains.Annotations.CanBeNullAttribute()] string tagName = null);
    }
    public interface IHtmlEnumAttributeValueType
    {
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Html.Html.IHtmlAttributeEnumValue> Members { get; }
        bool Strict { get; }
    }
    public interface IHtmlEventDeclaredElement : JetBrains.ReSharper.Psi.Html.Html.IHtmlDeclaredElement, JetBrains.ReSharper.Psi.IDeclaredElement { }
    public interface IHtmlTagDeclaredElement : JetBrains.ReSharper.Psi.Html.Html.IHtmlDeclaredElement, JetBrains.ReSharper.Psi.Html.Html.IObsoletable, JetBrains.ReSharper.Psi.IDeclaredElement
    {
        JetBrains.ReSharper.Psi.Html.Html.TagClosingRequirement ClosingRequirement { get; }
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Html.Html.AttributeInfo> InheritedAttributes { get; }
        bool OnlyOnce { get; }
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Html.Html.AttributeInfo> OwnAttributes { get; }
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Html.Html.AttributeInfo> GetAllowedAttributes(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, bool strict = False);
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IType GetType(JetBrains.ReSharper.Psi.Html.Tree.IHtmlTag treeTag);
    }
    public interface IHtmlXmlns : JetBrains.ReSharper.Psi.Html.Html.IHtmlDeclaredElement, JetBrains.ReSharper.Psi.IDeclaredElement { }
    public interface IObsoletable
    {
        bool NonStandard { get; }
        bool Obsolete { get; }
    }
    public class static LanguageSpecificAttributesForHtmlTagsUtils
    {
        public static System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Html.Html.AttributeInfo> GetAttributeInfos(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Html.Html.IHtmlDeclaredElementsProvider> languageSpecificAttributesForHtmlTags, JetBrains.ReSharper.Psi.Html.Html.IHtmlTagDeclaredElement tag, bool strict = False) { }
    }
    public enum TagClosingRequirement
    {
        REGULAR_TAG_CLOSING_REQUIRED = 0,
        REGULAR_TAG_CLOSING_OPTIONAL = 1,
        EMPTY_TAG = 2,
    }
}
namespace JetBrains.ReSharper.Psi.Html
{
    
    [JetBrains.ReSharper.Psi.LanguageDefinitionAttribute("HTML")]
    public class HtmlLanguage : JetBrains.ReSharper.Psi.KnownLanguage
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static readonly JetBrains.ReSharper.Psi.Html.HtmlLanguage Instance;
        public const string Name = "HTML";
        protected HtmlLanguage([JetBrains.Annotations.NotNullAttribute()] string name, [JetBrains.Annotations.NotNullAttribute()] string presentableName) { }
        protected HtmlLanguage([JetBrains.Annotations.NotNullAttribute()] string name) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.Html.HtmlLanguage))]
    public class HtmlLanguageService : JetBrains.ReSharper.Psi.LanguageService
    {
        public HtmlLanguageService(JetBrains.ReSharper.Psi.Html.HtmlLanguage htmlLanguage, JetBrains.ReSharper.Psi.IConstantValueService constantValueService, JetBrains.ReSharper.Psi.Html.Parsing.IHtmlTokenNodeTypes tokenNodeTypes, JetBrains.ReSharper.Psi.Html.IHtmlCodeFormatter codeFormatter, JetBrains.ReSharper.Psi.Html.Parsing.IWebTreeBuilderFactory webTreeBuilderFactory) { }
        public override JetBrains.ReSharper.Psi.ExtensionsAPI.Caches2.ILanguageCacheProvider CacheProvider { get; }
        public override JetBrains.ReSharper.Psi.CodeStyle.ICodeFormatter CodeFormatter { get; }
        public override bool IsCaseSensitive { get; }
        public override bool SupportTypeMemberCache { get; }
        public override JetBrains.ReSharper.Psi.ITypePresenter TypePresenter { get; }
        public override JetBrains.ReSharper.Psi.Parsing.ILexer CreateFilteringLexer(JetBrains.ReSharper.Psi.Parsing.ILexer lexer) { }
        public override JetBrains.ReSharper.Psi.Parsing.IParser CreateParser(JetBrains.ReSharper.Psi.Parsing.ILexer lexer, JetBrains.ReSharper.Psi.Modules.IPsiModule module, JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
        public override JetBrains.ReSharper.Psi.ExtensionsAPI.IReferenceContextCodec CreateReferenceContextCodec() { }
        public override JetBrains.ReSharper.Psi.Parsing.ILexerFactory GetPrimaryLexerFactory() { }
        public override bool IsValidName(JetBrains.ReSharper.Psi.DeclaredElementType elementType, string name) { }
    }
    [JetBrains.ProjectModel.ProjectFileTypeAttribute(typeof(JetBrains.ProjectModel.HtmlProjectFileType))]
    public class HtmlProjectFileLanguageService : JetBrains.ReSharper.Psi.MixedProjectFileLanguageService
    {
        public HtmlProjectFileLanguageService(JetBrains.ProjectModel.HtmlProjectFileType projectFileType) { }
        public override JetBrains.UI.Icons.IconId Icon { get; }
        protected override JetBrains.ReSharper.Psi.PsiLanguageType PsiLanguageType { get; }
    }
    public interface IHtmlCodeFormatter : JetBrains.ReSharper.Psi.CodeStyle.ICodeFormatter { }
    public class static TagNameUtil
    {
        public static bool IsValidName(string name, string nameForTest) { }
    }
}
namespace JetBrains.ReSharper.Psi.Html.Impl.CodeStyle
{
    
    public enum HtmlAttributeIndenting
    {
        [System.ComponentModel.DescriptionAttribute("One indent")]
        OneStep = 0,
        [System.ComponentModel.DescriptionAttribute("Two indents")]
        TwoSteps = 1,
        [System.ComponentModel.DescriptionAttribute("Align by first attribute")]
        ByFirstAttr = 2,
    }
    public enum HtmlAttributesFormat
    {
        [System.ComponentModel.DescriptionAttribute("On single line")]
        OnSingleLine = 0,
        [System.ComponentModel.DescriptionAttribute("First attribute on single line")]
        FirstAttributeOnSingleLine = 1,
        [System.ComponentModel.DescriptionAttribute("Each attribute on separate lines")]
        OnDifferentLines = 2,
        [System.ComponentModel.DescriptionAttribute("Do not touch")]
        DoNotTouch = 3,
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.Html.HtmlLanguage))]
    public class HtmlCodeFormatter : JetBrains.ReSharper.Psi.Impl.CodeStyle.CodeFormatterBase, JetBrains.ReSharper.Psi.CodeStyle.ICodeFormatter, JetBrains.ReSharper.Psi.Html.IHtmlCodeFormatter
    {
        public HtmlCodeFormatter(JetBrains.ReSharper.Psi.Html.HtmlLanguage language, JetBrains.ReSharper.Psi.Html.Parsing.IHtmlTokenNodeTypes tokenNodeTypes, JetBrains.Application.Settings.ISettingsStore settingsStore, JetBrains.Application.Settings.ISettingsOptimization settingsOptimization) { }
        protected override JetBrains.ReSharper.Psi.PsiLanguageType LanguageType { get; }
        public override JetBrains.ReSharper.Psi.Tree.ITreeNode CreateNewLine() { }
        public override JetBrains.ReSharper.Psi.Tree.ITreeNode CreateSpace(string indent, JetBrains.ReSharper.Psi.Tree.ITreeNode replacedSpace) { }
        protected virtual void DoIndent(JetBrains.ReSharper.Psi.Impl.CodeStyle.CodeFormattingContext context, JetBrains.ReSharper.Psi.Html.CodeStyle.HtmlCodeFormattingSettings settings, JetBrains.ReSharper.Psi.CodeStyle.CodeFormatProfile profile, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override JetBrains.ReSharper.Psi.ITreeRange Format(JetBrains.ReSharper.Psi.Tree.ITreeNode firstElement, JetBrains.ReSharper.Psi.Tree.ITreeNode lastElement, JetBrains.ReSharper.Psi.CodeStyle.CodeFormatProfile profile, JetBrains.Application.Progress.IProgressIndicator progressIndicator, JetBrains.Application.Settings.IContextBoundSettingsStore overrideSettingsStore = null) { }
        public override void FormatDeletedNodes(JetBrains.ReSharper.Psi.Tree.ITreeNode parent, JetBrains.ReSharper.Psi.Tree.ITreeNode prevNode, JetBrains.ReSharper.Psi.Tree.ITreeNode nextNode) { }
        public override void FormatInsertedNodes(JetBrains.ReSharper.Psi.Tree.ITreeNode nodeFirst, JetBrains.ReSharper.Psi.Tree.ITreeNode nodeLast, bool formatSurround) { }
        public override JetBrains.ReSharper.Psi.ITreeRange FormatInsertedRange(JetBrains.ReSharper.Psi.Tree.ITreeNode nodeFirst, JetBrains.ReSharper.Psi.Tree.ITreeNode nodeLast, JetBrains.ReSharper.Psi.ITreeRange origin) { }
        public override void FormatReplacedNode(JetBrains.ReSharper.Psi.Tree.ITreeNode oldNode, JetBrains.ReSharper.Psi.Tree.ITreeNode newNode) { }
        public override JetBrains.ReSharper.Psi.Tree.ITokenNode GetMinimalSeparator(JetBrains.ReSharper.Psi.Tree.ITokenNode leftToken, JetBrains.ReSharper.Psi.Tree.ITokenNode rightToken) { }
        protected override bool IsFormatNextSpaces(JetBrains.ReSharper.Psi.CodeStyle.CodeFormatProfile profile) { }
        protected virtual void RunFormatterForGeneratedLanguage(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, JetBrains.ReSharper.Psi.PsiLanguageType language, JetBrains.DocumentModel.DocumentRange range, JetBrains.ReSharper.Psi.CodeStyle.CodeFormatProfile profile, JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
        protected virtual void RunFormatterForGeneratedLanguages(JetBrains.ReSharper.Psi.Tree.IFile originalFile, JetBrains.ReSharper.Psi.Tree.ITreeNode firstNode, JetBrains.ReSharper.Psi.Tree.ITreeNode lastNode, JetBrains.ReSharper.Psi.CodeStyle.CodeFormatProfile profile, JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
        public virtual bool TryCustomFormat(JetBrains.ReSharper.Psi.Tree.ITreeNode firstElement, JetBrains.ReSharper.Psi.Tree.ITreeNode lastElement, JetBrains.ReSharper.Psi.CodeStyle.CodeFormatProfile profile, JetBrains.Application.Progress.IProgressIndicator progressIndicator = null) { }
    }
    [JetBrains.ReSharper.Psi.CodeStyle.SettingsUpgrade.CodeStyleSettingsAttribute("HTML")]
    public class HtmlCodeStyleSettings : JetBrains.Application.Configuration.IXmlReadable, JetBrains.Util.ICloneable<JetBrains.ReSharper.Psi.Html.Impl.CodeStyle.HtmlCodeStyleSettings>, System.ICloneable
    {
        public JetBrains.ReSharper.Psi.Html.Impl.CodeStyle.HtmlCodeStyleSettings Clone() { }
        public void ReadFromXml(System.Xml.XmlElement element) { }
    }
    public class static HtmlFormatterHelper
    {
        public static bool HasSpacePreservation([JetBrains.Annotations.CanBeNullAttribute()] this JetBrains.ReSharper.Psi.Html.Tree.IHtmlTag tag) { }
    }
    [JetBrains.Application.Settings.SettingsKeyAttribute(typeof(JetBrains.ReSharper.Psi.CodeStyle.CodeFormattingSettingsKey), "Code formatting in HTML")]
    public class HtmlFormatterSettingsKey
    {
        [JetBrains.Application.Settings.SettingsEntryAttribute(true, "Blank line after processing instructions")]
        public bool BlankLineAfterProcessingInstructions;
        [JetBrains.Application.Settings.SettingsEntryAttribute(2, "Maximum blank lines between tags")]
        public int MaxBlankLines;
        [JetBrains.Application.Settings.SettingsEntryAttribute(20, "Maximum single line tag content length")]
        public int MaxSingleLineTagLength;
        [JetBrains.Application.Settings.SettingsEntryAttribute(false, "Spaces around \'=\' in attribute")]
        public bool ProcessingInstructionAroundAttributeEq;
        [JetBrains.Application.Settings.SettingsEntryAttribute(JetBrains.ReSharper.Psi.Html.Impl.CodeStyle.HtmlAttributeIndenting.ByFirstAttr, "Attributes indenting")]
        public JetBrains.ReSharper.Psi.Html.Impl.CodeStyle.HtmlAttributeIndenting ProcessingInstructionAttributeIndenting;
        [JetBrains.Application.Settings.SettingsEntryAttribute(JetBrains.ReSharper.Psi.Html.Impl.CodeStyle.HtmlAttributesFormat.OnSingleLine, "Attributes format")]
        public JetBrains.ReSharper.Psi.Html.Impl.CodeStyle.HtmlAttributesFormat ProcessingInstructionAttributesFormat;
        [JetBrains.Application.Settings.SettingsEntryAttribute(false, "Space after last attribute")]
        public bool ProcessingInstructionSpaceAfterLastAttr;
        [JetBrains.Application.Settings.SettingsEntryAttribute(JetBrains.ReSharper.Psi.Html.Impl.CodeStyle.HtmlAttributeIndenting.ByFirstAttr, "Attributes indenting")]
        public JetBrains.ReSharper.Psi.Html.Impl.CodeStyle.HtmlAttributeIndenting TagAttributeIndenting;
        [JetBrains.Application.Settings.SettingsEntryAttribute(JetBrains.ReSharper.Psi.Html.Impl.CodeStyle.HtmlAttributesFormat.OnSingleLine, "Attributes format")]
        public JetBrains.ReSharper.Psi.Html.Impl.CodeStyle.HtmlAttributesFormat TagAttributesFormat;
        [JetBrains.Application.Settings.SettingsEntryAttribute(false, "Space after last attribute")]
        public bool TagSpaceAfterLastAttr;
        [JetBrains.Application.Settings.SettingsEntryAttribute(true, "Space before \'/>\'")]
        public bool TagSpaceBeforeHeaderEnd1;
        [JetBrains.Application.Settings.SettingsEntryAttribute(false, "Spaces around \'=\' in attribute")]
        public bool TagSpacesAroundAttributeEq;
        [JetBrains.Application.Settings.SettingsEntryAttribute(true, "Wrap before attribute")]
        public bool WrapBeforeAttr;
        [JetBrains.Application.Settings.SettingsEntryAttribute(false, "Wrap inside text")]
        public bool WrapInsideText;
        [JetBrains.Application.Settings.SettingsEntryAttribute(120, "Right margin (columns)")]
        public int WrapLimit;
        [JetBrains.Application.Settings.SettingsEntryAttribute(true, "Wrap long lines")]
        public bool WrapLongLines;
        public HtmlFormatterSettingsKey() { }
    }
    public class HtmlIndentingStage
    {
        public static void DoIndent(JetBrains.ReSharper.Psi.Impl.CodeStyle.CodeFormattingContext context, JetBrains.ReSharper.Psi.Html.CodeStyle.HtmlCodeFormattingSettings settings, JetBrains.ReSharper.Psi.CodeStyle.CodeFormatProfile profile, JetBrains.Application.Progress.IProgressIndicator progress, JetBrains.ReSharper.Psi.Html.Impl.CodeStyle.HtmlIndentingVisitor visitor) { }
    }
    public class HtmlIndentingVisitor : JetBrains.ReSharper.Psi.Html.Tree.HtmlTreeVisitor<JetBrains.ReSharper.Psi.Impl.CodeStyle.FormattingStageContext, string>
    {
        public HtmlIndentingVisitor(JetBrains.ReSharper.Psi.Html.CodeStyle.HtmlCodeFormattingSettings settings, JetBrains.ReSharper.Psi.Impl.CodeStyle.IndentCache<JetBrains.ReSharper.Psi.Tree.ITreeNode> indentCache) { }
        public JetBrains.ReSharper.Psi.Impl.CodeStyle.IndentCache<JetBrains.ReSharper.Psi.Tree.ITreeNode> IndentCache { get; }
        public string IndentStr { get; }
        protected string GetAttrContainerIndent<TAttribute>(JetBrains.ReSharper.Psi.Web.Tree.IWebAttributeContainer<TAttribute> container, JetBrains.ReSharper.Psi.Html.Impl.CodeStyle.HtmlAttributeIndenting attrIndent, JetBrains.ReSharper.Psi.Impl.CodeStyle.FormattingStageContext context)
            where TAttribute :  class, JetBrains.ReSharper.Psi.Web.Tree.IWebAttribute { }
        public override string VisitHtmlConditionalComment(JetBrains.ReSharper.Psi.Html.Tree.IHtmlConditionalComment node, JetBrains.ReSharper.Psi.Impl.CodeStyle.FormattingStageContext context) { }
        public override string VisitHtmlFile(JetBrains.ReSharper.Psi.Html.Tree.IHtmlFile node, JetBrains.ReSharper.Psi.Impl.CodeStyle.FormattingStageContext context) { }
        public override string VisitHtmlTag(JetBrains.ReSharper.Psi.Html.Tree.IHtmlTag tag, JetBrains.ReSharper.Psi.Impl.CodeStyle.FormattingStageContext context) { }
        public override string VisitNode(JetBrains.ReSharper.Psi.Tree.ITreeNode node, JetBrains.ReSharper.Psi.Impl.CodeStyle.FormattingStageContext context) { }
        public override string VisitTagHeader(JetBrains.ReSharper.Psi.Html.Tree.IHtmlTagHeader node, JetBrains.ReSharper.Psi.Impl.CodeStyle.FormattingStageContext context) { }
        public override string VisitWebAttributeContainer<TAttribute>(JetBrains.ReSharper.Psi.Web.Tree.IWebAttributeContainer<TAttribute> node, JetBrains.ReSharper.Psi.Impl.CodeStyle.FormattingStageContext context)
            where TAttribute :  class, JetBrains.ReSharper.Psi.Web.Tree.IWebAttribute { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class VsHtmlFormatSettings
    {
        public virtual bool AutoInsertCloseTag { get; }
        public virtual JetBrains.ReSharper.Psi.CodeStyle.Casing ClientAttrCasing { get; }
        public virtual JetBrains.ReSharper.Psi.CodeStyle.Casing ClientTagCasing { get; }
        public virtual bool InsertAttrValueQuotesFormatting { get; }
        public virtual bool InsertAttrValueQuotesTyping { get; }
        public virtual JetBrains.ReSharper.Psi.CodeStyle.Casing ServerAttrCasing { get; }
        public virtual JetBrains.ReSharper.Psi.CodeStyle.Casing ServerTagCasing { get; }
    }
}
namespace JetBrains.ReSharper.Psi.Html.Impl.Html
{
    
    public class HtmlAttributeValueType : JetBrains.ReSharper.Psi.Html.Html.IHtmlAttributeValueType
    {
        public HtmlAttributeValueType(string name) { }
        public string Name { get; }
        public bool Equals(JetBrains.ReSharper.Psi.Html.Impl.Html.HtmlAttributeValueType other) { }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
    }
    public abstract class HtmlCachedTypeMemberBase<T> : JetBrains.ReSharper.Psi.ExtensionsAPI.Caches2.CachedTypeMemberBase, JetBrains.ReSharper.Psi.IDeclaredElement
        where T :  class, JetBrains.ReSharper.Psi.ExtensionsAPI.Caches2.ICachedTypeMemberDeclaration, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode
    {
        protected HtmlCachedTypeMemberBase(T declaration) { }
        public virtual bool CaseSensistiveName { get; }
        public JetBrains.ReSharper.Psi.Resolve.ISubstitution IdSubstitution { get; }
        public string ShortName { get; }
        public string XMLDocId { get; }
        protected override bool CanBindTo(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration) { }
        public JetBrains.ReSharper.Psi.ITypeMember GetContainingTypeMember() { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        protected T GetDeclaration() { }
        public abstract JetBrains.ReSharper.Psi.DeclaredElementType GetElementType();
        [JetBrains.Annotations.CanBeNullAttribute()]
        protected JetBrains.ReSharper.Psi.Html.Tree.IHtmlFile GetHtmlFile() { }
        protected virtual string GetShortName([JetBrains.Annotations.NotNullAttribute()] T declaration) { }
        public System.Xml.XmlNode GetXMLDescriptionSummary(bool inherit) { }
        public System.Xml.XmlNode GetXMLDoc(bool inherit) { }
        public virtual bool IsSynthetic() { }
    }
    [JetBrains.ReSharper.Psi.PsiComponentAttribute()]
    public class HtmlDeclaredElementsCache : JetBrains.ReSharper.Psi.Html.Html.IHtmlDeclaredElementsCache, JetBrains.ReSharper.Psi.Html.Html.IHtmlDeclaredElementsPluginManager
    {
        public HtmlDeclaredElementsCache(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Html.Html.IHtmlDeclaredElementsProvider> providers) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Html.Html.AttributeInfo> GetAdditionalAttributesForTag(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, JetBrains.ReSharper.Psi.Html.Html.IHtmlTagDeclaredElement tag, bool strict) { }
        public JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetAllAttributesSymbolTable(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
        public JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetAllTagsSymbolTable(JetBrains.ReSharper.Psi.IPsiSourceFile projectFile) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Html.Html.IHtmlAttributeDeclaredElement> GetAttributes(string name, JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
        public JetBrains.ReSharper.Psi.Html.Html.IHtmlAttributeValueType GetAttributeValueType(string typeName, JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
        public JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetCommonAttributesSymbolTable(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
        public JetBrains.ReSharper.Psi.Html.Html.IHtmlEventDeclaredElement GetEvent(string name, JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
        public JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetEventsSymbolTable(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
        public JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetLegacyEventsSymbolTable(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
        public JetBrains.ReSharper.Psi.Html.Html.IHtmlTagDeclaredElement GetTag(string name, JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
        public JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetTagAttributesSymbolTable(JetBrains.ReSharper.Psi.Html.Html.IHtmlTagDeclaredElement tag, JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, bool strict = False) { }
    }
    public abstract class HtmlDeclaredElementsProvider : JetBrains.ReSharper.Psi.Html.Html.IHtmlDeclaredElementsProvider
    {
        protected HtmlDeclaredElementsProvider(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ProjectModel.ISolution solution, string resourceFileName, System.Reflection.Assembly resourceAssembly, bool includeInAdditionalAttributes) { }
        protected bool IsDisposed { get; }
        protected object LockObject { get; }
        protected virtual void DoClear() { }
        protected System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Html.Html.IHtmlAttributeDeclaredElement> GetAllAttributes() { }
        public JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetAllAttributesSymbolTable() { }
        protected System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Html.Html.AttributeInfo> GetAllCommonAttributes() { }
        protected System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Html.Html.IHtmlEventDeclaredElement> GetAllEvents() { }
        protected System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Html.Html.IHtmlTagDeclaredElement> GetAllTags() { }
        public JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetAllTagsSymbolTable() { }
        public virtual System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Html.Html.AttributeInfo> GetAttributeInfos(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, JetBrains.ReSharper.Psi.Html.Html.IHtmlTagDeclaredElement tag, bool strict) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Html.Html.IHtmlAttributeDeclaredElement> GetAttributes(string name) { }
        public JetBrains.ReSharper.Psi.Html.Html.IHtmlAttributeValueType GetAttributeValueType(string typeName) { }
        public JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetCommonAttributesSymbolTable() { }
        public JetBrains.ReSharper.Psi.Html.Html.IHtmlEventDeclaredElement GetEvent(string name) { }
        public JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetEventsSymbolTable() { }
        public JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetLegacyEventsSymbolTable() { }
        public JetBrains.ReSharper.Psi.Html.Html.IHtmlTagDeclaredElement GetTag(string name) { }
        protected void InitializeIfNecessary() { }
        public abstract bool IsApplicable(JetBrains.ReSharper.Psi.IPsiSourceFile file);
    }
    [JetBrains.ReSharper.Psi.PsiComponentAttribute()]
    public class HtmlDeclaredElementTypes : JetBrains.ReSharper.Psi.Html.Impl.Html.HtmlDeclaredElementTypesBase, JetBrains.ReSharper.Psi.Html.Html.IHtmlDeclaredElementTypes, JetBrains.ReSharper.Psi.Html.Html.IHtmlDeclaredElementTypesBase
    {
        public HtmlDeclaredElementTypes(JetBrains.ReSharper.Psi.Html.Html.IHtmlDeclaredElementsCache htmlDeclaredElementsCache) { }
    }
    public abstract class HtmlDeclaredElementTypesBase : JetBrains.ReSharper.Psi.Html.Html.IHtmlDeclaredElementTypesBase
    {
        protected HtmlDeclaredElementTypesBase(JetBrains.ReSharper.Psi.Html.Html.IHtmlDeclaredElementsCache htmlDeclaredElementsCache) { }
        public JetBrains.ReSharper.Psi.Html.Html.IHtmlEnumAttributeValueType BoolType { get; }
        public JetBrains.ReSharper.Psi.Html.Html.IHtmlDeclaredElementsCache ElementsCache { get; }
        public JetBrains.ReSharper.Psi.Html.Html.IHtmlAttributeDeclaredElement ForAttribute { get; }
        public JetBrains.ReSharper.Psi.Html.Html.IHtmlAttributeDeclaredElement IdAttribute { get; }
        public JetBrains.ReSharper.Psi.Html.Html.IHtmlEnumAttributeValueType InputType { get; }
        public JetBrains.ReSharper.Psi.Html.Html.IHtmlEnumAttributeValueType LanguageType { get; }
        public JetBrains.ReSharper.Psi.Html.Html.IHtmlAttributeDeclaredElement NameAttribute { get; }
        public JetBrains.ReSharper.Psi.Html.Html.IHtmlAttributeValueType ScriptType { get; }
        public JetBrains.ReSharper.Psi.Html.Html.IHtmlAttributeValueType UrlType { get; }
        public JetBrains.ReSharper.Psi.Html.Html.IHtmlAttributeDeclaredElement GetCommonAttribute(string name) { }
        public JetBrains.ReSharper.Psi.Html.Html.IHtmlTagDeclaredElement GetObjectTag() { }
        public JetBrains.ReSharper.Psi.Html.Html.IHtmlTagDeclaredElement GetTableTag() { }
        public JetBrains.ReSharper.Psi.Html.Html.IHtmlTagDeclaredElement GetTdTag() { }
        public JetBrains.ReSharper.Psi.Html.Html.IHtmlTagDeclaredElement GetTrTag() { }
        public bool IsEvent(string attributeName, string tagName) { }
    }
    public class HtmlEventsSymbolTable : JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.SymbolTableBase
    {
        public HtmlEventsSymbolTable(System.Collections.Generic.IDictionary<string, JetBrains.ReSharper.Psi.Html.Html.IHtmlEventDeclaredElement> events) { }
        public override void ForAllSymbolInfos(System.Action<JetBrains.ReSharper.Psi.Resolve.ISymbolInfo> processor) { }
        public override JetBrains.ReSharper.Psi.Dependencies.ISymbolTableDependencySet GetDependencySet() { }
        public override System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Resolve.ISymbolInfo> GetSymbolInfos(string name) { }
        public override System.Collections.Generic.IEnumerable<string> Names() { }
    }
    [JetBrains.ReSharper.Psi.PsiComponentAttribute()]
    public class HtmlStandardDeclaredElementsProvider : JetBrains.ReSharper.Psi.Html.Impl.Html.HtmlDeclaredElementsProvider
    {
        public HtmlStandardDeclaredElementsProvider(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ProjectModel.ISolution solution) { }
        public override bool IsApplicable(JetBrains.ReSharper.Psi.IPsiSourceFile file) { }
    }
    public class HtmlTagIdDeclaredElement : JetBrains.ReSharper.Psi.IDeclaredElement, JetBrains.ReSharper.Psi.Web.DeclaredElements.IHtmlTagIdDeclaredElement
    {
        public HtmlTagIdDeclaredElement(string name, JetBrains.ProjectModel.ISolution solution) { }
        public bool CaseSensistiveName { get; }
        public JetBrains.ReSharper.Psi.PsiLanguageType PresentationLanguage { get; }
        public string ShortName { get; }
        public bool Equals(JetBrains.ReSharper.Psi.Web.DeclaredElements.IHtmlTagIdDeclaredElement other) { }
        public override bool Equals(object obj) { }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Tree.IDeclaration> GetDeclarations() { }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Tree.IDeclaration> GetDeclarationsIn(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
        public JetBrains.ReSharper.Psi.DeclaredElementType GetElementType() { }
        public override int GetHashCode() { }
        public JetBrains.ReSharper.Psi.IPsiServices GetPsiServices() { }
        public JetBrains.Util.DataStructures.HybridCollection<JetBrains.ReSharper.Psi.IPsiSourceFile> GetSourceFiles() { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Web.Symbols.IWebTagIdSymbol> GetSymbols() { }
        public System.Xml.XmlNode GetXMLDescriptionSummary(bool inherit) { }
        public System.Xml.XmlNode GetXMLDoc(bool inherit) { }
        public bool HasDeclarationsIn(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
        public bool IsSynthetic() { }
        public bool IsValid() { }
        public JetBrains.ReSharper.Psi.Web.DeclaredElements.IHtmlTagIdDeclaredElement SetNewName(string newName) { }
    }
}
namespace JetBrains.ReSharper.Psi.Html.Impl
{
    
    public class static HtmlKeywords
    {
        public const string BODY = "body";
        public const string BOOL_TYPE_NAME = "%Bool";
        public const string CLASS_ATTRIBUTE = "class";
        public const string ENDIF = "endif";
        public const string FALSE = "false";
        public const string FOR_ATTRIBUTE = "for";
        public const string GT = "gt";
        public const string GTE = "gte";
        public const string HEAD = "head";
        public const string HREF_ATTRIBUTE = "HRef";
        public const string HTML = "html";
        public const string ID_ATTRIBUTE = "id";
        public const string IF = "if";
        public const string INPUT_TYPE_NAME = "%InputType";
        public const string LANGUAGE_ATTRIBUTE = "Language";
        public const string LANGUAGE_TYPE_NAME = "%Language";
        public const string LINK = "link";
        public const string LT = "lt";
        public const string LTE = "lte";
        public const string NAME_ATTRIBUTE = "name";
        public const string OBJECT = "object";
        public const string RUNAT_ATTRIBUTE = "runat";
        public const string SCRIPT = "script";
        public const string SCRIPT_TYPE_NAME = "%Script";
        public const string SRC_ATTRIBUTE = "Src";
        public const string STYLE = "style";
        public const string STYLE_ATTRIBUTE = "style";
        public const string TABLE = "table";
        public const string TD = "td";
        public const string TEXTAREA = "textarea";
        public const string TITLE = "title";
        public const string TR = "tr";
        public const string TRUE = "true";
        public const string URL_TYPE_NAME = "%URL";
        public const string XMLNS_COLON_PREFIX = "xmlns:";
        public const string XMLNS_PREFIX = "xmlns";
    }
}
namespace JetBrains.ReSharper.Psi.Html.Impl.Parsing
{
    
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.Html.HtmlLanguage))]
    public class HtmlTokenNodeTypes : JetBrains.ReSharper.Psi.Html.Parsing.IHtmlTokenNodeTypes
    {
        protected const int LAST_HTML_TOKEN_NODE_TYPE_INDEX = 1055;
        public HtmlTokenNodeTypes(JetBrains.ReSharper.Psi.Html.HtmlLanguage lang) { }
        public JetBrains.ReSharper.Psi.Parsing.TokenNodeType ATTRIBUTE_NAME { get; }
        public JetBrains.ReSharper.Psi.Parsing.TokenNodeType ATTRIBUTE_VALUE { get; }
        public JetBrains.ReSharper.Psi.Parsing.TokenNodeType DOUBLE_QUOTE { get; }
        public JetBrains.ReSharper.Psi.Parsing.TokenNodeType EQ { get; }
        public JetBrains.ReSharper.Psi.Parsing.TokenNodeType ERROR { get; }
        public JetBrains.ReSharper.Psi.Parsing.TokenNodeType HTML_CDATA_BODY { get; }
        public JetBrains.ReSharper.Psi.Parsing.TokenNodeType HTML_CDATA_END { get; }
        public JetBrains.ReSharper.Psi.Parsing.TokenNodeType HTML_CDATA_START { get; }
        public JetBrains.ReSharper.Psi.Parsing.TokenNodeType HTML_COMMENT_BODY { get; }
        public JetBrains.ReSharper.Psi.Parsing.TokenNodeType HTML_COMMENT_END { get; }
        public JetBrains.ReSharper.Psi.Parsing.TokenNodeType HTML_COMMENT_START { get; }
        public JetBrains.ReSharper.Psi.Parsing.TokenNodeType HTML_CONDITIONAL_AND { get; }
        public JetBrains.ReSharper.Psi.Parsing.TokenNodeType HTML_CONDITIONAL_COMMENT_END { get; }
        public JetBrains.ReSharper.Psi.Parsing.TokenNodeType HTML_CONDITIONAL_COMMENT_END2 { get; }
        public JetBrains.ReSharper.Psi.Parsing.TokenNodeType HTML_CONDITIONAL_COMMENT_START { get; }
        public JetBrains.ReSharper.Psi.Parsing.TokenNodeType HTML_CONDITIONAL_END { get; }
        public JetBrains.ReSharper.Psi.Parsing.TokenNodeType HTML_CONDITIONAL_ENDIF { get; }
        public JetBrains.ReSharper.Psi.Parsing.TokenNodeType HTML_CONDITIONAL_FALSE { get; }
        public JetBrains.ReSharper.Psi.Parsing.TokenNodeType HTML_CONDITIONAL_GT { get; }
        public JetBrains.ReSharper.Psi.Parsing.TokenNodeType HTML_CONDITIONAL_GTE { get; }
        public JetBrains.ReSharper.Psi.Parsing.TokenNodeType HTML_CONDITIONAL_IF { get; }
        public JetBrains.ReSharper.Psi.Parsing.TokenNodeType HTML_CONDITIONAL_LPARENTH { get; }
        public JetBrains.ReSharper.Psi.Parsing.TokenNodeType HTML_CONDITIONAL_LT { get; }
        public JetBrains.ReSharper.Psi.Parsing.TokenNodeType HTML_CONDITIONAL_LTE { get; }
        public JetBrains.ReSharper.Psi.Parsing.TokenNodeType HTML_CONDITIONAL_NOT { get; }
        public JetBrains.ReSharper.Psi.Parsing.TokenNodeType HTML_CONDITIONAL_OR { get; }
        public JetBrains.ReSharper.Psi.Parsing.TokenNodeType HTML_CONDITIONAL_RPARENTH { get; }
        public JetBrains.ReSharper.Psi.Parsing.TokenNodeType HTML_CONDITIONAL_START { get; }
        public JetBrains.ReSharper.Psi.Parsing.TokenNodeType HTML_CONDITIONAL_TRUE { get; }
        public JetBrains.ReSharper.Psi.Parsing.TokenNodeType HTML_DOCTYPE_START { get; }
        public JetBrains.ReSharper.Psi.Parsing.TokenNodeType HTML_ENTITY_DIGITAL { get; }
        public JetBrains.ReSharper.Psi.Parsing.TokenNodeType HTML_ENTITY_HEXIMAL { get; }
        public JetBrains.ReSharper.Psi.Parsing.TokenNodeType HTML_ENTITY_NAMED { get; }
        public JetBrains.ReSharper.Psi.Parsing.TokenNodeType HTML_HEADER_START { get; }
        public JetBrains.ReSharper.Psi.Parsing.TokenNodeType HTML_INCLUDE_END { get; }
        public JetBrains.ReSharper.Psi.Parsing.TokenNodeType HTML_INCLUDE_FILE { get; }
        public JetBrains.ReSharper.Psi.Parsing.TokenNodeType HTML_INCLUDE_FILENAME { get; }
        public JetBrains.ReSharper.Psi.Parsing.TokenNodeType HTML_INCLUDE_VIRTUAL { get; }
        public JetBrains.ReSharper.Psi.Parsing.TokenNodeType IDENTIFIER { get; }
        public JetBrains.ReSharper.Psi.Parsing.TokenNodeType INCLUDED_FILE_END { get; }
        public JetBrains.ReSharper.Psi.Html.HtmlLanguage Language { get; }
        public JetBrains.ReSharper.Psi.Parsing.TokenNodeType NEW_LINE_IN_STRING { get; }
        public JetBrains.ReSharper.Psi.Parsing.TokenNodeType NUMBER { get; }
        public JetBrains.ReSharper.Psi.Parsing.TokenNodeType PI_END { get; }
        public JetBrains.ReSharper.Psi.Parsing.TokenNodeType PI_START { get; }
        public JetBrains.ReSharper.Psi.Parsing.TokenNodeType SCRIPT_BODY { get; }
        public JetBrains.ReSharper.Psi.Parsing.TokenNodeType SINGLE_QUOTE { get; }
        public JetBrains.ReSharper.Psi.Parsing.TokenNodeType SPACE { get; }
        public JetBrains.ReSharper.Psi.Parsing.TokenNodeType STRING { get; }
        public JetBrains.ReSharper.Psi.Parsing.TokenNodeType STYLE_BODY { get; }
        public JetBrains.ReSharper.Psi.Parsing.TokenNodeType TAG_END { get; }
        public JetBrains.ReSharper.Psi.Parsing.TokenNodeType TAG_END1 { get; }
        public JetBrains.ReSharper.Psi.Parsing.TokenNodeType TAG_NAME { get; }
        public JetBrains.ReSharper.Psi.Parsing.TokenNodeType TAG_START { get; }
        public JetBrains.ReSharper.Psi.Parsing.TokenNodeType TAG_START1 { get; }
        public JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet TAGS_BODY_NODE_SET { get; }
        public JetBrains.ReSharper.Psi.Parsing.TokenNodeType TEXT { get; }
        public JetBrains.ReSharper.Psi.Parsing.TokenNodeType TEXTAREA_BODY { get; }
        public virtual short GetChildRole(JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.TreeElement child) { }
        protected void Init<THtmlTokenNodeTypes>(JetBrains.ReSharper.Psi.Html.HtmlLanguage lang, THtmlTokenNodeTypes tokenNodeTypes)
            where THtmlTokenNodeTypes : JetBrains.ReSharper.Psi.Html.Parsing.IHtmlTokenNodeTypes { }
        public virtual bool IsNonHtmlToken(JetBrains.ReSharper.Psi.Parsing.TokenNodeType tokenNodeType) { }
        public virtual bool IsTagLikeClose(JetBrains.ReSharper.Psi.Parsing.TokenNodeType tokenNodeType) { }
        public virtual bool IsTagLikeOpen(JetBrains.ReSharper.Psi.Parsing.TokenNodeType tokenNodeType) { }
    }
}
namespace JetBrains.ReSharper.Psi.Html.Impl.PredefinedControls
{
    
    public class static HtmlControls
    {
        public static readonly string CLASS_ATTR;
        public static readonly string ID_ATTR;
        public static readonly string OBJECT_TAG;
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Psi.Html.Html.IHtmlAttributeValueType GetTagAttributeType(JetBrains.ReSharper.Psi.Html.Tree.ITagAttribute attribute) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Psi.Html.Impl.PredefinedControls.HtmlTagInfo GetTagInfo([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Html.Tree.IHtmlTag tag) { }
        public static bool IsHtmlTag(string tagName) { }
    }
    public class HtmlTagInfo
    {
        public static readonly JetBrains.ReSharper.Psi.Html.Impl.PredefinedControls.HtmlTagInfo Default;
        public const string DefaultNamespace = "System.Web.UI.HtmlControls";
        public const string DefaultType = "HtmlGenericControl";
        public HtmlTagInfo(string typeName, JetBrains.ReSharper.Psi.Html.Impl.PredefinedControls.TagRequirement startTag, JetBrains.ReSharper.Psi.Html.Impl.PredefinedControls.TagRequirement endTag, bool emptyTagAllowed, bool onlyOnce, [JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IDictionary<string, JetBrains.ReSharper.Psi.Html.Html.IHtmlAttributeValueType> attributes, System.Collections.Generic.IEnumerable<string> autoClosedBy) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public System.Collections.Generic.IDictionary<string, JetBrains.ReSharper.Psi.Html.Html.IHtmlAttributeValueType> AttributeTypes { get; }
        public System.Collections.Generic.JetHashSet<string> ClosingTagNames { get; }
        public bool EmptyTagAllowed { get; }
        public JetBrains.ReSharper.Psi.Html.Impl.PredefinedControls.TagRequirement EndTag { get; }
        public bool OnlyOnce { get; }
        public JetBrains.ReSharper.Psi.Html.Impl.PredefinedControls.TagRequirement StartTag { get; }
        public string TypeName { get; }
    }
    public enum TagRequirement
    {
        REQUIRED = 0,
        OPTIONAL = 1,
        FORBIDDEN = 2,
    }
}
namespace JetBrains.ReSharper.Psi.Html.Impl.References
{
    
    public class HtmlAllowedAttributesFilter : JetBrains.ReSharper.Psi.Resolve.SimpleSymbolFilter
    {
        public HtmlAllowedAttributesFilter(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Html.Html.AttributeInfo> allowedAttributes) { }
        public override JetBrains.ReSharper.Psi.Resolve.ResolveErrorType ErrorType { get; }
        public override bool Accepts(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution) { }
    }
    public struct HtmlAttributeValueEntry
    {
        public JetBrains.ReSharper.Psi.Html.Tree.ITagAttribute Attribute { get; }
        public JetBrains.ReSharper.Psi.IDeclaredElement AttributeResolution { get; }
        public JetBrains.ReSharper.Psi.Resolve.ISubstitution AttributeResolutionSubstitution { get; }
        public JetBrains.ReSharper.Psi.Html.Tree.IHtmlAttributeValue HtmlAttributeValue { get; }
        public bool IsEmpty { get; }
        public JetBrains.ReSharper.Psi.Html.Tree.IHtmlToken ValueToken { get; }
        public static JetBrains.ReSharper.Psi.Html.Impl.References.HtmlAttributeValueEntry CreateFromElement(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
    }
    public abstract class HtmlAttributeValueReferenceFactoryBase<TDeclaredElementTypes, TProjectFileType> : JetBrains.ReSharper.Psi.Html.Impl.References.HtmlReferenceFactoryBase<TDeclaredElementTypes, TProjectFileType>
        where TDeclaredElementTypes : JetBrains.ReSharper.Psi.Html.Html.IHtmlDeclaredElementTypesBase
        where TProjectFileType : JetBrains.ProjectModel.HtmlProjectFileType
    {
        protected HtmlAttributeValueReferenceFactoryBase(TDeclaredElementTypes declaredElementTypes) { }
        protected virtual bool CanHaveReference(JetBrains.ReSharper.Psi.Html.Impl.References.HtmlAttributeValueEntry entry, System.Collections.Generic.IEnumerable<string> names) { }
        protected abstract JetBrains.ReSharper.Psi.Resolve.IReference[] CreateReferences(JetBrains.ReSharper.Psi.Html.Impl.References.HtmlAttributeValueEntry entry);
        protected override JetBrains.ReSharper.Psi.Resolve.IReference[] GetReferences(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.Resolve.IReference[] oldReferences) { }
        protected override bool HasReference(JetBrains.ReSharper.Psi.Tree.ITreeNode element, System.Collections.Generic.ICollection<string> names) { }
        public abstract bool IsApplicable(JetBrains.ReSharper.Psi.Html.Impl.References.HtmlAttributeValueEntry entry);
    }
    public abstract class HtmlAttributeValueReferenceFactoryBase<TData, TDeclaredElementTypes, TProjectFileType> : JetBrains.ReSharper.Psi.Html.Impl.References.HtmlReferenceFactoryBase<TDeclaredElementTypes, TProjectFileType>
    
        where TDeclaredElementTypes : JetBrains.ReSharper.Psi.Html.Html.IHtmlDeclaredElementTypesBase
        where TProjectFileType : JetBrains.ProjectModel.HtmlProjectFileType
    {
        protected HtmlAttributeValueReferenceFactoryBase(TDeclaredElementTypes declaredElementTypes) { }
        protected virtual bool CanHaveReference(JetBrains.ReSharper.Psi.Html.Impl.References.HtmlAttributeValueEntry entry, TData data, System.Collections.Generic.IEnumerable<string> names) { }
        protected abstract JetBrains.ReSharper.Psi.Resolve.IReference[] CreateReferences(JetBrains.ReSharper.Psi.Html.Impl.References.HtmlAttributeValueEntry entry, TData data);
        protected override JetBrains.ReSharper.Psi.Resolve.IReference[] GetReferences(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.Resolve.IReference[] oldReferences) { }
        protected override bool HasReference(JetBrains.ReSharper.Psi.Tree.ITreeNode element, System.Collections.Generic.ICollection<string> names) { }
        public abstract bool IsApplicable(JetBrains.ReSharper.Psi.Html.Impl.References.HtmlAttributeValueEntry entry, out TData data);
    }
    [JetBrains.ReSharper.Psi.Resolve.ReferenceProviderFactoryAttribute()]
    public class HtmlEnumAttributeValueReferenceProvider : JetBrains.ReSharper.Psi.Html.Impl.References.HtmlAttributeValueReferenceFactoryBase<JetBrains.ReSharper.Psi.Html.Html.IHtmlEnumAttributeValueType, JetBrains.ReSharper.Psi.Html.Html.IHtmlDeclaredElementTypes, JetBrains.ProjectModel.HtmlProjectFileType>
    {
        public HtmlEnumAttributeValueReferenceProvider(JetBrains.ReSharper.Psi.Html.Html.IHtmlDeclaredElementTypes declaredElementTypes) { }
        protected override JetBrains.ReSharper.Psi.Resolve.IReference[] CreateReferences(JetBrains.ReSharper.Psi.Html.Impl.References.HtmlAttributeValueEntry entry, JetBrains.ReSharper.Psi.Html.Html.IHtmlEnumAttributeValueType data) { }
        public override bool IsApplicable(JetBrains.ReSharper.Psi.Html.Impl.References.HtmlAttributeValueEntry entry, out JetBrains.ReSharper.Psi.Html.Html.IHtmlEnumAttributeValueType data) { }
        public override bool IsApplicableToFile(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, JetBrains.ReSharper.Psi.Tree.IFile file) { }
    }
    public class HtmlEnumValueReference : JetBrains.ReSharper.Psi.Html.Impl.References.HtmlReferenceWithinElementBase<JetBrains.ReSharper.Psi.Html.Tree.IHtmlAttributeValue>, JetBrains.ReSharper.Psi.Html.References.IHtmlCompleteableReference, JetBrains.ReSharper.Psi.Html.References.IHtmlReferenceWithCustomData, JetBrains.ReSharper.Psi.Html.References.IHtmlSmartCompleteableReference, JetBrains.ReSharper.Psi.Resolve.ICompleteableReference, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.Util.IUserDataHolder
    {
        public HtmlEnumValueReference(JetBrains.ReSharper.Psi.Html.Tree.IHtmlAttributeValue owner, JetBrains.ReSharper.Psi.Html.Tree.IHtmlToken token, JetBrains.ReSharper.Psi.Html.Html.IHtmlEnumAttributeValueType enumType) { }
        public object CustomData { get; }
        public override JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetReferenceSymbolTable(bool useReferenceName) { }
    }
    public class HtmlFileLateBoundReference<TOwner, TToken> : JetBrains.ReSharper.Psi.Html.Impl.References.HtmlFileReference<TOwner, TToken>, JetBrains.ReSharper.Psi.Resolve.ILateBoundReference, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.Util.IUserDataHolder
        where TOwner : JetBrains.ReSharper.Psi.Tree.ITreeNode
        where TToken :  class, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        public HtmlFileLateBoundReference(TOwner owner, JetBrains.ReSharper.Psi.Resolve.IQualifier qualifier, TToken token, JetBrains.ReSharper.Psi.TreeTextRange rangeWithin) { }
        public virtual JetBrains.ReSharper.Psi.Resolve.Refers RefersToDeclaredElement(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
        public override JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.ResolveResultWithInfo Resolve(JetBrains.ReSharper.Psi.Resolve.ISymbolTable symbolTable, JetBrains.ReSharper.Psi.Resolve.IAccessContext context) { }
    }
    public abstract class HtmlFileReference<TOwner, TToken> : JetBrains.ReSharper.Psi.Html.Impl.References.HtmlPathReferenceBase<TOwner, TToken>, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IQualifiableReferenceBase, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IQualifiableReferenceWithGlobalSymbolTable, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IReferenceWithGlobalSymbolTable, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IReferenceWithQualifier, JetBrains.ReSharper.Psi.Html.References.IHtmlCompleteableReference, JetBrains.ReSharper.Psi.Html.References.IHtmlImportCompleteableReference, JetBrains.ReSharper.Psi.Resolve.ICompleteableReference, JetBrains.ReSharper.Psi.Resolve.IFileReference, JetBrains.ReSharper.Psi.Resolve.IPathReference, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.Util.IUserDataHolder
        where TOwner : JetBrains.ReSharper.Psi.Tree.ITreeNode
        where TToken :  class, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        protected HtmlFileReference(TOwner owner, JetBrains.ReSharper.Psi.Resolve.IQualifier qualifier, TToken token, JetBrains.ReSharper.Psi.TreeTextRange rangeWithin, bool allowEmptyName = False) { }
        protected HtmlFileReference(TOwner owner, JetBrains.ReSharper.Psi.Resolve.IQualifier qualifier, TToken token, JetBrains.ReSharper.Psi.TreeTextRange rangeWithin, JetBrains.ProjectModel.ProjectFileType expectedFileType, [JetBrains.Annotations.CanBeNullAttribute()] System.Collections.Generic.ICollection<string> expectedExtensions, bool noCircular, bool allowEmptyName = False) { }
        public override bool AllowEmptyName { get; }
        public System.Collections.Generic.ICollection<string> ExpectedExtensions { get; set; }
        public JetBrains.ProjectModel.ProjectFileType ExpectedFileType { get; set; }
        protected override JetBrains.ReSharper.Psi.Resolve.ISymbolFilter[] GetCompletionFilters() { }
        public override JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetReferenceSymbolTable(bool useReferenceName) { }
        public override JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetSmartCompletionSymbolTable() { }
        protected override JetBrains.ReSharper.Psi.Resolve.ISymbolFilter[] GetSmartSymbolFilters() { }
    }
    public class HtmlFolderLateBoundReference<TOwner, TToken> : JetBrains.ReSharper.Psi.Html.Impl.References.HtmlFolderReference<TOwner, TToken>, JetBrains.ReSharper.Psi.Resolve.ILateBoundReference, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.Util.IUserDataHolder
        where TOwner : JetBrains.ReSharper.Psi.Tree.ITreeNode
        where TToken :  class, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        public HtmlFolderLateBoundReference(TOwner owner, JetBrains.ReSharper.Psi.Resolve.IQualifier qualifier, TToken token, JetBrains.ReSharper.Psi.TreeTextRange rangeWithin) { }
        protected bool CanReferByName(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
        public virtual JetBrains.ReSharper.Psi.Resolve.Refers RefersToDeclaredElement(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
        public override JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.ResolveResultWithInfo Resolve(JetBrains.ReSharper.Psi.Resolve.ISymbolTable symbolTable, JetBrains.ReSharper.Psi.Resolve.IAccessContext context) { }
    }
    public abstract class HtmlFolderReference<TOwner, TToken> : JetBrains.ReSharper.Psi.Html.Impl.References.HtmlPathReferenceBase<TOwner, TToken>, JetBrains.ReSharper.Psi.Resolve.IQualifier
        where TOwner : JetBrains.ReSharper.Psi.Tree.ITreeNode
        where TToken :  class, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        protected HtmlFolderReference(TOwner owner, JetBrains.ReSharper.Psi.Resolve.IQualifier qualifier, TToken token, JetBrains.ReSharper.Psi.TreeTextRange rangeWithin) { }
        public bool Resolved { get; }
        public JetBrains.ReSharper.Psi.Resolve.QualifierKind GetKind() { }
        public override string GetName() { }
        protected override JetBrains.ReSharper.Psi.Resolve.ISymbolFilter[] GetSmartSymbolFilters() { }
        public JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetSymbolTable(JetBrains.ReSharper.Psi.Resolve.SymbolTableMode mode) { }
    }
    [JetBrains.ReSharper.Psi.Resolve.ReferenceProviderFactoryAttribute()]
    public class HtmlForAttributeValueReferenceProvider : JetBrains.ReSharper.Psi.Html.Impl.References.HtmlAttributeValueReferenceFactoryBase<JetBrains.ReSharper.Psi.Html.Html.IHtmlDeclaredElementTypes, JetBrains.ProjectModel.HtmlProjectFileType>
    {
        public HtmlForAttributeValueReferenceProvider(JetBrains.ReSharper.Psi.Html.Html.IHtmlDeclaredElementTypes declaredElementTypes) { }
        protected override JetBrains.ReSharper.Psi.Resolve.IReference[] CreateReferences(JetBrains.ReSharper.Psi.Html.Impl.References.HtmlAttributeValueEntry entry) { }
        public override bool IsApplicable(JetBrains.ReSharper.Psi.Html.Impl.References.HtmlAttributeValueEntry entry) { }
    }
    [JetBrains.ReSharper.Psi.Resolve.ReferenceProviderFactoryAttribute()]
    public class HtmlIdAttributeValueReferenceProvider : JetBrains.ReSharper.Psi.Html.Impl.References.HtmlAttributeValueReferenceFactoryBase<JetBrains.ReSharper.Psi.Html.Html.IHtmlDeclaredElementTypes, JetBrains.ProjectModel.HtmlProjectFileType>
    {
        public HtmlIdAttributeValueReferenceProvider(JetBrains.ReSharper.Psi.Html.Html.IHtmlDeclaredElementTypes declaredElementTypes) { }
        protected override JetBrains.ReSharper.Psi.Resolve.IReference[] CreateReferences(JetBrains.ReSharper.Psi.Html.Impl.References.HtmlAttributeValueEntry entry) { }
        public override bool IsApplicable(JetBrains.ReSharper.Psi.Html.Impl.References.HtmlAttributeValueEntry entry) { }
    }
    public class HtmlIdReference : JetBrains.ReSharper.Psi.Html.Impl.References.HtmlReferenceWithinElementBase<JetBrains.ReSharper.Psi.Html.Tree.IHtmlAttributeValue>, JetBrains.ReSharper.Psi.Html.References.IHtmlCompleteableReference, JetBrains.ReSharper.Psi.Resolve.ICompleteableReference, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.Util.IUserDataHolder
    {
        public HtmlIdReference(JetBrains.ReSharper.Psi.Html.Tree.IHtmlAttributeValue owner, JetBrains.ReSharper.Psi.Html.Tree.IHtmlToken token) { }
        public override JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetReferenceSymbolTable(bool useReferenceName) { }
    }
    public class HtmlObsoleteAttributesFilter : JetBrains.ReSharper.Psi.Resolve.SimpleSymbolFilter
    {
        public HtmlObsoleteAttributesFilter(bool includeObsolete = False, bool includeNonStandart = False) { }
        public override JetBrains.ReSharper.Psi.Resolve.ResolveErrorType ErrorType { get; }
        public override bool Accepts(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.Html.HtmlLanguage))]
    public class HtmlPathBinder : JetBrains.ReSharper.Psi.Web.References.IHtmlPathBinder
    {
        public string GetTargetPath<TOwner, TToken>(JetBrains.ReSharper.Psi.Web.References.PathReferenceBase<TOwner, TToken> reference, JetBrains.ReSharper.Psi.IPathDeclaredElement pathDeclaredElement)
            where TOwner : JetBrains.ReSharper.Psi.Tree.ITreeNode
            where TToken :  class, JetBrains.ReSharper.Psi.Tree.ITreeNode { }
        public JetBrains.ReSharper.Psi.Resolve.IReference SetText<TOwner, TToken>(JetBrains.ReSharper.Psi.Web.References.PathReferenceBase<TOwner, TToken> reference, string newText)
            where TOwner : JetBrains.ReSharper.Psi.Tree.ITreeNode
            where TToken :  class, JetBrains.ReSharper.Psi.Tree.ITreeNode { }
        public JetBrains.ReSharper.Psi.Tree.ITreeNode SetText<TOwner, TToken>(JetBrains.ReSharper.Psi.Web.References.PathReferenceBase<TOwner, TToken> reference, JetBrains.ReSharper.Psi.TreeTextRange range, string newText)
            where TOwner : JetBrains.ReSharper.Psi.Tree.ITreeNode
            where TToken :  class, JetBrains.ReSharper.Psi.Tree.ITreeNode { }
    }
    public abstract class HtmlPathReferenceBase<TOwner, TToken> : JetBrains.ReSharper.Psi.Web.References.PathReferenceBase<TOwner, TToken>, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IQualifiableReferenceBase, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IQualifiableReferenceWithGlobalSymbolTable, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IReferenceWithGlobalSymbolTable, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IReferenceWithQualifier, JetBrains.ReSharper.Psi.Html.References.IHtmlCompleteableReference, JetBrains.ReSharper.Psi.Html.References.IHtmlPathReference, JetBrains.ReSharper.Psi.Html.References.IHtmlSmartCompleteableReference, JetBrains.ReSharper.Psi.Resolve.ICompleteableReference, JetBrains.ReSharper.Psi.Resolve.IPathReference, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.Util.IUserDataHolder
        where TOwner : JetBrains.ReSharper.Psi.Tree.ITreeNode
        where TToken :  class, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        protected HtmlPathReferenceBase(TOwner owner, JetBrains.ReSharper.Psi.Resolve.IQualifier qualifier, TToken token, JetBrains.ReSharper.Psi.TreeTextRange rangeWithin) { }
        protected override JetBrains.ReSharper.Psi.Resolve.IReference BindToInternal(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution) { }
        public virtual bool IsWebRootPathSupported() { }
        public override JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.ResolveResultWithInfo Resolve(JetBrains.ReSharper.Psi.Resolve.ISymbolTable symbolTable, JetBrains.ReSharper.Psi.Resolve.IAccessContext context) { }
    }
    public abstract class HtmlReferenceFactoryBase<TDeclaredElementTypes, TProjectFileType> : JetBrains.ReSharper.Psi.Resolve.StatelessReferenceProviderFactoryBase
        where TDeclaredElementTypes : JetBrains.ReSharper.Psi.Html.Html.IHtmlDeclaredElementTypesBase
        where TProjectFileType : JetBrains.ProjectModel.HtmlProjectFileType
    {
        protected HtmlReferenceFactoryBase(TDeclaredElementTypes declaredElementTypes) { }
        protected TDeclaredElementTypes DeclaredElementTypes { get; }
        public override bool IsApplicableToFile(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, JetBrains.ReSharper.Psi.Tree.IFile file) { }
        protected bool IsApplicableToFileWithOverrides<T>(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, JetBrains.ReSharper.Psi.Tree.IFile file)
            where T :  class { }
        protected static JetBrains.ReSharper.Psi.Resolve.IReference[] SelectOldOrNewReferences(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.Resolve.IReference[] oldReferences, JetBrains.ReSharper.Psi.Resolve.IReference[] references) { }
    }
    public class HtmlReferenceToElementId : JetBrains.ReSharper.Psi.Html.Impl.References.HtmlReferenceWithinElementBase<JetBrains.ReSharper.Psi.Html.Tree.IHtmlAttributeValue>, JetBrains.ReSharper.Psi.Html.References.IHtmlCompleteableReference, JetBrains.ReSharper.Psi.Html.References.IHtmlReferenceToId, JetBrains.ReSharper.Psi.Resolve.ICompleteableReference, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.Util.IUserDataHolder
    {
        public HtmlReferenceToElementId(JetBrains.ReSharper.Psi.Html.Tree.IHtmlAttributeValue owner, JetBrains.ReSharper.Psi.Html.Tree.IHtmlToken token) { }
        public override JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetReferenceSymbolTable(bool useReferenceName) { }
        public override JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.ResolveResultWithInfo ResolveWithoutCache() { }
    }
    public class HtmlReferenceToIdInsidePath : JetBrains.ReSharper.Psi.Impl.Shared.References.QualifiableReferenceWithinElement<JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode, JetBrains.ReSharper.Psi.Html.Tree.IHtmlToken>, JetBrains.ReSharper.Psi.Html.References.IHtmlCompleteableReference, JetBrains.ReSharper.Psi.Html.References.IHtmlReferenceToId, JetBrains.ReSharper.Psi.Resolve.ICompleteableReference, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.Util.IUserDataHolder
    {
        public HtmlReferenceToIdInsidePath(JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode owner, JetBrains.ReSharper.Psi.Resolve.IPathReference pathReference, JetBrains.ReSharper.Psi.Html.Tree.IHtmlToken token, JetBrains.ReSharper.Psi.TreeTextRange rangeWithin) { }
        protected override JetBrains.ReSharper.Psi.Resolve.IReference BindToInternal(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution) { }
        public override JetBrains.ReSharper.Psi.ITypeElement GetQualifierTypeElement() { }
        public override JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.ResolveResultWithInfo GetResolveResult(JetBrains.ReSharper.Psi.Resolve.ISymbolTable symbolTable, string referenceName) { }
        public override JetBrains.ReSharper.Psi.Resolve.Staticness GetStaticness() { }
        public override JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.ResolveResultWithInfo Resolve(JetBrains.ReSharper.Psi.Resolve.ISymbolTable symbolTable, JetBrains.ReSharper.Psi.Resolve.IAccessContext context) { }
    }
    public abstract class HtmlReferenceWithinElementBase<TOwner> : JetBrains.ReSharper.Psi.Impl.Shared.References.ReferenceWithinElementBase<TOwner, JetBrains.ReSharper.Psi.Html.Tree.IHtmlToken>
        where TOwner : JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode
    {
        protected HtmlReferenceWithinElementBase(TOwner owner, JetBrains.ReSharper.Psi.Html.Tree.IHtmlToken token) { }
        protected HtmlReferenceWithinElementBase(TOwner owner, JetBrains.ReSharper.Psi.Html.Tree.IHtmlToken token, JetBrains.ReSharper.Psi.TreeTextRange rangeWithin) { }
        public override bool CaseSensitive { get; }
        protected override JetBrains.ReSharper.Psi.Resolve.IReference BindToInternal(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution) { }
    }
    public class HtmlResolveErrorType : JetBrains.ReSharper.Psi.Web.Resolve.WebResolveErrorType
    {
        public static readonly JetBrains.ReSharper.Psi.Html.Impl.References.HtmlResolveErrorType CANNOT_RESOLVE_ID;
        public static readonly JetBrains.ReSharper.Psi.Html.Impl.References.HtmlResolveErrorType UNKNOWN_HTML_ATTRIBUTE;
        public static readonly JetBrains.ReSharper.Psi.Html.Impl.References.HtmlResolveErrorType UNKNOWN_HTML_EVENT;
        public static readonly JetBrains.ReSharper.Psi.Html.Impl.References.HtmlResolveErrorType UNKNOWN_HTML_TAG;
    }
    [JetBrains.ReSharper.Psi.Resolve.ReferenceProviderFactoryAttribute()]
    public class HtmlUrlAttributeValueReferenceProvider : JetBrains.ReSharper.Psi.Html.Impl.References.HtmlAttributeValueReferenceFactoryBase<JetBrains.ReSharper.Psi.Html.Html.IHtmlDeclaredElementTypes, JetBrains.ProjectModel.HtmlProjectFileType>
    {
        public HtmlUrlAttributeValueReferenceProvider(JetBrains.ReSharper.Psi.Html.Html.IHtmlDeclaredElementTypes declaredElementTypes) { }
        protected override bool CanHaveReference(JetBrains.ReSharper.Psi.Html.Impl.References.HtmlAttributeValueEntry entry, System.Collections.Generic.IEnumerable<string> names) { }
        protected override JetBrains.ReSharper.Psi.Resolve.IReference[] CreateReferences(JetBrains.ReSharper.Psi.Html.Impl.References.HtmlAttributeValueEntry entry) { }
        public override bool IsApplicable(JetBrains.ReSharper.Psi.Html.Impl.References.HtmlAttributeValueEntry entry) { }
        public override bool IsApplicableToFile(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, JetBrains.ReSharper.Psi.Tree.IFile file) { }
    }
    public interface IHtmlEnumReferenceProviderOverride { }
    public interface IHtmlUrlReferenceProviderOverride { }
    public interface IQualifierReference : JetBrains.ReSharper.Psi.Resolve.IQualifier, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.Util.IUserDataHolder { }
}
namespace JetBrains.ReSharper.Psi.Html.Impl.Searching
{
    
    [JetBrains.ReSharper.Psi.PsiSharedComponentAttribute()]
    public class HtmlSearcherFactory : JetBrains.ReSharper.Psi.ExtensionsAPI.IDomainSpecificSearcherFactory
    {
        public HtmlSearcherFactory(JetBrains.ReSharper.Psi.Search.SearchDomainFactory searchDomainFactory) { }
        public JetBrains.ReSharper.Psi.ExtensionsAPI.IDomainSpecificSearcher CreateAnonymousTypeSearcher(System.Collections.Generic.IList<JetBrains.ReSharper.Psi.AnonymousTypeDescriptor> typeDescription, bool caseSensitive) { }
        public JetBrains.ReSharper.Psi.ExtensionsAPI.IDomainSpecificSearcher CreateConstantExpressionSearcher(JetBrains.ReSharper.Psi.ConstantValue constantValue, bool onlyLiteralExpression) { }
        public JetBrains.ReSharper.Psi.ExtensionsAPI.IDomainSpecificSearcher CreateConstructorSpecialReferenceSearcher(System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.IConstructor> constructors) { }
        public JetBrains.ReSharper.Psi.ExtensionsAPI.IDomainSpecificSearcher CreateLateBoundReferenceSearcher(System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.IDeclaredElement> elements) { }
        public JetBrains.ReSharper.Psi.ExtensionsAPI.IDomainSpecificSearcher CreateMethodsReferencedByDelegateSearcher(JetBrains.ReSharper.Psi.IDelegate @delegate) { }
        public JetBrains.ReSharper.Psi.ExtensionsAPI.IDomainSpecificSearcher CreateReferenceSearcher(System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.IDeclaredElement> elements, bool findCandidates) { }
        public JetBrains.ReSharper.Psi.ExtensionsAPI.IDomainSpecificSearcher CreateTextOccurenceSearcher(System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.IDeclaredElement> elements) { }
        public JetBrains.ReSharper.Psi.ExtensionsAPI.IDomainSpecificSearcher CreateTextOccurenceSearcher(string subject) { }
        public System.Collections.Generic.IEnumerable<string> GetAllPossibleWordsInFile(JetBrains.ReSharper.Psi.IDeclaredElement element) { }
        public JetBrains.ReSharper.Psi.Search.ISearchDomain GetDeclaredElementSearchDomain(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
        public JetBrains.Util.JetTuple<System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.IDeclaredElement>, System.Predicate<JetBrains.ReSharper.Psi.Search.IFindResultReference>, bool> GetDerivedFindRequest(JetBrains.ReSharper.Psi.Search.IFindResultReference result) { }
        public JetBrains.Util.JetTuple<System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.IDeclaredElement>, bool> GetNavigateToTargets(JetBrains.ReSharper.Psi.IDeclaredElement element) { }
        public System.Collections.Generic.IEnumerable<JetBrains.Util.Pair<JetBrains.ReSharper.Psi.IDeclaredElement, System.Predicate<JetBrains.ReSharper.Psi.Search.FindResult>>> GetRelatedDeclaredElements(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
        public bool IsCompatibleWithLanguage(JetBrains.ReSharper.Psi.PsiLanguageType languageType) { }
        public System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.Search.FindResult> TransformNavigationTargets(System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.Search.FindResult> targets) { }
    }
}
namespace JetBrains.ReSharper.Psi.Html.Impl.Symbols
{
    
    public abstract class HtmlTagIdSymbolsProviderBase<T> : JetBrains.ReSharper.Psi.Web.Impl.Symbols.WebSymbolsSimpleProviderBase<T>
        where T :  class, JetBrains.ReSharper.Psi.Web.Symbols.IWebSymbol
    {
        public override bool IsEnabled { get; }
        protected virtual void CollectSymbol(JetBrains.ReSharper.Psi.Html.Tree.ITagAttribute attribute, JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.Web.Symbols.IWebSymbol> symbols) { }
        protected abstract T CollectTagIdSymbol(string name, int offset, JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile);
        protected override JetBrains.ReSharper.Psi.IRecursiveElementProcessor CreateProcessor(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, System.Collections.Generic.List<JetBrains.ReSharper.Psi.Web.Symbols.IWebSymbol> symbols) { }
        protected override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Tree.IFile> GetPsiFiles(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
        protected abstract class HtmlTagIdSymbolBase<T> : JetBrains.ReSharper.Psi.Web.Impl.Symbols.WebTagIdSymbol
            where T :  class, JetBrains.ReSharper.Psi.Web.Symbols.IWebSymbol
        {
            protected HtmlTagIdSymbolBase(string name, int offset, JetBrains.ReSharper.Psi.IPsiSourceFile file, JetBrains.ReSharper.Psi.Web.Symbols.WebVisibilityScope declarationPlace) { }
            public override JetBrains.ReSharper.Psi.Web.DeclaredElements.IHtmlTagIdDeclaredElement GetDeclaredElement() { }
        }
    }
}
namespace JetBrains.ReSharper.Psi.Html.Impl.TagPrefixes
{
    
    public class HtmlDeclaredElementPresenter : JetBrains.ReSharper.Psi.Web.Impl.WebDeclaredElementPresenter
    {
        public static readonly JetBrains.ReSharper.Psi.Html.Impl.TagPrefixes.HtmlDeclaredElementPresenter Instance;
    }
    public class HtmlDeclaredElementType : JetBrains.ReSharper.Psi.Web.Impl.WebDeclaredElementType
    {
        public static readonly JetBrains.ReSharper.Psi.DeclaredElementType ASP_TAG_NAME;
        public static readonly JetBrains.ReSharper.Psi.DeclaredElementType ASP_TAG_PREFIX;
        public static readonly JetBrains.ReSharper.Psi.DeclaredElementType HTML_ATTRIBUTE;
        public static readonly JetBrains.ReSharper.Psi.DeclaredElementType HTML_EVENT;
        public static readonly JetBrains.ReSharper.Psi.DeclaredElementType HTML_TAG;
        public static readonly JetBrains.ReSharper.Psi.DeclaredElementType HTML_TAG_ID;
        public static readonly JetBrains.ReSharper.Psi.DeclaredElementType XMLNS;
        protected HtmlDeclaredElementType(string name, JetBrains.UI.Icons.IconId imageName) { }
        protected override JetBrains.ReSharper.Psi.IDeclaredElementPresenter DefaultPresenter { get; }
        public override bool IsPresentable(JetBrains.ReSharper.Psi.PsiLanguageType language) { }
    }
}
namespace JetBrains.ReSharper.Psi.Html.Impl.Tree
{
    
    public class HtmlAttributeName : JetBrains.ReSharper.Psi.Html.Impl.Tree.HtmlCompositeElement, JetBrains.ReSharper.Psi.Html.Tree.IHtmlAttributeName, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode
    {
        public HtmlAttributeName(JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType nodeType, JetBrains.ReSharper.Psi.Html.Parsing.IHtmlTokenNodeTypes tokenTypes) { }
        public string Name { get; }
        public JetBrains.ReSharper.Psi.Html.Tree.IHtmlToken NameToken { get; }
        public override TReturn AcceptVisitor<TContext, TReturn>(JetBrains.ReSharper.Psi.Html.Tree.HtmlTreeVisitor<TContext, TReturn> visitor, TContext context) { }
    }
    public class HtmlAttributeValue : JetBrains.ReSharper.Psi.Html.Impl.Tree.HtmlCompositeElement, JetBrains.ReSharper.Psi.Html.Tree.IHtmlAttributeValue, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode
    {
        public HtmlAttributeValue(JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType nodeType, JetBrains.ReSharper.Psi.Html.Parsing.IHtmlTokenNodeTypes tokenTypes) { }
        public JetBrains.ReSharper.Psi.Html.Tree.IHtmlToken LeadingQuote { get; }
        public JetBrains.ReSharper.Psi.Html.Tree.IHtmlToken TrailingQuote { get; }
        public string UnquotedValue { get; }
        public string UnquotedValueWithEmbeds { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode> ValueElements { get; }
        public virtual JetBrains.ReSharper.Psi.Html.Tree.IHtmlToken ValueToken { get; }
        public override TReturn AcceptVisitor<TContext, TReturn>(JetBrains.ReSharper.Psi.Html.Tree.HtmlTreeVisitor<TContext, TReturn> visitor, TContext context) { }
        protected override JetBrains.ReSharper.Psi.Tree.ReferenceCollection CreateFirstClassReferences() { }
        public override short GetChildRole(JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.TreeElement child) { }
    }
    public class HtmlCData : JetBrains.ReSharper.Psi.Html.Impl.Tree.HtmlTagContainer, JetBrains.ReSharper.Psi.Html.Tree.IHtmlCData, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTagContainer, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTagContainerMarker, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode
    {
        public HtmlCData(JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType nodeType, JetBrains.ReSharper.Psi.Html.Parsing.IHtmlTokenNodeTypes tokenTypes) { }
        protected override JetBrains.ReSharper.Psi.Tree.ITreeNode EndAnchor { get; }
        protected override JetBrains.ReSharper.Psi.Tree.ITreeNode StartAnchor { get; }
        public override TReturn AcceptVisitor<TContext, TReturn>(JetBrains.ReSharper.Psi.Html.Tree.HtmlTreeVisitor<TContext, TReturn> visitor, TContext context) { }
        public override short GetChildRole(JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.TreeElement child) { }
    }
    public class HtmlChildRole
    {
        public const short ATTRIBUTE = 5;
        public const short ATTRIBUTE_EQ = 12;
        public const short ATTRIBUTE_NAME = 6;
        public const short ATTRIBUTE_VALUE = 7;
        public const short CODE_BLOCK = 8;
        public const short COMMENT_TEXT = 9;
        public const short HTML_CDATA = 19;
        public const short HTML_CDATA_END = 21;
        public const short HTML_CDATA_START = 20;
        public const short HTML_COMMENT = 14;
        public const short HTML_COMMENT_END = 16;
        public const short HTML_COMMENT_START = 15;
        public const short HTML_CONDITIONAL_BINARY_OP = 156;
        public const short HTML_CONDITIONAL_COMMENT = 13;
        public const short HTML_CONDITIONAL_END = 163;
        public const short HTML_CONDITIONAL_ENDIF_BLOCK = 152;
        public const short HTML_CONDITIONAL_ENDIF_KEYWORD = 154;
        public const short HTML_CONDITIONAL_EXPRESSION = 159;
        public const short HTML_CONDITIONAL_IDENTIFIER = 160;
        public const short HTML_CONDITIONAL_IF_BLOCK = 151;
        public const short HTML_CONDITIONAL_IF_KEYWORD = 153;
        public const short HTML_CONDITIONAL_LPARENTH = 157;
        public const short HTML_CONDITIONAL_RPARENTH = 158;
        public const short HTML_CONDITIONAL_START = 162;
        public const short HTML_CONDITIONAL_UNARY_OP = 155;
        public const short HTML_CONDITIONAL_VALUE = 161;
        public const short HTML_DOCTYPE = 23;
        public const short HTML_DOCTYPE_ATTRIBUTE = 25;
        public const short HTML_DOCTYPE_START = 24;
        public const short HTML_HEADER_END = 112;
        public const short HTML_HEADER_NAME = 111;
        public const short HTML_HEADER_START = 110;
        public const short HTML_INCLUDE_END = 102;
        public const short HTML_INCLUDE_FILE_NAME = 101;
        public const short HTML_INCLUDE_START = 100;
        public const short HTML_LAST_CHILD_ROLE = 163;
        public const short HTML_TAG = 3;
        public const short HTML_TAG_END = 121;
        public const short HTML_TAG_FOOTER = 18;
        public const short HTML_TAG_HEADER = 17;
        public const short HTML_TAG_START = 120;
        public const short NAME = 4;
        public const short NONE = 0;
        public const short PI_END = 131;
        public const short PI_START = 130;
        public const short STYLE_BLOCK = 22;
    }
    public class HtmlComment : JetBrains.ReSharper.Psi.Html.Impl.Tree.HtmlTagContainer, JetBrains.ReSharper.Psi.Html.Tree.IHtmlComment, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTagContainer, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTagContainerMarker, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode, JetBrains.ReSharper.Psi.Html.Tree.IWebComment, JetBrains.ReSharper.Psi.Tree.IComment, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode
    {
        public HtmlComment(JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType nodeType, JetBrains.ReSharper.Psi.Html.Parsing.IHtmlTokenNodeTypes tokenTypes) { }
        public string CommentText { get; }
        protected override JetBrains.ReSharper.Psi.Tree.ITreeNode EndAnchor { get; }
        protected override JetBrains.ReSharper.Psi.Tree.ITreeNode StartAnchor { get; }
        public override TReturn AcceptVisitor<TContext, TReturn>(JetBrains.ReSharper.Psi.Html.Tree.HtmlTreeVisitor<TContext, TReturn> visitor, TContext context) { }
        public override short GetChildRole(JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.TreeElement child) { }
        public JetBrains.ReSharper.Psi.TreeTextRange GetCommentRange() { }
    }
    public abstract class HtmlCompositeElement : JetBrains.ReSharper.Psi.Impl.Shared.Tree.CompositeElementWithReferences, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode
    {
        protected JetBrains.ReSharper.Psi.Html.Parsing.IHtmlTokenNodeTypes myTokenTypes;
        protected HtmlCompositeElement([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType nodeType, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Html.Parsing.IHtmlTokenNodeTypes tokenTypes) { }
        public override JetBrains.ReSharper.Psi.PsiLanguageType Language { get; }
        public override JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType NodeType { get; }
        public JetBrains.ReSharper.Psi.Html.Parsing.IHtmlTokenNodeTypes TokenTypes { get; }
        public abstract TReturn AcceptVisitor<TContext, TReturn>(JetBrains.ReSharper.Psi.Html.Tree.HtmlTreeVisitor<TContext, TReturn> visitor, TContext context);
        protected JetBrains.ReSharper.Psi.Html.Parsing.IWebTreeBuilder CreateTreeBuilder() { }
        protected override JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.TreeElement DeepClone(JetBrains.ReSharper.Psi.Impl.TreeNodeCopyContext context) { }
        public System.Collections.ArrayList FindDescendantsByRole(short childRole) { }
        public override short GetChildRole(JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.TreeElement child) { }
    }
    public class HtmlConditionalBinaryExpression : JetBrains.ReSharper.Psi.Html.Impl.Tree.HtmlConditionalExpression, JetBrains.ReSharper.Psi.Html.Tree.IHtmlConditionalBinaryExpression, JetBrains.ReSharper.Psi.Html.Tree.IHtmlConditionalExpression, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode
    {
        public HtmlConditionalBinaryExpression(JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType nodeType, JetBrains.ReSharper.Psi.Html.Parsing.IHtmlTokenNodeTypes tokenTypes) { }
        public JetBrains.ReSharper.Psi.Html.Tree.IHtmlToken BinaryOp { get; }
        public JetBrains.ReSharper.Psi.Html.Tree.IHtmlConditionalExpression LeftExpression { get; }
        public JetBrains.ReSharper.Psi.Html.Tree.IHtmlConditionalExpression RightExpression { get; }
        public override short GetChildRole(JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.TreeElement child) { }
    }
    public class HtmlConditionalComment : JetBrains.ReSharper.Psi.Html.Impl.Tree.HtmlTagContainer, JetBrains.ReSharper.Psi.Html.Tree.IHtmlConditionalComment, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTagContainer, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTagContainerMarker, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode, JetBrains.ReSharper.Psi.Html.Tree.IWebComment, JetBrains.ReSharper.Psi.Tree.IComment, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode
    {
        public HtmlConditionalComment(JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType nodeType, JetBrains.ReSharper.Psi.Html.Parsing.IHtmlTokenNodeTypes tokenTypes) { }
        public string CommentText { get; }
        protected override JetBrains.ReSharper.Psi.Tree.ITreeNode EndAnchor { get; }
        public JetBrains.ReSharper.Psi.Html.Tree.IHtmlConditionalEndIf EndIf { get; }
        public JetBrains.ReSharper.Psi.Html.Tree.IHtmlConditionalIf If { get; }
        protected override JetBrains.ReSharper.Psi.Tree.ITreeNode StartAnchor { get; }
        public override TReturn AcceptVisitor<TContext, TReturn>(JetBrains.ReSharper.Psi.Html.Tree.HtmlTreeVisitor<TContext, TReturn> visitor, TContext context) { }
        public override short GetChildRole(JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.TreeElement child) { }
        public JetBrains.ReSharper.Psi.TreeTextRange GetCommentRange() { }
    }
    public class HtmlConditionalConstantExpression : JetBrains.ReSharper.Psi.Html.Impl.Tree.HtmlConditionalExpression, JetBrains.ReSharper.Psi.Html.Tree.IHtmlConditionalConstantExpression, JetBrains.ReSharper.Psi.Html.Tree.IHtmlConditionalExpression, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode
    {
        public HtmlConditionalConstantExpression(JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType nodeType, JetBrains.ReSharper.Psi.Html.Parsing.IHtmlTokenNodeTypes tokenTypes) { }
        public JetBrains.ReSharper.Psi.Html.Tree.IHtmlToken ConstantNode { get; }
    }
    public class HtmlConditionalEndIf : JetBrains.ReSharper.Psi.Html.Impl.Tree.HtmlConditionalStruct, JetBrains.ReSharper.Psi.Html.Tree.IHtmlConditionalEndIf, JetBrains.ReSharper.Psi.Html.Tree.IHtmlConditionalStruct, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode
    {
        public HtmlConditionalEndIf(JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType nodeType, JetBrains.ReSharper.Psi.Html.Parsing.IHtmlTokenNodeTypes tokenTypes) { }
        public JetBrains.ReSharper.Psi.Html.Tree.IHtmlToken EndIfToken { get; }
        public override short GetChildRole(JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.TreeElement child) { }
    }
    public class HtmlConditionalExistOrEqualExpression : JetBrains.ReSharper.Psi.Html.Impl.Tree.HtmlConditionalExpression, JetBrains.ReSharper.Psi.Html.Tree.IHtmlConditionalExistOrEqualExpression, JetBrains.ReSharper.Psi.Html.Tree.IHtmlConditionalExpression, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode
    {
        public HtmlConditionalExistOrEqualExpression(JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType nodeType, JetBrains.ReSharper.Psi.Html.Parsing.IHtmlTokenNodeTypes tokenTypes) { }
        public JetBrains.ReSharper.Psi.Html.Tree.IHtmlToken Identifier { get; }
        public JetBrains.ReSharper.Psi.Html.Tree.IHtmlConditionalExpression RightExpression { get; }
        public override short GetChildRole(JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.TreeElement child) { }
    }
    public class HtmlConditionalExpression : JetBrains.ReSharper.Psi.Html.Impl.Tree.HtmlCompositeElement, JetBrains.ReSharper.Psi.Html.Tree.IHtmlConditionalExpression, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode
    {
        public HtmlConditionalExpression(JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType nodeType, JetBrains.ReSharper.Psi.Html.Parsing.IHtmlTokenNodeTypes tokenTypes) { }
        public override TReturn AcceptVisitor<TContext, TReturn>(JetBrains.ReSharper.Psi.Html.Tree.HtmlTreeVisitor<TContext, TReturn> visitor, TContext context) { }
    }
    public class HtmlConditionalIf : JetBrains.ReSharper.Psi.Html.Impl.Tree.HtmlConditionalStruct, JetBrains.ReSharper.Psi.Html.Tree.IHtmlConditionalIf, JetBrains.ReSharper.Psi.Html.Tree.IHtmlConditionalStruct, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode
    {
        public HtmlConditionalIf(JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType nodeType, JetBrains.ReSharper.Psi.Html.Parsing.IHtmlTokenNodeTypes tokenTypes) { }
        public JetBrains.ReSharper.Psi.Html.Tree.IHtmlConditionalExpression ConditionalExpression { get; }
        public JetBrains.ReSharper.Psi.Html.Tree.IHtmlToken IfToken { get; }
        public override short GetChildRole(JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.TreeElement child) { }
    }
    public class HtmlConditionalParenthisizedExpression : JetBrains.ReSharper.Psi.Html.Impl.Tree.HtmlConditionalExpression, JetBrains.ReSharper.Psi.Html.Tree.IHtmlConditionalExpression, JetBrains.ReSharper.Psi.Html.Tree.IHtmlConditionalParenthesizedExpresion, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode
    {
        public HtmlConditionalParenthisizedExpression(JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType nodeType, JetBrains.ReSharper.Psi.Html.Parsing.IHtmlTokenNodeTypes tokenTypes) { }
        public JetBrains.ReSharper.Psi.Html.Tree.IHtmlConditionalExpression Expression { get; }
        public JetBrains.ReSharper.Psi.Html.Tree.IHtmlToken LParenth { get; }
        public JetBrains.ReSharper.Psi.Html.Tree.IHtmlToken RParenth { get; }
        public override short GetChildRole(JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.TreeElement child) { }
    }
    public abstract class HtmlConditionalStruct : JetBrains.ReSharper.Psi.Html.Impl.Tree.HtmlCompositeElement, JetBrains.ReSharper.Psi.Html.Tree.IHtmlConditionalStruct, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode
    {
        protected HtmlConditionalStruct(JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType nodeType, JetBrains.ReSharper.Psi.Html.Parsing.IHtmlTokenNodeTypes tokenTypes) { }
        public JetBrains.ReSharper.Psi.Html.Tree.IHtmlToken EndToken { get; }
        public JetBrains.ReSharper.Psi.Html.Tree.IHtmlToken StartToken { get; }
        public override TReturn AcceptVisitor<TContext, TReturn>(JetBrains.ReSharper.Psi.Html.Tree.HtmlTreeVisitor<TContext, TReturn> visitor, TContext context) { }
        public override short GetChildRole(JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.TreeElement child) { }
    }
    public class HtmlConditionalUnaryExpression : JetBrains.ReSharper.Psi.Html.Impl.Tree.HtmlConditionalExpression, JetBrains.ReSharper.Psi.Html.Tree.IHtmlConditionalExpression, JetBrains.ReSharper.Psi.Html.Tree.IHtmlConditionalUnaryExpression, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode
    {
        public HtmlConditionalUnaryExpression(JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType nodeType, JetBrains.ReSharper.Psi.Html.Parsing.IHtmlTokenNodeTypes tokenTypes) { }
        public JetBrains.ReSharper.Psi.Html.Tree.IHtmlConditionalExpression Expression { get; }
        public JetBrains.ReSharper.Psi.Html.Tree.IHtmlToken UnaryOp { get; }
        public override short GetChildRole(JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.TreeElement child) { }
    }
    public class HtmlDocType : JetBrains.ReSharper.Psi.Html.Impl.Tree.HtmlCompositeElement, JetBrains.ReSharper.Psi.Html.Tree.IHtmlDocType, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode
    {
        public HtmlDocType(JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType nodeType, JetBrains.ReSharper.Psi.Html.Parsing.IHtmlTokenNodeTypes tokenTypes) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Html.Tree.IHtmlAttributeValue> Attributes { get; }
        public JetBrains.ReSharper.Psi.Html.Tree.IHtmlToken EndToken { get; }
        public string Root { get; }
        public JetBrains.ReSharper.Psi.Html.Tree.IHtmlToken StartToken { get; }
        public override TReturn AcceptVisitor<TContext, TReturn>(JetBrains.ReSharper.Psi.Html.Tree.HtmlTreeVisitor<TContext, TReturn> visitor, TContext context) { }
        public override short GetChildRole(JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.TreeElement child) { }
    }
    public class HtmlDocumentRangeTranslator : JetBrains.ReSharper.Psi.Files.IDocumentRangeTranslator
    {
        public HtmlDocumentRangeTranslator(JetBrains.ReSharper.Psi.Html.Tree.IHtmlFile htmlFile, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Html.Tree.IHtmlIncludeEntry> entries) { }
        public JetBrains.DocumentModel.DocumentRange Translate(JetBrains.ReSharper.Psi.TreeTextRange range) { }
        public JetBrains.ReSharper.Psi.TreeTextRange Translate(JetBrains.DocumentModel.DocumentRange documentRange) { }
    }
    public class HtmlErrorElement : JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.ErrorElement, JetBrains.ReSharper.Psi.Html.Tree.IHtmlErrorElement, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode
    {
        public HtmlErrorElement([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType nodeType, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Html.Parsing.IHtmlTokenNodeTypes tokenTypes, string errorDescription) { }
        public override JetBrains.ReSharper.Psi.PsiLanguageType Language { get; }
        public override JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType NodeType { get; }
        public JetBrains.ReSharper.Psi.Html.Parsing.IHtmlTokenNodeTypes TokenTypes { get; }
        public TReturn AcceptVisitor<TContext, TReturn>(JetBrains.ReSharper.Psi.Html.Tree.HtmlTreeVisitor<TContext, TReturn> visitor, TContext context) { }
        protected override JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.TreeElement DeepClone(JetBrains.ReSharper.Psi.Impl.TreeNodeCopyContext context) { }
    }
    public class HtmlFile : JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.FileElementBase, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IScope, JetBrains.ReSharper.Psi.Html.Impl.Tree.ISpecialReparse, JetBrains.ReSharper.Psi.Html.Tree.IHtmlFile, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTagContainer, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTagContainerMarker, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode, JetBrains.ReSharper.Psi.Tree.IFile, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebFile, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode
    {
        public HtmlFile(JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType nodeType, JetBrains.ReSharper.Psi.Html.Parsing.IHtmlTokenNodeTypes tokenTypes) { }
        protected JetBrains.ReSharper.Psi.Html.Impl.Tree.HtmlFileData Data { get; }
        public JetBrains.ReSharper.Psi.Html.Tree.IHtmlDocType DocType { get; }
        public JetBrains.Util.OneToSetMap<JetBrains.Util.FileSystemPath, JetBrains.Util.FileSystemPath> ImmediateIncludes { get; }
        public override JetBrains.ReSharper.Psi.PsiLanguageType Language { get; }
        public int LevelDelta { get; }
        public override JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType NodeType { get; }
        public System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.Html.Tree.IHtmlPi> ProcessingInstructions { get; }
        public JetBrains.ReSharper.Psi.Html.Parsing.IHtmlTokenNodeTypes TokenTypes { get; }
        public TReturn AcceptVisitor<TContext, TReturn>(JetBrains.ReSharper.Psi.Html.Tree.HtmlTreeVisitor<TContext, TReturn> visitor, TContext context) { }
        public virtual JetBrains.ReSharper.Psi.Resolve.ISymbolTable AddGlobalDeclarations(JetBrains.ReSharper.Psi.Resolve.ISymbolTable parentTable, int level, JetBrains.ReSharper.Psi.Resolve.SymbolTableMode mode) { }
        public T AddTagAfter<T>(T tag, JetBrains.ReSharper.Psi.Tree.ITreeNode anchor)
            where T :  class, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTagContainer { }
        public T AddTagBefore<T>(T tag, JetBrains.ReSharper.Psi.Tree.ITreeNode anchor)
            where T :  class, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTagContainer { }
        protected virtual JetBrains.ReSharper.Psi.Html.Impl.Tree.HtmlFileData CreateData(JetBrains.ReSharper.Psi.Tree.IFile file) { }
        protected override JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.TreeElement DeepClone(JetBrains.ReSharper.Psi.Impl.TreeNodeCopyContext context) { }
        public JetBrains.ReSharper.Psi.ITreeRange GetBodyRange() { }
        public override short GetChildRole(JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.TreeElement child) { }
        public System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.Html.Tree.IHtmlTagContainer> GetInnerTagContainers() { }
        protected virtual JetBrains.ReSharper.Psi.Parsing.TokenNodeType GetReparsableNodeType(JetBrains.ReSharper.Psi.Tree.ITreeNode node) { }
        protected virtual JetBrains.ReSharper.Psi.Parsing.TokenNodeType GetReparsableNodeTypeByParent(JetBrains.ReSharper.Psi.Tree.ITreeNode node) { }
        protected virtual JetBrains.Util.Pair<JetBrains.ReSharper.Psi.Tree.ITreeNode, bool> GetTagAnchor([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode anchor, bool after) { }
        public System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.Html.Tree.IHtmlTag> GetTags() { }
        public void Initialize([JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.OneToSetMap<JetBrains.Util.FileSystemPath, JetBrains.Util.FileSystemPath> immediateIncludes) { }
        protected virtual bool NearbyLexemsShouldBeCombined(JetBrains.ReSharper.Psi.Parsing.TokenNodeType nodeType) { }
        public void RemoveTag<T>(T tag)
            where T :  class, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTagContainer { }
        public override JetBrains.ReSharper.Psi.Tree.IFile ReParse(JetBrains.ReSharper.Psi.TreeTextRange modifiedRange, string text) { }
        public JetBrains.ReSharper.Psi.Tree.IFile ReParseGeneratedFile(JetBrains.ReSharper.Psi.TreeTextRange modifiedRange, string text) { }
        public override void SubTreeChanged(JetBrains.ReSharper.Psi.Tree.ITreeNode elementContainingChanges, JetBrains.ReSharper.Psi.PsiChangedElementType changeType) { }
        public bool TrySpecialReparse(JetBrains.ReSharper.Psi.TreeTextRange modifiedRange, string text) { }
    }
    public class HtmlFileData
    {
        public HtmlFileData(JetBrains.ReSharper.Psi.Tree.ITreeNode node) { }
        public System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.Html.Tree.IHtmlDocType> DocTypes { get; }
        public System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.Html.Tree.IHtmlPi> ProcessingInstructions { get; }
        protected virtual bool InteriorShouldBeProcessed(JetBrains.ReSharper.Psi.Tree.ITreeNode node) { }
        public void OnSubtreeChanged(JetBrains.ReSharper.Psi.Tree.ITreeNode nodeContainingChanges, JetBrains.ReSharper.Psi.PsiChangedElementType changeType) { }
        protected virtual bool ProcessNode(JetBrains.ReSharper.Psi.Tree.ITreeNode node) { }
        protected virtual void RemoveDeadElements() { }
        protected static void RemoveDeadElements<T>(System.Collections.Generic.IList<T> elements)
            where T : JetBrains.ReSharper.Psi.Tree.ITreeNode { }
        protected virtual void SortElements() { }
        protected static void SortElements<T>(JetBrains.Util.OrderedHashSet<T> elements)
            where T : JetBrains.ReSharper.Psi.Tree.ITreeNode { }
    }
    public class HtmlHeader : JetBrains.ReSharper.Psi.Html.Impl.Tree.HtmlCompositeElement, JetBrains.ReSharper.Psi.Html.Tree.IHtmlHeader, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode
    {
        public HtmlHeader(JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType nodeType, JetBrains.ReSharper.Psi.Html.Parsing.IHtmlTokenNodeTypes tokenTypes) { }
        public JetBrains.ReSharper.Psi.Html.Tree.IHtmlToken EndToken { get; }
        public string Name { get; }
        public JetBrains.ReSharper.Psi.Html.Tree.IHtmlToken NameToken { get; }
        public JetBrains.ReSharper.Psi.Html.Tree.IHtmlToken StartToken { get; }
        public override TReturn AcceptVisitor<TContext, TReturn>(JetBrains.ReSharper.Psi.Html.Tree.HtmlTreeVisitor<TContext, TReturn> visitor, TContext context) { }
        public override short GetChildRole(JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.TreeElement child) { }
    }
    public class HtmlInclude : JetBrains.ReSharper.Psi.Html.Impl.Tree.HtmlCompositeElement, JetBrains.ReSharper.Psi.Html.Tree.IHtmlInclude, JetBrains.ReSharper.Psi.Html.Tree.IHtmlIncludeEntry, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode
    {
        public HtmlInclude(JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType nodeType, JetBrains.ReSharper.Psi.Html.Parsing.IHtmlTokenNodeTypes tokenTypes) { }
        public JetBrains.ReSharper.Psi.Html.Tree.IHtmlToken FilenameToken { get; }
        public JetBrains.ReSharper.Psi.Html.Tree.IHtmlIncludeEnd IncludeEnd { get; set; }
        public bool IsVirtual { get; }
        public string ReferencedString { get; }
        public JetBrains.Util.FileSystemPath ResolvedPath { get; set; }
        public override TReturn AcceptVisitor<TContext, TReturn>(JetBrains.ReSharper.Psi.Html.Tree.HtmlTreeVisitor<TContext, TReturn> visitor, TContext context) { }
        public override short GetChildRole(JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.TreeElement child) { }
    }
    public class HtmlIncludeEnd : JetBrains.ReSharper.Psi.Html.Impl.Tree.HtmlCompositeElement, JetBrains.ReSharper.Psi.Html.Tree.IHtmlIncludeEnd, JetBrains.ReSharper.Psi.Html.Tree.IHtmlIncludeEntry, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode
    {
        public HtmlIncludeEnd(JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType nodeType, JetBrains.ReSharper.Psi.Html.Parsing.IHtmlTokenNodeTypes tokenTypes) { }
        public JetBrains.ReSharper.Psi.Html.Tree.IHtmlInclude IncludeStart { get; set; }
        public override TReturn AcceptVisitor<TContext, TReturn>(JetBrains.ReSharper.Psi.Html.Tree.HtmlTreeVisitor<TContext, TReturn> visitor, TContext context) { }
    }
    public class HtmlPi : JetBrains.ReSharper.Psi.Html.Impl.Tree.HtmlCompositeElement, JetBrains.ReSharper.Psi.Html.Tree.IHtmlPi, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebAttributeContainer<JetBrains.ReSharper.Psi.Html.Tree.IHtmlPiAttribute>, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode
    {
        public HtmlPi(JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType nodeType, JetBrains.ReSharper.Psi.Html.Parsing.IHtmlTokenNodeTypes tokenTypes) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Html.Tree.IHtmlPiAttribute> Attributes { get; }
        public JetBrains.ReSharper.Psi.Html.Tree.IHtmlToken EndToken { get; }
        public string Name { get; }
        public JetBrains.ReSharper.Psi.Html.Tree.IHtmlToken StartToken { get; }
        public override TReturn AcceptVisitor<TContext, TReturn>(JetBrains.ReSharper.Psi.Html.Tree.HtmlTreeVisitor<TContext, TReturn> visitor, TContext context) { }
        public JetBrains.ReSharper.Psi.Html.Tree.IHtmlPiAttribute AddAttributeAfter(JetBrains.ReSharper.Psi.Html.Tree.IHtmlPiAttribute attribute, JetBrains.ReSharper.Psi.Html.Tree.IHtmlPiAttribute anchor = null) { }
        public JetBrains.ReSharper.Psi.Html.Tree.IHtmlPiAttribute AddAttributeBefore(JetBrains.ReSharper.Psi.Html.Tree.IHtmlPiAttribute attribute, JetBrains.ReSharper.Psi.Html.Tree.IHtmlPiAttribute anchor = null) { }
        public override short GetChildRole(JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.TreeElement child) { }
        public void RemoveAttribute(JetBrains.ReSharper.Psi.Html.Tree.IHtmlPiAttribute attribute) { }
    }
    public class HtmlPiAttribute : JetBrains.ReSharper.Psi.Html.Impl.Tree.HtmlCompositeElement, JetBrains.ReSharper.Psi.Html.Tree.IHtmlPiAttribute, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebAttribute, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode
    {
        public HtmlPiAttribute(JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType nodeType, JetBrains.ReSharper.Psi.Html.Parsing.IHtmlTokenNodeTypes tokenTypes) { }
        public string AttributeName { get; }
        public JetBrains.ReSharper.Psi.Html.Tree.IHtmlToken EqToken { get; }
        public JetBrains.ReSharper.Psi.Html.Tree.IHtmlAttributeName NameElement { get; }
        public JetBrains.ReSharper.Psi.Html.Tree.IHtmlAttributeValue ValueElement { get; }
        public override TReturn AcceptVisitor<TContext, TReturn>(JetBrains.ReSharper.Psi.Html.Tree.HtmlTreeVisitor<TContext, TReturn> visitor, TContext context) { }
        public bool AttributeNameEqualsTo(string attributeName) { }
        protected override void ClearCachedData() { }
        public override short GetChildRole(JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.TreeElement child) { }
    }
    public class HtmlTag : JetBrains.ReSharper.Psi.Html.Impl.Tree.HtmlTagContainer, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IScope, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTag, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTagContainer, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTagContainerMarker, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode, JetBrains.ReSharper.Psi.Tree.IChameleonNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebAttributeContainer<JetBrains.ReSharper.Psi.Html.Tree.ITagAttribute>, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode
    {
        protected string myTagName;
        protected string myTagPrefix;
        protected JetBrains.ReSharper.Psi.Html.Tree.HtmlTagType myTagType;
        protected JetBrains.ReSharper.Psi.Html.Tree.HtmlTagType2 myTagType2;
        public HtmlTag(JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType nodeType, JetBrains.ReSharper.Psi.Html.Parsing.IHtmlTokenNodeTypes tokenTypes) { }
        public virtual bool AllowSelfClose { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Html.Tree.ITagAttribute> Attributes { get; }
        protected override JetBrains.ReSharper.Psi.Tree.ITreeNode EndAnchor { get; }
        public virtual JetBrains.ReSharper.Psi.Html.Tree.IHtmlTagFooter Footer { get; }
        public string FullTagName { get; }
        public JetBrains.ReSharper.Psi.Html.Tree.IHtmlTagHeader Header { get; }
        public bool IsOpened { get; }
        public bool IsSelfClosed { get; }
        public int LevelDelta { get; }
        public virtual bool ShouldBeEmpty { get; }
        protected override JetBrains.ReSharper.Psi.Tree.ITreeNode StartAnchor { get; }
        public string TagName { get; }
        public string TagPrefix { get; }
        public JetBrains.ReSharper.Psi.Html.Tree.HtmlTagType TagType { get; }
        public JetBrains.ReSharper.Psi.Html.Tree.HtmlTagType2 TagType2 { get; }
        public override TReturn AcceptVisitor<TContext, TReturn>(JetBrains.ReSharper.Psi.Html.Tree.HtmlTreeVisitor<TContext, TReturn> visitor, TContext context) { }
        public JetBrains.ReSharper.Psi.Html.Tree.ITagAttribute AddAttributeAfter(JetBrains.ReSharper.Psi.Html.Tree.ITagAttribute attribute, JetBrains.ReSharper.Psi.Html.Tree.ITagAttribute anchor = null) { }
        public JetBrains.ReSharper.Psi.Html.Tree.ITagAttribute AddAttributeBefore(JetBrains.ReSharper.Psi.Html.Tree.ITagAttribute attribute, JetBrains.ReSharper.Psi.Html.Tree.ITagAttribute anchor = null) { }
        public JetBrains.ReSharper.Psi.Resolve.ISymbolTable AddGlobalDeclarations(JetBrains.ReSharper.Psi.Resolve.ISymbolTable parentTable, int level, JetBrains.ReSharper.Psi.Resolve.SymbolTableMode mode) { }
        public override T AddTagAfter<T>(T tag, JetBrains.ReSharper.Psi.Tree.ITreeNode anchor)
            where T :  class, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTagContainer { }
        public override T AddTagBefore<T>(T tag, JetBrains.ReSharper.Psi.Tree.ITreeNode anchor)
            where T :  class, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTagContainer { }
        public JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.TreeElement AddTrailingNewLine() { }
        protected override JetBrains.ReSharper.Psi.Tree.ReferenceCollection CreateFirstClassReferences() { }
        public override JetBrains.ReSharper.Psi.Tree.IChameleonNode FindChameleonWhichCoversRange(JetBrains.ReSharper.Psi.TreeTextRange textRange) { }
        public override short GetChildRole(JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.TreeElement child) { }
        protected int GetParentIndent(int step) { }
        protected virtual System.Collections.Generic.IList<JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.TreeElement> Indent(int parentIndent, int step) { }
        protected virtual void IndentContent(int indent, int step) { }
        protected virtual JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.TreeElement IndentFooter(int indent) { }
        protected JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.TreeElement IndentHeader(int indent) { }
        public bool NameMatches(string tagName) { }
        public void RemoveAttribute(JetBrains.ReSharper.Psi.Html.Tree.ITagAttribute attribute) { }
        public virtual JetBrains.ReSharper.Psi.Tree.IChameleonNode ReSync(JetBrains.ReSharper.Psi.Parsing.CachingLexer cachingLexer, JetBrains.ReSharper.Psi.TreeTextRange changedRange, int insertedTextLen) { }
        public override void SubTreeChanged(JetBrains.ReSharper.Psi.Tree.ITreeNode elementContainingChanges, JetBrains.ReSharper.Psi.PsiChangedElementType changeType) { }
        public virtual void UpdateHeaderInformation() { }
    }
    public abstract class HtmlTagContainer : JetBrains.ReSharper.Psi.Html.Impl.Tree.HtmlCompositeElement, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTagContainer, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTagContainerMarker, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode
    {
        public static readonly short[] HTML_TAG_CONTAINER_ROLES;
        protected HtmlTagContainer([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType nodeType, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Html.Parsing.IHtmlTokenNodeTypes tokenTypes) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        protected abstract JetBrains.ReSharper.Psi.Tree.ITreeNode EndAnchor { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        protected abstract JetBrains.ReSharper.Psi.Tree.ITreeNode StartAnchor { get; }
        public override TReturn AcceptVisitor<TContext, TReturn>(JetBrains.ReSharper.Psi.Html.Tree.HtmlTreeVisitor<TContext, TReturn> visitor, TContext context) { }
        public virtual T AddTagAfter<T>(T tag, JetBrains.ReSharper.Psi.Tree.ITreeNode anchor)
            where T :  class, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTagContainer { }
        public virtual T AddTagBefore<T>(T tag, JetBrains.ReSharper.Psi.Tree.ITreeNode anchor)
            where T :  class, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTagContainer { }
        public JetBrains.ReSharper.Psi.ITreeRange GetBodyRange() { }
        public System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.Html.Tree.IHtmlTagContainer> GetInnerTagContainers() { }
        public System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.Html.Tree.IHtmlTag> GetTags() { }
        public void RemoveTag<T>(T tag)
            where T :  class, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTagContainer { }
    }
    public class static HtmlTagContainerNavigator
    {
        public static JetBrains.ReSharper.Psi.Html.Tree.IHtmlTagContainer GetByTagContainer([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Html.Tree.IHtmlTagContainer tagContainer) { }
    }
    public class HtmlTagFooter : JetBrains.ReSharper.Psi.Html.Impl.Tree.TagNameContainer, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTagFooter, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode, JetBrains.ReSharper.Psi.Html.Tree.ITagNameContainer, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode
    {
        public HtmlTagFooter(JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType nodeType, JetBrains.ReSharper.Psi.Html.Parsing.IHtmlTokenNodeTypes tokenTypes) { }
        public JetBrains.ReSharper.Psi.Html.Tree.IHtmlToken EndToken { get; }
        public JetBrains.ReSharper.Psi.Html.Tree.IHtmlToken StartToken { get; }
        public override TReturn AcceptVisitor<TContext, TReturn>(JetBrains.ReSharper.Psi.Html.Tree.HtmlTreeVisitor<TContext, TReturn> visitor, TContext context) { }
        protected override JetBrains.ReSharper.Psi.Tree.ReferenceCollection CreateFirstClassReferences() { }
        public override short GetChildRole(JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.TreeElement child) { }
    }
    public class HtmlTagHeader : JetBrains.ReSharper.Psi.Html.Impl.Tree.TagNameContainer, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTagHeader, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode, JetBrains.ReSharper.Psi.Html.Tree.ITagNameContainer, JetBrains.ReSharper.Psi.Tree.IChameleonNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebAttributeContainer<JetBrains.ReSharper.Psi.Html.Tree.ITagAttribute>, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode
    {
        public HtmlTagHeader(JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType nodeType, JetBrains.ReSharper.Psi.Html.Parsing.IHtmlTokenNodeTypes tokenTypes) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Html.Tree.ITagAttribute> Attributes { get; }
        public JetBrains.ReSharper.Psi.Html.Tree.IHtmlToken EndToken { get; }
        public bool IsClosed { get; }
        public bool IsOpened { get; }
        public bool IsSelfClosed { get; }
        public JetBrains.ReSharper.Psi.Html.Tree.IHtmlToken StartToken { get; }
        public override TReturn AcceptVisitor<TContext, TReturn>(JetBrains.ReSharper.Psi.Html.Tree.HtmlTreeVisitor<TContext, TReturn> visitor, TContext context) { }
        public JetBrains.ReSharper.Psi.Html.Tree.ITagAttribute AddAttributeAfter(JetBrains.ReSharper.Psi.Html.Tree.ITagAttribute attribute, JetBrains.ReSharper.Psi.Html.Tree.ITagAttribute anchor = null) { }
        public JetBrains.ReSharper.Psi.Html.Tree.ITagAttribute AddAttributeBefore(JetBrains.ReSharper.Psi.Html.Tree.ITagAttribute attribute, JetBrains.ReSharper.Psi.Html.Tree.ITagAttribute anchor = null) { }
        public JetBrains.ReSharper.Psi.Html.Tree.IHtmlAttributeValue GetAttributeValue(string attributeName) { }
        public override short GetChildRole(JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.TreeElement child) { }
        public void RemoveAttribute(JetBrains.ReSharper.Psi.Html.Tree.ITagAttribute attribute) { }
        public virtual JetBrains.ReSharper.Psi.Tree.IChameleonNode ReSync(JetBrains.ReSharper.Psi.Parsing.CachingLexer cachingLexer, JetBrains.ReSharper.Psi.TreeTextRange changedRange, int insertedTextLen) { }
    }
    public class static HtmlTagNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Psi.Html.Tree.IHtmlTag GetByAttribute([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Html.Tree.ITagAttribute attribute) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static TTag GetByAttribute<TTag, TTagHeader>([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Html.Tree.ITagAttribute attribute)
            where TTag :  class, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTag
            where TTagHeader :  class, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTagHeader { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Psi.Html.Tree.IHtmlTag GetByAttributeValue([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Html.Tree.IHtmlAttributeValue attributeValue) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static TTag GetByAttributeValue<TTag, TTagHeader, TTagAttribute>([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Html.Tree.IHtmlAttributeValue attributeValue)
            where TTag :  class, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTag
            where TTagHeader :  class, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTagHeader
            where TTagAttribute :  class, JetBrains.ReSharper.Psi.Html.Tree.ITagAttribute { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static T GetByTag<T>([JetBrains.Annotations.NotNullAttribute()] T tag)
            where T :  class, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTagContainer { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Psi.Html.Tree.IHtmlTag GetByTagFooter([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Html.Tree.IHtmlTagFooter footer) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static TTag GetByTagFooter<TTag>([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Html.Tree.IHtmlTagFooter footer)
            where TTag :  class, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTag { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Psi.Html.Tree.IHtmlTag GetByTagHeader([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Html.Tree.IHtmlTagHeader header) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static TTag GetByTagHeader<TTag>([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Html.Tree.IHtmlTagHeader header)
            where TTag :  class, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTag { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Psi.Html.Tree.IHtmlTag GetByTagNameContainer([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Html.Tree.ITagNameContainer container) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static TTag GetByTagNameContainer<TTag, TTagHeader, TTagFooter>([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Html.Tree.ITagNameContainer container)
            where TTag :  class, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTag
            where TTagHeader : JetBrains.ReSharper.Psi.Html.Tree.IHtmlTagHeader
            where TTagFooter : JetBrains.ReSharper.Psi.Html.Tree.IHtmlTagFooter { }
    }
    public class HtmlToken<THtmlTokenNodeTypes> : JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.BindedToBufferLeafElement, JetBrains.ReSharper.Psi.Html.Tree.IHtmlToken, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode, JetBrains.ReSharper.Psi.Tree.ITokenNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode
        where THtmlTokenNodeTypes : JetBrains.ReSharper.Psi.Html.Parsing.IHtmlTokenNodeTypes
    {
        protected internal HtmlToken(THtmlTokenNodeTypes tokenTypes, JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType type, JetBrains.Text.IBuffer buffer, JetBrains.ReSharper.Psi.TreeOffset startOffset, JetBrains.ReSharper.Psi.TreeOffset endOffset) { }
        public override JetBrains.ReSharper.Psi.PsiLanguageType Language { get; }
        public THtmlTokenNodeTypes TokenTypes { get; }
        public TReturn AcceptVisitor<TContext, TReturn>(JetBrains.ReSharper.Psi.Html.Tree.HtmlTreeVisitor<TContext, TReturn> visitor, TContext context) { }
        public JetBrains.ReSharper.Psi.Parsing.TokenNodeType GetTokenType() { }
        public JetBrains.ReSharper.Psi.TreeTextRange GetUnquotedRangeWithin() { }
        public string GetUnquotedText() { }
        public JetBrains.ReSharper.Psi.TreeOffset GetUnquotedTreeStartOffset() { }
        public JetBrains.ReSharper.Psi.TreeTextRange GetUnquotedTreeTextRange() { }
        public override bool IsFiltered() { }
        public override string ToString() { }
    }
    public interface ISpecialReparse
    {
        bool TrySpecialReparse(JetBrains.ReSharper.Psi.TreeTextRange modifiedRange, string text);
    }
    public sealed class ScriptTag : JetBrains.ReSharper.Psi.Html.Impl.Tree.HtmlTag, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTag, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTagContainer, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTagContainerMarker, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode, JetBrains.ReSharper.Psi.Html.Tree.IScriptTag, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebAttributeContainer<JetBrains.ReSharper.Psi.Html.Tree.ITagAttribute>, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode
    {
        public ScriptTag(JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType nodeType, JetBrains.ReSharper.Psi.Html.Parsing.IHtmlTokenNodeTypes tokenTypes) { }
        public JetBrains.ReSharper.Psi.PsiLanguageType LanguageType { get; }
        public override short GetChildRole(JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.TreeElement child) { }
        protected override System.Collections.Generic.IList<JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.TreeElement> Indent(int parentIndent, int step) { }
        protected override void IndentContent(int indent, int step) { }
        protected override JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.TreeElement IndentFooter(int indent) { }
    }
    public class TagAttribute : JetBrains.ReSharper.Psi.Html.Impl.Tree.HtmlCompositeElement, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode, JetBrains.ReSharper.Psi.Html.Tree.ITagAttribute, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebAttribute, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode
    {
        public TagAttribute(JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType nodeType, JetBrains.ReSharper.Psi.Html.Parsing.IHtmlTokenNodeTypes tokenTypes) { }
        public string AttributeName { get; }
        public JetBrains.ReSharper.Psi.Html.Tree.IHtmlToken EqToken { get; }
        public JetBrains.ReSharper.Psi.Html.Tree.IHtmlAttributeName NameElement { get; }
        public JetBrains.ReSharper.Psi.Html.References.IHtmlAttributeReference Reference { get; }
        public JetBrains.ReSharper.Psi.Html.Tree.IHtmlAttributeValue ValueElement { get; }
        public override TReturn AcceptVisitor<TContext, TReturn>(JetBrains.ReSharper.Psi.Html.Tree.HtmlTreeVisitor<TContext, TReturn> visitor, TContext context) { }
        public bool AttributeNameEqualsTo(string attributeName) { }
        protected override void ClearCachedData() { }
        protected override JetBrains.ReSharper.Psi.Tree.ReferenceCollection CreateFirstClassReferences() { }
        public override short GetChildRole(JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.TreeElement child) { }
    }
    public class static TagAttributeNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static TContainer GetByAttribute<TAttribute, TContainer>([JetBrains.Annotations.NotNullAttribute()] TAttribute attribute)
            where TAttribute :  class, JetBrains.ReSharper.Psi.Web.Tree.IWebAttribute
            where TContainer : JetBrains.ReSharper.Psi.Web.Tree.IWebAttributeContainer<> { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Psi.Html.Tree.ITagAttribute GetByValue([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Html.Tree.IHtmlAttributeValue attributeValue) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static TAttribute GetByValue<TAttribute>([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Html.Tree.IHtmlAttributeValue attributeValue)
            where TAttribute :  class, JetBrains.ReSharper.Psi.Html.Tree.ITagAttribute { }
    }
    public abstract class TagNameContainer : JetBrains.ReSharper.Psi.Html.Impl.Tree.HtmlCompositeElement, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode, JetBrains.ReSharper.Psi.Html.Tree.ITagNameContainer, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode
    {
        protected TagNameContainer(JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType nodeType, JetBrains.ReSharper.Psi.Html.Parsing.IHtmlTokenNodeTypes tokenTypes) { }
        public JetBrains.ReSharper.Psi.Html.Tree.IHtmlTag Tag { get; }
        public string TagName { get; }
        public JetBrains.ReSharper.Psi.Html.Tree.IHtmlToken TagNameToken { get; }
        public override short GetChildRole(JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.TreeElement child) { }
        public override JetBrains.DocumentModel.DocumentRange GetNavigationRange() { }
    }
    public class XmlnsAttribute : JetBrains.ReSharper.Psi.Html.Impl.Tree.TagAttribute, JetBrains.ReSharper.Psi.ExtensionsAPI.Caches2.ICachedTypeMemberDeclaration, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode, JetBrains.ReSharper.Psi.Html.Tree.ITagAttribute, JetBrains.ReSharper.Psi.Html.Tree.IXmlnsTagAttribute, JetBrains.ReSharper.Psi.Tree.IDeclaration, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Tree.IXmlDocOwnerTreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebAttribute, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode
    {
        public XmlnsAttribute(JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType nodeType, JetBrains.ReSharper.Psi.Html.Parsing.IHtmlTokenNodeTypes tokenTypes) { }
        public string DeclaredName { get; }
        public JetBrains.ReSharper.Psi.DeclaredElementType GetDeclaredElementType() { }
        public JetBrains.ReSharper.Psi.TreeTextRange GetNameRange() { }
        public System.Xml.XmlNode GetXMLDoc(bool inherit) { }
        public bool IsSynthetic() { }
        protected override void PreInit() { }
        public void SetName(string name) { }
    }
}
namespace JetBrains.ReSharper.Psi.Html.Naming
{
    
    public class HtmlNamingPolicyProvider : JetBrains.ReSharper.Psi.Web.Naming.WebPolicyProvider
    {
        public HtmlNamingPolicyProvider(JetBrains.ReSharper.Psi.PsiLanguageType language, JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, JetBrains.Application.Settings.IContextBoundSettingsStore settingsStore) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.Html.HtmlLanguage))]
    public class HtmlNamingPolicyProviderFactory : JetBrains.ReSharper.Psi.Naming.Interfaces.INamingPolicyProviderFactory
    {
        public HtmlNamingPolicyProviderFactory(JetBrains.ReSharper.Psi.PsiLanguageType language) { }
        public JetBrains.ReSharper.Psi.Naming.Interfaces.INamingPolicyProvider CreatePolicyProvider(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, JetBrains.Application.Settings.IContextBoundSettingsStore settingsStore) { }
    }
}
namespace JetBrains.ReSharper.Psi.Html.Parsing
{
    
    public class HtmlCompoundIncrementalLexer<TLexer> : JetBrains.ReSharper.Psi.Html.Parsing.HtmlCompoundLexer<TLexer>, JetBrains.ReSharper.Psi.Parsing.IIncrementalLexer, JetBrains.ReSharper.Psi.Parsing.ILexer, JetBrains.ReSharper.Psi.Parsing.ILexerEx
        where TLexer : JetBrains.ReSharper.Psi.Html.Parsing.IHtmlCompoundLexer, JetBrains.ReSharper.Psi.Parsing.IIncrementalLexer
    {
        public HtmlCompoundIncrementalLexer([JetBrains.Annotations.NotNullAttribute()] JetBrains.Text.IBuffer buffer, [JetBrains.Annotations.NotNullAttribute()] TLexer baseLexer, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Parsing.IIncrementalLexerFactory htmlLexerFactory) { }
        public int EOFPos { get; }
        public int LexemIndent { get; }
        public void Start(int startOffset, int endOffset, uint state) { }
    }
    public class HtmlCompoundLexer<TLexer> : JetBrains.ReSharper.Psi.Parsing.ILexer, JetBrains.ReSharper.Psi.Parsing.ILexerEx
        where TLexer : JetBrains.ReSharper.Psi.Html.Parsing.IHtmlCompoundLexer
    {
        [JetBrains.Annotations.NotNullAttribute()]
        protected readonly TLexer myBaseLexer;
        protected JetBrains.ReSharper.Psi.Parsing.TokenNodeType myCurrentToken;
        protected uint myZLexerState;
        public HtmlCompoundLexer([JetBrains.Annotations.NotNullAttribute()] JetBrains.Text.IBuffer buffer, [JetBrains.Annotations.NotNullAttribute()] TLexer baseLexer, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Parsing.IIncrementalLexerFactory htmlLexerFactory) { }
        public JetBrains.Text.IBuffer Buffer { get; }
        public object CurrentPosition { get; set; }
        public uint LexerStateEx { get; }
        public int TokenEnd { get; }
        public int TokenStart { get; }
        public JetBrains.ReSharper.Psi.Parsing.TokenNodeType TokenType { get; }
        public void Advance() { }
        protected uint GetBaseLexerState() { }
        protected uint GetHtmlLexerState() { }
        protected void SetHtmlLexerState(bool isRunning, uint htmlLexerState) { }
        public void Start() { }
    }
    public enum HtmlContextType
    {
        Html = 0,
        Script = 1,
        Style = 2,
        Code = 3,
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.Html.HtmlLanguage))]
    public class HtmlElementFactory : JetBrains.ReSharper.Psi.Html.Parsing.IWebElementFactory
    {
        public HtmlElementFactory(JetBrains.ReSharper.Psi.Html.Parsing.IWebTreeBuilderFactory builderFactory) { }
        public virtual System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Tree.ITreeNode> CompileText(string text, JetBrains.ReSharper.Psi.Tree.ITreeNode contextElement, JetBrains.ReSharper.Psi.Html.Parsing.HtmlContextType htmlContextType = 0) { }
        public JetBrains.ReSharper.Psi.Html.Tree.IHtmlTag CreateCompoundHtmlTag(string tagName, JetBrains.ReSharper.Psi.Tree.ITreeNode contextElement) { }
        public JetBrains.ReSharper.Psi.Html.Tree.IHtmlTag CreateEmptyHtmlTag(string tagName, JetBrains.ReSharper.Psi.Tree.ITreeNode contextElement) { }
        public JetBrains.ReSharper.Psi.Html.Tree.IHtmlFile CreateFile(JetBrains.Text.IBuffer buffer, JetBrains.ReSharper.Psi.Modules.IPsiModule module) { }
        public JetBrains.ReSharper.Psi.Html.Tree.IHtmlTag CreateHtmlTag(string text, JetBrains.ReSharper.Psi.Tree.ITreeNode contextElement) { }
        public T CreateSandBox<T>(T result, JetBrains.ReSharper.Psi.Tree.ITreeNode contextElement, JetBrains.ReSharper.Psi.SandBoxContextType contextType = 1)
            where T :  class, JetBrains.ReSharper.Psi.Tree.ITreeNode { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.ReSharper.Psi.Html.Parsing.HtmlElementFactory GetInstance<TLanguage>(JetBrains.ReSharper.Psi.ILanguageManager languageManager = null)
            where TLanguage : JetBrains.ReSharper.Psi.PsiLanguageType { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.ReSharper.Psi.Html.Parsing.HtmlElementFactory GetInstance(JetBrains.ReSharper.Psi.PsiLanguageType lang, JetBrains.ReSharper.Psi.ILanguageManager languageManager = null) { }
        [JetBrains.Annotations.NotNullAttribute()]
        protected static T GetInstance<T>(JetBrains.ReSharper.Psi.PsiLanguageType lang, JetBrains.ReSharper.Psi.ILanguageManager languageManager = null)
            where T :  class, JetBrains.ReSharper.Psi.Html.Parsing.IWebElementFactory { }
    }
    public class HtmlLexer : JetBrains.ReSharper.Psi.Html.Parsing.HtmlRawLexerGenerated
    {
        public HtmlLexer(JetBrains.ReSharper.Psi.Html.Parsing.IHtmlTokenNodeTypes tokenNodeTypes, JetBrains.Text.IBuffer buffer) { }
    }
    public class HtmlLexerFactory : JetBrains.ReSharper.Psi.Parsing.IIncrementalLexerFactory, JetBrains.ReSharper.Psi.Parsing.ILexerFactory
    {
        public HtmlLexerFactory(JetBrains.ReSharper.Psi.Html.Parsing.IHtmlTokenNodeTypes tokenNodeTypes) { }
        public JetBrains.ReSharper.Psi.Parsing.IIncrementalLexer CreateLexer(JetBrains.Text.IBuffer buffer) { }
    }
    public abstract class HtmlRawLexerGenerated : JetBrains.ReSharper.Psi.Parsing.IIncrementalLexer, JetBrains.ReSharper.Psi.Parsing.ILexer, JetBrains.ReSharper.Psi.Parsing.ILexerEx
    {
        protected JetBrains.ReSharper.Psi.Parsing.TokenNodeType currTokenType;
        public const int LEXER_STATE_IN_TAG_ATTRS = 3;
        public const int LEXER_STATE_IN_TAG_ATTRS_VALUE = 5;
        protected bool myInScript;
        protected bool myInStyle;
        protected bool myInTextArea;
        protected const int YY_CONDITIONAL = 23;
        protected const int YY_IN_CDATA = 13;
        protected const int YY_IN_CLOSING_TAG = 10;
        protected const int YY_IN_COMMENT = 12;
        protected const int YY_IN_DOCTYPE = 24;
        protected const int YY_IN_DOCTYPE_VALUE_DOUBLEQUOTE = 25;
        protected const int YY_IN_HTML_HEADER = 22;
        protected const int YY_IN_INCLUDE = 21;
        protected const int YY_IN_PI = 2;
        protected const int YY_IN_SCRIPT = 14;
        protected const int YY_IN_SCRIPT_DOUBLEQUOTED_LITERAL = 15;
        protected const int YY_IN_SCRIPT_SINGLEQUOTED_LITERAL = 16;
        protected const int YY_IN_STYLE = 17;
        protected const int YY_IN_STYLE_DOUBLEQUOTED_LITERAL = 18;
        protected const int YY_IN_STYLE_SINGLEQUOTED_LITERAL = 19;
        protected const int YY_IN_TAG = 1;
        protected const int YY_IN_TAG_ATTRS = 3;
        protected const int YY_IN_TAG_ATTRS_EMPTY_VALUE_DOUBLEQUOTE = 9;
        protected const int YY_IN_TAG_ATTRS_EMPTY_VALUE_SINGLEQUOTE = 7;
        protected const int YY_IN_TAG_ATTRS_EQ = 4;
        protected const int YY_IN_TAG_ATTRS_VALUE = 5;
        protected const int YY_IN_TAG_ATTRS_VALUE_DOUBLEQUOTE = 8;
        protected const int YY_IN_TAG_ATTRS_VALUE_SINGLEQUOTE = 6;
        protected const int YY_IN_TEXTAREA = 20;
        protected const int YY_SKIPTO_GT = 11;
        protected const int YYINITIAL = 0;
        protected HtmlRawLexerGenerated(JetBrains.ReSharper.Psi.Html.Parsing.IHtmlTokenNodeTypes tokenNodeTypes, JetBrains.Text.IBuffer buffer) { }
        public HtmlRawLexerGenerated(JetBrains.Text.IBuffer buffer) { }
        public HtmlRawLexerGenerated(JetBrains.Text.IBuffer buffer, int startOffset, int endOffset) { }
        public JetBrains.Text.IBuffer Buffer { get; }
        public object CurrentPosition { get; set; }
        public int EOFPos { get; }
        public int LexemIndent { get; }
        public uint LexerStateEx { get; }
        public int TokenEnd { get; }
        public int TokenStart { get; }
        public JetBrains.ReSharper.Psi.Parsing.TokenNodeType TokenType { get; }
        public JetBrains.ReSharper.Psi.Parsing.TokenNodeType _locateToken() { }
        public void Advance() { }
        public static uint GetNewState(uint lexerState, uint newState) { }
        public static bool IsInState(uint lexerState, int verifyingState) { }
        protected bool IsSpecialTag(string expectedName) { }
        protected JetBrains.ReSharper.Psi.Parsing.TokenNodeType makeToken(JetBrains.ReSharper.Psi.Parsing.TokenNodeType type) { }
        protected void setState(int state) { }
        protected void setStateClear(int state) { }
        public void Start() { }
        public void Start(int startOffset, int endOffset, uint state) { }
    }
    public class HtmlStackedLexer : JetBrains.ReSharper.Psi.Parsing.ILexer
    {
        public HtmlStackedLexer(JetBrains.ReSharper.Psi.Parsing.ILexerFactory lexerFactory, JetBrains.ReSharper.Psi.Html.Parsing.IHtmlTokenNodeTypes tokenTypes) { }
        public JetBrains.Text.IBuffer Buffer { get; }
        public JetBrains.Util.FileSystemPath CurrentFile { get; }
        public object CurrentPosition { get; set; }
        public int TokenEnd { get; }
        public int TokenStart { get; }
        public JetBrains.ReSharper.Psi.Parsing.TokenNodeType TokenType { get; }
        public void Advance() { }
        public bool Push(JetBrains.Text.IBuffer buffer, bool noAdvanceOnReturn = False) { }
        public bool Push([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IPsiSourceFile file, bool noAdvanceOnReturn = False) { }
        public bool Push([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Parsing.ILexer lexer, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.FileSystemPath path, bool noAdvanceOnReturn = False) { }
        public void Start() { }
    }
    public class HtmlTokenNodeType<THtmlTokenNodeTypes> : JetBrains.ReSharper.Psi.Parsing.TokenNodeType, JetBrains.ReSharper.Psi.Html.Parsing.IHtmlTokenNodeType<THtmlTokenNodeTypes>, JetBrains.ReSharper.Psi.Parsing.ITokenNodeType
        where THtmlTokenNodeTypes : JetBrains.ReSharper.Psi.Html.Parsing.IHtmlTokenNodeTypes
    {
        public HtmlTokenNodeType([JetBrains.Annotations.NotNullAttribute()] THtmlTokenNodeTypes tokenNodeTypes, [JetBrains.Annotations.NotNullAttribute()] string s, int index, bool isFilteredNode = False) { }
        public override bool IsComment { get; }
        public override bool IsConstantLiteral { get; }
        public override bool IsFiltered { get; }
        public override bool IsIdentifier { get; }
        public override bool IsKeyword { get; }
        public override bool IsStringLiteral { get; }
        public override bool IsWhitespace { get; }
        public THtmlTokenNodeTypes TokenNodeTypes { get; }
        public override string TokenRepresentation { get; }
        public override JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.LeafElementBase Create(JetBrains.Text.IBuffer buffer, JetBrains.ReSharper.Psi.TreeOffset startOffset, JetBrains.ReSharper.Psi.TreeOffset endOffset) { }
    }
    public sealed class HtmlTreeBuilder : JetBrains.ReSharper.Psi.Html.Parsing.HtmlTreeBuilderBase<JetBrains.ReSharper.Psi.Html.Tree.IHtmlFile, JetBrains.ReSharper.Psi.Html.Impl.Tree.HtmlFile, JetBrains.ReSharper.Psi.Html.Tree.HtmlElementTypes, JetBrains.ReSharper.Psi.Html.Parsing.IHtmlTokenNodeTypes>
    {
        protected override JetBrains.ReSharper.Psi.Html.Parsing.HtmlTreeBuilderBase<JetBrains.ReSharper.Psi.Html.Tree.IHtmlFile, JetBrains.ReSharper.Psi.Html.Impl.Tree.HtmlFile, JetBrains.ReSharper.Psi.Html.Tree.HtmlElementTypes, JetBrains.ReSharper.Psi.Html.Parsing.IHtmlTokenNodeTypes>.FindParentToClose DoFindParentToClose(JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeElement e) { }
    }
    public abstract class HtmlTreeBuilderBase<TIFile, TFile, TElementTypes, TTokenTypes> : JetBrains.ReSharper.Psi.Html.Parsing.WebTreeBuilder<TIFile, TFile, TElementTypes, TTokenTypes>
        where TIFile : JetBrains.ReSharper.Psi.Html.Tree.IHtmlFile
        where TFile : JetBrains.ReSharper.Psi.Html.Impl.Tree.HtmlFile, TIFile
        where TElementTypes : JetBrains.ReSharper.Psi.Html.Tree.HtmlElementTypes
        where TTokenTypes :  class, JetBrains.ReSharper.Psi.Html.Parsing.IHtmlTokenNodeTypes
    {
        public HtmlTreeBuilderBase(JetBrains.ReSharper.Psi.Html.HtmlLanguage lang, TElementTypes elementTypes, TTokenTypes tokenTypes, System.Collections.Generic.ICollection<string> templatesMimeTypes, int depthThreshold) { }
        public override bool CanHaveServerSideNodes { get; }
        protected override JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet HandlingTokens { get; }
        protected override JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeElement AppendParsedTag(JetBrains.ReSharper.Psi.Html.Impl.Tree.HtmlTag tag, JetBrains.ReSharper.Psi.Html.Impl.Tree.HtmlTagHeader tagHeader, JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeElement originalParent, JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeElement compositeElement) { }
        protected override TFile CreateFile(JetBrains.ReSharper.Psi.Html.Parsing.HtmlStackedLexer stackedLexer, out JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeElement compositeElement) { }
        protected abstract JetBrains.ReSharper.Psi.Html.Parsing.HtmlTreeBuilderBase<TIFile, TFile, TElementTypes, TTokenTypes>.FindParentToClose DoFindParentToClose(JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeElement e);
        [JetBrains.Annotations.CanBeNullAttribute()]
        protected virtual JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeElement FindClosedTagParent(JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeElement parent, JetBrains.ReSharper.Psi.Html.Impl.Tree.HtmlTag tag) { }
        protected override JetBrains.ReSharper.Psi.Html.Impl.Tree.HtmlTag FindSiblingTagThatCanBeClosedByFooter(JetBrains.ReSharper.Psi.Html.Impl.Tree.HtmlTagFooter tagFooter, JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.TreeElement lastNode) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        protected static JetBrains.ReSharper.Psi.Html.Impl.PredefinedControls.HtmlTagInfo GetParentTagInfo(JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeElement parent) { }
        public override System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Tree.ITreeNode> SearchServerSideNodes(JetBrains.ReSharper.Psi.Tree.ITreeNode nestedFile) { }
        protected override JetBrains.ReSharper.Psi.Html.Parsing.ServerSideNodeKinds ToNodeWithKind(JetBrains.ReSharper.Psi.Tree.ITreeNode node) { }
        protected enum FindParentToClose<TIFile, TFile, TElementTypes, TTokenTypes>
            where TIFile : JetBrains.ReSharper.Psi.Html.Tree.IHtmlFile
            where TFile : JetBrains.ReSharper.Psi.Html.Impl.Tree.HtmlFile, TIFile
            where TElementTypes : JetBrains.ReSharper.Psi.Html.Tree.HtmlElementTypes
            where TTokenTypes :  class, JetBrains.ReSharper.Psi.Html.Parsing.IHtmlTokenNodeTypes
        {
            STOP = 0,
            SKIP_TO_PARENT = 1,
            NORMAL = 2,
        }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.Html.HtmlLanguage))]
    public class HtmlTreeBuilderFactory : JetBrains.ReSharper.Psi.Html.Parsing.IWebTreeBuilderFactory
    {
        protected System.Collections.Generic.ICollection<string> myTemplatesMimeTypes;
        public HtmlTreeBuilderFactory(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.Settings.ISettingsStore settingsStore, JetBrains.ReSharper.Psi.Html.HtmlLanguage language, JetBrains.ReSharper.Psi.Html.Tree.HtmlElementTypes elementTypes, JetBrains.ReSharper.Psi.Html.Parsing.IHtmlTokenNodeTypes tokenTypes, JetBrains.ReSharper.Psi.PerformanceThreshold.PerformanceThresholds threshold) { }
        public virtual JetBrains.ReSharper.Psi.Html.Parsing.IWebTreeBuilder CreateTreeBuilder() { }
    }
    public interface IHtmlCompoundLexer : JetBrains.ReSharper.Psi.Parsing.ILexer, JetBrains.ReSharper.Psi.Parsing.ILexerEx
    {
        short NStates { get; }
        JetBrains.ReSharper.Psi.Html.Parsing.IHtmlCompoundTokenNodeTypes TokenTypes { get; }
    }
    public interface IHtmlCompoundTokenNodeTypes : JetBrains.ReSharper.Psi.Html.Parsing.IHtmlTokenNodeTypes
    {
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Parsing.TokenNodeType RAW_HTML { get; }
    }
    public interface IHtmlTokenNodeType<out THtmlTokenNodeTypes> : JetBrains.ReSharper.Psi.Parsing.ITokenNodeType
        where out THtmlTokenNodeTypes : JetBrains.ReSharper.Psi.Html.Parsing.IHtmlTokenNodeTypes
    {
        [JetBrains.Annotations.NotNullAttribute()]
        THtmlTokenNodeTypes TokenNodeTypes { get; }
    }
    public interface IHtmlTokenNodeTypes
    {
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Parsing.TokenNodeType ATTRIBUTE_NAME { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Parsing.TokenNodeType ATTRIBUTE_VALUE { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Parsing.TokenNodeType DOUBLE_QUOTE { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Parsing.TokenNodeType EQ { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Parsing.TokenNodeType ERROR { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Parsing.TokenNodeType HTML_CDATA_BODY { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Parsing.TokenNodeType HTML_CDATA_END { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Parsing.TokenNodeType HTML_CDATA_START { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Parsing.TokenNodeType HTML_COMMENT_BODY { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Parsing.TokenNodeType HTML_COMMENT_END { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Parsing.TokenNodeType HTML_COMMENT_START { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Parsing.TokenNodeType HTML_CONDITIONAL_AND { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Parsing.TokenNodeType HTML_CONDITIONAL_COMMENT_END { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Parsing.TokenNodeType HTML_CONDITIONAL_COMMENT_END2 { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Parsing.TokenNodeType HTML_CONDITIONAL_COMMENT_START { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Parsing.TokenNodeType HTML_CONDITIONAL_END { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Parsing.TokenNodeType HTML_CONDITIONAL_ENDIF { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Parsing.TokenNodeType HTML_CONDITIONAL_FALSE { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Parsing.TokenNodeType HTML_CONDITIONAL_GT { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Parsing.TokenNodeType HTML_CONDITIONAL_GTE { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Parsing.TokenNodeType HTML_CONDITIONAL_IF { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Parsing.TokenNodeType HTML_CONDITIONAL_LPARENTH { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Parsing.TokenNodeType HTML_CONDITIONAL_LT { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Parsing.TokenNodeType HTML_CONDITIONAL_LTE { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Parsing.TokenNodeType HTML_CONDITIONAL_NOT { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Parsing.TokenNodeType HTML_CONDITIONAL_OR { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Parsing.TokenNodeType HTML_CONDITIONAL_RPARENTH { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Parsing.TokenNodeType HTML_CONDITIONAL_START { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Parsing.TokenNodeType HTML_CONDITIONAL_TRUE { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Parsing.TokenNodeType HTML_DOCTYPE_START { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Parsing.TokenNodeType HTML_ENTITY_DIGITAL { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Parsing.TokenNodeType HTML_ENTITY_HEXIMAL { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Parsing.TokenNodeType HTML_ENTITY_NAMED { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Parsing.TokenNodeType HTML_HEADER_START { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Parsing.TokenNodeType HTML_INCLUDE_END { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Parsing.TokenNodeType HTML_INCLUDE_FILE { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Parsing.TokenNodeType HTML_INCLUDE_FILENAME { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Parsing.TokenNodeType HTML_INCLUDE_VIRTUAL { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Parsing.TokenNodeType IDENTIFIER { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Parsing.TokenNodeType INCLUDED_FILE_END { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Html.HtmlLanguage Language { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Parsing.TokenNodeType NEW_LINE_IN_STRING { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Parsing.TokenNodeType NUMBER { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Parsing.TokenNodeType PI_END { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Parsing.TokenNodeType PI_START { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Parsing.TokenNodeType SCRIPT_BODY { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Parsing.TokenNodeType SINGLE_QUOTE { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Parsing.TokenNodeType SPACE { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Parsing.TokenNodeType STRING { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Parsing.TokenNodeType STYLE_BODY { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Parsing.TokenNodeType TAG_END { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Parsing.TokenNodeType TAG_END1 { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Parsing.TokenNodeType TAG_NAME { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Parsing.TokenNodeType TAG_START { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Parsing.TokenNodeType TAG_START1 { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet TAGS_BODY_NODE_SET { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Parsing.TokenNodeType TEXT { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Parsing.TokenNodeType TEXTAREA_BODY { get; }
        short GetChildRole(JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.TreeElement child);
        bool IsNonHtmlToken(JetBrains.ReSharper.Psi.Parsing.TokenNodeType tokenNodeType);
        bool IsTagLikeClose(JetBrains.ReSharper.Psi.Parsing.TokenNodeType tokenNodeType);
        bool IsTagLikeOpen(JetBrains.ReSharper.Psi.Parsing.TokenNodeType tokenNodeType);
    }
    public interface IWebElementFactory
    {
        JetBrains.ReSharper.Psi.Html.Tree.IHtmlTag CreateCompoundHtmlTag(string tagName, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode contextElement);
        JetBrains.ReSharper.Psi.Html.Tree.IHtmlTag CreateEmptyHtmlTag(string tagName, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode contextElement);
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Html.Tree.IHtmlTag CreateHtmlTag(string text, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode contextElement);
        [JetBrains.Annotations.NotNullAttribute()]
        T CreateSandBox<T>([JetBrains.Annotations.NotNullAttribute()] T result, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode contextElement, JetBrains.ReSharper.Psi.SandBoxContextType contextType = 1)
            where T :  class, JetBrains.ReSharper.Psi.Tree.ITreeNode;
    }
    public interface IWebTreeBuilder
    {
        bool CanHaveServerSideNodes { get; }
        JetBrains.ReSharper.Psi.Html.Tree.IHtmlFile CreateTree([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Parsing.ILexer lexer, JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile = null);
        JetBrains.ReSharper.Psi.Html.Tree.IHtmlFile CreateTree([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile);
        JetBrains.ReSharper.Psi.Html.Tree.IHtmlFile CreateTree([JetBrains.Annotations.NotNullAttribute()] JetBrains.Text.IBuffer buffer, JetBrains.ReSharper.Psi.IPsiSourceFile baseSourceFile = null);
        System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Tree.ITreeNode> SearchServerSideNodes(JetBrains.ReSharper.Psi.Tree.ITreeNode nestedFile);
        System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Html.Parsing.ServerSideNodeWithKind> SearchServerSideNodesWithKinds(JetBrains.ReSharper.Psi.Tree.ITreeNode nestedFile);
    }
    public interface IWebTreeBuilderFactory
    {
        JetBrains.ReSharper.Psi.Html.Parsing.IWebTreeBuilder CreateTreeBuilder();
    }
    public class NonRecursiveTreeNodeTraverser : JetBrains.ReSharper.Psi.Html.Parsing.NonRecursiveTreeTraverser<JetBrains.ReSharper.Psi.Tree.ITreeNode>
    {
        protected NonRecursiveTreeNodeTraverser(System.Func<JetBrains.ReSharper.Psi.Tree.ITreeNode, bool> processBeforeChildrenAndShouldGoDeeper = null, System.Action<JetBrains.ReSharper.Psi.Tree.ITreeNode> processAfterChildren = null, System.Func<bool> shouldStop = null) { }
        public static JetBrains.ReSharper.Psi.Html.Parsing.NonRecursiveTreeTraverser<JetBrains.ReSharper.Psi.Tree.ITreeNode> Create(System.Func<JetBrains.ReSharper.Psi.Tree.ITreeNode, bool> processBeforeChildrenAndShouldGoDeeper = null, System.Action<JetBrains.ReSharper.Psi.Tree.ITreeNode> processAfterChildren = null) { }
        public static JetBrains.ReSharper.Psi.Html.Parsing.NonRecursiveTreeTraverser<JetBrains.ReSharper.Psi.Tree.ITreeNode> CreateInterruptable(System.Func<JetBrains.ReSharper.Psi.Tree.ITreeNode, bool> processBeforeChildrenAndShouldGoDeeper = null, System.Action<JetBrains.ReSharper.Psi.Tree.ITreeNode> processAfterChildren = null) { }
        protected override JetBrains.ReSharper.Psi.Tree.ITreeNode GetFirstChild(JetBrains.ReSharper.Psi.Tree.ITreeNode node) { }
        protected override JetBrains.ReSharper.Psi.Tree.ITreeNode GetNextSibling(JetBrains.ReSharper.Psi.Tree.ITreeNode node) { }
        protected override JetBrains.ReSharper.Psi.Tree.ITreeNode GetParent(JetBrains.ReSharper.Psi.Tree.ITreeNode node) { }
    }
    public abstract class NonRecursiveTreeTraverser<TNode>
    
    {
        public NonRecursiveTreeTraverser(System.Func<TNode, bool> processBeforeChildrenAndShouldGoDeeper = null, System.Action<TNode> processAfterChildren = null, System.Func<bool> shouldStop = null) { }
        protected abstract TNode GetFirstChild(TNode node);
        protected abstract TNode GetNextSibling(TNode node);
        protected abstract TNode GetParent(TNode node);
        protected virtual void ProcessAfterChildren(TNode node) { }
        protected virtual bool ProcessBeforeChildren(TNode treeNode) { }
        public void Run(TNode treeNode) { }
        protected virtual bool ShouldStop() { }
    }
    public enum ServerSideNodeKinds
    {
        Whitespace = 0,
        DirectOutcome = 1,
        ControlStructure = 2,
    }
    public struct ServerSideNodeWithKind
    {
        public JetBrains.ReSharper.Psi.Html.Parsing.ServerSideNodeKinds NodeKind;
        public JetBrains.ReSharper.Psi.Tree.ITreeNode TreeNode;
        public ServerSideNodeWithKind(JetBrains.ReSharper.Psi.Html.Parsing.ServerSideNodeKinds nodeKind, JetBrains.ReSharper.Psi.Tree.ITreeNode treeNode) { }
    }
    public abstract class WebTreeBuilder<TIFile, TFile, TElementTypes, TTokenTypes> : JetBrains.ReSharper.Psi.Html.Parsing.IWebTreeBuilder
        where TIFile : JetBrains.ReSharper.Psi.Html.Tree.IHtmlFile
        where TFile : JetBrains.ReSharper.Psi.Html.Impl.Tree.HtmlFile, TIFile
        where TElementTypes : JetBrains.ReSharper.Psi.Html.Tree.HtmlElementTypes
        where TTokenTypes :  class, JetBrains.ReSharper.Psi.Html.Parsing.IHtmlTokenNodeTypes
    {
        protected WebTreeBuilder(JetBrains.ReSharper.Psi.Html.HtmlLanguage lang, TElementTypes elementTypes, TTokenTypes tokenTypes, System.Collections.Generic.ICollection<string> templatesMimeTypes, int depthThreshold) { }
        protected JetBrains.ReSharper.Psi.Impl.PsiBuilderLexer BuilderLexer { get; }
        public abstract bool CanHaveServerSideNodes { get; }
        protected TElementTypes ElementTypes { get; }
        protected abstract JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet HandlingTokens { get; }
        protected JetBrains.Util.OneToSetMap<JetBrains.Util.FileSystemPath, JetBrains.Util.FileSystemPath> ImmediateIncludes { get; }
        protected JetBrains.ReSharper.Psi.IPsiSourceFile SourceFile { get; }
        protected TTokenTypes TokenTypes { get; }
        protected void AddHtmlInclude(JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeElement parent, JetBrains.ReSharper.Psi.IPsiSourceFile includedSourceFile, JetBrains.Util.FileSystemPath includedPath, bool noAdvanceOnReturn = False) { }
        protected virtual JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeElement AddHtmlIncludeEnd(JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeElement parent, JetBrains.ReSharper.Psi.Html.Impl.Tree.HtmlIncludeEnd includeEnd) { }
        protected void AppendNewChild([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeElement parent, JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.TreeElement element) { }
        protected virtual JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeElement AppendParsedTag(JetBrains.ReSharper.Psi.Html.Impl.Tree.HtmlTag tag, JetBrains.ReSharper.Psi.Html.Impl.Tree.HtmlTagHeader tagHeader, JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeElement originalParent, JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeElement compositeElement) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        protected virtual JetBrains.ReSharper.Psi.Html.Impl.Tree.TagAttribute ConvertTagAttribute([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Html.Impl.Tree.TagAttribute originalAttribute) { }
        protected JetBrains.ReSharper.Psi.Html.Impl.Tree.HtmlErrorElement CreateError(JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeElement parent, string description, JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.TreeElement child = null) { }
        protected abstract TFile CreateFile(JetBrains.ReSharper.Psi.Html.Parsing.HtmlStackedLexer stackedLexer, out JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeElement compositeElement);
        protected virtual JetBrains.ReSharper.Psi.Html.Impl.Tree.HtmlToken<TTokenTypes> CreateToken([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Html.Parsing.HtmlTokenNodeType<TTokenTypes> tokenType) { }
        protected static JetBrains.ReSharper.Psi.Html.Impl.Tree.HtmlToken<TTokenTypes> CreateToken([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Parsing.TokenNodeType tokenType, JetBrains.Text.IBuffer buffer, JetBrains.ReSharper.Psi.TreeTextRange treeTextRange) { }
        protected virtual void CreateTokenError(ref JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeElement parent, string description, ref JetBrains.ReSharper.Psi.Html.Parsing.HtmlTokenNodeType<> tokenType) { }
        public JetBrains.ReSharper.Psi.Html.Tree.IHtmlFile CreateTree(JetBrains.ReSharper.Psi.Parsing.ILexer lexer, JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile = null) { }
        public JetBrains.ReSharper.Psi.Html.Tree.IHtmlFile CreateTree(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
        public JetBrains.ReSharper.Psi.Html.Tree.IHtmlFile CreateTree(JetBrains.Text.IBuffer buffer, JetBrains.ReSharper.Psi.IPsiSourceFile baseSourceFile = null) { }
        protected virtual JetBrains.ReSharper.Psi.Html.Impl.Tree.HtmlTag FindSiblingTagThatCanBeClosedByFooter(JetBrains.ReSharper.Psi.Html.Impl.Tree.HtmlTagFooter tagFooter, JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.TreeElement lastNode) { }
        protected JetBrains.ReSharper.Psi.Html.Parsing.HtmlTokenNodeType<TTokenTypes> GetNextHtmlToken(ref JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeElement compositeElement) { }
        protected JetBrains.ReSharper.Psi.Html.Parsing.HtmlTokenNodeType<TTokenTypes> GetNextNotErrorToken(ref JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeElement compositeElement) { }
        protected JetBrains.ReSharper.Psi.Html.Parsing.HtmlTokenNodeType<TTokenTypes> GetNextToken() { }
        protected virtual bool IsStopFindOpenTag(JetBrains.ReSharper.Psi.Tree.ITreeNode node) { }
        protected virtual bool ParseAdditionalConstruct([JetBrains.Annotations.CanBeNullAttribute()] ref JetBrains.ReSharper.Psi.Html.Parsing.HtmlTokenNodeType<> tokenType, ref JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeElement compositeElement) { }
        protected virtual void ParseSpecialTag(JetBrains.ReSharper.Psi.Html.Impl.Tree.HtmlTag tag, JetBrains.ReSharper.Psi.Html.Impl.Tree.HtmlTagHeader header, JetBrains.ReSharper.Psi.Parsing.TokenNodeType bodyTokenType) { }
        protected virtual JetBrains.ReSharper.Psi.Html.Impl.Tree.HtmlTag ParseTag(JetBrains.ReSharper.Psi.Html.Impl.Tree.HtmlTagHeader tagHeader) { }
        protected void PushBack([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Html.Impl.Tree.HtmlToken<TTokenTypes> token) { }
        protected void PushBack([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Html.Parsing.HtmlTokenNodeType<TTokenTypes> tokenType) { }
        public abstract System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Tree.ITreeNode> SearchServerSideNodes(JetBrains.ReSharper.Psi.Tree.ITreeNode nestedFile);
        public System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Html.Parsing.ServerSideNodeWithKind> SearchServerSideNodesWithKinds(JetBrains.ReSharper.Psi.Tree.ITreeNode nestedFile) { }
        protected abstract JetBrains.ReSharper.Psi.Html.Parsing.ServerSideNodeKinds ToNodeWithKind(JetBrains.ReSharper.Psi.Tree.ITreeNode node);
        protected class NoInsideRecursiveElementsCollector<TIFile, TFile, TElementTypes, TTokenTypes, T> : JetBrains.ReSharper.Psi.RecursiveElementCollector<T>
            where TIFile : JetBrains.ReSharper.Psi.Html.Tree.IHtmlFile
            where TFile : JetBrains.ReSharper.Psi.Html.Impl.Tree.HtmlFile, TIFile
            where TElementTypes : JetBrains.ReSharper.Psi.Html.Tree.HtmlElementTypes
            where TTokenTypes :  class, JetBrains.ReSharper.Psi.Html.Parsing.IHtmlTokenNodeTypes
            where T :  class, JetBrains.ReSharper.Psi.Tree.ITreeNode
        {
            public NoInsideRecursiveElementsCollector(System.Func<T, bool> predicate) { }
            public override bool InteriorShouldBeProcessed(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
            public override JetBrains.ReSharper.Psi.RecursiveElementCollector<T> ProcessElement(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        }
    }
    public class static WebTreeBuilderFactory
    {
        public static JetBrains.ReSharper.Psi.Html.Parsing.IWebTreeBuilder CreateTreeBuilder(JetBrains.ReSharper.Psi.PsiLanguageType lang) { }
        public static JetBrains.ReSharper.Psi.Html.Parsing.IWebTreeBuilderFactory GetInstance(JetBrains.ReSharper.Psi.PsiLanguageType language) { }
    }
}
namespace JetBrains.ReSharper.Psi.Html.References
{
    
    public interface IHtmlAttributeReference : JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IQualifiableReferenceBase, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IQualifiableReferenceWithGlobalSymbolTable, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IReferenceWithGlobalSymbolTable, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IReferenceWithQualifier, JetBrains.ReSharper.Psi.Resolve.ICompleteableReference, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.Util.IUserDataHolder
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.ITypeElement GetQualifierTypeElement();
    }
    public interface IHtmlCompleteableReference : JetBrains.ReSharper.Psi.Resolve.ICompleteableReference, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.Util.IUserDataHolder { }
    public interface IHtmlImportCompleteableReference : JetBrains.ReSharper.Psi.Html.References.IHtmlCompleteableReference, JetBrains.ReSharper.Psi.Resolve.ICompleteableReference, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.Util.IUserDataHolder { }
    public interface IHtmlImportTypeCompleteableReference : JetBrains.ReSharper.Psi.Html.References.IHtmlCompleteableReference, JetBrains.ReSharper.Psi.Html.References.IHtmlImportCompleteableReference, JetBrains.ReSharper.Psi.Resolve.ICompleteableReference, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.Util.IUserDataHolder
    {
        JetBrains.ReSharper.Psi.IDeclaredElement GetQualifierDeclaredElement();
    }
    public interface IHtmlPathReference : JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IQualifiableReferenceBase, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IQualifiableReferenceWithGlobalSymbolTable, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IReferenceWithGlobalSymbolTable, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IReferenceWithQualifier, JetBrains.ReSharper.Psi.Resolve.ICompleteableReference, JetBrains.ReSharper.Psi.Resolve.IPathReference, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.Util.IUserDataHolder { }
    public interface IHtmlReferenceToId : JetBrains.ReSharper.Psi.Html.References.IHtmlCompleteableReference, JetBrains.ReSharper.Psi.Resolve.ICompleteableReference, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.Util.IUserDataHolder { }
    public interface IHtmlReferenceWithCustomData
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        object CustomData { get; }
    }
    public interface IHtmlSmartCompleteableReference : JetBrains.ReSharper.Psi.Html.References.IHtmlCompleteableReference, JetBrains.ReSharper.Psi.Resolve.ICompleteableReference, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.Util.IUserDataHolder
    {
        JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetSmartCompletionSymbolTable();
    }
    public interface IHtmlTagReference : JetBrains.ReSharper.Psi.Html.Impl.References.IQualifierReference, JetBrains.ReSharper.Psi.Html.References.IHtmlCompleteableReference, JetBrains.ReSharper.Psi.Html.References.IHtmlSmartCompleteableReference, JetBrains.ReSharper.Psi.Resolve.ICompleteableReference, JetBrains.ReSharper.Psi.Resolve.IQualifier, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.Util.IUserDataHolder
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Html.Tree.IHtmlTag GetHtmlTag();
    }
    public class PathQualifier : JetBrains.ReSharper.Psi.Web.References.PathQualifier
    {
        public PathQualifier([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IProject project, string qualifierPath) { }
    }
}
namespace JetBrains.ReSharper.Psi.Html.Resources
{
    
    public sealed class PsiHtmlThemedIcons
    {
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Psi.Html;component/resources/PsiHtmlThemedIcons/ThemedIcons.P" +
            "siHtml.Generated.Xaml", 0, "Html")]
        public sealed class Html : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Psi.Html;component/resources/PsiHtmlThemedIcons/ThemedIcons.P" +
            "siHtml.Generated.Xaml", 4, "HtmlTag")]
        public sealed class HtmlTag : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Psi.Html;component/resources/PsiHtmlThemedIcons/ThemedIcons.P" +
            "siHtml.Generated.Xaml", 2, "HtmlTagAttribute")]
        public sealed class HtmlTagAttribute : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Psi.Html;component/resources/PsiHtmlThemedIcons/ThemedIcons.P" +
            "siHtml.Generated.Xaml", 3, "HtmlTagAttributeValue")]
        public sealed class HtmlTagAttributeValue : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Psi.Html;component/resources/PsiHtmlThemedIcons/ThemedIcons.P" +
            "siHtml.Generated.Xaml", 1, "HtmlTagId")]
        public sealed class HtmlTagId : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
    }
}
namespace JetBrains.ReSharper.Psi.Html.Settings
{
    
    [JetBrains.Application.ShellComponentAttribute()]
    public class PredefinedWebSettings : JetBrains.Application.Settings.IHaveDefaultSettingsStream { }
    [JetBrains.Application.Settings.SettingsKeyAttribute(typeof(JetBrains.ReSharper.Settings.CodeEditingSettings), "Web settings", KeyNameOverride="Web")]
    public class WebSettings
    {
        [JetBrains.Application.Settings.SettingsIndexedEntryAttribute("JavaScript templates MIME types")]
        public JetBrains.Application.Settings.Store.IIndexedEntry<string, bool> TemplateMimeTypes;
    }
    public class static WebSettingsAccessor
    {
        public static readonly System.Linq.Expressions.Expression<System.Func<JetBrains.ReSharper.Psi.Html.Settings.WebSettings, JetBrains.Application.Settings.Store.IIndexedEntry<string, bool>>> TemplateMimeTypes;
    }
}
namespace JetBrains.ReSharper.Psi.Html.Symbols
{
    
    public interface IHtmlClassSymbol : JetBrains.ReSharper.Psi.Web.Symbols.IWebClassSymbol, JetBrains.ReSharper.Psi.Web.Symbols.IWebSymbol { }
    public interface IHtmlTagIdSymbol : JetBrains.ReSharper.Psi.Web.Symbols.IWebSymbol, JetBrains.ReSharper.Psi.Web.Symbols.IWebTagIdSymbol { }
}
namespace JetBrains.ReSharper.Psi.Html.Tree
{
    
    public class static HtmlConditionalIfEx
    {
        public static bool ShouldBeTreatedAsAComment(this JetBrains.ReSharper.Psi.Html.Tree.IHtmlConditionalIf @if) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.Html.HtmlLanguage))]
    public class HtmlElementTypes
    {
        public readonly JetBrains.ReSharper.Psi.Html.Tree.HtmlElementTypes.HTML_TAG_ATTRIBUTE_NAME_NODE_TYPE HTML_ATTRIBUTE_NAME;
        public readonly JetBrains.ReSharper.Psi.Html.Tree.HtmlElementTypes.HTML_CDATA_NODE_TYPE HTML_CDATA;
        public readonly JetBrains.ReSharper.Psi.Html.Tree.HtmlElementTypes.HTML_COMMENT_NODE_TYPE HTML_COMMENT;
        public readonly JetBrains.ReSharper.Psi.Html.Tree.HtmlElementTypes.HTML_CONDITIONAL_BINARY_EXPR_NODE_TYPE HTML_CONDITIONAL_BINARY_EXPR;
        public readonly JetBrains.ReSharper.Psi.Html.Tree.HtmlElementTypes.HTML_CONDITIONAL_COMMENT_NODE_TYPE HTML_CONDITIONAL_COMMENT;
        public readonly JetBrains.ReSharper.Psi.Html.Tree.HtmlElementTypes.HTML_CONDITIONAL_CONST_EXPR_NODE_TYPE HTML_CONDITIONAL_CONST_EXPR;
        public readonly JetBrains.ReSharper.Psi.Html.Tree.HtmlElementTypes.HTML_CONDITIONAL_ENDIF_NODE_TYPE HTML_CONDITIONAL_ENDIF;
        public readonly JetBrains.ReSharper.Psi.Html.Tree.HtmlElementTypes.HTML_CONDITIONAL_IF_NODE_TYPE HTML_CONDITIONAL_IF;
        public readonly JetBrains.ReSharper.Psi.Html.Tree.HtmlElementTypes.HTML_CONDITIONAL_PARENTH_EXPR_NODE_TYPE HTML_CONDITIONAL_PARENTH_EXPR;
        public readonly JetBrains.ReSharper.Psi.Html.Tree.HtmlElementTypes.HTML_CONDITIONAL_SIMPLE_EXPR_NODE_TYPE HTML_CONDITIONAL_SIMPLE_EXPR;
        public readonly JetBrains.ReSharper.Psi.Html.Tree.HtmlElementTypes.HTML_CONDITIONAL_UNARY_EXPR_NODE_TYPE HTML_CONDITIONAL_UNARY_EXPR;
        public readonly JetBrains.ReSharper.Psi.Html.Tree.HtmlElementTypes.HTML_DOCTYPE_NODE_TYPE HTML_DOCTYPE;
        public readonly JetBrains.ReSharper.Psi.Html.Tree.HtmlElementTypes.ERROR_NODE_TYPE HTML_ERROR;
        public readonly JetBrains.ReSharper.Psi.Html.Tree.HtmlElementTypes.HTML_FILE_NODE_TYPE HTML_FILE;
        public readonly JetBrains.ReSharper.Psi.Html.Tree.HtmlElementTypes.HTML_HEADER_NODE_TYPE HTML_HEADER;
        public readonly JetBrains.ReSharper.Psi.Html.Tree.HtmlElementTypes.HTML_INCLUDE_NODE_TYPE HTML_INCLUDE;
        public readonly JetBrains.ReSharper.Psi.Html.Tree.HtmlElementTypes.HTML_INCLUDE_END_NODE_TYPE HTML_INCLUDE_END;
        public readonly JetBrains.ReSharper.Psi.Html.Tree.HtmlElementTypes.HTML_PI_NODE_TYPE HTML_PI;
        public readonly JetBrains.ReSharper.Psi.Html.Tree.HtmlElementTypes.HTML_PI_ATTRIBUTE_NODE_TYPE HTML_PI_ATTRIBUTE;
        public readonly JetBrains.ReSharper.Psi.Html.Tree.HtmlElementTypes.HTML_SCRIPT_TAG_NODE_TYPE HTML_SCRIPT_TAG;
        public readonly JetBrains.ReSharper.Psi.Html.Tree.HtmlElementTypes.HTML_XMLNS_TAG_ATTRIBUTE_NODE_TYPE HTML_XMLNS_TAG_ATTRIBUTE;
        public HtmlElementTypes(JetBrains.ReSharper.Psi.Html.Parsing.IHtmlTokenNodeTypes tokenTypes) { }
        public JetBrains.ReSharper.Psi.Html.Tree.HtmlElementTypes.HTML_TAG_ATTRIBUTE_VALUE_NODE_TYPE ATTRIBUTE_VALUE { get; set; }
        public JetBrains.ReSharper.Psi.Html.Tree.HtmlElementTypes.HTML_TAG_NODE_TYPE TAG { get; set; }
        public JetBrains.ReSharper.Psi.Html.Tree.HtmlElementTypes.HTML_TAG_ATTRIBUTE_NODE_TYPE TAG_ATTRIBUTE { get; set; }
        public JetBrains.ReSharper.Psi.Html.Tree.HtmlElementTypes.HTML_TAG_FOOTER_NODE_TYPE TAG_FOOTER { get; set; }
        public JetBrains.ReSharper.Psi.Html.Tree.HtmlElementTypes.HTML_TAG_HEADER_NODE_TYPE TAG_HEADER { get; set; }
        public class ERROR_NODE_TYPE : JetBrains.ReSharper.Psi.Html.Tree.HtmlElementTypes.HtmlCompositeNodeType<JetBrains.ReSharper.Psi.Html.Impl.Tree.HtmlErrorElement>
        {
            public ERROR_NODE_TYPE(JetBrains.ReSharper.Psi.Html.Parsing.IHtmlTokenNodeTypes tokenTypes, int index) { }
            public override JetBrains.ReSharper.Psi.Html.Impl.Tree.HtmlErrorElement Create() { }
            public JetBrains.ReSharper.Psi.Html.Impl.Tree.HtmlErrorElement Create(string errorDescription) { }
        }
        public class HTML_CDATA_NODE_TYPE : JetBrains.ReSharper.Psi.Html.Tree.HtmlElementTypes.HtmlCompositeNodeType<JetBrains.ReSharper.Psi.Html.Impl.Tree.HtmlCData>
        {
            public HTML_CDATA_NODE_TYPE(JetBrains.ReSharper.Psi.Html.Parsing.IHtmlTokenNodeTypes tokenTypes, int index) { }
            public override JetBrains.ReSharper.Psi.Html.Impl.Tree.HtmlCData Create() { }
        }
        public class HTML_COMMENT_NODE_TYPE : JetBrains.ReSharper.Psi.Html.Tree.HtmlElementTypes.HtmlCompositeNodeType<JetBrains.ReSharper.Psi.Html.Impl.Tree.HtmlComment>
        {
            public HTML_COMMENT_NODE_TYPE(JetBrains.ReSharper.Psi.Html.Parsing.IHtmlTokenNodeTypes tokenTypes, int index) { }
            public override JetBrains.ReSharper.Psi.Html.Impl.Tree.HtmlComment Create() { }
        }
        public class HTML_CONDITIONAL_BINARY_EXPR_NODE_TYPE : JetBrains.ReSharper.Psi.Html.Tree.HtmlElementTypes.HtmlCompositeNodeType<JetBrains.ReSharper.Psi.Html.Impl.Tree.HtmlConditionalBinaryExpression>
        {
            public HTML_CONDITIONAL_BINARY_EXPR_NODE_TYPE(JetBrains.ReSharper.Psi.Html.Parsing.IHtmlTokenNodeTypes tokenTypes, int index) { }
            public override JetBrains.ReSharper.Psi.Html.Impl.Tree.HtmlConditionalBinaryExpression Create() { }
        }
        public class HTML_CONDITIONAL_COMMENT_NODE_TYPE : JetBrains.ReSharper.Psi.Html.Tree.HtmlElementTypes.HtmlCompositeNodeType<JetBrains.ReSharper.Psi.Html.Impl.Tree.HtmlConditionalComment>
        {
            public HTML_CONDITIONAL_COMMENT_NODE_TYPE(JetBrains.ReSharper.Psi.Html.Parsing.IHtmlTokenNodeTypes tokenTypes, int index) { }
            public override JetBrains.ReSharper.Psi.Html.Impl.Tree.HtmlConditionalComment Create() { }
        }
        public class HTML_CONDITIONAL_CONST_EXPR_NODE_TYPE : JetBrains.ReSharper.Psi.Html.Tree.HtmlElementTypes.HtmlCompositeNodeType<JetBrains.ReSharper.Psi.Html.Impl.Tree.HtmlConditionalConstantExpression>
        {
            public HTML_CONDITIONAL_CONST_EXPR_NODE_TYPE(JetBrains.ReSharper.Psi.Html.Parsing.IHtmlTokenNodeTypes tokenTypes, int index) { }
            public override JetBrains.ReSharper.Psi.Html.Impl.Tree.HtmlConditionalConstantExpression Create() { }
        }
        public class HTML_CONDITIONAL_ENDIF_NODE_TYPE : JetBrains.ReSharper.Psi.Html.Tree.HtmlElementTypes.HtmlCompositeNodeType<JetBrains.ReSharper.Psi.Html.Impl.Tree.HtmlConditionalEndIf>
        {
            public HTML_CONDITIONAL_ENDIF_NODE_TYPE(JetBrains.ReSharper.Psi.Html.Parsing.IHtmlTokenNodeTypes tokenTypes, int index) { }
            public override JetBrains.ReSharper.Psi.Html.Impl.Tree.HtmlConditionalEndIf Create() { }
        }
        public class HTML_CONDITIONAL_IF_NODE_TYPE : JetBrains.ReSharper.Psi.Html.Tree.HtmlElementTypes.HtmlCompositeNodeType<JetBrains.ReSharper.Psi.Html.Impl.Tree.HtmlConditionalIf>
        {
            public HTML_CONDITIONAL_IF_NODE_TYPE(JetBrains.ReSharper.Psi.Html.Parsing.IHtmlTokenNodeTypes tokenTypes, int index) { }
            public override JetBrains.ReSharper.Psi.Html.Impl.Tree.HtmlConditionalIf Create() { }
        }
        public class HTML_CONDITIONAL_PARENTH_EXPR_NODE_TYPE : JetBrains.ReSharper.Psi.Html.Tree.HtmlElementTypes.HtmlCompositeNodeType<JetBrains.ReSharper.Psi.Html.Impl.Tree.HtmlConditionalParenthisizedExpression>
        {
            public HTML_CONDITIONAL_PARENTH_EXPR_NODE_TYPE(JetBrains.ReSharper.Psi.Html.Parsing.IHtmlTokenNodeTypes tokenTypes, int index) { }
            public override JetBrains.ReSharper.Psi.Html.Impl.Tree.HtmlConditionalParenthisizedExpression Create() { }
        }
        public class HTML_CONDITIONAL_SIMPLE_EXPR_NODE_TYPE : JetBrains.ReSharper.Psi.Html.Tree.HtmlElementTypes.HtmlCompositeNodeType<JetBrains.ReSharper.Psi.Html.Impl.Tree.HtmlConditionalExistOrEqualExpression>
        {
            public HTML_CONDITIONAL_SIMPLE_EXPR_NODE_TYPE(JetBrains.ReSharper.Psi.Html.Parsing.IHtmlTokenNodeTypes tokenTypes, int index) { }
            public override JetBrains.ReSharper.Psi.Html.Impl.Tree.HtmlConditionalExistOrEqualExpression Create() { }
        }
        public class HTML_CONDITIONAL_UNARY_EXPR_NODE_TYPE : JetBrains.ReSharper.Psi.Html.Tree.HtmlElementTypes.HtmlCompositeNodeType<JetBrains.ReSharper.Psi.Html.Impl.Tree.HtmlConditionalUnaryExpression>
        {
            public HTML_CONDITIONAL_UNARY_EXPR_NODE_TYPE(JetBrains.ReSharper.Psi.Html.Parsing.IHtmlTokenNodeTypes tokenTypes, int index) { }
            public override JetBrains.ReSharper.Psi.Html.Impl.Tree.HtmlConditionalUnaryExpression Create() { }
        }
        public class HTML_DOCTYPE_NODE_TYPE : JetBrains.ReSharper.Psi.Html.Tree.HtmlElementTypes.HtmlCompositeNodeType<JetBrains.ReSharper.Psi.Html.Impl.Tree.HtmlDocType>
        {
            public HTML_DOCTYPE_NODE_TYPE(JetBrains.ReSharper.Psi.Html.Parsing.IHtmlTokenNodeTypes tokenTypes, int index) { }
            public override JetBrains.ReSharper.Psi.Html.Impl.Tree.HtmlDocType Create() { }
        }
        public class HTML_FILE_NODE_TYPE : JetBrains.ReSharper.Psi.Html.Tree.HtmlElementTypes.HtmlCompositeNodeType<JetBrains.ReSharper.Psi.Html.Impl.Tree.HtmlFile>
        {
            public HTML_FILE_NODE_TYPE(JetBrains.ReSharper.Psi.Html.Parsing.IHtmlTokenNodeTypes tokenTypes, int index) { }
            public override JetBrains.ReSharper.Psi.Html.Impl.Tree.HtmlFile Create() { }
        }
        public class HTML_HEADER_NODE_TYPE : JetBrains.ReSharper.Psi.Html.Tree.HtmlElementTypes.HtmlCompositeNodeType<JetBrains.ReSharper.Psi.Html.Impl.Tree.HtmlHeader>
        {
            public HTML_HEADER_NODE_TYPE(JetBrains.ReSharper.Psi.Html.Parsing.IHtmlTokenNodeTypes tokenTypes, int index) { }
            public override JetBrains.ReSharper.Psi.Html.Impl.Tree.HtmlHeader Create() { }
        }
        public class HTML_INCLUDE_END_NODE_TYPE : JetBrains.ReSharper.Psi.Html.Tree.HtmlElementTypes.HtmlCompositeNodeType<JetBrains.ReSharper.Psi.Html.Impl.Tree.HtmlIncludeEnd>
        {
            public HTML_INCLUDE_END_NODE_TYPE(JetBrains.ReSharper.Psi.Html.Parsing.IHtmlTokenNodeTypes tokenTypes, int index) { }
            public override JetBrains.ReSharper.Psi.Html.Impl.Tree.HtmlIncludeEnd Create() { }
        }
        public class HTML_INCLUDE_NODE_TYPE : JetBrains.ReSharper.Psi.Html.Tree.HtmlElementTypes.HtmlCompositeNodeType<JetBrains.ReSharper.Psi.Html.Impl.Tree.HtmlInclude>
        {
            public HTML_INCLUDE_NODE_TYPE(JetBrains.ReSharper.Psi.Html.Parsing.IHtmlTokenNodeTypes tokenTypes, int index) { }
            public override JetBrains.ReSharper.Psi.Html.Impl.Tree.HtmlInclude Create() { }
        }
        public class HTML_PI_ATTRIBUTE_NODE_TYPE : JetBrains.ReSharper.Psi.Html.Tree.HtmlElementTypes.HtmlCompositeNodeType<JetBrains.ReSharper.Psi.Html.Impl.Tree.HtmlPiAttribute>
        {
            public HTML_PI_ATTRIBUTE_NODE_TYPE(JetBrains.ReSharper.Psi.Html.Parsing.IHtmlTokenNodeTypes tokenTypes, int index) { }
            public override JetBrains.ReSharper.Psi.Html.Impl.Tree.HtmlPiAttribute Create() { }
        }
        public class HTML_PI_NODE_TYPE : JetBrains.ReSharper.Psi.Html.Tree.HtmlElementTypes.HtmlCompositeNodeType<JetBrains.ReSharper.Psi.Html.Impl.Tree.HtmlPi>
        {
            public HTML_PI_NODE_TYPE(JetBrains.ReSharper.Psi.Html.Parsing.IHtmlTokenNodeTypes tokenTypes, int index) { }
            public override JetBrains.ReSharper.Psi.Html.Impl.Tree.HtmlPi Create() { }
        }
        public class HTML_SCRIPT_TAG_NODE_TYPE : JetBrains.ReSharper.Psi.Html.Tree.HtmlElementTypes.HtmlCompositeNodeType<JetBrains.ReSharper.Psi.Html.Impl.Tree.ScriptTag>
        {
            public HTML_SCRIPT_TAG_NODE_TYPE(JetBrains.ReSharper.Psi.Html.Parsing.IHtmlTokenNodeTypes tokenTypes, int index) { }
            public override JetBrains.ReSharper.Psi.Html.Impl.Tree.ScriptTag Create() { }
        }
        public class HTML_TAG_ATTRIBUTE_NAME_NODE_TYPE : JetBrains.ReSharper.Psi.Html.Tree.HtmlElementTypes.HtmlCompositeNodeType<JetBrains.ReSharper.Psi.Html.Impl.Tree.HtmlAttributeName>
        {
            public HTML_TAG_ATTRIBUTE_NAME_NODE_TYPE(JetBrains.ReSharper.Psi.Html.Parsing.IHtmlTokenNodeTypes tokenTypes, int index) { }
            public override JetBrains.ReSharper.Psi.Html.Impl.Tree.HtmlAttributeName Create() { }
        }
        public class HTML_TAG_ATTRIBUTE_NODE_TYPE : JetBrains.ReSharper.Psi.Html.Tree.HtmlElementTypes.HtmlCompositeNodeType<JetBrains.ReSharper.Psi.Html.Impl.Tree.TagAttribute>
        {
            public HTML_TAG_ATTRIBUTE_NODE_TYPE(JetBrains.ReSharper.Psi.Html.Parsing.IHtmlTokenNodeTypes tokenTypes, int index) { }
            protected HTML_TAG_ATTRIBUTE_NODE_TYPE(string s, JetBrains.ReSharper.Psi.Html.Parsing.IHtmlTokenNodeTypes tokenTypes, int index) { }
            public override JetBrains.ReSharper.Psi.Html.Impl.Tree.TagAttribute Create() { }
        }
        public class HTML_TAG_ATTRIBUTE_VALUE_NODE_TYPE : JetBrains.ReSharper.Psi.Html.Tree.HtmlElementTypes.HtmlCompositeNodeType<JetBrains.ReSharper.Psi.Html.Impl.Tree.HtmlAttributeValue>
        {
            public HTML_TAG_ATTRIBUTE_VALUE_NODE_TYPE(JetBrains.ReSharper.Psi.Html.Parsing.IHtmlTokenNodeTypes tokenTypes, int index) { }
            protected HTML_TAG_ATTRIBUTE_VALUE_NODE_TYPE(string s, JetBrains.ReSharper.Psi.Html.Parsing.IHtmlTokenNodeTypes tokenTypes, int index) { }
            public override JetBrains.ReSharper.Psi.Html.Impl.Tree.HtmlAttributeValue Create() { }
        }
        public class HTML_TAG_FOOTER_NODE_TYPE : JetBrains.ReSharper.Psi.Html.Tree.HtmlElementTypes.HtmlCompositeNodeType<JetBrains.ReSharper.Psi.Html.Impl.Tree.HtmlTagFooter>
        {
            public HTML_TAG_FOOTER_NODE_TYPE(JetBrains.ReSharper.Psi.Html.Parsing.IHtmlTokenNodeTypes tokenTypes, int index) { }
            protected HTML_TAG_FOOTER_NODE_TYPE(string s, JetBrains.ReSharper.Psi.Html.Parsing.IHtmlTokenNodeTypes tokenTypes, int index) { }
            public override JetBrains.ReSharper.Psi.Html.Impl.Tree.HtmlTagFooter Create() { }
        }
        public class HTML_TAG_HEADER_NODE_TYPE : JetBrains.ReSharper.Psi.Html.Tree.HtmlElementTypes.HtmlCompositeNodeType<JetBrains.ReSharper.Psi.Html.Impl.Tree.HtmlTagHeader>
        {
            public HTML_TAG_HEADER_NODE_TYPE(JetBrains.ReSharper.Psi.Html.Parsing.IHtmlTokenNodeTypes tokenTypes, int index) { }
            protected HTML_TAG_HEADER_NODE_TYPE(string s, JetBrains.ReSharper.Psi.Html.Parsing.IHtmlTokenNodeTypes tokenTypes, int index) { }
            public override JetBrains.ReSharper.Psi.Html.Impl.Tree.HtmlTagHeader Create() { }
        }
        public class HTML_TAG_NODE_TYPE : JetBrains.ReSharper.Psi.Html.Tree.HtmlElementTypes.HtmlCompositeNodeType<JetBrains.ReSharper.Psi.Html.Impl.Tree.HtmlTag>
        {
            public HTML_TAG_NODE_TYPE(JetBrains.ReSharper.Psi.Html.Parsing.IHtmlTokenNodeTypes tokenTypes, int index) { }
            protected HTML_TAG_NODE_TYPE(string s, JetBrains.ReSharper.Psi.Html.Parsing.IHtmlTokenNodeTypes tokenTypes, int index) { }
            public override JetBrains.ReSharper.Psi.Html.Impl.Tree.HtmlTag Create() { }
        }
        public class HTML_XMLNS_TAG_ATTRIBUTE_NODE_TYPE : JetBrains.ReSharper.Psi.Html.Tree.HtmlElementTypes.HTML_TAG_ATTRIBUTE_NODE_TYPE
        {
            public HTML_XMLNS_TAG_ATTRIBUTE_NODE_TYPE(JetBrains.ReSharper.Psi.Html.Parsing.IHtmlTokenNodeTypes tokenTypes, int index) { }
            public override JetBrains.ReSharper.Psi.Html.Impl.Tree.TagAttribute Create() { }
        }
        public abstract class HtmlCompositeNodeType<T> : JetBrains.ReSharper.Psi.Html.Tree.HtmlElementTypes.HtmlCompositeNodeType<T, JetBrains.ReSharper.Psi.Html.Parsing.IHtmlTokenNodeTypes>
            where T : JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeElement
        {
            protected HtmlCompositeNodeType(string s, JetBrains.ReSharper.Psi.Html.Parsing.IHtmlTokenNodeTypes tokenTypes, int index) { }
        }
        public abstract class HtmlCompositeNodeType<T, TTokenNodeTypes> : JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType<T>
            where T : JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeElement
            where TTokenNodeTypes : JetBrains.ReSharper.Psi.Html.Parsing.IHtmlTokenNodeTypes
        {
            protected readonly TTokenNodeTypes myTokenTypes;
            protected HtmlCompositeNodeType(string s, TTokenNodeTypes tokenTypes, int index) { }
        }
    }
    public class static HtmlTagExtensions
    {
        public static string GetNonEmptyAttributeValue([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Html.Tree.IHtmlTag tag, [JetBrains.Annotations.NotNullAttribute()] string attributeName) { }
    }
    public enum HtmlTagType
    {
        HTML = 0,
        ASP_CONTROL = 1,
        CUSTOM_CONTROL = 2,
        UNKNOWN = 3,
    }
    public enum HtmlTagType2 : short
    {
        HTML = 0,
        CONTROL = 1,
        PROPERTY = 2,
        UNKNOWN = 3,
    }
    public abstract class HtmlTreeVisitor<TContext, TReturn>
    
    
    {
        protected HtmlTreeVisitor() { }
        public void AddVisitorForInheritedLanguage(JetBrains.ReSharper.Psi.Html.Tree.IInheritedLanguageHtmlTreeVisitor<TContext, TReturn> visitor) { }
        public T GetVisitorForInheritedLanguage<T>()
            where T :  class, JetBrains.ReSharper.Psi.Html.Tree.IInheritedLanguageHtmlTreeVisitor<, > { }
        public virtual TReturn VisitComment(JetBrains.ReSharper.Psi.Html.Tree.IWebComment node, TContext context) { }
        public virtual TReturn VisitErrorElement(JetBrains.ReSharper.Psi.Html.Tree.IHtmlErrorElement node, TContext context) { }
        public virtual TReturn VisitHeader(JetBrains.ReSharper.Psi.Html.Tree.IHtmlHeader node, TContext context) { }
        public virtual TReturn VisitHtmlAttributeName(JetBrains.ReSharper.Psi.Html.Tree.IHtmlAttributeName node, TContext context) { }
        public virtual TReturn VisitHtmlAttributeValue(JetBrains.ReSharper.Psi.Html.Tree.IHtmlAttributeValue node, TContext context) { }
        public virtual TReturn VisitHtmlCData(JetBrains.ReSharper.Psi.Html.Tree.IHtmlCData node, TContext context) { }
        public virtual TReturn VisitHtmlComment(JetBrains.ReSharper.Psi.Html.Tree.IHtmlComment node, TContext context) { }
        public virtual TReturn VisitHtmlConditionalComment(JetBrains.ReSharper.Psi.Html.Tree.IHtmlConditionalComment node, TContext context) { }
        public virtual TReturn VisitHtmlConditionalExpression(JetBrains.ReSharper.Psi.Html.Tree.IHtmlConditionalExpression node, TContext context) { }
        public virtual TReturn VisitHtmlConditionalStruct(JetBrains.ReSharper.Psi.Html.Tree.IHtmlConditionalStruct node, TContext context) { }
        public virtual TReturn VisitHtmlDocType(JetBrains.ReSharper.Psi.Html.Tree.IHtmlDocType node, TContext context) { }
        public virtual TReturn VisitHtmlFile(JetBrains.ReSharper.Psi.Html.Tree.IHtmlFile node, TContext context) { }
        public virtual TReturn VisitHtmlInclude(JetBrains.ReSharper.Psi.Html.Tree.IHtmlInclude node, TContext context) { }
        public virtual TReturn VisitHtmlIncludeEnd(JetBrains.ReSharper.Psi.Html.Tree.IHtmlIncludeEnd node, TContext context) { }
        public virtual TReturn VisitHtmlTag(JetBrains.ReSharper.Psi.Html.Tree.IHtmlTag node, TContext context) { }
        public virtual TReturn VisitHtmlTagContainer(JetBrains.ReSharper.Psi.Html.Tree.IHtmlTagContainer node, TContext context) { }
        public virtual TReturn VisitNode(JetBrains.ReSharper.Psi.Tree.ITreeNode node, TContext context) { }
        public virtual TReturn VisitTagAttribute(JetBrains.ReSharper.Psi.Html.Tree.ITagAttribute node, TContext context) { }
        public virtual TReturn VisitTagFooter(JetBrains.ReSharper.Psi.Html.Tree.IHtmlTagFooter node, TContext context) { }
        public virtual TReturn VisitTagHeader(JetBrains.ReSharper.Psi.Html.Tree.IHtmlTagHeader node, TContext context) { }
        public virtual TReturn VisitTokenNode(JetBrains.ReSharper.Psi.Html.Tree.IHtmlToken node, TContext context) { }
        public virtual TReturn VisitWebAttribute(JetBrains.ReSharper.Psi.Web.Tree.IWebAttribute node, TContext context) { }
        public virtual TReturn VisitWebAttributeContainer<TAttribute>(JetBrains.ReSharper.Psi.Web.Tree.IWebAttributeContainer<TAttribute> node, TContext context)
            where TAttribute :  class, JetBrains.ReSharper.Psi.Web.Tree.IWebAttribute { }
    }
    public interface IHtmlAttributeName : JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode
    {
        string Name { get; }
        JetBrains.ReSharper.Psi.Html.Tree.IHtmlToken NameToken { get; }
    }
    public interface IHtmlAttributeValue : JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Html.Tree.IHtmlToken LeadingQuote { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Html.Tree.IHtmlToken TrailingQuote { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        string UnquotedValue { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        string UnquotedValueWithEmbeds { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode> ValueElements { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Html.Tree.IHtmlToken ValueToken { get; }
    }
    public interface IHtmlCData : JetBrains.ReSharper.Psi.Html.Tree.IHtmlTagContainer, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTagContainerMarker, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode { }
    public interface IHtmlComment : JetBrains.ReSharper.Psi.Html.Tree.IHtmlTagContainer, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTagContainerMarker, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode, JetBrains.ReSharper.Psi.Html.Tree.IWebComment, JetBrains.ReSharper.Psi.Tree.IComment, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode { }
    public interface IHtmlConditionalBinaryExpression : JetBrains.ReSharper.Psi.Html.Tree.IHtmlConditionalExpression, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode
    {
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Html.Tree.IHtmlToken BinaryOp { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Html.Tree.IHtmlConditionalExpression LeftExpression { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Html.Tree.IHtmlConditionalExpression RightExpression { get; }
    }
    public interface IHtmlConditionalComment : JetBrains.ReSharper.Psi.Html.Tree.IHtmlTagContainer, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTagContainerMarker, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode, JetBrains.ReSharper.Psi.Html.Tree.IWebComment, JetBrains.ReSharper.Psi.Tree.IComment, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Html.Tree.IHtmlConditionalEndIf EndIf { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Html.Tree.IHtmlConditionalIf If { get; }
    }
    public interface IHtmlConditionalConstantExpression : JetBrains.ReSharper.Psi.Html.Tree.IHtmlConditionalExpression, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode
    {
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Html.Tree.IHtmlToken ConstantNode { get; }
    }
    public interface IHtmlConditionalEndIf : JetBrains.ReSharper.Psi.Html.Tree.IHtmlConditionalStruct, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode
    {
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Html.Tree.IHtmlToken EndIfToken { get; }
    }
    public interface IHtmlConditionalExistOrEqualExpression : JetBrains.ReSharper.Psi.Html.Tree.IHtmlConditionalExpression, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode
    {
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Html.Tree.IHtmlToken Identifier { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Html.Tree.IHtmlConditionalExpression RightExpression { get; }
    }
    public interface IHtmlConditionalExpression : JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode { }
    public interface IHtmlConditionalIf : JetBrains.ReSharper.Psi.Html.Tree.IHtmlConditionalStruct, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Html.Tree.IHtmlConditionalExpression ConditionalExpression { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Html.Tree.IHtmlToken IfToken { get; }
    }
    public interface IHtmlConditionalParenthesizedExpresion : JetBrains.ReSharper.Psi.Html.Tree.IHtmlConditionalExpression, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Html.Tree.IHtmlConditionalExpression Expression { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Html.Tree.IHtmlToken LParenth { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Html.Tree.IHtmlToken RParenth { get; }
    }
    public interface IHtmlConditionalStruct : JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Html.Tree.IHtmlToken EndToken { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Html.Tree.IHtmlToken StartToken { get; }
    }
    public interface IHtmlConditionalUnaryExpression : JetBrains.ReSharper.Psi.Html.Tree.IHtmlConditionalExpression, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Html.Tree.IHtmlConditionalExpression Expression { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Html.Tree.IHtmlToken UnaryOp { get; }
    }
    public interface IHtmlDocType : JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode
    {
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Html.Tree.IHtmlAttributeValue> Attributes { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Html.Tree.IHtmlToken EndToken { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        string Root { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Html.Tree.IHtmlToken StartToken { get; }
    }
    public interface IHtmlErrorElement : JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode
    {
        string ErrorDescription { get; }
    }
    public interface IHtmlFile : JetBrains.ReSharper.Psi.Html.Tree.IHtmlTagContainer, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTagContainerMarker, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode, JetBrains.ReSharper.Psi.Tree.IFile, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebFile, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Html.Tree.IHtmlDocType DocType { get; }
        JetBrains.Util.OneToSetMap<JetBrains.Util.FileSystemPath, JetBrains.Util.FileSystemPath> ImmediateIncludes { get; }
        System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.Html.Tree.IHtmlPi> ProcessingInstructions { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Tree.IFile ReParseGeneratedFile(JetBrains.ReSharper.Psi.TreeTextRange modifiedRange, string text);
    }
    public interface IHtmlHeader : JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Html.Tree.IHtmlToken EndToken { get; }
        string Name { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Html.Tree.IHtmlToken NameToken { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Html.Tree.IHtmlToken StartToken { get; }
    }
    public interface IHtmlInclude : JetBrains.ReSharper.Psi.Html.Tree.IHtmlIncludeEntry, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode
    {
        JetBrains.ReSharper.Psi.Html.Tree.IHtmlToken FilenameToken { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Html.Tree.IHtmlIncludeEnd IncludeEnd { get; }
        bool IsVirtual { get; }
        string ReferencedString { get; }
        JetBrains.Util.FileSystemPath ResolvedPath { get; }
    }
    public interface IHtmlIncludeEnd : JetBrains.ReSharper.Psi.Html.Tree.IHtmlIncludeEntry, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode
    {
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Html.Tree.IHtmlInclude IncludeStart { get; }
    }
    public interface IHtmlIncludeEntry : JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode { }
    public interface IHtmlPi : JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebAttributeContainer<JetBrains.ReSharper.Psi.Html.Tree.IHtmlPiAttribute>, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode
    {
        JetBrains.ReSharper.Psi.Html.Tree.IHtmlToken EndToken { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        string Name { get; }
        JetBrains.ReSharper.Psi.Html.Tree.IHtmlToken StartToken { get; }
    }
    public interface IHtmlPiAttribute : JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebAttribute, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Html.Tree.IHtmlToken EqToken { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Html.Tree.IHtmlAttributeName NameElement { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Html.Tree.IHtmlAttributeValue ValueElement { get; }
    }
    public interface IHtmlTag : JetBrains.ReSharper.Psi.Html.Tree.IHtmlTagContainer, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTagContainerMarker, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebAttributeContainer<JetBrains.ReSharper.Psi.Html.Tree.ITagAttribute>, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode
    {
        bool AllowSelfClose { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Html.Tree.IHtmlTagFooter Footer { get; }
        string FullTagName { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Html.Tree.IHtmlTagHeader Header { get; }
        bool IsSelfClosed { get; }
        bool ShouldBeEmpty { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        string TagName { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        string TagPrefix { get; }
        JetBrains.ReSharper.Psi.Html.Tree.HtmlTagType TagType { get; }
        JetBrains.ReSharper.Psi.Html.Tree.HtmlTagType2 TagType2 { get; }
        bool NameMatches(string tagName);
    }
    public interface IHtmlTagContainer : JetBrains.ReSharper.Psi.Html.Tree.IHtmlTagContainerMarker, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode
    {
        T AddTagAfter<T>([JetBrains.Annotations.NotNullAttribute()] T tag, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode anchor)
            where T :  class, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTagContainer;
        T AddTagBefore<T>([JetBrains.Annotations.NotNullAttribute()] T tag, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode anchor)
            where T :  class, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTagContainer;
        JetBrains.ReSharper.Psi.ITreeRange GetBodyRange();
        System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.Html.Tree.IHtmlTagContainer> GetInnerTagContainers();
        System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.Html.Tree.IHtmlTag> GetTags();
        void RemoveTag<T>([JetBrains.Annotations.NotNullAttribute()] T tag)
            where T :  class, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTagContainer;
    }
    public interface IHtmlTagContainerMarker : JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode { }
    public interface IHtmlTagFooter : JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode, JetBrains.ReSharper.Psi.Html.Tree.ITagNameContainer, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Html.Tree.IHtmlToken EndToken { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Html.Tree.IHtmlToken StartToken { get; }
    }
    public interface IHtmlTagHeader : JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode, JetBrains.ReSharper.Psi.Html.Tree.ITagNameContainer, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebAttributeContainer<JetBrains.ReSharper.Psi.Html.Tree.ITagAttribute>, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Html.Tree.IHtmlToken EndToken { get; }
        bool IsClosed { get; }
        bool IsSelfClosed { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Html.Tree.IHtmlToken StartToken { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Html.Tree.IHtmlAttributeValue GetAttributeValue(string attributeName);
    }
    public interface IHtmlToken : JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode, JetBrains.ReSharper.Psi.Tree.ITokenNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode
    {
        JetBrains.ReSharper.Psi.TreeTextRange GetUnquotedRangeWithin();
        string GetUnquotedText();
        JetBrains.ReSharper.Psi.TreeOffset GetUnquotedTreeStartOffset();
        JetBrains.ReSharper.Psi.TreeTextRange GetUnquotedTreeTextRange();
    }
    public interface IHtmlTreeNode : JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode
    {
        JetBrains.ReSharper.Psi.Html.Parsing.IHtmlTokenNodeTypes TokenTypes { get; }
        TReturn AcceptVisitor<TContext, TReturn>(JetBrains.ReSharper.Psi.Html.Tree.HtmlTreeVisitor<TContext, TReturn> visitor, TContext context);
    }
    public interface IInheritedLanguageHtmlTreeVisitor<TContext, TReturn> { }
    public interface IScriptTag : JetBrains.ReSharper.Psi.Html.Tree.IHtmlTag, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTagContainer, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTagContainerMarker, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebAttributeContainer<JetBrains.ReSharper.Psi.Html.Tree.ITagAttribute>, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.PsiLanguageType LanguageType { get; }
    }
    public interface ITagAttribute : JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebAttribute, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Html.Tree.IHtmlToken EqToken { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Html.Tree.IHtmlAttributeName NameElement { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Html.References.IHtmlAttributeReference Reference { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Html.Tree.IHtmlAttributeValue ValueElement { get; }
    }
    public interface ITagNameContainer : JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Html.Tree.IHtmlTag Tag { get; }
        string TagName { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Html.Tree.IHtmlToken TagNameToken { get; }
    }
    public interface IWebComment : JetBrains.ReSharper.Psi.Tree.IComment, JetBrains.ReSharper.Psi.Tree.ITreeNode { }
    public interface IXmlnsTagAttribute : JetBrains.ReSharper.Psi.ExtensionsAPI.Caches2.ICachedTypeMemberDeclaration, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode, JetBrains.ReSharper.Psi.Html.Tree.ITagAttribute, JetBrains.ReSharper.Psi.Tree.IDeclaration, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Tree.IXmlDocOwnerTreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebAttribute, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode
    {
        JetBrains.ReSharper.Psi.DeclaredElementType GetDeclaredElementType();
    }
    public class static TagAttributeExtensions
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public static string GetUnquotedValue([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Html.Tree.ITagAttribute attribute) { }
        public static JetBrains.DocumentModel.DocumentRange GetUnquotedValueDocumentRange([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Html.Tree.ITagAttribute attribute) { }
        public static JetBrains.ReSharper.Psi.TreeTextRange GetUnquotedValueTreeTextRange([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Html.Tree.ITagAttribute attribute) { }
        public static bool IsIdAttribute([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Html.Tree.ITagAttribute attribute) { }
        public static bool IsRunAtAttribute([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Html.Tree.ITagAttribute attribute) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Psi.Html.Html.IHtmlAttributeDeclaredElement ResolveAttribute([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Html.Tree.ITagAttribute attribute) { }
    }
    public class static TagNameContainerExtensions
    {
        public static JetBrains.DocumentModel.DocumentRange GetNameDocumentRange(this JetBrains.ReSharper.Psi.Html.Tree.ITagNameContainer tagNameContainer) { }
    }
}
namespace JetBrains.ReSharper.Psi.Html.Utils
{
    
    public class static HtmlAttributeContainerUtil
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public static TAttribute AddAttributeAfter<TContainer, TAttribute, TTokenTypes>([JetBrains.Annotations.NotNullAttribute()] TContainer container, [JetBrains.Annotations.NotNullAttribute()] TAttribute attribute, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode anchor, [JetBrains.Annotations.NotNullAttribute()] TTokenTypes tokenTypes)
            where TContainer :  class, JetBrains.ReSharper.Psi.Web.Tree.IWebAttributeContainer<>, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode
            where TAttribute :  class, JetBrains.ReSharper.Psi.Web.Tree.IWebAttribute
            where TTokenTypes : JetBrains.ReSharper.Psi.Html.Parsing.IHtmlTokenNodeTypes { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static TAttribute AddAttributeBefore<TContainer, TAttribute, TTokenTypes>([JetBrains.Annotations.NotNullAttribute()] TContainer container, [JetBrains.Annotations.NotNullAttribute()] TAttribute attribute, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode anchor, [JetBrains.Annotations.NotNullAttribute()] TTokenTypes tokenTypes)
            where TContainer :  class, JetBrains.ReSharper.Psi.Web.Tree.IWebAttributeContainer<>, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode
            where TAttribute :  class, JetBrains.ReSharper.Psi.Web.Tree.IWebAttribute
            where TTokenTypes : JetBrains.ReSharper.Psi.Html.Parsing.IHtmlTokenNodeTypes { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static string GetAttributeValue<T>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Web.Tree.IWebAttributeContainer<T> tag, [JetBrains.Annotations.NotNullAttribute()] string attributeName)
            where T :  class, JetBrains.ReSharper.Psi.Html.Tree.ITagAttribute { }
        public static void RemoveAttribute<T>([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Web.Tree.IWebAttributeContainer<T> container, [JetBrains.Annotations.NotNullAttribute()] T attribute)
            where T :  class, JetBrains.ReSharper.Psi.Web.Tree.IWebAttribute { }
    }
    public class static HtmlElementsMover
    {
        public static JetBrains.ReSharper.Psi.Html.Utils.IHtmlElementsMover StartMove([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Html.Tree.IHtmlFile htmlFile) { }
    }
    public class HtmlLeaveEolTreeRangeBuilder : JetBrains.ReSharper.Psi.Util.ITreeRangeBuilder
    {
        public bool IsWhitespaceTokenOrSpecialToken(JetBrains.ReSharper.Psi.Tree.ITreeNode node) { }
        public bool SupportsLanguage(JetBrains.ReSharper.Psi.PsiLanguageType language) { }
    }
    public class static HtmlModificationUtil
    {
        public static void AddAttributeToTagHeader([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Html.Tree.IHtmlTagHeader header, string attributeName, string attributeValue) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.ReSharper.Psi.Html.Tree.IHtmlToken CreateNewLine([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Html.Parsing.IHtmlTokenNodeTypes htmlTokenNodeTypes) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.ReSharper.Psi.Html.Tree.IHtmlToken CreateToken(JetBrains.ReSharper.Psi.Parsing.TokenNodeType tokenType, string tokenText) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.ReSharper.Psi.Html.Tree.IHtmlToken CreateWhitespace([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Html.Parsing.IHtmlTokenNodeTypes htmlTokenNodeTypes, [JetBrains.Annotations.NotNullAttribute()] string space) { }
        public static bool FixAttributeValue(JetBrains.ReSharper.Psi.Html.Tree.IHtmlAttributeValue attributeValue) { }
        public static JetBrains.ReSharper.Psi.Resolve.IReference FixPathReferenceTail([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Resolve.IPathReference pathReference, out bool isFixed) { }
        public static bool FixTagAttribute([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Html.Tree.ITagAttribute attribute) { }
        public static void FixTagFooter([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Html.Tree.IHtmlTagFooter footer) { }
        public static bool FixTagHeader([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Html.Tree.IHtmlTagHeader header, bool closeTag, bool needFooter) { }
        public static System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Tree.ITokenNode> GetTokens([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode node) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Psi.Html.Tree.IHtmlToken IsWhitespace([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode treeNode) { }
        public static bool PrepareForSubproperties([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Html.Tree.ITagAttribute attribute, string shortName) { }
    }
    public class static HtmlPathReferenceUtil
    {
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.ResolveResultWithInfo CheckAspLateBoundPathReferenceResolveResult<TOwner, TToken>(JetBrains.ReSharper.Psi.Html.Impl.References.HtmlPathReferenceBase<TOwner, TToken> pathReference, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.ResolveResultWithInfo baseResult)
            where TOwner : JetBrains.ReSharper.Psi.Tree.ITreeNode
            where TToken :  class, JetBrains.ReSharper.Psi.Tree.ITreeNode { }
        public static JetBrains.ReSharper.Psi.Resolve.IReference[] CreatePathAndIdReferences<TOwner, TToken>([JetBrains.Annotations.NotNullAttribute()] TOwner owner, [JetBrains.Annotations.NotNullAttribute()] TToken token, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Resolve.IQualifier baseQualifier, [JetBrains.Annotations.NotNullAttribute()] System.Func<TOwner, JetBrains.ReSharper.Psi.Resolve.IQualifier, TToken, JetBrains.ReSharper.Psi.TreeTextRange, JetBrains.ReSharper.Psi.Resolve.IPathReference> createFolderReferenceDelegate, [JetBrains.Annotations.NotNullAttribute()] System.Func<TOwner, JetBrains.ReSharper.Psi.Resolve.IQualifier, TToken, JetBrains.ReSharper.Psi.TreeTextRange, JetBrains.ReSharper.Psi.Resolve.IPathReference> createFileReferenceDelegate, [JetBrains.Annotations.NotNullAttribute()] System.Func<TOwner, JetBrains.ReSharper.Psi.Resolve.IPathReference, TToken, JetBrains.ReSharper.Psi.TreeTextRange, JetBrains.ReSharper.Psi.Resolve.IReference> createIdReferenceDelegate = null)
            where TOwner : JetBrains.ReSharper.Psi.Tree.ITreeNode
            where TToken :  class, JetBrains.ReSharper.Psi.Tree.ITreeNode { }
        public static JetBrains.ReSharper.Psi.Resolve.IPathReference[] CreatePathReferences<TOwner, TToken>([JetBrains.Annotations.NotNullAttribute()] TOwner owner, [JetBrains.Annotations.NotNullAttribute()] TToken token, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Resolve.IQualifier baseQualifier, [JetBrains.Annotations.NotNullAttribute()] System.Func<TOwner, JetBrains.ReSharper.Psi.Resolve.IQualifier, TToken, JetBrains.ReSharper.Psi.TreeTextRange, JetBrains.ReSharper.Psi.Resolve.IPathReference> createFolderReferenceDelegate, [JetBrains.Annotations.NotNullAttribute()] System.Func<TOwner, JetBrains.ReSharper.Psi.Resolve.IQualifier, TToken, JetBrains.ReSharper.Psi.TreeTextRange, JetBrains.ReSharper.Psi.Resolve.IPathReference> createFileReferenceDelegate)
            where TOwner : JetBrains.ReSharper.Psi.Tree.ITreeNode
            where TToken :  class, JetBrains.ReSharper.Psi.Tree.ITreeNode { }
        public static string ExpandRootName([JetBrains.Annotations.CanBeNullAttribute()] string path, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ProjectModel.IProject project) { }
        public static string GetTargetPath<TOwner, TToken>(JetBrains.ReSharper.Psi.Web.References.PathReferenceBase<TOwner, TToken> reference, JetBrains.ReSharper.Psi.IPathDeclaredElement pathDeclaredElement)
            where TOwner : JetBrains.ReSharper.Psi.Tree.ITreeNode
            where TToken :  class, JetBrains.ReSharper.Psi.Tree.ITreeNode { }
    }
    public class static HtmlReferenceUtil
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Psi.Html.Impl.References.IQualifierReference GetQualifierByTag([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Html.Tree.IHtmlTag containingTag) { }
    }
    public class static HtmlReferenceWithTokenUtil
    {
        public static JetBrains.ReSharper.Psi.Tree.ITreeNode CreateNewToken<TToken>(TToken oldToken, JetBrains.Text.IBuffer buffer)
            where TToken :  class, JetBrains.ReSharper.Psi.Tree.ITreeNode { }
        public static JetBrains.ReSharper.Psi.Impl.Shared.References.IReferenceWithinElement<TToken> SetText<TToken>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Impl.Shared.References.IReferenceWithinElement<TToken> reference, string newText)
            where TToken :  class, JetBrains.ReSharper.Psi.Tree.ITreeNode { }
        public static JetBrains.ReSharper.Psi.Tree.ITreeNode SetText<TOwner, TToken>(TToken token, JetBrains.ReSharper.Psi.TreeTextRange rangeWithin, string newText, TOwner elementToRemoveReferences)
            where TOwner : JetBrains.ReSharper.Psi.Tree.ITreeNode
            where TToken :  class, JetBrains.ReSharper.Psi.Tree.ITreeNode { }
    }
    public class static HtmlTagContainerUtil
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public static T AddTag<T>([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Html.Tree.IHtmlTagContainer container, [JetBrains.Annotations.NotNullAttribute()] T tag)
            where T :  class, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTagContainer { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static T AddTagAfter<T>([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Html.Tree.IHtmlTagContainer container, [JetBrains.Annotations.NotNullAttribute()] T tag, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode anchor)
            where T :  class, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTagContainer { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static T AddTagBefore<T>([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Html.Tree.IHtmlTagContainer container, [JetBrains.Annotations.NotNullAttribute()] T tag, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode anchor)
            where T :  class, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTagContainer { }
        public static void RemoveTag<T>([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Html.Tree.IHtmlTagContainer container, [JetBrains.Annotations.NotNullAttribute()] T tag)
            where T :  class, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTagContainer { }
    }
    public class static HtmlTagUtil
    {
        public static void IndentTag<T>([JetBrains.Annotations.NotNullAttribute()] T tag)
            where T :  class, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTagContainer { }
        public static void MakeCompound([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Html.Tree.IHtmlTag tag) { }
        public static void MakeEmptyTag([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Html.Tree.IHtmlTag tag) { }
    }
    public class static HtmlTreeUtil
    {
        public static short GetChildRole(JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.TreeElement child) { }
    }
    public interface IHtmlElementsMover : System.IDisposable { }
}