[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]

namespace JetBrains.ReSharper.ExternalProcessStorage.Impl
{
    
    public class SafeDependencyToFileIdsMap : JetBrains.ReSharper.ExternalProcessStorage.SolutionAnalysis.IDependencyToFileIdsMap, System.IDisposable
    {
        public SafeDependencyToFileIdsMap([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.ExternalProcessStorage.SolutionAnalysis.IDependencyToFileIdsMap map) { }
        public void AddDependencies(uint[] dependencies, uint fileId) { }
        public void Compact(bool full) { }
        public void Dispose() { }
        public void FileIdBitsIncreased(int oldBitsCount, int newBitsCount) { }
        public System.Collections.Generic.Dictionary<uint, uint> GetFilesToRehighlight(uint[] changes) { }
        public string GetStatistics() { }
        public void RemoveDependencies(uint[] dependencies, uint fileId) { }
    }
    public class SafeDependencyToHashMap : JetBrains.ReSharper.ExternalProcessStorage.SolutionAnalysis.IDependencyToHashMap, System.IDisposable
    {
        public SafeDependencyToHashMap([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.ExternalProcessStorage.SolutionAnalysis.IDependencyToHashMap map) { }
        public int Count { get; }
        public JetBrains.ReSharper.ExternalProcessStorage.SolutionAnalysis.SerializableHashes this[JetBrains.ReSharper.ExternalProcessStorage.SolutionAnalysis.SerializableDependencies dependencies] { get; }
        public JetBrains.ReSharper.ExternalProcessStorage.SolutionAnalysis.IDependencyToHashMap Map { get; }
        public void Clear() { }
        public void Compact() { }
        public void Dispose() { }
    }
    public class SafeSolutionAnalysisStorage : JetBrains.ReSharper.ExternalProcessStorage.SolutionAnalysis.ISolutionAnalysisStorage
    {
        public SafeSolutionAnalysisStorage(JetBrains.ReSharper.ExternalProcessStorage.SolutionAnalysis.ISolutionAnalysisStorage storage) { }
        public bool InterruptFlag { set; }
        public void AddDependencies(JetBrains.ReSharper.ExternalProcessStorage.SolutionAnalysis.IDependencyToHashMap map, JetBrains.ReSharper.ExternalProcessStorage.SolutionAnalysis.IDependencyToHashMap touchedDependencies, JetBrains.ReSharper.ExternalProcessStorage.SolutionAnalysis.SerializableDependenciesAndHashes dependencies) { }
        public void AddDependencies(JetBrains.ReSharper.ExternalProcessStorage.SolutionAnalysis.IDependencyToHashMap map, JetBrains.ReSharper.ExternalProcessStorage.SolutionAnalysis.IDependencyToHashMap touchedDependencies, int dependenciesAndHashesId) { }
        public JetBrains.ReSharper.ExternalProcessStorage.SolutionAnalysis.IDependencyToFileIdsMap CreateDependencyToFileIdsMap(int fileIdBitsCount) { }
        public JetBrains.ReSharper.ExternalProcessStorage.SolutionAnalysis.IDependencyToHashMap CreateDependencyToHashMap() { }
        public JetBrains.ReSharper.ExternalProcessStorage.SolutionAnalysis.SerializableDependenciesAndHashes DependenciesAndHashesById(int id) { }
        public int DependenciesAndHashesCountById(int id) { }
        public void DisposeDependenciesAndHashes(int id) { }
        public int StoreDependenciesAndHashes(JetBrains.ReSharper.ExternalProcessStorage.SolutionAnalysis.SerializableDependenciesAndHashes data) { }
        public void SubtractDependencies(JetBrains.ReSharper.ExternalProcessStorage.SolutionAnalysis.IDependencyToHashMap map, JetBrains.ReSharper.ExternalProcessStorage.SolutionAnalysis.IDependencyToHashMap touchedDependencies, JetBrains.ReSharper.ExternalProcessStorage.SolutionAnalysis.SerializableDependenciesAndHashes dependencies) { }
        public void SubtractDependencies(JetBrains.ReSharper.ExternalProcessStorage.SolutionAnalysis.IDependencyToHashMap map, JetBrains.ReSharper.ExternalProcessStorage.SolutionAnalysis.IDependencyToHashMap touchedDependencies, int dependenciesAndHashesId) { }
        public JetBrains.ReSharper.ExternalProcessStorage.SolutionAnalysis.SerializableDependencies TouchedDependenciesToChanges(JetBrains.ReSharper.ExternalProcessStorage.SolutionAnalysis.IDependencyToHashMap dependencyToHash, JetBrains.ReSharper.ExternalProcessStorage.SolutionAnalysis.IDependencyToHashMap touchedDependencyToInitialValue) { }
    }
}
namespace JetBrains.ReSharper.ExternalProcessStorage
{
    
