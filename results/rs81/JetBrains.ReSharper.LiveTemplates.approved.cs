[assembly: JetBrains.ActionManagement.ActionsXmlAttribute("JetBrains.ReSharper.LiveTemplates.resources.actions.xml")]
[assembly: JetBrains.TextControl.DocumentMarkup.RegisterHighlighterAttribute("ReSharper Template Editor Template Keyword", "{c08f5855-58b3-429e-959a-396c99fdd86d}", DarkForegroundColor="LightBlue", EffectType=JetBrains.TextControl.DocumentMarkup.EffectType.TEXT, ForegroundColor="DarkBlue", Layer=2000, VSPriority=40)]
[assembly: JetBrains.UI.Icons.CompiledIcons.CompiledIconsPackAttribute(IconNames=new string[] {
        "AddFileTemplate",
        "AddFileStorage",
        "ManageLayers",
        "AddSurroundTemplate",
        "AddLiveTemplate",
        "ExportLiveTemplate",
        "MoveLiveTemplate",
        "LiveTemplatesToolWindow",
        "ImportLiveTemplate",
        "ScopeVB",
        "NewFolderLiveTemplate",
        "ShowPredefinedTemplates",
        "DeleteLiveTemplate",
        "CopyLiveTemplete",
        "FilterLiveTemplate",
        "EditTemplate"}, IconPackResourceIdentification="JetBrains.ReSharper.LiveTemplates;component/resources/LiveTemplatesThemedIcons/Th" +
    "emedIcons.LiveTemplates.Generated.Xaml")]
[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]
[assembly: System.Windows.Markup.XmlnsDefinitionAttribute("urn:shemas-jetbrains-com:ui-application-icons-live-templates", "JetBrains.ReSharper.LiveTemplates.Resources")]

namespace JetBrains.ReSharper.LiveTemplates.Actions
{
    
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "BuildTemplateFromSelection"})]
    public class BuildTemplateAction : JetBrains.ActionManagement.IActionHandler
    {
        public void Execute(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.DelegateExecute nextExecute) { }
        public bool Update(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.ActionPresentation presentation, JetBrains.ActionManagement.DelegateUpdate nextUpdate) { }
    }
}
namespace JetBrains.ReSharper.LiveTemplates.Execution
{
    
    [JetBrains.ProjectModel.SolutionComponentAttribute(JetBrains.Application.Components.ProgramConfigurations.NONE | JetBrains.Application.Components.ProgramConfigurations.STANDALONE | JetBrains.Application.Components.ProgramConfigurations.VS_ADDIN | JetBrains.Application.Components.ProgramConfigurations.ALL)]
    public class LiveTemplateTracker
    {
        public LiveTemplateTracker(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControlManager textControlManager, JetBrains.TextControl.Util.TextControlChangeUnitFactory textControlChangeUnitFactory, JetBrains.ActionManagement.IActionManager actionManager, JetBrains.UI.Tooltips.ITooltipManager tooltipManager, JetBrains.Application.ChangeManager changeManager, JetBrains.ReSharper.Feature.Services.LiveTemplates.LiveTemplates.LiveTemplatesManager liveTemplatesManager, JetBrains.ReSharper.Feature.Services.Lookup.ILookupWindowManager lookupWindowManager) { }
    }
}
namespace JetBrains.ReSharper.LiveTemplates
{
    
    public class ExtendedRichText : System.Windows.Forms.RichTextBox
    {
        public ExtendedRichText() { }
        protected override void Dispose(bool disposing) { }
        public void GetFocus() { }
        public void RemoveFocus() { }
    }
    public class FieldSelectionControl : JetBrains.UI.CommonControls.SafeTreeList
    {
        public FieldSelectionControl(JetBrains.ReSharper.LiveTemplates.TemplateBuilder.TemplateBuildingData templateBuildingData, JetBrains.UI.Application.IUIApplication environment) { }
        public event System.EventHandler SelectedFieldsChanged;
    }
    public interface ITextEditor
    {
        public event System.Windows.Forms.MouseEventHandler MouseMove;
        public event System.EventHandler TextChanged;
        void BeginHighlight();
        void EndHighlight();
        string GetText();
        void SetColor(JetBrains.Util.TextRange textRange, System.Drawing.Color color);
        void SetFlags(JetBrains.Util.TextRange textRange, bool underline);
        void SetText(string text);
    }
    public class MacroChooserForm : System.Windows.Forms.Form
    {
        public MacroChooserForm(JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.IMacroDefinition currentMacro) { }
        public JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.IMacroDefinition SelectedMacro { get; }
        protected override void Dispose(bool disposing) { }
    }
    public class static MacroDescriptionFormatter
    {
        public static JetBrains.CommonControls.ActiveRichText.FormattedText FormatMacro(JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.IMacroDefinition macro, System.Collections.Generic.IList<JetBrains.ReSharper.LiveTemplates.UI.TemplateEditor.MacroParameterAutomationBase> parameters) { }
        public static JetBrains.CommonControls.ActiveRichText.FormattedText FormatMacroDescription(JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.IMacroDefinition macro) { }
        public static JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.MacroDefinitionAttribute GetMacroAttribute(JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.IMacroDefinition macro) { }
        public static System.Collections.Generic.IList<string> GetParameterNames(JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.IMacroDefinition macro) { }
        public static string ToPlainText(JetBrains.CommonControls.ActiveRichText.FormattedText formatted) { }
    }
    public class MacrosList : JetBrains.UI.CommonControls.SafeTreeList
    {
        public MacrosList() { }
        public JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.IMacroDefinition SelectedMacro { get; set; }
        public event System.EventHandler SelectedMacroChange;
    }
    public class static ParameterValueSetManager
    {
        public static JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.ConstantMacroParameter GetMacroParameterWithSolution(JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.ConstantMacroParameter constantMacroParameter, JetBrains.ProjectModel.ISolution solution, JetBrains.Application.IShellLocks locks, JetBrains.Application.Threading.Tasks.ITaskHost tasks, JetBrains.UI.Application.IMainWindow mainWindow) { }
    }
    public class RichTextEditor : JetBrains.ReSharper.LiveTemplates.ITextEditor, System.IDisposable
    {
        public RichTextEditor(JetBrains.ReSharper.LiveTemplates.ExtendedRichText richTextBox) { }
        public event System.Windows.Forms.MouseEventHandler MouseMove;
        public event System.EventHandler TextChanged;
        public void BeginHighlight() { }
        public void Dispose() { }
        public void EndHighlight() { }
        public string GetText() { }
        public void SetColor(JetBrains.Util.TextRange textRange, System.Drawing.Color color) { }
        public void SetFlags(JetBrains.Util.TextRange textRange, bool underline) { }
        public void SetText(string text) { }
    }
}
namespace JetBrains.ReSharper.LiveTemplates.FileTemplates
{
    
