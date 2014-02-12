[assembly: JetBrains.ActionManagement.ActionsXmlAttribute("JetBrains.ReSharper.Feature.Services.Css.resources.Actions.xml")]
[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]

namespace JetBrains.ReSharper.Feature.Services.Css.Bulbs
{
    
    public class CssContextActionDataProvider : JetBrains.ReSharper.Feature.Services.Bulbs.CachedContextActionDataProviderBase<JetBrains.ReSharper.Psi.Css.Tree.ICssFile>, JetBrains.ReSharper.Feature.Services.Bulbs.IContextActionDataProvider, JetBrains.ReSharper.Feature.Services.Bulbs.IContextActionDataProvider<JetBrains.ReSharper.Psi.Css.Tree.ICssFile>, JetBrains.ReSharper.Feature.Services.Css.Bulbs.ICssContextActionDataProvider
    {
        public CssContextActionDataProvider(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl, JetBrains.ReSharper.Psi.Css.Tree.ICssFile file) { }
        public JetBrains.ReSharper.Psi.Css.CssElementFactory ElementFactory { get; }
        public sealed class ContextKey : JetBrains.ReSharper.Daemon.CaretDependentFeatures.ContextKeyWithValueBase<JetBrains.ReSharper.Feature.Services.Css.Bulbs.ICssContextActionDataProvider>
        {
            public static readonly JetBrains.ReSharper.Feature.Services.Css.Bulbs.CssContextActionDataProvider.ContextKey Instance;
        }
        [JetBrains.ProjectModel.SolutionComponentAttribute()]
        public class Current : JetBrains.ReSharper.Daemon.Bulbs.CurrentContextActionDataProviderBase<JetBrains.ReSharper.Feature.Services.Css.Bulbs.ICssContextActionDataProvider, JetBrains.ReSharper.Psi.Css.CssLanguage, JetBrains.ReSharper.Psi.Css.Tree.ICssFile>
        {
            public Current(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.IShellLocks shellLocks, JetBrains.ReSharper.Daemon.CaretDependentFeatures.ContextManager contextManager, JetBrains.ReSharper.Psi.AsyncCommitService asyncCommitService, JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControlManager textControlManager, JetBrains.ReSharper.Psi.Files.IPsiFiles psiFiles) { }
            protected override JetBrains.ReSharper.Feature.Services.Css.Bulbs.ICssContextActionDataProvider CreateDataProvider(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl, JetBrains.ReSharper.Psi.Css.Tree.ICssFile psiFile) { }
            protected override JetBrains.ReSharper.Daemon.CaretDependentFeatures.ContextKeyWithValueBase<JetBrains.ReSharper.Feature.Services.Css.Bulbs.ICssContextActionDataProvider> GetContextKey() { }
        }
    }
    public interface ICssContextActionDataProvider : JetBrains.ReSharper.Feature.Services.Bulbs.IContextActionDataProvider, JetBrains.ReSharper.Feature.Services.Bulbs.IContextActionDataProvider<JetBrains.ReSharper.Psi.Css.Tree.ICssFile>
    {
        JetBrains.ReSharper.Psi.Css.CssElementFactory ElementFactory { get; }
    }
}
namespace JetBrains.ReSharper.Feature.Services.Css.CodeCleanup
{
    