    public interface IServer
    {
        JetBrains.ReSharper.ExternalProcessStorage.SolutionAnalysis.ISolutionAnalysisStorage SolutionAnalysisStorage { get; }
        long GetTotalMemory(bool forceFullCollection);
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class StorageManager : JetBrains.ReSharper.ExternalProcessStorage.IServer, System.IDisposable
    {
        public StorageManager() { }
        public static JetBrains.ReSharper.ExternalProcessStorage.StorageManager Instance { get; }
        public JetBrains.ReSharper.ExternalProcessStorage.SolutionAnalysis.ISolutionAnalysisStorage SolutionAnalysisStorage { get; }
        public void AssertNotDisposed() { }
        public long GetTotalMemory(bool forceFullCollection) { }
    }
}
namespace JetBrains.ReSharper.ExternalProcessStorage.Remoting
{
    
    public class static RemotingUtil
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public static TIServer ConnectChannel<TIServer>([JetBrains.Annotations.NotNullAttribute()] string url, [JetBrains.Annotations.NotNullAttribute()] string channelName)
            where TIServer :  class { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.IDisposable RegisterRemotingServer<TServer>([JetBrains.Annotations.NotNullAttribute()] string url, [JetBrains.Annotations.NotNullAttribute()] string channelName) { }
    }
}
namespace JetBrains.ReSharper.ExternalProcessStorage.SolutionAnalysis
{
    
