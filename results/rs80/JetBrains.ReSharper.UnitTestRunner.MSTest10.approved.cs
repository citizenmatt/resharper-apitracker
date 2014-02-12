[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]

namespace JetBrains.ReSharper.UnitTestRunner.MSTest
{
    
    public class ContextAccessor : Microsoft.VisualStudio.TestTools.Execution.IContextAccessor
    {
        public ContextAccessor() { }
        public int Count { get; }
        public void AddDoubleValue(string key, double value) { }
        public void AddIntValue(string key, int value) { }
        public void AddObject(string key, object value) { }
        public void AddStringValue(string key, string value) { }
        public double GetDoubleValue(string key) { }
        public System.Collections.IDictionaryEnumerator GetEnumerator() { }
        public int GetIntValue(string key) { }
        public object GetObject(string key) { }
        public string GetStringValue(string key) { }
        public void RemoveValue(string key) { }
    }
    public class ExecutionRunConfiguration : Microsoft.VisualStudio.TestTools.Execution.IExecutionRunConfiguration
    {
        public ExecutionRunConfiguration(System.Reflection.Assembly qtcAssembly, Microsoft.VisualStudio.TestTools.Common.ITestElement[] testElements, Microsoft.VisualStudio.TestTools.Common.TestRunConfiguration runConfiguration) { }
        public Microsoft.VisualStudio.TestTools.Common.ITestElement[] TestElements { get; }
        public Microsoft.VisualStudio.TestTools.Common.TestRun TestRun { get; }
    }
    public class static MsTestAssemblies
    {
        public const string AOB_DLL_FQN = "Microsoft.VisualStudio.QualityTools.AgentObject, Version=10.0.0.0, Culture=neutra" +
            "l, PublicKeyToken=b03f5f7f11d50a3a";
        public const string APM_DLL_FQN = "Microsoft.VisualStudio.QualityTools.AgentProcessManager, Version=10.0.0.0, Cultur" +
            "e=neutral, PublicKeyToken=b03f5f7f11d50a3a";
        public const string COMMANDLINE_DLL_FQN = "Microsoft.VisualStudio.QualityTools.CommandLine, Version=10.0.0.0, Culture=neutra" +
            "l, PublicKeyToken=b03f5f7f11d50a3a";
        public const string GenericTipType_FQN = "Microsoft.VisualStudio.TestTools.TestTypes.Generic.GenericTestTip, Microsoft.Visu" +
            "alStudio.QualityTools.Tips.GenericTest.Tip, Version=10.0.0.0, Culture=neutral, P" +
            "ublicKeyToken=b03f5f7f11d50a3a";
        public const string MOLES_ADAPTER_FQN = "Microsoft.Moles.VsHost.Agent.MolesAgentAdapter";
        public const string MOLES_ASSEMBLY = "Microsoft.Moles.VsHost.exe";
        public const string QTC_DLL_FQN = "Microsoft.VisualStudio.QualityTools.Common, Version=10.0.0.0, Culture=neutral, Pu" +
            "blicKeyToken=b03f5f7f11d50a3a";
        public const string TMI_DLL_FQN = "Microsoft.VisualStudio.QualityTools.TMI, Version=10.0.0.0, Culture=neutral, Publi" +
            "cKeyToken=b03f5f7f11d50a3a";
        public const string UnitTestTipType_FQN = "Microsoft.VisualStudio.TestTools.TestTypes.Unit.UnitTestTip, Microsoft.VisualStud" +
            "io.QualityTools.Tips.UnitTest.Tip, Version=10.0.0.0, Culture=neutral, PublicKeyT" +
            "oken=b03f5f7f11d50a3a";
    }
    public class MsTestExeRunner
    {
        public MsTestExeRunner(System.Collections.Generic.List<Microsoft.VisualStudio.TestTools.Common.TestElement> runWithMsTestExe, JetBrains.ReSharper.UnitTestRunner.MSTest.ServerReporter serverReporter) { }
        public void Run(string assemblyLocation, string runConfigurationFilename, bool isolateRun) { }
        public void TestFinishedHandler(object sender, System.EventArgs args) { }
        public void TestStartedHandler(object sender, System.EventArgs args) { }
    }
    public class MsTestTaskRunner : JetBrains.ReSharper.TaskRunnerFramework.RecursiveRemoteTaskRunner
    {
        public const string MSTEST_ID = "MSTest";
        public MsTestTaskRunner(JetBrains.ReSharper.TaskRunnerFramework.IRemoteTaskServer server) { }
        public override void ExecuteRecursive(JetBrains.ReSharper.TaskRunnerFramework.TaskExecutionNode node) { }
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
    public class RealMsTestTaskRunner : System.MarshalByRefObject, JetBrains.ReSharper.UnitTestRunner.MSTest.IMsTestTaskRunner
    {
        public RealMsTestTaskRunner(JetBrains.ReSharper.TaskRunnerFramework.IRemoteTaskServer server, System.Collections.Generic.Dictionary<string, JetBrains.ReSharper.UnitTestRunner.MSTest.MsTestTestMethodTask> tests, System.Collections.Generic.Dictionary<string, JetBrains.ReSharper.UnitTestRunner.MSTest.MsTestTestClassTask> classes) { }
        public void RunCommand(JetBrains.ReSharper.UnitTestRunner.MSTest.MsTestTestAssemblyTask testAssemblyTask, string command) { }
        public void RunTests(JetBrains.ReSharper.UnitTestRunner.MSTest.MsTestTestAssemblyTask testAssemblyTask) { }
    }
    public class ResultSink : System.MarshalByRefObject, Microsoft.VisualStudio.TestTools.Execution.IResultSink
    {
        public ResultSink(JetBrains.ReSharper.UnitTestRunner.MSTest.ServerReporter serverReporter) { }
        public void AddResult(Microsoft.VisualStudio.TestTools.Common.TestMessage testMessage) { }
    }
    public class RunContext : Microsoft.VisualStudio.TestTools.Execution.IBaseRunContext, Microsoft.VisualStudio.TestTools.Execution.IRunContext, Microsoft.VisualStudio.TestTools.Utility.IRemoteDataProvider
    {
        public RunContext(Microsoft.VisualStudio.TestTools.Execution.IExecutionRunConfiguration runConfig, Microsoft.VisualStudio.TestTools.Execution.ITestContext testContext) { }
        public string AgentName { get; }
        public Microsoft.VisualStudio.TestTools.Execution.IResultSink ResultSink { get; }
        public Microsoft.VisualStudio.TestTools.Execution.IExecutionRunConfiguration RunConfig { get; }
        public Microsoft.VisualStudio.TestTools.Execution.IContextAccessor RunContextVariables { get; }
        public Microsoft.VisualStudio.TestTools.Execution.ITestRunner TestRunner { get; }
        public System.Collections.Generic.List<string> GetColumns(string invariantProviderName, string connectionString, string tableName) { }
        public void PauseTestRun() { }
        public System.Data.DataTable ReadTable(string invariantProviderName, string connectionString, string tableName) { }
        public void StopTestRun() { }
    }
    public class ServerReporter
    {
        public ServerReporter(JetBrains.ReSharper.TaskRunnerFramework.IRemoteTaskServer server, System.Collections.Generic.Dictionary<string, JetBrains.ReSharper.UnitTestRunner.MSTest.MsTestTestClassTask> classes, System.Collections.Generic.Dictionary<string, JetBrains.ReSharper.UnitTestRunner.MSTest.MsTestTestMethodTask> tests) { }
        public System.Collections.Generic.IEnumerable<Microsoft.VisualStudio.TestTools.Common.TestElement> TestsCollection { set; }
        public JetBrains.ReSharper.UnitTestRunner.MSTest.MsTestTestClassTask GetTestClassTask(string typeName) { }
        public JetBrains.ReSharper.UnitTestRunner.MSTest.MsTestTestMethodTask GetTestTask(string testName) { }
        public void TestException(string name, JetBrains.ReSharper.TaskRunnerFramework.TaskException[] exceptions) { }
        public void TestFinished(string name, string message, JetBrains.ReSharper.TaskRunnerFramework.TaskResult result) { }
        public void TestOutput(string name, string message, JetBrains.ReSharper.TaskRunnerFramework.TaskOutputType outputType) { }
        public void TestStarted(string name) { }
    }
    public class TestContext : Microsoft.VisualStudio.TestTools.Execution.ITestContext
    {
        public TestContext(JetBrains.ReSharper.UnitTestRunner.MSTest.ServerReporter server) { }
        public System.Collections.Generic.IDictionary<string, object> Properties { get; }
        public Microsoft.VisualStudio.TestTools.Execution.IResultSink ResultSink { get; }
        public Microsoft.VisualStudio.TestTools.Execution.IContextAccessor RunContextVariables { get; }
        public Microsoft.VisualStudio.TestTools.Execution.IContextAccessor TestContextVariables { get; }
    }
}