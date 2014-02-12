[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]

namespace JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport
{
    
    public class AssemblyExporter : JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.IAssemblyExporter
    {
        public AssemblyExporter([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Caches.ISymbolCache symbolCache, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Modules.IPsiModules psiModules, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Feature.Services.ExternalSources.Pdb.Cache.IPdbCacheManager pdbCacheManager, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.IShellLocks shellLocks, JetBrains.Application.Env.RunsProducts.ProductConfigurations configurations, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.model2.Assemblies.AssemblyToAssemblyResolvers.AssemblyToAssemblyReferencesResolveManager assemblyToAssemblyReferencesResolveManager) { }
        public JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.ProjFile Export(JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.IAssemblyExportParameters assemblyExportParameters, JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
        protected virtual System.Guid GenerateGuid(bool generateEmptyGuid) { }
        protected virtual JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.ProjFile SaveProject(JetBrains.Util.FileSystemPath rootFolder) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class AssemblyExporterManager : JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.IAssemblyExporter, JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.IAssemblyExporterManager
    {
        public AssemblyExporterManager(JetBrains.ReSharper.Psi.Caches.ISymbolCache symbolCache, JetBrains.ReSharper.Psi.Modules.IPsiModules psiModules, JetBrains.ReSharper.Feature.Services.ExternalSources.Pdb.Cache.IPdbCacheManager pdbCacheManager, JetBrains.Application.IShellLocks shellLocks, JetBrains.Application.Env.RunsProducts.ProductConfigurations configurations, JetBrains.ProjectModel.model2.Assemblies.AssemblyToAssemblyResolvers.AssemblyToAssemblyReferencesResolveManager assemblyToAssemblyReferencesResolveManager) { }
        public JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.ProjFile Export(JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.IAssemblyExportParameters assemblyExportParameters, JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
    }
    public class AssemblyExportParameters : JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.IAssemblyExportParameters
    {
        public AssemblyExportParameters(JetBrains.ProjectModel.Model2.Assemblies.Interfaces.IAssemblyFile assemblyFile, JetBrains.Util.FileSystemPath folder, JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.FolderIsNotEmptyAction folderIsNotEmptyChoice, string projectName, bool createSolution = True, bool performDecompilation = True, bool generateEmptyGuid = False, bool writeBoundAssemblyComment = True) { }
        public JetBrains.ProjectModel.Model2.Assemblies.Interfaces.IAssemblyFile AssemblyFile { get; }
        public bool CreateSolution { get; }
        public JetBrains.Util.FileSystemPath Folder { get; }
        public JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.FolderIsNotEmptyAction FolderIsNotEmptyChoice { get; }
        public bool GenerateEmptyGuid { get; }
        public bool PerformDecompilation { get; }
        public string ProjectName { get; }
        public bool WriteBoundAssemblyComment { get; }
        public bool Check() { }
        public override string ToString() { }
    }
    public class CSharpAssemblyExportMetadataRenderer : JetBrains.Decompiler.Render.CSharp.MetadataRenderer
    {
        public CSharpAssemblyExportMetadataRenderer(JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Metadata.Reader.API.IMetadataAssembly assembly, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Decompiler.Render.ICodeTextWriter writer, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Decompiler.ClassDecompilerOptions options, JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext context) { }
        protected override JetBrains.Metadata.Reader.API.IMetadataCustomAttribute[] ExtraFilterCustomAttributes(JetBrains.Metadata.Reader.API.IMetadataCustomAttribute[] attributes) { }
        protected override void WriteComments() { }
        protected override void WriteModuleAttributes() { }
    }
    public class CSharpAssemblyExportMetadataTranslator : JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.MetadataTranslator.CSharpMetadataTranslator
    {
        protected override JetBrains.Decompiler.Render.CSharp.MetadataRenderer CreateMetadataRenderer(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Metadata.Reader.API.IMetadataAssembly assembly, JetBrains.Decompiler.Render.CSharp.OptimizeImportsCodeTextWriter writer, JetBrains.Decompiler.ClassDecompilerOptions options, JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext context) { }
    }
    public enum FolderIsNotEmptyAction
    {
        RewriteExistingFiles = 0,
        DeleteFolderContent = 1,
    }
    public interface IAssemblyExporter
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.ProjFile Export(JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.IAssemblyExportParameters assemblyExportParameters, JetBrains.Application.Progress.IProgressIndicator progressIndicator);
    }
    public interface IAssemblyExporterManager : JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.IAssemblyExporter { }
    public interface IAssemblyExportParameters
    {
        JetBrains.ProjectModel.Model2.Assemblies.Interfaces.IAssemblyFile AssemblyFile { get; }
        bool CreateSolution { get; }
        JetBrains.Util.FileSystemPath Folder { get; }
        JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.FolderIsNotEmptyAction FolderIsNotEmptyChoice { get; }
        bool GenerateEmptyGuid { get; }
        bool PerformDecompilation { get; }
        string ProjectName { get; }
        bool WriteBoundAssemblyComment { get; }
        bool Check();
    }
    public interface INodeData
    {
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.Util.FileSystemPath Path { get; }
    }
    public class static ProjFileGenerator
    {
        public const string BoundAssemblyComment = "Project was exported from assembly: ";
        public const string GeneratorMsBuildCompile = "MSBuild:Compile";
        public const string MsBuildBinPathProperty = "MSBuildBinPath";
        public const string MsBuildToolsPathProperty = "MSBuildToolsPath";
        public static void AddAssemblyInfo(this JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.ElementNodes.PropertyGroupElement propertyGroup, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.Model2.Assemblies.Interfaces.IAssembly assembly, System.Guid projectGuid) { }
        public static JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.ElementNodes.ItemGroupElement AddItemGroup(this JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.ElementNodes.ProjectElement rootElement, string itemsName, System.Collections.Generic.IEnumerable<string> itemIncludes, System.Action<JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.ElementNodes.ItemElement> itemMetadataAdder = null) { }
        public static void AddItems(this JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.ElementNodes.ItemGroupElement itemGroup, string itemsName, System.Collections.Generic.IEnumerable<string> itemIncludes, System.Action<JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.ElementNodes.ItemElement> itemMetadataAdder = null) { }
        public static void AddNonEmptyRootNamespace(this JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.ElementNodes.PropertyGroupElement propertyGroup, JetBrains.ReSharper.Psi.INamespace rootNamespace) { }
        public static void AddReferences(this JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.ElementNodes.ItemGroupElement itemGroup, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileReference> references) { }
        public static JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.Attributes.ProjFileElementAttribute ConditionEqAttribute(string stringA, string stringB) { }
        public static JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.ElementNodes.PropertyGroupElement GenerateConfigurationPlatformPropertyGroup(string configuration, string platform, JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.Properties.IProjFileProperties properties) { }
        public static JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.ElementNodes.ProjectElement GenerateProjectElement(JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.Properties.IProjFileProperties properties) { }
        public static JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.ElementNodes.ProjFileRoot GenerateProjFileRoot(JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.Properties.IProjFileProperties properties) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static string GetApplicationVersion(JetBrains.ProjectModel.Model2.Assemblies.Interfaces.IAssembly assembly) { }
        public static string GetFrameworkProfile(JetBrains.ProjectModel.Model2.Assemblies.Interfaces.IAssembly assembly) { }
        public static System.Version GetFrameworkVersion(JetBrains.ProjectModel.Model2.Assemblies.Interfaces.IAssembly assembly) { }
        public static string GetFrameworkVersionString(JetBrains.ProjectModel.Model2.Assemblies.Interfaces.IAssembly assembly) { }
        public static string GetOutputType(JetBrains.ProjectModel.Model2.Assemblies.Interfaces.IAssembly assembly) { }
        public static string GetPlatform(System.Reflection.ProcessorArchitecture processorArchitecture) { }
        public static string GetPlatform(JetBrains.ProjectModel.Model2.Assemblies.Interfaces.IAssembly assembly) { }
        public static System.Version GetToolsVersion(JetBrains.ProjectModel.Model2.Assemblies.Interfaces.IAssembly assembly) { }
        public static string GetToolsVersionString(JetBrains.ProjectModel.Model2.Assemblies.Interfaces.IAssembly assembly) { }
        public static string GuidValue(System.Guid guid) { }
    }
    public class static ProjFileReader
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.ElementNodes.ProjFileRoot ImportFromXmlDocument(System.Xml.XmlDocument document) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.ElementNodes.ProjFileRoot ReadFromFile(JetBrains.Util.FileSystemPath projFilePath) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.Util.FileSystemPath TryReadBoundAssemblyPath(JetBrains.Util.FileSystemPath projFilePath) { }
    }
    public class ProjFileReference
    {
        public ProjFileReference([JetBrains.Annotations.NotNullAttribute()] string reference, [JetBrains.Annotations.CanBeNullAttribute()] string hintPath = null) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public string HintPath { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public string Reference { get; }
    }
    public class static SolutionFileGenerator
    {
        public static void SaveSolutionFile(JetBrains.Util.FileSystemPath solutionFilePath, JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.ProjFile projFile) { }
    }
    public class TypesAnalizer
    {
        public TypesAnalizer([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.Model2.Assemblies.Interfaces.IAssemblyFile assemblyFile, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Modules.IPsiModules psiModules, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Caches.ISymbolCache symbolCache) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Psi.INamespace DefaultNamespace { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.ITypeElement> Types { get; }
        public int TypesCount { get; }
    }
}
namespace JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.Mappings
{
    
    public class NamespaceFolderMappings
    {
        public NamespaceFolderMappings([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.INamespace defaultNamespace) { }
        public void AddMapping([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.INamespace ns, string folder) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public string GetFolder([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.INamespace ns) { }
    }
    public class TypeFileMappings
    {
        public TypeFileMappings(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.ITypeElement> types, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.INamespace defaultNamespace, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Feature.Services.ExternalSources.Pdb.PdbInfo pdbInfo) { }
        public TypeFileMappings([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.Model2.Assemblies.Interfaces.IAssemblyFile assemblyFile, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Modules.IPsiModules psiModules, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Caches.ISymbolCache symbolCache, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Feature.Services.ExternalSources.Pdb.Cache.IPdbCacheManager pdbCacheManager, [JetBrains.Annotations.CanBeNullAttribute()] System.Collections.Generic.IEnumerable<string> xamlFiles = null) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Psi.INamespace DefaultNamespace { get; }
        public void BindXamlFiles(System.Collections.Generic.IEnumerable<string> xamlFiles) { }
        public bool Contains(string file) { }
        public System.Collections.Generic.IEnumerable<string> GetAllFiles() { }
        public System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.ITypeElement> GetAllTypes() { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public string GetAssemblyInfoFile() { }
        public string GetFolder(JetBrains.ReSharper.Psi.INamespace ns) { }
        public void SetAssemblyInfoFileName(string assemblyInfoFile) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public System.Collections.Generic.IEnumerable<string> TryGetBoundXamlFiles(string file) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public string TryGetFile(JetBrains.ReSharper.Psi.ITypeElement type) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.ITypeElement> TryGetTypes(string file) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public string TryGetXamlFile(JetBrains.ReSharper.Psi.ITypeElement type) { }
    }
    public class UniqueFilePathGenerator
    {
        public UniqueFilePathGenerator() { }
        public bool Contains(string filePath) { }
        public bool Delete(string filePath) { }
        public string Generate(JetBrains.ReSharper.Psi.ITypeElement typeElement, string relativeFolderPath) { }
        public string Generate(string relativeFilePath) { }
        public string Generate(string suggestedFileName, string relativeFolderPath) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.Attributes
{
    
    public class ProjFileAttributeUsageInfo
    {
        public const string VariousNames = "";
        public ProjFileAttributeUsageInfo([JetBrains.Annotations.NotNullAttribute()] string name, [JetBrains.Annotations.CanBeNullAttribute()] System.Func<string, bool> valueChecker = null, bool required = False, [JetBrains.Annotations.CanBeNullAttribute()] string alternativeAttributeName = null) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public string AlternativeAttributeName { get; }
        public string Name { get; }
        public bool Required { get; }
        public bool CheckValue(string value) { }
        public override string ToString() { }
    }
    public class ProjFileElementAttribute
    {
        public ProjFileElementAttribute([JetBrains.Annotations.NotNullAttribute()] string name, [JetBrains.Annotations.NotNullAttribute()] string value) { }
        public string Name { get; }
        public string Value { get; }
        public override bool Equals(object obj) { }
        public bool Equals(JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.Attributes.ProjFileElementAttribute other) { }
        public override int GetHashCode() { }
        public override string ToString() { }
    }
    public class ProjFileElementConditionAttribute : JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.Attributes.ProjFileElementAttribute
    {
        public ProjFileElementConditionAttribute(string condition) { }
    }
    public class ProjFileElementIncludeAttribute : JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.Attributes.ProjFileElementAttribute
    {
        public ProjFileElementIncludeAttribute(string include) { }
    }
    public class ProjFileElementNameAttribute : JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.Attributes.ProjFileElementAttribute
    {
        public ProjFileElementNameAttribute(string name) { }
    }
    public class ProjFileElementProjectAttribute : JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.Attributes.ProjFileElementAttribute
    {
        public ProjFileElementProjectAttribute(string project) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.ElementNodes
{
    
    public sealed class ChooseElement : JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.ElementNodes.ProjFileElement
    {
        public ChooseElement() { }
        public override bool CheckChild(JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.ElementNodes.ProjFileElement testedElement) { }
        protected override JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.ElementNodes.ProjFileElement CreateChild(string childName, string childValue, params JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.Attributes.ProjFileElementAttribute[] childAttributes) { }
        protected override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.Attributes.ProjFileAttributeUsageInfo> GetAttributeUsageInfos() { }
    }
    public sealed class ImportElement : JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.ElementNodes.ProjFileElement
    {
        public ImportElement(params JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.Attributes.ProjFileElementAttribute[] attributes) { }
        public override bool CheckChild(JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.ElementNodes.ProjFileElement testedElement) { }
        protected override JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.ElementNodes.ProjFileElement CreateChild(string childName, string childValue, params JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.Attributes.ProjFileElementAttribute[] childAttributes) { }
        protected override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.Attributes.ProjFileAttributeUsageInfo> GetAttributeUsageInfos() { }
    }
    public sealed class ImportGroupElement : JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.ElementNodes.ProjFileElement
    {
        public ImportGroupElement(params JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.Attributes.ProjFileElementAttribute[] attributes) { }
        public override bool CheckChild(JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.ElementNodes.ProjFileElement testedElement) { }
        protected override JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.ElementNodes.ProjFileElement CreateChild(string childName, string childValue, params JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.Attributes.ProjFileElementAttribute[] childAttributes) { }
        protected override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.Attributes.ProjFileAttributeUsageInfo> GetAttributeUsageInfos() { }
    }
    public interface IProjFileElementChild
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.ElementNodes.ProjFileElement Parent { get; }
        void Write(System.Xml.XmlWriter xmlWriter);
    }
    public sealed class ItemDefinitionElement : JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.ElementNodes.ProjFileElement
    {
        public ItemDefinitionElement([JetBrains.Annotations.NotNullAttribute()] string name, params JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.Attributes.ProjFileElementAttribute[] attributes) { }
        public override bool CheckChild(JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.ElementNodes.ProjFileElement testedElement) { }
        protected override JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.ElementNodes.ProjFileElement CreateChild(string childName, string childValue, params JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.Attributes.ProjFileElementAttribute[] childAttributes) { }
        protected override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.Attributes.ProjFileAttributeUsageInfo> GetAttributeUsageInfos() { }
    }
    public sealed class ItemDefinitionGroupElement : JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.ElementNodes.ProjFileElement
    {
        public ItemDefinitionGroupElement(params JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.Attributes.ProjFileElementAttribute[] attributes) { }
        public override bool CheckChild(JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.ElementNodes.ProjFileElement testedElement) { }
        protected override JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.ElementNodes.ProjFileElement CreateChild(string childName, string childValue, params JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.Attributes.ProjFileElementAttribute[] childAttributes) { }
        protected override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.Attributes.ProjFileAttributeUsageInfo> GetAttributeUsageInfos() { }
    }
    public sealed class ItemElement : JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.ElementNodes.ProjFileElement
    {
        public ItemElement([JetBrains.Annotations.NotNullAttribute()] string name, params JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.Attributes.ProjFileElementAttribute[] attributes) { }
        public string Include { get; }
        public override bool CheckChild(JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.ElementNodes.ProjFileElement testedElement) { }
        protected override JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.ElementNodes.ProjFileElement CreateChild(string childName, string childValue, params JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.Attributes.ProjFileElementAttribute[] childAttributes) { }
        protected override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.Attributes.ProjFileAttributeUsageInfo> GetAttributeUsageInfos() { }
    }
    public sealed class ItemGroupElement : JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.ElementNodes.ProjFileElement
    {
        public ItemGroupElement(params JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.Attributes.ProjFileElementAttribute[] attributes) { }
        public override bool CheckChild(JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.ElementNodes.ProjFileElement testedElement) { }
        protected override JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.ElementNodes.ProjFileElement CreateChild(string childName, string childValue, params JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.Attributes.ProjFileElementAttribute[] childAttributes) { }
        protected override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.Attributes.ProjFileAttributeUsageInfo> GetAttributeUsageInfos() { }
    }
    public sealed class ItemMetadataElement : JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.ElementNodes.ProjFileElement
    {
        public ItemMetadataElement([JetBrains.Annotations.NotNullAttribute()] string name, [JetBrains.Annotations.NotNullAttribute()] string value, params JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.Attributes.ProjFileElementAttribute[] attributes) { }
        public override bool CheckChild(JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.ElementNodes.ProjFileElement testedElement) { }
        protected override JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.ElementNodes.ProjFileElement CreateChild(string childName, string childValue, params JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.Attributes.ProjFileElementAttribute[] childAttributes) { }
        protected override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.Attributes.ProjFileAttributeUsageInfo> GetAttributeUsageInfos() { }
    }
    public sealed class OnErrorElement : JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.ElementNodes.ProjFileElement
    {
        public OnErrorElement(params JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.Attributes.ProjFileElementAttribute[] attributes) { }
        public override bool CheckChild(JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.ElementNodes.ProjFileElement testedElement) { }
        protected override JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.ElementNodes.ProjFileElement CreateChild(string childName, string childValue, params JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.Attributes.ProjFileElementAttribute[] childAttributes) { }
        protected override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.Attributes.ProjFileAttributeUsageInfo> GetAttributeUsageInfos() { }
    }
    public sealed class OtherwiseElement : JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.ElementNodes.ProjFileElement
    {
        public OtherwiseElement() { }
        public override bool CheckChild(JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.ElementNodes.ProjFileElement testedElement) { }
        protected override JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.ElementNodes.ProjFileElement CreateChild(string childName, string childValue, params JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.Attributes.ProjFileElementAttribute[] childAttributes) { }
        protected override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.Attributes.ProjFileAttributeUsageInfo> GetAttributeUsageInfos() { }
    }
    public class OtherXmlElement : JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.ElementNodes.ProjFileElement
    {
        public OtherXmlElement([JetBrains.Annotations.NotNullAttribute()] string name, [JetBrains.Annotations.NotNullAttribute()] string value, params JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.Attributes.ProjFileElementAttribute[] attributes) { }
        public override bool CheckChild(JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.ElementNodes.ProjFileElement testedElement) { }
        protected override JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.ElementNodes.ProjFileElement CreateChild(string childName, string childValue, params JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.Attributes.ProjFileElementAttribute[] childAttributes) { }
        protected override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.Attributes.ProjFileAttributeUsageInfo> GetAttributeUsageInfos() { }
    }
    public sealed class OutputElement : JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.ElementNodes.ProjFileElement
    {
        public OutputElement(params JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.Attributes.ProjFileElementAttribute[] attributes) { }
        public override bool CheckChild(JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.ElementNodes.ProjFileElement testedElement) { }
        protected override JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.ElementNodes.ProjFileElement CreateChild(string childName, string childValue, params JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.Attributes.ProjFileElementAttribute[] childAttributes) { }
        protected override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.Attributes.ProjFileAttributeUsageInfo> GetAttributeUsageInfos() { }
    }
    public sealed class ParameterElement : JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.ElementNodes.ProjFileElement
    {
        public ParameterElement([JetBrains.Annotations.NotNullAttribute()] string name, params JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.Attributes.ProjFileElementAttribute[] attributes) { }
        public override bool CheckChild(JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.ElementNodes.ProjFileElement testedElement) { }
        protected override JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.ElementNodes.ProjFileElement CreateChild(string childName, string childValue, params JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.Attributes.ProjFileElementAttribute[] childAttributes) { }
        protected override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.Attributes.ProjFileAttributeUsageInfo> GetAttributeUsageInfos() { }
    }
    public sealed class ParameterGroupElement : JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.ElementNodes.ProjFileElement
    {
        public ParameterGroupElement() { }
        public override bool CheckChild(JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.ElementNodes.ProjFileElement testedElement) { }
        protected override JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.ElementNodes.ProjFileElement CreateChild(string childName, string childValue, params JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.Attributes.ProjFileElementAttribute[] childAttributes) { }
        protected override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.Attributes.ProjFileAttributeUsageInfo> GetAttributeUsageInfos() { }
    }
    public sealed class ProjectElement : JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.ElementNodes.ProjFileElement
    {
        public ProjectElement(params JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.Attributes.ProjFileElementAttribute[] attributes) { }
        public override bool CheckChild(JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.ElementNodes.ProjFileElement testedElement) { }
        protected override JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.ElementNodes.ProjFileElement CreateChild(string childName, string childValue, params JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.Attributes.ProjFileElementAttribute[] childAttributes) { }
        protected override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.Attributes.ProjFileAttributeUsageInfo> GetAttributeUsageInfos() { }
        protected override void WriteStartElement(System.Xml.XmlWriter xmlWriter) { }
    }
    public sealed class ProjectExtensionsElement : JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.ElementNodes.ProjFileElement
    {
        public ProjectExtensionsElement([JetBrains.Annotations.NotNullAttribute()] string value) { }
        public override bool CheckChild(JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.ElementNodes.ProjFileElement testedElement) { }
        protected override JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.ElementNodes.ProjFileElement CreateChild(string childName, string childValue, params JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.Attributes.ProjFileElementAttribute[] childAttributes) { }
        protected override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.Attributes.ProjFileAttributeUsageInfo> GetAttributeUsageInfos() { }
    }
    public class ProjFileComment : JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.ElementNodes.IProjFileElementChild
    {
        public ProjFileComment(string comment, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.ElementNodes.ProjFileElement parent) { }
        public string Comment { get; }
        public JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.ElementNodes.ProjFileElement Parent { get; }
        public void Write(System.Xml.XmlWriter xmlWriter) { }
    }
    public abstract class ProjFileElement : JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.ElementNodes.IProjFileElementChild
    {
        public const string NoValue = "";
        protected ProjFileElement([JetBrains.Annotations.NotNullAttribute()] string name, [JetBrains.Annotations.NotNullAttribute()] string value, params JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.Attributes.ProjFileElementAttribute[] attributes) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.Attributes.ProjFileElementAttribute> Attributes { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.ElementNodes.ProjFileComment> ChildComments { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.ElementNodes.ProjFileElement> ChildElements { get; }
        public string Name { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.ElementNodes.ProjFileElement Parent { get; set; }
        public string Value { get; }
        public JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.ElementNodes.ProjFileElement AddChild([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.ElementNodes.ProjFileElement child) { }
        public JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.ElementNodes.ProjFileComment AddChildComment(string comment) { }
        public abstract bool CheckChild([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.ElementNodes.ProjFileElement testedElement);
        public bool CheckParent([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.ElementNodes.ProjFileElement testedElement) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        protected abstract JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.ElementNodes.ProjFileElement CreateChild([JetBrains.Annotations.NotNullAttribute()] string childName, [JetBrains.Annotations.NotNullAttribute()] string childValue, params JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.Attributes.ProjFileElementAttribute[] childAttributes);
        protected abstract System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.Attributes.ProjFileAttributeUsageInfo> GetAttributeUsageInfos();
        [JetBrains.Annotations.CanBeNullAttribute()]
        public string GetAttributeValue(string attributeName) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.ElementNodes.ProjFileElement> GetChildElements(string name) { }
        public System.Collections.Generic.IEnumerable<string> GetPossibleAttributeNames() { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.Attributes.ProjFileAttributeUsageInfo> GetPossibleAttributeUsageInfos() { }
        public bool HasChildComments() { }
        public bool HasChildElements() { }
        public override string ToString() { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.ElementNodes.ProjFileElement TryAddChild([JetBrains.Annotations.NotNullAttribute()] string childName, [JetBrains.Annotations.NotNullAttribute()] string childValue, params JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.Attributes.ProjFileElementAttribute[] childAttributes) { }
        public void Write(System.Xml.XmlWriter xmlWriter) { }
        protected virtual void WriteAttributes(System.Xml.XmlWriter xmlWriter) { }
        protected virtual void WriteChildren(System.Xml.XmlWriter xmlWriter) { }
        protected virtual void WriteEndElement(System.Xml.XmlWriter xmlWriter) { }
        protected virtual void WriteStartElement(System.Xml.XmlWriter xmlWriter) { }
        protected virtual void WriteValue(System.Xml.XmlWriter xmlWriter) { }
    }
    public class ProjFileElementChildren
    {
        public ProjFileElementChildren() { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.ElementNodes.ProjFileComment> Comments { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.ElementNodes.ProjFileElement> Elements { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.ElementNodes.IProjFileElementChild> ElementsAndComments { get; }
        public void AddComment(JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.ElementNodes.ProjFileComment comment) { }
        public void AddElement(JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.ElementNodes.ProjFileElement element) { }
        public bool HasChildComments() { }
        public bool HasChildElements() { }
    }
    public class ProjFileRoot : JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.ElementNodes.ProjFileElement
    {
        public ProjFileRoot() { }
        public override bool CheckChild(JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.ElementNodes.ProjFileElement testedElement) { }
        protected override JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.ElementNodes.ProjFileElement CreateChild(string childName, string childValue, params JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.Attributes.ProjFileElementAttribute[] childAttributes) { }
        protected override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.Attributes.ProjFileAttributeUsageInfo> GetAttributeUsageInfos() { }
        protected override void WriteEndElement(System.Xml.XmlWriter xmlWriter) { }
        protected override void WriteStartElement(System.Xml.XmlWriter xmlWriter) { }
    }
    public sealed class PropertyElement : JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.ElementNodes.ProjFileElement
    {
        public PropertyElement([JetBrains.Annotations.NotNullAttribute()] string name, [JetBrains.Annotations.NotNullAttribute()] string value, params JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.Attributes.ProjFileElementAttribute[] attributes) { }
        public override bool CheckChild(JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.ElementNodes.ProjFileElement testedElement) { }
        protected override JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.ElementNodes.ProjFileElement CreateChild(string childName, string childValue, params JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.Attributes.ProjFileElementAttribute[] childAttributes) { }
        protected override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.Attributes.ProjFileAttributeUsageInfo> GetAttributeUsageInfos() { }
    }
    public sealed class PropertyGroupElement : JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.ElementNodes.ProjFileElement
    {
        public PropertyGroupElement(params JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.Attributes.ProjFileElementAttribute[] attributes) { }
        public override bool CheckChild(JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.ElementNodes.ProjFileElement testedElement) { }
        protected override JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.ElementNodes.ProjFileElement CreateChild(string childName, string childValue, params JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.Attributes.ProjFileElementAttribute[] childAttributes) { }
        protected override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.Attributes.ProjFileAttributeUsageInfo> GetAttributeUsageInfos() { }
    }
    public sealed class TargetElement : JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.ElementNodes.ProjFileElement
    {
        public TargetElement(params JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.Attributes.ProjFileElementAttribute[] attributes) { }
        public override bool CheckChild(JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.ElementNodes.ProjFileElement testedElement) { }
        protected override JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.ElementNodes.ProjFileElement CreateChild(string childName, string childValue, params JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.Attributes.ProjFileElementAttribute[] childAttributes) { }
        protected override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.Attributes.ProjFileAttributeUsageInfo> GetAttributeUsageInfos() { }
    }
    public sealed class TaskBodyElement : JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.ElementNodes.ProjFileElement
    {
        public TaskBodyElement([JetBrains.Annotations.NotNullAttribute()] string value, params JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.Attributes.ProjFileElementAttribute[] attributes) { }
        public override bool CheckChild(JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.ElementNodes.ProjFileElement testedElement) { }
        protected override JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.ElementNodes.ProjFileElement CreateChild(string childName, string childValue, params JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.Attributes.ProjFileElementAttribute[] childAttributes) { }
        protected override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.Attributes.ProjFileAttributeUsageInfo> GetAttributeUsageInfos() { }
    }
    public sealed class TaskElement : JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.ElementNodes.ProjFileElement
    {
        public TaskElement([JetBrains.Annotations.NotNullAttribute()] string name, params JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.Attributes.ProjFileElementAttribute[] attributes) { }
        public override bool CheckChild(JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.ElementNodes.ProjFileElement testedElement) { }
        protected override JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.ElementNodes.ProjFileElement CreateChild(string childName, string childValue, params JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.Attributes.ProjFileElementAttribute[] childAttributes) { }
        protected override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.Attributes.ProjFileAttributeUsageInfo> GetAttributeUsageInfos() { }
    }
    public sealed class UsingTaskElement : JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.ElementNodes.ProjFileElement
    {
        public UsingTaskElement(params JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.Attributes.ProjFileElementAttribute[] attributes) { }
        public override bool CheckChild(JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.ElementNodes.ProjFileElement testedElement) { }
        protected override JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.ElementNodes.ProjFileElement CreateChild(string childName, string childValue, params JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.Attributes.ProjFileElementAttribute[] childAttributes) { }
        protected override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.Attributes.ProjFileAttributeUsageInfo> GetAttributeUsageInfos() { }
    }
    public sealed class WhenElement : JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.ElementNodes.ProjFileElement
    {
        public WhenElement(params JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.Attributes.ProjFileElementAttribute[] attributes) { }
        public override bool CheckChild(JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.ElementNodes.ProjFileElement testedElement) { }
        protected override JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.ElementNodes.ProjFileElement CreateChild(string childName, string childValue, params JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.Attributes.ProjFileElementAttribute[] childAttributes) { }
        protected override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.Attributes.ProjFileAttributeUsageInfo> GetAttributeUsageInfos() { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel
{
    
    public class FolderElement
    {
        public FolderElement(JetBrains.Util.FileSystemPath path, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.FolderElement parent) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.FolderElement> ChildFolders { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.LinkedItemElement> ChildItems { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.FolderElement Parent { get; }
        public JetBrains.Util.FileSystemPath Path { get; }
        public void AddChildItem(JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.LinkedItemElement linkedItem) { }
        public override string ToString() { }
    }
    public class LinkedItemElement
    {
        public LinkedItemElement(JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.ElementNodes.ItemElement item, JetBrains.Util.FileSystemPath path) { }
        public JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.ElementNodes.ItemElement Item { get; }
        public JetBrains.Util.FileSystemPath Path { get; }
        public override string ToString() { }
    }
    public class ProjFile : JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.INodeData
    {
        public ProjFile(JetBrains.Util.FileSystemPath projFilePath, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ProjectModel.Model2.Assemblies.Interfaces.IAssembly assembly, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Modules.IPsiModules psiModules = null, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Caches.ISymbolCache symbolCache = null, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Feature.Services.ExternalSources.Pdb.Cache.IPdbCacheManager pdbCacheManager = null) { }
        public ProjFile(JetBrains.Util.FileSystemPath rootFolder, string projectName, JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.Properties.IProjFileProperties properties) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ProjectModel.Model2.Assemblies.Interfaces.IAssembly Assembly { get; }
        public string DefaultNamespace { get; }
        public string DefaultNamespaceFolderName { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.ElementNodes.ProjectElement GetProjectElement { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.LinkedItemElement> LinkedItems { get; }
        public JetBrains.Util.FileSystemPath Path { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.ElementNodes.PropertyElement> Properties { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.ElementNodes.ItemElement> References { get; }
        public JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.FolderElement RootFolderElement { get; }
        public bool Equals(JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.ProjFile other) { }
        public override bool Equals(object obj) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.Util.FileSystemPath GetFolder(JetBrains.ReSharper.Psi.INamespace ns) { }
        public override int GetHashCode() { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.ElementNodes.PropertyElement> GetPropertyElements(string propertyName) { }
        public string GetRelativePath(JetBrains.Util.FileSystemPath path) { }
        public override string ToString() { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public string TryGetFile(JetBrains.ReSharper.Psi.ITypeElement type) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public string TryGetPropertyValue(string propertyName) { }
    }
    public class static ProjFileExtensions
    {
        public static string GetAssemblyName(this JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.ProjFile projFile) { }
        public static string GetDefaultConfiguration(this JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.ProjFile projFile) { }
        public static string GetDefaultPlatform(this JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.ProjFile projFile) { }
        public static string GetOutputType(this JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.ProjFile projFile) { }
        public static JetBrains.Util.FileSystemPath GetPath(this JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.ProjFile projFile, [JetBrains.Annotations.CanBeNullAttribute()] string relativePath) { }
        public static JetBrains.Util.FileSystemPath GetPath(this JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.ProjFile projFile, JetBrains.ReSharper.Psi.ITypeElement typeElement) { }
        public static System.Guid GetProjectGuid(this JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.ProjFile projFile) { }
        public static string GetTargetFrameworkProfile(this JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.ProjFile projFile) { }
        public static string GetTargetFrameworkVersion(this JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.ProjFile projFile) { }
        public static string GetToolsVersion(this JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileModel.ProjFile projFile) { }
    }
    public class static ProjFileUtil
    {
        public const string ConfigurationAllConfigurations = "All Configurations";
        public const string ConfigurationDebug = "Debug";
        public const string ConfigurationRelease = "Release";
        public const string DebugTypeFull = "full";
        public const string DebugTypeNone = "none";
        public const string DebugTypePdbonly = "pdbonly";
        public const string DefaultFileAlignment = "512";
        public const string DefaultTargetFrameworkVersion = "v3.0";
        public const string DefaultToolsVersion = "3.0";
        public const string DefaultWarningLevel = "4";
        public const string DefineConstantDebug = "DEBUG";
        public const string DefineConstantTrace = "TRACE";
        public const string ErrorReportPrompt = "prompt";
        public const string PlatformAnyCpu = "AnyCPU";
        public const string PlatformAnyCpu32BitPreferred = "anycpu32bitpreferred";
        public const string PlatformArm = "ARM";
        public const string PlatformItanium = "Itanium";
        public const string PlatformWin32 = "Win32";
        public const string PlatformX64 = "x64";
        public const string PlatformX86 = "x86";
        public const string TargetBuild = "Build";
        public const string TargetFrameworkVersion45 = "v4.5";
        public const string ValueDelimeter = ";";
        public const string ValueFalse = "false";
        public const string ValueTrue = "true";
        public const string VerticalBarSymbol = "|";
        public static string CombineValues(string valueA, string valueB) { }
        public static string ConditionEqString(string parameter, string value) { }
        public static string ConditionString(string parameter, string value, string comparisonSymbol) { }
        public static string ItemListReference(string itemName) { }
        public static string MetadataReference(string metadataName) { }
        public static string PropertyReference(string propertyName) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.Properties
{
    
    public interface IProjFileProperties
    {
        bool AllowUnsafeBlocks { get; }
        JetBrains.ProjectModel.Model2.Assemblies.Interfaces.IAssembly Assembly { get; }
        System.Collections.Generic.IEnumerable<string> EmbeddedResources { get; }
        System.Guid ProjectGuid { get; }
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileReference> References { get; }
        System.Collections.Generic.IEnumerable<string> Resources { get; }
        JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.Mappings.TypeFileMappings Sources { get; }
        bool WriteBoundAssemblyComment { get; }
        System.Collections.Generic.IEnumerable<string> XamlResources { get; }
    }
    public class ProjFileProperties : JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.Properties.IProjFileProperties
    {
        public ProjFileProperties(System.Guid projectGuid, JetBrains.ProjectModel.Model2.Assemblies.Interfaces.IAssembly assembly, JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.Mappings.TypeFileMappings sources, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileReference> references, System.Collections.Generic.IEnumerable<string> resources, System.Collections.Generic.IEnumerable<string> embeddedResources, System.Collections.Generic.IEnumerable<string> xamlResources, bool allowUnsafeBlocks, bool writeBoundAssemblyComment) { }
        public bool AllowUnsafeBlocks { get; }
        public JetBrains.ProjectModel.Model2.Assemblies.Interfaces.IAssembly Assembly { get; }
        public System.Collections.Generic.IEnumerable<string> EmbeddedResources { get; }
        public System.Guid ProjectGuid { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ProjFileReference> References { get; }
        public System.Collections.Generic.IEnumerable<string> Resources { get; }
        public JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.Mappings.TypeFileMappings Sources { get; }
        public bool WriteBoundAssemblyComment { get; }
        public System.Collections.Generic.IEnumerable<string> XamlResources { get; }
    }
}
namespace JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.AssemblyExport.ResourceUtils
{
    
    public class static AssemblyResourcesUtil
    {
        public static JetBrains.Metadata.Reader.API.IManifestResourceDisposition[] GetAssemblyResources([JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.FileSystemPath assemblyLocation) { }
        public static JetBrains.Metadata.Utils.PE.Directories.ResourceDirectoryEntry[] GetWin32DirectoryChildren(JetBrains.Metadata.Utils.PE.Directories.ResourceDirectory root) { }
        public static JetBrains.Metadata.Utils.PE.Directories.ResourceDirectoryEntry[] GetWin32Resources(JetBrains.ProjectModel.Model2.Assemblies.Interfaces.IAssemblyFile assemblyFile) { }
    }
    public enum ResType
    {
        Undefined = 0,
        ResX = 1,
        Xaml = 2,
    }
    public class static ResxUtil
    {
        public static void ConvertResourcesToResx(System.IO.Stream resourcesStream, string resxFilePath) { }
        public static string PresentResxFromBinaryResources(System.IO.Stream resourcesStream) { }
    }
    public class static XamlUtil
    {
        public static void ConvertToXaml(System.IO.Stream bamlStream, JetBrains.Util.FileSystemPath xamlFilePath, JetBrains.Metadata.Reader.API.IMetadataAssembly metadataAssembly) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.MetadataTranslator
{
    
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.CSharp.CSharpLanguage))]
    public class CSharpMetadataTranslator : JetBrains.ReSharper.Feature.Services.ExternalSources.MetadataTranslator.IMetadataTranslator
    {
        public bool IsAvailable { get; }
        public bool IsMethodBodiesDecompilationSupported { get; }
        protected virtual JetBrains.Decompiler.Render.CSharp.MetadataRenderer CreateMetadataRenderer(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Metadata.Reader.API.IMetadataAssembly assembly, JetBrains.Decompiler.Render.CSharp.OptimizeImportsCodeTextWriter writer, JetBrains.Decompiler.ClassDecompilerOptions options, JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext context) { }
        public string TranslateAssemblyInfo(JetBrains.ReSharper.Psi.Modules.IAssemblyPsiModule context, JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext resolveContext) { }
        public string TranslateTopLevelTypeElement(JetBrains.ReSharper.Psi.ITypeElement element, JetBrains.ReSharper.Psi.Modules.IAssemblyPsiModule assemblyPsiModule, JetBrains.ReSharper.Feature.Services.ExternalSources.MetadataTranslator.MetadataTranslatorOptions options, JetBrains.Application.Progress.IProgressIndicator indicator) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.Navigation
{
    
    [JetBrains.ReSharper.Psi.ShellFeaturePartAttribute()]
    public class ExternalSourcesOverloadsContextSearch : JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextSearches.IContextSearch, JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextSearches.IOverloadsContextSearch
    {
        public System.Collections.Generic.IEnumerable<JetBrains.DocumentModel.DocumentRange> GetOverloadRanges(JetBrains.Application.DataContext.IDataContext dataContext) { }
        public bool IsAvailable(JetBrains.Application.DataContext.IDataContext dataContext) { }
        public bool IsContextApplicable(JetBrains.Application.DataContext.IDataContext dataContext) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.ExternalSources.CSharp.Utils
{
    
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.CSharp.CSharpLanguage))]
    public class CSharpDeclaredElementBinder : JetBrains.ReSharper.Feature.Services.ExternalSources.Utils.DeclaredElementBinder
    {
        public override void BindDeclarations(JetBrains.ReSharper.Psi.Tree.IFile file, JetBrains.ReSharper.Psi.Modules.IPsiModule psiModule, bool failOnUnresolvedSymbols) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.CSharp.CSharpLanguage))]
    public class CSharpReorderMembers : JetBrains.ReSharper.Feature.Services.ExternalSources.Utils.IReorderMembers
    {
        public void ReorderMembers(JetBrains.ReSharper.Psi.Tree.IFile file) { }
    }
}