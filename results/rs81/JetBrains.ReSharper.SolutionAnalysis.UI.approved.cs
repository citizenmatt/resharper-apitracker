[assembly: JetBrains.ActionManagement.ActionsXmlAttribute("JetBrains.ReSharper.Daemon.SolutionAnalysis.UI.Resources.Actions.xml")]
[assembly: JetBrains.UI.Icons.CompiledIcons.CompiledIconsPackAttribute(IconNames=new string[] {
        "AnalyzingNoErrors8",
        "AnalyzingNoErrors4",
        "AnalyzingErrors8",
        "SolutionAnalysisPaused",
        "AnalyzingNoErrors1",
        "SolutionAnalysisNA",
        "SolutionAnalysisContinue",
        "StatusBarIndicatorBackground",
        "ErrorsGroupNode",
        "AnalyzingNoErrors7",
        "AnalyzingErrors5",
        "Loading2",
        "SolutionAnalysis",
        "AnimationErrors7",
        "AnimationNoErrors2",
        "Loading8",
        "UnignoreErrors",
        "SolutionAnalysisWarning",
        "ShowIgnoredErrors",
        "FinishedErrors",
        "ReanalyzeAllFiles",
        "AnalyzingErrors9",
        "AnalyzingNoErrors6",
        "AnimationNoErrors1",
        "AnimationLoading1",
        "SolutionAnalysisRefresh",
        "SolutionAnalysisHint",
        "AnimationLoading8",
        "Loading5",
        "AnimationNoErrors7",
        "IssueGroup",
        "AnimationErrors1",
        "AnalyzingNoErrors5",
        "AnimationNoErrors8",
        "SolutionAnalysisOptions",
        "AnimationLoading2",
        "SolutionAnalysisError",
        "AnimationErrors3",
        "AnimationErrors6",
        "FindSimilarIssues",
        "ReanalyzeFilesWithErrors",
        "AnimationLoading6",
        "Loading3",
        "Loading9",
        "SolutionAnalysisToolWindow",
        "Loading7",
        "AnimationLoading4",
        "AnimationErrors5",
        "AnimationNoErrors5",
        "Loading4",
        "Loading6",
        "CacheLocked",
        "AnalyzingErrors1",
        "SolutionAnalysisPause",
        "AnimationLoading7",
        "AnalysisOff",
        "AnimationNoErrors3",
        "AnalyzingNoErrors9",
        "AnalyzingErrors2",
        "CheckingForChanges4",
        "Loading1",
        "AnimationNoErrors4",
        "SkipFile",
        "AnalyzingErrors4",
        "CheckingForChanges1",
        "SolutionAnalysisSuggestion",
        "AnimationErrors8",
        "CheckingForChanges2",
        "AnalyzingNoErrors3",
        "FilterIssues",
        "FinishedNoErrors",
        "AnimationLoading5",
        "AnimationLoading3",
        "AnalyzingErrors6",
        "AnimationErrors4",
        "AnimationNoErrors6",
        "IgnoreErrors",
        "AnalyzingErrors7",
        "AnalyzingErrors3",
        "CheckingForChanges3",
        "InvalidError",
        "AnimationErrors2",
        "AnalyzingNoErrors2"}, IconPackResourceIdentification="JetBrains.ReSharper.SolutionAnalysis.UI;component/Resources/SolutionAnalysisTheme" +
    "dIcons/ThemedIcons.SolutionAnalysis.Generated.Xaml")]
[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]
[assembly: System.Windows.Markup.XmlnsDefinitionAttribute("urn:shemas-jetbrains-com:ui-application-icons-solution-analysis", "JetBrains.ReSharper.Daemon.SolutionAnalysis.UI.Resources")]

namespace JetBrains.ReSharper.Daemon.SolutionAnalysis.UI.Actions
{
    
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "ErrorsView.ShowIgnoredIssues"})]
    public class ShowIgnoredIssuesAction : JetBrains.ActionManagement.IActionHandler
    {
        public void Execute(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.DelegateExecute nextExecute) { }
        public bool Update(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.ActionPresentation presentation, JetBrains.ActionManagement.DelegateUpdate nextUpdate) { }
    }
}
namespace JetBrains.ReSharper.Daemon.SolutionAnalysis.UI.ErrorsView
{
    
    [JetBrains.Application.ShellComponentAttribute()]
    public class ErrorsViewExportProvider : JetBrains.IDE.TreeBrowser.ExportTreeProviderBase
    {
        public ErrorsViewExportProvider([JetBrains.Annotations.NotNullAttribute()] JetBrains.UI.Application.Progress.UITaskExecutorSwitchingImplementation uiTaskExecutorSwitchingImplementation, JetBrains.Application.IApplicationDescriptor product, JetBrains.UI.Application.IMainWindow mainWindow = null) { }
        public System.Xml.Xsl.XslCompiledTransform XmlToHtmlTransformation { get; }
        public System.Xml.Xsl.XslCompiledTransform XmlToTextTransformation { get; }
        public override System.Action<JetBrains.Application.Progress.IProgressIndicator, System.IO.Stream> GetExporter(JetBrains.Application.DataContext.IDataContext context, JetBrains.IDE.TreeBrowser.ExportTreeViewFormat exportFormat, bool onlySelection, out string title, out System.Windows.Forms.IWin32Window uiParent) { }
        public System.Action<JetBrains.Application.Progress.IProgressIndicator, System.IO.Stream> GetExporter(JetBrains.ProjectModel.ISolution solution, JetBrains.IDE.TreeBrowser.ExportTreeViewFormat exportFormat, System.Collections.Generic.IEnumerable<JetBrains.ProjectModel.IProjectModelElement> scope, System.Collections.Generic.ICollection<JetBrains.ReSharper.Daemon.SolutionAnalysis.IIssue> issues, string title) { }
        public override bool IsApplicable(JetBrains.Application.DataContext.IDataContext context, JetBrains.IDE.TreeBrowser.ExportTreeViewFormat exportFormat) { }
    }
    public class ErrorsViewIndicatorAutomation : JetBrains.ReSharper.Daemon.SolutionAnalysis.UI.Indicator.StatusIndicator, JetBrains.UI.Wpf.IAutomation, System.ComponentModel.INotifyPropertyChanged
    {
        public readonly JetBrains.DataFlow.IProperty<JetBrains.UI.RichText.RichText> Label;
        public readonly JetBrains.ReSharper.Daemon.SolutionAnalysis.UI.Indicator.RoundProgressStatusControlAutomation RoundProgress;
        public ErrorsViewIndicatorAutomation(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Threading.IThreading threading) { }
        public event System.ComponentModel.PropertyChangedEventHandler System.ComponentModel.INotifyPropertyChanged.PropertyChanged;
    }
    [JetBrains.UI.Wpf.ViewAttribute(JetBrains.UI.Wpf.ViewKind.Wpf)]
    public class ErrorsViewIndicatorView : JetBrains.UI.Wpf.ViewControl<JetBrains.ReSharper.Daemon.SolutionAnalysis.UI.ErrorsView.ErrorsViewIndicatorAutomation>
    {
        protected override System.Windows.UIElement OnRenderView(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ReSharper.Daemon.SolutionAnalysis.UI.ErrorsView.ErrorsViewIndicatorAutomation automation) { }
    }
    [JetBrains.UI.ToolWindowManagement.ToolWindowDescriptorAttribute(Icon=typeof(JetBrains.ReSharper.Daemon.SolutionAnalysis.UI.Resources.SolutionAnalysisThemedIcons.SolutionAnalysisToolWindow), ProductNeutralId="ErrorsView", Text="Errors in Solution", Type=JetBrains.UI.ToolWindowManagement.ToolWindowType.SingleInstance, VisibilityPersistenceScope=JetBrains.UI.ToolWindowManagement.ToolWindowVisibilityPersistenceScope.Solution)]
    public class ErrorsViewToolWindowDescriptor : JetBrains.UI.ToolWindowManagement.ToolWindowDescriptor
    {
        public ErrorsViewToolWindowDescriptor(JetBrains.Application.IApplicationDescriptor applicationDescriptor) { }
    }
    public interface IIssueOccurence : JetBrains.ReSharper.Feature.Services.Navigation.Search.IOccurence
    {
        JetBrains.ReSharper.Daemon.SolutionAnalysis.IIssue Issue { get; }
        bool Navigate(JetBrains.UI.PopupWindowManager.PopupWindowContextSource windowContext, bool transferFocus);
    }
}
namespace JetBrains.ReSharper.Daemon.SolutionAnalysis.UI.Indicator
{
    
