[assembly: JetBrains.UI.Icons.CompiledIcons.CompiledIconsPackAttribute(IconNames=new string[] {
        "AspHtmlTagAttributeValue",
        "AspDirective",
        "AspDirectiveAttribute"}, IconPackResourceIdentification="JetBrains.ReSharper.Psi.Web;component/resources/PsiWebThemedIcons/ThemedIcons.Psi" +
    "Web.Generated.Xaml")]
[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]
[assembly: System.Windows.Markup.XmlnsDefinitionAttribute("urn:shemas-jetbrains-com:ui-application-icons-psi-web", "JetBrains.ReSharper.Psi.Web.Resources")]

namespace JetBrains.ReSharper.Psi.Web
{
    
    public enum AspNetVersion : ushort
    {
        Unknown = 65535,
        Version10 = 10,
        Version11 = 11,
        Version20 = 20,
        Version30 = 30,
        Version35 = 35,
        Version40 = 40,
        Version45 = 45,
    }
    public interface IVersionRestricted
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        System.Nullable<JetBrains.ReSharper.Psi.Web.AspNetVersion> SupportedVersion { get; }
    }
    public interface IWebProjectFileLanguageService : JetBrains.ReSharper.Psi.IProjectFileLanguageService
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.PsiLanguageType GetCodeBehindLanguage(JetBrains.Text.IBuffer buffer);
    }
    public abstract class WebCodeBehindSecondaryLexerProcess : JetBrains.ReSharper.Psi.ExtensionsAPI.ISecondaryLexingProcess
    {
        protected readonly JetBrains.ReSharper.Psi.PsiLanguageType myCodeBehindLanguage;
        protected JetBrains.ReSharper.Psi.Parsing.MixedLexer myParentLexer;
        protected WebCodeBehindSecondaryLexerProcess(JetBrains.ProjectModel.ProjectFileType projectFileType, JetBrains.ReSharper.Psi.Web.Util.WebPsiLanguageUtil webPsiLanguageUtil, JetBrains.ReSharper.Psi.Parsing.MixedLexer parentLexer, JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile = null) { }
        public bool CanHandle(JetBrains.ProjectModel.ProjectFileType projectFileType) { }
        public abstract JetBrains.ReSharper.Psi.Parsing.ILexer TryCreateCodeBehindLexer(JetBrains.ReSharper.Psi.Parsing.ILexer baseLexer);
    }
    [JetBrains.ProjectModel.ProjectComponentAttribute(JetBrains.Application.Components.ProgramConfigurations.NONE | JetBrains.Application.Components.ProgramConfigurations.TEST | JetBrains.Application.Components.ProgramConfigurations.COMMAND_LINE | JetBrains.Application.Components.ProgramConfigurations.ALL, ProjectKinds=JetBrains.ProjectModel.ProjectKind.UNSUPPORTED | JetBrains.ProjectModel.ProjectKind.WEB_SITE)]
    public class WebsiteTargetFrameworkUpdater : System.IDisposable
    {
        public readonly JetBrains.ProjectModel.IProject Project;
        public WebsiteTargetFrameworkUpdater(JetBrains.ProjectModel.IProject project, JetBrains.ReSharper.Psi.Web.Cache.IWebConfigCache webConfigCache) { }
        public System.Version OriginalVersion { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        protected virtual System.Version FixNewTargetFramework(System.Version targetFramework) { }
        protected virtual void UpdateTargetFramework(System.Version targetFramework) { }
    }
    public class static WebSymbolTable<T>
        where T :  class, JetBrains.ReSharper.Psi.Web.Symbols.IWebSymbol
    {
        public static JetBrains.ReSharper.Psi.Resolve.ISymbolTable Create(JetBrains.ProjectModel.ISolution solution, System.Converter<T, JetBrains.ReSharper.Psi.IDeclaredElement> getDeclaredElement) { }
        public static JetBrains.ReSharper.Psi.Resolve.ISymbolTable Create(JetBrains.ReSharper.Psi.IPsiSourceFile psiSourceFile, System.Converter<T, JetBrains.ReSharper.Psi.IDeclaredElement> getDeclaredElement) { }
    }
}
namespace JetBrains.ReSharper.Psi.Web.BuildProviders
{
    
    public interface IWebsiteBuildEngine
    {
        JetBrains.ReSharper.Psi.Web.BuildProviders.WebsiteBuildResult ExecuteBuild(JetBrains.DataFlow.Lifetime buildLifetime, string folderBaseName, JetBrains.Util.FileSystemPath targetPath, JetBrains.Util.FileSystemPath outputPath, string logName);
    }
    public interface IWebsiteBuildEngineFactory
    {
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Web.BuildProviders.IWebsiteBuildEngine CreateWebsiteBuilder([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IProject project);
    }
    public interface IWebsiteBuilder
    {
        JetBrains.DataFlow.ISimpleSignal GeneratedFilesChanged { get; }
        JetBrains.Util.FileSystemPath GeneratedFilesDirectory { get; }
        void RebuildWebsite();
    }
    public interface IWebsiteBuilderFactory
    {
        JetBrains.ReSharper.Psi.Web.BuildProviders.IWebsiteBuilder CreateWebsiteBuilder(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ReSharper.Psi.Web.BuildProviders.IWebsiteBuildRequestor requestor);
    }
    public interface IWebsiteBuilders
    {
        JetBrains.ReSharper.Psi.Web.BuildProviders.IWebsiteBuilder GetOrCreateBuildProvidersSupportManager(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ProjectModel.IProject project);
        JetBrains.ReSharper.Psi.Web.BuildProviders.IWebsiteBuilder GetOrCreateWebReferencesSupportManager(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ProjectModel.IProject project);
    }
    public interface IWebsiteBuildRequestor
    {
        string LogName { get; }
        JetBrains.ProjectModel.IProject Project { get; }
        void BeforeBuildStarted();
        bool IsPrimaryFile(JetBrains.ProjectModel.IProjectFile file, JetBrains.ReSharper.Psi.Web.Impl.BuildProviders.WebFolders folders);
        bool IsSignificantFile(JetBrains.ProjectModel.IProjectFile file, JetBrains.ReSharper.Psi.Web.Impl.BuildProviders.WebFolders folders);
        bool IsSupplementaryFile(JetBrains.ProjectModel.IProjectFile file, JetBrains.ReSharper.Psi.Web.Impl.BuildProviders.WebFolders folders);
        System.Collections.Generic.Dictionary<JetBrains.Util.FileSystemPath, string> OnBuildFinished(System.Collections.Generic.Dictionary<JetBrains.Util.FileSystemPath, long> primaryFiles, System.Collections.Generic.Dictionary<JetBrains.Util.FileSystemPath, long> supplementaryFiles, JetBrains.ReSharper.Psi.Web.BuildProviders.WebsiteBuildResult buildResult, JetBrains.Util.FileSystemPath targetPath, JetBrains.Util.FileSystemPath outputPath, JetBrains.Util.FileSystemPath tempDirPath);
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class WebsiteBuildEngineFactory : JetBrains.ReSharper.Psi.Web.BuildProviders.IWebsiteBuildEngineFactory
    {
        public WebsiteBuildEngineFactory(JetBrains.ProjectModel.PlatformManager platformManager) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ReSharper.Psi.Web.BuildProviders.IWebsiteBuildEngine CreateWebsiteBuilder([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IProject project) { }
    }
    public enum WebsiteBuildResult
    {
        CANNOT_BUILD = 0,
        SUCCEDED = 1,
        FINISHED_WITH_ERRORS = 2,
        FAILED = 3,
    }
}
namespace JetBrains.ReSharper.Psi.Web.Cache
{
    
