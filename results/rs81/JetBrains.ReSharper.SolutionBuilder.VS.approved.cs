[assembly: JetBrains.ActionManagement.ActionsXmlAttribute("JetBrains.ReSharper.SolutionBuilder.VS.Resources.Actions.xml")]
[assembly: JetBrains.UI.Icons.CompiledIcons.CompiledIconsPackAttribute(IconNames=new string[] {
        "StopBuild",
        "ClearSolution2",
        "BuildPending",
        "BuildRunningWarning",
        "TrackBuild",
        "BuildRunningError",
        "Excluded",
        "BuildStatusSuccess",
        "Aborted",
        "BuildStatusFailed",
        "RunBuild",
        "BuildStatusWarning",
        "RunningBuild",
        "BuildStatusUpToDate"}, IconPackResourceIdentification="JetBrains.ReSharper.SolutionBuilder.VS;component/Resources/SolutionBuilderVisualS" +
    "tudioThemedIcons/ThemedIcons.SolutionBuilderVisualStudio.Generated.Xaml")]
[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]
[assembly: System.Windows.Markup.XmlnsDefinitionAttribute("urn:shemas-jetbrains-com:ui-application-icons-solution-builder-visual-studio", "JetBrains.ReSharper.SolutionBuilder.VS.Resources")]

namespace JetBrains.ReSharper.SolutionBuilder.VS
{
    
