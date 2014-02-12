[assembly: JetBrains.UI.Icons.CompiledIcons.CompiledIconsPackAttribute(IconNames=new string[] {
        "Settings",
        "Task",
        "Metadata",
        "UsingTask",
        "Stop",
        "AttributeRequired",
        "Element",
        "Fileset",
        "Run",
        "ItemGroup",
        "PropertyGroup",
        "Function",
        "Target",
        "Attribute"}, IconPackResourceIdentification="JetBrains.ReSharper.Psi.BuildScripts;component/icons/PsiBuildScriptsThemedIcons/T" +
    "hemedIcons.PsiBuildScripts.Generated.Xaml")]
[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]
[assembly: System.Windows.Markup.XmlnsDefinitionAttribute("urn:shemas-jetbrains-com:ui-application-icons-psi-build-scripts", "JetBrains.ReSharper.Psi.BuildScripts.Icons")]

namespace JetBrains.ReSharper.BuildScriptSupport.Searching
{
    
    public class ScriptReferenceSearcher<TLanguage> : JetBrains.ReSharper.Psi.ExtensionsAPI.IDomainSpecificSearcher
        where TLanguage : JetBrains.ReSharper.Psi.PsiLanguageType
    {
        public ScriptReferenceSearcher(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IDeclaredElement> elements, bool findCandidates) { }
        public bool ProcessElement<TResult>(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.Search.IFindResultConsumer<TResult> consumer) { }
        public bool ProcessProjectItem<TResult>(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, JetBrains.ReSharper.Psi.Search.IFindResultConsumer<TResult> consumer) { }
    }
}
namespace JetBrains.ReSharper.Psi.BuildScripts
{
    
