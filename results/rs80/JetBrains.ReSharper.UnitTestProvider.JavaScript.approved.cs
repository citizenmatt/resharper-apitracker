[assembly: JetBrains.Application.Install.InstallFileAttribute("phantomjstestrunner", JetBrains.Application.Install.InstallationData.InstallationTargetDirRoot.InstallDir, "", JetBrains.Application.Install.InstallationData.InstallationSourceDirRoot2.ReferencesDirectories, "PhantomJSTestRunner.js")]
[assembly: JetBrains.UI.Icons.CompiledIcons.CompiledIconsPackAttribute(IconNames=new string[] {
        "Qunit",
        "Jsunit",
        "Jasmine"}, IconPackResourceIdentification="JetBrains.ReSharper.UnitTestProvider.JavaScript;component/resources/UnitTestingJa" +
    "vaScriptIcons/ThemedIcons.UnitTestingJavaScript.Generated.Xaml")]
[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]
[assembly: System.Windows.Markup.XmlnsDefinitionAttribute("urn:shemas-jetbrains-com:ui-application-icons-unit-testing-java-script", "JetBrains.ReSharper.UnitTestProvider.JavaScript.Resources")]

namespace JetBrains.ReSharper.UnitTestProvider.JavaScript.Browsers
{
    
    public class DefaultWebBrowserInfo : JetBrains.ReSharper.UnitTestProvider.JavaScript.Browsers.IWebBrowserInfo
    {
        public static readonly JetBrains.ReSharper.UnitTestProvider.JavaScript.Browsers.DefaultWebBrowserInfo Instance;
        public System.Drawing.Icon Icon { get; }
        public JetBrains.Util.FileSystemPath Location { get; }
        public string Name { get; }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class InstalledBrowsersLocator
    {
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.UnitTestProvider.JavaScript.Browsers.IWebBrowserInfo> InstalledBrowsers { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.UnitTestProvider.JavaScript.Browsers.IWebBrowserInfo> InstalledBrowsersWithDefaultEntry { get; }
        public JetBrains.ReSharper.UnitTestProvider.JavaScript.Browsers.IWebBrowserInfo GetBrowserInfo(string browserLocation) { }
    }
    public interface IWebBrowserInfo
    {
        System.Drawing.Icon Icon { get; }
        JetBrains.Util.FileSystemPath Location { get; }
        string Name { get; }
    }
    public class WebBrowserInfo : JetBrains.ReSharper.UnitTestProvider.JavaScript.Browsers.IWebBrowserInfo
    {
        public WebBrowserInfo(string name, System.Drawing.Icon icon, JetBrains.Util.FileSystemPath location) { }
        public System.Drawing.Icon Icon { get; }
        public object ImageSource { get; }
        public JetBrains.Util.FileSystemPath Location { get; }
        public string Name { get; }
        public bool Equals(JetBrains.ReSharper.UnitTestProvider.JavaScript.Browsers.WebBrowserInfo other) { }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
    }
}
namespace JetBrains.ReSharper.UnitTestProvider.JavaScript.Jasmine
{
    
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class JasmineElementFactory
    {
        public JasmineElementFactory(JetBrains.ReSharper.UnitTestProvider.JavaScript.Jasmine.JasmineServiceProvider provider, JetBrains.ReSharper.UnitTestFramework.Elements.IUnitTestElementManager unitTestElementManager) { }
        public JetBrains.ReSharper.UnitTestProvider.JavaScript.Jasmine.JasmineSpecificationElement GetOrCreateSpecification(string specificationName, JetBrains.ProjectModel.IProject project, JetBrains.ProjectModel.ProjectModelElementEnvoy projectFileEnvoy, string filename, JetBrains.Util.TextRange textRange, System.Collections.Generic.IList<string> referencedFiles, JetBrains.ReSharper.UnitTestFramework.IUnitTestElement suite) { }
        public JetBrains.ReSharper.UnitTestProvider.JavaScript.Jasmine.JasmineSuiteElement GetOrCreateSuite(JetBrains.ProjectModel.IProject project, JetBrains.ProjectModel.ProjectModelElementEnvoy projectFileEnvoy, string suiteName, JetBrains.ReSharper.UnitTestProvider.JavaScript.Jasmine.JasmineSuiteElement parentSuite, JetBrains.Util.TextRange textRange, System.Collections.Generic.IList<string> referencedFiles) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class JasmineElementSerializer : JetBrains.ReSharper.UnitTestFramework.IUnitTestElementSerializer
    {
        public JasmineElementSerializer(JetBrains.ReSharper.UnitTestProvider.JavaScript.Jasmine.JasmineTestProvider provider, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.UnitTestProvider.JavaScript.Jasmine.JasmineElementFactory factory) { }
        public JetBrains.ReSharper.UnitTestFramework.IUnitTestProvider Provider { get; }
        public JetBrains.ReSharper.UnitTestFramework.IUnitTestElement DeserializeElement(System.Xml.XmlElement parent, JetBrains.ReSharper.UnitTestFramework.IUnitTestElement parentElement) { }
        public void SerializeElement(System.Xml.XmlElement parent, JetBrains.ReSharper.UnitTestFramework.IUnitTestElement element) { }
    }
    public class JasmineFileExplorer : JetBrains.ReSharper.Psi.IRecursiveElementProcessor
    {
        public JasmineFileExplorer(JetBrains.ReSharper.UnitTestProvider.JavaScript.Jasmine.JasmineElementFactory factory, JetBrains.ReSharper.UnitTestFramework.UnitTestElementLocationConsumer consumer, JetBrains.ReSharper.Psi.Tree.IFile file, JetBrains.Application.CheckForInterrupt interrupted, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IPsiSourceFile> referencedFiles) { }
        public bool ProcessingIsFinished { get; }
        public bool InteriorShouldBeProcessed(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public void ProcessAfterInterior(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public void ProcessBeforeInterior(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class JasmineServiceProvider
    {
        public JasmineServiceProvider(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.UnitTestProvider.JavaScript.Jasmine.JasmineTestProvider provider, JetBrains.Application.Settings.ISettingsStore settingsStore, JetBrains.Application.Env.Components.ProductSettingsLocation productSettingsLocation) { }
        public JetBrains.ReSharper.UnitTestProvider.JavaScript.Jasmine.JasmineTestProvider Provider { get; }
        public JetBrains.ReSharper.UnitTestFramework.UnitTestTask CreateTestSetTask(JetBrains.ProjectModel.IProjectFile projectFile, JetBrains.ProjectModel.IProject project, string[] referencedFiles) { }
        public JetBrains.ReSharper.UnitTestFramework.Strategy.IUnitTestRunStrategy GetRunStrategy() { }
    }
    public class JasmineSpecificationElement : JetBrains.ReSharper.UnitTestProvider.JavaScript.JavaScriptTestElementBase, System.IEquatable<JetBrains.ReSharper.UnitTestProvider.JavaScript.Jasmine.JasmineSpecificationElement>
    {
        public JasmineSpecificationElement(JetBrains.ReSharper.UnitTestProvider.JavaScript.Jasmine.JasmineServiceProvider provider, string specificationName, JetBrains.ProjectModel.ProjectModelElementEnvoy projectFileEnvoy, JetBrains.Util.TextRange textRange, System.Collections.Generic.IList<string> referencedFiles) { }
        public override string Id { get; }
        public override string Kind { get; }
        public override JetBrains.ReSharper.UnitTestFramework.IUnitTestProvider Provider { get; }
        public override string ShortName { get; }
        public bool Equals(JetBrains.ReSharper.UnitTestProvider.JavaScript.Jasmine.JasmineSpecificationElement other) { }
        public override bool Equals(JetBrains.ReSharper.UnitTestFramework.IUnitTestElement obj) { }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
        public override JetBrains.ReSharper.UnitTestFramework.Strategy.IUnitTestRunStrategy GetRunStrategy(JetBrains.ReSharper.UnitTestFramework.IHostProvider hostProvider) { }
        public override System.Collections.Generic.IList<JetBrains.ReSharper.UnitTestFramework.UnitTestTask> GetTaskSequence(System.Collections.Generic.ICollection<JetBrains.ReSharper.UnitTestFramework.IUnitTestElement> explicitElements, JetBrains.ReSharper.UnitTestFramework.IUnitTestLaunch launch) { }
        public static JetBrains.ReSharper.UnitTestFramework.IUnitTestElement ReadFromXml(System.Xml.XmlElement parent, JetBrains.ReSharper.UnitTestFramework.IUnitTestElement parentElement, JetBrains.ReSharper.UnitTestProvider.JavaScript.Jasmine.JasmineElementFactory factory, JetBrains.ProjectModel.ISolution solution) { }
        public void SetReferencedFiles(System.Collections.Generic.IList<string> files) { }
        public void WriteToXml(System.Xml.XmlElement parent) { }
    }
    public class JasmineSuiteElement : JetBrains.ReSharper.UnitTestProvider.JavaScript.JavaScriptTestElementBase, System.IEquatable<JetBrains.ReSharper.UnitTestProvider.JavaScript.Jasmine.JasmineSuiteElement>
    {
        public JasmineSuiteElement(JetBrains.ReSharper.UnitTestProvider.JavaScript.Jasmine.JasmineServiceProvider provider, string suiteName, JetBrains.ReSharper.UnitTestProvider.JavaScript.Jasmine.JasmineSuiteElement parentSuite, JetBrains.ProjectModel.ProjectModelElementEnvoy projectFileEnvoy, JetBrains.Util.TextRange textRange, System.Collections.Generic.IList<string> referencedFiles) { }
        public override string Id { get; }
        public override string Kind { get; }
        public override JetBrains.ReSharper.UnitTestFramework.IUnitTestProvider Provider { get; }
        public override string ShortName { get; }
        public bool Equals(JetBrains.ReSharper.UnitTestProvider.JavaScript.Jasmine.JasmineSuiteElement other) { }
        public override bool Equals(JetBrains.ReSharper.UnitTestFramework.IUnitTestElement obj) { }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
        public override JetBrains.ReSharper.UnitTestFramework.Strategy.IUnitTestRunStrategy GetRunStrategy(JetBrains.ReSharper.UnitTestFramework.IHostProvider hostProvider) { }
        public override System.Collections.Generic.IList<JetBrains.ReSharper.UnitTestFramework.UnitTestTask> GetTaskSequence(System.Collections.Generic.ICollection<JetBrains.ReSharper.UnitTestFramework.IUnitTestElement> explicitElements, JetBrains.ReSharper.UnitTestFramework.IUnitTestLaunch launch) { }
        public static JetBrains.ReSharper.UnitTestFramework.IUnitTestElement ReadFromXml(System.Xml.XmlElement parent, JetBrains.ReSharper.UnitTestFramework.IUnitTestElement parentElement, JetBrains.ReSharper.UnitTestProvider.JavaScript.Jasmine.JasmineElementFactory factory, JetBrains.ProjectModel.ISolution solution) { }
        public void SetReferencedFiles(System.Collections.Generic.IList<string> files) { }
        public void WriteToXml(System.Xml.XmlElement parent) { }
    }
    [JetBrains.ReSharper.UnitTestFramework.FileUnitTestExplorerAttribute()]
    public class JasmineTestFileExplorer : JetBrains.ReSharper.UnitTestFramework.IUnitTestFileExplorer
    {
        public JasmineTestFileExplorer(JetBrains.ReSharper.UnitTestProvider.JavaScript.Jasmine.JasmineTestProvider provider, JetBrains.ReSharper.UnitTestProvider.JavaScript.Jasmine.JasmineElementFactory factory, JetBrains.ReSharper.Psi.JavaScript.Services.IJavaScriptDependencyManager javaScriptDependencyManager) { }
        public JetBrains.ReSharper.UnitTestFramework.IUnitTestProvider Provider { get; }
        public void ExploreFile(JetBrains.ReSharper.Psi.Tree.IFile psiFile, JetBrains.ReSharper.UnitTestFramework.UnitTestElementLocationConsumer consumer, JetBrains.Application.CheckForInterrupt interrupted) { }
    }
    [JetBrains.ReSharper.UnitTestFramework.UnitTestProviderAttribute()]
    public class JasmineTestProvider : JetBrains.ReSharper.UnitTestFramework.IUnitTestProvider
    {
        public JasmineTestProvider() { }
        public string ID { get; }
        public string Name { get; }
        public int CompareUnitTestElements(JetBrains.ReSharper.UnitTestFramework.IUnitTestElement x, JetBrains.ReSharper.UnitTestFramework.IUnitTestElement y) { }
        public void ExploreExternal(JetBrains.ReSharper.UnitTestFramework.UnitTestElementConsumer consumer) { }
        public void ExploreSolution(JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.UnitTestFramework.UnitTestElementConsumer consumer) { }
        public bool IsElementOfKind(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, JetBrains.ReSharper.UnitTestFramework.UnitTestElementKind elementKind) { }
        public bool IsElementOfKind(JetBrains.ReSharper.UnitTestFramework.IUnitTestElement element, JetBrains.ReSharper.UnitTestFramework.UnitTestElementKind elementKind) { }
        public bool IsSupported(JetBrains.ReSharper.UnitTestFramework.IHostProvider hostProvider) { }
    }
}
namespace JetBrains.ReSharper.UnitTestProvider.JavaScript
{
    
    public class JavaScriptOutOfProcessUnitTestRunStrategy : JetBrains.ReSharper.UnitTestFramework.Strategy.OutOfProcessUnitTestRunStrategy
    {
        public JavaScriptOutOfProcessUnitTestRunStrategy(JetBrains.ReSharper.TaskRunnerFramework.RemoteTaskRunnerInfo info) { }
        public override bool NeedProjectBuild(JetBrains.ProjectModel.IProject project) { }
    }
    [JetBrains.ReSharper.Psi.PsiComponentAttribute()]
    public class JavaScriptTestCache : JetBrains.ReSharper.Psi.Caches.ICache, JetBrains.ReSharper.Psi.Caches.ISwitchingCache
    {
        public JavaScriptTestCache(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.UnitTestFramework.IUnitTestingSettingsAccessor settingsAccessor, JetBrains.ReSharper.UnitTestProvider.JavaScript.QUnit.QUnitTestProvider qunitProvider, JetBrains.ReSharper.UnitTestProvider.JavaScript.QUnit.QUnitElementFactory factory, JetBrains.Application.IShellLocks shellLocks, JetBrains.ReSharper.Psi.IPsiConfiguration psiConfiguration, JetBrains.Application.Settings.ISettingsStore settingsStore, JetBrains.ReSharper.UnitTestProvider.JavaScript.Jasmine.JasmineTestProvider jasmineProvider, JetBrains.ReSharper.UnitTestProvider.JavaScript.Jasmine.JasmineElementFactory jasmineFactory, JetBrains.ReSharper.Psi.Caches.IPersistentIndexManager persistentIndexManager, JetBrains.ReSharper.Psi.JavaScript.Services.IJavaScriptDependencyManager javaScriptDependencyManager) { }
        public JetBrains.DataFlow.IProperty<bool> Active { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.UnitTestFramework.IUnitTestElement> UnitTestElements { get; }
        public void Initialize() { }
        public void MarkAsDirty(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
        public void ReanalyzeDirtyFiles() { }
        public void Release() { }
    }
    public abstract class JavaScriptTestElementBase : JetBrains.ReSharper.UnitTestFramework.IUnitTestElement, System.IEquatable<JetBrains.ReSharper.UnitTestFramework.IUnitTestElement>
    {
        protected readonly JetBrains.ProjectModel.ProjectModelElementEnvoy myProjectFileEnvoy;
        protected JavaScriptTestElementBase(JetBrains.ProjectModel.ProjectModelElementEnvoy projectFileEnvoy, JetBrains.Util.TextRange textRange) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.UnitTestFramework.UnitTestElementCategory> Categories { get; }
        public System.Collections.Generic.ICollection<JetBrains.ReSharper.UnitTestFramework.IUnitTestElement> Children { get; }
        public bool Explicit { get; }
        public string ExplicitReason { get; }
        public abstract string Id { get; }
        public abstract string Kind { get; }
        public JetBrains.ReSharper.UnitTestFramework.IUnitTestElement Parent { get; set; }
        public abstract JetBrains.ReSharper.UnitTestFramework.IUnitTestProvider Provider { get; }
        public abstract string ShortName { get; }
        public JetBrains.ReSharper.UnitTestFramework.UnitTestElementState State { get; set; }
        public JetBrains.Util.TextRange TextRange { get; set; }
        public abstract bool Equals(JetBrains.ReSharper.UnitTestFramework.IUnitTestElement other);
        public JetBrains.ReSharper.Psi.IDeclaredElement GetDeclaredElement() { }
        public JetBrains.ReSharper.UnitTestFramework.UnitTestElementDisposition GetDisposition() { }
        public JetBrains.ReSharper.UnitTestFramework.UnitTestNamespace GetNamespace() { }
        public virtual string GetPresentation(JetBrains.ReSharper.UnitTestFramework.IUnitTestElement element) { }
        public JetBrains.ProjectModel.IProject GetProject() { }
        protected JetBrains.ProjectModel.IProjectFile GetProjectFile() { }
        public System.Collections.Generic.IEnumerable<JetBrains.ProjectModel.IProjectFile> GetProjectFiles() { }
        public abstract JetBrains.ReSharper.UnitTestFramework.Strategy.IUnitTestRunStrategy GetRunStrategy(JetBrains.ReSharper.UnitTestFramework.IHostProvider hostProvider);
        public abstract System.Collections.Generic.IList<JetBrains.ReSharper.UnitTestFramework.UnitTestTask> GetTaskSequence(System.Collections.Generic.ICollection<JetBrains.ReSharper.UnitTestFramework.IUnitTestElement> explicitElements, JetBrains.ReSharper.UnitTestFramework.IUnitTestLaunch launch);
    }
    public enum JavaScriptTestEngine
    {
        Browser = 0,
        PhantomJS = 1,
    }
    public class static JavaScriptTestRunnerHelper
    {
        public static string GetBrowserLocation(JetBrains.Application.Settings.IContextBoundSettingsStore settings) { }
        public static string GetPhantomJsLocation(JetBrains.Application.Settings.IContextBoundSettingsStore settings, JetBrains.Application.Env.Components.ProductSettingsLocation productSettingsLocation) { }
    }
    [JetBrains.Application.Settings.SettingsKeyAttribute(typeof(JetBrains.ReSharper.UnitTestFramework.UnitTestingSettings), "Common settings for all JavaScript unit test providers")]
    public class JavaScriptUnitTestProvidersSettings
    {
        [JetBrains.Application.Settings.SettingsEntryAttribute(null, "Path to web browser to run tests in")]
        public string BrowserLocation;
        [JetBrains.Application.Settings.SettingsEntryAttribute(JetBrains.ReSharper.UnitTestProvider.JavaScript.JavaScriptTestEngine.Browser, "Where to run JavaScript tests")]
        public JetBrains.ReSharper.UnitTestProvider.JavaScript.JavaScriptTestEngine JavaScriptTestEngine;
        [JetBrains.Application.Settings.SettingsEntryAttribute(null, "Path to PhantomJS")]
        public string PhantomJSLocation;
    }
}
namespace JetBrains.ReSharper.UnitTestProvider.JavaScript.Options
{
    
    public class EnumBooleanConverter : System.Windows.Data.IValueConverter
    {
        public object Convert(object value, System.Type targetType, object parameter, System.Globalization.CultureInfo culture) { }
        public object ConvertBack(object value, System.Type targetType, object parameter, System.Globalization.CultureInfo culture) { }
    }
    [JetBrains.UI.Options.OptionsPageAttribute("JavaScript Tests", "JavaScript Tests", typeof(JetBrains.ReSharper.UnitTestProvider.JavaScript.Resources.UnitTestingJavaScriptThemedIcons.Qunit), HelpKeyword="Reference__Options__Tools__Unit_Testing__QUnit", ParentId="UnitTesting", Sequence=3D)]
    public class JavaScriptTestsPage : JetBrains.UI.Options.Helpers.AOptionsPage
    {
        public const string PID = "JavaScript Tests";
        public JavaScriptTestsPage(JetBrains.DataFlow.Lifetime lifetime, JetBrains.UI.Application.IUIApplication environment, JetBrains.UI.Options.OptionsSettingsSmartContext smartContext, JetBrains.ReSharper.UnitTestProvider.JavaScript.Browsers.InstalledBrowsersLocator browserLocator, JetBrains.ReSharper.UnitTestProvider.JavaScript.QUnit.QUnitTestProvider provider = null, JetBrains.ReSharper.UnitTestProvider.JavaScript.Jasmine.JasmineTestProvider jasmineProvider = null) { }
        public override bool OnOk() { }
    }
    public class JavascriptTestsPageView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector
    {
        public JavascriptTestsPageView(JetBrains.ReSharper.UnitTestProvider.JavaScript.Browsers.InstalledBrowsersLocator browsersLocator, string phantomjsPath) { }
        public JetBrains.ReSharper.UnitTestProvider.JavaScript.JavaScriptTestEngine Engine { get; set; }
        public JetBrains.ReSharper.UnitTestProvider.JavaScript.Browsers.IWebBrowserInfo SelectedBrowser { get; set; }
        public void InitializeComponent() { }
    }
}
namespace JetBrains.ReSharper.UnitTestProvider.JavaScript.QUnit
{
    
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class QUnitElementFactory
    {
        public QUnitElementFactory(JetBrains.ReSharper.UnitTestProvider.JavaScript.QUnit.QUnitServiceProvider provider, JetBrains.ReSharper.UnitTestFramework.Elements.IUnitTestElementManager unitTestElementManager) { }
        public JetBrains.ReSharper.UnitTestProvider.JavaScript.QUnit.QUnitModuleElement GetOrCreateModule(JetBrains.ProjectModel.IProject project, JetBrains.ProjectModel.ProjectModelElementEnvoy projectFileEnvoy, string moduleName, string filename, JetBrains.Util.TextRange textRange, System.Collections.Generic.IList<string> referencedFiles) { }
        public JetBrains.ReSharper.UnitTestProvider.JavaScript.QUnit.QUnitTestElement GetOrCreateTest(string testName, JetBrains.ProjectModel.IProject project, JetBrains.ProjectModel.ProjectModelElementEnvoy projectFileEnvoy, string filename, JetBrains.Util.TextRange textRange, System.Collections.Generic.IList<string> referencedFiles, JetBrains.ReSharper.UnitTestFramework.IUnitTestElement module) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class QUnitElementSerializer : JetBrains.ReSharper.UnitTestFramework.IUnitTestElementSerializer
    {
        public QUnitElementSerializer(JetBrains.ReSharper.UnitTestProvider.JavaScript.QUnit.QUnitTestProvider provider, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.UnitTestProvider.JavaScript.QUnit.QUnitElementFactory factory) { }
        public JetBrains.ReSharper.UnitTestFramework.IUnitTestProvider Provider { get; }
        public JetBrains.ReSharper.UnitTestFramework.IUnitTestElement DeserializeElement(System.Xml.XmlElement parent, JetBrains.ReSharper.UnitTestFramework.IUnitTestElement parentElement) { }
        public void SerializeElement(System.Xml.XmlElement parent, JetBrains.ReSharper.UnitTestFramework.IUnitTestElement element) { }
    }
    public class QUnitFileExplorer : JetBrains.ReSharper.Psi.IRecursiveElementProcessor
    {
        public QUnitFileExplorer(JetBrains.ReSharper.UnitTestProvider.JavaScript.QUnit.QUnitElementFactory factory, JetBrains.ReSharper.UnitTestFramework.UnitTestElementLocationConsumer consumer, JetBrains.ReSharper.Psi.Tree.IFile file, JetBrains.Application.CheckForInterrupt interrupted, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IPsiSourceFile> referencedFiles) { }
        public bool ProcessingIsFinished { get; }
        public void FinishCurrentModule(int endOffset) { }
        public bool InteriorShouldBeProcessed(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public void ProcessAfterInterior(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public void ProcessBeforeInterior(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
    }
    public class QUnitModuleElement : JetBrains.ReSharper.UnitTestProvider.JavaScript.JavaScriptTestElementBase, System.IEquatable<JetBrains.ReSharper.UnitTestProvider.JavaScript.QUnit.QUnitModuleElement>
    {
        public QUnitModuleElement(JetBrains.ReSharper.UnitTestProvider.JavaScript.QUnit.QUnitServiceProvider provider, JetBrains.ProjectModel.ProjectModelElementEnvoy projectFileEnvoy, string moduleName, JetBrains.Util.TextRange textRange, System.Collections.Generic.IList<string> referencedFiles) { }
        public override string Id { get; }
        public override string Kind { get; }
        public override JetBrains.ReSharper.UnitTestFramework.IUnitTestProvider Provider { get; }
        public override string ShortName { get; }
        public override bool Equals(JetBrains.ReSharper.UnitTestFramework.IUnitTestElement other) { }
        public bool Equals(JetBrains.ReSharper.UnitTestProvider.JavaScript.QUnit.QUnitModuleElement other) { }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
        public override JetBrains.ReSharper.UnitTestFramework.Strategy.IUnitTestRunStrategy GetRunStrategy(JetBrains.ReSharper.UnitTestFramework.IHostProvider hostProvider) { }
        public override System.Collections.Generic.IList<JetBrains.ReSharper.UnitTestFramework.UnitTestTask> GetTaskSequence(System.Collections.Generic.ICollection<JetBrains.ReSharper.UnitTestFramework.IUnitTestElement> explicitElements, JetBrains.ReSharper.UnitTestFramework.IUnitTestLaunch launch) { }
        public static JetBrains.ReSharper.UnitTestFramework.IUnitTestElement ReadFromXml(System.Xml.XmlElement parent, JetBrains.ReSharper.UnitTestFramework.IUnitTestElement parentElement, JetBrains.ReSharper.UnitTestProvider.JavaScript.QUnit.QUnitElementFactory factory, JetBrains.ProjectModel.ISolution solution) { }
        public void SetReferencedFiles(System.Collections.Generic.IList<string> files) { }
        public void WriteToXml(System.Xml.XmlElement parent) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class QUnitServiceProvider
    {
        public QUnitServiceProvider(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.UnitTestProvider.JavaScript.QUnit.QUnitTestProvider provider, JetBrains.Application.Settings.ISettingsStore settingsStore, JetBrains.Application.Env.Components.ProductSettingsLocation productSettingsLocation) { }
        public JetBrains.ReSharper.UnitTestProvider.JavaScript.QUnit.QUnitTestProvider Provider { get; }
        public JetBrains.ReSharper.UnitTestFramework.UnitTestTask CreateTestSetTask(JetBrains.ProjectModel.IProjectFile projectFile, JetBrains.ProjectModel.IProject project, string[] referencedFiles) { }
        public JetBrains.ReSharper.UnitTestFramework.Strategy.IUnitTestRunStrategy GetRunStrategy() { }
    }
    public class QUnitTestElement : JetBrains.ReSharper.UnitTestProvider.JavaScript.JavaScriptTestElementBase, System.IEquatable<JetBrains.ReSharper.UnitTestProvider.JavaScript.QUnit.QUnitTestElement>
    {
        public QUnitTestElement(JetBrains.ReSharper.UnitTestProvider.JavaScript.QUnit.QUnitServiceProvider provider, string testName, JetBrains.ProjectModel.ProjectModelElementEnvoy projectFileEnvoy, JetBrains.Util.TextRange textRange, System.Collections.Generic.IList<string> referencedFiles) { }
        public override string Id { get; }
        public override string Kind { get; }
        public override JetBrains.ReSharper.UnitTestFramework.IUnitTestProvider Provider { get; }
        public override string ShortName { get; }
        public override bool Equals(JetBrains.ReSharper.UnitTestFramework.IUnitTestElement other) { }
        public bool Equals(JetBrains.ReSharper.UnitTestProvider.JavaScript.QUnit.QUnitTestElement other) { }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
        public override JetBrains.ReSharper.UnitTestFramework.Strategy.IUnitTestRunStrategy GetRunStrategy(JetBrains.ReSharper.UnitTestFramework.IHostProvider hostProvider) { }
        public override System.Collections.Generic.IList<JetBrains.ReSharper.UnitTestFramework.UnitTestTask> GetTaskSequence(System.Collections.Generic.ICollection<JetBrains.ReSharper.UnitTestFramework.IUnitTestElement> explicitElements, JetBrains.ReSharper.UnitTestFramework.IUnitTestLaunch launch) { }
        public static JetBrains.ReSharper.UnitTestFramework.IUnitTestElement ReadFromXml(System.Xml.XmlElement parent, JetBrains.ReSharper.UnitTestFramework.IUnitTestElement parentElement, JetBrains.ReSharper.UnitTestProvider.JavaScript.QUnit.QUnitElementFactory factory, JetBrains.ProjectModel.ISolution solution) { }
        public void SetReferencedFiles(System.Collections.Generic.IList<string> files) { }
        public void WriteToXml(System.Xml.XmlElement parent) { }
    }
    [JetBrains.ReSharper.UnitTestFramework.FileUnitTestExplorerAttribute()]
    public class QUnitTestFileExplorer : JetBrains.ReSharper.UnitTestFramework.IUnitTestFileExplorer
    {
        public QUnitTestFileExplorer(JetBrains.ReSharper.UnitTestProvider.JavaScript.QUnit.QUnitTestProvider provider, JetBrains.ReSharper.UnitTestProvider.JavaScript.QUnit.QUnitElementFactory factory, JetBrains.ReSharper.Psi.JavaScript.Services.IJavaScriptDependencyManager javaScriptDependencyManager) { }
        public JetBrains.ReSharper.UnitTestFramework.IUnitTestProvider Provider { get; }
        public void ExploreFile(JetBrains.ReSharper.Psi.Tree.IFile psiFile, JetBrains.ReSharper.UnitTestFramework.UnitTestElementLocationConsumer consumer, JetBrains.Application.CheckForInterrupt interrupted) { }
    }
    [JetBrains.ReSharper.UnitTestFramework.UnitTestProviderAttribute()]
    public class QUnitTestProvider : JetBrains.ReSharper.UnitTestFramework.IUnitTestProvider
    {
        public QUnitTestProvider() { }
        public string ID { get; }
        public string Name { get; }
        public int CompareUnitTestElements(JetBrains.ReSharper.UnitTestFramework.IUnitTestElement x, JetBrains.ReSharper.UnitTestFramework.IUnitTestElement y) { }
        public void ExploreExternal(JetBrains.ReSharper.UnitTestFramework.UnitTestElementConsumer consumer) { }
        public void ExploreSolution(JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.UnitTestFramework.UnitTestElementConsumer consumer) { }
        public bool IsElementOfKind(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, JetBrains.ReSharper.UnitTestFramework.UnitTestElementKind elementKind) { }
        public bool IsElementOfKind(JetBrains.ReSharper.UnitTestFramework.IUnitTestElement element, JetBrains.ReSharper.UnitTestFramework.UnitTestElementKind elementKind) { }
        public bool IsSupported(JetBrains.ReSharper.UnitTestFramework.IHostProvider hostProvider) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute(JetBrains.Application.Components.ProgramConfigurations.NONE | JetBrains.Application.Components.ProgramConfigurations.VS_ADDIN | JetBrains.Application.Components.ProgramConfigurations.ALL)]
    public class QUnitTestProviderSettingsUpgrader : JetBrains.ReSharper.UnitTestFramework.UnitTestProviderSettingsUpgraderBase
    {
        [JetBrains.Application.Configuration.XmlExternalizableAttribute(null)]
        public string BrowserLocation { get; set; }
        protected override string SectionName { get; }
    }
}
namespace JetBrains.ReSharper.UnitTestProvider.JavaScript.Resources
{
    
    public sealed class UnitTestingJavaScriptThemedIcons
    {
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.UnitTestProvider.JavaScript;component/resources/UnitTestingJa" +
            "vaScriptIcons/ThemedIcons.UnitTestingJavaScript.Generated.Xaml", 2, "Jasmine")]
        public sealed class Jasmine : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.UnitTestProvider.JavaScript;component/resources/UnitTestingJa" +
            "vaScriptIcons/ThemedIcons.UnitTestingJavaScript.Generated.Xaml", 1, "Jsunit")]
        public sealed class Jsunit : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.UnitTestProvider.JavaScript;component/resources/UnitTestingJa" +
            "vaScriptIcons/ThemedIcons.UnitTestingJavaScript.Generated.Xaml", 0, "Qunit")]
        public sealed class Qunit : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
    }
}