    public class EmptyWebConfigProjectFileChangeBuilder : JetBrains.ReSharper.Psi.Web.Cache.IWebConfigProjectFileChangeBuilder, System.IDisposable
    {
        public static readonly JetBrains.ReSharper.Psi.Web.Cache.EmptyWebConfigProjectFileChangeBuilder Instance;
        public bool WillRaiseChangesIfAny { get; }
        public void AddChange(JetBrains.ProjectModel.IProjectFile projectFile, JetBrains.ReSharper.Psi.Web.Cache.WebConfigChangeType changeType) { }
        public void Dispose() { }
    }
    public class HttpHandlerInfo
    {
        public readonly string FullTypeName;
        public readonly string Path;
        public HttpHandlerInfo(string path, string fullTypeName) { }
        public bool ContainsWildcards { get; }
        public System.Text.RegularExpressions.Regex PathRegex { get; }
    }
    public interface IImportedNamespaces
    {
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.IList<string> GetNamespaces(JetBrains.ProjectModel.ProjectFileType language);
        System.Collections.Generic.IEnumerable<string> GetPreimportedNamespaces();
    }
    public interface IWebConfigCache
    {
        JetBrains.DataFlow.ISignal<System.Collections.Generic.ICollection<JetBrains.Util.JetTuple<JetBrains.ProjectModel.IProjectFile, JetBrains.Util.FileSystemPath, JetBrains.ReSharper.Psi.Web.Cache.WebConfigChangeType>>> ProjectFilesChanged { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Web.Cache.IWebConfigCompoundData GetCompoundDataBeforeWebConfig(JetBrains.ProjectModel.IProjectFile webConfigFile);
        System.Collections.Generic.IEnumerable<JetBrains.ProjectModel.IProjectFile> GetConfigFiles([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ProjectModel.IProjectItem projectItem);
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Web.Cache.WebConfigData GetData([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IProjectItem projectItem);
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Web.Cache.WebConfigData GetEmptyData([JetBrains.Annotations.NotNullAttribute()] JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext resolveContext);
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Web.Cache.WebConfigData GetRootData([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IModule module, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext resolveContext);
    }
    public interface IWebConfigCompoundData
    {
        JetBrains.ReSharper.Psi.Web.Cache.WebConfigData GetData([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IModule module, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext resolveContext, JetBrains.Util.FileSystemPath targetPath);
    }
    public interface IWebConfigProjectFileChangeBuilder : System.IDisposable
    {
        bool WillRaiseChangesIfAny { get; }
        void AddChange(JetBrains.ProjectModel.IProjectFile projectFile, JetBrains.ReSharper.Psi.Web.Cache.WebConfigChangeType changeType);
    }
    public enum PageParserFilterType
    {
        NOT_USED = 0,
        CUSTOM = 1,
        CUSTOM_AND_MVC_IS_REFERENCED = 2,
        MVC = 3,
        OPEN_RASTA = 4,
    }
    public abstract class TagPrefixesInfo
    {
        public abstract JetBrains.Util.OneToListMap<JetBrains.ReSharper.Psi.Web.Cache.TagPrefixesInfo.TagPrefixNamePair, JetBrains.Util.Pair<JetBrains.Util.FileSystemPath, string>> FullTagNameToPathMap { get; }
        public abstract JetBrains.Util.OneToListMap<string, string> PrefixToNamespaceMap { get; }
        public class TagPrefixNamePair
        {
            public readonly string Name;
            public readonly string Prefix;
            public TagPrefixNamePair(string prefix, string name) { }
            public bool Equals(JetBrains.ReSharper.Psi.Web.Cache.TagPrefixesInfo.TagPrefixNamePair other) { }
            public override bool Equals(object obj) { }
            public override int GetHashCode() { }
        }
    }
    public class static WebConfigCache
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.ReSharper.Psi.Web.Cache.WebConfigData GetData([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IPsiSourceFile psiSourceFile) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.ReSharper.Psi.Web.Cache.WebConfigData GetData([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IProject project) { }
        public static JetBrains.ReSharper.Psi.Web.Cache.IWebConfigCache GetInstance(JetBrains.ReSharper.Psi.IPsiSourceFile psiSourceFile) { }
        public static JetBrains.ReSharper.Psi.Web.Cache.IWebConfigCache GetInstance(JetBrains.ProjectModel.ISolution solution) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.ReSharper.Psi.Web.Cache.WebConfigData GetRootData([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IModule module, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext resolveContext) { }
    }
    public enum WebConfigChangeType
    {
        ADDED = 0,
        REMOVED = 1,
        MODIFIED = 2,
    }
    public abstract class WebConfigData
    {
        public const string DEFAULT_PROFILE_PROVIDER = "AspNetSqlProfileProvider";
        public static readonly System.Collections.Generic.Dictionary<string, string> DefaultBuildProviders;
        public const string IGNORE_BUILD_PROVIDER = "System.Web.Compilation.IgnoreFileBuildProvider";
        public const string RESX_DEFAULT_BUILD_PROVIDER = "System.Web.Compilation.ResXBuildProvider";
        public abstract System.Collections.Generic.IEnumerable<JetBrains.Util.FileSystemPath> AdditionalConfigs { get; }
        public abstract bool AutoEventWireup { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public abstract JetBrains.ReSharper.Psi.PsiLanguageType CodeBehindLanguage { get; }
        public abstract System.Collections.Generic.IList<string> CodeSubDirectories { get; }
        public abstract JetBrains.Util.OneToSetMap<string, string> CustomBuildProviders { get; }
        public abstract JetBrains.Util.OneToSetMap<string, string> CustomProfileProviders { get; }
        public abstract bool Explicit { get; }
        public abstract bool HasProfile { get; }
        public abstract System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Web.Cache.HttpHandlerInfo> HttpHandlers { get; }
        public abstract JetBrains.ReSharper.Psi.Web.Cache.IImportedNamespaces ImportedNamespaces { get; }
        public abstract bool IsMonorail { get; }
        public abstract string MasterPageFile { get; }
        public abstract System.Collections.Generic.IEnumerable<JetBrains.Util.FileSystemPath> ReferenceProbingRelativePath { get; }
        public abstract JetBrains.ReSharper.Psi.Web.Cache.WebProjectReferencesInfo ReferencesInfo { get; }
        public abstract bool Strict { get; }
        public abstract string StyleSheetTheme { get; }
        public abstract System.Collections.Generic.IEnumerable<JetBrains.Util.Pair<string, string>> TagMappings { get; }
        public abstract JetBrains.ReSharper.Psi.Web.Cache.TagPrefixesInfo TagPrefixes { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public abstract System.Version TargetFramework { get; }
        public abstract string Theme { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public abstract System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.PreProcessingDirective> GetAllPreprocessorDefines();
        [JetBrains.Annotations.NotNullAttribute()]
        public abstract JetBrains.Util.OneToListMap<string, string> GetExpressionBuilders();
        public abstract JetBrains.ReSharper.Psi.IType GetMappedType([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IType type, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Modules.IPsiModule psiModule);
        [JetBrains.Annotations.NotNullAttribute()]
        public abstract System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.PreProcessingDirective> GetPreprocessorDefines(string extensionWithDot);
        [JetBrains.Annotations.CanBeNullAttribute()]
        public abstract string GetRazorBasePageType(bool isCSharp);
        [JetBrains.Annotations.CanBeNullAttribute()]
        public abstract string GetResourceProviderFactoryType();
        public abstract JetBrains.ReSharper.Psi.Web.Cache.PageParserFilterType GetUsedPageParserFilterType([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Modules.IPsiModule psiModule);
        [JetBrains.Annotations.CanBeNullAttribute()]
        public abstract JetBrains.ReSharper.Psi.IType ResolveBasePageType([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Modules.IPsiModule psiModule);
        [JetBrains.Annotations.CanBeNullAttribute()]
        public abstract JetBrains.ReSharper.Psi.IType ResolveUserControlBaseType([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Modules.IPsiModule psiModule);
    }
    public abstract class WebConfigProjectFileCacheBase<T>
        where T :  class
    {
        protected readonly JetBrains.ProjectModel.ISolution mySolution;
        protected WebConfigProjectFileCacheBase(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ProjectModel.ISolution solution, JetBrains.Application.IShellLocks shellLocks) { }
        protected JetBrains.Application.IShellLocks Locks { get; set; }
        public JetBrains.DataFlow.ISignal<System.Collections.Generic.ICollection<JetBrains.Util.JetTuple<JetBrains.ProjectModel.IProjectFile, JetBrains.Util.FileSystemPath, JetBrains.ReSharper.Psi.Web.Cache.WebConfigChangeType>>> ProjectFilesChanged { get; }
        protected JetBrains.ReSharper.Psi.IPsiServices PsiServices { get; }
        protected abstract bool CanHandle(JetBrains.ProjectModel.IProjectFile projectFile);
        protected abstract T CreateFileData(JetBrains.ProjectModel.IProjectFile projectFile);
        protected abstract T CreateFileData(string configText);
        protected JetBrains.ReSharper.Psi.Web.Cache.WebConfigProjectFileCacheBase<T>.Entry GetEntry([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ProjectModel.IProjectFile file) { }
        protected JetBrains.ReSharper.Psi.Web.Cache.WebConfigProjectFileCacheBase<T>.Entry GetEntrySafe(JetBrains.ProjectModel.IProjectFile file) { }
        protected void InvalidateFiles(System.Func<JetBrains.ProjectModel.IProjectFile, bool> predicate, System.Action<JetBrains.ProjectModel.IProjectFile, JetBrains.Util.FileSystemPath, JetBrains.ReSharper.Psi.Web.Cache.WebConfigChangeType> changeBuilder) { }
        protected void InvalidateFilesInFolder(JetBrains.ProjectModel.IProject project, JetBrains.Util.FileSystemPath folder, System.Action<JetBrains.ProjectModel.IProjectFile, JetBrains.Util.FileSystemPath, JetBrains.ReSharper.Psi.Web.Cache.WebConfigChangeType> changeBuilder) { }
        public void InvalidateProjectFile([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IProjectFile changedFile, System.Action<JetBrains.ProjectModel.IProjectFile, JetBrains.Util.FileSystemPath, JetBrains.ReSharper.Psi.Web.Cache.WebConfigChangeType> changeBuilder) { }
        protected void InvalidateSingleFile(JetBrains.ProjectModel.IProjectFile changedFile, System.Action<JetBrains.ProjectModel.IProjectFile, JetBrains.Util.FileSystemPath, JetBrains.ReSharper.Psi.Web.Cache.WebConfigChangeType> changeBuilder) { }
        protected virtual void OnFileAdded(JetBrains.ProjectModel.IProjectFile projectFile, System.Action<JetBrains.ProjectModel.IProjectFile, JetBrains.Util.FileSystemPath, JetBrains.ReSharper.Psi.Web.Cache.WebConfigChangeType> changeBuilder) { }
        protected virtual void OnFileDeleted(JetBrains.ProjectModel.IProjectFile projectFile, JetBrains.Util.FileSystemPath oldPath, System.Action<JetBrains.ProjectModel.IProjectFile, JetBrains.Util.FileSystemPath, JetBrains.ReSharper.Psi.Web.Cache.WebConfigChangeType> changeBuilder) { }
        protected virtual void OnFileModified(JetBrains.ProjectModel.IProjectFile projectFile, System.Action<JetBrains.ProjectModel.IProjectFile, JetBrains.Util.FileSystemPath, JetBrains.ReSharper.Psi.Web.Cache.WebConfigChangeType> changeBuilder) { }
        public virtual void OnProjectModelChange(JetBrains.ProjectModel.ProjectModelChange change, System.Action<JetBrains.ProjectModel.IProjectFile, JetBrains.Util.FileSystemPath, JetBrains.ReSharper.Psi.Web.Cache.WebConfigChangeType> changeBuilder) { }
        protected class Entry<T>
            where T :  class
        {
            public Entry(T fileData) { }
            public T FileData { get; set; }
            public JetBrains.ReSharper.Psi.Web.Cache.WebConfigProjectFileCacheBase<T>.EntryState State { get; set; }
        }
        protected enum EntryState<T>
            where T :  class
        {
            DATA_INVALID = 0,
            DATA_VALID = 1,
            COMITTED = 2,
        }
    }
    public class WebConfigProjectFileChangeBuilder : JetBrains.ReSharper.Psi.Web.Cache.IWebConfigProjectFileChangeBuilder, System.IDisposable
    {
        public WebConfigProjectFileChangeBuilder(JetBrains.DataFlow.ISignal<System.Collections.Generic.ICollection<JetBrains.Util.Pair<JetBrains.ProjectModel.IProjectFile, JetBrains.ReSharper.Psi.Web.Cache.WebConfigChangeType>>> signal) { }
        public bool WillRaiseChangesIfAny { get; }
        public void AddChange(JetBrains.ProjectModel.IProjectFile projectFile, JetBrains.ReSharper.Psi.Web.Cache.WebConfigChangeType changeType) { }
        public void Dispose() { }
    }
    public abstract class WebProjectReferencesInfo
    {
        public static readonly string[] Default30Assemblies;
        public static readonly string[] DefaultAssemblies;
        public abstract bool ClearDefault { get; }
        public abstract System.Collections.Generic.IEnumerable<string> ReferencesToAdd { get; }
        public abstract System.Collections.Generic.IEnumerable<string> ReferencesToRemove { get; }
        public abstract System.Collections.Generic.IEnumerable<JetBrains.Metadata.Utils.AssemblyNameInfo> RuntimeReferences { get; }
    }
    public abstract class WebSymbolType : JetBrains.Util.EnumPattern
    {
        protected WebSymbolType(string name) { }
    }
}
namespace JetBrains.ReSharper.Psi.Web.CodeBehindSupport
{
    
    public class static CodeBehindSupportUtils
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.ReSharper.Psi.Tree.IFile GetOriginalFile([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Tree.ITreeNode treeNode) { }
        public static JetBrains.ReSharper.Psi.TreeTextRange<JetBrains.ReSharper.Psi.Original> GetOriginalTreeTextRange(JetBrains.ReSharper.Psi.Tree.ITreeNode generatedNode) { }
        public static JetBrains.ReSharper.Psi.TreeTextRange<JetBrains.ReSharper.Psi.Original> GetOriginalTreeTextRange(JetBrains.ReSharper.Psi.TreeTextRange<JetBrains.ReSharper.Psi.Generated> generatedTreeRange, JetBrains.ReSharper.Psi.Impl.Shared.RangeTranslatorWithGeneratedRangeMap rangeTranslator) { }
        public static JetBrains.Util.Pair<JetBrains.ReSharper.Psi.TreeTextRange<JetBrains.ReSharper.Psi.Original>, System.Collections.Generic.List<JetBrains.ReSharper.Psi.TreeTextRange<JetBrains.ReSharper.Psi.Original>>> GetOriginalTreeTextRangeAndItsParts(JetBrains.ReSharper.Psi.Tree.ITreeNode generatedNode) { }
        public static JetBrains.Util.Pair<JetBrains.ReSharper.Psi.TreeTextRange<JetBrains.ReSharper.Psi.Original>, System.Collections.Generic.List<JetBrains.ReSharper.Psi.TreeTextRange<JetBrains.ReSharper.Psi.Original>>> GetOriginalTreeTextRangeAndItsParts(JetBrains.ReSharper.Psi.TreeTextRange<JetBrains.ReSharper.Psi.Generated> generatedTreeRange, JetBrains.ReSharper.Psi.Impl.Shared.RangeTranslatorWithGeneratedRangeMap rangeTranslator) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.ReSharper.Psi.Impl.Shared.RangeTranslatorWithGeneratedRangeMap GetRangeTranslator([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Tree.IFile generatedFile) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.ReSharper.Psi.Impl.Shared.RangeTranslatorWithGeneratedRangeMap GetRangeTranslator([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Tree.ITreeNode treeNode) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Psi.Impl.Shared.RangeTranslatorWithGeneratedRangeMap GetRangeTranslatorNullable([JetBrains.Annotations.CanBeNullAttribute()] this JetBrains.ReSharper.Psi.Tree.IFile generatedFile) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Psi.Impl.Shared.RangeTranslatorWithGeneratedRangeMap GetRangeTranslatorNullable([JetBrains.Annotations.CanBeNullAttribute()] this JetBrains.ReSharper.Psi.Tree.ITreeNode treeNode) { }
    }
    public abstract class CustomModificationHandler<TInlineCodeBlock, TUsingDirective>
        where TInlineCodeBlock :  class, JetBrains.ReSharper.Psi.Tree.ITreeNode
        where TUsingDirective :  class, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        protected CustomModificationHandler(JetBrains.ReSharper.Psi.ILanguageManager languageManager) { }
        protected JetBrains.ReSharper.Psi.ILanguageManager LanguageManager { get; }
        protected abstract void AddSuperClassDirectiveToOriginalFile(JetBrains.ReSharper.Psi.Tree.IFile originalFile, JetBrains.ReSharper.Psi.Tree.ITreeNode anchor, JetBrains.ReSharper.Psi.Tree.ITreeNode superClassGeneratedNode);
        protected abstract TInlineCodeBlock CreateInlineCodeBlock(string text, JetBrains.ReSharper.Psi.Tree.ITreeNode anchor);
        protected abstract JetBrains.ReSharper.Psi.Tree.ITreeNode CreateNewLineToken(JetBrains.ReSharper.Psi.Modules.IPsiModule psiModule);
        protected abstract JetBrains.ReSharper.Psi.TreeTextRange CreateTypeMemberNode(JetBrains.ReSharper.Psi.Tree.IFile originalFile, string text, JetBrains.ReSharper.Psi.Tree.ITreeNode first, JetBrains.ReSharper.Psi.Tree.ITreeNode last);
        protected abstract JetBrains.ReSharper.Psi.TreeTextRange CreateUsingNode(bool before, TUsingDirective anchor, JetBrains.ReSharper.Psi.Tree.ITreeNode usingDirective, JetBrains.ReSharper.Psi.Tree.IFile originalFile);
        protected void FinishAddStatementsRange(JetBrains.ReSharper.Psi.ITreeRange treeRange, bool before) { }
        public virtual JetBrains.ReSharper.Psi.Tree.ITreeNode FixupAnchorForAddingTypeMember(JetBrains.ReSharper.Psi.IPsiServices psiServices, JetBrains.ReSharper.Psi.Tree.IFile generatedFile, JetBrains.ReSharper.Psi.Tree.ITreeNode anchor, bool willInsertBefore, JetBrains.ReSharper.Psi.Tree.ITreeNode classDeclaration) { }
        protected abstract JetBrains.ReSharper.Psi.TreeTextRange GetCodeTreeTextRange(TInlineCodeBlock codeBlock);
        protected abstract JetBrains.ReSharper.Psi.TreeTextRange GetExistingTypeMembersRange(JetBrains.ReSharper.Psi.Tree.IFile originalFile);
        protected virtual JetBrains.ReSharper.Psi.Impl.Shared.MappedRangeType GetImportRangeType() { }
        protected abstract JetBrains.ReSharper.Psi.TreeTextRange GetNameRange(JetBrains.ReSharper.Psi.Tree.ITreeNode usingDirective);
        public static System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Tree.ITreeNode> GetNodesInRange(JetBrains.ReSharper.Psi.Tree.ITreeNode node, JetBrains.ReSharper.Psi.TreeTextRange range) { }
        public static void GetStatementsInfo(JetBrains.ReSharper.Psi.ITreeRange treeRange, out JetBrains.ReSharper.Psi.TreeTextRange dstRange, out string text) { }
        protected abstract JetBrains.ReSharper.Psi.Tree.ITreeNode GetSuperClassNodeFromOriginalFile(JetBrains.ReSharper.Psi.Tree.IFile originalFile);
        protected JetBrains.ReSharper.Psi.Tree.ITreeNode HandleAddImportInternal(JetBrains.ReSharper.Psi.IPsiServices psiServices, System.Func<JetBrains.ReSharper.Psi.Tree.ITreeNode> action, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode generatedCodeAnchor, bool before, JetBrains.ReSharper.Psi.PsiLanguageType language, JetBrains.ReSharper.Psi.Tree.IFile generatedFile) { }
        public virtual JetBrains.ReSharper.Psi.Tree.ITreeNode HandleAddTypeMember(JetBrains.ReSharper.Psi.IPsiServices psiServices, System.Func<JetBrains.ReSharper.Psi.Tree.ITreeNode> action, JetBrains.ReSharper.Psi.Tree.IFile generatedFile) { }
        protected virtual JetBrains.ReSharper.Psi.Tree.ITreeNode HandleAddTypeMember(JetBrains.ReSharper.Psi.IPsiServices psiServices, JetBrains.ReSharper.Psi.Tree.ITreeNode addedNode) { }
        protected void HandleRemoveImportInternal(JetBrains.ReSharper.Psi.IPsiServices psiServices, JetBrains.ReSharper.Psi.Tree.ITreeNode scope, JetBrains.ReSharper.Psi.Tree.ITreeNode directive, System.Action action, JetBrains.ReSharper.Psi.PsiLanguageType language, JetBrains.ReSharper.Psi.TreeTextRange dstRange) { }
        public JetBrains.ReSharper.Psi.Tree.ITreeNode HandleSuperClassChange(JetBrains.ReSharper.Psi.IPsiServices psiServices, System.Func<JetBrains.ReSharper.Psi.Tree.ITreeNode> action, JetBrains.ReSharper.Psi.Tree.ITreeNode classDeclaration) { }
        protected virtual void ModifyAnchorForAddingStatements(bool before, ref JetBrains.ReSharper.Psi.Tree.ITreeNode anchor) { }
        protected virtual JetBrains.ReSharper.Psi.Tree.ITreeNode PrepareAnchor(JetBrains.ReSharper.Psi.Tree.ITreeNode anchor, JetBrains.ReSharper.Psi.Tree.ITreeNode classDeclaration) { }
        protected abstract void RemoveUsingNode(JetBrains.ReSharper.Psi.Tree.IFile originalFile, TUsingDirective directiveInOriginalFile);
    }
}
namespace JetBrains.ReSharper.Psi.Web.CodeStyle
{
    
    [JetBrains.ReSharper.Psi.CodeStyle.SettingsUpgrade.CodeStyleSettingsAttribute("Web")]
    public class WebCodeStyleSettings : JetBrains.Application.Configuration.IXmlReadable, System.ICloneable
    {
        public WebCodeStyleSettings() { }
        public JetBrains.ReSharper.Psi.Web.Naming.WebNamingStyleSettings NamingSettings { get; }
        public object Clone() { }
        public void ReadFromXml(System.Xml.XmlElement element) { }
    }
}
namespace JetBrains.ReSharper.Psi.Web.DeclaredElements
{
    
    public interface ICssClassDeclaredElement : JetBrains.ReSharper.Psi.IDeclaredElement
    {
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Web.Symbols.IWebClassSymbol> GetSymbols();
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Web.DeclaredElements.ICssClassDeclaredElement SetName([JetBrains.Annotations.NotNullAttribute()] string newName);
    }
    public interface IHtmlTagIdDeclaredElement : JetBrains.ReSharper.Psi.IDeclaredElement
    {
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Web.Symbols.IWebTagIdSymbol> GetSymbols();
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Web.DeclaredElements.IHtmlTagIdDeclaredElement SetNewName([JetBrains.Annotations.NotNullAttribute()] string newName);
    }
}
namespace JetBrains.ReSharper.Psi.Web.Directives
{
    
    public interface IAssemblyAttributeValueType : JetBrains.ReSharper.Psi.Web.Directives.IWebDirectiveAttributeValueType { }
    public interface IFileAttributeValueType : JetBrains.ReSharper.Psi.Web.Directives.IWebDirectiveAttributeValueType
    {
        System.Collections.Generic.ICollection<string> ExpectedExtensions { get; }
        bool NoCircular { get; }
    }
    public interface IInterfaceAttributeValueType : JetBrains.ReSharper.Psi.Web.Directives.IWebDirectiveAttributeValueType { }
    public interface INamespaceAttributeValueType : JetBrains.ReSharper.Psi.Web.Directives.IWebDirectiveAttributeValueType { }
    public interface INumberAttributeValueType : JetBrains.ReSharper.Psi.Web.Directives.IWebDirectiveAttributeValueType { }
    public interface IThemeAttributeValueType : JetBrains.ReSharper.Psi.Web.Directives.IWebDirectiveAttributeValueType { }
    public interface ITypeAttributeValueType : JetBrains.ReSharper.Psi.Web.Directives.IWebDirectiveAttributeValueType
    {
        string ExpectedBaseType { get; }
    }
    public interface IWebDeclaredElementsCache
    {
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetAllDirectivesSymbolTable();
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Web.Directives.IWebDirectiveDeclaredElement GetDirective(string directiveName);
    }
    public interface IWebDirectiveAttributeDeclaredElement : JetBrains.ReSharper.Psi.IDeclaredElement, JetBrains.ReSharper.Psi.Web.IVersionRestricted
    {
        [JetBrains.Annotations.NotNullAttribute()]
        string DefaultValue { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Web.Directives.IWebDirectiveAttributeValueType ValueType { get; }
    }
    public interface IWebDirectiveAttributeValueType
    {
        string Name { get; }
    }
    public interface IWebDirectiveDeclaredElement : JetBrains.ReSharper.Psi.IDeclaredElement
    {
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Web.Directives.IWebDirectiveAttributeDeclaredElement> AllowedAttributes { get; }
        System.Collections.Generic.ICollection<string> AllowedInFiles { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Web.Directives.IWebDirectiveAttributeDeclaredElement GetAttribute(string attributeName);
    }
    public interface IWebDirectiveEnumAttributeValueType : JetBrains.ReSharper.Psi.Web.Directives.IWebDirectiveAttributeValueType
    {
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IDeclaredElement> Members { get; }
    }
}
namespace JetBrains.ReSharper.Psi.Web.Generation
{
    
    public class static ConstrainedGeneratedDocumentServiceExtensions
    {
        public static bool TransactionActionIsUnrelatedImpl(this JetBrains.ReSharper.Psi.Web.Generation.IConstrainedGeneratedDocumentService docService, JetBrains.ReSharper.Psi.Transactions.IPsiTransactionAction transactionAction) { }
    }
    public class FixRangeTranslatorsCommitBuildResult : JetBrains.ReSharper.Psi.Files.ICommitBuildResult
    {
        public FixRangeTranslatorsCommitBuildResult(JetBrains.ReSharper.Psi.Impl.Shared.RangeTranslatorWithGeneratedRangeMap rangeTranslator, JetBrains.ReSharper.Psi.Files.CachedPsiFile cachedPsiFile, JetBrains.ReSharper.Psi.TreeTextRange treeTextRange, string text) { }
        public JetBrains.ReSharper.Psi.Files.CachedPsiFile CachedPsiFile { get; }
        public void FinishCommit() { }
        public JetBrains.ReSharper.Psi.Files.PsiFileModificationInfo GetModificationInfo() { }
    }
    public class FixRangeTranslatorsOnSharedRangeCommitBuildResult : JetBrains.ReSharper.Psi.Files.ICommitBuildResult
    {
        public FixRangeTranslatorsOnSharedRangeCommitBuildResult(JetBrains.ReSharper.Psi.Impl.Shared.RangeTranslatorWithGeneratedRangeMap rangeTranslator, JetBrains.ReSharper.Psi.Files.CachedPsiFile cachedPsiFile, JetBrains.ReSharper.Psi.TreeTextRange<JetBrains.ReSharper.Psi.Original> treeTextRange, JetBrains.ReSharper.Psi.TreeTextRange<JetBrains.ReSharper.Psi.Generated> treeTextRangeGenerated, string text) { }
        public JetBrains.ReSharper.Psi.Files.CachedPsiFile CachedPsiFile { get; }
        public void FinishCommit() { }
        public JetBrains.ReSharper.Psi.Files.PsiFileModificationInfo GetModificationInfo() { }
    }
    public abstract class GeneratedDocumentServiceBase : JetBrains.ReSharper.Psi.ExtensionsAPI.IGeneratedDocumentService
    {
        protected int PromoteToGeneratedInProgress { get; set; }
        public void AssertValid(JetBrains.ReSharper.Psi.Tree.IFile generatedFile) { }
        public bool CanHandle(JetBrains.ProjectModel.ProjectFileType projectFileType) { }
        protected System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Files.ICommitBuildResult> CreateFixRangeTranslatorsCommitResult(JetBrains.ReSharper.Psi.Files.CachedPsiFile cachedPsiFile, JetBrains.ReSharper.Psi.TreeTextRange treeTextRange, string text) { }
        protected System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Files.ICommitBuildResult> CreatePromotedDocumentChangeCommitResult(JetBrains.ReSharper.Psi.Files.CachedPsiFile secondaryCachedPsiFile, JetBrains.ReSharper.Psi.TreeTextRange oldTreeRange, string newText) { }
        public abstract JetBrains.ReSharper.Psi.ExtensionsAPI.ISecondaryLexingProcess CreateSecondaryLexingService(JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Psi.Parsing.MixedLexer mixedLexer, JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile = null);
        protected virtual bool CustomPromoteChange(JetBrains.ReSharper.Psi.TreeTextRange range, string oldText, string newText, JetBrains.ReSharper.Psi.Impl.Shared.RangeTranslatorWithGeneratedRangeMap rangeTranslator, JetBrains.ReSharper.Psi.Tree.IFile generatedFile, JetBrains.ReSharper.Psi.Transactions.IPsiTransactionAction transactionAction) { }
        public virtual System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.Files.ICommitBuildResult> ExecuteSecondaryDocumentCommitWork(JetBrains.ReSharper.Psi.Files.PrimaryFileModificationInfo primaryFileModificationInfo, JetBrains.ReSharper.Psi.Files.CachedPsiFile cachedPsiFile, JetBrains.ReSharper.Psi.TreeTextRange oldTreeRange, string newText) { }
        public abstract JetBrains.ReSharper.Psi.ExtensionsAPI.ISecondaryDocumentGenerationResult Generate(JetBrains.ReSharper.Psi.Files.PrimaryFileModificationInfo modificationInfo);
        public abstract System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.PsiLanguageType> GetSecondaryPsiLanguageTypes(JetBrains.ProjectModel.IProject project);
        public abstract bool IsSecondaryPsiLanguageType(JetBrains.ProjectModel.IProject project, JetBrains.ReSharper.Psi.PsiLanguageType language);
        public abstract JetBrains.ReSharper.Psi.Parsing.ILexerFactory LexerFactoryWithPreprocessor(JetBrains.ReSharper.Psi.PsiLanguageType primaryLanguage);
        public virtual void ProcessChangeFromGeneratedToPrimary(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, JetBrains.Util.TextRange range, string oldText, string newText, JetBrains.ReSharper.Psi.PsiLanguageType language) { }
        public virtual void ProcessChangeFromPrimaryToGenerated(JetBrains.ReSharper.Psi.TreeTextRange range, string oldText, string newText, JetBrains.ReSharper.Psi.Files.ISecondaryRangeTranslator rangeTranslator, JetBrains.ReSharper.Psi.Tree.IFile generatedFile, JetBrains.ReSharper.Psi.Transactions.IPsiTransactionAction transactionAction) { }
        protected virtual bool PromoteChangeFromGeneratedToPrimary(JetBrains.ReSharper.Psi.TreeTextRange<JetBrains.ReSharper.Psi.Original> modifiedOriginalRange, JetBrains.ReSharper.Psi.TreeTextRange<JetBrains.ReSharper.Psi.Generated> modifiedGeneratedRange, string newText, JetBrains.ReSharper.Psi.Impl.Shared.RangeTranslatorWithGeneratedRangeMap rangeTranslator) { }
        protected virtual bool ReparseOriginalFile(JetBrains.ReSharper.Psi.TreeTextRange treeTextRange, string newText, JetBrains.ReSharper.Psi.Impl.Shared.RangeTranslatorWithGeneratedRangeMap rangeTranslator) { }
        protected virtual bool TransactionActionIsUnrelated(JetBrains.ReSharper.Psi.Transactions.IPsiTransactionAction transactionAction) { }
        public virtual JetBrains.DocumentModel.DocumentRange TryFindNavigationRangeInPrimaryDocument(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
    }
    public class GenerationResults
    {
        public GenerationResults([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.PsiLanguageType language, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.IFile file) { }
        public GenerationResults(JetBrains.ReSharper.Psi.PsiLanguageType languageType, System.Text.StringBuilder text, JetBrains.ReSharper.Psi.Impl.Shared.IGeneratedRangeMap generatedRangeMap) { }
        public GenerationResults(JetBrains.ReSharper.Psi.PsiLanguageType languageType, string text, JetBrains.ReSharper.Psi.Impl.Shared.IGeneratedRangeMap generatedRangeMap) { }
        public JetBrains.ReSharper.Psi.Impl.Shared.IGeneratedRangeMap GeneratedRangeMap { get; }
        public bool IsEmpty { get; }
        public JetBrains.ReSharper.Psi.PsiLanguageType LanguageType { get; }
        public System.Text.StringBuilder Text { get; }
        public void Append(JetBrains.ReSharper.Psi.Web.Generation.GenerationResults results, bool mapIsOrdered = False) { }
        public void AppendLine(JetBrains.ReSharper.Psi.Web.Generation.GenerationResults results, bool mapIsOrdered = False) { }
    }
    public interface IConstrainedGeneratedDocumentService : JetBrains.ReSharper.Psi.ExtensionsAPI.IGeneratedDocumentService
    {
        bool HasProjectedInnerElements(JetBrains.ReSharper.Psi.Tree.ITreeNode node);
        bool HasProjectedOuterElements(JetBrains.ReSharper.Psi.Tree.ITreeNode node);
    }
}
namespace JetBrains.ReSharper.Psi.Web.Impl.BuildProviders
{
    
    public class AsyncWebsiteBuilder : JetBrains.ReSharper.Psi.Web.Impl.BuildProviders.WebsiteBuilderBase
    {
        protected static readonly System.TimeSpan MaxAbortTimeout;
        protected static readonly System.TimeSpan MinAbortTimeout;
        protected System.TimeSpan myAbortTimeout;
        public AsyncWebsiteBuilder(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ReSharper.Psi.Web.BuildProviders.IWebsiteBuildRequestor requestor, JetBrains.Application.ChangeManager changeManager, JetBrains.DocumentManagers.impl.DocumentManagerOperations documentManagerOperations, JetBrains.ReSharper.Psi.Files.IPsiFiles psiFiles, JetBrains.ProjectModel.PlatformManager platformManager, JetBrains.Application.IShellLocks shellLocks, JetBrains.ReSharper.Psi.Web.BuildProviders.WebsiteBuildEngineFactory factory) { }
        protected override void CommitAllDocumentsAsync(System.Action onCommited, System.Action onInterrupted) { }
        protected override void QueueWithReadLockWhenReadLockAvailable(string id, System.TimeSpan interval, System.Action action) { }
        protected override void RebuildWebsite(int delayInMilliseconds) { }
        protected override void RunBuildThread(JetBrains.DataFlow.Lifetime lifetime, System.Action<JetBrains.DataFlow.Lifetime> action) { }
        protected override void StartCollectFilesActivity(JetBrains.Application.InterruptableReadActivity activity) { }
    }
    public class BuildProvidersSupportManager : JetBrains.ReSharper.Psi.Web.BuildProviders.IWebsiteBuildRequestor
    {
        public BuildProvidersSupportManager(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ProjectModel.IProject project) { }
        public JetBrains.ProjectModel.IProject Project { get; }
        public bool IsPrimaryFile(JetBrains.ProjectModel.IProjectFile file, JetBrains.ReSharper.Psi.Web.Impl.BuildProviders.WebFolders folders) { }
        public bool IsSignificantFile(JetBrains.ProjectModel.IProjectFile file, JetBrains.ReSharper.Psi.Web.Impl.BuildProviders.WebFolders folders) { }
        public bool IsSupplementaryFile(JetBrains.ProjectModel.IProjectFile file, JetBrains.ReSharper.Psi.Web.Impl.BuildProviders.WebFolders folders) { }
    }
    public class SynchWebsiteBuilder : JetBrains.ReSharper.Psi.Web.Impl.BuildProviders.WebsiteBuilderBase
    {
        public SynchWebsiteBuilder(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ReSharper.Psi.Web.BuildProviders.IWebsiteBuildRequestor requestor, JetBrains.Application.ChangeManager changeManager, JetBrains.DocumentManagers.impl.DocumentManagerOperations documentManagerOperations, JetBrains.ReSharper.Psi.Files.IPsiFiles psiFiles, JetBrains.ProjectModel.PlatformManager platformManager, JetBrains.Application.IShellLocks shellLocks, JetBrains.ReSharper.Psi.Web.BuildProviders.WebsiteBuildEngineFactory factory) { }
        protected override void CommitAllDocumentsAsync(System.Action onCommited, System.Action onInterrupted) { }
        protected override void QueueWithReadLockWhenReadLockAvailable(string id, System.TimeSpan interval, System.Action action) { }
        protected override void RebuildWebsite(int delayInMilliseconds) { }
        protected override void RunBuildThread(JetBrains.DataFlow.Lifetime lifetime, System.Action<JetBrains.DataFlow.Lifetime> action) { }
        protected override void StartCollectFilesActivity(JetBrains.Application.InterruptableReadActivity activity) { }
    }
    public class WebFolders
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        public readonly JetBrains.ProjectModel.IProjectFolder AppCodeFolder;
        [JetBrains.Annotations.CanBeNullAttribute()]
        public readonly JetBrains.ProjectModel.IProjectFolder WebReferencesFolder;
        public WebFolders(JetBrains.ProjectModel.IProject project) { }
    }
    public class WebReferencesSupportManager : JetBrains.ReSharper.Psi.Web.BuildProviders.IWebsiteBuildRequestor
    {
        public WebReferencesSupportManager(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ProjectModel.IProject project, JetBrains.DocumentManagers.DocumentManager documentManager) { }
        public System.Collections.Generic.JetHashSet<JetBrains.Util.FileSystemPath> AppCodeSubfolders { get; }
        public JetBrains.ProjectModel.IProject Project { get; }
        public void BeforeBuildStarted() { }
        public bool IsPrimaryFile(JetBrains.ProjectModel.IProjectFile file, JetBrains.ReSharper.Psi.Web.Impl.BuildProviders.WebFolders folders) { }
        public bool IsSignificantFile(JetBrains.ProjectModel.IProjectFile file, JetBrains.ReSharper.Psi.Web.Impl.BuildProviders.WebFolders folders) { }
        public bool IsSupplementaryFile(JetBrains.ProjectModel.IProjectFile file, JetBrains.ReSharper.Psi.Web.Impl.BuildProviders.WebFolders folders) { }
        public System.Collections.Generic.Dictionary<JetBrains.Util.FileSystemPath, string> OnBuildFinished(System.Collections.Generic.Dictionary<JetBrains.Util.FileSystemPath, long> primaryFiles, System.Collections.Generic.Dictionary<JetBrains.Util.FileSystemPath, long> supplementaryFiles, JetBrains.ReSharper.Psi.Web.BuildProviders.WebsiteBuildResult buildResult, JetBrains.Util.FileSystemPath targetPath, JetBrains.Util.FileSystemPath outputPath, JetBrains.Util.FileSystemPath tempDirPath) { }
    }
    public abstract class WebsiteBuilderBase : JetBrains.ReSharper.Psi.Web.BuildProviders.IWebsiteBuilder
    {
        protected readonly object myLockObject;
        public const string TEMP_DIR = "tempDirectory";
        public WebsiteBuilderBase(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ReSharper.Psi.Web.BuildProviders.IWebsiteBuildRequestor requestor, JetBrains.Application.ChangeManager changeManager, JetBrains.DocumentManagers.impl.DocumentManagerOperations documentManagerOperations, JetBrains.ReSharper.Psi.Files.IPsiFiles psiFiles, JetBrains.ProjectModel.PlatformManager platformManager, JetBrains.Application.IShellLocks shellLocks, JetBrains.ReSharper.Psi.Web.BuildProviders.WebsiteBuildEngineFactory factory) { }
        protected JetBrains.Application.ChangeManager ChangeManager { get; }
        public JetBrains.DataFlow.ISimpleSignal GeneratedFilesChanged { get; }
        public JetBrains.Util.FileSystemPath GeneratedFilesDirectory { get; }
        protected JetBrains.DataFlow.Lifetime Lifetime { get; }
        public string LogName { get; }
        public JetBrains.ProjectModel.IProject Project { get; }
        protected JetBrains.ReSharper.Psi.Files.IPsiFiles PsiFiles { get; set; }
        public JetBrains.ReSharper.Psi.Web.BuildProviders.IWebsiteBuildRequestor Requestor { get; }
        protected JetBrains.Application.IShellLocks ShellLocks { get; }
        public static void CollectDebugFiles(JetBrains.Util.FileSystemPath folderPath, JetBrains.ReSharper.Psi.Web.Impl.BuildProviders.WebsiteBuilderBase.IDebugFileConsumer consumer) { }
        protected abstract void CommitAllDocumentsAsync(System.Action onCommited, System.Action onInterrupted);
        protected void CopyFile(JetBrains.Util.FileSystemPath srcPath, JetBrains.Util.FileSystemPath dstPath, bool doLogging = False) { }
        protected virtual JetBrains.Util.TemporaryDirectoryCookie CreateGeneratedFilesDirectory() { }
        protected static void EnsureFolder(JetBrains.Util.FileSystemPath folderPath) { }
        protected void EnsureFoldersExist(JetBrains.Util.FileSystemPath targetPath, System.Collections.Generic.IList<JetBrains.Util.FileSystemPath> relativePaths) { }
        public static JetBrains.ProjectModel.IProjectFile GetNeighbourFile(JetBrains.ProjectModel.IProjectFile projectFile, string newExtension) { }
        protected void OnBuidFinished(System.Collections.Generic.Dictionary<JetBrains.Util.FileSystemPath, string> filesToCopy, System.Collections.Generic.Dictionary<JetBrains.Util.FileSystemPath, long> primaryFiles, System.Collections.Generic.Dictionary<JetBrains.Util.FileSystemPath, long> supplementaryFiles) { }
        protected void OnBuildSucceded(System.Collections.Generic.Dictionary<JetBrains.Util.FileSystemPath, long> primaryFiles, System.Collections.Generic.Dictionary<JetBrains.Util.FileSystemPath, long> supplementaryFiles, JetBrains.ReSharper.Psi.Web.BuildProviders.WebsiteBuildResult buildResult, JetBrains.Util.FileSystemPath targetPath, JetBrains.Util.FileSystemPath outputPath, JetBrains.Util.FileSystemPath tempDirPath) { }
        protected abstract void QueueWithReadLockWhenReadLockAvailable(string id, System.TimeSpan interval, System.Action action);
        protected abstract void RebuildWebsite(int delayInMilliseconds);
        public void RebuildWebsite() { }
        protected abstract void RunBuildThread(JetBrains.DataFlow.Lifetime lifetime, System.Action<JetBrains.DataFlow.Lifetime> action);
        protected void SetState(JetBrains.ReSharper.Psi.Web.Impl.BuildProviders.WebsiteBuilderBase.State newState, JetBrains.ReSharper.Psi.Web.Impl.BuildProviders.WebsiteBuilderBase.BuildResult buildResult) { }
        protected abstract void StartCollectFilesActivity(JetBrains.Application.InterruptableReadActivity activity);
        protected enum BuildResult
        {
            UNKNOWN = 0,
            SUCCESS = 1,
            INTERRUPTED = 2,
            ERROR = 3,
        }
        public interface IDebugFileConsumer
        {
            void ConsumeFile(JetBrains.Util.FileSystemPath generatedFilePath);
            bool ProcessFolder(JetBrains.Util.FileSystemPath folderPath);
        }
        protected enum State
        {
            IDLE = 0,
            COLLECT_FILES_QUEUED = 1,
            BUILD_IN_PROGRESS = 2,
        }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class WebsiteBuilderFactory : JetBrains.ReSharper.Psi.Web.BuildProviders.IWebsiteBuilderFactory
    {
        public WebsiteBuilderFactory(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.ChangeManager changeManager, JetBrains.DocumentManagers.impl.DocumentManagerOperations documentManagerOperations, JetBrains.ProjectModel.PlatformManager platformManager, JetBrains.Application.IShellLocks shellLocks, JetBrains.ReSharper.Psi.Web.BuildProviders.WebsiteBuildEngineFactory buildEngineFactory) { }
        protected JetBrains.ReSharper.Psi.Web.BuildProviders.WebsiteBuildEngineFactory BuildEngineFactory { get; }
        protected JetBrains.Application.ChangeManager ChangeManager { get; }
        protected JetBrains.DocumentManagers.impl.DocumentManagerOperations DocumentManagerOperations { get; }
        protected JetBrains.ProjectModel.PlatformManager PlatformManager { get; }
        protected JetBrains.ReSharper.Psi.Files.IPsiFiles PsiFiles { get; }
        protected JetBrains.Application.IShellLocks ShellLocks { get; }
        public virtual JetBrains.ReSharper.Psi.Web.BuildProviders.IWebsiteBuilder CreateWebsiteBuilder(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ReSharper.Psi.Web.BuildProviders.IWebsiteBuildRequestor requestor) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class WebsiteBuilders : JetBrains.ReSharper.Psi.Web.BuildProviders.IWebsiteBuilders
    {
        public WebsiteBuilders(JetBrains.ReSharper.Psi.Web.BuildProviders.IWebsiteBuilderFactory builderFactory, JetBrains.DocumentManagers.DocumentManager documentManager) { }
        public JetBrains.ReSharper.Psi.Web.BuildProviders.IWebsiteBuilder GetOrCreateBuildProvidersSupportManager(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ProjectModel.IProject project) { }
        public JetBrains.ReSharper.Psi.Web.BuildProviders.IWebsiteBuilder GetOrCreateWebReferencesSupportManager(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ProjectModel.IProject project) { }
    }
    public class static WebsiteBuildRequestorUtil
    {
        public static System.Collections.Generic.JetHashSet<JetBrains.Util.FileSystemPath> GetAppCodeSubfolders(JetBrains.ProjectModel.IProject project) { }
    }
}
namespace JetBrains.ReSharper.Psi.Web.Impl.Directives
{
    
    public class WebAttributeEnumValue : JetBrains.ReSharper.Psi.IDeclaredElement
    {
        public WebAttributeEnumValue(string shortName, JetBrains.ReSharper.Psi.Modules.IPsiModule psiModule) { }
        public bool CaseSensistiveName { get; }
        public JetBrains.ReSharper.Psi.PsiLanguageType PresentationLanguage { get; }
        public string ShortName { get; }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Tree.IDeclaration> GetDeclarations() { }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Tree.IDeclaration> GetDeclarationsIn(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
        public JetBrains.ReSharper.Psi.DeclaredElementType GetElementType() { }
        public JetBrains.ReSharper.Psi.IPsiServices GetPsiServices() { }
        public JetBrains.Util.DataStructures.HybridCollection<JetBrains.ReSharper.Psi.IPsiSourceFile> GetSourceFiles() { }
        public System.Xml.XmlNode GetXMLDescriptionSummary(bool inherit) { }
        public System.Xml.XmlNode GetXMLDoc(bool inherit) { }
        public bool HasDeclarationsIn(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
        public bool IsSynthetic() { }
        public bool IsValid() { }
    }
    public abstract class WebDeclaredElementsCache : JetBrains.ReSharper.Psi.Web.Directives.IWebDeclaredElementsCache
    {
        protected readonly JetBrains.ReSharper.Psi.Modules.IPsiModule myEmptyPsiModule;
        protected readonly object myLockObject;
        protected WebDeclaredElementsCache(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ReSharper.Psi.IPsiServices psiServices, string resourceName) { }
        public JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetAllDirectivesSymbolTable() { }
        public JetBrains.ReSharper.Psi.Web.Directives.IWebDirectiveDeclaredElement GetDirective(string directiveName) { }
    }
    public class WebDirectiveAttributeDeclaredElement : JetBrains.ReSharper.Psi.IDeclaredElement, JetBrains.ReSharper.Psi.Web.Directives.IWebDirectiveAttributeDeclaredElement, JetBrains.ReSharper.Psi.Web.IVersionRestricted
    {
        public WebDirectiveAttributeDeclaredElement(string shortName, JetBrains.ReSharper.Psi.Modules.IPsiModule psiModule, JetBrains.ReSharper.Psi.Web.Directives.IWebDirectiveAttributeValueType valueType, string defaultValue, System.Nullable<JetBrains.ReSharper.Psi.Web.AspNetVersion> versionRestriction) { }
        public bool CaseSensistiveName { get; }
        public string DefaultValue { get; }
        public JetBrains.ReSharper.Psi.PsiLanguageType PresentationLanguage { get; }
        public string ShortName { get; }
        public System.Nullable<JetBrains.ReSharper.Psi.Web.AspNetVersion> SupportedVersion { get; }
        public JetBrains.ReSharper.Psi.Web.Directives.IWebDirectiveAttributeValueType ValueType { get; }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Tree.IDeclaration> GetDeclarations() { }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Tree.IDeclaration> GetDeclarationsIn(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
        public JetBrains.ReSharper.Psi.DeclaredElementType GetElementType() { }
        public JetBrains.ReSharper.Psi.IPsiServices GetPsiServices() { }
        public JetBrains.Util.DataStructures.HybridCollection<JetBrains.ReSharper.Psi.IPsiSourceFile> GetSourceFiles() { }
        public System.Xml.XmlNode GetXMLDescriptionSummary(bool inherit) { }
        public System.Xml.XmlNode GetXMLDoc(bool inherit) { }
        public bool HasDeclarationsIn(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
        public bool IsSynthetic() { }
        public bool IsValid() { }
    }
    public class WebDirectiveAttributeValueType : JetBrains.ReSharper.Psi.Web.Directives.IWebDirectiveAttributeValueType
    {
        public static readonly JetBrains.ReSharper.Psi.Web.Directives.IWebDirectiveAttributeValueType Assembly;
        public static readonly JetBrains.ReSharper.Psi.Web.Directives.IWebDirectiveAttributeValueType Interface;
        public static readonly JetBrains.ReSharper.Psi.Web.Directives.IWebDirectiveAttributeValueType Namespace;
        public static readonly JetBrains.ReSharper.Psi.Web.Directives.IWebDirectiveAttributeValueType Number;
        public static readonly JetBrains.ReSharper.Psi.Web.Directives.IWebDirectiveAttributeValueType Theme;
        public static readonly JetBrains.ReSharper.Psi.Web.Directives.IWebDirectiveAttributeValueType Unknown;
        protected WebDirectiveAttributeValueType(string name) { }
        public string Name { get; }
        public bool Equals(JetBrains.ReSharper.Psi.Web.Impl.Directives.WebDirectiveAttributeValueType other) { }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
        public override string ToString() { }
    }
    public class WebDirectiveDeclaredElement : JetBrains.ReSharper.Psi.IDeclaredElement, JetBrains.ReSharper.Psi.Web.Directives.IWebDirectiveDeclaredElement
    {
        public WebDirectiveDeclaredElement(string shortName, System.Collections.Generic.IEnumerable<string> alowedInFiles, JetBrains.ReSharper.Psi.Modules.IPsiModule psiModule, System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.Web.Directives.IWebDirectiveAttributeDeclaredElement> alowedAttributes) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Web.Directives.IWebDirectiveAttributeDeclaredElement> AllowedAttributes { get; }
        public System.Collections.Generic.ICollection<string> AllowedInFiles { get; }
        public bool CaseSensistiveName { get; }
        public JetBrains.ReSharper.Psi.PsiLanguageType PresentationLanguage { get; }
        public string ShortName { get; }
        public JetBrains.ReSharper.Psi.Web.Directives.IWebDirectiveAttributeDeclaredElement GetAttribute(string attributeName) { }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Tree.IDeclaration> GetDeclarations() { }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Tree.IDeclaration> GetDeclarationsIn(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
        public JetBrains.ReSharper.Psi.DeclaredElementType GetElementType() { }
        public JetBrains.ReSharper.Psi.IPsiServices GetPsiServices() { }
        public JetBrains.Util.DataStructures.HybridCollection<JetBrains.ReSharper.Psi.IPsiSourceFile> GetSourceFiles() { }
        public System.Xml.XmlNode GetXMLDescriptionSummary(bool inherit) { }
        public System.Xml.XmlNode GetXMLDoc(bool inherit) { }
        public bool HasDeclarationsIn(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
        public bool IsSynthetic() { }
        public bool IsValid() { }
    }
    public class WebDirectiveEnumAttributeValueType : JetBrains.ReSharper.Psi.Web.Impl.Directives.WebDirectiveAttributeValueType, JetBrains.ReSharper.Psi.Web.Directives.IWebDirectiveAttributeValueType, JetBrains.ReSharper.Psi.Web.Directives.IWebDirectiveEnumAttributeValueType
    {
        public WebDirectiveEnumAttributeValueType(string name, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IDeclaredElement> members) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IDeclaredElement> Members { get; }
    }
    public class WebDirectiveFileAttributeValueType : JetBrains.ReSharper.Psi.Web.Impl.Directives.WebDirectiveAttributeValueType, JetBrains.ReSharper.Psi.Web.Directives.IFileAttributeValueType, JetBrains.ReSharper.Psi.Web.Directives.IWebDirectiveAttributeValueType
    {
        public WebDirectiveFileAttributeValueType(System.Collections.Generic.ICollection<string> expectedExtensions, bool noCircular) { }
        public System.Collections.Generic.ICollection<string> ExpectedExtensions { get; }
        public bool NoCircular { get; }
    }
    public class WebDirectiveTypeAttributeValueType : JetBrains.ReSharper.Psi.Web.Impl.Directives.WebDirectiveAttributeValueType, JetBrains.ReSharper.Psi.Web.Directives.ITypeAttributeValueType, JetBrains.ReSharper.Psi.Web.Directives.IWebDirectiveAttributeValueType
    {
        public WebDirectiveTypeAttributeValueType(string expectedBaseType) { }
        public string ExpectedBaseType { get; }
    }
}
namespace JetBrains.ReSharper.Psi.Web.Impl.Finder
{
    
    public class FindResultWebSymbol : JetBrains.ReSharper.Psi.Search.FindResult
    {
        public FindResultWebSymbol([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Web.Symbols.IWebSymbol webSymbol) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ReSharper.Psi.Web.Symbols.IWebSymbol WebSymbol { get; }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
    }
}
namespace JetBrains.ReSharper.Psi.Web.Impl.PsiModules
{
    
    public class AspFileDataDiffImpl : JetBrains.ReSharper.Psi.Web.PsiModules.IAspFileDataDiff
    {
        public AspFileDataDiffImpl([JetBrains.Annotations.NotNullAttribute()] string oldCodeFile, [JetBrains.Annotations.NotNullAttribute()] string newCodeFile, [JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IEnumerable<string> addedReferencedFiles, [JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IEnumerable<string> removedReferencedFiles, [JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IEnumerable<string> addedReferencedModulesByName, [JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IEnumerable<string> removedReferencedModulesByName, [JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IEnumerable<string> addedReferencedModulesByPath, [JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IEnumerable<string> removedReferencedModulesByPath, [JetBrains.Annotations.NotNullAttribute()] string oldLanguage, [JetBrains.Annotations.NotNullAttribute()] string newlLanguage) { }
        public System.Collections.Generic.IEnumerable<string> AddedReferencedFiles { get; }
        public System.Collections.Generic.IEnumerable<string> AddedReferencedModulesByName { get; }
        public System.Collections.Generic.IEnumerable<string> AddedReferencedModulesByPath { get; }
        public string NewCodeFile { get; }
        public string NewLanguageDefinedInFile { get; }
        public string OldCodeFile { get; }
        public string OldLanguageDefinedInFile { get; }
        public System.Collections.Generic.IEnumerable<string> RemovedReferencedFiles { get; }
        public System.Collections.Generic.IEnumerable<string> RemovedReferencedModulesByName { get; }
        public System.Collections.Generic.IEnumerable<string> RemovedReferencedModulesByPath { get; }
        public bool IsEmpty() { }
    }
    public class static AssemblyCookieExtension
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Psi.Modules.IPsiModuleReference ToPsiModuleReference([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ProjectModel.Model2.Assemblies.Interfaces.IAssemblyCookie cookie, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Modules.IPsiModules psiModules, JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext referenceResolveContext) { }
    }
    public interface IAspFileDataChangeListener
    {
        void OnProjectFileDataChanged(JetBrains.Util.Pair<JetBrains.Util.FileSystemPath, JetBrains.ReSharper.Psi.Web.PsiModules.IAspFileDataDiff> pair, JetBrains.ReSharper.Psi.Modules.PsiModuleChangeBuilder changeBuilder);
    }
    public interface IWebCommonReferenceProvider
    {
        JetBrains.DataFlow.ISimpleSignal ReferencesChanged { get; }
        void GetCommonReferencesFor(JetBrains.ReSharper.Psi.Modules.IPsiModule psiModule, JetBrains.ReSharper.Psi.Web.Impl.PsiModules.PsiModuleReferenceAccumulator referenceAccumulator);
        bool InternalsVisibleTo(JetBrains.ReSharper.Psi.Modules.IPsiModule moduleTo, JetBrains.ReSharper.Psi.Modules.IPsiModule moduleFrom);
    }
    public interface IWebCommonReferenceProviderFactory
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Web.Impl.PsiModules.IWebCommonReferenceProvider CreateReferenceProvider(JetBrains.DataFlow.Lifetime helperLifetime, JetBrains.ReSharper.Psi.Web.Impl.PsiModules.IWebProjectPsiModuleHandler handler, JetBrains.ReSharper.Psi.Web.PsiModules.IAspFileDataCache aspFileDataCache);
    }
    public interface IWebConfigChangesListener
    {
        void OnWebConfigChanged(System.Collections.Generic.ICollection<JetBrains.Util.JetTuple<JetBrains.ProjectModel.IProjectFile, JetBrains.Util.FileSystemPath, JetBrains.ReSharper.Psi.Web.Cache.WebConfigChangeType>> tuples, JetBrains.ReSharper.Psi.Modules.PsiModuleChangeBuilder changeBuilder);
    }
    public interface IWebProjectPsiModuleHandler : JetBrains.ReSharper.Psi.Modules.IProjectPsiModuleHandler
    {
        JetBrains.ProjectModel.IProject Project { get; }
        System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.PreProcessingDirective> GetAllDefines([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Modules.IPsiModule module, [JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.PreProcessingDirective> moduleDefines);
        void GetCommonReferencesFor(JetBrains.ReSharper.Psi.Modules.IPsiModule psiModule, JetBrains.ReSharper.Psi.Web.Impl.PsiModules.PsiModuleReferenceAccumulator referenceAccumulator);
    }
    public interface IWebPsiModuleHandlerHelper
    {
        double Priority { get; }
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IPsiSourceFile> FindPsiSourceFiles(JetBrains.ProjectModel.IProjectFile projectFile);
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Modules.IPsiModule> GetAllModules();
        bool InternalsVisibleTo(JetBrains.ReSharper.Psi.Modules.IPsiModule moduleTo, JetBrains.ReSharper.Psi.Modules.IPsiModule moduleFrom);
        void OnExternalModuleSetChanged(JetBrains.ReSharper.Psi.Modules.PsiModuleChangeBuilder changeBuilder);
        bool OnProjectFileAdded(JetBrains.ProjectModel.IProjectFile projectFile, JetBrains.ReSharper.Psi.Modules.PsiModuleChangeBuilder changeBuilder, System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Web.Impl.PsiModules.IWebPsiModuleHandlerHelper> alreadyProcessedBy);
        void OnProjectFileModified(JetBrains.ProjectModel.IProjectFile projectFile, JetBrains.ReSharper.Psi.Modules.PsiModuleChangeBuilder changeBuilder);
        void OnProjectFileRemoved(JetBrains.ProjectModel.IProjectFile projectFile, JetBrains.ReSharper.Psi.Modules.PsiModuleChangeBuilder changeBuilder);
        void OnProjectPropertiesChange(JetBrains.ReSharper.Psi.Modules.PsiModuleChangeBuilder changeBuilder);
    }
    public interface IWebPsiModuleHandlerHelperFactory
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Web.Impl.PsiModules.IWebPsiModuleHandlerHelper CreateHelper(JetBrains.DataFlow.Lifetime helperLifetime, JetBrains.ReSharper.Psi.Web.Impl.PsiModules.IWebProjectPsiModuleHandler handler, JetBrains.ReSharper.Psi.Web.Cache.IWebConfigCache webConfigCache, JetBrains.ReSharper.Psi.Web.PsiModules.IAspFileDataCache aspFileDataCache);
    }
    [JetBrains.ReSharper.Psi.Modules.MiscFilesProjectPsiModuleProviderAttribute()]
    public class NavigateablePsiSourceFilesMiscFilesProjectPsiModuleProvider : JetBrains.ReSharper.Psi.Modules.IMiscFilesProjectPsiModuleProvider, System.IDisposable
    {
        public NavigateablePsiSourceFilesMiscFilesProjectPsiModuleProvider(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ProjectModel.ISolution solution, JetBrains.Application.ChangeManager changeManager) { }
        public void Dispose() { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Modules.IPsiModule> GetModules() { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IPsiSourceFile> GetPsiSourceFilesFor(JetBrains.ProjectModel.IProjectFile projectFile) { }
        public void OnProjectFileChanged(JetBrains.ProjectModel.IProjectFile projectFile, JetBrains.ReSharper.Psi.Modules.PsiModuleChange.ChangeType changeType, JetBrains.ReSharper.Psi.Modules.PsiModuleChangeBuilder changeBuilder, JetBrains.Util.FileSystemPath oldLocation) { }
    }
    public class PsiModuleReferenceAccumulator
    {
        public PsiModuleReferenceAccumulator() { }
        public void Add(JetBrains.ReSharper.Psi.Modules.IPsiModuleReference reference) { }
        public void AddRange(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Modules.IPsiModuleReference> references) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Modules.IPsiModuleReference> GetReferences() { }
    }
    public abstract class WebProjectPsiModuleHandlerBase : JetBrains.Application.IChangeProvider, JetBrains.ReSharper.Psi.Modules.IProjectPsiModuleHandler, JetBrains.ReSharper.Psi.Web.Impl.PsiModules.IWebProjectPsiModuleHandler
    {
        protected readonly JetBrains.Application.IShellLocks Locks;
        protected WebProjectPsiModuleHandlerBase(JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IProject project, JetBrains.Application.ChangeManager changeManager, JetBrains.Application.IShellLocks locks, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Web.Impl.PsiModules.IWebPsiModuleHandlerHelperFactory> helperFactories, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Web.Impl.PsiModules.IWebCommonReferenceProviderFactory> referenceProviderFactories, JetBrains.ReSharper.Psi.Web.PsiModules.IAspFileDataCache aspFileDataCache, JetBrains.ReSharper.Psi.Web.Cache.IWebConfigCache webConfigCache, JetBrains.ReSharper.Psi.Web.PsiModules.IWebAssemblyReferenceFactory assemblyReferenceFactory) { }
        protected System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Web.Impl.PsiModules.IWebPsiModuleHandlerHelper> AllHelpers { get; }
        public JetBrains.Application.IChangeProvider ChangeProvider { get; }
        protected JetBrains.DataFlow.Lifetime Lifetime { get; }
        public abstract JetBrains.ReSharper.Psi.Modules.IProjectPsiModule PrimaryModule { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ProjectModel.IProject Project { get; }
        public virtual object Execute(JetBrains.Application.IChangeMap changeMap) { }
        protected virtual void ExecuteOrQueueWithWriteLock(string name, System.Action action) { }
        public System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.PreProcessingDirective> GetAllDefines(JetBrains.ReSharper.Psi.Modules.IPsiModule module, System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.PreProcessingDirective> moduleDefines) { }
        public virtual System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Modules.IPsiModule> GetAllModules() { }
        public virtual void GetCommonReferencesFor(JetBrains.ReSharper.Psi.Modules.IPsiModule psiModule, JetBrains.ReSharper.Psi.Web.Impl.PsiModules.PsiModuleReferenceAccumulator referenceAccumulator) { }
        public abstract System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Modules.IPsiModule> GetPsiModulesToReference();
        public virtual System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IPsiSourceFile> GetPsiSourceFilesFor(JetBrains.ProjectModel.IProjectFile projectFile) { }
        public virtual bool InternalsVisibleTo(JetBrains.ReSharper.Psi.Modules.IPsiModule moduleTo, JetBrains.ReSharper.Psi.Modules.IPsiModule moduleFrom) { }
        protected virtual void OnCommonReferenceChanged(bool obj) { }
        public void OnExternalModuleSetChanged(JetBrains.ReSharper.Psi.Modules.PsiModuleChangeBuilder changeBuilder) { }
        protected virtual void OnProjectFileAdded(JetBrains.ProjectModel.IProjectFile projectFile, JetBrains.ReSharper.Psi.Modules.PsiModuleChangeBuilder changeBuilder) { }
        public void OnProjectFileChanged(JetBrains.ProjectModel.IProjectFile projectFile, JetBrains.Util.FileSystemPath oldLocation, JetBrains.ReSharper.Psi.Modules.PsiModuleChange.ChangeType changeType, JetBrains.ReSharper.Psi.Modules.PsiModuleChangeBuilder changeBuilder) { }
        protected virtual void OnProjectFileDataChanged(JetBrains.Util.Pair<JetBrains.Util.FileSystemPath, JetBrains.ReSharper.Psi.Web.PsiModules.IAspFileDataDiff> pair) { }
        protected virtual void OnProjectFileModified(JetBrains.ProjectModel.IProjectFile projectFile, JetBrains.ReSharper.Psi.Modules.PsiModuleChangeBuilder changeBuilder) { }
        protected virtual void OnProjectFileRemoved(JetBrains.ProjectModel.IProjectFile projectFile, JetBrains.Util.FileSystemPath oldLocation, JetBrains.ReSharper.Psi.Modules.PsiModuleChangeBuilder changeBuilder) { }
        public virtual void OnProjectPropertiesChanged(JetBrains.ReSharper.Psi.Modules.PsiModuleChangeBuilder changeBuilder) { }
        protected virtual void OnWebConfigChanged(System.Collections.Generic.ICollection<JetBrains.Util.JetTuple<JetBrains.ProjectModel.IProjectFile, JetBrains.Util.FileSystemPath, JetBrains.ReSharper.Psi.Web.Cache.WebConfigChangeType>> tuples) { }
    }
    public class static WebPsiModuleHandlerHelperEx
    {
        public const double APP_CODE_PRIORITY = 500D;
        public const double APP_WEBREFERENCES_PRIORITY = 100D;
        public const double ASP_FILES_PRIORITY = 400D;
        public const double GLOBAL_RESOURCES_PRIORITY = 499D;
        public const double OTHER_FILES_PRIORITY = 0D;
        public const double WEB_CONFIGS_PRIORITY = 300D;
    }
}
namespace JetBrains.ReSharper.Psi.Web.Impl.PsiModules.WebApp.Helpers
{
    
    public interface IWebAppSignificantModuleProvider : JetBrains.ReSharper.Psi.Web.Impl.PsiModules.IWebPsiModuleHandlerHelper
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Modules.IProjectPsiModule PrimaryModule { get; }
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Modules.IPsiModule> GetPsiModulesToReference();
    }
    [JetBrains.ReSharper.Psi.Web.Impl.PsiModules.WebApp.WebAppPsiModuleHandlerHelperFactoryAttribute()]
    public class WebAppAppCodeHelperFactory : JetBrains.ReSharper.Psi.Web.Impl.PsiModules.IWebPsiModuleHandlerHelperFactory, JetBrains.ReSharper.Psi.Web.Impl.PsiModules.WebApp.IWebAppPsiModuleHandlerHelperFactory
    {
        public WebAppAppCodeHelperFactory(JetBrains.ProjectModel.FileTypes.IProjectFileTypeServices projectFileTypeServices, JetBrains.ReSharper.Psi.Web.Impl.PsiModules.Website.WebProjectFileTypeClassifier webProjectFileTypeClassifier, JetBrains.ProjectModel.IProjectFileExtensions projectFileExtensions, JetBrains.Application.ChangeManager changeManager, JetBrains.Application.IShellLocks shellLocks, JetBrains.ReSharper.Psi.Web.BuildProviders.IWebsiteBuilders websiteBuilders, JetBrains.DocumentManagers.DocumentManager documentManager, JetBrains.ReSharper.Psi.PsiProjectFileTypeCoordinator psiProjectFileTypeCoordinator, JetBrains.ReSharper.Psi.Web.PsiModules.IWebAssemblyReferenceFactory webAssemblyReferenceFactory, JetBrains.ReSharper.Psi.PsiSourceFilePropertiesManager propertiesManager) { }
        public JetBrains.ReSharper.Psi.Web.Impl.PsiModules.IWebPsiModuleHandlerHelper CreateHelper(JetBrains.DataFlow.Lifetime helperLifetime, JetBrains.ReSharper.Psi.Web.Impl.PsiModules.IWebProjectPsiModuleHandler handler, JetBrains.ReSharper.Psi.Web.Cache.IWebConfigCache webConfigCache, JetBrains.ReSharper.Psi.Web.PsiModules.IAspFileDataCache aspFileDataCache) { }
    }
}
namespace JetBrains.ReSharper.Psi.Web.Impl.PsiModules.WebApp
{
    
    public interface IWebAppCommonReferenceProviderFactory : JetBrains.ReSharper.Psi.Web.Impl.PsiModules.IWebCommonReferenceProviderFactory { }
    public interface IWebAppPsiModuleHandlerHelperFactory : JetBrains.ReSharper.Psi.Web.Impl.PsiModules.IWebPsiModuleHandlerHelperFactory { }
    [JetBrains.Annotations.BaseTypeRequiredAttribute(typeof(JetBrains.ReSharper.Psi.Web.Impl.PsiModules.WebApp.IWebAppCommonReferenceProviderFactory))]
    [JetBrains.Annotations.MeansImplicitUseAttribute()]
    [System.AttributeUsageAttribute(System.AttributeTargets.Class | System.AttributeTargets.All, AllowMultiple=false, Inherited=true)]
    public class WebAppCommonReferenceProviderFactoryAttribute : JetBrains.ProjectModel.SolutionComponentAttribute { }
    [JetBrains.ReSharper.Psi.Modules.ModuleReferencerAttribute(Priority=0)]
    public class WebAppModuleReferencer : JetBrains.ReSharper.Psi.Modules.GenericModuleReferencer
    {
        public override bool CanReferenceModule(JetBrains.ReSharper.Psi.Modules.IPsiModule module, JetBrains.ReSharper.Psi.Modules.IPsiModule moduleToReference, JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext context) { }
    }
    public class WebAppPsiModuleHandler : JetBrains.ReSharper.Psi.Web.Impl.PsiModules.WebProjectPsiModuleHandlerBase
    {
        public WebAppPsiModuleHandler(JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IProject project, JetBrains.Application.ChangeManager changeManager, JetBrains.Application.IShellLocks locks, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Web.Impl.PsiModules.WebApp.IWebAppPsiModuleHandlerHelperFactory> helperProviders, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Web.Impl.PsiModules.WebApp.IWebAppCommonReferenceProviderFactory> referenceProviders, JetBrains.ReSharper.Psi.Web.PsiModules.IAspFileDataCache aspFileDataCache, JetBrains.ReSharper.Psi.Web.Cache.IWebConfigCache webConfigCache, JetBrains.ReSharper.Psi.Web.PsiModules.IWebAssemblyReferenceFactory assemblyReferenceFactory) { }
        public override JetBrains.ReSharper.Psi.Modules.IProjectPsiModule PrimaryModule { get; }
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Modules.IPsiModule> GetPsiModulesToReference() { }
    }
    [JetBrains.Annotations.BaseTypeRequiredAttribute(typeof(JetBrains.ReSharper.Psi.Web.Impl.PsiModules.WebApp.IWebAppPsiModuleHandlerHelperFactory))]
    [JetBrains.Annotations.MeansImplicitUseAttribute()]
    [System.AttributeUsageAttribute(System.AttributeTargets.Class | System.AttributeTargets.All, AllowMultiple=false, Inherited=true)]
    public class WebAppPsiModuleHandlerHelperFactoryAttribute : JetBrains.ProjectModel.SolutionComponentAttribute { }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class WebAppPsiModuleProvider : JetBrains.ReSharper.Psi.Modules.IProjectPsiModuleProvider
    {
        protected readonly System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Web.Impl.PsiModules.WebApp.IWebAppPsiModuleHandlerHelperFactory> HelperProviders;
        protected readonly System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Web.Impl.PsiModules.WebApp.IWebAppCommonReferenceProviderFactory> ReferenceProviders;
        public WebAppPsiModuleProvider(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Web.Impl.PsiModules.WebApp.IWebAppCommonReferenceProviderFactory> referenceProviders, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Web.Impl.PsiModules.WebApp.IWebAppPsiModuleHandlerHelperFactory> helperProviders) { }
        protected virtual JetBrains.ReSharper.Psi.Web.Impl.PsiModules.WebApp.WebAppPsiModuleHandler CreateWebAppPsiModuleHandler(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ProjectModel.IProject project, JetBrains.Application.IShellLocks locks, JetBrains.ReSharper.Psi.Web.PsiModules.IAspFileDataCache aspFileDataCache, JetBrains.ReSharper.Psi.Web.Cache.IWebConfigCache webConfigCache, JetBrains.Application.ChangeManager changeManager, JetBrains.ReSharper.Psi.Web.PsiModules.IWebAssemblyReferenceFactory assemblyReferenceFactory) { }
        public JetBrains.ReSharper.Psi.Modules.IProjectPsiModuleHandler TryCreate(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ProjectModel.IProject project) { }
    }
}
namespace JetBrains.ReSharper.Psi.Web.Impl.PsiModules.WebApp.Modules
{
    
    public interface IWebAppMainModule : JetBrains.ReSharper.Psi.Modules.IDecorableProjectPsiModule, JetBrains.ReSharper.Psi.Modules.IProjectPsiModule, JetBrains.ReSharper.Psi.Modules.IPsiModule { }
}
namespace JetBrains.ReSharper.Psi.Web.Impl.PsiModules.WebApp.ReferenceProviders
{
    
    [JetBrains.ReSharper.Psi.Web.Impl.PsiModules.WebApp.WebAppCommonReferenceProviderFactoryAttribute()]
    public class WebAppFoldersReferenceProviderFactory : JetBrains.ReSharper.Psi.Web.Impl.PsiModules.IWebCommonReferenceProviderFactory, JetBrains.ReSharper.Psi.Web.Impl.PsiModules.WebApp.IWebAppCommonReferenceProviderFactory
    {
        public WebAppFoldersReferenceProviderFactory(JetBrains.Application.FileSystemTracker.IFileSystemTracker fileSystemTracker, JetBrains.Application.IShellLocks shellLocks, JetBrains.ReSharper.Psi.Web.PsiModules.IWebAssemblyReferenceFactory webAssemblyReferenceFactory, JetBrains.ReSharper.Psi.Web.Cache.IWebConfigCache webConfigCache) { }
        public JetBrains.ReSharper.Psi.Web.Impl.PsiModules.IWebCommonReferenceProvider CreateReferenceProvider(JetBrains.DataFlow.Lifetime helperLifetime, JetBrains.ReSharper.Psi.Web.Impl.PsiModules.IWebProjectPsiModuleHandler handler, JetBrains.ReSharper.Psi.Web.PsiModules.IAspFileDataCache aspFileDataCache) { }
    }
}
namespace JetBrains.ReSharper.Psi.Web.Impl.PsiModules.Website.Helpers
{
    
    public class PsiSourceFilesContainer
    {
        public PsiSourceFilesContainer() { }
        public virtual void AddPsiSourceFile(JetBrains.ProjectModel.IProjectFile projectFile, JetBrains.ReSharper.Psi.IPsiSourceFile psiSourceFile, JetBrains.ReSharper.Psi.Modules.PsiModuleChangeBuilder changeBuilder) { }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Modules.IPsiModule> FindPsiModules(JetBrains.ProjectModel.IProjectFile projectFile) { }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Psi.IPsiSourceFile> FindPsiSourceFiles(JetBrains.ProjectModel.IProjectFile projectFile) { }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Psi.IPsiSourceFile> RemoveProjectFile(JetBrains.ProjectModel.IProjectFile projectFile, JetBrains.ReSharper.Psi.Modules.PsiModuleChangeBuilder changeBuilder) { }
        public virtual void RemovePsiSourceFile(JetBrains.ProjectModel.IProjectFile projectFile, JetBrains.ReSharper.Psi.IPsiSourceFile psiSourceFile, JetBrains.ReSharper.Psi.Modules.PsiModuleChangeBuilder changeBuilder) { }
    }
    public class WebsiteAppCodeHelper : JetBrains.ReSharper.Psi.Web.Impl.PsiModules.IWebCommonReferenceProvider, JetBrains.ReSharper.Psi.Web.Impl.PsiModules.IWebConfigChangesListener, JetBrains.ReSharper.Psi.Web.Impl.PsiModules.IWebPsiModuleHandlerHelper
    {
        public WebsiteAppCodeHelper(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ReSharper.Psi.Web.Impl.PsiModules.IWebProjectPsiModuleHandler handler, JetBrains.ReSharper.Psi.Web.Cache.IWebConfigCache webConfigCache, JetBrains.ProjectModel.FileTypes.IProjectFileTypeServices projectFileTypeServices, JetBrains.ReSharper.Psi.Web.Impl.PsiModules.Website.WebProjectFileTypeClassifier projectFileClassifier, JetBrains.ProjectModel.IProjectFileExtensions projectFileExtensions, JetBrains.Application.ChangeManager changeManager, JetBrains.Application.IShellLocks locks, JetBrains.ReSharper.Psi.Web.BuildProviders.IWebsiteBuilders websiteBuilders, JetBrains.DocumentManagers.DocumentManager documentManager, JetBrains.ReSharper.Psi.PsiProjectFileTypeCoordinator psiProjectFileTypeCoordinator, JetBrains.ReSharper.Psi.Web.PsiModules.IWebAssemblyReferenceFactory webAssemblyReferenceFactory, JetBrains.ReSharper.Psi.PsiSourceFilePropertiesManager propertiesManager) { }
        public double Priority { get; }
        public JetBrains.DataFlow.ISimpleSignal ReferencesChanged { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IPsiSourceFile> FindPsiSourceFiles(JetBrains.ProjectModel.IProjectFile projectFile) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Modules.IPsiModule> GetAllModules() { }
        public void GetCommonReferencesFor(JetBrains.ReSharper.Psi.Modules.IPsiModule psiModule, JetBrains.ReSharper.Psi.Web.Impl.PsiModules.PsiModuleReferenceAccumulator referenceAccumulator) { }
        public bool InternalsVisibleTo(JetBrains.ReSharper.Psi.Modules.IPsiModule moduleTo, JetBrains.ReSharper.Psi.Modules.IPsiModule moduleFrom) { }
        public void OnExternalModuleSetChanged(JetBrains.ReSharper.Psi.Modules.PsiModuleChangeBuilder changeBuilder) { }
        public bool OnProjectFileAdded(JetBrains.ProjectModel.IProjectFile projectFile, JetBrains.ReSharper.Psi.Modules.PsiModuleChangeBuilder changeBuilder, System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Web.Impl.PsiModules.IWebPsiModuleHandlerHelper> alreadyProcessedBy) { }
        public void OnProjectFileModified(JetBrains.ProjectModel.IProjectFile projectFile, JetBrains.ReSharper.Psi.Modules.PsiModuleChangeBuilder changeBuilder) { }
        public void OnProjectFileRemoved(JetBrains.ProjectModel.IProjectFile projectFile, JetBrains.ReSharper.Psi.Modules.PsiModuleChangeBuilder changeBuilder) { }
        public void OnProjectPropertiesChange(JetBrains.ReSharper.Psi.Modules.PsiModuleChangeBuilder changeBuilder) { }
        public void OnWebConfigChanged(System.Collections.Generic.ICollection<JetBrains.Util.JetTuple<JetBrains.ProjectModel.IProjectFile, JetBrains.Util.FileSystemPath, JetBrains.ReSharper.Psi.Web.Cache.WebConfigChangeType>> tuples, JetBrains.ReSharper.Psi.Modules.PsiModuleChangeBuilder changeBuilder) { }
    }
    [JetBrains.ReSharper.Psi.Web.Impl.PsiModules.Website.WebsitePsiModuleHandlerHelperFactoryAttribute()]
    public class WebsiteAppCodeHelperFactory : JetBrains.ReSharper.Psi.Web.Impl.PsiModules.IWebPsiModuleHandlerHelperFactory, JetBrains.ReSharper.Psi.Web.Impl.PsiModules.Website.IWebsitePsiModuleHandlerHelperFactory
    {
        public WebsiteAppCodeHelperFactory(JetBrains.ProjectModel.FileTypes.IProjectFileTypeServices projectFileTypeServices, JetBrains.ReSharper.Psi.Web.Impl.PsiModules.Website.WebProjectFileTypeClassifier webProjectFileTypeClassifier, JetBrains.ProjectModel.IProjectFileExtensions projectFileExtensions, JetBrains.Application.ChangeManager changeManager, JetBrains.Application.IShellLocks shellLocks, JetBrains.ReSharper.Psi.Web.BuildProviders.IWebsiteBuilders websiteBuilders, JetBrains.DocumentManagers.DocumentManager documentManager, JetBrains.ReSharper.Psi.PsiProjectFileTypeCoordinator psiProjectFileTypeCoordinator, JetBrains.ReSharper.Psi.Web.PsiModules.IWebAssemblyReferenceFactory webAssemblyReferenceFactory, JetBrains.ReSharper.Psi.PsiSourceFilePropertiesManager propertiesManager) { }
        public JetBrains.ReSharper.Psi.Web.Impl.PsiModules.IWebPsiModuleHandlerHelper CreateHelper(JetBrains.DataFlow.Lifetime helperLifetime, JetBrains.ReSharper.Psi.Web.Impl.PsiModules.IWebProjectPsiModuleHandler handler, JetBrains.ReSharper.Psi.Web.Cache.IWebConfigCache webConfigCache, JetBrains.ReSharper.Psi.Web.PsiModules.IAspFileDataCache aspFileDataCache) { }
    }
    public class WebsiteWebReferencesHelper : JetBrains.ReSharper.Psi.Web.Impl.PsiModules.IWebCommonReferenceProvider, JetBrains.ReSharper.Psi.Web.Impl.PsiModules.IWebPsiModuleHandlerHelper
    {
        public WebsiteWebReferencesHelper(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ReSharper.Psi.Web.Impl.PsiModules.IWebProjectPsiModuleHandler handler, JetBrains.ProjectModel.IProjectFileExtensions projectFileExtensions, JetBrains.ReSharper.Psi.PsiProjectFileTypeCoordinator psiProjectFileTypeCoordinator, JetBrains.Application.ChangeManager changeManager, JetBrains.Application.IShellLocks locks, JetBrains.ReSharper.Psi.Web.BuildProviders.IWebsiteBuilders websiteBuilders, JetBrains.DocumentManagers.DocumentManager documentManager, JetBrains.ReSharper.Psi.Web.PsiModules.IWebAssemblyReferenceFactory webAssemblyReferenceFactory, JetBrains.ReSharper.Psi.PsiSourceFilePropertiesManager propertiesManager) { }
        public double Priority { get; }
        public JetBrains.DataFlow.ISimpleSignal ReferencesChanged { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IPsiSourceFile> FindPsiSourceFiles(JetBrains.ProjectModel.IProjectFile projectFile) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Modules.IPsiModule> GetAllModules() { }
        public void GetCommonReferencesFor(JetBrains.ReSharper.Psi.Modules.IPsiModule psiModule, JetBrains.ReSharper.Psi.Web.Impl.PsiModules.PsiModuleReferenceAccumulator referenceAccumulator) { }
        public void OnExternalModuleSetChanged(JetBrains.ReSharper.Psi.Modules.PsiModuleChangeBuilder changeBuilder) { }
        public bool OnProjectFileAdded(JetBrains.ProjectModel.IProjectFile projectFile, JetBrains.ReSharper.Psi.Modules.PsiModuleChangeBuilder changeBuilder, System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Web.Impl.PsiModules.IWebPsiModuleHandlerHelper> alreadyProcessedBy) { }
        public void OnProjectFileModified(JetBrains.ProjectModel.IProjectFile projectFile, JetBrains.ReSharper.Psi.Modules.PsiModuleChangeBuilder changeBuilder) { }
        public void OnProjectFileRemoved(JetBrains.ProjectModel.IProjectFile projectFile, JetBrains.ReSharper.Psi.Modules.PsiModuleChangeBuilder changeBuilder) { }
        public void OnProjectPropertiesChange(JetBrains.ReSharper.Psi.Modules.PsiModuleChangeBuilder changeBuilder) { }
    }
    [JetBrains.ReSharper.Psi.Web.Impl.PsiModules.Website.WebsitePsiModuleHandlerHelperFactoryAttribute()]
    public class WebsiteWebReferencesHelperFactory : JetBrains.ReSharper.Psi.Web.Impl.PsiModules.IWebPsiModuleHandlerHelperFactory, JetBrains.ReSharper.Psi.Web.Impl.PsiModules.Website.IWebsitePsiModuleHandlerHelperFactory
    {
        public WebsiteWebReferencesHelperFactory(JetBrains.Application.FileSystemTracker.IFileSystemTracker fileSystemTracker, JetBrains.ProjectModel.IProjectFileExtensions projectFileExtensions, JetBrains.Application.IShellLocks locks, JetBrains.ReSharper.Psi.PsiProjectFileTypeCoordinator psiProjectFileTypeCoordinator, JetBrains.Application.ChangeManager changeManager, JetBrains.ReSharper.Psi.Web.BuildProviders.IWebsiteBuilderFactory factory, JetBrains.DocumentManagers.DocumentManager documentManager, JetBrains.ReSharper.Psi.Web.BuildProviders.IWebsiteBuilders websiteBuilders, JetBrains.ReSharper.Psi.Web.PsiModules.IWebAssemblyReferenceFactory webAssemblyReferenceFactory, JetBrains.ReSharper.Psi.PsiSourceFilePropertiesManager propertiesManager) { }
        public JetBrains.ReSharper.Psi.Web.Impl.PsiModules.IWebPsiModuleHandlerHelper CreateHelper(JetBrains.DataFlow.Lifetime helperLifetime, JetBrains.ReSharper.Psi.Web.Impl.PsiModules.IWebProjectPsiModuleHandler handler, JetBrains.ReSharper.Psi.Web.Cache.IWebConfigCache webConfigCache, JetBrains.ReSharper.Psi.Web.PsiModules.IAspFileDataCache aspFileDataCache) { }
    }
}
namespace JetBrains.ReSharper.Psi.Web.Impl.PsiModules.Website
{
    
    public interface IWebsiteCommonReferenceProviderFactory : JetBrains.ReSharper.Psi.Web.Impl.PsiModules.IWebCommonReferenceProviderFactory { }
    public interface IWebsitePsiModuleHandlerHelperFactory : JetBrains.ReSharper.Psi.Web.Impl.PsiModules.IWebPsiModuleHandlerHelperFactory { }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class WebProjectFileTypeClassifier
    {
        public WebProjectFileTypeClassifier(JetBrains.ProjectModel.FileTypes.IProjectFileTypeServices projectFileTypeServices) { }
        public bool IsAppCodeFile(JetBrains.ProjectModel.IProjectFile projectFile) { }
        public bool IsAspFile(JetBrains.ProjectModel.IProjectFile projectFile) { }
        public bool IsCodeBehindFile(JetBrains.ProjectModel.IProjectFile projectFile) { }
    }
    [JetBrains.Annotations.BaseTypeRequiredAttribute(typeof(JetBrains.ReSharper.Psi.Web.Impl.PsiModules.Website.IWebsiteCommonReferenceProviderFactory))]
    [JetBrains.Annotations.MeansImplicitUseAttribute()]
    [System.AttributeUsageAttribute(System.AttributeTargets.Class | System.AttributeTargets.All, AllowMultiple=false, Inherited=true)]
    public class WebsiteCommonReferenceProviderFactoryAttribute : JetBrains.ProjectModel.SolutionComponentAttribute { }
    public class WebsitePsiModuleHandler : JetBrains.ReSharper.Psi.Web.Impl.PsiModules.WebProjectPsiModuleHandlerBase
    {
        public WebsitePsiModuleHandler(JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IProject website, JetBrains.ReSharper.Psi.Web.PsiModules.IAspFileDataCache aspFileDataCache, JetBrains.ReSharper.Psi.Web.Cache.IWebConfigCache webConfigCache, JetBrains.Application.ChangeManager changeManager, JetBrains.Application.IShellLocks locks, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Web.Impl.PsiModules.Website.IWebsitePsiModuleHandlerHelperFactory> helperProviders, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Web.Impl.PsiModules.Website.IWebsiteCommonReferenceProviderFactory> referenceProviders, JetBrains.ReSharper.Psi.Web.PsiModules.IWebAssemblyReferenceFactory assemblyReferenceFactory, JetBrains.ReSharper.Psi.PsiProjectFileTypeCoordinator psiProjectFileTypeCoordinator) { }
        public override JetBrains.ReSharper.Psi.Modules.IProjectPsiModule PrimaryModule { get; }
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Modules.IPsiModule> GetPsiModulesToReference() { }
    }
    [JetBrains.Annotations.BaseTypeRequiredAttribute(typeof(JetBrains.ReSharper.Psi.Web.Impl.PsiModules.Website.IWebsitePsiModuleHandlerHelperFactory))]
    [JetBrains.Annotations.MeansImplicitUseAttribute()]
    [System.AttributeUsageAttribute(System.AttributeTargets.Class | System.AttributeTargets.All, AllowMultiple=false, Inherited=true)]
    public class WebsitePsiModuleHandlerHelperFactoryAttribute : JetBrains.ProjectModel.SolutionComponentAttribute { }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class WebsitePsiModuleProvider : JetBrains.ReSharper.Psi.Modules.IProjectPsiModuleProvider
    {
        protected readonly System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Web.Impl.PsiModules.Website.IWebsitePsiModuleHandlerHelperFactory> HelperProviders;
        protected readonly JetBrains.ReSharper.Psi.PsiProjectFileTypeCoordinator myPsiProjectFileTypeCoordinator;
        protected readonly System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Web.Impl.PsiModules.Website.IWebsiteCommonReferenceProviderFactory> ReferenceProviders;
        public WebsitePsiModuleProvider(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Web.Impl.PsiModules.Website.IWebsiteCommonReferenceProviderFactory> referenceProviders, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Web.Impl.PsiModules.Website.IWebsitePsiModuleHandlerHelperFactory> helperProviders, JetBrains.ReSharper.Psi.PsiProjectFileTypeCoordinator psiProjectFileTypeCoordinator) { }
        protected virtual JetBrains.ReSharper.Psi.Web.Impl.PsiModules.Website.WebsitePsiModuleHandler CreateWebsitePsiModuleHandler(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ProjectModel.IProject project, JetBrains.Application.IShellLocks locks, JetBrains.ReSharper.Psi.Web.PsiModules.IAspFileDataCache aspFileDataCache, JetBrains.ReSharper.Psi.Web.Cache.IWebConfigCache webConfigCache, JetBrains.Application.ChangeManager changeManager, JetBrains.ReSharper.Psi.Web.PsiModules.IWebAssemblyReferenceFactory assemblyReferenceFactory) { }
        public JetBrains.ReSharper.Psi.Modules.IProjectPsiModuleHandler TryCreate(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ProjectModel.IProject project) { }
    }
}
namespace JetBrains.ReSharper.Psi.Web.Impl.PsiModules.Website.Modules
{
    
    public interface IAppCodeModule : JetBrains.ReSharper.Psi.Modules.IPsiModule, JetBrains.ReSharper.Psi.Web.Impl.PsiModules.Website.Modules.IAppCodeModuleBase, JetBrains.ReSharper.Psi.Web.Impl.PsiModules.Website.Modules.IWebsitePsiModule { }
    public interface IAppCodeModuleBase : JetBrains.ReSharper.Psi.Modules.IPsiModule, JetBrains.ReSharper.Psi.Web.Impl.PsiModules.Website.Modules.IWebsitePsiModule { }
    public interface IAppCodeSubfolderModule : JetBrains.ReSharper.Psi.Modules.IPsiModule, JetBrains.ReSharper.Psi.Web.Impl.PsiModules.Website.Modules.IAppCodeModuleBase, JetBrains.ReSharper.Psi.Web.Impl.PsiModules.Website.Modules.IWebsitePsiModule
    {
        JetBrains.Util.FileSystemPath FolderPath { get; }
    }
    public interface IWebsitePsiModule : JetBrains.ReSharper.Psi.Modules.IPsiModule { }
    public abstract class WebModuleWithGeneratedFiles : JetBrains.ReSharper.Psi.Modules.ProjectPsiModuleBase
    {
        public WebModuleWithGeneratedFiles(JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IProject project, [JetBrains.Annotations.NotNullAttribute()] string nameSuffix, JetBrains.Util.FileSystemPath generatedFilesFolder, JetBrains.ProjectModel.IProjectFileExtensions projectFileExtensions, JetBrains.DocumentManagers.DocumentManager documentManager, JetBrains.ReSharper.Psi.PsiProjectFileTypeCoordinator psiProjectFileTypeCoordinator, JetBrains.ReSharper.Psi.Web.PsiModules.IWebAssemblyReferenceFactory webAssemblyReferenceFactory) { }
        public System.Collections.Generic.Dictionary<JetBrains.Util.FileSystemPath, JetBrains.ReSharper.Psi.IPsiSourceFileWithLocation> GeneratedFiles { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        protected virtual JetBrains.ReSharper.Psi.IPsiSourceFileWithLocation AddGeneratedFile(JetBrains.Util.FileSystemPath existingFile) { }
        protected override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Modules.IPsiModuleReference> GetReferencesInternal() { }
        protected override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IPsiSourceFile> GetSourceFiles() { }
        public void RebuildGeneratedFiles(JetBrains.ReSharper.Psi.Modules.PsiModuleChangeBuilder changeBuilder) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        protected virtual JetBrains.ReSharper.Psi.IPsiSourceFileWithLocation RemoveGeneratedFile(JetBrains.Util.FileSystemPath removedPath) { }
    }
    public class WebSiteMainModule : JetBrains.ReSharper.Psi.Modules.ProjectPsiModuleBase, JetBrains.ReSharper.Psi.Modules.IDecorableProjectPsiModule, JetBrains.ReSharper.Psi.Modules.IProjectPsiModule, JetBrains.ReSharper.Psi.Modules.IPsiModule, JetBrains.ReSharper.Psi.Web.Impl.PsiModules.Website.Modules.IWebsitePsiModule
    {
        public WebSiteMainModule(JetBrains.ReSharper.Psi.Web.Impl.PsiModules.IWebProjectPsiModuleHandler handler, JetBrains.ReSharper.Psi.PsiProjectFileTypeCoordinator psiProjectFileTypeCoordinator) { }
        protected override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Modules.IPsiModuleReference> GetReferencesInternal() { }
    }
}
namespace JetBrains.ReSharper.Psi.Web.Impl.PsiModules.Website.Properties
{
    
    public interface IWebsiteAppCodePsiSourceFilePropertiesFactory
    {
        JetBrains.ReSharper.Psi.IPsiSourceFileProperties CreateProperties(JetBrains.ProjectModel.IProjectFile projectFile, JetBrains.ReSharper.Psi.IPsiSourceFile psiSourceFile, JetBrains.ReSharper.Psi.PsiSourceFilePropertiesManager propertiesManager, JetBrains.ReSharper.Psi.Web.Cache.IWebConfigCache webConfigCache);
    }
    public class WebsiteAppCodePsiSourceFileProperties : JetBrains.ReSharper.Psi.Web.Impl.PsiModules.Website.Properties.WebsitePsiSourceFileProperties
    {
        public WebsiteAppCodePsiSourceFileProperties(JetBrains.ProjectModel.IProjectFile projectFile, JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, JetBrains.ReSharper.Psi.PsiSourceFilePropertiesManager propertiesManager) { }
    }
    public class WebsitePsiSourceFileProperties : JetBrains.ReSharper.Psi.Impl.DefaultPsiProjectFileProperties
    {
        public WebsitePsiSourceFileProperties(JetBrains.ProjectModel.IProjectFile projectFile, JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, JetBrains.ReSharper.Psi.PsiSourceFilePropertiesManager propertiesManager) { }
        protected WebsitePsiSourceFileProperties(JetBrains.ProjectModel.IProjectFile projectFile, JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, JetBrains.ReSharper.Psi.PsiSourceFilePropertiesManager propertiesManager, bool shouldBuildPsi) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        protected JetBrains.ReSharper.Psi.IPsiSourceFileProperties BaseProperties { get; }
        public override bool IsGeneratedFile { get; }
        public override bool IsICacheParticipant { get; }
        public override bool IsNonUserFile { get; }
        public override bool ProvidesCodeModel { get; }
        public override bool ShouldBuildPsi { get; }
        public static JetBrains.ReSharper.Psi.Web.Impl.PsiModules.Website.Properties.WebsitePsiSourceFileProperties CreateNoPsi(JetBrains.ProjectModel.IProjectFile projectFile, JetBrains.ReSharper.Psi.IPsiSourceFile psiSourceFile, JetBrains.ReSharper.Psi.PsiSourceFilePropertiesManager propertiesManager) { }
    }
}
namespace JetBrains.ReSharper.Psi.Web.Impl.PsiModules.Website.ReferenceProviders
{
    
    public class WebFoldersReferenceProvider : JetBrains.ReSharper.Psi.Web.Impl.PsiModules.IWebCommonReferenceProvider, JetBrains.ReSharper.Psi.Web.Impl.PsiModules.IWebConfigChangesListener
    {
        public WebFoldersReferenceProvider(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ReSharper.Psi.Web.Impl.PsiModules.IWebProjectPsiModuleHandler handler, System.Collections.Generic.ICollection<JetBrains.Util.FileSystemPath> foldersToWatch, JetBrains.Application.FileSystemTracker.IFileSystemTracker fileSystemTracker, JetBrains.ReSharper.Psi.Web.PsiModules.IWebAssemblyReferenceFactory assemblyReferenceFactory, JetBrains.Application.IShellLocks shellLocks, JetBrains.ReSharper.Psi.Web.Cache.IWebConfigCache webConfigCache) { }
        public JetBrains.DataFlow.ISimpleSignal ReferencesChanged { get; }
        public void GetCommonReferencesFor(JetBrains.ReSharper.Psi.Modules.IPsiModule psiModule, JetBrains.ReSharper.Psi.Web.Impl.PsiModules.PsiModuleReferenceAccumulator referenceAccumulator) { }
        public bool InternalsVisibleTo(JetBrains.ReSharper.Psi.Modules.IPsiModule moduleTo, JetBrains.ReSharper.Psi.Modules.IPsiModule moduleFrom) { }
        public void OnWebConfigChanged(System.Collections.Generic.ICollection<JetBrains.Util.JetTuple<JetBrains.ProjectModel.IProjectFile, JetBrains.Util.FileSystemPath, JetBrains.ReSharper.Psi.Web.Cache.WebConfigChangeType>> tuples, JetBrains.ReSharper.Psi.Modules.PsiModuleChangeBuilder changeBuilder) { }
    }
    [JetBrains.ReSharper.Psi.Web.Impl.PsiModules.Website.WebsiteCommonReferenceProviderFactoryAttribute()]
    public class WebsiteFoldersReferenceProviderFactory : JetBrains.ReSharper.Psi.Web.Impl.PsiModules.IWebCommonReferenceProviderFactory, JetBrains.ReSharper.Psi.Web.Impl.PsiModules.Website.IWebsiteCommonReferenceProviderFactory
    {
        public WebsiteFoldersReferenceProviderFactory(JetBrains.Application.FileSystemTracker.IFileSystemTracker fileSystemTracker, JetBrains.Application.IShellLocks shellLocks, JetBrains.ReSharper.Psi.Web.PsiModules.IWebAssemblyReferenceFactory webAssemblyReferenceFactory, JetBrains.ReSharper.Psi.Web.Cache.IWebConfigCache webConfigCache) { }
        public JetBrains.ReSharper.Psi.Web.Impl.PsiModules.IWebCommonReferenceProvider CreateReferenceProvider(JetBrains.DataFlow.Lifetime helperLifetime, JetBrains.ReSharper.Psi.Web.Impl.PsiModules.IWebProjectPsiModuleHandler handler, JetBrains.ReSharper.Psi.Web.PsiModules.IAspFileDataCache aspFileDataCache) { }
    }
    [JetBrains.ReSharper.Psi.Web.Impl.PsiModules.Website.WebsiteCommonReferenceProviderFactoryAttribute()]
    public class WebsiteProjectReferenceProviderFactory : JetBrains.ReSharper.Psi.Web.Impl.PsiModules.IWebCommonReferenceProviderFactory, JetBrains.ReSharper.Psi.Web.Impl.PsiModules.Website.IWebsiteCommonReferenceProviderFactory
    {
        public WebsiteProjectReferenceProviderFactory(JetBrains.Application.ChangeManager changeManager) { }
        public JetBrains.ReSharper.Psi.Web.Impl.PsiModules.IWebCommonReferenceProvider CreateReferenceProvider(JetBrains.DataFlow.Lifetime helperLifetime, JetBrains.ReSharper.Psi.Web.Impl.PsiModules.IWebProjectPsiModuleHandler handler, JetBrains.ReSharper.Psi.Web.PsiModules.IAspFileDataCache aspFileDataCache) { }
    }
}
namespace JetBrains.ReSharper.Psi.Web.Impl.Services
{
    
    public interface ISourceFilesFilter
    {
        System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.IPsiSourceFile> FilterSourceFiles(System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.IPsiSourceFile> sourceFiles);
    }
}
namespace JetBrains.ReSharper.Psi.Web.Impl.Symbols
{
    
    public class static ProjectsDependenciesUtil
    {
        public static bool IsVisible(JetBrains.ReSharper.Psi.IPsiSourceFile fromFile, JetBrains.ReSharper.Psi.Modules.IPsiModule module) { }
    }
    public abstract class WebClassSymbol : JetBrains.ReSharper.Psi.Web.Impl.Symbols.WebSymbolBase, JetBrains.ReSharper.Psi.Web.Symbols.IWebClassSymbol, JetBrains.ReSharper.Psi.Web.Symbols.IWebSymbol
    {
        protected WebClassSymbol(string name, int startOffset, JetBrains.ReSharper.Psi.IPsiSourceFile file, JetBrains.ReSharper.Psi.Web.Symbols.WebVisibilityScope declarationPlace) { }
        public override bool Equals(object obj) { }
        protected bool Equals(JetBrains.ReSharper.Psi.Web.Symbols.IWebClassSymbol other) { }
        public abstract JetBrains.ReSharper.Psi.Web.DeclaredElements.ICssClassDeclaredElement GetDeclaredElement();
        public override int GetHashCode() { }
    }
    public abstract class WebSymbolBase : JetBrains.ReSharper.Psi.Web.Symbols.IWebSymbol
    {
        protected WebSymbolBase(string name, int startOffset, JetBrains.ReSharper.Psi.IPsiSourceFile file, JetBrains.ReSharper.Psi.Web.Symbols.WebVisibilityScope declarationPlace) { }
        public string Name { get; }
        public abstract string ProviderId { get; }
        public JetBrains.ReSharper.Psi.IPsiSourceFile SourceFile { get; }
        public int StartOffset { get; }
        public JetBrains.ReSharper.Psi.Web.Symbols.WebVisibilityScope VisibilityScope { get; }
        protected bool Equals(JetBrains.ReSharper.Psi.Web.Symbols.IWebSymbol other) { }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
    }
    [JetBrains.ReSharper.Psi.PsiComponentAttribute()]
    public class WebSymbolsCache : JetBrains.ReSharper.Psi.Caches.ICache, JetBrains.ReSharper.Psi.Web.Symbols.IWebSymbolsCache
    {
        public WebSymbolsCache(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.IShellLocks shellLocks, JetBrains.DataFlow.IViewable<JetBrains.ReSharper.Psi.Web.Symbols.IWebSymbolsProvider> providers, JetBrains.ReSharper.Psi.IPsiConfiguration psiConfiguration, JetBrains.ReSharper.Psi.Caches.IPersistentIndexManager persistentIndexManager, JetBrains.ReSharper.Psi.Util.CommonIdentifierIntern commonIdentifierIntern) { }
        protected virtual string CacheDirectoryName { get; }
        public bool HasDirtyFiles { get; }
        protected virtual string LoadSaveProgressText { get; }
        protected virtual int Version { get; }
        public System.Collections.Generic.IEnumerable<string> GetNames() { }
        public System.Collections.Generic.IEnumerable<string> GetNames(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
        public System.Collections.Generic.IEnumerable<T> GetSymbols<T>(string name)
            where T :  class, JetBrains.ReSharper.Psi.Web.Symbols.IWebSymbol { }
        public System.Collections.Generic.IEnumerable<T> GetSymbols<T>()
            where T :  class, JetBrains.ReSharper.Psi.Web.Symbols.IWebSymbol { }
        public System.Collections.Generic.IEnumerable<T> GetSymbols<T>(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile)
            where T :  class, JetBrains.ReSharper.Psi.Web.Symbols.IWebSymbol { }
        public void MarkAsDirty(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
        public void MergeLoaded(object data) { }
        protected virtual System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.Web.Symbols.IWebSymbol> ReadSymbols(JetBrains.ReSharper.Psi.IPsiSourceFile file, System.IO.BinaryReader reader, JetBrains.ReSharper.Psi.Util.ITokenIntern intern) { }
        protected virtual void WriteSymbols(System.IO.BinaryWriter writer, JetBrains.ReSharper.Psi.IPsiSourceFile file, System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.Web.Symbols.IWebSymbol> data) { }
    }
    public abstract class WebSymbolsProviderBase<T> : JetBrains.ReSharper.Psi.Web.Symbols.IWebSymbolsProvider
        where T :  class, JetBrains.ReSharper.Psi.Web.Symbols.IWebSymbol
    {
        public abstract string Id { get; }
        public abstract bool IsEnabled { get; }
        public virtual int Version { get; }
        public virtual System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Web.Symbols.IWebSymbol> BuildSymbols(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
        protected abstract JetBrains.ReSharper.Psi.IRecursiveElementProcessor CreateProcessor(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, System.Collections.Generic.List<JetBrains.ReSharper.Psi.Web.Symbols.IWebSymbol> symbols);
        protected abstract System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Tree.IFile> GetPsiFiles(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile);
        protected abstract T ReadSymbol(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, System.IO.BinaryReader reader, JetBrains.ReSharper.Psi.Util.ITokenIntern identifierIntern);
        public abstract bool Support(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile);
        public override string ToString() { }
        protected abstract void WriteSymbol(System.IO.BinaryWriter writer, T symbol);
    }
    public abstract class WebSymbolsSimpleProviderBase<T> : JetBrains.ReSharper.Psi.Web.Impl.Symbols.WebSymbolsProviderBase<T>
        where T :  class, JetBrains.ReSharper.Psi.Web.Symbols.IWebSymbol
    {
        protected abstract T CreateSymbol(string name, int offset, JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, JetBrains.ReSharper.Psi.Web.Symbols.WebVisibilityScope scope);
        protected virtual T ReadSymbol(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, System.IO.BinaryReader reader, JetBrains.ReSharper.Psi.Util.ITokenIntern identifierIntern) { }
        protected virtual void WriteSymbol(System.IO.BinaryWriter writer, T symbol) { }
    }
    public abstract class WebTagIdSymbol : JetBrains.ReSharper.Psi.Web.Symbols.IWebSymbol, JetBrains.ReSharper.Psi.Web.Symbols.IWebTagIdSymbol
    {
        protected WebTagIdSymbol(string name, int offset, JetBrains.ReSharper.Psi.IPsiSourceFile file, JetBrains.ReSharper.Psi.Web.Symbols.WebVisibilityScope declarationPlace) { }
        public string Name { get; }
        public abstract string ProviderId { get; }
        public JetBrains.ReSharper.Psi.IPsiSourceFile SourceFile { get; }
        public int StartOffset { get; }
        public JetBrains.ReSharper.Psi.Web.Symbols.WebVisibilityScope VisibilityScope { get; }
        public bool Equals(JetBrains.ReSharper.Psi.Web.Symbols.IWebTagIdSymbol other) { }
        public override bool Equals(object obj) { }
        public abstract JetBrains.ReSharper.Psi.Web.DeclaredElements.IHtmlTagIdDeclaredElement GetDeclaredElement();
        public override int GetHashCode() { }
    }
}
namespace JetBrains.ReSharper.Psi.Web.Impl.TagPrefixes
{
    
    public class GlobalTagPrefix : JetBrains.ReSharper.Psi.IDeclaredElement, JetBrains.ReSharper.Psi.Web.TagPrefixes.IGlobalTagPrefix, JetBrains.ReSharper.Psi.Web.TagPrefixes.ITagPrefix
    {
        public GlobalTagPrefix(string shortName, System.Collections.Generic.IEnumerable<string> namespaceNames, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.ISolution solution) { }
        public bool CaseSensistiveName { get; }
        public System.Collections.Generic.IEnumerable<string> NamespaceNames { get; }
        public JetBrains.ReSharper.Psi.PsiLanguageType PresentationLanguage { get; }
        public string ShortName { get; }
        public JetBrains.ReSharper.Psi.Web.TagPrefixes.ITagPrefixDeclaration GetDeclaration() { }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Tree.IDeclaration> GetDeclarations() { }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Tree.IDeclaration> GetDeclarationsIn(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
        public JetBrains.ReSharper.Psi.DeclaredElementType GetElementType() { }
        public JetBrains.ReSharper.Psi.IPsiServices GetPsiServices() { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.INamespace> GetReferencedNamespaces(JetBrains.ReSharper.Psi.Modules.IPsiModule currentModule, JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext context) { }
        public JetBrains.Util.DataStructures.HybridCollection<JetBrains.ReSharper.Psi.IPsiSourceFile> GetSourceFiles() { }
        public System.Xml.XmlNode GetXMLDescriptionSummary(bool inherit) { }
        public System.Xml.XmlNode GetXMLDoc(bool inherit) { }
        public bool HasDeclarationsIn(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
        public bool IsSynthetic() { }
        public bool IsValid() { }
    }
    public abstract class TagNameBase : JetBrains.ReSharper.Psi.ExtensionsAPI.Caches2.CachedTypeMemberBase, JetBrains.ReSharper.Psi.IDeclaredElement, JetBrains.ReSharper.Psi.Web.TagPrefixes.ITagName
    {
        protected TagNameBase(JetBrains.ReSharper.Psi.Web.TagPrefixes.ITagNameDeclaration declaration) { }
        public bool CaseSensistiveName { get; }
        public JetBrains.ReSharper.Psi.Resolve.ISubstitution IdSubstitution { get; }
        public string ShortName { get; }
        public string XMLDocId { get; }
        public JetBrains.ReSharper.Psi.ITypeMember GetContainingTypeMember() { }
        public abstract JetBrains.ReSharper.Psi.DeclaredElementType GetElementType();
        public JetBrains.ReSharper.Psi.Web.TagPrefixes.ITagPrefix GetParentTagPrefix() { }
        public System.Xml.XmlNode GetXMLDescriptionSummary(bool inherit) { }
        public System.Xml.XmlNode GetXMLDoc(bool inherit) { }
        public bool IsSynthetic() { }
    }
    public abstract class TagPrefixBase : JetBrains.ReSharper.Psi.ExtensionsAPI.Caches2.CachedTypeMemberBase, JetBrains.ReSharper.Psi.IDeclaredElement, JetBrains.ReSharper.Psi.Web.TagPrefixes.ITagPrefix
    {
        protected TagPrefixBase(JetBrains.ReSharper.Psi.Web.TagPrefixes.ITagPrefixDeclaration declaration) { }
        public bool CaseSensistiveName { get; }
        public JetBrains.ReSharper.Psi.Resolve.ISubstitution IdSubstitution { get; }
        public string ShortName { get; }
        public string XMLDocId { get; }
        public override bool Equals(object obj) { }
        public JetBrains.ReSharper.Psi.ITypeMember GetContainingTypeMember() { }
        public override System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Tree.IDeclaration> GetDeclarations() { }
        public override System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Tree.IDeclaration> GetDeclarationsIn(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
        public abstract JetBrains.ReSharper.Psi.DeclaredElementType GetElementType();
        public override int GetHashCode() { }
        public System.Xml.XmlNode GetXMLDescriptionSummary(bool inherit) { }
        public System.Xml.XmlNode GetXMLDoc(bool inherit) { }
        public bool IsSynthetic() { }
    }
    public class static TagPrefixImplUtil
    {
        public static bool Equals(JetBrains.ReSharper.Psi.Web.TagPrefixes.ITagPrefix p1, JetBrains.ReSharper.Psi.Web.TagPrefixes.ITagPrefix p2) { }
        public static System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Tree.IDeclaration> GetDeclarations(JetBrains.ReSharper.Psi.Web.TagPrefixes.ITagPrefix tagPrefix) { }
        public static System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Tree.IDeclaration> GetDeclarationsIn(JetBrains.ReSharper.Psi.Web.TagPrefixes.ITagPrefix tagPrefix, JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
        public static int GetHashCode(JetBrains.ReSharper.Psi.Web.TagPrefixes.ITagPrefix tagPrefix) { }
    }
}
namespace JetBrains.ReSharper.Psi.Web.Impl.WebConfig.Cache
{
    
    public class CollectConfigSourcesElementFactory : JetBrains.ReSharper.Psi.Xml.Parsing.DelegatingXmlElementFactory
    {
        public CollectConfigSourcesElementFactory(JetBrains.ReSharper.Psi.Xml.Parsing.IXmlElementFactory factory) { }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IConfigSourceAttribute> ConfigSourceAttributes { get; }
        public override JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttribute CreateAttribute(JetBrains.ReSharper.Psi.Xml.Tree.IXmlIdentifier nameIdentifier, JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttributeContainer attributeContainer, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagContainer parentTag, JetBrains.ReSharper.Psi.Xml.Parsing.IXmlElementFactoryContext context) { }
    }
    public class TagPrefixesInfoImpl : JetBrains.ReSharper.Psi.Web.Cache.TagPrefixesInfo
    {
        public static readonly JetBrains.ReSharper.Psi.Web.Impl.WebConfig.Cache.TagPrefixesInfoImpl Empty;
        public TagPrefixesInfoImpl([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Web.Impl.WebConfig.Cache.TagPrefixesInfoImpl parentInfo) { }
        public TagPrefixesInfoImpl([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IPagesTag pagesConfig, JetBrains.Util.FileSystemPath basePath) { }
        public override JetBrains.Util.OneToListMap<JetBrains.ReSharper.Psi.Web.Cache.TagPrefixesInfo.TagPrefixNamePair, JetBrains.Util.Pair<JetBrains.Util.FileSystemPath, string>> FullTagNameToPathMap { get; }
        public override JetBrains.Util.OneToListMap<string, string> PrefixToNamespaceMap { get; }
        public void Append(JetBrains.ReSharper.Psi.Web.Impl.WebConfig.Cache.TagPrefixesInfoImpl tagPrefixesInfo) { }
    }
    [JetBrains.ReSharper.Psi.PsiComponentAttribute()]
    public class WebConfigCacheImpl : JetBrains.ReSharper.Psi.Web.Cache.WebConfigProjectFileCacheBase<JetBrains.ReSharper.Psi.Web.Impl.WebConfig.Cache.WebConfigCompoundData>, JetBrains.ReSharper.Psi.Web.Cache.IWebConfigCache
    {
        public WebConfigCacheImpl(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.ChangeManager changeManager, JetBrains.ReSharper.Psi.Web.WebConfig.LinkedConfigurationManager configurationManager, JetBrains.Application.IShellLocks shellLocks, JetBrains.DataFlow.Lifetime lifetime, JetBrains.DocumentManagers.DocumentManager documentManager, JetBrains.ProjectModel.Sharepoint.ISharepointFilesLocator sharepointFilesLocator, JetBrains.ProjectModel.PlatformManager platformManager, JetBrains.ReSharper.Psi.TypeKeywordsManager typeKeywordsManager, JetBrains.ReSharper.Psi.Web.Util.WebPsiLanguageUtil webPsiLanguageUtil, JetBrains.ReSharper.Psi.PsiProjectFileTypeCoordinator projectFileTypeCoordinator) { }
        protected override bool CanHandle(JetBrains.ProjectModel.IProjectFile projectFile) { }
        protected override JetBrains.ReSharper.Psi.Web.Impl.WebConfig.Cache.WebConfigCompoundData CreateFileData([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IProjectFile projectFile) { }
        protected override JetBrains.ReSharper.Psi.Web.Impl.WebConfig.Cache.WebConfigCompoundData CreateFileData(string configText) { }
        public JetBrains.ReSharper.Psi.Web.Cache.IWebConfigCompoundData GetCompoundDataBeforeWebConfig(JetBrains.ProjectModel.IProjectFile webConfigFile) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        protected virtual JetBrains.ProjectModel.IProjectFile GetConfigFile(JetBrains.ProjectModel.IProjectFolder folder) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ProjectModel.IProjectFile> GetConfigFiles(JetBrains.ProjectModel.IProjectItem projectItem) { }
        public JetBrains.ReSharper.Psi.Web.Cache.WebConfigData GetData(JetBrains.ProjectModel.IProjectItem projectItem) { }
        public JetBrains.ReSharper.Psi.Web.Cache.WebConfigData GetEmptyData(JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext resolveContext) { }
        public JetBrains.ReSharper.Psi.Web.Cache.WebConfigData GetRootData(JetBrains.ProjectModel.IModule module, JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext resolveContext) { }
        protected override void OnFileAdded(JetBrains.ProjectModel.IProjectFile projectFile, System.Action<JetBrains.ProjectModel.IProjectFile, JetBrains.Util.FileSystemPath, JetBrains.ReSharper.Psi.Web.Cache.WebConfigChangeType> changeBuilder) { }
        public override void OnProjectModelChange(JetBrains.ProjectModel.ProjectModelChange change, System.Action<JetBrains.ProjectModel.IProjectFile, JetBrains.Util.FileSystemPath, JetBrains.ReSharper.Psi.Web.Cache.WebConfigChangeType> changeBuilder) { }
    }
    public class WebConfigCompoundData : JetBrains.ReSharper.Psi.Web.Cache.IWebConfigCompoundData
    {
        public WebConfigCompoundData(JetBrains.ReSharper.Psi.TypeKeywordsManager typeKeywordsManager, JetBrains.ReSharper.Psi.Web.Util.WebPsiLanguageUtil webPsiLanguageUtil, JetBrains.ReSharper.Psi.PsiProjectFileTypeCoordinator projectFileTypeCoordinator) { }
        public WebConfigCompoundData(JetBrains.ReSharper.Psi.TypeKeywordsManager typeKeywordsManager, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Web.Impl.WebConfig.Cache.WebConfigCompoundData parentData, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ProjectModel.IProjectFile webConfigFile, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IConfigurationTag configurationTag, JetBrains.ReSharper.Psi.Web.Util.WebPsiLanguageUtil webPsiLanguageUtil, JetBrains.ReSharper.Psi.PsiProjectFileTypeCoordinator projectFileTypeCoordinator) { }
        public JetBrains.ReSharper.Psi.Web.Cache.WebConfigData GetData(JetBrains.ProjectModel.IProjectItem projectItem) { }
        public JetBrains.ReSharper.Psi.Web.Cache.WebConfigData GetData([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IModule module, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext resolveContext) { }
        public JetBrains.ReSharper.Psi.Web.Cache.WebConfigData GetData(JetBrains.ProjectModel.IModule module, JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext resolveContext, JetBrains.Util.FileSystemPath targetPath) { }
    }
}
namespace JetBrains.ReSharper.Psi.Web.Impl.WebConfig
{
    
    public class static Keywords
    {
        public const string ADD = "add";
        public const string ALLOW_DEFINITION = "allowDefinition";
        public const string ALLOW_LOCATION = "allowLocation";
        public const string ALLOW_OVERRIDE_ATTRIBUTE = "allowOverride";
        public const string APP_SETTINGS = "appSettings";
        public const string ASSEMBLIES = "assemblies";
        public const string ASSEMBLY_ATTRIBUTE = "assembly";
        public const string ASSEMBLY_BINDING = "assemblyBinding";
        public const string ASSEMBLY_IDENTITY = "assemblyIdentity";
        public const string AUTO_EVENT_WIREUP_ATTRIBUTE = "autoEventWireup";
        public const string AUTO_IMPORT_VB_NAMESPACE_ATTRIBUTE = "autoImportVBNamespace";
        public const string BUILD_PROVIDER = "buildProvider";
        public const string BUILD_PROVIDERS = "buildProviders";
        public const string CLAIM_TYPE_REQUIRED = "claimTypeRequired";
        public const string CLEAR = "clear";
        public const string CODE_BASE = "codeBase";
        public const string CODE_SUBDIRECTORIES = "codeSubDirectories";
        public const string COMPILATION = "compilation";
        public const string COMPILER = "compiler";
        public const string COMPILER_LANGUAGE_ATTRIBUTE = "compilerLanguage";
        public const string COMPILER_OPTIONS_ATTRIBUTE = "compilerOptions";
        public const string COMPILERS = "compilers";
        public const string COMPONENT = "component";
        public const string CONFIG_SECTIONS = "configSections";
        public const string CONFIG_SOURCE_ATTRIBUTE = "configSource";
        public const string CONFIGURATION = "configuration";
        public const string CONNECTION_STRING_ATTRIBUTE = "connectionString";
        public const string CONTAINERS = "containers";
        public const string CONTROLS = "controls";
        public const string CULTURE_ATTRIBUTE = "culture";
        public const string DEBUG_ATTRIBUTE = "debug";
        public const string DEFAULT_LANGUAGE_ATTRIBUTE = "defaultLanguage";
        public const string DEFAULT_PROVIDER_ATTRIBUTE = "defaultProvider";
        public const string DEPENDENT_ASSEMBLY = "dependentAssembly";
        public const string DIRECTORY_NAME_ATTRIBUTE = "directoryName";
        public const string ELMAH = "elmah";
        public const string ENABLED_ATTRIBUTE = "enabled";
        public const string EXCEPTION_HANDLING = "exceptionHandling";
        public const string EXPLICIT_ATTRIBUTE = "explicit";
        public const string EXPRESSION_BUILDERS = "expressionBuilders";
        public const string EXPRESSION_PREFIX_ATTRIBUTE = "expressionPrefix";
        public const string EXTENSION_ATTRIBUTE = "extension";
        public const string FILE_ATTRIBUTE = "file";
        public const string FILTER = "filter";
        public const string FULL_NAME_ATTRIBUTE = "fullName";
        public const string GLOBALIZATION = "globalization";
        public const string GROUP = "group";
        public const string HANDLERS = "handlers";
        public const string HREF_ATTRIBUTE = "href";
        public const string HTTP_HANDLERS = "httpHandlers";
        public const string HTTP_MODULES = "httpModules";
        public const string INHERIT_IN_CHILD_APPLICATIONS_ATTRIBUTE = "inheritInChildApplications";
        public const string INHERITS_ATTRIBUTE = "inherits";
        public const string LINKED_CONFIGURATION = "linkedConfiguration";
        public const string LISTENERS = "listeners";
        public const string LOCATION = "location";
        public const string LOG_FILTERS = "logFilters";
        public const string LOG4NET = "log4net";
        public const string LOGGING = "logging";
        public const string MAPPED_TAG_TYPE_ATTRIBUTE = "mappedTagType";
        public const string MASTER_PAGE_FILE_ATTRIBUTE = "masterPageFile";
        public const string MONORAIL = "monorail";
        public const string NAME_ATTRIBUTE = "name";
        public const string NAMESPACE_ATTRIBUTE = "namespace";
        public const string NAMESPACES = "namespaces";
        public const string NLOG = "nlog";
        public const string PAGE_BASE_TYPE_ATTRIBUTE = "pageBaseType";
        public const string PAGE_PARSER_FILTER_TYPE_ATTRIBUTE = "pageParserFilterType";
        public const string PAGES = "pages";
        public const string PARTIAL_NAME_ATTRIBUTE = "partialName";
        public const string PATH_ATTRIBUTE = "path";
        public const string PROFILE = "profile";
        public const string PROPERTIES = "properties";
        public const string PROVIDER_ATTRIBUTE = "provider";
        public const string PROVIDERS = "providers";
        public const string PUBLIC_KEY_TOKEN_ATTRIBUTE = "publicKeyToken";
        public const string QUALIFY_ASSEMBLY = "qualifyAssembly";
        public const string RAZOR_CONFIG = "system.web.webPages.razor";
        public const string READONLY_ATTRIBUTE = "readOnly";
        public const string REMOVE = "remove";
        public const string RESOURCE_PROVIDER_FACTORY_TYPE = "resourceProviderFactoryType";
        public const string RUNTIME = "runtime";
        public const string SECTION = "section";
        public const string SECTION_GROUP = "sectionGroup";
        public const string SOURCE = "source";
        public const string SRC_ATTRIBUTE = "src";
        public const string STRICT_ATTRIBUTE = "strict";
        public const string STYLE_SHEET_THEME_ATTRIBUTE = "styleSheetTheme";
        public const string SUPPORTED_CLAIMS = "supportedClaims";
        public const string SWITCH_TYPE_ATTRIBUTE = "switchType";
        public const string SYNDICATION_COMPRESSION = "SyndicationCompression";
        public const string SYSTEM_DIAGNOSTICS = "system.diagnostics";
        public const string SYSTEM_SERVICEMODEL = "system.serviceModel";
        public const string SYSTEM_WEB = "system.web";
        public const string SYSTEM_WEBSERVER = "system.webServer";
        public const string TAG_MAPPING = "tagMapping";
        public const string TAG_NAME_ATTRIBUTE = "tagName";
        public const string TAG_PREFIX_ATTRIBUTE = "tagPrefix";
        public const string TAG_TYPE_ATTRIBUTE = "tagType";
        public const string TARGET_FRAMEWORK = "targetFramework";
        public const string TARGET_FRAMEWORK_MONIKER = "targetFrameworkMoniker";
        public const string THEME_ATTRIBUTE = "theme";
        public const string TYPE_ATTRIBUTE = "type";
        public const string UNITY = "unity";
        public const string UNITY_EXTENSION_TYPE = "extensionType";
        public const string UNITY_MAPTO = "mapTo";
        public const string USER_CONTROL_BASE_TYPE_ATTRIBUTE = "userControlBaseType";
        public const string VERSION_ATTRIBUTE = "version";
        public const string WARNING_LEVEL_ATTRIBUTE = "warningLevel";
    }
    public class WebConfigTreeBuilder : JetBrains.ReSharper.Psi.Xml.Parsing.XmlTreeBuilder
    {
        public WebConfigTreeBuilder(JetBrains.ReSharper.Psi.Xml.Parsing.IXmlElementFactory elementFactory, JetBrains.ReSharper.Psi.Xml.Parsing.IXmlElementFactoryContext factoryContext, JetBrains.ReSharper.Psi.Util.ITokenIntern intern) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.Web.WebConfig.WebConfigLanguage))]
    public class WebConfigTreeNodeFactory : JetBrains.ReSharper.Psi.Xml.Parsing.XmlTreeNodeFactory
    {
        public WebConfigTreeNodeFactory([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Web.WebConfig.WebConfigLanguage languageType, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Parsing.XmlTokenTypes tokenTypes, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Web.Impl.WebConfig.Tree.WebConfigElementType elementTypes) { }
        public override JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttribute CreateAttribute(JetBrains.ReSharper.Psi.Xml.Tree.IXmlIdentifier nameIdentifier, JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttributeContainer attributeContainer, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagContainer parentTag, JetBrains.ReSharper.Psi.Xml.Parsing.IXmlElementFactoryContext context) { }
        public override JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag CreateRootTag(JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagHeader header, JetBrains.ReSharper.Psi.Xml.Parsing.IXmlElementFactoryContext context) { }
        public override JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag CreateTag(JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagHeader header, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag parentTag, JetBrains.ReSharper.Psi.Xml.Parsing.IXmlElementFactoryContext context) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.Web.WebConfig.WebConfigLanguage))]
    public class WebConfigXmlLanguageSupport : JetBrains.ReSharper.Psi.Xml.XmlLanguageSupport
    {
        public override bool CanConvertAttributeToTag(JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttribute attribute) { }
        public override JetBrains.ReSharper.Psi.Xml.Parsing.XmlTreeBuilder CreateTreeBuilder(JetBrains.ReSharper.Psi.Xml.Parsing.IXmlElementFactory factory, JetBrains.ReSharper.Psi.Xml.Parsing.IXmlElementFactoryContext factoryContext, JetBrains.ReSharper.Psi.Util.ITokenIntern intern) { }
    }
}
namespace JetBrains.ReSharper.Psi.Web.Impl.WebConfig.PsiModules.Website.Helpers
{
    
    [JetBrains.ReSharper.Psi.Web.Impl.PsiModules.WebApp.WebAppPsiModuleHandlerHelperFactoryAttribute()]
    public class WebAppWebsiteConfigsHelperFactory : JetBrains.ReSharper.Psi.Web.Impl.PsiModules.IWebPsiModuleHandlerHelperFactory, JetBrains.ReSharper.Psi.Web.Impl.PsiModules.WebApp.IWebAppPsiModuleHandlerHelperFactory
    {
        public WebAppWebsiteConfigsHelperFactory(JetBrains.ReSharper.Psi.Web.Cache.IWebConfigCache webConfigCache, JetBrains.ReSharper.Psi.Web.PsiModules.IWebAssemblyReferenceFactory webAssemblyReferenceFactory, JetBrains.Application.IShellLocks shellLocks, JetBrains.ReSharper.Psi.PsiProjectFileTypeCoordinator psiProjectFileTypeCoordinator, JetBrains.ReSharper.Psi.PsiSourceFilePropertiesManager propertiesManager) { }
        public JetBrains.ReSharper.Psi.Web.Impl.PsiModules.IWebPsiModuleHandlerHelper CreateHelper(JetBrains.DataFlow.Lifetime helperLifetime, JetBrains.ReSharper.Psi.Web.Impl.PsiModules.IWebProjectPsiModuleHandler handler, JetBrains.ReSharper.Psi.Web.Cache.IWebConfigCache webConfigCache, JetBrains.ReSharper.Psi.Web.PsiModules.IAspFileDataCache aspFileDataCache) { }
    }
    public class WebsiteWebConfigsHelper : JetBrains.ReSharper.Psi.Web.Impl.PsiModules.IWebCommonReferenceProvider, JetBrains.ReSharper.Psi.Web.Impl.PsiModules.IWebConfigChangesListener, JetBrains.ReSharper.Psi.Web.Impl.PsiModules.IWebPsiModuleHandlerHelper
    {
        public WebsiteWebConfigsHelper(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ReSharper.Psi.Web.Impl.PsiModules.IWebProjectPsiModuleHandler handler, JetBrains.ReSharper.Psi.Web.Cache.IWebConfigCache webConfigCache, JetBrains.ReSharper.Psi.Web.PsiModules.IWebAssemblyReferenceFactory assemblyReferenceFactory, JetBrains.Application.IShellLocks shellLocks, JetBrains.ReSharper.Psi.PsiProjectFileTypeCoordinator psiProjectFileTypeCoordinator, JetBrains.ReSharper.Psi.PsiSourceFilePropertiesManager propertiesManager) { }
        public double Priority { get; }
        public JetBrains.DataFlow.ISimpleSignal ReferencesChanged { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IPsiSourceFile> FindPsiSourceFiles(JetBrains.ProjectModel.IProjectFile projectFile) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Modules.IPsiModule> GetAllModules() { }
        public void GetCommonReferencesFor(JetBrains.ReSharper.Psi.Modules.IPsiModule psiModule, JetBrains.ReSharper.Psi.Web.Impl.PsiModules.PsiModuleReferenceAccumulator referenceAccumulator) { }
        public bool InternalsVisibleTo(JetBrains.ReSharper.Psi.Modules.IPsiModule moduleTo, JetBrains.ReSharper.Psi.Modules.IPsiModule moduleFrom) { }
        public void OnExternalModuleSetChanged(JetBrains.ReSharper.Psi.Modules.PsiModuleChangeBuilder changeBuilder) { }
        public bool OnProjectFileAdded(JetBrains.ProjectModel.IProjectFile projectFile, JetBrains.ReSharper.Psi.Modules.PsiModuleChangeBuilder changeBuilder, System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Web.Impl.PsiModules.IWebPsiModuleHandlerHelper> alreadyProcessedBy) { }
        public void OnProjectFileModified(JetBrains.ProjectModel.IProjectFile projectFile, JetBrains.ReSharper.Psi.Modules.PsiModuleChangeBuilder changeBuilder) { }
        public void OnProjectFileRemoved(JetBrains.ProjectModel.IProjectFile projectFile, JetBrains.ReSharper.Psi.Modules.PsiModuleChangeBuilder changeBuilder) { }
        public void OnProjectPropertiesChange(JetBrains.ReSharper.Psi.Modules.PsiModuleChangeBuilder changeBuilder) { }
        public void OnWebConfigChanged(System.Collections.Generic.ICollection<JetBrains.Util.JetTuple<JetBrains.ProjectModel.IProjectFile, JetBrains.Util.FileSystemPath, JetBrains.ReSharper.Psi.Web.Cache.WebConfigChangeType>> tuples, JetBrains.ReSharper.Psi.Modules.PsiModuleChangeBuilder changeBuilder) { }
    }
    [JetBrains.ReSharper.Psi.Web.Impl.PsiModules.Website.WebsitePsiModuleHandlerHelperFactoryAttribute()]
    public class WebsiteWebsiteConfigsHelperFactory : JetBrains.ReSharper.Psi.Web.Impl.PsiModules.IWebPsiModuleHandlerHelperFactory, JetBrains.ReSharper.Psi.Web.Impl.PsiModules.Website.IWebsitePsiModuleHandlerHelperFactory
    {
        public WebsiteWebsiteConfigsHelperFactory(JetBrains.ReSharper.Psi.Web.Cache.IWebConfigCache webConfigCache, JetBrains.ReSharper.Psi.Web.PsiModules.IWebAssemblyReferenceFactory webAssemblyReferenceFactory, JetBrains.Application.IShellLocks shellLocks, JetBrains.ReSharper.Psi.PsiProjectFileTypeCoordinator psiProjectFileTypeCoordinator, JetBrains.ReSharper.Psi.PsiSourceFilePropertiesManager propertiesManager) { }
        public JetBrains.ReSharper.Psi.Web.Impl.PsiModules.IWebPsiModuleHandlerHelper CreateHelper(JetBrains.DataFlow.Lifetime helperLifetime, JetBrains.ReSharper.Psi.Web.Impl.PsiModules.IWebProjectPsiModuleHandler handler, JetBrains.ReSharper.Psi.Web.Cache.IWebConfigCache webConfigCache, JetBrains.ReSharper.Psi.Web.PsiModules.IAspFileDataCache aspFileDataCache) { }
    }
}
namespace JetBrains.ReSharper.Psi.Web.Impl.WebConfig.PsiModules.Website.Modules
{
    
    public interface IWebConfigModule : JetBrains.ReSharper.Psi.Modules.IPsiModule, JetBrains.ReSharper.Psi.Web.Impl.PsiModules.Website.Modules.IWebsitePsiModule, System.IDisposable
    {
        JetBrains.ProjectModel.IProjectFile WebConfigFile { get; set; }
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Modules.IPsiModuleReference> GetCommonReferences();
        void OnWebConfigChanged(System.Collections.Generic.ICollection<JetBrains.Util.JetTuple<JetBrains.ProjectModel.IProjectFile, JetBrains.Util.FileSystemPath, JetBrains.ReSharper.Psi.Web.Cache.WebConfigChangeType>> tuples, JetBrains.ReSharper.Psi.Modules.PsiModuleChangeBuilder changeBuilder);
    }
    public interface IWebConfigReferenceConsumerModule : JetBrains.ReSharper.Psi.Modules.IProjectPsiModule, JetBrains.ReSharper.Psi.Modules.IPsiModule, JetBrains.ReSharper.Psi.Web.Impl.PsiModules.Website.Modules.IWebsitePsiModule
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ProjectModel.IProjectItem MainProjectItem { get; }
    }
    public class MainWebConfigModule : JetBrains.ReSharper.Psi.Web.Impl.WebConfig.PsiModules.Website.Modules.WebConfigModuleBase
    {
        public MainWebConfigModule(JetBrains.ReSharper.Psi.Web.Impl.PsiModules.IWebProjectPsiModuleHandler handler, JetBrains.ReSharper.Psi.Web.PsiModules.IWebAssemblyReferenceFactory assemblyReferenceFactory, JetBrains.ReSharper.Psi.Web.Cache.IWebConfigCache webConfigCache, JetBrains.ReSharper.Psi.PsiProjectFileTypeCoordinator psiProjectFileTypeCoordinator) { }
    }
    public class NestedWebConfigModule : JetBrains.ReSharper.Psi.Web.Impl.WebConfig.PsiModules.Website.Modules.WebConfigModuleBase
    {
        public NestedWebConfigModule(JetBrains.ProjectModel.IProjectFile webConfigFile, JetBrains.ReSharper.Psi.Web.Impl.PsiModules.IWebProjectPsiModuleHandler handler, JetBrains.ReSharper.Psi.Web.PsiModules.IWebAssemblyReferenceFactory assemblyReferenceFactory, JetBrains.ReSharper.Psi.Web.Cache.IWebConfigCache webConfigCache, JetBrains.ReSharper.Psi.PsiProjectFileTypeCoordinator psiProjectFileTypeCoordinator) { }
    }
    public abstract class WebConfigModuleBase : JetBrains.ReSharper.Psi.Modules.ProjectPsiModuleBase, JetBrains.ReSharper.Psi.Modules.IPsiModule, JetBrains.ReSharper.Psi.Web.Impl.PsiModules.Website.Modules.IWebsitePsiModule, JetBrains.ReSharper.Psi.Web.Impl.WebConfig.PsiModules.Website.Modules.IWebConfigModule, System.IDisposable
    {
        protected WebConfigModuleBase(JetBrains.ReSharper.Psi.Web.Impl.PsiModules.IWebProjectPsiModuleHandler handler, JetBrains.ReSharper.Psi.Web.PsiModules.IWebAssemblyReferenceFactory assemblyReferenceFactory, JetBrains.ReSharper.Psi.Web.Cache.IWebConfigCache webConfigCache, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ProjectModel.IProjectFile webConfigFile, string nameSuffix, JetBrains.ReSharper.Psi.PsiProjectFileTypeCoordinator psiProjectFileTypeCoordinator) { }
        public JetBrains.ProjectModel.IProjectFile WebConfigFile { get; set; }
        public void Dispose() { }
        public virtual System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Modules.IPsiModuleReference> GetCommonReferences() { }
        protected override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Modules.IPsiModuleReference> GetReferencesInternal() { }
        public void OnWebConfigChanged(System.Collections.Generic.ICollection<JetBrains.Util.JetTuple<JetBrains.ProjectModel.IProjectFile, JetBrains.Util.FileSystemPath, JetBrains.ReSharper.Psi.Web.Cache.WebConfigChangeType>> tuples, JetBrains.ReSharper.Psi.Modules.PsiModuleChangeBuilder changeBuilder) { }
    }
}
namespace JetBrains.ReSharper.Psi.Web.Impl.WebConfig.Resolve
{
    
    public class WebConfigResolveErrorType : JetBrains.ReSharper.Psi.Xml.Impl.Resolve.XmlResolveErrorType
    {
        public static readonly JetBrains.ReSharper.Psi.Web.Impl.WebConfig.Resolve.WebConfigResolveErrorType INVALID_BASE_TYPE;
        public static readonly JetBrains.ReSharper.Psi.Web.Impl.WebConfig.Resolve.WebConfigResolveErrorType MODULE_MISMATCH;
        public static readonly JetBrains.ReSharper.Psi.Web.Impl.WebConfig.Resolve.WebConfigResolveErrorType MODULE_QUALIFICATION_ERROR;
        public static readonly JetBrains.ReSharper.Psi.Web.Impl.WebConfig.Resolve.WebConfigResolveErrorType TYPE_ARGUMENTS_COUNT_MISMATCH;
        public static readonly JetBrains.ReSharper.Psi.Web.Impl.WebConfig.Resolve.WebConfigResolveErrorType WRONG_MODULE;
        public WebConfigResolveErrorType(string name, string tooltip) { }
    }
}
namespace JetBrains.ReSharper.Psi.Web.Impl.WebConfig.TagPrefix
{
    
    public class WebConfigDeclaredElementType : JetBrains.ReSharper.Psi.Web.Impl.WebDeclaredElementType
    {
        public static readonly JetBrains.ReSharper.Psi.DeclaredElementType WEB_CONFIG_TAG_NAME;
        public static readonly JetBrains.ReSharper.Psi.DeclaredElementType WEB_CONFIG_TAG_PREFIX;
        protected override JetBrains.ReSharper.Psi.IDeclaredElementPresenter DefaultPresenter { get; }
        public override bool IsPresentable(JetBrains.ReSharper.Psi.PsiLanguageType language) { }
    }
}
namespace JetBrains.ReSharper.Psi.Web.Impl.WebConfig.Tree
{
    
    public class ConfigSourceAttribute : JetBrains.ReSharper.Psi.Web.Impl.WebConfig.Tree.FileAttributeBase, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IConfigSourceAttribute, JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IXmlPathAttribute, JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttribute, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        public ConfigSourceAttribute(JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType type) { }
        public override bool IsRelative { get; }
        protected override JetBrains.ReSharper.Psi.Resolve.IReference CreateFileReference(JetBrains.ReSharper.Psi.Web.Impl.WebConfig.Tree.References.WebConfigFolderReference qualifier, JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken token, JetBrains.ReSharper.Psi.TreeTextRange range) { }
        public JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IWebConfigTag GetResolvedTag() { }
        protected override void PreInit() { }
    }
    public abstract class FileAttributeBase : JetBrains.ReSharper.Psi.Web.Impl.WebConfig.Tree.WebConfigAttribute, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IXmlPathAttribute, JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttribute, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        protected FileAttributeBase(JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType type) { }
        public abstract bool IsRelative { get; }
        protected abstract JetBrains.ReSharper.Psi.Resolve.IReference CreateFileReference(JetBrains.ReSharper.Psi.Web.Impl.WebConfig.Tree.References.WebConfigFolderReference qualifier, JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken token, JetBrains.ReSharper.Psi.TreeTextRange range);
        protected override JetBrains.ReSharper.Psi.Tree.ReferenceCollection CreateReferencesInternal(JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttributeValue value) { }
    }
    public class GrouppedProperty : JetBrains.ReSharper.Psi.Web.Impl.WebConfig.Tree.ProfilePropertyBase
    {
        public GrouppedProperty(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IGroupNameAttribute> declarations) { }
        public override JetBrains.ReSharper.Psi.PsiLanguageType PresentationLanguage { get; }
        public override JetBrains.ReSharper.Psi.IType ReturnType { get; }
        protected override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IWebConfigTypeDeclaration> GetContainingTypeDeclarations() { }
        public override System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Tree.IDeclaration> GetDeclarations() { }
        public override JetBrains.ReSharper.Psi.IPsiServices GetPsiServices() { }
        protected override bool IsMyDeclaration(JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IProfilePropertyTag propertyTag) { }
    }
    public class GroupPropertyTag : JetBrains.ReSharper.Psi.Web.Impl.WebConfig.Tree.WebConfigTypeDeclarationTag, JetBrains.ReSharper.Psi.ExtensionsAPI.Caches2.ICachedDeclaration2, JetBrains.ReSharper.Psi.Tree.IDeclaration, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Tree.ITypeDeclaration, JetBrains.ReSharper.Psi.Tree.ITypeDeclarationHolder, JetBrains.ReSharper.Psi.Tree.IXmlDocOwnerTreeNode, JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IGroupPropertyTag, JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IProfilePropertyTag, JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IWebConfigTag, JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IWebConfigTypeDeclaration, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagContainer, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        public const string PROFILE_GROUP = "ProfileGroup";
        public const string SUPER_TYPE_NAME = "System.Web.Profile.ProfileGroupBase";
        public GroupPropertyTag(JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType type) { }
        public override string DeclaredName { get; }
        public string Name { get; }
        public JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IGroupNameAttribute NameAttribute { get; }
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IProfilePropertyTag> Properties { get; }
        protected override string SuperTypeName { get; }
        public override void SetName(string name) { }
    }
    public class PagesTag : JetBrains.ReSharper.Psi.Web.Impl.WebConfig.Tree.WebConfigTag, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IPagesTag, JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IWebConfigTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagContainer, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        public const string PAGE_BASE_TYPE = "System.Web.UI.Page";
        public const string PAGE_PARSER_FILTER_TYPE = "System.Web.UI.PageParserFilter";
        public const string USER_CONTROL_BASE_TYPE = "System.Web.UI.UserControl";
        public PagesTag(JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType type) { }
        public bool AutoEventWireup { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttribute AutoEventWireupAttribute { get; }
        public string MasterPageFile { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttribute MasterPageFileAttribute { get; }
        public JetBrains.ReSharper.Psi.Web.WebConfig.Tree.INamespacesTag Namespaces { get; }
        public string PageBaseType { get; }
        public JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IWebConfigTypeAttribute PageBaseTypeAttribute { get; }
        public JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IWebConfigTypeAttribute PageParserFilterTypeAttribute { get; }
        public string StyleSheetTheme { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttribute StyleSheetThemeAttribute { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Web.WebConfig.Tree.ITagMappingActionTag> TagMappings { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IAddTagPrefixTag> TagPrefixes { get; }
        public string Theme { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttribute ThemeAttribute { get; }
        public string UserControlBaseType { get; }
        public JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IWebConfigTypeAttribute UserControlBaseTypeAttribute { get; }
    }
    public abstract class ProfilePropertyBase : JetBrains.ReSharper.Psi.IAccessRightsOwner, JetBrains.ReSharper.Psi.IAttributesOwner, JetBrains.ReSharper.Psi.IAttributesSet, JetBrains.ReSharper.Psi.IClrDeclaredElement, JetBrains.ReSharper.Psi.IDeclaredElement, JetBrains.ReSharper.Psi.IModifiersOwner, JetBrains.ReSharper.Psi.IOverridableMember, JetBrains.ReSharper.Psi.IParametersOwner, JetBrains.ReSharper.Psi.IProperty, JetBrains.ReSharper.Psi.ITypeMember, JetBrains.ReSharper.Psi.ITypeOwner, JetBrains.ReSharper.Psi.IXmlDocIdOwner
    {
        public JetBrains.ReSharper.Psi.AccessibilityDomain AccessibilityDomain { get; }
        public bool CanBeImplicitImplementation { get; }
        public bool CaseSensistiveName { get; }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Psi.IExplicitImplementation> ExplicitImplementations { get; }
        public JetBrains.ReSharper.Psi.IAccessor Getter { get; }
        public JetBrains.ReSharper.Psi.MemberHidePolicy HidePolicy { get; }
        public JetBrains.ReSharper.Psi.Resolve.ISubstitution IdSubstitution { get; }
        public bool IsAbstract { get; }
        public bool IsDefault { get; }
        public bool IsExplicitImplementation { get; }
        public bool IsExtern { get; }
        public bool IsOverride { get; }
        public bool IsReadable { get; }
        public virtual bool IsReadonly { get; }
        public bool IsSealed { get; }
        public bool IsStatic { get; }
        public bool IsUnsafe { get; }
        public bool IsVirtual { get; }
        public bool IsVolatile { get; }
        public bool IsWritable { get; }
        public JetBrains.ReSharper.Psi.Modules.IPsiModule Module { get; }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Psi.IParameter> Parameters { get; }
        public abstract JetBrains.ReSharper.Psi.PsiLanguageType PresentationLanguage { get; }
        public JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext ResolveContext { get; }
        public abstract JetBrains.ReSharper.Psi.IType ReturnType { get; }
        public JetBrains.ReSharper.Psi.IAccessor Setter { get; }
        public string ShortName { get; }
        public JetBrains.ReSharper.Psi.IType Type { get; }
        public string XMLDocId { get; }
        public System.Nullable<JetBrains.ReSharper.Psi.Dependencies.Hash> CalcHash() { }
        public JetBrains.ReSharper.Psi.AccessRights GetAccessRights() { }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Psi.IAttributeInstance> GetAttributeInstances(bool inherit) { }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Psi.IAttributeInstance> GetAttributeInstances(JetBrains.ReSharper.Psi.IClrTypeName clrName, bool inherit) { }
        public JetBrains.ReSharper.Psi.ITypeElement GetContainingType() { }
        protected abstract System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IWebConfigTypeDeclaration> GetContainingTypeDeclarations();
        public JetBrains.ReSharper.Psi.ITypeMember GetContainingTypeMember() { }
        public abstract System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Tree.IDeclaration> GetDeclarations();
        public System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Tree.IDeclaration> GetDeclarationsIn(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
        public JetBrains.ReSharper.Psi.DeclaredElementType GetElementType() { }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Psi.TypeMemberInstance> GetHiddenMembers() { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Tree.IParametersOwnerDeclaration> GetParametersOwnerDeclarations() { }
        public abstract JetBrains.ReSharper.Psi.IPsiServices GetPsiServices();
        public JetBrains.ReSharper.Psi.InvocableSignature GetSignature(JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution) { }
        public JetBrains.Util.DataStructures.HybridCollection<JetBrains.ReSharper.Psi.IPsiSourceFile> GetSourceFiles() { }
        public System.Xml.XmlNode GetXMLDescriptionSummary(bool inherit) { }
        public System.Xml.XmlNode GetXMLDoc(bool inherit) { }
        public bool HasAttributeInstance(JetBrains.ReSharper.Psi.IClrTypeName clrName, bool inherit) { }
        public bool HasDeclarationsIn(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
        protected abstract bool IsMyDeclaration(JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IProfilePropertyTag propertyTag);
        public bool IsSynthetic() { }
        public bool IsValid() { }
    }
    public class QualifiedTypeAttribute : JetBrains.ReSharper.Psi.Web.Impl.WebConfig.Tree.WebConfigTypeAttribute
    {
        public QualifiedTypeAttribute(JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType type, bool lateBound = False, bool allowEmpty = False) { }
        public override bool ModuleQualificationRequired { get; }
        protected override JetBrains.ReSharper.Psi.Tree.ReferenceCollection CreateReferencesInternal(JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttributeValue value) { }
        protected virtual string GetExpectedBaseType() { }
    }
    public class RazorPagesTag : JetBrains.ReSharper.Psi.Web.Impl.WebConfig.Tree.WebConfigTag, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IRazorPagesTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagContainer, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        public RazorPagesTag(JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType type) { }
        public JetBrains.ReSharper.Psi.Web.WebConfig.Tree.INamespacesTag Namespaces { get; }
        public string PageBaseType { get; }
        public JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IWebConfigTypeAttribute PageBaseTypeAttribute { get; }
    }
    public class SystemWebTag : JetBrains.ReSharper.Psi.Web.Impl.WebConfig.Tree.WebConfigTag, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.WebConfig.Tree.ISystemWebTag, JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IWebConfigTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagContainer, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        public SystemWebTag(JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType _type) { }
        public JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IAppSettingTag AppSetting { get; }
        public JetBrains.ReSharper.Psi.Web.WebConfig.Tree.ICompilationTag Compilation { get; }
        public JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IPagesTag PagesConfig { get; }
        public JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IProfileTag Profile { get; }
    }
    public abstract class WebConfigAttribute : JetBrains.ReSharper.Psi.Xml.Impl.Tree.XmlAttribute
    {
        protected WebConfigAttribute(JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType type) { }
        protected override JetBrains.ReSharper.Psi.Tree.ReferenceCollection CreateFirstClassReferences() { }
        protected abstract JetBrains.ReSharper.Psi.Tree.ReferenceCollection CreateReferencesInternal(JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttributeValue value);
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.Web.WebConfig.WebConfigLanguage))]
    public class WebConfigElementType : JetBrains.ReSharper.Psi.Xml.Tree.XmlElementTypes
    {
        public WebConfigElementType(JetBrains.ReSharper.Psi.Parsing.XmlTokenTypes xmlTokenTypes) { }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType ADD_ASSEMBLY { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType ADD_BUILD_PROVIDER { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType ADD_CODE_SUBDIRECTORY { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType ADD_EXPRESSION_BUILDER { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType ADD_HTTP_HANDLER { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType ADD_NAMESPACE { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType ADD_PROPERTY { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType ADD_PROVIDER { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType ADD_TAGMAPPING { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType ADD_TAGPREFIX { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType APP_SETTINGS { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType ASSEMBLY_IDENTITY { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType CLEAR_ASSEMBLIES { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType CLEAR_BUILD_PROVIDERS { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType CLEAR_EXPRESSION_BUILDERS { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType CLEAR_HTTP_HANDLERS { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType CLEAR_NAMESPACES { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType CLEAR_PROPERTIES { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType CLEAR_PROVIDERS { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType CLEAR_SECTIONS { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType CLEAR_TAGMAPPINGS { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType CODE_BASE { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType COMPILATION { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType COMPILER { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType CONFIG_SECTIONS { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType CONFIG_SRC_ATTRIBUTE { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType CONFIGURATION { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType CONTROL_SRC_ATTRIBUTE { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType DEPENDENT_ASSEMBLY { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType DIRECTORY_NAME_ATTRIBUTE { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType ELMAH { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType GROUP_NAME_ATTRIBUTE { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType GROUP_PROPERTIES { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType LINKED_CONFIGURATION { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType LOCATION { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType LOCATION_PATH_ATTRIBUTE { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType MASTER_PAGE_FILE_ATTRIBUTE { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType NAMESPACE_ATTRIBUTE { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType NAMESPACES { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType PAGES { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType PROFILE { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType PROFILE_TYPE_ATTRIBUTE { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType PROPERTY_NAME_ATTRIBUTE { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType QUALIFIED_TYPE_ATTRIBUTE { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType QUALIFY_ASSEMBLY { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType RAZOR { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType RAZOR_PAGES { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType REMOVE_ASSEMBLY { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType REMOVE_BUILD_PROVIDER { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType REMOVE_EXPRESSION_BUILDER { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType REMOVE_HTTP_HANDLER { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType REMOVE_NAMESPACE { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType REMOVE_PROPERTY { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType REMOVE_PROVIDER { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType REMOVE_SECTION { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType REMOVE_TAGMAPPING { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType RUNTIME_ASSEMBLY_BINDING { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType SECTION { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType SECTION_GROUP { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType SYSTEM_WEB { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType TAG_NAME_ATTRIBUTE { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType TAG_PREFIX_ATTRIBUTE { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType TYPE_ATTRIBUTE { get; }
    }
    public class WebConfigTag : JetBrains.ReSharper.Psi.Xml.Impl.Tree.XmlTag, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IWebConfigTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagContainer, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        public WebConfigTag(JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType type) { }
        protected bool GetAttributeBoolValue([JetBrains.Annotations.NotNullAttribute()] string attributeName, bool defaultValue = False) { }
        protected int GetAttributeIntValue([JetBrains.Annotations.NotNullAttribute()] string attributeName, int defaultValue = 0) { }
        [JetBrains.Annotations.ContractAnnotationAttribute("defaultValue:notnull => notnull")]
        protected string GetAttributeStringValue([JetBrains.Annotations.NotNullAttribute()] string attributeName, string defaultValue = "") { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public T GetNestedTag<T>(string xpath)
            where T :  class, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag { }
        public override void SubTreeChanged(JetBrains.ReSharper.Psi.Tree.ITreeNode elementContainingChanges, JetBrains.ReSharper.Psi.PsiChangedElementType changeType) { }
    }
    public class static WebConfigTagExtensions
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IConfigSourceAttribute GetConfigSourceAttribute(this JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IWebConfigTag webConfigTag) { }
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        public static T GetResolvedTag<T>(this T tag)
            where T :  class, JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IWebConfigTag { }
    }
    public abstract class WebConfigTypeAttribute : JetBrains.ReSharper.Psi.Web.Impl.WebConfig.Tree.WebConfigAttribute, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IWebConfigTypeAttribute, JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttribute, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        protected WebConfigTypeAttribute(JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType type) { }
        public virtual bool ModuleQualificationRequired { get; }
    }
    public abstract class WebConfigTypeDeclarationTag : JetBrains.ReSharper.Psi.Web.Impl.WebConfig.Tree.WebConfigTag, JetBrains.ReSharper.Psi.ExtensionsAPI.Caches2.ICachedDeclaration2, JetBrains.ReSharper.Psi.Tree.IDeclaration, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Tree.ITypeDeclaration, JetBrains.ReSharper.Psi.Tree.ITypeDeclarationHolder, JetBrains.ReSharper.Psi.Tree.IXmlDocOwnerTreeNode, JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IWebConfigTypeDeclaration
    {
        protected WebConfigTypeDeclarationTag(JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType _type) { }
        public JetBrains.ReSharper.Psi.IDeclaredElement CacheDeclaredElement { get; set; }
        public string CLRName { get; }
        public JetBrains.ReSharper.Psi.IDeclaredElement DeclaredElement { get; }
        public abstract string DeclaredName { get; }
        public JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<JetBrains.ReSharper.Psi.Tree.ITypeMemberDeclaration> MemberDeclarations { get; }
        public JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<JetBrains.ReSharper.Psi.Tree.ITypeDeclaration> NestedTypeDeclarations { get; }
        public abstract System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IProfilePropertyTag> Properties { get; }
        protected abstract string SuperTypeName { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IDeclaredType> SuperTypes { get; }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Tree.ITypeDeclaration> TypeDeclarations { get; }
        public JetBrains.ReSharper.Psi.TreeTextRange GetNameRange() { }
        public System.Xml.XmlNode GetXMLDoc(bool inherit) { }
        public bool IsSynthetic() { }
        protected override void PreInit() { }
        public abstract void SetName(string name);
    }
}
namespace JetBrains.ReSharper.Psi.Web.Impl.WebConfig.Tree.References
{
    
    public sealed class AppSubCodeFolderReference : JetBrains.ReSharper.Psi.Web.Impl.WebConfig.Tree.References.WebConfigFolderReference
    {
        public AppSubCodeFolderReference(JetBrains.ReSharper.Psi.Tree.ITreeNode owner, JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken token, JetBrains.ReSharper.Psi.TreeTextRange rangeWithin) { }
        public override JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetReferenceSymbolTable(bool useReferenceName) { }
    }
    public interface IWebConfigConstructorReference : JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.Util.IUserDataHolder { }
    public interface IWebModuleQualificationReference : JetBrains.ReSharper.Psi.Resolve.IQualifier, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.Util.IUserDataHolder
    {
        bool LateBound { get; }
        bool NoLeadingComma { get; set; }
        JetBrains.ReSharper.Psi.TreeTextRange RangeWithin { get; }
        JetBrains.ReSharper.Psi.Resolve.IReference BindTo(JetBrains.ReSharper.Psi.Modules.IPsiModule module);
    }
    public interface IWebNamespaceReference : JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IQualifiableReferenceBase, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IQualifiableReferenceWithGlobalSymbolTable, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IReferenceWithGlobalSymbolTable, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IReferenceWithQualifier, JetBrains.ReSharper.Psi.Resolve.ICompleteableReference, JetBrains.ReSharper.Psi.Resolve.IQualifier, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.Util.IUserDataHolder
    {
        JetBrains.ReSharper.Psi.TreeTextRange RangeWithin { get; }
    }
    public interface IWebTypeReference : JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IQualifiableReferenceBase, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IQualifiableReferenceWithGlobalSymbolTable, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IReferenceWithGlobalSymbolTable, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IReferenceWithQualifier, JetBrains.ReSharper.Psi.Resolve.ICompleteableReference, JetBrains.ReSharper.Psi.Resolve.IQualifier, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.Util.IUserDataHolder
    {
        bool CaseSensitive { get; }
        string ExpectedBaseType { get; }
        bool KeywordsAllowed { get; }
        JetBrains.ReSharper.Psi.PsiLanguageType KeywordsLanguage { get; }
        bool MustBePublic { get; }
        JetBrains.ReSharper.Psi.TreeTextRange RangeWithin { get; }
        JetBrains.ReSharper.Psi.Tree.ITreeNode TokenElement { get; }
        JetBrains.ReSharper.Psi.Resolve.IReference FixModuleQualification(JetBrains.ReSharper.Psi.Modules.IPsiModule psiModule);
        int GetTypeArgumentCount();
    }
    public interface IWebTypeReferenceCreator
    {
        JetBrains.ReSharper.Psi.TreeTextRange CalcRangeWithin([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode tokenElement);
        JetBrains.ReSharper.Psi.Web.Impl.WebConfig.Tree.References.IWebModuleQualificationReference CreateModuleQualificationReference(JetBrains.ReSharper.Psi.Tree.ITreeNode owner, JetBrains.ReSharper.Psi.Tree.ITreeNode token, JetBrains.ReSharper.Psi.TreeTextRange rangeWithin, bool lateBound = False);
        JetBrains.ReSharper.Psi.Web.Impl.WebConfig.Tree.References.IWebNamespaceReference CreateNamespaceReference(JetBrains.ReSharper.Psi.Tree.ITreeNode owner, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Resolve.IQualifier qualifier, JetBrains.ReSharper.Psi.Tree.ITreeNode token, JetBrains.ReSharper.Psi.TreeTextRange rangeWithin);
        JetBrains.ReSharper.Psi.Web.WebConfig.Util.ComplexTypeParser CreateParser(string text, JetBrains.ReSharper.Psi.TreeTextRange range);
        JetBrains.ReSharper.Psi.Web.Impl.WebConfig.Tree.References.IWebTypeReference CreateTypeReference(JetBrains.ReSharper.Psi.Tree.ITreeNode owner, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Resolve.IQualifier qualifier, JetBrains.ReSharper.Psi.Tree.ITreeNode token, JetBrains.ReSharper.Psi.TreeTextRange rangeWithin, string expectedBaseType = null);
    }
    public class ModuleQualificationReference : JetBrains.ReSharper.Psi.Xml.Impl.Tree.References.XmlReferenceWithTokenBase<JetBrains.ReSharper.Psi.Tree.ITreeNode>, JetBrains.ReSharper.Psi.Resolve.ILateBoundReference, JetBrains.ReSharper.Psi.Resolve.IQualifier, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.ReSharper.Psi.Web.Impl.WebConfig.Tree.References.IWebModuleQualificationReference, JetBrains.Util.IUserDataHolder
    {
        public ModuleQualificationReference(JetBrains.ReSharper.Psi.Tree.ITreeNode owner, JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken token, JetBrains.ReSharper.Psi.TreeTextRange rangeWithin, bool lateBound = False) { }
        public bool LateBound { get; }
        public bool NoLeadingComma { get; set; }
        public bool Resolved { get; }
        public JetBrains.ReSharper.Psi.Resolve.IReference BindTo(JetBrains.ReSharper.Psi.Modules.IPsiModule module) { }
        public JetBrains.ReSharper.Psi.Resolve.QualifierKind GetKind() { }
        public override JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetReferenceSymbolTable(bool useReferenceName) { }
        public JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetSymbolTable(JetBrains.ReSharper.Psi.Resolve.SymbolTableMode mode) { }
        public override JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.ResolveResultWithInfo ResolveWithoutCache() { }
    }
    public class WebConfigFolderReference : JetBrains.ReSharper.Psi.Web.Impl.WebConfig.Tree.References.WebConfigPathReferenceBase, JetBrains.ReSharper.Psi.Resolve.IQualifier
    {
        public WebConfigFolderReference(JetBrains.ReSharper.Psi.Tree.ITreeNode owner, JetBrains.ReSharper.Psi.Resolve.IQualifier qualifier, JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken token, JetBrains.ReSharper.Psi.TreeTextRange rangeWithin) { }
        public bool Resolved { get; }
        public JetBrains.ReSharper.Psi.Resolve.QualifierKind GetKind() { }
        protected override JetBrains.ReSharper.Psi.Resolve.ISymbolFilter[] GetSmartSymbolFilters() { }
        public JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetSymbolTable(JetBrains.ReSharper.Psi.Resolve.SymbolTableMode mode) { }
    }
    public abstract class WebConfigPathReferenceBase : JetBrains.ReSharper.Psi.Xml.Impl.Tree.References.XmlQualifiableReferenceWithToken, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IQualifiableReferenceBase, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IQualifiableReferenceWithGlobalSymbolTable, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IReferenceWithGlobalSymbolTable, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IReferenceWithQualifier, JetBrains.ReSharper.Psi.Resolve.ICompleteableReference, JetBrains.ReSharper.Psi.Resolve.IPathReference, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.ReSharper.Psi.Web.References.IIgnorablePathReference, JetBrains.ReSharper.Psi.Xml.Tree.References.IXmlCompleteableReference, JetBrains.ReSharper.Psi.Xml.Tree.References.IXmlReference, JetBrains.ReSharper.Psi.Xml.Tree.References.IXmlSmartCompleteableReference, JetBrains.Util.IUserDataHolder
    {
        protected WebConfigPathReferenceBase(JetBrains.ReSharper.Psi.Tree.ITreeNode owner, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Resolve.IQualifier qualifier, JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken token, JetBrains.ReSharper.Psi.TreeTextRange rangeWithin) { }
        public virtual bool AllowEmptyName { get; }
        protected bool BindToFullPath { get; }
        public virtual bool CanBeMappedOrIgnored { get; }
        public override bool IsQualified { get; }
        protected override JetBrains.ReSharper.Psi.Resolve.IReference BindToInternal(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution) { }
        public JetBrains.Util.FileSystemPath GetBasePath() { }
        protected override JetBrains.ReSharper.Psi.Resolve.ISymbolFilter[] GetCompletionFilters() { }
        public override string GetName() { }
        public JetBrains.ReSharper.Psi.Resolve.ISymbolFilter[] GetPathFilters() { }
        public override JetBrains.ReSharper.Psi.ITypeElement GetQualifierTypeElement() { }
        public override JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetReferenceSymbolTable(bool useReferenceName) { }
        public override JetBrains.ReSharper.Psi.Resolve.Staticness GetStaticness() { }
        public override JetBrains.ReSharper.Psi.Resolve.ISymbolFilter[] GetSymbolFilters() { }
        public override JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.ResolveResultWithInfo Resolve(JetBrains.ReSharper.Psi.Resolve.ISymbolTable symbolTable, JetBrains.ReSharper.Psi.Resolve.IAccessContext context) { }
    }
    public class WebConfigTypeReference : JetBrains.ReSharper.Psi.Xml.Impl.Tree.References.XmlQualifiableReferenceWithToken, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IQualifiableReferenceBase, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IQualifiableReferenceWithGlobalSymbolTable, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IReferenceWithGlobalSymbolTable, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IReferenceWithQualifier, JetBrains.ReSharper.Psi.Resolve.ICompleteableReference, JetBrains.ReSharper.Psi.Resolve.IQualifier, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.ReSharper.Psi.Web.Impl.WebConfig.Tree.References.IWebTypeReference, JetBrains.ReSharper.Psi.Xml.Tree.References.IXmlCompleteableReference, JetBrains.ReSharper.Psi.Xml.Tree.References.IXmlReference, JetBrains.ReSharper.Psi.Xml.Tree.References.IXmlSmartCompleteableReference, JetBrains.ReSharper.Psi.Xml.Tree.References.IXmlTypeNameCompleteableReference, JetBrains.Util.IUserDataHolder
    {
        public WebConfigTypeReference([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode owner, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Resolve.IQualifier qualifier, JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken token, JetBrains.ReSharper.Psi.TreeTextRange rangeWithin, string expectedBaseType = null, bool mustBePublic = False, bool allowEmpty = False) { }
        public virtual string ExpectedBaseType { get; }
        public virtual bool KeywordsAllowed { get; }
        public virtual JetBrains.ReSharper.Psi.PsiLanguageType KeywordsLanguage { get; }
        public bool MustBePublic { get; }
        public bool Resolved { get; }
        protected override JetBrains.ReSharper.Psi.Resolve.SymbolTableMode SymbolTableMode { get; }
        protected override JetBrains.ReSharper.Psi.Resolve.IReference BindToInternal(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution) { }
        public JetBrains.ReSharper.Psi.Resolve.IReference FixModuleQualification(JetBrains.ReSharper.Psi.Modules.IPsiModule psiModule) { }
        protected override JetBrains.ReSharper.Psi.Resolve.ISymbolFilter[] GetCompletionFilters() { }
        public JetBrains.ReSharper.Psi.Resolve.QualifierKind GetKind() { }
        public override string GetName() { }
        public override JetBrains.ReSharper.Psi.ITypeElement GetQualifierTypeElement() { }
        public override JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.ResolveResultWithInfo GetResolveResult(JetBrains.ReSharper.Psi.Resolve.ISymbolTable symbolTable, string referenceName) { }
        protected override JetBrains.ReSharper.Psi.Resolve.ISymbolFilter[] GetSmartSymbolFilters() { }
        public override JetBrains.ReSharper.Psi.Resolve.Staticness GetStaticness() { }
        public JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetSymbolTable(JetBrains.ReSharper.Psi.Resolve.SymbolTableMode mode) { }
        public int GetTypeArgumentCount() { }
        protected virtual bool IsKnownTypeReference() { }
        public override JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.ResolveResultWithInfo Resolve(JetBrains.ReSharper.Psi.Resolve.ISymbolTable symbolTable, JetBrains.ReSharper.Psi.Resolve.IAccessContext context) { }
    }
}
namespace JetBrains.ReSharper.Psi.Web.Impl
{
    
    public class WebDeclaredElementPresenter : JetBrains.ReSharper.Psi.IDeclaredElementPresenter
    {
        public static readonly JetBrains.ReSharper.Psi.Web.Impl.WebDeclaredElementPresenter Instance;
        protected static JetBrains.Util.TextRange AppendString(System.Text.StringBuilder sb, string substr) { }
        public virtual string Format(JetBrains.ReSharper.Psi.DeclaredElementPresenterStyle style, JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution, out JetBrains.ReSharper.Psi.DeclaredElementPresenterMarking marking) { }
        public string Format(JetBrains.ReSharper.Psi.ParameterKind parameterKind) { }
        public string Format(JetBrains.ReSharper.Psi.AccessRights accessRights) { }
        protected virtual string GetEntityKindStr(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
        protected static void TrimString(System.Text.StringBuilder str) { }
    }
    public class WebDeclaredElementType : JetBrains.ReSharper.Psi.DeclaredElementTypeBase
    {
        public static readonly JetBrains.ReSharper.Psi.DeclaredElementType ATTRIBUTE_ENUM_VALUE;
        public static readonly JetBrains.ReSharper.Psi.DeclaredElementType DIRECTIVE;
        public static readonly JetBrains.ReSharper.Psi.DeclaredElementType DIRECTIVE_ATTRIBUTE;
        public static readonly JetBrains.ReSharper.Psi.DeclaredElementType GLOBAL_TAG_PREFIX;
        protected WebDeclaredElementType(string name, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.UI.Icons.IconId imageName) { }
        protected override JetBrains.ReSharper.Psi.IDeclaredElementPresenter DefaultPresenter { get; }
        protected override JetBrains.UI.Icons.IconId GetImage() { }
        public override bool IsPresentable(JetBrains.ReSharper.Psi.PsiLanguageType language) { }
    }
    [JetBrains.ProjectModel.ProjectFileTypeAttribute(typeof(JetBrains.ProjectModel.XsdProjectFileType))]
    public class XsdProjectFileLanguageService : JetBrains.ReSharper.Psi.Xml.XmlProjectFileLanguageService
    {
        public const string EXTENSION = ".xsd";
        public XsdProjectFileLanguageService(JetBrains.ProjectModel.XsdProjectFileType xsdProjectFileType) { }
        public override JetBrains.UI.Icons.IconId Icon { get; }
        public override JetBrains.ReSharper.Psi.PsiLanguageType GetPsiLanguageType(JetBrains.ProjectModel.ProjectFileType languageType) { }
        public override JetBrains.ReSharper.Psi.IPsiSourceFileProperties GetPsiProperties(JetBrains.ProjectModel.IProjectFile projectFile, JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
        public class XsdGetPsiSourceFileProperties : JetBrains.ReSharper.Psi.Impl.DefaultPsiProjectFileProperties
        {
            public XsdGetPsiSourceFileProperties(JetBrains.ProjectModel.IProjectFile projectFile, JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
        }
    }
}
namespace JetBrains.ReSharper.Psi.Web.Languages
{
    
    public interface IWebCodeBehindLanguageSupport
    {
        JetBrains.ReSharper.Psi.PsiLanguageType CodeBehindLanguage { get; }
        bool IsCaseSensitive { get; }
    }
    public interface IWebLanguageNameParser
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.PsiLanguageType ParseScriptLanguage(string languageName);
    }
    [JetBrains.Annotations.BaseTypeRequiredAttribute(typeof(JetBrains.ReSharper.Psi.Web.Languages.IWebCodeBehindLanguageSupport))]
    [JetBrains.Annotations.MeansImplicitUseAttribute()]
    public class WebCodeBehindLanguageSupportAttribute : JetBrains.ReSharper.Psi.LanguageAttribute
    {
        public WebCodeBehindLanguageSupportAttribute(System.Type language) { }
    }
    [JetBrains.Annotations.BaseTypeRequiredAttribute(typeof(JetBrains.ReSharper.Psi.Web.Languages.IWebLanguageNameParser))]
    [JetBrains.Annotations.MeansImplicitUseAttribute()]
    public class WebLanguageNameParserAttribute : JetBrains.ReSharper.Psi.LanguageAttribute
    {
        public WebLanguageNameParserAttribute(System.Type language) { }
    }
}
namespace JetBrains.ReSharper.Psi.Web.Naming
{
    
    public interface IConfigurableWebProjectNamingSettings { }
    [JetBrains.Application.Configuration.Upgrade.GlobalSettingsUpgraderAttribute()]
    [JetBrains.ProjectModel.Settings.Upgrade.SolutionSettingsUpgraderAttribute()]
    public class WebCustomRulesNamingSettingsUpgrade : JetBrains.ReSharper.Psi.Naming.Settings.Upgrade.CustomRulesNamingSettingsUpgrade<JetBrains.ReSharper.Psi.Web.Naming.WebNamingSettingsKey>
    {
        public WebCustomRulesNamingSettingsUpgrade(JetBrains.Application.Parts.IPartsCatalogueSet partsSet, JetBrains.ProjectModel.ISolution solution = null) { }
        protected override JetBrains.ReSharper.Psi.Naming.Settings.CustomRulesNamingSettingsBase GetSpecificSettings(JetBrains.ReSharper.Psi.CodeStyle.SettingsUpgrade.CodeStyleSettingsObsolete codeStyleSettings) { }
    }
    [JetBrains.Application.Settings.SettingsKeyAttribute(typeof(JetBrains.ReSharper.Psi.Naming.Settings.NamingSettings), "Web naming settings")]
    public class WebNamingSettingsKey : JetBrains.ReSharper.Psi.Naming.Settings.CustomRulesNamingSettingsKeyBase { }
    [System.ObsoleteAttribute("Deprecated, use WebNamingSettingsKey")]
    public class WebNamingStyleSettings : JetBrains.ReSharper.Psi.Naming.Settings.CustomRulesNamingSettingsBase
    {
        public override object Clone() { }
    }
    public abstract class WebPolicyProvider : JetBrains.ReSharper.Psi.Naming.Impl.CustomRulesBasedPolicyProvider<JetBrains.ReSharper.Psi.Web.Naming.WebNamingSettingsKey>
    {
        protected WebPolicyProvider(JetBrains.ReSharper.Psi.PsiLanguageType language, JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, JetBrains.Application.Settings.IContextBoundSettingsStore settingsStore) { }
        protected override JetBrains.ReSharper.Psi.Naming.Settings.NamingPolicy UndefinedPolicy { get; }
    }
}
namespace JetBrains.ReSharper.Psi.Web.PsiModules
{
    
    public class static AspFileDataExtensions
    {
        public static void Dump(this JetBrains.ReSharper.Psi.Web.PsiModules.IAspFileData data, System.IO.StreamWriter writer) { }
    }
    public class EmptyAspFileData : JetBrains.ReSharper.Psi.Web.PsiModules.IAspFileData
    {
        public static readonly JetBrains.ReSharper.Psi.Web.PsiModules.EmptyAspFileData Instance;
        public string CodeFile { get; }
        public string LanguageDefinedInFile { get; }
        public System.Collections.Generic.IEnumerable<string> ReferencedFiles { get; }
        public System.Collections.Generic.IEnumerable<string> ReferencedModulesByName { get; }
        public System.Collections.Generic.IEnumerable<string> ReferencedModulesByPath { get; }
        public JetBrains.ReSharper.Psi.Web.PsiModules.IAspFileDataDiff GetDiff(JetBrains.ReSharper.Psi.Web.PsiModules.IAspFileData otherData) { }
    }
    public interface IAspFileData
    {
        [JetBrains.Annotations.NotNullAttribute()]
        string CodeFile { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        string LanguageDefinedInFile { get; }
        System.Collections.Generic.IEnumerable<string> ReferencedFiles { get; }
        System.Collections.Generic.IEnumerable<string> ReferencedModulesByName { get; }
        System.Collections.Generic.IEnumerable<string> ReferencedModulesByPath { get; }
        JetBrains.ReSharper.Psi.Web.PsiModules.IAspFileDataDiff GetDiff([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Web.PsiModules.IAspFileData otherData);
    }
    public interface IAspFileDataCache
    {
        JetBrains.DataFlow.ISignal<JetBrains.Util.Pair<JetBrains.Util.FileSystemPath, JetBrains.ReSharper.Psi.Web.PsiModules.IAspFileDataDiff>> ProjectFileDataChanged { get; }
        System.Collections.Generic.Dictionary<JetBrains.Util.FileSystemPath, JetBrains.ReSharper.Psi.Web.PsiModules.IAspFileData> GetExistingData();
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Web.PsiModules.IAspFileData GetExistingData(JetBrains.ProjectModel.IProjectFile projectFile);
    }
    public interface IAspFileDataDiff
    {
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.IEnumerable<string> AddedReferencedFiles { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.IEnumerable<string> AddedReferencedModulesByName { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.IEnumerable<string> AddedReferencedModulesByPath { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        string NewCodeFile { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        string NewLanguageDefinedInFile { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        string OldCodeFile { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        string OldLanguageDefinedInFile { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.IEnumerable<string> RemovedReferencedFiles { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.IEnumerable<string> RemovedReferencedModulesByName { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.IEnumerable<string> RemovedReferencedModulesByPath { get; }
        bool IsEmpty();
    }
    public interface IGlobalResourcePsiSourceFileProperties : JetBrains.ReSharper.Psi.ICustomPsiSourceFileProperties { }
    public interface ISharepointProjectModule : JetBrains.ProjectModel.IModule, JetBrains.ProjectModel.IProjectModelElement, JetBrains.Util.IUserDataHolder { }
    public interface IWebAssemblyReferenceFactory
    {
        JetBrains.DataFlow.ISimpleSignal AssembliesCreated { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ProjectModel.Model2.Assemblies.Interfaces.IAssemblyCookie ResolveAssemblyNameReference(JetBrains.Metadata.Utils.AssemblyNameInfo assemblyName, JetBrains.ProjectModel.IProject webProject, string id);
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ProjectModel.Model2.Assemblies.Interfaces.IAssemblyCookie ResolveAssemblyPathReference(JetBrains.Util.FileSystemPath assemplyPath, JetBrains.ProjectModel.IProject webProject, string id);
    }
    public interface IWebProjectFileClassifier
    {
        bool CanBeAppCodeFile([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IProjectFile projectFile);
        bool CanBeAspFile([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IProjectFile projectFile);
        bool CanBeCodeBehindFile([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IProjectFile projectFile);
    }
    public class static SharepointExtensions
    {
        [JetBrains.Annotations.ContractAnnotationAttribute("null => false")]
        public static bool IsSharepointWorkflow(this JetBrains.ProjectModel.IModule module) { }
    }
}
namespace JetBrains.ReSharper.Psi.Web.References
{
    
    public interface IHtmlPathBinder
    {
        string GetTargetPath<TOwner, TToken>(JetBrains.ReSharper.Psi.Web.References.PathReferenceBase<TOwner, TToken> reference, JetBrains.ReSharper.Psi.IPathDeclaredElement pathDeclaredElement)
            where TOwner : JetBrains.ReSharper.Psi.Tree.ITreeNode
            where TToken :  class, JetBrains.ReSharper.Psi.Tree.ITreeNode;
        JetBrains.ReSharper.Psi.Resolve.IReference SetText<TOwner, TToken>(JetBrains.ReSharper.Psi.Web.References.PathReferenceBase<TOwner, TToken> reference, string newText)
            where TOwner : JetBrains.ReSharper.Psi.Tree.ITreeNode
            where TToken :  class, JetBrains.ReSharper.Psi.Tree.ITreeNode;
        JetBrains.ReSharper.Psi.Tree.ITreeNode SetText<TOwner, TToken>(JetBrains.ReSharper.Psi.Web.References.PathReferenceBase<TOwner, TToken> reference, JetBrains.ReSharper.Psi.TreeTextRange range, string newText)
            where TOwner : JetBrains.ReSharper.Psi.Tree.ITreeNode
            where TToken :  class, JetBrains.ReSharper.Psi.Tree.ITreeNode;
    }
    public interface IIgnorablePathReference : JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IQualifiableReferenceBase, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IQualifiableReferenceWithGlobalSymbolTable, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IReferenceWithGlobalSymbolTable, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IReferenceWithQualifier, JetBrains.ReSharper.Psi.Resolve.ICompleteableReference, JetBrains.ReSharper.Psi.Resolve.IPathReference, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.Util.IUserDataHolder
    {
        bool AllowEmptyName { get; }
        bool CanBeMappedOrIgnored { get; }
    }
    public interface IPathQualifier : JetBrains.ReSharper.Psi.Resolve.IQualifier
    {
        bool AllowedOustideOfSite { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.Util.FileSystemPath Path { get; }
    }
    public class PathQualifier : JetBrains.ReSharper.Psi.Resolve.IQualifier, JetBrains.ReSharper.Psi.Web.References.IPathQualifier
    {
        public PathQualifier([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.ISolution solution, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.FileSystemPath qualifierPath, bool allowedOustideOfSite = False) { }
        public bool AllowedOustideOfSite { get; }
        public JetBrains.Util.FileSystemPath Path { get; }
        public bool Resolved { get; }
        public JetBrains.ReSharper.Psi.Resolve.QualifierKind GetKind() { }
        public JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetSymbolTable(JetBrains.ReSharper.Psi.Resolve.SymbolTableMode mode) { }
    }
    public abstract class PathReferenceBase<TOwner, TToken> : JetBrains.ReSharper.Psi.Impl.Shared.References.QualifiableReferenceWithinElement<TOwner, TToken>, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IQualifiableReferenceBase, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IQualifiableReferenceWithGlobalSymbolTable, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IReferenceWithGlobalSymbolTable, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IReferenceWithQualifier, JetBrains.ReSharper.Psi.Resolve.ICompleteableReference, JetBrains.ReSharper.Psi.Resolve.IPathReference, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.ReSharper.Psi.Web.References.IIgnorablePathReference, JetBrains.Util.IUserDataHolder
        where TOwner : JetBrains.ReSharper.Psi.Tree.ITreeNode
        where TToken :  class, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        protected PathReferenceBase(TOwner owner, JetBrains.ReSharper.Psi.Resolve.IQualifier qualifier, TToken token, JetBrains.ReSharper.Psi.TreeTextRange rangeWithin) { }
        public virtual bool AllowEmptyName { get; }
        public virtual bool CanBeMappedOrIgnored { get; }
        public override bool IsQualified { get; }
        public JetBrains.Util.FileSystemPath GetBasePath() { }
        protected override JetBrains.ReSharper.Psi.Resolve.ISymbolFilter[] GetCompletionFilters() { }
        public JetBrains.ReSharper.Psi.Resolve.ISymbolFilter[] GetPathFilters() { }
        public override JetBrains.ReSharper.Psi.ITypeElement GetQualifierTypeElement() { }
        public override JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetReferenceSymbolTable(bool useReferenceName) { }
        public override JetBrains.ReSharper.Psi.Resolve.Staticness GetStaticness() { }
        public override JetBrains.ReSharper.Psi.Resolve.ISymbolFilter[] GetSymbolFilters() { }
    }
    public abstract class StringLiteralPathBinder : JetBrains.ReSharper.Psi.Web.References.IHtmlPathBinder
    {
        protected StringLiteralPathBinder(JetBrains.ReSharper.Psi.Util.IStringLiteralAltererProvider stringLiteralAltererProvider) { }
        public string GetTargetPath<TOwner, TToken>(JetBrains.ReSharper.Psi.Web.References.PathReferenceBase<TOwner, TToken> reference, JetBrains.ReSharper.Psi.IPathDeclaredElement pathDeclaredElement)
            where TOwner : JetBrains.ReSharper.Psi.Tree.ITreeNode
            where TToken :  class, JetBrains.ReSharper.Psi.Tree.ITreeNode { }
        public JetBrains.ReSharper.Psi.Resolve.IReference SetText<TOwner, TToken>(JetBrains.ReSharper.Psi.Web.References.PathReferenceBase<TOwner, TToken> reference, string newText)
            where TOwner : JetBrains.ReSharper.Psi.Tree.ITreeNode
            where TToken :  class, JetBrains.ReSharper.Psi.Tree.ITreeNode { }
        public JetBrains.ReSharper.Psi.Tree.ITreeNode SetText<TOwner, TToken>(JetBrains.ReSharper.Psi.Web.References.PathReferenceBase<TOwner, TToken> reference, JetBrains.ReSharper.Psi.TreeTextRange range, string newText)
            where TOwner : JetBrains.ReSharper.Psi.Tree.ITreeNode
            where TToken :  class, JetBrains.ReSharper.Psi.Tree.ITreeNode { }
    }
}
namespace JetBrains.ReSharper.Psi.Web.Resolve
{
    
    public class ExistingNamesFilter : JetBrains.ReSharper.Psi.Resolve.SimpleSymbolFilter
    {
        public ExistingNamesFilter(System.Collections.Generic.JetHashSet<string> usedNames) { }
        public override JetBrains.ReSharper.Psi.Resolve.ResolveErrorType ErrorType { get; }
        public override bool Accepts(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution) { }
    }
    public class static WebDirectiveReferenceUtil
    {
        public static JetBrains.ReSharper.Psi.Resolve.ISymbolFilter[] GetCompletionFilters(JetBrains.ReSharper.Psi.Resolve.IReference directiveReference) { }
    }
    public class WebResolveErrorType : JetBrains.ReSharper.Psi.Resolve.ResolveErrorTypeWithTooltip
    {
        public static readonly JetBrains.ReSharper.Psi.Resolve.ResolveErrorType EXTENSION_MISMATCH;
        public static readonly JetBrains.ReSharper.Psi.Resolve.ResolveErrorType INVALID_DIRECTIVE;
        public static readonly JetBrains.ReSharper.Psi.Resolve.ResolveErrorType PATH_OUTSIDE_WEBSITE;
        public static readonly JetBrains.ReSharper.Psi.Resolve.ResolveErrorType[] PathErrors;
        public WebResolveErrorType(string name, string tooltip) { }
    }
}
namespace JetBrains.ReSharper.Psi.Web.Resources
{
    
    public sealed class PsiWebThemedIcons
    {
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Psi.Web;component/resources/PsiWebThemedIcons/ThemedIcons.Psi" +
            "Web.Generated.Xaml", 1, "AspDirective")]
        public sealed class AspDirective : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Psi.Web;component/resources/PsiWebThemedIcons/ThemedIcons.Psi" +
            "Web.Generated.Xaml", 2, "AspDirectiveAttribute")]
        public sealed class AspDirectiveAttribute : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Psi.Web;component/resources/PsiWebThemedIcons/ThemedIcons.Psi" +
            "Web.Generated.Xaml", 0, "AspHtmlTagAttributeValue")]
        public sealed class AspHtmlTagAttributeValue : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
    }
}
namespace JetBrains.ReSharper.Psi.Web.Searching
{
    
    public class WebReferenceSearcher<TLanguage> : JetBrains.ReSharper.Psi.ExtensionsAPI.IDomainSpecificSearcher
        where TLanguage : JetBrains.ReSharper.Psi.KnownLanguage
    {
        public WebReferenceSearcher(JetBrains.ReSharper.Psi.ExtensionsAPI.IDomainSpecificSearcherFactory factory, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IDeclaredElement> elements, bool findCandidates, bool searchForLateBound) { }
        public bool ProcessElement<TResult>(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.Search.IFindResultConsumer<TResult> consumer) { }
        public bool ProcessProjectItem<TResult>(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, JetBrains.ReSharper.Psi.Search.IFindResultConsumer<TResult> consumer) { }
    }
    public class WebTextOccurenceSearcher<TLanguage> : JetBrains.ReSharper.Psi.ExtensionsAPI.IDomainSpecificSearcher
        where TLanguage : JetBrains.ReSharper.Psi.KnownLanguage
    {
        public WebTextOccurenceSearcher(params string[] texts) { }
        public bool ProcessElement<TResult>(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.Search.IFindResultConsumer<TResult> consumer) { }
        public bool ProcessProjectItem<TResult>(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, JetBrains.ReSharper.Psi.Search.IFindResultConsumer<TResult> consumer) { }
    }
}
namespace JetBrains.ReSharper.Psi.Web.Services
{
    
    public interface ISourceFilesResolver
    {
        System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.IPsiSourceFile> FilterSourceFiles(System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.IPsiSourceFile> files);
    }
}
namespace JetBrains.ReSharper.Psi.Web.Symbols
{
    
    public interface IWebClassSymbol : JetBrains.ReSharper.Psi.Web.Symbols.IWebSymbol
    {
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Web.DeclaredElements.ICssClassDeclaredElement GetDeclaredElement();
    }
    [JetBrains.Annotations.CannotApplyEqualityOperatorAttribute()]
    public interface IWebSymbol
    {
        [JetBrains.Annotations.NotNullAttribute()]
        string Name { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        string ProviderId { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IPsiSourceFile SourceFile { get; }
        int StartOffset { get; }
        JetBrains.ReSharper.Psi.Web.Symbols.WebVisibilityScope VisibilityScope { get; }
    }
    public interface IWebSymbolsCache
    {
        System.Collections.Generic.IEnumerable<string> GetNames();
        System.Collections.Generic.IEnumerable<string> GetNames(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile);
        System.Collections.Generic.IEnumerable<T> GetSymbols<T>()
            where T :  class, JetBrains.ReSharper.Psi.Web.Symbols.IWebSymbol;
        System.Collections.Generic.IEnumerable<T> GetSymbols<T>(string name)
            where T :  class, JetBrains.ReSharper.Psi.Web.Symbols.IWebSymbol;
        System.Collections.Generic.IEnumerable<T> GetSymbols<T>(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile)
            where T :  class, JetBrains.ReSharper.Psi.Web.Symbols.IWebSymbol;
    }
    public interface IWebSymbolsProvider
    {
        string Id { get; }
        bool IsEnabled { get; }
        int Version { get; }
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Web.Symbols.IWebSymbol> BuildSymbols([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile);
        JetBrains.ReSharper.Psi.Web.Symbols.IWebSymbol ReadSymbol([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, System.IO.BinaryReader reader, JetBrains.ReSharper.Psi.Util.ITokenIntern identifierIntern);
        bool Support([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile);
        void WriteSymbol(System.IO.BinaryWriter writer, JetBrains.ReSharper.Psi.Web.Symbols.IWebSymbol symbol);
    }
    public interface IWebTagIdSymbol : JetBrains.ReSharper.Psi.Web.Symbols.IWebSymbol
    {
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Web.DeclaredElements.IHtmlTagIdDeclaredElement GetDeclaredElement();
    }
    public class WebSymbolsVisibilityManager { }
    public enum WebVisibilityScope : sbyte
    {
        Everywhere = 0,
        FileLocal = 1,
    }
}
namespace JetBrains.ReSharper.Psi.Web.TagPrefixes
{
    
    public interface IGlobalTagPrefix : JetBrains.ReSharper.Psi.IDeclaredElement, JetBrains.ReSharper.Psi.Web.TagPrefixes.ITagPrefix
    {
        System.Collections.Generic.IEnumerable<string> NamespaceNames { get; }
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.INamespace> GetReferencedNamespaces(JetBrains.ReSharper.Psi.Modules.IPsiModule currentModule, JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext context);
    }
    public interface ITagName : JetBrains.ReSharper.Psi.IDeclaredElement
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Web.TagPrefixes.ITagNameDeclaration GetDeclaration();
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Web.TagPrefixes.ITagPrefix GetParentTagPrefix();
    }
    public interface ITagNameDeclaration : JetBrains.ReSharper.Psi.Tree.IDeclaration, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Tree.IXmlDocOwnerTreeNode
    {
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Web.TagPrefixes.ITagPrefixHolder Holder { get; }
    }
    public interface ITagPrefix : JetBrains.ReSharper.Psi.IDeclaredElement
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Web.TagPrefixes.ITagPrefixDeclaration GetDeclaration();
    }
    public interface ITagPrefixDeclaration : JetBrains.ReSharper.Psi.Tree.IDeclaration, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Tree.IXmlDocOwnerTreeNode
    {
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Web.TagPrefixes.ITagPrefixHolder Holder { get; }
    }
    public interface ITagPrefixHolder : JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        string Assembly { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Resolve.IReference NamespaceReference { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Resolve.IReference SrcPathReference { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Web.TagPrefixes.ITagNameDeclaration TagNameDeclaration { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Web.TagPrefixes.ITagPrefixDeclaration TagPrefixDeclaration { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.Util.FileSystemPath TargetPath { get; }
    }
    public interface ITagPrefixSupport
    {
        JetBrains.ReSharper.Psi.Web.TagPrefixes.TagNameDeclarationConflict DeclarationHides(JetBrains.ReSharper.Psi.Web.TagPrefixes.ITagNameDeclaration nameDeclaration, JetBrains.ReSharper.Psi.Web.TagPrefixes.ITagName tagName);
        System.Collections.Generic.IEnumerable<JetBrains.ProjectModel.IProjectFile> GetImmediateRelevantFiles(JetBrains.ReSharper.Psi.IPsiSourceFile psiSourceFile);
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Web.TagPrefixes.ITagPrefixHolder> GetTagPrefixHolders(JetBrains.ReSharper.Psi.Tree.IFile file, JetBrains.Util.FileSystemPath targetPath);
    }
    public enum TagNameDeclarationConflict
    {
        HIDES = 0,
        ERROR = 1,
    }
    public class static TagNameExtensions
    {
        public static string GetFullName([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Web.TagPrefixes.ITagName tagName) { }
        public static string GetFullName([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Web.TagPrefixes.ITagNameDeclaration tagNameDeclaration) { }
        public static string GetTagName([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Web.TagPrefixes.ITagName tagName) { }
        public static string GetTagName([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Web.TagPrefixes.ITagNameDeclaration tagNameDeclaration) { }
        public static string GetTagPrefix([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Web.TagPrefixes.ITagName tagName) { }
        public static string GetTagPrefix([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Web.TagPrefixes.ITagNameDeclaration tagNameDeclaration) { }
    }
    public abstract class TagPrefixCache
    {
        public abstract System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Web.TagPrefixes.IGlobalTagPrefix> GetGlobalTagPrefixes([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IModule module, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext resolveContext);
        public static JetBrains.ReSharper.Psi.Web.TagPrefixes.TagPrefixCache GetInstance(JetBrains.ProjectModel.ISolution solution) { }
        public abstract System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IPsiSourceFile> GetSourceFiles(string tagPrefix);
    }
    public class static TagPrefixExtensions
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Psi.INamespace GetReferencedNamespace([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Web.TagPrefixes.ITagPrefixDeclaration prefixDeclaration) { }
        public static string GetTagPrefix([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Web.TagPrefixes.ITagPrefixDeclaration prefixDeclaration) { }
        public static string GetTagPrefix([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Web.TagPrefixes.ITagPrefix prefix) { }
    }
}
namespace JetBrains.ReSharper.Psi.Web.Tree
{
    
    public interface IWebAttribute : JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode
    {
        [JetBrains.Annotations.NotNullAttribute()]
        string AttributeName { get; }
        bool AttributeNameEqualsTo(string attributeName);
    }
    public interface IWebAttributeContainer<T> : JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode
        where T :  class, JetBrains.ReSharper.Psi.Web.Tree.IWebAttribute
    {
        System.Collections.Generic.IEnumerable<T> Attributes { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        T AddAttributeAfter([JetBrains.Annotations.NotNullAttribute()] T attribute, [JetBrains.Annotations.CanBeNullAttribute()] T anchor = null);
        [JetBrains.Annotations.NotNullAttribute()]
        T AddAttributeBefore([JetBrains.Annotations.NotNullAttribute()] T attribute, [JetBrains.Annotations.CanBeNullAttribute()] T anchor = null);
        void RemoveAttribute([JetBrains.Annotations.NotNullAttribute()] T attribute);
    }
    public interface IWebCodeBlock { }
    public interface IWebFile : JetBrains.ReSharper.Psi.Tree.IFile, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode { }
    public interface IWebFileWithCodeBehind : JetBrains.ReSharper.Psi.Tree.IFile, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebFile, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode
    {
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IDeclaredType> GetSuperTypes();
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Tree.ITypeDeclaration GetTypeDeclaration();
    }
    public interface IWebTreeNode : JetBrains.ReSharper.Psi.Tree.ITreeNode { }
    public class static WebAttributeContainerExtensions
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static T GetAttribute<T>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Web.Tree.IWebAttributeContainer<T> container, [System.ComponentModel.LocalizableAttribute(false)] string attributeName)
            where T :  class, JetBrains.ReSharper.Psi.Web.Tree.IWebAttribute { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static T1 GetAttribute<T1, T>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Web.Tree.IWebAttributeContainer<T> container, string attributeName)
            where T1 :  class, T
            where T :  class, JetBrains.ReSharper.Psi.Web.Tree.IWebAttribute { }
        public static System.Collections.Generic.IEnumerable<T> GetAttributes<T>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Web.Tree.IWebAttributeContainer<T> container, string attributeName)
            where T :  class, JetBrains.ReSharper.Psi.Web.Tree.IWebAttribute { }
        public static System.Collections.Generic.IEnumerable<T1> GetAttributes<T1, T>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Web.Tree.IWebAttributeContainer<T> container, string attributeName)
            where T1 :  class, T
            where T :  class, JetBrains.ReSharper.Psi.Web.Tree.IWebAttribute { }
        public static System.Collections.Generic.IEnumerable<T> GetAttributes<T>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Web.Tree.IWebAttributeContainer<T> container)
            where T :  class, JetBrains.ReSharper.Psi.Web.Tree.IWebAttribute { }
        public static System.Collections.Generic.IEnumerable<T> GetAttributes<T>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Web.Tree.IWebAttributeContainer<T> container, System.Predicate<T> predicate)
            where T :  class, JetBrains.ReSharper.Psi.Web.Tree.IWebAttribute { }
        public static System.Collections.Generic.IEnumerable<T1> GetAttributes<T1, T>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Web.Tree.IWebAttributeContainer<T> container, System.Predicate<T> predicate)
            where T1 :  class, T
            where T :  class, JetBrains.ReSharper.Psi.Web.Tree.IWebAttribute { }
    }
}
namespace JetBrains.ReSharper.Psi.Web.Util
{
    
    public class static CodeBehindLanguageUtil
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Psi.Tree.IFile GetCodeBehindFile([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Web.Tree.IWebFileWithCodeBehind webFile) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Psi.Tree.IFile GetCodeBehindFileViaPsiFast([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
        public static JetBrains.ReSharper.Psi.PsiLanguageType GetCodeBehindLanguage([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ProjectModel.IProjectFile projectFile) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.ReSharper.Psi.PsiLanguageType GetCodeBehindLanguage([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.ReSharper.Psi.PsiLanguageType GetCodeBehindLanguage([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.PsiLanguageType codeBehindLanguageDefinedInFile) { }
        public static JetBrains.ReSharper.Psi.PsiLanguageType GetCodeBehindLanguage([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ProjectModel.IProjectFile projectFile, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.PsiLanguageType codeBehindLanguageDefinedInFile) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.ReSharper.Psi.PsiLanguageType GetCodeBehindLanguage([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Web.Tree.IWebFileWithCodeBehind webFile) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.ReSharper.Psi.PsiLanguageType GetCodeBehindLanguage([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode webElement) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Psi.PsiLanguageType GetCodeBehindLanguageDefinedInFile([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Psi.PsiLanguageType GetCodeBehindLanguageDefinedInFile([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ProjectModel.IProjectFile projectFile) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.ReSharper.Psi.PsiLanguageType GetCodeBehindLanguageViaPsiFast([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
        public static JetBrains.ProjectModel.ProjectFileType GetCodeBehindProjectFileLanguage([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
        public static bool GetSingleTypeDeclaration(JetBrains.ReSharper.Psi.Tree.ITypeAndNamespaceHolderDeclaration holder, ref JetBrains.ReSharper.Psi.Tree.ITypeDeclaration currentCandidate) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class ReferencedAssembliesService
    {
        public ReferencedAssembliesService(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ProjectModel.ISolution solution, JetBrains.Application.ChangeManager changeManager) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ProjectModel.ProjectReferenceChange IsAssemblyReferenceChange([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ProjectModel.ProjectModelChange projectModelChange, JetBrains.Metadata.Utils.AssemblyNameInfo assemblyInfo) { }
        public static bool IsProjectReferencingAssemblyByName([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ProjectModel.IProject project, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Metadata.Utils.AssemblyNameInfo targetAssembly, [JetBrains.Annotations.CanBeNullAttribute()] out JetBrains.Metadata.Utils.AssemblyNameInfo referencedAssembly) { }
        [JetBrains.Annotations.ContractAnnotationAttribute("=> true, referencedAssembly:notnull; => false, referencedAssembly:null")]
        public static bool IsProjectReferencingAssemblyByName([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ProjectModel.IProjectElement projectElement, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Metadata.Utils.AssemblyNameInfo targetAssembly, [JetBrains.Annotations.CanBeNullAttribute()] out JetBrains.Metadata.Utils.AssemblyNameInfo referencedAssembly) { }
    }
    public class static ReferencedAssembliesServiceEx
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ProjectModel.ProjectReferenceChange IsMvcAssemblyReferenceChange([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ProjectModel.ProjectModelChange projectModelChange) { }
        public static bool IsProjectReferencingMvc([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ProjectModel.IProjectElement projectElement) { }
        [JetBrains.Annotations.ContractAnnotationAttribute("=>true,version:notnull;=>false,version:null")]
        public static bool IsProjectReferencingMvc([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ProjectModel.IProjectElement projectElement, [JetBrains.Annotations.CanBeNullAttribute()] out System.Version version) { }
        public static bool IsProjectReferencingMvc3([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ProjectModel.IProjectElement projectElement) { }
        public static bool IsProjectReferencingRazor([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ProjectModel.IProjectElement projectElement) { }
        public static bool IsProjectReferencingRazor2([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ProjectModel.IProjectElement projectElement) { }
    }
    public class static WebAttributeUtil
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public static string GetAttributeName([JetBrains.Annotations.NotNullAttribute()] string prefix, [JetBrains.Annotations.NotNullAttribute()] string name) { }
        public static bool HasName([JetBrains.Annotations.NotNullAttribute()] string prefix, [JetBrains.Annotations.NotNullAttribute()] string name, [JetBrains.Annotations.NotNullAttribute()] string attributeName) { }
    }
    public class static WebFilesUtil
    {
        public const string APP_CODE = "App_Code";
        public const string APP_CODE_SUBCODE = "App_SubCode";
        public const string APP_GLOBAL_RESOURCES = "App_GlobalResources";
        public const string APP_THEMES = "App_Themes";
        public const string APP_WEB = "App_Web";
        public const string APP_WEB_REFERENCES = "App_WebReferences";
        public const string BIN = "Bin";
        public const string CLIENT_BIN = "ClientBin";
        public const string DOT_DESIGNER = ".designer";
        public const string GLOBAL_ASAX = "global.asax";
        public const string WEB_CONFIG = "web.config";
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ProjectModel.IProjectFolder GetAppCodeFolder(this JetBrains.ProjectModel.IProject project) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Psi.Modules.IPsiModule GetAppCodeModule([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Psi.Modules.IPsiModule GetAppCodeModule([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ProjectModel.IProject project) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ProjectModel.IProjectFolder GetAppGlobalResourcesFolder([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ProjectModel.IProject project) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ProjectModel.IProjectFile GetAspFileByCodeBehindFile([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IProjectFile codeBehindFile, [JetBrains.Annotations.NotNullAttribute()] System.Func<JetBrains.ProjectModel.IProjectFile, bool> isWebPage) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ProjectModel.IProjectFile GetCodeBehindFileByDesignerFile([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IProjectFile designerFile) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ProjectModel.IProjectFile GetCodeBehindFileByWebPageFile([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ProjectModel.IProjectFile webPageFile, [JetBrains.Annotations.NotNullAttribute()] string codeFileString) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.Util.FileSystemPath GetCodeBehindFilePath([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IProjectFile projectFile, [JetBrains.Annotations.NotNullAttribute()] string codeFileString) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ProjectModel.IProjectFile GetDesignerFileByCodeBehindFile([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IProjectFile codeBehindFile) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ProjectModel.IProjectFile GetDesignerFileByWebPageFile([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IProjectFile webPageFile, [JetBrains.Annotations.NotNullAttribute()] string codeFileString) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.Util.FileSystemPath GetDesignerFilePath([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IProjectFile projectFile, [JetBrains.Annotations.NotNullAttribute()] string codeFileString) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.Util.FileSystemPath GetDesignerFilePath([JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.FileSystemPath codeBehindFilePath) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ProjectModel.IProjectFile GetGlobalAsax([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ProjectModel.IProject project) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ProjectModel.IProjectFile GetMainWebConfig([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ProjectModel.IProject project) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ProjectModel.IProjectFile GetProjectItem([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IProjectElement projectElement, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.FileSystemPath path) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ProjectModel.IProjectFile GetProjectItem([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ProjectModel.IProject project, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.FileSystemPath path) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.Util.FileSystemPath GetProjectPath([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IProjectFile file) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.Util.FileSystemPath GetProjectPath([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ProjectModel.IProject project) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ProjectModel.IProjectFile GetReferencedFile([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IProjectFile file, out JetBrains.Util.FileSystemPath referencedPath, [JetBrains.Annotations.NotNullAttribute()] string srcPath) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.Util.FileSystemPath GetReferencedPath([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IProjectFile projectFile, [JetBrains.Annotations.NotNullAttribute()] string srcPath) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.Util.FileSystemPath GetReferencedPath([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IProject project, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.FileSystemPath aspFilePath, [JetBrains.Annotations.NotNullAttribute()] string srcPath) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ProjectModel.IProjectFile GetWebPageFileByDesignerFile([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IProjectFile designerFile, [JetBrains.Annotations.NotNullAttribute()] System.Func<JetBrains.ProjectModel.IProjectFile, bool> isWebPage) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ProjectModel.IProjectFolder GetWebReferencesFolder([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ProjectModel.IProject project) { }
        public static bool InAppGlobalResourcesFolder([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ProjectModel.IProjectFile projectFile) { }
        public static bool InWebReferencesFolder([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ProjectModel.IProjectFile projectFile) { }
        public static bool IsAppCodeFile([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ProjectModel.IProjectFile projectFile) { }
        public static bool IsAppCodeFolder([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ProjectModel.IProjectFolder folder) { }
        public static bool IsAppGlobalResourcesFolder([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ProjectModel.IProjectFolder folder) { }
        public static bool IsBinFolder([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ProjectModel.IProjectFolder folder) { }
        public static bool IsClientBinFolder([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ProjectModel.IProjectFolder folder) { }
        public static bool IsDesignerFile([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ProjectModel.IProjectFile designerFile) { }
        public static bool IsFileInFolder([JetBrains.Annotations.CanBeNullAttribute()] this JetBrains.ProjectModel.IProjectFile projectFile, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ProjectModel.IProjectFolder projectFolder) { }
        public static bool IsFileInFolder([JetBrains.Annotations.CanBeNullAttribute()] this JetBrains.ProjectModel.IProjectFile projectFile, [JetBrains.Annotations.NotNullAttribute()] System.Predicate<JetBrains.ProjectModel.IProjectFolder> folderCheck) { }
        public static bool IsGlobalAsax([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ProjectModel.IProjectFile projectFile) { }
        public static bool IsMainWebConfig([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ProjectModel.IProjectFile projectFile) { }
        public static bool IsWebReferencesFolder([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ProjectModel.IProjectFolder folder) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.Util.FileSystemPath ResolveInclude([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.ISolution solution, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.FileSystemPath baseFilePath, [JetBrains.Annotations.NotNullAttribute()] string includeName, bool isVirtual) { }
        public class ProjectPathCookie : System.IDisposable
        {
            public ProjectPathCookie(JetBrains.Util.FileSystemPath projectPath) { }
            public void Dispose() { }
        }
    }
    public class static WebPathReferenceUtil
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.ReSharper.Psi.Resolve.ISymbolFilter[] AddNoCircularPathReferenceFilter([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Resolve.ISymbolFilter[] filters, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Resolve.IPathReference pathReference) { }
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.ResolveResultWithInfo CheckResolveResult(JetBrains.ReSharper.Psi.Web.References.IIgnorablePathReference pathReference, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.ResolveResultWithInfo resolveResult) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static string ConvertToRootRelativePath([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IProjectItem projectItem, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.FileSystemPath path) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static string ConvertToRootRelativePath([JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.FileSystemPath root, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.FileSystemPath path) { }
        public static JetBrains.Util.FileSystemPath GetBasePath(JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IQualifiableReferenceWithGlobalSymbolTable pathReference) { }
        public static JetBrains.ReSharper.Psi.Resolve.ISymbolFilter[] GetCompletionFilters(JetBrains.ReSharper.Psi.Resolve.IPathReference pathReference) { }
        public static JetBrains.ReSharper.Psi.Resolve.ISymbolFilter[] GetFolderSmartSymbolFilters(JetBrains.ReSharper.Psi.Resolve.IPathReference folderReference) { }
        public static JetBrains.ReSharper.Psi.Resolve.ISymbolFilter[] GetPathInWebsiteFilter([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Resolve.IPathReference pathReference) { }
        public static JetBrains.Util.FileSystemPath GetPathUnmapped(JetBrains.ReSharper.Psi.Web.References.IIgnorablePathReference pathReference, JetBrains.ReSharper.Psi.IPathDeclaredElement pathDeclaredElement) { }
        public static JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetQualifierSymbolTable(JetBrains.ReSharper.Psi.Resolve.IPathReference pathReference) { }
        public static JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetReferenceSymbolTable(JetBrains.ReSharper.Psi.Resolve.IPathReference pathReference, bool useReferenceName) { }
        public static JetBrains.Util.FileSystemPath GetRootPath([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ProjectModel.IProject project) { }
        public static JetBrains.Util.FileSystemPath GetRootPath([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IProjectItem projectItem) { }
        public static JetBrains.Util.FileSystemPath GetRootPath([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
        public static JetBrains.Util.FileSystemPath GetRootPath([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Resolve.IPathReference pathReference) { }
        public static JetBrains.ReSharper.Psi.Resolve.ISymbolFilter[] GetSmartSymbolFilters(JetBrains.ReSharper.Psi.Resolve.IPathReference pathReference) { }
        public static JetBrains.ReSharper.Psi.Resolve.ISymbolFilter[] GetSmartSymbolFilters(JetBrains.ReSharper.Psi.Resolve.IFileReference fileReference) { }
        public static JetBrains.Util.FileSystemPath GetVirtualPathInWebsite([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IPathDeclaredElement pathDeclaredElement, JetBrains.ProjectModel.IProject project) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.Util.FileSystemPath GetVirtualPathInWebsite([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IProjectItem projectItem) { }
    }
    [JetBrains.ReSharper.Psi.PsiSharedComponentAttribute()]
    public class WebPsiLanguageUtil
    {
        public static readonly System.Text.RegularExpressions.Regex LANGUAGE_REGEX;
        public static readonly System.Text.RegularExpressions.Regex RUNAT_SERVER_REGEX;
        public WebPsiLanguageUtil(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ReSharper.Psi.ILanguageManager languageManager) { }
        [System.ObsoleteAttribute("Inject me!")]
        public static JetBrains.ReSharper.Psi.Web.Util.WebPsiLanguageUtil Instance { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.PsiLanguageType> GetPossibleCodeBehindLanguages() { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Psi.PsiLanguageType GetPsiLanguageByAttributeValue(string value) { }
        public JetBrains.ReSharper.Psi.PsiLanguageType GetPsiLanguageByHeaderText(string headerText) { }
        public bool IsCaseSensitiveCodeBehindLanguage(JetBrains.ReSharper.Psi.PsiLanguageType codeBehindLanguage) { }
        public bool IsPossibleCodeBehindLanguage(JetBrains.ReSharper.Psi.PsiLanguageType language) { }
    }
}
namespace JetBrains.ReSharper.Psi.Web.WebConfig
{
    
    public abstract class LinkedConfigurationManager : System.IDisposable
    {
        protected LinkedConfigurationManager() { }
        public JetBrains.DataFlow.ISignal<System.Collections.Generic.ICollection<JetBrains.Util.FileSystemPath>> FilesChanged { get; }
        protected virtual void Dispose() { }
        public static JetBrains.ReSharper.Psi.Web.WebConfig.LinkedConfigurationManager GetInstance(JetBrains.ProjectModel.ISolution solution) { }
        public static JetBrains.ReSharper.Psi.Web.WebConfig.LinkedConfigurationManager GetInstance(JetBrains.ProjectModel.IProjectFile projectFile) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public abstract JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IConfigurationTag GetLinkedConfiguration([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Web.WebConfig.Tree.ILinkedConfigurationTag linkedConfigurationTag, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IProjectFile projectFile);
        protected void RaiseFilesChanged(System.Collections.Generic.ICollection<JetBrains.Util.FileSystemPath> filePaths) { }
    }
    [JetBrains.ReSharper.Psi.LanguageDefinitionAttribute("Web.Config")]
    public class WebConfigLanguage : JetBrains.ReSharper.Psi.Xml.XmlLanguage
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static readonly JetBrains.ReSharper.Psi.Web.WebConfig.WebConfigLanguage Instance;
        public const string Name = "Web.Config";
        protected WebConfigLanguage([JetBrains.Annotations.NotNullAttribute()] string name) { }
        protected WebConfigLanguage([JetBrains.Annotations.NotNullAttribute()] string name, [JetBrains.Annotations.NotNullAttribute()] string presentableName) { }
    }
    [JetBrains.ProjectModel.ProjectFileTypeAttribute(typeof(JetBrains.ProjectModel.WebConfigProjectFileType))]
    public class WebConfigProjectFileLanguageService : JetBrains.ReSharper.Psi.Xml.XmlProjectFileLanguageService
    {
        public WebConfigProjectFileLanguageService(JetBrains.ProjectModel.WebConfigProjectFileType webConfigProjectFileType) { }
        public override JetBrains.UI.Icons.IconId Icon { get; }
        public override JetBrains.ReSharper.Psi.PsiLanguageType GetPsiLanguageType(JetBrains.ProjectModel.IProjectFile projectFile) { }
        public override JetBrains.ReSharper.Psi.PsiLanguageType GetPsiLanguageType(JetBrains.ProjectModel.ProjectFileType languageType) { }
        public override JetBrains.ReSharper.Psi.IPsiSourceFileProperties GetPsiProperties(JetBrains.ProjectModel.IProjectFile projectFile, JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
    }
    public class static WebExtensions
    {
        public static string GetExtensionWithDot([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.IPsiSourceFile psiSourceFile) { }
        public static bool IsAsaxFile([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.IPsiSourceFile psiSourceFile) { }
        public static bool IsHtmlPage([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.IPsiSourceFile psiSourceFile) { }
        public static bool IsMasterPage([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.IPsiSourceFile psiSourceFile) { }
        public static bool IsUserControl([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.IPsiSourceFile psiSourceFile) { }
        public static bool IsWcfService([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.IPsiSourceFile psiSourceFile) { }
        public static bool IsWebHandler([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.IPsiSourceFile psiSourceFile) { }
        public static bool IsWebPage([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.IPsiSourceFile psiSourceFile) { }
        public static bool IsWebService([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.IPsiSourceFile psiSourceFile) { }
    }
}
namespace JetBrains.ReSharper.Psi.Web.WebConfig.Naming
{
    
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.Web.WebConfig.WebConfigLanguage))]
    public class WebConfigConfigurableWebProjectNamingSettings : JetBrains.ReSharper.Psi.Web.Naming.IConfigurableWebProjectNamingSettings { }
    [JetBrains.ReSharper.Psi.Naming.Elements.NamedElementsBagAttribute(typeof(JetBrains.ReSharper.Psi.Web.WebConfig.WebConfigLanguage))]
    public class WebConfigNamedElements : JetBrains.ReSharper.Psi.Naming.Elements.ElementKindOfElementType
    {
        public static readonly JetBrains.ReSharper.Psi.Naming.Elements.IElementKind ASP_TAG_NAME;
        public static readonly JetBrains.ReSharper.Psi.Naming.Elements.IElementKind ASP_TAG_PREFIX;
        protected WebConfigNamedElements([JetBrains.Annotations.NotNullAttribute()] string name, string presentableName, System.Func<JetBrains.ReSharper.Psi.IDeclaredElement, bool> isApplicable, JetBrains.ReSharper.Psi.Naming.Settings.NamingRule namingRule) { }
        public override JetBrains.ReSharper.Psi.PsiLanguageType Language { get; }
        public override JetBrains.ReSharper.Psi.Naming.Settings.NamingRule GetDefaultRule() { }
    }
    public class WebConfigNamingPolicyProviders : JetBrains.ReSharper.Psi.Web.Naming.WebPolicyProvider
    {
        public WebConfigNamingPolicyProviders(JetBrains.ReSharper.Psi.PsiLanguageType language, JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, JetBrains.Application.Settings.IContextBoundSettingsStore settingsStore) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.Web.WebConfig.WebConfigLanguage))]
    public class WebConfigNamingPolicyProvidersFactory : JetBrains.ReSharper.Psi.Naming.Interfaces.INamingPolicyProviderFactory
    {
        public WebConfigNamingPolicyProvidersFactory(JetBrains.ReSharper.Psi.PsiLanguageType language) { }
        public JetBrains.ReSharper.Psi.Naming.Interfaces.INamingPolicyProvider CreatePolicyProvider(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, JetBrains.Application.Settings.IContextBoundSettingsStore settingsStore) { }
    }
}
namespace JetBrains.ReSharper.Psi.Web.WebConfig.Tree
{
    
    public class static ConfigurationTagEx
    {
        public static System.Collections.Generic.IEnumerable<JetBrains.Util.Pair<JetBrains.ReSharper.Psi.Web.WebConfig.Tree.ISystemWebTag, JetBrains.Util.FileSystemPath>> GetAllSystemWebTags(this JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IConfigurationTag configurationTag) { }
        public static JetBrains.Util.FileSystemPath GetDefaultSystemWebPath(this JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IConfigurationTag configurationTag) { }
        public static System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Web.WebConfig.Tree.ISystemWebTag> GetTopLevelSystemWebTags(this JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IConfigurationTag configurationTag) { }
    }
    public enum DefinitionType
    {
        Everywhere = 0,
        MachineOnly = 1,
        MachineToApplication = 2,
    }
    public interface IAddAssemblyTag : JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IAssemblyTag, JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IWebConfigTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagContainer, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        [JetBrains.Annotations.NotNullAttribute()]
        string Assembly { get; }
    }
    public interface IAddBuildProviderTag : JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IBuildProviderTag, JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IWebConfigTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagContainer, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        [JetBrains.Annotations.NotNullAttribute()]
        string Assembly { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        string Extension { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        string Type { get; }
    }
    public interface IAddCodeSubDirectoryTag : JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IWebConfigTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagContainer, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        [JetBrains.Annotations.NotNullAttribute()]
        string DirectoryName { get; }
    }
    public interface IAddExpressionBuilderTag : JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IExpressionBuilderTag, JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IWebConfigTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagContainer, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        [JetBrains.Annotations.NotNullAttribute()]
        string ExpressionPrefix { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        string Type { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IWebConfigTypeAttribute TypeAttribute { get; }
    }
    public interface IAddHttpHandlerTag : JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IHttpHandlerTag, JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IWebConfigTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagContainer, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        string FullTypeName { get; }
        string Path { get; }
    }
    public interface IAddNamespaceTag : JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.WebConfig.Tree.INamespaceActionTag, JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IWebConfigTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagContainer, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        string NamespaceName { get; }
    }
    public interface IAddPropertyTag : JetBrains.ReSharper.Psi.Tree.IDeclaration, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Tree.ITypeMemberDeclaration, JetBrains.ReSharper.Psi.Tree.IXmlDocOwnerTreeNode, JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IProfilePropertyTag, JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IWebConfigTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagContainer, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        string Name { get; }
        string PropertyType { get; }
        JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IWebConfigTypeAttribute PropertyTypeAttribute { get; }
        string Provider { get; }
        bool ReadOnly { get; }
    }
    public interface IAddProviderTag : JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IProfileProviderTag, JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IWebConfigTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagContainer, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        string ConnectionString { get; }
        string Name { get; }
        string Type { get; }
    }
    public interface IAddSectionGroupTag : JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.WebConfig.Tree.ISectionTag, JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IWebConfigTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagContainer, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        [JetBrains.Annotations.NotNullAttribute()]
        string Name { get; }
    }
    public interface IAddSectionTag : JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.WebConfig.Tree.ISectionTag, JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IWebConfigTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagContainer, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        JetBrains.ReSharper.Psi.Web.WebConfig.Tree.DefinitionType AllowDefinition { get; }
        bool AllowLocation { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        string Name { get; }
    }
    public interface IAddTagMappingTag : JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.WebConfig.Tree.ITagMappingActionTag, JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IWebConfigTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagContainer, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        string MappedTagType { get; }
        JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IWebConfigTypeAttribute MappedTagTypeAttribute { get; }
        string TagType { get; }
        JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IWebConfigTypeAttribute TagTypeAttribute { get; }
    }
    public interface IAddTagPrefixTag : JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.TagPrefixes.ITagPrefixHolder, JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IWebConfigTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagContainer, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        [JetBrains.Annotations.NotNullAttribute()]
        string AddTagName { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        string AddTagPrefix { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        new string Assembly { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        string Namespace { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        string Src { get; }
    }
    public interface IAppSettingTag : JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IWebConfigTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagContainer, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.IEnumerable<JetBrains.Util.FileSystemPath> ConfigFilePaths { get; }
    }
    public interface IAssemblyIdentityTag : JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IWebConfigTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagContainer, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        [JetBrains.Annotations.NotNullAttribute()]
        string Culture { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        string Name { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        string PublicKeyToken { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        string Version { get; }
    }
    public interface IAssemblyTag : JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IWebConfigTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagContainer, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode { }
    public interface IBuildProviderTag : JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IWebConfigTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagContainer, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode { }
    public interface IClearAssembliesTag : JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IAssemblyTag, JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IWebConfigTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagContainer, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode { }
    public interface IClearBuildProvidersTag : JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IBuildProviderTag, JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IWebConfigTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagContainer, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode { }
    public interface IClearExpressionBuildersTag : JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IExpressionBuilderTag, JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IWebConfigTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagContainer, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode { }
    public interface IClearHttpHandlerTag : JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IHttpHandlerTag, JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IWebConfigTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagContainer, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode { }
    public interface IClearNamespacesTag : JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.WebConfig.Tree.INamespaceActionTag, JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IWebConfigTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagContainer, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode { }
    public interface IClearPropertiesTag : JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IProfilePropertyTag, JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IWebConfigTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagContainer, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode { }
    public interface IClearProvidersTag : JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IProfileProviderTag, JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IWebConfigTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagContainer, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode { }
    public interface IClearSectionsTag : JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.WebConfig.Tree.ISectionTag, JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IWebConfigTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagContainer, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode { }
    public interface IClearTagMappingsTag : JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.WebConfig.Tree.ITagMappingActionTag, JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IWebConfigTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagContainer, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode { }
    public interface ICodeBaseTag : JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IWebConfigTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagContainer, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        [JetBrains.Annotations.NotNullAttribute()]
        string HRef { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        string Version { get; }
    }
    public interface ICompilationTag : JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IWebConfigTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagContainer, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IAssemblyTag> Assemblies { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IBuildProviderTag> BuildProviders { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IAddCodeSubDirectoryTag> CodeSubDirectories { get; }
        bool Debug { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        string DefaultLanguage { get; }
        bool Explicit { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IExpressionBuilderTag> ExpressionBuilders { get; }
        bool Strict { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        System.Version TargetFramework { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttribute TargetFrameworkAttribute { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttribute TargetFrameworkMonikerAttribute { get; }
    }
    public interface ICompilerTag : JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IWebConfigTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagContainer, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        [JetBrains.Annotations.NotNullAttribute()]
        string CompilerLanguage { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        string Extension { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        string Options { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        string Type { get; }
        int WarningLevel { get; }
    }
    public interface IConfigSectionsTag : JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IWebConfigTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagContainer, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Web.WebConfig.Tree.ISectionTag> Sections { get; }
    }
    public interface IConfigSourceAttribute : JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IXmlPathAttribute, JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttribute, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IWebConfigTag GetResolvedTag();
    }
    public interface IConfigurationTag : JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.WebConfig.Tree.ILocalableTag, JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IWebConfigTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagContainer, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Web.WebConfig.Tree.ILinkedConfigurationTag> AssemblyBindings { get; }
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Web.WebConfig.Tree.ICompilerTag> Compilers { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IConfigSectionsTag ConfigSections { get; }
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IHttpHandlerTag> HttpHandlers { get; }
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Web.WebConfig.Tree.ILocationTag> Locations { get; }
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IRuntimeAssemblyBindingTag> RuntimeAssemblyBindings { get; }
    }
    public interface IDependentAssemblyTag : JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IWebConfigTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagContainer, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IAssemblyIdentityTag AssemblyIdentity { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Web.WebConfig.Tree.ICodeBaseTag CodeBase { get; }
    }
    public interface IExpressionBuilderTag : JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IWebConfigTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagContainer, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode { }
    public interface IGroupNameAttribute : JetBrains.ReSharper.Psi.Tree.IDeclaration, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Tree.ITypeMemberDeclaration, JetBrains.ReSharper.Psi.Tree.IXmlDocOwnerTreeNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttribute, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode { }
    public interface IGroupPropertyTag : JetBrains.ReSharper.Psi.ExtensionsAPI.Caches2.ICachedDeclaration2, JetBrains.ReSharper.Psi.Tree.IDeclaration, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Tree.ITypeDeclaration, JetBrains.ReSharper.Psi.Tree.ITypeDeclarationHolder, JetBrains.ReSharper.Psi.Tree.IXmlDocOwnerTreeNode, JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IProfilePropertyTag, JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IWebConfigTag, JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IWebConfigTypeDeclaration, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagContainer, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        string Name { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IGroupNameAttribute NameAttribute { get; }
    }
    public interface IHttpHandlerTag : JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IWebConfigTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagContainer, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode { }
    public interface ILinkedConfigurationTag : JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IWebConfigTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagContainer, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        JetBrains.Util.FileSystemPath LinkedConfigPath { get; }
    }
    public interface ILocalableTag : JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IWebConfigTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagContainer, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IRazorTag RazorConfig { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Web.WebConfig.Tree.ISystemWebTag SystemWeb { get; }
    }
    public interface ILocationPathAttribute : JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IXmlPathAttribute, JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttribute, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode { }
    public interface ILocationTag : JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.WebConfig.Tree.ILocalableTag, JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IWebConfigTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagContainer, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        bool AllowOverride { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttribute AllowOverrideAttribute { get; }
        bool InheritInChildApplications { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttribute InheritInChildApplicationsAttribute { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        string Path { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Web.WebConfig.Tree.ILocationPathAttribute PathAttribute { get; }
    }
    public interface INamespaceActionTag : JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IWebConfigTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagContainer, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode { }
    public interface INamespacesTag : JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IWebConfigTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagContainer, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Web.WebConfig.Tree.INamespaceActionTag> Actions { get; }
        bool AutoImportVBNamespace { get; }
    }
    public interface IPagesTag : JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IWebConfigTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagContainer, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        bool AutoEventWireup { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttribute AutoEventWireupAttribute { get; }
        string MasterPageFile { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttribute MasterPageFileAttribute { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Web.WebConfig.Tree.INamespacesTag Namespaces { get; }
        string PageBaseType { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IWebConfigTypeAttribute PageBaseTypeAttribute { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IWebConfigTypeAttribute PageParserFilterTypeAttribute { get; }
        string StyleSheetTheme { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttribute StyleSheetThemeAttribute { get; }
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Web.WebConfig.Tree.ITagMappingActionTag> TagMappings { get; }
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IAddTagPrefixTag> TagPrefixes { get; }
        string Theme { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttribute ThemeAttribute { get; }
        string UserControlBaseType { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IWebConfigTypeAttribute UserControlBaseTypeAttribute { get; }
    }
    public interface IProfilePropertyTag : JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IWebConfigTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagContainer, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode { }
    public interface IProfileProviderTag : JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IWebConfigTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagContainer, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode { }
    public interface IProfileTag : JetBrains.ReSharper.Psi.ExtensionsAPI.Caches2.ICachedDeclaration2, JetBrains.ReSharper.Psi.Tree.IDeclaration, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Tree.ITypeDeclaration, JetBrains.ReSharper.Psi.Tree.ITypeDeclarationHolder, JetBrains.ReSharper.Psi.Tree.IXmlDocOwnerTreeNode, JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IWebConfigTag, JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IWebConfigTypeDeclaration, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagContainer, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        string DefaultProvider { get; }
        bool Enabled { get; }
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IGroupPropertyTag> Groups { get; }
        string Inherits { get; }
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IProfileProviderTag> Providers { get; }
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IGroupPropertyTag> GetGroups(string groupTypeName);
    }
    public interface IQualifyAssemblyTag : JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IWebConfigTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagContainer, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        string FullName { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttribute FullNameAttribute { get; }
        string PartialName { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttribute PartialNameAttribute { get; }
    }
    public interface IRazorPagesTag : JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagContainer, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Web.WebConfig.Tree.INamespacesTag Namespaces { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        string PageBaseType { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IWebConfigTypeAttribute PageBaseTypeAttribute { get; }
    }
    public interface IRazorTag : JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IWebConfigTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagContainer, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IRazorPagesTag PagesConfig { get; }
    }
    public interface IRemoveAssemblyTag : JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IAssemblyTag, JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IWebConfigTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagContainer, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        [JetBrains.Annotations.NotNullAttribute()]
        string Assembly { get; }
    }
    public interface IRemoveBuildProviderTag : JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IBuildProviderTag, JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IWebConfigTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagContainer, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        [JetBrains.Annotations.NotNullAttribute()]
        string Extension { get; }
    }
    public interface IRemoveExpressionBuilderTag : JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IExpressionBuilderTag, JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IWebConfigTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagContainer, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        string ExpressionPrefix { get; }
    }
    public interface IRemoveHttpHandlerTag : JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IHttpHandlerTag, JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IWebConfigTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagContainer, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        string Path { get; }
    }
    public interface IRemoveNamespaceTag : JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.WebConfig.Tree.INamespaceActionTag, JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IWebConfigTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagContainer, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        string NamespaceName { get; }
    }
    public interface IRemovePropertyTag : JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IProfilePropertyTag, JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IWebConfigTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagContainer, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        string Name { get; }
    }
    public interface IRemoveProviderTag : JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IProfileProviderTag, JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IWebConfigTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagContainer, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        string Name { get; }
    }
    public interface IRemoveSectionTag : JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.WebConfig.Tree.ISectionTag, JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IWebConfigTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagContainer, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        [JetBrains.Annotations.NotNullAttribute()]
        string Name { get; }
    }
    public interface IRemoveTagMappingTag : JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.WebConfig.Tree.ITagMappingActionTag, JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IWebConfigTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagContainer, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        string TagType { get; }
    }
    public interface IRuntimeAssemblyBindingTag : JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IWebConfigTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagContainer, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        bool ApplyPublisherPolicy { get; }
        System.Collections.Generic.IDictionary<string, string> AssemblyQualificationMap { get; }
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IDependentAssemblyTag> DependentAssemblies { get; }
        System.Collections.Generic.IEnumerable<JetBrains.Util.FileSystemPath> ProbingDirectories { get; }
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IQualifyAssemblyTag> QualifyAssemblies { get; }
    }
    public interface ISectionTag : JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IWebConfigTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagContainer, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode { }
    public interface ISystemWebTag : JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IWebConfigTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagContainer, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IAppSettingTag AppSetting { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Web.WebConfig.Tree.ICompilationTag Compilation { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IPagesTag PagesConfig { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IProfileTag Profile { get; }
    }
    public interface ITagMappingActionTag : JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IWebConfigTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagContainer, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode { }
    public interface IWebConfigFile : JetBrains.ReSharper.Psi.Tree.IFile, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlDocumentNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlFile, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagContainer, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IConfigurationTag Configuration { get; }
    }
    public interface IWebConfigTag : JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagContainer, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        T GetNestedTag<T>(string xpath)
            where T :  class, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag;
    }
    public interface IWebConfigTagNameAttribute : JetBrains.ReSharper.Psi.Tree.IDeclaration, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Tree.IXmlDocOwnerTreeNode, JetBrains.ReSharper.Psi.Web.TagPrefixes.ITagNameDeclaration, JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttribute, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        string TagName { get; }
    }
    public interface IWebConfigTagPrefixAttribute : JetBrains.ReSharper.Psi.Tree.IDeclaration, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Tree.IXmlDocOwnerTreeNode, JetBrains.ReSharper.Psi.Web.TagPrefixes.ITagPrefixDeclaration, JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttribute, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        string TagPrefix { get; }
    }
    public interface IWebConfigTypeAttribute : JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttribute, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        bool ModuleQualificationRequired { get; }
    }
    public interface IWebConfigTypeDeclaration : JetBrains.ReSharper.Psi.ExtensionsAPI.Caches2.ICachedDeclaration2, JetBrains.ReSharper.Psi.Tree.IDeclaration, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Tree.ITypeDeclaration, JetBrains.ReSharper.Psi.Tree.ITypeDeclarationHolder, JetBrains.ReSharper.Psi.Tree.IXmlDocOwnerTreeNode
    {
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IProfilePropertyTag> Properties { get; }
    }
    public interface IXmlPathAttribute : JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttribute, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        bool IsRelative { get; }
    }
    public class static LocationTagExtensions
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.Util.FileSystemPath ResolvePath(this JetBrains.ReSharper.Psi.Web.WebConfig.Tree.ILocationTag locationTag) { }
    }
}
namespace JetBrains.ReSharper.Psi.Web.WebConfig.Util
{
    
    public class ArrayDimensionInfo
    {
        public readonly int DimensionCount;
        public readonly JetBrains.ReSharper.Psi.TreeTextRange Range;
        public ArrayDimensionInfo(JetBrains.ReSharper.Psi.TreeTextRange range, int dimensionCount) { }
    }
    public class static AspFilesUtil
    {
        public static string GetModuleQualification(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.Modules.IPsiModule psiModule) { }
    }
    public class static AspNamespaceReferenceUtil
    {
        public static JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetSymbolTable(JetBrains.ReSharper.Psi.Web.Impl.WebConfig.Tree.References.IWebNamespaceReference namespaceReference, JetBrains.ReSharper.Psi.Resolve.SymbolTableMode mode, bool caseSensitive) { }
        public class AspNamespaceReferenceQualifier : JetBrains.ReSharper.Psi.Resolve.IQualifier
        {
            public AspNamespaceReferenceQualifier(JetBrains.ReSharper.Psi.Tree.ITreeNode element, bool isCaseSensitive) { }
            public bool Resolved { get; }
            public JetBrains.ReSharper.Psi.Resolve.QualifierKind GetKind() { }
            public JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetSymbolTable(JetBrains.ReSharper.Psi.Resolve.SymbolTableMode mode) { }
        }
    }
    public class ComplexTypeParser
    {
        public const char APOS = '`';
        public const char COMMA = ',';
        public readonly System.Collections.Generic.List<JetBrains.ReSharper.Psi.Web.WebConfig.Util.ErrorInfo> Errors;
        public const char LBRACKET = '[';
        public const char MODULE_DELIM = ',';
        public const char NAMESPACE_DELIM = '.';
        public const char QMARK = '?';
        public const char RBRACKET = ']';
        public readonly string Text;
        public const char TYPE_DELIM = '+';
        public const char UNKNOWN = '\0';
        public ComplexTypeParser(string text, JetBrains.ReSharper.Psi.TreeTextRange range, char typeArgumentsLBracket, char typeArgumentsRBracket, char nullableChar, string typeArgumentsLBracketSuffix, bool nestedTypeInBracketsAllowed, bool typeArgumentsCountRequired) { }
        public static JetBrains.ReSharper.Psi.Web.WebConfig.Util.ComplexTypeParser CreateCsParser(string text, JetBrains.ReSharper.Psi.TreeTextRange range) { }
        public static JetBrains.ReSharper.Psi.Web.WebConfig.Util.ComplexTypeParser CreateParser(string text, JetBrains.ReSharper.Psi.TreeTextRange range) { }
        public static JetBrains.ReSharper.Psi.Web.WebConfig.Util.ComplexTypeParser CreateVbParser(string text, JetBrains.ReSharper.Psi.TreeTextRange range) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ReSharper.Psi.Web.WebConfig.Util.ParsedTypeInfo Parse() { }
    }
    public class static ComplexTypeUtil
    {
        public static JetBrains.ReSharper.Psi.Tree.ReferenceCollection CreateReferences([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode owner, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode tokenNode, string expectedBaseType, bool lateBound, JetBrains.ReSharper.Psi.Web.Impl.WebConfig.Tree.References.IWebTypeReferenceCreator creator) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Psi.Web.Impl.WebConfig.Tree.References.IWebTypeReference FindTypeReference([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode owner, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode tokenElement) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Psi.Web.Impl.WebConfig.Tree.References.IWebTypeReference FindTypeReference([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode owner, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Web.WebConfig.Util.ParsedTypeInfo typeInfo) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.ReSharper.Psi.IType GetType(JetBrains.ReSharper.Psi.TypeKeywordsManager typeKeywordsManager, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode owner, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode tokenElement) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.ReSharper.Psi.IType GetType(JetBrains.ReSharper.Psi.TypeKeywordsManager typeKeywordsManager, JetBrains.ReSharper.Psi.Tree.ITreeNode owner, JetBrains.ReSharper.Psi.Web.WebConfig.Util.ParsedTypeInfo typeInfo) { }
    }
    public class static ConfigSourceAttributeUtil
    {
        public static JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IWebConfigTag CreateReferencedWebConfigTag(JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IConfigSourceAttribute attribute, JetBrains.ProjectModel.IProject project, JetBrains.Util.FileSystemPath webConfigPath, JetBrains.DocumentManagers.DocumentManager documentManager) { }
        public static bool GetUnusedTagsAndAttributes(JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IConfigSourceAttribute configSourceAttribute, out System.Collections.Generic.List<> attributes, out System.Collections.Generic.List<> tags) { }
    }
    public class ErrorInfo
    {
        public readonly string Message;
        public readonly JetBrains.ReSharper.Psi.TreeTextRange Range;
        public ErrorInfo(JetBrains.ReSharper.Psi.TreeTextRange range, string message) { }
    }
    public class static OpenRastaUtil
    {
        public const string PageParserFilterType = "OpenRasta.Codecs.WebForms.OpenRastaPageParserFilter";
        public static string[] SpecialViewTypes;
        public const string SpecialViewTypesNamespace = "OpenRasta.Codecs.WebForms";
        public static bool IsOpenRastaSpecial(string text, JetBrains.ReSharper.Psi.TreeTextRange treeTextRange, bool caseSensitive) { }
    }
    public class ParsedTypeInfo
    {
        public readonly System.Collections.Generic.List<JetBrains.ReSharper.Psi.Web.WebConfig.Util.ArrayDimensionInfo> ArrayDimensions;
        public readonly System.Collections.Generic.List<char> Delimiters;
        public JetBrains.ReSharper.Psi.TreeTextRange ModuleQualificationRange;
        public readonly System.Collections.Generic.List<JetBrains.ReSharper.Psi.Web.WebConfig.Util.ParsedTypePart> Parts;
        public readonly string Text;
        public ParsedTypeInfo(string text, bool isCLR) { }
        public JetBrains.ReSharper.Psi.TreeOffset EndOffset { get; }
        public bool IsCLR { get; }
        public JetBrains.ReSharper.Psi.TreeOffset StartOffset { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Psi.Web.WebConfig.Util.ParsedTypePart FindTypePart(JetBrains.ReSharper.Psi.TreeTextRange identifierRange) { }
        public bool IsSimple() { }
        public string ToStringCLR(bool dumpNull) { }
        public string ToStringCS(bool dumpNull) { }
        public string ToStringVB(bool dumpNull) { }
    }
    public class ParsedTypePart
    {
        public JetBrains.ReSharper.Psi.TreeOffset EndOffset;
        public readonly JetBrains.ReSharper.Psi.TreeTextRange IdentifierRange;
        public bool IsNullable;
        public readonly string Text;
        public JetBrains.ReSharper.Psi.TreeTextRange TypeArgumentCountRange;
        public readonly System.Collections.Generic.List<JetBrains.ReSharper.Psi.Web.WebConfig.Util.ParsedTypeInfo> TypeArguments;
        public JetBrains.ReSharper.Psi.TreeTextRange TypeArgumentsWithBracketsRange;
        public ParsedTypePart(string text, JetBrains.ReSharper.Psi.TreeTextRange identifierRange) { }
        public string GetIdentifierText() { }
        public bool IsSimple() { }
    }
    public class static ReferenceToTypeUtil
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.ReSharper.Psi.Web.WebConfig.Util.ParsedTypeInfo GetOrCreateParsedTypeInfo([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode ownerElement, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode tokenElement, System.Func<JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.TreeTextRange> calcRangeWithinDelegate, System.Func<string, JetBrains.ReSharper.Psi.TreeTextRange, JetBrains.ReSharper.Psi.Web.WebConfig.Util.ComplexTypeParser> createParserDelegate) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Psi.Web.WebConfig.Util.ParsedTypeInfo GetOrFixExistingParsedTypeInfo([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode ownerElement, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode tokenElement) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Web.WebConfig.Util.ErrorInfo> GetParserErrors(JetBrains.ReSharper.Psi.Tree.ITreeNode ownerElement) { }
    }
    public class static SectionsUtil
    {
        public static bool IsInCustomSection([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Tree.ITreeNode node) { }
        public static bool IsInCustomSection([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IWebConfigTag tag) { }
    }
    public class TaggedCollection<TItemType>
    
    {
        public TaggedCollection() { }
        public TaggedCollection(System.Collections.Generic.IEqualityComparer<string> comparer) { }
        public TaggedCollection(JetBrains.ReSharper.Psi.Web.WebConfig.Util.TaggedCollection<TItemType> collection) { }
        public System.Collections.Generic.IList<TItemType> OrderedItems { get; }
        public void AddActions<T>(JetBrains.ReSharper.Psi.Web.WebConfig.Util.TaggedCollectionActionSequence<T, TItemType> actionSequence) { }
        public void AddActions<T>(System.Collections.Generic.IEnumerable<T> actions, System.Converter<T, JetBrains.ReSharper.Psi.Web.WebConfig.Util.TaggedCollectionAction> actionConverter, System.Converter<T, TItemType> itemConverter) { }
        public void AddCollection(JetBrains.ReSharper.Psi.Web.WebConfig.Util.TaggedCollection<TItemType> collection) { }
        public virtual void AddItem(string tag, TItemType item) { }
        public virtual void AddItemFirst(string tag, TItemType item) { }
        public virtual void Clear() { }
        public System.Collections.Generic.IList<TItemType> GetItems(string tag) { }
        public virtual void RemoveItems(string tag) { }
    }
    public struct TaggedCollectionAction
    {
        public static JetBrains.ReSharper.Psi.Web.WebConfig.Util.TaggedCollectionAction Clear;
        public static JetBrains.ReSharper.Psi.Web.WebConfig.Util.TaggedCollectionAction Invalid;
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly string Tag;
        public readonly JetBrains.ReSharper.Psi.Web.WebConfig.Util.TaggedCollectionAction.ActionType Type;
        public static JetBrains.ReSharper.Psi.Web.WebConfig.Util.TaggedCollectionAction Add([JetBrains.Annotations.CanBeNullAttribute()] string tag) { }
        public static JetBrains.ReSharper.Psi.Web.WebConfig.Util.TaggedCollectionAction Remove([JetBrains.Annotations.CanBeNullAttribute()] string tag) { }
        public enum ActionType
        {
            ADD = 0,
            REMOVE = 1,
            CLEAR = 2,
            INVALID = 3,
        }
    }
    public class TaggedCollectionActionSequence<TTag, TValue>
    
    
    {
        public TaggedCollectionActionSequence() { }
        public System.Collections.Generic.IEnumerable<JetBrains.Util.Pair<JetBrains.ReSharper.Psi.Web.WebConfig.Util.TaggedCollectionAction, TValue>> Actions { get; }
        public void Add(string tag, TValue value) { }
        public void AddActions(JetBrains.ReSharper.Psi.Web.WebConfig.Util.TaggedCollectionActionSequence<TTag, TValue> actionSequence) { }
        public void AddActions(System.Collections.Generic.IEnumerable<TTag> tags, System.Converter<TTag, JetBrains.ReSharper.Psi.Web.WebConfig.Util.TaggedCollectionAction> actionConverter, System.Converter<TTag, TValue> valueConverter) { }
        public void Clear() { }
        public void FillMap(JetBrains.Util.OneToSetMap<string, TValue> map) { }
        public void Remove(string tag) { }
        public JetBrains.ReSharper.Psi.Web.WebConfig.Util.TaggedCollection<TValue> ToCollection(System.Collections.Generic.IEqualityComparer<string> comparer = null) { }
    }
    public class static TagPrefixUtil
    {
        public static System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Web.TagPrefixes.ITagPrefixHolder> GetHoldersInFile(JetBrains.ReSharper.Psi.Tree.IFile file, JetBrains.Util.FileSystemPath targetPath) { }
        public static System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Web.TagPrefixes.ITagPrefixHolder> GetRelevantHolders(JetBrains.ReSharper.Psi.Tree.IFile file) { }
        public static System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Web.TagPrefixes.ITagPrefixHolder> GetRelevantHoldersBeforeFile(JetBrains.ReSharper.Psi.Tree.IFile file, JetBrains.Util.FileSystemPath targetPath) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Psi.Web.TagPrefixes.ITagPrefixSupport GetTagPrefixSupport(JetBrains.ReSharper.Psi.Tree.IFile file) { }
    }
    public class static WebConfigTypeAttributeUtil
    {
        public static JetBrains.ReSharper.Psi.Tree.ReferenceCollection CreateReferences([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IWebConfigTypeAttribute owner, string expectedBaseType, bool lateBound, JetBrains.ReSharper.Psi.Web.Impl.WebConfig.Tree.References.IWebTypeReferenceCreator creator) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Psi.Web.WebConfig.Util.ParsedTypeInfo GetParsedTypeInfo([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IWebConfigTypeAttribute attribute) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Psi.IType GetType([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.TypeKeywordsManager typeKeywordsManager, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IWebConfigTypeAttribute attribute) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Psi.Xml.Tree.IXmlValueToken GetValueToken([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Web.WebConfig.Tree.IWebConfigTypeAttribute attribute) { }
    }
    public class static WebModuleQuaificationReferenceUtil
    {
        public static JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetModuleReferenceSymbolTable(this JetBrains.ReSharper.Psi.Web.Impl.WebConfig.Tree.References.IWebModuleQualificationReference reference, bool useReferenceName) { }
        public static JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetQualifierSymbolTable(this JetBrains.ReSharper.Psi.Web.Impl.WebConfig.Tree.References.IWebModuleQualificationReference moduleQualificationReference, JetBrains.ReSharper.Psi.Resolve.SymbolTableMode mode) { }
        public static JetBrains.ReSharper.Psi.Resolve.ResolveErrorType ResolveModule(this JetBrains.ReSharper.Psi.Web.Impl.WebConfig.Tree.References.IWebModuleQualificationReference reference, JetBrains.ProjectModel.IModule module, JetBrains.Metadata.Utils.AssemblyNameInfo expectedAssemblyName) { }
        public static JetBrains.ReSharper.Psi.Modules.IPsiModule ResolveModule(this JetBrains.ReSharper.Psi.Web.Impl.WebConfig.Tree.References.IWebModuleQualificationReference reference, out JetBrains.ReSharper.Psi.Resolve.ResolveErrorType errorType, out string errorTooltip) { }
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.ResolveResultWithInfo ResolveModuleWithoutCache(this JetBrains.ReSharper.Psi.Web.Impl.WebConfig.Tree.References.IWebModuleQualificationReference reference) { }
    }
    public class static WebTypeReferenceUtil
    {
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.ResolveResultWithInfo CheckResolveResultWithModule(this JetBrains.ReSharper.Psi.Web.Impl.WebConfig.Tree.References.IWebTypeReference typeReference, JetBrains.ReSharper.Psi.Tree.ITreeNode token, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.ResolveResultWithInfo resolveInfo) { }
        public static JetBrains.ReSharper.Psi.Web.Impl.WebConfig.Tree.References.IWebModuleQualificationReference FindModuleQualificationReference(this JetBrains.ReSharper.Psi.Web.Impl.WebConfig.Tree.References.IWebTypeReference typeReference, JetBrains.ReSharper.Psi.Tree.ITreeNode tokenElement) { }
        public static System.Collections.Generic.List<JetBrains.ReSharper.Psi.Resolve.ISymbolFilter> GetFilters(JetBrains.ReSharper.Psi.Web.Impl.WebConfig.Tree.References.IWebTypeReference typeReference, JetBrains.ReSharper.Psi.Tree.ITreeNode tokenElement, JetBrains.ReSharper.Psi.PsiLanguageType language) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static string GetTypeNameByKeyword(JetBrains.ReSharper.Psi.Web.Impl.WebConfig.Tree.References.IWebTypeReference typeReference) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Psi.Web.WebConfig.Util.ParsedTypePart GetTypePart(this JetBrains.ReSharper.Psi.Web.Impl.WebConfig.Tree.References.IWebTypeReference typeReference, ref JetBrains.ReSharper.Psi.Web.WebConfig.Util.ParsedTypeInfo typeInfo) { }
        public class AspExplicitSubstitutionProviderFilter : JetBrains.ReSharper.Psi.Resolve.ISymbolFilter
        {
            public AspExplicitSubstitutionProviderFilter(System.Collections.Generic.IList<JetBrains.ReSharper.Psi.IType> typeParameterValues) { }
            public JetBrains.ReSharper.Psi.Resolve.ResolveErrorType ErrorType { get; }
            public JetBrains.ReSharper.Psi.Resolve.FilterRunType RunType { get; }
            public System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Resolve.ISymbolInfo> FilterArray(System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Resolve.ISymbolInfo> data) { }
        }
        public class DicstinctFilter : JetBrains.ReSharper.Psi.Resolve.ISymbolFilter
        {
            public static readonly JetBrains.ReSharper.Psi.Web.WebConfig.Util.WebTypeReferenceUtil.DicstinctFilter Instance;
            public JetBrains.ReSharper.Psi.Resolve.ResolveErrorType ErrorType { get; }
            public JetBrains.ReSharper.Psi.Resolve.FilterRunType RunType { get; }
            public System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Resolve.ISymbolInfo> FilterArray(System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Resolve.ISymbolInfo> data) { }
        }
        public class TypeParametersCountFilter : JetBrains.ReSharper.Psi.Resolve.SimpleSymbolFilter
        {
            public TypeParametersCountFilter(int typeParametersCount) { }
            public override JetBrains.ReSharper.Psi.Resolve.ResolveErrorType ErrorType { get; }
            public override JetBrains.ReSharper.Psi.Resolve.FilterRunType RunType { get; }
            public override bool Accepts(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution) { }
        }
    }
}