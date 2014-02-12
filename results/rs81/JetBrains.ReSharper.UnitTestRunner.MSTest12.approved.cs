[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]
[assembly: System.Runtime.Versioning.TargetFrameworkAttribute(".NETFramework,Version=v4.5", FrameworkDisplayName=".NET Framework 4.5")]

namespace JetBrains.ReSharper.UnitTestRunner.MSTest
{
    
    public class MsTestTaskRunner : JetBrains.ReSharper.UnitTestRunner.MSTest.MsTestTaskRunnerBase
    {
        public const string MSTEST_ID = "MSTest";
        public MsTestTaskRunner(JetBrains.ReSharper.TaskRunnerFramework.IRemoteTaskServer server) { }
        public override void Abort() { }
        public override void ExecuteRecursive(JetBrains.ReSharper.TaskRunnerFramework.TaskExecutionNode node) { }
    }
    public abstract class MsTestTaskRunnerBase : JetBrains.ReSharper.TaskRunnerFramework.RecursiveRemoteTaskRunner
    {
        protected readonly System.Collections.Generic.Dictionary<string, JetBrains.ReSharper.UnitTestRunner.MSTest.MsTestTestClassTask> myClasses;
        protected readonly System.Collections.Generic.Dictionary<string, JetBrains.ReSharper.UnitTestRunner.MSTest.MsTestTestMethodTask> myTests;
        protected MsTestTaskRunnerBase(JetBrains.ReSharper.TaskRunnerFramework.IRemoteTaskServer server) { }
        protected void FindTestsToRun(JetBrains.ReSharper.TaskRunnerFramework.TaskExecutionNode node) { }
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
    public class RunContext : Microsoft.VisualStudio.TestPlatform.ObjectModel.Adapter.IDiscoveryContext, Microsoft.VisualStudio.TestPlatform.ObjectModel.Adapter.IRunContext
    {
        public RunContext(string solutionDirectory, string testRunDirectory, Microsoft.VisualStudio.TestPlatform.ObjectModel.Adapter.IRunSettings runSettings) { }
        public bool InIsolation { get; }
        public bool IsBeingDebugged { get; }
        public bool IsDataCollectionEnabled { get; }
        public bool KeepAlive { get; }
        public Microsoft.VisualStudio.TestPlatform.ObjectModel.Adapter.IRunSettings RunSettings { get; }
        public string SolutionDirectory { get; }
        public string TestRunDirectory { get; }
        public Microsoft.VisualStudio.TestPlatform.ObjectModel.Adapter.ITestCaseFilterExpression GetTestCaseFilter(System.Collections.Generic.IEnumerable<string> supportedProperties, System.Func<string, Microsoft.VisualStudio.TestPlatform.ObjectModel.TestProperty> propertyProvider) { }
    }
}
namespace JetBrains.ReSharper.UnitTestRunner.MSTest11
{
    
    public class FrameworkHandle : Microsoft.VisualStudio.TestPlatform.ObjectModel.Adapter.IFrameworkHandle, Microsoft.VisualStudio.TestPlatform.ObjectModel.Adapter.ITestExecutionRecorder, Microsoft.VisualStudio.TestPlatform.ObjectModel.Logging.IMessageLogger
    {
        public FrameworkHandle(JetBrains.ReSharper.TaskRunnerFramework.IRemoteTaskServer server, System.Collections.Generic.Dictionary<string, JetBrains.ReSharper.UnitTestRunner.MSTest.MsTestTestMethodTask> tests) { }
        public bool EnableShutdownAfterTestRun { get; set; }
        public int LaunchProcessWithDebuggerAttached(string filePath, string workingDirectory, string arguments, System.Collections.Generic.IDictionary<string, string> environmentVariables) { }
        public void RecordAttachments(System.Collections.Generic.IList<Microsoft.VisualStudio.TestPlatform.ObjectModel.AttachmentSet> attachmentSets) { }
        public void RecordEnd(Microsoft.VisualStudio.TestPlatform.ObjectModel.TestCase testCase, Microsoft.VisualStudio.TestPlatform.ObjectModel.TestOutcome outcome) { }
        public void RecordResult(Microsoft.VisualStudio.TestPlatform.ObjectModel.TestResult testResult) { }
        public void RecordStart(Microsoft.VisualStudio.TestPlatform.ObjectModel.TestCase testCase) { }
        public void SendMessage(Microsoft.VisualStudio.TestPlatform.ObjectModel.Logging.TestMessageLevel testMessageLevel, string message) { }
    }
}
namespace JetBrains.ReSharper.UnitTestRunner.MSTest11.Metro
{
    
    public class static UtilEx
    {
        public static JetBrains.ReSharper.TaskRunnerFramework.TaskOutputType ToOutputType(this string category) { }
        public static JetBrains.ReSharper.TaskRunnerFramework.TaskResult ToTaskResult(this Microsoft.VisualStudio.TestPlatform.ObjectModel.TestOutcome outcome) { }
    }
}