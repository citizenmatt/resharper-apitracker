[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]

namespace JetBrains.ReSharper.UnitTestRunner.JavaScript
{
    
    public class static HttpUtility
    {
        public static string HtmlDecode(string s) { }
        public static string HtmlEncode(string text) { }
        public static System.Collections.Specialized.NameValueCollection ParseQueryString(string s) { }
    }
    public abstract class JavaScriptTestRunnerBase : JetBrains.ReSharper.TaskRunnerFramework.RecursiveRemoteTaskRunner
    {
        protected JavaScriptTestRunnerBase(JetBrains.ReSharper.TaskRunnerFramework.IRemoteTaskServer server) { }
        public override void ExecuteRecursive(JetBrains.ReSharper.TaskRunnerFramework.TaskExecutionNode node) { }
        protected abstract JetBrains.ReSharper.UnitTestRunner.JavaScript.RequestHandlerBase GetRequestHandler(JetBrains.ReSharper.UnitTestRunner.JavaScript.Tasks.JavaScriptTestSetTask testSetTask, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.UnitTestRunner.JavaScript.Tasks.JavaScriptTestTask> tasks);
        protected abstract string KeyProvider(JetBrains.ReSharper.UnitTestRunner.JavaScript.Tasks.JavaScriptTestTask javaScriptTestTask);
        public static string QuoteArgument(string arg) { }
    }
    public class JsTestRunnerHttpServer : System.IDisposable
    {
        public JsTestRunnerHttpServer(JetBrains.ReSharper.TaskRunnerFramework.IRemoteTaskServer server, JetBrains.ReSharper.UnitTestRunner.JavaScript.Tasks.JavaScriptTestSetTask setTask, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.UnitTestRunner.JavaScript.Tasks.JavaScriptTestTask> tasks, JetBrains.ReSharper.UnitTestRunner.JavaScript.RequestHandlerBase requestHandler, System.Func<JetBrains.ReSharper.UnitTestRunner.JavaScript.Tasks.JavaScriptTestTask, string> keyProvider) { }
        public int PortNumber { get; }
        public void Dispose() { }
        public void Run() { }
    }
    public class static JsTestRunnerHttpServerEx
    {
        public static System.Collections.Generic.Dictionary<string, JetBrains.ReSharper.UnitTestRunner.JavaScript.Tasks.JavaScriptTestTask> ToDictionary(this System.Collections.Generic.IEnumerable<JetBrains.ReSharper.UnitTestRunner.JavaScript.Tasks.JavaScriptTestTask> tasks, System.Func<JetBrains.ReSharper.UnitTestRunner.JavaScript.Tasks.JavaScriptTestTask, string> keyProvider) { }
        public static JetBrains.ReSharper.TaskRunnerFramework.TaskResult ToTaskResult(this string s) { }
    }
    public abstract class RequestHandlerBase
    {
        public string BaseUrl { get; set; }
        public virtual string FormatStackTrace(string stacktrace) { }
        public static string LoadFile(string filename) { }
        public static string LoadResource(string path) { }
        public abstract bool ProcessRequest(System.Net.HttpListenerContext context, string path, System.Collections.Specialized.NameValueCollection @params);
        public static void WriteResponse(System.Net.HttpListenerResponse response, string text) { }
    }
}
namespace JetBrains.ReSharper.UnitTestRunner.JavaScript.Jasmine
{
    
    public class JasmineRequestHandler : JetBrains.ReSharper.UnitTestRunner.JavaScript.RequestHandlerBase
    {
        public JasmineRequestHandler(JetBrains.ReSharper.UnitTestRunner.JavaScript.Tasks.JavaScriptTestSetTask testSetTask, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.UnitTestRunner.JavaScript.Tasks.JavaScriptTestTask> tasks) { }
        public override string FormatStackTrace(string stacktrace) { }
        public override bool ProcessRequest(System.Net.HttpListenerContext context, string path, System.Collections.Specialized.NameValueCollection @params) { }
    }
    public class JasmineTestRunner : JetBrains.ReSharper.UnitTestRunner.JavaScript.JavaScriptTestRunnerBase
    {
        public const string ID = "Jasmine";
        public JasmineTestRunner(JetBrains.ReSharper.TaskRunnerFramework.IRemoteTaskServer server) { }
        protected override JetBrains.ReSharper.UnitTestRunner.JavaScript.RequestHandlerBase GetRequestHandler(JetBrains.ReSharper.UnitTestRunner.JavaScript.Tasks.JavaScriptTestSetTask testSetTask, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.UnitTestRunner.JavaScript.Tasks.JavaScriptTestTask> tasks) { }
        protected override string KeyProvider(JetBrains.ReSharper.UnitTestRunner.JavaScript.Tasks.JavaScriptTestTask javaScriptTestTask) { }
    }
}
namespace JetBrains.ReSharper.UnitTestRunner.JavaScript.QUnit
{
    