    public class BuildScriptDeclaredElementPresenter : JetBrains.ReSharper.Psi.IDeclaredElementPresenter
    {
        public string Format(JetBrains.ReSharper.Psi.DeclaredElementPresenterStyle style, JetBrains.ReSharper.Psi.IDeclaredElement element, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution, out JetBrains.ReSharper.Psi.DeclaredElementPresenterMarking marking) { }
        public string Format(JetBrains.ReSharper.Psi.ParameterKind parameterKind) { }
        public string Format(JetBrains.ReSharper.Psi.AccessRights accessRights) { }
        protected virtual string GetElementTypeName(JetBrains.ReSharper.Psi.IDeclaredElement element) { }
    }
    public class BuildScriptDeclaredElementType : JetBrains.ReSharper.Psi.DeclaredElementType
    {
        public static readonly JetBrains.ReSharper.Psi.DeclaredElementType ATTRIBUTE;
        public static readonly JetBrains.ReSharper.Psi.DeclaredElementType TAG;
        protected BuildScriptDeclaredElementType(string presentableName, string name, JetBrains.UI.Icons.IconId imageName) { }
        protected override JetBrains.ReSharper.Psi.IDeclaredElementPresenter DefaultPresenter { get; }
        public override string PresentableName { get; }
        protected override JetBrains.UI.Icons.IconId GetImage() { }
        public virtual bool IsEqual(JetBrains.ReSharper.Psi.BuildScripts.BuildScriptDeclaredElementType type) { }
        public override bool IsPresentable(JetBrains.ReSharper.Psi.PsiLanguageType language) { }
        public override string ToString() { }
    }
    public class BuildScriptIconUtil
    {
        public static JetBrains.UI.Icons.IconId GetImage(JetBrains.UI.Icons.IconId imageName) { }
    }
    [JetBrains.ReSharper.Psi.LanguageDefinitionAttribute("BUILD_SCRIPT")]
    public class BuildScriptLanguage : JetBrains.ReSharper.Psi.Xml.XmlLanguage
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static readonly JetBrains.ReSharper.Psi.BuildScripts.BuildScriptLanguage Instance;
        public const string Name = "BUILD_SCRIPT";
        public BuildScriptLanguage() { }
        protected BuildScriptLanguage([JetBrains.Annotations.NotNullAttribute()] string name) { }
        protected BuildScriptLanguage([JetBrains.Annotations.NotNullAttribute()] string name, [JetBrains.Annotations.NotNullAttribute()] string presentableName) { }
    }
    public abstract class BuildScriptLanguageServiceBase : JetBrains.ReSharper.Psi.Xml.XmlLanguageService
    {
        protected BuildScriptLanguageServiceBase(JetBrains.ReSharper.Psi.Xml.XmlLanguage languageType, JetBrains.ReSharper.Psi.IConstantValueService constantValueService, JetBrains.ReSharper.Psi.Parsing.XmlTokenTypes tokenTypes, JetBrains.ReSharper.Psi.Xml.Parsing.IXmlElementFactory elementFactory, JetBrains.ReSharper.Psi.Xml.Impl.CodeStyle.XmlCodeFormatter codeFormatter, JetBrains.ReSharper.Psi.Util.CommonIdentifierIntern commonIdentifierIntern) { }
        public abstract JetBrains.ReSharper.Psi.BuildScripts.DeclaredElementFinder CreateDeclaredElementFinder(JetBrains.ProjectModel.ISolution solution);
        public abstract JetBrains.ReSharper.Psi.BuildScripts.InclusionEngine.IBuildScriptFileExecutorBase GetBuildScriptExecutor();
        public abstract JetBrains.ReSharper.Psi.BuildScripts.ICommonElementProvider GetCommonElementProvider(JetBrains.ProjectModel.ISolution solution);
        public abstract JetBrains.ReSharper.Psi.BuildScripts.IDeclarationFinder GetDeclarationFinder();
        public abstract string GetDefaultTargetAttributeName();
        public abstract string GetProjectAttributeName();
        public abstract JetBrains.ReSharper.Psi.BuildScripts.ValueEvaluator GetValueEvaluator();
    }
    public abstract class BuildScriptModule : JetBrains.ReSharper.Psi.Modules.IPsiModule
    {
        protected BuildScriptModule(JetBrains.ProjectModel.ISolution solution) { }
        public JetBrains.ProjectModel.IModule ContainingProjectModule { get; }
        public abstract string DisplayName { get; }
        public abstract string Name { get; }
        public abstract JetBrains.ProjectModel.ProjectFileType ProjectFileType { get; }
        public abstract JetBrains.ReSharper.Psi.PsiLanguageType PsiLanguage { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IPsiSourceFile> SourceFiles { get; }
        public System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.PreProcessingDirective> GetAllDefines() { }
        public abstract string GetPersistentID();
        public JetBrains.ReSharper.Psi.IPsiServices GetPsiServices() { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IPsiSourceFile> GetPsiSourceFileFor(JetBrains.ProjectModel.IProjectFile projectFile) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Modules.IPsiModuleReference> GetReferences(JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext moduleReferenceResolveContext) { }
        public JetBrains.ProjectModel.ISolution GetSolution() { }
        public bool IsValid() { }
        public void RemoveMapping(JetBrains.ProjectModel.IProjectFile projectFile) { }
        public JetBrains.ReSharper.Psi.IPsiSourceFile SetMapping(JetBrains.ProjectModel.IProjectFile projectFile) { }
    }
    public class static BuildScriptNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Psi.BuildScripts.Tree.IBuildScriptTag GetByAttribute([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.BuildScripts.Tree.IBuildScriptAttribute attribute) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Psi.BuildScripts.Tree.IBuildScriptTag GetByTag([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.BuildScripts.Tree.IBuildScriptTag tag) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Psi.BuildScripts.Tree.IBuildScriptAttribute GetByToken([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken token) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Psi.BuildScripts.Tree.IBuildFile GetFileByElement([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Psi.BuildScripts.Tree.IBuildFile GetFileByTag([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.BuildScripts.Tree.IBuildScriptTag tag) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Psi.BuildScripts.Tree.IBuildFile GetFileByToken([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken token) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Psi.BuildScripts.Tree.IBuildScriptTag GetTagByFooterIdentifier([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken token) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Psi.BuildScripts.Tree.IBuildScriptTag GetTagByHeaderIdentifier([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken token) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Psi.BuildScripts.Tree.IBuildScriptTag GetTagByToken([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken token) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Collections.Generic.List<T> LookupAllChildItems<T>(JetBrains.ReSharper.Psi.BuildScripts.Tree.IBuildFile file) { }
        public static System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.BuildScripts.Tree.BuildScriptTagBase> LookupAllImportTags(JetBrains.ReSharper.Psi.BuildScripts.Tree.IBuildFile file) { }
    }
    public abstract class BuildScriptPsiModuleProvider : JetBrains.ReSharper.Psi.Modules.IMiscFilesProjectPsiModuleProvider, System.IDisposable
    {
        protected abstract JetBrains.ReSharper.Psi.BuildScripts.BuildScriptModule Module { get; }
        public void Dispose() { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Modules.IPsiModule> GetModules() { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IPsiSourceFile> GetPsiSourceFilesFor(JetBrains.ProjectModel.IProjectFile projectFile) { }
        public void OnProjectFileChanged(JetBrains.ProjectModel.IProjectFile projectFile, JetBrains.ReSharper.Psi.Modules.PsiModuleChange.ChangeType changeType, JetBrains.ReSharper.Psi.Modules.PsiModuleChangeBuilder changeBuilder, JetBrains.Util.FileSystemPath oldLocation) { }
    }
    public class BuildScriptSourceFileProperties : JetBrains.ReSharper.Psi.IPsiSourceFileProperties
    {
        public bool IsGeneratedFile { get; }
        public bool IsICacheParticipant { get; }
        public bool IsNonUserFile { get; }
        public bool ProvidesCodeModel { get; }
        public bool ShouldBuildPsi { get; }
        public string GetDefaultNamespace() { }
        public System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.PreProcessingDirective> GetDefines() { }
        public System.Collections.Generic.IEnumerable<string> GetPreImportedNamespaces() { }
    }
    public abstract class DeclaredElementFinder
    {
        protected DeclaredElementFinder(JetBrains.ProjectModel.ISolution solution) { }
        public System.Collections.Generic.Dictionary<string, JetBrains.ReSharper.Psi.IDeclaredElement> DeclaredElements { get; set; }
        public System.Collections.Generic.Dictionary<string, JetBrains.ReSharper.Psi.IDeclaredElement> InitialDeclaredElements { get; set; }
        public System.Collections.Generic.Dictionary<string, JetBrains.ReSharper.Psi.IDeclaredElement> SkippedDeclaredElements { get; set; }
        public JetBrains.ProjectModel.ISolution Solution { get; }
        protected abstract JetBrains.ReSharper.Psi.IDeclaredElement CreatePropertyDeclaredElement(string name, JetBrains.ProjectModel.ISolution solution);
        public abstract void ProcessAttribute(JetBrains.ReSharper.Psi.BuildScripts.Tree.BuildScriptAttributeBase attribute, JetBrains.ReSharper.Psi.BuildScripts.InclusionEngine.BuildScriptNode node);
        public void ProcessExternalPropertiesElement(JetBrains.ReSharper.Psi.BuildScripts.Tree.ExternalPropertiesElement element, JetBrains.ReSharper.Psi.BuildScripts.InclusionEngine.BuildScriptNode node) { }
        public abstract void ProcessTag(JetBrains.ReSharper.Psi.BuildScripts.Tree.BuildScriptTagBase tag, JetBrains.ReSharper.Psi.BuildScripts.InclusionEngine.BuildScriptNode node);
    }
    public interface ICommonElementProvider
    {
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IDeclaredElement> GetAllCommonElements(JetBrains.ReSharper.Psi.IPsiSourceFile file);
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.IDeclaredElement GetCommonElement(string name, JetBrains.ReSharper.Psi.DeclaredElementType expectedType, JetBrains.ReSharper.Psi.IPsiSourceFile file);
        bool IsCommonElement(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement);
    }
    public interface IDeclarationFinder
    {
        System.Collections.Generic.List<JetBrains.ReSharper.Psi.Tree.IDeclaration> FindAllDeclarations(JetBrains.ReSharper.Psi.BuildScripts.Tree.BuildScriptFileBase file);
        System.Collections.Generic.List<JetBrains.ReSharper.Psi.Tree.IDeclaration> FindDeclarationsBefore(JetBrains.ReSharper.Psi.BuildScripts.Tree.BuildScriptFileBase file, JetBrains.ReSharper.Psi.TreeTextRange range);
    }
    public interface ITask { }
    public class static PathUtil
    {
        public static string GetDirectoryPath(JetBrains.ReSharper.Psi.BuildScripts.Tree.IBuildScriptAttribute attribute, JetBrains.Util.FileSystemPath baseDir) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static System.Collections.Generic.List<string> GetFilePath(JetBrains.ReSharper.Psi.BuildScripts.Tree.IBuildScriptAttribute attribute, JetBrains.Util.FileSystemPath baseDir) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.Util.FileSystemPath GetFilePath(JetBrains.ReSharper.Psi.BuildScripts.Tree.IBuildFile file) { }
        public static JetBrains.ReSharper.Psi.Tree.IFile GetImportedFile(JetBrains.ReSharper.Psi.BuildScripts.Tree.BuildScriptFileBase thisFile, JetBrains.ReSharper.Psi.BuildScripts.InclusionEngine.CommonExecutionContext context, JetBrains.Util.FileSystemPath path) { }
        public static JetBrains.ReSharper.Psi.Tree.IFile GetImportedFile(JetBrains.ProjectModel.IProject project, JetBrains.Util.FileSystemPath path, JetBrains.ReSharper.Psi.LanguageService languageService) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static string GetImportedPath(JetBrains.ReSharper.Psi.BuildScripts.InclusionEngine.IInclusionTag inclusionTag, System.Predicate<string> extensionCheck) { }
    }
    public abstract class PredefinedItemsBase
    {
        public abstract System.Collections.Generic.IList<string> GetPredefinedPropertyValue(string propertyName, JetBrains.Util.FileSystemPath fileLocation, string projectName, string defaultTargets);
        public abstract bool IsPredefined(string tagName);
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class ReferenceManager : JetBrains.Application.IChangeProvider
    {
        public ReferenceManager(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Psi.Modules.IPsiModules psiModules, JetBrains.DocumentManagers.DocumentManager documentManager, JetBrains.ReSharper.Psi.Files.PsiFiles psiFiles, JetBrains.ReSharper.Psi.BuildScripts.InclusionEngine.BuildScriptManager buildScriptManager, JetBrains.Application.ChangeManager changeManager, JetBrains.DocumentModel.Impl.DocumentChangeManager documentChangeManager, JetBrains.DocumentManagers.SolutionDocumentChangeProvider solutionDocumentChangeProvider) { }
        public event System.Action<JetBrains.ReSharper.Psi.IDeclaredElement> BuildScriptDeclaredElementRemoved;
        public event System.Action<JetBrains.ReSharper.Psi.BuildScripts.Declarations.IBuildScriptDeclaration, JetBrains.ReSharper.Psi.BuildScripts.DeclaredElements.BuildScriptDeclaredElementBase> BuildScriptDeclaredElementUpdated;
        public void AddDeclaredElement(JetBrains.ReSharper.Psi.Tree.IFile file, JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
        public void BuildDeclaredElements(JetBrains.ReSharper.Psi.BuildScripts.InclusionEngine.BuildScriptGraph graph) { }
        public void ChangeDeclaredElementName(JetBrains.ReSharper.Psi.IDeclaredElement element, string newName) { }
        public void Clear() { }
        public void ClearFileDeclarations(JetBrains.ReSharper.Psi.Tree.IFile file) { }
        public void ClearFileDeclaredElements(JetBrains.ReSharper.Psi.Tree.IFile file, JetBrains.Util.OneToSetMap<string, JetBrains.ReSharper.Psi.IDeclaredElement> elementsFound) { }
        public object Execute(JetBrains.Application.IChangeMap changeMap) { }
        public System.Collections.Generic.JetHashSet<JetBrains.ReSharper.Psi.IDeclaredElement> GetAllDeclaredElements(JetBrains.ReSharper.Psi.BuildScripts.Tree.BuildScriptFileBase file) { }
        public System.Collections.Generic.JetHashSet<JetBrains.ReSharper.Psi.IDeclaredElement> GetAllDeclaredElementsOfType(JetBrains.ReSharper.Psi.BuildScripts.Tree.IBuildFile file, JetBrains.ReSharper.Psi.DeclaredElementType type) { }
        public System.Collections.Generic.List<JetBrains.ReSharper.Psi.BuildScripts.Tree.BuildScriptFileBase> GetDeclaredElementFiles(JetBrains.ReSharper.Psi.IDeclaredElement element) { }
        public JetBrains.ReSharper.Psi.IDeclaredElement GetDeclaredElementOfType(JetBrains.ReSharper.Psi.BuildScripts.Tree.BuildScriptFileBase file, JetBrains.ReSharper.Psi.DeclaredElementType type, string name) { }
        public static JetBrains.ReSharper.Psi.BuildScripts.ReferenceManager GetInstance(JetBrains.ProjectModel.ISolution solution) { }
        public void OnBuildScriptDeclaredElementUpdated(JetBrains.ReSharper.Psi.BuildScripts.Declarations.IBuildScriptDeclaration declaration, JetBrains.ReSharper.Psi.BuildScripts.DeclaredElements.BuildScriptDeclaredElementBase declaredElement) { }
        public void UpdateDeclaredElement(JetBrains.ReSharper.Psi.BuildScripts.Declarations.IBuildScriptDeclaration declaration, JetBrains.ReSharper.Psi.BuildScripts.DeclaredElements.BuildScriptDeclaredElementBase element) { }
        public void UpdateDeclaredElement(JetBrains.ReSharper.Psi.BuildScripts.Declarations.IBuildScriptDeclaration declaration) { }
    }
    public abstract class ReferencesManagerBase
    {
        public abstract void IgnoreProperty(string propertyName, JetBrains.ReSharper.Psi.BuildScripts.Tree.BuildScriptFileBase file);
    }
    public class static ScriptUtil
    {
        public static T FindChildNode<T>(JetBrains.ReSharper.Psi.Tree.ITreeNode node)
            where T :  class { }
        public static string GetDefaultTargets(JetBrains.ReSharper.Psi.BuildScripts.Tree.BuildScriptFileBase file) { }
        public static string GetProjectName(JetBrains.ReSharper.Psi.BuildScripts.Tree.BuildScriptFileBase file) { }
        public static JetBrains.ReSharper.Psi.BuildScripts.Tree.BuildScriptFileBase GetPsiFile(JetBrains.ProjectModel.ISolution solution, JetBrains.DocumentModel.DocumentRange range) { }
        public static bool IsValidPropertyName(string name) { }
        public static bool IsValidTargetName(string name) { }
    }
    public abstract class ValueEvaluator
    {
        protected ValueEvaluator() { }
        public System.Collections.Generic.IList<string> GetAllPossibleValues(JetBrains.ReSharper.Psi.BuildScripts.Tree.IBuildScriptAttribute attribute) { }
        public System.Collections.Generic.IList<string> GetAllPossibleValues(JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeElement property) { }
        public static System.Collections.Generic.IList<string> GetAllPossibleValues(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
        protected abstract System.Collections.Generic.IList<string> GetPredefinedPropertyValues(JetBrains.ReSharper.Psi.BuildScripts.References.ScriptReferenceBase reference, JetBrains.ReSharper.Psi.BuildScripts.Tree.BuildScriptFileBase file);
        protected abstract bool IsPredefinedProperty(JetBrains.ReSharper.Psi.BuildScripts.References.ScriptReferenceBase reference);
    }
}
namespace JetBrains.ReSharper.Psi.BuildScripts.Declarations
{
    
    public abstract class ExternalPropertyDeclaration : JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeElement, JetBrains.ReSharper.Psi.BuildScripts.Declarations.IBuildScriptDeclaration, JetBrains.ReSharper.Psi.BuildScripts.Declarations.IPropertyDeclaration, JetBrains.ReSharper.Psi.Tree.IDeclaration, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Tree.IXmlDocOwnerTreeNode
    {
        protected ExternalPropertyDeclaration(string name, JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType nodeType) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Psi.IDeclaredElement DeclaredElement { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public string DeclaredName { get; }
        public bool IsDeclarationValid { get; }
        public override JetBrains.ReSharper.Psi.PsiLanguageType Language { get; }
        public override JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType NodeType { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public string PropertyName { get; }
        public JetBrains.ProjectModel.ISolution Solution { get; set; }
        public abstract JetBrains.ReSharper.Psi.BuildScripts.DeclaredElements.BuildScriptDeclaredElementBase CreateDeclaredElement(System.Collections.Generic.JetHashSet<JetBrains.ReSharper.Psi.BuildScripts.InclusionEngine.BuildScriptNode> nodes, JetBrains.ProjectModel.ISolution solution);
        public abstract JetBrains.ReSharper.Psi.DeclaredElementType GetElementType();
        public JetBrains.ReSharper.Psi.TreeTextRange GetNameRange() { }
        public System.Collections.Generic.IList<string> GetValues() { }
        public System.Xml.XmlNode GetXMLDoc(bool inherit) { }
        public void InitReference(JetBrains.ReSharper.Psi.BuildScripts.Tree.BuildScriptFileBase file) { }
        public bool IsSynthetic() { }
        public void SetDeclaredElement(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
        public void SetName(string name) { }
    }
    public abstract class ExternalPropertyDeclarationNodeType : JetBrains.ReSharper.Psi.BuildScripts.Tree.BuildScriptNodeType
    {
        protected ExternalPropertyDeclarationNodeType(string name, JetBrains.ReSharper.Psi.Xml.Tree.XmlElementTypes xmlElementTypes, int index) { }
    }
    public interface IBuildScriptDeclaration : JetBrains.ReSharper.Psi.Tree.IDeclaration, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Tree.IXmlDocOwnerTreeNode
    {
        bool IsDeclarationValid { get; }
        JetBrains.ProjectModel.ISolution Solution { get; set; }
        JetBrains.ReSharper.Psi.BuildScripts.DeclaredElements.BuildScriptDeclaredElementBase CreateDeclaredElement(System.Collections.Generic.JetHashSet<JetBrains.ReSharper.Psi.BuildScripts.InclusionEngine.BuildScriptNode> nodes, JetBrains.ProjectModel.ISolution solution);
        JetBrains.ReSharper.Psi.DeclaredElementType GetElementType();
        void InitReference(JetBrains.ReSharper.Psi.BuildScripts.Tree.BuildScriptFileBase file);
        void SetDeclaredElement(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement);
    }
    public interface IPropertyDeclaration
    {
        string PropertyName { get; }
        System.Collections.Generic.IList<string> GetValues();
    }
}
namespace JetBrains.ReSharper.Psi.BuildScripts.DeclaredElements
{
    
    public abstract class BuildScriptDeclaredElementBase : JetBrains.ReSharper.Psi.IDeclaredElement
    {
        protected BuildScriptDeclaredElementBase(string name, System.Collections.Generic.JetHashSet<JetBrains.ReSharper.Psi.BuildScripts.InclusionEngine.BuildScriptNode> nodes, JetBrains.ProjectModel.ISolution solution) { }
        public bool CaseSensistiveName { get; }
        public abstract JetBrains.ReSharper.Psi.PsiLanguageType PresentationLanguage { get; }
        public string ShortName { get; }
        public void AddContainingNode(JetBrains.ReSharper.Psi.BuildScripts.InclusionEngine.BuildScriptNode node) { }
        public void AddDeclaration(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration, JetBrains.ReSharper.Psi.BuildScripts.InclusionEngine.BuildScriptNode node) { }
        public void ClearContainingNodes() { }
        public void ContainedInNode(JetBrains.ReSharper.Psi.BuildScripts.InclusionEngine.BuildScriptNode node) { }
        public JetBrains.ReSharper.Psi.BuildScripts.InclusionEngine.BuildScriptNode[] GetContainingNodes() { }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Tree.IDeclaration> GetDeclarations() { }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Tree.IDeclaration> GetDeclarationsIn(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
        public abstract JetBrains.ReSharper.Psi.DeclaredElementType GetElementType();
        public JetBrains.ReSharper.Psi.IPsiServices GetPsiServices() { }
        public JetBrains.Util.DataStructures.HybridCollection<JetBrains.ReSharper.Psi.IPsiSourceFile> GetSourceFiles() { }
        public System.Xml.XmlNode GetXMLDescriptionSummary(bool inherit) { }
        public System.Xml.XmlNode GetXMLDoc(bool inherit) { }
        public bool HasDeclarationsIn(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
        public bool IsSynthetic() { }
        public bool IsValid() { }
        public void NotContainedInNode(JetBrains.ReSharper.Psi.BuildScripts.InclusionEngine.BuildScriptNode node) { }
        public void RemoveDeclarations(JetBrains.Util.FileSystemPath filePath) { }
        public void SetName(string name) { }
        public override string ToString() { }
        public void UpdateDeclarations(JetBrains.DocumentModel.DocumentChange documentChange, JetBrains.ReSharper.Psi.BuildScripts.InclusionEngine.BuildScriptNode node) { }
    }
    public abstract class PropertyDeclaredElement : JetBrains.ReSharper.Psi.BuildScripts.DeclaredElements.BuildScriptDeclaredElementBase
    {
        protected PropertyDeclaredElement(string name, System.Collections.Generic.JetHashSet<JetBrains.ReSharper.Psi.BuildScripts.InclusionEngine.BuildScriptNode> nodes, JetBrains.ProjectModel.ISolution solution) { }
    }
    public abstract class TargetDeclaredElement : JetBrains.ReSharper.Psi.BuildScripts.DeclaredElements.BuildScriptDeclaredElementBase
    {
        protected TargetDeclaredElement(string name, System.Collections.Generic.JetHashSet<JetBrains.ReSharper.Psi.BuildScripts.InclusionEngine.BuildScriptNode> nodes, JetBrains.ProjectModel.ISolution solution) { }
    }
}
namespace JetBrains.ReSharper.Psi.BuildScripts.Icons
{
    
    public sealed class PsiBuildScriptsThemedIcons
    {
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Psi.BuildScripts;component/icons/PsiBuildScriptsThemedIcons/T" +
            "hemedIcons.PsiBuildScripts.Generated.Xaml", 13, "Attribute")]
        public sealed class Attribute : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Psi.BuildScripts;component/icons/PsiBuildScriptsThemedIcons/T" +
            "hemedIcons.PsiBuildScripts.Generated.Xaml", 5, "AttributeRequired")]
        public sealed class AttributeRequired : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Psi.BuildScripts;component/icons/PsiBuildScriptsThemedIcons/T" +
            "hemedIcons.PsiBuildScripts.Generated.Xaml", 6, "Element")]
        public sealed class Element : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Psi.BuildScripts;component/icons/PsiBuildScriptsThemedIcons/T" +
            "hemedIcons.PsiBuildScripts.Generated.Xaml", 7, "Fileset")]
        public sealed class Fileset : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Psi.BuildScripts;component/icons/PsiBuildScriptsThemedIcons/T" +
            "hemedIcons.PsiBuildScripts.Generated.Xaml", 11, "Function")]
        public sealed class Function : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Psi.BuildScripts;component/icons/PsiBuildScriptsThemedIcons/T" +
            "hemedIcons.PsiBuildScripts.Generated.Xaml", 9, "ItemGroup")]
        public sealed class ItemGroup : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Psi.BuildScripts;component/icons/PsiBuildScriptsThemedIcons/T" +
            "hemedIcons.PsiBuildScripts.Generated.Xaml", 2, "Metadata")]
        public sealed class Metadata : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Psi.BuildScripts;component/icons/PsiBuildScriptsThemedIcons/T" +
            "hemedIcons.PsiBuildScripts.Generated.Xaml", 10, "PropertyGroup")]
        public sealed class PropertyGroup : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Psi.BuildScripts;component/icons/PsiBuildScriptsThemedIcons/T" +
            "hemedIcons.PsiBuildScripts.Generated.Xaml", 8, "Run")]
        public sealed class Run : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Psi.BuildScripts;component/icons/PsiBuildScriptsThemedIcons/T" +
            "hemedIcons.PsiBuildScripts.Generated.Xaml", 0, "Settings")]
        public sealed class Settings : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Psi.BuildScripts;component/icons/PsiBuildScriptsThemedIcons/T" +
            "hemedIcons.PsiBuildScripts.Generated.Xaml", 4, "Stop")]
        public sealed class Stop : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Psi.BuildScripts;component/icons/PsiBuildScriptsThemedIcons/T" +
            "hemedIcons.PsiBuildScripts.Generated.Xaml", 12, "Target")]
        public sealed class Target : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Psi.BuildScripts;component/icons/PsiBuildScriptsThemedIcons/T" +
            "hemedIcons.PsiBuildScripts.Generated.Xaml", 1, "Task")]
        public sealed class Task : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Psi.BuildScripts;component/icons/PsiBuildScriptsThemedIcons/T" +
            "hemedIcons.PsiBuildScripts.Generated.Xaml", 3, "UsingTask")]
        public sealed class UsingTask : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
    }
}
namespace JetBrains.ReSharper.Psi.BuildScripts.InclusionEngine
{
    
