[assembly: JetBrains.ActionManagement.ActionsXmlAttribute("JetBrains.ReSharper.Features.StructuralSearch.resources.Actions.xml")]
[assembly: JetBrains.ReSharper.Daemon.RegisterStaticHighlightingsGroupAttribute("StructuralSearch", "Structural Search Highlightings", true)]
[assembly: JetBrains.UI.Icons.CompiledIcons.CompiledIconsPackAttribute(IconNames=new string[] {
        "EditPattern",
        "Pattern",
        "EditPlaceholder",
        "SeveritySuggestion",
        "SeverityWarning",
        "RemovePattern",
        "Type",
        "SeverityNone",
        "Identifier",
        "SeverityHint",
        "Import",
        "SeverityError",
        "Statement",
        "RemovePlaceholder",
        "AddPattern",
        "AddPlaceholder",
        "PatternsCatalogue",
        "PerformStructuralSearch",
        "StructuralSearchPlaceholder",
        "Expression",
        "Argument"}, IconPackResourceIdentification="JetBrains.ReSharper.Features.StructuralSearch;component/resources/StructuralSearc" +
    "hIcons/ThemedIcons.StructuralSearch.Generated.Xaml")]
[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]
[assembly: System.Windows.Markup.XmlnsDefinitionAttribute("urn:shemas-jetbrains-com:ui-application-icons-structural-search", "JetBrains.ReSharper.Features.StructuralSearch.Resources")]

namespace JetBrains.ReSharper.Features.StructuralSearch
{
    
