[assembly: JetBrains.ReSharper.Daemon.RegisterStaticHighlightingsGroupAttribute("UnitTestGutterMarks", "Unit Test Gutter Marks", false)]
[assembly: JetBrains.TextControl.DocumentMarkup.RegisterHighlighterAttribute("ReSharper Unit Test Element Ignored", EffectType=JetBrains.TextControl.DocumentMarkup.EffectType.GUTTER_MARK, GutterMarkType=typeof(JetBrains.ReSharper.UnitTestFramework.Highlighting.UnitTestElementsGutterIgnoredMark), VSPriority=92)]
[assembly: JetBrains.TextControl.DocumentMarkup.RegisterHighlighterAttribute("ReSharper Unit Test Element", EffectType=JetBrains.TextControl.DocumentMarkup.EffectType.GUTTER_MARK, GutterMarkType=typeof(JetBrains.ReSharper.UnitTestFramework.Highlighting.UnitTestElementGutterMark), VSPriority=92)]
[assembly: JetBrains.TextControl.DocumentMarkup.RegisterHighlighterAttribute("ReSharper Unit Test Element Container", EffectType=JetBrains.TextControl.DocumentMarkup.EffectType.GUTTER_MARK, GutterMarkType=typeof(JetBrains.ReSharper.UnitTestFramework.Highlighting.UnitTestElementsGutterMark), VSPriority=92)]
[assembly: JetBrains.TextControl.DocumentMarkup.RegisterHighlighterAttribute("ReSharper Unit Test Container Successful", EffectType=JetBrains.TextControl.DocumentMarkup.EffectType.GUTTER_MARK, GutterMarkType=typeof(JetBrains.ReSharper.UnitTestFramework.Highlighting.UnitTestElementsGutterContainerSuccessfulMark), VSPriority=92)]
[assembly: JetBrains.TextControl.DocumentMarkup.RegisterHighlighterAttribute("ReSharper Unit Test Element Successful", EffectType=JetBrains.TextControl.DocumentMarkup.EffectType.GUTTER_MARK, GutterMarkType=typeof(JetBrains.ReSharper.UnitTestFramework.Highlighting.UnitTestElementsGutterSuccessfulMark), VSPriority=92)]
[assembly: JetBrains.TextControl.DocumentMarkup.RegisterHighlighterAttribute("ReSharper Unit Test Container Failed", EffectType=JetBrains.TextControl.DocumentMarkup.EffectType.GUTTER_MARK, GutterMarkType=typeof(JetBrains.ReSharper.UnitTestFramework.Highlighting.UnitTestElementsGutterContainerFailedMark), VSPriority=92)]
[assembly: JetBrains.TextControl.DocumentMarkup.RegisterHighlighterAttribute("ReSharper Unit Test Element Failed", EffectType=JetBrains.TextControl.DocumentMarkup.EffectType.GUTTER_MARK, GutterMarkType=typeof(JetBrains.ReSharper.UnitTestFramework.Highlighting.UnitTestElementsGutterFailedMark), VSPriority=92)]
[assembly: JetBrains.TextControl.DocumentMarkup.RegisterHighlighterAttribute("ReSharper Unit Test Container Ignored", EffectType=JetBrains.TextControl.DocumentMarkup.EffectType.GUTTER_MARK, GutterMarkType=typeof(JetBrains.ReSharper.UnitTestFramework.Highlighting.UnitTestElementsGutterContainerIgnoredMark), VSPriority=92)]
[assembly: JetBrains.UI.Icons.CompiledIcons.CompiledIconsPackAttribute(IconNames=new string[] {
        "StatusFailed",
        "StatusUnknown",
        "StatusFailedPassive",
        "TestFixtureFail",
        "StatusIgnored",
        "AppendSession",
        "TestFixtureAborted",
        "Session",
        "StatusInconclusive",
        "TrackRun",
        "TestMethodFail",
        "RunTest",
        "RunningError",
        "TestPending",
        "Time",
        "TestMethodIgnored",
        "StatusAborted",
        "Rerun",
        "RunAll",
        "TestMethod",
        "StatusAll",
        "StopTest",
        "NewSession",
        "Category",
        "LockSession",
        "TestFixtureIgnored",
        "DeleteTest",
        "TestFixture",
        "StatusSuccessPassive",
        "Debug",
        "TestFixtureSuccess",
        "StatusSuccess",
        "RunningTest",
        "Mstest",
        "BuildPolicy",
        "Kill",
        "Outdated",
        "TestMethodSuccess",
        "TestMethodAborted"}, IconPackResourceIdentification="JetBrains.ReSharper.UnitTestFramework;component/resources/UnitTestingThemedIcons/" +
    "ThemedIcons.UnitTesting.Generated.Xaml")]
[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]
[assembly: System.Windows.Markup.XmlnsDefinitionAttribute("urn:shemas-jetbrains-com:ui-application-icons-unit-testing", "JetBrains.ReSharper.UnitTestFramework.Resources")]

namespace JetBrains.ReSharper.UnitTestExplorer
{
    
    [JetBrains.Application.ShellComponentAttribute()]
    public class UnitTestHost
    {
        public UnitTestHost(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.UnitTestFramework.IHostProvider> hostProviders) { }
        public static JetBrains.ReSharper.UnitTestExplorer.UnitTestHost Instance { get; }
        public JetBrains.ReSharper.UnitTestFramework.IHostProvider GetProvider(string id) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.UnitTestFramework.IHostProvider> GetProviders() { }
    }
    public class static UnitTestIconManager
    {
        public static JetBrains.UI.Icons.IconId GetCombinedStateImage(JetBrains.ReSharper.UnitTestFramework.UnitTestStatus status, bool isContainer) { }
        public static JetBrains.UI.Icons.IconId GetStandardImage(JetBrains.ReSharper.UnitTestFramework.UI.UnitTestElementImage image) { }
        public static JetBrains.UI.Icons.IconId GetStateImage(JetBrains.UI.TreeView.PresentationState state) { }
        public static JetBrains.UI.Icons.IconId GetStateImage(JetBrains.ReSharper.UnitTestFramework.UnitTestRunStatus runStatus, JetBrains.ReSharper.UnitTestFramework.UnitTestStatus status, bool outdated) { }
    }
    [JetBrains.ProjectModel.Settings.Upgrade.SolutionSettingsUpgraderAttribute()]
    public class UnitTestSessionManagerSettingsUpgrader : JetBrains.Application.Configuration.Upgrade.ISettingsUpgrader, JetBrains.ProjectModel.Settings.Upgrade.ISolutionSettingsUpgrader
    {
        public UnitTestSessionManagerSettingsUpgrader(JetBrains.ProjectModel.ISolution solution) { }
    }
}
namespace JetBrains.ReSharper.UnitTestFramework.Analysis
{
    
    public class MethodFieldPropertyFilter : JetBrains.ReSharper.Psi.Resolve.ISymbolFilter
    {
        public static readonly JetBrains.ReSharper.UnitTestFramework.Analysis.MethodFieldPropertyFilter Instance;
        public JetBrains.ReSharper.Psi.Resolve.ResolveErrorType ErrorType { get; }
        public JetBrains.ReSharper.Psi.Resolve.FilterRunType RunType { get; }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Resolve.ISymbolInfo> FilterArray(System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Resolve.ISymbolInfo> data) { }
    }
}
namespace JetBrains.ReSharper.UnitTestFramework.AttributeChecker
{
    
    [JetBrains.ReSharper.Psi.PsiComponentAttribute()]
    public class UnitTestAttributeCache : JetBrains.ReSharper.Psi.Caches.InvalidatingPsiCache
    {
        public UnitTestAttributeCache(JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Psi.Search.SearchDomainFactory searchDomainFactory, JetBrains.Application.IShellLocks shellLocks) { }
        public JetBrains.Util.OneToListMap<JetBrains.ReSharper.Psi.IClrTypeName, JetBrains.ReSharper.Psi.IClrTypeName>.ValueCollection GetAllDerivedAttributes(JetBrains.ReSharper.Psi.IClrTypeName attributeClrName) { }
        public bool HasAttributeOrDerivedAttribute(JetBrains.ReSharper.Psi.IAttributesOwner attributesOwner, JetBrains.ReSharper.Psi.IClrTypeName attributeClrName) { }
        public bool HasAttributeOrDerivedAttribute(JetBrains.ReSharper.Psi.IAttributesOwner attributesOwner, params JetBrains.ReSharper.Psi.IClrTypeName[] attributeClrNames) { }
        public bool HasAttributeOrDerivedAttribute(JetBrains.Metadata.Reader.API.IMetadataEntity metadataEntity, JetBrains.ReSharper.Psi.IClrTypeName attributeClrName) { }
        public bool HasAttributeOrDerivedAttribute(JetBrains.Metadata.Reader.API.IMetadataEntity metadataEntity, params JetBrains.ReSharper.Psi.IClrTypeName[] attributeClrNames) { }
        protected override void InvalidateOnPhysicalChange() { }
    }
}
namespace JetBrains.ReSharper.UnitTestFramework
{
    
