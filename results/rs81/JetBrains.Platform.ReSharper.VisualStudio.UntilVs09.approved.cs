[assembly: JetBrains.TextControl.DocumentMarkup.RegisterHighlighterAttribute("InvisibleMarkerType", "{5B1123D4-D36B-44EF-9710-569D3B95F9A1}", Layer=4000, VSPriority=850)]
[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]

namespace JetBrains.VsIntegration.UntilVs09.UI
{
    
    [JetBrains.Application.ShellComponentAttribute(JetBrains.Application.Sharing.Common, JetBrains.Application.Lifecycle.Deferred, JetBrains.Application.Creation.PrimaryThread, JetBrains.Application.Access.None)]
    public class VsStatusBarIndicatorsWhidbey
    {
        public VsStatusBarIndicatorsWhidbey(JetBrains.DataFlow.Lifetime lifetime, JetBrains.UI.StatusBar.IStatusBar statusbar, JetBrains.UI.Application.IMainWindow mainWindow, JetBrains.Application.Env.RunsProducts.ProductConfigurations productConfigurations, JetBrains.UI.PopupMenu.JetPopupMenus jetPopupMenus, JetBrains.Application.Interop.NativeHook.IWindowsHookManager windowsHookManager, JetBrains.UI.PopupWindowManager.MainWindowPopupWindowContext mainWindowPopupWindowContext, JetBrains.Application.Components.IComponentContainer containerForFactoringViews, JetBrains.UI.Wpf.IAutomationViewsRegistry automationViewsRegistry) { }
    }
}
namespace JetBrains.VsIntegration.Whidbey.Markup
{
    
