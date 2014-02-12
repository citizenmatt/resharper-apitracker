[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]

namespace JetBrains.ReSharper.Psi.BuildScripts.NAnt.Declarations
{
    
    public abstract class NAntAttributeBasedDeclaration : JetBrains.ReSharper.Psi.BuildScripts.NAnt.Tree.NAntAttribute, JetBrains.ReSharper.Psi.BuildScripts.Declarations.IBuildScriptDeclaration, JetBrains.ReSharper.Psi.Tree.IDeclaration, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Tree.IXmlDocOwnerTreeNode
    {
        protected NAntAttributeBasedDeclaration(JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType nodeType) { }
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
    public class NAntExternalPropertyDeclaration : JetBrains.ReSharper.Psi.BuildScripts.Declarations.ExternalPropertyDeclaration
    {
        public NAntExternalPropertyDeclaration(string name, JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType nodeType) { }
        public override JetBrains.ReSharper.Psi.BuildScripts.DeclaredElements.BuildScriptDeclaredElementBase CreateDeclaredElement(System.Collections.Generic.JetHashSet<JetBrains.ReSharper.Psi.BuildScripts.InclusionEngine.BuildScriptNode> nodes, JetBrains.ProjectModel.ISolution solution) { }
        public override JetBrains.ReSharper.Psi.DeclaredElementType GetElementType() { }
    }
    public class NAntPropertyDeclaration : JetBrains.ReSharper.Psi.BuildScripts.NAnt.Declarations.NAntAttributeBasedDeclaration, JetBrains.ReSharper.Psi.BuildScripts.Declarations.IPropertyDeclaration
    {
        public NAntPropertyDeclaration(JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType nodeType) { }
        public string PropertyName { get; }
        public override JetBrains.ReSharper.Psi.BuildScripts.DeclaredElements.BuildScriptDeclaredElementBase CreateDeclaredElement(System.Collections.Generic.JetHashSet<JetBrains.ReSharper.Psi.BuildScripts.InclusionEngine.BuildScriptNode> nodes, JetBrains.ProjectModel.ISolution solution) { }
        public override JetBrains.ReSharper.Psi.DeclaredElementType GetElementType() { }
        public System.Collections.Generic.IList<string> GetValues() { }
        public override void InitReference(JetBrains.ReSharper.Psi.BuildScripts.Tree.BuildScriptFileBase file) { }
    }
    public class NAntTargetDeclaration : JetBrains.ReSharper.Psi.BuildScripts.NAnt.Declarations.NAntAttributeBasedDeclaration
    {
        public NAntTargetDeclaration(JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType nodeType) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public string TargetName { get; }
        public override JetBrains.ReSharper.Psi.BuildScripts.DeclaredElements.BuildScriptDeclaredElementBase CreateDeclaredElement(System.Collections.Generic.JetHashSet<JetBrains.ReSharper.Psi.BuildScripts.InclusionEngine.BuildScriptNode> nodes, JetBrains.ProjectModel.ISolution solution) { }
        public override JetBrains.ReSharper.Psi.DeclaredElementType GetElementType() { }
        public override void InitReference(JetBrains.ReSharper.Psi.BuildScripts.Tree.BuildScriptFileBase file) { }
    }
    public class RegexPatternPropertyDeclaration : JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeElement, JetBrains.ReSharper.Psi.BuildScripts.Declarations.IBuildScriptDeclaration, JetBrains.ReSharper.Psi.Tree.IDeclaration, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Tree.IXmlDocOwnerTreeNode
    {
        public RegexPatternPropertyDeclaration(JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType nodeType) { }
        public RegexPatternPropertyDeclaration(string propertyName, JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType nodeType) { }
        public JetBrains.ReSharper.Psi.IDeclaredElement DeclaredElement { get; }
        public string DeclaredName { get; }
        public bool IsDeclarationValid { get; }
        public override JetBrains.ReSharper.Psi.PsiLanguageType Language { get; }
        public override JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType NodeType { get; }
        public string PropertyName { get; }
        public JetBrains.ProjectModel.ISolution Solution { get; set; }
        public JetBrains.ReSharper.Psi.BuildScripts.DeclaredElements.BuildScriptDeclaredElementBase CreateDeclaredElement(System.Collections.Generic.JetHashSet<JetBrains.ReSharper.Psi.BuildScripts.InclusionEngine.BuildScriptNode> nodes, JetBrains.ProjectModel.ISolution solution) { }
        public JetBrains.ReSharper.Psi.DeclaredElementType GetElementType() { }
        public JetBrains.ReSharper.Psi.TreeTextRange GetNameRange() { }
        public System.Xml.XmlNode GetXMLDoc(bool inherit) { }
        public void InitReference(JetBrains.ReSharper.Psi.BuildScripts.Tree.BuildScriptFileBase file) { }
        public bool IsSynthetic() { }
        public void SetDeclaredElement(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
        public void SetName(string name) { }
    }
}
namespace JetBrains.ReSharper.Psi.BuildScripts.NAnt.DeclaredElements
{
    
