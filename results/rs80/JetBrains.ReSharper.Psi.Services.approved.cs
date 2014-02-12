[assembly: JetBrains.UI.Icons.CompiledIcons.CompiledIconsPackAttribute(IconNames=new string[] {
        "DfaFrom",
        "DfaTo",
        "DfaCollection",
        "DfaLambda"}, IconPackResourceIdentification="JetBrains.ReSharper.Psi.Services;component/resources/DfaThemedIcons/ThemedIcons.D" +
    "fa.Generated.Xaml")]
[assembly: JetBrains.UI.Icons.CompiledIcons.CompiledIconsPackAttribute(IconNames=new string[] {
        "OverridesAndImplements",
        "Overrides",
        "Implements",
        "Hides",
        "HidesAndImplements",
        "HasImplementations",
        "QuasiImplements",
        "HasOverrides",
        "Empty"}, IconPackResourceIdentification="JetBrains.ReSharper.Psi.Services;component/resources/PsiServicesIcons/ThemedIcons" +
    ".PsiServices.Generated.Xaml")]
[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]
[assembly: System.Windows.Markup.XmlnsDefinitionAttribute("urn:shemas-jetbrains-com:ui-application-icons-dfa", "JetBrains.ReSharper.Psi.Services.Resources")]
[assembly: System.Windows.Markup.XmlnsDefinitionAttribute("urn:shemas-jetbrains-com:ui-application-icons-psi-services", "JetBrains.ReSharper.Psi.Services.Resources")]

namespace JetBrains.ReSharper.Feature.Services.Descriptions
{
    
    public class static DeclaredElementDescriptionPresenterUtil
    {
        public static JetBrains.UI.RichText.RichTextBlock GetDeclaredElementDescription([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IDeclaredElement element, JetBrains.ReSharper.Feature.Services.Descriptions.DeclaredElementDescriptionStyle style = null, JetBrains.ReSharper.Psi.PsiLanguageType language = null, JetBrains.ReSharper.Psi.Modules.IPsiModule module = null) { }
        public static bool IsObsolete(JetBrains.ReSharper.Psi.IDeclaredElement element) { }
        public static bool IsObsolete(JetBrains.ReSharper.Psi.IDeclaredElement element, out JetBrains.UI.RichText.RichTextBlock obsoleteDescription) { }
    }
    public class DeclaredElementDescriptionStyle
    {
        public static readonly JetBrains.ReSharper.Feature.Services.Descriptions.DeclaredElementDescriptionStyle FULL_STYLE;
        public static readonly JetBrains.ReSharper.Feature.Services.Descriptions.DeclaredElementDescriptionStyle NO_OBSOLETE_FULL_STYLE;
        public static readonly JetBrains.ReSharper.Feature.Services.Descriptions.DeclaredElementDescriptionStyle NO_OBSOLETE_SUMMARY_STYLE;
        public static readonly JetBrains.ReSharper.Feature.Services.Descriptions.DeclaredElementDescriptionStyle OBSOLETE_DESCRIPTION;
        public static readonly JetBrains.ReSharper.Feature.Services.Descriptions.DeclaredElementDescriptionStyle PARAMETER_STYLE;
        public static readonly JetBrains.ReSharper.Feature.Services.Descriptions.DeclaredElementDescriptionStyle SUMMARY_STYLE;
        public JetBrains.ReSharper.Feature.Services.Descriptions.DescriptionPlacement IntendedDescriptionPlacement { get; set; }
        public bool ShowFullDescription { get; set; }
        public bool ShowObsoleteDescription { get; set; }
        public bool ShowSummary { get; set; }
    }
    public enum DescriptionPlacement
    {
        ON_THE_NEW_LINE = 0,
        AFTER_NAME = 1,
    }
    public interface IDeclaredElementDescriptionPresenter
    {
        JetBrains.UI.RichText.RichTextBlock GetDeclaredElementDescription([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IDeclaredElement element, JetBrains.ReSharper.Feature.Services.Descriptions.DeclaredElementDescriptionStyle style = null, JetBrains.ReSharper.Psi.PsiLanguageType language = null, JetBrains.ReSharper.Psi.Modules.IPsiModule module = null);
        bool IsDeclaredElementObsolete(JetBrains.ReSharper.Psi.IDeclaredElement element);
        bool IsDeclaredElementObsolete(JetBrains.ReSharper.Psi.IDeclaredElement element, out JetBrains.UI.RichText.RichTextBlock obsoleteDescription, JetBrains.ReSharper.Feature.Services.Descriptions.DeclaredElementDescriptionStyle style = null);
    }
}
namespace JetBrains.ReSharper.Feature.Services.Intentions.DataProviders
{
    
    public interface ICreateNewFileTarget : JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.ICreationTarget, JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.ITargetPostExecute, JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.ITargetPreExecute, JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.ITopLevelScopeTarget
    {
        string FileName { get; }
        JetBrains.ProjectModel.ProjectFileType FileType { get; }
        JetBrains.ReSharper.Psi.Resolve.IReference ReferenceToBind { get; }
        JetBrains.ProjectModel.IProjectFolder TargetFolder { get; }
        JetBrains.ReSharper.Psi.PsiLanguageType TargetLanguage { get; }
        string TargetNamespaceName { get; }
        JetBrains.Util.FileSystemPath TargetPath { get; }
    }
    public interface ICreationTarget
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Tree.ITreeNode Anchor { get; }
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Tree.ITreeNode> GetPossibleTargetDeclarations();
        JetBrains.ReSharper.Psi.Tree.ITreeNode GetTargetDeclaration();
        JetBrains.ReSharper.Psi.Tree.IFile GetTargetDeclarationFile();
    }
    public interface IFileTarget : JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.ICreationTarget, JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.ITopLevelScopeTarget
    {
        JetBrains.ReSharper.Psi.Tree.IFile TargetFile { get; }
    }
    public interface INamespaceByNameTarget : JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.ICreationTarget, JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.ITargetPreExecute, JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.ITopLevelScopeTarget
    {
        JetBrains.ReSharper.Psi.Tree.IFile TargetFile { get; }
        string TargetNamespaceName { get; }
    }
    public interface INamespaceTarget : JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.ICreationTarget, JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.ITargetPreExecute, JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.ITopLevelScopeTarget
    {
        JetBrains.ReSharper.Psi.Tree.IFile TargetFile { get; }
        JetBrains.ReSharper.Psi.INamespace TargetNamespace { get; }
    }
    public interface ITargetPostExecute
    {
        void PostExecute(JetBrains.ReSharper.Psi.IDeclaredElement creationResult);
    }
    public interface ITargetPreExecute
    {
        void PreExecute();
    }
    public interface ITargetSetPart
    {
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Tree.IDeclaration> AvailableTargets { get; }
        void SetPart(JetBrains.ReSharper.Psi.Tree.IDeclaration typePart);
    }
    public interface ITopLevelScopeTarget : JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.ICreationTarget
    {
        JetBrains.ProjectModel.IProject GetTargetProject();
    }
    public interface ITypeDeclarationTarget : JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.ICreationTarget
    {
        JetBrains.ReSharper.Psi.Tree.ITypeDeclaration TargetTypeDeclaration { get; }
    }
    public interface ITypeTarget : JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.ICreationTarget, JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.ITargetSetPart
    {
        JetBrains.ReSharper.Psi.ITypeElement TargetType { get; }
    }
}
namespace JetBrains.ReSharper.Feature.Services.Util
{
    
