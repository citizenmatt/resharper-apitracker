[assembly: JetBrains.UI.Icons.CompiledIcons.CompiledIconsPackAttribute(IconNames=new string[] {
        "Asxx"}, IconPackResourceIdentification="JetBrains.ReSharper.Psi.Asxx;component/resources/PsiAsxxIcons/ThemedIcons.PsiAsxx" +
    ".Generated.Xaml")]
[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]
[assembly: System.Windows.Markup.XmlnsDefinitionAttribute("urn:shemas-jetbrains-com:ui-application-icons-psi-asxx", "JetBrains.ReSharper.Psi.Asxx.Resources")]

namespace JetBrains.ReSharper.Psi.Asxx
{
    
    [JetBrains.ReSharper.Psi.LanguageDefinitionAttribute("ASXX")]
    public class AsxxLanguage : JetBrains.ReSharper.Psi.KnownLanguage
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static readonly JetBrains.ReSharper.Psi.Asxx.AsxxLanguage Instance;
        public const string Name = "ASXX";
        protected AsxxLanguage([JetBrains.Annotations.NotNullAttribute()] string name) { }
        protected AsxxLanguage([JetBrains.Annotations.NotNullAttribute()] string name, [JetBrains.Annotations.NotNullAttribute()] string presentableName) { }
    }
    [JetBrains.ProjectModel.ProjectFileTypeAttribute(typeof(JetBrains.ProjectModel.AsxxProjectFileType))]
    public class AsxxProjectFileLanguageService : JetBrains.ReSharper.Psi.MixedProjectFileLanguageService, JetBrains.ReSharper.Psi.IProjectFileLanguageService, JetBrains.ReSharper.Psi.Web.IWebProjectFileLanguageService
    {
        public AsxxProjectFileLanguageService(JetBrains.ProjectModel.AsxxProjectFileType asxxProjectFileType, JetBrains.ReSharper.Psi.Web.Util.WebPsiLanguageUtil webPsiLanguageUtil) { }
        public override JetBrains.UI.Icons.IconId Icon { get; }
        protected override JetBrains.ReSharper.Psi.PsiLanguageType PsiLanguageType { get; }
        public JetBrains.ReSharper.Psi.PsiLanguageType GetCodeBehindLanguage(JetBrains.Text.IBuffer buffer) { }
        public override JetBrains.ReSharper.Psi.IPsiSourceFileProperties GetPsiProperties(JetBrains.ProjectModel.IProjectFile projectFile, JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
    }
}
namespace JetBrains.ReSharper.Psi.Asxx.Directives
{
    
    public interface IAsxxDeclaredElementsCache : JetBrains.ReSharper.Psi.Web.Directives.IWebDeclaredElementsCache { }
}
namespace JetBrains.ReSharper.Psi.Asxx.Impl
{
    
