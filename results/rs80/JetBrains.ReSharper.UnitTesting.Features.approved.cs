[assembly: JetBrains.ActionManagement.ActionsXmlAttribute("JetBrains.ReSharper.UnitTesting.Features.resources.Actions.xml")]
[assembly: JetBrains.Application.Install.InstallBindingRedirectionsConfigFileAttribute("JetBrains.ReSharper.TaskRunner.CLR4.x64.exe.config", JetBrains.Application.Install.InstallationData.InstallationSourceDirRoot2.ProductBinariesDir, "JetBrains.ReSharper.TaskRunner.CLR4.x64.exe.config")]
[assembly: JetBrains.Application.Install.InstallBindingRedirectionsConfigFileAttribute("JetBrains.ReSharper.TaskRunner.CLR4.MSIL.exe.config", JetBrains.Application.Install.InstallationData.InstallationSourceDirRoot2.ProductBinariesDir, "JetBrains.ReSharper.TaskRunner.CLR4.MSIL.exe.config")]
[assembly: JetBrains.Application.Install.InstallBindingRedirectionsConfigFileAttribute("JetBrains.ReSharper.TaskRunner.CLR4.exe.config", JetBrains.Application.Install.InstallationData.InstallationSourceDirRoot2.ProductBinariesDir, "JetBrains.ReSharper.TaskRunner.CLR4.exe.config")]
[assembly: JetBrains.Application.Install.InstallBindingRedirectionsConfigFileAttribute("JetBrains.ReSharper.TaskRunner.exe.config", JetBrains.Application.Install.InstallationData.InstallationSourceDirRoot2.ProductBinariesDir, "JetBrains.ReSharper.TaskRunner.exe.config")]
[assembly: JetBrains.Application.Install.InstallBindingRedirectionsConfigFileAttribute("JetBrains.ReSharper.TaskRunner.MSIL.exe.config", JetBrains.Application.Install.InstallationData.InstallationSourceDirRoot2.ProductBinariesDir, "JetBrains.ReSharper.TaskRunner.MSIL.exe.config")]
[assembly: JetBrains.Application.Install.InstallBindingRedirectionsConfigFileAttribute("JetBrains.ReSharper.TaskRunner.x64.exe.config", JetBrains.Application.Install.InstallationData.InstallationSourceDirRoot2.ProductBinariesDir, "JetBrains.ReSharper.TaskRunner.x64.exe.config")]
[assembly: JetBrains.UI.Icons.CompiledIcons.CompiledIconsPackAttribute(IconNames=new string[] {
        "UnitTestingOptionsPage",
        "UnitTestRunner",
        "UnitSession"}, IconPackResourceIdentification="JetBrains.ReSharper.UnitTesting.Features;component/resources/UnitTestingFeatureIc" +
    "ons/ThemedIcons.UnitTestingFeature.Generated.Xaml")]
[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]
[assembly: System.Windows.Markup.XmlnsDefinitionAttribute("urn:shemas-jetbrains-com:ui-application-icons-unit-testing-feature", "JetBrains.ReSharper.UnitTesting.Features.Resources")]

