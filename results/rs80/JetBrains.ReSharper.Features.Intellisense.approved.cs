[assembly: JetBrains.ActionManagement.ActionsXmlAttribute("JetBrains.ReSharper.Features.Intellisense.resources.Actions.xml")]
[assembly: JetBrains.UI.Icons.CompiledIcons.CompiledIconsPackAttribute(IconNames=new string[] {
        "ParameterInfoPage",
        "EditorOptionsPage",
        "CodeCompletionPage",
        "CompletionAppearance",
        "IntellisenseGeneral",
        "Collapse",
        "Unpin",
        "IntellisensePage",
        "ScrollUp",
        "IntellisenseAutopopupPage",
        "IntellisenseCompletingCharsPage",
        "ScrollDown"}, IconPackResourceIdentification="JetBrains.ReSharper.Features.Intellisense;component/resources/FeaturesIntellisens" +
    "eIcons/ThemedIcons.FeaturesIntellisense.Generated.Xaml")]
[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]
[assembly: System.Windows.Markup.XmlnsDefinitionAttribute("urn:shemas-jetbrains-com:ui-application-icons-features-intellisense", "JetBrains.ReSharper.Features.Intellisense.Resources")]

namespace JetBrains.ReSharper.Features.Intellisense.CodeCompletion
{
    
    public abstract class CodeCompletionActionBase : JetBrains.ActionManagement.IActionHandler
    {
        protected abstract JetBrains.ReSharper.Feature.Services.CodeCompletion.CodeCompletionType CodeCompletionType { get; }
        public virtual void Execute(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.DelegateExecute nextExecute) { }
        public virtual bool Update(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.ActionPresentation presentation, JetBrains.ActionManagement.DelegateUpdate nextUpdate) { }
    }
    [JetBrains.ActionManagement.ActionHandlerAttribute()]
    public class CompleteCodeBasicAction : JetBrains.ReSharper.Features.Intellisense.CodeCompletion.CodeCompletionActionBase
    {
        protected override JetBrains.ReSharper.Feature.Services.CodeCompletion.CodeCompletionType CodeCompletionType { get; }
        public override void Execute(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.DelegateExecute nextExecute) { }
        public override bool Update(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.ActionPresentation presentation, JetBrains.ActionManagement.DelegateUpdate nextUpdate) { }
    }
    [JetBrains.ActionManagement.ActionHandlerAttribute()]
    public class CompleteCodeSmartAction : JetBrains.ReSharper.Features.Intellisense.CodeCompletion.CodeCompletionActionBase
    {
        protected override JetBrains.ReSharper.Feature.Services.CodeCompletion.CodeCompletionType CodeCompletionType { get; }
        public override void Execute(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.DelegateExecute nextExecute) { }
    }
    [JetBrains.ActionManagement.ActionHandlerAttribute()]
    public class CompleteCodeTypeNameAction : JetBrains.ReSharper.Features.Intellisense.CodeCompletion.CodeCompletionActionBase
    {
        protected override JetBrains.ReSharper.Feature.Services.CodeCompletion.CodeCompletionType CodeCompletionType { get; }
        public override void Execute(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.DelegateExecute nextExecute) { }
    }
}
namespace JetBrains.ReSharper.Features.Intellisense.CompleteStatement
{
    
    [JetBrains.ActionManagement.ActionHandlerAttribute()]
    public class CompleteStatementActionHandler : JetBrains.ActionManagement.IActionHandler
    {
        public CompleteStatementActionHandler() { }
        public void Execute(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.DelegateExecute nextExecute) { }
        public bool Update(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.ActionPresentation presentation, JetBrains.ActionManagement.DelegateUpdate nextUpdate) { }
    }
}
namespace JetBrains.ReSharper.Features.Intellisense.NextPreviousMember
{
    
    public abstract class GotoNextPrevMemberActionBase
    {
        protected static void Execute(JetBrains.Application.DataContext.IDataContext context, bool nextMember) { }
        protected static int GetNavigationOffset(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl, bool nextMember) { }
        public static int GetTargetOffset(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, int offset, bool nextMember) { }
        protected static bool Update(JetBrains.Application.DataContext.IDataContext context, bool nextMember) { }
    }
}
namespace JetBrains.ReSharper.Features.Intellisense.Options
{
    