    public class AsxxCodeBehindSecondaryLexerProcess : JetBrains.ReSharper.Psi.Web.WebCodeBehindSecondaryLexerProcess
    {
        public AsxxCodeBehindSecondaryLexerProcess(JetBrains.ProjectModel.AsxxProjectFileType projectFileType, JetBrains.ReSharper.Psi.Web.Util.WebPsiLanguageUtil webPsiLanguageUtil, JetBrains.ReSharper.Psi.Parsing.MixedLexer parentLexer, JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile = null) { }
        public override JetBrains.ReSharper.Psi.Parsing.ILexer TryCreateCodeBehindLexer(JetBrains.ReSharper.Psi.Parsing.ILexer baseLexer) { }
    }
    [JetBrains.ReSharper.Psi.ExtensionsAPI.GeneratedDocumentServiceAttribute(typeof(JetBrains.ProjectModel.AsxxProjectFileType))]
    public class AsxxGeneratedDocumentManager : JetBrains.ReSharper.Psi.Web.Generation.GeneratedDocumentServiceBase
    {
        public AsxxGeneratedDocumentManager(JetBrains.ProjectModel.AsxxProjectFileType projectFileType, JetBrains.ReSharper.Psi.Web.Util.WebPsiLanguageUtil webPsiLanguageUtil) { }
        public override JetBrains.ReSharper.Psi.ExtensionsAPI.ISecondaryLexingProcess CreateSecondaryLexingService(JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Psi.Parsing.MixedLexer mixedLexer, JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile = null) { }
        public override JetBrains.ReSharper.Psi.ExtensionsAPI.ISecondaryDocumentGenerationResult Generate(JetBrains.ReSharper.Psi.Files.PrimaryFileModificationInfo modificationInfo) { }
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.PsiLanguageType> GetSecondaryPsiLanguageTypes(JetBrains.ProjectModel.IProject project) { }
        public override bool IsSecondaryPsiLanguageType(JetBrains.ProjectModel.IProject project, JetBrains.ReSharper.Psi.PsiLanguageType language) { }
        public override JetBrains.ReSharper.Psi.Parsing.ILexerFactory LexerFactoryWithPreprocessor(JetBrains.ReSharper.Psi.PsiLanguageType primaryLanguage) { }
        protected override bool ReparseOriginalFile(JetBrains.ReSharper.Psi.TreeTextRange treeTextRange, string newText, JetBrains.ReSharper.Psi.Impl.Shared.RangeTranslatorWithGeneratedRangeMap rangeTranslator) { }
    }
    public class static AsxxKeywords
    {
        public const string ASSEMBLY = "Assembly";
        public const string LANGUAGE_ATTRIBUTE = "Language";
        public const string SERVICE_HOST = "ServiceHost";
        public const string WEB_HANDLER = "WebHandler";
        public const string WEB_SERVICE = "WebService";
    }
}
namespace JetBrains.ReSharper.Psi.Asxx.Impl.Directives
{
    
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class AsxxDeclaredElementsCache : JetBrains.ReSharper.Psi.Web.Impl.Directives.WebDeclaredElementsCache, JetBrains.ReSharper.Psi.Asxx.Directives.IAsxxDeclaredElementsCache, JetBrains.ReSharper.Psi.Web.Directives.IWebDeclaredElementsCache
    {
        public AsxxDeclaredElementsCache(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ReSharper.Psi.IPsiServices psiServices) { }
    }
}
namespace JetBrains.ReSharper.Psi.Asxx.Impl.References
{
    
