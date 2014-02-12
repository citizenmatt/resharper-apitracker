[assembly: JetBrains.UI.Icons.CompiledIcons.CompiledIconsPackAttribute(IconNames=new string[] {
        "ScopeRazorCS"}, IconPackResourceIdentification="JetBrains.ReSharper.Feature.Services.Razor.CSharp;component/resources/ServicesRaz" +
    "orCSharpThemedIcons/ThemedIcons.ServicesRazorCSharp.Generated.Xaml")]
[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]
[assembly: System.Windows.Markup.XmlnsDefinitionAttribute("urn:shemas-jetbrains-com:ui-application-icons-services-razor-csharp", "JetBrains.ReSharper.Feature.Services.Razor.CSharp.Resources")]

namespace JetBrains.ReSharper.Feature.Services.Razor.CSharp.CodeCompletion
{
    
    public class FunctionsKeywordLookupItem : JetBrains.ReSharper.Feature.Services.Lookup.TextLookupItem
    {
        public FunctionsKeywordLookupItem(JetBrains.ReSharper.Feature.Services.Razor.CodeCompletion.RazorTransitionCompletionContext context) { }
        public JetBrains.ReSharper.Feature.Services.Razor.CodeCompletion.RazorTransitionCompletionContext Context { get; }
        protected JetBrains.ReSharper.Feature.Services.TypingAssist.SkippingTypingAssist GetSkippingTypingAssist() { }
        protected override void OnAfterComplete(JetBrains.TextControl.ITextControl textControl, ref JetBrains.Util.TextRange nameRange, ref JetBrains.Util.TextRange decorationRange, JetBrains.ReSharper.Psi.ExpectedTypes.TailType tailType, ref JetBrains.ReSharper.Feature.Services.Lookup.Suffix suffix, ref JetBrains.DocumentModel.IRangeMarker caretPositionRangeMarker) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class RazorCSharpAutomaticStrategyOnCharacter : JetBrains.ReSharper.Feature.Services.Html.CodeCompletion.HtmlAutomaticStrategyOnListedCharacters<JetBrains.ReSharper.Psi.Razor.Tree.IRazorFile, JetBrains.ReSharper.Psi.Razor.Parsing.IRazorTokenNodeTypes>
    {
        public RazorCSharpAutomaticStrategyOnCharacter(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Settings.CSharpIntellisenseManager cSharpIntellisenseManager, JetBrains.Application.Settings.ISettingsStore settingsStore) { }
        public override JetBrains.ReSharper.Psi.PsiLanguageType Language { get; }
        protected override bool GetIntellisenseEnabled(JetBrains.Application.Settings.IContextBoundSettingsStore contextBoundSettingsStore) { }
        protected override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.Html.CodeCompletion.HtmlAutomaticStrategyOnListedCharacters<JetBrains.ReSharper.Psi.Razor.Tree.IRazorFile, JetBrains.ReSharper.Psi.Razor.Parsing.IRazorTokenNodeTypes>.StartChar> GetStartChars(JetBrains.ReSharper.Psi.Razor.Parsing.IRazorTokenNodeTypes tokenNodeTypes) { }
        public override JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.AutopopupType IsEnabledInSettings(JetBrains.Application.Settings.IContextBoundSettingsStore settingsStore, JetBrains.TextControl.ITextControl textControl) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class RazorCSharpAutomaticStrategyOnDot : JetBrains.ReSharper.Feature.Services.Html.CodeCompletion.HtmlAutomaticStrategyOnListedCharacters<JetBrains.ReSharper.Psi.Razor.Tree.IRazorFile, JetBrains.ReSharper.Psi.Razor.Parsing.IRazorTokenNodeTypes>
    {
        public RazorCSharpAutomaticStrategyOnDot(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Settings.CSharpIntellisenseManager cSharpIntellisenseManager, JetBrains.Application.Settings.ISettingsStore settingsStore) { }
        public override JetBrains.ReSharper.Psi.PsiLanguageType Language { get; }
        protected override bool GetIntellisenseEnabled(JetBrains.Application.Settings.IContextBoundSettingsStore contextBoundSettingsStore) { }
        protected override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.Html.CodeCompletion.HtmlAutomaticStrategyOnListedCharacters<JetBrains.ReSharper.Psi.Razor.Tree.IRazorFile, JetBrains.ReSharper.Psi.Razor.Parsing.IRazorTokenNodeTypes>.StartChar> GetStartChars(JetBrains.ReSharper.Psi.Razor.Parsing.IRazorTokenNodeTypes tokenNodeTypes) { }
        public override JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.AutopopupType IsEnabledInSettings(JetBrains.Application.Settings.IContextBoundSettingsStore settingsStore, JetBrains.TextControl.ITextControl textControl) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class RazorCSharpAutomaticStrategyOnSection : JetBrains.ReSharper.Feature.Services.CodeCompletion.IAutomaticCodeCompletionStrategy
    {
        public RazorCSharpAutomaticStrategyOnSection(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Settings.CSharpIntellisenseManager cSharpIntellisenseManager, JetBrains.Application.Settings.ISettingsStore settingsStore) { }
        public JetBrains.ReSharper.Feature.Services.CodeCompletion.CodeCompletionType CodeCompletionType { get; }
        public bool ForceHideCompletion { get; }
        public JetBrains.ReSharper.Psi.PsiLanguageType Language { get; }
        public bool AcceptsFile(JetBrains.ReSharper.Psi.Tree.IFile file, JetBrains.TextControl.ITextControl textControl) { }
        public bool AcceptTyping(char c, JetBrains.TextControl.ITextControl textControl, JetBrains.Application.Settings.IContextBoundSettingsStore boundSettingsStore) { }
        public JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.AutopopupType IsEnabledInSettings(JetBrains.Application.Settings.IContextBoundSettingsStore settingsStore, JetBrains.TextControl.ITextControl textControl) { }
        public bool ProcessSubsequentTyping(char c, JetBrains.TextControl.ITextControl textControl) { }
    }
    public class RazorCSharpCodeCompletionContext : JetBrains.ReSharper.Feature.Services.Razor.CodeCompletion.RazorCodeCompletionContext
    {
        public RazorCSharpCodeCompletionContext(JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.CodeCompletionContext context, JetBrains.ReSharper.Feature.Services.Html.CodeCompletion.HtmlReparsedCompletionContext unterminatedContext, JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.TextLookupRanges ranges) { }
        public override JetBrains.ReSharper.Feature.Services.Lookup.DeclaredElementLookupItem CreateDeclaredElementLookupItem(string name, JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
    }
    [JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.IntellisensePartAttribute()]
    public class RazorCSharpCodeCompletionContextProvider : JetBrains.ReSharper.Feature.Services.Razor.CodeCompletion.RazorCodeCompletionContextProvider<JetBrains.ReSharper.Psi.Razor.CSharp.RazorCSharpLanguage>
    {
        public RazorCSharpCodeCompletionContextProvider(JetBrains.ReSharper.Feature.Services.Html.CodeCompletion.Settings.HtmlIntellisenseManager htmlIntellisenseManager, JetBrains.ReSharper.Psi.Html.Html.IHtmlDeclaredElementTypes cache) { }
        protected override JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ISpecificCodeCompletionContext GetSpecificContext(JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.CodeCompletionContext context, JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.TextLookupRanges ranges, JetBrains.ReSharper.Feature.Services.Html.CodeCompletion.HtmlReparsedCompletionContext unterminatedContext) { }
    }
    [JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.IntellisensePartAttribute()]
    public class RazorCSharpCompletingCharactersProvider : JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.CompletingCharsProviderWithSetting<JetBrains.ReSharper.Feature.Services.Razor.CodeCompletion.RazorCodeCompletionContext, JetBrains.ReSharper.Feature.Services.Razor.CodeCompletion.RazorCompletingCharactersSettingsKey>
    {
        protected override System.Linq.Expressions.Expression<System.Func<JetBrains.ReSharper.Feature.Services.Razor.CodeCompletion.RazorCompletingCharactersSettingsKey, bool>> GetCompleteOnSpaceSettingKey() { }
        protected override System.Linq.Expressions.Expression<System.Func<JetBrains.ReSharper.Feature.Services.Razor.CodeCompletion.RazorCompletingCharactersSettingsKey, JetBrains.ReSharper.Feature.Services.Lookup.LookupItemInsertType>> GetEnterActionSettingKey() { }
        protected override System.Linq.Expressions.Expression<System.Func<JetBrains.ReSharper.Feature.Services.Razor.CodeCompletion.RazorCompletingCharactersSettingsKey, string>> GetNonCompletingCharactersSettingKey() { }
        protected override System.Linq.Expressions.Expression<System.Func<JetBrains.ReSharper.Feature.Services.Razor.CodeCompletion.RazorCompletingCharactersSettingsKey, JetBrains.ReSharper.Feature.Services.Lookup.LookupItemInsertType>> GetTabActionSettingKey() { }
        protected override bool IsApplicable(JetBrains.ReSharper.Feature.Services.Razor.CodeCompletion.RazorCodeCompletionContext context) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.Razor.CSharp.RazorCSharpLanguage))]
    public class RazorCSharpKeywordItemsProvider : JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ItemsProviderOfSpecificContext<JetBrains.ReSharper.Feature.Services.Razor.CodeCompletion.RazorTransitionCompletionContext>
    {
        protected static readonly string[] ourKeywords;
        protected override bool AddLookupItems(JetBrains.ReSharper.Feature.Services.Razor.CodeCompletion.RazorTransitionCompletionContext context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector) { }
        protected virtual System.Collections.Generic.IEnumerable<string> GetKeywords() { }
        protected override bool IsAvailable(JetBrains.ReSharper.Feature.Services.Razor.CodeCompletion.RazorTransitionCompletionContext context) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.Razor.CSharp.Mvc.RazorCSharpMvcLanguage))]
    public class RazorCSharpMvcKeywordItemsProvider : JetBrains.ReSharper.Feature.Services.Razor.CSharp.CodeCompletion.RazorCSharpKeywordItemsProvider
    {
        protected override System.Collections.Generic.IEnumerable<string> GetKeywords() { }
    }
    public class RazorCSharpReparsedCompletionContext : JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.CSharpReparsedCompletionContext
    {
        public RazorCSharpReparsedCompletionContext(JetBrains.ReSharper.Psi.Tree.IFile file, JetBrains.ReSharper.Psi.TreeTextRange range, string newText, int prefixLength = 0, int documentShift = 0) { }
        protected override JetBrains.ReSharper.Psi.TreeTextRange GetRangeOfReference(int startOffsetInNewNode) { }
        public override JetBrains.Util.TextRange ToDocumentRange(JetBrains.ReSharper.Psi.TreeTextRange treeRange) { }
    }
    [JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.IntellisensePartAttribute()]
    public class RazorCSharpSpecificCodeCompletionContextProvider : JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContextProvider
    {
        public RazorCSharpSpecificCodeCompletionContextProvider(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Settings.CSharpIntellisenseManager cSharpIntellisenseManager, JetBrains.ReSharper.Psi.ILanguageManager languageManager, JetBrains.Application.Settings.ISettingsStore settingsStore, JetBrains.ReSharper.Feature.Services.Lookup.LookupItemsOwnerFactory factory) { }
        protected override JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.CSharpReparsedCompletionContext CreateReparseContext(JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.CodeCompletionContext context, JetBrains.ReSharper.Psi.TreeTextRange selectedTreeRange, string newText) { }
        public override JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ISpecificCodeCompletionContext GetCompletionContext(JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.CodeCompletionContext context) { }
        public override bool IsApplicable(JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.CodeCompletionContext context) { }
    }
    [JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.IntellisensePartAttribute()]
    public class RazorCSharpTransitionCompletionContextProvider : JetBrains.ReSharper.Feature.Services.CodeCompletion.Impl.CodeCompletionContextProviderBase
    {
        public RazorCSharpTransitionCompletionContextProvider(JetBrains.ReSharper.Psi.ILanguageManager languageManager, JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Settings.CSharpIntellisenseManager cSharpIntellisenseManager) { }
        public override JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ISpecificCodeCompletionContext GetCompletionContext(JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.CodeCompletionContext context) { }
        public override bool IsApplicable(JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.CodeCompletionContext context) { }
    }
    public class RazorSectionNameLookupItem : JetBrains.ReSharper.Feature.Services.Html.CodeCompletion.HtmlDeclaredElementLookupItemBase
    {
        public RazorSectionNameLookupItem(JetBrains.ReSharper.Psi.DeclaredElementInstance<JetBrains.ReSharper.Psi.IDeclaredElement> declaredElement, string name, JetBrains.ReSharper.Feature.Services.Html.CodeCompletion.HtmlCodeCompletionContext context, JetBrains.ReSharper.Psi.PsiLanguageType languageType, JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.TextLookupRanges ranges) { }
        protected override void FixInsertedText(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.Razor.CSharp.LiveTemplates
{
    
    public class InRazorCSharpProject : JetBrains.ReSharper.Feature.Services.Razor.LiveTemplates.Scope.InRazorSpecificProject, JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.IMainScopePoint, JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint
    {
        public InRazorCSharpProject() { }
        public override string PresentableShortName { get; }
        public string QuickListTitle { get; }
        public System.Guid QuickListUID { get; }
        public override JetBrains.ReSharper.Psi.PsiLanguageType RelatedLanguage { get; }
        public override System.Guid GetDefaultUID() { }
    }
    [JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ScopeCategoryUIProviderAttribute(Priority=-110D, ScopeFilter=JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ScopeFilter.Project)]
    public class RazorCSharpProjectScopeCategoryUIProvider : JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ScopeCategoryUIProvider
    {
        public RazorCSharpProjectScopeCategoryUIProvider() { }
        public override string CategoryCaption { get; }
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint> BuildAllPoints() { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class RazorCSharpProjectScopeProvider : JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ScopeProvider
    {
        public RazorCSharpProjectScopeProvider() { }
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint> ProvideScopePoints(JetBrains.ReSharper.Feature.Services.LiveTemplates.Context.TemplateAcceptanceContext context) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.Razor.CSharp.LiveTemplates.Support
{
    
    [JetBrains.ReSharper.Feature.Services.LiveTemplates.Support.FileTemplatesAttribute()]
    public class RazorCSharpFileTemplatesSupport : JetBrains.ReSharper.Feature.Services.Razor.LiveTemplates.RazorFileTemplatesSupportBase
    {
        protected override JetBrains.ProjectModel.Properties.ProjectLanguage Language { get; }
        public override string Name { get; }
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint> ScopePoints { get; }
    }
}
namespace JetBrains.ReSharper.Feature.Services.Razor.CSharp.Resources
{
    
    public sealed class ServicesRazorCSharpThemedIcons
    {
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Feature.Services.Razor.CSharp;component/resources/ServicesRaz" +
            "orCSharpThemedIcons/ThemedIcons.ServicesRazorCSharp.Generated.Xaml", 0, "ScopeRazorCS")]
        public sealed class ScopeRazorCS : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
    }
}
namespace JetBrains.ReSharper.Feature.Services.Razor.CSharp.TypingAssist
{
    
    public enum BracketType
    {
        Brace = 0,
        Parenthesis = 1,
        Bracket = 2,
        AllBrackets = 10,
    }
    public class RazorBraceMatcher
    {
        public RazorBraceMatcher([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Razor.Parsing.IRazorTokenNodeTypes razorTokenNodeTypes, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.MatchingBrace.ISimpleMatchingBraceProvider> providers, JetBrains.ReSharper.Feature.Services.Razor.CSharp.TypingAssist.BracketType bracketType = 10) { }
        public int Direction(JetBrains.ReSharper.Psi.Parsing.CachingLexer lexer) { }
        public bool FindMatchingBracket(JetBrains.ReSharper.Psi.Parsing.CachingLexer cachingLexer, out int pos) { }
        public bool FindMatchingBracket(JetBrains.ReSharper.Psi.Parsing.CachingLexer cachingLexer) { }
        public JetBrains.Util.JetTuple<JetBrains.ReSharper.Feature.Services.Razor.CSharp.TypingAssist.BracketType, int> GetBracketType(JetBrains.ReSharper.Psi.Parsing.CachingLexer lexer) { }
        public bool HasOpenBraces() { }
        public bool IsStackEmpty() { }
        public bool ProceedStack(JetBrains.ReSharper.Psi.Parsing.CachingLexer lexer) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class RazorCSharpHtmlTypingAssist : JetBrains.ReSharper.Feature.Services.Html.TypingAssist.WebTypingAssist<JetBrains.ProjectModel.RazorCSharpProjectFileType, JetBrains.ReSharper.Psi.Razor.CSharp.RazorCSharpLanguage, JetBrains.ReSharper.Psi.Razor.Parsing.IRazorTokenNodeTypes, JetBrains.ReSharper.Feature.Services.Razor.Options.RazorTypingAssistSettings>
    {
        public RazorCSharpHtmlTypingAssist(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Psi.Services.CachingLexerService cachingLexerService, JetBrains.Application.CommandProcessing.ICommandProcessor commandProcessor, JetBrains.ReSharper.Feature.Services.CodeCompletion.IntellisenseManager intellisenseManager, JetBrains.Application.Settings.ISettingsStore settingsStore, JetBrains.ReSharper.Feature.Services.TypingAssist.SkippingTypingAssist skippingTypingAssist, JetBrains.ReSharper.Psi.ILanguageManager languageManager, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.Html.TypingAssist.ISpecialTagSmartEnterHandler> smartEnterHandlers, JetBrains.ReSharper.Feature.Services.ParameterInfo.ParameterInfoPopupController parameterInfoPopupController, JetBrains.ReSharper.Feature.Services.TypingAssist.ITypingAssistManager typingAssistManager, JetBrains.ReSharper.Psi.IPsiServices psiServices, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.TypingAssist.ISecondaryTypingAssist> secondaryTypingAssists) { }
        protected override bool DoHandleEnterAfterHeaderPressed(JetBrains.TextControl.ITextControl textControl) { }
        protected override bool HandleQuoteAtTokenStart(JetBrains.TextControl.ITextControl textControl, JetBrains.ReSharper.Psi.Parsing.CachingLexer lexer, JetBrains.ReSharper.Psi.Razor.Parsing.IRazorTokenNodeTypes tokenTypes) { }
        public override bool QuickCheckAvailability(JetBrains.TextControl.ITextControl textControl, JetBrains.ReSharper.Psi.IPsiSourceFile projectFile) { }
    }
}