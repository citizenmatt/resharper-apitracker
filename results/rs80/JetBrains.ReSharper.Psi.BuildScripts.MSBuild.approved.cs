[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]

namespace JetBrains.ReSharper.Psi.BuildScripts.MSBuild.Declarations
{
    
    public abstract class MSBuildAttributeBasedDeclaration : JetBrains.ReSharper.Psi.BuildScripts.MSBuild.Tree.MSBuildAttribute, JetBrains.ReSharper.Psi.BuildScripts.Declarations.IBuildScriptDeclaration, JetBrains.ReSharper.Psi.Tree.IDeclaration, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Tree.IXmlDocOwnerTreeNode
    {
        protected MSBuildAttributeBasedDeclaration(JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType nodeType) { }
        public JetBrains.ReSharper.Psi.IDeclaredElement DeclaredElement { get; }
        public string DeclaredName { get; }
        public bool IsDeclarationValid { get; }
        public JetBrains.ProjectModel.ISolution Solution { get; set; }
        public abstract JetBrains.ReSharper.Psi.BuildScripts.DeclaredElements.BuildScriptDeclaredElementBase CreateDeclaredElement(System.Collections.Generic.JetHashSet<JetBrains.ReSharper.Psi.BuildScripts.InclusionEngine.BuildScriptNode> nodes, JetBrains.ProjectModel.ISolution solution);
        public abstract JetBrains.ReSharper.Psi.DeclaredElementType GetElementType();
        public JetBrains.ReSharper.Psi.TreeTextRange GetNameRange() { }
        public System.Xml.XmlNode GetXMLDoc(bool inherit) { }
        public abstract void InitReference(JetBrains.ReSharper.Psi.BuildScripts.Tree.BuildScriptFileBase file);
        public bool IsSynthetic() { }
        public void SetDeclaredElement(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
        public void SetDeclaredName(string name) { }
        public void SetName(string name) { }
    }
    public class MSBuildAttributedItemGroupDeclaration : JetBrains.ReSharper.Psi.BuildScripts.MSBuild.Declarations.MSBuildAttributeBasedDeclaration
    {
        public MSBuildAttributedItemGroupDeclaration(JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType nodeType) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public string ItemGroupName { get; }
        public override JetBrains.ReSharper.Psi.BuildScripts.DeclaredElements.BuildScriptDeclaredElementBase CreateDeclaredElement(System.Collections.Generic.JetHashSet<JetBrains.ReSharper.Psi.BuildScripts.InclusionEngine.BuildScriptNode> nodes, JetBrains.ProjectModel.ISolution solution) { }
        public override JetBrains.ReSharper.Psi.DeclaredElementType GetElementType() { }
        public override void InitReference(JetBrains.ReSharper.Psi.BuildScripts.Tree.BuildScriptFileBase file) { }
    }
    public class MSBuildAttributedPropertyDeclaration : JetBrains.ReSharper.Psi.BuildScripts.MSBuild.Declarations.MSBuildAttributeBasedDeclaration, JetBrains.ReSharper.Psi.BuildScripts.Declarations.IPropertyDeclaration
    {
        public MSBuildAttributedPropertyDeclaration(JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType nodeType) { }
        public string PropertyName { get; }
        public override JetBrains.ReSharper.Psi.BuildScripts.DeclaredElements.BuildScriptDeclaredElementBase CreateDeclaredElement(System.Collections.Generic.JetHashSet<JetBrains.ReSharper.Psi.BuildScripts.InclusionEngine.BuildScriptNode> nodes, JetBrains.ProjectModel.ISolution solution) { }
        public override JetBrains.ReSharper.Psi.DeclaredElementType GetElementType() { }
        public System.Collections.Generic.IList<string> GetValues() { }
        public override void InitReference(JetBrains.ReSharper.Psi.BuildScripts.Tree.BuildScriptFileBase file) { }
    }
    public class MSBuildExternalPropertyDeclaration : JetBrains.ReSharper.Psi.BuildScripts.Declarations.ExternalPropertyDeclaration
    {
        public MSBuildExternalPropertyDeclaration(string name, JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType nodeType) { }
        public override JetBrains.ReSharper.Psi.BuildScripts.DeclaredElements.BuildScriptDeclaredElementBase CreateDeclaredElement(System.Collections.Generic.JetHashSet<JetBrains.ReSharper.Psi.BuildScripts.InclusionEngine.BuildScriptNode> nodes, JetBrains.ProjectModel.ISolution solution) { }
        public override JetBrains.ReSharper.Psi.DeclaredElementType GetElementType() { }
    }
    public class MSBuildItemGroupDeclaration : JetBrains.ReSharper.Psi.BuildScripts.MSBuild.Declarations.TagBasedDeclaration, JetBrains.ReSharper.Psi.BuildScripts.MSBuild.Tree.IMSBuildItemGroupElement
    {
        public MSBuildItemGroupDeclaration(string name, JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType nodeType) { }
        public string ItemGroupName { get; }
        public override JetBrains.ReSharper.Psi.BuildScripts.DeclaredElements.BuildScriptDeclaredElementBase CreateDeclaredElement(System.Collections.Generic.JetHashSet<JetBrains.ReSharper.Psi.BuildScripts.InclusionEngine.BuildScriptNode> nodes, JetBrains.ProjectModel.ISolution solution) { }
        public override JetBrains.ReSharper.Psi.DeclaredElementType GetElementType() { }
        public override void InitReference(JetBrains.ReSharper.Psi.BuildScripts.Tree.BuildScriptFileBase file) { }
    }
    public class MSBuildMetadataDeclaration : JetBrains.ReSharper.Psi.BuildScripts.MSBuild.Declarations.TagBasedDeclaration
    {
        public MSBuildMetadataDeclaration(string name, JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType nodeType) { }
        public override JetBrains.ReSharper.Psi.BuildScripts.DeclaredElements.BuildScriptDeclaredElementBase CreateDeclaredElement(System.Collections.Generic.JetHashSet<JetBrains.ReSharper.Psi.BuildScripts.InclusionEngine.BuildScriptNode> nodes, JetBrains.ProjectModel.ISolution solution) { }
        public override JetBrains.ReSharper.Psi.DeclaredElementType GetElementType() { }
        public override void InitReference(JetBrains.ReSharper.Psi.BuildScripts.Tree.BuildScriptFileBase file) { }
    }
    public class MSBuildPropertyDeclaration : JetBrains.ReSharper.Psi.BuildScripts.MSBuild.Declarations.TagBasedDeclaration, JetBrains.ReSharper.Psi.BuildScripts.Declarations.IPropertyDeclaration, JetBrains.ReSharper.Psi.BuildScripts.Tree.IProperty
    {
        public MSBuildPropertyDeclaration(string name, JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType nodeType) { }
        public JetBrains.ReSharper.Psi.BuildScripts.Declarations.IBuildScriptDeclaration PropertyDeclaration { get; }
        public string PropertyName { get; }
        public override JetBrains.ReSharper.Psi.BuildScripts.DeclaredElements.BuildScriptDeclaredElementBase CreateDeclaredElement(System.Collections.Generic.JetHashSet<JetBrains.ReSharper.Psi.BuildScripts.InclusionEngine.BuildScriptNode> nodes, JetBrains.ProjectModel.ISolution solution) { }
        protected override JetBrains.ReSharper.Psi.Tree.ReferenceCollection CreateFirstClassReferences() { }
        public override JetBrains.ReSharper.Psi.DeclaredElementType GetElementType() { }
        public System.Collections.Generic.IList<string> GetValues() { }
        public override void InitReference(JetBrains.ReSharper.Psi.BuildScripts.Tree.BuildScriptFileBase file) { }
    }
    public class MSBuildTargetDeclaration : JetBrains.ReSharper.Psi.BuildScripts.MSBuild.Declarations.MSBuildAttributeBasedDeclaration
    {
        public MSBuildTargetDeclaration(JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType nodeType) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public string TargetName { get; }
        public override JetBrains.ReSharper.Psi.BuildScripts.DeclaredElements.BuildScriptDeclaredElementBase CreateDeclaredElement(System.Collections.Generic.JetHashSet<JetBrains.ReSharper.Psi.BuildScripts.InclusionEngine.BuildScriptNode> nodes, JetBrains.ProjectModel.ISolution solution) { }
        public override JetBrains.ReSharper.Psi.DeclaredElementType GetElementType() { }
        public override void InitReference(JetBrains.ReSharper.Psi.BuildScripts.Tree.BuildScriptFileBase file) { }
    }
    public class MSBuildTaskDeclaration : JetBrains.ReSharper.Psi.BuildScripts.MSBuild.Declarations.MSBuildAttributeBasedDeclaration
    {
        public MSBuildTaskDeclaration(JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType nodeType) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public string FullTaskName { get; }
        public override JetBrains.ReSharper.Psi.BuildScripts.DeclaredElements.BuildScriptDeclaredElementBase CreateDeclaredElement(System.Collections.Generic.JetHashSet<JetBrains.ReSharper.Psi.BuildScripts.InclusionEngine.BuildScriptNode> nodes, JetBrains.ProjectModel.ISolution solution) { }
        public override JetBrains.ReSharper.Psi.DeclaredElementType GetElementType() { }
        public override void InitReference(JetBrains.ReSharper.Psi.BuildScripts.Tree.BuildScriptFileBase file) { }
    }
    public abstract class TagBasedDeclaration : JetBrains.ReSharper.Psi.BuildScripts.MSBuild.Tree.MSBuildTag, JetBrains.ReSharper.Psi.BuildScripts.Declarations.IBuildScriptDeclaration, JetBrains.ReSharper.Psi.Tree.IDeclaration, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Tree.IXmlDocOwnerTreeNode
    {
        protected TagBasedDeclaration(string name, JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType nodeType) { }
        public JetBrains.ReSharper.Psi.IDeclaredElement DeclaredElement { get; }
        public string DeclaredName { get; }
        public bool IsDeclarationValid { get; }
        public JetBrains.ProjectModel.ISolution Solution { get; set; }
        public abstract JetBrains.ReSharper.Psi.BuildScripts.DeclaredElements.BuildScriptDeclaredElementBase CreateDeclaredElement(System.Collections.Generic.JetHashSet<JetBrains.ReSharper.Psi.BuildScripts.InclusionEngine.BuildScriptNode> nodes, JetBrains.ProjectModel.ISolution solution);
        public abstract JetBrains.ReSharper.Psi.DeclaredElementType GetElementType();
        public JetBrains.ReSharper.Psi.TreeTextRange GetNameRange() { }
        public System.Xml.XmlNode GetXMLDoc(bool inherit) { }
        public abstract void InitReference(JetBrains.ReSharper.Psi.BuildScripts.Tree.BuildScriptFileBase file);
        public bool IsSynthetic() { }
        public void SetDeclaredElement(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
        public void SetName(string name) { }
    }
}
namespace JetBrains.ReSharper.Psi.BuildScripts.MSBuild.DeclaredElements
{
    
