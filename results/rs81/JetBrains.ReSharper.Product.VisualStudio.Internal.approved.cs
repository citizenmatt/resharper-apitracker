[assembly: JetBrains.UI.Icons.CompiledIcons.CompiledIconsPackAttribute(IconNames=new string[] {
        "InternalPage"}, IconPackResourceIdentification="JetBrains.ReSharper.Product.VisualStudio.Internal;component/Resources/FeaturesVis" +
    "ualStudioInternalIcons/ThemedIcons.FeaturesVisualStudioInternal.Generated.Xaml")]
[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]
[assembly: System.Windows.Markup.XmlnsDefinitionAttribute("urn:shemas-jetbrains-com:ui-application-icons-features-visual-studio-internal", "JetBrains.ReSharper.Product.VisualStudio.Internal.Resources")]

namespace JetBrains.ReSharper.Features.Common.UI
{
    
    [System.Windows.Markup.ContentPropertyAttribute("DeclaredElement")]
    public class DeclaredElementView : System.Windows.Documents.Span
    {
        public static readonly System.Windows.DependencyProperty DeclaredElementProperty;
        public DeclaredElementView([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IDeclaredElement declaredelement, JetBrains.UI.PopupWindowManager.MainWindowPopupWindowContext mainWindowPopupWindowContext) { }
        public DeclaredElementView(JetBrains.UI.PopupWindowManager.MainWindowPopupWindowContext mainWindowPopupWindowContext) { }
        public JetBrains.ReSharper.Psi.IDeclaredElement DeclaredElement { get; set; }
    }
}
namespace JetBrains.ReSharper.Product.VisualStudio.Internal.ErrorStripeProto
{
    
    [JetBrains.Application.ShellComponentAttribute()]
    public class ErrorStripeProtoOptionsPage
    {
        public ErrorStripeProtoOptionsPage(JetBrains.DataFlow.Lifetime lifetime, JetBrains.UI.Application.IUIApplication environment) { }
    }
}
namespace JetBrains.ReSharper.Product.VisualStudio.Internal.Resources
{
    
    public sealed class FeaturesVisualStudioInternalThemedIcons
    {
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Product.VisualStudio.Internal;component/Resources/FeaturesVis" +
            "ualStudioInternalIcons/ThemedIcons.FeaturesVisualStudioInternal.Generated.Xaml", 0, "InternalPage")]
        public sealed class InternalPage : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
    }
}
namespace JetBrains.ReSharper.Product.VisualStudio.Internal.Src.Actions
{
    
    public class PrintSchema
    {
        public static void OpenForExport(JetBrains.Application.Settings.ISettingsSchema schema) { }
        public static void Print(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.Settings.ISettingsSchema schema, JetBrains.Application.IShellLocks locks) { }
    }
}
namespace JetBrains.ReSharper.VSI.Actions
{
    
    public class CheckBoxSample7 : System.Windows.Controls.Control, System.Windows.Markup.IComponentConnector
    {
        public static readonly System.Windows.DependencyProperty TextProperty;
        public CheckBoxSample7() { }
        public string Text { get; set; }
        public void InitializeComponent() { }
    }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "LocalRegister"})]
    public class LocalRegisterAction : JetBrains.ActionManagement.IActionHandler { }
    [JetBrains.Application.ShellComponentAttribute()]
    public class StdAfxComponent
    {
        public StdAfxComponent(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.ChangeManager changeman, JetBrains.Threading.IThreading threading) { }
    }
    public class UserControl666 : System.Windows.Controls.Control, System.Windows.Markup.IComponentConnector
    {
        public UserControl666() { }
        public void InitializeComponent() { }
    }
}
namespace JetBrains.ReSharper.VSI.Components
{
    
    public class static SolutionWatchdog
    {
        [JetBrains.ProjectModel.SolutionComponentAttribute()]
        public class SolCompo : System.IDisposable
        {
            public SolCompo([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.ISolution solution) { }
        }
    }
}
namespace JetBrains.ReSharper.VSI.Misc
{
    
    public class static LocalProj
    {
        public static bool RegisterAndDevenvSetup() { }
    }
}
namespace JetBrains.ReSharper.VSI.OnlineHelp
{
    
    public class GoogleOnlineHelpProvider : JetBrains.ReSharper.VSI.OnlineHelp.IOnlineHelpProvider
    {
        public string UrlFromTypeElement(JetBrains.ReSharper.Psi.ITypeElement typeElement) { }
        public string UrlFromTypeMember(JetBrains.ReSharper.Psi.ITypeMember typeMember) { }
    }
    public interface IOnlineHelpProvider
    {
        string UrlFromTypeElement(JetBrains.ReSharper.Psi.ITypeElement typeElement);
        string UrlFromTypeMember(JetBrains.ReSharper.Psi.ITypeMember typeMember);
    }
    public class MsdnOnlineHelpProvider : JetBrains.ReSharper.VSI.OnlineHelp.IOnlineHelpProvider
    {
        public string UrlFromTypeElement(JetBrains.ReSharper.Psi.ITypeElement typeElement) { }
        public string UrlFromTypeMember(JetBrains.ReSharper.Psi.ITypeMember typeMember) { }
    }
    [JetBrains.ActionManagement.ActionHandlerAttribute()]
    public class OnlineHelpActionHandler : JetBrains.ActionManagement.IActionHandler
    {
        public void Execute(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.DelegateExecute nextExecute) { }
        public bool Update(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.ActionPresentation presentation, JetBrains.ActionManagement.DelegateUpdate nextUpdate) { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class OnlineHelpOptions
    {
        public OnlineHelpOptions(JetBrains.DataFlow.Lifetime lifetime) { }
    }
    [JetBrains.Application.Settings.SettingsKeyAttribute(typeof(JetBrains.Application.Settings.EnvironmentSettings), "Online help settings")]
    public class OnlineHelpSettings
    {
        [JetBrains.Application.Settings.SettingsEntryAttribute(false, "Is enabled")]
        public bool IsEnabled;
    }
    [JetBrains.Application.Configuration.Upgrade.GlobalSettingsUpgraderAttribute()]
    public class OnlineHelpSettingsUpgrader : JetBrains.Application.Configuration.IXmlReadable, JetBrains.Application.Configuration.Upgrade.IGlobalSettingsUpgrader, JetBrains.Application.Configuration.Upgrade.ISettingsUpgrader
    {
        public void ReadFromXml(System.Xml.XmlElement element) { }
        public void Upgrade(JetBrains.Application.Configuration.IComponentSettingsProvider legacySettingsProvider, JetBrains.Application.Settings.IContextBoundSettingsStore boundSettingsStore, JetBrains.DataFlow.Lifetime upgradeLifetime) { }
    }
}
namespace JetBrains.ReSharper.VSI.ProjectModel
{
    
    [JetBrains.ActionManagement.ActionHandlerAttribute()]
    public class DumpVsHierarchyActionHandler : JetBrains.ActionManagement.IActionHandler
    {
        public bool DumpSolution(System.Text.StringBuilder builder, System.Func<JetBrains.VsIntegration.ProjectModel.VsHierarchyItem, System.Collections.Generic.IEnumerable<JetBrains.VsIntegration.ProjectModel.VsHierarchyItem>> children) { }
        public void Execute(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.DelegateExecute nextExecute) { }
        public bool Update(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.ActionPresentation presentation, JetBrains.ActionManagement.DelegateUpdate nextUpdate) { }
    }
}