    public class CompletingCharactersSettingsControl : System.Windows.Controls.UserControl, System.ComponentModel.INotifyPropertyChanged, System.Windows.Markup.IComponentConnector
    {
        public CompletingCharactersSettingsControl(JetBrains.DataFlow.Lifetime lifetime, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Features.Intellisense.Options.IntelliSenseCompletingCharactersPage.SpecificIntellisenseSetting> settings, JetBrains.Application.Settings.SettingsScalarEntry enterKeyActionEntry, JetBrains.Application.Settings.SettingsScalarEntry tabKeyActionEntry, JetBrains.UI.Options.OptionsSettingsSmartContext settingsContext) { }
        public System.Collections.Generic.IEnumerable<string> AllEnumValues { get; }
        public JetBrains.DataFlow.IProperty<JetBrains.ReSharper.Feature.Services.Lookup.LookupItemInsertType> EnterAction { get; set; }
        public string EnterActionString { get; set; }
        public JetBrains.DataFlow.IProperty<JetBrains.ReSharper.Feature.Services.Lookup.LookupItemInsertType> TabAction { get; set; }
        public string TabActionString { get; set; }
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        public void InitializeComponent() { }
        [JetBrains.Annotations.NotifyPropertyChangedInvocatorAttribute()]
        protected virtual void OnPropertyChanged(string propertyName) { }
    }
    [JetBrains.UI.Options.OptionsPageAttribute("CompletionAppearance", "Completion Appearance", typeof(JetBrains.ReSharper.Features.Intellisense.Resources.FeaturesIntellisenseThemedIcons.CompletionAppearance), HelpKeyword="Reference__Options__Environment__IntelliSense__Completion_Appearance", ParentId="IntelliSense", Sequence=2D)]
    public class CompletionAppearancePage : JetBrains.UI.Options.Helpers.AStackPanelOptionsPage3
    {
        public const string PID = "CompletionAppearance";
        public CompletionAppearancePage(JetBrains.DataFlow.Lifetime lifetime, JetBrains.UI.Application.IUIApplication environment, JetBrains.UI.Options.OptionsSettingsSmartContext settings, JetBrains.Application.Env.RunsProducts.ProductConfigurations config, JetBrains.Application.IApplicationDescriptor product) { }
    }
    [JetBrains.UI.Options.OptionsPageAttribute("CompletionBehavior", "Completion Behavior", typeof(JetBrains.ReSharper.Features.Intellisense.Resources.FeaturesIntellisenseThemedIcons.CodeCompletionPage), HelpKeyword="Reference__Options__Environment__IntelliSense__Completion_Behavior", ParentId="IntelliSense", Sequence=1D)]
    public class CompletionBehaviorPage : JetBrains.UI.Options.Helpers.AStackPanelOptionsPage3
    {
        public const string PID = "CompletionBehavior";
        public CompletionBehaviorPage(JetBrains.DataFlow.Lifetime lifetime, JetBrains.UI.Application.IUIApplication environment, JetBrains.ActionManagement.IActionManager actionManager, JetBrains.ActionManagement.IShortcutManager shortcutManager, JetBrains.UI.Options.OptionsSettingsSmartContext settings) { }
    }
    [JetBrains.UI.Options.OptionsPageAttribute("EditorAppearance", "Editor Appearance", typeof(JetBrains.UI.Resources.CommonThemedIcons.Appearance), HelpKeyword="Reference__Options__Environment__Editor__Editor_Appearance", ParentId="Editor", Sequence=0D)]
    public class EditorAppearancePage : JetBrains.UI.Options.Helpers.AOptionsPage
    {
        [JetBrains.Annotations.PublicAPIAttribute()]
        public const string PID = "EditorAppearance";
        public EditorAppearancePage(JetBrains.DataFlow.Lifetime lifetime, JetBrains.UI.Application.IUIApplication environment, JetBrains.UI.Options.OptionsSettingsSmartContext settings, JetBrains.TextControl.GutterMargin.IGutterMargin gutterMargin) { }
    }
    [JetBrains.UI.Options.OptionsPageAttribute("EditorBehavior", "Editor Behavior", typeof(JetBrains.UI.Resources.CommonThemedIcons.Behaivior), HelpKeyword="Reference__Options__Environment__Editor__Editor_Behavior", ParentId="Editor", Sequence=1D)]
    public class EditorBehaviorPage : JetBrains.UI.Options.Helpers.AStackPanelOptionsPage3
    {
        [JetBrains.Annotations.PublicAPIAttribute()]
        public const string PID = "EditorBehavior";
        public EditorBehaviorPage(JetBrains.DataFlow.Lifetime lifetime, JetBrains.UI.Application.IUIApplication environment, JetBrains.UI.Options.OptionsSettingsSmartContext settings, JetBrains.Application.Env.RunsProducts.ProductConfigurations configurations, JetBrains.Application.IApplicationDescriptor product) { }
    }
    [JetBrains.UI.Options.OptionsPageAttribute("Editor", "Editor", typeof(JetBrains.ReSharper.Features.Intellisense.Resources.FeaturesIntellisenseThemedIcons.EditorOptionsPage), HelpKeyword="Reference__Options__Environment__Editor", ParentId="Environment", Sequence=1D)]
    public class EditorPage : JetBrains.UI.Options.Helpers.AEmptyOptionsPage
    {
        [JetBrains.Annotations.PublicAPIAttribute()]
        public const string PID = "Editor";
        public EditorPage() { }
    }
    [JetBrains.UI.Options.OptionsPageAttribute("CompletionAutopopup", "Autopopup", typeof(JetBrains.ReSharper.Features.Intellisense.Resources.FeaturesIntellisenseThemedIcons.IntellisenseAutopopupPage), HelpKeyword="Reference__Options__Environment__IntelliSense__Autopopup", ParentId="IntelliSense", Sequence=0.7D)]
    public class IntelliSenseAutopopupPage : JetBrains.UI.Options.Helpers.AOptionsPage
    {
        [JetBrains.Annotations.UsedImplicitlyAttribute()]
        public const string PID = "CompletionAutopopup";
        public IntelliSenseAutopopupPage(JetBrains.DataFlow.Lifetime lifetime, JetBrains.UI.Application.IUIApplication environment, JetBrains.UI.Options.OptionsSettingsSmartContext settings) { }
        public static string TypeToString(JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.AutopopupType type) { }
    }
    [JetBrains.UI.Options.OptionsPageAttribute("IntelliSenseCompletingCharactersPage", "Completing Characters", typeof(JetBrains.ReSharper.Features.Intellisense.Resources.FeaturesIntellisenseThemedIcons.IntellisenseCompletingCharsPage), HelpKeyword="Reference__Options__Environment__Completing_Characters", ParentId="IntelliSense", Sequence=0.7D)]
    public class IntelliSenseCompletingCharactersPage : JetBrains.UI.Options.Helpers.AOptionsPage
    {
        public const string PID = "IntelliSenseCompletingCharactersPage";
        public IntelliSenseCompletingCharactersPage([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, JetBrains.UI.Application.IUIApplication environment, JetBrains.UI.Options.OptionsSettingsSmartContext settings) { }
        public class SpecificIntellisenseSetting : System.ComponentModel.INotifyPropertyChanged
        {
            public SpecificIntellisenseSetting(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.Settings.SettingsKey settingsKey, JetBrains.Application.Settings.SettingsScalarEntry completeOnSpaceEntry, JetBrains.Application.Settings.SettingsScalarEntry nonCompletingSymbolsEntry, JetBrains.Application.Settings.SettingsScalarEntry enterActionEntry, JetBrains.Application.Settings.SettingsScalarEntry tabActionEntry, JetBrains.UI.Options.OptionsSettingsSmartContext settings) { }
            public System.Collections.Generic.IEnumerable<string> AllEnumValues { get; }
            public JetBrains.DataFlow.IProperty<bool> CompleteOnSpace { get; set; }
            public JetBrains.DataFlow.IProperty<JetBrains.ReSharper.Feature.Services.Lookup.LookupItemInsertType> EnterAction { get; set; }
            public string EnterActionString { get; set; }
            public string GroupName { get; }
            public JetBrains.DataFlow.IProperty<string> NonCompletingSymbols { get; set; }
            public bool ShowGroup { set; }
            public JetBrains.DataFlow.IProperty<JetBrains.ReSharper.Feature.Services.Lookup.LookupItemInsertType> TabAction { get; set; }
            public string TabActionString { get; set; }
            public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        }
    }
    public class IntellisenseEnabledList : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector
    {
        public IntellisenseEnabledList() { }
        public void InitializeComponent() { }
    }
    [JetBrains.UI.Options.OptionsPageAttribute("IntelliSenseGeneral", "General", typeof(JetBrains.ReSharper.Features.Intellisense.Resources.FeaturesIntellisenseThemedIcons.IntellisenseGeneral), HelpKeyword="Reference__Options__Environment__IntelliSense__General", ParentId="IntelliSense", Sequence=0.5D)]
    public class IntelliSenseGeneralPage : JetBrains.UI.Options.Helpers.AStackPanelOptionsPage3
    {
        public const string PID = "IntelliSenseGeneral";
        public IntelliSenseGeneralPage(JetBrains.DataFlow.Lifetime lifetime, JetBrains.UI.Application.IUIApplication environment, JetBrains.ActionManagement.IActionManager actionManager, JetBrains.ActionManagement.IShortcutManager shortcutManager, JetBrains.UI.Options.OptionsSettingsSmartContext settings) { }
        public static void AddDisabledMembersCueBanner([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] System.Windows.Forms.Control parent, [JetBrains.Annotations.NotNullAttribute()] JetBrains.UI.Options.OptionsSettingsSmartContext smartContext, JetBrains.UI.Application.IUIApplication environment) { }
    }
    [JetBrains.UI.Options.OptionsPageAttribute("IntelliSense", "IntelliSense", typeof(JetBrains.ReSharper.Features.Intellisense.Resources.FeaturesIntellisenseThemedIcons.IntellisensePage), HelpKeyword="Reference__Options__Environment__IntelliSense", ParentId="Environment", Sequence=3D)]
    public class IntelliSensePage : JetBrains.UI.Options.Helpers.AEmptyOptionsPage
    {
        public const string PID = "IntelliSense";
        public IntelliSensePage() { }
    }
    public class LanguageCompletingCharSettings : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector
    {
        public LanguageCompletingCharSettings(JetBrains.ReSharper.Features.Intellisense.Options.IntelliSenseCompletingCharactersPage.SpecificIntellisenseSetting item) { }
        public JetBrains.ReSharper.Features.Intellisense.Options.IntelliSenseCompletingCharactersPage.SpecificIntellisenseSetting Item { get; }
        public void InitializeComponent() { }
    }
    [JetBrains.UI.Options.OptionsPageAttribute("ParameterInfo", "Parameter Info", typeof(JetBrains.ReSharper.Features.Intellisense.Resources.FeaturesIntellisenseThemedIcons.ParameterInfoPage), HelpKeyword="Reference__Options__Environment__IntelliSense__Parameter_Info", ParentId="IntelliSense", Sequence=3D)]
    public class ParameterInfoPage : JetBrains.UI.Options.Helpers.AStackPanelOptionsPage3
    {
        public const string PID = "ParameterInfo";
        public ParameterInfoPage(JetBrains.DataFlow.Lifetime lifetime, JetBrains.UI.Application.IUIApplication environment, JetBrains.ActionManagement.ActionManager actionManager, JetBrains.ActionManagement.IShortcutManager shortcutManager, JetBrains.UI.Options.OptionsSettingsSmartContext settings) { }
    }
}
namespace JetBrains.ReSharper.Features.Intellisense.ParameterInfo
{
    
