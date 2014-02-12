[assembly: JetBrains.ActionManagement.ActionsXmlAttribute("JetBrains.ReSharper.Features.Altering.resources.Actions.xml")]
[assembly: JetBrains.TextControl.DocumentMarkup.RegisterHighlighterAttribute("ReSharper Rearrange Left/Right Code Hint", "{77F2E461-3DAC-4D52-8FA6-49521A9286A7}", BackgroundColor="#fcf978:Yellow", DarkBackgroundColor="#5E5B02", DarkForegroundColor="Gray", EffectType=JetBrains.TextControl.DocumentMarkup.EffectType.HIGHLIGHT, ForegroundColor="Black", Layer=5002, VSPriority=10003)]
[assembly: JetBrains.TextControl.DocumentMarkup.RegisterHighlighterAttribute("ReSharper Rearrange Up/Down Code Hint", "{6C366DFF-B5CE-46FC-93D6-A09A85C0083F}", BackgroundColor="#b1dbf3:Green", DarkBackgroundColor="#10496B", DarkForegroundColor="Gray", EffectType=JetBrains.TextControl.DocumentMarkup.EffectType.HIGHLIGHT, ForegroundColor="Black", Layer=5001, VSPriority=10002)]
[assembly: JetBrains.UI.Icons.CompiledIcons.CompiledIconsPackAttribute(IconNames=new string[] {
        "DisplayByType",
        "IconTriangle",
        "CodeCleanupOptionPage",
        "DisplayAlphabetic",
        "FileHeaderText",
        "GeneratedMembers"}, IconPackResourceIdentification="JetBrains.ReSharper.Features.Altering;component/resources/AlteringFeaturesIcons/T" +
    "hemedIcons.AlteringFeatu.Generated.Xaml")]
[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]
[assembly: System.Windows.Markup.XmlnsDefinitionAttribute("urn:shemas-jetbrains-com:ui-application-icons-altering-featu", "JetBrains.ReSharper.Features.Altering.Resources")]

namespace JetBrains.ReSharper.Feature.Services.Generate.Actions
{
    
    public abstract class StandardGenerateActionWorkflow : JetBrains.ReSharper.Feature.Services.ActionsMenu.IWorkflow<JetBrains.ReSharper.Feature.Services.Generate.Actions.GenerateActionGroup>, JetBrains.ReSharper.Feature.Services.Generate.Actions.IGenerateActionWorkflow
    {
        protected StandardGenerateActionWorkflow(string kind, JetBrains.UI.Icons.IconId icon, string menuText, JetBrains.ReSharper.Feature.Services.Generate.Actions.GenerateActionGroup actionGroup, string windowTitle, string description, string actionId) { }
        public JetBrains.ReSharper.Feature.Services.Generate.Actions.GenerateActionGroup ActionGroup { get; }
        public string ActionId { get; }
        public JetBrains.UI.Icons.IconId Icon { get; }
        public abstract double Order { get; }
        public string ShortActionId { get; }
        public string Title { get; }
        public void Execute(JetBrains.Application.DataContext.IDataContext context) { }
        public virtual bool IsAvailable(JetBrains.Application.DataContext.IDataContext dataContext) { }
        public bool IsEnabled(JetBrains.Application.DataContext.IDataContext context) { }
        public override string ToString() { }
    }
}
namespace JetBrains.ReSharper.Features.Altering.CodeCleanup
{
    
