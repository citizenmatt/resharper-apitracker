[assembly: JetBrains.UI.Icons.CompiledIcons.CompiledIconsPackAttribute(IconNames=new string[] {
        "HtmlTagAttributeIcon",
        "HtmlTagIcon",
        "HtmlTagAttributeValueIcon"}, IconPackResourceIdentification="JetBrains.ReSharper.Feature.Services.Html;component/resources/ServicesHtmlThemedI" +
    "cons/ThemedIcons.ServicesHtml.Generated.Xaml")]
[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]
[assembly: System.Windows.Markup.XmlnsDefinitionAttribute("urn:shemas-jetbrains-com:ui-application-icons-services-html", "JetBrains.ReSharper.Feature.Services.Html.Resources")]

namespace JetBrains.ReSharper.Feature.Services.Html.Bulbs
{
    
    public interface IWebContextActionDataProvider<out TFile> : JetBrains.ReSharper.Feature.Services.Bulbs.IContextActionDataProvider, JetBrains.ReSharper.Feature.Services.Bulbs.IContextActionDataProvider<TFile>
        where out TFile :  class, JetBrains.ReSharper.Psi.Html.Tree.IHtmlFile
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        T FindNodeAtCaret<T>()
            where T :  class, JetBrains.ReSharper.Psi.Tree.ITreeNode;
        [JetBrains.Annotations.CanBeNullAttribute()]
        T FindNodeAtOffset<T>(int offset)
            where T :  class, JetBrains.ReSharper.Psi.Tree.ITreeNode;
    }
    public class WebContextActionDataProvider<TFile, TTypeLanguage> : JetBrains.ReSharper.Feature.Services.Bulbs.CachedContextActionDataProviderBase<TFile>, JetBrains.ReSharper.Feature.Services.Bulbs.IContextActionDataProvider, JetBrains.ReSharper.Feature.Services.Bulbs.IContextActionDataProvider<TFile>, JetBrains.ReSharper.Feature.Services.Html.Bulbs.IWebContextActionDataProvider<TFile>
        where TFile :  class, JetBrains.ReSharper.Psi.Html.Tree.IHtmlFile
        where TTypeLanguage : JetBrains.ReSharper.Psi.Html.HtmlLanguage
    {
        public WebContextActionDataProvider(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl, TFile file) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Feature.Services.Html.Bulbs.IWebContextActionDataProvider<TFile> Create([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.ISolution solution, [JetBrains.Annotations.NotNullAttribute()] JetBrains.TextControl.ITextControl textControl) { }
        public T FindNodeAtCaret<T>()
            where T :  class, JetBrains.ReSharper.Psi.Tree.ITreeNode { }
        public T FindNodeAtOffset<T>(int offset)
            where T :  class, JetBrains.ReSharper.Psi.Tree.ITreeNode { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.Html.CodeCleanup
{
    
    [JetBrains.ReSharper.Feature.Services.CodeCleanup.CodeCleanupModuleAttribute()]
    public class ReformatCode : JetBrains.ReSharper.Feature.Services.CodeCleanup.ICodeCleanupModule
    {
        public System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.CodeCleanup.CodeCleanupOptionDescriptor> Descriptors { get; }
        public bool IsAvailableOnSelection { get; }
        public JetBrains.ReSharper.Psi.PsiLanguageType LanguageType { get; }
        public bool IsAvailable(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
        public void Process(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, JetBrains.DocumentModel.IRangeMarker rangeMarker, JetBrains.ReSharper.Feature.Services.CodeCleanup.CodeCleanupProfile profile, JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
        public void SetDefaultSetting(JetBrains.ReSharper.Feature.Services.CodeCleanup.CodeCleanupProfile profile, JetBrains.ReSharper.Feature.Services.CodeCleanup.CodeCleanup.DefaultProfileType profileType) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.Html.CodeCompletion
{
    
    public class static HtmlAutomaticCodeCompletionStategiesUtils
    {
        public static bool CheckClassOrIDAttribute(this JetBrains.ReSharper.Psi.Html.Tree.IHtmlToken token) { }
        public static bool CheckClassOrIDAttribute(string attributeName) { }
        public static bool CheckClassOrIDAttribute(this JetBrains.ReSharper.Psi.Html.Tree.ITagAttribute tagAttribute) { }
        public static bool CheckNotClassOrIDAttribute(this JetBrains.ReSharper.Psi.Html.Tree.IHtmlToken token) { }
        public static bool MatchHtmlToken(this JetBrains.ReSharper.Feature.Services.CodeCompletion.IAutomaticCodeCompletionStrategy strategy, JetBrains.ReSharper.Psi.Tree.IFile file, JetBrains.TextControl.ITextControl textControl, System.Func<JetBrains.ReSharper.Psi.Html.Tree.IHtmlToken, bool> matcher) { }
        public static bool MatchHtmlTokenType(this JetBrains.ReSharper.Feature.Services.CodeCompletion.IAutomaticCodeCompletionStrategy strategy, JetBrains.ReSharper.Psi.Tree.IFile file, JetBrains.TextControl.ITextControl textControl, System.Func<JetBrains.ReSharper.Psi.Parsing.TokenNodeType, JetBrains.ReSharper.Psi.Html.Parsing.IHtmlTokenNodeTypes, bool> matcher) { }
    }
    public abstract class HtmlAutomaticStrategyOnCharacterBase<TFile> : JetBrains.ReSharper.Feature.Services.CodeCompletion.IAutomaticCodeCompletionStrategy
        where TFile : JetBrains.ReSharper.Psi.Html.Tree.IHtmlFile
    {
        public JetBrains.ReSharper.Feature.Services.CodeCompletion.CodeCompletionType CodeCompletionType { get; }
        public bool ForceHideCompletion { get; }
        public virtual JetBrains.ReSharper.Psi.PsiLanguageType Language { get; }
        public virtual bool AcceptsFile(JetBrains.ReSharper.Psi.Tree.IFile file, JetBrains.TextControl.ITextControl textControl) { }
        public abstract bool AcceptTyping(char c, JetBrains.TextControl.ITextControl textControl, JetBrains.Application.Settings.IContextBoundSettingsStore boundSettingsStore);
        public abstract JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.AutopopupType IsEnabledInSettings(JetBrains.Application.Settings.IContextBoundSettingsStore settingsStore, JetBrains.TextControl.ITextControl textControl);
        public bool ProcessSubsequentTyping(char c, JetBrains.TextControl.ITextControl textControl) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class HtmlAutomaticStrategyOnClassesAndID : JetBrains.ReSharper.Feature.Services.CodeCompletion.IAutomaticCodeCompletionStrategy
    {
        public HtmlAutomaticStrategyOnClassesAndID(JetBrains.Application.Settings.ISettingsStore settingsStore, JetBrains.ReSharper.Feature.Services.Html.CodeCompletion.Settings.HtmlIntellisenseManager htmlIntellisenseManager) { }
        public JetBrains.ReSharper.Feature.Services.CodeCompletion.CodeCompletionType CodeCompletionType { get; }
        public bool ForceHideCompletion { get; }
        public JetBrains.ReSharper.Psi.PsiLanguageType Language { get; }
        public bool AcceptsFile(JetBrains.ReSharper.Psi.Tree.IFile file, JetBrains.TextControl.ITextControl textControl) { }
        public bool AcceptTyping(char c, JetBrains.TextControl.ITextControl textControl, JetBrains.Application.Settings.IContextBoundSettingsStore boundSettingsStore) { }
        public JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.AutopopupType IsEnabledInSettings(JetBrains.Application.Settings.IContextBoundSettingsStore settingsStore, JetBrains.TextControl.ITextControl textControl) { }
        public bool ProcessSubsequentTyping(char c, JetBrains.TextControl.ITextControl textControl) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class HtmlAutomaticStrategyOnHash : JetBrains.ReSharper.Feature.Services.CodeCompletion.IAutomaticCodeCompletionStrategy
    {
        public HtmlAutomaticStrategyOnHash(JetBrains.ReSharper.Psi.Html.Html.IHtmlDeclaredElementTypes declaredElementTypes, JetBrains.ReSharper.Psi.Html.Html.IHtmlDeclaredElementsCache declaredElementsCache, JetBrains.ReSharper.Feature.Services.Html.CodeCompletion.Settings.HtmlIntellisenseManager htmlIntellisenseManager, JetBrains.Application.Settings.ISettingsStore settingsStore) { }
        public JetBrains.ReSharper.Feature.Services.CodeCompletion.CodeCompletionType CodeCompletionType { get; }
        public bool ForceHideCompletion { get; }
        public JetBrains.ReSharper.Psi.PsiLanguageType Language { get; }
        public bool AcceptsFile(JetBrains.ReSharper.Psi.Tree.IFile file, JetBrains.TextControl.ITextControl textControl) { }
        public bool AcceptTyping(char c, JetBrains.TextControl.ITextControl textControl, JetBrains.Application.Settings.IContextBoundSettingsStore boundSettingsStore) { }
        public JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.AutopopupType IsEnabledInSettings(JetBrains.Application.Settings.IContextBoundSettingsStore settingsStore, JetBrains.TextControl.ITextControl textControl) { }
        public bool ProcessSubsequentTyping(char c, JetBrains.TextControl.ITextControl textControl) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class HtmlAutomaticStrategyOnIdentifier : JetBrains.ReSharper.Feature.Services.CodeCompletion.IAutomaticCodeCompletionStrategy
    {
        public HtmlAutomaticStrategyOnIdentifier(JetBrains.Application.Settings.ISettingsStore settingsStore, JetBrains.ReSharper.Feature.Services.Html.CodeCompletion.Settings.HtmlIntellisenseManager htmlIntellisenseManager) { }
        public JetBrains.ReSharper.Feature.Services.CodeCompletion.CodeCompletionType CodeCompletionType { get; }
        public bool ForceHideCompletion { get; }
        public JetBrains.ReSharper.Psi.PsiLanguageType Language { get; }
        public bool AcceptsFile(JetBrains.ReSharper.Psi.Tree.IFile file, JetBrains.TextControl.ITextControl textControl) { }
        public bool AcceptTyping(char c, JetBrains.TextControl.ITextControl textControl, JetBrains.Application.Settings.IContextBoundSettingsStore boundSettingsStore) { }
        public JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.AutopopupType IsEnabledInSettings(JetBrains.Application.Settings.IContextBoundSettingsStore settingsStore, JetBrains.TextControl.ITextControl textControl) { }
        public bool ProcessSubsequentTyping(char c, JetBrains.TextControl.ITextControl textControl) { }
    }
    public abstract class HtmlAutomaticStrategyOnListedCharacters<TFile, TTokenNodeTypes> : JetBrains.ReSharper.Feature.Services.Html.CodeCompletion.HtmlAutomaticStrategyOnCharacterBase<TFile>
        where TFile : JetBrains.ReSharper.Psi.Html.Tree.IHtmlFile
        where TTokenNodeTypes : JetBrains.ReSharper.Psi.Html.Parsing.IHtmlTokenNodeTypes
    {
        public override bool AcceptsFile(JetBrains.ReSharper.Psi.Tree.IFile file, JetBrains.TextControl.ITextControl textControl) { }
        public override bool AcceptTyping(char c, JetBrains.TextControl.ITextControl textControl, JetBrains.Application.Settings.IContextBoundSettingsStore boundSettingsStore) { }
        protected abstract bool GetIntellisenseEnabled(JetBrains.Application.Settings.IContextBoundSettingsStore contextBoundSettingsStore);
        protected virtual System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.Html.CodeCompletion.HtmlAutomaticStrategyOnListedCharacters<TFile, TTokenNodeTypes>.StartChar> GetStartChars([JetBrains.Annotations.CanBeNullAttribute()] TTokenNodeTypes tokenNodeTypes) { }
        protected class StartChar<TFile, TTokenNodeTypes>
            where TFile : JetBrains.ReSharper.Psi.Html.Tree.IHtmlFile
            where TTokenNodeTypes : JetBrains.ReSharper.Psi.Html.Parsing.IHtmlTokenNodeTypes
        {
            public StartChar(char c, JetBrains.ReSharper.Psi.Parsing.TokenNodeType token, JetBrains.ReSharper.Psi.Parsing.TokenNodeType prevToken = null, System.Predicate<JetBrains.ReSharper.Psi.Html.Tree.IHtmlToken> additionalCheck = null) { }
            public StartChar(char c, JetBrains.ReSharper.Psi.Parsing.TokenNodeType token, JetBrains.ReSharper.Psi.PsiLanguageType prevLanguage) { }
            public System.Predicate<JetBrains.ReSharper.Psi.Html.Tree.IHtmlToken> AdditionalCheck { get; }
            public char Char { get; }
            public JetBrains.ReSharper.Psi.PsiLanguageType PrevLanguage { get; }
            public JetBrains.ReSharper.Psi.Parsing.TokenNodeType PrevToken { get; }
            public JetBrains.ReSharper.Psi.Parsing.TokenNodeType Token { get; }
        }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class HtmlAutomaticStrategyOnPunctuation : JetBrains.ReSharper.Feature.Services.Html.CodeCompletion.HtmlAutomaticStrategyOnListedCharacters<JetBrains.ReSharper.Psi.Html.Tree.IHtmlFile, JetBrains.ReSharper.Psi.Html.Parsing.IHtmlTokenNodeTypes>
    {
        public HtmlAutomaticStrategyOnPunctuation(JetBrains.Application.Settings.ISettingsStore settingsStore, JetBrains.ReSharper.Feature.Services.Html.CodeCompletion.Settings.HtmlIntellisenseManager htmlIntellisenseManager) { }
        protected override bool GetIntellisenseEnabled(JetBrains.Application.Settings.IContextBoundSettingsStore contextBoundSettingsStore) { }
        protected override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.Html.CodeCompletion.HtmlAutomaticStrategyOnListedCharacters<JetBrains.ReSharper.Psi.Html.Tree.IHtmlFile, JetBrains.ReSharper.Psi.Html.Parsing.IHtmlTokenNodeTypes>.StartChar> GetStartChars(JetBrains.ReSharper.Psi.Html.Parsing.IHtmlTokenNodeTypes tokenNodeTypes) { }
        public override JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.AutopopupType IsEnabledInSettings(JetBrains.Application.Settings.IContextBoundSettingsStore settingsStore, JetBrains.TextControl.ITextControl textControl) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class HtmlAutomaticStrategyOnPunctuationInClassesAndIDs : JetBrains.ReSharper.Feature.Services.Html.CodeCompletion.HtmlAutomaticStrategyOnListedCharacters<JetBrains.ReSharper.Psi.Html.Tree.IHtmlFile, JetBrains.ReSharper.Psi.Html.Parsing.IHtmlTokenNodeTypes>
    {
        public HtmlAutomaticStrategyOnPunctuationInClassesAndIDs(JetBrains.Application.Settings.ISettingsStore settingsStore, JetBrains.ReSharper.Feature.Services.Html.CodeCompletion.Settings.HtmlIntellisenseManager htmlIntellisenseManager) { }
        protected override bool GetIntellisenseEnabled(JetBrains.Application.Settings.IContextBoundSettingsStore contextBoundSettingsStore) { }
        protected override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.Html.CodeCompletion.HtmlAutomaticStrategyOnListedCharacters<JetBrains.ReSharper.Psi.Html.Tree.IHtmlFile, JetBrains.ReSharper.Psi.Html.Parsing.IHtmlTokenNodeTypes>.StartChar> GetStartChars(JetBrains.ReSharper.Psi.Html.Parsing.IHtmlTokenNodeTypes tokenNodeTypes) { }
        public override JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.AutopopupType IsEnabledInSettings(JetBrains.Application.Settings.IContextBoundSettingsStore settingsStore, JetBrains.TextControl.ITextControl textControl) { }
    }
    public abstract class HtmlAutomaticStrategyOnWhitespaceBase<TFile> : JetBrains.ReSharper.Feature.Services.Html.CodeCompletion.HtmlAutomaticStrategyOnCharacterBase<TFile>
        where TFile : JetBrains.ReSharper.Psi.Html.Tree.IHtmlFile
    {
        public override bool AcceptsFile(JetBrains.ReSharper.Psi.Tree.IFile file, JetBrains.TextControl.ITextControl textControl) { }
        public override bool AcceptTyping(char c, JetBrains.TextControl.ITextControl textControl, JetBrains.Application.Settings.IContextBoundSettingsStore boundSettingsStore) { }
        protected abstract bool GetIntellisenseEnabled(JetBrains.Application.Settings.IContextBoundSettingsStore toDataContext);
        protected abstract bool ShouldPopup(JetBrains.ReSharper.Psi.Html.Tree.IHtmlToken tokenNode);
    }
    public class HtmlCodeCompletionContext : JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.SpecificCodeCompletionContext
    {
        public HtmlCodeCompletionContext(JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.CodeCompletionContext context, JetBrains.ReSharper.Feature.Services.Html.CodeCompletion.HtmlReparsedCompletionContext unterminatedContext, JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.TextLookupRanges ranges) { }
        public override string ContextId { get; }
        public JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.TextLookupRanges Ranges { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Psi.Resolve.IReference Reference { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Psi.Tree.ITreeNode TreeNode { get; }
        public JetBrains.ReSharper.Feature.Services.Html.CodeCompletion.HtmlReparsedCompletionContext UnterminatedContext { get; }
        public virtual JetBrains.ReSharper.Feature.Services.Lookup.DeclaredElementLookupItem CreateDeclaredElementLookupItem(string name, JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
        public virtual string GetDisplayNameByDeclaredElement(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
        public virtual void ReparseAfterCompletionIfNeeded() { }
    }
    [JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.IntellisensePartAttribute()]
    public class HtmlCodeCompletionContextProvider : JetBrains.ReSharper.Feature.Services.CodeCompletion.Impl.CodeCompletionContextProviderBase
    {
        public HtmlCodeCompletionContextProvider(JetBrains.ReSharper.Feature.Services.Html.CodeCompletion.Settings.HtmlIntellisenseManager htmlIntellisenseManager, JetBrains.ReSharper.Psi.Html.Html.IHtmlDeclaredElementTypes htmlCache) { }
        public override JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ISpecificCodeCompletionContext GetCompletionContext(JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.CodeCompletionContext context) { }
        protected virtual JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ISpecificCodeCompletionContext GetSpecificContext(JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.CodeCompletionContext context, JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.TextLookupRanges ranges, JetBrains.ReSharper.Feature.Services.Html.CodeCompletion.HtmlReparsedCompletionContext unterminatedContext) { }
        public override bool IsApplicable(JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.CodeCompletionContext context) { }
        protected virtual bool IsIntellisenseEnabled(JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.CodeCompletionContext context) { }
        protected virtual bool ReferenceIsAcceptableForHtmlCompletion(JetBrains.ReSharper.Psi.Resolve.IReference referenceToComplete, JetBrains.ReSharper.Psi.Tree.ITreeNode elementToComplete) { }
    }
    [JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.IntellisensePartAttribute()]
    public class HtmlCompletingCharactersProvider : JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.CompletingCharsProviderWithSetting<JetBrains.ReSharper.Feature.Services.Html.CodeCompletion.HtmlCodeCompletionContext, JetBrains.ReSharper.Feature.Services.Html.CodeCompletion.HtmlCompletingCharactersSettingsKey>
    {
        protected override System.Linq.Expressions.Expression<System.Func<JetBrains.ReSharper.Feature.Services.Html.CodeCompletion.HtmlCompletingCharactersSettingsKey, bool>> GetCompleteOnSpaceSettingKey() { }
        protected override System.Linq.Expressions.Expression<System.Func<JetBrains.ReSharper.Feature.Services.Html.CodeCompletion.HtmlCompletingCharactersSettingsKey, JetBrains.ReSharper.Feature.Services.Lookup.LookupItemInsertType>> GetEnterActionSettingKey() { }
        protected override System.Linq.Expressions.Expression<System.Func<JetBrains.ReSharper.Feature.Services.Html.CodeCompletion.HtmlCompletingCharactersSettingsKey, string>> GetNonCompletingCharactersSettingKey() { }
        protected override System.Linq.Expressions.Expression<System.Func<JetBrains.ReSharper.Feature.Services.Html.CodeCompletion.HtmlCompletingCharactersSettingsKey, JetBrains.ReSharper.Feature.Services.Lookup.LookupItemInsertType>> GetTabActionSettingKey() { }
        protected override bool IsApplicable(JetBrains.ReSharper.Feature.Services.Html.CodeCompletion.HtmlCodeCompletionContext context) { }
        protected override JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.CompletionAction IsCharacterAcceptable(char c, JetBrains.ReSharper.Feature.Services.Html.CodeCompletion.HtmlCodeCompletionContext context, JetBrains.Application.Settings.IContextBoundSettingsStore settingsStore) { }
    }
    [JetBrains.Application.Settings.SettingsKeyAttribute(typeof(JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.IntelliSenseCompletingCharactersSettingsKey), "Html")]
    public class HtmlCompletingCharactersSettingsKey
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
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.Html.HtmlLanguage))]
    public class HtmlCompletionRangesProvider : JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ItemsProviderOfSpecificContext<JetBrains.ReSharper.Feature.Services.Html.CodeCompletion.HtmlCodeCompletionContext>, JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ICodeCompletionItemsProvider, JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ICompletionRangesProvider
    {
        protected override JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.TextLookupRanges GetDefaultRanges(JetBrains.ReSharper.Feature.Services.Html.CodeCompletion.HtmlCodeCompletionContext context) { }
    }
    public class HtmlDeclaredElementLookupItem : JetBrains.ReSharper.Feature.Services.Html.CodeCompletion.HtmlDeclaredElementLookupItemBase
    {
        public HtmlDeclaredElementLookupItem(JetBrains.ReSharper.Psi.DeclaredElementInstance<JetBrains.ReSharper.Psi.IDeclaredElement> declaredElement, string name, string displayName, JetBrains.ReSharper.Feature.Services.Html.CodeCompletion.HtmlCodeCompletionContext context, JetBrains.ReSharper.Psi.PsiLanguageType languageType, JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.TextLookupRanges ranges) { }
        protected override JetBrains.ReSharper.Psi.CodeStyle.Casing Casing { get; }
        public override void Accept(JetBrains.TextControl.ITextControl textControl, JetBrains.Util.TextRange nameRange, JetBrains.ReSharper.Feature.Services.Lookup.LookupItemInsertType lookupItemInsertType, JetBrains.ReSharper.Feature.Services.Lookup.Suffix suffix, JetBrains.ProjectModel.ISolution solution, bool keepCaretStill) { }
        protected override void FixInsertedText(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
    }
    public abstract class HtmlDeclaredElementLookupItemBase : JetBrains.ReSharper.Feature.Services.Lookup.Impl.DeclaredElementLookupItem<JetBrains.ReSharper.Psi.Html.References.IHtmlCompleteableReference, JetBrains.ReSharper.Psi.Html.Tree.IHtmlFile>
    {
        protected HtmlDeclaredElementLookupItemBase(JetBrains.ReSharper.Psi.DeclaredElementInstance<JetBrains.ReSharper.Psi.IDeclaredElement> declaredElement, string name, string displayName, JetBrains.ReSharper.Feature.Services.Html.CodeCompletion.HtmlCodeCompletionContext context, JetBrains.ReSharper.Psi.PsiLanguageType languageType, JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.TextLookupRanges ranges) { }
        protected char[] AllowableSuffixes { get; set; }
        public JetBrains.ReSharper.Feature.Services.Html.IHtmlDescriptionsCache HtmlDescriptionsCache { get; }
        protected static JetBrains.ReSharper.Psi.Html.Impl.CodeStyle.VsHtmlFormatSettings VsHtmlFormatSettings { get; }
        protected override JetBrains.ReSharper.Psi.Resolve.IReference BindReferenceAfterComplete(JetBrains.TextControl.ITextControl textControl, JetBrains.Util.TextRange nameRange) { }
        protected abstract void FixInsertedText(JetBrains.ReSharper.Psi.Resolve.IReference reference);
        protected JetBrains.ReSharper.Feature.Services.TypingAssist.SkippingTypingAssist GetSkippingTypingAssist() { }
        protected override void OnAfterComplete(JetBrains.TextControl.ITextControl textControl, ref JetBrains.Util.TextRange nameRange, ref JetBrains.Util.TextRange decorationRange, JetBrains.ReSharper.Psi.ExpectedTypes.TailType tailType, ref JetBrains.ReSharper.Feature.Services.Lookup.Suffix suffix, ref JetBrains.DocumentModel.IRangeMarker caretPositionRangeMarker) { }
        protected override void PlaybackSuffix(JetBrains.TextControl.ITextControl textControl, JetBrains.ReSharper.Feature.Services.Lookup.Suffix suffix) { }
    }
    public class HtmlFooterItem : JetBrains.ReSharper.Feature.Services.Lookup.TextLookupItemBase
    {
        public HtmlFooterItem(string text, [JetBrains.Annotations.NotNullAttribute()] JetBrains.UI.Icons.IconId image, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Feature.Services.Html.CodeCompletion.HtmlCodeCompletionContext context) { }
        public override JetBrains.UI.Icons.IconId Image { get; }
        public override void Accept(JetBrains.TextControl.ITextControl textControl, JetBrains.Util.TextRange nameRange, JetBrains.ReSharper.Feature.Services.Lookup.LookupItemInsertType lookupItemInsertType, JetBrains.ReSharper.Feature.Services.Lookup.Suffix suffix, JetBrains.ProjectModel.ISolution solution, bool keepCaretStill) { }
        protected override void OnAfterComplete(JetBrains.TextControl.ITextControl textControl, ref JetBrains.Util.TextRange nameRange, ref JetBrains.Util.TextRange decorationRange, JetBrains.ReSharper.Psi.ExpectedTypes.TailType tailType, ref JetBrains.ReSharper.Feature.Services.Lookup.Suffix suffix, ref JetBrains.DocumentModel.IRangeMarker caretPositionRangeMarker) { }
        protected override void PlaybackSuffix(JetBrains.TextControl.ITextControl textControl, JetBrains.ReSharper.Feature.Services.Lookup.Suffix suffix) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.Html.HtmlLanguage))]
    public class HtmlReferencedItemsProvider : JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ItemsProviderOfSpecificContext<JetBrains.ReSharper.Feature.Services.Html.CodeCompletion.HtmlCodeCompletionContext>
    {
        public HtmlReferencedItemsProvider(JetBrains.ReSharper.Psi.Html.Parsing.IHtmlTokenNodeTypes tokenNodeTypes) { }
        protected override void AddItemsGroups(JetBrains.ReSharper.Feature.Services.Html.CodeCompletion.HtmlCodeCompletionContext context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector, JetBrains.ReSharper.Feature.Services.CodeCompletion.IntellisenseManager intellisenseManager) { }
        protected override bool AddLookupItems(JetBrains.ReSharper.Feature.Services.Html.CodeCompletion.HtmlCodeCompletionContext context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector) { }
        protected virtual void CollectElement(string name, JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, JetBrains.ReSharper.Feature.Services.Html.CodeCompletion.HtmlCodeCompletionContext context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector) { }
        protected virtual System.Collections.Generic.IEnumerable<string> GetAttributesByImportance(JetBrains.ReSharper.Psi.Resolve.IReference qualifier) { }
        protected virtual JetBrains.Text.IdentifierMatcher GetIdentifierMatcher(JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.CodeCompletionContext context, JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.TextLookupRanges ranges) { }
        protected override JetBrains.ReSharper.Feature.Services.Lookup.LookupFocusBehaviour GetLookupFocusBehaviour(JetBrains.ReSharper.Feature.Services.Html.CodeCompletion.HtmlCodeCompletionContext context) { }
        protected virtual JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetSymbolTable(JetBrains.ReSharper.Feature.Services.Html.CodeCompletion.HtmlCodeCompletionContext context) { }
        protected override bool IsAvailable(JetBrains.ReSharper.Feature.Services.Html.CodeCompletion.HtmlCodeCompletionContext context) { }
    }
    public class HtmlReparsedCompletionContext : JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ReparsedCodeCompletionContext
    {
        public HtmlReparsedCompletionContext([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.IFile file, JetBrains.ReSharper.Psi.TreeTextRange range, string newText) { }
        protected override JetBrains.ReSharper.Psi.Services.IReparseContext GetReparseContext(JetBrains.ReSharper.Psi.Tree.IFile file, JetBrains.ReSharper.Psi.TreeTextRange range) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.Html.HtmlLanguage))]
    public class HtmlTagFooterItemsProvider : JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ItemsProviderOfSpecificContext<JetBrains.ReSharper.Feature.Services.Html.CodeCompletion.HtmlCodeCompletionContext>
    {
        protected override bool AddLookupItems(JetBrains.ReSharper.Feature.Services.Html.CodeCompletion.HtmlCodeCompletionContext context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector) { }
        protected override bool IsAvailable(JetBrains.ReSharper.Feature.Services.Html.CodeCompletion.HtmlCodeCompletionContext context) { }
    }
    public class HtmlTagNameLookupItem : JetBrains.ReSharper.Feature.Services.Html.CodeCompletion.HtmlDeclaredElementLookupItemBase
    {
        public HtmlTagNameLookupItem(JetBrains.ReSharper.Psi.DeclaredElementInstance<JetBrains.ReSharper.Psi.IDeclaredElement> declaredElement, string name, string displayName, JetBrains.ReSharper.Feature.Services.Html.CodeCompletion.HtmlCodeCompletionContext context, JetBrains.ReSharper.Psi.PsiLanguageType languageType, JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.TextLookupRanges ranges) { }
        protected override JetBrains.ReSharper.Psi.CodeStyle.Casing Casing { get; }
        public override bool HasCandidates { get; }
        protected bool SkipFooterUpdate { get; set; }
        public override void Accept(JetBrains.TextControl.ITextControl textControl, JetBrains.Util.TextRange nameRange, JetBrains.ReSharper.Feature.Services.Lookup.LookupItemInsertType lookupItemInsertType, JetBrains.ReSharper.Feature.Services.Lookup.Suffix suffix, JetBrains.ProjectModel.ISolution solution, bool keepCaretStill) { }
        protected bool CloseTag(JetBrains.ReSharper.Psi.Html.Tree.IHtmlTag tag) { }
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.ParameterInfo.ICandidate> CreateCandidates() { }
        protected override void FixInsertedText(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
    }
    public class OrderedNamesSelector : JetBrains.ReSharper.Feature.Services.Lookup.ILookupItemsPreference
    {
        public OrderedNamesSelector(System.Collections.Generic.IEnumerable<string> orderedList) { }
        public int Order { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem> FilterItems(System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem> items) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.Html.CodeCompletion.HtmlEntities
{
    
    public class HtmlEntityCodeCompletionContext : JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.SpecificCodeCompletionContext
    {
        public HtmlEntityCodeCompletionContext(JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.CodeCompletionContext context, JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.TextLookupRanges ranges) { }
        public override string ContextId { get; }
        public JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.TextLookupRanges Ranges { get; }
    }
    [JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.IntellisensePartAttribute()]
    public class HtmlEntityCodeCompletionContextProvider : JetBrains.ReSharper.Feature.Services.CodeCompletion.Impl.CodeCompletionContextProviderBase
    {
        public HtmlEntityCodeCompletionContextProvider(JetBrains.ReSharper.Psi.ILanguageManager languageManager, JetBrains.ReSharper.Feature.Services.Html.CodeCompletion.Settings.HtmlIntellisenseManager htmlIntellisenseManager) { }
        public override JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ISpecificCodeCompletionContext GetCompletionContext(JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.CodeCompletionContext context) { }
        public override bool IsApplicable(JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.CodeCompletionContext context) { }
    }
    public class HtmlEntityDefaultLookupItem : JetBrains.ReSharper.Feature.Services.Lookup.TextLookupItem
    {
        public HtmlEntityDefaultLookupItem() { }
        public override void Accept(JetBrains.TextControl.ITextControl textControl, JetBrains.Util.TextRange nameRange, JetBrains.ReSharper.Feature.Services.Lookup.LookupItemInsertType lookupItemInsertType, JetBrains.ReSharper.Feature.Services.Lookup.Suffix suffix, JetBrains.ProjectModel.ISolution solution, bool keepCaretStill) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.Html.HtmlLanguage))]
    public class HtmlEntityItemsProvider : JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ItemsProviderOfSpecificContext<JetBrains.ReSharper.Feature.Services.Html.CodeCompletion.HtmlEntities.HtmlEntityCodeCompletionContext>
    {
        protected override bool AddLookupItems(JetBrains.ReSharper.Feature.Services.Html.CodeCompletion.HtmlEntities.HtmlEntityCodeCompletionContext context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector) { }
        protected override JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.TextLookupRanges GetDefaultRanges(JetBrains.ReSharper.Feature.Services.Html.CodeCompletion.HtmlEntities.HtmlEntityCodeCompletionContext context) { }
        protected override bool IsAvailable(JetBrains.ReSharper.Feature.Services.Html.CodeCompletion.HtmlEntities.HtmlEntityCodeCompletionContext context) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.Html.CodeCompletion.Settings
{
    
    [JetBrains.Application.Settings.SettingsKeyAttribute(typeof(JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.AutopopupEnabledSettingsKey), "HTML")]
    public class HtmlAutopopupEnabledSettingsKey
    {
        [JetBrains.Application.Settings.SettingsEntryAttribute(JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.AutopopupType.SoftAutopopup, "On classes and IDs")]
        public JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.AutopopupType OnClassesAndIDs;
        [JetBrains.Application.Settings.SettingsEntryAttribute(JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.AutopopupType.HardAutopopup, "On \'#\'")]
        public JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.AutopopupType OnHash;
        [JetBrains.Application.Settings.SettingsEntryAttribute(JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.AutopopupType.HardAutopopup, "On identifiers")]
        public JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.AutopopupType OnIdentifiers;
        [JetBrains.Application.Settings.SettingsEntryAttribute(JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.AutopopupType.HardAutopopup, "On punctuation")]
        public JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.AutopopupType OnPunctuation;
        [JetBrains.Application.Settings.SettingsEntryAttribute(JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.AutopopupType.HardAutopopup, "On space")]
        public JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.AutopopupType OnSpace;
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class HtmlIntellisenseManager : JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.LanguageSpecificIntellisenseManager
    {
        public HtmlIntellisenseManager(JetBrains.Application.Settings.ISettingsStore settingsStore) { }
        protected override bool GetIntellisenseEnabledSpecific(JetBrains.Application.Settings.IContextBoundSettingsStore boundSettingsStore) { }
    }
    [JetBrains.Application.Settings.SettingsKeyAttribute(typeof(JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.IntellisenseEnabledSettingsKey), "Override VS IntelliSense for HTML")]
    public class IntellisenseEnabledSettingHtml
    {
        [JetBrains.Application.Settings.SettingsEntryAttribute(false, "HTML (.html files and server pages)")]
        public bool IntellisenseEnabled;
    }
}
namespace JetBrains.ReSharper.Feature.Services.Html.CodeStructure
{
    
    public abstract class HtmlCodeStructureElement<T> : JetBrains.ReSharper.Feature.Services.CodeStructure.CodeStructureElement, JetBrains.ReSharper.Feature.Services.CodeStructure.IFileStructureAspect, JetBrains.ReSharper.Feature.Services.CodeStructure.IGotoFileMemberAspect, JetBrains.ReSharper.Feature.Services.CodeStructure.IMemberNavigationAspect
        where T :  class, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode
    {
        protected readonly JetBrains.ReSharper.Psi.Html.Parsing.IHtmlTokenNodeTypes myTokentypes;
        protected static readonly JetBrains.UI.RichText.TextStyle NAME_STYLE;
        protected HtmlCodeStructureElement(T element, JetBrains.ReSharper.Psi.Html.Parsing.IHtmlTokenNodeTypes tokenTypes, JetBrains.ReSharper.Feature.Services.CodeStructure.CodeStructureElement parent) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        protected T Element { get; }
        public bool InitiallyExpanded { get; }
        public override JetBrains.ReSharper.Psi.PsiLanguageType Language { get; }
        public virtual JetBrains.DocumentModel.DocumentRange NavigationRange { get; }
        public override JetBrains.ReSharper.Psi.Tree.ITreeNode TreeNode { get; }
        public bool CanMoveElements(JetBrains.UI.TreeView.RelativeLocation location, System.Collections.Generic.IList<JetBrains.ReSharper.Feature.Services.CodeStructure.CodeStructureElement> dropElements) { }
        public bool CanRemove() { }
        public virtual bool CanRename() { }
        protected override void DumpSelf(System.IO.TextWriter builder) { }
        public override JetBrains.ReSharper.Feature.Services.CodeStructure.IFileStructureAspect GetFileStructureAspect() { }
        public override JetBrains.ReSharper.Feature.Services.CodeStructure.IGotoFileMemberAspect GetGotoMemberAspect() { }
        public override JetBrains.ReSharper.Feature.Services.CodeStructure.IMemberNavigationAspect GetMemberNavigationAspect() { }
        public virtual JetBrains.DocumentModel.DocumentRange[] GetNavigationRanges() { }
        protected abstract JetBrains.Util.JetTuple<JetBrains.UI.Icons.IconId, JetBrains.UI.RichText.RichText, JetBrains.UI.RichText.RichText> GetPresentation(JetBrains.UI.TreeView.PresentationState state);
        public abstract System.Collections.Generic.IList<string> GetQuickSearchTexts();
        public JetBrains.ReSharper.Psi.IPsiSourceFile GetSourceFile() { }
        public override JetBrains.Util.TextRange GetTextRange() { }
        public virtual string InitialName() { }
        public virtual void MoveElements(JetBrains.UI.TreeView.RelativeLocation location, System.Collections.Generic.IList<JetBrains.ReSharper.Feature.Services.CodeStructure.CodeStructureElement> dropElements) { }
        public virtual void Present(JetBrains.UI.TreeView.StructuredPresenter<JetBrains.TreeModels.TreeModelNode, JetBrains.CommonControls.IPresentableItem> presenter, JetBrains.CommonControls.IPresentableItem item, JetBrains.TreeModels.TreeModelNode modelNode, JetBrains.UI.TreeView.PresentationState state) { }
        public virtual void Present(JetBrains.UI.PopupMenu.IMenuItemDescriptor descriptor, JetBrains.UI.TreeView.PresentationState state) { }
        public virtual void Remove() { }
        public virtual void Rename(string newName) { }
    }
    [JetBrains.ProjectModel.ProjectFileTypeAttribute(typeof(JetBrains.ProjectModel.HtmlProjectFileType))]
    public class HtmlCodeStructureProvider : JetBrains.ReSharper.Feature.Services.CodeStructure.IProjectFileCodeStructureProvider
    {
        public HtmlCodeStructureProvider(JetBrains.ReSharper.Psi.ILanguageManager languageManager) { }
        public JetBrains.ReSharper.Feature.Services.CodeStructure.CodeStructureRootElement Build(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, JetBrains.ReSharper.Feature.Services.CodeStructure.CodeStructureOptions options) { }
        protected virtual JetBrains.ReSharper.Psi.IRecursiveElementProcessor CreateElementProcessor(JetBrains.ReSharper.Feature.Services.Html.CodeStructure.HtmlCodeStructureRootElement root, JetBrains.ReSharper.Psi.Html.Parsing.IHtmlTokenNodeTypes tokenTypes) { }
        protected class HtmlCodeStructureRecursiveElementProcessor : JetBrains.ReSharper.Psi.IRecursiveElementProcessor
        {
            protected readonly System.Collections.Generic.Stack<JetBrains.ReSharper.Feature.Services.CodeStructure.CodeStructureElement> myParentElements;
            protected readonly JetBrains.ReSharper.Feature.Services.CodeStructure.CodeStructureRootElement myRoot;
            protected readonly JetBrains.ReSharper.Psi.Html.Parsing.IHtmlTokenNodeTypes myTokenTypes;
            protected static readonly System.Collections.Generic.JetHashSet<string> ourIgnoreTags;
            public HtmlCodeStructureRecursiveElementProcessor(JetBrains.ReSharper.Psi.Html.Parsing.IHtmlTokenNodeTypes tokenTypes, JetBrains.ReSharper.Feature.Services.CodeStructure.CodeStructureRootElement root) { }
            public bool ProcessingIsFinished { get; }
            public virtual bool InteriorShouldBeProcessed(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
            public void ProcessAfterInterior(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
            public virtual void ProcessBeforeInterior(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
            protected virtual bool ProcessTagAnyway(JetBrains.ReSharper.Psi.Html.Tree.IHtmlTag tag) { }
        }
    }
    public class HtmlCodeStructureRootElement : JetBrains.ReSharper.Feature.Services.CodeStructure.CodeStructureRootElement
    {
        public HtmlCodeStructureRootElement(JetBrains.ReSharper.Psi.Tree.IFile file) { }
    }
    public class static HtmlCodeStructureUtils
    {
        public static JetBrains.UI.RichText.RichText CreateCodeText(JetBrains.ReSharper.Psi.TreeTextRange wholeCodeRange, JetBrains.ReSharper.Psi.TreeTextRange trimmedCodeRange, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.IFile file) { }
        public static System.Collections.Generic.IEnumerable<T> GetSiblingsAfterAndSelf<T>(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.TreeTextRange range)
            where T : JetBrains.ReSharper.Psi.Tree.ITreeNode { }
        public static System.Collections.Generic.IEnumerable<T> GetSiblingsAndSelf<T>(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.TreeTextRange range, System.Func<JetBrains.ReSharper.Psi.Tree.ITreeNode, System.Func<JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Tree.TreeNodeActionType>, JetBrains.ReSharper.Psi.Tree.ITreeNode> finder)
            where T : JetBrains.ReSharper.Psi.Tree.ITreeNode { }
        public static System.Collections.Generic.IEnumerable<T> GetSiblingsBeforeAndSelf<T>(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.TreeTextRange range)
            where T : JetBrains.ReSharper.Psi.Tree.ITreeNode { }
        public static JetBrains.ReSharper.Psi.TreeTextRange TrimCodeRangeViaGeneratedPsi(JetBrains.DocumentModel.DocumentRange originalRange, JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, JetBrains.ReSharper.Psi.Tree.IFile originalFile) { }
        public static JetBrains.ReSharper.Psi.TreeTextRange TrimRange(JetBrains.ReSharper.Psi.Tree.IFile file, JetBrains.ReSharper.Psi.TreeTextRange sourceTreeRange, System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.Parsing.TokenNodeType> skipNodes) { }
    }
    public class HtmlConditionalCommentCodeStructureElement : JetBrains.ReSharper.Feature.Services.Html.CodeStructure.HtmlCodeStructureElement<JetBrains.ReSharper.Psi.Html.Tree.IHtmlConditionalComment>
    {
        public HtmlConditionalCommentCodeStructureElement(JetBrains.ReSharper.Psi.Html.Tree.IHtmlConditionalComment element, JetBrains.ReSharper.Psi.Html.Parsing.IHtmlTokenNodeTypes tokenTypes, JetBrains.ReSharper.Feature.Services.CodeStructure.CodeStructureElement parent) { }
        protected override JetBrains.Util.JetTuple<JetBrains.UI.Icons.IconId, JetBrains.UI.RichText.RichText, JetBrains.UI.RichText.RichText> GetPresentation(JetBrains.UI.TreeView.PresentationState state) { }
        public override System.Collections.Generic.IList<string> GetQuickSearchTexts() { }
    }
    public class HtmlTagCodeStructureElement<TTag> : JetBrains.ReSharper.Feature.Services.Html.CodeStructure.HtmlCodeStructureElement<TTag>
        where TTag :  class, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTag
    {
        protected readonly System.Collections.Generic.IDictionary<string, JetBrains.ReSharper.Feature.Services.Html.CodeStructure.HtmlTagCodeStructureElement<TTag>.AttributeType> AttributeTypes;
        public HtmlTagCodeStructureElement(TTag tag, JetBrains.ReSharper.Psi.Html.Parsing.IHtmlTokenNodeTypes tokenTypes, JetBrains.ReSharper.Feature.Services.CodeStructure.CodeStructureElement parent) { }
        public override JetBrains.DocumentModel.DocumentRange NavigationRange { get; }
        protected virtual JetBrains.UI.RichText.RichText DecorElement([JetBrains.Annotations.NotNullAttribute()] TTag tag, JetBrains.UI.RichText.RichText text) { }
        public override JetBrains.DocumentModel.DocumentRange[] GetNavigationRanges() { }
        protected override JetBrains.Util.JetTuple<JetBrains.UI.Icons.IconId, JetBrains.UI.RichText.RichText, JetBrains.UI.RichText.RichText> GetPresentation(JetBrains.UI.TreeView.PresentationState state) { }
        public override System.Collections.Generic.IList<string> GetQuickSearchTexts() { }
        protected enum AttributeType<TTag>
            where TTag :  class, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTag
        {
            Id = 0,
            Class = 1,
            Others = 2,
        }
    }
    public interface ISkipNodesProvider
    {
        System.Collections.Generic.JetHashSet<JetBrains.ReSharper.Psi.Parsing.TokenNodeType> Nodes { get; }
    }
}
namespace JetBrains.ReSharper.Feature.Services.Html.Comment
{
    
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.Html.HtmlLanguage))]
    public class HtmlBlockCommentActionProvider : JetBrains.ReSharper.Feature.Services.Comment.IBlockCommentActionProvider
    {
        public HtmlBlockCommentActionProvider(JetBrains.ReSharper.Psi.Html.Parsing.IHtmlTokenNodeTypes tokenNodeTypes) { }
        protected virtual JetBrains.ReSharper.Psi.Parsing.TokenNodeType CommentBody { get; }
        protected virtual JetBrains.ReSharper.Psi.Parsing.TokenNodeType CommentEnd { get; }
        protected virtual JetBrains.ReSharper.Psi.Parsing.TokenNodeType CommentStart { get; }
        public virtual string EndBlockCommentMarker { get; }
        public string NestedEndBlockCommentMarker { get; }
        public string NestedStartBlockCommentMarker { get; }
        public virtual string StartBlockCommentMarker { get; }
        public JetBrains.Util.TextRange GetBlockComment(JetBrains.ReSharper.Psi.Parsing.CachingLexer lexer) { }
        public int InsertBockCommentPosition(JetBrains.ReSharper.Psi.Parsing.ILexer lexer, int position) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.Html.HtmlLanguage))]
    public class HtmlLineCommentActionProvider : JetBrains.ReSharper.Feature.Services.Comment.ILineCommentActionProvider
    {
        public HtmlLineCommentActionProvider(JetBrains.ReSharper.Psi.Html.Parsing.IHtmlTokenNodeTypes tokenNodeTypes) { }
        protected virtual JetBrains.ReSharper.Psi.Parsing.TokenNodeType CommentEnd { get; }
        protected virtual JetBrains.ReSharper.Psi.Parsing.TokenNodeType CommentStart { get; }
        public virtual string EndLineCommentMarker { get; }
        public virtual string StartLineCommentMarker { get; }
        public JetBrains.Util.TextRange GetLineCommentRange(JetBrains.ReSharper.Psi.Parsing.CachingLexer lexer, JetBrains.Util.TextRange lineRange, out int startCommentLength, out int endCommentLength, out bool doNotUncomment) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.Html.ContextHighlighters
{
    
    [JetBrains.ReSharper.Daemon.CaretDependentFeatures.ContainsContextConsumerAttribute()]
    public class HtmlMatchingAttrValueQuotesContextHighlighter : JetBrains.ReSharper.Feature.Services.ContextHighlighters.MatchingBraceContextHighlighterBase
    {
        public HtmlMatchingAttrValueQuotesContextHighlighter(JetBrains.ReSharper.Feature.Services.Html.Bulbs.IWebContextActionDataProvider<JetBrains.ReSharper.Psi.Html.Tree.IHtmlFile> dataProvider) { }
        protected override bool IsLeftBracket(JetBrains.ReSharper.Psi.Parsing.TokenNodeType tokenType) { }
        protected override bool IsRightBracket(JetBrains.ReSharper.Psi.Parsing.TokenNodeType tokenType) { }
        protected override bool Match(JetBrains.ReSharper.Psi.Parsing.TokenNodeType token1, JetBrains.ReSharper.Psi.Parsing.TokenNodeType token2) { }
        [JetBrains.ReSharper.Daemon.CaretDependentFeatures.AsyncContextConsumerAttribute()]
        public static System.Action ProcessDataContext(JetBrains.DataFlow.Lifetime lifetime, [JetBrains.ReSharper.Daemon.CaretDependentFeatures.ContextKeyAttribute(typeof(JetBrains.ReSharper.Intentions.Html.ContextActions.HtmlContextActionDataProvider.ContextKey))] JetBrains.ReSharper.Feature.Services.Html.Bulbs.IWebContextActionDataProvider<JetBrains.ReSharper.Psi.Html.Tree.IHtmlFile> dataProvider, JetBrains.ReSharper.Daemon.CaretDependentFeatures.InvisibleBraceHintManager invisibleBraceHintManager, JetBrains.ReSharper.Feature.Services.ContextHighlighters.MatchingBraceSuggester matchingBraceSuggester) { }
        protected override void TryHighlightToLeft(JetBrains.ReSharper.Feature.Services.ContextHighlighters.MatchingHighlightingsConsumer consumer, JetBrains.ReSharper.Psi.Tree.ITokenNode selectedToken, JetBrains.ReSharper.Psi.TreeOffset treeOffset) { }
        protected override void TryHighlightToRight(JetBrains.ReSharper.Feature.Services.ContextHighlighters.MatchingHighlightingsConsumer consumer, JetBrains.ReSharper.Psi.Tree.ITokenNode selectedToken, JetBrains.ReSharper.Psi.TreeOffset treeOffset) { }
    }
    [JetBrains.ReSharper.Daemon.CaretDependentFeatures.ContainsContextConsumerAttribute()]
    public class HtmlMatchingBracesContextHighlighter : JetBrains.ReSharper.Feature.Services.ContextHighlighters.ContextHighlighterBase
    {
        public HtmlMatchingBracesContextHighlighter(JetBrains.ReSharper.Feature.Services.Html.Bulbs.IWebContextActionDataProvider<JetBrains.ReSharper.Psi.Html.Tree.IHtmlFile> dataProvider) { }
        protected override void CollectHighlightings(JetBrains.ReSharper.Feature.Services.Bulbs.IContextActionDataProvider dataProvider, JetBrains.ReSharper.Feature.Services.ContextHighlighters.MatchingHighlightingsConsumer consumer) { }
        [JetBrains.ReSharper.Daemon.CaretDependentFeatures.AsyncContextConsumerAttribute()]
        public static System.Action ProcessDataContext(JetBrains.DataFlow.Lifetime lifetime, [JetBrains.ReSharper.Daemon.CaretDependentFeatures.ContextKeyAttribute(typeof(JetBrains.ReSharper.Intentions.Html.ContextActions.HtmlContextActionDataProvider.ContextKey))] JetBrains.ReSharper.Feature.Services.Html.Bulbs.IWebContextActionDataProvider<JetBrains.ReSharper.Psi.Html.Tree.IHtmlFile> dataProvider, JetBrains.ReSharper.Daemon.CaretDependentFeatures.InvisibleBraceHintManager invisibleBraceHintManager, JetBrains.ReSharper.Feature.Services.ContextHighlighters.MatchingBraceSuggester matchingBraceSuggester) { }
    }
    [JetBrains.ReSharper.Daemon.CaretDependentFeatures.ContainsContextConsumerAttribute()]
    public class HtmlMatchingCDataBracesContextHighlighter : JetBrains.ReSharper.Feature.Services.ContextHighlighters.MatchingBraceContextHighlighterBase
    {
        public HtmlMatchingCDataBracesContextHighlighter(JetBrains.ReSharper.Feature.Services.Html.Bulbs.IWebContextActionDataProvider<JetBrains.ReSharper.Psi.Html.Tree.IHtmlFile> dataProvider) { }
        protected override bool IsLeftBracket(JetBrains.ReSharper.Psi.Parsing.TokenNodeType tokenType) { }
        protected override bool IsRightBracket(JetBrains.ReSharper.Psi.Parsing.TokenNodeType tokenType) { }
        protected override bool Match(JetBrains.ReSharper.Psi.Parsing.TokenNodeType token1, JetBrains.ReSharper.Psi.Parsing.TokenNodeType token2) { }
        [JetBrains.ReSharper.Daemon.CaretDependentFeatures.AsyncContextConsumerAttribute()]
        public static System.Action ProcessDataContext(JetBrains.DataFlow.Lifetime lifetime, [JetBrains.ReSharper.Daemon.CaretDependentFeatures.ContextKeyAttribute(typeof(JetBrains.ReSharper.Intentions.Html.ContextActions.HtmlContextActionDataProvider.ContextKey))] JetBrains.ReSharper.Feature.Services.Html.Bulbs.IWebContextActionDataProvider<JetBrains.ReSharper.Psi.Html.Tree.IHtmlFile> dataProvider, JetBrains.ReSharper.Daemon.CaretDependentFeatures.InvisibleBraceHintManager invisibleBraceHintManager, JetBrains.ReSharper.Feature.Services.ContextHighlighters.MatchingBraceSuggester matchingBraceSuggester) { }
        protected override void TryHighlightToLeft(JetBrains.ReSharper.Feature.Services.ContextHighlighters.MatchingHighlightingsConsumer consumer, JetBrains.ReSharper.Psi.Tree.ITokenNode selectedToken, JetBrains.ReSharper.Psi.TreeOffset treeOffset) { }
        protected override void TryHighlightToRight(JetBrains.ReSharper.Feature.Services.ContextHighlighters.MatchingHighlightingsConsumer consumer, JetBrains.ReSharper.Psi.Tree.ITokenNode selectedToken, JetBrains.ReSharper.Psi.TreeOffset treeOffset) { }
    }
    [JetBrains.ReSharper.Daemon.CaretDependentFeatures.ContainsContextConsumerAttribute()]
    public class HtmlMatchingCommentBracesContextHighlighter : JetBrains.ReSharper.Feature.Services.ContextHighlighters.MatchingBraceContextHighlighterBase
    {
        protected override bool IsLeftBracket(JetBrains.ReSharper.Psi.Parsing.TokenNodeType tokenType) { }
        protected override bool IsRightBracket(JetBrains.ReSharper.Psi.Parsing.TokenNodeType tokenType) { }
        protected override bool Match(JetBrains.ReSharper.Psi.Parsing.TokenNodeType token1, JetBrains.ReSharper.Psi.Parsing.TokenNodeType token2) { }
        [JetBrains.ReSharper.Daemon.CaretDependentFeatures.AsyncContextConsumerAttribute()]
        public static System.Action ProcessDataContext(JetBrains.DataFlow.Lifetime lifetime, [JetBrains.ReSharper.Daemon.CaretDependentFeatures.ContextKeyAttribute(typeof(JetBrains.ReSharper.Intentions.Html.ContextActions.HtmlContextActionDataProvider.ContextKey))] JetBrains.ReSharper.Feature.Services.Html.Bulbs.IWebContextActionDataProvider<JetBrains.ReSharper.Psi.Html.Tree.IHtmlFile> dataProvider, JetBrains.ReSharper.Daemon.CaretDependentFeatures.InvisibleBraceHintManager invisibleBraceHintManager, JetBrains.ReSharper.Feature.Services.ContextHighlighters.MatchingBraceSuggester matchingBraceSuggester) { }
        protected override void TryHighlightToLeft(JetBrains.ReSharper.Feature.Services.ContextHighlighters.MatchingHighlightingsConsumer consumer, JetBrains.ReSharper.Psi.Tree.ITokenNode selectedToken, JetBrains.ReSharper.Psi.TreeOffset treeOffset) { }
        protected override void TryHighlightToRight(JetBrains.ReSharper.Feature.Services.ContextHighlighters.MatchingHighlightingsConsumer consumer, JetBrains.ReSharper.Psi.Tree.ITokenNode selectedToken, JetBrains.ReSharper.Psi.TreeOffset treeOffset) { }
    }
    [JetBrains.ReSharper.Daemon.CaretDependentFeatures.ContainsContextConsumerAttribute()]
    public class HtmlMatchingConditionalCommentBracesContextHighlighter : JetBrains.ReSharper.Feature.Services.ContextHighlighters.MatchingBraceContextHighlighterBase
    {
        protected override bool IsLeftBracket(JetBrains.ReSharper.Psi.Parsing.TokenNodeType tokenType) { }
        protected override bool IsRightBracket(JetBrains.ReSharper.Psi.Parsing.TokenNodeType tokenType) { }
        protected override bool Match(JetBrains.ReSharper.Psi.Parsing.TokenNodeType token1, JetBrains.ReSharper.Psi.Parsing.TokenNodeType token2) { }
        [JetBrains.ReSharper.Daemon.CaretDependentFeatures.AsyncContextConsumerAttribute()]
        public static System.Action ProcessDataContext(JetBrains.DataFlow.Lifetime lifetime, [JetBrains.ReSharper.Daemon.CaretDependentFeatures.ContextKeyAttribute(typeof(JetBrains.ReSharper.Intentions.Html.ContextActions.HtmlContextActionDataProvider.ContextKey))] JetBrains.ReSharper.Feature.Services.Html.Bulbs.IWebContextActionDataProvider<JetBrains.ReSharper.Psi.Html.Tree.IHtmlFile> dataProvider, JetBrains.ReSharper.Daemon.CaretDependentFeatures.InvisibleBraceHintManager invisibleBraceHintManager, JetBrains.ReSharper.Feature.Services.ContextHighlighters.MatchingBraceSuggester matchingBraceSuggester) { }
        protected override void TryHighlightToLeft(JetBrains.ReSharper.Feature.Services.ContextHighlighters.MatchingHighlightingsConsumer consumer, JetBrains.ReSharper.Psi.Tree.ITokenNode selectedToken, JetBrains.ReSharper.Psi.TreeOffset treeOffset) { }
        protected override void TryHighlightToRight(JetBrains.ReSharper.Feature.Services.ContextHighlighters.MatchingHighlightingsConsumer consumer, JetBrains.ReSharper.Psi.Tree.ITokenNode selectedToken, JetBrains.ReSharper.Psi.TreeOffset treeOffset) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.Html
{
    
    public class static HtmlContextUtil
    {
        public static bool AnyHotspotIntersects([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotContext context, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Html.Tree.IHtmlToken token) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.UI.Icons.IconId GetIcon([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Html.Tree.IHtmlTag tag) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.UI.Icons.IconId GetIcon([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Html.Tree.ITagAttribute attribute) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Html.Tree.ITagAttribute> GetInnerAttributes([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Html.Tree.IHtmlFile file, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTag tag) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Collections.Generic.IEnumerable<T> GetInnerTags<T>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Html.Tree.IHtmlTagContainerMarker tagContainer)
            where T : JetBrains.ReSharper.Psi.Html.Tree.IHtmlTag { }
        public static T GetOuterTag<T>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Tree.ITreeNode tagContainer, JetBrains.ReSharper.Psi.TreeTextRange range, System.Func<T, bool> predicate)
            where T :  class, JetBrains.ReSharper.Psi.Tree.ITreeNode { }
        public static System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Tree.ITreeNode> NextSiblings([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Tree.ITreeNode node) { }
        public static System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Tree.ITreeNode> PrevSiblings([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Tree.ITreeNode node) { }
        public static System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Tree.ITreeNode> Siblings([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Tree.ITreeNode node) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Tree.ITokenNode> WalkWhitespaceNodes([JetBrains.Annotations.CanBeNullAttribute()] this JetBrains.ReSharper.Psi.Tree.ITokenNode token, [JetBrains.Annotations.NotNullAttribute()] System.Func<JetBrains.ReSharper.Psi.Tree.ITokenNode, JetBrains.ReSharper.Psi.Tree.ITokenNode> walker) { }
    }
    [JetBrains.ReSharper.Feature.Services.Descriptions.DeclaredElementDescriptionProviderAttribute()]
    public class HtmlDescriptionsCache : JetBrains.ReSharper.Feature.Services.Descriptions.IDeclaredElementDescriptionProvider, JetBrains.ReSharper.Feature.Services.Html.IHtmlDescriptionsCache, System.IDisposable
    {
        public HtmlDescriptionsCache(JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IPsiServices psiServices, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Html.Html.IHtmlDeclaredElementsCache htmlDeclaredElementTypes, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Html.Html.IHtmlDeclaredElementsProvider> languageSpecificAttributesForHtmlTags) { }
        public System.Collections.Generic.IEnumerable<string> ErrorLog { get; }
        public System.Collections.Generic.IEnumerable<string> ImportantCommonAttributes { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Html.Html.IHtmlDeclaredElementsProvider> LanguageSpecificAttributesForHtmlTags { get; }
        public int Priority { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Feature.Services.Html.HtmlDescriptionsCache.AttributeDescription GetCommonAttributeDescription([JetBrains.Annotations.NotNullAttribute()] string name) { }
        public string GetDescriptionForHtmlValueType([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Html.Html.IHtmlAttributeValueType attributeValueType) { }
        public JetBrains.UI.RichText.RichTextBlock GetElementDescription(JetBrains.ReSharper.Psi.IDeclaredElement element, JetBrains.ReSharper.Feature.Services.Descriptions.DeclaredElementDescriptionStyle style, JetBrains.ReSharper.Psi.PsiLanguageType language, JetBrains.ReSharper.Psi.Modules.IPsiModule module) { }
        public JetBrains.ReSharper.Feature.Services.Html.IHtmlTagDescription GetTagDescription(JetBrains.ReSharper.Psi.Html.Html.IHtmlTagDeclaredElement element) { }
        public System.Nullable<bool> IsElementObsolete(JetBrains.ReSharper.Psi.IDeclaredElement element, out JetBrains.UI.RichText.RichTextBlock obsoleteDescription, JetBrains.ReSharper.Feature.Services.Descriptions.DeclaredElementDescriptionStyle style) { }
        public class AttributeDescription
        {
            public AttributeDescription(string name, string summary, string description, bool obsolete, string obsoleteDescription, bool unimplemented, bool nonStandard) { }
            public string Description { get; }
            public string Name { get; }
            public bool NonStandard { get; set; }
            public bool Obsolete { get; }
            public string ObsoleteDescription { get; }
            public string Summary { get; }
            public bool Unimplemented { get; set; }
        }
        public class HtmlTagDescription : JetBrains.ReSharper.Feature.Services.Html.IHtmlTagDescription
        {
            public string Description { get; }
            public bool NonStandard { get; }
            public bool Obsolete { get; }
            public string ObsoleteDescription { get; }
            public string Summary { get; }
            public JetBrains.ReSharper.Psi.Html.Html.IHtmlTagDeclaredElement Tag { get; }
            public System.Nullable<JetBrains.ReSharper.Psi.Html.Html.AttributeInfo> GetAttributeByCode(string name, JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
            public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Html.Html.AttributeInfo> GetAttributesByImportance(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
            public JetBrains.UI.RichText.RichTextBlock GetObsoleteDescription() { }
        }
    }
    public interface IHtmlDescriptionsCache
    {
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Feature.Services.Html.IHtmlTagDescription GetTagDescription([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Html.Html.IHtmlTagDeclaredElement element);
    }
    public interface IHtmlTagDescription
    {
        System.Nullable<JetBrains.ReSharper.Psi.Html.Html.AttributeInfo> GetAttributeByCode([JetBrains.Annotations.NotNullAttribute()] string name, JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile);
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Html.Html.AttributeInfo> GetAttributesByImportance(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile);
    }
    public class static Utils
    {
        public static System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.CodeStructure.CodeStructureElement> GetParentsAndSelf(this JetBrains.ReSharper.Feature.Services.CodeStructure.CodeStructureElement baseElement) { }
        public static string GetText([JetBrains.Annotations.NotNullAttribute()] this JetBrains.DocumentModel.IRangeMarker rangeMarker) { }
        public static System.Func<T, bool> Inverse<T>([JetBrains.Annotations.NotNullAttribute()] this System.Func<T, bool> predicate) { }
        public static bool IsAny<T>([JetBrains.Annotations.CanBeNullAttribute()] this T obj, [JetBrains.Annotations.NotNullAttribute()] params System.Predicate<>[] predicates) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Collections.Generic.IEnumerable<char> ToEnumerable([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Text.IBuffer buffer) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Collections.Generic.IEnumerable<char> ToEnumerable([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Text.IBuffer buffer, int start) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Collections.Generic.IEnumerable<char> ToEnumerable([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Text.IBuffer buffer, int start, int length) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.Html.HtmlEntities
{
    
    public class HtmlEntitiesLexer : JetBrains.ReSharper.Psi.Parsing.ILexer
    {
        protected const int YY_SEMICOLON_REQUIRED = 1;
        protected const int YYINITIAL = 0;
        public HtmlEntitiesLexer(JetBrains.ReSharper.Psi.Html.Parsing.IHtmlTokenNodeTypes tokenNodeTypes, JetBrains.Text.IBuffer buffer, bool semicolonRequired) { }
        public HtmlEntitiesLexer(JetBrains.Text.IBuffer buffer) { }
        public HtmlEntitiesLexer(JetBrains.Text.IBuffer buffer, int startOffset, int endOffset) { }
        public JetBrains.Text.IBuffer Buffer { get; }
        public object CurrentPosition { get; set; }
        public int TokenEnd { get; }
        public int TokenStart { get; }
        public JetBrains.ReSharper.Psi.Parsing.TokenNodeType TokenType { get; }
        public JetBrains.ReSharper.Psi.Parsing.TokenNodeType _locateToken() { }
        public void Advance() { }
        protected void locateToken() { }
        public void Start() { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.Html.HtmlLanguage))]
    public class HtmlEntitiesNodeTypeSet
    {
        public HtmlEntitiesNodeTypeSet(JetBrains.ReSharper.Psi.Html.Parsing.IHtmlTokenNodeTypes tokenTypes) { }
        public JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet AllowedTokens { get; set; }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class HtmlEntitiesService
    {
        public HtmlEntitiesService(JetBrains.ReSharper.Psi.ILanguageManager languageManager) { }
        public System.Collections.Generic.IDictionary<string, JetBrains.ReSharper.Feature.Services.Html.HtmlEntities.HtmlEntity> Entities { get; }
        public static JetBrains.ReSharper.Feature.Services.Html.HtmlEntities.HtmlEntitiesService GetInstance(JetBrains.ProjectModel.ISolution solution) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.Html.HtmlLanguage))]
    public class HtmlEntitiesWalker
    {
        public HtmlEntitiesWalker(JetBrains.ReSharper.Psi.Html.Parsing.IHtmlTokenNodeTypes tokenTypes, JetBrains.ReSharper.Feature.Services.Html.HtmlEntities.HtmlEntitiesNodeTypeSet htmlEntitiesNodeTypeSet) { }
        public System.Collections.Generic.IEnumerable<JetBrains.Util.JetTuple<JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode, JetBrains.ReSharper.Psi.TreeTextRange>> GetHtmlEntitiesData([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Html.Tree.IHtmlToken node) { }
    }
    public class HtmlEntity : System.IEquatable<JetBrains.ReSharper.Feature.Services.Html.HtmlEntities.HtmlEntity>
    {
        public HtmlEntity(JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode entity, JetBrains.ReSharper.Feature.Services.Html.HtmlEntities.HtmlEntitiesService htmlEntitiesService) { }
        public string EntityName { get; }
        public string HexNumericEntity { get; }
        public bool IsKnown { get; }
        public bool IsNumeric { get; }
        public string NamedEntity { get; }
        public string NumericEntity { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public string Symbol { get; }
        public bool Equals(JetBrains.ReSharper.Feature.Services.Html.HtmlEntities.HtmlEntity other) { }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.Html.MathingBrace
{
    
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.Html.HtmlLanguage))]
    public class HtmlMatchingBraceProvider : JetBrains.ReSharper.Feature.Services.MatchingBrace.ISimpleMatchingBraceProvider
    {
        protected readonly System.Collections.Generic.IList<JetBrains.Util.Pair<JetBrains.ReSharper.Psi.Parsing.TokenNodeType, JetBrains.ReSharper.Psi.Parsing.TokenNodeType>> myLeftRightSimplePairs;
        public HtmlMatchingBraceProvider(JetBrains.ReSharper.Psi.Html.HtmlLanguage language, JetBrains.ReSharper.Psi.Html.Parsing.IHtmlTokenNodeTypes tokenNodeTypes) { }
        public int Compare(JetBrains.ReSharper.Psi.Parsing.TokenNodeType x, JetBrains.ReSharper.Psi.Parsing.TokenNodeType y) { }
        public bool IsLeftBracket(JetBrains.ReSharper.Psi.Parsing.TokenNodeType tokenType) { }
        public bool IsRightBracket(JetBrains.ReSharper.Psi.Parsing.TokenNodeType tokenType) { }
        public bool Match(JetBrains.ReSharper.Psi.Parsing.TokenNodeType token1, JetBrains.ReSharper.Psi.Parsing.TokenNodeType token2) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.Html.Navigation
{
    
    [JetBrains.ReSharper.Psi.ShellFeaturePartAttribute()]
    public class HtmlDeclarationSearch : JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextSearches.BaseSearches.DefaultDeclarationSearch
    {
        public override JetBrains.ReSharper.Feature.Services.Search.SearchRequests.SearchDeclarationsRequest GetDeclarationSearchRequest(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
        protected override bool IsAvailableInternal(JetBrains.Application.DataContext.IDataContext dataContext) { }
        public override bool IsContextApplicable(JetBrains.Application.DataContext.IDataContext dataContext) { }
        public override bool IsGotoDeclarationApplicable(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
    }
    [JetBrains.ReSharper.Psi.ShellFeaturePartAttribute()]
    public class HtmlGotoSymbolProvider : JetBrains.ReSharper.Feature.Services.Goto.GotoProviders.CachedGotoSymbolBase<JetBrains.ReSharper.Psi.Web.Symbols.IWebSymbolsCache>, JetBrains.ReSharper.Feature.Services.Goto.IApplicableGotoProvider, JetBrains.ReSharper.Feature.Services.Goto.IGotoEverythingProvider, JetBrains.ReSharper.Feature.Services.Goto.IGotoSymbolProvider, JetBrains.ReSharper.Feature.Services.Goto.IOccurenceNavigationProvider
    {
        public System.Func<int, int> ItemsPriorityFunc { get; }
        protected override JetBrains.ReSharper.Psi.Web.Symbols.IWebSymbolsCache GetCache(JetBrains.ReSharper.Feature.Services.Goto.INavigationScope scope, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Feature.Services.Goto.GotoContext gotoContext) { }
        protected override System.Collections.Generic.IEnumerable<string> GetNames(JetBrains.ReSharper.Psi.Web.Symbols.IWebSymbolsCache cache, JetBrains.ReSharper.Feature.Services.Goto.INavigationScope scope) { }
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.Search.IOccurence> GetOccurencesByMatchingInfo(JetBrains.ReSharper.Feature.Services.Goto.MatchingInfo navigationInfo, JetBrains.ReSharper.Feature.Services.Goto.INavigationScope scope, JetBrains.ReSharper.Feature.Services.Goto.GotoContext gotoContext, JetBrains.Application.CheckForInterrupt checkForInterrupt) { }
        public override bool IsApplicable(JetBrains.ReSharper.Feature.Services.Goto.INavigationScope scope, JetBrains.ReSharper.Feature.Services.Goto.GotoContext gotoContext, JetBrains.Text.IdentifierMatcher matcher) { }
    }
    [JetBrains.ReSharper.Psi.ShellFeaturePartAttribute()]
    public class HtmlImplementationContextSearch : JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextSearches.BaseSearches.ImplementationContextSearch
    {
        protected override bool IsAvailableInternal(JetBrains.Application.DataContext.IDataContext dataContext) { }
        public override bool IsContextApplicable(JetBrains.Application.DataContext.IDataContext dataContext) { }
    }
    public class static HtmlNavigationUtil
    {
        public static bool IsHtmlDeclaredElementWithDeclaration(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
        public static bool IsHtmlDeclaredElementWithoutDeclaration(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
    }
    [JetBrains.ReSharper.Psi.ShellFeaturePartAttribute()]
    public class HtmlNonCachedGotoFileMemberProvider : JetBrains.ReSharper.Feature.Services.Goto.GotoProviders.NonCachedFileMemberProvider<JetBrains.ReSharper.Psi.Html.HtmlLanguage> { }
    [JetBrains.ReSharper.Psi.ShellFeaturePartAttribute()]
    public class HtmlOccurencePresenter : JetBrains.ReSharper.Feature.Services.Web.Navigation.WebSymbolOccurencePresenter
    {
        public override bool IsApplicable(JetBrains.ReSharper.Feature.Services.Search.IOccurence occurence) { }
    }
    [JetBrains.ReSharper.Psi.ShellFeaturePartAttribute()]
    public class HtmlTagIdDeclarationSearch : JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextSearches.BaseSearches.DefaultDeclarationSearch
    {
        protected override JetBrains.ReSharper.Feature.Services.Search.SearchRequests.SearchDeclarationsRequest CreateSearchRequest(JetBrains.Application.DataContext.IDataContext dataContext, JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, JetBrains.ReSharper.Psi.IDeclaredElement initialTarget) { }
        public override JetBrains.ReSharper.Feature.Services.Search.SearchRequests.SearchDeclarationsRequest GetDeclarationSearchRequest(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
        public override JetBrains.Util.JetTuple<System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IDeclaredElement>, JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextSearches.GetSearchRequest<JetBrains.ReSharper.Feature.Services.Search.SearchRequests.SearchDeclarationsRequest>> GetElementsAndSearchRequest(JetBrains.Application.DataContext.IDataContext dataContext) { }
        protected override bool IsAvailableInternal(JetBrains.Application.DataContext.IDataContext dataContext) { }
        public override bool IsContextApplicable(JetBrains.Application.DataContext.IDataContext dataContext) { }
        public override bool IsGotoDeclarationApplicable(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
    }
    [JetBrains.ReSharper.Psi.ShellFeaturePartAttribute()]
    public class HtmlTagIdUsagesContextSearch : JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextSearches.BaseSearches.FindUsagesContextSearch
    {
        protected override JetBrains.ReSharper.Feature.Services.Search.SearchRequests.SearchUsagesRequest CreateSearchRequest(JetBrains.Application.DataContext.IDataContext dataContext, JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, JetBrains.ReSharper.Psi.IDeclaredElement initialTarget) { }
        public override bool IsContextApplicable(JetBrains.Application.DataContext.IDataContext dataContext) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.Html.Options
{
    
    public class static HtmlTypingAssistOptions<TSettings>
        where TSettings : JetBrains.ReSharper.Feature.Services.Html.Options.HtmlTypingAssistSettings
    {
        public static readonly System.Linq.Expressions.Expression<System.Func<TSettings, bool>> ChangeTagNameTracking;
        public static readonly System.Linq.Expressions.Expression<System.Func<TSettings, bool>> FormatOnClosingTagExpression;
        public static readonly System.Linq.Expressions.Expression<System.Func<TSettings, bool>> FormatOnEnterExpression;
    }
    [JetBrains.Application.Settings.SettingsKeyAttribute(typeof(JetBrains.ReSharper.Feature.Services.Options.TypingAssistSettings), "HTML typing assistance settings", KeyNameOverride="Html")]
    public class HtmlTypingAssistSettings
    {
        [JetBrains.Application.Settings.SettingsEntryAttribute(true, "Synchronous changing of matching tag")]
        public bool ChangedTagNameTracking;
        [JetBrains.Application.Settings.SettingsEntryAttribute(true, "Auto-format on closing tag")]
        public bool FormatOnClosingTag;
        [JetBrains.Application.Settings.SettingsEntryAttribute(true, "Auto-format on enter")]
        public bool FormatOnEnter;
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class PredefinedHtmlTypingAssistSettings : JetBrains.Application.Settings.IHaveDefaultSettingsStream { }
}
namespace JetBrains.ReSharper.Feature.Services.Html.ParameterInfo
{
    
    public abstract class HtmlTagCandidateBase : JetBrains.ReSharper.Feature.Services.ParameterInfo.CachingCandidate
    {
        protected HtmlTagCandidateBase(JetBrains.UI.RichText.RichTextBlock description, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Html.Tree.IHtmlTagHeader htmlTagHeader, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Html.Tree.ITagAttribute currentAttribute) { }
        protected System.Collections.Generic.List<JetBrains.ReSharper.Feature.Services.Html.ParameterInfo.HtmlTagCandidateBase.AttributeInfo> AttributeInfos { get; }
        public JetBrains.ReSharper.Psi.Html.Tree.ITagAttribute CurrentAttribute { get; }
        protected JetBrains.ReSharper.Psi.Html.Tree.IHtmlTagHeader HtmlTagHeader { get; }
        public override bool IsFilteredOut { get; set; }
        public override bool IsObsolete { get; }
        public override JetBrains.UI.RichText.RichTextBlock ObsoleteDescription { get; }
        public override int PositionalParameterCount { get; }
        public string SuggestedAttribute { get; }
        protected void AddUnrecognizedParameters() { }
        public override JetBrains.UI.RichText.RichTextBlock GetDescription() { }
        protected override System.Collections.Generic.IList<string> GetParameterNames() { }
        public override void GetParametersInfo(out string paramNames, out JetBrains.UI.RichText.RichTextBlock paramDescriptions, out bool isParamsArray) { }
        public override System.Collections.Generic.IList<JetBrains.UI.RichText.TextStyle> GetParameterStyles() { }
        protected override string GetSignatureInternal(string[] namedArguments, out JetBrains.Util.TextRange parameterRanges, out int mapToOriginalOrder, out JetBrains.ReSharper.Feature.Services.ParameterInfo.ExtensionMethodInfo extensionMethodInfo) { }
        public abstract bool IsParameterRecognized(string attribute);
        public override bool Matches(JetBrains.ReSharper.Psi.IDeclaredElement signature) { }
        protected class AttributeInfo
        {
            public AttributeInfo(string name, JetBrains.UI.RichText.RichTextBlock description, JetBrains.UI.RichText.TextStyle textStyle) { }
            public JetBrains.UI.RichText.RichTextBlock Description { get; set; }
            public string Name { get; set; }
            public JetBrains.UI.RichText.TextStyle TextStyle { get; set; }
            public bool Unrecognized { get; set; }
        }
    }
    [JetBrains.ReSharper.Feature.Services.ParameterInfo.ParameterInfoContextFactoryAttribute(typeof(JetBrains.ReSharper.Psi.Html.HtmlLanguage))]
    public class HtmlTagParameterInfoContextFactory : JetBrains.ReSharper.Feature.Services.ParameterInfo.IParameterInfoContextFactory
    {
        public HtmlTagParameterInfoContextFactory(JetBrains.ReSharper.Psi.PsiLanguageType language) { }
        public System.Collections.Generic.IEnumerable<char> ImportantChars { get; }
        public virtual JetBrains.ReSharper.Psi.PsiLanguageType Language { get; }
        public JetBrains.ReSharper.Feature.Services.ParameterInfo.IParameterInfoContext CreateContext(JetBrains.ProjectModel.ISolution solution, JetBrains.DocumentModel.IDocument document, int caretOffset, int expectedLParenthOffset, char invocationChar, JetBrains.Application.Settings.IContextBoundSettingsStore contextBoundSettingsStore) { }
        protected virtual JetBrains.ReSharper.Feature.Services.Html.ParameterInfo.HtmlTagCandidateBase GetCandidate([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Html.Tree.IHtmlTagHeader htmlTagHeader, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.IFile file, JetBrains.ReSharper.Psi.Html.Tree.ITagAttribute currentAttribute) { }
        public bool IsIntellisenseEnabled(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Settings.IContextBoundSettingsStore contextBoundSettingsStore) { }
        public bool ShouldPopup(JetBrains.DocumentModel.IDocument document, int caretOffset, char c, JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Settings.IContextBoundSettingsStore contextBoundSettingsStore) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.Html.RearrangeCode
{
    
    public abstract class HtmlAttributeRearrangeableElementTypeBase<TAttribute, TContainer> : JetBrains.ReSharper.Feature.Services.RearrangeCode.IRearrangeableElementType
        where TAttribute :  class, JetBrains.ReSharper.Psi.Web.Tree.IWebAttribute
        where TContainer :  class, JetBrains.ReSharper.Psi.Web.Tree.IWebAttributeContainer<>
    {
        public JetBrains.ReSharper.Feature.Services.RearrangeCode.IRearrangeable CreateElement(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
    }
    [JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableElementTypeAttribute()]
    public class HtmlTagAttributeRearrangeableElementType : JetBrains.ReSharper.Feature.Services.Html.RearrangeCode.HtmlAttributeRearrangeableElementTypeBase<JetBrains.ReSharper.Psi.Html.Tree.ITagAttribute, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTag> { }
    public class RearrangeableAttribute<TAttribute, TContainer> : JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableElementAppendRemove<TAttribute, TContainer>
        where TAttribute :  class, JetBrains.ReSharper.Psi.Web.Tree.IWebAttribute
        where TContainer :  class, JetBrains.ReSharper.Psi.Web.Tree.IWebAttributeContainer<>
    {
        public RearrangeableAttribute(TAttribute attribute) { }
        protected override TContainer Parent { get; }
        public override JetBrains.ReSharper.Feature.Services.RearrangeCode.Direction SupportedDirections { get; }
        protected override TAttribute AddAfter(TContainer parent, TAttribute child, TAttribute anchor) { }
        protected override TAttribute AddBefore(TContainer parent, TAttribute child, TAttribute anchor) { }
        protected override System.Collections.Generic.IEnumerable<TAttribute> GetChildren(TContainer parent) { }
        protected override void RemoveChild(TContainer parent, TAttribute child) { }
    }
    public class RearrangeableTagContainer : JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableElement
    {
        protected override JetBrains.ReSharper.Psi.Tree.ITreeNode Element { get; }
        public override JetBrains.ReSharper.Feature.Services.RearrangeCode.Direction SupportedDirections { get; }
        public override string Title { get; }
        public override bool CanMove(JetBrains.ReSharper.Feature.Services.RearrangeCode.Direction direction) { }
        protected override JetBrains.ReSharper.Psi.Tree.ITreeNode Move(JetBrains.ReSharper.Feature.Services.RearrangeCode.Direction direction) { }
        [JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableElementTypeAttribute()]
        public class Type : JetBrains.ReSharper.Feature.Services.RearrangeCode.IRearrangeableElementType
        {
            public JetBrains.ReSharper.Feature.Services.RearrangeCode.IRearrangeable CreateElement(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        }
    }
}
namespace JetBrains.ReSharper.Feature.Services.Html.Resources
{
    
    public sealed class ServicesHtmlThemedIcons
    {
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Feature.Services.Html;component/resources/ServicesHtmlThemedI" +
            "cons/ThemedIcons.ServicesHtml.Generated.Xaml", 0, "HtmlTagAttributeIcon")]
        public sealed class HtmlTagAttributeIcon : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Feature.Services.Html;component/resources/ServicesHtmlThemedI" +
            "cons/ThemedIcons.ServicesHtml.Generated.Xaml", 2, "HtmlTagAttributeValueIcon")]
        public sealed class HtmlTagAttributeValueIcon : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Feature.Services.Html;component/resources/ServicesHtmlThemedI" +
            "cons/ThemedIcons.ServicesHtml.Generated.Xaml", 1, "HtmlTagIcon")]
        public sealed class HtmlTagIcon : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
    }
}
namespace JetBrains.ReSharper.Feature.Services.Html.SelectEmbracingConstruct
{
    
    public class HtmlDotSelection<TFile> : JetBrains.ReSharper.Feature.Services.SelectEmbracingConstruct.DotSelection<TFile>
        where TFile :  class, JetBrains.ReSharper.Psi.Html.Tree.IHtmlFile
    {
        public HtmlDotSelection(JetBrains.ReSharper.Feature.Services.Web.SelectEmbracingConstruct.IWebSelectEmbracingConstructProvider<TFile> provider, TFile file, JetBrains.ReSharper.Psi.TreeOffset offset, bool selectBetterToken, bool useCamelHumps) { }
        protected JetBrains.ReSharper.Psi.TreeOffset Offset { get; }
        protected JetBrains.ReSharper.Feature.Services.Web.SelectEmbracingConstruct.IWebSelectEmbracingConstructProvider<TFile> Provider { get; }
        protected override JetBrains.ReSharper.Feature.Services.SelectEmbracingConstruct.ISelectedRange CreateTokenPartSelection(JetBrains.ReSharper.Psi.Tree.ITokenNode tokenNode, JetBrains.ReSharper.Psi.TreeTextRange treeTextRange) { }
        protected override JetBrains.ReSharper.Feature.Services.SelectEmbracingConstruct.ISelectedRange CreateTreeNodeSelection(JetBrains.ReSharper.Psi.Tree.ITokenNode tokenNode) { }
        protected override JetBrains.ReSharper.Feature.Services.SelectEmbracingConstruct.ISelectedRange GetParentInternal(JetBrains.ReSharper.Psi.Tree.ITokenNode tokenNode) { }
        protected override bool IsLiteralToken(JetBrains.ReSharper.Psi.Tree.ITokenNode token) { }
        protected override bool IsNewLineToken(JetBrains.ReSharper.Psi.Tree.ITokenNode token) { }
        protected override bool IsPrevTokenBetter(JetBrains.ReSharper.Psi.Tree.ITokenNode prevToken, JetBrains.ReSharper.Psi.Tree.ITokenNode tokenNode) { }
        protected override bool IsSpaceToken(JetBrains.ReSharper.Psi.Tree.ITokenNode token) { }
        protected override bool IsWordToken(JetBrains.ReSharper.Psi.Tree.ITokenNode token) { }
    }
    public class HtmlElementRange<TFile> : JetBrains.ReSharper.Feature.Services.Html.SelectEmbracingConstruct.HtmlSelectedRange<TFile>
        where TFile :  class, JetBrains.ReSharper.Psi.Html.Tree.IHtmlFile
    {
        public HtmlElementRange(JetBrains.ReSharper.Feature.Services.Web.SelectEmbracingConstruct.IWebSelectEmbracingConstructProvider<TFile> provider, JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public override JetBrains.ReSharper.Feature.Services.SelectEmbracingConstruct.ExtendToTheWholeLinePolicy ExtendToWholeLine { get; }
        public override JetBrains.ReSharper.Feature.Services.SelectEmbracingConstruct.ISelectedRange Parent { get; }
    }
    public abstract class HtmlSelectedRange<TFile> : JetBrains.ReSharper.Feature.Services.SelectEmbracingConstruct.SelectedRangeBase<TFile>
        where TFile :  class, JetBrains.ReSharper.Psi.Html.Tree.IHtmlFile
    {
        protected readonly JetBrains.ReSharper.Psi.Tree.ITreeNode myNode;
        protected readonly JetBrains.ReSharper.Feature.Services.Web.SelectEmbracingConstruct.IWebSelectEmbracingConstructProvider<TFile> myProvider;
        protected HtmlSelectedRange(JetBrains.ReSharper.Feature.Services.Web.SelectEmbracingConstruct.IWebSelectEmbracingConstructProvider<TFile> provider, JetBrains.ReSharper.Psi.Tree.ITreeNode node, JetBrains.DocumentModel.DocumentRange documentRange) { }
        protected JetBrains.ReSharper.Feature.Services.SelectEmbracingConstruct.ISelectedRange BuildHtmlNodeSelection(JetBrains.ReSharper.Psi.Tree.ITreeNode treeNode) { }
        protected virtual JetBrains.ReSharper.Feature.Services.SelectEmbracingConstruct.ISelectedRange BuildTokenPartSelection(JetBrains.ReSharper.Feature.Services.Web.SelectEmbracingConstruct.IWebSelectEmbracingConstructProvider<TFile> provider, JetBrains.ReSharper.Psi.Tree.ITokenNode token, JetBrains.ReSharper.Psi.TreeTextRange rangeWithin) { }
        protected static JetBrains.DocumentModel.DocumentRange GetDocumentRange(TFile file, JetBrains.ReSharper.Psi.TreeTextRange treeTextRange) { }
        protected static JetBrains.DocumentModel.DocumentRange GetDocumentRange(TFile file, JetBrains.ReSharper.Psi.TreeOffset starTreeOffset, JetBrains.ReSharper.Psi.TreeOffset endTreeOffset) { }
    }
    [JetBrains.ProjectModel.ProjectFileTypeAttribute(typeof(JetBrains.ProjectModel.HtmlProjectFileType))]
    public class HtmlSelectEmbracingConstructProvider : JetBrains.ReSharper.Feature.Services.Web.SelectEmbracingConstruct.WebSelectEmbracingConstructProviderBase<JetBrains.ReSharper.Psi.Html.Tree.IHtmlFile>
    {
        public HtmlSelectEmbracingConstructProvider(JetBrains.ProjectModel.HtmlProjectFileType htmlProjectFileType, JetBrains.Application.Settings.ISettingsStore settingsStore) { }
        public override JetBrains.ReSharper.Feature.Services.SelectEmbracingConstruct.ISelectedRange CreateDotSelectedRange(JetBrains.ReSharper.Psi.Html.Tree.IHtmlFile primaryFile, JetBrains.ReSharper.Psi.TreeOffset treeOffset, bool selectBetterToken) { }
        public override JetBrains.ReSharper.Feature.Services.SelectEmbracingConstruct.ISelectedRange CreateElementSelectedRange(JetBrains.ReSharper.Psi.Tree.ITreeNode node) { }
        public override JetBrains.ReSharper.Feature.Services.Web.SelectEmbracingConstruct.IWrapperRange CreateWrapperRange(JetBrains.DocumentModel.IDocument document, JetBrains.ReSharper.Psi.Html.Tree.IHtmlFile primaryFile, JetBrains.ReSharper.Feature.Services.SelectEmbracingConstruct.ISelectedRange primaryRange, JetBrains.ReSharper.Feature.Services.SelectEmbracingConstruct.ISelectedTreeRange codeBehindRange, JetBrains.ReSharper.Psi.Tree.IFile secondaryFile) { }
    }
    public class HtmlTokenPartSelection<TFile> : JetBrains.ReSharper.Feature.Services.Html.SelectEmbracingConstruct.HtmlSelectedRange<TFile>
        where TFile :  class, JetBrains.ReSharper.Psi.Html.Tree.IHtmlFile
    {
        protected readonly JetBrains.ReSharper.Psi.TreeTextRange myRangeWithin;
        protected readonly JetBrains.ReSharper.Psi.Tree.ITokenNode myToken;
        public HtmlTokenPartSelection(JetBrains.ReSharper.Feature.Services.Web.SelectEmbracingConstruct.IWebSelectEmbracingConstructProvider<TFile> provider, JetBrains.ReSharper.Psi.Tree.ITokenNode token, JetBrains.ReSharper.Psi.TreeTextRange rangeWithin) { }
        public override JetBrains.ReSharper.Feature.Services.SelectEmbracingConstruct.ExtendToTheWholeLinePolicy ExtendToWholeLine { get; }
        public override JetBrains.ReSharper.Feature.Services.SelectEmbracingConstruct.ISelectedRange Parent { get; }
        protected virtual JetBrains.Util.JetTuple<int, int, bool> GetParentCalculationData(JetBrains.ReSharper.Psi.Parsing.TokenNodeType tokenType, string tokenText) { }
    }
    public class HtmlWrapperRange : JetBrains.ReSharper.Feature.Services.Web.SelectEmbracingConstruct.WrapperRange<JetBrains.ReSharper.Psi.Html.Tree.IHtmlFile>
    {
        public HtmlWrapperRange(JetBrains.DocumentModel.IDocument document, JetBrains.ReSharper.Psi.Html.Tree.IHtmlFile primaryFile, JetBrains.ReSharper.Feature.Services.SelectEmbracingConstruct.ISelectedTreeRange secondarySelection, JetBrains.ReSharper.Feature.Services.SelectEmbracingConstruct.ISelectedRange primarySelection, JetBrains.ReSharper.Psi.Tree.IFile secondaryFile) { }
        protected override bool IsSpecialToken(JetBrains.ReSharper.Psi.Parsing.TokenNodeType tokenNodeType) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.Html.TodoItems
{
    
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.Html.HtmlLanguage))]
    public class HtmlTodoContentsProvider : JetBrains.ReSharper.Feature.Services.TodoItems.DefaultTodoContentsProvider
    {
        public HtmlTodoContentsProvider(JetBrains.ReSharper.Psi.Html.Parsing.IHtmlTokenNodeTypes htmlTokenNodeTypes) { }
        public override System.Nullable<JetBrains.Util.TextRange> GetTokenContentsRange(string documentText, JetBrains.Util.TextRange tokenRange, JetBrains.ReSharper.Psi.Parsing.TokenNodeType tokenType) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.Html.TypingAssist
{
    
    public abstract class ChangedTagNameTracker : JetBrains.ReSharper.Feature.Services.TypingAssist.ITypingHandler
    {
        public static readonly JetBrains.Util.Key<JetBrains.ReSharper.Feature.Services.Html.TypingAssist.TagMarkers> OurChangedTagNameDataKey;
        protected ChangedTagNameTracker(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Settings.ISettingsStore settingsStore, JetBrains.ReSharper.Psi.Services.CachingLexerService cachingLexerService, JetBrains.Application.CommandProcessing.ICommandProcessor commandProcessor, JetBrains.TextControl.Impl.TextControlTypingHandlers textControlTypingHandlers, JetBrains.DataFlow.Lifetime lifetime, JetBrains.TextControl.ITextControlManager textControlManager, JetBrains.Application.IShellLocks shellLocks, JetBrains.ActionManagement.IActionManager actionManager, JetBrains.ProjectModel.Model2.Transaction.IEnsureWritableHandler ensureWritableHandler, JetBrains.DocumentManagers.DocumentManager documentManager, JetBrains.ReSharper.Feature.Services.Lookup.ILookupWindowManager lookupWindowManager, JetBrains.ReSharper.Psi.Files.IPsiFiles psiFiles, JetBrains.Application.ChangeManager changeManager, JetBrains.ReSharper.Feature.Services.TypingAssist.ITypingAssistManager typingAssistManager) { }
        public JetBrains.Application.CommandProcessing.ICommandProcessor CommandProcessor { get; set; }
        public JetBrains.Application.Settings.ISettingsStore SettingsStore { get; set; }
        public JetBrains.ProjectModel.ISolution Solution { get; set; }
        protected virtual JetBrains.ReSharper.Feature.Services.Html.TypingAssist.ChangedTagNameTracker.MarkerFindResults FindMarkersViaLexer(JetBrains.TextControl.ITextControl textControl, int caretPosition) { }
        protected virtual JetBrains.ReSharper.Feature.Services.Html.TypingAssist.ChangedTagNameTracker.MarkerFindResults FindMarkersViaPsi(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, JetBrains.TextControl.ITextControl textControl, int caretPosition) { }
        protected JetBrains.ReSharper.Psi.Parsing.CachingLexer GetCachingLexer(JetBrains.TextControl.ITextControl textControl) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Feature.Services.Html.TypingAssist.TagMarkers GetData([JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.IUserDataHolder dataHolder) { }
        protected TEntry GetTypingAssistOption<TSettings, TEntry>(JetBrains.TextControl.ITextControl textControl, System.Linq.Expressions.Expression<System.Func<TSettings, TEntry>> expression) { }
        public void HandleAction(JetBrains.TextControl.ITextControl textControl, System.Action action, System.Func<JetBrains.Util.TextRange, JetBrains.Util.TextRange> selRangeConverter, bool shouldReCheckAfterNoMarkers) { }
        protected abstract bool IsAvailable(JetBrains.TextControl.ITextControl textControl, JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile);
        public static void ProcessMarkers(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl, System.Action action) { }
        public bool QuickCheckAvailability(JetBrains.TextControl.ITextControl textControl, JetBrains.ReSharper.Psi.IPsiSourceFile projectFile) { }
        public static void SetData([JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.IUserDataHolder dataHolder, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Feature.Services.Html.TypingAssist.TagMarkers markers) { }
        protected class MarkerFindResults
        {
            public static readonly JetBrains.ReSharper.Feature.Services.Html.TypingAssist.ChangedTagNameTracker.MarkerFindResults Unsuccessful;
            public MarkerFindResults(bool isHeader, string tagName, JetBrains.Util.TextRange secondRange, JetBrains.Util.TextRange tokenRange) { }
            public bool IsHeader { get; }
            public JetBrains.Util.TextRange SecondRange { get; }
            public bool Success { get; }
            public string TagName { get; }
            public JetBrains.Util.TextRange TokenRange { get; }
        }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class DocumentLifetimeProvider : JetBrains.ReSharper.Feature.Services.Html.TypingAssist.IDocumentLifetimeProvider
    {
        public JetBrains.DataFlow.Lifetime CreateLifetimeUntilDocumentChanged(JetBrains.TextControl.ITextControl textControl) { }
        public JetBrains.DataFlow.Lifetime CreateLifetimeUntilDocumentChangedOrCaretMoved(JetBrains.TextControl.ITextControl textControl) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class HtmlChangedTagNameTracker : JetBrains.ReSharper.Feature.Services.Html.TypingAssist.SpecificChangedTagNameTracker<JetBrains.ReSharper.Feature.Services.Html.Options.HtmlTypingAssistSettings, JetBrains.ProjectModel.HtmlProjectFileType>
    {
        public HtmlChangedTagNameTracker(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Settings.ISettingsStore settingsStore, JetBrains.ReSharper.Psi.Services.CachingLexerService cachingLexerService, JetBrains.Application.CommandProcessing.ICommandProcessor commandProcessor, JetBrains.TextControl.Impl.TextControlTypingHandlers textControlTypingHandlers, JetBrains.DataFlow.Lifetime lifetime, JetBrains.TextControl.ITextControlManager textControlManager, JetBrains.Application.IShellLocks shellLocks, JetBrains.ActionManagement.IActionManager actionManager, JetBrains.ProjectModel.Model2.Transaction.IEnsureWritableHandler ensureWritableHandler, JetBrains.DocumentManagers.DocumentManager documentManager, JetBrains.ReSharper.Feature.Services.Lookup.ILookupWindowManager lookupWindowManager, JetBrains.ReSharper.Psi.Files.IPsiFiles psiFiles, JetBrains.Application.ChangeManager changeManager, JetBrains.ReSharper.Feature.Services.TypingAssist.ITypingAssistManager typingAssistManager) { }
        protected override bool IsAvailable(JetBrains.TextControl.ITextControl textControl, JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
    }
    public class static HtmlLexerUtils
    {
        public static bool GetFooterByHeader(JetBrains.ReSharper.Psi.Parsing.CachingLexer lexer, JetBrains.ReSharper.Psi.Html.Parsing.IHtmlTokenNodeTypes htmlTokenNodeTypes, JetBrains.ReSharper.Feature.Services.Html.TypingAssist.HtmlLexerUtils.TagNameContainerInfo header) { }
        public static bool GetHeaderByFooter(JetBrains.ReSharper.Psi.Parsing.CachingLexer lexer, JetBrains.ReSharper.Psi.Html.Parsing.IHtmlTokenNodeTypes htmlTokenNodeTypes, JetBrains.ReSharper.Feature.Services.Html.TypingAssist.HtmlLexerUtils.TagNameContainerInfo footer) { }
        public static JetBrains.ReSharper.Feature.Services.Html.TypingAssist.HtmlLexerUtils.TagNameContainerInfo GetTagNameContainerInfo(JetBrains.ReSharper.Psi.Parsing.CachingLexer lexer, JetBrains.ReSharper.Psi.Html.Parsing.IHtmlTokenNodeTypes htmlTokenNodeTypes) { }
        public static bool InsideTagHeader(JetBrains.ReSharper.Psi.Parsing.CachingLexer lexer, JetBrains.ReSharper.Psi.Html.Parsing.IHtmlTokenNodeTypes htmlTokenNodeTypes) { }
        public class TagNameContainerInfo
        {
            public TagNameContainerInfo() { }
            public bool Closed { get; }
            public int EndPosition { get; set; }
            public int NamePosition { get; set; }
            public bool SelfClosed { get; set; }
            public int StartPosition { get; set; }
            public string TagName { get; set; }
            public int TokenIndexForEnd { get; set; }
            public int TokenIndexForName { get; set; }
            public int TokenIndexForStart { get; set; }
            public JetBrains.ReSharper.Feature.Services.Html.TypingAssist.TagNameContainerType Type { get; set; }
        }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class HtmlTypingAssist : JetBrains.ReSharper.Feature.Services.Html.TypingAssist.WebTypingAssist<JetBrains.ProjectModel.HtmlProjectFileType, JetBrains.ReSharper.Psi.Html.HtmlLanguage, JetBrains.ReSharper.Psi.Html.Parsing.IHtmlTokenNodeTypes, JetBrains.ReSharper.Feature.Services.Html.Options.HtmlTypingAssistSettings>
    {
        public HtmlTypingAssist(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Psi.Services.CachingLexerService cachingLexerService, JetBrains.Application.CommandProcessing.ICommandProcessor commandProcessor, JetBrains.ReSharper.Feature.Services.CodeCompletion.IntellisenseManager intellisenseManager, JetBrains.Application.Settings.ISettingsStore settingsStore, JetBrains.ReSharper.Feature.Services.TypingAssist.SkippingTypingAssist skippingTypingAssist, JetBrains.ReSharper.Psi.ILanguageManager languageManager, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.Html.TypingAssist.ISpecialTagSmartEnterHandler> smartEnterHandlers, JetBrains.ReSharper.Feature.Services.ParameterInfo.ParameterInfoPopupController parameterInfoPopupController, JetBrains.ReSharper.Feature.Services.TypingAssist.ITypingAssistManager typingAssistManager, JetBrains.ReSharper.Psi.IPsiServices psiServices, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.TypingAssist.ISecondaryTypingAssist> secondaryTypingAssists) { }
        public override bool QuickCheckAvailability(JetBrains.TextControl.ITextControl textControl, JetBrains.ReSharper.Psi.IPsiSourceFile projectFile) { }
    }
    public interface IDocumentLifetimeProvider
    {
        JetBrains.DataFlow.Lifetime CreateLifetimeUntilDocumentChanged(JetBrains.TextControl.ITextControl textControl);
        JetBrains.DataFlow.Lifetime CreateLifetimeUntilDocumentChangedOrCaretMoved(JetBrains.TextControl.ITextControl textControl);
    }
    public interface ISpecialTagSmartEnterHandler
    {
        bool FormatOnSmartEnter(JetBrains.ReSharper.Psi.Html.Tree.IHtmlTag tag, JetBrains.TextControl.ITextControl textControl);
        bool IsTagSupported(JetBrains.ReSharper.Psi.Html.Tree.IHtmlTag tag, JetBrains.TextControl.ITextControl textControl);
    }
    public abstract class SpecificChangedTagNameTracker<TSettings, TProjectFileType> : JetBrains.ReSharper.Feature.Services.Html.TypingAssist.ChangedTagNameTracker
        where TSettings : JetBrains.ReSharper.Feature.Services.Html.Options.HtmlTypingAssistSettings
        where TProjectFileType : JetBrains.ProjectModel.ProjectFileType
    {
        protected SpecificChangedTagNameTracker(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Settings.ISettingsStore settingsStore, JetBrains.ReSharper.Psi.Services.CachingLexerService cachingLexerService, JetBrains.Application.CommandProcessing.ICommandProcessor commandProcessor, JetBrains.TextControl.Impl.TextControlTypingHandlers textControlTypingHandlers, JetBrains.DataFlow.Lifetime lifetime, JetBrains.TextControl.ITextControlManager textControlManager, JetBrains.Application.IShellLocks shellLocks, JetBrains.ActionManagement.IActionManager actionManager, JetBrains.ProjectModel.Model2.Transaction.IEnsureWritableHandler ensureWritableHandler, JetBrains.DocumentManagers.DocumentManager documentManager, JetBrains.ReSharper.Feature.Services.Lookup.ILookupWindowManager lookupWindowManager, JetBrains.ReSharper.Psi.Files.IPsiFiles psiFiles, JetBrains.Application.ChangeManager changeManager, JetBrains.ReSharper.Feature.Services.TypingAssist.ITypingAssistManager typingAssistManager) { }
        protected override bool IsAvailable(JetBrains.TextControl.ITextControl textControl, JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
    }
    public class TagMarkers
    {
        public static readonly JetBrains.ReSharper.Feature.Services.Html.TypingAssist.TagMarkers DEFAULT;
        public TagMarkers(string tagName, JetBrains.DocumentModel.IRangeMarker firstTagNameRange, JetBrains.DocumentModel.IRangeMarker secondTagNameRange, bool changeTrackerCancelled, bool firstTagIsHeader) { }
        public int CaretPosition { get; set; }
        public string ChangedTagName { get; set; }
        public bool ChangeTrackerCancelled { get; set; }
        public bool FirstTagIsHeader { get; set; }
        public JetBrains.DocumentModel.IRangeMarker FirstTagNameRange { get; set; }
        public bool IsProcessingCommand { get; set; }
        public JetBrains.DocumentModel.IRangeMarker SecondTagNameRange { get; set; }
        public string TagName { get; set; }
    }
    public enum TagNameContainerType
    {
        Header = 0,
        Footer = 1,
    }
    public abstract class WebTypingAssist<TProjectFileType, TLanguage, TTokenTypes, TSettings> : JetBrains.ReSharper.Feature.Services.TypingAssist.TypingAssistLanguageBase<TLanguage, JetBrains.ReSharper.Psi.Html.IHtmlCodeFormatter>, JetBrains.ReSharper.Feature.Services.TypingAssist.ITypingHandler
        where TProjectFileType : JetBrains.ProjectModel.ProjectFileType
        where TLanguage : JetBrains.ReSharper.Psi.PsiLanguageType
        where TTokenTypes :  class, JetBrains.ReSharper.Psi.Html.Parsing.IHtmlTokenNodeTypes
        where TSettings : JetBrains.ReSharper.Feature.Services.Html.Options.HtmlTypingAssistSettings
    {
        protected WebTypingAssist(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Psi.Services.CachingLexerService cachingLexerService, JetBrains.Application.CommandProcessing.ICommandProcessor commandProcessor, JetBrains.ReSharper.Feature.Services.CodeCompletion.IntellisenseManager intellisenseManager, JetBrains.Application.Settings.ISettingsStore settingsStore, JetBrains.ReSharper.Feature.Services.TypingAssist.SkippingTypingAssist skippingTypingAssist, JetBrains.ReSharper.Psi.ILanguageManager languageManager, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.Html.TypingAssist.ISpecialTagSmartEnterHandler> smartEnterHandlers, JetBrains.ReSharper.Feature.Services.ParameterInfo.ParameterInfoPopupController parameterInfoPopupController, JetBrains.ReSharper.Feature.Services.TypingAssist.ITypingAssistManager typingAssistManager, JetBrains.ReSharper.Psi.IPsiServices psiServices, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.TypingAssist.ISecondaryTypingAssist> secondaryTypingAssists) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.TypingAssist.ISecondaryTypingAssist> SecondaryTypingAssists { get; }
        protected virtual bool DoHandleEnterAfterHeaderPressed(JetBrains.TextControl.ITextControl textControl) { }
        protected bool FormatTag(JetBrains.TextControl.ITextControl textControl, JetBrains.ReSharper.Psi.Tree.IFile file, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode headerNode, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode footerNode, TTokenTypes tokenTypes, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode parentTag) { }
        protected JetBrains.ReSharper.Psi.Html.Parsing.HtmlElementFactory GetElementFactory(JetBrains.TextControl.ITextControl textControl) { }
        protected virtual bool HandleBackspacePressed(JetBrains.ReSharper.Feature.Services.TypingAssist.IActionContext context) { }
        protected bool HandleDelPressed(JetBrains.ReSharper.Feature.Services.TypingAssist.IActionContext context) { }
        protected bool HandleEnterPressed(JetBrains.ReSharper.Feature.Services.TypingAssist.IActionContext context) { }
        protected bool HandleEq(JetBrains.TextControl.ITypingContext typingContext) { }
        protected virtual bool HandleQuoteAtTokenStart(JetBrains.TextControl.ITextControl textControl, JetBrains.ReSharper.Psi.Parsing.CachingLexer lexer, TTokenTypes tokenTypes) { }
        protected bool HandleQuoteTyped(JetBrains.TextControl.ITypingContext typingContext) { }
        protected bool HandleSlash(JetBrains.TextControl.ITypingContext typingContext) { }
        protected override bool IsSupported(JetBrains.TextControl.ITextControl textControl) { }
        protected virtual bool IsTokenEnd(JetBrains.ReSharper.Psi.Html.Parsing.IHtmlTokenNodeType<TTokenTypes> tokenType) { }
        public virtual bool QuickCheckAvailability(JetBrains.TextControl.ITextControl textControl, JetBrains.ReSharper.Psi.IPsiSourceFile projectFile) { }
    }
}
namespace JetBrains.ReSharper.Intentions.Html.ContextActions
{
    
    public abstract class HtmlContextActionDataBuilderBase<THtmlFile, THtmlLanguage> : JetBrains.ReSharper.Feature.Services.Bulbs.IContextActionDataBuilder
        where THtmlFile :  class, JetBrains.ReSharper.Psi.Html.Tree.IHtmlFile
        where THtmlLanguage : JetBrains.ReSharper.Psi.Html.HtmlLanguage
    {
        public JetBrains.ReSharper.Feature.Services.Bulbs.IContextActionDataProvider Build(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
    }
    public class static HtmlContextActionDataProvider
    {
        public sealed class ContextKey : JetBrains.ReSharper.Daemon.CaretDependentFeatures.ContextKeyWithValueBase<JetBrains.ReSharper.Feature.Services.Html.Bulbs.IWebContextActionDataProvider<JetBrains.ReSharper.Psi.Html.Tree.IHtmlFile>>
        {
            public static readonly JetBrains.ReSharper.Intentions.Html.ContextActions.HtmlContextActionDataProvider.ContextKey Instance;
        }
        [JetBrains.ProjectModel.SolutionComponentAttribute()]
        public class Current : JetBrains.ReSharper.Daemon.Bulbs.CurrentContextActionDataProviderBase<JetBrains.ReSharper.Feature.Services.Html.Bulbs.IWebContextActionDataProvider<JetBrains.ReSharper.Psi.Html.Tree.IHtmlFile>, JetBrains.ReSharper.Psi.Html.HtmlLanguage, JetBrains.ReSharper.Psi.Html.Tree.IHtmlFile>
        {
            public Current(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.IShellLocks shellLocks, JetBrains.ReSharper.Daemon.CaretDependentFeatures.ContextManager contextManager, JetBrains.ReSharper.Psi.AsyncCommitService asyncCommitService, JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControlManager textControlManager, JetBrains.ReSharper.Psi.Files.IPsiFiles psiFiles) { }
            protected override JetBrains.ReSharper.Feature.Services.Html.Bulbs.IWebContextActionDataProvider<JetBrains.ReSharper.Psi.Html.Tree.IHtmlFile> CreateDataProvider(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl, JetBrains.ReSharper.Psi.Html.Tree.IHtmlFile psiFile) { }
            protected override JetBrains.ReSharper.Daemon.CaretDependentFeatures.ContextKeyWithValueBase<JetBrains.ReSharper.Feature.Services.Html.Bulbs.IWebContextActionDataProvider<JetBrains.ReSharper.Psi.Html.Tree.IHtmlFile>> GetContextKey() { }
        }
    }
}