    public class BuildAbortedEventArgs : System.EventArgs
    {
        public BuildAbortedEventArgs(JetBrains.ReSharper.SolutionBuilder.VS.SolutionBuilder2.Operation operation) { }
        public JetBrains.ReSharper.SolutionBuilder.VS.SolutionBuilder2.Operation PerformedOperation { get; }
    }
    public enum BuildErrorStatus
    {
        Clean = 0,
        Warnings = 1,
        Errors = 2,
        UpToDate = 3,
    }
    public class BuildMessageWildArgs : System.EventArgs
    {
        public BuildMessageWildArgs(JetBrains.ProjectModel.IProject project, string message) { }
        public string Message { get; set; }
        public JetBrains.ProjectModel.IProject Project { get; set; }
    }
    public interface IProcessRunnerHostController : System.IDisposable
    {
        void Abort();
        string GetTaskRunnerCommandLineArgs();
        JetBrains.Util.FileSystemPath GetTaskRunnerPath();
        int Run();
        void RunAsync(System.Action<int> endAction);
    }
    public interface ISolutionBuildProvider : System.IDisposable
    {
        bool IsBuildRunning { get; }
        void AbortOperation();
        bool RunOperation(JetBrains.ReSharper.SolutionBuilder.VS.SolutionBuilder2.Operation operation);
        bool RunOperation(JetBrains.ReSharper.SolutionBuilder.VS.SolutionBuilder2.Operation operation, JetBrains.ProjectModel.IProject project);
    }
    public abstract class ProcessTaskRunnerHostControllerBase : JetBrains.ReSharper.SolutionBuilder.VS.IProcessRunnerHostController, System.IDisposable
    {
        public System.Diagnostics.Process Process { get; }
        public virtual void Abort() { }
        public void Dispose() { }
        public abstract string GetTaskRunnerCommandLineArgs();
        public abstract JetBrains.Util.FileSystemPath GetTaskRunnerPath();
        public virtual void Run() { }
        public void RunAsync(System.Action<int> endAction) { }
    }
    public enum ProjectBuildState
    {
        Excluded = 0,
        Pending = 1,
        Running = 2,
        Completed = 3,
        Aborted = 4,
    }
    public class ProjectBuildStatusArg : System.EventArgs
    {
        public JetBrains.ReSharper.SolutionBuilder.VS.BuildErrorStatus ErrorStatus { get; }
        public JetBrains.ReSharper.SolutionBuilder.VS.SolutionBuilder2.Operation PerformedOperation { get; }
        public JetBrains.ProjectModel.IProject Project { get; }
    }
    public abstract class SolutionBuilder2 : System.IDisposable
    {
        public abstract bool IsBuildRunning { get; }
        public abstract bool IsSolutionBuilderActive { get; set; }
        public abstract string SelectedSolutionBuildProviderName { get; set; }
        public abstract System.Collections.Generic.IEnumerable<string> SolutionBuildProvidersList { get; }
        public event System.EventHandler<JetBrains.ReSharper.SolutionBuilder.VS.BuildAbortedEventArgs> BuildAborted;
        public event System.EventHandler<JetBrains.ReSharper.SolutionBuilder.VS.BuildMessageWildArgs> OutputLine;
        public event System.EventHandler<JetBrains.ReSharper.SolutionBuilder.VS.ProjectBuildStatusArg> ProjectBuildFinished;
        public event System.EventHandler<JetBrains.ReSharper.SolutionBuilder.VS.ProjectBuildStatusArg> ProjectBuildStarted;
        public event System.EventHandler<JetBrains.ReSharper.SolutionBuilder.VS.SolutionBuildFinishedStatusArg> SolutionBuildFinished;
        public event System.EventHandler<JetBrains.ReSharper.SolutionBuilder.VS.SolutionBuildStartStatusArg> SolutionBuildStarted;
        public abstract void Abort();
        public abstract void BuildProject(JetBrains.ProjectModel.IProject project);
        public abstract void BuildSolution();
        public abstract void ClearProject(JetBrains.ProjectModel.IProject project);
        public abstract void ClearSolution();
        public abstract void Dispose();
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.ReSharper.SolutionBuilder.VS.SolutionBuilder2 GetInstance(JetBrains.ProjectModel.ISolution solution) { }
        public abstract void RebuildProject(JetBrains.ProjectModel.IProject project);
        public abstract void RebuildSolution();
        public enum Operation
        {
            Clear = 0,
            Build = 1,
            Rebuild = 2,
            Idle = 3,
        }
    }
    public class SolutionBuilderVSTest
    {
        public string AssembliesListResourceName { get; }
        public System.Reflection.Assembly ConfigurationAssembly { get; }
        protected string RelativeTestDataPath { get; }
        protected void DoOneTest(string testName) { }
        public void testChangeApi() { }
        public void testChangeApi2() { }
        public void testCleanBuild() { }
        public void testResourceChange() { }
    }
    public class SolutionBuildFinishedStatusArg : JetBrains.ReSharper.SolutionBuilder.VS.SolutionBuildStatusArgBase
    {
        public SolutionBuildFinishedStatusArg(JetBrains.ReSharper.SolutionBuilder.VS.BuildErrorStatus result, int projectsBuiltCount, JetBrains.ReSharper.SolutionBuilder.VS.SolutionBuilder2.Operation operation) { }
        public JetBrains.ReSharper.SolutionBuilder.VS.BuildErrorStatus ErrorStatus { get; }
    }
    [JetBrains.Annotations.BaseTypeRequiredAttribute(typeof(JetBrains.ReSharper.SolutionBuilder.VS.ISolutionBuildProvider))]
    [System.AttributeUsageAttribute(System.AttributeTargets.Class | System.AttributeTargets.All, AllowMultiple=false, Inherited=false)]
    public class SolutionBuildProviderAttribute : System.Attribute
    {
        public SolutionBuildProviderAttribute(string name) { }
        public string Name { get; set; }
    }
    public class SolutionBuildStartStatusArg : JetBrains.ReSharper.SolutionBuilder.VS.SolutionBuildStatusArgBase
    {
        public SolutionBuildStartStatusArg(int projectsCount, JetBrains.ReSharper.SolutionBuilder.VS.SolutionBuilder2.Operation operation) { }
    }
    public class SolutionBuildStatusArgBase : System.EventArgs
    {
        public SolutionBuildStatusArgBase(int projectsCount, JetBrains.ReSharper.SolutionBuilder.VS.SolutionBuilder2.Operation operation) { }
        public JetBrains.ReSharper.SolutionBuilder.VS.SolutionBuilder2.Operation PerformedOperation { get; }
        public int ProjectsCount { get; }
    }
}
namespace JetBrains.ReSharper.SolutionBuilder.VS.IDE.Actions
{
    