    [JetBrains.ReSharper.Psi.PsiComponentAttribute()]
    public class BuildScriptCache : JetBrains.ReSharper.Psi.Caches.ICache
    {
        public BuildScriptCache(JetBrains.Application.IShellLocks locks, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Psi.IPsiConfiguration psiConfiguration, JetBrains.ReSharper.Psi.Caches.IPersistentIndexManager persistentIndexManager) { }
        public System.Collections.Generic.Dictionary<JetBrains.ReSharper.Psi.IPsiSourceFile, JetBrains.ReSharper.Psi.BuildScripts.InclusionEngine.BuildScriptCacheData> CachedData { get; }
        public JetBrains.ReSharper.Psi.BuildScripts.InclusionEngine.BuildScriptGraph Graph { get; }
        public JetBrains.ReSharper.Psi.BuildScripts.InclusionEngine.BuildScriptGraph GraphNoCheck { get; }
        public bool HasDirtyFiles { get; }
        public bool IsUpToDate { get; }
        public object Build(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, bool isStartup) { }
        public void CheckBuildScriptGraph() { }
        public void Clear() { }
        public void Drop(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
        public void Merge(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, object builtPart) { }
        public void OnDocumentChange(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, JetBrains.DocumentManagers.impl.ProjectFileDocumentCopyChange args) { }
        public void OnPsiChange(JetBrains.ReSharper.Psi.Tree.ITreeNode elementContainingChanges, JetBrains.ReSharper.Psi.PsiChangedElementType type) { }
        public void SyncUpdate(bool underTransaction) { }
        public bool UpToDate(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
    }
    public class BuildScriptCacheData
    {
        public BuildScriptCacheData() { }
        public BuildScriptCacheData(JetBrains.Util.OneToSetMap<JetBrains.ReSharper.Psi.TreeTextRange, JetBrains.Util.FileSystemPath> data) { }
        public JetBrains.Util.OneToSetMap<JetBrains.ReSharper.Psi.TreeTextRange, JetBrains.Util.FileSystemPath> RangeToFileIdMapping { get; }
    }
    public class BuildScriptEdge : System.IEquatable<JetBrains.ReSharper.Psi.BuildScripts.InclusionEngine.BuildScriptEdge>
    {
        public JetBrains.ReSharper.Psi.TreeTextRange Range { get; set; }
        public JetBrains.ReSharper.Psi.BuildScripts.InclusionEngine.BuildScriptNode Source { get; set; }
        public JetBrains.ReSharper.Psi.BuildScripts.InclusionEngine.BuildScriptNode Target { get; set; }
        public bool Equals(JetBrains.ReSharper.Psi.BuildScripts.InclusionEngine.BuildScriptEdge buildScriptEdge) { }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
        public override string ToString() { }
    }
    public class BuildScriptFinder : JetBrains.ProjectModel.RecursiveProjectVisitor
    {
        public BuildScriptFinder(System.Collections.Generic.IEnumerable<string> fileExtensionsToSkip) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ProjectModel.IProjectFile> Find(JetBrains.ProjectModel.ISolution solution) { }
        public override void VisitProjectFile(JetBrains.ProjectModel.IProjectFile projectFile) { }
    }
    public class BuildScriptGraph
    {
        public BuildScriptGraph(JetBrains.ProjectModel.ISolution solution) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Psi.BuildScripts.InclusionEngine.BuildScriptNode this[JetBrains.Util.FileSystemPath filePath] { get; }
        public System.Collections.Generic.List<JetBrains.ReSharper.Psi.BuildScripts.InclusionEngine.BuildScriptNode> Nodes { get; }
        public void Build(JetBrains.ReSharper.Psi.BuildScripts.InclusionEngine.BuildScriptFinder finder, JetBrains.ReSharper.Psi.BuildScripts.InclusionEngine.BuildScriptCache buildScriptCache) { }
        public void DeleteSandboxedFiles() { }
        public JetBrains.ReSharper.Psi.BuildScripts.InclusionEngine.BuildScriptNode GetNode(JetBrains.Util.FileSystemPath filePath, JetBrains.ProjectModel.IProject project, JetBrains.ReSharper.Psi.LanguageService languageService) { }
        public bool IsUpToDate(JetBrains.ProjectModel.IProjectFile file) { }
        public void UpdateForProjectFile(JetBrains.ProjectModel.IProjectFile projectFile) { }
    }
    [JetBrains.ReSharper.Psi.PsiComponentAttribute()]
    public class BuildScriptManager
    {
        public BuildScriptManager(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Psi.BuildScripts.InclusionEngine.BuildScriptCache cache) { }
        public JetBrains.ReSharper.Psi.BuildScripts.InclusionEngine.BuildScriptGraph Graph { get; }
        public JetBrains.ReSharper.Psi.BuildScripts.InclusionEngine.BuildScriptGraph GraphNoCheck { get; }
        public void Clear() { }
        public System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.IDeclaredElement> GetInclusionDeclaredElementsForFile(JetBrains.ReSharper.Psi.BuildScripts.Tree.BuildScriptFileBase file) { }
        public System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.BuildScripts.Tree.BuildScriptFileBase> GetInclusionFiles(JetBrains.ReSharper.Psi.BuildScripts.Tree.BuildScriptFileBase file) { }
        public static JetBrains.ReSharper.Psi.BuildScripts.InclusionEngine.BuildScriptManager GetInstance(JetBrains.ProjectModel.ISolution solution) { }
        public System.Collections.Generic.JetHashSet<JetBrains.ReSharper.Psi.IDeclaredElement> GetVisibleDeclaredElementsForFile(JetBrains.ReSharper.Psi.BuildScripts.Tree.BuildScriptFileBase file) { }
    }
    public abstract class BuildScriptNode
    {
        protected readonly JetBrains.ReSharper.Psi.LanguageService myLanguageService;
        protected BuildScriptNode(JetBrains.Util.FileSystemPath filePath, string id, JetBrains.ReSharper.Psi.LanguageService languageService) { }
        public JetBrains.Util.FileSystemPath FilePath { get; set; }
        public string ID { get; }
        public System.Collections.Generic.JetHashSet<JetBrains.ReSharper.Psi.BuildScripts.InclusionEngine.BuildScriptEdge> IncomingEdges { get; }
        public JetBrains.Util.OneToSetMap<JetBrains.ReSharper.Psi.TreeTextRange, JetBrains.ReSharper.Psi.BuildScripts.InclusionEngine.BuildScriptEdge> OutgoingEdges { get; }
        public abstract JetBrains.ReSharper.Psi.BuildScripts.Tree.BuildScriptFileBase GetFile();
        public bool PointsToNode(JetBrains.ReSharper.Psi.BuildScripts.InclusionEngine.BuildScriptNode node) { }
    }
    public class BuildScriptNonProjectFileNode : JetBrains.ReSharper.Psi.BuildScripts.InclusionEngine.BuildScriptNode
    {
        public BuildScriptNonProjectFileNode(JetBrains.Util.FileSystemPath filePath, string id, JetBrains.ReSharper.Psi.LanguageService languageService, JetBrains.ProjectModel.ISolution solution) { }
        public JetBrains.ProjectModel.ISolution Solution { get; }
        public override JetBrains.ReSharper.Psi.BuildScripts.Tree.BuildScriptFileBase GetFile() { }
        public override string ToString() { }
    }
    public class BuildScriptProjectFileNode : JetBrains.ReSharper.Psi.BuildScripts.InclusionEngine.BuildScriptNode
    {
        public BuildScriptProjectFileNode(JetBrains.ProjectModel.IProjectFile projectFile, string id, JetBrains.ReSharper.Psi.LanguageService languageService) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ProjectModel.IProjectFile ProjectFile { get; }
        public override JetBrains.ReSharper.Psi.BuildScripts.Tree.BuildScriptFileBase GetFile() { }
        public override string ToString() { }
    }
    public abstract class CommonExecutionContext
    {
        protected CommonExecutionContext(JetBrains.ProjectModel.ISolution solution, JetBrains.ProjectModel.IProject project, JetBrains.Util.FileSystemPath fileLocation, System.Collections.Generic.Dictionary<JetBrains.Util.FileSystemPath, JetBrains.ReSharper.Psi.Tree.IFile> cachedPsiFiles) { }
        public System.Collections.Generic.Dictionary<JetBrains.Util.FileSystemPath, JetBrains.ReSharper.Psi.Tree.IFile> CachedExternalPsiFiles { get; }
        public System.Collections.Generic.List<JetBrains.ReSharper.Psi.Tree.IFile> ExecutedFiles { get; }
        public JetBrains.Util.FileSystemPath FileLocation { get; }
        public JetBrains.ProjectModel.IProject Project { get; }
        public JetBrains.ProjectModel.ISolution Solution { get; }
    }
    public abstract class IBuildScriptFileExecutorBase
    {
        public abstract JetBrains.ReSharper.Psi.BuildScripts.InclusionEngine.CommonExecutionContext Execute(JetBrains.ReSharper.Psi.BuildScripts.Tree.BuildScriptFileBase file, JetBrains.ProjectModel.ISolution solution, JetBrains.ProjectModel.IProject project, System.Collections.Generic.Dictionary<JetBrains.Util.FileSystemPath, JetBrains.ReSharper.Psi.Tree.IFile> cachedPsiFiles);
        protected static void MakeInclusionEdge(JetBrains.ReSharper.Psi.BuildScripts.Tree.IBuildFile file, JetBrains.ReSharper.Psi.BuildScripts.Tree.IBuildFile importedFile, JetBrains.ReSharper.Psi.BuildScripts.InclusionEngine.CommonExecutionContext context, JetBrains.ReSharper.Psi.TreeTextRange range) { }
    }
    public interface IInclusionTag : JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagContainer, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.BuildScripts.Tree.IBuildScriptAttribute ImportAttribute { get; }
        System.Collections.Generic.List<string> ImportedFileIds { get; set; }
    }
    public interface ILanguageSpecificBuildScriptFinder
    {
        bool IsBuildScriptFile(JetBrains.ProjectModel.IProjectFile projectFile);
    }
    public class static ScriptFileIdentityManager
    {
        public static string GetIdForFile(this JetBrains.ReSharper.Psi.BuildScripts.Tree.BuildScriptFileBase file) { }
    }
}
namespace JetBrains.ReSharper.Psi.BuildScripts.Parsing
{
    