    public abstract class MSBuildCommonDeclaredElement : JetBrains.ReSharper.Psi.IDeclaredElement
    {
        protected string myShortName;
        protected JetBrains.ProjectModel.ISolution mySolution;
        protected MSBuildCommonDeclaredElement(string name, JetBrains.ProjectModel.ISolution solution) { }
        public virtual bool CaseSensistiveName { get; }
        public JetBrains.ReSharper.Psi.Resolve.ISubstitution IdSubstitution { get; }
        public JetBrains.ReSharper.Psi.Modules.IPsiModule Module { get; }
        public virtual JetBrains.ReSharper.Psi.PsiLanguageType PresentationLanguage { get; }
        public virtual string ShortName { get; }
        public string XMLDocId { get; }
        public JetBrains.ReSharper.Psi.ITypeElement GetContainingType() { }
        public JetBrains.ReSharper.Psi.ITypeMember GetContainingTypeMember() { }
        public virtual System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Tree.IDeclaration> GetDeclarations() { }
        public virtual System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Tree.IDeclaration> GetDeclarationsIn(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
        public abstract JetBrains.ReSharper.Psi.DeclaredElementType GetElementType();
        public virtual JetBrains.ReSharper.Psi.IPsiServices GetPsiServices() { }
        public virtual JetBrains.Util.DataStructures.HybridCollection<JetBrains.ReSharper.Psi.IPsiSourceFile> GetSourceFiles() { }
        public virtual System.Xml.XmlNode GetXMLDescriptionSummary(bool inherit) { }
        public virtual System.Xml.XmlNode GetXMLDoc(bool inherit) { }
        public virtual bool HasDeclarationsIn(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
        public virtual bool IsSynthetic() { }
        public virtual bool IsValid() { }
    }
    public class MSBuildCommonPropertyDeclaredElement : JetBrains.ReSharper.Psi.BuildScripts.MSBuild.DeclaredElements.MSBuildCommonDeclaredElement
    {
        public MSBuildCommonPropertyDeclaredElement(string name, JetBrains.ProjectModel.ISolution solution) { }
        public override JetBrains.ReSharper.Psi.DeclaredElementType GetElementType() { }
        public override string ToString() { }
    }
    public class MSBuildItemGroupDeclaredElement : JetBrains.ReSharper.Psi.BuildScripts.DeclaredElements.BuildScriptDeclaredElementBase
    {
        public MSBuildItemGroupDeclaredElement(string name, System.Collections.Generic.JetHashSet<JetBrains.ReSharper.Psi.BuildScripts.InclusionEngine.BuildScriptNode> nodes, JetBrains.ProjectModel.ISolution solution) { }
        public override JetBrains.ReSharper.Psi.PsiLanguageType PresentationLanguage { get; }
        public override JetBrains.ReSharper.Psi.DeclaredElementType GetElementType() { }
    }
    public class MSBuildMetadataDeclaredElement : JetBrains.ReSharper.Psi.BuildScripts.DeclaredElements.BuildScriptDeclaredElementBase
    {
        public MSBuildMetadataDeclaredElement(string name, System.Collections.Generic.JetHashSet<JetBrains.ReSharper.Psi.BuildScripts.InclusionEngine.BuildScriptNode> nodes, JetBrains.ProjectModel.ISolution solution) { }
        public override JetBrains.ReSharper.Psi.PsiLanguageType PresentationLanguage { get; }
        public override JetBrains.ReSharper.Psi.DeclaredElementType GetElementType() { }
    }
    public class MSBuildPropertyDeclaredElement : JetBrains.ReSharper.Psi.BuildScripts.DeclaredElements.PropertyDeclaredElement
    {
        public MSBuildPropertyDeclaredElement(string name, System.Collections.Generic.JetHashSet<JetBrains.ReSharper.Psi.BuildScripts.InclusionEngine.BuildScriptNode> nodes, JetBrains.ProjectModel.ISolution solution) { }
        public override JetBrains.ReSharper.Psi.PsiLanguageType PresentationLanguage { get; }
        public override JetBrains.ReSharper.Psi.DeclaredElementType GetElementType() { }
    }
    public class MSBuildTargetDeclaredElement : JetBrains.ReSharper.Psi.BuildScripts.DeclaredElements.TargetDeclaredElement
    {
        public MSBuildTargetDeclaredElement(string name, System.Collections.Generic.JetHashSet<JetBrains.ReSharper.Psi.BuildScripts.InclusionEngine.BuildScriptNode> nodes, JetBrains.ProjectModel.ISolution solution) { }
        public override JetBrains.ReSharper.Psi.PsiLanguageType PresentationLanguage { get; }
        public override JetBrains.ReSharper.Psi.DeclaredElementType GetElementType() { }
    }
    public class MSBuildTaskDeclaredElement : JetBrains.ReSharper.Psi.BuildScripts.DeclaredElements.BuildScriptDeclaredElementBase
    {
        public MSBuildTaskDeclaredElement(string name, System.Collections.Generic.JetHashSet<JetBrains.ReSharper.Psi.BuildScripts.InclusionEngine.BuildScriptNode> nodes, JetBrains.ProjectModel.ISolution solution) { }
        public override JetBrains.ReSharper.Psi.PsiLanguageType PresentationLanguage { get; }
        public override JetBrains.ReSharper.Psi.DeclaredElementType GetElementType() { }
    }
}
namespace JetBrains.ReSharper.Psi.BuildScripts.MSBuild.InclusionEngine
{
    
