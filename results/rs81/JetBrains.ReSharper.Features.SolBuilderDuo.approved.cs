[assembly: JetBrains.Application.Install.InstallFileAttribute("MsbuildExeConfig", JetBrains.Application.Install.InstallationData.InstallationTargetDirRoot.InstallDir, "", JetBrains.Application.Install.InstallationData.InstallationSourceDirRoot2.ReferencesDirectories, "MSBuild.Exe.Config")]
[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]

namespace JetBrains.ReSharper.Features.SolBuilderDuo.Engine.Common.AssemblySurface
{
    
    public class AssemblySurfaceCache
    {
        [System.ObsoleteAttribute("Do not use in code. For XAML serialization only.")]
        public AssemblySurfaceCache() { }
        public string Algorithm { get; set; }
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)]
        public JetBrains.DataFlow.ListEvents<JetBrains.ReSharper.Features.SolBuilderDuo.Engine.Common.AssemblySurface.AssemblySurfaceHash> AssemblySurfaceHashes { get; }
        public static string CurrentAlgorithm { get; }
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)]
        public JetBrains.DataFlow.ListEvents<JetBrains.ReSharper.Features.SolBuilderDuo.Engine.Common.AssemblySurface.ProjectBuildSignature> ProjectBuildSignatures { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ReSharper.Features.SolBuilderDuo.Engine.Common.AssemblySurface.AssemblySurfaceHash GetAssemblySurfaceHash([JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.FileSystemPath path) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.Util.FileSystemPath GetCachePathForSolutionFile([JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.FileSystemPath pathSolutionFile) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.IDisposable Load([JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.FileSystemPath path, [JetBrains.Annotations.NotNullAttribute()] out JetBrains.ReSharper.Features.SolBuilderDuo.Engine.Common.AssemblySurface.AssemblySurfaceCache assemblysurfacecache) { }
        public void RemoveProjectSignature([JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.FileSystemPath pathProjectFile) { }
        public void ReplaceProjectSignature([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Features.SolBuilderDuo.Engine.Common.AssemblySurface.ProjectBuildSignature signatureNew) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Features.SolBuilderDuo.Engine.Common.AssemblySurface.ProjectBuildSignature TryGetProjectBuildSignature([JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.FileSystemPath path) { }
    }
    public class AssemblySurfaceHash : System.IEquatable<JetBrains.ReSharper.Features.SolBuilderDuo.Engine.Common.AssemblySurface.AssemblySurfaceHash>
    {
        public static readonly System.Collections.Generic.IEqualityComparer<JetBrains.ReSharper.Features.SolBuilderDuo.Engine.Common.AssemblySurface.AssemblySurfaceHash> StrictEqualityComparer;
        public AssemblySurfaceHash(JetBrains.Util.FileSystemPath path) { }
        public string AssemblyName { get; set; }
        public string FullPath { get; set; }
        public System.DateTime ModificationTime { get; set; }
        public string PublicApiHash { get; set; }
        public override bool Equals(object obj) { }
        public bool Equals(JetBrains.ReSharper.Features.SolBuilderDuo.Engine.Common.AssemblySurface.AssemblySurfaceHash obj) { }
        public override int GetHashCode() { }
        public bool IsUpToDate() { }
    }
    public class AssemblySurfaceSerializerOnTheFly : System.IDisposable
    {
        public void Dispose() { }
        public static void Run([JetBrains.Annotations.NotNullAttribute()] JetBrains.Metadata.Reader.API.IMetadataAssembly assembly, [JetBrains.Annotations.NotNullAttribute()] System.IO.Stream stream) { }
    }
    public class ProjectBuildSignature
    {
        public ProjectBuildSignature() { }
        public string ProjectFileFullPath { get; set; }
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)]
        public JetBrains.DataFlow.ListEvents<JetBrains.ReSharper.Features.SolBuilderDuo.Engine.Common.AssemblySurface.AssemblySurfaceHash> ProjectReferenceOutputs { get; }
        public bool HasBreakingChangesAgainst([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Features.SolBuilderDuo.Engine.Common.AssemblySurface.ProjectBuildSignature prev) { }
        public JetBrains.ReSharper.Features.SolBuilderDuo.Engine.Common.AssemblySurface.ProjectBuildSignature.ChangesKind HasChangesAgainst([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Features.SolBuilderDuo.Engine.Common.AssemblySurface.ProjectBuildSignature prev) { }
        public enum ChangesKind
        {
            None = 0,
            NonBreaking = 1,
            Breaking = 2,
        }
    }
}
namespace JetBrains.ReSharper.Features.SolBuilderDuo.Engine.Common.Filtering
{
    
    public class static MsbuildProjectTransformerXml
    {
        public static readonly string XmlnsMsbuild;
        public static readonly string XmlnsMsbuildUri;
        public static System.Xml.XmlElement CreateElement(System.Xml.XmlNode xmlAnyNodeFromDoc, JetBrains.ReSharper.Features.SolBuilderDuo.Engine.Common.Filtering.MsbuildProjectTransformerXml.Elements element) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Xml.XmlNamespaceManager CreateNamespaceManager([JetBrains.Annotations.NotNullAttribute()] System.Xml.XmlDocument xmlProject) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Xml.XmlElement CreateUsingTaskElement([JetBrains.Annotations.NotNullAttribute()] System.Xml.XmlDocument xmlDoc, [JetBrains.Annotations.NotNullAttribute()] System.Type typeTaskClass) { }
        public static System.Xml.XmlNode FindBeginLevelComment(int nLevel, System.Xml.XmlElement xmlMsbuildTask) { }
        public static System.Xml.XmlNode FindEndLevelComment(int nLevel, System.Xml.XmlElement xmlMsbuildTask) { }
        public static string GetBeginLevelCommentText(int nLevel) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static string GetBuildLevelItemGroupName(int nLevel, System.Nullable<JetBrains.ReSharper.Features.SolBuilderDuo.Engine.Common.AssemblySurface.ProjectBuildSignature.ChangesKind> changeskind) { }
        public static string GetEndLevelCommentText(int nLevel) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Collections.Generic.Dictionary<JetBrains.ReSharper.Features.SolBuilderDuo.Engine.Common.Filtering.MsbuildProjectTransformerXml.BuildConfiguration, System.Collections.Generic.List<System.Collections.Generic.List<string>>> GetSolutionBuildLevels([JetBrains.Annotations.NotNullAttribute()] System.Xml.XmlDocument xmlProject) { }
        public static void InsertUsingTaskElement(System.Xml.XmlDocument xmlDocument, System.Type typeTaskClass) { }
        public static void MakeBuildConditional([JetBrains.Annotations.NotNullAttribute()] System.Xml.XmlDocument xmlProject, [JetBrains.Annotations.NotNullAttribute()] System.Type typeConditionalFilterTaskClass, [JetBrains.Annotations.CanBeNullAttribute()] System.Action<int, System.Xml.XmlElement> FAddTasksAroundMsbuildCall) { }
        public enum Attributes
        {
            Condition = 0,
            Include = 1,
            Name = 2,
            Projects = 3,
            Input = 4,
            TaskName = 5,
            AssemblyFile = 6,
            Level = 7,
            TaskParameter = 8,
            ItemName = 9,
            Properties = 10,
            BreakingChanges = 11,
            NonBreakingChanges = 12,
            NoChanges = 13,
            Importance = 14,
            Text = 15,
            Targets = 16,
            InitialTargets = 17,
            UnloadProjectsOnCompletion = 18,
            BuildInParallel = 19,
            UseResultsCache = 20,
            Output = 21,
            TargetOutputs = 22,
        }
        public struct BuildConfiguration : System.IEquatable<JetBrains.ReSharper.Features.SolBuilderDuo.Engine.Common.Filtering.MsbuildProjectTransformerXml.BuildConfiguration>
        {
            [JetBrains.Annotations.NotNullAttribute()]
            public readonly string Configuration;
            [JetBrains.Annotations.NotNullAttribute()]
            public readonly string Platform;
            public BuildConfiguration([JetBrains.Annotations.NotNullAttribute()] string configuration, [JetBrains.Annotations.NotNullAttribute()] string platform) { }
            public override bool Equals(object obj) { }
            public bool Equals(JetBrains.ReSharper.Features.SolBuilderDuo.Engine.Common.Filtering.MsbuildProjectTransformerXml.BuildConfiguration obj) { }
            public override int GetHashCode() { }
            [JetBrains.Annotations.NotNullAttribute()]
            public override string ToString() { }
        }
        public enum Elements
        {
            Project = 0,
            ItemGroup = 1,
            BuildLevel = 2,
            MSBuild = 3,
            Target = 4,
            UsingTask = 5,
            Output = 6,
            Message = 7,
            Error = 8,
            Warning = 9,
            CreateItem = 10,
        }
        public enum Metadata
        {
            Identity = 0,
        }
        public enum Misc
        {
            Configuration = 0,
            Platform = 1,
            Value = 2,
            Build = 3,
            BuildLevel = 4,
            Clean = 5,
            Rebuild = 6,
            BuildLevelNonBreakingChanges = 7,
            BuildLevelNoChanges = 8,
            BuildLevelBreakingChanges = 9,
        }
        public enum Properties
        {
            MSBuildProjectFullPath = 0,
        }
    }
    public enum SolBuilderDuoHeuristics
    {
        ByDate = 0,
        ByApiSurface = 1,
    }
    public class static SolutionFileConverter
    {
        public static System.Xml.XmlDocument RunConverter([JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.FileSystemPath pathSolution, bool isUsingStaticEngine) { }
        public static System.Xml.XmlDocument RunConverter([JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.FileSystemPath pathSolution, Microsoft.Build.BuildEngine.Engine engine) { }
    }
}
namespace JetBrains.ReSharper.Features.SolBuilderDuo.Engine.Common.Logging
{
    
    public struct MsbuildProjectBuildId : System.IEquatable<JetBrains.ReSharper.Features.SolBuilderDuo.Engine.Common.Logging.MsbuildProjectBuildId>
    {
        public readonly int NodeId;
        public readonly int ProjectContextId;
        public MsbuildProjectBuildId([JetBrains.Annotations.NotNullAttribute()] Microsoft.Build.Framework.BuildEventContext ctx) { }
        public MsbuildProjectBuildId(int nodeid, int projectcontextid) { }
        public override bool Equals(object obj) { }
        public bool Equals(JetBrains.ReSharper.Features.SolBuilderDuo.Engine.Common.Logging.MsbuildProjectBuildId obj) { }
        public override int GetHashCode() { }
        public override string ToString() { }
    }
    public class static SolBuilderDuoMsbuildEventConverter
    {
        public static JetBrains.ReSharper.SolutionBuilder.SolBuilderDuo.SolBuildEvent ConvertFrom([JetBrains.Annotations.NotNullAttribute()] Microsoft.Build.Framework.BuildEventArgs args) { }
        public static JetBrains.ReSharper.SolutionBuilder.SolBuilderDuo.SolBuildEvent ConvertFromError([JetBrains.Annotations.NotNullAttribute()] Microsoft.Build.Framework.BuildErrorEventArgs args) { }
        public static JetBrains.ReSharper.SolutionBuilder.SolBuilderDuo.SolBuildEvent ConvertFromMessage([JetBrains.Annotations.CanBeNullAttribute()] Microsoft.Build.Framework.BuildMessageEventArgs args) { }
        public static JetBrains.ReSharper.SolutionBuilder.SolBuilderDuo.SolBuildEvent ConvertFromStatus([JetBrains.Annotations.CanBeNullAttribute()] Microsoft.Build.Framework.BuildStatusEventArgs args) { }
        public static JetBrains.ReSharper.SolutionBuilder.SolBuilderDuo.SolBuildEvent ConvertFromWarning([JetBrains.Annotations.NotNullAttribute()] Microsoft.Build.Framework.BuildWarningEventArgs args) { }
        public static JetBrains.ReSharper.SolutionBuilder.SolBuilderDuo.SolBuildEventImportance ConvertImportanceFromMsbuild(Microsoft.Build.Framework.MessageImportance importance) { }
    }
}
namespace JetBrains.ReSharper.Features.SolBuilderDuo.Engine.Legacy
{
    
    public class AssemblySurfaceSerializer
    {
        public AssemblySurfaceSerializer() { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Xml.XmlDocument Run([JetBrains.Annotations.NotNullAttribute()] JetBrains.Metadata.Reader.API.IMetadataAssembly assembly) { }
    }
    public class BuildLevelConditionalFilterSatellite : Microsoft.Build.Utilities.Task
    {
        [Microsoft.Build.Framework.OutputAttribute()]
        public Microsoft.Build.Framework.ITaskItem[] BreakingChanges { get; set; }
        [Microsoft.Build.Framework.RequiredAttribute()]
        public Microsoft.Build.Framework.ITaskItem[] Input { get; set; }
        [Microsoft.Build.Framework.RequiredAttribute()]
        public string Level { get; set; }
        public override bool Execute() { }
    }
    [System.ServiceModel.ServiceContractAttribute()]
    public interface IMainMsbuildNode
    {
        [System.ServiceModel.OperationContractAttribute()]
        string[] QueryBuildProjects([JetBrains.Annotations.NotNullAttribute()] string[] itemspecs);
    }
    public class static MsbuildNodeData
    {
        public static JetBrains.ReSharper.Features.SolBuilderDuo.Engine.Legacy.IMainMsbuildNode MainNode;
        public static string[] QueryBuildProjects([JetBrains.Annotations.NotNullAttribute()] string[] itemspecs) { }
    }
    public class static MsbuildProjectTransformerEngine
    {
        public static readonly string XmlnsMsbuild;
        public static readonly string XmlnsMsbuildUri;
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Xml.XmlNamespaceManager CreateNamespaceManager([JetBrains.Annotations.NotNullAttribute()] System.Xml.XmlDocument xmlProject) { }
        public static void MakeBuildConditional([JetBrains.Annotations.NotNullAttribute()] Microsoft.Build.BuildEngine.Project project) { }
        public enum Attributes
        {
            Condition = 0,
            Include = 1,
            Name = 2,
            Projects = 3,
            Input = 4,
            Output = 5,
            TaskName = 6,
            AssemblyFile = 7,
            Level = 8,
            TaskParameter = 9,
            ItemName = 10,
        }
        public struct BuildConfiguration : System.IEquatable<JetBrains.ReSharper.Features.SolBuilderDuo.Engine.Legacy.MsbuildProjectTransformerEngine.BuildConfiguration>
        {
            [JetBrains.Annotations.NotNullAttribute()]
            public readonly string Configuration;
            [JetBrains.Annotations.NotNullAttribute()]
            public readonly string Platform;
            public BuildConfiguration([JetBrains.Annotations.NotNullAttribute()] string configuration, [JetBrains.Annotations.NotNullAttribute()] string platform) { }
            public override bool Equals(object obj) { }
            public bool Equals(JetBrains.ReSharper.Features.SolBuilderDuo.Engine.Legacy.MsbuildProjectTransformerEngine.BuildConfiguration obj) { }
            public override int GetHashCode() { }
            [JetBrains.Annotations.NotNullAttribute()]
            public override string ToString() { }
        }
        public enum Elements
        {
            Project = 0,
            ItemGroup = 1,
            BuildLevel = 2,
            MSBuild = 3,
            Target = 4,
            UsingTask = 5,
            Output = 6,
        }
        public enum Misc
        {
            Configuration = 0,
            Platform = 1,
            Value = 2,
            Build = 3,
            BuildLevel = 4,
            BuildLevelConditional = 5,
        }
    }
    public class SolBuilderDuoMsbuildSecondaryNodeLogger
    {
        public Microsoft.Build.Framework.IEventRedirector BuildEventRedirector { get; set; }
        public int NodeId { get; set; }
        public string Parameters { get; set; }
        public Microsoft.Build.Framework.LoggerVerbosity Verbosity { get; set; }
        public void Initialize(Microsoft.Build.Framework.IEventSource eventSource) { }
        public void Initialize(Microsoft.Build.Framework.IEventSource eventSource, int nodeCount) { }
        public void Shutdown() { }
    }
}
namespace JetBrains.ReSharper.Features.SolBuilderDuo.Engine.MsbuildExe
{
    
    [JetBrains.ReSharper.Features.SolBuilderDuo.Engine.MsbuildExe.Components.MsbuildExeComponentAttribute()]
    public class BuildLevelProjectsLogic
    {
        public readonly JetBrains.DataFlow.IDictionaryEvents<JetBrains.Util.FileSystemPath, System.Nullable<JetBrains.ReSharper.Features.SolBuilderDuo.Engine.Common.AssemblySurface.ProjectBuildSignature.ChangesKind>> ProjectDecisions;
        public BuildLevelProjectsLogic(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ReSharper.Features.SolBuilderDuo.Engine.MsbuildExe.Components.IsBuildAbortedMonitor isBuildAbortedMonitor, JetBrains.ReSharper.Features.SolBuilderDuo.Engine.MsbuildExe.Components.TrackProjectsToBeBuilt trackProjectsToBeBuilt, JetBrains.ReSharper.Features.SolBuilderDuo.Engine.MsbuildExe.Filtering.IMsbuildExeHeuristicsHandler heuristicsHandler, JetBrains.ReSharper.Features.SolBuilderDuo.Engine.MsbuildExe.Logging.MsbuildExeBuildEventsUpload eventsUpload, JetBrains.ReSharper.Features.SolBuilderDuo.Engine.MsbuildExe.Components.ModifyIsBuildindStatesSafe modifyIsBuildindStatesSafe, JetBrains.ReSharper.Features.SolBuilderDuo.Engine.MsbuildExe.SolutionBuildDataProjectHashesCalculator projectHashesCalculator) { }
        public void FilterBuildLevelProjects(System.Collections.Generic.ICollection<JetBrains.Util.FileSystemPath> input, out System.Collections.Generic.ICollection<> prjBreakingChanges, out System.Collections.Generic.ICollection<> prjNonBreakingChanges, out System.Collections.Generic.ICollection<> prjNoChanges) { }
        public void OnBuildLevelBegin(int nLevel, System.Collections.Generic.List<JetBrains.Util.FileSystemPath> projects) { }
        public void OnBuildLevelEnd(int nLevel, System.Collections.Generic.List<JetBrains.Util.FileSystemPath> projectsAll, System.Collections.Generic.List<JetBrains.Util.FileSystemPath> projectsNoChanges, System.Collections.Generic.List<JetBrains.Util.FileSystemPath> projectsBreakingChanges, System.Collections.Generic.List<JetBrains.Util.FileSystemPath> projectsNonBreakingChanges) { }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    [System.Runtime.InteropServices.GuidAttribute("08B93B46-4D2E-4041-8DA2-580E5E5E67A8")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsDual)]
    public interface IRotReader
    {
        [JetBrains.Annotations.UsedImplicitlyAttribute()]
        void Data(string data);
    }
    public class MsbuildExeEngineStarter
    {
        public static readonly string BuildEventSenderName;
        public JetBrains.ReSharper.Features.SolBuilderDuo.Engine.Common.Filtering.SolBuilderDuoHeuristics Heuristics;
        public readonly JetBrains.DataFlow.ISimpleSignal IncomingAbort;
        public readonly string InstanceId;
        public bool IsConcurrent;
        public System.Version MsbuildVersion;
        public JetBrains.ReSharper.SolutionBuilder.SolBuilderDuo.SolBuildEventImportance RequiredBuildEventImportance;
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly JetBrains.ReSharper.SolutionBuilder.SolBuilderDuo.BuildSession Session;
        public readonly JetBrains.DataFlow.Property<JetBrains.ReSharper.Features.SolBuilderDuo.Engine.MsbuildExe.MsbuildExeEngineStarter.States> State;
        public MsbuildExeEngineStarter([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.SolutionBuilder.SolBuilderDuo.BuildSession session) { }
        protected void AssertState(JetBrains.ReSharper.Features.SolBuilderDuo.Engine.MsbuildExe.MsbuildExeEngineStarter.States stateExpected) { }
        public void BeginRun(JetBrains.DataFlow.Lifetime lifetimeParent) { }
        public static string GetBuildEventPipeName([JetBrains.Annotations.NotNullAttribute()] string sInstanceId) { }
        public static string GetIsAbortedEventName([JetBrains.Annotations.NotNullAttribute()] string sInstanceId) { }
        public static string MapBuildSeverityToMsbuildTargetName(JetBrains.ReSharper.SolutionBuilder.SolBuilderDuo.BuildSessionSeverity severity) { }
        public class static MsbuildProp
        {
            public static readonly string Heuristics;
            public static readonly string InstanceId;
            public static readonly string Prefix;
            public static readonly string RequiredBuildEventImportance;
            public static readonly string TargetName;
            public class static Standard
            {
                public static readonly string PropertyConfiguration;
                public static readonly string PropertyPlatform;
                public static readonly string SolutionDir;
                public static readonly string SolutionExt;
                public static readonly string SolutionFileName;
                public static readonly string SolutionName;
                public static readonly string SolutionPath;
            }
        }
        public enum States
        {
            Invalid = 0,
            Initialized = 1,
            Building = 2,
            UsedUp = 3,
        }
    }
    [JetBrains.ReSharper.Features.SolBuilderDuo.Engine.MsbuildExe.Components.MsbuildExeComponentAttribute()]
    public class MsbuildExeMainNode
    {
        public readonly JetBrains.ReSharper.Features.SolBuilderDuo.Engine.MsbuildExe.MsbuildExeMainNodeParameters Data;
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly JetBrains.ReSharper.Features.SolBuilderDuo.Engine.MsbuildExe.Logging.MsbuildExeBuildEventsUpload EventsUpload;
        public readonly JetBrains.ReSharper.Features.SolBuilderDuo.Engine.MsbuildExe.Components.SandboxMsbuildEngine SandboxMsbuildEngine;
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly JetBrains.ReSharper.Features.SolBuilderDuo.Engine.MsbuildExe.Filtering.SolutionBuildData SolutionBuildData;
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly JetBrains.Util.FileSystemPath SolutionDir;
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly JetBrains.Util.FileSystemPath SolutionFile;
        public MsbuildExeMainNode([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Features.SolBuilderDuo.Engine.MsbuildExe.MsbuildExeMainNodeParameters data, JetBrains.ReSharper.Features.SolBuilderDuo.Engine.MsbuildExe.Logging.MsbuildExeBuildEventsUpload eu, JetBrains.ReSharper.Features.SolBuilderDuo.Engine.MsbuildExe.Components.SolutionBuildDataLoader sbd, JetBrains.ReSharper.Features.SolBuilderDuo.Engine.MsbuildExe.Components.IsBuildAbortedMonitor isBuildAbortedMonitor, JetBrains.ReSharper.Features.SolBuilderDuo.Engine.MsbuildExe.Components.ModifyIsBuildindStatesSafe modifyIsBuildindStatesSafe, JetBrains.ReSharper.Features.SolBuilderDuo.Engine.MsbuildExe.BuildLevelProjectsLogic buildLevelProjectsLogic, JetBrains.ReSharper.Features.SolBuilderDuo.Engine.MsbuildExe.Components.SandboxMsbuildEngine sandboxMsbuildEngine, JetBrains.ReSharper.Features.SolBuilderDuo.Engine.MsbuildExe.Components.ProjectInfoCollector projectInfoCollector) { }
        public void CollectProjectInfoOnLevelBegin(JetBrains.Util.FileSystemPath pathProject, System.Collections.Generic.Dictionary<string, string> properties) { }
        public void FilterBuildLevelProjects(System.Collections.Generic.ICollection<JetBrains.Util.FileSystemPath> input, out System.Collections.Generic.ICollection<> prjBreakingChanges, out System.Collections.Generic.ICollection<> prjNonBreakingChanges, out System.Collections.Generic.ICollection<> prjNoChanges) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.ReSharper.Features.SolBuilderDuo.Engine.MsbuildExe.MsbuildExeMainNode GetInstance() { }
        public bool IsBuildAborted() { }
        public void OnBuildLevelBegin(int nLevel, System.Collections.Generic.List<JetBrains.Util.FileSystemPath> projects) { }
        public void OnBuildLevelEnd(int nLevel, System.Collections.Generic.List<JetBrains.Util.FileSystemPath> projectsAll, System.Collections.Generic.List<JetBrains.Util.FileSystemPath> projectsNoChanges, System.Collections.Generic.List<JetBrains.Util.FileSystemPath> projectsBreakingChanges, System.Collections.Generic.List<JetBrains.Util.FileSystemPath> projectsNonBreakingChanges) { }
        public void ReportGlobalBuildFinished() { }
        public void ReportGlobalBuildStarted() { }
        public bool ReportProjectBuildNotRunning(JetBrains.Util.FileSystemPath pathProject) { }
        public void ReportProjectBuildOperationsStarted([JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.FileSystemPath pathProject) { }
        public bool ReportProjectBuildRunning([JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.FileSystemPath pathProject) { }
        public void ReportProjectTargetFinished([JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.FileSystemPath pathProject, [JetBrains.Annotations.NotNullAttribute()] string sTargetName) { }
        public void ReportProjectTargetStarted([JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.FileSystemPath pathProject, [JetBrains.Annotations.NotNullAttribute()] string sTargetName) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.ReSharper.Features.SolBuilderDuo.Engine.MsbuildExe.MsbuildExeMainNode Start([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Features.SolBuilderDuo.Engine.MsbuildExe.MsbuildExeMainNodeParameters data) { }
        public class static EventSourceIds
        {
            public static readonly string BuildOperationsStarted;
            public static readonly string MsbuildIntegration;
            public static readonly string ProjectBuildSkipped;
            public static readonly string UpToDate_BreakingChanges;
            public static readonly string UpToDate_NoChanges;
            public static readonly string UpToDate_NonBreakingChanges;
        }
    }
    public class MsbuildExeMainNodeParameters
    {
        public MsbuildExeMainNodeParameters(JetBrains.ReSharper.Features.SolBuilderDuo.Engine.Common.Filtering.SolBuilderDuoHeuristics buildHeuristics, string engineInstanceId, bool isBuildingJustRequiredProjects, string[] projectsMustBeBuiltRelative, JetBrains.ReSharper.SolutionBuilder.SolBuilderDuo.SolBuildEventImportance requiredBuildEventImportance, JetBrains.Util.FileSystemPath solutionFile, JetBrains.ReSharper.SolutionBuilder.SolBuilderDuo.BuildSessionSeverity buildSeverity, bool isConcurrent) { }
        public JetBrains.ReSharper.Features.SolBuilderDuo.Engine.Common.Filtering.SolBuilderDuoHeuristics BuildHeuristics { get; set; }
        public JetBrains.ReSharper.SolutionBuilder.SolBuilderDuo.BuildSessionSeverity BuildSeverity { get; set; }
        public string EngineInstanceId { get; set; }
        public bool IsBuildingJustRequiredProjects { get; set; }
        public bool IsConcurrent { get; set; }
        public string[] ProjectsMustBeBuiltRelative { get; set; }
        public JetBrains.ReSharper.SolutionBuilder.SolBuilderDuo.SolBuildEventImportance RequiredBuildEventImportance { get; set; }
        public JetBrains.Util.FileSystemPath SolutionFile { get; set; }
        public void AssertValid() { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.ReSharper.Features.SolBuilderDuo.Engine.MsbuildExe.MsbuildExeMainNodeParameters Deserialize([JetBrains.Annotations.NotNullAttribute()] string content) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static string Serialize([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Features.SolBuilderDuo.Engine.MsbuildExe.MsbuildExeMainNodeParameters parameters) { }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    [System.Runtime.InteropServices.GuidAttribute("9C63092A-84B6-4735-B445-E51EEBE8E9CD")]
    public class RotReader : JetBrains.ReSharper.Features.SolBuilderDuo.Engine.MsbuildExe.IRotReader
    {
        public readonly JetBrains.DataFlow.ISignal<JetBrains.ReSharper.Features.SolBuilderDuo.Engine.MsbuildExe.Logging.MsbuildExeLoggerBaseEvent> ObjectReceived;
        public RotReader(JetBrains.DataFlow.Lifetime lifetime, string instanceId) { }
        [JetBrains.Annotations.UsedImplicitlyAttribute()]
        public void Data(string data) { }
    }
    [JetBrains.Application.Settings.SettingsKeyAttribute(typeof(JetBrains.ProjectModel.Settings.Schema.BuildSettings), "Build with SolBuilderDuo.")]
    public class SolBuilderDuoSettings
    {
        [JetBrains.Application.Settings.SettingsEntryAttribute(0, @"Version of MSBuild to use when building. 0 means “as the runtime version of the application initiating the build” (in case of Visual Studio, this is the same MSBuild VS itself uses for building). FFFFFFFF means use the highest version available on this machine. Any other number: HIWORD is the major version number, LOWORD is the minor version number.")]
        public uint MsbuildVersion;
        [JetBrains.Application.Settings.SettingsEntryAttribute(JetBrains.ReSharper.SolutionBuilder.SolBuilderDuo.SolBuildEventImportance.High, "The events allowed into the logger must be at least this important. Allowing thro" +
            "ugh lower-importance events slow down the build process.")]
        public JetBrains.ReSharper.SolutionBuilder.SolBuilderDuo.SolBuildEventImportance RequiredBuildEventImportance;
        [JetBrains.Application.Settings.SettingsEntryAttribute(true, "Whether to avoid rebuilding unchanged projects whose references have only had ins" +
            "ignificant changes since last build.")]
        public bool UseApiSurfaceHeuristics;
        [JetBrains.Application.Settings.SettingsEntryAttribute(null, "Whether to build on all of the CPUs available on the computer, in parallel.")]
        public bool UseConcurrentBuild;
        [JetBrains.Application.Settings.SettingsEntryAttribute(JetBrains.ReSharper.Features.SolBuilderDuo.Engine.MsbuildExe.SolBuilderDuoSettings.UseMsbuildSolutionBuilderFlag.Ask, "Whether this implementation should be promoted into the solution builder service." +
            " NULL means asking user for consent.")]
        public JetBrains.ReSharper.Features.SolBuilderDuo.Engine.MsbuildExe.SolBuilderDuoSettings.UseMsbuildSolutionBuilderFlag UseMsbuildSolutionBuilder;
        public enum UseMsbuildSolutionBuilderFlag
        {
            Ask = 0,
            No = 1,
            Yes = 2,
        }
    }
    [JetBrains.ReSharper.Features.SolBuilderDuo.Engine.MsbuildExe.Components.MsbuildExeComponentAttribute()]
    public class SolutionBuildDataProjectHashesCalculator
    {
        public SolutionBuildDataProjectHashesCalculator(JetBrains.ReSharper.Features.SolBuilderDuo.Engine.MsbuildExe.Components.SolutionBuildDataLoader dataLoader, JetBrains.ReSharper.Features.SolBuilderDuo.Engine.MsbuildExe.MsbuildExeMainNodeParameters parameters) { }
        public void ForceUpdateProjectHashes([JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.FileSystemPath pathProject) { }
    }
}
namespace JetBrains.ReSharper.Features.SolBuilderDuo.Engine.MsbuildExe.Components
{
    
    [JetBrains.ReSharper.Features.SolBuilderDuo.Engine.MsbuildExe.Components.MsbuildExeComponentAttribute()]
    public class AssertIsBuildingStatesConsistent
    {
        public AssertIsBuildingStatesConsistent(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ReSharper.Features.SolBuilderDuo.Engine.MsbuildExe.Components.IsBuildingStates isBuildingStates) { }
    }
    [JetBrains.ReSharper.Features.SolBuilderDuo.Engine.MsbuildExe.Components.MsbuildExeComponentAttribute()]
    public class DeleteWorkingFilesAfterCleanSeverityBuild
    {
        public DeleteWorkingFilesAfterCleanSeverityBuild(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ReSharper.Features.SolBuilderDuo.Engine.MsbuildExe.MsbuildExeMainNodeParameters parameters) { }
    }
    [JetBrains.ReSharper.Features.SolBuilderDuo.Engine.MsbuildExe.Components.MsbuildExeComponentAttribute()]
    public class IsBuildAbortedMonitor
    {
        public IsBuildAbortedMonitor([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Features.SolBuilderDuo.Engine.MsbuildExe.MsbuildExeMainNodeParameters data) { }
        public bool IsBuildAborted() { }
    }
    [JetBrains.ReSharper.Features.SolBuilderDuo.Engine.MsbuildExe.Components.MsbuildExeComponentAttribute()]
    public class IsBuildingStates
    {
        public readonly JetBrains.DataFlow.IProperty<bool> IsBuildRunning;
        public readonly JetBrains.DataFlow.DictionaryEvents<JetBrains.Util.FileSystemPath, JetBrains.ReSharper.Features.SolBuilderDuo.Engine.MsbuildExe.Components.IsBuildingStates.ProjectBeingBuilt> ProjectsBeingBuilt;
        public IsBuildingStates(JetBrains.DataFlow.Lifetime lifetime) { }
        public class ProjectBeingBuilt
        {
            public readonly JetBrains.DataFlow.IProperty<bool> IsAnyBuildOperationsReported;
            public readonly JetBrains.Util.FileSystemPath ProjectPath;
            public readonly JetBrains.DataFlow.IListEvents<string> RunningTargetNames;
            public ProjectBeingBuilt(JetBrains.Util.FileSystemPath projectPath) { }
            public override string ToString() { }
        }
    }
    [JetBrains.ReSharper.Features.SolBuilderDuo.Engine.MsbuildExe.Components.MsbuildExeComponentAttribute()]
    public class ModifyIsBuildindStatesSafe
    {
        public ModifyIsBuildindStatesSafe(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ReSharper.Features.SolBuilderDuo.Engine.MsbuildExe.Components.IsBuildingStates isBuildingStates) { }
        public void ReportGlobalBuildFinished() { }
        public void ReportGlobalBuildStarted() { }
        public bool ReportProjectBuildNotRunning([JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.FileSystemPath pathProject) { }
        public void ReportProjectBuildOperationsStarted([JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.FileSystemPath pathProject) { }
        public bool ReportProjectBuildRunning([JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.FileSystemPath pathProject) { }
        public void ReportProjectsBuildLevelEnded() { }
        public void ReportProjectTargetFinished([JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.FileSystemPath pathProject, [JetBrains.Annotations.NotNullAttribute()] string sTargetName) { }
        public void ReportProjectTargetStarted([JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.FileSystemPath pathProject, [JetBrains.Annotations.NotNullAttribute()] string sTargetName) { }
    }
    [JetBrains.ReSharper.Features.SolBuilderDuo.Engine.MsbuildExe.Components.MsbuildExeComponentAttribute()]
    public class Msbuild4ReflectionAccess
    {
        public Msbuild4ReflectionAccess() { }
        [JetBrains.Annotations.NotNullAttribute()]
        public object BuildManager { get; }
        public int GetMaxNodeCount() { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ReSharper.Features.SolBuilderDuo.Engine.MsbuildExe.Components.Msbuild4ReflectionAccess.ProjectInstance GetProjectInstance([JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.FileSystemPath pathProject) { }
        public bool IsAvailable() { }
        public class ProjectInstance
        {
            [JetBrains.Annotations.NotNullAttribute()]
            public readonly JetBrains.ReSharper.Features.SolBuilderDuo.Engine.MsbuildExe.Components.Msbuild4ReflectionAccess Owner;
            [JetBrains.Annotations.NotNullAttribute()]
            public readonly JetBrains.Util.FileSystemPath ProjectPath;
            [JetBrains.Annotations.NotNullAttribute()]
            public readonly object Raw;
            public ProjectInstance([JetBrains.Annotations.NotNullAttribute()] object raw, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.FileSystemPath pathProject, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Features.SolBuilderDuo.Engine.MsbuildExe.Components.Msbuild4ReflectionAccess owner) { }
            public void AddTaskItem([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Features.SolBuilderDuo.Engine.MsbuildExe.Filtering.TaskItemCollectedInfo item, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.OnError onerror) { }
            [JetBrains.Annotations.NotNullAttribute()]
            public System.Collections.Generic.IList<JetBrains.ReSharper.Features.SolBuilderDuo.Engine.MsbuildExe.Filtering.TaskItemCollectedInfo> GetAllTaskItems([JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.OnError onerror) { }
            [JetBrains.Annotations.NotNullAttribute()]
            public System.Collections.Generic.IDictionary<string, string> GetGlobalProperties([JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.OnError onerror) { }
            public string GetProperty([JetBrains.Annotations.NotNullAttribute()] string sPropertyName, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.OnError onerror) { }
            [JetBrains.Annotations.NotNullAttribute()]
            public System.Collections.Generic.IList<JetBrains.ReSharper.Features.SolBuilderDuo.Engine.MsbuildExe.Filtering.TaskItemCollectedInfo> GetTaskItems([JetBrains.Annotations.NotNullAttribute()] string itemname, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.OnError onerror) { }
            public System.Collections.Generic.IList<string> GetTaskOutputItemGroupNames([JetBrains.Annotations.NotNullAttribute()] string sTargetName, [JetBrains.Annotations.NotNullAttribute()] string sTaskName, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.OnError onerror) { }
            public bool RestoreConditionsOnTasksInTarget([JetBrains.Annotations.NotNullAttribute()] string sTargetName, System.Collections.Generic.IDictionary<object, string> oldconditions, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.OnError onerror) { }
            public bool SetFalseConditionOnAllTasksInTarget([JetBrains.Annotations.NotNullAttribute()] string sTargetName, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.OnError onerror, System.Collections.Generic.IDictionary<object, string> oldconditions = null) { }
            public void SetProperty([JetBrains.Annotations.NotNullAttribute()] string sPropertyName, [JetBrains.Annotations.NotNullAttribute()] string sEvaluatedValue, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.OnError onerror) { }
            public bool SetTaskCondition([JetBrains.Annotations.NotNullAttribute()] string sTargetName, [JetBrains.Annotations.NotNullAttribute()] string sTaskName, [JetBrains.Annotations.NotNullAttribute()] string sConditionText, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.OnError onerror) { }
        }
        public class static Strings
        {
            public static readonly string BuildManager_ConfigCache;
            public static readonly string BuildManager_DefaultBuildManager;
            public static readonly string BuildRequestConfiguration_ProjectFullPath;
            public static readonly string BuildRequestConfiguration_ToolsVersion;
            public static readonly string ElementLocation_EmptyLocation;
            public static readonly string MicrosoftBuild;
            public static readonly string MicrosoftBuildConstructionElementlocation;
            public static readonly string MicrosoftBuildExecutionBuildmanager;
            public static readonly string ProjectInstance_AddItem;
            public static readonly string ProjectInstance_GetItems;
            public static readonly string ProjectInstance_GetProperty;
            public static readonly string ProjectInstance_GetPropertyValue;
            public static readonly string ProjectInstance_GlobalProperties;
            public static readonly string ProjectInstance_Items;
            public static readonly string ProjectInstance_SetProperty;
            public static readonly string ProjectItemInstance_EvaluatedInclude;
            public static readonly string ProjectItemInstance_ItemType;
            public static readonly string ProjectItemInstance_Metadata;
            public static readonly string ProjectMetadataInstance_EvaluatedValue;
            public static readonly string ProjectMetadataInstance_Name;
            public static readonly string ProjectPropertyInstance_EvaluatedValue;
            public static readonly string ProjectTargetInstance_Children;
            public static readonly string ProjectTargetInstance_Tasks;
            public static readonly string ProjectTaskInstance_condition;
            public static readonly string ProjectTaskInstance_Condition;
            public static readonly string ProjectTaskInstance_conditionLocation;
            public static readonly string ProjectTaskInstance_Name;
            public static readonly string ProjectTaskInstance_Outputs;
            public static readonly string ProjectTaskOutputItemInstance;
            public static readonly string ProjectTaskOutputItemInstance_ItemType;
        }
    }
    [JetBrains.ReSharper.Features.SolBuilderDuo.Engine.MsbuildExe.Components.MsbuildExeComponentAttribute()]
    public class ProjectInfoCollector
    {
        public readonly JetBrains.ReSharper.Features.SolBuilderDuo.Engine.MsbuildExe.Components.ProjectInfoCollector.ProjectInfoCollectionModes ProjectInfoCollectionMode;
        public ProjectInfoCollector(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ReSharper.Features.SolBuilderDuo.Engine.MsbuildExe.Components.SolutionBuildDataLoader dataLoader, JetBrains.ReSharper.Features.SolBuilderDuo.Engine.MsbuildExe.Components.SandboxMsbuildEngine sandboxMsbuildEngine, JetBrains.ReSharper.Features.SolBuilderDuo.Engine.MsbuildExe.MsbuildExeMainNodeParameters data, JetBrains.ReSharper.Features.SolBuilderDuo.Engine.MsbuildExe.Components.Msbuild4ReflectionAccess msbuild4ReflectionAccess, JetBrains.ReSharper.Features.SolBuilderDuo.Engine.MsbuildExe.Components.IsBuildingStates isBuildingStates, JetBrains.ReSharper.Features.SolBuilderDuo.Engine.MsbuildExe.SolutionBuildDataProjectHashesCalculator hashesCalculator, JetBrains.ReSharper.Features.SolBuilderDuo.Engine.MsbuildExe.Logging.MsbuildExeBuildEventsUpload eventsUpload, JetBrains.ReSharper.Features.SolBuilderDuo.Engine.MsbuildExe.BuildLevelProjectsLogic buildlevellogic) { }
        public void CollectProjectInfoOnLevelBegin(JetBrains.Util.FileSystemPath pathProject, System.Collections.Generic.Dictionary<string, string> properties) { }
        public enum ProjectInfoCollectionModes
        {
            None = 0,
            SandboxMsbuildEngine = 1,
            TamperingWithProjectInstance = 2,
        }
    }
    [JetBrains.ReSharper.Features.SolBuilderDuo.Engine.MsbuildExe.Components.MsbuildExeComponentAttribute()]
    public class SandboxMsbuildEngine
    {
        public SandboxMsbuildEngine(JetBrains.DataFlow.Lifetime disposables) { }
        public void WithMsbuildProject([JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.FileSystemPath pathProject, [JetBrains.Annotations.CanBeNullAttribute()] System.Collections.Generic.IDictionary<string, string> mapGlobalProps, [JetBrains.Annotations.NotNullAttribute()] System.Action<Microsoft.Build.BuildEngine.Project> F) { }
    }
    [JetBrains.ReSharper.Features.SolBuilderDuo.Engine.MsbuildExe.Components.MsbuildExeComponentAttribute()]
    public class SolutionBuildDataLoader
    {
        public readonly JetBrains.ReSharper.Features.SolBuilderDuo.Engine.MsbuildExe.Filtering.SolutionBuildData SolutionBuildData;
        public SolutionBuildDataLoader(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ReSharper.Features.SolBuilderDuo.Engine.MsbuildExe.MsbuildExeMainNodeParameters data) { }
    }
    [JetBrains.ReSharper.Features.SolBuilderDuo.Engine.MsbuildExe.Components.MsbuildExeComponentAttribute()]
    public class SwitchingMsbuildExeHeuristicsHandler : JetBrains.ReSharper.Features.SolBuilderDuo.Engine.MsbuildExe.Filtering.IMsbuildExeHeuristicsHandler
    {
        public SwitchingMsbuildExeHeuristicsHandler(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ReSharper.Features.SolBuilderDuo.Engine.MsbuildExe.MsbuildExeMainNodeParameters parameters, JetBrains.Application.Components.IComponentContainer parent) { }
    }
    [JetBrains.ReSharper.Features.SolBuilderDuo.Engine.MsbuildExe.Components.MsbuildExeComponentAttribute()]
    public class TrackProjectsToBeBuilt
    {
        public TrackProjectsToBeBuilt([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Features.SolBuilderDuo.Engine.MsbuildExe.MsbuildExeMainNodeParameters data, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Features.SolBuilderDuo.Engine.MsbuildExe.Components.IsBuildingStates isBuildingStates) { }
        public bool IsAllRequiredProjectsDone() { }
    }
    [JetBrains.ReSharper.Features.SolBuilderDuo.Engine.MsbuildExe.Components.MsbuildExeComponentAttribute()]
    public class UploadEventsOnIsBuildingStates
    {
        public UploadEventsOnIsBuildingStates(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ReSharper.Features.SolBuilderDuo.Engine.MsbuildExe.Components.IsBuildingStates isBuildingStates, JetBrains.ReSharper.Features.SolBuilderDuo.Engine.MsbuildExe.Logging.MsbuildExeBuildEventsUpload eventsUpload) { }
    }
}
namespace JetBrains.ReSharper.Features.SolBuilderDuo.Engine.MsbuildExe.Filtering
{
    
    [JetBrains.Annotations.UsedImplicitlyAttribute()]
    public class CollectProjectInfoTask : JetBrains.ReSharper.Features.SolBuilderDuo.Engine.MsbuildExe.Filtering.TaskBase
    {
        public static readonly string ProjectPropertyName;
        public static readonly string PropertiesPropertyName;
        [JetBrains.Annotations.UsedImplicitlyAttribute()]
        [Microsoft.Build.Framework.RequiredAttribute()]
        public Microsoft.Build.Framework.ITaskItem Project { get; set; }
        [JetBrains.Annotations.UsedImplicitlyAttribute()]
        public string[] Properties { get; set; }
        protected override void ExecuteCore() { }
    }
    public interface IMsbuildExeHeuristicsHandler
    {
        JetBrains.ReSharper.Features.SolBuilderDuo.Engine.Common.AssemblySurface.ProjectBuildSignature.ChangesKind QueryBuildProject([JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.FileSystemPath pathProject);
    }
    [JetBrains.Annotations.UsedImplicitlyAttribute()]
    public class LevelBeginTask : JetBrains.ReSharper.Features.SolBuilderDuo.Engine.MsbuildExe.Filtering.TaskBase
    {
        public static readonly string LevelPropertyName;
        public static readonly string ProjectsPropertyName;
        [JetBrains.Annotations.UsedImplicitlyAttribute()]
        [Microsoft.Build.Framework.RequiredAttribute()]
        public int Level { get; set; }
        [JetBrains.Annotations.UsedImplicitlyAttribute()]
        [Microsoft.Build.Framework.RequiredAttribute()]
        public Microsoft.Build.Framework.ITaskItem[] Projects { get; set; }
        protected override void ExecuteCore() { }
    }
    [JetBrains.Annotations.UsedImplicitlyAttribute()]
    public class LevelEndTask : JetBrains.ReSharper.Features.SolBuilderDuo.Engine.MsbuildExe.Filtering.TaskBase
    {
        public static readonly string BreakingChangesPropertyName;
        public static readonly string LevelPropertyName;
        public static readonly string NoChangesPropertyName;
        public static readonly string NonBreakingChangesPropertyName;
        public static readonly string ProjectsPropertyName;
        [JetBrains.Annotations.UsedImplicitlyAttribute()]
        [Microsoft.Build.Framework.OutputAttribute()]
        public Microsoft.Build.Framework.ITaskItem[] BreakingChanges { get; set; }
        [JetBrains.Annotations.UsedImplicitlyAttribute()]
        [Microsoft.Build.Framework.RequiredAttribute()]
        public int Level { get; set; }
        [JetBrains.Annotations.UsedImplicitlyAttribute()]
        [Microsoft.Build.Framework.OutputAttribute()]
        public Microsoft.Build.Framework.ITaskItem[] NoChanges { get; set; }
        [JetBrains.Annotations.UsedImplicitlyAttribute()]
        [Microsoft.Build.Framework.OutputAttribute()]
        public Microsoft.Build.Framework.ITaskItem[] NonBreakingChanges { get; set; }
        [JetBrains.Annotations.UsedImplicitlyAttribute()]
        [Microsoft.Build.Framework.RequiredAttribute()]
        public Microsoft.Build.Framework.ITaskItem[] Projects { get; set; }
        protected override void ExecuteCore() { }
    }
    public class static MsbuildEngineProjectOperations
    {
        [System.ObsoleteAttribute("Now inputs-outputs live in the project description.")]
        public static bool MsbuildAreInputsNewerThanOutputsNoReferencedProjects([JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.FileSystemPath pathProject, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Features.SolBuilderDuo.Engine.MsbuildExe.Components.SandboxMsbuildEngine engine) { }
        public static JetBrains.ReSharper.Features.SolBuilderDuo.Engine.MsbuildExe.Filtering.ProjectDescriptionCollectedInfo MsbuildCollectProjectInfo([JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.FileSystemPath pathProject, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Features.SolBuilderDuo.Engine.MsbuildExe.Components.SandboxMsbuildEngine engine, [JetBrains.Annotations.CanBeNullAttribute()] System.Collections.Generic.IDictionary<string, string> properties) { }
        [System.ObsoleteAttribute("Now injected right into the solution.")]
        public static void MsbuildCopyReferencesToOutputFolder([JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.FileSystemPath pathProject, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Features.SolBuilderDuo.Engine.MsbuildExe.Components.SandboxMsbuildEngine engine) { }
        [System.ObsoleteAttribute("Now collection of this info is injected right into the solution.")]
        public static JetBrains.ReSharper.Features.SolBuilderDuo.Engine.Common.AssemblySurface.ProjectBuildSignature MsbuildCreateProjectBuildSignature([JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.FileSystemPath pathProject, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Features.SolBuilderDuo.Engine.MsbuildExe.Components.SandboxMsbuildEngine engine, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Features.SolBuilderDuo.Engine.Common.AssemblySurface.AssemblySurfaceCache cache) { }
        [JetBrains.Annotations.NotNullAttribute()]
        [System.ObsoleteAttribute("We now know input/output files.")]
        public static JetBrains.Util.FileSystemPath MsbuildGetProjectTargetDir([JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.FileSystemPath pathProject, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Features.SolBuilderDuo.Engine.MsbuildExe.Components.SandboxMsbuildEngine engine) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Collections.Generic.IEnumerable<JetBrains.Util.FileSystemPath> MsbuildGetReferencedAssemblies([JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.FileSystemPath pathProject, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Features.SolBuilderDuo.Engine.MsbuildExe.Components.SandboxMsbuildEngine engine) { }
    }
    [JetBrains.Annotations.UsedImplicitlyAttribute()]
    public class MsbuildExeBootstrapTask : JetBrains.ReSharper.Features.SolBuilderDuo.Engine.MsbuildExe.Filtering.TaskBase
    {
        protected override void ExecuteCore() { }
    }
    [JetBrains.Annotations.UsedImplicitlyAttribute()]
    public class MsbuildExeBuildLevelConditionalFilterTask : JetBrains.ReSharper.Features.SolBuilderDuo.Engine.MsbuildExe.Filtering.TaskBase
    {
        [JetBrains.Annotations.UsedImplicitlyAttribute()]
        [Microsoft.Build.Framework.OutputAttribute()]
        public Microsoft.Build.Framework.ITaskItem[] BreakingChanges { get; set; }
        [JetBrains.Annotations.UsedImplicitlyAttribute()]
        [Microsoft.Build.Framework.RequiredAttribute()]
        public Microsoft.Build.Framework.ITaskItem[] Input { get; set; }
        [JetBrains.Annotations.UsedImplicitlyAttribute()]
        [Microsoft.Build.Framework.RequiredAttribute()]
        public string Level { get; set; }
        [JetBrains.Annotations.UsedImplicitlyAttribute()]
        [Microsoft.Build.Framework.OutputAttribute()]
        public Microsoft.Build.Framework.ITaskItem[] NoChanges { get; set; }
        [JetBrains.Annotations.UsedImplicitlyAttribute()]
        [Microsoft.Build.Framework.OutputAttribute()]
        public Microsoft.Build.Framework.ITaskItem[] NonBreakingChanges { get; set; }
        protected override void ExecuteCore() { }
    }
    public class MsbuildExeByDateHeuristicsHandler : JetBrains.ReSharper.Features.SolBuilderDuo.Engine.MsbuildExe.Filtering.IMsbuildExeHeuristicsHandler { }
    public class static MsbuildExeSolutionFileTransformer
    {
        public static readonly string ItemGroupName_ReferencedAssemblies;
        public static readonly string ItemGroupName_ReferencedAssembliesWithMetadata;
        public static readonly string MetadataName_OriginatingProject;
        public static readonly string PropertyName_ProjectPath;
        public static readonly string TargetName_CollectProjectInfo;
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.Util.FileSystemPath GetProjectFullPathByTaskItem([JetBrains.Annotations.NotNullAttribute()] Microsoft.Build.Framework.ITaskItem item, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.FileSystemPath dirSolution) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Collections.Generic.IEnumerable<JetBrains.Util.FileSystemPath> GetProjectItemsByFullSpec([JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.FileSystemPath pathProject, [JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IEnumerable<Microsoft.Build.Framework.ITaskItem> items) { }
        public class static TasksImplementation
        {
            public static void CollectProjectInfo(Microsoft.Build.Framework.ITaskItem itemProject, string[] properties) { }
            public static void EmitSolutionMsbuildProjFile(JetBrains.ReSharper.Features.SolBuilderDuo.Engine.MsbuildExe.MsbuildExeMainNodeParameters parameters, JetBrains.ReSharper.Features.SolBuilderDuo.Engine.MsbuildExe.Components.SandboxMsbuildEngine sandboxMsbuildEngine, JetBrains.ReSharper.Features.SolBuilderDuo.Engine.MsbuildExe.Filtering.SolutionBuildData solutionBuildData) { }
            public static void FilterBuildLevelProjects(Microsoft.Build.Framework.ITaskItem[] input, out Microsoft.Build.Framework.ITaskItem prjBreakingChanges, out Microsoft.Build.Framework.ITaskItem prjNonBreakingChanges, out Microsoft.Build.Framework.ITaskItem prjNoChanges) { }
            public static void OnLevelBegin(int nLevel, Microsoft.Build.Framework.ITaskItem[] projects) { }
            public static void OnLevelEnd(int nLevel, Microsoft.Build.Framework.ITaskItem[] projectsAll, Microsoft.Build.Framework.ITaskItem[] projectsNoChanges, Microsoft.Build.Framework.ITaskItem[] projectsBreakingChanges, Microsoft.Build.Framework.ITaskItem[] projectsNonBreakingChanges) { }
        }
    }
    public class static MsbuildFile
    {
        public class static Attributes
        {
            public static readonly string AdditionalMetadata;
            public static readonly string AssemblyFile;
            public static readonly string BreakingChanges;
            public static readonly string BuildInParallel;
            public static readonly string Condition;
            public static readonly string Importance;
            public static readonly string Include;
            public static readonly string InitialTargets;
            public static readonly string Input;
            public static readonly string ItemName;
            public static readonly string Level;
            public static readonly string Name;
            public static readonly string NoChanges;
            public static readonly string NonBreakingChanges;
            public static readonly string Output;
            public static readonly string Outputs;
            public static readonly string PreserveExistingMetadata;
            public static readonly string Projects;
            public static readonly string Properties;
            public static readonly string Returns;
            public static readonly string TargetOutputs;
            public static readonly string Targets;
            public static readonly string TaskName;
            public static readonly string TaskParameter;
            public static readonly string Text;
            public static readonly string UnloadProjectsOnCompletion;
            public static readonly string UseResultsCache;
        }
        public class static ItemGroups
        {
            public static readonly string AvailableItemName;
            public static readonly string ReferencePath;
        }
        public class static Metadatas
        {
            public static readonly string Identity;
        }
        public class static Misc
        {
            public static readonly string[] WellKnownAvailableItemNames;
        }
        public class static Properties
        {
            public static readonly string BuildProjectReferences;
            public static readonly string Configuration;
            public static readonly string OutDir;
            public static readonly string OutputPath;
            public static readonly string Platform;
            public static readonly string TargetDir;
            public static readonly string TargetPath;
        }
        public class static Targets
        {
            public static readonly string CopyFilesMarkedCopyLocal;
            public static readonly string GetCopyToOutputDirectoryItems;
            public static readonly string GetTargetPath;
            public static readonly string ResolveAssemblyReferences;
            public static readonly string ResolveProjectReferences;
            public static readonly string SplitProjectReferencesByType;
        }
        public class static Tasks
        {
            public static readonly string ResolveAssemblyReference;
        }
    }
    public class ProjectDescription
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Features.SolBuilderDuo.Engine.MsbuildExe.Filtering.ProjectDescriptionCollectedInfo CollectedInfo { get; set; }
        public bool IsValid { get; }
        public JetBrains.Util.FileSystemPath ProjectFilePath { get; set; }
        public System.DateTime ProjectFileTimeStamp { get; set; }
        public bool AreInputFilesNewerThanOutputFiles() { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ReSharper.Features.SolBuilderDuo.Engine.MsbuildExe.Filtering.ProjectDescriptionCollectedInfo GetCollectedInfo() { }
        public bool IsOutdatedRecursive() { }
    }
    public class ProjectDescriptionCollectedInfo
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly System.Collections.Generic.Dictionary<string, JetBrains.ReSharper.Features.SolBuilderDuo.Engine.MsbuildExe.Filtering.TaskItemCollectedInfoBlob> CachedTargetOutputItems;
        [JetBrains.Annotations.CanBeNullAttribute()]
        public System.Collections.Generic.List<JetBrains.Util.FileSystemPath> InputFiles;
        [JetBrains.Annotations.CanBeNullAttribute()]
        public System.Collections.Generic.List<JetBrains.Util.FileSystemPath> OutputFiles;
        [JetBrains.Annotations.CanBeNullAttribute()]
        public System.Collections.Generic.List<JetBrains.Util.FileSystemPath> ReferencedAssemblies;
        [JetBrains.Annotations.CanBeNullAttribute()]
        public System.Collections.Generic.List<JetBrains.ReSharper.Features.SolBuilderDuo.Engine.Common.AssemblySurface.AssemblySurfaceHash> ReferencedAssemblyHashes;
        public ProjectDescriptionCollectedInfo() { }
        public JetBrains.ReSharper.Features.SolBuilderDuo.Engine.Common.AssemblySurface.ProjectBuildSignature.ChangesKind DetectChangesAgainstCurrentAssemblies(JetBrains.ReSharper.Features.SolBuilderDuo.Engine.Common.AssemblySurface.AssemblySurfaceCache cache) { }
    }
    public class SolutionBuildData
    {
        public SolutionBuildData() { }
        public string Algorithm { get; set; }
        public JetBrains.ReSharper.Features.SolBuilderDuo.Engine.Common.AssemblySurface.AssemblySurfaceCache AssemblySurfaceCache { get; set; }
        public static string CurrentAlgorithm { get; }
        public JetBrains.ReSharper.Features.SolBuilderDuo.Engine.MsbuildExe.Filtering.SolutionDescription SolutionDescription { get; set; }
        public void Clear() { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.Util.FileSystemPath[] GetAllSolutionSatelliteFiles([JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.FileSystemPath pathSolutionFile) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.Util.FileSystemPath GetBootstrapProjFilePath([JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.FileSystemPath pathSolutionFile) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.Util.FileSystemPath GetSolutionBuildDataFilePath([JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.FileSystemPath pathSolutionFile) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.Util.FileSystemPath GetSolutionMsbuildProjFilePath([JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.FileSystemPath pathSolutionFile) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.ReSharper.Features.SolBuilderDuo.Engine.MsbuildExe.Filtering.SolutionBuildData Load_BinaryFormatter([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.FileSystemPath path) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.ReSharper.Features.SolBuilderDuo.Engine.MsbuildExe.Filtering.SolutionBuildData Load_XamlSerializer([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.FileSystemPath path) { }
    }
    public class SolutionDescription
    {
        public SolutionDescription() { }
        public bool IsValid { get; }
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)]
        public JetBrains.DataFlow.ListEvents<JetBrains.ReSharper.Features.SolBuilderDuo.Engine.MsbuildExe.Filtering.ProjectDescription> Projects { get; }
        public System.DateTime SoltionFileTimeStamp { get; set; }
        public JetBrains.Util.FileSystemPath SolutionFilePath { get; set; }
        public System.DateTime SolutionMsbuildProjTimeStamp { get; set; }
        public void Clear() { }
        public void ClearIfOutdated() { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ReSharper.Features.SolBuilderDuo.Engine.MsbuildExe.Filtering.ProjectDescription GetProject([JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.FileSystemPath pathProject) { }
        public bool IsProjectDescriptionValid([JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.FileSystemPath pathProject) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Features.SolBuilderDuo.Engine.MsbuildExe.Filtering.ProjectDescription TryGetProject([JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.FileSystemPath pathProject) { }
    }
    public abstract class TaskBase : Microsoft.Build.Utilities.Task
    {
        public virtual bool Execute() { }
        protected abstract void ExecuteCore();
    }
    public class TaskItemCollectedInfo : System.IEquatable<JetBrains.ReSharper.Features.SolBuilderDuo.Engine.MsbuildExe.Filtering.TaskItemCollectedInfo>
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly string ItemSpec;
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly string ItemType;
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<string, string>> Metadata;
        public TaskItemCollectedInfo([JetBrains.Annotations.NotNullAttribute()] string itemType, [JetBrains.Annotations.NotNullAttribute()] string itemSpec) { }
        public bool Equals(JetBrains.ReSharper.Features.SolBuilderDuo.Engine.MsbuildExe.Filtering.TaskItemCollectedInfo other) { }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
        public override string ToString() { }
    }
    public class TaskItemCollectedInfoBlob
    {
        public byte[] Data;
        public System.Collections.Generic.IList<JetBrains.ReSharper.Features.SolBuilderDuo.Engine.MsbuildExe.Filtering.TaskItemCollectedInfo> Deserialize() { }
        public void Serialize(System.Collections.Generic.IList<JetBrains.ReSharper.Features.SolBuilderDuo.Engine.MsbuildExe.Filtering.TaskItemCollectedInfo> items) { }
    }
}
namespace JetBrains.ReSharper.Features.SolBuilderDuo.Engine.MsbuildExe.Logging
{
    
    [JetBrains.ReSharper.Features.SolBuilderDuo.Engine.MsbuildExe.Components.MsbuildExeComponentAttribute()]
    public class MsbuildExeBuildEventsUpload
    {
        public MsbuildExeBuildEventsUpload([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Features.SolBuilderDuo.Engine.MsbuildExe.MsbuildExeMainNodeParameters parameters) { }
        public MsbuildExeBuildEventsUpload([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] string engineInstanceId) { }
        public void UploadEvent([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Features.SolBuilderDuo.Engine.MsbuildExe.Logging.MsbuildExeLoggerBaseEvent evt) { }
    }
    public abstract class MsbuildExeLoggerBaseEvent { }
    public class MsbuildExeLoggerLogEvent : JetBrains.ReSharper.Features.SolBuilderDuo.Engine.MsbuildExe.Logging.MsbuildExeLoggerBaseEvent
    {
        public JetBrains.ReSharper.SolutionBuilder.SolBuilderDuo.SolBuildEvent BuildEvent;
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.Util.FileSystemPath ProjectPath;
    }
    public class MsbuildExeLoggerProjectBuildStateEvent : JetBrains.ReSharper.Features.SolBuilderDuo.Engine.MsbuildExe.Logging.MsbuildExeLoggerBaseEvent
    {
        public JetBrains.ReSharper.SolutionBuilder.SolBuilderDuo.BuildSessionProjectBuildState BuildState;
        public JetBrains.Util.FileSystemPath ProjectPath;
    }
    public class MsbuildExeMainNodeLogger : Microsoft.Build.Framework.ILogger
    {
        public MsbuildExeMainNodeLogger() { }
        public string Parameters { get; set; }
        public Microsoft.Build.Framework.LoggerVerbosity Verbosity { get; set; }
        [JetBrains.Annotations.NotNullAttribute()]
        public static string GetMsbuildCommandLineString([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Features.SolBuilderDuo.Engine.MsbuildExe.MsbuildExeMainNodeParameters parameters) { }
        public void RegisterOwnerOfProject(JetBrains.ReSharper.Features.SolBuilderDuo.Engine.Common.Logging.MsbuildProjectBuildId id, JetBrains.ReSharper.Features.SolBuilderDuo.Engine.Common.Logging.MsbuildProjectBuildId idOwner) { }
        public void ReportBuildLogEvent([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Features.SolBuilderDuo.Engine.MsbuildExe.Logging.MsbuildExeLoggerLogEvent logevt) { }
        public System.Nullable<JetBrains.ReSharper.Features.SolBuilderDuo.Engine.Common.Logging.MsbuildProjectBuildId> TryGetOwner(JetBrains.ReSharper.Features.SolBuilderDuo.Engine.Common.Logging.MsbuildProjectBuildId id) { }
    }
}
namespace JetBrains.ReSharper.Features.SolBuilderDuo.Engine.Satellite
{
    
    [System.ServiceModel.ServiceContractAttribute()]
    public interface ISolBuilderDuoClient
    {
        [JetBrains.Annotations.NotNullAttribute()]
        [System.ServiceModel.OperationContractAttribute()]
        JetBrains.Util.FileSystemPath[] QueryBuildProjects([JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.FileSystemPath[] pathProjects);
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true)]
        void ReportBuildCompleted();
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true)]
        void ReportBuildSessionBuildEvent([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.Util.FileSystemPath pathProject, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.SolutionBuilder.SolBuilderDuo.SolBuildEvent evtn, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.SolutionBuilder.SolBuilderDuo.SolBuildEventWithLocation evtl);
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true)]
        void ReportBuildSessionProjectBuildState([JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.FileSystemPath pathProject, JetBrains.ReSharper.SolutionBuilder.SolBuilderDuo.BuildSessionProjectBuildState state);
        [System.ServiceModel.OperationContractAttribute()]
        bool ReportServerAddress(int nProcessId, [JetBrains.Annotations.NotNullAttribute()] System.Uri uriAddress);
        [System.ServiceModel.OperationContractAttribute()]
        void Test();
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true)]
        void UpdateBuildSignatures([JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.FileSystemPath[] pathProjects);
    }
    [System.ServiceModel.ServiceContractAttribute()]
    public interface ISolBuilderDuoServer
    {
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true)]
        void AbortBuild();
        [JetBrains.Annotations.NotNullAttribute()]
        [System.ServiceModel.OperationContractAttribute()]
        JetBrains.ReSharper.Features.SolBuilderDuo.Engine.Satellite.RemoteResult BeginBuild();
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true)]
        void Shutdown();
        [System.ServiceModel.OperationContractAttribute()]
        void Test();
        [JetBrains.Annotations.NotNullAttribute()]
        [System.ServiceModel.OperationContractAttribute()]
        JetBrains.ReSharper.Features.SolBuilderDuo.Engine.Satellite.RemoteResult UploadBuildSession([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Features.SolBuilderDuo.Engine.Satellite.MsbuildInSatelliteSessionInitialDataSerialized sessionSerialized);
    }
    public class MsbuildInSatelliteSessionInitialDataSerialized
    {
        public string ConfigurationName { get; set; }
        public JetBrains.ReSharper.Features.SolBuilderDuo.Engine.Common.Filtering.SolBuilderDuoHeuristics Heuristics { get; set; }
        public bool IsConcurrent { get; set; }
        public string PlatformName { get; set; }
        public JetBrains.Util.FileSystemPath[] Projects { get; set; }
        public JetBrains.Util.FileSystemPath[] ProjectsMustBeBuilt { get; set; }
        public JetBrains.ReSharper.SolutionBuilder.SolBuilderDuo.SolBuildEventImportance RequiredBuildEventImportance { get; set; }
        public JetBrains.ReSharper.SolutionBuilder.SolBuilderDuo.BuildSessionSeverity Severity { get; set; }
        public JetBrains.Util.FileSystemPath SolutionFile { get; set; }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.ReSharper.Features.SolBuilderDuo.Engine.Satellite.MsbuildInSatelliteSessionInitialDataSerialized Create([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.SolutionBuilder.SolBuilderDuo.BuildSession session, JetBrains.ReSharper.Features.SolBuilderDuo.Engine.Common.Filtering.SolBuilderDuoHeuristics heuristics, bool isConcurrent, JetBrains.ReSharper.SolutionBuilder.SolBuilderDuo.SolBuildEventImportance requiredbuildeventimpoerance) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ReSharper.SolutionBuilder.SolBuilderDuo.BuildSession ToBuildSession() { }
    }
    public class MsbuildInSatelliteSessionRun : JetBrains.ReSharper.Features.SolBuilderDuo.Engine.Legacy.IMainMsbuildNode, Microsoft.Build.Framework.ILogger, System.IDisposable
    {
        public static readonly string EnginePropertyConfiguration;
        public static readonly string EnginePropertyPlatform;
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly JetBrains.Threading.JetDispatcher MainThread;
        public readonly JetBrains.DataFlow.ISignal<JetBrains.DataFlow.InOutEventArgs<JetBrains.Util.FileSystemPath[], JetBrains.Util.FileSystemPath[]>> QueryBuildProjects;
        public JetBrains.ReSharper.SolutionBuilder.SolBuilderDuo.SolBuildEventImportance RequiredBuildEventImportance;
        public readonly JetBrains.ReSharper.SolutionBuilder.SolBuilderDuo.BuildSession Session;
        public readonly JetBrains.DataFlow.Property<JetBrains.ReSharper.Features.SolBuilderDuo.Engine.Satellite.MsbuildInSatelliteSessionRun.States> State;
        public readonly JetBrains.DataFlow.ISignal<JetBrains.DataFlow.EventArgs<JetBrains.Util.FileSystemPath[]>> UpdateBuildSignatures;
        public MsbuildInSatelliteSessionRun([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.SolutionBuilder.SolBuilderDuo.BuildSession session, JetBrains.ReSharper.Features.SolBuilderDuo.Engine.Common.Filtering.SolBuilderDuoHeuristics heuristics, bool isConcurrent) { }
        public void Abort() { }
        public void AssertMainThread() { }
        protected void AssertState(JetBrains.ReSharper.Features.SolBuilderDuo.Engine.Satellite.MsbuildInSatelliteSessionRun.States stateExpected) { }
        public void BeginRun() { }
        public void Dispose() { }
        public enum States
        {
            Error = 0,
            Initialized = 1,
            Building = 2,
            UsedUp = 3,
        }
    }
    public class RemoteResult
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public string Description { get; }
        public bool IsSuccessful { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public string Title { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.ReSharper.Features.SolBuilderDuo.Engine.Satellite.RemoteResult CreateFailure([JetBrains.Annotations.NotNullAttribute()] System.Exception ex) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.ReSharper.Features.SolBuilderDuo.Engine.Satellite.RemoteResult CreateSuccess() { }
        public void ThrowIfFailed() { }
    }
    public class SatelliteEngineStarter : JetBrains.ReSharper.Features.SolBuilderDuo.Engine.Satellite.ISolBuilderDuoClient
    {
        public readonly System.Uri Address;
        public readonly JetBrains.DataFlow.ObsoleteLifetimeAndDefinitionAtTheSameTime DisposablesRunMain;
        public readonly JetBrains.DataFlow.ObsoleteLifetimeAndDefinitionAtTheSameTime DisposablesRunWorker;
        public readonly JetBrains.ReSharper.Features.SolBuilderDuo.Engine.Common.Filtering.SolBuilderDuoHeuristics Heuristics;
        public readonly bool IsConcurrent;
        public JetBrains.ReSharper.SolutionBuilder.SolBuilderDuo.SolBuildEventImportance RequiredBuildEventImportance;
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly JetBrains.ReSharper.SolutionBuilder.SolBuilderDuo.BuildSession Session;
        public readonly JetBrains.DataFlow.Property<JetBrains.ReSharper.Features.SolBuilderDuo.Engine.Satellite.SatelliteEngineStarter.States> State;
        public SatelliteEngineStarter([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.SolutionBuilder.SolBuilderDuo.BuildSession session, JetBrains.ReSharper.Features.SolBuilderDuo.Engine.Common.Filtering.SolBuilderDuoHeuristics heuristics, bool isConcurrent) { }
        public void Abort() { }
        protected void AssertState(JetBrains.ReSharper.Features.SolBuilderDuo.Engine.Satellite.SatelliteEngineStarter.States stateExpected) { }
        public void BeginRun() { }
        public enum States
        {
            Invalid = 0,
            Initialized = 1,
            Building = 2,
            UsedUp = 3,
        }
    }
    public class SolBuilderDuoClientProxy : JetBrains.ReSharper.Features.SolBuilderDuo.Engine.Satellite.ISolBuilderDuoClient, System.IDisposable
    {
        public SolBuilderDuoClientProxy([JetBrains.Annotations.NotNullAttribute()] System.Uri uriClientAddress) { }
        public void Dispose() { }
    }
    public class static SolBuilderDuoCommunication
    {
        public static System.ServiceModel.NetNamedPipeBinding CreateServiceBinding() { }
    }
    public class SolBuilderDuoSatellite : JetBrains.ReSharper.Features.SolBuilderDuo.Engine.Satellite.ISolBuilderDuoServer, System.IDisposable
    {
        public readonly System.Uri Address;
        public SolBuilderDuoSatellite([JetBrains.Annotations.NotNullAttribute()] System.Uri clientaddress, bool bIsInInternalMode) { }
        public void Dispose() { }
        public void Run() { }
        public class InterprocessPropertySetter<TValue> : System.MarshalByRefObject { }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public class SolBuilderDuoSatelliteArgument : JetBrains.Util.Satellite.ISatelliteProcessArgument
    {
        public const string ConfigFileName = "MSBuild.Exe.Config";
        public System.Uri ClientAddress { get; set; }
        public bool IsInInternalMode { get; set; }
        public void Run() { }
    }
}
namespace JetBrains.ReSharper.Features.SolBuilderDuo.Provider
{
    
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class MsbuildSolutionBuilder : JetBrains.ReSharper.SolutionBuilder.ISolutionBuilder
    {
        public readonly JetBrains.Threading.JetDispatcher Dispatcher;
        public readonly JetBrains.DataFlow.ISimpleSignal IncomingAbort;
        public static readonly bool IsUsingMsbuildExeEngineStarter;
        public static readonly bool OptionTrace;
        public static readonly double SolutionBuilderImplementationPriority;
        public MsbuildSolutionBuilder(JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.ISolution solution, JetBrains.DocumentManagers.impl.DocumentManagerOperations documentOperations, JetBrains.VsIntegration.ActionManagement.VsActionManager vsActionManager, JetBrains.ReSharper.SolutionBuilder.SolutionBuilder solutionBuilder, JetBrains.ProjectModel.PlatformManager platformManager, JetBrains.Application.Settings.ISettingsStore settings) { }
        public JetBrains.DataFlow.IProperty<JetBrains.ReSharper.SolutionBuilder.SolBuilderDuo.BuildSession> RunningSession { get; }
        public void Abort() { }
        public void BeginRun(JetBrains.ReSharper.SolutionBuilder.SolBuilderDuo.BuildSession session) { }
        public JetBrains.ReSharper.SolutionBuilder.SolBuilderDuo.BuildSession CreateSession(JetBrains.ReSharper.SolutionBuilder.SolBuilderDuo.BuildSessionSeverity severity, params JetBrains.ProjectModel.IProject[] projectsToBuild) { }
        public bool IsOverridingDevenvActionsNow() { }
    }
}