    public class PredefinedStrings
    {
        public const string BASEDIR = "basedir";
        public const string DEFAULT = "default";
        public const string DEPENDS = "depends";
        public const string ID = "id";
        public const string MSBUILD_ASSEMBLY_FILE = "AssemblyFile";
        public const string MSBUILD_ASSEMBLY_NAME = "AssemblyName";
        public const string MSBUILD_CALL_TARGET = "CallTarget";
        public const string MSBUILD_CODE_FACTORY = "CodeFactory";
        public const string MSBUILD_CONDITION = "Condition";
        public const string MSBUILD_DEFAULT_TARGETS = "DefaultTargets";
        public const string MSBUILD_DEPENDS = "DependsOnTargets";
        public const string MSBUILD_IMPORT = "Import";
        public const string MSBUILD_INITIAL_TARGETS = "InitialTargets";
        public const string MSBUILD_IS_REQUIRED = "Required";
        public const string MSBUILD_ITEM_DEFINITION_GROUP = "ItemDefinitionGroup";
        public const string MSBUILD_ITEM_GROUP = "ItemGroup";
        public const string MSBUILD_ITEM_GROUP_NAME = "ItemName";
        public const string MSBUILD_NAME = "Name";
        public const string MSBUILD_OUTPUT = "Output";
        public const string MSBUILD_PARAMETER_GROUP = "ParameterGroup";
        public const string MSBUILD_PARAMETER_TYPE = "ParameterType";
        public const string MSBUILD_PROJECT = "Project";
        public const string MSBUILD_PROPERTY_GROUP = "PropertyGroup";
        public const string MSBUILD_PROPERTY_NAME = "PropertyName";
        public const string MSBUILD_TARGET = "Target";
        public const string MSBUILD_TARGETS = "Targets";
        public const string MSBUILD_TASK = "Task";
        public const string MSBUILD_TASK_FACTORY = "TaskFactory";
        public const string MSBUILD_TASK_NAME = "TaskName";
        public const string MSBUILD_USING_TASK = "UsingTask";
        public const string NAME = "name";
        public const string NANT_ASSEMBLY_FILE = "path";
        public const string NANT_ASSEMBLY_NAME = "assembly";
        public const string NANT_BUILDFILE = "buildfile";
        public const string NANT_CALL_TASK = "call";
        public const string NANT_DIRECTORY = "NANT_DIRECTORIES:";
        public const string NANT_FILESET = "fileset";
        public const string NANT_FOREACH_TASK = "foreach";
        public const string NANT_IF_TASK = "if";
        public const string NANT_IFNOT_TASK = "ifnot";
        public const string NANT_INCLUDE = "include";
        public const string NANT_LOADFILE_TASK = "loadfile";
        public const string NANT_LOADTASKS_TASK = "loadtasks";
        public const string NANT_PATTERN = "pattern";
        public const string NANT_PROJECT = "project";
        public const string NANT_PROPERTY = "property";
        public const string NANT_PROPERTY_EXISTS = "propertyexists";
        public const string NANT_PROPERTY_TRUE = "propertytrue";
        public const string NANT_READREGISTRY_TASK = "readregistry";
        public const string NANT_REGEX = "regex";
        public const string NANT_TARGET = "target";
        public const string NANT_TARGET_EXISTS = "targetexists";
        public const string NANT_VALUE = "value";
        public const string RESHARPER_IGNORED_PROPERTIES = "EXTERNAL_PROPERTIES:";
        public const string VALUE = "value";
    }
}
namespace JetBrains.ReSharper.Psi.BuildScripts.References
{
    
