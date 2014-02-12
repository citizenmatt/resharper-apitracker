[assembly: JetBrains.ActionManagement.ActionsXmlAttribute("JetBrains.ReSharper.Features.Common.resources.Actions.xml")]
[assembly: JetBrains.ActionManagement.ActionsXmlAttribute("JetBrains.ReSharper.Features.Common.resources.OccurenceBrowser-Actions.xml")]
[assembly: JetBrains.UI.Icons.CompiledIcons.CompiledIconsPackAttribute(IconNames=new string[] {
        "Xaml",
        "LanguagesCommon",
        "BuildScripts",
        "Master",
        "Vbnet",
        "Inc",
        "CodeStyleSharing",
        "CsharpOptionPage"}, IconPackResourceIdentification="JetBrains.ReSharper.Features.Common;component/src/Options/CommonFeaturesOptionsIc" +
    "ons/ThemedIcons.CommonFeaturesOptions.Generated.Xaml")]
[assembly: JetBrains.UI.Icons.CompiledIcons.CompiledIconsPackAttribute(IconNames=new string[] {
        "FindResultsToolWindow",
        "MergeOccurencesInFeaturesCommon",
        "UserTemplates",
        "UsageHandles"}, IconPackResourceIdentification="JetBrains.ReSharper.Features.Common;component/resources/FeaturesCommonThemedIcons" +
    "/ThemedIcons.FeaturesCommon.Generated.Xaml")]
[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]
[assembly: System.Windows.Markup.XmlnsDefinitionAttribute("urn:shemas-jetbrains-com:ui-application-icons-common-features-options", "JetBrains.ReSharper.Features.Common.Src.Options")]
[assembly: System.Windows.Markup.XmlnsDefinitionAttribute("urn:shemas-jetbrains-com:ui-application-icons-features-common", "JetBrains.ReSharper.Features.Common.Resources")]

namespace JetBrains.IDE.TreeBrowser
{
    
    public abstract class MyTreeModelBrowserPanelImpl
    {
        protected static readonly System.TimeSpan KeyboardDelay;
        protected readonly JetBrains.DataFlow.Lifetime myLifetime;
        protected MyTreeModelBrowserPanelImpl(JetBrains.DataFlow.Lifetime lifetime, JetBrains.IDE.TreeBrowser.TreeModelBrowserDescriptorBase descriptor, JetBrains.UI.Application.IUIApplication environment) { }
        protected JetBrains.ActionManagement.IActionBar ActionBar { get; }
        public JetBrains.UI.CrossFramework.EitherControl Control { get; }
        public JetBrains.IDE.TreeBrowser.TreeModelBrowserDescriptorBase Descriptor { get; }
        public JetBrains.UI.Application.IUIApplication Environment { get; }
        public string PreviewActionName { get; }
        public JetBrains.CommonControls.IPresentableItem PreviewCaption { get; set; }
        public System.Windows.Forms.Orientation PreviewOrientation { get; set; }
        public bool PreviewSupported { get; }
        public virtual bool PreviewVisible { get; set; }
        public JetBrains.TreeModels.TreeModel TreeModel { get; }
        protected JetBrains.IDE.TreeBrowser.UpdateKind UpdatePending { get; }
        protected virtual System.Windows.UIElement CreateActionBar(JetBrains.ActionManagement.IActionBarManager actionBarManager, string actionID) { }
        protected abstract System.Windows.UIElement CreateTree();
        protected virtual JetBrains.UI.TreeView.StructuredPresenter<JetBrains.TreeModels.TreeModelNode, JetBrains.CommonControls.IPresentableItem> GetPresenter() { }
        protected virtual void InitializeCustomBar() { }
        protected virtual void InitializeCustomControl() { }
        protected virtual void OnFocusedNodeChanged(System.EventArgs e) { }
        protected virtual void OnLoading() { }
        protected virtual void OnPreviewOrientationChanged() { }
        protected virtual void PerformUpdate() { }
        protected abstract void ReplaceModel(JetBrains.TreeModels.TreeModel treeModel);
        protected virtual void RequestImmediateUpdate() { }
        protected virtual void RequestPendingUpdate() { }
        protected void RequestUpdate(JetBrains.IDE.TreeBrowser.UpdateKind kind, bool immediate) { }
        protected abstract JetBrains.TreeModels.TreeModelNode SelectedModel();
        public virtual void SynchronizePreview() { }
        protected abstract void UpdateAllNodesPresentation();
    }
}
namespace JetBrains.IDE.TreeBrowser.WPF
{
    
    public class MyTreeModelBrowserPanelWPF : JetBrains.IDE.TreeBrowser.MyTreeModelBrowserPanelImpl, JetBrains.Application.DataContext.IDataRuleProvider, JetBrains.IDE.TreeBrowser.ITreePanelActions
    {
        public MyTreeModelBrowserPanelWPF(JetBrains.DataFlow.Lifetime lifetime, JetBrains.IDE.TreeBrowser.TreeModelBrowserDescriptorBase descriptor, JetBrains.UI.Application.IUIApplication environment) { }
        public JetBrains.IDE.TreeBrowser.WPF.TreeModelPresentableViewWPF TreeModelView { get; }
        public void CollapseAll() { }
        protected override System.Windows.UIElement CreateTree() { }
        [JetBrains.Annotations.NotNullAttribute()]
        protected virtual JetBrains.IDE.TreeBrowser.WPF.TreeModelPresentableViewWPF CreateView() { }
        protected virtual void CustomizeTreeView(JetBrains.IDE.TreeBrowser.WPF.TreeModelPresentableViewWPF treeModelView) { }
        public void ExpandAll() { }
        public void FocusOn(JetBrains.TreeModels.TreeModelNode node) { }
        public System.Collections.Generic.IEnumerable<JetBrains.Application.DataContext.IDataRule> GetDataRules() { }
        protected virtual bool Navigate(JetBrains.TreeModels.TreeModelNode node, bool transferFocus) { }
        protected virtual void ReplaceModel(JetBrains.TreeModels.TreeModel treeModel) { }
        protected override JetBrains.TreeModels.TreeModelNode SelectedModel() { }
        protected virtual void UpdateAllNodesPresentation() { }
    }
}
namespace JetBrains.ReSharper.Features.Common.AsyncTreeBrowser
{
    
    public interface ITreeModelAdapter
    {
        object RootNode { get; }
        void BuildOutgoing(object parentNode, JetBrains.Application.Progress.IProgressIndicator progressIndicator);
        System.Collections.ICollection GetOutgoing(object node);
        bool IsOutgoingBuilt(object node);
        bool RecursionPreventionCompare(object firstNode, object secondNode);
        bool SemanticCompare(object firstNode, object secondNode);
    }
    public class TreeAsyncModel : JetBrains.TreeModels.TreeModel
    {
        public System.Action<object, JetBrains.DataFlow.EventArgs<JetBrains.TreeModels.TreeModelNode>> OnExpandFailed;
        public TreeAsyncModel(JetBrains.ReSharper.Features.Common.AsyncTreeBrowser.ITreeModelAdapter modelAdapter) { }
        public TreeAsyncModel(System.Collections.Generic.IEqualityComparer<object> equalityComparer, JetBrains.ReSharper.Features.Common.AsyncTreeBrowser.ITreeModelAdapter modelAdapter) { }
        public JetBrains.ReSharper.Features.Common.AsyncTreeBrowser.ITreeModelAdapter ModelAdapter { get; }
        public JetBrains.TreeModels.RecursionPreventionStyle RecursionPrevention { get; set; }
        protected override JetBrains.TreeModels.TreeModelNode CreateNode(JetBrains.TreeModels.TreeModelNode parent, object value) { }
        public static bool IsProgressData(object firstNode) { }
        protected override void PerformUpdate() { }
    }
    public class TreeAsyncView : JetBrains.UI.TreeView.TreeModelPresentableView
    {
        protected TreeAsyncView(JetBrains.ReSharper.Features.Common.AsyncTreeBrowser.TreeAsyncModel model, JetBrains.UI.TreeView.ITreeViewController controller) { }
        protected override JetBrains.UI.TreeView.TreeModelViewNodeIterator CreateIterator(System.Predicate<JetBrains.UI.TreeView.TreeModelViewNode> predicate, JetBrains.UI.TreeView.TreeModelViewNodeIterator.IterationDirection direction, JetBrains.UI.TreeView.TreeModelViewNode startNode) { }
        public override void ExpandAll() { }
        protected override JetBrains.UI.RenderParams GetRenderParams(JetBrains.UI.TreeView.TreeModelViewNode viewNode) { }
        protected override void RaiseBeforeFocusNode(DevExpress.XtraTreeList.Nodes.TreeListNode oldNode, DevExpress.XtraTreeList.Nodes.TreeListNode newNode, ref bool canFocus) { }
        public void RemoveProgressNode(JetBrains.TreeModels.TreeModelNode modelNode) { }
        protected override void UpdateNodeCells(JetBrains.UI.TreeView.TreeModelViewNode viewNode, JetBrains.TreeModels.TreeModelNode modelNode, JetBrains.UI.TreeView.PresentationState state) { }
    }
    public class TreeModelAsyncViewNodeIterator : JetBrains.UI.TreeView.TreeModelViewNodeIterator
    {
        public TreeModelAsyncViewNodeIterator(JetBrains.UI.TreeView.TreeModelView modelView) { }
        public TreeModelAsyncViewNodeIterator(JetBrains.UI.TreeView.TreeModelView modelView, System.Predicate<JetBrains.UI.TreeView.TreeModelViewNode> predicate, JetBrains.UI.TreeView.TreeModelViewNodeIterator.IterationDirection direction, JetBrains.UI.TreeView.TreeModelViewNode startNode) { }
        protected override void EnsureChildren(JetBrains.UI.TreeView.TreeModelViewNode node) { }
        protected override bool HasChildren(JetBrains.UI.TreeView.TreeModelViewNode node) { }
    }
}
namespace JetBrains.ReSharper.Features.Common.Clipboard
{
    
    [JetBrains.Application.ShellComponentAttribute()]
    public class ClipboardManagerImpl : JetBrains.ReSharper.Feature.Services.Clipboard.ClipboardManager
    {
        public ClipboardManagerImpl(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ActionManagement.IActionManager actionManager) { }
        public override System.Collections.Generic.IEnumerable<System.Windows.Forms.IDataObject> ClipboardEntries { get; }
        public override void AddClipboardEntry(System.Windows.Forms.IDataObject dataObject) { }
        public override void RegisterCopyHandler(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ReSharper.Feature.Services.Clipboard.ClipboardManager.Handler handler) { }
        public override void RegisterCutHandler(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ReSharper.Feature.Services.Clipboard.ClipboardManager.Handler handler) { }
        public override void RegisterPasteHandler(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ReSharper.Feature.Services.Clipboard.ClipboardManager.Handler handler) { }
    }
    public abstract class OverridenActionHandler : JetBrains.ActionManagement.OverridingActionHandler
    {
        protected OverridenActionHandler(System.Collections.Generic.List<JetBrains.ReSharper.Feature.Services.Clipboard.ClipboardManager.Handler> handlers, string baseActionIds) { }
        public override void Execute(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.DelegateExecute nextExecute) { }
        public override bool Update(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.ActionPresentation presentation, JetBrains.ActionManagement.DelegateUpdate nextUpdate) { }
    }
}
namespace JetBrains.ReSharper.Features.Common.CodePreview
{
    