    public sealed class AsxxFileReference<TOwner, TToken> : JetBrains.ReSharper.Psi.Asxx.Impl.References.AsxxPathReferenceBase<TOwner, TToken>, JetBrains.ReSharper.Psi.Asxx.References.IAsxxCompleteableReference, JetBrains.ReSharper.Psi.Asxx.References.IAsxxImportCompleteableReference, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IQualifiableReferenceBase, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IQualifiableReferenceWithGlobalSymbolTable, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IReferenceWithGlobalSymbolTable, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IReferenceWithQualifier, JetBrains.ReSharper.Psi.Resolve.ICompleteableReference, JetBrains.ReSharper.Psi.Resolve.IFileReference, JetBrains.ReSharper.Psi.Resolve.IPathReference, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.Util.IUserDataHolder
        where TOwner : JetBrains.ReSharper.Psi.Tree.ITreeNode
        where TToken :  class, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        public AsxxFileReference(TOwner owner, JetBrains.ReSharper.Psi.Resolve.IQualifier qualifier, TToken token, JetBrains.ReSharper.Psi.TreeTextRange rangeWithin, JetBrains.ProjectModel.ProjectFileType expectedFileType, System.Collections.Generic.ICollection<string> expectedExtensions, bool noCircular) { }
        public System.Collections.Generic.ICollection<string> ExpectedExtensions { get; }
        public JetBrains.ProjectModel.ProjectFileType ExpectedFileType { get; }
        protected override JetBrains.ReSharper.Psi.Resolve.ISymbolFilter[] GetCompletionFilters() { }
        public override JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetReferenceSymbolTable(bool useReferenceName) { }
        public override JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetSmartCompletionSymbolTable() { }
        protected override JetBrains.ReSharper.Psi.Resolve.ISymbolFilter[] GetSmartSymbolFilters() { }
    }
    public sealed class AsxxFolderReference<TOwner, TToken> : JetBrains.ReSharper.Psi.Asxx.Impl.References.AsxxPathReferenceBase<TOwner, TToken>, JetBrains.ReSharper.Psi.Resolve.IQualifier
        where TOwner : JetBrains.ReSharper.Psi.Tree.ITreeNode
        where TToken :  class, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        public AsxxFolderReference(TOwner owner, JetBrains.ReSharper.Psi.Resolve.IQualifier qualifier, TToken token, JetBrains.ReSharper.Psi.TreeTextRange rangeWithin) { }
        public bool Resolved { get; }
        public JetBrains.ReSharper.Psi.Resolve.QualifierKind GetKind() { }
        public override string GetName() { }
        protected override JetBrains.ReSharper.Psi.Resolve.ISymbolFilter[] GetSmartSymbolFilters() { }
        public JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetSymbolTable(JetBrains.ReSharper.Psi.Resolve.SymbolTableMode mode) { }
    }
    public abstract class AsxxPathReferenceBase<TOwner, TToken> : JetBrains.ReSharper.Psi.Web.References.PathReferenceBase<TOwner, TToken>, JetBrains.ReSharper.Psi.Asxx.References.IAsxxCompleteableReference, JetBrains.ReSharper.Psi.Asxx.References.IAsxxSmartCompleteableReference, JetBrains.ReSharper.Psi.Resolve.ICompleteableReference, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.Util.IUserDataHolder
        where TOwner : JetBrains.ReSharper.Psi.Tree.ITreeNode
        where TToken :  class, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        protected AsxxPathReferenceBase(TOwner owner, JetBrains.ReSharper.Psi.Resolve.IQualifier qualifier, TToken token, JetBrains.ReSharper.Psi.TreeTextRange rangeWithin) { }
        public override bool CanBeMappedOrIgnored { get; }
        protected override JetBrains.ReSharper.Psi.Resolve.IReference BindToInternal(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution) { }
        public override JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.ResolveResultWithInfo Resolve(JetBrains.ReSharper.Psi.Resolve.ISymbolTable symbolTable, JetBrains.ReSharper.Psi.Resolve.IAccessContext context) { }
    }
    public class AsxxTypeReference : JetBrains.ReSharper.Psi.Impl.Shared.References.QualifiableReferenceWithinElement<JetBrains.ReSharper.Psi.Asxx.Tree.IAsxxTreeNode, JetBrains.ReSharper.Psi.Asxx.Tree.IAsxxToken>, JetBrains.ReSharper.Psi.Asxx.References.IAsxxCompleteableReference, JetBrains.ReSharper.Psi.Asxx.References.IAsxxImportCompleteableReference, JetBrains.ReSharper.Psi.Asxx.References.IAsxxImportTypeCompleteableReference, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IQualifiableReferenceBase, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IQualifiableReferenceWithGlobalSymbolTable, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IReferenceWithGlobalSymbolTable, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IReferenceWithQualifier, JetBrains.ReSharper.Psi.Resolve.ICompleteableReference, JetBrains.ReSharper.Psi.Resolve.IQualifier, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.ReSharper.Psi.Web.Impl.WebConfig.Tree.References.IWebTypeReference, JetBrains.Util.IUserDataHolder
    {
        public AsxxTypeReference(JetBrains.ReSharper.Psi.Asxx.Tree.IAsxxTreeNode owner, JetBrains.ReSharper.Psi.Resolve.IQualifier qualifier, JetBrains.ReSharper.Psi.Asxx.Tree.IAsxxToken token, JetBrains.ReSharper.Psi.TreeTextRange rangeWithin, string expectedBaseType) { }
        public override bool CaseSensitive { get; }
        public virtual string ExpectedBaseType { get; }
        public virtual bool KeywordsAllowed { get; }
        public JetBrains.ReSharper.Psi.PsiLanguageType KeywordsLanguage { get; }
        public bool MustBePublic { get; }
        public bool Resolved { get; }
        protected override JetBrains.ReSharper.Psi.Resolve.IReference BindToInternal(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution) { }
        public JetBrains.ReSharper.Psi.Resolve.IReference FixModuleQualification(JetBrains.ReSharper.Psi.Modules.IPsiModule psiModule) { }
        protected override JetBrains.ReSharper.Psi.Resolve.ISymbolFilter[] GetCompletionFilters() { }
        public JetBrains.ReSharper.Psi.Resolve.QualifierKind GetKind() { }
        public override string GetName() { }
        public JetBrains.ReSharper.Psi.IDeclaredElement GetQualifierDeclaredElement() { }
        public override JetBrains.ReSharper.Psi.ITypeElement GetQualifierTypeElement() { }
        protected override JetBrains.ReSharper.Psi.Resolve.ISymbolFilter[] GetSmartSymbolFilters() { }
        public override JetBrains.ReSharper.Psi.Resolve.Staticness GetStaticness() { }
        public JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetSymbolTable(JetBrains.ReSharper.Psi.Resolve.SymbolTableMode mode) { }
        public int GetTypeArgumentCount() { }
        public override JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.ResolveResultWithInfo Resolve(JetBrains.ReSharper.Psi.Resolve.ISymbolTable symbolTable, JetBrains.ReSharper.Psi.Resolve.IAccessContext context) { }
    }
    public class AsxxTypeReferenceCreator : JetBrains.ReSharper.Psi.Web.Impl.WebConfig.Tree.References.IWebTypeReferenceCreator
    {
        public static readonly JetBrains.ReSharper.Psi.Asxx.Impl.References.AsxxTypeReferenceCreator Instance;
        public JetBrains.ReSharper.Psi.TreeTextRange CalcRangeWithin(JetBrains.ReSharper.Psi.Tree.ITreeNode tokenElement) { }
        public JetBrains.ReSharper.Psi.Web.Impl.WebConfig.Tree.References.IWebModuleQualificationReference CreateModuleQualificationReference(JetBrains.ReSharper.Psi.Tree.ITreeNode owner, JetBrains.ReSharper.Psi.Tree.ITreeNode token, JetBrains.ReSharper.Psi.TreeTextRange rangeWithin, bool lateBound = False) { }
        public JetBrains.ReSharper.Psi.Web.Impl.WebConfig.Tree.References.IWebNamespaceReference CreateNamespaceReference(JetBrains.ReSharper.Psi.Tree.ITreeNode owner, JetBrains.ReSharper.Psi.Resolve.IQualifier qualifier, JetBrains.ReSharper.Psi.Tree.ITreeNode token, JetBrains.ReSharper.Psi.TreeTextRange rangeWithin) { }
        public JetBrains.ReSharper.Psi.Web.WebConfig.Util.ComplexTypeParser CreateParser(string text, JetBrains.ReSharper.Psi.TreeTextRange range) { }
        public JetBrains.ReSharper.Psi.Web.Impl.WebConfig.Tree.References.IWebTypeReference CreateTypeReference(JetBrains.ReSharper.Psi.Tree.ITreeNode owner, JetBrains.ReSharper.Psi.Resolve.IQualifier qualifier, JetBrains.ReSharper.Psi.Tree.ITreeNode token, JetBrains.ReSharper.Psi.TreeTextRange rangeWithin, string expectedBaseType = null) { }
    }
}
namespace JetBrains.ReSharper.Psi.Asxx.Impl.Resolve
{
    
