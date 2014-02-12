[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]

namespace JetBrains.dotTrace.Api
{
    
    public class BaseProfilingConfig
    {
        public JetBrains.dotTrace.Api.ProfilingControl ProfilingControl;
        public string RedistPath;
        public string TempPath;
        public BaseProfilingConfig() { }
    }
    public class static Control
    {
        public static bool CanDetach { get; }
        public static bool IsActive { get; }
        public static void Cancel() { }
        public static void Detach() { }
        public static void Pause() { }
        public static void Resume() { }
        public static void Start() { }
        public static void StartPaused() { }
        public static void Stop() { }
    }
    public class InvalidConfigurationException : System.Exception
    {
        public InvalidConfigurationException(string message) { }
        public InvalidConfigurationException(string message, System.Exception innerException) { }
    }
    public class OpenProfilingConfig : JetBrains.dotTrace.Api.BaseProfilingConfig { }
    public class ProcessSnapshotProfilingConfig : JetBrains.dotTrace.Api.BaseProfilingConfig
    {
        public string ExecutablePath;
        public JetBrains.dotTrace.Api.SnapshotFormat SnapshotFormat;
        public ProcessSnapshotProfilingConfig(string executablePath) { }
    }
    public class static ProfilerState
    {
        public static bool IsDotTraceInstalled { get; }
        public static bool IsProfilerActive { get; }
    }
    public enum ProfilingControl
    {
        None = 0,
        ControllerWindow = 1,
        API = 2,
    }
    public class SaveSnapshotProfilingConfig : JetBrains.dotTrace.Api.BaseProfilingConfig
    {
        public string SavePath;
        public JetBrains.dotTrace.Api.SnapshotFormat SnapshotFormat;
        public SaveSnapshotProfilingConfig(string savePath) { }
    }
    public class static SelfAttach
    {
        public static void Attach() { }
        public static void Attach(JetBrains.dotTrace.Api.BaseProfilingConfig config) { }
    }
    public enum SnapshotFormat
    {
        Compressed = 0,
        Uncompressed = 1,
    }
}