namespace JetBrains.ReSharper.UnitTestExplorer.OccurenceKinds
{
    
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class UnitTestOccurenceKindProvider : JetBrains.ReSharper.Feature.Services.Occurences.OccurenceKindProviders.IOccurenceKindProvider
    {
        public UnitTestOccurenceKindProvider(JetBrains.ReSharper.UnitTestFramework.UnitTestManager manager) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.Occurences.OccurenceKindProviders.OccurenceKind> GetAllPossibleOccurenceKinds() { }
        public System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.Occurences.OccurenceKindProviders.OccurenceKind> GetOccurenceKinds(JetBrains.ReSharper.Feature.Services.Search.IOccurence occurence) { }
    }
}
namespace JetBrains.ReSharper.UnitTesting.Features.Actions
{
    
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "UnitTestSession.AppendTests"})]
    public class AppendTestsAction : JetBrains.ReSharper.UnitTestExplorer.Session.Actions.AppendTestsActionBase { }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "UnitTestSession.NewSession"})]
    public class NewSessionAction : JetBrains.ReSharper.UnitTestExplorer.Session.Actions.NewSessionActionBase { }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "UnitTestSession.RepeatPreviousRun"})]
    public class RepeatPreviousRunAction : JetBrains.ReSharper.UnitTestExplorer.Session.Actions.RepeatPreviousRunActionBase { }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "UnitTestSession.Filter.ShowAll"})]
    public class ShowAllAccessAction : JetBrains.ReSharper.UnitTestExplorer.ShowAllAccessActionBase { }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "UnitTestSession.Filter.ShowFailed"})]
    public class ShowFailedStatusAction : JetBrains.ReSharper.UnitTestExplorer.ShowFailedStatusActionBase { }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "UnitTestSession.Filter.ShowIgnored"})]
    public class ShowIgnoredStatusAction : JetBrains.ReSharper.UnitTestExplorer.ShowIgnoredStatusActionBase { }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "UnitTestSession.Filter.ShowOnlyFailed"})]
    public class ShowOnlyFailedStatusAction : JetBrains.ReSharper.UnitTestExplorer.ShowOnlyFailedStatusActionBase { }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "UnitTestSession.Filter.ShowOnlyIgnored"})]
    public class ShowOnlyIgnoredStatusAction : JetBrains.ReSharper.UnitTestExplorer.ShowOnlyIgnoredStatusActionBase { }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "UnitTestSession.Filter.ShowSuccess"})]
    public class ShowSuccessStatusAction : JetBrains.ReSharper.UnitTestExplorer.ShowSuccessStatusActionBase { }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "UnitTestSession.TrackRunningTest"})]
    public class TrackRunningTestAction : JetBrains.ReSharper.UnitTestExplorer.TrackRunningTestActionBase { }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "UnitTestExplorer.Refresh"})]
    public class UnitTestBrowserRefreshAction : JetBrains.ReSharper.UnitTestExplorer.UnitTestBrowserRefreshActionBase { }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "ReSharper_UnitTest_DebugContext"})]
    public class UnitTestDebugContextAction : JetBrains.ReSharper.UnitTestExplorer.UnitTestDebugContextActionBase { }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "UnitTest.ContextMenu.HostProvider1"})]
    public class UnitTestExplorerContextRunAction1 : JetBrains.ReSharper.UnitTestExplorer.UnitTestExplorerContextRunAction1Base { }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "UnitTest.ContextMenu.HostProvider2"})]
    public class UnitTestExplorerContextRunAction2 : JetBrains.ReSharper.UnitTestExplorer.UnitTestExplorerContextRunAction2Base { }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "UnitTest.ContextMenu.HostProvider3"})]
    public class UnitTestExplorerContextRunAction3 : JetBrains.ReSharper.UnitTestExplorer.UnitTestExplorerContextRunAction3Base { }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "UnitTest.ContextMenu.HostProvider4"})]
    public class UnitTestExplorerContextRunAction4 : JetBrains.ReSharper.UnitTestExplorer.UnitTestExplorerContextRunAction4Base { }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "UnitTest.ContextMenu.HostProvider5"})]
    public class UnitTestExplorerContextRunAction5 : JetBrains.ReSharper.UnitTestExplorer.UnitTestExplorerContextRunAction5Base { }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "UnitTest.RunCurrentSession"})]
    public class UnitTestExplorerRunCurrentSessionAction : JetBrains.ReSharper.UnitTestExplorer.UnitTestExplorerRunCurrentSessionActionBase { }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "UnitTest.RunSolution1"})]
    public class UnitTestExplorerRunSolution1Action : JetBrains.ReSharper.UnitTestExplorer.Actions.UnitTestExplorerRunSolution1ActionBase { }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "UnitTest.RunSolution2"})]
    public class UnitTestExplorerRunSolution2Action : JetBrains.ReSharper.UnitTestExplorer.Actions.UnitTestExplorerRunSolution2ActionBase { }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "UnitTest.RunSolution3"})]
    public class UnitTestExplorerRunSolution3Action : JetBrains.ReSharper.UnitTestExplorer.Actions.UnitTestExplorerRunSolution3ActionBase { }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "UnitTest.RunSolution4"})]
    public class UnitTestExplorerRunSolution4Action : JetBrains.ReSharper.UnitTestExplorer.Actions.UnitTestExplorerRunSolution4ActionBase { }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "UnitTest.RunSolution5"})]
    public class UnitTestExplorerRunSolution5Action : JetBrains.ReSharper.UnitTestExplorer.Actions.UnitTestExplorerRunSolution5ActionBase { }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "UnitTest.RunSolution"})]
    public class UnitTestExplorerRunSolutionAction : JetBrains.ReSharper.UnitTestExplorer.Actions.UnitTestExplorerRunSolutionActionBase { }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "ReSharper_UnitTest_RunContext"})]
    public class UnitTestRunContextAction : JetBrains.ReSharper.UnitTestExplorer.UnitTestRunContextActionBase { }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "UnitTestSession.Abort"})]
    public class UnitTestSessionAbortAction : JetBrains.ReSharper.UnitTestExplorer.UnitTestSessionAbortActionBase { }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "UnitTestSession.AppendChildren"})]
    public class UnitTestSessionAppendChildren : JetBrains.ReSharper.UnitTestExplorer.Session.Actions.UnitTestSessionAppendChildrenBase { }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "UnitTestSession.BuildPolicy.Always"})]
    public class UnitTestSessionBuildPolicyAlways : JetBrains.ReSharper.UnitTestExplorer.UnitTestSessionBuildPolicyAlwaysBase { }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "UnitTestSession.BuildPolicy.Automatic"})]
    public class UnitTestSessionBuildPolicyAutomatic : JetBrains.ReSharper.UnitTestExplorer.UnitTestSessionBuildPolicyAutomaticBase { }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "UnitTestSession.BuildPolicy.Never"})]
    public class UnitTestSessionBuildPolicyNever : JetBrains.ReSharper.UnitTestExplorer.UnitTestSessionBuildPolicyNeverBase { }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "UnitTestSession.BuildPolicy.WholeSolution"})]
    public class UnitTestSessionBuildPolicyWholeSolution : JetBrains.ReSharper.UnitTestExplorer.UnitTestSessionBuildPolicyWholeSolutionBase { }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "UnitTestSession.Lock"})]
    public class UnitTestSessionLockAction : JetBrains.ReSharper.UnitTestExplorer.UnitTestSessionLockActionBase { }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "UnitTestSession.RemoveSelectedNodes"})]
    public class UnitTestSessionRemoveSelectedNodes : JetBrains.ReSharper.UnitTestExplorer.Actions.UnitTestSessionRemoveSelectedNodesBase { }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "UnitTestSession.Rename"})]
    public class UnitTestSessionRenameAction : JetBrains.ReSharper.UnitTestExplorer.Session.Actions.UnitTestSessionRenameActionBase { }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "UnitTestSession.RunAllAction1"})]
    public class UnitTestSessionRunAll1Action : JetBrains.ReSharper.UnitTestExplorer.UnitTestSessionRunAll1ActionBase { }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "UnitTestSession.RunAllAction2"})]
    public class UnitTestSessionRunAll2Action : JetBrains.ReSharper.UnitTestExplorer.UnitTestSessionRunAll2ActionBase { }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "UnitTestSession.RunAllAction3"})]
    public class UnitTestSessionRunAll3Action : JetBrains.ReSharper.UnitTestExplorer.UnitTestSessionRunAll3ActionBase { }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "UnitTestSession.RunAllAction4"})]
    public class UnitTestSessionRunAll4Action : JetBrains.ReSharper.UnitTestExplorer.UnitTestSessionRunAll4ActionBase { }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "UnitTestSession.RunAllAction5"})]
    public class UnitTestSessionRunAll5Action : JetBrains.ReSharper.UnitTestExplorer.UnitTestSessionRunAll5ActionBase { }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "UnitTestSession.RunAllTestsInSession"})]
    public class UnitTestSessionRunAllTestsInSessionAction : JetBrains.ReSharper.UnitTestExplorer.UnitTestSessionRunAllTestsInSessionActionBase { }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "UnitTestSession.TargetFramework.CLR2"})]
    public class UnitTestSessionTargetFrameworkClr2 : JetBrains.ReSharper.UnitTestExplorer.Session.Actions.UnitTestSessionTargetFrameworkClr2Base { }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "UnitTestSession.TargetFramework.CLR4"})]
    public class UnitTestSessionTargetFrameworkClr4 : JetBrains.ReSharper.UnitTestExplorer.Session.Actions.UnitTestSessionTargetFrameworkClr4Base { }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "UnitTestSession.TargetFramework.Default"})]
    public class UnitTestSessionTargetFrameworkDefault : JetBrains.ReSharper.UnitTestExplorer.Session.Actions.UnitTestSessionTargetFrameworkDefaultBase { }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "UnitTestSession.TargetFramework"})]
    public class UnitTestSessionTargetFrameworkGroup : JetBrains.ReSharper.UnitTestExplorer.Session.Actions.UnitTestSessionTargetFrameworkGroupBase { }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "UnitTestSession.TargetPlatform.Default"})]
    public class UnitTestSessionTargetPlatformDefault : JetBrains.ReSharper.UnitTestExplorer.UnitTestSessionTargetPlatformDefaultBase { }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "UnitTestSession.TargetPlatform"})]
    public class UnitTestSessionTargetPlatformGroup : JetBrains.ReSharper.UnitTestExplorer.UnitTestSessionTargetPlatformGroupBase { }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "UnitTestSession.TargetPlatform.MSIL"})]
    public class UnitTestSessionTargetPlatformMSIL : JetBrains.ReSharper.UnitTestExplorer.UnitTestSessionTargetPlatformMSILBase { }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "UnitTestSession.TargetPlatform.x64"})]
    public class UnitTestSessionTargetPlatformX64 : JetBrains.ReSharper.UnitTestExplorer.UnitTestSessionTargetPlatformX64Base { }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "UnitTestSession.TargetPlatform.x86"})]
    public class UnitTestSessionTargetPlatformX86 : JetBrains.ReSharper.UnitTestExplorer.UnitTestSessionTargetPlatformX86Base { }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "UnitTestSession.Time"})]
    public class UnitTestSessionTimeAction : JetBrains.ReSharper.UnitTestExplorer.UnitTestSessionTimeActionBase { }
}
namespace JetBrains.ReSharper.UnitTesting.Features.Options
{
    