    [JetBrains.ReSharper.Feature.Services.CodeCleanup.CodeCleanupModuleAttribute(ModulesAfter=new System.Type[] {
            typeof(JetBrains.ReSharper.Feature.Services.Css.CodeCleanup.ReformatCode)})]
    public class AlphabetizeProperties : JetBrains.ReSharper.Feature.Services.CodeCleanup.ICodeCleanupModule
    {
        public System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.CodeCleanup.CodeCleanupOptionDescriptor> Descriptors { get; }
        public bool IsAvailableOnSelection { get; }
        public JetBrains.ReSharper.Psi.PsiLanguageType LanguageType { get; }
        public bool IsAvailable(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
        public void Process(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, JetBrains.DocumentModel.IRangeMarker rangeMarker, JetBrains.ReSharper.Feature.Services.CodeCleanup.CodeCleanupProfile profile, JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
        public void SetDefaultSetting(JetBrains.ReSharper.Feature.Services.CodeCleanup.CodeCleanupProfile profile, JetBrains.ReSharper.Feature.Services.CodeCleanup.CodeCleanup.DefaultProfileType profileType) { }
    }
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
namespace JetBrains.ReSharper.Feature.Services.Css.CodeCompletion
{
    
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class CssAutomaticStrategyOnPunctuation : JetBrains.ReSharper.Feature.Services.CodeCompletion.IAutomaticCodeCompletionStrategy
    {
        public CssAutomaticStrategyOnPunctuation(JetBrains.ReSharper.Feature.Services.Css.CodeCompletion.Settings.CssIntellisenseManager cssIntellisenseManager, JetBrains.Application.Settings.ISettingsStore settingsStore) { }
        public JetBrains.ReSharper.Feature.Services.CodeCompletion.CodeCompletionType CodeCompletionType { get; }
        public bool ForceHideCompletion { get; }
        public JetBrains.ReSharper.Psi.PsiLanguageType Language { get; }
        public bool AcceptsFile(JetBrains.ReSharper.Psi.Tree.IFile file, JetBrains.TextControl.ITextControl textControl) { }
        public bool AcceptTyping(char c, JetBrains.TextControl.ITextControl textControl, JetBrains.Application.Settings.IContextBoundSettingsStore boundSettingsStore) { }
        public JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.AutopopupType IsEnabledInSettings(JetBrains.Application.Settings.IContextBoundSettingsStore settingsStore, JetBrains.TextControl.ITextControl textControl) { }
        public bool ProcessSubsequentTyping(char c, JetBrains.TextControl.ITextControl textControl) { }
    }
    public class CssCodeCompletionContext : JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.SpecificCodeCompletionContext
    {
        public CssCodeCompletionContext(JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.CodeCompletionContext context, JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.TextLookupRanges referenceRanges, JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.TextLookupRanges elementRanges, JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ReparsedCodeCompletionContext unterminatedContext, JetBrains.ReSharper.Psi.PsiLanguageType language) { }
        public override string ContextId { get; }
        public JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.TextLookupRanges ElementRanges { get; set; }
        public override JetBrains.ReSharper.Psi.PsiLanguageType Language { get; }
        public JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.TextLookupRanges ReferenceRanges { get; set; }
        public JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ReparsedCodeCompletionContext UnterminatedContext { get; set; }
    }
    [JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.IntellisensePartAttribute()]
    public class CssCodeCompletionContextProviderWithReparse : JetBrains.ReSharper.Feature.Services.CodeCompletion.Impl.CodeCompletionContextProviderBase
    {
        public CssCodeCompletionContextProviderWithReparse(JetBrains.ReSharper.Feature.Services.Css.CodeCompletion.Settings.CssIntellisenseManager cssIntellisenseManager) { }
        public override JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ISpecificCodeCompletionContext GetCompletionContext(JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.CodeCompletionContext context) { }
        public static JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ISpecificCodeCompletionContext GetSpecificContext(JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.CodeCompletionContext context, JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ReparsedCodeCompletionContext unterminatedContext) { }
        public override bool IsApplicable(JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.CodeCompletionContext context) { }
    }
    [JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.IntellisensePartAttribute()]
    public class CssCompletingCharactersProvider : JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.CompletingCharsProviderWithSetting<JetBrains.ReSharper.Feature.Services.Css.CodeCompletion.CssCodeCompletionContext, JetBrains.ReSharper.Feature.Services.Css.CodeCompletion.CssCompletingCharactersSettingsKey>
    {
        protected override System.Linq.Expressions.Expression<System.Func<JetBrains.ReSharper.Feature.Services.Css.CodeCompletion.CssCompletingCharactersSettingsKey, bool>> GetCompleteOnSpaceSettingKey() { }
        protected override System.Linq.Expressions.Expression<System.Func<JetBrains.ReSharper.Feature.Services.Css.CodeCompletion.CssCompletingCharactersSettingsKey, JetBrains.ReSharper.Feature.Services.Lookup.LookupItemInsertType>> GetEnterActionSettingKey() { }
        protected override System.Linq.Expressions.Expression<System.Func<JetBrains.ReSharper.Feature.Services.Css.CodeCompletion.CssCompletingCharactersSettingsKey, string>> GetNonCompletingCharactersSettingKey() { }
        protected override System.Linq.Expressions.Expression<System.Func<JetBrains.ReSharper.Feature.Services.Css.CodeCompletion.CssCompletingCharactersSettingsKey, JetBrains.ReSharper.Feature.Services.Lookup.LookupItemInsertType>> GetTabActionSettingKey() { }
        protected override bool IsApplicable(JetBrains.ReSharper.Feature.Services.Css.CodeCompletion.CssCodeCompletionContext context) { }
    }
    [JetBrains.Application.Settings.SettingsKeyAttribute(typeof(JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.IntelliSenseCompletingCharactersSettingsKey), "CSS")]
    public class CssCompletingCharactersSettingsKey
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
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.Css.CssLanguage))]
    public class CssHexColorCompletionRule : JetBrains.ReSharper.Feature.Services.Css.CodeCompletion.ItemsProviderWithContainer<JetBrains.ReSharper.Feature.Services.Css.CodeCompletion.CssCodeCompletionContext, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Colors.IColorElement>>
    {
        public CssHexColorCompletionRule(JetBrains.ReSharper.Feature.Services.VisualElements.IVisualElementFactory elementFactory) { }
        protected override void EvaluateLookupItems(JetBrains.ReSharper.Feature.Services.Css.CodeCompletion.CssCodeCompletionContext context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector, JetBrains.Text.IdentifierMatcher prefixMatcher, JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.TextLookupRanges ranges, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Colors.IColorElement> itemsContainer) { }
        protected override JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.TextLookupRanges EvaluateLookupRanges(JetBrains.ReSharper.Feature.Services.Css.CodeCompletion.CssCodeCompletionContext context) { }
        protected override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Colors.IColorElement> GetCompletableItems(JetBrains.ReSharper.Feature.Services.Css.CodeCompletion.CssCodeCompletionContext context) { }
        protected override JetBrains.ReSharper.Feature.Services.Lookup.LookupFocusBehaviour GetLookupFocusBehaviour(JetBrains.ReSharper.Feature.Services.Css.CodeCompletion.CssCodeCompletionContext context) { }
        protected override bool IsAvailable(JetBrains.ReSharper.Feature.Services.Css.CodeCompletion.CssCodeCompletionContext context) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.Css.CssLanguage))]
    public class CssHexColorStringCompletionRule : JetBrains.ReSharper.Feature.Services.Css.CodeCompletion.ItemsProviderWithContainer<JetBrains.ReSharper.Feature.Services.Css.CodeCompletion.CssCodeCompletionContext, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Colors.IColorElement>>
    {
        public CssHexColorStringCompletionRule(JetBrains.ReSharper.Feature.Services.VisualElements.IVisualElementFactory elementFactory) { }
        protected override void EvaluateLookupItems(JetBrains.ReSharper.Feature.Services.Css.CodeCompletion.CssCodeCompletionContext context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector, JetBrains.Text.IdentifierMatcher prefixMatcher, JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.TextLookupRanges ranges, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Colors.IColorElement> itemsContainer) { }
        protected override JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.TextLookupRanges EvaluateLookupRanges(JetBrains.ReSharper.Feature.Services.Css.CodeCompletion.CssCodeCompletionContext context) { }
        protected override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Colors.IColorElement> GetCompletableItems(JetBrains.ReSharper.Feature.Services.Css.CodeCompletion.CssCodeCompletionContext context) { }
        protected override JetBrains.ReSharper.Feature.Services.Lookup.LookupFocusBehaviour GetLookupFocusBehaviour(JetBrains.ReSharper.Feature.Services.Css.CodeCompletion.CssCodeCompletionContext context) { }
        protected override bool IsAvailable(JetBrains.ReSharper.Feature.Services.Css.CodeCompletion.CssCodeCompletionContext context) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.Css.CssLanguage))]
    public class CssImportantKeywordCompletionRule : JetBrains.ReSharper.Feature.Services.Css.CodeCompletion.ItemsProviderWithContainer<JetBrains.ReSharper.Feature.Services.Css.CodeCompletion.CssCodeCompletionContext, System.Collections.Generic.IEnumerable<string>>
    {
        protected override void EvaluateLookupItems(JetBrains.ReSharper.Feature.Services.Css.CodeCompletion.CssCodeCompletionContext context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector, JetBrains.Text.IdentifierMatcher prefixMatcher, JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.TextLookupRanges ranges, System.Collections.Generic.IEnumerable<string> itemsContainer) { }
        protected override JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.TextLookupRanges EvaluateLookupRanges(JetBrains.ReSharper.Feature.Services.Css.CodeCompletion.CssCodeCompletionContext context) { }
        protected override System.Collections.Generic.IEnumerable<string> GetCompletableItems(JetBrains.ReSharper.Feature.Services.Css.CodeCompletion.CssCodeCompletionContext context) { }
        protected override JetBrains.ReSharper.Feature.Services.Lookup.LookupFocusBehaviour GetLookupFocusBehaviour(JetBrains.ReSharper.Feature.Services.Css.CodeCompletion.CssCodeCompletionContext context) { }
    }
    public class CssKeywordCompletionRule : JetBrains.ReSharper.Feature.Services.Css.CodeCompletion.ItemsProviderWithContainer<JetBrains.ReSharper.Feature.Services.Css.CodeCompletion.CssCodeCompletionContext, System.Collections.Generic.IEnumerable<string>>
    {
        protected override void EvaluateLookupItems(JetBrains.ReSharper.Feature.Services.Css.CodeCompletion.CssCodeCompletionContext context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector, JetBrains.Text.IdentifierMatcher prefixMatcher, JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.TextLookupRanges ranges, System.Collections.Generic.IEnumerable<string> itemsContainer) { }
        protected override JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.TextLookupRanges EvaluateLookupRanges(JetBrains.ReSharper.Feature.Services.Css.CodeCompletion.CssCodeCompletionContext context) { }
        protected override System.Collections.Generic.IEnumerable<string> GetCompletableItems(JetBrains.ReSharper.Feature.Services.Css.CodeCompletion.CssCodeCompletionContext context) { }
        protected override JetBrains.ReSharper.Feature.Services.Lookup.LookupFocusBehaviour GetLookupFocusBehaviour(JetBrains.ReSharper.Feature.Services.Css.CodeCompletion.CssCodeCompletionContext context) { }
    }
    public class CssReparsedCompletionContext : JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ReparsedCodeCompletionContext
    {
        public CssReparsedCompletionContext(JetBrains.ReSharper.Psi.Tree.IFile file, JetBrains.ReSharper.Psi.TreeTextRange selectedTreeRange, string placeholder) { }
        protected override JetBrains.ReSharper.Psi.Services.IReparseContext GetReparseContext(JetBrains.ReSharper.Psi.Tree.IFile file, JetBrains.ReSharper.Psi.TreeTextRange range) { }
    }
    public class CssTailType : JetBrains.ReSharper.Psi.ExpectedTypes.TailType
    {
        public static readonly JetBrains.ReSharper.Psi.ExpectedTypes.TailType Braces;
        public static readonly JetBrains.ReSharper.Psi.ExpectedTypes.TailType MediaColon;
        public static readonly JetBrains.ReSharper.Psi.ExpectedTypes.TailType Parentheses;
        public static readonly JetBrains.ReSharper.Psi.ExpectedTypes.TailType ParenthesesAndLeaveCaretWithin;
        public static readonly JetBrains.ReSharper.Psi.ExpectedTypes.TailType PropertyColon;
        public static readonly JetBrains.ReSharper.Psi.ExpectedTypes.TailType Whitespace;
        public override JetBrains.ReSharper.Psi.Parsing.TokenNodeType[] EvaluateTail(JetBrains.ProjectModel.ISolution solution, JetBrains.DocumentModel.IDocument document) { }
    }
    public class static CssValueTemplates
    {
        public static readonly System.Collections.Generic.Dictionary<string, JetBrains.ReSharper.LiveTemplates.Templates.Template> ValueTemplates;
    }
    public abstract class ItemsProviderWithContainer<TContext, TContainer> : JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ItemsProviderOfSpecificContext<TContext>
        where TContext :  class, JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ISpecificCodeCompletionContext
        where TContainer :  class
    {
        protected override bool AddLookupItems(TContext context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector) { }
        protected abstract void EvaluateLookupItems(TContext context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector, JetBrains.Text.IdentifierMatcher prefixMatcher, JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.TextLookupRanges ranges, [JetBrains.Annotations.NotNullAttribute()] TContainer itemsContainer);
        [JetBrains.Annotations.CanBeNullAttribute()]
        protected abstract JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.TextLookupRanges EvaluateLookupRanges([JetBrains.Annotations.NotNullAttribute()] TContext context);
        [JetBrains.Annotations.NotNullAttribute()]
        protected abstract TContainer GetCompletableItems([JetBrains.Annotations.NotNullAttribute()] TContext context);
    }
}
namespace JetBrains.ReSharper.Feature.Services.Css.CodeCompletion.Settings
{
    
