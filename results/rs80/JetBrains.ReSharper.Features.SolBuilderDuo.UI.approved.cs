[assembly: JetBrains.ActionManagement.ActionsXmlAttribute("JetBrains.ReSharper.Features.SolBuilderDuo.UI.Res.Actions.xml")]
[assembly: JetBrains.UI.Icons.CompiledIcons.CompiledIconsPackAttribute(IconNames=new string[] {
        "SolBuilderDuoEnableHeuristics",
        "SolBuilderDuoDebug",
        "SolBuilderDuoRebuildSelection",
        "SolBuilderDuoEventsViewFilterShowAll",
        "SolBuilderDuoEventsViewFilterShowErrorsOnly",
        "SolBuilderDuoDebugDontBuild",
        "SolBuilderDuoRunSelection",
        "SolBuilderDuoRepeat",
        "SolBuilderDuoCancel",
        "SolBuilderDuoEventsViewFilter",
        "SolBuilderDuoCleanSelection",
        "SolBuilderDuoBuild",
        "SolBuilderDuoRunDontBuild",
        "SolBuilderDuoClean",
        "SolBuilderDuoRun",
        "SolBuilderDuoDebugSelection",
        "SolBuilderDuoEventsViewFilterShowWarnings",
        "SolBuilderDuoEventsViewFilterShowOutput",
        "SolBuilderDuoRebuild",
        "SolBuilderDuoBuildSelection",
        "SolBuilderDuoEventsViewFilterShowWarningsAndErrors",
        "SolBuilderDuoEventsViewFilterShowErrors",
        "SolBuilderDuoEventsViewFilterShowConsole",
        "SolBuilderDuoEventsViewFilterShowService"}, IconPackResourceIdentification="JetBrains.ReSharper.Features.SolBuilderDuo.UI;component/Res/SolBuilderDuoIcons/Th" +
    "emedIcons.SolBuilderDuo.Generated.Xaml")]
[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]
[assembly: System.Windows.Markup.XmlnsDefinitionAttribute("urn:shemas-jetbrains-com:ui-application-icons-sol-builder-duo", "JetBrains.ReSharper.Features.SolBuilderDuo.Res")]

namespace JetBrains.ReSharper.Features.SolBuilderDuo.Actions
{
    