    public class EditorParameterInfoHandler : JetBrains.ReSharper.Feature.Services.ParameterInfo.IParameterInfoProvider, System.IDisposable
    {
        public JetBrains.ReSharper.Feature.Services.ParameterInfo.IParameterInfoContext Context { get; }
        public JetBrains.UI.PopupWindowManager.HideFlags HideFlags { get; }
        public JetBrains.ProjectModel.ISolution Solution { get; }
        public JetBrains.TextControl.ITextControl TextControl { get; }
        public event System.EventHandler ContextChanged;
        public static bool CanCreateContext(JetBrains.ProjectModel.ISolution solution, JetBrains.DocumentModel.IDocument document, JetBrains.ReSharper.Psi.ILanguageManager languageManager) { }
        public static JetBrains.ReSharper.Feature.Services.ParameterInfo.IParameterInfoContext CreateContext(JetBrains.ProjectModel.ISolution solution, JetBrains.DocumentModel.IDocument document, int caretOffset, int expectedLParenthOffset, char invocationChar, JetBrains.ReSharper.Psi.ILanguageManager languageManager) { }
        public JetBrains.UI.PopupWindowManager.IPopupWindowContext CreatePopupWindowContext(JetBrains.DataFlow.Lifetime lifetime) { }
        public void Dispose() { }
        public static void DoWithHandler(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl, int expectedLParenthOffset, char invocationChar, System.Action<JetBrains.ReSharper.Features.Intellisense.ParameterInfo.EditorParameterInfoHandler> doWithHandler) { }
        public static bool ShouldPopup(JetBrains.TextControl.ITextControl control, char c, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Psi.ILanguageManager languageManager) { }
    }
    public class InvocableControl
    {
        public InvocableControl(JetBrains.ReSharper.Feature.Services.ParameterInfo.ICandidate candidate, JetBrains.UI.Components.Theming.IColorThemeManager themeManager) { }
        public int ActiveParameter { get; set; }
        public int Height { get; set; }
        public bool IsEnabled { get; set; }
        public bool IsExtended { get; set; }
        public string[] NamedArguments { set; }
        public System.Drawing.Rectangle Rectangle { get; set; }
        public System.Drawing.Color ThemedActiveBackground { get; }
        public System.Drawing.Color ThemedActiveForeground { get; }
        public System.Drawing.Color ThemedInactiveBackground { get; }
        public System.Drawing.Color ThemedInactiveForeground { get; }
        public System.Drawing.Color ThemedSeparator { get; }
        public int Width { get; set; }
        public System.Drawing.Size GetPreferredSize(System.Drawing.Graphics graphics, int maxWidth, JetBrains.UI.RenderParams renderparams, bool active) { }
        public int GetSignatureHeight(System.Drawing.Graphics graphics, int maxWidth, JetBrains.UI.RenderParams renderparams, bool active) { }
        public System.Drawing.Size GetTextSize(JetBrains.UI.RichText.RichText text, System.Drawing.Graphics graphics, JetBrains.UI.RenderParams renderparams) { }
        public System.Drawing.Size GetTextSize(JetBrains.UI.RichText.RichTextBlock text, System.Drawing.Graphics graphics, JetBrains.UI.RenderParams renderparams) { }
        public void Paint(System.Drawing.Graphics g, bool isActive, bool drawSeparator, JetBrains.UI.RenderParams renderparams) { }
    }
    public interface IParameterInfoHandlerFactory
    {
        void DoWithCreateHandler(JetBrains.Application.DataContext.IDataContext context, System.Action<JetBrains.ReSharper.Feature.Services.ParameterInfo.IParameterInfoProvider> doWithHandler);
        bool IsAvailable(JetBrains.Application.DataContext.IDataContext context);
    }
    public abstract class NavigationControlBase : JetBrains.UI.CommonControls.SafePanel
    {
        protected const int BUTTON_SIZE = 10;
        protected int myAlignmentHeight;
        protected JetBrains.UI.Components.ImageListButton.ImageListButton myDownButton;
        protected JetBrains.UI.Components.ImageListButton.ImageListButton myUpButton;
        public static readonly System.Drawing.Size ourButtonSize;
        protected const int PADDING = 2;
        public NavigationControlBase(JetBrains.ActionManagement.IActionManager actionman, JetBrains.ActionManagement.IShortcutManager shortcutManager, JetBrains.UI.Application.IUIApplication uiapp) { }
        public bool IsFirst { get; set; }
        public bool IsLast { get; set; }
        public event System.EventHandler DownClick;
        public event System.EventHandler UpClick;
        public System.Drawing.Size CalculateDesiredSize() { }
        public abstract System.Drawing.Size GetPreferredSize(bool isFirst, bool isLast);
        protected override void OnResize(System.EventArgs eventargs) { }
        public void Show(int alignmentHeight) { }
        protected abstract void UpdateControls();
    }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "ParameterInfo.Show"})]
    public class ParameterInfoAction : JetBrains.ActionManagement.IActionHandler
    {
        public ParameterInfoAction() { }
        public void Execute(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.DelegateExecute nextExecute) { }
        public bool Update(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.ActionPresentation presentation, JetBrains.ActionManagement.DelegateUpdate nextUpdate) { }
    }
    public class ParameterInfoControl : JetBrains.ReSharper.Features.Intellisense.ParameterInfo.ParameterInfoControlBase, JetBrains.UI.Tooltips.ITooltipProvider
    {
        public ParameterInfoControl(JetBrains.UI.Components.Theming.IColorThemeManager themeManager, JetBrains.UI.Application.IMainWindow mainWindow) { }
        protected override bool CanSelsectSignature(int line) { }
        protected override JetBrains.ReSharper.Features.Intellisense.ParameterInfo.NavigationControlBase CreateNavControl() { }
        public override System.Drawing.Size GetDesiredSize(JetBrains.UI.IGraphicsContainer gc, System.Drawing.Size limit) { }
        public JetBrains.UI.Tooltips.ITooltipInfo GetTooltip(JetBrains.DataFlow.Lifetime lifetime, System.Drawing.Point point) { }
        protected override void LayoutControls() { }
        protected virtual void OnClick(object sender, System.EventArgs e) { }
        protected override void OnMouseMove(System.Windows.Forms.MouseEventArgs e) { }
        protected override void PaintInvocables(System.Windows.Forms.PaintEventArgs e) { }
        protected override void RecalculateSize() { }
    }
    public abstract class ParameterInfoControlBase : System.Windows.Forms.Form, JetBrains.CommonControls.IConstrainableControl
    {
        protected readonly JetBrains.ReSharper.Features.Intellisense.ParameterInfo.NavigationControlBase myNavControl;
        protected readonly JetBrains.UI.RenderParams myRenderParams;
        protected readonly JetBrains.UI.Components.Theming.IColorThemeManager myThemeManager;
        protected ParameterInfoControlBase(JetBrains.UI.Components.Theming.IColorThemeManager themeManager, JetBrains.UI.Application.IMainWindow mainwin) { }
        public virtual int ActiveSignature { get; set; }
        public bool AutoActivate { get; set; }
        public JetBrains.ReSharper.Feature.Services.ParameterInfo.IParameterInfoContext Context { get; set; }
        protected override System.Windows.Forms.CreateParams CreateParams { get; }
        protected int FirstEnabled { get; }
        protected int InvocablesCount { get; }
        protected int LastEnabled { get; }
        public int MaximumWidth { get; }
        protected override bool ShowWithoutActivation { get; }
        public JetBrains.DataFlow.ISimpleSignal WantsResize { get; }
        protected abstract bool CanSelsectSignature(int line);
        protected abstract JetBrains.ReSharper.Features.Intellisense.ParameterInfo.NavigationControlBase CreateNavControl();
        protected override void Dispose(bool disposing) { }
        public abstract System.Drawing.Size GetDesiredSize(JetBrains.UI.IGraphicsContainer gc, System.Drawing.Size limit);
        protected JetBrains.ReSharper.Features.Intellisense.ParameterInfo.InvocableControl GetInvocable(int i) { }
        protected int GetInvocableIndex(System.Drawing.Point point) { }
        public bool HaveMultipleSignatures() { }
        protected bool IsVisible() { }
        protected abstract void LayoutControls();
        protected virtual void OnActiveSignatureChanged(int oldSignature, int newSignature) { }
        protected override void OnLayout(System.Windows.Forms.LayoutEventArgs levent) { }
        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e) { }
        protected abstract void PaintInvocables(System.Windows.Forms.PaintEventArgs e);
        protected virtual void RecalculateSize() { }
        public void SetLayout(JetBrains.UI.LayoutResult layout) { }
        public void ShowNextSignature() { }
        public void ShowPrevSignature() { }
        protected override void WndProc(ref System.Windows.Forms.Message m) { }
    }
    public class ParameterInfoControlWithOneCandidate : JetBrains.ReSharper.Features.Intellisense.ParameterInfo.ParameterInfoControlBase
    {
        public ParameterInfoControlWithOneCandidate(JetBrains.UI.Components.Theming.IColorThemeManager themeManager, JetBrains.UI.Application.IMainWindow mainWindow) { }
        public override int ActiveSignature { set; }
        protected override bool CanSelsectSignature(int line) { }
        protected override JetBrains.ReSharper.Features.Intellisense.ParameterInfo.NavigationControlBase CreateNavControl() { }
        public override System.Drawing.Size GetDesiredSize(JetBrains.UI.IGraphicsContainer gc, System.Drawing.Size limit) { }
        protected override void LayoutControls() { }
        protected override void PaintInvocables(System.Windows.Forms.PaintEventArgs e) { }
    }
    public class ParameterInfoHandlerFactory : JetBrains.ReSharper.Features.Intellisense.ParameterInfo.IParameterInfoHandlerFactory
    {
        public ParameterInfoHandlerFactory(JetBrains.DataFlow.Lifetime lifetime) { }
        public void DoWithCreateHandler(JetBrains.Application.DataContext.IDataContext context, System.Action<JetBrains.ReSharper.Feature.Services.ParameterInfo.IParameterInfoProvider> doWithHandler) { }
        public bool IsAvailable(JetBrains.Application.DataContext.IDataContext context) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute(JetBrains.Application.Components.ProgramConfigurations.NONE | JetBrains.Application.Components.ProgramConfigurations.STANDALONE | JetBrains.Application.Components.ProgramConfigurations.VS_ADDIN | JetBrains.Application.Components.ProgramConfigurations.ALL)]
    public class ParameterInfoPopupControllerImpl : JetBrains.ReSharper.Feature.Services.ParameterInfo.ParameterInfoPopupController
    {
        public ParameterInfoPopupControllerImpl(JetBrains.ReSharper.Feature.Services.CodeCompletion.IntellisenseManager intellisenseManager, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Psi.ILanguageManager languageManager, JetBrains.DataFlow.Lifetime lifetime, JetBrains.TextControl.ITextControlManager textControlManager, JetBrains.ReSharper.Feature.Services.Lookup.ILookupWindowManager lookupWindowManager, JetBrains.UI.Application.IMainWindow mainWindow, JetBrains.ActionManagement.IActionManager actionManager, JetBrains.Threading.IThreading threading, JetBrains.Application.Settings.ISettingsStore settingsStore, JetBrains.UI.Components.Theming.IColorThemeManager themeManager) { }
        public override bool IsParameterInfoShownInCurrentContext { get; }
        public override bool SupportsSignatureSwitching { get; }
        public override JetBrains.ReSharper.Feature.Services.ParameterInfo.IParameterInfoContext CreateContext(JetBrains.ProjectModel.ISolution solution, JetBrains.DocumentModel.IDocument document, int caretOffset, int expectedLParenthOffset) { }
        public override void EmulateTyping(char c, JetBrains.TextControl.ITextControl textControl) { }
        public override bool IsParameterInfoAvailable(JetBrains.Application.DataContext.IDataContext context) { }
        public override void MoveParameterInfoOnTop() { }
        public override void PopupParameterInfo(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl, int expectedLParOffset, JetBrains.ReSharper.Psi.IDeclaredElement signature) { }
        public override void PopupParameterInfo(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        public override void PopupParameterInfo(JetBrains.Application.DataContext.IDataContext context) { }
        public override void PopupParameterInfo(JetBrains.ReSharper.Feature.Services.ParameterInfo.IParameterInfoProvider provider, JetBrains.TextControl.ITextControl textControl) { }
        public override void ShowDocForNextSignature() { }
        public override void ShowDocForPreviousSignature() { }
    }
}
namespace JetBrains.ReSharper.Features.Intellisense.ParameterInfo.Theming
{
    