    public enum ActionScope
    {
        NONE = 0,
        SELECTION = 1,
        FILE = 2,
        MULTIPLE_FILES = 3,
        DIRECTORY = 4,
        SOLUTION = 5,
    }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "CleanupCode"})]
    public class CodeCleanupAction : JetBrains.ReSharper.Features.Altering.CodeCleanup.CodeCleanupActionBase
    {
        protected override JetBrains.ReSharper.Feature.Services.CodeCleanup.CodeCleanupProfile GetProfile(JetBrains.ReSharper.Features.Altering.CodeCleanup.CodeCleanupFilesCollector collector) { }
    }
    public abstract class CodeCleanupActionBase : JetBrains.ActionManagement.IActionHandler
    {
        protected abstract JetBrains.ReSharper.Feature.Services.CodeCleanup.CodeCleanupProfile GetProfile(JetBrains.ReSharper.Features.Altering.CodeCleanup.CodeCleanupFilesCollector collector);
        protected static JetBrains.ReSharper.Feature.Services.CodeCleanup.CodeCleanupProfile SelectProfileDialog(JetBrains.ReSharper.Features.Altering.CodeCleanup.CodeCleanupFilesCollector collector, bool isSilentCleanup) { }
    }
    public class CodeCleanupDialog : System.Windows.Forms.Form
    {
        public CodeCleanupDialog(JetBrains.UI.Application.IUIApplication environment, JetBrains.ReSharper.Features.Altering.CodeCleanup.CodeCleanupFilesCollector collector, bool isSilentCleanup, JetBrains.Application.Settings.IContextBoundSettingsStore store, JetBrains.ReSharper.Feature.Services.CodeCleanup.CodeCleanupSettingsComponent codeCleanupSettings) { }
        public JetBrains.ReSharper.Feature.Services.CodeCleanup.CodeCleanupProfile SelectedProfile { get; }
        public bool UseSelectedProfileAsSilent { get; }
    }
    public class CodeCleanupFilesCollector
    {
        public readonly JetBrains.ProjectModel.ISolution Solution;
        public readonly JetBrains.TextControl.ITextControl TextControl;
        public JetBrains.ProjectModel.IProjectItem ProjectItem { get; }
        public JetBrains.ReSharper.Features.Altering.CodeCleanup.ActionScope GetActionScope() { }
        public System.Func<JetBrains.DataFlow.Lifetime, JetBrains.Application.DataContext.DataContexts, JetBrains.Application.DataContext.IDataContext> GetContext() { }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Psi.IPsiSourceFile> GetFiles() { }
        public System.Collections.Generic.HashSet<JetBrains.ReSharper.Psi.PsiLanguageType> GetLanguages() { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Features.Altering.CodeCleanup.CodeCleanupFilesCollector TryCreate(JetBrains.Application.DataContext.IDataContext context) { }
    }
    [JetBrains.UI.Options.OptionsPageAttribute("CodeCleanup", "Code Cleanup", typeof(JetBrains.ReSharper.Features.Altering.Resources.AlteringFeatuThemedIcons.CodeCleanupOptionPage), HelpKeyword="Reference__Options__Tools__Code_Cleanup", ParentId="CodeEditing", Sequence=4D)]
    public class CodeCleanupOptionPage : JetBrains.UI.CommonControls.SafeTableLayoutPanel, JetBrains.UI.Options.IOptionsPage
    {
        public const string PID = "CodeCleanup";
        public CodeCleanupOptionPage(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Threading.IThreading threading, JetBrains.UI.CommonControls.Fonts.FontsManager fontsManager, JetBrains.UI.Options.OptionsSettingsSmartContext smartContext, JetBrains.ReSharper.Feature.Services.CodeCleanup.CodeCleanupSettingsComponent codeCleanupSettings, JetBrains.UI.Application.IUIApplication environment) { }
        public JetBrains.UI.CrossFramework.EitherControl Control { get; }
        public string Id { get; }
        public bool OnOk() { }
        public bool ValidatePage() { }
    }
    public class ModifiedDocumentsCollection : System.IDisposable
    {
        public ModifiedDocumentsCollection(JetBrains.ProjectModel.ISolution solution) { }
        public JetBrains.DocumentModel.IDocument[] Documents { get; }
        public void Add(JetBrains.ProjectModel.IProjectFile projectFile, [JetBrains.Annotations.NotNullAttribute()] string newText, int caretPos, bool canIncrementalUpdate) { }
        public void ApplyCaretPosition() { }
        public void ApplyDocumentText() { }
        public void Dispose() { }
    }
    public class ProfileNameDialog : System.Windows.Forms.Form, JetBrains.CommonControls.Validation.IValidatorProvider
    {
        public ProfileNameDialog() { }
        public System.Collections.Generic.ICollection<string> ForbiddenNames { get; set; }
        public string ProfileName { get; set; }
        public System.Collections.Generic.IEnumerable<JetBrains.CommonControls.Validation.IValidator> Validators { get; }
        protected override void Dispose(bool disposing) { }
    }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "SilentCleanupCode"})]
    public class SilentCleanupCodeAction : JetBrains.ReSharper.Features.Altering.CodeCleanup.CodeCleanupActionBase
    {
        protected override JetBrains.ReSharper.Feature.Services.CodeCleanup.CodeCleanupProfile GetProfile(JetBrains.ReSharper.Features.Altering.CodeCleanup.CodeCleanupFilesCollector collector) { }
    }
}
namespace JetBrains.ReSharper.Features.Altering.Generate
{
    
