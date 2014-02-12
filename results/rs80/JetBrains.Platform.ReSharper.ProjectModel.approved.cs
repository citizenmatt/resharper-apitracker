[assembly: JetBrains.UI.Icons.CompiledIcons.CompiledIconsPackAttribute(IconNames=new string[] {
        "LayerSolutionPersonal",
        "AssemblyReference",
        "SdkModule",
        "VbasicProj",
        "VbasicProject",
        "CsharpProj",
        "MissingFile",
        "Assembly",
        "Unknown",
        "LayerSolutionShared",
        "CsharpProject",
        "Directory",
        "SolutionFolder"}, IconPackResourceIdentification="JetBrains.Platform.ReSharper.ProjectModel;component/Resources/ProjectModel.Themed" +
    "Icons/ThemedIcons.ProjectModel.Generated.Xaml")]
[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]
[assembly: System.Windows.Markup.XmlnsDefinitionAttribute("urn:shemas-jetbrains-com:ui-application-icons-project-model", "JetBrains.ProjectModel.Resources")]

namespace JetBrains.ProjectModel
{
    
    [JetBrains.ProjectModel.ProjectFileTypeDefinitionAttribute("AppxManifest")]
    public class AppxManifestProjectFileType : JetBrains.ProjectModel.XmlProjectFileType
    {
        public const string APPX_MANIFEST_EXTENSION = ".appxmanifest";
        public static readonly JetBrains.ProjectModel.AppxManifestProjectFileType Instance;
        public const string Name = "AppxManifest";
        protected AppxManifestProjectFileType(string name) { }
        protected AppxManifestProjectFileType(string name, string presentableName) { }
    }
    [JetBrains.ProjectModel.ProjectFileTypeDefinitionAttribute("ASP")]
    public class AspProjectFileType : JetBrains.ProjectModel.HtmlProjectFileType
    {
        public const string ASAX_EXTENSION = ".asax";
        public const string CONTROL_EXTENSION = ".ascx";
        public static readonly JetBrains.ProjectModel.AspProjectFileType Instance;
        public const string MASTER_PAGE_EXTENSION = ".master";
        public const string Name = "ASP";
        public const string PAGE_EXTENSION = ".aspx";
        protected AspProjectFileType(string name) { }
        protected AspProjectFileType(string name, string presentableName) { }
        protected AspProjectFileType(string name, string presentableName, System.Collections.Generic.IEnumerable<string> extensions) { }
    }
    public class AssemblyChange : JetBrains.ProjectModel.ProjectModelChange
    {
        public AssemblyChange(System.Collections.Generic.IList<JetBrains.ProjectModel.ProjectModelChange> deltas, JetBrains.ProjectModel.Model2.Assemblies.Interfaces.IAssembly assembly, JetBrains.ProjectModel.ProjectModelChangeType changeType) { }
        public AssemblyChange(JetBrains.ProjectModel.Model2.Assemblies.Interfaces.IAssembly assembly, JetBrains.ProjectModel.ProjectModelChangeType changeType) { }
        public JetBrains.ProjectModel.Model2.Assemblies.Interfaces.IAssembly Assembly { get; }
        protected override string ElementDescription { get; }
        protected override string ElementPath { get; }
        public override void Accept(JetBrains.ProjectModel.IProjectModelChangeDeltaVisitor visitor) { }
        protected override string GetExtendedDump() { }
        public override JetBrains.ProjectModel.ProjectModelChange Propagate() { }
    }
    public class AssemblyFileChange : JetBrains.ProjectModel.ProjectModelChange
    {
        public AssemblyFileChange(JetBrains.ProjectModel.Model2.Assemblies.Interfaces.IAssemblyFile assemblyFile, JetBrains.ProjectModel.ProjectModelChangeType changeType, JetBrains.ProjectModel.Model2.Assemblies.Interfaces.IAssembly oldAssembly, JetBrains.ProjectModel.Model2.Assemblies.Interfaces.IAssemblyFileData oldData) { }
        public AssemblyFileChange(JetBrains.ProjectModel.Model2.Assemblies.Interfaces.IAssemblyFile assemblyFile, JetBrains.ProjectModel.ProjectModelChangeType changeType) { }
        public JetBrains.ProjectModel.Model2.Assemblies.Interfaces.IAssemblyFile AssemblyFile { get; }
        protected override string ElementDescription { get; }
        protected override string ElementPath { get; }
        public JetBrains.ProjectModel.Model2.Assemblies.Interfaces.IAssembly OldAssembly { get; }
        public JetBrains.ProjectModel.Model2.Assemblies.Interfaces.IAssemblyFileData OldData { get; }
        public override void Accept(JetBrains.ProjectModel.IProjectModelChangeDeltaVisitor visitor) { }
        protected override string GetExtendedDump() { }
        public override JetBrains.ProjectModel.ProjectModelChange Propagate() { }
    }
    [JetBrains.ProjectModel.SolutionInstanceComponentAttribute()]
    public class AssemblyNamesInterner
    {
        public AssemblyNamesInterner() { }
        public string Intern(string value) { }
    }
    public class AssemblyReferenceResolveResult
    {
        public AssemblyReferenceResolveResult([JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.FileSystemPath pathToAssemblyFile) { }
        public JetBrains.Util.FileSystemPath PathToAssemblyFile { get; }
    }
    [JetBrains.ProjectModel.ProjectFileTypeDefinitionAttribute("Asxx")]
    public class AsxxProjectFileType : JetBrains.ProjectModel.KnownProjectFileType
    {
        public const string HANDLER_EXTENSION = ".ashx";
        public static readonly JetBrains.ProjectModel.AsxxProjectFileType Instance;
        public const string Name = "Asxx";
        public const string WCFSERVICE_EXTENSION = ".svc";
        public const string WEBSERVICE_EXTENSION = ".asmx";
        protected AsxxProjectFileType(string name) { }
        protected AsxxProjectFileType(string name, string presentableName) { }
    }
    public class BeforeFilesSavedEventArgs : System.EventArgs
    {
        public BeforeFilesSavedEventArgs(JetBrains.ProjectModel.IProjectFile[] filesToSave) { }
        public bool IsCanceled { get; }
        public void Cancel() { }
        public JetBrains.ProjectModel.IProjectFile[] GetFilesToSave() { }
        public bool NeedSave(JetBrains.ProjectModel.IProjectFile file) { }
        public void SetNeedSave(JetBrains.ProjectModel.IProjectFile file, bool value) { }
    }
    public delegate void BeforeFilesSavedEventHandler(JetBrains.ProjectModel.BeforeFilesSavedEventArgs args);
    public class BeforeMadeWritableEventArgs : System.EventArgs
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly System.Collections.Generic.ICollection<JetBrains.ProjectModel.IProjectFile> FilesToMakeWritable;
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly System.Collections.Generic.ICollection<JetBrains.Util.FileSystemPath> PathsToMakeWritable;
        public readonly System.Collections.Generic.ICollection<JetBrains.ProjectModel.IProjectFile> SkipOpen;
        public BeforeMadeWritableEventArgs([JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.ICollection<JetBrains.ProjectModel.IProjectFile> filesToMakeWritable, [JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.ICollection<JetBrains.Util.FileSystemPath> pathsToMakeWritable, [JetBrains.Annotations.CanBeNullAttribute()] System.Collections.Generic.ICollection<JetBrains.ProjectModel.IProjectFile> skipOpen) { }
        public bool IsEmpty { get; }
        public bool IsInMemoryEditsAllowed { get; set; }
        public string Message { get; set; }
        public JetBrains.Util.EnsureWritableResult Result { get; set; }
    }
    public delegate void BeforeMadeWritableEventHandler(object sender, JetBrains.ProjectModel.BeforeMadeWritableEventArgs args);
    public class BeforeReloadedEventArgs : System.EventArgs
    {
        public BeforeReloadedEventArgs(JetBrains.ProjectModel.IProjectFile projectFile, bool isConflict) { }
        public bool IsCanceled { get; }
        public bool IsConflictWithPersistentVersion { get; }
        public JetBrains.ProjectModel.IProjectFile ProjectFile { get; }
        public JetBrains.Application.Progress.ITaskExecutor TaskExecutor { get; set; }
        public void Cancel() { }
    }
    public delegate void BeforeReloadedEventHandler(JetBrains.ProjectModel.BeforeReloadedEventArgs args);
    public class BeforeSavedEventArgs : System.EventArgs
    {
        public BeforeSavedEventArgs(JetBrains.ProjectModel.IProjectFile projectFile, bool differWithPersistentFile) { }
        public bool IsCanceled { get; }
        public bool IsConflictWithPersistentVersion { get; }
        public JetBrains.ProjectModel.IProjectFile ProjectFile { get; }
        public void Cancel() { }
    }
    public delegate void BeforeSavedEventHandler(JetBrains.ProjectModel.BeforeSavedEventArgs args);
    public enum BuildAction : byte
    {
        CONTENT = 0,
        COMPILE = 1,
        EMBEDDED_RESOURCE = 2,
        NONE = 3,
        APPDESIGNER = 4,
        UNKNOWN = 5,
        XAML_APPLICATION_DEFINITION = 6,
        XAML_PAGE = 7,
        XAML_RESOURCE = 8,
        XAML_DESIGN_DATA = 9,
        XAML_DESIGN_DATA_WITH_TYPES = 10,
        APPX_MANIFEST = 11,
    }
    [JetBrains.ProjectModel.ProjectFileTypeDefinitionAttribute("BuildScript")]
    public class BuildScriptProjectFileType : JetBrains.ProjectModel.XmlProjectFileType
    {
        public static readonly JetBrains.ProjectModel.BuildScriptProjectFileType Instance;
        public const string Name = "BuildScript";
        protected BuildScriptProjectFileType(string name) { }
        protected BuildScriptProjectFileType(string name, string presentableName) { }
        protected BuildScriptProjectFileType(string name, string presentableName, System.Collections.Generic.IEnumerable<string> extensions) { }
    }
    public class CollapseRequest
    {
        public CollapseRequest(JetBrains.ProjectModel.IProjectFolder projectFolder, bool collapseSelf) { }
        public bool CollapseSelf { get; set; }
        public JetBrains.ProjectModel.IProjectFolder ProjectFolder { get; set; }
    }
    [JetBrains.ProjectModel.ProjectFileTypeDefinitionAttribute("CSHARP", Edition="Csharp")]
    public class CSharpProjectFileType : JetBrains.ProjectModel.KnownProjectFileType
    {
        public const string CS_EXTENSION = ".cs";
        public static readonly JetBrains.ProjectModel.CSharpProjectFileType Instance;
        public const string Name = "CSHARP";
        protected CSharpProjectFileType(string name) { }
        protected CSharpProjectFileType(string name, string presentableName) { }
    }
    [JetBrains.ProjectModel.ProjectFileTypeDefinitionAttribute("CSS")]
    public class CssProjectFileType : JetBrains.ProjectModel.KnownProjectFileType
    {
        public const string CSS_EXTENSION = ".css";
        public static readonly JetBrains.ProjectModel.CssProjectFileType Instance;
        public const string Name = "CSS";
        protected CssProjectFileType(string name) { }
        protected CssProjectFileType(string name, string presentableName) { }
    }
    [JetBrains.ProjectModel.ProjectFileTypeDefinitionAttribute("DTD")]
    public class DtdProjectFileType : JetBrains.ProjectModel.XmlProjectFileType
    {
        public const string DTD_EXTENSION = ".dtd";
        public static readonly JetBrains.ProjectModel.DtdProjectFileType Instance;
        public const string Name = "DTD";
        protected DtdProjectFileType(string name) { }
        protected DtdProjectFileType(string name, string presentableName) { }
    }
    [System.FlagsAttribute()]
    public enum ExternalChangeType
    {
        NONE = 0,
        TIMESTAMP = 1,
        EXISTS = 2,
        READONLY = 4,
    }
    public class FileSet
    {
        public FileSet([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.Pattern includePattern, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ProjectModel.Pattern excludePattern, JetBrains.ProjectModel.BuildAction buildAction) { }
        public JetBrains.ProjectModel.BuildAction BuildAction { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ProjectModel.Pattern ExcludePattern { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ProjectModel.Pattern IncludePattern { get; }
        public bool IsFileMemberOf(JetBrains.Util.FileSystemPath path) { }
        public override string ToString() { }
        public void WriteFileSet(System.IO.BinaryWriter writer) { }
    }
    public class FileSetSet
    {
        public FileSetSet() { }
        public FileSetSet(JetBrains.ProjectModel.FileSet fileSet) { }
        public void AddFileSet(JetBrains.ProjectModel.FileSet fileSet) { }
        public JetBrains.Util.FileSystemPath[] GetBasePaths() { }
        public JetBrains.ProjectModel.FileSet[] GetFileSets() { }
        public JetBrains.ProjectModel.FileSet IsMemberOf(JetBrains.Util.FileSystemPath fsp) { }
        public static JetBrains.ProjectModel.FileSetSet ReadFileSet(System.IO.BinaryReader binaryReader) { }
        public override string ToString() { }
        public void WriteFileSet(System.IO.BinaryWriter writer) { }
        public static void WriteFileSet([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ProjectModel.FileSetSet fileSetSet, System.IO.BinaryWriter writer) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class FileSystemPathAllowIntern
    {
        public FileSystemPathAllowIntern(JetBrains.DataFlow.Lifetime lifetime) { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class FileTypeDefinitionExtensionMapping : JetBrains.ProjectModel.IFileExtensionMapping
    {
        public FileTypeDefinitionExtensionMapping(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ProjectModel.IProjectFileTypes fileTypes) { }
        public JetBrains.DataFlow.ISimpleSignal Changed { get; }
        public System.Collections.Generic.IEnumerable<string> GetExtensions(JetBrains.ProjectModel.ProjectFileType projectFileType) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ProjectModel.ProjectFileType> GetFileTypes(string extension) { }
    }
    [System.ComponentModel.LocalizableAttribute(false)]
    public class FrameworkIdentifier : System.IEquatable<JetBrains.ProjectModel.FrameworkIdentifier>
    {
        public const string NET_CORE = ".NETCore";
        public const string NET_FRAMEWORK_ID = ".NETFrameWork";
        public const string NET_PORTABLE_ID = ".NETPortable";
        public static readonly JetBrains.ProjectModel.FrameworkIdentifier NetCore;
        public static readonly JetBrains.ProjectModel.FrameworkIdentifier NetFramework;
        public static readonly JetBrains.ProjectModel.FrameworkIdentifier NetMicroFramework;
        public static readonly JetBrains.ProjectModel.FrameworkIdentifier PocketPC;
        public static readonly JetBrains.ProjectModel.FrameworkIdentifier Portable;
        public static readonly JetBrains.ProjectModel.FrameworkIdentifier Silverlight;
        public static readonly JetBrains.ProjectModel.FrameworkIdentifier Smartphone;
        public static readonly JetBrains.ProjectModel.FrameworkIdentifier WindowsCE;
        public static readonly JetBrains.ProjectModel.FrameworkIdentifier WindowsPhone;
        public FrameworkIdentifier([JetBrains.Annotations.NotNullAttribute()] string identifier) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public string PresentableName { get; }
        public bool Equals(JetBrains.ProjectModel.FrameworkIdentifier other) { }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
        public static System.Collections.Generic.IEnumerable<JetBrains.ProjectModel.FrameworkIdentifier> GetWellKnownIdentifiers() { }
        public override string ToString() { }
        public void WriteFrameworkIdentifier(System.IO.BinaryWriter writer) { }
    }
    public class FrugalWeakCollection<TItem> : System.Collections.Generic.IEnumerable<TItem>, System.Collections.IEnumerable, System.IDisposable
        where TItem :  class
    {
        public FrugalWeakCollection() { }
        public void Add([JetBrains.Annotations.NotNullAttribute()] TItem item) { }
        public void Clear() { }
        public void Dispose() { }
        public System.Collections.Generic.IEnumerator<TItem> GetEnumerator() { }
    }
    [JetBrains.ProjectModel.ProjectFileTypeDefinitionAttribute("HTML")]
    public class HtmlProjectFileType : JetBrains.ProjectModel.KnownProjectFileType
    {
        public const string HTM_EXTENSION = ".htm";
        public const string HTML_EXTENSION = ".html";
        public static readonly JetBrains.ProjectModel.HtmlProjectFileType Instance;
        public const string Name = "HTML";
        protected HtmlProjectFileType(string name) { }
        protected HtmlProjectFileType(string name, string presentableName) { }
        protected HtmlProjectFileType(string name, string presentableName, System.Collections.Generic.IEnumerable<string> extensions) { }
    }
    public interface IActivityLogContributorSolutionComponent
    {
        void ProcessSolutionStatistics(JetBrains.ActivityTracking.ActivityLog log);
    }
    public interface IFileExtensionMapping
    {
        JetBrains.DataFlow.ISimpleSignal Changed { get; }
        System.Collections.Generic.IEnumerable<string> GetExtensions(JetBrains.ProjectModel.ProjectFileType projectFileType);
        System.Collections.Generic.IEnumerable<JetBrains.ProjectModel.ProjectFileType> GetFileTypes(string extension);
    }
    public interface IInMemoryChangeManager
    {
        public event JetBrains.ProjectModel.BeforeFilesSavedEventHandler BeforeFilesSaved;
        void RegisterInMemoryTracker(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ProjectModel.IInMemoryFileChangeTracker inMemoryFileChangeTracker);
        void SaveAll();
    }
    public interface IInMemoryFileChangeTracker : JetBrains.Application.IChangeProvider
    {
        void SaveFile(JetBrains.ProjectModel.IProjectFile file);
    }
    [JetBrains.ProjectModel.ProjectFileTypeDefinitionAttribute("IL")]
    public class ILProjectFileType : JetBrains.ProjectModel.KnownProjectFileType
    {
        public const string IL_EXTENSION = ".il";
        public static readonly JetBrains.ProjectModel.ILProjectFileType Instance;
        public const string Name = "IL";
        protected ILProjectFileType(string name) { }
        protected ILProjectFileType(string name, string presentableName) { }
        protected ILProjectFileType(string name, string presentableName, string[] strings) { }
    }
    public interface IModule : JetBrains.ProjectModel.IProjectModelElement, JetBrains.Util.IUserDataHolder
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ProjectModel.PlatformID PlatformID { get; }
        string Presentation { get; }
    }
    public interface IModuleToAssemblyReferenceResolver
    {
        System.Collections.Generic.IEnumerable<JetBrains.ProjectModel.AssemblyReferenceResolveResult> ResolveAssemblyReferences(JetBrains.ProjectModel.Model2.References.AssemblyReferenceTarget referenceTarget, JetBrains.ProjectModel.IModule referenceSource);
    }
    public interface IProject : JetBrains.ProjectModel.IModule, JetBrains.ProjectModel.IProjectElement, JetBrains.ProjectModel.IProjectFolder, JetBrains.ProjectModel.IProjectItem, JetBrains.ProjectModel.IProjectModelElement, JetBrains.Util.IUserDataHolder, System.IDisposable
    {
        System.Guid Guid { get; }
        bool IsOpened { get; set; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ProjectModel.IProjectFile ProjectFile { get; }
        JetBrains.Util.FileSystemPath ProjectFileLocation { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ProjectModel.Properties.IProjectProperties ProjectProperties { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.IEnumerable<JetBrains.ProjectModel.IProjectToModuleReference> GetModuleReferences();
        JetBrains.Util.FileSystemPath GetOutputDirectory();
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.Util.FileSystemPath GetOutputFilePath();
        bool HasFlavour<T>()
            where T : JetBrains.ProjectModel.Properties.IProjectFlavor;
    }
    public interface IProjectCollection
    {
        System.Collections.Generic.ICollection<JetBrains.ProjectModel.IProject> GetAllProjects();
    }
    public interface IProjectElement : JetBrains.ProjectModel.IProjectModelElement, JetBrains.Util.IUserDataHolder
    {
        string GetPersistentID();
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ProjectModel.IProject GetProject();
    }
    public interface IProjectFile : JetBrains.ProjectModel.IProjectElement, JetBrains.ProjectModel.IProjectItem, JetBrains.ProjectModel.IProjectModelElement, JetBrains.Util.IUserDataHolder
    {
        bool HasChangedExternallySinceLastReconciliation { get; }
        bool HasChangedInMemorySinceLastReconciliation { get; }
        bool IsFileSystemReadonly { get; }
        bool IsMissing { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ProjectModel.ProjectFileType LanguageType { get; }
        int LastExternalModificationStamp { get; }
        int LastInMemoryModificationStamp { get; set; }
        System.DateTime LastWriteTimeUtc { get; }
        JetBrains.ProjectModel.Properties.IProjectFileProperties Properties { get; }
        System.IO.Stream CreateReadStream();
        System.IO.Stream CreateWriteStream();
        System.Collections.Generic.ICollection<JetBrains.ProjectModel.IProjectFile> GetDependentFiles();
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ProjectModel.IProjectFile GetDependsUponFile();
        void MarkReconciledWithExternalVersion();
        void MarkReconciledWithInMemoryVersion();
        void UpdatePropertiesFrom(JetBrains.ProjectModel.Properties.IProjectFileProperties properties);
        void WriteProjectFile(System.IO.BinaryWriter writer, JetBrains.ProjectModel.Impl.ProjectSerializationIndex index, JetBrains.Util.FileSystemPath baseLocation);
    }
    public interface IProjectFileExtensions
    {
        JetBrains.DataFlow.ISimpleSignal Changed { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.IEnumerable<string> GetExtensions(JetBrains.ProjectModel.ProjectFileType fileType);
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ProjectModel.ProjectFileType GetFileType(string extension);
    }
    public interface IProjectFileTypes : JetBrains.DataFlow.IViewable<JetBrains.ProjectModel.ProjectFileType>
    {
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.IEnumerable<JetBrains.ProjectModel.ProjectFileType> All { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ProjectModel.ProjectFileType GetFileType([JetBrains.Annotations.NotNullAttribute()] string fileTypeName);
    }
    public interface IProjectFileUpdater
    {
        void OnItemAdded(JetBrains.ProjectModel.ProjectItemChange addChange);
        void OnItemMoved(JetBrains.ProjectModel.ProjectItemChange moveChange);
        void OnItemRemoved(JetBrains.ProjectModel.ProjectItemChange changeDelta);
        void OnPropertyChanged(JetBrains.ProjectModel.ProjectItemChange itemChange);
        void OnReferenceAdded(JetBrains.ProjectModel.ProjectReferenceChange projectRefChange);
        void OnReferenceRemoved(JetBrains.ProjectModel.ProjectReferenceChange modRefChange);
    }
    public interface IProjectFolder : JetBrains.ProjectModel.IProjectElement, JetBrains.ProjectModel.IProjectItem, JetBrains.ProjectModel.IProjectModelElement, JetBrains.Util.IUserDataHolder
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ProjectModel.ProjectFolderPath Path { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [System.ObsoleteAttribute("Use the method if and only if you\'re 100% sure there\'s only one project item expe" +
            "cted. Use ProjectFolderEx.FindProjectItemsByLocation otherwise.")]
        JetBrains.ProjectModel.IProjectItem FindProjectItemByLocation([JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.FileSystemPath location);
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ProjectModel.IProjectItem GetSubItem(string name);
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.IList<JetBrains.ProjectModel.IProjectItem> GetSubItems(string name);
        System.Collections.Generic.IList<JetBrains.ProjectModel.IProjectItem> GetSubItems();
        bool WriteProjectFolder(System.IO.BinaryWriter writer, JetBrains.ProjectModel.Impl.ProjectSerializationIndex index, JetBrains.Util.FileSystemPath baseLocation);
    }
    public interface IProjectItem : JetBrains.ProjectModel.IProjectElement, JetBrains.ProjectModel.IProjectModelElement, JetBrains.Util.IUserDataHolder
    {
        bool IsLinked { get; }
        JetBrains.ProjectModel.ProjectItemKind Kind { get; }
        JetBrains.Util.FileSystemPath Location { get; }
        JetBrains.Application.IShellLocks Locks { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ProjectModel.IProjectFolder ParentFolder { get; }
        void Dump(System.IO.TextWriter to);
        string GetPresentableProjectPath();
    }
    public interface IProjectModelChangeDeltaVisitor
    {
        void VisitAssemblyDelta(JetBrains.ProjectModel.AssemblyChange assemblyChange);
        void VisitAssemblyFileDelta(JetBrains.ProjectModel.AssemblyFileChange change);
        void VisitDelta(JetBrains.ProjectModel.ProjectModelChange changeDelta);
        void VisitItemDelta(JetBrains.ProjectModel.ProjectItemChange change);
        void VisitProjectReferenceDelta(JetBrains.ProjectModel.ProjectReferenceChange change);
        void VisitSdkReferenceDelta(JetBrains.ProjectModel.ProjectSdkReferenceChange projectSdkReferenceChange);
        void VisitSolutionDelta(JetBrains.ProjectModel.SolutionChange change);
    }
    public interface IProjectModelEditor
    {
        JetBrains.ProjectModel.IProjectToAssemblyReference AddAssemblyReference([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IProject project, JetBrains.Util.FileSystemPath fullPathToReferencedLibrary);
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ProjectModel.IProjectFile AddFile([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IProjectFolder parentFolder, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.FileSystemPath location);
        JetBrains.ProjectModel.IProjectFolder AddFolder([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IProjectFolder parentFolder, [JetBrains.Annotations.NotNullAttribute()] string name, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.Util.FileSystemPath folderPath = null);
        JetBrains.ProjectModel.IProjectToModuleReference AddModuleReference([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IProject project, JetBrains.ProjectModel.IModule referenceToAdd);
        bool CanAddFile([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IProjectFolder parentFolder, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.FileSystemPath location, out string reason);
        bool CanAddFolder([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IProjectFolder parentFolder, [JetBrains.Annotations.NotNullAttribute()] string name, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.Util.FileSystemPath folderPath, out string reason);
        bool CanCopy([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IProjectItem projectItem, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ProjectModel.IProjectFolder newParentItem, out string reason);
        bool CanMove([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IProjectItem projectItem, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ProjectModel.IProjectFolder newParentItem, out string reason);
        bool CanRemove([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IProjectItem projectItem, out string reason);
        bool CanRename([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IProjectItem projectItem, [JetBrains.Annotations.NotNullAttribute()] string newName, out string reason);
        JetBrains.ProjectModel.IProjectItem Copy([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IProjectItem projectItem, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ProjectModel.IProjectFolder newParentItem);
        void Move([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IProjectItem projectItem, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ProjectModel.IProjectFolder newParentItem);
        void Remove([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IProjectItem projectItem);
        void RemoveModuleReference(JetBrains.ProjectModel.IProjectToModuleReference referenceToRemove);
        void Rename([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IProjectItem projectItem, [JetBrains.Annotations.NotNullAttribute()] string newName);
    }
    public interface IProjectModelElement : JetBrains.Util.IUserDataHolder
    {
        [JetBrains.Annotations.NotNullAttribute()]
        string Name { get; }
        void Accept(JetBrains.ProjectModel.ProjectVisitor projectVisitor);
        object GetProperty(JetBrains.Util.Key propertyName);
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ProjectModel.ISolution GetSolution();
        bool IsValid();
        void SetProperty(JetBrains.Util.Key propertyName, object propertyValue);
    }
    public interface IProjectModelElementPointer { }
    public interface IProjectModelElementPresenter
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.UI.Icons.IconId GetIcon([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IProjectModelElement projectModelElement);
        [JetBrains.Annotations.CanBeNullAttribute()]
        string GetPresentableLocation([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IProjectModelElement projectModelElement);
    }
    public interface IProjectModelTimestamps
    {
        int AnyChange { get; }
        int ProjectFileTypes { get; }
        int ProjectItemLocations { get; }
    }
    public interface IProjectModelTransactionCookie : JetBrains.ProjectModel.IProjectModelEditor, JetBrains.Util.ITransactionCookie, System.IDisposable { }
    public interface IProjectModelTransactionFactory
    {
        JetBrains.ProjectModel.IProjectModelTransactionCookie CreateTransactionCookie(JetBrains.Util.DefaultAction defaultAction, string commandName, JetBrains.Util.IUndoRedoHandler handler, bool optimizeChangesOnCommit, JetBrains.Application.Progress.IProgressIndicator pi);
    }
    public interface IProjectModelTransactionHandler
    {
        void RegisterNewChange(JetBrains.ProjectModel.ITransactionAction transactionAction);
    }
    public interface IProjectModelTransactionManager
    {
        JetBrains.ProjectModel.IProjectModelTransactionHandler CurrentTransactionHandler { get; }
        void SetCurrentTransactionHandler(JetBrains.ProjectModel.IProjectModelTransactionHandler transactionHandler);
    }
    public interface IProjectPresentablePathProvider
    {
        string GetPresentableProjectPath(JetBrains.ProjectModel.IProjectItem projectItem);
    }
    public interface IProjectToAssemblyReference : JetBrains.ProjectModel.IProjectElement, JetBrains.ProjectModel.IProjectModelElement, JetBrains.ProjectModel.IProjectToModuleReference, JetBrains.ProjectModel.Model2.References.IModuleToAssemblyReference, JetBrains.Util.IUserDataHolder, System.IDisposable
    {
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ProjectModel.Model2.References.AssemblyReferenceTarget ReferenceTarget { get; }
    }
    public interface IProjectToModuleReference : JetBrains.ProjectModel.IProjectElement, JetBrains.ProjectModel.IProjectModelElement, JetBrains.Util.IUserDataHolder, System.IDisposable
    {
        [JetBrains.Annotations.NotNullAttribute()]
        string AliasList { get; set; }
        bool CopyLocal { get; set; }
        bool EmbedInteropTypes { get; set; }
        JetBrains.ProjectModel.IProject OwnerModule { get; }
    }
    public interface IProjectToProjectReference : JetBrains.ProjectModel.IProjectElement, JetBrains.ProjectModel.IProjectModelElement, JetBrains.ProjectModel.IProjectToModuleReference, JetBrains.ProjectModel.References.IProjectToModuleWithSourcesReference, JetBrains.Util.IUserDataHolder, System.IDisposable { }
    public interface IQuerySolutionCloseHandler
    {
        bool QuerySolutionClose(JetBrains.ProjectModel.ISolution solution);
    }
    public interface ISdkModule : JetBrains.ProjectModel.IModule, JetBrains.ProjectModel.IProject, JetBrains.ProjectModel.IProjectElement, JetBrains.ProjectModel.IProjectFolder, JetBrains.ProjectModel.IProjectItem, JetBrains.ProjectModel.IProjectModelElement, JetBrains.Util.IUserDataHolder, System.IDisposable
    {
        JetBrains.Util.FileSystemPath ContentRootFolder { get; }
        System.Collections.Generic.ICollection<JetBrains.Util.FileSystemPath> SdkContentFiles { get; }
        string SdkIdentity { get; }
        JetBrains.Metadata.Utils.SdkModuleInfo SDKModuleInfo { get; }
        JetBrains.Metadata.Utils.TargetPlatformData TargetPlatformData { get; }
    }
    public interface ISolution : JetBrains.Application.IChangeProvider, JetBrains.ProjectModel.IProjectCollection, JetBrains.ProjectModel.IProjectModelElement, JetBrains.Util.IUserDataHolder, System.IDisposable
    {
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ProjectModel.Transaction.IProjectModelBatchChangeManager BatchChangeManager { get; }
        bool IsTemporary { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.Application.IShellLocks Locks { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ProjectModel.IProject MiscFilesProject { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ProjectModel.PlatformManager PlatformManager { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ProjectModel.IProjectFile SolutionFile { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.Util.FileSystemPath SolutionFilePath { get; }
        JetBrains.ProjectModel.ISolutionOwner SolutionOwner { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ProjectModel.IProject SolutionProject { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ProjectModel.IProjectModelTimestamps Timestamps { get; }
        void Dump([JetBrains.Annotations.NotNullAttribute()] System.IO.TextWriter to);
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ProjectModel.IProjectElement FindElementByPersistentID([JetBrains.Annotations.NotNullAttribute()] string persistentID);
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.ICollection<JetBrains.ProjectModel.IProjectItem> FindProjectItemsByLocation([JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.FileSystemPath location);
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.IList<JetBrains.ProjectModel.Model2.Assemblies.Interfaces.IAssembly> GetAllAssemblies();
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ProjectModel.IProject GetProjectByGuid(System.Guid projectGuid);
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ProjectModel.IProject GetProjectByName([JetBrains.Annotations.NotNullAttribute()] string name);
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.ICollection<JetBrains.ProjectModel.IProject> GetTopLevelProjects();
    }
    public interface ISolutionExplorer
    {
        bool CollapseInSolutionExplorer(System.Collections.Generic.IEnumerable<JetBrains.ProjectModel.CollapseRequest> collapseRequests);
        bool ShowInSolutionExplorer([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ProjectModel.IProjectItem projectItem, bool activate);
    }
    public interface ISolutionOpeningOwner : JetBrains.ProjectModel.ISolutionOwner
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ProjectModel.ISolution CurrentSolution { get; }
        bool CloseSolution();
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ProjectModel.ISolution OpenExistingSolution([JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.FileSystemPath solutionFilePath);
        void StartOpenExistingSolution(JetBrains.Util.FileSystemPath solutionFilePath, System.Action callback);
    }
    public interface ISolutionOwner
    {
        bool IsRealSolutionOwner { get; }
        JetBrains.ProjectModel.Properties.ProjectFilePropertiesFactory ProjectFilePropertiesFactory { get; }
        JetBrains.ProjectModel.Properties.ProjectPropertiesFactory ProjectPropertiesFactory { get; }
        T GetComponent<T>()
            where T :  class;
        bool IsSolutionValid(JetBrains.ProjectModel.ISolution solution);
    }
    public enum ItemSubType : byte
    {
        CODE = 0,
        COMPONENT = 1,
        DESIGNER = 2,
        FORM = 3,
        USER_CONTROL = 4,
        UNKNOWN = 5,
    }
    public class static ItemTypesGuid
    {
        public static readonly System.Guid PhysicalFile;
        public static readonly System.Guid PhysicalFolder;
        public static readonly System.Guid SubProject;
        public static readonly System.Guid VirtualFolder;
    }
    public interface ITransactionAction
    {
        System.Collections.Generic.IEnumerable<JetBrains.ProjectModel.IProjectFile> AffectedProjectFiles { get; }
        void Commit();
        void Rollback();
    }
    public interface IWritableProjectModelTimestamps : JetBrains.ProjectModel.IProjectModelTimestamps
    {
        int IncrementAnyChange();
        int IncrementProjectFileTypes();
        int IncrementProjectItemLocations();
    }
    [JetBrains.ProjectModel.ProjectFileTypeDefinitionAttribute("JS")]
    public class JavaScriptProjectFileType : JetBrains.ProjectModel.KnownProjectFileType
    {
        [JetBrains.Annotations.UsedImplicitlyAttribute()]
        public static readonly JetBrains.ProjectModel.JavaScriptProjectFileType Instance;
        public const string JS_EXTENSION = ".js";
        public const string MIN_JS_EXTENSION = ".min.js";
        public const string Name = "JS";
        protected JavaScriptProjectFileType(string name) { }
        protected JavaScriptProjectFileType(string name, string presentableName) { }
        protected JavaScriptProjectFileType(string name, string presentableName, string[] strings) { }
    }
    [JetBrains.ProjectModel.ProjectFileTypeDefinitionAttribute("ANY")]
    public class KnownProjectFileType : JetBrains.ProjectModel.ProjectFileType
    {
        public static readonly JetBrains.ProjectModel.KnownProjectFileType Instance;
        public const string Name = "ANY";
        protected KnownProjectFileType([JetBrains.Annotations.NotNullAttribute()] string name) { }
        protected KnownProjectFileType([JetBrains.Annotations.NotNullAttribute()] string name, [JetBrains.Annotations.NotNullAttribute()] string presentableName) { }
        protected KnownProjectFileType([JetBrains.Annotations.NotNullAttribute()] string name, [JetBrains.Annotations.NotNullAttribute()] string presentableName, [JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IEnumerable<string> extensions) { }
    }
    public class MakingWritableEventArgs : JetBrains.ProjectModel.BeforeMadeWritableEventArgs
    {
        public MakingWritableEventArgs(JetBrains.ProjectModel.BeforeMadeWritableEventArgs e) { }
    }
    public delegate void MakingWritableEventHandler(object sender, JetBrains.ProjectModel.MakingWritableEventArgs args);
    public class ModificationFinishedEventArgs : System.EventArgs
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly System.Collections.Generic.ICollection<JetBrains.ProjectModel.IProjectFile> FilesToMakeWritable;
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly System.Collections.Generic.ICollection<JetBrains.Util.FileSystemPath> PathsToMakeWritable;
        public ModificationFinishedEventArgs([JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.ICollection<JetBrains.ProjectModel.IProjectFile> filesToMakeWritable, [JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.ICollection<JetBrains.Util.FileSystemPath> pathsToMakeWritable) { }
        public bool IsEmpty { get; }
    }
    public delegate void ModificationFinishedEventHandler(object sender, JetBrains.ProjectModel.ModificationFinishedEventArgs args);
    [JetBrains.ProjectModel.ProjectFileTypeDefinitionAttribute("MSBuild")]
    public class MSBuildProjectFileType : JetBrains.ProjectModel.BuildScriptProjectFileType
    {
        public static readonly JetBrains.ProjectModel.MSBuildProjectFileType Instance;
        public const string Name = "MSBuild";
        public const string ProjExtension = ".proj";
        protected MSBuildProjectFileType(string name) { }
        protected MSBuildProjectFileType(string name, string presentableName) { }
    }
    [JetBrains.ProjectModel.ProjectFileTypeDefinitionAttribute("MSTestAccessor")]
    public class MSTestAccessorProjectFileType : JetBrains.ProjectModel.KnownProjectFileType
    {
        public static readonly JetBrains.ProjectModel.MSTestAccessorProjectFileType Instance;
        public const string Name = "MSTestAccessor";
        protected MSTestAccessorProjectFileType(string name) { }
        protected MSTestAccessorProjectFileType(string name, string presentableName) { }
    }
    [JetBrains.ProjectModel.ProjectFileTypeDefinitionAttribute("NAnt")]
    public class NAntProjectFileType : JetBrains.ProjectModel.BuildScriptProjectFileType
    {
        public const string Extension = ".build";
        public static readonly JetBrains.ProjectModel.NAntProjectFileType Instance;
        public const string Name = "NAnt";
        protected NAntProjectFileType(string name) { }
        protected NAntProjectFileType(string name, string presentableName) { }
    }
    public class OperationFailedException : System.ApplicationException
    {
        public OperationFailedException(string message) { }
        public OperationFailedException(string message, System.Exception innerException) { }
    }
    public class OutputAssemblyInfo
    {
        public OutputAssemblyInfo(System.Guid outputAssemblyMvid, JetBrains.Metadata.Utils.AssemblyNameInfo assemblyNameInfo, JetBrains.Util.FileSystemPath location) { }
        public JetBrains.Metadata.Utils.AssemblyNameInfo AssemblyNameInfo { get; }
        public JetBrains.Util.FileSystemPath Location { get; }
        public System.Guid OutputAssemblyMvid { get; }
        protected bool Equals(JetBrains.ProjectModel.OutputAssemblyInfo other) { }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
    }
    [System.ComponentModel.LocalizableAttribute(false)]
    public sealed class PlatformID : System.IEquatable<JetBrains.ProjectModel.PlatformID>
    {
        public PlatformID([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.FrameworkIdentifier identifier, [JetBrains.Annotations.NotNullAttribute()] System.Version version, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ProjectModel.ProfileIdentifier profile = null) { }
        public string FullName { get; }
        public JetBrains.ProjectModel.FrameworkIdentifier Identifier { get; }
        public JetBrains.ProjectModel.ProfileIdentifier Profile { get; }
        public System.Version Version { get; }
        public static JetBrains.ProjectModel.PlatformID CreateFromName([JetBrains.Annotations.NotNullAttribute()] string name, [JetBrains.Annotations.CanBeNullAttribute()] System.Version version = null, JetBrains.ProjectModel.ProfileIdentifier profile = null) { }
        public static JetBrains.ProjectModel.PlatformID CreateFromName([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.FrameworkIdentifier framework, [JetBrains.Annotations.CanBeNullAttribute()] System.Version version = null, JetBrains.ProjectModel.ProfileIdentifier profile = null) { }
        public bool Equals(JetBrains.ProjectModel.PlatformID other) { }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
        public static JetBrains.ProjectModel.PlatformID ReadPlatformId(System.IO.BinaryReader reader) { }
        public override string ToString() { }
        public static JetBrains.ProjectModel.PlatformID TryCreate(string frameworkName) { }
        public void WritePlatformId(System.IO.BinaryWriter writer) { }
    }
    public sealed class PlatformInfo
    {
        public PlatformInfo(JetBrains.ProjectModel.PlatformID platformID, System.Collections.Generic.IEnumerable<JetBrains.Util.FileSystemPath> platformFolders, JetBrains.Util.FileSystemPath csharpCompiler, JetBrains.Util.FileSystemPath vbCompiler, JetBrains.Util.FileSystemPath msBuild, System.Version msBuildVersion, JetBrains.Util.FileSystemPath temporaryASPFiles, JetBrains.Util.FileSystemPath configDirectory, System.Collections.Generic.IList<JetBrains.Util.FileSystemPath> additionalAssemblyFolders, System.Collections.Generic.IEnumerable<JetBrains.Util.FileSystemPath> mscorlibSearchPath) { }
        public System.Collections.Generic.ICollection<JetBrains.Util.FileSystemPath> AdditionalAssemblyFolders { get; }
        public JetBrains.Util.FileSystemPath AspNetCompilerPath { get; }
        public JetBrains.Util.FileSystemPath Config { get; }
        public JetBrains.Util.FileSystemPath CSharpCompilerPath { get; }
        public JetBrains.ProjectModel.FrameworkIdentifier Identifier { get; }
        public JetBrains.Util.FileSystemPath MicrosoftVisualBasicPath { get; }
        public JetBrains.Util.FileSystemPath MSBuildPath { get; }
        public System.Version MSBuildVersion { get; }
        public JetBrains.Util.FileSystemPath MscorlibPath { get; }
        public System.Collections.Generic.ICollection<JetBrains.Util.FileSystemPath> PlatformFolders { get; }
        public JetBrains.ProjectModel.PlatformID PlatformID { get; }
        public JetBrains.ProjectModel.ProfileIdentifier Profile { get; }
        public JetBrains.Util.FileSystemPath TemporaryASPFiles { get; }
        public JetBrains.Util.FileSystemPath VBCompilerPath { get; }
        public System.Version Version { get; }
        public bool IsFrameworkAssembly(JetBrains.Util.FileSystemPath assemblyPath) { }
    }
    public class PlatformInfoVersionComparer : System.Collections.Generic.IComparer<JetBrains.ProjectModel.PlatformInfo>
    {
        public static readonly JetBrains.ProjectModel.PlatformInfoVersionComparer Instance;
        public int Compare(JetBrains.ProjectModel.PlatformInfo x, JetBrains.ProjectModel.PlatformInfo y) { }
    }
    public abstract class PlatformManager
    {
        public const string MicrosoftCSharp = "Microsoft.CSharp";
        public const string MicrosoftVisualBasic = "Microsoft.VisualBasic";
        public const string Mscorlib = "mscorlib";
        public const string System = "System";
        public const string SystemCore = "System.Core";
        public const string Windows = "Windows";
        protected PlatformManager(JetBrains.ProjectModel.impl.IFrameworkDetectionHelper frameworkDetectionHelper) { }
        public JetBrains.ProjectModel.impl.IFrameworkDetectionHelper FrameworkDetectionHelper { get; }
        public abstract JetBrains.Util.FileSystemPath Gac40Path { get; }
        public abstract JetBrains.Util.FileSystemPath GacPath { get; }
        public abstract void Dump(System.IO.TextWriter writer, JetBrains.Util.FileSystemPath rootPath = null, JetBrains.Util.FileSystemPath replacePath = null);
        public abstract System.Collections.Generic.IEnumerable<JetBrains.ProjectModel.PlatformInfo> GetAllPlatformInfos();
        [JetBrains.Annotations.NotNullAttribute()]
        public abstract JetBrains.ProjectModel.PlatformID GetAssemblyPlatformId(JetBrains.Util.FileSystemPath assemblyPath);
        public abstract JetBrains.ProjectModel.PlatformInfo GetDefaultPlatformInfo();
        [JetBrains.Annotations.CanBeNullAttribute()]
        public abstract JetBrains.ProjectModel.PlatformInfo GetPlatformInfo([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ProjectModel.PlatformID id);
        public abstract JetBrains.ProjectModel.PlatformID GetRunTimePlatformId(JetBrains.ProjectModel.PlatformID compileTimePlatformId);
        public abstract bool IsFrameworkAssembly(JetBrains.Util.FileSystemPath fileSystemPath);
    }
    public class static PlatformUtils
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.ProjectModel.PlatformID CreatePlatformId(System.Collections.Generic.ICollection<System.Guid> projectTypeGuids, JetBrains.ProjectModel.PlatformID defaultPlatform, [JetBrains.Annotations.CanBeNullAttribute()] System.Version targetFrameworkVersion) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.Util.FileSystemPath GetReferencedAssembliesDir() { }
    }
    [System.ComponentModel.LocalizableAttribute(false)]
    public class ProfileIdentifier
    {
        public static readonly JetBrains.ProjectModel.ProfileIdentifier Client;
        public static readonly JetBrains.ProjectModel.ProfileIdentifier Default;
        public static readonly JetBrains.ProjectModel.ProfileIdentifier Runtime;
        public static readonly JetBrains.ProjectModel.ProfileIdentifier WindowsPhone;
        public static readonly JetBrains.ProjectModel.ProfileIdentifier WindowsPhone71;
        public ProfileIdentifier([JetBrains.Annotations.NotNullAttribute()] string identifier) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public string PresentableName { get; }
        public bool Equals(JetBrains.ProjectModel.ProfileIdentifier other) { }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
        public bool IsDefault() { }
        public override string ToString() { }
        public void WriteProfileIdentifier(System.IO.BinaryWriter writer) { }
    }
    [JetBrains.Annotations.MeansImplicitUseAttribute(JetBrains.Annotations.ImplicitUseKindFlags.InstantiatedNoFixedConstructorSignature)]
    [System.AttributeUsageAttribute(System.AttributeTargets.Class | System.AttributeTargets.All, Inherited=false)]
    public class ProjectComponentAttribute : JetBrains.Application.Components.ComponentAttribute
    {
        public ProjectComponentAttribute() { }
        public ProjectComponentAttribute(JetBrains.Application.Components.ProgramConfigurations programConfigurations) { }
        public JetBrains.ProjectModel.ProjectKind ProjectKinds { get; set; }
    }
    public class ProjectComponentFilter : JetBrains.Application.Parts.ProgramConfigurationPartFilter
    {
        public ProjectComponentFilter(JetBrains.ProjectModel.ProjectKind projectKind, JetBrains.Application.Components.ProgramConfigurations guessProgramConfiguration) { }
        protected override bool Supported(JetBrains.Application.Parts.PartCatalogueType part) { }
    }
    public class static ProjectExtensions
    {
        public static bool CanBeWindowsWebProject([JetBrains.Annotations.CanBeNullAttribute()] this JetBrains.ProjectModel.IProjectFile projectFile) { }
        public static bool CanBeWindowsWebProject([JetBrains.Annotations.CanBeNullAttribute()] this JetBrains.ProjectModel.IProject project) { }
        public static System.Collections.Generic.IEnumerable<JetBrains.ProjectModel.IProjectFile> GetAllProjectFiles([JetBrains.Annotations.CanBeNullAttribute()] this JetBrains.ProjectModel.IProjectFolder projectFolder, System.Predicate<JetBrains.ProjectModel.IProjectFile> predicate = null) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Collections.Generic.ICollection<JetBrains.ProjectModel.IProjectToAssemblyReference> GetAssemblyReferences([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ProjectModel.IProject project) { }
        public static JetBrains.Util.FileSystemPath GetIntermediateDirectory(this JetBrains.ProjectModel.IProject project) { }
        public static JetBrains.ProjectModel.IProjectToModuleReference GetModuleReference(this JetBrains.ProjectModel.IProject project, [JetBrains.Annotations.NotNullAttribute()] string moduleName) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ProjectModel.OutputAssemblyInfo GetOutputAssemblyInfo(this JetBrains.ProjectModel.IProject project) { }
        public static string GetOutputAssemblyName(this JetBrains.ProjectModel.IProject project) { }
        public static System.Collections.Generic.ICollection<JetBrains.ProjectModel.IProjectToProjectReference> GetProjectReferences([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ProjectModel.IProject project) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext GetResolveContext(this JetBrains.ProjectModel.IProject project) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ProjectModel.Model2.Assemblies.Interfaces.IAssembly GetValidOutputAssembly(this JetBrains.ProjectModel.IProject project) { }
        public static bool HasReferenceToWindowsWinmd(this JetBrains.ProjectModel.IProject project) { }
        public static bool IsMetroStyleProject(this JetBrains.ProjectModel.IProject project) { }
        public static bool IsProjectWithoutPsi(this JetBrains.ProjectModel.IProject project) { }
        [JetBrains.Annotations.ContractAnnotationAttribute("null => false")]
        public static bool IsSharepointWorkflow(this JetBrains.ProjectModel.IProject project) { }
        public static bool IsWebApplication(this JetBrains.ProjectModel.IProject project) { }
        public static bool IsWebProject([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ProjectModel.IProject project) { }
        [JetBrains.Annotations.ContractAnnotationAttribute("null => false")]
        public static bool IsWinJSProjectKind([JetBrains.Annotations.CanBeNullAttribute()] this JetBrains.ProjectModel.IProject project) { }
        public static bool IsWinmdModule(this JetBrains.ProjectModel.IModule module) { }
        public static bool ShouldHaveImplicitReferences(this JetBrains.ProjectModel.IProject project) { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class ProjectFileExtensions : JetBrains.ProjectModel.IProjectFileExtensions
    {
        public ProjectFileExtensions(JetBrains.DataFlow.Lifetime lifetime, JetBrains.DataFlow.IViewable<JetBrains.ProjectModel.IFileExtensionMapping> extensionMappings, JetBrains.ProjectModel.IProjectFileTypes projectFileTypes) { }
        public JetBrains.DataFlow.ISimpleSignal Changed { get; }
        protected virtual JetBrains.ProjectModel.ProjectFileType CalcValue(string extension) { }
        public System.Collections.Generic.IEnumerable<string> GetExtensions(JetBrains.ProjectModel.ProjectFileType fileType) { }
        public JetBrains.ProjectModel.ProjectFileType GetFileType(string extension) { }
    }
    public sealed class ProjectFileImpl : JetBrains.ProjectModel.ProjectItemBase, JetBrains.ProjectModel.IProjectElement, JetBrains.ProjectModel.IProjectFile, JetBrains.ProjectModel.IProjectItem, JetBrains.ProjectModel.IProjectModelElement, JetBrains.Util.IUserDataHolder
    {
        public ProjectFileImpl(JetBrains.Util.FileSystemPath path, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.ProjectFolderImpl parentItem, JetBrains.ProjectModel.Properties.IProjectFileProperties properties) { }
        public ProjectFileImpl(JetBrains.ProjectModel.ProjectFilePath path, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.ProjectFolderImpl parentItem, JetBrains.ProjectModel.Properties.IProjectFileProperties properties) { }
        public JetBrains.ProjectModel.Impl.CachedFileSystemData CachedFileSystemData { get; }
        public bool HasChangedExternallySinceLastReconciliation { get; }
        public bool HasChangedInMemorySinceLastReconciliation { get; }
        public bool IsFileSystemReadonly { get; }
        public override bool IsLinked { get; }
        public bool IsMissing { get; }
        public override JetBrains.ProjectModel.ProjectItemKind Kind { get; }
        public JetBrains.ProjectModel.ProjectFileType LanguageType { get; }
        public int LastExternalModificationStamp { get; }
        public int LastInMemoryModificationStamp { get; set; }
        public System.DateTime LastWriteTimeUtc { get; }
        public override JetBrains.Util.FileSystemPath Location { get; }
        public override string Name { get; }
        public JetBrains.ProjectModel.ProjectFilePath Path { get; }
        public JetBrains.ProjectModel.Properties.IProjectFileProperties Properties { get; }
        public override void Accept(JetBrains.ProjectModel.ProjectVisitor projectVisitor) { }
        protected override void AdviseFileSystemChanges() { }
        public override void Cleanup() { }
        public System.IO.Stream CreateReadStream() { }
        public System.IO.Stream CreateWriteStream() { }
        protected override void DoMoveImpl(JetBrains.ProjectModel.IProjectFolder newParentItem) { }
        public override void DoRename(string newName) { }
        public System.Collections.Generic.ICollection<JetBrains.ProjectModel.IProjectFile> GetDependentFiles() { }
        public JetBrains.ProjectModel.IProjectFile GetDependsUponFile() { }
        public void MarkReconciledWithExternalVersion() { }
        public void MarkReconciledWithInMemoryVersion() { }
        public override void OnOpen() { }
        public static void ReadProjectFile(System.IO.BinaryReader reader, JetBrains.ProjectModel.ProjectFolderImpl projectFolder, JetBrains.Util.FileSystemPath baseLocation, JetBrains.ProjectModel.Properties.IProjectFilePropertiesProvider filePropertiesProvider) { }
        public override string ToString() { }
        public void UpdatePropertiesFrom(JetBrains.ProjectModel.Properties.IProjectFileProperties properties) { }
        public void WriteProjectFile(System.IO.BinaryWriter writer, JetBrains.ProjectModel.Impl.ProjectSerializationIndex index, JetBrains.Util.FileSystemPath baseLocation) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class ProjectFileLocationLiveWatcher
    {
        public ProjectFileLocationLiveWatcher(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.ChangeManager changemanager, JetBrains.Application.IShellLocks locks, JetBrains.ProjectModel.ISolution solution) { }
    }
    public class ProjectFilePath
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public string FileShortName { get; }
        public bool IsLinked { get; }
        public static JetBrains.ProjectModel.ProjectFilePath Create([JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.FileSystemPath path, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ProjectModel.IProjectFolder parentFolder) { }
        public static JetBrains.ProjectModel.ProjectFilePath ReadProjectItemPath(System.IO.BinaryReader reader, JetBrains.Util.FileSystemPath baseLocation) { }
        public override string ToString() { }
        public void WriteProjectItemPath(System.IO.BinaryWriter writer, JetBrains.Util.FileSystemPath baseLocation) { }
    }
    public struct ProjectFileTextRange
    {
        public static readonly JetBrains.ProjectModel.ProjectFileTextRange Invalid;
        public ProjectFileTextRange(JetBrains.ProjectModel.IProjectFile projectFile, int offset) { }
        public ProjectFileTextRange(JetBrains.ProjectModel.IProjectFile projectFile, JetBrains.Util.TextRange textRange) { }
        public bool IsValid { get; }
        public JetBrains.ProjectModel.IProjectFile ProjectFile { get; }
        public JetBrains.Util.TextRange TextRange { get; }
    }
    [JetBrains.Annotations.CannotApplyEqualityOperatorAttribute()]
    public abstract class ProjectFileType
    {
        protected ProjectFileType([JetBrains.Annotations.NotNullAttribute()] string name) { }
        protected ProjectFileType([JetBrains.Annotations.NotNullAttribute()] string name, [JetBrains.Annotations.NotNullAttribute()] string presentableName) { }
        protected ProjectFileType([JetBrains.Annotations.NotNullAttribute()] string name, [JetBrains.Annotations.NotNullAttribute()] string presentableName, [JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IEnumerable<string> extensions) { }
        public System.Collections.Generic.IEnumerable<string> Extensions { get; }
        public string Name { get; }
        public string PresentableName { get; }
        public override string ToString() { }
    }
    [JetBrains.Annotations.MeansImplicitUseAttribute()]
    [System.AttributeUsageAttribute(System.AttributeTargets.Class | System.AttributeTargets.All, AllowMultiple=false)]
    public class ProjectFileTypeAttribute : JetBrains.Application.Parts.PartAttribute
    {
        public ProjectFileTypeAttribute(System.Type type) { }
        public System.Type Type { get; }
    }
    [JetBrains.Annotations.MeansImplicitUseAttribute()]
    [System.AttributeUsageAttribute(System.AttributeTargets.Class | System.AttributeTargets.All)]
    public class ProjectFileTypeDefinitionAttribute : JetBrains.Application.Parts.PartAttribute
    {
        public ProjectFileTypeDefinitionAttribute(string type) { }
        public string Edition { get; set; }
        public bool Internal { get; set; }
        public string Type { get; set; }
    }
    public class static ProjectFileTypeEx
    {
        public static bool Is<T>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ProjectModel.ProjectFileType projectFileType)
            where T : JetBrains.ProjectModel.ProjectFileType { }
        public static bool IsExactly<T>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ProjectModel.ProjectFileType projectFileType)
            where T : JetBrains.ProjectModel.ProjectFileType { }
        [JetBrains.Annotations.ContractAnnotationAttribute("null=>true")]
        public static bool IsNullOrUnknown(this JetBrains.ProjectModel.ProjectFileType projectFileType) { }
        public static bool IsProjectFileType([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ProjectModel.ProjectFileType projectFileType, JetBrains.ProjectModel.ProjectFileType fileType) { }
        public static bool IsProjectFileType([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ProjectModel.ProjectFileType projectFileType, System.Type fileType) { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class ProjectFileTypes : JetBrains.DataFlow.IViewable<JetBrains.ProjectModel.ProjectFileType>, JetBrains.ProjectModel.IProjectFileTypes
    {
        public ProjectFileTypes(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.Parts.IPartsCatalogueSet catalogueSet, JetBrains.Application.IApplicationDescriptor applicationDescriptor, JetBrains.Application.Env.RunsProducts.ProductConfigurations productConfigurations) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ProjectModel.ProjectFileType> All { get; }
        public JetBrains.ProjectModel.ProjectFileType GetFileType(string fileTypeName) { }
        public void View(JetBrains.DataFlow.Lifetime lifetime, System.Action<JetBrains.DataFlow.Lifetime, JetBrains.ProjectModel.ProjectFileType> viewer) { }
    }
    public class static ProjectFolderEx
    {
        public static System.Collections.Generic.IEnumerable<JetBrains.ProjectModel.IProjectItem> FindProjectItemsByLocation([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ProjectModel.IProjectFolder folder, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.FileSystemPath location) { }
    }
    public class ProjectFolderImpl : JetBrains.ProjectModel.ProjectItemBase, JetBrains.ProjectModel.IProjectElement, JetBrains.ProjectModel.IProjectFolder, JetBrains.ProjectModel.IProjectFolderActions, JetBrains.ProjectModel.IProjectItem, JetBrains.ProjectModel.IProjectModelElement, JetBrains.Util.IUserDataHolder
    {
        protected ProjectFolderImpl([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.Impl.SolutionElement solutionElement, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ProjectModel.ProjectFolderPath path, JetBrains.ProjectModel.ProjectFolderImpl parentItem) { }
        public JetBrains.ProjectModel.Impl.CachedProjectItemValue<JetBrains.ProjectModel.IProjectFolder, JetBrains.Util.OneToSetMap<JetBrains.ProjectModel.IProjectFile, JetBrains.ProjectModel.IProjectFile>> DependentFilesCache { get; }
        public override bool IsLinked { get; }
        public override JetBrains.ProjectModel.ProjectItemKind Kind { get; }
        public override JetBrains.Util.FileSystemPath Location { get; }
        public override string Name { get; }
        public JetBrains.ProjectModel.ProjectFolderPath Path { get; }
        public override void Accept(JetBrains.ProjectModel.ProjectVisitor projectVisitor) { }
        protected internal void AddSubItem(JetBrains.ProjectModel.ProjectItemBase child) { }
        protected override void AdviseFileSystemChanges() { }
        public override void Cleanup() { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ProjectModel.IProjectFile DoCreateFile(JetBrains.Util.FileSystemPath location, JetBrains.ProjectModel.Properties.IProjectFileProperties projectFileProperties) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ProjectModel.IProjectFile DoCreateFile(JetBrains.ProjectModel.ProjectFilePath path, JetBrains.ProjectModel.Properties.IProjectFileProperties properties) { }
        public JetBrains.ProjectModel.IProjectFolder DoCreateFolder(JetBrains.ProjectModel.ProjectFolderPath projectFolderPath) { }
        public override void DoRename(string newName) { }
        protected static void DumpItems(System.IO.TextWriter to, int indent, System.Collections.Generic.ICollection<JetBrains.ProjectModel.IProjectItem> subItems) { }
        protected virtual void DumpSelf(System.IO.TextWriter to, int indent) { }
        public virtual JetBrains.ProjectModel.IProjectItem FindProjectItemByLocation(JetBrains.Util.FileSystemPath path) { }
        public override JetBrains.ProjectModel.ProjectModelChange GetChangeDelta(JetBrains.ProjectModel.ProjectModelChangeType changeType) { }
        public virtual JetBrains.ProjectModel.IProjectItem GetSubItem(string name) { }
        public System.Collections.Generic.IList<JetBrains.ProjectModel.IProjectItem> GetSubItems(string name) { }
        public System.Collections.Generic.IList<JetBrains.ProjectModel.IProjectItem> GetSubItems() { }
        public override void OnRemove() { }
        public void OnSubItemMoved(JetBrains.ProjectModel.IProjectItem subItem, string oldName) { }
        protected static void ReadProjectFolderProperties(System.IO.BinaryReader reader, JetBrains.ProjectModel.ProjectFolderImpl projectFolder, JetBrains.Util.FileSystemPath baseLocation, JetBrains.ProjectModel.Impl.SolutionElement solutionElement, JetBrains.ProjectModel.Impl.ProjectSerializationIndex index, JetBrains.ProjectModel.Properties.IProjectFilePropertiesProvider filePropertiesProvider) { }
        public virtual void RemoveSubItem(JetBrains.ProjectModel.ProjectItemBase child) { }
        protected override void SubtreeChanged() { }
        public override string ToString() { }
        public virtual bool WriteProjectFolder(System.IO.BinaryWriter writer, JetBrains.ProjectModel.Impl.ProjectSerializationIndex index, JetBrains.Util.FileSystemPath baseLocation) { }
        protected bool WriteProjectFolderProperties(System.IO.BinaryWriter writer, JetBrains.ProjectModel.Impl.ProjectSerializationIndex index, JetBrains.Util.FileSystemPath baseLocation) { }
    }
    public class ProjectFolderPath
    {
        public ProjectFolderPath(string shortName, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.Util.FileSystemPath referencedFolderPath) { }
        public bool IsVirtualPath { get; }
        public JetBrains.Util.FileSystemPath ReferencedFolderPath { get; }
        public string ShortName { get; }
        public static JetBrains.ProjectModel.ProjectFolderPath ReadProjectItemPath(System.IO.BinaryReader reader) { }
        public override string ToString() { }
        public void WriteProjectItemPath(System.IO.BinaryWriter writer, JetBrains.Util.FileSystemPath baseLocation) { }
    }
    public class ProjectImpl : JetBrains.ProjectModel.ProjectFolderImpl, JetBrains.ProjectModel.IModule, JetBrains.ProjectModel.IProject, JetBrains.ProjectModel.IProjectCollection, JetBrains.ProjectModel.IProjectElement, JetBrains.ProjectModel.IProjectFolder, JetBrains.ProjectModel.IProjectItem, JetBrains.ProjectModel.IProjectModelElement, JetBrains.Util.IUserDataHolder, System.IDisposable
    {
        protected ProjectImpl([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.Impl.SolutionElement solutionElement, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.Properties.IProjectProperties projectProperties, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.IShellLocks locks, System.Guid guid, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ProjectModel.ProjectFolderImpl parentProject, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.FileSystemPath location, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.FileSystemPath projectFileLocation, string projectName) { }
        public System.Guid Guid { get; }
        public bool IsOpened { get; set; }
        public override JetBrains.ProjectModel.ProjectItemKind Kind { get; }
        public override JetBrains.Util.FileSystemPath Location { get; }
        public virtual string Name { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ProjectModel.Model2.Assemblies.Interfaces.IAssembly OutputAssembly { get; set; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ProjectModel.OutputAssemblyInfo OutputAssemblyInfo { get; set; }
        public JetBrains.ProjectModel.PlatformID PlatformID { get; }
        public string Presentation { get; }
        public JetBrains.ProjectModel.IProjectFile ProjectFile { get; }
        public JetBrains.Util.FileSystemPath ProjectFileLocation { get; }
        public JetBrains.ProjectModel.Properties.IProjectProperties ProjectProperties { get; }
        public override void Accept(JetBrains.ProjectModel.ProjectVisitor projectVisitor) { }
        public JetBrains.ProjectModel.IProject AddProjectFromLocation(JetBrains.ProjectModel.Properties.IProjectProperties projectProperties, JetBrains.Util.FileSystemPath projectFileLocation, System.Guid projectGuid) { }
        public void AddSdkReference(JetBrains.ProjectModel.References.Impl.SdkReferenceImpl referenceImplToAdd) { }
        protected internal override void AddSubItem(JetBrains.ProjectModel.ProjectItemBase child) { }
        protected override void AdviseFileSystemChanges() { }
        public override void AssertIsValid() { }
        public static JetBrains.ProjectModel.ProjectImpl CreateProjectImpl(JetBrains.ProjectModel.Impl.SolutionElement solutionElement, JetBrains.ProjectModel.Properties.IProjectProperties projectProperties, JetBrains.Application.IShellLocks locks, System.Guid guid, JetBrains.ProjectModel.ProjectFolderImpl parentProject, JetBrains.Util.FileSystemPath location, JetBrains.Util.FileSystemPath projectFileLocation, string projectName) { }
        public static JetBrains.ProjectModel.ProjectImpl CreateProjectImpl(JetBrains.ProjectModel.Impl.SolutionElement solutionElement, JetBrains.ProjectModel.Properties.IProjectProperties projectProperties, JetBrains.Application.IShellLocks locks, System.Guid guid, JetBrains.ProjectModel.ProjectFolderImpl parentFolder, JetBrains.Util.FileSystemPath projectFileLocation) { }
        public void Dispose() { }
        public void DoAddReference(JetBrains.ProjectModel.IProjectToModuleReference addedReference) { }
        public void DoCreateProjectFile(JetBrains.Util.FileSystemPath projectFilePath, JetBrains.ProjectModel.Properties.IProjectFileProperties projectFileProperties) { }
        protected override void DoMoveImpl(JetBrains.ProjectModel.IProjectFolder newParentItem) { }
        public override void DoRemove() { }
        public void DoRemoveReference(JetBrains.ProjectModel.IProjectToModuleReference referenceToRemove) { }
        public override void DoRename(string newName) { }
        protected override void DumpSelf(System.IO.TextWriter to, int indent) { }
        public System.Collections.Generic.ICollection<JetBrains.ProjectModel.IProject> GetAllProjects() { }
        public override JetBrains.ProjectModel.ProjectModelChange GetChangeDelta(JetBrains.ProjectModel.ProjectModelChangeType changeType) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ProjectModel.IProjectToModuleReference> GetModuleReferences() { }
        public JetBrains.Util.FileSystemPath GetOutputDirectory() { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.Util.FileSystemPath GetOutputFilePath() { }
        public override JetBrains.ProjectModel.IProject GetProject() { }
        public System.Collections.Generic.ICollection<JetBrains.ProjectModel.IProjectToModuleReference> GetReferences() { }
        public override JetBrains.ProjectModel.ISolution GetSolution() { }
        public bool HasFlavour<T>()
            where T : JetBrains.ProjectModel.Properties.IProjectFlavor { }
        public override bool IsValid() { }
        public void MoveToNewLocation(JetBrains.Util.FileSystemPath newProjectFileLocation) { }
        public void PropertiesChanged() { }
        public static JetBrains.ProjectModel.ProjectImpl ReadProject(System.IO.BinaryReader reader, JetBrains.ProjectModel.Impl.SolutionElement solutionElement, JetBrains.ProjectModel.Impl.ProjectSerializationIndex index, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ProjectModel.ProjectFolderImpl containingFolder, JetBrains.Util.FileSystemPath baseLocation) { }
        public override void RemoveSubItem(JetBrains.ProjectModel.ProjectItemBase child) { }
        public override string ToString() { }
        public JetBrains.Util.FileSystemPath TryResolveByHintPath(JetBrains.Metadata.Utils.AssemblyNameInfo assemblyNameInfo) { }
        public override bool WriteProjectFolder(System.IO.BinaryWriter writer, JetBrains.ProjectModel.Impl.ProjectSerializationIndex serializationIndex, JetBrains.Util.FileSystemPath baseLocation) { }
    }
    public abstract class ProjectItemBase : JetBrains.Util.UserDataHolder, JetBrains.ProjectModel.IProjectElement, JetBrains.ProjectModel.IProjectItem, JetBrains.ProjectModel.IProjectItemActions, JetBrains.ProjectModel.IProjectModelElement, JetBrains.ProjectModel.IProjectModelElementInternal, JetBrains.Util.IUserDataHolder
    {
        protected JetBrains.Application.IShellLocks myLocks;
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ProjectModel.ProjectFolderImpl myParentFolder;
        protected ProjectItemBase(JetBrains.ProjectModel.ProjectFolderImpl parentFolder) { }
        public JetBrains.Application.FileSystemTracker.IFileSystemTracker FileSystemTracker { get; }
        public abstract bool IsLinked { get; }
        public abstract JetBrains.ProjectModel.ProjectItemKind Kind { get; }
        public abstract JetBrains.Util.FileSystemPath Location { get; }
        public JetBrains.Application.IShellLocks Locks { get; }
        public abstract string Name { get; }
        public JetBrains.ProjectModel.IProjectFolder ParentFolder { get; }
        public virtual void Accept(JetBrains.ProjectModel.ProjectVisitor projectVisitor) { }
        protected abstract void AdviseFileSystemChanges();
        public virtual void AssertIsValid() { }
        public virtual void Cleanup() { }
        protected void DoAdviseFileSystemChanges() { }
        public void DoMove(JetBrains.ProjectModel.IProjectFolder newParentItem) { }
        protected virtual void DoMoveImpl(JetBrains.ProjectModel.IProjectFolder newParentItem) { }
        public virtual void DoRemove() { }
        public abstract void DoRename(string oldName);
        public virtual void Dump(System.IO.TextWriter to) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public virtual JetBrains.ProjectModel.ProjectModelChange GetChangeDelta(JetBrains.ProjectModel.ProjectModelChangeType changeType) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public string GetPersistentID() { }
        public string GetPresentableProjectPath() { }
        public virtual JetBrains.ProjectModel.IProject GetProject() { }
        public virtual object GetProperty(JetBrains.Util.Key propertyName) { }
        public virtual JetBrains.ProjectModel.ISolution GetSolution() { }
        public virtual bool IsValid() { }
        public virtual void OnOpen() { }
        public virtual void OnRemove() { }
        public virtual void SetProperty(JetBrains.Util.Key propertyName, object propertyValue) { }
        protected virtual void SubtreeChanged() { }
        protected void UnadviseFileSystemChanges() { }
        protected class MyOpenVisitor : JetBrains.ProjectModel.RecursiveProjectVisitor
        {
            public override void VisitProjectItem(JetBrains.ProjectModel.IProjectItem projectItem) { }
        }
    }
    public class ProjectItemChange : JetBrains.ProjectModel.ProjectModelChange
    {
        public ProjectItemChange(System.Collections.Generic.IList<JetBrains.ProjectModel.ProjectModelChange> childrenDeltas, JetBrains.ProjectModel.IProjectItem projectModelElement, JetBrains.ProjectModel.IProjectFolder oldParentFolder, JetBrains.ProjectModel.ProjectModelChangeType changeType, JetBrains.Util.FileSystemPath oldLocation, JetBrains.ProjectModel.ExternalChangeType externalChangeType, string oldPersistentId) { }
        public ProjectItemChange(System.Collections.Generic.IList<JetBrains.ProjectModel.ProjectModelChange> childrenDeltas, JetBrains.ProjectModel.IProjectItem projectModelElement, JetBrains.ProjectModel.IProjectFolder oldParentItem, JetBrains.ProjectModel.ProjectModelChangeType changeType, JetBrains.Util.FileSystemPath oldLocation, string oldPersistentId) { }
        protected override string ElementDescription { get; }
        protected override string ElementPath { get; }
        public bool IsContentsExternallyChanged { get; }
        public JetBrains.Util.FileSystemPath OldLocation { get; }
        public JetBrains.ProjectModel.IProjectFolder OldParentFolder { get; }
        public string OldPersistentId { get; }
        public JetBrains.ProjectModel.IProjectItem ProjectItem { get; }
        public override void Accept(JetBrains.ProjectModel.IProjectModelChangeDeltaVisitor visitor) { }
        protected override void CollectAffectedSolutionFiles(System.Collections.Generic.JetHashSet<JetBrains.ProjectModel.IProjectFile> affectedSolutionFiles) { }
        protected override string GetExtendedDump() { }
        public override JetBrains.ProjectModel.IProject GetOldProject() { }
        public override JetBrains.ProjectModel.ProjectModelChange Propagate() { }
    }
    public class static ProjectItemExtensions
    {
        public static void SetAddedExplicitlyPropertyRecursive(this JetBrains.ProjectModel.IProjectItem projectItem, bool value) { }
    }
    public enum ProjectItemKind : short
    {
        UNKNOWN = 0,
        PHYSICAL_FILE = 1,
        PHYSICAL_DIRECTORY = 2,
        PROJECT = 3,
        VIRTUAL_DIRECTORY = 4,
    }
    public class ProjectItemsVisitor<TProjectItem> : JetBrains.ProjectModel.RecursiveProjectVisitor
        where TProjectItem :  class, JetBrains.ProjectModel.IProjectItem
    {
        public ProjectItemsVisitor(System.Action<TProjectItem> actionWithItem) { }
        public override void VisitProjectItem(JetBrains.ProjectModel.IProjectItem projectItem) { }
    }
    [System.FlagsAttribute()]
    public enum ProjectKind : byte
    {
        UNSUPPORTED = 0,
        REGULAR_PROJECT = 1,
        SOLUTION_FOLDER = 2,
        WEB_SITE = 4,
        SOLUTION_PROJECT = 16,
        MISC_FILES_PROJECT = 64,
        SDK_MODULE = 128,
    }
    public class static ProjectLanguageUtil
    {
        public static JetBrains.ProjectModel.Properties.ProjectLanguage GetLanguageTypeForWebSite([JetBrains.Annotations.CanBeNullAttribute()] string s) { }
    }
    [JetBrains.ProjectModel.ProjectComponentAttribute()]
    public class ProjectLocationLive
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly JetBrains.ProjectModel.IProject Project;
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly JetBrains.DataFlow.IProperty<JetBrains.Util.FileSystemPath> ProjectFileLocation;
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly JetBrains.DataFlow.IProperty<JetBrains.Util.FileSystemPath> ProjectLocation;
        public ProjectLocationLive(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.IShellLocks locks, JetBrains.ProjectModel.IProject project) { }
        public void SetLocations(JetBrains.Util.FileSystemPath projectLocation, JetBrains.Util.FileSystemPath projectFileLocation) { }
    }
    public abstract class ProjectManager
    {
        public abstract void CloseProject([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IProject project);
        public abstract System.Collections.Generic.IEnumerable<T> GetComponents<T>(JetBrains.ProjectModel.IProject project)
            where T :  class;
        public static JetBrains.ProjectModel.ProjectManager GetInstance([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.ISolution solution) { }
        public static bool HasInstance(JetBrains.ProjectModel.ISolution solution) { }
        public abstract void OpenProject(JetBrains.ProjectModel.IProject project, JetBrains.ProjectModel.Tasks.ISolutionLoadTasksScheduler scheduler);
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class ProjectManagerBase : JetBrains.ProjectModel.ProjectManager
    {
        public ProjectManagerBase(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.Components.IComponentContainer container, JetBrains.Application.Parts.IPartsCatalogueSet catalogueSet, JetBrains.ProjectModel.ISolution solution, JetBrains.Application.IShellLocks locks, JetBrains.Application.Env.RunsProducts.ProductConfigurations productConfigurations) { }
        public override void CloseProject(JetBrains.ProjectModel.IProject project) { }
        public override System.Collections.Generic.IEnumerable<T> GetComponents<T>(JetBrains.ProjectModel.IProject project)
            where T :  class { }
        public override void OpenProject(JetBrains.ProjectModel.IProject project, JetBrains.ProjectModel.Tasks.ISolutionLoadTasksScheduler scheduler) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class ProjectManagerInitializer
    {
        public ProjectManagerInitializer(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ProjectModel.ISolution solution, JetBrains.ProjectModel.ProjectManager projectManager, JetBrains.Application.IShellLocks locks, JetBrains.ProjectModel.ProjectModelElementPointerManager doNotRemove, JetBrains.ProjectModel.Tasks.ISolutionLoadTasksScheduler scheduler) { }
    }
    public abstract class ProjectModelChange
    {
        public static readonly JetBrains.ProjectModel.ProjectModelChange[] EMPTY_DELTAS;
        protected ProjectModelChange(System.Collections.Generic.IList<JetBrains.ProjectModel.ProjectModelChange> childrenDeltas, JetBrains.ProjectModel.IProjectModelElement projectModelElement, JetBrains.ProjectModel.ProjectModelChangeType changeType) { }
        protected abstract string ElementDescription { get; }
        protected abstract string ElementPath { get; }
        public bool IsAdded { get; }
        public bool IsClosingSolution { get; }
        public bool IsExternallyChanged { get; }
        public bool IsMovedIn { get; }
        public bool IsMovedOut { get; }
        public bool IsOpeningSolution { get; }
        public bool IsPropertiesChanged { get; }
        public bool IsRemoved { get; }
        public bool IsSubtreeChanged { get; }
        public JetBrains.ProjectModel.ProjectModelChange ParentDelta { get; }
        public JetBrains.ProjectModel.IProjectModelElement ProjectModelElement { get; }
        public JetBrains.ProjectModel.PropertyChangeSupport PropertyChangeSupport { get; }
        public virtual void Accept(JetBrains.ProjectModel.IProjectModelChangeDeltaVisitor visitor) { }
        protected virtual void CollectAffectedSolutionFiles(System.Collections.Generic.JetHashSet<JetBrains.ProjectModel.IProjectFile> affectedSolutionFiles) { }
        public bool ContainsChangeType(JetBrains.ProjectModel.ProjectModelChangeType changeType) { }
        public void Dump(System.IO.TextWriter to) { }
        public string Dump() { }
        public System.Collections.Generic.ICollection<JetBrains.ProjectModel.IProjectFile> GetAffectedSolutionFiles() { }
        public System.Collections.Generic.Dictionary<JetBrains.ProjectModel.IProjectModelElement, JetBrains.ProjectModel.ProjectModelChange>.ValueCollection GetChildren() { }
        protected virtual string GetExtendedDump() { }
        public JetBrains.ProjectModel.IProject GetNewProject() { }
        protected JetBrains.ProjectModel.IProjectFile GetNewProjectFile() { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public virtual JetBrains.ProjectModel.IProject GetOldProject() { }
        protected JetBrains.ProjectModel.IProjectFile GetOldProjectFile() { }
        public JetBrains.ProjectModel.ISolution GetSolution() { }
        protected JetBrains.ProjectModel.IProjectFile GetSolutionFile() { }
        protected bool IsOpeningOrClosingProject() { }
        public static System.Collections.Generic.IList<JetBrains.ProjectModel.ProjectModelChange> Merge(System.Collections.Generic.IList<JetBrains.ProjectModel.ProjectModelChange> firstDeltas, System.Collections.Generic.IList<JetBrains.ProjectModel.ProjectModelChange> secondDeltas) { }
        protected virtual JetBrains.ProjectModel.ProjectModelChange Merge(JetBrains.ProjectModel.ProjectModelChange other) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public abstract JetBrains.ProjectModel.ProjectModelChange Propagate();
    }
    [System.FlagsAttribute()]
    public enum ProjectModelChangeType
    {
        UNKNOWN = 0,
        ADDED = 1,
        REMOVED = 2,
        MOVED_OUT = 4,
        MOVED_IN = 8,
        SUBTREE = 16,
        EXTERNAL_CHANGE = 32,
        PROPERTIES = 64,
        REFERENCE_TARGET = 128,
        PROJECT_STRUCTURE_AND_COMPONENTS_READY = 256,
        PROJECT_MODEL_CACHES_READY = 512,
    }
    public abstract class ProjectModelEditorBase : JetBrains.ProjectModel.IProjectModelEditor
    {
        protected ProjectModelEditorBase(JetBrains.ProjectModel.ISolution solution, JetBrains.ProjectModel.IProjectModelTransactionManager projectModelTransactionManager, JetBrains.Application.IShellLocks locks, JetBrains.ProjectModel.Assemblies.Impl.ModuleReferenceResolveManager moduleReferenceResolveManager) { }
        protected JetBrains.Application.IShellLocks Locks { get; }
        protected JetBrains.ProjectModel.Assemblies.Impl.ModuleReferenceResolveManager ModuleReferenceResolveManager { get; }
        public JetBrains.ProjectModel.IProjectToAssemblyReference AddAssemblyReference(JetBrains.ProjectModel.IProject project, JetBrains.Util.FileSystemPath fullPathToReferencedLibrary) { }
        public virtual JetBrains.ProjectModel.IProjectFile AddFile(JetBrains.ProjectModel.IProjectFolder parentFolder, JetBrains.Util.FileSystemPath location) { }
        public virtual JetBrains.ProjectModel.IProjectFolder AddFolder(JetBrains.ProjectModel.IProjectFolder parentFolder, string name, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.Util.FileSystemPath folderPath = null) { }
        public JetBrains.ProjectModel.IProjectToModuleReference AddModuleReference(JetBrains.ProjectModel.IProject project, JetBrains.ProjectModel.IModule referenceToAdd) { }
        public bool CanAddFile(JetBrains.ProjectModel.IProjectFolder parentFolder, JetBrains.Util.FileSystemPath location, out string reason) { }
        public virtual bool CanAddFolder(JetBrains.ProjectModel.IProjectFolder parentFolder, string name, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.Util.FileSystemPath folderPath, out string reason) { }
        public bool CanCopy(JetBrains.ProjectModel.IProjectItem projectItem, JetBrains.ProjectModel.IProjectFolder newParentItem, out string reason) { }
        public virtual bool CanMove(JetBrains.ProjectModel.IProjectItem projectItem, JetBrains.ProjectModel.IProjectFolder newParentItem, out string reason) { }
        public bool CanRemove(JetBrains.ProjectModel.IProjectItem projectItem, out string reason) { }
        public bool CanRename(JetBrains.ProjectModel.IProjectItem projectItem, string newName, out string reason) { }
        public JetBrains.ProjectModel.IProjectItem Copy(JetBrains.ProjectModel.IProjectItem projectItem, JetBrains.ProjectModel.IProjectFolder newParentItem) { }
        protected abstract JetBrains.ProjectModel.Transaction.Actions.AddFileAction CreateAddFileAction(JetBrains.ProjectModel.IProjectFolder parentFolder, JetBrains.Util.FileSystemPath location);
        protected abstract JetBrains.ProjectModel.Model2.Transaction.Actions.AddFolderAction CreateAddFolderAction(JetBrains.ProjectModel.IProjectFolder parentFolder, string name, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.Util.FileSystemPath folderPath);
        protected abstract JetBrains.ProjectModel.Model2.Transaction.Actions.AddReferenceAction CreateAddReferenceAction(JetBrains.ProjectModel.IProject project, JetBrains.ProjectModel.IModule referenceToAdd);
        protected abstract JetBrains.ProjectModel.Model2.Transaction.Actions.AddReferenceAction2 CreateAddReferenceAction2(JetBrains.ProjectModel.IProject project, JetBrains.Util.FileSystemPath fullPathToReferencedLibrary);
        protected abstract JetBrains.ProjectModel.Model2.Transaction.Actions.CopyAction CreateCopyAction(JetBrains.ProjectModel.IProjectItem projectItem, JetBrains.ProjectModel.IProjectFolder newParentItem);
        protected abstract JetBrains.ProjectModel.Model2.Transaction.Actions.MoveAction CreateMoveAction(JetBrains.ProjectModel.IProjectItem projectItem, JetBrains.ProjectModel.IProjectFolder newParentItem);
        protected abstract JetBrains.ProjectModel.Model2.Transaction.Actions.RemoveAction CreateRemoveAction(JetBrains.ProjectModel.IProjectItem projectItem);
        protected abstract JetBrains.ProjectModel.Model2.Transaction.Actions.RemoveReferenceAction CreateRemoveReferenceAction(JetBrains.ProjectModel.IProjectToModuleReference referenceToRemove);
        protected abstract JetBrains.ProjectModel.Model2.Transaction.Actions.RenameAction CreateRenameAction(JetBrains.ProjectModel.IProjectItem projectItem, string newName);
        public void Move(JetBrains.ProjectModel.IProjectItem projectItem, JetBrains.ProjectModel.IProjectFolder newParentItem) { }
        public static void MoveDiskEntity(JetBrains.Util.FileSystemPath oldLocation, JetBrains.Util.FileSystemPath newLocation) { }
        public void Remove(JetBrains.ProjectModel.IProjectItem projectItem) { }
        public static void RemoveDiskEntity(JetBrains.Util.FileSystemPath location) { }
        public void RemoveModuleReference(JetBrains.ProjectModel.IProjectToModuleReference referenceToRemove) { }
        public void Rename(JetBrains.ProjectModel.IProjectItem projectItem, string newName) { }
    }
    public class ProjectModelElementEnvoy
    {
        public ProjectModelElementEnvoy([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IProjectModelElement element, JetBrains.ProjectModel.ISolution solution, JetBrains.ProjectModel.ProjectModelElementPointerManager pmepm) { }
        public ProjectModelElementEnvoy([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IProjectModelElement element) { }
        public static JetBrains.ProjectModel.ProjectModelElementEnvoy Empty { get; }
        public bool IsValid { get; }
        public string Name { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ProjectModel.ISolution Solution { get; }
        public string Text { get; }
        public static JetBrains.ProjectModel.ProjectModelElementEnvoy Create([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ProjectModel.IProjectModelElement element) { }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ProjectModel.IProjectModelElement GetValidProjectElement() { }
        public void Present<TStructureElement>(JetBrains.UI.TreeView.StructuredPresenter<TStructureElement, JetBrains.CommonControls.IPresentableItem> presenter, TStructureElement structureElement, JetBrains.CommonControls.IPresentableItem item, JetBrains.UI.TreeView.PresentationState state)
            where TStructureElement : JetBrains.Util.IPresentableStructureElement { }
        public override string ToString() { }
    }
    public class static ProjectModelElementExtension
    {
        [System.Diagnostics.ConditionalAttribute("JET_MODE_ASSERT")]
        public static void AssertIsValid(this JetBrains.ProjectModel.IProjectModelElement element) { }
    }
    public class static ProjectModelElementPointerExtensions
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.ProjectModel.IProjectModelElementPointer CreatePointer([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ProjectModel.IProjectModelElement element) { }
        public static string GetPersistentId([JetBrains.Annotations.CanBeNullAttribute()] this JetBrains.ProjectModel.IProjectModelElementPointer pointer, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.ISolution solution) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ProjectModel.IProjectModelElement GetValidProjectElement([JetBrains.Annotations.CanBeNullAttribute()] this JetBrains.ProjectModel.IProjectModelElementPointer pointer, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.ISolution solution) { }
    }
    public abstract class ProjectModelElementPointerManager
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public abstract JetBrains.ProjectModel.IProjectModelElementPointer CreatePointer([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IProjectModelElement element);
        [JetBrains.Annotations.NotNullAttribute()]
        public abstract JetBrains.ProjectModel.IProjectModelElementPointer CreatePointer(string persistentId);
        public abstract void Dump(System.IO.TextWriter writer, JetBrains.Util.FileSystemPath basePath);
        public abstract System.Collections.Generic.IList<JetBrains.ProjectModel.IProjectModelElementPointer> GetAllPointersToTheSameElement(JetBrains.ProjectModel.IProjectModelElementPointer pointer);
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.ProjectModel.ProjectModelElementPointerManager GetInstance([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.ISolution solution) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public abstract string GetPersistentId(JetBrains.ProjectModel.IProjectModelElementPointer pointer);
        [JetBrains.Annotations.CanBeNullAttribute()]
        public abstract JetBrains.ProjectModel.IProjectModelElement GetValidProjectModelElement([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ProjectModel.IProjectModelElementPointer pointer);
    }
    public class static ProjectModelElementPointerManagerEx
    {
        public static System.Collections.Generic.IList<JetBrains.ProjectModel.IProjectModelElementPointer> GetAllPointersToTheSameElement([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ProjectModel.ProjectModelElementPointerManager manager, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IProjectModelElement element) { }
        public static System.Collections.Generic.IList<JetBrains.ProjectModel.IProjectModelElementPointer> GetAllPointersToTheSameElement([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ProjectModel.ProjectModelElementPointerManager manager, [JetBrains.Annotations.NotNullAttribute()] string persistentId) { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class ProjectModelElementPresentationService
    {
        public ProjectModelElementPresentationService(JetBrains.DataFlow.Lifetime lifetime, JetBrains.DataFlow.IViewable<JetBrains.ProjectModel.IProjectModelElementPresenter> presenters) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.UI.Icons.IconId GetIcon([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IProjectModelElement projectModelElement) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public string GetPresentableLocation([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IProjectModelElement projectModelElement) { }
    }
    [JetBrains.Annotations.BaseTypeRequiredAttribute(typeof(JetBrains.ProjectModel.IProjectModelElementPresenter))]
    [JetBrains.Annotations.MeansImplicitUseAttribute()]
    [System.AttributeUsageAttribute(System.AttributeTargets.Class | System.AttributeTargets.All, AllowMultiple=false)]
    public class ProjectModelElementPresenterAttribute : JetBrains.Application.ShellComponentAttribute
    {
        public ProjectModelElementPresenterAttribute(double priority) { }
        public double Priority { get; }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class ProjectModelIcons
    {
        public virtual JetBrains.UI.Icons.IconId AssemblyIcon { get; }
        public virtual JetBrains.UI.Icons.IconId AssemblyReferenceIcon { get; }
        public virtual JetBrains.UI.Icons.IconId CSharpProjectIcon { get; }
        public virtual JetBrains.UI.Icons.IconId DirectoryIcon { get; }
        public virtual JetBrains.UI.Icons.IconId MissingFileIcon { get; }
        public virtual JetBrains.UI.Icons.IconId SdkModuleIcon { get; }
        public virtual JetBrains.UI.Icons.IconId SolutionFolderIcon { get; }
        public virtual JetBrains.UI.Icons.IconId UnknownIcon { get; }
        public virtual JetBrains.UI.Icons.IconId VisualBasicProjectIcon { get; }
    }
    [JetBrains.ProjectModel.SolutionInstanceComponentAttribute()]
    public class ProjectModelKickOff
    {
        public ProjectModelKickOff(JetBrains.ProjectModel.ISolution solution, JetBrains.ProjectModel.Tasks.ISolutionLoadTasksScheduler scheduler, JetBrains.Application.IShellLocks locks) { }
    }
    public class ProjectOutputChange
    {
        public ProjectOutputChange(JetBrains.ProjectModel.IProject projectWithOutput, JetBrains.ProjectModel.Model2.Assemblies.Interfaces.IAssembly mergedAssembly, JetBrains.ProjectModel.Model2.Assemblies.Interfaces.IAssembly separateAssembly, JetBrains.ProjectModel.ProjectModelChangeType changeType) { }
        public JetBrains.ProjectModel.ProjectModelChangeType ChangeType { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ProjectModel.Model2.Assemblies.Interfaces.IAssembly MergedAssembly { get; }
        public JetBrains.ProjectModel.IProject Project { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ProjectModel.Model2.Assemblies.Interfaces.IAssembly SeparateAssembly { get; }
    }
    public enum ProjectOutputType : byte
    {
        CONSOLE_EXE = 0,
        WIN_EXE = 1,
        LIBRARY = 2,
        MODULE = 3,
        WINMDOBJ = 4,
        APPCONTAINEREXE = 5,
        UNKNOWN = 6,
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class ProjectPresentablePathCache : JetBrains.ProjectModel.IProjectPresentablePathProvider
    {
        public ProjectPresentablePathCache(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ProjectModel.ISolution solution, JetBrains.Application.ChangeManager changeManager) { }
        public string GetPresentableProjectPath(JetBrains.ProjectModel.IProjectItem projectItem) { }
    }
    public class ProjectReferenceChange : JetBrains.ProjectModel.ProjectModelChange
    {
        public ProjectReferenceChange(JetBrains.ProjectModel.IProjectToModuleReference projectModelElement, JetBrains.ProjectModel.ProjectModelChangeType changeType) { }
        protected override string ElementDescription { get; }
        protected override string ElementPath { get; }
        public JetBrains.ProjectModel.IProjectToModuleReference ProjectToModuleReference { get; }
        public override void Accept(JetBrains.ProjectModel.IProjectModelChangeDeltaVisitor visitor) { }
        protected override void CollectAffectedSolutionFiles(System.Collections.Generic.JetHashSet<JetBrains.ProjectModel.IProjectFile> affectedSolutionFiles) { }
        public override JetBrains.ProjectModel.IProject GetOldProject() { }
        protected override JetBrains.ProjectModel.ProjectModelChange Merge(JetBrains.ProjectModel.ProjectModelChange other) { }
        public override JetBrains.ProjectModel.ProjectModelChange Propagate() { }
    }
    public class ProjectReferenceTargetChange : JetBrains.ProjectModel.ProjectReferenceChange
    {
        public ProjectReferenceTargetChange(JetBrains.ProjectModel.IProjectToModuleReference projectModelElement, JetBrains.ProjectModel.ProjectModelChangeType changeType, JetBrains.ProjectModel.IModule oldReferenceTarget, JetBrains.ProjectModel.IModule newReferenceTarget) { }
        public bool IsReferenceTargetChanged { get; }
        public JetBrains.ProjectModel.IModule NewReferenceTarget { get; }
        public JetBrains.ProjectModel.IModule OldReferenceTarget { get; }
        protected override string GetExtendedDump() { }
    }
    public class ProjectSdkReferenceChange : JetBrains.ProjectModel.ProjectModelChange
    {
        public ProjectSdkReferenceChange(JetBrains.ProjectModel.IProjectModelElement projectModelElement, JetBrains.ProjectModel.ProjectModelChangeType changeType) { }
        protected override string ElementDescription { get; }
        protected override string ElementPath { get; }
        public JetBrains.ProjectModel.References.Impl.SdkReferenceImpl SdkReferenceImpl { get; }
        public override void Accept(JetBrains.ProjectModel.IProjectModelChangeDeltaVisitor visitor) { }
        public override JetBrains.ProjectModel.IProject GetOldProject() { }
        public override JetBrains.ProjectModel.ProjectModelChange Propagate() { }
    }
    public class static ProjectTypesGuid
    {
        public static readonly System.Guid CSharpLangService;
        public static readonly System.Guid DBProject;
        public static readonly System.Guid FSharp;
        public static readonly System.Guid InstallShieldProject;
        public static readonly System.Guid InstallShieldProjectLight;
        public static System.Guid IUnknown;
        public static readonly System.Guid MetroStyleAppGuid;
        public static System.Guid PerformanceAnalyzerGuid;
        public static System.Guid RegularProjectAsWebsiteForTests;
        public static readonly System.Guid SilverlightProject;
        public static readonly System.Guid SolutionItemsProject;
        public static readonly System.Guid SqlServerDatabaseProject;
        public static readonly System.Guid UnloadedProject;
        public static readonly System.Guid VBLangService;
        public static readonly System.Guid VBSmartDevice;
        public static readonly System.Guid Vs2005WebSite;
        public static readonly System.Guid VsPerformanceAnalyzerProject;
        public static readonly System.Guid WindowsCSharp;
        public static readonly System.Guid WindowsPhone;
        public static readonly System.Guid WorkflowProject;
    }
    public class static ProjectUtil
    {
        public const string PROJECT_PATH_SEPARATOR = "/";
        public static readonly JetBrains.Util.Key<System.Xml.XmlNode> XmlElementKey;
        public static JetBrains.ProjectModel.IProjectPresentablePathProvider ProjectPresentablePathProvider { get; }
        public static JetBrains.TreeModels.CascadeGroup CreateCascade([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IProjectItem item) { }
        public static JetBrains.TreeModels.CascadeGroup CreateCascade([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ProjectModel.IProjectItem item, JetBrains.ProjectModel.ProjectModelElementPointerManager projectModelElementPointerManager, JetBrains.ProjectModel.ISolution solution) { }
        public static JetBrains.ProjectModel.IProjectElement FindProjectElementByPersistentID(JetBrains.ProjectModel.ISolution solution, string id) { }
        public static int GetFileCount(JetBrains.ProjectModel.IProjectModelElement projectItem) { }
        public static JetBrains.ProjectModel.IProjectItem[] GetFilteredSubItems(JetBrains.ProjectModel.IProjectFolder projectFolder, System.Predicate<JetBrains.ProjectModel.IProjectItem> filter) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Collections.Generic.IEnumerable<JetBrains.ProjectModel.IProjectFolder> GetParentFolders([JetBrains.Annotations.CanBeNullAttribute()] this JetBrains.ProjectModel.IProjectItem item) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Collections.Generic.IEnumerable<JetBrains.ProjectModel.IProjectItem> GetPathChain([JetBrains.Annotations.CanBeNullAttribute()] this JetBrains.ProjectModel.IProjectItem item) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Collections.Generic.IEnumerable<JetBrains.ProjectModel.IProjectFolder> GetPathChain([JetBrains.Annotations.CanBeNullAttribute()] this JetBrains.ProjectModel.IProjectFolder item) { }
        public static string GetPersistentID(JetBrains.ProjectModel.IProjectItem projectItem) { }
        public static string GetPersistentID(JetBrains.ProjectModel.IProjectToModuleReference projectToModuleReference) { }
        public static string GetPersistentID(JetBrains.ProjectModel.References.Impl.SdkReferenceImpl sdkReferenceImpl) { }
        public static string GetPresentableProjectPath(System.Collections.Generic.IEnumerable<JetBrains.ProjectModel.IProjectItem> pathChain) { }
        public static string GetPresentableProjectPath(JetBrains.ProjectModel.IProjectItem projectItem) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.ProjectModel.IProject GetProjectByFullPath([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.ISolution solution, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.FileSystemPath path) { }
        public static string GetRelativePresentableProjectPath(JetBrains.ProjectModel.IProjectItem projectItem, JetBrains.ProjectModel.IProjectFolder projectFolder) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ProjectModel.IProjectItem GetSubItemRecursively([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ProjectModel.IProjectFolder where, [JetBrains.Annotations.NotNullAttribute()] string what) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Collections.Generic.IEnumerable<JetBrains.ProjectModel.IProjectItem> GetSubItemsRecursively([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ProjectModel.IProjectFolder item) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Collections.Generic.IEnumerable<JetBrains.ProjectModel.IProjectItem> GetSubItemsRecursively([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ProjectModel.IProjectFolder where, [JetBrains.Annotations.NotNullAttribute()] string what) { }
        public static bool IsProjectFromUserView([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ProjectModel.IProject project) { }
        public static string[] ProjectPathAsArray(string projPath) { }
        public static string ProjectPathAsString(string[] projPath) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ProjectModel.IProject TryGetProjectByFullPath([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.ISolution solution, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.FileSystemPath path) { }
    }
    public abstract class ProjectVisitor
    {
        public virtual void VisitAssemblyToAssemblyReference(JetBrains.ProjectModel.Model2.Assemblies.Interfaces.IAssemblyToAssemblyReference reference) { }
        public virtual void VisitModuleToModuleReference(JetBrains.ProjectModel.IProjectToModuleReference reference) { }
        public virtual void VisitProject(JetBrains.ProjectModel.IProject project) { }
        public virtual void VisitProjectAssemblyReference(JetBrains.ProjectModel.IProjectToAssemblyReference reference) { }
        public virtual void VisitProjectFile(JetBrains.ProjectModel.IProjectFile projectFile) { }
        public virtual void VisitProjectFolder(JetBrains.ProjectModel.IProjectFolder projectFolder) { }
        public virtual void VisitProjectItem(JetBrains.ProjectModel.IProjectItem projectItem) { }
        public virtual void VisitProjectModelElement(JetBrains.ProjectModel.IProjectModelElement element) { }
        public virtual void VisitProjectSdkReference(JetBrains.ProjectModel.References.Impl.SdkReferenceImpl sdkReferenceImpl) { }
        public virtual void VisitProjectToProjectReference(JetBrains.ProjectModel.IProjectToProjectReference reference) { }
        public virtual void VisitSolution(JetBrains.ProjectModel.ISolution solution) { }
    }
    public class PropertyChangeInfo
    {
        public PropertyChangeInfo(string propertyName, object oldValue, object newValue) { }
        public object NewValue { get; }
        public object OldValue { get; }
        public string PropertyName { get; }
        public JetBrains.ProjectModel.PropertyChangeInfo MergeWith(JetBrains.ProjectModel.PropertyChangeInfo otherInfo) { }
    }
    public class PropertyChangeSupport
    {
        public System.Collections.Generic.ICollection<JetBrains.ProjectModel.PropertyChangeInfo> GetChangedProperties() { }
        public object GetNewValue(string propertyName) { }
        public object GetOldValue(string propertyName) { }
        public JetBrains.ProjectModel.PropertyChangeInfo GetPropertyChangeInfo(string propertyType) { }
        public bool IsPropertyChanged(string propertyName) { }
        public JetBrains.ProjectModel.PropertyChangeSupport Merge(JetBrains.ProjectModel.PropertyChangeSupport other) { }
        public void OnPropertyChanged(string propertyType, object oldValue, object newValue) { }
    }
    [JetBrains.ProjectModel.ProjectFileTypeDefinitionAttribute("RAZOR_CSHARP", Edition="Csharp")]
    public class RazorCSharpProjectFileType : JetBrains.ProjectModel.RazorProjectFileType
    {
        public static readonly JetBrains.ProjectModel.RazorCSharpProjectFileType Instance;
        public const string Name = "RAZOR_CSHARP";
        public const string RazorCSharpExtension = ".cshtml";
        protected RazorCSharpProjectFileType(string name) { }
        protected RazorCSharpProjectFileType(string name, string presentableName) { }
    }
    [JetBrains.ProjectModel.ProjectFileTypeDefinitionAttribute("RAZOR")]
    public class RazorProjectFileType : JetBrains.ProjectModel.HtmlProjectFileType
    {
        public static readonly JetBrains.ProjectModel.RazorProjectFileType Instance;
        public const string Name = "RAZOR";
        protected RazorProjectFileType(string name) { }
        protected RazorProjectFileType(string name, string presentableName) { }
        protected RazorProjectFileType(string name, string presentableName, System.Collections.Generic.IEnumerable<string> extensions) { }
    }
    public class RecursiveProjectModelChangeDeltaVisitor : JetBrains.ProjectModel.IProjectModelChangeDeltaVisitor
    {
        public RecursiveProjectModelChangeDeltaVisitor([JetBrains.Annotations.CanBeNullAttribute()] System.Action<JetBrains.ProjectModel.ProjectModelChange> FWithDelta, [JetBrains.Annotations.CanBeNullAttribute()] System.Action<JetBrains.ProjectModel.ProjectItemChange> FWithItemDelta) { }
        public virtual void VisitAssemblyDelta(JetBrains.ProjectModel.AssemblyChange assemblyChange) { }
        public virtual void VisitAssemblyFileDelta(JetBrains.ProjectModel.AssemblyFileChange change) { }
        public virtual void VisitDelta(JetBrains.ProjectModel.ProjectModelChange changeDelta) { }
        public virtual void VisitItemDelta(JetBrains.ProjectModel.ProjectItemChange change) { }
        public virtual void VisitProjectReferenceDelta(JetBrains.ProjectModel.ProjectReferenceChange change) { }
        public virtual void VisitSdkReferenceDelta(JetBrains.ProjectModel.ProjectSdkReferenceChange projectSdkReferenceChange) { }
        public virtual void VisitSolutionDelta(JetBrains.ProjectModel.SolutionChange change) { }
    }
    public class static RecursiveProjectModelChangeDeltaVisitorEx
    {
        public static void VisitDeltasRecursively([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ProjectModel.ProjectModelChange change, [JetBrains.Annotations.NotNullAttribute()] System.Action<JetBrains.ProjectModel.ProjectModelChange> FWithDelta) { }
        public static void VisitItemDeltasRecursively([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ProjectModel.ProjectModelChange change, [JetBrains.Annotations.NotNullAttribute()] System.Action<JetBrains.ProjectModel.ProjectItemChange> FWithItemDelta) { }
    }
    public abstract class RecursiveProjectVisitor : JetBrains.ProjectModel.ProjectVisitor
    {
        protected RecursiveProjectVisitor(bool visitReferences) { }
        protected RecursiveProjectVisitor() { }
        public virtual bool ProcessingIsFinished { get; }
        public override void VisitProject(JetBrains.ProjectModel.IProject project) { }
        public override void VisitProjectFolder(JetBrains.ProjectModel.IProjectFolder projectFolder) { }
        public override void VisitSolution(JetBrains.ProjectModel.ISolution solution) { }
    }
    [JetBrains.ProjectModel.ProjectFileTypeDefinitionAttribute("RESJSON")]
    public class ResJsonProjectFileType : JetBrains.ProjectModel.KnownProjectFileType
    {
        public static readonly JetBrains.ProjectModel.ResJsonProjectFileType Instance;
        public const string Name = "RESJSON";
        public const string RESJSON_EXTENSION = ".resjson";
        protected ResJsonProjectFileType(string name) { }
        protected ResJsonProjectFileType(string name, string presentableName) { }
        protected ResJsonProjectFileType(string name, string presentableName, string[] strings) { }
    }
    [JetBrains.ProjectModel.ProjectFileTypeDefinitionAttribute("Resw")]
    public class ReswProjectFileType : JetBrains.ProjectModel.XmlProjectFileType
    {
        public static readonly JetBrains.ProjectModel.ReswProjectFileType Instance;
        public const string Name = "Resw";
        public const string RESW_FILE_EXTENSION = ".resw";
        protected ReswProjectFileType(string name) { }
        protected ReswProjectFileType(string name, string presentableName) { }
    }
    [JetBrains.ProjectModel.ProjectFileTypeDefinitionAttribute("Resx")]
    public class ResxProjectFileType : JetBrains.ProjectModel.XmlProjectFileType
    {
        public static readonly JetBrains.ProjectModel.ResxProjectFileType Instance;
        public const string Name = "Resx";
        public const string RESX_FILE_EXTENSION = ".resx";
        protected ResxProjectFileType(string name) { }
        protected ResxProjectFileType(string name, string presentableName) { }
    }
    [JetBrains.ProjectModel.ProjectFileTypeDefinitionAttribute("Skin")]
    public class SkinProjectFileType : JetBrains.ProjectModel.AspProjectFileType
    {
        public static readonly JetBrains.ProjectModel.SkinProjectFileType Instance;
        public const string Name = "Skin";
        public const string SKIN_EXTENSION = ".skin";
        protected SkinProjectFileType(string name) { }
        protected SkinProjectFileType(string name, string presentableName) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class SolutionActivityTrackingComponent
    {
        public SolutionActivityTrackingComponent(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ProjectModel.Tasks.ISolutionLoadTasksScheduler scheduler, JetBrains.Application.ActivityTrackingNew.ActivityTracking activityTracking, System.Collections.Generic.IEnumerable<JetBrains.ProjectModel.IActivityLogContributorSolutionComponent> components) { }
    }
    public class SolutionChange : JetBrains.ProjectModel.ProjectModelChange
    {
        public SolutionChange(System.Collections.Generic.IList<JetBrains.ProjectModel.ProjectModelChange> childrenDeltas, JetBrains.ProjectModel.ISolution solution, JetBrains.ProjectModel.ProjectModelChangeType changeType) { }
        protected override string ElementDescription { get; }
        protected override string ElementPath { get; }
        public override void Accept(JetBrains.ProjectModel.IProjectModelChangeDeltaVisitor visitor) { }
        protected override void CollectAffectedSolutionFiles(System.Collections.Generic.JetHashSet<JetBrains.ProjectModel.IProjectFile> affectedSolutionFiles) { }
        public override JetBrains.ProjectModel.ProjectModelChange Propagate() { }
    }
    [JetBrains.Annotations.MeansImplicitUseAttribute(JetBrains.Annotations.ImplicitUseKindFlags.InstantiatedNoFixedConstructorSignature)]
    [System.AttributeUsageAttribute(System.AttributeTargets.Class | System.AttributeTargets.All, Inherited=false)]
    public class SolutionComponentAttribute : JetBrains.Application.Components.ComponentAttribute
    {
        public SolutionComponentAttribute() { }
        public SolutionComponentAttribute(JetBrains.Application.Components.ProgramConfigurations programConfigurations) { }
    }
    public class static SolutionEx
    {
        public static JetBrains.ProjectModel.IProjectModelTransactionCookie CreateTransactionCookie([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ProjectModel.ISolution solution, JetBrains.Util.DefaultAction defaultAction, string commandName, JetBrains.Application.Progress.IProgressIndicator pi, bool optimizeChangesOnCommit, JetBrains.Util.IUndoRedoHandler handler = null) { }
        public static JetBrains.ProjectModel.IProjectModelTransactionCookie CreateTransactionCookie([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ProjectModel.ISolution solution, JetBrains.Util.DefaultAction defaultAction, string commandName) { }
        public static JetBrains.ProjectModel.IProjectModelTransactionCookie CreateTransactionCookie([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ProjectModel.ISolution solution, JetBrains.Util.DefaultAction defaultAction, string commandName, JetBrains.Application.Progress.IProgressIndicator pi) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static T GetComponent<T>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ProjectModel.ISolution solution)
            where T :  class { }
        public static T GetComponent<T>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ProjectModel.IProject project)
            where T :  class { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Collections.Generic.IEnumerable<T> GetComponents<T>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ProjectModel.ISolution solution)
            where T :  class { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Collections.Generic.IEnumerable<T> GetComponents<T>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ProjectModel.IProject project)
            where T :  class { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.DataFlow.Lifetime GetLifetime([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ProjectModel.ISolution solution) { }
        public static bool HasComponent<T>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ProjectModel.ISolution solution)
            where T :  class { }
        public static void SaveSettings(this JetBrains.ProjectModel.IProject project) { }
        public static void SaveSettings(this JetBrains.ProjectModel.ISolution solution) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static T TryGetComponent<T>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ProjectModel.ISolution solution)
            where T :  class { }
        public static T TryGetComponent<T>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ProjectModel.IProject project)
            where T :  class { }
    }
    [JetBrains.ProjectModel.SolutionInstanceComponentAttribute()]
    public class SolutionFileLocationLive
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly JetBrains.DataFlow.IProperty<JetBrains.Util.FileSystemPath> SolutionFileLocation;
        public SolutionFileLocationLive(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.ChangeManager changemanager, JetBrains.ProjectModel.ISolution solution, JetBrains.Application.IShellLocks locks) { }
    }
    public sealed class SolutionInstance
    {
        public SolutionInstance(JetBrains.Application.Parts.IPartsCatalogueSet catalogueSet, JetBrains.Application.Components.IComponentContainer parentContainer, JetBrains.ProjectModel.Impl.SolutionElement solution, JetBrains.Application.Env.RunsProducts.ProductConfigurations productConfigurations) { }
        public JetBrains.Application.Components.ComponentContainer InstanceComponentContainer { get; }
        public JetBrains.DataFlow.Lifetime Lifetime { get; }
        public JetBrains.ProjectModel.Model2.Assemblies.Interfaces.IModuleReferenceResolveManager ModuleReferenceResolveManager { get; }
        public JetBrains.ProjectModel.Impl.SolutionElement Solution { get; }
        public JetBrains.Application.Components.ComponentContainer SolutionComponentContainer { get; }
        public void CloseSolutionInstance() { }
        public static JetBrains.Application.Components.IComponentContainer GetContainer([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.ISolution solution) { }
        public static JetBrains.Application.Components.IComponentContainer GetInstanceContainer([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.ISolution solution) { }
        public static JetBrains.DataFlow.Lifetime GetLifetime([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.ISolution solution) { }
        public void OpenSolution(JetBrains.ProjectModel.ISolutionOwner solutionOwner) { }
        public void OpenSolutionInstance() { }
    }
    [JetBrains.Annotations.MeansImplicitUseAttribute(JetBrains.Annotations.ImplicitUseKindFlags.InstantiatedNoFixedConstructorSignature)]
    [System.AttributeUsageAttribute(System.AttributeTargets.Class | System.AttributeTargets.All, Inherited=false)]
    public class SolutionInstanceComponentAttribute : JetBrains.Application.Components.ComponentAttribute
    {
        public SolutionInstanceComponentAttribute() { }
        public SolutionInstanceComponentAttribute(JetBrains.Application.Components.ProgramConfigurations programConfigurations) { }
    }
    public enum SolutionLoadStates
    {
        Closed = 0,
        BackgroundLoad = 1,
        Load = 2,
        Synchronized = 3,
    }
    public abstract class SolutionManagerBase : JetBrains.ProjectModel.ISolutionOwner
    {
        protected readonly JetBrains.Application.Parts.IPartsCatalogueSet myCatalogueSet;
        protected readonly JetBrains.Application.Components.IComponentContainer myComponentContainer;
        protected readonly JetBrains.Application.Env.RunsProducts.ProductConfigurations myProductConfigurations;
        protected readonly JetBrains.ProjectModel.Tasks.ISolutionLoadTasksScheduler myScheduler;
        protected SolutionManagerBase(JetBrains.Application.IShellLocks locks, System.Collections.Generic.IEnumerable<JetBrains.ProjectModel.IQuerySolutionCloseHandler> solutionCloseHandlers, JetBrains.Application.Parts.IPartsCatalogueSet catalogueSet, JetBrains.Application.Components.IComponentContainer componentContainer, JetBrains.Application.Env.RunsProducts.ProductConfigurations productConfigurations, JetBrains.ProjectModel.Tasks.ISolutionLoadTasksScheduler scheduler, JetBrains.ProjectModel.Properties.ProjectPropertiesFactory projectPropertiesFactory, JetBrains.ProjectModel.Properties.ProjectFlavoursFactory projectFlavoursFactory, JetBrains.ProjectModel.Properties.ProjectFilePropertiesFactory projectFilePropertiesFactory) { }
        public JetBrains.ProjectModel.ISolution CurrentSolution { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        protected JetBrains.ProjectModel.SolutionInstance CurrentSolutionInstance { get; set; }
        public abstract bool IsRealSolutionOwner { get; }
        protected JetBrains.Application.IShellLocks Locks { get; }
        public JetBrains.ProjectModel.Properties.ProjectFilePropertiesFactory ProjectFilePropertiesFactory { get; }
        public JetBrains.ProjectModel.Properties.ProjectPropertiesFactory ProjectPropertiesFactory { get; }
        protected virtual bool CloseSolutionInstance(JetBrains.ProjectModel.SolutionInstance instance) { }
        protected JetBrains.ProjectModel.SolutionInstance CreateSolutionInstance(JetBrains.ProjectModel.Impl.SolutionElement solutionElement, JetBrains.ProjectModel.SolutionInstance solutionInstance) { }
        public T GetComponent<T>()
            where T :  class { }
        public bool IsSolutionValid(JetBrains.ProjectModel.ISolution solution) { }
        protected virtual void SolutionReady(JetBrains.ProjectModel.SolutionInstance solutionInstance) { }
    }
    [System.ObsoleteAttribute("For usage only in settings upgraders. Do not create a component!")]
    public class SolutionSettingsTable : JetBrains.Application.Configuration.SettingsTableBase
    {
        public SolutionSettingsTable(JetBrains.Application.Configuration.IComponentSettingsProvider settings, JetBrains.Application.Env.RunsProducts.ProductConfigurations productConfigurations) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class SolutionsManaerSolutionProvider
    {
        public SolutionsManaerSolutionProvider(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ProjectModel.ISolution solution, JetBrains.ProjectModel.SolutionsManager solutionsManager) { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class SolutionsManager
    {
        public SolutionsManager(JetBrains.DataFlow.Lifetime lifetime) { }
        public JetBrains.ProjectModel.ISolution Solution { get; }
        public JetBrains.DataFlow.IViewable<JetBrains.ProjectModel.ISolution> Solutions { get; }
    }
    public class TimestampChange
    {
        public TimestampChange(System.Collections.Generic.ICollection<JetBrains.ProjectModel.TimestampChangedEventArgs> args) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ProjectModel.TimestampChangedEventArgs> GetTimestampChangedEventArgs() { }
    }
    public class TimestampChangedEventArgs : System.EventArgs
    {
        public TimestampChangedEventArgs(JetBrains.ProjectModel.IProjectFile file, int oldTimestampValue) { }
        public JetBrains.ProjectModel.IProjectFile File { get; }
        public int OldTimestampValue { get; }
    }
    [JetBrains.ProjectModel.ProjectFileTypeDefinitionAttribute("TS")]
    public class TypeScriptProjectFileType : JetBrains.ProjectModel.JavaScriptProjectFileType
    {
        public const string D_TS_EXTENSION = ".d.ts";
        [JetBrains.Annotations.UsedImplicitlyAttribute()]
        public static readonly JetBrains.ProjectModel.TypeScriptProjectFileType Instance;
        public const string Name = "TS";
        public const string TS_EXTENSION = ".ts";
        protected TypeScriptProjectFileType(string name) { }
        protected TypeScriptProjectFileType(string name, string presentableName) { }
        protected TypeScriptProjectFileType(string name, string presentableName, string[] strings) { }
    }
    [JetBrains.ProjectModel.ProjectFileTypeDefinitionAttribute("UNKNOWN")]
    public sealed class UnknownProjectFileType : JetBrains.ProjectModel.ProjectFileType
    {
        public static readonly JetBrains.ProjectModel.UnknownProjectFileType Instance;
        public const string Name = "UNKNOWN";
    }
    public abstract class UnloadedProjectSupportManager
    {
        public abstract JetBrains.DataFlow.ISignal<System.Collections.Generic.Dictionary<JetBrains.ProjectModel.IProject, JetBrains.Util.Pair<JetBrains.ProjectModel.Update.IProjectReferenceDescriptor, JetBrains.ProjectModel.Update.IProjectReferenceProperties>>> ReferencesToAdd { get; }
        public abstract JetBrains.DataFlow.ISignal<System.Collections.Generic.Dictionary<JetBrains.ProjectModel.IProject, JetBrains.Util.Pair<JetBrains.ProjectModel.Update.IProjectReferenceDescriptor, JetBrains.ProjectModel.Update.IProjectReferenceProperties>>> ReferencesToRemove { get; }
        public abstract void AfterProjectLoaded([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IProject project);
        public abstract void AfterProjectReloaded(System.Guid projectGuid);
        public abstract void BeforeProjectRemoved([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IProject project);
        public abstract void BeforeProjectUnloaded([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IProject unloadedProject);
        public abstract void BeforeUnloadedProjectRemoved(System.Guid projectGuid);
        public static JetBrains.ProjectModel.UnloadedProjectSupportManager GetInstance(JetBrains.ProjectModel.ISolution solution) { }
    }
    [JetBrains.ProjectModel.ProjectFileTypeDefinitionAttribute("VBASIC", Edition="Vbnet")]
    public class VBProjectFileType : JetBrains.ProjectModel.KnownProjectFileType
    {
        public static readonly JetBrains.ProjectModel.VBProjectFileType Instance;
        public const string Name = "VBASIC";
        public const string VB_EXTENSION = ".vb";
        protected VBProjectFileType(string name) { }
        protected VBProjectFileType(string name, string presentableName) { }
    }
    [JetBrains.ProjectModel.ProjectFileTypeDefinitionAttribute("VBS")]
    public class VBScriptProjectFileType : JetBrains.ProjectModel.KnownProjectFileType
    {
        public static readonly JetBrains.ProjectModel.VBScriptProjectFileType Instance;
        public const string Name = "VBS";
        public const string VBS_EXTENSION = ".vbs";
        protected VBScriptProjectFileType(string name) { }
        protected VBScriptProjectFileType(string name, string presentableName) { }
    }
    [JetBrains.ProjectModel.ProjectFileTypeDefinitionAttribute("Web.Config")]
    public class WebConfigProjectFileType : JetBrains.ProjectModel.XmlProjectFileType
    {
        public static readonly JetBrains.ProjectModel.WebConfigProjectFileType Instance;
        public const string Name = "Web.Config";
        public const string WEB_CONFIG_EXTENSION = ".config";
        protected WebConfigProjectFileType(string name) { }
        protected WebConfigProjectFileType(string name, string presentableName) { }
    }
    [JetBrains.ProjectModel.ProjectFileTypeDefinitionAttribute("XAML")]
    public class XamlProjectFileType : JetBrains.ProjectModel.XmlProjectFileType
    {
        public static readonly JetBrains.ProjectModel.XamlProjectFileType Instance;
        public const string Name = "XAML";
        public const string XAML_EXTENSION = ".xaml";
        [System.ObsoleteAttribute("Use XAML_EXTENSION instead")]
        public const string XamlExtension = ".xaml";
        protected XamlProjectFileType(string name) { }
        protected XamlProjectFileType(string name, string presentableName) { }
    }
    [JetBrains.ProjectModel.ProjectFileTypeDefinitionAttribute("XML")]
    public class XmlProjectFileType : JetBrains.ProjectModel.KnownProjectFileType
    {
        public static readonly JetBrains.ProjectModel.XmlProjectFileType Instance;
        public const string Name = "XML";
        public const string XML_EXTENSION = ".xml";
        protected XmlProjectFileType(string name) { }
        protected XmlProjectFileType(string name, string presentableName) { }
        protected XmlProjectFileType(string name, string presentableName, System.Collections.Generic.IEnumerable<string> extensions) { }
    }
    [JetBrains.ProjectModel.ProjectFileTypeDefinitionAttribute("XSD")]
    public class XsdProjectFileType : JetBrains.ProjectModel.XmlProjectFileType
    {
        public static readonly JetBrains.ProjectModel.XsdProjectFileType Instance;
        public const string Name = "XSD";
        public const string XSD_EXTENSION = ".xsd";
        protected XsdProjectFileType(string name) { }
        protected XsdProjectFileType(string name, string presentableName) { }
    }
}
namespace JetBrains.ProjectModel.Assemblies
{
    
    [JetBrains.ProjectModel.model2.Assemblies.AssemblyToAssemblyResolvers.AssemblyToAssemblyReferencesResolverAttribute(1D)]
    [JetBrains.ProjectModel.model2.Assemblies.ProjectToAssemblyResolvers.ProjectToAssemblyReferencesResolverAttribute(1D)]
    public class AssemblyFoldersAssemblyResolver : JetBrains.ProjectModel.model2.Assemblies.AssemblyToAssemblyResolvers.IAssemblyToAssemblyReferencesResolver, JetBrains.ProjectModel.model2.Assemblies.ProjectToAssemblyResolvers.IProjectToAssemblyReferencesResolver
    {
        public AssemblyFoldersAssemblyResolver(JetBrains.ProjectModel.Impl.AssemblyInfoCache assemblyInfoCache, JetBrains.ProjectModel.PlatformManager platformManager, JetBrains.ProjectModel.AssemblyNamesInterner interner) { }
        public System.Collections.Generic.IEnumerable<JetBrains.Util.FileSystemPath> ResolveReference(System.Collections.Generic.ICollection<JetBrains.Util.FileSystemPath> sourceAssemblyFile, JetBrains.Metadata.Utils.AssemblyNameInfo referenceName) { }
        public System.Collections.Generic.IEnumerable<JetBrains.Util.FileSystemPath> ResolveReference(JetBrains.ProjectModel.Model2.References.AssemblyReferenceTarget referenceTarget, JetBrains.ProjectModel.IProject referenceSource) { }
    }
}
namespace JetBrains.ProjectModel.Assemblies.AssemblyToAssemblyResolvers
{
    
    public class ProjectResolveContext : JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext
    {
        public ProjectResolveContext([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IProject project) { }
        public JetBrains.ProjectModel.IProject Project { get; }
        public string UniqueName { get; }
        public JetBrains.Util.FileSystemPath GetResolveResult(JetBrains.Metadata.Reader.API.AssemblyReferenceWithSource assemblyReferenceWithSource) { }
        public bool IsValid() { }
        public void SetResolveResult(JetBrains.Metadata.Reader.API.AssemblyReferenceWithSource assemblyReferenceWithSource, JetBrains.Util.FileSystemPath resolveResult) { }
    }
}
namespace JetBrains.ProjectModel.Assemblies.Impl
{
    
    [JetBrains.ProjectModel.SolutionInstanceComponentAttribute()]
    public class AssemblyFactory : JetBrains.ProjectModel.model2.Assemblies.Interfaces.IAssemblyFactory
    {
        public AssemblyFactory(JetBrains.Application.IShellLocks locks, JetBrains.ProjectModel.Model2.Assemblies.Impl.AssemblyCollection assemblyCollection, JetBrains.ProjectModel.Impl.SolutionElement solution, JetBrains.Application.ChangeManager changeManager, JetBrains.ProjectModel.Impl.AssemblyInfoCache assemblyInfoCache, JetBrains.ProjectModel.Model2.Assemblies.Interfaces.EffectiveReferencedAssemblyNamesExtractor assemblyNamesExtractor, JetBrains.ProjectModel.Assemblies.Impl.ResolveContextManager resolveContextManager, JetBrains.Application.FileSystemTracker.IFileSystemTracker fileSystemTracker) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ProjectModel.Model2.Assemblies.Interfaces.IAssemblyCookie AddRef(JetBrains.Util.FileSystemPath assemblyPath, [JetBrains.Annotations.NotNullAttribute()] string holderId, JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext moduleReferenceResolveContext) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ProjectModel.Model2.Assemblies.Interfaces.IAssemblyFile GetOrCreateAssemblyFile(JetBrains.Util.FileSystemPath expectedLocation, JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext moduleReferenceResolveContext) { }
    }
    [JetBrains.ProjectModel.SolutionInstanceComponentAttribute()]
    public class AssemblyReferenceResolutionCache
    {
        public AssemblyReferenceResolutionCache(JetBrains.ProjectModel.Caches.SolutionCachesConfiguration solutionCachesConfiguration, JetBrains.ProjectModel.ISolution solution, JetBrains.ProjectModel.Tasks.ISolutionLoadTasksScheduler scheduler, JetBrains.DataFlow.Lifetime lifetime, JetBrains.ProjectModel.Assemblies.Impl.ResolveContextManager resolveContextManager) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.Util.FileSystemPath GetOrCreateResolveResult(JetBrains.ProjectModel.Model2.References.AssemblyReferenceTarget referenceTarget, JetBrains.ProjectModel.IModule referenceSource, JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext moduleReferenceResolveContext, System.Func<JetBrains.ProjectModel.Model2.References.AssemblyReferenceTarget, JetBrains.ProjectModel.IModule, JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext, JetBrains.Util.FileSystemPath> resolutionFunc) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.Util.FileSystemPath GetOrCreateResolveResult(JetBrains.Metadata.Utils.AssemblyNameInfo referenceTargetName, JetBrains.Util.FileSystemPath sourceLocation, System.Guid mvid, JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext moduleReferenceResolveContext, System.Func<JetBrains.Metadata.Utils.AssemblyNameInfo, JetBrains.Util.FileSystemPath, JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext, JetBrains.Util.FileSystemPath> resolutionFunc) { }
        public class AssemblyReferenceResolveCacheEntry
        {
            public AssemblyReferenceResolveCacheEntry(System.Guid mvid, JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext moduleReferenceResolveContext, JetBrains.Metadata.Utils.AssemblyNameInfo referenceName, JetBrains.Util.FileSystemPath sourceAssemblyLocation) { }
            public System.Guid Mvid { get; }
            protected bool Equals(JetBrains.ProjectModel.Assemblies.Impl.AssemblyReferenceResolutionCache.AssemblyReferenceResolveCacheEntry other) { }
            public override bool Equals(object obj) { }
            public override int GetHashCode() { }
            public bool IsValid() { }
            public override string ToString() { }
        }
    }
    [JetBrains.ProjectModel.SolutionInstanceComponentAttribute()]
    public class ModuleReferenceResolveManager : JetBrains.ProjectModel.Model2.Assemblies.Interfaces.IModuleReferenceResolveManager
    {
        public ModuleReferenceResolveManager([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.IShellLocks locks, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.PlatformManager platformManager, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.Model2.Assemblies.Impl.AssemblyCollection assemblyCollection, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.Transaction.IProjectModelBatchChangeManager batchChangeManager, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.Assemblies.Impl.ModuleReferencesResolveStore referencesResolveStore, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.model2.Assemblies.AssemblyToAssemblyResolvers.AssemblyToAssemblyReferencesResolveManager assemblyToAssemblyReferencesResolveManager, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.model2.Assemblies.ProjectToAssemblyResolvers.ProjectToAssemblyReferencesResolveManager projectToAssemblyReferencesResolveManager, JetBrains.Application.ChangeManager changeManager, JetBrains.ProjectModel.Assemblies.Impl.AssemblyReferenceResolutionCache assemblyNameResolutionCache) { }
        public void RefreshAssemblyReferences(JetBrains.ProjectModel.Model2.Assemblies.Interfaces.IAssembly assembly) { }
        public void RefreshProjectOutputAssemblyReferences(JetBrains.ProjectModel.ProjectImpl project) { }
        public virtual JetBrains.Util.FileSystemPath Resolve(JetBrains.ProjectModel.Model2.References.AssemblyReferenceTarget referenceTarget, JetBrains.ProjectModel.IModule referenceSource, JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext moduleReferenceResolveContext) { }
        public void ResolveAndStoreAssemblyReferences(System.Collections.Generic.IEnumerable<JetBrains.ProjectModel.Model2.References.IModuleToAssemblyReference> references) { }
        public void UpdateReferenceAndFire(JetBrains.ProjectModel.Model2.References.IModuleToAssemblyReference reference, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.Util.FileSystemPath resolveResult) { }
        public void WipeReferencesResolve(System.Collections.Generic.IEnumerable<JetBrains.ProjectModel.Model2.References.IModuleToAssemblyReference> references) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class ModuleReferenceResolveSync : JetBrains.Application.IChangeProvider
    {
        public ModuleReferenceResolveSync(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.ChangeManager changeManager, JetBrains.ProjectModel.Assemblies.Impl.ModuleReferencesResolveStore store, JetBrains.ProjectModel.ISolution solution, JetBrains.ProjectModel.Model2.Assemblies.Interfaces.IModuleReferenceResolveManager referenceResolveManager, JetBrains.Application.IShellLocks locks, JetBrains.ProjectModel.Model2.Assemblies.Impl.AssemblyCollection assemblyCollection, JetBrains.ProjectModel.Impl.AssemblyInfoCache assemblyInfoCache, JetBrains.ProjectModel.Model2.Assemblies.Interfaces.EffectiveReferencedAssemblyNamesExtractor assemblyNamesExtractor) { }
        public JetBrains.DataFlow.Property<bool> SuspendHardOperations { get; }
        public void ApplyExternalAssemblyChanges(System.Collections.Generic.List<JetBrains.ProjectModel.Model2.Assemblies.Interfaces.IAssemblyFile> assemblyFiles) { }
        public object Execute(JetBrains.Application.IChangeMap changeMap) { }
        public void InvalidateReferences(JetBrains.ProjectModel.IProject project) { }
        public void ReResolveUnresolvedReferences() { }
        protected virtual void UpdateProjectStructure() { }
    }
    [JetBrains.ProjectModel.SolutionInstanceComponentAttribute()]
    public class ModuleReferencesResolveStore : JetBrains.ProjectModel.Model2.Assemblies.Interfaces.IModuleReferencesResolveStore
    {
        public ModuleReferencesResolveStore(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.IShellLocks locks, JetBrains.ProjectModel.Assemblies.Impl.AssemblyFactory assemblyFactory, JetBrains.ProjectModel.References.SdkReferencesManager sdkReferencesManager) { }
        public System.Collections.Generic.ICollection<JetBrains.ProjectModel.Model2.References.IModuleToAssemblyReference> UnresolvedToAssemblyReferences { get; }
        public void FireAssemblyRemoved(JetBrains.ProjectModel.Model2.Assemblies.Interfaces.IAssembly assembly) { }
        public void FireAssemblyUpdated(JetBrains.ProjectModel.Model2.Assemblies.Interfaces.IAssembly assembly) { }
        public void FireProjectAdded(JetBrains.ProjectModel.IProject project) { }
        public void FireProjectReferenceAdded(JetBrains.ProjectModel.IProjectToProjectReference projectToProjectReference) { }
        public void FireProjectReferenceRemoved(JetBrains.ProjectModel.IProjectToProjectReference projectToProjectReference) { }
        public void FireProjectRemoved(JetBrains.ProjectModel.IProject project) { }
        public JetBrains.ProjectModel.Model2.Assemblies.Interfaces.IAssemblyFile GetAssemblyFileResolveResult(JetBrains.ProjectModel.Model2.References.IModuleToAssemblyReference reference) { }
        public System.Collections.Generic.ICollection<JetBrains.ProjectModel.Model2.Assemblies.Interfaces.IAssemblyToAssemblyReference> GetAssemblyReferences(JetBrains.ProjectModel.Model2.Assemblies.Interfaces.IAssembly assembly, JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext moduleReferenceResolveContext) { }
        public System.Collections.Generic.ICollection<JetBrains.ProjectModel.Model2.References.IModuleToAssemblyReference> GetAssemblyReferencesForAllContexts(JetBrains.ProjectModel.IModule module) { }
        public System.Collections.Generic.ICollection<JetBrains.ProjectModel.Model2.References.IModuleToAssemblyReference> GetReferencesToAssembly(JetBrains.ProjectModel.Model2.Assemblies.Interfaces.IAssembly assembly, JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext moduleReferenceResolveContext) { }
        public System.Collections.Generic.ICollection<JetBrains.ProjectModel.Model2.References.IModuleToAssemblyReference> GetReferencesToAssemblyByAssemblyNameOrHintPath(JetBrains.Util.FileSystemPath hintPath, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.Metadata.Utils.AssemblyNameInfo info, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext moduleReferenceResolveContext) { }
        public System.Collections.Generic.ICollection<JetBrains.ProjectModel.Model2.References.IModuleToAssemblyReference> GetReferencesToAssemblyForAllContexts(JetBrains.ProjectModel.Model2.Assemblies.Interfaces.IAssembly assembly) { }
        public System.Collections.Generic.ICollection<JetBrains.ProjectModel.IProjectToProjectReference> GetReferencesToProject(JetBrains.ProjectModel.IProject target) { }
        public JetBrains.ProjectModel.Model2.Assemblies.Interfaces.IAssembly GetResolveResult(JetBrains.ProjectModel.Model2.References.IModuleToAssemblyReference reference) { }
        public JetBrains.ProjectModel.IProject GetResolveResult(JetBrains.ProjectModel.IProjectToProjectReference reference) { }
        public JetBrains.ProjectModel.IProject GetResolveResult(JetBrains.ProjectModel.References.IProjectToSdkReference reference) { }
        public void InvalidateResolveResult(JetBrains.ProjectModel.Model2.References.IModuleToAssemblyReference reference) { }
        public void RemoveReference(JetBrains.ProjectModel.Model2.References.IModuleToAssemblyReference assemblyToAssemblyReference) { }
        public JetBrains.ProjectModel.Model2.Assemblies.Interfaces.IAssemblyFile SetResolveResult(JetBrains.ProjectModel.Model2.References.IModuleToAssemblyReference reference, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.FileSystemPath resolveResult) { }
    }
    public class static ReferenceExtensions
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ProjectModel.IModule GetOwnerModule(this JetBrains.ProjectModel.Model2.References.IModuleToAssemblyReference moduleToAssemblyReference) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.ProjectModel.Model2.References.AssemblyReferenceTarget GetReferenceTarget(this JetBrains.ProjectModel.Model2.References.IModuleToAssemblyReference moduleToAssemblyReference) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext GetResolveContext(this JetBrains.ProjectModel.Model2.References.IModuleToAssemblyReference moduleToModuleReference) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ProjectModel.ISolution GetSolution(this JetBrains.ProjectModel.Model2.References.IModuleToAssemblyReference moduleToAssemblyReference) { }
        public static bool IsValid(this JetBrains.ProjectModel.Model2.References.IModuleToAssemblyReference moduleToAssemblyReference) { }
    }
    [JetBrains.ProjectModel.SolutionInstanceComponentAttribute()]
    public class ResolveContextManager
    {
        public ResolveContextManager() { }
        protected virtual JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext CreateResolveContext(JetBrains.ProjectModel.IProject project) { }
        public void DumpAllContexts(System.IO.TextWriter writer) { }
        public System.Collections.Generic.ICollection<JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext> GetAssemblyResolveContexts(JetBrains.ProjectModel.Model2.Assemblies.Interfaces.IAssembly assembly) { }
        public static JetBrains.ProjectModel.Assemblies.Impl.ResolveContextManager GetInstance(JetBrains.ProjectModel.ISolution solution) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext GetOrCreateProjectResolveContext(JetBrains.ProjectModel.IProject referencesOwner) { }
    }
}
namespace JetBrains.ProjectModel.Build
{
    
    [JetBrains.ProjectModel.SolutionInstanceComponentAttribute()]
    public class OutputAssemblies : JetBrains.Application.IChangeProvider
    {
        public OutputAssemblies(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ProjectModel.Assemblies.Impl.AssemblyFactory assemblyFactory, JetBrains.Application.IShellLocks locks, JetBrains.ProjectModel.impl.ViewableProjectsCollection projects, JetBrains.Application.ChangeManager changeManager, JetBrains.ProjectModel.ISolution solution, JetBrains.Application.FileSystemTracker.IFileSystemTracker fileSystemTracker, JetBrains.ProjectModel.Model2.Assemblies.Impl.AssemblyCollection assemblyCollection, JetBrains.ProjectModel.Impl.AssemblyInfoCache assemblyInfoCache) { }
        protected virtual void AfterProjectOpenedInternal(JetBrains.ProjectModel.IProject project) { }
        public void Dump(System.IO.StreamWriter writer) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ProjectModel.IProject GetProjectByOutputAssembly(JetBrains.ProjectModel.Model2.Assemblies.Interfaces.IAssembly assembly) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ProjectModel.IProject GetProjectByOutputAssemblyMvid(System.Guid mvid) { }
    }
    public class VBBuildSettings : JetBrains.ProjectModel.Properties.Managed.ManagedProjectBuildSettings, JetBrains.ProjectModel.Properties.IBuildSettings, JetBrains.ProjectModel.Properties.Managed.IManagedProjectBuildSettings, JetBrains.ProjectModel.Properties.VB.IVBBuildSettings
    {
        public JetBrains.ProjectModel.Properties.VB.OptionCompare OptionCompare { get; set; }
        public JetBrains.ProjectModel.Properties.VB.OptionExplicit OptionExplicit { get; set; }
        public JetBrains.ProjectModel.Properties.VB.OptionInfer OptionInfer { get; set; }
        public JetBrains.ProjectModel.Properties.VB.OptionStrict OptionStrict { get; set; }
        public override void Dump(System.IO.TextWriter to, int indent) { }
        public override void ReadBuildSettings(System.IO.BinaryReader reader) { }
        public override bool UpdateFrom(JetBrains.ProjectModel.Properties.IBuildSettings settings) { }
        public override void WriteBuildSettings(System.IO.BinaryWriter writer) { }
    }
}
namespace JetBrains.ProjectModel.Caches
{
    
    [JetBrains.ProjectModel.SolutionInstanceComponentAttribute()]
    public class IgnoreChangesFromCacheFolder
    {
        public IgnoreChangesFromCacheFolder(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ProjectModel.ISolution solution, JetBrains.ProjectModel.Caches.ISolutionCachesConfiguration cachesConfiguration, JetBrains.Application.FileSystemTracker.IFileSystemTracker fileSystemTracker) { }
    }
    public interface IProjectFileDataCache
    {
        int Version { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        object BuildData(System.Xml.XmlDocument document);
        bool CanHandle([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IProjectFile projectFile);
        [JetBrains.Annotations.CanBeNullAttribute()]
        System.Action OnDataChanged(JetBrains.ProjectModel.IProjectFile projectFile, [JetBrains.Annotations.CanBeNullAttribute()] object oldData, [JetBrains.Annotations.NotNullAttribute()] object newData);
        [JetBrains.Annotations.NotNullAttribute()]
        object Read([JetBrains.Annotations.NotNullAttribute()] System.IO.BinaryReader reader);
        void Write([JetBrains.Annotations.NotNullAttribute()] System.IO.BinaryWriter writer, [JetBrains.Annotations.NotNullAttribute()] object data);
    }
    public interface ISolutionCachesConfiguration
    {
        JetBrains.Util.FileSystemPath CacheFormatVersionFile { get; }
        bool PersistCaches { get; }
        bool CacheFormatVersionMatches();
        JetBrains.Util.FileSystemPath GetCacheFolder();
    }
    public abstract class ProjectFileDataCache
    {
        public abstract T GetData<T>(JetBrains.ProjectModel.Caches.IProjectFileDataCache cache, JetBrains.ProjectModel.IProject project, T defaultValue);
        public abstract void RegisterCache(JetBrains.DataFlow.Lifetime cachelifetime, JetBrains.ProjectModel.Caches.IProjectFileDataCache cache);
    }
    [JetBrains.ProjectModel.SolutionInstanceComponentAttribute()]
    public class ProjectFileDataCacheImpl : JetBrains.ProjectModel.Caches.ProjectFileDataCache
    {
        public ProjectFileDataCacheImpl(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ProjectModel.ISolution solution, JetBrains.ProjectModel.Caches.ISolutionCachesConfiguration cachesConfiguration, JetBrains.Application.ChangeManager changeManager, JetBrains.Application.IShellLocks locks) { }
        public override T GetData<T>(JetBrains.ProjectModel.Caches.IProjectFileDataCache cache, JetBrains.ProjectModel.IProject project, T defaultValue) { }
        public override void RegisterCache(JetBrains.DataFlow.Lifetime cachelifetime, JetBrains.ProjectModel.Caches.IProjectFileDataCache cache) { }
    }
    [JetBrains.ProjectModel.SolutionInstanceComponentAttribute()]
    public class SolutionCachesConfiguration : JetBrains.ProjectModel.Caches.ISolutionCachesConfiguration
    {
        public const int CachesFormatVersion = 3;
        public SolutionCachesConfiguration(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.Settings.ISettingsStore settingsStore, JetBrains.ProjectModel.ISolution solution, JetBrains.Application.IApplicationDescriptor applicationDescriptor, JetBrains.Application.Env.Components.ProductSettingsLocation productSettingsLocation, JetBrains.ProjectModel.Settings.Storages.SolutionSettingsStoragePersonal needToBeReady, JetBrains.ProjectModel.Settings.Storages.SolutionSettingsStorageShared needToBeReady2) { }
        public JetBrains.Util.FileSystemPath CacheFormatVersionFile { get; }
        protected virtual JetBrains.ReSharper.Psi.CachesLocationType CacheLocation { get; }
        public virtual bool PersistCaches { get; }
        public bool CacheFormatVersionMatches() { }
        public virtual JetBrains.Util.FileSystemPath GetCacheFolder() { }
    }
    public class static SolutionCachesConfigurationExtensions
    {
        public static JetBrains.Util.FileSystemPath GetSolutionCacheFolder(this JetBrains.ProjectModel.Caches.ISolutionCachesConfiguration configuration, JetBrains.ProjectModel.ISolution solution) { }
    }
}
namespace JetBrains.ProjectModel.Configuration
{
    
    [System.ObsoleteAttribute("Use settings store bound to a project instead. This class is used for settings mi" +
        "gration only")]
    public class ProjectSettingsComponent : JetBrains.Application.Configuration.SettingsComponentBase
    {
        public ProjectSettingsComponent(JetBrains.ProjectModel.IProject project, JetBrains.Application.Env.RunsProducts.ProductConfigurations productConfigurations, JetBrains.Application.IApplicationDescriptor applicationDescriptor) { }
        protected override System.Collections.Generic.ICollection<JetBrains.Application.Configuration.XmlExternalizationScope> ValidXmlExternalizationScopes { get; }
        protected override bool OnLoadSettingsXmlBag(System.Action<System.Xml.XmlDocument, JetBrains.Application.Configuration.XmlExternalizationScope> funcDeserializeXmlBag) { }
    }
    [System.ObsoleteAttribute()]
    public sealed class SolutionSettingsComponent : JetBrains.Application.Configuration.SettingsComponentBase
    {
        public SolutionSettingsComponent(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.IApplicationDescriptor applicationDescriptor, JetBrains.Application.Env.RunsProducts.ProductConfigurations productConfigurations) { }
        protected override System.Collections.Generic.ICollection<JetBrains.Application.Configuration.XmlExternalizationScope> ValidXmlExternalizationScopes { get; }
        protected override bool OnLoadSettingsXmlBag(System.Action<System.Xml.XmlDocument, JetBrains.Application.Configuration.XmlExternalizationScope> funcDeserializeXmlBag) { }
    }
}
namespace JetBrains.ProjectModel.DataContext
{
    
    public class static DataConstants
    {
        public static readonly JetBrains.Application.DataContext.DataConstant<JetBrains.ProjectModel.Model2.Assemblies.Interfaces.IAssemblyToAssemblyReference[]> AssemblyToAssemblyReferences;
        public static readonly JetBrains.Application.DataContext.DataConstant<JetBrains.ProjectModel.IProject> Project;
        public static readonly JetBrains.Application.DataContext.DataConstant<JetBrains.ProjectModel.IProjectModelElement> PROJECT_MODEL_ELEMENT;
        public static readonly JetBrains.Application.DataContext.DataConstant<JetBrains.ProjectModel.IProjectModelElement[]> PROJECT_MODEL_ELEMENTS;
        public static readonly JetBrains.Application.DataContext.DataConstant<JetBrains.ProjectModel.model2.References.ReferencesFolder> REFERENCES_FOLDER;
        public static readonly JetBrains.Application.DataContext.DataConstant<JetBrains.ProjectModel.ISolution> SOLUTION;
    }
    public class static DataContextsEx
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Func<JetBrains.DataFlow.Lifetime, JetBrains.Application.DataContext.DataContexts, JetBrains.Application.DataContext.IDataContext> ToDataContext([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ProjectModel.IProjectModelElement proelem) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ProjectModel.IProjectModelElement[] ToProjectModelElementsDataConstant([JetBrains.Annotations.CanBeNullAttribute()] this JetBrains.ProjectModel.IProjectModelElement proelem) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ProjectModel.IProjectModelElement[] ToProjectModelElementsDataConstant([JetBrains.Annotations.CanBeNullAttribute()] this JetBrains.ProjectModel.IProjectModelElement[] proelem) { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class ProjectModelDataRules
    {
        public ProjectModelDataRules(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.DataContext.DataContexts contexts) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class ProjectModelPerSolutionDataRules
    {
        public ProjectModelPerSolutionDataRules(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.DataContext.DataContexts contexts, JetBrains.ProjectModel.ISolution solutionMy, JetBrains.Application.Components.IComponentContainer containerSolution) { }
    }
}
namespace JetBrains.ProjectModel.FileTypes
{
    
    public class CachingProjectFileTypeServicesAccess<TService>
        where TService :  class
    {
        public CachingProjectFileTypeServicesAccess(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ProjectModel.FileTypes.IProjectFileTypeServices services) { }
        [JetBrains.Annotations.NotNullAttribute()]
        [JetBrains.Annotations.UsedImplicitlyAttribute()]
        public System.Collections.Generic.List<TService> GetServices([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.ProjectFileType fileType) { }
    }
    public interface IProjectFileTypeServices
    {
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.DataFlow.ViewableCollection<JetBrains.ProjectModel.ProjectFileType> Definitions { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        [JetBrains.Annotations.UsedImplicitlyAttribute()]
        System.Collections.Generic.IEnumerable<T> GetMultipleServicesFromAll<T>()
            where T :  class;
        [JetBrains.Annotations.NotNullAttribute()]
        [JetBrains.Annotations.UsedImplicitlyAttribute()]
        T GetService<T>([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.ProjectFileType fileType)
            where T :  class;
        [JetBrains.Annotations.NotNullAttribute()]
        [JetBrains.Annotations.UsedImplicitlyAttribute()]
        System.Collections.Generic.IEnumerable<T> GetServices<T>([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.ProjectFileType fileType)
            where T :  class;
        [JetBrains.Annotations.NotNullAttribute()]
        [JetBrains.Annotations.UsedImplicitlyAttribute()]
        System.Collections.Generic.IEnumerable<T> GetServicesFromAll<T>()
            where T :  class;
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.UsedImplicitlyAttribute()]
        T TryGetService<T>([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.ProjectFileType fileType)
            where T :  class;
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class ProjectFileTypeServices : JetBrains.Application.Extensibility.SplittedComponentContainer<JetBrains.ProjectModel.ProjectFileType, JetBrains.ProjectModel.ProjectFileTypeAttribute>, JetBrains.ProjectModel.FileTypes.IProjectFileTypeServices
    {
        public ProjectFileTypeServices(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.Parts.IPartsCatalogueSet catalogueSet, JetBrains.Application.Components.IComponentContainer parentContainer, JetBrains.ProjectModel.IProjectFileTypes fileTypes) { }
    }
}
namespace JetBrains.ProjectModel.Impl
{
    
    [JetBrains.ProjectModel.SolutionInstanceComponentAttribute()]
    public sealed class AssemblyInfoCache
    {
        public AssemblyInfoCache(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.FileSystemTracker.IFileSystemTracker tracker, JetBrains.ProjectModel.PlatformManager platformManager, JetBrains.ProjectModel.Caches.SolutionCachesConfiguration solutionCachesConfiguration, JetBrains.ProjectModel.ISolution solution, JetBrains.ProjectModel.Tasks.ISolutionLoadTasksScheduler scheduler) { }
        public void ApplyExternalChange(JetBrains.ProjectModel.FileSystemChangeDelta fscd) { }
        public void Dump(System.IO.TextWriter writer) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.Metadata.Utils.AssemblyNameReader.AssemblyInfo GetAssemblyInfo(JetBrains.Util.FileSystemPath folderPath, string assemblyFileName, System.Func<JetBrains.Util.FileSystemPath, string, JetBrains.Util.FileSystemPath> combineFunc, out JetBrains.Util.FileSystemPath fullAssemblyPath) { }
        public JetBrains.Util.FileSystemPath GetCacheFilePath() { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ProjectModel.PlatformID GetPlatformId(JetBrains.Util.FileSystemPath assemblyPath) { }
    }
    public class CachedFileSystemData
    {
        public CachedFileSystemData(JetBrains.Util.FileSystemPath location) { }
        public System.IO.FileAttributes FileAttributes { get; set; }
        public bool FileExists { get; set; }
        public System.DateTime LastWriteTimeUtc { get; set; }
        public void Load(JetBrains.Util.FileSystemPath path) { }
        public JetBrains.ProjectModel.ExternalChangeType Refresh(JetBrains.Util.FileSystemPath path) { }
    }
    public class CachedProjectFileType : JetBrains.ProjectModel.Impl.CachedProjectItemValue<JetBrains.ProjectModel.IProjectFile, JetBrains.ProjectModel.ProjectFileType>
    {
        public CachedProjectFileType([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IProjectModelTimestamps timestamps, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IProjectFile projectFile, System.Func<JetBrains.ProjectModel.IProjectFile, JetBrains.ProjectModel.ProjectFileType> evaluateFunc) { }
        protected override int ModificationTimestamp() { }
    }
    public class CachedProjectItemLocation<TProjectItem> : JetBrains.ProjectModel.Impl.CachedProjectItemValue<TProjectItem, JetBrains.Util.FileSystemPath>
        where TProjectItem : JetBrains.ProjectModel.IProjectItem
    {
        public CachedProjectItemLocation([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IProjectModelTimestamps timestamps, [JetBrains.Annotations.NotNullAttribute()] TProjectItem projectItem, System.Func<TProjectItem, JetBrains.Util.FileSystemPath> evaluateFunc, JetBrains.Util.FileSystemPath initialValue = null) { }
        protected override int ModificationTimestamp() { }
    }
    public class CachedProjectItemValue<TProjectItem, TValue>
        where TProjectItem : JetBrains.ProjectModel.IProjectItem
        where TValue :  class
    {
        public CachedProjectItemValue([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IProjectModelTimestamps timestamps, [JetBrains.Annotations.NotNullAttribute()] TProjectItem projectItem, System.Func<TProjectItem, TValue> evaluateFunc, TValue initialValue = null) { }
        public JetBrains.ProjectModel.IProjectModelTimestamps Timestamps { get; }
        public static JetBrains.ProjectModel.Impl.CachedProjectItemValue<TProjectItem, TValue> CreateInvalidatedOnAnyChange(TProjectItem projectItem, System.Func<TProjectItem, TValue> evaluateFunc) { }
        public TValue GetValue() { }
        protected virtual int ModificationTimestamp() { }
        public void ResetValue() { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class ExternalChangeProcessor : System.IDisposable
    {
        public ExternalChangeProcessor(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ProjectModel.ISolution solution, JetBrains.Application.IShellLocks shellLocks, JetBrains.UI.Application.IUIApplication environment, JetBrains.ProjectModel.Transaction.IProjectModelBatchChangeManager projectModelBatchChangeManager, JetBrains.ProjectModel.Assemblies.Impl.ModuleReferenceResolveSync moduleReferenceResolveSync, JetBrains.Application.ChangeManager changeManager, JetBrains.ProjectModel.Impl.AssemblyInfoCache assemblyInfoCache, JetBrains.Application.FileSystemTracker.IFileSystemTracker fileSystemTracker, JetBrains.UI.StatusBar.IStatusBar statusBar = null) { }
        public void Dispose() { }
        public void ForceSyncExternalChange(JetBrains.Util.FileSystemPath path, JetBrains.ProjectModel.FileSystemChangeType changeType, bool doSync) { }
        public void OnFileSystemChanged(JetBrains.ProjectModel.FileSystemChange change) { }
    }
    public class GuidProjectReference : JetBrains.Util.UserDataHolder, JetBrains.ProjectModel.IProjectElement, JetBrains.ProjectModel.IProjectModelElement, JetBrains.ProjectModel.IProjectModelElementInternal, JetBrains.ProjectModel.IProjectToModuleReference, JetBrains.ProjectModel.IProjectToProjectReference, JetBrains.ProjectModel.References.IProjectToModuleWithSourcesReference, JetBrains.Util.IUserDataHolder, System.IDisposable
    {
        public GuidProjectReference(System.Guid referencedProjectGuid, string referencedProjectName, JetBrains.ProjectModel.IProject containingProject, bool copyLocal, bool embedInteropTypes, string aliasList) { }
        public GuidProjectReference(JetBrains.ProjectModel.IProject containingProject, System.Guid referencedProjectGuid, string referencedProjectName) { }
        public string AliasList { get; set; }
        public bool CopyLocal { get; set; }
        public bool EmbedInteropTypes { get; set; }
        public JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext ModuleReferenceResolveContext { get; }
        public string Name { get; }
        public JetBrains.ProjectModel.IProject OwnerModule { get; }
        public System.Guid ReferencedProjectGuid { get; }
        public string ReferencedProjectName { get; }
        public void Accept(JetBrains.ProjectModel.ProjectVisitor projectVisitor) { }
        public void AssertIsValid() { }
        public void Dispose() { }
        public string GetPersistentID() { }
        public JetBrains.ProjectModel.IProject GetProject() { }
        public object GetProperty(JetBrains.Util.Key propertyName) { }
        public JetBrains.ProjectModel.ISolution GetSolution() { }
        public bool IsValid() { }
        public static JetBrains.ProjectModel.Impl.GuidProjectReference ReadReference(System.IO.BinaryReader reader, JetBrains.ProjectModel.ProjectImpl project) { }
        public void SetProperty(JetBrains.Util.Key propertyName, object propertyValue) { }
        public override string ToString() { }
        public void WriteReference(System.IO.BinaryWriter writer) { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public sealed class InMemoryChangeManager : JetBrains.Application.IChangeProvider, JetBrains.ProjectModel.IInMemoryChangeManager
    {
        public InMemoryChangeManager(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.ChangeManager changeManager) { }
        public event JetBrains.ProjectModel.BeforeFilesSavedEventHandler BeforeFilesSaved;
        public object Execute(JetBrains.Application.IChangeMap changeMap) { }
        public void RegisterInMemoryTracker(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ProjectModel.IInMemoryFileChangeTracker inMemoryFileChangeTracker) { }
        public void SaveAll() { }
    }
    public class ProjectFileModificationCookie : JetBrains.Util.ModificationCookie
    {
        public ProjectFileModificationCookie(JetBrains.Util.EnsureWritableResult ensureWritableResult, [JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.ICollection<JetBrains.ProjectModel.IProjectFile> projectFiles) { }
        public ProjectFileModificationCookie(JetBrains.Util.EnsureWritableResult ensureWritableResult, [JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.ICollection<JetBrains.ProjectModel.IProjectFile> projectFiles, string message) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public System.Collections.Generic.ICollection<JetBrains.ProjectModel.IProjectFile> ProjectFiles { get; }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class ProjectImporterImpl : JetBrains.ProjectModel.Standalone.IProjectImporter
    {
        public ProjectImporterImpl(JetBrains.Application.IShellLocks locks, JetBrains.ProjectModel.PlatformManager platformManager, JetBrains.ProjectModel.Properties.ProjectPropertiesFactory projectPropertiesFactory, JetBrains.ProjectModel.Properties.ProjectFilePropertiesFactory projectFilePropertiesFactory, JetBrains.ProjectModel.Properties.ProjectFlavoursFactory flavoursFactory) { }
        public JetBrains.ProjectModel.IProject AddProject(JetBrains.ProjectModel.Impl.SolutionElement solution, JetBrains.Util.FileSystemPath projectLocation) { }
        public bool ImportSolution(JetBrains.ProjectModel.Impl.SolutionElement solution, JetBrains.Util.FileSystemPath solutionFilePath) { }
    }
    public class ProjectInstance
    {
        public ProjectInstance(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.Components.IComponentContainer parentContainer, JetBrains.Application.Parts.IPartsCatalogueSet catalogueSet, JetBrains.ProjectModel.IProject project, JetBrains.Application.Env.RunsProducts.ProductConfigurations productConfigurations) { }
        public JetBrains.Application.Components.ComponentContainer ComponentContainer { get; }
        public JetBrains.DataFlow.Lifetime Lifetime { get; }
        public JetBrains.ProjectModel.IProject Project { get; }
        public static JetBrains.Application.Components.IComponentContainer GetContainer([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IProject project) { }
        public void InitializeComponents() { }
    }
    public class ProjectModelBatchChange : JetBrains.ProjectModel.Transaction.IProjectModelBatchChange
    {
        public ProjectModelBatchChange(JetBrains.ProjectModel.Transaction.ProjectModelBatchChangeManager manager, bool notifyChangeManager) { }
        public bool NotifyChangeManager { get; }
        public void AddDeltas(JetBrains.ProjectModel.ProjectModelChange[] newDeltas) { }
        public void Commit(JetBrains.Application.Progress.ITaskExecutor executor) { }
        public System.Collections.Generic.IList<JetBrains.ProjectModel.ProjectModelChange> GetChanges() { }
        public System.Collections.Generic.IList<JetBrains.ProjectModel.ProjectModelChange> GetChangesAndWipe() { }
    }
    [JetBrains.ProjectModel.ProjectModelElementPresenterAttribute(1D)]
    public class ProjectModelElementPresenter : JetBrains.ProjectModel.IProjectModelElementPresenter
    {
        public ProjectModelElementPresenter(JetBrains.ProjectModel.ProjectModelIcons projectModelIcons) { }
        public JetBrains.UI.Icons.IconId GetIcon(JetBrains.ProjectModel.IProjectModelElement element) { }
        public string GetPresentableLocation(JetBrains.ProjectModel.IProjectModelElement projectModelElement) { }
    }
    public class static ProjectReferenceExtension
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static string GetReferencedName(this JetBrains.ProjectModel.IProjectToProjectReference projectToProjectReference) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static string GetReferencedName(this JetBrains.ProjectModel.IProject referencedProject) { }
    }
    public class ProjectSerializationIndex
    {
        public System.Collections.Generic.Dictionary<System.Guid, JetBrains.ProjectModel.Properties.IProjectPropertiesFactory> FactoryByGuid { get; }
        public JetBrains.Util.BidirectionalMap<System.Guid, byte> IndexByGuid { get; }
        public JetBrains.ProjectModel.ISolutionOwner SolutionOwner { get; }
        public static JetBrains.ProjectModel.Impl.ProjectSerializationIndex CreateProjectSerializationIndex(JetBrains.ProjectModel.ISolutionOwner owner, System.IO.BinaryWriter writer) { }
        public static JetBrains.ProjectModel.Impl.ProjectSerializationIndex ReadProjectSerializationIndex(JetBrains.ProjectModel.ISolutionOwner solutionOwner, System.IO.BinaryReader reader) { }
    }
    public class ProjectToAssemblyReference : JetBrains.ProjectModel.Impl.ProjectToAssemblyReferenceBase, JetBrains.ProjectModel.IProjectElement, JetBrains.ProjectModel.IProjectModelElement, JetBrains.ProjectModel.IProjectToAssemblyReference, JetBrains.ProjectModel.IProjectToModuleReference, JetBrains.ProjectModel.Model2.References.IModuleToAssemblyReference, JetBrains.Util.IUserDataHolder, System.IDisposable
    {
        public ProjectToAssemblyReference(JetBrains.ProjectModel.IProject containingProject, JetBrains.ProjectModel.Model2.References.AssemblyReferenceTarget referenceTarget) { }
        public string AliasList { get; set; }
        public bool CopyLocal { get; set; }
        public bool EmbedInteropTypes { get; set; }
        public override JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext ModuleReferenceResolveContext { get; }
        public override JetBrains.ProjectModel.IProject OwnerModule { get; }
        public override void Accept(JetBrains.ProjectModel.ProjectVisitor visitor) { }
        public override void AssertIsValid() { }
        public static JetBrains.ProjectModel.Impl.ProjectToAssemblyReference CreateFromLocation(JetBrains.ProjectModel.IProject project, JetBrains.Util.FileSystemPath location) { }
        public static JetBrains.ProjectModel.Impl.ProjectToAssemblyReference CreateFromName(JetBrains.ProjectModel.IProject project, JetBrains.Metadata.Utils.AssemblyNameInfo assemblyName) { }
        public string GetPersistentID() { }
        public JetBrains.ProjectModel.IProject GetProject() { }
        public override bool IsValid() { }
        public static JetBrains.ProjectModel.Impl.ProjectToAssemblyReference ReadReference(System.IO.BinaryReader reader, JetBrains.ProjectModel.ProjectImpl project) { }
        public override string ToString() { }
        public void WriteReference(System.IO.BinaryWriter writer) { }
    }
    public abstract class ProjectToAssemblyReferenceBase : JetBrains.ProjectModel.IProjectModelElement, JetBrains.ProjectModel.IProjectModelElementInternal, JetBrains.ProjectModel.Model2.References.IModuleToAssemblyReference, JetBrains.Util.IUserDataHolder
    {
        protected readonly JetBrains.ProjectModel.Model2.References.AssemblyReferenceTarget myReferenceTarget;
        protected ProjectToAssemblyReferenceBase([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.Model2.References.AssemblyReferenceTarget referenceTarget) { }
        public abstract JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext ModuleReferenceResolveContext { get; }
        public string Name { get; }
        public abstract JetBrains.ProjectModel.IProject OwnerModule { get; }
        public JetBrains.ProjectModel.Model2.References.AssemblyReferenceTarget ReferenceTarget { get; }
        public abstract void Accept(JetBrains.ProjectModel.ProjectVisitor projectVisitor);
        public abstract void AssertIsValid();
        public void Dispose() { }
        public System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<object, object>> EnumerateData() { }
        public T GetData<T>(JetBrains.Util.Key<T> key)
            where T :  class { }
        public object GetProperty(JetBrains.Util.Key propertyName) { }
        public JetBrains.ProjectModel.ISolution GetSolution() { }
        public abstract bool IsValid();
        public void PutData<T>(JetBrains.Util.Key<T> key, T val)
            where T :  class { }
        public void SetProperty(JetBrains.Util.Key properyName, object propetyValue) { }
        public override string ToString() { }
    }
    public class ReferencesCollection<TReference> : JetBrains.ProjectModel.Model2.Interfaces.IReferencesCollection<TReference>, System.Collections.Generic.IEnumerable<TReference>, System.Collections.IEnumerable
        where TReference : JetBrains.ProjectModel.IProjectToModuleReference
    {
        public ReferencesCollection(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.IShellLocks locks) { }
        public ReferencesCollection(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.IShellLocks locks, System.Collections.Generic.IList<TReference> references) { }
        public int Count { get; }
        public void AddReference(TReference reference) { }
        public System.Collections.Generic.IEnumerator<TReference> GetEnumerator() { }
        public static JetBrains.ProjectModel.Impl.ReferencesCollection<JetBrains.ProjectModel.IProjectToModuleReference> ReadKnownProjectToModuleReferences(JetBrains.DataFlow.Lifetime lifetime, System.IO.BinaryReader reader, JetBrains.ProjectModel.ProjectImpl project, JetBrains.Application.IShellLocks locks) { }
        public void RemoveReference(TReference reference) { }
        public void WriteKnownProjectToModuleReferences(System.IO.BinaryWriter writer) { }
    }
    [JetBrains.Application.ShellComponentAttribute(JetBrains.Application.Components.ProgramConfigurations.NONE | JetBrains.Application.Components.ProgramConfigurations.STANDALONE | JetBrains.Application.Components.ProgramConfigurations.VS_ADDIN | JetBrains.Application.Components.ProgramConfigurations.ALL)]
    public class SaveAllOnSolutionClose : JetBrains.ProjectModel.IQuerySolutionCloseHandler
    {
        public SaveAllOnSolutionClose(JetBrains.ProjectModel.Impl.InMemoryChangeManager memoryChangeManager) { }
        public bool QuerySolutionClose(JetBrains.ProjectModel.ISolution solution) { }
    }
    [JetBrains.Application.ShellComponentAttribute(JetBrains.Application.Components.ProgramConfigurations.NONE | JetBrains.Application.Components.ProgramConfigurations.STANDALONE | JetBrains.Application.Components.ProgramConfigurations.TEST | JetBrains.Application.Components.ProgramConfigurations.COMMAND_LINE | JetBrains.Application.Components.ProgramConfigurations.ALL)]
    public class SaveProjectFileAfterInMemoryChange : JetBrains.Application.IChangeProvider, JetBrains.ProjectModel.IInMemoryFileChangeTracker
    {
        public SaveProjectFileAfterInMemoryChange(JetBrains.Application.IShellLocks locks, JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.ChangeManager changeManager, JetBrains.ProjectModel.IInMemoryChangeManager inMemoryChangeManager, JetBrains.ProjectModel.Impl.SolutionManagerImpl solutionManagerImpl) { }
        public object Execute(JetBrains.Application.IChangeMap changeMap) { }
        public void SaveFile(JetBrains.ProjectModel.IProjectFile file) { }
    }
    public class static ShellFileIcon
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.UI.Icons.IconId Create([JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.FileSystemPath path, JetBrains.ProjectModel.Impl.ShellFileIconId.IconSize iconsize = 1) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.UI.Icons.IconId Create([JetBrains.Annotations.NotNullAttribute()] string extension, JetBrains.ProjectModel.Impl.ShellFileIconId.IconSize iconsize = 1) { }
    }
    public class ShellFileIconId : JetBrains.UI.Icons.IconId
    {
        public readonly string ExtensionWithDot;
        public readonly JetBrains.ProjectModel.Impl.ShellFileIconId.IconSize Size;
        public override int CompareTo(JetBrains.UI.Icons.IconId otherRaw) { }
        public override bool Equals(JetBrains.UI.Icons.IconId otherRaw) { }
        protected override int GetHashCodeCore() { }
        protected override string ToStringCore() { }
        public enum IconSize
        {
            LargeIcon = 0,
            SmallIcon = 1,
        }
    }
    [JetBrains.Application.ShellComponentAttribute(JetBrains.Application.Sharing.Common, JetBrains.Application.Lifecycle.DemandReclaimable, JetBrains.Application.Creation.PrimaryThread, JetBrains.Application.Access.PrimaryThread)]
    public class ShellFileIconIdOwner : JetBrains.UI.Icons.IIconIdOwner
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static System.Windows.Media.Imaging.BitmapSource TryGetFileIconImage([JetBrains.Annotations.NotNullAttribute()] string extension, bool isLargeIcon = False) { }
    }
    public class SimpleProjectToProjectReference : JetBrains.Util.UserDataHolder, JetBrains.ProjectModel.IProjectElement, JetBrains.ProjectModel.IProjectModelElement, JetBrains.ProjectModel.IProjectModelElementInternal, JetBrains.ProjectModel.IProjectToModuleReference, JetBrains.ProjectModel.IProjectToProjectReference, JetBrains.ProjectModel.References.IProjectToModuleWithSourcesReference, JetBrains.Util.IUserDataHolder, System.IDisposable
    {
        public SimpleProjectToProjectReference(JetBrains.ProjectModel.IProject containingProject, JetBrains.ProjectModel.IProject referencedProject) { }
        public string AliasList { get; set; }
        public bool CopyLocal { get; set; }
        public bool EmbedInteropTypes { get; set; }
        public JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext ModuleReferenceResolveContext { get; }
        public string Name { get; }
        public JetBrains.ProjectModel.IProject OwnerModule { get; }
        public JetBrains.ProjectModel.IProjectModelElementPointer TargetProjectPointer { get; }
        public void Accept(JetBrains.ProjectModel.ProjectVisitor projectVisitor) { }
        public void AssertIsValid() { }
        public void Dispose() { }
        public string GetPersistentID() { }
        public JetBrains.ProjectModel.IProject GetProject() { }
        public object GetProperty(JetBrains.Util.Key propertyName) { }
        public JetBrains.ProjectModel.ISolution GetSolution() { }
        public bool IsValid() { }
        public static JetBrains.ProjectModel.IProjectToModuleReference ReadReference(System.IO.BinaryReader reader, JetBrains.ProjectModel.ProjectImpl project) { }
        public void SetProperty(JetBrains.Util.Key propertyName, object propertyValue) { }
        public void WriteReference(System.IO.BinaryWriter writer) { }
    }
    public class SolutionElement : JetBrains.Application.IChangeProvider, JetBrains.ProjectModel.IProjectCollection, JetBrains.ProjectModel.IProjectModelElement, JetBrains.ProjectModel.IProjectModelElementInternal, JetBrains.ProjectModel.ISolution, JetBrains.Util.IUserDataHolder, System.IDisposable
    {
        public const string MiscellaneousFiles = "Miscellaneous Files";
        public static readonly System.Guid MiscellaneousFilesProjectGuid;
        public static readonly System.Guid SolutionProjectGuid;
        public const string SolutionProjectName = "&";
        public SolutionElement(JetBrains.Util.FileSystemPath path, JetBrains.ProjectModel.ISolutionOwner solutionOwner, JetBrains.Application.ChangeManager changeManager, JetBrains.Application.IShellLocks locks, JetBrains.ProjectModel.PlatformManager platformManager, JetBrains.ProjectModel.IProjectFileExtensions projectFileExtensions) { }
        public JetBrains.ProjectModel.Model2.Assemblies.Interfaces.IAssemblyCollection AssemblyCollection { get; }
        public JetBrains.ProjectModel.Transaction.IProjectModelBatchChangeManager BatchChangeManager { get; }
        public JetBrains.Application.FileSystemTracker.IFileSystemTracker FileSystemTracker { get; }
        public bool IsTemporary { get; }
        public JetBrains.Application.IShellLocks Locks { get; }
        public JetBrains.ProjectModel.IProject MiscFilesProject { get; }
        public string Name { get; }
        public JetBrains.ProjectModel.PlatformManager PlatformManager { get; }
        public JetBrains.ProjectModel.ProjectManager ProjectManager { get; }
        public JetBrains.ProjectModel.IProjectFile SolutionFile { get; }
        public JetBrains.Util.FileSystemPath SolutionFilePath { get; }
        public JetBrains.ProjectModel.SolutionInstance SolutionInstance { get; set; }
        public JetBrains.ProjectModel.ISolutionOwner SolutionOwner { get; }
        public JetBrains.ProjectModel.IProject SolutionProject { get; }
        public JetBrains.ProjectModel.Impl.SolutionStructure Structure { get; }
        public JetBrains.ProjectModel.IProjectModelTimestamps Timestamps { get; }
        public void Accept(JetBrains.ProjectModel.ProjectVisitor visitor) { }
        public void AddTopLevelProject(JetBrains.ProjectModel.IProject project) { }
        public void AssertIsValid() { }
        public void BeforeTransactionCommits(JetBrains.ProjectModel.Transaction.BeforeChangesCommitsEventArgs beforeChangesCommitsEventArgs) { }
        public void Dispose() { }
        public void Dump(System.IO.TextWriter to) { }
        public object Execute(JetBrains.Application.IChangeMap changeMap) { }
        public JetBrains.ProjectModel.IProjectElement FindElementByPersistentID(string persistentID) { }
        public System.Collections.Generic.ICollection<JetBrains.ProjectModel.IProjectItem> FindProjectItemsByLocation(JetBrains.Util.FileSystemPath location) { }
        public System.Collections.Generic.IList<JetBrains.ProjectModel.Model2.Assemblies.Interfaces.IAssembly> GetAllAssemblies() { }
        public System.Collections.Generic.ICollection<JetBrains.ProjectModel.IProject> GetAllProjects() { }
        public T GetData<T>(JetBrains.Util.Key<T> key)
            where T :  class { }
        public JetBrains.ProjectModel.IProject GetProjectByGuid(System.Guid projectGuid) { }
        public JetBrains.ProjectModel.IProject GetProjectByName(string name) { }
        public object GetProperty(JetBrains.Util.Key propertyName) { }
        public JetBrains.ProjectModel.ISolution GetSolution() { }
        public static string GetSolutionOrProjectLegacySettingsFileSuffix(JetBrains.Application.Configuration.XmlExternalizationScope scope, JetBrains.Application.IApplicationDescriptor applicationDescriptor) { }
        public static string GetSolutionOrProjectSettingsStorageFileSuffix(JetBrains.Application.Configuration.XmlExternalizationScope scope) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.DataFlow.IProperty<JetBrains.Util.FileSystemPath> GetSolutionSettingsStoragePath([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.SolutionFileLocationLive location, JetBrains.Application.Configuration.XmlExternalizationScope scope) { }
        public System.Collections.Generic.ICollection<JetBrains.ProjectModel.IProject> GetTopLevelProjects() { }
        public void InitializationCompleted() { }
        public bool IsValid() { }
        public void PutData<T>(JetBrains.Util.Key<T> key, T val)
            where T :  class { }
        public void ReadSolution(System.IO.BinaryReader reader) { }
        public void RemoveProjectImpl(JetBrains.ProjectModel.IProject project) { }
        public void RenameSolutionFile(JetBrains.Util.FileSystemPath newSolutionFilePath) { }
        public void SetProperty(JetBrains.Util.Key propertyName, object propertyValue) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.Util.FileSystemPath SolutionSettingsLegacyPath(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Configuration.XmlExternalizationScope scope, JetBrains.Application.IApplicationDescriptor applicationDescriptor) { }
        public override string ToString() { }
        public void UpdateOutputAssemblies() { }
        public void WriteSolution(System.IO.BinaryWriter writer) { }
    }
    public class static SolutionExtentions
    {
        public static JetBrains.ProjectModel.IProject AddProject(this JetBrains.ProjectModel.Impl.SolutionElement solution, JetBrains.ProjectModel.ProjectImpl projectImpl) { }
        public static JetBrains.ProjectModel.IProject AddProjectFromLocation(this JetBrains.ProjectModel.Impl.SolutionElement solution, JetBrains.ProjectModel.Properties.IProjectProperties projectProperties, System.Guid projectGuid, JetBrains.Util.FileSystemPath projectLocation, JetBrains.Util.FileSystemPath projectFileLocation, string projectName) { }
        public static JetBrains.ProjectModel.IProject AddProjectFromLocation(this JetBrains.ProjectModel.Impl.SolutionElement solution, JetBrains.ProjectModel.Properties.IProjectProperties projectProperties, JetBrains.Util.FileSystemPath projectFileLocation, System.Guid projectGuid) { }
    }
    public class SolutionFormatVersion
    {
        public static JetBrains.ProjectModel.Impl.SolutionFormatVersion Unknown;
        public const string VS_2005_TECH_VERSION = "9.00";
        public const string VS_2008_TECH_VERSION = "10.00";
        public const string VS_2010_TECH_VERSION = "11.00";
        public const string VS_2011_TECH_VERSION = "12.00";
        public System.Version MaxPlatformVersion { get; }
        public string VsTechVersion { get; }
        public static JetBrains.ProjectModel.Impl.SolutionFormatVersion Get([JetBrains.Annotations.NotNullAttribute()] string value) { }
    }
    [JetBrains.Application.ShellComponentAttribute(JetBrains.Application.Components.ProgramConfigurations.NONE | JetBrains.Application.Components.ProgramConfigurations.STANDALONE | JetBrains.Application.Components.ProgramConfigurations.COMMAND_LINE | JetBrains.Application.Components.ProgramConfigurations.ALL)]
    public class SolutionManagerImpl : JetBrains.ProjectModel.SolutionManagerBase, JetBrains.Application.IChangeProvider, JetBrains.ProjectModel.ISolutionOpeningOwner, JetBrains.ProjectModel.ISolutionOwner
    {
        protected readonly JetBrains.Application.ChangeManager myChangeManager;
        public SolutionManagerImpl(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.Parts.IPartsCatalogueSet catalogueSet, JetBrains.Application.Components.IComponentContainer componentContainer, JetBrains.Application.ChangeManager changeManager, JetBrains.ProjectModel.Standalone.IProjectImporter projectImporter, JetBrains.Application.IShellLocks locks, JetBrains.ProjectModel.PlatformManager platformManager, JetBrains.Application.Env.RunsProducts.ProductConfigurations productConfigurations, System.Collections.Generic.IEnumerable<JetBrains.ProjectModel.IQuerySolutionCloseHandler> solutionCloseHandlers, JetBrains.ProjectModel.Properties.ProjectPropertiesFactory projectPropertiesFactory, JetBrains.ProjectModel.Properties.ProjectFlavoursFactory projectFlavoursFactory, JetBrains.ProjectModel.Tasks.ISolutionLoadTasksScheduler scheduler, JetBrains.ProjectModel.Properties.ProjectFilePropertiesFactory projectFilePropertiesFactory, JetBrains.ProjectModel.IProjectFileExtensions projectFileExtensions) { }
        protected JetBrains.Application.ChangeManager ChangeManager { get; }
        public override bool IsRealSolutionOwner { get; }
        protected JetBrains.ProjectModel.PlatformManager PlatformManager { get; }
        protected JetBrains.ProjectModel.IProjectFileExtensions ProjectFileExtensions { get; set; }
        public JetBrains.ProjectModel.Standalone.IProjectImporter ProjectImporter { get; }
        public bool CloseSolution(JetBrains.ProjectModel.ISolution solution) { }
        public JetBrains.ProjectModel.Impl.SolutionElement CreateSolution(JetBrains.Util.FileSystemPath solutionFilePath) { }
        public JetBrains.ProjectModel.Impl.SolutionElement CreateSolutionWithCustomProcess(JetBrains.Util.FileSystemPath solutionFilePath, System.Action<JetBrains.ProjectModel.Impl.SolutionElement> creator) { }
        public object Execute(JetBrains.Application.IChangeMap changeMap) { }
        public JetBrains.ProjectModel.Impl.SolutionElement ImportProjectsFromExistingSolution([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.Impl.SolutionElement solution, JetBrains.Util.FileSystemPath solutionFilePath, bool doRemoveOldProjects) { }
        public JetBrains.ProjectModel.IProject OpenExistingProject(JetBrains.ProjectModel.Impl.SolutionElement solution, JetBrains.Util.FileSystemPath projectFilePath) { }
        public JetBrains.ProjectModel.Impl.SolutionElement OpenExistingSolution(JetBrains.Util.FileSystemPath solutionFilePath) { }
        public void StartOpenExistingSolution(JetBrains.Util.FileSystemPath solutionFilePath, System.Action callback) { }
    }
    public class SolutionStructure
    {
        public SolutionStructure(JetBrains.Application.IShellLocks locks) { }
        public void CheckValidity() { }
        public void Dump(System.IO.TextWriter writer) { }
        public System.Collections.Generic.ICollection<JetBrains.ProjectModel.IProjectItem> FindProjectItems(JetBrains.Util.FileSystemPath path) { }
        public void OnProjectItemAdded(JetBrains.ProjectModel.IProjectItem projectItem) { }
        public void OnProjectItemMoved(JetBrains.ProjectModel.IProjectItem projectItem, JetBrains.Util.FileSystemPath oldLocation) { }
        public void OnProjectItemRemoved(JetBrains.ProjectModel.IProjectItem projectItem) { }
    }
}
namespace JetBrains.ProjectModel.Impl.Build
{
    
    public sealed class ManagedProjectConfiguration : JetBrains.ProjectModel.Impl.Build.ManagedProjectConfigurationBase
    {
        public override bool UpdateFrom(JetBrains.ProjectModel.Properties.IProjectConfiguration configuration) { }
    }
    public abstract class ManagedProjectConfigurationBase : JetBrains.ProjectModel.Impl.Build.ProjectConfigurationBase, JetBrains.ProjectModel.Properties.IProjectConfiguration, JetBrains.ProjectModel.Properties.Managed.IManagedProjectConfiguration, JetBrains.Util.IUserDataHolder
    {
        protected ManagedProjectConfigurationBase() { }
        public virtual string DefineConstants { get; set; }
        public string DocumentationFile { get; set; }
        public bool EnableUnmanagedCodeDebugging { get; set; }
        public bool GenerateSerializationAssemblies { get; set; }
        public string NoWarn { get; set; }
        public bool Optimize { get; set; }
        public bool RegisterForCOMInterop { get; set; }
        public string RelativeIntermediateDirectory { get; set; }
        public bool RemoveIntegerChecks { get; set; }
        public bool TreatWarningsAsErrors { get; set; }
        public int WarningLevel { get; set; }
        public override void Dump(System.IO.TextWriter to, int indent) { }
        public override void ReadConfiguration(System.IO.BinaryReader reader) { }
        public override bool UpdateFrom(JetBrains.ProjectModel.Properties.IProjectConfiguration configuration) { }
        public override void WriteConfiguration(System.IO.BinaryWriter writer) { }
    }
    public abstract class ProjectConfigurationBase : JetBrains.Util.UserDataHolder, JetBrains.ProjectModel.Properties.IProjectConfiguration, JetBrains.Util.IUserDataHolder
    {
        protected ProjectConfigurationBase() { }
        public string Name { get; set; }
        public string RelativeOutputDirectory { get; set; }
        public virtual void Dump(System.IO.TextWriter to, int indent) { }
        protected void OnPropertyChange() { }
        public virtual void ReadConfiguration(System.IO.BinaryReader reader) { }
        public void SetProject(JetBrains.ProjectModel.IProject project) { }
        public virtual bool UpdateFrom(JetBrains.ProjectModel.Properties.IProjectConfiguration configuration) { }
        public virtual void WriteConfiguration(System.IO.BinaryWriter writer) { }
    }
    public class VBProjectConfiguration : JetBrains.ProjectModel.Impl.Build.ManagedProjectConfigurationBase, JetBrains.ProjectModel.Properties.IProjectConfiguration, JetBrains.ProjectModel.Properties.Managed.IManagedProjectConfiguration, JetBrains.ProjectModel.Properties.VB.IVBProjectConfiguration, JetBrains.Util.IUserDataHolder
    {
        public VBProjectConfiguration() { }
        public JetBrains.ProjectModel.Properties.DebugType DebugType { get; set; }
        public bool DefineDebug { get; set; }
        public bool DefineTrace { get; set; }
        public string MyType { get; set; }
        public string Platform { get; set; }
        public string WarningsAsErrors { get; set; }
        public override void Dump(System.IO.TextWriter to, int indent) { }
        public string GetCompilerOptionsCommandLine(JetBrains.Util.FileSystemPath location) { }
        public override void ReadConfiguration(System.IO.BinaryReader reader) { }
        public override bool UpdateFrom(JetBrains.ProjectModel.Properties.IProjectConfiguration configuration) { }
        public override void WriteConfiguration(System.IO.BinaryWriter writer) { }
    }
}
namespace JetBrains.ProjectModel.impl
{
    
    [JetBrains.ProjectModel.impl.PlatformsProviderAttribute()]
    public class CompactPlatformsProvider : JetBrains.ProjectModel.impl.IPlatformsProvider
    {
        public CompactPlatformsProvider(JetBrains.ProjectModel.impl.IFrameworkDetectionHelper frameworkDetectionHelper) { }
        public JetBrains.ProjectModel.PlatformID DetectPlatformIdByReferences(JetBrains.Metadata.Utils.AssemblyNameInfo corlibReference, JetBrains.Metadata.Utils.AssemblyNameInfo[] otherReferences, System.Collections.Generic.IList<JetBrains.ProjectModel.PlatformInfo> platforms) { }
        public System.Collections.Generic.IDictionary<JetBrains.Util.FileSystemPath, JetBrains.ProjectModel.PlatformID> GetPlatformFoldersPrefixes(System.Collections.Generic.IList<JetBrains.ProjectModel.PlatformInfo> platforms) { }
        public System.Collections.Generic.IList<JetBrains.ProjectModel.PlatformInfo> GetPlatforms() { }
    }
    public class static DefaultPlatformUtil
    {
        public static JetBrains.ProjectModel.PlatformInfo GetDefaultPlatformInfo(System.Collections.Generic.IEnumerable<JetBrains.ProjectModel.PlatformInfo> allPlatforms) { }
    }
    public abstract class FrameworkDetectionHelperBase : JetBrains.ProjectModel.impl.IFrameworkDetectionHelper
    {
        public event System.Action DetectionDataChanged;
        public abstract System.Version[] EnumerateInstalledNetFrameworks();
        public abstract System.Collections.Generic.IList<JetBrains.ProjectModel.impl.LightPlatformDefinition> GetCompactPlatforms();
        public abstract System.Collections.Generic.IList<JetBrains.ProjectModel.Impl.Sdk.SdkInfo> GetDotNetSdk();
        protected System.Collections.Generic.IList<JetBrains.ProjectModel.Impl.Sdk.SdkInfo> GetExtensionSdks(JetBrains.Util.FileSystemPath sdkRoot, string targetPlatformIdentifier, string targetPlatformVersion) { }
        protected System.Collections.Generic.IList<JetBrains.ProjectModel.Impl.Sdk.SdkInfo> GetExtensionSdks(JetBrains.Util.FileSystemPath sdkRoot) { }
        protected abstract System.Collections.Generic.IEnumerable<JetBrains.Util.FileSystemPath> GetExtensionSdksFolders();
        public System.Collections.Generic.IList<JetBrains.ProjectModel.PlatformInfo> GetFrameworksFromReferenceAssembliesFolder(JetBrains.Util.FileSystemPath path, System.Func<JetBrains.ProjectModel.PlatformID, System.Collections.Generic.IList<JetBrains.Util.FileSystemPath>> getAssemblyFolders, System.Func<System.Version, JetBrains.Util.FileSystemPath> getRuntimeDir, System.Func<System.Version, bool> addRuntimeFramework) { }
        public abstract System.Collections.Generic.IList<JetBrains.ProjectModel.impl.LightPlatformDefinition> GetMicroFrameworkPlatforms();
        protected abstract JetBrains.Util.FileSystemPath GetMicrosoftReferenceAssembliesRoot();
        public abstract JetBrains.Util.FileSystemPath GetMsBuildDirectory(System.Version version);
        public System.Version GetMsBuildVersion(System.Version platformVersion) { }
        public abstract JetBrains.Util.FileSystemPath GetNetCoreFrameworkReferenceAssembliesPath();
        public abstract JetBrains.Util.FileSystemPath[] GetNetFrameworkAssemblyFolders(System.Version version);
        public abstract JetBrains.Util.FileSystemPath GetNetFrameworkDirectory(System.Version version);
        public abstract JetBrains.Util.FileSystemPath[] GetNetFrameworkGlobalAssemblyFolders();
        public abstract JetBrains.Util.FileSystemPath GetNetFrameworkReferenceAssembliesPath();
        public abstract JetBrains.Util.FileSystemPath GetNetFrameworkV3AssembliesPath(int minorVersion);
        public abstract System.Collections.Generic.ICollection<JetBrains.Util.FileSystemPath> GetSdkInstallationFolders();
        public abstract System.Collections.Generic.IList<JetBrains.ProjectModel.impl.LightPlatformDefinition> GetSilverlightPlatforms();
        public System.Collections.Generic.IList<JetBrains.ProjectModel.PlatformInfo> GetThirdPartyFrameworks() { }
        public abstract JetBrains.Util.FileSystemPath GetWindows8PlatfromSdkFolder(System.Version version);
        public abstract System.Collections.Generic.IList<JetBrains.ProjectModel.Impl.Sdk.SdkInfo> GetWindowsSdk();
    }
    public class static FrameworkDetectionUtils
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static System.Version ExtractExactVersion(string name) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static System.Version ExtractMajorMinorVersion(string name) { }
        public static JetBrains.ProjectModel.PlatformID FindPlatform([JetBrains.Annotations.NotNullAttribute()] this System.Collections.Generic.IEnumerable<JetBrains.ProjectModel.PlatformInfo> platforms, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.FrameworkIdentifier identifier, [JetBrains.Annotations.NotNullAttribute()] System.Version version, JetBrains.ProjectModel.ProfileIdentifier profile = null) { }
        public static System.Collections.Generic.IDictionary<JetBrains.Util.FileSystemPath, JetBrains.ProjectModel.PlatformID> ToPlatformFoldersPrefixes(this System.Collections.Generic.IEnumerable<JetBrains.ProjectModel.PlatformInfo> platforms) { }
    }
    public interface IFrameworkDetectionHelper
    {
        public event System.Action DetectionDataChanged;
        System.Version[] EnumerateInstalledNetFrameworks();
        System.Collections.Generic.IList<JetBrains.ProjectModel.impl.LightPlatformDefinition> GetCompactPlatforms();
        System.Collections.Generic.IList<JetBrains.ProjectModel.Impl.Sdk.SdkInfo> GetDotNetSdk();
        System.Collections.Generic.IList<JetBrains.ProjectModel.PlatformInfo> GetFrameworksFromReferenceAssembliesFolder(JetBrains.Util.FileSystemPath path, System.Func<JetBrains.ProjectModel.PlatformID, System.Collections.Generic.IList<JetBrains.Util.FileSystemPath>> getAssemblyFolders, System.Func<System.Version, JetBrains.Util.FileSystemPath> getRuntimeDir, System.Func<System.Version, bool> addRuntimeFramework);
        System.Collections.Generic.IList<JetBrains.ProjectModel.impl.LightPlatformDefinition> GetMicroFrameworkPlatforms();
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.Util.FileSystemPath GetMsBuildDirectory([JetBrains.Annotations.NotNullAttribute()] System.Version version);
        [JetBrains.Annotations.NotNullAttribute()]
        System.Version GetMsBuildVersion([JetBrains.Annotations.NotNullAttribute()] System.Version platformVersion);
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.Util.FileSystemPath GetNetCoreFrameworkReferenceAssembliesPath();
        JetBrains.Util.FileSystemPath[] GetNetFrameworkAssemblyFolders(System.Version version);
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.Util.FileSystemPath GetNetFrameworkDirectory([JetBrains.Annotations.NotNullAttribute()] System.Version version);
        JetBrains.Util.FileSystemPath[] GetNetFrameworkGlobalAssemblyFolders();
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.Util.FileSystemPath GetNetFrameworkReferenceAssembliesPath();
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.Util.FileSystemPath GetNetFrameworkV3AssembliesPath(int minorVersion);
        System.Collections.Generic.ICollection<JetBrains.Util.FileSystemPath> GetSdkInstallationFolders();
        System.Collections.Generic.IList<JetBrains.ProjectModel.impl.LightPlatformDefinition> GetSilverlightPlatforms();
        System.Collections.Generic.IList<JetBrains.ProjectModel.PlatformInfo> GetThirdPartyFrameworks();
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.Util.FileSystemPath GetWindows8PlatfromSdkFolder([JetBrains.Annotations.NotNullAttribute()] System.Version version);
        System.Collections.Generic.IList<JetBrains.ProjectModel.Impl.Sdk.SdkInfo> GetWindowsSdk();
    }
    public interface IPlatformsProvider
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ProjectModel.PlatformID DetectPlatformIdByReferences([JetBrains.Annotations.NotNullAttribute()] JetBrains.Metadata.Utils.AssemblyNameInfo corlibReference, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Metadata.Utils.AssemblyNameInfo[] otherReferences, [JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IList<JetBrains.ProjectModel.PlatformInfo> platforms);
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.IDictionary<JetBrains.Util.FileSystemPath, JetBrains.ProjectModel.PlatformID> GetPlatformFoldersPrefixes([JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IList<JetBrains.ProjectModel.PlatformInfo> platforms);
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.IList<JetBrains.ProjectModel.PlatformInfo> GetPlatforms();
    }
    public class LightPlatformDefinition
    {
        public LightPlatformDefinition(JetBrains.ProjectModel.PlatformID platformID, System.Collections.Generic.ICollection<JetBrains.Util.FileSystemPath> platformFolders, System.Collections.Generic.IList<JetBrains.Util.FileSystemPath> assemblyFolders) { }
        public LightPlatformDefinition(JetBrains.ProjectModel.PlatformID platformID, JetBrains.Util.FileSystemPath platformFolder, System.Collections.Generic.IList<JetBrains.Util.FileSystemPath> assemblyFolders) { }
        public System.Collections.Generic.IList<JetBrains.Util.FileSystemPath> AssemblyFolders { get; }
        public System.Collections.Generic.ICollection<JetBrains.Util.FileSystemPath> PlatformFolders { get; }
        public JetBrains.ProjectModel.PlatformID PlatformID { get; }
        public JetBrains.ProjectModel.PlatformInfo ToPlatformInfo() { }
    }
    [JetBrains.ProjectModel.impl.PlatformsProviderAttribute()]
    public class NetCoreProvider : JetBrains.ProjectModel.impl.IPlatformsProvider
    {
        public NetCoreProvider([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.impl.IFrameworkDetectionHelper frameworkDetectionHelper) { }
        [System.ObsoleteAttribute("Do not use me PLZ")]
        public static JetBrains.ProjectModel.PlatformID NetCorePlatformID { get; }
        public JetBrains.ProjectModel.PlatformID DetectPlatformIdByReferences(JetBrains.Metadata.Utils.AssemblyNameInfo corlibReference, JetBrains.Metadata.Utils.AssemblyNameInfo[] otherReferences, System.Collections.Generic.IList<JetBrains.ProjectModel.PlatformInfo> platforms) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public System.Collections.Generic.List<JetBrains.Util.FileSystemPath> GetNetCorePlatformFolders([JetBrains.Annotations.NotNullAttribute()] System.Version netCoreVersion) { }
        public System.Collections.Generic.IDictionary<JetBrains.Util.FileSystemPath, JetBrains.ProjectModel.PlatformID> GetPlatformFoldersPrefixes(System.Collections.Generic.IList<JetBrains.ProjectModel.PlatformInfo> platforms) { }
        public System.Collections.Generic.IList<JetBrains.ProjectModel.PlatformInfo> GetPlatforms() { }
    }
    [JetBrains.ProjectModel.impl.PlatformsProviderAttribute()]
    public class NetMicroFrameworksProvider : JetBrains.ProjectModel.impl.IPlatformsProvider
    {
        public NetMicroFrameworksProvider(JetBrains.ProjectModel.impl.IFrameworkDetectionHelper frameworkDetectionHelper) { }
        public JetBrains.ProjectModel.PlatformID DetectPlatformIdByReferences(JetBrains.Metadata.Utils.AssemblyNameInfo corlibReference, JetBrains.Metadata.Utils.AssemblyNameInfo[] otherReferences, System.Collections.Generic.IList<JetBrains.ProjectModel.PlatformInfo> platforms) { }
        public System.Collections.Generic.IDictionary<JetBrains.Util.FileSystemPath, JetBrains.ProjectModel.PlatformID> GetPlatformFoldersPrefixes(System.Collections.Generic.IList<JetBrains.ProjectModel.PlatformInfo> platforms) { }
        public System.Collections.Generic.IList<JetBrains.ProjectModel.PlatformInfo> GetPlatforms() { }
    }
    [JetBrains.ProjectModel.impl.PlatformsProviderAttribute()]
    public class NetPlatformsProvider : JetBrains.ProjectModel.impl.IPlatformsProvider
    {
        protected bool myRuntimeAssembliesOnly;
        public NetPlatformsProvider([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.impl.IFrameworkDetectionHelper frameworkDetectionHelper) { }
        public JetBrains.ProjectModel.PlatformID DetectPlatformIdByReferences(JetBrains.Metadata.Utils.AssemblyNameInfo cr, JetBrains.Metadata.Utils.AssemblyNameInfo[] otherReferences, System.Collections.Generic.IList<JetBrains.ProjectModel.PlatformInfo> platforms) { }
        protected virtual JetBrains.ProjectModel.PlatformID FindPlatformForCorlibReference(System.Version mscorlibVersion, System.Collections.Generic.IList<JetBrains.ProjectModel.PlatformInfo> platforms) { }
        public System.Collections.Generic.IDictionary<JetBrains.Util.FileSystemPath, JetBrains.ProjectModel.PlatformID> GetPlatformFoldersPrefixes(System.Collections.Generic.IList<JetBrains.ProjectModel.PlatformInfo> platforms) { }
        public System.Collections.Generic.IList<JetBrains.ProjectModel.PlatformInfo> GetPlatforms() { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class PlatformManagerImpl : JetBrains.ProjectModel.PlatformManager, JetBrains.Application.IExternalSourcesDebugInfoProvider
    {
        protected System.Collections.Generic.IList<> modreq(System.Runtime.CompilerServices.IsVolatile) myAllPlatforms;
        protected System.Collections.Generic.List<> modreq(System.Runtime.CompilerServices.IsVolatile) myPlatformFoldersPrefixes;
        protected System.Collections.Generic.Dictionary<, > modreq(System.Runtime.CompilerServices.IsVolatile) myPlatformFoldersPrefixesByProvider;
        protected System.Collections.Generic.Dictionary<, > modreq(System.Runtime.CompilerServices.IsVolatile) myPlatformsByProvider;
        public PlatformManagerImpl(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ProjectModel.impl.IFrameworkDetectionHelper frameworkDetectionHelper, JetBrains.DataFlow.IViewable<JetBrains.ProjectModel.impl.IPlatformsProvider> providers) { }
        public override JetBrains.Util.FileSystemPath Gac40Path { get; }
        public override JetBrains.Util.FileSystemPath GacPath { get; }
        public override void Dump(System.IO.TextWriter writer, JetBrains.Util.FileSystemPath rootPath = null, JetBrains.Util.FileSystemPath replacePath = null) { }
        public override System.Collections.Generic.IEnumerable<JetBrains.ProjectModel.PlatformInfo> GetAllPlatformInfos() { }
        public override JetBrains.ProjectModel.PlatformID GetAssemblyPlatformId(JetBrains.Util.FileSystemPath assemblyPath) { }
        public override JetBrains.ProjectModel.PlatformInfo GetDefaultPlatformInfo() { }
        public override JetBrains.ProjectModel.PlatformInfo GetPlatformInfo([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ProjectModel.PlatformID platformID) { }
        public override JetBrains.ProjectModel.PlatformID GetRunTimePlatformId(JetBrains.ProjectModel.PlatformID compileTimePlatformId) { }
        public override bool IsFrameworkAssembly(JetBrains.Util.FileSystemPath fileSystemPath) { }
    }
    [JetBrains.Annotations.BaseTypeRequiredAttribute(typeof(JetBrains.ProjectModel.impl.IPlatformsProvider))]
    [JetBrains.Annotations.MeansImplicitUseAttribute()]
    [System.AttributeUsageAttribute(System.AttributeTargets.Class | System.AttributeTargets.All)]
    public class PlatformsProviderAttribute : JetBrains.Application.ShellComponentAttribute
    {
        public PlatformsProviderAttribute(JetBrains.Application.Components.ProgramConfigurations programConfigurations) { }
    }
    [JetBrains.ProjectModel.impl.PlatformsProviderAttribute()]
    public class SilverlightPlatformsProvider : JetBrains.ProjectModel.impl.IPlatformsProvider
    {
        public SilverlightPlatformsProvider(JetBrains.ProjectModel.impl.IFrameworkDetectionHelper frameworkDetectionHelper) { }
        public JetBrains.ProjectModel.PlatformID DetectPlatformIdByReferences(JetBrains.Metadata.Utils.AssemblyNameInfo corlibReference, JetBrains.Metadata.Utils.AssemblyNameInfo[] otherReferences, System.Collections.Generic.IList<JetBrains.ProjectModel.PlatformInfo> platforms) { }
        public System.Collections.Generic.IDictionary<JetBrains.Util.FileSystemPath, JetBrains.ProjectModel.PlatformID> GetPlatformFoldersPrefixes(System.Collections.Generic.IList<JetBrains.ProjectModel.PlatformInfo> platforms) { }
        public System.Collections.Generic.IList<JetBrains.ProjectModel.PlatformInfo> GetPlatforms() { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class SwitchingFrameworkLocationHelper : JetBrains.ProjectModel.impl.IFrameworkDetectionHelper
    {
        public SwitchingFrameworkLocationHelper() { }
        public JetBrains.ProjectModel.impl.IFrameworkDetectionHelper Helper { get; set; }
        public event System.Action DetectionDataChanged;
        public System.Version[] EnumerateInstalledNetFrameworks() { }
        public System.Collections.Generic.IList<JetBrains.ProjectModel.impl.LightPlatformDefinition> GetCompactPlatforms() { }
        protected virtual JetBrains.ProjectModel.impl.IFrameworkDetectionHelper GetDefaultHelper() { }
        public System.Collections.Generic.IList<JetBrains.ProjectModel.Impl.Sdk.SdkInfo> GetDotNetSdk() { }
        public System.Collections.Generic.IList<JetBrains.ProjectModel.PlatformInfo> GetFrameworksFromReferenceAssembliesFolder(JetBrains.Util.FileSystemPath path, System.Func<JetBrains.ProjectModel.PlatformID, System.Collections.Generic.IList<JetBrains.Util.FileSystemPath>> getAssemblyFolders, System.Func<System.Version, JetBrains.Util.FileSystemPath> getRuntimeDir, System.Func<System.Version, bool> addRuntimeFramework) { }
        public System.Collections.Generic.IList<JetBrains.ProjectModel.impl.LightPlatformDefinition> GetMicroFrameworkPlatforms() { }
        public JetBrains.Util.FileSystemPath GetMsBuildDirectory(System.Version version) { }
        public System.Version GetMsBuildVersion(System.Version platformVersion) { }
        public JetBrains.Util.FileSystemPath GetNetCoreFrameworkReferenceAssembliesPath() { }
        public JetBrains.Util.FileSystemPath[] GetNetFrameworkAssemblyFolders(System.Version version) { }
        public JetBrains.Util.FileSystemPath GetNetFrameworkDirectory(System.Version version) { }
        public JetBrains.Util.FileSystemPath[] GetNetFrameworkGlobalAssemblyFolders() { }
        public JetBrains.Util.FileSystemPath GetNetFrameworkReferenceAssembliesPath() { }
        public JetBrains.Util.FileSystemPath GetNetFrameworkV3AssembliesPath(int minorVersion) { }
        public System.Collections.Generic.ICollection<JetBrains.Util.FileSystemPath> GetSdkInstallationFolders() { }
        public System.Collections.Generic.IList<JetBrains.ProjectModel.impl.LightPlatformDefinition> GetSilverlightPlatforms() { }
        public System.Collections.Generic.IList<JetBrains.ProjectModel.PlatformInfo> GetThirdPartyFrameworks() { }
        public JetBrains.Util.FileSystemPath GetWindows8PlatfromSdkFolder(System.Version version) { }
        public System.Collections.Generic.IList<JetBrains.ProjectModel.Impl.Sdk.SdkInfo> GetWindowsSdk() { }
    }
    public class SystemFrameworkLocationHelper : JetBrains.ProjectModel.impl.FrameworkDetectionHelperBase
    {
        public event System.Action DetectionDataChanged;
        public override System.Version[] EnumerateInstalledNetFrameworks() { }
        public static System.Version ExtractSdkVersion(string key) { }
        public override System.Collections.Generic.IList<JetBrains.ProjectModel.impl.LightPlatformDefinition> GetCompactPlatforms() { }
        public override System.Collections.Generic.IList<JetBrains.ProjectModel.Impl.Sdk.SdkInfo> GetDotNetSdk() { }
        protected override System.Collections.Generic.IEnumerable<JetBrains.Util.FileSystemPath> GetExtensionSdksFolders() { }
        public override System.Collections.Generic.IList<JetBrains.ProjectModel.impl.LightPlatformDefinition> GetMicroFrameworkPlatforms() { }
        [JetBrains.Annotations.NotNullAttribute()]
        protected override JetBrains.Util.FileSystemPath GetMicrosoftReferenceAssembliesRoot() { }
        public override JetBrains.Util.FileSystemPath GetMsBuildDirectory(System.Version version) { }
        public override JetBrains.Util.FileSystemPath GetNetCoreFrameworkReferenceAssembliesPath() { }
        public override JetBrains.Util.FileSystemPath[] GetNetFrameworkAssemblyFolders(System.Version version) { }
        public override JetBrains.Util.FileSystemPath GetNetFrameworkDirectory(System.Version version) { }
        public override JetBrains.Util.FileSystemPath[] GetNetFrameworkGlobalAssemblyFolders() { }
        public override JetBrains.Util.FileSystemPath GetNetFrameworkReferenceAssembliesPath() { }
        public override JetBrains.Util.FileSystemPath GetNetFrameworkV3AssembliesPath(int minorVersion) { }
        public override System.Collections.Generic.ICollection<JetBrains.Util.FileSystemPath> GetSdkInstallationFolders() { }
        public override System.Collections.Generic.IList<JetBrains.ProjectModel.impl.LightPlatformDefinition> GetSilverlightPlatforms() { }
        [JetBrains.Annotations.NotNullAttribute()]
        public override JetBrains.Util.FileSystemPath GetWindows8PlatfromSdkFolder(System.Version version) { }
        public override System.Collections.Generic.IList<JetBrains.ProjectModel.Impl.Sdk.SdkInfo> GetWindowsSdk() { }
    }
    public enum TargetDotNetFrameworkVersion
    {
        Version11 = 0,
        Version20 = 1,
        Version30 = 2,
        Version35 = 3,
        Version40 = 4,
        VersionLatest = 4,
    }
    [JetBrains.ProjectModel.impl.PlatformsProviderAttribute()]
    public class ThirdPartyFrameworksProvider : JetBrains.ProjectModel.impl.IPlatformsProvider
    {
        public ThirdPartyFrameworksProvider(JetBrains.ProjectModel.impl.IFrameworkDetectionHelper frameworkDetectionHelper) { }
        public JetBrains.ProjectModel.PlatformID DetectPlatformIdByReferences(JetBrains.Metadata.Utils.AssemblyNameInfo corlibReference, JetBrains.Metadata.Utils.AssemblyNameInfo[] otherReferences, System.Collections.Generic.IList<JetBrains.ProjectModel.PlatformInfo> platforms) { }
        public System.Collections.Generic.IDictionary<JetBrains.Util.FileSystemPath, JetBrains.ProjectModel.PlatformID> GetPlatformFoldersPrefixes(System.Collections.Generic.IList<JetBrains.ProjectModel.PlatformInfo> platforms) { }
        public System.Collections.Generic.IList<JetBrains.ProjectModel.PlatformInfo> GetPlatforms() { }
    }
    [JetBrains.ProjectModel.SolutionInstanceComponentAttribute()]
    public class ViewableProjectsCollection
    {
        public ViewableProjectsCollection(JetBrains.DataFlow.Lifetime lifetime) { }
        public JetBrains.DataFlow.IViewable<JetBrains.ProjectModel.IProject> Projects { get; }
    }
}
namespace JetBrains.ProjectModel.Impl.Sdk
{
    
    public interface ISdkManager
    {
        System.Collections.Generic.ICollection<JetBrains.ProjectModel.Impl.Sdk.SdkInfo> Kits { get; }
        void Dump(System.IO.TextWriter writer);
    }
    public class SdkIdentifier : System.IEquatable<JetBrains.ProjectModel.Impl.Sdk.SdkIdentifier>
    {
        public static readonly JetBrains.ProjectModel.Impl.Sdk.SdkIdentifier DotNetSdk;
        public static readonly JetBrains.ProjectModel.Impl.Sdk.SdkIdentifier WindowsSdk;
        public SdkIdentifier([JetBrains.Annotations.NotNullAttribute()] string identifier) { }
        public bool Equals(JetBrains.ProjectModel.Impl.Sdk.SdkIdentifier other) { }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
        public override string ToString() { }
    }
    public class SdkInfo
    {
        public SdkInfo(JetBrains.ProjectModel.Impl.Sdk.SdkIdentifier identifier, System.Version version, JetBrains.Util.FileSystemPath root, System.Collections.Generic.ICollection<JetBrains.ProjectModel.Impl.Sdk.SdkInfo> extensionSDKs = null) { }
        public System.Collections.Generic.ICollection<JetBrains.ProjectModel.Impl.Sdk.SdkInfo> ExtensionSDKs { get; set; }
        public JetBrains.ProjectModel.Impl.Sdk.SdkIdentifier Identifier { get; }
        public JetBrains.Util.FileSystemPath Root { get; }
        public System.Version Version { get; }
    }
    public class static SdkManagerEx
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.Util.FileSystemPath GetToolPath(this JetBrains.ProjectModel.Impl.Sdk.ISdkManager sdkManager, string exeName) { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class SdkManagerImpl : JetBrains.Application.IExternalSourcesDebugInfoProvider, JetBrains.ProjectModel.Impl.Sdk.ISdkManager
    {
        public SdkManagerImpl(JetBrains.ProjectModel.impl.IFrameworkDetectionHelper frameworkDetectionHelper) { }
        public System.Collections.Generic.ICollection<JetBrains.ProjectModel.Impl.Sdk.SdkInfo> Kits { get; }
        public void Dump(System.IO.TextWriter writer) { }
    }
}
namespace JetBrains.ProjectModel.impl.SpecialFiles
{
    
    [JetBrains.ProjectModel.SolutionInstanceComponentAttribute()]
    public class SpecialFilesManager
    {
        public SpecialFilesManager(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.IShellLocks locks) { }
        public JetBrains.ProjectModel.IProjectFile CreateSpecialFile(JetBrains.Util.FileSystemPath path) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ProjectModel.IProjectFile FindSpecialFile(JetBrains.Util.FileSystemPath path) { }
        public JetBrains.ProjectModel.IProjectFile GetSpecialFile(JetBrains.Util.FileSystemPath path) { }
        public bool IsNonProjectItem(JetBrains.ProjectModel.IProjectItem projectFile) { }
        public bool IsSpecialFile(JetBrains.ProjectModel.IProjectItem projectItem) { }
        public void MoveSpecialFile(JetBrains.ProjectModel.IProjectFile projectFile, JetBrains.ProjectModel.IProjectFolder newParentFolder) { }
        public void ReleaseSpecialFile(JetBrains.Util.FileSystemPath path) { }
        public void ReleaseSpecialFile(JetBrains.ProjectModel.IProjectFile item) { }
    }
}
namespace JetBrains.ProjectModel.model2.Assemblies
{
    
    public class static AssemblyExtensions { }
}
namespace JetBrains.ProjectModel.model2.Assemblies.AssemblyToAssemblyResolvers
{
    
    public class static AssemblyReferencesResolverUtil
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.ProjectModel.PlatformInfo GetPlatformInfo(System.Collections.Generic.IEnumerable<JetBrains.Util.FileSystemPath> sourceAssemblyFile, JetBrains.ProjectModel.Impl.AssemblyInfoCache assemblyInfoCache, JetBrains.ProjectModel.PlatformManager platformManager) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.Util.FileSystemPath ResolveInDirectory(JetBrains.Metadata.Utils.AssemblyNameInfo referenceName, JetBrains.Util.FileSystemPath directory, JetBrains.ProjectModel.Impl.AssemblyInfoCache assemblyInfoCache, JetBrains.ProjectModel.AssemblyNamesInterner interner, string[] extensions) { }
    }
    [JetBrains.ProjectModel.SolutionInstanceComponentAttribute()]
    public class AssemblyToAssemblyReferencesResolveManager
    {
        public AssemblyToAssemblyReferencesResolveManager(JetBrains.DataFlow.Lifetime lifetime, JetBrains.DataFlow.IViewable<JetBrains.ProjectModel.model2.Assemblies.AssemblyToAssemblyResolvers.IAssemblyToAssemblyReferencesResolver> resolvers, JetBrains.ProjectModel.model2.Assemblies.AssemblyToAssemblyResolvers.FrameworkAssemblyToAssemblyReferencesResolver frameworkResolver, JetBrains.ProjectModel.Impl.AssemblyInfoCache assemblyInfoCache, JetBrains.ProjectModel.PlatformManager platformManager, JetBrains.ProjectModel.ISolution solution) { }
        public JetBrains.Metadata.Reader.API.IAssemblyResolver CreateMetadataAssemblyResolver([JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.FileSystemPath assemblyPath, System.Guid mvid) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public virtual JetBrains.Util.FileSystemPath ResolveReference(System.Collections.Generic.ICollection<JetBrains.Util.FileSystemPath> sourceAssemblyFile, JetBrains.Metadata.Utils.AssemblyNameInfo referenceName, JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext context) { }
    }
    [JetBrains.Annotations.BaseTypeRequiredAttribute(typeof(JetBrains.ProjectModel.model2.Assemblies.AssemblyToAssemblyResolvers.IAssemblyToAssemblyReferencesResolver))]
    [JetBrains.Annotations.MeansImplicitUseAttribute()]
    [System.AttributeUsageAttribute(System.AttributeTargets.Class | System.AttributeTargets.All, AllowMultiple=false)]
    public class AssemblyToAssemblyReferencesResolverAttribute : JetBrains.ProjectModel.SolutionInstanceComponentAttribute
    {
        public AssemblyToAssemblyReferencesResolverAttribute(double priority) { }
        public double Priority { get; }
    }
    [JetBrains.ProjectModel.SolutionInstanceComponentAttribute()]
    public class FrameworkAssemblyToAssemblyReferencesResolver
    {
        public FrameworkAssemblyToAssemblyReferencesResolver(JetBrains.ProjectModel.PlatformManager platformManager, JetBrains.ProjectModel.Impl.AssemblyInfoCache assemblyInfoCache, JetBrains.ProjectModel.AssemblyNamesInterner interner) { }
        public System.Collections.Generic.IEnumerable<JetBrains.Util.FileSystemPath> ResolveReference(System.Collections.Generic.ICollection<JetBrains.Util.FileSystemPath> sourceAssemblyFile, JetBrains.Metadata.Utils.AssemblyNameInfo referenceName) { }
    }
    [JetBrains.ProjectModel.model2.Assemblies.AssemblyToAssemblyResolvers.AssemblyToAssemblyReferencesResolverAttribute(2D)]
    public class GacAssemblyToAssemblyReferencesResolver : JetBrains.ProjectModel.model2.Assemblies.AssemblyToAssemblyResolvers.IAssemblyToAssemblyReferencesResolver
    {
        public GacAssemblyToAssemblyReferencesResolver(JetBrains.ProjectModel.PlatformManager platformManager, JetBrains.ProjectModel.Impl.AssemblyInfoCache assemblyInfoCache) { }
        public System.Collections.Generic.IEnumerable<JetBrains.Util.FileSystemPath> ResolveReference(System.Collections.Generic.ICollection<JetBrains.Util.FileSystemPath> sourceAssemblyFile, JetBrains.Metadata.Utils.AssemblyNameInfo referenceName) { }
    }
    [JetBrains.ProjectModel.model2.Assemblies.ProjectToAssemblyResolvers.ProjectToAssemblyReferencesResolverAttribute(2D)]
    public class GacProjectToAssemblyReferencesResolver : JetBrains.ProjectModel.model2.Assemblies.ProjectToAssemblyResolvers.IProjectToAssemblyReferencesResolver
    {
        public GacProjectToAssemblyReferencesResolver(JetBrains.ProjectModel.PlatformManager platformManager) { }
        public System.Collections.Generic.IEnumerable<JetBrains.Util.FileSystemPath> ResolveReference(JetBrains.ProjectModel.Model2.References.AssemblyReferenceTarget referenceTarget, JetBrains.ProjectModel.IProject referenceSource) { }
    }
    public interface IAssemblyToAssemblyReferencesResolver
    {
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.IEnumerable<JetBrains.Util.FileSystemPath> ResolveReference([JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.ICollection<JetBrains.Util.FileSystemPath> sourceAssemblyFile, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Metadata.Utils.AssemblyNameInfo referenceName);
    }
    [JetBrains.ProjectModel.model2.Assemblies.AssemblyToAssemblyResolvers.AssemblyToAssemblyReferencesResolverAttribute(3D)]
    public class NearAssemblyToAssemblyAssemblyToAssemblyReferencesResolver : JetBrains.ProjectModel.model2.Assemblies.AssemblyToAssemblyResolvers.IAssemblyToAssemblyReferencesResolver
    {
        public NearAssemblyToAssemblyAssemblyToAssemblyReferencesResolver(JetBrains.ProjectModel.Impl.AssemblyInfoCache assemblyInfoCache, JetBrains.ProjectModel.AssemblyNamesInterner interner) { }
        public System.Collections.Generic.IEnumerable<JetBrains.Util.FileSystemPath> ResolveReference(System.Collections.Generic.ICollection<JetBrains.Util.FileSystemPath> sourceAssemblyFile, JetBrains.Metadata.Utils.AssemblyNameInfo referenceName) { }
    }
    [JetBrains.ProjectModel.model2.Assemblies.AssemblyToAssemblyResolvers.AssemblyToAssemblyReferencesResolverAttribute(4D)]
    public class SolutionAssemblyToAssemblyReferencesResolver : JetBrains.ProjectModel.model2.Assemblies.AssemblyToAssemblyResolvers.IAssemblyToAssemblyReferencesResolver
    {
        public SolutionAssemblyToAssemblyReferencesResolver(JetBrains.ProjectModel.Model2.Assemblies.Impl.AssemblyCollection assemblyCollection) { }
        public System.Collections.Generic.IEnumerable<JetBrains.Util.FileSystemPath> ResolveReference(System.Collections.Generic.ICollection<JetBrains.Util.FileSystemPath> sourceAssemblyFile, JetBrains.Metadata.Utils.AssemblyNameInfo referenceName) { }
    }
}
namespace JetBrains.ProjectModel.Model2.Assemblies.Impl
{
    
    [JetBrains.ProjectModel.SolutionInstanceComponentAttribute()]
    public class AssemblyCollection : JetBrains.ProjectModel.Model2.Assemblies.Interfaces.IAssemblyCollection
    {
        public AssemblyCollection([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.Impl.SolutionElement solution, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.IShellLocks locks, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.Transaction.IProjectModelBatchChangeManager batchChangeManager, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.ChangeManager changeManager, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.Tasks.ISolutionLoadTasksScheduler scheduler) { }
        public JetBrains.ProjectModel.Transaction.IProjectModelBatchChangeManager BatchChangeManager { get; }
        public System.Collections.Generic.IList<JetBrains.ProjectModel.Model2.Assemblies.Interfaces.IAssemblyCookie> Cookies { get; }
        public JetBrains.DataFlow.Lifetime Lifetime { get; }
        public int Timestamp { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ProjectModel.Model2.Assemblies.Interfaces.IAssemblyCookie AddRef(JetBrains.ProjectModel.Model2.Assemblies.Interfaces.IAssemblyFile assemblyFile, string holderId) { }
        public bool ContainsAssembly(JetBrains.ProjectModel.Model2.Assemblies.Interfaces.IAssembly assembly) { }
        public void Dump(System.IO.TextWriter writer) { }
        public System.Collections.Generic.IList<JetBrains.ProjectModel.Model2.Assemblies.Interfaces.IAssembly> GetAllAssemblies() { }
        public System.Collections.Generic.ICollection<JetBrains.ProjectModel.Model2.Assemblies.Interfaces.IAssemblyFile> GetAllAssemblyFiles() { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ProjectModel.Model2.Assemblies.Interfaces.IAssemblyFile GetFileByLocation(JetBrains.Util.FileSystemPath path) { }
        public void IncrementTimeStamp() { }
        public void OnAssemblyFileAdded(JetBrains.ProjectModel.Model2.Assemblies.Interfaces.IAssembly assembly, JetBrains.ProjectModel.Model2.Assemblies.Interfaces.IAssemblyFile assemblyFile, bool fireEvent) { }
        public void OnAssemblyFileRemoved(JetBrains.ProjectModel.Model2.Assemblies.Interfaces.IAssembly assembly, JetBrains.ProjectModel.Model2.Assemblies.Interfaces.IAssemblyFile assemblyFile) { }
        public void ReleaseReference(JetBrains.ProjectModel.Model2.Assemblies.Interfaces.AssemblyCookie assemblyCookie) { }
    }
    [System.Diagnostics.DebuggerDisplayAttribute("AssemblyToAssembly: Source = {myAssembly}, Target = {ReferenceTarget.AssemblyName" +
        "}")]
    public class AssemblyToAssemblyReference : JetBrains.ProjectModel.Model2.Assemblies.Interfaces.IAssemblyToAssemblyReference, JetBrains.ProjectModel.Model2.References.IModuleToAssemblyReference
    {
        public AssemblyToAssemblyReference(JetBrains.ProjectModel.Model2.Assemblies.Interfaces.IAssembly assembly, JetBrains.ProjectModel.Model2.References.AssemblyReferenceTarget referenceTarget, JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext moduleReferenceResolveContext) { }
        public JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext ModuleReferenceResolveContext { get; }
        public JetBrains.ProjectModel.Model2.Assemblies.Interfaces.IAssembly OwnerModule { get; }
        public JetBrains.ProjectModel.Model2.References.AssemblyReferenceTarget ReferenceTarget { get; }
        public void Accept(JetBrains.ProjectModel.ProjectVisitor projectVisitor) { }
        public void AssertIsValid() { }
        protected bool Equals(JetBrains.ProjectModel.Model2.Assemblies.Impl.AssemblyToAssemblyReference other) { }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
        public bool IsValid() { }
    }
}
namespace JetBrains.ProjectModel.model2.Assemblies.Impl
{
    
    [JetBrains.ProjectModel.SolutionInstanceComponentAttribute()]
    public class AssemblyGC
    {
        public AssemblyGC(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ProjectModel.Model2.Assemblies.Impl.AssemblyCollection assemblyCollection, JetBrains.ProjectModel.ISolution solution, JetBrains.Application.IShellLocks locks, JetBrains.Application.ChangeManager changeManager, JetBrains.ProjectModel.Model2.Assemblies.Interfaces.IModuleReferencesResolveStore moduleReferencesResolveStore) { }
        public void ForceGC() { }
    }
}
namespace JetBrains.ProjectModel.Model2.Assemblies.Interfaces
{
    
    public class AssemblyCookie : JetBrains.ProjectModel.Model2.Assemblies.Interfaces.IAssemblyCookie, System.IDisposable
    {
        public AssemblyCookie(JetBrains.ProjectModel.Model2.Assemblies.Impl.AssemblyCollection assemblyCollection, JetBrains.ProjectModel.Model2.Assemblies.Interfaces.IAssemblyFile assemblyFile, string holderId) { }
        public JetBrains.ProjectModel.Model2.Assemblies.Interfaces.IAssembly Assembly { get; }
        public JetBrains.ProjectModel.Model2.Assemblies.Interfaces.IAssemblyFile AssemblyFile { get; }
        public string HolderId { get; }
        public void Dispose() { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class EffectiveReferencedAssemblyNamesExtractor
    {
        public EffectiveReferencedAssemblyNamesExtractor(System.Collections.Generic.IEnumerable<JetBrains.ProjectModel.Model2.Assemblies.Interfaces.ICustomReferencedAssemblyNamesProvider> providers) { }
        public System.Collections.Generic.IEnumerable<JetBrains.Metadata.Utils.AssemblyNameInfo> GetReferencedAssemblies(JetBrains.Metadata.Reader.API.IMetadataAssembly assembly) { }
    }
    public interface IAssembly : JetBrains.ProjectModel.IModule, JetBrains.ProjectModel.IProjectModelElement, JetBrains.Util.IUserDataHolder, System.IDisposable
    {
        JetBrains.Metadata.Utils.AssemblyNameInfo AssemblyName { get; }
        string FullAssemblyName { get; }
        bool HasStrongName { get; }
        bool IsMissing { get; }
        bool IsMscorlib { get; }
        bool IsRetargetable { get; }
        System.Guid Mvid { get; }
        void Dump(System.IO.TextWriter to);
        JetBrains.ProjectModel.Model2.Assemblies.Interfaces.IAssemblyFile FindFileByLocation(JetBrains.Util.FileSystemPath location);
        System.Collections.Generic.ICollection<JetBrains.ProjectModel.Model2.Assemblies.Interfaces.IAssemblyFile> GetFiles();
        System.Collections.Generic.ICollection<JetBrains.Metadata.Utils.AssemblyNameInfo> GetReferencedAssemblyNames();
    }
    public interface IAssemblyCollection
    {
        JetBrains.ProjectModel.Model2.Assemblies.Interfaces.IAssemblyCookie AddRef(JetBrains.ProjectModel.Model2.Assemblies.Interfaces.IAssemblyFile assemblyFile, string holderId);
        void Dump(System.IO.TextWriter writer);
        System.Collections.Generic.IList<JetBrains.ProjectModel.Model2.Assemblies.Interfaces.IAssembly> GetAllAssemblies();
        JetBrains.ProjectModel.Model2.Assemblies.Interfaces.IAssemblyFile GetFileByLocation(JetBrains.Util.FileSystemPath runtimeAssemblyLocation);
    }
    public interface IAssemblyCookie : System.IDisposable
    {
        JetBrains.ProjectModel.Model2.Assemblies.Interfaces.IAssembly Assembly { get; }
        JetBrains.ProjectModel.Model2.Assemblies.Interfaces.IAssemblyFile AssemblyFile { get; }
    }
    public interface IAssemblyFile : JetBrains.ProjectModel.IProjectModelElement, JetBrains.ProjectModel.Model2.Assemblies.Interfaces.IAssemblyFileData, JetBrains.Util.IUserDataHolder, System.IDisposable
    {
        JetBrains.ProjectModel.Model2.Assemblies.Interfaces.IAssembly Assembly { get; }
    }
    public interface IAssemblyFileData
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.Metadata.Utils.AssemblyNameInfo AssemblyName { get; }
        System.IO.FileAttributes FileAttributes { get; }
        bool IsMissing { get; }
        System.DateTime LastWriteTimeUtc { get; }
        JetBrains.Util.FileSystemPath Location { get; }
        System.Guid Mvid { get; }
    }
    public interface IAssemblyToAssemblyReference : JetBrains.ProjectModel.Model2.References.IModuleToAssemblyReference
    {
        JetBrains.ProjectModel.Model2.Assemblies.Interfaces.IAssembly OwnerModule { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ProjectModel.Model2.References.AssemblyReferenceTarget ReferenceTarget { get; }
    }
    public interface ICustomReferencedAssemblyNamesProvider
    {
        System.Collections.Generic.ICollection<JetBrains.Metadata.Utils.AssemblyNameInfo> PatchReferencedAssemblies(JetBrains.Metadata.Reader.API.IMetadataAssembly assembly, System.Collections.Generic.ICollection<JetBrains.Metadata.Utils.AssemblyNameInfo> references);
    }
    public interface IModuleReferenceResolveManager
    {
        void RefreshAssemblyReferences(JetBrains.ProjectModel.Model2.Assemblies.Interfaces.IAssembly assembly);
        void RefreshProjectOutputAssemblyReferences(JetBrains.ProjectModel.ProjectImpl project);
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.Util.FileSystemPath Resolve(JetBrains.ProjectModel.Model2.References.AssemblyReferenceTarget referenceTarget, JetBrains.ProjectModel.IModule referenceSource, JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext moduleReferenceResolveContext);
        void ResolveAndStoreAssemblyReferences(System.Collections.Generic.IEnumerable<JetBrains.ProjectModel.Model2.References.IModuleToAssemblyReference> references);
        void WipeReferencesResolve(System.Collections.Generic.IEnumerable<JetBrains.ProjectModel.Model2.References.IModuleToAssemblyReference> references);
    }
    public interface IModuleReferencesResolveStore
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ProjectModel.Model2.Assemblies.Interfaces.IAssemblyFile GetAssemblyFileResolveResult(JetBrains.ProjectModel.Model2.References.IModuleToAssemblyReference reference);
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.ICollection<JetBrains.ProjectModel.Model2.Assemblies.Interfaces.IAssemblyToAssemblyReference> GetAssemblyReferences(JetBrains.ProjectModel.Model2.Assemblies.Interfaces.IAssembly assembly, JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext moduleReferenceResolveContext);
        System.Collections.Generic.ICollection<JetBrains.ProjectModel.Model2.References.IModuleToAssemblyReference> GetAssemblyReferencesForAllContexts(JetBrains.ProjectModel.IModule module);
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.ICollection<JetBrains.ProjectModel.Model2.References.IModuleToAssemblyReference> GetReferencesToAssembly(JetBrains.ProjectModel.Model2.Assemblies.Interfaces.IAssembly assembly, JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext moduleReferenceResolveContext);
        System.Collections.Generic.ICollection<JetBrains.ProjectModel.Model2.References.IModuleToAssemblyReference> GetReferencesToAssemblyForAllContexts(JetBrains.ProjectModel.Model2.Assemblies.Interfaces.IAssembly assembly);
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ProjectModel.Model2.Assemblies.Interfaces.IAssembly GetResolveResult(JetBrains.ProjectModel.Model2.References.IModuleToAssemblyReference reference);
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ProjectModel.IModule GetResolveResult(JetBrains.ProjectModel.IProjectToModuleReference reference);
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ProjectModel.IProject GetResolveResult(JetBrains.ProjectModel.IProjectToProjectReference reference);
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ProjectModel.IProject GetResolveResult(JetBrains.ProjectModel.References.IProjectToSdkReference reference);
    }
    public class static ModuleReferencesResolveStoreEx
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Collections.Generic.ICollection<JetBrains.ProjectModel.Model2.Assemblies.Interfaces.IAssemblyToAssemblyReference> GetAssemblyReferences([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ProjectModel.Model2.Assemblies.Interfaces.IAssembly assembly, JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext moduleReferenceResolveContext) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ProjectModel.Model2.Assemblies.Interfaces.IAssembly GetModuleToAssemblyResolveResult([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ProjectModel.Model2.References.IModuleToAssemblyReference reference) { }
        public static bool IsModuleToAssemblyReferenceResolved([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ProjectModel.Model2.References.IModuleToAssemblyReference reference) { }
        public static bool IsReferences(this JetBrains.ProjectModel.IProject project, JetBrains.ProjectModel.IModule module) { }
        public static bool IsResolved([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ProjectModel.IProjectToModuleReference reference) { }
        public static JetBrains.ProjectModel.IModule ResolveResult([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ProjectModel.IProjectToModuleReference reference) { }
        public static JetBrains.ProjectModel.IProject ResolveResult([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ProjectModel.IProjectToProjectReference reference) { }
        public static JetBrains.ProjectModel.Model2.Assemblies.Interfaces.IAssemblyFile ResolveResultAssemblyFile([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ProjectModel.Model2.References.IModuleToAssemblyReference reference) { }
    }
}
namespace JetBrains.ProjectModel.model2.Assemblies.Interfaces
{
    
    public interface IAssemblyFactory
    {
        JetBrains.ProjectModel.Model2.Assemblies.Interfaces.IAssemblyCookie AddRef(JetBrains.Util.FileSystemPath assemblyPath, string holderId, JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext moduleReferenceResolveContext);
    }
}
namespace JetBrains.ProjectModel.model2.Assemblies.ProjectToAssemblyResolvers
{
    
    [JetBrains.ProjectModel.SolutionInstanceComponentAttribute()]
    public class FrameworkProjectToAssemblyReferencesResolver
    {
        public FrameworkProjectToAssemblyReferencesResolver(JetBrains.ProjectModel.PlatformManager platformManager, JetBrains.ProjectModel.Impl.AssemblyInfoCache assemblyInfoCache, JetBrains.ProjectModel.AssemblyNamesInterner interner) { }
        public System.Collections.Generic.IEnumerable<JetBrains.Util.FileSystemPath> ResolveReference(JetBrains.ProjectModel.Model2.References.AssemblyReferenceTarget referenceTarget, JetBrains.ProjectModel.IProject referenceSource) { }
    }
    public interface IProjectToAssemblyReferencesResolver
    {
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.IEnumerable<JetBrains.Util.FileSystemPath> ResolveReference(JetBrains.ProjectModel.Model2.References.AssemblyReferenceTarget referenceTarget, JetBrains.ProjectModel.IProject referenceSource);
    }
    [JetBrains.ProjectModel.SolutionInstanceComponentAttribute()]
    public class ProjectToAssemblyReferencesResolveManager
    {
        public ProjectToAssemblyReferencesResolveManager(JetBrains.DataFlow.Lifetime lifetime, JetBrains.DataFlow.IViewable<JetBrains.ProjectModel.model2.Assemblies.ProjectToAssemblyResolvers.IProjectToAssemblyReferencesResolver> resolvers, JetBrains.ProjectModel.Impl.AssemblyInfoCache assemblyInfoCache, JetBrains.ProjectModel.model2.Assemblies.ProjectToAssemblyResolvers.FrameworkProjectToAssemblyReferencesResolver frameworkResolver) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public virtual JetBrains.Util.FileSystemPath ResolveReference(JetBrains.ProjectModel.Model2.References.AssemblyReferenceTarget referenceTarget, JetBrains.ProjectModel.IProject referenceSource) { }
    }
    [JetBrains.Annotations.BaseTypeRequiredAttribute(typeof(JetBrains.ProjectModel.model2.Assemblies.ProjectToAssemblyResolvers.IProjectToAssemblyReferencesResolver))]
    [JetBrains.Annotations.MeansImplicitUseAttribute()]
    [System.AttributeUsageAttribute(System.AttributeTargets.Class | System.AttributeTargets.All, AllowMultiple=false)]
    public class ProjectToAssemblyReferencesResolverAttribute : JetBrains.ProjectModel.SolutionInstanceComponentAttribute
    {
        public ProjectToAssemblyReferencesResolverAttribute(double priority) { }
        public double Priority { get; }
    }
    public class SolutionProjectToAssemblyReferencesResolver : JetBrains.ProjectModel.model2.Assemblies.ProjectToAssemblyResolvers.IProjectToAssemblyReferencesResolver
    {
        public SolutionProjectToAssemblyReferencesResolver(JetBrains.ProjectModel.Model2.Assemblies.Impl.AssemblyCollection assemblyCollection) { }
        public System.Collections.Generic.IEnumerable<JetBrains.Util.FileSystemPath> ResolveReference(JetBrains.ProjectModel.Model2.References.AssemblyReferenceTarget referenceTarget, JetBrains.ProjectModel.IProject referenceSource) { }
    }
}
namespace JetBrains.ProjectModel.Model2.Interfaces
{
    
    public interface IReferencesCollection<TReference> : System.Collections.Generic.IEnumerable<TReference>, System.Collections.IEnumerable
        where TReference : JetBrains.ProjectModel.IProjectToModuleReference
    {
        int Count { get; }
        void AddReference(TReference reference);
        void RemoveReference(TReference reference);
        void WriteKnownProjectToModuleReferences(System.IO.BinaryWriter writer);
    }
}
namespace JetBrains.ProjectModel.Model2.References
{
    
    public class AssemblyReferenceTarget
    {
        public AssemblyReferenceTarget([JetBrains.Annotations.NotNullAttribute()] JetBrains.Metadata.Utils.AssemblyNameInfo assemblyName, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.Util.FileSystemPath hintLocation) { }
        public string AssemblyFileName { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.Metadata.Utils.AssemblyNameInfo AssemblyName { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.Util.FileSystemPath HintLocation { get; }
        public bool Equals(JetBrains.ProjectModel.Model2.References.AssemblyReferenceTarget other) { }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
        public static JetBrains.ProjectModel.Model2.References.AssemblyReferenceTarget ReadAssemblyTarget(System.IO.BinaryReader reader) { }
        public override string ToString() { }
        public void WriteReferenceTarget(System.IO.BinaryWriter writer) { }
    }
    public interface IModuleToAssemblyReference
    {
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext ModuleReferenceResolveContext { get; }
    }
}
namespace JetBrains.ProjectModel.model2.References
{
    
    public class ReferencesFolder
    {
        public ReferencesFolder([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IProject ownerProject) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ProjectModel.IProject OwnerProject { get; }
    }
}
namespace JetBrains.ProjectModel.Model2.Transaction.Actions
{
    
    public abstract class AddFolderAction : JetBrains.ProjectModel.Model2.Transaction.Actions.TransactionActionBase, JetBrains.ProjectModel.ITransactionAction
    {
        protected AddFolderAction(JetBrains.ProjectModel.IProjectFolder parentFolder, string name, JetBrains.Util.FileSystemPath folderPath, JetBrains.Application.IShellLocks locks) { }
        public JetBrains.Util.FileSystemPath AddedFolderPath { get; }
        protected JetBrains.ProjectModel.IProjectFolder AddedProjectFolder { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ProjectModel.IProjectFile> AffectedProjectFiles { get; }
        protected string Name { get; }
        protected JetBrains.ProjectModel.IProjectFolder ParentFolder { get; }
        public abstract void Commit();
        public JetBrains.ProjectModel.IProjectFolder Prepare() { }
        public void Rollback() { }
    }
    public abstract class AddReferenceAction : JetBrains.ProjectModel.Model2.Transaction.Actions.TransactionActionBase, JetBrains.ProjectModel.ITransactionAction
    {
        protected AddReferenceAction(JetBrains.ProjectModel.IProject project, JetBrains.ProjectModel.IModule moduleToReference, JetBrains.Application.IShellLocks locks, JetBrains.ProjectModel.Model2.Assemblies.Interfaces.IModuleReferenceResolveManager moduleReferenceResolveManager) { }
        protected JetBrains.ProjectModel.IProjectToModuleReference AddedReference { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ProjectModel.IProjectFile> AffectedProjectFiles { get; }
        protected JetBrains.ProjectModel.IModule ModuleToReference { get; }
        protected JetBrains.ProjectModel.IProject Project { get; }
        public abstract void Commit();
        protected virtual JetBrains.Util.FileSystemPath GuessLocalPath() { }
        public JetBrains.ProjectModel.IProjectToModuleReference Prepare() { }
        public void Rollback() { }
    }
    public abstract class AddReferenceAction2 : JetBrains.ProjectModel.Model2.Transaction.Actions.TransactionActionBase, JetBrains.ProjectModel.ITransactionAction
    {
        protected AddReferenceAction2(JetBrains.ProjectModel.IProject project, JetBrains.Util.FileSystemPath fullPathToReferencedAssembly, JetBrains.Application.IShellLocks locks, JetBrains.ProjectModel.Model2.Assemblies.Interfaces.IModuleReferenceResolveManager moduleReferenceResolveManager) { }
        protected JetBrains.ProjectModel.IProjectToModuleReference AddedReference { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ProjectModel.IProjectFile> AffectedProjectFiles { get; }
        public JetBrains.Util.FileSystemPath FullPathToReferencedAssembly { get; }
        protected JetBrains.ProjectModel.IProject Project { get; }
        public abstract void Commit();
        public JetBrains.ProjectModel.IProjectToAssemblyReference Prepare() { }
        public void Rollback() { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class AssemblyReferencesHelper
    {
        public AssemblyReferencesHelper(JetBrains.ProjectModel.ISolution solution) { }
        public static JetBrains.ProjectModel.Model2.Transaction.Actions.AssemblyReferencesHelper GetInstance(JetBrains.ProjectModel.ISolution solution) { }
        public JetBrains.Util.FileSystemPath GuessBestAssemblyToAddLocation(JetBrains.ProjectModel.IProject priorityProject, JetBrains.ProjectModel.Model2.Assemblies.Interfaces.IAssembly assemblyToReference) { }
    }
    public abstract class CopyAction : JetBrains.ProjectModel.Model2.Transaction.Actions.TransactionActionBase, JetBrains.ProjectModel.ITransactionAction
    {
        protected CopyAction(JetBrains.ProjectModel.IProjectItem projectItem, JetBrains.ProjectModel.IProjectFolder newParentItem, JetBrains.Application.IShellLocks locks) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ProjectModel.IProjectFile> AffectedProjectFiles { get; }
        public System.Collections.Generic.ICollection<JetBrains.ProjectModel.IProjectItem> CreatedItems { get; }
        protected JetBrains.ProjectModel.IProjectFolder NewParentItem { get; }
        public JetBrains.ProjectModel.IProjectItem SourceItem { get; }
        protected JetBrains.Util.FileSystemPath SourceLocation { get; }
        protected JetBrains.ProjectModel.IProject SourceProject { get; }
        public abstract void Commit();
        protected abstract void CopyDocument(JetBrains.ProjectModel.IProjectFile oldProjectFile, JetBrains.ProjectModel.IProjectFile newProjectFile);
        public JetBrains.ProjectModel.IProjectItem Prepare() { }
        public void Rollback() { }
    }
    public abstract class MoveAction : JetBrains.ProjectModel.Model2.Transaction.Actions.TransactionActionBase, JetBrains.ProjectModel.ITransactionAction
    {
        protected MoveAction(JetBrains.ProjectModel.IProjectItem projectItem, JetBrains.ProjectModel.IProjectFolder newParentItem, JetBrains.Application.IShellLocks locks) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ProjectModel.IProjectFile> AffectedProjectFiles { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ProjectModel.IProjectFile> MovedFiles { get; }
        protected JetBrains.ProjectModel.IProjectFolder NewParentItem { get; }
        protected JetBrains.ProjectModel.IProjectFolder OldParentItem { get; }
        protected JetBrains.Util.FileSystemPath OldPath { get; }
        public JetBrains.ProjectModel.IProjectItem ProjectItem { get; }
        public abstract void Commit();
        public void Prepare() { }
        public void Rollback() { }
    }
    public abstract class RemoveAction : JetBrains.ProjectModel.Model2.Transaction.Actions.TransactionActionBase, JetBrains.ProjectModel.ITransactionAction
    {
        protected RemoveAction(JetBrains.ProjectModel.IProjectItem projectItem, JetBrains.Application.IShellLocks locks) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ProjectModel.IProjectFile> AffectedProjectFiles { get; }
        public System.Collections.Generic.IList<JetBrains.ProjectModel.IProjectFile> AllRemovedFiles { get; }
        protected System.Collections.Generic.IEnumerable<JetBrains.ProjectModel.IProjectFile> DependentFiles { get; }
        protected JetBrains.Util.FileSystemPath Location { get; }
        protected JetBrains.ProjectModel.IProjectFolder ParentFolder { get; }
        protected JetBrains.ProjectModel.IProject Project { get; }
        public JetBrains.ProjectModel.IProjectItem ProjectItem { get; }
        protected JetBrains.ProjectModel.ISolution Solution { get; }
        public abstract void Commit();
        public virtual void Prepare() { }
        public void Rollback() { }
    }
    public abstract class RemoveReferenceAction : JetBrains.ProjectModel.Model2.Transaction.Actions.TransactionActionBase, JetBrains.ProjectModel.ITransactionAction
    {
        protected RemoveReferenceAction(JetBrains.ProjectModel.IProjectToModuleReference referenceToRemove, JetBrains.Application.IShellLocks locks, JetBrains.ProjectModel.Model2.Assemblies.Interfaces.IModuleReferenceResolveManager moduleReferenceResolveManager) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ProjectModel.IProjectFile> AffectedProjectFiles { get; }
        protected JetBrains.ProjectModel.IProject Project { get; }
        protected JetBrains.ProjectModel.IProjectToModuleReference ReferenceToRemove { get; }
        public abstract void Commit();
        public void Prepare() { }
        public void Rollback() { }
    }
    public abstract class RenameAction : JetBrains.ProjectModel.Model2.Transaction.Actions.TransactionActionBase, JetBrains.ProjectModel.ITransactionAction
    {
        protected readonly string myNewName;
        protected JetBrains.Util.FileSystemPath myOldLocation;
        protected string myOldName;
        protected readonly JetBrains.ProjectModel.IProjectItem myProjectItem;
        protected RenameAction(JetBrains.ProjectModel.IProjectItem projectItem, string newName, JetBrains.Application.IShellLocks locks) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ProjectModel.IProjectFile> AffectedProjectFiles { get; }
        protected string NewName { get; }
        protected JetBrains.Util.FileSystemPath OldLocation { get; }
        protected string OldName { get; }
        protected JetBrains.ProjectModel.IProjectItem ProjectItem { get; }
        public abstract void Commit();
        public virtual void Prepare() { }
        public virtual void Rollback() { }
    }
    public abstract class TransactionActionBase
    {
        protected TransactionActionBase(JetBrains.Application.IShellLocks locks) { }
        public JetBrains.Application.IShellLocks Locks { get; }
        protected JetBrains.ProjectModel.IProjectFile GetAffectedProject(JetBrains.ProjectModel.IProjectItem item) { }
        protected JetBrains.ProjectModel.IProjectFile GetAffectedSolution(JetBrains.ProjectModel.IProjectItem item) { }
    }
}
namespace JetBrains.ProjectModel.Model2.Transaction
{
    
    public class EnsureWritableCollection : JetBrains.ProjectModel.Model2.Transaction.IEnsureWritableCollection
    {
        public System.Collections.Generic.List<JetBrains.Util.Pair<JetBrains.ProjectModel.IProjectFile, JetBrains.Util.FileSystemPath>> Files { get; }
        public JetBrains.ProjectModel.ISolution Solution { get; }
        public JetBrains.ProjectModel.Model2.Transaction.IEnsureWritableCollection AddFile(JetBrains.ProjectModel.IProjectFile projectFile) { }
        public JetBrains.ProjectModel.Model2.Transaction.IEnsureWritableCollection AddFiles(params JetBrains.ProjectModel.IProjectFile[] projectFiles) { }
        public JetBrains.ProjectModel.Model2.Transaction.IEnsureWritableCollection AddFiles(System.Collections.Generic.IEnumerable<JetBrains.ProjectModel.IProjectFile> projectFiles) { }
        public JetBrains.ProjectModel.Model2.Transaction.IEnsureWritableCollection AddPath(JetBrains.Util.FileSystemPath path) { }
        public JetBrains.ProjectModel.Model2.Transaction.IEnsureWritableCollection AddPaths(params JetBrains.Util.FileSystemPath[] paths) { }
        public JetBrains.ProjectModel.Model2.Transaction.IEnsureWritableCollection AddPaths(System.Collections.Generic.IEnumerable<JetBrains.Util.FileSystemPath> paths) { }
        public JetBrains.ProjectModel.Model2.Transaction.IEnsureWritableCollection AddProject(JetBrains.ProjectModel.IProject project) { }
        public JetBrains.ProjectModel.Model2.Transaction.IEnsureWritableCollection AddSolution(JetBrains.ProjectModel.ISolution solution) { }
        public JetBrains.Util.ModificationCookie CreateCookie(System.Collections.Generic.ICollection<JetBrains.ProjectModel.IProjectFile> doNotOpenOnBefore = null) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute(JetBrains.Application.Components.ProgramConfigurations.NONE | JetBrains.Application.Components.ProgramConfigurations.STANDALONE | JetBrains.Application.Components.ProgramConfigurations.TEST | JetBrains.Application.Components.ProgramConfigurations.COMMAND_LINE | JetBrains.Application.Components.ProgramConfigurations.ALL)]
    public class EnsureWritableHandler : JetBrains.ProjectModel.Model2.Transaction.IEnsureWritableHandler
    {
        public EnsureWritableHandler(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.IShellLocks locks) { }
        protected JetBrains.Application.IShellLocks Locks { get; }
        public JetBrains.ProjectModel.ISolution Solution { get; }
        public event JetBrains.ProjectModel.BeforeMadeWritableEventHandler BeforeMadeWritable;
        public event JetBrains.ProjectModel.MakingWritableEventHandler MakingWritable;
        public event JetBrains.ProjectModel.ModificationFinishedEventHandler ModificationFinished;
        public JetBrains.ProjectModel.Model2.Transaction.IEnsureWritableCollection CreateCollection() { }
        public bool IsInModification(JetBrains.ProjectModel.IProjectFile projectFile) { }
        public bool IsWritable(JetBrains.ProjectModel.ISolution solution) { }
        public bool IsWritable(JetBrains.ProjectModel.IProject project) { }
        public bool IsWritable(JetBrains.ProjectModel.IProjectFile projectFile) { }
        protected virtual void OnBeforeMadeWritable(JetBrains.ProjectModel.BeforeMadeWritableEventArgs args) { }
        protected virtual void OnMakingWritable(JetBrains.ProjectModel.MakingWritableEventArgs args) { }
        protected virtual JetBrains.ProjectModel.Model2.Transaction.EnsureWritableHandler.QueryIsWritableResult QueryIsWritable([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IProjectFile projectFile) { }
        public enum QueryIsWritableResult
        {
            READONLY = 0,
            WRITABLE = 1,
            MODIFIED = 2,
        }
    }
    public interface IEnsureWritableCollection
    {
        JetBrains.ProjectModel.Model2.Transaction.IEnsureWritableCollection AddFile(JetBrains.ProjectModel.IProjectFile projectFile);
        JetBrains.ProjectModel.Model2.Transaction.IEnsureWritableCollection AddFiles(params JetBrains.ProjectModel.IProjectFile[] projectFiles);
        JetBrains.ProjectModel.Model2.Transaction.IEnsureWritableCollection AddFiles(System.Collections.Generic.IEnumerable<JetBrains.ProjectModel.IProjectFile> projectFiles);
        JetBrains.ProjectModel.Model2.Transaction.IEnsureWritableCollection AddPath(JetBrains.Util.FileSystemPath path);
        JetBrains.ProjectModel.Model2.Transaction.IEnsureWritableCollection AddPaths(params JetBrains.Util.FileSystemPath[] paths);
        JetBrains.ProjectModel.Model2.Transaction.IEnsureWritableCollection AddPaths(System.Collections.Generic.IEnumerable<JetBrains.Util.FileSystemPath> paths);
        JetBrains.ProjectModel.Model2.Transaction.IEnsureWritableCollection AddProject(JetBrains.ProjectModel.IProject project);
        JetBrains.ProjectModel.Model2.Transaction.IEnsureWritableCollection AddSolution(JetBrains.ProjectModel.ISolution solution);
        JetBrains.Util.ModificationCookie CreateCookie(System.Collections.Generic.ICollection<JetBrains.ProjectModel.IProjectFile> doNotOpenBefore = null);
    }
    public interface IEnsureWritableHandler
    {
        public event JetBrains.ProjectModel.BeforeMadeWritableEventHandler BeforeMadeWritable;
        public event JetBrains.ProjectModel.MakingWritableEventHandler MakingWritable;
        public event JetBrains.ProjectModel.ModificationFinishedEventHandler ModificationFinished;
        JetBrains.ProjectModel.Model2.Transaction.IEnsureWritableCollection CreateCollection();
        bool IsInModification(JetBrains.ProjectModel.IProjectFile projectFile);
        bool IsWritable([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.ISolution solution);
        bool IsWritable([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IProject project);
        bool IsWritable([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IProjectFile projectFile);
    }
}
namespace JetBrains.ProjectModel.Model2.Web
{
    
    public class ProjectFilesTracker : JetBrains.ProjectModel.RecursiveProjectModelChangeDeltaVisitor
    {
        public ProjectFilesTracker([JetBrains.Annotations.CanBeNullAttribute()] System.Action<JetBrains.ProjectModel.IProjectFile, JetBrains.Util.FileSystemPath> deletedDelegate, [JetBrains.Annotations.CanBeNullAttribute()] System.Action<JetBrains.ProjectModel.IProjectFile> createdDelegate, [JetBrains.Annotations.CanBeNullAttribute()] System.Action<JetBrains.ProjectModel.IProjectFile> externalChangeDelegate, [JetBrains.Annotations.CanBeNullAttribute()] System.Action<JetBrains.ProjectModel.IProjectFile> propertiesChangeDelegate) { }
        public static void ProcessChange(JetBrains.ProjectModel.ProjectModelChange projectModelChange, System.Action<JetBrains.ProjectModel.IProjectFile, JetBrains.Util.FileSystemPath> deleteDelegate, System.Action<JetBrains.ProjectModel.IProjectFile> createDelegate, System.Action<JetBrains.ProjectModel.IProjectFile> externalChangeDelegate, System.Action<JetBrains.ProjectModel.IProjectFile> propertiesChangeDelegate) { }
        public override void VisitItemDelta(JetBrains.ProjectModel.ProjectItemChange change) { }
    }
}
namespace JetBrains.ProjectModel.MSBuild
{
    
    public class MSBuildProjectFileUpdater : JetBrains.ProjectModel.IProjectFileUpdater
    {
        public MSBuildProjectFileUpdater(System.Xml.XmlDocument xmlDocument) { }
        public void OnItemAdded(JetBrains.ProjectModel.ProjectItemChange addChange) { }
        public void OnItemMoved(JetBrains.ProjectModel.ProjectItemChange moveChange) { }
        public void OnItemRemoved(JetBrains.ProjectModel.ProjectItemChange changeDelta) { }
        public void OnPropertyChanged(JetBrains.ProjectModel.ProjectItemChange itemChange) { }
        public void OnReferenceAdded(JetBrains.ProjectModel.ProjectReferenceChange projectRefChange) { }
        public void OnReferenceRemoved(JetBrains.ProjectModel.ProjectReferenceChange modRefChange) { }
    }
    public class static MSBuildProjectUtil
    {
        public const string AfterTargetsAttr = "AfterTargets";
        public const string AllowUnsafeBlocksProperty = "AllowUnsafeBlocks";
        public const string APPDESIGNER_ELEMENT = "AppDesigner";
        public const string APPLICATION_VERSION_ELEMENT = "ApplicationVersion";
        public const string ApplicationDefinitionElement = "ApplicationDefinition";
        public const string ApplicationVersionElement = "ApplicationVersion";
        public const string APPX_MANIFEST_ELEMENT = "AppxManifest";
        public const string AssemblyFileAttr = "AssemblyFile";
        public const string AssemblyNameAttr = "AssemblyName";
        public const string AssemblyNameProperty = "AssemblyName";
        public const string BASE_ADDRESS_ELEMENT = "BaseAddress";
        public const string BaseAddressProperty = "BaseAddress";
        public const string BeforeTargetsAttr = "BeforeTargets";
        public const string BOOTSTRAPPER_FILE = "BootstrapperFile";
        public const string CHECK_OVERFLOW_ELEMENT = "CheckForOverflowUnderflow";
        public const string CheckForOverflowUnderflowProperty = "CheckForOverflowUnderflow";
        public const string CHOOSE_ELEMENT = "Choose";
        public const string ChooseElement = "Choose";
        public const string COM_INTEROP_ELEMENT = "RegisterForComInterop";
        public const string CompileElement = "Compile";
        public const string ConditionAttr = "Condition";
        public const string CONFIG_OVERRIDE_FILE_ELEMENT = "ConfigurationOverrideFile";
        public const string ConfigurationProperty = "Configuration";
        public const string CONTENT_ELEMENT = "Content";
        public const string CONTINUE_ON_ERROR_ATTR = "ContinueOnError";
        public const string ContinueOnErrorAttr = "ContinueOnError";
        public const string DebugSymbolsProperty = "DebugSymbols";
        public const string DebugTypeProperty = "DebugType";
        public const string DEFAULT_TARGETS_ATTR = "DefaultTargets";
        public const string DEFAULT_TARGETS_ELEMENT = "DefaultTargets";
        public const string DefaultTargetsAttr = "DefaultTargets";
        public const string DefineConstants = "DefineConstants";
        public const string DefineDebugProperty = "DefineDebug";
        public const string DefineTraceProperty = "DefineTrace";
        public const string DEPENDENT_UPON_ELEMENT = "DependentUpon";
        public const string DependentUponElement = "DependentUpon";
        public const string DEPENDS_ON_TARGETS_ATTR = "DependsOnTargets";
        public const string DependsOnTargetsAttr = "DependsOnTargets";
        public const string DOC_FILE_ELEMENT = "DocumentationFile";
        public const string DocumentationFileProperty = "DocumentationFile";
        public const string EmbeddedResourceElement = "EmbeddedResource";
        public const string ErrorReportProperty = "ErrorReport";
        public const string EVALUATE_ATTR = "Evaluate";
        public const string EvaluateAttr = "Evaluate";
        public const string EXCLUDE_PATTERN_ATTR = "ExcludePattern";
        public const string ExcludeAttr = "Exclude";
        public const string EXECUTE_TARGETS_ATTR = "ExecuteTargets";
        public const string ExecuteTargetsAttr = "ExecuteTargets";
        public const string FileAlignmentProperty = "FileAlignment";
        public const string FOLDER_ELEMENT = "Folder";
        public const string GENERATE_SERIALIZATION_ASSEMBLIES = "GenerateSerializationAssemblies";
        public const string GenerateSerializationAssembliesProperty = "GenerateSerializationAssemblies";
        public const string GeneratorElement = "Generator";
        public const string HintPathElement = "HintPath";
        public const string IMPORT_GROUP_ELEMENT = "ImportGroup";
        public const string ImportElement = "Import";
        public const string ImportGroupElement = "ImportGroup";
        public const string INCLUDE_PATTERN_ATTR = "IncludePattern";
        public const string IncludeAttr = "Include";
        public const string INITIAL_TARGETS_ATTR = "InitialTargets";
        public const string InitialTargetsAttr = "InitialTargets";
        public const string INPUTS_ATTR = "Inputs";
        public const string InputsAttr = "Inputs";
        public const string IntermediateOutputPathProperty = "IntermediateOutputPath";
        public const string ITEM_DEFINITION_GROUP_ELEMENT = "ItemDefinitionGroup";
        public const string ITEM_NAME_ATTR = "ItemName";
        public const string ItemDefinitionGroupElement = "ItemDefinitionGroup";
        public const string ItemGroupElement = "ItemGroup";
        public const string ItemNameAttr = "ItemName";
        public const string KEEP_DUPLICATE_OUTPUTS_ATTR = "KeepDuplicateOutputs";
        public const string KeepDuplicateOutputsAttr = "KeepDuplicateOutputs";
        public const string KeepDuplicatesAttr = "KeepDuplicates";
        public const string KeepMetadataAttr = "KeepMetadata";
        public const string LanguageProperty = "Language";
        public const string LINK_ELEMENT = "Link";
        public const string MSBUILD_VERSION_ATTR = "MSBuildVersion";
        public const string MyTypeProperty = "MyType";
        public const string NAME_ATTR = "Name";
        public const string NameAttr = "Name";
        public const string NameElement = "Name";
        public const string NoneElement = "None";
        public const string NOSTD_LIB_ELEMENT = "NoStdLib";
        public const string NoStdLibProperty = "NoStdLib";
        public const string NOWARN_ELEMENT = "NoWarn";
        public const string NoWarnProperty = "NoWarn";
        public const string ON_ERROR_ELEMENT = "OnError";
        public const string OnErrorElement = "OnError";
        public const string OptimizeProperty = "Optimize";
        public const string OptionCompareProperty = "OptionCompare";
        public const string OptionExplicitProperty = "OptionExplicit";
        public const string OptionInferProperty = "OptionInfer";
        public const string OptionStrictProperty = "OptionStrinct";
        public const string OTHERWISE_ELEMENT = "Otherwise";
        public const string OtherwiseElement = "Otherwise";
        public const string OUTPUT_ATTR = "Output";
        public const string OUTPUT_ELEMENT = "Output";
        public const string OutputAttr = "Output";
        public const string OutputElement = "Output";
        public const string OutputPathProperty = "OutputPath";
        public const string OUTPUTS_ATTR = "Outputs";
        public const string OutputsAttr = "Outputs";
        public const string OutputTypeExe = "Exe";
        public const string OutputTypeLibrary = "Library";
        public const string OutputTypeProperty = "OutputType";
        public const string OutputTypeWinExe = "WinExe";
        public const string OutputTypeWinMd = "WinMD";
        public const string PageElement = "Page";
        public const string PARAMETER_GROUP_ELEMENT = "ParameterGroup";
        public const string PARAMETER_TYPE_ATTR = "ParameterType";
        public const string ParameterGroupElement = "ParameterGroup";
        public const string ParameterTypeAttr = "ParameterType";
        public const string PLATFORM_FAMILY_NAME = "PlatformFamilyName";
        public const string PlatformProperty = "Platform";
        public const string PlatformTargetProperty = "PlatformTarget";
        public const string PREFIX = "pr";
        public const string PRIVATE_ELEMENT = "Private";
        public const string ProductVersionElement = "ProductVersion";
        public const string PROJECT_EXTENSIONS_ELEMENT = "ProjectExtensions";
        public const string PROJECT_REFERENCE_PROJECT_GUID_ELEMENT = "Project";
        public const string ProjectAttr = "Project";
        public const string ProjectExtensionsElement = "ProjectExtensions";
        public const string ProjectGuidProperty = "ProjectGuid";
        public const string ProjectReferenceItem = "ProjectReference";
        public const string ProjectReferenceProperty = "ProjectReference";
        public const string ProjectRootElement = "Project";
        public const string ProjectTypeGuidsProperty = "ProjectTypeGuids";
        public const string PROPERTY_NAME_ATTR = "PropertyName";
        public const string PropertyGroupElement = "PropertyGroup";
        public const string PropertyNameAttr = "PropertyName";
        public const string ReferenceElement = "Reference";
        public const string ReferencePathItem = "ReferencePath";
        public const string RegisterForComInteropProperty = "RegisterForComInterop";
        public const string REMOVE_ATTR = "Remove";
        public const string REMOVE_INTEGER_ELEMENT = "RemoveIntegerChecks";
        public const string RemoveAttr = "Remove";
        public const string RemoveMetadataAttr = "RemoveMetadata";
        public const string REQUIRED_ATTR = "Required";
        public const string RequiredAttr = "Required";
        public const string RESHARPER_EXTENSIONS = "ReSharper";
        public const string ResourceElement = "Resource";
        public const string RETURNS_ATTR = "Returns";
        public const string ReturnsAttr = "Returns";
        public const string RootNamespaceProperty = "RootNamespace";
        public const string SchemaVersionElement = "SchemaVersion";
        public const string SDKReferenceElement = "SDKReference";
        public const string SPECIFIC_VERSION_ATTR = "SpecificVersion";
        public const string SplashScreenElement = "SplashScreen";
        public const string SUBTYPE_CODE = "Code";
        public const string SUBTYPE_COMPONENT = "Component";
        public const string SUBTYPE_DESIGNER = "Designer";
        public const string SUBTYPE_ELEMENT = "SubType";
        public const string SUBTYPE_FORM = "Form";
        public const string SUBTYPE_USERCONTROL = "UserControl";
        public const string TARGET_ELEMENT = "Target";
        public const string TargetElement = "Target";
        public const string TargetFrameworkIdentifierProperty = "TargetFrameworkIdentifier";
        public const string TargetFrameworkProfileProperty = "TargetFrameworkProfile";
        public const string TargetFrameworkVersionProperty = "TargetFrameworkVersion";
        public const string TASK_BODY_ELEMENT = "TaskBody";
        public const string TASK_FACTORY_ATTR = "TaskFactory";
        public const string TASK_NAME_ATTR = "TaskName";
        public const string TASK_PARAMETER_ATTR = "TaskParameter";
        public const string TaskBodyElement = "TaskBody";
        public const string TaskFactoryAttr = "TaskFactory";
        public const string TaskNameAttr = "TaskName";
        public const string TaskParameterAttr = "TaskParameter";
        public const string TOOLS_VERSION_ATTR = "ToolsVersion";
        public const string ToolsVersionAttr = "ToolsVersion";
        public const string TREAT_WARNINGS_AS_ERRORS_ELEMENT = "TreatWarningsAsErrors";
        public const string TreatAsLocalPropertyAttr = "TreatAsLocalProperty";
        public const string TreatWarningsAsErrorsProperty = "TreatWarningsAsErrors";
        public const string UNIT_TEST = "Unittest";
        public const string USING_TASK_ELEMENT = "UsingTask";
        public const string UsingTaskElement = "UsingTask";
        public const string WarningLevelProperty = "WarningLevel";
        public const string WarningsAsErrorsProperty = "WarningsAsErrors";
        public const string WHEN_ELEMENT = "When";
        public const string WhenElement = "When";
        public const string XAML_ACROPOLIS_COMPONENT = "AcropolisComponent";
        public const string XAML_APP_DEF = "XamlAppDef";
        public const string XAML_APP_DEF_2 = "XamlAppdef";
        public const string XAML_APP_DEFINITION = "ApplicationDefinition";
        public const string XAML_DESIGN_DATA = "DesignData";
        public const string XAML_DESIGN_DATA_WITH_TYPES = "DesignDataWithDesignTimeCreatableTypes";
        public const string XAML_PAGE = "Page";
        public const string XAML_SILVERLIGHT_PAGE = "SilverlightPage";
        public const string XMLNS_URI = "http://schemas.microsoft.com/developer/msbuild/2003";
        public const string XmlnsAttr = "xmlns";
        public const string XmlnsUri = "http://schemas.microsoft.com/developer/msbuild/2003";
        public static JetBrains.ProjectModel.BuildAction GetBuildActionByItemElement(string name) { }
        public static JetBrains.ProjectModel.Properties.DebugType GetDebugType(string type) { }
        public static string GetGuidRepr(System.Guid guid) { }
        public static JetBrains.ProjectModel.ItemSubType GetItemSubType(string itemSubType) { }
        public static string GetItemSubType(JetBrains.ProjectModel.ItemSubType subType) { }
        public static string GetMSBuildItemType(JetBrains.ProjectModel.IProjectFile file) { }
        public static JetBrains.ProjectModel.ProjectOutputType GetOutputType(string text) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Collections.Generic.ICollection<System.Guid> GetProjectTypeGuids([JetBrains.Annotations.CanBeNullAttribute()] string guidsString) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static string GetProjectTypeGuidsString(JetBrains.Util.FileSystemPath projectFileLocation) { }
        public static string Qualify(string elementName) { }
    }
    public class ProjectImportHelper
    {
        public ProjectImportHelper(JetBrains.ProjectModel.Impl.SolutionElement solutionElement, JetBrains.Application.IShellLocks locks, JetBrains.ProjectModel.PlatformID defaultPlatformId, JetBrains.ProjectModel.SolutionFileParser.SlnFileProject project, System.Xml.XmlDocument xmlDocument, JetBrains.ProjectModel.Properties.ProjectFilePropertiesFactory projectFilePropertiesFactory) { }
        public void AddItemsFromFileSystem(JetBrains.ProjectModel.ProjectFolderImpl folder, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.FileSetSet fileSetSet) { }
        public void BuildFromFileSystemNoEvents(JetBrains.ProjectModel.ProjectFolderImpl projectFolderImpl, JetBrains.ProjectModel.FileSetSet fileSetSet) { }
        public static JetBrains.ProjectModel.Properties.ProjectLanguage GetLanguageTypeByProjectAttr(string project) { }
        public JetBrains.ProjectModel.IProject Import() { }
    }
}
namespace JetBrains.ProjectModel.Persistence
{
    
    public class SolutionPersistenceOperations
    {
        public SolutionPersistenceOperations(JetBrains.ProjectModel.Caches.ISolutionCachesConfiguration configuration, JetBrains.Util.FileSystemPath solutionFilePath, string solutionName) { }
        public bool Load(JetBrains.ProjectModel.Impl.SolutionElement solution) { }
        public bool ReadStream(System.IO.BinaryReader reader, JetBrains.ProjectModel.Impl.SolutionElement solution) { }
        public void Save(JetBrains.ProjectModel.SolutionInstance solutionInstance) { }
        public void WriteStream(System.IO.BinaryWriter writer, JetBrains.ProjectModel.Impl.SolutionElement solutionElement) { }
    }
}
namespace JetBrains.ProjectModel.Properties
{
    
    public class BuildSettingsBase : JetBrains.ProjectModel.Properties.IBuildSettings
    {
        public virtual void Dump(System.IO.TextWriter to, int indent) { }
        protected void OnPropertyChange() { }
        public virtual void ReadBuildSettings(System.IO.BinaryReader reader) { }
        public void SetProject(JetBrains.ProjectModel.IProject project) { }
        public virtual bool UpdateFrom(JetBrains.ProjectModel.Properties.IBuildSettings settings) { }
        public virtual void WriteBuildSettings(System.IO.BinaryWriter writer) { }
    }
    public enum DebugType
    {
        NONE = 0,
        PDB_ONLY = 1,
        FULL = 2,
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class DefaultNamespaceFolderProvider : JetBrains.Application.Settings.IHaveDefaultSettingsStream { }
    public class EmptyProjectFileProperties : JetBrains.ProjectModel.Properties.ProjectFilePropertiesBase
    {
        public override bool UpdatePropertiesFrom(JetBrains.ProjectModel.Properties.IProjectFileProperties properties) { }
    }
    public class static FilePropertiesHelper
    {
        public static void SetDependsUponFile([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ProjectModel.IProjectFile projectItem, string dependsUponItemName, bool raiseNotification = True) { }
    }
    public interface IBuildSettings
    {
        void Dump(System.IO.TextWriter to, int indent);
        void ReadBuildSettings(System.IO.BinaryReader reader);
        void SetProject(JetBrains.ProjectModel.IProject project);
        bool UpdateFrom(JetBrains.ProjectModel.Properties.IBuildSettings settings);
        void WriteBuildSettings(System.IO.BinaryWriter writer);
    }
    public interface IProjectConfiguration : JetBrains.Util.IUserDataHolder
    {
        string Name { get; set; }
        string RelativeOutputDirectory { get; set; }
        void Dump(System.IO.TextWriter to, int indent);
        void ReadConfiguration(System.IO.BinaryReader reader);
        void SetProject(JetBrains.ProjectModel.IProject project);
        bool UpdateFrom(JetBrains.ProjectModel.Properties.IProjectConfiguration configuration);
        void WriteConfiguration(System.IO.BinaryWriter writer);
    }
    public interface IProjectFileProperties
    {
        JetBrains.ProjectModel.BuildAction BuildAction { get; set; }
        bool IsHidden { get; set; }
        void Dump(System.IO.TextWriter to);
        void ReadFileProperties(System.IO.BinaryReader reader);
        void SetProjectFile(JetBrains.ProjectModel.IProjectFile projectFile);
        bool UpdatePropertiesFrom(JetBrains.ProjectModel.Properties.IProjectFileProperties properties);
        void WriteProjectFileProperties(System.IO.BinaryWriter writer);
    }
    public interface IProjectFilePropertiesProvider
    {
        JetBrains.ProjectModel.Properties.IProjectFileProperties CreateProjectFileProperties();
        bool IsApplicable(JetBrains.ProjectModel.Properties.IProjectProperties projectProperties);
    }
    public interface IProjectFlavor
    {
        string FlavorName { get; }
        System.Guid Guid { get; }
    }
    public interface IProjectProperties
    {
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ProjectModel.Properties.IProjectConfiguration ActiveConfiguration { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ProjectModel.Properties.IBuildSettings BuildSettings { get; }
        JetBrains.ProjectModel.Properties.ProjectLanguage DefaultLanguage { get; }
        System.Guid OwnerFactoryGuid { get; }
        JetBrains.ProjectModel.PlatformID PlatformId { get; }
        JetBrains.ProjectModel.ProjectKind ProjectKind { get; }
        System.Collections.Generic.IEnumerable<System.Guid> ProjectTypeGuids { get; }
        void Dump(System.IO.TextWriter to, int indent = 0);
        bool UpdateFrom(JetBrains.ProjectModel.Properties.IProjectProperties properties);
        void WriteProjectProperties(System.IO.BinaryWriter writer);
    }
    public interface IProjectPropertiesFactory
    {
        System.Guid FactoryGuid { get; }
        JetBrains.ProjectModel.Properties.IProjectProperties CreateProjectProperties(System.Guid projectTypeGuid, System.Collections.Generic.ICollection<System.Guid> projectTypeGuids, JetBrains.ProjectModel.PlatformID platformIdVs, JetBrains.Metadata.Utils.TargetPlatformData targetPlatfromData);
        bool IsApplicable(System.Guid projectTypeGuid, System.Collections.Generic.ICollection<System.Guid> projectTypeGuids, JetBrains.ProjectModel.PlatformID platformId);
        JetBrains.ProjectModel.Properties.IProjectProperties Read(System.IO.BinaryReader reader, JetBrains.ProjectModel.Impl.ProjectSerializationIndex index);
    }
    public class IsDesignTimeBuildInputProperty { }
    public interface ISdkConsumerProperties : JetBrains.ProjectModel.Properties.IProjectProperties
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.Metadata.Utils.TargetPlatformData TargetPlatformData { get; }
    }
    public class static NamespaceFolderProperty
    {
        public static string CalculateExpectedNamespace([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ProjectModel.IProjectItem item) { }
        public static bool GetNamespaceFolderProperty(this JetBrains.ProjectModel.IProjectFolder projectFolder) { }
        public static void SetNamespaceFolderProperty([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ProjectModel.IProjectFolder projectFolder, bool providesNamespace) { }
    }
    public class static ProjectConfigurationEx
    {
        public static void SetRelativeOutputDirectory([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ProjectModel.Properties.IProjectConfiguration configuration, [JetBrains.Annotations.CanBeNullAttribute()] string outputDirectory, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.FileSystemPath projectDirectory) { }
    }
    public class ProjectFileProperties : JetBrains.ProjectModel.Properties.ProjectFilePropertiesBase
    {
        public ProjectFileProperties() { }
        [JetBrains.Annotations.NotNullAttribute()]
        [JetBrains.Annotations.UsedImplicitlyAttribute()]
        public string CustomTool { get; set; }
        [JetBrains.Annotations.NotNullAttribute()]
        [JetBrains.Annotations.UsedImplicitlyAttribute()]
        public string CustomToolNamespace { get; set; }
        [JetBrains.Annotations.NotNullAttribute()]
        [JetBrains.Annotations.UsedImplicitlyAttribute()]
        public string CustomToolOutput { get; set; }
        [JetBrains.Annotations.NotNullAttribute()]
        [JetBrains.Annotations.UsedImplicitlyAttribute()]
        public string DependsUponName { get; set; }
        [JetBrains.Annotations.UsedImplicitlyAttribute()]
        public bool IsCustomToolOutput { get; set; }
        [JetBrains.Annotations.UsedImplicitlyAttribute()]
        public bool IsDesignTimeBuildInput { get; set; }
        [JetBrains.Annotations.UsedImplicitlyAttribute()]
        public JetBrains.ProjectModel.ItemSubType SubType { get; set; }
        public override void Dump(System.IO.TextWriter to) { }
        public override void ReadFileProperties(System.IO.BinaryReader reader) { }
        public override bool UpdatePropertiesFrom(JetBrains.ProjectModel.Properties.IProjectFileProperties properties) { }
        public override void WriteProjectFileProperties(System.IO.BinaryWriter writer) { }
    }
    public class ProjectFilePropertiesBase : JetBrains.ProjectModel.Properties.IProjectFileProperties
    {
        protected JetBrains.ProjectModel.IProjectFile myProjectFile;
        public ProjectFilePropertiesBase() { }
        public JetBrains.ProjectModel.BuildAction BuildAction { get; set; }
        public bool IsHidden { get; set; }
        public virtual void Dump(System.IO.TextWriter to) { }
        protected void OnPropertyChange(string name, object oldValue, object newValue) { }
        public virtual void ReadFileProperties(System.IO.BinaryReader reader) { }
        public void SetProjectFile(JetBrains.ProjectModel.IProjectFile projectFile) { }
        public virtual bool UpdatePropertiesFrom(JetBrains.ProjectModel.Properties.IProjectFileProperties properties) { }
        protected System.IDisposable UsingWriteLock() { }
        public virtual void WriteProjectFileProperties(System.IO.BinaryWriter writer) { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class ProjectFilePropertiesFactory
    {
        public ProjectFilePropertiesFactory(JetBrains.ProjectModel.Properties.ProjectModelExtensionsContainer container) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ProjectModel.Properties.IProjectFilePropertiesProvider CreateFilePropertiesProvider(JetBrains.ProjectModel.Properties.IProjectProperties projectProperties) { }
        public JetBrains.ProjectModel.Properties.IProjectFileProperties CreateProjectFileProperties(JetBrains.ProjectModel.Properties.IProjectProperties projectProperties) { }
    }
    [JetBrains.ProjectModel.Properties.ProjectModelExtensionAttribute()]
    public class ProjectFilePropertiesProvider : JetBrains.ProjectModel.Properties.ProjectFilePropertiesProviderBase
    {
        public override JetBrains.ProjectModel.Properties.IProjectFileProperties CreateProjectFileProperties() { }
        public override bool IsApplicable(JetBrains.ProjectModel.Properties.IProjectProperties projectProperties) { }
    }
    [JetBrains.ProjectModel.Properties.ProjectModelExtensionAttribute()]
    public class ProjectFilePropertiesProviderBase : JetBrains.ProjectModel.Properties.IProjectFilePropertiesProvider
    {
        public virtual JetBrains.ProjectModel.Properties.IProjectFileProperties CreateProjectFileProperties() { }
        public virtual bool IsApplicable(JetBrains.ProjectModel.Properties.IProjectProperties projectProperties) { }
    }
    public class ProjectFlavorAttribute : JetBrains.Application.ShellComponentAttribute { }
    [JetBrains.Application.ShellComponentAttribute()]
    public class ProjectFlavoursFactory
    {
        public ProjectFlavoursFactory(JetBrains.DataFlow.Lifetime lifetime, JetBrains.DataFlow.IViewable<JetBrains.ProjectModel.Properties.IProjectFlavor> flavourFactories) { }
        public JetBrains.ProjectModel.Properties.IProjectFlavor GetFlavourbyId(System.Guid guid) { }
    }
    public class ProjectLanguage : JetBrains.Util.EnumPattern
    {
        public static readonly JetBrains.ProjectModel.Properties.ProjectLanguage CSHARP;
        public static readonly JetBrains.ProjectModel.Properties.ProjectLanguage JAVASCRIPT;
        public static readonly JetBrains.ProjectModel.Properties.ProjectLanguage UNKNOWN;
        public static readonly JetBrains.ProjectModel.Properties.ProjectLanguage VBASIC;
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ProjectModel.ProjectFileType DefaultProjectFileType { get; }
        public string PresentableName { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.ProjectModel.Properties.ProjectLanguage ParsePresentableName(string presentableName) { }
    }
    [JetBrains.Annotations.MeansImplicitUseAttribute()]
    [System.AttributeUsageAttribute(System.AttributeTargets.Class | System.AttributeTargets.All)]
    public class ProjectModelExtensionAttribute : JetBrains.Application.Parts.PartAttribute { }
    [JetBrains.Application.ShellComponentAttribute()]
    public class ProjectModelExtensionsContainer
    {
        public ProjectModelExtensionsContainer(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.Parts.IPartsCatalogueSet catalogueSet, JetBrains.Application.Components.IComponentContainer parentContainer) { }
        public System.Collections.Generic.IEnumerable<T> GetParts<T>(System.Func<T, bool> isApplicable)
            where T :  class { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class ProjectPropertiesFactory
    {
        public ProjectPropertiesFactory(JetBrains.ProjectModel.Properties.ProjectModelExtensionsContainer container, JetBrains.ProjectModel.Properties.ProjectFlavoursFactory flavoursFactory) { }
        public JetBrains.ProjectModel.Properties.ProjectFlavoursFactory FlavoursFactory { get; }
        public JetBrains.ProjectModel.Properties.IProjectProperties CreateProjectProperties(System.Guid projectTypeGuid, System.Collections.Generic.ICollection<System.Guid> projectTypeGuids, JetBrains.ProjectModel.PlatformID platformId, JetBrains.Metadata.Utils.TargetPlatformData targetPlatformData = null) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ProjectModel.Properties.IProjectPropertiesFactory> GetAllFactories() { }
    }
    public enum RunPostBuildEventType : byte
    {
        ALWAYS = 0,
        ON_SUCCESSFUL_BUILD = 1,
        ON_OUTPUT_UPDATED = 2,
    }
    public class SdkFileProjectFileProperties : JetBrains.ProjectModel.Properties.ProjectFilePropertiesBase
    {
        public override void Dump(System.IO.TextWriter to) { }
        public override bool UpdatePropertiesFrom(JetBrains.ProjectModel.Properties.IProjectFileProperties properties) { }
    }
    [JetBrains.Annotations.MeansImplicitUseAttribute()]
    [System.AttributeUsageAttribute(System.AttributeTargets.Class | System.AttributeTargets.All)]
    public class SolutionProjectModelExtensionAttribute : JetBrains.Application.Parts.PartAttribute { }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class SolutionProjectModelExtensionsContainer
    {
        public SolutionProjectModelExtensionsContainer(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.Parts.IPartsCatalogueSet catalogueSet, JetBrains.Application.Components.IComponentContainer parentContainer) { }
        public System.Collections.Generic.IEnumerable<T> GetParts<T>(System.Func<T, bool> isApplicable)
            where T :  class { }
    }
}
namespace JetBrains.ProjectModel.Properties.Common
{
    
    public class MiscFilesProjectProperties : JetBrains.ProjectModel.Properties.Common.ProjectPropertiesBase, JetBrains.ProjectModel.Properties.IProjectProperties
    {
        public MiscFilesProjectProperties() { }
        public override JetBrains.ProjectModel.Properties.IBuildSettings BuildSettings { get; }
        public JetBrains.ProjectModel.Properties.ProjectLanguage DefaultLanguage { get; }
        public JetBrains.ProjectModel.ProjectKind ProjectKind { get; }
        public override void Dump(System.IO.TextWriter to, int indent = 0) { }
        public override void WriteProjectProperties(System.IO.BinaryWriter writer) { }
    }
    public abstract class ProjectPropertiesBase
    {
        protected ProjectPropertiesBase(System.Collections.Generic.ICollection<System.Guid> projectTypeGuids, JetBrains.ProjectModel.PlatformID platformId, System.Guid factoryGuid) { }
        protected ProjectPropertiesBase(System.Guid factoryGuid) { }
        public abstract JetBrains.ProjectModel.Properties.IBuildSettings BuildSettings { get; }
        public System.Guid OwnerFactoryGuid { get; }
        public JetBrains.ProjectModel.PlatformID PlatformId { get; }
        public System.Collections.Generic.IEnumerable<System.Guid> ProjectTypeGuids { get; }
        public virtual void Dump(System.IO.TextWriter to, int indent = 0) { }
        protected void ReadPlatformId(System.IO.BinaryReader reader) { }
        public virtual void ReadProjectProperties(System.IO.BinaryReader reader, JetBrains.ProjectModel.Impl.ProjectSerializationIndex index) { }
        protected void ReadProjectTypeGuids(System.IO.BinaryReader reader) { }
        protected virtual bool UpdateBuildSettings(JetBrains.ProjectModel.Properties.IProjectProperties properties) { }
        public virtual bool UpdateFrom(JetBrains.ProjectModel.Properties.IProjectProperties properties) { }
        protected void WritePlatformId(System.IO.BinaryWriter writer) { }
        public virtual void WriteProjectProperties(System.IO.BinaryWriter writer) { }
        protected void WriteProjectTypeGuids(System.IO.BinaryWriter writer) { }
    }
    public class SdkModuleProperties : JetBrains.ProjectModel.Properties.Common.ProjectPropertiesBase, JetBrains.ProjectModel.Properties.IProjectProperties, JetBrains.ProjectModel.Properties.ISdkConsumerProperties
    {
        public SdkModuleProperties(JetBrains.Metadata.Utils.TargetPlatformData targetPlatformData) { }
        public JetBrains.ProjectModel.Properties.IProjectConfiguration ActiveConfiguration { get; }
        public override JetBrains.ProjectModel.Properties.IBuildSettings BuildSettings { get; }
        public JetBrains.ProjectModel.Properties.ProjectLanguage DefaultLanguage { get; }
        public JetBrains.ProjectModel.ProjectKind ProjectKind { get; }
        public JetBrains.Metadata.Utils.TargetPlatformData TargetPlatformData { get; }
        public override void Dump(System.IO.TextWriter to, int indent = 0) { }
        public override void ReadProjectProperties(System.IO.BinaryReader reader, JetBrains.ProjectModel.Impl.ProjectSerializationIndex index) { }
        public override void WriteProjectProperties(System.IO.BinaryWriter writer) { }
    }
    public class SolutionFolderProjectProperties : JetBrains.ProjectModel.Properties.Common.ProjectPropertiesBase, JetBrains.ProjectModel.Properties.IProjectProperties
    {
        public SolutionFolderProjectProperties(System.Guid factoryGuid) { }
        public JetBrains.ProjectModel.Properties.IProjectConfiguration ActiveConfiguration { get; }
        public override JetBrains.ProjectModel.Properties.IBuildSettings BuildSettings { get; }
        public JetBrains.ProjectModel.Properties.ProjectLanguage DefaultLanguage { get; }
        public JetBrains.ProjectModel.ProjectKind ProjectKind { get; }
        public override void Dump(System.IO.TextWriter to, int indent = 0) { }
        public override void ReadProjectProperties(System.IO.BinaryReader reader, JetBrains.ProjectModel.Impl.ProjectSerializationIndex index) { }
        public override void WriteProjectProperties(System.IO.BinaryWriter writer) { }
    }
    [JetBrains.ProjectModel.Properties.ProjectModelExtensionAttribute()]
    public class SolutionFolderProjectPropertiesFactory : JetBrains.ProjectModel.Properties.Common.UnknownProjectPropertiesFactory
    {
        public static readonly System.Guid ProjectTypeGuid;
        public override System.Guid FactoryGuid { get; }
        public override JetBrains.ProjectModel.Properties.IProjectProperties CreateProjectProperties(System.Guid projectTypeGuid, System.Collections.Generic.ICollection<System.Guid> projectTypeGuids, JetBrains.ProjectModel.PlatformID platformIdVs, JetBrains.Metadata.Utils.TargetPlatformData targetPlatfromData) { }
        public static JetBrains.ProjectModel.Properties.Common.SolutionFolderProjectProperties CreateSolutionFolderProjectProperties() { }
        public override bool IsApplicable(System.Guid projectTypeGuid, System.Collections.Generic.ICollection<System.Guid> projectTypeGuids, JetBrains.ProjectModel.PlatformID platformId) { }
        public override JetBrains.ProjectModel.Properties.IProjectProperties Read(System.IO.BinaryReader reader, JetBrains.ProjectModel.Impl.ProjectSerializationIndex index) { }
    }
    public class SolutionProjectProperties : JetBrains.ProjectModel.Properties.Common.ProjectPropertiesBase, JetBrains.ProjectModel.Properties.IProjectProperties
    {
        public SolutionProjectProperties() { }
        public JetBrains.ProjectModel.Properties.IProjectConfiguration ActiveConfiguration { get; }
        public override JetBrains.ProjectModel.Properties.IBuildSettings BuildSettings { get; }
        public JetBrains.ProjectModel.Properties.ProjectLanguage DefaultLanguage { get; }
        public JetBrains.ProjectModel.ProjectKind ProjectKind { get; }
        public override void Dump(System.IO.TextWriter to, int indent = 0) { }
        public override void ReadProjectProperties(System.IO.BinaryReader reader, JetBrains.ProjectModel.Impl.ProjectSerializationIndex index) { }
        public override void WriteProjectProperties(System.IO.BinaryWriter writer) { }
    }
    public class UnknownManagedProjectProperties : JetBrains.ProjectModel.Properties.Common.ProjectPropertiesBase, JetBrains.ProjectModel.Properties.IProjectProperties
    {
        public UnknownManagedProjectProperties(System.Collections.Generic.ICollection<System.Guid> flavours, JetBrains.ProjectModel.PlatformID platformId, System.Guid guid) { }
        public UnknownManagedProjectProperties(System.Guid guid) { }
        public JetBrains.ProjectModel.Properties.IProjectConfiguration ActiveConfiguration { get; }
        public override JetBrains.ProjectModel.Properties.IBuildSettings BuildSettings { get; }
        public JetBrains.ProjectModel.Properties.ProjectLanguage DefaultLanguage { get; }
        public JetBrains.ProjectModel.ProjectKind ProjectKind { get; }
        public override void Dump(System.IO.TextWriter to, int indent = 0) { }
        public override void ReadProjectProperties(System.IO.BinaryReader reader, JetBrains.ProjectModel.Impl.ProjectSerializationIndex index) { }
        public override bool UpdateFrom(JetBrains.ProjectModel.Properties.IProjectProperties properties) { }
        public override void WriteProjectProperties(System.IO.BinaryWriter writer) { }
    }
    [JetBrains.ProjectModel.Properties.ProjectModelExtensionAttribute()]
    public class UnknownProjectPropertiesFactory : JetBrains.ProjectModel.Properties.IProjectPropertiesFactory
    {
        public virtual System.Guid FactoryGuid { get; }
        public virtual JetBrains.ProjectModel.Properties.IProjectProperties CreateProjectProperties(System.Guid projectTypeGuid, System.Collections.Generic.ICollection<System.Guid> projectTypeGuids, JetBrains.ProjectModel.PlatformID platformIdVs, JetBrains.Metadata.Utils.TargetPlatformData targetPlatfromData) { }
        public static JetBrains.ProjectModel.Properties.Common.UnknownManagedProjectProperties CreateUnknownProjectProperties(JetBrains.ProjectModel.PlatformID platformId, System.Collections.Generic.ICollection<System.Guid> projectTypeGuids) { }
        public static JetBrains.ProjectModel.Properties.Common.UnknownManagedProjectProperties CreateUnknownProjectProperties(JetBrains.ProjectModel.PlatformID platformId, System.Guid[] flavors) { }
        public static JetBrains.ProjectModel.Properties.Common.UnknownManagedProjectProperties CreateUnknownProjectProperties(JetBrains.ProjectModel.PlatformID platformId) { }
        public virtual bool IsApplicable(System.Guid projectTypeGuid, System.Collections.Generic.ICollection<System.Guid> projectTypeGuids, JetBrains.ProjectModel.PlatformID platformId) { }
        public virtual JetBrains.ProjectModel.Properties.IProjectProperties Read(System.IO.BinaryReader reader, JetBrains.ProjectModel.Impl.ProjectSerializationIndex index) { }
    }
    public sealed class UnsupportedProjectConfiguration : JetBrains.ProjectModel.Impl.Build.ProjectConfigurationBase { }
    public class UnsupportedProjectProperties : JetBrains.ProjectModel.Properties.Common.ProjectPropertiesBase, JetBrains.ProjectModel.Properties.IProjectProperties
    {
        public UnsupportedProjectProperties(System.Guid guid) { }
        public JetBrains.ProjectModel.Properties.IProjectConfiguration ActiveConfiguration { get; }
        public override JetBrains.ProjectModel.Properties.IBuildSettings BuildSettings { get; }
        public JetBrains.ProjectModel.Properties.ProjectLanguage DefaultLanguage { get; }
        public JetBrains.ProjectModel.ProjectKind ProjectKind { get; }
        public override void Dump(System.IO.TextWriter to, int indent = 0) { }
        public override void ReadProjectProperties(System.IO.BinaryReader reader, JetBrains.ProjectModel.Impl.ProjectSerializationIndex index) { }
        public override void WriteProjectProperties(System.IO.BinaryWriter writer) { }
    }
    [JetBrains.ProjectModel.Properties.ProjectModelExtensionAttribute()]
    public class UnsupportedProjectPropertiesFactory : JetBrains.ProjectModel.Properties.Common.UnknownProjectPropertiesFactory
    {
        public override System.Guid FactoryGuid { get; }
        public override JetBrains.ProjectModel.Properties.IProjectProperties CreateProjectProperties(System.Guid projectTypeGuid, System.Collections.Generic.ICollection<System.Guid> projectTypeGuids, JetBrains.ProjectModel.PlatformID platformIdVs, JetBrains.Metadata.Utils.TargetPlatformData targetPlatfromData) { }
        public override bool IsApplicable(System.Guid projectTypeGuid, System.Collections.Generic.ICollection<System.Guid> projectTypeGuids, JetBrains.ProjectModel.PlatformID platformId) { }
    }
}
namespace JetBrains.ProjectModel.Properties.CSharp
{
    
    public class CSharpBuildSettings : JetBrains.ProjectModel.Properties.Managed.ManagedProjectBuildSettings
    {
        public override bool UpdateFrom(JetBrains.ProjectModel.Properties.IBuildSettings settings) { }
    }
    public class CSharpProjectProperties : JetBrains.ProjectModel.Properties.Common.ProjectPropertiesBase, JetBrains.ProjectModel.Properties.IProjectProperties, JetBrains.ProjectModel.Properties.ISdkConsumerProperties
    {
        public CSharpProjectProperties(System.Guid factoryGuid, JetBrains.Metadata.Utils.TargetPlatformData targetPlatformData = null) { }
        public JetBrains.ProjectModel.Propoerties.CSharpProjectConfiguration ActiveConfiguration { get; }
        public override JetBrains.ProjectModel.Properties.IBuildSettings BuildSettings { get; }
        public JetBrains.ProjectModel.Properties.CSharp.CSharpBuildSettings CSharpBuildSettings { get; }
        public JetBrains.ProjectModel.Properties.ProjectLanguage DefaultLanguage { get; }
        public JetBrains.ProjectModel.ProjectKind ProjectKind { get; }
        public JetBrains.Metadata.Utils.TargetPlatformData TargetPlatformData { get; }
        public override void Dump(System.IO.TextWriter to, int indent = 0) { }
        public override void ReadProjectProperties(System.IO.BinaryReader reader, JetBrains.ProjectModel.Impl.ProjectSerializationIndex index) { }
        public override bool UpdateFrom(JetBrains.ProjectModel.Properties.IProjectProperties properties) { }
        public override void WriteProjectProperties(System.IO.BinaryWriter writer) { }
    }
    [JetBrains.ProjectModel.Properties.ProjectModelExtensionAttribute()]
    public class CSharpProjectPropertiesFactory : JetBrains.ProjectModel.Properties.Common.UnknownProjectPropertiesFactory
    {
        public static readonly System.Guid CSharpProjectTypeGuid;
        public override System.Guid FactoryGuid { get; }
        public static JetBrains.ProjectModel.Properties.CSharp.CSharpProjectProperties CreateCSharpProjectProperties(JetBrains.ProjectModel.PlatformID platformId, System.Collections.Generic.ICollection<System.Guid> flavours, JetBrains.Metadata.Utils.TargetPlatformData targetPlatformData = null) { }
        public static JetBrains.ProjectModel.Properties.CSharp.CSharpProjectProperties CreateCSharpProjectProperties(JetBrains.ProjectModel.PlatformID platformId, params System.Guid[] flavors) { }
        public static JetBrains.ProjectModel.Properties.CSharp.CSharpProjectProperties CreateCSharpProjectProperties(JetBrains.ProjectModel.PlatformID platformId) { }
        public override JetBrains.ProjectModel.Properties.IProjectProperties CreateProjectProperties(System.Guid projectTypeGuid, System.Collections.Generic.ICollection<System.Guid> projectTypeGuids, JetBrains.ProjectModel.PlatformID platformIdVs, JetBrains.Metadata.Utils.TargetPlatformData targetPlatfromData) { }
        public override bool IsApplicable(System.Guid projectTypeGuid, System.Collections.Generic.ICollection<System.Guid> projectTypeGuids, JetBrains.ProjectModel.PlatformID platformId) { }
        public override JetBrains.ProjectModel.Properties.IProjectProperties Read(System.IO.BinaryReader reader, JetBrains.ProjectModel.Impl.ProjectSerializationIndex index) { }
    }
    public interface ICSharpProjectConfiguration : JetBrains.ProjectModel.Properties.IProjectConfiguration, JetBrains.ProjectModel.Properties.Managed.IManagedProjectConfiguration, JetBrains.Util.IUserDataHolder
    {
        bool AllowUnsafeCode { get; set; }
        uint BaseAddress { get; set; }
        bool CheckForOverflowUnderflow { get; set; }
        bool DebugSymbols { get; set; }
        uint FileAlignment { get; set; }
        bool IncrementalBuild { get; set; }
        JetBrains.ProjectModel.Properties.CSharp.VSCSharpLanguageVersion LanguageVersion { get; set; }
        bool NoStdLibProperty { get; set; }
        string WarningsAsErrors { get; set; }
        string GetCompilerOptionsCommandLine(JetBrains.Util.FileSystemPath projectDir);
    }
    public enum VSCSharpLanguageVersion
    {
        CS12 = 0,
        CS20 = 1,
        CS3 = 2,
        Latest = 3,
    }
}
namespace JetBrains.ProjectModel.Properties.Flavours
{
    
    [JetBrains.ProjectModel.Properties.ProjectFlavorAttribute()]
    public class BizTalkProjectFlavor : JetBrains.ProjectModel.Properties.IProjectFlavor
    {
        public static readonly System.Guid BizTalkProject;
        public string FlavorName { get; }
        public System.Guid Guid { get; }
    }
    [JetBrains.ProjectModel.Properties.ProjectFlavorAttribute()]
    public class MetroStyleAppFlavor : JetBrains.ProjectModel.Properties.IProjectFlavor
    {
        public static System.Guid MetroStyleAppGuid;
        public string FlavorName { get; }
        public System.Guid Guid { get; }
    }
    [JetBrains.ProjectModel.Properties.ProjectFlavorAttribute()]
    public class MonoDroidProjectFlavor : JetBrains.ProjectModel.Properties.IProjectFlavor
    {
        public static readonly System.Guid MonoDroidProject;
        public string FlavorName { get; }
        public System.Guid Guid { get; }
    }
    [JetBrains.ProjectModel.Properties.ProjectFlavorAttribute()]
    public class SharepointCSharpWorkflowFlavor : JetBrains.ProjectModel.Properties.Flavours.SharepointWorkflowFlavorBase
    {
        public static readonly System.Guid CSharpWorkflowProject;
        public override string FlavorName { get; }
        public override System.Guid Guid { get; }
    }
    [JetBrains.ProjectModel.Properties.ProjectFlavorAttribute()]
    public class SharepointVbWorkflowFlavor : JetBrains.ProjectModel.Properties.Flavours.SharepointWorkflowFlavorBase
    {
        public static readonly System.Guid VbWorkflowProject;
        public override string FlavorName { get; }
        public override System.Guid Guid { get; }
    }
    public abstract class SharepointWorkflowFlavorBase : JetBrains.ProjectModel.Properties.Flavours.WebApplicationFlavorBase { }
    [JetBrains.ProjectModel.Properties.ProjectFlavorAttribute()]
    public class WebApplicationFlavor : JetBrains.ProjectModel.Properties.Flavours.WebApplicationFlavorBase
    {
        public static readonly System.Guid WebApplicationProject;
        public override string FlavorName { get; }
        public override System.Guid Guid { get; }
    }
    public abstract class WebApplicationFlavorBase : JetBrains.ProjectModel.Properties.IProjectFlavor
    {
        public abstract string FlavorName { get; }
        public abstract System.Guid Guid { get; }
    }
    [JetBrains.ProjectModel.Properties.ProjectFlavorAttribute()]
    public class WindowsPhoneProjectFlavor : JetBrains.ProjectModel.Properties.IProjectFlavor
    {
        public static readonly System.Guid WindowsPhoneProject;
        public string FlavorName { get; }
        public System.Guid Guid { get; }
    }
    [JetBrains.ProjectModel.Properties.ProjectFlavorAttribute()]
    public class WPFProjectFlavor : JetBrains.ProjectModel.Properties.IProjectFlavor
    {
        public static readonly System.Guid WPFProject;
        public string FlavorName { get; }
        public System.Guid Guid { get; }
    }
    [JetBrains.ProjectModel.Properties.ProjectFlavorAttribute()]
    public class XamarinMonoDroidProjectFlavor : JetBrains.ProjectModel.Properties.IProjectFlavor
    {
        public static readonly System.Guid XamarinMonoDroidProject;
        public string FlavorName { get; }
        public System.Guid Guid { get; }
    }
}
namespace JetBrains.ProjectModel.Properties.JavaScriptMetroStyle
{
    
    [JetBrains.ProjectModel.Properties.ProjectModelExtensionAttribute()]
    public class JavaScriptMetroProjectPropertiesFactory : JetBrains.ProjectModel.Properties.Common.UnknownProjectPropertiesFactory
    {
        public static readonly System.Guid JavaScriptMetroStyleProjectTypeGuild;
        public override System.Guid FactoryGuid { get; }
        public static JetBrains.ProjectModel.Properties.JavaScriptMetroStyle.JavaScriptMetroStyleProjectProperties CreateJavaScriptMetroProjectProperties(JetBrains.ProjectModel.PlatformID platformIdVs, System.Collections.Generic.ICollection<System.Guid> flavours, JetBrains.Metadata.Utils.TargetPlatformData targetPlatformData = null) { }
        public static JetBrains.ProjectModel.Properties.JavaScriptMetroStyle.JavaScriptMetroStyleProjectProperties CreateJavaScriptMetroProjectProperties(JetBrains.ProjectModel.PlatformID platformId, params System.Guid[] flavours) { }
        public static JetBrains.ProjectModel.Properties.JavaScriptMetroStyle.JavaScriptMetroStyleProjectProperties CreateJavaScriptMetroProjectProperties(JetBrains.ProjectModel.PlatformID platformId) { }
        public override JetBrains.ProjectModel.Properties.IProjectProperties CreateProjectProperties(System.Guid projectTypeGuid, System.Collections.Generic.ICollection<System.Guid> projectTypeGuids, JetBrains.ProjectModel.PlatformID platformId, JetBrains.Metadata.Utils.TargetPlatformData targetPlatfromData) { }
        public override bool IsApplicable(System.Guid projectTypeGuid, System.Collections.Generic.ICollection<System.Guid> projectTypeGuids, JetBrains.ProjectModel.PlatformID platformId) { }
        public override JetBrains.ProjectModel.Properties.IProjectProperties Read(System.IO.BinaryReader reader, JetBrains.ProjectModel.Impl.ProjectSerializationIndex index) { }
    }
    public class JavaScriptMetroStyleBuildSettings : JetBrains.ProjectModel.Properties.BuildSettingsBase
    {
        public override void Dump(System.IO.TextWriter to, int indent) { }
        public override bool UpdateFrom(JetBrains.ProjectModel.Properties.IBuildSettings settings) { }
    }
    public class JavaScriptMetroStyleProjectProperties : JetBrains.ProjectModel.Properties.Common.ProjectPropertiesBase, JetBrains.ProjectModel.Properties.IProjectProperties, JetBrains.ProjectModel.Properties.ISdkConsumerProperties
    {
        public JavaScriptMetroStyleProjectProperties(System.Guid factoryGuid, JetBrains.Metadata.Utils.TargetPlatformData targetPlatformData = null) { }
        public JetBrains.ProjectModel.Properties.IProjectConfiguration ActiveConfiguration { get; }
        public override JetBrains.ProjectModel.Properties.IBuildSettings BuildSettings { get; }
        public JetBrains.ProjectModel.Properties.ProjectLanguage DefaultLanguage { get; }
        public JetBrains.ProjectModel.ProjectKind ProjectKind { get; }
        public JetBrains.Metadata.Utils.TargetPlatformData TargetPlatformData { get; }
        public void Dump(System.IO.TextWriter to, int indent = 0) { }
        public override void ReadProjectProperties(System.IO.BinaryReader reader, JetBrains.ProjectModel.Impl.ProjectSerializationIndex index) { }
        public override bool UpdateFrom(JetBrains.ProjectModel.Properties.IProjectProperties properties) { }
        public override void WriteProjectProperties(System.IO.BinaryWriter writer) { }
    }
}
namespace JetBrains.ProjectModel.Properties.Managed
{
    
    public interface IManagedProjectBuildSettings : JetBrains.ProjectModel.Properties.IBuildSettings
    {
        string ApplicationType { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        string DefaultNamespace { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        string[] ImportedNamespaces { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        string OutputAssemblyFileName { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        string OutputAssemblyName { get; set; }
        JetBrains.ProjectModel.ProjectOutputType OutputType { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        string PlatformTarget { get; set; }
        string StartupObject { get; }
    }
    public interface IManagedProjectConfiguration : JetBrains.ProjectModel.Properties.IProjectConfiguration, JetBrains.Util.IUserDataHolder
    {
        string DefineConstants { get; set; }
        string DocumentationFile { get; set; }
        bool EnableUnmanagedCodeDebugging { get; set; }
        bool GenerateSerializationAssemblies { get; set; }
        string NoWarn { get; set; }
        bool Optimize { get; set; }
        bool RegisterForCOMInterop { get; set; }
        string RelativeIntermediateDirectory { get; set; }
        bool RemoveIntegerChecks { get; set; }
        bool TreatWarningsAsErrors { get; set; }
        int WarningLevel { get; set; }
    }
    public class ManagedProjectBuildSettings : JetBrains.ProjectModel.Properties.BuildSettingsBase, JetBrains.ProjectModel.Properties.IBuildSettings, JetBrains.ProjectModel.Properties.Managed.IManagedProjectBuildSettings
    {
        public ManagedProjectBuildSettings() { }
        public string ApplicationType { get; set; }
        public string DefaultNamespace { get; set; }
        public string[] ImportedNamespaces { get; set; }
        public string OutputAssemblyFileName { get; }
        public string OutputAssemblyName { get; set; }
        public JetBrains.ProjectModel.ProjectOutputType OutputType { get; set; }
        public string PlatformTarget { get; set; }
        public string PostBuildEvent { get; set; }
        public string PreBuildEvent { get; set; }
        public JetBrains.ProjectModel.Properties.RunPostBuildEventType RunPostBuildEventType { get; set; }
        public string StartupObject { get; set; }
        public override void Dump(System.IO.TextWriter to, int indent) { }
        public override void ReadBuildSettings(System.IO.BinaryReader reader) { }
        public override bool UpdateFrom(JetBrains.ProjectModel.Properties.IBuildSettings settings) { }
        public override void WriteBuildSettings(System.IO.BinaryWriter writer) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class ShouldUseHostCompilerProvider : JetBrains.ProjectModel.Caches.IProjectFileDataCache
    {
        public ShouldUseHostCompilerProvider(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.IShellLocks locks, JetBrains.ProjectModel.Caches.ProjectFileDataCache cache) { }
        public int Version { get; }
        public object BuildData(System.Xml.XmlDocument document) { }
        public bool CanHandle(JetBrains.ProjectModel.IProjectFile projectFile) { }
        public System.Action OnDataChanged(JetBrains.ProjectModel.IProjectFile projectFile, object oldData, object newData) { }
        public object Read(System.IO.BinaryReader reader) { }
        public bool ShouldUseHostCompiler(JetBrains.ProjectModel.IProject project) { }
        public void Write(System.IO.BinaryWriter writer, object data) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class WarningsAsErrorsPropertyProvider : JetBrains.ProjectModel.Caches.IProjectFileDataCache
    {
        public WarningsAsErrorsPropertyProvider(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.IShellLocks locks, JetBrains.ProjectModel.Caches.ProjectFileDataCache cache) { }
        public int Version { get; }
        public object BuildData(System.Xml.XmlDocument document) { }
        public bool CanHandle(JetBrains.ProjectModel.IProjectFile projectFile) { }
        public JetBrains.ProjectModel.Properties.Managed.WarningsAsErrorsPropertyProvider.Properties GetProperties(JetBrains.ProjectModel.IProject project) { }
        public System.Action OnDataChanged(JetBrains.ProjectModel.IProjectFile projectFile, object oldData, object newData) { }
        public object Read(System.IO.BinaryReader reader) { }
        public void Write(System.IO.BinaryWriter writer, object data) { }
        public sealed class Properties
        {
            [JetBrains.Annotations.NotNullAttribute()]
            public string WarningsAsErrors { get; }
            [JetBrains.Annotations.NotNullAttribute()]
            public string WarningsNotAsErrors { get; }
            public override bool Equals(object obj) { }
            public override int GetHashCode() { }
        }
    }
}
namespace JetBrains.ProjectModel.Properties.VB
{
    
    public interface IVBBuildSettings : JetBrains.ProjectModel.Properties.IBuildSettings, JetBrains.ProjectModel.Properties.Managed.IManagedProjectBuildSettings
    {
        JetBrains.ProjectModel.Properties.VB.OptionCompare OptionCompare { get; }
        JetBrains.ProjectModel.Properties.VB.OptionExplicit OptionExplicit { get; }
        JetBrains.ProjectModel.Properties.VB.OptionInfer OptionInfer { get; }
        JetBrains.ProjectModel.Properties.VB.OptionStrict OptionStrict { get; }
    }
    public interface IVBProjectConfiguration : JetBrains.ProjectModel.Properties.IProjectConfiguration, JetBrains.ProjectModel.Properties.Managed.IManagedProjectConfiguration, JetBrains.Util.IUserDataHolder
    {
        JetBrains.ProjectModel.Properties.DebugType DebugType { get; set; }
        bool DefineDebug { get; set; }
        bool DefineTrace { get; set; }
        string Platform { get; set; }
        string WarningsAsErrors { get; set; }
        string GetCompilerOptionsCommandLine(JetBrains.Util.FileSystemPath location);
    }
    public enum OptionCompare : byte
    {
        Binary = 0,
        Text = 1,
    }
    public enum OptionExplicit : byte
    {
        Off = 0,
        On = 1,
    }
    public enum OptionInfer : byte
    {
        Off = 0,
        On = 1,
    }
    public enum OptionStrict : byte
    {
        Off = 0,
        On = 1,
    }
    public class VBProjectProperties : JetBrains.ProjectModel.Properties.Common.ProjectPropertiesBase, JetBrains.ProjectModel.Properties.IProjectProperties, JetBrains.ProjectModel.Properties.ISdkConsumerProperties
    {
        public VBProjectProperties(System.Guid factoryGuid, JetBrains.Metadata.Utils.TargetPlatformData targetPlatformData = null) { }
        public JetBrains.ProjectModel.Properties.IProjectConfiguration ActiveConfiguration { get; }
        public override JetBrains.ProjectModel.Properties.IBuildSettings BuildSettings { get; }
        public JetBrains.ProjectModel.Properties.ProjectLanguage DefaultLanguage { get; }
        public JetBrains.ProjectModel.ProjectKind ProjectKind { get; }
        public JetBrains.Metadata.Utils.TargetPlatformData TargetPlatformData { get; }
        public override void Dump(System.IO.TextWriter to, int indent = 0) { }
        public override void ReadProjectProperties(System.IO.BinaryReader reader, JetBrains.ProjectModel.Impl.ProjectSerializationIndex index) { }
        public override bool UpdateFrom(JetBrains.ProjectModel.Properties.IProjectProperties properties) { }
        public override void WriteProjectProperties(System.IO.BinaryWriter writer) { }
    }
    [JetBrains.ProjectModel.Properties.ProjectModelExtensionAttribute()]
    public class VBProjectPropertiesFactory : JetBrains.ProjectModel.Properties.Common.UnknownProjectPropertiesFactory
    {
        public static readonly System.Guid VBProjectTypeGuid;
        public override System.Guid FactoryGuid { get; }
        public override JetBrains.ProjectModel.Properties.IProjectProperties CreateProjectProperties(System.Guid projectTypeGuid, System.Collections.Generic.ICollection<System.Guid> projectTypeGuids, JetBrains.ProjectModel.PlatformID platformIdVs, JetBrains.Metadata.Utils.TargetPlatformData targetPlatfromData) { }
        public static JetBrains.ProjectModel.Properties.VB.VBProjectProperties CreateVBProjectProperties(JetBrains.ProjectModel.PlatformID platformId, params System.Guid[] flavors) { }
        public static JetBrains.ProjectModel.Properties.VB.VBProjectProperties CreateVBProjectProperties(JetBrains.ProjectModel.PlatformID platformId, System.Collections.Generic.ICollection<System.Guid> flavours, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.Metadata.Utils.TargetPlatformData targetPlatformData = null) { }
        public static JetBrains.ProjectModel.Properties.VB.VBProjectProperties CreateVBProjectProperties(JetBrains.ProjectModel.PlatformID platformId) { }
        public override bool IsApplicable(System.Guid projectTypeGuid, System.Collections.Generic.ICollection<System.Guid> projectTypeGuids, JetBrains.ProjectModel.PlatformID platformId) { }
        public override JetBrains.ProjectModel.Properties.IProjectProperties Read(System.IO.BinaryReader reader, JetBrains.ProjectModel.Impl.ProjectSerializationIndex index) { }
    }
}
namespace JetBrains.ProjectModel.Properties.VCXProj
{
    
    public enum ConfigurationTypes
    {
        TypeUnknown = 0,
        TypeApplication = 1,
        TypeDynamicLibrary = 2,
        TypeStaticLibrary = 4,
        TypeGeneric = 10,
    }
    public enum UseOfATL
    {
        UseATLNotSet = 0,
        UseATLStatic = 1,
        UseATLDynamic = 2,
    }
    public enum UseOfMfc
    {
        UseMfcStdWin = 0,
        UseMfcStatic = 1,
        UseMfcDynamic = 2,
    }
    public class VCXBuildSettings : JetBrains.ProjectModel.Properties.Managed.ManagedProjectBuildSettings
    {
        public VCXBuildSettings() { }
        public string AssemblyReferenceSearchPaths { get; set; }
        public override void Dump(System.IO.TextWriter to, int indent) { }
    }
    public enum VCXCompileAsManagedOptions
    {
        ManagedNotSet = 0,
        ManagedAssembly = 1,
        ManagedAssemblyPure = 2,
        ManagedAssemblySafe = 3,
        ManagedAssemblyOldSyntax = 4,
    }
    public class VCXProjectConfiguration : JetBrains.ProjectModel.Impl.Build.ManagedProjectConfigurationBase
    {
        public VCXProjectConfiguration() { }
        [JetBrains.Annotations.UsedImplicitlyAttribute()]
        public string AdditionalIncludeDirectories { get; set; }
        [JetBrains.Annotations.UsedImplicitlyAttribute()]
        public JetBrains.ProjectModel.Properties.VCXProj.VCXCompileAsManagedOptions CompileAsManagedOptions { get; set; }
        [JetBrains.Annotations.UsedImplicitlyAttribute()]
        public JetBrains.ProjectModel.Properties.VCXProj.ConfigurationTypes ConfigurationType { get; set; }
        [JetBrains.Annotations.UsedImplicitlyAttribute()]
        public string FullIncludePath { get; set; }
        [JetBrains.Annotations.UsedImplicitlyAttribute()]
        public string PreprocessorDefinitions { get; set; }
        [JetBrains.Annotations.UsedImplicitlyAttribute()]
        public JetBrains.ProjectModel.Properties.VCXProj.UseOfATL UseOfAtl { get; set; }
        [JetBrains.Annotations.UsedImplicitlyAttribute()]
        public JetBrains.ProjectModel.Properties.VCXProj.UseOfMfc UseOfMfc { get; set; }
        public override void Dump(System.IO.TextWriter to, int indent) { }
        public override void ReadConfiguration(System.IO.BinaryReader reader) { }
        public override bool UpdateFrom(JetBrains.ProjectModel.Properties.IProjectConfiguration configuration) { }
        public override void WriteConfiguration(System.IO.BinaryWriter writer) { }
    }
    public class VCXProjectProperties : JetBrains.ProjectModel.Properties.Common.ProjectPropertiesBase, JetBrains.ProjectModel.Properties.IProjectProperties
    {
        public VCXProjectProperties(System.Collections.Generic.ICollection<System.Guid> projectTypeGuids, JetBrains.ProjectModel.PlatformID platformId, System.Guid factoryGuid) { }
        public VCXProjectProperties(System.Guid factoryGuid) { }
        public JetBrains.ProjectModel.Properties.IProjectConfiguration ActiveConfiguration { get; }
        public override JetBrains.ProjectModel.Properties.IBuildSettings BuildSettings { get; }
        public JetBrains.ProjectModel.Properties.ProjectLanguage DefaultLanguage { get; }
        public JetBrains.ProjectModel.ProjectKind ProjectKind { get; }
        public override void Dump(System.IO.TextWriter to, int indent = 0) { }
        public override void ReadProjectProperties(System.IO.BinaryReader reader, JetBrains.ProjectModel.Impl.ProjectSerializationIndex index) { }
        public override bool UpdateFrom(JetBrains.ProjectModel.Properties.IProjectProperties properties) { }
        public override void WriteProjectProperties(System.IO.BinaryWriter writer) { }
    }
    [JetBrains.ProjectModel.Properties.ProjectModelExtensionAttribute()]
    public class VCXProjectPropertiesFactory : JetBrains.ProjectModel.Properties.Common.UnknownProjectPropertiesFactory
    {
        public static readonly System.Guid VCXProjectTypeGuid;
        public override System.Guid FactoryGuid { get; }
        public override JetBrains.ProjectModel.Properties.IProjectProperties CreateProjectProperties(System.Guid projectTypeGuid, System.Collections.Generic.ICollection<System.Guid> projectTypeGuids, JetBrains.ProjectModel.PlatformID platformIdVs, JetBrains.Metadata.Utils.TargetPlatformData targetPlatfromData) { }
        public static JetBrains.ProjectModel.Properties.VCXProj.VCXProjectProperties CreateVCXProjectProperties(JetBrains.ProjectModel.PlatformID platformId, System.Collections.Generic.ICollection<System.Guid> flavours, JetBrains.Metadata.Utils.TargetPlatformData targetPlatformData = null) { }
        public static JetBrains.ProjectModel.Properties.VCXProj.VCXProjectProperties CreateVCXProjectProperties(JetBrains.ProjectModel.PlatformID platformId, params System.Guid[] flavors) { }
        public static JetBrains.ProjectModel.Properties.VCXProj.VCXProjectProperties CreateVCXProjectProperties(JetBrains.ProjectModel.PlatformID platformId) { }
        public override bool IsApplicable(System.Guid projectTypeGuid, System.Collections.Generic.ICollection<System.Guid> projectTypeGuids, JetBrains.ProjectModel.PlatformID platformId) { }
        public override JetBrains.ProjectModel.Properties.IProjectProperties Read(System.IO.BinaryReader reader, JetBrains.ProjectModel.Impl.ProjectSerializationIndex index) { }
    }
}
namespace JetBrains.ProjectModel.Properties.WebSite
{
    
    public class WebSiteProjectProperties : JetBrains.ProjectModel.Properties.Common.ProjectPropertiesBase, JetBrains.ProjectModel.Properties.IProjectProperties
    {
        public JetBrains.ProjectModel.Properties.IProjectConfiguration ActiveConfiguration { get; }
        public override JetBrains.ProjectModel.Properties.IBuildSettings BuildSettings { get; }
        public JetBrains.ProjectModel.Properties.ProjectLanguage DefaultLanguage { get; }
        public JetBrains.ProjectModel.ProjectKind ProjectKind { get; }
        public override void Dump(System.IO.TextWriter to, int indent = 0) { }
        public override void ReadProjectProperties(System.IO.BinaryReader reader, JetBrains.ProjectModel.Impl.ProjectSerializationIndex index) { }
        protected override bool UpdateBuildSettings(JetBrains.ProjectModel.Properties.IProjectProperties properties) { }
        public override bool UpdateFrom(JetBrains.ProjectModel.Properties.IProjectProperties properties) { }
        public override void WriteProjectProperties(System.IO.BinaryWriter writer) { }
    }
    [JetBrains.ProjectModel.Properties.ProjectModelExtensionAttribute()]
    public class WebSiteProjectPropertiesFactory : JetBrains.ProjectModel.Properties.IProjectPropertiesFactory
    {
        public static readonly System.Guid ProjectTypeGuid;
        public System.Guid FactoryGuid { get; }
        public JetBrains.ProjectModel.Properties.IProjectProperties CreateProjectProperties(System.Guid projectTypeGuid, System.Collections.Generic.ICollection<System.Guid> projectTypeGuids, JetBrains.ProjectModel.PlatformID platformIdVs, JetBrains.Metadata.Utils.TargetPlatformData targetPlatfromData) { }
        public static JetBrains.ProjectModel.Properties.WebSite.WebSiteProjectProperties CreateWebSiteProjectProperties(JetBrains.ProjectModel.PlatformID platformId, JetBrains.ProjectModel.Properties.ProjectLanguage defaultLanguage, System.Collections.Generic.ICollection<System.Guid> projectTypeGuids) { }
        public static JetBrains.ProjectModel.Properties.WebSite.WebSiteProjectProperties CreateWebSiteProjectPropertiesForTests(JetBrains.ProjectModel.PlatformID platformId, JetBrains.ProjectModel.Properties.ProjectLanguage defaultLanguage, System.Collections.Generic.ICollection<System.Guid> flavours) { }
        public bool IsApplicable(System.Guid projectTypeGuid, System.Collections.Generic.ICollection<System.Guid> projectTypeGuids, JetBrains.ProjectModel.PlatformID platformId) { }
        public JetBrains.ProjectModel.Properties.IProjectProperties Read(System.IO.BinaryReader reader, JetBrains.ProjectModel.Impl.ProjectSerializationIndex index) { }
    }
}
namespace JetBrains.ProjectModel.Propoerties
{
    
    public class CSharpProjectConfiguration : JetBrains.ProjectModel.Impl.Build.ManagedProjectConfigurationBase, JetBrains.ProjectModel.Properties.CSharp.ICSharpProjectConfiguration, JetBrains.ProjectModel.Properties.IProjectConfiguration, JetBrains.ProjectModel.Properties.Managed.IManagedProjectConfiguration, JetBrains.Util.IUserDataHolder
    {
        public CSharpProjectConfiguration() { }
        public bool AllowUnsafeCode { get; set; }
        public uint BaseAddress { get; set; }
        public bool CheckForOverflowUnderflow { get; set; }
        public bool DebugSymbols { get; set; }
        public uint FileAlignment { get; set; }
        public bool IncrementalBuild { get; set; }
        public JetBrains.ProjectModel.Properties.CSharp.VSCSharpLanguageVersion LanguageVersion { get; set; }
        public bool NoStdLibProperty { get; set; }
        public string WarningsAsErrors { get; set; }
        public override void Dump(System.IO.TextWriter to, int indent) { }
        public string GetCompilerOptionsCommandLine(JetBrains.Util.FileSystemPath projectDir) { }
        public override void ReadConfiguration(System.IO.BinaryReader reader) { }
        public override bool UpdateFrom(JetBrains.ProjectModel.Properties.IProjectConfiguration configuration) { }
        public override void WriteConfiguration(System.IO.BinaryWriter writer) { }
    }
}
namespace JetBrains.ProjectModel.References.Impl
{
    
    public class ProjectToComAssemblyReference : JetBrains.ProjectModel.Impl.ProjectToAssemblyReference
    {
        public readonly JetBrains.Util.FileSystemPath ManifestFilePath;
        public ProjectToComAssemblyReference(JetBrains.ProjectModel.IProject containingProject, JetBrains.Util.FileSystemPath manifestFilePath) { }
    }
    [JetBrains.ProjectModel.SolutionInstanceComponentAttribute()]
    public class SdkReferenceFactory
    {
        public SdkReferenceFactory(JetBrains.ProjectModel.References.SdkReferencesManager sdkReferencesManager) { }
        public JetBrains.ProjectModel.References.IProjectToSdkReference CreateSdkReference(JetBrains.ProjectModel.IProject project, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Metadata.Utils.SdkModuleInfo sdkModuleInfo) { }
        public static JetBrains.ProjectModel.References.Impl.SdkReferenceFactory GetInstance(JetBrains.ProjectModel.Impl.SolutionElement solutionElement) { }
    }
    public class SdkReferenceImpl : JetBrains.ProjectModel.IProjectElement, JetBrains.ProjectModel.IProjectModelElement, JetBrains.ProjectModel.IProjectModelElementInternal, JetBrains.ProjectModel.IProjectToModuleReference, JetBrains.ProjectModel.References.IProjectToModuleWithSourcesReference, JetBrains.ProjectModel.References.IProjectToSdkReference, JetBrains.Util.IUserDataHolder, System.IDisposable
    {
        public string AliasList { get; set; }
        public bool CopyLocal { get; set; }
        public bool EmbedInteropTypes { get; set; }
        public JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext ModuleReferenceResolveContext { get; }
        public string Name { get; }
        public System.Collections.Generic.ICollection<JetBrains.ProjectModel.IProjectToAssemblyReference> NestedAssemblyReferences { get; }
        public JetBrains.ProjectModel.IProject OwnerModule { get; }
        public JetBrains.ProjectModel.IProject Project { get; }
        public JetBrains.ProjectModel.Update.SdkReferences.SdkReferenceInfo SdkReferenceInfo { get; }
        public void Accept(JetBrains.ProjectModel.ProjectVisitor projectVisitor) { }
        public void AssertIsValid() { }
        public void Dispose() { }
        public void Dump(System.IO.TextWriter textWriter, int indent) { }
        public System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<object, object>> EnumerateData() { }
        public T GetData<T>(JetBrains.Util.Key<T> key)
            where T :  class { }
        public string GetPersistentID() { }
        public JetBrains.ProjectModel.IProject GetProject() { }
        public object GetProperty(JetBrains.Util.Key propertyName) { }
        public JetBrains.ProjectModel.ISolution GetSolution() { }
        public bool IsValid() { }
        public void PutData<T>(JetBrains.Util.Key<T> key, T val)
            where T :  class { }
        public void SetProperty(JetBrains.Util.Key propertyName, object propertyValue) { }
    }
}
namespace JetBrains.ProjectModel.References
{
    
    public interface IProjectToModuleWithSourcesReference : JetBrains.ProjectModel.IProjectElement, JetBrains.ProjectModel.IProjectModelElement, JetBrains.ProjectModel.IProjectToModuleReference, JetBrains.Util.IUserDataHolder, System.IDisposable { }
    public interface IProjectToSdkReference : JetBrains.ProjectModel.IProjectElement, JetBrains.ProjectModel.IProjectModelElement, JetBrains.ProjectModel.IProjectToModuleReference, JetBrains.ProjectModel.References.IProjectToModuleWithSourcesReference, JetBrains.Util.IUserDataHolder, System.IDisposable
    {
        System.Collections.Generic.ICollection<JetBrains.ProjectModel.IProjectToAssemblyReference> NestedAssemblyReferences { get; }
        JetBrains.ProjectModel.Update.SdkReferences.SdkReferenceInfo SdkReferenceInfo { get; }
    }
    public class static SdkModuleUtil
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.Metadata.Utils.SdkModuleInfo GetSdkModuleInfoFromManifest(string sdkManifestDirectoryPath, string targetConfiguration = null, string targetArchitecture = null) { }
        public static bool IsMetroStyleSdk(this JetBrains.ProjectModel.ISdkModule sdkModule) { }
        public static bool IsWindows8Platform(this JetBrains.Metadata.Utils.TargetPlatformData data) { }
    }
    [JetBrains.ProjectModel.SolutionInstanceComponentAttribute()]
    public class SdkReferencesManager : JetBrains.Application.IChangeProvider
    {
        public static string WindowsSdkName;
        public SdkReferencesManager(JetBrains.ProjectModel.Impl.SolutionElement solution, JetBrains.Application.ChangeManager changeManager, JetBrains.DataFlow.Lifetime lifetime, JetBrains.ProjectModel.impl.NetCoreProvider netCoreProvider) { }
        public void Dump(System.IO.TextWriter textWriter) { }
        public object Execute(JetBrains.Application.IChangeMap changeMap) { }
        protected virtual void FixSdkModuleReferences(JetBrains.ProjectModel.Sdk.SdkModuleImpl referenceOwner, JetBrains.ProjectModel.Impl.SolutionElement solutionElement) { }
        public System.Collections.Generic.ICollection<JetBrains.ProjectModel.References.IProjectToSdkReference> GetAllReferencesToSdkModule(JetBrains.ProjectModel.ISdkModule targetSdkModule) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ProjectModel.References.IProjectToSdkReference GetContainingSdkReference([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IProjectToModuleReference projectToModuleReference) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ProjectModel.ISdkModule GetSdkModule(string identity) { }
        public void InitializeSdkModule(JetBrains.Metadata.Utils.SdkModuleInfo sdkModuleInfo, JetBrains.ProjectModel.Impl.SolutionElement solution, JetBrains.Metadata.Utils.TargetPlatformData targetPlatfromData) { }
        public bool IsNetCoreNestedModule(JetBrains.ProjectModel.IModule module) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ProjectModel.ISdkModule ResolveSdkReference(JetBrains.ProjectModel.References.IProjectToSdkReference reference) { }
    }
}
namespace JetBrains.ProjectModel.Resolver
{
    
    public class static AssemblyNameUtil
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.Metadata.Utils.AssemblyNameInfo GetAssemblyNameInfo(JetBrains.Util.FileSystemPath path, JetBrains.ProjectModel.ISolution solution) { }
    }
    public class SoftAssemblyNameComparer : System.Collections.Generic.IEqualityComparer<JetBrains.Metadata.Utils.AssemblyNameInfo>
    {
        public static JetBrains.ProjectModel.Resolver.SoftAssemblyNameComparer Instance;
        public bool Equals(JetBrains.Metadata.Utils.AssemblyNameInfo x, JetBrains.Metadata.Utils.AssemblyNameInfo y) { }
        public int GetHashCode(JetBrains.Metadata.Utils.AssemblyNameInfo assemblyNameInfo) { }
    }
}
namespace JetBrains.ProjectModel.Resources
{
    
    public sealed class ProjectModelThemedIcons
    {
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.Platform.ReSharper.ProjectModel;component/Resources/ProjectModel.Themed" +
            "Icons/ThemedIcons.ProjectModel.Generated.Xaml", 7, "Assembly")]
        public sealed class Assembly : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.Platform.ReSharper.ProjectModel;component/Resources/ProjectModel.Themed" +
            "Icons/ThemedIcons.ProjectModel.Generated.Xaml", 1, "AssemblyReference")]
        public sealed class AssemblyReference : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.Platform.ReSharper.ProjectModel;component/Resources/ProjectModel.Themed" +
            "Icons/ThemedIcons.ProjectModel.Generated.Xaml", 5, "CsharpProj")]
        public sealed class CsharpProj : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.Platform.ReSharper.ProjectModel;component/Resources/ProjectModel.Themed" +
            "Icons/ThemedIcons.ProjectModel.Generated.Xaml", 10, "CsharpProject")]
        public sealed class CsharpProject : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.Platform.ReSharper.ProjectModel;component/Resources/ProjectModel.Themed" +
            "Icons/ThemedIcons.ProjectModel.Generated.Xaml", 11, "Directory")]
        public sealed class Directory : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.Platform.ReSharper.ProjectModel;component/Resources/ProjectModel.Themed" +
            "Icons/ThemedIcons.ProjectModel.Generated.Xaml", 0, "LayerSolutionPersonal")]
        public sealed class LayerSolutionPersonal : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.Platform.ReSharper.ProjectModel;component/Resources/ProjectModel.Themed" +
            "Icons/ThemedIcons.ProjectModel.Generated.Xaml", 9, "LayerSolutionShared")]
        public sealed class LayerSolutionShared : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.Platform.ReSharper.ProjectModel;component/Resources/ProjectModel.Themed" +
            "Icons/ThemedIcons.ProjectModel.Generated.Xaml", 6, "MissingFile")]
        public sealed class MissingFile : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.Platform.ReSharper.ProjectModel;component/Resources/ProjectModel.Themed" +
            "Icons/ThemedIcons.ProjectModel.Generated.Xaml", 2, "SdkModule")]
        public sealed class SdkModule : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.Platform.ReSharper.ProjectModel;component/Resources/ProjectModel.Themed" +
            "Icons/ThemedIcons.ProjectModel.Generated.Xaml", 12, "SolutionFolder")]
        public sealed class SolutionFolder : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.Platform.ReSharper.ProjectModel;component/Resources/ProjectModel.Themed" +
            "Icons/ThemedIcons.ProjectModel.Generated.Xaml", 8, "Unknown")]
        public sealed class Unknown : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.Platform.ReSharper.ProjectModel;component/Resources/ProjectModel.Themed" +
            "Icons/ThemedIcons.ProjectModel.Generated.Xaml", 3, "VbasicProj")]
        public sealed class VbasicProj : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.Platform.ReSharper.ProjectModel;component/Resources/ProjectModel.Themed" +
            "Icons/ThemedIcons.ProjectModel.Generated.Xaml", 4, "VbasicProject")]
        public sealed class VbasicProject : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
    }
}
namespace JetBrains.ProjectModel.Sdk
{
    
    public class SdkModuleComparer : System.Collections.Generic.IEqualityComparer<JetBrains.ProjectModel.ISdkModule>
    {
        public static System.Collections.Generic.IEqualityComparer<JetBrains.ProjectModel.ISdkModule> Instance { get; }
        public bool Equals(JetBrains.ProjectModel.ISdkModule x, JetBrains.ProjectModel.ISdkModule y) { }
        public int GetHashCode(JetBrains.ProjectModel.ISdkModule obj) { }
    }
    public class SdkModuleImpl : JetBrains.ProjectModel.ProjectFolderImpl, JetBrains.ProjectModel.IModule, JetBrains.ProjectModel.IProject, JetBrains.ProjectModel.IProjectElement, JetBrains.ProjectModel.IProjectFolder, JetBrains.ProjectModel.IProjectItem, JetBrains.ProjectModel.IProjectModelElement, JetBrains.ProjectModel.ISdkModule, JetBrains.Util.IUserDataHolder, System.IDisposable
    {
        public SdkModuleImpl(JetBrains.Metadata.Utils.SdkModuleInfo sdkModuleInfo, JetBrains.ProjectModel.Impl.SolutionElement solution, JetBrains.ProjectModel.Properties.ISdkConsumerProperties projectProperties) { }
        public JetBrains.Util.FileSystemPath ContentRootFolder { get; }
        public System.Guid Guid { get; }
        public override bool IsLinked { get; }
        public bool IsOpened { get; set; }
        public override JetBrains.ProjectModel.ProjectItemKind Kind { get; }
        public override JetBrains.Util.FileSystemPath Location { get; }
        public override string Name { get; }
        public JetBrains.ProjectModel.PlatformID PlatformID { get; }
        public string Presentation { get; }
        public JetBrains.ProjectModel.IProjectFile ProjectFile { get; }
        public JetBrains.Util.FileSystemPath ProjectFileLocation { get; }
        public JetBrains.ProjectModel.Properties.IProjectProperties ProjectProperties { get; }
        public System.Collections.Generic.ICollection<JetBrains.Util.FileSystemPath> SdkContentFiles { get; }
        public string SdkIdentity { get; }
        public JetBrains.Metadata.Utils.SdkModuleInfo SDKModuleInfo { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.Metadata.Utils.TargetPlatformData TargetPlatformData { get; }
        public override void Accept(JetBrains.ProjectModel.ProjectVisitor projectVisitor) { }
        public override void AssertIsValid() { }
        public void Dispose() { }
        public void DoAddSdkToAssemblyReference(JetBrains.ProjectModel.IProjectToModuleReference projectToModuleReference) { }
        public void DoAddSdkToSdkReference(JetBrains.ProjectModel.References.IProjectToSdkReference sdkReferenceImpl) { }
        protected bool Equals(JetBrains.ProjectModel.Sdk.SdkModuleImpl other) { }
        public override bool Equals(object obj) { }
        public override JetBrains.ProjectModel.ProjectModelChange GetChangeDelta(JetBrains.ProjectModel.ProjectModelChangeType changeType) { }
        public override int GetHashCode() { }
        public System.Collections.Generic.IEnumerable<JetBrains.ProjectModel.IProjectToModuleReference> GetModuleReferences() { }
        public JetBrains.Util.FileSystemPath GetOutputDirectory() { }
        public JetBrains.Util.FileSystemPath GetOutputFilePath() { }
        public override JetBrains.ProjectModel.IProject GetProject() { }
        public System.Collections.Generic.ICollection<JetBrains.ProjectModel.IProjectToModuleReference> GetReferences() { }
        public override JetBrains.ProjectModel.ISolution GetSolution() { }
        public bool HasFlavour<T>()
            where T : JetBrains.ProjectModel.Properties.IProjectFlavor { }
        public override bool IsValid() { }
        public void Remove() { }
        public override string ToString() { }
        public override bool WriteProjectFolder(System.IO.BinaryWriter writer, JetBrains.ProjectModel.Impl.ProjectSerializationIndex serializationIndex, JetBrains.Util.FileSystemPath baseLocation) { }
    }
}
namespace JetBrains.ProjectModel.Settings.Cache
{
    
    [JetBrains.Application.ShellComponentAttribute()]
    public class GlobalSettingsCache : JetBrains.Application.Settings.Extentions.SettingsCacheBase
    {
        public GlobalSettingsCache(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.Settings.ISettingsStore settingsStore) { }
    }
    [JetBrains.ProjectModel.ProjectComponentAttribute()]
    public class ProjectSettingsCache : JetBrains.Application.Settings.Extentions.SettingsCacheBase
    {
        public ProjectSettingsCache(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ProjectModel.IProject project, JetBrains.Application.Settings.ISettingsStore settingsStore) { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class SettingsCacheManager
    {
        public SettingsCacheManager(JetBrains.Application.Settings.Extentions.ISettingsCache globalSettingsCache, JetBrains.Application.DataContext.DataContexts dataContexts) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.Application.Settings.Extentions.ISettingsCache GetCache(JetBrains.Application.DataContext.IDataContext dataContext) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.Application.Settings.Extentions.ISettingsCache GetCache([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IProject project) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.Application.Settings.Extentions.ISettingsCache GetCache([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.ISolution solution) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.Application.Settings.Extentions.ISettingsCache GetCache(System.Func<JetBrains.DataFlow.Lifetime, JetBrains.Application.DataContext.DataContexts, JetBrains.Application.DataContext.IDataContext> func) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class SolutionSettingsCache : JetBrains.Application.Settings.Extentions.SettingsCacheBase
    {
        public SolutionSettingsCache(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Settings.ISettingsStore settingsStore, JetBrains.ProjectModel.Settings.Cache.GlobalSettingsCache globalSettingsCache) { }
        protected override bool ContextsHaveDifferencesInternal(System.Func<JetBrains.DataFlow.Lifetime, JetBrains.Application.DataContext.DataContexts, JetBrains.Application.DataContext.IDataContext> dc1, System.Func<JetBrains.DataFlow.Lifetime, JetBrains.Application.DataContext.DataContexts, JetBrains.Application.DataContext.IDataContext> dc2, JetBrains.Application.Settings.SettingsKey key) { }
    }
}
namespace JetBrains.ProjectModel.Settings.Schema
{
    
    [JetBrains.Application.Settings.SettingsKeyAttribute(typeof(JetBrains.ProjectModel.Settings.Schema.HierarchySettings), "Configures solution and project build.")]
    public class BuildSettings { }
    [JetBrains.Application.Settings.SettingsKeyAttribute(typeof(JetBrains.Application.Settings.EnvironmentSettings), "Environment hierarchy settings. In Visual Studio, this is the Solution/Project Mo" +
        "del.")]
    public class HierarchySettings { }
}
namespace JetBrains.ProjectModel.Settings.Storages
{
    
    public class static ProjectModelSettingsStorageMountPointPriorityClasses
    {
        public static readonly double ProjectShared;
        public static readonly double ProjectUser;
        public static readonly double SolutionShared;
        public static readonly double SolutionUser;
    }
    public abstract class ProjectSettingsStorageBase : JetBrains.ProjectModel.Settings.Storages.SettingsStorageProviderBaseInChildContainer
    {
        protected ProjectSettingsStorageBase([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IProject project, bool isPersonal, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Threading.IThreading threading, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.FileSystemTracker.IFileSystemTracker filetracker, JetBrains.Application.Settings.Storage.SettingsStorageProvidersCollection c1, JetBrains.Application.IShellLocks locks, JetBrains.Application.Settings.Storage.Persistence.FileSettingsStorageBehavior behavior, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<JetBrains.DataFlow.PropertyId, object>> metadata, JetBrains.ProjectModel.ProjectLocationLive location) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.Util.FileSystemPath ConvertProjectFilePathToSettingsStoragePath(string projectName, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.Util.FileSystemPath projectLocation, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.Util.FileSystemPath projectFilePath, JetBrains.Application.Configuration.XmlExternalizationScope scope) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.Util.FileSystemPath GetLegacySettingsFilePath([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IProject project, JetBrains.Application.Configuration.XmlExternalizationScope scope, JetBrains.Application.IApplicationDescriptor product) { }
    }
    [JetBrains.ProjectModel.ProjectComponentAttribute()]
    public class ProjectSettingsStoragePersonal : JetBrains.ProjectModel.Settings.Storages.ProjectSettingsStorageBase
    {
        public ProjectSettingsStoragePersonal([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IProject project, JetBrains.Threading.IThreading a, JetBrains.Application.FileSystemTracker.IFileSystemTracker b, JetBrains.Application.Settings.Storage.SettingsStorageProvidersCollection c, JetBrains.Application.IShellLocks d, JetBrains.Application.Settings.Storage.Persistence.FileSettingsStorageBehavior e, JetBrains.ProjectModel.ProjectLocationLive f) { }
    }
    [JetBrains.ProjectModel.ProjectComponentAttribute()]
    public class ProjectSettingsStorageShared : JetBrains.ProjectModel.Settings.Storages.ProjectSettingsStorageBase
    {
        public ProjectSettingsStorageShared([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IProject project, JetBrains.Threading.IThreading a, JetBrains.Application.FileSystemTracker.IFileSystemTracker b, JetBrains.Application.Settings.Storage.SettingsStorageProvidersCollection c, JetBrains.Application.IShellLocks d, JetBrains.Application.Settings.Storage.Persistence.FileSettingsStorageBehavior e, JetBrains.ProjectModel.ProjectLocationLive f) { }
    }
    public abstract class SettingsStorageProviderBaseInChildContainer : JetBrains.Application.Settings.Storage.FileSettingsStorageProviderBase
    {
        protected SettingsStorageProviderBaseInChildContainer([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] string name, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.IProperty<JetBrains.Util.FileSystemPath> path, bool isWritable, double priority, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.IIsAvailable isAvailable, JetBrains.Application.Settings.Storage.Persistence.SettingsStoreSerializationToXmlDiskFile.SavingEmptyContent whenNoContent, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Threading.IThreading threading, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.FileSystemTracker.IFileSystemTracker filetracker, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.Storage.Persistence.FileSettingsStorageBehavior behavior, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.Storage.SettingsStorageProvidersCollection expose, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<JetBrains.DataFlow.PropertyId, object>> metadata = null) { }
    }
    public abstract class SolutionSettingsStorageBase : JetBrains.ProjectModel.Settings.Storages.SettingsStorageProviderBaseInChildContainer
    {
        protected SolutionSettingsStorageBase([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.ISolution solution, bool isPersonal, JetBrains.Threading.IThreading c1, JetBrains.Application.FileSystemTracker.IFileSystemTracker c2, JetBrains.Application.Settings.Storage.SettingsStorageProvidersCollection expose, JetBrains.Application.IShellLocks c3, JetBrains.Application.Settings.Storage.Persistence.FileSettingsStorageBehavior c4, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<JetBrains.DataFlow.PropertyId, object>> metadata, JetBrains.ProjectModel.SolutionFileLocationLive c5) { }
    }
    [JetBrains.ProjectModel.SolutionInstanceComponentAttribute()]
    public class SolutionSettingsStoragePersonal : JetBrains.ProjectModel.Settings.Storages.SolutionSettingsStorageBase
    {
        public SolutionSettingsStoragePersonal([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.ISolution solution, JetBrains.Threading.IThreading c1, JetBrains.Application.FileSystemTracker.IFileSystemTracker c2, JetBrains.Application.Settings.Storage.SettingsStorageProvidersCollection c3, JetBrains.Application.IShellLocks c4, JetBrains.Application.Settings.Storage.Persistence.FileSettingsStorageBehavior c5, JetBrains.ProjectModel.SolutionFileLocationLive c6, JetBrains.UI.Icons.IThemedIconManager iconman) { }
    }
    [JetBrains.ProjectModel.SolutionInstanceComponentAttribute()]
    public class SolutionSettingsStorageShared : JetBrains.ProjectModel.Settings.Storages.SolutionSettingsStorageBase
    {
        public SolutionSettingsStorageShared([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.ISolution solution, JetBrains.Threading.IThreading c1, JetBrains.Application.FileSystemTracker.IFileSystemTracker c2, JetBrains.Application.Settings.Storage.SettingsStorageProvidersCollection c3, JetBrains.Application.IShellLocks c4, JetBrains.Application.Settings.Storage.Persistence.FileSettingsStorageBehavior c5, JetBrains.ProjectModel.SolutionFileLocationLive c6, JetBrains.UI.Icons.IThemedIconManager iconman) { }
    }
}
namespace JetBrains.ProjectModel.Settings.Store
{
    
    [JetBrains.ProjectModel.ProjectComponentAttribute()]
    public class ProjectSettings
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly System.Func<JetBrains.Application.Settings.IContextBoundSettingsStore> BindForWritingToProjectShared;
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly JetBrains.Application.Settings.UserInterface.UserFriendlySettingsLayer.Identity ProjectPersonalLayerId;
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly JetBrains.Application.Settings.UserInterface.UserFriendlySettingsLayer.Identity ProjectSharedLayerId;
        public ProjectSettings(JetBrains.ProjectModel.IProject project, JetBrains.ProjectModel.Settings.Storages.ProjectSettingsStorageShared shared, JetBrains.ProjectModel.Settings.Storages.ProjectSettingsStoragePersonal personal, JetBrains.Application.Settings.ISettingsStore store) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class SolutionSettings
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly System.Func<JetBrains.Application.Settings.IContextBoundSettingsStore> BindForWritingToSolutionShared;
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly JetBrains.Application.Settings.UserInterface.UserFriendlySettingsLayer.Identity SolutionPersonalLayerId;
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly JetBrains.Application.Settings.UserInterface.UserFriendlySettingsLayer.Identity SolutionSharedLayerId;
        public SolutionSettings(JetBrains.ProjectModel.ISolution solution, JetBrains.ProjectModel.Settings.Storages.SolutionSettingsStorageShared shared, JetBrains.ProjectModel.Settings.Storages.SolutionSettingsStoragePersonal personal, JetBrains.Application.Settings.ISettingsStore store) { }
    }
}
namespace JetBrains.ProjectModel.Settings.Upgrade
{
    
    public interface IProjectSettingsUpgrader : JetBrains.Application.Configuration.Upgrade.ISettingsUpgrader
    {
        void Upgrade(JetBrains.Application.Configuration.IComponentSettingsProvider legacySettingsProvider, JetBrains.Application.Settings.IContextBoundSettingsStore boundSettingsStore, JetBrains.DataFlow.Lifetime upgradeLifetime);
    }
    public interface ISolutionSettingsUpgrader : JetBrains.Application.Configuration.Upgrade.ISettingsUpgrader
    {
        void Upgrade(JetBrains.Application.Configuration.IComponentSettingsProvider legacySettingsProvider, JetBrains.Application.Settings.IContextBoundSettingsStore boundSettingsStore, JetBrains.DataFlow.Lifetime upgradeLifetime);
    }
    [JetBrains.ProjectModel.ProjectComponentAttribute(JetBrains.Application.Components.ProgramConfigurations.NONE | JetBrains.Application.Components.ProgramConfigurations.VS_ADDIN | JetBrains.Application.Components.ProgramConfigurations.ALL)]
    public class ProjectSettingsUpgrade : JetBrains.Application.Configuration.Upgrade.SettingsUpgradeBase<JetBrains.ProjectModel.Settings.Upgrade.IProjectSettingsUpgrader, JetBrains.ProjectModel.Settings.Upgrade.ProjectSettingsUpgraderAttribute>
    {
        public ProjectSettingsUpgrade(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.Components.IComponentContainer parentContainer, JetBrains.Application.Parts.IPartsCatalogueSet catalogueSet, JetBrains.Application.Settings.ISettingsStore settingsStore, JetBrains.ProjectModel.IProject project, JetBrains.Application.Env.RunsProducts.ProductConfigurations productConfigurations, JetBrains.Application.Settings.UserInterface.ResetSettings resetSettings, JetBrains.ProjectModel.Settings.Store.ProjectSettings projectSettings, JetBrains.Application.IApplicationDescriptor applicationDescriptor) { }
        protected override JetBrains.Application.Configuration.IComponentSettingsProvider CreateLegacySettingsComponent() { }
        protected override void DoUpgrade(JetBrains.ProjectModel.Settings.Upgrade.IProjectSettingsUpgrader settingsUpgrader, JetBrains.Application.Configuration.IComponentSettingsProvider solutionSettingsComponent, JetBrains.Application.Settings.IContextBoundSettingsStore boundSettingsStore, JetBrains.DataFlow.Lifetime upgradeLifetime) { }
        protected override JetBrains.Application.Settings.SettingsScalarEntry IsUpgradedFlagEntry(JetBrains.Application.Settings.ISettingsSchema schema) { }
    }
    [JetBrains.Application.Settings.SettingsKeyAttribute(typeof(JetBrains.Application.Settings.HousekeepingSettings), "Project Settings Upgraded")]
    public class ProjectSettingsUpgradedSettingsKey
    {
        [JetBrains.Application.Settings.SettingsEntryAttribute(false, "Project Settings Upgraded")]
        public bool IsUpgraded;
    }
    [JetBrains.Annotations.BaseTypeRequiredAttribute(typeof(JetBrains.ProjectModel.Settings.Upgrade.IProjectSettingsUpgrader))]
    [JetBrains.Annotations.MeansImplicitUseAttribute()]
    [System.AttributeUsageAttribute(System.AttributeTargets.Class | System.AttributeTargets.All)]
    public class ProjectSettingsUpgraderAttribute : JetBrains.Application.Parts.PartAttribute { }
    [JetBrains.ProjectModel.SolutionComponentAttribute(JetBrains.Application.Components.ProgramConfigurations.NONE | JetBrains.Application.Components.ProgramConfigurations.VS_ADDIN | JetBrains.Application.Components.ProgramConfigurations.ALL)]
    public class SolutionSettingsUpgrade : JetBrains.Application.Configuration.Upgrade.SettingsUpgradeBase<JetBrains.ProjectModel.Settings.Upgrade.ISolutionSettingsUpgrader, JetBrains.ProjectModel.Settings.Upgrade.SolutionSettingsUpgraderAttribute>
    {
        public SolutionSettingsUpgrade(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.Components.IComponentContainer parentContainer, JetBrains.Application.Parts.IPartsCatalogueSet catalogueSet, JetBrains.Application.Settings.ISettingsStore settingsStore, JetBrains.ProjectModel.ISolution solution, JetBrains.ProjectModel.Model2.Transaction.IEnsureWritableHandler ensureWritableHandler, JetBrains.Application.IApplicationDescriptor applicationDescriptor, JetBrains.Application.Env.RunsProducts.ProductConfigurations productConfigurations, JetBrains.Application.IShellLocks locks, JetBrains.Application.Settings.UserInterface.ResetSettings resetSettings, JetBrains.ProjectModel.Settings.Store.SolutionSettings solutionSettings) { }
        public JetBrains.Application.Settings.ISettingsStore SettingsStore { get; }
        protected override JetBrains.Application.Configuration.IComponentSettingsProvider CreateLegacySettingsComponent() { }
        protected override void DoUpgrade(JetBrains.ProjectModel.Settings.Upgrade.ISolutionSettingsUpgrader settingsUpgrader, JetBrains.Application.Configuration.IComponentSettingsProvider solutionSettingsComponent, JetBrains.Application.Settings.IContextBoundSettingsStore boundSettingsStore, JetBrains.DataFlow.Lifetime upgradeLifetime) { }
        protected override JetBrains.Application.Settings.SettingsScalarEntry IsUpgradedFlagEntry(JetBrains.Application.Settings.ISettingsSchema schema) { }
    }
    [JetBrains.Application.Settings.SettingsKeyAttribute(typeof(JetBrains.Application.Settings.HousekeepingSettings), "Solution Settings Upgraded")]
    public class SolutionSettingsUpgradedSettingsKey
    {
        [JetBrains.Application.Settings.SettingsEntryAttribute(false, "Solution Settings Upgraded")]
        public bool IsUpgraded;
    }
    [JetBrains.Annotations.BaseTypeRequiredAttribute(typeof(JetBrains.ProjectModel.Settings.Upgrade.ISolutionSettingsUpgrader))]
    [JetBrains.Annotations.MeansImplicitUseAttribute()]
    [System.AttributeUsageAttribute(System.AttributeTargets.Class | System.AttributeTargets.All)]
    public class SolutionSettingsUpgraderAttribute : JetBrains.Application.Parts.PartAttribute { }
}
namespace JetBrains.ProjectModel.Sharepoint
{
    
    public interface ISharepointDeploymentTypeTracker
    {
        JetBrains.ProjectModel.Sharepoint.SharepointDeploymentType GetDeploymentType([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IProjectFile projectFile);
    }
    public interface ISharepointFilesLocator
    {
        JetBrains.Util.FileSystemPath PredefinedControlTemplatesPath { get; }
        JetBrains.Util.FileSystemPath PredefinedLayoutsPath { get; }
        JetBrains.Util.FileSystemPath PredefinedMasterFilesFolderPath { get; }
        JetBrains.Util.FileSystemPath PredefinedResourcesFolderPath { get; }
        JetBrains.Util.FileSystemPath WebConfigPath { get; }
    }
    public enum SharepointDeploymentType : byte
    {
        NoDeployment = 0,
        ElementManifest = 1,
        ElementFile = 2,
        TemplateFile = 3,
        RootFile = 4,
        ClassResource = 5,
        ApplicationResource = 6,
        AppGlobalResource = 7,
        PackageOnly = 8,
        Resource = 9,
        DwpFile = 10,
    }
    public class SharepointDeploymentTypeProperty { }
    public class static SharepointDeploymentTypeTracker
    {
        public static JetBrains.ProjectModel.Sharepoint.SharepointDeploymentType GetDeploymentType([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ProjectModel.IProjectFile projectFile) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class SharepointDeploymentTypeTrackerImpl : JetBrains.ProjectModel.Sharepoint.ISharepointDeploymentTypeTracker
    {
        public SharepointDeploymentTypeTrackerImpl(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ProjectModel.ISolution solution, JetBrains.Application.ChangeManager changeManager, JetBrains.Application.IShellLocks locks, JetBrains.ProjectModel.Transaction.IProjectModelBatchChangeManager batchChangeManager, JetBrains.ProjectModel.impl.ViewableProjectsCollection projectsCollection) { }
        public JetBrains.ProjectModel.Sharepoint.SharepointDeploymentType GetDeploymentType(JetBrains.ProjectModel.IProjectFile projectFile) { }
        [JetBrains.Annotations.NotNullAttribute()]
        protected JetBrains.Util.FileSystemPath GetSpdataFilePath(JetBrains.Util.FileSystemPath location) { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class SharepointFilesLocatorImpl : JetBrains.ProjectModel.Sharepoint.ISharepointFilesLocator
    {
        public SharepointFilesLocatorImpl() { }
        public JetBrains.Util.FileSystemPath PredefinedControlTemplatesPath { get; }
        public JetBrains.Util.FileSystemPath PredefinedLayoutsPath { get; }
        public JetBrains.Util.FileSystemPath PredefinedMasterFilesFolderPath { get; }
        public JetBrains.Util.FileSystemPath PredefinedResourcesFolderPath { get; }
        public JetBrains.Util.FileSystemPath WebConfigPath { get; }
        protected virtual JetBrains.Util.FileSystemPath InitializeRootPath() { }
        protected virtual void InitilizeIfNecessary() { }
    }
}
namespace JetBrains.ProjectModel.SolutionFileParser
{
    
    public interface ISlnFile
    {
        string ErrorMessage { get; }
        JetBrains.ProjectModel.Impl.SolutionFormatVersion FormatVersion { get; }
        JetBrains.Util.OneToListMap<string, JetBrains.ProjectModel.SolutionFileParser.SlnFileGlobalSection> GlobalSections { get; }
        bool HasErrors { get; }
        System.Collections.Generic.List<JetBrains.ProjectModel.SolutionFileParser.SlnFileProject> Projects { get; }
        void Dump(System.IO.TextWriter writer);
    }
    public class SlnFileGlobalSection
    {
        public SlnFileGlobalSection(string name, string value) { }
        public string Name { get; }
        public JetBrains.Util.OneToListMap<string, string> Properties { get; }
        public string Value { get; }
        public void AddProperty(string name, string value) { }
        public void Dump(System.IO.TextWriter writer, string indent) { }
    }
    public class SlnFileProject
    {
        public SlnFileProject(string projectName, System.Guid projectGuid, System.Guid projectTypeGuid, string projectLocation, JetBrains.Util.FileSystemPath solutionFilePath) { }
        public System.Guid ProjectGuid { get; }
        public string ProjectName { get; }
        public JetBrains.Util.OneToListMap<string, JetBrains.ProjectModel.SolutionFileParser.SlnFileProjectSection> ProjectSections { get; }
        public System.Guid ProjectTypeGuid { get; }
        public JetBrains.Util.FileSystemPath SolutionFilePath { get; }
        public void Dump(System.IO.TextWriter writer, string indent) { }
        public JetBrains.Util.FileSystemPath GetLocation() { }
    }
    public class SlnFileProjectSection
    {
        public SlnFileProjectSection(string sectionName, string sectionValue) { }
        public JetBrains.Util.OneToListMap<string, string> Properties { get; }
        public string SectionName { get; }
        public string SectionValue { get; }
        public void AddProperty(string name, string value) { }
        public void Dump(System.IO.TextWriter writer, string indent) { }
    }
    public class SolutionFileParser : JetBrains.ProjectModel.SolutionFileParser.ISlnFile
    {
        public const string VSSolutionExtension = ".sln";
        public string ErrorMessage { get; }
        public JetBrains.ProjectModel.Impl.SolutionFormatVersion FormatVersion { get; }
        public JetBrains.Util.OneToListMap<string, JetBrains.ProjectModel.SolutionFileParser.SlnFileGlobalSection> GlobalSections { get; }
        public bool HasErrors { get; }
        public System.Collections.Generic.List<JetBrains.ProjectModel.SolutionFileParser.SlnFileProject> Projects { get; }
        public void Dump(System.IO.TextWriter writer) { }
        public static JetBrains.ProjectModel.SolutionFileParser.ISlnFile ParseFile(JetBrains.Util.FileSystemPath solutionFilePath) { }
    }
}
namespace JetBrains.ProjectModel.Standalone
{
    
    public interface IProjectImporter
    {
        JetBrains.ProjectModel.IProject AddProject(JetBrains.ProjectModel.Impl.SolutionElement solution, JetBrains.Util.FileSystemPath projectLocation);
        bool ImportSolution(JetBrains.ProjectModel.Impl.SolutionElement solution, JetBrains.Util.FileSystemPath solutionFilePath);
    }
    public interface ISpecificProjectImporter
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ProjectModel.IProject ImportProject(JetBrains.ProjectModel.Impl.SolutionElement solutionElement, JetBrains.ProjectModel.SolutionFileParser.SlnFileProject project, JetBrains.ProjectModel.PlatformID defaultPlatformId);
    }
}
namespace JetBrains.ProjectModel.Standalone.WebSite
{
    
    public class WebSiteProjectImporter : JetBrains.ProjectModel.Standalone.ISpecificProjectImporter
    {
        public WebSiteProjectImporter(JetBrains.Application.IShellLocks locks) { }
        public JetBrains.ProjectModel.IProject ImportProject(JetBrains.ProjectModel.Impl.SolutionElement solutionElement, JetBrains.ProjectModel.SolutionFileParser.SlnFileProject slnProject, JetBrains.ProjectModel.PlatformID defaultPlatformId) { }
    }
}
namespace JetBrains.ProjectModel.Tasks
{
    
    public interface ISolutionLoadTasksScheduler
    {
        void ClearTasks();
        void DispatchTasks(bool background);
        void EnqueueTask(JetBrains.ProjectModel.Tasks.SolutionLoadTask task);
        void EnqueueWaitTask(JetBrains.ProjectModel.Tasks.SolutionLoadWaitHandle waitHandle);
        JetBrains.Util.DataStructures.OrderedDictionary<JetBrains.ProjectModel.Tasks.SolutionLoadTaskKinds, JetBrains.ProjectModel.Tasks.SolutionLoadTaskKindTime> GetTimePerTaskKind();
        JetBrains.ProjectModel.Tasks.SolutionLoadTaskKindTime GetTotalTime();
        void ResetTime();
        void ResumeWaitTask(JetBrains.ProjectModel.Tasks.SolutionLoadWaitHandle waitHandle, bool background);
    }
    public class SolutionLoadTask
    {
        public SolutionLoadTask(string name, JetBrains.ProjectModel.Tasks.SolutionLoadTaskKinds kind, System.Action action) { }
        public System.Action ActionToExecute { get; }
        public JetBrains.ProjectModel.Tasks.SolutionLoadTaskKinds Kind { get; }
        public string TaskName { get; }
    }
    public enum SolutionLoadTaskKinds
    {
        LoadSolutionFromCache = 0,
        WaitInitialSynchronizeSolution = 1,
        InitialSynchronizeSolution = 2,
        SolutionContainer = 3,
        FireProjectItemsAdded = 4,
        FireAssembliesAdded = 5,
        PreparePsiModules = 6,
        BeforeKickOff = 7,
        KickOff = 8,
        StartPsi = 9,
        WaitFinalSynchronizeSolution = 10,
        FinalSynchronizeSolution = 11,
        RefreshBuildSettings = 12,
        Done = 13,
        AfterDone = 14,
    }
    public class SolutionLoadTaskKindTime
    {
        public long MaxMilliseconds;
        public int TaskCount;
        public long TotalMilliseconds;
        public SolutionLoadTaskKindTime() { }
        public void AddTaskTime(long taskMilliseconds) { }
    }
    public abstract class SolutionLoadTasksSchedulerBase : JetBrains.ProjectModel.Tasks.ISolutionLoadTasksScheduler
    {
        protected bool myIsStarted;
        protected readonly JetBrains.Application.IShellLocks myLocks;
        protected SolutionLoadTasksSchedulerBase(JetBrains.Application.IShellLocks locks) { }
        protected int Count { get; }
        public void ClearTasks() { }
        public virtual void DispatchTasks(bool background) { }
        public void EnqueueTask(JetBrains.ProjectModel.Tasks.SolutionLoadTask task) { }
        public virtual void EnqueueWaitTask(JetBrains.ProjectModel.Tasks.SolutionLoadWaitHandle waitHandle) { }
        protected void ExecuteOneTask(JetBrains.ProjectModel.Tasks.SolutionLoadTask task) { }
        protected JetBrains.ProjectModel.Tasks.SolutionLoadTask FetchTaskFromQueue() { }
        public JetBrains.Util.DataStructures.OrderedDictionary<JetBrains.ProjectModel.Tasks.SolutionLoadTaskKinds, JetBrains.ProjectModel.Tasks.SolutionLoadTaskKindTime> GetTimePerTaskKind() { }
        public JetBrains.ProjectModel.Tasks.SolutionLoadTaskKindTime GetTotalTime() { }
        protected virtual void Pause() { }
        public void ResetTime() { }
        public void ResumeWaitTask(JetBrains.ProjectModel.Tasks.SolutionLoadWaitHandle waitHandle, bool background) { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class SolutionLoadTasksSchedulerSync : JetBrains.ProjectModel.Tasks.SolutionLoadTasksSchedulerBase
    {
        public SolutionLoadTasksSchedulerSync(JetBrains.Application.IShellLocks locks) { }
    }
    public class SolutionLoadWaitHandle
    {
        public SolutionLoadWaitHandle(JetBrains.ProjectModel.Tasks.SolutionLoadTaskKinds kind, string taskName) { }
        public JetBrains.ProjectModel.Tasks.SolutionLoadTaskKinds Kind { get; }
        public string TaskName { get; }
    }
}
namespace JetBrains.ProjectModel.Transaction.Actions
{
    
    public abstract class AddFileAction : JetBrains.ProjectModel.Model2.Transaction.Actions.TransactionActionBase, JetBrains.ProjectModel.ITransactionAction
    {
        protected AddFileAction([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IProjectFolder parentFolder, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.FileSystemPath location, JetBrains.Application.IShellLocks locks) { }
        public JetBrains.ProjectModel.IProjectFile AddedFile { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ProjectModel.IProjectFile> AffectedProjectFiles { get; }
        protected JetBrains.Util.FileSystemPath Location { get; }
        protected JetBrains.ProjectModel.IProjectFolder ParentFolder { get; }
        public abstract void Commit();
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ProjectModel.IProjectFile Prepare() { }
        public void Rollback() { }
    }
}
namespace JetBrains.ProjectModel.Transaction
{
    
    public class BeforeChangesCommitsEventArgs : System.EventArgs
    {
        public BeforeChangesCommitsEventArgs(JetBrains.ProjectModel.Transaction.IProjectModelBatchChange projectModelBatchChange) { }
        public JetBrains.ProjectModel.Transaction.IProjectModelBatchChange ProjectModelBatchChange { get; }
    }
    public delegate void BeforeChangesCommitsEventHandler(JetBrains.ProjectModel.Transaction.BeforeChangesCommitsEventArgs args);
    public interface IProjectModelBatchChange
    {
        void Commit(JetBrains.Application.Progress.ITaskExecutor executor);
        System.Collections.Generic.IList<JetBrains.ProjectModel.ProjectModelChange> GetChanges();
    }
    public interface IProjectModelBatchChangeManager
    {
        public event JetBrains.ProjectModel.Transaction.BeforeChangesCommitsEventHandler BeforeChangesCommits;
        void AddChanges(JetBrains.ProjectModel.ProjectModelChange[] deltas);
        JetBrains.ProjectModel.Transaction.IProjectModelBatchChange BeginBatchChange(bool notifyChangeManager = True);
    }
    public class ProjectModelBatchChangeCookie : System.IDisposable
    {
        public ProjectModelBatchChangeCookie([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.Transaction.IProjectModelBatchChangeManager batchChangeManager, bool notifyChangeManger, JetBrains.Application.Progress.ITaskExecutor taskExecutor) { }
        public ProjectModelBatchChangeCookie(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.ITaskExecutor taskExecutor) { }
        public void Dispose() { }
    }
    public sealed class ProjectModelBatchChangeManager : JetBrains.ProjectModel.Transaction.IProjectModelBatchChangeManager
    {
        public ProjectModelBatchChangeManager(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.ChangeManager changeManager, JetBrains.Application.IShellLocks locks, JetBrains.ProjectModel.IWritableProjectModelTimestamps timestamps) { }
        public event JetBrains.ProjectModel.Transaction.BeforeChangesCommitsEventHandler BeforeChangesCommits;
        public void AddChanges(JetBrains.ProjectModel.ProjectModelChange[] deltas) { }
        public JetBrains.ProjectModel.Transaction.IProjectModelBatchChange BeginBatchChange(bool notifyChangeManager = True) { }
        public void OnBeforeTransactionCommits(JetBrains.ProjectModel.Transaction.BeforeChangesCommitsEventArgs e) { }
    }
    public class static ProjectModelChangeUtil
    {
        public static void AddPropertyChange([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.Transaction.IProjectModelBatchChangeManager batchChangeManager, JetBrains.ProjectModel.IProjectItem item, string propetyName, object oldValue, object newValue) { }
        public static void OnChange([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.Transaction.IProjectModelBatchChangeManager batchChangeManager, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.ProjectModelChange changeDelta) { }
    }
}
namespace JetBrains.ProjectModel.Update
{
    
    public interface IProjectDescriptor : JetBrains.ProjectModel.Update.IProjectFolderDescriptor, JetBrains.ProjectModel.Update.IProjectItemDescriptor
    {
        System.Guid Guid { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ProjectModel.Update.IProjectPointer ParentProjectPointer { get; }
        JetBrains.Util.FileSystemPath ProjectFilePath { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ProjectModel.Properties.IProjectProperties ProjectProperties { get; }
    }
    public interface IProjectFileDescriptor : JetBrains.ProjectModel.Update.IProjectItemDescriptor
    {
        JetBrains.Util.FileSystemPath Location { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ProjectModel.Properties.IProjectFileProperties Properties { get; }
    }
    public interface IProjectFolderDescriptor : JetBrains.ProjectModel.Update.IProjectItemDescriptor
    {
        bool IsHidden { get; }
        System.Collections.Generic.IList<JetBrains.ProjectModel.Update.IProjectItemDescriptor> Items { get; }
        JetBrains.Util.FileSystemPath Location { get; }
        string Name { get; }
    }
    public interface IProjectItemDescriptor { }
    public interface IProjectPointer
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ProjectModel.IProject ResolveProject();
    }
    public interface IProjectReferenceDescriptor { }
    public interface IProjectReferenceProperties
    {
        string AliasList { get; }
        bool AutoReferenced { get; }
        bool CopyLocal { get; }
        bool EmbedInteropTypes { get; }
    }
    public interface IProjectReferenceToken
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ProjectModel.IProjectToModuleReference CreateProjectReference(JetBrains.ProjectModel.IProject project);
    }
    public interface ISdkReferenceToken : JetBrains.ProjectModel.Update.IProjectReferenceToken { }
    public class LateWriteLockCookie : System.IDisposable
    {
        public LateWriteLockCookie(JetBrains.Application.IShellLocks locks, JetBrains.ProjectModel.Transaction.IProjectModelBatchChangeManager batchChangeManager, bool notifyChangeManager) { }
        public bool NotifyChangeManager { get; }
        public void AcquireWriteLockIfNecessary() { }
        public void Dispose() { }
    }
    public class ProjectDescriptor : JetBrains.ProjectModel.Update.IProjectDescriptor, JetBrains.ProjectModel.Update.IProjectFolderDescriptor, JetBrains.ProjectModel.Update.IProjectItemDescriptor
    {
        public System.Guid Guid { get; }
        public bool IsHidden { get; set; }
        public System.Collections.Generic.IList<JetBrains.ProjectModel.Update.IProjectItemDescriptor> Items { get; }
        public JetBrains.Util.FileSystemPath Location { get; }
        public string Name { get; }
        public JetBrains.ProjectModel.Update.IProjectPointer ParentProjectPointer { get; set; }
        public JetBrains.Util.FileSystemPath ProjectFilePath { get; }
        public JetBrains.ProjectModel.Properties.IProjectProperties ProjectProperties { get; }
        public static JetBrains.ProjectModel.Update.ProjectDescriptor CreateByProjectFile(System.Guid guid, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.Properties.IProjectProperties projectProperties, JetBrains.ProjectModel.Update.IProjectPointer parentProjectPointer, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.Update.IProjectFileDescriptor projectFileDescriptor) { }
        public static JetBrains.ProjectModel.Update.ProjectDescriptor CreateByProjectLocation(System.Guid guid, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.Properties.IProjectProperties projectProperties, JetBrains.ProjectModel.Update.IProjectPointer parentProjectPointer, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.FileSystemPath projectFolder, [JetBrains.Annotations.CanBeNullAttribute()] string projectName = null) { }
        public static JetBrains.ProjectModel.Update.ProjectDescriptor CreateByProjectName(System.Guid guid, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.Properties.IProjectProperties projectProperties, JetBrains.ProjectModel.Update.IProjectPointer parentProjectPointer, string projectName) { }
    }
    public class ProjectFileDescriptor : JetBrains.ProjectModel.Update.IProjectFileDescriptor, JetBrains.ProjectModel.Update.IProjectItemDescriptor
    {
        public ProjectFileDescriptor([JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.FileSystemPath location, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.Properties.IProjectFileProperties properties) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.Util.FileSystemPath Location { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ProjectModel.Properties.IProjectFileProperties Properties { get; set; }
    }
    public class ProjectFolderDescriptor : JetBrains.ProjectModel.Update.IProjectFolderDescriptor, JetBrains.ProjectModel.Update.IProjectItemDescriptor
    {
        public ProjectFolderDescriptor(string name, JetBrains.Util.FileSystemPath location, params JetBrains.ProjectModel.Update.IProjectItemDescriptor[] items) { }
        public ProjectFolderDescriptor(JetBrains.Util.FileSystemPath location, params JetBrains.ProjectModel.Update.IProjectItemDescriptor[] items) { }
        public bool IsHidden { get; set; }
        public System.Collections.Generic.IList<JetBrains.ProjectModel.Update.IProjectItemDescriptor> Items { get; }
        public JetBrains.Util.FileSystemPath Location { get; }
        public string Name { get; }
    }
    [JetBrains.ProjectModel.SolutionInstanceComponentAttribute()]
    public class ProjectModelUpdater
    {
        public ProjectModelUpdater(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ProjectModel.Impl.SolutionElement solution, JetBrains.Application.IShellLocks locks, JetBrains.ProjectModel.Update.ProjectReferenceFactory referenceFactory, JetBrains.ProjectModel.Transaction.IProjectModelBatchChangeManager batchChangeManager, JetBrains.ProjectModel.impl.SpecialFiles.SpecialFilesManager specialFilesManager, JetBrains.ProjectModel.Caches.ProjectFileDataCache projectFileDataCache) { }
        protected JetBrains.ProjectModel.Impl.SolutionElement Solution { get; }
        protected virtual JetBrains.ProjectModel.IProjectFolder CreateFolder(JetBrains.ProjectModel.Update.LateWriteLockCookie lateWriteLockCookie, JetBrains.ProjectModel.IProjectFolder parentFolder, JetBrains.ProjectModel.Update.IProjectFolderDescriptor folderDescriptor) { }
        protected virtual JetBrains.ProjectModel.IProject CreateProject(JetBrains.ProjectModel.Update.LateWriteLockCookie lateWriteLockCookie, JetBrains.ProjectModel.Update.IProjectDescriptor descriptor) { }
        protected virtual JetBrains.ProjectModel.IProjectFile CreateProjectFile(JetBrains.ProjectModel.Update.LateWriteLockCookie lateWriteLockCookie, JetBrains.ProjectModel.IProjectFolder parentFolder, JetBrains.ProjectModel.Update.IProjectFileDescriptor fileDescriptor) { }
        protected virtual JetBrains.ProjectModel.IProjectFile CreateProjectFileForProject(JetBrains.ProjectModel.Update.LateWriteLockCookie lateWriteLockCookie, JetBrains.ProjectModel.IProject project, JetBrains.ProjectModel.Update.IProjectFileDescriptor fileDescriptor) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public virtual JetBrains.ProjectModel.IProject FindProject(JetBrains.ProjectModel.Update.IProjectDescriptor descriptor) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public virtual JetBrains.ProjectModel.IProjectToModuleReference FindProjectReference(JetBrains.ProjectModel.IProject project, JetBrains.ProjectModel.Update.IProjectReferenceDescriptor referenceDescriptor) { }
        protected virtual void UpdateFolderContent(JetBrains.ProjectModel.Update.LateWriteLockCookie lateWriteLockCookie, JetBrains.ProjectModel.IProjectFolder folder, JetBrains.ProjectModel.Update.IProjectFolderDescriptor descriptor, JetBrains.ProjectModel.Update.UpdateFlags flags) { }
        public virtual JetBrains.ProjectModel.IProject UpdateOrCreateProject([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.Update.IProjectDescriptor projectDescriptor, JetBrains.ProjectModel.Update.UpdateFlags flags) { }
        protected virtual JetBrains.ProjectModel.IProject UpdateOrCreateProject(JetBrains.ProjectModel.Update.LateWriteLockCookie lateWriteLockCookie, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.Update.IProjectDescriptor descriptor, JetBrains.ProjectModel.Update.UpdateFlags flags) { }
        public virtual void UpdateOrCreateProjects(System.Collections.Generic.IEnumerable<JetBrains.ProjectModel.Update.IProjectDescriptor> projectDescriptors, JetBrains.ProjectModel.Update.UpdateFlags flags) { }
        protected virtual bool UpdateProject(JetBrains.ProjectModel.Update.LateWriteLockCookie lateWriteLockCookie, JetBrains.ProjectModel.IProject project, JetBrains.ProjectModel.Update.IProjectDescriptor descriptor, JetBrains.ProjectModel.Update.UpdateFlags flags) { }
        public virtual void UpdateProjectReferences(JetBrains.ProjectModel.IProject project, System.Collections.Generic.ICollection<JetBrains.Util.Pair<JetBrains.ProjectModel.Update.IProjectReferenceDescriptor, JetBrains.ProjectModel.Update.IProjectReferenceProperties>> referenceDescriptors, bool notifyChangeManager) { }
    }
    public class ProjectPointer : JetBrains.ProjectModel.Update.IProjectPointer
    {
        public ProjectPointer(JetBrains.ProjectModel.IProject project) { }
        public JetBrains.ProjectModel.IProject ResolveProject() { }
    }
    public class ProjectPointerByProjectDescriptor : JetBrains.ProjectModel.Update.IProjectPointer
    {
        public readonly JetBrains.ProjectModel.Update.IProjectDescriptor ProjectDescriptor;
        public ProjectPointerByProjectDescriptor([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.Update.IProjectDescriptor projectDescriptor, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.Update.ProjectModelUpdater updater) { }
        public JetBrains.ProjectModel.IProject ResolveProject() { }
    }
    public class ProjectPointerByProjectFilePath : JetBrains.ProjectModel.Update.IProjectPointer
    {
        public ProjectPointerByProjectFilePath(JetBrains.Util.FileSystemPath referencedProjectFilePath, JetBrains.ProjectModel.ISolution solution) { }
        public JetBrains.ProjectModel.IProject ResolveProject() { }
    }
    public class ProjectPointerByProjectModelElementPointer : JetBrains.ProjectModel.Update.IProjectPointer
    {
        public ProjectPointerByProjectModelElementPointer(JetBrains.ProjectModel.IProjectModelElementPointer pointer, JetBrains.ProjectModel.ProjectModelElementPointerManager manager) { }
        public JetBrains.ProjectModel.IProject ResolveProject() { }
    }
    [JetBrains.ProjectModel.SolutionInstanceComponentAttribute()]
    public class ProjectReferenceFactory
    {
        public ProjectReferenceFactory(JetBrains.ProjectModel.References.Impl.SdkReferenceFactory sdkReferenceFactory) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public virtual JetBrains.ProjectModel.Update.IProjectReferenceToken DescriptorToToken(JetBrains.ProjectModel.Update.IProjectReferenceDescriptor descriptor) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public virtual JetBrains.ProjectModel.Update.IProjectReferenceToken ReferenceToToken(JetBrains.ProjectModel.IProjectToModuleReference reference) { }
    }
    public class ProjectReferenceProperties : JetBrains.ProjectModel.Update.IProjectReferenceProperties
    {
        public ProjectReferenceProperties() { }
        public string AliasList { get; set; }
        public bool AutoReferenced { get; set; }
        public bool CopyLocal { get; set; }
        public bool EmbedInteropTypes { get; set; }
    }
    public class ProjectToAssemblyReferenceDescriptor : JetBrains.ProjectModel.Update.IProjectReferenceDescriptor, JetBrains.ProjectModel.Update.IProjectReferenceToken
    {
        public ProjectToAssemblyReferenceDescriptor([JetBrains.Annotations.NotNullAttribute()] JetBrains.Metadata.Utils.AssemblyNameInfo assemblyName, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.FileSystemPath hintPath) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.Metadata.Utils.AssemblyNameInfo AssemblyName { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.Util.FileSystemPath HintPath { get; }
        public JetBrains.ProjectModel.IProjectToModuleReference CreateProjectReference(JetBrains.ProjectModel.IProject project) { }
        public bool Equals(JetBrains.ProjectModel.Update.ProjectToAssemblyReferenceDescriptor other) { }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
    }
    public class ProjectToComAssemblyReferenceDescriptor : JetBrains.ProjectModel.Update.IProjectReferenceDescriptor, JetBrains.ProjectModel.Update.IProjectReferenceToken
    {
        public readonly JetBrains.Util.FileSystemPath ManifestFilePath;
        public ProjectToComAssemblyReferenceDescriptor(JetBrains.Util.FileSystemPath manifestFilePath) { }
        public JetBrains.ProjectModel.IProjectToModuleReference CreateProjectReference(JetBrains.ProjectModel.IProject project) { }
        protected bool Equals(JetBrains.ProjectModel.Update.ProjectToComAssemblyReferenceDescriptor other) { }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
    }
    public class ProjectToProjectReferenceByGuidDescriptor : JetBrains.ProjectModel.Update.IProjectReferenceDescriptor, JetBrains.ProjectModel.Update.IProjectReferenceToken
    {
        public ProjectToProjectReferenceByGuidDescriptor(string projectName, System.Guid projectGuid) { }
        public System.Guid ProjectGuid { get; }
        public string ProjectName { get; }
        public JetBrains.ProjectModel.IProjectToModuleReference CreateProjectReference(JetBrains.ProjectModel.IProject project) { }
        public bool Equals(JetBrains.ProjectModel.Update.ProjectToProjectReferenceByGuidDescriptor other) { }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
    }
    public class ProjectToProjectReferenceByPointerDescriptor : JetBrains.ProjectModel.Update.IProjectReferenceDescriptor, JetBrains.ProjectModel.Update.IProjectReferenceToken
    {
        public ProjectToProjectReferenceByPointerDescriptor([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.Update.IProjectPointer projectPointer) { }
        public JetBrains.ProjectModel.Update.IProjectPointer ProjectPointer { get; }
        public JetBrains.ProjectModel.IProjectToModuleReference CreateProjectReference(JetBrains.ProjectModel.IProject project) { }
        public bool Equals(JetBrains.ProjectModel.Update.ProjectToProjectReferenceByPointerDescriptor other) { }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
    }
    [System.FlagsAttribute()]
    public enum UpdateFlags
    {
        NONE = 0,
        F_UPDATE_PROJECT_PROPERTIES = 1,
        F_CREATE_MISSING_ITEMS = 2,
        F_REMOVE_REDUNDAND_FILES_AND_FOLDERS = 4,
        F_REMOVE_REDUNDAND_NESTED_PROJECTS = 8,
        F_NOTIFY_CHANGE_MANGER = 256,
        CREATE_MISSING_ITEMS = 2,
        ASL_STARTUP_SYNC = 7,
        FULL_SYNC = 15,
        FULL_SYNC_NOTIFY_CHANGE_MANAGER = 271,
    }
    public class static UpdateFlagsExtension
    {
        public static bool CreateMissingItems(this JetBrains.ProjectModel.Update.UpdateFlags flags) { }
        public static bool NotifyChangeManager(this JetBrains.ProjectModel.Update.UpdateFlags flags) { }
        public static bool SynchronizeFilesAndFolders(this JetBrains.ProjectModel.Update.UpdateFlags flags) { }
        public static bool SynchronizeNestedProjects(this JetBrains.ProjectModel.Update.UpdateFlags flags) { }
        public static bool UpdateProjectProperties(this JetBrains.ProjectModel.Update.UpdateFlags flags) { }
    }
}
namespace JetBrains.ProjectModel.Update.SdkReferences
{
    
    public class ProjectToSdkReferenceDescriptor : JetBrains.ProjectModel.Update.IProjectReferenceDescriptor, JetBrains.ProjectModel.Update.IProjectReferenceToken, JetBrains.ProjectModel.Update.ISdkReferenceToken
    {
        public ProjectToSdkReferenceDescriptor([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.References.Impl.SdkReferenceFactory sdkReferenceFactory, [JetBrains.Annotations.NotNullAttribute()] string sdkName, [JetBrains.Annotations.NotNullAttribute()] string sdkManifestPath) { }
        public ProjectToSdkReferenceDescriptor([JetBrains.Annotations.NotNullAttribute()] string sdkName, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.FileSystemPath sdkManifestPath, [JetBrains.Annotations.NotNullAttribute()] System.Func<JetBrains.ProjectModel.IProject, JetBrains.ProjectModel.References.Impl.SdkReferenceFactory> getSdkReferenceFactory) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.Util.FileSystemPath ManifestPath { get; }
        public JetBrains.ProjectModel.IProjectToModuleReference CreateProjectReference(JetBrains.ProjectModel.IProject project) { }
        protected bool Equals(JetBrains.ProjectModel.Update.SdkReferences.ProjectToSdkReferenceDescriptor other) { }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.Metadata.Utils.SdkModuleInfo GetSdkModuleInfo(string targetArchitecture = null) { }
        public override string ToString() { }
    }
    public class SdkReferenceInfo
    {
        public SdkReferenceInfo(string sdkName, string sdkVersion, string sdkManifestPath, string identity = null) { }
        public string Identity { get; }
        public string PersistentName { get; }
        public string SdkManifestPath { get; }
        public string SdkName { get; }
        public string SdkVersion { get; }
        public void Dump(System.IO.TextWriter textWriter, int indent) { }
    }
}
namespace JetBrains.ReSharper.Psi
{
    
    public enum CachesLocationType
    {
        SOLUTION_FOLDER = 0,
        TEMP_FOLDER = 1,
        LOCAL_APPDATA_FOLER = 2,
    }
    [JetBrains.Application.Settings.SettingsKeyAttribute(typeof(JetBrains.ProjectModel.Settings.Schema.HierarchySettings), "PSI configuration settings", KeyNameOverride="PsiConfigurationSettingsKey")]
    public class PsiConfigurationSettingsKey
    {
        [JetBrains.Application.Settings.SettingsEntryAttribute(JetBrains.ReSharper.Psi.CachesLocationType.LOCAL_APPDATA_FOLER, "Cache folder location type")]
        public JetBrains.ReSharper.Psi.CachesLocationType LocationType;
    }
    [System.ObsoleteAttribute()]
    public class PsiConfigurationSettingsObsolete : JetBrains.Application.Configuration.IXmlReadable
    {
        public PsiConfigurationSettingsObsolete(JetBrains.Application.Configuration.IComponentSettingsProvider settings) { }
        public JetBrains.ReSharper.Psi.CachesLocationType Location { get; }
        public void ReadFromXml(System.Xml.XmlElement element) { }
    }
    [JetBrains.Application.Configuration.Upgrade.GlobalSettingsUpgraderAttribute()]
    public class PsiConfigurationSettingsUpgrader : JetBrains.Application.Configuration.Upgrade.IGlobalSettingsUpgrader, JetBrains.Application.Configuration.Upgrade.ISettingsUpgrader
    {
        public void Upgrade(JetBrains.Application.Configuration.IComponentSettingsProvider legacySettingsProvider, JetBrains.Application.Settings.IContextBoundSettingsStore boundSettingsStore, JetBrains.DataFlow.Lifetime upgradeLifetime) { }
    }
}