    public struct Dependency
    {
        public static readonly System.Collections.Generic.IEqualityComparer<JetBrains.ReSharper.ExternalProcessStorage.SolutionAnalysis.Dependency> Comparer;
        public Dependency(uint value) { }
        public static bool HaveTestPresentations { get; }
        public uint Value { get; }
        public bool Equals(JetBrains.ReSharper.ExternalProcessStorage.SolutionAnalysis.Dependency dependency) { }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
        public static void InitTestPresentationsMap() { }
        public static JetBrains.ReSharper.ExternalProcessStorage.SolutionAnalysis.Dependency[] ReadArray(System.IO.BinaryReader reader) { }
        public static JetBrains.ReSharper.ExternalProcessStorage.SolutionAnalysis.Dependency ReadFrom(System.IO.BinaryReader reader) { }
        public void RegisterTestPresentation(string presentation) { }
        public static void ReleaseTestPresentationsMap() { }
        public override string ToString() { }
        public static void WriteArray(JetBrains.ReSharper.ExternalProcessStorage.SolutionAnalysis.Dependency[] dependencies, System.IO.BinaryWriter writer) { }
        public void WriteTo(System.IO.BinaryWriter writer) { }
    }
    public class static DependencyToFileIdsMapConstants
    {
        public const int MIN_FILE_ID = 10;
    }
    public interface IDependencyToFileIdsMap : System.IDisposable
    {
        void AddDependencies(uint[] dependencies, uint fileId);
        void Compact(bool full);
        void FileIdBitsIncreased(int oldBitsCount, int newBitsCount);
        System.Collections.Generic.Dictionary<uint, uint> GetFilesToRehighlight(uint[] changes);
        string GetStatistics();
        void RemoveDependencies(uint[] dependencies, uint fileId);
    }
    public interface IDependencyToHashMap : System.IDisposable
    {
        int Count { get; }
        JetBrains.ReSharper.ExternalProcessStorage.SolutionAnalysis.SerializableHashes this[JetBrains.ReSharper.ExternalProcessStorage.SolutionAnalysis.SerializableDependencies dependencies] { get; }
        void Clear();
        void Compact();
    }
    public class InterruptedException : System.Exception
    {
        protected InterruptedException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    }
    public interface ISolutionAnalysisStorage
    {
        bool InterruptFlag { set; }
        void AddDependencies(JetBrains.ReSharper.ExternalProcessStorage.SolutionAnalysis.IDependencyToHashMap map, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.ExternalProcessStorage.SolutionAnalysis.IDependencyToHashMap touchedDependencies, JetBrains.ReSharper.ExternalProcessStorage.SolutionAnalysis.SerializableDependenciesAndHashes dependencies);
        void AddDependencies(JetBrains.ReSharper.ExternalProcessStorage.SolutionAnalysis.IDependencyToHashMap map, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.ExternalProcessStorage.SolutionAnalysis.IDependencyToHashMap touchedDependencies, int dependenciesAndHashesId);
        JetBrains.ReSharper.ExternalProcessStorage.SolutionAnalysis.IDependencyToFileIdsMap CreateDependencyToFileIdsMap(int fileIdBitsCount);
        JetBrains.ReSharper.ExternalProcessStorage.SolutionAnalysis.IDependencyToHashMap CreateDependencyToHashMap();
        JetBrains.ReSharper.ExternalProcessStorage.SolutionAnalysis.SerializableDependenciesAndHashes DependenciesAndHashesById(int id);
        int DependenciesAndHashesCountById(int id);
        void DisposeDependenciesAndHashes(int id);
        int StoreDependenciesAndHashes(JetBrains.ReSharper.ExternalProcessStorage.SolutionAnalysis.SerializableDependenciesAndHashes data);
        void SubtractDependencies(JetBrains.ReSharper.ExternalProcessStorage.SolutionAnalysis.IDependencyToHashMap map, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.ExternalProcessStorage.SolutionAnalysis.IDependencyToHashMap touchedDependencies, JetBrains.ReSharper.ExternalProcessStorage.SolutionAnalysis.SerializableDependenciesAndHashes dependencies);
        void SubtractDependencies(JetBrains.ReSharper.ExternalProcessStorage.SolutionAnalysis.IDependencyToHashMap map, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.ExternalProcessStorage.SolutionAnalysis.IDependencyToHashMap touchedDependencies, int dependenciesAndHashesId);
        JetBrains.ReSharper.ExternalProcessStorage.SolutionAnalysis.SerializableDependencies TouchedDependenciesToChanges(JetBrains.ReSharper.ExternalProcessStorage.SolutionAnalysis.IDependencyToHashMap dependencyToHash, JetBrains.ReSharper.ExternalProcessStorage.SolutionAnalysis.IDependencyToHashMap touchedDependencyToInitialValue);
    }
    public class SerializableDependencies : System.Runtime.Serialization.ISerializable
    {
        public SerializableDependencies(System.Collections.Generic.ICollection<JetBrains.ReSharper.ExternalProcessStorage.SolutionAnalysis.Dependency> collection) { }
        public SerializableDependencies(JetBrains.ReSharper.ExternalProcessStorage.SolutionAnalysis.Dependency dependency) { }
        public SerializableDependencies(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public System.Collections.Generic.ICollection<JetBrains.ReSharper.ExternalProcessStorage.SolutionAnalysis.Dependency> Collection { get; }
    }
    public class SerializableDependenciesAndHashes : System.Runtime.Serialization.ISerializable
    {
        public SerializableDependenciesAndHashes(System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<JetBrains.ReSharper.ExternalProcessStorage.SolutionAnalysis.Dependency, JetBrains.ReSharper.Psi.Dependencies.Hash>> collection) { }
        public System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<JetBrains.ReSharper.ExternalProcessStorage.SolutionAnalysis.Dependency, JetBrains.ReSharper.Psi.Dependencies.Hash>> Collection { get; }
    }
    public class SerializableHashes : System.Runtime.Serialization.ISerializable
    {
        public SerializableHashes(System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.Dependencies.Hash> collection) { }
        public SerializableHashes(JetBrains.ReSharper.Psi.Dependencies.Hash Hash) { }
        public SerializableHashes(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.Dependencies.Hash> Collection { get; }
    }
    public class static StatisticsUtil
    {
        public static void DumpDependencyMapStatistics<TDependency, TProjectFile>(System.Text.StringBuilder builder, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TDependency, System.Collections.Generic.IEnumerable<TProjectFile>>> map, int mapSize) { }
    }
}