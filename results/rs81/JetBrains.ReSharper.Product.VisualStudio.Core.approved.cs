[assembly: JetBrains.Application.ApplicationDescriptorAttribute(typeof(JetBrains.ReSharper.ReSharperApplicationDescriptor))]
[assembly: JetBrains.UI.Icons.CompiledIcons.CompiledIconsPackAttribute(IconNames=new string[] {
        "ProductUsagePage",
        "VsOptionsPage"}, IconPackResourceIdentification="JetBrains.ReSharper.Product.VisualStudio.Core;component/Resources/ReSharperVisual" +
    "StudioCoreThemedIcons/ThemedIcons.ReSharperVisualStudioCore.Generated.Xaml")]
[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]
[assembly: System.Windows.Markup.XmlnsDefinitionAttribute("urn:shemas-jetbrains-com:ui-application-icons-re-sharper-visual-studio-core", "JetBrains.ReSharper.Product.VisualStudio.Core.Resources")]

namespace JetBrains.ReSharper.Product.VisualStudio.Core.ActivityTracking
{
    
    [JetBrains.Application.ShellComponentAttribute()]
    public class VsActivityTrackingStatisticsProvider : JetBrains.Application.ActivityTrackingNew.IActivityTrackingStatisticsProvider
    {
        public VsActivityTrackingStatisticsProvider(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.ActivityTrackingNew.ActivityTrackingSettings settings, JetBrains.VsIntegration.Application.IVsEnvironmentInformation vsEnvironmentInformation, JetBrains.UI.Application.ILicenseCheckerComponent licenseCheckerComponent, JetBrains.UI.Application.IUIApplication environment, JetBrains.UI.Application.UIApplication uiApplication, JetBrains.Application.DataContext.DataContexts dataContexts, JetBrains.VsIntegration.ActionManagement.VsActionManagerSettingsStorage vsActionManagerSettingsStorage) { }
        public void GetActivityStatistics(JetBrains.ActivityTracking.ActivityLog log) { }
        protected virtual void ShowBalloon() { }
    }
}
namespace JetBrains.ReSharper.Product.VisualStudio.Core.Customization
{
    
    [JetBrains.Application.Env.EnvironmentComponentAttribute(JetBrains.Application.Sharing.Product)]
    public class ChooseVsKeyboardScheme
    {
        public ChooseVsKeyboardScheme([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.IApplicationDescriptor product) { }
    }
    public class VsExtensionClipartReSharper : JetBrains.VsIntegration.Install.VsPackageAssembly.IVsExtensionClipart { }
}
namespace JetBrains.ReSharper.Product.VisualStudio.Core.OptionPages
{
    
    [JetBrains.UI.Options.OptionsPageAttribute("VisualStudioIntegration", "Keyboard & Menus", typeof(JetBrains.ReSharper.Product.VisualStudio.Core.Resources.ReSharperVisualStudioCoreThemedIcons.VsOptionsPage), HelpKeyword="Reference__Options__Environment__Visual_Studio_Integration", ParentId="Environment", Sequence=0.5D)]
    public class VisualStudioIntegrationPage : JetBrains.UI.Options.Helpers.AOptionsPage
    {
        public const string PID = "VisualStudioIntegration";
        public VisualStudioIntegrationPage(JetBrains.DataFlow.Lifetime lifetime, JetBrains.UI.Application.IUIApplication environment, JetBrains.UI.Application.Progress.UITaskExecutor uiTaskExecutor, JetBrains.ActionManagement.IShortcutManager shortcutManager, JetBrains.UI.Options.OptionsSettingsSmartContext settings, JetBrains.VsIntegration.ActionManagement.VsActionManagerSettingsStorage vsActionManagerSettingsStorage, JetBrains.Application.IApplicationDescriptor product) { }
        public override bool OnOk() { }
    }
}
namespace JetBrains.ReSharper.Product.VisualStudio.Core.ReSharperMisbehaves
{
    
    [JetBrains.Application.ShellComponentAttribute()]
    public class VsAdvertiseSubmitFeedbackComponent
    {
        public VsAdvertiseSubmitFeedbackComponent(JetBrains.VsIntegration.ActionManagement.VsActionManager actionManager, JetBrains.DataFlow.Lifetime lifetime, EnvDTE.DTE dte, JetBrains.UI.Application.IUIApplication environment, JetBrains.UI.Application.IMainWindow mainWindow, JetBrains.Application.Settings.ISettingsStore settingsStore) { }
        public bool DoNotShow { get; set; }
    }
    [JetBrains.Application.Settings.SettingsKeyAttribute(typeof(JetBrains.Application.Settings.HousekeepingSettings), "VsAdvertiseSubmitFeedbackComponentSettingsKey")]
    public class VsAdvertiseSubmitFeedbackComponentSettingsKey
    {
        [JetBrains.Application.Settings.SettingsEntryAttribute(false, "Do not show")]
        public bool DoNotShow;
    }
}
namespace JetBrains.ReSharper.Product.VisualStudio.Core.Resources
{
    
    public sealed class ReSharperVisualStudioCoreThemedIcons
    {
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Product.VisualStudio.Core;component/Resources/ReSharperVisual" +
            "StudioCoreThemedIcons/ThemedIcons.ReSharperVisualStudioCore.Generated.Xaml", 0, "ProductUsagePage")]
        public sealed class ProductUsagePage : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Product.VisualStudio.Core;component/Resources/ReSharperVisual" +
            "StudioCoreThemedIcons/ThemedIcons.ReSharperVisualStudioCore.Generated.Xaml", 1, "VsOptionsPage")]
        public sealed class VsOptionsPage : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
    }
}
namespace JetBrains.ReSharper.Product.VisualStudio.Core.SolutionWatchdog
{
    
    [JetBrains.Application.Settings.SettingsKeyAttribute(typeof(System.Reflection.Missing), "Solution watchdog settings")]
    public class SolutionWatchdogSettingsKey
    {
        [JetBrains.Application.Settings.SettingsEntryAttribute(true, "Is solution watchdog enabled")]
        public bool IsEnabled;
    }
}
namespace JetBrains.ReSharper.VSI.Components
{
    
    public class static SolutionWatchdog
    {
        [JetBrains.ProjectModel.SolutionComponentAttribute()]
        public class SolCompo : System.IDisposable
        {
            public SolCompo([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.ISolution solution, JetBrains.DataFlow.Lifetime lt) { }
        }
    }
}