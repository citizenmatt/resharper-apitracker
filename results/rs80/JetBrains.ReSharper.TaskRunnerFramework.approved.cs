[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]

namespace JetBrains.ReSharper.TaskRunnerFramework
{
    
    public class AppDomainExceptionTask : JetBrains.ReSharper.TaskRunnerFramework.RemoteTask
    {
        public AppDomainExceptionTask(string runnerID) { }
        public AppDomainExceptionTask(System.Xml.XmlElement element) { }
        public override bool IsMeaningfulTask { get; }
        public override bool Equals(JetBrains.ReSharper.TaskRunnerFramework.RemoteTask other) { }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
    }
    public class AssemblyLoader : System.MarshalByRefObject, System.IDisposable
    {
        public AssemblyLoader() { }
        public void Dispose() { }
        public void RegisterAssembly(string displayName, string codeBase) { }
        public void RegisterAssembly(System.Reflection.Assembly assembly) { }
        public void RegisterPath(string path) { }
    }
    public interface IRemoteChannel
    {
        void SendPacket(string xml);
        void SendPacket(System.Xml.XmlElement element);
    }
    public interface IRemoteChannelMessageListener
    {
        void OnError(string message);
        void OnError(System.Exception exception);
        void OnPacket(System.Xml.XmlElement message, JetBrains.ReSharper.TaskRunnerFramework.RemoteChannel remoteChannel);
    }
    public interface IRemoteTaskServer
    {
        void CreateDynamicElement(JetBrains.ReSharper.TaskRunnerFramework.RemoteTask remoteTask);
        void SetTempFolderPath(string path);
        void TaskDiscovered(JetBrains.ReSharper.TaskRunnerFramework.RemoteTask remoteTask);
        void TaskDuration(JetBrains.ReSharper.TaskRunnerFramework.RemoteTask remoteTask, System.TimeSpan duration);
        void TaskException(JetBrains.ReSharper.TaskRunnerFramework.RemoteTask remoteTask, JetBrains.ReSharper.TaskRunnerFramework.TaskException[] exceptions);
        void TaskFinished(JetBrains.ReSharper.TaskRunnerFramework.RemoteTask remoteTask, string message, JetBrains.ReSharper.TaskRunnerFramework.TaskResult result);
        void TaskOutput(JetBrains.ReSharper.TaskRunnerFramework.RemoteTask remoteTask, string text, JetBrains.ReSharper.TaskRunnerFramework.TaskOutputType outputType);
        void TaskStarting(JetBrains.ReSharper.TaskRunnerFramework.RemoteTask remoteTask);
    }
    public interface ITaskRunnerClientController
    {
        void AfterRunFinished();
        void AfterTaskFinished(JetBrains.ReSharper.TaskRunnerFramework.RemoteTask task);
        void BeforeRunStarted();
        void BeforeTaskStarted(JetBrains.ReSharper.TaskRunnerFramework.RemoteTask task);
    }
    public class static PlatformExtensions
    {
        public static string ToShortString(this JetBrains.ReSharper.TaskRunnerFramework.PlatformType platformType) { }
        public static string ToShortString(this JetBrains.ReSharper.TaskRunnerFramework.PlatformVersion platformVersion) { }
    }
    public enum PlatformType
    {
        [System.ComponentModel.DescriptionAttribute("Automatic based on test project\'s target platform")]
        Automatic = 0,
        [System.ComponentModel.DescriptionAttribute("Use platform-independent (AnyCPU) runner")]
        MSIL = 1,
        [System.ComponentModel.DescriptionAttribute("Force tests to run in 32-bit process")]
        x86 = 2,
        [System.ComponentModel.DescriptionAttribute("Force tests to run in 64-bit process")]
        x64 = 3,
    }
    public enum PlatformVersion
    {
        [System.ComponentModel.DescriptionAttribute("Automatic based on test project\'s target framework")]
        Automatic = 0,
        [System.ComponentModel.DescriptionAttribute("Force tests to use CLR 2.0")]
        v2_0 = 1,
        [System.ComponentModel.DescriptionAttribute("Force tests to use CLR 4.0")]
        v4_0 = 2,
    }
    public abstract class RecursiveRemoteTaskRunner
    {
        protected RecursiveRemoteTaskRunner(JetBrains.ReSharper.TaskRunnerFramework.IRemoteTaskServer server) { }
        public JetBrains.ReSharper.TaskRunnerFramework.IRemoteTaskServer Server { get; }
        public virtual void Abort() { }
        public abstract void ExecuteRecursive(JetBrains.ReSharper.TaskRunnerFramework.TaskExecutionNode node);
    }
    public class RemoteChannel : JetBrains.ReSharper.TaskRunnerFramework.IRemoteChannel, System.IDisposable
    {
        public RemoteChannel(System.Net.Sockets.TcpClient client, JetBrains.ReSharper.TaskRunnerFramework.IRemoteChannelMessageListener listener = null) { }
        public JetBrains.ReSharper.TaskRunnerFramework.IRemoteChannelMessageListener Listener { get; set; }
        public void Dispose() { }
        public void SendPacket(string xml) { }
        public void SendPacket(System.Xml.XmlElement element) { }
        public void Start() { }
        public void Stop() { }
        public void WaitForFinish() { }
    }
    public abstract class RemoteTask : System.IEquatable<JetBrains.ReSharper.TaskRunnerFramework.RemoteTask>
    {
        protected RemoteTask(System.Xml.XmlElement element) { }
        protected RemoteTask(string runnerID) { }
        public string Id { get; }
        public abstract bool IsMeaningfulTask { get; }
        public string RunnerID { get; }
        public virtual JetBrains.ReSharper.TaskRunnerFramework.RuntimeEnvironment EnsureRuntimeEnvironment(JetBrains.ReSharper.TaskRunnerFramework.RuntimeEnvironment runtimeEnvironment) { }
        public abstract bool Equals(JetBrains.ReSharper.TaskRunnerFramework.RemoteTask other);
        public virtual bool Equals(object obj) { }
        public virtual int GetHashCode() { }
        protected static string GetXmlAttribute(System.Xml.XmlElement element, string name) { }
        public virtual void SaveXml(System.Xml.XmlElement element) { }
        protected static void SetXmlAttribute(System.Xml.XmlElement element, string name, string value) { }
    }
    public class static RemoteTaskEx
    {
        public static JetBrains.ReSharper.TaskRunnerFramework.RemoteTask FromXml(System.Xml.XmlElement taskNode) { }
        public static void ToXml(this JetBrains.ReSharper.TaskRunnerFramework.RemoteTask remoteTask, System.Xml.XmlElement parent, string runId) { }
    }
    public class RemoteTaskPacket
    {
        public RemoteTaskPacket() { }
        public RemoteTaskPacket(string runId, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.TaskRunnerFramework.RemoteTask> taskInfo) { }
        public string RunId { get; set; }
        public System.Collections.Generic.IList<JetBrains.ReSharper.TaskRunnerFramework.RemoteTask> Tasks { get; }
        public static JetBrains.ReSharper.TaskRunnerFramework.RemoteTaskPacket FromXml(System.Xml.XmlElement element) { }
        public void ToXml(System.Xml.XmlElement node) { }
    }
    public struct RemoteTaskRunnerInfo
    {
        public RemoteTaskRunnerInfo(string id, System.Type runnerType) { }
        public RemoteTaskRunnerInfo(string id, System.Type runnerType, string[] additionalPaths) { }
        public string[] AdditionalPaths { get; }
        public string Id { get; }
        public string RunnerCodeBase { get; }
        public string RunnerTypeName { get; }
        public bool Equals(JetBrains.ReSharper.TaskRunnerFramework.RemoteTaskRunnerInfo other) { }
        public override bool Equals(object obj) { }
        public static JetBrains.ReSharper.TaskRunnerFramework.RemoteTaskRunnerInfo FromXml(System.Xml.XmlElement element) { }
        public override int GetHashCode() { }
        public void ToXml(System.Xml.XmlElement element) { }
    }
    public struct RuntimeEnvironment
    {
        public static readonly JetBrains.ReSharper.TaskRunnerFramework.RuntimeEnvironment Automatic;
        public static readonly JetBrains.ReSharper.TaskRunnerFramework.RuntimeEnvironment Default;
        public JetBrains.ReSharper.TaskRunnerFramework.PlatformType PlatformType;
        public JetBrains.ReSharper.TaskRunnerFramework.PlatformVersion PlatformVersion;
        public bool Unmanaged;
        public static bool IsAutomatic(JetBrains.ReSharper.TaskRunnerFramework.RuntimeEnvironment env) { }
        public override string ToString() { }
    }
    public class ServerChannel : JetBrains.ReSharper.TaskRunnerFramework.IRemoteChannelMessageListener
    {
        public ServerChannel(JetBrains.ReSharper.TaskRunnerFramework.RemoteChannel remoteChannel, System.Action<System.Collections.Generic.IEnumerable<JetBrains.ReSharper.TaskRunnerFramework.RemoteTaskPacket>> doWork, System.Action<System.Xml.XmlElement> configure, System.Action abort) { }
        public void OnError(string message) { }
        public void OnError(System.Exception exception) { }
        public void OnPacket(System.Xml.XmlElement message, JetBrains.ReSharper.TaskRunnerFramework.RemoteChannel remoteChannel) { }
    }
    public class StartupTaskRunnerHost : System.MarshalByRefObject
    {
        public StartupTaskRunnerHost(JetBrains.ReSharper.TaskRunnerFramework.IRemoteTaskServer server) { }
        public void Abort() { }
        public void ExecuteNodes(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.TaskRunnerFramework.TaskExecutionNode> nodes) { }
    }
    public struct TaskException
    {
        public TaskException(string type, string message, string stackTrace) { }
        public TaskException(System.Exception exception) { }
        public string Message { get; }
        public string StackTrace { get; }
        public string Type { get; }
        public static JetBrains.ReSharper.TaskRunnerFramework.TaskException FromXml(System.Xml.XmlElement element) { }
        public void ToXml(System.Xml.XmlElement element) { }
    }
    public class TaskExecutionNode
    {
        public TaskExecutionNode(JetBrains.ReSharper.TaskRunnerFramework.TaskExecutionNode parent, JetBrains.ReSharper.TaskRunnerFramework.RemoteTask task) { }
        public System.Collections.Generic.List<JetBrains.ReSharper.TaskRunnerFramework.TaskExecutionNode> Children { get; }
        public JetBrains.ReSharper.TaskRunnerFramework.TaskExecutionNode Parent { get; }
        public JetBrains.ReSharper.TaskRunnerFramework.RemoteTask RemoteTask { get; }
    }
    public class static TaskExecutor
    {
        public static JetBrains.ReSharper.TaskRunnerFramework.TaskExecutorConfiguration Configuration { get; }
        public static System.Collections.Generic.IDictionary<string, JetBrains.ReSharper.TaskRunnerFramework.RemoteTaskRunnerInfo> RunnerInfos { get; }
        public static JetBrains.ReSharper.TaskRunnerFramework.TaskException[] ConvertExceptions(System.Exception ex, out string message) { }
        public static void Run(System.Net.IPAddress address, int port, string sessionId) { }
    }
    public class TaskExecutorConfiguration
    {
        public string AssemblyFolder { get; set; }
        public bool IsInInternalDebug { get; set; }
        public System.Collections.Generic.List<string> RunnerPaths { get; set; }
        public bool ShadowCopy { get; set; }
        public static JetBrains.ReSharper.TaskRunnerFramework.TaskExecutorConfiguration FromXml(System.Xml.XmlElement element) { }
        public void ToXml(System.Xml.XmlElement parent) { }
    }
    public class TaskOutputInterceptor : System.IDisposable
    {
        public TaskOutputInterceptor(JetBrains.ReSharper.TaskRunnerFramework.RemoteTask task, JetBrains.ReSharper.TaskRunnerFramework.IRemoteTaskServer server) { }
        public void Dispose() { }
    }
    public enum TaskOutputType
    {
        STDOUT = 0,
        STDERR = 1,
        DEBUGTRACE = 2,
    }
    public enum TaskResult
    {
        Success = 0,
        Skipped = 1,
        Error = 2,
        Exception = 3,
        Inconclusive = 4,
    }
    public class TaskRunnerClientControllerInfo
    {
        public TaskRunnerClientControllerInfo(string clientControllerCodeBase, string clientControllerTypeName) { }
        public TaskRunnerClientControllerInfo(System.Type controllerType) { }
        public string CodeBase { get; }
        public string[] DependentLibrariesPaths { get; set; }
        public string TypeName { get; }
        public static JetBrains.ReSharper.TaskRunnerFramework.TaskRunnerClientControllerInfo FromXml(System.Xml.XmlElement element) { }
        public void ToXml(System.Xml.XmlElement element) { }
    }
    public class TaskRunnerProxy : System.MarshalByRefObject, JetBrains.ReSharper.TaskRunnerFramework.IRemoteTaskServer
    {
        public TaskRunnerProxy(string runId, JetBrains.ReSharper.TaskRunnerFramework.IRemoteChannel remoteChannel) { }
        public JetBrains.ReSharper.TaskRunnerFramework.ITaskRunnerClientController ClientController { get; set; }
        public void CreateDynamicElement(JetBrains.ReSharper.TaskRunnerFramework.RemoteTask remoteTask) { }
        public virtual object InitializeLifetimeService() { }
        public void RunFinished() { }
        public void RunStarted() { }
        public void SetTempFolderPath(string path) { }
        public void TaskDiscovered(JetBrains.ReSharper.TaskRunnerFramework.RemoteTask remoteTask) { }
        public void TaskDuration(JetBrains.ReSharper.TaskRunnerFramework.RemoteTask remoteTask, System.TimeSpan duration) { }
        public void TaskException(JetBrains.ReSharper.TaskRunnerFramework.RemoteTask remoteTask, JetBrains.ReSharper.TaskRunnerFramework.TaskException[] exceptions) { }
        public void TaskFinished(JetBrains.ReSharper.TaskRunnerFramework.RemoteTask remoteTask, string message, JetBrains.ReSharper.TaskRunnerFramework.TaskResult result) { }
        public void TaskOutput(JetBrains.ReSharper.TaskRunnerFramework.RemoteTask remoteTask, string text, JetBrains.ReSharper.TaskRunnerFramework.TaskOutputType outputType) { }
        public void TaskStarting(JetBrains.ReSharper.TaskRunnerFramework.RemoteTask remoteTask) { }
    }
}