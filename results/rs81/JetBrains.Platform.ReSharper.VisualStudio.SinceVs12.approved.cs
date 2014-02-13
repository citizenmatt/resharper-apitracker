[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]
[assembly: System.Runtime.Versioning.TargetFrameworkAttribute(".NETFramework,Version=v4.5", FrameworkDisplayName=".NET Framework 4.5")]

namespace JetBrains.VsIntegration.SinceVs12.TextControl
{
    
    public class static DefaultTextViewHostOptionsSinceVs12
    {
        public static readonly Microsoft.VisualStudio.Text.Editor.EditorOptionKey<double> ChangeTrackingMarginWidthOptionId;
        public const string ChangeTrackingMarginWidthOptionName = "OverviewMargin/ChangeTrackingWidth";
        public static readonly Microsoft.VisualStudio.Text.Editor.EditorOptionKey<double> ErrorMarginWidthOptionId;
        public const string ErrorMarginWidthOptionName = "OverviewMargin/ErrorMarginWidth";
        public static readonly Microsoft.VisualStudio.Text.Editor.EditorOptionKey<double> MarkMarginWidthOptionId;
        public const string MarkMarginWidthOptionName = "OverviewMargin/MarkMarginWidth";
        public static readonly Microsoft.VisualStudio.Text.Editor.EditorOptionKey<int> PreviewSizeOptionId;
        public const string PreviewSizeOptionName = "OverviewMargin/PreviewSize";
        public static readonly Microsoft.VisualStudio.Text.Editor.EditorOptionKey<bool> ShowCaretPositionOptionId;
        public const string ShowCaretPositionOptionName = "OverviewMargin/ShowCaretPosition";
        public static readonly Microsoft.VisualStudio.Text.Editor.EditorOptionKey<bool> ShowChangeTrackingMarginOptionId;
        public const string ShowChangeTrackingMarginOptionName = "OverviewMargin/ShowChangeTracking";
        public static readonly Microsoft.VisualStudio.Text.Editor.EditorOptionKey<bool> ShowEnhancedScrollBarOptionId;
        public const string ShowEnhancedScrollBarOptionName = "OverviewMargin/ShowEnhancedScrollBar";
        public static readonly Microsoft.VisualStudio.Text.Editor.EditorOptionKey<bool> ShowErrorsOptionId;
        public const string ShowErrorsOptionName = "OverviewMargin/ShowErrors";
        public static readonly Microsoft.VisualStudio.Text.Editor.EditorOptionKey<bool> ShowMarksOptionId;
        public const string ShowMarksOptionName = "OverviewMargin/ShowMarks";
        public static readonly Microsoft.VisualStudio.Text.Editor.EditorOptionKey<bool> ShowPreviewOptionId;
        public const string ShowPreviewOptionName = "OverviewMargin/ShowPreview";
        public static readonly Microsoft.VisualStudio.Text.Editor.EditorOptionKey<bool> ShowScrollBarAnnotationsOptionId;
        public const string ShowScrollBarAnnotationsOptionName = "OverviewMargin/ShowScrollBarAnnotationsOption";
        public static readonly Microsoft.VisualStudio.Text.Editor.EditorOptionKey<bool> SourceImageMarginEnabledOptionId;
        public const string SourceImageMarginEnabledOptionName = "OverviewMargin/ShowSourceImageMargin";
        public static readonly Microsoft.VisualStudio.Text.Editor.EditorOptionKey<double> SourceImageMarginWidthOptionId;
        public const string SourceImageMarginWidthOptionName = "OverviewMargin/SourceImageMarginWidth";
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class FindWindowFrameForEmbeddedPeekTextView : JetBrains.VsIntegration.SinceVs10.TextControl.IFindWindowFrameForVsTextView
    {
        public FindWindowFrameForEmbeddedPeekTextView([JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.ILogger logger, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.Lazy.Lazy<JetBrains.VsIntegration.SinceVs10.TextControl.FindWindowFrameViaTextViewServiceProvider> findWindowFrameViaTextViewServiceProvider) { }
    }
    public class static PredefinedMarginNamesSinceVs12
    {
        public const string BottomRightCorner = "BottomRightCorner";
        public const string OverviewChangeTracking = "OverviewChangeTrackingMargin";
        public const string OverviewError = "OverviewErrorMargin";
        public const string OverviewMark = "OverviewMarkMargin";
        public const string OverviewSourceImage = "OverviewSourceImageMargin";
    }
    public class VsErrorStripeIndicatorMargin : System.Windows.Controls.Border, Microsoft.VisualStudio.Text.Editor.ITextViewMargin, Microsoft.VisualStudio.Text.Editor.IWpfTextViewMargin, System.IDisposable
    {
        public VsErrorStripeIndicatorMargin(Microsoft.VisualStudio.Text.Editor.IWpfTextViewHost host) { }
        public void AdjustVisibility() { }
    }
    [Microsoft.VisualStudio.Text.Editor.MarginContainerAttribute("RightControl")]
    [Microsoft.VisualStudio.Text.Editor.TextViewRoleAttribute("INTERACTIVE")]
    [Microsoft.VisualStudio.Utilities.ContentTypeAttribute("text")]
    [Microsoft.VisualStudio.Utilities.NameAttribute("ReSharperErrorStripeIndicatorMargin")]
    [Microsoft.VisualStudio.Utilities.OrderAttribute(After="SplitterControl")]
    [Microsoft.VisualStudio.Utilities.OrderAttribute(Before="VerticalScrollBarContainer")]
    [System.ComponentModel.Composition.ExportAttribute(typeof(Microsoft.VisualStudio.Text.Editor.IWpfTextViewMarginProvider))]
    public class VsErrorStripeIndicatorMarginProvider : Microsoft.VisualStudio.Text.Editor.IWpfTextViewMarginProvider
    {
        public static string MarginName { get; }
    }
    public class VsErrorStripeLayouterSinceVs12 : JetBrains.TextControl.ErrorStripe.WpfErrorStripeLayouter
    {
        public readonly JetBrains.DataFlow.IProperty<JetBrains.TextControl.ErrorStripe.ErrorStripeWidth> MarginWidth;
        public VsErrorStripeLayouterSinceVs12([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Threading.IThreading threading, [JetBrains.Annotations.NotNullAttribute()] JetBrains.TextControl.ErrorStripe.WpfErrorStripeControl errorStripe, [JetBrains.Annotations.NotNullAttribute()] Microsoft.VisualStudio.Text.Editor.IWpfTextViewHost textViewHost, [JetBrains.Annotations.NotNullAttribute()] System.Windows.FrameworkElement verticalScrollBarElement) { }
        protected override void UpdateLayout() { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class VsErrorStripeLayoutManagerSinceVs12 : JetBrains.VsIntegration.DevTen.TextControl.VsErrorStripeLayoutManagerDevTen
    {
        public VsErrorStripeLayoutManagerSinceVs12([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Threading.IThreading threading, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.Store.Implementation.SettingsStore settingsStore, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.Lazy.Lazy<Microsoft.VisualStudio.Editor.IVsEditorAdaptersFactoryService> vsEditorAdaptersFactoryService, [JetBrains.Annotations.NotNullAttribute()] JetBrains.UI.Theming.ITheming theming) { }
        public override JetBrains.TextControl.ErrorStripe.ErrorStripeLayout AvailableLayouts { get; }
        protected override JetBrains.TextControl.ErrorStripe.WpfErrorStripeLayouter CreateLayouter(JetBrains.DataFlow.Lifetime lifetime, Microsoft.VisualStudio.Text.Editor.IWpfTextView textView, JetBrains.TextControl.ErrorStripe.WpfErrorStripeControl errorStripeControl) { }
    }
    public class VsOverviewErrorStripeMargin : System.Windows.Controls.Border, Microsoft.VisualStudio.Text.Editor.ITextViewMargin, Microsoft.VisualStudio.Text.Editor.IWpfTextViewMargin, System.IDisposable
    {
        public readonly JetBrains.DataFlow.IProperty<double> MarginWidth;
        public VsOverviewErrorStripeMargin(Microsoft.VisualStudio.Text.Editor.IWpfTextViewHost host) { }
        public double Vs12DefaultMarginWidth { get; }
        public void AdjustVisibility() { }
    }
    [Microsoft.VisualStudio.Text.Editor.MarginContainerAttribute("VerticalScrollBar")]
    [Microsoft.VisualStudio.Text.Editor.TextViewRoleAttribute("INTERACTIVE")]
    [Microsoft.VisualStudio.Utilities.ContentTypeAttribute("text")]
    [Microsoft.VisualStudio.Utilities.NameAttribute("ReSharperOverviewErrorStripeMargin")]
    [Microsoft.VisualStudio.Utilities.OrderAttribute(After="OverviewMarkMargin")]
    [Microsoft.VisualStudio.Utilities.OrderAttribute(After="OverviewSourceImageMargin")]
    [Microsoft.VisualStudio.Utilities.OrderAttribute(After="OverviewChangeTrackingMargin")]
    [Microsoft.VisualStudio.Utilities.OrderAttribute(After="OverviewErrorMargin")]
    [System.ComponentModel.Composition.ExportAttribute(typeof(Microsoft.VisualStudio.Text.Editor.IWpfTextViewMarginProvider))]
    public sealed class VsOverviewErrorStripeMarginProvider : Microsoft.VisualStudio.Text.Editor.IWpfTextViewMarginProvider
    {
        public static string MarginName { get; }
    }
}