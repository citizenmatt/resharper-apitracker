[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]

namespace JetBrains.ReSharper.UnitTestProvider.MSTest
{
    
    public interface IMsTestAttributesProvider : JetBrains.ReSharper.Features.Shared.UnitTesting.IUnitTestingCategoriesAttributeProvider
    {
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IClrTypeName> IgnoreAttributes { get; }
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IClrTypeName> TestClassAttributes { get; }
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IClrTypeName> TestMethodAttributes { get; }
        bool IsTestClass(JetBrains.ReSharper.Psi.ITypeElement typeElement);
        bool IsTestMethod(JetBrains.ReSharper.Psi.ITypeMember typeMember);
    }
    public interface IMsTestElementFactory
    {
        JetBrains.ReSharper.UnitTestProvider.MSTest.MsTestTestClassElementBase GetOrCreateClassElement(JetBrains.ReSharper.Psi.IClrTypeName id, JetBrains.ProjectModel.IProject project, JetBrains.ProjectModel.ProjectModelElementEnvoy envoy);
        JetBrains.ReSharper.UnitTestProvider.MSTest.MsTestTestMethodElementBase GetOrCreateMethodElement(string id, JetBrains.ProjectModel.IProject project, JetBrains.ReSharper.UnitTestProvider.MSTest.MsTestTestClassElementBase parent, JetBrains.ProjectModel.ProjectModelElementEnvoy envoy, JetBrains.ReSharper.Psi.IClrTypeName typeName);
        JetBrains.ReSharper.UnitTestProvider.MSTest.MsTestTestRowElementBase GetOrCreateRowElement(string id, JetBrains.ProjectModel.IProject project, JetBrains.ReSharper.UnitTestProvider.MSTest.MsTestTestMethodElementBase parent, JetBrains.ProjectModel.ProjectModelElementEnvoy envoy);
    }
    public interface IMsTestServices
    {
        JetBrains.ReSharper.UnitTestFramework.IUnitTestProvider Provider { get; }
        int VsVersionMajor { get; }
        string GetRunConfigurationFilename(JetBrains.ReSharper.UnitTestFramework.IUnitTestLaunch launch);
        JetBrains.ReSharper.UnitTestFramework.Strategy.IUnitTestRunStrategy GetRunStrategy(JetBrains.ReSharper.UnitTestFramework.IHostProvider hostProvider, JetBrains.ReSharper.UnitTestFramework.IUnitTestElement element);
    }
    public abstract class MsTestAttributesProviderBase : JetBrains.ReSharper.Features.Shared.UnitTesting.IUnitTestingCategoriesAttributeProvider, JetBrains.ReSharper.UnitTestProvider.MSTest.IMsTestAttributesProvider
    {
        public abstract System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IClrTypeName> CategoryAttributes { get; }
        public abstract System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IClrTypeName> IgnoreAttributes { get; }
        public abstract System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IClrTypeName> TestClassAttributes { get; }
        public abstract System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IClrTypeName> TestMethodAttributes { get; }
        public bool IsTestClass(JetBrains.ReSharper.Psi.ITypeElement typeElement) { }
        public bool IsTestMethod(JetBrains.ReSharper.Psi.ITypeMember typeMember) { }
    }
    public abstract class MsTestElementBase : JetBrains.ReSharper.UnitTestFramework.IUnitTestElement, System.IEquatable<JetBrains.ReSharper.UnitTestFramework.IUnitTestElement>
    {
        protected readonly JetBrains.ReSharper.UnitTestProvider.MSTest.IMsTestServices ourServices;
        protected MsTestElementBase(JetBrains.ReSharper.UnitTestProvider.MSTest.IMsTestServices services, JetBrains.ProjectModel.ProjectModelElementEnvoy project, JetBrains.ReSharper.Psi.IClrTypeName typeName) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.UnitTestFramework.UnitTestElementCategory> Categories { get; set; }
        public System.Collections.Generic.ICollection<JetBrains.ReSharper.UnitTestFramework.IUnitTestElement> Children { get; }
        public bool Explicit { get; }
        public string ExplicitReason { get; set; }
        public abstract string Id { get; }
        public abstract string Kind { get; }
        public JetBrains.ReSharper.UnitTestFramework.IUnitTestElement Parent { get; set; }
        public JetBrains.ReSharper.UnitTestFramework.IUnitTestProvider Provider { get; }
        public abstract string ShortName { get; }
        public JetBrains.ReSharper.UnitTestFramework.UnitTestElementState State { get; set; }
        public JetBrains.ReSharper.Psi.IClrTypeName TypeName { get; }
        public abstract bool Equals(JetBrains.ReSharper.UnitTestFramework.IUnitTestElement other);
        public abstract JetBrains.ReSharper.Psi.IDeclaredElement GetDeclaredElement();
        public abstract JetBrains.ReSharper.UnitTestFramework.UnitTestElementDisposition GetDisposition();
        public JetBrains.ReSharper.UnitTestFramework.UnitTestNamespace GetNamespace() { }
        public abstract string GetPresentation(JetBrains.ReSharper.UnitTestFramework.IUnitTestElement parent = null);
        public JetBrains.ProjectModel.IProject GetProject() { }
        public abstract System.Collections.Generic.IEnumerable<JetBrains.ProjectModel.IProjectFile> GetProjectFiles();
        public JetBrains.ReSharper.UnitTestFramework.Strategy.IUnitTestRunStrategy GetRunStrategy(JetBrains.ReSharper.UnitTestFramework.IHostProvider hostProvider) { }
        public abstract System.Collections.Generic.IList<JetBrains.ReSharper.UnitTestFramework.UnitTestTask> GetTaskSequence(System.Collections.Generic.ICollection<JetBrains.ReSharper.UnitTestFramework.IUnitTestElement> explicitElements, JetBrains.ReSharper.UnitTestFramework.IUnitTestLaunch launch);
        public override string ToString() { }
    }
    public class MsTestFileExplorer : JetBrains.ReSharper.Psi.IRecursiveElementProcessor
    {
        public MsTestFileExplorer(JetBrains.ReSharper.UnitTestProvider.MSTest.IMsTestElementFactory factory, JetBrains.ReSharper.UnitTestProvider.MSTest.IMsTestAttributesProvider provider, JetBrains.ReSharper.UnitTestFramework.UnitTestElementLocationConsumer consumer, JetBrains.ReSharper.Psi.Tree.IFile file, JetBrains.Application.CheckForInterrupt interrupted) { }
        public bool ProcessingIsFinished { get; }
        public bool InteriorShouldBeProcessed(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public void ProcessAfterInterior(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public void ProcessBeforeInterior(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
    }
    public class MsTestMetadataExplorer
    {
        public MsTestMetadataExplorer(JetBrains.ReSharper.UnitTestProvider.MSTest.IMsTestElementFactory factory, JetBrains.ReSharper.UnitTestProvider.MSTest.IMsTestAttributesProvider provider, JetBrains.ProjectModel.IProject project, JetBrains.Application.IShellLocks shellLocks, JetBrains.ReSharper.UnitTestFramework.UnitTestElementConsumer consumer) { }
        public void ExploreAssembly(JetBrains.Metadata.Reader.API.IMetadataAssembly assembly) { }
    }
    [JetBrains.UI.Options.OptionsPageAttribute("MSTest", "MsTest", typeof(JetBrains.ReSharper.UnitTestFramework.Resources.UnitTestingThemedIcons.Mstest), HelpKeyword="Reference__Options__Tools__Unit_Testing__MSTest", ParentId="UnitTesting", Sequence=2D)]
    public class MsTestPage : JetBrains.UI.Options.Helpers.AStackPanelOptionsPage3
    {
        public MsTestPage(JetBrains.DataFlow.Lifetime lifetime, JetBrains.UI.Application.IUIApplication environment, JetBrains.UI.Options.OptionsSettingsSmartContext smartContext, JetBrains.ReSharper.UnitTestProvider.MSTest.MsTestProviderBase provider, JetBrains.ProjectModel.ISolution solution = null, JetBrains.ReSharper.UnitTestProvider.MSTest.IMsTestServices services = null) { }
    }
    [JetBrains.ReSharper.UnitTestFramework.UnitTestPresenterAttribute()]
    public class MsTestPresenter : JetBrains.ReSharper.UnitTestFramework.IUnitTestPresenter
    {
        public MsTestPresenter() { }
        public void Present(JetBrains.ReSharper.UnitTestFramework.IUnitTestElement element, JetBrains.CommonControls.IPresentableItem item, JetBrains.TreeModels.TreeModelNode node, JetBrains.UI.TreeView.PresentationState state) { }
    }
    public abstract class MsTestProviderBase : JetBrains.ReSharper.UnitTestFramework.IUnitTestProvider
    {
        protected MsTestProviderBase(JetBrains.Application.Settings.ISettingsStore settingsStore, JetBrains.ReSharper.UnitTestProvider.MSTest.IMsTestAttributesProvider attributesProvider) { }
        public string ID { get; }
        public string Name { get; }
        protected JetBrains.Application.Settings.ISettingsStore SettingsStore { get; }
        public abstract int CompareUnitTestElements(JetBrains.ReSharper.UnitTestFramework.IUnitTestElement x, JetBrains.ReSharper.UnitTestFramework.IUnitTestElement y);
        public void ExploreExternal(JetBrains.ReSharper.UnitTestFramework.UnitTestElementConsumer consumer) { }
        public void ExploreSolution(JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.UnitTestFramework.UnitTestElementConsumer consumer) { }
        public static System.Collections.Generic.IEnumerable<JetBrains.ReSharper.UnitTestProvider.MSTest.MsTestRunConfigurationInfo> GetAvailableRunConfigurations(JetBrains.ProjectModel.ISolution solution) { }
        public string GetMetadataFilename(JetBrains.ProjectModel.ISolution solution) { }
        public static string GetRunConfigurationFilename(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Settings.IContextBoundSettingsStore boundSettingsStore) { }
        public static JetBrains.Util.FileSystemPath GetRunConfigurationFilePath(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Settings.IContextBoundSettingsStore boundSettingsStore) { }
        public bool IsElementOfKind(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, JetBrains.ReSharper.UnitTestFramework.UnitTestElementKind elementKind) { }
        public bool IsElementOfKind(JetBrains.ReSharper.UnitTestFramework.IUnitTestElement element, JetBrains.ReSharper.UnitTestFramework.UnitTestElementKind elementKind) { }
        public bool IsSupported(JetBrains.ReSharper.UnitTestFramework.IHostProvider hostProvider) { }
    }
    [JetBrains.Application.Settings.SettingsKeyAttribute(typeof(JetBrains.ReSharper.UnitTestFramework.UnitTestingSettings), "Settings for MSTest unit test provider")]
    public class MsTestProviderSettings
    {
        [JetBrains.Application.Settings.SettingsEntryAttribute(null, "Path to .runconfig/.testsettings file")]
        public string RunConfigurationFilename;
        [JetBrains.Application.Settings.SettingsEntryAttribute(false, "Force MSTest runner to run tests even if not all features are supported")]
        public bool RunTestsEvenIfCodeCoverageEnabled;
        [JetBrains.Application.Settings.SettingsEntryAttribute(false, "Force MSTest runner to run tests with mstest.exe")]
        public bool RunTestsWithMsTestExe;
        [JetBrains.Application.Settings.SettingsEntryAttribute(true, "Use .runconfig/.testsettings selected in VS UI/.vsmdi file")]
        public bool UseTestRunConfigFromMetadataFile;
    }
    [JetBrains.ProjectModel.Settings.Upgrade.SolutionSettingsUpgraderAttribute()]
    public class MsTestProviderSettingsUpgrader : JetBrains.ReSharper.UnitTestFramework.UnitTestProviderSettingsUpgraderBase
    {
        [JetBrains.Application.Configuration.XmlExternalizableAttribute(null, SettingName="RunConfigurationFilename")]
        public string RunConfigurationFilename { get; set; }
        [JetBrains.Application.Configuration.XmlExternalizableAttribute(false, SettingName="RunTestsEvenIfCodeCoverageEnabled")]
        public bool RunTestsEvenIfCodeCoverageEnabled { get; set; }
        protected override string SectionName { get; }
        [JetBrains.Application.Configuration.XmlExternalizableAttribute(true, SettingName="UseTestRunConfigFromMetadataFile")]
        public bool UseTestRunConfigFromMetadataFile { get; set; }
    }
    public class MsTestRunConfigurationInfo
    {
        public MsTestRunConfigurationInfo() { }
        public MsTestRunConfigurationInfo(string path) { }
        public MsTestRunConfigurationInfo(JetBrains.Util.FileSystemPath path) { }
        public bool CodeCoverageEnabled { get; }
        public string Filename { get; }
        public bool IsMsilHost { get; }
        public JetBrains.Util.FileSystemPath Path { get; }
        public static void Edit(JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.UnitTestProvider.MSTest.MsTestRunConfigurationInfo info) { }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
        public override string ToString() { }
    }
    public abstract class MsTestTestClassElementBase : JetBrains.ReSharper.UnitTestProvider.MSTest.MsTestElementBase
    {
        protected MsTestTestClassElementBase(JetBrains.ReSharper.UnitTestProvider.MSTest.IMsTestServices services, JetBrains.ProjectModel.ProjectModelElementEnvoy project, JetBrains.ReSharper.Psi.IClrTypeName typeName) { }
    }
    public abstract class MsTestTestMethodElementBase : JetBrains.ReSharper.UnitTestProvider.MSTest.MsTestElementBase
    {
        protected MsTestTestMethodElementBase(JetBrains.ReSharper.UnitTestProvider.MSTest.IMsTestServices services, JetBrains.ProjectModel.ProjectModelElementEnvoy project, JetBrains.ReSharper.Psi.IClrTypeName typeName, JetBrains.ReSharper.UnitTestProvider.MSTest.MsTestTestClassElementBase testClass, string methodName) { }
        public string MethodName { get; }
        public JetBrains.ReSharper.UnitTestProvider.MSTest.MsTestTestClassElementBase TestClass { get; }
    }
    public abstract class MsTestTestRowElementBase : JetBrains.ReSharper.UnitTestProvider.MSTest.MsTestElementBase
    {
        protected MsTestTestRowElementBase(JetBrains.ReSharper.UnitTestProvider.MSTest.IMsTestServices services, JetBrains.ProjectModel.ProjectModelElementEnvoy project, JetBrains.ReSharper.Psi.IClrTypeName typeName) { }
    }
    public class MsTestTestSettingsFileInfo
    {
        public MsTestTestSettingsFileInfo(string filename) { }
        protected virtual string MachineName { get; }
        protected virtual string UserName { get; }
        public string GetDeploymentDirectoryName(string outputDirectory, System.DateTime now) { }
    }
    public class MsTestTreePresenter : JetBrains.ReSharper.Features.Shared.TreePsiBrowser.TreeModelBrowserPresenter
    {
        public MsTestTreePresenter() { }
        protected override bool IsNaturalParent(object parentValue, object childValue) { }
        protected override object Unwrap(object value) { }
    }
}