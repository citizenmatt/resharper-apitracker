[assembly: JetBrains.ActionManagement.ActionsXmlAttribute("JetBrains.ReSharper.SolutionBuilder.resources.Actions.xml")]
[assembly: JetBrains.UI.Icons.CompiledIcons.CompiledIconsPackAttribute(IconNames=new string[] {
        "RebuildProject",
        "FinishedWarnings",
        "ViewSource",
        "ClearSolution",
        "InProgressErrors",
        "BuildSolution",
        "InProgressWarnings",
        "CancelBuild",
        "RebuildSolution",
        "Output",
        "FinishedOK",
        "BuildWarning",
        "BuildError",
        "CleanProject",
        "InProgressOK",
        "FinishedBuildErrors",
        "BuildProject",
        "FinishedUpToDate",
        "ViewOutput"}, IconPackResourceIdentification="JetBrains.ReSharper.SolutionBuilder;component/resources/SolutionBuilderCompilerTh" +
    "emedIcons/ThemedIcons.SolutionBuilderCompiler.Generated.Xaml")]
[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]
[assembly: System.Windows.Markup.XmlnsDefinitionAttribute("urn:shemas-jetbrains-com:ui-application-icons-solution-builder-compiler", "JetBrains.ReSharper.SolutionBuilder.Resources")]

namespace JetBrains.ComponentModel
{
    
    public class GetInstance<TInstance, TParameter>
        where TInstance :  class
        where TParameter :  class
    {
        public GetInstance([JetBrains.Annotations.NotNullAttribute()] System.Func<TParameter, TInstance> funcGetter) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public TInstance this[TParameter parameter] { get; }
    }
    public class TryGetInstance<TInstance, TParameter>
        where TInstance :  class
        where TParameter :  class
    {
        public TryGetInstance([JetBrains.Annotations.NotNullAttribute()] System.Func<TParameter, TInstance> funcGetter) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public TInstance this[TParameter parameter] { get; }
    }
}
namespace JetBrains.ReSharper.SolutionBuilder
{
    