    public class AttributeReference : JetBrains.ReSharper.Psi.BuildScripts.References.ScriptReferenceBase
    {
        public AttributeReference(JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeElement reference, JetBrains.ReSharper.Psi.TreeTextRange range, JetBrains.ReSharper.Psi.TreeTextRange rangeInAttribute, string referenceName, JetBrains.ReSharper.Psi.DeclaredElementType type) { }
        public override JetBrains.ReSharper.Psi.Resolve.IReference BindTo(JetBrains.ReSharper.Psi.IDeclaredElement element) { }
        public JetBrains.ReSharper.Psi.TreeTextRange GetRangeInAttribute() { }
        public override JetBrains.ReSharper.Psi.TreeTextRange GetTreeTextRange() { }
        public void SetRangeInAttribute(JetBrains.ReSharper.Psi.TreeTextRange range) { }
    }
    public class FakeReference : JetBrains.ReSharper.Psi.BuildScripts.References.AttributeReference
    {
        public FakeReference(JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeElement reference, JetBrains.ReSharper.Psi.TreeTextRange range, JetBrains.ReSharper.Psi.TreeTextRange rangeInAttribute, string referenceName, JetBrains.ReSharper.Psi.DeclaredElementType type) { }
    }
    public abstract class ScriptReferenceBase : JetBrains.Util.UserDataHolder, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IQualifiableReferenceBase, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IQualifiableReferenceWithGlobalSymbolTable, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IReferenceWithGlobalSymbolTable, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IReferenceWithQualifier, JetBrains.ReSharper.Psi.Resolve.ICompleteableReference, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.Util.IUserDataHolder
    {
        protected readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeElement myElement;
        protected string myReferenceName;
        protected JetBrains.ReSharper.Psi.IDeclaredElement myTag;
        protected ScriptReferenceBase(JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeElement reference, JetBrains.ReSharper.Psi.TreeTextRange range, string referenceName, JetBrains.ReSharper.Psi.DeclaredElementType referenceType) { }
        public JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.ResolveResultWithInfo CurrentResolveResult { get; set; }
        public bool HasMultipleNames { get; }
        public bool IsQualified { get; }
        public JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeElement Reference { get; }
        public JetBrains.ReSharper.Psi.DeclaredElementType Type { get; }
        public abstract JetBrains.ReSharper.Psi.Resolve.IReference BindTo(JetBrains.ReSharper.Psi.IDeclaredElement element);
        public JetBrains.ReSharper.Psi.Resolve.IReference BindTo(JetBrains.ReSharper.Psi.IDeclaredElement element, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution) { }
        public JetBrains.ReSharper.Psi.Resolve.IAccessContext GetAccessContext() { }
        public System.Collections.Generic.IEnumerable<string> GetAllNames() { }
        public JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetCompletionSymbolTable() { }
        public JetBrains.DocumentModel.DocumentRange GetDocumentRange() { }
        public string GetName() { }
        public JetBrains.ReSharper.Psi.Resolve.IQualifier GetQualifier() { }
        public JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetReferenceSymbolTable(bool useReferenceName) { }
        public JetBrains.ReSharper.Psi.Tree.ITreeNode GetTreeNode() { }
        public abstract JetBrains.ReSharper.Psi.TreeTextRange GetTreeTextRange();
        public bool IsValid() { }
        public JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.ResolveResultWithInfo Resolve() { }
        public JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.ResolveResultWithInfo Resolve(JetBrains.ReSharper.Psi.Resolve.ISymbolTable symbolTable, JetBrains.ReSharper.Psi.Resolve.IAccessContext context) { }
    }
    public class TagReference : JetBrains.ReSharper.Psi.BuildScripts.References.ScriptReferenceBase
    {
        public TagReference(JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeElement reference, JetBrains.ReSharper.Psi.TreeTextRange range, string referenceName, JetBrains.ReSharper.Psi.DeclaredElementType type) { }
        public override JetBrains.ReSharper.Psi.Resolve.IReference BindTo(JetBrains.ReSharper.Psi.IDeclaredElement element) { }
        protected virtual void BindToInternal(JetBrains.ReSharper.Psi.BuildScripts.Tree.BuildScriptTagBase tag, JetBrains.ReSharper.Psi.Parsing.XmlTokenTypes types, string newName) { }
        public override JetBrains.ReSharper.Psi.TreeTextRange GetTreeTextRange() { }
    }
    public class TextReference : JetBrains.ReSharper.Psi.BuildScripts.References.ScriptReferenceBase
    {
        public TextReference(JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeElement reference, JetBrains.ReSharper.Psi.TreeTextRange range, JetBrains.ReSharper.Psi.TreeTextRange rangeInString, string referenceName, JetBrains.ReSharper.Psi.DeclaredElementType referenceType) { }
        public override JetBrains.ReSharper.Psi.Resolve.IReference BindTo(JetBrains.ReSharper.Psi.IDeclaredElement element) { }
        public override JetBrains.ReSharper.Psi.TreeTextRange GetTreeTextRange() { }
    }
}
namespace JetBrains.ReSharper.Psi.BuildScripts.Searching
{
    
