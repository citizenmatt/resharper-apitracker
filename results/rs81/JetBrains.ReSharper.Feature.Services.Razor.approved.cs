[assembly: JetBrains.UI.Icons.CompiledIcons.CompiledIconsPackAttribute(IconNames=new string[] {
        "RazorLineMarkup",
        "ScopeRazor",
        "RazorBaseType",
        "RazorImplicitExpression",
        "RazorNamespaceImport",
        "RazorCodeBlock"}, IconPackResourceIdentification="JetBrains.ReSharper.Feature.Services.Razor;component/resources/ServicesRazorTheme" +
    "dIcons/ThemedIcons.ServicesRazor.Generated.Xaml")]
[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]
[assembly: System.Windows.Markup.XmlnsDefinitionAttribute("urn:shemas-jetbrains-com:ui-application-icons-services-razor", "JetBrains.ReSharper.Feature.Services.Razor.Resources")]

namespace JetBrains.ReSharper.Feature.Services.Razor.CodeCompletion
{
    
    public class RazorCodeCompletionContext : JetBrains.ReSharper.Feature.Services.Html.CodeCompletion.HtmlCodeCompletionContext
    {
        public RazorCodeCompletionContext(JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.CodeCompletionContext context, JetBrains.ReSharper.Feature.Services.Html.CodeCompletion.HtmlReparsedCompletionContext unterminatedContext, JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.TextLookupRanges ranges) { }
        public override void ReparseAfterCompletionIfNeeded() { }
    }
    public class RazorCodeCompletionContextProvider<TLanguage> : JetBrains.ReSharper.Feature.Services.Html.CodeCompletion.HtmlCodeCompletionContextProvider
        where TLanguage : JetBrains.ReSharper.Psi.PsiLanguageType
    {
        public RazorCodeCompletionContextProvider(JetBrains.ReSharper.Feature.Services.Html.CodeCompletion.Settings.HtmlIntellisenseManager htmlIntellisenseManager, JetBrains.ReSharper.Psi.Html.Html.IHtmlDeclaredElementTypes cache) { }
        protected override JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ISpecificCodeCompletionContext GetSpecificContext(JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.CodeCompletionContext context, JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.TextLookupRanges ranges, JetBrains.ReSharper.Feature.Services.Html.CodeCompletion.HtmlReparsedCompletionContext unterminatedContext) { }
        public override bool IsApplicable(JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.CodeCompletionContext context) { }
        protected override bool ReferenceIsAcceptableForHtmlCompletion(JetBrains.ReSharper.Psi.Resolve.IReference referenceToComplete, JetBrains.ReSharper.Psi.Tree.ITreeNode elementToComplete) { }
    }
    [JetBrains.Application.Settings.SettingsKeyAttribute(typeof(JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.IntelliSenseCompletingCharactersSettingsKey), "Razor")]
    public class RazorCompletingCharactersSettingsKey
    {
        [JetBrains.Application.Settings.SettingsEntryAttribute(true, "Complete on space")]
        public bool CompleteOnSpace;
        [JetBrains.Application.Settings.SettingsEntryAttribute(JetBrains.ReSharper.Feature.Services.Lookup.LookupItemInsertType.Insert, "Enter action")]
        public JetBrains.ReSharper.Feature.Services.Lookup.LookupItemInsertType EnterAction;
        [JetBrains.Application.Settings.SettingsEntryAttribute("", "Non-completing characters")]
        public string NonCompletingCharacters;
        [JetBrains.Application.Settings.SettingsEntryAttribute(JetBrains.ReSharper.Feature.Services.Lookup.LookupItemInsertType.Replace, "Tab action")]
        public JetBrains.ReSharper.Feature.Services.Lookup.LookupItemInsertType TabAction;
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.Razor.RazorLanguage))]
    public class RazorCompletionRangesProvider : JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ItemsProviderOfSpecificContext<JetBrains.ReSharper.Feature.Services.Razor.CodeCompletion.RazorTransitionCompletionContext>, JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ICodeCompletionItemsProvider, JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ICompletionRangesProvider
    {
        protected override JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.TextLookupRanges GetDefaultRanges(JetBrains.ReSharper.Feature.Services.Razor.CodeCompletion.RazorTransitionCompletionContext context) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.Razor.RazorLanguage))]
    public class RazorTextTagItemProvider : JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ItemsProviderOfSpecificContext<JetBrains.ReSharper.Feature.Services.Razor.CodeCompletion.RazorCodeCompletionContext>
    {
        protected override bool AddLookupItems(JetBrains.ReSharper.Feature.Services.Razor.CodeCompletion.RazorCodeCompletionContext context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector) { }
        protected override bool IsAvailable(JetBrains.ReSharper.Feature.Services.Razor.CodeCompletion.RazorCodeCompletionContext context) { }
    }
    public class RazorTransitionCompletionContext : JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.SpecificCodeCompletionContext
    {
        public RazorTransitionCompletionContext(JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.CodeCompletionContext context, JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.TextLookupRanges ranges) { }
        public override string ContextId { get; }
        public JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.TextLookupRanges Ranges { get; }
    }
}
namespace JetBrains.ReSharper.Feature.Services.Razor.CodeCompletion.Settings
{
    