    public enum BuildPolicy
    {
        Automatic = 0,
        Always = 1,
        Never = 2,
        WholeSolution = 3,
    }
    [JetBrains.Annotations.BaseTypeRequiredAttribute(typeof(JetBrains.ReSharper.UnitTestFramework.IUnitTestFileExplorer))]
    public class FileUnitTestExplorerAttribute : JetBrains.ProjectModel.SolutionComponentAttribute { }
    public interface IDiscoveredRemoteTaskHandler
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.UnitTestFramework.IUnitTestElement Accept(JetBrains.ReSharper.UnitTestFramework.IUnitTestRun run, JetBrains.ReSharper.TaskRunnerFramework.RemoteTask task, out JetBrains.ProjectModel.IProject project);
        bool CanHandle(JetBrains.ReSharper.TaskRunnerFramework.RemoteTask task);
    }
    public interface IDynamicUnitTestProvider
    {
        JetBrains.ReSharper.UnitTestFramework.IUnitTestElement GetDynamicElement(JetBrains.ReSharper.TaskRunnerFramework.RemoteTask remoteTask, System.Collections.Generic.Dictionary<JetBrains.ReSharper.TaskRunnerFramework.RemoteTask, JetBrains.ReSharper.UnitTestFramework.IUnitTestElement> tasks);
    }
    public interface IHostProvider
    {
        JetBrains.ReSharper.UnitTestFramework.IHostProviderDescriptor Descriptor { get; }
        string ID { get; }
        bool Available();
        bool Available(JetBrains.ReSharper.UnitTestFramework.IUnitTestElement element);
        JetBrains.ReSharper.UnitTestFramework.ITaskRunnerHostController CreateHostController(JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.UnitTestFramework.IUnitTestLaunchManager launchManager, JetBrains.ReSharper.UnitTestFramework.IUnitTestAgentManager agentManager, JetBrains.ReSharper.UnitTestFramework.IUnitTestLaunch launch);
    }
    public interface IHostProviderDescriptor
    {
        string AllFromSolutionText { get; }
        string Format { get; }
        bool HasRunAllAction { get; }
        bool HasRunAllFromSolutionAction { get; }
        JetBrains.UI.Icons.IconId Icon { get; }
        JetBrains.UI.Icons.IconId IconAll { get; }
        int Priority { get; }
    }
    public interface IMsTestMetroStrategy : JetBrains.ReSharper.UnitTestFramework.Strategy.IPerProjectRunStrategy, JetBrains.ReSharper.UnitTestFramework.Strategy.IUnitTestRunStrategy
    {
        bool UnregisterPackageOnFinish { get; set; }
        string PackageFullName(JetBrains.ReSharper.UnitTestFramework.IUnitTestRun run);
        bool RegisterPackage(JetBrains.ReSharper.UnitTestFramework.IUnitTestRun run);
        void RunTests(JetBrains.ReSharper.UnitTestFramework.ITaskRunnerHostController runController, JetBrains.ReSharper.UnitTestFramework.IUnitTestRun run, JetBrains.ReSharper.UnitTestFramework.IUnitTestLaunch launch);
        void UnregisterPackage(JetBrains.ReSharper.UnitTestFramework.IUnitTestRun run);
    }
    public interface ITaskRunnerHostController : System.IDisposable
    {
        JetBrains.ReSharper.TaskRunnerFramework.TaskRunnerClientControllerInfo ClientControllerInfo { get; }
        string HostId { get; }
        void Abort(JetBrains.ReSharper.UnitTestFramework.IUnitTestRun run);
        void Cancel(JetBrains.ReSharper.UnitTestFramework.IUnitTestRun run);
        JetBrains.ReSharper.TaskRunnerFramework.TaskRunnerClientControllerInfo GetClientControllerInfo();
        void OnRunFinish(JetBrains.ReSharper.UnitTestFramework.IUnitTestRun run);
        void Run(JetBrains.ReSharper.UnitTestFramework.IUnitTestRun run, JetBrains.ReSharper.UnitTestFramework.Strategy.IUnitTestRunStrategy runStrategy, System.Action continuation);
    }
    public interface ITaskRunnerPacketHandler
    {
        string PacketName { get; }
        void Accept(System.Xml.XmlElement packet, JetBrains.ReSharper.TaskRunnerFramework.RemoteChannel remoteChannel);
    }
    public interface IUnitTestAgentManager
    {
        void RegisterRun(JetBrains.ReSharper.UnitTestFramework.IUnitTestRun run, JetBrains.ReSharper.UnitTestFramework.Strategy.IUnitTestRunStrategy strategy, JetBrains.ReSharper.UnitTestFramework.ITaskRunnerHostController controller);
        void SendPacket(JetBrains.ReSharper.UnitTestFramework.IUnitTestRun run, string packet);
    }
    public interface IUnitTestElement : System.IEquatable<JetBrains.ReSharper.UnitTestFramework.IUnitTestElement>
    {
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.UnitTestFramework.UnitTestElementCategory> Categories { get; }
        System.Collections.Generic.ICollection<JetBrains.ReSharper.UnitTestFramework.IUnitTestElement> Children { get; }
        bool Explicit { get; }
        string ExplicitReason { get; }
        string Id { get; }
        string Kind { get; }
        JetBrains.ReSharper.UnitTestFramework.IUnitTestElement Parent { get; set; }
        JetBrains.ReSharper.UnitTestFramework.IUnitTestProvider Provider { get; }
        string ShortName { get; }
        JetBrains.ReSharper.UnitTestFramework.UnitTestElementState State { get; set; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.IDeclaredElement GetDeclaredElement();
        JetBrains.ReSharper.UnitTestFramework.UnitTestElementDisposition GetDisposition();
        JetBrains.ReSharper.UnitTestFramework.UnitTestNamespace GetNamespace();
        string GetPresentation([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.UnitTestFramework.IUnitTestElement parent = null);
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ProjectModel.IProject GetProject();
        [JetBrains.Annotations.CanBeNullAttribute()]
        System.Collections.Generic.IEnumerable<JetBrains.ProjectModel.IProjectFile> GetProjectFiles();
        JetBrains.ReSharper.UnitTestFramework.Strategy.IUnitTestRunStrategy GetRunStrategy(JetBrains.ReSharper.UnitTestFramework.IHostProvider hostProvider);
        System.Collections.Generic.IList<JetBrains.ReSharper.UnitTestFramework.UnitTestTask> GetTaskSequence(System.Collections.Generic.ICollection<JetBrains.ReSharper.UnitTestFramework.IUnitTestElement> explicitElements, JetBrains.ReSharper.UnitTestFramework.IUnitTestLaunch launch);
    }
    public interface IUnitTestElementSerializer
    {
        JetBrains.ReSharper.UnitTestFramework.IUnitTestProvider Provider { get; }
        JetBrains.ReSharper.UnitTestFramework.IUnitTestElement DeserializeElement(System.Xml.XmlElement parent, JetBrains.ReSharper.UnitTestFramework.IUnitTestElement parentElement);
        void SerializeElement(System.Xml.XmlElement parent, JetBrains.ReSharper.UnitTestFramework.IUnitTestElement element);
    }
    public interface IUnitTestElementsTransformationRule
    {
        void Apply(JetBrains.ReSharper.UnitTestFramework.UnitTestElements elements);
    }
    public interface IUnitTestFileExplorer
    {
        JetBrains.ReSharper.UnitTestFramework.IUnitTestProvider Provider { get; }
        void ExploreFile(JetBrains.ReSharper.Psi.Tree.IFile psiFile, JetBrains.ReSharper.UnitTestFramework.UnitTestElementLocationConsumer consumer, JetBrains.Application.CheckForInterrupt interrupted);
    }
    public interface IUnitTestingSettingsAccessor
    {
        JetBrains.DataFlow.IProperty<bool> EnableUnitTesting { get; }
        bool IsProviderEnabled(JetBrains.ReSharper.UnitTestFramework.IUnitTestProvider provider);
        bool IsUnitTestingEnabled();
    }
    public interface IUnitTestLaunch
    {
        System.DateTime DateTimeStarted { get; }
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.UnitTestFramework.IUnitTestElement> Elements { get; }
        string Id { get; }
        JetBrains.ReSharper.UnitTestFramework.IUnitTestElement LastStartedElement { get; }
        JetBrains.DataFlow.Lifetime Lifetime { get; }
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.UnitTestFramework.IUnitTestRun> Runs { get; }
        JetBrains.DataFlow.IProperty<JetBrains.ReSharper.UnitTestFramework.UnitTestSessionState> State { get; }
        void Abort();
        JetBrains.ReSharper.UnitTestFramework.IUnitTestRun CreateRun(JetBrains.ReSharper.TaskRunnerFramework.RuntimeEnvironment runtimeEnvironment);
        void Finished();
        JetBrains.ReSharper.UnitTestFramework.IUnitTestRun GetRun(string id);
        JetBrains.ReSharper.TaskRunnerFramework.RemoteTask[][] GetTasks(string runId);
        void Run(JetBrains.ReSharper.UnitTestFramework.UnitTestElements elements, System.Collections.Generic.IEnumerable<JetBrains.ProjectModel.IProject> projects, JetBrains.ReSharper.UnitTestFramework.IHostProvider provider, JetBrains.ReSharper.TaskRunnerFramework.PlatformType automatic, JetBrains.ReSharper.TaskRunnerFramework.PlatformVersion frameworkVersion);
        void TaskDiscovered(JetBrains.ReSharper.UnitTestFramework.IUnitTestRun run, JetBrains.ReSharper.TaskRunnerFramework.RemoteTask task);
        void TaskDuration(JetBrains.ReSharper.TaskRunnerFramework.RemoteTask remoteTask, System.TimeSpan duration);
        void TaskException(JetBrains.ReSharper.TaskRunnerFramework.RemoteTask remoteTask, JetBrains.ReSharper.TaskRunnerFramework.TaskException[] exceptions);
        void TaskFinished(JetBrains.ReSharper.TaskRunnerFramework.RemoteTask remoteTask, string message, JetBrains.ReSharper.TaskRunnerFramework.TaskResult result);
        void TaskOutput(JetBrains.ReSharper.TaskRunnerFramework.RemoteTask remoteTask, string text, JetBrains.ReSharper.TaskRunnerFramework.TaskOutputType type);
        void TaskStarting(JetBrains.ReSharper.TaskRunnerFramework.RemoteTask remoteTask);
    }
    public interface IUnitTestLaunchManager
    {
        void AbortBuild();
        void BuildAndRunSession(JetBrains.ReSharper.UnitTestFramework.IUnitTestSessionView sessionView, JetBrains.ReSharper.UnitTestFramework.UnitTestElements elements, JetBrains.ReSharper.UnitTestFramework.IHostProvider hostProvider, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.UnitTestFramework.IUnitTestElementsTransformationRule> rules, JetBrains.ReSharper.UnitTestFramework.BuildPolicy buildPolicy = 0, JetBrains.ReSharper.TaskRunnerFramework.PlatformType platformType = 0, JetBrains.ReSharper.TaskRunnerFramework.PlatformVersion frameworkVersion = 0, bool focusAfterBuild = False);
        JetBrains.ReSharper.UnitTestFramework.IUnitTestLaunch CreateLaunch(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.UnitTestFramework.IDiscoveredRemoteTaskHandler> taskHandlers, System.Action<JetBrains.ReSharper.UnitTestFramework.IUnitTestElement> addElement);
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.UnitTestFramework.IUnitTestLaunch GetLaunchByRun(string runId);
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.UnitTestFramework.IUnitTestRun GetRun(string id);
        bool HasPreviousRunForSession(JetBrains.ReSharper.UnitTestFramework.IUnitTestSession session);
        void RepeatPreviousRunForSession(JetBrains.ReSharper.UnitTestFramework.IUnitTestSessionView session);
    }
    public interface IUnitTestMetadataExplorer
    {
        JetBrains.ReSharper.UnitTestFramework.IUnitTestProvider Provider { get; }
        void ExploreAssembly(JetBrains.ProjectModel.IProject project, JetBrains.Metadata.Reader.API.IMetadataAssembly assembly, JetBrains.ReSharper.UnitTestFramework.UnitTestElementConsumer consumer, System.Threading.ManualResetEvent exitEvent);
    }
    public interface IUnitTestNamespace
    {
        string NamespaceName { get; }
    }
    public interface IUnitTestPresenter
    {
        void Present(JetBrains.ReSharper.UnitTestFramework.IUnitTestElement element, JetBrains.CommonControls.IPresentableItem item, JetBrains.TreeModels.TreeModelNode node, JetBrains.UI.TreeView.PresentationState state);
    }
    public interface IUnitTestPreviewPanel { }
    public interface IUnitTestProjectsExplorer
    {
        JetBrains.ReSharper.UnitTestFramework.IUnitTestProvider Provider { get; }
        void ExploreProjects(System.Collections.Generic.ICollection<JetBrains.ProjectModel.IProject> projects, JetBrains.ReSharper.UnitTestFramework.UnitTestElementsConsumer consumer);
    }
    public interface IUnitTestProvider
    {
        string ID { get; }
        string Name { get; }
        int CompareUnitTestElements(JetBrains.ReSharper.UnitTestFramework.IUnitTestElement x, JetBrains.ReSharper.UnitTestFramework.IUnitTestElement y);
        void ExploreExternal(JetBrains.ReSharper.UnitTestFramework.UnitTestElementConsumer consumer);
        void ExploreSolution(JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.UnitTestFramework.UnitTestElementConsumer consumer);
        bool IsElementOfKind(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, JetBrains.ReSharper.UnitTestFramework.UnitTestElementKind elementKind);
        bool IsElementOfKind(JetBrains.ReSharper.UnitTestFramework.IUnitTestElement element, JetBrains.ReSharper.UnitTestFramework.UnitTestElementKind elementKind);
        bool IsSupported(JetBrains.ReSharper.UnitTestFramework.IHostProvider hostProvider);
    }
    public interface IUnitTestProvidersManager
    {
        System.Collections.Generic.IList<JetBrains.ReSharper.UnitTestFramework.IUnitTestProvider> GetDisabledProviders();
        JetBrains.ReSharper.UnitTestFramework.IUnitTestElementSerializer GetElementSerializer(string providerId);
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.UnitTestFramework.IUnitTestProvider> GetEnabledProviders();
    }
    public interface IUnitTestResultManager
    {
        JetBrains.DataFlow.ISignal<JetBrains.ReSharper.UnitTestFramework.IUnitTestElement> TestStarted { get; }
        public event System.EventHandler<JetBrains.ReSharper.UnitTestFramework.UnitTestResultEventArgs> UnitTestResultUpdated;
        JetBrains.ReSharper.UnitTestFramework.UnitTestResult GetResult(JetBrains.ReSharper.UnitTestFramework.IUnitTestElement element);
        System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<JetBrains.ReSharper.UnitTestFramework.IUnitTestElement, JetBrains.ReSharper.UnitTestFramework.UnitTestResult>> GetResults(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.UnitTestFramework.IUnitTestElement> elements);
        void MarkOutdated(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.UnitTestFramework.IUnitTestElement> elements);
        void TestDuration(JetBrains.ReSharper.UnitTestFramework.IUnitTestElement element, System.TimeSpan duration);
        void TestException(JetBrains.ReSharper.UnitTestFramework.IUnitTestElement element, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.TaskRunnerFramework.TaskException> exceptions);
        void TestFinishing(JetBrains.ReSharper.UnitTestFramework.IUnitTestElement element, string message, JetBrains.ReSharper.TaskRunnerFramework.TaskResult result);
        void TestOutput(JetBrains.ReSharper.UnitTestFramework.IUnitTestElement element, string text, JetBrains.ReSharper.TaskRunnerFramework.TaskOutputType type);
        void TestStarting(JetBrains.ReSharper.UnitTestFramework.IUnitTestElement element);
    }
    public interface IUnitTestRun : JetBrains.Util.IUserDataHolder
    {
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.UnitTestFramework.IUnitTestElement> Elements { get; }
        string ID { get; }
        JetBrains.ReSharper.UnitTestFramework.UnitTestRunStatus RunStatus { get; set; }
        JetBrains.ReSharper.TaskRunnerFramework.RuntimeEnvironment RuntimeEnvironment { get; }
        void AddTask(JetBrains.ReSharper.TaskRunnerFramework.RemoteTask task);
        void CreateDynamicElement(JetBrains.ReSharper.TaskRunnerFramework.RemoteTask remoteTask);
        JetBrains.ReSharper.UnitTestFramework.IUnitTestElement GetElementByRemoteTaskId(string id);
        System.Collections.Generic.Dictionary<string, JetBrains.ReSharper.UnitTestFramework.IUnitTestElement> GetTaskIdsToElements();
        JetBrains.ReSharper.TaskRunnerFramework.RemoteTask[][] GetTasks();
    }
    public interface IUnitTestSession
    {
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.UnitTestFramework.IUnitTestElement> Elements { get; }
        string Id { get; }
        JetBrains.DataFlow.IProperty<bool> IsIdle { get; }
        JetBrains.DataFlow.IProperty<JetBrains.ReSharper.UnitTestFramework.IUnitTestLaunch> Launch { get; }
        JetBrains.DataFlow.Lifetime Lifetime { get; }
        string Name { get; set; }
        JetBrains.DataFlow.ISignal<JetBrains.ReSharper.UnitTestFramework.IUnitTestSession> SessionContentsChanged { get; }
        JetBrains.ReSharper.UnitTestFramework.UnitTestResult SessionResult { get; }
        void AddElement(JetBrains.ReSharper.UnitTestFramework.IUnitTestElement element);
        void AddElements(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.UnitTestFramework.IUnitTestElement> unitTestElements);
        void Append(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.UnitTestFramework.IUnitTestElement> elements);
        bool HasElement(JetBrains.ReSharper.UnitTestFramework.IUnitTestElement element);
        bool IsEmpty();
        void RemoveElements(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.UnitTestFramework.IUnitTestElement> elements);
    }
    public interface IUnitTestSessionManager
    {
        JetBrains.ReSharper.UnitTestFramework.IUnitTestSessionView CurrentSession { get; }
        JetBrains.DataFlow.ISignal<JetBrains.ReSharper.UnitTestFramework.IUnitTestSessionView> SessionClosed { get; }
        JetBrains.DataFlow.ISignal<JetBrains.ReSharper.UnitTestFramework.IUnitTestSessionView> SessionCreated { get; }
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.UnitTestFramework.IUnitTestSessionView> Sessions { get; }
        void ActivateSession(JetBrains.ReSharper.UnitTestFramework.IUnitTestSessionView session);
        JetBrains.ReSharper.UnitTestFramework.IUnitTestSessionView AppendToCurrentOrNewSession(JetBrains.ReSharper.UnitTestFramework.UnitTestElements unitTests, bool focus = True, string name = null);
        void CloseAllSessions();
        void CloseSession(JetBrains.ReSharper.UnitTestFramework.IUnitTestSessionView session);
        JetBrains.ReSharper.UnitTestFramework.IUnitTestSessionView CreateSession(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.UnitTestFramework.IUnitTestElement> elements = null, string name = null, string id = null);
        JetBrains.ReSharper.UnitTestFramework.IUnitTestSessionView GetSession(string id);
        void OpenSession(JetBrains.ReSharper.UnitTestFramework.IUnitTestSessionView session, bool show = True);
        void RunInCurrentOrNewSession(JetBrains.ReSharper.UnitTestFramework.UnitTestElements unitTests, JetBrains.ReSharper.UnitTestFramework.IHostProvider hostProvider, bool focus = True, string name = null);
    }
    public interface IUnitTestSessionView
    {
        JetBrains.ReSharper.UnitTestFramework.BuildPolicy BuildPolicy { get; set; }
        JetBrains.ReSharper.TaskRunnerFramework.PlatformVersion FrameworkVersion { get; set; }
        int GroupingIndex { get; set; }
        JetBrains.DataFlow.IProperty<bool> Locked { get; }
        JetBrains.ReSharper.TaskRunnerFramework.PlatformType PlatformType { get; set; }
        JetBrains.ReSharper.UnitTestFramework.IUnitTestSession Session { get; }
        JetBrains.DataFlow.IProperty<string> Title { get; }
        bool TrackElements { get; set; }
        void ActivateElement(JetBrains.ReSharper.UnitTestFramework.IUnitTestElement element);
        void Run(JetBrains.ReSharper.UnitTestFramework.UnitTestElements elements, JetBrains.ReSharper.UnitTestFramework.IHostProvider provider, bool build = True, bool focus = True);
        void RunAll(JetBrains.ReSharper.UnitTestFramework.IHostProvider provider);
        [JetBrains.Annotations.UsedImplicitlyAttribute()]
        void SetActivePreviewPanel<T>()
            where T :  class, JetBrains.ReSharper.UnitTestFramework.IUnitTestPreviewPanel;
    }
    public interface IUnitTestSolutionBuilder
    {
        void AbortBuild();
        void BuildProjects(JetBrains.DataFlow.Lifetime lifetime, System.Collections.Generic.JetHashSet<JetBrains.ProjectModel.IProject> targetProjects, JetBrains.ReSharper.UnitTestFramework.BuildPolicy buildPolicy, System.Action<System.Collections.Generic.IEnumerable<JetBrains.ProjectModel.IProject>> successAction, System.Action<System.Collections.Generic.List<string>> funcFailed);
    }
    [JetBrains.Annotations.BaseTypeRequiredAttribute(typeof(JetBrains.ReSharper.UnitTestFramework.IUnitTestMetadataExplorer))]
    public class MetadataUnitTestExplorerAttribute : JetBrains.ProjectModel.SolutionComponentAttribute { }
    public class PersistentUnitTestSessionInfo : JetBrains.Application.Configuration.IXmlReadable, JetBrains.Application.Configuration.IXmlWritable
    {
        public const string ELEMENTS_TAG = "Elements";
        public const string ID_ATTRIBUTE = "Id";
        public PersistentUnitTestSessionInfo(JetBrains.ProjectModel.ISolution solution, string serialized = null) { }
        public System.Collections.Generic.ICollection<JetBrains.ReSharper.UnitTestFramework.IUnitTestElement> Elements { get; set; }
        [JetBrains.Application.Configuration.XmlExternalizableAttribute(false)]
        public bool Locked { get; set; }
        [JetBrains.Application.Configuration.XmlExternalizableAttribute(null)]
        public string Name { get; set; }
        public void ReadFromXml(System.Xml.XmlElement element) { }
        public override string ToString() { }
        public void WriteToXml(System.Xml.XmlElement element) { }
    }
    [JetBrains.ReSharper.UnitTestFramework.UnitTestHostProviderAttribute()]
    public class ProcessHostProvider : JetBrains.ReSharper.UnitTestFramework.IHostProvider
    {
        public JetBrains.ReSharper.UnitTestFramework.IHostProviderDescriptor Descriptor { get; }
        public string ID { get; }
        public bool Available() { }
        public bool Available(JetBrains.ReSharper.UnitTestFramework.IUnitTestElement element) { }
        public JetBrains.ReSharper.UnitTestFramework.ITaskRunnerHostController CreateHostController(JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.UnitTestFramework.IUnitTestLaunchManager launchManager, JetBrains.ReSharper.UnitTestFramework.IUnitTestAgentManager agentManager, JetBrains.ReSharper.UnitTestFramework.IUnitTestLaunch launch) { }
    }
    public class ProcessHostProviderDescriptor : JetBrains.ReSharper.UnitTestFramework.IHostProviderDescriptor
    {
        public string AllFromSolutionText { get; }
        public string Format { get; }
        public bool HasRunAllAction { get; }
        public bool HasRunAllFromSolutionAction { get; }
        public JetBrains.UI.Icons.IconId Icon { get; }
        public JetBrains.UI.Icons.IconId IconAll { get; }
        public int Priority { get; }
    }
    public class ProcessTaskRunnerHostController : JetBrains.ReSharper.UnitTestFramework.TaskRunnerHostControllerBase
    {
        public ProcessTaskRunnerHostController(JetBrains.ReSharper.UnitTestFramework.IUnitTestLaunchManager launchManager, JetBrains.ReSharper.UnitTestFramework.IUnitTestAgentManager agentManager, JetBrains.ReSharper.UnitTestFramework.IUnitTestLaunch launch, int port) { }
        public override string HostId { get; }
        public override void Abort(JetBrains.ReSharper.UnitTestFramework.IUnitTestRun run) { }
        public override void Run(JetBrains.ReSharper.UnitTestFramework.IUnitTestRun run) { }
    }
    public class static RuntimeEnvironmentEx
    {
        public static JetBrains.ReSharper.TaskRunnerFramework.PlatformType GetPlatformType(JetBrains.ProjectModel.IProject project) { }
        public static JetBrains.ReSharper.TaskRunnerFramework.RuntimeEnvironment GetRuntimeEnvironment(string assemblyLocation) { }
        public static JetBrains.ReSharper.TaskRunnerFramework.RuntimeEnvironment GetRuntimeEnvironment(JetBrains.ProjectModel.IProject project) { }
        public static bool IsClr4Required(JetBrains.ProjectModel.PlatformID projectPlatform) { }
    }
    public abstract class TaskRunnerHostControllerBase : JetBrains.ReSharper.UnitTestFramework.ITaskRunnerHostController, System.IDisposable
    {
        protected TaskRunnerHostControllerBase(JetBrains.ReSharper.UnitTestFramework.IUnitTestLaunchManager launchManager, JetBrains.ReSharper.UnitTestFramework.IUnitTestAgentManager agentManager, JetBrains.ReSharper.UnitTestFramework.IUnitTestLaunch launch) { }
        public JetBrains.ReSharper.TaskRunnerFramework.TaskRunnerClientControllerInfo ClientControllerInfo { get; }
        public abstract string HostId { get; }
        public JetBrains.ReSharper.UnitTestFramework.IUnitTestLaunch Launch { get; }
        protected JetBrains.ReSharper.UnitTestFramework.IUnitTestLaunchManager LaunchManager { get; }
        public abstract void Abort(JetBrains.ReSharper.UnitTestFramework.IUnitTestRun run);
        public virtual void Cancel(JetBrains.ReSharper.UnitTestFramework.IUnitTestRun run) { }
        public void Dispose() { }
        protected virtual void Dispose(bool disposing) { }
        protected override void Finalize() { }
        public virtual JetBrains.ReSharper.TaskRunnerFramework.TaskRunnerClientControllerInfo GetClientControllerInfo() { }
        protected string GetTaskRunnerCommandLineArgs(string sessionID, int port) { }
        protected JetBrains.Util.FileSystemPath GetTaskRunnerPathForRun(JetBrains.ReSharper.UnitTestFramework.IUnitTestRun run) { }
        public virtual void OnRunFinish(JetBrains.ReSharper.UnitTestFramework.IUnitTestRun run) { }
        public virtual void Run(JetBrains.ReSharper.UnitTestFramework.IUnitTestRun run, JetBrains.ReSharper.UnitTestFramework.Strategy.IUnitTestRunStrategy runStrategy, System.Action continuation) { }
        public abstract void Run(JetBrains.ReSharper.UnitTestFramework.IUnitTestRun run);
        protected void RunFinished(JetBrains.ReSharper.UnitTestFramework.IUnitTestRun run) { }
    }
    public class ThreadTaskRunnerHostController : JetBrains.ReSharper.UnitTestFramework.TaskRunnerHostControllerBase
    {
        public ThreadTaskRunnerHostController(JetBrains.ReSharper.UnitTestFramework.IUnitTestLaunchManager launchManager, JetBrains.ReSharper.UnitTestFramework.IUnitTestAgentManager agentManager, JetBrains.ReSharper.UnitTestFramework.IUnitTestLaunch launch, int port) { }
        public override string HostId { get; }
        public override void Abort(JetBrains.ReSharper.UnitTestFramework.IUnitTestRun run) { }
        public override void Run(JetBrains.ReSharper.UnitTestFramework.IUnitTestRun run) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute(JetBrains.Application.Components.ProgramConfigurations.NONE | JetBrains.Application.Components.ProgramConfigurations.VS_ADDIN | JetBrains.Application.Components.ProgramConfigurations.ALL)]
    public class UnitTestBackgroundProjectExplorer
    {
        public UnitTestBackgroundProjectExplorer(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ProjectModel.ISolution solution, JetBrains.Application.IShellLocks shellLocks, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.UnitTestFramework.IUnitTestMetadataExplorer> metadataExplorers, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.UnitTestFramework.IUnitTestProjectsExplorer> projectExplorers, JetBrains.ReSharper.UnitTestFramework.UnitTestProjectsToRebuildWatcher unitTestProjectsToRebuildWatcher, JetBrains.ReSharper.UnitTestFramework.Elements.UnitTestElementByProjectCache unitTestElementCache, JetBrains.ReSharper.UnitTestFramework.Elements.IUnitTestElementManager elementManager, JetBrains.ReSharper.UnitTestFramework.IUnitTestProvidersManager unitTestProvidersManager, JetBrains.ReSharper.UnitTestFramework.UnitTestProviders unitTestProviders, JetBrains.ReSharper.UnitTestFramework.Elements.IUnitTestElementManager unitTestElementsManager, JetBrains.ProjectModel.model2.Assemblies.AssemblyToAssemblyResolvers.AssemblyToAssemblyReferencesResolveManager referencesResolveManager, JetBrains.ReSharper.SolutionBuilder.SolutionBuilder solutionBuilder, JetBrains.ReSharper.UnitTestFramework.IUnitTestResultManager resultManager) { }
        public void Clear() { }
        public void ExploreProjects(System.Collections.Generic.ICollection<JetBrains.ProjectModel.IProject> projects) { }
        public void Remove(JetBrains.ProjectModel.IProject project) { }
        public void RescanAll() { }
        public void ScheduleProjects(System.Collections.Generic.ICollection<JetBrains.ProjectModel.IProject> projects) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute(JetBrains.Application.Components.ProgramConfigurations.NONE | JetBrains.Application.Components.ProgramConfigurations.VS_ADDIN | JetBrains.Application.Components.ProgramConfigurations.ALL)]
    public class UnitTestChangeListener
    {
        public UnitTestChangeListener(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ProjectModel.ISolution solution, JetBrains.DocumentManagers.DocumentManager documentManager, JetBrains.ReSharper.UnitTestFramework.UnitTestBackgroundProjectExplorer unitTestBackgroundProjectExplorer, JetBrains.ReSharper.UnitTestFramework.UnitTestProjectsToRebuildWatcher projectsToRebuildWatcher, JetBrains.Application.ChangeManager changeManager, JetBrains.ReSharper.Psi.Modules.IPsiModules psiModules, JetBrains.Application.IShellLocks shellLocks, JetBrains.ReSharper.SolutionBuilder.SolutionBuilder solutionBuilder, JetBrains.ReSharper.UnitTestFramework.Elements.IUnitTestElementManager unitTestElementManager, JetBrains.ReSharper.UnitTestFramework.Elements.UnitTestElementByProjectCache elementByProjectCache, JetBrains.ReSharper.UnitTestFramework.IUnitTestingSettingsAccessor settingsAccessor, JetBrains.ReSharper.Daemon.Daemon daemon, JetBrains.Application.Settings.ISettingsStore settingsStore, JetBrains.ReSharper.UnitTestFramework.Elements.UnitTestElementProjectFileCache elementByProjectFileCache) { }
        public void RefreshAll(bool enabled) { }
    }
    public class UnitTestElementCategory : System.IEquatable<JetBrains.ReSharper.UnitTestFramework.UnitTestElementCategory>
    {
        public static readonly System.Collections.Generic.JetHashSet<JetBrains.ReSharper.UnitTestFramework.UnitTestElementCategory> Uncategorized;
        public const string UncategorizedString = "<Uncategorized>";
        public string Name { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Collections.Generic.IEnumerable<JetBrains.ReSharper.UnitTestFramework.UnitTestElementCategory> Create([JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.JetHashSet<string> categories) { }
        public bool Equals(JetBrains.ReSharper.UnitTestFramework.UnitTestElementCategory unitTestElementCategory) { }
        public override bool Equals(object obj) { }
        public static JetBrains.ReSharper.UnitTestFramework.UnitTestElementCategory Get(string name) { }
        public override int GetHashCode() { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Collections.Generic.IEnumerable<JetBrains.ReSharper.UnitTestFramework.UnitTestElementCategory> Merge([JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IEnumerable<JetBrains.ReSharper.UnitTestFramework.UnitTestElementCategory> existing, [JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.JetHashSet<string> categories) { }
        public override string ToString() { }
    }
    public class UnitTestElementComparer : System.Collections.Generic.IComparer<JetBrains.ReSharper.UnitTestFramework.IUnitTestElement>
    {
        public UnitTestElementComparer(params System.Type[] testElementsTypes) { }
        public int Compare(JetBrains.ReSharper.UnitTestFramework.IUnitTestElement x, JetBrains.ReSharper.UnitTestFramework.IUnitTestElement y) { }
    }
    public delegate void UnitTestElementConsumer(JetBrains.ReSharper.UnitTestFramework.IUnitTestElement unitTestElement);
    public class UnitTestElementDisposition
    {
        public static readonly JetBrains.ReSharper.UnitTestFramework.UnitTestElementDisposition InvalidDisposition;
        public UnitTestElementDisposition(JetBrains.ReSharper.UnitTestFramework.IUnitTestElement unitTestElement, JetBrains.ProjectModel.IProjectFile projectFile, JetBrains.Util.TextRange textRange, JetBrains.Util.TextRange containingRange) { }
        public UnitTestElementDisposition(JetBrains.ReSharper.UnitTestFramework.IUnitTestElement unitTestElement, JetBrains.ProjectModel.IProjectFile projectFile, JetBrains.Util.TextRange textRange, JetBrains.Util.TextRange containingRange, System.Collections.Generic.IList<JetBrains.ReSharper.UnitTestFramework.IUnitTestElement> subElements) { }
        public UnitTestElementDisposition(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.UnitTestFramework.UnitTestElementLocation> locations, JetBrains.ReSharper.UnitTestFramework.IUnitTestElement unitTestElement) { }
        public System.Collections.Generic.IList<JetBrains.ReSharper.UnitTestFramework.UnitTestElementLocation> Locations { get; }
        public System.Collections.Generic.IList<JetBrains.ReSharper.UnitTestFramework.IUnitTestElement> SubElements { get; }
        public JetBrains.ReSharper.UnitTestFramework.IUnitTestElement UnitTestElement { get; }
        public static JetBrains.ReSharper.UnitTestFramework.UnitTestElementDisposition NotYetClear(JetBrains.ReSharper.UnitTestFramework.IUnitTestElement element) { }
    }
    public class static UnitTestElementEx
    {
        public static JetBrains.ReSharper.UnitTestFramework.UnitTestElementPointer CreatePointer(this JetBrains.ReSharper.UnitTestFramework.IUnitTestElement element, JetBrains.ProjectModel.ProjectModelElementPointerManager pointerManager, JetBrains.ReSharper.UnitTestFramework.Elements.IUnitTestElementManager unitTestElementManager) { }
    }
    public enum UnitTestElementKind
    {
        Unknown = 0,
        Test = 1,
        TestContainer = 2,
        TestStuff = 3,
    }
    public class UnitTestElementLocation
    {
        public UnitTestElementLocation(JetBrains.ProjectModel.IProjectFile projectFile, JetBrains.Util.TextRange navigationRange, JetBrains.Util.TextRange containingRange) { }
        public JetBrains.Util.TextRange ContainingRange { get; }
        public JetBrains.Util.TextRange NavigationRange { get; }
        public JetBrains.ProjectModel.IProjectFile ProjectFile { get; }
    }
    public delegate void UnitTestElementLocationConsumer(JetBrains.ReSharper.UnitTestFramework.UnitTestElementDisposition unitTestID);
    public class UnitTestElementPointer
    {
        public UnitTestElementPointer(JetBrains.ReSharper.UnitTestFramework.IUnitTestElement element, JetBrains.ProjectModel.ProjectModelElementPointerManager pointerManager, JetBrains.ReSharper.UnitTestFramework.Elements.IUnitTestElementManager unitTestElementManager) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public string ElementId { get; }
        public bool Equals(JetBrains.ReSharper.UnitTestFramework.UnitTestElementPointer other) { }
        public override bool Equals(object obj) { }
        public JetBrains.ReSharper.UnitTestFramework.IUnitTestElement GetElement() { }
        public override int GetHashCode() { }
        public override string ToString() { }
    }
    public class UnitTestElements
    {
        public UnitTestElements(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.UnitTestFramework.IUnitTestElement> elements = null, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.UnitTestFramework.IUnitTestElement> explicitElements = null) { }
        public System.Collections.Generic.JetHashSet<JetBrains.ReSharper.UnitTestFramework.IUnitTestElement> Elements { get; }
        public System.Collections.Generic.JetHashSet<JetBrains.ReSharper.UnitTestFramework.IUnitTestElement> ExplicitElements { get; }
        public static void FillElementRecursive(JetBrains.ReSharper.UnitTestFramework.IUnitTestElement element, System.Collections.Generic.ICollection<JetBrains.ReSharper.UnitTestFramework.IUnitTestElement> elements) { }
        public static System.Collections.Generic.ICollection<JetBrains.ReSharper.UnitTestFramework.IUnitTestElement> GetElementsRecursive(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.UnitTestFramework.IUnitTestElement> elements) { }
        public static System.Collections.Generic.IEnumerable<JetBrains.ReSharper.UnitTestFramework.IUnitTestElement> GetElementsRecursive(JetBrains.ReSharper.UnitTestFramework.IUnitTestElement element) { }
    }
    public delegate void UnitTestElementsConsumer(JetBrains.ProjectModel.IProject project, System.Collections.Generic.ICollection<JetBrains.ReSharper.UnitTestFramework.IUnitTestElement> unitTestElement);
    public enum UnitTestElementState
    {
        Valid = 0,
        Dynamic = 1,
        Pending = 2,
        Invalid = 3,
        Fake = 4,
    }
    public class static UnitTestElementStateEx
    {
        public static bool IsPendingOrDynamic(this JetBrains.ReSharper.UnitTestFramework.UnitTestElementState state) { }
        public static bool IsValid(this JetBrains.ReSharper.UnitTestFramework.UnitTestElementState state) { }
        public static bool IsValidNotDynamic(this JetBrains.ReSharper.UnitTestFramework.UnitTestElementState state) { }
    }
    public class UnitTestElementsTransformationRuleAttribute : JetBrains.ProjectModel.SolutionComponentAttribute
    {
        public UnitTestElementsTransformationRuleAttribute() { }
        public bool Explicit { get; set; }
    }
    public class UnitTestEventArgs : System.EventArgs
    {
        public UnitTestEventArgs(JetBrains.ReSharper.UnitTestFramework.IUnitTestElement element) { }
        public UnitTestEventArgs(JetBrains.ReSharper.UnitTestFramework.IUnitTestElement element, JetBrains.ReSharper.UnitTestFramework.UnitTestResult elementResult) { }
        public JetBrains.ReSharper.UnitTestFramework.IUnitTestElement Element { get; }
        public JetBrains.ReSharper.UnitTestFramework.UnitTestResult ElementResult { get; }
    }
    [JetBrains.Application.Settings.SettingsKeyAttribute(typeof(JetBrains.ReSharper.UnitTestFramework.UnitTestingMruSettings), "Unit Test Explorer settings")]
    public class UnitTestExplorerSettings
    {
        [JetBrains.Application.Settings.SettingsEntryAttribute(3, "Index of tree grouping provider")]
        public int GroupingIndex;
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class UnitTestFileExplorer
    {
        public UnitTestFileExplorer(JetBrains.ProjectModel.ISolution solution, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.UnitTestFramework.IUnitTestFileExplorer> fileExplorers, JetBrains.Application.IShellLocks shellLocks, JetBrains.ReSharper.UnitTestFramework.IUnitTestProvidersManager unitTestProviders, JetBrains.ReSharper.UnitTestFramework.Elements.UnitTestElementProjectFileCache unitTestElementCache, JetBrains.ReSharper.UnitTestFramework.Elements.IUnitTestElementManager unitTestElementManager, JetBrains.ReSharper.UnitTestFramework.IUnitTestResultManager resultsManager) { }
        public System.Collections.Generic.List<JetBrains.ReSharper.UnitTestFramework.UnitTestElementDisposition> Explore(JetBrains.ReSharper.Psi.Tree.IFile file, JetBrains.Application.CheckForInterrupt interrupt, JetBrains.ReSharper.UnitTestFramework.UnitTestElementConsumer consumer) { }
        public System.Collections.Generic.IList<JetBrains.ReSharper.UnitTestFramework.IUnitTestElement> GetElements(JetBrains.DocumentModel.IDocument document, JetBrains.Util.TextRange documentRange, JetBrains.Application.CheckForInterrupt checkForInterrupt, JetBrains.ReSharper.UnitTestFramework.UnitTestElementConsumer consumer = null) { }
    }
    [JetBrains.Annotations.MeansImplicitUseAttribute()]
    [System.AttributeUsageAttribute(System.AttributeTargets.Class | System.AttributeTargets.All, AllowMultiple=false, Inherited=false)]
    public class UnitTestHostProviderAttribute : JetBrains.Application.ShellComponentAttribute { }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class UnitTestingAssemblyLoader : System.IDisposable
    {
        public UnitTestingAssemblyLoader() { }
        public void RegisterAssembly(System.Reflection.Assembly assembly) { }
    }
    [JetBrains.Application.Settings.SettingsKeyAttribute(typeof(JetBrains.Application.Settings.HousekeepingSettings), "MRU values for unit testing")]
    public class UnitTestingMruSettings { }
    [JetBrains.Application.Settings.SettingsKeyAttribute(typeof(JetBrains.Application.Settings.EnvironmentSettings), "Unit testing settings")]
    public class UnitTestingSettings
    {
        [JetBrains.Application.Settings.SettingsEntryAttribute("", "Custom directory for test assemblies and data")]
        public string CustomStartDirectory;
        [JetBrains.Application.Settings.SettingsIndexedEntryAttribute("Disabled providers")]
        public JetBrains.Application.Settings.Store.IIndexedEntry<string, bool> DisabledProviders;
        [JetBrains.Application.Settings.SettingsEntryAttribute(false, "Enable internal debug")]
        public bool EnableDebugInternal;
        [JetBrains.Application.Settings.SettingsEntryAttribute(true, "Enable unit testing")]
        public bool EnableUnitTesting;
        [JetBrains.Application.Settings.SettingsEntryAttribute("", "List of excluded categories")]
        public string ExcludedCategoriesList;
        [JetBrains.Application.Settings.SettingsEntryAttribute(1, "Number of test runner processes running in parallel")]
        public int ParallelProcessesCount;
        [JetBrains.Application.Settings.SettingsEntryAttribute(true, "Save session state on close and restore on startup")]
        public bool SaveSessionState;
        [JetBrains.Application.Settings.SettingsEntryAttribute(true, "Shadow-copy assemblies being tested")]
        public bool ShadowCopy;
        [JetBrains.Application.Settings.SettingsEntryAttribute(false, "Use custom directory for tests")]
        public bool UseCustomStartDirectory;
        [JetBrains.Application.Settings.SettingsEntryAttribute(true, "Wrap long lines in unit tests output")]
        public bool WrapLongLinesInUnitTestSessionOutput;
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class UnitTestingSettingsAccessor : JetBrains.ReSharper.UnitTestFramework.IUnitTestingSettingsAccessor
    {
        public UnitTestingSettingsAccessor(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.Settings.ISettingsStore settingsStore, JetBrains.ProjectModel.ISolution solution) { }
        public JetBrains.DataFlow.IProperty<bool> EnableUnitTesting { get; }
        public bool IsProviderEnabled(JetBrains.ReSharper.UnitTestFramework.IUnitTestProvider provider) { }
        public bool IsUnitTestingEnabled() { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class UnitTestManager
    {
        public UnitTestManager(JetBrains.ReSharper.UnitTestFramework.IUnitTestProvidersManager unitTestProvidersManager, JetBrains.ReSharper.UnitTestFramework.Elements.UnitTestElementProjectFileCache elementProjectFileCache, JetBrains.ReSharper.UnitTestFramework.Elements.UnitTestElementShortNameCache shortNamesCache, JetBrains.ReSharper.UnitTestFramework.Elements.UnitTestElementByProjectCache unitTestElementByProjectCache, JetBrains.ReSharper.UnitTestFramework.IUnitTestingSettingsAccessor unitTestingSettingsAccessor) { }
        public virtual bool CanExecuteAction() { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.UnitTestFramework.IUnitTestElement GetElement([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
        public System.Collections.Generic.IList<JetBrains.ReSharper.UnitTestFramework.IUnitTestElement> GetElements(System.Collections.Generic.IList<JetBrains.ProjectModel.IProjectItem> targetProjectItems) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.UnitTestFramework.IUnitTestElement> GetElements(System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.IDeclaredElement> elements) { }
        public bool IsElementOfKind(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, JetBrains.ReSharper.UnitTestFramework.UnitTestElementKind elementKind) { }
        public bool IsElementOfKind(JetBrains.ReSharper.UnitTestFramework.IUnitTestElement element, JetBrains.ReSharper.UnitTestFramework.UnitTestElementKind elementKind) { }
        public virtual bool UpdateAction(JetBrains.ActionManagement.ActionPresentation presentation) { }
    }
    [JetBrains.ProjectModel.Settings.Upgrade.SolutionSettingsUpgraderAttribute()]
    public class UnitTestManagerSettingsUpgrader : JetBrains.Application.Configuration.IXmlReadable, JetBrains.Application.Configuration.Upgrade.ISettingsUpgrader, JetBrains.ProjectModel.Settings.Upgrade.ISolutionSettingsUpgrader
    {
        public UnitTestManagerSettingsUpgrader() { }
        [JetBrains.Application.Configuration.XmlExternalizableAttribute("")]
        public string CustomStartDirectory { get; set; }
        public bool EnableDebugInternal { get; set; }
        [JetBrains.Application.Configuration.XmlExternalizableAttribute(true, SettingName="EnableUnitTesting")]
        public bool EnableUnitTesting { get; set; }
        [JetBrains.Application.Configuration.XmlExternalizableAttribute("")]
        public string ExcludedCategoriesList { get; set; }
        [JetBrains.Application.Configuration.XmlExternalizableAttribute(1)]
        public int ParallelProcessesCount { get; set; }
        [JetBrains.Application.Configuration.XmlExternalizableAttribute(true)]
        public bool SaveSessionState { get; set; }
        [JetBrains.Application.Configuration.XmlExternalizableAttribute(true, SettingName="UseShadowCopy")]
        public bool ShadowCopy { get; set; }
        [JetBrains.Application.Configuration.XmlExternalizableAttribute(false, SettingName="UseCustomFolder")]
        public bool UseCustomStartDirectory { get; set; }
    }
    public class UnitTestNamespace : JetBrains.ReSharper.UnitTestFramework.IUnitTestNamespace, System.IEquatable<JetBrains.ReSharper.UnitTestFramework.UnitTestNamespace>
    {
        public UnitTestNamespace(string clrName) { }
        public string NamespaceName { get; }
        public bool Equals(JetBrains.ReSharper.UnitTestFramework.UnitTestNamespace unitTestNamespace) { }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
    }
    public class UnitTestPresentationState : JetBrains.UI.TreeView.PresentationState
    {
        public UnitTestPresentationState(JetBrains.UI.TreeView.PresentationState state) { }
        public bool Outdated { get; set; }
        public JetBrains.ReSharper.UnitTestFramework.UnitTestRunStatus RunStatus { get; set; }
        public JetBrains.ReSharper.UnitTestFramework.UnitTestStatus Status { get; set; }
    }
    [JetBrains.Annotations.BaseTypeRequiredAttribute(typeof(JetBrains.ReSharper.UnitTestFramework.IUnitTestPresenter))]
    [JetBrains.Annotations.MeansImplicitUseAttribute()]
    [System.AttributeUsageAttribute(System.AttributeTargets.Class | System.AttributeTargets.All)]
    public class UnitTestPresenterAttribute : JetBrains.ProjectModel.SolutionComponentAttribute { }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class UnitTestProjectsToRebuildWatcher
    {
        public UnitTestProjectsToRebuildWatcher() { }
        public System.Collections.Generic.JetHashSet<JetBrains.ProjectModel.IProject> GetNotBuiltProjects() { }
        public void MarkProjectForBuild(JetBrains.ProjectModel.IProject project) { }
        public void MarkProjectsForBuild(System.Collections.Generic.IEnumerable<JetBrains.ProjectModel.IProject> projects) { }
        public void Remove(JetBrains.ProjectModel.IProject project) { }
        public void Remove(System.Collections.Generic.IEnumerable<JetBrains.ProjectModel.IProject> projects) { }
        public bool ShouldBuild(System.Collections.Generic.IEnumerable<JetBrains.ProjectModel.IProject> projects) { }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Class | System.AttributeTargets.All)]
    public class UnitTestProviderAttribute : JetBrains.Application.ShellComponentAttribute { }
    [JetBrains.Application.ShellComponentAttribute()]
    public class UnitTestProviders
    {
        public UnitTestProviders(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.UnitTestFramework.IUnitTestProvider> providers) { }
        public JetBrains.ReSharper.UnitTestFramework.IUnitTestProvider GetProvider(string providerId) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.UnitTestFramework.IUnitTestProvider> GetProviders() { }
    }
    public abstract class UnitTestProviderSettingsUpgraderBase : JetBrains.Application.Configuration.IXmlReadable, JetBrains.Application.Configuration.Upgrade.ISettingsUpgrader, JetBrains.ProjectModel.Settings.Upgrade.ISolutionSettingsUpgrader
    {
        protected internal abstract string SectionName { get; }
        public JetBrains.Application.Settings.IContextBoundSettingsStore SettingsStore { get; }
        public void Upgrade(JetBrains.Application.Configuration.IComponentSettingsProvider legacySettingsProvider, JetBrains.Application.Settings.IContextBoundSettingsStore boundSettingsStore, JetBrains.DataFlow.Lifetime upgradeLifetime) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class UnitTestProvidersManager : JetBrains.ReSharper.UnitTestFramework.IUnitTestProvidersManager
    {
        public UnitTestProvidersManager(JetBrains.DataFlow.Lifetime lifetime, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.UnitTestFramework.IUnitTestProvider> providers, JetBrains.ReSharper.UnitTestFramework.UnitTestingAssemblyLoader loader, JetBrains.ReSharper.UnitTestFramework.IUnitTestingSettingsAccessor unitTestingSettingsAccessor, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.UnitTestFramework.IUnitTestElementSerializer> elementSerializers, JetBrains.Application.Settings.Extentions.ISettingsCache settingsCache, JetBrains.ReSharper.UnitTestFramework.UnitTestProvidersSettingsCachedReader unitTestProvidersSettingsCachedReader) { }
        public System.Collections.Generic.IList<JetBrains.ReSharper.UnitTestFramework.IUnitTestProvider> GetDisabledProviders() { }
        public JetBrains.ReSharper.UnitTestFramework.IUnitTestElementSerializer GetElementSerializer(string providerId) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.UnitTestFramework.IUnitTestProvider> GetEnabledProviders() { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class UnitTestProvidersSettingsCachedReader : JetBrains.Application.Settings.Extentions.ICachedSettingsReader<System.Collections.Generic.IEnumerable<JetBrains.ReSharper.UnitTestFramework.IUnitTestProvider>>
    {
        public UnitTestProvidersSettingsCachedReader(JetBrains.Application.Settings.ISettingsStore settingsStore, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.UnitTestFramework.IUnitTestProvider> providers, JetBrains.ReSharper.UnitTestFramework.IUnitTestingSettingsAccessor unitTestingSettingsAccessor) { }
        public JetBrains.Application.Settings.SettingsKey KeyExposed { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.UnitTestFramework.IUnitTestProvider> ReadData(JetBrains.Application.Settings.IContextBoundSettingsStore store) { }
    }
    public sealed class UnitTestResult
    {
        public UnitTestResult() { }
        public int ChildrenFailCount { get; set; }
        public JetBrains.ReSharper.UnitTestFramework.UnitTestStatus DerivedStatus { get; set; }
        public System.TimeSpan Duration { get; set; }
        public System.DateTimeOffset EndTime { get; set; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.TaskRunnerFramework.TaskException> Exceptions { get; }
        public string Message { get; set; }
        public bool Outdated { get; set; }
        public string Output { get; }
        public JetBrains.ReSharper.UnitTestFramework.UnitTestRunStatus RunStatus { get; set; }
        public System.DateTimeOffset StartTime { get; set; }
        public JetBrains.ReSharper.UnitTestFramework.UnitTestStatus Status { get; set; }
        public void AddExceptions(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.TaskRunnerFramework.TaskException> exceptions) { }
        public void AppendOutput(string output) { }
        public JetBrains.ReSharper.UnitTestFramework.UnitTestStatus GetEffectiveStatus() { }
        public void Merge(JetBrains.ReSharper.UnitTestFramework.UnitTestResult from) { }
        public void Reset() { }
        public override string ToString() { }
    }
    public class UnitTestResultEventArgs : System.EventArgs
    {
        public UnitTestResultEventArgs(JetBrains.ReSharper.UnitTestFramework.IUnitTestElement element, JetBrains.ReSharper.UnitTestFramework.UnitTestResult result) { }
        public JetBrains.ReSharper.UnitTestFramework.IUnitTestElement Element { get; }
        public JetBrains.ReSharper.UnitTestFramework.UnitTestResult Result { get; }
    }
    public enum UnitTestRunStatus
    {
        Completed = 0,
        Idle = 1,
        Pending = 2,
        Running = 3,
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class UnitTestServer
    {
        public UnitTestServer(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ReSharper.TaskRunnerFramework.IRemoteChannelMessageListener taskRunnerEventsListener) { }
        public int PortNumber { get; }
    }
    [JetBrains.Application.Settings.SettingsKeyAttribute(typeof(JetBrains.ReSharper.UnitTestFramework.UnitTestingMruSettings), "Default unit test session settings")]
    public class UnitTestSessionDefaultSettings
    {
        [JetBrains.Application.Settings.SettingsEntryAttribute(JetBrains.ReSharper.UnitTestFramework.BuildPolicy.Automatic, "Default solution build policy before running tests in all new sessions")]
        public JetBrains.ReSharper.UnitTestFramework.BuildPolicy BuildPolicy;
        [JetBrains.Application.Settings.SettingsEntryAttribute(3, "Index of tree grouping provider")]
        public int GroupingIndex;
        [JetBrains.Application.Settings.SettingsEntryAttribute(JetBrains.ReSharper.TaskRunnerFramework.PlatformType.Automatic, "PlatformType (x86/x64) to run tests")]
        public JetBrains.ReSharper.TaskRunnerFramework.PlatformType PlatformType;
        [JetBrains.Application.Settings.SettingsEntryAttribute(JetBrains.ReSharper.TaskRunnerFramework.PlatformVersion.Automatic, "RuntimeEnvironment (CLR2/4) to run tests")]
        public JetBrains.ReSharper.TaskRunnerFramework.PlatformVersion PlatformVersion;
        [JetBrains.Application.Settings.SettingsEntryAttribute(false, "Track active element in tree by default in all new sessions")]
        public bool TrackActiveElement;
    }
    [JetBrains.Application.Settings.SettingsIndexedKeyAttribute(typeof(JetBrains.ReSharper.UnitTestFramework.UnitTestingMruSettings), "Persistent sessions", typeof(JetBrains.Application.Settings.GuidIndex))]
    public class UnitTestSessionPersistentData
    {
        [JetBrains.Application.Settings.SettingsEntryAttribute(JetBrains.ReSharper.UnitTestFramework.BuildPolicy.Automatic, "Solution build policy before running tests")]
        public JetBrains.ReSharper.UnitTestFramework.BuildPolicy BuildPolicy;
        [JetBrains.Application.Settings.SettingsEntryAttribute(3, "Index of tree grouping provider")]
        public int GroupingIndex;
        [JetBrains.Application.Settings.SettingsEntryAttribute(false, "Is session locked?")]
        public bool Locked;
        [JetBrains.Application.Settings.SettingsEntryAttribute(null, "Session name")]
        public string Name;
        [JetBrains.Application.Settings.SettingsEntryAttribute(JetBrains.ReSharper.TaskRunnerFramework.PlatformType.Automatic, "PlatformType (x86/x64) to run tests")]
        public JetBrains.ReSharper.TaskRunnerFramework.PlatformType PlatformType;
        [JetBrains.Application.Settings.SettingsEntryAttribute(JetBrains.ReSharper.TaskRunnerFramework.PlatformVersion.Automatic, "RuntimeEnvironment (CLR2/4) to run tests")]
        public JetBrains.ReSharper.TaskRunnerFramework.PlatformVersion PlatformVersion;
        [JetBrains.Application.Settings.SettingsEntryAttribute(false, "Track active element in tree")]
        public bool TrackActiveElement;
        [JetBrains.Application.Settings.SettingsEntryAttribute(null, "Elements in session serialized in XML")]
        public string XmlSerializedElements;
    }
    public enum UnitTestSessionState
    {
        Idle = 0,
        Building = 1,
        Starting = 2,
        Running = 3,
        Stopping = 4,
        Aborting = 5,
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute(JetBrains.Application.Components.ProgramConfigurations.NONE | JetBrains.Application.Components.ProgramConfigurations.VS_ADDIN | JetBrains.Application.Components.ProgramConfigurations.ALL)]
    public class UnitTestSolutionBuilder : JetBrains.ReSharper.UnitTestFramework.IUnitTestSolutionBuilder
    {
        public UnitTestSolutionBuilder(JetBrains.Application.IShellLocks shellLocks, JetBrains.ReSharper.UnitTestFramework.UnitTestProjectsToRebuildWatcher projectsToRebuildWatcher, JetBrains.ReSharper.SolutionBuilder.SolutionBuilder builder) { }
        public void AbortBuild() { }
        public void BuildProjects(JetBrains.DataFlow.Lifetime lifetime, System.Collections.Generic.JetHashSet<JetBrains.ProjectModel.IProject> targetProjects, JetBrains.ReSharper.UnitTestFramework.BuildPolicy buildPolicy, System.Action<System.Collections.Generic.IEnumerable<JetBrains.ProjectModel.IProject>> successAction, System.Action<System.Collections.Generic.List<string>> funcFailed) { }
    }
    public enum UnitTestStatus
    {
        Unknown = 0,
        Success = 10,
        Inconclusive = 20,
        Ignored = 30,
        Failed = 40,
        Aborted = 50,
    }
    public class UnitTestTask
    {
        public UnitTestTask(JetBrains.ReSharper.UnitTestFramework.IUnitTestElement element, JetBrains.ReSharper.TaskRunnerFramework.RemoteTask remoteTask) { }
        public JetBrains.ReSharper.UnitTestFramework.IUnitTestElement Element { get; }
        public JetBrains.ReSharper.TaskRunnerFramework.RemoteTask RemoteTask { get; }
    }
    public class WellKnownHostProvidersIds
    {
        public const string DebugProviderId = "Debug";
        public const string RunProviderId = "Process";
    }
}
namespace JetBrains.ReSharper.UnitTestFramework.Elements
{
    
    public interface IUnitTestElementCache
    {
        void AddElement(JetBrains.ReSharper.UnitTestFramework.IUnitTestElement element);
        void Clear();
        void RemoveElement(JetBrains.ReSharper.UnitTestFramework.IUnitTestElement element);
    }
    public interface IUnitTestElementManager
    {
        bool HasUnitTestElements { get; }
        JetBrains.DataFlow.ISignal<System.Collections.Generic.IEnumerable<JetBrains.ReSharper.UnitTestFramework.IUnitTestElement>> UnitTestElementCreated { get; }
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.UnitTestFramework.IUnitTestElement> UnitTestElements { get; }
        JetBrains.DataFlow.ISignal<bool> UnitTestElementsChanged { get; }
        void AddElement(JetBrains.ReSharper.UnitTestFramework.IUnitTestElement element);
        void AddElements(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.UnitTestFramework.IUnitTestElement> elements);
        void Clear();
        JetBrains.ReSharper.UnitTestFramework.IUnitTestElement GetElementById(JetBrains.ProjectModel.IProject project, string id);
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.UnitTestFramework.IUnitTestElement> GetElementByIds(System.Collections.Generic.JetHashSet<string> ids);
        void RemoveElements(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.UnitTestFramework.IUnitTestElement> elements);
        void ReplaceElements(JetBrains.ProjectModel.IProject project, System.Collections.Generic.JetHashSet<JetBrains.ReSharper.UnitTestFramework.IUnitTestElement> elements);
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute(JetBrains.Application.Components.ProgramConfigurations.NONE | JetBrains.Application.Components.ProgramConfigurations.VS_ADDIN | JetBrains.Application.Components.ProgramConfigurations.ALL)]
    public class UnitTestElementByCategoryCache : JetBrains.ReSharper.Features.Shared.UnitTesting.IUnitTestingCategoriesProvider, JetBrains.ReSharper.UnitTestFramework.Elements.IUnitTestElementCache
    {
        public UnitTestElementByCategoryCache(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Features.Shared.UnitTesting.IUnitTestingCategoriesAttributeProvider> attributeProviders) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IClrTypeName> AttributeTypes { get; }
        public System.Collections.Generic.IEnumerable<string> Categories { get; }
        public JetBrains.UI.Icons.IconId Image { get; }
        public void AddElement(JetBrains.ReSharper.UnitTestFramework.IUnitTestElement element) { }
        public void Clear() { }
        public void RemoveElement(JetBrains.ReSharper.UnitTestFramework.IUnitTestElement element) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class UnitTestElementByProjectCache : JetBrains.ReSharper.UnitTestFramework.Elements.IUnitTestElementCache
    {
        public UnitTestElementByProjectCache() { }
        public bool HasElements { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.UnitTestFramework.IUnitTestElement> UnitTestElements { get; }
        public void AddElement(JetBrains.ReSharper.UnitTestFramework.IUnitTestElement element) { }
        public void Clear() { }
        public JetBrains.ReSharper.UnitTestFramework.IUnitTestElement GetElementById(JetBrains.ProjectModel.IProject project, string id) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.UnitTestFramework.IUnitTestElement> GetElementsById(string id) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.UnitTestFramework.IUnitTestElement> GetElementsFrom(JetBrains.ProjectModel.IProject project) { }
        public void RemoveElement(JetBrains.ReSharper.UnitTestFramework.IUnitTestElement element) { }
        public void RemoveProject(JetBrains.ProjectModel.IProject project) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class UnitTestElementManager : JetBrains.ReSharper.UnitTestFramework.Elements.IUnitTestElementManager
    {
        public UnitTestElementManager(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.IShellLocks shellLocks, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.UnitTestFramework.Elements.IUnitTestElementCache> caches, JetBrains.ReSharper.UnitTestFramework.Elements.UnitTestElementByProjectCache mainCache, JetBrains.ReSharper.UnitTestFramework.IUnitTestResultManager unitTestResultManager) { }
        public bool HasUnitTestElements { get; }
        public JetBrains.DataFlow.ISignal<System.Collections.Generic.IEnumerable<JetBrains.ReSharper.UnitTestFramework.IUnitTestElement>> UnitTestElementCreated { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.UnitTestFramework.IUnitTestElement> UnitTestElements { get; }
        public JetBrains.DataFlow.ISignal<bool> UnitTestElementsChanged { get; }
        public void AddElement(JetBrains.ReSharper.UnitTestFramework.IUnitTestElement element) { }
        public void AddElements(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.UnitTestFramework.IUnitTestElement> elements) { }
        public void Clear() { }
        public JetBrains.ReSharper.UnitTestFramework.IUnitTestElement GetElementById(JetBrains.ProjectModel.IProject project, string id) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.UnitTestFramework.IUnitTestElement> GetElementByIds(System.Collections.Generic.JetHashSet<string> ids) { }
        public void RemoveElements(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.UnitTestFramework.IUnitTestElement> elements) { }
        public void ReplaceElements(JetBrains.ProjectModel.IProject project, System.Collections.Generic.JetHashSet<JetBrains.ReSharper.UnitTestFramework.IUnitTestElement> elements) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class UnitTestElementProjectFileCache : JetBrains.ReSharper.UnitTestFramework.Elements.IUnitTestElementCache
    {
        public UnitTestElementProjectFileCache() { }
        public void AddElement(JetBrains.ReSharper.UnitTestFramework.IUnitTestElement element) { }
        public void Clear() { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.UnitTestFramework.IUnitTestElement> GetElementsIn(JetBrains.ProjectModel.IProjectFile projectFile) { }
        public bool HasElementsIn(JetBrains.ProjectModel.IProjectFile projectFile) { }
        public void RemoveElement(JetBrains.ReSharper.UnitTestFramework.IUnitTestElement element) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class UnitTestElementShortNameCache : JetBrains.ReSharper.UnitTestFramework.Elements.IUnitTestElementCache
    {
        public UnitTestElementShortNameCache() { }
        public void AddElement(JetBrains.ReSharper.UnitTestFramework.IUnitTestElement element) { }
        public bool CanElementExist(string name) { }
        public void Clear() { }
        public void RemoveElement(JetBrains.ReSharper.UnitTestFramework.IUnitTestElement element) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class UnitTestResultManager : JetBrains.ReSharper.UnitTestFramework.IUnitTestResultManager
    {
        public UnitTestResultManager(JetBrains.DataFlow.Lifetime lifetime) { }
        public JetBrains.DataFlow.ISignal<JetBrains.ReSharper.UnitTestFramework.IUnitTestElement> TestStarted { get; }
        public event System.EventHandler<JetBrains.ReSharper.UnitTestFramework.UnitTestResultEventArgs> UnitTestResultUpdated;
        public JetBrains.ReSharper.UnitTestFramework.UnitTestResult GetResult(JetBrains.ReSharper.UnitTestFramework.IUnitTestElement element) { }
        public System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<JetBrains.ReSharper.UnitTestFramework.IUnitTestElement, JetBrains.ReSharper.UnitTestFramework.UnitTestResult>> GetResults(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.UnitTestFramework.IUnitTestElement> elements) { }
        public void MarkOutdated(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.UnitTestFramework.IUnitTestElement> elements) { }
        public void TestDuration(JetBrains.ReSharper.UnitTestFramework.IUnitTestElement element, System.TimeSpan duration) { }
        public void TestException(JetBrains.ReSharper.UnitTestFramework.IUnitTestElement element, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.TaskRunnerFramework.TaskException> exceptions) { }
        public void TestFinishing(JetBrains.ReSharper.UnitTestFramework.IUnitTestElement element, string message, JetBrains.ReSharper.TaskRunnerFramework.TaskResult result) { }
        public void TestOutput(JetBrains.ReSharper.UnitTestFramework.IUnitTestElement element, string text, JetBrains.ReSharper.TaskRunnerFramework.TaskOutputType type) { }
        public void TestStarting(JetBrains.ReSharper.UnitTestFramework.IUnitTestElement element) { }
    }
}
namespace JetBrains.ReSharper.UnitTestFramework.EventBus
{
    
    public class TestRunFinishedEventArgs
    {
        public TestRunFinishedEventArgs(JetBrains.ReSharper.UnitTestFramework.IUnitTestSession session) { }
        public JetBrains.ReSharper.UnitTestFramework.IUnitTestSession Session { get; }
    }
    public class UnitTestActivityTrackingEvents
    {
        public static readonly JetBrains.Util.EventBus.EventId<JetBrains.ReSharper.UnitTestFramework.EventBus.TestRunFinishedEventArgs> TestRunFinishedEvent;
    }
}
namespace JetBrains.ReSharper.UnitTestFramework.Highlighting
{
    
    public class static UnitTestBulbMenuAnchors
    {
        public static readonly JetBrains.UI.BulbMenu.IAnchor AppendSessionAnchor;
        public static readonly JetBrains.UI.BulbMenu.IAnchorPosition AppendSessionPosition;
        public static readonly JetBrains.UI.BulbMenu.IAnchor CategoryAnchor;
        public static readonly JetBrains.UI.BulbMenu.IAnchorPosition CategoryPosition;
        public static readonly JetBrains.UI.BulbMenu.IAnchor CreateSessionAnchor;
        public static readonly JetBrains.UI.BulbMenu.IAnchorPosition CreateSessionPosition;
        public static readonly JetBrains.UI.BulbMenu.IAnchor RunTestsAnchor;
        public static readonly JetBrains.UI.BulbMenu.IAnchorPosition RunTestsPosition;
        public static readonly JetBrains.UI.BulbMenu.IAnchor SubelementsAnchor;
        public static readonly JetBrains.UI.BulbMenu.IAnchorPosition SubelementsPosition;
    }
    [JetBrains.ReSharper.Daemon.DaemonStageAttribute(StagesBefore=new System.Type[] {
            typeof(JetBrains.ReSharper.Daemon.LanguageSpecificDaemonStage)})]
    public class UnitTestDaemonStage : JetBrains.ReSharper.Daemon.IDaemonStage
    {
        public UnitTestDaemonStage(JetBrains.ReSharper.UnitTestFramework.UnitTestFileExplorer unitTestFileExplorer, JetBrains.ReSharper.UnitTestFramework.Elements.IUnitTestElementManager unitTestElementManager, JetBrains.ReSharper.UnitTestFramework.UI.IUnitTestExplorerWindowService unitTestExplorerToolWindowService, JetBrains.ReSharper.UnitTestFramework.IUnitTestingSettingsAccessor unitTestingSettingsAccessor, JetBrains.Application.IShellLocks shellLocks) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Daemon.IDaemonStageProcess> CreateProcess(JetBrains.ReSharper.Daemon.IDaemonProcess process, JetBrains.Application.Settings.IContextBoundSettingsStore settings, JetBrains.ReSharper.Daemon.DaemonProcessKind processKind) { }
        public JetBrains.ReSharper.Daemon.ErrorStripeRequest NeedsErrorStripe(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, JetBrains.Application.Settings.IContextBoundSettingsStore settings) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class UnitTestPsiIconManagerExtension : JetBrains.ReSharper.Psi.IPsiIconManagerExtension
    {
        public UnitTestPsiIconManagerExtension(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ReSharper.UnitTestFramework.UnitTestManager unitTestManager, JetBrains.ReSharper.UnitTestFramework.IUnitTestResultManager resultManager, JetBrains.ReSharper.Psi.PsiIconManager psiIconManager) { }
        public JetBrains.UI.Icons.IconId GetImageId(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, JetBrains.ReSharper.Psi.PsiLanguageType languageType, out bool canApplyExtensions) { }
    }
}
namespace JetBrains.ReSharper.UnitTestFramework.Resources
{
    
    public sealed class UnitTestingThemedIcons
    {
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.UnitTestFramework;component/resources/UnitTestingThemedIcons/" +
            "ThemedIcons.UnitTesting.Generated.Xaml", 5, "AppendSession")]
        public sealed class AppendSession : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.UnitTestFramework;component/resources/UnitTestingThemedIcons/" +
            "ThemedIcons.UnitTesting.Generated.Xaml", 34, "BuildPolicy")]
        public sealed class BuildPolicy : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.UnitTestFramework;component/resources/UnitTestingThemedIcons/" +
            "ThemedIcons.UnitTesting.Generated.Xaml", 23, "Category")]
        public sealed class Category : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.UnitTestFramework;component/resources/UnitTestingThemedIcons/" +
            "ThemedIcons.UnitTesting.Generated.Xaml", 29, "Debug")]
        public sealed class Debug : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.UnitTestFramework;component/resources/UnitTestingThemedIcons/" +
            "ThemedIcons.UnitTesting.Generated.Xaml", 26, "DeleteTest")]
        public sealed class DeleteTest : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.UnitTestFramework;component/resources/UnitTestingThemedIcons/" +
            "ThemedIcons.UnitTesting.Generated.Xaml", 35, "Kill")]
        public sealed class Kill : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.UnitTestFramework;component/resources/UnitTestingThemedIcons/" +
            "ThemedIcons.UnitTesting.Generated.Xaml", 24, "LockSession")]
        public sealed class LockSession : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.UnitTestFramework;component/resources/UnitTestingThemedIcons/" +
            "ThemedIcons.UnitTesting.Generated.Xaml", 33, "Mstest")]
        public sealed class Mstest : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.UnitTestFramework;component/resources/UnitTestingThemedIcons/" +
            "ThemedIcons.UnitTesting.Generated.Xaml", 22, "NewSession")]
        public sealed class NewSession : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.UnitTestFramework;component/resources/UnitTestingThemedIcons/" +
            "ThemedIcons.UnitTesting.Generated.Xaml", 36, "Outdated")]
        public sealed class Outdated : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.UnitTestFramework;component/resources/UnitTestingThemedIcons/" +
            "ThemedIcons.UnitTesting.Generated.Xaml", 17, "Rerun")]
        public sealed class Rerun : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.UnitTestFramework;component/resources/UnitTestingThemedIcons/" +
            "ThemedIcons.UnitTesting.Generated.Xaml", 18, "RunAll")]
        public sealed class RunAll : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.UnitTestFramework;component/resources/UnitTestingThemedIcons/" +
            "ThemedIcons.UnitTesting.Generated.Xaml", 12, "RunningError")]
        public sealed class RunningError : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.UnitTestFramework;component/resources/UnitTestingThemedIcons/" +
            "ThemedIcons.UnitTesting.Generated.Xaml", 32, "RunningTest")]
        public sealed class RunningTest : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.UnitTestFramework;component/resources/UnitTestingThemedIcons/" +
            "ThemedIcons.UnitTesting.Generated.Xaml", 11, "RunTest")]
        public sealed class RunTest : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.UnitTestFramework;component/resources/UnitTestingThemedIcons/" +
            "ThemedIcons.UnitTesting.Generated.Xaml", 7, "Session")]
        public sealed class Session : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.UnitTestFramework;component/resources/UnitTestingThemedIcons/" +
            "ThemedIcons.UnitTesting.Generated.Xaml", 16, "StatusAborted")]
        public sealed class StatusAborted : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.UnitTestFramework;component/resources/UnitTestingThemedIcons/" +
            "ThemedIcons.UnitTesting.Generated.Xaml", 20, "StatusAll")]
        public sealed class StatusAll : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.UnitTestFramework;component/resources/UnitTestingThemedIcons/" +
            "ThemedIcons.UnitTesting.Generated.Xaml", 0, "StatusFailed")]
        public sealed class StatusFailed : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.UnitTestFramework;component/resources/UnitTestingThemedIcons/" +
            "ThemedIcons.UnitTesting.Generated.Xaml", 2, "StatusFailedPassive")]
        public sealed class StatusFailedPassive : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.UnitTestFramework;component/resources/UnitTestingThemedIcons/" +
            "ThemedIcons.UnitTesting.Generated.Xaml", 4, "StatusIgnored")]
        public sealed class StatusIgnored : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.UnitTestFramework;component/resources/UnitTestingThemedIcons/" +
            "ThemedIcons.UnitTesting.Generated.Xaml", 8, "StatusInconclusive")]
        public sealed class StatusInconclusive : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.UnitTestFramework;component/resources/UnitTestingThemedIcons/" +
            "ThemedIcons.UnitTesting.Generated.Xaml", 31, "StatusSuccess")]
        public sealed class StatusSuccess : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.UnitTestFramework;component/resources/UnitTestingThemedIcons/" +
            "ThemedIcons.UnitTesting.Generated.Xaml", 28, "StatusSuccessPassive")]
        public sealed class StatusSuccessPassive : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.UnitTestFramework;component/resources/UnitTestingThemedIcons/" +
            "ThemedIcons.UnitTesting.Generated.Xaml", 1, "StatusUnknown")]
        public sealed class StatusUnknown : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.UnitTestFramework;component/resources/UnitTestingThemedIcons/" +
            "ThemedIcons.UnitTesting.Generated.Xaml", 21, "StopTest")]
        public sealed class StopTest : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.UnitTestFramework;component/resources/UnitTestingThemedIcons/" +
            "ThemedIcons.UnitTesting.Generated.Xaml", 27, "TestFixture")]
        public sealed class TestFixture : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.UnitTestFramework;component/resources/UnitTestingThemedIcons/" +
            "ThemedIcons.UnitTesting.Generated.Xaml", 6, "TestFixtureAborted")]
        public sealed class TestFixtureAborted : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.UnitTestFramework;component/resources/UnitTestingThemedIcons/" +
            "ThemedIcons.UnitTesting.Generated.Xaml", 3, "TestFixtureFail")]
        public sealed class TestFixtureFail : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.UnitTestFramework;component/resources/UnitTestingThemedIcons/" +
            "ThemedIcons.UnitTesting.Generated.Xaml", 25, "TestFixtureIgnored")]
        public sealed class TestFixtureIgnored : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.UnitTestFramework;component/resources/UnitTestingThemedIcons/" +
            "ThemedIcons.UnitTesting.Generated.Xaml", 30, "TestFixtureSuccess")]
        public sealed class TestFixtureSuccess : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.UnitTestFramework;component/resources/UnitTestingThemedIcons/" +
            "ThemedIcons.UnitTesting.Generated.Xaml", 19, "TestMethod")]
        public sealed class TestMethod : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.UnitTestFramework;component/resources/UnitTestingThemedIcons/" +
            "ThemedIcons.UnitTesting.Generated.Xaml", 38, "TestMethodAborted")]
        public sealed class TestMethodAborted : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.UnitTestFramework;component/resources/UnitTestingThemedIcons/" +
            "ThemedIcons.UnitTesting.Generated.Xaml", 10, "TestMethodFail")]
        public sealed class TestMethodFail : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.UnitTestFramework;component/resources/UnitTestingThemedIcons/" +
            "ThemedIcons.UnitTesting.Generated.Xaml", 15, "TestMethodIgnored")]
        public sealed class TestMethodIgnored : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.UnitTestFramework;component/resources/UnitTestingThemedIcons/" +
            "ThemedIcons.UnitTesting.Generated.Xaml", 37, "TestMethodSuccess")]
        public sealed class TestMethodSuccess : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.UnitTestFramework;component/resources/UnitTestingThemedIcons/" +
            "ThemedIcons.UnitTesting.Generated.Xaml", 13, "TestPending")]
        public sealed class TestPending : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.UnitTestFramework;component/resources/UnitTestingThemedIcons/" +
            "ThemedIcons.UnitTesting.Generated.Xaml", 14, "Time")]
        public sealed class Time : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.UnitTestFramework;component/resources/UnitTestingThemedIcons/" +
            "ThemedIcons.UnitTesting.Generated.Xaml", 9, "TrackRun")]
        public sealed class TrackRun : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
    }
}
namespace JetBrains.ReSharper.UnitTestFramework.Strategy
{
    