    public class BarProgressStatusControlAutomation : JetBrains.UI.Wpf.AAutomation
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly JetBrains.DataFlow.IProperty<double> ProgressFraction;
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly JetBrains.DataFlow.IProperty<JetBrains.ReSharper.Daemon.SolutionAnalysis.UI.Indicator.IndicatorState> State;
        public BarProgressStatusControlAutomation([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Threading.IThreading invocator, [JetBrains.Annotations.NotNullAttribute()] JetBrains.UI.Icons.IThemedIconManager iconMan) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.CommonControls.IWindowlessControl CreateWcPresentation([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifePresentation) { }
    }
    [JetBrains.UI.Wpf.ViewAttribute(JetBrains.UI.Wpf.ViewKind.Wpf)]
    public class BarProgressStatusControlView : JetBrains.UI.Wpf.ViewControl<JetBrains.ReSharper.Daemon.SolutionAnalysis.UI.Indicator.BarProgressStatusControlAutomation>
    {
        protected override System.Windows.UIElement OnRenderView(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ReSharper.Daemon.SolutionAnalysis.UI.Indicator.BarProgressStatusControlAutomation automation) { }
    }
    [JetBrains.UI.Wpf.ViewAttribute(JetBrains.UI.Wpf.ViewKind.WindowlessControl)]
    public class BarProgressStatusControlWindowlessControl : JetBrains.CommonControls.IConstrainableControl, JetBrains.CommonControls.IWindowlessControl, JetBrains.UI.Wpf.IView, JetBrains.UI.Wpf.IView<JetBrains.ReSharper.Daemon.SolutionAnalysis.UI.Indicator.BarProgressStatusControlAutomation>
    {
        public BarProgressStatusControlWindowlessControl(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ReSharper.Daemon.SolutionAnalysis.UI.Indicator.BarProgressStatusControlAutomation automation) { }
    }
    public class FilesCountStatusIndicatorAutomation : JetBrains.UI.Wpf.AAutomation
    {
        public readonly JetBrains.DataFlow.IProperty<JetBrains.UI.Components.Fonts.EitherFont> Font;
        public readonly JetBrains.DataFlow.IProperty<JetBrains.UI.Components.Theming.EitherColor> ForeColor;
        public readonly JetBrains.DataFlow.IProperty<bool> IsHot;
        public readonly JetBrains.DataFlow.IProperty<string> Label;
        public FilesCountStatusIndicatorAutomation(JetBrains.DataFlow.Lifetime lifetime, JetBrains.UI.Application.IUIApplication application) { }
    }
    [JetBrains.UI.Wpf.ViewAttribute(JetBrains.UI.Wpf.ViewKind.Wpf)]
    public class FilesCountStatusIndicatorView : JetBrains.UI.Wpf.ViewControl<JetBrains.ReSharper.Daemon.SolutionAnalysis.UI.Indicator.FilesCountStatusIndicatorAutomation>
    {
        protected override System.Windows.UIElement OnRenderView(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ReSharper.Daemon.SolutionAnalysis.UI.Indicator.FilesCountStatusIndicatorAutomation automation) { }
    }
    [JetBrains.UI.Wpf.ViewAttribute(JetBrains.UI.Wpf.ViewKind.WindowlessControl)]
    public class FilesCountStatusIndicatorWindowlessControl : JetBrains.CommonControls.RichTextTipPainter, JetBrains.UI.Wpf.IView, JetBrains.UI.Wpf.IView<JetBrains.ReSharper.Daemon.SolutionAnalysis.UI.Indicator.FilesCountStatusIndicatorAutomation>
    {
        public FilesCountStatusIndicatorWindowlessControl(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ReSharper.Daemon.SolutionAnalysis.UI.Indicator.FilesCountStatusIndicatorAutomation automation) { }
    }
    [JetBrains.Application.Settings.SettingsKeyAttribute(typeof(JetBrains.ReSharper.Daemon.HighlightingSettings), "SWEA indicator appearance settings")]
    public class IndicatorAppearanceSettings
    {
        [JetBrains.Application.Settings.SettingsEntryAttribute(JetBrains.ReSharper.Daemon.SolutionAnalysis.UI.Indicator.ProgressIndicatorKind.ROUND, "Indicator shape")]
        public JetBrains.ReSharper.Daemon.SolutionAnalysis.UI.Indicator.ProgressIndicatorKind IndicatorKind;
        [JetBrains.Application.Settings.SettingsEntryAttribute(true, "Whether to show error count")]
        public bool ShowErrorCount;
    }
    [JetBrains.Application.Configuration.Upgrade.GlobalSettingsUpgraderAttribute()]
    public class IndicatorAppearanceSettingsUpgrader : JetBrains.Application.Configuration.SettingTablesUpgrader
    {
        public IndicatorAppearanceSettingsUpgrader(JetBrains.Application.Env.RunsProducts.ProductConfigurations productConfigurations) { }
        protected override void DoUpgrade(JetBrains.Application.Configuration.IComponentSettingsProvider legacySettingsProvider, JetBrains.Application.Settings.IContextBoundSettingsStore boundSettingsStore, JetBrains.DataFlow.Lifetime upgradeLifetime, JetBrains.Application.Configuration.SettingsTableBase workspaceSettingsTable, JetBrains.Application.Configuration.SettingsTableBase globalSettingsTable) { }
    }
    public class IndicatorBase
    {
        public readonly JetBrains.DataFlow.IProperty<JetBrains.ReSharper.Daemon.SolutionAnalysis.UI.Indicator.IndicatorState> State;
        public IndicatorBase(JetBrains.DataFlow.Lifetime lifetime) { }
        protected bool HasErrors { get; }
        protected bool Interrupted { get; }
        protected JetBrains.ReSharper.Daemon.SolutionAnalysis.UI.Indicator.IndicatorState MainState { get; }
    }
    [System.FlagsAttribute()]
    public enum IndicatorState
    {
        IDLE = 0,
        ANALYZING = 1,
        OFF = 2,
        LOADING = 3,
        NOT_LOADED = 4,
        CACHE_LOCKED = 5,
        CACHE_IO_PROBLEM = 6,
        ANALYZING_CHANGES = 7,
        ANALYSIS_PAUSED = 8,
        LOADING_PAUSED = 9,
        MAIN_STATE_PART = 31,
        ERRORS = 32,
        INTERRUPTED = 64,
    }
    public enum ProgressIndicatorKind
    {
        ROUND = 0,
        BAR = 1,
    }
    public class RoundProgressStatusControlAutomation : JetBrains.UI.Wpf.AAutomation
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly JetBrains.DataFlow.IProperty<double> ProgressFraction;
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly JetBrains.DataFlow.IProperty<JetBrains.UI.Icons.IconId> RoundIcon;
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly JetBrains.DataFlow.IProperty<JetBrains.ReSharper.Daemon.SolutionAnalysis.UI.Indicator.IndicatorState> State;
        public RoundProgressStatusControlAutomation([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime) { }
    }
    [JetBrains.UI.Wpf.ViewAttribute(JetBrains.UI.Wpf.ViewKind.Wpf)]
    public class RoundProgressStatusControlView : JetBrains.UI.Wpf.ViewControl<JetBrains.ReSharper.Daemon.SolutionAnalysis.UI.Indicator.RoundProgressStatusControlAutomation>
    {
        protected override System.Windows.UIElement OnRenderView(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ReSharper.Daemon.SolutionAnalysis.UI.Indicator.RoundProgressStatusControlAutomation automation) { }
    }
    [JetBrains.UI.Wpf.ViewAttribute(JetBrains.UI.Wpf.ViewKind.WindowlessControl)]
    public class RoundProgressStatusControlWindowlessControl : JetBrains.CommonControls.BitmapWindowlessControl, JetBrains.UI.Wpf.IView, JetBrains.UI.Wpf.IView<JetBrains.ReSharper.Daemon.SolutionAnalysis.UI.Indicator.RoundProgressStatusControlAutomation>
    {
        public RoundProgressStatusControlWindowlessControl(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ReSharper.Daemon.SolutionAnalysis.UI.Indicator.RoundProgressStatusControlAutomation automation, JetBrains.UI.Icons.IThemedIconManager iconman) { }
    }
    public class StatusIndicator
    {
        public readonly JetBrains.DataFlow.IProperty<string> FilesErrorsCountsText;
        public readonly JetBrains.DataFlow.IProperty<double> ProgressFraction;
        public readonly JetBrains.DataFlow.IProperty<JetBrains.UI.RichText.RichText> ProgressText;
        public readonly JetBrains.DataFlow.IProperty<JetBrains.ReSharper.Daemon.SolutionAnalysis.UI.Indicator.IndicatorState> State;
        public StatusIndicator(JetBrains.DataFlow.Lifetime lifetime) { }
        public JetBrains.UI.RichText.RichTextBlock BuildText(JetBrains.ReSharper.Daemon.SolutionAnalysis.UI.Indicator.StatusIndicator.TextFor textfor) { }
        public enum TextFor
        {
            StatusBar = 0,
            ErrorsView = 1,
        }
    }
}
namespace JetBrains.ReSharper.Daemon.SolutionAnalysis.UI.IssuesReport
{
    