    public class ParameterInfoThemeColor : JetBrains.UI.Components.Theming.ThemeColor
    {
        public static readonly JetBrains.UI.Components.Theming.ThemeColor ParameterInfoActiveBackground;
        public static readonly JetBrains.UI.Components.Theming.ThemeColor ParameterInfoActiveForeground;
        public static readonly JetBrains.UI.Components.Theming.ThemeColor ParameterInfoInactiveBackground;
        public static readonly JetBrains.UI.Components.Theming.ThemeColor ParameterInfoInactiveForeground;
        public static readonly JetBrains.UI.Components.Theming.ThemeColor ParameterInfoSeparator;
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class ParameterInfoThemeColorFiller : JetBrains.UI.Components.Theming.IThemeColorFiller
    {
        public virtual void FillColorTheme(JetBrains.UI.Components.Theming.ColorTheme t) { }
    }
}
namespace JetBrains.ReSharper.Features.Intellisense.QuickDoc
{
    
    [JetBrains.ReSharper.Feature.Services.QuickDoc.QuickDocProviderAttribute(0)]
    public class QuickDocCandidatesProvider : JetBrains.ReSharper.Feature.Services.QuickDoc.IQuickDocProvider
    {
        public QuickDocCandidatesProvider(JetBrains.ProjectModel.ISolution solution, JetBrains.DocumentManagers.DocumentManager documentManager, JetBrains.ReSharper.Feature.Services.Navigation.NavigationManager navigationManager, JetBrains.UI.Application.HelpSystem helpSystem, JetBrains.ReSharper.Features.Shared.Util.DeclaredElementCandidatesNavigator declaredElementCandidatesNavigator, JetBrains.ReSharper.Feature.Services.QuickDoc.Providers.QuickDocTypeMemberProvider quickDocTypeMemberProvider) { }
        public bool CanNavigate(JetBrains.Application.DataContext.IDataContext context) { }
        public void Resolve(JetBrains.Application.DataContext.IDataContext context, System.Action<JetBrains.ReSharper.Feature.Services.QuickDoc.IQuickDocPresenter, JetBrains.ReSharper.Psi.PsiLanguageType> resolved) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class QuickDocManager : JetBrains.ReSharper.Psi.IAsyncCommitClient, System.IDisposable
    {
        public QuickDocManager(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.IShellLocks shellLocks, JetBrains.ProjectModel.ISolution solution, JetBrains.DataFlow.IViewable<JetBrains.ReSharper.Feature.Services.QuickDoc.IQuickDocProvider> providers, JetBrains.ReSharper.Psi.AsyncCommitService asyncCommitService, JetBrains.ReSharper.Psi.IPsiServices psiServices, JetBrains.UI.ActiveText.LinkNavigator linkNavigator) { }
        public JetBrains.UI.ActiveText.LinkNavigator LinkNavigator { get; }
        public JetBrains.Application.IShellLocks ShellLocks { get; }
        public bool CanShowQuickDoc(JetBrains.Application.DataContext.IDataContext context) { }
        public void RegisterController(JetBrains.ReSharper.Features.Intellisense.QuickDoc.StandAlone.QuickDocController controller) { }
        public void RegisterViewForDispose(System.Windows.Forms.Form view) { }
        public void ResolveGoto(JetBrains.Application.DataContext.IDataContext context, System.Action<JetBrains.ReSharper.Feature.Services.QuickDoc.IQuickDocPresenter, JetBrains.ReSharper.Psi.PsiLanguageType> resolved) { }
        public void UnregisterController(JetBrains.ReSharper.Features.Intellisense.QuickDoc.StandAlone.QuickDocController controller) { }
    }
    [JetBrains.Application.Settings.SettingsKeyAttribute(typeof(JetBrains.UI.UserInterfaceSettings), "QuickDoc view settings")]
    public class QuickDocSettings
    {
        [JetBrains.Application.Settings.SettingsEntryAttribute(300, "Width")]
        public int Width;
    }
    [JetBrains.Application.Configuration.Upgrade.GlobalSettingsUpgraderAttribute()]
    public class QuickDocSettingsUpgrader : JetBrains.Application.Configuration.SettingTablesUpgrader
    {
        public QuickDocSettingsUpgrader(JetBrains.Application.Env.RunsProducts.ProductConfigurations productConfigurations) { }
        protected override void DoUpgrade(JetBrains.Application.Configuration.IComponentSettingsProvider legacySettingsProvider, JetBrains.Application.Settings.IContextBoundSettingsStore boundSettingsStore, JetBrains.DataFlow.Lifetime upgradeLifetime, JetBrains.Application.Configuration.SettingsTableBase workspaceSettingsTable, JetBrains.Application.Configuration.SettingsTableBase globalSettingsTable) { }
    }
    public class QuickDocView : System.Windows.Forms.Form, JetBrains.CommonControls.IConstrainableControl
    {
        public QuickDocView(JetBrains.ReSharper.Features.Intellisense.QuickDoc.StandAlone.QuickDocController controller, JetBrains.UI.Application.IMainWindow mainWindow, JetBrains.UI.Icons.IThemedIconManager iconman) { }
        public bool AutoActivate { get; set; }
        protected override System.Windows.Forms.CreateParams CreateParams { get; }
        public JetBrains.UI.PopupWindowManager.IPopupWindow PopupWindow { get; set; }
        public JetBrains.DataFlow.ISimpleSignal WantsResize { get; }
        public System.Drawing.Size GetDesiredSize(JetBrains.UI.IGraphicsContainer gc, System.Drawing.Size limit) { }
        protected override void OnClosing(System.ComponentModel.CancelEventArgs e) { }
        protected override void OnDeactivate(System.EventArgs e) { }
        protected override void OnKeyDown(System.Windows.Forms.KeyEventArgs e) { }
        protected override void OnPaint(System.Windows.Forms.PaintEventArgs args) { }
        public void SetLayout(JetBrains.UI.LayoutResult layout) { }
        protected override void WndProc(ref System.Windows.Forms.Message m) { }
    }
    [JetBrains.Application.ShellComponentAttribute(JetBrains.Application.Components.ProgramConfigurations.NONE | JetBrains.Application.Components.ProgramConfigurations.STANDALONE | JetBrains.Application.Components.ProgramConfigurations.VS_ADDIN | JetBrains.Application.Components.ProgramConfigurations.ALL)]
    public class XmlDocImagesProviderImpl : JetBrains.ReSharper.Feature.Services.QuickDoc.Render.XmlDocImagesProvider, System.IDisposable
    {
        public XmlDocImagesProviderImpl(JetBrains.DataFlow.Lifetime lifetime, JetBrains.UI.Icons.IThemedIconManager iconman) { }
        public override JetBrains.Util.FileSystemPath InlineCollapsPath { get; }
        public override string InlineCollapsPathJS { get; }
        public override JetBrains.Util.FileSystemPath InlineExpandPath { get; }
        public override string InlineExpandPathJS { get; }
        public void Dispose() { }
    }
}
namespace JetBrains.ReSharper.Features.Intellisense.QuickDoc.StandAlone
{
    