    public class AsxxResolveErrorType : JetBrains.ReSharper.Psi.Web.Resolve.WebResolveErrorType
    {
        public static readonly JetBrains.ReSharper.Psi.Resolve.ResolveErrorType TYPE_EXPECTED;
        protected AsxxResolveErrorType(string name, string tooltip) { }
    }
}
namespace JetBrains.ReSharper.Psi.Asxx.Impl.Searching
{
    
    [JetBrains.ReSharper.Psi.PsiSharedComponentAttribute()]
    public class AsxxSearcherFactory : JetBrains.ReSharper.Psi.ExtensionsAPI.IDomainSpecificSearcherFactory
    {
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
        public System.Collections.Generic.IEnumerable<JetBrains.Util.Pair<JetBrains.ReSharper.Psi.IDeclaredElement, System.Predicate<JetBrains.ReSharper.Psi.Search.FindResult>>> GetRelatedDeclaredElements(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
        public bool IsCompatibleWithLanguage(JetBrains.ReSharper.Psi.PsiLanguageType languageType) { }
        public System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.Search.FindResult> TransformNavigationTargets(System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.Search.FindResult> targets) { }
    }
}
namespace JetBrains.ReSharper.Psi.Asxx.Impl.Tree
{
    
    public class static AsxxDirectiveNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Psi.Asxx.Tree.IAsxxDirective GetByAttribute([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Asxx.Tree.IAsxxDirectiveAttribute attribute) { }
    }
}
namespace JetBrains.ReSharper.Psi.Asxx.Impl.Website
{
    