    public class NAntPropertyDeclaredElement : JetBrains.ReSharper.Psi.BuildScripts.DeclaredElements.PropertyDeclaredElement
    {
        public NAntPropertyDeclaredElement(string name, System.Collections.Generic.JetHashSet<JetBrains.ReSharper.Psi.BuildScripts.InclusionEngine.BuildScriptNode> nodes, JetBrains.ProjectModel.ISolution solution) { }
        public override JetBrains.ReSharper.Psi.PsiLanguageType PresentationLanguage { get; }
        public override JetBrains.ReSharper.Psi.DeclaredElementType GetElementType() { }
    }
    public class NAntTargetDeclaredElement : JetBrains.ReSharper.Psi.BuildScripts.DeclaredElements.TargetDeclaredElement
    {
        public NAntTargetDeclaredElement(string name, System.Collections.Generic.JetHashSet<JetBrains.ReSharper.Psi.BuildScripts.InclusionEngine.BuildScriptNode> nodes, JetBrains.ProjectModel.ISolution solution) { }
        public override JetBrains.ReSharper.Psi.PsiLanguageType PresentationLanguage { get; }
        public override JetBrains.ReSharper.Psi.DeclaredElementType GetElementType() { }
    }
}
namespace JetBrains.ReSharper.Psi.BuildScripts.NAnt.InclusionEngine
{
    
    public class NAntAbstractExecutor : JetBrains.ReSharper.Psi.BuildScripts.InclusionEngine.IBuildScriptFileExecutorBase
    {
        public static System.Collections.Generic.IEnumerable<string> Evaluate(string text, JetBrains.ReSharper.Psi.Xml.Impl.Tree.XmlAttribute attribute, JetBrains.ReSharper.Psi.TreeTextRange valueTokenRange, JetBrains.ReSharper.Psi.BuildScripts.NAnt.InclusionEngine.NAntExecutionContext context) { }
        public override JetBrains.ReSharper.Psi.BuildScripts.InclusionEngine.CommonExecutionContext Execute(JetBrains.ReSharper.Psi.BuildScripts.Tree.BuildScriptFileBase file, JetBrains.ProjectModel.ISolution solution, JetBrains.ProjectModel.IProject project, System.Collections.Generic.Dictionary<JetBrains.Util.FileSystemPath, JetBrains.ReSharper.Psi.Tree.IFile> cachedPsiFiles) { }
    }
    public class NAntExecutionContext : JetBrains.ReSharper.Psi.BuildScripts.InclusionEngine.CommonExecutionContext
    {
        public NAntExecutionContext(JetBrains.ReSharper.Psi.BuildScripts.NAnt.NAntLanguageService languageService, JetBrains.ProjectModel.ISolution solution, JetBrains.ProjectModel.IProject project, JetBrains.Util.FileSystemPath fileLocation, string projectName, string defaultTarget, System.Collections.Generic.Dictionary<JetBrains.Util.FileSystemPath, JetBrains.ReSharper.Psi.Tree.IFile> cachedPsiFiles) { }
        public string DefaultTarget { get; }
        public JetBrains.ReSharper.Psi.BuildScripts.NAnt.NAntLanguageService LanguageService { get; }
        public string ProjectName { get; }
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> Properties { get; }
    }
    public class NAntInclusionEngineValueEvaluator
    {
        public static System.Collections.Generic.List<string> GetAllPossibleValues(string text, JetBrains.ReSharper.Psi.Xml.Impl.Tree.XmlAttribute attribute, JetBrains.ReSharper.Psi.TreeTextRange valueTokenRange, JetBrains.ReSharper.Psi.BuildScripts.NAnt.InclusionEngine.NAntExecutionContext context) { }
    }
}
namespace JetBrains.ReSharper.Psi.BuildScripts.NAnt
{
    
