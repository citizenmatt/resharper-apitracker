[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]

namespace JetBrains.ReSharper.Psi.Asp.CSharp.CodeStyle
{
    
    [JetBrains.Application.Settings.SettingsKeyAttribute(typeof(JetBrains.ReSharper.Psi.CSharp.CodeStyle.FormatSettings.CSharpFormatSettingsKey), "Code formatting in ASP.NET C#")]
    public class AspCSharpFormatSettings
    {
        [JetBrains.Application.Settings.SettingsEntryAttribute(false, "Override brace style for C# to always use \"At end of line (K&&R style)\"")]
        public bool AlwaysUseEndOfLineBraceStyle;
        [JetBrains.Application.Settings.SettingsEntryAttribute(false, "Enable wrapping")]
        public bool EnableWrapping;
    }
}
namespace JetBrains.ReSharper.Psi.Asp.CSharp.CustomReferences
{
    
    public class CSharpHtmlTagAttributeReference : JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.QualifiableCheckedReferenceBase<JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpIdentifier>, JetBrains.ReSharper.Psi.Resolve.ICompleteableReference, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.Util.IUserDataHolder
    {
        public CSharpHtmlTagAttributeReference(JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpIdentifier owner, string htmlElementName) { }
        public override bool HasMultipleNames { get; }
        public override bool IsQualified { get; }
        public override JetBrains.ReSharper.Psi.Resolve.IReference BindTo(JetBrains.ReSharper.Psi.IDeclaredElement element) { }
        public override JetBrains.ReSharper.Psi.Resolve.IReference BindTo(JetBrains.ReSharper.Psi.IDeclaredElement element, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution) { }
        public override JetBrains.ReSharper.Psi.Resolve.IAccessContext GetAccessContext() { }
        public override System.Collections.Generic.IEnumerable<string> GetAllNames() { }
        public JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetCompletionSymbolTable() { }
        public override string GetName() { }
        public override JetBrains.ReSharper.Psi.Resolve.IQualifier GetQualifier() { }
        public override JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.ResolveResultWithInfo GetResolveResult(JetBrains.ReSharper.Psi.Resolve.ISymbolTable symbolTable, string referenceName) { }
        public override JetBrains.ReSharper.Psi.Resolve.ISymbolFilter[] GetSymbolFilters() { }
        public override JetBrains.ReSharper.Psi.TreeTextRange GetTreeTextRange() { }
        public override JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.ResolveResultWithInfo Resolve(JetBrains.ReSharper.Psi.Resolve.ISymbolTable symbolTable, JetBrains.ReSharper.Psi.Resolve.IAccessContext context) { }
    }
    public class CssClassReferenceInsideAnonymousMemberReferenceProvider : JetBrains.ReSharper.Psi.Resolve.IReferenceFactory
    {
        public JetBrains.ReSharper.Psi.Resolve.IReference[] GetReferences(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.Resolve.IReference[] oldReferences) { }
        public bool HasReference(JetBrains.ReSharper.Psi.Tree.ITreeNode element, System.Collections.Generic.ICollection<string> names) { }
    }
    public class HtmlAttributeForAnonymousMemberReferenceProvider : JetBrains.ReSharper.Psi.Resolve.IReferenceFactory
    {
        public JetBrains.ReSharper.Psi.Resolve.IReference[] GetReferences(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.Resolve.IReference[] oldReferences) { }
        public bool HasReference(JetBrains.ReSharper.Psi.Tree.ITreeNode element, System.Collections.Generic.ICollection<string> names) { }
    }
    public class HtmlTagAttributeQualifier : JetBrains.ReSharper.Psi.Resolve.IQualifier
    {
        public HtmlTagAttributeQualifier(JetBrains.ReSharper.Psi.Resolve.IReference reference, string htmlElementName) { }
        public bool Resolved { get; }
        public JetBrains.ReSharper.Psi.Resolve.QualifierKind GetKind() { }
        public JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetSymbolTable(JetBrains.ReSharper.Psi.Resolve.SymbolTableMode mode) { }
    }
    public class HtmlTagIdReferenceInsideAnonymousMemberReferenceProvider : JetBrains.ReSharper.Psi.Resolve.IReferenceFactory
    {
        public JetBrains.ReSharper.Psi.Resolve.IReference[] GetReferences(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.Resolve.IReference[] oldReferences) { }
        public bool HasReference(JetBrains.ReSharper.Psi.Tree.ITreeNode element, System.Collections.Generic.ICollection<string> names) { }
    }
}
namespace JetBrains.ReSharper.Psi.Asp.CSharp.Impl
{
    