    [JetBrains.ProjectModel.ProjectFileTypeAttribute(typeof(JetBrains.ProjectModel.AsxxProjectFileType))]
    public class WebAsxxProjectFileClassifier : JetBrains.ReSharper.Psi.Web.PsiModules.IWebProjectFileClassifier
    {
        public bool CanBeAppCodeFile(JetBrains.ProjectModel.IProjectFile projectFile) { }
        public bool CanBeAspFile(JetBrains.ProjectModel.IProjectFile projectFile) { }
        public bool CanBeCodeBehindFile(JetBrains.ProjectModel.IProjectFile projectFile) { }
    }
}
namespace JetBrains.ReSharper.Psi.Asxx.Parsing
{
    
    public class static AsxxElementFactory
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.ReSharper.Psi.Asxx.Tree.IAsxxDirective CreateDirective([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode contextElement, JetBrains.Text.IBuffer buffer) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.ReSharper.Psi.Asxx.Tree.IAsxxDirective CreateDirective([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode contextElement, string directiveName, params JetBrains.Util.Pair<, >[] attributes) { }
    }
    public class AsxxLexerFactory : JetBrains.ReSharper.Psi.Parsing.ILexerFactory
    {
        public static readonly JetBrains.ReSharper.Psi.Asxx.Parsing.AsxxLexerFactory Instance;
        public JetBrains.ReSharper.Psi.Parsing.ILexer CreateLexer(JetBrains.Text.IBuffer buffer) { }
    }
    public class AsxxRawLexer : JetBrains.ReSharper.Psi.Asxx.Parsing.AsxxRawLexerGenerated
    {
        public AsxxRawLexer(JetBrains.Text.IBuffer buffer) { }
        public AsxxRawLexer(JetBrains.Text.IBuffer buffer, int startOffset, int endOffset) { }
        protected override void locateToken() { }
    }
    public class AsxxRawLexerGenerated : JetBrains.ReSharper.Psi.Parsing.IIncrementalLexer, JetBrains.ReSharper.Psi.Parsing.ILexer, JetBrains.ReSharper.Psi.Parsing.ILexerEx
    {
        protected JetBrains.ReSharper.Psi.Parsing.TokenNodeType currTokenType;
        protected const int YY_IN_DIRECTIVE = 1;
        protected const int YY_IN_DIRECTIVE_ATTRS = 2;
        protected const int YY_IN_DIRECTIVE_ATTRS_EQ = 3;
        protected const int YY_IN_DIRECTIVE_ATTRS_VALUE = 4;
        protected const int YYINITIAL = 0;
        public AsxxRawLexerGenerated(JetBrains.Text.IBuffer buffer) { }
        public AsxxRawLexerGenerated(JetBrains.Text.IBuffer buffer, int startOffset, int endOffset) { }
        public JetBrains.Text.IBuffer Buffer { get; }
        protected int BufferEnd { get; set; }
        protected int BufferIndex { get; set; }
        protected int BufferStart { get; set; }
        public object CurrentPosition { get; set; }
        public int EOFPos { get; }
        public int LexemIndent { get; }
        public uint LexerStateEx { get; }
        protected int LexicalState { get; set; }
        public static short NStates { get; }
        public int TokenEnd { get; }
        public int TokenStart { get; }
        public JetBrains.ReSharper.Psi.Parsing.TokenNodeType TokenType { get; }
        public JetBrains.ReSharper.Psi.Parsing.TokenNodeType _locateToken() { }
        public void Advance() { }
        protected virtual void locateToken() { }
        protected JetBrains.ReSharper.Psi.Parsing.TokenNodeType makeToken(JetBrains.ReSharper.Psi.Parsing.TokenNodeType type) { }
        public void Start() { }
        public void Start(int startOffset, int endOffset, uint state) { }
    }
    public class AsxxTokenNodeType : JetBrains.ReSharper.Psi.Parsing.TokenNodeType
    {
        public static readonly JetBrains.ReSharper.Psi.Asxx.Parsing.AsxxTokenNodeType ATTRIBUTE_VALUE;
        public static readonly JetBrains.ReSharper.Psi.Asxx.Parsing.AsxxTokenNodeType CODE;
        public static readonly JetBrains.ReSharper.Psi.Asxx.Parsing.AsxxTokenNodeType CODE_INTERNAL;
        public static readonly JetBrains.ReSharper.Psi.Asxx.Parsing.AsxxTokenNodeType DIRECTIVE_END;
        public static readonly JetBrains.ReSharper.Psi.Asxx.Parsing.AsxxTokenNodeType DIRECTIVE_START;
        public static readonly JetBrains.ReSharper.Psi.Asxx.Parsing.AsxxTokenNodeType EQ;
        public static readonly JetBrains.ReSharper.Psi.Asxx.Parsing.AsxxTokenNodeType ERROR;
        public static readonly JetBrains.ReSharper.Psi.Asxx.Parsing.AsxxTokenNodeType IDENTIFIER;
        public static readonly JetBrains.ReSharper.Psi.Asxx.Parsing.AsxxTokenNodeType NEW_LINE;
        public static readonly JetBrains.ReSharper.Psi.Asxx.Parsing.AsxxTokenNodeType WHITE_SPACE;
        public override bool IsComment { get; }
        public override bool IsConstantLiteral { get; }
        public override bool IsIdentifier { get; }
        public override bool IsKeyword { get; }
        public override bool IsStringLiteral { get; }
        public override bool IsWhitespace { get; }
        public override string TokenRepresentation { get; }
        public override JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.LeafElementBase Create(JetBrains.Text.IBuffer buffer, JetBrains.ReSharper.Psi.TreeOffset startOffset, JetBrains.ReSharper.Psi.TreeOffset endOffset) { }
    }
    public class AsxxTreeBuilder
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.ReSharper.Psi.Asxx.Tree.IAsxxDirective CreateDirective(string directiveName, params JetBrains.Util.Pair<, >[] attributes) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.ReSharper.Psi.Asxx.Tree.IAsxxFile ParseFile(string text) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.ReSharper.Psi.Asxx.Tree.IAsxxFile ParseFile(JetBrains.Text.IBuffer buffer) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.ReSharper.Psi.Asxx.Tree.IAsxxFile ParseFile(JetBrains.ReSharper.Psi.Parsing.ILexer lexer) { }
    }
}
namespace JetBrains.ReSharper.Psi.Asxx.References
{
    