    public abstract class BuildAndRunAction : JetBrains.ActionManagement.IActionHandler
    {
        protected readonly JetBrains.ReSharper.Features.SolBuilderDuo.Actions.RunStartupProjectAction myActionRunner;
        public BuildAndRunAction(JetBrains.ReSharper.Features.SolBuilderDuo.Actions.BuildAndRunAction.ProjectOrSolution scope) { }
        public void Execute([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.DelegateExecute nextExecute) { }
        public bool Update([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.ActionPresentation presentation, JetBrains.ActionManagement.DelegateUpdate nextUpdate) { }
        public class Notifier : System.Windows.Window
        {
            public Notifier() { }
            public static void ShowOnAllDesktops() { }
            public static void ShowWhenReady([JetBrains.Annotations.CanBeNullAttribute()] System.Diagnostics.Process process) { }
        }
        public enum ProjectOrSolution
        {
            Project = 0,
            Solution = 1,
        }
    }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "BuildAndRunProject"})]
    public class BuildAndRunProjectAction : JetBrains.ReSharper.Features.SolBuilderDuo.Actions.BuildAndRunAction
    {
        public BuildAndRunProjectAction() { }
    }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "BuildAndRunSolution"})]
    public class BuildAndRunSolutionAction : JetBrains.ReSharper.Features.SolBuilderDuo.Actions.BuildAndRunAction
    {
        public BuildAndRunSolutionAction() { }
    }
    public class static DataConstants
    {
        public static readonly JetBrains.Application.DataContext.DataConstant<JetBrains.ReSharper.SolutionBuilder.SolBuilderDuo.BuildSession> BuildSession;
        public static readonly JetBrains.Application.DataContext.DataConstant<System.Collections.Generic.IList<JetBrains.ReSharper.SolutionBuilder.SolBuilderDuo.BuildSessionProject>> BuildSessionProjects;
    }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "RunStartupProject"})]
    public class RunStartupProjectAction : JetBrains.ActionManagement.IActionHandler
    {
        public static bool NotifyTargetProcessStarted { get; }
        public static bool WaitForTargetProcess { get; }
        public static bool CloseSpawnedProcesses() { }
        public void Execute(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.DelegateExecute nextExecute) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static System.Diagnostics.Process StartProcess() { }
        public bool Update(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.ActionPresentation presentation, JetBrains.ActionManagement.DelegateUpdate nextUpdate) { }
        public class WaitProcessPopup : System.Windows.Window
        {
            protected WaitProcessPopup([JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IEnumerable<System.Diagnostics.Process> processes) { }
            protected override void OnClosing(System.ComponentModel.CancelEventArgs e) { }
            protected override void OnSourceInitialized(System.EventArgs e) { }
            public static bool WaitFor([JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.ICollection<System.Diagnostics.Process> processes) { }
        }
    }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "SolBuilderDuo.Build",
            "SolBuilderDuo.Rebuild",
            "SolBuilderDuo.Clean",
            "SolBuilderDuo.Run",
            "SolBuilderDuo.Debug",
            "SolBuilderDuo.BuildSelection",
            "SolBuilderDuo.RebuildSelection",
            "SolBuilderDuo.CleanSelection",
            "SolBuilderDuo.RunSelection",
            "SolBuilderDuo.DebugSelection",
            "SolBuilderDuo.RunDontBuild",
            "SolBuilderDuo.DebugDontBuild"})]
    public class SolBuilderBuildActions : JetBrains.ActionManagement.IActionHandler
    {
        public readonly System.Collections.Generic.Dictionary<string, JetBrains.ReSharper.Features.SolBuilderDuo.Actions.SolBuilderBuildActions.ItemDesc> myMapDesc;
        public SolBuilderBuildActions([JetBrains.Annotations.NotNullAttribute()] string sActionId) { }
        public static void Execute(JetBrains.ReSharper.Features.SolBuilderDuo.Actions.SolBuilderBuildActions.ItemDesc actiondesc, JetBrains.ProjectModel.ISolution solution, JetBrains.ProjectModel.IProject[] selection) { }
        public struct ItemDesc
        {
            public readonly string Id;
            public bool IsSelection;
            public readonly JetBrains.ReSharper.Features.SolBuilderDuo.Actions.SolBuilderBuildActions.ItemDesc.RunOrDebug PostBuild;
            public readonly System.Nullable<JetBrains.ReSharper.SolutionBuilder.SolBuilderDuo.BuildSessionSeverity> Severity;
            public ItemDesc(string id, System.Nullable<JetBrains.ReSharper.SolutionBuilder.SolBuilderDuo.BuildSessionSeverity> severity, bool isSelection, JetBrains.ReSharper.Features.SolBuilderDuo.Actions.SolBuilderBuildActions.ItemDesc.RunOrDebug postBuild) { }
            public enum RunOrDebug
            {
                None = 0,
                Run = 1,
                Debug = 2,
            }
        }
    }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "SolBuilderDuo.Cancel"})]
    public class SolBuilderCancelAction : JetBrains.ActionManagement.IActionHandler
    {
        public void Execute(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.DelegateExecute nextExecute) { }
        public bool Update(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.ActionPresentation presentation, JetBrains.ActionManagement.DelegateUpdate nextUpdate) { }
    }
    [JetBrains.ActionManagement.ActionHandlerAttribute()]
    public class SolBuilderDuo_ShowBuildMessagesAction : JetBrains.ActionManagement.IActionHandler { }
    [JetBrains.ActionManagement.ActionHandlerAttribute()]
    public class SolBuilderDuo_ShowSettingsAction : JetBrains.ActionManagement.IActionHandler { }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "SolBuilderDuo.Repeat",
            "SolBuilderDuo.EnableHeuristics",
            "SolBuilderDuo.EventsView.ActionBar"})]
    public class SolBuilderTempActions : JetBrains.ActionManagement.IActionHandler
    {
        public void Execute(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.DelegateExecute nextExecute) { }
        public bool Update(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.ActionPresentation presentation, JetBrains.ActionManagement.DelegateUpdate nextUpdate) { }
    }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "SolBuilderDuo.EventsView.Filter.ShowErrorsOnly",
            "SolBuilderDuo.EventsView.Filter.ShowWarningsAndErrors",
            "SolBuilderDuo.EventsView.Filter.ShowAll",
            "SolBuilderDuo.EventsView.Filter.ShowErrors",
            "SolBuilderDuo.EventsView.Filter.ShowWarnings",
            "SolBuilderDuo.EventsView.Filter.ShowOutput",
            "SolBuilderDuo.EventsView.Filter.ShowService",
            "SolBuilderDuo.EventsView.Filter.ShowConsole"})]
    public class SolBuildEventsFilterActions : JetBrains.ActionManagement.IActionHandler
    {
        protected SolBuildEventsFilterActions([JetBrains.Annotations.NotNullAttribute()] string actionid) { }
        public void Execute(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.DelegateExecute nextExecute) { }
        public bool Update(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.ActionPresentation presentation, JetBrains.ActionManagement.DelegateUpdate nextUpdate) { }
    }
}
namespace JetBrains.ReSharper.Features.SolBuilderDuo
{
    
    public class EntryPoint
    {
        public void In() { }
        public void Out() { }
        public void Run() { }
        public void RunCore() { }
    }
}
namespace JetBrains.ReSharper.Features.SolBuilderDuo.Res
{
    
