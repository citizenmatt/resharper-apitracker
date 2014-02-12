[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]

namespace JetBrains.ReSharper.UnitTestExplorer.Actions
{
    
    public abstract class UnitTestContextActionBase : JetBrains.ActionManagement.IActionHandler
    {
        public void Execute(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.DelegateExecute nextExecute) { }
        protected abstract void Execute([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.UnitTestFramework.UnitTestElements elements, JetBrains.ReSharper.UnitTestFramework.IUnitTestSessionView session, JetBrains.ProjectModel.ISolution solution, JetBrains.Application.DataContext.IDataContext context);
        public bool Update(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.ActionPresentation presentation, JetBrains.ActionManagement.DelegateUpdate nextUpdate) { }
        protected abstract bool Update(JetBrains.ActionManagement.ActionPresentation presentation, bool hasAnyTests, JetBrains.ReSharper.UnitTestFramework.IUnitTestSessionView session);
    }
    public abstract class UnitTestExplorerContextBaseAction : JetBrains.ReSharper.UnitTestExplorer.Actions.UnitTestContextActionBase
    {
        protected abstract bool IsRunOrDebugAction { get; }
        protected override void Execute(JetBrains.ReSharper.UnitTestFramework.UnitTestElements elements, JetBrains.ReSharper.UnitTestFramework.IUnitTestSessionView session, JetBrains.ProjectModel.ISolution solution, JetBrains.Application.DataContext.IDataContext context) { }
        protected abstract JetBrains.ReSharper.UnitTestFramework.IHostProvider GetHostProvider();
        protected override bool Update(JetBrains.ActionManagement.ActionPresentation presentation, bool hasAnyTests, JetBrains.ReSharper.UnitTestFramework.IUnitTestSessionView session) { }
    }
    public abstract class UnitTestExplorerRunSolution1ActionBase : JetBrains.ReSharper.UnitTestExplorer.Actions.UnitTestRunSolutionActionsBase
    {
        protected override JetBrains.ReSharper.UnitTestFramework.IHostProvider GetHostProvider() { }
    }
    public abstract class UnitTestExplorerRunSolution2ActionBase : JetBrains.ReSharper.UnitTestExplorer.Actions.UnitTestRunSolutionActionsBase
    {
        protected override JetBrains.ReSharper.UnitTestFramework.IHostProvider GetHostProvider() { }
    }
    public abstract class UnitTestExplorerRunSolution3ActionBase : JetBrains.ReSharper.UnitTestExplorer.Actions.UnitTestRunSolutionActionsBase
    {
        protected override JetBrains.ReSharper.UnitTestFramework.IHostProvider GetHostProvider() { }
    }
    public abstract class UnitTestExplorerRunSolution4ActionBase : JetBrains.ReSharper.UnitTestExplorer.Actions.UnitTestRunSolutionActionsBase
    {
        protected override JetBrains.ReSharper.UnitTestFramework.IHostProvider GetHostProvider() { }
    }
    public abstract class UnitTestExplorerRunSolution5ActionBase : JetBrains.ReSharper.UnitTestExplorer.Actions.UnitTestRunSolutionActionsBase
    {
        protected override JetBrains.ReSharper.UnitTestFramework.IHostProvider GetHostProvider() { }
    }
    public class UnitTestExplorerRunSolutionActionBase : JetBrains.ReSharper.UnitTestExplorer.Actions.UnitTestRunSolutionActionsBase
    {
        protected override JetBrains.ReSharper.UnitTestFramework.IHostProvider GetHostProvider() { }
        public override bool Update(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.ActionPresentation presentation, JetBrains.ActionManagement.DelegateUpdate nextUpdate) { }
    }
    public abstract class UnitTestRunSolutionActionsBase : JetBrains.ActionManagement.IActionHandler
    {
        public void Execute(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.DelegateExecute nextExecute) { }
        protected abstract JetBrains.ReSharper.UnitTestFramework.IHostProvider GetHostProvider();
        public virtual bool Update(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.ActionPresentation presentation, JetBrains.ActionManagement.DelegateUpdate nextUpdate) { }
    }
    public abstract class UnitTestSessionRemoveSelectedNodesBase : JetBrains.ActionManagement.IActionHandler
    {
        public void Execute(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.DelegateExecute nextExecute) { }
        public bool Update(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.ActionPresentation presentation, JetBrains.ActionManagement.DelegateUpdate nextUpdate) { }
    }
}
namespace JetBrains.ReSharper.UnitTestExplorer.Common
{
    
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public sealed class UnitTestDataRules
    {
        public UnitTestDataRules(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ReSharper.UnitTestFramework.UnitTestManager unitTestManager, JetBrains.ActionManagement.IActionManager actionManager) { }
        public static JetBrains.ReSharper.UnitTestFramework.UnitTestElements TreeModelNodesToUnitTestElements(JetBrains.Application.DataContext.IDataContext context) { }
    }
}
namespace JetBrains.ReSharper.UnitTestExplorer.ElementRules
{
    
    public class AllElementsInSolutionRule : JetBrains.ReSharper.UnitTestFramework.IUnitTestElementsTransformationRule
    {
        public AllElementsInSolutionRule(JetBrains.Application.IShellLocks shellLocks, JetBrains.ReSharper.UnitTestFramework.Elements.IUnitTestElementManager elementManager) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.UnitTestFramework.IUnitTestElementsTransformationRule> AsIEnumerable { get; }
        public void Apply(JetBrains.ReSharper.UnitTestFramework.UnitTestElements elements) { }
    }
    [JetBrains.ReSharper.UnitTestFramework.UnitTestElementsTransformationRuleAttribute()]
    public class CleanUpInvalidElementsRule : JetBrains.ReSharper.UnitTestFramework.IUnitTestElementsTransformationRule
    {
        public void Apply(JetBrains.ReSharper.UnitTestFramework.UnitTestElements elements) { }
    }
    [JetBrains.ReSharper.UnitTestFramework.UnitTestElementsTransformationRuleAttribute()]
    public class EnsureRequiredElementsRule : JetBrains.ReSharper.UnitTestFramework.IUnitTestElementsTransformationRule
    {
        public void Apply(JetBrains.ReSharper.UnitTestFramework.UnitTestElements elements) { }
    }
    [JetBrains.ReSharper.UnitTestFramework.UnitTestElementsTransformationRuleAttribute()]
    public class MarkDynamicElementsAsPendingRule : JetBrains.ReSharper.UnitTestFramework.IUnitTestElementsTransformationRule
    {
        public void Apply(JetBrains.ReSharper.UnitTestFramework.UnitTestElements elements) { }
    }
    [JetBrains.ReSharper.UnitTestFramework.UnitTestElementsTransformationRuleAttribute()]
    public class SkipTestsFromExcludedCategoriesRule : JetBrains.ReSharper.UnitTestFramework.IUnitTestElementsTransformationRule
    {
        public SkipTestsFromExcludedCategoriesRule(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Settings.ISettingsStore store, JetBrains.ReSharper.UnitTestFramework.IUnitTestResultManager resultManager) { }
        public void Apply(JetBrains.ReSharper.UnitTestFramework.UnitTestElements elements) { }
    }
}
namespace JetBrains.ReSharper.UnitTestExplorer.EventBus
{
    
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class UnitTestsActivityTracking
    {
        public UnitTestsActivityTracking(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ReSharper.UnitTestFramework.IUnitTestSessionManager sessionManager, JetBrains.Util.EventBus.IEventContext context) { }
    }
}
namespace JetBrains.ReSharper.UnitTestExplorer
{
    