    public interface IAsxxCompleteableReference : JetBrains.ReSharper.Psi.Resolve.ICompleteableReference, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.Util.IUserDataHolder { }
    public interface IAsxxImportCompleteableReference : JetBrains.ReSharper.Psi.Asxx.References.IAsxxCompleteableReference, JetBrains.ReSharper.Psi.Resolve.ICompleteableReference, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.Util.IUserDataHolder { }
    public interface IAsxxImportTypeCompleteableReference : JetBrains.ReSharper.Psi.Asxx.References.IAsxxCompleteableReference, JetBrains.ReSharper.Psi.Asxx.References.IAsxxImportCompleteableReference, JetBrains.ReSharper.Psi.Resolve.ICompleteableReference, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.Util.IUserDataHolder
    {
        JetBrains.ReSharper.Psi.IDeclaredElement GetQualifierDeclaredElement();
    }
    public interface IAsxxSmartCompleteableReference : JetBrains.ReSharper.Psi.Asxx.References.IAsxxCompleteableReference, JetBrains.ReSharper.Psi.Resolve.ICompleteableReference, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.Util.IUserDataHolder
    {
        JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetSmartCompletionSymbolTable();
    }
}
namespace JetBrains.ReSharper.Psi.Asxx.Resources
{
    
    public sealed class PsiAsxxThemedIcons
    {
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Psi.Asxx;component/resources/PsiAsxxIcons/ThemedIcons.PsiAsxx" +
            ".Generated.Xaml", 0, "Asxx")]
        public sealed class Asxx : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
    }
}
namespace JetBrains.ReSharper.Psi.Asxx.Tree
{
    