    [JetBrains.Application.ShellComponentAttribute()]
    public class CSharpPredefinedPatterns : JetBrains.ReSharper.Features.StructuralSearch.IPredefinedCustomPatternsSource
    {
        public CSharpPredefinedPatterns(JetBrains.ReSharper.Psi.ILanguageManager languageManager) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Features.StructuralSearch.IPredefinedPattern> GetPatterns() { }
    }
    public class CSharpPredefinedPatternsStageProcess : JetBrains.ReSharper.Features.StructuralSearch.CSharpStructuralSearchDaemonStageProcess
    {
        public CSharpPredefinedPatternsStageProcess(JetBrains.ReSharper.Daemon.IDaemonProcess process, JetBrains.Application.Settings.IContextBoundSettingsStore settingsStore, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<JetBrains.ReSharper.Features.StructuralSearch.ICustomPattern, JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralMatcher>> matchers, JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpFile file) { }
        protected override JetBrains.ReSharper.Daemon.IHighlighting CreateHighlighting(JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralMatchResult result, System.Collections.Generic.KeyValuePair<JetBrains.ReSharper.Features.StructuralSearch.ICustomPattern, JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralMatcher> pair) { }
    }
    [JetBrains.ReSharper.Daemon.DaemonStageAttribute(StagesBefore=new System.Type[] {
            typeof(JetBrains.ReSharper.Daemon.LanguageSpecificDaemonStage)})]
    public class CSharpStructuralSearchDaemonStage : JetBrains.ReSharper.Daemon.CSharp.Stages.CSharpDaemonStageBase
    {
        public CSharpStructuralSearchDaemonStage(JetBrains.ReSharper.Features.StructuralSearch.CustomPatternMatcherManager customPatternMatcherManager) { }
        protected override JetBrains.ReSharper.Daemon.IDaemonStageProcess CreateProcess(JetBrains.ReSharper.Daemon.IDaemonProcess process, JetBrains.Application.Settings.IContextBoundSettingsStore settings, JetBrains.ReSharper.Daemon.DaemonProcessKind processKind, JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpFile file) { }
    }
    public class CSharpStructuralSearchDaemonStageProcess : JetBrains.ReSharper.Features.StructuralSearch.StructuralSearchDaemonStageProcessBase
    {
        public CSharpStructuralSearchDaemonStageProcess(JetBrains.ReSharper.Daemon.IDaemonProcess process, JetBrains.Application.Settings.IContextBoundSettingsStore settingsStore, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<JetBrains.ReSharper.Features.StructuralSearch.ICustomPattern, JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralMatcher>> matchers, JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpFile file) { }
        public override bool InteriorShouldBeProcessed(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.Services.StructuralSearch.IMatchingContext context) { }
        public override void ProcessBeforeInterior(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.Services.StructuralSearch.IMatchingContext context) { }
    }
    public class CustomPattern : JetBrains.ReSharper.Features.StructuralSearch.ICustomPattern
    {
        public CustomPattern() { }
        public bool FormatAfterReplace { get; set; }
        public JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralSearchPattern Pattern { get; set; }
        public JetBrains.ReSharper.Daemon.Severity Severity { get; set; }
        public bool ShortenReferences { get; set; }
        public bool Equals(JetBrains.ReSharper.Features.StructuralSearch.CustomPattern other) { }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class CustomPatternMatcherManager
    {
        public CustomPatternMatcherManager(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ReSharper.Psi.ILanguageManager languageManager) { }
        public System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<JetBrains.ReSharper.Features.StructuralSearch.ICustomPattern, JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralMatcher>> GetMatchersFor(JetBrains.ReSharper.Psi.PsiLanguageType language, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ProjectModel.IProject project) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.KnownLanguage))]
    public class CustomPatternMatchersCachedReader : JetBrains.Application.Settings.Extentions.ICachedSettingsReader<System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<JetBrains.ReSharper.Features.StructuralSearch.ICustomPattern, JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralMatcher>>>
    {
        public CustomPatternMatchersCachedReader(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.Settings.ISettingsStore settingsStore, JetBrains.ReSharper.Psi.KnownLanguage language, JetBrains.ReSharper.Features.StructuralSearch.StructuralSearchMatcherManager matcherManager, JetBrains.ReSharper.Psi.ILanguages languages, JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralSearcherFactory structuralSearcherFactory = null) { }
        public JetBrains.Application.Settings.SettingsKey KeyExposed { get; }
        public System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<JetBrains.ReSharper.Features.StructuralSearch.ICustomPattern, JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralMatcher>> ReadData(JetBrains.Application.Settings.IContextBoundSettingsStore store) { }
    }
    [JetBrains.Application.Settings.SettingsIndexedKeyAttribute(typeof(JetBrains.ReSharper.Features.StructuralSearch.CustomPatternSettings), "Placeholder", typeof(string))]
    public class CustomPatternPlaceholderSettings : JetBrains.ReSharper.Features.StructuralSearch.PlaceholderSettings { }
    [JetBrains.ReSharper.Feature.Services.Bulbs.QuickFixAttribute()]
    public class CustomPatternQuickFix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public CustomPatternQuickFix(JetBrains.ReSharper.Features.StructuralSearch.Highlightings.StructuralSearchPatternHighlightingBase highlighting) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    [JetBrains.Application.Settings.SettingsIndexedKeyAttribute(typeof(JetBrains.ReSharper.Features.StructuralSearch.StructuralSearchSettings), "A search & replace pattern", typeof(JetBrains.Application.Settings.GuidIndex), KeyNameOverride="Pattern")]
    public class CustomPatternSettings : JetBrains.ReSharper.Features.StructuralSearch.StructuralSearchPatternSettings
    {
        [JetBrains.Application.Settings.SettingsEntryAttribute("", "Comment")]
        public string Comment;
        [JetBrains.Application.Settings.SettingsEntryAttribute("", "Replace comment")]
        public string ReplaceComment;
        [JetBrains.Application.Settings.SettingsEntryAttribute(JetBrains.ReSharper.Daemon.Severity.DO_NOT_SHOW, "Highlighting severity")]
        public JetBrains.ReSharper.Daemon.Severity Severity;
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class CustomPatternSettingsChangedHandler
    {
        public CustomPatternSettingsChangedHandler(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ProjectModel.ISolution solution, JetBrains.Threading.IThreading threading, JetBrains.Application.Settings.ISettingsStore settingsStore) { }
    }
    public class CustomPatternSettingsUtil
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Features.StructuralSearch.ICustomPattern ReadCustomPattern(JetBrains.Application.Settings.IContextBoundSettingsStore contextBoundSettingsStore, System.Collections.Generic.Dictionary<JetBrains.Application.Settings.SettingsKey, object> patternKeyIndices, JetBrains.ReSharper.Psi.ILanguages languages, JetBrains.ReSharper.Psi.Services.StructuralSearch.StructuralSearchEngine engine) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Features.StructuralSearch.ICustomPattern ReadCustomPattern(JetBrains.Application.Settings.IContextBoundSettingsStore contextBoundSettingsStore, System.Collections.Generic.Dictionary<JetBrains.Application.Settings.SettingsKey, object> patternKeyIndices, JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralSearcherFactory structuralSearcherFactory) { }
        public static void WriteCustomPattern(JetBrains.Application.Settings.IContextBoundSettingsStore contextBoundSettingsStore, JetBrains.Application.Settings.GuidIndex guid, JetBrains.ReSharper.Features.StructuralSearch.ICustomPattern pattern) { }
    }
    public interface ICustomPattern
    {
        JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralSearchPattern Pattern { get; set; }
        JetBrains.ReSharper.Daemon.Severity Severity { get; set; }
    }
    public interface IPredefinedCustomPatternsSource
    {
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Features.StructuralSearch.IPredefinedPattern> GetPatterns();
    }
    public interface IPredefinedPattern : JetBrains.ReSharper.Features.StructuralSearch.ICustomPattern
    {
        JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralSearchPatternBuilder Builder { get; set; }
        string CompoundItemName { get; }
        string ConfigurableSeverityId { get; }
        string GroupName { get; }
    }
    public class PlaceholderSettings
    {
        [JetBrains.Application.Settings.SettingsIndexedEntryAttribute("Properties")]
        public JetBrains.Application.Settings.Store.IIndexedEntry<string, string> Properties;
        [JetBrains.Application.Settings.SettingsEntryAttribute(null, "Type")]
        public string Type;
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class PredefinedCustomPatternsManager : JetBrains.ReSharper.Daemon.Impl.ICustomConfigurableSeverityItemProvider
    {
        public PredefinedCustomPatternsManager(JetBrains.ReSharper.Features.StructuralSearch.StructuralSearchMatcherManager structuralSearchMatcherManager, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Features.StructuralSearch.IPredefinedCustomPatternsSource> customPatternsSources) { }
        public System.Collections.Generic.IEnumerable<JetBrains.Util.JetTuple<JetBrains.ReSharper.Psi.PsiLanguageType, JetBrains.ReSharper.Daemon.HighlightingSettingsManager.ConfigurableSeverityItem>> ConfigurableSeverityItems { get; }
        public System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<JetBrains.ReSharper.Features.StructuralSearch.ICustomPattern, JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralMatcher>> GetMatchersFor<T>()
            where T : JetBrains.ReSharper.Psi.PsiLanguageType { }
    }
    public class PredefinedPattern : JetBrains.ReSharper.Features.StructuralSearch.CustomPattern, JetBrains.ReSharper.Features.StructuralSearch.ICustomPattern, JetBrains.ReSharper.Features.StructuralSearch.IPredefinedPattern
    {
        public JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralSearchPatternBuilder Builder { get; set; }
        public string CompoundItemName { get; set; }
        public string ConfigurableSeverityId { get; set; }
        public string GroupName { get; set; }
        public bool Equals(JetBrains.ReSharper.Features.StructuralSearch.PredefinedPattern other) { }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
    }
    [JetBrains.ReSharper.Daemon.DaemonStageAttribute(StagesBefore=new System.Type[] {
            typeof(JetBrains.ReSharper.Daemon.LanguageSpecificDaemonStage)})]
    public class PredefinedPatternsStage : JetBrains.ReSharper.Daemon.IDaemonStage
    {
        public PredefinedPatternsStage(JetBrains.ReSharper.Features.StructuralSearch.PredefinedCustomPatternsManager patternsManager) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Daemon.IDaemonStageProcess> CreateProcess(JetBrains.ReSharper.Daemon.IDaemonProcess process, JetBrains.Application.Settings.IContextBoundSettingsStore settings, JetBrains.ReSharper.Daemon.DaemonProcessKind processKind) { }
        public JetBrains.ReSharper.Daemon.ErrorStripeRequest NeedsErrorStripe(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, JetBrains.Application.Settings.IContextBoundSettingsStore settings) { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class RecentSearchesManager
    {
        public RecentSearchesManager(JetBrains.Application.Settings.ISettingsStore settingsStore, JetBrains.ReSharper.Psi.ILanguages languages, JetBrains.ReSharper.Psi.Services.StructuralSearch.StructuralSearchEngine engine) { }
        public JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralSearchPattern RecentSearch { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralSearchPattern> RecentSearches { get; }
        public string RecentSearchScopeName { get; set; }
        public bool ReplaceMode { get; set; }
        public void AddSearch(JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralSearchPattern structuralSearchPattern) { }
    }
    [JetBrains.Application.Settings.SettingsIndexedKeyAttribute(typeof(JetBrains.ReSharper.Features.StructuralSearch.RecentSearchSettings), "Placeholder", typeof(string))]
    public class RecentSearchPlaceholderSettings : JetBrains.ReSharper.Features.StructuralSearch.PlaceholderSettings { }
    [JetBrains.Application.Settings.SettingsIndexedKeyAttribute(typeof(JetBrains.ReSharper.Features.StructuralSearch.StructuralSearchSettings), "Recent search", typeof(string))]
    public class RecentSearchSettings : JetBrains.ReSharper.Features.StructuralSearch.StructuralSearchPatternSettings { }
    public class static SsrPatternSettingsUtil
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralSearchPattern ReadSsrPattern<TPatternSettings, TPlaceholderSettings>(JetBrains.Application.Settings.IContextBoundSettingsStore contextBoundSettingsStore, System.Collections.Generic.Dictionary<JetBrains.Application.Settings.SettingsKey, object> patternKeyIndices, JetBrains.ReSharper.Psi.ILanguages languages, JetBrains.ReSharper.Psi.Services.StructuralSearch.StructuralSearchEngine engine)
            where TPatternSettings : JetBrains.ReSharper.Features.StructuralSearch.StructuralSearchPatternSettings
            where TPlaceholderSettings : JetBrains.ReSharper.Features.StructuralSearch.PlaceholderSettings { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralSearchPattern ReadSsrPattern<TPatternSettings, TPlaceholderSettings>(JetBrains.Application.Settings.IContextBoundSettingsStore contextBoundSettingsStore, System.Collections.Generic.Dictionary<JetBrains.Application.Settings.SettingsKey, object> patternKeyIndices, JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralSearcherFactory structuralSearcherFactory)
            where TPatternSettings : JetBrains.ReSharper.Features.StructuralSearch.StructuralSearchPatternSettings
            where TPlaceholderSettings : JetBrains.ReSharper.Features.StructuralSearch.PlaceholderSettings { }
        public static void WriteSsrPattern<TPatternSettings, TPlaceholderSettings>(JetBrains.Application.Settings.IContextBoundSettingsStore settingsStore, System.Collections.Generic.Dictionary<JetBrains.Application.Settings.SettingsKey, object> keyIndices, JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralSearchPattern structuralSearchPattern)
            where TPatternSettings : JetBrains.ReSharper.Features.StructuralSearch.StructuralSearchPatternSettings
            where TPlaceholderSettings : JetBrains.ReSharper.Features.StructuralSearch.PlaceholderSettings { }
    }
    public class StructuralReplaceSearchResultsBrowserDescriptor : JetBrains.ReSharper.Features.Common.Occurences.OccurenceBrowserDescriptor, System.IDisposable
    {
        public StructuralReplaceSearchResultsBrowserDescriptor(JetBrains.ReSharper.Features.StructuralSearch.Finding.StructuralSearchRequest request) { }
        public override string ContextMenuID { get; }
        public override JetBrains.TreeModels.TreeModel Model { get; }
        public JetBrains.ReSharper.Features.StructuralSearch.Finding.StructuralSearchRequest Request { get; }
        public void Dispose() { }
        public bool Search() { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class StructuralSearchActionManager
    {
        public StructuralSearchActionManager(
                    JetBrains.DataFlow.Lifetime lifetime, 
                    JetBrains.ProjectModel.ISolution solution, 
                    JetBrains.ReSharper.Psi.Services.StructuralSearch.StructuralSearchEngine engine, 
                    JetBrains.ReSharper.Features.StructuralSearch.RecentSearchesManager recentSearchesManager, 
                    JetBrains.Application.IShellLocks locks, 
                    JetBrains.ReSharper.Psi.IPsiServices psiServices, 
                    JetBrains.ReSharper.Psi.PsiProjectFileTypeCoordinator psiProjectFileTypeCoordinator, 
                    JetBrains.Application.IApplicationDescriptor product, 
                    JetBrains.UI.Application.IMainWindow mainwin, 
                    JetBrains.DocumentModel.DocumentSettings documentSettings, 
                    JetBrains.CommonControls.Validation.FormValidators formValidators, 
                    JetBrains.Application.Interop.NativeHook.IWindowsHookManager windowsHookManager, 
                    JetBrains.TextControl.DocumentMarkup.IDocumentMarkupManager documentMarkupManager, 
                    JetBrains.DocumentManagers.DocumentManager documentManager, 
                    JetBrains.UI.Components.Theming.IColorThemeManager themeManager, 
                    JetBrains.ActionManagement.IActionManager actionManager, 
                    JetBrains.UI.Tooltips.ITooltipManager tooltipManager, 
                    JetBrains.UI.Application.IUIApplication environment, 
                    JetBrains.ReSharper.Psi.Search.SearchDomainFactory searchDomainFactory) { }
        public System.Action<JetBrains.TextControl.ITextControl> CustomPatternQuickFix(JetBrains.ReSharper.Features.StructuralSearch.Highlightings.StructuralSearchPatternHighlightingBase highlighting, string text) { }
        public void EditCustomPattern(JetBrains.ReSharper.Features.StructuralSearch.ICustomPattern pattern) { }
        public void EditSearchAction(JetBrains.Application.DataContext.IDataContext context) { }
        public void FindSimilarCodeAction(JetBrains.Application.DataContext.IDataContext context) { }
        public bool IsAvailableFor(JetBrains.ReSharper.Psi.PsiLanguageType language) { }
        public void SearchAction(JetBrains.Application.DataContext.IDataContext context) { }
    }
    public abstract class StructuralSearchDaemonStageProcessBase : JetBrains.ReSharper.Daemon.IDaemonStageProcess, JetBrains.ReSharper.Psi.IRecursiveElementProcessor<JetBrains.ReSharper.Psi.Services.StructuralSearch.IMatchingContext>
    {
        protected StructuralSearchDaemonStageProcessBase(JetBrains.ReSharper.Daemon.IDaemonProcess process, JetBrains.Application.Settings.IContextBoundSettingsStore settingsStore, JetBrains.ReSharper.Psi.Tree.IFile file) { }
        public JetBrains.ReSharper.Daemon.IDaemonProcess DaemonProcess { get; }
        protected JetBrains.Application.Threading.IMultiCoreFibers Fibers { get; }
        protected virtual JetBrains.ReSharper.Daemon.IHighlighting CreateHighlighting(JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralMatchResult result, System.Collections.Generic.KeyValuePair<JetBrains.ReSharper.Features.StructuralSearch.ICustomPattern, JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralMatcher> pair) { }
        public void Execute(System.Action<JetBrains.ReSharper.Daemon.DaemonStageResult> committer) { }
        public virtual bool InteriorShouldBeProcessed(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.Services.StructuralSearch.IMatchingContext context) { }
        public bool IsProcessingFinished(JetBrains.ReSharper.Psi.Services.StructuralSearch.IMatchingContext context) { }
        protected void Match(JetBrains.ReSharper.Psi.Tree.ITreeNode param, System.Collections.Generic.Dictionary<JetBrains.ReSharper.Features.StructuralSearch.ICustomPattern, JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralMatcher> matchers, JetBrains.ReSharper.Psi.Services.StructuralSearch.IMatchingContext context) { }
        public void ProcessAfterInterior(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.Services.StructuralSearch.IMatchingContext context) { }
        public abstract void ProcessBeforeInterior(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.Services.StructuralSearch.IMatchingContext context);
    }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "StructuralSearch.EditSearch"})]
    public class StructuralSearchEditSearchAction : JetBrains.ActionManagement.IActionHandler
    {
        public void Execute(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.DelegateExecute nextExecute) { }
        public bool Update(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.ActionPresentation presentation, JetBrains.ActionManagement.DelegateUpdate nextUpdate) { }
    }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "StructuralSearch.FindSimilarCode"})]
    public class StructuralSearchFindSimilarCodeAction : JetBrains.ActionManagement.IActionHandler
    {
        public void Execute(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.DelegateExecute nextExecute) { }
        public bool Update(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.ActionPresentation presentation, JetBrains.ActionManagement.DelegateUpdate nextUpdate) { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class StructuralSearchMatcherManager
    {
        public StructuralSearchMatcherManager() { }
        public JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralMatcher GetOrCreateMatcher(JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralSearchPattern pattern, JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralSearchPatternBuilder builder = null) { }
    }
    public class StructuralSearchPatternSettings
    {
        [JetBrains.Application.Settings.SettingsEntryAttribute(true, "Format after replace")]
        public bool FormatAfterReplace;
        [JetBrains.Application.Settings.SettingsEntryAttribute(true, "Ignore braces in single statement blocks")]
        public bool IgnoreBracesInSingleStatementBlocks;
        [JetBrains.Application.Settings.SettingsEntryAttribute(true, "Ignore empty statements")]
        public bool IgnoreEmptyStatements;
        [JetBrains.Application.Settings.SettingsEntryAttribute(true, "Ignore parentheses in expressions")]
        public bool IgnoreParanthesisInExpressions;
        [JetBrains.Application.Settings.SettingsEntryAttribute(false, "Ignore additional unmatched content")]
        public bool IgnoreUnmatchedContent;
        [JetBrains.Application.Settings.SettingsEntryAttribute(false, "Is a replace pattern")]
        public bool IsReplacePattern;
        [JetBrains.Application.Settings.SettingsEntryAttribute(null, "Language")]
        public string LanguageName;
        [JetBrains.Application.Settings.SettingsEntryAttribute(true, "Match all members without modifiers")]
        public bool MatchAllMembersWithoutModifiers;
        [JetBrains.Application.Settings.SettingsEntryAttribute(true, "Match method parameters with \'this\', \'ref\' or \'out\'")]
        public bool MatchMethodParameterWithThisRefOut;
        [JetBrains.Application.Settings.SettingsEntryAttribute(null, "Replace pattern")]
        public string ReplacePattern;
        [JetBrains.Application.Settings.SettingsEntryAttribute(null, "Search pattern")]
        public string SearchPattern;
        [JetBrains.Application.Settings.SettingsEntryAttribute(true, "Shorten references")]
        public bool ShortenReferences;
        [JetBrains.Application.Settings.SettingsEntryAttribute(true, "Smartly match associative expressions")]
        public bool SmartMatchAssociativeExpressions;
        [JetBrains.Application.Settings.SettingsEntryAttribute(true, "Treat postfix and prefix operator as equivalent")]
        public bool TreatPostfixAndPrefixOperatorEquivalent;
        [JetBrains.Application.Settings.SettingsEntryAttribute(JetBrains.ReSharper.Psi.Services.StructuralSearch.TreatBinaryExpressionsEquivalent.Smart, "Treat reversed binary expressions as equivalent")]
        public JetBrains.ReSharper.Psi.Services.StructuralSearch.TreatBinaryExpressionsEquivalent TreatReversedBinaryExpressionsEquivalent;
        [JetBrains.Application.Settings.SettingsEntryAttribute(true, "Match void with Type placeholder")]
        public bool TypePlaceholderMatchesVoid;
    }
    public class StructuralSearchResultsBrowserDescriptor : JetBrains.ReSharper.Features.Finding.Search.SearchDescriptor, System.IDisposable
    {
        public StructuralSearchResultsBrowserDescriptor(JetBrains.ReSharper.Features.StructuralSearch.Finding.StructuralSearchRequest request) { }
        public override string ActionBarID { get; }
        public void Dispose() { }
        public override string GetResultsTitle(JetBrains.ReSharper.Features.Common.Occurences.OccurenceSection section) { }
    }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "StructuralSearch.Search"})]
    public class StructuralSearchSearchAction : JetBrains.ActionManagement.IActionHandler
    {
        public void Execute(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.DelegateExecute nextExecute) { }
        public bool Update(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.ActionPresentation presentation, JetBrains.ActionManagement.DelegateUpdate nextUpdate) { }
    }
    [JetBrains.Application.Settings.SettingsKeyAttribute(typeof(JetBrains.ReSharper.Settings.PatternsAndTemplatesSettingsKey), "“Search with pattern” settings")]
    public class StructuralSearchSettings { }
    [JetBrains.ProjectModel.Settings.Upgrade.SolutionSettingsUpgraderAttribute()]
    public class StructuralSearchSettingsUpgrader : JetBrains.Application.Configuration.IXmlReadable, JetBrains.Application.Configuration.Upgrade.ISettingsUpgrader, JetBrains.ProjectModel.Settings.Upgrade.ISolutionSettingsUpgrader { }
    [JetBrains.Application.ShellComponentAttribute()]
    public class VBPredefinedPatterns : JetBrains.ReSharper.Features.StructuralSearch.IPredefinedCustomPatternsSource
    {
        public VBPredefinedPatterns(JetBrains.ReSharper.Psi.ILanguageManager languageManager) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Features.StructuralSearch.IPredefinedPattern> GetPatterns() { }
    }
    public class VBPredefinedPatternsStageProcess : JetBrains.ReSharper.Features.StructuralSearch.VBStructuralSearchDaemonStageProcess
    {
        public VBPredefinedPatternsStageProcess(JetBrains.ReSharper.Daemon.IDaemonProcess process, JetBrains.Application.Settings.IContextBoundSettingsStore settingsStore, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<JetBrains.ReSharper.Features.StructuralSearch.ICustomPattern, JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralMatcher>> matchers, JetBrains.ReSharper.Psi.VB.Tree.IVBFile file) { }
        protected override JetBrains.ReSharper.Daemon.IHighlighting CreateHighlighting(JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralMatchResult result, System.Collections.Generic.KeyValuePair<JetBrains.ReSharper.Features.StructuralSearch.ICustomPattern, JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralMatcher> pair) { }
    }
    [JetBrains.ReSharper.Daemon.DaemonStageAttribute(StagesBefore=new System.Type[] {
            typeof(JetBrains.ReSharper.Daemon.LanguageSpecificDaemonStage)})]
    public class VBStructuralSearchDaemonStage : JetBrains.ReSharper.Daemon.VB.Stages.VBDaemonStageBase
    {
        public VBStructuralSearchDaemonStage(JetBrains.ReSharper.Features.StructuralSearch.CustomPatternMatcherManager customPatternMatcherManager) { }
        public override JetBrains.ReSharper.Daemon.IDaemonStageProcess CreateProcess(JetBrains.ReSharper.Daemon.IDaemonProcess process, JetBrains.Application.Settings.IContextBoundSettingsStore settings, JetBrains.ReSharper.Daemon.DaemonProcessKind processKind, JetBrains.ReSharper.Psi.VB.Tree.IVBFile file) { }
        protected override bool IsSupported(JetBrains.ReSharper.Psi.IPsiSourceFile projectFile, JetBrains.Application.Settings.IContextBoundSettingsStore settingsStore) { }
    }
    public class VBStructuralSearchDaemonStageProcess : JetBrains.ReSharper.Features.StructuralSearch.StructuralSearchDaemonStageProcessBase
    {
        public VBStructuralSearchDaemonStageProcess(JetBrains.ReSharper.Daemon.IDaemonProcess process, JetBrains.Application.Settings.IContextBoundSettingsStore settingsStore, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<JetBrains.ReSharper.Features.StructuralSearch.ICustomPattern, JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralMatcher>> matchers, JetBrains.ReSharper.Psi.VB.Tree.IVBFile file) { }
        public override bool InteriorShouldBeProcessed(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.Services.StructuralSearch.IMatchingContext context) { }
        public override void ProcessBeforeInterior(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.Services.StructuralSearch.IMatchingContext context) { }
    }
}
namespace JetBrains.ReSharper.Features.StructuralSearch.Finding
{
    