    public class BuildMessage
    {
        public BuildMessage(string projectName, JetBrains.Util.FileSystemPath file, int line, int column, string text, JetBrains.ReSharper.SolutionBuilder.BuildMessageType type) { }
        public BuildMessage(JetBrains.Util.FileSystemPath file, int line, int column, string text, JetBrains.ReSharper.SolutionBuilder.BuildMessageType type) { }
        public BuildMessage(JetBrains.Util.FileSystemPath file, string text) { }
        public BuildMessage(string text, JetBrains.ReSharper.SolutionBuilder.BuildMessageType type) { }
        public BuildMessage(string text) { }
        public BuildMessage(string description, System.Exception ex) { }
        public int Column { get; }
        public JetBrains.Util.FileSystemPath File { get; set; }
        public bool IsError { get; }
        public bool IsProgress { get; }
        public bool IsWariningReference { get; }
        public bool IsWarning { get; }
        public int Line { get; }
        public string ProjectName { get; set; }
        public string Text { get; }
        public JetBrains.ReSharper.SolutionBuilder.BuildMessageType Type { get; }
    }
    public class BuildMessageCollection : System.Collections.Generic.IEnumerable<JetBrains.ReSharper.SolutionBuilder.BuildMessage>, System.Collections.IEnumerable
    {
        public BuildMessageCollection() { }
        public BuildMessageCollection(JetBrains.ReSharper.SolutionBuilder.BuildMessage err) { }
        public BuildMessageCollection(JetBrains.ReSharper.SolutionBuilder.BuildMessageCollection ec) { }
        public int ErrorsCount { get; }
        public bool HasErrors { get; }
        public bool HasWarnings { get; }
        public JetBrains.ReSharper.SolutionBuilder.BuildMessage this[int i] { get; }
        public int WarningsCount { get; }
        public void Add(JetBrains.ReSharper.SolutionBuilder.BuildMessage message) { }
        public void AddRange(JetBrains.ReSharper.SolutionBuilder.BuildMessageCollection collection) { }
        public System.Collections.Generic.IEnumerator<JetBrains.ReSharper.SolutionBuilder.BuildMessage> GetEnumerator() { }
    }
    public enum BuildMessageType
    {
        UNKNOWN = -1,
        PROGRESS = 0,
        LOG = 1,
        ERROR = 2,
        WARNING = 3,
        WARNING_REFERENCE = 4,
    }
    public class CollectedFiles
    {
        public CollectedFiles() { }
        public System.Collections.Generic.List<JetBrains.ProjectModel.IProjectFile> AllFiles { get; }
        public System.Collections.Generic.List<JetBrains.ReSharper.SolutionBuilder.IResourceFile> ResourceFiles { get; }
        public System.Collections.Generic.List<JetBrains.ProjectModel.IProjectFile> SourceFiles { get; }
        public System.Collections.Generic.List<JetBrains.ProjectModel.IProjectFile> XamlFiles { get; }
    }
    public class EmptySolutionBuilder : JetBrains.ReSharper.SolutionBuilder.ISolutionBuilder
    {
        public EmptySolutionBuilder() { }
        public JetBrains.DataFlow.IProperty<JetBrains.ReSharper.SolutionBuilder.SolBuilderDuo.BuildSession> RunningSession { get; }
        public void Abort() { }
        public void BeginRun(JetBrains.ReSharper.SolutionBuilder.SolBuilderDuo.BuildSession session) { }
        public JetBrains.ReSharper.SolutionBuilder.SolBuilderDuo.BuildSession CreateSession(JetBrains.ReSharper.SolutionBuilder.SolBuilderDuo.BuildSessionSeverity severity, params JetBrains.ProjectModel.IProject[] projectsToBuild) { }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Class | System.AttributeTargets.All)]
    public class FilesCollectorAttribute : System.Attribute { }
    [JetBrains.Annotations.MeansImplicitUseAttribute()]
    [System.AttributeUsageAttribute(System.AttributeTargets.Class | System.AttributeTargets.All)]
    public class FilesCompilerAttribute : System.Attribute { }
    public interface IBuildLogger
    {
        void LogBuildAction(string text, params object[] args);
    }
    public interface IBuildProcess
    {
        public event JetBrains.ReSharper.SolutionBuilder.OutputLineHandler ConsoleOutputLine;
        void Abort();
    }
    public interface IBuildResultsControl : JetBrains.ReSharper.SolutionBuilder.IBuildLogger, JetBrains.UI.ActionSystem.Actions.IExpandCollapseProvider
    {
        bool WarningsVisible { get; }
        void AddMessage(JetBrains.ProjectModel.IProject project, JetBrains.ReSharper.SolutionBuilder.BuildMessage message);
        void AddOutput(string line);
        void AddProject(JetBrains.ProjectModel.IProject project);
        void AddSolution(JetBrains.ProjectModel.ISolution solution, bool isRebuild, int nProjectsToProcess);
        void BuildAborted();
        bool CanGotoOutput();
        bool CanGotoSource();
        bool CanNavigate(bool forward);
        void Clear();
        void GotoOutput();
        void GotoSource();
        void ProjectBuildFinished(JetBrains.ProjectModel.IProject project, bool wasUpToDate);
        void SolutionBuildFinished(bool wasUpToDate);
        void ToggleWarnings();
    }
    public interface IFilesCollector
    {
        JetBrains.ProjectModel.ProjectFileType LanguageType { get; }
        JetBrains.ReSharper.SolutionBuilder.CollectedFiles CollectFiles(JetBrains.ProjectModel.IProject project, JetBrains.ReSharper.SolutionBuilder.IProjectSignature oldSignature);
        string GetBaseClassName(JetBrains.ReSharper.Psi.Tree.ITypeDeclaration typeDecl);
        System.Collections.Generic.ICollection<string> GetImportedNamespaces(JetBrains.ProjectModel.IProject project, JetBrains.ReSharper.Psi.Tree.IFile file);
        void Reset();
    }
    public interface IFilesCompiler : JetBrains.ReSharper.SolutionBuilder.IBuildProcess
    {
        JetBrains.ProjectModel.ProjectFileType LanguageType { get; }
        void BuildSources(JetBrains.ProjectModel.IProject project, System.Collections.Generic.IList<JetBrains.ProjectModel.Properties.IProjectConfiguration> configurations, JetBrains.ProjectModel.IProjectFile[] sourceFiles, JetBrains.ReSharper.SolutionBuilder.IResourceFile[] resources, JetBrains.ReSharper.SolutionBuilder.BuildMessageCollection messages);
        void Reset();
    }
    public interface IProjectSignature
    {
        string GetAssemblyResourceName(JetBrains.Util.FileSystemPath resxFilePath);
        System.DateTime GetFileTime(JetBrains.Util.FileSystemPath sourceFile);
        JetBrains.Util.FileSystemPath GetGetDependsUponItem(JetBrains.Util.FileSystemPath resxFilePath);
    }
    public interface IResourceFile
    {
        string AssemblyResourceName { get; }
        JetBrains.ProjectModel.IProjectFile DependsUponFile { get; }
        bool IsCompilable { get; }
        JetBrains.ProjectModel.IProjectFile SourceFile { get; }
    }
    public interface ISolutionBuilder
    {
        JetBrains.DataFlow.IProperty<JetBrains.ReSharper.SolutionBuilder.SolBuilderDuo.BuildSession> RunningSession { get; }
        void Abort();
        void BeginRun([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.SolutionBuilder.SolBuilderDuo.BuildSession session);
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.SolutionBuilder.SolBuilderDuo.BuildSession CreateSession(JetBrains.ReSharper.SolutionBuilder.SolBuilderDuo.BuildSessionSeverity severity, [JetBrains.Annotations.NotNullAttribute()] params JetBrains.ProjectModel.IProject[] projectsToBuild);
    }
    public delegate void OutputLineHandler(string line);
    [JetBrains.Application.Settings.SettingsKeyAttribute(typeof(JetBrains.ProjectModel.Settings.Schema.BuildSettings), "Run startup project settings")]
    public class RunStartupProjectSettings
    {
        [JetBrains.Application.Settings.SettingsEntryAttribute(true, "Whether to notify of target process started.")]
        public bool NotifyTargetProcessStarted;
        [JetBrains.Application.Settings.SettingsEntryAttribute(true, "Whether to wait for the target process to exit before running the build-and-run a" +
            "ction.")]
        public bool WaitForTargetProcess;
    }
    [JetBrains.Application.Configuration.Upgrade.GlobalSettingsUpgraderAttribute()]
    public class RunStartupProjectSettingsUpgrader : JetBrains.Application.Configuration.SettingTablesUpgrader
    {
        public RunStartupProjectSettingsUpgrader(JetBrains.Application.Env.RunsProducts.ProductConfigurations productConfigurations) { }
        protected override void DoUpgrade(JetBrains.Application.Configuration.IComponentSettingsProvider legacySettingsProvider, JetBrains.Application.Settings.IContextBoundSettingsStore boundSettingsStore, JetBrains.DataFlow.Lifetime upgradeLifetime, JetBrains.Application.Configuration.SettingsTableBase workspaceSettingsTable, JetBrains.Application.Configuration.SettingsTableBase globalSettingsTable) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class SolutionBuilder : JetBrains.ReSharper.SolutionBuilder.ISolutionBuilder
    {
        public readonly JetBrains.DataFlow.Property<JetBrains.ReSharper.SolutionBuilder.ISolutionBuilder> ActiveImplementation;
        public readonly JetBrains.DataFlow.ListEvents<JetBrains.Util.JetTuple<double, JetBrains.ReSharper.SolutionBuilder.ISolutionBuilder>> Implementations;
        public SolutionBuilder(JetBrains.DataFlow.Lifetime lifetime) { }
        public JetBrains.DataFlow.IProperty<JetBrains.ReSharper.SolutionBuilder.SolBuilderDuo.BuildSession> RunningSession { get; }
        public void Abort() { }
        public void BeginRun([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.SolutionBuilder.SolBuilderDuo.BuildSession session) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ReSharper.SolutionBuilder.SolBuilderDuo.BuildSession CreateSession(JetBrains.ReSharper.SolutionBuilder.SolBuilderDuo.BuildSessionSeverity severity, [JetBrains.Annotations.NotNullAttribute()] params JetBrains.ProjectModel.IProject[] projectsToBuild) { }
        public static JetBrains.Util.FileSystemPath GetProjectFullPath([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IProject project) { }
        public static bool IsProject([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IProject project) { }
    }
    public class static SolutionBuilderEx { }
}
namespace JetBrains.ReSharper.SolutionBuilder.Impl
{
    
    public class static BuildFileUtil
    {
        public static JetBrains.ReSharper.SolutionBuilder.BuildMessage CopyFile(JetBrains.Util.FileSystemPath srcFile, JetBrains.Util.FileSystemPath dstFile) { }
        public static JetBrains.ReSharper.SolutionBuilder.BuildMessage CopyFile(JetBrains.Util.FileSystemPath srcFile, JetBrains.Util.FileSystemPath dstFile, bool force) { }
        public static JetBrains.ReSharper.SolutionBuilder.BuildMessage CreateDirectory(JetBrains.Util.FileSystemPath directory) { }
        public static JetBrains.ReSharper.SolutionBuilder.BuildMessage DeleteFile(JetBrains.Util.FileSystemPath file) { }
        public static JetBrains.ReSharper.SolutionBuilder.BuildMessage DeleteFile(JetBrains.Util.FileSystemPath file, bool force, bool justLocked) { }
        public static JetBrains.ReSharper.SolutionBuilder.BuildMessage DeleteFile(JetBrains.Util.FileSystemPath file, bool force) { }
        public static bool IsFileLocked(JetBrains.Util.FileSystemPath file) { }
        public static void RemoveShadowFiles(JetBrains.Util.FileSystemPath file) { }
    }
    public abstract class BuildProcess : JetBrains.ReSharper.SolutionBuilder.IBuildProcess
    {
        protected JetBrains.ReSharper.SolutionBuilder.Impl.ProcessRunner CurrentProcess { get; set; }
        public event JetBrains.ReSharper.SolutionBuilder.OutputLineHandler ConsoleOutputLine;
        public void Abort() { }
        public static JetBrains.ProjectModel.Properties.Managed.IManagedProjectConfiguration GetConfiguration(JetBrains.ProjectModel.IProject project, System.Collections.Generic.IList<JetBrains.ProjectModel.Properties.IProjectConfiguration> configurations) { }
        protected bool IsAborted() { }
        protected void OnOutputLine(string line) { }
        public virtual void Reset() { }
    }
    public class ProcessRunner
    {
        public ProcessRunner(JetBrains.Util.FileSystemPath procName, string procParams, JetBrains.Util.FileSystemPath workingDirectory) { }
        public event JetBrains.ReSharper.SolutionBuilder.OutputLineHandler ErrorLine;
        public event JetBrains.ReSharper.SolutionBuilder.Impl.ProcessRunner.ExitHandler Exited;
        public event JetBrains.ReSharper.SolutionBuilder.OutputLineHandler OutputLine;
        public delegate void ExitHandler(JetBrains.ReSharper.SolutionBuilder.Impl.ProcessRunner process, int exitCode);
    }
    public class SignatureAssemblySerializer
    {
        public SignatureAssemblySerializer() { }
        public System.Xml.XmlDocument Document { get; }
        public void SerializeAssembly(JetBrains.Metadata.Reader.API.IMetadataAssembly assembly) { }
        public System.Xml.XmlElement SerializeType(JetBrains.Metadata.Reader.API.IMetadataTypeInfo type) { }
        public System.Xml.XmlElement SerializeValueType(JetBrains.Metadata.Reader.API.IMetadataType type) { }
    }
    public class SolutionBuilderImpl { }
}
namespace JetBrains.ReSharper.SolutionBuilder.Impl.MSBuild
{
    
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class MSBuildCompiler : JetBrains.ReSharper.SolutionBuilder.Impl.BuildProcess, JetBrains.ReSharper.SolutionBuilder.IBuildProcess, JetBrains.ReSharper.SolutionBuilder.IFilesCompiler, JetBrains.ReSharper.SolutionBuilder.ILoggingFilesCompiler
    {
        public readonly JetBrains.DataFlow.IProperty<JetBrains.ReSharper.SolutionBuilder.Impl.MSBuild.MSBuildCompiler.IMSBuildCompilerImpl> Implementation;
        public MSBuildCompiler(JetBrains.DataFlow.Lifetime lifetime) { }
        public static JetBrains.ComponentModel.GetInstance<JetBrains.ReSharper.SolutionBuilder.Impl.MSBuild.MSBuildCompiler, JetBrains.ProjectModel.ISolution> Instance { get; }
        public JetBrains.ProjectModel.ProjectFileType LanguageType { get; }
        public static JetBrains.ComponentModel.TryGetInstance<JetBrains.ReSharper.SolutionBuilder.Impl.MSBuild.MSBuildCompiler, JetBrains.ProjectModel.ISolution> TryInstance { get; }
        public void BuildSources(JetBrains.ProjectModel.IProject project, System.Collections.Generic.IList<JetBrains.ProjectModel.Properties.IProjectConfiguration> configurations, JetBrains.ProjectModel.IProjectFile[] sourceFiles, JetBrains.ReSharper.SolutionBuilder.IResourceFile[] resources, JetBrains.ReSharper.SolutionBuilder.BuildMessageCollection messages) { }
        public void SetLogger(JetBrains.ReSharper.SolutionBuilder.IBuildLogger logger) { }
        public interface IMSBuildCompilerImpl
        {
            JetBrains.DataFlow.ISignal<string> OutputLine { get; }
            void BuildSources(JetBrains.ProjectModel.IProject project, System.Collections.Generic.IList<JetBrains.ProjectModel.Properties.IProjectConfiguration> configurations, JetBrains.ProjectModel.IProjectFile[] sourceFiles, JetBrains.ReSharper.SolutionBuilder.IResourceFile[] resources, JetBrains.ReSharper.SolutionBuilder.BuildMessageCollection messages);
            void SetLogger(JetBrains.ReSharper.SolutionBuilder.IBuildLogger logger);
        }
    }
}
namespace JetBrains.ReSharper.SolutionBuilder.Resources
{
    
    public sealed class SolutionBuilderCompilerThemedIcons
    {
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.SolutionBuilder;component/resources/SolutionBuilderCompilerTh" +
            "emedIcons/ThemedIcons.SolutionBuilderCompiler.Generated.Xaml", 12, "BuildError")]
        public sealed class BuildError : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.SolutionBuilder;component/resources/SolutionBuilderCompilerTh" +
            "emedIcons/ThemedIcons.SolutionBuilderCompiler.Generated.Xaml", 16, "BuildProject")]
        public sealed class BuildProject : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.SolutionBuilder;component/resources/SolutionBuilderCompilerTh" +
            "emedIcons/ThemedIcons.SolutionBuilderCompiler.Generated.Xaml", 5, "BuildSolution")]
        public sealed class BuildSolution : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.SolutionBuilder;component/resources/SolutionBuilderCompilerTh" +
            "emedIcons/ThemedIcons.SolutionBuilderCompiler.Generated.Xaml", 11, "BuildWarning")]
        public sealed class BuildWarning : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.SolutionBuilder;component/resources/SolutionBuilderCompilerTh" +
            "emedIcons/ThemedIcons.SolutionBuilderCompiler.Generated.Xaml", 7, "CancelBuild")]
        public sealed class CancelBuild : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.SolutionBuilder;component/resources/SolutionBuilderCompilerTh" +
            "emedIcons/ThemedIcons.SolutionBuilderCompiler.Generated.Xaml", 13, "CleanProject")]
        public sealed class CleanProject : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.SolutionBuilder;component/resources/SolutionBuilderCompilerTh" +
            "emedIcons/ThemedIcons.SolutionBuilderCompiler.Generated.Xaml", 3, "ClearSolution")]
        public sealed class ClearSolution : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.SolutionBuilder;component/resources/SolutionBuilderCompilerTh" +
            "emedIcons/ThemedIcons.SolutionBuilderCompiler.Generated.Xaml", 15, "FinishedBuildErrors")]
        public sealed class FinishedBuildErrors : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.SolutionBuilder;component/resources/SolutionBuilderCompilerTh" +
            "emedIcons/ThemedIcons.SolutionBuilderCompiler.Generated.Xaml", 10, "FinishedOK")]
        public sealed class FinishedOK : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.SolutionBuilder;component/resources/SolutionBuilderCompilerTh" +
            "emedIcons/ThemedIcons.SolutionBuilderCompiler.Generated.Xaml", 17, "FinishedUpToDate")]
        public sealed class FinishedUpToDate : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.SolutionBuilder;component/resources/SolutionBuilderCompilerTh" +
            "emedIcons/ThemedIcons.SolutionBuilderCompiler.Generated.Xaml", 1, "FinishedWarnings")]
        public sealed class FinishedWarnings : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.SolutionBuilder;component/resources/SolutionBuilderCompilerTh" +
            "emedIcons/ThemedIcons.SolutionBuilderCompiler.Generated.Xaml", 4, "InProgressErrors")]
        public sealed class InProgressErrors : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.SolutionBuilder;component/resources/SolutionBuilderCompilerTh" +
            "emedIcons/ThemedIcons.SolutionBuilderCompiler.Generated.Xaml", 14, "InProgressOK")]
        public sealed class InProgressOK : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.SolutionBuilder;component/resources/SolutionBuilderCompilerTh" +
            "emedIcons/ThemedIcons.SolutionBuilderCompiler.Generated.Xaml", 6, "InProgressWarnings")]
        public sealed class InProgressWarnings : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.SolutionBuilder;component/resources/SolutionBuilderCompilerTh" +
            "emedIcons/ThemedIcons.SolutionBuilderCompiler.Generated.Xaml", 9, "Output")]
        public sealed class Output : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.SolutionBuilder;component/resources/SolutionBuilderCompilerTh" +
            "emedIcons/ThemedIcons.SolutionBuilderCompiler.Generated.Xaml", 0, "RebuildProject")]
        public sealed class RebuildProject : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.SolutionBuilder;component/resources/SolutionBuilderCompilerTh" +
            "emedIcons/ThemedIcons.SolutionBuilderCompiler.Generated.Xaml", 8, "RebuildSolution")]
        public sealed class RebuildSolution : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.SolutionBuilder;component/resources/SolutionBuilderCompilerTh" +
            "emedIcons/ThemedIcons.SolutionBuilderCompiler.Generated.Xaml", 18, "ViewOutput")]
        public sealed class ViewOutput : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.SolutionBuilder;component/resources/SolutionBuilderCompilerTh" +
            "emedIcons/ThemedIcons.SolutionBuilderCompiler.Generated.Xaml", 2, "ViewSource")]
        public sealed class ViewSource : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
    }
}
namespace JetBrains.ReSharper.SolutionBuilder.SolBuilderDuo
{
    