    public class IssuesReportDescriptor : JetBrains.ReSharper.Daemon.SolutionAnalysis.UI.RunInspection.InspectionResultDescriptorBase, JetBrains.ReSharper.Daemon.Impl.ProjectModelWrapper.IUpdatableTextRangesSource
    {
        public IssuesReportDescriptor(JetBrains.ProjectModel.ISolution solution, System.Collections.Generic.ICollection<JetBrains.ProjectModel.IProjectModelElement> scope, System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.Navigation.Search.IOccurence> results, [JetBrains.Annotations.NotNullAttribute()] string sourceMoniker) { }
        public void UpdatableRangesInFile(JetBrains.ReSharper.Daemon.Impl.ProjectModelWrapper.IProjectFileWrapper file, System.Func<JetBrains.Util.TextRange, JetBrains.Util.TextRange> updateFunc) { }
        public override void UpdateResults() { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class IssuesReportPresenter
    {
        public IssuesReportPresenter(JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Features.Browsing.InspectionWindowRegistrar inspectionWindowRegistrar) { }
        public void ShowIssueReport(JetBrains.Util.FileSystemPath fsp) { }
    }
    [JetBrains.ActionManagement.ActionHandlerAttribute()]
    public class LoadIssuesReportActionHandler : JetBrains.ActionManagement.IActionHandler
    {
        public void Execute(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.DelegateExecute nextExecute) { }
        public bool Update(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.ActionPresentation presentation, JetBrains.ActionManagement.DelegateUpdate nextUpdate) { }
    }
    [JetBrains.ActionManagement.ActionHandlerAttribute()]
    public class SaveIssuesReportActionHandler : JetBrains.ActionManagement.IActionHandler
    {
        public void Execute(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.DelegateExecute nextExecute) { }
        public bool Update(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.ActionPresentation presentation, JetBrains.ActionManagement.DelegateUpdate nextUpdate) { }
    }
}
namespace JetBrains.ReSharper.Daemon.SolutionAnalysis.UI.Resources
{
    