    public class GeneratorElementsOptionsControl : JetBrains.ReSharper.Features.Altering.Generate.GeneratorOptionsControlBase
    {
        public GeneratorElementsOptionsControl(JetBrains.ReSharper.Feature.Services.Generate.IGeneratorWorkflow workflow) { }
        public override void SelectedElementsChanged(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.Generate.IGeneratorElement> selection) { }
    }
    public class GeneratorGlobalOptionsControl : JetBrains.ReSharper.Features.Altering.Generate.GeneratorOptionsControlBase
    {
        public GeneratorGlobalOptionsControl(System.Collections.Generic.IList<JetBrains.ReSharper.Feature.Services.Generate.IGeneratorOption> options) { }
    }
    public class GeneratorOptionsControlBase : JetBrains.UI.CommonControls.SafeTableLayoutPanel
    {
        protected GeneratorOptionsControlBase([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.UI.Application.IUIApplication environment) { }
        protected System.Windows.Forms.ColumnStyle InitializeLayout() { }
        public virtual void SelectedElementsChanged(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.Generate.IGeneratorElement> selection) { }
        protected class TriggeringLabel : System.Windows.Forms.Label
        {
            public TriggeringLabel(System.Windows.Forms.Control control) { }
            protected override void OnMouseClick(System.Windows.Forms.MouseEventArgs e) { }
            protected override bool ProcessMnemonic(char charCode) { }
        }
    }
    public class GeneratorPage : JetBrains.UI.CommonControls.SafeTableLayoutPanel
    {
        public GeneratorPage(System.Collections.Generic.IList<JetBrains.ReSharper.Feature.Services.Generate.IGeneratorElement> elements, JetBrains.Util.OneToListMap<JetBrains.ReSharper.Feature.Services.Generate.IGeneratorElement, JetBrains.ReSharper.Feature.Services.Generate.IGeneratorOption> options, string elementsCaption, JetBrains.ReSharper.Feature.Services.Generate.IGeneratorWorkflow workflow, JetBrains.UI.Application.IUIApplication environment) { }
        public GeneratorPage(JetBrains.UI.Application.IUIApplication environment, System.Collections.Generic.IList<JetBrains.ReSharper.Feature.Services.Generate.IGeneratorElement> elements, System.Collections.Generic.IList<JetBrains.ReSharper.Feature.Services.Generate.IGeneratorOption> options, System.Collections.Generic.IList<JetBrains.ReSharper.Feature.Services.Generate.IGeneratorElement> resultElements, string elementsCaption, JetBrains.ReSharper.Feature.Services.Generate.IGeneratorWorkflow workflow) { }
        public event System.EventHandler SelectionChanged;
        public void ActivateTreeView() { }
        public void RefreshCollections() { }
    }
    public class GeneratorWorkflowForm : System.Windows.Forms.Form
    {
        public GeneratorWorkflowForm(JetBrains.UI.Application.IUIApplication environment, JetBrains.ReSharper.Feature.Services.Generate.IGeneratorWorkflow workflow, string title, string description) { }
        protected override System.Drawing.Size DefaultSize { get; }
        protected override void Dispose(bool disposing) { }
    }
}
namespace JetBrains.ReSharper.Features.Altering.Generate.New
{
    