    public abstract class BuildAndRunActionBase : JetBrains.ActionManagement.IActionHandler
    {
        protected BuildAndRunActionBase(JetBrains.ReSharper.SolutionBuilder.VS.IDE.Actions.BuildAndRunActionBase.ProjectOrSolution scope) { }
        public void Execute([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.DelegateExecute nextExecute) { }
        public JetBrains.ProjectModel.IProject GetProject([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.DataContext.IDataContext context) { }
        public bool Update([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.ActionPresentation presentation, JetBrains.ActionManagement.DelegateUpdate nextUpdate) { }
        public enum ProjectOrSolution
        {
            Project = 0,
            Solution = 1,
        }
    }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "SolutionBuilder2.BuildAndRunProject"})]
    public class BuildAndRunProjectAction : JetBrains.ReSharper.SolutionBuilder.VS.IDE.Actions.BuildAndRunActionBase
    {
        public BuildAndRunProjectAction() { }
    }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "SolutionBuilder2.BuildAndRunSolution"})]
    public class BuildAndRunSolutionAction : JetBrains.ReSharper.SolutionBuilder.VS.IDE.Actions.BuildAndRunActionBase
    {
        public BuildAndRunSolutionAction() { }
    }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "SolutionBuilder2.RunStartupProject"})]
    public class RunStartupProjectAction : JetBrains.ActionManagement.IActionHandler
    {
        public static bool NotifyTargetProcessStarted { get; }
        public static bool WaitForTargetProcess { get; }
        public static bool CloseSpawnedProcesses() { }
        public void Execute(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.DelegateExecute nextExecute) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static System.Diagnostics.Process StartProcess() { }
        public bool Update(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.ActionPresentation presentation, JetBrains.ActionManagement.DelegateUpdate nextUpdate) { }
    }
}
namespace JetBrains.ReSharper.SolutionBuilder.VS.IDE.VSWindows.Impl.VSWindowsTool
{
    