    [JetBrains.Application.ShellComponentAttribute()]
    public class FileTemplatesManagerImpl : JetBrains.ReSharper.Feature.Services.LiveTemplates.FileTemplates.FileTemplatesManager
    {
        public FileTemplatesManagerImpl(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ActionManagement.IActionManager actionManager, JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.TemplateScopeManager scopeManager, JetBrains.UI.Application.UIApplication application, JetBrains.ReSharper.Feature.Services.LiveTemplates.LiveTemplates.LiveTemplatesManager liveTemplatesManager, JetBrains.DataFlow.IViewable<JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.IScopeCategoryUIProvider> scopeCategoryUIProviders, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.LiveTemplates.Support.IFileTemplatesSupport> fileTemplateSupporters, JetBrains.Application.Settings.ISettingsStore settingsStore, JetBrains.ReSharper.Feature.Services.LiveTemplates.Settings.StoredTemplatesProvider storedTemplatesProvider, JetBrains.Application.ChangeManager changeManager, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.LiveTemplates.FileTemplates.ISectionFilenameSelector> fileNameSelectors) { }
        public override JetBrains.ProjectModel.IProjectFile CreateFileFromTemplate(string fileNameNoExtension, JetBrains.ProjectModel.IProjectFolder targetFolder, JetBrains.ReSharper.LiveTemplates.Templates.Template template, System.Action<JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotSession> init = null) { }
    }
    public class GenerateFileActionWorkflow : JetBrains.ReSharper.Feature.Services.ActionsMenu.IWorkflow<JetBrains.ReSharper.Feature.Services.Generate.Actions.GenerateActionGroup>, JetBrains.ReSharper.Feature.Services.Generate.Actions.IGenerateActionWorkflow
    {
        public GenerateFileActionWorkflow(JetBrains.ReSharper.LiveTemplates.Templates.Template template, int index) { }
        public JetBrains.ReSharper.Feature.Services.Generate.Actions.GenerateActionGroup ActionGroup { get; }
        public string ActionId { get; }
        public JetBrains.UI.Icons.IconId Icon { get; }
        public double Order { get; }
        public string ShortActionId { get; }
        public string Title { get; }
        public void Execute(JetBrains.Application.DataContext.IDataContext context) { }
        public bool IsAvailable(JetBrains.Application.DataContext.IDataContext dataContext) { }
        public bool IsEnabled(JetBrains.Application.DataContext.IDataContext context) { }
    }
    [JetBrains.ReSharper.Feature.Services.Generate.Actions.GenerateProviderAttribute()]
    public class GenerateFromTemplateItemProvider : JetBrains.ReSharper.Feature.Services.ActionsMenu.IWorkflowProvider<JetBrains.ReSharper.Feature.Services.Generate.Actions.IGenerateActionWorkflow, JetBrains.ReSharper.Feature.Services.Generate.Actions.GenerateActionGroup>, JetBrains.ReSharper.Feature.Services.Generate.Actions.IGenerateActionProvider
    {
        public GenerateFromTemplateItemProvider() { }
        public GenerateFromTemplateItemProvider(bool workInTextControl) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.Generate.Actions.IGenerateActionWorkflow> CreateWorkflow(JetBrains.Application.DataContext.IDataContext dataContext) { }
    }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "FileTemplates.QuickList.More"})]
    public class MoreFileTemplatesAction : JetBrains.ActionManagement.IActionHandler
    {
        public MoreFileTemplatesAction() { }
        public void Execute(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.DelegateExecute nextExecute) { }
        public bool Update(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.ActionPresentation presentation, JetBrains.ActionManagement.DelegateUpdate nextUpdate) { }
    }
    public class MoreTemplatesActionWorkflow : JetBrains.ReSharper.Feature.Services.ActionsMenu.IWorkflow<JetBrains.ReSharper.Feature.Services.Generate.Actions.GenerateActionGroup>, JetBrains.ReSharper.Feature.Services.Generate.Actions.IGenerateActionWorkflow
    {
        public MoreTemplatesActionWorkflow() { }
        public JetBrains.ReSharper.Feature.Services.Generate.Actions.GenerateActionGroup ActionGroup { get; }
        public string ActionId { get; }
        public JetBrains.UI.Icons.IconId Icon { get; }
        public double Order { get; }
        public string ShortActionId { get; }
        public string Title { get; }
        public void Execute(JetBrains.Application.DataContext.IDataContext context) { }
        public bool IsAvailable(JetBrains.Application.DataContext.IDataContext dataContext) { }
        public bool IsEnabled(JetBrains.Application.DataContext.IDataContext context) { }
    }
}
namespace JetBrains.ReSharper.LiveTemplates.Resources
{
    
    public sealed class LiveTemplatesThemedIcons
    {
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.LiveTemplates;component/resources/LiveTemplatesThemedIcons/Th" +
            "emedIcons.LiveTemplates.Generated.Xaml", 1, "AddFileStorage")]
        public sealed class AddFileStorage : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.LiveTemplates;component/resources/LiveTemplatesThemedIcons/Th" +
            "emedIcons.LiveTemplates.Generated.Xaml", 0, "AddFileTemplate")]
        public sealed class AddFileTemplate : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.LiveTemplates;component/resources/LiveTemplatesThemedIcons/Th" +
            "emedIcons.LiveTemplates.Generated.Xaml", 4, "AddLiveTemplate")]
        public sealed class AddLiveTemplate : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.LiveTemplates;component/resources/LiveTemplatesThemedIcons/Th" +
            "emedIcons.LiveTemplates.Generated.Xaml", 3, "AddSurroundTemplate")]
        public sealed class AddSurroundTemplate : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.LiveTemplates;component/resources/LiveTemplatesThemedIcons/Th" +
            "emedIcons.LiveTemplates.Generated.Xaml", 13, "CopyLiveTemplete")]
        public sealed class CopyLiveTemplete : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.LiveTemplates;component/resources/LiveTemplatesThemedIcons/Th" +
            "emedIcons.LiveTemplates.Generated.Xaml", 12, "DeleteLiveTemplate")]
        public sealed class DeleteLiveTemplate : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.LiveTemplates;component/resources/LiveTemplatesThemedIcons/Th" +
            "emedIcons.LiveTemplates.Generated.Xaml", 15, "EditTemplate")]
        public sealed class EditTemplate : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.LiveTemplates;component/resources/LiveTemplatesThemedIcons/Th" +
            "emedIcons.LiveTemplates.Generated.Xaml", 5, "ExportLiveTemplate")]
        public sealed class ExportLiveTemplate : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.LiveTemplates;component/resources/LiveTemplatesThemedIcons/Th" +
            "emedIcons.LiveTemplates.Generated.Xaml", 14, "FilterLiveTemplate")]
        public sealed class FilterLiveTemplate : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.LiveTemplates;component/resources/LiveTemplatesThemedIcons/Th" +
            "emedIcons.LiveTemplates.Generated.Xaml", 8, "ImportLiveTemplate")]
        public sealed class ImportLiveTemplate : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.LiveTemplates;component/resources/LiveTemplatesThemedIcons/Th" +
            "emedIcons.LiveTemplates.Generated.Xaml", 7, "LiveTemplatesToolWindow")]
        public sealed class LiveTemplatesToolWindow : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.LiveTemplates;component/resources/LiveTemplatesThemedIcons/Th" +
            "emedIcons.LiveTemplates.Generated.Xaml", 2, "ManageLayers")]
        public sealed class ManageLayers : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.LiveTemplates;component/resources/LiveTemplatesThemedIcons/Th" +
            "emedIcons.LiveTemplates.Generated.Xaml", 6, "MoveLiveTemplate")]
        public sealed class MoveLiveTemplate : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.LiveTemplates;component/resources/LiveTemplatesThemedIcons/Th" +
            "emedIcons.LiveTemplates.Generated.Xaml", 10, "NewFolderLiveTemplate")]
        public sealed class NewFolderLiveTemplate : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.LiveTemplates;component/resources/LiveTemplatesThemedIcons/Th" +
            "emedIcons.LiveTemplates.Generated.Xaml", 9, "ScopeVB")]
        public sealed class ScopeVB : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.LiveTemplates;component/resources/LiveTemplatesThemedIcons/Th" +
            "emedIcons.LiveTemplates.Generated.Xaml", 11, "ShowPredefinedTemplates")]
        public sealed class ShowPredefinedTemplates : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
    }
}
namespace JetBrains.ReSharper.LiveTemplates.src.UI.TemplateEditor
{
    