    public class CodePanel : JetBrains.UI.CommonControls.SafePanel, JetBrains.Application.DataContext.IDataRuleProvider
    {
        public CodePanel([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.ISolution solution, [JetBrains.Annotations.NotNullAttribute()] JetBrains.UI.WindowManagement.WindowFrame frame, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.IShellLocks locks, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Threading.IThreading invocator, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.ChangeManager changeManager, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.AsyncCommitService asyncCommitService, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Services.CachingLexerService cachingLexerService, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Daemon.Daemon daemon, [JetBrains.Annotations.NotNullAttribute()] JetBrains.UI.StatusBar.IStatusBar statusBar, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ActionManagement.IActionManager actionManager, JetBrains.TextControl.DocumentMarkup.IHighlighterCustomization highlighterCustomization, JetBrains.DocumentModel.IInMemoryDocumentFactory documentFactory, JetBrains.UI.Application.IUIApplication uiapp) { }
        public JetBrains.ReSharper.Daemon.Daemon Daemon { get; }
        public JetBrains.Threading.IThreading Invocator { get; }
        public JetBrains.Threading.GroupingEvent RedisplayGroupingEvent { get; }
        public event System.Action<JetBrains.ReSharper.Features.Common.CodePreview.CodePanel, JetBrains.ReSharper.Features.Common.CodePreview.CodePanelEventArgs> CodePanelChanged;
        public void Display(System.Collections.Generic.IList<JetBrains.DocumentModel.DocumentRange> ranges, JetBrains.Util.OneToListMap<JetBrains.DocumentModel.DocumentRange, JetBrains.TextControl.DocumentMarkup.IHighlighter> highlightingMap, JetBrains.DocumentModel.DocumentRange scrollRange) { }
        public JetBrains.Util.TextRange GetCodePanelRange(JetBrains.DocumentModel.DocumentRange realDocumentRange) { }
        public void OnActionExecuted(JetBrains.ReSharper.Psi.IAsyncCommitClient action) { }
        public void Show(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, System.Collections.Generic.IList<JetBrains.DocumentModel.DocumentRange> highlightedRanges) { }
        public void Show(JetBrains.Util.TextRange documentTextRange, JetBrains.ProjectModel.IProjectFile projectFile, System.Collections.Generic.IList<JetBrains.DocumentModel.DocumentRange> highlightedRanges) { }
        public void Show(JetBrains.ProjectModel.IProjectFile projectFile, System.Collections.Generic.IList<JetBrains.DocumentModel.DocumentRange> highlightedRanges) { }
        public void ShowDefaultMessage() { }
        protected override void WndProc(ref System.Windows.Forms.Message m) { }
    }
    public class CodePanelEventArgs : System.EventArgs
    {
        public CodePanelEventArgs(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, JetBrains.ProjectModel.IProjectFile file) { }
        public JetBrains.ReSharper.Psi.IDeclaredElement Container { get; }
        public JetBrains.ProjectModel.IProjectFile File { get; }
    }
}
namespace JetBrains.ReSharper.Features.Common.ComponentsAPI
{
    
    public interface IModelInitializer
    {
        void InitModel(JetBrains.DataFlow.Lifetime lifetime, JetBrains.UI.GotoByName.GotoByNameModel model);
    }
    public interface ITypeHierarchyHelper
    {
        bool AllowExcludingExternalElements();
    }
}
namespace JetBrains.ReSharper.Features.Common.FindResultsBrowser
{
    
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class FindResultsBrowser
    {
        public FindResultsBrowser(JetBrains.Application.Settings.ISettingsStore settingsStore, JetBrains.DataFlow.Lifetime lifetime, JetBrains.UI.ToolWindowManagement.ToolWindowManager toolWindowManager, JetBrains.Application.IShellLocks locks, JetBrains.ActionManagement.IActionManager actionManager, JetBrains.ActionManagement.IActionBarManager actionBarManager, JetBrains.ActionManagement.IShortcutManager shortcutManager, JetBrains.ReSharper.Psi.Files.IPsiFiles psiFiles, JetBrains.ReSharper.Features.Common.FindResultsBrowser.FindResultsToolWindowDescriptor toolWindowDescriptor, JetBrains.UI.Icons.IThemedIconManager themedIconManager, JetBrains.UI.Components.Theming.IColorThemeManager themeManager, JetBrains.ProjectModel.ISolution solution, JetBrains.UI.Application.IUIApplication environment) { }
        public static void ShowResults(JetBrains.ReSharper.Features.Common.Occurences.OccurenceBrowserDescriptor descriptor) { }
    }
    [JetBrains.UI.ToolWindowManagement.ToolWindowDescriptorAttribute(Icon=typeof(JetBrains.ReSharper.Features.Common.Resources.FeaturesCommonThemedIcons.FindResultsToolWindow), InitialDocking=JetBrains.UI.ToolWindowManagement.ToolWindowInitialDocking.Bottom, ProductNeutralId="SearchResultsWindow", Text="Find Results", Type=JetBrains.UI.ToolWindowManagement.ToolWindowType.MultiInstance, VisibilityPersistenceScope=JetBrains.UI.ToolWindowManagement.ToolWindowVisibilityPersistenceScope.Solution)]
    public class FindResultsToolWindowDescriptor : JetBrains.UI.ToolWindowManagement.ToolWindowDescriptor
    {
        public FindResultsToolWindowDescriptor(JetBrains.Application.IApplicationDescriptor applicationDescriptor) { }
    }
}
namespace JetBrains.ReSharper.Features.Common.GoToByName.Controllers
{
    