    public class BuildSession : System.IDisposable
    {
        public readonly JetBrains.DataFlow.IListEvents<JetBrains.ReSharper.SolutionBuilder.SolBuilderDuo.SolBuildEvent> BuildEventsNonProject;
        public readonly JetBrains.ReSharper.SolutionBuilder.SolBuilderDuo.BuildSessionSeverity BuildSeverity;
        public readonly string ConfigurationName;
        public readonly JetBrains.Threading.JetDispatcher Dispatcher;
        public readonly string PlatformName;
        public readonly JetBrains.DataFlow.ListEvents<JetBrains.ReSharper.SolutionBuilder.SolBuilderDuo.BuildSessionProject> Projects;
        public readonly JetBrains.Util.FileSystemPath[] ProjectsMustBeBuilt;
        public readonly JetBrains.Util.FileSystemPath SolutionFile;
        public readonly JetBrains.DataFlow.IProperty<JetBrains.ReSharper.SolutionBuilder.SolBuilderDuo.BuildSessionState> State;
        public BuildSession([JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.FileSystemPath solutionfile, JetBrains.ReSharper.SolutionBuilder.SolBuilderDuo.BuildSessionSeverity severity, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.FileSystemPath[] pathProjectsMustBeBuilt, [JetBrains.Annotations.NotNullAttribute()] string sConfigurationName, [JetBrains.Annotations.NotNullAttribute()] string sPlatformName) { }
        public void Dispose() { }
    }
    public enum BuildSessionErrorStatus
    {
        Clean = 0,
        Warnings = 1,
        Errors = 2,
    }
    public class static BuildSessionEx
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.DataFlow.ISignal<JetBrains.DataFlow.AddRemoveIndexEventArgs<JetBrains.ReSharper.SolutionBuilder.SolBuilderDuo.SolBuildEvent>> CreateBuildEventsAddRemove([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.SolutionBuilder.SolBuilderDuo.BuildSession session, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.DataFlow.IProperty<JetBrains.ReSharper.SolutionBuilder.SolBuilderDuo.BuildSessionProjectErrorStatus> CreateProjectErrorStatus([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.SolutionBuilder.SolBuilderDuo.BuildSessionProject project, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime) { }
        public static System.Func<JetBrains.Util.FileSystemPath, JetBrains.ReSharper.SolutionBuilder.SolBuilderDuo.BuildSessionProject> CreateProjectFullPathCache([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.SolutionBuilder.SolBuilderDuo.BuildSession session) { }
        public static JetBrains.DataFlow.DictionaryEvents<JetBrains.Util.FileSystemPath, JetBrains.ReSharper.SolutionBuilder.SolBuilderDuo.BuildSessionProject> CreateProjectFullPathCache2([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.SolutionBuilder.SolBuilderDuo.BuildSession session, JetBrains.DataFlow.Lifetime lifetime) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.DataFlow.IProperty<JetBrains.ReSharper.SolutionBuilder.SolBuilderDuo.BuildSessionProjectErrorStatus> CreateSessionErrorStatus([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.SolutionBuilder.SolBuilderDuo.BuildSession session, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime) { }
        public static System.Collections.Generic.IEnumerable<JetBrains.ReSharper.SolutionBuilder.SolBuilderDuo.SolBuildEvent> GetAllBuildEvents([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.SolutionBuilder.SolBuilderDuo.BuildSession session) { }
        public static bool IsSuccessful([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.SolutionBuilder.SolBuilderDuo.BuildSessionProject project) { }
        public static bool IsSuccessful([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.SolutionBuilder.SolBuilderDuo.BuildSession session) { }
    }
    public class BuildSessionProject : System.IEquatable<JetBrains.ReSharper.SolutionBuilder.SolBuilderDuo.BuildSessionProject>
    {
        public readonly JetBrains.DataFlow.IListEvents<JetBrains.ReSharper.SolutionBuilder.SolBuilderDuo.SolBuildEvent> BuildEvents;
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly JetBrains.DataFlow.Property<JetBrains.ReSharper.SolutionBuilder.SolBuilderDuo.BuildSessionProjectBuildState> BuildState;
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly JetBrains.Util.FileSystemPath FullPath;
        public BuildSessionProject([JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.FileSystemPath fullpath) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public string Name { get; }
        public override bool Equals(object obj) { }
        public bool Equals(JetBrains.ReSharper.SolutionBuilder.SolBuilderDuo.BuildSessionProject projectData) { }
        public override int GetHashCode() { }
        [JetBrains.Annotations.NotNullAttribute()]
        public override string ToString() { }
    }
    public enum BuildSessionProjectBuildState
    {
        Excluded = 0,
        Pending = 1,
        Running = 2,
        Completed = 3,
    }
    public enum BuildSessionProjectErrorStatus
    {
        Clean = 0,
        Warnings = 1,
        Errors = 2,
    }
    public enum BuildSessionSeverity
    {
        Clean = 0,
        Rebuild = 1,
        Build = 2,
    }
    public enum BuildSessionState
    {
        Waiting = 0,
        Running = 1,
        Completed = 2,
    }
    public class SolBuildEvent : System.Runtime.Serialization.ISerializable
    {
        public readonly string HelpKeyword;
        public readonly JetBrains.ReSharper.SolutionBuilder.SolBuilderDuo.SolBuildEventImportance Importance;
        public readonly JetBrains.ReSharper.SolutionBuilder.SolBuilderDuo.SolBuildEventKind Kind;
        public readonly string Message;
        public readonly string SenderName;
        public readonly System.DateTime TimeStamp;
        public SolBuildEvent(JetBrains.ReSharper.SolutionBuilder.SolBuilderDuo.SolBuildEventKind kind, string message, string senderName, System.Nullable<System.DateTime> timestamp, string helpKeyword, JetBrains.ReSharper.SolutionBuilder.SolBuilderDuo.SolBuildEventImportance importance) { }
        protected SolBuildEvent(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        protected virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo info) { }
        public override string ToString() { }
    }
    public enum SolBuildEventImportance
    {
        High = 0,
        Normal = 1,
        Low = 2,
    }
    public enum SolBuildEventKind
    {
        Output = 0,
        Service = 1,
        Console = 2,
        Warning = 3,
        Error = 4,
    }
    public class SolBuildEventWithLocation : JetBrains.ReSharper.SolutionBuilder.SolBuilderDuo.SolBuildEvent
    {
        public readonly string Code;
        public readonly int ColumnNumber;
        public readonly int EndColumnNumber;
        public readonly int EndLineNumber;
        public readonly string File;
        public readonly int LineNumber;
        public readonly string Subcategory;
        public SolBuildEventWithLocation(JetBrains.ReSharper.SolutionBuilder.SolBuilderDuo.SolBuildEventKind kind, string message, string senderName, System.DateTime timestamp, string helpKeyword, string file, string code, int lineNumber, int columnNumber, int endLineNumber, int endColumnNumber, string subcategory) { }
        protected SolBuildEventWithLocation(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        protected override void GetObjectData(System.Runtime.Serialization.SerializationInfo info) { }
    }
}
namespace JetBrains.ReSharper.SolutionCompiler.Impl
{
    
    public class static ConfigurationsUtil
    {
        public static JetBrains.ProjectModel.Properties.Managed.IManagedProjectConfiguration GetConfiguration(JetBrains.ProjectModel.IProject project, System.Collections.Generic.IEnumerable<JetBrains.ProjectModel.Properties.IProjectConfiguration> configurations) { }
        public static System.Collections.Generic.IList<JetBrains.ProjectModel.Properties.IProjectConfiguration> GetConfigurations(JetBrains.ProjectModel.ISolution solution) { }
    }
    public class DependenciesBuilder
    {
        public DependenciesBuilder(JetBrains.ProjectModel.ISolution solution, JetBrains.ProjectModel.IProject project, System.Collections.Generic.IList<JetBrains.ProjectModel.Properties.IProjectConfiguration> configurations) { }
        public JetBrains.ProjectModel.IProject[] BuildOrder { get; }
        public JetBrains.ProjectModel.IProject Project { get; }
        public JetBrains.ProjectModel.ISolution Solution { get; }
    }
}