    public abstract class ScriptSearcherFactoryBase<TLanguage> : JetBrains.ReSharper.Psi.ExtensionsAPI.IDomainSpecificSearcherFactory
        where TLanguage : JetBrains.ReSharper.Psi.BuildScripts.BuildScriptLanguage
    {
        protected ScriptSearcherFactoryBase(JetBrains.ReSharper.Psi.Search.SearchDomainFactory searchDomainFactory) { }
        public JetBrains.ReSharper.Psi.ExtensionsAPI.IDomainSpecificSearcher CreateAnonymousTypeSearcher(System.Collections.Generic.IList<JetBrains.ReSharper.Psi.AnonymousTypeDescriptor> typeDescription, bool caseSensitive) { }
        public JetBrains.ReSharper.Psi.ExtensionsAPI.IDomainSpecificSearcher CreateConstantExpressionSearcher(JetBrains.ReSharper.Psi.ConstantValue constantValue, bool onlyLiteralExpression) { }
        public JetBrains.ReSharper.Psi.ExtensionsAPI.IDomainSpecificSearcher CreateConstructorSpecialReferenceSearcher(System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.IConstructor> constructors) { }
        public JetBrains.ReSharper.Psi.ExtensionsAPI.IDomainSpecificSearcher CreateLateBoundReferenceSearcher(System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.IDeclaredElement> elements) { }
        public JetBrains.ReSharper.Psi.ExtensionsAPI.IDomainSpecificSearcher CreateMethodsReferencedByDelegateSearcher(JetBrains.ReSharper.Psi.IDelegate @delegate) { }
        public JetBrains.ReSharper.Psi.ExtensionsAPI.IDomainSpecificSearcher CreateReferenceSearcher(System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.IDeclaredElement> elements, bool findCandidates) { }
        public JetBrains.ReSharper.Psi.ExtensionsAPI.IDomainSpecificSearcher CreateTextOccurenceSearcher(System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.IDeclaredElement> elements) { }
        public JetBrains.ReSharper.Psi.ExtensionsAPI.IDomainSpecificSearcher CreateTextOccurenceSearcher(string subject) { }
        public System.Collections.Generic.IEnumerable<string> GetAllPossibleWordsInFile(JetBrains.ReSharper.Psi.IDeclaredElement element) { }
        public JetBrains.ReSharper.Psi.Search.ISearchDomain GetDeclaredElementSearchDomain(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
        public JetBrains.Util.JetTuple<System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.IDeclaredElement>, System.Predicate<JetBrains.ReSharper.Psi.Search.IFindResultReference>, bool> GetDerivedFindRequest(JetBrains.ReSharper.Psi.Search.IFindResultReference result) { }
        public JetBrains.Util.JetTuple<System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.IDeclaredElement>, bool> GetNavigateToTargets(JetBrains.ReSharper.Psi.IDeclaredElement element) { }
        public System.Collections.Generic.IEnumerable<JetBrains.Util.Pair<JetBrains.ReSharper.Psi.IDeclaredElement, System.Predicate<JetBrains.ReSharper.Psi.Search.FindResult>>> GetRelatedDeclaredElements(JetBrains.ReSharper.Psi.IDeclaredElement element) { }
        public bool IsCompatibleWithLanguage(JetBrains.ReSharper.Psi.PsiLanguageType languageType) { }
        public System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.Search.FindResult> TransformNavigationTargets(System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.Search.FindResult> targets) { }
    }
}
namespace JetBrains.ReSharper.Psi.BuildScripts.Tree
{
    