    public class FullNavigationItemData
    {
        public FullNavigationItemData(JetBrains.ReSharper.Feature.Services.Goto.MatchingInfo firstWordMatchingInfo, JetBrains.ReSharper.Feature.Services.Goto.IApplicableGotoProvider provider, JetBrains.ReSharper.Feature.Services.Goto.INavigationScope scope, JetBrains.ReSharper.Feature.Services.Search.IOccurence occurence = null) { }
        public JetBrains.ReSharper.Feature.Services.Goto.MatchingInfo ChainedMatchingInfo { get; }
        public JetBrains.ReSharper.Feature.Services.Goto.IApplicableGotoProvider NavigationProvider { get; }
        public JetBrains.ReSharper.Feature.Services.Goto.INavigationScope Scope { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.Search.IOccurence> GetOccurences(JetBrains.ReSharper.Feature.Services.Goto.GotoContext gotoContext, JetBrains.Application.CheckForInterrupt checkCancelled) { }
    }
    public abstract class GotoControllerBase<TGotoProvider, TGotoChainedProvider> : JetBrains.UI.GotoByName.GotoByNameController
        where TGotoProvider :  class, JetBrains.ReSharper.Feature.Services.Goto.IOccurenceNavigationProvider
        where TGotoChainedProvider :  class, JetBrains.ReSharper.Feature.Services.Goto.ChainedProviders.IChainedSearchProvider
    {
        [JetBrains.Annotations.NotNullAttribute()]
        protected JetBrains.DataFlow.Property<System.Func<JetBrains.ReSharper.Feature.Services.Search.IOccurence, bool>> ItemsPassFilter;
        [JetBrains.Annotations.CanBeNullAttribute()]
        protected readonly object ScopeData;
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ProjectModel.ISolution Solution;
        protected GotoControllerBase([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.ISolution solution, [JetBrains.Annotations.CanBeNullAttribute()] object scopeData, JetBrains.ReSharper.Feature.Services.Search.LibrariesFlag librariesFlag, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.IShellLocks locks, bool enableMulticore) { }
        protected virtual bool InstantItemsAllowed { get; }
        public bool LibrariesFlagAutoSwitch { get; set; }
        protected virtual int NonInstantItemsCount { get; }
        protected int WordsCount { get; }
        protected virtual System.Collections.Generic.List<string> AnalyzeFilterForWords(string filterString) { }
        protected override void BeforeUpdateItems() { }
        public void ConsumePresentableItems(string filterString, int itemsCount, System.Action<System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Features.Common.GoToByName.Controllers.PresentableGotoItem>, JetBrains.UI.GotoByName.GotoByNameController.AddItemsBehavior> itemsConsumer) { }
        protected override bool ExecuteItem(JetBrains.UI.PopupMenu.Impl.JetPopupMenuItem item, JetBrains.DataFlow.ISignal<bool> closeBeforeExecute) { }
        protected virtual System.Nullable<JetBrains.ReSharper.Feature.Services.Occurences.OccurencePresentationOptions> GetPresentationOptions() { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        protected virtual string GetWildcardFilter(string filterString) { }
        protected abstract System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.Goto.ChainedNavigationItemData> InitScopes(bool isSearchingInLibs);
        public virtual bool IsSpecialString(ref string filterString) { }
        public void RestrictItemsPassFilterForOccurence([JetBrains.Annotations.NotNullAttribute()] System.Func<JetBrains.ReSharper.Feature.Services.Search.IOccurence, bool> funcAdd) { }
        protected virtual int ScoreMatchingInfo(JetBrains.ReSharper.Features.Common.GoToByName.Controllers.FullNavigationItemData fullNavigationItemData, System.Collections.Generic.List<string> revertedWords, string wildCardFilter) { }
        protected virtual void SortMatchingInfos(System.Collections.Generic.List<JetBrains.ReSharper.Features.Common.GoToByName.Controllers.FullNavigationItemData> pairs, System.Collections.Generic.IEnumerable<string> words, JetBrains.Text.IdentifierMatcher matcher, string wildCardFilter) { }
        protected System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Features.Common.GoToByName.Controllers.PresentableGotoItem> SortOccurences(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Features.Common.GoToByName.Controllers.PresentableGotoItem> items, string filterString) { }
        protected override bool UpdateItems(string filterString, System.Func<System.Collections.Generic.IEnumerable<JetBrains.UI.PopupMenu.Impl.JetPopupMenuItem>, JetBrains.UI.GotoByName.GotoByNameController.AddItemsBehavior, bool> itemsConsumer) { }
    }
    public class GotoDeclaredElementController : JetBrains.ReSharper.Features.Common.GoToByName.Controllers.GotoControllerBase<JetBrains.ReSharper.Feature.Services.Goto.IGotoTypeProvider, JetBrains.ReSharper.Feature.Services.Goto.ChainedProviders.IChainedNamespacesProvider>, JetBrains.ReSharper.Feature.Services.Goto.ICompletionGotoController
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly string DeclaredElementKindDisplayName;
        protected GotoDeclaredElementController([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Feature.Services.Search.LibrariesFlag librariesFlag, [JetBrains.Annotations.NotNullAttribute()] string sDeclaredElementKindDisplayName, JetBrains.Application.IShellLocks locks, bool enableMulticore = False) { }
        protected override System.Collections.Generic.List<string> AnalyzeFilterForWords(string filterString) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.ReSharper.Features.Common.GoToByName.Controllers.GotoDeclaredElementController CreateGotoDeclaredElementController([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Feature.Services.Search.LibrariesFlag librariesFlag, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.IShellLocks locks) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.ReSharper.Features.Common.GoToByName.Controllers.GotoNamespaceController CreateGotoNamespaceController([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Feature.Services.Search.LibrariesFlag librariesFlag, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.IShellLocks locks) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.UI.GotoByName.GotoByNameModel CreateGotoTypeModel([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Feature.Services.Search.LibrariesFlag librariesFlag, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.IShellLocks locks) { }
        protected override System.Nullable<JetBrains.ReSharper.Feature.Services.Occurences.OccurencePresentationOptions> GetPresentationOptions() { }
        protected override System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.Goto.ChainedNavigationItemData> InitScopes(bool isSearchingInLibs) { }
        public void RestrictItemsPassFilter([JetBrains.Annotations.NotNullAttribute()] System.Func<JetBrains.ReSharper.Psi.IDeclaredElement, bool> funcAdd) { }
    }
    public class GotoEverythingController : JetBrains.ReSharper.Features.Common.GoToByName.Controllers.GotoControllerBase<JetBrains.ReSharper.Feature.Services.Goto.IGotoEverythingProvider, JetBrains.ReSharper.Feature.Services.Goto.ChainedProviders.IChainedSearchEverythingProvider>
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly string DeclaredElementKindDisplayName;
        protected GotoEverythingController([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Feature.Services.Search.LibrariesFlag librariesFlag, [JetBrains.Annotations.NotNullAttribute()] string sDeclaredElementKindDisplayName, JetBrains.Application.IShellLocks locks, bool enableMulticore = False) { }
        protected override bool InstantItemsAllowed { get; }
        public override int MenuItemsCountLimit { get; }
        protected override int NonInstantItemsCount { get; }
        protected override System.Collections.Generic.List<string> AnalyzeFilterForWords(string filterString) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.ReSharper.Features.Common.GoToByName.Controllers.GotoEverythingController CreateGotoEverythingController([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Feature.Services.Search.LibrariesFlag librariesFlag, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.IShellLocks locks) { }
        protected override string GetWildcardFilter(string filterString) { }
        protected override System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.Goto.ChainedNavigationItemData> InitScopes(bool isSearchingInLibs) { }
        public override bool IsSpecialString(ref string filterString) { }
        public void RestrictItemsPassFilter([JetBrains.Annotations.NotNullAttribute()] System.Func<JetBrains.ReSharper.Psi.IDeclaredElement, bool> funcAdd) { }
        protected override int ScoreMatchingInfo(JetBrains.ReSharper.Features.Common.GoToByName.Controllers.FullNavigationItemData fullNavigationItemData, System.Collections.Generic.List<string> revertedWords, string wildCardFilter) { }
    }
    public class GotoFileController : JetBrains.ReSharper.Features.Common.GoToByName.Controllers.GotoControllerBase<JetBrains.ReSharper.Feature.Services.Goto.IGotoFileProvider, JetBrains.ReSharper.Feature.Services.Goto.ChainedProviders.IChainedProjectElementProvider>
    {
        public GotoFileController([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.ISolution solution, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.IShellLocks locks, bool enableMulticore = False) { }
        protected override System.Collections.Generic.List<string> AnalyzeFilterForWords(string filterString) { }
        public bool DefaultFileFilter(JetBrains.ReSharper.Feature.Services.Search.IOccurence occurence) { }
        protected override System.Nullable<JetBrains.ReSharper.Feature.Services.Occurences.OccurencePresentationOptions> GetPresentationOptions() { }
        protected override System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.Goto.ChainedNavigationItemData> InitScopes(bool isSearchingInLibs) { }
        public override bool IsSpecialString(ref string filterString) { }
        public void RestrictItemsPassFilter(System.Func<JetBrains.ProjectModel.IProjectItem, bool> funcAdd) { }
    }
    public class GotoNamespaceController : JetBrains.ReSharper.Features.Common.GoToByName.Controllers.GotoControllerBase<JetBrains.ReSharper.Feature.Services.Goto.GotoProviders.IGotoNamespaceProvider, JetBrains.ReSharper.Feature.Services.Goto.ChainedProviders.IChainedSearchProvider>, JetBrains.ReSharper.Feature.Services.Goto.ICompletionGotoController
    {
        public GotoNamespaceController([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.ISolution solution, [JetBrains.Annotations.CanBeNullAttribute()] object scopeData, JetBrains.ReSharper.Feature.Services.Search.LibrariesFlag librariesFlag, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.IShellLocks locks, bool enableMulticore) { }
        protected override System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.Goto.ChainedNavigationItemData> InitScopes(bool isSearchingInLibs) { }
        public void RestrictItemsPassFilter(System.Func<JetBrains.ReSharper.Psi.IDeclaredElement, bool> filter) { }
    }
    public class GotoSymbolController : JetBrains.ReSharper.Features.Common.GoToByName.Controllers.GotoControllerBase<JetBrains.ReSharper.Feature.Services.Goto.IGotoSymbolProvider, JetBrains.ReSharper.Feature.Services.Goto.ChainedProviders.IChainedSymbolProvider>
    {
        public GotoSymbolController([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Feature.Services.Search.LibrariesFlag librariesFlag, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.IShellLocks locks, bool enableMulticore = False) { }
        protected override System.Collections.Generic.List<string> AnalyzeFilterForWords(string filterString) { }
        public static JetBrains.UI.GotoByName.GotoByNameModel CreateGotoSymbolModel(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Psi.Modules.IPsiModule project, JetBrains.ReSharper.Feature.Services.Search.LibrariesFlag librariesFlag, JetBrains.Application.IShellLocks locks, bool enableMulticore) { }
        protected override System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.Goto.ChainedNavigationItemData> InitScopes(bool isSearchingInLibs) { }
    }
    public class PresentableGotoItem
    {
        public PresentableGotoItem(JetBrains.ReSharper.Feature.Services.Search.IOccurence occurence, JetBrains.ReSharper.Feature.Services.Goto.MatchingInfo matchingInfo, JetBrains.ReSharper.Feature.Services.Goto.IApplicableGotoProvider provider, bool isInstant = False) { }
        public bool IsInstant { get; }
        public JetBrains.ReSharper.Feature.Services.Goto.MatchingInfo MatchingInfo { get; }
        public JetBrains.ReSharper.Feature.Services.Search.IOccurence Occurence { get; }
        public JetBrains.ReSharper.Feature.Services.Goto.IApplicableGotoProvider Provider { get; }
        protected bool Equals(JetBrains.ReSharper.Features.Common.GoToByName.Controllers.PresentableGotoItem other) { }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
    }
}
namespace JetBrains.ReSharper.Features.Common.GoToByName
{
    
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class GotoByNameModelManager
    {
        public GotoByNameModelManager(JetBrains.ProjectModel.ISolution solution) { }
        public static JetBrains.ReSharper.Features.Common.GoToByName.GotoByNameModelManager GetInstance(JetBrains.ProjectModel.ISolution solution) { }
        public void ProcessModel<TModelInitializer>(JetBrains.UI.GotoByName.GotoByNameModel model, JetBrains.DataFlow.Lifetime lifetime)
            where TModelInitializer :  class, JetBrains.ReSharper.Features.Common.ComponentsAPI.IModelInitializer { }
    }
    public class GoToCamelCasePrefixMatcher : JetBrains.ReSharper.Feature.Services.Filtering.CamelCasePrefixMatcher
    {
        public GoToCamelCasePrefixMatcher(string prefix, bool appendEnding, bool bMatchBeginningOfStringOnly) { }
        public override string BuildRegexString(string prefix) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class GotoMerger
    {
        protected static bool DiffersByExtension(JetBrains.ReSharper.Features.Common.GoToByName.Controllers.PresentableGotoItem name, JetBrains.ReSharper.Features.Common.GoToByName.Controllers.PresentableGotoItem nameWithExtension) { }
        protected virtual System.Collections.Generic.IEnumerable<System.Func<JetBrains.ReSharper.Features.Common.GoToByName.Controllers.PresentableGotoItem, JetBrains.ReSharper.Features.Common.GoToByName.Controllers.PresentableGotoItem, bool>> GetAllItemsMergeRules() { }
        protected virtual System.Collections.Generic.IEnumerable<System.Func<JetBrains.ReSharper.Features.Common.GoToByName.Controllers.PresentableGotoItem, JetBrains.ReSharper.Features.Common.GoToByName.Controllers.PresentableGotoItem, bool>> GetInstantAndCommonItemsMergeRules() { }
        protected static bool InstantTypeOverType(JetBrains.ReSharper.Features.Common.GoToByName.Controllers.PresentableGotoItem instantType, JetBrains.ReSharper.Features.Common.GoToByName.Controllers.PresentableGotoItem commonType) { }
        public void MergeInstantAndCommonItems(System.Collections.Generic.List<JetBrains.ReSharper.Features.Common.GoToByName.Controllers.PresentableGotoItem> instantItems, System.Collections.Generic.List<JetBrains.ReSharper.Features.Common.GoToByName.Controllers.PresentableGotoItem> commonItems) { }
        public void MergeItems(System.Collections.Generic.List<JetBrains.ReSharper.Features.Common.GoToByName.Controllers.PresentableGotoItem> topMatchingInfos) { }
        protected bool RecentEditOverCommon(JetBrains.ReSharper.Features.Common.GoToByName.Controllers.PresentableGotoItem recentMethod, JetBrains.ReSharper.Features.Common.GoToByName.Controllers.PresentableGotoItem method) { }
        protected static bool RecentOrInstantFileOverFile(JetBrains.ReSharper.Features.Common.GoToByName.Controllers.PresentableGotoItem recentFile, JetBrains.ReSharper.Features.Common.GoToByName.Controllers.PresentableGotoItem file) { }
        protected bool UpperTypeOverLowerFile(JetBrains.ReSharper.Features.Common.GoToByName.Controllers.PresentableGotoItem data1, JetBrains.ReSharper.Features.Common.GoToByName.Controllers.PresentableGotoItem data2) { }
    }
}
namespace JetBrains.ReSharper.Features.Common.GoToByName.ModelInitializers
{
    
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class GotoFileModelInitializer : JetBrains.ReSharper.Features.Common.ComponentsAPI.IModelInitializer
    {
        public virtual void InitModel(JetBrains.DataFlow.Lifetime lifetime, JetBrains.UI.GotoByName.GotoByNameModel model) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class GotoSymbolModelInitializer : JetBrains.ReSharper.Features.Common.ComponentsAPI.IModelInitializer
    {
        protected virtual bool ShowCheckBox { get; }
        public virtual void InitModel(JetBrains.DataFlow.Lifetime lifetime, JetBrains.UI.GotoByName.GotoByNameModel model) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class GotoTypeModelInitializer : JetBrains.ReSharper.Features.Common.ComponentsAPI.IModelInitializer
    {
        protected virtual bool ShowCheckBox { get; }
        public virtual void InitModel(JetBrains.DataFlow.Lifetime lifetime, JetBrains.UI.GotoByName.GotoByNameModel model) { }
    }
}
namespace JetBrains.ReSharper.Features.Common.Occurences
{
    
    [JetBrains.ReSharper.Feature.Services.Occurences.OccurenceProviderAttribute(Priority=0)]
    public class DefaultOccurenceProvider : JetBrains.ReSharper.Feature.Services.Occurences.IOccurenceProvider
    {
        public JetBrains.ReSharper.Feature.Services.Search.IOccurence MakeOccurence(JetBrains.ReSharper.Psi.Search.FindResult result) { }
    }
    public class GroupingSectionId : JetBrains.Util.EnumPattern
    {
        public static JetBrains.ReSharper.Features.Common.Occurences.GroupingSectionId CompiledUsagesSection;
        public static JetBrains.ReSharper.Features.Common.Occurences.GroupingSectionId DefaultSection;
        public static JetBrains.ReSharper.Features.Common.Occurences.GroupingSectionId LateBoundUsagesSection;
        public static JetBrains.ReSharper.Features.Common.Occurences.GroupingSectionId TextualUsagesSection;
        public GroupingSectionId([JetBrains.Annotations.NotNullAttribute()] string name, int priority = 0) { }
        public int Priority { get; }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class NavigationSettings
    {
        public NavigationSettings(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Settings.ISettingsStore settingsStore, JetBrains.DataFlow.Lifetime lifetime) { }
        public bool AutoExpandResultsExpression { get; }
        public static JetBrains.ReSharper.Features.Common.Occurences.NavigationSettings GetInstance(JetBrains.ProjectModel.ISolution solution) { }
    }
    public abstract class OccurenceBrowserDescriptor : JetBrains.ReSharper.Features.Common.TreePsiBrowser.TreeModelBrowserDescriptorPsi
    {
        protected OccurenceBrowserDescriptor([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.ISolution solution) { }
        public override string ActionBarID { get; }
        public JetBrains.TreeModels.TreeModelGrouping<JetBrains.ReSharper.Feature.Services.Search.IOccurence> ActiveGrouping { get; }
        public override string ContextMenuID { get; }
        protected virtual int DefaultGroupingIndex { get; set; }
        protected bool DrawElementExtensions { get; set; }
        public System.Collections.Generic.List<JetBrains.TreeModels.TreeModelGrouping<JetBrains.ReSharper.Feature.Services.Search.IOccurence>> Groupings { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.Search.IOccurence> Items { get; }
        public bool MergeOccurences { get; set; }
        public System.Collections.Generic.ICollection<JetBrains.ReSharper.Features.Common.Occurences.OccurenceSection> OccurenceSections { get; }
        public override JetBrains.UI.TreeView.StructuredPresenter<JetBrains.TreeModels.TreeModelNode, JetBrains.CommonControls.IPresentableItem> Presenter { get; }
        public override JetBrains.IDE.TreeBrowser.PreviewSupport PreviewSupport { get; }
        public override bool AcceptOccurence(object value) { }
        public bool AccessTypePresent(JetBrains.ReSharper.Feature.Services.Occurences.OccurenceKindProviders.OccurenceKind occurenceKind) { }
        protected virtual JetBrains.ReSharper.Features.Common.Occurences.OccurenceEqualityComparer CreateEqualityComparer() { }
        protected virtual void CreateGroupings(System.Collections.Generic.List<JetBrains.TreeModels.TreeModelGrouping<JetBrains.ReSharper.Feature.Services.Search.IOccurence>> groupings) { }
        public override bool CustomizeActionBar(JetBrains.ActionManagement.IActionBar bar) { }
        public override bool ExpandNodeInitially(JetBrains.TreeModels.TreeModelNode modelNode) { }
        protected virtual void FillSections(System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.Search.IOccurence> items) { }
        protected virtual System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.Occurences.OccurenceKindProviders.OccurenceKind> GetAllOccurenceKinds() { }
        protected System.Collections.Generic.List<JetBrains.ReSharper.Features.Common.Occurences.GroupingSectionId> GetContainingSection(JetBrains.ReSharper.Feature.Services.Search.IOccurence item) { }
        public override System.Collections.Generic.IEnumerable<JetBrains.TreeModels.TreeModelNode> GetDefaultNodes(JetBrains.TreeModels.TreeModel model) { }
        protected virtual System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.Occurences.OccurenceKindProviders.OccurenceKind> GetOccurenceKinds(JetBrains.ReSharper.Feature.Services.Search.IOccurence occurence) { }
        protected virtual void GroupChangeCommitted(object sender, System.EventArgs e) { }
        public bool IsShownAccessType(JetBrains.ReSharper.Feature.Services.Occurences.OccurenceKindProviders.OccurenceKind occurenceKind) { }
        public bool IsShownOnlyAccessType(JetBrains.ReSharper.Feature.Services.Occurences.OccurenceKindProviders.OccurenceKind occurenceKind) { }
        public override bool Navigate(JetBrains.TreeModels.TreeModelNode node, JetBrains.UI.PopupWindowManager.PopupWindowContextSource windowContext, bool transferFocus, JetBrains.IDE.TabOptions options = 2) { }
        public override System.Windows.Forms.Control PreviewCreateControl(JetBrains.UI.WindowManagement.WindowFrame framePreview) { }
        public override void PreviewUpdate(System.Windows.Forms.Control previewControl, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.TreeModels.TreeModelNode modelNode, ref JetBrains.CommonControls.IPresentableItem previewCaption) { }
        protected void Regroup() { }
        protected void RemoveItem(JetBrains.ReSharper.Feature.Services.Search.IOccurence occurence) { }
        public void SetGrouping(JetBrains.TreeModels.TreeModelGrouping<JetBrains.ReSharper.Feature.Services.Search.IOccurence> grouping) { }
        protected virtual void SetResults([JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.Search.IOccurence> items, JetBrains.Application.Progress.IProgressIndicator indicator = null, bool mergeKinds = True) { }
        public void ShowAccessType(JetBrains.ReSharper.Feature.Services.Occurences.OccurenceKindProviders.OccurenceKind occurenceKind, bool show) { }
        public void ShowAllAccessTypes() { }
        public void ShowOnlyAccessType(JetBrains.ReSharper.Feature.Services.Occurences.OccurenceKindProviders.OccurenceKind occurenceKind, bool show) { }
        public static void SortSections(System.Collections.Generic.List<JetBrains.ReSharper.Features.Common.Occurences.OccurenceSection> values) { }
    }
    [JetBrains.ReSharper.Psi.ShellFeaturePartAttribute()]
    public class OccurenceBrowserGroupingProvider : JetBrains.ReSharper.Features.Shared.GroupingManagement.IGroupingProvider<JetBrains.ReSharper.Feature.Services.Search.IOccurence>
    {
        public virtual System.Collections.Generic.ICollection<JetBrains.TreeModels.TreeModelGrouping<JetBrains.ReSharper.Feature.Services.Search.IOccurence>> GetGroupings(JetBrains.IDE.TreeBrowser.TreeModelBrowserDescriptorBase descriptor) { }
        public virtual bool IsApplicable(JetBrains.IDE.TreeBrowser.TreeModelBrowserDescriptorBase descriptor) { }
        protected class DirectoryGroupProvider : JetBrains.TreeModels.ITreeGroupProvider<JetBrains.ReSharper.Feature.Services.Search.IOccurence>
        {
            public object ExtractGroupObject(JetBrains.ReSharper.Feature.Services.Search.IOccurence item) { }
        }
        protected class ExternalLibrariesGroupProvider : JetBrains.TreeModels.ITreeGroupProvider<JetBrains.ReSharper.Feature.Services.Search.IOccurence>
        {
            public object ExtractGroupObject(JetBrains.ReSharper.Feature.Services.Search.IOccurence item) { }
        }
        protected class NamespaceGroupProvider : JetBrains.TreeModels.ITreeGroupProvider<JetBrains.ReSharper.Feature.Services.Search.IOccurence>
        {
            public object ExtractGroupObject(JetBrains.ReSharper.Feature.Services.Search.IOccurence item) { }
        }
        protected class ProjectFileGroupProvider : JetBrains.TreeModels.ITreeGroupProvider<JetBrains.ReSharper.Feature.Services.Search.IOccurence>
        {
            public object ExtractGroupObject(JetBrains.ReSharper.Feature.Services.Search.IOccurence item) { }
        }
        protected class ProjectGroupProvider : JetBrains.TreeModels.ITreeGroupProvider<JetBrains.ReSharper.Feature.Services.Search.IOccurence>
        {
            public object ExtractGroupObject(JetBrains.ReSharper.Feature.Services.Search.IOccurence item) { }
        }
        protected class ProjectStructureProvider : JetBrains.TreeModels.ITreeGroupProvider<JetBrains.ReSharper.Feature.Services.Search.IOccurence>
        {
            public object ExtractGroupObject(JetBrains.ReSharper.Feature.Services.Search.IOccurence item) { }
        }
        protected class TypeElementGroupProvider : JetBrains.TreeModels.ITreeGroupProvider<JetBrains.ReSharper.Feature.Services.Search.IOccurence>
        {
            public object ExtractGroupObject(JetBrains.ReSharper.Feature.Services.Search.IOccurence item) { }
        }
        protected class TypeMemberGroupProvider : JetBrains.TreeModels.ITreeGroupProvider<JetBrains.ReSharper.Feature.Services.Search.IOccurence>
        {
            public object ExtractGroupObject(JetBrains.ReSharper.Feature.Services.Search.IOccurence item) { }
        }
    }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "OccurenceBrowser.MergeOccurences"})]
    public class OccurenceBrowserMergeAction : JetBrains.ActionManagement.IActionHandler
    {
        public void Execute(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.DelegateExecute nextExecute) { }
        public bool Update(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.ActionPresentation presentation, JetBrains.ActionManagement.DelegateUpdate nextUpdate) { }
    }
    public class OccurenceBrowserPresenter : JetBrains.ReSharper.Features.Shared.TreePsiBrowser.TreeModelBrowserPresenter
    {
        public OccurenceBrowserPresenter() { }
        protected override void HighlightDeclaredElement(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, JetBrains.ReSharper.Psi.PsiLanguageType languageType, JetBrains.CommonControls.IPresentableItem item, JetBrains.TreeModels.TreeModelNode modelNode, JetBrains.ReSharper.Psi.DeclaredElementPresenterMarking marking) { }
        public void PresentRangeOccurence(JetBrains.CommonControls.IPresentableItem item, JetBrains.ReSharper.Feature.Services.Navigation.Occurences.RangeOccurence rangeOccurence) { }
        protected override object Unwrap(object value) { }
    }
    public class OccurenceComparer : JetBrains.ReSharper.Features.Shared.TreePsiBrowser.TreeModelBrowserComparer
    {
        public OccurenceComparer(JetBrains.ProjectModel.IProjectPresentablePathProvider provider) { }
        protected OccurenceComparer() { }
        protected override object Unwrap(object wrapper) { }
    }
    public class OccurenceEqualityComparer : System.Collections.Generic.IEqualityComparer<object>
    {
        public OccurenceEqualityComparer(JetBrains.ProjectModel.ISolution solution) { }
        protected virtual bool CompareDeclaredElementOccurences(JetBrains.ReSharper.Feature.Services.Occurences.DeclaredElementOccurence xDeclaredElementOccurence, JetBrains.ReSharper.Feature.Services.Occurences.DeclaredElementOccurence yDeclaredElementOccurence) { }
        protected virtual bool CompareOccurences(JetBrains.ReSharper.Feature.Services.Search.IOccurence x, JetBrains.ReSharper.Feature.Services.Search.IOccurence y) { }
        protected bool CompareRangeOccurences(JetBrains.ReSharper.Feature.Services.Navigation.Occurences.RangeOccurence xRangeOccurence, JetBrains.ReSharper.Feature.Services.Navigation.Occurences.RangeOccurence yRangeOccurence) { }
        protected virtual bool CompareReferenceOccurences(JetBrains.ReSharper.Feature.Services.Occurences.ReferenceOccurence xReferenceOccurence, JetBrains.ReSharper.Feature.Services.Occurences.ReferenceOccurence yReferenceOccurence) { }
        protected virtual int GetOccurenceHashCode(JetBrains.ReSharper.Feature.Services.Search.IOccurence occurence) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class OccurencePopupMenu
    {
        public static readonly JetBrains.UI.Icons.IconId IconShowInFindResults;
        public const int ITEMS_COUNT_LIMIT = 100000;
        public OccurencePopupMenu(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.IShellLocks locks, JetBrains.DataFlow.Lifetime lifetime) { }
        public static JetBrains.ReSharper.Features.Common.Occurences.OccurencePopupMenu GetInstance(JetBrains.ProjectModel.ISolution solution) { }
        public virtual void ShowMenuFromTextControl<TDescriptor>(JetBrains.Application.DataContext.IDataContext context, System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.Search.IOccurence> items, System.Func<TDescriptor> descriptorBuilder, System.Nullable<JetBrains.ReSharper.Feature.Services.Occurences.OccurencePresentationOptions> options, bool skipMenuIfSingleEnabled, string title, int itemsCountLimit = 100000)
            where TDescriptor : JetBrains.ReSharper.Features.Common.Occurences.OccurenceBrowserDescriptor { }
        public virtual void ShowMenuGlobal(string title, bool skipMenuIfSingleEnabled, System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.Search.IOccurence> items, JetBrains.ReSharper.Feature.Services.Navigation.NavigationOptions options, JetBrains.ReSharper.Feature.Services.Occurences.OccurencePresentationOptions presentationOptions, System.Func<JetBrains.ReSharper.Features.Common.Occurences.OccurenceBrowserDescriptor> descriptorBuilder) { }
    }
    public class OccurenceSection
    {
        public OccurenceSection(JetBrains.ReSharper.Features.Common.Occurences.GroupingSectionId sectionType) { }
        public OccurenceSection(JetBrains.ReSharper.Feature.Services.Search.OccurenceType occurenceType) { }
        public int FilteredCount { get; set; }
        public System.Collections.Generic.List<JetBrains.ReSharper.Feature.Services.Search.IOccurence> Items { get; set; }
        public JetBrains.TreeModels.TreeGroupModel<JetBrains.ReSharper.Feature.Services.Search.IOccurence> Model { get; set; }
        public JetBrains.ReSharper.Features.Common.Occurences.GroupingSectionId SectionName { get; }
        public int TotalCount { get; set; }
    }
    [JetBrains.ReSharper.Psi.ShellFeaturePartAttribute()]
    public class OccurenceSectionProvider : JetBrains.ReSharper.Features.Common.SectionsManagement.IOccurenceSectionProvider
    {
        public virtual System.Collections.Generic.ICollection<JetBrains.ReSharper.Features.Common.Occurences.GroupingSectionId> GetGroupSectionId(JetBrains.ReSharper.Feature.Services.Search.IOccurence occurence, JetBrains.ReSharper.Features.Common.Occurences.OccurenceBrowserDescriptor descriptor) { }
        public virtual System.Collections.Generic.ICollection<JetBrains.TreeModels.TreeSection> GetTreeSections(JetBrains.ReSharper.Features.Common.Occurences.OccurenceBrowserDescriptor descriptor) { }
        public virtual bool IsApplicable(JetBrains.ReSharper.Features.Common.Occurences.OccurenceBrowserDescriptor descriptor) { }
    }
    public class static OccurenceUtil
    {
        public static int CompareDeclaredElementOccurences(JetBrains.ReSharper.Feature.Services.Occurences.DeclaredElementOccurence x, JetBrains.ReSharper.Feature.Services.Occurences.DeclaredElementOccurence y) { }
        public static int CompareDeclaredElements(JetBrains.ReSharper.Psi.IDeclaredElement xDeclaredElement, JetBrains.ReSharper.Psi.IDeclaredElement yDeclaredElement) { }
        public static int CompareOccurences(JetBrains.ReSharper.Feature.Services.Search.IOccurence x, JetBrains.ReSharper.Feature.Services.Search.IOccurence y, System.Nullable<JetBrains.ReSharper.Feature.Services.Occurences.OccurencePresentationOptions> options) { }
        public static int CompareRangeOccurences(JetBrains.ReSharper.Feature.Services.Navigation.Occurences.RangeOccurence x, JetBrains.ReSharper.Feature.Services.Navigation.Occurences.RangeOccurence y) { }
        public static JetBrains.ReSharper.Feature.Services.Occurences.DeclaredElementOccurence CreateOccurence(this JetBrains.ReSharper.Psi.IDeclaredElement targetElement) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Psi.IDeclaredElement GetDeclaredElement(this JetBrains.ReSharper.Feature.Services.Search.IOccurence occurence) { }
        public static JetBrains.ReSharper.Features.Common.Occurences.GroupingSectionId GetSectionId(this JetBrains.ReSharper.Feature.Services.Search.OccurenceType occurenceType) { }
    }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "OccurenceBrowser.Filter.ShowAll"})]
    public class ShowAllAccessAction : JetBrains.ActionManagement.IActionHandler
    {
        public void Execute(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.DelegateExecute nextExecute) { }
        public bool Update(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.ActionPresentation presentation, JetBrains.ActionManagement.DelegateUpdate nextUpdate) { }
    }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "OccurenceBrowser.Filter.ShowAttribute"})]
    public class ShowAttributeAccessAction : JetBrains.ReSharper.Features.Common.Occurences.ShowOccurenceKindBaseAction
    {
        public override JetBrains.ReSharper.Feature.Services.Occurences.OccurenceKindProviders.OccurenceKind OccurenceKind { get; }
    }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "OccurenceBrowser.Filter.ShowBaseMethodCall"})]
    public class ShowBaseMethodCallAction : JetBrains.ReSharper.Features.Common.Occurences.ShowOccurenceKindBaseAction
    {
        public override JetBrains.ReSharper.Feature.Services.Occurences.OccurenceKindProviders.OccurenceKind OccurenceKind { get; }
    }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "OccurenceBrowser.Filter.ShowDocumentation"})]
    public class ShowDocumentationAccessAction : JetBrains.ReSharper.Features.Common.Occurences.ShowOccurenceKindBaseAction
    {
        public override JetBrains.ReSharper.Feature.Services.Occurences.OccurenceKindProviders.OccurenceKind OccurenceKind { get; }
    }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "OccurenceBrowser.Filter.ShowInvocation"})]
    public class ShowInvocationAccessAction : JetBrains.ReSharper.Features.Common.Occurences.ShowOccurenceKindBaseAction
    {
        public override JetBrains.ReSharper.Feature.Services.Occurences.OccurenceKindProviders.OccurenceKind OccurenceKind { get; }
    }
    public abstract class ShowOccurenceKindBaseAction : JetBrains.ActionManagement.IActionHandler
    {
        public abstract JetBrains.ReSharper.Feature.Services.Occurences.OccurenceKindProviders.OccurenceKind OccurenceKind { get; }
        public void Execute(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.DelegateExecute nextExecute) { }
        public bool Update(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.ActionPresentation presentation, JetBrains.ActionManagement.DelegateUpdate nextUpdate) { }
    }
    public abstract class ShowOnlyAccessTypeBaseAction : JetBrains.ActionManagement.IActionHandler
    {
        public abstract JetBrains.ReSharper.Feature.Services.Occurences.OccurenceKindProviders.OccurenceKind OccurenceKind { get; }
        public void Execute(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.DelegateExecute nextExecute) { }
        public bool Update(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.ActionPresentation presentation, JetBrains.ActionManagement.DelegateUpdate nextUpdate) { }
    }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "OccurenceBrowser.Filter.ShowOnlyRead"})]
    public class ShowOnlyReadAccessAction : JetBrains.ReSharper.Features.Common.Occurences.ShowOnlyAccessTypeBaseAction
    {
        public override JetBrains.ReSharper.Feature.Services.Occurences.OccurenceKindProviders.OccurenceKind OccurenceKind { get; }
    }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "OccurenceBrowser.Filter.ShowOnlyWrite"})]
    public class ShowOnlyWriteAccessAction : JetBrains.ReSharper.Features.Common.Occurences.ShowOnlyAccessTypeBaseAction
    {
        public override JetBrains.ReSharper.Feature.Services.Occurences.OccurenceKindProviders.OccurenceKind OccurenceKind { get; }
    }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "OccurenceBrowser.Filter.ShowOther"})]
    public class ShowOtherAccessAction : JetBrains.ReSharper.Features.Common.Occurences.ShowOccurenceKindBaseAction
    {
        public override JetBrains.ReSharper.Feature.Services.Occurences.OccurenceKindProviders.OccurenceKind OccurenceKind { get; }
    }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "OccurenceBrowser.Filter.ShowRead"})]
    public class ShowReadAccessAction : JetBrains.ReSharper.Features.Common.Occurences.ShowOccurenceKindBaseAction
    {
        public override JetBrains.ReSharper.Feature.Services.Occurences.OccurenceKindProviders.OccurenceKind OccurenceKind { get; }
    }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "OccurenceBrowser.Filter.ShowUnitTestUsages"})]
    public class ShowUnitTestAction : JetBrains.ReSharper.Features.Common.Occurences.ShowOccurenceKindBaseAction
    {
        public override JetBrains.ReSharper.Feature.Services.Occurences.OccurenceKindProviders.OccurenceKind OccurenceKind { get; }
    }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "OccurenceBrowser.Filter.ShowVBHandlesClause"})]
    public class ShowVBHandlesClauseAction : JetBrains.ReSharper.Features.Common.Occurences.ShowOccurenceKindBaseAction
    {
        public override JetBrains.ReSharper.Feature.Services.Occurences.OccurenceKindProviders.OccurenceKind OccurenceKind { get; }
    }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "OccurenceBrowser.Filter.ShowInterfaceQualification"})]
    public class ShowVBImplementsClauseAction : JetBrains.ReSharper.Features.Common.Occurences.ShowOccurenceKindBaseAction
    {
        public override JetBrains.ReSharper.Feature.Services.Occurences.OccurenceKindProviders.OccurenceKind OccurenceKind { get; }
    }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "OccurenceBrowser.Filter.ShowWrite"})]
    public class ShowWriteAccessAction : JetBrains.ReSharper.Features.Common.Occurences.ShowOccurenceKindBaseAction
    {
        public override JetBrains.ReSharper.Feature.Services.Occurences.OccurenceKindProviders.OccurenceKind OccurenceKind { get; }
    }
}
namespace JetBrains.ReSharper.Features.Common.Occurences.ExecutionHosting
{
    
