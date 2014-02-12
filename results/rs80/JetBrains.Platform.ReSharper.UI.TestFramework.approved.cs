[assembly: JetBrains.Util.TestDataPathBaseAttribute("Platform\\test\\data")]
[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]

namespace Components
{
    
    [JetBrains.Application.ShellComponentAttribute()]
    public class TestImplUITaskExecutorSwitchingImplementation : JetBrains.UI.Application.Progress.UITaskExecutorSwitchingImplementation
    {
        public TestImplUITaskExecutorSwitchingImplementation([JetBrains.Annotations.NotNullAttribute()] JetBrains.Threading.IThreading invocator, JetBrains.Application.Interop.NativeHook.IWindowsHookManager windowsHookManager, JetBrains.UI.Application.Progress.WorkerThreadShop workerThreadShop, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.UI.Application.IMainWindow mainwin, JetBrains.UI.Application.IUIApplicationSimple uiApplicationSimple) { }
        public override JetBrains.Application.Progress.ITaskExecutor CreateExecutor(JetBrains.UI.Application.Progress.TaskThreadAffinity threading, System.Windows.Forms.IWin32Window mainWindow = null) { }
    }
}
namespace JetBrains.ActionManagement
{
    
    [JetBrains.Application.ShellComponentAttribute()]
    public class TestActionManager : JetBrains.ActionManagement.ActionManager
    {
        public TestActionManager(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.Env.RunsProducts.ProductConfigurations productConfigurations, JetBrains.Application.DataContext.DataContexts dataContexts, JetBrains.Application.IShellLocks shellLocks, JetBrains.Application.ActivityTrackingNew.IActivityTracking activityTracking) { }
        public bool ProcessTypesLoading { get; set; }
        public override string GetLocationInMainMenu(JetBrains.ActionManagement.IExecutableAction action) { }
    }
}
namespace JetBrains.Platform.TestUI.Components
{
    
