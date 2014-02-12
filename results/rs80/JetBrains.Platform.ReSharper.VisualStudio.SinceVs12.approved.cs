[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]
[assembly: System.Runtime.Versioning.TargetFrameworkAttribute(".NETFramework,Version=v4.5", FrameworkDisplayName=".NET Framework 4.5")]

namespace JetBrains.VsIntegration.SinceVs12.TextControl
{
    
    [JetBrains.Application.ShellComponentAttribute()]
    public class FindWindowFrameForEmbeddedPeekTextView : JetBrains.VsIntegration.SinceVs10.TextControl.IFindWindowFrameForVsTextView
    {
        public FindWindowFrameForEmbeddedPeekTextView([JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.ILogger logger, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.Lazy.Lazy<JetBrains.VsIntegration.SinceVs10.TextControl.FindWindowFrameViaTextViewServiceProvider> findWindowFrameViaTextViewServiceProvider) { }
    }
}