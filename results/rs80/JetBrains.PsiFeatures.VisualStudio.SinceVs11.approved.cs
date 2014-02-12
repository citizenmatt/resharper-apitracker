[assembly: JetBrains.PsiFeatures.VisualStudio.SinceVs11.Theming.RegisterReSharperThemeColorAttribute("LTSelectedGradientEnd", DarkBackgroundColor="#3299FF", HighContrastBackground=JetBrains.UI.Components.Theming.SystemColor.Highlight, LightBackgroundColor="#C6DEFF")]
[assembly: JetBrains.PsiFeatures.VisualStudio.SinceVs11.Theming.RegisterReSharperThemeColorAttribute("LTHeaderGradientEnd", DarkBackgroundColor="#2D2D2D", HighContrastBackground=JetBrains.UI.Components.Theming.SystemColor.Window, LightBackgroundColor="#EDEFF1")]
[assembly: JetBrains.PsiFeatures.VisualStudio.SinceVs11.Theming.RegisterReSharperThemeColorAttribute("LookupMatchedTextForeground", DarkForegroundColor="Blue", HighContrastForeground=JetBrains.UI.Components.Theming.SystemColor.HotTrack, LightForegroundColor="Blue")]
[assembly: JetBrains.PsiFeatures.VisualStudio.SinceVs11.Theming.RegisterReSharperThemeColorAttribute("LTSelectedBorderInner", DarkBackgroundColor="#3299FF", HighContrastBackground=JetBrains.UI.Components.Theming.SystemColor.Highlight, LightBackgroundColor="#D6E7FF")]
[assembly: JetBrains.PsiFeatures.VisualStudio.SinceVs11.Theming.RegisterReSharperThemeColorAttribute("LTSelectedGradientStart", DarkBackgroundColor="#3299FF", HighContrastBackground=JetBrains.UI.Components.Theming.SystemColor.Highlight, LightBackgroundColor="#EFF6FF")]
[assembly: JetBrains.PsiFeatures.VisualStudio.SinceVs11.Theming.RegisterReSharperThemeColorAttribute("LTHeaderGradientBase", DarkBackgroundColor="#2D2D2D", HighContrastBackground=JetBrains.UI.Components.Theming.SystemColor.Window, LightBackgroundColor="White")]
[assembly: JetBrains.PsiFeatures.VisualStudio.SinceVs11.Theming.RegisterReSharperThemeColorAttribute("LTHeaderGradientStart", DarkBackgroundColor="#2D2D2D", HighContrastBackground=JetBrains.UI.Components.Theming.SystemColor.Window, LightBackgroundColor="#F5F6F9")]
[assembly: JetBrains.PsiFeatures.VisualStudio.SinceVs11.Theming.RegisterReSharperThemeColorAttribute("LTInternalBorder", DarkBackgroundColor="#CECECE", HighContrastBackground=JetBrains.UI.Components.Theming.SystemColor.ActiveBorder, LightBackgroundColor="#CECECE")]
[assembly: JetBrains.PsiFeatures.VisualStudio.SinceVs11.Theming.RegisterReSharperThemeColorAttribute("LTSplitterBorder", DarkBackgroundColor="#5A5A5A", HighContrastBackground=JetBrains.UI.Components.Theming.SystemColor.Control, LightBackgroundColor="#A0A0A0")]
[assembly: JetBrains.PsiFeatures.VisualStudio.SinceVs11.Theming.RegisterReSharperThemeColorAttribute("LTTagBorder", DarkBackgroundColor="#434343", HighContrastBackground=JetBrains.UI.Components.Theming.SystemColor.Control, LightBackgroundColor="#E2E2E2")]
[assembly: JetBrains.PsiFeatures.VisualStudio.SinceVs11.Theming.RegisterReSharperThemeColorAttribute("LTTag", DarkBackgroundColor="#000000", DarkForegroundColor="#CCCCCC", HighContrastBackground=JetBrains.UI.Components.Theming.SystemColor.Control, HighContrastForeground=JetBrains.UI.Components.Theming.SystemColor.ControlText, LightBackgroundColor="#F0F0F0", LightForegroundColor="#292929")]
[assembly: JetBrains.PsiFeatures.VisualStudio.SinceVs11.Theming.RegisterReSharperThemeColorAttribute("LTPreviewKeyword", DarkForegroundColor="LightBlue", HighContrastForeground=JetBrains.UI.Components.Theming.SystemColor.HotTrack, LightForegroundColor="DarkBlue")]
[assembly: JetBrains.PsiFeatures.VisualStudio.SinceVs11.Theming.RegisterReSharperThemeColorAttribute("LTPreviewField", DarkForegroundColor="BurlyWood", HighContrastForeground=JetBrains.UI.Components.Theming.SystemColor.GrayText, LightForegroundColor="Brown")]
[assembly: JetBrains.VsIntegration.SinceVs11.Theming.RegisterThemeColorAttribute("LTSelectedBorder", CategoryDescriptor=typeof(JetBrains.PsiFeatures.VisualStudio.SinceVs11.Theming.ReSharperCategoryDescriptor), DarkBackgroundColor="#3299FF", HighContrastBackground=JetBrains.UI.Components.Theming.SystemColor.Highlight, LightBackgroundColor="#729AD5")]
[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]
[assembly: System.Runtime.Versioning.TargetFrameworkAttribute(".NETFramework,Version=v4.5", FrameworkDisplayName=".NET Framework 4.5")]