    [JetBrains.Application.Settings.SettingsKeyAttribute(typeof(JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.AutopopupEnabledSettingsKey), "Razor")]
    public class RazorAutopopupEnabledSettingsKey
    {
        [JetBrains.Application.Settings.SettingsEntryAttribute(JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.AutopopupType.HardAutopopup, "After \'(\' and \'@\'")]
        public JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.AutopopupType OnPunctuation;
        [JetBrains.Application.Settings.SettingsEntryAttribute(JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.AutopopupType.HardAutopopup, "After space in \'section\'")]
        public JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.AutopopupType OnSpaceInSection;
    }
}
namespace JetBrains.ReSharper.Feature.Services.Razor.CodeStructure
{
    
    public class RazorCodeBlockStructureElement : JetBrains.ReSharper.Feature.Services.Html.CodeStructure.HtmlCodeStructureElement<JetBrains.ReSharper.Psi.Razor.Tree.IRazorCode>
    {
        public RazorCodeBlockStructureElement(JetBrains.ReSharper.Psi.Razor.Tree.IRazorCode element, JetBrains.ReSharper.Psi.Html.Parsing.IHtmlTokenNodeTypes tokenTypes, JetBrains.ReSharper.Feature.Services.CodeStructure.CodeStructureElement parent) { }
        protected override JetBrains.Util.JetTuple<JetBrains.UI.Icons.IconId, JetBrains.UI.RichText.RichText, JetBrains.UI.RichText.RichText> GetPresentation(JetBrains.UI.TreeView.PresentationState state) { }
        public override System.Collections.Generic.IList<string> GetQuickSearchTexts() { }
    }
    [JetBrains.ProjectModel.ProjectFileTypeAttribute(typeof(JetBrains.ProjectModel.RazorProjectFileType))]
    public class RazorCodeStructureProvider : JetBrains.ReSharper.Feature.Services.Html.CodeStructure.HtmlCodeStructureProvider
    {
        public RazorCodeStructureProvider(JetBrains.ReSharper.Psi.ILanguageManager languageManager) { }
        protected override JetBrains.ReSharper.Psi.IRecursiveElementProcessor CreateElementProcessor(JetBrains.ReSharper.Feature.Services.Html.CodeStructure.HtmlCodeStructureRootElement root, JetBrains.ReSharper.Psi.Html.Parsing.IHtmlTokenNodeTypes tokenTypes) { }
    }
    public class RazorDirectiveCodeStructureElement : JetBrains.ReSharper.Feature.Services.Html.CodeStructure.HtmlCodeStructureElement<JetBrains.ReSharper.Psi.Razor.Tree.IRazorCode>
    {
        public RazorDirectiveCodeStructureElement(JetBrains.ReSharper.Psi.Razor.Tree.IRazorCode element, JetBrains.ReSharper.Psi.Html.Parsing.IHtmlTokenNodeTypes tokenTypes, JetBrains.ReSharper.Feature.Services.CodeStructure.CodeStructureElement parent, JetBrains.UI.Icons.IconId iconName) { }
        public override JetBrains.DocumentModel.DocumentRange NavigationRange { get; }
        protected override JetBrains.Util.JetTuple<JetBrains.UI.Icons.IconId, JetBrains.UI.RichText.RichText, JetBrains.UI.RichText.RichText> GetPresentation(JetBrains.UI.TreeView.PresentationState state) { }
        public override System.Collections.Generic.IList<string> GetQuickSearchTexts() { }
    }
    public class RazorHelperCodeStructureElement : JetBrains.ReSharper.Feature.Services.Html.CodeStructure.HtmlCodeStructureElement<JetBrains.ReSharper.Psi.Razor.Tree.IRazorHelper>, JetBrains.ReSharper.Feature.Services.CodeStructure.ICodeStructureDeclarationElement
    {
        public RazorHelperCodeStructureElement(JetBrains.ReSharper.Psi.Razor.Tree.IRazorHelper element, JetBrains.ReSharper.Psi.Html.Parsing.IHtmlTokenNodeTypes tokenTypes, JetBrains.ReSharper.Feature.Services.CodeStructure.CodeStructureElement parent) { }
        public JetBrains.ReSharper.Psi.Tree.IDeclaration Declaration { get; }
        public JetBrains.ReSharper.Psi.IDeclaredElement DeclaredElement { get; }
        protected override JetBrains.Util.JetTuple<JetBrains.UI.Icons.IconId, JetBrains.UI.RichText.RichText, JetBrains.UI.RichText.RichText> GetPresentation(JetBrains.UI.TreeView.PresentationState state) { }
        public override System.Collections.Generic.IList<string> GetQuickSearchTexts() { }
    }
    public class RazorHtmlMarkupCodeStructureElement : JetBrains.ReSharper.Feature.Services.Html.CodeStructure.HtmlCodeStructureElement<JetBrains.ReSharper.Psi.Razor.Tree.IRazorHtmlMarkup>
    {
        public RazorHtmlMarkupCodeStructureElement(JetBrains.ReSharper.Psi.Razor.Tree.IRazorHtmlMarkup element, JetBrains.ReSharper.Psi.Html.Parsing.IHtmlTokenNodeTypes tokenTypes, JetBrains.ReSharper.Feature.Services.CodeStructure.CodeStructureElement parent) { }
        protected override JetBrains.Util.JetTuple<JetBrains.UI.Icons.IconId, JetBrains.UI.RichText.RichText, JetBrains.UI.RichText.RichText> GetPresentation(JetBrains.UI.TreeView.PresentationState state) { }
        public override System.Collections.Generic.IList<string> GetQuickSearchTexts() { }
    }
    public class RazorSectionCodeStructureElement : JetBrains.ReSharper.Feature.Services.Html.CodeStructure.HtmlCodeStructureElement<JetBrains.ReSharper.Psi.Razor.Tree.IRazorSection>
    {
        public RazorSectionCodeStructureElement(JetBrains.ReSharper.Psi.Razor.Tree.IRazorSection element, JetBrains.ReSharper.Psi.Html.Parsing.IHtmlTokenNodeTypes tokenTypes, JetBrains.ReSharper.Feature.Services.CodeStructure.CodeStructureElement parent) { }
        public override JetBrains.DocumentModel.DocumentRange NavigationRange { get; }
        protected override JetBrains.Util.JetTuple<JetBrains.UI.Icons.IconId, JetBrains.UI.RichText.RichText, JetBrains.UI.RichText.RichText> GetPresentation(JetBrains.UI.TreeView.PresentationState state) { }
        public override System.Collections.Generic.IList<string> GetQuickSearchTexts() { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.Razor.Comment
{
    
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.Razor.RazorLanguage))]
    public class RazorBlockCommentActionProvider : JetBrains.ReSharper.Feature.Services.Html.Comment.HtmlBlockCommentActionProvider
    {
        public RazorBlockCommentActionProvider(JetBrains.ReSharper.Psi.Razor.Parsing.IRazorTokenNodeTypes tokenNodeTypes) { }
        protected override JetBrains.ReSharper.Psi.Parsing.TokenNodeType CommentBody { get; }
        protected override JetBrains.ReSharper.Psi.Parsing.TokenNodeType CommentEnd { get; }
        protected override JetBrains.ReSharper.Psi.Parsing.TokenNodeType CommentStart { get; }
        public override string EndBlockCommentMarker { get; }
        public override string StartBlockCommentMarker { get; }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.Razor.RazorLanguage))]
    public class RazorLineCommentActionProvider : JetBrains.ReSharper.Feature.Services.Html.Comment.HtmlLineCommentActionProvider
    {
        public RazorLineCommentActionProvider(JetBrains.ReSharper.Psi.Razor.Parsing.IRazorTokenNodeTypes tokenNodeTypes) { }
        protected override JetBrains.ReSharper.Psi.Parsing.TokenNodeType CommentEnd { get; }
        protected override JetBrains.ReSharper.Psi.Parsing.TokenNodeType CommentStart { get; }
        public override string EndLineCommentMarker { get; }
        public override string StartLineCommentMarker { get; }
    }
}
namespace JetBrains.ReSharper.Feature.Services.Razor.ContextHighlighters
{
    