    public class GenerateConstructorActionWorkflow : JetBrains.ReSharper.Feature.Services.Generate.Actions.StandardGenerateActionWorkflow
    {
        public GenerateConstructorActionWorkflow(JetBrains.UI.Icons.IconId icon) { }
        public override double Order { get; }
    }
    [JetBrains.ReSharper.Feature.Services.Generate.Actions.GenerateProviderAttribute()]
    public class GenerateConstructorItemProvider : JetBrains.ReSharper.Feature.Services.ActionsMenu.IWorkflowProvider<JetBrains.ReSharper.Feature.Services.Generate.Actions.IGenerateActionWorkflow, JetBrains.ReSharper.Feature.Services.Generate.Actions.GenerateActionGroup>, JetBrains.ReSharper.Feature.Services.Generate.Actions.IGenerateActionProvider
    {
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.Generate.Actions.IGenerateActionWorkflow> CreateWorkflow(JetBrains.Application.DataContext.IDataContext dataContext) { }
    }
    public class GenerateDelegatingActionWorkflow : JetBrains.ReSharper.Feature.Services.Generate.Actions.StandardGenerateActionWorkflow
    {
        public GenerateDelegatingActionWorkflow(JetBrains.UI.Icons.IconId icon) { }
        public override double Order { get; }
    }
    [JetBrains.ReSharper.Feature.Services.Generate.Actions.GenerateProviderAttribute()]
    public class GenerateDelegatingItemProvider : JetBrains.ReSharper.Feature.Services.ActionsMenu.IWorkflowProvider<JetBrains.ReSharper.Feature.Services.Generate.Actions.IGenerateActionWorkflow, JetBrains.ReSharper.Feature.Services.Generate.Actions.GenerateActionGroup>, JetBrains.ReSharper.Feature.Services.Generate.Actions.IGenerateActionProvider
    {
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.Generate.Actions.IGenerateActionWorkflow> CreateWorkflow(JetBrains.Application.DataContext.IDataContext dataContext) { }
    }
    public class GenerateEqualityComparerActionWorkflow : JetBrains.ReSharper.Feature.Services.Generate.Actions.StandardGenerateActionWorkflow
    {
        public GenerateEqualityComparerActionWorkflow(JetBrains.UI.Icons.IconId icon) { }
        public override double Order { get; }
    }
    [JetBrains.ReSharper.Feature.Services.Generate.Actions.GenerateProviderAttribute()]
    public class GenerateEqualityComparerItemProvider : JetBrains.ReSharper.Feature.Services.ActionsMenu.IWorkflowProvider<JetBrains.ReSharper.Feature.Services.Generate.Actions.IGenerateActionWorkflow, JetBrains.ReSharper.Feature.Services.Generate.Actions.GenerateActionGroup>, JetBrains.ReSharper.Feature.Services.Generate.Actions.IGenerateActionProvider
    {
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.Generate.Actions.IGenerateActionWorkflow> CreateWorkflow(JetBrains.Application.DataContext.IDataContext dataContext) { }
    }
    public class GenerateEqualityMembersActionWorkflow : JetBrains.ReSharper.Feature.Services.Generate.Actions.StandardGenerateActionWorkflow
    {
        public GenerateEqualityMembersActionWorkflow(JetBrains.UI.Icons.IconId icon) { }
        public override double Order { get; }
    }
    [JetBrains.ReSharper.Feature.Services.Generate.Actions.GenerateProviderAttribute()]
    public class GenerateEqualityMembersItemProvider : JetBrains.ReSharper.Feature.Services.ActionsMenu.IWorkflowProvider<JetBrains.ReSharper.Feature.Services.Generate.Actions.IGenerateActionWorkflow, JetBrains.ReSharper.Feature.Services.Generate.Actions.GenerateActionGroup>, JetBrains.ReSharper.Feature.Services.Generate.Actions.IGenerateActionProvider
    {
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.Generate.Actions.IGenerateActionWorkflow> CreateWorkflow(JetBrains.Application.DataContext.IDataContext dataContext) { }
    }
    public class GenerateEventSubscriptionActionWorkflow : JetBrains.ReSharper.Feature.Services.Generate.Actions.StandardGenerateActionWorkflow
    {
        public GenerateEventSubscriptionActionWorkflow(JetBrains.UI.Icons.IconId icon) { }
        public override double Order { get; }
    }
    [JetBrains.ReSharper.Feature.Services.Generate.Actions.GenerateProviderAttribute()]
    public class GenerateEventSubscriptionItemProvider : JetBrains.ReSharper.Feature.Services.ActionsMenu.IWorkflowProvider<JetBrains.ReSharper.Feature.Services.Generate.Actions.IGenerateActionWorkflow, JetBrains.ReSharper.Feature.Services.Generate.Actions.GenerateActionGroup>, JetBrains.ReSharper.Feature.Services.Generate.Actions.IGenerateActionProvider
    {
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.Generate.Actions.IGenerateActionWorkflow> CreateWorkflow(JetBrains.Application.DataContext.IDataContext dataContext) { }
    }
    public class GenerateFormattingMembersActionWorkflow : JetBrains.ReSharper.Feature.Services.Generate.Actions.StandardGenerateActionWorkflow
    {
        public GenerateFormattingMembersActionWorkflow(JetBrains.UI.Icons.IconId icon) { }
        public override double Order { get; }
    }
    [JetBrains.ReSharper.Feature.Services.Generate.Actions.GenerateProviderAttribute()]
    public class GenerateFormattingMembersItemProvider : JetBrains.ReSharper.Feature.Services.ActionsMenu.IWorkflowProvider<JetBrains.ReSharper.Feature.Services.Generate.Actions.IGenerateActionWorkflow, JetBrains.ReSharper.Feature.Services.Generate.Actions.GenerateActionGroup>, JetBrains.ReSharper.Feature.Services.Generate.Actions.IGenerateActionProvider
    {
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.Generate.Actions.IGenerateActionWorkflow> CreateWorkflow(JetBrains.Application.DataContext.IDataContext dataContext) { }
    }
    public class GenerateImplementationsActionWorkflow : JetBrains.ReSharper.Feature.Services.Generate.Actions.StandardGenerateActionWorkflow
    {
        public GenerateImplementationsActionWorkflow(JetBrains.UI.Icons.IconId icon) { }
        public override double Order { get; }
    }
    [JetBrains.ReSharper.Feature.Services.Generate.Actions.GenerateProviderAttribute()]
    public class GenerateImplementationsItemProvider : JetBrains.ReSharper.Feature.Services.ActionsMenu.IWorkflowProvider<JetBrains.ReSharper.Feature.Services.Generate.Actions.IGenerateActionWorkflow, JetBrains.ReSharper.Feature.Services.Generate.Actions.GenerateActionGroup>, JetBrains.ReSharper.Feature.Services.Generate.Actions.IGenerateActionProvider
    {
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.Generate.Actions.IGenerateActionWorkflow> CreateWorkflow(JetBrains.Application.DataContext.IDataContext dataContext) { }
    }
    public class GenerateOverridesActionWorkflow : JetBrains.ReSharper.Feature.Services.Generate.Actions.StandardGenerateActionWorkflow
    {
        public GenerateOverridesActionWorkflow(JetBrains.UI.Icons.IconId icon) { }
        public override double Order { get; }
    }
    [JetBrains.ReSharper.Feature.Services.Generate.Actions.GenerateProviderAttribute()]
    public class GenerateOverridesItemProvider : JetBrains.ReSharper.Feature.Services.ActionsMenu.IWorkflowProvider<JetBrains.ReSharper.Feature.Services.Generate.Actions.IGenerateActionWorkflow, JetBrains.ReSharper.Feature.Services.Generate.Actions.GenerateActionGroup>, JetBrains.ReSharper.Feature.Services.Generate.Actions.IGenerateActionProvider
    {
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.Generate.Actions.IGenerateActionWorkflow> CreateWorkflow(JetBrains.Application.DataContext.IDataContext dataContext) { }
    }
    public class GeneratePartialMethodsActionWorkflow : JetBrains.ReSharper.Feature.Services.Generate.Actions.StandardGenerateActionWorkflow
    {
        public GeneratePartialMethodsActionWorkflow(JetBrains.UI.Icons.IconId icon) { }
        public override double Order { get; }
    }
    [JetBrains.ReSharper.Feature.Services.Generate.Actions.GenerateProviderAttribute()]
    public class GeneratePartialMethodsItemProvider : JetBrains.ReSharper.Feature.Services.ActionsMenu.IWorkflowProvider<JetBrains.ReSharper.Feature.Services.Generate.Actions.IGenerateActionWorkflow, JetBrains.ReSharper.Feature.Services.Generate.Actions.GenerateActionGroup>, JetBrains.ReSharper.Feature.Services.Generate.Actions.IGenerateActionProvider
    {
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.Generate.Actions.IGenerateActionWorkflow> CreateWorkflow(JetBrains.Application.DataContext.IDataContext dataContext) { }
    }
    public class GeneratePropertiesActionWorkflow : JetBrains.ReSharper.Feature.Services.Generate.Actions.StandardGenerateActionWorkflow
    {
        public GeneratePropertiesActionWorkflow(JetBrains.UI.Icons.IconId icon) { }
        public override double Order { get; }
    }
    [JetBrains.ReSharper.Feature.Services.Generate.Actions.GenerateProviderAttribute()]
    public class GeneratePropertiesItemProvider : JetBrains.ReSharper.Feature.Services.ActionsMenu.IWorkflowProvider<JetBrains.ReSharper.Feature.Services.Generate.Actions.IGenerateActionWorkflow, JetBrains.ReSharper.Feature.Services.Generate.Actions.GenerateActionGroup>, JetBrains.ReSharper.Feature.Services.Generate.Actions.IGenerateActionProvider
    {
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.Generate.Actions.IGenerateActionWorkflow> CreateWorkflow(JetBrains.Application.DataContext.IDataContext dataContext) { }
    }
    public class GenerateReadOnlyPropertiesActionWorkflow : JetBrains.ReSharper.Feature.Services.Generate.Actions.StandardGenerateActionWorkflow
    {
        public GenerateReadOnlyPropertiesActionWorkflow(JetBrains.UI.Icons.IconId icon) { }
        public override double Order { get; }
    }
    [JetBrains.ReSharper.Feature.Services.Generate.Actions.GenerateProviderAttribute()]
    public class GenerateReadOnlyPropertiesItemProvider : JetBrains.ReSharper.Feature.Services.ActionsMenu.IWorkflowProvider<JetBrains.ReSharper.Feature.Services.Generate.Actions.IGenerateActionWorkflow, JetBrains.ReSharper.Feature.Services.Generate.Actions.GenerateActionGroup>, JetBrains.ReSharper.Feature.Services.Generate.Actions.IGenerateActionProvider
    {
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.Generate.Actions.IGenerateActionWorkflow> CreateWorkflow(JetBrains.Application.DataContext.IDataContext dataContext) { }
    }
}
namespace JetBrains.ReSharper.Features.Altering.Options
{
    