    public abstract class BuildScriptAttributeBase : JetBrains.ReSharper.Psi.Xml.Impl.Tree.XmlAttribute, JetBrains.ReSharper.Psi.BuildScripts.Tree.IBuildScriptAttribute, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttribute, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        protected BuildScriptAttributeBase(JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType type) { }
        public JetBrains.ReSharper.Psi.BuildScripts.Tree.IBuildScriptTag Container { get; }
        public System.Collections.Generic.IList<string> CalculateValues() { }
        protected override JetBrains.ReSharper.Psi.Tree.ReferenceCollection CreateFirstClassReferences() { }
        public void DropReferences() { }
        protected abstract JetBrains.ReSharper.Psi.Tree.ReferenceCollection GetAttributeReferences();
        [JetBrains.Annotations.NotNullAttribute()]
        protected TLanguageService GetLanguageService<TLanguageService>()
            where TLanguageService : JetBrains.ReSharper.Psi.BuildScripts.BuildScriptLanguageServiceBase { }
        public JetBrains.ReSharper.Psi.TreeTextRange GetTokenRange() { }
    }
    public abstract class BuildScriptFileBase : JetBrains.ReSharper.Psi.Xml.Impl.Tree.XmlFile, JetBrains.ReSharper.Psi.BuildScripts.Tree.IBuildFile, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IIncrementalScope, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IScope, JetBrains.ReSharper.Psi.Tree.IFile, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlDocumentNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlFile, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagContainer, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        protected JetBrains.ReSharper.Psi.BuildScripts.ReferencesManagerBase myReferencesManager;
        protected BuildScriptFileBase(JetBrains.ReSharper.Psi.BuildScripts.Tree.BuildScriptNodeType type) { }
        public JetBrains.Util.FileSystemPath AlternativeFileLocation { get; set; }
        public JetBrains.ReSharper.Psi.BuildScripts.Tree.ExternalPropertiesElement ExternalPropertiesElement { get; set; }
        public int LevelDelta { get; }
        public JetBrains.ReSharper.Psi.BuildScripts.ReferencesManagerBase ReferencesManager { get; }
        public JetBrains.ReSharper.Psi.Resolve.ISymbolTable AddDeclarationsAfterElement(JetBrains.ReSharper.Psi.Resolve.ISymbolTable parentTable, JetBrains.ReSharper.Psi.Tree.ITreeNode element, int level, JetBrains.ReSharper.Psi.Resolve.SymbolTableMode mode) { }
        public abstract JetBrains.ReSharper.Psi.Resolve.ISymbolTable AddDeclarationsBeforeElement(JetBrains.ReSharper.Psi.Resolve.ISymbolTable parentTable, JetBrains.ReSharper.Psi.Tree.ITreeNode element, int level, JetBrains.ReSharper.Psi.Resolve.SymbolTableMode mode);
        public JetBrains.ReSharper.Psi.Resolve.ISymbolTable AddGlobalDeclarations(JetBrains.ReSharper.Psi.Resolve.ISymbolTable parentTable, int level, JetBrains.ReSharper.Psi.Resolve.SymbolTableMode mode) { }
        public void CacheImportedFile(string path, JetBrains.ReSharper.Psi.Tree.IFile file) { }
        protected virtual JetBrains.Util.OneToSetMap<string, JetBrains.ReSharper.Psi.IDeclaredElement> FilterElements(System.Collections.Generic.JetHashSet<JetBrains.ReSharper.Psi.IDeclaredElement> elements) { }
        protected abstract System.Collections.Generic.List<JetBrains.ReSharper.Psi.IDeclaredElement> FindCommonDeclarations();
        public abstract System.Collections.Generic.JetHashSet<JetBrains.ReSharper.Psi.IDeclaredElement> FindGlobalDeclarations();
        public System.Collections.Generic.JetHashSet<JetBrains.ReSharper.Psi.IDeclaredElement> GatherDeclaredElements(JetBrains.ReSharper.Psi.BuildScripts.InclusionEngine.BuildScriptManager buildScriptManager) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Psi.Tree.IFile GetImportedFile(string path) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public TLanguageService GetLanguageService<TLanguageService>()
            where TLanguageService : JetBrains.ReSharper.Psi.BuildScripts.BuildScriptLanguageServiceBase { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ProjectModel.IProject GetProject() { }
    }
    public abstract class BuildScriptNodeType : JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType
    {
        protected BuildScriptNodeType(string s, JetBrains.ReSharper.Psi.Xml.Tree.XmlElementTypes xmlElementTypes, int index) { }
    }
    public class BuildScriptTagBase : JetBrains.ReSharper.Psi.Xml.Impl.Tree.XmlTag, JetBrains.ReSharper.Psi.BuildScripts.Tree.IBuildScriptTag, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagContainer, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        protected BuildScriptTagBase(JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType type) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public virtual JetBrains.ReSharper.Psi.BuildScripts.Tree.IBuildScriptAttribute ImportAttribute { get; }
        public virtual bool IsImportsTag { get; }
        public JetBrains.ReSharper.Psi.BuildScripts.Tree.IBuildScriptAttribute GetAttributeByName(string name) { }
        public override string ToString() { }
    }
    public abstract class ExternalPropertiesElement : JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeElement, JetBrains.ReSharper.Psi.Tree.ITokenNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlToken, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        protected ExternalPropertiesElement(JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType nodeType) { }
        public override JetBrains.ReSharper.Psi.PsiLanguageType Language { get; }
        public override JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType NodeType { get; }
        public JetBrains.ReSharper.Psi.Parsing.XmlTokenTypes XmlTokenTypes { get; }
        public TReturn AcceptVisitor<TContext, TReturn>(JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeVisitor<TContext, TReturn> visitor, TContext context) { }
        public System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.BuildScripts.Declarations.ExternalPropertyDeclaration> GetDeclarations() { }
        public abstract JetBrains.ReSharper.Psi.Parsing.XmlTokenNodeType GetTokenType();
    }
    public interface IBuildFile : JetBrains.ReSharper.Psi.Tree.IFile, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlDocumentNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlFile, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagContainer, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        JetBrains.Util.FileSystemPath AlternativeFileLocation { get; set; }
    }
    public interface IBuildScriptAttribute : JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttribute, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        JetBrains.ReSharper.Psi.BuildScripts.Tree.IBuildScriptTag Container { get; }
        System.Collections.Generic.IList<string> CalculateValues();
    }
    public interface IBuildScriptTag : JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagContainer, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        JetBrains.ReSharper.Psi.BuildScripts.Tree.IBuildScriptAttribute GetAttributeByName(string name);
    }
    public interface IProperty
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.BuildScripts.Declarations.IBuildScriptDeclaration PropertyDeclaration { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        string PropertyName { get; }
    }
    public interface ITarget
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.BuildScripts.Declarations.IBuildScriptDeclaration TargetDeclaration { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        string TargetName { get; }
    }
    public class static TreeExtensions
    {
        public static System.Collections.Generic.IEnumerable<T> FindAllInnerTags<T>(this JetBrains.ReSharper.Psi.BuildScripts.Tree.IBuildScriptTag tag, System.Predicate<JetBrains.ReSharper.Psi.BuildScripts.Tree.BuildScriptTagBase> condition)
            where T : JetBrains.ReSharper.Psi.BuildScripts.Tree.BuildScriptTagBase { }
    }
}