    public class GroupingSolutionContext
    {
        public readonly JetBrains.DataFlow.IProperty<JetBrains.ProjectModel.ProjectModelElementPointerManager> PMEPManager;
        public readonly JetBrains.DataFlow.IProperty<JetBrains.ProjectModel.ISolution> Solution;
        public GroupingSolutionContext() { }
    }
    public class static SessionNameUtil
    {
        public static string GuessFromContext(JetBrains.Application.DataContext.IDataContext context) { }
    }
    public abstract class ShowAllAccessActionBase : JetBrains.ActionManagement.IActionHandler
    {
        public void Execute(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.DelegateExecute nextExecute) { }
        public bool Update(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.ActionPresentation presentation, JetBrains.ActionManagement.DelegateUpdate nextUpdate) { }
    }
    public abstract class ShowFailedStatusActionBase : JetBrains.ReSharper.UnitTestExplorer.ShowStatusBaseAction
    {
        public override JetBrains.ReSharper.UnitTestFramework.UnitTestStatus UnitTestStatus { get; }
    }
    public abstract class ShowIgnoredStatusActionBase : JetBrains.ReSharper.UnitTestExplorer.ShowStatusBaseAction
    {
        public override JetBrains.ReSharper.UnitTestFramework.UnitTestStatus UnitTestStatus { get; }
    }
    public abstract class ShowOnlyFailedStatusActionBase : JetBrains.ReSharper.UnitTestExplorer.ShowOnlyStatusBaseAction
    {
        public override JetBrains.ReSharper.UnitTestFramework.UnitTestStatus UnitTestStatus { get; }
    }
    public abstract class ShowOnlyIgnoredStatusActionBase : JetBrains.ReSharper.UnitTestExplorer.ShowOnlyStatusBaseAction
    {
        public override JetBrains.ReSharper.UnitTestFramework.UnitTestStatus UnitTestStatus { get; }
    }
    public abstract class ShowOnlyStatusBaseAction : JetBrains.ActionManagement.IActionHandler
    {
        public abstract JetBrains.ReSharper.UnitTestFramework.UnitTestStatus UnitTestStatus { get; }
        public void Execute(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.DelegateExecute nextExecute) { }
        public bool Update(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.ActionPresentation presentation, JetBrains.ActionManagement.DelegateUpdate nextUpdate) { }
    }
    public abstract class ShowStatusBaseAction : JetBrains.ActionManagement.IActionHandler
    {
        public abstract JetBrains.ReSharper.UnitTestFramework.UnitTestStatus UnitTestStatus { get; }
        public void Execute(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.DelegateExecute nextExecute) { }
        public bool Update(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.ActionPresentation presentation, JetBrains.ActionManagement.DelegateUpdate nextUpdate) { }
    }
    public abstract class ShowSuccessStatusActionBase : JetBrains.ReSharper.UnitTestExplorer.ShowStatusBaseAction
    {
        public override JetBrains.ReSharper.UnitTestFramework.UnitTestStatus UnitTestStatus { get; }
    }
    public abstract class TrackRunningTestActionBase : JetBrains.ActionManagement.IActionHandler
    {
        public void Execute(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.DelegateExecute nextExecute) { }
        public bool Update(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.ActionPresentation presentation, JetBrains.ActionManagement.DelegateUpdate nextUpdate) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class UnitTestAgentManager : JetBrains.ReSharper.UnitTestFramework.IUnitTestAgentManager
    {
        public UnitTestAgentManager(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Settings.ISettingsStore settingsStore, JetBrains.ReSharper.UnitTestExplorer.RemoteChannel.TaskRunnerAgentEventsListener agentEventsListener) { }
        public void RegisterRun(JetBrains.ReSharper.UnitTestFramework.IUnitTestRun run, JetBrains.ReSharper.UnitTestFramework.Strategy.IUnitTestRunStrategy strategy, JetBrains.ReSharper.UnitTestFramework.ITaskRunnerHostController controller) { }
        public void SendPacket(JetBrains.ReSharper.UnitTestFramework.IUnitTestRun run, string packet) { }
    }
    public abstract class UnitTestBrowserRefreshActionBase : JetBrains.ActionManagement.IActionHandler
    {
        public void Execute(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.DelegateExecute nextExecute) { }
        public bool Update(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.ActionPresentation presentation, JetBrains.ActionManagement.DelegateUpdate nextUpdate) { }
    }
    public class static UnitTestDataConstants
    {
        public static readonly JetBrains.Application.DataContext.DataConstant<JetBrains.ReSharper.UnitTestFramework.UnitTestElements> UNIT_TEST_ELEMENTS;
    }
    public abstract class UnitTestDebugContextActionBase : JetBrains.ReSharper.UnitTestExplorer.Actions.UnitTestExplorerContextBaseAction
    {
        protected override bool IsRunOrDebugAction { get; }
        protected override JetBrains.ReSharper.UnitTestFramework.IHostProvider GetHostProvider() { }
    }
    public abstract class UnitTestDescriptorBase : JetBrains.IDE.TreeBrowser.TreeModelBrowserDescriptorBase
    {
        protected UnitTestDescriptorBase(JetBrains.ProjectModel.ISolution solution) { }
        public int GroupingIndex { get; set; }
        public System.Collections.Generic.List<JetBrains.TreeModels.TreeModelGrouping<JetBrains.ReSharper.UnitTestFramework.IUnitTestElement>> Groupings { get; }
        public override JetBrains.TreeModels.TreeModel Model { get; }
        public override JetBrains.UI.TreeView.StructuredPresenter<JetBrains.TreeModels.TreeModelNode, JetBrains.CommonControls.IPresentableItem> Presenter { get; }
        public override bool QuickSearchSupported { get; }
        protected JetBrains.TreeModels.TreeGroupModel<JetBrains.ReSharper.UnitTestFramework.IUnitTestElement> TreeModel { get; }
        public override bool VisibilitySupported { get; }
        protected virtual void CreateGroupings(System.Collections.Generic.List<JetBrains.TreeModels.TreeModelGrouping<JetBrains.ReSharper.UnitTestFramework.IUnitTestElement>> groupings) { }
        public override bool CustomizeActionBar(JetBrains.ActionManagement.IActionBar bar) { }
        protected abstract int GetDefaultGroupingIndex(JetBrains.Application.Settings.ISettingsStore store, System.Func<JetBrains.DataFlow.Lifetime, JetBrains.Application.DataContext.DataContexts, JetBrains.Application.DataContext.IDataContext> dataContext);
        public override bool Navigate(JetBrains.TreeModels.TreeModelNode node, JetBrains.UI.PopupWindowManager.PopupWindowContextSource windowContext, bool transferFocus, JetBrains.IDE.TabOptions options = 2) { }
        public override bool QuickSearchMatches(JetBrains.TreeModels.TreeModelNode viewNode, string quickSearchText) { }
        protected abstract void SetGroupingIndex(int index);
    }
    [JetBrains.ReSharper.Psi.Naming.Elements.NamedElementsBagAttribute(null)]
    public class UnitTestElementKindOfElementType : JetBrains.ReSharper.Psi.Naming.Elements.ElementKindOfElementType
    {
        public static readonly JetBrains.ReSharper.Psi.Naming.Elements.IElementKind TEST_MEMBER;
        public static readonly JetBrains.ReSharper.Psi.Naming.Elements.IElementKind TEST_TYPE;
        protected UnitTestElementKindOfElementType([JetBrains.Annotations.NotNullAttribute()] string name, string presentableName, System.Func<JetBrains.ReSharper.Psi.IDeclaredElement, bool> isApplicable) { }
        public override JetBrains.ReSharper.Psi.PsiLanguageType Language { get; }
    }
    public abstract class UnitTestExplorerContextRunAction1Base : JetBrains.ReSharper.UnitTestExplorer.Actions.UnitTestExplorerContextBaseAction
    {
        protected override bool IsRunOrDebugAction { get; }
        protected override JetBrains.ReSharper.UnitTestFramework.IHostProvider GetHostProvider() { }
    }
    public abstract class UnitTestExplorerContextRunAction2Base : JetBrains.ReSharper.UnitTestExplorer.Actions.UnitTestExplorerContextBaseAction
    {
        protected override bool IsRunOrDebugAction { get; }
        protected override JetBrains.ReSharper.UnitTestFramework.IHostProvider GetHostProvider() { }
    }
    public abstract class UnitTestExplorerContextRunAction3Base : JetBrains.ReSharper.UnitTestExplorer.Actions.UnitTestExplorerContextBaseAction
    {
        protected override bool IsRunOrDebugAction { get; }
        protected override JetBrains.ReSharper.UnitTestFramework.IHostProvider GetHostProvider() { }
    }
    public abstract class UnitTestExplorerContextRunAction4Base : JetBrains.ReSharper.UnitTestExplorer.Actions.UnitTestExplorerContextBaseAction
    {
        protected override bool IsRunOrDebugAction { get; }
        protected override JetBrains.ReSharper.UnitTestFramework.IHostProvider GetHostProvider() { }
    }
    public abstract class UnitTestExplorerContextRunAction5Base : JetBrains.ReSharper.UnitTestExplorer.Actions.UnitTestExplorerContextBaseAction
    {
        protected override bool IsRunOrDebugAction { get; }
        protected override JetBrains.ReSharper.UnitTestFramework.IHostProvider GetHostProvider() { }
    }
    public abstract class UnitTestExplorerRunCurrentSessionActionBase : JetBrains.ActionManagement.IActionHandler
    {
        public void Execute(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.DelegateExecute nextExecute) { }
        public bool Update(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.ActionPresentation presentation, JetBrains.ActionManagement.DelegateUpdate nextUpdate) { }
    }
    public class UnitTestExplorerToolWindowDescriptor : JetBrains.UI.ToolWindowManagement.ToolWindowDescriptor
    {
        public UnitTestExplorerToolWindowDescriptor(JetBrains.Application.IApplicationDescriptor applicationDescriptor) { }
    }
    public abstract class UnitTestExplorerToolWindowServiceBase : JetBrains.ReSharper.UnitTestFramework.UI.UnitTestExplorerWindowServiceImpl
    {
        protected UnitTestExplorerToolWindowServiceBase(JetBrains.DataFlow.Lifetime lifetime, JetBrains.UI.ToolWindowManagement.ToolWindowManager toolWindowManager, JetBrains.ReSharper.UnitTestExplorer.UnitTestExplorerToolWindowDescriptor unitTestExplorerToolWindowDescriptor, JetBrains.Application.Settings.ISettingsStore settingsStore, JetBrains.UI.Application.IUIApplication environment) { }
        protected void InitToolWindow(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.UnitTestFramework.Elements.IUnitTestElementManager manager, JetBrains.Application.Env.RunsProducts.ProductConfigurations productConfigurations, JetBrains.Application.Settings.ISettingsStore settingsStore, JetBrains.UI.Theming.ITheming themeManager) { }
        public override void OpenInExplorer(System.Collections.Generic.IList<JetBrains.ReSharper.UnitTestFramework.IUnitTestElement> elements) { }
        public override void RequestUpdateStructure() { }
    }
    public class UnitTestGroupings { }
    public abstract class UnitTestNodesBaseAction : JetBrains.ActionManagement.IActionHandler
    {
        public void Execute(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.DelegateExecute nextExecute) { }
        protected abstract void ExecuteElements(JetBrains.ReSharper.UnitTestFramework.IUnitTestSessionManager manager, JetBrains.ReSharper.UnitTestFramework.UnitTestElements elements, string name, JetBrains.UI.PopupWindowManager.PopupWindowContextSource wndCtx);
        public virtual bool Update(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.ActionPresentation presentation, JetBrains.ActionManagement.DelegateUpdate nextUpdate) { }
    }
    [JetBrains.UI.ActiveText.ProtocolHandlerAttribute(Protocol="unittestelement", SchemeDelimiter=":")]
    public class UnitTestProtocolHandler : JetBrains.UI.ActiveText.IProtocolHandler
    {
        public const string LinkPrefix = "unittestelement:";
        public void Navigate(string link, object host) { }
    }
    public abstract class UnitTestRunContextActionBase : JetBrains.ReSharper.UnitTestExplorer.Actions.UnitTestExplorerContextBaseAction
    {
        protected override bool IsRunOrDebugAction { get; }
        protected override JetBrains.ReSharper.UnitTestFramework.IHostProvider GetHostProvider() { }
    }
    public abstract class UnitTestSessionAbortActionBase : JetBrains.ActionManagement.IActionHandler
    {
        public void Execute(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.DelegateExecute nextExecute) { }
        public bool Update(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.ActionPresentation presentation, JetBrains.ActionManagement.DelegateUpdate nextUpdate) { }
    }
    public abstract class UnitTestSessionBuildPolicyAlwaysBase : JetBrains.ReSharper.UnitTestExplorer.UnitTestSessionBuildPolicyBase
    {
        protected override JetBrains.ReSharper.UnitTestFramework.BuildPolicy BuildPolicy { get; }
    }
    public abstract class UnitTestSessionBuildPolicyAutomaticBase : JetBrains.ReSharper.UnitTestExplorer.UnitTestSessionBuildPolicyBase
    {
        protected override JetBrains.ReSharper.UnitTestFramework.BuildPolicy BuildPolicy { get; }
    }
    public abstract class UnitTestSessionBuildPolicyBase : JetBrains.ActionManagement.IActionHandler
    {
        protected abstract JetBrains.ReSharper.UnitTestFramework.BuildPolicy BuildPolicy { get; }
        public void Execute(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.DelegateExecute nextExecute) { }
        public bool Update(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.ActionPresentation presentation, JetBrains.ActionManagement.DelegateUpdate nextUpdate) { }
    }
    public abstract class UnitTestSessionBuildPolicyNeverBase : JetBrains.ReSharper.UnitTestExplorer.UnitTestSessionBuildPolicyBase
    {
        protected override JetBrains.ReSharper.UnitTestFramework.BuildPolicy BuildPolicy { get; }
    }
    public abstract class UnitTestSessionBuildPolicyWholeSolutionBase : JetBrains.ReSharper.UnitTestExplorer.UnitTestSessionBuildPolicyBase
    {
        protected override JetBrains.ReSharper.UnitTestFramework.BuildPolicy BuildPolicy { get; }
    }
    public abstract class UnitTestSessionLockActionBase : JetBrains.ActionManagement.IActionHandler
    {
        public void Execute(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.DelegateExecute nextExecute) { }
        public bool Update(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.ActionPresentation presentation, JetBrains.ActionManagement.DelegateUpdate nextUpdate) { }
    }
    public abstract class UnitTestSessionRunActionBase : JetBrains.ActionManagement.IActionHandler
    {
        protected virtual bool RunSelected { get; }
        public virtual void Execute(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.DelegateExecute nextExecute) { }
        protected abstract JetBrains.ReSharper.UnitTestFramework.IHostProvider GetHostProvider();
        public virtual bool Update(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.ActionPresentation presentation, JetBrains.ActionManagement.DelegateUpdate nextUpdate) { }
    }
    public abstract class UnitTestSessionRunAll1ActionBase : JetBrains.ReSharper.UnitTestExplorer.UnitTestSessionRunAllMainAction
    {
        protected override JetBrains.ReSharper.UnitTestFramework.IHostProvider GetHostProvider() { }
    }
    public abstract class UnitTestSessionRunAll2ActionBase : JetBrains.ReSharper.UnitTestExplorer.UnitTestSessionRunAllMainAction
    {
        protected override JetBrains.ReSharper.UnitTestFramework.IHostProvider GetHostProvider() { }
    }
    public abstract class UnitTestSessionRunAll3ActionBase : JetBrains.ReSharper.UnitTestExplorer.UnitTestSessionRunAllMainAction
    {
        protected override JetBrains.ReSharper.UnitTestFramework.IHostProvider GetHostProvider() { }
    }
    public abstract class UnitTestSessionRunAll4ActionBase : JetBrains.ReSharper.UnitTestExplorer.UnitTestSessionRunAllMainAction
    {
        protected override JetBrains.ReSharper.UnitTestFramework.IHostProvider GetHostProvider() { }
    }
    public abstract class UnitTestSessionRunAll5ActionBase : JetBrains.ReSharper.UnitTestExplorer.UnitTestSessionRunAllMainAction
    {
        protected override JetBrains.ReSharper.UnitTestFramework.IHostProvider GetHostProvider() { }
    }
    public abstract class UnitTestSessionRunAllMainAction : JetBrains.ReSharper.UnitTestExplorer.UnitTestSessionRunActionBase
    {
        protected override bool RunSelected { get; }
        public override bool Update(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.ActionPresentation presentation, JetBrains.ActionManagement.DelegateUpdate nextUpdate) { }
    }
    public abstract class UnitTestSessionRunAllTestsInSessionActionBase : JetBrains.ReSharper.UnitTestExplorer.UnitTestSessionRunAllMainAction
    {
        public override void Execute(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.DelegateExecute nextExecute) { }
        protected override JetBrains.ReSharper.UnitTestFramework.IHostProvider GetHostProvider() { }
    }
    public abstract class UnitTestSessionTargetPlatformBase : JetBrains.ActionManagement.IActionHandler
    {
        protected abstract JetBrains.ReSharper.TaskRunnerFramework.PlatformType PlatformType { get; }
        public void Execute(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.DelegateExecute nextExecute) { }
        public bool Update(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.ActionPresentation presentation, JetBrains.ActionManagement.DelegateUpdate nextUpdate) { }
    }
    public abstract class UnitTestSessionTargetPlatformDefaultBase : JetBrains.ReSharper.UnitTestExplorer.UnitTestSessionTargetPlatformBase
    {
        protected override JetBrains.ReSharper.TaskRunnerFramework.PlatformType PlatformType { get; }
    }
    public abstract class UnitTestSessionTargetPlatformGroupBase : JetBrains.ActionManagement.IActionHandler
    {
        public void Execute(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.DelegateExecute nextExecute) { }
        public bool Update(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.ActionPresentation presentation, JetBrains.ActionManagement.DelegateUpdate nextUpdate) { }
    }
    public abstract class UnitTestSessionTargetPlatformMSILBase : JetBrains.ReSharper.UnitTestExplorer.UnitTestSessionTargetPlatformBase
    {
        protected override JetBrains.ReSharper.TaskRunnerFramework.PlatformType PlatformType { get; }
    }
    public abstract class UnitTestSessionTargetPlatformX64Base : JetBrains.ReSharper.UnitTestExplorer.UnitTestSessionTargetPlatformBase
    {
        protected override JetBrains.ReSharper.TaskRunnerFramework.PlatformType PlatformType { get; }
    }
    public abstract class UnitTestSessionTargetPlatformX86Base : JetBrains.ReSharper.UnitTestExplorer.UnitTestSessionTargetPlatformBase
    {
        protected override JetBrains.ReSharper.TaskRunnerFramework.PlatformType PlatformType { get; }
    }
    public abstract class UnitTestSessionTimeActionBase : JetBrains.ActionManagement.IActionHandler
    {
        public void Execute(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.DelegateExecute nextExecute) { }
        public bool Update(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.ActionPresentation presentation, JetBrains.ActionManagement.DelegateUpdate nextUpdate) { }
    }
    public class UnitTestSessionToolWindowDescriptor : JetBrains.UI.ToolWindowManagement.ToolWindowDescriptor
    {
        public UnitTestSessionToolWindowDescriptor(JetBrains.Application.IApplicationDescriptor applicationDescriptor) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class UnitTestStatusInEditorUpdater
    {
        public UnitTestStatusInEditorUpdater(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.UnitTestFramework.IUnitTestResultManager resultManager, JetBrains.TextControl.ITextControlManager textControlManager, JetBrains.ReSharper.Daemon.Daemon daemon, JetBrains.Application.IShellLocks shellLocks, JetBrains.Application.ChangeManager changeManager, JetBrains.DocumentManagers.DocumentManager documentManager, JetBrains.ReSharper.UnitTestFramework.Elements.UnitTestElementProjectFileCache projectFileCache, JetBrains.ReSharper.Psi.Files.IPsiFiles psiFiles) { }
    }
    public class UnitTestTreeModelBrowserComparer : JetBrains.ReSharper.Features.Shared.TreePsiBrowser.TreeModelBrowserComparer
    {
        public UnitTestTreeModelBrowserComparer(JetBrains.ProjectModel.IProjectPresentablePathProvider presentablePathProvider) { }
        protected override System.Type DisambiguateTypeConflict(System.Type t1, System.Type t2) { }
    }
    [JetBrains.Application.Configuration.Upgrade.GlobalSettingsUpgraderAttribute()]
    public class UnitTestWorkspaceSettingsTableUpgrader : JetBrains.Application.Configuration.SettingTablesUpgrader
    {
        public UnitTestWorkspaceSettingsTableUpgrader(JetBrains.Application.Env.RunsProducts.ProductConfigurations productConfigurations) { }
        protected override void DoUpgrade(JetBrains.Application.Configuration.IComponentSettingsProvider legacySettingsProvider, JetBrains.Application.Settings.IContextBoundSettingsStore boundSettingsStore, JetBrains.DataFlow.Lifetime upgradeLifetime, JetBrains.Application.Configuration.SettingsTableBase workspaceSettingsTable, JetBrains.Application.Configuration.SettingsTableBase globalSettingsTable) { }
    }
}
namespace JetBrains.ReSharper.UnitTestExplorer.Launch
{
    