    [JetBrains.UI.Options.OptionsPageAttribute("FileHeaderTextPage", "File Header Text", typeof(JetBrains.ReSharper.Features.Altering.Resources.AlteringFeatuThemedIcons.FileHeaderText), HelpKeyword="Reference__Options__Languages__Common__File_Header_Text", ParentId="CodeEditing", Sequence=3D)]
    public class FileHeaderTextPage : JetBrains.UI.CommonControls.SafeUserControl, JetBrains.UI.Options.IOptionsPage
    {
        public const string PID = "FileHeaderTextPage";
        public FileHeaderTextPage(JetBrains.DataFlow.Lifetime lifetime, JetBrains.UI.Options.OptionsSettingsSmartContext settingsSmartContext, JetBrains.ReSharper.Feature.Services.CodeCleanup.IFileHeaderUtils fileHeaderUtils, JetBrains.Threading.IThreading threading, JetBrains.UI.Icons.IThemedIconManager alteringFeatuIconsComponent, JetBrains.UI.Application.IUIApplication environment) { }
        public JetBrains.UI.CrossFramework.EitherControl Control { get; }
        public string Id { get; }
        public bool OnOk() { }
        public bool ValidatePage() { }
    }
    [JetBrains.UI.Options.OptionsPageAttribute("MemberGenerator", "Members Generation", typeof(JetBrains.ReSharper.Features.Altering.Resources.AlteringFeatuThemedIcons.GeneratedMembers), HelpKeyword="Reference__Options__Languages__Common__Generated_Members", Internal=false, ParentId="CodeEditing", Sequence=2D)]
    public class MemberGenerationPage : JetBrains.UI.Options.Helpers.AStackPanelOptionsPage3
    {
        public const string PID = "MemberGenerator";
        public MemberGenerationPage(JetBrains.DataFlow.Lifetime lifetime, JetBrains.UI.Application.IUIApplication environment, JetBrains.UI.Options.OptionsSettingsSmartContext context) { }
    }
}
namespace JetBrains.ReSharper.Features.Altering.Rearrange
{
    