    public class static ActivityLog
    {
        public static void Print(JetBrains.ReSharper.SolutionBuilder.VS.IDE.VSWindows.Impl.VSWindowsTool.ActivityLogItem item) { }
        public static void Print(string source, string message) { }
        public static void Print(string source, string message, System.Guid guid) { }
        public static void Print(string source, string message, System.Guid guid, int hr) { }
        public static void Print(string source, string message, int hr) { }
        public static void Print(string source, string message, System.Guid guid, int hr, string path) { }
        public static void Print(string source, string message, System.Guid guid, string path) { }
        public static void Print(string source, string message, int hr, string path) { }
        public static void Print(string source, string message, string path) { }
        public static void Print(JetBrains.ReSharper.SolutionBuilder.VS.IDE.VSWindows.Impl.VSWindowsTool.ActivityLogType type, string source, string message) { }
        public static void Print(JetBrains.ReSharper.SolutionBuilder.VS.IDE.VSWindows.Impl.VSWindowsTool.ActivityLogType type, string source, string message, System.Guid guid) { }
        public static void Print(JetBrains.ReSharper.SolutionBuilder.VS.IDE.VSWindows.Impl.VSWindowsTool.ActivityLogType type, string source, string message, System.Guid guid, int hr) { }
        public static void Print(JetBrains.ReSharper.SolutionBuilder.VS.IDE.VSWindows.Impl.VSWindowsTool.ActivityLogType type, string source, string message, int hr) { }
        public static void Print(JetBrains.ReSharper.SolutionBuilder.VS.IDE.VSWindows.Impl.VSWindowsTool.ActivityLogType type, string source, string message, System.Guid guid, int hr, string path) { }
        public static void Print(JetBrains.ReSharper.SolutionBuilder.VS.IDE.VSWindows.Impl.VSWindowsTool.ActivityLogType type, string source, string message, System.Guid guid, string path) { }
        public static void Print(JetBrains.ReSharper.SolutionBuilder.VS.IDE.VSWindows.Impl.VSWindowsTool.ActivityLogType type, string source, string message, int hr, string path) { }
        public static void Print(JetBrains.ReSharper.SolutionBuilder.VS.IDE.VSWindows.Impl.VSWindowsTool.ActivityLogType type, string source, string message, string path) { }
    }
    public sealed class ActivityLogItem
    {
        public ActivityLogItem() { }
        public ActivityLogItem(string message) { }
        public ActivityLogItem(string source, string message) { }
        public ActivityLogItem(JetBrains.ReSharper.SolutionBuilder.VS.IDE.VSWindows.Impl.VSWindowsTool.ActivityLogType type, string message) { }
        public ActivityLogItem(JetBrains.ReSharper.SolutionBuilder.VS.IDE.VSWindows.Impl.VSWindowsTool.ActivityLogType type, string source, string message) { }
        public System.Nullable<System.Guid> Guid { get; set; }
        public System.Nullable<int> Hr { get; set; }
        public string Message { get; set; }
        public string Path { get; set; }
        public string Source { get; set; }
        public JetBrains.ReSharper.SolutionBuilder.VS.IDE.VSWindows.Impl.VSWindowsTool.ActivityLogType Type { get; set; }
    }
    public enum ActivityLogType
    {
        Information = 0,
        Warning = 1,
        Error = 2,
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Class | System.AttributeTargets.All)]
    public sealed class ClearWithSolutionAttribute : JetBrains.ReSharper.SolutionBuilder.VS.IDE.VSWindows.Impl.VSWindowsTool.Core.BoolAttribute
    {
        public ClearWithSolutionAttribute(bool value) { }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Class | System.AttributeTargets.All)]
    public sealed class InitiallyVisibleAttribute : JetBrains.ReSharper.SolutionBuilder.VS.IDE.VSWindows.Impl.VSWindowsTool.Core.BoolAttribute
    {
        public InitiallyVisibleAttribute(bool value) { }
    }
    public abstract class OutputPaneDefinition
    {
        protected OutputPaneDefinition() { }
        public bool ClearWithSolution { get; }
        public bool InitiallyVisible { get; }
        public bool IsSilent { get; }
        public string Name { get; }
        public virtual System.Guid PaneGUID { get; }
        public bool ThreadSafe { get; }
    }
    public class static OutputWindowAdapter
    {
        public static JetBrains.ReSharper.SolutionBuilder.VS.IDE.VSWindows.Impl.VSWindowsTool.OutputWindowPaneAdapter Build { get; }
        public static JetBrains.ReSharper.SolutionBuilder.VS.IDE.VSWindows.Impl.VSWindowsTool.OutputWindowPaneAdapter Debug { get; }
        public static JetBrains.ReSharper.SolutionBuilder.VS.IDE.VSWindows.Impl.VSWindowsTool.OutputWindowPaneAdapter General { get; }
        public static JetBrains.ReSharper.SolutionBuilder.VS.IDE.VSWindows.Impl.VSWindowsTool.Core.OutputPaneHandling OutputPaneHandling { get; set; }
        public static JetBrains.ReSharper.SolutionBuilder.VS.IDE.VSWindows.Impl.VSWindowsTool.OutputWindowPaneAdapter Silent { get; }
        public static JetBrains.ReSharper.SolutionBuilder.VS.IDE.VSWindows.Impl.VSWindowsTool.OutputWindowPaneAdapter CreateBuildOverridePane() { }
        public static JetBrains.ReSharper.SolutionBuilder.VS.IDE.VSWindows.Impl.VSWindowsTool.OutputWindowPaneAdapter CreatePane(System.Type type) { }
        public static JetBrains.ReSharper.SolutionBuilder.VS.IDE.VSWindows.Impl.VSWindowsTool.OutputWindowPaneAdapter CreateVirtual() { }
        public static JetBrains.ReSharper.SolutionBuilder.VS.IDE.VSWindows.Impl.VSWindowsTool.OutputWindowPaneAdapter GetPane(System.Type type) { }
        public static bool RemovePane(System.Type type) { }
    }
    public sealed class OutputWindowPaneAdapter
    {
        public EnvDTE.OutputWindowPane DTEPane { get; }
        public bool IsVirtual { get; }
        public string Name { get; set; }
        public Microsoft.VisualStudio.Shell.Interop.IVsOutputWindowPane Pane { get; }
        public bool ThreadSafe { get; set; }
        public void Activate() { }
        public void AddErrorListItem(string output) { }
        public void AddErrorListItem(string output, string projectName) { }
        public void Clear() { }
        public void FlushToTaskList() { }
        public static EnvDTE.Window GetOutputWindow() { }
        public void Hide() { }
        public void Print(string output) { }
        public void Print(string format, params object[] parameters) { }
        public void Print(System.IFormatProvider provider, string format, params object[] parameters) { }
        public void PrintLine(string output) { }
        public void PrintLine(string format, params object[] parameters) { }
        public void PrintLine(System.IFormatProvider provider, string format, params object[] parameters) { }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Class | System.AttributeTargets.All)]
    public sealed class PaneNameAttribute : JetBrains.ReSharper.SolutionBuilder.VS.IDE.VSWindows.Impl.VSWindowsTool.Core.StringAttribute
    {
        public PaneNameAttribute(string value) { }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Class | System.AttributeTargets.All)]
    public sealed class ThreadSafeAttribute : JetBrains.ReSharper.SolutionBuilder.VS.IDE.VSWindows.Impl.VSWindowsTool.Core.BoolAttribute
    {
        public ThreadSafeAttribute(bool value) { }
    }
}
namespace JetBrains.ReSharper.SolutionBuilder.VS.IDE.VSWindows.Impl.VSWindowsTool.Core
{
    
