[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]

namespace JetBrains.ReSharper.UnitTestRunner.nUnit
{
    
    public class BuiltInNUnitRunner : System.MarshalByRefObject, JetBrains.ReSharper.UnitTestRunner.nUnit.INUnitRunner
    {
        public BuiltInNUnitRunner(string resharperBin) { }
        public void Abort() { }
        public void ExploreTests(JetBrains.ReSharper.TaskRunnerFramework.IRemoteTaskServer server, bool useAddins, string assembly) { }
        public void RunTests(JetBrains.ReSharper.TaskRunnerFramework.IRemoteTaskServer server, System.Collections.Generic.Dictionary<string, JetBrains.ReSharper.TaskRunnerFramework.RemoteTask> tests, System.Collections.Generic.Dictionary<string, JetBrains.ReSharper.TaskRunnerFramework.RemoteTask> fixtures, System.Collections.Generic.List<string> explicitly, bool useAddins, System.Collections.Generic.List<string> assemblies) { }
    }
    public class CustomNUnitRunner : System.MarshalByRefObject, JetBrains.ReSharper.UnitTestRunner.nUnit.INUnitRunner
    {
        public CustomNUnitRunner(string nunitBin) { }
        public void Abort() { }
        public void ExploreTests(JetBrains.ReSharper.TaskRunnerFramework.IRemoteTaskServer server, bool useAddins, string assembly) { }
        public void RunTests(JetBrains.ReSharper.TaskRunnerFramework.IRemoteTaskServer server, System.Collections.Generic.Dictionary<string, JetBrains.ReSharper.TaskRunnerFramework.RemoteTask> tests, System.Collections.Generic.Dictionary<string, JetBrains.ReSharper.TaskRunnerFramework.RemoteTask> fixtures, System.Collections.Generic.List<string> explicitly, bool useAddins, System.Collections.Generic.List<string> assemblies) { }
    }
    public interface INUnitRunner
    {
        void Abort();
        void ExploreTests(JetBrains.ReSharper.TaskRunnerFramework.IRemoteTaskServer server, bool useAddins, string assembly);
        void RunTests(JetBrains.ReSharper.TaskRunnerFramework.IRemoteTaskServer server, System.Collections.Generic.Dictionary<string, JetBrains.ReSharper.TaskRunnerFramework.RemoteTask> tests, System.Collections.Generic.Dictionary<string, JetBrains.ReSharper.TaskRunnerFramework.RemoteTask> fixtures, System.Collections.Generic.List<string> explicitly, bool useAddins, System.Collections.Generic.List<string> assemblies);
    }
    public class NUnitAssemblyDiscoveryTask : JetBrains.ReSharper.TaskRunnerFramework.RemoteTask, System.IEquatable<JetBrains.ReSharper.UnitTestRunner.nUnit.NUnitAssemblyDiscoveryTask>
    {
        public NUnitAssemblyDiscoveryTask(System.Xml.XmlElement element) { }
        public NUnitAssemblyDiscoveryTask(System.Collections.Generic.Dictionary<string, string> assemblyLocations) { }
        public System.Collections.Generic.Dictionary<string, string> AssemblyLocations { get; }
        public override bool IsMeaningfulTask { get; }
        public bool Equals(JetBrains.ReSharper.UnitTestRunner.nUnit.NUnitAssemblyDiscoveryTask other) { }
        public override bool Equals(JetBrains.ReSharper.TaskRunnerFramework.RemoteTask other) { }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
        public override void SaveXml(System.Xml.XmlElement element) { }
    }
    public class NUnitGenericTestFixtureTask : JetBrains.ReSharper.TaskRunnerFramework.RemoteTask, System.IEquatable<JetBrains.ReSharper.UnitTestRunner.nUnit.NUnitGenericTestFixtureTask>
    {
        public NUnitGenericTestFixtureTask(string typeName, string parentId, bool explicitly) { }
        public NUnitGenericTestFixtureTask(System.Xml.XmlElement element) { }
        public bool Explicitly { get; }
        public override bool IsMeaningfulTask { get; }
        public string ParentId { get; }
        public string TypeName { get; }
        public bool Equals(JetBrains.ReSharper.UnitTestRunner.nUnit.NUnitGenericTestFixtureTask nUnitGenericTestFixtureTask) { }
        public override bool Equals(JetBrains.ReSharper.TaskRunnerFramework.RemoteTask other) { }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
        public override void SaveXml(System.Xml.XmlElement element) { }
    }
    public class NUnitListener : System.MarshalByRefObject, NUnit.Core.EventListener
    {
        public NUnitListener(JetBrains.ReSharper.TaskRunnerFramework.IRemoteTaskServer server, JetBrains.ReSharper.UnitTestRunner.nUnit.NUnitTestRunner runner, System.Collections.Generic.Dictionary<string, JetBrains.ReSharper.TaskRunnerFramework.RemoteTask> tasks, System.Collections.Generic.Dictionary<string, JetBrains.ReSharper.TaskRunnerFramework.RemoteTask> fixtures) { }
        public void RunFinished(NUnit.Core.TestResult result) { }
        public void RunFinished(System.Exception exception) { }
        public void RunStarted(string name, int testCount) { }
        public void SuiteFinished(NUnit.Core.TestResult result) { }
        public void SuiteStarted(NUnit.Core.TestName testName) { }
        public void TestFinished(NUnit.Core.TestResult result) { }
        public void TestOutput(NUnit.Core.TestOutput testOutput) { }
        public void TestStarted(NUnit.Core.TestName testName) { }
        public void UnhandledException(System.Exception exception) { }
    }
    public class NUnitRowTestTask : JetBrains.ReSharper.TaskRunnerFramework.RemoteTask, System.IEquatable<JetBrains.ReSharper.UnitTestRunner.nUnit.NUnitRowTestTask>
    {
        public NUnitRowTestTask(string name, bool explicitly, string parentId, string categories) { }
        public NUnitRowTestTask(System.Xml.XmlElement element) { }
        public string Categories { get; }
        public bool Explicitly { get; }
        public override bool IsMeaningfulTask { get; }
        public string Name { get; }
        public string ParentId { get; }
        public override bool Equals(JetBrains.ReSharper.TaskRunnerFramework.RemoteTask other) { }
        public override bool Equals(object obj) { }
        public bool Equals(JetBrains.ReSharper.UnitTestRunner.nUnit.NUnitRowTestTask nUnitRowTestTask) { }
        public override int GetHashCode() { }
        public override void SaveXml(System.Xml.XmlElement element) { }
    }
    public class NUnitSetUpFixtureTask : JetBrains.ReSharper.TaskRunnerFramework.RemoteTask, System.IEquatable<JetBrains.ReSharper.UnitTestRunner.nUnit.NUnitSetUpFixtureTask>
    {
        public NUnitSetUpFixtureTask(string typeName, string parentId) { }
        public NUnitSetUpFixtureTask(System.Xml.XmlElement element) { }
        public override bool IsMeaningfulTask { get; }
        public string ParentId { get; }
        public string TypeName { get; }
        public bool Equals(JetBrains.ReSharper.UnitTestRunner.nUnit.NUnitSetUpFixtureTask nUnitTestFixtureTask) { }
        public override bool Equals(JetBrains.ReSharper.TaskRunnerFramework.RemoteTask other) { }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
        public override void SaveXml(System.Xml.XmlElement element) { }
    }
    public class NUnitTaskRunner : JetBrains.ReSharper.TaskRunnerFramework.RecursiveRemoteTaskRunner
    {
        public const string NunitID = "nUnit";
        public NUnitTaskRunner(JetBrains.ReSharper.TaskRunnerFramework.IRemoteTaskServer server) { }
        public override void Abort() { }
        public override void ExecuteRecursive(JetBrains.ReSharper.TaskRunnerFramework.TaskExecutionNode node) { }
    }
    public class NUnitTestAssemblySetTask : JetBrains.ReSharper.TaskRunnerFramework.RemoteTask, System.IEquatable<JetBrains.ReSharper.UnitTestRunner.nUnit.NUnitTestAssemblySetTask>
    {
        public NUnitTestAssemblySetTask(System.Xml.XmlElement element) { }
        public NUnitTestAssemblySetTask(string nUnitInstallDir, JetBrains.ReSharper.UnitTestRunner.nUnit.UseAddins useAddins) { }
        public override bool IsMeaningfulTask { get; }
        public string NUnitInstallDir { get; }
        public JetBrains.ReSharper.UnitTestRunner.nUnit.UseAddins UseAddins { get; }
        public bool Equals(JetBrains.ReSharper.UnitTestRunner.nUnit.NUnitTestAssemblySetTask other) { }
        public override bool Equals(JetBrains.ReSharper.TaskRunnerFramework.RemoteTask other) { }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
        public override void SaveXml(System.Xml.XmlElement element) { }
    }
    public class NUnitTestAssemblyTask : JetBrains.ReSharper.TaskRunnerFramework.RemoteTask, System.IEquatable<JetBrains.ReSharper.UnitTestRunner.nUnit.NUnitTestAssemblyTask>
    {
        public NUnitTestAssemblyTask(System.Xml.XmlElement element) { }
        public NUnitTestAssemblyTask(string assemblyLocation) { }
        public string AssemblyLocation { get; }
        public override bool IsMeaningfulTask { get; }
        public bool Equals(JetBrains.ReSharper.UnitTestRunner.nUnit.NUnitTestAssemblyTask other) { }
        public override bool Equals(JetBrains.ReSharper.TaskRunnerFramework.RemoteTask other) { }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
        public override void SaveXml(System.Xml.XmlElement element) { }
    }
    public class NUnitTestFixtureTask : JetBrains.ReSharper.TaskRunnerFramework.RemoteTask, System.IEquatable<JetBrains.ReSharper.UnitTestRunner.nUnit.NUnitTestFixtureTask>
    {
        public NUnitTestFixtureTask(string typeName, string parentId, bool explicitly) { }
        public NUnitTestFixtureTask(System.Xml.XmlElement element) { }
        public bool Explicitly { get; }
        public override bool IsMeaningfulTask { get; }
        public string ParentId { get; }
        public string TypeName { get; }
        public bool Equals(JetBrains.ReSharper.UnitTestRunner.nUnit.NUnitTestFixtureTask nUnitTestFixtureTask) { }
        public override bool Equals(JetBrains.ReSharper.TaskRunnerFramework.RemoteTask other) { }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
        public override void SaveXml(System.Xml.XmlElement element) { }
    }
    public class NUnitTestRunner : NUnit.Core.RemoteTestRunner
    {
        public NUnit.Core.TestResult Run(NUnit.Core.EventListener listener, NUnit.Core.ITestFilter filter) { }
    }
    public class NUnitTestTask : JetBrains.ReSharper.TaskRunnerFramework.RemoteTask, System.IEquatable<JetBrains.ReSharper.UnitTestRunner.nUnit.NUnitTestTask>
    {
        public NUnitTestTask(string typeName, string shortName, string testId, bool explicitly, string[] childrenIds, string parentId) { }
        public NUnitTestTask(System.Xml.XmlElement element) { }
        public string[] ChildrenIds { get; }
        public bool Explicitly { get; }
        public override bool IsMeaningfulTask { get; }
        public string ParentId { get; }
        public string ShortName { get; }
        public string TestId { get; }
        public string TypeName { get; }
        public bool Equals(JetBrains.ReSharper.UnitTestRunner.nUnit.NUnitTestTask nUnitTestTask) { }
        public override bool Equals(JetBrains.ReSharper.TaskRunnerFramework.RemoteTask other) { }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
        public override void SaveXml(System.Xml.XmlElement element) { }
    }
    public enum UseAddins
    {
        Never = 0,
        Always = 1,
        IfRequired = 2,
    }
}