    [JetBrains.ProjectModel.ProjectFileTypeAttribute(typeof(JetBrains.ProjectModel.AspProjectFileType))]
    public class AspCSharpProjectFileCustomPsiPropertiesProvider : JetBrains.ReSharper.Psi.IProjectFileCustomPsiPropertiesProvider
    {
        public T GetCustomProperties<T>(JetBrains.ProjectModel.IProjectFile projectFile, JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
    }
}
namespace JetBrains.ReSharper.Psi.Asp.CSharp.Impl.CodeStyle
{
    
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.CSharp.CSharpLanguage))]
    public class AspCSharpHtmlCustomFormattingInfoProvider : JetBrains.ReSharper.Psi.Asp.Impl.CodeStyle.IAspCustomFormattingInfoProvider
    {
        public JetBrains.Util.Pair<JetBrains.ReSharper.Psi.TreeTextRange, JetBrains.ReSharper.Psi.Tree.ITreeNode> GetBlockInfo(JetBrains.ReSharper.Psi.Tree.ITreeNode token) { }
    }
}
namespace JetBrains.ReSharper.Psi.Asp.CSharp.Impl.Generate
{
    
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.CSharp.CSharpLanguage))]
    public class AspCSharpCodeBehindGenerator : JetBrains.ReSharper.Psi.Asp.Impl.Generate.AspCodeBehindGenerator
    {
        public const string LEADING_COMMENT = "/**/";
        public const string TRAILING_COMMENT = "/*__RESHARPER__*/";
        public AspCSharpCodeBehindGenerator(JetBrains.ReSharper.Psi.CSharp.CSharpLanguage language, JetBrains.ReSharper.Psi.Asp.Impl.UniqueIdGenerator idGenerator) { }
        protected override bool AppendLineInRenderBlock { get; }
        protected override string DelimiterComment { get; }
        protected override string EndOfExpression { get; }
        protected override bool IsCaseSensitive { get; }
        protected override string LeadingComment { get; }
        protected override string TrailerComment { get; }
        protected override string UsingFormatString { get; }
        protected override JetBrains.ReSharper.Psi.Web.Generation.GenerationResults GenerateClassDeclEnd(bool closeNamespace) { }
        protected override JetBrains.ReSharper.Psi.Web.Generation.GenerationResults GenerateClassDeclStart(string className, JetBrains.ReSharper.Psi.Impl.Shared.ElementRange<JetBrains.ReSharper.Psi.Html.Tree.IHtmlToken> classNameRange, JetBrains.ReSharper.Psi.Asp.Tree.IAspFile aspFile) { }
        protected override JetBrains.ReSharper.Psi.Web.Generation.GenerationResults GenerateDataBindingMethodEnd() { }
        protected override JetBrains.ReSharper.Psi.Web.Generation.GenerationResults GenerateDataBindingMethodStart(string name) { }
        protected override JetBrains.ReSharper.Psi.Web.Generation.GenerationResults GenerateDataBindingVariable(string name, System.Collections.Generic.IEnumerable<string> fieldNames) { }
        protected override JetBrains.ReSharper.Psi.Web.Generation.GenerationResults GenerateMethodEnd() { }
        protected override JetBrains.ReSharper.Psi.Web.Generation.GenerationResults GenerateNamespaceStart(string namespaceName, JetBrains.ReSharper.Psi.Impl.Shared.ElementRange<JetBrains.ReSharper.Psi.Html.Tree.IHtmlToken> namespaceNameRange, JetBrains.ReSharper.Psi.Asp.Tree.IAspFile aspFile) { }
        protected override JetBrains.ReSharper.Psi.Web.Generation.GenerationResults GenerateScriptBody(JetBrains.ReSharper.Psi.Asp.Tree.IAspScriptTag scriptTag, JetBrains.ReSharper.Psi.Asp.Tree.IAspFile aspFile) { }
        protected override JetBrains.ReSharper.Psi.Web.Generation.GenerationResults GenerateSyntheticMethodStart() { }
    }
}
namespace JetBrains.ReSharper.Psi.Asp.CSharp.Impl.References
{
    