    public class static AsxxDirectiveAttributeExtensions
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public static string GetUnquotedValue([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Asxx.Tree.IAsxxDirectiveAttribute attribute) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.ReSharper.Psi.TreeTextRange GetUnquotedValueRange([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Asxx.Tree.IAsxxDirectiveAttribute attribute) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.ReSharper.Psi.TreeTextRange GetUnquotedValueRangeWithin([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Asxx.Tree.IAsxxDirectiveAttribute attribute) { }
    }
    public interface IAsxxCodeBlock : JetBrains.ReSharper.Psi.Asxx.Tree.IAsxxTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode
    {
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Asxx.Tree.IAsxxToken CodeToken { get; }
    }
    public interface IAsxxDirective : JetBrains.ReSharper.Psi.Asxx.Tree.IAsxxTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebAttributeContainer<JetBrains.ReSharper.Psi.Asxx.Tree.IAsxxDirectiveAttribute>, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode
    {
        string DirectiveName { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Asxx.Tree.IAsxxToken EndToken { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Asxx.Tree.IAsxxToken NameToken { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Asxx.Tree.IAsxxToken StartToken { get; }
    }
    public interface IAsxxDirectiveAttribute : JetBrains.ReSharper.Psi.Asxx.Tree.IAsxxTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebAttribute, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Asxx.Tree.IAsxxToken EqToken { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Asxx.Tree.IAsxxToken NameToken { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Asxx.Tree.IAsxxToken ValueToken { get; }
    }
    public interface IAsxxFile : JetBrains.ReSharper.Psi.Asxx.Tree.IAsxxTreeNode, JetBrains.ReSharper.Psi.Tree.IFile, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebFile, JetBrains.ReSharper.Psi.Web.Tree.IWebFileWithCodeBehind, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode
    {
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Asxx.Tree.IAsxxCodeBlock> GetCodeBlocks();
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Asxx.Tree.IAsxxDirective> GetDirectives();
    }
    public interface IAsxxFileNode : JetBrains.ReSharper.Psi.Asxx.Tree.IAsxxTreeNode, JetBrains.ReSharper.Psi.Tree.IFile, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode { }
    public interface IAsxxMainDirective : JetBrains.ReSharper.Psi.Asxx.Tree.IAsxxDirective, JetBrains.ReSharper.Psi.Asxx.Tree.IAsxxTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebAttributeContainer<JetBrains.ReSharper.Psi.Asxx.Tree.IAsxxDirectiveAttribute>, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Asxx.Tree.IAsxxDirectiveAttribute LanguageAttribute { get; }
    }
    public interface IAsxxToken : JetBrains.ReSharper.Psi.Asxx.Tree.IAsxxTreeNode, JetBrains.ReSharper.Psi.Tree.ITokenNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode
    {
        JetBrains.ReSharper.Psi.TreeTextRange GetUnquotedRangeWithin();
        string GetUnquotedText();
        JetBrains.ReSharper.Psi.TreeOffset GetUnquotedTreeStartOffset();
        JetBrains.ReSharper.Psi.TreeTextRange GetUnquotedTreeTextRange();
    }
    public interface IAsxxTreeNode : JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode { }
}
namespace JetBrains.ReSharper.Psi.Asxx.Util
{
    
    public class static AsxxModificationUtil
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.ReSharper.Psi.Asxx.Tree.IAsxxToken CreateToken(JetBrains.ReSharper.Psi.Parsing.TokenNodeType tokenType, string tokenText) { }
        public static bool FixAsxxDirective([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Asxx.Tree.IAsxxDirective directive) { }
        public static bool FixAsxxDirectiveAttribute([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Asxx.Tree.IAsxxDirectiveAttribute attribute) { }
    }
    public class static AsxxPathReferenceUtil
    {
        public static JetBrains.ReSharper.Psi.Resolve.IReference[] CreatePathReferences<TOwner, TToken>([JetBrains.Annotations.NotNullAttribute()] TOwner owner, [JetBrains.Annotations.NotNullAttribute()] TToken token, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Resolve.IQualifier baseQualifier, [JetBrains.Annotations.NotNullAttribute()] System.Func<TOwner, JetBrains.ReSharper.Psi.Resolve.IQualifier, TToken, JetBrains.ReSharper.Psi.TreeTextRange, JetBrains.ReSharper.Psi.Resolve.IPathReference> createFolderReferenceDelegate, [JetBrains.Annotations.NotNullAttribute()] System.Func<TOwner, JetBrains.ReSharper.Psi.Resolve.IQualifier, TToken, JetBrains.ReSharper.Psi.TreeTextRange, JetBrains.ReSharper.Psi.Resolve.IPathReference> createFileReferenceDelegate)
            where TOwner : JetBrains.ReSharper.Psi.Tree.ITreeNode
            where TToken :  class, JetBrains.ReSharper.Psi.Tree.ITreeNode { }
        public static JetBrains.ReSharper.Psi.Resolve.IReference[] CreatePathReferences<TOwner, TToken>([JetBrains.Annotations.NotNullAttribute()] TOwner owner, [JetBrains.Annotations.NotNullAttribute()] TToken token, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Resolve.IQualifier baseQualifier, [JetBrains.Annotations.NotNullAttribute()] System.Func<TOwner, JetBrains.ReSharper.Psi.Resolve.IQualifier, TToken, JetBrains.ReSharper.Psi.TreeTextRange, JetBrains.ReSharper.Psi.Resolve.IPathReference> createFolderReferenceDelegate, [JetBrains.Annotations.NotNullAttribute()] System.Func<TOwner, JetBrains.ReSharper.Psi.Resolve.IQualifier, TToken, JetBrains.ReSharper.Psi.TreeTextRange, JetBrains.ReSharper.Psi.Resolve.IPathReference> createFileReferenceDelegate, JetBrains.ReSharper.Psi.TreeTextRange rangeWithin)
            where TOwner : JetBrains.ReSharper.Psi.Tree.ITreeNode
            where TToken :  class, JetBrains.ReSharper.Psi.Tree.ITreeNode { }
    }
    public class static AsxxReferenceWithTokenUtil
    {
        public static JetBrains.ReSharper.Psi.Tree.ITreeNode CreateNewToken<TToken>(TToken oldToken, JetBrains.Text.IBuffer buffer)
            where TToken :  class, JetBrains.ReSharper.Psi.Tree.ITreeNode { }
        public static JetBrains.ReSharper.Psi.Impl.Shared.References.IReferenceWithinElement<TToken> SetText<TToken>(JetBrains.ReSharper.Psi.Impl.Shared.References.IReferenceWithinElement<TToken> reference, string newText)
            where TToken :  class, JetBrains.ReSharper.Psi.Tree.ITreeNode { }
        public static JetBrains.ReSharper.Psi.Tree.ITreeNode SetText<TOwner, TToken>(TToken token, JetBrains.ReSharper.Psi.TreeTextRange rangeWithin, string newText, TOwner elementToRemoveReferences)
            where TOwner : JetBrains.ReSharper.Psi.Tree.ITreeNode
            where TToken :  class, JetBrains.ReSharper.Psi.Tree.ITreeNode { }
    }
}