    [JetBrains.UI.Wpf.ViewAttribute(JetBrains.UI.Wpf.ViewKind.Wpf)]
    public class FieldView : System.Windows.Controls.Grid, JetBrains.UI.Wpf.IView, JetBrains.UI.Wpf.IView<JetBrains.ReSharper.LiveTemplates.UI.TemplateEditor.TemplateFieldAutomation>, System.Windows.Markup.IComponentConnector
    {
        public FieldView() { }
        public void InitializeComponent() { }
    }
    [JetBrains.UI.Wpf.ViewAttribute(JetBrains.UI.Wpf.ViewKind.Wpf)]
    public class TemplateReferenceMappingView : System.Windows.Controls.Grid, JetBrains.UI.Wpf.IView, JetBrains.UI.Wpf.IView<JetBrains.ReSharper.LiveTemplates.UI.TemplateEditor.TemplateReferenceMappingAutomation>, System.Windows.Markup.IComponentConnector
    {
        public TemplateReferenceMappingView() { }
        public void InitializeComponent() { }
    }
    [JetBrains.UI.Wpf.ViewAttribute(JetBrains.UI.Wpf.ViewKind.Wpf)]
    public class TemplateReferenceSectionView : System.Windows.Controls.StackPanel, JetBrains.UI.Wpf.IView, JetBrains.UI.Wpf.IView<JetBrains.ReSharper.LiveTemplates.UI.TemplateEditor.TemplateReferenceSectionAutomation>, System.Windows.Markup.IComponentConnector
    {
        public TemplateReferenceSectionView() { }
        public void InitializeComponent() { }
    }
    [JetBrains.UI.Wpf.ViewAttribute(JetBrains.UI.Wpf.ViewKind.Wpf)]
    public class VariableMacroParameterView : System.Windows.Controls.UserControl, JetBrains.UI.Wpf.IView, JetBrains.UI.Wpf.IView<JetBrains.ReSharper.LiveTemplates.UI.TemplateEditor.VariableMacroParameterAutomation>, System.Windows.Markup.IComponentConnector
    {
        public VariableMacroParameterView() { }
        public void InitializeComponent() { }
    }
}
namespace JetBrains.ReSharper.LiveTemplates.Surround
{
    
    public class static SurroundUtil
    {
        public static JetBrains.ReSharper.LiveTemplates.Templates.Template ChooseTemplateByDialog(JetBrains.TextControl.ITextControl textControl, System.Collections.Generic.List<JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint> realScopePoints) { }
    }
}
namespace JetBrains.ReSharper.LiveTemplates.TemplateBuilder
{
    
