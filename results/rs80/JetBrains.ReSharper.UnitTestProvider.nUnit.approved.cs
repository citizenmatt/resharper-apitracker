[assembly: JetBrains.UI.Icons.CompiledIcons.CompiledIconsPackAttribute(IconNames=new string[] {
        "Nunit"}, IconPackResourceIdentification="JetBrains.ReSharper.UnitTestProvider.nUnit;component/resources/UnitTestingNunitIc" +
    "ons/ThemedIcons.UnitTestingNunit.Generated.Xaml")]
[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]
[assembly: System.Windows.Markup.XmlnsDefinitionAttribute("urn:shemas-jetbrains-com:ui-application-icons-unit-testing-nunit", "JetBrains.ReSharper.UnitTestProvider.nUnit.Resources")]

namespace JetBrains.ReSharper.UnitTestProvider.nUnit.FileExplorer
{
    
    public class NUnitFileExplorer : JetBrains.ReSharper.Psi.IRecursiveElementProcessor
    {
        public NUnitFileExplorer(JetBrains.ReSharper.UnitTestProvider.nUnit.NUnitElementFactory factory, JetBrains.ReSharper.UnitTestFramework.Elements.IUnitTestElementManager elementManager, JetBrains.ReSharper.UnitTestFramework.AttributeChecker.UnitTestAttributeCache attributeChecker, JetBrains.ReSharper.UnitTestFramework.UnitTestElementLocationConsumer consumer, JetBrains.ReSharper.Psi.Tree.IFile file, JetBrains.Application.CheckForInterrupt interrupted) { }
        public bool ProcessingIsFinished { get; }
        public bool InteriorShouldBeProcessed(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public static bool IsTestFixture(JetBrains.ReSharper.Psi.ITypeElement typeElement, out bool isAbstract, JetBrains.ReSharper.UnitTestFramework.AttributeChecker.UnitTestAttributeCache attributeChecker) { }
        public static bool IsTestMethod(JetBrains.ReSharper.Psi.ITypeMember element, JetBrains.ReSharper.UnitTestFramework.AttributeChecker.UnitTestAttributeCache attributeChecker) { }
        public void ProcessAfterInterior(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public void ProcessBeforeInterior(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
    }
    public class NUnitFileExplorerInheritorsConsumer : JetBrains.ReSharper.Psi.Search.IFindResultConsumer<JetBrains.ReSharper.Psi.ITypeElement>
    {
        public NUnitFileExplorerInheritorsConsumer() { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.ITypeElement> FoundElements { get; }
        public JetBrains.ReSharper.Psi.ITypeElement Build(JetBrains.ReSharper.Psi.Search.FindResult result) { }
        public JetBrains.ReSharper.Psi.Search.FindExecution Merge(JetBrains.ReSharper.Psi.ITypeElement data) { }
    }
    public class static NUnitFileExplorerValuePresenter
    {
        public static string TypeRepresentation(JetBrains.ReSharper.Psi.IType type) { }
        public static string ValueRepresentation(JetBrains.ReSharper.Psi.AttributeValue value, bool escape) { }
    }
    [JetBrains.ReSharper.UnitTestFramework.FileUnitTestExplorerAttribute()]
    public class NUnitTestFileExplorer : JetBrains.ReSharper.UnitTestFramework.IUnitTestFileExplorer
    {
        public NUnitTestFileExplorer(JetBrains.ReSharper.UnitTestProvider.nUnit.NUnitTestProvider provider, JetBrains.ReSharper.UnitTestProvider.nUnit.NUnitElementFactory factory, JetBrains.ReSharper.UnitTestFramework.Elements.IUnitTestElementManager elementManger, JetBrains.ReSharper.UnitTestFramework.AttributeChecker.UnitTestAttributeCache attributeChecker) { }
        public JetBrains.ReSharper.UnitTestFramework.IUnitTestProvider Provider { get; }
        public void ExploreFile(JetBrains.ReSharper.Psi.Tree.IFile psiFile, JetBrains.ReSharper.UnitTestFramework.UnitTestElementLocationConsumer consumer, JetBrains.Application.CheckForInterrupt interrupted) { }
    }
    public class NUnitTestFromAbstractFixtureFakeElement : JetBrains.ReSharper.UnitTestFramework.IUnitTestElement, System.IEquatable<JetBrains.ReSharper.UnitTestFramework.IUnitTestElement>
    {
        public NUnitTestFromAbstractFixtureFakeElement(JetBrains.ReSharper.UnitTestFramework.IUnitTestProvider provider, JetBrains.ProjectModel.IProject project, JetBrains.ReSharper.Psi.IClrTypeName typeName, string methodName) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.UnitTestFramework.UnitTestElementCategory> Categories { get; }
        public System.Collections.Generic.ICollection<JetBrains.ReSharper.UnitTestFramework.IUnitTestElement> Children { get; }
        public bool Explicit { get; }
        public string ExplicitReason { get; }
        public string Id { get; }
        public string Kind { get; }
        public JetBrains.ReSharper.UnitTestFramework.IUnitTestElement Parent { get; set; }
        public JetBrains.ReSharper.UnitTestFramework.IUnitTestProvider Provider { get; }
        public string ShortName { get; }
        public JetBrains.ReSharper.UnitTestFramework.UnitTestElementState State { get; set; }
        public JetBrains.ReSharper.Psi.IClrTypeName TypeName { get; }
        public bool Equals(JetBrains.ReSharper.UnitTestFramework.IUnitTestElement other) { }
        public JetBrains.ReSharper.Psi.IDeclaredElement GetDeclaredElement() { }
        public JetBrains.ReSharper.UnitTestFramework.UnitTestElementDisposition GetDisposition() { }
        public virtual JetBrains.ReSharper.UnitTestFramework.UnitTestNamespace GetNamespace() { }
        public string GetPresentation(JetBrains.ReSharper.UnitTestFramework.IUnitTestElement parent = null) { }
        public JetBrains.ProjectModel.IProject GetProject() { }
        public System.Collections.Generic.IEnumerable<JetBrains.ProjectModel.IProjectFile> GetProjectFiles() { }
        public JetBrains.ReSharper.UnitTestFramework.Strategy.IUnitTestRunStrategy GetRunStrategy(JetBrains.ReSharper.UnitTestFramework.IHostProvider hostProvider) { }
        public System.Collections.Generic.IList<JetBrains.ReSharper.UnitTestFramework.UnitTestTask> GetTaskSequence(System.Collections.Generic.ICollection<JetBrains.ReSharper.UnitTestFramework.IUnitTestElement> explicitElements, JetBrains.ReSharper.UnitTestFramework.IUnitTestLaunch launch) { }
    }
}
namespace JetBrains.ReSharper.UnitTestProvider.nUnit
{
    
    public class NUnitDynamicRowTestElement : JetBrains.ReSharper.UnitTestProvider.nUnit.NUnitRowTestElement
    {
        public NUnitDynamicRowTestElement(JetBrains.ReSharper.UnitTestProvider.nUnit.NUnitServiceProvider serviceProvider, string id, JetBrains.ReSharper.UnitTestProvider.nUnit.NUnitTestElement test, JetBrains.ProjectModel.ProjectModelElementEnvoy project, JetBrains.ReSharper.Psi.IClrTypeName typeName) { }
        public override string ShortName { get; }
        public override JetBrains.ReSharper.UnitTestFramework.UnitTestElementState State { get; set; }
    }
    public abstract class NUnitElementBase : JetBrains.ReSharper.UnitTestFramework.IUnitTestElement, System.IEquatable<JetBrains.ReSharper.UnitTestFramework.IUnitTestElement>
    {
        protected readonly JetBrains.ReSharper.UnitTestProvider.nUnit.NUnitServiceProvider ourServiceProvider;
        protected NUnitElementBase(JetBrains.ReSharper.UnitTestProvider.nUnit.NUnitServiceProvider serviceProvider, string id, JetBrains.ReSharper.Psi.IClrTypeName typeName, JetBrains.ProjectModel.ProjectModelElementEnvoy pointer) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.UnitTestFramework.UnitTestElementCategory> Categories { get; set; }
        public System.Collections.Generic.ICollection<JetBrains.ReSharper.UnitTestFramework.IUnitTestElement> Children { get; }
        public virtual bool Explicit { get; }
        public string ExplicitReason { get; set; }
        public string Id { get; }
        public abstract string Kind { get; }
        public JetBrains.ReSharper.UnitTestFramework.IUnitTestElement Parent { get; set; }
        public JetBrains.ReSharper.UnitTestFramework.IUnitTestProvider Provider { get; }
        public abstract string ShortName { get; }
        public virtual JetBrains.ReSharper.UnitTestFramework.UnitTestElementState State { get; set; }
        public JetBrains.ReSharper.Psi.IClrTypeName TypeName { get; }
        public abstract bool Equals(JetBrains.ReSharper.UnitTestFramework.IUnitTestElement other);
        public abstract JetBrains.ReSharper.Psi.IDeclaredElement GetDeclaredElement();
        public abstract JetBrains.ReSharper.UnitTestFramework.UnitTestElementDisposition GetDisposition();
        public virtual JetBrains.ReSharper.UnitTestFramework.UnitTestNamespace GetNamespace() { }
        public abstract string GetPresentation(JetBrains.ReSharper.UnitTestFramework.IUnitTestElement parent = null);
        public JetBrains.ProjectModel.IProject GetProject() { }
        public abstract System.Collections.Generic.IEnumerable<JetBrains.ProjectModel.IProjectFile> GetProjectFiles();
        public JetBrains.ReSharper.UnitTestFramework.Strategy.IUnitTestRunStrategy GetRunStrategy(JetBrains.ReSharper.UnitTestFramework.IHostProvider hostProvider) { }
        public abstract System.Collections.Generic.IList<JetBrains.ReSharper.UnitTestFramework.UnitTestTask> GetTaskSequence(System.Collections.Generic.ICollection<JetBrains.ReSharper.UnitTestFramework.IUnitTestElement> explicitElements, JetBrains.ReSharper.UnitTestFramework.IUnitTestLaunch launch);
        public override string ToString() { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class NUnitElementFactory
    {
        public NUnitElementFactory(JetBrains.ReSharper.UnitTestProvider.nUnit.NUnitServiceProvider provider, JetBrains.ReSharper.UnitTestFramework.Elements.IUnitTestElementManager elementManager) { }
        public JetBrains.ReSharper.UnitTestFramework.IUnitTestElement CreateTestFromAbstractFixtureFakeElement(JetBrains.ProjectModel.IProject project, JetBrains.ReSharper.Psi.IClrTypeName clrTypeName, string shortName) { }
    }
    public class NUnitGenericTestFixtureElement : JetBrains.ReSharper.UnitTestProvider.nUnit.NUnitTestFixtureElement, System.IEquatable<JetBrains.ReSharper.UnitTestProvider.nUnit.NUnitGenericTestFixtureElement>
    {
        public NUnitGenericTestFixtureElement(JetBrains.ReSharper.UnitTestProvider.nUnit.NUnitServiceProvider serviceProvider, string id, JetBrains.ProjectModel.ProjectModelElementEnvoy project, JetBrains.ReSharper.UnitTestProvider.nUnit.NUnitTestFixtureElement parent) { }
        public override JetBrains.ReSharper.UnitTestFramework.UnitTestElementState State { get; set; }
        public bool Equals(JetBrains.ReSharper.UnitTestProvider.nUnit.NUnitGenericTestFixtureElement other) { }
        public override bool Equals(JetBrains.ReSharper.UnitTestFramework.IUnitTestElement other) { }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
        public override string GetPresentation(JetBrains.ReSharper.UnitTestFramework.IUnitTestElement parent = null) { }
        public override System.Collections.Generic.IList<JetBrains.ReSharper.UnitTestFramework.UnitTestTask> GetTaskSequence(System.Collections.Generic.ICollection<JetBrains.ReSharper.UnitTestFramework.IUnitTestElement> explicitElements, JetBrains.ReSharper.UnitTestFramework.IUnitTestLaunch launch) { }
        public new static JetBrains.ReSharper.UnitTestProvider.nUnit.NUnitTestFixtureElement ReadFromXml(System.Xml.XmlElement parent, JetBrains.ReSharper.UnitTestFramework.IUnitTestElement parentElement, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.UnitTestProvider.nUnit.NUnitElementFactory factory) { }
        public new void WriteToXml(System.Xml.XmlElement parent) { }
    }
    public class NUnitMetadataExplorer
    {
        public NUnitMetadataExplorer(JetBrains.ReSharper.UnitTestProvider.nUnit.NUnitElementFactory factory, JetBrains.ReSharper.UnitTestFramework.Elements.IUnitTestElementManager elementManager, JetBrains.ReSharper.UnitTestFramework.AttributeChecker.UnitTestAttributeCache checker, JetBrains.ProjectModel.IProject project, JetBrains.Application.IShellLocks shellLocks, JetBrains.ReSharper.UnitTestFramework.UnitTestElementConsumer consumer) { }
        public void ExploreAssembly(JetBrains.Metadata.Reader.API.IMetadataAssembly assembly) { }
        public static string ExtractCategoryFromAttributeName(string fullyQualifiedName) { }
    }
    public class static NUnitMetadataExplorerValuePresenter
    {
        public static string TypeRepresentation(JetBrains.Metadata.Reader.API.IMetadataType type) { }
        public static string ValueRepresentation(JetBrains.Metadata.Reader.API.MetadataAttributeValue attributeValue, bool escape) { }
        public static string ValueRepresentation(object value, bool escape, JetBrains.Metadata.Reader.API.IMetadataType type = null) { }
        public static string ValueRepresentation(JetBrains.Metadata.Reader.API.MetadataAttributeValue value, int i, JetBrains.Metadata.Reader.API.IMetadataParameter[] parameters, bool escape) { }
    }
    [JetBrains.UI.Options.OptionsPageAttribute("nUnit", "NUnit", typeof(JetBrains.ReSharper.UnitTestProvider.nUnit.Resources.UnitTestingNunitThemedIcons.Nunit), HelpKeyword="Reference__Options__Tools__Unit_Testing__NUnit", ParentId="UnitTesting", Sequence=1D)]
    public class NUnitPage : JetBrains.UI.Options.Helpers.AStackPanelOptionsPage3
    {
        public NUnitPage(JetBrains.DataFlow.Lifetime lifetime, JetBrains.UI.Application.IUIApplication environment, JetBrains.UI.Options.OptionsSettingsSmartContext smartContext, JetBrains.ReSharper.UnitTestProvider.nUnit.NUnitTestProvider provider = null) { }
    }
    [JetBrains.Application.Settings.SettingsKeyAttribute(typeof(JetBrains.ReSharper.UnitTestFramework.UnitTestingSettings), "Settings for NUnit unit test provider")]
    public class NUnitProviderSettings
    {
        [JetBrains.Application.Settings.SettingsEntryAttribute(null, "Path to custom NUnit installation")]
        public string CustomNUnitFolder;
        [JetBrains.Application.Settings.SettingsEntryAttribute(JetBrains.ReSharper.UnitTestRunner.nUnit.UseAddins.IfRequired, "NUnit addin usage policy")]
        public JetBrains.ReSharper.UnitTestRunner.nUnit.UseAddins UseAddins;
        [JetBrains.Application.Settings.SettingsEntryAttribute(false, "Use custom NUnit installation")]
        public bool UseCustomNUnit;
    }
    public class NUnitRowTestElement : JetBrains.ReSharper.UnitTestProvider.nUnit.NUnitElementBase, System.IEquatable<JetBrains.ReSharper.UnitTestProvider.nUnit.NUnitRowTestElement>
    {
        protected readonly JetBrains.ReSharper.UnitTestProvider.nUnit.NUnitTestElement ourTest;
        public NUnitRowTestElement(JetBrains.ReSharper.UnitTestProvider.nUnit.NUnitServiceProvider serviceProvider, string id, JetBrains.ReSharper.UnitTestProvider.nUnit.NUnitTestElement test, JetBrains.ProjectModel.ProjectModelElementEnvoy project, JetBrains.ReSharper.Psi.IClrTypeName typeName) { }
        public override string Kind { get; }
        public override string ShortName { get; }
        public bool Equals(JetBrains.ReSharper.UnitTestProvider.nUnit.NUnitRowTestElement other) { }
        public override bool Equals(JetBrains.ReSharper.UnitTestFramework.IUnitTestElement other) { }
        public override bool Equals(object obj) { }
        public override JetBrains.ReSharper.Psi.IDeclaredElement GetDeclaredElement() { }
        public override JetBrains.ReSharper.UnitTestFramework.UnitTestElementDisposition GetDisposition() { }
        public override int GetHashCode() { }
        public override string GetPresentation(JetBrains.ReSharper.UnitTestFramework.IUnitTestElement parent = null) { }
        public override System.Collections.Generic.IEnumerable<JetBrains.ProjectModel.IProjectFile> GetProjectFiles() { }
        public override System.Collections.Generic.IList<JetBrains.ReSharper.UnitTestFramework.UnitTestTask> GetTaskSequence(System.Collections.Generic.ICollection<JetBrains.ReSharper.UnitTestFramework.IUnitTestElement> explicitElements, JetBrains.ReSharper.UnitTestFramework.IUnitTestLaunch launch) { }
        public static JetBrains.ReSharper.UnitTestProvider.nUnit.NUnitRowTestElement ReadFromXml(System.Xml.XmlElement parent, JetBrains.ReSharper.UnitTestFramework.IUnitTestElement parentElement, JetBrains.ReSharper.UnitTestProvider.nUnit.NUnitElementFactory factory) { }
        public void WriteToXml(System.Xml.XmlElement parent) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class NUnitServiceProvider
    {
        public NUnitServiceProvider(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Psi.Modules.IPsiModules psiModules, JetBrains.ReSharper.Psi.Caches.ISymbolCache symbolCache, JetBrains.ReSharper.UnitTestProvider.nUnit.NUnitTestProvider provider, JetBrains.Application.Settings.ISettingsStore settingsStore) { }
        public JetBrains.Application.Settings.IContextBoundSettingsStore BoundSettingsStore { get; }
        public JetBrains.ReSharper.UnitTestFramework.IUnitTestProvider Provider { get; }
        public JetBrains.ReSharper.Psi.Modules.IPsiModules PsiModules { get; }
        public JetBrains.ReSharper.UnitTestFramework.Strategy.IUnitTestRunStrategy Strategy { get; }
        public JetBrains.ReSharper.Psi.Caches.ISymbolCache SymbolCache { get; }
    }
    public class NUnitSetUpFixtureElement : JetBrains.ReSharper.UnitTestProvider.nUnit.NUnitElementBase, JetBrains.ReSharper.UnitTestFramework.IUnitTestNamespace, System.IEquatable<JetBrains.ReSharper.UnitTestProvider.nUnit.NUnitSetUpFixtureElement>
    {
        public NUnitSetUpFixtureElement(JetBrains.ReSharper.UnitTestProvider.nUnit.NUnitServiceProvider serviceProvider, string id, JetBrains.ProjectModel.ProjectModelElementEnvoy project, JetBrains.ReSharper.Psi.IClrTypeName typeName) { }
        public override string Kind { get; }
        public string NamespaceName { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.UnitTestProvider.nUnit.NUnitSetUpFixtureElement> SetUpFixtures { get; }
        public override string ShortName { get; }
        public void AddSetupFixture(JetBrains.ReSharper.UnitTestProvider.nUnit.NUnitSetUpFixtureElement setUpFixture) { }
        public override bool Equals(JetBrains.ReSharper.UnitTestFramework.IUnitTestElement other) { }
        public bool Equals(JetBrains.ReSharper.UnitTestProvider.nUnit.NUnitSetUpFixtureElement other) { }
        public override JetBrains.ReSharper.Psi.IDeclaredElement GetDeclaredElement() { }
        public override JetBrains.ReSharper.UnitTestFramework.UnitTestElementDisposition GetDisposition() { }
        public override int GetHashCode() { }
        public override JetBrains.ReSharper.UnitTestFramework.UnitTestNamespace GetNamespace() { }
        public override string GetPresentation(JetBrains.ReSharper.UnitTestFramework.IUnitTestElement parent = null) { }
        public override System.Collections.Generic.IEnumerable<JetBrains.ProjectModel.IProjectFile> GetProjectFiles() { }
        public override System.Collections.Generic.IList<JetBrains.ReSharper.UnitTestFramework.UnitTestTask> GetTaskSequence(System.Collections.Generic.ICollection<JetBrains.ReSharper.UnitTestFramework.IUnitTestElement> explicitElements, JetBrains.ReSharper.UnitTestFramework.IUnitTestLaunch launch) { }
        public static JetBrains.ReSharper.UnitTestProvider.nUnit.NUnitSetUpFixtureElement ReadFromXml(System.Xml.XmlElement parent, JetBrains.ReSharper.UnitTestProvider.nUnit.NUnitElementFactory factory, JetBrains.ProjectModel.ISolution solution) { }
        public void WriteToXml(System.Xml.XmlElement parent) { }
    }
    public class NUnitTestElement : JetBrains.ReSharper.UnitTestProvider.nUnit.NUnitElementBase, System.IEquatable<JetBrains.ReSharper.UnitTestProvider.nUnit.NUnitTestElement>
    {
        public NUnitTestElement(JetBrains.ReSharper.UnitTestProvider.nUnit.NUnitServiceProvider serviceProvider, string id, JetBrains.ReSharper.UnitTestProvider.nUnit.NUnitTestFixtureElement fixture, JetBrains.ProjectModel.ProjectModelElementEnvoy project, JetBrains.ReSharper.Psi.IClrTypeName typeName, string methodName) { }
        public JetBrains.ReSharper.UnitTestProvider.nUnit.NUnitTestFixtureElement Fixture { get; }
        public override string Kind { get; }
        public override string ShortName { get; }
        public override bool Equals(JetBrains.ReSharper.UnitTestFramework.IUnitTestElement other) { }
        public bool Equals(JetBrains.ReSharper.UnitTestProvider.nUnit.NUnitTestElement other) { }
        public override bool Equals(object obj) { }
        public override JetBrains.ReSharper.Psi.IDeclaredElement GetDeclaredElement() { }
        public override JetBrains.ReSharper.UnitTestFramework.UnitTestElementDisposition GetDisposition() { }
        public override int GetHashCode() { }
        public override string GetPresentation(JetBrains.ReSharper.UnitTestFramework.IUnitTestElement parent = null) { }
        public override System.Collections.Generic.IEnumerable<JetBrains.ProjectModel.IProjectFile> GetProjectFiles() { }
        public override System.Collections.Generic.IList<JetBrains.ReSharper.UnitTestFramework.UnitTestTask> GetTaskSequence(System.Collections.Generic.ICollection<JetBrains.ReSharper.UnitTestFramework.IUnitTestElement> explicitElements, JetBrains.ReSharper.UnitTestFramework.IUnitTestLaunch launch) { }
        public static JetBrains.ReSharper.UnitTestProvider.nUnit.NUnitTestElement ReadFromXml(System.Xml.XmlElement parent, JetBrains.ReSharper.UnitTestFramework.IUnitTestElement parentElement, JetBrains.ReSharper.UnitTestProvider.nUnit.NUnitElementFactory factory, JetBrains.ProjectModel.ISolution solution) { }
        public void WriteToXml(System.Xml.XmlElement parent) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class NUnitTestElementSerializer : JetBrains.ReSharper.UnitTestFramework.IUnitTestElementSerializer
    {
        public NUnitTestElementSerializer(JetBrains.ReSharper.UnitTestProvider.nUnit.NUnitTestProvider provider, JetBrains.ReSharper.UnitTestProvider.nUnit.NUnitElementFactory factory, JetBrains.ProjectModel.ISolution solution) { }
        public JetBrains.ReSharper.UnitTestFramework.IUnitTestProvider Provider { get; }
        public JetBrains.ReSharper.UnitTestFramework.IUnitTestElement DeserializeElement(System.Xml.XmlElement parent, JetBrains.ReSharper.UnitTestFramework.IUnitTestElement parentElement) { }
        public void SerializeElement(System.Xml.XmlElement parent, JetBrains.ReSharper.UnitTestFramework.IUnitTestElement element) { }
    }
    public class NUnitTestFixtureElement : JetBrains.ReSharper.UnitTestProvider.nUnit.NUnitElementBase, System.IEquatable<JetBrains.ReSharper.UnitTestProvider.nUnit.NUnitTestFixtureElement>
    {
        protected const string PROJECT_ATTRIBUTE = "Project";
        public NUnitTestFixtureElement(JetBrains.ReSharper.UnitTestProvider.nUnit.NUnitServiceProvider serviceProvider, string id, JetBrains.ProjectModel.ProjectModelElementEnvoy project, JetBrains.ReSharper.Psi.IClrTypeName typeName, string assemblyLocation, JetBrains.ReSharper.UnitTestFramework.IUnitTestElement parent) { }
        public string AssemblyLocation { get; set; }
        public override string Kind { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.UnitTestProvider.nUnit.NUnitSetUpFixtureElement> SetUpFixtures { get; }
        public override string ShortName { get; }
        public void AddSetupFixture(JetBrains.ReSharper.UnitTestProvider.nUnit.NUnitSetUpFixtureElement setUpFixture) { }
        public override bool Equals(JetBrains.ReSharper.UnitTestFramework.IUnitTestElement other) { }
        public bool Equals(JetBrains.ReSharper.UnitTestProvider.nUnit.NUnitTestFixtureElement other) { }
        public override bool Equals(object obj) { }
        public override JetBrains.ReSharper.Psi.IDeclaredElement GetDeclaredElement() { }
        public override JetBrains.ReSharper.UnitTestFramework.UnitTestElementDisposition GetDisposition() { }
        public override int GetHashCode() { }
        public override string GetPresentation(JetBrains.ReSharper.UnitTestFramework.IUnitTestElement parent = null) { }
        public override System.Collections.Generic.IEnumerable<JetBrains.ProjectModel.IProjectFile> GetProjectFiles() { }
        public override System.Collections.Generic.IList<JetBrains.ReSharper.UnitTestFramework.UnitTestTask> GetTaskSequence(System.Collections.Generic.ICollection<JetBrains.ReSharper.UnitTestFramework.IUnitTestElement> explicitElements, JetBrains.ReSharper.UnitTestFramework.IUnitTestLaunch launch) { }
        public static JetBrains.ReSharper.UnitTestProvider.nUnit.NUnitTestFixtureElement ReadFromXml(System.Xml.XmlElement parent, JetBrains.ReSharper.UnitTestFramework.IUnitTestElement parentElement, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.UnitTestProvider.nUnit.NUnitElementFactory factory) { }
        public void WriteToXml(System.Xml.XmlElement parent) { }
    }
    [JetBrains.ReSharper.UnitTestFramework.UnitTestPresenterAttribute()]
    public class NUnitTestPresenter : JetBrains.ReSharper.UnitTestFramework.IUnitTestPresenter
    {
        public NUnitTestPresenter() { }
        public void Present(JetBrains.ReSharper.UnitTestFramework.IUnitTestElement element, JetBrains.CommonControls.IPresentableItem item, JetBrains.TreeModels.TreeModelNode node, JetBrains.UI.TreeView.PresentationState state) { }
    }
    [JetBrains.ReSharper.UnitTestFramework.UnitTestProviderAttribute()]
    public class NUnitTestProvider : JetBrains.ReSharper.Features.Shared.UnitTesting.IUnitTestingCategoriesAttributeProvider, JetBrains.ReSharper.UnitTestFramework.IDynamicUnitTestProvider, JetBrains.ReSharper.UnitTestFramework.IUnitTestProvider
    {
        public static readonly JetBrains.ReSharper.Psi.IClrTypeName CategoryAttribute;
        public static readonly JetBrains.ReSharper.Psi.IClrTypeName ExplicitAttribute;
        public static readonly JetBrains.ReSharper.Psi.IClrTypeName IgnoreAttribute;
        public const string NAME = "NUnit";
        public static readonly JetBrains.ReSharper.Psi.IClrTypeName RandomAttribute;
        public static readonly JetBrains.ReSharper.Psi.IClrTypeName RangeAttribute;
        public static readonly JetBrains.ReSharper.Psi.IClrTypeName SequentialAttribute;
        public static readonly JetBrains.ReSharper.Psi.IClrTypeName SetUpFixtureAttribute;
        public static readonly JetBrains.ReSharper.Psi.IClrTypeName TestAttribute;
        public static readonly JetBrains.ReSharper.Psi.IClrTypeName TestCaseAttribute;
        public static readonly JetBrains.ReSharper.Psi.IClrTypeName TestCaseSourceAttribute;
        public static readonly JetBrains.ReSharper.Psi.IClrTypeName TestFixtureAttribute;
        public static readonly JetBrains.ReSharper.Psi.IClrTypeName TheoryAttribute;
        public static readonly JetBrains.ReSharper.Psi.IClrTypeName ValuesAttribute;
        public static readonly JetBrains.ReSharper.Psi.IClrTypeName ValueSourceAttribute;
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IClrTypeName> CategoryAttributes { get; }
        public string ID { get; }
        public string Name { get; }
        public int CompareUnitTestElements(JetBrains.ReSharper.UnitTestFramework.IUnitTestElement x, JetBrains.ReSharper.UnitTestFramework.IUnitTestElement y) { }
        public void ExploreExternal(JetBrains.ReSharper.UnitTestFramework.UnitTestElementConsumer consumer) { }
        public void ExploreSolution(JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.UnitTestFramework.UnitTestElementConsumer consumer) { }
        public JetBrains.ReSharper.UnitTestFramework.IUnitTestElement GetDynamicElement(JetBrains.ReSharper.TaskRunnerFramework.RemoteTask remoteTask, System.Collections.Generic.Dictionary<JetBrains.ReSharper.TaskRunnerFramework.RemoteTask, JetBrains.ReSharper.UnitTestFramework.IUnitTestElement> tasks) { }
        public bool IsElementOfKind(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, JetBrains.ReSharper.UnitTestFramework.UnitTestElementKind elementKind) { }
        public bool IsElementOfKind(JetBrains.ReSharper.UnitTestFramework.IUnitTestElement element, JetBrains.ReSharper.UnitTestFramework.UnitTestElementKind elementKind) { }
        public bool IsSupported(JetBrains.ReSharper.UnitTestFramework.IHostProvider hostProvider) { }
        public static bool ValidateNUnitPath(JetBrains.Util.FileSystemPath path) { }
    }
    [JetBrains.ProjectModel.Settings.Upgrade.SolutionSettingsUpgraderAttribute()]
    public class NUnitTestProviderSettingsUpgrader : JetBrains.ReSharper.UnitTestFramework.UnitTestProviderSettingsUpgraderBase
    {
        [JetBrains.Application.Configuration.XmlExternalizableAttribute(null, SettingName="NUnitInstallDir")]
        public virtual string NUnitInstallDir { get; set; }
        protected override string SectionName { get; }
        [JetBrains.Application.Configuration.XmlExternalizableAttribute(JetBrains.ReSharper.UnitTestRunner.nUnit.UseAddins.IfRequired)]
        public JetBrains.ReSharper.UnitTestRunner.nUnit.UseAddins UseAddins { get; set; }
        [JetBrains.Application.Configuration.XmlExternalizableAttribute(false)]
        public virtual bool UseSpecifiedNUnit { get; set; }
    }
    public class NUnitTestTreePresenter : JetBrains.ReSharper.Features.Shared.TreePsiBrowser.TreeModelBrowserPresenter
    {
        public NUnitTestTreePresenter() { }
        protected override bool IsNaturalParent(object parentValue, object childValue) { }
        protected override object Unwrap(object value) { }
    }
    [JetBrains.ReSharper.UnitTestFramework.MetadataUnitTestExplorerAttribute()]
    public class NUnitUnitTestMetadataExplorer : JetBrains.ReSharper.UnitTestFramework.IUnitTestMetadataExplorer
    {
        public NUnitUnitTestMetadataExplorer(JetBrains.ReSharper.UnitTestProvider.nUnit.NUnitTestProvider provider, JetBrains.Application.IShellLocks shellLocks, JetBrains.ReSharper.UnitTestProvider.nUnit.NUnitElementFactory factory, JetBrains.ReSharper.UnitTestFramework.Elements.IUnitTestElementManager elementManager, JetBrains.ReSharper.UnitTestFramework.AttributeChecker.UnitTestAttributeCache attributeCache) { }
        public JetBrains.ReSharper.UnitTestFramework.IUnitTestProvider Provider { get; }
        public void ExploreAssembly(JetBrains.ProjectModel.IProject project, JetBrains.Metadata.Reader.API.IMetadataAssembly assembly, JetBrains.ReSharper.UnitTestFramework.UnitTestElementConsumer consumer, System.Threading.ManualResetEvent exitEvent) { }
    }
    public class NUnitUnitTestProjectsExplorer : JetBrains.ReSharper.UnitTestFramework.IUnitTestProjectsExplorer
    {
        public NUnitUnitTestProjectsExplorer(JetBrains.ReSharper.UnitTestProvider.nUnit.NUnitServiceProvider provider, JetBrains.ProjectModel.ISolution solution, JetBrains.Util.ILogger logger, JetBrains.ReSharper.UnitTestFramework.IUnitTestAgentManager unitTestAgentManager, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.UnitTestFramework.IHostProvider> hostProviders, JetBrains.ReSharper.UnitTestProvider.nUnit.NUnitElementFactory elementFactory, JetBrains.Application.IShellLocks shellLocks) { }
        public JetBrains.ReSharper.UnitTestFramework.IUnitTestProvider Provider { get; }
        public void ExploreProject(JetBrains.ProjectModel.IProject project, string assemblyLocation, JetBrains.ReSharper.UnitTestFramework.UnitTestElementsConsumer consumer) { }
        public void ExploreProjects(System.Collections.Generic.ICollection<JetBrains.ProjectModel.IProject> projects, JetBrains.ReSharper.UnitTestFramework.UnitTestElementsConsumer consumer) { }
    }
}
namespace JetBrains.ReSharper.UnitTestProvider.nUnit.Resources
{
    
    public sealed class UnitTestingNunitThemedIcons
    {
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.UnitTestProvider.nUnit;component/resources/UnitTestingNunitIc" +
            "ons/ThemedIcons.UnitTestingNunit.Generated.Xaml", 0, "Nunit")]
        public sealed class Nunit : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
    }
}
namespace JetBrains.ReSharper.UnitTestProvider.nUnit.TaskHandler
{
    
    public class DiscoveredAssemblyHandler : JetBrains.ReSharper.UnitTestFramework.IDiscoveredRemoteTaskHandler
    {
        public DiscoveredAssemblyHandler(System.Collections.Generic.IEnumerable<JetBrains.ProjectModel.IProject> projects) { }
        public DiscoveredAssemblyHandler(JetBrains.ProjectModel.IProject project, string assemblyLocation) { }
        public string CurrentAssemblyLocation { get; }
        public JetBrains.ProjectModel.IProject CurrentProject { get; }
        public JetBrains.ProjectModel.ProjectModelElementEnvoy CurrentProjectEnvoy { get; }
        public JetBrains.ReSharper.UnitTestFramework.IUnitTestElement Accept(JetBrains.ReSharper.UnitTestFramework.IUnitTestRun run, JetBrains.ReSharper.TaskRunnerFramework.RemoteTask task, out JetBrains.ProjectModel.IProject project) { }
        public bool CanHandle(JetBrains.ReSharper.TaskRunnerFramework.RemoteTask task) { }
    }
    public class DiscoveredGenericTestFixtureHandler : JetBrains.ReSharper.UnitTestProvider.nUnit.TaskHandler.DiscoveredRemoteTaskHandlerBase<JetBrains.ReSharper.UnitTestRunner.nUnit.NUnitGenericTestFixtureTask>
    {
        public DiscoveredGenericTestFixtureHandler(JetBrains.ReSharper.UnitTestProvider.nUnit.NUnitElementFactory elementFactory, JetBrains.ReSharper.UnitTestProvider.nUnit.TaskHandler.DiscoveredAssemblyHandler assemblyHandler, System.Collections.Generic.Dictionary<string, JetBrains.ReSharper.UnitTestFramework.IUnitTestElement> discoveredElements) { }
        protected override JetBrains.ReSharper.UnitTestFramework.IUnitTestElement Accept(JetBrains.ReSharper.UnitTestRunner.nUnit.NUnitGenericTestFixtureTask task, out JetBrains.ProjectModel.IProject project) { }
    }
    public abstract class DiscoveredRemoteTaskHandlerBase<T> : JetBrains.ReSharper.UnitTestFramework.IDiscoveredRemoteTaskHandler
        where T : JetBrains.ReSharper.TaskRunnerFramework.RemoteTask
    {
        protected readonly JetBrains.ReSharper.UnitTestProvider.nUnit.TaskHandler.DiscoveredAssemblyHandler ourAssemblyHandler;
        protected readonly System.Collections.Generic.Dictionary<string, JetBrains.ReSharper.UnitTestFramework.IUnitTestElement> ourDiscoveredElements;
        protected DiscoveredRemoteTaskHandlerBase(JetBrains.ReSharper.UnitTestProvider.nUnit.TaskHandler.DiscoveredAssemblyHandler assemblyHandler, System.Collections.Generic.Dictionary<string, JetBrains.ReSharper.UnitTestFramework.IUnitTestElement> discoveredElements) { }
        public JetBrains.ReSharper.UnitTestFramework.IUnitTestElement Accept(JetBrains.ReSharper.UnitTestFramework.IUnitTestRun run, JetBrains.ReSharper.TaskRunnerFramework.RemoteTask task, out JetBrains.ProjectModel.IProject project) { }
        protected abstract JetBrains.ReSharper.UnitTestFramework.IUnitTestElement Accept(T task, out JetBrains.ProjectModel.IProject project);
        public bool CanHandle(JetBrains.ReSharper.TaskRunnerFramework.RemoteTask task) { }
    }
    public class DiscoveredSetUpFixtureHandler : JetBrains.ReSharper.UnitTestProvider.nUnit.TaskHandler.DiscoveredRemoteTaskHandlerBase<JetBrains.ReSharper.UnitTestRunner.nUnit.NUnitSetUpFixtureTask>
    {
        public DiscoveredSetUpFixtureHandler(JetBrains.ReSharper.UnitTestProvider.nUnit.NUnitElementFactory elementFactory, JetBrains.ReSharper.UnitTestProvider.nUnit.TaskHandler.DiscoveredAssemblyHandler assemblyHandler, System.Collections.Generic.Dictionary<string, JetBrains.ReSharper.UnitTestFramework.IUnitTestElement> discoveredElements) { }
        protected override JetBrains.ReSharper.UnitTestFramework.IUnitTestElement Accept(JetBrains.ReSharper.UnitTestRunner.nUnit.NUnitSetUpFixtureTask task, out JetBrains.ProjectModel.IProject project) { }
    }
    public class DiscoveredTasksCollector : JetBrains.ReSharper.UnitTestFramework.IDiscoveredRemoteTaskHandler
    {
        public DiscoveredTasksCollector() { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.TaskRunnerFramework.RemoteTask> AllTasks { get; }
        public JetBrains.ReSharper.UnitTestFramework.IUnitTestElement Accept(JetBrains.ReSharper.UnitTestFramework.IUnitTestRun run, JetBrains.ReSharper.TaskRunnerFramework.RemoteTask task, out JetBrains.ProjectModel.IProject project) { }
        public bool CanHandle(JetBrains.ReSharper.TaskRunnerFramework.RemoteTask task) { }
    }
    public class DiscoveredTestCaseHandler : JetBrains.ReSharper.UnitTestProvider.nUnit.TaskHandler.DiscoveredRemoteTaskHandlerBase<JetBrains.ReSharper.UnitTestRunner.nUnit.NUnitRowTestTask>
    {
        public DiscoveredTestCaseHandler(JetBrains.ReSharper.UnitTestProvider.nUnit.NUnitElementFactory elementFactory, JetBrains.ReSharper.UnitTestProvider.nUnit.TaskHandler.DiscoveredAssemblyHandler assemblyHandler, System.Collections.Generic.Dictionary<string, JetBrains.ReSharper.UnitTestFramework.IUnitTestElement> discoveredElements) { }
        protected override JetBrains.ReSharper.UnitTestFramework.IUnitTestElement Accept(JetBrains.ReSharper.UnitTestRunner.nUnit.NUnitRowTestTask task, out JetBrains.ProjectModel.IProject project) { }
    }
    public class DiscoveredTestFixtureHandler : JetBrains.ReSharper.UnitTestProvider.nUnit.TaskHandler.DiscoveredRemoteTaskHandlerBase<JetBrains.ReSharper.UnitTestRunner.nUnit.NUnitTestFixtureTask>
    {
        public DiscoveredTestFixtureHandler(JetBrains.ReSharper.UnitTestProvider.nUnit.NUnitElementFactory elementFactory, JetBrains.ReSharper.UnitTestProvider.nUnit.TaskHandler.DiscoveredAssemblyHandler assemblyHandler, System.Collections.Generic.Dictionary<string, JetBrains.ReSharper.UnitTestFramework.IUnitTestElement> discoveredElements) { }
        protected override JetBrains.ReSharper.UnitTestFramework.IUnitTestElement Accept(JetBrains.ReSharper.UnitTestRunner.nUnit.NUnitTestFixtureTask task, out JetBrains.ProjectModel.IProject project) { }
    }
    public class DiscoveredTestHandler : JetBrains.ReSharper.UnitTestProvider.nUnit.TaskHandler.DiscoveredRemoteTaskHandlerBase<JetBrains.ReSharper.UnitTestRunner.nUnit.NUnitTestTask>
    {
        public DiscoveredTestHandler(JetBrains.ReSharper.UnitTestProvider.nUnit.NUnitElementFactory elementFactory, JetBrains.ReSharper.UnitTestProvider.nUnit.TaskHandler.DiscoveredAssemblyHandler assemblyHandler, System.Collections.Generic.Dictionary<string, JetBrains.ReSharper.UnitTestFramework.IUnitTestElement> discoveredElements) { }
        protected override JetBrains.ReSharper.UnitTestFramework.IUnitTestElement Accept(JetBrains.ReSharper.UnitTestRunner.nUnit.NUnitTestTask task, out JetBrains.ProjectModel.IProject project) { }
    }
}