    public class QuickDocControl : System.Windows.Forms.Control
    {
        public QuickDocControl(JetBrains.ReSharper.Features.Intellisense.QuickDoc.StandAlone.QuickDocController controller, JetBrains.UI.ActiveText.LinkNavigator linkNavigator) { }
        public string DocumentText { set; }
        public int GetPrefferedHeight(int desiredWidth) { }
        public int GetPrefferedWidth() { }
        protected override void OnKeyDown(System.Windows.Forms.KeyEventArgs e) { }
        [JetBrains.Annotations.UsedImplicitlyAttribute(JetBrains.Annotations.ImplicitUseTargetFlags.Members | JetBrains.Annotations.ImplicitUseTargetFlags.WithMembers)]
        [System.Runtime.InteropServices.ComVisibleAttribute(true)]
        public class ExternalScriptHandler
        {
            public ExternalScriptHandler(JetBrains.ReSharper.Features.Intellisense.QuickDoc.StandAlone.QuickDocControl view) { }
            public void Expanded() { }
            public void Navigate(string url) { }
            public void NavigateCtrl(string url) { }
        }
    }
    public class QuickDocController : System.ComponentModel.Component
    {
        public QuickDocController(JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Psi.PsiLanguageType language, JetBrains.ReSharper.Features.Intellisense.QuickDoc.QuickDocManager quickDocManager) { }
        public JetBrains.DataFlow.SimpleSignal ContentUpdated { get; }
        public System.Windows.Forms.Control Control { get; }
        public JetBrains.ReSharper.Psi.PsiLanguageType DefaultLanguage { get; set; }
        public bool IsBackEnabled { get; }
        public bool IsForwardEnabled { get; }
        public JetBrains.DataFlow.Signal<System.Windows.Forms.Keys> KeyPressed { get; }
        public JetBrains.ProjectModel.ISolution Solution { get; }
        protected override void Dispose(bool disposing) { }
        public int GetPrefferedHeight(int width) { }
        public int GetPrefferedWidth() { }
        public void GoBack() { }
        public void GoForward() { }
        public void GoTo([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Feature.Services.QuickDoc.IQuickDocPresenter presenter) { }
        public void OpenInEditor() { }
        public void ReadMore() { }
        public void Resolve(string id, System.Action<JetBrains.ReSharper.Feature.Services.QuickDoc.IQuickDocPresenter> resolved) { }
        public void SafeQueue(string actionName, System.Action action) { }
        public void UpdateContent() { }
    }
}
namespace JetBrains.ReSharper.Features.Intellisense.Resources
{
    