    public class VsFontAndColorsRegistrarWhidbey : System.IDisposable
    {
        public VsFontAndColorsRegistrarWhidbey(EnvDTE.DTE dte) { }
        public void Dispose() { }
        public void RegisterBackgroundColor(string id, int backgroundColor) { }
        public void RegisterForegroundColor(string id, int foregroundColor) { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class VsHighlighterCustomizationWhidbey : JetBrains.VsIntegration.Markup.VsHighlighterCustomizationCommon
    {
        public VsHighlighterCustomizationWhidbey(JetBrains.DataFlow.Lifetime lifetime, JetBrains.TextControl.DefaultTextControlSchemeManager defaultTextControlSchemeManager, [JetBrains.Annotations.NotNullAttribute()] JetBrains.VsIntegration.Whidbey.Markup.VsHighlightingHelperWhidbey vsHighlightingHelperWhidbey, JetBrains.TextControl.DocumentMarkup.IHighlightingAttributeRegistry highlightingAttributeRegistry, JetBrains.Threading.IThreading threading) { }
        protected override JetBrains.TextControl.DocumentMarkup.HighlighterAttributes ApplyVsCustomizations([JetBrains.Annotations.NotNullAttribute()] JetBrains.TextControl.DocumentMarkup.HighlighterAttributes sample, [JetBrains.Annotations.NotNullAttribute()] string sRegisteredHighlighterAttributeId) { }
    }
    [JetBrains.Application.Install.AssemblyAttributeInstallerAttribute(typeof(JetBrains.TextControl.DocumentMarkup.RegisterHighlighterAttribute), JetBrains.Application.Install.InstallerVsVersionAffinity.Specific)]
    public sealed class VsHighlighterInstallerWhidbey : JetBrains.Application.Install.IAssemblyAttributeInstaller<JetBrains.TextControl.DocumentMarkup.RegisterHighlighterAttribute>
    {
        public const string RegExternalMarkersSuffix = "Text Editor\\External Markers";
        public static void CleanupRegisteredHighlighters(JetBrains.Application.Install.Installer installer) { }
    }
    [JetBrains.Application.Install.StaticInstallerAttribute(JetBrains.Application.Install.InstallerVsVersionAffinity.Specific)]
    public sealed class VsHighlighterServiceInstaller : JetBrains.Application.Install.IStaticInstaller
    {
        public const string RegServicesSuffix = "Services";
        public JetBrains.Application.Install.InstallationData.InstallationData InstallStatic([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Install.Installer installer) { }
    }
    [JetBrains.Application.Env.EnvironmentComponentAttribute(JetBrains.Application.Sharing.Product)]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public class VsHighlightingHelperWhidbey : Microsoft.VisualStudio.OLE.Interop.IServiceProvider, Microsoft.VisualStudio.TextManager.Interop.IVsTextMarkerTypeProvider
    {
        public VsHighlightingHelperWhidbey(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.Parts.IPartsCatalogueSet catalogueSet, Microsoft.VisualStudio.Shell.Interop.IProfferService profferService, JetBrains.Util.Lazy.Lazy<Microsoft.VisualStudio.TextManager.Interop.IVsTextManager> vsTextManager, JetBrains.Util.Lazy.Lazy<EnvDTE.DTE> dte, JetBrains.Application.IApplicationDescriptor applicationDescriptor) { }
        public void GetHighlighterColor([JetBrains.Annotations.NotNullAttribute()] string attributeId, out System.Drawing.Color foregroundColor, out System.Drawing.Color backgroundColor, out System.Nullable<> isBold) { }
        public int GetTextMarkerType(ref System.Guid pguidMarker, out Microsoft.VisualStudio.TextManager.Interop.IVsPackageDefinedTextMarkerType ppMarkerType) { }
        public Microsoft.VisualStudio.TextManager.Interop.MARKERTYPE GetVSMarkerType(string attributeId) { }
        public static System.Guid MakeVsMarkerTypeProviderGuid([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.IProductNameAndVersion product) { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class VsPublishGutterMarkFactoryWhidbey
    {
        public VsPublishGutterMarkFactoryWhidbey([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.VsIntegration.Whidbey.Markup.VsHighlightingHelperWhidbey vsHighlightingHelperWhidbey, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Components.IComponentContainer containerForFactoring, [JetBrains.Annotations.NotNullAttribute()] JetBrains.UI.Wpf.IAutomationViewsRegistry automationViewsRegistry) { }
    }
    public class static VsRegisterHighlighterUtilWhidbey
    {
        public static System.Drawing.Color ColorIndexToColor(Microsoft.VisualStudio.TextManager.Interop.COLORINDEX colorIndex) { }
        public static Microsoft.VisualStudio.TextManager.Interop.COLORINDEX ColorToColorIndex(string color) { }
        public static Microsoft.VisualStudio.TextManager.Interop.FONTFLAGS FontStyleToFontFlags(System.Drawing.FontStyle style) { }
        public static bool IsInColorIndex(System.Drawing.Color color) { }
    }
}
namespace JetBrains.VsIntegration.Whidbey.TextControl
{
    
    public class CreateVsTextControlWhidbeyParams : JetBrains.TextControl.CreateTextControlParams<JetBrains.VsIntegration.Whidbey.TextControl.VsTextControlWhidbey>
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly JetBrains.VsIntegration.DocumentModel.Whidbey.VsDocumentWhidbey Document;
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly JetBrains.VsIntegration.Interop.Shim.TextManager.IVsTextView VsTextView;
        public CreateVsTextControlWhidbeyParams([JetBrains.Annotations.NotNullAttribute()] JetBrains.VsIntegration.DocumentModel.Whidbey.VsDocumentWhidbey document, [JetBrains.Annotations.NotNullAttribute()] JetBrains.VsIntegration.Interop.Shim.TextManager.IVsTextView textview, [JetBrains.Annotations.NotNullAttribute()] JetBrains.UI.WindowManagement.WindowFrame frame) { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class VsErrorStripeLayoutManagerWhidbey : JetBrains.TextControl.ErrorStripe.ErrorStripeLayoutManager
    {
        public VsErrorStripeLayoutManagerWhidbey([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.Store.Implementation.SettingsStore settingsStore) { }
        public override JetBrains.TextControl.ErrorStripe.ErrorStripeLayout AvailableLayouts { get; }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class VsTextControlCreationMonitorWhidbey
    {
        public VsTextControlCreationMonitorWhidbey(JetBrains.DataFlow.Lifetime lifetime, JetBrains.VsIntegration.Whidbey.DocumentModel.VsDocumentManagerWhidbey docman, JetBrains.VsIntegration.WindowManagement.VsWindowFrameManager windowman, Microsoft.VisualStudio.Shell.Interop.IVsCodeDefView vsCodeDefView, JetBrains.VsIntegration.Whidbey.TextControl.VsTextControlCreatorWhidbey vsTextControlCreator, JetBrains.Application.Interop.NativeHook.IWindowsHookManager hookman, JetBrains.VsIntegration.Interop.Shim.Shell.IVsRunningDocumentTable rdt, JetBrains.VsIntegration.DocumentModel.Whidbey.MapVsCookieToProjectFile myMapVsCookieToProjectFile, JetBrains.Threading.IThreading threading, Microsoft.VisualStudio.TextManager.Interop.IVsTextManager vsTextManager) { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public sealed class VsTextControlCreatorWhidbey : JetBrains.VsIntegration.TextControl.VsTextControlCreatorCommon
    {
        public VsTextControlCreatorWhidbey(JetBrains.DataFlow.Lifetime lifetime, JetBrains.TextControl.StandaloneTextControlSwitchingGraphicsProvider switchingGraphicsProvider, JetBrains.Application.IShellLocks invocator, JetBrains.TextControl.DefaultTextControlSchemeManager defaultTextControlSchemeManager, JetBrains.TextControl.RunningTextControls runningTextControls, JetBrains.Application.Components.IComponentContainer componentContainer) { }
        public override TTextControl CreateTextControl<TTextControl>([JetBrains.Annotations.NotNullAttribute()] JetBrains.TextControl.CreateTextControlParams<TTextControl> param)
            where TTextControl : JetBrains.TextControl.ITextControl { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.VsIntegration.Whidbey.TextControl.VsTextControlWhidbey TryGetTextControlByVsTextView(JetBrains.VsIntegration.Interop.Shim.TextManager.IVsTextView vsTextView) { }
    }
    public sealed class VsTextControlWhidbey : JetBrains.VsIntegration.TextControl.VsTextControlCommon
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly JetBrains.VsIntegration.DocumentModel.Whidbey.VsDocumentWhidbey VsDocument;
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly JetBrains.VsIntegration.Interop.Shim.TextManager.IVsTextView VsTextView;
        [JetBrains.Threading.GuardAttribute(JetBrains.Threading.Rgc.Guarded)]
        public VsTextControlWhidbey(
                    [JetBrains.Annotations.NotNullAttribute()] JetBrains.VsIntegration.DocumentModel.Whidbey.VsDocumentWhidbey vsDocument, 
                    [JetBrains.Annotations.NotNullAttribute()] JetBrains.VsIntegration.Interop.Shim.TextManager.IVsTextView vsTextView, 
                    [JetBrains.Annotations.NotNullAttribute()] JetBrains.UI.WindowManagement.WindowFrame frame, 
                    JetBrains.Application.IShellLocks locks, 
                    Microsoft.VisualStudio.TextManager.Interop.IVsHiddenTextManager vsHiddenTextManager, 
                    JetBrains.TextControl.Impl.TextControlTypingHandlers textControlTypingHandlers, 
                    JetBrains.VsIntegration.Application.VsCommandProcessor vsCommandProcessor, 
                    JetBrains.VsIntegration.ActionManagement.VsActionManager vsActionManager, 
                    JetBrains.Application.ChangeManager changeManager, 
                    JetBrains.DocumentModel.Impl.DocumentChangeManager documentChangeManager, 
                    JetBrains.VsIntegration.DocumentModel.VsDocumentManagerSynchronization vsDocumentManagerSynchronization, 
                    JetBrains.TextControl.DefaultTextControlSchemeManager defaultTextControlSchemeManager, 
                    JetBrains.VsIntegration.Interop.Events.VsTextManagerEvents vsTextManagerEvents, 
                    Microsoft.VisualStudio.TextManager.Interop.IVsTextManager vsTextManager, 
                    JetBrains.TextControl.DocumentMarkup.IHighlighterCustomization highlighterCustomization, 
                    JetBrains.TextControl.DocumentMarkup.IDocumentMarkupManager documentMarkupManager, 
                    JetBrains.VsIntegration.TextControl.VsDefaultTextControlSchemeManager vsDefaultTextControlSchemeManager, 
                    JetBrains.Application.Interop.NativeHook.IWindowsHookManager windowsMessageHookManager, 
                    JetBrains.UI.PopupWindowManager.MainWindowPopupWindowContext mainWindowPopupWindowContext, 
                    JetBrains.UI.Theming.ITheming theming, 
                    JetBrains.UI.Application.IUIApplication env) { }
        public override JetBrains.TextControl.ITextControlCaret Caret { get; }
        public override JetBrains.TextControl.Coords.ITextControlCoords Coords { get; }
        public override bool IsVsAlive { get; }
        public override JetBrains.TextControl.ITextControlScrolling Scrolling { get; }
        public override JetBrains.TextControl.ITextControlSelection Selection { get; }
        public override JetBrains.TextControl.ITextControlWindow Window { get; }
        protected override object Execute(JetBrains.Application.IChangeMap changeMap) { }
        public override void FillVirtualSpaceUntilCaret() { }
        public override System.IDisposable GetUpdateCookie(string description) { }
        protected override Microsoft.VisualStudio.TextManager.Interop.IVsCompoundAction GetVsTextViewCompoundAction() { }
        public override Microsoft.VisualStudio.OLE.Interop.IOleCommandTarget GetVsTextViewOleCommandTarget() { }
        protected override void Init_AfterFieldInit() { }
        public override bool IsPositionInTextView(JetBrains.TextControl.Coords.ITextControlPos position) { }
        public override void PushOleCommandFilter(JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] Microsoft.VisualStudio.OLE.Interop.IOleCommandTarget filter, [JetBrains.Annotations.NotNullAttribute()] out Microsoft.VisualStudio.OLE.Interop.IOleCommandTarget callnext) { }
        [JetBrains.Threading.GuardAttribute(JetBrains.Threading.Rgc.Guarded)]
        public override void SyncToVsGuarded() { }
    }
}
namespace JetBrains.VsIntegration.Whidbey.UI
{
    
    [JetBrains.Application.ShellComponentAttribute()]
    public class InvalidateOnIconThemeChange
    {
        public InvalidateOnIconThemeChange([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.UI.Icons.IThemedIconManager themedIconManager, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Threading.IThreading threading) { }
    }
}