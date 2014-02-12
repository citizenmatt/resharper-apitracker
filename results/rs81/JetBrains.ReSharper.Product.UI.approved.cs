[assembly: JetBrains.UI.Icons.CompiledIcons.CompiledIconsPackAttribute(IconNames=new string[] {
        "ReSharper16x16",
        "ReSharper32x32"}, IconPackResourceIdentification="JetBrains.ReSharper.Product.UI;component/Resources/ReSharperUI.ThemedIcons/Themed" +
    "Icons.ReSharperUI.Generated.Xaml")]
[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]
[assembly: System.Windows.Markup.XmlnsDefinitionAttribute("urn:shemas-jetbrains-com:ui-application-icons-re-sharper-ui", "JetBrains.ReSharper.Product.UI.Resources")]

namespace JetBrains.ReSharper.Product.UI.Actions
{
    
    [JetBrains.ActionManagement.ActionHandlerAttribute()]
    public class ReSharperMisbehavesAction : JetBrains.ActionManagement.IActionHandler
    {
        public void Execute(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.DelegateExecute nextExecute) { }
        public bool Update(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.ActionPresentation presentation, JetBrains.ActionManagement.DelegateUpdate nextUpdate) { }
    }
}
namespace JetBrains.ReSharper.Product.UI.Controls
{
    
    public class AdvertiseSubmitFeedbackForm : System.Windows.Forms.Form
    {
        public AdvertiseSubmitFeedbackForm(JetBrains.UI.Application.IUIApplication environment) { }
        public bool DoNotShow { get; }
        protected override void Dispose(bool disposing) { }
        protected override bool ProcessCmdKey(ref System.Windows.Forms.Message msg, System.Windows.Forms.Keys keyData) { }
    }
    public class ProductUsageFeedbackForm : System.Windows.Forms.Form
    {
        public ProductUsageFeedbackForm(JetBrains.UI.Application.IUIApplication environment, JetBrains.Application.ActivityTrackingNew.ActivityTrackingSettings activityTrackingSettings) { }
        protected override void Dispose(bool disposing) { }
    }
}
namespace JetBrains.ReSharper.Product.UI.Resources
{
    
    public sealed class ReSharperUIThemedIcons
    {
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Product.UI;component/Resources/ReSharperUI.ThemedIcons/Themed" +
            "Icons.ReSharperUI.Generated.Xaml", 0, "ReSharper16x16")]
        public sealed class ReSharper16x16 : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Product.UI;component/Resources/ReSharperUI.ThemedIcons/Themed" +
            "Icons.ReSharperUI.Generated.Xaml", 1, "ReSharper32x32")]
        public sealed class ReSharper32x32 : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
    }
}