    public interface INavigationExecutionHost
    {
        void ExecuteCandidates(JetBrains.Application.DataContext.IDataContext dataContext, bool promoteDeclaredElement, System.Collections.Generic.ICollection<JetBrains.Util.JetTuple<JetBrains.ReSharper.Psi.IDeclaredElement, JetBrains.ReSharper.Psi.Services.CandidatesUtil.DeclaredElementExecutor>> elementExecutionPairs);
        void ExecuteWithDeclaredElements(JetBrains.Application.DataContext.IDataContext dataContext, bool promoteDeclaredElement, System.Collections.Generic.ICollection<JetBrains.Util.JetTuple<JetBrains.ReSharper.Psi.IDeclaredElement, JetBrains.ReSharper.Psi.Services.CandidatesUtil.DeclaredElementExecutor>> candidates, JetBrains.ReSharper.Psi.Services.CandidatesUtil.MultiplyDeclaredElementExecutor multipleExecutor);
        JetBrains.ReSharper.Feature.Services.Navigation.AdvancedSearchingInfo ExecuteWithDialog(JetBrains.Application.DataContext.IDataContext dataContext, JetBrains.ReSharper.Psi.IDeclaredElement declaredElement);
        bool ProcessImmediateResult(JetBrains.Application.DataContext.IDataContext context, System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.Search.IOccurence> results);
        bool ProcessImmediateResultHierarchy(JetBrains.Application.DataContext.IDataContext context, System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.Search.IOccurence> results);
        bool ProcessImmediateResultHighlightUsages(JetBrains.Application.DataContext.IDataContext context, System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.Search.IOccurence> results);
        void ShowContextPopupMenu<TDescriptor>(JetBrains.Application.DataContext.IDataContext context, System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.Search.IOccurence> occurences, System.Func<TDescriptor> descriptorBuilder, System.Nullable<JetBrains.ReSharper.Feature.Services.Occurences.OccurencePresentationOptions> options, bool skipMenuIfSingleEnabled, string title)
            where TDescriptor : JetBrains.ReSharper.Features.Common.Occurences.OccurenceBrowserDescriptor;
        void ShowFindResults<TDescriptor>(JetBrains.Application.DataContext.IDataContext context, System.Func<TDescriptor> descriptor)
            where TDescriptor : JetBrains.ReSharper.Features.Common.Occurences.OccurenceBrowserDescriptor;
        void ShowGlobalPopupMenu(JetBrains.ProjectModel.ISolution solution, System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.Search.IOccurence> occurences, bool activate, JetBrains.UI.PopupWindowManager.PopupWindowContextSource windowContext, System.Func<JetBrains.ReSharper.Features.Common.Occurences.OccurenceBrowserDescriptor> descriptorBuilder, System.Nullable<JetBrains.ReSharper.Feature.Services.Occurences.OccurencePresentationOptions> options, bool skipMenuIfSingleEnabled, string title);
    }
}
namespace JetBrains.ReSharper.Features.Common.Options
{
    
