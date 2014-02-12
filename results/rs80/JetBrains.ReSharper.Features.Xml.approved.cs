[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]

namespace JetBrains.ReSharper.Features.Xml.Navigation
{
    
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "GotoDataContext"})]
    public class GotoBindingDataContextAction : JetBrains.ReSharper.Features.Finding.NavigateFromHere.ContextNavigationActionBase<JetBrains.ReSharper.Features.Xml.Navigation.GotoBindingDataContextProvider>
    {
        public const string ACTION_ID = "GotoDataContext";
    }
    [JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextNavigationProviderAttribute()]
    public sealed class GotoBindingDataContextProvider : JetBrains.ReSharper.Feature.Services.ActionsMenu.IWorkflowProvider<JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextNavigation, JetBrains.ReSharper.Feature.Services.ContextNavigation.NavigationActionGroup>, JetBrains.ReSharper.Feature.Services.ContextNavigation.INavigateFromHereProvider
    {
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextNavigation> CreateWorkflow(JetBrains.Application.DataContext.IDataContext dataContext) { }
    }
}
namespace JetBrains.ReSharper.Features.Xml.Options.Xaml
{
    
    [JetBrains.UI.Options.OptionsPageAttribute("XamlContextActions", "Context Actions", typeof(JetBrains.ReSharper.Daemon.Src.Bulbs.Resources.BulbThemedIcons.ContextAction), HelpKeyword="Reference__Options__Languages__XAML__Context_Actions", ParentId="Xaml")]
    public class XamlContextActionsPage : JetBrains.ReSharper.Intentions.Options.ContextActionsPageBase
    {
        public const string PID = "XamlContextActions";
        public XamlContextActionsPage(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionTable contextActionTable, JetBrains.UI.Application.UIApplication uiApplication, JetBrains.Application.Interop.NativeHook.IWindowsHookManager windowsHookManager, JetBrains.ActionManagement.IActionManager actionManager, JetBrains.UI.Options.OptionsSettingsSmartContext smartContext, JetBrains.Threading.IThreading threading) { }
        public override string Id { get; }
    }
    [JetBrains.UI.Options.OptionsPageAttribute("Xaml.Editor", "Editor", typeof(JetBrains.ReSharper.Features.Intellisense.Resources.FeaturesIntellisenseThemedIcons.EditorOptionsPage), HelpKeyword="Reference__Options__Languages__XAML__Editor", ParentId="Xaml", Sequence=0D)]
    public class XamlEditorPage : JetBrains.ReSharper.Features.Xml.Options.XmlEditorBasePage<JetBrains.ReSharper.Feature.Services.Xaml.Options.XamlTypingAssistSettings>
    {
        [JetBrains.Annotations.PublicAPIAttribute()]
        public const string PID = "Xaml.Editor";
        public XamlEditorPage(JetBrains.DataFlow.Lifetime lifetime, JetBrains.UI.Application.IUIApplication environment, JetBrains.UI.Options.OptionsSettingsSmartContext settings) { }
    }
}
namespace JetBrains.ReSharper.Features.Xml.Options.Xml
{
    
    [JetBrains.UI.Options.OptionsPageAttribute("XmlContextActions", "Context Actions", typeof(JetBrains.ReSharper.Daemon.Src.Bulbs.Resources.BulbThemedIcons.ContextAction), HelpKeyword="Reference__Options__Languages__XML__Context_Actions", ParentId="Xml")]
    public class XmlContextActionsPage : JetBrains.ReSharper.Intentions.Options.ContextActionsPageBase
    {
        public const string PID = "XmlContextActions";
        public XmlContextActionsPage(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionTable contextActionTable, JetBrains.UI.Application.UIApplication uiApplication, JetBrains.Application.Interop.NativeHook.IWindowsHookManager windowsHookManager, JetBrains.ActionManagement.IActionManager actionManager, JetBrains.UI.Options.OptionsSettingsSmartContext smartContext, JetBrains.Threading.IThreading threading) { }
        public override string Id { get; }
    }
}
namespace JetBrains.ReSharper.Features.Xml.Options
{
    
    public abstract class XmlEditorBasePage<TSettings> : JetBrains.UI.Options.Helpers.AStackPanelOptionsPage3
        where TSettings : JetBrains.ReSharper.Feature.Services.Xml.Options.XmlTypingAssistSettings
    {
        protected XmlEditorBasePage(JetBrains.DataFlow.Lifetime lifetime, JetBrains.UI.Application.IUIApplication environment, string pid, JetBrains.UI.Options.OptionsSettingsSmartContext settings) { }
    }
    [JetBrains.UI.Options.OptionsPageAttribute("Xml.Editor", "Editor", typeof(JetBrains.ReSharper.Features.Intellisense.Resources.FeaturesIntellisenseThemedIcons.EditorOptionsPage), HelpKeyword="Reference__Options__Languages__XML__Editor", ParentId="Xml", Sequence=0D)]
    public class XmlEditorPage : JetBrains.ReSharper.Features.Xml.Options.XmlEditorBasePage<JetBrains.ReSharper.Feature.Services.Xml.Options.XmlTypingAssistSettings>
    {
        [JetBrains.Annotations.PublicAPIAttribute()]
        public const string PID = "Xml.Editor";
        public XmlEditorPage(JetBrains.DataFlow.Lifetime lifetime, JetBrains.UI.Application.IUIApplication environment, JetBrains.UI.Options.OptionsSettingsSmartContext settings) { }
    }
}