    [JetBrains.ReSharper.Psi.Resolve.ReferenceProviderFactoryAttribute()]
    public class AspCSharpGeneratedCodeReferenceProviderFactory : JetBrains.ReSharper.Psi.Asp.Impl.References.AspGeneratedCodeReferenceProviderFactory<JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpFile>
    {
        public AspCSharpGeneratedCodeReferenceProviderFactory(JetBrains.ReSharper.Psi.Asp.Html.IAspDeclaredElementTypes aspDeclaredElementTypes) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.CSharp.CSharpLanguage))]
    public class AspCSharpTypeReferenceDecorator : JetBrains.ReSharper.Psi.Asp.Impl.References.IAspTypeReferenceDecorator
    {
        public string TypeArgumentPrefix { get; }
        public string TypeArgumentsCountFormat { get; }
        public string TypeArgumentsPrefix { get; }
        public string TypeArgumentsSuffix { get; }
        public string TypeArgumentSuffix { get; }
    }
}
namespace JetBrains.ReSharper.Psi.Asp.CSharp.Impl.Resolve
{
    
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.CSharp.CSharpLanguage))]
    public class AspCSharpMethodGroupConvertibleFilterFactory : JetBrains.ReSharper.Psi.Asp.Impl.Resolve.IAspMethodGroupConvertibleFilterFactory
    {
        public JetBrains.ReSharper.Psi.Resolve.ISymbolFilter CreateMethodGroupConvertibleFilter(JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode context, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.DeclaredElementInstance<JetBrains.ReSharper.Psi.IDelegate> eventType) { }
    }
}
namespace JetBrains.ReSharper.Psi.Asp.CSharp.Injection
{
    
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class CssStyleIntoCsAnonymousMemberDeclarationInjection : JetBrains.ReSharper.Psi.Impl.Shared.InjectedPsi.IndependentInjectedPsiProvider
    {
        public override JetBrains.ReSharper.Psi.PsiLanguageType GeneratedLanguage { get; }
        protected override bool CanBeGeneratedNode(JetBrains.ReSharper.Psi.Tree.ITreeNode node) { }
        protected override bool CanBeOriginalNode(JetBrains.ReSharper.Psi.Tree.ITreeNode node) { }
        protected override JetBrains.ReSharper.Psi.ExtensionsAPI.IInjectedNodeContext CreateInjectedFileAndContext(JetBrains.ReSharper.Psi.ExtensionsAPI.IInjectedFileContext fileContext, JetBrains.ReSharper.Psi.Tree.ITreeNode originalNode, JetBrains.Text.IBuffer buffer, JetBrains.ReSharper.Psi.LanguageService languageService, int originalStartOffset, int originalEndOffset, int generatedStartOffset = 0, int generatedEndOffset = -1) { }
        public override JetBrains.ReSharper.Psi.ExtensionsAPI.IInjectedFileContext CreateInjectedFileContext(JetBrains.ReSharper.Psi.Tree.IFile originalFile) { }
        public override JetBrains.ReSharper.Psi.ExtensionsAPI.IInjectedNodeContext CreateInjectedNodeContext(JetBrains.ReSharper.Psi.ExtensionsAPI.IInjectedFileContext fileContext, JetBrains.ReSharper.Psi.Tree.ITreeNode originalNode) { }
        public override bool IsApplicable(JetBrains.ReSharper.Psi.PsiLanguageType originalLanguage) { }
        public override bool IsApplicableToNode(JetBrains.ReSharper.Psi.Tree.ITreeNode node, JetBrains.ReSharper.Psi.ExtensionsAPI.IInjectedFileContext context) { }
        public override void Regenerate(JetBrains.ReSharper.Psi.Impl.Shared.InjectedPsi.IndependentInjectedNodeContext nodeContext) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class CssStyleIntoCsCollectionElementInitializerInjection : JetBrains.ReSharper.Psi.Impl.Shared.InjectedPsi.IndependentInjectedPsiProvider
    {
        public override JetBrains.ReSharper.Psi.PsiLanguageType GeneratedLanguage { get; }
        protected override bool CanBeGeneratedNode(JetBrains.ReSharper.Psi.Tree.ITreeNode node) { }
        protected override bool CanBeOriginalNode(JetBrains.ReSharper.Psi.Tree.ITreeNode node) { }
        protected override JetBrains.ReSharper.Psi.ExtensionsAPI.IInjectedNodeContext CreateInjectedFileAndContext(JetBrains.ReSharper.Psi.ExtensionsAPI.IInjectedFileContext fileContext, JetBrains.ReSharper.Psi.Tree.ITreeNode originalNode, JetBrains.Text.IBuffer buffer, JetBrains.ReSharper.Psi.LanguageService languageService, int originalStartOffset, int originalEndOffset, int generatedStartOffset = 0, int generatedEndOffset = -1) { }
        public override JetBrains.ReSharper.Psi.ExtensionsAPI.IInjectedFileContext CreateInjectedFileContext(JetBrains.ReSharper.Psi.Tree.IFile originalFile) { }
        public override JetBrains.ReSharper.Psi.ExtensionsAPI.IInjectedNodeContext CreateInjectedNodeContext(JetBrains.ReSharper.Psi.ExtensionsAPI.IInjectedFileContext fileContext, JetBrains.ReSharper.Psi.Tree.ITreeNode originalNode) { }
        public override bool IsApplicable(JetBrains.ReSharper.Psi.PsiLanguageType originalLanguage) { }
        public override bool IsApplicableToNode(JetBrains.ReSharper.Psi.Tree.ITreeNode node, JetBrains.ReSharper.Psi.ExtensionsAPI.IInjectedFileContext context) { }
        public override void Regenerate(JetBrains.ReSharper.Psi.Impl.Shared.InjectedPsi.IndependentInjectedNodeContext nodeContext) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class CssStyleIntoCsLiteralExpressionInjection : JetBrains.ReSharper.Psi.Impl.Shared.InjectedPsi.IndependentInjectedPsiProvider
    {
        public override JetBrains.ReSharper.Psi.PsiLanguageType GeneratedLanguage { get; }
        protected override bool CanBeGeneratedNode(JetBrains.ReSharper.Psi.Tree.ITreeNode node) { }
        protected override bool CanBeOriginalNode(JetBrains.ReSharper.Psi.Tree.ITreeNode node) { }
        protected override JetBrains.ReSharper.Psi.ExtensionsAPI.IInjectedNodeContext CreateInjectedFileAndContext(JetBrains.ReSharper.Psi.ExtensionsAPI.IInjectedFileContext fileContext, JetBrains.ReSharper.Psi.Tree.ITreeNode originalNode, JetBrains.Text.IBuffer buffer, JetBrains.ReSharper.Psi.LanguageService languageService, int originalStartOffset, int originalEndOffset, int generatedStartOffset = 0, int generatedEndOffset = -1) { }
        public override JetBrains.ReSharper.Psi.ExtensionsAPI.IInjectedFileContext CreateInjectedFileContext(JetBrains.ReSharper.Psi.Tree.IFile originalFile) { }
        public override JetBrains.ReSharper.Psi.ExtensionsAPI.IInjectedNodeContext CreateInjectedNodeContext(JetBrains.ReSharper.Psi.ExtensionsAPI.IInjectedFileContext fileContext, JetBrains.ReSharper.Psi.Tree.ITreeNode originalNode) { }
        public override bool IsApplicable(JetBrains.ReSharper.Psi.PsiLanguageType originalLanguage) { }
        public override bool IsApplicableToNode(JetBrains.ReSharper.Psi.Tree.ITreeNode node, JetBrains.ReSharper.Psi.ExtensionsAPI.IInjectedFileContext context) { }
        public override void Regenerate(JetBrains.ReSharper.Psi.Impl.Shared.InjectedPsi.IndependentInjectedNodeContext nodeContext) { }
    }
}
namespace JetBrains.ReSharper.Psi.Asp.CSharp.Naming2
{
    
    [JetBrains.ReSharper.Psi.Naming.Interfaces.NamingConsistencyCheckerAttribute(typeof(JetBrains.ReSharper.Psi.CSharp.CSharpLanguage))]
    public sealed class AspCSharpCodeBehindNamingConsistencyChecker : JetBrains.ReSharper.Psi.Asp.Naming2.AspCodeBehindNamingConsistencyChecker { }
}
namespace JetBrains.ReSharper.Psi.Asp.CSharp.Utils
{
    
    public class static AspCSharpUtils
    {
        public static void DetachServiceCommentMarker(JetBrains.ReSharper.Psi.Tree.IStatement statement) { }
        public static void DetachServiceCommentMarkerAfterDeclarations(JetBrains.ReSharper.Psi.Tree.ITreeNode statement) { }
        public static JetBrains.ReSharper.Psi.Tree.IComment GetServiceCommentAfter(JetBrains.ReSharper.Psi.Tree.ITreeNode statement) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.CSharp.CSharpLanguage))]
    public class CSharpComplexTypeParserFactory : JetBrains.ReSharper.Psi.Asp.Utils.GenericComplexTypeParserFactory
    {
        public override System.Func<string, JetBrains.ReSharper.Psi.TreeTextRange, JetBrains.ReSharper.Psi.Web.WebConfig.Util.ComplexTypeParser> CreateParserDelegate(bool isOpenRasta) { }
    }
}