    public class NAntAttributeNodeType : JetBrains.ReSharper.Psi.BuildScripts.Tree.BuildScriptNodeType
    {
        public NAntAttributeNodeType(JetBrains.ReSharper.Psi.BuildScripts.NAnt.NAntNodeTypes nodeTypes, int index) { }
        public override JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeElement Create() { }
    }
    public class NAntCommentNodeType : JetBrains.ReSharper.Psi.BuildScripts.Tree.BuildScriptNodeType
    {
        public NAntCommentNodeType(JetBrains.ReSharper.Psi.BuildScripts.NAnt.NAntNodeTypes nodeTypes, int index) { }
        public override JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeElement Create() { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class NAntCommonElementProvider : JetBrains.ReSharper.Psi.BuildScripts.ICommonElementProvider
    {
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IDeclaredElement> GetAllCommonElements(JetBrains.ReSharper.Psi.IPsiSourceFile file) { }
        public JetBrains.ReSharper.Psi.IDeclaredElement GetCommonElement(string name, JetBrains.ReSharper.Psi.DeclaredElementType expectedType, JetBrains.ReSharper.Psi.IPsiSourceFile file) { }
        public static JetBrains.ReSharper.Psi.BuildScripts.NAnt.NAntCommonElementProvider GetInstance(JetBrains.ProjectModel.ISolution solution) { }
        public bool IsCommonElement(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
    }
    public class NAntDeclarationFinder : JetBrains.ReSharper.Psi.BuildScripts.IDeclarationFinder
    {
        public System.Collections.Generic.List<JetBrains.ReSharper.Psi.Tree.IDeclaration> FindAllDeclarations(JetBrains.ReSharper.Psi.BuildScripts.Tree.BuildScriptFileBase file) { }
        public System.Collections.Generic.List<JetBrains.ReSharper.Psi.Tree.IDeclaration> FindDeclarationsBefore(JetBrains.ReSharper.Psi.BuildScripts.Tree.BuildScriptFileBase file, JetBrains.ReSharper.Psi.TreeTextRange range) { }
    }
    public class NAntDeclaredElementFinder : JetBrains.ReSharper.Psi.BuildScripts.DeclaredElementFinder
    {
        public NAntDeclaredElementFinder(JetBrains.ProjectModel.ISolution solution) { }
        protected override JetBrains.ReSharper.Psi.IDeclaredElement CreatePropertyDeclaredElement(string name, JetBrains.ProjectModel.ISolution solution) { }
        public override void ProcessAttribute(JetBrains.ReSharper.Psi.BuildScripts.Tree.BuildScriptAttributeBase attribute, JetBrains.ReSharper.Psi.BuildScripts.InclusionEngine.BuildScriptNode node) { }
        public override void ProcessTag(JetBrains.ReSharper.Psi.BuildScripts.Tree.BuildScriptTagBase tag, JetBrains.ReSharper.Psi.BuildScripts.InclusionEngine.BuildScriptNode node) { }
    }
    public class NAntDeclaredElementPresenter : JetBrains.ReSharper.Psi.BuildScripts.BuildScriptDeclaredElementPresenter
    {
        protected override string GetElementTypeName(JetBrains.ReSharper.Psi.IDeclaredElement element) { }
    }
    public class NAntDeclaredElementType : JetBrains.ReSharper.Psi.BuildScripts.BuildScriptDeclaredElementType
    {
        public static readonly JetBrains.ReSharper.Psi.DeclaredElementType NANT_PROJECT;
        public static readonly JetBrains.ReSharper.Psi.DeclaredElementType NANT_PROPERTY;
        public static readonly JetBrains.ReSharper.Psi.DeclaredElementType NANT_TARGET;
        public NAntDeclaredElementType(string presentableName, string name, JetBrains.UI.Icons.IconId imageName) { }
        protected override JetBrains.ReSharper.Psi.IDeclaredElementPresenter DefaultPresenter { get; }
    }
    public class NAntExternalPropertiesNodeType : JetBrains.ReSharper.Psi.BuildScripts.Tree.BuildScriptNodeType
    {
        public NAntExternalPropertiesNodeType(JetBrains.ReSharper.Psi.BuildScripts.NAnt.NAntNodeTypes nodeTypes, int index) { }
        public override JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeElement Create() { }
    }
    public class NAntExternalPropertyDeclarationNodeType : JetBrains.ReSharper.Psi.BuildScripts.Declarations.ExternalPropertyDeclarationNodeType
    {
        public NAntExternalPropertyDeclarationNodeType(JetBrains.ReSharper.Psi.BuildScripts.NAnt.NAntNodeTypes nodeTypes, int index) { }
        public override JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeElement Create() { }
    }
    public class NAntFileNodeType : JetBrains.ReSharper.Psi.BuildScripts.Tree.BuildScriptNodeType
    {
        public NAntFileNodeType(JetBrains.ReSharper.Psi.BuildScripts.NAnt.NAntNodeTypes nodeTypes, int index) { }
        public override JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeElement Create() { }
    }
    [JetBrains.ReSharper.Psi.LanguageDefinitionAttribute("NANT_BUILD_SCRIPT")]
    public class NAntLanguage : JetBrains.ReSharper.Psi.BuildScripts.BuildScriptLanguage
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static readonly JetBrains.ReSharper.Psi.BuildScripts.NAnt.NAntLanguage Instance;
        public const string Name = "NANT_BUILD_SCRIPT";
        protected NAntLanguage([JetBrains.Annotations.NotNullAttribute()] string name, [JetBrains.Annotations.NotNullAttribute()] string presentableName) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.BuildScripts.NAnt.NAntLanguage))]
    public class NAntLanguageService : JetBrains.ReSharper.Psi.BuildScripts.BuildScriptLanguageServiceBase
    {
        public NAntLanguageService(JetBrains.ReSharper.Psi.BuildScripts.NAnt.NAntLanguage languageType, JetBrains.ReSharper.Psi.IConstantValueService constantValueService, JetBrains.ReSharper.Psi.Parsing.XmlTokenTypes tokenTypes, JetBrains.ReSharper.Psi.Xml.Parsing.IXmlElementFactory elementFactory, JetBrains.ReSharper.Psi.Xml.Impl.CodeStyle.XmlCodeFormatter codeFormatter, JetBrains.ReSharper.Psi.Util.CommonIdentifierIntern commonIdentifierIntern) { }
        public override JetBrains.ReSharper.Psi.ExtensionsAPI.Caches2.ILanguageCacheProvider CacheProvider { get; }
        public override bool IsCaseSensitive { get; }
        public JetBrains.ReSharper.Psi.BuildScripts.NAnt.Tree.NAntPredefinedFunctions PredefinedFunctions { get; }
        public JetBrains.ReSharper.Psi.BuildScripts.NAnt.NAntPredefinedProperties PredefinedProperties { get; }
        public JetBrains.ReSharper.Psi.BuildScripts.NAnt.NAntPredefinedTags PredefinedTags { get; }
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
        public override bool IsValidName(JetBrains.ReSharper.Psi.DeclaredElementType elementType, string name) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.BuildScripts.NAnt.NAntLanguage))]
    public class NAntNodeTypes : JetBrains.ReSharper.Psi.Xml.Tree.XmlElementTypes
    {
        public NAntNodeTypes(JetBrains.ReSharper.Psi.Parsing.XmlTokenTypes xmlTokenTypes) { }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType NANT_ATTRIBUTE_NODE_TYPE { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType NANT_COMMENT_NODE_TYPE { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType NANT_EXTERNAL_PROPERTIES_NODE_TYPE { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType NANT_EXTERNAL_PROPERTY_DECLARATION_NODE_TYPE { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType NANT_FILE_NODE_TYPE { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType NANT_REGEX_PATTERN_NODE_TYPE { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType NANT_REGEX_PATTERN_PROPERTY_NODE_TYPE { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType NANT_TAG_FOOTER_NODE_TYPE { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType NANT_TAG_HEADER_NODE_TYPE { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType NANT_TAG_NODE_TYPE { get; }
    }
    public class NAntPredefinedProperties : JetBrains.ReSharper.Psi.BuildScripts.PredefinedItemsBase
    {
        public NAntPredefinedProperties() { }
        public System.Collections.Generic.IList<string> GetAll() { }
        public override System.Collections.Generic.IList<string> GetPredefinedPropertyValue(string propertyName, JetBrains.Util.FileSystemPath fileLocation, string projectName, string defaultTargets) { }
        public override bool IsPredefined(string propertyName) { }
    }
    public class NAntPredefinedTags : JetBrains.ReSharper.Psi.BuildScripts.PredefinedItemsBase
    {
        public NAntPredefinedTags() { }
        public override System.Collections.Generic.IList<string> GetPredefinedPropertyValue(string propertyName, JetBrains.Util.FileSystemPath fileLocation, string projectName, string defaultTargets) { }
        public override bool IsPredefined(string tagName) { }
    }
    [JetBrains.ProjectModel.ProjectFileTypeAttribute(typeof(JetBrains.ProjectModel.NAntProjectFileType))]
    public class NAntProjectFileLanguageService : JetBrains.ReSharper.Psi.Xml.XmlProjectFileLanguageService
    {
        public NAntProjectFileLanguageService(JetBrains.ProjectModel.NAntProjectFileType nantProjectFileType) { }
        public override JetBrains.UI.Icons.IconId Icon { get; }
        public override JetBrains.ReSharper.Psi.PsiLanguageType GetPsiLanguageType(JetBrains.ProjectModel.ProjectFileType languageType) { }
    }
    [JetBrains.ReSharper.Psi.Modules.MiscFilesProjectPsiModuleProviderAttribute()]
    public class NAntPsiModuleProvider : JetBrains.ReSharper.Psi.BuildScripts.BuildScriptPsiModuleProvider
    {
        public NAntPsiModuleProvider(JetBrains.ProjectModel.ISolution solution) { }
        protected override JetBrains.ReSharper.Psi.BuildScripts.BuildScriptModule Module { get; }
    }
    public class NAntReferencesManager : JetBrains.ReSharper.Psi.BuildScripts.ReferencesManagerBase
    {
        public NAntReferencesManager() { }
        public override void IgnoreProperty(string propertyName, JetBrains.ReSharper.Psi.BuildScripts.Tree.BuildScriptFileBase file) { }
    }
    public class NAntRegexPatternNodeType : JetBrains.ReSharper.Psi.BuildScripts.Tree.BuildScriptNodeType
    {
        public NAntRegexPatternNodeType(JetBrains.ReSharper.Psi.BuildScripts.NAnt.NAntNodeTypes nodeTypes, int index) { }
        public override JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeElement Create() { }
    }
    public class NAntRegexPatternPropertyDeclarationNodeType : JetBrains.ReSharper.Psi.BuildScripts.Tree.BuildScriptNodeType
    {
        public NAntRegexPatternPropertyDeclarationNodeType(JetBrains.ReSharper.Psi.BuildScripts.NAnt.NAntNodeTypes nodeTypes, int index) { }
        public override JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeElement Create() { }
    }
    public class NAntTagFooterNodeType : JetBrains.ReSharper.Psi.BuildScripts.Tree.BuildScriptNodeType
    {
        public NAntTagFooterNodeType(JetBrains.ReSharper.Psi.BuildScripts.NAnt.NAntNodeTypes nodeTypes, int index) { }
        public override JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeElement Create() { }
    }
    public class NAntTagHeaderNodeType : JetBrains.ReSharper.Psi.BuildScripts.Tree.BuildScriptNodeType
    {
        public NAntTagHeaderNodeType(JetBrains.ReSharper.Psi.BuildScripts.NAnt.NAntNodeTypes nodeTypes, int index) { }
        public override JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeElement Create() { }
    }
    public class NAntTagNodeType : JetBrains.ReSharper.Psi.BuildScripts.Tree.BuildScriptNodeType
    {
        public NAntTagNodeType(JetBrains.ReSharper.Psi.BuildScripts.NAnt.NAntNodeTypes nodeTypes, int index) { }
        public override JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeElement Create() { }
    }
    public class NAntValueEvaluator : JetBrains.ReSharper.Psi.BuildScripts.ValueEvaluator
    {
        public NAntValueEvaluator(JetBrains.ReSharper.Psi.BuildScripts.NAnt.NAntLanguageService languageService) { }
        protected override System.Collections.Generic.IList<string> GetPredefinedPropertyValues(JetBrains.ReSharper.Psi.BuildScripts.References.ScriptReferenceBase reference, JetBrains.ReSharper.Psi.BuildScripts.Tree.BuildScriptFileBase file) { }
        protected override bool IsPredefinedProperty(JetBrains.ReSharper.Psi.BuildScripts.References.ScriptReferenceBase reference) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.BuildScripts.NAnt.NAntLanguage))]
    public class NAntXmlLanguageSupport : JetBrains.ReSharper.Psi.Xml.XmlLanguageSupport
    {
        public override bool CanConvertAttributeToTag(JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttribute attribute) { }
        public override bool CanConvertTagToAttribute(JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag tag) { }
        public override JetBrains.ReSharper.Psi.Xml.Parsing.XmlTreeBuilder CreateTreeBuilder(JetBrains.ReSharper.Psi.Xml.Parsing.IXmlElementFactory factory, JetBrains.ReSharper.Psi.Xml.Parsing.IXmlElementFactoryContext factoryContext, JetBrains.ReSharper.Psi.Util.ITokenIntern intern) { }
        public override bool IsFormattingAllowed(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
    }
}
namespace JetBrains.ReSharper.Psi.BuildScripts.NAnt.Parsing
{
    
    public class NAntTagFactory
    {
        public NAntTagFactory(JetBrains.ReSharper.Psi.BuildScripts.NAnt.NAntNodeTypes nodeTypes) { }
        public JetBrains.ReSharper.Psi.BuildScripts.NAnt.Tree.NAntTag CreateTagNode(JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagHeader header, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagContainer parent) { }
    }
    public class NAntTreeBuilder : JetBrains.ReSharper.Psi.Xml.Parsing.XmlTreeBuilder
    {
        public NAntTreeBuilder(JetBrains.ReSharper.Psi.Xml.Parsing.IXmlElementFactory elementFactory, JetBrains.ReSharper.Psi.Xml.Parsing.IXmlElementFactoryContext factoryContext, JetBrains.ReSharper.Psi.Util.ITokenIntern intern) { }
        protected override void AppendNewChild(JetBrains.ReSharper.Psi.Tree.ITreeNode parent, JetBrains.ReSharper.Psi.Xml.Tree.IXmlComment comment) { }
        protected override void AppendNewChild(JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttribute parent, JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttributeValue child) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.BuildScripts.NAnt.NAntLanguage))]
    public class NAntTreeNodeFactory : JetBrains.ReSharper.Psi.Xml.Parsing.XmlTreeNodeFactory
    {
        public NAntTreeNodeFactory([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.BuildScripts.NAnt.NAntLanguage languageType, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Parsing.XmlTokenTypes tokenTypes, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xml.Tree.XmlElementTypes elementTypes, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.BuildScripts.NAnt.NAntNodeTypes nodeTypes) { }
        public override JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttribute CreateAttribute(JetBrains.ReSharper.Psi.Xml.Tree.IXmlIdentifier nameIdentifier, JetBrains.ReSharper.Psi.Xml.Tree.IXmlAttributeContainer attributeContainer, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagContainer parentTag, JetBrains.ReSharper.Psi.Xml.Parsing.IXmlElementFactoryContext context) { }
        public override JetBrains.ReSharper.Psi.Xml.Tree.IXmlComment CreateComment() { }
        public override JetBrains.ReSharper.Psi.Xml.Tree.IXmlFile CreateFile() { }
        public override JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag CreateRootTag(JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagHeader header, JetBrains.ReSharper.Psi.Xml.Parsing.IXmlElementFactoryContext context) { }
        public override JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag CreateTag(JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagHeader header, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag parentTag, JetBrains.ReSharper.Psi.Xml.Parsing.IXmlElementFactoryContext context) { }
        public override JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagFooter CreateTagFooter(JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagContainer parentTag, JetBrains.ReSharper.Psi.Xml.Parsing.IXmlElementFactoryContext context) { }
        public override JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagHeader CreateTagHeader(JetBrains.ReSharper.Psi.Xml.Tree.IXmlTagContainer parentTag, JetBrains.ReSharper.Psi.Xml.Parsing.IXmlElementFactoryContext context) { }
    }
}
namespace JetBrains.ReSharper.Psi.BuildScripts.NAnt.Searching
{
    
    [JetBrains.ReSharper.Psi.PsiSharedComponentAttribute()]
    public class NAntScriptSearcherFactory : JetBrains.ReSharper.Psi.BuildScripts.Searching.ScriptSearcherFactoryBase<JetBrains.ReSharper.Psi.BuildScripts.NAnt.NAntLanguage>
    {
        public NAntScriptSearcherFactory(JetBrains.ReSharper.Psi.Search.SearchDomainFactory searchDomainFactory) { }
    }
}
namespace JetBrains.ReSharper.Psi.BuildScripts.NAnt.Tasks
{
    
    public class BooleanValidator : JetBrains.ReSharper.Psi.BuildScripts.NAnt.Tasks.Validator
    {
        public override bool Validate(string value) { }
    }
    public class DateTimeValidator : JetBrains.ReSharper.Psi.BuildScripts.NAnt.Tasks.Validator
    {
        public override bool Validate(string value) { }
    }
    public class ElementComparer : System.Collections.Generic.IComparer<JetBrains.ReSharper.Psi.BuildScripts.NAnt.Tasks.NAntElement>
    {
        public int Compare(JetBrains.ReSharper.Psi.BuildScripts.NAnt.Tasks.NAntElement x, JetBrains.ReSharper.Psi.BuildScripts.NAnt.Tasks.NAntElement y) { }
    }
    public class Int32Validator : JetBrains.ReSharper.Psi.BuildScripts.NAnt.Tasks.Validator
    {
        public override bool Validate(string value) { }
    }
    public class NAntAttribute
    {
        public NAntAttribute(string name, bool required, JetBrains.ReSharper.Psi.BuildScripts.NAnt.Tasks.Validator validator) { }
        public string Name { get; }
        public bool Required { get; }
        public JetBrains.ReSharper.Psi.BuildScripts.NAnt.Tasks.Validator Validator { get; }
    }
    public class NAntElement : JetBrains.ReSharper.Psi.BuildScripts.ITask
    {
        protected System.Collections.Generic.Dictionary<string, JetBrains.ReSharper.Psi.BuildScripts.NAnt.Tasks.NAntElement> myElementsMap;
        public System.Collections.Generic.Dictionary<string, JetBrains.ReSharper.Psi.BuildScripts.NAnt.Tasks.NAntAttribute> AttributesMap { get; }
        public System.Collections.Generic.Dictionary<string, JetBrains.ReSharper.Psi.BuildScripts.NAnt.Tasks.NAntElementArray> ElementArraysMap { get; }
        public System.Collections.Hashtable ElementCollectionsMap { get; }
        public System.Collections.Generic.Dictionary<string, JetBrains.ReSharper.Psi.BuildScripts.NAnt.Tasks.NAntElement> ElementsMap { get; }
        public bool HasInnerElements { get; }
        public bool IsRawXml { get; }
        public bool IsTaskContainer { get; }
        public string Name { get; }
        public void AddAttribute(JetBrains.ReSharper.Psi.BuildScripts.NAnt.Tasks.NAntAttribute attribute) { }
        public void AddElement(JetBrains.ReSharper.Psi.BuildScripts.NAnt.Tasks.NAntElement element) { }
        public void AddElementArray(JetBrains.ReSharper.Psi.BuildScripts.NAnt.Tasks.NAntElementArray array) { }
        public void AddElementCollection(JetBrains.ReSharper.Psi.BuildScripts.NAnt.Tasks.NAntElementCollection collection) { }
        public void DumpToXml(System.Xml.XmlElement element, System.Xml.XmlDocument document) { }
        public JetBrains.ReSharper.Psi.BuildScripts.NAnt.Tasks.NAntAttribute[] GetAllAttributes() { }
        public JetBrains.ReSharper.Psi.BuildScripts.NAnt.Tasks.NAntElementArray[] GetAllElementArrays() { }
        public JetBrains.ReSharper.Psi.BuildScripts.NAnt.Tasks.NAntElementCollection[] GetAllElementCollections() { }
        public JetBrains.ReSharper.Psi.BuildScripts.NAnt.Tasks.NAntElement[] GetAllElements() { }
        public JetBrains.ReSharper.Psi.BuildScripts.NAnt.Tasks.NAntElement GetElement(string name) { }
        public JetBrains.ReSharper.Psi.BuildScripts.NAnt.Tasks.NAntElementArray GetElementArray(string possibleName) { }
        public JetBrains.ReSharper.Psi.BuildScripts.NAnt.Tasks.NAntElementCollection GetElementCollection(string collectionName) { }
        public bool IsAttribute(string name) { }
        public bool IsElement(string name) { }
        public bool IsElementArray(string name) { }
        public bool IsElementCollection(string name) { }
        public void SortContents() { }
        public class AttributeComparer : System.Collections.Generic.IComparer<JetBrains.ReSharper.Psi.BuildScripts.NAnt.Tasks.NAntAttribute>
        {
            public int Compare(JetBrains.ReSharper.Psi.BuildScripts.NAnt.Tasks.NAntAttribute x, JetBrains.ReSharper.Psi.BuildScripts.NAnt.Tasks.NAntAttribute y) { }
        }
    }
    public class NAntElementArray
    {
        public void AddContainingElement(JetBrains.ReSharper.Psi.BuildScripts.NAnt.Tasks.NAntElement element) { }
        public string[] GetAllContainingElements() { }
        public JetBrains.ReSharper.Psi.BuildScripts.NAnt.Tasks.NAntElement GetContainingElement(string name) { }
        public void SortContents() { }
    }
    public class NAntElementCollection : JetBrains.ReSharper.Psi.BuildScripts.NAnt.Tasks.NAntElement
    {
        public NAntElementCollection(string name) { }
        public new string Name { get; }
        public System.Collections.Generic.List<string> GetAllContainingElements() { }
        public JetBrains.ReSharper.Psi.BuildScripts.NAnt.Tasks.NAntElement GetContainingElement(string name) { }
        public bool IsContainingElement(string name) { }
        public new void SortContents() { }
    }
    public class NAntTask : JetBrains.ReSharper.Psi.BuildScripts.NAnt.Tasks.NAntElement
    {
        public NAntTask(string name) { }
    }
    public class NAntTaskFactory
    {
        public static JetBrains.ReSharper.Psi.BuildScripts.NAnt.Tasks.NAntTask CreateTask(JetBrains.Metadata.Reader.API.IMetadataTypeInfo task, string name, JetBrains.Metadata.Reader.API.IMetadataAssembly currentAssembly) { }
        public static JetBrains.ReSharper.Psi.BuildScripts.NAnt.Tasks.NAntTask[] FromXml(System.Xml.XmlDocument document) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class NAntTaskManager
    {
        public NAntTaskManager(JetBrains.ProjectModel.ISolution solution) { }
        public System.Collections.Generic.Dictionary<string, JetBrains.ReSharper.Psi.BuildScripts.NAnt.Tasks.NAntTask> CommonNAntTasks { get; }
        public void AddSearchDirectory(string directory) { }
        public void AddSearchDirectoryAndScan(string directory) { }
        public JetBrains.ReSharper.Psi.BuildScripts.NAnt.Tasks.NAntTask[] GetAllTasks(string nantDir) { }
        public static JetBrains.ReSharper.Psi.BuildScripts.NAnt.Tasks.NAntTaskManager GetInstance(JetBrains.ProjectModel.ISolution solution) { }
        public JetBrains.ReSharper.Psi.BuildScripts.NAnt.Tasks.NAntTask GetTask(string name, JetBrains.ReSharper.Psi.Tree.IFile file) { }
        public JetBrains.ReSharper.Psi.BuildScripts.NAnt.Tasks.NAntTask[] GetTasks(JetBrains.ReSharper.Psi.Tree.IFile file) { }
        public bool IsLoaded(JetBrains.ReSharper.Psi.BuildScripts.NAnt.Tree.NAntLoadTasksTag tag) { }
        public bool IsResolved(string taskName, JetBrains.ReSharper.Psi.Tree.IFile file) { }
        public void LoadTasksForNant(string nantDir) { }
    }
    [JetBrains.Application.Settings.SettingsKeyAttribute(typeof(JetBrains.Application.Settings.EnvironmentSettings), "NAnt settings")]
    public class NAntValidationSettings
    {
        [JetBrains.Application.Settings.SettingsEntryAttribute(null, "NAnt binaries folder")]
        public JetBrains.Util.FileSystemPath NAntFolder;
    }
    [JetBrains.ProjectModel.Settings.Upgrade.SolutionSettingsUpgraderAttribute()]
    public class NAntValidationSettingsUpgrader : JetBrains.Application.Configuration.Upgrade.ISettingsUpgrader, JetBrains.ProjectModel.Settings.Upgrade.ISolutionSettingsUpgrader
    {
        public void Upgrade(JetBrains.Application.Configuration.IComponentSettingsProvider legacySettingsProvider, JetBrains.Application.Settings.IContextBoundSettingsStore boundSettingsStore, JetBrains.DataFlow.Lifetime upgradeLifetime) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class ScriptSettings
    {
        public ScriptSettings(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Settings.ISettingsStore settingsStore) { }
        public void ChangeNAntDirectory(string fileId, JetBrains.Util.FileSystemPath nantPath, System.Func<JetBrains.DataFlow.Lifetime, JetBrains.Application.DataContext.DataContexts, JetBrains.Application.DataContext.IDataContext> fContext) { }
        public static JetBrains.ReSharper.Psi.BuildScripts.NAnt.Tasks.ScriptSettings GetInstance(JetBrains.ProjectModel.ISolution solution) { }
        public JetBrains.Util.FileSystemPath GetNAntDirectory(string fileId, System.Func<JetBrains.DataFlow.Lifetime, JetBrains.Application.DataContext.DataContexts, JetBrains.Application.DataContext.IDataContext> fContext) { }
        public void RemoveFileBinding(string fileId, System.Func<JetBrains.DataFlow.Lifetime, JetBrains.Application.DataContext.DataContexts, JetBrains.Application.DataContext.IDataContext> fContext) { }
        public void SetNAntDirectory(string fileId, JetBrains.Util.FileSystemPath nantPath, System.Func<JetBrains.DataFlow.Lifetime, JetBrains.Application.DataContext.DataContexts, JetBrains.Application.DataContext.IDataContext> fContext) { }
    }
    public class StringValidator : JetBrains.ReSharper.Psi.BuildScripts.NAnt.Tasks.Validator
    {
        public bool AllowEmpty { get; set; }
        public string Expression { get; set; }
        public override bool Validate(string value) { }
    }
    public abstract class Validator
    {
        public abstract bool Validate(string value);
    }
}
namespace JetBrains.ReSharper.Psi.BuildScripts.NAnt.Tree
{
    
    public class NAntAttribute : JetBrains.ReSharper.Psi.BuildScripts.Tree.BuildScriptAttributeBase
    {
        public NAntAttribute(JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType nodeType) { }
        public static void FillInNAntReferences(string val, JetBrains.ReSharper.Psi.TreeTextRange initialRange, JetBrains.ReSharper.Psi.Xml.Impl.Tree.XmlAttribute attribute, System.Collections.Generic.List<string> codePiecesCollection, System.Collections.Generic.List<JetBrains.ReSharper.Psi.TreeTextRange> codePiecesRanges, System.Collections.Generic.List<string> resultingReferences, System.Collections.Generic.List<JetBrains.ReSharper.Psi.TreeTextRange> resultingReferencesRanges) { }
        protected override JetBrains.ReSharper.Psi.Tree.ReferenceCollection GetAttributeReferences() { }
    }
    public class NAntElementTag : JetBrains.ReSharper.Psi.BuildScripts.NAnt.Tree.NAntTag
    {
        public NAntElementTag(JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType nodeType) { }
    }
    public class NAntExternalPropertiesElement : JetBrains.ReSharper.Psi.BuildScripts.Tree.ExternalPropertiesElement
    {
        public NAntExternalPropertiesElement(JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType nodeType) { }
        public override JetBrains.ReSharper.Psi.Parsing.XmlTokenNodeType GetTokenType() { }
    }
    public class NAntFile : JetBrains.ReSharper.Psi.BuildScripts.Tree.BuildScriptFileBase
    {
        public NAntFile(JetBrains.ReSharper.Psi.BuildScripts.Tree.BuildScriptNodeType nodeType) { }
        public override JetBrains.ReSharper.Psi.Resolve.ISymbolTable AddDeclarationsBeforeElement(JetBrains.ReSharper.Psi.Resolve.ISymbolTable parentTable, JetBrains.ReSharper.Psi.Tree.ITreeNode element, int level, JetBrains.ReSharper.Psi.Resolve.SymbolTableMode mode) { }
        protected override System.Collections.Generic.List<JetBrains.ReSharper.Psi.IDeclaredElement> FindCommonDeclarations() { }
        public override System.Collections.Generic.JetHashSet<JetBrains.ReSharper.Psi.IDeclaredElement> FindGlobalDeclarations() { }
        public override short GetChildRole(JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.TreeElement child) { }
    }
    public class NAntLoadTasksTag : JetBrains.ReSharper.Psi.BuildScripts.NAnt.Tree.NAntTag
    {
        public NAntLoadTasksTag(JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType nodeType) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Psi.BuildScripts.NAnt.Tree.NAntAttribute AssemblyAttribute { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Psi.BuildScripts.NAnt.Tree.NAntAttribute PathAttribute { get; }
        public bool TasksLoaded { get; set; }
    }
    public class NAntPredefinedFunctions : JetBrains.ReSharper.Psi.BuildScripts.PredefinedItemsBase
    {
        public NAntPredefinedFunctions() { }
        public System.Collections.Generic.IList<string> GetAll() { }
        public override System.Collections.Generic.IList<string> GetPredefinedPropertyValue(string propertyName, JetBrains.Util.FileSystemPath fileLocation, string projectName, string defaultTargets) { }
        public override bool IsPredefined(string tagName) { }
    }
    public class NAntProjectTag : JetBrains.ReSharper.Psi.BuildScripts.NAnt.Tree.NAntTag, JetBrains.ReSharper.Psi.Tree.IDeclaration, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Tree.IXmlDocOwnerTreeNode
    {
        public NAntProjectTag(JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType nodeType) { }
        public JetBrains.ReSharper.Psi.IDeclaredElement DeclaredElement { get; }
        public string DeclaredName { get; }
        public JetBrains.ReSharper.Psi.TreeTextRange GetNameRange() { }
        public System.Xml.XmlNode GetXMLDoc(bool inherit) { }
        public bool IsSynthetic() { }
        public void SetName(string name) { }
    }
    public class NAntPropertyTag : JetBrains.ReSharper.Psi.BuildScripts.NAnt.Tree.NAntTag, JetBrains.ReSharper.Psi.BuildScripts.Tree.IProperty
    {
        public NAntPropertyTag(JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType nodeType) { }
        public JetBrains.ReSharper.Psi.BuildScripts.Declarations.IBuildScriptDeclaration PropertyDeclaration { get; }
        public string PropertyName { get; }
    }
    public class NAntTag : JetBrains.ReSharper.Psi.BuildScripts.Tree.BuildScriptTagBase
    {
        public NAntTag(JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType nodeType) { }
        public override short GetChildRole(JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.TreeElement child) { }
    }
    public class NAntTagFooter : JetBrains.ReSharper.Psi.Xml.Impl.Tree.XmlTagFooterNode
    {
        public NAntTagFooter(JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType nodeType) { }
    }
    public class NAntTargetTag : JetBrains.ReSharper.Psi.BuildScripts.NAnt.Tree.NAntTag, JetBrains.ReSharper.Psi.BuildScripts.Tree.ITarget
    {
        public NAntTargetTag(JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType nodeType) { }
        public JetBrains.ReSharper.Psi.BuildScripts.Declarations.IBuildScriptDeclaration TargetDeclaration { get; }
        public string TargetName { get; }
    }
    public class NAntTaskTag : JetBrains.ReSharper.Psi.BuildScripts.NAnt.Tree.NAntElementTag
    {
        public NAntTaskTag(JetBrains.ReSharper.Psi.Xml.Tree.XmlCompositeNodeType nodeType) { }
        public bool IsTaskContainer { get; }
    }
}