    [JetBrains.UI.Options.OptionsPageAttribute("UnitTesting", "Unit Testing", typeof(JetBrains.ReSharper.UnitTesting.Features.Resources.UnitTestingFeatureThemedIcons.UnitTestingOptionsPage), HelpKeyword="Reference__Options__Tools__Unit_Testing", ParentId="Tools", Sequence=1D)]
    public class UnitTestingPage : JetBrains.ReSharper.UnitTestExplorer.Options.UnitTestingPageBase
    {
        public UnitTestingPage(JetBrains.UI.Options.OptionsSettingsSmartContext smartContext, JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.Env.RunsProducts.ProductConfigurations productConfiguraions, System.Windows.Forms.IWin32Window mainWindow, JetBrains.UI.Application.IUIApplication uiApplicationEnvironment) { }
    }
}
namespace JetBrains.ReSharper.UnitTesting.Features
{
    
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class ReSharperUnitTestSessionManager : JetBrains.ReSharper.UnitTestExplorer.Session.UnitTestSessionManager
    {
        public ReSharperUnitTestSessionManager(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ProjectModel.ISolution solution, JetBrains.DataFlow.IViewable<JetBrains.ReSharper.UnitTestExplorer.Session.Preview.IUnitTestPreviewPanelFactory> panelFactories, JetBrains.Application.IShellLocks shellLocks, JetBrains.ReSharper.UnitTestExplorer.UnitTestSessionToolWindowDescriptor unitTestSessionToolWindowDescriptor, JetBrains.UI.ToolWindowManagement.ToolWindowManager toolWindowManager, JetBrains.Application.Settings.ISettingsStore settingsStore, JetBrains.ReSharper.UnitTestFramework.Elements.IUnitTestElementManager unitTestElementManager, JetBrains.ProjectModel.ProjectModelElementPointerManager projectModelElementPointerManager, JetBrains.ReSharper.UnitTestFramework.IUnitTestingSettingsAccessor settingsAccessor, JetBrains.ReSharper.UnitTestFramework.IUnitTestProvidersManager providersManager, JetBrains.UI.TaskBar.ITaskBarManager taskBarManager, JetBrains.UI.Theming.ITheming themeManager, JetBrains.ReSharper.UnitTestFramework.IUnitTestResultManager resultManager, JetBrains.UI.Application.IUIApplication uiApplicationEnvironment) { }
    }
}
namespace JetBrains.ReSharper.UnitTesting.Features.Resources
{
    