    public sealed class FeaturesIntellisenseThemedIcons
    {
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Features.Intellisense;component/resources/FeaturesIntellisens" +
            "eIcons/ThemedIcons.FeaturesIntellisense.Generated.Xaml", 2, "CodeCompletionPage")]
        public sealed class CodeCompletionPage : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Features.Intellisense;component/resources/FeaturesIntellisens" +
            "eIcons/ThemedIcons.FeaturesIntellisense.Generated.Xaml", 5, "Collapse")]
        public sealed class Collapse : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Features.Intellisense;component/resources/FeaturesIntellisens" +
            "eIcons/ThemedIcons.FeaturesIntellisense.Generated.Xaml", 3, "CompletionAppearance")]
        public sealed class CompletionAppearance : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Features.Intellisense;component/resources/FeaturesIntellisens" +
            "eIcons/ThemedIcons.FeaturesIntellisense.Generated.Xaml", 1, "EditorOptionsPage")]
        public sealed class EditorOptionsPage : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Features.Intellisense;component/resources/FeaturesIntellisens" +
            "eIcons/ThemedIcons.FeaturesIntellisense.Generated.Xaml", 9, "IntellisenseAutopopupPage")]
        public sealed class IntellisenseAutopopupPage : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Features.Intellisense;component/resources/FeaturesIntellisens" +
            "eIcons/ThemedIcons.FeaturesIntellisense.Generated.Xaml", 10, "IntellisenseCompletingCharsPage")]
        public sealed class IntellisenseCompletingCharsPage : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Features.Intellisense;component/resources/FeaturesIntellisens" +
            "eIcons/ThemedIcons.FeaturesIntellisense.Generated.Xaml", 4, "IntellisenseGeneral")]
        public sealed class IntellisenseGeneral : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Features.Intellisense;component/resources/FeaturesIntellisens" +
            "eIcons/ThemedIcons.FeaturesIntellisense.Generated.Xaml", 7, "IntellisensePage")]
        public sealed class IntellisensePage : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Features.Intellisense;component/resources/FeaturesIntellisens" +
            "eIcons/ThemedIcons.FeaturesIntellisense.Generated.Xaml", 0, "ParameterInfoPage")]
        public sealed class ParameterInfoPage : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Features.Intellisense;component/resources/FeaturesIntellisens" +
            "eIcons/ThemedIcons.FeaturesIntellisense.Generated.Xaml", 11, "ScrollDown")]
        public sealed class ScrollDown : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Features.Intellisense;component/resources/FeaturesIntellisens" +
            "eIcons/ThemedIcons.FeaturesIntellisense.Generated.Xaml", 8, "ScrollUp")]
        public sealed class ScrollUp : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Features.Intellisense;component/resources/FeaturesIntellisens" +
            "eIcons/ThemedIcons.FeaturesIntellisense.Generated.Xaml", 6, "Unpin")]
        public sealed class Unpin : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
    }
}
namespace JetBrains.ReSharper.Features.Intellisense.SelectEmbracingConstruct
{
    