    public sealed class SolutionAnalysisThemedIcons
    {
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.SolutionAnalysis.UI;component/Resources/SolutionAnalysisTheme" +
            "dIcons/ThemedIcons.SolutionAnalysis.Generated.Xaml", 55, "AnalysisOff")]
        public sealed class AnalysisOff : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.SolutionAnalysis.UI;component/Resources/SolutionAnalysisTheme" +
            "dIcons/ThemedIcons.SolutionAnalysis.Generated.Xaml", 52, "AnalyzingErrors1")]
        public sealed class AnalyzingErrors1 : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.SolutionAnalysis.UI;component/Resources/SolutionAnalysisTheme" +
            "dIcons/ThemedIcons.SolutionAnalysis.Generated.Xaml", 58, "AnalyzingErrors2")]
        public sealed class AnalyzingErrors2 : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.SolutionAnalysis.UI;component/Resources/SolutionAnalysisTheme" +
            "dIcons/ThemedIcons.SolutionAnalysis.Generated.Xaml", 78, "AnalyzingErrors3")]
        public sealed class AnalyzingErrors3 : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.SolutionAnalysis.UI;component/Resources/SolutionAnalysisTheme" +
            "dIcons/ThemedIcons.SolutionAnalysis.Generated.Xaml", 63, "AnalyzingErrors4")]
        public sealed class AnalyzingErrors4 : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.SolutionAnalysis.UI;component/Resources/SolutionAnalysisTheme" +
            "dIcons/ThemedIcons.SolutionAnalysis.Generated.Xaml", 10, "AnalyzingErrors5")]
        public sealed class AnalyzingErrors5 : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.SolutionAnalysis.UI;component/Resources/SolutionAnalysisTheme" +
            "dIcons/ThemedIcons.SolutionAnalysis.Generated.Xaml", 73, "AnalyzingErrors6")]
        public sealed class AnalyzingErrors6 : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.SolutionAnalysis.UI;component/Resources/SolutionAnalysisTheme" +
            "dIcons/ThemedIcons.SolutionAnalysis.Generated.Xaml", 77, "AnalyzingErrors7")]
        public sealed class AnalyzingErrors7 : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.SolutionAnalysis.UI;component/Resources/SolutionAnalysisTheme" +
            "dIcons/ThemedIcons.SolutionAnalysis.Generated.Xaml", 2, "AnalyzingErrors8")]
        public sealed class AnalyzingErrors8 : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.SolutionAnalysis.UI;component/Resources/SolutionAnalysisTheme" +
            "dIcons/ThemedIcons.SolutionAnalysis.Generated.Xaml", 21, "AnalyzingErrors9")]
        public sealed class AnalyzingErrors9 : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.SolutionAnalysis.UI;component/Resources/SolutionAnalysisTheme" +
            "dIcons/ThemedIcons.SolutionAnalysis.Generated.Xaml", 4, "AnalyzingNoErrors1")]
        public sealed class AnalyzingNoErrors1 : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.SolutionAnalysis.UI;component/Resources/SolutionAnalysisTheme" +
            "dIcons/ThemedIcons.SolutionAnalysis.Generated.Xaml", 82, "AnalyzingNoErrors2")]
        public sealed class AnalyzingNoErrors2 : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.SolutionAnalysis.UI;component/Resources/SolutionAnalysisTheme" +
            "dIcons/ThemedIcons.SolutionAnalysis.Generated.Xaml", 68, "AnalyzingNoErrors3")]
        public sealed class AnalyzingNoErrors3 : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.SolutionAnalysis.UI;component/Resources/SolutionAnalysisTheme" +
            "dIcons/ThemedIcons.SolutionAnalysis.Generated.Xaml", 1, "AnalyzingNoErrors4")]
        public sealed class AnalyzingNoErrors4 : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.SolutionAnalysis.UI;component/Resources/SolutionAnalysisTheme" +
            "dIcons/ThemedIcons.SolutionAnalysis.Generated.Xaml", 32, "AnalyzingNoErrors5")]
        public sealed class AnalyzingNoErrors5 : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.SolutionAnalysis.UI;component/Resources/SolutionAnalysisTheme" +
            "dIcons/ThemedIcons.SolutionAnalysis.Generated.Xaml", 22, "AnalyzingNoErrors6")]
        public sealed class AnalyzingNoErrors6 : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.SolutionAnalysis.UI;component/Resources/SolutionAnalysisTheme" +
            "dIcons/ThemedIcons.SolutionAnalysis.Generated.Xaml", 9, "AnalyzingNoErrors7")]
        public sealed class AnalyzingNoErrors7 : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.SolutionAnalysis.UI;component/Resources/SolutionAnalysisTheme" +
            "dIcons/ThemedIcons.SolutionAnalysis.Generated.Xaml", 0, "AnalyzingNoErrors8")]
        public sealed class AnalyzingNoErrors8 : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.SolutionAnalysis.UI;component/Resources/SolutionAnalysisTheme" +
            "dIcons/ThemedIcons.SolutionAnalysis.Generated.Xaml", 57, "AnalyzingNoErrors9")]
        public sealed class AnalyzingNoErrors9 : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.SolutionAnalysis.UI;component/Resources/SolutionAnalysisTheme" +
            "dIcons/ThemedIcons.SolutionAnalysis.Generated.Xaml", 31, "AnimationErrors1")]
        public sealed class AnimationErrors1 : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.SolutionAnalysis.UI;component/Resources/SolutionAnalysisTheme" +
            "dIcons/ThemedIcons.SolutionAnalysis.Generated.Xaml", 81, "AnimationErrors2")]
        public sealed class AnimationErrors2 : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.SolutionAnalysis.UI;component/Resources/SolutionAnalysisTheme" +
            "dIcons/ThemedIcons.SolutionAnalysis.Generated.Xaml", 37, "AnimationErrors3")]
        public sealed class AnimationErrors3 : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.SolutionAnalysis.UI;component/Resources/SolutionAnalysisTheme" +
            "dIcons/ThemedIcons.SolutionAnalysis.Generated.Xaml", 74, "AnimationErrors4")]
        public sealed class AnimationErrors4 : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.SolutionAnalysis.UI;component/Resources/SolutionAnalysisTheme" +
            "dIcons/ThemedIcons.SolutionAnalysis.Generated.Xaml", 47, "AnimationErrors5")]
        public sealed class AnimationErrors5 : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.SolutionAnalysis.UI;component/Resources/SolutionAnalysisTheme" +
            "dIcons/ThemedIcons.SolutionAnalysis.Generated.Xaml", 38, "AnimationErrors6")]
        public sealed class AnimationErrors6 : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.SolutionAnalysis.UI;component/Resources/SolutionAnalysisTheme" +
            "dIcons/ThemedIcons.SolutionAnalysis.Generated.Xaml", 13, "AnimationErrors7")]
        public sealed class AnimationErrors7 : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.SolutionAnalysis.UI;component/Resources/SolutionAnalysisTheme" +
            "dIcons/ThemedIcons.SolutionAnalysis.Generated.Xaml", 66, "AnimationErrors8")]
        public sealed class AnimationErrors8 : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.SolutionAnalysis.UI;component/Resources/SolutionAnalysisTheme" +
            "dIcons/ThemedIcons.SolutionAnalysis.Generated.Xaml", 24, "AnimationLoading1")]
        public sealed class AnimationLoading1 : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.SolutionAnalysis.UI;component/Resources/SolutionAnalysisTheme" +
            "dIcons/ThemedIcons.SolutionAnalysis.Generated.Xaml", 35, "AnimationLoading2")]
        public sealed class AnimationLoading2 : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.SolutionAnalysis.UI;component/Resources/SolutionAnalysisTheme" +
            "dIcons/ThemedIcons.SolutionAnalysis.Generated.Xaml", 72, "AnimationLoading3")]
        public sealed class AnimationLoading3 : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.SolutionAnalysis.UI;component/Resources/SolutionAnalysisTheme" +
            "dIcons/ThemedIcons.SolutionAnalysis.Generated.Xaml", 46, "AnimationLoading4")]
        public sealed class AnimationLoading4 : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.SolutionAnalysis.UI;component/Resources/SolutionAnalysisTheme" +
            "dIcons/ThemedIcons.SolutionAnalysis.Generated.Xaml", 71, "AnimationLoading5")]
        public sealed class AnimationLoading5 : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.SolutionAnalysis.UI;component/Resources/SolutionAnalysisTheme" +
            "dIcons/ThemedIcons.SolutionAnalysis.Generated.Xaml", 41, "AnimationLoading6")]
        public sealed class AnimationLoading6 : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.SolutionAnalysis.UI;component/Resources/SolutionAnalysisTheme" +
            "dIcons/ThemedIcons.SolutionAnalysis.Generated.Xaml", 54, "AnimationLoading7")]
        public sealed class AnimationLoading7 : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.SolutionAnalysis.UI;component/Resources/SolutionAnalysisTheme" +
            "dIcons/ThemedIcons.SolutionAnalysis.Generated.Xaml", 27, "AnimationLoading8")]
        public sealed class AnimationLoading8 : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.SolutionAnalysis.UI;component/Resources/SolutionAnalysisTheme" +
            "dIcons/ThemedIcons.SolutionAnalysis.Generated.Xaml", 23, "AnimationNoErrors1")]
        public sealed class AnimationNoErrors1 : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.SolutionAnalysis.UI;component/Resources/SolutionAnalysisTheme" +
            "dIcons/ThemedIcons.SolutionAnalysis.Generated.Xaml", 14, "AnimationNoErrors2")]
        public sealed class AnimationNoErrors2 : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.SolutionAnalysis.UI;component/Resources/SolutionAnalysisTheme" +
            "dIcons/ThemedIcons.SolutionAnalysis.Generated.Xaml", 56, "AnimationNoErrors3")]
        public sealed class AnimationNoErrors3 : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.SolutionAnalysis.UI;component/Resources/SolutionAnalysisTheme" +
            "dIcons/ThemedIcons.SolutionAnalysis.Generated.Xaml", 61, "AnimationNoErrors4")]
        public sealed class AnimationNoErrors4 : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.SolutionAnalysis.UI;component/Resources/SolutionAnalysisTheme" +
            "dIcons/ThemedIcons.SolutionAnalysis.Generated.Xaml", 48, "AnimationNoErrors5")]
        public sealed class AnimationNoErrors5 : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.SolutionAnalysis.UI;component/Resources/SolutionAnalysisTheme" +
            "dIcons/ThemedIcons.SolutionAnalysis.Generated.Xaml", 75, "AnimationNoErrors6")]
        public sealed class AnimationNoErrors6 : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.SolutionAnalysis.UI;component/Resources/SolutionAnalysisTheme" +
            "dIcons/ThemedIcons.SolutionAnalysis.Generated.Xaml", 29, "AnimationNoErrors7")]
        public sealed class AnimationNoErrors7 : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.SolutionAnalysis.UI;component/Resources/SolutionAnalysisTheme" +
            "dIcons/ThemedIcons.SolutionAnalysis.Generated.Xaml", 33, "AnimationNoErrors8")]
        public sealed class AnimationNoErrors8 : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.SolutionAnalysis.UI;component/Resources/SolutionAnalysisTheme" +
            "dIcons/ThemedIcons.SolutionAnalysis.Generated.Xaml", 51, "CacheLocked")]
        public sealed class CacheLocked : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.SolutionAnalysis.UI;component/Resources/SolutionAnalysisTheme" +
            "dIcons/ThemedIcons.SolutionAnalysis.Generated.Xaml", 64, "CheckingForChanges1")]
        public sealed class CheckingForChanges1 : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.SolutionAnalysis.UI;component/Resources/SolutionAnalysisTheme" +
            "dIcons/ThemedIcons.SolutionAnalysis.Generated.Xaml", 67, "CheckingForChanges2")]
        public sealed class CheckingForChanges2 : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.SolutionAnalysis.UI;component/Resources/SolutionAnalysisTheme" +
            "dIcons/ThemedIcons.SolutionAnalysis.Generated.Xaml", 79, "CheckingForChanges3")]
        public sealed class CheckingForChanges3 : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.SolutionAnalysis.UI;component/Resources/SolutionAnalysisTheme" +
            "dIcons/ThemedIcons.SolutionAnalysis.Generated.Xaml", 59, "CheckingForChanges4")]
        public sealed class CheckingForChanges4 : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.SolutionAnalysis.UI;component/Resources/SolutionAnalysisTheme" +
            "dIcons/ThemedIcons.SolutionAnalysis.Generated.Xaml", 8, "ErrorsGroupNode")]
        public sealed class ErrorsGroupNode : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.SolutionAnalysis.UI;component/Resources/SolutionAnalysisTheme" +
            "dIcons/ThemedIcons.SolutionAnalysis.Generated.Xaml", 69, "FilterIssues")]
        public sealed class FilterIssues : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.SolutionAnalysis.UI;component/Resources/SolutionAnalysisTheme" +
            "dIcons/ThemedIcons.SolutionAnalysis.Generated.Xaml", 39, "FindSimilarIssues")]
        public sealed class FindSimilarIssues : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.SolutionAnalysis.UI;component/Resources/SolutionAnalysisTheme" +
            "dIcons/ThemedIcons.SolutionAnalysis.Generated.Xaml", 19, "FinishedErrors")]
        public sealed class FinishedErrors : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.SolutionAnalysis.UI;component/Resources/SolutionAnalysisTheme" +
            "dIcons/ThemedIcons.SolutionAnalysis.Generated.Xaml", 70, "FinishedNoErrors")]
        public sealed class FinishedNoErrors : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.SolutionAnalysis.UI;component/Resources/SolutionAnalysisTheme" +
            "dIcons/ThemedIcons.SolutionAnalysis.Generated.Xaml", 76, "IgnoreErrors")]
        public sealed class IgnoreErrors : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.SolutionAnalysis.UI;component/Resources/SolutionAnalysisTheme" +
            "dIcons/ThemedIcons.SolutionAnalysis.Generated.Xaml", 80, "InvalidError")]
        public sealed class InvalidError : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.SolutionAnalysis.UI;component/Resources/SolutionAnalysisTheme" +
            "dIcons/ThemedIcons.SolutionAnalysis.Generated.Xaml", 30, "IssueGroup")]
        public sealed class IssueGroup : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.SolutionAnalysis.UI;component/Resources/SolutionAnalysisTheme" +
            "dIcons/ThemedIcons.SolutionAnalysis.Generated.Xaml", 60, "Loading1")]
        public sealed class Loading1 : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.SolutionAnalysis.UI;component/Resources/SolutionAnalysisTheme" +
            "dIcons/ThemedIcons.SolutionAnalysis.Generated.Xaml", 11, "Loading2")]
        public sealed class Loading2 : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.SolutionAnalysis.UI;component/Resources/SolutionAnalysisTheme" +
            "dIcons/ThemedIcons.SolutionAnalysis.Generated.Xaml", 42, "Loading3")]
        public sealed class Loading3 : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.SolutionAnalysis.UI;component/Resources/SolutionAnalysisTheme" +
            "dIcons/ThemedIcons.SolutionAnalysis.Generated.Xaml", 49, "Loading4")]
        public sealed class Loading4 : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.SolutionAnalysis.UI;component/Resources/SolutionAnalysisTheme" +
            "dIcons/ThemedIcons.SolutionAnalysis.Generated.Xaml", 28, "Loading5")]
        public sealed class Loading5 : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.SolutionAnalysis.UI;component/Resources/SolutionAnalysisTheme" +
            "dIcons/ThemedIcons.SolutionAnalysis.Generated.Xaml", 50, "Loading6")]
        public sealed class Loading6 : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.SolutionAnalysis.UI;component/Resources/SolutionAnalysisTheme" +
            "dIcons/ThemedIcons.SolutionAnalysis.Generated.Xaml", 45, "Loading7")]
        public sealed class Loading7 : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.SolutionAnalysis.UI;component/Resources/SolutionAnalysisTheme" +
            "dIcons/ThemedIcons.SolutionAnalysis.Generated.Xaml", 15, "Loading8")]
        public sealed class Loading8 : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.SolutionAnalysis.UI;component/Resources/SolutionAnalysisTheme" +
            "dIcons/ThemedIcons.SolutionAnalysis.Generated.Xaml", 43, "Loading9")]
        public sealed class Loading9 : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.SolutionAnalysis.UI;component/Resources/SolutionAnalysisTheme" +
            "dIcons/ThemedIcons.SolutionAnalysis.Generated.Xaml", 20, "ReanalyzeAllFiles")]
        public sealed class ReanalyzeAllFiles : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.SolutionAnalysis.UI;component/Resources/SolutionAnalysisTheme" +
            "dIcons/ThemedIcons.SolutionAnalysis.Generated.Xaml", 40, "ReanalyzeFilesWithErrors")]
        public sealed class ReanalyzeFilesWithErrors : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.SolutionAnalysis.UI;component/Resources/SolutionAnalysisTheme" +
            "dIcons/ThemedIcons.SolutionAnalysis.Generated.Xaml", 18, "ShowIgnoredErrors")]
        public sealed class ShowIgnoredErrors : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.SolutionAnalysis.UI;component/Resources/SolutionAnalysisTheme" +
            "dIcons/ThemedIcons.SolutionAnalysis.Generated.Xaml", 62, "SkipFile")]
        public sealed class SkipFile : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.SolutionAnalysis.UI;component/Resources/SolutionAnalysisTheme" +
            "dIcons/ThemedIcons.SolutionAnalysis.Generated.Xaml", 12, "SolutionAnalysis")]
        public sealed class SolutionAnalysis : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.SolutionAnalysis.UI;component/Resources/SolutionAnalysisTheme" +
            "dIcons/ThemedIcons.SolutionAnalysis.Generated.Xaml", 6, "SolutionAnalysisContinue")]
        public sealed class SolutionAnalysisContinue : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.SolutionAnalysis.UI;component/Resources/SolutionAnalysisTheme" +
            "dIcons/ThemedIcons.SolutionAnalysis.Generated.Xaml", 36, "SolutionAnalysisError")]
        public sealed class SolutionAnalysisError : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.SolutionAnalysis.UI;component/Resources/SolutionAnalysisTheme" +
            "dIcons/ThemedIcons.SolutionAnalysis.Generated.Xaml", 26, "SolutionAnalysisHint")]
        public sealed class SolutionAnalysisHint : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.SolutionAnalysis.UI;component/Resources/SolutionAnalysisTheme" +
            "dIcons/ThemedIcons.SolutionAnalysis.Generated.Xaml", 5, "SolutionAnalysisNA")]
        public sealed class SolutionAnalysisNA : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.SolutionAnalysis.UI;component/Resources/SolutionAnalysisTheme" +
            "dIcons/ThemedIcons.SolutionAnalysis.Generated.Xaml", 34, "SolutionAnalysisOptions")]
        public sealed class SolutionAnalysisOptions : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.SolutionAnalysis.UI;component/Resources/SolutionAnalysisTheme" +
            "dIcons/ThemedIcons.SolutionAnalysis.Generated.Xaml", 53, "SolutionAnalysisPause")]
        public sealed class SolutionAnalysisPause : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.SolutionAnalysis.UI;component/Resources/SolutionAnalysisTheme" +
            "dIcons/ThemedIcons.SolutionAnalysis.Generated.Xaml", 3, "SolutionAnalysisPaused")]
        public sealed class SolutionAnalysisPaused : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.SolutionAnalysis.UI;component/Resources/SolutionAnalysisTheme" +
            "dIcons/ThemedIcons.SolutionAnalysis.Generated.Xaml", 25, "SolutionAnalysisRefresh")]
        public sealed class SolutionAnalysisRefresh : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.SolutionAnalysis.UI;component/Resources/SolutionAnalysisTheme" +
            "dIcons/ThemedIcons.SolutionAnalysis.Generated.Xaml", 65, "SolutionAnalysisSuggestion")]
        public sealed class SolutionAnalysisSuggestion : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.SolutionAnalysis.UI;component/Resources/SolutionAnalysisTheme" +
            "dIcons/ThemedIcons.SolutionAnalysis.Generated.Xaml", 44, "SolutionAnalysisToolWindow")]
        public sealed class SolutionAnalysisToolWindow : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.SolutionAnalysis.UI;component/Resources/SolutionAnalysisTheme" +
            "dIcons/ThemedIcons.SolutionAnalysis.Generated.Xaml", 17, "SolutionAnalysisWarning")]
        public sealed class SolutionAnalysisWarning : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.SolutionAnalysis.UI;component/Resources/SolutionAnalysisTheme" +
            "dIcons/ThemedIcons.SolutionAnalysis.Generated.Xaml", 7, "StatusBarIndicatorBackground")]
        public sealed class StatusBarIndicatorBackground : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.SolutionAnalysis.UI;component/Resources/SolutionAnalysisTheme" +
            "dIcons/ThemedIcons.SolutionAnalysis.Generated.Xaml", 16, "UnignoreErrors")]
        public sealed class UnignoreErrors : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
    }
}
namespace JetBrains.ReSharper.Daemon.SolutionAnalysis.UI.RunInspection
{
    