namespace JetBrains.PsiFeatures.VisualStudio.SinceVs11.Theming
{
    
    [System.AttributeUsageAttribute(System.AttributeTargets.Assembly | System.AttributeTargets.All, AllowMultiple=true)]
    public class RegisterReSharperThemeColorAttribute : JetBrains.VsIntegration.SinceVs11.Theming.RegisterThemeColorAttribute
    {
        public RegisterReSharperThemeColorAttribute(string colorId) { }
    }
    public class ReSharperCategoryDescriptor : JetBrains.VsIntegration.SinceVs11.Theming.RegisterThemeColorAttribute.ICategoryDescriptor
    {
        public ReSharperCategoryDescriptor() { }
        public System.Guid CategoryGuid { get; }
        public string CategoryName { get; }
    }
    public class static ReSharperColors
    {
        public static readonly System.Guid Category;
        public static Microsoft.VisualStudio.Shell.ThemeResourceKey LookupMatchedTextForegroundTextBrushKey { get; }
        public static Microsoft.VisualStudio.Shell.ThemeResourceKey LookupMatchedTextForegroundTextColorKey { get; }
        public static Microsoft.VisualStudio.Shell.ThemeResourceKey LTHeaderGradientBaseBrushKey { get; }
        public static Microsoft.VisualStudio.Shell.ThemeResourceKey LTHeaderGradientBaseColorKey { get; }
        public static Microsoft.VisualStudio.Shell.ThemeResourceKey LTHeaderGradientEndBrushKey { get; }
        public static Microsoft.VisualStudio.Shell.ThemeResourceKey LTHeaderGradientEndColorKey { get; }
        public static Microsoft.VisualStudio.Shell.ThemeResourceKey LTHeaderGradientStartBrushKey { get; }
        public static Microsoft.VisualStudio.Shell.ThemeResourceKey LTHeaderGradientStartColorKey { get; }
        public static Microsoft.VisualStudio.Shell.ThemeResourceKey LTInternalBorderBrushKey { get; }
        public static Microsoft.VisualStudio.Shell.ThemeResourceKey LTInternalBorderColorKey { get; }
        public static Microsoft.VisualStudio.Shell.ThemeResourceKey LTPreviewFieldTextBrushKey { get; }
        public static Microsoft.VisualStudio.Shell.ThemeResourceKey LTPreviewFieldTextColorKey { get; }
        public static Microsoft.VisualStudio.Shell.ThemeResourceKey LTPreviewKeywordTextBrushKey { get; }
        public static Microsoft.VisualStudio.Shell.ThemeResourceKey LTPreviewKeywordTextColorKey { get; }
        public static Microsoft.VisualStudio.Shell.ThemeResourceKey LTSelectedBorderBrushKey { get; }
        public static Microsoft.VisualStudio.Shell.ThemeResourceKey LTSelectedBorderColorKey { get; }
        public static Microsoft.VisualStudio.Shell.ThemeResourceKey LTSelectedBorderInnerBrushKey { get; }
        public static Microsoft.VisualStudio.Shell.ThemeResourceKey LTSelectedBorderInnerColorKey { get; }
        public static Microsoft.VisualStudio.Shell.ThemeResourceKey LTSelectedGradientEndBrushKey { get; }
        public static Microsoft.VisualStudio.Shell.ThemeResourceKey LTSelectedGradientEndColorKey { get; }
        public static Microsoft.VisualStudio.Shell.ThemeResourceKey LTSelectedGradientStartBrushKey { get; }
        public static Microsoft.VisualStudio.Shell.ThemeResourceKey LTSelectedGradientStartColorKey { get; }
        public static Microsoft.VisualStudio.Shell.ThemeResourceKey LTSplitterBorderBrushKey { get; }
        public static Microsoft.VisualStudio.Shell.ThemeResourceKey LTSplitterBorderColorKey { get; }
        public static Microsoft.VisualStudio.Shell.ThemeResourceKey LTTagBorderBrushKey { get; }
        public static Microsoft.VisualStudio.Shell.ThemeResourceKey LTTagBorderColorKey { get; }
        public static Microsoft.VisualStudio.Shell.ThemeResourceKey LTTagBrushKey { get; }
        public static Microsoft.VisualStudio.Shell.ThemeResourceKey LTTagColorKey { get; }
        public static Microsoft.VisualStudio.Shell.ThemeResourceKey LTTagTextBrushKey { get; }
        public static Microsoft.VisualStudio.Shell.ThemeResourceKey LTTagTextColorKey { get; }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class Vs11LiveTemplatesThemeColorFiller : JetBrains.PsiFeatures.VisualStudio.Core.Theming.VsLiveTemplatesColorFiller
    {
        public Vs11LiveTemplatesThemeColorFiller(Microsoft.VisualStudio.Shell.Interop.IVsUIShell5 vsUIShell) { }
        public override void FillColorTheme(JetBrains.UI.Components.Theming.ColorTheme theme) { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class Vs11LookupThemeColorFiller : JetBrains.ReSharper.Feature.Services.Lookup.Theming.LookupThemeColorFiller
    {
        public Vs11LookupThemeColorFiller(Microsoft.VisualStudio.Shell.Interop.IVsUIShell5 vsUIShell5) { }
        public override void FillColorTheme(JetBrains.UI.Components.Theming.ColorTheme theme) { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class Vs11ParameterInfoThemeColorFiller : JetBrains.ReSharper.Features.Intellisense.ParameterInfo.Theming.ParameterInfoThemeColorFiller
    {
        public Vs11ParameterInfoThemeColorFiller(Microsoft.VisualStudio.Shell.Interop.IVsUIShell5 vsUIShell5) { }
        public override void FillColorTheme(JetBrains.UI.Components.Theming.ColorTheme theme) { }
    }
}
namespace JetBrains.PsiFeatures.VisualStudio.SinceVs11.TypingAssist
{
    
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class AspChangedTagNameTrackerVs11 : JetBrains.ReSharper.Feature.Services.Asp.TypingAssist.AspChangedTagNameTracker
    {
        public AspChangedTagNameTrackerVs11(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Settings.ISettingsStore settingsStore, JetBrains.ReSharper.Psi.Services.CachingLexerService cachingLexerService, JetBrains.Application.CommandProcessing.ICommandProcessor commandProcessor, JetBrains.TextControl.Impl.TextControlTypingHandlers textControlTypingHandlers, JetBrains.DataFlow.Lifetime lifetime, JetBrains.TextControl.ITextControlManager textControlManager, JetBrains.Application.IShellLocks shellLocks, JetBrains.ActionManagement.IActionManager actionManager, JetBrains.ProjectModel.Model2.Transaction.IEnsureWritableHandler ensureWritableHandler, JetBrains.DocumentManagers.DocumentManager documentManager, JetBrains.ReSharper.Feature.Services.Lookup.ILookupWindowManager lookupWindowManager, JetBrains.ReSharper.Psi.Files.IPsiFiles psiFiles, JetBrains.Application.ChangeManager changeManager, JetBrains.ReSharper.Feature.Services.TypingAssist.ITypingAssistManager typingAssistManager) { }
        protected override bool IsAvailable(JetBrains.TextControl.ITextControl textControl, JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class HtmlChangedTagNameTrackerVs11 : JetBrains.ReSharper.Feature.Services.Html.TypingAssist.HtmlChangedTagNameTracker
    {
        public HtmlChangedTagNameTrackerVs11(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Settings.ISettingsStore settingsStore, JetBrains.ReSharper.Psi.Services.CachingLexerService cachingLexerService, JetBrains.Application.CommandProcessing.ICommandProcessor commandProcessor, JetBrains.TextControl.Impl.TextControlTypingHandlers textControlTypingHandlers, JetBrains.DataFlow.Lifetime lifetime, JetBrains.TextControl.ITextControlManager textControlManager, JetBrains.Application.IShellLocks shellLocks, JetBrains.ActionManagement.IActionManager actionManager, JetBrains.ProjectModel.Model2.Transaction.IEnsureWritableHandler ensureWritableHandler, JetBrains.DocumentManagers.DocumentManager documentManager, JetBrains.ReSharper.Feature.Services.Lookup.ILookupWindowManager lookupWindowManager, JetBrains.ReSharper.Psi.Files.IPsiFiles psiFiles, JetBrains.Application.ChangeManager changeManager, JetBrains.ReSharper.Feature.Services.TypingAssist.ITypingAssistManager typingAssistManager) { }
        protected override bool IsAvailable(JetBrains.TextControl.ITextControl textControl, JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class RazorChangedTagNameTrackerVs11 : JetBrains.ReSharper.Feature.Services.Razor.TypingAssist.RazorChangedTagNameTracker
    {
        public RazorChangedTagNameTrackerVs11(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Settings.ISettingsStore settingsStore, JetBrains.ReSharper.Psi.Services.CachingLexerService cachingLexerService, JetBrains.Application.CommandProcessing.ICommandProcessor commandProcessor, JetBrains.TextControl.Impl.TextControlTypingHandlers textControlTypingHandlers, JetBrains.DataFlow.Lifetime lifetime, JetBrains.TextControl.ITextControlManager textControlManager, JetBrains.Application.IShellLocks shellLocks, JetBrains.ActionManagement.IActionManager actionManager, JetBrains.ProjectModel.Model2.Transaction.IEnsureWritableHandler ensureWritableHandler, JetBrains.DocumentManagers.DocumentManager documentManager, JetBrains.ReSharper.Feature.Services.Lookup.ILookupWindowManager lookupWindowManager, JetBrains.ReSharper.Psi.Files.IPsiFiles psiFiles, JetBrains.Application.ChangeManager changeManager, JetBrains.ReSharper.Feature.Services.TypingAssist.ITypingAssistManager typingAssistManager) { }
        protected override bool IsAvailable(JetBrains.TextControl.ITextControl textControl, JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
    }
}