    public abstract class BoolAttribute : System.Attribute
    {
        protected BoolAttribute(bool value) { }
        public bool Value { get; }
    }
    public enum OutputPaneHandling
    {
        Silent = 0,
        ThrowException = 1,
        RedirectToGeneral = 2,
        RedirectToDebug = 3,
    }
    public abstract class StringAttribute : System.Attribute
    {
        protected StringAttribute(string value) { }
        public string Value { get; }
    }
    public sealed class WindowPaneNotFoundException : System.Exception
    {
        public WindowPaneNotFoundException(string message) { }
        public WindowPaneNotFoundException(System.Type type) { }
        public WindowPaneNotFoundException(System.Type type, System.Exception innerException) { }
        public WindowPaneNotFoundException(string message, System.Exception innerException) { }
        public WindowPaneNotFoundException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    }
}
namespace JetBrains.ReSharper.SolutionBuilder.VS.Impl
{
    
    public class BuildMessageParsed
    {
        public BuildMessageParsed(string projectName, JetBrains.Util.FileSystemPath file, int line, int column, string text, JetBrains.ReSharper.SolutionBuilder.VS.Impl.BuildMessageParsed.BuildMessageType type) { }
        public BuildMessageParsed(JetBrains.Util.FileSystemPath file, int line, int column, string text, JetBrains.ReSharper.SolutionBuilder.VS.Impl.BuildMessageParsed.BuildMessageType type) { }
        public BuildMessageParsed(JetBrains.Util.FileSystemPath file, string text) { }
        public BuildMessageParsed(string text, JetBrains.ReSharper.SolutionBuilder.VS.Impl.BuildMessageParsed.BuildMessageType type) { }
        public BuildMessageParsed(string text) { }
        public BuildMessageParsed(string description, System.Exception e) { }
        public int Column { get; }
        public JetBrains.Util.FileSystemPath File { get; set; }
        public bool IsError { get; }
        public bool IsWarning { get; }
        public int Line { get; }
        public JetBrains.ProjectModel.IProject Project { get; }
        public JetBrains.ProjectModel.IProjectFile ProjectFile { get; }
        public string ProjectName { get; }
        public string Text { get; }
        public JetBrains.ReSharper.SolutionBuilder.VS.Impl.BuildMessageParsed.BuildMessageType Type { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.ReSharper.SolutionBuilder.VS.Impl.BuildMessageParsed Parse(JetBrains.ReSharper.SolutionBuilder.VS.BuildMessageWildArgs args) { }
        public override string ToString() { }
        public enum BuildMessageType
        {
            Unknown = -1,
            Log = 0,
            Error = 1,
            Warning = 2,
        }
    }
    public class static ReferencesProjectsOrderer
    {
        public static System.Collections.Generic.IEnumerable<JetBrains.ProjectModel.IProject> GetOrderedProjectList(System.Collections.Generic.IEnumerable<JetBrains.ProjectModel.IProject> initialList) { }
    }
}
namespace JetBrains.ReSharper.SolutionBuilder.VS.Impl.Components
{
    