    [JetBrains.Application.Settings.SettingsKeyAttribute(typeof(JetBrains.ReSharper.Daemon.HighlightingSettings), "Code issue filters")]
    public class CodeIssueFilterSettings
    {
        [JetBrains.Application.Settings.SettingsIndexedEntryAttribute("Issue types to hide")]
        public JetBrains.Application.Settings.Store.IIndexedEntry<JetBrains.ReSharper.Daemon.SolutionAnalysis.IIssueType, JetBrains.ReSharper.Daemon.SolutionAnalysis.UI.RunInspection.DoHideIssue> IssueTypesToHide;
    }
    public enum DoHideIssue
    {
        Default = 0,
        DoHide = 1,
        DoShow = 2,
    }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "InspectionResults.FilterIssues"})]
    public class FilterIssuesAction : JetBrains.ActionManagement.IActionHandler
    {
        public void Execute(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.DelegateExecute nextExecute) { }
        public bool Update(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.ActionPresentation presentation, JetBrains.ActionManagement.DelegateUpdate nextUpdate) { }
    }
    public abstract class InspectionResultDescriptorBase : JetBrains.ReSharper.Feature.Services.Tree.OccurenceBrowserDescriptor
    {
        protected InspectionResultDescriptorBase(JetBrains.ProjectModel.ISolution solution, System.Collections.Generic.ICollection<JetBrains.ProjectModel.IProjectModelElement> scope, System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.Navigation.Search.IOccurence> results, JetBrains.ReSharper.Daemon.SolutionAnalysis.UI.RunInspection.IssueTypeGroup issuesToShow = null) { }
        public override string ActionBarID { get; }
        public override string ContextMenuID { get; }
        protected override int DefaultGroupingIndex { get; set; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Daemon.SolutionAnalysis.IIssue> FilteredIssues { get; }
        public bool IsShowingSpecificIssueTypesOnly { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Daemon.SolutionAnalysis.IIssueType> IssuesToHide { get; set; }
        public override JetBrains.TreeModels.TreeModel Model { get; }
        public override JetBrains.UI.TreeView.StructuredPresenter<JetBrains.TreeModels.TreeModelNode, JetBrains.CommonControls.IPresentableItem> Presenter { get; }
        public System.Collections.Generic.ICollection<JetBrains.ProjectModel.IProjectModelElement> Scope { get; }
        public override void ExportTreeView(JetBrains.UI.TreeView.TreeModelView modelView, JetBrains.IDE.TreeBrowser.ExportTreeViewFormat format, bool onlySelection, System.IO.Stream output, JetBrains.Application.Progress.IProgressIndicator progress) { }
        protected virtual void SetResults(System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.Navigation.Search.IOccurence> items, JetBrains.Application.Progress.IProgressIndicator indicator = null, bool mergeKinds = True) { }
        public abstract void UpdateResults();
    }
    [JetBrains.ReSharper.Psi.ShellFeaturePartAttribute()]
    public class InspectionResultGroupingProvider : JetBrains.ReSharper.Features.Common.Occurences.OccurenceBrowserGroupingProvider
    {
        public override System.Collections.Generic.ICollection<JetBrains.TreeModels.TreeModelGrouping<JetBrains.ReSharper.Feature.Services.Navigation.Search.IOccurence>> GetGroupings(JetBrains.IDE.TreeBrowser.TreeModelBrowserDescriptorBase descriptor) { }
        public override bool IsApplicable(JetBrains.IDE.TreeBrowser.TreeModelBrowserDescriptorBase descriptor) { }
        protected class IssueCategoryAndTypeGroupProvider : JetBrains.TreeModels.ITreeGroupProvider<JetBrains.ReSharper.Feature.Services.Navigation.Search.IOccurence>
        {
            public object ExtractGroupObject(JetBrains.ReSharper.Feature.Services.Navigation.Search.IOccurence item) { }
        }
        protected class IssueCategoryGroupProvider : JetBrains.TreeModels.ITreeGroupProvider<JetBrains.ReSharper.Feature.Services.Navigation.Search.IOccurence>
        {
            public object ExtractGroupObject(JetBrains.ReSharper.Feature.Services.Navigation.Search.IOccurence item) { }
        }
        protected class IssueSeverityGroupProvider : JetBrains.TreeModels.ITreeGroupProvider<JetBrains.ReSharper.Feature.Services.Navigation.Search.IOccurence>
        {
            public object ExtractGroupObject(JetBrains.ReSharper.Feature.Services.Navigation.Search.IOccurence item) { }
        }
        protected class IssueTypeGroupProvider : JetBrains.TreeModels.ITreeGroupProvider<JetBrains.ReSharper.Feature.Services.Navigation.Search.IOccurence>
        {
            public object ExtractGroupObject(JetBrains.ReSharper.Feature.Services.Navigation.Search.IOccurence item) { }
        }
    }
    [JetBrains.ReSharper.Psi.ShellFeaturePartAttribute()]
    public class InspectionResultOccurenceSectionProvider : JetBrains.ReSharper.Feature.Services.Tree.SectionsManagement.OccurenceSectionProvider
    {
        public override System.Collections.Generic.ICollection<JetBrains.TreeModels.TreeSection> GetTreeSections(JetBrains.ReSharper.Feature.Services.Tree.OccurenceBrowserDescriptor descriptor) { }
        public override bool IsApplicable(JetBrains.ReSharper.Feature.Services.Tree.OccurenceBrowserDescriptor descriptor) { }
    }
    [JetBrains.Application.Settings.SettingsKeyAttribute(typeof(JetBrains.UI.UserInterfaceSettings), "Inspection results view settings")]
    public class InspectionResultViewSettings
    {
        [JetBrains.Application.Settings.SettingsEntryAttribute(7, "Group by")]
        public int GroupingIndex;
    }
    [JetBrains.Application.Configuration.Upgrade.GlobalSettingsUpgraderAttribute()]
    public class InspectionResultViewSettingsUpgrader : JetBrains.Application.Configuration.SettingTablesUpgrader
    {
        public InspectionResultViewSettingsUpgrader(JetBrains.Application.Env.RunsProducts.ProductConfigurations productConfigurations) { }
        protected override void DoUpgrade(JetBrains.Application.Configuration.IComponentSettingsProvider legacySettingsProvider, JetBrains.Application.Settings.IContextBoundSettingsStore boundSettingsStore, JetBrains.DataFlow.Lifetime upgradeLifetime, JetBrains.Application.Configuration.SettingsTableBase workspaceSettingsTable, JetBrains.Application.Configuration.SettingsTableBase globalSettingsTable) { }
    }
    public class IssueSeverityGroup : System.IComparable<JetBrains.ReSharper.Daemon.SolutionAnalysis.UI.RunInspection.IssueSeverityGroup>
    {
        public IssueSeverityGroup(JetBrains.ReSharper.Daemon.Severity severity) { }
        public JetBrains.ReSharper.Daemon.Severity Severity { get; }
        public int CompareTo(JetBrains.ReSharper.Daemon.SolutionAnalysis.UI.RunInspection.IssueSeverityGroup other) { }
        protected bool Equals(JetBrains.ReSharper.Daemon.SolutionAnalysis.UI.RunInspection.IssueSeverityGroup other) { }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
    }
    public class IssueTypeGroup
    {
        public IssueTypeGroup(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Daemon.SolutionAnalysis.IIssueType> issueTypes) { }
        public IssueTypeGroup(JetBrains.ReSharper.Daemon.SolutionAnalysis.IIssueType issueType, bool mergeCompound) { }
        public IssueTypeGroup(string groupId) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public string GroupId { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Daemon.SolutionAnalysis.IIssueType> IssueTypes { get; }
        public string Name { get; }
        public bool Equals(JetBrains.ReSharper.Daemon.SolutionAnalysis.UI.RunInspection.IssueTypeGroup other) { }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
    }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "InspectionResults.Update"})]
    public class RefreshInspectionResultsAction : JetBrains.ActionManagement.IActionHandler
    {
        public void Execute(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.DelegateExecute nextExecute) { }
        public bool Update(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.ActionPresentation presentation, JetBrains.ActionManagement.DelegateUpdate nextUpdate) { }
    }
    public class static RunInspection
    {
        public static void Execute(System.Collections.Generic.IList<JetBrains.ProjectModel.IProjectModelElement> scope, JetBrains.ReSharper.Daemon.SolutionAnalysis.UI.RunInspection.IssueTypeGroup issuesToShow = null) { }
        public static bool IsAvailable(System.Collections.Generic.IList<JetBrains.ProjectModel.IProjectModelElement> scope) { }
    }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "RunInspection"})]
    public class RunInspectionAction : JetBrains.ActionManagement.IActionHandler
    {
        public void Execute(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.DelegateExecute nextExecute) { }
        public bool Update(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.ActionPresentation presentation, JetBrains.ActionManagement.DelegateUpdate nextUpdate) { }
    }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "RunInspection.CurrentProject"})]
    public class RunInspectionInCurrentProjectAction : JetBrains.ActionManagement.IActionHandler
    {
        public void Execute(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.DelegateExecute nextExecute) { }
        public bool Update(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.ActionPresentation presentation, JetBrains.ActionManagement.DelegateUpdate nextUpdate) { }
    }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "RunInspection.Solution"})]
    public class RunInspectionInSolutionAction : JetBrains.ActionManagement.IActionHandler
    {
        public void Execute(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.DelegateExecute nextExecute) { }
        public bool Update(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.ActionPresentation presentation, JetBrains.ActionManagement.DelegateUpdate nextUpdate) { }
    }
    [JetBrains.Application.Configuration.Upgrade.GlobalSettingsUpgraderAttribute()]
    public class RunInspectionSettingsUpgrader : JetBrains.Application.Configuration.Upgrade.IGlobalSettingsUpgrader, JetBrains.Application.Configuration.Upgrade.ISettingsUpgrader
    {
        public void Upgrade(JetBrains.Application.Configuration.IComponentSettingsProvider legacySettingsProvider, JetBrains.Application.Settings.IContextBoundSettingsStore boundSettingsStore, JetBrains.DataFlow.Lifetime upgradeLifetime) { }
    }
}
namespace JetBrains.ReSharper.Daemon.SolutionAnalysis.UI.Theming
{
    
    public class SweaThemeColor : JetBrains.UI.Components.Theming.ThemeColor
    {
        public static readonly JetBrains.ReSharper.Daemon.SolutionAnalysis.UI.Theming.SweaThemeColor SolutionWideAnalysisErrorsIndicatorBackground;
        public static readonly JetBrains.ReSharper.Daemon.SolutionAnalysis.UI.Theming.SweaThemeColor SolutionWideAnalysisErrorsIndicatorForeground;
        public static readonly JetBrains.ReSharper.Daemon.SolutionAnalysis.UI.Theming.SweaThemeColor SolutionWideAnalysisErrorsIndicatorSeparator;
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class SweaThemeColorFiller : JetBrains.UI.Components.Theming.IThemeColorFiller
    {
        public virtual void FillColorTheme(JetBrains.UI.Components.Theming.ColorTheme t) { }
    }
}