    public class UnitTestLaunch : JetBrains.ReSharper.UnitTestFramework.IUnitTestLaunch
    {
        public UnitTestLaunch(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.UnitTestFramework.IUnitTestLaunchManager launchManager, JetBrains.Application.Settings.IContextBoundSettingsStore settingsStore, JetBrains.Application.IShellLocks shellLocks, JetBrains.ReSharper.UnitTestFramework.IUnitTestResultManager resultManager, System.Action finishAction, JetBrains.ReSharper.UnitTestExplorer.UnitTestAgentManager unitTestAgentManager, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.UnitTestFramework.IDiscoveredRemoteTaskHandler> taskHandlers, System.Action<JetBrains.ReSharper.UnitTestFramework.IUnitTestElement> addDynamicElement) { }
        public System.DateTime DateTimeStarted { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.UnitTestFramework.IUnitTestElement> Elements { get; }
        public string Id { get; }
        public JetBrains.ReSharper.UnitTestFramework.IUnitTestElement LastStartedElement { get; }
        public JetBrains.DataFlow.Lifetime Lifetime { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.UnitTestFramework.IUnitTestRun> Runs { get; }
        public JetBrains.DataFlow.IProperty<JetBrains.ReSharper.UnitTestFramework.UnitTestSessionState> State { get; }
        public void Abort() { }
        public void AddElement(JetBrains.ReSharper.UnitTestFramework.IUnitTestElement element) { }
        public JetBrains.ReSharper.UnitTestFramework.IUnitTestRun CreateRun(JetBrains.ReSharper.TaskRunnerFramework.RuntimeEnvironment runtimeEnvironment) { }
        public void Finished() { }
        public JetBrains.ReSharper.UnitTestFramework.IUnitTestRun GetRun(string id) { }
        public JetBrains.ReSharper.TaskRunnerFramework.RemoteTask[][] GetTasks(string runId) { }
        public void Run(JetBrains.ReSharper.UnitTestFramework.UnitTestElements elements, System.Collections.Generic.IEnumerable<JetBrains.ProjectModel.IProject> projects, JetBrains.ReSharper.UnitTestFramework.IHostProvider hostProvider, JetBrains.ReSharper.TaskRunnerFramework.PlatformType platformType, JetBrains.ReSharper.TaskRunnerFramework.PlatformVersion platformVersion) { }
        public void TaskDiscovered(JetBrains.ReSharper.UnitTestFramework.IUnitTestRun run, JetBrains.ReSharper.TaskRunnerFramework.RemoteTask task) { }
        public void TaskDuration(JetBrains.ReSharper.TaskRunnerFramework.RemoteTask remoteTask, System.TimeSpan duration) { }
        public void TaskException(JetBrains.ReSharper.TaskRunnerFramework.RemoteTask remoteTask, JetBrains.ReSharper.TaskRunnerFramework.TaskException[] exceptions) { }
        public void TaskFinished(JetBrains.ReSharper.TaskRunnerFramework.RemoteTask remoteTask, string message, JetBrains.ReSharper.TaskRunnerFramework.TaskResult result) { }
        public void TaskOutput(JetBrains.ReSharper.TaskRunnerFramework.RemoteTask remoteTask, string text, JetBrains.ReSharper.TaskRunnerFramework.TaskOutputType type) { }
        public void TaskStarting(JetBrains.ReSharper.TaskRunnerFramework.RemoteTask remoteTask) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class UnitTestLaunchManager : JetBrains.ReSharper.UnitTestFramework.IUnitTestLaunchManager
    {
        public UnitTestLaunchManager(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Settings.ISettingsStore settingsStore, JetBrains.DataFlow.IViewable<JetBrains.ReSharper.UnitTestFramework.IUnitTestElementsTransformationRule> elementsRules, JetBrains.Application.IShellLocks shellLocks, JetBrains.ReSharper.UnitTestFramework.IUnitTestResultManager resultManager, JetBrains.ReSharper.UnitTestFramework.IUnitTestSolutionBuilder solutionBuilder, JetBrains.ReSharper.UnitTestExplorer.UnitTestAgentManager unitTestAgentManager, JetBrains.ReSharper.UnitTestFramework.UnitTestBackgroundProjectExplorer projectExplorer, JetBrains.ReSharper.UnitTestFramework.IUnitTestSessionManager sessionManager) { }
        public void AbortBuild() { }
        public void BuildAndRunSession(JetBrains.ReSharper.UnitTestFramework.IUnitTestSessionView sessionView, JetBrains.ReSharper.UnitTestFramework.UnitTestElements elements, JetBrains.ReSharper.UnitTestFramework.IHostProvider hostProvider, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.UnitTestFramework.IUnitTestElementsTransformationRule> rules, JetBrains.ReSharper.UnitTestFramework.BuildPolicy buildPolicy = 0, JetBrains.ReSharper.TaskRunnerFramework.PlatformType platformType = 0, JetBrains.ReSharper.TaskRunnerFramework.PlatformVersion frameworkVersion = 0, bool focusAfterBuild = False) { }
        public JetBrains.ReSharper.UnitTestFramework.IUnitTestLaunch CreateLaunch(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.UnitTestFramework.IDiscoveredRemoteTaskHandler> taskHandlers, System.Action<JetBrains.ReSharper.UnitTestFramework.IUnitTestElement> addElement) { }
        public JetBrains.ReSharper.UnitTestFramework.IUnitTestLaunch GetLaunchByRun(string runId) { }
        public JetBrains.ReSharper.UnitTestFramework.IUnitTestRun GetRun(string id) { }
        public bool HasPreviousRunForSession(JetBrains.ReSharper.UnitTestFramework.IUnitTestSession session) { }
        public void RepeatPreviousRunForSession(JetBrains.ReSharper.UnitTestFramework.IUnitTestSessionView session) { }
        public void RunSession(JetBrains.ReSharper.UnitTestFramework.IUnitTestSession session, JetBrains.ReSharper.UnitTestFramework.UnitTestElements elements, JetBrains.ReSharper.UnitTestFramework.IHostProvider hostProvider, System.Collections.Generic.JetHashSet<JetBrains.ProjectModel.IProject> projects = null, JetBrains.ReSharper.UnitTestFramework.IUnitTestLaunch launch = null, JetBrains.ReSharper.TaskRunnerFramework.PlatformType platformType = 0, JetBrains.ReSharper.TaskRunnerFramework.PlatformVersion frameworkVersion = 0) { }
    }
    public class UnitTestRun : JetBrains.Util.UserDataHolder, JetBrains.ReSharper.UnitTestFramework.IUnitTestRun, JetBrains.Util.IUserDataHolder
    {
        public UnitTestRun(JetBrains.ReSharper.UnitTestExplorer.Launch.UnitTestLaunch launch, JetBrains.ReSharper.TaskRunnerFramework.RuntimeEnvironment runtimeEnvironment) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.UnitTestFramework.IUnitTestElement> Elements { get; }
        public string ID { get; }
        public JetBrains.ReSharper.UnitTestFramework.UnitTestRunStatus RunStatus { get; set; }
        public JetBrains.ReSharper.TaskRunnerFramework.RuntimeEnvironment RuntimeEnvironment { get; }
        public void AddElement(JetBrains.ReSharper.UnitTestFramework.IUnitTestElement element, System.Collections.Generic.ICollection<JetBrains.ReSharper.UnitTestFramework.IUnitTestElement> explicitElements) { }
        public void AddTask(JetBrains.ReSharper.TaskRunnerFramework.RemoteTask task) { }
        public void CreateDynamicElement(JetBrains.ReSharper.TaskRunnerFramework.RemoteTask remoteTask) { }
        public JetBrains.ReSharper.UnitTestFramework.IUnitTestElement GetElement(JetBrains.ReSharper.TaskRunnerFramework.RemoteTask remoteTask) { }
        public JetBrains.ReSharper.UnitTestFramework.IUnitTestElement GetElementByRemoteTaskId(string id) { }
        public System.Collections.Generic.Dictionary<string, JetBrains.ReSharper.UnitTestFramework.IUnitTestElement> GetTaskIdsToElements() { }
        public JetBrains.ReSharper.TaskRunnerFramework.RemoteTask[][] GetTasks() { }
    }
    public class UnitTestRunProperties : System.IComparable<JetBrains.ReSharper.UnitTestExplorer.Launch.UnitTestRunProperties>
    {
        public UnitTestRunProperties(JetBrains.ReSharper.UnitTestFramework.IUnitTestProvider provider, JetBrains.ProjectModel.IProject project, JetBrains.ReSharper.UnitTestFramework.Strategy.IUnitTestRunStrategy runStrategy, JetBrains.ReSharper.TaskRunnerFramework.RuntimeEnvironment runtimeEnvironment) { }
        public JetBrains.ReSharper.UnitTestFramework.ITaskRunnerHostController RunController { get; set; }
        public JetBrains.ReSharper.UnitTestFramework.Strategy.IUnitTestRunStrategy RunStrategy { get; }
        public JetBrains.ReSharper.TaskRunnerFramework.RuntimeEnvironment RuntimeEnvironment { get; }
        public int CompareTo(JetBrains.ReSharper.UnitTestExplorer.Launch.UnitTestRunProperties other) { }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
    }
}
namespace JetBrains.ReSharper.UnitTestExplorer.Manager
{
    
    [JetBrains.ReSharper.UnitTestFramework.UnitTestHostProviderAttribute()]
    public class DebugHostProvider : JetBrains.ReSharper.UnitTestFramework.IHostProvider
    {
        public DebugHostProvider(JetBrains.Util.Lazy.Lazy<Microsoft.VisualStudio.Shell.Interop.IVsDebugger2> debugger, EnvDTE.DTE dte, JetBrains.Threading.IThreading threading) { }
        public JetBrains.ReSharper.UnitTestFramework.IHostProviderDescriptor Descriptor { get; }
        public string ID { get; }
        public bool Available() { }
        public bool Available(JetBrains.ReSharper.UnitTestFramework.IUnitTestElement element) { }
        public JetBrains.ReSharper.UnitTestFramework.ITaskRunnerHostController CreateHostController(JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.UnitTestFramework.IUnitTestLaunchManager sessionManager, JetBrains.ReSharper.UnitTestFramework.IUnitTestAgentManager agentManager, JetBrains.ReSharper.UnitTestFramework.IUnitTestLaunch launch) { }
    }
    public class DebugHostProviderDescriptor : JetBrains.ReSharper.UnitTestFramework.IHostProviderDescriptor
    {
        public string AllFromSolutionText { get; }
        public string Format { get; }
        public bool HasRunAllAction { get; }
        public bool HasRunAllFromSolutionAction { get; }
        public JetBrains.UI.Icons.IconId Icon { get; }
        public JetBrains.UI.Icons.IconId IconAll { get; }
        public int Priority { get; }
    }
    public class DebugTaskRunnerHostController : JetBrains.ReSharper.UnitTestFramework.TaskRunnerHostControllerBase, Microsoft.VisualStudio.Shell.Interop.IVsDebuggerEvents
    {
        public DebugTaskRunnerHostController(JetBrains.ReSharper.UnitTestFramework.IUnitTestLaunchManager launchManager, JetBrains.ReSharper.UnitTestFramework.IUnitTestAgentManager agentManager, JetBrains.Util.Lazy.Lazy<Microsoft.VisualStudio.Shell.Interop.IVsDebugger2> debugger2, EnvDTE.DTE dte, JetBrains.Threading.IThreading threading, JetBrains.ReSharper.UnitTestFramework.IUnitTestLaunch launch, int portNumber) { }
        public override string HostId { get; }
        public override void Abort(JetBrains.ReSharper.UnitTestFramework.IUnitTestRun run) { }
        public override void Cancel(JetBrains.ReSharper.UnitTestFramework.IUnitTestRun run) { }
        protected override void Dispose(bool disposing) { }
        public int OnModeChange(Microsoft.VisualStudio.Shell.Interop.DBGMODE dbgmodeNew) { }
        public override void Run(JetBrains.ReSharper.UnitTestFramework.IUnitTestRun run) { }
    }
}
namespace JetBrains.ReSharper.UnitTestExplorer.Options
{
    
    public class EnumValueConverter : System.Windows.Data.IValueConverter
    {
        public EnumValueConverter(System.Type type) { }
        public object Convert(object value, System.Type targetType, object parameter, System.Globalization.CultureInfo culture) { }
        public object ConvertBack(object value, System.Type targetType, object parameter, System.Globalization.CultureInfo culture) { }
    }
    public class EnumValuesConverter : System.Windows.Data.IValueConverter
    {
        public object Convert(object value, System.Type targetType, object parameter, System.Globalization.CultureInfo culture) { }
        public object ConvertBack(object value, System.Type targetType, object parameter, System.Globalization.CultureInfo culture) { }
    }
    public abstract class UnitTestingPageBase : JetBrains.UI.Options.Helpers.AOptionsPage
    {
        public const string PID = "UnitTesting";
        protected UnitTestingPageBase([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, JetBrains.UI.Options.OptionsSettingsSmartContext settings, JetBrains.Application.Env.RunsProducts.ProductConfigurations productConfigurations, System.Windows.Forms.IWin32Window mainWindow, JetBrains.ReSharper.UnitTestExplorer.Options.UnitTestingPageBase.BindEnableUnitTestingSetting bindEnableUnitTestingSetting, JetBrains.UI.Application.IUIApplication uiApplicationEnvironment) { }
        public int ParallelProcessesCount { get; set; }
        public JetBrains.ReSharper.TaskRunnerFramework.PlatformType PlatformType { get; set; }
        public JetBrains.ReSharper.TaskRunnerFramework.PlatformVersion PlatformVersion { get; set; }
        public string SkippedCategories { get; set; }
        public override bool OnOk() { }
        public delegate void BindEnableUnitTestingSetting(JetBrains.DataFlow.Lifetime lifetime, JetBrains.UI.Options.OptionsSettingsSmartContext smartContext, JetBrains.DataFlow.IProperty<bool> enableUnitTesting);
    }
}
namespace JetBrains.ReSharper.UnitTestExplorer.RemoteChannel
{
    
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class CacheFolderPacketHandler : JetBrains.ReSharper.UnitTestFramework.ITaskRunnerPacketHandler
    {
        public string PacketName { get; }
        public void Accept(System.Xml.XmlElement packet, JetBrains.ReSharper.TaskRunnerFramework.RemoteChannel remoteChannel) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class TaskCreatePacketHandler : JetBrains.ReSharper.UnitTestExplorer.RemoteChannel.TaskPacketHandlerBase
    {
        public TaskCreatePacketHandler(JetBrains.ReSharper.UnitTestFramework.IUnitTestLaunchManager launchManager) { }
        public override string PacketName { get; }
        protected override void AcceptTask(JetBrains.ReSharper.UnitTestFramework.IUnitTestLaunch launch, JetBrains.ReSharper.UnitTestFramework.IUnitTestRun run1, JetBrains.ReSharper.TaskRunnerFramework.RemoteTask task, System.Xml.XmlElement packet) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class TaskDiscoveredPacketHandler : JetBrains.ReSharper.UnitTestExplorer.RemoteChannel.TaskPacketHandlerBase
    {
        public TaskDiscoveredPacketHandler(JetBrains.ReSharper.UnitTestFramework.IUnitTestLaunchManager launchManager) { }
        public override string PacketName { get; }
        protected override void AcceptTask(JetBrains.ReSharper.UnitTestFramework.IUnitTestLaunch launch, JetBrains.ReSharper.UnitTestFramework.IUnitTestRun run, JetBrains.ReSharper.TaskRunnerFramework.RemoteTask task, System.Xml.XmlElement packet) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class TaskDurationPacketHandler : JetBrains.ReSharper.UnitTestExplorer.RemoteChannel.TaskPacketHandlerBase
    {
        public TaskDurationPacketHandler(JetBrains.ReSharper.UnitTestFramework.IUnitTestLaunchManager launchManager) { }
        public override string PacketName { get; }
        protected override void AcceptTask(JetBrains.ReSharper.UnitTestFramework.IUnitTestLaunch launch, JetBrains.ReSharper.UnitTestFramework.IUnitTestRun run, JetBrains.ReSharper.TaskRunnerFramework.RemoteTask task, System.Xml.XmlElement packet) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class TaskExceptionPacketHandler : JetBrains.ReSharper.UnitTestExplorer.RemoteChannel.TaskPacketHandlerBase
    {
        public TaskExceptionPacketHandler(JetBrains.ReSharper.UnitTestFramework.IUnitTestLaunchManager launchManager) { }
        public override string PacketName { get; }
        protected override void AcceptTask(JetBrains.ReSharper.UnitTestFramework.IUnitTestLaunch launch, JetBrains.ReSharper.UnitTestFramework.IUnitTestRun run, JetBrains.ReSharper.TaskRunnerFramework.RemoteTask task, System.Xml.XmlElement packet) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class TaskFinishPacketHandler : JetBrains.ReSharper.UnitTestExplorer.RemoteChannel.TaskPacketHandlerBase
    {
        public TaskFinishPacketHandler(JetBrains.ReSharper.UnitTestFramework.IUnitTestLaunchManager launchManager) { }
        public override string PacketName { get; }
        public override void Accept(System.Xml.XmlElement packet, JetBrains.ReSharper.TaskRunnerFramework.RemoteChannel remoteChannel) { }
        protected override void AcceptTask(JetBrains.ReSharper.UnitTestFramework.IUnitTestLaunch launch, JetBrains.ReSharper.UnitTestFramework.IUnitTestRun run, JetBrains.ReSharper.TaskRunnerFramework.RemoteTask task, System.Xml.XmlElement packet) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class TaskOutputPacketHandler : JetBrains.ReSharper.UnitTestExplorer.RemoteChannel.TaskPacketHandlerBase
    {
        public TaskOutputPacketHandler(JetBrains.ReSharper.UnitTestFramework.IUnitTestLaunchManager launchManager) { }
        public override string PacketName { get; }
        protected override void AcceptTask(JetBrains.ReSharper.UnitTestFramework.IUnitTestLaunch launch, JetBrains.ReSharper.UnitTestFramework.IUnitTestRun run, JetBrains.ReSharper.TaskRunnerFramework.RemoteTask task, System.Xml.XmlElement packet) { }
    }
    public abstract class TaskPacketHandlerBase : JetBrains.ReSharper.UnitTestFramework.ITaskRunnerPacketHandler
    {
        protected TaskPacketHandlerBase(JetBrains.ReSharper.UnitTestFramework.IUnitTestLaunchManager launchManager) { }
        protected JetBrains.ReSharper.UnitTestFramework.IUnitTestLaunchManager LaunchManager { get; }
        public abstract string PacketName { get; }
        public virtual void Accept(System.Xml.XmlElement packet, JetBrains.ReSharper.TaskRunnerFramework.RemoteChannel remoteChannel) { }
        protected abstract void AcceptTask(JetBrains.ReSharper.UnitTestFramework.IUnitTestLaunch launch, JetBrains.ReSharper.UnitTestFramework.IUnitTestRun run, JetBrains.ReSharper.TaskRunnerFramework.RemoteTask task, System.Xml.XmlElement packet);
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class TaskRunnerAgentEventsListener : JetBrains.ReSharper.UnitTestFramework.ITaskRunnerPacketHandler
    {
        public readonly JetBrains.DataFlow.ISignal<System.Collections.Generic.KeyValuePair<string, JetBrains.ReSharper.TaskRunnerFramework.IRemoteChannel>> AgentConnected;
        public TaskRunnerAgentEventsListener(JetBrains.DataFlow.Lifetime lifetime) { }
        public string PacketName { get; }
        public void Accept(System.Xml.XmlElement packet, JetBrains.ReSharper.TaskRunnerFramework.RemoteChannel remoteChannel) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class TaskRunnerEventsListener : JetBrains.ReSharper.TaskRunnerFramework.IRemoteChannelMessageListener
    {
        public TaskRunnerEventsListener(JetBrains.DataFlow.Lifetime lifetime, JetBrains.DataFlow.IViewable<JetBrains.ReSharper.UnitTestFramework.ITaskRunnerPacketHandler> packetHandlers) { }
        public void OnError(string message) { }
        public void OnError(System.Exception exception) { }
        public void OnPacket(System.Xml.XmlElement message, JetBrains.ReSharper.TaskRunnerFramework.RemoteChannel remoteChannel) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class TaskStartPacketHandler : JetBrains.ReSharper.UnitTestExplorer.RemoteChannel.TaskPacketHandlerBase
    {
        public TaskStartPacketHandler(JetBrains.ReSharper.UnitTestFramework.IUnitTestLaunchManager launchManager) { }
        public override string PacketName { get; }
        protected override void AcceptTask(JetBrains.ReSharper.UnitTestFramework.IUnitTestLaunch launch, JetBrains.ReSharper.UnitTestFramework.IUnitTestRun run, JetBrains.ReSharper.TaskRunnerFramework.RemoteTask task, System.Xml.XmlElement packet) { }
    }
}
namespace JetBrains.ReSharper.UnitTestExplorer.Resources.UnitTestingIcons
{
    
    [JetBrains.Application.ShellComponentAttribute(JetBrains.Application.Sharing.Common, JetBrains.Application.Lifecycle.DemandReclaimable, JetBrains.Application.Creation.AnyThread, JetBrains.Application.Access.AnyThread)]
    public class IconsForIconThemeSelectionSampleUnitTesting : JetBrains.UI.Icons.Settings.IIconsForIconThemeSelectionSample { }
}
namespace JetBrains.ReSharper.UnitTestExplorer.Session.Actions
{
    
    public abstract class AppendTestsActionBase : JetBrains.ReSharper.UnitTestExplorer.Actions.UnitTestContextActionBase
    {
        protected override void Execute(JetBrains.ReSharper.UnitTestFramework.UnitTestElements elements, JetBrains.ReSharper.UnitTestFramework.IUnitTestSessionView session, JetBrains.ProjectModel.ISolution solution, JetBrains.Application.DataContext.IDataContext context) { }
        protected override bool Update(JetBrains.ActionManagement.ActionPresentation presentation, bool hasAnyTests, JetBrains.ReSharper.UnitTestFramework.IUnitTestSessionView session) { }
    }
    public abstract class NewSessionActionBase : JetBrains.ReSharper.UnitTestExplorer.Actions.UnitTestContextActionBase
    {
        protected override void Execute(JetBrains.ReSharper.UnitTestFramework.UnitTestElements elements, JetBrains.ReSharper.UnitTestFramework.IUnitTestSessionView session, JetBrains.ProjectModel.ISolution solution, JetBrains.Application.DataContext.IDataContext context) { }
        protected override bool Update(JetBrains.ActionManagement.ActionPresentation presentation, bool hasAnyTests, JetBrains.ReSharper.UnitTestFramework.IUnitTestSessionView session) { }
    }
    public abstract class RepeatPreviousRunActionBase : JetBrains.ActionManagement.IActionHandler
    {
        public void Execute(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.DelegateExecute nextExecute) { }
        public bool Update(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.ActionPresentation presentation, JetBrains.ActionManagement.DelegateUpdate nextUpdate) { }
    }
    public abstract class UnitTestSessionAppendChildrenBase : JetBrains.ActionManagement.IActionHandler
    {
        public void Execute(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.DelegateExecute nextExecute) { }
        public bool Update(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.ActionPresentation presentation, JetBrains.ActionManagement.DelegateUpdate nextUpdate) { }
    }
    public abstract class UnitTestSessionRenameActionBase : JetBrains.ActionManagement.IActionHandler
    {
        public void Execute(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.DelegateExecute nextExecute) { }
        public bool Update(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.ActionPresentation presentation, JetBrains.ActionManagement.DelegateUpdate nextUpdate) { }
    }
    public abstract class UnitTestSessionTargetFrameworkActionBase : JetBrains.ActionManagement.IActionHandler
    {
        protected abstract JetBrains.ReSharper.TaskRunnerFramework.PlatformVersion PlatformVersion { get; }
        public void Execute(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.DelegateExecute nextExecute) { }
        public bool Update(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.ActionPresentation presentation, JetBrains.ActionManagement.DelegateUpdate nextUpdate) { }
    }
    public abstract class UnitTestSessionTargetFrameworkClr2Base : JetBrains.ReSharper.UnitTestExplorer.Session.Actions.UnitTestSessionTargetFrameworkActionBase
    {
        protected override JetBrains.ReSharper.TaskRunnerFramework.PlatformVersion PlatformVersion { get; }
    }
    public abstract class UnitTestSessionTargetFrameworkClr4Base : JetBrains.ReSharper.UnitTestExplorer.Session.Actions.UnitTestSessionTargetFrameworkActionBase
    {
        protected override JetBrains.ReSharper.TaskRunnerFramework.PlatformVersion PlatformVersion { get; }
    }
    public abstract class UnitTestSessionTargetFrameworkDefaultBase : JetBrains.ReSharper.UnitTestExplorer.Session.Actions.UnitTestSessionTargetFrameworkActionBase
    {
        protected override JetBrains.ReSharper.TaskRunnerFramework.PlatformVersion PlatformVersion { get; }
    }
    public abstract class UnitTestSessionTargetFrameworkGroupBase : JetBrains.ActionManagement.IActionHandler
    {
        public void Execute(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.DelegateExecute nextExecute) { }
        public bool Update(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.ActionPresentation presentation, JetBrains.ActionManagement.DelegateUpdate nextUpdate) { }
    }
}
namespace JetBrains.ReSharper.UnitTestExplorer.Session
{
    
    public class static AppendToSessionMenu
    {
        public static bool CanAddElementsToSession(JetBrains.ReSharper.UnitTestFramework.IUnitTestSessionView session) { }
        public static void FillMenu(JetBrains.DataFlow.Lifetime lifetime, JetBrains.UI.PopupMenu.JetPopupMenu menu, JetBrains.ReSharper.UnitTestFramework.IUnitTestSessionManager sessionManager, JetBrains.ReSharper.UnitTestFramework.UnitTestElements elements, bool addNewSessionItem) { }
        public static void Show(JetBrains.DataFlow.Lifetime lifetime, JetBrains.UI.PopupWindowManager.PopupWindowContextSource ctx, JetBrains.ReSharper.UnitTestFramework.IUnitTestSessionManager sessionManager, JetBrains.ReSharper.UnitTestFramework.UnitTestElements elements) { }
    }
    public abstract class UnitTestElementsUndoUnitBase : Microsoft.VisualStudio.OLE.Interop.IOleUndoUnit
    {
        protected readonly System.Collections.Generic.ICollection<JetBrains.ReSharper.UnitTestExplorer.Session.UnitTestElementsUndoUnitBase.UnitTestElementData> ourElementsData;
        protected readonly string ourSessionId;
        protected UnitTestElementsUndoUnitBase(JetBrains.ReSharper.UnitTestFramework.IUnitTestSession session, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.UnitTestFramework.IUnitTestElement> elements) { }
        public abstract void Do(Microsoft.VisualStudio.OLE.Interop.IOleUndoManager pUndoManager);
        public abstract void GetDescription(out string pBstr);
        public void GetUnitType(out System.Guid pClsid, out int plID) { }
        public void OnNextAdd() { }
        protected struct UnitTestElementData
        {
            public string ElementId;
            public string ProjectPersistentId;
        }
    }
    public class UnitTestSession : JetBrains.ReSharper.UnitTestFramework.IUnitTestSession
    {
        public UnitTestSession(JetBrains.DataFlow.Lifetime lifetime, string id, JetBrains.ReSharper.UnitTestFramework.Elements.IUnitTestElementManager unitTestElementManager, JetBrains.ProjectModel.ProjectModelElementPointerManager projectModelElementPointerManager, JetBrains.Application.IShellLocks shellLocks) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.UnitTestFramework.IUnitTestElement> Elements { get; }
        public int ElementsCount { get; }
        public System.Collections.Generic.List<JetBrains.ReSharper.UnitTestFramework.IUnitTestElement> ElementsList { get; }
        public string Id { get; }
        public JetBrains.DataFlow.IProperty<bool> IsIdle { get; }
        public JetBrains.DataFlow.IProperty<JetBrains.ReSharper.UnitTestFramework.IUnitTestLaunch> Launch { get; }
        public JetBrains.DataFlow.Lifetime Lifetime { get; }
        public string Name { get; set; }
        public JetBrains.DataFlow.ISignal<JetBrains.ReSharper.UnitTestFramework.IUnitTestSession> SessionContentsChanged { get; }
        public JetBrains.ReSharper.UnitTestFramework.UnitTestResult SessionResult { get; }
        public void AddElement(JetBrains.ReSharper.UnitTestFramework.IUnitTestElement element) { }
        public void AddElements(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.UnitTestFramework.IUnitTestElement> elements) { }
        public void Append(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.UnitTestFramework.IUnitTestElement> elements) { }
        public bool HasElement(JetBrains.ReSharper.UnitTestFramework.IUnitTestElement element) { }
        public bool IsEmpty() { }
        public void RemoveElements(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.UnitTestFramework.IUnitTestElement> elements) { }
    }
    public abstract class UnitTestSessionManager : JetBrains.ReSharper.UnitTestFramework.IUnitTestSessionManager, System.IDisposable
    {
        protected readonly JetBrains.UI.ToolWindowManagement.TabbedToolWindowClass ToolWindowClass;
        protected UnitTestSessionManager(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ProjectModel.ISolution solution, JetBrains.DataFlow.IViewable<JetBrains.ReSharper.UnitTestExplorer.Session.Preview.IUnitTestPreviewPanelFactory> panelFactories, JetBrains.Application.IShellLocks shellLocks, JetBrains.ReSharper.UnitTestExplorer.UnitTestSessionToolWindowDescriptor unitTestSessionToolWindowDescriptor, JetBrains.UI.ToolWindowManagement.ToolWindowManager toolWindowManager, JetBrains.Application.Settings.ISettingsStore settingsStore, JetBrains.ReSharper.UnitTestFramework.Elements.IUnitTestElementManager unitTestElementManager, JetBrains.ProjectModel.ProjectModelElementPointerManager projectModelElementPointerManager, JetBrains.ReSharper.UnitTestFramework.IUnitTestingSettingsAccessor settingsAccessor, JetBrains.ReSharper.UnitTestFramework.IUnitTestProvidersManager providersManager, JetBrains.UI.TaskBar.ITaskBarManager taskBarManager, JetBrains.UI.Theming.ITheming themeManager, JetBrains.ReSharper.UnitTestFramework.IUnitTestResultManager resultManager, JetBrains.UI.Application.IUIApplication uiApplicationEnvironment) { }
        public JetBrains.ReSharper.UnitTestFramework.IUnitTestSessionView CurrentSession { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.UnitTestExplorer.Session.Preview.IUnitTestPreviewPanelFactory> PreviewPanelFactories { get; }
        public JetBrains.DataFlow.ISignal<JetBrains.ReSharper.UnitTestFramework.IUnitTestSessionView> SessionClosed { get; }
        public JetBrains.DataFlow.ISignal<JetBrains.ReSharper.UnitTestFramework.IUnitTestSessionView> SessionCreated { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.UnitTestFramework.IUnitTestSessionView> Sessions { get; }
        public void ActivateSession(JetBrains.ReSharper.UnitTestFramework.IUnitTestSessionView sessionView) { }
        public JetBrains.ReSharper.UnitTestFramework.IUnitTestSessionView AppendToCurrentOrNewSession(JetBrains.ReSharper.UnitTestFramework.UnitTestElements unitTests, bool focus = True, string name = null) { }
        public void CloseAllSessions() { }
        public void CloseSession(JetBrains.ReSharper.UnitTestFramework.IUnitTestSessionView session) { }
        public JetBrains.ReSharper.UnitTestFramework.IUnitTestSessionView CreateSession(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.UnitTestFramework.IUnitTestElement> elements = null, string name = null, string id = null) { }
        public void Dispose() { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.UnitTestFramework.IUnitTestSessionView GetSession(string id) { }
        public void OpenSession(JetBrains.ReSharper.UnitTestFramework.IUnitTestSessionView session, bool show = True) { }
        public void RunInCurrentOrNewSession(JetBrains.ReSharper.UnitTestFramework.UnitTestElements elements, JetBrains.ReSharper.UnitTestFramework.IHostProvider provider, bool focus = True, string name = null) { }
        public void RunInCurrentOrNewSessionNoBuild(JetBrains.ReSharper.UnitTestFramework.UnitTestElements elements, JetBrains.ReSharper.UnitTestFramework.IHostProvider provider, bool focus = True, string name = null) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class UnitTestSessionSettingsManager
    {
        public UnitTestSessionSettingsManager(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ProjectModel.ISolution solution, JetBrains.Application.IShellLocks shellLocks, JetBrains.ReSharper.UnitTestFramework.Elements.IUnitTestElementManager unitTestElementManager, JetBrains.Application.Settings.ISettingsStore settingsStore, JetBrains.ReSharper.UnitTestFramework.IUnitTestSessionManager sessionManager, JetBrains.Application.ChangeManager changeManager, JetBrains.ReSharper.UnitTestFramework.IUnitTestingSettingsAccessor settingsAccessor) { }
    }
    public class UnitTestSessionView : JetBrains.ReSharper.UnitTestExplorer.UnitTestDescriptorBase, JetBrains.ReSharper.UnitTestFramework.IUnitTestSessionView
    {
        public UnitTestSessionView(JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.UnitTestExplorer.Session.UnitTestSession session, JetBrains.Application.IShellLocks shellLocks, JetBrains.Application.Settings.IContextBoundSettingsStore settingsStore, JetBrains.ReSharper.UnitTestFramework.IUnitTestResultManager resultManager, JetBrains.ReSharper.UnitTestExplorer.Session.UnitTestSessionManager unitTestSessionManager, JetBrains.ReSharper.UnitTestFramework.IUnitTestLaunchManager launchManager, JetBrains.UI.Application.IUIApplication uiApplicationEnvironment) { }
        public override string ActionBarID { get; }
        public JetBrains.ReSharper.UnitTestFramework.IUnitTestElement ActiveElement { get; }
        public JetBrains.ReSharper.UnitTestFramework.BuildPolicy BuildPolicy { get; set; }
        public override string ContextMenuID { get; }
        public JetBrains.ReSharper.TaskRunnerFramework.PlatformVersion FrameworkVersion { get; set; }
        public JetBrains.DataFlow.IProperty<bool> Locked { get; }
        public JetBrains.ReSharper.TaskRunnerFramework.PlatformType PlatformType { get; set; }
        public override string PreviewActionName { get; }
        public JetBrains.ReSharper.UnitTestExplorer.Session.Preview.UnitTestPreviewPane PreviewControl { get; }
        public override JetBrains.IDE.TreeBrowser.PreviewSupport PreviewSupport { get; }
        public JetBrains.ReSharper.UnitTestFramework.IUnitTestSession Session { get; }
        public bool ShowTime { get; set; }
        public bool TrackElements { get; set; }
        public override bool AcceptOccurence(object value) { }
        public void ActivateElement(JetBrains.ReSharper.UnitTestFramework.IUnitTestElement element) { }
        protected override int GetDefaultGroupingIndex(JetBrains.Application.Settings.ISettingsStore store, System.Func<JetBrains.DataFlow.Lifetime, JetBrains.Application.DataContext.DataContexts, JetBrains.Application.DataContext.IDataContext> dataContext) { }
        public JetBrains.ReSharper.UnitTestFramework.UnitTestResult GetModelResult(JetBrains.TreeModels.TreeModelNode node) { }
        public bool IsShownOnlyStatus(JetBrains.ReSharper.UnitTestFramework.UnitTestStatus status) { }
        public bool IsShownStatus(JetBrains.ReSharper.UnitTestFramework.UnitTestStatus status) { }
        public override System.Windows.Forms.Control PreviewCreateControl(JetBrains.UI.WindowManagement.WindowFrame framePreview) { }
        public override void PreviewUpdate(System.Windows.Forms.Control previewControl, JetBrains.TreeModels.TreeModelNode modelNode, ref JetBrains.CommonControls.IPresentableItem previewCaption) { }
        public void Run(JetBrains.ReSharper.UnitTestFramework.UnitTestElements elements, JetBrains.ReSharper.UnitTestFramework.IHostProvider provider, bool build = True, bool focus = True) { }
        public void RunAll(JetBrains.ReSharper.UnitTestFramework.IHostProvider provider) { }
        public void SetActivePreviewPanel<T>()
            where T :  class, JetBrains.ReSharper.UnitTestFramework.IUnitTestPreviewPanel { }
        protected override void SetGroupingIndex(int index) { }
        public void ShowAllStatuses() { }
        public void ShowOnlyStatus(JetBrains.ReSharper.UnitTestFramework.UnitTestStatus status, bool show) { }
        public void ShowStatus(JetBrains.ReSharper.UnitTestFramework.UnitTestStatus status, bool show) { }
        public override void Update(JetBrains.IDE.TreeBrowser.UpdateKind updateKind) { }
        public override bool VisibilityState(JetBrains.TreeModels.TreeModelNode modelNode) { }
    }
    public class UnitTestStatusPanelWPF : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector
    {
        public UnitTestStatusPanelWPF(JetBrains.DataFlow.Lifetime lifetime, JetBrains.UI.Application.IUIApplication environment) { }
        public int TotalCount { set; }
        public void InitializeComponent() { }
        public void SetCounts(int successCount, int failCount, int ignoreCount) { }
        public void SetIndeterminateProgress() { }
        public void SetMessage(string message) { }
        public void UpdateProgress(int completed, int total, JetBrains.ReSharper.UnitTestFramework.UnitTestStatus status) { }
    }
}
namespace JetBrains.ReSharper.UnitTestExplorer.Session.Preview
{
    
    public interface IUnitTestPreviewPanelFactory
    {
        JetBrains.ReSharper.UnitTestExplorer.Session.Preview.UnitTestPreviewPanelBase CreatePanel(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ReSharper.UnitTestFramework.IUnitTestSessionView session);
        bool QueryCloseInstances(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.UnitTestFramework.IUnitTestSessionView> sessions);
    }
    public class UnitTestPreviewPane : JetBrains.CommonControls.TabStripControl
    {
        public UnitTestPreviewPane(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ReSharper.UnitTestExplorer.Session.UnitTestSessionView session, JetBrains.UI.Application.IUIApplication uiApplicationEnvironment, JetBrains.ReSharper.UnitTestExplorer.Session.UnitTestSessionManager unitTestSessionManager) { }
        public void AddPreviewPanel(JetBrains.ReSharper.UnitTestExplorer.Session.Preview.IUnitTestPreviewPanelFactory factory) { }
        public void RemovePreviewPanel(JetBrains.ReSharper.UnitTestExplorer.Session.Preview.IUnitTestPreviewPanelFactory factory) { }
        public void UpdatePanels(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.UnitTestExplorer.Session.Preview.IUnitTestPreviewPanelFactory> factoriesAdded, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.UnitTestExplorer.Session.Preview.IUnitTestPreviewPanelFactory> factoriesRemoved) { }
    }
    public abstract class UnitTestPreviewPanelBase : JetBrains.UI.CommonControls.SafeUserControl, JetBrains.ReSharper.UnitTestFramework.IUnitTestPreviewPanel
    {
        protected UnitTestPreviewPanelBase(JetBrains.ReSharper.UnitTestFramework.IUnitTestSessionView session) { }
        public abstract JetBrains.CommonControls.PresentableItemImage Image { get; }
        protected JetBrains.ReSharper.UnitTestFramework.IUnitTestSessionView Session { get; }
        public abstract string Title { get; }
        public abstract void PreviewUpdate(JetBrains.ReSharper.UnitTestFramework.IUnitTestElement unitTestViewElement, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.UnitTestFramework.IUnitTestElement> unitTestViewElements);
    }
    [JetBrains.Annotations.BaseTypeRequiredAttribute(typeof(JetBrains.ReSharper.UnitTestExplorer.Session.Preview.IUnitTestPreviewPanelFactory))]
    [JetBrains.Annotations.MeansImplicitUseAttribute()]
    public class UnitTestPreviewPanelFactoryAttribute : JetBrains.ProjectModel.SolutionComponentAttribute
    {
        public UnitTestPreviewPanelFactoryAttribute() { }
        public int Order { get; set; }
    }
    public class UnitTestWPFOutputPanel : JetBrains.ReSharper.UnitTestExplorer.Session.Preview.UnitTestPreviewPanelBase
    {
        public UnitTestWPFOutputPanel(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.IShellLocks shellLocks, JetBrains.ReSharper.UnitTestFramework.IUnitTestSessionView session, JetBrains.UI.ActiveText.LinkNavigator linkNavigator, JetBrains.UI.CommonControls.Fonts.FontsManager fontsManager, JetBrains.Application.Settings.IContextBoundSettingsStoreLive contextBoundSettingsStore, JetBrains.UI.Components.Theming.IColorThemeManager themeManager, JetBrains.ReSharper.UnitTestFramework.IUnitTestResultManager resultManager, bool isInternal, JetBrains.ReSharper.Features.Shared.StackTrace.StackTraceManager stackTraceManager) { }
        public override JetBrains.CommonControls.PresentableItemImage Image { get; }
        public override string Title { get; }
        public override void PreviewUpdate(JetBrains.ReSharper.UnitTestFramework.IUnitTestElement unitTestViewElement, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.UnitTestFramework.IUnitTestElement> unitTestViewElements) { }
    }
    [JetBrains.ReSharper.UnitTestExplorer.Session.Preview.UnitTestPreviewPanelFactoryAttribute(Order=0)]
    public class UnitTestWPFOutputPanelFactory : JetBrains.ReSharper.UnitTestExplorer.Session.Preview.IUnitTestPreviewPanelFactory
    {
        public UnitTestWPFOutputPanelFactory(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Settings.ISettingsStore settingsStore, JetBrains.Application.Env.RunsProducts.ProductConfigurations productConfigurations, JetBrains.UI.ActiveText.LinkNavigator linkNavigator, JetBrains.UI.CommonControls.Fonts.FontsManager fontsManager, JetBrains.UI.Components.Theming.IColorThemeManager themeManager, JetBrains.ReSharper.UnitTestFramework.IUnitTestResultManager resultManager, JetBrains.ReSharper.Features.Shared.StackTrace.StackTraceManager stackTraceManager, JetBrains.Application.IShellLocks shellLocks) { }
        public JetBrains.ReSharper.UnitTestExplorer.Session.Preview.UnitTestPreviewPanelBase CreatePanel(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ReSharper.UnitTestFramework.IUnitTestSessionView session) { }
        public bool QueryCloseInstances(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.UnitTestFramework.IUnitTestSessionView> sessions) { }
    }
}
namespace JetBrains.ReSharper.UnitTestExplorer.src.Common
{
    
    [JetBrains.ReSharper.Psi.ShellFeaturePartAttribute()]
    public class UnitTestGroupingProvider : JetBrains.ReSharper.Features.Shared.GroupingManagement.IGroupingProvider<JetBrains.ReSharper.UnitTestFramework.IUnitTestElement>
    {
        public System.Collections.Generic.ICollection<JetBrains.TreeModels.TreeModelGrouping<JetBrains.ReSharper.UnitTestFramework.IUnitTestElement>> GetGroupings(JetBrains.IDE.TreeBrowser.TreeModelBrowserDescriptorBase descriptor) { }
        public bool IsApplicable(JetBrains.IDE.TreeBrowser.TreeModelBrowserDescriptorBase descriptor) { }
        public class CategoriesGroupProvider : JetBrains.TreeModels.ITreeGroupProvider<JetBrains.ReSharper.UnitTestFramework.IUnitTestElement>
        {
            public object ExtractGroupObject(JetBrains.ReSharper.UnitTestFramework.IUnitTestElement item) { }
        }
        public class NamespacesAndUnitTestGroupProvider : JetBrains.TreeModels.ITreeGroupProvider<JetBrains.ReSharper.UnitTestFramework.IUnitTestElement>
        {
            public object ExtractGroupObject(JetBrains.ReSharper.UnitTestFramework.IUnitTestElement item) { }
        }
        public class ProjectGroupProvider : JetBrains.TreeModels.ITreeGroupProvider<JetBrains.ReSharper.UnitTestFramework.IUnitTestElement>
        {
            public ProjectGroupProvider(JetBrains.ReSharper.UnitTestExplorer.GroupingSolutionContext ctx) { }
            public object ExtractGroupObject(JetBrains.ReSharper.UnitTestFramework.IUnitTestElement item) { }
        }
        public class ProjectStructureGroupProvider : JetBrains.TreeModels.ITreeGroupProvider<JetBrains.ReSharper.UnitTestFramework.IUnitTestElement>
        {
            public ProjectStructureGroupProvider(JetBrains.ReSharper.UnitTestExplorer.GroupingSolutionContext ctx) { }
            public object ExtractGroupObject(JetBrains.ReSharper.UnitTestFramework.IUnitTestElement item) { }
        }
        public class UnitTestGroupProvider : JetBrains.TreeModels.ITreeGroupProvider<JetBrains.ReSharper.UnitTestFramework.IUnitTestElement>
        {
            public object ExtractGroupObject(JetBrains.ReSharper.UnitTestFramework.IUnitTestElement item) { }
        }
    }
}