    public class SignatureManager : System.IDisposable
    {
        public SignatureManager([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.ISolution mySolution) { }
        public JetBrains.ReSharper.SolutionBuilder.VS.Signature.ProjectBuildAction CheckProjectSignature(JetBrains.ProjectModel.IProject project, out System.Collections.Generic.ICollection<> libFilesToCopy) { }
        public JetBrains.ReSharper.SolutionBuilder.VS.Signature.ProjectBuildAction CheckProjectSignature(System.Uri uriProjectIdentity) { }
        public void Dispose() { }
        public static JetBrains.ReSharper.SolutionBuilder.VS.Impl.Components.SignatureManager GetInstance([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.ISolution solution) { }
        public void RemoveSinature(JetBrains.ProjectModel.IProject project) { }
        public void SaveAlreadyBuiltProjectSignature(JetBrains.ProjectModel.IProject project) { }
    }
}
namespace JetBrains.ReSharper.SolutionBuilder.VS.Resources
{
    
    public sealed class SolutionBuilderVisualStudioThemedIcons
    {
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.SolutionBuilder.VS;component/Resources/SolutionBuilderVisualS" +
            "tudioThemedIcons/ThemedIcons.SolutionBuilderVisualStudio.Generated.Xaml", 8, "Aborted")]
        public sealed class Aborted : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.SolutionBuilder.VS;component/Resources/SolutionBuilderVisualS" +
            "tudioThemedIcons/ThemedIcons.SolutionBuilderVisualStudio.Generated.Xaml", 2, "BuildPending")]
        public sealed class BuildPending : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.SolutionBuilder.VS;component/Resources/SolutionBuilderVisualS" +
            "tudioThemedIcons/ThemedIcons.SolutionBuilderVisualStudio.Generated.Xaml", 5, "BuildRunningError")]
        public sealed class BuildRunningError : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.SolutionBuilder.VS;component/Resources/SolutionBuilderVisualS" +
            "tudioThemedIcons/ThemedIcons.SolutionBuilderVisualStudio.Generated.Xaml", 3, "BuildRunningWarning")]
        public sealed class BuildRunningWarning : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.SolutionBuilder.VS;component/Resources/SolutionBuilderVisualS" +
            "tudioThemedIcons/ThemedIcons.SolutionBuilderVisualStudio.Generated.Xaml", 9, "BuildStatusFailed")]
        public sealed class BuildStatusFailed : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.SolutionBuilder.VS;component/Resources/SolutionBuilderVisualS" +
            "tudioThemedIcons/ThemedIcons.SolutionBuilderVisualStudio.Generated.Xaml", 7, "BuildStatusSuccess")]
        public sealed class BuildStatusSuccess : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.SolutionBuilder.VS;component/Resources/SolutionBuilderVisualS" +
            "tudioThemedIcons/ThemedIcons.SolutionBuilderVisualStudio.Generated.Xaml", 13, "BuildStatusUpToDate")]
        public sealed class BuildStatusUpToDate : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.SolutionBuilder.VS;component/Resources/SolutionBuilderVisualS" +
            "tudioThemedIcons/ThemedIcons.SolutionBuilderVisualStudio.Generated.Xaml", 11, "BuildStatusWarning")]
        public sealed class BuildStatusWarning : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.SolutionBuilder.VS;component/Resources/SolutionBuilderVisualS" +
            "tudioThemedIcons/ThemedIcons.SolutionBuilderVisualStudio.Generated.Xaml", 1, "ClearSolution2")]
        public sealed class ClearSolution2 : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.SolutionBuilder.VS;component/Resources/SolutionBuilderVisualS" +
            "tudioThemedIcons/ThemedIcons.SolutionBuilderVisualStudio.Generated.Xaml", 6, "Excluded")]
        public sealed class Excluded : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.SolutionBuilder.VS;component/Resources/SolutionBuilderVisualS" +
            "tudioThemedIcons/ThemedIcons.SolutionBuilderVisualStudio.Generated.Xaml", 10, "RunBuild")]
        public sealed class RunBuild : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.SolutionBuilder.VS;component/Resources/SolutionBuilderVisualS" +
            "tudioThemedIcons/ThemedIcons.SolutionBuilderVisualStudio.Generated.Xaml", 12, "RunningBuild")]
        public sealed class RunningBuild : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.SolutionBuilder.VS;component/Resources/SolutionBuilderVisualS" +
            "tudioThemedIcons/ThemedIcons.SolutionBuilderVisualStudio.Generated.Xaml", 0, "StopBuild")]
        public sealed class StopBuild : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.SolutionBuilder.VS;component/Resources/SolutionBuilderVisualS" +
            "tudioThemedIcons/ThemedIcons.SolutionBuilderVisualStudio.Generated.Xaml", 4, "TrackBuild")]
        public sealed class TrackBuild : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
    }
}
namespace JetBrains.ReSharper.SolutionBuilder.VS.Signature
{
    
