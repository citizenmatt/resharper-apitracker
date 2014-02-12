[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]

namespace JetBrains.ReSharper.UnitTestRunner.MSTest
{
    
    public class MsTestTaskRunner : JetBrains.ReSharper.TaskRunnerFramework.RecursiveRemoteTaskRunner
    {
        public const string MSTEST_ID = "MSTest";
        public MsTestTaskRunner(JetBrains.ReSharper.TaskRunnerFramework.IRemoteTaskServer server) { }
        public override void ExecuteRecursive(JetBrains.ReSharper.TaskRunnerFramework.TaskExecutionNode node) { }
        public void TestFinishedHandler(object sender, System.EventArgs args) { }
        public void TestStartedHandler(object sender, System.EventArgs args) { }
    }
    public class MsTestTestAssemblyTask : JetBrains.ReSharper.TaskRunnerFramework.RemoteTask, System.IEquatable<JetBrains.ReSharper.UnitTestRunner.MSTest.MsTestTestAssemblyTask>
    {
        public MsTestTestAssemblyTask(System.Xml.XmlElement element) { }
        public MsTestTestAssemblyTask(string runnerId, string assemblyLocation, string assemblyOutputLocation, string runConfigurationFilename, string visualStudioDirectory, bool isolateRun, int vsVersion, bool isMsilHost, string solutionFolder, string[] silverlightFolders, bool runWithMsTestExe) { }
        public string AssemblyLocation { get; }
        public string AssemblyOutputLocation { get; }
        public override bool IsMeaningfulTask { get; }
        public bool IsMsilHost { get; }
        public bool IsolateRun { get; }
        public string RunConfigurationFilename { get; }
        public bool RunWithMsTestExe { get; }
        public string[] SilverlightFolders { get; }
        public string SolutionFolder { get; }
        public string VisualStudioDirectory { get; }
        public override JetBrains.ReSharper.TaskRunnerFramework.RuntimeEnvironment EnsureRuntimeEnvironment(JetBrains.ReSharper.TaskRunnerFramework.RuntimeEnvironment runtimeEnvironment) { }
        public bool Equals(JetBrains.ReSharper.UnitTestRunner.MSTest.MsTestTestAssemblyTask other) { }
        public override bool Equals(JetBrains.ReSharper.TaskRunnerFramework.RemoteTask other) { }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
        public override void SaveXml(System.Xml.XmlElement element) { }
    }
    public class MsTestTestClassTask : JetBrains.ReSharper.TaskRunnerFramework.RemoteTask, System.IEquatable<JetBrains.ReSharper.UnitTestRunner.MSTest.MsTestTestClassTask>
    {
        public MsTestTestClassTask(System.Xml.XmlElement element) { }
        public MsTestTestClassTask(string runnerId, string typeName, bool ignore, int vsVersion, bool isMsilHost) { }
        public bool Ignore { get; }
        public override bool IsMeaningfulTask { get; }
        public string TypeName { get; }
        public override JetBrains.ReSharper.TaskRunnerFramework.RuntimeEnvironment EnsureRuntimeEnvironment(JetBrains.ReSharper.TaskRunnerFramework.RuntimeEnvironment runtimeEnvironment) { }
        public bool Equals(JetBrains.ReSharper.UnitTestRunner.MSTest.MsTestTestClassTask other) { }
        public override bool Equals(JetBrains.ReSharper.TaskRunnerFramework.RemoteTask other) { }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
        public override void SaveXml(System.Xml.XmlElement element) { }
    }
    public class MsTestTestMethodTask : JetBrains.ReSharper.TaskRunnerFramework.RemoteTask, System.IEquatable<JetBrains.ReSharper.UnitTestRunner.MSTest.MsTestTestMethodTask>
    {
        public MsTestTestMethodTask(string runnerId, string typeName, string shortName, int vsVersion, bool ignore, bool isMsilHost) { }
        public MsTestTestMethodTask(System.Xml.XmlElement element) { }
        public bool Ignore { get; }
        public override bool IsMeaningfulTask { get; }
        public string ShortName { get; }
        public string TypeName { get; }
        public override JetBrains.ReSharper.TaskRunnerFramework.RuntimeEnvironment EnsureRuntimeEnvironment(JetBrains.ReSharper.TaskRunnerFramework.RuntimeEnvironment runtimeEnvironment) { }
        public bool Equals(JetBrains.ReSharper.UnitTestRunner.MSTest.MsTestTestMethodTask other) { }
        public override bool Equals(JetBrains.ReSharper.TaskRunnerFramework.RemoteTask other) { }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
        public override void SaveXml(System.Xml.XmlElement element) { }
    }
    public class MsTestTestRowTask : JetBrains.ReSharper.TaskRunnerFramework.RemoteTask, System.IEquatable<JetBrains.ReSharper.UnitTestRunner.MSTest.MsTestTestRowTask>
    {
        public MsTestTestRowTask(System.Xml.XmlElement element) { }
        public MsTestTestRowTask(string runnerId, string testType, string testMethod, int number, int vsVersion, bool isMsilHost) { }
        public override bool IsMeaningfulTask { get; }
        public int Number { get; }
        public string TestMethod { get; }
        public string TestType { get; }
        public override JetBrains.ReSharper.TaskRunnerFramework.RuntimeEnvironment EnsureRuntimeEnvironment(JetBrains.ReSharper.TaskRunnerFramework.RuntimeEnvironment runtimeEnvironment) { }
        public bool Equals(JetBrains.ReSharper.UnitTestRunner.MSTest.MsTestTestRowTask other) { }
        public override bool Equals(JetBrains.ReSharper.TaskRunnerFramework.RemoteTask other) { }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
        public override void SaveXml(System.Xml.XmlElement element) { }
    }
}