    public sealed class UnitTestingFeatureThemedIcons
    {
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.UnitTesting.Features;component/resources/UnitTestingFeatureIc" +
            "ons/ThemedIcons.UnitTestingFeature.Generated.Xaml", 2, "UnitSession")]
        public sealed class UnitSession : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.UnitTesting.Features;component/resources/UnitTestingFeatureIc" +
            "ons/ThemedIcons.UnitTestingFeature.Generated.Xaml", 0, "UnitTestingOptionsPage")]
        public sealed class UnitTestingOptionsPage : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.UnitTesting.Features;component/resources/UnitTestingFeatureIc" +
            "ons/ThemedIcons.UnitTestingFeature.Generated.Xaml", 1, "UnitTestRunner")]
        public sealed class UnitTestRunner : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
    }
}
namespace JetBrains.ReSharper.UnitTesting.Features.ToolWindow
{
    
    [JetBrains.UI.ToolWindowManagement.ToolWindowDescriptorAttribute(Icon=typeof(JetBrains.ReSharper.UnitTesting.Features.Resources.UnitTestingFeatureThemedIcons.UnitTestRunner), ProductNeutralId="UnitTestExplorerWindow", Text="Unit Test Explorer", Type=JetBrains.UI.ToolWindowManagement.ToolWindowType.SingleInstance, VisibilityPersistenceScope=JetBrains.UI.ToolWindowManagement.ToolWindowVisibilityPersistenceScope.Solution)]
    public class ReSharperUnitTestExplorerToolWindowDescriptor : JetBrains.ReSharper.UnitTestExplorer.UnitTestExplorerToolWindowDescriptor
    {
        public ReSharperUnitTestExplorerToolWindowDescriptor(JetBrains.Application.IApplicationDescriptor applicationDescriptor) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class ReSharperUnitTestExplorerToolWindowService : JetBrains.ReSharper.UnitTestExplorer.UnitTestExplorerToolWindowServiceBase
    {
        public ReSharperUnitTestExplorerToolWindowService(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.UnitTestFramework.Elements.IUnitTestElementManager manager, JetBrains.UI.ToolWindowManagement.ToolWindowManager toolWindowManager, JetBrains.ReSharper.UnitTestExplorer.UnitTestExplorerToolWindowDescriptor unitTestExplorerToolWindowDescriptor, JetBrains.Application.Env.RunsProducts.ProductConfigurations productConfigurations, JetBrains.Application.Settings.ISettingsStore settingsStore, JetBrains.UI.Theming.ITheming themeManager, JetBrains.UI.Application.IUIApplication environment) { }
    }
    [JetBrains.UI.ToolWindowManagement.ToolWindowDescriptorAttribute(ContextMenuActionGroupId="UnitTestSession.TabContextMenu", Icon=typeof(JetBrains.ReSharper.UnitTesting.Features.Resources.UnitTestingFeatureThemedIcons.UnitSession), InstancePresentableName="session", MultiInstanceTabRenameAllowed=true, MultiInstanceTabRenameDuplicateNamesNotAllowed=true, ProductNeutralId="UnitTestSessionsWindow", Text="Unit Test Sessions", Type=JetBrains.UI.ToolWindowManagement.ToolWindowType.MultiInstance, VisibilityPersistenceScope=JetBrains.UI.ToolWindowManagement.ToolWindowVisibilityPersistenceScope.Global)]
    public class ReSharperUnitTestSessionToolWindowDescriptor : JetBrains.ReSharper.UnitTestExplorer.UnitTestSessionToolWindowDescriptor
    {
        public ReSharperUnitTestSessionToolWindowDescriptor(JetBrains.Application.IApplicationDescriptor applicationDescriptor) { }
    }
}