    [JetBrains.UI.Options.OptionsPageAttribute("CodeEditing", "Code Editing", null, HelpKeyword="Reference__Options__Languages", Sequence=2D)]
    public class CodeEditingPage : JetBrains.UI.Options.Helpers.AEmptyOptionsPage
    {
        public const string PID = "CodeEditing";
        public CodeEditingPage() { }
    }
    [JetBrains.UI.Options.OptionsPageAttribute("CodeStyleSharing", "Code Style Sharing", typeof(JetBrains.ReSharper.Features.Common.Src.Options.CommonFeaturesOptionsThemedIcons.CodeStyleSharing), HelpKeyword="Reference__Options__Languages__Common__Code_Style_Sharing", Internal=false, ParentId="CodeEditing", Sequence=1D)]
    public class CodeStyleSharingPage : JetBrains.UI.Options.Helpers.AStackPanelOptionsPage3
    {
        public const string PID = "CodeStyleSharing";
        public CodeStyleSharingPage(JetBrains.DataFlow.Lifetime lifetime, JetBrains.UI.Application.IUIApplication environment, JetBrains.UI.Options.OptionsSettingsSmartContext smartContext, JetBrains.Application.Components.IComponentContainer parentContainer, JetBrains.Application.Parts.IPartsCatalogueSet catalogueSet) { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class FakeSolutionProvider : JetBrains.ProjectModel.SolutionManagerBase
    {
        public FakeSolutionProvider(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.IShellLocks locks, JetBrains.Application.ChangeManager changeManager, JetBrains.ProjectModel.PlatformManager platformManager, JetBrains.Application.Parts.IPartsCatalogueSet catalogueSet, JetBrains.Application.Components.IComponentContainer componentContainer, JetBrains.Application.Env.RunsProducts.ProductConfigurations productConfigurations, JetBrains.ProjectModel.Properties.ProjectPropertiesFactory projectPropertiesFactory, JetBrains.ProjectModel.Properties.ProjectFlavoursFactory projectFlavoursFactory, JetBrains.ProjectModel.Tasks.ISolutionLoadTasksScheduler scheduler, JetBrains.ProjectModel.Properties.ProjectFilePropertiesFactory projectFilePropertiesFactory, JetBrains.ProjectModel.IProjectFileExtensions projectFileExtensions) { }
        public override bool IsRealSolutionOwner { get; }
        public JetBrains.ProjectModel.ISolution GetOrCreateFakeSolution(JetBrains.DataFlow.Lifetime lifetime, object requestor) { }
    }
    [JetBrains.UI.Options.OptionsPageAttribute("Tools", "Tools", null, HelpKeyword="Reference__Options__Tools", Sequence=4D)]
    public class ToolsPage : JetBrains.UI.Options.IOptionsPage
    {
        public const string PID = "Tools";
        public JetBrains.UI.CrossFramework.EitherControl Control { get; }
        public string Id { get; }
        public bool OnOk() { }
        public bool ValidatePage() { }
    }
}
namespace JetBrains.ReSharper.Features.Common.Options.Languages
{
    