    [JetBrains.ReSharper.Daemon.CaretDependentFeatures.ContainsContextConsumerAttribute()]
    public class RazorMatchingBracesContextHighlighter : JetBrains.ReSharper.Feature.Services.ContextHighlighters.MatchingBraceContextHighlighterBase
    {
        public RazorMatchingBracesContextHighlighter(JetBrains.ReSharper.Feature.Services.Html.Bulbs.IWebContextActionDataProvider<JetBrains.ReSharper.Psi.Razor.Tree.IRazorFile> dataProvider) { }
        protected override bool IsLeftBracket(JetBrains.ReSharper.Psi.Parsing.TokenNodeType tokenType) { }
        protected override bool IsRightBracket(JetBrains.ReSharper.Psi.Parsing.TokenNodeType tokenType) { }
        protected override bool Match(JetBrains.ReSharper.Psi.Parsing.TokenNodeType token1, JetBrains.ReSharper.Psi.Parsing.TokenNodeType token2) { }
        [JetBrains.ReSharper.Daemon.CaretDependentFeatures.AsyncContextConsumerAttribute()]
        public static System.Action ProcessDataContext(JetBrains.DataFlow.Lifetime lifetime, [JetBrains.ReSharper.Daemon.CaretDependentFeatures.ContextKeyAttribute(typeof(JetBrains.ReSharper.Intentions.Razor.ContextActions.RazorContextActionDataProvider.ContextKey))] JetBrains.ReSharper.Feature.Services.Html.Bulbs.IWebContextActionDataProvider<JetBrains.ReSharper.Psi.Razor.Tree.IRazorFile> dataProvider, JetBrains.ReSharper.Daemon.CaretDependentFeatures.InvisibleBraceHintManager invisibleBraceHintManager, JetBrains.ReSharper.Feature.Services.ContextHighlighters.MatchingBraceSuggester matchingBraceSuggester) { }
        protected override void TryHighlightToLeft(JetBrains.ReSharper.Feature.Services.ContextHighlighters.MatchingHighlightingsConsumer consumer, JetBrains.ReSharper.Psi.Tree.ITokenNode selectedToken, JetBrains.ReSharper.Psi.TreeOffset treeOffset) { }
        protected override void TryHighlightToRight(JetBrains.ReSharper.Feature.Services.ContextHighlighters.MatchingHighlightingsConsumer consumer, JetBrains.ReSharper.Psi.Tree.ITokenNode selectedToken, JetBrains.ReSharper.Psi.TreeOffset treeOffset) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.Razor.LiveTemplates
{
    
    [JetBrains.ReSharper.Feature.Services.LiveTemplates.Support.FileTemplatesAttribute()]
    public class RazorFileTemplatesSupport : JetBrains.ReSharper.Feature.Services.Razor.LiveTemplates.RazorFileTemplatesSupportBase
    {
        protected override JetBrains.ProjectModel.Properties.ProjectLanguage Language { get; }
        public override string Name { get; }
    }
    public abstract class RazorFileTemplatesSupportBase : JetBrains.ReSharper.Feature.Services.LiveTemplates.Support.IFileTemplatesSupport
    {
        protected abstract JetBrains.ProjectModel.Properties.ProjectLanguage Language { get; }
        public abstract string Name { get; }
        public virtual System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint> ScopePoints { get; }
        public virtual bool Accepts(JetBrains.ProjectModel.IProject project) { }
    }
    [JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ScopeCategoryUIProviderAttribute(Priority=-100D, ScopeFilter=JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ScopeFilter.Project)]
    public class RazorProjectScopeCategoryUIProvider : JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ScopeCategoryUIProvider
    {
        public RazorProjectScopeCategoryUIProvider() { }
        public override string CategoryCaption { get; }
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint> BuildAllPoints() { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class RazorProjectScopeProvider : JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ScopeProvider
    {
        public RazorProjectScopeProvider() { }
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint> ProvideScopePoints(JetBrains.ReSharper.Feature.Services.LiveTemplates.Context.TemplateAcceptanceContext context) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.Razor.LiveTemplates.Scope
{
    
    public class InAnyRazorProject : JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.InAnyProject
    {
        public override string DefaultFileName { get; }
        public override string PresentableShortName { get; }
        public override JetBrains.ReSharper.Psi.PsiLanguageType RelatedLanguage { get; }
        public override System.Guid GetDefaultUID() { }
    }
    public class InRazorSpecificProject : JetBrains.ReSharper.Feature.Services.Razor.LiveTemplates.Scope.InAnyRazorProject
    {
        public InRazorSpecificProject(JetBrains.ProjectModel.Properties.ProjectLanguage projectLanguage) { }
        public override System.Guid GetDefaultUID() { }
        public override bool IsSubsetOf(JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint other) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.Razor.Navigation.GoToRelated
{
    
    [JetBrains.ReSharper.Feature.Services.Navigation.GoToRelated.RelatedFilesProviderAttribute(typeof(JetBrains.ProjectModel.RazorProjectFileType))]
    public class RazorRelatedFilesProvider : JetBrains.ReSharper.Feature.Services.Navigation.GoToRelated.DefaultRelatedFilesProvider
    {
        public override System.Collections.Generic.IEnumerable<JetBrains.Util.JetTuple<JetBrains.ProjectModel.IProjectFile, string, JetBrains.ProjectModel.IProjectFile>> GetRelatedFiles(JetBrains.ProjectModel.IProjectFile projectFile) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.Razor.Navigation
{
    
    [JetBrains.ReSharper.Psi.ShellFeaturePartAttribute()]
    public class RazorFileMemberProvider : JetBrains.ReSharper.Feature.Services.Goto.GotoProviders.NonCachedFileMemberProvider<JetBrains.ReSharper.Psi.Razor.RazorLanguage> { }
}
namespace JetBrains.ReSharper.Feature.Services.Razor.Options
{
    
    [JetBrains.Application.ShellComponentAttribute()]
    public class PredefinedRazorTypingAssistSettings : JetBrains.Application.Settings.IHaveDefaultSettingsStream { }
    [JetBrains.Application.Settings.SettingsKeyAttribute(typeof(JetBrains.ReSharper.Feature.Services.Options.TypingAssistSettings), "Razor typing assistance settings", KeyNameOverride="Razor")]
    public class RazorTypingAssistSettings : JetBrains.ReSharper.Feature.Services.Html.Options.HtmlTypingAssistSettings { }
}
namespace JetBrains.ReSharper.Feature.Services.Razor
{
    
    [JetBrains.ProjectModel.ProjectFileTypeAttribute(typeof(JetBrains.ProjectModel.RazorCSharpProjectFileType))]
    public class RazorFileTypeSpecificOwnerUtil : JetBrains.ReSharper.Feature.Services.Util.DefaultFileTypeSpecificOwnerUtil
    {
        public RazorFileTypeSpecificOwnerUtil(JetBrains.ReSharper.Psi.Razor.Impl.CustomHandlers.IRazorPsiServices razorPsiServices) { }
        public override bool CanContainSeveralClasses(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
        public override bool CanDeclarationBeOverloaded(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration) { }
        public override bool CanHaveConstructors(JetBrains.ReSharper.Psi.Tree.ITypeDeclaration typeElement) { }
        public override bool CanImplementInterfaces(JetBrains.ReSharper.Psi.Tree.ITypeDeclaration typeElement) { }
        public override JetBrains.DocumentModel.DocumentRange GetDocumentRangeForPartiallyUnmappedNode(JetBrains.ReSharper.Psi.Tree.ITreeNode node) { }
        public override JetBrains.Util.FileSystemPath GetFolderForElementsMovedToExternalScope(JetBrains.ProjectModel.IProjectFile file, string @namespace, JetBrains.ReSharper.Psi.Tree.ITreeNode referenceNode) { }
        public override System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.IClrTypeName> GetMvcViewWithModelBaseTypes() { }
        public override string GetNamespaceForElementsMovedToExternalScope(JetBrains.ReSharper.Psi.Tree.ITypeDeclaration typeElement, JetBrains.ReSharper.Psi.Tree.ITreeNode referenceNode) { }
        public override string GetPrettyName(JetBrains.ReSharper.Psi.Tree.ITypeDeclaration element, bool mustBeIdentifier) { }
        public override bool HasUglyName(JetBrains.ReSharper.Psi.Tree.ITypeDeclaration declaration) { }
        public override bool IsCodeBehindClass(JetBrains.ReSharper.Psi.Tree.ITypeDeclaration declaration) { }
        public override bool IsOperationPossibleOnUnmappedRange(JetBrains.ReSharper.Psi.Tree.ITreeNode node) { }
        public override bool IsOperationPossibleOnUnmappedRange(JetBrains.ReSharper.Psi.ITreeRange range) { }
    }
    public class static RazorImages
    {
        public static JetBrains.UI.Icons.IconId GetSectionImage() { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.Razor.Resources
{
    
    public sealed class ServicesRazorThemedIcons
    {
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Feature.Services.Razor;component/resources/ServicesRazorTheme" +
            "dIcons/ThemedIcons.ServicesRazor.Generated.Xaml", 2, "RazorBaseType")]
        public sealed class RazorBaseType : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Feature.Services.Razor;component/resources/ServicesRazorTheme" +
            "dIcons/ThemedIcons.ServicesRazor.Generated.Xaml", 5, "RazorCodeBlock")]
        public sealed class RazorCodeBlock : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Feature.Services.Razor;component/resources/ServicesRazorTheme" +
            "dIcons/ThemedIcons.ServicesRazor.Generated.Xaml", 3, "RazorImplicitExpression")]
        public sealed class RazorImplicitExpression : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Feature.Services.Razor;component/resources/ServicesRazorTheme" +
            "dIcons/ThemedIcons.ServicesRazor.Generated.Xaml", 0, "RazorLineMarkup")]
        public sealed class RazorLineMarkup : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Feature.Services.Razor;component/resources/ServicesRazorTheme" +
            "dIcons/ThemedIcons.ServicesRazor.Generated.Xaml", 4, "RazorNamespaceImport")]
        public sealed class RazorNamespaceImport : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Feature.Services.Razor;component/resources/ServicesRazorTheme" +
            "dIcons/ThemedIcons.ServicesRazor.Generated.Xaml", 1, "ScopeRazor")]
        public sealed class ScopeRazor : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
    }
}
namespace JetBrains.ReSharper.Feature.Services.Razor.TodoItems
{
    
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.Razor.RazorLanguage))]
    public class RazorTodoContentsProvider : JetBrains.ReSharper.Feature.Services.Html.TodoItems.HtmlTodoContentsProvider
    {
        public RazorTodoContentsProvider(JetBrains.ReSharper.Psi.Razor.Parsing.IRazorTokenNodeTypes razorTokenNodeTypes) { }
        public override System.Nullable<JetBrains.Util.TextRange> GetTokenContentsRange(string documentText, JetBrains.Util.TextRange tokenRange, JetBrains.ReSharper.Psi.Parsing.TokenNodeType tokenType) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.Razor.TypingAssist
{
    
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class RazorChangedTagNameTracker : JetBrains.ReSharper.Feature.Services.Html.TypingAssist.SpecificChangedTagNameTracker<JetBrains.ReSharper.Feature.Services.Razor.Options.RazorTypingAssistSettings, JetBrains.ProjectModel.RazorProjectFileType>
    {
        public RazorChangedTagNameTracker(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Settings.ISettingsStore settingsStore, JetBrains.ReSharper.Psi.Services.CachingLexerService cachingLexerService, JetBrains.Application.CommandProcessing.ICommandProcessor commandProcessor, JetBrains.TextControl.Impl.TextControlTypingHandlers textControlTypingHandlers, JetBrains.DataFlow.Lifetime lifetime, JetBrains.TextControl.ITextControlManager textControlManager, JetBrains.Application.IShellLocks shellLocks, JetBrains.ActionManagement.IActionManager actionManager, JetBrains.ProjectModel.Model2.Transaction.IEnsureWritableHandler ensureWritableHandler, JetBrains.DocumentManagers.DocumentManager documentManager, JetBrains.ReSharper.Feature.Services.Lookup.ILookupWindowManager lookupWindowManager, JetBrains.ReSharper.Psi.Files.IPsiFiles psiFiles, JetBrains.Application.ChangeManager changeManager, JetBrains.ReSharper.Feature.Services.TypingAssist.ITypingAssistManager typingAssistManager) { }
        protected override JetBrains.ReSharper.Feature.Services.Html.TypingAssist.ChangedTagNameTracker.MarkerFindResults FindMarkersViaLexer(JetBrains.TextControl.ITextControl textControl, int caretPosition) { }
        protected override JetBrains.ReSharper.Feature.Services.Html.TypingAssist.ChangedTagNameTracker.MarkerFindResults FindMarkersViaPsi(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, JetBrains.TextControl.ITextControl textControl, int caretPosition) { }
        public static bool GetPairMarkup(JetBrains.ReSharper.Psi.Parsing.CachingLexer lexer, JetBrains.ReSharper.Psi.Razor.Parsing.IRazorTokenNodeTypes tokenNodeTypes, int direction) { }
    }
}
namespace JetBrains.ReSharper.Intentions.Razor.ContextActions
{
    
    public class static RazorContextActionDataProvider
    {
        public sealed class ContextKey : JetBrains.ReSharper.Daemon.CaretDependentFeatures.ContextKeyWithValueBase<JetBrains.ReSharper.Feature.Services.Html.Bulbs.IWebContextActionDataProvider<JetBrains.ReSharper.Psi.Razor.Tree.IRazorFile>>
        {
            public static readonly JetBrains.ReSharper.Intentions.Razor.ContextActions.RazorContextActionDataProvider.ContextKey Instance;
        }
        [JetBrains.ProjectModel.SolutionComponentAttribute()]
        public class Current : JetBrains.ReSharper.Daemon.Bulbs.CurrentContextActionDataProviderBase<JetBrains.ReSharper.Feature.Services.Html.Bulbs.IWebContextActionDataProvider<JetBrains.ReSharper.Psi.Razor.Tree.IRazorFile>, JetBrains.ReSharper.Psi.Razor.RazorLanguage, JetBrains.ReSharper.Psi.Razor.Tree.IRazorFile>
        {
            public Current(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.IShellLocks shellLocks, JetBrains.ReSharper.Daemon.CaretDependentFeatures.ContextManager contextManager, JetBrains.ReSharper.Psi.AsyncCommitService asyncCommitService, JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControlManager textControlManager, JetBrains.ReSharper.Psi.Files.IPsiFiles psiFiles) { }
            protected override JetBrains.ReSharper.Feature.Services.Html.Bulbs.IWebContextActionDataProvider<JetBrains.ReSharper.Psi.Razor.Tree.IRazorFile> CreateDataProvider(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl, JetBrains.ReSharper.Psi.Razor.Tree.IRazorFile psiFile) { }
            protected override JetBrains.ReSharper.Daemon.CaretDependentFeatures.ContextKeyWithValueBase<JetBrains.ReSharper.Feature.Services.Html.Bulbs.IWebContextActionDataProvider<JetBrains.ReSharper.Psi.Razor.Tree.IRazorFile>> GetContextKey() { }
        }
    }
}