    [JetBrains.Application.ShellComponentAttribute()]
    public class TestFrameFocusHelper : JetBrains.UI.WindowManagement.IFrameFocusHelper
    {
        public void KeepCurrentFrame(System.Action nested) { }
    }
    [JetBrains.Application.Env.EnvironmentComponentAttribute(JetBrains.Application.Sharing.Product)]
    public class TestImplLicenseCheckComponent : JetBrains.UI.Application.LicenseCheckComponent
    {
        public TestImplLicenseCheckComponent([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, JetBrains.UI.Application.LicenseCheckerComponent licenseChecker) { }
        protected override JetBrains.DataFlow.IProperty<JetBrains.Application.Env.ProductCanBeStartedVerdict> CreateCanBeStartedCore(JetBrains.DataFlow.Lifetime lifetime) { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class TestImplUpdatesManager : JetBrains.UI.Updates.UpdatesManager
    {
        public TestImplUpdatesManager(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Threading.IThreading threading, JetBrains.UI.Updates.UpdatesLocalInfoManager updatesLocalInfoManager, JetBrains.Application.IApplicationDescriptor applicationDescriptor, JetBrains.Application.Env.Components.ProductSettingsLocation productSettingsLocation, JetBrains.Application.Settings.ISettingsStore settingsStore, JetBrains.Application.Communication.WebProxySettingsReader webProxySettingsReader) { }
        protected override void Init(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.IApplicationDescriptor applicationDescriptor, JetBrains.Application.Env.Components.ProductSettingsLocation settingsLocation, JetBrains.Application.Settings.ISettingsStore settingsStore, JetBrains.Application.Communication.WebProxySettingsReader webProxySettingsReader) { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class TestImplUserActivityMonitor : JetBrains.UI.Components.UserActivityMonitor
    {
        public TestImplUserActivityMonitor(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Threading.IThreading invocator, JetBrains.UI.Application.IIsApplicationActiveState appactive) { }
        protected override void Init(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Threading.IThreading invocator, JetBrains.UI.Application.IIsApplicationActiveState appactive) { }
    }
    [JetBrains.Application.Env.EnvironmentComponentAttribute(JetBrains.Application.Sharing.Product)]
    public class TestTimeBombComponent : JetBrains.UI.License.UITimeBombComponent
    {
        public TestTimeBombComponent([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, JetBrains.Util.Lazy.Lazy<JetBrains.UI.Application.IMainWindow> mainWindow, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Threading.IThreading invocator, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.IApplicationDescriptor applicationDescriptor, JetBrains.UI.Application.OpensUri opensUri) { }
        protected override JetBrains.DataFlow.IProperty<JetBrains.Application.Env.ProductCanBeStartedVerdict> CreateCanBeStartedCore(JetBrains.DataFlow.Lifetime lifetime) { }
    }
}
namespace JetBrains.Platform.TestUI.ToolWindowManagement
{
    
    public class TestToolWindowFrame : JetBrains.UI.ToolWindowManagement.TopLevelToolWindowFrameBase
    {
        public TestToolWindowFrame(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.IShellLocks locks) { }
        public override void Close() { }
        public override void Show(bool activate = True) { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class TestTopLevelToolWindowFrameFactory : JetBrains.UI.ToolWindowManagement.TopLevelToolWindowFrameFactory
    {
        public TestTopLevelToolWindowFrameFactory(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.IShellLocks locks) { }
        public override JetBrains.UI.ToolWindowManagement.TopLevelToolWindowFrameBase CreateTopLevelFrame(JetBrains.DataFlow.Lifetime lifetime, JetBrains.UI.ToolWindowManagement.ToolWindowDescriptor toolWindowDescriptor) { }
        public override bool IsFrameRequired(JetBrains.UI.ToolWindowManagement.ToolWindowDescriptor toolWindowDescriptor) { }
    }
}
namespace JetBrains.Platform.TestUtil.Components
{
    
    [JetBrains.Application.ShellComponentAttribute()]
    public class TestImplTooltipManagerComponent : JetBrains.UI.Tooltips.TooltipManagerComponent
    {
        public static readonly JetBrains.DataFlow.ISignal<JetBrains.CommonControls.IWindowlessControl> TooltipShown;
        public TestImplTooltipManagerComponent(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Threading.IThreading threading, JetBrains.UI.Application.IMainWindow mainwin, JetBrains.UI.Application.IIsApplicationActiveState isApplicationActiveState, JetBrains.UI.PopupWindowManager.PopupWindowManager popupWindowManager, JetBrains.UI.PopupWindowManager.MainWindowPopupWindowContext mainWindowPopupWindowContext, JetBrains.DataFlow.IViewable<JetBrains.UI.Tooltips.IFindTooltipElementsAtCursor> finders, JetBrains.UI.Theming.ITheming theming, JetBrains.UI.Application.IUIApplication environment, JetBrains.Application.Interop.NativeHook.IWindowsHookManager hookman) { }
        protected override void Init() { }
        protected override JetBrains.UI.PopupWindowManager.IPopupWindow ShowCore(JetBrains.DataFlow.LifetimeDefinition lifetimeDefinition, JetBrains.CommonControls.IWindowlessControl painter, JetBrains.UI.PopupWindowManager.IPopupWindowContext context, JetBrains.UI.PopupWindowManager.HideFlags hideflags, System.TimeSpan timeout) { }
    }
}
namespace JetBrains.TestFramework.UI
{
    
    [JetBrains.Application.Env.EnvironmentComponentAttribute(JetBrains.Application.Sharing.Product)]
    public class TestImplLicenseCheckerComponent : JetBrains.UI.Application.LicenseCheckerComponent
    {
        public TestImplLicenseCheckerComponent([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime componentLifetime, JetBrains.Application.IApplicationDescriptor applicationDescriptor, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Env.Components.ProductSettingsLocation productSettingsLocation, [JetBrains.Annotations.NotNullAttribute()] JetBrains.UI.License.LicenseSettingsLocation licenseSettingsLocation, [JetBrains.Annotations.NotNullAttribute()] JetBrains.UI.Application.OpensUri opensUri, [JetBrains.Annotations.NotNullAttribute()] JetBrains.UI.Application.HelpSystem helpSystem, JetBrains.Threading.IThreading threading) { }
        protected override JetBrains.UI.Application.License.LicenseInformation GetLicenseInformation() { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class TestImplThemeManager : JetBrains.UI.Components.Theming.ThemeManager
    {
        public TestImplThemeManager(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Threading.IThreading threading, JetBrains.DataFlow.IViewable<JetBrains.UI.Components.Theming.IThemeColorFiller> fillers) { }
        protected override JetBrains.UI.Components.Theming.ColorTheme CreateTheme() { }
    }
    [JetBrains.Application.ShellComponentAttribute(JetBrains.Application.Sharing.Common, JetBrains.Application.Lifecycle.Deferred, JetBrains.Application.Creation.PrimaryThread, JetBrains.Application.Access.None)]
    public class TestMemoryUsageIndicator : JetBrains.UI.StatusBar.Indicators.MemoryUsageIndicator
    {
        public TestMemoryUsageIndicator([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Threading.IThreading invocator, JetBrains.UI.Application.IIsApplicationActiveState appactive, JetBrains.Util.Lazy.Lazy<JetBrains.UI.Tooltips.ITooltipManager> tooltips, JetBrains.Application.Settings.ISettingsStore settingsStore, JetBrains.Application.Env.RunsProducts.ProductConfigurations productConfigurations, JetBrains.Application.Interop.NativeHook.IWindowsHookManager windowsHookManager, JetBrains.UI.PopupWindowManager.MainWindowPopupWindowContext mainWindowPopupWindowContext, [JetBrains.Annotations.NotNullAttribute()] JetBrains.UI.Components.Theming.IStatusBarColorsManager thememan, JetBrains.UI.Application.IUIApplication environment) { }
    }
}
namespace JetBrains.UI.ActionSystem.ShortcutManager
{
    
    [JetBrains.Application.ShellComponentAttribute()]
    public class TestShortcutManager : JetBrains.UI.ActionSystem.ShortcutManager.ShortcutManagerBase<JetBrains.UI.ActionSystem.ShortcutManager.SchemeEntry>
    {
        public TestShortcutManager(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ActionManagement.IActionManager actionManager) { }
        protected override JetBrains.UI.ActionSystem.ShortcutManager.SchemeEntry CreateSchemeEntry(JetBrains.ActionManagement.ShortcutScheme scheme) { }
    }
}