    [JetBrains.UI.Options.OptionsPageAttribute("BuildScripts", "Build Scripts", typeof(JetBrains.ReSharper.Features.Common.Src.Options.CommonFeaturesOptionsThemedIcons.BuildScripts), HelpKeyword="Reference__Options__Languages__Build_Scripts", ParentId="CodeEditing", Sequence=30D)]
    public class BuildScriptsPage : JetBrains.UI.Options.IOptionsPage
    {
        public const string PID = "BuildScripts";
        public JetBrains.UI.CrossFramework.EitherControl Control { get; }
        public string Id { get; }
        public bool OnOk() { }
        public bool ValidatePage() { }
    }
    [JetBrains.UI.Options.OptionsPageAttribute("Csharp", "C#", typeof(JetBrains.ReSharper.Features.Common.Src.Options.CommonFeaturesOptionsThemedIcons.CsharpOptionPage), HelpKeyword="Reference__Options__Languages__CSharp", ParentId="CodeEditing", Sequence=7D, SupportedEditions=new string[] {
            "Csharp"})]
    public class CsharpPage : JetBrains.UI.Options.IOptionsPage
    {
        public const string PID = "Csharp";
        public JetBrains.UI.CrossFramework.EitherControl Control { get; }
        public string Id { get; }
        public bool OnOk() { }
        public bool ValidatePage() { }
    }
    [JetBrains.UI.Options.OptionsPageAttribute("Vbnet", "Visual Basic .NET", typeof(JetBrains.ReSharper.Features.Common.Src.Options.CommonFeaturesOptionsThemedIcons.Vbnet), HelpKeyword="Reference__Options__Languages__Visual_Basic__NET", ParentId="CodeEditing", Sequence=8D, SupportedEditions=new string[] {
            "Vbnet"})]
    public class VbnetPage : JetBrains.UI.Options.IOptionsPage
    {
        public const string PID = "Vbnet";
        public JetBrains.UI.CrossFramework.EitherControl Control { get; }
        public string Id { get; }
        public bool OnOk() { }
        public bool ValidatePage() { }
    }
    [JetBrains.UI.Options.OptionsPageAttribute("Xaml", "XAML", typeof(JetBrains.ReSharper.Features.Common.Src.Options.CommonFeaturesOptionsThemedIcons.Xaml), HelpKeyword="Reference__Options__Languages__XAML", ParentId="CodeEditing", Sequence=21D)]
    public class XamlPage : JetBrains.UI.Options.IOptionsPage
    {
        public const string PID = "Xaml";
        public JetBrains.UI.CrossFramework.EitherControl Control { get; }
        public string Id { get; }
        public bool OnOk() { }
        public bool ValidatePage() { }
    }
    [JetBrains.UI.Options.OptionsPageAttribute("XmlDoc", "XML Doc Comments", typeof(JetBrains.IDE.Resources.IdeThemedIcons.XmlDocument), HelpKeyword="Reference__Options__XML_Doc_Comments", ParentId="CodeEditing", Sequence=22D)]
    public class XmlDocPage : JetBrains.UI.Options.IOptionsPage
    {
        public const string PID = "XmlDoc";
        public JetBrains.UI.CrossFramework.EitherControl Control { get; }
        public string Id { get; }
        public bool OnOk() { }
        public bool ValidatePage() { }
    }
    [JetBrains.UI.Options.OptionsPageAttribute("Xml", "XML", typeof(JetBrains.IDE.Resources.IdeThemedIcons.XmlDocument), HelpKeyword="Reference__Options__Languages__XML", ParentId="CodeEditing", Sequence=20D)]
    public class XmlPage : JetBrains.UI.Options.IOptionsPage
    {
        public const string PID = "Xml";
        public JetBrains.UI.CrossFramework.EitherControl Control { get; }
        public string Id { get; }
        public bool OnOk() { }
        public bool ValidatePage() { }
    }
}
namespace JetBrains.ReSharper.Features.Common.Resources
{
    
    public sealed class FeaturesCommonThemedIcons
    {
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Features.Common;component/resources/FeaturesCommonThemedIcons" +
            "/ThemedIcons.FeaturesCommon.Generated.Xaml", 0, "FindResultsToolWindow")]
        public sealed class FindResultsToolWindow : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Features.Common;component/resources/FeaturesCommonThemedIcons" +
            "/ThemedIcons.FeaturesCommon.Generated.Xaml", 1, "MergeOccurencesInFeaturesCommon")]
        public sealed class MergeOccurencesInFeaturesCommon : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Features.Common;component/resources/FeaturesCommonThemedIcons" +
            "/ThemedIcons.FeaturesCommon.Generated.Xaml", 3, "UsageHandles")]
        public sealed class UsageHandles : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Features.Common;component/resources/FeaturesCommonThemedIcons" +
            "/ThemedIcons.FeaturesCommon.Generated.Xaml", 2, "UserTemplates")]
        public sealed class UserTemplates : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
    }
}
namespace JetBrains.ReSharper.Features.Common.SectionsManagement
{
    
    public interface IOccurenceSectionProvider
    {
        System.Collections.Generic.ICollection<JetBrains.ReSharper.Features.Common.Occurences.GroupingSectionId> GetGroupSectionId(JetBrains.ReSharper.Feature.Services.Search.IOccurence occurence, JetBrains.ReSharper.Features.Common.Occurences.OccurenceBrowserDescriptor descriptor);
        System.Collections.Generic.ICollection<JetBrains.TreeModels.TreeSection> GetTreeSections(JetBrains.ReSharper.Features.Common.Occurences.OccurenceBrowserDescriptor descriptor);
        bool IsApplicable(JetBrains.ReSharper.Features.Common.Occurences.OccurenceBrowserDescriptor descriptor);
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class OccurenceSectionsManager
    {
        public OccurenceSectionsManager(JetBrains.ReSharper.Feature.Services.IFeaturePartsContainer featureParts) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Features.Common.Occurences.GroupingSectionId> GetGroupingSectionIds(JetBrains.ReSharper.Feature.Services.Search.IOccurence occurence, JetBrains.ReSharper.Features.Common.Occurences.OccurenceBrowserDescriptor descriptor) { }
        public static JetBrains.ReSharper.Features.Common.SectionsManagement.OccurenceSectionsManager GetInstance(JetBrains.ProjectModel.ISolution solution) { }
        public System.Collections.Generic.List<JetBrains.TreeModels.TreeSection> GetTreeSectionsFromOccurenceSections(JetBrains.ReSharper.Features.Common.Occurences.OccurenceBrowserDescriptor descriptor) { }
    }
}
namespace JetBrains.ReSharper.Features.Common.Src.Options
{
    
    public sealed class CommonFeaturesOptionsThemedIcons
    {
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Features.Common;component/src/Options/CommonFeaturesOptionsIc" +
            "ons/ThemedIcons.CommonFeaturesOptions.Generated.Xaml", 2, "BuildScripts")]
        public sealed class BuildScripts : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Features.Common;component/src/Options/CommonFeaturesOptionsIc" +
            "ons/ThemedIcons.CommonFeaturesOptions.Generated.Xaml", 6, "CodeStyleSharing")]
        public sealed class CodeStyleSharing : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Features.Common;component/src/Options/CommonFeaturesOptionsIc" +
            "ons/ThemedIcons.CommonFeaturesOptions.Generated.Xaml", 7, "CsharpOptionPage")]
        public sealed class CsharpOptionPage : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Features.Common;component/src/Options/CommonFeaturesOptionsIc" +
            "ons/ThemedIcons.CommonFeaturesOptions.Generated.Xaml", 5, "Inc")]
        public sealed class Inc : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Features.Common;component/src/Options/CommonFeaturesOptionsIc" +
            "ons/ThemedIcons.CommonFeaturesOptions.Generated.Xaml", 1, "LanguagesCommon")]
        public sealed class LanguagesCommon : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Features.Common;component/src/Options/CommonFeaturesOptionsIc" +
            "ons/ThemedIcons.CommonFeaturesOptions.Generated.Xaml", 3, "Master")]
        public sealed class Master : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Features.Common;component/src/Options/CommonFeaturesOptionsIc" +
            "ons/ThemedIcons.CommonFeaturesOptions.Generated.Xaml", 4, "Vbnet")]
        public sealed class Vbnet : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Features.Common;component/src/Options/CommonFeaturesOptionsIc" +
            "ons/ThemedIcons.CommonFeaturesOptions.Generated.Xaml", 0, "Xaml")]
        public sealed class Xaml : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
    }
}
namespace JetBrains.ReSharper.Features.Common.TreePsiBrowser
{
    