    public class static FileSpecificUtil
    {
        public static bool CanAnotherClassBePlacedBeside(JetBrains.ReSharper.Psi.ITypeElement typeElement) { }
        public static bool CanContainSeveralClasses(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
        public static bool CanDeclarationBeOverloaded(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration) { }
        public static bool CanHaveConstructors([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.ITypeElement typeElement) { }
        public static bool CanImplementInterfaces(JetBrains.ReSharper.Psi.ITypeElement typeElement) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static string GetDefaultNamespace([JetBrains.Annotations.CanBeNullAttribute()] this JetBrains.ProjectModel.IProject project) { }
        public static JetBrains.DocumentModel.DocumentRange GetExtendedDocumentRange(this JetBrains.ReSharper.Psi.Tree.ITreeNode node) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.ReSharper.Feature.Services.Util.IFileTypeSpecificOwnerUtil GetFileSpecificService([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
        public static JetBrains.Util.FileSystemPath GetFolderForElementsMovedToExternalScope(JetBrains.ProjectModel.IProjectFile projectFile, string @namespace, JetBrains.ReSharper.Psi.Tree.ITreeNode referenceNode = null) { }
        public static System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.IClrTypeName> GetMvcViewWithModelBaseTypes(JetBrains.ProjectModel.IProjectFile file) { }
        public static string GetNamespaceForElementsMovedToExternalScope(JetBrains.ReSharper.Psi.Tree.ITypeDeclaration typeDeclaration, JetBrains.ReSharper.Psi.Tree.ITreeNode referenceNode = null) { }
        public static string GetNamespaceForElementsMovedToExternalScope(JetBrains.ReSharper.Psi.ITypeElement typeElement, JetBrains.ReSharper.Psi.Tree.ITreeNode referenceNode = null) { }
        public static string GetPrettyName(JetBrains.ReSharper.Psi.ITypeElement typeElement, bool mustBeIdentifier) { }
        public static System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Tree.ITypeDeclaration> GetRelatedAndFilterHidden(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Tree.ITypeDeclaration> declarations) { }
        public static System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Tree.ITypeDeclaration> GetVisibleDeclarations(JetBrains.ReSharper.Psi.ITypeElement typeElement) { }
        public static bool HasChangeableDocumentRange(this JetBrains.ReSharper.Psi.ITreeRange range) { }
        public static bool HasChangeableDocumentRange(this JetBrains.ReSharper.Psi.Tree.ITreeNode node) { }
        public static bool HasHiddenDeclarations(JetBrains.ReSharper.Psi.ITypeElement typeElement) { }
        public static bool HasUglyName(JetBrains.ReSharper.Psi.ITypeElement typeElement) { }
        [System.ObsoleteAttribute("Use more specific method from this class or IDeclaration.IsSynthetic")]
        public static bool IsCodeBehindClass([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.ITypeElement typeElement) { }
        public static bool IsHidden([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITypeDeclaration declaration) { }
        public static bool IsUserTextDeclaration([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.IDeclaration declaration) { }
        public static System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.Tree.IDeclaration> SortDeclarationsByWritability(JetBrains.ReSharper.Psi.ITypeElement typeElement, JetBrains.ReSharper.Psi.Tree.IDeclaration prefferedDeclaration, JetBrains.ReSharper.Psi.PsiLanguageType language) { }
        public static System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Tree.IDeclaration> SortDeclarationsByWritability([JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Tree.IDeclaration> declarations, JetBrains.ReSharper.Psi.Tree.IDeclaration prefferedDeclaration, JetBrains.ReSharper.Psi.PsiLanguageType language) { }
        public static bool SuperClassCanBeChanged([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.ITypeElement typeElement) { }
    }
    public interface IFileTypeSpecificOwnerUtil
    {
        bool CanContainSeveralClasses(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile);
        bool CanDeclarationBeOverloaded(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration);
        bool CanHaveConstructors(JetBrains.ReSharper.Psi.Tree.ITypeDeclaration typeElement);
        bool CanImplementInterfaces(JetBrains.ReSharper.Psi.Tree.ITypeDeclaration typeElement);
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.ITypeElement GetContainingTypeForReference([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Resolve.IReference reference);
        JetBrains.DocumentModel.DocumentRange GetDocumentRangeForPartiallyUnmappedNode(JetBrains.ReSharper.Psi.Tree.ITreeNode node);
        JetBrains.Util.FileSystemPath GetFolderForElementsMovedToExternalScope([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IProjectFile projectFile, [JetBrains.Annotations.NotNullAttribute()] string @namespace, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode referenceNode);
        System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.IClrTypeName> GetMvcViewWithModelBaseTypes();
        string GetNamespaceForElementsMovedToExternalScope([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITypeDeclaration typeElement, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode referenceNode);
        string GetPrettyName(JetBrains.ReSharper.Psi.Tree.ITypeDeclaration element, bool mustBeIdentifier);
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Tree.ITypeDeclaration> GetRelatedAndFilterHidden([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITypeDeclaration declaration);
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Tree.IDeclaration> GetRelatedDeclarations(JetBrains.ReSharper.Psi.Tree.ITypeDeclaration typeDeclaration);
        bool HasUglyName(JetBrains.ReSharper.Psi.Tree.ITypeDeclaration declaration);
        [System.ObsoleteAttribute("Use more specific method from this interface or IDeclaration.IsSynthetic")]
        bool IsCodeBehindClass([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITypeDeclaration declaration);
        bool IsHidden([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITypeDeclaration declaration);
        bool IsOperationPossibleOnUnmappedRange(JetBrains.ReSharper.Psi.Tree.ITreeNode node);
        bool IsOperationPossibleOnUnmappedRange(JetBrains.ReSharper.Psi.ITreeRange range);
        bool IsUserTextDeclaration([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.IDeclaration declaration);
        bool SuperClassCanBeChanged(JetBrains.ReSharper.Psi.Tree.ITypeDeclaration typeElement);
        bool SuperClassNameMustBeFull(JetBrains.ReSharper.Psi.Tree.ITypeDeclaration typeElement);
    }
    public interface IPrefferedReference : JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.Util.IUserDataHolder { }
    [JetBrains.ProjectModel.SolutionComponentAttribute(JetBrains.Application.Components.ProgramConfigurations.NONE | JetBrains.Application.Components.ProgramConfigurations.STANDALONE | JetBrains.Application.Components.ProgramConfigurations.VS_ADDIN | JetBrains.Application.Components.ProgramConfigurations.ALL)]
    public class ProjectFileCacheCleanup
    {
        public ProjectFileCacheCleanup(JetBrains.ProjectModel.Tasks.ISolutionLoadTasksScheduler scheduler, JetBrains.ReSharper.Psi.IPsiServices psiServices, JetBrains.ProjectModel.ISolution solution, JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.IShellLocks locks) { }
    }
}
namespace JetBrains.ReSharper.Psi.Services
{
    
    public class CachingFinder
    {
        public CachingFinder([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IPsiServices psiServices) { }
        public System.Collections.Generic.List<JetBrains.ReSharper.Psi.Search.FindResultOverridableMember> FindImmediateImplementingMembers([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IOverridableMember overridableMember, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Progress.IProgressIndicator pi) { }
        public System.Collections.Generic.List<JetBrains.ReSharper.Psi.Search.FindResultOverridableMember> FindImplementingMembers([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IOverridableMember overridableMember, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Progress.IProgressIndicator pi) { }
        public System.Collections.Generic.IList<JetBrains.Util.JetTuple<JetBrains.ReSharper.Psi.IDeclaredElement, JetBrains.ReSharper.Psi.Resolve.IReference>> FindReferences<T>(System.Collections.Generic.ICollection<T> elements, JetBrains.ReSharper.Psi.Search.ISearchDomain domain, JetBrains.Application.Progress.IProgressIndicator pi)
            where T : JetBrains.ReSharper.Psi.IDeclaredElement { }
        public System.Collections.Generic.List<JetBrains.Util.JetTuple<JetBrains.ReSharper.Psi.IDeclaredElement, JetBrains.ReSharper.Psi.Resolve.IReference>> FindUsages([JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.IDeclaredElement> elements, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Progress.IProgressIndicator pi) { }
    }
    public abstract class CachingLexerService : JetBrains.Application.IChangeProvider
    {
        protected CachingLexerService(JetBrains.DocumentManagers.DocumentManager documentManager, JetBrains.ReSharper.Psi.Modules.IPsiModules psiModules) { }
        public abstract object Execute(JetBrains.Application.IChangeMap changeMap);
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Psi.Parsing.CachingLexer GetCachingLexer([JetBrains.Annotations.NotNullAttribute()] JetBrains.TextControl.ITextControl textControl) { }
        public abstract JetBrains.ReSharper.Psi.Parsing.CachingLexer GetCachingLexer([JetBrains.Annotations.NotNullAttribute()] JetBrains.TextControl.ITextControl textControl, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile);
        public abstract JetBrains.ReSharper.Psi.Parsing.CachingLexer GetCachingLexer([JetBrains.Annotations.NotNullAttribute()] JetBrains.TextControl.ITextControl textControl, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.ProjectFileType projectFileType);
        [System.ObsoleteAttribute("Inject CachingLexerService")]
        public static JetBrains.ReSharper.Psi.Services.CachingLexerService GetInstance(JetBrains.ProjectModel.ISolution solution) { }
    }
    public class static CandidatesUtil
    {
        public static System.Collections.Generic.IList<JetBrains.ReSharper.Psi.DeclaredElementInstance> GetCandidateInstances(JetBrains.ReSharper.Psi.Services.ReferencePreferenceKind kind, params JetBrains.ReSharper.Psi.Resolve.IReference[] references) { }
        public static System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.IDeclaredElement> GetCandidates(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.Services.ReferencePreferenceKind kind) { }
        public static void GetCurrentReferenceLocation(JetBrains.Application.DataContext.IDataContext context, out JetBrains.ProjectModel.IProjectFile projectFile, out JetBrains.Util.TextRange textRange) { }
        public static JetBrains.ReSharper.Psi.Resolve.IReference[] SelectGoodReferences(System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.Resolve.IReference> references) { }
        public delegate void DeclaredElementExecutor(JetBrains.Application.DataContext.IDataContext context, JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, JetBrains.ReSharper.Psi.IDeclaredElement initialTarget = null);
        public delegate void MultiplyDeclaredElementExecutor(JetBrains.Application.DataContext.IDataContext context, System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.IDeclaredElement> declaredElements, System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.IDeclaredElement> initialTargers);
    }
    public class CLRTypeAnchorSerializer : JetBrains.ReSharper.Psi.Services.ITypeAnchorSerializer
    {
        public JetBrains.ReSharper.Psi.Services.TypeAnchor Deserialize(string sFullyQualifiedName) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public string Serialize(JetBrains.ReSharper.Psi.Services.TypeAnchor typeAnchor, JetBrains.ReSharper.Psi.Caches.ISymbolScope cache) { }
    }
    public class DeclaredElementInstancePointerMap<TElementType, TValue> : JetBrains.ReSharper.Psi.Services.IDeclaredElementInstanceToDataMap<TElementType, TValue>
        where TElementType :  class, JetBrains.ReSharper.Psi.IDeclaredElement
    
    {
        public DeclaredElementInstancePointerMap() { }
        public TValue this[JetBrains.ReSharper.Psi.DeclaredElementInstance<TElementType> element] { get; set; }
        public void Add(JetBrains.ReSharper.Psi.DeclaredElementInstance<TElementType> element, TValue value) { }
        public bool Contains(JetBrains.ReSharper.Psi.DeclaredElementInstance<TElementType> key) { }
        public void Rehash() { }
        public bool TryGetValue(JetBrains.ReSharper.Psi.DeclaredElementInstance<TElementType> key, out TValue value) { }
    }
    public class static DefaultValueUtil
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Psi.Tree.IExpression GetDefaultValue([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IType type, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.PsiLanguageType language, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Modules.IPsiModule module) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Psi.Tree.IExpression GetOptionalParameterDefaultValue([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IType type, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.PsiLanguageType language, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Modules.IPsiModule module) { }
        public interface IDefaultValueCreation
        {
            JetBrains.ReSharper.Psi.Tree.IExpression CreateArrayConstructorCall(JetBrains.ReSharper.Psi.IType arrayType, JetBrains.ReSharper.Psi.Modules.IPsiModule module);
            JetBrains.ReSharper.Psi.Tree.IExpression CreateConstantValue(JetBrains.ReSharper.Psi.ConstantValue value, JetBrains.ReSharper.Psi.Modules.IPsiModule module);
            JetBrains.ReSharper.Psi.Tree.IExpression CreateDefaultConstructorCall(JetBrains.ReSharper.Psi.IType valueType, JetBrains.ReSharper.Psi.Modules.IPsiModule module);
            JetBrains.ReSharper.Psi.Tree.IExpression CreateNull(JetBrains.ReSharper.Psi.Modules.IPsiModule module);
            JetBrains.ReSharper.Psi.Tree.IExpression CreateTypeDefaultExpression(JetBrains.ReSharper.Psi.IType type, JetBrains.ReSharper.Psi.Modules.IPsiModule module);
        }
    }
    public class ElementEnvoyMap<TValue> : JetBrains.ReSharper.Psi.Services.IDeclaredElementToDataMap<TValue>, System.Collections.IEnumerable
    
    {
        public ElementEnvoyMap() { }
        public TValue this[JetBrains.ReSharper.Psi.IDeclaredElement element] { get; set; }
        public System.Collections.IEnumerable Keys { get; }
        public System.Collections.Generic.IEnumerable<TValue> Values { get; }
        public void Add(JetBrains.ReSharper.Psi.IDeclaredElement element, TValue value) { }
        public void Clear() { }
        public bool Contains(JetBrains.ReSharper.Psi.IDeclaredElement key) { }
        public System.Collections.IEnumerator GetEnumerator() { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Psi.IDeclaredElementEnvoy GetKeyEnvoy(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
        public bool IsEmpty() { }
        public void Rehash() { }
        public bool TryGetValue(JetBrains.ReSharper.Psi.IDeclaredElement key, out TValue value) { }
    }
    public class ElementPointerMap<TValue> : JetBrains.ReSharper.Psi.Services.IDeclaredElementToDataMap<TValue>
    
    {
        public ElementPointerMap() { }
        public TValue this[JetBrains.ReSharper.Psi.IDeclaredElement element] { get; set; }
        public void Add(JetBrains.ReSharper.Psi.IDeclaredElement element, TValue value) { }
        public bool Contains(JetBrains.ReSharper.Psi.IDeclaredElement key) { }
        public void Rehash() { }
        public bool TryGetValue(JetBrains.ReSharper.Psi.IDeclaredElement key, out TValue value) { }
    }
    public interface IAnonymousObjectsAnalyser
    {
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.IEnumerable<JetBrains.Util.Pair<string, JetBrains.ReSharper.Psi.Resolve.Managed.IManagedExpression>> GetMemberInitializers([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode element);
        bool IsCreationExpression([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode element);
    }
    public interface ICustomCachingLexerService
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Parsing.CachingLexer CreateCachingLexer([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.ISolution solution, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.ProjectFileType projectFileType, [JetBrains.Annotations.NotNullAttribute()] JetBrains.TextControl.ITextControl textControl, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.PsiProjectFileTypeCoordinator projectFileTypeCoordinator, JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile = null);
        void Drop([JetBrains.Annotations.NotNullAttribute()] JetBrains.TextControl.ITextControl textControl);
        JetBrains.ReSharper.Psi.Parsing.CachingLexer Resync([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Psi.Parsing.DocumentUpdatesAccumulator updatesAccumulator, JetBrains.ProjectModel.ProjectFileType projectFileType, JetBrains.TextControl.ITextControl textControl, JetBrains.ReSharper.Psi.PsiProjectFileTypeCoordinator projectFileTypeCoordinator, JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile = null);
    }
    public interface IDaemonSuspender
    {
        System.IDisposable Suspend();
    }
    public interface IDeclaredElementInstanceToDataMap<TElementType, TValue>
        where TElementType :  class, JetBrains.ReSharper.Psi.IDeclaredElement
    
    {
        TValue this[JetBrains.ReSharper.Psi.DeclaredElementInstance<TElementType> element] { get; set; }
        void Add(JetBrains.ReSharper.Psi.DeclaredElementInstance<TElementType> element, TValue value);
        bool Contains(JetBrains.ReSharper.Psi.DeclaredElementInstance<TElementType> key);
        void Rehash();
        bool TryGetValue(JetBrains.ReSharper.Psi.DeclaredElementInstance<TElementType> key, out TValue value);
    }
    public interface IDeclaredElementToDataMap<TValue>
    
    {
        TValue this[JetBrains.ReSharper.Psi.IDeclaredElement element] { get; set; }
        void Add(JetBrains.ReSharper.Psi.IDeclaredElement element, TValue value);
        bool Contains(JetBrains.ReSharper.Psi.IDeclaredElement key);
        void Rehash();
        bool TryGetValue(JetBrains.ReSharper.Psi.IDeclaredElement key, out TValue value);
    }
    public interface ILanguageReferenceSelector
    {
        JetBrains.ReSharper.Psi.IConstructor GetBaseConstructor(JetBrains.ReSharper.Psi.IConstructor constructor);
        [JetBrains.Annotations.CanBeNullAttribute()]
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.DeclaredElementInstance> GetCandidates([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.Services.ReferencePreferenceKind preferenceKind);
    }
    public class InheritanceInformation
    {
        public System.Collections.Generic.IList<JetBrains.ReSharper.Psi.TypeMemberInstance> HiddenMembers;
        public System.Collections.Generic.IList<JetBrains.ReSharper.Psi.OverridableMemberInstance> ImplementedMembers;
        public System.Collections.Generic.IList<JetBrains.ReSharper.Psi.OverridableMemberInstance> OverridenMembers;
        public string ToolTip;
        public InheritanceInformation() { }
        public JetBrains.UI.Icons.IconId Image { get; }
        public static JetBrains.ReSharper.Psi.Services.InheritanceInformation FromDeclaredElement(JetBrains.ReSharper.Psi.IDeclaredElement element) { }
        public static JetBrains.ReSharper.Psi.Services.InheritanceInformation FromDeclaredElement(JetBrains.ReSharper.Psi.IDeclaredElement element, JetBrains.ReSharper.Psi.PsiLanguageType languageType) { }
    }
    public interface IReparseContext
    {
        JetBrains.ReSharper.Psi.Services.ReparseResult GetReparseResult(string newText);
    }
    public interface ITextControlPsi
    {
        bool IgnoreDeclarationInBinding([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Tree.IDeclaration declaration);
    }
    public interface ITypeAnchorSerializer
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Services.TypeAnchor Deserialize([JetBrains.Annotations.NotNullAttribute()] string sFullyQualifiedName);
        string Serialize(JetBrains.ReSharper.Psi.Services.TypeAnchor typeAnchor);
    }
    public interface ITypeMemberDeclarationService
    {
        JetBrains.ReSharper.Psi.Tree.IDeclaration FindDeclarationByOffset(JetBrains.DocumentModel.DocumentRange documentRange, JetBrains.ReSharper.Psi.Tree.IFile file);
    }
    public abstract class LiteralService
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.ReSharper.Psi.Services.LiteralService Get([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.ReSharper.Psi.Services.LiteralService Get([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.PsiLanguageType language) { }
        public abstract JetBrains.ReSharper.Psi.TreeTextRange GetValueTextRange([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode element);
        public virtual JetBrains.ReSharper.Psi.TreeTextRange GetValueWithinRange([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public abstract bool IsConstantLiteral([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode element);
        public virtual bool IsStringLiteral([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public virtual bool IsVerbatimStringLiteral(JetBrains.ReSharper.Psi.Tree.ILiteralExpression expression) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public virtual string ParseStringLiteral([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ILiteralExpression literal, out JetBrains.Util.RangeTranslator translator) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public abstract string ParseStringLiteral([JetBrains.Annotations.NotNullAttribute()] string literalText, out JetBrains.Util.RangeTranslator translator);
    }
    public class MixedCachingLexerService : JetBrains.ReSharper.Psi.Services.UniversalCachingLexerService
    {
        public override JetBrains.ReSharper.Psi.Parsing.CachingLexer CreateCachingLexer(JetBrains.ProjectModel.ISolution solution, JetBrains.ProjectModel.ProjectFileType projectFileType, JetBrains.TextControl.ITextControl textControl, JetBrains.ReSharper.Psi.PsiProjectFileTypeCoordinator projectFileTypeCoordinator, JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile = null) { }
        public override void Drop(JetBrains.TextControl.ITextControl textControl) { }
        public override JetBrains.ReSharper.Psi.Parsing.CachingLexer Resync(JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Psi.Parsing.DocumentUpdatesAccumulator updatesAccumulator, JetBrains.ProjectModel.ProjectFileType projectFileType, JetBrains.TextControl.ITextControl textControl, JetBrains.ReSharper.Psi.PsiProjectFileTypeCoordinator projectFileTypeCoordinator, JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile = null) { }
    }
    public enum ReferencePreferenceKind
    {
        Default = 0,
        ToDeclaration = 1,
        ToUsage = 2,
        ToBase = 3,
        ToInheritors = 4,
        ToType = 5,
    }
    public class static ReferencesCollectingUtil
    {
        public static System.Collections.Generic.IList<T> CollectElementsWithReference<T>(JetBrains.ReSharper.Psi.Tree.ITreeNode scopeElement, string referenceName, System.Converter<T, JetBrains.ReSharper.Psi.Resolve.IReference> convert, System.Predicate<JetBrains.ReSharper.Psi.Resolve.IReference> condition)
            where T : JetBrains.ReSharper.Psi.Tree.ITreeNode { }
        public static System.Collections.Generic.IList<T> CollectElementsWithResolveErrorReference<T>(JetBrains.ReSharper.Psi.Tree.ITreeNode scopeElement, string referenceName, System.Converter<T, JetBrains.ReSharper.Psi.Resolve.IReference> convert, JetBrains.ReSharper.Psi.IDeclaredElement resolvedTo)
            where T : JetBrains.ReSharper.Psi.Tree.ITreeNode { }
        public static System.Collections.Generic.IList<T> CollectElementsWithUnresolvedReference<T>(JetBrains.ReSharper.Psi.Tree.ITreeNode scopeElement, string referenceName, System.Converter<T, JetBrains.ReSharper.Psi.Resolve.IReference> convert)
            where T : JetBrains.ReSharper.Psi.Tree.ITreeNode { }
    }
    public abstract class ReparseContext
    {
        protected JetBrains.ReSharper.Psi.Services.ReparseContext.ContextType myContextType;
        protected JetBrains.ReSharper.Psi.Services.ReparseContext.ReparseContextLexer myLexer;
        protected JetBrains.ReSharper.Psi.Modules.IPsiModule myPsiModule;
        protected string myText;
        public int OriginalTextLength { get; }
        public string Text { get; }
        public JetBrains.ReSharper.Psi.Services.ReparseContext.ContextType Type { get; }
        public int WholeTextLength { get; }
        protected static string GetTextBetween([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode child1, JetBrains.ReSharper.Psi.Tree.ITreeNode child2) { }
        public static string GetTextInsideParentTillChild([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode parent, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode child) { }
        protected static bool HasErrorElement(JetBrains.ReSharper.Psi.Tree.ITreeNode root) { }
        public enum ContextType
        {
            DocCommentBlock = 0,
            ExtendsList = 1,
            Statement = 2,
            TypeParametersConstraints = 3,
            TypeMember = 4,
            Namespace = 5,
            File = 6,
        }
        protected class ReparseContextLexer : JetBrains.ReSharper.Psi.Parsing.ILexer, JetBrains.ReSharper.Psi.Parsing.ILexer<int>
        {
            public ReparseContextLexer(JetBrains.ReSharper.Psi.LanguageService service, string text) { }
            public JetBrains.Text.IBuffer Buffer { get; }
            public int CurrentPosition { get; set; }
            public int OriginalTextLength { get; }
            public int TokenEnd { get; }
            public int TokenStart { get; }
            public JetBrains.ReSharper.Psi.Parsing.TokenNodeType TokenType { get; }
            public void Advance() { }
            public void AppendText(string text) { }
            public void Start() { }
        }
    }
    public abstract class ReparseContextBase : JetBrains.ReSharper.Psi.Services.IReparseContext
    {
        protected ReparseContextBase(JetBrains.ReSharper.Psi.Tree.ITreeNode origin, string contextHead, string contextTail) { }
        public string ContextHead { get; }
        public string ContextTail { get; }
        protected JetBrains.ReSharper.Psi.Modules.IPsiModule Module { get; set; }
        protected JetBrains.ReSharper.Psi.Tree.ITreeNode Origin { get; set; }
        protected static void FillNodeDecl(JetBrains.ReSharper.Psi.Tree.ITreeNode node, JetBrains.ReSharper.Psi.Tree.ITreeNode body, JetBrains.ReSharper.Psi.TreeTextRange selRange, ref System.Text.StringBuilder sbCur, System.Text.StringBuilder sbTail) { }
        public abstract JetBrains.ReSharper.Psi.Services.ReparseResult GetReparseResult(string newText);
        protected static JetBrains.ReSharper.Psi.Tree.ITreeNode SkipErrorNodes(JetBrains.ReSharper.Psi.Tree.ITreeNode origin) { }
        protected static void SplitNode(JetBrains.ReSharper.Psi.Tree.ITreeNode node, JetBrains.ReSharper.Psi.TreeTextRange range, out string contextHead, out string contextTail) { }
    }
    public abstract class ReparseContextShortBase
    {
        protected JetBrains.ReSharper.Psi.Services.ReparseContextShortBase.ReparseContextLexer myLexer;
        protected JetBrains.ReSharper.Psi.Modules.IPsiModule myPsiModule;
        protected string myText;
        public int OriginalTextLength { get; }
        public string Text { get; }
        public int WholeTextLength { get; }
        protected static string GetTextBetween([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode child1, JetBrains.ReSharper.Psi.Tree.ITreeNode child2) { }
        protected static bool HasErrorElement(JetBrains.ReSharper.Psi.Tree.ITreeNode root) { }
        protected class ReparseContextLexer : JetBrains.ReSharper.Psi.Parsing.ILexer
        {
            public ReparseContextLexer(JetBrains.ReSharper.Psi.LanguageService service, string text) { }
            public JetBrains.Text.IBuffer Buffer { get; }
            public object CurrentPosition { get; set; }
            public int OriginalTextLength { get; }
            public int TokenEnd { get; }
            public int TokenStart { get; }
            public JetBrains.ReSharper.Psi.Parsing.TokenNodeType TokenType { get; }
            public void Advance() { }
            public void AppendText(string text) { }
            public void Start() { }
        }
    }
    public class ReparseResult
    {
        public ReparseResult(JetBrains.ReSharper.Psi.Tree.ITreeNode newNode, JetBrains.ReSharper.Psi.Tree.ITreeNode originalNode, int startOffsetInNewNode) { }
        public JetBrains.ReSharper.Psi.Tree.ITreeNode NewNode { get; }
        public JetBrains.ReSharper.Psi.Tree.ITreeNode OriginalNode { get; }
        public int StartOffsetInNewNode { get; }
    }
    public class static TextControlToPsi
    {
        [System.ObsoleteAttribute("Do not use. Specify language")]
        public static void BindToPsi(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, JetBrains.Util.TextRange textRange, out JetBrains.ReSharper.Psi.DeclaredElementEnvoy<> boundTypeMember, out JetBrains.ReSharper.Psi.DeclaredElementEnvoy<> boundTypeElement, out JetBrains.ReSharper.Psi.DeclaredElementEnvoy<> boundNamespace) { }
        public static void BindToPsi(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, JetBrains.ReSharper.Psi.PsiLanguageType language, JetBrains.Util.TextRange textRange, out JetBrains.ReSharper.Psi.DeclaredElementEnvoy<> boundTypeMember, out JetBrains.ReSharper.Psi.DeclaredElementEnvoy<> boundTypeElement, out JetBrains.ReSharper.Psi.DeclaredElementEnvoy<> boundNamespace) { }
        public static JetBrains.ReSharper.Psi.IDeclaredElement GetContainingTypeOrTypeMember([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.ISolution solution, [JetBrains.Annotations.NotNullAttribute()] JetBrains.TextControl.ITextControl textControl) { }
        public static JetBrains.ReSharper.Psi.IDeclaredElement GetContainingTypeOrTypeMember([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.ISolution solution, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DocumentModel.IDocument document, int offset) { }
        public static JetBrains.ReSharper.Psi.Tree.IDeclaration GetDeclaration(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        public static JetBrains.ReSharper.Psi.Tree.IDeclaration GetDeclaration(JetBrains.ProjectModel.ISolution solution, JetBrains.DocumentModel.IDocument document, int offset) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [System.ObsoleteAttribute("Use TextControlToPsi.GetDeclaredElements")]
        public static JetBrains.ReSharper.Psi.IDeclaredElement GetDeclaredElement(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        public static System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.IDeclaredElement> GetDeclaredElements(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        public static System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.IDeclaredElement> GetDeclaredElements(JetBrains.ProjectModel.ISolution solution, JetBrains.DocumentModel.IDocument document, int offset, out bool isPossiblyNonNullInThisDocument) { }
        public static T GetElement<T>(JetBrains.ProjectModel.ISolution solution, [JetBrains.Annotations.NotNullAttribute()] JetBrains.TextControl.ITextControl textControl)
            where T :  class, JetBrains.ReSharper.Psi.Tree.ITreeNode { }
        public static T GetElement<T>(JetBrains.ProjectModel.ISolution solution, JetBrains.DocumentModel.IDocument document, int offset)
            where T :  class, JetBrains.ReSharper.Psi.Tree.ITreeNode { }
        public static T GetElement<T>([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.ISolution solution, [JetBrains.Annotations.NotNullAttribute()] JetBrains.TextControl.ITextControl textControl, out JetBrains.ReSharper.Psi.Tree.ITreeNode anchor)
            where T :  class, JetBrains.ReSharper.Psi.Tree.ITreeNode { }
        public static T GetElementFromCaretPosition<T>(JetBrains.ProjectModel.ISolution solution, [JetBrains.Annotations.NotNullAttribute()] JetBrains.TextControl.ITextControl textControl)
            where T :  class, JetBrains.ReSharper.Psi.Tree.ITreeNode { }
        public static T GetElementPointedByUser<T>(JetBrains.ProjectModel.ISolution solution, [JetBrains.Annotations.NotNullAttribute()] JetBrains.TextControl.ITextControl textControl)
            where T :  class, JetBrains.ReSharper.Psi.Tree.ITreeNode { }
        public static System.Collections.Generic.IEnumerable<T> GetElements<T>(JetBrains.ProjectModel.ISolution solution, JetBrains.DocumentModel.IDocument document, int offset)
            where T :  class, JetBrains.ReSharper.Psi.Tree.ITreeNode { }
        public static System.Collections.Generic.IEnumerable<T> GetElements<T>(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl)
            where T :  class, JetBrains.ReSharper.Psi.Tree.ITreeNode { }
        [System.ObsoleteAttribute("ask serjic why")]
        public static JetBrains.ReSharper.Psi.PsiLanguageType GetLanguageType(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        [JetBrains.Annotations.NotNullAttribute()]
        [System.ObsoleteAttribute("ask serjic why")]
        public static JetBrains.ReSharper.Psi.PsiLanguageType GetLanguageType(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl, int offset) { }
        public static System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Tree.IFile> GetPsiFilesFromDocument([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.ISolution solution, JetBrains.DocumentModel.DocumentRange range) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Psi.Resolve.IReference[] GetReferencesAtCaret(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Psi.Resolve.IReference[] GetReferencesAtOffset(JetBrains.ProjectModel.ISolution solution, JetBrains.DocumentModel.IDocument document, int offset) { }
        public static System.Collections.Generic.IEnumerable<T> GetSelectedElements<T>(JetBrains.ProjectModel.ISolution solution, JetBrains.DocumentModel.IDocument document, JetBrains.Util.TextRange textRange)
            where T :  class, JetBrains.ReSharper.Psi.Tree.ITreeNode { }
        public static JetBrains.ReSharper.Psi.Tree.ITreeNode GetSourceTokenAtCaret(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        public static JetBrains.ReSharper.Psi.Tree.ITreeNode GetSourceTokenAtOffset([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.ISolution solution, [JetBrains.Annotations.NotNullAttribute()] JetBrains.TextControl.ITextControl textControl, int offset) { }
        public static JetBrains.ReSharper.Psi.Tree.ITreeNode GetSourceTokenAtOffset([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.ISolution solution, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DocumentModel.IDocument document, int offset) { }
        public static JetBrains.ReSharper.Psi.Tree.ITreeNode GetSourceTokenBeforeCaret([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.ISolution solution, [JetBrains.Annotations.NotNullAttribute()] JetBrains.TextControl.ITextControl textControl) { }
    }
    public class TrivialReparseContext : JetBrains.ReSharper.Psi.Services.IReparseContext
    {
        public TrivialReparseContext(JetBrains.ReSharper.Psi.Tree.IFile file, JetBrains.ReSharper.Psi.TreeTextRange range) { }
        public JetBrains.ReSharper.Psi.Services.ReparseResult GetReparseResult(string newText) { }
    }
    public class TypeAnchor
    {
        public TypeAnchor(string name, string[] typeArgs, JetBrains.ReSharper.Psi.Services.TypeAnchor next) { }
        public string Name { get; }
        public JetBrains.ReSharper.Psi.Services.TypeAnchor Next { get; }
        public string[] TypeArgs { get; }
        public static JetBrains.ReSharper.Psi.Services.TypeAnchor Create(JetBrains.ReSharper.Psi.ITypeElement typeElement) { }
    }
    public class static TypeAnchorSerializationUtil
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Psi.Services.TypeAnchor Deserialize(string s) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static string Serialize([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Services.TypeAnchor anchor, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.PsiLanguageType languageType) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static string Serialize([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.ITypeElement typeElement) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.KnownLanguage))]
    public class UniversalCachingLexerService : JetBrains.ReSharper.Psi.Services.ICustomCachingLexerService
    {
        public virtual JetBrains.ReSharper.Psi.Parsing.CachingLexer CreateCachingLexer(JetBrains.ProjectModel.ISolution solution, JetBrains.ProjectModel.ProjectFileType projectFileType, JetBrains.TextControl.ITextControl textControl, JetBrains.ReSharper.Psi.PsiProjectFileTypeCoordinator projectFileTypeCoordinator, JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile = null) { }
        protected static JetBrains.ReSharper.Psi.Parsing.CachingLexer CreateTokenBufferFromLexer(JetBrains.TextControl.ITextControl textControl, JetBrains.ReSharper.Psi.Parsing.ILexer lexer) { }
        public virtual void Drop(JetBrains.TextControl.ITextControl textControl) { }
        protected static JetBrains.ReSharper.Psi.Parsing.TokenBuffer GetTokenBuffer(JetBrains.TextControl.ITextControl textControl) { }
        public virtual JetBrains.ReSharper.Psi.Parsing.CachingLexer Resync(JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Psi.Parsing.DocumentUpdatesAccumulator updatesAccumulator, JetBrains.ProjectModel.ProjectFileType projectFileType, JetBrains.TextControl.ITextControl textControl, JetBrains.ReSharper.Psi.PsiProjectFileTypeCoordinator projectFileTypeCoordinator, JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile = null) { }
        protected static JetBrains.ReSharper.Psi.Parsing.CachingLexer Resync(JetBrains.TextControl.ITextControl textControl, System.Func<JetBrains.ReSharper.Psi.Parsing.TokenBuffer> action) { }
    }
}
namespace JetBrains.ReSharper.Psi.Services.CodeInsight
{
    
    public interface ILocalSymbolsServiceProvider
    {
        JetBrains.ReSharper.Psi.IType GetThisType(JetBrains.ReSharper.Psi.Tree.ITreeNode element);
        JetBrains.ReSharper.Psi.Services.CodeInsight.VariablesList GetVisibleVariables(JetBrains.ReSharper.Psi.Tree.IFile file, JetBrains.ReSharper.Psi.TreeOffset offset);
    }
    public abstract class LocalSymbolsServiceProviderBase<TBlock, TStatement> : JetBrains.ReSharper.Psi.Services.CodeInsight.ILocalSymbolsServiceProvider
        where TBlock :  class, JetBrains.ReSharper.Psi.Tree.ITreeNode
        where TStatement :  class, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        protected virtual JetBrains.ReSharper.Psi.Resolve.ISymbolTable FilterVisibleVariables(JetBrains.ReSharper.Psi.Resolve.ISymbolTable table, JetBrains.ReSharper.Psi.Resolve.IAccessContext context, JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        protected virtual System.Collections.Generic.List<JetBrains.ReSharper.Psi.Services.CodeInsight.VariablesList.TypedAndNamedEntity> GetAdditionalEntries(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public JetBrains.ReSharper.Psi.IType GetThisType(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public JetBrains.ReSharper.Psi.Services.CodeInsight.VariablesList GetVisibleVariables(JetBrains.ReSharper.Psi.Tree.IFile file, JetBrains.ReSharper.Psi.TreeOffset offset) { }
        protected virtual bool IsVariable(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, JetBrains.ReSharper.Psi.PsiLanguageType language) { }
    }
    public class PsiCodeInsightUtil
    {
        public static int CompareVariables(JetBrains.ReSharper.Psi.IDeclaredElement x, JetBrains.ReSharper.Psi.IDeclaredElement y) { }
    }
    public class VariablesList
    {
        public static readonly JetBrains.ReSharper.Psi.Services.CodeInsight.VariablesList Empty;
        public VariablesList(System.Collections.Generic.List<JetBrains.ReSharper.Psi.DeclaredElementInstance<JetBrains.ReSharper.Psi.ITypeOwner>> variables, System.Collections.Generic.List<JetBrains.ReSharper.Psi.Services.CodeInsight.VariablesList.TypedAndNamedEntity> additionalEntries) { }
        public System.Collections.Generic.List<JetBrains.ReSharper.Psi.Services.CodeInsight.VariablesList.TypedAndNamedEntity> AdditionalEntries { get; }
        public System.Collections.Generic.List<JetBrains.ReSharper.Psi.DeclaredElementInstance<JetBrains.ReSharper.Psi.ITypeOwner>> Variables { get; }
        public bool Contains(string name) { }
        public class TypedAndNamedEntity
        {
            public TypedAndNamedEntity(JetBrains.ReSharper.Psi.IType type, string name) { }
            public string Name { get; }
            public JetBrains.ReSharper.Psi.IType Type { get; }
        }
    }
}
namespace JetBrains.ReSharper.Psi.Services.ExpressionSelection
{
    
    public class ExpressionSelectionProviderBase<TExpression> : JetBrains.ReSharper.Psi.Services.ExpressionSelection.IExpressionSelectionProvider
        where TExpression :  class, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        public TExpressionRequired GetExpression<TExpressionRequired>(JetBrains.ReSharper.Psi.Tree.IFile file, JetBrains.DocumentModel.DocumentRange range, bool exactRange, System.Predicate<TExpressionRequired> predicate)
            where TExpressionRequired :  class, JetBrains.ReSharper.Psi.Tree.ITreeNode { }
        public TExpressionRequired GetExpressionInRange<TExpressionRequired>(JetBrains.ReSharper.Psi.Tree.IFile file, JetBrains.DocumentModel.DocumentRange range, bool exactRange, System.Predicate<TExpressionRequired> predicate)
            where TExpressionRequired :  class, JetBrains.ReSharper.Psi.Tree.ITreeNode { }
        protected virtual bool IsTokenSkipped(JetBrains.ReSharper.Psi.Tree.ITokenNode token) { }
    }
    public class static ExpressionSelectionUtil
    {
        public static TExpressionRequired GetExpressionInRange<TExpressionRequired>([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.IFile file, JetBrains.DocumentModel.DocumentRange range, bool exactRange, [JetBrains.Annotations.CanBeNullAttribute()] System.Predicate<TExpressionRequired> predicate)
            where TExpressionRequired :  class, JetBrains.ReSharper.Psi.Tree.ITreeNode { }
        public static TExpression GetSelectedExpression<TExpression>([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.ISolution solution, [JetBrains.Annotations.NotNullAttribute()] JetBrains.TextControl.ITextControl textControl, bool exactRange)
            where TExpression :  class, JetBrains.ReSharper.Psi.Tree.ITreeNode { }
        public static TExpression GetSelectedExpression<TExpression>([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.ISolution solution, [JetBrains.Annotations.NotNullAttribute()] JetBrains.TextControl.ITextControl textControl, bool exactRange, [JetBrains.Annotations.CanBeNullAttribute()] System.Predicate<TExpression> predicate)
            where TExpression :  class, JetBrains.ReSharper.Psi.Tree.ITreeNode { }
    }
    public interface IExpressionSelectionProvider
    {
        TExpressionRequired GetExpression<TExpressionRequired>([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.IFile file, JetBrains.DocumentModel.DocumentRange range, bool exactRange, [JetBrains.Annotations.CanBeNullAttribute()] System.Predicate<TExpressionRequired> predicate)
            where TExpressionRequired :  class, JetBrains.ReSharper.Psi.Tree.ITreeNode;
        TExpressionRequired GetExpressionInRange<TExpressionRequired>([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.IFile file, JetBrains.DocumentModel.DocumentRange range, bool exactRange, [JetBrains.Annotations.CanBeNullAttribute()] System.Predicate<TExpressionRequired> predicate)
            where TExpressionRequired :  class, JetBrains.ReSharper.Psi.Tree.ITreeNode;
    }
}
namespace JetBrains.ReSharper.Psi.Services.Presentation
{
    
    public class static ExpressionPresentationBuilder
    {
        public static JetBrains.ReSharper.Psi.Services.Presentation.IPresentableExpression BuildPresentableExpression(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.KnownLanguage))]
    public class ExpressionPresenterLanguageService
    {
        public virtual bool CanReduce(JetBrains.ReSharper.Psi.Tree.ITreeNode node) { }
        public virtual bool IsGrouppingNode(JetBrains.ReSharper.Psi.Tree.ITreeNode node) { }
    }
    public interface IExpressionPresentationProvider<TPresentationObject>
    
    {
        int PlaceholderLength { get; }
        int PresentationMaxLength { get; }
        TPresentationObject AppendPlaceholder(TPresentationObject presentation);
        TPresentationObject AppentLeafNode(TPresentationObject presentation, [JetBrains.Annotations.NotNullAttribute()] string text);
        TPresentationObject GetInitialObject();
        int MesureText([JetBrains.Annotations.NotNullAttribute()] string text);
    }
    public interface IPresentableExpression
    {
        TPresentation GetPresentation<TPresentation>(JetBrains.ReSharper.Psi.Services.Presentation.IExpressionPresentationProvider<TPresentation> presentationProvider);
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class PsiSourceFilePresentationService
    {
        public PsiSourceFilePresentationService([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.PsiProjectFileTypeCoordinator coordinator) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.UI.Icons.IconId GetIconId([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
    }
    public class RichTextPresentationProvider : JetBrains.ReSharper.Psi.Services.Presentation.IExpressionPresentationProvider<JetBrains.UI.RichText.RichText>
    {
        public RichTextPresentationProvider([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Services.ValueTracking.Presentation.IExpressionPresentationStyle style) { }
        public int PlaceholderLength { get; }
        public int PresentationMaxLength { get; }
        public JetBrains.UI.RichText.RichText AppendPlaceholder(JetBrains.UI.RichText.RichText presentation) { }
        public JetBrains.UI.RichText.RichText AppentLeafNode(JetBrains.UI.RichText.RichText presentation, string text) { }
        public JetBrains.UI.RichText.RichText GetInitialObject() { }
        public int MesureText(string text) { }
    }
}
namespace JetBrains.ReSharper.Psi.Services.Resources
{
    
    public sealed class DfaThemedIcons
    {
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Psi.Services;component/resources/DfaThemedIcons/ThemedIcons.D" +
            "fa.Generated.Xaml", 2, "DfaCollection")]
        public sealed class DfaCollection : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Psi.Services;component/resources/DfaThemedIcons/ThemedIcons.D" +
            "fa.Generated.Xaml", 0, "DfaFrom")]
        public sealed class DfaFrom : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Psi.Services;component/resources/DfaThemedIcons/ThemedIcons.D" +
            "fa.Generated.Xaml", 3, "DfaLambda")]
        public sealed class DfaLambda : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Psi.Services;component/resources/DfaThemedIcons/ThemedIcons.D" +
            "fa.Generated.Xaml", 1, "DfaTo")]
        public sealed class DfaTo : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
    }
    public sealed class PsiServicesThemedIcons
    {
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Psi.Services;component/resources/PsiServicesIcons/ThemedIcons" +
            ".PsiServices.Generated.Xaml", 8, "Empty")]
        public sealed class Empty : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Psi.Services;component/resources/PsiServicesIcons/ThemedIcons" +
            ".PsiServices.Generated.Xaml", 5, "HasImplementations")]
        public sealed class HasImplementations : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Psi.Services;component/resources/PsiServicesIcons/ThemedIcons" +
            ".PsiServices.Generated.Xaml", 7, "HasOverrides")]
        public sealed class HasOverrides : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Psi.Services;component/resources/PsiServicesIcons/ThemedIcons" +
            ".PsiServices.Generated.Xaml", 3, "Hides")]
        public sealed class Hides : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Psi.Services;component/resources/PsiServicesIcons/ThemedIcons" +
            ".PsiServices.Generated.Xaml", 4, "HidesAndImplements")]
        public sealed class HidesAndImplements : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Psi.Services;component/resources/PsiServicesIcons/ThemedIcons" +
            ".PsiServices.Generated.Xaml", 2, "Implements")]
        public sealed class Implements : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Psi.Services;component/resources/PsiServicesIcons/ThemedIcons" +
            ".PsiServices.Generated.Xaml", 1, "Overrides")]
        public sealed class Overrides : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Psi.Services;component/resources/PsiServicesIcons/ThemedIcons" +
            ".PsiServices.Generated.Xaml", 0, "OverridesAndImplements")]
        public sealed class OverridesAndImplements : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Psi.Services;component/resources/PsiServicesIcons/ThemedIcons" +
            ".PsiServices.Generated.Xaml", 6, "QuasiImplements")]
        public sealed class QuasiImplements : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
    }
}
namespace JetBrains.ReSharper.Psi.Services.StructuralSearch
{
    
    public class AndMatcher : JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher
    {
        public AndMatcher([JetBrains.Annotations.CanBeNullAttribute()] params JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher[] matchers) { }
        public AndMatcher([JetBrains.Annotations.CanBeNullAttribute()] System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher> matchers) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher> Children { get; }
        public System.Collections.Generic.IEnumerable<string> Words { get; }
        public bool Match(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.Services.StructuralSearch.IMatchingContext context) { }
    }
    public class AnyTypeMatcher : JetBrains.ReSharper.Psi.Services.StructuralSearch.ITypeMatcher
    {
        public static readonly JetBrains.ReSharper.Psi.Services.StructuralSearch.AnyTypeMatcher Instance;
        public string ShortName { get; }
        public bool MatchType(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.Services.StructuralSearch.IMatchingContext context) { }
        public bool MatchType(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.IType elementType, JetBrains.ReSharper.Psi.Services.StructuralSearch.IMatchingContext context) { }
    }
    [System.Diagnostics.DebuggerDisplayAttribute("{DebuggerRepresentation}")]
    public abstract class ElementMatcherBase<T> : JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher
        where T :  class, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        protected ElementMatcherBase() { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher> Children { get; }
        protected JetBrains.ReSharper.Psi.Services.StructuralSearch.ITypeMatcher TypeMatcher { get; set; }
        public virtual System.Collections.Generic.IEnumerable<string> Words { get; }
        protected void AddChild(JetBrains.Util.Pair<JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher, System.Func<T, JetBrains.ReSharper.Psi.Tree.ITreeNode>> child) { }
        protected JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher AddMatcher<T2>(T expression, System.Func<T, T2> elementsGetter) { }
        protected JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher AddMatcher<T2>(T expression, System.Func<T, T2> elementsGetter, System.Func<T2, T2, bool> comparer) { }
        protected JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher AddMatcher(JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher matcher, System.Func<T, JetBrains.ReSharper.Psi.Tree.ITreeNode> propertyGetter) { }
        public virtual bool Match(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.Services.StructuralSearch.IMatchingContext context) { }
    }
    public interface IElementMatcher
    {
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher> Children { get; }
        System.Collections.Generic.IEnumerable<string> Words { get; }
        bool Match(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.Services.StructuralSearch.IMatchingContext context);
    }
    public class IllegalPlaceholderException : JetBrains.ReSharper.Psi.Services.StructuralSearch.StructuralSearchException
    {
        public IllegalPlaceholderException(string msg, JetBrains.Util.TextRange range) { }
        public JetBrains.Util.TextRange Range { get; }
    }
    public interface IMatchingContext
    {
        JetBrains.ReSharper.Psi.Tree.ITreeNode MatchedElement { get; set; }
        bool CheckAllVariants(JetBrains.ReSharper.Psi.Tree.ITreeNode element, params System.Func<, , >[] match);
        bool CheckVariant([JetBrains.Annotations.InstantHandleAttribute()] System.Func<JetBrains.ReSharper.Psi.Services.StructuralSearch.IMatchingContext, bool> match);
        JetBrains.ReSharper.Psi.Services.StructuralSearch.IMatchingContext ExecuteDelayedMatchers();
        System.Collections.Generic.IList<object> GetAllMatchedElements(string placeholderName);
        T GetData<T>(JetBrains.Util.Key<T> key)
            where T :  class;
        object GetMatchedElement(string placeholderName);
        JetBrains.ReSharper.Psi.IType GetMatchedType(string placeholderName);
        bool MatchPlaceholder(JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholderMatcher matcher, JetBrains.ReSharper.Psi.Tree.ITreeNode element, System.Func<JetBrains.ReSharper.Psi.Tree.ITreeNode, bool> additionalCheck);
        bool MatchPlaceholder(JetBrains.ReSharper.Psi.Services.StructuralSearch.ISequencePlaceholderMatcher matcher, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Tree.ITreeNode> element, System.Func<System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Tree.ITreeNode>, bool> additionalCheck);
        bool MatchPlaceholder(JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholderMatcher matcher, JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher additionalCheck);
        bool MatchPlaceholder(JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholderTypeMatcher matcher, JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.IType elementType, JetBrains.ReSharper.Psi.ITypeConversionRule typeConversionRule);
        void PutData<T>(JetBrains.Util.Key<T> key, T value)
            where T :  class;
        void RegisterTypeMatcher(JetBrains.ReSharper.Psi.Services.StructuralSearch.ITypeMatcher matcher, JetBrains.ReSharper.Psi.Tree.ITreeNode element);
    }
    public interface IMetaPlaceholder : JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder, JetBrains.Util.ICloneable<JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder>, System.ICloneable { }
    public interface IPatternFromCodeCreator
    {
        JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralSearchPattern CreatePattern(JetBrains.ProjectModel.ISolution solution, JetBrains.DocumentModel.DocumentRange selection);
    }
    public interface IPatternLexerErrorResult : JetBrains.ReSharper.Psi.Services.StructuralSearch.IPatternLexerResult
    {
        string ErrorMessage { get; }
        JetBrains.Util.TextRange ErrorRange { get; }
    }
    public interface IPatternLexerResult
    {
        JetBrains.ReSharper.Psi.Tree.ITreeNode Element { get; }
        JetBrains.ReSharper.Psi.Services.StructuralSearch.PlaceholderUsagesCollection Placeholders { get; }
    }
    public interface IPlaceholder : JetBrains.Util.ICloneable<JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder>, System.ICloneable
    {
        string Description { get; }
        string Name { get; }
        string[] ReplacingText { get; }
        System.Collections.Generic.ICollection<string> Words { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholderMatcher CreateMatcher(JetBrains.ReSharper.Psi.Services.StructuralSearch.StructuralSearchPatternParams @params);
        JetBrains.ReSharper.Psi.Services.StructuralSearch.PlaceholderInfo ToPlaceholderInfo();
    }
    public interface IPlaceholderMatcher : JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher
    {
        string PlaceholderName { get; }
        JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher CreatePlaceholderMatcher(JetBrains.ReSharper.Psi.Tree.ITreeNode element);
    }
    public interface IPlaceholderTypeMatcher : JetBrains.ReSharper.Psi.Services.StructuralSearch.ITypeMatcher
    {
        bool ExactType { get; }
        string PlaceholderName { get; }
        JetBrains.ReSharper.Psi.IType GetElementType(JetBrains.ReSharper.Psi.Tree.ITreeNode element);
        JetBrains.ReSharper.Psi.IType GetPlaceholderType(JetBrains.ReSharper.Psi.Tree.ITreeNode element);
    }
    public interface ISequenceMatcher<T> : JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher
        where T : JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        bool Match(System.Collections.Generic.IEnumerable<T> elements, JetBrains.ReSharper.Psi.Services.StructuralSearch.IMatchingContext context);
    }
    public interface ISequencePlaceholder : JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder, JetBrains.Util.ICloneable<JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder>, System.ICloneable
    {
        int MaximalOccurences { get; }
        int MinimalOccurences { get; }
    }
    public interface ISequencePlaceholderMatchChecker
    {
        bool ShouldCheckForMatching { get; }
        bool VerifyMatchSafely<T>(System.Collections.Generic.IList<T> elements, JetBrains.ReSharper.Psi.Services.StructuralSearch.IMatchingContext context, int fromElement, int count)
            where T : JetBrains.ReSharper.Psi.Tree.ITreeNode;
    }
    public interface ISequencePlaceholderMatcher : JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher, JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholderMatcher, JetBrains.ReSharper.Psi.Services.StructuralSearch.ISequenceMatcher<JetBrains.ReSharper.Psi.Tree.ITreeNode>
    {
        int MaximalOccurences { get; }
        int MinimalOccurences { get; }
        JetBrains.ReSharper.Psi.Services.StructuralSearch.ISequenceMatcher<JetBrains.ReSharper.Psi.Tree.ITreeNode> CreatePlaceholderMatcher(System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.Tree.ITreeNode> elements);
    }
    public interface ISequenceStructuralMatcher : JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralMatcher
    {
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralMatchResult Match<T>(System.Collections.Generic.IList<T> elements)
            where T : JetBrains.ReSharper.Psi.Tree.ITreeNode;
    }
    public interface ISequenceStructuralMatcher<T> : JetBrains.ReSharper.Psi.Services.StructuralSearch.ISequenceStructuralMatcher, JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralMatcher
        where T : JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralMatchResult Match(System.Collections.Generic.IList<T> elements);
    }
    public interface IStructuralMatcher
    {
        System.Collections.Generic.ICollection<string> Words { get; }
        System.Collections.Generic.ICollection<string> GetExtendedWords(JetBrains.ProjectModel.ISolution solution);
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralMatchResult Match(JetBrains.ReSharper.Psi.Tree.ITreeNode element);
        JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralMatchResult Match(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.Services.StructuralSearch.IMatchingContext context);
        bool QuickMatch(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.Services.StructuralSearch.IMatchingContext context = null);
    }
    public interface IStructuralMatchResult
    {
        JetBrains.ReSharper.Psi.Services.StructuralSearch.IMatchingContext Context { get; }
        bool Matched { get; }
        JetBrains.ReSharper.Psi.Tree.ITreeNode MatchedElement { get; }
        System.Collections.Generic.IList<T> GetAllMatchedElements<T>(string placeholderName);
        JetBrains.DocumentModel.DocumentRange GetDocumentRange();
        object GetMatch(string placeholderName);
        JetBrains.ReSharper.Psi.Tree.ITreeNode GetMatchedElement(string placeholderName);
        T GetMatchedElement<T>(string placeholderName)
            where T :  class;
        System.Collections.IEnumerable GetMatchedElementList(string placeholderName);
        JetBrains.ReSharper.Psi.ITreeRange GetMatchedTreeRange(string placeholderName);
        JetBrains.ReSharper.Psi.IType GetMatchedType(string placeholderName);
    }
    public interface IStructuralSearcher : JetBrains.ReSharper.Psi.ExtensionsAPI.IDomainSpecificSearcher
    {
        JetBrains.ReSharper.Psi.PsiLanguageType Language { get; }
    }
    public interface IStructuralSearcherFactory
    {
        bool IsInternal { get; }
        bool SupportsIgnoreUnmatched { get; }
        [JetBrains.Annotations.PureAttribute()]
        JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralSearchPattern CreatePattern();
        [JetBrains.Annotations.PureAttribute()]
        JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralSearchPattern CreatePattern(string pattern, params JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder[] placeholders);
        [JetBrains.Annotations.PureAttribute()]
        JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralSearchPattern CreatePattern(JetBrains.ProjectModel.ISolution solution, JetBrains.DocumentModel.DocumentRange selection);
        void Replace(JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralSearchPattern pattern, JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralMatchResult result);
        void Replace(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralMatchResult> targets, JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralSearchPattern pattern);
    }
    public interface IStructuralSearchPattern : JetBrains.Util.ICloneable<JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralSearchPattern>, System.ICloneable
    {
        string Comment { get; set; }
        bool FormatAfterReplace { get; set; }
        JetBrains.ReSharper.Psi.PsiLanguageType Language { get; }
        JetBrains.ReSharper.Psi.Services.StructuralSearch.StructuralSearchPatternParams Params { get; set; }
        System.Collections.Generic.IDictionary<string, JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder> Placeholders { get; set; }
        JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralSearchPatternPresenter Presenter { get; }
        string ReplaceComment { get; set; }
        string ReplacePattern { get; set; }
        string SearchPattern { get; set; }
        bool ShortenReferences { get; set; }
        JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralSearchPattern AddPatternPlaceholder(string name, string pattern);
        JetBrains.ReSharper.Psi.Services.StructuralSearch.IPatternLexerErrorResult Check();
        JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralMatcher CreateMatcher();
        JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralMatcher CreateMatcher(JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralSearchPatternBuilder builder);
        bool GuessPlaceholders();
        void ReadPlaceholders(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Services.StructuralSearch.PlaceholderInfo> placeholderInfos);
    }
    public interface IStructuralSearchPatternBuilder
    {
        JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralMatcher CreateMatcher(string pattern, System.Collections.Generic.IDictionary<string, JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder> placeholders, JetBrains.ReSharper.Psi.Services.StructuralSearch.StructuralSearchPatternParams @params);
        JetBrains.ReSharper.Psi.Services.StructuralSearch.IPatternLexerResult ParsePattern(string pattern, System.Collections.Generic.IDictionary<string, JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder> placeholders, JetBrains.ReSharper.Psi.Services.StructuralSearch.StructuralSearchPatternParams @params);
    }
    public interface IStructuralSearchPatternPresenter
    {
        [JetBrains.Annotations.NotNullAttribute()]
        string GetReplaceCommentPresentation();
        [JetBrains.Annotations.NotNullAttribute()]
        string GetReplaceCommentPresentation(JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralMatchResult result);
        [JetBrains.Annotations.NotNullAttribute()]
        string GetReplacePresentation();
        [JetBrains.Annotations.NotNullAttribute()]
        string GetReplacePresentation(JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralMatchResult result);
        [JetBrains.Annotations.NotNullAttribute()]
        string GetSearchCommentPresentation();
        [JetBrains.Annotations.NotNullAttribute()]
        string GetSearchCommentPresentation(JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralMatchResult result);
        [JetBrains.Annotations.NotNullAttribute()]
        string GetSearchPresentation();
        [JetBrains.Annotations.NotNullAttribute()]
        string GetSearchPresentation(JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralMatchResult result);
    }
    public interface ITypeMatcher
    {
        string ShortName { get; }
        bool MatchType(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.Services.StructuralSearch.IMatchingContext context);
        bool MatchType(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.IType elementType, JetBrains.ReSharper.Psi.Services.StructuralSearch.IMatchingContext context);
    }
    public interface ITypeMatcherCanContainOther
    {
        void RegisterContainingTypePlaceholderMatches(System.Action<string, JetBrains.ReSharper.Psi.Tree.ITreeNode> register, JetBrains.ReSharper.Psi.Tree.ITreeNode element);
    }
    public interface IUnknownPlaceholder : JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder, JetBrains.Util.ICloneable<JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder>, System.ICloneable
    {
        JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder ReplacementCandidate { get; set; }
    }
    public class ListAnyOrderMatcher<T> : JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher
        where T :  class, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        public ListAnyOrderMatcher(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher> matchers, System.Func<JetBrains.ReSharper.Psi.Tree.ITreeNode, System.Collections.Generic.IEnumerable<T>> elementsGetter) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher> Children { get; }
        public System.Collections.Generic.IEnumerable<string> Words { get; }
        public bool Match(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.Services.StructuralSearch.IMatchingContext context) { }
    }
    public class MatcherNotImplementedException : System.Exception
    {
        public MatcherNotImplementedException(System.Type type) { }
        public override string Message { get; }
    }
    public class NullMatcher : JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher
    {
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher> Children { get; }
        public System.Collections.Generic.IEnumerable<string> Words { get; }
        public bool Match(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.Services.StructuralSearch.IMatchingContext context) { }
    }
    public class OrMatcher : JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher
    {
        public OrMatcher([JetBrains.Annotations.CanBeNullAttribute()] params JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher[] matchers) { }
        public OrMatcher([JetBrains.Annotations.CanBeNullAttribute()] System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher> matchers) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher> Children { get; }
        public System.Collections.Generic.IEnumerable<string> Words { get; }
        public bool Match(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.Services.StructuralSearch.IMatchingContext context) { }
    }
    public class static PatternFromCodeCreatorHelper
    {
        public static string UnshiftAndTrim(string original) { }
    }
    public abstract class PatternLexer
    {
        public static readonly System.Text.RegularExpressions.Regex MetaPlaceholderRegex;
        [JetBrains.Annotations.NotNullAttribute()]
        protected System.Text.StringBuilder myText;
        public static readonly System.Text.RegularExpressions.Regex PlaceholderRegex;
        public static readonly System.Text.RegularExpressions.Regex SelectionEndRegex;
        public static readonly System.Text.RegularExpressions.Regex SelectionStartRegex;
        protected abstract JetBrains.ReSharper.Psi.LanguageService LanguageService { get; }
        protected abstract bool MetaPlaceholderSupported { get; }
        public JetBrains.ReSharper.Psi.Services.StructuralSearch.PlaceholderUsagesCollection PlaceholderUsages { get; }
        public string ProcessedText { get; }
        protected virtual JetBrains.ReSharper.Psi.Services.StructuralSearch.IUnknownPlaceholder CreateUnknownPlaceholder(string name) { }
        protected abstract JetBrains.ReSharper.Psi.Services.StructuralSearch.IMetaPlaceholder GetMetaPlaceholder(string name);
        protected virtual bool IsErrorElementBeforeOffset(JetBrains.ReSharper.Psi.Tree.IErrorElement errorElement, JetBrains.ReSharper.Psi.TreeOffset offset) { }
        public void ReplacePlaceholders(string pattern, System.Collections.Generic.IDictionary<string, JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder> placeholders, JetBrains.ReSharper.Psi.Services.StructuralSearch.StructuralSearchPatternParams @params, bool createUnknownPlaceholders = False, bool deleteUnusedPlaceholders = False, int realShift = 0) { }
        public virtual JetBrains.ReSharper.Psi.Services.StructuralSearch.IPatternLexerResult TryParsePattern(string pattern, System.Collections.Generic.IDictionary<string, JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder> placeholders, JetBrains.ReSharper.Psi.Services.StructuralSearch.StructuralSearchPatternParams @params, System.Func<JetBrains.ReSharper.Psi.Parsing.IParser, JetBrains.ReSharper.Psi.Tree.ITreeNode> createElement, int realShift = 0, bool createUnknownPlaceholders = False, bool deleteUnusedPlaceholders = False) { }
    }
    public class PatternLexerErrorResult : JetBrains.ReSharper.Psi.Services.StructuralSearch.IPatternLexerErrorResult, JetBrains.ReSharper.Psi.Services.StructuralSearch.IPatternLexerResult
    {
        public PatternLexerErrorResult(string error) { }
        public PatternLexerErrorResult(string error, JetBrains.Util.TextRange errorRange) { }
        public JetBrains.ReSharper.Psi.Tree.ITreeNode Element { get; }
        public string ErrorMessage { get; }
        public JetBrains.Util.TextRange ErrorRange { get; }
        public JetBrains.ReSharper.Psi.Services.StructuralSearch.PlaceholderUsagesCollection Placeholders { get; }
    }
    public class PatternLexerException : JetBrains.ReSharper.Psi.Services.StructuralSearch.StructuralSearchException
    {
        public PatternLexerException(string message) { }
        public PatternLexerException(string message, System.Exception inner) { }
    }
    public class PatternLexerResult : JetBrains.ReSharper.Psi.Services.StructuralSearch.IPatternLexerResult
    {
        public PatternLexerResult(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.Services.StructuralSearch.PlaceholderUsagesCollection placeholders) { }
        public JetBrains.ReSharper.Psi.Tree.ITreeNode Element { get; }
        public JetBrains.ReSharper.Psi.Services.StructuralSearch.PlaceholderUsagesCollection Placeholders { get; set; }
    }
    public class PatternMatcherBuilderParams
    {
        public PatternMatcherBuilderParams() { }
        public PatternMatcherBuilderParams(JetBrains.ReSharper.Psi.Services.StructuralSearch.StructuralSearchPatternParams @params) { }
        public JetBrains.ReSharper.Psi.Services.StructuralSearch.StructuralSearchPatternParams Params { get; }
        public JetBrains.ReSharper.Psi.Services.StructuralSearch.PlaceholderUsagesCollection PlaceholderUsages { get; set; }
        public bool SkipSelectionEnd { get; set; }
        public bool SkipSelectionStart { get; set; }
    }
    public class PlaceholderInfo
    {
        public string Name;
        public readonly System.Collections.Generic.Dictionary<string, string> Properties;
        public string Type;
        public PlaceholderInfo() { }
    }
    public class PlaceholderUsage
    {
        public PlaceholderUsage(JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder placeholder, int start, int end, int originalStart, int originalEnd) { }
        public JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholderMatcher Matcher { get; set; }
        public JetBrains.Util.TextRange OriginalRange { get; }
        public JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder Placeholder { get; }
        public JetBrains.ReSharper.Psi.TreeTextRange Range { get; set; }
    }
    public class PlaceholderUsagesCollection : System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Services.StructuralSearch.PlaceholderUsage>, System.Collections.IEnumerable
    {
        public PlaceholderUsagesCollection() { }
        public void Add(JetBrains.ReSharper.Psi.Services.StructuralSearch.PlaceholderUsage usage) { }
        public void AddRange(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Services.StructuralSearch.PlaceholderUsage> usages) { }
        public void Clear() { }
        public JetBrains.ReSharper.Psi.Services.StructuralSearch.PlaceholderUsage Find(JetBrains.ReSharper.Psi.TreeTextRange range) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Services.StructuralSearch.PlaceholderUsage> FindPlaceholdersInside(JetBrains.ReSharper.Psi.TreeTextRange range) { }
        public JetBrains.ReSharper.Psi.Services.StructuralSearch.Impl.SelectionPlaceholder FindSelectionPlaceholder(JetBrains.ReSharper.Psi.TreeTextRange range, bool skipStart, bool skipEnd) { }
        public System.Collections.Generic.IEnumerator<JetBrains.ReSharper.Psi.Services.StructuralSearch.PlaceholderUsage> GetEnumerator() { }
    }
    public class ReplacePatternLexer : JetBrains.ReSharper.Psi.Services.StructuralSearch.PatternLexer
    {
        protected override JetBrains.ReSharper.Psi.LanguageService LanguageService { get; }
        protected override bool MetaPlaceholderSupported { get; }
        protected override JetBrains.ReSharper.Psi.Services.StructuralSearch.IMetaPlaceholder GetMetaPlaceholder(string name) { }
        public JetBrains.ReSharper.Psi.Services.StructuralSearch.ReplacePatternLexerResult ParsePattern(string replacePattern, System.Collections.Generic.IDictionary<string, JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder> placeholders, JetBrains.ReSharper.Psi.Services.StructuralSearch.StructuralSearchPatternParams @params) { }
    }
    public class ReplacePatternLexerErrorResult : JetBrains.ReSharper.Psi.Services.StructuralSearch.PatternLexerErrorResult
    {
        public ReplacePatternLexerErrorResult(string error, JetBrains.Util.TextRange errorRange) { }
        public ReplacePatternLexerErrorResult(JetBrains.ReSharper.Psi.Services.StructuralSearch.IPatternLexerErrorResult errorResult) { }
    }
    public class ReplacePatternLexerResult
    {
        public ReplacePatternLexerResult(string text, JetBrains.ReSharper.Psi.Services.StructuralSearch.PlaceholderUsagesCollection placeholders) { }
        public JetBrains.ReSharper.Psi.Services.StructuralSearch.PlaceholderUsagesCollection Placeholders { get; }
        public string Text { get; }
    }
    public class SequenceMatcher<T> : JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher, JetBrains.ReSharper.Psi.Services.StructuralSearch.ISequenceMatcher<T>
        where T : JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        public SequenceMatcher([JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher> matchers) { }
        public SequenceMatcher([JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher> matchers, System.Func<JetBrains.ReSharper.Psi.Tree.ITreeNode, System.Collections.Generic.IEnumerable<T>> elementsGetter) { }
        public SequenceMatcher(JetBrains.ReSharper.Psi.Tree.ITreeNode element, System.Func<JetBrains.ReSharper.Psi.Tree.ITreeNode, System.Collections.Generic.IEnumerable<T>> elementsGetter, System.Func<JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher> getMatcher) { }
        public bool AllowUnmatched { get; set; }
        public bool AllowUnmatchedAtTheEnd { get; set; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher> Children { get; }
        public bool DeepAnalysis { get; set; }
        public System.Collections.Generic.IEnumerable<string> Words { get; }
        protected bool CanSkip(T element) { }
        public virtual bool CountedAsOccurence(T element) { }
        public bool Match(System.Collections.Generic.IEnumerable<T> elements, JetBrains.ReSharper.Psi.Services.StructuralSearch.IMatchingContext context) { }
        public bool Match(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.Services.StructuralSearch.IMatchingContext context) { }
        public bool MatchAllVariants(System.Collections.Generic.IEnumerable<T> elements, JetBrains.ReSharper.Psi.Services.StructuralSearch.IMatchingContext context) { }
        public bool MatchFirst(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        protected System.Collections.Generic.IEnumerable<int[]> MatchRecursive(System.Collections.Generic.IList<T> elements, System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher> matchers, JetBrains.ReSharper.Psi.Services.StructuralSearch.IMatchingContext context, int currentMatcher, int currentElement, int[] maxElementIndicesForMatchers, bool[] countedAsOccurence) { }
        protected virtual bool MoveToNextElement(System.Collections.Generic.IEnumerator<T> elementsEnumerator, out T currentElement) { }
    }
    public class SimpleMatcher<T, T2> : JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher
    
    
    {
        public SimpleMatcher(T element, System.Func<T, T2> propGetter) { }
        public SimpleMatcher(T element, System.Func<T, T2> propGetter, System.Func<T2, T2, bool> comparer) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher> Children { get; }
        public System.Collections.Generic.IEnumerable<string> Words { get; }
        public bool Match(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.Services.StructuralSearch.IMatchingContext context) { }
    }
    public class StructuralFinder : JetBrains.ReSharper.Psi.IRecursiveElementProcessor
    {
        public StructuralFinder(JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralMatcher structuralSearchMatcher) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralMatchResult> MatchResults { get; }
        public bool ProcessingIsFinished { get; }
        public bool InteriorShouldBeProcessed(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public void ProcessAfterInterior(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public void ProcessBeforeInterior(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
    }
    public abstract class StructuralMatcher : JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralMatcher
    {
        protected StructuralMatcher([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher matcher) { }
        [JetBrains.Annotations.NotNullAttribute()]
        protected JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher Matcher { get; }
        public System.Collections.Generic.ICollection<string> Words { get; }
        public abstract System.Collections.Generic.ICollection<string> GetExtendedWords(JetBrains.ProjectModel.ISolution solution);
        public JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralMatchResult Match(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public virtual JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralMatchResult Match(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.Services.StructuralSearch.IMatchingContext context) { }
        public bool QuickMatch(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.Services.StructuralSearch.IMatchingContext context = null) { }
    }
    [JetBrains.ReSharper.Psi.PsiSharedComponentAttribute()]
    public class StructuralSearchEngine
    {
        public StructuralSearchEngine(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ReSharper.Psi.ILanguageManager languageManager, JetBrains.ReSharper.Psi.ILanguages languages) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralSearcherFactory GetFactory(JetBrains.ReSharper.Psi.PsiLanguageType language) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.PsiLanguageType> GetNonInternalLanguages() { }
        public bool IsAvailableFor(JetBrains.ReSharper.Psi.PsiLanguageType language) { }
        public JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralSearcherFactory TryGetFactory(JetBrains.ReSharper.Psi.PsiLanguageType language) { }
    }
    public class StructuralSearcher : JetBrains.ReSharper.Psi.ExtensionsAPI.IDomainSpecificSearcher, JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralSearcher
    {
        public StructuralSearcher(JetBrains.DocumentManagers.DocumentManager documentManager, JetBrains.ReSharper.Psi.PsiLanguageType language, JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralMatcher matcher) { }
        public JetBrains.ReSharper.Psi.PsiLanguageType Language { get; }
        public bool ProcessElement<TResult>(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.Search.IFindResultConsumer<TResult> consumer) { }
        public bool ProcessProjectItem<TResult>(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, JetBrains.ReSharper.Psi.Search.IFindResultConsumer<TResult> consumer) { }
    }
    [JetBrains.Annotations.BaseTypeRequiredAttribute(typeof(JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralSearcherFactory))]
    [JetBrains.Annotations.MeansImplicitUseAttribute()]
    [System.AttributeUsageAttribute(System.AttributeTargets.Class | System.AttributeTargets.All)]
    public class StructuralSearcherFactoryAttribute : JetBrains.ReSharper.Psi.LanguageAttribute
    {
        public StructuralSearcherFactoryAttribute(System.Type language) { }
    }
    public class StructuralSearchException : System.Exception
    {
        public StructuralSearchException(string message, System.Exception innerException) { }
        public StructuralSearchException(string message) { }
    }
    public class StructuralSearchPatternParams
    {
        [JetBrains.Application.Configuration.XmlExternalizableAttribute(true)]
        public bool IgnoreBracesInSingleStatementBlocks;
        [JetBrains.Application.Configuration.XmlExternalizableAttribute(true)]
        public bool IgnoreEmptyStatements;
        [JetBrains.Application.Configuration.XmlExternalizableAttribute(true)]
        public bool IgnoreParanthesisInExpressions;
        public bool IgnoreUnmatchedContent;
        [JetBrains.Application.Configuration.XmlExternalizableAttribute(true)]
        public bool MatchAllMembersWithoutModifiers;
        [JetBrains.Application.Configuration.XmlExternalizableAttribute(true)]
        public bool MatchMethodParameterWithThisRefOut;
        [JetBrains.Application.Configuration.XmlExternalizableAttribute(true)]
        public bool SmartMatchAssociativeExpressions;
        [JetBrains.Application.Configuration.XmlExternalizableAttribute(true)]
        public bool TreatPostfixAndPrefixOperatorEquivalent;
        [JetBrains.Application.Configuration.XmlExternalizableAttribute(JetBrains.ReSharper.Psi.Services.StructuralSearch.TreatBinaryExpressionsEquivalent.Smart)]
        public JetBrains.ReSharper.Psi.Services.StructuralSearch.TreatBinaryExpressionsEquivalent TreatReversedBinaryExpressionsEquivalent;
        [JetBrains.Application.Configuration.XmlExternalizableAttribute(true)]
        public bool TypePlaceholderMatchesVoid;
        public StructuralSearchPatternParams() { }
        public static JetBrains.ReSharper.Psi.Services.StructuralSearch.StructuralSearchPatternParams CreateParams(bool matchSimilar, bool ignoreUnmatchedContent = False, JetBrains.ReSharper.Psi.Services.StructuralSearch.TreatBinaryExpressionsEquivalent binaryExpressions = 2) { }
        public bool Equals(JetBrains.ReSharper.Psi.Services.StructuralSearch.StructuralSearchPatternParams other) { }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
    }
    public enum TreatBinaryExpressionsEquivalent
    {
        Never = 0,
        Always = 1,
        Smart = 2,
    }
    public abstract class TypeMatcherBase<T> : JetBrains.ReSharper.Psi.Services.StructuralSearch.ITypeMatcher
        where T :  class, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        protected TypeMatcherBase(System.Collections.Generic.List<JetBrains.ReSharper.Psi.Services.StructuralSearch.ITypeMatcher> typeArgumentMatchers) { }
        public string ShortName { get; }
        protected System.Collections.Generic.List<JetBrains.ReSharper.Psi.Services.StructuralSearch.ITypeMatcher> TypeArgumentMatchers { get; }
        protected abstract string TypeName { get; }
        protected virtual bool CheckEmptySubstitution(JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution) { }
        protected virtual bool CheckSubstition(JetBrains.ReSharper.Psi.Resolve.ISubstitution subst, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.ITypeElement elDeclaredTypeElement, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.Services.StructuralSearch.IMatchingContext context) { }
        protected abstract JetBrains.ReSharper.Psi.IType GetElementType(T element);
        protected abstract JetBrains.ReSharper.Psi.IType GetOriginalType(JetBrains.ReSharper.Psi.Tree.ITreeNode element);
        public bool MatchType(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.Services.StructuralSearch.IMatchingContext context) { }
        public bool MatchType(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.IType elementType, JetBrains.ReSharper.Psi.Services.StructuralSearch.IMatchingContext context) { }
        protected virtual bool MatchType(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.IType type, JetBrains.ReSharper.Psi.IType elementType, JetBrains.ReSharper.Psi.Services.StructuralSearch.IMatchingContext context) { }
        protected virtual bool MatchTypeWithPlaceholder(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.IType elementType, JetBrains.ReSharper.Psi.Services.StructuralSearch.IMatchingContext context) { }
        protected class ArgumentPlaceholderTypeArgumentListMatcher<T> : System.Collections.Generic.List<JetBrains.ReSharper.Psi.Services.StructuralSearch.ITypeMatcher>
            where T :  class, JetBrains.ReSharper.Psi.Tree.ITreeNode
        {
            public static readonly System.Collections.Generic.List<JetBrains.ReSharper.Psi.Services.StructuralSearch.ITypeMatcher> Instance;
        }
    }
    public class UnorderedSetMatcher : JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher, JetBrains.ReSharper.Psi.Services.StructuralSearch.ISequenceMatcher<JetBrains.ReSharper.Psi.Tree.ITreeNode>
    {
        public UnorderedSetMatcher([JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher> matchers) { }
        public bool AllowUnmatched { get; set; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher> Children { get; }
        public System.Collections.Generic.IEnumerable<string> Words { get; }
        public bool Match(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Tree.ITreeNode> elements, JetBrains.ReSharper.Psi.Services.StructuralSearch.IMatchingContext context) { }
        public bool Match(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.Services.StructuralSearch.IMatchingContext context) { }
    }
}
namespace JetBrains.ReSharper.Psi.Services.StructuralSearch.Impl
{
    
    public class static AssociativeMatcherUtil
    {
        public static JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralMatchResult MatchExpression(JetBrains.ReSharper.Psi.Tree.ITreeNode node, System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Tree.ITreeNode> operands, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher> matchers, JetBrains.ReSharper.Psi.Services.StructuralSearch.IMatchingContext context, System.Func<JetBrains.ReSharper.Psi.Tree.ITreeNode, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Tree.ITreeNode>> getOperands) { }
        public static System.Collections.Generic.List<JetBrains.ReSharper.Psi.Tree.ITreeNode> MatchExpression(System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Tree.ITreeNode> operands, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher> matchers, JetBrains.ReSharper.Psi.Services.StructuralSearch.IMatchingContext context, System.Func<JetBrains.ReSharper.Psi.Tree.ITreeNode, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Tree.ITreeNode>> getOperands) { }
        public static bool MatchUnorderedSequence(System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Tree.ITreeNode> operands, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher> allMatchers, JetBrains.ReSharper.Psi.Services.StructuralSearch.IMatchingContext context, bool allowUnmatched) { }
    }
    public class FindResultStructural : JetBrains.ReSharper.Psi.Search.FindResultText
    {
        public FindResultStructural(JetBrains.ReSharper.Psi.Tree.IFile file, JetBrains.DocumentModel.DocumentRange range, JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralMatchResult matchResult) { }
        public JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralMatchResult MatchResult { get; }
    }
    public class MatchingContext : JetBrains.ReSharper.Psi.Services.StructuralSearch.IMatchingContext
    {
        public JetBrains.ReSharper.Psi.Tree.ITreeNode MatchedElement { get; set; }
        public bool CheckAllVariants(JetBrains.ReSharper.Psi.Tree.ITreeNode element, params System.Func<, , >[] variants) { }
        public bool CheckVariant(System.Func<JetBrains.ReSharper.Psi.Services.StructuralSearch.IMatchingContext, bool> match) { }
        public JetBrains.ReSharper.Psi.Services.StructuralSearch.IMatchingContext ExecuteDelayedMatchers() { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public System.Collections.Generic.IList<object> GetAllMatchedElements(string placeholderName) { }
        public T GetData<T>(JetBrains.Util.Key<T> key)
            where T :  class { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public object GetMatchedElement(string placeholderName) { }
        public JetBrains.ReSharper.Psi.IType GetMatchedType(string placeholderName) { }
        public bool MatchPlaceholder(JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholderMatcher placeholderMatcher, JetBrains.ReSharper.Psi.Tree.ITreeNode element, System.Func<JetBrains.ReSharper.Psi.Tree.ITreeNode, bool> additionalCheck) { }
        public bool MatchPlaceholder(JetBrains.ReSharper.Psi.Services.StructuralSearch.ISequencePlaceholderMatcher placeholderMatcher, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Tree.ITreeNode> elements, System.Func<System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Tree.ITreeNode>, bool> additionalCheck) { }
        public bool MatchPlaceholder(JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholderMatcher placeholderMatcher, JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher additionalCheck) { }
        public bool MatchPlaceholder(JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholderTypeMatcher matcher, JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.IType elementType, JetBrains.ReSharper.Psi.ITypeConversionRule typeConversionRule) { }
        public void PutData<T>(JetBrains.Util.Key<T> key, T value)
            where T :  class { }
        public void RegisterTypeMatcher(JetBrains.ReSharper.Psi.Services.StructuralSearch.ITypeMatcher matcher, JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
    }
    public class MatchingContextVariant : JetBrains.ReSharper.Psi.Services.StructuralSearch.IMatchingContext
    {
        public MatchingContextVariant(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public JetBrains.ReSharper.Psi.Tree.ITreeNode MatchedElement { get; set; }
        public bool Valid { get; }
        public bool CheckAllVariants(JetBrains.ReSharper.Psi.Tree.ITreeNode element, params System.Func<, , >[] variants) { }
        public bool CheckVariant(System.Func<JetBrains.ReSharper.Psi.Services.StructuralSearch.IMatchingContext, bool> match) { }
        public JetBrains.ReSharper.Psi.Services.StructuralSearch.Impl.MatchingContextVariant Clone() { }
        public JetBrains.ReSharper.Psi.Services.StructuralSearch.IMatchingContext ExecuteDelayedMatchers() { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public System.Collections.Generic.IList<object> GetAllMatchedElements(string placeholderName) { }
        public T GetData<T>(JetBrains.Util.Key<T> key)
            where T :  class { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public object GetMatchedElement(string placeholderName) { }
        public JetBrains.ReSharper.Psi.IType GetMatchedType(string placeholderName) { }
        public bool MatchPlaceholder(JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholderMatcher placeholderMatcher, JetBrains.ReSharper.Psi.Tree.ITreeNode element, System.Func<JetBrains.ReSharper.Psi.Tree.ITreeNode, bool> additionalCheck) { }
        public bool MatchPlaceholder(JetBrains.ReSharper.Psi.Services.StructuralSearch.ISequencePlaceholderMatcher placeholderMatcher, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Tree.ITreeNode> elements, System.Func<System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Tree.ITreeNode>, bool> additionalCheck) { }
        public bool MatchPlaceholder(JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholderMatcher matcher, JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher additionalCheck) { }
        public bool MatchPlaceholder(JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholderTypeMatcher matcher, JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.IType elementType, JetBrains.ReSharper.Psi.ITypeConversionRule typeConversionRule) { }
        public void PutData<T>(JetBrains.Util.Key<T> key, T value)
            where T :  class { }
        public void RegisterTypeMatcher(JetBrains.ReSharper.Psi.Services.StructuralSearch.ITypeMatcher matcher, JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
    }
    public class MetaPlaceholderMatcher : JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher, JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholderMatcher, JetBrains.ReSharper.Psi.Services.StructuralSearch.ISequenceMatcher<JetBrains.ReSharper.Psi.Tree.ITreeNode>, JetBrains.ReSharper.Psi.Services.StructuralSearch.ISequencePlaceholderMatcher
    {
        public MetaPlaceholderMatcher(string name) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher> Children { get; }
        public int MaximalOccurences { get; }
        public int MinimalOccurences { get; }
        public string PlaceholderName { get; }
        public System.Collections.Generic.IEnumerable<string> Words { get; }
        public JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher CreatePlaceholderMatcher(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public JetBrains.ReSharper.Psi.Services.StructuralSearch.ISequenceMatcher<JetBrains.ReSharper.Psi.Tree.ITreeNode> CreatePlaceholderMatcher(System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.Tree.ITreeNode> elements) { }
        public bool Match(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Tree.ITreeNode> elements, JetBrains.ReSharper.Psi.Services.StructuralSearch.IMatchingContext context) { }
        public bool Match(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.Services.StructuralSearch.IMatchingContext context) { }
    }
    public abstract class PlaceholderBase : JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder, JetBrains.Util.ICloneable<JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder>, System.ICloneable
    {
        protected PlaceholderBase(string name) { }
        public abstract string Description { get; }
        public string Name { get; set; }
        public abstract string[] ReplacingText { get; }
        public virtual System.Collections.Generic.ICollection<string> Words { get; }
        public abstract JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder Clone();
        public abstract JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholderMatcher CreateMatcher(JetBrains.ReSharper.Psi.Services.StructuralSearch.StructuralSearchPatternParams @params);
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
        public abstract JetBrains.ReSharper.Psi.Services.StructuralSearch.PlaceholderInfo ToPlaceholderInfo();
        public override string ToString() { }
    }
    public abstract class PlaceholderMatcherBase : JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher, JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholderMatcher
    {
        protected PlaceholderMatcherBase(JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder placeholder) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher> Children { get; }
        public string PlaceholderName { get; }
        public System.Collections.Generic.IEnumerable<string> Words { get; }
        public abstract JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher CreatePlaceholderMatcher(JetBrains.ReSharper.Psi.Tree.ITreeNode element);
        public abstract bool Match(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.Services.StructuralSearch.IMatchingContext context);
    }
    public struct PlaceholderReplacement
    {
        public PlaceholderReplacement(JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder placeholder, object replacement) { }
        public JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder Placeholder { get; }
        public object Replacement { get; }
    }
    public class SelectionMatcher : JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher
    {
        public SelectionMatcher(bool isSelStart, JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher childMatcher) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher> Children { get; }
        public System.Collections.Generic.IEnumerable<string> Words { get; }
        public bool Match(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.Services.StructuralSearch.IMatchingContext context) { }
    }
    public class SelectionPlaceholder : JetBrains.ReSharper.Psi.Services.StructuralSearch.Impl.PlaceholderBase
    {
        public static readonly JetBrains.Util.Key<JetBrains.ReSharper.Psi.Tree.ITreeNode> SelectionEndKey;
        public static readonly JetBrains.Util.Key<JetBrains.ReSharper.Psi.Tree.ITreeNode> SelectionStartKey;
        public SelectionPlaceholder(string name, bool isSelStart) { }
        public override string Description { get; }
        public bool IsSelStart { get; }
        public override string[] ReplacingText { get; }
        public override JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder Clone() { }
        public override JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholderMatcher CreateMatcher(JetBrains.ReSharper.Psi.Services.StructuralSearch.StructuralSearchPatternParams @params) { }
        public override JetBrains.ReSharper.Psi.Services.StructuralSearch.PlaceholderInfo ToPlaceholderInfo() { }
    }
    public class SelectionPlaceholderMatcher : JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher, JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholderMatcher
    {
        public SelectionPlaceholderMatcher(bool isSelStart, JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholderMatcher childMatcher) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher> Children { get; }
        public string PlaceholderName { get; }
        public System.Collections.Generic.IEnumerable<string> Words { get; }
        public JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher CreatePlaceholderMatcher(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public bool Match(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.Services.StructuralSearch.IMatchingContext context) { }
    }
    public class SelectionSequencePlaceholderMatcher : JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher, JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholderMatcher, JetBrains.ReSharper.Psi.Services.StructuralSearch.ISequenceMatcher<JetBrains.ReSharper.Psi.Tree.ITreeNode>, JetBrains.ReSharper.Psi.Services.StructuralSearch.ISequencePlaceholderMatchChecker, JetBrains.ReSharper.Psi.Services.StructuralSearch.ISequencePlaceholderMatcher
    {
        public SelectionSequencePlaceholderMatcher(bool isSelStart, JetBrains.ReSharper.Psi.Services.StructuralSearch.ISequencePlaceholderMatcher childMatcher) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher> Children { get; }
        public int MaximalOccurences { get; }
        public int MinimalOccurences { get; }
        public string PlaceholderName { get; }
        public bool ShouldCheckForMatching { get; }
        public System.Collections.Generic.IEnumerable<string> Words { get; }
        public JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher CreatePlaceholderMatcher(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public JetBrains.ReSharper.Psi.Services.StructuralSearch.ISequenceMatcher<JetBrains.ReSharper.Psi.Tree.ITreeNode> CreatePlaceholderMatcher(System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.Tree.ITreeNode> elements) { }
        public bool Match(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.Services.StructuralSearch.IMatchingContext context) { }
        public bool Match(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Tree.ITreeNode> elements, JetBrains.ReSharper.Psi.Services.StructuralSearch.IMatchingContext context) { }
        public bool VerifyMatchSafely<T>(System.Collections.Generic.IList<T> elements, JetBrains.ReSharper.Psi.Services.StructuralSearch.IMatchingContext context, int fromElement, int count)
            where T : JetBrains.ReSharper.Psi.Tree.ITreeNode { }
    }
    public class SequenceMatchingContext<T> : JetBrains.ReSharper.Psi.Services.StructuralSearch.Impl.MatchingContext
        where T : JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        public SequenceMatchingContext(System.Collections.Generic.IEnumerable<T> elements) { }
        public System.Collections.Generic.IEnumerable<T> Elements { get; set; }
    }
    public abstract class SequencePlaceholderBase : JetBrains.ReSharper.Psi.Services.StructuralSearch.Impl.PlaceholderBase, JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder, JetBrains.ReSharper.Psi.Services.StructuralSearch.ISequencePlaceholder, JetBrains.Util.ICloneable<JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder>, System.ICloneable
    {
        protected SequencePlaceholderBase(string name, int minimalOccurences = 1, int maximalOccurences = 1) { }
        protected SequencePlaceholderBase(JetBrains.ReSharper.Psi.Services.StructuralSearch.PlaceholderInfo placeholderInfo) { }
        public override string Description { get; }
        protected abstract string EntityName { get; }
        public int MaximalOccurences { get; set; }
        public int MinimalOccurences { get; set; }
        protected abstract string TagName { get; }
        public bool Equals(JetBrains.ReSharper.Psi.Services.StructuralSearch.Impl.SequencePlaceholderBase other) { }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
        public override JetBrains.ReSharper.Psi.Services.StructuralSearch.PlaceholderInfo ToPlaceholderInfo() { }
    }
    public abstract class SequencePlaceholderMatcherBase : JetBrains.ReSharper.Psi.Services.StructuralSearch.Impl.PlaceholderMatcherBase, JetBrains.ReSharper.Psi.Services.StructuralSearch.IElementMatcher, JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholderMatcher, JetBrains.ReSharper.Psi.Services.StructuralSearch.ISequenceMatcher<JetBrains.ReSharper.Psi.Tree.ITreeNode>, JetBrains.ReSharper.Psi.Services.StructuralSearch.ISequencePlaceholderMatcher
    {
        protected SequencePlaceholderMatcherBase(JetBrains.ReSharper.Psi.Services.StructuralSearch.ISequencePlaceholder placeholder) { }
        public int MaximalOccurences { get; }
        public int MinimalOccurences { get; }
        public abstract JetBrains.ReSharper.Psi.Services.StructuralSearch.ISequenceMatcher<JetBrains.ReSharper.Psi.Tree.ITreeNode> CreatePlaceholderMatcher(System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.Tree.ITreeNode> enumerable);
        public virtual bool Match(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Tree.ITreeNode> elements, JetBrains.ReSharper.Psi.Services.StructuralSearch.IMatchingContext context) { }
    }
    public class SequenceStructuralMatcher<T> : JetBrains.ReSharper.Psi.Services.StructuralSearch.ISequenceStructuralMatcher, JetBrains.ReSharper.Psi.Services.StructuralSearch.ISequenceStructuralMatcher<T>, JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralMatcher
        where T : JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        public SequenceStructuralMatcher(JetBrains.ReSharper.Psi.Services.StructuralSearch.SequenceMatcher<T> matcher) { }
        protected JetBrains.ReSharper.Psi.Services.StructuralSearch.SequenceMatcher<T> Matcher { get; }
        public System.Collections.Generic.ICollection<string> Words { get; }
        public System.Collections.Generic.ICollection<string> GetExtendedWords(JetBrains.ProjectModel.ISolution solution) { }
        protected virtual bool IsFilteredNode(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralMatchResult Match([JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IList<T> elements) { }
        public JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralMatchResult Match<TTreeNode>(System.Collections.Generic.IList<TTreeNode> elements)
            where TTreeNode : JetBrains.ReSharper.Psi.Tree.ITreeNode { }
        public virtual JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralMatchResult Match(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public virtual JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralMatchResult Match(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.Services.StructuralSearch.IMatchingContext context) { }
        protected JetBrains.ReSharper.Psi.Tree.ITreeNode NextSignificantElement(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public bool QuickMatch(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.Services.StructuralSearch.IMatchingContext context = null) { }
    }
    public class StructuralMatchResult : JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralMatchResult
    {
        public static readonly JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralMatchResult NOT_MATCHED;
        public JetBrains.ReSharper.Psi.Services.StructuralSearch.IMatchingContext Context { get; }
        public bool Matched { get; }
        public JetBrains.ReSharper.Psi.Tree.ITreeNode MatchedElement { get; }
        public static JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralMatchResult Get(JetBrains.ReSharper.Psi.Services.StructuralSearch.IMatchingContext context, JetBrains.DocumentModel.DocumentRange range) { }
        public System.Collections.Generic.IList<T> GetAllMatchedElements<T>(string placeholderName) { }
        public JetBrains.DocumentModel.DocumentRange GetDocumentRange() { }
        public object GetMatch(string placeholderName) { }
        public JetBrains.ReSharper.Psi.Tree.ITreeNode GetMatchedElement(string placeholderName) { }
        public T GetMatchedElement<T>(string placeholderName)
            where T :  class { }
        public System.Collections.IEnumerable GetMatchedElementList(string placeholderName) { }
        public JetBrains.ReSharper.Psi.ITreeRange GetMatchedTreeRange(string placeholderName) { }
        public JetBrains.ReSharper.Psi.IType GetMatchedType(string placeholderName) { }
        public static JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralMatchResult GetSequenceContext<T>(JetBrains.ReSharper.Psi.Services.StructuralSearch.Impl.SequenceMatchingContext<T> context, JetBrains.DocumentModel.DocumentRange range)
            where T : JetBrains.ReSharper.Psi.Tree.ITreeNode { }
    }
    public abstract class StructuralSearchPatternPresenterBase : JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralSearchPatternPresenter
    {
        protected StructuralSearchPatternPresenterBase(JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralSearchPattern pattern) { }
        protected abstract string GetListReplacement(System.Collections.IEnumerable enumerable);
        public string GetReplaceCommentPresentation() { }
        public string GetReplaceCommentPresentation(JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralMatchResult result) { }
        public string GetReplacePresentation() { }
        public string GetReplacePresentation(JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralMatchResult result) { }
        public string GetSearchCommentPresentation() { }
        public string GetSearchCommentPresentation(JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralMatchResult result) { }
        public string GetSearchPresentation() { }
        public string GetSearchPresentation(JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralMatchResult result) { }
        protected abstract JetBrains.ReSharper.Psi.Services.StructuralSearch.ReplacePatternLexerResult ParsePattern(string text, System.Collections.Generic.IDictionary<string, JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder> placeholders);
    }
    public class StructuralSearchPatternValidator
    {
        public StructuralSearchPatternValidator(JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralSearchPatternBuilder[] builders) { }
        public JetBrains.ReSharper.Psi.Services.StructuralSearch.IPatternLexerResult TryParseReplacePattern(string replacePattern, System.Collections.Generic.IDictionary<string, JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder> placeholders, JetBrains.ReSharper.Psi.Services.StructuralSearch.StructuralSearchPatternParams @params) { }
        public JetBrains.ReSharper.Psi.Services.StructuralSearch.IPatternLexerErrorResult Validate(JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralSearchPattern pattern) { }
    }
    public class UnknownPlaceholder : JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder, JetBrains.ReSharper.Psi.Services.StructuralSearch.IUnknownPlaceholder, JetBrains.Util.ICloneable<JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder>, System.ICloneable
    {
        public UnknownPlaceholder(string name) { }
        public string Description { get; }
        public string Name { get; }
        public JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder ReplacementCandidate { get; set; }
        public virtual string[] ReplacingText { get; }
        public System.Collections.Generic.ICollection<string> Words { get; }
        public JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder Clone() { }
        public JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholderMatcher CreateMatcher(JetBrains.ReSharper.Psi.Services.StructuralSearch.StructuralSearchPatternParams @params) { }
        public bool Equals(JetBrains.ReSharper.Psi.Services.StructuralSearch.Impl.UnknownPlaceholder other) { }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
        public JetBrains.ReSharper.Psi.Services.StructuralSearch.PlaceholderInfo ToPlaceholderInfo() { }
    }
}
namespace JetBrains.ReSharper.Psi.Services.ValueTracking.Engine
{
    
    public class ValueTrackingEngine
    {
        public ValueTrackingEngine(JetBrains.ReSharper.Psi.Services.ValueTracking.Engine.ValueTrackingSessionEnvinonment manager) { }
        public JetBrains.ReSharper.Psi.Services.ValueTracking.Engine.ValueTrackingSessionEnvinonment Session { get; }
        public void Expand(System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.IValueTrackingNode> nodes, JetBrains.Application.Progress.IProgressIndicator pi) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.ReSharper.Psi.Services.ValueTracking.Impl.IValueTrackingLanguageService GetLanguageService([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.PsiLanguageType language) { }
    }
    public class ValueTrackingNodesRepository
    {
        public ValueTrackingNodesRepository() { }
        [JetBrains.Annotations.NotNullAttribute()]
        public System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.IValueTrackingNode> GetNodesOfElement(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public void Register(JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.IValueTrackingNode node) { }
    }
    public class ValueTrackingSessionEnvinonment
    {
        public JetBrains.ReSharper.Psi.Services.ValueTracking.Engine.ValueTrackingEngine Engine { get; }
        public JetBrains.ReSharper.Psi.Services.ValueTracking.Engine.ValueTrackingNodesRepository NodesRespository { get; }
        public JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.IValueTrackingNode RootNode { get; }
        public string SessionTitle { get; }
        public JetBrains.ProjectModel.ISolution Solution { get; }
        public JetBrains.ReSharper.Psi.Services.CachingFinder ValueTrackingFindResultsCache { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Psi.Services.ValueTracking.Engine.ValueTrackingSessionEnvinonment CreateEnvoronmentFromContext(JetBrains.Application.DataContext.IDataContext context, JetBrains.ReSharper.Psi.Services.ValueTracking.Impl.ValueTrackingDirections trackingDirections, out string text, bool doCommit = True) { }
    }
}
namespace JetBrains.ReSharper.Psi.Services.ValueTracking.Impl
{
    
    public interface IValueTrackingCallStack
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Services.ValueTracking.Impl.IValueTrackingCallStack Parent { get; }
        JetBrains.ReSharper.Psi.ITreeNodePointer<JetBrains.ReSharper.Psi.Tree.IArgumentsOwner> Pointer { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Services.ValueTracking.Impl.IValueTrackingCallStack Push([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.IArgumentsOwner element);
    }
    public interface IValueTrackingLanguageService
    {
        JetBrains.ReSharper.Psi.IDeclaredElement GetElementFromExpression(JetBrains.ReSharper.Psi.Tree.IExpression expression);
        JetBrains.ReSharper.Psi.Services.ValueTracking.Presentation.IValueTrackingNodePresentation GetElementPresentation(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.Services.ValueTracking.Presentation.IExpressionPresentationStyle style);
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.IType GetOwnerType(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, JetBrains.Application.DataContext.IDataContext dataContext);
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.IValueTrackingNode NodeFromDeclaredElement(JetBrains.ReSharper.Psi.IDeclaredElement element, JetBrains.ReSharper.Psi.Services.ValueTracking.Impl.ValueTrackingDirections direction, JetBrains.ReSharper.Psi.Services.ValueTracking.Engine.ValueTrackingSessionEnvinonment session, JetBrains.ReSharper.Psi.Tree.IDeclaration declaration, JetBrains.ReSharper.Psi.IType ownerType, out string text);
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.IValueTrackingNode NodeFromExpression(JetBrains.ReSharper.Psi.Tree.IExpression expression, JetBrains.ReSharper.Psi.Services.ValueTracking.Impl.ValueTrackingDirections direction, JetBrains.ReSharper.Psi.Services.ValueTracking.Engine.ValueTrackingSessionEnvinonment envinonment);
    }
    public class ValueTrackingCallStack : JetBrains.ReSharper.Psi.Services.ValueTracking.Impl.IValueTrackingCallStack
    {
        public static JetBrains.ReSharper.Psi.Services.ValueTracking.Impl.IValueTrackingCallStack EmptyStack { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ReSharper.Psi.Services.ValueTracking.Impl.IValueTrackingCallStack Parent { get; }
        public JetBrains.ReSharper.Psi.ITreeNodePointer<JetBrains.ReSharper.Psi.Tree.IArgumentsOwner> Pointer { get; }
        public JetBrains.ReSharper.Psi.Services.ValueTracking.Impl.IValueTrackingCallStack Push(JetBrains.ReSharper.Psi.Tree.IArgumentsOwner owner) { }
    }
    public enum ValueTrackingDirections
    {
        Up = 0,
        Down = 1,
        Both = 2,
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.KnownLanguage))]
    public class ValueTrackingLanguageServiceBase : JetBrains.ReSharper.Psi.Services.ValueTracking.Impl.IValueTrackingLanguageService
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        public virtual JetBrains.ReSharper.Psi.Tree.IArgumentsOwner GetArgumentsOwner(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public virtual JetBrains.ReSharper.Psi.Tree.IExpression GetArgumentValue(JetBrains.ReSharper.Psi.Tree.IArgument argument) { }
        public virtual JetBrains.ReSharper.Psi.IDeclaredElement GetElementFromExpression(JetBrains.ReSharper.Psi.Tree.IExpression expression) { }
        public virtual JetBrains.ReSharper.Psi.Services.ValueTracking.Presentation.IValueTrackingNodePresentation GetElementPresentation(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.Services.ValueTracking.Presentation.IExpressionPresentationStyle style) { }
        public virtual JetBrains.ReSharper.Psi.IType GetOwnerType(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, JetBrains.Application.DataContext.IDataContext dataContext) { }
        public virtual JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.IValueTrackingNode NodeFromDeclaredElement(JetBrains.ReSharper.Psi.IDeclaredElement element, JetBrains.ReSharper.Psi.Services.ValueTracking.Impl.ValueTrackingDirections direction, JetBrains.ReSharper.Psi.Services.ValueTracking.Engine.ValueTrackingSessionEnvinonment session, JetBrains.ReSharper.Psi.Tree.IDeclaration declaration, JetBrains.ReSharper.Psi.IType ownerType, out string text) { }
        public virtual JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.IValueTrackingNode NodeFromExpression(JetBrains.ReSharper.Psi.Tree.IExpression expression, JetBrains.ReSharper.Psi.Services.ValueTracking.Impl.ValueTrackingDirections direction, JetBrains.ReSharper.Psi.Services.ValueTracking.Engine.ValueTrackingSessionEnvinonment envinonment) { }
    }
}
namespace JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes
{
    
    public class CompositePreExpandedNode : JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.IPreExpandedNode
    {
        public CompositePreExpandedNode(System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.IPreExpandedNode> nodes) { }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Psi.IDeclaredElement> ElementsToSearch { get; }
        public void AddReference(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.IDeclaredElement element) { }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.IValueTrackingNode> ExpandWithFindResults(JetBrains.Application.Progress.IProgressIndicator pi) { }
        public void InitNode(JetBrains.Application.Progress.SubProgressIndicator pi) { }
    }
    public interface IPreExpandedNode
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        System.Collections.Generic.IList<JetBrains.ReSharper.Psi.IDeclaredElement> ElementsToSearch { get; }
        void AddReference([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Resolve.IReference reference, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IDeclaredElement element);
        [JetBrains.Annotations.CanBeNullAttribute()]
        System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.IValueTrackingNode> ExpandWithFindResults(JetBrains.Application.Progress.IProgressIndicator pi);
        void InitNode(JetBrains.Application.Progress.SubProgressIndicator pi);
    }
    public interface IValueTrackingNode
    {
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Services.ValueTracking.Impl.IValueTrackingCallStack CallStack { get; }
        bool CanBeExpanded { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.IValueTrackingNode> Children { get; }
        JetBrains.ReSharper.Psi.Services.ValueTracking.Impl.ValueTrackingDirections Direction { get; }
        bool HasDuplicates { get; }
        bool IsPassThrough { get; }
        bool IsRecursive { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.IValueTrackingNode Parent { get; }
        JetBrains.ReSharper.Psi.Services.ValueTracking.Presentation.IValueTrackingNodePresentation Presentation { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Services.ValueTracking.Engine.ValueTrackingSessionEnvinonment Session { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Tree.ITreeNode SourceElement { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.IPreExpandedNode GetPreExpandedNode(JetBrains.Application.Progress.IProgressIndicator pi);
    }
    public interface IValueTrackingNodeImpl : JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.IValueTrackingNode, JetBrains.Util.IUserDataHolder
    {
        void AfterInitNode();
        void SetChilds([JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.IValueTrackingNode> childs);
        void SetHasDuplicates(bool hasDuplicates);
        void SetRecursive(bool isRecursive);
    }
    public abstract class NodeBase : JetBrains.Util.UserDataHolder, JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.IValueTrackingNode, JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.IValueTrackingNodeImpl, JetBrains.Util.IUserDataHolder
    {
        protected NodeBase(JetBrains.ReSharper.Psi.Services.ValueTracking.Engine.ValueTrackingSessionEnvinonment session, JetBrains.ReSharper.Psi.Services.ValueTracking.Impl.ValueTrackingDirections direction, JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.IValueTrackingNode parent, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.Services.ValueTracking.Impl.IValueTrackingCallStack callStack) { }
        public JetBrains.ReSharper.Psi.Services.ValueTracking.Impl.IValueTrackingCallStack CallStack { get; }
        public virtual bool CanBeExpanded { get; }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.IValueTrackingNode> Children { get; }
        public JetBrains.ReSharper.Psi.Services.ValueTracking.Impl.ValueTrackingDirections Direction { get; set; }
        public bool HasDuplicates { get; }
        public abstract bool IsPassThrough { get; }
        public bool IsRecursive { get; }
        public JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.IValueTrackingNode Parent { get; }
        public JetBrains.ReSharper.Psi.Services.ValueTracking.Presentation.IValueTrackingNodePresentation Presentation { get; set; }
        public JetBrains.ReSharper.Psi.Services.ValueTracking.Engine.ValueTrackingSessionEnvinonment Session { get; }
        public virtual JetBrains.ReSharper.Psi.Tree.ITreeNode SourceElement { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public abstract JetBrains.ReSharper.Psi.IType SourceType { get; }
        public virtual void AfterInitNode() { }
        protected virtual JetBrains.ReSharper.Psi.Services.ValueTracking.Presentation.IValueTrackingNodePresentation CreatePresentation(JetBrains.ReSharper.Psi.Services.ValueTracking.Presentation.IExpressionPresentationStyle style) { }
        public abstract JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.IPreExpandedNode GetPreExpandedNode(JetBrains.Application.Progress.IProgressIndicator pi);
        public void SetChilds([JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.IValueTrackingNode> childs) { }
        public void SetHasDuplicates(bool hasDuplicates) { }
        public void SetRecursive(bool isRecursive) { }
    }
    public class NodeFromPreExpandedNode : JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.NodeBase
    {
        public NodeFromPreExpandedNode(JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.PreExpandedNodeBase preExpandedNodeBase) { }
        public override bool IsPassThrough { get; }
        public override JetBrains.ReSharper.Psi.IType SourceType { get; }
        public override JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.IPreExpandedNode GetPreExpandedNode(JetBrains.Application.Progress.IProgressIndicator pi) { }
    }
    public abstract class PreExpandedNodeBase : JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.IPreExpandedNode
    {
        protected PreExpandedNodeBase(JetBrains.ReSharper.Psi.Services.ValueTracking.Engine.ValueTrackingSessionEnvinonment session, JetBrains.ReSharper.Psi.Services.ValueTracking.Impl.ValueTrackingDirections directions, JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.IValueTrackingNode parent, JetBrains.ReSharper.Psi.Services.ValueTracking.Impl.IValueTrackingCallStack stack) { }
        public JetBrains.ReSharper.Psi.Services.ValueTracking.Impl.IValueTrackingCallStack CallStack { get; }
        public JetBrains.ReSharper.Psi.Services.ValueTracking.Impl.ValueTrackingDirections Direction { get; }
        public abstract System.Collections.Generic.IList<JetBrains.ReSharper.Psi.IDeclaredElement> ElementsToSearch { get; }
        public JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.IValueTrackingNode Parent { get; }
        public JetBrains.ReSharper.Psi.Services.ValueTracking.Engine.ValueTrackingSessionEnvinonment Session { get; }
        public abstract void AddReference(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.IDeclaredElement element);
        public abstract System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.IValueTrackingNode> ExpandWithFindResults(JetBrains.Application.Progress.IProgressIndicator pi);
        public virtual void InitNode(JetBrains.Application.Progress.SubProgressIndicator pi) { }
    }
    public class PreExpandedWrapperNode : JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.IPreExpandedNode
    {
        public PreExpandedWrapperNode([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.IPreExpandedNode wrappedNode, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.WrapperNodeBase ownerNode) { }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Psi.IDeclaredElement> ElementsToSearch { get; }
        public void AddReference(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.IDeclaredElement element) { }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.IValueTrackingNode> ExpandWithFindResults(JetBrains.Application.Progress.IProgressIndicator pi) { }
        public void InitNode(JetBrains.Application.Progress.SubProgressIndicator pi) { }
    }
    public class TrivialPreExpandedNode : JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.IPreExpandedNode
    {
        public TrivialPreExpandedNode(System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.IValueTrackingNode> nodes) { }
        public TrivialPreExpandedNode(JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.IValueTrackingNode node) { }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Psi.IDeclaredElement> ElementsToSearch { get; }
        public void AddReference(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.IDeclaredElement element) { }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.IValueTrackingNode> ExpandWithFindResults(JetBrains.Application.Progress.IProgressIndicator pi) { }
        public void InitNode(JetBrains.Application.Progress.SubProgressIndicator pi) { }
    }
    public abstract class WrapperNodeBase : JetBrains.Util.UserDataHolder, JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.IValueTrackingNode, JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.IValueTrackingNodeImpl, JetBrains.Util.IUserDataHolder
    {
        protected WrapperNodeBase(JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.IValueTrackingNode wrappedNode, JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.IValueTrackingNode parent) { }
        public JetBrains.ReSharper.Psi.Services.ValueTracking.Impl.IValueTrackingCallStack CallStack { get; }
        public bool CanBeExpanded { get; }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.IValueTrackingNode> Children { get; }
        public JetBrains.ReSharper.Psi.Services.ValueTracking.Impl.ValueTrackingDirections Direction { get; }
        public bool HasDuplicates { get; }
        public virtual bool IsPassThrough { get; }
        public bool IsRecursive { get; }
        public JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.IValueTrackingNode Parent { get; }
        public JetBrains.ReSharper.Psi.Services.ValueTracking.Presentation.IValueTrackingNodePresentation Presentation { get; }
        public JetBrains.ReSharper.Psi.Services.ValueTracking.Engine.ValueTrackingSessionEnvinonment Session { get; }
        public JetBrains.ReSharper.Psi.Tree.ITreeNode SourceElement { get; }
        protected JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.IValueTrackingNode WrappedNode { get; }
        public virtual void AfterInitNode() { }
        protected virtual JetBrains.ReSharper.Psi.Services.ValueTracking.Presentation.IValueTrackingNodePresentation CreatePresentation(JetBrains.ReSharper.Psi.Services.ValueTracking.Presentation.IExpressionPresentationStyle style, JetBrains.UI.RichText.RichText innerPresentation) { }
        public virtual JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.IPreExpandedNode GetPreExpandedNode(JetBrains.Application.Progress.IProgressIndicator pi) { }
        public void SetChilds(System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.IValueTrackingNode> childs) { }
        public void SetHasDuplicates(bool hasDuplicates) { }
        public void SetRecursive(bool isRecursive) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public abstract JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.IValueTrackingNode WrapChild(JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.IValueTrackingNode childOfWrappedNode);
    }
}
namespace JetBrains.ReSharper.Psi.Services.ValueTracking.Presentation
{
    
    public class DefaultValueTrackingNodePresentation : JetBrains.ReSharper.Psi.Services.ValueTracking.Presentation.IValueTrackingNodePresentation
    {
        public DefaultValueTrackingNodePresentation(string lineText, int hiStart, int hiLength) { }
        public JetBrains.UI.Icons.IconId GetIconName() { }
        public JetBrains.UI.RichText.RichText GetPresentationRichText(JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.IValueTrackingNode node) { }
    }
    public class EmptyPresenter : JetBrains.ReSharper.Psi.Services.ValueTracking.Presentation.ValueTrackingGroupPresenterBase
    {
        public static readonly JetBrains.ReSharper.Psi.Services.ValueTracking.Presentation.IValueTrackingNodeGroupPresenter PresenterInstance;
        public override string Description { get; }
        protected override JetBrains.Util.Key<JetBrains.UI.RichText.RichText> PresenterKey { get; }
        protected override JetBrains.UI.RichText.RichText GetTextOfSourceElement(JetBrains.ReSharper.Psi.Tree.ITreeNode sourceElement) { }
        protected override JetBrains.UI.RichText.RichText PresentDeclaredElement(JetBrains.ReSharper.Psi.IDeclaredElement element) { }
    }
    public class ExpressionPresentationOnDemand : JetBrains.ReSharper.Psi.Services.ValueTracking.Presentation.IExpressionPresentationStyle
    {
        public ExpressionPresentationOnDemand() { }
        public JetBrains.UI.RichText.TextStyle HilightedTextStyle { get; set; }
        public JetBrains.UI.RichText.TextStyle PlaceholderStyle { get; set; }
        public JetBrains.UI.RichText.TextStyle TextStyle { get; set; }
        public JetBrains.UI.RichText.TextStyle WrapperHighlightedTextStyle { get; set; }
        public JetBrains.UI.RichText.TextStyle WrapperTextStyle { get; set; }
    }
    public class ExpressionPresentationStyle : JetBrains.ReSharper.Psi.Services.ValueTracking.Presentation.IExpressionPresentationStyle
    {
        public static JetBrains.ReSharper.Psi.Services.ValueTracking.Presentation.IExpressionPresentationStyle DefaultStyle;
        public JetBrains.UI.RichText.TextStyle HilightedTextStyle { get; }
        public JetBrains.UI.RichText.TextStyle PlaceholderStyle { get; }
        public JetBrains.UI.RichText.TextStyle TextStyle { get; }
        public JetBrains.UI.RichText.TextStyle WrapperHighlightedTextStyle { get; }
        public JetBrains.UI.RichText.TextStyle WrapperTextStyle { get; }
    }
    public class FileGroupPresenter : JetBrains.ReSharper.Psi.Services.ValueTracking.Presentation.ValueTrackingGroupPresenterBase
    {
        public static readonly JetBrains.ReSharper.Psi.Services.ValueTracking.Presentation.IValueTrackingNodeGroupPresenter PresenterInstance;
        public override string Description { get; }
        protected override JetBrains.Util.Key<JetBrains.UI.RichText.RichText> PresenterKey { get; }
        protected override JetBrains.UI.RichText.RichText GetTextOfSourceElement(JetBrains.ReSharper.Psi.Tree.ITreeNode sourceElement) { }
    }
    public interface IExpressionPresentationStyle
    {
        JetBrains.UI.RichText.TextStyle HilightedTextStyle { get; }
        JetBrains.UI.RichText.TextStyle PlaceholderStyle { get; }
        JetBrains.UI.RichText.TextStyle TextStyle { get; }
        JetBrains.UI.RichText.TextStyle WrapperHighlightedTextStyle { get; }
        JetBrains.UI.RichText.TextStyle WrapperTextStyle { get; }
    }
    public interface IValueTrackingNodeGroupPresenter
    {
        string Description { get; }
        JetBrains.UI.RichText.RichText Presentation(JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.IValueTrackingNode node);
    }
    public interface IValueTrackingNodePresentation
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.UI.Icons.IconId GetIconName();
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.UI.RichText.RichText GetPresentationRichText(JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.IValueTrackingNode node);
    }
    public class NamespaceGroupPresenter : JetBrains.ReSharper.Psi.Services.ValueTracking.Presentation.ValueTrackingGroupPresenterBase
    {
        public static readonly JetBrains.ReSharper.Psi.Services.ValueTracking.Presentation.IValueTrackingNodeGroupPresenter PresenterInstance;
        public override string Description { get; }
        protected override JetBrains.Util.Key<JetBrains.UI.RichText.RichText> PresenterKey { get; }
        protected override JetBrains.UI.RichText.RichText GetTextOfSourceElement(JetBrains.ReSharper.Psi.Tree.ITreeNode sourceElement) { }
    }
    public class NamespaceTypeGroupPresenter : JetBrains.ReSharper.Psi.Services.ValueTracking.Presentation.ValueTrackingGroupPresenterBase
    {
        public static readonly JetBrains.ReSharper.Psi.Services.ValueTracking.Presentation.IValueTrackingNodeGroupPresenter PresenterInstance;
        public override string Description { get; }
        protected override JetBrains.Util.Key<JetBrains.UI.RichText.RichText> PresenterKey { get; }
        protected override JetBrains.UI.RichText.RichText GetTextOfSourceElement(JetBrains.ReSharper.Psi.Tree.ITreeNode sourceElement) { }
    }
    public class NamespaceTypeMemberGroupPresenter : JetBrains.ReSharper.Psi.Services.ValueTracking.Presentation.ValueTrackingGroupPresenterBase
    {
        public static readonly JetBrains.ReSharper.Psi.Services.ValueTracking.Presentation.IValueTrackingNodeGroupPresenter PresenterInstance;
        public override string Description { get; }
        protected override JetBrains.Util.Key<JetBrains.UI.RichText.RichText> PresenterKey { get; }
        protected override JetBrains.UI.RichText.RichText GetTextOfSourceElement(JetBrains.ReSharper.Psi.Tree.ITreeNode sourceElement) { }
    }
    public class ProjectFolderFileGroupPresenter : JetBrains.ReSharper.Psi.Services.ValueTracking.Presentation.ValueTrackingGroupPresenterBase
    {
        public static readonly JetBrains.ReSharper.Psi.Services.ValueTracking.Presentation.IValueTrackingNodeGroupPresenter PresenterInstance;
        public override string Description { get; }
        protected override JetBrains.Util.Key<JetBrains.UI.RichText.RichText> PresenterKey { get; }
        protected override JetBrains.UI.RichText.RichText GetTextOfSourceElement(JetBrains.ReSharper.Psi.Tree.ITreeNode sourceElement) { }
    }
    public class ProjectFolderGroupPresenter : JetBrains.ReSharper.Psi.Services.ValueTracking.Presentation.ValueTrackingGroupPresenterBase
    {
        public static readonly JetBrains.ReSharper.Psi.Services.ValueTracking.Presentation.IValueTrackingNodeGroupPresenter PresenterInstance;
        public override string Description { get; }
        protected override JetBrains.Util.Key<JetBrains.UI.RichText.RichText> PresenterKey { get; }
        protected override JetBrains.UI.RichText.RichText GetTextOfSourceElement(JetBrains.ReSharper.Psi.Tree.ITreeNode sourceElement) { }
    }
    public class ProjectGroupPresenter : JetBrains.ReSharper.Psi.Services.ValueTracking.Presentation.ValueTrackingGroupPresenterBase
    {
        public static readonly JetBrains.ReSharper.Psi.Services.ValueTracking.Presentation.IValueTrackingNodeGroupPresenter PresenterInstance;
        public override string Description { get; }
        protected override JetBrains.Util.Key<JetBrains.UI.RichText.RichText> PresenterKey { get; }
        protected override JetBrains.UI.RichText.RichText GetTextOfSourceElement(JetBrains.ReSharper.Psi.Tree.ITreeNode sourceElement) { }
    }
    public class RichTextPresentation : JetBrains.ReSharper.Psi.Services.ValueTracking.Presentation.IValueTrackingNodePresentation
    {
        public RichTextPresentation(JetBrains.UI.RichText.RichText richText, JetBrains.UI.Icons.IconId iconName) { }
        public JetBrains.UI.Icons.IconId GetIconName() { }
        public JetBrains.UI.RichText.RichText GetPresentationRichText(JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.IValueTrackingNode node) { }
    }
    public class TrivialPresentation : JetBrains.ReSharper.Psi.Services.ValueTracking.Presentation.IValueTrackingNodePresentation
    {
        public TrivialPresentation(string text) { }
        public JetBrains.UI.Icons.IconId GetIconName() { }
        public JetBrains.UI.RichText.RichText GetPresentationRichText(JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.IValueTrackingNode node) { }
    }
    public class TypeAndMemberGroupPresenter : JetBrains.ReSharper.Psi.Services.ValueTracking.Presentation.ValueTrackingGroupPresenterBase
    {
        public static readonly JetBrains.ReSharper.Psi.Services.ValueTracking.Presentation.IValueTrackingNodeGroupPresenter PresenterInstance;
        public override string Description { get; }
        protected override JetBrains.Util.Key<JetBrains.UI.RichText.RichText> PresenterKey { get; }
        protected override JetBrains.UI.RichText.RichText GetTextOfSourceElement(JetBrains.ReSharper.Psi.Tree.ITreeNode sourceElement) { }
    }
    public class TypeGroupPresenter : JetBrains.ReSharper.Psi.Services.ValueTracking.Presentation.ValueTrackingGroupPresenterBase
    {
        public static readonly JetBrains.ReSharper.Psi.Services.ValueTracking.Presentation.IValueTrackingNodeGroupPresenter PresenterInstance;
        public override string Description { get; }
        protected override JetBrains.Util.Key<JetBrains.UI.RichText.RichText> PresenterKey { get; }
        protected override JetBrains.UI.RichText.RichText GetTextOfSourceElement(JetBrains.ReSharper.Psi.Tree.ITreeNode sourceElement) { }
        protected override JetBrains.UI.RichText.RichText PresentDeclaredElement(JetBrains.ReSharper.Psi.IDeclaredElement element) { }
    }
    public abstract class ValueTrackingGroupPresenterBase : JetBrains.ReSharper.Psi.Services.ValueTracking.Presentation.IValueTrackingNodeGroupPresenter
    {
        protected static readonly JetBrains.UI.RichText.TextStyle FirstPartStyle;
        protected static readonly JetBrains.UI.RichText.TextStyle SeconPartStyle;
        public abstract string Description { get; }
        protected abstract JetBrains.Util.Key<JetBrains.UI.RichText.RichText> PresenterKey { get; }
        protected abstract JetBrains.UI.RichText.RichText GetTextOfSourceElement(JetBrains.ReSharper.Psi.Tree.ITreeNode sourceElement);
        public JetBrains.UI.RichText.RichText Presentation(JetBrains.ReSharper.Psi.Services.ValueTracking.Nodes.IValueTrackingNode node) { }
        protected virtual JetBrains.UI.RichText.RichText PresentDeclaredElement(JetBrains.ReSharper.Psi.IDeclaredElement element) { }
        public override string ToString() { }
    }
}