    [JetBrains.Application.ShellComponentAttribute()]
    public class SelectEmbracingConstructTracker
    {
        public SelectEmbracingConstructTracker(JetBrains.DataFlow.Lifetime lifetime) { }
        public static JetBrains.ReSharper.Features.Intellisense.SelectEmbracingConstruct.SelectEmbracingConstructTracker Instance { get; }
        public bool IsAvailable(JetBrains.TextControl.ITextControl textControl) { }
        public void SelectEmbracingConstruct(JetBrains.TextControl.ITextControl textControl, JetBrains.Util.TextRange range) { }
        public void UnselectEmbracingConstruct(JetBrains.TextControl.ITextControl textControl) { }
    }
}
namespace JetBrains.ReSharper.Features.Intellisense.src.Options
{
    
    public class AutomaticCompletionSettignsControl : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector
    {
        public System.Collections.Generic.IEnumerable<string> AllEnumValues { get; }
        [JetBrains.Annotations.UsedImplicitlyAttribute()]
        public bool IsAutomaticCompletionEnabled { get; set; }
        public string SelectedTab { get; set; }
        public void InitializeComponent() { }
    }
}
namespace JetBrains.ReSharper.Features.Intellisense.TextEditor
{
    
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "BlockComment"})]
    public class BlockCommentAction : JetBrains.ActionManagement.IActionHandler
    {
        public const string ID = "BlockComment";
        public BlockCommentAction() { }
        public void Execute(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.DelegateExecute nextExecute) { }
        public static string FixNestedMarkersWhileComment(string commentedText, JetBrains.ReSharper.Feature.Services.Comment.IBlockCommentActionProvider provider) { }
        public static string FixNestedMarkersWhileUncomment(string commentedText, JetBrains.ReSharper.Feature.Services.Comment.IBlockCommentActionProvider provider) { }
        public static JetBrains.ReSharper.Feature.Services.Comment.IBlockCommentActionProvider GetProvider(JetBrains.Application.DataContext.IDataContext context) { }
        public bool Update(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.ActionPresentation presentation, JetBrains.ActionManagement.DelegateUpdate nextUpdate) { }
    }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "LineComment"})]
    public class LineCommentAction : JetBrains.ActionManagement.IActionHandler
    {
        public const string ID = "LineComment";
        public void Execute(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.DelegateExecute nextExecute) { }
        public bool Update(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.ActionPresentation presentation, JetBrains.ActionManagement.DelegateUpdate nextUpdate) { }
    }
    public class static LineCommentSettings
    {
        public static bool DoUncommentAdjacentLines { get; }
        public class UncommentAdjacentLinesCookie : System.IDisposable
        {
            public UncommentAdjacentLinesCookie() { }
            public void Dispose() { }
        }
    }
}