    public class QUnitRequestHandler : JetBrains.ReSharper.UnitTestRunner.JavaScript.RequestHandlerBase
    {
        public QUnitRequestHandler(JetBrains.ReSharper.UnitTestRunner.JavaScript.Tasks.JavaScriptTestSetTask task) { }
        public override bool ProcessRequest(System.Net.HttpListenerContext context, string path, System.Collections.Specialized.NameValueCollection @params) { }
    }
    public class QUnitTestRunner : JetBrains.ReSharper.UnitTestRunner.JavaScript.JavaScriptTestRunnerBase
    {
        public const string ID = "QUnit";
        public QUnitTestRunner(JetBrains.ReSharper.TaskRunnerFramework.IRemoteTaskServer server) { }
        protected override JetBrains.ReSharper.UnitTestRunner.JavaScript.RequestHandlerBase GetRequestHandler(JetBrains.ReSharper.UnitTestRunner.JavaScript.Tasks.JavaScriptTestSetTask testSetTask, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.UnitTestRunner.JavaScript.Tasks.JavaScriptTestTask> tasks) { }
        protected override string KeyProvider(JetBrains.ReSharper.UnitTestRunner.JavaScript.Tasks.JavaScriptTestTask javaScriptTestTask) { }
    }
}
namespace JetBrains.ReSharper.UnitTestRunner.JavaScript.Tasks
{
    
    public class JavaScriptModuleTask : JetBrains.ReSharper.TaskRunnerFramework.RemoteTask, System.IEquatable<JetBrains.ReSharper.UnitTestRunner.JavaScript.Tasks.JavaScriptModuleTask>
    {
        public JavaScriptModuleTask(string moduleName, string runnerId) { }
        public JavaScriptModuleTask(System.Xml.XmlElement element) { }
        public override bool IsMeaningfulTask { get; }
        public bool Equals(JetBrains.ReSharper.UnitTestRunner.JavaScript.Tasks.JavaScriptModuleTask other) { }
        public override bool Equals(JetBrains.ReSharper.TaskRunnerFramework.RemoteTask other) { }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
        public override void SaveXml(System.Xml.XmlElement element) { }
        public override string ToString() { }
    }
    public class JavaScriptTestSetTask : JetBrains.ReSharper.TaskRunnerFramework.RemoteTask, System.IEquatable<JetBrains.ReSharper.UnitTestRunner.JavaScript.Tasks.JavaScriptTestSetTask>
    {
        public JavaScriptTestSetTask(string filename, string browserLocation, string phantomJsScriptLocation, string[] referencedFiles, string projectFolder, string runnerId) { }
        public JavaScriptTestSetTask(System.Xml.XmlElement element) { }
        public string BrowserLocation { get; }
        public string Filename { get; }
        public override bool IsMeaningfulTask { get; }
        public string PhantomJsScriptLocation { get; }
        public string ProjectFolder { get; }
        public string[] ReferencedFiles { get; }
        public bool Equals(JetBrains.ReSharper.UnitTestRunner.JavaScript.Tasks.JavaScriptTestSetTask other) { }
        public override bool Equals(JetBrains.ReSharper.TaskRunnerFramework.RemoteTask other) { }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
        public override void SaveXml(System.Xml.XmlElement element) { }
    }
    public class JavaScriptTestTask : JetBrains.ReSharper.TaskRunnerFramework.RemoteTask, System.IEquatable<JetBrains.ReSharper.UnitTestRunner.JavaScript.Tasks.JavaScriptTestTask>
    {
        public JavaScriptTestTask(string testName, string runnerId) { }
        public JavaScriptTestTask(System.Xml.XmlElement element) { }
        public override bool IsMeaningfulTask { get; }
        public string TestName { get; }
        public bool Equals(JetBrains.ReSharper.UnitTestRunner.JavaScript.Tasks.JavaScriptTestTask other) { }
        public override bool Equals(JetBrains.ReSharper.TaskRunnerFramework.RemoteTask other) { }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
        public override void SaveXml(System.Xml.XmlElement element) { }
        public override string ToString() { }
    }
}