    public sealed class MyCachingPresenter : JetBrains.UI.TreeView.StructuredPresenter<JetBrains.TreeModels.TreeModelNode, JetBrains.CommonControls.IPresentableItem>
    {
        public MyCachingPresenter(JetBrains.UI.TreeView.StructuredPresenter<JetBrains.TreeModels.TreeModelNode, JetBrains.CommonControls.IPresentableItem> presenter) { }
        public JetBrains.UI.TreeView.StructuredPresenter<JetBrains.TreeModels.TreeModelNode, JetBrains.CommonControls.IPresentableItem> Presenter { get; }
        public void Invalidate(JetBrains.TreeModels.TreeModelNode toModel) { }
        public void Set(System.Collections.Generic.Dictionary<JetBrains.TreeModels.TreeModelNode, JetBrains.CommonControls.IPresentableItem> presentations) { }
        public override void UpdateItem(object value, JetBrains.TreeModels.TreeModelNode structureElement, JetBrains.CommonControls.IPresentableItem item, JetBrains.UI.TreeView.PresentationState state) { }
    }
    public class MyTreeModelBrowserPanelPsiWPF : JetBrains.IDE.TreeBrowser.WPF.MyTreeModelBrowserPanelWPF, JetBrains.ReSharper.Psi.IAsyncCommitClient
    {
        public MyTreeModelBrowserPanelPsiWPF(JetBrains.DataFlow.Lifetime lifetime, JetBrains.IDE.TreeBrowser.TreeModelBrowserDescriptor descriptor, JetBrains.UI.Application.IUIApplication environment) { }
        protected override System.Windows.UIElement CreateActionBar(JetBrains.ActionManagement.IActionBarManager actionBarManager, string actionId) { }
        protected override void CustomizeTreeView(JetBrains.IDE.TreeBrowser.WPF.TreeModelPresentableViewWPF treeModelView) { }
        protected override JetBrains.UI.TreeView.StructuredPresenter<JetBrains.TreeModels.TreeModelNode, JetBrains.CommonControls.IPresentableItem> GetPresenter() { }
        protected override void InitializeCustomControl() { }
        protected override bool Navigate(JetBrains.TreeModels.TreeModelNode node, bool transferFocus) { }
        protected override void OnLoading() { }
        protected override void RequestImmediateUpdate() { }
        protected override void RequestPendingUpdate() { }
        public override void SynchronizePreview() { }
    }
    public class TreeGridBrowserPanelPsi : JetBrains.IDE.TreeGridBrowser.TreeGridBrowserPanel, JetBrains.ReSharper.Psi.IAsyncCommitClient
    {
        public TreeGridBrowserPanelPsi([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.IDE.TreeBrowser.TreeModelBrowserDescriptorBase descriptor, [JetBrains.Annotations.NotNullAttribute()] JetBrains.UI.Application.IUIApplication environment, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ActionManagement.IActionBarManager actionBarManager, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.ChangeManager changeManager) { }
        protected override JetBrains.IDE.TreeGridBrowser.IPendedActionScheduler GetPendedActionScheduler() { }
        protected override JetBrains.UI.TreeView.StructuredPresenter<JetBrains.TreeModels.TreeModelNode, JetBrains.CommonControls.IPresentableItem> GetStructuredPresenter() { }
        protected override void OnModelReadActivityStarted() { }
        protected override void OnMoveToOccurence(JetBrains.TreeModels.TreeModelNode occurence) { }
    }
    public abstract class TreeModelBrowserDescriptorPsi : JetBrains.IDE.TreeBrowser.TreeModelBrowserDescriptor
    {
        protected TreeModelBrowserDescriptorPsi(JetBrains.ProjectModel.ISolution solution) { }
        public override bool Navigate([JetBrains.Annotations.NotNullAttribute()] JetBrains.TreeModels.TreeModelNode node, [JetBrains.Annotations.NotNullAttribute()] JetBrains.UI.PopupWindowManager.PopupWindowContextSource windowContext, bool transferFocus, JetBrains.IDE.TabOptions options = 2) { }
    }
    public class TreeModelBrowserPanelPsi : JetBrains.IDE.TreeBrowser.TreeModelBrowserPanel, JetBrains.ReSharper.Psi.IAsyncCommitClient
    {
        public TreeModelBrowserPanelPsi(JetBrains.IDE.TreeBrowser.TreeModelBrowserDescriptor descriptor, JetBrains.UI.Application.IUIApplication environment) { }
        public JetBrains.ProjectModel.ISolution Solution { get; }
        protected override void BeforeMovePrevNext() { }
        protected override JetBrains.ActionManagement.IActionBar CreateActionBar(JetBrains.ActionManagement.IActionBarManager actionBarManager, string actionId) { }
        protected override void CustomizeTreeView(JetBrains.UI.TreeView.TreeModelPresentableView treeModelView) { }
        protected override JetBrains.UI.TreeView.StructuredPresenter<JetBrains.TreeModels.TreeModelNode, JetBrains.CommonControls.IPresentableItem> GetPresenter() { }
        protected override void InitializeCustomControl() { }
        protected override bool Navigate(JetBrains.TreeModels.TreeModelNode node, bool transferFocus, JetBrains.IDE.TabOptions options = 2) { }
        protected override void OnLoading(System.EventArgs e) { }
        protected override void RequestImmediateUpdate() { }
        protected override void RequestPendingUpdate() { }
        public override void SynchronizePreview() { }
    }
    public class TreeModelBrowserPanelPsiWPF : JetBrains.IDE.TreeBrowser.WPF.TreeModelBrowserPanelWPF, JetBrains.ReSharper.Psi.IAsyncCommitClient
    {
        public TreeModelBrowserPanelPsiWPF(JetBrains.IDE.TreeBrowser.TreeModelBrowserDescriptor descriptor, JetBrains.DataFlow.Lifetime parentLifetime, JetBrains.ActionManagement.IActionBarManager actionBar, JetBrains.UI.Application.IUIApplication environment) { }
        public JetBrains.ProjectModel.ISolution Solution { get; }
        protected override JetBrains.ActionManagement.IActionBar CreateActionBar(JetBrains.ActionManagement.IActionBarManager actionBarManager, string actionId) { }
        protected override void CustomizeTreeView(JetBrains.IDE.TreeBrowser.WPF.TreeModelPresentableViewWPF treeModelView) { }
        protected override void Dispose(bool disposing) { }
        protected override JetBrains.UI.TreeView.StructuredPresenter<JetBrains.TreeModels.TreeModelNode, JetBrains.CommonControls.IPresentableItem> GetPresenter() { }
        protected override void InitializeCustomControl() { }
        protected override bool Navigate(JetBrains.TreeModels.TreeModelNode node, bool transferFocus) { }
        protected override void OnLoading(System.EventArgs e) { }
        protected override void RequestImmediateUpdate() { }
        protected override void RequestPendingUpdate() { }
        public static JetBrains.UI.CrossFramework.EitherControl SelectTreeImplementation(JetBrains.UI.Application.IUIApplication environment, JetBrains.IDE.TreeBrowser.TreeModelBrowserDescriptor descriptor, JetBrains.DataFlow.Lifetime lifetime, JetBrains.ActionManagement.IActionBarManager actionBar, JetBrains.Application.Settings.ISettingsStore settingsStore, JetBrains.Application.ChangeManager changeManager) { }
        public override void SynchronizePreview() { }
    }
    public class TreeModelPresentableViewPsi : JetBrains.IDE.TreeBrowser.WPF.TreeModelPresentableViewWPF
    {
        public TreeModelPresentableViewPsi(JetBrains.UI.TreeView.ITreeViewController controller, JetBrains.ProjectModel.ISolution solution, JetBrains.DocumentManagers.DocumentManager documentManager, JetBrains.Application.ChangeManager changeManager, JetBrains.UI.Application.IUIApplication environment) { }
        public TreeModelPresentableViewPsi(JetBrains.UI.TreeView.ITreeViewController controller, JetBrains.ProjectModel.ISolution solution, JetBrains.UI.Application.IUIApplication environment) { }
        public override JetBrains.UI.TreeView.StructuredPresenter<JetBrains.TreeModels.TreeModelNode, JetBrains.CommonControls.IPresentableItem> Presenter { get; set; }
        protected override void OnModelUpdating(object sender, System.EventArgs e) { }
    }
}
namespace JetBrains.ReSharper.Features.Common.UI
{
    
