[assembly: JetBrains.Util.TestDataPathBaseAttribute("Platform\\test\\data")]
[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]

namespace JetBrains.Platform.Tests.TextControl.Components
{
    
    [JetBrains.Application.ShellComponentAttribute()]
    public class GutterMarginTest : JetBrains.TextControl.GutterMargin.GutterMarginImpl
    {
        public GutterMarginTest(JetBrains.Application.Settings.Store.Implementation.SettingsStore settingsStore) { }
        public override bool IsApplicable() { }
        public override bool IsEnabled(JetBrains.TextControl.ITextControl textControl) { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class TestEnsureAllTextControlsDisposed : JetBrains.TestShell.Components.ITearDown
    {
        public TestEnsureAllTextControlsDisposed([JetBrains.Annotations.NotNullAttribute()] JetBrains.TextControl.RunningTextControls runningTextControls) { }
    }
}
namespace JetBrains.Platform.Tests.TextControl
{
    
    public class TestGraphicsProvider : JetBrains.TextControl.Graphics.IEditorGraphicsProvider
    {
        public TestGraphicsProvider(JetBrains.TextControl.DefaultTextControlSchemeManager defaultTextControlSchemeManager) { }
        public JetBrains.TextControl.Graphics.TestEditorGraphics Graphics { get; }
        public JetBrains.TextControl.Graphics.IEditorGraphics CreateEditorGraphics(System.Windows.Forms.Control control, System.Drawing.Color backColor) { }
    }
}