    public sealed class SolBuilderDuoThemedIcons
    {
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Features.SolBuilderDuo.UI;component/Res/SolBuilderDuoIcons/Th" +
            "emedIcons.SolBuilderDuo.Generated.Xaml", 11, "SolBuilderDuoBuild")]
        public sealed class SolBuilderDuoBuild : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Features.SolBuilderDuo.UI;component/Res/SolBuilderDuoIcons/Th" +
            "emedIcons.SolBuilderDuo.Generated.Xaml", 19, "SolBuilderDuoBuildSelection")]
        public sealed class SolBuilderDuoBuildSelection : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Features.SolBuilderDuo.UI;component/Res/SolBuilderDuoIcons/Th" +
            "emedIcons.SolBuilderDuo.Generated.Xaml", 8, "SolBuilderDuoCancel")]
        public sealed class SolBuilderDuoCancel : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Features.SolBuilderDuo.UI;component/Res/SolBuilderDuoIcons/Th" +
            "emedIcons.SolBuilderDuo.Generated.Xaml", 13, "SolBuilderDuoClean")]
        public sealed class SolBuilderDuoClean : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Features.SolBuilderDuo.UI;component/Res/SolBuilderDuoIcons/Th" +
            "emedIcons.SolBuilderDuo.Generated.Xaml", 10, "SolBuilderDuoCleanSelection")]
        public sealed class SolBuilderDuoCleanSelection : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Features.SolBuilderDuo.UI;component/Res/SolBuilderDuoIcons/Th" +
            "emedIcons.SolBuilderDuo.Generated.Xaml", 1, "SolBuilderDuoDebug")]
        public sealed class SolBuilderDuoDebug : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Features.SolBuilderDuo.UI;component/Res/SolBuilderDuoIcons/Th" +
            "emedIcons.SolBuilderDuo.Generated.Xaml", 5, "SolBuilderDuoDebugDontBuild")]
        public sealed class SolBuilderDuoDebugDontBuild : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Features.SolBuilderDuo.UI;component/Res/SolBuilderDuoIcons/Th" +
            "emedIcons.SolBuilderDuo.Generated.Xaml", 15, "SolBuilderDuoDebugSelection")]
        public sealed class SolBuilderDuoDebugSelection : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Features.SolBuilderDuo.UI;component/Res/SolBuilderDuoIcons/Th" +
            "emedIcons.SolBuilderDuo.Generated.Xaml", 0, "SolBuilderDuoEnableHeuristics")]
        public sealed class SolBuilderDuoEnableHeuristics : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Features.SolBuilderDuo.UI;component/Res/SolBuilderDuoIcons/Th" +
            "emedIcons.SolBuilderDuo.Generated.Xaml", 9, "SolBuilderDuoEventsViewFilter")]
        public sealed class SolBuilderDuoEventsViewFilter : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Features.SolBuilderDuo.UI;component/Res/SolBuilderDuoIcons/Th" +
            "emedIcons.SolBuilderDuo.Generated.Xaml", 3, "SolBuilderDuoEventsViewFilterShowAll")]
        public sealed class SolBuilderDuoEventsViewFilterShowAll : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Features.SolBuilderDuo.UI;component/Res/SolBuilderDuoIcons/Th" +
            "emedIcons.SolBuilderDuo.Generated.Xaml", 22, "SolBuilderDuoEventsViewFilterShowConsole")]
        public sealed class SolBuilderDuoEventsViewFilterShowConsole : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Features.SolBuilderDuo.UI;component/Res/SolBuilderDuoIcons/Th" +
            "emedIcons.SolBuilderDuo.Generated.Xaml", 21, "SolBuilderDuoEventsViewFilterShowErrors")]
        public sealed class SolBuilderDuoEventsViewFilterShowErrors : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Features.SolBuilderDuo.UI;component/Res/SolBuilderDuoIcons/Th" +
            "emedIcons.SolBuilderDuo.Generated.Xaml", 4, "SolBuilderDuoEventsViewFilterShowErrorsOnly")]
        public sealed class SolBuilderDuoEventsViewFilterShowErrorsOnly : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Features.SolBuilderDuo.UI;component/Res/SolBuilderDuoIcons/Th" +
            "emedIcons.SolBuilderDuo.Generated.Xaml", 17, "SolBuilderDuoEventsViewFilterShowOutput")]
        public sealed class SolBuilderDuoEventsViewFilterShowOutput : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Features.SolBuilderDuo.UI;component/Res/SolBuilderDuoIcons/Th" +
            "emedIcons.SolBuilderDuo.Generated.Xaml", 23, "SolBuilderDuoEventsViewFilterShowService")]
        public sealed class SolBuilderDuoEventsViewFilterShowService : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Features.SolBuilderDuo.UI;component/Res/SolBuilderDuoIcons/Th" +
            "emedIcons.SolBuilderDuo.Generated.Xaml", 16, "SolBuilderDuoEventsViewFilterShowWarnings")]
        public sealed class SolBuilderDuoEventsViewFilterShowWarnings : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Features.SolBuilderDuo.UI;component/Res/SolBuilderDuoIcons/Th" +
            "emedIcons.SolBuilderDuo.Generated.Xaml", 20, "SolBuilderDuoEventsViewFilterShowWarningsAndErrors")]
        public sealed class SolBuilderDuoEventsViewFilterShowWarningsAndErrors : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Features.SolBuilderDuo.UI;component/Res/SolBuilderDuoIcons/Th" +
            "emedIcons.SolBuilderDuo.Generated.Xaml", 18, "SolBuilderDuoRebuild")]
        public sealed class SolBuilderDuoRebuild : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Features.SolBuilderDuo.UI;component/Res/SolBuilderDuoIcons/Th" +
            "emedIcons.SolBuilderDuo.Generated.Xaml", 2, "SolBuilderDuoRebuildSelection")]
        public sealed class SolBuilderDuoRebuildSelection : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Features.SolBuilderDuo.UI;component/Res/SolBuilderDuoIcons/Th" +
            "emedIcons.SolBuilderDuo.Generated.Xaml", 7, "SolBuilderDuoRepeat")]
        public sealed class SolBuilderDuoRepeat : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Features.SolBuilderDuo.UI;component/Res/SolBuilderDuoIcons/Th" +
            "emedIcons.SolBuilderDuo.Generated.Xaml", 14, "SolBuilderDuoRun")]
        public sealed class SolBuilderDuoRun : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Features.SolBuilderDuo.UI;component/Res/SolBuilderDuoIcons/Th" +
            "emedIcons.SolBuilderDuo.Generated.Xaml", 12, "SolBuilderDuoRunDontBuild")]
        public sealed class SolBuilderDuoRunDontBuild : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Features.SolBuilderDuo.UI;component/Res/SolBuilderDuoIcons/Th" +
            "emedIcons.SolBuilderDuo.Generated.Xaml", 6, "SolBuilderDuoRunSelection")]
        public sealed class SolBuilderDuoRunSelection : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
    }
}
namespace JetBrains.ReSharper.Features.SolBuilderDuo.View
{
    