    public enum ProjectBuildAction
    {
        Uptodate = 0,
        CopyLibraries = 1,
        Rebuild = 2,
        Publish = 3,
    }
}
namespace JetBrains.ReSharper.VS.SolutionBuilder
{
    
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class VsSolutionBuilder : EnvDTE._dispBuildEvents, JetBrains.ReSharper.SolutionBuilder.ISolutionBuilder, System.IDisposable
    {
        public readonly JetBrains.Threading.JetDispatcher Dispatcher;
        public static readonly double SolutionBuilderImplementationPriority;
        public VsSolutionBuilder([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.ISolution solution, Microsoft.VisualStudio.Shell.Interop.IVsSolutionBuildManager2 vsSolutionBuildManager2, JetBrains.VsIntegration.ProjectModel.ProjectModelSynchronizer projectModelSynchronizer) { }
        public JetBrains.DataFlow.IProperty<JetBrains.ReSharper.SolutionBuilder.SolBuilderDuo.BuildSession> RunningSession { get; }
        public void Abort() { }
        public void BeginRun([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.SolutionBuilder.SolBuilderDuo.BuildSession session) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.ReSharper.SolutionBuilder.SolBuilderDuo.BuildSession CreateBuildSessionFromVsSolution([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.SolutionBuilder.SolBuilderDuo.BuildSessionSeverity severity, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IProject[] projectsToBuild) { }
        public JetBrains.ReSharper.SolutionBuilder.SolBuilderDuo.BuildSession CreateSession(JetBrains.ReSharper.SolutionBuilder.SolBuilderDuo.BuildSessionSeverity severity, [JetBrains.Annotations.NotNullAttribute()] params JetBrains.ProjectModel.IProject[] projectsToBuild) { }
        public void Dispose() { }
        public void OnBuildBegin(EnvDTE.vsBuildScope Scope, EnvDTE.vsBuildAction Action) { }
        public void OnBuildDone(EnvDTE.vsBuildScope Scope, EnvDTE.vsBuildAction Action) { }
        public void OnBuildProjConfigBegin(string sVsProject, string ProjectConfig, string Platform, string SolutionConfig) { }
        public void OnBuildProjConfigDone(string sVsProject, string ProjectConfig, string Platform, string SolutionConfig, bool Success) { }
    }
}