    public class StructuralSearchDomainSearcher<TResult> : JetBrains.ReSharper.Feature.Services.Search.SearchDomainVisitorParallel
    
    {
        public StructuralSearchDomainSearcher(JetBrains.ReSharper.Psi.Search.ISearchDomain searchDomain, JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralSearcher searcher, JetBrains.ReSharper.Psi.Search.IFindResultConsumer<TResult> consumer, JetBrains.Application.Progress.IProgressIndicator pi, bool async) { }
        protected override bool ProcessAssembly(JetBrains.ReSharper.Psi.IPsiAssembly assembly) { }
        protected override bool ProcessElement(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        protected override bool ProcessProjectFile(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
    }
    public class StructuralSearchOccurence : JetBrains.ReSharper.Feature.Services.Navigation.Occurences.RangeOccurence
    {
        public StructuralSearchOccurence(JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralMatchResult result) { }
        public JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralMatchResult Result { get; }
    }
    public class StructuralSearchRequest : JetBrains.ReSharper.Feature.Services.Search.SearchRequests.SearchRequest
    {
        public StructuralSearchRequest(JetBrains.ProjectModel.ISolution solution, JetBrains.DocumentManagers.DocumentManager documentManager, JetBrains.ReSharper.Psi.Search.SearchDomainFactory searchDomainFactory, JetBrains.ReSharper.Psi.Search.ISearchDomain searchDomain, JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralSearchPattern structuralSearchPattern) { }
        public JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralSearchPattern Pattern { get; }
        public JetBrains.ReSharper.Psi.Search.ISearchDomain SearchDomain { get; }
        public override System.Collections.ICollection SearchTargets { get; }
        public override JetBrains.ProjectModel.ISolution Solution { get; }
        public override string Title { get; }
        public override System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.Search.IOccurence> Search(JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralMatchResult> SearchReplaceTargets(JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
    }
}
namespace JetBrains.ReSharper.Features.StructuralSearch.Highlightings
{
    
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("", "CSHARP", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.NONE, ShowToolTipInStatusBar=true)]
    public class CSharpPredefinedPatternHighlighting : JetBrains.ReSharper.Features.StructuralSearch.Highlightings.StructuralSearchPatternHighlightingBase, JetBrains.ReSharper.Daemon.ICustomConfigurableSeverityIdHighlighting, JetBrains.ReSharper.Daemon.IHighlighting
    {
        public CSharpPredefinedPatternHighlighting(JetBrains.ReSharper.Features.StructuralSearch.IPredefinedPattern pattern, JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralMatchResult result) { }
        public string ConfigurableSeverityId { get; }
    }
    public abstract class CustomPatternHighlighting : JetBrains.ReSharper.Features.StructuralSearch.Highlightings.StructuralSearchPatternHighlightingBase
    {
        public static JetBrains.ReSharper.Daemon.IHighlighting Create(JetBrains.ReSharper.Features.StructuralSearch.ICustomPattern pattern, JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralMatchResult result) { }
    }
    public class EditCustomPatternAction : JetBrains.ReSharper.Intentions.Extensibility.IBulbAction
    {
        public EditCustomPatternAction(JetBrains.ReSharper.Features.StructuralSearch.ICustomPattern pattern) { }
        public string Text { get; }
        public void Execute(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
    }
    [JetBrains.ReSharper.Intentions.Extensibility.CustomHighlightingActionProviderAttribute(typeof(JetBrains.ProjectModel.KnownProjectFileType))]
    public class EditCustomPatternProvider : JetBrains.ReSharper.Intentions.Extensibility.ICustomHighlightingActionProvider
    {
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> GetActions(JetBrains.ReSharper.Daemon.IHighlighting highlighting, JetBrains.DocumentModel.DocumentRange highlightingRange, JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, string inspectionTitle) { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("", "HTML,ASPX", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.NONE, ShowToolTipInStatusBar=true)]
    public class HtmlPredefinedPatternHighlighting : JetBrains.ReSharper.Features.StructuralSearch.Highlightings.StructuralSearchPatternHighlightingBase, JetBrains.ReSharper.Daemon.ICustomConfigurableSeverityIdHighlighting, JetBrains.ReSharper.Daemon.IHighlighting
    {
        public HtmlPredefinedPatternHighlighting(JetBrains.ReSharper.Features.StructuralSearch.IPredefinedPattern pattern, JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralMatchResult result) { }
        public string ConfigurableSeverityId { get; }
    }
    public abstract class StructuralSearchPatternHighlightingBase : JetBrains.ReSharper.Daemon.IHighlighting
    {
        protected StructuralSearchPatternHighlightingBase(JetBrains.ReSharper.Features.StructuralSearch.ICustomPattern pattern, JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralMatchResult result) { }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Features.StructuralSearch.ICustomPattern Pattern { get; }
        public JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralMatchResult Result { get; }
        public string ToolTip { get; }
        public bool IsValid() { }
    }
    public class static StructuralSearchStaticHighlightingsGroups
    {
        public const string StructuralSearchGroup = "StructuralSearch";
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("", "VBASIC", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.NONE, ShowToolTipInStatusBar=true)]
    public class VBPredefinedPatternHighlighting : JetBrains.ReSharper.Features.StructuralSearch.Highlightings.StructuralSearchPatternHighlightingBase, JetBrains.ReSharper.Daemon.ICustomConfigurableSeverityIdHighlighting, JetBrains.ReSharper.Daemon.IHighlighting
    {
        public VBPredefinedPatternHighlighting(JetBrains.ReSharper.Features.StructuralSearch.IPredefinedPattern pattern, JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralMatchResult result) { }
        public string ConfigurableSeverityId { get; }
    }
}
namespace JetBrains.ReSharper.Features.StructuralSearch.Placeholders.CSharp
{
    
    [JetBrains.ReSharper.Features.StructuralSearch.Placeholders.PlaceholderEditorAttribute(typeof(JetBrains.ReSharper.Psi.CSharp.CSharpLanguage))]
    public class CSharpArgumentPlaceholderEditor : JetBrains.ReSharper.Features.StructuralSearch.Placeholders.CSharp.CSharpPlaceholderEditorBase<JetBrains.ReSharper.Psi.Services.CSharp.StructuralSearch.Placeholders.ArgumentPlaceholder, JetBrains.ReSharper.Features.StructuralSearch.Placeholders.CSharp.UI.ArgumentPlaceholderEditForm>
    {
        public CSharpArgumentPlaceholderEditor(JetBrains.UI.Application.IUIApplication environment, JetBrains.Application.Interop.NativeHook.IWindowsHookManager hookManager, JetBrains.CommonControls.Validation.FormValidators formValidators) { }
        public override string Name { get; }
        protected override JetBrains.ReSharper.Features.StructuralSearch.Placeholders.CSharp.UI.ArgumentPlaceholderEditForm CreateEditor(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Psi.Services.CSharp.StructuralSearch.Placeholders.ArgumentPlaceholder placeholder, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder> placeholders, System.Windows.Forms.IWin32Window mainwin) { }
        public override JetBrains.UI.Icons.IconId GetImage() { }
    }
    [JetBrains.ReSharper.Features.StructuralSearch.Placeholders.PlaceholderEditorAttribute(typeof(JetBrains.ReSharper.Psi.CSharp.CSharpLanguage))]
    public class CSharpExpressionPlaceholderEditor : JetBrains.ReSharper.Features.StructuralSearch.Placeholders.CSharp.CSharpPlaceholderEditorBase<JetBrains.ReSharper.Psi.Services.CSharp.StructuralSearch.Placeholders.ExpressionPlaceholder, JetBrains.ReSharper.Features.StructuralSearch.Placeholders.CSharp.UI.ExpressionPlaceholderEditForm>
    {
        public CSharpExpressionPlaceholderEditor(JetBrains.UI.Application.IUIApplication environment, JetBrains.Application.Interop.NativeHook.IWindowsHookManager hookManager, JetBrains.CommonControls.Validation.FormValidators formValidators, JetBrains.Application.IShellLocks shellLocks, JetBrains.ReSharper.Psi.CSharp.CSharpLanguage csharpLanguage) { }
        public override string Name { get; }
        protected override JetBrains.ReSharper.Features.StructuralSearch.Placeholders.CSharp.UI.ExpressionPlaceholderEditForm CreateEditor(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Psi.Services.CSharp.StructuralSearch.Placeholders.ExpressionPlaceholder placeholder, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder> placeholders, System.Windows.Forms.IWin32Window mainwin) { }
        public override JetBrains.UI.Icons.IconId GetImage() { }
    }
    [JetBrains.ReSharper.Features.StructuralSearch.Placeholders.PlaceholderEditorAttribute(typeof(JetBrains.ReSharper.Psi.CSharp.CSharpLanguage))]
    public class CSharpIdentifierPlaceholderEditor : JetBrains.ReSharper.Features.StructuralSearch.Placeholders.CSharp.CSharpPlaceholderEditorBase<JetBrains.ReSharper.Psi.Services.CSharp.StructuralSearch.Placeholders.IdentifierPlaceholder, JetBrains.ReSharper.Features.StructuralSearch.Placeholders.CSharp.UI.IdentifierPlaceholderEditForm>
    {
        public CSharpIdentifierPlaceholderEditor(JetBrains.UI.Application.IUIApplication environment, JetBrains.Application.Interop.NativeHook.IWindowsHookManager hookManager, JetBrains.CommonControls.Validation.FormValidators formValidators) { }
        public override string Name { get; }
        protected override JetBrains.ReSharper.Features.StructuralSearch.Placeholders.CSharp.UI.IdentifierPlaceholderEditForm CreateEditor(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Psi.Services.CSharp.StructuralSearch.Placeholders.IdentifierPlaceholder placeholder, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder> placeholders, System.Windows.Forms.IWin32Window mainwin) { }
        public override JetBrains.UI.Icons.IconId GetImage() { }
    }
    public abstract class CSharpPlaceholderEditorBase<T, TE> : JetBrains.ReSharper.Features.StructuralSearch.Placeholders.PlaceholderEditorBase<T, TE>
        where T :  class, JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder
        where TE : System.Windows.Forms.Form, JetBrains.ReSharper.Features.StructuralSearch.Placeholders.IPlaceholderEditorForm
    {
        protected CSharpPlaceholderEditorBase(JetBrains.UI.Application.IUIApplication environment) { }
    }
    [JetBrains.ReSharper.Features.StructuralSearch.Placeholders.PlaceholderEditorAttribute(typeof(JetBrains.ReSharper.Psi.CSharp.CSharpLanguage))]
    public class CSharpStatementPlaceholderEditor : JetBrains.ReSharper.Features.StructuralSearch.Placeholders.CSharp.CSharpPlaceholderEditorBase<JetBrains.ReSharper.Psi.Services.CSharp.StructuralSearch.Placeholders.StatementPlaceholder, JetBrains.ReSharper.Features.StructuralSearch.Placeholders.CSharp.UI.StatementPlaceholderEditForm>
    {
        public CSharpStatementPlaceholderEditor(JetBrains.UI.Application.IUIApplication environment, JetBrains.Application.Interop.NativeHook.IWindowsHookManager hookManager, JetBrains.CommonControls.Validation.FormValidators formValidators) { }
        public override string Name { get; }
        protected override JetBrains.ReSharper.Features.StructuralSearch.Placeholders.CSharp.UI.StatementPlaceholderEditForm CreateEditor(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Psi.Services.CSharp.StructuralSearch.Placeholders.StatementPlaceholder placeholder, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder> placeholders, System.Windows.Forms.IWin32Window mainwin) { }
        public override JetBrains.UI.Icons.IconId GetImage() { }
    }
    [JetBrains.ReSharper.Features.StructuralSearch.Placeholders.PlaceholderEditorAttribute(typeof(JetBrains.ReSharper.Psi.CSharp.CSharpLanguage))]
    public class CSharpTypePlaceholderEditor : JetBrains.ReSharper.Features.StructuralSearch.Placeholders.CSharp.CSharpPlaceholderEditorBase<JetBrains.ReSharper.Psi.Services.CSharp.StructuralSearch.Placeholders.TypePlaceholder, JetBrains.ReSharper.Features.StructuralSearch.Placeholders.CSharp.UI.TypePlaceholderEditForm>
    {
        public CSharpTypePlaceholderEditor(JetBrains.UI.Application.IUIApplication environment, JetBrains.Application.Interop.NativeHook.IWindowsHookManager hookManager, JetBrains.CommonControls.Validation.FormValidators formValidators, JetBrains.ReSharper.Psi.CSharp.CSharpLanguage csharpLanguage) { }
        public override string Name { get; }
        protected override JetBrains.ReSharper.Features.StructuralSearch.Placeholders.CSharp.UI.TypePlaceholderEditForm CreateEditor(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Psi.Services.CSharp.StructuralSearch.Placeholders.TypePlaceholder placeholder, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder> placeholders, System.Windows.Forms.IWin32Window mainwin) { }
        public override JetBrains.UI.Icons.IconId GetImage() { }
    }
}
namespace JetBrains.ReSharper.Features.StructuralSearch.Placeholders.CSharp.UI
{
    
    public class ArgumentPlaceholderEditForm : JetBrains.UI.CommonControls.Controls.FormOwnedByMainWindow, JetBrains.ReSharper.Features.StructuralSearch.Placeholders.IPlaceholderEditorForm
    {
        public ArgumentPlaceholderEditForm(JetBrains.UI.Application.IUIApplication environment, JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.Interop.NativeHook.IWindowsHookManager hookManager, JetBrains.CommonControls.Validation.FormValidators formValidators, JetBrains.ReSharper.Psi.Services.CSharp.StructuralSearch.Placeholders.ArgumentPlaceholder placeholder, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder> placeholders, System.Windows.Forms.IWin32Window mainwin) { }
        public JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder Placeholder { get; }
        public event System.EventHandler OkClick;
        protected override void Dispose(bool disposing) { }
        protected override void OnLoad(System.EventArgs e) { }
    }
    public class ExpressionPlaceholderEditForm : JetBrains.UI.CommonControls.Controls.FormOwnedByMainWindow, JetBrains.ReSharper.Features.StructuralSearch.Placeholders.IPlaceholderEditorForm
    {
        public ExpressionPlaceholderEditForm(JetBrains.UI.Application.IUIApplication environment, JetBrains.Application.Interop.NativeHook.IWindowsHookManager hookManager, JetBrains.CommonControls.Validation.FormValidators formValidators, JetBrains.Application.IShellLocks shellLocks, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Psi.CSharp.CSharpLanguage csharpLanguage, JetBrains.ReSharper.Psi.Services.CSharp.StructuralSearch.Placeholders.ExpressionPlaceholder placeholder, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder> placeholders, System.Windows.Forms.IWin32Window mainwin) { }
        public JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder Placeholder { get; }
        public event System.EventHandler OkClick;
        protected override void Dispose(bool disposing) { }
        protected override void OnLoad(System.EventArgs e) { }
    }
    public class IdentifierPlaceholderEditForm : JetBrains.UI.CommonControls.Controls.FormOwnedByMainWindow, JetBrains.ReSharper.Features.StructuralSearch.Placeholders.IPlaceholderEditorForm
    {
        public IdentifierPlaceholderEditForm(JetBrains.UI.Application.IUIApplication environment, JetBrains.Application.Interop.NativeHook.IWindowsHookManager hookManager, JetBrains.CommonControls.Validation.FormValidators formValidators, JetBrains.ReSharper.Psi.Services.CSharp.StructuralSearch.Placeholders.IdentifierPlaceholder placeholder, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder> placeholders, System.Windows.Forms.IWin32Window mainwin) { }
        public JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder Placeholder { get; }
        public event System.EventHandler OkClick;
        protected override void Dispose(bool disposing) { }
        protected override void OnLoad(System.EventArgs e) { }
    }
    public class StatementPlaceholderEditForm : JetBrains.UI.CommonControls.Controls.FormOwnedByMainWindow, JetBrains.ReSharper.Features.StructuralSearch.Placeholders.IPlaceholderEditorForm
    {
        public StatementPlaceholderEditForm(JetBrains.UI.Application.IUIApplication environment, JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.Interop.NativeHook.IWindowsHookManager hookManager, JetBrains.CommonControls.Validation.FormValidators formValidators, JetBrains.ReSharper.Psi.Services.CSharp.StructuralSearch.Placeholders.StatementPlaceholder placeholder, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder> placeholders, System.Windows.Forms.IWin32Window mainwin) { }
        public JetBrains.UI.Application.IUIApplication Environment { get; }
        public JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder Placeholder { get; }
        public event System.EventHandler OkClick;
        protected override void Dispose(bool disposing) { }
        protected override void OnLoad(System.EventArgs e) { }
    }
    public class TypePlaceholderEditForm : JetBrains.UI.CommonControls.Controls.FormOwnedByMainWindow, JetBrains.ReSharper.Features.StructuralSearch.Placeholders.IPlaceholderEditorForm
    {
        public TypePlaceholderEditForm(JetBrains.UI.Application.IUIApplication environment, JetBrains.Application.Interop.NativeHook.IWindowsHookManager hookManager, JetBrains.CommonControls.Validation.FormValidators formValidators, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Psi.CSharp.CSharpLanguage csharpLanguage, JetBrains.ReSharper.Psi.Services.CSharp.StructuralSearch.Placeholders.TypePlaceholder placeholder, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder> placeholders, System.Windows.Forms.IWin32Window mainwin) { }
        public JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder Placeholder { get; }
        public event System.EventHandler OkClick;
        protected override void Dispose(bool disposing) { }
        protected override void OnLoad(System.EventArgs e) { }
    }
}
namespace JetBrains.ReSharper.Features.StructuralSearch.Placeholders
{
    
    public interface IPlaceholderEditor
    {
        string Name { get; }
        System.Type PlaceholderType { get; }
        void CreatePlaceholder(JetBrains.ProjectModel.ISolution solution, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder> placeholders, System.Action<JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder> callback, System.Windows.Forms.Form parent);
        void EditPlaceholder(JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder placeholder, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder> placeholders, System.Action<JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder> callback, System.Windows.Forms.Form parent);
        JetBrains.UI.Icons.IconId GetImage();
    }
    public interface IPlaceholderEditorForm
    {
        JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder Placeholder { get; }
        public event System.EventHandler OkClick;
    }
    [JetBrains.Annotations.BaseTypeRequiredAttribute(typeof(JetBrains.ReSharper.Features.StructuralSearch.Placeholders.IPlaceholderEditor))]
    [JetBrains.Annotations.MeansImplicitUseAttribute()]
    public class PlaceholderEditorAttribute : JetBrains.ReSharper.Psi.LanguageAttribute
    {
        public PlaceholderEditorAttribute(System.Type language) { }
    }
    public abstract class PlaceholderEditorBase<T, TE> : JetBrains.ReSharper.Features.StructuralSearch.Placeholders.IPlaceholderEditor
        where T :  class, JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder
        where TE : System.Windows.Forms.Form, JetBrains.ReSharper.Features.StructuralSearch.Placeholders.IPlaceholderEditorForm
    {
        protected PlaceholderEditorBase(JetBrains.UI.Application.IUIApplication environment) { }
        public JetBrains.UI.Application.IUIApplication Environment { get; }
        public abstract string Name { get; }
        public virtual System.Type PlaceholderType { get; }
        protected abstract TE CreateEditor(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ProjectModel.ISolution solution, T placeholder, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder> placeholders, System.Windows.Forms.IWin32Window mainwin);
        public void CreatePlaceholder(JetBrains.ProjectModel.ISolution solution, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder> placeholders, System.Action<JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder> callback, System.Windows.Forms.Form parent) { }
        public void EditPlaceholder(JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder placeholder, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder> placeholders, System.Action<JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder> callback, System.Windows.Forms.Form parent) { }
        public abstract JetBrains.UI.Icons.IconId GetImage();
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class PlaceholderEditorManager
    {
        public PlaceholderEditorManager(JetBrains.ReSharper.Psi.ILanguageManager languageManager) { }
        public void CreatePlaceholder(System.Type type, JetBrains.ProjectModel.ISolution solution, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder> placeholders, System.Action<JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder> callback, System.Windows.Forms.Form parent, JetBrains.ReSharper.Psi.PsiLanguageType language) { }
        public void EditPlaceholder(JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder placeholder, JetBrains.ProjectModel.ISolution solution, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder> placeholders, System.Action<JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder> callback, System.Windows.Forms.Form parent, JetBrains.ReSharper.Psi.PsiLanguageType language) { }
        public JetBrains.UI.Icons.IconId GetImage(JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder placeholder, JetBrains.ReSharper.Psi.PsiLanguageType language) { }
        public JetBrains.UI.Icons.IconId GetImage(System.Type type, JetBrains.ReSharper.Psi.PsiLanguageType language) { }
        public System.Collections.Generic.IEnumerable<JetBrains.Util.Pair<string, System.Type>> GetPlaceholderEditors(JetBrains.ReSharper.Psi.PsiLanguageType language) { }
        public static JetBrains.Util.JetTuple<JetBrains.CommonControls.Validation.ValidatorSeverity, JetBrains.UI.RichText.RichText> NameValidator(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder> placeholders, JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder placeholder, string name) { }
        public static JetBrains.Util.JetTuple<JetBrains.CommonControls.Validation.ValidatorSeverity, JetBrains.UI.RichText.RichText> RegExpValidator(string regexp, bool caseSensitive) { }
    }
}
namespace JetBrains.ReSharper.Features.StructuralSearch.Placeholders.VB.UI
{
    
    public class ArgumentPlaceholderEditForm : JetBrains.UI.CommonControls.Controls.FormOwnedByMainWindow, JetBrains.ReSharper.Features.StructuralSearch.Placeholders.IPlaceholderEditorForm
    {
        public ArgumentPlaceholderEditForm(JetBrains.UI.Application.IUIApplication environment, JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.Interop.NativeHook.IWindowsHookManager hookManager, JetBrains.CommonControls.Validation.FormValidators formValidators, JetBrains.ReSharper.Psi.Services.VB.StructuralSearch.Placeholders.ArgumentPlaceholder placeholder, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder> placeholders, System.Windows.Forms.IWin32Window mainwin) { }
        public JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder Placeholder { get; }
        public event System.EventHandler OkClick;
        protected override void Dispose(bool disposing) { }
        protected override void OnLoad(System.EventArgs e) { }
    }
    public class ExpressionPlaceholderEditForm : JetBrains.UI.CommonControls.Controls.FormOwnedByMainWindow, JetBrains.ReSharper.Features.StructuralSearch.Placeholders.IPlaceholderEditorForm
    {
        public ExpressionPlaceholderEditForm(JetBrains.UI.Application.IUIApplication environment, JetBrains.Application.Interop.NativeHook.IWindowsHookManager hookManager, JetBrains.CommonControls.Validation.FormValidators formValidators, JetBrains.Application.IShellLocks shellLocks, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Psi.VB.VBLanguage vbLanguage, JetBrains.ReSharper.Psi.Services.VB.StructuralSearch.Placeholders.ExpressionPlaceholder placeholder, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder> placeholders, System.Windows.Forms.IWin32Window mainwin) { }
        public JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder Placeholder { get; }
        public event System.EventHandler OkClick;
        protected override void Dispose(bool disposing) { }
        protected override void OnLoad(System.EventArgs e) { }
    }
    public class IdentifierPlaceholderEditForm : JetBrains.UI.CommonControls.Controls.FormOwnedByMainWindow, JetBrains.ReSharper.Features.StructuralSearch.Placeholders.IPlaceholderEditorForm
    {
        public IdentifierPlaceholderEditForm(JetBrains.UI.Application.IUIApplication environment, JetBrains.Application.Interop.NativeHook.IWindowsHookManager hookManager, JetBrains.CommonControls.Validation.FormValidators formValidators, JetBrains.ReSharper.Psi.Services.VB.StructuralSearch.Placeholders.IdentifierPlaceholder placeholder, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder> placeholders, System.Windows.Forms.IWin32Window mainwin) { }
        public JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder Placeholder { get; }
        public event System.EventHandler OkClick;
        protected override void Dispose(bool disposing) { }
        protected override void OnLoad(System.EventArgs e) { }
    }
    public class StatementPlaceholderEditForm : JetBrains.UI.CommonControls.Controls.FormOwnedByMainWindow, JetBrains.ReSharper.Features.StructuralSearch.Placeholders.IPlaceholderEditorForm
    {
        public StatementPlaceholderEditForm(JetBrains.UI.Application.IUIApplication environment, JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.Interop.NativeHook.IWindowsHookManager hookManager, JetBrains.CommonControls.Validation.FormValidators formValidators, JetBrains.ReSharper.Psi.Services.VB.StructuralSearch.Placeholders.StatementPlaceholder placeholder, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder> placeholders, System.Windows.Forms.IWin32Window mainwin) { }
        public JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder Placeholder { get; }
        public event System.EventHandler OkClick;
        protected override void Dispose(bool disposing) { }
        protected override void OnLoad(System.EventArgs e) { }
    }
    public class TypePlaceholderEditForm : JetBrains.UI.CommonControls.Controls.FormOwnedByMainWindow, JetBrains.ReSharper.Features.StructuralSearch.Placeholders.IPlaceholderEditorForm
    {
        public TypePlaceholderEditForm(JetBrains.UI.Application.IUIApplication environment, JetBrains.Application.Interop.NativeHook.IWindowsHookManager hookManager, JetBrains.CommonControls.Validation.FormValidators formValidators, JetBrains.Application.IShellLocks shellLocks, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Psi.VB.VBLanguage vbLanguage, JetBrains.ReSharper.Psi.Services.VB.StructuralSearch.Placeholders.TypePlaceholder placeholder, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder> placeholders, System.Windows.Forms.IWin32Window mainwin) { }
        public JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder Placeholder { get; }
        public event System.EventHandler OkClick;
        protected override void Dispose(bool disposing) { }
        protected override void OnLoad(System.EventArgs e) { }
    }
}
namespace JetBrains.ReSharper.Features.StructuralSearch.Placeholders.VB
{
    
    [JetBrains.ReSharper.Features.StructuralSearch.Placeholders.PlaceholderEditorAttribute(typeof(JetBrains.ReSharper.Psi.VB.VBLanguage))]
    public class VBArgumentPlaceholderEditor : JetBrains.ReSharper.Features.StructuralSearch.Placeholders.VB.VBPlaceholderEditorBase<JetBrains.ReSharper.Psi.Services.VB.StructuralSearch.Placeholders.ArgumentPlaceholder, JetBrains.ReSharper.Features.StructuralSearch.Placeholders.VB.UI.ArgumentPlaceholderEditForm>
    {
        public VBArgumentPlaceholderEditor(JetBrains.UI.Application.IUIApplication environment, JetBrains.Application.Interop.NativeHook.IWindowsHookManager hookManager, JetBrains.CommonControls.Validation.FormValidators formValidators) { }
        public override string Name { get; }
        protected override JetBrains.ReSharper.Features.StructuralSearch.Placeholders.VB.UI.ArgumentPlaceholderEditForm CreateEditor(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Psi.Services.VB.StructuralSearch.Placeholders.ArgumentPlaceholder placeholder, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder> placeholders, System.Windows.Forms.IWin32Window mainwin) { }
        public override JetBrains.UI.Icons.IconId GetImage() { }
    }
    [JetBrains.ReSharper.Features.StructuralSearch.Placeholders.PlaceholderEditorAttribute(typeof(JetBrains.ReSharper.Psi.VB.VBLanguage))]
    public class VBExpressionPlaceholderEditor : JetBrains.ReSharper.Features.StructuralSearch.Placeholders.VB.VBPlaceholderEditorBase<JetBrains.ReSharper.Psi.Services.VB.StructuralSearch.Placeholders.ExpressionPlaceholder, JetBrains.ReSharper.Features.StructuralSearch.Placeholders.VB.UI.ExpressionPlaceholderEditForm>
    {
        public VBExpressionPlaceholderEditor(JetBrains.UI.Application.IUIApplication environment, JetBrains.Application.Interop.NativeHook.IWindowsHookManager hookManager, JetBrains.CommonControls.Validation.FormValidators formValidators, JetBrains.Application.IShellLocks shellLocks, JetBrains.ReSharper.Psi.VB.VBLanguage vbLanguage) { }
        public override string Name { get; }
        protected override JetBrains.ReSharper.Features.StructuralSearch.Placeholders.VB.UI.ExpressionPlaceholderEditForm CreateEditor(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Psi.Services.VB.StructuralSearch.Placeholders.ExpressionPlaceholder placeholder, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder> placeholders, System.Windows.Forms.IWin32Window mainwin) { }
        public override JetBrains.UI.Icons.IconId GetImage() { }
    }
    [JetBrains.ReSharper.Features.StructuralSearch.Placeholders.PlaceholderEditorAttribute(typeof(JetBrains.ReSharper.Psi.VB.VBLanguage))]
    public class VBIdentifierPlaceholderEditor : JetBrains.ReSharper.Features.StructuralSearch.Placeholders.VB.VBPlaceholderEditorBase<JetBrains.ReSharper.Psi.Services.VB.StructuralSearch.Placeholders.IdentifierPlaceholder, JetBrains.ReSharper.Features.StructuralSearch.Placeholders.VB.UI.IdentifierPlaceholderEditForm>
    {
        public VBIdentifierPlaceholderEditor(JetBrains.UI.Application.IUIApplication environment, JetBrains.Application.Interop.NativeHook.IWindowsHookManager hookManager, JetBrains.CommonControls.Validation.FormValidators formValidators) { }
        public override string Name { get; }
        protected override JetBrains.ReSharper.Features.StructuralSearch.Placeholders.VB.UI.IdentifierPlaceholderEditForm CreateEditor(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Psi.Services.VB.StructuralSearch.Placeholders.IdentifierPlaceholder placeholder, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder> placeholders, System.Windows.Forms.IWin32Window mainwin) { }
        public override JetBrains.UI.Icons.IconId GetImage() { }
    }
    public abstract class VBPlaceholderEditorBase<T, TE> : JetBrains.ReSharper.Features.StructuralSearch.Placeholders.PlaceholderEditorBase<T, TE>
        where T :  class, JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder
        where TE : System.Windows.Forms.Form, JetBrains.ReSharper.Features.StructuralSearch.Placeholders.IPlaceholderEditorForm
    {
        protected VBPlaceholderEditorBase(JetBrains.UI.Application.IUIApplication environment) { }
    }
    [JetBrains.ReSharper.Features.StructuralSearch.Placeholders.PlaceholderEditorAttribute(typeof(JetBrains.ReSharper.Psi.VB.VBLanguage))]
    public class VBStatementPlaceholderEditor : JetBrains.ReSharper.Features.StructuralSearch.Placeholders.VB.VBPlaceholderEditorBase<JetBrains.ReSharper.Psi.Services.VB.StructuralSearch.Placeholders.StatementPlaceholder, JetBrains.ReSharper.Features.StructuralSearch.Placeholders.VB.UI.StatementPlaceholderEditForm>
    {
        public VBStatementPlaceholderEditor(JetBrains.UI.Application.IUIApplication environment, JetBrains.Application.Interop.NativeHook.IWindowsHookManager hookManager, JetBrains.CommonControls.Validation.FormValidators formValidators) { }
        public override string Name { get; }
        protected override JetBrains.ReSharper.Features.StructuralSearch.Placeholders.VB.UI.StatementPlaceholderEditForm CreateEditor(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Psi.Services.VB.StructuralSearch.Placeholders.StatementPlaceholder placeholder, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder> placeholders, System.Windows.Forms.IWin32Window mainwin) { }
        public override JetBrains.UI.Icons.IconId GetImage() { }
    }
    [JetBrains.ReSharper.Features.StructuralSearch.Placeholders.PlaceholderEditorAttribute(typeof(JetBrains.ReSharper.Psi.VB.VBLanguage))]
    public class VBTypePlaceholderEditor : JetBrains.ReSharper.Features.StructuralSearch.Placeholders.VB.VBPlaceholderEditorBase<JetBrains.ReSharper.Psi.Services.VB.StructuralSearch.Placeholders.TypePlaceholder, JetBrains.ReSharper.Features.StructuralSearch.Placeholders.VB.UI.TypePlaceholderEditForm>
    {
        public VBTypePlaceholderEditor(JetBrains.UI.Application.IUIApplication environment, JetBrains.Application.Interop.NativeHook.IWindowsHookManager hookManager, JetBrains.CommonControls.Validation.FormValidators formValidators, JetBrains.Application.IShellLocks shellLocks, JetBrains.ReSharper.Psi.VB.VBLanguage vbLanguage) { }
        public override string Name { get; }
        protected override JetBrains.ReSharper.Features.StructuralSearch.Placeholders.VB.UI.TypePlaceholderEditForm CreateEditor(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Psi.Services.VB.StructuralSearch.Placeholders.TypePlaceholder placeholder, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder> placeholders, System.Windows.Forms.IWin32Window mainwin) { }
        public override JetBrains.UI.Icons.IconId GetImage() { }
    }
}
namespace JetBrains.ReSharper.Features.StructuralSearch.Resources.StructuralSearchIcons
{
    
    [JetBrains.Application.ShellComponentAttribute(JetBrains.Application.Sharing.Common, JetBrains.Application.Lifecycle.DemandReclaimable, JetBrains.Application.Creation.AnyThread, JetBrains.Application.Access.AnyThread)]
    public class IconsForIconThemeSelectionSampleStructuralSearch : JetBrains.UI.Icons.Settings.IIconsForIconThemeSelectionSample { }
}
namespace JetBrains.ReSharper.Features.StructuralSearch.Resources
{
    
    public sealed class StructuralSearchThemedIcons
    {
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Features.StructuralSearch;component/resources/StructuralSearc" +
            "hIcons/ThemedIcons.StructuralSearch.Generated.Xaml", 14, "AddPattern")]
        public sealed class AddPattern : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Features.StructuralSearch;component/resources/StructuralSearc" +
            "hIcons/ThemedIcons.StructuralSearch.Generated.Xaml", 15, "AddPlaceholder")]
        public sealed class AddPlaceholder : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Features.StructuralSearch;component/resources/StructuralSearc" +
            "hIcons/ThemedIcons.StructuralSearch.Generated.Xaml", 20, "Argument")]
        public sealed class Argument : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Features.StructuralSearch;component/resources/StructuralSearc" +
            "hIcons/ThemedIcons.StructuralSearch.Generated.Xaml", 0, "EditPattern")]
        public sealed class EditPattern : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Features.StructuralSearch;component/resources/StructuralSearc" +
            "hIcons/ThemedIcons.StructuralSearch.Generated.Xaml", 2, "EditPlaceholder")]
        public sealed class EditPlaceholder : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Features.StructuralSearch;component/resources/StructuralSearc" +
            "hIcons/ThemedIcons.StructuralSearch.Generated.Xaml", 19, "Expression")]
        public sealed class Expression : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Features.StructuralSearch;component/resources/StructuralSearc" +
            "hIcons/ThemedIcons.StructuralSearch.Generated.Xaml", 8, "Identifier")]
        public sealed class Identifier : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Features.StructuralSearch;component/resources/StructuralSearc" +
            "hIcons/ThemedIcons.StructuralSearch.Generated.Xaml", 10, "Import")]
        public sealed class Import : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Features.StructuralSearch;component/resources/StructuralSearc" +
            "hIcons/ThemedIcons.StructuralSearch.Generated.Xaml", 1, "Pattern")]
        public sealed class Pattern : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Features.StructuralSearch;component/resources/StructuralSearc" +
            "hIcons/ThemedIcons.StructuralSearch.Generated.Xaml", 16, "PatternsCatalogue")]
        public sealed class PatternsCatalogue : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Features.StructuralSearch;component/resources/StructuralSearc" +
            "hIcons/ThemedIcons.StructuralSearch.Generated.Xaml", 17, "PerformStructuralSearch")]
        public sealed class PerformStructuralSearch : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Features.StructuralSearch;component/resources/StructuralSearc" +
            "hIcons/ThemedIcons.StructuralSearch.Generated.Xaml", 5, "RemovePattern")]
        public sealed class RemovePattern : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Features.StructuralSearch;component/resources/StructuralSearc" +
            "hIcons/ThemedIcons.StructuralSearch.Generated.Xaml", 13, "RemovePlaceholder")]
        public sealed class RemovePlaceholder : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Features.StructuralSearch;component/resources/StructuralSearc" +
            "hIcons/ThemedIcons.StructuralSearch.Generated.Xaml", 11, "SeverityError")]
        public sealed class SeverityError : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Features.StructuralSearch;component/resources/StructuralSearc" +
            "hIcons/ThemedIcons.StructuralSearch.Generated.Xaml", 9, "SeverityHint")]
        public sealed class SeverityHint : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Features.StructuralSearch;component/resources/StructuralSearc" +
            "hIcons/ThemedIcons.StructuralSearch.Generated.Xaml", 7, "SeverityNone")]
        public sealed class SeverityNone : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Features.StructuralSearch;component/resources/StructuralSearc" +
            "hIcons/ThemedIcons.StructuralSearch.Generated.Xaml", 3, "SeveritySuggestion")]
        public sealed class SeveritySuggestion : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Features.StructuralSearch;component/resources/StructuralSearc" +
            "hIcons/ThemedIcons.StructuralSearch.Generated.Xaml", 4, "SeverityWarning")]
        public sealed class SeverityWarning : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Features.StructuralSearch;component/resources/StructuralSearc" +
            "hIcons/ThemedIcons.StructuralSearch.Generated.Xaml", 12, "Statement")]
        public sealed class Statement : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Features.StructuralSearch;component/resources/StructuralSearc" +
            "hIcons/ThemedIcons.StructuralSearch.Generated.Xaml", 18, "StructuralSearchPlaceholder")]
        public sealed class StructuralSearchPlaceholder : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Features.StructuralSearch;component/resources/StructuralSearc" +
            "hIcons/ThemedIcons.StructuralSearch.Generated.Xaml", 6, "Type")]
        public sealed class Type : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
    }
}
namespace JetBrains.ReSharper.Features.StructuralSearch.UI
{
    