    [JetBrains.Application.Settings.SettingsKeyAttribute(typeof(JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.AutopopupEnabledSettingsKey), "CSS")]
    public class CssAutopopupEnabledSettingsKey
    {
        [JetBrains.Application.Settings.SettingsEntryAttribute(JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.AutopopupType.SoftAutopopup, "On hex colors")]
        public JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.AutopopupType OnHexColors;
        [JetBrains.Application.Settings.SettingsEntryAttribute(JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.AutopopupType.HardAutopopup, "On identifiers")]
        public JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.AutopopupType OnIdentifiers;
        [JetBrains.Application.Settings.SettingsEntryAttribute(JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.AutopopupType.HardAutopopup, "On punctuation")]
        public JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.AutopopupType OnPunctuation;
        [JetBrains.Application.Settings.SettingsEntryAttribute(JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.AutopopupType.SoftAutopopup, "On selectors")]
        public JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.AutopopupType OnSelectors;
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class CssIntellisenseManager : JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.LanguageSpecificIntellisenseManager
    {
        public CssIntellisenseManager(JetBrains.Application.Settings.ISettingsStore settingsStore) { }
        protected override bool GetIntellisenseEnabledSpecific(JetBrains.Application.Settings.IContextBoundSettingsStore boundSettingsStore) { }
    }
    [JetBrains.Application.Settings.SettingsKeyAttribute(typeof(JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.IntellisenseEnabledSettingsKey), "Override VS IntelliSense for CSS")]
    public class IntellisenseEnabledCssSettingsKey
    {
        [JetBrains.Application.Settings.SettingsEntryAttribute(false, "CSS (.css files and embedded CSS)")]
        public bool IntellisenseEnabled;
    }
}
namespace JetBrains.ReSharper.Feature.Services.Css.CodeStructure
{
    
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.Css.CssLanguage))]
    public class CssCodeStructureProvider : JetBrains.ReSharper.Feature.Services.CodeStructure.IPsiFileCodeStructureProvider
    {
        public JetBrains.ReSharper.Feature.Services.CodeStructure.CodeStructureRootElement Build(JetBrains.ReSharper.Psi.Tree.IFile file, JetBrains.ReSharper.Feature.Services.CodeStructure.CodeStructureOptions options) { }
    }
    public class QuickSearchTextCollector : JetBrains.ReSharper.Psi.Css.Tree.TreeNodeVisitor<System.Collections.Generic.ICollection<string>>, JetBrains.ReSharper.Psi.IRecursiveElementProcessor<System.Collections.Generic.ICollection<string>>
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Collections.Generic.IList<string> GetQuickSearchText([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode node) { }
        public static void GetQuickSearchText([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode node, [JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.ICollection<string> words) { }
        public bool InteriorShouldBeProcessed(JetBrains.ReSharper.Psi.Tree.ITreeNode element, System.Collections.Generic.ICollection<string> context) { }
        public bool IsProcessingFinished(System.Collections.Generic.ICollection<string> context) { }
        public void ProcessAfterInterior(JetBrains.ReSharper.Psi.Tree.ITreeNode element, System.Collections.Generic.ICollection<string> context) { }
        public void ProcessBeforeInterior(JetBrains.ReSharper.Psi.Tree.ITreeNode element, System.Collections.Generic.ICollection<string> context) { }
        public override void VisitNode(JetBrains.ReSharper.Psi.Tree.ITreeNode node, System.Collections.Generic.ICollection<string> context) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.Css.Colors
{
    
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.Css.CssLanguage))]
    public class CssColorDeclaredElementSearcher : JetBrains.ReSharper.Feature.Services.Colors.IColorDeclaredElementSearcher
    {
        public System.Collections.Generic.IEnumerable<string> GetWords(JetBrains.ReSharper.Psi.Colors.IColorDeclaredElement element) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.Css.ContextHighlighters
{
    
    [JetBrains.ReSharper.Daemon.CaretDependentFeatures.ContainsContextConsumerAttribute()]
    public class CssMatchingBraceContextHighlighter : JetBrains.ReSharper.Feature.Services.ContextHighlighters.MatchingBraceContextHighlighterBase
    {
        protected override bool IsLeftBracket(JetBrains.ReSharper.Psi.Parsing.TokenNodeType tokenType) { }
        protected override bool IsRightBracket(JetBrains.ReSharper.Psi.Parsing.TokenNodeType tokenType) { }
        protected override bool Match(JetBrains.ReSharper.Psi.Parsing.TokenNodeType token1, JetBrains.ReSharper.Psi.Parsing.TokenNodeType token2) { }
        [JetBrains.ReSharper.Daemon.CaretDependentFeatures.AsyncContextConsumerAttribute()]
        public static System.Action ProcessDataContext(JetBrains.DataFlow.Lifetime lifetime, [JetBrains.ReSharper.Daemon.CaretDependentFeatures.ContextKeyAttribute(typeof(JetBrains.ReSharper.Feature.Services.Css.Bulbs.CssContextActionDataProvider.ContextKey))] JetBrains.ReSharper.Feature.Services.Bulbs.IContextActionDataProvider dataProvider, JetBrains.ReSharper.Daemon.CaretDependentFeatures.InvisibleBraceHintManager invisibleBraceHintManager, JetBrains.ReSharper.Feature.Services.ContextHighlighters.MatchingBraceSuggester matchingBraceSuggester) { }
        protected override void TryHighlightToLeft(JetBrains.ReSharper.Feature.Services.ContextHighlighters.MatchingHighlightingsConsumer consumer, JetBrains.ReSharper.Psi.Tree.ITokenNode selectedToken, JetBrains.ReSharper.Psi.TreeOffset treeOffset) { }
        protected override void TryHighlightToRight(JetBrains.ReSharper.Feature.Services.ContextHighlighters.MatchingHighlightingsConsumer consumer, JetBrains.ReSharper.Psi.Tree.ITokenNode selectedToken, JetBrains.ReSharper.Psi.TreeOffset treeOffset) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.Css.ContextSearch
{
    
    [JetBrains.ReSharper.Psi.ShellFeaturePartAttribute()]
    public class ImplementationContextSearch : JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextSearches.BaseSearches.ImplementationContextSearch
    {
        protected override bool IsAvailableInternal(JetBrains.Application.DataContext.IDataContext dataContext) { }
        public override bool IsContextApplicable(JetBrains.Application.DataContext.IDataContext dataContext) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.Css.GoToMatchedTags
{
    
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "GotoMatchedTags"})]
    public class GoToMatchedTagsAction : JetBrains.ReSharper.Features.Finding.NavigateFromHere.ContextNavigationActionBase<JetBrains.ReSharper.Feature.Services.Css.GoToMatchedTags.IMatchedTagsNavigationProvider> { }
    [JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextNavigationProviderAttribute()]
    public class GotoMatchedTagsProvider : JetBrains.ReSharper.Features.Finding.NavigateFromHere.RequestContextSearchProvider<JetBrains.ReSharper.Feature.Services.Css.GoToMatchedTags.IMatchedTagsContextSearch, JetBrains.ReSharper.Feature.Services.Css.GoToMatchedTags.SearchMatchedTagsDescriptor, JetBrains.ReSharper.Feature.Services.Css.GoToMatchedTags.SearchMatchedTagsRequest>, JetBrains.ReSharper.Feature.Services.ActionsMenu.IWorkflowProvider<JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextNavigation, JetBrains.ReSharper.Feature.Services.ContextNavigation.NavigationActionGroup>, JetBrains.ReSharper.Feature.Services.ContextNavigation.INavigateFromHereProvider, JetBrains.ReSharper.Feature.Services.Css.GoToMatchedTags.IMatchedTagsNavigationProvider, JetBrains.ReSharper.Features.Finding.FindHierarchy.IFindUsagesProvider, JetBrains.ReSharper.Features.Finding.FindHierarchy.IGotoUsagesProvider, JetBrains.ReSharper.Features.Finding.NavigateFromHere.IContextSearchProvider
    {
        public GotoMatchedTagsProvider(JetBrains.ReSharper.Feature.Services.IFeaturePartsContainer manager) { }
        protected override JetBrains.ReSharper.Feature.Services.Css.GoToMatchedTags.SearchMatchedTagsDescriptor CreateSearchDescriptor(JetBrains.ReSharper.Feature.Services.Css.GoToMatchedTags.SearchMatchedTagsRequest searchRequest, System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.Search.IOccurence> occurences) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextNavigation> CreateWorkflow(JetBrains.Application.DataContext.IDataContext dataContext) { }
    }
    public interface IMatchedTagsContextSearch : JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextSearches.IContextSearch, JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextSearches.IRequestContextSearch<JetBrains.ReSharper.Feature.Services.Css.GoToMatchedTags.SearchMatchedTagsRequest> { }
    public interface IMatchedTagsNavigationProvider : JetBrains.ReSharper.Feature.Services.ActionsMenu.IWorkflowProvider<JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextNavigation, JetBrains.ReSharper.Feature.Services.ContextNavigation.NavigationActionGroup>, JetBrains.ReSharper.Feature.Services.ContextNavigation.INavigateFromHereProvider, JetBrains.ReSharper.Features.Finding.FindHierarchy.IFindUsagesProvider, JetBrains.ReSharper.Features.Finding.FindHierarchy.IGotoUsagesProvider, JetBrains.ReSharper.Features.Finding.NavigateFromHere.IContextSearchProvider { }
    [JetBrains.ReSharper.Psi.ShellFeaturePartAttribute()]
    public class MatchedTagsContextSearch : JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextSearches.BaseSearches.ContextSearchBase<JetBrains.ReSharper.Feature.Services.Css.GoToMatchedTags.SearchMatchedTagsRequest>, JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextSearches.IContextSearch, JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextSearches.IRequestContextSearch<JetBrains.ReSharper.Feature.Services.Css.GoToMatchedTags.SearchMatchedTagsRequest>, JetBrains.ReSharper.Feature.Services.Css.GoToMatchedTags.IMatchedTagsContextSearch
    {
        protected override JetBrains.ReSharper.Feature.Services.Css.GoToMatchedTags.SearchMatchedTagsRequest CreateSearchRequest(JetBrains.Application.DataContext.IDataContext dataContext, JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, JetBrains.ReSharper.Psi.IDeclaredElement initialTarget) { }
        protected override System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.DeclaredElementInstance> GetCandidateInstances(JetBrains.Application.DataContext.IDataContext context, JetBrains.ReSharper.Psi.Services.ReferencePreferenceKind kind) { }
        protected override bool IsAvailableInternal(JetBrains.Application.DataContext.IDataContext dataContext) { }
        public override bool IsContextApplicable(JetBrains.Application.DataContext.IDataContext dataContext) { }
    }
    public class SearchMatchedTagsDescriptor : JetBrains.ReSharper.Features.Finding.Search.SearchDescriptor
    {
        public SearchMatchedTagsDescriptor(JetBrains.ReSharper.Features.StructuralSearch.Finding.StructuralSearchRequest request, System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.Search.IOccurence> occurences) { }
        public override string GetResultsTitle(JetBrains.ReSharper.Features.Common.Occurences.OccurenceSection section) { }
    }
    public class SearchMatchedTagsRequest : JetBrains.ReSharper.Features.StructuralSearch.Finding.StructuralSearchRequest
    {
        public SearchMatchedTagsRequest(JetBrains.ProjectModel.ISolution solution, JetBrains.DocumentManagers.DocumentManager documentManager, JetBrains.ReSharper.Psi.Search.ISearchDomain domain, JetBrains.ReSharper.Psi.Search.SearchDomainFactory factory, JetBrains.ReSharper.Psi.Css.DeclaredElements.ICssSelectorDeclaredElement element) { }
        public override System.Collections.ICollection SearchTargets { get; }
    }
}
namespace JetBrains.ReSharper.Feature.Services.Css.Hierarchy.Actions
{
    
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "StyleHierarchy.BaseOnThis"})]
    public class BaseOnThisAction : JetBrains.ActionManagement.IActionHandler
    {
        public void Execute(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.DelegateExecute nextExecute) { }
        public bool Update(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.ActionPresentation presentation, JetBrains.ActionManagement.DelegateUpdate nextUpdate) { }
    }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "StyleHierarchy.ChildStylesHierarchy"})]
    public class ChildStylesHierarchyAction : JetBrains.ActionManagement.IActionHandler
    {
        public void Execute(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.DelegateExecute nextExecute) { }
        public virtual bool Update(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.ActionPresentation presentation, JetBrains.ActionManagement.DelegateUpdate nextUpdate) { }
    }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "StyleHierarchy.ParentStylesHierarchy"})]
    public class ParentStylesHierarchyAction : JetBrains.ActionManagement.IActionHandler
    {
        public void Execute(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.DelegateExecute nextExecute) { }
        public virtual bool Update(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.ActionPresentation presentation, JetBrains.ActionManagement.DelegateUpdate nextUpdate) { }
    }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "StyleHierarchy.StyleHierarchy"})]
    public class StyleHierarchyAction : JetBrains.ActionManagement.IActionHandler
    {
        public void Execute(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.DelegateExecute nextExecute) { }
        public virtual bool Update(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.ActionPresentation presentation, JetBrains.ActionManagement.DelegateUpdate nextUpdate) { }
    }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "StyleHierarchy.Update"})]
    public class UpdateStyleHierarchyAction : JetBrains.ActionManagement.IActionHandler
    {
        public void Execute(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.DelegateExecute nextExecute) { }
        public bool Update(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.ActionPresentation presentation, JetBrains.ActionManagement.DelegateUpdate nextUpdate) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.Css.Hierarchy
{
    
    public class CssStyleHierarchyController : JetBrains.ReSharper.Features.Browsing.Hierarchies.TypeHierarchy.TypeHierarchyController
    {
        public override bool Equals(JetBrains.ReSharper.Psi.IDeclaredElementEnvoy x, JetBrains.ReSharper.Psi.IDeclaredElementEnvoy y) { }
        protected override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IDeclaredElementEnvoy> GetActualDerivedTypes(JetBrains.ReSharper.Psi.IDeclaredElementEnvoy envoy, JetBrains.ReSharper.Features.Browsing.Hierarchies.TypeHierarchy.TypeHierarchyViewStyle viewStyle) { }
        protected override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IDeclaredElementEnvoy> GetActualSuperTypes(JetBrains.ReSharper.Psi.IDeclaredElementEnvoy envoy, JetBrains.ReSharper.Features.Browsing.Hierarchies.TypeHierarchy.TypeHierarchyViewStyle viewStyle) { }
        public override System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.Search.IOccurence> GetClassHierarchyOccurences(JetBrains.ReSharper.Psi.IDeclaredElementEnvoy target, bool applyFilter) { }
        public override System.Collections.Generic.IEnumerable<JetBrains.TreeModels.CascadeGroup> GetDefaultRootPath(JetBrains.ReSharper.Feature.Services.Search.IOccurence item, JetBrains.ReSharper.Features.Browsing.Hierarchies.HierarchyDescriptor<JetBrains.ReSharper.Psi.IDeclaredElementEnvoy> owner) { }
        public override int GetHashCode(JetBrains.ReSharper.Psi.IDeclaredElementEnvoy envoy) { }
        public override System.Collections.Generic.IList<JetBrains.ReSharper.Feature.Services.Search.IOccurence> GetImplementorsTreesOccurences(JetBrains.ReSharper.Psi.IDeclaredElementEnvoy target, bool applyFilter) { }
        public override System.Collections.Generic.IList<JetBrains.ReSharper.Feature.Services.Search.IOccurence> GetInterfaceLeavesOccurences(JetBrains.ReSharper.Psi.IDeclaredElementEnvoy target, bool applyFilter) { }
        protected override System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.Search.IOccurence> GetSubtypeOccurencesInternal(JetBrains.ReSharper.Psi.IDeclaredElementEnvoy target, JetBrains.ReSharper.Psi.Services.ElementEnvoyMap<JetBrains.ReSharper.Feature.Services.Search.IOccurence> map) { }
        public override System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.Search.IOccurence> GetSuperTypesOccurences(JetBrains.ReSharper.Psi.IDeclaredElementEnvoy target, bool applyFilter) { }
        protected override System.Collections.Generic.IEnumerable<JetBrains.TreeModels.CascadeGroup> UpdateGroupingRootPath(System.Collections.Generic.IEnumerable<JetBrains.TreeModels.CascadeGroup> input, JetBrains.ReSharper.Feature.Services.Search.IOccurence item, JetBrains.ReSharper.Features.Browsing.Hierarchies.HierarchyDescriptor<JetBrains.ReSharper.Psi.IDeclaredElementEnvoy> owner) { }
    }
    public class CssStyleHierarchyDescriptor : JetBrains.ReSharper.Features.Browsing.Hierarchies.HierarchyDescriptor<JetBrains.ReSharper.Psi.IDeclaredElementEnvoy>
    {
        public CssStyleHierarchyDescriptor(JetBrains.ReSharper.Feature.Services.Css.Hierarchy.CssStyleHierarchyController controller, JetBrains.ReSharper.Psi.IDeclaredElementEnvoy target, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Features.Browsing.Hierarchies.TypeHierarchy.TypeHierarchyViewStyle viewStyle) { }
        public override string ActionBarID { get; }
        public override JetBrains.UI.TreeView.StructuredPresenter<JetBrains.TreeModels.TreeModelNode, JetBrains.CommonControls.IPresentableItem> Presenter { get; }
        protected override void CreateGroupings(System.Collections.Generic.List<JetBrains.TreeModels.TreeModelGrouping<JetBrains.ReSharper.Feature.Services.Search.IOccurence>> groupings) { }
        protected override JetBrains.ReSharper.Features.Browsing.Hierarchies.HierarchyPresenterBase<JetBrains.ReSharper.Psi.IDeclaredElementEnvoy> CreatePresenter() { }
        public override void PreviewUpdate(System.Windows.Forms.Control previewControl, JetBrains.TreeModels.TreeModelNode modelNode, ref JetBrains.CommonControls.IPresentableItem previewCaption) { }
        protected override void UpdateTitle() { }
        protected class DefaultHierarchyGroupProvider : JetBrains.TreeModels.ITreeGroupProvider<JetBrains.ReSharper.Feature.Services.Search.IOccurence>
        {
            public DefaultHierarchyGroupProvider(JetBrains.ReSharper.Feature.Services.Css.Hierarchy.CssStyleHierarchyDescriptor descriptor) { }
            public virtual object ExtractGroupObject(JetBrains.ReSharper.Feature.Services.Search.IOccurence item) { }
        }
    }
    public class CssStyleHierarchyPresenter : JetBrains.ReSharper.Features.Browsing.Hierarchies.HierarchyPresenterBase<JetBrains.ReSharper.Psi.IDeclaredElementEnvoy>
    {
        public CssStyleHierarchyPresenter(JetBrains.ReSharper.Feature.Services.Css.Hierarchy.CssStyleHierarchyDescriptor descriptor, JetBrains.ProjectModel.ProjectModelElementPresentationService projectModelElementPresentationService) { }
        protected override void PresentDeclaredElementOccurence(JetBrains.ReSharper.Feature.Services.Occurences.DeclaredElementOccurence value, JetBrains.CommonControls.IPresentableItem item, JetBrains.TreeModels.TreeModelNode structureelement, JetBrains.UI.TreeView.PresentationState state) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.Css.Navigation
{
    
    [JetBrains.ReSharper.Psi.ShellFeaturePartAttribute()]
    public class CssClassDeclarationSearch : JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextSearches.BaseSearches.DefaultDeclarationSearch
    {
        public CssClassDeclarationSearch(JetBrains.ReSharper.Feature.Services.Occurences.OccurenceFactory occurenceFactory) { }
        protected override JetBrains.ReSharper.Feature.Services.Search.SearchRequests.SearchDeclarationsRequest CreateSearchRequest(JetBrains.Application.DataContext.IDataContext dataContext, JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, JetBrains.ReSharper.Psi.IDeclaredElement initialTarget) { }
        public override JetBrains.ReSharper.Feature.Services.Search.SearchRequests.SearchDeclarationsRequest GetDeclarationSearchRequest(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
        public override JetBrains.Util.JetTuple<System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IDeclaredElement>, JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextSearches.GetSearchRequest<JetBrains.ReSharper.Feature.Services.Search.SearchRequests.SearchDeclarationsRequest>> GetElementsAndSearchRequest(JetBrains.Application.DataContext.IDataContext dataContext) { }
        protected override bool IsAvailableInternal(JetBrains.Application.DataContext.IDataContext dataContext) { }
        public override bool IsContextApplicable(JetBrains.Application.DataContext.IDataContext dataContext) { }
        public override bool IsGotoDeclarationApplicable(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
    }
    public class CssClassSearchDeclarationsRequest : JetBrains.ReSharper.Feature.Services.Search.SearchRequests.SearchDeclarationsRequest
    {
        public CssClassSearchDeclarationsRequest(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, JetBrains.ReSharper.Feature.Services.Occurences.OccurenceFactory occurenceFactory) { }
        public override System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.Search.IOccurence> Search(JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
    }
    [JetBrains.ReSharper.Psi.ShellFeaturePartAttribute()]
    public class CssClassUsagesContextSearch : JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextSearches.BaseSearches.FindUsagesContextSearch
    {
        protected override JetBrains.ReSharper.Feature.Services.Search.SearchRequests.SearchUsagesRequest CreateSearchRequest(JetBrains.Application.DataContext.IDataContext dataContext, JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, JetBrains.ReSharper.Psi.IDeclaredElement initialTarget) { }
        public override bool IsContextApplicable(JetBrains.Application.DataContext.IDataContext dataContext) { }
    }
    [JetBrains.ReSharper.Psi.ShellFeaturePartAttribute()]
    public class CssGotoFileMemberProvider : JetBrains.ReSharper.Feature.Services.Goto.GotoProviders.NonCachedFileMemberProvider<JetBrains.ReSharper.Psi.Css.CssLanguage> { }
    [JetBrains.ReSharper.Psi.ShellFeaturePartAttribute()]
    public class CssGotoSymbolProvider : JetBrains.ReSharper.Feature.Services.Goto.GotoProviders.CachedGotoSymbolBase<JetBrains.ReSharper.Psi.Web.Symbols.IWebSymbolsCache>, JetBrains.ReSharper.Feature.Services.Goto.IApplicableGotoProvider, JetBrains.ReSharper.Feature.Services.Goto.IGotoEverythingProvider, JetBrains.ReSharper.Feature.Services.Goto.IGotoSymbolProvider, JetBrains.ReSharper.Feature.Services.Goto.IOccurenceNavigationProvider
    {
        public System.Func<int, int> ItemsPriorityFunc { get; }
        protected override JetBrains.ReSharper.Psi.Web.Symbols.IWebSymbolsCache GetCache(JetBrains.ReSharper.Feature.Services.Goto.INavigationScope scope, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Feature.Services.Goto.GotoContext gotoContext) { }
        protected override System.Collections.Generic.IEnumerable<string> GetNames(JetBrains.ReSharper.Psi.Web.Symbols.IWebSymbolsCache cache, JetBrains.ReSharper.Feature.Services.Goto.INavigationScope scope) { }
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.Search.IOccurence> GetOccurencesByMatchingInfo(JetBrains.ReSharper.Feature.Services.Goto.MatchingInfo navigationInfo, JetBrains.ReSharper.Feature.Services.Goto.INavigationScope scope, JetBrains.ReSharper.Feature.Services.Goto.GotoContext gotoContext, JetBrains.Application.CheckForInterrupt checkForInterrupt) { }
        public override bool IsApplicable(JetBrains.ReSharper.Feature.Services.Goto.INavigationScope scope, JetBrains.ReSharper.Feature.Services.Goto.GotoContext gotoContext, JetBrains.Text.IdentifierMatcher matcher) { }
    }
    [JetBrains.ReSharper.Psi.ShellFeaturePartAttribute()]
    public class CssOccurencePresenter : JetBrains.ReSharper.Feature.Services.Web.Navigation.WebSymbolOccurencePresenter
    {
        public override bool IsApplicable(JetBrains.ReSharper.Feature.Services.Search.IOccurence occurence) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.Css.ParameterInfo
{
    
    public class CssDefinitionCandidate : JetBrains.ReSharper.Feature.Services.ParameterInfo.ICandidate
    {
        public CssDefinitionCandidate(JetBrains.ReSharper.Psi.Css.Definitions.ICssDefinition definition, JetBrains.ReSharper.Psi.Css.Definitions.ICssValueDefinition valueDefinition, JetBrains.ReSharper.Feature.Services.Css.ParameterInfo.CssValueDefinitionPrinterWithRanges printer) { }
        public JetBrains.ReSharper.Psi.Css.Definitions.ICssDefinition Definition { get; }
        public bool IsFilteredOut { get; set; }
        public bool IsObsolete { get; }
        public JetBrains.UI.RichText.RichTextBlock ObsoleteDescription { get; }
        public System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<JetBrains.Util.TextRange, JetBrains.ReSharper.Psi.Css.Definitions.ICssValueDefinition>> Parameters { get; }
        public int PositionalParameterCount { get; }
        public JetBrains.ReSharper.Psi.Css.Definitions.ICssValueDefinition ValueDefinition { get; }
        public JetBrains.UI.RichText.RichTextBlock GetDescription() { }
        public void GetParametersInfo(out string paramNames, out JetBrains.UI.RichText.RichTextBlock paramDescriptions, out bool isParamsArray) { }
        public JetBrains.UI.RichText.RichText GetSignature(string[] namedArguments, out JetBrains.Util.TextRange parameterRanges, out int mapToOriginalOrder, out JetBrains.ReSharper.Feature.Services.ParameterInfo.ExtensionMethodInfo extensionMethodInfo) { }
        public bool Matches(JetBrains.ReSharper.Psi.IDeclaredElement signature) { }
    }
    [JetBrains.ReSharper.Feature.Services.ParameterInfo.ParameterInfoContextFactoryAttribute(typeof(JetBrains.ReSharper.Psi.Css.CssLanguage))]
    public class CssInvocationParameterInfoContextFactory : JetBrains.ReSharper.Feature.Services.Css.ParameterInfo.CssParameterInfoContextFactoryBase<JetBrains.ReSharper.Psi.Css.Tree.ICssInvocationExpression>
    {
        public override System.Collections.Generic.IEnumerable<char> ImportantChars { get; }
        public override JetBrains.ReSharper.Psi.PsiLanguageType Language { get; }
        public override JetBrains.ReSharper.Feature.Services.ParameterInfo.IParameterInfoContext CreateContext(JetBrains.ProjectModel.ISolution solution, JetBrains.DocumentModel.IDocument document, int caretOffset, int expectedLParenthOffset, char invocationChar, JetBrains.Application.Settings.IContextBoundSettingsStore contextBoundSettingsStore) { }
        protected override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Css.Tree.ICssTreeNode> GetNodes(JetBrains.ReSharper.Psi.Css.Tree.ICssInvocationExpression expression) { }
        public override bool ShouldPopup(JetBrains.DocumentModel.IDocument document, int caretOffset, char c, JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Settings.IContextBoundSettingsStore contextBoundSettingsStore) { }
    }
    public class CssInvocationPrinterWithRanges : JetBrains.ReSharper.Feature.Services.Css.ParameterInfo.CssValueDefinitionPrinterWithRanges
    {
        protected override System.Text.StringBuilder CrateContext() { }
        public override string Print(JetBrains.ReSharper.Psi.Css.Definitions.ICssValueDefinition definition) { }
    }
    [JetBrains.ReSharper.Feature.Services.ParameterInfo.ParameterInfoContextFactoryAttribute(typeof(JetBrains.ReSharper.Psi.Css.CssLanguage))]
    public class CssMediaFeatureParameterInfoContextFactory : JetBrains.ReSharper.Feature.Services.Css.ParameterInfo.CssParameterInfoContextFactoryBase<JetBrains.ReSharper.Psi.Css.Tree.IMediaFeature>
    {
        public override System.Collections.Generic.IEnumerable<char> ImportantChars { get; }
        public override JetBrains.ReSharper.Psi.PsiLanguageType Language { get; }
        public override JetBrains.ReSharper.Feature.Services.ParameterInfo.IParameterInfoContext CreateContext(JetBrains.ProjectModel.ISolution solution, JetBrains.DocumentModel.IDocument document, int caretOffset, int expectedLParenthOffset, char invocationChar, JetBrains.Application.Settings.IContextBoundSettingsStore contextBoundSettingsStore) { }
        protected override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Css.Tree.ICssTreeNode> GetNodes(JetBrains.ReSharper.Psi.Css.Tree.IMediaFeature expression) { }
        public override bool ShouldPopup(JetBrains.DocumentModel.IDocument document, int caretOffset, char c, JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Settings.IContextBoundSettingsStore contextBoundSettingsStore) { }
    }
    public class CssParameterInfoContext : JetBrains.ReSharper.Feature.Services.ParameterInfo.IParameterInfoContext
    {
        public CssParameterInfoContext(int argument, JetBrains.Util.TextRange range, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Feature.Services.ParameterInfo.ICandidate candidate) { }
        public int Argument { get; }
        public JetBrains.ReSharper.Feature.Services.ParameterInfo.ICandidate[] Candidates { get; }
        public JetBrains.ReSharper.Feature.Services.ParameterInfo.ICandidate DefaultCandidate { get; }
        public string[] NamedArguments { get; set; }
        public System.Type ParameterListNodeType { get; }
        public System.Collections.Generic.ICollection<System.Type> ParameterNodeTypes { get; }
        public JetBrains.Util.TextRange Range { get; }
    }
    public abstract class CssParameterInfoContextFactoryBase<T> : JetBrains.ReSharper.Feature.Services.ParameterInfo.IParameterInfoContextFactory
        where T :  class, JetBrains.ReSharper.Psi.Css.Tree.ICssTreeNode
    {
        public abstract System.Collections.Generic.IEnumerable<char> ImportantChars { get; }
        public abstract JetBrains.ReSharper.Psi.PsiLanguageType Language { get; }
        public abstract JetBrains.ReSharper.Feature.Services.ParameterInfo.IParameterInfoContext CreateContext(JetBrains.ProjectModel.ISolution solution, JetBrains.DocumentModel.IDocument document, int caretOffset, int expectedLParenthOffset, char invocationChar, JetBrains.Application.Settings.IContextBoundSettingsStore contextBoundSettingsStore);
        [JetBrains.Annotations.NotNullAttribute()]
        protected static JetBrains.ReSharper.Psi.Css.Definitions.ICssValueDefinition FindDefinitionUnderCursor(JetBrains.ReSharper.Psi.TreeOffset caretOffset, [JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.LinkedList<JetBrains.ReSharper.Psi.Css.Tree.ICssTreeNode> nodes, JetBrains.ReSharper.Psi.Css.Definitions.ICssValueDefinition definition, System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<JetBrains.Util.TextRange, JetBrains.ReSharper.Psi.Css.Definitions.ICssValueDefinition>> definitions, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Psi.Css.CssLanguageVersion cssVersion) { }
        protected static int GetArgumentIndex([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Feature.Services.Css.ParameterInfo.CssDefinitionCandidate candidate, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Css.Definitions.ICssValueDefinition cssValueDefinition) { }
        [JetBrains.Annotations.NotNullAttribute()]
        protected abstract System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Css.Tree.ICssTreeNode> GetNodes([JetBrains.Annotations.NotNullAttribute()] T expression);
        public bool IsIntellisenseEnabled(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Settings.IContextBoundSettingsStore contextBoundSettingsStore) { }
        public abstract bool ShouldPopup(JetBrains.DocumentModel.IDocument document, int caretOffset, char c, JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Settings.IContextBoundSettingsStore contextBoundSettingsStore);
    }
    [JetBrains.ReSharper.Feature.Services.ParameterInfo.ParameterInfoContextFactoryAttribute(typeof(JetBrains.ReSharper.Psi.Css.CssLanguage))]
    public class CssPropertyValueParameterInfoContextFactory : JetBrains.ReSharper.Feature.Services.Css.ParameterInfo.CssParameterInfoContextFactoryBase<JetBrains.ReSharper.Psi.Css.Tree.ICssProperty>
    {
        public override System.Collections.Generic.IEnumerable<char> ImportantChars { get; }
        public override JetBrains.ReSharper.Psi.PsiLanguageType Language { get; }
        public override JetBrains.ReSharper.Feature.Services.ParameterInfo.IParameterInfoContext CreateContext(JetBrains.ProjectModel.ISolution solution, JetBrains.DocumentModel.IDocument document, int caretOffset, int expectedLParenthOffset, char invocationChar, JetBrains.Application.Settings.IContextBoundSettingsStore contextBoundSettingsStore) { }
        protected override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Css.Tree.ICssTreeNode> GetNodes(JetBrains.ReSharper.Psi.Css.Tree.ICssProperty expression) { }
        public override bool ShouldPopup(JetBrains.DocumentModel.IDocument document, int caretOffset, char c, JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Settings.IContextBoundSettingsStore contextBoundSettingsStore) { }
    }
    [JetBrains.ReSharper.Feature.Services.ParameterInfo.ParameterInfoContextFactoryAttribute(typeof(JetBrains.ReSharper.Psi.Css.CssLanguage))]
    public class CssPseudoFunctionParameterInfoContextFactory : JetBrains.ReSharper.Feature.Services.Css.ParameterInfo.CssParameterInfoContextFactoryBase<JetBrains.ReSharper.Psi.Css.Tree.IPseudoFunctionSelector>
    {
        public override System.Collections.Generic.IEnumerable<char> ImportantChars { get; }
        public override JetBrains.ReSharper.Psi.PsiLanguageType Language { get; }
        public override JetBrains.ReSharper.Feature.Services.ParameterInfo.IParameterInfoContext CreateContext(JetBrains.ProjectModel.ISolution solution, JetBrains.DocumentModel.IDocument document, int caretOffset, int expectedLParenthOffset, char invocationChar, JetBrains.Application.Settings.IContextBoundSettingsStore contextBoundSettingsStore) { }
        protected override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Css.Tree.ICssTreeNode> GetNodes(JetBrains.ReSharper.Psi.Css.Tree.IPseudoFunctionSelector expression) { }
        public override bool ShouldPopup(JetBrains.DocumentModel.IDocument document, int caretOffset, char c, JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Settings.IContextBoundSettingsStore contextBoundSettingsStore) { }
    }
    public class CssValueDefinitionPrinterWithRanges : JetBrains.ReSharper.Psi.Css.Definitions.CssValueDefinitionPrinter
    {
        public CssValueDefinitionPrinterWithRanges() { }
        public System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<JetBrains.Util.TextRange, JetBrains.ReSharper.Psi.Css.Definitions.ICssValueDefinition>> Parameters { get; }
        public void AddDefinition(JetBrains.Util.TextRange textRange, JetBrains.ReSharper.Psi.Css.Definitions.ICssValueDefinition valueDefinition) { }
        public override string Print(JetBrains.ReSharper.Psi.Css.Definitions.ICssValueDefinition definition) { }
        public override void VisitCssValueAngleDefinition(JetBrains.ReSharper.Psi.Css.Definitions.ICssValueAngleDefinition angleDefinition, System.Text.StringBuilder builder) { }
        public override void VisitCssValueAnyDefinition(JetBrains.ReSharper.Psi.Css.Definitions.ICssValueAnyDefinition anyDefinition, System.Text.StringBuilder builder) { }
        public override void VisitCssValueColorDefinition(JetBrains.ReSharper.Psi.Css.Definitions.ICssValueColorDefinition colorDefinition, System.Text.StringBuilder builder) { }
        public override void VisitCssValueEmptyDefinition(JetBrains.ReSharper.Psi.Css.Definitions.ICssValueEmptyDefinition emptyDefinition, System.Text.StringBuilder builder) { }
        public override void VisitCssValueExpressionDefinition(JetBrains.ReSharper.Psi.Css.Definitions.ICssValueExpressionDefinition expressionDefinition, System.Text.StringBuilder builder) { }
        public override void VisitCssValueFrequencyDefinition(JetBrains.ReSharper.Psi.Css.DeclaredElements.ICssValueFrequencyDefinition frequencyDefinition, System.Text.StringBuilder builder) { }
        public override void VisitCssValueGroupDefinition(JetBrains.ReSharper.Psi.Css.Definitions.ICssValueGroupDefinition groupDefinition, System.Text.StringBuilder builder) { }
        public override void VisitCssValueInlineDefinition(JetBrains.ReSharper.Psi.Css.Definitions.ICssValueInlineDefinition valueInlineDefinition, System.Text.StringBuilder builder) { }
        public override void VisitCssValueIntegerDefinition(JetBrains.ReSharper.Psi.Css.Definitions.ICssValueIntegerDefinition integerDefinition, System.Text.StringBuilder builder) { }
        public override void VisitCssValueInvokeDefinition(JetBrains.ReSharper.Psi.Css.Definitions.ICssValueInvokeDefinition invokeDefinition, System.Text.StringBuilder builder) { }
        public override void VisitCssValueJavaScriptDefinition(JetBrains.ReSharper.Psi.Css.Definitions.ICssValueJavaScriptDefinition javaScriptDefinition, System.Text.StringBuilder builder) { }
        public override void VisitCssValueLengthDefinition(JetBrains.ReSharper.Psi.Css.Definitions.ICssValueLengthDefinition lengthDefinition, System.Text.StringBuilder builder) { }
        public override void VisitCssValueNameDefinition(JetBrains.ReSharper.Psi.Css.Definitions.ICssValueNameDefinition nameDefinition, System.Text.StringBuilder builder) { }
        public override void VisitCssValueNullDefinition(JetBrains.ReSharper.Psi.Css.Definitions.ICssValueNullDefinition nullDefinition, System.Text.StringBuilder builder) { }
        public override void VisitCssValueNumberDefinition(JetBrains.ReSharper.Psi.Css.Definitions.ICssValueNumberDefinition numberDefinition, System.Text.StringBuilder builder) { }
        public override void VisitCssValuePercentageDefinition(JetBrains.ReSharper.Psi.Css.Definitions.ICssValuePercentageDefinition percentageDefinition, System.Text.StringBuilder builder) { }
        public override void VisitCssValuePositionDefinition(JetBrains.ReSharper.Psi.Css.Definitions.ICssValuePositionDefinition positionDefinition, System.Text.StringBuilder builder) { }
        public override void VisitCssValuePropertyReferenceDefinition(JetBrains.ReSharper.Psi.Css.Definitions.ICssValuePropertyReferenceDefinition propertyReferenceDefinition, System.Text.StringBuilder builder) { }
        public override void VisitCssValueResolutionDefinition(JetBrains.ReSharper.Psi.Css.Definitions.ICssValueResolutionDefinition resolutionDefinition, System.Text.StringBuilder builder) { }
        public override void VisitCssValueSelectorDefinition(JetBrains.ReSharper.Psi.Css.Definitions.ICssValueSelectorDefinition selectorDefinition, System.Text.StringBuilder builder) { }
        public override void VisitCssValueStringDefinition(JetBrains.ReSharper.Psi.Css.Definitions.ICssValueStringDefinition stringDefinition, System.Text.StringBuilder builder) { }
        public override void VisitCssValueTextDefinition(JetBrains.ReSharper.Psi.Css.Definitions.ICssValueTextDefinition textDefinition, System.Text.StringBuilder builder) { }
        public override void VisitCssValueTimeDefinition(JetBrains.ReSharper.Psi.Css.Definitions.ICssValueTimeDefinition timeDefinition, System.Text.StringBuilder builder) { }
        public override void VisitCssValueUrangeDefinition(JetBrains.ReSharper.Psi.Css.Definitions.ICssValueUrangeDefinition urangeDefinition, System.Text.StringBuilder builder) { }
        public override void VisitCssValueUriDefinition(JetBrains.ReSharper.Psi.Css.Definitions.ICssValueUriDefinition uriDefinition, System.Text.StringBuilder builder) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.Css.QuickDoc
{
    
    [JetBrains.ReSharper.Feature.Services.Descriptions.DeclaredElementDescriptionProviderAttribute()]
    public class CssDeclaredElementDescriptionProvider : JetBrains.ReSharper.Feature.Services.Descriptions.IDeclaredElementDescriptionProvider
    {
        public int Priority { get; }
        public JetBrains.UI.RichText.RichTextBlock GetElementDescription(JetBrains.ReSharper.Psi.IDeclaredElement element, JetBrains.ReSharper.Feature.Services.Descriptions.DeclaredElementDescriptionStyle style, JetBrains.ReSharper.Psi.PsiLanguageType language, JetBrains.ReSharper.Psi.Modules.IPsiModule module) { }
        public System.Nullable<bool> IsElementObsolete(JetBrains.ReSharper.Psi.IDeclaredElement element, out JetBrains.UI.RichText.RichTextBlock obsoleteDescription, JetBrains.ReSharper.Feature.Services.Descriptions.DeclaredElementDescriptionStyle style) { }
    }
    public class QuickDocCssDefinitionPresenter : JetBrains.ReSharper.Feature.Services.QuickDoc.IQuickDocPresenter
    {
        public QuickDocCssDefinitionPresenter(JetBrains.ReSharper.Feature.Services.Css.QuickDoc.QuickDocCssDefinitionProvider quickDocCssDefinitionProvider, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Css.DeclaredElements.ICssDefinitionDeclaredElement element, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Modules.IPsiModule module, JetBrains.ReSharper.Psi.Css.CssLanguageVersion version) { }
        public string GetHtml(JetBrains.ReSharper.Psi.PsiLanguageType presentationLanguage) { }
        public string GetId() { }
        public void OpenInEditor() { }
        public void ReadMore() { }
        public JetBrains.ReSharper.Feature.Services.QuickDoc.IQuickDocPresenter Resolve(string id) { }
    }
    [JetBrains.ReSharper.Feature.Services.QuickDoc.QuickDocProviderAttribute(0)]
    public class QuickDocCssDefinitionProvider : JetBrains.ReSharper.Feature.Services.QuickDoc.IQuickDocProvider
    {
        public QuickDocCssDefinitionProvider(JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Psi.Files.IPsiFiles psiFiles, JetBrains.DocumentManagers.DocumentManager documentManager, JetBrains.ReSharper.Psi.Css.CssLanguageVersionProvider cssLanguageVersionProvider) { }
        public bool CanNavigate(JetBrains.Application.DataContext.IDataContext context) { }
        public void Resolve(JetBrains.Application.DataContext.IDataContext context, System.Action<JetBrains.ReSharper.Feature.Services.QuickDoc.IQuickDocPresenter, JetBrains.ReSharper.Psi.PsiLanguageType> resolved) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Feature.Services.QuickDoc.IQuickDocPresenter Resolve(string id, JetBrains.ReSharper.Psi.Css.CssLanguageVersion version, JetBrains.ReSharper.Psi.Modules.IPsiModule module) { }
    }
    public class QuickDocCssValueDefinitionPrinter : JetBrains.ReSharper.Psi.Css.Definitions.CssValueDefinitionPrinter
    {
        protected override System.Text.StringBuilder Append(System.Text.StringBuilder builder, string value) { }
        protected override System.Text.StringBuilder AppendFormat(System.Text.StringBuilder builder, string format, params string[] args) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public new static string Print(JetBrains.ReSharper.Psi.Css.Definitions.ICssValueDefinition definition) { }
        public override void VisitCssValueInlineDefinition(JetBrains.ReSharper.Psi.Css.Definitions.ICssValueInlineDefinition valueInlineDefinition, System.Text.StringBuilder builder) { }
        public override void VisitCssValueInvokeDefinition(JetBrains.ReSharper.Psi.Css.Definitions.ICssValueInvokeDefinition invokeDefinition, System.Text.StringBuilder builder) { }
        public override void VisitCssValuePropertyReferenceDefinition(JetBrains.ReSharper.Psi.Css.Definitions.ICssValuePropertyReferenceDefinition propertyReferenceDefinition, System.Text.StringBuilder builder) { }
    }
    public class static QuickDocUtil
    {
        public static string ProcessCRef(string cref, string linkText, bool addHyperlink, JetBrains.ReSharper.Psi.Modules.IPsiModule module, JetBrains.ReSharper.Psi.PsiLanguageType languageType, JetBrains.ReSharper.Psi.Css.CssLanguageVersion version) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Psi.Css.DeclaredElements.ICssDefinitionDeclaredElement ResolveDeclaredElement(string id, JetBrains.ReSharper.Psi.Css.CssLanguageVersion version, JetBrains.ReSharper.Psi.Modules.IPsiModule module) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.Css.RearrangeCode
{
    
    public class RearrangeableCssPropertyStatement : JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableElementSwap<JetBrains.ReSharper.Psi.Css.Tree.ICssPropertyStatement>
    {
        protected override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Css.Tree.ICssPropertyStatement> GetSiblings() { }
        [JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableElementTypeAttribute()]
        public class Type : JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableSingleElementBase<JetBrains.ReSharper.Psi.Css.Tree.ICssPropertyStatement>.TypeBase
        {
            protected override JetBrains.ReSharper.Feature.Services.RearrangeCode.IRearrangeable CreateElement(JetBrains.ReSharper.Psi.Css.Tree.ICssPropertyStatement element) { }
        }
    }
    public class RearrangeableCssPropertyValueExpression : JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableElementSwap<JetBrains.ReSharper.Psi.Css.Tree.ICssPropertyValueExpression>
    {
        protected override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Css.Tree.ICssPropertyValueExpression> GetSiblings() { }
        [JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableElementTypeAttribute()]
        public class Type : JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableSingleElementBase<JetBrains.ReSharper.Psi.Css.Tree.ICssPropertyValueExpression>.TypeBase
        {
            protected override JetBrains.ReSharper.Feature.Services.RearrangeCode.IRearrangeable CreateElement(JetBrains.ReSharper.Psi.Css.Tree.ICssPropertyValueExpression element) { }
        }
    }
    public class RearrangeableRuleset : JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableElementSwap<JetBrains.ReSharper.Psi.Css.Tree.IRuleset>
    {
        protected override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Css.Tree.IRuleset> GetSiblings() { }
        [JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableElementTypeAttribute()]
        public class Type : JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableSingleElementBase<JetBrains.ReSharper.Psi.Css.Tree.IRuleset>.TypeBase
        {
            protected override JetBrains.ReSharper.Feature.Services.RearrangeCode.IRearrangeable CreateElement(JetBrains.ReSharper.Psi.Css.Tree.IRuleset element) { }
        }
    }
    public class RearrangeableRulesetDeclaration : JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableElementSwap<JetBrains.ReSharper.Psi.Css.Tree.IRulesetDeclaration>
    {
        protected override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Css.Tree.IRulesetDeclaration> GetSiblings() { }
        [JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableElementTypeAttribute()]
        public class Type : JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableSingleElementBase<JetBrains.ReSharper.Psi.Css.Tree.IRulesetDeclaration>.TypeBase
        {
            protected override JetBrains.ReSharper.Feature.Services.RearrangeCode.IRearrangeable CreateElement(JetBrains.ReSharper.Psi.Css.Tree.IRulesetDeclaration element) { }
        }
    }
}
namespace JetBrains.ReSharper.Feature.Services.Css.References
{
    
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.Css.CssLanguage))]
    public class CssPathBinder : JetBrains.ReSharper.Psi.Web.References.IHtmlPathBinder
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
    public class CssStringFileReference : JetBrains.ReSharper.Psi.Html.Impl.References.HtmlFileReference<JetBrains.ReSharper.Psi.Css.Tree.ICssStringLiteralExpression, JetBrains.ReSharper.Psi.Tree.ITokenNode>
    {
        public CssStringFileReference(JetBrains.ReSharper.Psi.Css.Tree.ICssStringLiteralExpression owner, JetBrains.ReSharper.Psi.Resolve.IQualifier qualifier, JetBrains.ReSharper.Psi.Tree.ITokenNode token, JetBrains.ReSharper.Psi.TreeTextRange rangeWithin, JetBrains.ProjectModel.ProjectFileType expectedFileType, bool noCircular) { }
        public override string GetName() { }
    }
    public class CssStringFileReferenceFactory : JetBrains.ReSharper.Psi.Resolve.IReferenceFactory
    {
        public JetBrains.ReSharper.Psi.Resolve.IReference[] GetReferences(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.Resolve.IReference[] oldReferences) { }
        public bool HasReference(JetBrains.ReSharper.Psi.Tree.ITreeNode element, System.Collections.Generic.ICollection<string> names) { }
    }
    public class CssStringFolderReference : JetBrains.ReSharper.Psi.Html.Impl.References.HtmlFolderReference<JetBrains.ReSharper.Psi.Css.Tree.ICssStringLiteralExpression, JetBrains.ReSharper.Psi.Tree.ITokenNode>
    {
        public CssStringFolderReference(JetBrains.ReSharper.Psi.Css.Tree.ICssStringLiteralExpression owner, JetBrains.ReSharper.Psi.Resolve.IQualifier qualifier, JetBrains.ReSharper.Psi.Tree.ITokenNode token, JetBrains.ReSharper.Psi.TreeTextRange rangeWithin) { }
        public override string GetName() { }
    }
    public class CssUriFileReference : JetBrains.ReSharper.Psi.Html.Impl.References.HtmlFileReference<JetBrains.ReSharper.Psi.Css.Tree.ICssLiteralExpression, JetBrains.ReSharper.Psi.Tree.ITokenNode>
    {
        public CssUriFileReference(JetBrains.ReSharper.Psi.Css.Tree.ICssLiteralExpression owner, JetBrains.ReSharper.Psi.Resolve.IQualifier qualifier, JetBrains.ReSharper.Psi.Tree.ITokenNode token, JetBrains.ReSharper.Psi.TreeTextRange rangeWithin) { }
        public CssUriFileReference(JetBrains.ReSharper.Psi.Css.Tree.ICssLiteralExpression owner, JetBrains.ReSharper.Psi.Resolve.IQualifier qualifier, JetBrains.ReSharper.Psi.Tree.ITokenNode token, JetBrains.ReSharper.Psi.TreeTextRange rangeWithin, JetBrains.ProjectModel.ProjectFileType expectedFileType, [JetBrains.Annotations.CanBeNullAttribute()] System.Collections.Generic.ICollection<string> expectedExtensions, bool noCircular, bool allowEmptyName = False) { }
        public override string GetName() { }
    }
    public class CssUriFileReferenceFactory : JetBrains.ReSharper.Psi.Resolve.IReferenceFactory
    {
        public JetBrains.ReSharper.Psi.Resolve.IReference[] GetReferences(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.Resolve.IReference[] oldReferences) { }
        public bool HasReference(JetBrains.ReSharper.Psi.Tree.ITreeNode element, System.Collections.Generic.ICollection<string> names) { }
    }
    public class CssUriFolderReference : JetBrains.ReSharper.Psi.Html.Impl.References.HtmlFolderReference<JetBrains.ReSharper.Psi.Css.Tree.ICssLiteralExpression, JetBrains.ReSharper.Psi.Tree.ITokenNode>
    {
        public CssUriFolderReference(JetBrains.ReSharper.Psi.Css.Tree.ICssLiteralExpression owner, JetBrains.ReSharper.Psi.Resolve.IQualifier qualifier, JetBrains.ReSharper.Psi.Tree.ITokenNode token, JetBrains.ReSharper.Psi.TreeTextRange rangeWithin) { }
        public override string GetName() { }
    }
    public class static CssUriHelper
    {
        public static bool IsSpecialUri(string url) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.Css.SelectEmbracingConstruct
{
    
    public class CssTreeRangeSelection : JetBrains.ReSharper.Feature.Services.SelectEmbracingConstruct.TreeRangeSelection<JetBrains.ReSharper.Psi.Css.Tree.ICssFile>
    {
        public CssTreeRangeSelection(JetBrains.ReSharper.Psi.Css.Tree.ICssFile fileNode, JetBrains.ReSharper.Psi.Tree.ITreeNode first, JetBrains.ReSharper.Psi.Tree.ITreeNode last) { }
        public override JetBrains.ReSharper.Feature.Services.SelectEmbracingConstruct.ISelectedRange Parent { get; }
    }
}
namespace JetBrains.ReSharper.Feature.Services.Css.TodoItems
{
    
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.Css.CssLanguage))]
    public class CssTodoContentsProvider : JetBrains.ReSharper.Feature.Services.TodoItems.DefaultTodoContentsProvider
    {
        public override System.Nullable<JetBrains.Util.TextRange> GetTokenContentsRange(string documentText, JetBrains.Util.TextRange tokenRange, JetBrains.ReSharper.Psi.Parsing.TokenNodeType tokenType) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.Css.TypingAssist
{
    
    public class CssBracketMatcher : JetBrains.ReSharper.Feature.Services.TypingAssist.BracketMatcher
    {
        public CssBracketMatcher() { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public sealed class CssTypingAssist : JetBrains.ReSharper.Feature.Services.Css.TypingAssist.CssTypingAssistBase
    {
        public CssTypingAssist(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ProjectModel.ISolution solution, JetBrains.Application.CommandProcessing.ICommandProcessor commandProcessor, JetBrains.ReSharper.Psi.Services.CachingLexerService cachingLexerService, JetBrains.Application.Settings.ISettingsStore settingsStore, JetBrains.ReSharper.Feature.Services.TypingAssist.ITypingAssistManager typingAssistManager, JetBrains.ReSharper.Psi.IPsiServices psiServices) { }
        protected override bool IsSupported(JetBrains.TextControl.ITextControl textControl) { }
    }
    public abstract class CssTypingAssistBase : JetBrains.ReSharper.Feature.Services.TypingAssist.TypingAssistLanguageBase<JetBrains.ReSharper.Psi.Css.CssLanguage, JetBrains.ReSharper.Psi.Css.CodeStyle.ICssCodeFormatter>, JetBrains.ReSharper.Feature.Services.TypingAssist.ITypingHandler
    {
        protected CssTypingAssistBase(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ProjectModel.ISolution solution, JetBrains.Application.CommandProcessing.ICommandProcessor commandProcessor, JetBrains.Application.Settings.ISettingsStore settingsStore, JetBrains.ReSharper.Psi.Services.CachingLexerService cachingLexerService, JetBrains.ReSharper.Feature.Services.TypingAssist.ITypingAssistManager typingAssistManager, JetBrains.ReSharper.Psi.IPsiServices psiServices) { }
        protected virtual int AdjustLineIndent(JetBrains.TextControl.ITextControl textControl, int originalOffset, int currentOffset) { }
        protected virtual void DoFormatStatementOnSemicolon(JetBrains.TextControl.ITextControl textControl) { }
        protected void DoSmartIndentOnEnter(JetBrains.TextControl.ITextControl textControl) { }
        protected bool HandleDelPressed(JetBrains.ReSharper.Feature.Services.TypingAssist.IActionContext context) { }
        protected virtual bool IsStopperTokenForStringLiteral([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Parsing.TokenNodeType tokenType) { }
        public virtual bool QuickCheckAvailability(JetBrains.TextControl.ITextControl textControl, JetBrains.ReSharper.Psi.IPsiSourceFile projectFile) { }
        public bool ReformatForSmartEnter(string dummyText, JetBrains.TextControl.ITextControl textControl, JetBrains.ReSharper.Psi.Tree.IFile file, JetBrains.ReSharper.Psi.TreeTextRange reparseTreeOffset, JetBrains.ReSharper.Psi.TreeOffset lBraceTreePos, JetBrains.ReSharper.Psi.TreeOffset rBraceTreePos) { }
    }
}