    public class DoNothingRunStrategy : JetBrains.ReSharper.UnitTestFramework.Strategy.IUnitTestRunStrategy
    {
        public void Abort(JetBrains.ReSharper.UnitTestFramework.ITaskRunnerHostController runController, JetBrains.ReSharper.UnitTestFramework.IUnitTestRun run) { }
        public void Cancel(JetBrains.ReSharper.UnitTestFramework.ITaskRunnerHostController runController, JetBrains.ReSharper.UnitTestFramework.IUnitTestRun run) { }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
        public JetBrains.ReSharper.TaskRunnerFramework.RuntimeEnvironment GetRuntimeEnvironment(JetBrains.ReSharper.UnitTestFramework.IUnitTestElement element, JetBrains.ReSharper.TaskRunnerFramework.RuntimeEnvironment projectRuntimeEnvironment, JetBrains.ReSharper.UnitTestFramework.IUnitTestLaunch launch) { }
        public bool NeedProjectBuild(JetBrains.ProjectModel.IProject project) { }
        public void Run(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ReSharper.UnitTestFramework.ITaskRunnerHostController runController, JetBrains.ReSharper.UnitTestFramework.IUnitTestRun run, JetBrains.ReSharper.UnitTestFramework.IUnitTestLaunch launch, System.Action continuation) { }
    }
    public interface IPerProjectRunStrategy : JetBrains.ReSharper.UnitTestFramework.Strategy.IUnitTestRunStrategy { }
    public interface IUnitTestRunStrategy
    {
        void Abort(JetBrains.ReSharper.UnitTestFramework.ITaskRunnerHostController runController, JetBrains.ReSharper.UnitTestFramework.IUnitTestRun run);
        void Cancel(JetBrains.ReSharper.UnitTestFramework.ITaskRunnerHostController runController, JetBrains.ReSharper.UnitTestFramework.IUnitTestRun run);
        JetBrains.ReSharper.TaskRunnerFramework.RuntimeEnvironment GetRuntimeEnvironment(JetBrains.ReSharper.UnitTestFramework.IUnitTestElement element, JetBrains.ReSharper.TaskRunnerFramework.RuntimeEnvironment projectRuntimeEnvironment, JetBrains.ReSharper.UnitTestFramework.IUnitTestLaunch launch);
        bool NeedProjectBuild([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IProject project);
        void Run(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ReSharper.UnitTestFramework.ITaskRunnerHostController runController, JetBrains.ReSharper.UnitTestFramework.IUnitTestRun run, JetBrains.ReSharper.UnitTestFramework.IUnitTestLaunch launch, System.Action continuation);
    }
    public class OutOfProcessUnitTestRunStrategy : JetBrains.ReSharper.UnitTestFramework.Strategy.IUnitTestRunStrategy
    {
        public OutOfProcessUnitTestRunStrategy(JetBrains.ReSharper.TaskRunnerFramework.RemoteTaskRunnerInfo info) { }
        public JetBrains.ReSharper.TaskRunnerFramework.RemoteTaskRunnerInfo Info { get; }
        public void Abort(JetBrains.ReSharper.UnitTestFramework.ITaskRunnerHostController runController, JetBrains.ReSharper.UnitTestFramework.IUnitTestRun run) { }
        public void Cancel(JetBrains.ReSharper.UnitTestFramework.ITaskRunnerHostController runController, JetBrains.ReSharper.UnitTestFramework.IUnitTestRun run) { }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
        public JetBrains.ReSharper.TaskRunnerFramework.RuntimeEnvironment GetRuntimeEnvironment(JetBrains.ReSharper.UnitTestFramework.IUnitTestElement element, JetBrains.ReSharper.TaskRunnerFramework.RuntimeEnvironment projectRuntimeEnvironment, JetBrains.ReSharper.UnitTestFramework.IUnitTestLaunch launch) { }
        public virtual bool NeedProjectBuild(JetBrains.ProjectModel.IProject project) { }
        public void Run(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ReSharper.UnitTestFramework.ITaskRunnerHostController runController, JetBrains.ReSharper.UnitTestFramework.IUnitTestRun run, JetBrains.ReSharper.UnitTestFramework.IUnitTestLaunch launch, System.Action continuation) { }
    }
}
namespace JetBrains.ReSharper.UnitTestFramework.UI
{
    