    public class CustomPatternItem : System.ComponentModel.INotifyPropertyChanged
    {
        public CustomPatternItem(JetBrains.Application.Settings.GuidIndex id, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Features.StructuralSearch.ICustomPattern pattern, JetBrains.Application.Settings.IContextBoundSettingsStore contextBoundSettingsStore) { }
        public JetBrains.Application.Settings.GuidIndex Id { get; }
        public string LanguageName { get; }
        public JetBrains.ReSharper.Features.StructuralSearch.ICustomPattern Pattern { get; set; }
        [JetBrains.Annotations.UsedImplicitlyAttribute()]
        public string SearchFor { get; set; }
        [JetBrains.Annotations.UsedImplicitlyAttribute()]
        public string SearchForTrimmedToFirstNonEmptyLine { get; set; }
        [JetBrains.Annotations.UsedImplicitlyAttribute()]
        public JetBrains.ReSharper.Daemon.Severity Severity { get; set; }
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
    }
    [JetBrains.UI.Options.OptionsPageAttribute("CustomPatterns", "Custom Patterns", typeof(JetBrains.ReSharper.Features.StructuralSearch.Resources.StructuralSearchThemedIcons.PatternsCatalogue), HelpKeyword="Reference__Options__Code_Inspection__Custom_Patterns", ParentId="CodeInspection", Sequence=3D)]
    public class CustomPatternsPage : System.Windows.Forms.UserControl, JetBrains.UI.Options.IOptionsPage
    {
        public const string PID = "CustomPatterns";
        public CustomPatternsPage(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ReSharper.Psi.Services.StructuralSearch.StructuralSearchEngine engine, JetBrains.ReSharper.Psi.PsiProjectFileTypeCoordinator psiProjectFileTypeCoordinator, JetBrains.UI.Application.IMainWindow mainwin, JetBrains.Application.IShellLocks locks, JetBrains.Application.IApplicationDescriptor product, JetBrains.TextControl.DocumentMarkup.IDocumentMarkupManager documentMarkupManager, JetBrains.UI.Options.OptionsSettingsSmartContext optionsSettingsSmartContext, JetBrains.ReSharper.Psi.ILanguages languages, JetBrains.ReSharper.Psi.Search.SearchDomainFactory searchDomainFactory, JetBrains.CommonControls.Validation.FormValidators formValidators = null, JetBrains.Application.Interop.NativeHook.IWindowsHookManager windowsHookManager = null, JetBrains.ProjectModel.ISolution solution = null, JetBrains.ReSharper.Features.StructuralSearch.StructuralSearchActionManager structuralSearchActionManager = null, JetBrains.DocumentManagers.DocumentManager documentManager = null) { }
        public JetBrains.UI.CrossFramework.EitherControl Control { get; }
        public string Id { get; }
        public bool OnOk() { }
        public bool ValidatePage() { }
    }
    public sealed class CustomPatternsView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector
    {
        public static readonly System.Windows.DependencyProperty CustomPatternItemsSourceProperty;
        public CustomPatternsView(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.IShellLocks locks, JetBrains.ReSharper.Psi.Services.StructuralSearch.StructuralSearchEngine engine, JetBrains.ReSharper.Psi.PsiProjectFileTypeCoordinator psiProjectFileTypeCoordinator, JetBrains.UI.Application.IMainWindow mainWindow, JetBrains.Application.IApplicationDescriptor applicationDescriptor, JetBrains.CommonControls.Validation.FormValidators formValidators, JetBrains.Application.Interop.NativeHook.IWindowsHookManager windowsHookManager, JetBrains.TextControl.DocumentMarkup.IDocumentMarkupManager documentMarkupManager, JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Settings.IContextBoundSettingsStore contextBoundSettingsStore, JetBrains.DocumentManagers.DocumentManager documentManager, JetBrains.ReSharper.Features.StructuralSearch.StructuralSearchActionManager structuralSearchActionManager, JetBrains.ReSharper.Psi.Search.SearchDomainFactory searchDomainFactory) { }
        public System.Collections.ObjectModel.ObservableCollection<JetBrains.ReSharper.Features.StructuralSearch.UI.CustomPatternItem> CustomPatternItemsSource { get; set; }
        public void InitializeComponent() { }
    }
    public class PatternsCollection : JetBrains.UI.CommonControls.SafeTableLayoutPanel
    {
        public PatternsCollection(JetBrains.ProjectModel.ISolution solution, JetBrains.DocumentManagers.DocumentManager documentManager, JetBrains.ReSharper.Features.StructuralSearch.StructuralSearchActionManager structuralSearchActionManager, JetBrains.UI.Application.IUIApplication environment, JetBrains.ReSharper.Psi.Search.SearchDomainFactory searchDomainFactory) { }
    }
    public class PatternToTextBlockConverter : System.Windows.Data.IValueConverter
    {
        public object Convert(object value, System.Type targetType, object parameter, System.Globalization.CultureInfo culture) { }
        public object ConvertBack(object value, System.Type targetType, object parameter, System.Globalization.CultureInfo culture) { }
    }
    public class PlaceholdersCollection : JetBrains.UI.CommonControls.SafeTableLayoutPanel
    {
        public PlaceholdersCollection([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Features.StructuralSearch.Placeholders.PlaceholderEditorManager placeholderEditorManager, JetBrains.UI.Application.IUIApplication environment) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder> Items { get; set; }
        public JetBrains.ReSharper.Psi.PsiLanguageType Language { get; set; }
        public event System.EventHandler AddGuessedPlaceholders;
        public event System.EventHandler Changed;
    }
    public class PlaceholdersCollectionTreeView : JetBrains.UI.TreeView.TreeModelPresentableView
    {
        public PlaceholdersCollectionTreeView(JetBrains.TreeModels.TreeModel model) { }
        protected override void Initialize() { }
        protected override void SetupColumnWidth() { }
        protected override void UpdateNodeCells(JetBrains.UI.TreeView.TreeModelViewNode viewNode, JetBrains.TreeModels.TreeModelNode modelNode, JetBrains.UI.TreeView.PresentationState state) { }
    }
    public class PlaceholdersCollectionTreeViewController : JetBrains.UI.TreeView.TreeViewController
    {
        public PlaceholdersCollectionTreeViewController() { }
        public override bool DragDropSupported { get; }
        public override bool GuardActions { get; }
        public override bool QuickSearchSupported { get; }
        public override bool VisibilitySupported { get; }
        public override bool ExpandNodeInitially(JetBrains.TreeModels.TreeModelNode modelNode) { }
        public override bool VisibilityState(JetBrains.TreeModels.TreeModelNode modelNode) { }
    }
    public class PlaceholdersCollectionTreeViewPresenter : JetBrains.UI.TreeView.StructuredPresenter<JetBrains.TreeModels.TreeModelNode, JetBrains.CommonControls.IPresentableItem>
    {
        public PlaceholdersCollectionTreeViewPresenter(JetBrains.ReSharper.Features.StructuralSearch.Placeholders.PlaceholderEditorManager placeholderEditorManager, JetBrains.ReSharper.Psi.PsiLanguageType language) { }
        public JetBrains.ReSharper.Psi.PsiLanguageType Language { get; set; }
        public override void UpdateItem(object value, JetBrains.TreeModels.TreeModelNode structureElement, JetBrains.CommonControls.IPresentableItem item, JetBrains.UI.TreeView.PresentationState state) { }
    }
    public class ReplaceFoundOccurenciesPanel : JetBrains.ReSharper.Features.Common.TreePsiBrowser.TreeModelBrowserPanelPsi
    {
        public ReplaceFoundOccurenciesPanel(JetBrains.ReSharper.Features.StructuralSearch.StructuralReplaceSearchResultsBrowserDescriptor descriptor, JetBrains.UI.Application.IUIApplication environment) { }
        public void CheckItems() { }
        protected override JetBrains.UI.TreeView.TreeModelPresentableView CreateView(JetBrains.TreeModels.TreeModel model) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Features.StructuralSearch.Finding.StructuralSearchOccurence> GetCheckedItems() { }
    }
    public class ReplaceOccurenciesForm : JetBrains.UI.CommonControls.Controls.FormOwnedByMainWindow
    {
        public ReplaceOccurenciesForm(JetBrains.ReSharper.Features.StructuralSearch.StructuralReplaceSearchResultsBrowserDescriptor descriptor, JetBrains.Threading.IThreading invocator, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.UI.Application.IMainWindow mainwin, JetBrains.DocumentModel.DocumentSettings documentSettings, JetBrains.UI.Components.Theming.IColorThemeManager themeManager) { }
        public event System.EventHandler OkClick;
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralMatchResult> GetTargets() { }
    }
    public sealed class SeverityConverter : System.Windows.Data.IValueConverter
    {
        public object Convert(object value, System.Type targetType, object parameter, System.Globalization.CultureInfo culture) { }
        public object ConvertBack(object value, System.Type targetType, object parameter, System.Globalization.CultureInfo culture) { }
    }
    public sealed class SeverityValues : System.Collections.ObjectModel.ObservableCollection<JetBrains.ReSharper.Daemon.Severity>
    {
        public SeverityValues() { }
    }
    public class StructuralSearchConflictsForm : JetBrains.UI.CommonControls.Controls.FormOwnedByMainWindow
    {
        public StructuralSearchConflictsForm([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.UI.Application.IMainWindow mainWindow, JetBrains.UI.Application.IUIApplication environment, string subtitle) { }
        public event System.EventHandler OkClick;
        public void AddConflicts(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Refactorings.Conflicts.IConflict> conflicts) { }
        protected override void Dispose(bool disposing) { }
    }
    public class StructuralSearchForm : JetBrains.UI.CommonControls.Controls.FormOwnedByMainWindow
    {
        public StructuralSearchForm(JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Feature.Services.Search.ISearchDomainContext searchDomainContext, JetBrains.ReSharper.Psi.Services.StructuralSearch.StructuralSearchEngine engine, JetBrains.ReSharper.Psi.PsiProjectFileTypeCoordinator psiProjectFileTypeCoordinator, [JetBrains.Annotations.CanBeNullAttribute()] System.Windows.Forms.IWin32Window mainwin, JetBrains.Application.IApplicationDescriptor product, JetBrains.Threading.IThreading invocator, JetBrains.CommonControls.Validation.FormValidators formValidators, JetBrains.Application.Interop.NativeHook.IWindowsHookManager windowsHookManager, JetBrains.TextControl.DocumentMarkup.IDocumentMarkupManager documentMarkupManager, JetBrains.ReSharper.Features.StructuralSearch.Placeholders.PlaceholderEditorManager placeholderEditorManager, JetBrains.UI.Application.IUIApplication environment, bool showRecentSearch = True, bool isShownFromOptions = False) { }
        public bool CanSwitchModes { set; }
        public JetBrains.ReSharper.Psi.PsiLanguageType Language { get; set; }
        protected JetBrains.ProjectModel.ProjectFileType LanguageProjectFileType { get; }
        public string OkButtonTextFind { get; set; }
        public string OkButtonTextReplace { get; set; }
        public JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralSearchPattern Pattern { get; set; }
        public bool ReplaceMode { get; set; }
        public string SaveButtonText { set; }
        public bool SaveButtonVisible { set; }
        public JetBrains.ReSharper.Features.StructuralSearch.UI.StructuralSearchFormSaveKind SaveKind { get; set; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Feature.Services.Search.NamedSearchDomain SelectedSearchDomain { get; }
        public JetBrains.ReSharper.Daemon.Severity Severity { get; set; }
        public bool ShowComments { set; }
        public bool ShowSecondaryControls { set; }
        public event System.ComponentModel.CancelEventHandler OkClick;
        public void AddReplaceErrorHighlighting(JetBrains.ReSharper.Psi.Services.StructuralSearch.IPatternLexerErrorResult error) { }
        public void AddSearchErrorHighlighting(JetBrains.ReSharper.Psi.Services.StructuralSearch.IPatternLexerErrorResult error) { }
        protected override void Dispose(bool disposing) { }
    }
    public enum StructuralSearchFormSaveKind
    {
        OVERWRITE = 0,
        COPY = 1,
    }
    public class StructuralSearchFormValidator : JetBrains.CommonControls.Validation.ControlValidator
    {
        public StructuralSearchFormValidator(JetBrains.ReSharper.Features.StructuralSearch.UI.StructuralSearchForm structuralSearchForm, System.Windows.Forms.Control control, JetBrains.Application.Interop.NativeHook.IWindowsHookManager windowsHookManager, JetBrains.UI.Application.IUIApplication environment) { }
        public override void Update() { }
    }
}