    public class CheckedTreeViewController<TNodeType>
        where TNodeType :  class, JetBrains.ReSharper.Features.Common.UI.ICheckableTreeNode<>
    {
        public CheckedTreeViewController(System.Collections.Generic.ICollection<TNodeType> allItems, [JetBrains.Annotations.CanBeNullAttribute()] System.Comparison<TNodeType> nodesComparer) { }
        public System.Collections.Generic.ICollection<TNodeType> AllItems { get; }
        [JetBrains.Annotations.UsedImplicitlyAttribute()]
        public System.Collections.Generic.ICollection<TNodeType> Roots { get; }
        public virtual void BindToTreeView(JetBrains.UI.TreeGrid.TreeGridView treeListView) { }
    }
    public class ChooseProjectFolderController : JetBrains.UI.GotoByName.GotoByNameController
    {
        public static JetBrains.ReSharper.Features.Common.UI.CompletionPickerSettings ConfigureFolderChooser(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.IShellLocks locks, JetBrains.ProjectModel.ISolution solution) { }
        protected override bool ExecuteItem(JetBrains.UI.PopupMenu.Impl.JetPopupMenuItem item, JetBrains.DataFlow.ISignal<bool> closeBeforeExecute) { }
        public static bool FilterFolder(JetBrains.ProjectModel.IProjectFolder projectFolder) { }
        public static JetBrains.ProjectModel.IProjectFolder ParseFolderName(JetBrains.ProjectModel.ISolution solution, string name) { }
        public static string PresentInternal(JetBrains.ProjectModel.IProjectFolder folder) { }
        protected override bool UpdateItems(string filterString, System.Func<System.Collections.Generic.IEnumerable<JetBrains.UI.PopupMenu.Impl.JetPopupMenuItem>, JetBrains.UI.GotoByName.GotoByNameController.AddItemsBehavior, bool> addItemsConsumer) { }
    }
    public class ChooseProjectItemController : JetBrains.UI.GotoByName.GotoByNameController
    {
        public static JetBrains.ReSharper.Features.Common.UI.CompletionPickerSettings ConfigureProjectItemChooser(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.IShellLocks locks, JetBrains.ProjectModel.ISolution solution) { }
        protected override bool ExecuteItem(JetBrains.UI.PopupMenu.Impl.JetPopupMenuItem item, JetBrains.DataFlow.ISignal<bool> closeBeforeExecute) { }
        public static bool FilterFolder(JetBrains.ProjectModel.IProjectFolder projectFolder) { }
        public static JetBrains.ProjectModel.IProjectItem ParseProjectItemName(JetBrains.ProjectModel.ISolution solution, string name) { }
        public static string PresentInternal(JetBrains.ProjectModel.IProjectItem projectItem) { }
        protected override bool UpdateItems(string filterString, System.Func<System.Collections.Generic.IEnumerable<JetBrains.UI.PopupMenu.Impl.JetPopupMenuItem>, JetBrains.UI.GotoByName.GotoByNameController.AddItemsBehavior, bool> addItemsConsumer) { }
    }
    public class CompletionPickerEdit : System.Windows.Forms.TextBox
    {
        public readonly JetBrains.DataFlow.Property<int> CaretPosition;
        protected readonly JetBrains.DataFlow.ISimpleSignal CommitCompletionListInputString;
        protected readonly JetBrains.DataFlow.ISignal<JetBrains.DataFlow.OutEventArgs<bool>> CompletionListExecuteSelectedItem;
        protected readonly JetBrains.DataFlow.ISignal<JetBrains.DataFlow.EventArgs<JetBrains.UI.PopupMenu.Impl.JetPopupMenuDoc.NextItemDir>> CompletionListSelectNextItem;
        public readonly JetBrains.DataFlow.IProperty<JetBrains.ReSharper.Features.Common.UI.CompletionPickerEdit.CompletionListShowModes> CompletionListShowMode;
        protected readonly JetBrains.DataFlow.Property<bool> IsCompletionListVisible;
        [JetBrains.Annotations.NotNullAttribute()]
        protected readonly System.Windows.Forms.Button myBtnTree;
        [JetBrains.Annotations.NotNullAttribute()]
        protected readonly JetBrains.DataFlow.Lifetime myLifetime;
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly JetBrains.DataFlow.Property<JetBrains.ReSharper.Features.Common.UI.CompletionPickerSettings> Settings;
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly JetBrains.DataFlow.Property<string> Text;
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly JetBrains.DataFlow.Property<string> TextBeforeCaret;
        public CompletionPickerEdit(JetBrains.ReSharper.Features.Common.UI.CompletionPickerEditComponents completionPickerEditComponents, JetBrains.ProjectModel.ISolution solution) { }
        protected void ExecuteCompletionListItem(JetBrains.UI.PopupMenu.Impl.JetPopupMenuItem item) { }
        protected override void OnLayout(System.Windows.Forms.LayoutEventArgs levent) { }
        protected override void OnLostFocus(System.EventArgs e) { }
        protected override void OnVisibleChanged(System.EventArgs e) { }
        protected override bool ProcessCmdKey(ref System.Windows.Forms.Message msg, System.Windows.Forms.Keys keyData) { }
        protected override bool ProcessDialogKey(System.Windows.Forms.Keys keyData) { }
        public void ShowCompletionPickerTreeDropDown(JetBrains.ProjectModel.ISolution solution, JetBrains.UI.Tooltips.ITooltipManager tooltipman, JetBrains.UI.PopupWindowManager.MainWindowPopupWindowContext mainWindowPopupWindowContext, JetBrains.Application.Interop.NativeHook.IWindowsHookManager windowsHookManager, JetBrains.UI.PopupWindowManager.PopupWindowManager popupWindowManager) { }
        protected override void WndProc(ref System.Windows.Forms.Message m) { }
        public enum CompletionListShowModes
        {
            Show = 0,
            HideSoft = 1,
            HideHard = 2,
        }
        public enum CompletionListShowModeTransition
        {
            Soft = 0,
            Hard = 1,
        }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class CompletionPickerEditComponents
    {
        public CompletionPickerEditComponents(JetBrains.UI.Application.IUIApplication environment, JetBrains.UI.Tooltips.ITooltipManager tooltipman, JetBrains.Application.Interop.NativeHook.IWindowsHookManager windowsHookManager, JetBrains.UI.PopupWindowManager.MainWindowPopupWindowContext mainWindowPopupWindowContext, JetBrains.UI.PopupWindowManager.PopupWindowManager popupWindowManager) { }
        public JetBrains.UI.Application.IUIApplication Environment { get; }
        public JetBrains.Application.Interop.NativeHook.IWindowsHookManager IWindowsHookManager { get; }
        public JetBrains.UI.Application.IMainWindow MainWindow { get; }
        public JetBrains.UI.PopupWindowManager.MainWindowPopupWindowContext MainWindowPopupWindowContext { get; }
        public JetBrains.UI.PopupWindowManager.PopupWindowManager PopupWindowManager { get; }
        public JetBrains.UI.Tooltips.ITooltipManager Tooltipman { get; }
    }
    [System.ObsoleteAttribute("Cannot be injected, replace with validator provider.")]
    public class CompletionPickerEditValidatorAttribute : JetBrains.CommonControls.Validation.ValidationAttribute
    {
        public CompletionPickerEditValidatorAttribute(string message, JetBrains.CommonControls.Validation.ValidatorSeverity severity) { }
        public CompletionPickerEditValidatorAttribute(string message, JetBrains.CommonControls.Validation.ValidatorSeverity severity, bool canBeEmpty) { }
        public override JetBrains.CommonControls.Validation.IValidator BuildValidator(System.Windows.Forms.Control control, object host) { }
    }
    public class CompletionPickerPopupDialog : System.Windows.Forms.Form
    {
        protected readonly int DimDesiredWidth;
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly JetBrains.DataFlow.Property<JetBrains.ReSharper.Features.Common.UI.CompletionPickerSettings> Settings;
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly JetBrains.DataFlow.Property<string> TypeChooserText;
        public CompletionPickerPopupDialog(JetBrains.UI.Application.IUIApplication environment, JetBrains.UI.Tooltips.ITooltipManager tooltipman, JetBrains.UI.Application.IMainWindow mainWindow, JetBrains.Application.Interop.NativeHook.IWindowsHookManager windowsHookManager, JetBrains.UI.PopupWindowManager.MainWindowPopupWindowContext mainWindowPopupWindowContext, JetBrains.UI.PopupWindowManager.PopupWindowManager popupWindowManager, JetBrains.ProjectModel.ISolution solution = null) { }
        public JetBrains.UI.RichText.RichTextBlock LabelText { get; set; }
        protected override void OnVisibleChanged(System.EventArgs e) { }
    }
    public class CompletionPickerSettings : System.IDisposable
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly JetBrains.DataFlow.Property<JetBrains.UI.GotoByName.GotoByNameModel> CompletionModel;
        public readonly JetBrains.DataFlow.ObsoleteLifetimeAndDefinitionAtTheSameTime Disposables;
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly JetBrains.DataFlow.Signal<JetBrains.DataFlow.InOutEventArgs<object, System.Collections.Generic.List<object>>> ExpandPickerItem;
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly JetBrains.DataFlow.IProperty<bool> IsSelectingAllTextOnCompletion;
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly JetBrains.DataFlow.Property<JetBrains.UI.TreeView.StructuredPresenter<JetBrains.TreeModels.TreeModelNode, JetBrains.CommonControls.IPresentableItem>> PickerItemPresenter;
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly JetBrains.DataFlow.Signal<JetBrains.DataFlow.InOutEventArgs<JetBrains.UI.PopupMenu.Impl.JetPopupMenuItem, string>> TranslateCompletionItem;
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly JetBrains.DataFlow.Signal<JetBrains.DataFlow.InOutEventArgs<object, string>> TranslatePickerItem;
        public CompletionPickerSettings() { }
        public void Dispose() { }
    }
    public class CompletionPickerTreeDropDown : System.Windows.Forms.Form, JetBrains.CommonControls.IConstrainableControl
    {
        protected readonly JetBrains.ReSharper.Features.Common.TreePsiBrowser.TreeModelPresentableViewPsi myTreeView;
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly JetBrains.DataFlow.Property<string> SelectedItemText;
        public CompletionPickerTreeDropDown([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Features.Common.UI.CompletionPickerSettings settings, JetBrains.ProjectModel.ISolution solution, JetBrains.UI.Tooltips.ITooltipManager tooltipManager, JetBrains.UI.PopupWindowManager.MainWindowPopupWindowContext mainWindowPopupWindowContext, JetBrains.Application.Interop.NativeHook.IWindowsHookManager windowsHookManager) { }
        public bool AutoActivate { get; set; }
        protected override System.Windows.Forms.CreateParams CreateParams { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ReSharper.Features.Common.UI.CompletionPickerSettings Settings { get; }
        protected override bool ShowWithoutActivation { get; }
        public JetBrains.DataFlow.ISimpleSignal WantsResize { get; }
        protected void ExecuteFocusedNode() { }
        public System.Drawing.Size GetDesiredSize(JetBrains.UI.IGraphicsContainer gc, System.Drawing.Size limit) { }
        public static bool IsAvailable([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Features.Common.UI.CompletionPickerSettings settings) { }
        protected override void OnKeyDown(System.Windows.Forms.KeyEventArgs args) { }
        protected override void OnLeave(System.EventArgs e) { }
        protected override void OnLostFocus(System.EventArgs e) { }
        protected override void OnPaint(System.Windows.Forms.PaintEventArgs args) { }
        public void SetLayout(JetBrains.UI.LayoutResult layout) { }
        public class static Dim
        {
            public static readonly System.Drawing.Size BorderWidth;
            public static readonly System.Drawing.Size DefaultSize;
            public static readonly System.Windows.Forms.Padding TreeControlDockPadding;
        }
    }
    public abstract class DeclaredElementChooser
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly JetBrains.DataFlow.Property<System.Func<JetBrains.ReSharper.Psi.IDeclaredElement, bool>> CompletionItemsPassFilter;
        [JetBrains.Annotations.NotNullAttribute()]
        protected JetBrains.ReSharper.Feature.Services.Goto.ICompletionGotoController myCompletionController;
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly JetBrains.DataFlow.Property<System.Func<JetBrains.ReSharper.Psi.IDeclaredElement, bool>> PickerItemsPassFilter;
        protected DeclaredElementChooser([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.ISolution solution, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ProjectModel.IProject project, JetBrains.ReSharper.Feature.Services.Search.LibrariesFlag libraries, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.PsiLanguageType language, [JetBrains.Annotations.NotNullAttribute()] System.Func<JetBrains.ReSharper.Feature.Services.Goto.ICompletionGotoController> FCreateCompletionController) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ReSharper.Psi.PsiLanguageType Language { get; }
        public JetBrains.ReSharper.Feature.Services.Search.LibrariesFlag Libraries { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ReSharper.Features.Common.UI.CompletionPickerSettings Settings { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ProjectModel.ISolution Solution { get; }
        protected virtual bool Filter(JetBrains.ReSharper.Psi.IDeclaredElement element) { }
        [JetBrains.Annotations.NotNullAttribute()]
        protected JetBrains.ReSharper.Psi.Caches.ISymbolScope GetDeclarationsCache() { }
        protected static string GetFqName([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IDeclaredElement de, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.PsiLanguageType language) { }
        [JetBrains.Annotations.NotNullAttribute()]
        protected System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IClrDeclaredElement> GetItems([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.IDeclaredElement element) { }
        protected void InitCompletion(System.Func<JetBrains.ReSharper.Feature.Services.Goto.ICompletionGotoController> FCreateCompletionController) { }
        protected void InitPicker() { }
    }
    public class FileChooser
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly JetBrains.DataFlow.Property<System.Func<JetBrains.ProjectModel.IProjectItem, bool>> CompletionItemsPassFilter;
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly JetBrains.DataFlow.Property<System.Func<JetBrains.ProjectModel.IProjectItem, bool>> PickerItemsPassFilter;
        public FileChooser([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.ISolution solution, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.IShellLocks locks) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ReSharper.Features.Common.UI.CompletionPickerSettings Settings { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ProjectModel.ISolution Solution { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        protected JetBrains.ReSharper.Features.Common.GoToByName.Controllers.GotoFileController CreateCompletionController(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.IShellLocks locks) { }
        protected void InitCompletion(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.IShellLocks locks) { }
        protected void RestrictItemsPassFilter([JetBrains.Annotations.NotNullAttribute()] System.Func<JetBrains.ProjectModel.IProjectItem, bool> funcAdd) { }
    }
    public interface ICheckableTreeNode<T>
        where T :  class, JetBrains.ReSharper.Features.Common.UI.ICheckableTreeNode<>
    {
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.List<T> Children { get; }
        [JetBrains.Annotations.UsedImplicitlyAttribute()]
        JetBrains.DataFlow.IProperty<System.Nullable<bool>> IsCheckedTriState { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        T Parent { get; }
    }
    public class NamespaceChooser : JetBrains.ReSharper.Features.Common.UI.DeclaredElementChooser
    {
        public NamespaceChooser([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.ISolution solution, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ProjectModel.IProject project, JetBrains.ReSharper.Feature.Services.Search.LibrariesFlag libraries, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.PsiLanguageType language, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.IShellLocks locks) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.ReSharper.Features.Common.UI.CompletionPickerSettings CreateSettings([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.ISolution solution, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ProjectModel.IProject project, JetBrains.ReSharper.Feature.Services.Search.LibrariesFlag libraries, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.PsiLanguageType language, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.IShellLocks locks) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Psi.INamespace TryGetNamespace([JetBrains.Annotations.NotNullAttribute()] string sFqName) { }
    }
    public class ProjectInHierarchyItem : JetBrains.ReSharper.Features.Common.UI.ICheckableTreeNode<JetBrains.ReSharper.Features.Common.UI.ProjectInHierarchyItem>
    {
        public ProjectInHierarchyItem(JetBrains.ProjectModel.IProjectModelElement element, JetBrains.ReSharper.Features.Common.UI.ProjectInHierarchyItem parent, JetBrains.ReSharper.Features.Common.UI.ProjectInHierarchyItemKinds itemKind, int index, string name, string description, bool isIncluded) { }
        public System.Collections.Generic.List<JetBrains.ReSharper.Features.Common.UI.ProjectInHierarchyItem> Children { get; }
        [JetBrains.Annotations.UsedImplicitlyAttribute()]
        public string Description { get; }
        public JetBrains.ProjectModel.IProjectModelElement Element { get; }
        public int Index { get; }
        [JetBrains.Annotations.UsedImplicitlyAttribute()]
        public JetBrains.DataFlow.IProperty<System.Nullable<bool>> IsCheckedTriState { get; set; }
        public JetBrains.ReSharper.Features.Common.UI.ProjectInHierarchyItemKinds ItemKind { get; }
        [JetBrains.Annotations.UsedImplicitlyAttribute()]
        public string Name { get; }
        public JetBrains.ReSharper.Features.Common.UI.ProjectInHierarchyItem Parent { get; }
    }
    public enum ProjectInHierarchyItemKinds
    {
        Group = 0,
        Project = 1,
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class ProjectStructureBuilder
    {
        public ProjectStructureBuilder(JetBrains.ProjectModel.ISolution solution) { }
        public bool FilterTerminating { get; set; }
        public JetBrains.Util.OneToSetMap<JetBrains.ProjectModel.IProjectModelElement, JetBrains.ProjectModel.IProject> GroupToProjectsMap { get; }
        public void AnalyzeIfNeeded() { }
        public System.Collections.Generic.List<JetBrains.ReSharper.Features.Common.UI.ProjectInHierarchyItem> BuildNodes(System.Func<JetBrains.ProjectModel.IProject, bool> isIncludedFunc) { }
        public JetBrains.ProjectModel.IProjectFolder GetContainingGroup(JetBrains.ProjectModel.IProject project) { }
        public static JetBrains.ReSharper.Features.Common.UI.ProjectStructureBuilder GetInstance(JetBrains.ProjectModel.ISolution solution) { }
    }
    public class TypeChooser : JetBrains.ReSharper.Features.Common.UI.DeclaredElementChooser
    {
        public TypeChooser([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Feature.Services.Search.LibrariesFlag libraries, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.PsiLanguageType language, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.IShellLocks locks) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.ReSharper.Features.Common.UI.CompletionPickerSettings CreateSettings([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Feature.Services.Search.LibrariesFlag libraries, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.PsiLanguageType language, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.IShellLocks locks) { }
        protected override bool Filter(JetBrains.ReSharper.Psi.IDeclaredElement element) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Psi.ITypeElement TryGetTypeElement([JetBrains.Annotations.NotNullAttribute()] string sFqName) { }
    }
}
namespace JetBrains.ReSharper.Features.Common.Util
{
    
    public class static TypeHierarchyUtil
    {
        public static void AggregateBaseElements(JetBrains.ReSharper.Psi.ITypeElement typeElement, System.Collections.Generic.List<JetBrains.ReSharper.Psi.ITypeElement> baseElements, JetBrains.ReSharper.Psi.ITypeElement objectType, bool filterExternalElements) { }
    }
}
namespace JetBrains.ReSharper.Features.Common.XmlDocId
{
    
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "CopyXmlDocIdToClipboard"})]
    public class CopyXmlDocIdToClipboardAction : JetBrains.ActionManagement.IActionHandler
    {
        public void Execute(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.DelegateExecute nextExecute) { }
        public bool Update(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.ActionPresentation presentation, JetBrains.ActionManagement.DelegateUpdate nextUpdate) { }
    }
}