    public class MSBuildAbstractExecutor : JetBrains.ReSharper.Psi.BuildScripts.InclusionEngine.IBuildScriptFileExecutorBase
    {
        public MSBuildAbstractExecutor() { }
        public static System.Collections.Generic.List<string> Evaluate(JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeElement element, string text, JetBrains.ReSharper.Psi.TreeTextRange valueTokenRange, JetBrains.ReSharper.Psi.BuildScripts.MSBuild.InclusionEngine.MSBuildExecutionContext context) { }
        public override JetBrains.ReSharper.Psi.BuildScripts.InclusionEngine.CommonExecutionContext Execute(JetBrains.ReSharper.Psi.BuildScripts.Tree.BuildScriptFileBase file, JetBrains.ProjectModel.ISolution solution, JetBrains.ProjectModel.IProject project, System.Collections.Generic.Dictionary<JetBrains.Util.FileSystemPath, JetBrains.ReSharper.Psi.Tree.IFile> cachedPsiFiles) { }
        public static string MakeFullPath(JetBrains.ReSharper.Psi.BuildScripts.Tree.IBuildFile file, string possiblePath) { }
    }
    public class MSBuildExecutionContext : JetBrains.ReSharper.Psi.BuildScripts.InclusionEngine.CommonExecutionContext
    {
        public MSBuildExecutionContext(JetBrains.ReSharper.Psi.BuildScripts.MSBuild.MSBuildLanguageService languageService, JetBrains.ProjectModel.ISolution solution, JetBrains.ProjectModel.IProject project, JetBrains.Util.FileSystemPath fileLocation, string projectName, string defaultTargets, System.Collections.Generic.Dictionary<JetBrains.Util.FileSystemPath, JetBrains.ReSharper.Psi.Tree.IFile> cachedPsiFiles) { }
        public string DefaultTargets { get; }
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> ItemGroups { get; }
        public JetBrains.ReSharper.Psi.BuildScripts.MSBuild.MSBuildLanguageService LanguageService { get; }
        public string ProjectName { get; }
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> Properties { get; }
    }
    public class MSBuildScriptFinder : JetBrains.ReSharper.Psi.BuildScripts.InclusionEngine.ILanguageSpecificBuildScriptFinder
    {
        public bool IsBuildScriptFile(JetBrains.ProjectModel.IProjectFile projectFile) { }
    }
    public class MSBuildValueEvaluator
    {
        public static System.Collections.Generic.List<string> GetAllPossibleValues(string text, JetBrains.ReSharper.Psi.TreeTextRange valueTokenRange, JetBrains.ReSharper.Psi.BuildScripts.MSBuild.InclusionEngine.MSBuildExecutionContext context) { }
    }
}
namespace JetBrains.ReSharper.Psi.BuildScripts.MSBuild
{
    
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class MSBuildCommonElementsProvider : JetBrains.ReSharper.Psi.BuildScripts.ICommonElementProvider, System.IDisposable
    {
        public MSBuildCommonElementsProvider(JetBrains.ProjectModel.ISolution solution) { }
        public void Dispose() { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IDeclaredElement> GetAllCommonElements(JetBrains.ReSharper.Psi.IPsiSourceFile file) { }
        public JetBrains.ReSharper.Psi.IDeclaredElement GetCommonElement(string name, JetBrains.ReSharper.Psi.DeclaredElementType expectedType, JetBrains.ReSharper.Psi.IPsiSourceFile file) { }
        public static JetBrains.ReSharper.Psi.BuildScripts.MSBuild.MSBuildCommonElementsProvider GetInstance(JetBrains.ProjectModel.ISolution solution) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IDeclaredElement> GetItemGroupMetadata(string itemGroupName) { }
        public System.Collections.Generic.IEnumerable<string> GetWellKnownMetadata() { }
        public bool IsCommonElement(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
    }
    public class MSBuildDeclarationFinder : JetBrains.ReSharper.Psi.BuildScripts.IDeclarationFinder
    {
        public System.Collections.Generic.List<JetBrains.ReSharper.Psi.Tree.IDeclaration> FindAllDeclarations(JetBrains.ReSharper.Psi.BuildScripts.Tree.BuildScriptFileBase file) { }
        public System.Collections.Generic.List<JetBrains.ReSharper.Psi.Tree.IDeclaration> FindDeclarationsBefore(JetBrains.ReSharper.Psi.BuildScripts.Tree.BuildScriptFileBase file, JetBrains.ReSharper.Psi.TreeTextRange range) { }
    }
    public class MSBuildDeclaredElementFinder : JetBrains.ReSharper.Psi.BuildScripts.DeclaredElementFinder
    {
        public MSBuildDeclaredElementFinder(JetBrains.ProjectModel.ISolution solution) { }
        protected override JetBrains.ReSharper.Psi.IDeclaredElement CreatePropertyDeclaredElement(string name, JetBrains.ProjectModel.ISolution solution) { }
        public override void ProcessAttribute(JetBrains.ReSharper.Psi.BuildScripts.Tree.BuildScriptAttributeBase attribute, JetBrains.ReSharper.Psi.BuildScripts.InclusionEngine.BuildScriptNode node) { }
        public override void ProcessTag(JetBrains.ReSharper.Psi.BuildScripts.Tree.BuildScriptTagBase tag, JetBrains.ReSharper.Psi.BuildScripts.InclusionEngine.BuildScriptNode node) { }
    }
    public class MSBuildDeclaredElementPresenter : JetBrains.ReSharper.Psi.BuildScripts.BuildScriptDeclaredElementPresenter
    {
        protected override string GetElementTypeName(JetBrains.ReSharper.Psi.IDeclaredElement element) { }
    }
    public class MSBuildDeclaredElementType : JetBrains.ReSharper.Psi.BuildScripts.BuildScriptDeclaredElementType
    {
        public static readonly JetBrains.ReSharper.Psi.DeclaredElementType MSBUILD_COMMON_ITEM_GROUP;
        public static readonly JetBrains.ReSharper.Psi.DeclaredElementType MSBUILD_COMMON_METADATA;
        public static readonly JetBrains.ReSharper.Psi.DeclaredElementType MSBUILD_COMMON_PROPERTY;
        public static readonly JetBrains.ReSharper.Psi.DeclaredElementType MSBUILD_COMMON_TARGET;
        public static readonly JetBrains.ReSharper.Psi.DeclaredElementType MSBUILD_ITEM_GROUP;
        public static readonly JetBrains.ReSharper.Psi.DeclaredElementType MSBUILD_METADATA;
        public static readonly JetBrains.ReSharper.Psi.DeclaredElementType MSBUILD_PROPERTY;
        public static readonly JetBrains.ReSharper.Psi.DeclaredElementType MSBUILD_TARGET;
        public static readonly JetBrains.ReSharper.Psi.DeclaredElementType MSBUILD_TASK;
        public MSBuildDeclaredElementType(string presentableName, string name, JetBrains.UI.Icons.IconId imageName) { }
        protected override JetBrains.ReSharper.Psi.IDeclaredElementPresenter DefaultPresenter { get; }
        public override bool IsEqual(JetBrains.ReSharper.Psi.BuildScripts.BuildScriptDeclaredElementType type) { }
    }
    [JetBrains.ReSharper.Psi.LanguageDefinitionAttribute("MSBUILD_BUILD_SCRIPT")]
    public class MSBuildLanguage : JetBrains.ReSharper.Psi.BuildScripts.BuildScriptLanguage
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static readonly JetBrains.ReSharper.Psi.BuildScripts.MSBuild.MSBuildLanguage Instance;
        public const string Name = "MSBUILD_BUILD_SCRIPT";
        protected MSBuildLanguage([JetBrains.Annotations.NotNullAttribute()] string name, [JetBrains.Annotations.NotNullAttribute()] string presentableName) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.BuildScripts.MSBuild.MSBuildLanguage))]
    public class MSBuildLanguageService : JetBrains.ReSharper.Psi.BuildScripts.BuildScriptLanguageServiceBase
    {
        public MSBuildLanguageService(JetBrains.ReSharper.Psi.BuildScripts.MSBuild.MSBuildLanguage languageType, JetBrains.ReSharper.Psi.IConstantValueService constantValueService, JetBrains.ReSharper.Psi.Parsing.XmlTokenTypes tokenTypes, JetBrains.ReSharper.Psi.Xml.Parsing.IXmlElementFactory elementFactory, JetBrains.ReSharper.Psi.Xml.Impl.CodeStyle.XmlCodeFormatter codeFormatter, JetBrains.ReSharper.Psi.Util.CommonIdentifierIntern commonIdentifierIntern) { }
        public override JetBrains.ReSharper.Psi.ExtensionsAPI.Caches2.ILanguageCacheProvider CacheProvider { get; }
        public override bool IsCaseSensitive { get; }
        public JetBrains.ReSharper.Psi.BuildScripts.MSBuild.MSBuildPredefinedMetadataItems PredefinedMetadata { get; }
        public JetBrains.ReSharper.Psi.BuildScripts.MSBuild.MSBuildPredefinedProperties PredefinedProperties { get; }
        public JetBrains.ReSharper.Psi.BuildScripts.MSBuild.MSBuildPredefinedTags PredefinedTags { get; }
        public override bool SupportTypeMemberCache { get; }
        public override JetBrains.ReSharper.Psi.ITypePresenter TypePresenter { get; }
        public override JetBrains.ReSharper.Psi.BuildScripts.DeclaredElementFinder CreateDeclaredElementFinder(JetBrains.ProjectModel.ISolution solution) { }
        public override JetBrains.ReSharper.Psi.Parsing.IParser CreateParser(JetBrains.ReSharper.Psi.Parsing.ILexer lexer, JetBrains.ReSharper.Psi.Modules.IPsiModule module, JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
        public override JetBrains.ReSharper.Psi.BuildScripts.InclusionEngine.IBuildScriptFileExecutorBase GetBuildScriptExecutor() { }
        public override JetBrains.ReSharper.Psi.BuildScripts.ICommonElementProvider GetCommonElementProvider(JetBrains.ProjectModel.ISolution solution) { }
        public override JetBrains.ReSharper.Psi.BuildScripts.IDeclarationFinder GetDeclarationFinder() { }
        public override string GetDefaultTargetAttributeName() { }
        public override string GetProjectAttributeName() { }
        public override JetBrains.ReSharper.Psi.BuildScripts.ValueEvaluator GetValueEvaluator() { }
        public bool IsRegistryProperty(string propertyReference) { }
        public override bool IsValidName(JetBrains.ReSharper.Psi.DeclaredElementType elementType, string name) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class MSBuildMetadataManager : System.IDisposable
    {
        public MSBuildMetadataManager(JetBrains.ReSharper.Psi.BuildScripts.ReferenceManager referenceManager) { }
        public void Dispose() { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Psi.IDeclaredElement GetDeclaringItemGroup(JetBrains.ReSharper.Psi.IDeclaredElement metadataDeclaredElement) { }
        public static JetBrains.ReSharper.Psi.BuildScripts.MSBuild.MSBuildMetadataManager GetInstance(JetBrains.ProjectModel.ISolution solution) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IDeclaredElement> GetRelatedMetadata(JetBrains.ReSharper.Psi.BuildScripts.MSBuild.DeclaredElements.MSBuildItemGroupDeclaredElement itemGroup) { }
    }
    public class static MSBuildNavigator
    {
        public static System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.BuildScripts.MSBuild.Tree.MSBuildPropertyGroupTag> GetPropertyGroups(this JetBrains.ReSharper.Psi.BuildScripts.MSBuild.Tree.MSBuildFile file) { }
    }
    public class MSBuildPredefinedMetadataItems : JetBrains.ReSharper.Psi.BuildScripts.PredefinedItemsBase
    {
        public MSBuildPredefinedMetadataItems() { }
        public System.Collections.Generic.IEnumerable<string> GetAllPredefinedItems() { }
        public override System.Collections.Generic.IList<string> GetPredefinedPropertyValue(string propertyName, JetBrains.Util.FileSystemPath fileLocation, string projectName, string defaultTargets) { }
        public override bool IsPredefined(string tagName) { }
    }
    public class MSBuildPredefinedProperties : JetBrains.ReSharper.Psi.BuildScripts.PredefinedItemsBase
    {
        public MSBuildPredefinedProperties() { }
        public System.Collections.Generic.IList<string> GetAllPredefinedProperties() { }
        public override System.Collections.Generic.IList<string> GetPredefinedPropertyValue(string propertyName, JetBrains.Util.FileSystemPath fileLocation, string projectName, string defaultTargets) { }
        public override bool IsPredefined(string propertyName) { }
    }
    public class MSBuildPredefinedTags : JetBrains.ReSharper.Psi.BuildScripts.PredefinedItemsBase
    {
        public MSBuildPredefinedTags() { }
        public override System.Collections.Generic.IList<string> GetPredefinedPropertyValue(string propertyName, JetBrains.Util.FileSystemPath fileLocation, string projectName, string defaultTargets) { }
        public override bool IsPredefined(string tagName) { }
    }
    [JetBrains.ProjectModel.ProjectFileTypeAttribute(typeof(JetBrains.ProjectModel.MSBuildProjectFileType))]
    public class MSBuildProjectFileLanguageService : JetBrains.ReSharper.Psi.Xml.XmlProjectFileLanguageService
    {
        public MSBuildProjectFileLanguageService(JetBrains.ProjectModel.MSBuildProjectFileType msbuildProjectFileType) { }
        public override JetBrains.UI.Icons.IconId Icon { get; }
        public override JetBrains.ReSharper.Psi.PsiLanguageType GetPsiLanguageType(JetBrains.ProjectModel.ProjectFileType languageType) { }
        public override JetBrains.ReSharper.Psi.IPsiSourceFileProperties GetPsiProperties(JetBrains.ProjectModel.IProjectFile projectFile, JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
    }
    [JetBrains.ReSharper.Psi.Modules.MiscFilesProjectPsiModuleProviderAttribute()]
    public class MSBuildPsiModuleProvider : JetBrains.ReSharper.Psi.BuildScripts.BuildScriptPsiModuleProvider
    {
        public MSBuildPsiModuleProvider(JetBrains.ProjectModel.ISolution solution) { }
        protected override JetBrains.ReSharper.Psi.BuildScripts.BuildScriptModule Module { get; }
    }
    public class MSBuildReferencesManager : JetBrains.ReSharper.Psi.BuildScripts.ReferencesManagerBase
    {
        public MSBuildReferencesManager() { }
        public override void IgnoreProperty(string propertyName, JetBrains.ReSharper.Psi.BuildScripts.Tree.BuildScriptFileBase file) { }
        public bool IsPropertyIgnored(string name) { }
    }
    public class MSBuildValueEvaluator : JetBrains.ReSharper.Psi.BuildScripts.ValueEvaluator
    {
        public MSBuildValueEvaluator(JetBrains.ReSharper.Psi.BuildScripts.MSBuild.MSBuildLanguageService languageService) { }
        protected override System.Collections.Generic.IList<string> GetPredefinedPropertyValues(JetBrains.ReSharper.Psi.BuildScripts.References.ScriptReferenceBase reference, JetBrains.ReSharper.Psi.BuildScripts.Tree.BuildScriptFileBase file) { }
        protected override bool IsPredefinedProperty(JetBrains.ReSharper.Psi.BuildScripts.References.ScriptReferenceBase reference) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.BuildScripts.MSBuild.MSBuildLanguage))]
    public class MSBuildXmlLanguageSupport : JetBrains.ReSharper.Psi.Xml.XmlLanguageSupport
    {
        public override bool CanConvertAttributeToTag(JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttribute attribute) { }
        public override bool CanConvertTagToAttribute(JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag tag) { }
        public override JetBrains.ReSharper.Psi.Xml.Parsing.XmlTreeBuilder CreateTreeBuilder(JetBrains.ReSharper.Psi.Xml.Parsing.IXmlElementFactory factory, JetBrains.ReSharper.Psi.Xml.Parsing.IXmlElementFactoryContext factoryContext, JetBrains.ReSharper.Psi.Util.ITokenIntern intern) { }
        public override bool IsFormattingAllowed(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
    }
}
namespace JetBrains.ReSharper.Psi.BuildScripts.MSBuild.Parsing
{
    
    public class MSBuildAttributeNodeType : JetBrains.ReSharper.Psi.BuildScripts.Tree.BuildScriptNodeType
    {
        public MSBuildAttributeNodeType(JetBrains.ReSharper.Psi.BuildScripts.MSBuild.Parsing.MSBuildNodeTypes nodeTypes, int index) { }
        public override JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeElement Create() { }
    }
    public class MSBuildCommentNodeType : JetBrains.ReSharper.Psi.BuildScripts.Tree.BuildScriptNodeType
    {
        public MSBuildCommentNodeType(JetBrains.ReSharper.Psi.BuildScripts.MSBuild.Parsing.MSBuildNodeTypes nodeTypes, int index) { }
        public override JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeElement Create() { }
    }
    public class MSBuildExternalPropertiesNodeType : JetBrains.ReSharper.Psi.BuildScripts.Tree.BuildScriptNodeType
    {
        public MSBuildExternalPropertiesNodeType(JetBrains.ReSharper.Psi.BuildScripts.MSBuild.Parsing.MSBuildNodeTypes nodeTypes, int index) { }
        public override JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeElement Create() { }
    }
    public class MSBuildExternalPropertyDeclarationNodeType : JetBrains.ReSharper.Psi.BuildScripts.Declarations.ExternalPropertyDeclarationNodeType
    {
        public MSBuildExternalPropertyDeclarationNodeType(JetBrains.ReSharper.Psi.BuildScripts.MSBuild.Parsing.MSBuildNodeTypes nodeTypes, int index) { }
        public override JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeElement Create() { }
    }
    public class MSBuildFileNodeType : JetBrains.ReSharper.Psi.BuildScripts.Tree.BuildScriptNodeType
    {
        public MSBuildFileNodeType(JetBrains.ReSharper.Psi.BuildScripts.MSBuild.Parsing.MSBuildNodeTypes nodeTypes, int index) { }
        public override JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeElement Create() { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.BuildScripts.MSBuild.MSBuildLanguage))]
    public class MSBuildNodeTypes : JetBrains.ReSharper.Psi.Xml.Tree.XmlElementTypes
    {
        public MSBuildNodeTypes(JetBrains.ReSharper.Psi.Parsing.XmlTokenTypes xmlTokenTypes) { }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType MSBUILD_ATTRIBUTE_NODE_TYPE { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType MSBUILD_COMMENT_NODE_TYPE { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType MSBUILD_EXTERNAL_PROPERTIES_NODE_TYPE { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType MSBUILD_EXTERNAL_PROPERTY_DECLARATION_NODE_TYPE { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType MSBUILD_FILE_NODE_TYPE { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType MSBUILD_HEADER_NODE_TYPE { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType MSBUILD_TAG_FOOTER_NODE_TYPE { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType MSBUILD_TAG_NODE_TYPE { get; }
    }
    public class MSBuildTagFooterNodeType : JetBrains.ReSharper.Psi.BuildScripts.Tree.BuildScriptNodeType
    {
        public MSBuildTagFooterNodeType(JetBrains.ReSharper.Psi.BuildScripts.MSBuild.Parsing.MSBuildNodeTypes nodeTypes, int index) { }
        public override JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeElement Create() { }
    }
    public class MSBuildTagHeaderNodeType : JetBrains.ReSharper.Psi.BuildScripts.Tree.BuildScriptNodeType
    {
        public MSBuildTagHeaderNodeType(JetBrains.ReSharper.Psi.BuildScripts.MSBuild.Parsing.MSBuildNodeTypes nodeTypes, int index) { }
        public override JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeElement Create() { }
    }
    public class MSBuildTagNodeType : JetBrains.ReSharper.Psi.BuildScripts.Tree.BuildScriptNodeType
    {
        public MSBuildTagNodeType(JetBrains.ReSharper.Psi.BuildScripts.MSBuild.Parsing.MSBuildNodeTypes nodeTypes, int index) { }
        public override JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeElement Create() { }
    }
    public class MSBuildTreeBuilder : JetBrains.ReSharper.Psi.Xml.Parsing.XmlTreeBuilder
    {
        public MSBuildTreeBuilder(JetBrains.ReSharper.Psi.Xml.Parsing.IXmlElementFactory xmlElementFactory, JetBrains.ReSharper.Psi.Util.ITokenIntern intern) { }
        public MSBuildTreeBuilder(JetBrains.ReSharper.Psi.Xml.Parsing.IXmlElementFactory xmlElementFactory, JetBrains.ReSharper.Psi.Xml.Parsing.IXmlElementFactoryContext context, JetBrains.ReSharper.Psi.Util.ITokenIntern intern) { }
        protected override void AppendNewChild(JetBrains.ReSharper.Psi.Tree.ITreeNode parent, JetBrains.ReSharper.Psi.Xml.Tree.IXmlComment comment) { }
        protected override void AppendNewChild(JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttribute parent, JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttributeValue child) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.BuildScripts.MSBuild.MSBuildLanguage))]
    public class MsBuildTreeNodeFactory : JetBrains.ReSharper.Psi.Xml.Parsing.XmlTreeNodeFactory
    {
        public MsBuildTreeNodeFactory([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.BuildScripts.MSBuild.MSBuildLanguage languageType, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Parsing.XmlTokenTypes tokenTypes, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xml.Tree.XmlElementTypes elementTypes, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.BuildScripts.MSBuild.Parsing.MSBuildNodeTypes nodeTypes) { }
        public override JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttribute CreateAttribute(JetBrains.ReSharper.Psi.Xml.Tree.IXmlIdentifier nameIdentifier, JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttributeContainer attributeContainer, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagContainer parentTag, JetBrains.ReSharper.Psi.Xml.Parsing.IXmlElementFactoryContext context) { }
        public override JetBrains.ReSharper.Psi.Xml.Tree.IXmlComment CreateComment() { }
        public override JetBrains.ReSharper.Psi.Xml.Tree.IXmlFile CreateFile() { }
        public override JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag CreateRootTag(JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagHeader header, JetBrains.ReSharper.Psi.Xml.Parsing.IXmlElementFactoryContext context) { }
        public override JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag CreateTag(JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagHeader header, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag parentTag, JetBrains.ReSharper.Psi.Xml.Parsing.IXmlElementFactoryContext context) { }
        public override JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagFooter CreateTagFooter(JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagContainer parentTag, JetBrains.ReSharper.Psi.Xml.Parsing.IXmlElementFactoryContext context) { }
        public override JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagHeader CreateTagHeader(JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagContainer parentTag, JetBrains.ReSharper.Psi.Xml.Parsing.IXmlElementFactoryContext context) { }
    }
}
namespace JetBrains.ReSharper.Psi.BuildScripts.MSBuild.References
{
    
    public class MSBuildItemGroupElementTagReference : JetBrains.ReSharper.Psi.BuildScripts.References.TagReference
    {
        public MSBuildItemGroupElementTagReference(JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeElement reference, JetBrains.ReSharper.Psi.TreeTextRange range, string referenceName, JetBrains.ReSharper.Psi.DeclaredElementType type) { }
        protected override void BindToInternal(JetBrains.ReSharper.Psi.BuildScripts.Tree.BuildScriptTagBase tag, JetBrains.ReSharper.Psi.Parsing.XmlTokenTypes types, string newName) { }
    }
    public class MSBuildReferenceUtil
    {
        public static System.Collections.Generic.IEnumerable<T> GetReferences<T>(JetBrains.ReSharper.Psi.Xml.Impl.Tree.XmlCompositeElement element, string text, JetBrains.ReSharper.Psi.TreeTextRange tokenRange, JetBrains.ReSharper.Psi.BuildScripts.MSBuild.References.ReferenceConstructor<T> referenceConstructor)
            where T : JetBrains.ReSharper.Psi.Resolve.IReference { }
    }
    public class MSBuildRegistryKeyReference : JetBrains.ReSharper.Psi.BuildScripts.References.AttributeReference
    {
        public MSBuildRegistryKeyReference(JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeElement reference, JetBrains.ReSharper.Psi.TreeTextRange range, JetBrains.ReSharper.Psi.TreeTextRange rangeInAttribute, string referenceName) { }
    }
    public class MSBuildUsingTaskTagReference : JetBrains.ReSharper.Psi.BuildScripts.References.TagReference
    {
        public MSBuildUsingTaskTagReference(JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeElement reference, JetBrains.ReSharper.Psi.TreeTextRange range, string referenceName, JetBrains.ReSharper.Psi.DeclaredElementType type) { }
        protected override void BindToInternal(JetBrains.ReSharper.Psi.BuildScripts.Tree.BuildScriptTagBase tag, JetBrains.ReSharper.Psi.Parsing.XmlTokenTypes types, string newName) { }
    }
    public delegate T ReferenceConstructor<T>(JetBrains.ReSharper.Psi.Xml.Impl.Tree.XmlCompositeElement element, JetBrains.ReSharper.Psi.TreeTextRange range, JetBrains.ReSharper.Psi.TreeTextRange rangeInToken, string name, JetBrains.ReSharper.Psi.DeclaredElementType type);
}
namespace JetBrains.ReSharper.Psi.BuildScripts.MSBuild.Searching
{
    
    [JetBrains.ReSharper.Psi.PsiSharedComponentAttribute()]
    public class MSBuildScriptSearcherFactory : JetBrains.ReSharper.Psi.BuildScripts.Searching.ScriptSearcherFactoryBase<JetBrains.ReSharper.Psi.BuildScripts.MSBuild.MSBuildLanguage>
    {
        public MSBuildScriptSearcherFactory(JetBrains.ReSharper.Psi.Search.SearchDomainFactory searchDomainFactory) { }
    }
}
namespace JetBrains.ReSharper.Psi.BuildScripts.MSBuild.Tasks
{
    
    public class MSBuildAttribute
    {
        public MSBuildAttribute(string name, bool isRequired, bool isOutput, string type) { }
        public bool IsOutput { get; set; }
        public bool IsRequired { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
    }
    public class MSBuildOutputAttribute : JetBrains.ReSharper.Psi.BuildScripts.MSBuild.Tasks.MSBuildAttribute
    {
        public MSBuildOutputAttribute(string name, bool isRequired, bool isOutput, JetBrains.ReSharper.Psi.BuildScripts.MSBuild.Tasks.OutputAttributeType type) { }
        public JetBrains.ReSharper.Psi.BuildScripts.MSBuild.Tasks.OutputAttributeType Type { get; }
    }
    public class MSBuildTask : JetBrains.ReSharper.Psi.BuildScripts.ITask
    {
        public MSBuildTask(string name) { }
        public MSBuildTask(string name, string qualifiedName) { }
        public string Name { get; }
        public System.Collections.Generic.Dictionary<string, JetBrains.ReSharper.Psi.BuildScripts.MSBuild.Tasks.MSBuildAttribute> OutputAttributes { get; }
        public string QualifiedName { get; }
        public void AddAttribute(JetBrains.ReSharper.Psi.BuildScripts.MSBuild.Tasks.MSBuildAttribute attribute) { }
        public void DumpToXml(System.Xml.XmlElement element, System.Xml.XmlDocument document) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.BuildScripts.MSBuild.Tasks.MSBuildAttribute> GetAllAttributes() { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.BuildScripts.MSBuild.Tasks.MSBuildAttribute> GetOutputAttributes() { }
    }
    public class MSBuildTaskFactory
    {
        public static JetBrains.ReSharper.Psi.BuildScripts.MSBuild.Tasks.MSBuildTask CreateInlineTask(string taskName, JetBrains.ReSharper.Psi.BuildScripts.MSBuild.Tree.MSBuildUsingTaskTag usingTag) { }
        public static JetBrains.ReSharper.Psi.BuildScripts.MSBuild.Tasks.MSBuildTask CreateTask(JetBrains.Metadata.Reader.API.IMetadataTypeInfo type, string name) { }
        public static JetBrains.ReSharper.Psi.BuildScripts.MSBuild.Tasks.MSBuildTask CreateTask(JetBrains.Metadata.Reader.API.IMetadataTypeInfo type, string qualifiedName, string name) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class MSBuildTaskManager
    {
        public MSBuildTaskManager(JetBrains.ProjectModel.ISolution solution) { }
        public System.Collections.Generic.Dictionary<string, JetBrains.ReSharper.Psi.BuildScripts.MSBuild.Tasks.MSBuildTask> CommonMSBuildTasks { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.BuildScripts.MSBuild.Tasks.MSBuildTask> GetAllTasks(JetBrains.ReSharper.Psi.Tree.IFile file) { }
        public System.Collections.Generic.Dictionary<string, JetBrains.ReSharper.Psi.BuildScripts.MSBuild.Tasks.MSBuildTask> GetCustomTasks(JetBrains.ReSharper.Psi.Tree.IFile file) { }
        public static JetBrains.ReSharper.Psi.BuildScripts.MSBuild.Tasks.MSBuildTaskManager GetInstance(JetBrains.ProjectModel.ISolution solution) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Psi.BuildScripts.MSBuild.Tasks.MSBuildTask GetTask(JetBrains.ReSharper.Psi.Tree.IFile file, string taskName) { }
        public bool IsResolved(JetBrains.ReSharper.Psi.Tree.IFile file, string taskName) { }
        public JetBrains.ReSharper.Psi.BuildScripts.MSBuild.Tasks.MSBuildTask MSBuildGetTask(string taskName) { }
        public bool MSBuildIsResolved(string taskName) { }
        public void ProcessUsingTaskTag(JetBrains.ReSharper.Psi.BuildScripts.MSBuild.Tree.MSBuildUsingTaskTag tag) { }
        public void ProcessUsingTaskTag(JetBrains.ReSharper.Psi.BuildScripts.MSBuild.Tree.MSBuildUsingTaskTag tag, JetBrains.ReSharper.Psi.BuildScripts.MSBuild.InclusionEngine.MSBuildExecutionContext context) { }
        public void ScanKnownAssembly(JetBrains.Util.FileSystemPath path) { }
    }
    public enum OutputAttributeType
    {
        Property = 0,
        Item = 1,
    }
}
namespace JetBrains.ReSharper.Psi.BuildScripts.MSBuild.Tree
{
    
    public interface IMSBuildItemGroupElement
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        string ItemGroupName { get; }
    }
    public class MSBuildAttribute : JetBrains.ReSharper.Psi.BuildScripts.Tree.BuildScriptAttributeBase
    {
        public MSBuildAttribute(JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType nodeType) { }
        protected override JetBrains.ReSharper.Psi.Tree.ReferenceCollection GetAttributeReferences() { }
    }
    public class MSBuildComment : JetBrains.ReSharper.Psi.Xml.Impl.Tree.XmlComment
    {
        public MSBuildComment(JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType nodeType) { }
    }
    public class MSBuildExternalPropertiesElement : JetBrains.ReSharper.Psi.BuildScripts.Tree.ExternalPropertiesElement
    {
        public MSBuildExternalPropertiesElement(JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType nodeType) { }
        public override JetBrains.ReSharper.Psi.Parsing.XmlTokenNodeType GetTokenType() { }
    }
    public class MSBuildFile : JetBrains.ReSharper.Psi.BuildScripts.Tree.BuildScriptFileBase
    {
        public MSBuildFile(JetBrains.ReSharper.Psi.BuildScripts.Tree.BuildScriptNodeType nodeType) { }
        public JetBrains.ReSharper.Psi.BuildScripts.MSBuild.MSBuildReferencesManager ReferencesManagerAlias { get; }
        public override JetBrains.ReSharper.Psi.Resolve.ISymbolTable AddDeclarationsBeforeElement(JetBrains.ReSharper.Psi.Resolve.ISymbolTable parentTable, JetBrains.ReSharper.Psi.Tree.ITreeNode element, int level, JetBrains.ReSharper.Psi.Resolve.SymbolTableMode mode) { }
        protected override JetBrains.Util.OneToSetMap<string, JetBrains.ReSharper.Psi.IDeclaredElement> FilterElements(System.Collections.Generic.JetHashSet<JetBrains.ReSharper.Psi.IDeclaredElement> elements) { }
        protected override System.Collections.Generic.List<JetBrains.ReSharper.Psi.IDeclaredElement> FindCommonDeclarations() { }
        public override System.Collections.Generic.JetHashSet<JetBrains.ReSharper.Psi.IDeclaredElement> FindGlobalDeclarations() { }
        public override short GetChildRole(JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.TreeElement child) { }
    }
    public class MSBuildImportTag : JetBrains.ReSharper.Psi.BuildScripts.MSBuild.Tree.MSBuildTag, JetBrains.ReSharper.Psi.BuildScripts.InclusionEngine.IInclusionTag, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagContainer, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTreeNode
    {
        public MSBuildImportTag(JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType nodeType) { }
        public override JetBrains.ReSharper.Psi.BuildScripts.Tree.IBuildScriptAttribute ImportAttribute { get; }
        public System.Collections.Generic.List<string> ImportedFileIds { get; set; }
        public override bool IsImportsTag { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Psi.BuildScripts.MSBuild.Tree.MSBuildAttribute Project { get; }
    }
    public class MSBuildItemDefinitionGroup : JetBrains.ReSharper.Psi.BuildScripts.MSBuild.Tree.MSBuildTag
    {
        public MSBuildItemDefinitionGroup(JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType nodeType) { }
    }
    public class MSBuildItemDefinitionGroupElement : JetBrains.ReSharper.Psi.BuildScripts.MSBuild.Tree.MSBuildTag
    {
        public MSBuildItemDefinitionGroupElement(JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType nodeType) { }
        public string ItemGroupName { get; }
    }
    public class MSBuildItemGroupElementTag : JetBrains.ReSharper.Psi.BuildScripts.MSBuild.Tree.MSBuildTag, JetBrains.ReSharper.Psi.BuildScripts.MSBuild.Tree.IMSBuildItemGroupElement
    {
        public MSBuildItemGroupElementTag(JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType nodeType) { }
        public string ItemGroupName { get; }
    }
    public class MSBuildItemGroupTag : JetBrains.ReSharper.Psi.BuildScripts.MSBuild.Tree.MSBuildTag
    {
        public MSBuildItemGroupTag(JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType nodeType) { }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Psi.BuildScripts.MSBuild.Declarations.MSBuildItemGroupDeclaration> GetItemGroupDeclarations() { }
    }
    public class MSBuildMetadataTag : JetBrains.ReSharper.Psi.BuildScripts.MSBuild.Tree.MSBuildTag
    {
        public MSBuildMetadataTag(JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType nodeType) { }
    }
    public class MSBuildOutputTag : JetBrains.ReSharper.Psi.BuildScripts.MSBuild.Tree.MSBuildTag
    {
        public MSBuildOutputTag(JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType nodeType) { }
        public bool HasItemGroupDeclaration { get; }
        public bool HasPropertyDeclaration { get; }
    }
    public class MSBuildProjectTag : JetBrains.ReSharper.Psi.BuildScripts.MSBuild.Tree.MSBuildTag, JetBrains.ReSharper.Psi.Tree.IDeclaration, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Tree.IXmlDocOwnerTreeNode
    {
        public MSBuildProjectTag(JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType nodeType) { }
        public JetBrains.ReSharper.Psi.IDeclaredElement DeclaredElement { get; }
        public string DeclaredName { get; }
        public JetBrains.ReSharper.Psi.TreeTextRange GetNameRange() { }
        public System.Xml.XmlNode GetXMLDoc(bool inherit) { }
        public bool IsSynthetic() { }
        public void SetName(string name) { }
    }
    public class MSBuildPropertyGroupTag : JetBrains.ReSharper.Psi.BuildScripts.MSBuild.Tree.MSBuildTag
    {
        public MSBuildPropertyGroupTag(JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType nodeType) { }
    }
    public class MSBuildTag : JetBrains.ReSharper.Psi.BuildScripts.Tree.BuildScriptTagBase
    {
        public MSBuildTag(JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType nodeType) { }
        protected JetBrains.ReSharper.Psi.BuildScripts.MSBuild.MSBuildLanguageService LanguageService { get; }
        protected override JetBrains.ReSharper.Psi.Tree.ReferenceCollection CreateFirstClassReferences() { }
        public override short GetChildRole(JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.TreeElement child) { }
    }
    public class MSBuildTargetTag : JetBrains.ReSharper.Psi.BuildScripts.MSBuild.Tree.MSBuildTag, JetBrains.ReSharper.Psi.BuildScripts.Tree.ITarget
    {
        public MSBuildTargetTag(JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType nodeType) { }
        public JetBrains.ReSharper.Psi.BuildScripts.Declarations.IBuildScriptDeclaration TargetDeclaration { get; }
        public string TargetName { get; }
    }
    public class MSBuildTaskTag : JetBrains.ReSharper.Psi.BuildScripts.MSBuild.Tree.MSBuildTag
    {
        public MSBuildTaskTag(JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType nodeType) { }
        public string TaskName { get; }
        protected override JetBrains.ReSharper.Psi.Tree.ReferenceCollection CreateFirstClassReferences() { }
    }
    public class MSBuildUsingTaskTag : JetBrains.ReSharper.Psi.BuildScripts.MSBuild.Tree.MSBuildTag
    {
        public MSBuildUsingTaskTag(JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType nodeType) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public string AssemblyName { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public string TaskFactory { get; }
        public string TaskName { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public string GetAssemblyFile(JetBrains.ReSharper.Psi.BuildScripts.Tree.BuildScriptFileBase file, JetBrains.ReSharper.Psi.BuildScripts.MSBuild.InclusionEngine.MSBuildExecutionContext context) { }
        public bool IsSynthetic() { }
    }
}