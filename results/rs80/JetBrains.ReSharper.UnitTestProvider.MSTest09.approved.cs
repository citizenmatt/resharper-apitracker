[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]

namespace JetBrains.ReSharper.UnitTestProvider.MSTest09
{
    
    [JetBrains.Application.ShellComponentAttribute()]
    public class MsTestAttributesProvider : JetBrains.ReSharper.UnitTestProvider.MSTest.MsTestAttributesProviderBase
    {
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IClrTypeName> CategoryAttributes { get; }
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IClrTypeName> IgnoreAttributes { get; }
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IClrTypeName> TestClassAttributes { get; }
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IClrTypeName> TestMethodAttributes { get; }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class MsTestElementFactory : JetBrains.ReSharper.UnitTestProvider.MSTest.IMsTestElementFactory
    {
        public MsTestElementFactory(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ReSharper.UnitTestProvider.MSTest.IMsTestServices services, JetBrains.ReSharper.UnitTestFramework.Elements.IUnitTestElementManager unitTestElementManager, JetBrains.Application.Settings.ISettingsStore settingsStore, JetBrains.ProjectModel.ISolution solution) { }
        public JetBrains.ReSharper.UnitTestProvider.MSTest.MsTestTestClassElementBase GetOrCreateClassElement(JetBrains.ReSharper.Psi.IClrTypeName id, JetBrains.ProjectModel.IProject project, JetBrains.ProjectModel.ProjectModelElementEnvoy envoy) { }
        public JetBrains.ReSharper.UnitTestProvider.MSTest.MsTestTestMethodElementBase GetOrCreateMethodElement(string id, JetBrains.ProjectModel.IProject project, JetBrains.ReSharper.UnitTestProvider.MSTest.MsTestTestClassElementBase parent, JetBrains.ProjectModel.ProjectModelElementEnvoy envoy, JetBrains.ReSharper.Psi.IClrTypeName typeName) { }
        public JetBrains.ReSharper.UnitTestProvider.MSTest.MsTestTestRowElementBase GetOrCreateRowElement(string id, JetBrains.ProjectModel.IProject project, JetBrains.ReSharper.UnitTestProvider.MSTest.MsTestTestMethodElementBase parent, JetBrains.ProjectModel.ProjectModelElementEnvoy envoy) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class MsTestElementSerializer : JetBrains.ReSharper.UnitTestFramework.IUnitTestElementSerializer
    {
        public MsTestElementSerializer(JetBrains.ReSharper.UnitTestProvider.MSTest09.MsTestProvider provider, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.UnitTestProvider.MSTest09.MsTestElementFactory factory) { }
        public JetBrains.ReSharper.UnitTestFramework.IUnitTestProvider Provider { get; }
        public JetBrains.ReSharper.UnitTestFramework.IUnitTestElement DeserializeElement(System.Xml.XmlElement parent, JetBrains.ReSharper.UnitTestFramework.IUnitTestElement parentElement) { }
        public void SerializeElement(System.Xml.XmlElement parent, JetBrains.ReSharper.UnitTestFramework.IUnitTestElement element) { }
    }
    [JetBrains.ReSharper.UnitTestFramework.UnitTestProviderAttribute()]
    public class MsTestProvider : JetBrains.ReSharper.UnitTestProvider.MSTest.MsTestProviderBase
    {
        public MsTestProvider(JetBrains.Application.Settings.ISettingsStore settingsStore, JetBrains.ReSharper.UnitTestProvider.MSTest.IMsTestAttributesProvider attributesProvider) { }
        public override int CompareUnitTestElements(JetBrains.ReSharper.UnitTestFramework.IUnitTestElement x, JetBrains.ReSharper.UnitTestFramework.IUnitTestElement y) { }
        public static string GetVisualStudioDirectory() { }
        public bool RunWithMsTestExe(JetBrains.ProjectModel.ISolution solution) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class MsTestServices : JetBrains.ReSharper.UnitTestProvider.MSTest.IMsTestServices
    {
        public MsTestServices(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Settings.ISettingsStore store, JetBrains.ReSharper.UnitTestProvider.MSTest09.MsTestProvider provider) { }
        public JetBrains.ReSharper.UnitTestFramework.IUnitTestProvider Provider { get; }
        public int VsVersionMajor { get; }
        public string GetRunConfigurationFilename(JetBrains.ReSharper.UnitTestFramework.IUnitTestLaunch launch) { }
        public JetBrains.ReSharper.UnitTestFramework.Strategy.IUnitTestRunStrategy GetRunStrategy(JetBrains.ReSharper.UnitTestFramework.IHostProvider hostProvider, JetBrains.ReSharper.UnitTestFramework.IUnitTestElement element) { }
    }
    public class MsTestTestClassElement : JetBrains.ReSharper.UnitTestProvider.MSTest.MsTestTestClassElementBase, System.IEquatable<JetBrains.ReSharper.UnitTestProvider.MSTest09.MsTestTestClassElement>
    {
        public MsTestTestClassElement(JetBrains.ReSharper.UnitTestProvider.MSTest.IMsTestServices services, JetBrains.ProjectModel.ProjectModelElementEnvoy project, JetBrains.ReSharper.Psi.IClrTypeName typeName, string assemblyLocation, JetBrains.Application.Settings.IContextBoundSettingsStore boundSettingsStore) { }
        public override string Id { get; }
        public override string Kind { get; }
        public override string ShortName { get; }
        public override bool Equals(JetBrains.ReSharper.UnitTestFramework.IUnitTestElement other) { }
        public bool Equals(JetBrains.ReSharper.UnitTestProvider.MSTest09.MsTestTestClassElement other) { }
        public override bool Equals(object obj) { }
        public override JetBrains.ReSharper.Psi.IDeclaredElement GetDeclaredElement() { }
        public override JetBrains.ReSharper.UnitTestFramework.UnitTestElementDisposition GetDisposition() { }
        public override int GetHashCode() { }
        public override string GetPresentation(JetBrains.ReSharper.UnitTestFramework.IUnitTestElement parent = null) { }
        public override System.Collections.Generic.IEnumerable<JetBrains.ProjectModel.IProjectFile> GetProjectFiles() { }
        public override System.Collections.Generic.IList<JetBrains.ReSharper.UnitTestFramework.UnitTestTask> GetTaskSequence(System.Collections.Generic.ICollection<JetBrains.ReSharper.UnitTestFramework.IUnitTestElement> explicitElements, JetBrains.ReSharper.UnitTestFramework.IUnitTestLaunch launch) { }
        public static JetBrains.ReSharper.UnitTestProvider.MSTest.MsTestTestClassElementBase ReadFromXml(System.Xml.XmlElement parent, JetBrains.ReSharper.UnitTestProvider.MSTest09.MsTestElementFactory factory, JetBrains.ProjectModel.ISolution solution) { }
        public void WriteToXml(System.Xml.XmlElement parent) { }
    }
    public class MsTestTestMethodElement : JetBrains.ReSharper.UnitTestProvider.MSTest.MsTestTestMethodElementBase, System.IEquatable<JetBrains.ReSharper.UnitTestProvider.MSTest09.MsTestTestMethodElement>
    {
        public MsTestTestMethodElement(string id, JetBrains.ReSharper.UnitTestProvider.MSTest.IMsTestServices services, JetBrains.ReSharper.UnitTestProvider.MSTest.MsTestTestClassElementBase fixture, JetBrains.ProjectModel.ProjectModelElementEnvoy project, JetBrains.ReSharper.Psi.IClrTypeName declaringTypeName, string methodName) { }
        public override string Id { get; }
        public override string Kind { get; }
        public override string ShortName { get; }
        public override bool Equals(JetBrains.ReSharper.UnitTestFramework.IUnitTestElement other) { }
        public bool Equals(JetBrains.ReSharper.UnitTestProvider.MSTest09.MsTestTestMethodElement other) { }
        public override bool Equals(object obj) { }
        public override JetBrains.ReSharper.Psi.IDeclaredElement GetDeclaredElement() { }
        public override JetBrains.ReSharper.UnitTestFramework.UnitTestElementDisposition GetDisposition() { }
        public override int GetHashCode() { }
        public override string GetPresentation(JetBrains.ReSharper.UnitTestFramework.IUnitTestElement parent = null) { }
        public override System.Collections.Generic.IEnumerable<JetBrains.ProjectModel.IProjectFile> GetProjectFiles() { }
        public override System.Collections.Generic.IList<JetBrains.ReSharper.UnitTestFramework.UnitTestTask> GetTaskSequence(System.Collections.Generic.ICollection<JetBrains.ReSharper.UnitTestFramework.IUnitTestElement> explicitElements, JetBrains.ReSharper.UnitTestFramework.IUnitTestLaunch launch) { }
        public static JetBrains.ReSharper.UnitTestProvider.MSTest.MsTestTestMethodElementBase ReadFromXml(System.Xml.XmlElement parent, JetBrains.ReSharper.UnitTestFramework.IUnitTestElement parentElement, JetBrains.ReSharper.UnitTestProvider.MSTest09.MsTestElementFactory factory, JetBrains.ProjectModel.ISolution solution) { }
        public void WriteToXml(System.Xml.XmlElement parent) { }
    }
    public class MsTestTestRowElement : JetBrains.ReSharper.UnitTestProvider.MSTest.MsTestTestRowElementBase, System.IEquatable<JetBrains.ReSharper.UnitTestProvider.MSTest09.MsTestTestRowElement>
    {
        public MsTestTestRowElement(JetBrains.ReSharper.UnitTestProvider.MSTest.IMsTestServices services, JetBrains.ReSharper.UnitTestProvider.MSTest.MsTestTestMethodElementBase testMethodElement, JetBrains.ProjectModel.ProjectModelElementEnvoy project, string tableName, int order) { }
        public override string Id { get; }
        public override string Kind { get; }
        public override string ShortName { get; }
        public override bool Equals(JetBrains.ReSharper.UnitTestFramework.IUnitTestElement other) { }
        public bool Equals(JetBrains.ReSharper.UnitTestProvider.MSTest09.MsTestTestRowElement other) { }
        public override bool Equals(object obj) { }
        public override JetBrains.ReSharper.Psi.IDeclaredElement GetDeclaredElement() { }
        public override JetBrains.ReSharper.UnitTestFramework.UnitTestElementDisposition GetDisposition() { }
        public override int GetHashCode() { }
        public override string GetPresentation(JetBrains.ReSharper.UnitTestFramework.IUnitTestElement parent = null) { }
        public override System.Collections.Generic.IEnumerable<JetBrains.ProjectModel.IProjectFile> GetProjectFiles() { }
        public override System.Collections.Generic.IList<JetBrains.ReSharper.UnitTestFramework.UnitTestTask> GetTaskSequence(System.Collections.Generic.ICollection<JetBrains.ReSharper.UnitTestFramework.IUnitTestElement> explicitElements, JetBrains.ReSharper.UnitTestFramework.IUnitTestLaunch launch) { }
        public static JetBrains.ReSharper.UnitTestProvider.MSTest.MsTestTestRowElementBase ReadFromXml(System.Xml.XmlElement parent, JetBrains.ReSharper.UnitTestFramework.IUnitTestElement parentElement, JetBrains.ReSharper.UnitTestProvider.MSTest09.MsTestElementFactory factory, JetBrains.ProjectModel.ISolution solution) { }
        public void WriteToXml(System.Xml.XmlElement parent) { }
    }
    [JetBrains.ReSharper.UnitTestFramework.FileUnitTestExplorerAttribute()]
    public class MsTestUnitTestFileExplorer : JetBrains.ReSharper.UnitTestFramework.IUnitTestFileExplorer
    {
        public MsTestUnitTestFileExplorer(JetBrains.ReSharper.UnitTestProvider.MSTest09.MsTestProvider provider, JetBrains.ReSharper.UnitTestProvider.MSTest.IMsTestElementFactory factory, JetBrains.ReSharper.UnitTestProvider.MSTest.IMsTestAttributesProvider attributesProvider) { }
        public JetBrains.ReSharper.UnitTestFramework.IUnitTestProvider Provider { get; }
        public void ExploreFile(JetBrains.ReSharper.Psi.Tree.IFile psiFile, JetBrains.ReSharper.UnitTestFramework.UnitTestElementLocationConsumer consumer, JetBrains.Application.CheckForInterrupt interrupted) { }
    }
    [JetBrains.ReSharper.UnitTestFramework.MetadataUnitTestExplorerAttribute()]
    public class MsTestUnitTestMetadataExplorer : JetBrains.ReSharper.UnitTestFramework.IUnitTestMetadataExplorer
    {
        public MsTestUnitTestMetadataExplorer(JetBrains.ReSharper.UnitTestProvider.MSTest09.MsTestProvider provider, JetBrains.ReSharper.UnitTestProvider.MSTest.IMsTestElementFactory factory, JetBrains.Application.IShellLocks shellLocks, JetBrains.ReSharper.UnitTestProvider.MSTest.IMsTestAttributesProvider attributesProvider) { }
        public JetBrains.ReSharper.UnitTestFramework.IUnitTestProvider Provider { get; }
        public void ExploreAssembly(JetBrains.ProjectModel.IProject project, JetBrains.Metadata.Reader.API.IMetadataAssembly assembly, JetBrains.ReSharper.UnitTestFramework.UnitTestElementConsumer consumer, System.Threading.ManualResetEvent exitEvent) { }
    }
}