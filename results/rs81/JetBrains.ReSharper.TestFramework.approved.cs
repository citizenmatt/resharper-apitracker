[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]

namespace JetBrains.ReSharper.Daemon.Impl
{
    
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class DaemonTestImpl : JetBrains.ReSharper.Daemon.Impl.DaemonImpl
    {
        public DaemonTestImpl(
                    JetBrains.ProjectModel.ISolution solution, 
                    JetBrains.DataFlow.Lifetime lifetime, 
                    JetBrains.ReSharper.Psi.IPsiServices psiServices, 
                    JetBrains.DocumentManagers.DocumentManager documentManager, 
                    JetBrains.Application.IShellLocks locks, 
                    JetBrains.TextControl.ITextControlManager textControlManager, 
                    JetBrains.Application.ChangeManager changeManager, 
                    JetBrains.ReSharper.Daemon.Impl.DaemonStageManager daemonStageManager, 
                    JetBrains.ReSharper.Daemon.HighlightingSettingsManager highlightingSettingsManager, 
                    JetBrains.ReSharper.Psi.GeneratedCode.DaemonExcludedFilesManager excludedFilesManager, 
                    JetBrains.ReSharper.Daemon.Impl.SolutionAnalysisService solutionAnalysisService, 
                    JetBrains.TextControl.DocumentMarkup.IDocumentMarkupManager documentMarkupManager, 
                    JetBrains.ReSharper.Psi.AsyncCommitService asyncCommitService, 
                    JetBrains.ReSharper.Daemon.Impl.SolutionAnalysisIndicator solutionAnalysisIndicator, 
                    JetBrains.Application.Settings.ISettingsStore settingsStore, 
                    JetBrains.ReSharper.Daemon.IDaemonThread daemonThread, 
                    JetBrains.ProjectModel.Tasks.ISolutionLoadTasksScheduler scheduler, 
                    JetBrains.ReSharper.Daemon.Impl.DaemonAutoDisableStrategy daemonAutoDisableStrategy, 
                    JetBrains.DocumentManagers.Transactions.SolutionDocumentTransactionManager solutionDocumentTransactionManager, 
                    JetBrains.DocumentManagers.DocumentToProjectFileMappingStorage documentStorage) { }
        public override bool InterruptFlag { get; set; }
        protected override JetBrains.ReSharper.Daemon.Impl.VisibleDocumentDaemonProcess CreateDaemonForDocumentImpl(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
        protected override void OnBeforeAcquiringWriteLock(object sender, System.EventArgs e) { }
        protected override void OnPsiTransactionStarted() { }
        protected override void OnStagesChangedQueue() { }
        public void RunHighlight(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, JetBrains.DataFlow.Lifetime lifetime) { }
    }
    public class VisibleDocumentDaemonProcessTest : JetBrains.ReSharper.Daemon.Impl.VisibleDocumentDaemonProcess
    {
        public VisibleDocumentDaemonProcessTest(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, JetBrains.TextControl.DocumentMarkup.IDocumentMarkupManager documentMarkupManager, JetBrains.TextControl.ITextControlManager textControlManager, JetBrains.DocumentManagers.DocumentManager documentManager, JetBrains.ReSharper.Daemon.Impl.SolutionAnalysisService solutionAnalysisService, JetBrains.ReSharper.Daemon.HighlightingSettingsManager highlightingSettingsManager, JetBrains.Application.IShellLocks locks, JetBrains.DocumentManagers.Transactions.SolutionDocumentTransactionManager documentTransactionManager, JetBrains.DataFlow.Lifetime lifetime) { }
        protected override JetBrains.ReSharper.Daemon.Impl.VisibleDocumentDaemonProcess.Committer CreateCommitter() { }
        protected override void WaitForHighlightingsCommitter(JetBrains.ReSharper.Daemon.Impl.VisibleDocumentDaemonProcess.Committer committer) { }
        public class TextCommitter : JetBrains.ReSharper.Daemon.Impl.VisibleDocumentDaemonProcess.Committer
        {
            public TextCommitter(JetBrains.ReSharper.Daemon.Impl.VisibleDocumentDaemonProcess process, JetBrains.DataFlow.Lifetime lifetime, JetBrains.ReSharper.Daemon.Impl.DaemonImpl daemonImpl) { }
            public override void Dispose() { }
            protected override void QueueExecution() { }
        }
    }
}
namespace JetBrains.ReSharper.Daemon.Impl.Util
{
    
    [JetBrains.Application.ShellComponentAttribute()]
    public class LinqToolsAnalyzerEnablerForTests : JetBrains.ReSharper.Daemon.Util.LinqToolsAnalyzerEnabler
    {
        public override bool Enabled { get; }
        public void RunWithAnalyzerEnabled(System.Action action) { }
    }
}
namespace JetBrains.ReSharper.ExternalSources.Tests.Core
{
    