    public class BuildEventOccurence : JetBrains.ReSharper.Feature.Services.Search.IOccurence
    {
        public BuildEventOccurence([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.SolutionBuilder.SolBuilderDuo.SolBuildEvent evt, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IProjectModelElement project, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Features.SolBuilderDuo.View.BuildEventOccurence.DocumentForFileCache doccache, JetBrains.ReSharper.Features.SolBuilderDuo.View.BuildEventOccurence.FeatureFlags featureflags) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ReSharper.SolutionBuilder.SolBuilderDuo.SolBuildEvent BuildEvent { get; }
        public System.Nullable<JetBrains.DocumentModel.DocumentCoords> DocumentCoords { get; }
        public bool IsValid { get; }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Feature.Services.Search.IOccurence> MergedItems { get; }
        public object MergeKey { get; }
        public JetBrains.ReSharper.Psi.DeclaredElementEnvoy<JetBrains.ReSharper.Psi.INamespace> Namespace { get; }
        public JetBrains.ReSharper.Feature.Services.Search.OccurenceType OccurenceType { get; }
        public JetBrains.ReSharper.Feature.Services.Occurences.OccurencePresentationOptions PresentationOptions { get; set; }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ProjectModel.ProjectModelElementEnvoy ProjectModelElementEnvoy { get; }
        public JetBrains.ReSharper.Psi.DeclaredElementEnvoy<JetBrains.ReSharper.Psi.ITypeElement> TypeElement { get; }
        public JetBrains.ReSharper.Psi.DeclaredElementEnvoy<JetBrains.ReSharper.Psi.ITypeMember> TypeMember { get; }
        public JetBrains.UI.PopupMenu.IMenuItemDescriptor Describe() { }
        public string DumpToString() { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.CommonControls.PresentableItemImage GetIcon() { }
        public JetBrains.ProjectModel.IProjectFile GetProjectFileFromEnvoy() { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.UI.RichText.RichText GetRichText() { }
        public bool Navigate(JetBrains.ProjectModel.ISolution solution, JetBrains.UI.PopupWindowManager.PopupWindowContextSource windowContext, bool transferFocus, JetBrains.IDE.TabOptions tabOptions) { }
        public class DocumentForFileCache
        {
            [JetBrains.Annotations.NotNullAttribute()]
            public JetBrains.DocumentModel.IDocument GetDocument([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IProjectFile profile) { }
        }
        [System.FlagsAttribute()]
        public enum FeatureFlags
        {
            TrackLocationChanges = 1,
            GroupBuildResultsByMembers = 2,
        }
    }
    public class BuildSessionView : System.Windows.Controls.Border, System.IDisposable
    {
        public readonly JetBrains.DataFlow.ISignal<JetBrains.DataFlow.EventArgs<JetBrains.ReSharper.SolutionBuilder.SolBuilderDuo.BuildSessionProject>> OpenProjectMessagesRequested;
        public readonly JetBrains.DataFlow.Property<double> ProjectViewHeight;
        public readonly JetBrains.DataFlow.Property<double> ProjectViewWidth;
        public readonly JetBrains.DataFlow.IProperty<JetBrains.ReSharper.SolutionBuilder.SolBuilderDuo.BuildSession> Session;
        public BuildSessionView([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.SolutionBuilder.SolBuilderDuo.BuildSession session) { }
        public BuildSessionView() { }
        public void Dispose() { }
    }
    public class ProjectsByLevelsView : System.Windows.Controls.Border
    {
        public readonly JetBrains.DataFlow.Property<double> ProjectViewHeight;
        public readonly JetBrains.DataFlow.Property<double> ProjectViewWidth;
        public ProjectsByLevelsView() { }
        public void SetContent([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.List<System.Collections.Generic.List<JetBrains.ReSharper.SolutionBuilder.SolBuilderDuo.BuildSessionProject>> levels) { }
    }
    public class RunStartupProject
    {
        public static bool WaitForTargetProcess { get; }
        public static void DebugProcess(JetBrains.VsIntegration.ProjectModel.VSSolutionManager vsSolutionManager, Microsoft.VisualStudio.Shell.Interop.IVsDebugger2 vsDebugger) { }
        public static bool IsInDebugMode([JetBrains.Annotations.NotNullAttribute()] Microsoft.VisualStudio.Shell.Interop.IVsDebugger debugger) { }
        public static bool KillOldProcesses() { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Diagnostics.Process StartProcess() { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class SolBuilderDuoAutoShowResults
    {
        public SolBuilderDuoAutoShowResults(JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.ISolution solution, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.ISettingsStore settings, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Features.SolBuilderDuo.Provider.MsbuildSolutionBuilder solutionBuilder, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Threading.IThreading threading, [JetBrains.Annotations.NotNullAttribute()] JetBrains.UI.Application.Progress.UITaskExecutor uiTaskExecutor, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IPsiServices ψServices) { }
    }
    [JetBrains.UI.Options.OptionsPageAttribute("SolBuilderDuo", "SolBuilderDuo", typeof(JetBrains.ReSharper.Features.SolBuilderDuo.Res.SolBuilderDuoThemedIcons.SolBuilderDuoRun), ParentId="Tools")]
    public class SolBuilderDuoPage : JetBrains.UI.Options.Helpers.AStackPanelOptionsPage3
    {
        public const string PID = "SolBuilderDuo";
        public SolBuilderDuoPage(JetBrains.DataFlow.Lifetime lifetime, JetBrains.UI.Application.IUIApplication environment, JetBrains.UI.Options.OptionsSettingsSmartContext settings) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class SolBuilderDuoStatusBarIndicator
    {
        public SolBuilderDuoStatusBarIndicator([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.ISolution solution, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.ISettingsStore settings, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Features.SolBuilderDuo.Provider.MsbuildSolutionBuilder solutionBuilder, [JetBrains.Annotations.NotNullAttribute()] JetBrains.UI.Icons.IThemedIconManager themedIconManager, [JetBrains.Annotations.NotNullAttribute()] JetBrains.UI.StatusBar.IStatusBar statusBar, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.IApplicationDescriptor product, [JetBrains.Annotations.NotNullAttribute()] JetBrains.UI.TaskBar.ITaskBarManager taskBarManager) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class SolBuilderDuoView
    {
        public readonly JetBrains.DataFlow.IProperty<JetBrains.ReSharper.SolutionBuilder.SolBuilderDuo.BuildSession> CurrentSession;
        public SolBuilderDuoView(JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.ISolution solution, JetBrains.Threading.IThreading invocator, JetBrains.ReSharper.SolutionBuilder.SolutionBuilder solutionBuilder, JetBrains.ReSharper.Features.SolBuilderDuo.View.SolBuilderDuoViewToolWindowDescriptor toolWindowDescriptor, JetBrains.UI.ToolWindowManagement.ToolWindowManager toolWindowManager, JetBrains.Application.Settings.ISettingsStore settings, JetBrains.ReSharper.Psi.IPsiServices ψManager, JetBrains.Application.Settings.ISettingsStore settingsStore, JetBrains.UI.Application.Progress.UITaskExecutor uiTaskExecutor, JetBrains.UI.Components.Theming.IColorThemeManager themeManager) { }
    }
    [JetBrains.Application.Settings.SettingsKeyAttribute(typeof(JetBrains.UI.Settings.LayoutSettings), "Presentation aspects of the solution builder.")]
    public class SolBuilderDuoViewSettings
    {
        [JetBrains.Application.Settings.SettingsEntryAttribute(true, "After build completes, show build results automatically (if there are significant" +
            " events reported).")]
        public bool AutoShowBuildResults;
        [JetBrains.Application.Settings.SettingsEntryAttribute(true, "Enable grouping solution builder results by namespaces, types, and members.")]
        public bool GroupBuildResultsByMembers;
        [JetBrains.Application.Settings.SettingsEntryAttribute(11, "MRU grouping of build results in Find Results View.")]
        public int MruFindResultsGroupingIndex;
        [JetBrains.Application.Settings.SettingsEntryAttribute(true, "Show build progress in status bar when a build is running.")]
        public bool ShowBuildProgressInStatusBar;
        [JetBrains.Application.Settings.SettingsEntryAttribute(true, "Show build progress in windows task bar when a build is running.")]
        public bool ShowBuildProgressInTaskBar;
        [JetBrains.Application.Settings.SettingsEntryAttribute(true, "When build starts, open a tool window with graphical presentation of the build pr" +
            "ogress.")]
        public bool ShowBuildProgressInToolWindow;
    }
    [JetBrains.UI.ToolWindowManagement.ToolWindowDescriptorAttribute(Icon=typeof(JetBrains.ReSharper.Features.SolBuilderDuo.Res.SolBuilderDuoThemedIcons.SolBuilderDuoRun), ProductNeutralId="SolBuilderDuo", Text="SolBuilderDuo", Type=JetBrains.UI.ToolWindowManagement.ToolWindowType.SingleInstance, VisibilityPersistenceScope=JetBrains.UI.ToolWindowManagement.ToolWindowVisibilityPersistenceScope.Solution)]
    public class SolBuilderDuoViewToolWindowDescriptor : JetBrains.UI.ToolWindowManagement.ToolWindowDescriptor
    {
        public SolBuilderDuoViewToolWindowDescriptor(JetBrains.Application.IApplicationDescriptor applicationDescriptor) { }
    }
    public class SolBuildEventsBrowserDescriptor : JetBrains.ReSharper.Features.Common.Occurences.OccurenceBrowserDescriptor
    {
        public readonly JetBrains.ReSharper.SolutionBuilder.SolBuilderDuo.BuildSession Session;
        public SolBuildEventsBrowserDescriptor([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.SolutionBuilder.SolBuilderDuo.BuildSession session, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.ISolution solution, [JetBrains.Annotations.NotNullAttribute()] System.Func<JetBrains.ReSharper.SolutionBuilder.SolBuilderDuo.SolBuildEvent, JetBrains.ReSharper.SolutionBuilder.SolBuilderDuo.BuildSessionProject, bool> funcDomainFilter, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IPsiServices psiServices, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.ISettingsStore settings, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Threading.IThreading threading, [JetBrains.Annotations.NotNullAttribute()] JetBrains.UI.Application.Progress.UITaskExecutor uiTaskExecutor) { }
        public override string ActionBarID { get; }
        protected override int DefaultGroupingIndex { get; set; }
        public bool HasSignificantEvents { get; }
        public JetBrains.ReSharper.Features.SolBuilderDuo.View.TogglingFilter<JetBrains.ReSharper.SolutionBuilder.SolBuilderDuo.SolBuildEventKind> KindFilter { get; }
        public override JetBrains.TreeModels.TreeModel Model { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public override JetBrains.ProjectModel.ISolution Solution { get; }
        protected override void SetResults(System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.Search.IOccurence> items, JetBrains.Application.Progress.IProgressIndicator indicator = null, bool mergeKinds = True) { }
        public static void Show([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.SolutionBuilder.SolBuilderDuo.BuildSession session, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.ISolution solution, [JetBrains.Annotations.NotNullAttribute()] System.Func<JetBrains.ReSharper.SolutionBuilder.SolBuilderDuo.SolBuildEvent, JetBrains.ReSharper.SolutionBuilder.SolBuilderDuo.BuildSessionProject, bool> funcDomainFilter, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IPsiServices ψManager, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.ISettingsStore settingsStore, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Threading.IThreading threading, [JetBrains.Annotations.NotNullAttribute()] JetBrains.UI.Application.Progress.UITaskExecutor uiTaskExecutor) { }
        [JetBrains.Threading.GuardAttribute(JetBrains.Threading.Rgc.Guarded)]
        public static bool ShowIfNeeded([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.SolutionBuilder.SolBuilderDuo.BuildSession session, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.ISolution solution, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IPsiServices ψManager, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.ISettingsStore settingsStore, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Threading.IThreading threading, [JetBrains.Annotations.NotNullAttribute()] JetBrains.UI.Application.Progress.UITaskExecutor uiTaskExecutor) { }
        [JetBrains.Threading.GuardAttribute(JetBrains.Threading.Rgc.Guarded)]
        public static bool ShowIfNeeded([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.SolutionBuilder.SolBuilderDuo.BuildSession session, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.ISolution solution, [JetBrains.Annotations.NotNullAttribute()] System.Func<JetBrains.ReSharper.SolutionBuilder.SolBuilderDuo.SolBuildEvent, JetBrains.ReSharper.SolutionBuilder.SolBuilderDuo.BuildSessionProject, bool> funcDomainFilter, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IPsiServices ψManager, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.ISettingsStore settingsStore, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Threading.IThreading threading, [JetBrains.Annotations.NotNullAttribute()] JetBrains.UI.Application.Progress.UITaskExecutor uiTaskExecutor) { }
    }
    public class TogglingFilter<TItem>
    
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public static readonly TItem[] EverythingInEnum;
        public TogglingFilter() { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.DataFlow.ICollectionEvents<TItem> Effective { get; }
        public void Apply(bool isExclusive, params TItem[] kinds) { }
        public bool IsIncluded(bool isExclusive, params TItem[] kinds) { }
        public void SetExclusively([JetBrains.Annotations.NotNullAttribute()] params TItem[] items) { }
        public void Toggle([JetBrains.Annotations.NotNullAttribute()] params TItem[] items) { }
    }
}
namespace JetBrains.ReSharper.Features.SolBuilderDuo.View.BuildSessionView2
{
    
    public class Dashboard : System.Windows.FrameworkElement
    {
        public readonly JetBrains.DataFlow.IProperty<JetBrains.ReSharper.Features.SolBuilderDuo.View.BuildSessionView2.DashboardLayoutCalculator.CalculatedLayout> CalculatedLayout;
        public readonly JetBrains.DataFlow.ListEvents<JetBrains.ReSharper.Features.SolBuilderDuo.View.BuildSessionView2.IndicatorView> ProjectIndicators;
        public readonly JetBrains.ReSharper.Features.SolBuilderDuo.View.BuildSessionView2.IndicatorView SolutionIndicator;
        public Dashboard([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Features.SolBuilderDuo.View.BuildSessionView2.IndicatorView solutionIndicator, JetBrains.Threading.IThreading threading) { }
        protected override System.Collections.IEnumerator LogicalChildren { get; }
        protected override int VisualChildrenCount { get; }
        protected override System.Windows.Size ArrangeOverride(System.Windows.Size finalSize) { }
        protected override System.Windows.Media.Visual GetVisualChild(int index) { }
        protected override System.Windows.Size MeasureOverride(System.Windows.Size availableSize) { }
        public class static Dim
        {
            public static readonly System.Windows.Media.Color ColorBack;
            public static System.TimeSpan ColorChangeDuration;
            public static System.Windows.Media.Color ColorCompletedClean;
            public static System.Windows.Media.Color ColorCompletedErrors;
            public static System.Windows.Media.Color ColorCompletedUpToDateMixIn;
            public static System.Windows.Media.Color ColorCompletedWarnings;
            public static System.Windows.Media.Color ColorExcluded;
            public static readonly System.Windows.Media.Color ColorLabelText;
            public static System.Windows.Media.Color ColorPending;
            public static System.Windows.Media.Color ColorRunningClean;
            public static System.Windows.Media.Color ColorRunningErrors;
            public static System.Windows.Media.Color ColorRunningUpToDateMixIn;
            public static System.Windows.Media.Color ColorRunningWarnings;
            public static System.Windows.Media.Color IndicatorBorderColor;
            public static readonly double IndicatorBorderCornerRadius;
            public static System.Windows.Thickness IndicatorBorderThickness;
            public static System.Windows.Thickness IndicatorLabelPadding;
            public static readonly System.Windows.Thickness IndicatorMargin;
            public static readonly double LabelFontSize;
            public static readonly float NoChangesMixFactor;
            public static readonly float NonBreakingChangesMixFactor;
            public static System.Windows.Controls.TextBlock CreateIndicatorLabelTextBlock() { }
            public static System.Windows.Media.FontFamily GetMonospacedFont() { }
            public class static Base
            {
                public static readonly System.Windows.Media.Color ColorBack;
                public static readonly System.Windows.Media.Color ColorCompletedMixIn;
                public static readonly float CompletedMixFactor;
                public static readonly double InactiviyDimFactor;
            }
        }
    }
    public class static DashboardController
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Windows.FrameworkElement CreateView([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.SolutionBuilder.SolBuilderDuo.BuildSession session, JetBrains.Threading.IThreading threading, JetBrains.ActionManagement.IActionManager actionManager) { }
    }
    public class static DashboardLayoutCalculator
    {
        public static readonly double MaxIndicatorWidthToHeightFactor;
        public static readonly double MinIndicatorWidthToHeightFactor;
        public static readonly double MinPreferredRowHeight;
        public static readonly double NaturalIndicatorHeight;
        public static System.Windows.Size DefaultIndicatorSize { get; }
        public static int GetColumnCountFromRowCount(int nRows, int nIndicators) { }
        public static double GetRowCountApproxFromFactor(double factor, System.Windows.Size sizeView, int nIndicators) { }
        public static double GetRowCountApproxFromIndicatorHeight(double fIndicatorHeight, System.Windows.Size sizeView) { }
        public static JetBrains.ReSharper.Features.SolBuilderDuo.View.BuildSessionView2.DashboardLayoutCalculator.CalculatedLayout Run(System.Windows.Size size, int nIndicators) { }
        public struct CalculatedLayout
        {
            public int IndicatorsCount;
            public int RowCount;
            public System.Windows.Size ViewSize;
            public System.Windows.Size GetFullRowIndicatorLogicalSize() { }
            public double GetIndicatorAspect() { }
            public System.Windows.Size GetIndicatorLogicalSize() { }
            public double GetIndicatorVisualHeight() { }
            public System.Windows.Size GetIndicatorVisualSize() { }
            public double GetIndicatorVisualWidth() { }
            public override string ToString() { }
        }
    }
    public abstract class IndicatorData
    {
        public readonly JetBrains.DataFlow.IProperty<JetBrains.ReSharper.Features.SolBuilderDuo.View.BuildSessionView2.IndicatorData.ActiveInactiveColors> Color;
        public readonly JetBrains.DataFlow.IProperty<int> ErrorsCount;
        public readonly JetBrains.DataFlow.IProperty<bool> IsActive;
        public readonly JetBrains.DataFlow.IProperty<int> WarningsCount;
        public IndicatorData(JetBrains.DataFlow.Lifetime lifetime) { }
        public abstract string Text { get; }
        public abstract string TipTitleText { get; }
        protected void Init_ErrorsWarningsCount(JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.ISignal<JetBrains.DataFlow.AddRemoveIndexEventArgs<JetBrains.ReSharper.SolutionBuilder.SolBuilderDuo.SolBuildEvent>> sigAddRemove) { }
        public struct ActiveInactiveColors
        {
            public System.Windows.Media.Color Active;
            public System.Windows.Media.Color Inactive;
            public ActiveInactiveColors(System.Windows.Media.Color both) { }
            public ActiveInactiveColors(System.Windows.Media.Color active, System.Windows.Media.Color inactive) { }
        }
    }
    public class IndicatorLabel : System.Windows.Controls.Decorator
    {
        public readonly JetBrains.DataFlow.IProperty<string> Text;
        public readonly System.Windows.Controls.TextBlock TextBlock;
        public IndicatorLabel() { }
        protected override System.Windows.Size ArrangeOverride(System.Windows.Size arrangeSize) { }
        protected override System.Windows.Size MeasureOverride(System.Windows.Size constraint) { }
    }
    public class IndicatorView : System.Windows.Controls.Button
    {
        public readonly JetBrains.DataFlow.IProperty<JetBrains.ReSharper.Features.SolBuilderDuo.View.BuildSessionView2.IndicatorData.ActiveInactiveColors> Color;
        public readonly JetBrains.DataFlow.IProperty<bool> IsActive;
        public IndicatorView() { }
        public bool IsSolutionIndicator { get; set; }
        public JetBrains.DataFlow.IProperty<string> Text { get; }
    }
    public class static MonospacedTextAbbreviator<TItem>
    
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Collections.Generic.Dictionary<TItem, string> Run([JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.ICollection<TItem> items, [JetBrains.Annotations.NotNullAttribute()] System.Func<TItem, string> FItemName, double pixelwidth, System.Windows.Controls.TextBlock renderer) { }
    }
    public class ProjectIndicatorData : JetBrains.ReSharper.Features.SolBuilderDuo.View.BuildSessionView2.IndicatorData
    {
        public readonly JetBrains.DataFlow.IProperty<JetBrains.ReSharper.Features.SolBuilderDuo.View.BuildSessionView2.ProjectIndicatorData.ProjectBuildMessageStatus> BuildMessageStatus;
        public readonly JetBrains.ReSharper.SolutionBuilder.SolBuilderDuo.BuildSessionProject Project;
        public readonly JetBrains.DataFlow.IProperty<JetBrains.ReSharper.Features.SolBuilderDuo.Engine.Common.AssemblySurface.ProjectBuildSignature.ChangesKind> UpToDateStatus;
        public ProjectIndicatorData([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.SolutionBuilder.SolBuilderDuo.BuildSessionProject project) { }
        public override string Text { get; }
        public override string TipTitleText { get; }
        public enum ProjectBuildMessageStatus
        {
            Empty = 0,
            NoChanges = 1,
            NonBreakingChanges = 2,
            Ok = 3,
            Warnings = 4,
            Errors = 5,
        }
    }
    public class SolutionIndicatorData : JetBrains.ReSharper.Features.SolBuilderDuo.View.BuildSessionView2.IndicatorData
    {
        public SolutionIndicatorData([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.SolutionBuilder.SolBuilderDuo.BuildSession session) { }
        public override string Text { get; }
        public override string TipTitleText { get; }
    }
    public class StringAbbreviator<TItem>
    
    {
        protected StringAbbreviator([JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IEnumerable<TItem> items, [JetBrains.Annotations.NotNullAttribute()] System.Func<TItem, string> FItemName, int nChars) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Collections.Generic.Dictionary<TItem, string> Run([JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IEnumerable<TItem> items, [JetBrains.Annotations.NotNullAttribute()] System.Func<TItem, string> FItemName, int nChars) { }
    }
}
namespace JetBrains.ReSharper.Features.SolBuilderDuo.View.Infra
{
    
    public class Abbreviator<TItem>
    
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Collections.Generic.Dictionary<TItem, string> Run([JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IEnumerable<TItem> items, [JetBrains.Annotations.NotNullAttribute()] System.Func<TItem, string> funcItemName) { }
    }
    public class TestAbbreviator
    {
        public void ConflictResolvedInCaps() { }
        public void ConflictUnique() { }
        public void NoConflit() { }
        public void ShortNoConflict() { }
    }
}
namespace JetBrains.ReSharper.Features.SolBuilderDuo.View.Legacy
{
    
    public class static HieroPro
    {
        public static void ShowPreview([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.DataContext.IDataContext context) { }
    }
}