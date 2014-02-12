[assembly: System.Reflection.AssemblyKeyFileAttribute("../../../Platform/lib/Key.snk")]

namespace JetBrains.Profiler.Core.Api
{
    
    public sealed class CoverageProfiler
    {
        public static bool CanDetach { get; }
        public static bool IsActive { get; }
        public static void Begin() { }
        public static void BeginGroup(string name) { }
        public static void Detach() { }
        public static void EndDrop() { }
        public static void EndGroup() { }
        public static void EndSave() { }
        public static void Start() { }
        public static void Stop() { }
    }
    public sealed class MemoryProfiler
    {
        public static bool CanDetach { get; }
        public static bool IsActive { get; }
        public static void Detach() { }
        public static void Dump() { }
    }
    public sealed class PerformanceProfiler
    {
        public static bool CanDetach { get; }
        public static bool IsActive { get; }
        public static void Begin() { }
        public static void BeginGroup(string name) { }
        public static void Detach() { }
        public static void EndDrop() { }
        public static void EndGroup() { }
        public static void EndSave() { }
        public static void Start() { }
        public static void Stop() { }
    }
    public class ProfilingApiException : System.ApplicationException
    {
        public ProfilingApiException(string message) { }
    }
}