    [JetBrains.Application.ShellComponentAttribute()]
    public class DecompilerSettingsInTest
    {
        public DecompilerSettingsInTest(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.Settings.ISettingsStore settingsStore) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class TemporaryExternalSourcesProvider : JetBrains.ReSharper.Feature.Services.ExternalSources.Core.IExternalSourcesProvider
    {
        public TemporaryExternalSourcesProvider(JetBrains.ReSharper.Feature.Services.ExternalSources.Core.IExternalSourcesMappingChangeManager mappingChangeManager) { }
        public string Id { get; }
        public string PresentableShortName { get; }
        public int Priority { get; }
        public System.IDisposable AddMapping(JetBrains.Util.FileSystemPath file, JetBrains.ProjectModel.Model2.Assemblies.Interfaces.IAssembly assembly) { }
        public void ChangeMapping(JetBrains.Util.FileSystemPath file, JetBrains.ProjectModel.Model2.Assemblies.Interfaces.IAssembly assembly) { }
        public bool IsApplicable(JetBrains.ReSharper.Feature.Services.Navigation.CompiledElementNavigationInfo navigationInfo) { }
        public JetBrains.ReSharper.Feature.Services.ExternalSources.Core.Impl.ExternalSourcesMapping MapFileToAssembly(JetBrains.Util.FileSystemPath file) { }
        public JetBrains.DataStructures.IReadOnlyCollection<JetBrains.ReSharper.Feature.Services.ExternalSources.Core.Impl.ExternalSourcesMapping> NavigateToSources(JetBrains.ReSharper.Psi.ICompiledElement compiledElement, JetBrains.Application.Progress.ITaskExecutor taskExecutor) { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class TestExternalSourcesFirstTimeNavigation : JetBrains.ReSharper.ExternalSources.ReSharperIntegration.ExternalSourcesFirstTimeNavigation
    {
        public TestExternalSourcesFirstTimeNavigation(JetBrains.ActionManagement.IActionManager actionManager, JetBrains.ActionManagement.IShortcutManager shortcutManager, JetBrains.Application.Settings.ISettingsStore settingsStore, JetBrains.Application.DataContext.DataContexts dataContexts) { }
        public override bool Execute() { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.ExternalSources.Tests
{
    
    [JetBrains.ReSharper.Psi.PsiComponentAttribute()]
    public class DeclaredElementBinderServiceTestImpl : JetBrains.ReSharper.Feature.Services.ExternalSources.Core.Impl.DeclaredElementBinderService
    {
        public DeclaredElementBinderServiceTestImpl(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ReSharper.Psi.Files.IPsiFiles psiFiles, JetBrains.ReSharper.Psi.ILanguageManager languageManager) { }
        public JetBrains.DataFlow.IProperty<bool> FailOnUnresolvedSymbols { get; }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class TestPdbSettings
    {
        public TestPdbSettings(JetBrains.Application.Settings.ISettingsStore settingsStore, JetBrains.Application.DataContext.DataContexts dataContexts) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.Lookup
{
    
    [JetBrains.Application.ShellComponentAttribute()]
    public class TestLookupWindowManager : JetBrains.ReSharper.Feature.Services.Lookup.ILookupWindowManager, JetBrains.TestShell.Components.ITearDown, System.IDisposable
    {
        protected bool myIsExternalDocumentChangeAllowed;
        public TestLookupWindowManager(JetBrains.Application.Settings.ISettingsStore settingsStore, JetBrains.UI.CommonControls.Fonts.FontsManager fontsManager, JetBrains.UI.Components.Theming.IColorThemeManager themeManager, JetBrains.Threading.IThreading threading) { }
        public virtual JetBrains.ReSharper.Feature.Services.Lookup.ILookup CurrentLookup { get; set; }
        public bool Enabled { get; set; }
        public static JetBrains.ReSharper.Feature.Services.Lookup.TestLookupWindowManager Instance { get; }
        public virtual bool IsExternalDocumentChangeAllowed { get; }
        public bool IsShowing { get; }
        public JetBrains.Application.Settings.ISettingsStore SettingsStore { get; }
        public event System.EventHandler AfterLookupWindowShown;
        public event System.EventHandler<JetBrains.DataFlow.EventArgs<JetBrains.ReSharper.Feature.Services.Lookup.ILookup>> BeforeLookupWindowClosed;
        public event System.EventHandler BeforeLookupWindowShown;
        public event System.EventHandler LookupWindowClosed;
        public virtual JetBrains.ReSharper.Feature.Services.Lookup.ILookup CreateLookup(JetBrains.TextControl.ITextControl textControl, JetBrains.Util.TextRange textRange, JetBrains.ReSharper.Feature.Services.Lookup.ILookupItemsSource lookupItems, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Feature.Services.Lookup.LookupWindowOptions options) { }
        public void Dispose() { }
        public JetBrains.UI.Components.Theming.ColorTheme GetColorScheme() { }
        public virtual System.IDisposable GetExternalDocumentChangeCookie() { }
        public System.Drawing.Font GetLookupwindowFont(bool useCompletionVsFond) { }
        public virtual void HideLookup() { }
        public void HideProgressAnimation() { }
        public void ShowProgressAnimation() { }
        public void TearDown() { }
        public void UpdateLookup(JetBrains.ReSharper.Feature.Services.Lookup.ILookup lookup, JetBrains.ReSharper.Feature.Services.Lookup.ILookupItemsSource lookupItems, JetBrains.ReSharper.Feature.Services.Lookup.LookupWindowOptions windowOptions, JetBrains.Util.TextRange textRange, JetBrains.UI.RichText.RichTextBlock[] completionType) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.QuickDoc.Render.Tests
{
    
    [JetBrains.Application.ShellComponentAttribute()]
    public class XmlDocImagesProviderTestImpl : JetBrains.ReSharper.Feature.Services.QuickDoc.Render.XmlDocImagesProvider
    {
        public override JetBrains.Util.FileSystemPath InlineCollapsPath { get; }
        public override string InlineCollapsPathJS { get; }
        public override JetBrains.Util.FileSystemPath InlineExpandPath { get; }
        public override string InlineExpandPathJS { get; }
    }
}
namespace JetBrains.ReSharper.Feature.Services.Tests.CSharp.FeatureServices.ContextHighlighters
{
    
    [JetBrains.Application.ShellComponentAttribute()]
    public class CaretDependentFeaturesUtilComponentWithMockingMode : JetBrains.ReSharper.Daemon.CaretDependentFeatures.CaretDependentFeaturesUtilComponent
    {
        public CaretDependentFeaturesUtilComponentWithMockingMode(JetBrains.TextControl.DocumentMarkup.IDocumentMarkupManager documentMarkupManager, JetBrains.UI.Tooltips.ITooltipManager tooltipManager, JetBrains.Application.IShellLocks shellLocks, JetBrains.ActionManagement.IActionManager actionManager, JetBrains.UI.Application.IUIApplication environment) { }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Feature.Services.ContextHighlighters.MatchingHighlightingsConsumer.HighlightingIdAndDocumentRange> CollectedHighlightings { get; }
        public System.Collections.Generic.IDictionary<JetBrains.DocumentModel.DocumentRange, string> InvisibleBraceHints { get; }
        public bool IsMockingMode { set; }
        public override void HighlightForLifetime(JetBrains.DocumentModel.DocumentRange documentRange, string highlightingId, JetBrains.DataFlow.Lifetime caretDependentStuffLifetime) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.Tests.CSharp.FeatureServices.Navigation
{
    
    public class TestDeclaredElementNavigationService : JetBrains.ReSharper.Feature.Services.Navigation.DeclaredElementNavigation.DeclaredElementNavigationService
    {
        public TestDeclaredElementNavigationService(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ReSharper.Feature.Services.SolutionFeaturePartsContainer container, JetBrains.UI.Application.IUIApplication environment, JetBrains.Application.IShellLocks shellLocks) { }
        public override void Navigate(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, JetBrains.UI.PopupWindowManager.PopupWindowContextSource windowContext, bool transferFocus, System.Nullable<JetBrains.ReSharper.Feature.Services.Occurences.OccurencePresentationOptions> options = null, JetBrains.IDE.TabOptions tabOptions = 2) { }
        public void SetWriter(System.IO.TextWriter textWriter) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class TestNavigationManagerImpl : JetBrains.ReSharper.Feature.Services.Navigation.NavigationManagerImpl
    {
        public TestNavigationManagerImpl(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.IShellLocks shellLocks, JetBrains.DocumentManagers.DocumentManager documentManager, JetBrains.TextControl.ITextControlManager textControlManager, JetBrains.IDE.EditorManager editorManager, JetBrains.ReSharper.Feature.Services.Navigation.CustomHighlighting.CustomHighlightingManager customHighlightingManager, JetBrains.UI.PopupWindowManager.MainWindowPopupWindowContext mainWindowPopupWindowContext, JetBrains.ReSharper.Feature.Services.SolutionFeaturePartsContainer featurePartsContainer, JetBrains.UI.Application.IUIApplication environment) { }
        public void SetWriter(System.IO.TextWriter writer) { }
        protected override bool ShowMenu(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.Navigation.Navigation.INavigationPoint> points, JetBrains.ReSharper.Feature.Services.Navigation.NavigationOptions options) { }
        protected override void SynchronizeToCaret() { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class TestOccurencePopupMenu : JetBrains.ReSharper.Feature.Services.Occurences.Presentation.OccurencePopupMenu
    {
        public TestOccurencePopupMenu(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.IShellLocks locks, JetBrains.DataFlow.Lifetime lifetime) { }
        public void SetHost(JetBrains.ReSharper.Features.Common.Occurences.ExecutionHosting.INavigationExecutionHost host) { }
        public override void ShowMenuGlobal(string title, bool skipMenuIfSingleEnabled, System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.Navigation.Search.IOccurence> items, JetBrains.ReSharper.Feature.Services.Navigation.NavigationOptions options, JetBrains.ReSharper.Feature.Services.Occurences.OccurencePresentationOptions presentationOptions, System.Func<JetBrains.ReSharper.Feature.Services.Tree.OccurenceBrowserDescriptor> descriptorBuilder) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class TestReferencedCodeSearcher : JetBrains.ReSharper.Feature.Services.ReferencedCode.ReferencedCodeSearcher
    {
        public TestReferencedCodeSearcher(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.IShellLocks locks, JetBrains.Application.Threading.Tasks.ITaskHost tasks, JetBrains.ReSharper.Psi.Modules.AssemblyPsiModuleFactory assemblyPsiModuleFactory, JetBrains.Application.Env.RunsProducts.ProductConfigurations configuration) { }
    }
}
namespace JetBrains.ReSharper.Features.Intellisense.ParameterInfo.Test
{
    
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class TestParameterInfoPopupController : JetBrains.ReSharper.Feature.Services.ParameterInfo.ParameterInfoPopupController
    {
        public TestParameterInfoPopupController(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ReSharper.Psi.ILanguageManager languageManager, JetBrains.ActionManagement.IActionManager actionManager) { }
        public bool IsEditorParameterInfoShown { get; }
        public bool IsParameterInfoAvailableInCurrentContext { get; }
        public override bool IsParameterInfoShownInCurrentContext { get; }
        public override bool SupportsSignatureSwitching { get; }
        public override JetBrains.ReSharper.Feature.Services.ParameterInfo.IParameterInfoContext CreateContext(JetBrains.ProjectModel.ISolution solution, JetBrains.DocumentModel.IDocument document, int caretOffset, int expectedLParenthOffset) { }
        public override void EmulateTyping(char c, JetBrains.TextControl.ITextControl textControl) { }
        public override bool IsParameterInfoAvailableFast(JetBrains.Application.DataContext.IDataContext context) { }
        public override void MoveParameterInfoOnTop() { }
        public override void PopupParameterInfo(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl, int offset, JetBrains.ReSharper.Psi.IDeclaredElement signature) { }
        public override void PopupParameterInfo(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ReSharper.Feature.Services.ParameterInfo.IParameterInfoProvider provider, JetBrains.TextControl.ITextControl textControl) { }
        public override void PopupParameterInfo(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        public override void PopupParameterInfo(JetBrains.Application.DataContext.IDataContext context) { }
        public override void ShowDocForNextSignature() { }
        public override void ShowDocForPreviousSignature() { }
    }
}
namespace JetBrains.ReSharper.FeaturesTests.Tips
{
    
    [JetBrains.Application.ShellComponentAttribute()]
    public class TestTipsManager : JetBrains.ReSharper.Features.Environment.Tips.TipsManagerImpl
    {
        public TestTipsManager(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.Env.RunsProducts.ProductConfigurations productConfigurations, JetBrains.Application.IApplicationDescriptor product, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.UI.Application.IMainWindow mainwin, JetBrains.Threading.IThreading invocator, JetBrains.Application.Settings.ISettingsStore settingsStore, JetBrains.Application.DataContext.DataContexts dataContexts, JetBrains.Application.Env.Components.ProductSettingsLocation productSettingsLocation) { }
        public override void ShowTips(bool onStartup) { }
    }
}
namespace JetBrains.ReSharper.Psi.Xaml.Test
{
    
    public class static XamlLibrariesUtil
    {
        public static string[] GetDev10WorkflowLibraries() { }
        public static string[] GetSilverlight2Libraries() { }
        public static string[] GetSilverlight3Libraries() { }
        public static string[] GetSilverlight4Libraries() { }
        public static string[] GetSilverlight5Libraries() { }
        public static string[] GetWindowPhone70Libraries() { }
        public static string[] GetWindowPhone71Libraries() { }
        public static string[] GetWPF30Libraries() { }
        public static string[] GetWPF40Libraries() { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class XamlTestLanguageLevelProvider : JetBrains.ReSharper.Psi.Xaml.Impl.XamlLanguageLevelProvider
    {
        public XamlTestLanguageLevelProvider() { }
        public JetBrains.ReSharper.Psi.Xaml.Impl.XamlLanguageLevel LanguageLevel { get; set; }
        public override JetBrains.ReSharper.Psi.Xaml.Impl.XamlLanguageLevel GetLanguageLevel(JetBrains.ProjectModel.IProjectItem projectItem) { }
    }
}
namespace JetBrains.ReSharper.PsiTests.Asp.PsiModule
{
    
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class TestWebAppPsiModuleProvider : JetBrains.ReSharper.Psi.Web.Impl.PsiModules.WebApp.WebAppPsiModuleProvider
    {
        public TestWebAppPsiModuleProvider(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Web.Impl.PsiModules.WebApp.IWebAppCommonReferenceProviderFactory> referenceProviders, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Web.Impl.PsiModules.WebApp.IWebAppPsiModuleHandlerHelperFactory> helperProviders) { }
        protected override JetBrains.ReSharper.Psi.Web.Impl.PsiModules.WebApp.WebAppPsiModuleHandler CreateWebAppPsiModuleHandler(JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IProject project, JetBrains.Application.IShellLocks locks, JetBrains.ReSharper.Psi.Web.PsiModules.IAspFileDataCache aspFileDataCache, JetBrains.ReSharper.Psi.Web.Cache.IWebConfigCache webConfigCache, JetBrains.Application.ChangeManager changeManager, JetBrains.ReSharper.Psi.Web.PsiModules.IWebAssemblyReferenceFactory assemblyReferenceFactory) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class TestWebsitePsiModuleProvider : JetBrains.ReSharper.Psi.Web.Impl.PsiModules.Website.WebsitePsiModuleProvider
    {
        public TestWebsitePsiModuleProvider(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Web.Impl.PsiModules.Website.IWebsiteCommonReferenceProviderFactory> referenceProviders, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Web.Impl.PsiModules.Website.IWebsitePsiModuleHandlerHelperFactory> helperProviders, JetBrains.ReSharper.Psi.PsiProjectFileTypeCoordinator psiProjectFileTypeCoordinator) { }
        protected override JetBrains.ReSharper.Psi.Web.Impl.PsiModules.Website.WebsitePsiModuleHandler CreateWebsitePsiModuleHandler(JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IProject project, JetBrains.Application.IShellLocks locks, JetBrains.ReSharper.Psi.Web.PsiModules.IAspFileDataCache aspFileDataCache, JetBrains.ReSharper.Psi.Web.Cache.IWebConfigCache webConfigCache, JetBrains.Application.ChangeManager changeManager, JetBrains.ReSharper.Psi.Web.PsiModules.IWebAssemblyReferenceFactory assemblyReferenceFactory) { }
    }
}
namespace JetBrains.ReSharper.PsiTests.Asp
{
    
    public class TestAsp45Attribute : JetBrains.ReSharper.PsiTests.Asp.TestAspAttribute, JetBrains.ReSharper.TestFramework.ITestPlatformProvider
    {
        public TestAsp45Attribute(params string[] references) { }
        public JetBrains.ProjectModel.PlatformID GetPlatformId() { }
        public override System.Collections.Generic.IEnumerable<string> GetReferences(JetBrains.ProjectModel.PlatformID platformID) { }
    }
    public class TestAspAttribute : JetBrains.ReSharper.TestFramework.TestReferencesAttribute
    {
        public TestAspAttribute(params string[] references) { }
        public override System.Collections.Generic.IEnumerable<string> GetReferences(JetBrains.ProjectModel.PlatformID platformID) { }
    }
    public class TestExtendedAsp45Attribute : JetBrains.ReSharper.PsiTests.Asp.TestExtendedAspAttribute, JetBrains.ReSharper.TestFramework.ITestPlatformProvider
    {
        public TestExtendedAsp45Attribute(params string[] references) { }
        public JetBrains.ProjectModel.PlatformID GetPlatformId() { }
        public override System.Collections.Generic.IEnumerable<string> GetReferences(JetBrains.ProjectModel.PlatformID platformID) { }
    }
    public class TestExtendedAspAttribute : JetBrains.ReSharper.PsiTests.Asp.TestAspAttribute
    {
        public TestExtendedAspAttribute(params string[] references) { }
        public override System.Collections.Generic.IEnumerable<string> GetReferences(JetBrains.ProjectModel.PlatformID platformID) { }
    }
    [JetBrains.ReSharper.TestFramework.IncludeMsCorLibAttribute()]
    public abstract class WebReferenceTestBase : JetBrains.ReSharper.TestFramework.ReferenceTestBase
    {
        public override string ProjectBasePath { get; }
        protected override void AfterTestFinished(JetBrains.ProjectModel.IProject testProject) { }
        protected override void BeforeTestStarted(JetBrains.ProjectModel.IProjectFile projectFile) { }
        protected virtual bool DumpLine([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
        protected override string Format(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution, JetBrains.ReSharper.Psi.PsiLanguageType languageType, JetBrains.ReSharper.Psi.DeclaredElementPresenterStyle presenter, JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        protected override JetBrains.DocumentModel.DocumentRange GetDocumentRange(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public override JetBrains.ProjectModel.Properties.IProjectProperties GetProjectProperties(JetBrains.ProjectModel.PlatformID platformId, System.Collections.Generic.ICollection<System.Guid> flavours) { }
    }
}
namespace JetBrains.ReSharper.PsiTests.Lexing
{
    
    [NUnit.Framework.CategoryAttribute("Lexer")]
    public abstract class LexerTestBase : JetBrains.ReSharper.TestFramework.BaseTestWithSingleProject
    {
        protected const string test10dot = "test10";
        protected const string test1dot = "test1";
        protected const string test2dot = "test2";
        protected const string test3dot = "test3";
        protected const string test4dot = "test4";
        protected const string test5dot = "test5";
        protected const string test6dot = "test6";
        protected const string test7dot = "test7";
        protected const string test8dot = "test8";
        protected const string test9dot = "test9";
        protected const string testPPdot = "testPP";
        protected const string unicodeTest1 = "testUnicode1";
        protected const string unicodeTest2 = "testUnicode2";
        protected const string unicodeTest3 = "testUnicode3";
        protected override string RelativeTestDataPath { get; }
        protected virtual JetBrains.ReSharper.Psi.Parsing.ILexer CreateLexer(System.IO.StreamReader sr) { }
        protected virtual JetBrains.ReSharper.Psi.Parsing.ILexer CreateLexer(JetBrains.ProjectModel.IProjectFile projectFile, System.IO.StreamReader sr) { }
        protected override void DoOneTest(string testName) { }
        protected override void DoTest(JetBrains.ProjectModel.IProject testProject) { }
        protected void DoTestFile(string filename, System.Text.Encoding encoding = null) { }
        protected virtual void WriteToken(System.IO.TextWriter writer, JetBrains.ReSharper.Psi.Parsing.ILexer lexer) { }
    }
}
namespace JetBrains.ReSharper.PsiTests.parsing
{
    
    [NUnit.Framework.CategoryAttribute("Parser")]
    public abstract class ParserTestBase : JetBrains.ReSharper.TestFramework.BaseTestWithTextControl
    {
        protected override void DoTest(JetBrains.ProjectModel.IProject testProject) { }
    }
}
namespace JetBrains.ReSharper.PsiTests
{
    
    [JetBrains.ReSharper.Psi.PsiComponentAttribute()]
    public class TestGeneratedDocumentsManager : JetBrains.ReSharper.Psi.Files.GeneratedDocumentsManager
    {
        public TestGeneratedDocumentsManager(JetBrains.DataFlow.Lifetime lifetime, JetBrains.DocumentModel.IInMemoryDocumentFactory documentFactory, JetBrains.ProjectModel.FileTypes.IProjectFileTypeServices projectFileTypeServices, JetBrains.DocumentModel.Transactions.IDocumentTransactionManager transactionManager) { }
        public override void AssertGeneratedFilesValid(JetBrains.ReSharper.Psi.IPsiSourceFile psiSourceFile) { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class TestIdGenerator : JetBrains.ReSharper.Psi.Asp.Impl.PureUniqueIdGenerator
    {
        public TestIdGenerator() { }
        public override string GenerateId() { }
        public override void Reset() { }
    }
}
namespace JetBrains.ReSharper.PsiTests.WinRT
{
    
    public class TestNetCore45Attribute : JetBrains.ReSharper.TestFramework.TestReferencesAttribute, JetBrains.ReSharper.TestFramework.ITestMsCorLibFlagProvider, JetBrains.ReSharper.TestFramework.ITestPlatformProvider
    {
        public TestNetCore45Attribute(params string[] references) { }
        public JetBrains.ReSharper.TestFramework.ReferenceDlls GetMsCorLibFlag() { }
        public JetBrains.ProjectModel.PlatformID GetPlatformId() { }
        public override System.Collections.Generic.IEnumerable<string> GetReferences(JetBrains.ProjectModel.PlatformID platformID) { }
    }
    public class TestNetCore45WinRTComponentAttribute : JetBrains.ReSharper.PsiTests.WinRT.TestNetCore45Attribute, JetBrains.ReSharper.TestFramework.ITestSdkReferencesProvider
    {
        public TestNetCore45WinRTComponentAttribute(params string[] references) { }
    }
}
namespace JetBrains.ReSharper.PsiTests.Xaml
{
    
    public class TestDev10WorkflowAttribute : JetBrains.ReSharper.TestFramework.TestReferencesAttribute, JetBrains.ReSharper.TestFramework.ITestPlatformProvider
    {
        public TestDev10WorkflowAttribute(params string[] references) { }
        public JetBrains.ProjectModel.PlatformID GetPlatformId() { }
        public override System.Collections.Generic.IEnumerable<string> GetReferences(JetBrains.ProjectModel.PlatformID platformID) { }
    }
    public class TestSilverlight2Attribute : JetBrains.ReSharper.TestFramework.TestReferencesAttribute, JetBrains.ReSharper.TestFramework.ITestMsCorLibFlagProvider, JetBrains.ReSharper.TestFramework.ITestPlatformProvider
    {
        public TestSilverlight2Attribute(params string[] references) { }
        public JetBrains.ReSharper.TestFramework.ReferenceDlls GetMsCorLibFlag() { }
        public JetBrains.ProjectModel.PlatformID GetPlatformId() { }
        public override System.Collections.Generic.IEnumerable<string> GetReferences(JetBrains.ProjectModel.PlatformID platformID) { }
    }
    public class TestSilverlight3Attribute : JetBrains.ReSharper.TestFramework.TestReferencesAttribute, JetBrains.ReSharper.TestFramework.ITestPlatformProvider
    {
        public TestSilverlight3Attribute(params string[] references) { }
        public JetBrains.ProjectModel.PlatformID GetPlatformId() { }
        public override System.Collections.Generic.IEnumerable<string> GetReferences(JetBrains.ProjectModel.PlatformID platformID) { }
    }
    public class TestSilverlight4Attribute : JetBrains.ReSharper.TestFramework.TestReferencesAttribute, JetBrains.ReSharper.TestFramework.ITestMsCorLibFlagProvider, JetBrains.ReSharper.TestFramework.ITestPlatformProvider
    {
        public TestSilverlight4Attribute(params string[] references) { }
        public JetBrains.ReSharper.TestFramework.ReferenceDlls GetMsCorLibFlag() { }
        public JetBrains.ProjectModel.PlatformID GetPlatformId() { }
        public override System.Collections.Generic.IEnumerable<string> GetReferences(JetBrains.ProjectModel.PlatformID platformID) { }
    }
    public class TestSilverlight5Attribute : JetBrains.ReSharper.TestFramework.TestReferencesAttribute, JetBrains.ReSharper.TestFramework.ITestMsCorLibFlagProvider, JetBrains.ReSharper.TestFramework.ITestPlatformProvider
    {
        public TestSilverlight5Attribute(params string[] references) { }
        public JetBrains.ReSharper.TestFramework.ReferenceDlls GetMsCorLibFlag() { }
        public JetBrains.ProjectModel.PlatformID GetPlatformId() { }
        public override System.Collections.Generic.IEnumerable<string> GetReferences(JetBrains.ProjectModel.PlatformID platformID) { }
    }
    public class TestWindowsPhone70Attribute : JetBrains.ReSharper.TestFramework.TestReferencesAttribute, JetBrains.ReSharper.TestFramework.ITestFlavoursProvider, JetBrains.ReSharper.TestFramework.ITestPlatformProvider
    {
        public TestWindowsPhone70Attribute(params string[] references) { }
        public JetBrains.ProjectModel.PlatformID GetPlatformId() { }
        public System.Guid[] GetProjectTypeGuids() { }
        public override System.Collections.Generic.IEnumerable<string> GetReferences(JetBrains.ProjectModel.PlatformID platformID) { }
    }
    public class TestWindowsPhone71Attribute : JetBrains.ReSharper.TestFramework.TestReferencesAttribute, JetBrains.ReSharper.TestFramework.ITestFlavoursProvider, JetBrains.ReSharper.TestFramework.ITestPlatformProvider
    {
        public TestWindowsPhone71Attribute(params string[] references) { }
        public JetBrains.ProjectModel.PlatformID GetPlatformId() { }
        public System.Guid[] GetProjectTypeGuids() { }
        public override System.Collections.Generic.IEnumerable<string> GetReferences(JetBrains.ProjectModel.PlatformID platformID) { }
    }
    public class TestWPF30Attribute : JetBrains.ReSharper.TestFramework.TestReferencesAttribute, JetBrains.ReSharper.TestFramework.ITestFlavoursProvider, JetBrains.ReSharper.TestFramework.ITestPlatformProvider
    {
        public TestWPF30Attribute(params string[] references) { }
        public JetBrains.ProjectModel.PlatformID GetPlatformId() { }
        public System.Guid[] GetProjectTypeGuids() { }
        public override System.Collections.Generic.IEnumerable<string> GetReferences(JetBrains.ProjectModel.PlatformID platformID) { }
    }
    public class TestWPF40Attribute : JetBrains.ReSharper.TestFramework.TestReferencesAttribute, JetBrains.ReSharper.TestFramework.ITestPlatformProvider
    {
        public TestWPF40Attribute(params string[] references) { }
        public JetBrains.ProjectModel.PlatformID GetPlatformId() { }
        public override System.Collections.Generic.IEnumerable<string> GetReferences(JetBrains.ProjectModel.PlatformID platformID) { }
    }
    public class TestWPF45Attribute : JetBrains.ReSharper.TestFramework.TestReferencesAttribute, JetBrains.ReSharper.TestFramework.ITestPlatformProvider
    {
        public TestWPF45Attribute(params string[] references) { }
        public JetBrains.ProjectModel.PlatformID GetPlatformId() { }
        public override System.Collections.Generic.IEnumerable<string> GetReferences(JetBrains.ProjectModel.PlatformID platformID) { }
    }
}
namespace JetBrains.ReSharper.TestFramework
{
    
    public class AddAssembliesCookie : System.IDisposable
    {
        public AddAssembliesCookie(JetBrains.ProjectModel.IProject project, params string[] assemblyNames) { }
        public void Dispose() { }
    }
    public class AssembliesWithTestsReSharperTest
    {
        protected string AllAssembliesResourceName { get; }
        protected System.Reflection.Assembly ConfigurationAssembly { get; }
        [NUnit.Framework.TestAttribute()]
        public void TestAssemblies() { }
        [NUnit.Framework.TestAttribute()]
        public void TestAssembliesCLR4() { }
        [NUnit.Framework.TestAttribute()]
        public void TestWrongNUnitVersion() { }
    }
    public class static BaseTestEx
    {
        public static JetBrains.ReSharper.Psi.ILanguageManager GetLanguageManager([JetBrains.Annotations.NotNullAttribute()] this JetBrains.TestShell.Infra.BaseTest test) { }
        public static JetBrains.ReSharper.Psi.ILanguages GetLanguages([JetBrains.Annotations.NotNullAttribute()] this JetBrains.TestShell.Infra.BaseTest test) { }
    }
    public abstract class BaseTestWithExistingSolution : JetBrains.ReSharper.TestFramework.BaseTestWithSolution
    {
        protected virtual JetBrains.Util.FileSystemPath ExistingSolutionFilePath { get; }
        protected override void CleanSolution() { }
        protected void DoTestSolution(JetBrains.Util.FileSystemPath solutionFilePath, System.Action<JetBrains.DataFlow.Lifetime, JetBrains.ProjectModel.ISolution> testAction) { }
        protected override JetBrains.ProjectModel.ISolution InitSolution(JetBrains.ReSharper.TestFramework.BaseTestWithSolution.TestSolutionConfiguration testSolutionConfiguration, JetBrains.TestFramework.ProjectModel.ReuseSolutionInTestsComponent reuseSolutionInTestsComponent) { }
        protected virtual void PreprocessOpenSolution(JetBrains.ProjectModel.Impl.SolutionElement existingSolution) { }
    }
    public abstract class BaseTestWithSingleProject : JetBrains.ReSharper.TestFramework.BaseTestWithSolution
    {
        public const string JETBRAINS_ANNOTATIONS_DLL_PATH = "%PRODUCT%\\JetBrains.Annotations.dll";
        protected JetBrains.ProjectModel.IProject Project { get; }
        protected virtual System.Guid ProjectGuid { get; }
        protected virtual string ProjectName { get; }
        protected JetBrains.ReSharper.TestFramework.ReferenceDlls ReferencesMsCorLib { get; }
        protected virtual string SolutionFileName { get; }
        protected void CheckDocument([JetBrains.Annotations.NotNullAttribute()] JetBrains.DocumentModel.IDocument document) { }
        protected virtual void CheckProject(JetBrains.ProjectModel.IProject project, params JetBrains.ProjectModel.IProjectFile[] filesToExclude) { }
        protected virtual void CheckProjectFile(JetBrains.ProjectModel.IProjectFile projectItem) { }
        protected override void CloseSolution() { }
        protected JetBrains.Util.Pair<JetBrains.ProjectModel.Update.IProjectDescriptor, System.Collections.Generic.ICollection<JetBrains.Util.Pair<JetBrains.ProjectModel.Update.IProjectReferenceDescriptor, JetBrains.ProjectModel.Update.IProjectReferenceProperties>>> CreateProjectDescriptor(string projectName, System.Collections.Generic.ICollection<JetBrains.Util.FileSystemPath> absoluteFileSet, System.Collections.Generic.IEnumerable<string> libraries, JetBrains.ReSharper.TestFramework.ReferenceDlls referenceMsCorLib, System.Collections.Generic.ICollection<string> sdkReferences) { }
        protected JetBrains.Util.Pair<JetBrains.ProjectModel.Update.IProjectDescriptor, System.Collections.Generic.ICollection<JetBrains.Util.Pair<JetBrains.ProjectModel.Update.IProjectReferenceDescriptor, JetBrains.ProjectModel.Update.IProjectReferenceProperties>>> CreateProjectDescriptor(string projectName, string outputAssemblyName, System.Collections.Generic.ICollection<JetBrains.Util.FileSystemPath> absoluteFileSet, System.Collections.Generic.IEnumerable<string> libraries, JetBrains.ReSharper.TestFramework.ReferenceDlls referenceMsCorLib, System.Collections.Generic.ICollection<string> sdkReferences) { }
        [JetBrains.Annotations.NotNullAttribute()]
        protected virtual JetBrains.ReSharper.TestFramework.BaseTestWithSolution.TestSolutionConfiguration CreateSolutionConfiguration(JetBrains.ReSharper.TestFramework.ReferenceDlls referenceMsCorLib, [JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IEnumerable<string> libraries, [JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IEnumerable<string> fileSet, [JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.ICollection<string> sdkReferences) { }
        protected override void DoOneTest(string testName) { }
        protected virtual void DoTest(JetBrains.ProjectModel.IProject testProject) { }
        protected override void DoTest() { }
        protected virtual void DoTestSolution(params string[] fileSet) { }
        protected void ExecuteWithGold(JetBrains.DocumentModel.IDocument document, System.Action<System.IO.TextWriter> test) { }
        protected virtual JetBrains.ProjectModel.Properties.IProjectProperties FixProjectProperties(JetBrains.ProjectModel.Properties.IProjectProperties projectProperties, string outputAssemblyName) { }
        protected JetBrains.ProjectModel.IProjectFile GetProjectFile(JetBrains.Util.FileSystemPath fileName) { }
        protected JetBrains.ProjectModel.IProjectFile GetProjectFile(string fileName) { }
        protected virtual System.Collections.Generic.IEnumerable<string> GetReferencedAssemblies() { }
        protected virtual string[] GetSdkReferences() { }
        protected JetBrains.ProjectModel.IProject PrepareSingleProject([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.ISolution solution) { }
        protected void WithSingleProject([JetBrains.Annotations.NotNullAttribute()] string filename, [JetBrains.Annotations.NotNullAttribute()] System.Action<JetBrains.DataFlow.Lifetime, JetBrains.ProjectModel.ISolution, JetBrains.ProjectModel.IProject> F) { }
        protected void WithSingleProject([JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IEnumerable<string> filenames, [JetBrains.Annotations.NotNullAttribute()] System.Action<JetBrains.DataFlow.Lifetime, JetBrains.ProjectModel.ISolution, JetBrains.ProjectModel.IProject> F) { }
    }
    public abstract class BaseTestWithSolution : JetBrains.TestShell.Infra.BaseTest, JetBrains.ReSharper.TestFramework.IBaseTest
    {
        protected virtual bool AllowFileSystemTracker { get; }
        protected System.Func<JetBrains.ProjectModel.ISolution, System.IDisposable> ExecuteBeforeTest { set; }
        protected string Extension { get; }
        protected virtual JetBrains.ReSharper.TestFramework.BaseTestWithSolution.GuardAffinityFlags GuardAffinity { get; }
        protected JetBrains.ReSharper.Psi.ILanguageManager LanguageManager { get; }
        protected JetBrains.ReSharper.Psi.ILanguages Languages { get; }
        public virtual string ProjectBasePath { get; }
        public virtual System.Nullable<JetBrains.ProjectModel.ProjectOutputType> ProjectOutputType { get; }
        protected JetBrains.ProjectModel.ISolution Solution { get; }
        public string SolutionItemsBasePath { get; }
        protected virtual JetBrains.Util.FileSystemPath SolutionItemsBasePath2 { get; }
        protected virtual string TestName { get; }
        protected string TestName2 { get; }
        protected virtual void CleanSolution() { }
        protected virtual void CloseSolution() { }
        protected virtual void DoTest() { }
        protected void DoTestSolution(JetBrains.ReSharper.TestFramework.BaseTestWithSolution.TestSolutionConfiguration testSolutionConfiguration, System.Func<System.Action, System.Action> wrapper = null) { }
        protected void DoTestSolution(System.Action<JetBrains.DataFlow.Lifetime, JetBrains.ProjectModel.ISolution> test) { }
        protected void DoTestSolution(JetBrains.ReSharper.TestFramework.BaseTestWithSolution.TestSolutionConfiguration testSolutionConfiguration, System.Action<JetBrains.DataFlow.Lifetime, JetBrains.ProjectModel.ISolution> test) { }
        protected void DoTestSolution(JetBrains.ReSharper.TestFramework.BaseTestWithSolution.TestSolutionConfiguration testSolutionConfiguration, System.Action test) { }
        protected void ExecuteWithGold(JetBrains.ProjectModel.IProjectFile projectFile, [JetBrains.Annotations.InstantHandleAttribute()] System.Action<System.IO.TextWriter> test, bool caseSensitive = True, System.Text.Encoding encoding = null) { }
        protected void ExecuteWithGold(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, [JetBrains.Annotations.InstantHandleAttribute()] System.Action<System.IO.TextWriter> test, bool caseSensitive = True, System.Text.Encoding encoding = null) { }
        protected void ExecuteWithGold(JetBrains.Util.FileSystemPath testLocation, [JetBrains.Annotations.InstantHandleAttribute()] System.Action<System.IO.TextWriter> test, bool caseSensitive = True, System.Text.Encoding encoding = null) { }
        protected virtual System.Collections.Generic.ICollection<System.Guid> GetFlavours() { }
        protected virtual JetBrains.ProjectModel.PlatformID GetPlatformID() { }
        protected JetBrains.ProjectModel.PlatformInfo GetPlatformInfo() { }
        public virtual JetBrains.ProjectModel.Properties.IProjectProperties GetProjectProperties(JetBrains.ProjectModel.PlatformID platformId, System.Collections.Generic.ICollection<System.Guid> flavours) { }
        protected JetBrains.ProjectModel.ISolution InitSolution(JetBrains.ReSharper.TestFramework.BaseTestWithSolution.TestSolutionConfiguration testSolutionConfiguration) { }
        protected virtual JetBrains.ProjectModel.ISolution InitSolution(JetBrains.ReSharper.TestFramework.BaseTestWithSolution.TestSolutionConfiguration testSolutionConfiguration, JetBrains.TestFramework.ProjectModel.ReuseSolutionInTestsComponent reuseSolutionInTestsComponent) { }
        [JetBrains.Annotations.NotNullAttribute()]
        protected JetBrains.ProjectModel.ISolution PrepareSolution([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.TestFramework.BaseTestWithSolution.TestSolutionConfiguration solutionconfiguration) { }
        public static void SetDefaultProjectFilePropertiesAction(JetBrains.Util.FileSystemPath filePath, JetBrains.ProjectModel.Properties.IProjectFileProperties properties) { }
        protected System.IDisposable SetPlatformVersion(JetBrains.ProjectModel.PlatformID platformId) { }
        protected void SetPlatformVersion(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ProjectModel.PlatformID platformId) { }
        protected virtual void SetProjectFileProperties(JetBrains.Util.FileSystemPath fileSystemPath, JetBrains.ProjectModel.Properties.IProjectFileProperties projectFileProperties) { }
        protected class CustomProjectFilePropertiesCookie : System.IDisposable
        {
            public CustomProjectFilePropertiesCookie(JetBrains.ReSharper.TestFramework.BaseTestWithSolution test, System.Action<JetBrains.Util.FileSystemPath, JetBrains.ProjectModel.Properties.IProjectFileProperties> action) { }
            public void Dispose() { }
        }
        public enum GuardAffinityFlags
        {
            GuardedAndSync = 0,
            UnguardedAndAsync = 1,
        }
        protected class TestSolutionConfiguration
        {
            public TestSolutionConfiguration([JetBrains.Annotations.CanBeNullAttribute()] string solutionFileName, System.Action<JetBrains.Util.FileSystemPath, JetBrains.ProjectModel.Properties.IProjectFileProperties> setProjectFileProperties, JetBrains.Util.OneToListMap<JetBrains.ProjectModel.Update.IProjectDescriptor, JetBrains.Util.Pair<JetBrains.ProjectModel.Update.IProjectReferenceDescriptor, JetBrains.ProjectModel.Update.IProjectReferenceProperties>> projectDescriptors = null) { }
            public JetBrains.Util.OneToListMap<JetBrains.ProjectModel.Update.IProjectDescriptor, JetBrains.Util.Pair<JetBrains.ProjectModel.Update.IProjectReferenceDescriptor, JetBrains.ProjectModel.Update.IProjectReferenceProperties>> ProjectDescriptors { get; }
            public JetBrains.Util.FileSystemPath SolutionFilePath { get; }
            public virtual JetBrains.ProjectModel.ISolution CreateSolution(JetBrains.TestFramework.ProjectModel.TestSolutionManager solutionManager) { }
            public virtual void RefillSolution(JetBrains.ProjectModel.ISolution solution) { }
        }
    }
    public abstract class BaseTestWithTextControl : JetBrains.ReSharper.TestFramework.BaseTestWithTextControl<JetBrains.ReSharper.TestFramework.CaretPositionsProcessor>
    {
        protected override JetBrains.ReSharper.TestFramework.CaretPositionsProcessor CreateCaretPositionProcessor(JetBrains.Util.FileSystemPath temporaryDirectory) { }
    }
    public abstract class BaseTestWithTextControl<TCaretProcessor> : JetBrains.ReSharper.TestFramework.BaseTestWithSingleProject
        where TCaretProcessor : JetBrains.ReSharper.TestFramework.CaretPositionsProcessor
    {
        public const string CARET_STRING = "{caret}";
        protected BaseTestWithTextControl() { }
        protected TCaretProcessor CaretPositionsProcessor { get; }
        protected override JetBrains.Util.FileSystemPath SolutionItemsBasePath2 { get; }
        protected System.Collections.Generic.List<string> Tooltips { get; }
        protected void CheckTextControl([JetBrains.Annotations.NotNullAttribute()] JetBrains.TextControl.ITextControl textControl) { }
        protected override void CloseSolution() { }
        protected abstract TCaretProcessor CreateCaretPositionProcessor(JetBrains.Util.FileSystemPath temporaryDirectory);
        protected virtual void DoNamedTest(params string[] otherFiles) { }
        protected override void DoOneTest(string testName) { }
        protected override void DoTest() { }
        protected void DoTestAllFilesInFolder(string folder) { }
        protected virtual void DoTestFiles(params string[] testFiles) { }
        protected virtual void DoTestSolution(JetBrains.ReSharper.TestFramework.NamedPositionsProcessor positionsProcessor) { }
        protected void DumpRanges(JetBrains.ProjectModel.IProjectFile projectFile, System.IO.TextWriter w, bool dumpFiles = False) { }
        protected System.Action<System.IO.TextWriter> DumpTextControl(JetBrains.TextControl.ITextControl textControl) { }
        protected string DumpTextControlToString(JetBrains.TextControl.ITextControl textControl) { }
        public JetBrains.ReSharper.TestFramework.CaretMovement[] GetCaretMovements() { }
        public JetBrains.ReSharper.TestFramework.CaretPosition GetCaretPosition() { }
        protected JetBrains.ReSharper.TestFramework.CaretPosition[] GetCaretPositions() { }
        protected static JetBrains.ProjectModel.IProjectFile GetProjectFile(JetBrains.ProjectModel.IProject project, JetBrains.TextControl.ITextControl textControl) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        protected static string GetSetting([JetBrains.Annotations.NotNullAttribute()] JetBrains.TextControl.ITextControl textControl, string settingName) { }
        [JetBrains.Annotations.NotNullAttribute()]
        protected static System.Collections.Generic.ICollection<string> GetSettings([JetBrains.Annotations.NotNullAttribute()] string text, string settingPrefix) { }
        [JetBrains.Annotations.NotNullAttribute()]
        protected static System.Collections.Generic.ICollection<string> GetSettings([JetBrains.Annotations.NotNullAttribute()] System.Text.StringBuilder builder, string settingPrefix) { }
        [JetBrains.Annotations.NotNullAttribute()]
        protected static System.Collections.Generic.ICollection<string> GetSettings([JetBrains.Annotations.NotNullAttribute()] JetBrains.Text.IBuffer buffer, string settingPrefix) { }
        [JetBrains.Annotations.NotNullAttribute()]
        protected static System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<int, string>> GetSettings([JetBrains.Annotations.NotNullAttribute()] JetBrains.Text.IBuffer buffer, string settingPrefix, int number) { }
        protected virtual string[] ModifyTestFiles(string[] testFiles) { }
        protected JetBrains.TextControl.ITextControl OpenTextControl(JetBrains.ProjectModel.IProjectFile projectFile, System.Nullable<int> caretOffset = null) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.TextControl.ITextControl OpenTextControl([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IProject project, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.TestFramework.CaretPosition caretPosition) { }
        [JetBrains.Annotations.NotNullAttribute()]
        protected JetBrains.TextControl.ITextControl OpenTextControl([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IProject project) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.TextControl.ITextControl OpenTextControlAndSetSelection([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IProject project) { }
        protected void ReportError(JetBrains.DocumentModel.IDocument document, string message) { }
        public override void TestFixtureSetUp() { }
        public override void TestFixtureTearDown() { }
        public static void WriteCommentedText(System.IO.TextWriter w, string commentPrefix, string text) { }
    }
    public class CaretMovement
    {
        public CaretMovement(JetBrains.ReSharper.TestFramework.CaretPosition sourcePosition, JetBrains.ReSharper.TestFramework.CaretPosition targetPosition) { }
        public JetBrains.ReSharper.TestFramework.CaretPosition SourcePosition { get; }
        public JetBrains.ReSharper.TestFramework.CaretPosition TargetPosition { get; }
    }
    public class CaretPosition
    {
        public CaretPosition(JetBrains.Util.FileSystemPath fileName, int offset) { }
        public JetBrains.Util.FileSystemPath FileName { get; }
        public int Offset { get; }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
        public override string ToString() { }
    }
    public class CaretPositionsProcessor : JetBrains.ReSharper.TestFramework.NamedPositionsProcessor
    {
        public CaretPositionsProcessor(JetBrains.Util.FileSystemPath temporaryDirectory) { }
        public JetBrains.ReSharper.TestFramework.CaretPosition CaretPosition { get; set; }
        public JetBrains.ReSharper.TestFramework.CaretPosition SelectionEnd { get; }
        public JetBrains.ReSharper.TestFramework.CaretPosition SelectionStart { get; }
        public JetBrains.ReSharper.TestFramework.CaretMovement[] GetCaretMovements() { }
        public JetBrains.ReSharper.TestFramework.CaretPosition[] GetCaretPositions() { }
        protected override bool IsValidPositionName(string name) { }
        public override void Process(JetBrains.Util.FileSystemPath basePath, params string[] files) { }
        protected void ProcessPositionNames() { }
        public void ProcessWithPositionNames(JetBrains.Util.FileSystemPath basePath, params JetBrains.Util.FileSystemPath[] files) { }
    }
    public class DefaultNamespaceCookie : System.IDisposable
    {
        public DefaultNamespaceCookie(JetBrains.ProjectModel.IProject project, string @namespace) { }
        public void Dispose() { }
    }
    public class ExcludeMsCorLibAttribute : System.Attribute, JetBrains.ReSharper.TestFramework.ITestMsCorLibFlagProvider
    {
        public JetBrains.ReSharper.TestFramework.ReferenceDlls GetMsCorLibFlag() { }
    }
    public abstract class ExecuteActionTestBase : JetBrains.ReSharper.TestFramework.BaseTestWithTextControl
    {
        protected virtual string ActionId { get; }
        protected override void DoTest(JetBrains.ProjectModel.IProject testProject) { }
        protected virtual void ProcessSettings(string documentText, JetBrains.ProjectModel.IProject project) { }
    }
    public class ExpectedExceptionInsideSolutionAttribute : System.Attribute
    {
        public string ExpectedMessage { get; set; }
    }
    public interface IBaseTest
    {
        string ProjectBasePath { get; }
        System.Nullable<JetBrains.ProjectModel.ProjectOutputType> ProjectOutputType { get; }
        JetBrains.Application.Components.IComponentContainer ShellInstance { get; }
        string SolutionItemsBasePath { get; }
        JetBrains.ProjectModel.Properties.IProjectProperties GetProjectProperties(JetBrains.ProjectModel.PlatformID platformId, System.Collections.Generic.ICollection<System.Guid> flavours);
    }
    public class IncludeMsCorLibAttribute : System.Attribute, JetBrains.ReSharper.TestFramework.ITestMsCorLibFlagProvider
    {
        public JetBrains.ReSharper.TestFramework.ReferenceDlls GetMsCorLibFlag() { }
    }
    public interface ITestFlavoursProvider
    {
        bool Inherits { get; }
        System.Guid[] GetProjectTypeGuids();
    }
    public interface ITestLibraryReferencesProvider
    {
        bool Inherits { get; }
        System.Collections.Generic.IEnumerable<string> GetReferences(JetBrains.ProjectModel.PlatformID platformID);
    }
    public interface ITestMsCorLibFlagProvider
    {
        JetBrains.ReSharper.TestFramework.ReferenceDlls GetMsCorLibFlag();
    }
    public interface ITestPlatformProvider
    {
        JetBrains.ProjectModel.PlatformID GetPlatformId();
    }
    public interface ITestSdkReferencesProvider
    {
        bool Inherits { get; }
        System.Collections.Generic.IEnumerable<string> GetReferences();
    }
    public class NamedPositionsProcessor : System.IDisposable
    {
        public NamedPositionsProcessor(JetBrains.Util.FileSystemPath temporaryDirectory) { }
        public System.Collections.Generic.ICollection<string> PositionNames { get; }
        public string[] SkipExtensions { get; set; }
        public JetBrains.Util.FileSystemPath TempDirectory { get; }
        public void Dispose() { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.Util.FileSystemPath GetProcessedFilePath([JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.FileSystemPath filePath) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.Util.FileSystemPath[] GetProcessedFiles() { }
        protected virtual bool IsValidNameChar(char c, bool first) { }
        protected virtual bool IsValidPositionName(string name) { }
        public System.Collections.Generic.IList<JetBrains.ReSharper.TestFramework.CaretPosition> Positions(string name) { }
        public virtual void Process([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.Util.FileSystemPath basePath, params string[] files) { }
        public virtual void Process([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.Util.FileSystemPath basePath, params JetBrains.Util.FileSystemPath[] files) { }
        protected virtual void ProcessProcessedFile(JetBrains.Util.FileSystemPath originalFileName, JetBrains.Util.FileSystemPath processedFileName, System.Text.StringBuilder result) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class NamingSettingsOverrideForTests
    {
        public NamingSettingsOverrideForTests(JetBrains.Application.Settings.ISettingsStore settingsStore, [JetBrains.Annotations.UsedImplicitlyAttribute()] System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Naming.Settings.Upgrade.CodeStyleSettingsUpgrade> deps) { }
    }
    public class OptionsIterationResult : JetBrains.ReSharper.TestFramework.TestResult
    {
        public OptionsIterationResult(string optionGroupName, int indentLevel) { }
        public override bool HasOnlyOneVariant { get; }
        public override string TextForTheOnlyVariant { get; }
        public void AddTextForOption(JetBrains.ReSharper.TestFramework.TestResult text) { }
        public override string ToString() { }
    }
    public class OptionValuesIterationResult : JetBrains.ReSharper.TestFramework.TestResult
    {
        public OptionValuesIterationResult(string optionName, int indentLevel, bool separateWithSolidLine, bool reportUnaffected) { }
        public override bool HasOnlyOneVariant { get; }
        public override string TextForTheOnlyVariant { get; }
        public void AddTextForOptionValue(string optionValue, JetBrains.ReSharper.TestFramework.TestResult text) { }
        public override string ToString() { }
    }
    public class ParameterizedCaretPosition
    {
        public ParameterizedCaretPosition(JetBrains.ReSharper.TestFramework.CaretPosition position, string parameter) { }
        public string Parameter { get; }
        public JetBrains.ReSharper.TestFramework.CaretPosition Position { get; }
    }
    public class ProjectFilePropertiesInitializer : JetBrains.ProjectModel.RecursiveProjectVisitor
    {
        public override void VisitProjectItem(JetBrains.ProjectModel.IProjectItem projectItem) { }
    }
    [System.FlagsAttribute()]
    public enum ReferenceDlls
    {
        None = 0,
        MsCorLib = 1,
    }
    [JetBrains.ReSharper.TestFramework.ExcludeMsCorLibAttribute()]
    [NUnit.Framework.CategoryAttribute("Resolve")]
    public abstract class ReferenceTestBase : JetBrains.ReSharper.TestFramework.BaseTestWithSingleProject
    {
        protected virtual bool RunAllNonQualifiedReferenceResolver { get; }
        protected virtual bool AcceptPsiFile(JetBrains.ReSharper.Psi.Tree.IFile psiFile) { }
        protected abstract bool AcceptReference(JetBrains.ReSharper.Psi.Resolve.IReference reference);
        protected virtual void AfterTestFinished(JetBrains.ProjectModel.IProject testProject) { }
        protected virtual void BeforeTestStarted(JetBrains.ProjectModel.IProjectFile projectFile) { }
        protected virtual JetBrains.ReSharper.Psi.DeclaredElementPresenterStyle CreateDeclaredElementPresenter() { }
        protected void DoNamedTest(params string[] otherFiles) { }
        protected override void DoOneTest(string testName) { }
        protected void DoTest(string testFileName, params string[] otherFiles) { }
        protected void DoTest(string testFileName, System.Collections.Generic.IEnumerable<string> otherFiles) { }
        protected override void DoTest(JetBrains.ProjectModel.IProject testProject) { }
        protected virtual string Format([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution, JetBrains.ReSharper.Psi.PsiLanguageType languageType, JetBrains.ReSharper.Psi.DeclaredElementPresenterStyle presenter, JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        protected virtual JetBrains.DocumentModel.DocumentRange GetDocumentRange(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        protected virtual void PresentExtraInfo(System.IO.TextWriter writer, JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
    }
    public class static ReferenceTestUtil
    {
        public static void SortReferences(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Resolve.IReference> collectedReferences, out System.Collections.Generic.IList<> sortedReferences, out System.Collections.Generic.IList<> sortedPositions) { }
        public static void SortReferences(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Resolve.IReference> collectedReferences, System.Func<JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.DocumentModel.DocumentRange> getDocumentRange, out System.Collections.Generic.IList<> sortedReferences, out System.Collections.Generic.IList<> sortedPositions) { }
        public class ReferenceCollector : JetBrains.ReSharper.Psi.IRecursiveElementProcessor
        {
            public ReferenceCollector(JetBrains.ProjectModel.IProjectFile projectFile, System.Predicate<JetBrains.ReSharper.Psi.Resolve.IReference> acceptReference, System.Predicate<JetBrains.ReSharper.Psi.Tree.IFile> acceptPsiFile, bool runAllNonQualifiedReferencesResolver) { }
            public ReferenceCollector(JetBrains.ProjectModel.IProjectFile projectFile, System.Predicate<JetBrains.ReSharper.Psi.Resolve.IReference> acceptReference, System.Func<JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.DocumentModel.DocumentRange> getDocumentRange, System.Predicate<JetBrains.ReSharper.Psi.Tree.IFile> acceptPsiFile, bool runAllNonQualifiedReferencesResolver) { }
            public bool ProcessingIsFinished { get; }
            public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Resolve.IReference> References { get; }
            public bool InteriorShouldBeProcessed(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
            public void ProcessAfterInterior(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
            public void ProcessBeforeInterior(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        }
        public class ReferenceComparer : System.Collections.Generic.IComparer<JetBrains.ReSharper.Psi.Resolve.IReference>
        {
            public static readonly JetBrains.ReSharper.TestFramework.ReferenceTestUtil.ReferenceComparer Instance;
            public ReferenceComparer(System.Func<JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.DocumentModel.DocumentRange> getDocumentRange) { }
            public int Compare(JetBrains.ReSharper.Psi.Resolve.IReference x, JetBrains.ReSharper.Psi.Resolve.IReference y) { }
        }
    }
    public class SimpleResult : JetBrains.ReSharper.TestFramework.TestResult
    {
        public SimpleResult(string text) { }
        public override bool HasOnlyOneVariant { get; }
        public override string TextForTheOnlyVariant { get; }
        public override string ToString() { }
    }
    public class static SolutionTestExtensions
    {
        public static JetBrains.ProjectModel.Model2.Assemblies.Interfaces.IAssemblyFile AddAssembly(this JetBrains.ProjectModel.ISolution solution, JetBrains.DataFlow.Lifetime lifetime, JetBrains.Util.FileSystemPath assemblyPath, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ProjectModel.PlatformID platformID = null, JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext moduleReferenceResolveContext = null) { }
        public static JetBrains.ReSharper.Psi.Modules.IAssemblyPsiModule AddAssemblyPsiModule(this JetBrains.ProjectModel.ISolution solution, JetBrains.DataFlow.Lifetime lifetime, JetBrains.Util.FileSystemPath assemblyPath, JetBrains.ProjectModel.PlatformID platformID) { }
    }
    public class TestCSharpSharepointAttribute : JetBrains.ReSharper.TestFramework.TestSharepointAttributeBase
    {
        public TestCSharpSharepointAttribute(params string[] references) { }
        public override System.Guid[] GetProjectTypeGuids() { }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Class | System.AttributeTargets.Method | System.AttributeTargets.All, AllowMultiple=false, Inherited=true)]
    public class TestFileExtensionAttribute : System.Attribute
    {
        public TestFileExtensionAttribute([JetBrains.Annotations.NotNullAttribute()] string extension) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public string Extension { get; }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Class | System.AttributeTargets.Method | System.AttributeTargets.All, AllowMultiple=true)]
    public class TestFlavoursAttribute : System.Attribute, JetBrains.ReSharper.TestFramework.ITestFlavoursProvider
    {
        public TestFlavoursAttribute(params string[] projectTypeGuids) { }
        public bool Inherits { get; set; }
        public System.Guid[] GetProjectTypeGuids() { }
    }
    public class static TestFrameworkUtil
    {
        [System.ObsoleteAttribute()]
        public static void DumpReferencePositions(System.IO.TextWriter w, string text, System.Collections.Generic.IList<JetBrains.ReSharper.TestFramework.TestFrameworkUtil.Position> sortedPositions) { }
        public static void DumpReferencePositions(System.IO.TextWriter w, JetBrains.Text.IBuffer text, System.Collections.Generic.IList<JetBrains.ReSharper.TestFramework.TestFrameworkUtil.Position> sortedPositions) { }
        public static void SortItems<T>(System.Collections.Generic.IEnumerable<T> collectedItems, System.Collections.Generic.IComparer<T> comparer, System.Func<T, JetBrains.DocumentModel.DocumentRange> ranger, out System.Collections.Generic.IList<> sortedItems, out System.Collections.Generic.IList<> sortedPositions) { }
        public class EndPosition : JetBrains.ReSharper.TestFramework.TestFrameworkUtil.Position
        {
            public EndPosition(int offset, int itemNumber) { }
        }
        public abstract class Position
        {
            public readonly int ItemNumber;
            public readonly int Offset;
            protected Position(int offset, int itemNumber) { }
        }
        public class StartPosition : JetBrains.ReSharper.TestFramework.TestFrameworkUtil.Position
        {
            public StartPosition(int offset, int itemNumber) { }
        }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class TestGlobalFormatSettingsService : JetBrains.ReSharper.Psi.CodeStyle.GlobalFormatSettingsService
    {
        public TestGlobalFormatSettingsService(JetBrains.ReSharper.Psi.PsiProjectFileTypeCoordinator coordinator, JetBrains.ReSharper.Psi.ILanguageManager languageManager) { }
        public void ChangeIndentSize(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ReSharper.Psi.PsiLanguageType languageType, int indentSize) { }
        public void ChangeLangSettings(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ReSharper.Psi.PsiLanguageType languageType, JetBrains.ReSharper.Psi.CodeStyle.GlobalFormatSettings newSettings) { }
        public void ChangeUseTabs(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ReSharper.Psi.PsiLanguageType languageType, bool useTabs) { }
        protected override JetBrains.ReSharper.Psi.CodeStyle.GlobalFormatSettings GetLangSettings(JetBrains.ReSharper.Psi.PsiLanguageType languageType) { }
        protected override JetBrains.ReSharper.Psi.CodeStyle.GlobalFormatSettings GetLangSettings(JetBrains.ProjectModel.ProjectFileType languageType) { }
    }
    public class TestNetFramework2Attribute : System.Attribute, JetBrains.ReSharper.TestFramework.ITestPlatformProvider
    {
        public JetBrains.ProjectModel.PlatformID GetPlatformId() { }
    }
    public class TestNetFramework35Attribute : System.Attribute, JetBrains.ReSharper.TestFramework.ITestPlatformProvider
    {
        public JetBrains.ProjectModel.PlatformID GetPlatformId() { }
    }
    public class TestNetFramework45Attribute : System.Attribute, JetBrains.ReSharper.TestFramework.ITestPlatformProvider
    {
        public JetBrains.ProjectModel.PlatformID GetPlatformId() { }
    }
    public class TestNetFramework4Attribute : System.Attribute, JetBrains.ReSharper.TestFramework.ITestPlatformProvider
    {
        public JetBrains.ProjectModel.PlatformID GetPlatformId() { }
    }
    public class TestNetFramework4RuntimeAttribute : System.Attribute, JetBrains.ReSharper.TestFramework.ITestPlatformProvider
    {
        public JetBrains.ProjectModel.PlatformID GetPlatformId() { }
    }
    public class TestOptionsIterator
    {
        public TestOptionsIterator(JetBrains.TestShell.Infra.BaseTest test) { }
        public bool ReportUnaffected { get; set; }
        public bool SeparateWithSolidLine { get; }
        public void Iterate(System.IO.TextWriter writer, JetBrains.Application.Settings.ISettingsStore settingsStore, JetBrains.ProjectModel.IProjectFile projectFile, JetBrains.ProjectModel.ISolution solution, System.Action<JetBrains.ReSharper.TestFramework.TestOptionsIterator.TestData, System.IO.TextWriter> func) { }
        public string Iterate(JetBrains.Application.Settings.ISettingsStore settingsStore, JetBrains.ProjectModel.IProjectFile projectFile, JetBrains.ProjectModel.ISolution solution, System.Func<JetBrains.ReSharper.TestFramework.TestOptionsIterator.TestData, string> func) { }
        public class TestData
        {
            public TestData(JetBrains.Application.Settings.IContextBoundSettingsStore boundStore, JetBrains.ReSharper.TestFramework.TestGlobalFormatSettingsService formatSettingsService, bool separateWithSolidLine, bool reportUnaffected) { }
            public JetBrains.Application.Settings.IContextBoundSettingsStore BoundStore { get; }
            public System.Collections.Generic.IDictionary<string, object> CustomValues { get; }
            public JetBrains.ReSharper.TestFramework.TestGlobalFormatSettingsService FormatSettingsService { get; }
            public bool ReportUnaffected { get; }
            public bool SeparateWithSolidLine { get; }
        }
    }
    [JetBrains.Annotations.PublicAPIAttribute()]
    public class TestPlatformAttribute : System.Attribute, JetBrains.ReSharper.TestFramework.ITestPlatformProvider
    {
        public TestPlatformAttribute(string name) { }
        public TestPlatformAttribute(string name, int major, int minor) { }
        public TestPlatformAttribute(string name, int major, int minor, int build) { }
        public TestPlatformAttribute(string name, int major, int minor, int build, int revision) { }
        public JetBrains.ProjectModel.PlatformID GetPlatformId() { }
    }
    public sealed class TestProjectConfiguration
    {
        public string ProjectName;
        public readonly System.Collections.Generic.IList<string> ProjectNamesToRefer;
        public TestProjectConfiguration(JetBrains.ReSharper.TestFramework.IBaseTest owner, string projectName, System.Collections.Generic.ICollection<JetBrains.Util.FileSystemPath> testFiles, System.Collections.Generic.IEnumerable<string> libraries, JetBrains.ReSharper.TestFramework.ReferenceDlls referenceMsCorLib, JetBrains.ProjectModel.PlatformID platformID, System.Guid projectGuid, System.Collections.Generic.ICollection<System.Guid> flavours, System.Collections.Generic.ICollection<string> sdkReferences) { }
        public JetBrains.ProjectModel.IProject CreateProject(JetBrains.ProjectModel.ISolution solution, System.Action<JetBrains.Util.FileSystemPath, JetBrains.ProjectModel.Properties.IProjectFileProperties> setProjectFileProperties, bool setAssemblyShortName = True) { }
        public bool MatchesProject(JetBrains.ProjectModel.IProject project) { }
        public void RefillProject(JetBrains.ProjectModel.ISolution solution, JetBrains.ProjectModel.IProject project, System.Action<JetBrains.Util.FileSystemPath, JetBrains.ProjectModel.Properties.IProjectFileProperties> setProjectFileProperties) { }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Class | System.AttributeTargets.Method | System.AttributeTargets.All, AllowMultiple=true)]
    public class TestReferencesAttribute : System.Attribute, JetBrains.ReSharper.TestFramework.ITestLibraryReferencesProvider
    {
        public TestReferencesAttribute(params string[] references) { }
        public bool Inherits { get; set; }
        public virtual System.Collections.Generic.IEnumerable<string> GetReferences(JetBrains.ProjectModel.PlatformID platformID) { }
    }
    public abstract class TestResult
    {
        public abstract bool HasOnlyOneVariant { get; }
        public abstract string TextForTheOnlyVariant { get; }
        protected bool Equals(JetBrains.ReSharper.TestFramework.TestResult other) { }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Class | System.AttributeTargets.Method | System.AttributeTargets.All, AllowMultiple=true)]
    public class TestSdksAttribute : System.Attribute, JetBrains.ReSharper.TestFramework.ITestSdkReferencesProvider
    {
        public TestSdksAttribute(params string[] references) { }
        public bool Inherits { get; set; }
        public virtual System.Collections.Generic.IEnumerable<string> GetReferences() { }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Class | System.AttributeTargets.Method | System.AttributeTargets.All)]
    public class TestSettingsAttribute : System.Attribute
    {
        public TestSettingsAttribute(string settings) { }
        public string Settings { get; }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Class | System.AttributeTargets.All)]
    public class TestSettingsIncludeAttribute : System.Attribute
    {
        public TestSettingsIncludeAttribute(string fileName) { }
        public string FileName { get; }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Class | System.AttributeTargets.Method | System.AttributeTargets.All, AllowMultiple=true)]
    public class TestSettingsKeyAttribute : System.Attribute
    {
        public TestSettingsKeyAttribute(System.Type keyType) { }
        public System.Type KeyType { get; }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Class | System.AttributeTargets.All, AllowMultiple=true)]
    public class TestSettingsVariableAttribute : System.Attribute
    {
        public TestSettingsVariableAttribute(string name, System.Type type) { }
        public string Name { get; }
        public System.Type Type { get; }
    }
    public abstract class TestSharepointAttributeBase : JetBrains.ReSharper.TestFramework.TestReferencesAttribute, JetBrains.ReSharper.TestFramework.ITestFlavoursProvider, JetBrains.ReSharper.TestFramework.ITestPlatformProvider
    {
        public TestSharepointAttributeBase(params string[] references) { }
        public JetBrains.ProjectModel.PlatformID GetPlatformId() { }
        public abstract System.Guid[] GetProjectTypeGuids();
        public override System.Collections.Generic.IEnumerable<string> GetReferences(JetBrains.ProjectModel.PlatformID platformID) { }
    }
    [NUnit.Framework.TestFixtureAttribute()]
    public class TestTreeNodeEnumerable
    {
        [NUnit.Framework.TestAttribute()]
        public void TestEmpty() { }
        [NUnit.Framework.TestAttribute()]
        public void TestEmpty2() { }
        [NUnit.Framework.TestAttribute()]
        public void TestFourLevel() { }
        [NUnit.Framework.TestAttribute()]
        public void TestOneLevel() { }
    }
    public class TestVbSharepointAttribute : JetBrains.ReSharper.TestFramework.TestSharepointAttributeBase
    {
        public TestVbSharepointAttribute(params string[] references) { }
        public override System.Guid[] GetProjectTypeGuids() { }
        public override System.Collections.Generic.IEnumerable<string> GetReferences(JetBrains.ProjectModel.PlatformID platformID) { }
    }
    public class WebApplicationAttribute : System.Attribute, JetBrains.ReSharper.TestFramework.ITestFlavoursProvider
    {
        public bool Inherits { get; set; }
        public System.Guid[] GetProjectTypeGuids() { }
    }
}
namespace JetBrains.ReSharper.TestFramework.Components.Feature.Services.ContextHighlighters
{
    
    [JetBrains.Application.ShellComponentAttribute()]
    public class ContextManagerForTests : JetBrains.ReSharper.Daemon.CaretDependentFeatures.ContextManager
    {
        public ContextManagerForTests(JetBrains.Application.IShellLocks shellLocks) { }
        public void Enable(JetBrains.DataFlow.Lifetime lifetime, System.Action action) { }
        protected override void RegisterContextConsumerInternal(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ReSharper.Daemon.CaretDependentFeatures.IContextConsumer consumer) { }
        protected override void RegisterContextInternal(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ReSharper.Daemon.CaretDependentFeatures.IContextKey key) { }
    }
}
namespace JetBrains.ReSharper.TestFramework.Components.Feature.Services.LiveTemplates.Settings
{
    
    [JetBrains.Application.ShellComponentAttribute()]
    public class TestStoredTemplatesProvider : JetBrains.ReSharper.Feature.Services.LiveTemplates.Settings.StoredTemplatesProvider
    {
        public TestStoredTemplatesProvider(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.Settings.ISettingsStore settingsStore) { }
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.LiveTemplates.Templates.Template> EnumerateTemplates(JetBrains.Application.Settings.IContextBoundSettingsStore store, JetBrains.ReSharper.Feature.Services.LiveTemplates.Settings.TemplateApplicability applicability, bool enabledOnly = True) { }
        public void SetTemplatesEnumerable(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.LiveTemplates.Templates.Template> templates) { }
    }
}
namespace JetBrains.ReSharper.TestFramework.Components.Features.StructuralSearch
{
    
    [JetBrains.Application.ShellComponentAttribute()]
    public class TestCustomPatternManager
    {
        public TestCustomPatternManager(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.Settings.ISettingsStore settingsStore) { }
        public JetBrains.Application.Settings.GuidIndex AddPattern(JetBrains.ReSharper.Features.StructuralSearch.ICustomPattern pattern) { }
        public void RemovePattern(JetBrains.Application.Settings.GuidIndex guid) { }
    }
}
namespace JetBrains.ReSharper.TestFramework.Components.Features.TodoManager
{
    
    [JetBrains.ReSharper.Psi.PsiComponentAttribute()]
    public sealed class TodoManagerTest : JetBrains.ReSharper.Feature.Services.TodoItems.TodoManager, JetBrains.ReSharper.Psi.Caches.ICache
    {
        public TodoManagerTest(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.Threading.Tasks.ITaskHost tasks, JetBrains.ProjectModel.Settings.Cache.SettingsCacheManager settingsCacheManager, JetBrains.Application.Settings.ISettingsStore settingStore, JetBrains.ReSharper.Feature.Services.TodoItems.ITodoPatternStorage patternStorage, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Psi.Caches.ISymbolCache symbolCache, JetBrains.ReSharper.Psi.PsiProjectFileTypeCoordinator projectFileTypeCoordinator, JetBrains.Application.IShellLocks locks, JetBrains.ReSharper.Psi.IPsiConfiguration psiConfiguration, JetBrains.ReSharper.Psi.ILanguages languages, JetBrains.ReSharper.Psi.ILanguageManager languageManager, JetBrains.ReSharper.Psi.Caches.IPersistentIndexManager persistentIndexManager) { }
        protected override void OnUpdated() { }
        public void SyncUpdate(bool underTransaction) { }
    }
}
namespace JetBrains.ReSharper.TestFramework.Components.I18n
{
    
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class TestCustomToolService : JetBrains.ReSharper.I18n.Services.CustomToolService
    {
        public static readonly JetBrains.Util.Key NamespaceProperty;
        public TestCustomToolService(JetBrains.ProjectModel.IProjectFileExtensions projectFileExtensions) { }
        public override bool RunCustomTool(JetBrains.ReSharper.Psi.IPsiSourceFile psiSourceFile) { }
    }
}
namespace JetBrains.ReSharper.TestFramework.Components.Intentions
{
    
    [JetBrains.Application.ShellComponentAttribute()]
    public class IntentionResultTestBehavior : JetBrains.ReSharper.Feature.Services.Intentions.IntentionResultBehavior
    {
        public IntentionResultTestBehavior(JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.HotspotSessionExecutor hotspotSessionExecutor, JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.ShellLocks shellLocks) { }
        public JetBrains.DataFlow.ISignal<JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.Hotspot> OnHotspotEnter { get; }
        protected override void OnHotspotSessionExecutionStartedInternal(JetBrains.ReSharper.Feature.Services.Intentions.IntentionResult result, JetBrains.TextControl.ITextControl textControl) { }
    }
}
namespace JetBrains.ReSharper.TestFramework.Components.Psi
{
    
    [JetBrains.ReSharper.Psi.PsiComponentAttribute()]
    public class FileDependenciesSynchronizerTest : JetBrains.ReSharper.Psi.Modules.ExternalFileModules.FileDependenciesSynchronizer
    {
        public FileDependenciesSynchronizerTest(JetBrains.Application.IShellLocks locks, JetBrains.DataFlow.Lifetime lifetime, JetBrains.ReSharper.Psi.Caches.IPsiCaches psiCaches, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Modules.ExternalFileModules.IAsynchronousModuleChangeProducer> factories, JetBrains.ProjectModel.Tasks.ISolutionLoadTasksScheduler scheduler, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Psi.JavaScript.Impl.PsiModules.ReferencedFilesSupport.JavaScriptDependentFilesCache dependentFilesCache, JetBrains.ReSharper.Psi.JavaScript.Impl.PsiModules.ReferencedFilesSupport.JavaScriptDependentFilesModuleFactory javaScriptDependentFilesModuleFactory, JetBrains.Application.Threading.Tasks.ITaskHost tasks) { }
        public void ManualFlushChanged() { }
        protected override void SchedulerTask() { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class SymbolCacheTestHelper : System.IDisposable
    {
        public SymbolCacheTestHelper(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Psi.Caches.IPsiCaches psiCaches, JetBrains.ReSharper.Psi.Files.IPsiFiles psiFiles, JetBrains.ReSharper.Psi.Modules.IPsiModules psiModules, JetBrains.ReSharper.Psi.IGeneratedDocumentsManager generatedDocumentsManager, JetBrains.ReSharper.Psi.ILanguages languages, JetBrains.ReSharper.Psi.Impl.Reflection2.IPsiAssemblyFileLoader psiAssemblyFileLoader, JetBrains.Application.IShellLocks shellLocks, JetBrains.ReSharper.Psi.IPsiConfiguration psiConfiguration, JetBrains.ReSharper.Psi.Caches.IPersistentIndexManager persistentIndexManager, JetBrains.ReSharper.Psi.Transactions.IPsiTransactions psiTransactions, JetBrains.Application.ChangeManager changeManager, JetBrains.Application.Env.RunsProducts.ProductConfigurations configuration, JetBrains.ReSharper.Psi.Caches.IStubTreeNodeCache stubTreeNodeCache) { }
        public static System.Action<string> CacheUpdateNotification { set; }
        public void BuildCache(JetBrains.ReSharper.Psi.Caches.ICache cache, JetBrains.ReSharper.Psi.IPsiSourceFile[] projectFiles) { }
        public JetBrains.ReSharper.Psi.Caches.SymbolCache.SymbolCache CreateCache(JetBrains.DataFlow.Lifetime cacheLifetime) { }
        public void Dispose() { }
        public static JetBrains.ReSharper.TestFramework.Components.Psi.SymbolCacheTestHelper GetInstance(JetBrains.ProjectModel.ISolution solution) { }
        public JetBrains.ReSharper.Psi.Caches.SymbolCache.SymbolCache RestoreCache(JetBrains.DataFlow.Lifetime cacheLifetime, byte[] array) { }
        public byte[] SaveCache(JetBrains.ReSharper.Psi.Caches.ICache cache) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class TestDbDriverManager : JetBrains.ReSharper.Psi.Impl.Caches2.DbDriverManager
    {
        public override JetBrains.Application.PersistentMap.IKeyValueDbDriver<JetBrains.Util.FileSystemPath, JetBrains.Application.PersistentMap.PersistentMapOpenParamsBase> GetDriver() { }
    }
    [JetBrains.ProjectModel.SolutionInstanceComponentAttribute()]
    public class TestPsiConfiguration : JetBrains.ReSharper.Psi.Impl.PsiConfigurationImpl
    {
        public TestPsiConfiguration(JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.TestFramework.Components.Psi.TestPsiConfigurationSettings testSettings, JetBrains.ProjectModel.Caches.ISolutionCachesConfiguration solutionCachesConfiguration) { }
        public override bool CacheJobServiceSynchronous { get; }
        public override bool EagerMetadataLoad { get; }
        public override bool PersistCaches { get; }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class TestPsiConfigurationSettings
    {
        public TestPsiConfigurationSettings(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.IApplicationDescriptor applicationDescriptor) { }
        public JetBrains.ReSharper.Psi.CachesLocationType CachesLocationType { get; }
        public bool EagerMetadataLoad { get; set; }
        public static JetBrains.ReSharper.TestFramework.Components.Psi.TestPsiConfigurationSettings Instance { get; }
        public bool PersistCaches { get; set; }
        public bool SymbolCacheSynchronous { get; set; }
        public JetBrains.Util.FileSystemPath TempDirectoryPath { get; }
    }
    [JetBrains.ProjectModel.SolutionInstanceComponentAttribute()]
    public class TestSolutionCachesConfigurationOnPsi : JetBrains.TestFramework.ProjectModel.TestSolutionCachesConfiguration
    {
        public TestSolutionCachesConfigurationOnPsi(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.Settings.ISettingsStore settingsStore, JetBrains.ReSharper.TestFramework.Components.Psi.TestPsiConfigurationSettings testSettings, JetBrains.ProjectModel.ISolution solution, JetBrains.Application.IApplicationDescriptor applicationDescriptor, JetBrains.Application.Env.Components.ProductSettingsLocation productSettingsLocation, JetBrains.ProjectModel.Settings.Storages.SolutionSettingsStoragePersonal needToBeReady, JetBrains.ProjectModel.Settings.Storages.SolutionSettingsStorageShared needToBeReady2) { }
        protected override JetBrains.ReSharper.Psi.CachesLocationType CacheLocation { get; }
        public override bool PersistCaches { get; }
        protected override JetBrains.Util.FileSystemPath GetExpectedCachesPath(string productName, string solutionName) { }
    }
}
namespace JetBrains.ReSharper.TestFramework.Components.Psi.Web
{
    
    public class TestWebsiteBuilder : JetBrains.ReSharper.Psi.Web.Impl.BuildProviders.SynchWebsiteBuilder
    {
        public TestWebsiteBuilder(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ReSharper.Psi.Web.BuildProviders.IWebsiteBuildRequestor requestor, JetBrains.Application.ChangeManager changeManager, JetBrains.DocumentManagers.impl.DocumentManagerOperations documentManagerOperations, JetBrains.ReSharper.Psi.Files.IPsiFiles psiFiles, JetBrains.ProjectModel.PlatformManager platformManager, JetBrains.Application.IShellLocks shellLocks, JetBrains.ReSharper.Psi.Web.BuildProviders.WebsiteBuildEngineFactory factory) { }
        protected override JetBrains.Util.TemporaryDirectoryCookie CreateGeneratedFilesDirectory() { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class TestWebsiteBuilderFactory : JetBrains.ReSharper.Psi.Web.Impl.BuildProviders.WebsiteBuilderFactory
    {
        public TestWebsiteBuilderFactory(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.ChangeManager changeManager, JetBrains.DocumentManagers.impl.DocumentManagerOperations documentManagerOperations, JetBrains.ProjectModel.PlatformManager platformManager, JetBrains.Application.IShellLocks shellLocks, JetBrains.ReSharper.Psi.Web.BuildProviders.WebsiteBuildEngineFactory buildEngineFactory) { }
        public override JetBrains.ReSharper.Psi.Web.BuildProviders.IWebsiteBuilder CreateWebsiteBuilder(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ReSharper.Psi.Web.BuildProviders.IWebsiteBuildRequestor requestor) { }
    }
}
namespace JetBrains.ReSharper.TestFramework.Components.SolutionAnalysis
{
    
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class FileImagesDisableFlushChangesComponent
    {
        public static bool DisableFlushChanges;
        public FileImagesDisableFlushChangesComponent(JetBrains.ProjectModel.ISolution solution) { }
    }
}
namespace JetBrains.ReSharper.TestFramework.Components.UnitTestSupport
{
    
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class TestRemoteChannelMessageListener : JetBrains.ReSharper.TaskRunnerFramework.IRemoteChannelMessageListener
    {
        public System.IO.TextWriter Output { get; set; }
        public JetBrains.ReSharper.UnitTestFramework.IUnitTestRun Run { get; set; }
        public JetBrains.ReSharper.UnitTestFramework.ITaskRunnerHostController RunController { get; set; }
        public JetBrains.ReSharper.UnitTestFramework.Strategy.OutOfProcessUnitTestRunStrategy Strategy { get; set; }
        public void OnError(string message) { }
        public void OnError(System.Exception exception) { }
        public void OnPacket(System.Xml.XmlElement message, JetBrains.ReSharper.TaskRunnerFramework.RemoteChannel remoteChannel) { }
        public void RegisterPacketHandler(JetBrains.ReSharper.TaskRunnerFramework.ITaskRunnerPacketHandler packetHandler) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class UnitTestAgentManagerTestImpl : JetBrains.ReSharper.UnitTestFramework.IUnitTestAgentManager
    {
        public UnitTestAgentManagerTestImpl(JetBrains.ReSharper.TestFramework.Components.UnitTestSupport.TestRemoteChannelMessageListener messageListener) { }
        public void RegisterRun(JetBrains.ReSharper.UnitTestFramework.IUnitTestRun run, JetBrains.ReSharper.UnitTestFramework.Strategy.IUnitTestRunStrategy strategy, JetBrains.ReSharper.UnitTestFramework.ITaskRunnerHostController controller) { }
        public void SendPacket(JetBrains.ReSharper.UnitTestFramework.IUnitTestRun run, string packet) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class UnitTestingCategoriesProviderTest : JetBrains.ReSharper.Features.Shared.UnitTesting.IUnitTestingCategoriesProvider
    {
        public UnitTestingCategoriesProviderTest(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Features.Shared.UnitTesting.IUnitTestingCategoriesAttributeProvider> attributeProviders) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IClrTypeName> AttributeTypes { get; }
        public System.Collections.Generic.IEnumerable<string> Categories { get; }
        public JetBrains.UI.Icons.IconId Image { get; }
    }
}
namespace JetBrains.ReSharper.TestFramework.Web
{
    
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class TestWebVirtualPathProvider
    {
        public TestWebVirtualPathProvider(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ReSharper.Psi.Paths.IVirtualPathsService service) { }
        public void AddRelativePath(JetBrains.ProjectModel.IProject project, string relativePath) { }
        public void Clear(JetBrains.ProjectModel.IProject project) { }
    }
    public class static WebTestUtil
    {
        public static string ApplyTestDataPathSuffix(string fileName, string originalSuffix, string insert = ".mvc") { }
        public static void SetWebPaths(JetBrains.ProjectModel.IProject project, string text) { }
    }
}
namespace JetBrains.ReSharper.TestFramework.WinRT
{
    
    public class TestWinJSApplicationAttribute : JetBrains.ReSharper.TestFramework.TestSdksAttribute, JetBrains.ReSharper.TestFramework.ITestLibraryReferencesProvider
    {
        public TestWinJSApplicationAttribute(params string[] references) { }
        public override System.Collections.Generic.IEnumerable<string> GetReferences() { }
    }
}
namespace JetBrains.ReSharper.TestFramework.Xaml
{
    
    public class TestMetroStyleXamlAttribute : JetBrains.ReSharper.PsiTests.WinRT.TestNetCore45WinRTComponentAttribute, JetBrains.ReSharper.TestFramework.ITestFlavoursProvider
    {
        public TestMetroStyleXamlAttribute(params string[] references) { }
        public System.Guid[] GetProjectTypeGuids() { }
    }
}
namespace JetBrains.ReSharper.UnitTestSupportTests
{
    
    [JetBrains.ProjectModel.SolutionComponentAttribute(JetBrains.Application.Components.ProgramConfigurations.NONE | JetBrains.Application.Components.ProgramConfigurations.TEST | JetBrains.Application.Components.ProgramConfigurations.ALL)]
    public class UnitTestLaunchManagerTestImpl : JetBrains.ReSharper.UnitTestFramework.IUnitTestLaunchManager
    {
        public UnitTestLaunchManagerTestImpl() { }
        public void AbortBuild() { }
        public void AddLaunch(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ReSharper.UnitTestFramework.IUnitTestLaunch launch) { }
        public void BuildAndRunSession(JetBrains.ReSharper.UnitTestFramework.IUnitTestSessionView session, JetBrains.ReSharper.UnitTestFramework.UnitTestElements elements, JetBrains.ReSharper.UnitTestFramework.IHostProvider hostProvider, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.UnitTestFramework.IUnitTestElementsTransformationRule> rules, JetBrains.ReSharper.UnitTestFramework.BuildPolicy buildPolicy = 0, JetBrains.ReSharper.TaskRunnerFramework.PlatformType platformType = 0, JetBrains.ReSharper.TaskRunnerFramework.PlatformVersion frameworkVersion = 0, bool focusAfterBuild = False) { }
        public void ClearSessionHistory(JetBrains.ReSharper.UnitTestFramework.IUnitTestSessionView sessionView) { }
        public JetBrains.ReSharper.UnitTestFramework.IUnitTestLaunch CreateLaunch(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.UnitTestFramework.IDiscoveredRemoteTaskHandler> taskHandlers, System.Action<JetBrains.ReSharper.UnitTestFramework.IUnitTestElement> addElement) { }
        public JetBrains.ReSharper.UnitTestFramework.IUnitTestLaunch GetLaunchByRun(string runId) { }
        public JetBrains.ReSharper.UnitTestFramework.IUnitTestRun GetRun(string id) { }
        public bool HasPreviousRunForSession(JetBrains.ReSharper.UnitTestFramework.IUnitTestSession session) { }
        public void RepeatPreviousRunForSession(JetBrains.ReSharper.UnitTestFramework.IUnitTestSessionView session) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class UnitTestSessionManagerTestImpl : JetBrains.ReSharper.UnitTestFramework.IUnitTestSessionManager
    {
        public UnitTestSessionManagerTestImpl() { }
        public JetBrains.ReSharper.UnitTestFramework.IUnitTestSessionView CurrentSession { get; }
        public JetBrains.DataFlow.ISignal<JetBrains.ReSharper.UnitTestFramework.IUnitTestSessionView> SessionClosed { get; }
        public JetBrains.DataFlow.ISignal<JetBrains.ReSharper.UnitTestFramework.IUnitTestSessionView> SessionCreated { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.UnitTestFramework.IUnitTestSessionView> Sessions { get; }
        public void ActivateSession(JetBrains.ReSharper.UnitTestFramework.IUnitTestSessionView session) { }
        public void AddLaunch(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ReSharper.UnitTestFramework.IUnitTestLaunch launch) { }
        public JetBrains.ReSharper.UnitTestFramework.IUnitTestSessionView AppendToCurrentOrNewSession(JetBrains.ReSharper.UnitTestFramework.UnitTestElements unitTests, bool focus = True, string name = null) { }
        public void CloseAllSessions() { }
        public void CloseSession(JetBrains.ReSharper.UnitTestFramework.IUnitTestSessionView session) { }
        public JetBrains.ReSharper.UnitTestFramework.IUnitTestSessionView CreateSession(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.UnitTestFramework.IUnitTestElement> elements = null, string name = null, string id = null) { }
        public JetBrains.ReSharper.UnitTestFramework.IUnitTestSessionView CreateSession() { }
        public JetBrains.ReSharper.UnitTestFramework.IUnitTestLaunch GetLaunchByRun(string runId) { }
        public JetBrains.ReSharper.UnitTestFramework.IUnitTestRun GetRun(string id) { }
        public JetBrains.ReSharper.UnitTestFramework.IUnitTestSessionView GetSession(string id) { }
        public void OpenSession(JetBrains.ReSharper.UnitTestFramework.IUnitTestSessionView session, bool show = True) { }
        public void RemoveElementsFromDisabledProviders(System.Collections.Generic.IList<JetBrains.ReSharper.UnitTestFramework.IUnitTestProvider> disabledProviders) { }
        public void RunInCurrentOrNewSession(JetBrains.ReSharper.UnitTestFramework.UnitTestElements unitTests, JetBrains.ReSharper.UnitTestFramework.IHostProvider hostProvider, bool focus = True, string name = null) { }
    }
    public class UnitTestSessionTestImpl : JetBrains.Util.UserDataHolder, JetBrains.ReSharper.UnitTestFramework.IUnitTestLaunch, JetBrains.ReSharper.UnitTestFramework.IUnitTestRun, JetBrains.ReSharper.UnitTestFramework.IUnitTestSession, JetBrains.ReSharper.UnitTestFramework.IUnitTestSessionView, JetBrains.Util.IUserDataHolder
    {
        public UnitTestSessionTestImpl() { }
        public JetBrains.ReSharper.UnitTestFramework.BuildPolicy BuildPolicy { get; set; }
        public System.DateTime DateTimeStarted { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.UnitTestFramework.IUnitTestElement> Elements { get; }
        public JetBrains.ReSharper.TaskRunnerFramework.PlatformVersion FrameworkVersion { get; set; }
        public int GroupingIndex { get; set; }
        public string Id { get; }
        public string ID { get; }
        public JetBrains.DataFlow.IProperty<bool> IsIdle { get; }
        public JetBrains.ReSharper.UnitTestFramework.IUnitTestElement LastStartedElement { get; }
        public JetBrains.DataFlow.IProperty<JetBrains.ReSharper.UnitTestFramework.IUnitTestLaunch> Launch { get; }
        public JetBrains.DataFlow.Lifetime Lifetime { get; }
        public JetBrains.DataFlow.IProperty<bool> Locked { get; }
        public string Name { get; set; }
        public JetBrains.ReSharper.TaskRunnerFramework.PlatformType PlatformType { get; set; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.UnitTestFramework.IUnitTestRun> Runs { get; }
        public JetBrains.ReSharper.UnitTestFramework.UnitTestRunStatus RunStatus { get; set; }
        public JetBrains.ReSharper.TaskRunnerFramework.RuntimeEnvironment RuntimeEnvironment { get; set; }
        public System.Collections.Generic.List<System.Collections.Generic.IList<JetBrains.ReSharper.UnitTestFramework.UnitTestTask>> Sequences { set; }
        public JetBrains.ReSharper.UnitTestFramework.IUnitTestSession Session { get; }
        public JetBrains.ReSharper.UnitTestFramework.UnitTestResult SessionResult { get; }
        public bool ShowTime { get; set; }
        public JetBrains.DataFlow.IProperty<JetBrains.ReSharper.UnitTestFramework.UnitTestSessionState> State { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.UnitTestFramework.IDiscoveredRemoteTaskHandler> TaskHandlers { get; set; }
        public JetBrains.DataFlow.IProperty<string> Title { get; }
        public bool TrackElements { get; set; }
        public void Abort() { }
        public void ActivateElement(JetBrains.ReSharper.UnitTestFramework.IUnitTestElement element) { }
        public void AddElement(JetBrains.ReSharper.UnitTestFramework.IUnitTestElement element) { }
        public void AddElements(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.UnitTestFramework.IUnitTestElement> unitTestElements) { }
        public void AddTask(JetBrains.ReSharper.TaskRunnerFramework.RemoteTask task) { }
        public void Append(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.UnitTestFramework.IUnitTestElement> elements) { }
        public void CreateDynamicElement(JetBrains.ReSharper.TaskRunnerFramework.RemoteTask remoteTask) { }
        public JetBrains.ReSharper.UnitTestFramework.IUnitTestRun CreateRun(JetBrains.ReSharper.TaskRunnerFramework.RuntimeEnvironment runtimeEnvironment) { }
        public void Finished() { }
        public JetBrains.ReSharper.UnitTestFramework.IUnitTestElement GetElementByRemoteTaskId(string id) { }
        public JetBrains.ReSharper.TaskRunnerFramework.RemoteTask GetRemoteTaskForElement(JetBrains.ReSharper.UnitTestFramework.IUnitTestElement element) { }
        public JetBrains.ReSharper.UnitTestFramework.IUnitTestRun GetRun(string id) { }
        public System.Collections.Generic.Dictionary<string, JetBrains.ReSharper.UnitTestFramework.IUnitTestElement> GetTaskIdsToElements() { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.TaskRunnerFramework.RemoteTaskPacket> GetTasks() { }
        public bool HasElement(JetBrains.ReSharper.UnitTestFramework.IUnitTestElement element) { }
        public void RemoveElements(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.UnitTestFramework.IUnitTestElement> elements) { }
        public void Run(JetBrains.ReSharper.UnitTestFramework.UnitTestElements elements, JetBrains.ReSharper.UnitTestFramework.IHostProvider provider, bool build = True, bool focus = True) { }
        public void Run(JetBrains.ReSharper.UnitTestFramework.UnitTestElements elements, System.Collections.Generic.IEnumerable<JetBrains.ProjectModel.IProject> projects, JetBrains.ReSharper.UnitTestFramework.IHostProvider provider, JetBrains.ReSharper.TaskRunnerFramework.PlatformType automatic, JetBrains.ReSharper.TaskRunnerFramework.PlatformVersion frameworkVersion) { }
        public void Run(JetBrains.ReSharper.UnitTestFramework.ITaskRunnerHostController runningController, JetBrains.ReSharper.UnitTestFramework.Strategy.IUnitTestRunStrategy strategy, System.Action runFinishAction) { }
        public void RunAll(JetBrains.ReSharper.UnitTestFramework.IHostProvider provider) { }
        public void SetActivePreviewPanel<T>()
            where T :  class, JetBrains.ReSharper.UnitTestFramework.IUnitTestPreviewPanel { }
        public void TaskDiscovered(JetBrains.ReSharper.UnitTestFramework.IUnitTestRun run, JetBrains.ReSharper.TaskRunnerFramework.RemoteTask task) { }
        public void TaskDuration(JetBrains.ReSharper.UnitTestFramework.IUnitTestRun run, JetBrains.ReSharper.TaskRunnerFramework.RemoteTask remoteTask, System.TimeSpan duration) { }
        public void TaskException(JetBrains.ReSharper.UnitTestFramework.IUnitTestRun run, JetBrains.ReSharper.TaskRunnerFramework.RemoteTask remoteTask, JetBrains.ReSharper.TaskRunnerFramework.TaskException[] exceptions) { }
        public void TaskFinished(JetBrains.ReSharper.UnitTestFramework.IUnitTestRun run, JetBrains.ReSharper.TaskRunnerFramework.RemoteTask remoteTask, string message, JetBrains.ReSharper.TaskRunnerFramework.TaskResult result) { }
        public void TaskOutput(JetBrains.ReSharper.UnitTestFramework.IUnitTestRun run, JetBrains.ReSharper.TaskRunnerFramework.RemoteTask remoteTask, string text, JetBrains.ReSharper.TaskRunnerFramework.TaskOutputType type) { }
        public void TaskStarting(JetBrains.ReSharper.UnitTestFramework.IUnitTestRun run, JetBrains.ReSharper.TaskRunnerFramework.RemoteTask remoteTask) { }
    }
}