    public class RearrangeAction : JetBrains.ActionManagement.IActionHandler
    {
        protected RearrangeAction(JetBrains.ReSharper.Feature.Services.RearrangeCode.Direction direction) { }
        public void Execute(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.DelegateExecute nextExecute) { }
        public bool Update(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.ActionPresentation presentation, JetBrains.ActionManagement.DelegateUpdate nextUpdate) { }
        [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
                "MoveDown"})]
        public class MoveDownAction : JetBrains.ReSharper.Features.Altering.Rearrange.RearrangeAction
        {
            public MoveDownAction() { }
        }
        [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
                "MoveLeft"})]
        public class MoveLeftAction : JetBrains.ReSharper.Features.Altering.Rearrange.RearrangeAction
        {
            public MoveLeftAction() { }
        }
        [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
                "MoveRight"})]
        public class MoveRightAction : JetBrains.ReSharper.Features.Altering.Rearrange.RearrangeAction
        {
            public MoveRightAction() { }
        }
        [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
                "MoveUp"})]
        public class MoveUpAction : JetBrains.ReSharper.Features.Altering.Rearrange.RearrangeAction
        {
            public MoveUpAction() { }
        }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute(JetBrains.Application.Components.ProgramConfigurations.NONE | JetBrains.Application.Components.ProgramConfigurations.VS_ADDIN | JetBrains.Application.Components.ProgramConfigurations.ALL)]
    public class RearrangeTargetHighlighter : JetBrains.ReSharper.Psi.IAsyncCommitClient, System.IDisposable
    {
        public RearrangeTargetHighlighter(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControlManager textman, JetBrains.UI.Tooltips.ITooltipManager tooltipManager, JetBrains.Application.IShellLocks locks) { }
        public bool IsHighlighted { get; }
        public System.Action BeforeCommit() { }
        public void Dispose() { }
        public static JetBrains.ReSharper.Features.Altering.Rearrange.RearrangeTargetHighlighter GetInstance(JetBrains.ProjectModel.ISolution solution) { }
        public void HighlightImmediately() { }
        public void OnInterrupt() { }
    }
    public class static RearrangeTargetHighlighterIds
    {
        public const string HIGHLIGHTER_ATTRIBUTE_LEFTRIGHT = "ReSharper Rearrange Left/Right Code Hint";
        public const string HIGHLIGHTER_ATTRIBUTE_UPDOWN = "ReSharper Rearrange Up/Down Code Hint";
    }
}
namespace JetBrains.ReSharper.Features.Altering.Resources
{
    