    public abstract class FieldEvaluatorBase : JetBrains.ReSharper.Feature.Services.LiveTemplates.Builder.IFieldEvaluator, JetBrains.ReSharper.Psi.IRecursiveElementProcessor
    {
        public FieldEvaluatorBase(JetBrains.ReSharper.Feature.Services.LiveTemplates.Builder.CollectedFields context) { }
        protected JetBrains.ReSharper.Feature.Services.LiveTemplates.Builder.CollectedFields Context { get; }
        public OptionalField[] Fields { get; }
        public bool ProcessingIsFinished { get; }
        protected void AddField(JetBrains.ReSharper.Feature.Services.LiveTemplates.Builder.TemplateBuilderResult.OptionalField field) { }
        public bool InteriorShouldBeProcessed(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public void ProcessAfterInterior(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public void ProcessBeforeInterior(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public abstract void ProcessElement(JetBrains.ReSharper.Psi.Tree.ITreeNode element);
        public string SuggestFieldName(string baseName) { }
    }
    public class FieldNameTextChange : JetBrains.ReSharper.Feature.Services.LiveTemplates.Builder.TextChangeBase
    {
        public FieldNameTextChange(JetBrains.Util.TextRange range, JetBrains.ReSharper.LiveTemplates.TemplateField templateField) { }
        protected override string GetNewText(string oldText) { }
    }
    public class SimpleTextChange : JetBrains.ReSharper.Feature.Services.LiveTemplates.Builder.TextChangeBase
    {
        public SimpleTextChange(JetBrains.Util.TextRange range, string newText) { }
        protected override string GetNewText(string oldText) { }
    }
    public class SurroundTextChange : JetBrains.ReSharper.Feature.Services.LiveTemplates.Builder.TextChangeBase
    {
        public SurroundTextChange(JetBrains.Util.TextRange range, string openText, string closeText) { }
        protected override string GetNewText(string oldText) { }
    }
    public abstract class TemplateBuilder
    {
        public abstract JetBrains.ReSharper.Feature.Services.LiveTemplates.Builder.TemplateBuilderResult CreateTemplate(JetBrains.DocumentModel.DocumentRange documentRange);
        public static JetBrains.ReSharper.LiveTemplates.TemplateBuilder.TemplateBuilder GetInstance(JetBrains.ProjectModel.ISolution solution) { }
    }
    public class TemplateBuildingData
    {
        public TemplateBuildingData(JetBrains.ReSharper.Feature.Services.LiveTemplates.Builder.TemplateBuilderResult templateBuilderResult) { }
        public JetBrains.ReSharper.Feature.Services.LiveTemplates.Builder.TemplateBuilderResult TemplateBuilderResult { get; }
        public bool IsSelected(JetBrains.ReSharper.Feature.Services.LiveTemplates.Builder.TemplateBuilderResult.OptionalField optionalField) { }
        public void Select(JetBrains.ReSharper.Feature.Services.LiveTemplates.Builder.TemplateBuilderResult.OptionalField optionalField) { }
        public void Unselect(JetBrains.ReSharper.Feature.Services.LiveTemplates.Builder.TemplateBuilderResult.OptionalField optionalField) { }
    }
}
namespace JetBrains.ReSharper.LiveTemplates.UI
{
    
    public class DescriptionFormatter
    {
        public DescriptionFormatter(JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.MacroCallExpressionNew macroCallExpression) { }
        public string DescriptionString { get; }
        public bool FormatActive { get; set; }
        public JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.MacroCallExpressionNew MacroCallExpression { get; }
        public JetBrains.Util.TextRange[] Ranges { get; }
        public JetBrains.UI.RichText.RichText RichText { get; }
        public int GetParameterByRange(int range) { }
    }
    public class EditorFieldInfo
    {
        public EditorFieldInfo(JetBrains.ReSharper.LiveTemplates.TemplateField field) { }
        public JetBrains.ReSharper.LiveTemplates.TemplateField Field { get; }
        public int Occurences { get; set; }
    }
    public class FieldsSelectionDialog : System.Windows.Forms.Form
    {
        public FieldsSelectionDialog(JetBrains.ReSharper.LiveTemplates.TemplateBuilder.TemplateBuildingData templateBuildingData, JetBrains.UI.Application.IUIApplication environment) { }
        protected override void Dispose(bool disposing) { }
    }
    public class ParameterReference
    {
        public ParameterReference(int parameterIndex) { }
        public int ParameterIndex { get; }
    }
    public class TemplateChooserDialog : System.Windows.Forms.Form
    {
        public TemplateChooserDialog(JetBrains.DataFlow.Lifetime lifetime, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.LiveTemplates.Support.QuickListSupport> quickListSupports, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint> realScopePoints, System.Func<JetBrains.DataFlow.Lifetime, JetBrains.Application.DataContext.DataContexts, JetBrains.Application.DataContext.IDataContext> dataContext, JetBrains.ReSharper.Feature.Services.LiveTemplates.Settings.TemplateApplicability applicability) { }
        public TemplateChooserDialog(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.LiveTemplates.Support.QuickListSupport> quickListSupports, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint> realScopePoints, JetBrains.Application.Settings.IContextBoundSettingsStore boundStore, JetBrains.ReSharper.Feature.Services.LiveTemplates.Settings.TemplateApplicability applicability, JetBrains.DataFlow.Lifetime lifetime = null) { }
        public JetBrains.ReSharper.LiveTemplates.Templates.Template Template { get; }
        protected override void Dispose(bool disposing) { }
    }
    public class TemplateTextEditor : JetBrains.UI.CommonControls.SafePanel
    {
        public TemplateTextEditor(JetBrains.UI.WindowManagement.WindowFrame frame, JetBrains.UI.Application.IUIApplication uiapp) { }
        public JetBrains.ReSharper.LiveTemplates.Templates.Template Template { set; }
        public override string Text { get; set; }
        public void ApplyColorTheme(JetBrains.UI.Components.Theming.ColorTheme theme) { }
        protected override void Dispose(bool disposing) { }
    }
}
namespace JetBrains.ReSharper.LiveTemplates.UI.TemplateEditor
{
    
    public class ConstantMacroParameterAutomation : JetBrains.ReSharper.LiveTemplates.UI.TemplateEditor.MacroParameterAutomationBase
    {
        public ConstantMacroParameterAutomation(JetBrains.DataFlow.Lifetime lifetime, string name, string value = null) { }
    }
    [JetBrains.UI.Wpf.ViewAttribute(JetBrains.UI.Wpf.ViewKind.Wpf)]
    public class ConstantMacroParameterView : System.Windows.Controls.UserControl, JetBrains.UI.Wpf.IView, JetBrains.UI.Wpf.IView<JetBrains.ReSharper.LiveTemplates.UI.TemplateEditor.ConstantMacroParameterAutomation>, System.Windows.Markup.IComponentConnector
    {
        public ConstantMacroParameterView() { }
        public void InitializeComponent() { }
    }
    public class FieldOccurenceAutomation : System.IComparable<JetBrains.ReSharper.LiveTemplates.UI.TemplateEditor.FieldOccurenceAutomation>
    {
        public FieldOccurenceAutomation(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ReSharper.LiveTemplates.UI.TemplateEditor.TemplateTextSectionAutomation section, int number, JetBrains.ReSharper.LiveTemplates.UI.TemplateEditor.TemplateAutomation template) { }
        public JetBrains.DataFlow.IProperty<string> Description { get; }
        public System.Guid Guid { get; }
        public int Number { get; }
        public JetBrains.ReSharper.LiveTemplates.UI.TemplateEditor.TemplateTextSectionAutomation Section { get; }
        public int CompareTo(JetBrains.ReSharper.LiveTemplates.UI.TemplateEditor.FieldOccurenceAutomation other) { }
        public override string ToString() { }
        public void UpdateDescription() { }
    }
    public class FieldOccurenceComparer : System.Collections.Generic.IComparer<JetBrains.ReSharper.LiveTemplates.UI.TemplateEditor.FieldOccurenceAutomation>
    {
        public int Compare(JetBrains.ReSharper.LiveTemplates.UI.TemplateEditor.FieldOccurenceAutomation x, JetBrains.ReSharper.LiveTemplates.UI.TemplateEditor.FieldOccurenceAutomation y) { }
    }
    public class FieldOrder
    {
        public FieldOrder(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ReSharper.LiveTemplates.UI.TemplateEditor.TemplateAutomation template) { }
        public JetBrains.ReSharper.LiveTemplates.UI.TemplateEditor.ITemplateFieldRegister GetRegister(JetBrains.DataFlow.Lifetime l, System.Guid sectionGuid) { }
    }
    public interface IFieldEditableOccurence : JetBrains.UI.Wpf.IAutomation, System.ComponentModel.INotifyPropertyChanged { }
    public interface ITemplateEditor
    {
        void Activate();
    }
    public interface ITemplateFieldRegister
    {
        bool RegisterFieldOccurence(string fieldOrKeyword);
    }
    public abstract class MacroParameterAutomationBase : JetBrains.UI.Wpf.AAutomation
    {
        protected MacroParameterAutomationBase(JetBrains.DataFlow.Lifetime lifetime, string name, string value = null) { }
        public JetBrains.DataFlow.SimpleSignal Changed { get; }
        public JetBrains.DataFlow.IProperty<string> Name { get; }
        public JetBrains.DataFlow.IProperty<string> TextValue { get; }
        public virtual JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.IMacroParameterValue CreateMacroParameterValue() { }
    }
    public class MultipleEditableOccurence : JetBrains.UI.Wpf.AAutomation, JetBrains.ReSharper.LiveTemplates.UI.TemplateEditor.IFieldEditableOccurence, JetBrains.UI.Wpf.IAutomation, System.ComponentModel.INotifyPropertyChanged
    {
        public MultipleEditableOccurence(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ReSharper.LiveTemplates.UI.TemplateEditor.TemplateFieldAutomation field) { }
        public JetBrains.DataFlow.ListEvents<JetBrains.ReSharper.LiveTemplates.UI.TemplateEditor.FieldOccurenceAutomation> Ranges { get; }
        public JetBrains.DataFlow.Property<JetBrains.ReSharper.LiveTemplates.UI.TemplateEditor.FieldOccurenceAutomation> SelectedRange { get; }
        public override string ToString() { }
    }
    [JetBrains.UI.Wpf.ViewAttribute(JetBrains.UI.Wpf.ViewKind.Wpf)]
    public class MultipleEditableOccurenceView : System.Windows.Controls.UserControl, JetBrains.UI.Wpf.IView, JetBrains.UI.Wpf.IView<JetBrains.ReSharper.LiveTemplates.UI.TemplateEditor.MultipleEditableOccurence>, System.Windows.Markup.IComponentConnector
    {
        public MultipleEditableOccurenceView() { }
        public void InitializeComponent() { }
    }
    public class SingleEditableOccurence : JetBrains.UI.Wpf.AAutomation, JetBrains.ReSharper.LiveTemplates.UI.TemplateEditor.IFieldEditableOccurence, JetBrains.UI.Wpf.IAutomation, System.ComponentModel.INotifyPropertyChanged
    {
        public SingleEditableOccurence(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ReSharper.LiveTemplates.UI.TemplateEditor.TemplateFieldAutomation field) { }
        public JetBrains.DataFlow.IProperty<bool> IsEditable { get; }
        public override string ToString() { }
    }
    [JetBrains.UI.Wpf.ViewAttribute(JetBrains.UI.Wpf.ViewKind.Wpf)]
    public class SingleEditableOccurenceView : System.Windows.Controls.UserControl, JetBrains.UI.Wpf.IView, JetBrains.UI.Wpf.IView<JetBrains.ReSharper.LiveTemplates.UI.TemplateEditor.SingleEditableOccurence>, System.Windows.Markup.IComponentConnector
    {
        public SingleEditableOccurenceView() { }
        public void InitializeComponent() { }
    }
    public class TemplateAutomation : JetBrains.UI.Wpf.AAutomation
    {
        public TemplateAutomation(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ReSharper.LiveTemplates.Templates.Template template, JetBrains.ReSharper.Feature.Services.LiveTemplates.Settings.StoredTemplatesProvider storedTemplatesProvider, JetBrains.Application.Settings.IContextBoundSettingsStore boundStore, JetBrains.ReSharper.Feature.Services.LiveTemplates.Storages.StoragesLegacyHacks storagesLegacyHacks) { }
        public System.Windows.Input.ICommand AddReferenceCommand { get; }
        public System.Windows.Input.ICommand AddSectionCommand { get; }
        public JetBrains.DataFlow.ListEvents<JetBrains.ReSharper.Feature.Services.LiveTemplates.Settings.TemplateApplicability> Applicabilities { get; }
        public JetBrains.DataFlow.SimpleSignal Changed { get; }
        public JetBrains.DataFlow.IProperty<int> ChangedCount { get; }
        public System.Windows.Input.ICommand ChangeScopeCommand { get; }
        public JetBrains.DataFlow.IProperty<string> DefaultFileName { get; }
        public JetBrains.DataFlow.IProperty<string> Description { get; }
        public JetBrains.DataFlow.IProperty<string> DescriptionError { get; }
        public JetBrains.DataFlow.IProperty<System.Windows.Visibility> DescriptionErrorVisibility { get; }
        public JetBrains.DataFlow.SimpleSignal DoRehighlight { get; }
        public JetBrains.ReSharper.LiveTemplates.UI.TemplateEditor.FieldOrder FieldOrder { get; }
        public JetBrains.DataFlow.SimpleSignal FieldRehighlightRequested { get; }
        public JetBrains.DataFlow.ListEvents<JetBrains.ReSharper.LiveTemplates.UI.TemplateEditor.TemplateFieldAutomation> Fields { get; }
        public JetBrains.DataFlow.ListEvents<JetBrains.ReSharper.LiveTemplates.UI.TemplateEditor.TemplateFieldAutomation> FieldsOrdered { get; }
        public JetBrains.DataFlow.IProperty<System.Windows.Visibility> FilenameVisiblility { get; }
        public JetBrains.DataFlow.IProperty<bool> IsMoveDownEnabled { get; }
        public JetBrains.DataFlow.IProperty<bool> IsMoveUpEnabled { get; }
        public JetBrains.DataFlow.IProperty<bool> IsOptimiseSelected { get; }
        public JetBrains.DataFlow.IProperty<bool> IsReformatSelected { get; }
        public System.Windows.Input.ICommand MoveDownCommand { get; }
        public JetBrains.DataFlow.Property<double> MoveDownOpacity { get; }
        public System.Windows.Input.ICommand MoveUpCommand { get; }
        public JetBrains.DataFlow.Property<double> MoveUpOpacity { get; }
        public JetBrains.DataFlow.IProperty<string> ScopeDescription { get; }
        public JetBrains.DataFlow.ListEvents<JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint> ScopePoints { get; }
        public JetBrains.DataFlow.ListEvents<JetBrains.ReSharper.LiveTemplates.UI.TemplateEditor.TemplateSectionAutomation> Sections { get; }
        public JetBrains.DataFlow.IProperty<JetBrains.ReSharper.LiveTemplates.UI.TemplateEditor.TemplateFieldAutomation> SelectedField { get; }
        public JetBrains.DataFlow.IProperty<string> Shortcut { get; }
        public JetBrains.DataFlow.IProperty<string> ShortcutError { get; }
        public JetBrains.DataFlow.Property<System.Windows.Visibility> ShortcutErrorVisibility { get; set; }
        public JetBrains.DataFlow.IProperty<System.Windows.Visibility> ShortcutVisibility { get; }
        public JetBrains.DataFlow.IProperty<JetBrains.ReSharper.LiveTemplates.UI.TemplateEditor.TemplateContentAutomation> TemplateContent { get; }
        public JetBrains.DataFlow.IProperty<string> TemplatePresentableName { get; }
        public JetBrains.DataFlow.IProperty<JetBrains.ReSharper.LiveTemplates.UI.TemplateEditor.TemplateTextAutomation> TextAutomation { get; }
        public JetBrains.DataFlow.IProperty<bool> ValidateFileName { get; }
        public void PurgeEmptyFields() { }
        public void SaveToTemplate(JetBrains.ReSharper.LiveTemplates.Templates.Template template) { }
    }
    public class TemplateContentAutomation : JetBrains.UI.Wpf.AAutomation
    {
        public TemplateContentAutomation(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ReSharper.LiveTemplates.UI.TemplateEditor.TemplateAutomation template) { }
        public JetBrains.ReSharper.LiveTemplates.UI.TemplateEditor.TemplateAutomation Template { get; }
    }
    [JetBrains.UI.Wpf.ViewAttribute(JetBrains.UI.Wpf.ViewKind.Wpf)]
    public class TemplateContentView : JetBrains.UI.Wpf.ViewControl<JetBrains.ReSharper.LiveTemplates.UI.TemplateEditor.TemplateContentAutomation>
    {
        protected override System.Windows.UIElement OnRenderView(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ReSharper.LiveTemplates.UI.TemplateEditor.TemplateContentAutomation automation) { }
    }
    public class TemplateEditor : JetBrains.ReSharper.LiveTemplates.UI.TemplateEditor.ITemplateEditor
    {
        public TemplateEditor(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ReSharper.LiveTemplates.Templates.Template template, string docMoniker, JetBrains.IDE.PersistableViewManager persistableViewManager, JetBrains.ReSharper.Feature.Services.LiveTemplates.Settings.StoredTemplatesProvider storedTemplatesProvider, JetBrains.Application.Settings.IContextBoundSettingsStore boundStore, JetBrains.ReSharper.Feature.Services.LiveTemplates.Storages.StoragesLegacyHacks storagesLegacyHacks, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.LiveTemplates.UI.TemplateEditor.TemplateEditorManager.ITemplateEditorTracker tracker) { }
        public void Activate() { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class TemplateEditorManager : System.IDisposable
    {
        public TemplateEditorManager(JetBrains.DataFlow.Lifetime lifetime, JetBrains.UI.Application.IUIApplication environment, JetBrains.IDE.PersistableViewManager persistableViewManager, JetBrains.ReSharper.Feature.Services.LiveTemplates.Settings.StoredTemplatesProvider storedTemplatedProvider, JetBrains.ReSharper.Feature.Services.LiveTemplates.Storages.StoragesLegacyHacks storagesLegacyHacks) { }
        public static JetBrains.ReSharper.LiveTemplates.UI.TemplateEditor.TemplateEditorManager Instance { get; }
        public void CreateTemplate(JetBrains.ReSharper.LiveTemplates.Templates.Template template, JetBrains.Application.Settings.IContextBoundSettingsStore boundStore = null) { }
        public void Dispose() { }
        public void EditTemplate(JetBrains.ReSharper.LiveTemplates.Templates.Template template, JetBrains.Application.Settings.IContextBoundSettingsStore boundStore = null) { }
        public interface ITemplateEditorTracker
        {
            void UnregisterEditor(JetBrains.ReSharper.LiveTemplates.UI.TemplateEditor.ITemplateEditor editor);
        }
    }
    [JetBrains.UI.Wpf.ViewAttribute(JetBrains.UI.Wpf.ViewKind.Wpf)]
    public class TemplateEditorViewControl : System.Windows.Controls.Grid, JetBrains.UI.Wpf.IView, JetBrains.UI.Wpf.IView<JetBrains.ReSharper.LiveTemplates.UI.TemplateEditor.TemplateAutomation>, System.Windows.Markup.IComponentConnector
    {
        public TemplateEditorViewControl() { }
        public void InitializeComponent() { }
    }
    public class TemplateFieldAutomation : JetBrains.UI.Wpf.AAutomation
    {
        public bool UpdatingOccurences;
        public TemplateFieldAutomation(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ReSharper.LiveTemplates.TemplateField field, JetBrains.ReSharper.LiveTemplates.UI.TemplateEditor.TemplateAutomation template) { }
        public System.Windows.Input.ICommand ChooseMacroCommand { get; }
        public JetBrains.DataFlow.IProperty<string> DescriptionText { get; }
        public JetBrains.DataFlow.IProperty<JetBrains.ReSharper.LiveTemplates.UI.TemplateEditor.IFieldEditableOccurence> EditableOccurence { get; }
        public JetBrains.DataFlow.IProperty<JetBrains.CommonControls.ActiveRichText.FormattedText> FormattedDescription { get; }
        public JetBrains.DataFlow.SimpleSignal InitialChanged { get; }
        public JetBrains.DataFlow.IProperty<int> InitialRange { get; }
        public JetBrains.DataFlow.IProperty<System.Guid> InitialSection { get; }
        public JetBrains.DataFlow.IProperty<JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.IMacroDefinition> Macro { get; }
        public JetBrains.DataFlow.IProperty<string> Name { get; }
        public JetBrains.DataFlow.IProperty<int> OccurenceCount { get; }
        public JetBrains.DataFlow.ListEvents<JetBrains.ReSharper.LiveTemplates.UI.TemplateEditor.FieldOccurenceAutomation> OccurenceList { get; set; }
        public JetBrains.DataFlow.ListEvents<JetBrains.ReSharper.LiveTemplates.UI.TemplateEditor.MacroParameterAutomationBase> Parameters { get; set; }
        public JetBrains.DataFlow.IDictionaryEvents<System.Guid, int> PlainOccurenceCount { get; set; }
        public JetBrains.ReSharper.LiveTemplates.UI.TemplateEditor.MacroParameterAutomationBase CreateParameterAutomation(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.ParameterInfo parameterInfo, string name, JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.IMacroParameterValue value = null) { }
        public JetBrains.CommonControls.ActiveRichText.FormattedText GetFormattedDescription(JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.IMacroDefinition macro, System.Collections.Generic.IList<JetBrains.ReSharper.LiveTemplates.UI.TemplateEditor.MacroParameterAutomationBase> parameters) { }
        public int GetSectionOccurences(System.Guid sectionGuid) { }
        public void SetSectionOccurences(System.Guid sectionGuid, int value, bool bulkUpdate = True) { }
    }
    public class TemplateReferenceMappingAutomation : JetBrains.UI.Wpf.AAutomation
    {
        public const string UnchangedValue = "<Unchanged>";
        public TemplateReferenceMappingAutomation(JetBrains.DataFlow.Lifetime lifetime, string refField, string localField, JetBrains.ReSharper.LiveTemplates.UI.TemplateEditor.TemplateAutomation template) { }
        public JetBrains.DataFlow.IProperty<string> LocalField { get; }
        public JetBrains.DataFlow.ListEvents<string> LocalFields { get; }
        public JetBrains.DataFlow.IProperty<string> ReferenceField { get; }
    }
    public class TemplateReferenceSectionAutomation : JetBrains.ReSharper.LiveTemplates.UI.TemplateEditor.TemplateSectionAutomation
    {
        public TemplateReferenceSectionAutomation(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ReSharper.LiveTemplates.UI.TemplateEditor.TemplateAutomation parent, JetBrains.ReSharper.LiveTemplates.Templates.TemplateReferenceSection section, JetBrains.ReSharper.LiveTemplates.Templates.Template referencedTemplate) { }
        public JetBrains.DataFlow.ListEvents<JetBrains.ReSharper.LiveTemplates.UI.TemplateEditor.TemplateReferenceMappingAutomation> Mappings { get; }
        public JetBrains.DataFlow.IProperty<string> TemplateDescription { get; }
        protected override JetBrains.ReSharper.LiveTemplates.Templates.TemplateSection CreateNewSectionModel() { }
    }
    public abstract class TemplateSectionAutomation : JetBrains.UI.Wpf.AAutomation, JetBrains.ReSharper.Feature.Services.LiveTemplates.FileTemplates.ITemplateSectionAutomation
    {
        protected TemplateSectionAutomation(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ReSharper.LiveTemplates.UI.TemplateEditor.TemplateAutomation parent, JetBrains.ReSharper.LiveTemplates.Templates.TemplateSection section) { }
        public JetBrains.DataFlow.IProperty<JetBrains.ReSharper.Feature.Services.LiveTemplates.FileTemplates.ISectionFilenameSelector> CurrentSelector { get; }
        public JetBrains.DataFlow.IProperty<JetBrains.ReSharper.Feature.Services.LiveTemplates.FileTemplates.ISectionLocationAutomation> CurrentSelectorAutomation { get; }
        public System.Guid Guid { get; }
        public JetBrains.DataFlow.IProperty<string> MainFilename { get; }
        public System.Windows.Input.ICommand RemoveSectionCommand { get; }
        public JetBrains.DataFlow.ListEvents<JetBrains.ReSharper.Feature.Services.LiveTemplates.FileTemplates.ISectionFilenameSelector> Selectors { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        protected abstract JetBrains.ReSharper.LiveTemplates.Templates.TemplateSection CreateNewSectionModel();
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ReSharper.LiveTemplates.Templates.TemplateSection GetTemplateSectionModel() { }
    }
    public class TemplateTextAutomation : JetBrains.UI.Wpf.AAutomation
    {
        public TemplateTextAutomation(JetBrains.DataFlow.Lifetime lifetime, string text, JetBrains.ReSharper.LiveTemplates.UI.TemplateEditor.TemplateAutomation template, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.LiveTemplates.UI.TemplateEditor.TemplateTextSectionAutomation section = null) { }
        public JetBrains.ReSharper.LiveTemplates.UI.TemplateEditor.TemplateTextSectionAutomation Section { get; }
        public JetBrains.ReSharper.LiveTemplates.UI.TemplateEditor.TemplateAutomation Template { get; }
        public JetBrains.DataFlow.IProperty<string> Text { get; }
    }
    public class static TemplateTextHighlighterAttributeIds
    {
        public const string KEYWORD_ATTRIBUTE = "ReSharper Template Editor Template Keyword";
    }
    public class TemplateTextSectionAutomation : JetBrains.ReSharper.LiveTemplates.UI.TemplateEditor.TemplateSectionAutomation
    {
        public TemplateTextSectionAutomation(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ReSharper.LiveTemplates.UI.TemplateEditor.TemplateAutomation parent, JetBrains.ReSharper.LiveTemplates.Templates.TemplateTextSection section) { }
        public JetBrains.DataFlow.IProperty<double> ParentHeight { get; set; }
        public JetBrains.DataFlow.IProperty<JetBrains.ReSharper.LiveTemplates.UI.TemplateEditor.TemplateTextAutomation> TextAutomation { get; }
        protected override JetBrains.ReSharper.LiveTemplates.Templates.TemplateSection CreateNewSectionModel() { }
    }
    [JetBrains.UI.Wpf.ViewAttribute(JetBrains.UI.Wpf.ViewKind.Wpf)]
    public class TemplateTextSectionView : JetBrains.UI.Wpf.ViewControl<JetBrains.ReSharper.LiveTemplates.UI.TemplateEditor.TemplateTextSectionAutomation>
    {
        public TemplateTextSectionView() { }
        protected override System.Windows.UIElement OnRenderView(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ReSharper.LiveTemplates.UI.TemplateEditor.TemplateTextSectionAutomation automation) { }
    }
    [JetBrains.UI.Wpf.ViewAttribute(JetBrains.UI.Wpf.ViewKind.Wpf)]
    public class TemplateTextViewControl : JetBrains.UI.Wpf.ViewControl<JetBrains.ReSharper.LiveTemplates.UI.TemplateEditor.TemplateTextAutomation>
    {
        protected override System.Windows.UIElement OnRenderView(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ReSharper.LiveTemplates.UI.TemplateEditor.TemplateTextAutomation automation) { }
        public void UpdateHighlighting() { }
    }
    public class TypeMacroParameterAutomation : JetBrains.ReSharper.LiveTemplates.UI.TemplateEditor.MacroParameterAutomationBase
    {
        public TypeMacroParameterAutomation(JetBrains.DataFlow.Lifetime lifetime, string name, string value = null) { }
        public System.Windows.Input.ICommand SetTypeCommand { get; }
        public JetBrains.DataFlow.IProperty<System.Windows.Visibility> SetTypeEnabled { get; }
    }
    [JetBrains.UI.Wpf.ViewAttribute(JetBrains.UI.Wpf.ViewKind.Wpf)]
    public class TypeMacroParameterView : System.Windows.Controls.UserControl, JetBrains.UI.Wpf.IView, JetBrains.UI.Wpf.IView<JetBrains.ReSharper.LiveTemplates.UI.TemplateEditor.TypeMacroParameterAutomation>, System.Windows.Markup.IComponentConnector
    {
        public TypeMacroParameterView() { }
        public void InitializeComponent() { }
    }
    public class VariableMacroParameterAutomation : JetBrains.ReSharper.LiveTemplates.UI.TemplateEditor.MacroParameterAutomationBase
    {
        public VariableMacroParameterAutomation(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ReSharper.LiveTemplates.UI.TemplateEditor.TemplateFieldAutomation field, JetBrains.ReSharper.LiveTemplates.UI.TemplateEditor.TemplateAutomation template, string name, string value = null) { }
        public JetBrains.DataFlow.ListEvents<string> LocalFields { get; set; }
        public JetBrains.DataFlow.IProperty<string> SelectedField { get; }
        public override JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.IMacroParameterValue CreateMacroParameterValue() { }
    }
}
namespace JetBrains.ReSharper.LiveTemplates.UI.Theming
{
    
    public class LiveTemplateColor : JetBrains.UI.Components.Theming.ThemeColor
    {
        public static readonly JetBrains.ReSharper.LiveTemplates.UI.Theming.LiveTemplateColor LTHeaderGradientBase;
        public static readonly JetBrains.ReSharper.LiveTemplates.UI.Theming.LiveTemplateColor LTHeaderGradientEnd;
        public static readonly JetBrains.ReSharper.LiveTemplates.UI.Theming.LiveTemplateColor LTHeaderGradientStart;
        public static readonly JetBrains.ReSharper.LiveTemplates.UI.Theming.LiveTemplateColor LTInternalBorder;
        public static readonly JetBrains.ReSharper.LiveTemplates.UI.Theming.LiveTemplateColor LTPreviewField;
        public static readonly JetBrains.ReSharper.LiveTemplates.UI.Theming.LiveTemplateColor LTPreviewKeyword;
        public static readonly JetBrains.ReSharper.LiveTemplates.UI.Theming.LiveTemplateColor LTSelectedBorder;
        public static readonly JetBrains.ReSharper.LiveTemplates.UI.Theming.LiveTemplateColor LTSelectedBorderInner;
        public static readonly JetBrains.ReSharper.LiveTemplates.UI.Theming.LiveTemplateColor LTSelectedGradientEnd;
        public static readonly JetBrains.ReSharper.LiveTemplates.UI.Theming.LiveTemplateColor LTSelectedGradientStart;
        public static readonly JetBrains.ReSharper.LiveTemplates.UI.Theming.LiveTemplateColor LTSplitterBorder;
        public static readonly JetBrains.ReSharper.LiveTemplates.UI.Theming.LiveTemplateColor LTTagBackground;
        public static readonly JetBrains.ReSharper.LiveTemplates.UI.Theming.LiveTemplateColor LTTagBorder;
        public static readonly JetBrains.ReSharper.LiveTemplates.UI.Theming.LiveTemplateColor LTTagForeground;
        public static readonly JetBrains.ReSharper.LiveTemplates.UI.Theming.LiveTemplateColor LTTest;
    }
}
namespace JetBrains.ReSharper.LiveTemplates.UI.ToolWindow
{
    
    public class CategoryListItem : JetBrains.UI.Avalon.TreeListView.ObservableObject
    {
        public string AutomationName { get; }
        public string CategoryName { get; set; }
        public int Count { get; set; }
        public string DisplayText { get; }
        public bool IsAllCategories { get; set; }
    }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "LiveTemplates.CreateCategory"})]
    public class CreateCategoryActionHandler : JetBrains.ActionManagement.IActionHandler
    {
        public void Execute(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.DelegateExecute nextExecute) { }
        public bool Update(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.ActionPresentation presentation, JetBrains.ActionManagement.DelegateUpdate nextUpdate) { }
    }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "LiveTemplates.CreateTemplate"})]
    public class CreateTemplateActionHandler : JetBrains.ActionManagement.IActionHandler
    {
        public void Execute(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.DelegateExecute nextExecute) { }
        public bool Update(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.ActionPresentation presentation, JetBrains.ActionManagement.DelegateUpdate nextUpdate) { }
    }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "LiveTemplates.Delete"})]
    public class DeleteCategoriesActionHandler : JetBrains.ActionManagement.IActionHandler
    {
        public void Execute(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.DelegateExecute nextExecute) { }
        public bool Update(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.ActionPresentation presentation, JetBrains.ActionManagement.DelegateUpdate nextUpdate) { }
    }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "LiveTemplates.Delete"})]
    public class DeleteTemplatesActionHandler : JetBrains.ActionManagement.IActionHandler
    {
        public DeleteTemplatesActionHandler() { }
        public void Execute(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.DelegateExecute nextExecute) { }
        public bool Update(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.ActionPresentation presentation, JetBrains.ActionManagement.DelegateUpdate nextUpdate) { }
    }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "LiveTemplates.EditTemplate"})]
    public class EditTemplateActionHandler : JetBrains.ActionManagement.IActionHandler
    {
        public void Execute(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.DelegateExecute nextExecute) { }
        public bool Update(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.ActionPresentation presentation, JetBrains.ActionManagement.DelegateUpdate nextUpdate) { }
    }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "LiveTemplates.Export"})]
    public class ExportTemplatesActionHandler : JetBrains.ActionManagement.IActionHandler
    {
        public ExportTemplatesActionHandler() { }
        public void Execute(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.DelegateExecute nextExecute) { }
        public bool Update(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.ActionPresentation presentation, JetBrains.ActionManagement.DelegateUpdate nextUpdate) { }
    }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "LiveTemplates.Import"})]
    public class ImportTemplatesActionHandler : JetBrains.ActionManagement.IActionHandler
    {
        public ImportTemplatesActionHandler() { }
        public void Execute(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.DelegateExecute nextExecute) { }
        public bool Update(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.ActionPresentation presentation, JetBrains.ActionManagement.DelegateUpdate nextUpdate) { }
    }
    public interface IWithDisplayText
    {
        string DisplayText { get; }
    }
    [JetBrains.UI.ToolWindowManagement.ToolWindowDescriptorAttribute(Icon=typeof(JetBrains.ReSharper.LiveTemplates.Resources.LiveTemplatesThemedIcons.LiveTemplatesToolWindow), ProductNeutralId="ToolWindowID_LiveTemplates", Text="Templates Explorer", Type=JetBrains.UI.ToolWindowManagement.ToolWindowType.SingleInstance, VisibilityPersistenceScope=JetBrains.UI.ToolWindowManagement.ToolWindowVisibilityPersistenceScope.Global)]
    public class LiveTemplatesToolWindowDescriptor : JetBrains.UI.ToolWindowManagement.ToolWindowDescriptor
    {
        public LiveTemplatesToolWindowDescriptor(JetBrains.Application.IApplicationDescriptor applicationDescriptor) { }
    }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "LiveTemplates.ManageProviders"})]
    public class ManageProvidersActionHandler : JetBrains.ActionManagement.IActionHandler
    {
        public void Execute(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.DelegateExecute nextExecute) { }
        public bool Update(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.ActionPresentation presentation, JetBrains.ActionManagement.DelegateUpdate nextUpdate) { }
    }
    public class QuickListEntryColorConverter : System.Windows.Data.IValueConverter
    {
        public System.Windows.Media.Brush AbsentBrush { set; }
        public System.Windows.Media.Brush PresentBrush { set; }
        public object Convert(object value, System.Type targetType, object parameter, System.Globalization.CultureInfo culture) { }
        public object ConvertBack(object value, System.Type targetType, object parameter, System.Globalization.CultureInfo culture) { }
    }
    public class QuickListItem : System.Windows.DependencyObject, JetBrains.ReSharper.LiveTemplates.UI.ToolWindow.IWithDisplayText
    {
        public static readonly System.Windows.DependencyProperty ShortcutProperty;
        public QuickListItem(JetBrains.ReSharper.LiveTemplates.Templates.Template template) { }
        public QuickListItem(JetBrains.ReSharper.Feature.Services.LiveTemplates.QuickLists.TemplateReference reference) { }
        public string AutomationName { get; }
        public bool CanBeRemovedFromQuickList { get; }
        public string DisplayText { get; }
        public bool HasConcreteTemplate { get; }
        public bool IsSelectable { get; }
        public string Shortcut { get; set; }
        public System.Collections.Generic.IEnumerable<string> Tags { get; }
        public JetBrains.ReSharper.LiveTemplates.Templates.Template Template { get; }
        public System.Guid TemplateUid { get; }
        public string TypeDesc { get; }
        public override string ToString() { }
    }
    public class QuickListSeparator
    {
        public string Caption { get; set; }
        public bool IsSelectable { get; }
        public bool Middle { get; set; }
    }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "LiveTemplates.RestoreOriginal"})]
    public class RestoreOriginalActionHandler : JetBrains.ActionManagement.IActionHandler
    {
        public void Execute(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.DelegateExecute nextExecute) { }
        public bool Update(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.ActionPresentation presentation, JetBrains.ActionManagement.DelegateUpdate nextUpdate) { }
    }
    public class ScopeListItem : JetBrains.UI.Avalon.TreeListView.ObservableObject
    {
        public ScopeListItem() { }
        public ScopeListItem(JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.IScopeCategoryUIProvider provider) { }
        public string AutomationName { get; }
        public string Caption { get; }
        public int Count { get; set; }
        public string DisplayCount { get; }
        public JetBrains.UI.Icons.IconId Icon { get; set; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.IScopeCategoryUIProvider Provider { get; }
    }
    public enum ScopeSelectionType
    {
        None = 0,
        Specific = 1,
        Lost = 2,
    }
    [JetBrains.ActionManagement.ActionHandlerAttribute()]
    public class ShowLiveTemplatesAction : JetBrains.UI.ToolWindowManagement.ActivateToolWindowActionHandler<JetBrains.ReSharper.LiveTemplates.UI.ToolWindow.LiveTemplatesToolWindowDescriptor> { }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "TemplatesExplorer.Filter.ShowPredefined"})]
    public class ShowPredefinedTemplatesAction : JetBrains.ActionManagement.IActionHandler
    {
        public void Execute(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.DelegateExecute nextExecute) { }
        public bool Update(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.ActionPresentation presentation, JetBrains.ActionManagement.DelegateUpdate nextUpdate) { }
    }
    public class TagListDropHandler : JetBrains.UI.Wpf.DragDrop.DefaultDropHandler
    {
        public JetBrains.ReSharper.LiveTemplates.UI.ToolWindow.TemplatesFilterPanel FilterPanel { get; set; }
        public override void DragOver(JetBrains.UI.Wpf.DragDrop.IDropInfo dropInfo) { }
        public override void Drop(JetBrains.UI.Wpf.DragDrop.IDropInfo dropInfo) { }
    }
    public class TemplateFilter
    {
        public JetBrains.ReSharper.Feature.Services.LiveTemplates.Settings.TemplateApplicability Applicability;
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.Application.Settings.IContextBoundSettingsStore BoundSettingsStore;
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.IScopeCategoryUIProvider ScopeCategoryUIProvider;
        public JetBrains.ReSharper.LiveTemplates.UI.ToolWindow.ScopeSelectionType ScopeSelection;
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly System.Collections.Generic.ICollection<System.Guid> SelectedQuickItems;
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.LiveTemplates.Templates.Template SelectedTemplate;
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly System.Collections.Generic.ICollection<JetBrains.ReSharper.LiveTemplates.Templates.Template> SelectedTemplates;
        public string Tag;
        public TemplateFilter() { }
    }
    public class TemplateFilterViewModel : JetBrains.UI.Avalon.TreeListView.ObservableObject
    {
        public System.Collections.ObjectModel.ObservableCollection<JetBrains.ReSharper.LiveTemplates.UI.ToolWindow.CategoryListItem> Categories { get; set; }
        public System.Collections.ObjectModel.ObservableCollection<JetBrains.ReSharper.LiveTemplates.UI.ToolWindow.ScopeListItem> Scopes { get; set; }
    }
    public class TemplateListDragHandler : JetBrains.UI.Wpf.DragDrop.DefaultDragHandler
    {
        public JetBrains.ReSharper.LiveTemplates.UI.ToolWindow.TemplatesFilterPanel FilterPanel { get; set; }
        public override void StartDrag(JetBrains.UI.Wpf.DragDrop.IDragInfo dragInfo) { }
    }
    public class TemplateListItem : JetBrains.UI.Avalon.TreeListView.ObservableObject, JetBrains.ReSharper.LiveTemplates.UI.ToolWindow.IWithDisplayText
    {
        public TemplateListItem(JetBrains.ReSharper.LiveTemplates.Templates.Template template) { }
        public string AutomationName { get; }
        public string DisplayText { get; }
        public bool IsChecked { get; set; }
        public bool IsSelectable { get; }
        public System.Collections.Generic.IEnumerable<string> Tags { get; }
        public JetBrains.ReSharper.LiveTemplates.Templates.Template Template { get; }
        public string TypeDesc { get; }
    }
    public class TemplatesExplorerParams
    {
        public bool ListenSettingsEvents;
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint> RealScopePoints;
        public TemplatesExplorerParams() { }
        public JetBrains.ReSharper.Feature.Services.LiveTemplates.Settings.TemplateApplicability Applicability { get; set; }
        public JetBrains.Application.Settings.IContextBoundSettingsStore InitialStore { get; set; }
        public bool ShowCheckboxes { get; set; }
        public bool ShowMnemonics { get; set; }
        public bool UseQuicklist { get; set; }
    }
    public class TemplatesExplorerTabControl : JetBrains.UI.CommonControls.SafePanel, JetBrains.Application.DataContext.IDataRuleProvider
    {
        public readonly JetBrains.DataFlow.IProperty<bool> ShowPredefined;
        public readonly JetBrains.DataFlow.Property<bool> SmartIsSelected;
        public static readonly JetBrains.Application.DataContext.DataConstant<JetBrains.ReSharper.LiveTemplates.UI.ToolWindow.TemplatesExplorerTabControl> TemplatesExplorerTabControlDataConstant;
        public static readonly JetBrains.Application.DataContext.DataConstant<JetBrains.ReSharper.LiveTemplates.UI.ToolWindow.TemplatesFilterPanel> TemplatesFilterPanelDataConstant;
        public TemplatesExplorerTabControl(JetBrains.DataFlow.Lifetime lifetime, JetBrains.UI.WindowManagement.WindowFrame windowFrame, JetBrains.ReSharper.Feature.Services.LiveTemplates.Settings.TemplateApplicability applicability, JetBrains.Application.Settings.UserInterface.UserFriendlySettingsLayers optionsContextsForEditing, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.IProperty<bool> controlIsVisible, JetBrains.UI.Application.IUIApplication uiapp) { }
        public System.Collections.Generic.IEnumerable<JetBrains.Application.DataContext.IDataRule> GetDataRules() { }
        protected override void OnCreateControl() { }
    }
    public class TemplatesFilterPanel : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector
    {
        public static readonly JetBrains.Application.DataContext.DataConstant<JetBrains.ReSharper.LiveTemplates.UI.ToolWindow.TemplateFilter> CurrentFilterDataConstant;
        public readonly JetBrains.DataFlow.SimpleSignal SelectedTemplateChanged;
        public static readonly JetBrains.Application.DataContext.DataConstant<JetBrains.ReSharper.LiveTemplates.Templates.Template> SelectedTemplateDataConstant;
        public TemplatesFilterPanel(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ReSharper.LiveTemplates.UI.ToolWindow.TemplatesExplorerParams templatesExplorerParams, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.DataFlow.IProperty<bool> controlIsVisible) { }
        public JetBrains.DataFlow.IProperty<JetBrains.Application.Settings.IContextBoundSettingsStore> BoundSettingsStore { get; }
        public bool TemplateListCanAcceptDrop { get; }
        public JetBrains.ReSharper.LiveTemplates.UI.ToolWindow.TemplatesExplorerParams TemplatesExplorerParams { get; }
        public void DropUidsToCategory([JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IEnumerable<System.Guid> droppedUids, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.LiveTemplates.UI.ToolWindow.CategoryListItem targetTag) { }
        public JetBrains.ReSharper.LiveTemplates.UI.ToolWindow.TemplateFilter GetCurrentFilter() { }
        public JetBrains.ReSharper.LiveTemplates.Templates.Template GetSelectedTemplate() { }
        public void InitializeComponent() { }
        public void SaveCurrentlyFormedQuickList() { }
        public void TagUids([JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IEnumerable<System.Guid> uids, [JetBrains.Annotations.NotNullAttribute()] string newTag) { }
    }
    public class UseQuicklistBoolToTextConverter : System.Windows.Data.IValueConverter
    {
        public object Convert(object value, System.Type targetType, object parameter, System.Globalization.CultureInfo culture) { }
        public object ConvertBack(object value, System.Type targetType, object parameter, System.Globalization.CultureInfo culture) { }
    }
}
namespace JetBrains.ReSharper.Navigation
{
    
    [JetBrains.UI.ActiveText.ProtocolHandlerAttribute(Protocol="action")]
    public class ActionProtocolHandler : JetBrains.UI.ActiveText.ProtocolHandler
    {
        protected override void NavigateNakedLink(string link, object host) { }
    }
    public interface ILinkAction
    {
        void Execute(string link);
    }
}
namespace XamlGeneratedNamespace
{
    
    public sealed class GeneratedInternalTypeHelper : System.Windows.Markup.InternalTypeHelper
    {
        protected override void AddEventHandler(System.Reflection.EventInfo eventInfo, object target, System.Delegate handler) { }
        protected override System.Delegate CreateDelegate(System.Type delegateType, object target, string handler) { }
        protected override object CreateInstance(System.Type type, System.Globalization.CultureInfo culture) { }
        protected override object GetPropertyValue(System.Reflection.PropertyInfo propertyInfo, object target, System.Globalization.CultureInfo culture) { }
        protected override void SetPropertyValue(System.Reflection.PropertyInfo propertyInfo, object target, object value, System.Globalization.CultureInfo culture) { }
    }
}