    public interface IUnitTestExplorerWindowService
    {
        void OpenInExplorer(System.Collections.Generic.IList<JetBrains.ReSharper.UnitTestFramework.IUnitTestElement> elements);
        void RequestUpdateStructure();
    }
    public enum UnitTestElementImage
    {
        TestContainer = 0,
        Test = 1,
        TestCategory = 2,
        Running = 3,
        RunningError = 4,
        Building = 5,
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class UnitTestExplorerWindowServiceImpl : JetBrains.ReSharper.UnitTestFramework.UI.IUnitTestExplorerWindowService
    {
        public virtual void OpenInExplorer(System.Collections.Generic.IList<JetBrains.ReSharper.UnitTestFramework.IUnitTestElement> elements) { }
        public virtual void RequestUpdateStructure() { }
    }
    public class static UnitTestProviderOptionsPage
    {
        public static JetBrains.UI.CommonControls.CheckBoxDisabledNoCheck CreateEnableProviderCheckBox(JetBrains.DataFlow.Lifetime lifetime, JetBrains.UI.Options.OptionsSettingsSmartContext context, JetBrains.ReSharper.UnitTestFramework.IUnitTestProvider provider) { }
        public static JetBrains.UI.Controls.CheckBoxDisabledNoCheck2 CreateEnableProviderCheckBoxAvalon(JetBrains.DataFlow.Lifetime lifetime, JetBrains.UI.Options.OptionsSettingsSmartContext context, JetBrains.ReSharper.UnitTestFramework.IUnitTestProvider provider) { }
    }
}