    public sealed class AlteringFeatuThemedIcons
    {
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Features.Altering;component/resources/AlteringFeaturesIcons/T" +
            "hemedIcons.AlteringFeatu.Generated.Xaml", 2, "CodeCleanupOptionPage")]
        public sealed class CodeCleanupOptionPage : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Features.Altering;component/resources/AlteringFeaturesIcons/T" +
            "hemedIcons.AlteringFeatu.Generated.Xaml", 3, "DisplayAlphabetic")]
        public sealed class DisplayAlphabetic : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Features.Altering;component/resources/AlteringFeaturesIcons/T" +
            "hemedIcons.AlteringFeatu.Generated.Xaml", 0, "DisplayByType")]
        public sealed class DisplayByType : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Features.Altering;component/resources/AlteringFeaturesIcons/T" +
            "hemedIcons.AlteringFeatu.Generated.Xaml", 4, "FileHeaderText")]
        public sealed class FileHeaderText : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Features.Altering;component/resources/AlteringFeaturesIcons/T" +
            "hemedIcons.AlteringFeatu.Generated.Xaml", 5, "GeneratedMembers")]
        public sealed class GeneratedMembers : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Features.Altering;component/resources/AlteringFeaturesIcons/T" +
            "hemedIcons.AlteringFeatu.Generated.Xaml", 1, "IconTriangle")]
        public sealed class IconTriangle : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
    }
}