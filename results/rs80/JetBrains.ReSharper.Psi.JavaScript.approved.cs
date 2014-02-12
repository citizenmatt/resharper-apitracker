[assembly: JetBrains.UI.Icons.CompiledIcons.CompiledIconsPackAttribute(IconNames=new string[] {
        "JsLabel",
        "TypeScript",
        "JsFunction",
        "JsVariable",
        "JsMsAjaxNs",
        "JsProperty",
        "Js",
        "JsParameter"}, IconPackResourceIdentification="JetBrains.ReSharper.Psi.JavaScript;component/resources/PsiJavaScriptThemedIcons/T" +
    "hemedIcons.PsiJavaScript.Generated.Xaml")]
[assembly: System.Runtime.CompilerServices.InternalsVisibleToAttribute(@"JetBrains.ReSharper.Psi.JavaScript.WinRT, PublicKey=002400000480000094000000060200000024000052534131000400000100010087f63ba6a789c30e210e7ec987234ad9fe33baf7367993bab1b312d6f72ca296b91ed5c658964ffb9e7570eb184a527c68c6bdba41cfe67d8cfd3f888234206bf39205a3652d3af3445bb6f715fdac532e289fea41229bac37762b67eb16f58fee717d2465fca9ee17f08ed16772a1fc52c1c17022e1f0d9bdd004524a663aca")]
[assembly: System.Runtime.CompilerServices.InternalsVisibleToAttribute(@"JetBrains.ReSharper.Psi.Json, PublicKey=002400000480000094000000060200000024000052534131000400000100010087f63ba6a789c30e210e7ec987234ad9fe33baf7367993bab1b312d6f72ca296b91ed5c658964ffb9e7570eb184a527c68c6bdba41cfe67d8cfd3f888234206bf39205a3652d3af3445bb6f715fdac532e289fea41229bac37762b67eb16f58fee717d2465fca9ee17f08ed16772a1fc52c1c17022e1f0d9bdd004524a663aca")]
[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]
[assembly: System.Windows.Markup.XmlnsDefinitionAttribute("urn:shemas-jetbrains-com:ui-application-icons-psi-java-script", "JetBrains.ReSharper.Psi.JavaScript.Resources")]

namespace JetBrains.ReSharper.Psi.JavaScript.Caches
{
    
    public interface IAssociationRule : JetBrains.ReSharper.Psi.JavaScript.Caches.IJsRule
    {
        JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsPrimitiveTypeDescription GetAssociation(JetBrains.ReSharper.Psi.JavaScript.Caches.IJavaScriptTypeFileCache file);
    }
    [JetBrains.Annotations.CannotApplyEqualityOperatorAttribute()]
    public interface IJavaScriptSymbol
    {
        bool IsDeclaration { get; }
        bool IsFrameworkDeclaration { get; }
        bool IsGlobalDeclaration { get; }
        string Name { get; }
        int NavigationOffset { get; }
        JetBrains.ReSharper.Psi.IPsiSourceFile SourceFile { get; }
        JetBrains.ReSharper.Psi.Tree.IDeclaration GetDeclaration(JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsLocalElementResolver context);
        JetBrains.ReSharper.Psi.Tree.ITreeNode GetTreeNode(JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsLocalElementResolver context);
        bool IsExplicit();
    }
    public interface IJavaScriptTypeCache
    {
        JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsExpandablePrimitiveType ArrayPrimitive { get; }
        JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsExpandablePrimitiveType FunctionPrimitive { get; }
        JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsExpandablePrimitiveType ObjectPrimitive { get; }
        JetBrains.ProjectModel.ISolution Solution { get; }
        System.Collections.Generic.IEnumerable<string> StopSymbols { get; }
        JetBrains.ReSharper.Psi.JavaScript.Caches.IJavaScriptTypeFileCache BuildCacheForLocalDefinitions(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile);
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.JavaScript.DeclaredElements.IJavaScriptProperty CreateProperty(string name, JetBrains.ReSharper.Psi.JavaScript.Services.JavaScriptServices services);
        void DumpAssociations(System.IO.TextWriter textWriter);
        bool FindAllPropertyRules(JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsResolveContext context, JetBrains.ReSharper.Psi.JavaScript.Caches.IJsRuleConsumer consumer, JetBrains.ReSharper.Psi.IPsiSourceFile onlyInFile = null, bool filterOutNonJs = True);
        void FindAnnotations(JetBrains.ReSharper.Psi.JavaScript.Resolve.JsPrimitive primitive, JetBrains.ReSharper.Psi.JavaScript.Impl.Services.JavaScriptSourceFilesVisibilityFilter filter, JetBrains.ReSharper.Psi.JavaScript.Caches.IJavaScriptTypeFileCache fileCache, System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.JavaScript.Impl.ControlFlow.Inspections.ValueAnalysis.ContractAnnotations.PreparedAnnotation> listToAddResultsTo);
        JetBrains.ReSharper.Psi.JavaScript.DeclaredElements.IJavaScriptTypeOwner FindDeclaredElement(JetBrains.ReSharper.Psi.JavaScript.Resolve.JsPrimitive keyPrimitive, JetBrains.ReSharper.Psi.JavaScript.Resolve.JsPrimitive parent, JetBrains.ReSharper.Psi.JavaScript.Caches.IJavaScriptTypeFileCache fileCache = null, bool readOnly = False);
        JetBrains.ReSharper.Psi.JavaScript.DeclaredElements.IJavaScriptTypeOwner FindDeclaredElement(JetBrains.ReSharper.Psi.JavaScript.Resolve.JsPrimitive keyPrimitive, JetBrains.ReSharper.Psi.JavaScript.Resolve.JsPrimitive parent, JetBrains.ReSharper.Psi.JavaScript.Caches.IJavaScriptTypeFileCache fileCache, bool readOnly, bool canUseSimpleDeclaredElements, ref JetBrains.ReSharper.Psi.JavaScript.DeclaredElements.IJavaScriptTypeOwner cachedElement);
        bool FindRules(JetBrains.ReSharper.Psi.JavaScript.Resolve.JsPrimitive key, JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsResolveContext context, JetBrains.ReSharper.Psi.JavaScript.Caches.IJsRuleConsumer consumer, JetBrains.ReSharper.Psi.IPsiSourceFile onlyInFile = null, bool filterOutNonJs = False);
        bool FindRulesByParent(JetBrains.ReSharper.Psi.JavaScript.Resolve.JsPrimitive parent, JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsResolveContext context, JetBrains.ReSharper.Psi.JavaScript.Caches.IJsRuleConsumer consumer, bool filterOutNonJs = False);
        JetBrains.ReSharper.Psi.JavaScript.DeclaredElements.IJavaScriptTypeOwner FindTypedDeclaredElement(JetBrains.ReSharper.Psi.JavaScript.Resolve.JsPrimitive keyPrimitive, JetBrains.ReSharper.Psi.JavaScript.Resolve.JsPrimitive parent, JetBrains.ReSharper.Psi.JavaScript.Caches.IJavaScriptTypeFileCache fileCache = null);
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsExternalPrimitiveType> GetAdditionalGlobalSymbols(JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.JavaScriptResolveContext context);
        JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetAllDeclarationsSymbolTable(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile = null);
        JetBrains.ReSharper.Psi.JavaScript.Resolve.IJavaScriptType GetExpectedTypeForObjectLiteral(JetBrains.ReSharper.Psi.JavaScript.Tree.IObjectLiteral objectLiteral, JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsLocalElementResolver context);
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IPsiSourceFile> GetFilesWithName(string name);
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Resolve.ISymbolFilter> GetFiltersForObjectLiteralExpectedProperties(JetBrains.ReSharper.Psi.JavaScript.Tree.IObjectLiteral objectLiteral, JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.JavaScriptResolveContext resolveContext);
        JetBrains.ReSharper.Psi.JavaScript.Resolve.FullJavaScriptType GetStandardType(JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsPrimitiveTypeDescription primitive);
        System.Collections.Generic.IEnumerable<string> GetStandardTypeNames();
        JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsPrimitiveType GetTypeForPrimitive(JetBrains.ReSharper.Psi.JavaScript.Resolve.JsPrimitive primitive, bool allowIdentityLoss, JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.JavaScriptResolveContext context, bool strongTyped);
        bool IsStandardTypePrimitive(JetBrains.ReSharper.Psi.JavaScript.Resolve.JsPrimitive primitive);
    }
    public interface IJavaScriptTypeFileCache
    {
        bool Global { get; }
        JetBrains.ReSharper.Psi.IPsiSourceFile PsiSourceFile { get; }
        JetBrains.Util.dataStructures.MultimapValueCollection<JetBrains.ReSharper.Psi.JavaScript.Resolve.JsPrimitiveInfo, JetBrains.ReSharper.Psi.JavaScript.Caches.IJsRule> FindAssociations(JetBrains.ReSharper.Psi.JavaScript.Resolve.JsPrimitiveInfo primitive);
        JetBrains.ReSharper.Psi.JavaScript.Caches.IJsDeclarationInfo FindDeclarationInfo(JetBrains.ReSharper.Psi.JavaScript.Resolve.JsPrimitiveInfo primitive, JetBrains.ReSharper.Psi.JavaScript.Resolve.JsPrimitiveInfo parent);
        JetBrains.Util.dataStructures.MultimapValueCollection<JetBrains.ReSharper.Psi.JavaScript.Resolve.JsPrimitiveInfo, JetBrains.ReSharper.Psi.JavaScript.Caches.IPropertyRule> FindProperties(JetBrains.ReSharper.Psi.JavaScript.Resolve.JsPrimitiveInfo primitive);
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.JavaScript.Caches.IPropertyRule> GetAllProperties();
    }
    public interface IJsDeclarationInfo
    {
        JetBrains.ReSharper.Psi.JavaScript.Impl.Services.JavaScriptDeclaredElementType ElementType { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.TsModifiers Modifiers { get; }
        JetBrains.ReSharper.Psi.JavaScript.Resolve.JsPrimitiveInfo ParentInfo { get; }
        void WriteTo(System.IO.BinaryWriter writer);
    }
    public interface IJsRule
    {
        bool HasIdentityLoss { get; }
        bool IsDeclaration { get; }
        JetBrains.ReSharper.Psi.JavaScript.Resolve.JsPrimitiveInfo KeyPrimitive { get; }
        int Offset { get; }
        JetBrains.ReSharper.Psi.JavaScript.Resolve.JsRuleType RuleType { get; }
        JetBrains.ReSharper.Psi.JavaScript.Resolve.JsTypingType Typing { get; }
        bool CheckAdditionalInfo(JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsAdditionalTypeInfo info, JetBrains.ReSharper.Psi.JavaScript.Caches.IJavaScriptTypeFileCache file);
        string GetAdditionalLoggingInfo(JetBrains.ReSharper.Psi.JavaScript.Caches.IJavaScriptTypeFileCache file);
        void WriteTo(System.IO.BinaryWriter writer);
    }
    public interface IJsRuleConsumer
    {
        bool Consume(JetBrains.ReSharper.Psi.JavaScript.Caches.IJsRule rule, JetBrains.ReSharper.Psi.JavaScript.Caches.IJavaScriptTypeFileCache fileCache);
    }
    public interface IPropertyRule : JetBrains.ReSharper.Psi.JavaScript.Caches.IJsRule
    {
        JetBrains.ReSharper.Psi.JavaScript.Resolve.JsPrimitiveInfo ParentPrimitive { get; }
        string PropertyName { get; }
        JetBrains.ReSharper.Psi.JavaScript.Resolve.SymbolType SymbolType { get; }
    }
    public class static JavaScriptCacheExtensions
    {
        public static JetBrains.ReSharper.Psi.JavaScript.DeclaredElements.IJavaScriptTypeOwner FindDeclaredElement(this JetBrains.ReSharper.Psi.JavaScript.Caches.IJavaScriptTypeCache cache, JetBrains.ReSharper.Psi.JavaScript.Resolve.IJavaScriptType type, JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.JavaScriptResolveContext context) { }
    }
    public class JsAllPropertySearcher : JetBrains.ReSharper.Psi.JavaScript.Caches.JsPropertySearcherBase
    {
        public JsAllPropertySearcher(JetBrains.ReSharper.Psi.JavaScript.Caches.IJavaScriptTypeCache cache, bool searchForReadOnly, JetBrains.ReSharper.Psi.JavaScript.Resolve.SymbolType symbolType, JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsResolveContext context, JetBrains.ReSharper.Psi.IPsiSourceFile exceptSourceFile, int exceptOffset) { }
        public JetBrains.ReSharper.Psi.Resolve.ISymbolTable Run() { }
    }
    public class JsAssociationSearcher : JetBrains.ReSharper.Psi.JavaScript.Caches.IJsRuleConsumer
    {
        public JsAssociationSearcher(JetBrains.ReSharper.Psi.JavaScript.Resolve.JsPrimitive primitive, JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsAdditionalTypeInfo info, bool allowIdentityLoss, JetBrains.ReSharper.Psi.JavaScript.Resolve.JsTypingType typing, JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsResolveContext context, JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.IJsPrimitiveTypeConsumer consumer) { }
        public bool Consume(JetBrains.ReSharper.Psi.JavaScript.Caches.IJsRule rule, JetBrains.ReSharper.Psi.JavaScript.Caches.IJavaScriptTypeFileCache fileCache) { }
        public JetBrains.ReSharper.Psi.JavaScript.Resolve.JsRuleType Run() { }
    }
    public class JsPropertyLogger : JetBrains.ReSharper.Psi.JavaScript.Caches.IJsRuleConsumer
    {
        public JsPropertyLogger(JetBrains.ReSharper.Psi.JavaScript.Caches.IJavaScriptTypeCache cache, JetBrains.ReSharper.Psi.JavaScript.Resolve.FullJavaScriptType type, JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.JavaScriptResolveContext context) { }
        public bool Consume(JetBrains.ReSharper.Psi.JavaScript.Caches.IJsRule rule, JetBrains.ReSharper.Psi.JavaScript.Caches.IJavaScriptTypeFileCache fileCache) { }
        public void Run() { }
    }
    public class JsPropertySearcher : JetBrains.ReSharper.Psi.JavaScript.Caches.JsPropertySearcherBase
    {
        public JsPropertySearcher(JetBrains.ReSharper.Psi.JavaScript.Resolve.JsPrimitive primitive, bool onlyStrictTyping, bool searchForReadOnly, JetBrains.ReSharper.Psi.JavaScript.Resolve.SymbolType symbolType, JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsResolveContext context, JetBrains.ReSharper.Psi.IPsiSourceFile exceptSourceFile, int exceptOffset, JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsDeclaredElementConsumer tableToAddTo) { }
        public void Run() { }
    }
    public class JsPropertySearcherBase : JetBrains.ReSharper.Psi.JavaScript.Caches.IJsRuleConsumer
    {
        protected readonly JetBrains.ReSharper.Psi.JavaScript.Caches.IJavaScriptTypeCache myCache;
        protected readonly JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsResolveContext myContext;
        protected readonly JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsDeclaredElementConsumer myTableToAddTo;
        protected JsPropertySearcherBase(bool onlyStrictTyping, bool searchForReadOnly, JetBrains.ReSharper.Psi.JavaScript.Resolve.SymbolType symbolType, JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsResolveContext context, JetBrains.ReSharper.Psi.IPsiSourceFile exceptSourceFile, int exceptOffset, JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsDeclaredElementConsumer tableToAddTo, bool needTyped = True) { }
        public bool Consume(JetBrains.ReSharper.Psi.JavaScript.Caches.IJsRule rule, JetBrains.ReSharper.Psi.JavaScript.Caches.IJavaScriptTypeFileCache fileCache) { }
    }
    public class JsResolveSearcher : JetBrains.ReSharper.Psi.JavaScript.Caches.IJsRuleConsumer
    {
        public JsResolveSearcher(JetBrains.ReSharper.Psi.JavaScript.Caches.IJavaScriptTypeCache cache, JetBrains.ReSharper.Psi.JavaScript.Resolve.JsPrimitive primitive, JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsAdditionalTypeInfo info, bool onlyStrictTyping, JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsResolveContext context, JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsDeclaredElementConsumer tableToAddTo) { }
        public bool Consume(JetBrains.ReSharper.Psi.JavaScript.Caches.IJsRule rule, JetBrains.ReSharper.Psi.JavaScript.Caches.IJavaScriptTypeFileCache fileCache) { }
        public void Run() { }
    }
    public class JsSimpleDeclaredElementList : System.Collections.Generic.List<JetBrains.ReSharper.Psi.IDeclaredElement>, JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsDeclaredElementConsumer
    {
        public JetBrains.ReSharper.Psi.JavaScript.DeclaredElements.IJavaScriptTypeOwner CachedElement { get; set; }
        public void Consume(JetBrains.ReSharper.Psi.IDeclaredElement element) { }
    }
    public class JsSymbolSearcher : JetBrains.ReSharper.Psi.JavaScript.Caches.IJsRuleConsumer
    {
        public JsSymbolSearcher(JetBrains.ReSharper.Psi.JavaScript.Caches.IJavaScriptTypeCache cache, JetBrains.ReSharper.Psi.JavaScript.Resolve.JsPrimitive primitive, JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsResolveContext context, JetBrains.ReSharper.Psi.IPsiSourceFile onlyInFile = null, bool includeReadOnly = False, JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsAdditionalTypeInfo additionalTypeInfo = null) { }
        public bool Consume(JetBrains.ReSharper.Psi.JavaScript.Caches.IJsRule rule, JetBrains.ReSharper.Psi.JavaScript.Caches.IJavaScriptTypeFileCache fileCache) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.JavaScript.Caches.IJavaScriptSymbol> Run() { }
    }
}
namespace JetBrains.ReSharper.Psi.JavaScript.CodeStyle.Formatting
{
    
    public class static FormattingStageUtil
    {
        public static System.Collections.Generic.IEnumerable<string> GetBetweenStatementsSpaces(JetBrains.ReSharper.Psi.JavaScript.CodeStyle.Formatting.JavaScriptFmtStageContext context, JetBrains.ReSharper.Psi.JavaScript.CodeStyle.FormattingStageData data) { }
        public static JetBrains.ReSharper.Psi.CodeStyle.BraceFormatStyle GetFunctionBracesStyle(JetBrains.ReSharper.Psi.JavaScript.Tree.IBlockScope functionExpression, JetBrains.ReSharper.Psi.JavaScript.CodeStyle.Style.JavaScriptCodeFormattingSettings javaScriptCodeFormattingSettings) { }
        public static System.Collections.Generic.IEnumerable<string> GetLBraceSpaces(JetBrains.ReSharper.Psi.CodeStyle.BraceFormatStyle style, JetBrains.ReSharper.Psi.JavaScript.CodeStyle.Formatting.JavaScriptFmtStageContext context, JetBrains.ReSharper.Psi.JavaScript.CodeStyle.FormattingStageData data) { }
        [JetBrains.Annotations.PureAttribute()]
        public static System.Collections.Generic.IEnumerable<string> GetNodesSpace(int minLineFeeds, int maxLineFeeds, int preferedLineFeeds, bool makeSpace, JetBrains.ReSharper.Psi.JavaScript.CodeStyle.Formatting.JavaScriptFmtStageContext context, JetBrains.ReSharper.Psi.JavaScript.CodeStyle.FormattingStageData data) { }
        public static System.Collections.Generic.IEnumerable<string> GetRegularStatementSpaces(JetBrains.ReSharper.Psi.JavaScript.CodeStyle.Formatting.JavaScriptFmtStageContext context, JetBrains.ReSharper.Psi.JavaScript.CodeStyle.FormattingStageData data) { }
        public static System.Collections.Generic.IEnumerable<string> GetStatementBodySpaces(JetBrains.ReSharper.Psi.JavaScript.CodeStyle.Formatting.JavaScriptFmtStageContext context, JetBrains.ReSharper.Psi.JavaScript.CodeStyle.FormattingStageData data) { }
        public static bool IsFunctionDeclaration(JetBrains.ReSharper.Psi.JavaScript.CodeStyle.Formatting.JavaScriptFmtStageContext context) { }
        public static System.Collections.Generic.IEnumerable<string> SpacesAroundComma(JetBrains.ReSharper.Psi.JavaScript.CodeStyle.FormattingStageData formattingData, JetBrains.ReSharper.Psi.JavaScript.CodeStyle.Formatting.JavaScriptFmtStageContext context) { }
    }
    public class JavaScriptFmtStageContext : JetBrains.ReSharper.Psi.Impl.CodeStyle.FormattingStageContext
    {
        public JavaScriptFmtStageContext(JetBrains.ReSharper.Psi.Impl.CodeStyle.FormattingRange range) { }
    }
    public class JavaScriptFormattingVisitor : JetBrains.ReSharper.Psi.JavaScript.Tree.TreeNodeVisitor<JetBrains.ReSharper.Psi.JavaScript.CodeStyle.Formatting.JavaScriptFmtStageContext, System.Collections.Generic.IEnumerable<string>>
    {
        [JetBrains.Annotations.NotNullAttribute()]
        protected readonly JetBrains.ReSharper.Psi.JavaScript.CodeStyle.FormattingStageData myData;
        public JavaScriptFormattingVisitor(JetBrains.ReSharper.Psi.JavaScript.CodeStyle.FormattingStageData data) { }
        public override System.Collections.Generic.IEnumerable<string> VisitAccessorBody(JetBrains.ReSharper.Psi.JavaScript.Tree.IAccessorBody accessorBodyParam, JetBrains.ReSharper.Psi.JavaScript.CodeStyle.Formatting.JavaScriptFmtStageContext context) { }
        public override System.Collections.Generic.IEnumerable<string> VisitAccessorSignature(JetBrains.ReSharper.Psi.JavaScript.Tree.IAccessorSignature accessorSignatureParam, JetBrains.ReSharper.Psi.JavaScript.CodeStyle.Formatting.JavaScriptFmtStageContext context) { }
        public override System.Collections.Generic.IEnumerable<string> VisitArrayLiteral(JetBrains.ReSharper.Psi.JavaScript.Tree.IArrayLiteral arrayLiteralParam, JetBrains.ReSharper.Psi.JavaScript.CodeStyle.Formatting.JavaScriptFmtStageContext context) { }
        public override System.Collections.Generic.IEnumerable<string> VisitBinaryExpression(JetBrains.ReSharper.Psi.JavaScript.Tree.IBinaryExpression binaryExpressionParam, JetBrains.ReSharper.Psi.JavaScript.CodeStyle.Formatting.JavaScriptFmtStageContext context) { }
        public override System.Collections.Generic.IEnumerable<string> VisitBlock(JetBrains.ReSharper.Psi.JavaScript.Tree.IBlock block, JetBrains.ReSharper.Psi.JavaScript.CodeStyle.Formatting.JavaScriptFmtStageContext context) { }
        public override System.Collections.Generic.IEnumerable<string> VisitBreakStatement(JetBrains.ReSharper.Psi.JavaScript.Tree.IBreakStatement breakStatementParam, JetBrains.ReSharper.Psi.JavaScript.CodeStyle.Formatting.JavaScriptFmtStageContext context) { }
        public override System.Collections.Generic.IEnumerable<string> VisitCaseCaseClause(JetBrains.ReSharper.Psi.JavaScript.Tree.ICaseCaseClause caseCaseClause, JetBrains.ReSharper.Psi.JavaScript.CodeStyle.Formatting.JavaScriptFmtStageContext context) { }
        public override System.Collections.Generic.IEnumerable<string> VisitCaseClausesList(JetBrains.ReSharper.Psi.JavaScript.Tree.ICaseClausesList caseClausesListParam, JetBrains.ReSharper.Psi.JavaScript.CodeStyle.Formatting.JavaScriptFmtStageContext context) { }
        public override System.Collections.Generic.IEnumerable<string> VisitCatchBlock(JetBrains.ReSharper.Psi.JavaScript.Tree.ICatchBlock clause, JetBrains.ReSharper.Psi.JavaScript.CodeStyle.Formatting.JavaScriptFmtStageContext context) { }
        public override System.Collections.Generic.IEnumerable<string> VisitCompoundExpression(JetBrains.ReSharper.Psi.JavaScript.Tree.ICompoundExpression compoundExpressionParam, JetBrains.ReSharper.Psi.JavaScript.CodeStyle.Formatting.JavaScriptFmtStageContext context) { }
        public override System.Collections.Generic.IEnumerable<string> VisitConditionalTernaryExpression(JetBrains.ReSharper.Psi.JavaScript.Tree.IConditionalTernaryExpression expr, JetBrains.ReSharper.Psi.JavaScript.CodeStyle.Formatting.JavaScriptFmtStageContext context) { }
        public override System.Collections.Generic.IEnumerable<string> VisitContinueStatement(JetBrains.ReSharper.Psi.JavaScript.Tree.IContinueStatement continueStatementParam, JetBrains.ReSharper.Psi.JavaScript.CodeStyle.Formatting.JavaScriptFmtStageContext context) { }
        public override System.Collections.Generic.IEnumerable<string> VisitDebugStatement(JetBrains.ReSharper.Psi.JavaScript.Tree.IDebugStatement debugStatementParam, JetBrains.ReSharper.Psi.JavaScript.CodeStyle.Formatting.JavaScriptFmtStageContext context) { }
        public override System.Collections.Generic.IEnumerable<string> VisitDefaultClause(JetBrains.ReSharper.Psi.JavaScript.Tree.IDefaultClause defaultClause, JetBrains.ReSharper.Psi.JavaScript.CodeStyle.Formatting.JavaScriptFmtStageContext context) { }
        public override System.Collections.Generic.IEnumerable<string> VisitDoStatement(JetBrains.ReSharper.Psi.JavaScript.Tree.IDoStatement stmt, JetBrains.ReSharper.Psi.JavaScript.CodeStyle.Formatting.JavaScriptFmtStageContext context) { }
        public override System.Collections.Generic.IEnumerable<string> VisitExpressionStatement(JetBrains.ReSharper.Psi.JavaScript.Tree.IExpressionStatement expr, JetBrains.ReSharper.Psi.JavaScript.CodeStyle.Formatting.JavaScriptFmtStageContext context) { }
        public override System.Collections.Generic.IEnumerable<string> VisitFinallyBlock(JetBrains.ReSharper.Psi.JavaScript.Tree.IFinallyBlock finallyBlockParam, JetBrains.ReSharper.Psi.JavaScript.CodeStyle.Formatting.JavaScriptFmtStageContext context) { }
        public override System.Collections.Generic.IEnumerable<string> VisitForeachStatement(JetBrains.ReSharper.Psi.JavaScript.Tree.IForeachStatement stmt, JetBrains.ReSharper.Psi.JavaScript.CodeStyle.Formatting.JavaScriptFmtStageContext context) { }
        public override System.Collections.Generic.IEnumerable<string> VisitForInitializer(JetBrains.ReSharper.Psi.JavaScript.Tree.IForInitializer forInitializerParam, JetBrains.ReSharper.Psi.JavaScript.CodeStyle.Formatting.JavaScriptFmtStageContext context) { }
        public override System.Collections.Generic.IEnumerable<string> VisitForStatement(JetBrains.ReSharper.Psi.JavaScript.Tree.IForStatement stmt, JetBrains.ReSharper.Psi.JavaScript.CodeStyle.Formatting.JavaScriptFmtStageContext context) { }
        public override System.Collections.Generic.IEnumerable<string> VisitFunctionExpression(JetBrains.ReSharper.Psi.JavaScript.Tree.IFunctionExpression functionExpression, JetBrains.ReSharper.Psi.JavaScript.CodeStyle.Formatting.JavaScriptFmtStageContext context) { }
        public override System.Collections.Generic.IEnumerable<string> VisitFunctionExpressionSignature(JetBrains.ReSharper.Psi.JavaScript.Tree.IFunctionExpressionSignature functionExpressionSignature, JetBrains.ReSharper.Psi.JavaScript.CodeStyle.Formatting.JavaScriptFmtStageContext context) { }
        public override System.Collections.Generic.IEnumerable<string> VisitIfStatement(JetBrains.ReSharper.Psi.JavaScript.Tree.IIfStatement stmt, JetBrains.ReSharper.Psi.JavaScript.CodeStyle.Formatting.JavaScriptFmtStageContext context) { }
        public override System.Collections.Generic.IEnumerable<string> VisitIndexExpression(JetBrains.ReSharper.Psi.JavaScript.Tree.IIndexExpression expr, JetBrains.ReSharper.Psi.JavaScript.CodeStyle.Formatting.JavaScriptFmtStageContext context) { }
        public override System.Collections.Generic.IEnumerable<string> VisitInvocationExpression(JetBrains.ReSharper.Psi.JavaScript.Tree.IInvocationExpression invocationExpression, JetBrains.ReSharper.Psi.JavaScript.CodeStyle.Formatting.JavaScriptFmtStageContext context) { }
        public override System.Collections.Generic.IEnumerable<string> VisitJavaScriptFile(JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptFile javaScriptFile, JetBrains.ReSharper.Psi.JavaScript.CodeStyle.Formatting.JavaScriptFmtStageContext context) { }
        public override System.Collections.Generic.IEnumerable<string> VisitJavaScriptFileSection(JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptFileSection javaScriptFileSectionParam, JetBrains.ReSharper.Psi.JavaScript.CodeStyle.Formatting.JavaScriptFmtStageContext context) { }
        public override System.Collections.Generic.IEnumerable<string> VisitJavaScriptParameterList(JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptParameterList javaScriptParameterListParam, JetBrains.ReSharper.Psi.JavaScript.CodeStyle.Formatting.JavaScriptFmtStageContext context) { }
        public override System.Collections.Generic.IEnumerable<string> VisitNewExpression(JetBrains.ReSharper.Psi.JavaScript.Tree.INewExpression newExpressionParam, JetBrains.ReSharper.Psi.JavaScript.CodeStyle.Formatting.JavaScriptFmtStageContext context) { }
        public override System.Collections.Generic.IEnumerable<string> VisitObjectLiteral(JetBrains.ReSharper.Psi.JavaScript.Tree.IObjectLiteral objectLiteralParam, JetBrains.ReSharper.Psi.JavaScript.CodeStyle.Formatting.JavaScriptFmtStageContext context) { }
        public override System.Collections.Generic.IEnumerable<string> VisitObjectPropertiesList(JetBrains.ReSharper.Psi.JavaScript.Tree.IObjectPropertiesList objectPropertiesListParam, JetBrains.ReSharper.Psi.JavaScript.CodeStyle.Formatting.JavaScriptFmtStageContext context) { }
        public override System.Collections.Generic.IEnumerable<string> VisitObjectPropertyAccessor(JetBrains.ReSharper.Psi.JavaScript.Tree.IObjectPropertyAccessor objectPropertyAccessorParam, JetBrains.ReSharper.Psi.JavaScript.CodeStyle.Formatting.JavaScriptFmtStageContext context) { }
        public override System.Collections.Generic.IEnumerable<string> VisitObjectPropertyInitializer(JetBrains.ReSharper.Psi.JavaScript.Tree.IObjectPropertyInitializer objectPropertyInitializerParam, JetBrains.ReSharper.Psi.JavaScript.CodeStyle.Formatting.JavaScriptFmtStageContext context) { }
        public override System.Collections.Generic.IEnumerable<string> VisitParenthesizedExpression(JetBrains.ReSharper.Psi.JavaScript.Tree.IParenthesizedExpression parenthesizedExpressionParam, JetBrains.ReSharper.Psi.JavaScript.CodeStyle.Formatting.JavaScriptFmtStageContext context) { }
        public override System.Collections.Generic.IEnumerable<string> VisitPostfixExpression(JetBrains.ReSharper.Psi.JavaScript.Tree.IPostfixExpression postfixExpressionParam, JetBrains.ReSharper.Psi.JavaScript.CodeStyle.Formatting.JavaScriptFmtStageContext context) { }
        public override System.Collections.Generic.IEnumerable<string> VisitPrefixExpression(JetBrains.ReSharper.Psi.JavaScript.Tree.IPrefixExpression prefixExpressionParam, JetBrains.ReSharper.Psi.JavaScript.CodeStyle.Formatting.JavaScriptFmtStageContext context) { }
        public override System.Collections.Generic.IEnumerable<string> VisitReferenceExpression(JetBrains.ReSharper.Psi.JavaScript.Tree.IReferenceExpression expr, JetBrains.ReSharper.Psi.JavaScript.CodeStyle.Formatting.JavaScriptFmtStageContext context) { }
        public override System.Collections.Generic.IEnumerable<string> VisitReturnStatement(JetBrains.ReSharper.Psi.JavaScript.Tree.IReturnStatement stmt, JetBrains.ReSharper.Psi.JavaScript.CodeStyle.Formatting.JavaScriptFmtStageContext context) { }
        public override System.Collections.Generic.IEnumerable<string> VisitSwitchStatement(JetBrains.ReSharper.Psi.JavaScript.Tree.ISwitchStatement stmt, JetBrains.ReSharper.Psi.JavaScript.CodeStyle.Formatting.JavaScriptFmtStageContext context) { }
        public override System.Collections.Generic.IEnumerable<string> VisitThrowStatement(JetBrains.ReSharper.Psi.JavaScript.Tree.IThrowStatement stmt, JetBrains.ReSharper.Psi.JavaScript.CodeStyle.Formatting.JavaScriptFmtStageContext context) { }
        public override System.Collections.Generic.IEnumerable<string> VisitTryStatement(JetBrains.ReSharper.Psi.JavaScript.Tree.ITryStatement stmt, JetBrains.ReSharper.Psi.JavaScript.CodeStyle.Formatting.JavaScriptFmtStageContext context) { }
        public override System.Collections.Generic.IEnumerable<string> VisitVariableDeclaration(JetBrains.ReSharper.Psi.JavaScript.Tree.IVariableDeclaration variableDeclarationParam, JetBrains.ReSharper.Psi.JavaScript.CodeStyle.Formatting.JavaScriptFmtStageContext context) { }
        public override System.Collections.Generic.IEnumerable<string> VisitVariableDeclarationList(JetBrains.ReSharper.Psi.JavaScript.Tree.IVariableDeclarationList variableDeclarationListParam, JetBrains.ReSharper.Psi.JavaScript.CodeStyle.Formatting.JavaScriptFmtStageContext context) { }
        public override System.Collections.Generic.IEnumerable<string> VisitVariableStatement(JetBrains.ReSharper.Psi.JavaScript.Tree.IVariableStatement variableStatement, JetBrains.ReSharper.Psi.JavaScript.CodeStyle.Formatting.JavaScriptFmtStageContext context) { }
        public override System.Collections.Generic.IEnumerable<string> VisitWhileStatement(JetBrains.ReSharper.Psi.JavaScript.Tree.IWhileStatement stmt, JetBrains.ReSharper.Psi.JavaScript.CodeStyle.Formatting.JavaScriptFmtStageContext context) { }
        public override System.Collections.Generic.IEnumerable<string> VisitWithStatement(JetBrains.ReSharper.Psi.JavaScript.Tree.IWithStatement withStatementParam, JetBrains.ReSharper.Psi.JavaScript.CodeStyle.Formatting.JavaScriptFmtStageContext context) { }
    }
}
namespace JetBrains.ReSharper.Psi.JavaScript.CodeStyle
{
    
    public class FormattingStageData
    {
        public FormattingStageData(JetBrains.ReSharper.Psi.JavaScript.CodeStyle.Style.JavaScriptCodeFormattingSettings formattingSettings, JetBrains.ReSharper.Psi.Impl.CodeStyle.CodeFormattingContext context, JetBrains.ReSharper.Psi.JavaScript.CodeStyle.JavaScriptFormatProfile profile, System.Collections.Generic.List<JetBrains.ReSharper.Psi.JavaScript.CodeStyle.IJavaScriptCodeFormatterExtension> extensions) { }
        public JetBrains.ReSharper.Psi.Impl.CodeStyle.CodeFormattingContext Context { get; }
        public System.Collections.Generic.List<JetBrains.ReSharper.Psi.JavaScript.CodeStyle.IJavaScriptCodeFormatterExtension> Extensions { get; }
        public JetBrains.ReSharper.Psi.JavaScript.CodeStyle.Style.JavaScriptCodeFormattingSettings FormattingSettings { get; }
        public JetBrains.ReSharper.Psi.JavaScript.CodeStyle.JavaScriptFormatProfile Profile { get; }
    }
    public interface IJavaScriptCodeFormatterExtension
    {
        System.Nullable<bool> FormatSingleLine(JetBrains.ReSharper.Psi.Tree.ITreeNode context);
    }
    public interface IJavaScriptCodeFormatterFactory
    {
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.JavaScript.CodeStyle.Formatting.JavaScriptFormattingVisitor CreateFormattingVisitor([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.CodeStyle.FormattingStageData formattingData);
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.JavaScript.CodeStyle.Indenting.JavaScriptIndentVisitor CreateIndentVisitor([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.CodeStyle.Style.JavaScriptCodeFormattingSettings formattingSettings, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.CodeStyle.Indenting.JavaScriptIndentCache indentCache, JetBrains.ReSharper.Psi.Impl.CodeStyle.CodeFormattingContext context);
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.JavaScript.LanguageImpl.JavaScriptLanguage))]
    public class JavaScriptCodeFormatter : JetBrains.ReSharper.Psi.JavaScript.CodeStyle.JavaScriptCodeFormatterBase
    {
        public JavaScriptCodeFormatter(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ReSharper.Psi.PsiLanguageType language, JetBrains.Application.Settings.ISettingsStore settingsStore, JetBrains.Application.Settings.ISettingsOptimization settingsOptimization, JetBrains.DataFlow.IViewable<JetBrains.ReSharper.Psi.JavaScript.CodeStyle.IJavaScriptCodeFormatterExtension> extensions) { }
    }
    public abstract class JavaScriptCodeFormatterBase : JetBrains.ReSharper.Psi.Impl.CodeStyle.CodeFormatterBase, JetBrains.ReSharper.Psi.CodeStyle.ICodeFormatter, JetBrains.ReSharper.Psi.JavaScript.Services.IJavaScriptCodeFormatter
    {
        protected JavaScriptCodeFormatterBase(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ReSharper.Psi.PsiLanguageType language, JetBrains.Application.Settings.ISettingsStore settingsStore, JetBrains.Application.Settings.ISettingsOptimization settingsOptimization, JetBrains.DataFlow.IViewable<JetBrains.ReSharper.Psi.JavaScript.CodeStyle.IJavaScriptCodeFormatterExtension> extensions) { }
        protected override JetBrains.ReSharper.Psi.PsiLanguageType LanguageType { get; }
        public override JetBrains.ReSharper.Psi.Tree.ITreeNode CreateNewLine() { }
        public override JetBrains.ReSharper.Psi.Tree.ITreeNode CreateSpace(string indent, JetBrains.ReSharper.Psi.Tree.ITreeNode replacedSpace) { }
        public override JetBrains.ReSharper.Psi.Tree.ITreeNode CreateSpace() { }
        public void Format(JetBrains.ReSharper.Psi.Tree.ITreeNode root, JetBrains.ReSharper.Psi.JavaScript.CodeStyle.JavaScriptFormatProfile profile, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.Application.Progress.IProgressIndicator progressIndicator, JetBrains.Application.Settings.IContextBoundSettingsStore overrideSettingsStore = null) { }
        public override JetBrains.ReSharper.Psi.ITreeRange Format(JetBrains.ReSharper.Psi.Tree.ITreeNode firstElement, JetBrains.ReSharper.Psi.Tree.ITreeNode lastElement, JetBrains.ReSharper.Psi.CodeStyle.CodeFormatProfile profile, JetBrains.Application.Progress.IProgressIndicator progressIndicator, JetBrains.Application.Settings.IContextBoundSettingsStore overrideSettingsStore = null) { }
        public void Format(JetBrains.ReSharper.Psi.Tree.ITreeNode firstElement, JetBrains.ReSharper.Psi.Tree.ITreeNode lastElement, JetBrains.ReSharper.Psi.JavaScript.CodeStyle.JavaScriptFormatProfile profile, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.Application.Progress.IProgressIndicator pi, JetBrains.Application.Settings.IContextBoundSettingsStore overrideSettingsStore = null) { }
        public override void FormatDeletedNodes(JetBrains.ReSharper.Psi.Tree.ITreeNode parent, JetBrains.ReSharper.Psi.Tree.ITreeNode prevNode, JetBrains.ReSharper.Psi.Tree.ITreeNode nextNode) { }
        public void FormatDocComment(JetBrains.ReSharper.Psi.Tree.IDocCommentBlockNode docCommentBlock) { }
        public override void FormatInsertedNodes(JetBrains.ReSharper.Psi.Tree.ITreeNode nodeFirst, JetBrains.ReSharper.Psi.Tree.ITreeNode nodeLast, bool formatSurround) { }
        public override JetBrains.ReSharper.Psi.ITreeRange FormatInsertedRange(JetBrains.ReSharper.Psi.Tree.ITreeNode nodeFirst, JetBrains.ReSharper.Psi.Tree.ITreeNode nodeLast, JetBrains.ReSharper.Psi.ITreeRange origin) { }
        public override void FormatReplacedNode(JetBrains.ReSharper.Psi.Tree.ITreeNode oldNode, JetBrains.ReSharper.Psi.Tree.ITreeNode newNode) { }
        public override JetBrains.ReSharper.Psi.Tree.ITokenNode GetMinimalSeparator(JetBrains.ReSharper.Psi.Tree.ITokenNode leftToken, JetBrains.ReSharper.Psi.Tree.ITokenNode rightToken) { }
        public JetBrains.ReSharper.Psi.JavaScript.CodeStyle.JavaScriptFormatProfile GetProfile(JetBrains.ReSharper.Psi.CodeStyle.CodeFormatProfile profile) { }
        protected override bool IsFormatNextSpaces(JetBrains.ReSharper.Psi.CodeStyle.CodeFormatProfile profile) { }
        public override bool IsNewLine(JetBrains.ReSharper.Psi.Tree.ITreeNode ws) { }
        protected override void RemoveLeadingAndTrailingSpacesInFile(JetBrains.ReSharper.Psi.Tree.IFile fileNode) { }
    }
    public class JavaScriptFormatProfile
    {
        public JavaScriptFormatProfile(JetBrains.ReSharper.Psi.CodeStyle.CodeFormatProfile profile) { }
        public bool DontForceBraces { get; }
        public JetBrains.ReSharper.Psi.CodeStyle.CodeFormatProfile Profile { get; set; }
    }
}
namespace JetBrains.ReSharper.Psi.JavaScript.CodeStyle.Indenting
{
    
    public class JavaScriptIndentCache : JetBrains.ReSharper.Psi.Impl.CodeStyle.IndentCache<JetBrains.ReSharper.Psi.Tree.ITreeNode>
    {
        public JavaScriptIndentCache(JetBrains.ReSharper.Psi.Impl.CodeStyle.ICodeFormatterImpl codeFormatter, JetBrains.ReSharper.Psi.CodeStyle.AlignmentTabFillStyle tabFillStyle, JetBrains.ReSharper.Psi.CodeStyle.GlobalFormatSettings formattingSettings) { }
    }
    public class JavaScriptIndentVisitor : JetBrains.ReSharper.Psi.JavaScript.Tree.TreeNodeVisitor<JetBrains.ReSharper.Psi.Impl.CodeStyle.FormattingStageContext, string>
    {
        public JavaScriptIndentVisitor(JetBrains.ReSharper.Psi.JavaScript.CodeStyle.Style.JavaScriptCodeFormattingSettings formattingSettings, JetBrains.ReSharper.Psi.JavaScript.CodeStyle.Indenting.JavaScriptIndentCache indentCache, JetBrains.ReSharper.Psi.Impl.CodeStyle.CodeFormattingContext context) { }
        public string ContIndent { get; }
        public override string VisitAccessorBody(JetBrains.ReSharper.Psi.JavaScript.Tree.IAccessorBody accessorBody, JetBrains.ReSharper.Psi.Impl.CodeStyle.FormattingStageContext context) { }
        public override string VisitAccessorSignature(JetBrains.ReSharper.Psi.JavaScript.Tree.IAccessorSignature accessorSignatureParam, JetBrains.ReSharper.Psi.Impl.CodeStyle.FormattingStageContext context) { }
        public override string VisitBlock(JetBrains.ReSharper.Psi.JavaScript.Tree.IBlock block, JetBrains.ReSharper.Psi.Impl.CodeStyle.FormattingStageContext context) { }
        public override string VisitCaseCaseClause(JetBrains.ReSharper.Psi.JavaScript.Tree.ICaseCaseClause caseCaseClause, JetBrains.ReSharper.Psi.Impl.CodeStyle.FormattingStageContext context) { }
        public override string VisitCaseClausesList(JetBrains.ReSharper.Psi.JavaScript.Tree.ICaseClausesList caseClausesList, JetBrains.ReSharper.Psi.Impl.CodeStyle.FormattingStageContext context) { }
        public override string VisitCatchBlock(JetBrains.ReSharper.Psi.JavaScript.Tree.ICatchBlock catchBlockParam, JetBrains.ReSharper.Psi.Impl.CodeStyle.FormattingStageContext context) { }
        public override string VisitCompoundExpression(JetBrains.ReSharper.Psi.JavaScript.Tree.ICompoundExpression compoundExpression, JetBrains.ReSharper.Psi.Impl.CodeStyle.FormattingStageContext context) { }
        public override string VisitConditionalTernaryExpression(JetBrains.ReSharper.Psi.JavaScript.Tree.IConditionalTernaryExpression conditionalTernaryExpr, JetBrains.ReSharper.Psi.Impl.CodeStyle.FormattingStageContext context) { }
        public override string VisitDefaultClause(JetBrains.ReSharper.Psi.JavaScript.Tree.IDefaultClause defaultClause, JetBrains.ReSharper.Psi.Impl.CodeStyle.FormattingStageContext context) { }
        public override string VisitDocCommentBlockNode(JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptDocCommentBlockNode xmlDoc, JetBrains.ReSharper.Psi.Impl.CodeStyle.FormattingStageContext context) { }
        public override string VisitDoStatement(JetBrains.ReSharper.Psi.JavaScript.Tree.IDoStatement doStmt, JetBrains.ReSharper.Psi.Impl.CodeStyle.FormattingStageContext context) { }
        public override string VisitFinallyBlock(JetBrains.ReSharper.Psi.JavaScript.Tree.IFinallyBlock finallyBlockParam, JetBrains.ReSharper.Psi.Impl.CodeStyle.FormattingStageContext context) { }
        public override string VisitForStatement(JetBrains.ReSharper.Psi.JavaScript.Tree.IForStatement forStatementParam, JetBrains.ReSharper.Psi.Impl.CodeStyle.FormattingStageContext context) { }
        public override string VisitFunctionExpression(JetBrains.ReSharper.Psi.JavaScript.Tree.IFunctionExpression functionExpression, JetBrains.ReSharper.Psi.Impl.CodeStyle.FormattingStageContext context) { }
        public override string VisitFunctionExpressionSignature(JetBrains.ReSharper.Psi.JavaScript.Tree.IFunctionExpressionSignature functionExpressionSignature, JetBrains.ReSharper.Psi.Impl.CodeStyle.FormattingStageContext context) { }
        public string VisitFunctionLike(JetBrains.ReSharper.Psi.JavaScript.Tree.IBlockScope blockScope, JetBrains.ReSharper.Psi.Impl.CodeStyle.FormattingStageContext context) { }
        public override string VisitIfStatement(JetBrains.ReSharper.Psi.JavaScript.Tree.IIfStatement ifStatement, JetBrains.ReSharper.Psi.Impl.CodeStyle.FormattingStageContext context) { }
        public override string VisitJavaScriptFile(JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptFile javaScriptFileParam, JetBrains.ReSharper.Psi.Impl.CodeStyle.FormattingStageContext context) { }
        public override string VisitJavaScriptFileSection(JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptFileSection section, JetBrains.ReSharper.Psi.Impl.CodeStyle.FormattingStageContext context) { }
        public override string VisitJavaScriptParameterList(JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptParameterList javaScriptParameterList, JetBrains.ReSharper.Psi.Impl.CodeStyle.FormattingStageContext context) { }
        public override string VisitJavaScriptStatement(JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatement statement, JetBrains.ReSharper.Psi.Impl.CodeStyle.FormattingStageContext context) { }
        public override string VisitNode(JetBrains.ReSharper.Psi.Tree.ITreeNode node, JetBrains.ReSharper.Psi.Impl.CodeStyle.FormattingStageContext context) { }
        public override string VisitObjectPropertiesList(JetBrains.ReSharper.Psi.JavaScript.Tree.IObjectPropertiesList objectPropertiesList, JetBrains.ReSharper.Psi.Impl.CodeStyle.FormattingStageContext context) { }
        public override string VisitParenthesizedExpression(JetBrains.ReSharper.Psi.JavaScript.Tree.IParenthesizedExpression parenthesizedExpr, JetBrains.ReSharper.Psi.Impl.CodeStyle.FormattingStageContext context) { }
        public string VisitSignatureOwnerInPars(JetBrains.ReSharper.Psi.JavaScript.Tree.IJsSignatureNodeInPars functionExpression, JetBrains.ReSharper.Psi.Impl.CodeStyle.FormattingStageContext context) { }
        public override string VisitSwitchStatement(JetBrains.ReSharper.Psi.JavaScript.Tree.ISwitchStatement switchStmt, JetBrains.ReSharper.Psi.Impl.CodeStyle.FormattingStageContext context) { }
        public override string VisitTryStatement(JetBrains.ReSharper.Psi.JavaScript.Tree.ITryStatement tryStmt, JetBrains.ReSharper.Psi.Impl.CodeStyle.FormattingStageContext context) { }
        public override string VisitVariableDeclaration(JetBrains.ReSharper.Psi.JavaScript.Tree.IVariableDeclaration variableDeclaration, JetBrains.ReSharper.Psi.Impl.CodeStyle.FormattingStageContext context) { }
        public override string VisitVariableDeclarationList(JetBrains.ReSharper.Psi.JavaScript.Tree.IVariableDeclarationList variableDeclarationList, JetBrains.ReSharper.Psi.Impl.CodeStyle.FormattingStageContext context) { }
    }
}
namespace JetBrains.ReSharper.Psi.JavaScript.CodeStyle.SettingsUprgade
{
    
    [JetBrains.ReSharper.Psi.CodeStyle.SettingsUpgrade.CodeStyleSettingsAttribute("JavaScript")]
    [System.ObsoleteAttribute("Deprecated settings, use classes from Style\\")]
    public class JavaScriptCodeStyleSettings : JetBrains.Application.Configuration.IXmlReadable, JetBrains.Application.Configuration.IXmlUpgradable, System.ICloneable
    {
        public JavaScriptCodeStyleSettings() { }
        [System.ObsoleteAttribute("Deprecated, use classes from Style\\")]
        public JetBrains.ReSharper.Psi.JavaScript.CodeStyle.SettingsUprgade.JavaScriptFormatSettingsObsolete FormatSettingsObsolete { get; set; }
        public object Clone() { }
        public JetBrains.ReSharper.Psi.JavaScript.Naming.JavaScriptNamingStyleSettings GetNamingSettings2() { }
        public void ReadFromXml(System.Xml.XmlElement element) { }
    }
    [System.ObsoleteAttribute("Deprecated, use classes from Style\\")]
    public class JavaScriptFormatSettingsObsolete : JetBrains.Util.UserDataHolder, JetBrains.Application.Configuration.IXmlReadable
    {
        [JetBrains.Application.Configuration.XmlExternalizableAttribute(false)]
        public bool ALIGN_MULTILINE_PARAMETER;
        [JetBrains.Application.Configuration.XmlExternalizableAttribute(false)]
        public bool ALIGN_MULTIPLE_DECLARATION;
        [JetBrains.Application.Configuration.XmlExternalizableAttribute(JetBrains.ReSharper.Psi.CodeStyle.BraceFormatStyle.END_OF_LINE)]
        public JetBrains.ReSharper.Psi.CodeStyle.BraceFormatStyle CONTROL_STATEMENTS_BRACES;
        [JetBrains.Application.Configuration.XmlExternalizableAttribute(JetBrains.ReSharper.Psi.CodeStyle.EmptyBlockStyle.MULTILINE)]
        public JetBrains.ReSharper.Psi.CodeStyle.EmptyBlockStyle EMPTY_BLOCK_STYLE;
        [JetBrains.Application.Configuration.XmlExternalizableAttribute(JetBrains.ReSharper.Psi.JavaScript.CodeStyle.Style.ForceBraceStyle.DO_NOT_CHANGE)]
        public JetBrains.ReSharper.Psi.JavaScript.CodeStyle.Style.ForceBraceStyle FORCE_CONTROL_STATEMENTS_BRACES;
        [JetBrains.Application.Configuration.XmlExternalizableAttribute(JetBrains.ReSharper.Psi.CodeStyle.BraceFormatStyle.END_OF_LINE)]
        public JetBrains.ReSharper.Psi.CodeStyle.BraceFormatStyle FUNCTION_BRACES;
        [JetBrains.Application.Configuration.XmlExternalizableAttribute(false)]
        public bool INDENT_CASE_FROM_SWITCH;
        [JetBrains.Application.Configuration.XmlExternalizableAttribute(2)]
        public int KEEP_BLANK_LINES_BETWEEN_DECLARATIONS;
        [JetBrains.Application.Configuration.XmlExternalizableAttribute(2)]
        public int KEEP_BLANK_LINES_IN_CODE;
        [JetBrains.Application.Configuration.XmlExternalizableAttribute(true)]
        public bool KEEP_USER_LINEBREAKS_IN_EXPRESSIONS;
        [JetBrains.Application.Configuration.XmlExternalizableAttribute(1)]
        public int MIN_BLANK_LINES_BETWEEN_DECLARATIONS;
        [JetBrains.Application.Configuration.XmlExternalizableAttribute(JetBrains.ReSharper.Psi.CodeStyle.BraceFormatStyle.END_OF_LINE)]
        public JetBrains.ReSharper.Psi.CodeStyle.BraceFormatStyle OBJECT_LITERAL_BRACES;
        [JetBrains.Application.Configuration.XmlExternalizableAttribute(false)]
        public bool PLACE_CATCH_ON_NEW_LINE;
        [JetBrains.Application.Configuration.XmlExternalizableAttribute(false)]
        public bool PLACE_ELSE_ON_NEW_LINE;
        [JetBrains.Application.Configuration.XmlExternalizableAttribute(false)]
        public bool PLACE_FINALLY_ON_NEW_LINE;
        [JetBrains.Application.Configuration.XmlExternalizableAttribute(false)]
        public bool PLACE_WHILE_ON_NEW_LINE;
        [JetBrains.Application.Configuration.XmlExternalizableAttribute(JetBrains.ReSharper.Psi.CodeStyle.SimpleEmbeddedStatementStyle.DO_NOT_CHANGE)]
        public JetBrains.ReSharper.Psi.CodeStyle.SimpleEmbeddedStatementStyle SIMPLE_EMBEDDED_STATEMENT_STYLE;
        [JetBrains.Application.Configuration.XmlExternalizableAttribute(JetBrains.ReSharper.Psi.JavaScript.CodeStyle.Style.SingleStatementAnonymousFunctionStyle.DoNotChange)]
        public JetBrains.ReSharper.Psi.JavaScript.CodeStyle.Style.SingleStatementAnonymousFunctionStyle SINGLE_STATEMENT_FUNCTION_STYLE;
        [JetBrains.Application.Configuration.XmlExternalizableAttribute(true)]
        public bool SPACE_AFTER_COMMA;
        [JetBrains.Application.Configuration.XmlExternalizableAttribute(true)]
        public bool SPACE_AFTER_FOR_SEMICOLON;
        [JetBrains.Application.Configuration.XmlExternalizableAttribute(true)]
        public bool SPACE_AFTER_PROPERTY_COLON;
        [JetBrains.Application.Configuration.XmlExternalizableAttribute(true)]
        public bool SPACE_AFTER_TERNARY_COLON;
        [JetBrains.Application.Configuration.XmlExternalizableAttribute(true)]
        public bool SPACE_AFTER_TERNARY_QUEST;
        [JetBrains.Application.Configuration.XmlExternalizableAttribute(true)]
        public bool SPACE_AROUND_ASSIGNMENT_OPERATOR;
        [JetBrains.Application.Configuration.XmlExternalizableAttribute(true)]
        public bool SPACE_AROUND_BINARY_OPERATOR;
        [JetBrains.Application.Configuration.XmlExternalizableAttribute(false)]
        public bool SPACE_AROUND_DOT;
        [JetBrains.Application.Configuration.XmlExternalizableAttribute(false)]
        public bool SPACE_BEFORE_ARRAY_ACCESS_BRACKETS;
        [JetBrains.Application.Configuration.XmlExternalizableAttribute(false)]
        public bool SPACE_BEFORE_COLON_IN_CASE;
        [JetBrains.Application.Configuration.XmlExternalizableAttribute(false)]
        public bool SPACE_BEFORE_COMMA;
        [JetBrains.Application.Configuration.XmlExternalizableAttribute(false)]
        public bool SPACE_BEFORE_EMPTY_METHOD_CALL_PARENTHESES;
        [JetBrains.Application.Configuration.XmlExternalizableAttribute(false)]
        public bool SPACE_BEFORE_FOR_SEMICOLON;
        [JetBrains.Application.Configuration.XmlExternalizableAttribute(false)]
        public bool SPACE_BEFORE_METHOD_CALL_PARENTHESES;
        [JetBrains.Application.Configuration.XmlExternalizableAttribute(false)]
        public bool SPACE_BEFORE_METHOD_PARENTHESES;
        [JetBrains.Application.Configuration.XmlExternalizableAttribute(false)]
        public bool SPACE_BEFORE_PROPERTY_COLON;
        [JetBrains.Application.Configuration.XmlExternalizableAttribute(false)]
        public bool SPACE_BEFORE_SEMICOLON;
        [JetBrains.Application.Configuration.XmlExternalizableAttribute(true)]
        public bool SPACE_BEFORE_STATEMENT_PARENTHESES;
        [JetBrains.Application.Configuration.XmlExternalizableAttribute(true)]
        public bool SPACE_BEFORE_TERNARY_COLON;
        [JetBrains.Application.Configuration.XmlExternalizableAttribute(true)]
        public bool SPACE_BEFORE_TERNARY_QUEST;
        [JetBrains.Application.Configuration.XmlExternalizableAttribute(false)]
        public bool SPACE_WITHIN_ARRAY_ACCESS_BRACKETS;
        [JetBrains.Application.Configuration.XmlExternalizableAttribute(false)]
        public bool SPACE_WITHIN_EMPTY_METHOD_CALL_PARENTHESES;
        [JetBrains.Application.Configuration.XmlExternalizableAttribute(false)]
        public bool SPACE_WITHIN_EMPTY_METHOD_PARENTHESES;
        [JetBrains.Application.Configuration.XmlExternalizableAttribute(false)]
        public bool SPACE_WITHIN_METHOD_CALL_PARENTHESES;
        [JetBrains.Application.Configuration.XmlExternalizableAttribute(false)]
        public bool SPACE_WITHIN_METHOD_PARENTHESES;
        [JetBrains.Application.Configuration.XmlExternalizableAttribute(true)]
        public bool SPACE_WITHIN_OBJECT_LITERAL_BRACES;
        [JetBrains.Application.Configuration.XmlExternalizableAttribute(false)]
        public bool SPACE_WITHIN_PARENTHESES;
        [JetBrains.Application.Configuration.XmlExternalizableAttribute(false)]
        public bool SPACE_WITHIN_STATEMENT_PARENTHESES;
        [JetBrains.Application.Configuration.XmlExternalizableAttribute(true)]
        public bool SPECIAL_ELSE_IF_TREATMENT;
        [JetBrains.Application.Configuration.XmlExternalizableAttribute(true)]
        public bool STICK_COMMENT;
        public JetBrains.ReSharper.Psi.JavaScript.CodeStyle.SettingsUprgade.JavaScriptFormatSettingsObsolete Clone() { }
        public void ReadFromXml(System.Xml.XmlElement element) { }
    }
    [JetBrains.Application.Configuration.Upgrade.GlobalSettingsUpgraderAttribute()]
    [JetBrains.ProjectModel.Settings.Upgrade.SolutionSettingsUpgraderAttribute()]
    public class JavaScriptFormatSettingsUpgrade : JetBrains.ReSharper.Psi.Naming.Settings.Upgrade.CodeStyleSettingsUpgrade
    {
        public JavaScriptFormatSettingsUpgrade(JetBrains.Application.Parts.IPartsCatalogueSet partsSet, JetBrains.ProjectModel.ISolution solution = null) { }
        protected override void DoUpgrade(JetBrains.ReSharper.Psi.CodeStyle.SettingsUpgrade.CodeStyleSettingsObsolete codeStyleSettings, JetBrains.Application.Settings.IContextBoundSettingsStore contextBoundSettingsStore) { }
    }
}
namespace JetBrains.ReSharper.Psi.JavaScript.CodeStyle.Style
{
    
    public enum ForceBraceStyle
    {
        [System.ComponentModel.DescriptionAttribute("Do not change")]
        DO_NOT_CHANGE = 0,
        [System.ComponentModel.DescriptionAttribute("Remove braces")]
        ALWAYS_REMOVE = 1,
        [System.ComponentModel.DescriptionAttribute("Add braces")]
        ALWAYS_ADD = 2,
        [System.ComponentModel.DescriptionAttribute("Use braces for multiline")]
        ONLY_FOR_MULTILINE = 3,
    }
    public class JavaScriptCodeFormattingSettings
    {
        public readonly JetBrains.ReSharper.Psi.JavaScript.CodeStyle.Style.JavaScriptFormatBracesLayoutSettingsKey BracesLayout;
        public readonly JetBrains.ReSharper.Psi.CodeStyle.CommonFormatterSettingsKey CommonSettings;
        public readonly JetBrains.Application.Settings.IContextBoundSettingsStore ContextBoundSettingsStore;
        public readonly JetBrains.ReSharper.Psi.CodeStyle.GlobalFormatSettings GlobalSettings;
        public readonly JetBrains.ReSharper.Psi.JavaScript.CodeStyle.Style.JavaScriptFormatLineBreaksSettingsKey LineBreaks;
        public readonly JetBrains.ReSharper.Psi.JavaScript.CodeStyle.Style.JavaScriptFormatOtherSettingsKey Other;
        public readonly JetBrains.ReSharper.Psi.JavaScript.CodeStyle.Style.JavaScriptFormatSpacesSettingsKey Spaces;
        public JavaScriptCodeFormattingSettings(JetBrains.Application.Settings.IContextBoundSettingsStore contextBoundSettingsStore, JetBrains.Application.Settings.ISettingsOptimization settingsOptimization, JetBrains.ReSharper.Psi.CodeStyle.GlobalFormatSettings globalFormatSettings) { }
    }
    [JetBrains.Application.Settings.SettingsKeyAttribute(typeof(JetBrains.ReSharper.Psi.CodeStyle.CodeFormattingSettingsKey), "Code formatting in JavaScript")]
    public class JavaScriptCodeFormattingSettingsKey { }
    [JetBrains.Application.Settings.SettingsKeyAttribute(typeof(JetBrains.ReSharper.Psi.JavaScript.CodeStyle.Style.JavaScriptCodeFormattingSettingsKey), "Braces layout")]
    public class JavaScriptFormatBracesLayoutSettingsKey
    {
        [JetBrains.Application.Settings.SettingsEntryAttribute(JetBrains.ReSharper.Psi.CodeStyle.BraceFormatStyle.END_OF_LINE, "Control statements")]
        public JetBrains.ReSharper.Psi.CodeStyle.BraceFormatStyle CONTROL_STATEMENTS_BRACES;
        [JetBrains.Application.Settings.SettingsEntryAttribute(JetBrains.ReSharper.Psi.CodeStyle.EmptyBlockStyle.MULTILINE, "EMPTY_BLOCK_STYLE")]
        public JetBrains.ReSharper.Psi.CodeStyle.EmptyBlockStyle EMPTY_BLOCK_STYLE;
        [JetBrains.Application.Settings.SettingsEntryAttribute(JetBrains.ReSharper.Psi.JavaScript.CodeStyle.Style.ForceBraceStyle.DO_NOT_CHANGE, "Braces in statements")]
        public JetBrains.ReSharper.Psi.JavaScript.CodeStyle.Style.ForceBraceStyle FORCE_CONTROL_STATEMENTS_BRACES;
        [JetBrains.Application.Settings.SettingsEntryAttribute(JetBrains.ReSharper.Psi.CodeStyle.BraceFormatStyle.END_OF_LINE, "Function")]
        public JetBrains.ReSharper.Psi.CodeStyle.BraceFormatStyle FUNCTION_BRACES;
        [JetBrains.Application.Settings.SettingsEntryAttribute(JetBrains.ReSharper.Psi.CodeStyle.BraceFormatStyle.END_OF_LINE, "Functions passed as parameters to other function calls")]
        public JetBrains.ReSharper.Psi.CodeStyle.BraceFormatStyle FUNCTION_IN_INVOCATION_BRACES;
        [JetBrains.Application.Settings.SettingsEntryAttribute(false, "Indent \"case\" from \"switch\"")]
        public bool INDENT_CASE_FROM_SWITCH;
        [JetBrains.Application.Settings.SettingsEntryAttribute(false, "Indent object literals/arrays/nested expressions")]
        public bool INDENT_LEFT_PAR_INSIDE_EXPRESSION;
    }
    [JetBrains.Application.Settings.SettingsKeyAttribute(typeof(JetBrains.ReSharper.Psi.JavaScript.CodeStyle.Style.JavaScriptCodeFormattingSettingsKey), "Line breaks")]
    public class JavaScriptFormatLineBreaksSettingsKey
    {
        [JetBrains.Application.Settings.SettingsEntryAttribute(2, "Max blank lines between declarations")]
        public int KEEP_BLANK_LINES_BETWEEN_DECLARATIONS;
        [JetBrains.Application.Settings.SettingsEntryAttribute(2, "Max blank lines in code")]
        public int KEEP_BLANK_LINES_IN_CODE;
        [JetBrains.Application.Settings.SettingsEntryAttribute(true, "KEEP_USER_LINEBREAKS_IN_EXPRESSIONS")]
        public bool KEEP_USER_LINEBREAKS_IN_EXPRESSIONS;
        [JetBrains.Application.Settings.SettingsEntryAttribute(1, "Min blank lines between declarations")]
        public int MIN_BLANK_LINES_BETWEEN_DECLARATIONS;
        [JetBrains.Application.Settings.SettingsEntryAttribute(false, "Place \"catch\" on a new line")]
        public bool PLACE_CATCH_ON_NEW_LINE;
        [JetBrains.Application.Settings.SettingsEntryAttribute(false, "Place \"else\" on a new line")]
        public bool PLACE_ELSE_ON_NEW_LINE;
        [JetBrains.Application.Settings.SettingsEntryAttribute(false, "Place \"finally\" on a new line")]
        public bool PLACE_FINALLY_ON_NEW_LINE;
        [JetBrains.Application.Settings.SettingsEntryAttribute(false, "Place \"while\" on a new line")]
        public bool PLACE_WHILE_ON_NEW_LINE;
        [JetBrains.Application.Settings.SettingsEntryAttribute(JetBrains.ReSharper.Psi.CodeStyle.SimpleEmbeddedStatementStyle.DO_NOT_CHANGE, "Break line in simple embedded statement")]
        public JetBrains.ReSharper.Psi.CodeStyle.SimpleEmbeddedStatementStyle SIMPLE_EMBEDDED_STATEMENT_STYLE;
        [JetBrains.Application.Settings.SettingsEntryAttribute(JetBrains.ReSharper.Psi.JavaScript.CodeStyle.Style.SingleStatementAnonymousFunctionStyle.DoNotChange, "Single line anonymous function")]
        public JetBrains.ReSharper.Psi.JavaScript.CodeStyle.Style.SingleStatementAnonymousFunctionStyle SINGLE_STATEMENT_FUNCTION_STYLE;
        [JetBrains.Application.Settings.SettingsEntryAttribute(true, "Special \"else if\" treatment")]
        public bool SPECIAL_ELSE_IF_TREATMENT;
    }
    [JetBrains.Application.Settings.SettingsKeyAttribute(typeof(JetBrains.ReSharper.Psi.JavaScript.CodeStyle.Style.JavaScriptCodeFormattingSettingsKey), "Others")]
    public class JavaScriptFormatOtherSettingsKey
    {
        [JetBrains.Application.Settings.SettingsEntryAttribute(false, "Align multiline constructs: Method parameters")]
        public bool ALIGN_MULTILINE_PARAMETER;
        [JetBrains.Application.Settings.SettingsEntryAttribute(false, "Align multiline constructs: Multiple declarations")]
        public bool ALIGN_MULTIPLE_DECLARATION;
        [JetBrains.Application.Settings.SettingsEntryAttribute(true, "Don\'t indent comments started at first column")]
        public bool STICK_COMMENT;
    }
    [JetBrains.Application.Settings.SettingsKeyAttribute(typeof(JetBrains.ReSharper.Psi.JavaScript.CodeStyle.Style.JavaScriptCodeFormattingSettingsKey), "Spaces")]
    public class JavaScriptFormatSpacesSettingsKey
    {
        [JetBrains.Application.Settings.SettingsEntryAttribute(true, "After comma")]
        public bool SPACE_AFTER_COMMA;
        [JetBrains.Application.Settings.SettingsEntryAttribute(true, "After semicolon in for statement")]
        public bool SPACE_AFTER_FOR_SEMICOLON;
        [JetBrains.Application.Settings.SettingsEntryAttribute(true, "After \':\'")]
        public bool SPACE_AFTER_PROPERTY_COLON;
        [JetBrains.Application.Settings.SettingsEntryAttribute(true, "After \':\'")]
        public bool SPACE_AFTER_TERNARY_COLON;
        [JetBrains.Application.Settings.SettingsEntryAttribute(true, "After \'?\'")]
        public bool SPACE_AFTER_TERNARY_QUEST;
        [JetBrains.Application.Settings.SettingsEntryAttribute(true, "Around assignment operator")]
        public bool SPACE_AROUND_ASSIGNMENT_OPERATOR;
        [JetBrains.Application.Settings.SettingsEntryAttribute(true, "Around binary operator")]
        public bool SPACE_AROUND_BINARY_OPERATOR;
        [JetBrains.Application.Settings.SettingsEntryAttribute(false, "Around dot")]
        public bool SPACE_AROUND_DOT;
        [JetBrains.Application.Settings.SettingsEntryAttribute(false, "Before brackets")]
        public bool SPACE_BEFORE_ARRAY_ACCESS_BRACKETS;
        [JetBrains.Application.Settings.SettingsEntryAttribute(false, "Before colon")]
        public bool SPACE_BEFORE_COLON_IN_CASE;
        [JetBrains.Application.Settings.SettingsEntryAttribute(false, "Before comma")]
        public bool SPACE_BEFORE_COMMA;
        [JetBrains.Application.Settings.SettingsEntryAttribute(false, "Before empty parentheses")]
        public bool SPACE_BEFORE_EMPTY_METHOD_CALL_PARENTHESES;
        [JetBrains.Application.Settings.SettingsEntryAttribute(false, "Before semicolon in for statement")]
        public bool SPACE_BEFORE_FOR_SEMICOLON;
        [JetBrains.Application.Settings.SettingsEntryAttribute(false, "Before parentheses")]
        public bool SPACE_BEFORE_METHOD_CALL_PARENTHESES;
        [JetBrains.Application.Settings.SettingsEntryAttribute(false, "Before parentheses")]
        public bool SPACE_BEFORE_METHOD_PARENTHESES;
        [JetBrains.Application.Settings.SettingsEntryAttribute(false, "Before parentheses of anonymous method")]
        public bool SPACE_BEFORE_METHOD_PARENTHESES_ANONYMOUS;
        [JetBrains.Application.Settings.SettingsEntryAttribute(false, "Before \':\'")]
        public bool SPACE_BEFORE_PROPERTY_COLON;
        [JetBrains.Application.Settings.SettingsEntryAttribute(false, "Before semicolon")]
        public bool SPACE_BEFORE_SEMICOLON;
        [JetBrains.Application.Settings.SettingsEntryAttribute(true, "Before parentheses")]
        public bool SPACE_BEFORE_STATEMENT_PARENTHESES;
        [JetBrains.Application.Settings.SettingsEntryAttribute(true, "Before \':\'")]
        public bool SPACE_BEFORE_TERNARY_COLON;
        [JetBrains.Application.Settings.SettingsEntryAttribute(true, "In ternary operator \'? :\'")]
        public bool SPACE_BEFORE_TERNARY_QUEST;
        [JetBrains.Application.Settings.SettingsEntryAttribute(false, "Within brackets")]
        public bool SPACE_WITHIN_ARRAY_ACCESS_BRACKETS;
        [JetBrains.Application.Settings.SettingsEntryAttribute(false, "Within empty parentheses")]
        public bool SPACE_WITHIN_EMPTY_METHOD_CALL_PARENTHESES;
        [JetBrains.Application.Settings.SettingsEntryAttribute(false, "Within empty parentheses")]
        public bool SPACE_WITHIN_EMPTY_METHOD_PARENTHESES;
        [JetBrains.Application.Settings.SettingsEntryAttribute(false, "Within empty braces")]
        public bool SPACE_WITHIN_EMPTY_OBJECT_LITERAL_BRACES;
        [JetBrains.Application.Settings.SettingsEntryAttribute(false, "Within parentheses")]
        public bool SPACE_WITHIN_METHOD_CALL_PARENTHESES;
        [JetBrains.Application.Settings.SettingsEntryAttribute(false, "Within parentheses")]
        public bool SPACE_WITHIN_METHOD_PARENTHESES;
        [JetBrains.Application.Settings.SettingsEntryAttribute(true, "Within braces")]
        public bool SPACE_WITHIN_OBJECT_LITERAL_BRACES;
        [JetBrains.Application.Settings.SettingsEntryAttribute(false, "Within parentheses")]
        public bool SPACE_WITHIN_PARENTHESES;
        [JetBrains.Application.Settings.SettingsEntryAttribute(false, "Within parentheses")]
        public bool SPACE_WITHIN_STATEMENT_PARENTHESES;
    }
    public enum SingleStatementAnonymousFunctionStyle
    {
        [System.ComponentModel.DescriptionAttribute("Do not change")]
        DoNotChange = 0,
        [System.ComponentModel.DescriptionAttribute("Force put on single line")]
        ForcePutOnSingleLine = 1,
        [System.ComponentModel.DescriptionAttribute("Force line breaks")]
        ForceLineBreaks = 2,
    }
}
namespace JetBrains.ReSharper.Psi.JavaScript.ControlFlow
{
    
    public interface IJavaScriptControlFlowElement : JetBrains.ReSharper.Psi.ControlFlow.IControlFlowElement
    {
        bool ExecutesCode { get; }
    }
    public interface IJavaScriptControlFlowError
    {
        JetBrains.ReSharper.Psi.JavaScript.ControlFlow.JavaScriptControlFlowErrorType ErrorType { get; }
    }
    public interface IJavaScriptControlFlowRib : JetBrains.ReSharper.Psi.ControlFlow.IControlFlowRib
    {
        System.Nullable<bool> BooleanCondition { get; }
        JetBrains.ReSharper.Psi.JavaScript.ControlFlow.IJavaScriptControlFlowElement Source { get; }
        JetBrains.ReSharper.Psi.JavaScript.ControlFlow.IJavaScriptControlFlowElement Target { get; set; }
    }
    public interface IJavaScriptControlFlowStatement : JetBrains.ReSharper.Psi.ControlFlow.IControlFlowElement, JetBrains.ReSharper.Psi.JavaScript.ControlFlow.IJavaScriptControlFlowElement
    {
        JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatement Statement { get; }
    }
    public interface IJsControlFlowGraf : JetBrains.ReSharper.Psi.ControlFlow.IControlFlowGraf
    {
        JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptTreeNode Body { get; }
        System.Collections.Generic.IDictionary<JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.JavaScript.ControlFlow.JavaScriptControlFlowErrorType> ControlFlowErrors { get; }
        bool HasReachableImplicitReturn { get; }
        System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.JavaScript.ControlFlow.IJavaScriptControlFlowRib> ReachableExits { get; }
    }
    public enum JavaScriptControlFlowErrorType
    {
        UNRESOLVED_JUMP = 0,
    }
}
namespace JetBrains.ReSharper.Psi.JavaScript.DeclaredElements
{
    
    public interface IJavaScriptDeclaredElement : JetBrains.ReSharper.Psi.IDeclaredElement
    {
        bool HasDynamicName { get; }
    }
    public interface IJavaScriptDynamicProperty : JetBrains.ReSharper.Psi.IDeclaredElement, JetBrains.ReSharper.Psi.JavaScript.DeclaredElements.IJavaScriptDeclaredElement, JetBrains.ReSharper.Psi.JavaScript.DeclaredElements.IJavaScriptProperty, JetBrains.ReSharper.Psi.JavaScript.DeclaredElements.IJavaScriptTypeOwner, JetBrains.ReSharper.Psi.JavaScript.DeclaredElements.IJsCachedElement { }
    public interface IJavaScriptLabel : JetBrains.ReSharper.Psi.IDeclaredElement, JetBrains.ReSharper.Psi.JavaScript.DeclaredElements.IJavaScriptDeclaredElement { }
    public interface IJavaScriptLocalElement : JetBrains.ReSharper.Psi.IDeclaredElement, JetBrains.ReSharper.Psi.JavaScript.DeclaredElements.IJavaScriptDeclaredElement, JetBrains.ReSharper.Psi.JavaScript.DeclaredElements.IJavaScriptTypeOwner
    {
        JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptScope GetOwnerScope();
    }
    public interface IJavaScriptParameter : JetBrains.ReSharper.Psi.IDeclaredElement, JetBrains.ReSharper.Psi.JavaScript.DeclaredElements.IJavaScriptDeclaredElement, JetBrains.ReSharper.Psi.JavaScript.DeclaredElements.IJavaScriptLocalElement, JetBrains.ReSharper.Psi.JavaScript.DeclaredElements.IJavaScriptTypeOwner
    {
        int ParamNumber { get; }
    }
    public interface IJavaScriptProperty : JetBrains.ReSharper.Psi.IDeclaredElement, JetBrains.ReSharper.Psi.JavaScript.DeclaredElements.IJavaScriptDeclaredElement, JetBrains.ReSharper.Psi.JavaScript.DeclaredElements.IJavaScriptTypeOwner, JetBrains.ReSharper.Psi.JavaScript.DeclaredElements.IJsCachedElement
    {
        bool ReadOnly { get; }
        JetBrains.ReSharper.Psi.Resolve.ResolveErrorType ResolveStatus { get; }
        JetBrains.ReSharper.Psi.IPsiSourceFile SourceFileExample { get; }
        bool IsMoreThanInOneFile();
        JetBrains.ReSharper.Psi.JavaScript.DeclaredElements.IJavaScriptProperty SetName(string newName);
    }
    public interface IJavaScriptSymbolInfoService
    {
        bool CanBeFunction(JetBrains.ReSharper.Psi.IDeclaredElement element, JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.JavaScriptResolveContext context);
        JetBrains.ReSharper.Psi.JavaScript.Resolve.FullJavaScriptType GetJsType(JetBrains.ReSharper.Psi.IDeclaredElement element, JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.JavaScriptResolveContext context);
        string GetShortName(JetBrains.ReSharper.Psi.IDeclaredElement element);
        bool HasDynamicName(JetBrains.ReSharper.Psi.IDeclaredElement element);
        bool IsKnown(JetBrains.ReSharper.Psi.IDeclaredElement element);
        bool IsProperty(JetBrains.ReSharper.Psi.IDeclaredElement element);
    }
    public interface IJavaScriptTypeOwner : JetBrains.ReSharper.Psi.IDeclaredElement, JetBrains.ReSharper.Psi.JavaScript.DeclaredElements.IJavaScriptDeclaredElement
    {
        bool IsLocal { get; }
        bool IsVariableOrField { get; }
        bool CanBeFunction(JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.JavaScriptResolveContext context);
        JetBrains.ReSharper.Psi.JavaScript.Resolve.IJavaScriptType GetJsType(JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsDocumentOffsetProvider context);
    }
    public interface IJsCachedElement : JetBrains.ReSharper.Psi.IDeclaredElement, JetBrains.ReSharper.Psi.JavaScript.DeclaredElements.IJavaScriptDeclaredElement, JetBrains.ReSharper.Psi.JavaScript.DeclaredElements.IJavaScriptTypeOwner
    {
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.JavaScript.Caches.IJavaScriptSymbol> GetSymbols();
    }
    public class static JavaScriptTypeOwnerEx
    {
        public static bool IsJavaScriptProperty(this JetBrains.ReSharper.Psi.IDeclaredElement element) { }
    }
}
namespace JetBrains.ReSharper.Psi.JavaScript.DeclaredElements.TypeScript
{
    
    public interface ITsClassElement : JetBrains.ReSharper.Psi.IDeclaredElement, JetBrains.ReSharper.Psi.JavaScript.DeclaredElements.IJavaScriptDeclaredElement, JetBrains.ReSharper.Psi.JavaScript.DeclaredElements.IJavaScriptTypeOwner, JetBrains.ReSharper.Psi.JavaScript.DeclaredElements.IJsCachedElement, JetBrains.ReSharper.Psi.JavaScript.DeclaredElements.TypeScript.ITsDeclaredElement, JetBrains.ReSharper.Psi.JavaScript.DeclaredElements.TypeScript.ITsExtendableTypeElement, JetBrains.ReSharper.Psi.JavaScript.DeclaredElements.TypeScript.ITsMemberElement, JetBrains.ReSharper.Psi.JavaScript.DeclaredElements.TypeScript.ITsModuleMember, JetBrains.ReSharper.Psi.JavaScript.DeclaredElements.TypeScript.ITsTypeElement
    {
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.JavaScript.DeclaredElements.TypeScript.ITsExtendableTypeElement> GetImplementedElements();
    }
    public interface ITsDeclaredElement : JetBrains.ReSharper.Psi.IDeclaredElement, JetBrains.ReSharper.Psi.JavaScript.DeclaredElements.IJavaScriptDeclaredElement, JetBrains.ReSharper.Psi.JavaScript.DeclaredElements.IJavaScriptTypeOwner { }
    public interface ITsExtendableTypeElement : JetBrains.ReSharper.Psi.IDeclaredElement, JetBrains.ReSharper.Psi.JavaScript.DeclaredElements.IJavaScriptDeclaredElement, JetBrains.ReSharper.Psi.JavaScript.DeclaredElements.IJavaScriptTypeOwner, JetBrains.ReSharper.Psi.JavaScript.DeclaredElements.IJsCachedElement, JetBrains.ReSharper.Psi.JavaScript.DeclaredElements.TypeScript.ITsDeclaredElement, JetBrains.ReSharper.Psi.JavaScript.DeclaredElements.TypeScript.ITsMemberElement, JetBrains.ReSharper.Psi.JavaScript.DeclaredElements.TypeScript.ITsModuleMember, JetBrains.ReSharper.Psi.JavaScript.DeclaredElements.TypeScript.ITsTypeElement
    {
        JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetExtendedBaseElements(bool recursive);
        JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetMembers(bool includePrivate, bool includeInherited);
    }
    public interface ITsInterfaceElement : JetBrains.ReSharper.Psi.IDeclaredElement, JetBrains.ReSharper.Psi.JavaScript.DeclaredElements.IJavaScriptDeclaredElement, JetBrains.ReSharper.Psi.JavaScript.DeclaredElements.IJavaScriptTypeOwner, JetBrains.ReSharper.Psi.JavaScript.DeclaredElements.IJsCachedElement, JetBrains.ReSharper.Psi.JavaScript.DeclaredElements.TypeScript.ITsDeclaredElement, JetBrains.ReSharper.Psi.JavaScript.DeclaredElements.TypeScript.ITsExtendableTypeElement, JetBrains.ReSharper.Psi.JavaScript.DeclaredElements.TypeScript.ITsMemberElement, JetBrains.ReSharper.Psi.JavaScript.DeclaredElements.TypeScript.ITsModuleMember, JetBrains.ReSharper.Psi.JavaScript.DeclaredElements.TypeScript.ITsTypeElement { }
    public interface ITsMemberElement : JetBrains.ReSharper.Psi.IDeclaredElement, JetBrains.ReSharper.Psi.JavaScript.DeclaredElements.IJavaScriptDeclaredElement, JetBrains.ReSharper.Psi.JavaScript.DeclaredElements.IJavaScriptTypeOwner, JetBrains.ReSharper.Psi.JavaScript.DeclaredElements.IJsCachedElement, JetBrains.ReSharper.Psi.JavaScript.DeclaredElements.TypeScript.ITsDeclaredElement
    {
        bool IsPublic { get; }
        JetBrains.ReSharper.Psi.JavaScript.DeclaredElements.TypeScript.ITsTypeElement GetParentElement();
        JetBrains.ReSharper.Psi.JavaScript.Resolve.IJavaScriptType GetParentType();
    }
    public interface ITsModuleElement : JetBrains.ReSharper.Psi.IDeclaredElement, JetBrains.ReSharper.Psi.JavaScript.DeclaredElements.IJavaScriptDeclaredElement, JetBrains.ReSharper.Psi.JavaScript.DeclaredElements.IJavaScriptTypeOwner, JetBrains.ReSharper.Psi.JavaScript.DeclaredElements.IJsCachedElement, JetBrains.ReSharper.Psi.JavaScript.DeclaredElements.TypeScript.ITsDeclaredElement, JetBrains.ReSharper.Psi.JavaScript.DeclaredElements.TypeScript.ITsMemberElement, JetBrains.ReSharper.Psi.JavaScript.DeclaredElements.TypeScript.ITsModuleMember, JetBrains.ReSharper.Psi.JavaScript.DeclaredElements.TypeScript.ITsTypeElement { }
    public interface ITsModuleMember : JetBrains.ReSharper.Psi.IDeclaredElement, JetBrains.ReSharper.Psi.JavaScript.DeclaredElements.IJavaScriptDeclaredElement, JetBrains.ReSharper.Psi.JavaScript.DeclaredElements.IJavaScriptTypeOwner, JetBrains.ReSharper.Psi.JavaScript.DeclaredElements.IJsCachedElement, JetBrains.ReSharper.Psi.JavaScript.DeclaredElements.TypeScript.ITsDeclaredElement, JetBrains.ReSharper.Psi.JavaScript.DeclaredElements.TypeScript.ITsMemberElement { }
    public interface ITsTypeElement : JetBrains.ReSharper.Psi.IDeclaredElement, JetBrains.ReSharper.Psi.JavaScript.DeclaredElements.IJavaScriptDeclaredElement, JetBrains.ReSharper.Psi.JavaScript.DeclaredElements.IJavaScriptTypeOwner, JetBrains.ReSharper.Psi.JavaScript.DeclaredElements.IJsCachedElement, JetBrains.ReSharper.Psi.JavaScript.DeclaredElements.TypeScript.ITsDeclaredElement, JetBrains.ReSharper.Psi.JavaScript.DeclaredElements.TypeScript.ITsMemberElement, JetBrains.ReSharper.Psi.JavaScript.DeclaredElements.TypeScript.ITsModuleMember
    {
        JetBrains.ReSharper.Psi.JavaScript.Resolve.IJavaScriptType GetJsTypeForTypeElement();
        JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetMembers(bool includePrivate);
    }
    public interface ITsTypeMember : JetBrains.ReSharper.Psi.IDeclaredElement, JetBrains.ReSharper.Psi.JavaScript.DeclaredElements.IJavaScriptDeclaredElement, JetBrains.ReSharper.Psi.JavaScript.DeclaredElements.IJavaScriptTypeOwner, JetBrains.ReSharper.Psi.JavaScript.DeclaredElements.IJsCachedElement, JetBrains.ReSharper.Psi.JavaScript.DeclaredElements.TypeScript.ITsDeclaredElement, JetBrains.ReSharper.Psi.JavaScript.DeclaredElements.TypeScript.ITsMemberElement { }
}
namespace JetBrains.ReSharper.Psi.JavaScript.DocComments
{
    
    public interface IBasicDocSignature
    {
        bool HasDocSignature { get; }
        JetBrains.UI.RichText.RichTextBlock GetDescription();
        JetBrains.UI.RichText.RichTextBlock GetObsoleteDescription();
        JetBrains.UI.RichText.RichTextBlock[] GetParamDescriptions();
        bool IsObsolete();
    }
    public interface IDocParameter
    {
        JetBrains.ReSharper.Psi.JavaScript.DocComments.IDocType DocType { get; }
        int IndexInTheSignature { get; }
        string Name { get; }
        string SummaryText { get; }
        JetBrains.ReSharper.Psi.JavaScript.DeclaredElements.IJavaScriptLocalElement GetDeclaredElement(JetBrains.ReSharper.Psi.JavaScript.Tree.IJsSignatureNode signatureNode, JetBrains.ReSharper.Psi.JavaScript.DocComments.IDocSignature signature);
    }
    public interface IDocSignature : JetBrains.ReSharper.Psi.JavaScript.DocComments.IBasicDocSignature
    {
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.IList<JetBrains.ReSharper.Psi.JavaScript.DocComments.IDocParameter> DocParameters { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.JavaScript.DocComments.IDocType DocType { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        string SummaryText { get; }
    }
    public interface IDocType
    {
        string TypeName { get; }
        JetBrains.ReSharper.Psi.JavaScript.Resolve.IJavaScriptType GetJsType();
    }
    public interface IJsDocComment
    {
        System.Collections.Generic.IList<JetBrains.ReSharper.Psi.JavaScript.DocComments.IDocSignature> DocSignatures { get; }
    }
}
namespace JetBrains.ReSharper.Psi.JavaScript.Gen
{
    
    public sealed class ErrorMessages
    {
        public static string GetErrorMessage0() { }
        public static string GetErrorMessage1() { }
        public static string GetErrorMessage10() { }
        public static string GetErrorMessage11() { }
        public static string GetErrorMessage12() { }
        public static string GetErrorMessage13() { }
        public static string GetErrorMessage14() { }
        public static string GetErrorMessage15() { }
        public static string GetErrorMessage16() { }
        public static string GetErrorMessage17() { }
        public static string GetErrorMessage18() { }
        public static string GetErrorMessage19() { }
        public static string GetErrorMessage2() { }
        public static string GetErrorMessage20() { }
        public static string GetErrorMessage21() { }
        public static string GetErrorMessage22() { }
        public static string GetErrorMessage23() { }
        public static string GetErrorMessage24() { }
        public static string GetErrorMessage25() { }
        public static string GetErrorMessage26() { }
        public static string GetErrorMessage27() { }
        public static string GetErrorMessage28() { }
        public static string GetErrorMessage29() { }
        public static string GetErrorMessage3() { }
        public static string GetErrorMessage30() { }
        public static string GetErrorMessage31() { }
        public static string GetErrorMessage32() { }
        public static string GetErrorMessage33() { }
        public static string GetErrorMessage34() { }
        public static string GetErrorMessage35() { }
        public static string GetErrorMessage36() { }
        public static string GetErrorMessage37() { }
        public static string GetErrorMessage38() { }
        public static string GetErrorMessage39() { }
        public static string GetErrorMessage4() { }
        public static string GetErrorMessage40() { }
        public static string GetErrorMessage41() { }
        public static string GetErrorMessage42() { }
        public static string GetErrorMessage43() { }
        public static string GetErrorMessage44() { }
        public static string GetErrorMessage45() { }
        public static string GetErrorMessage46() { }
        public static string GetErrorMessage47() { }
        public static string GetErrorMessage48() { }
        public static string GetErrorMessage49() { }
        public static string GetErrorMessage5() { }
        public static string GetErrorMessage50() { }
        public static string GetErrorMessage51() { }
        public static string GetErrorMessage52() { }
        public static string GetErrorMessage53() { }
        public static string GetErrorMessage54() { }
        public static string GetErrorMessage55() { }
        public static string GetErrorMessage56() { }
        public static string GetErrorMessage57() { }
        public static string GetErrorMessage58() { }
        public static string GetErrorMessage59() { }
        public static string GetErrorMessage6() { }
        public static string GetErrorMessage60() { }
        public static string GetErrorMessage61() { }
        public static string GetErrorMessage62() { }
        public static string GetErrorMessage63() { }
        public static string GetErrorMessage64() { }
        public static string GetErrorMessage65() { }
        public static string GetErrorMessage66() { }
        public static string GetErrorMessage67() { }
        public static string GetErrorMessage68() { }
        public static string GetErrorMessage69() { }
        public static string GetErrorMessage7() { }
        public static string GetErrorMessage8() { }
        public static string GetErrorMessage9() { }
    }
    public class static TokenBitsets
    {
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet ElementBitset_0;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet ElementBitset_1;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet ElementBitset_2;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet ElementBitset_3;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet ElementBitset_4;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_accessorBody;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_accessorSignature;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_argumentListAux;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_argumentListAux2;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_arrayLiteral;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_assignmentOperatorAux;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_binaryExpression;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_binaryOperatorAux;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_block;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_breakStatement;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_caseCaseClause;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_caseClause;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_caseClausesList;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_catchBlock;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_compoundExpression;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_conditionalTernaryExpression;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_continueStatement;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_debugStatement;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_defaultClause;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_doStatement;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_emptyStatement;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_expressionStatement;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_finallyBlock;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_forDeclarationInitializer;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_foreachStatement;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_foreachStatementAux;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_forExpressionInitializer;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_forInitializer;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_forStatement;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_forStatementAux;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_functionExpression;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_functionExpressionSignature;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_functionStatement;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_identifierExpression;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_ifStatement;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_indexExpression;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_initialiser;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_invocationExpression;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_javaScriptExpression;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_javaScriptFile;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_javaScriptFileSection;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_javaScriptLiteralExpression;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_javaScriptParameterDeclaration;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_javaScriptParameterList;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_javaScriptStatement;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_javaScriptStatementWithParenthesis;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_labelledStatement;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_memberExpression;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_newExpression;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_noNewLineExpressionAndSemi;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_objectLiteral;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_objectPropertiesList;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_objectPropertyAccessor;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_objectPropertyDeclaration;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_objectPropertyInitializer;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_parenthesizedExpression;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_postfixExpression;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_prefixExpression;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_propertyName;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_propertyNameIdentifier;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_propertyNameNumericLiteral;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_propertyNameStringLiteral;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_referenceExpression;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_returnStatement;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_semicolon;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_statementsList;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_switchStatement;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_thisExpression;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_throwStatement;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_tryStatement;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_variableDeclaration;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_variableDeclarationList;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_variableStatement;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_whileStatement;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_withStatement;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet TokenBitset_0;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet TokenBitset_1;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet TokenBitset_10;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet TokenBitset_11;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet TokenBitset_12;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet TokenBitset_13;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet TokenBitset_14;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet TokenBitset_15;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet TokenBitset_16;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet TokenBitset_2;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet TokenBitset_3;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet TokenBitset_4;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet TokenBitset_5;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet TokenBitset_6;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet TokenBitset_7;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet TokenBitset_8;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet TokenBitset_9;
    }
}
namespace JetBrains.ReSharper.Psi.JavaScript.Impl.Caches
{
    
    public interface IJavaScriptSymbolProvider
    {
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsExternalPrimitiveType> GetSymbols(JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.JavaScriptResolveContext context);
        bool IsApplicable(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile);
    }
    public class JavaScriptPropertySymbol : JetBrains.ReSharper.Psi.JavaScript.Caches.IJavaScriptSymbol
    {
        public JavaScriptPropertySymbol(string name, JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, int navigationOffset, bool isAssigned, bool isDeclaration) { }
        public bool IsAssigned { get; }
        public bool IsDeclaration { get; }
        public bool IsFrameworkDeclaration { get; }
        public bool IsGlobalDeclaration { get; }
        public string Name { get; }
        public int NavigationOffset { get; }
        public JetBrains.ReSharper.Psi.IPsiSourceFile SourceFile { get; }
        public JetBrains.ReSharper.Psi.Tree.IDeclaration GetDeclaration(JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsLocalElementResolver context) { }
        public JetBrains.ReSharper.Psi.Tree.ITreeNode GetTreeNode(JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsLocalElementResolver context) { }
        public bool IsExplicit() { }
    }
    public class static JavaScriptTypeCacheBuilder
    {
        public static object GetTypeCacheForFile(JetBrains.ReSharper.Psi.IPsiSourceFile file) { }
        public static object Read(System.IO.BinaryReader reader, JetBrains.ReSharper.Psi.IPsiSourceFile file) { }
        public static void Write(object fileCache, System.IO.BinaryWriter writer) { }
    }
    public class JsDeclarationInfo : JetBrains.ReSharper.Psi.JavaScript.Caches.IJsDeclarationInfo
    {
        public JsDeclarationInfo(JetBrains.ReSharper.Psi.JavaScript.Impl.Services.JavaScriptDeclaredElementType elementType, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.TsModifiers modifiers, JetBrains.ReSharper.Psi.JavaScript.Resolve.JsPrimitiveInfo parentInfo) { }
        public JsDeclarationInfo(System.IO.BinaryReader reader, JetBrains.ReSharper.Psi.Util.ITokenIntern identifierIntern) { }
        public JetBrains.ReSharper.Psi.JavaScript.Impl.Services.JavaScriptDeclaredElementType ElementType { get; }
        public JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.TsModifiers Modifiers { get; }
        public JetBrains.ReSharper.Psi.JavaScript.Resolve.JsPrimitiveInfo ParentInfo { get; }
        public void WriteTo(System.IO.BinaryWriter writer) { }
    }
    public class JsTypeCacheBuilderResolver : JetBrains.ReSharper.Psi.IRecursiveElementProcessor, JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsDocumentOffsetProvider
    {
        public JsTypeCacheBuilderResolver(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, JetBrains.ReSharper.Psi.JavaScript.Services.JavaScriptServices javaScriptServices) { }
        public JetBrains.ReSharper.Psi.JavaScript.Services.JavaScriptServices JavaScriptServices { get; }
        public bool ProcessingIsFinished { get; }
        public JetBrains.ReSharper.Psi.IPsiSourceFile SourceFile { get; }
        public int GetDocumentStartOffset(JetBrains.ReSharper.Psi.Tree.ITreeNode node) { }
        public int GetDocumentStartOffset(JetBrains.ReSharper.Psi.Tree.ITreeNode node, JetBrains.ReSharper.Psi.TreeTextRange range) { }
        public System.Collections.Generic.Dictionary<JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.IReferenceExpressionReferenceOwner, JetBrains.ReSharper.Psi.IDeclaredElement> GetResolveCache() { }
        public bool InteriorShouldBeProcessed(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public void PopScope() { }
        public void Process(JetBrains.ReSharper.Psi.Tree.IFile file) { }
        public void ProcessAfterInterior(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public void ProcessBeforeInterior(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public void PushScope(JetBrains.ReSharper.Psi.JavaScript.Tree.IBlockScope function) { }
    }
}
namespace JetBrains.ReSharper.Psi.JavaScript.Impl.ControlFlow
{
    
    public interface IJsControlFlowBuilder
    {
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.JavaScript.ControlFlow.IJsControlFlowGraf GetGraf([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IJsFunctionLike function);
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.JavaScript.ControlFlow.IJsControlFlowGraf GetGraf([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptFileSection section);
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.JavaScript.ControlFlow.IJsControlFlowGraf GetGraf(JetBrains.ReSharper.Psi.Tree.ITreeNode node);
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.JavaScript.ControlFlow.IJsControlFlowGraf GraphFromNode(JetBrains.ReSharper.Psi.Tree.ITreeNode owner);
    }
    public class JavaScriptControlFlowBuilderParams
    {
        public JavaScriptControlFlowBuilderParams() { }
        public bool BuildExpressions { get; set; }
        public JetBrains.Application.CheckForInterrupt InterruptHandler { get; }
    }
    public class JsControlFlowGraf : JetBrains.ReSharper.Psi.ControlFlow.Impl.ControlFlowGraf, JetBrains.ReSharper.Psi.ControlFlow.IControlFlowGraf, JetBrains.ReSharper.Psi.JavaScript.ControlFlow.IJsControlFlowGraf
    {
        public JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptTreeNode Body { get; }
        public override JetBrains.ReSharper.Psi.ControlFlow.IControlFlowElement BodyElement { get; }
        public System.Collections.Generic.IDictionary<JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.JavaScript.ControlFlow.JavaScriptControlFlowErrorType> ControlFlowErrors { get; }
        public override JetBrains.ReSharper.Psi.ControlFlow.IControlFlowElement EntryElement { get; }
        public bool HasReachableImplicitReturn { get; }
        public System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.JavaScript.ControlFlow.IJavaScriptControlFlowRib> ReachableExits { get; }
        public void CollectExecutableElements(JetBrains.ReSharper.Psi.JavaScript.ControlFlow.IJavaScriptControlFlowRib rib, out bool hasExitFromMethod, System.Collections.Generic.HashSet<JetBrains.ReSharper.Psi.JavaScript.ControlFlow.IJavaScriptControlFlowElement> executableElements, System.Collections.Generic.HashSet<JetBrains.ReSharper.Psi.JavaScript.ControlFlow.IJavaScriptControlFlowElement> visited) { }
    }
}
namespace JetBrains.ReSharper.Psi.JavaScript.Impl.ControlFlow.Inspections
{
    
    public class static ControlFlowInspectionUtil { }
}
namespace JetBrains.ReSharper.Psi.JavaScript.Impl.ControlFlow.Inspections.ReachingDefinitions
{
    
    public class ControlFlowDefinition
    {
        public ControlFlowDefinition(JetBrains.ReSharper.Psi.Tree.ITreeNode definitionNode, int variableIndex) { }
        public JetBrains.ReSharper.Psi.Tree.ITreeNode DefinitionNode { get; }
        public int VariableIndex { get; }
    }
    public interface IReachingDefinitionsResult
    {
        System.Collections.Generic.List<JetBrains.ReSharper.Psi.JavaScript.Impl.ControlFlow.Inspections.ValueAnalysis.ValueAnalysisVariableInfo> LocalVariables { get; }
        System.Collections.Generic.Dictionary<JetBrains.ReSharper.Psi.Tree.ITreeNode, int> ReadUsages { get; }
        JetBrains.Util.OneToSetMap<JetBrains.ReSharper.Psi.Tree.ITreeNode, int> ReadUsagesInInnerFunctions { get; }
        JetBrains.Util.OneToListMap<JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode> ResultDefinitionsToUsages { get; }
        System.Collections.Generic.JetHashSet<JetBrains.ReSharper.Psi.Tree.ITreeNode> ResultHasReadsInInnerFunctionsBefore { get; }
        System.Collections.Generic.JetHashSet<JetBrains.ReSharper.Psi.Tree.ITreeNode> ResultHasWritesInInnerFunctionsBefore { get; }
        JetBrains.Util.OneToListMap<JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode> ResultUsagesToDefinitions { get; }
        System.Collections.Generic.Dictionary<JetBrains.ReSharper.Psi.JavaScript.DeclaredElements.IJavaScriptLocalElement, int> VariableIndicies { get; }
        System.Collections.Generic.Dictionary<JetBrains.ReSharper.Psi.Tree.ITreeNode, int> WriteUsages { get; }
        JetBrains.Util.OneToSetMap<JetBrains.ReSharper.Psi.Tree.ITreeNode, int> WriteUsagesInInnerFunctions { get; }
    }
}
namespace JetBrains.ReSharper.Psi.JavaScript.Impl.ControlFlow.Inspections.ValueAnalysis.ContractAnnotations
{
    
    public struct AnnotationParameter
    {
        public int ParameterIndex { get; set; }
        public JetBrains.ReSharper.Psi.JavaScript.Impl.ControlFlow.Inspections.ValueAnalysis.Values.JsVariableStateExtended Value { get; set; }
    }
    public class static BitUtil
    {
        public static byte BitCount(ulong value) { }
    }
    public class FunctionAnnotation
    {
        public FunctionAnnotation(int parameterCount) { }
        public System.Collections.Generic.List<JetBrains.ReSharper.Psi.JavaScript.Impl.ControlFlow.Inspections.ValueAnalysis.ContractAnnotations.FunctionAnnotationEntry> AnnotationEntries { get; }
        public JetBrains.ReSharper.Psi.JavaScript.Impl.ControlFlow.Inspections.ValueAnalysis.Values.JsVariableStateExtended DefaultReturn { get; set; }
        public int ParameterCount { get; }
    }
    public class FunctionAnnotationEntry
    {
        public FunctionAnnotationEntry(JetBrains.ReSharper.Psi.JavaScript.Impl.ControlFlow.Inspections.ValueAnalysis.Values.JsVariableStateExtended @return, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.JavaScript.Impl.ControlFlow.Inspections.ValueAnalysis.ContractAnnotations.AnnotationParameter> parameters) { }
        public System.Collections.Generic.List<JetBrains.ReSharper.Psi.JavaScript.Impl.ControlFlow.Inspections.ValueAnalysis.ContractAnnotations.AnnotationParameter> Parameters { get; set; }
        public JetBrains.ReSharper.Psi.JavaScript.Impl.ControlFlow.Inspections.ValueAnalysis.Values.JsVariableStateExtended Return { get; set; }
    }
    public class static FunctionAnnotationEntryEx
    {
        public static ulong CountApplicableTuple(this JetBrains.ReSharper.Psi.JavaScript.Impl.ControlFlow.Inspections.ValueAnalysis.ContractAnnotations.FunctionAnnotationEntry annotationEntry, System.Collections.Generic.IList<JetBrains.ReSharper.Psi.JavaScript.Impl.ControlFlow.Inspections.ValueAnalysis.Values.JsVariableStateExtended> parameters) { }
        public static int MaxParameterIndex(this JetBrains.ReSharper.Psi.JavaScript.Impl.ControlFlow.Inspections.ValueAnalysis.ContractAnnotations.FunctionAnnotationEntry entry) { }
    }
    public class PreparedAnnotation
    {
        public JetBrains.ReSharper.Psi.JavaScript.Impl.ControlFlow.Inspections.ValueAnalysis.Values.JsVariableStateExtended DefaultReturnValue { get; }
        public void AddAnnotationEntries(JetBrains.ReSharper.Psi.JavaScript.Impl.ControlFlow.Inspections.ValueAnalysis.ContractAnnotations.FunctionAnnotationEntry[] entries) { }
        public static JetBrains.ReSharper.Psi.JavaScript.Impl.ControlFlow.Inspections.ValueAnalysis.ContractAnnotations.PreparedAnnotation BuildPreparedAnnotation(JetBrains.ReSharper.Psi.JavaScript.Impl.ControlFlow.Inspections.ValueAnalysis.ContractAnnotations.FunctionAnnotationEntry[] annotationEntries) { }
        public JetBrains.ReSharper.Psi.JavaScript.Impl.ControlFlow.Inspections.ValueAnalysis.Values.JsVariableStateExtended ComputeReturnValue(System.Collections.Generic.IList<JetBrains.ReSharper.Psi.JavaScript.Impl.ControlFlow.Inspections.ValueAnalysis.Values.JsVariableStateExtended> paramValues) { }
        public JetBrains.ReSharper.Psi.JavaScript.Impl.ControlFlow.Inspections.ValueAnalysis.Values.JsVariableStateExtended GetCommonMask(int paramIndex) { }
        public JetBrains.ReSharper.Psi.JavaScript.Impl.ControlFlow.Inspections.ValueAnalysis.Values.JsVariableStateExtended GetIfableMask(int paramIndex) { }
        public JetBrains.ReSharper.Psi.JavaScript.Impl.ControlFlow.Inspections.ValueAnalysis.Values.JsVariableStateExtended GetNotifableMask(int paramIndex) { }
        public void MergeWith(JetBrains.ReSharper.Psi.JavaScript.Impl.ControlFlow.Inspections.ValueAnalysis.ContractAnnotations.PreparedAnnotation other) { }
        public void Read(System.IO.BinaryReader reader) { }
        public void Write(System.IO.BinaryWriter writer) { }
    }
    public class PreparedFunctionAnnotation
    {
        public JetBrains.ReSharper.Psi.JavaScript.Impl.ControlFlow.Inspections.ValueAnalysis.ContractAnnotations.FunctionAnnotation Annotation { get; }
        public JetBrains.ReSharper.Psi.JavaScript.Impl.ControlFlow.Inspections.ValueAnalysis.Values.JsVariableStateExtended[] ParameterCommonMask { get; }
        public JetBrains.ReSharper.Psi.JavaScript.Impl.ControlFlow.Inspections.ValueAnalysis.Values.JsVariableStateExtended[] ParameterIfableMask { get; }
        public JetBrains.ReSharper.Psi.JavaScript.Impl.ControlFlow.Inspections.ValueAnalysis.Values.JsVariableStateExtended[] ParameterNotifableMask { get; }
        public static JetBrains.ReSharper.Psi.JavaScript.Impl.ControlFlow.Inspections.ValueAnalysis.ContractAnnotations.PreparedFunctionAnnotation CreatePreparedList(JetBrains.ReSharper.Psi.JavaScript.Impl.ControlFlow.Inspections.ValueAnalysis.ContractAnnotations.FunctionAnnotation annotation) { }
    }
}
namespace JetBrains.ReSharper.Psi.JavaScript.Impl.ControlFlow.Inspections.ValueAnalysis.ContractAnnotations.Parser
{
    
    public class AnnotationParserException : System.Exception
    {
        public AnnotationParserException(string message) { }
        public AnnotationParserException(string message, System.Exception innerException) { }
    }
    public class FunctionAnnotationParser
    {
        public static JetBrains.ReSharper.Psi.JavaScript.Impl.ControlFlow.Inspections.ValueAnalysis.ContractAnnotations.FunctionAnnotationEntry ParseAnnotation(string text, JetBrains.ReSharper.Psi.JavaScript.Tree.IJsFunctionLike function) { }
        public static JetBrains.Util.dataStructures.FrugalLocalList<JetBrains.ReSharper.Psi.JavaScript.Impl.ControlFlow.Inspections.ValueAnalysis.ContractAnnotations.FunctionAnnotationEntry> ParseAnnotationList(string text, JetBrains.ReSharper.Psi.JavaScript.Tree.IJsFunctionLike function) { }
    }
}
namespace JetBrains.ReSharper.Psi.JavaScript.Impl.ControlFlow.Inspections.ValueAnalysis.DataStruct
{
    
    public class BitVector
    {
        public BitVector(JetBrains.ReSharper.Psi.JavaScript.Impl.ControlFlow.Inspections.ValueAnalysis.DataStruct.BitVector other) { }
        public BitVector(int size) { }
        public int Count { get; }
        public bool this[int index] { get; set; }
        public bool And(JetBrains.ReSharper.Psi.JavaScript.Impl.ControlFlow.Inspections.ValueAnalysis.DataStruct.BitVector other) { }
        public bool Assign(JetBrains.ReSharper.Psi.JavaScript.Impl.ControlFlow.Inspections.ValueAnalysis.DataStruct.BitVector other) { }
        public bool Except(JetBrains.ReSharper.Psi.JavaScript.Impl.ControlFlow.Inspections.ValueAnalysis.DataStruct.BitVector other) { }
        public bool GetBit(int index) { }
        public bool IsEqualTo(JetBrains.ReSharper.Psi.JavaScript.Impl.ControlFlow.Inspections.ValueAnalysis.DataStruct.BitVector other) { }
        public void Not() { }
        public bool Or(JetBrains.ReSharper.Psi.JavaScript.Impl.ControlFlow.Inspections.ValueAnalysis.DataStruct.BitVector other) { }
        public void Resize(int newSize) { }
        public void SetBit(int index, bool value) { }
    }
}
namespace JetBrains.ReSharper.Psi.JavaScript.Impl.ControlFlow.Inspections.ValueAnalysis.DependentAnalysis
{
    
    public class JsMemoryHive : System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.JavaScript.Impl.ControlFlow.Inspections.ValueAnalysis.DependentAnalysis.JsMemorySnapshot>, System.Collections.IEnumerable
    {
        public System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.JavaScript.Impl.ControlFlow.Inspections.ValueAnalysis.DependentAnalysis.JsMemorySnapshot> Snapshots { get; }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Psi.JavaScript.Impl.ControlFlow.Inspections.ValueAnalysis.Values.JsVariableState> BuildVariableStatesList(int variableCount) { }
        public static JetBrains.ReSharper.Psi.JavaScript.Impl.ControlFlow.Inspections.ValueAnalysis.DependentAnalysis.JsMemoryHive CreateInitialHive(int variableCount, int expressionCount, System.Collections.Generic.IList<JetBrains.ReSharper.Psi.JavaScript.Impl.ControlFlow.Inspections.ValueAnalysis.Values.JsVariableState> initialValues, JetBrains.ReSharper.Psi.JavaScript.Impl.ControlFlow.Inspections.ValueAnalysis.Values.JsVariableState initialExprValue) { }
        public override bool Equals(object obj) { }
        public System.Collections.Generic.IEnumerator<JetBrains.ReSharper.Psi.JavaScript.Impl.ControlFlow.Inspections.ValueAnalysis.DependentAnalysis.JsMemorySnapshot> GetEnumerator() { }
        public override int GetHashCode() { }
    }
    public class static JsMemoryHiveExt
    {
        public static JetBrains.ReSharper.Psi.JavaScript.Impl.ControlFlow.Inspections.ValueAnalysis.DependentAnalysis.JsMemoryHive FilterHive(this JetBrains.ReSharper.Psi.JavaScript.Impl.ControlFlow.Inspections.ValueAnalysis.DependentAnalysis.JsMemoryHive hive, System.Predicate<JetBrains.ReSharper.Psi.JavaScript.Impl.ControlFlow.Inspections.ValueAnalysis.DependentAnalysis.JsMemorySnapshot> filterPredicate) { }
        public static JetBrains.ReSharper.Psi.JavaScript.Impl.ControlFlow.Inspections.ValueAnalysis.DependentAnalysis.JsMemoryHive MergeWith(this JetBrains.ReSharper.Psi.JavaScript.Impl.ControlFlow.Inspections.ValueAnalysis.DependentAnalysis.JsMemoryHive hive, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.JavaScript.Impl.ControlFlow.Inspections.ValueAnalysis.DependentAnalysis.JsMemoryHive> otherHives) { }
        public static JetBrains.ReSharper.Psi.JavaScript.Impl.ControlFlow.Inspections.ValueAnalysis.DependentAnalysis.JsMemoryHive MutateHive(this JetBrains.ReSharper.Psi.JavaScript.Impl.ControlFlow.Inspections.ValueAnalysis.DependentAnalysis.JsMemoryHive hive, System.Func<JetBrains.ReSharper.Psi.JavaScript.Impl.ControlFlow.Inspections.ValueAnalysis.DependentAnalysis.JsMemorySnapshot, JetBrains.ReSharper.Psi.JavaScript.Impl.ControlFlow.Inspections.ValueAnalysis.DependentAnalysis.JsMemorySnapshot> snapshotMutator) { }
        public static JetBrains.ReSharper.Psi.JavaScript.Impl.ControlFlow.Inspections.ValueAnalysis.DependentAnalysis.JsMemoryHive MutateHive(this JetBrains.ReSharper.Psi.JavaScript.Impl.ControlFlow.Inspections.ValueAnalysis.DependentAnalysis.JsMemoryHive hive, System.Func<JetBrains.ReSharper.Psi.JavaScript.Impl.ControlFlow.Inspections.ValueAnalysis.DependentAnalysis.JsMemorySnapshot, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.JavaScript.Impl.ControlFlow.Inspections.ValueAnalysis.DependentAnalysis.JsMemorySnapshot>> forker) { }
    }
    public class JsMemorySnapshot
    {
        public JsMemorySnapshot(int expressionCount, int variableCount, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.JavaScript.Impl.ControlFlow.Inspections.ValueAnalysis.Values.JsVariableState> initialVarValues, JetBrains.ReSharper.Psi.JavaScript.Impl.ControlFlow.Inspections.ValueAnalysis.Values.JsVariableState initialExprValue) { }
        public int VariableCount { get; }
        public JetBrains.ReSharper.Psi.JavaScript.Impl.ControlFlow.Inspections.ValueAnalysis.DependentAnalysis.JsMemorySnapshot Clone() { }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
        public JetBrains.ReSharper.Psi.JavaScript.Impl.ControlFlow.Inspections.ValueAnalysis.Values.JsVariableState GetVariableState(int variableIndex) { }
        public JetBrains.ReSharper.Psi.JavaScript.Impl.ControlFlow.Inspections.ValueAnalysis.Values.JsVariableState PeekExpressionState(int expressionIndex) { }
        public void PushExpressionState(int expressionIndex, JetBrains.ReSharper.Psi.JavaScript.Impl.ControlFlow.Inspections.ValueAnalysis.Values.JsVariableState state) { }
        public void SetVariableState(int variableIndex, JetBrains.ReSharper.Psi.JavaScript.Impl.ControlFlow.Inspections.ValueAnalysis.Values.JsVariableState newState) { }
    }
    public class PackedVariableStateArray : JetBrains.ReSharper.Psi.JavaScript.Impl.ControlFlow.Inspections.ValueAnalysis.PackedIntegerArray<JetBrains.ReSharper.Psi.JavaScript.Impl.ControlFlow.Inspections.ValueAnalysis.DependentAnalysis.VariableStateBitsPerValue>
    {
        public PackedVariableStateArray(int valuesCount) { }
        public PackedVariableStateArray(JetBrains.ReSharper.Psi.JavaScript.Impl.ControlFlow.Inspections.ValueAnalysis.PackedIntegerArray<JetBrains.ReSharper.Psi.JavaScript.Impl.ControlFlow.Inspections.ValueAnalysis.DependentAnalysis.VariableStateBitsPerValue> other) { }
    }
    public struct VariableStateBitsPerValue : JetBrains.ReSharper.Psi.JavaScript.Impl.ControlFlow.Inspections.ValueAnalysis.IBitsPerValueProvider
    {
        public int BitsPerValue { get; }
    }
}
namespace JetBrains.ReSharper.Psi.JavaScript.Impl.ControlFlow.Inspections.ValueAnalysis
{
    
    public interface IBitsPerValueProvider
    {
        int BitsPerValue { get; }
    }
    public interface IJsValueAnalysisResults
    {
        System.Collections.Generic.IList<JetBrains.Util.Pair<JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression, bool>> ConstantConditionals { get; }
        System.Collections.Generic.IList<JetBrains.Util.Pair<JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression, JetBrains.ReSharper.Psi.JavaScript.Impl.ControlFlow.Inspections.ValueAnalysis.Values.JsVariableStateExtended>> ConstantExpressions { get; }
        System.Collections.Generic.IList<JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression> InvokedNonFunctionExpressions { get; }
        System.Collections.Generic.IList<JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression> MaybeInvokedNonFunctionExpressions { get; }
        System.Collections.Generic.IList<JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression> MaybeQualifiedNullReferences { get; }
        System.Collections.Generic.IList<JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression> QualifiedNullReferences { get; }
        System.Collections.Generic.IList<JetBrains.ReSharper.Psi.ITreeRange> UnreachableTreeRanges { get; }
    }
    public class JsControlFlowContext
    {
        public JsControlFlowContext(System.Collections.Generic.IList<JetBrains.ReSharper.Psi.JavaScript.Impl.ControlFlow.Inspections.ValueAnalysis.Values.JsVariableStateExtended> initialVariableStates, JetBrains.ReSharper.Psi.JavaScript.Impl.ControlFlow.Inspections.ValueAnalysis.ValueAnalysisPreprocessingData preprocessingData) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Psi.JavaScript.Impl.ControlFlow.Inspections.ValueAnalysis.DependentAnalysis.JsMemoryHive Hive { get; set; }
        public JetBrains.ReSharper.Psi.JavaScript.Impl.ControlFlow.Inspections.ValueAnalysis.DataStruct.BitVector ReachingDefinitions { get; }
        public int SnapshotCount { get; }
        public JetBrains.ReSharper.Psi.JavaScript.Impl.ControlFlow.Inspections.ValueAnalysis.DataStruct.BitVector VariableHasReadsInLambda { get; }
        public JetBrains.ReSharper.Psi.JavaScript.Impl.ControlFlow.Inspections.ValueAnalysis.DataStruct.BitVector VariableHasWritesInLambda { get; }
        public JetBrains.ReSharper.Psi.JavaScript.Impl.ControlFlow.Inspections.ValueAnalysis.PackedVariableStateExtendedArray VariableStates { get; }
        public JetBrains.ReSharper.Psi.JavaScript.Impl.ControlFlow.Inspections.ValueAnalysis.JsControlFlowContext Clone() { }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
        public JetBrains.ReSharper.Psi.JavaScript.Impl.ControlFlow.Inspections.ValueAnalysis.Values.JsVariableStateExtended GetVariableState(int index) { }
        public bool HasComplexityOverflow() { }
        public static JetBrains.ReSharper.Psi.JavaScript.Impl.ControlFlow.Inspections.ValueAnalysis.JsControlFlowContext Merge(System.Collections.Generic.IList<JetBrains.ReSharper.Psi.JavaScript.Impl.ControlFlow.Inspections.ValueAnalysis.JsControlFlowContext> others) { }
        public void PropagateAccessedVariables(System.Collections.Generic.ICollection<int> readAccessedVariables, System.Collections.Generic.ICollection<int> writeAccessedVariables) { }
        public void ReadVariable(int index, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptTreeNode sourceElement, JetBrains.ReSharper.Psi.JavaScript.Impl.ControlFlow.Inspections.ValueAnalysis.ValueAnalysisPreprocessingData preprocessingData) { }
        public void SetVariableState(int index, JetBrains.ReSharper.Psi.JavaScript.Impl.ControlFlow.Inspections.ValueAnalysis.Values.JsVariableStateExtended state) { }
        public void WriteVariable(int index, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptTreeNode binaryExpression, JetBrains.ReSharper.Psi.JavaScript.Impl.ControlFlow.Inspections.ValueAnalysis.ValueAnalysisPreprocessingData preprocessingData) { }
    }
    public class JsControlFlowGraphInspector : JetBrains.ReSharper.Psi.ControlFlow.Impl.ControlFlowGrafInspector<JetBrains.ReSharper.Psi.JavaScript.Impl.ControlFlow.Inspections.ValueAnalysis.JsControlFlowContext>, JetBrains.ReSharper.Psi.JavaScript.Impl.ControlFlow.Inspections.ReachingDefinitions.IReachingDefinitionsResult, JetBrains.ReSharper.Psi.JavaScript.Impl.ControlFlow.Inspections.ValueAnalysis.IJsValueAnalysisResults
    {
        public const int MAX_SNAPSHOTS_IN_HIVE = 8192;
        public JsControlFlowGraphInspector(JetBrains.ReSharper.Psi.ControlFlow.Impl.ControlFlowGraf graph, JetBrains.ReSharper.Psi.JavaScript.Services.JavaScriptServices services, JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.JavaScriptResolveContext context) { }
        public System.Collections.Generic.IList<JetBrains.Util.Pair<JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression, bool>> ConstantConditionals { get; }
        public System.Collections.Generic.IList<JetBrains.Util.Pair<JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression, JetBrains.ReSharper.Psi.JavaScript.Impl.ControlFlow.Inspections.ValueAnalysis.Values.JsVariableStateExtended>> ConstantExpressions { get; }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression> InvokedNonFunctionExpressions { get; }
        public bool IsFinished { get; }
        public System.Collections.Generic.List<JetBrains.ReSharper.Psi.JavaScript.Impl.ControlFlow.Inspections.ValueAnalysis.ValueAnalysisVariableInfo> LocalVariables { get; }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression> MaybeInvokedNonFunctionExpressions { get; }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression> MaybeQualifiedNullReferences { get; }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression> QualifiedNullReferences { get; }
        public System.Collections.Generic.Dictionary<JetBrains.ReSharper.Psi.Tree.ITreeNode, int> ReadUsages { get; }
        public JetBrains.Util.OneToSetMap<JetBrains.ReSharper.Psi.Tree.ITreeNode, int> ReadUsagesInInnerFunctions { get; }
        public JetBrains.Util.OneToListMap<JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode> ResultDefinitionsToUsages { get; }
        public System.Collections.Generic.JetHashSet<JetBrains.ReSharper.Psi.Tree.ITreeNode> ResultHasReadsInInnerFunctionsBefore { get; }
        public System.Collections.Generic.JetHashSet<JetBrains.ReSharper.Psi.Tree.ITreeNode> ResultHasWritesInInnerFunctionsBefore { get; }
        public JetBrains.Util.OneToListMap<JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode> ResultUsagesToDefinitions { get; }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Psi.ITreeRange> UnreachableTreeRanges { get; }
        public System.Collections.Generic.Dictionary<JetBrains.ReSharper.Psi.JavaScript.DeclaredElements.IJavaScriptLocalElement, int> VariableIndicies { get; }
        public System.Collections.Generic.Dictionary<JetBrains.ReSharper.Psi.Tree.ITreeNode, int> WriteUsages { get; }
        public JetBrains.Util.OneToSetMap<JetBrains.ReSharper.Psi.Tree.ITreeNode, int> WriteUsagesInInnerFunctions { get; }
        public override void Inspect() { }
        protected override bool InspectionPass(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.ControlFlow.IControlFlowElement> sequence) { }
        protected override void InspectLeafElementAndSetContextToExits(JetBrains.ReSharper.Psi.ControlFlow.IControlFlowElement element, JetBrains.ReSharper.Psi.JavaScript.Impl.ControlFlow.Inspections.ValueAnalysis.JsControlFlowContext context) { }
    }
    public class PackedIntegerArray<TBitsPerValue>
        where TBitsPerValue : JetBrains.ReSharper.Psi.JavaScript.Impl.ControlFlow.Inspections.ValueAnalysis.IBitsPerValueProvider
    {
        public PackedIntegerArray(int valuesCount) { }
        public PackedIntegerArray(JetBrains.ReSharper.Psi.JavaScript.Impl.ControlFlow.Inspections.ValueAnalysis.PackedIntegerArray<TBitsPerValue> other) { }
        public int BitsPerValue { get; }
        public int Count { get; }
        public ulong this[int index] { get; set; }
        public void AndAssign(JetBrains.ReSharper.Psi.JavaScript.Impl.ControlFlow.Inspections.ValueAnalysis.PackedIntegerArray<TBitsPerValue> other) { }
        public override bool Equals(object obj) { }
        public ulong Get(int index) { }
        public override int GetHashCode() { }
        public bool IsEqualTo(JetBrains.ReSharper.Psi.JavaScript.Impl.ControlFlow.Inspections.ValueAnalysis.PackedIntegerArray<TBitsPerValue> other) { }
        public void Not() { }
        public void OrAssign(JetBrains.ReSharper.Psi.JavaScript.Impl.ControlFlow.Inspections.ValueAnalysis.PackedIntegerArray<TBitsPerValue> other) { }
        public void Set(int index, ulong value) { }
    }
    public class PackedVariableStateExtendedArray : JetBrains.ReSharper.Psi.JavaScript.Impl.ControlFlow.Inspections.ValueAnalysis.PackedIntegerArray<JetBrains.ReSharper.Psi.JavaScript.Impl.ControlFlow.Inspections.ValueAnalysis.VariableStateExtendedBitsPerValue>
    {
        public PackedVariableStateExtendedArray(int valuesCount) { }
        public PackedVariableStateExtendedArray(JetBrains.ReSharper.Psi.JavaScript.Impl.ControlFlow.Inspections.ValueAnalysis.PackedIntegerArray<JetBrains.ReSharper.Psi.JavaScript.Impl.ControlFlow.Inspections.ValueAnalysis.VariableStateExtendedBitsPerValue> other) { }
    }
    public class ValueAnalysisPreprocessingData
    {
        public System.Collections.Generic.List<JetBrains.ReSharper.Psi.JavaScript.Impl.ControlFlow.Inspections.ReachingDefinitions.ControlFlowDefinition> Definitions { get; }
        public JetBrains.ReSharper.Psi.JavaScript.Impl.ControlFlow.Inspections.ValueAnalysis.DataStruct.BitVector InitialDefinitions { get; }
        public System.Collections.Generic.Dictionary<JetBrains.ReSharper.Psi.JavaScript.DeclaredElements.IJavaScriptLocalElement, int> LocalVariableIndicies { get; }
        public System.Collections.Generic.List<JetBrains.ReSharper.Psi.JavaScript.Impl.ControlFlow.Inspections.ValueAnalysis.ValueAnalysisVariableInfo> LocalVariables { get; }
        public int MaxExpressionDepth { get; }
        public System.Collections.Generic.Dictionary<JetBrains.ReSharper.Psi.Tree.ITreeNode, int> NodeToDefinitionIndex { get; }
        public System.Collections.Generic.Dictionary<JetBrains.ReSharper.Psi.Tree.ITreeNode, int> NodeToExpressionDepth { get; }
        public JetBrains.ReSharper.Psi.JavaScript.Impl.ControlFlow.Inspections.ValueAnalysis.DataStruct.BitVector NullDefinitions { get; }
        public System.Collections.Generic.Dictionary<JetBrains.ReSharper.Psi.Tree.ITreeNode, int> ReadUsages { get; }
        public JetBrains.Util.OneToSetMap<JetBrains.ReSharper.Psi.Tree.ITreeNode, int> ReadUsagesInInnerFunctions { get; }
        public System.Collections.Generic.JetHashSet<int> VariablesReadInNamedInnerFunctions { get; }
        public System.Collections.Generic.List<int> VariablesWrittenInLambda { get; }
        public System.Collections.Generic.JetHashSet<int> VariablesWrittenInNamedInnerFunctions { get; }
        public System.Collections.Generic.Dictionary<JetBrains.ReSharper.Psi.Tree.ITreeNode, int> WriteUsages { get; }
        public JetBrains.Util.OneToSetMap<JetBrains.ReSharper.Psi.Tree.ITreeNode, int> WriteUsagesInInnerFunctions { get; }
        public static JetBrains.ReSharper.Psi.JavaScript.Impl.ControlFlow.Inspections.ValueAnalysis.ValueAnalysisPreprocessingData.DataBuilder CreateBuilder(JetBrains.ReSharper.Psi.Tree.ITreeNode cfgBodySourceElement) { }
        public class DataBuilder
        {
            public DataBuilder(JetBrains.ReSharper.Psi.Tree.ITreeNode cfgBodySourceElement) { }
            public int AddDefinition(JetBrains.ReSharper.Psi.Tree.ITreeNode node, int variableIndex) { }
            public int AddInitialDefinition(JetBrains.ReSharper.Psi.Tree.ITreeNode node, int variableIndex) { }
            public void AddReadUsage(JetBrains.ReSharper.Psi.Tree.ITreeNode node, JetBrains.ReSharper.Psi.JavaScript.DeclaredElements.IJavaScriptLocalElement variable, bool isInnerFunctionUsage = False) { }
            public void AddReadUsage(JetBrains.ReSharper.Psi.Tree.ITreeNode node, int variableIndex, bool isInnerFunctionUsage = False) { }
            public int AddVariable(JetBrains.ReSharper.Psi.JavaScript.DeclaredElements.IJavaScriptLocalElement variable, JetBrains.ReSharper.Psi.JavaScript.Impl.ControlFlow.Inspections.ValueAnalysis.Values.JsVariableStateExtended initialValue) { }
            public void AddWriteInLambda(int variableIndex, JetBrains.ReSharper.Psi.JavaScript.Impl.ControlFlow.Inspections.ValueAnalysis.Values.JsVariableStateExtended value) { }
            public void AddWriteUsage(JetBrains.ReSharper.Psi.Tree.ITreeNode node, JetBrains.ReSharper.Psi.JavaScript.DeclaredElements.IJavaScriptLocalElement variable, bool isInnerFunctionUsage = False) { }
            public void AddWriteUsage(JetBrains.ReSharper.Psi.Tree.ITreeNode node, int variableIndex, bool isInnerFunctionUsage = False) { }
            public JetBrains.ReSharper.Psi.JavaScript.Impl.ControlFlow.Inspections.ValueAnalysis.ValueAnalysisPreprocessingData BuildData() { }
            public int GetExpressionDepth(JetBrains.ReSharper.Psi.Tree.ITreeNode node) { }
            public int GetVariableIndex(JetBrains.ReSharper.Psi.JavaScript.DeclaredElements.IJavaScriptLocalElement variable) { }
            public void SetExpressionDepth(JetBrains.ReSharper.Psi.Tree.ITreeNode node, int value) { }
            public void SetMaxExpressionsDepth(int value) { }
        }
    }
    public class ValueAnalysisVariableInfo
    {
        public JetBrains.ReSharper.Psi.JavaScript.DeclaredElements.IJavaScriptLocalElement DeclaredElement { get; }
        public JetBrains.ReSharper.Psi.JavaScript.Impl.ControlFlow.Inspections.ValueAnalysis.DataStruct.BitVector Definitions { get; set; }
        public JetBrains.ReSharper.Psi.JavaScript.Impl.ControlFlow.Inspections.ValueAnalysis.Values.JsVariableStateExtended InitialValue { get; }
        public int NullDefinitionIndex { get; set; }
        public JetBrains.ReSharper.Psi.JavaScript.Impl.ControlFlow.Inspections.ValueAnalysis.Values.JsVariableStateExtended StatesWrittenInLambda { get; }
    }
    public struct VariableStateExtendedBitsPerValue : JetBrains.ReSharper.Psi.JavaScript.Impl.ControlFlow.Inspections.ValueAnalysis.IBitsPerValueProvider
    {
        public int BitsPerValue { get; }
    }
}
namespace JetBrains.ReSharper.Psi.JavaScript.Impl.ControlFlow.Inspections.ValueAnalysis.Providers
{
    
    public class CacheFunctionAnnotationProvider : JetBrains.ReSharper.Psi.JavaScript.Impl.ControlFlow.Inspections.ValueAnalysis.Providers.IFunctionAnnotationProvider
    {
        public CacheFunctionAnnotationProvider(JetBrains.ReSharper.Psi.JavaScript.Services.JavaScriptServices services, JetBrains.ReSharper.Psi.IPsiSourceFile psiSourceFile, JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.JavaScriptResolveContext context) { }
        public JetBrains.ReSharper.Psi.JavaScript.Impl.ControlFlow.Inspections.ValueAnalysis.ContractAnnotations.PreparedAnnotation GetFunctionAnnotation(JetBrains.ReSharper.Psi.JavaScript.Tree.IReferenceExpression reference) { }
    }
    public class DefaultValueProvider : JetBrains.ReSharper.Psi.JavaScript.Impl.ControlFlow.Inspections.ValueAnalysis.Providers.IAnalysisValueProvider
    {
        public virtual JetBrains.ReSharper.Psi.JavaScript.Impl.ControlFlow.Inspections.ValueAnalysis.Values.JsVariableStateExtended GetInitialParameterValue(int parameterIndex) { }
        public virtual JetBrains.ReSharper.Psi.JavaScript.Impl.ControlFlow.Inspections.ValueAnalysis.Values.JsVariableStateExtended GetReferenceValue(JetBrains.ReSharper.Psi.JavaScript.Tree.IReferenceExpression reference, JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
    }
    public interface IAnalysisValueProvider
    {
        JetBrains.ReSharper.Psi.JavaScript.Impl.ControlFlow.Inspections.ValueAnalysis.Values.JsVariableStateExtended GetInitialParameterValue(int parameterIndex);
        JetBrains.ReSharper.Psi.JavaScript.Impl.ControlFlow.Inspections.ValueAnalysis.Values.JsVariableStateExtended GetReferenceValue(JetBrains.ReSharper.Psi.JavaScript.Tree.IReferenceExpression reference, JetBrains.ReSharper.Psi.IDeclaredElement declaredElement);
    }
    public interface IFunctionAnnotationProvider
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.JavaScript.Impl.ControlFlow.Inspections.ValueAnalysis.ContractAnnotations.PreparedAnnotation GetFunctionAnnotation(JetBrains.ReSharper.Psi.JavaScript.Tree.IReferenceExpression reference);
    }
    public class InlineParameterValueProvider : JetBrains.ReSharper.Psi.JavaScript.Impl.ControlFlow.Inspections.ValueAnalysis.Providers.DefaultValueProvider
    {
        public InlineParameterValueProvider(JetBrains.ReSharper.Psi.JavaScript.Tree.IInvocationExpression invocation) { }
        public override JetBrains.ReSharper.Psi.JavaScript.Impl.ControlFlow.Inspections.ValueAnalysis.Values.JsVariableStateExtended GetInitialParameterValue(int parameterIndex) { }
    }
}
namespace JetBrains.ReSharper.Psi.JavaScript.Impl.ControlFlow.Inspections.ValueAnalysis.ReachingDefintions
{
    
    public class ContextData
    {
        public ContextData(int variablesCount) { }
        public JetBrains.ReSharper.Psi.JavaScript.Impl.ControlFlow.Inspections.ValueAnalysis.DataStruct.BitVector HasReadInLambda { get; }
        public JetBrains.ReSharper.Psi.JavaScript.Impl.ControlFlow.Inspections.ValueAnalysis.DataStruct.BitVector HasWritesInLambda { get; }
        public JetBrains.ReSharper.Psi.JavaScript.Impl.ControlFlow.Inspections.ValueAnalysis.DataStruct.BitVector ReachingAssignments { get; }
        protected bool Equals(JetBrains.ReSharper.Psi.JavaScript.Impl.ControlFlow.Inspections.ValueAnalysis.ReachingDefintions.ContextData other) { }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
    }
    public struct Definition
    {
        public JetBrains.ReSharper.Psi.Tree.ITreeNode DefinitionNode;
    }
    public class PreprocessingData
    {
        public System.Collections.Generic.List<JetBrains.ReSharper.Psi.JavaScript.Impl.ControlFlow.Inspections.ValueAnalysis.ReachingDefintions.Definition> Definitions { get; }
        public JetBrains.ReSharper.Psi.JavaScript.Impl.ControlFlow.Inspections.ValueAnalysis.DataStruct.BitVector LambdaDefinitions { get; }
        public System.Collections.Generic.List<JetBrains.ReSharper.Psi.JavaScript.Impl.ControlFlow.Inspections.ValueAnalysis.ReachingDefintions.VariableInfo> VariableInfo { get; }
    }
    public struct VariableInfo
    {
        public JetBrains.ReSharper.Psi.JavaScript.Impl.ControlFlow.Inspections.ValueAnalysis.DataStruct.BitVector Definitions;
    }
}
namespace JetBrains.ReSharper.Psi.JavaScript.Impl.ControlFlow.Inspections.ValueAnalysis.Rules
{
    
    public class OpBinaryInstanceOfRules : JetBrains.ReSharper.Psi.JavaScript.Impl.ControlFlow.Inspections.ValueAnalysis.Rules.IBinaryOperatorRules
    {
        public JetBrains.ReSharper.Psi.JavaScript.Impl.ControlFlow.Inspections.ValueAnalysis.Values.JsVariableStateExtended GetResultState(JetBrains.ReSharper.Psi.JavaScript.Impl.ControlFlow.Inspections.ValueAnalysis.Values.JsVariableStateExtended left, JetBrains.ReSharper.Psi.JavaScript.Impl.ControlFlow.Inspections.ValueAnalysis.Values.JsVariableStateExtended right) { }
    }
    public class OpUnaryVoidRules : JetBrains.ReSharper.Psi.JavaScript.Impl.ControlFlow.Inspections.ValueAnalysis.Rules.IUnaryOperatorRules
    {
        public JetBrains.ReSharper.Psi.JavaScript.Impl.ControlFlow.Inspections.ValueAnalysis.Values.JsVariableStateExtended GetResultState(JetBrains.ReSharper.Psi.JavaScript.Impl.ControlFlow.Inspections.ValueAnalysis.Values.JsVariableStateExtended operand) { }
    }
}
namespace JetBrains.ReSharper.Psi.JavaScript.Impl.ControlFlow.Inspections.ValueAnalysis.Util
{
    
    public class static MathUtil
    {
        public static ulong IntPow(ulong x, uint pow) { }
    }
}
namespace JetBrains.ReSharper.Psi.JavaScript.Impl.ControlFlow.Inspections.ValueAnalysis.Values
{
    
    [System.FlagsAttribute()]
    public enum JsVariableState : byte
    {
        None = 0,
        StrictIfable = 1,
        WeakIfable = 2,
        Ifable = 3,
        StrictNotIfable = 4,
        WeakNotIfable = 8,
        NotIfable = 12,
        Strict = 5,
        Weak = 10,
        Anything = 15,
    }
    [System.FlagsAttribute()]
    public enum JsVariableStateExtended : ulong
    {
        Number_NaN = 1ul,
        Number_Zero = 2ul,
        Number_Other = 4ul,
        String_Empty = 8ul,
        String_Zero = 16ul,
        String_Undefined = 32ul,
        String_Number = 64ul,
        String_String = 128ul,
        String_Boolean = 256ul,
        String_Object = 512ul,
        String_Function = 1024ul,
        String_Other = 2048ul,
        Bool_True = 4096ul,
        Bool_False = 8192ul,
        Undefined = 16384ul,
        Null = 32768ul,
        Function = 65536ul,
        Object_Number_NaN = 131072ul,
        Object_Number_Zero = 262144ul,
        Object_Number_Other = 524288ul,
        Object_String_Empty = 1048576ul,
        Object_String_Zero = 2097152ul,
        Object_String_Undefined = 4194304ul,
        Object_String_Number = 8388608ul,
        Object_String_String = 16777216ul,
        Object_String_Boolean = 33554432ul,
        Object_String_Object = 67108864ul,
        Object_String_Function = 134217728ul,
        Object_String_Other = 268435456ul,
        Object_Bool_True = 536870912ul,
        Object_Bool_False = 1073741824ul,
        Object_Other = 2147483648ul,
        Array = 4294967296ul,
        Unknown_NullRef = 8589934592ul,
        Unknown_Function = 17179869184ul,
        Unknown = 25769803776ul,
        StrictIfable = 3217760228ul,
        WeakIfable = 5372117008ul,
        StrictNotIfable = 49153ul,
        WeakNotIfable = 8202ul,
        Ifable = 34359681012ul,
        NotIfable = 25769861131ul,
        Anything = 34359738367ul,
        None = 0ul,
    }
    public class static JsVariableStateExtendedUtil
    {
        public const int BITS_PER_VALUE = 35;
        public const int MAX_BIT_INDEX = 32;
        public const JetBrains.ReSharper.Psi.JavaScript.Impl.ControlFlow.Inspections.ValueAnalysis.Values.JsVariableStateExtended NUMBER = 7ul;
        public const JetBrains.ReSharper.Psi.JavaScript.Impl.ControlFlow.Inspections.ValueAnalysis.Values.JsVariableStateExtended OBJECT = 8589803520ul;
        public const JetBrains.ReSharper.Psi.JavaScript.Impl.ControlFlow.Inspections.ValueAnalysis.Values.JsVariableStateExtended STRING = 4088ul;
        public static JetBrains.ReSharper.Psi.JavaScript.Impl.ControlFlow.Inspections.ValueAnalysis.Values.JsVariableStateExtended FromLiteralExpression([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptLiteralExpression expression) { }
        public static JetBrains.ReSharper.Psi.JavaScript.Impl.ControlFlow.Inspections.ValueAnalysis.Values.JsVariableStateExtended FromState(JetBrains.ReSharper.Psi.JavaScript.Impl.ControlFlow.Inspections.ValueAnalysis.Values.JsVariableState state, bool setUnkownBit) { }
        public static JetBrains.ReSharper.Psi.JavaScript.Impl.ControlFlow.Inspections.ValueAnalysis.Values.JsVariableStateExtended FromTypeOfParamState(JetBrains.ReSharper.Psi.JavaScript.Impl.ControlFlow.Inspections.ValueAnalysis.Values.JsVariableStateExtended typeofParamState) { }
        public static JetBrains.ReSharper.Psi.JavaScript.Impl.ControlFlow.Inspections.ValueAnalysis.Values.JsVariableStateExtended GetVariableStateAfterPostfixOperation(JetBrains.ReSharper.Psi.JavaScript.Impl.ControlFlow.Inspections.ValueAnalysis.Values.JsVariableStateExtended postfixResult) { }
        public static bool IsConstant(this JetBrains.ReSharper.Psi.JavaScript.Impl.ControlFlow.Inspections.ValueAnalysis.Values.JsVariableStateExtended state) { }
        public static string StringValueOfSingleState(this JetBrains.ReSharper.Psi.JavaScript.Impl.ControlFlow.Inspections.ValueAnalysis.Values.JsVariableStateExtended state) { }
        public static JetBrains.ReSharper.Psi.JavaScript.Impl.ControlFlow.Inspections.ValueAnalysis.Values.JsVariableState ToState(this JetBrains.ReSharper.Psi.JavaScript.Impl.ControlFlow.Inspections.ValueAnalysis.Values.JsVariableStateExtended extState) { }
    }
    public class static JsVariableStateUtil
    {
        public const int BITS_PER_VALUE = 4;
        public static JetBrains.ReSharper.Psi.JavaScript.Impl.ControlFlow.Inspections.ValueAnalysis.Values.JsVariableStateExtended ToStateEx(this JetBrains.ReSharper.Psi.JavaScript.Impl.ControlFlow.Inspections.ValueAnalysis.Values.JsVariableState state) { }
    }
}
namespace JetBrains.ReSharper.Psi.JavaScript.Impl.DeclaredElements
{
    
    public interface IJavaScriptSymbolInfoProvider
    {
        bool CanBeFunction(JetBrains.ReSharper.Psi.IDeclaredElement element, JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.JavaScriptResolveContext context);
        JetBrains.ReSharper.Psi.JavaScript.Resolve.FullJavaScriptType GetJsType(JetBrains.ReSharper.Psi.IDeclaredElement element, JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.JavaScriptResolveContext context);
        string GetShortName(JetBrains.ReSharper.Psi.IDeclaredElement element);
        bool HasDynamicName(JetBrains.ReSharper.Psi.IDeclaredElement element);
        bool IsApplicable(JetBrains.ReSharper.Psi.IDeclaredElement element);
        bool IsProperty(JetBrains.ReSharper.Psi.IDeclaredElement element);
    }
    public class JavaScriptArgumentsVariable : JetBrains.ReSharper.Psi.JavaScript.Impl.DeclaredElements.JavaScriptDeclaredElementBase, JetBrains.ReSharper.Psi.IDeclaredElement, JetBrains.ReSharper.Psi.JavaScript.DeclaredElements.IJavaScriptDeclaredElement, JetBrains.ReSharper.Psi.JavaScript.DeclaredElements.IJavaScriptLocalElement, JetBrains.ReSharper.Psi.JavaScript.DeclaredElements.IJavaScriptTypeOwner
    {
        public JavaScriptArgumentsVariable(JetBrains.ReSharper.Psi.JavaScript.Tree.IJsSignatureNode functionExpression, int funcDocumentOffset) { }
        public bool HasDynamicName { get; }
        public bool IsLocal { get; }
        public bool IsVariableOrField { get; }
        public override string ShortName { get; }
        public bool CanBeFunction(JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.JavaScriptResolveContext context) { }
        public bool Equals(JetBrains.ReSharper.Psi.JavaScript.Impl.DeclaredElements.JavaScriptArgumentsVariable other) { }
        public override bool Equals(object obj) { }
        public override System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Tree.IDeclaration> GetDeclarations() { }
        public override System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Tree.IDeclaration> GetDeclarationsIn(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
        public override JetBrains.ReSharper.Psi.DeclaredElementType GetElementType() { }
        public override int GetHashCode() { }
        public JetBrains.ReSharper.Psi.JavaScript.Resolve.JsPrimitive GetJsPrimitive(JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsDocumentOffsetProvider context) { }
        public JetBrains.ReSharper.Psi.JavaScript.Resolve.IJavaScriptType GetJsType(JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsDocumentOffsetProvider context) { }
        public JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptScope GetOwnerScope() { }
        public override JetBrains.ReSharper.Psi.Search.ISearchDomain GetSearchDomain(JetBrains.ReSharper.Psi.Search.SearchDomainFactory factory) { }
    }
    public abstract class JavaScriptDeclaredElementBase : JetBrains.ReSharper.Psi.IDeclaredElement, JetBrains.ReSharper.Psi.JavaScript.Impl.IJavaScriptSearchDomainOwner
    {
        protected JavaScriptDeclaredElementBase(JetBrains.ReSharper.Psi.Modules.IPsiModule module, JetBrains.ReSharper.Psi.IPsiServices psiServices) { }
        public bool CaseSensistiveName { get; }
        public JetBrains.ReSharper.Psi.PsiLanguageType PresentationLanguage { get; }
        public abstract string ShortName { get; }
        public abstract System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Tree.IDeclaration> GetDeclarations();
        public abstract System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Tree.IDeclaration> GetDeclarationsIn(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile);
        public abstract JetBrains.ReSharper.Psi.DeclaredElementType GetElementType();
        public JetBrains.ReSharper.Psi.IPsiServices GetPsiServices() { }
        public abstract JetBrains.ReSharper.Psi.Search.ISearchDomain GetSearchDomain(JetBrains.ReSharper.Psi.Search.SearchDomainFactory factory);
        public JetBrains.Util.DataStructures.HybridCollection<JetBrains.ReSharper.Psi.IPsiSourceFile> GetSourceFiles() { }
        public virtual System.Xml.XmlNode GetXMLDescriptionSummary(bool inherit) { }
        public virtual System.Xml.XmlNode GetXMLDoc(bool inherit) { }
        public bool HasDeclarationsIn(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
        public bool IsSynthetic() { }
        public virtual bool IsValid() { }
    }
    public class JavaScriptLocalElement : JetBrains.ReSharper.Psi.JavaScript.Impl.DeclaredElements.JavaScriptDeclaredElementBase, JetBrains.ReSharper.Psi.IDeclaredElement, JetBrains.ReSharper.Psi.JavaScript.DeclaredElements.IJavaScriptDeclaredElement, JetBrains.ReSharper.Psi.JavaScript.DeclaredElements.IJavaScriptLocalElement, JetBrains.ReSharper.Psi.JavaScript.DeclaredElements.IJavaScriptTypeOwner
    {
        protected JavaScriptLocalElement(string name, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptScope ownerFunction, JetBrains.ReSharper.Psi.Modules.IPsiModule module, JetBrains.ReSharper.Psi.IPsiServices psiServices, JetBrains.ReSharper.Psi.Tree.ITreeNode declarationNode, int funcDocumentOffset) { }
        public bool HasDynamicName { get; }
        public bool IsLocal { get; }
        public bool IsVariableOrField { get; }
        public override string ShortName { get; }
        public bool CanBeFunction(JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.JavaScriptResolveContext context) { }
        public static JetBrains.ReSharper.Psi.JavaScript.Impl.DeclaredElements.JavaScriptLocalElement Create(string name, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptScope ownerFunction, JetBrains.ReSharper.Psi.Modules.IPsiModule module, JetBrains.ReSharper.Psi.IPsiServices psiServices, JetBrains.ReSharper.Psi.Tree.ITreeNode declarationNode, int funcDocumentOffset) { }
        protected bool Equals(JetBrains.ReSharper.Psi.JavaScript.Impl.DeclaredElements.JavaScriptLocalElement other) { }
        public override bool Equals(object obj) { }
        public override System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Tree.IDeclaration> GetDeclarations() { }
        public override System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Tree.IDeclaration> GetDeclarationsIn(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
        public override JetBrains.ReSharper.Psi.DeclaredElementType GetElementType() { }
        public override int GetHashCode() { }
        public virtual JetBrains.ReSharper.Psi.JavaScript.Resolve.IJavaScriptType GetJsType(JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsDocumentOffsetProvider context) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptScope GetOwnerScope() { }
        public override JetBrains.ReSharper.Psi.Search.ISearchDomain GetSearchDomain(JetBrains.ReSharper.Psi.Search.SearchDomainFactory factory) { }
        public override System.Xml.XmlNode GetXMLDescriptionSummary(bool inherit) { }
        public override System.Xml.XmlNode GetXMLDoc(bool inherit) { }
        public override bool IsValid() { }
    }
    public class JavaScriptParameterElement : JetBrains.ReSharper.Psi.JavaScript.Impl.DeclaredElements.JavaScriptLocalElement, JetBrains.ReSharper.Psi.IDeclaredElement, JetBrains.ReSharper.Psi.JavaScript.DeclaredElements.IJavaScriptDeclaredElement, JetBrains.ReSharper.Psi.JavaScript.DeclaredElements.IJavaScriptLocalElement, JetBrains.ReSharper.Psi.JavaScript.DeclaredElements.IJavaScriptParameter, JetBrains.ReSharper.Psi.JavaScript.DeclaredElements.IJavaScriptTypeOwner
    {
        public JavaScriptParameterElement(string name, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IJsSignatureNode ownerFunction, JetBrains.ReSharper.Psi.Modules.IPsiModule module, JetBrains.ReSharper.Psi.IPsiServices psiServices, JetBrains.ReSharper.Psi.Tree.ITreeNode declarationNode, int paramNumber, int funcDocumentOffset) { }
        public int ParamNumber { get; }
        public bool Equals(JetBrains.ReSharper.Psi.JavaScript.Impl.DeclaredElements.JavaScriptParameterElement other) { }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
        public override JetBrains.ReSharper.Psi.JavaScript.Resolve.IJavaScriptType GetJsType(JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsDocumentOffsetProvider context) { }
    }
    [JetBrains.ReSharper.Psi.PsiSharedComponentAttribute()]
    public class JavaScriptSymbolInfoService : JetBrains.ReSharper.Psi.JavaScript.DeclaredElements.IJavaScriptSymbolInfoService
    {
        public JavaScriptSymbolInfoService(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.JavaScript.Impl.DeclaredElements.IJavaScriptSymbolInfoProvider> symbolInfoProviders) { }
        public bool CanBeFunction(JetBrains.ReSharper.Psi.IDeclaredElement element, JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.JavaScriptResolveContext context) { }
        public JetBrains.ReSharper.Psi.JavaScript.Resolve.FullJavaScriptType GetJsType(JetBrains.ReSharper.Psi.IDeclaredElement element, JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.JavaScriptResolveContext context) { }
        public string GetShortName(JetBrains.ReSharper.Psi.IDeclaredElement element) { }
        public bool HasDynamicName(JetBrains.ReSharper.Psi.IDeclaredElement element) { }
        public bool IsKnown(JetBrains.ReSharper.Psi.IDeclaredElement element) { }
        public bool IsProperty(JetBrains.ReSharper.Psi.IDeclaredElement element) { }
    }
}
namespace JetBrains.ReSharper.Psi.JavaScript.Impl.DeclaredElements.TypeScript
{
    
    public class TsAccessFilter : JetBrains.ReSharper.Psi.Resolve.SimpleSymbolFilter
    {
        public override JetBrains.ReSharper.Psi.Resolve.ResolveErrorType ErrorType { get; }
        public override bool Accepts(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution) { }
    }
    public abstract class TsTypeElementBase : JetBrains.ReSharper.Psi.IDeclaredElement, JetBrains.ReSharper.Psi.JavaScript.DeclaredElements.IJavaScriptDeclaredElement, JetBrains.ReSharper.Psi.JavaScript.DeclaredElements.IJavaScriptTypeOwner, JetBrains.ReSharper.Psi.JavaScript.DeclaredElements.IJsCachedElement, JetBrains.ReSharper.Psi.JavaScript.DeclaredElements.TypeScript.ITsDeclaredElement, JetBrains.ReSharper.Psi.JavaScript.DeclaredElements.TypeScript.ITsMemberElement, JetBrains.ReSharper.Psi.JavaScript.DeclaredElements.TypeScript.ITsModuleMember, JetBrains.ReSharper.Psi.JavaScript.DeclaredElements.TypeScript.ITsTypeElement, JetBrains.ReSharper.Psi.JavaScript.Impl.IJavaScriptSearchDomainOwner
    {
        protected TsTypeElementBase(string name, string parentName, JetBrains.ReSharper.Psi.JavaScript.Services.JavaScriptServices services, JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, int offset, int parentOffset, JetBrains.ReSharper.Psi.JavaScript.Impl.Services.TypeScript.TypeScriptDeclaredElementType elementType, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.TsModifiers modifiers) { }
        public bool CaseSensistiveName { get; }
        public string FullTypeName { get; }
        public bool HasDynamicName { get; }
        public bool IsLocal { get; }
        public bool IsPublic { get; }
        public bool IsVariableOrField { get; }
        public JetBrains.ReSharper.Psi.PsiLanguageType PresentationLanguage { get; }
        public string ShortName { get; }
        public bool CanBeFunction(JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.JavaScriptResolveContext context) { }
        protected bool Equals(JetBrains.ReSharper.Psi.JavaScript.Impl.DeclaredElements.TypeScript.TsTypeElementBase other) { }
        public override bool Equals(object obj) { }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Tree.IDeclaration> GetDeclarations() { }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Tree.IDeclaration> GetDeclarationsIn(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
        public JetBrains.ReSharper.Psi.DeclaredElementType GetElementType() { }
        public override int GetHashCode() { }
        public JetBrains.ReSharper.Psi.JavaScript.Services.JavaScriptServices GetJsServices() { }
        public JetBrains.ReSharper.Psi.JavaScript.Resolve.IJavaScriptType GetJsType(JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsDocumentOffsetProvider context) { }
        public JetBrains.ReSharper.Psi.JavaScript.Resolve.IJavaScriptType GetJsTypeForTypeElement() { }
        public JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetMembers(bool includePrivate) { }
        public JetBrains.ReSharper.Psi.JavaScript.DeclaredElements.TypeScript.ITsTypeElement GetParentElement() { }
        public JetBrains.ReSharper.Psi.JavaScript.Resolve.IJavaScriptType GetParentType() { }
        protected JetBrains.ReSharper.Psi.JavaScript.Resolve.JsPrimitive GetPrimitiveForTypeElement() { }
        public JetBrains.ReSharper.Psi.IPsiServices GetPsiServices() { }
        public JetBrains.ReSharper.Psi.Search.ISearchDomain GetSearchDomain(JetBrains.ReSharper.Psi.Search.SearchDomainFactory factory) { }
        public JetBrains.Util.DataStructures.HybridCollection<JetBrains.ReSharper.Psi.IPsiSourceFile> GetSourceFiles() { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.JavaScript.Caches.IJavaScriptSymbol> GetSymbols() { }
        public System.Xml.XmlNode GetXMLDescriptionSummary(bool inherit) { }
        public System.Xml.XmlNode GetXMLDoc(bool inherit) { }
        public bool HasDeclarationsIn(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
        public bool IsSynthetic() { }
        public bool IsValid() { }
    }
}
namespace JetBrains.ReSharper.Psi.JavaScript.Impl.DocComments
{
    
    public class DocCommentParsed : JetBrains.ReSharper.Psi.JavaScript.DocComments.IJsDocComment
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public System.Collections.Generic.IList<JetBrains.ReSharper.Psi.JavaScript.DocComments.IDocSignature> DocSignatures { get; }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Psi.JavaScript.DocComments.IDocParameter> ParamTypes { get; }
        public static JetBrains.ReSharper.Psi.JavaScript.Impl.DocComments.DocCommentParsed ParseDocCommentPsi([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xml.Tree.IXmlFile file, JetBrains.ReSharper.Psi.JavaScript.Tree.IJsSignatureNode functionExpression) { }
    }
    public class DocParameter : JetBrains.ReSharper.Psi.JavaScript.DocComments.IDocParameter
    {
        public DocParameter([JetBrains.Annotations.NotNullAttribute()] string name, int indexInTheSignature) { }
        public DocParameter([JetBrains.Annotations.NotNullAttribute()] string name, string description, string typeName, int indexInTheSignature) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Psi.JavaScript.DocComments.IDocType DocType { get; }
        public int IndexInTheSignature { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public string Name { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public string SummaryText { get; set; }
        public JetBrains.ReSharper.Psi.JavaScript.DeclaredElements.IJavaScriptLocalElement GetDeclaredElement(JetBrains.ReSharper.Psi.JavaScript.Tree.IJsSignatureNode signatureNode, JetBrains.ReSharper.Psi.JavaScript.DocComments.IDocSignature signature) { }
    }
    public class DocSignature : JetBrains.ReSharper.Psi.JavaScript.DocComments.IBasicDocSignature, JetBrains.ReSharper.Psi.JavaScript.DocComments.IDocSignature
    {
        public DocSignature([JetBrains.Annotations.NotNullAttribute()] string summaryText) { }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Psi.JavaScript.DocComments.IDocParameter> DocParameters { get; }
        public JetBrains.ReSharper.Psi.JavaScript.DocComments.IDocType DocType { get; set; }
        public bool HasDocSignature { get; }
        public string SummaryText { get; set; }
        public void AddParameterDescription(int indexInTheSignature, string docParameterName, string description, string typeName) { }
        public void AppendText(string text) { }
        public JetBrains.UI.RichText.RichTextBlock GetDescription() { }
        public JetBrains.UI.RichText.RichTextBlock GetObsoleteDescription() { }
        public JetBrains.UI.RichText.RichTextBlock[] GetParamDescriptions() { }
        public bool IsObsolete() { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ReSharper.Psi.JavaScript.Impl.DocComments.DocSignature SetParameters([JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IList<string> names) { }
    }
    public class DocType : JetBrains.ReSharper.Psi.JavaScript.DocComments.IDocType
    {
        public DocType(string typeName) { }
        public string TypeName { get; }
        public JetBrains.ReSharper.Psi.JavaScript.Resolve.IJavaScriptType GetJsType() { }
    }
    public class JavaScriptDocCommentXmlPsi : JetBrains.ReSharper.Psi.Xml.XmlDocComments.DocCommentXmlPsiBase<JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptDocCommentBlockNode>
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ReSharper.Psi.JavaScript.Impl.DocComments.DocCommentParsed DocCommentParsed { get; }
        protected override string DocCommentStartText { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Psi.JavaScript.Tree.IJsFunctionLike FunctionExpression { get; }
        public JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag AddReferenceNodeAfter(JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag xmlTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag anchorXmlTag) { }
        public JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag AddReferenceNodeBefore(JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag xmlTag, JetBrains.ReSharper.Psi.Xml.Tree.IXmlTag anchorXmlTag) { }
        public static JetBrains.ReSharper.Psi.JavaScript.Impl.DocComments.JavaScriptDocCommentXmlPsi BuildPsi([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptDocCommentBlockNode block) { }
        protected override System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Tree.ITreeNode> DocCommentNodes() { }
        protected override void InvalidateCachedData() { }
        protected override System.Collections.Generic.IList<string> OrderedDocCommentTags() { }
        public override void SubTreeChanged() { }
    }
    public sealed class JavaScriptParameterFromDocComment : JetBrains.ReSharper.Psi.IDeclaredElement, JetBrains.ReSharper.Psi.JavaScript.DeclaredElements.IJavaScriptDeclaredElement, JetBrains.ReSharper.Psi.JavaScript.DeclaredElements.IJavaScriptLocalElement, JetBrains.ReSharper.Psi.JavaScript.DeclaredElements.IJavaScriptTypeOwner
    {
        public JavaScriptParameterFromDocComment(JetBrains.ReSharper.Psi.JavaScript.Tree.IJsSignatureNode functionExpression, JetBrains.ReSharper.Psi.JavaScript.Impl.DocComments.DocParameter docParameter, int indexInTheSignature) { }
        public bool CaseSensistiveName { get; }
        public bool HasDynamicName { get; }
        public bool IsLocal { get; }
        public bool IsVariableOrField { get; }
        public JetBrains.ReSharper.Psi.PsiLanguageType PresentationLanguage { get; }
        public string ShortName { get; }
        public bool CanBeFunction(JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.JavaScriptResolveContext context) { }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Tree.IDeclaration> GetDeclarations() { }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Tree.IDeclaration> GetDeclarationsIn(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
        public JetBrains.ReSharper.Psi.DeclaredElementType GetElementType() { }
        public JetBrains.ReSharper.Psi.JavaScript.Resolve.IJavaScriptType GetJsType(JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsDocumentOffsetProvider context) { }
        public JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptScope GetOwnerScope() { }
        public JetBrains.ReSharper.Psi.IPsiServices GetPsiServices() { }
        public JetBrains.Util.DataStructures.HybridCollection<JetBrains.ReSharper.Psi.IPsiSourceFile> GetSourceFiles() { }
        public System.Xml.XmlNode GetXMLDescriptionSummary(bool inherit) { }
        public System.Xml.XmlNode GetXMLDoc(bool inherit) { }
        public bool HasDeclarationsIn(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
        public bool IsSynthetic() { }
        public bool IsValid() { }
    }
    [JetBrains.ReSharper.Psi.LanguageDefinitionAttribute("JS_XMLDOC")]
    public class JavaScriptXmlDocLanguage : JetBrains.ReSharper.Psi.Xml.XmlDocComments.XmlDocLanguage
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static readonly JetBrains.ReSharper.Psi.JavaScript.Impl.DocComments.JavaScriptXmlDocLanguage Instance;
        public const string Name = "JS_XMLDOC";
        protected JavaScriptXmlDocLanguage() { }
    }
}
namespace JetBrains.ReSharper.Psi.JavaScript.Impl.Finder
{
    
    public enum FilterResult
    {
        DontKnow = 0,
        Exclude = 1,
        Include = 2,
    }
    public class FindResultJavaScriptSymbol : JetBrains.ReSharper.Psi.Search.FindResult
    {
        public FindResultJavaScriptSymbol([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Caches.IJavaScriptSymbol symbol) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ReSharper.Psi.JavaScript.Caches.IJavaScriptSymbol Symbol { get; }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
    }
    public interface ISourceFileFilterForDeclaredElementSearch
    {
        JetBrains.ReSharper.Psi.JavaScript.Impl.Finder.FilterResult Filter(JetBrains.ReSharper.Psi.IDeclaredElement element, JetBrains.ReSharper.Psi.IPsiSourceFile file, System.Type language);
    }
    public class JavaScriptReferenceSearcher<TLanguage> : JetBrains.ReSharper.Psi.ExtensionsAPI.IDomainSpecificSearcher
        where TLanguage : JetBrains.ReSharper.Psi.PsiLanguageType
    {
        public JavaScriptReferenceSearcher(JetBrains.ReSharper.Psi.ExtensionsAPI.IDomainSpecificSearcherFactory searchWordsProvider, System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.IDeclaredElement> elements, bool findCandidates, bool searchForLateBound, JetBrains.ReSharper.Psi.JavaScript.DeclaredElements.IJavaScriptSymbolInfoService infoService, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.JavaScript.Impl.Finder.ISourceFileFilterForDeclaredElementSearch> filters) { }
        public bool ProcessElement<TResult>(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.Search.IFindResultConsumer<TResult> consumer, JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.JavaScriptResolveContext context, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IDeclaredElement> filteredElements) { }
        public bool ProcessElement<TResult>(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.Search.IFindResultConsumer<TResult> consumer) { }
        public bool ProcessProjectItem<TResult>(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, JetBrains.ReSharper.Psi.Search.IFindResultConsumer<TResult> consumer) { }
    }
    [JetBrains.ReSharper.Psi.PsiSharedComponentAttribute()]
    public class JavaScriptSearcherFactory : JetBrains.ReSharper.Psi.JavaScript.Impl.Finder.JavaScriptSearcherFactoryBase<JetBrains.ReSharper.Psi.JavaScript.LanguageImpl.JavaScriptLanguage>
    {
        public JavaScriptSearcherFactory(JetBrains.ReSharper.Psi.JavaScript.DeclaredElements.IJavaScriptSymbolInfoService infoService, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.JavaScript.Impl.Finder.ISourceFileFilterForDeclaredElementSearch> filters) { }
    }
    public class JavaScriptSearcherFactoryBase<TLanguage> : JetBrains.ReSharper.Psi.ExtensionsAPI.IDomainSpecificSearcherFactory
        where TLanguage : JetBrains.ReSharper.Psi.PsiLanguageType
    {
        public JavaScriptSearcherFactoryBase(JetBrains.ReSharper.Psi.JavaScript.DeclaredElements.IJavaScriptSymbolInfoService infoService, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.JavaScript.Impl.Finder.ISourceFileFilterForDeclaredElementSearch> filters) { }
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
    public class JsReferenceSearchSourceFileProcessor<TResult> : JetBrains.ReSharper.Psi.ExtensionsAPI.Finder.ReferenceSearchSourceFileProcessor<TResult>
    
    {
        public JsReferenceSearchSourceFileProcessor(JetBrains.ReSharper.Psi.Tree.ITreeNode treeNode, bool findCandidates, JetBrains.ReSharper.Psi.Search.IFindResultConsumer<TResult> resultConsumer, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IDeclaredElement> elements, System.Collections.Generic.ICollection<string> wordsInText, System.Collections.Generic.ICollection<string> referenceNames, JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.JavaScriptResolveContext context, JetBrains.Util.OneToListMap<string, JetBrains.ReSharper.Psi.IDeclaredElement> propertiesByName) { }
        protected override JetBrains.ReSharper.Psi.Resolve.IResolveResult Resolve(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
    }
    [JetBrains.ReSharper.Psi.PsiSharedComponentAttribute()]
    public class JsSourceFileFilterForDeclaredElementSearch : JetBrains.ReSharper.Psi.JavaScript.Impl.Finder.ISourceFileFilterForDeclaredElementSearch
    {
        public JetBrains.ReSharper.Psi.JavaScript.Impl.Finder.FilterResult Filter(JetBrains.ReSharper.Psi.IDeclaredElement element, JetBrains.ReSharper.Psi.IPsiSourceFile file, System.Type language) { }
    }
}
namespace JetBrains.ReSharper.Psi.JavaScript.Impl.Framework.MicrosoftAjax
{
    
    public class JavaScriptNamespaceElementType : JetBrains.ReSharper.Psi.JavaScript.Impl.Services.JavaScriptDeclaredElementType
    {
        public static readonly JetBrains.ReSharper.Psi.JavaScript.Impl.Framework.MicrosoftAjax.JavaScriptNamespaceElementType Namespace;
    }
    public sealed class MicrosoftAjaxNamespaceReference : JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.CheckedReferenceBase<JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptLiteralExpression>, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IQualifiableReferenceBase, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IQualifiableReferenceWithGlobalSymbolTable, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IReferenceWithGlobalSymbolTable, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IReferenceWithQualifier, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.Util.IUserDataHolder
    {
        public MicrosoftAjaxNamespaceReference(JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptLiteralExpression owner, int localOffset, string name) { }
        public bool IsQualified { get; }
        public override JetBrains.ReSharper.Psi.Resolve.IReference BindTo(JetBrains.ReSharper.Psi.IDeclaredElement element, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution) { }
        public override JetBrains.ReSharper.Psi.Resolve.IReference BindTo(JetBrains.ReSharper.Psi.IDeclaredElement element) { }
        public override JetBrains.ReSharper.Psi.Resolve.IAccessContext GetAccessContext() { }
        public override string GetName() { }
        public JetBrains.ReSharper.Psi.Resolve.IQualifier GetQualifier() { }
        public override JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetReferenceSymbolTable(bool useReferenceName) { }
        public override JetBrains.ReSharper.Psi.Resolve.ISymbolFilter[] GetSymbolFilters() { }
        public override JetBrains.ReSharper.Psi.TreeTextRange GetTreeTextRange() { }
        public override bool IsValid() { }
        public JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.ResolveResultWithInfo Resolve(JetBrains.ReSharper.Psi.Resolve.ISymbolTable symbolTable, JetBrains.ReSharper.Psi.Resolve.IAccessContext context) { }
        public override JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.ResolveResultWithInfo ResolveWithoutCache() { }
    }
}
namespace JetBrains.ReSharper.Psi.JavaScript.Impl.Framework.Standard
{
    
    [JetBrains.ReSharper.Psi.Modules.PsiModuleFactoryAttribute()]
    public class JavaScriptExternalModulesCoreFactory : JetBrains.ReSharper.Psi.Modules.IPsiModuleFactory
    {
        public JavaScriptExternalModulesCoreFactory(JetBrains.DocumentModel.IInMemoryDocumentFactory documentsFactory, JetBrains.ProjectModel.ISolution solution) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Modules.IPsiModule> Modules { get; }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class JavaScriptLibraryTypesProvider
    {
        public static bool CheckNamespacedReference(JetBrains.ReSharper.Psi.JavaScript.Tree.IReferenceExpression referenceExpression, JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsLocalElementResolver context, bool resolveThroughLocalVars, bool useResolve, params string[] names) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class StandartObjectLiteralExpectedTypeProvider : JetBrains.ReSharper.Psi.JavaScript.LanguageImpl.IObjectLiteralExpectedTypeProvider
    {
        public JetBrains.ReSharper.Psi.JavaScript.Resolve.IJavaScriptType GetJsType(JetBrains.ReSharper.Psi.JavaScript.Tree.IObjectLiteral objectLiteral, JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsLocalElementResolver context) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Resolve.ISymbolFilter> GetPropertyFilters(JetBrains.ReSharper.Psi.JavaScript.Tree.IObjectLiteral objectLiteral, JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.JavaScriptResolveContext resolveContext) { }
    }
    [System.FlagsAttribute()]
    public enum StandartSymbolFlags : ushort
    {
        Function = 1,
        Variable = 2,
        Assignment = 4,
        ObjectProperty = 8,
        IndexedProperty = 16,
        InitializerIsFunction = 32,
        ObjectPropertyGetter = 64,
        ObjectPropertySetter = 128,
        FormalParameter = 256,
        TopLevel = 512,
        IsFrameworkDeclaration = 1024,
        IsGlobalDeclaration = 2048,
        HasDeclarationMask = 459,
        AllDeclaratiosMask = 479,
    }
}
namespace JetBrains.ReSharper.Psi.JavaScript.Impl
{
    
    public class static JavaScriptReferenceBindingUtil
    {
        public static TReferenceType BindReferenceTo<TReferenceType>([JetBrains.Annotations.NotNullAttribute()] TReferenceType reference, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IDeclaredElement element, System.Func<TReferenceType, JetBrains.ReSharper.Psi.IDeclaredElement, TReferenceType> modification)
            where TReferenceType :  class, JetBrains.ReSharper.Psi.Resolve.IReference { }
        public static bool CheckResolvedTo(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.IDeclaredElement target) { }
    }
}
namespace JetBrains.ReSharper.Psi.JavaScript.Impl.PsiModules
{
    
    public class FrameworkSourceFile : JetBrains.Util.UserDataHolder, JetBrains.ReSharper.Psi.IPsiSourceFile, JetBrains.Util.IUserDataHolder
    {
        public FrameworkSourceFile(JetBrains.DocumentModel.IInMemoryDocumentFactory documentFactory, JetBrains.ReSharper.Psi.Modules.IPsiModule psiModule, string name) { }
        public string DisplayName { get; }
        public JetBrains.DocumentModel.IDocument Document { get; }
        public System.Nullable<int> InMemoryModificationStamp { get; }
        public JetBrains.ProjectModel.ProjectFileType LanguageType { get; }
        public System.DateTime LastWriteTimeUtc { get; }
        public string Name { get; }
        public JetBrains.ReSharper.Psi.PsiLanguageType PrimaryPsiLanguage { get; }
        public JetBrains.ReSharper.Psi.IPsiSourceFileProperties Properties { get; }
        public JetBrains.ReSharper.Psi.Modules.IPsiModule PsiModule { get; }
        public JetBrains.ReSharper.Psi.IPsiSourceFileStorage PsiStorage { get; }
        public JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext ResolveContext { get; }
        public string GetPersistentID() { }
        public bool IsValid() { }
        public override string ToString() { }
    }
    public class FrameworkSourceFileProperties : JetBrains.ReSharper.Psi.IPsiSourceFileProperties
    {
        public static readonly JetBrains.ReSharper.Psi.IPsiSourceFileProperties Instance;
        public bool IsGeneratedFile { get; }
        public bool IsICacheParticipant { get; }
        public bool IsNonUserFile { get; }
        public bool ProvidesCodeModel { get; }
        public bool ShouldBuildPsi { get; }
        public string GetDefaultNamespace() { }
        public System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.PreProcessingDirective> GetDefines() { }
        public System.Collections.Generic.IEnumerable<string> GetPreImportedNamespaces() { }
    }
    public class JavaScriptExternalModule : JetBrains.ReSharper.Psi.Modules.IPsiModule
    {
        public JavaScriptExternalModule(JetBrains.ProjectModel.ISolution solution, string moduleName, string[] sourceFilesFromResources, JetBrains.DocumentModel.IInMemoryDocumentFactory documentFactory) { }
        public JetBrains.ProjectModel.IModule ContainingProjectModule { get; }
        public string DisplayName { get; }
        public string Name { get; }
        public JetBrains.ProjectModel.ProjectFileType ProjectFileType { get; }
        public JetBrains.ReSharper.Psi.PsiLanguageType PsiLanguage { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IPsiSourceFile> SourceFiles { get; }
        public System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.PreProcessingDirective> GetAllDefines() { }
        public string GetPersistentID() { }
        public JetBrains.ReSharper.Psi.IPsiServices GetPsiServices() { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Modules.IPsiModuleReference> GetReferences(JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext moduleReferenceResolveContext) { }
        public JetBrains.ProjectModel.ISolution GetSolution() { }
        public bool IsValid() { }
    }
    public abstract class JavaScriptExternalModulesReferencesProvider : JetBrains.Application.IChangeProvider, JetBrains.ReSharper.Psi.Modules.IProjectPsiModuleProviderFilter
    {
        protected JavaScriptExternalModulesReferencesProvider(JetBrains.ProjectModel.impl.ViewableProjectsCollection projects, JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.ChangeManager changeManager, JetBrains.ProjectModel.ISolution solution, JetBrains.Application.IShellLocks locks) { }
        protected JetBrains.ProjectModel.ISolution Solution { get; }
        protected abstract JetBrains.ReSharper.Psi.Modules.IPsiModule CreatePsiModule();
        public object Execute(JetBrains.Application.IChangeMap changeMap) { }
        protected abstract bool Matches(JetBrains.ProjectModel.IProject project);
        public JetBrains.Util.JetTuple<JetBrains.ReSharper.Psi.Modules.IProjectPsiModuleHandler, JetBrains.ReSharper.Psi.Modules.IPsiModuleDecorator> OverrideHandler(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ProjectModel.IProject project, JetBrains.ReSharper.Psi.Modules.IProjectPsiModuleHandler handler) { }
    }
}
namespace JetBrains.ReSharper.Psi.JavaScript.Impl.PsiModules.ReferencedFilesSupport
{
    
    public interface ILibraryFile
    {
        string FileName { get; }
        System.Collections.Generic.IEnumerable<JetBrains.Util.FileSystemPath> Locations { get; }
    }
    public interface ILibraryFiles
    {
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.JavaScript.Impl.PsiModules.ReferencedFilesSupport.ILibraryFile> LibraryFiles { get; }
    }
    [JetBrains.ReSharper.Psi.PsiComponentAttribute()]
    public class JavaScriptDependentFilesBuilder : JetBrains.ReSharper.Psi.Modules.ExternalFileModules.IDependentFilesBuilder
    {
        public JetBrains.ReSharper.Psi.Modules.ExternalFileModules.FileDependenciesPerFile Build(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
    }
    [JetBrains.ReSharper.Psi.PsiComponentAttribute()]
    public class JavaScriptDependentFilesCache : JetBrains.ReSharper.Psi.Modules.ExternalFileModules.DependentFilesCacheBase
    {
        public JavaScriptDependentFilesCache(JetBrains.DataFlow.Lifetime lifetime, JetBrains.DataFlow.IViewable<JetBrains.ReSharper.Psi.JavaScript.Impl.PsiModules.ReferencedFilesSupport.ILibraryFiles> libraryFiles, JetBrains.ReSharper.Psi.JavaScript.Impl.PsiModules.ReferencedFilesSupport.JavaScriptDependentFilesModuleFactory dependentFilesModuleFactory, JetBrains.ReSharper.Psi.JavaScript.Impl.PsiModules.ReferencedFilesSupport.JavaScriptDependentFilesBuilder builder, JetBrains.Application.IShellLocks locks, JetBrains.ReSharper.Psi.IPsiConfiguration configuration, JetBrains.ReSharper.Psi.Caches.IPersistentIndexManager persistentIndexManager) { }
        protected override bool Accepts(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
        public void AddLibFilesIfNeeded() { }
        protected override void BeforeAttach() { }
        protected override void FileAdded(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
        protected override void FileRemoved(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
    }
    [JetBrains.ProjectModel.SolutionInstanceComponentAttribute()]
    public class JavaScriptDependentFilesModuleFactory : JetBrains.ReSharper.Psi.Modules.ExternalFileModules.DependentFilesModuleFactory
    {
        public JavaScriptDependentFilesModuleFactory(JetBrains.ProjectModel.Tasks.ISolutionLoadTasksScheduler scheduler, JetBrains.ProjectModel.IProjectFileExtensions extensions, JetBrains.ReSharper.Psi.PsiProjectFileTypeCoordinator coordinator, JetBrains.Application.IShellLocks locks, JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.ChangeManager changeManager, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Psi.IPsiConfiguration configuration, JetBrains.ReSharper.Psi.Modules.ExternalFileModules.ContentFilesModuleFactory contentFilesModule) { }
        protected override string FileName { get; }
        protected override JetBrains.ReSharper.Psi.IPsiSourceFileProperties CreateProperties() { }
        protected override void HandleAddFirstReference(JetBrains.Util.FileSystemPath path, JetBrains.ReSharper.Psi.Modules.PsiModuleChangeBuilder builder) { }
        protected override void HandleRemoveLastReference(JetBrains.Util.FileSystemPath path, JetBrains.ReSharper.Psi.Modules.PsiModuleChangeBuilder builder) { }
        public override void OnProjectFileChanged(JetBrains.ProjectModel.IProjectFile projectFile, JetBrains.ReSharper.Psi.Modules.PsiModuleChange.ChangeType changeType, JetBrains.ReSharper.Psi.Modules.PsiModuleChangeBuilder builder, JetBrains.Util.FileSystemPath oldLocation) { }
        public bool TryGetSourceFileByPath(JetBrains.Util.FileSystemPath path, out JetBrains.ReSharper.Psi.IPsiSourceFile psiSourceFile) { }
    }
}
namespace JetBrains.ReSharper.Psi.JavaScript.Impl.PsiModules.TypeScript
{
    
    [JetBrains.ReSharper.Psi.PsiComponentAttribute()]
    public class LibDTsFile : JetBrains.ReSharper.Psi.JavaScript.Impl.PsiModules.ReferencedFilesSupport.ILibraryFiles
    {
        public virtual System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.JavaScript.Impl.PsiModules.ReferencedFilesSupport.ILibraryFile> LibraryFiles { get; }
    }
}
namespace JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve
{
    
    public class ComplexCalculationIdentifier : JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.ICalculationIdentifier
    {
        public ComplexCalculationIdentifier(object ident, string id, bool flag) { }
        public override bool Equals(object obj) { }
        public string GetDebugString() { }
        public override int GetHashCode() { }
        public override string ToString() { }
    }
    public class DeclarationReference : JetBrains.Util.UserDataHolder, JetBrains.ReSharper.Psi.JavaScript.Resolve.IDeclarationReference, JetBrains.ReSharper.Psi.JavaScript.Resolve.IJavaScriptCompleteableReference, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.Util.IUserDataHolder
    {
        public DeclarationReference(JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.IDeclarationReferenceOwner owner) { }
        public JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.ResolveResultWithInfo CurrentResolveResult { get; set; }
        public bool HasMultipleNames { get; }
        public JetBrains.ReSharper.Psi.Resolve.IReference BindTo(JetBrains.ReSharper.Psi.IDeclaredElement element) { }
        public JetBrains.ReSharper.Psi.Resolve.IReference BindTo(JetBrains.ReSharper.Psi.IDeclaredElement element, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution) { }
        public JetBrains.ReSharper.Psi.Resolve.IAccessContext GetAccessContext() { }
        public System.Collections.Generic.IEnumerable<string> GetAllNames() { }
        public JetBrains.ReSharper.Psi.JavaScript.Resolve.IJavaScriptType GetJsType(JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsLocalElementResolver context) { }
        public string GetName() { }
        public JetBrains.ReSharper.Psi.JavaScript.Resolve.FullJavaScriptType GetParentJsType(JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.JavaScriptResolveContext resolveContext) { }
        public JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetReferenceSymbolTable(bool useReferenceName) { }
        public JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetSymbolTableForCompletion(JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.JavaScriptResolveContext resolveContext, bool allProperties = False) { }
        public JetBrains.ReSharper.Psi.Tree.ITreeNode GetTreeNode() { }
        public JetBrains.ReSharper.Psi.TreeTextRange GetTreeTextRange() { }
        public bool IsValid() { }
        public JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.ResolveResultWithInfo Resolve() { }
    }
    public interface ICalculationIdentifier
    {
        string GetDebugString();
    }
    public interface IDeclarationReferenceOwner
    {
        [JetBrains.Annotations.NotNullAttribute()]
        string DeclaredName { get; }
        bool IsDynamic { get; }
        JetBrains.ReSharper.Psi.Tree.ITreeNode OwnerTreeNode { get; }
        JetBrains.ReSharper.Psi.JavaScript.Resolve.IDeclarationReference Reference { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.JavaScript.DeclaredElements.IJavaScriptTypeOwner GetDeclaredElement(JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsDocumentOffsetProvider context);
        JetBrains.ReSharper.Psi.TreeTextRange GetNameRange();
        JetBrains.ReSharper.Psi.JavaScript.Resolve.FullJavaScriptType GetParentJsType(JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.JavaScriptResolveContext resolveContext);
        JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetSymbolTableForCompletion(JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.JavaScriptResolveContext resolveContext, bool allProperties = False);
        void SetName(string name);
    }
    public interface IJsPrimitiveTypeConsumer
    {
        void Add(JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsPrimitiveType primitiveType);
    }
    public interface IReferenceExpressionReferenceOwner : JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        bool IsDynamic { get; }
        bool IsQualified { get; }
        JetBrains.ReSharper.Psi.Tree.ITreeNode NameTreeNode { get; }
        int OffsetFromNameNode { get; }
        JetBrains.ReSharper.Psi.JavaScript.Resolve.IReferenceExpressionReference BindingModification(JetBrains.ReSharper.Psi.JavaScript.Resolve.IReferenceExpressionReference reference, JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, string name);
        JetBrains.ReSharper.Psi.JavaScript.Resolve.IJavaScriptType GetQualifierJsType(JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsLocalElementResolver context);
        int GetReferenceExpressionReferenceDocumentOffset(JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsLocalElementResolver context);
        string GetReferenceExpressionReferenceName();
        JetBrains.ReSharper.Psi.TreeTextRange GetReferenceExpressionReferenceTreeRange();
    }
    public class JavaScriptResolveContext : JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsDocumentOffsetProvider, JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsLocalElementResolver, JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsResolveContext
    {
        protected readonly JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.JavaScriptResolveContext myBaseContext;
        protected JavaScriptResolveContext(JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.JavaScriptResolveContext baseContext, JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.ICalculationIdentifier ident, JetBrains.ReSharper.Psi.JavaScript.Services.JavaScriptServices services, JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, JetBrains.ReSharper.Psi.PsiLanguageType language) { }
        public JetBrains.ReSharper.Psi.Dependencies.DependencyStore DependencyStore { get; }
        protected int Depth { get; }
        protected System.Collections.Generic.Dictionary<JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.ICalculationIdentifier, object> Holder { get; }
        public JetBrains.ReSharper.Psi.JavaScript.Services.JavaScriptServices JavaScriptServices { get; set; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Psi.IPsiSourceFile SourceFile { get; }
        public JetBrains.ReSharper.Psi.JavaScript.Caches.IJavaScriptTypeFileCache TypeFileCache { get; }
        public JetBrains.ReSharper.Psi.JavaScript.Impl.Services.JavaScriptSourceFilesVisibilityFilter VisibilityFilter { get; }
        public T CalculateWithCache<T>(JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.ICalculationIdentifier ident, T defaultValue, [JetBrains.Annotations.InstantHandleAttribute()] System.Func<JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.JavaScriptResolveContext, T> getResult) { }
        public bool ChainPropertyReferences() { }
        protected virtual JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.JavaScriptResolveContext CreateChildContext(JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.ICalculationIdentifier ident) { }
        public static JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.JavaScriptResolveContext CreateInitialContext(JetBrains.ReSharper.Psi.JavaScript.Services.JavaScriptServices services, JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
        public static JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.JavaScriptResolveContext CreateInitialContext(JetBrains.ReSharper.Psi.JavaScript.Services.JavaScriptServices services, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.PsiLanguageType language) { }
        public static JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.JavaScriptResolveContext CreateInitialContext(JetBrains.ReSharper.Psi.JavaScript.Services.JavaScriptServices services, JetBrains.ReSharper.Psi.JavaScript.Impl.Services.JavaScriptSourceFilesVisibilityFilter filter) { }
        [System.Diagnostics.ConditionalAttribute("JET_MODE_ASSERT")]
        public virtual void DecreaseDebugDepth() { }
        public bool FullResolveForDynamicReferences() { }
        public int GetDocumentStartOffset(JetBrains.ReSharper.Psi.Tree.ITreeNode node) { }
        public int GetDocumentStartOffset(JetBrains.ReSharper.Psi.Tree.ITreeNode node, JetBrains.ReSharper.Psi.TreeTextRange range) { }
        public JetBrains.ReSharper.Psi.IDeclaredElement GetResolvedElement(JetBrains.ReSharper.Psi.JavaScript.Resolve.IReferenceExpressionReference reference, bool returnDynamicProperties) { }
        [System.Diagnostics.ConditionalAttribute("JET_MODE_ASSERT")]
        public virtual void IncreaseDebugDepth() { }
        [System.Diagnostics.ConditionalAttribute("JET_MODE_ASSERT")]
        public virtual void OutputDebugInfo([JetBrains.Annotations.InstantHandleAttribute()] System.Func<string> message) { }
        [System.Diagnostics.ConditionalAttribute("JET_MODE_ASSERT")]
        public virtual void OutputDebugInfo(string message, params object[] args) { }
        [System.Diagnostics.ConditionalAttribute("JET_MODE_ASSERT")]
        protected virtual void OutputDebugInfo(string message, JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.ICalculationIdentifier ident) { }
        [System.Diagnostics.ConditionalAttribute("JET_MODE_ASSERT")]
        protected virtual void OutputDebugInfo(string message, JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.ICalculationIdentifier ident, object result) { }
        public bool SmartCache() { }
        public bool StrongTyped() { }
        public override string ToString() { }
    }
    public enum JsQualifierKind
    {
        General = 0,
    }
    public class static JsResolveImplUtil
    {
        public static int FindOffsetToFilterOut(JetBrains.ReSharper.Psi.Tree.ITreeNode nameTreeNode, int offsetFromNameNode, bool isQualified) { }
        public static bool ShouldAddElementToDeclaredElementList(JetBrains.ReSharper.Psi.IDeclaredElement elementToAdd, bool sortFiles, System.Collections.Generic.IList<JetBrains.ReSharper.Psi.IDeclaredElement> list, out JetBrains.ReSharper.Psi.IDeclaredElement removeThisElementBeforeAdding) { }
    }
    public class JsSymbolTableMode : JetBrains.ReSharper.Psi.Resolve.SymbolTableMode
    {
        public static readonly JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.JsSymbolTableMode AllSymbols;
        public static readonly JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.JsSymbolTableMode ObjectProperties;
        public bool SmartProperties { get; }
        public override bool Accepts(JetBrains.ReSharper.Psi.Resolve.SymbolTableMode mode) { }
    }
    public class JsTypeExpandingContext : JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.IJsPrimitiveTypeConsumer
    {
        public JsTypeExpandingContext(JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.JavaScriptResolveContext context, JetBrains.ReSharper.Psi.Resolve.ResolveErrorType initialStatus, bool strongTyped) { }
        public bool AllowGlobalSymbols { get; set; }
        public JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.JavaScriptResolveContext Context { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsFinalPrimitiveType> Results { get; }
        public void Add(JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsPrimitiveType primitiveType) { }
        public void AddIfNoExists(JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsPrimitiveType primitive, bool includeInStatusCalculation = False) { }
        public void AddRange(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsPrimitiveType> primitiveTypes) { }
        public void AddToResults(JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsFinalPrimitiveType type) { }
        public void AddToResults<T>(System.Collections.Generic.IEnumerable<T> type)
            where T :  class, JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsFinalPrimitiveType { }
        public void ChangeStatus(JetBrains.ReSharper.Psi.Resolve.ResolveErrorType newStatus) { }
        public bool ContainedInProcessed(JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsPrimitiveType type) { }
        public JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsPrimitiveType Dequeue() { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsPrimitiveType> EnumerateQueue() { }
        public JetBrains.ReSharper.Psi.JavaScript.Resolve.FullJavaScriptType Expand(bool includeExpectedTypes, bool shortCut, bool addStandardTypes) { }
        public static JetBrains.ReSharper.Psi.JavaScript.Resolve.FullJavaScriptType Expand(System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsPrimitiveType> primitives, JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.JavaScriptResolveContext context, bool strongTyped, bool includeExpectedTypes = False, bool shortCut = False, bool addStandardTypes = True, JetBrains.ReSharper.Psi.Resolve.ResolveErrorType initialStatus = null) { }
        public bool IsEmpty() { }
        public void RemoveFromResults(JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsFinalPrimitiveType type) { }
        public void SwitchToDynamicTyping() { }
    }
    public class NodeCalculationIdentifier : JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.ICalculationIdentifier
    {
        public NodeCalculationIdentifier(JetBrains.ReSharper.Psi.Tree.ITreeNode ident, bool useAssignments) { }
        public override bool Equals(object obj) { }
        public string GetDebugString() { }
        public override int GetHashCode() { }
    }
    public class ReferenceExpressionReference : JetBrains.Util.UserDataHolder, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IQualifiableReferenceBase, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IReferenceWithGlobalSymbolTable, JetBrains.ReSharper.Psi.JavaScript.Resolve.IJavaScriptCompleteableReference, JetBrains.ReSharper.Psi.JavaScript.Resolve.IReferenceExpressionReference, JetBrains.ReSharper.Psi.JavaScript.Resolve.IReferenceWithContext, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.Util.IUserDataHolder
    {
        public ReferenceExpressionReference(JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.IReferenceExpressionReferenceOwner owner) { }
        public JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.ResolveResultWithInfo CurrentResolveResult { get; set; }
        public bool HasMultipleNames { get; }
        public bool IsDynamic { get; }
        public bool IsQualified { get; }
        public JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.IReferenceExpressionReferenceOwner Owner { get; }
        public JetBrains.ReSharper.Psi.Resolve.IReference BindTo(JetBrains.ReSharper.Psi.IDeclaredElement element) { }
        public JetBrains.ReSharper.Psi.Resolve.IReference BindTo(JetBrains.ReSharper.Psi.IDeclaredElement element, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution) { }
        public JetBrains.ReSharper.Psi.Resolve.IAccessContext GetAccessContext() { }
        public System.Collections.Generic.IEnumerable<string> GetAllNames() { }
        public JetBrains.ReSharper.Psi.JavaScript.Resolve.IJavaScriptType GetJsType(JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsLocalElementResolver context) { }
        public string GetName() { }
        public JetBrains.ReSharper.Psi.JavaScript.Resolve.FullJavaScriptType GetParentJsType(JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.JavaScriptResolveContext resolveContext) { }
        public JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetReferenceSymbolTable(bool useReferenceName) { }
        public JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetSymbolTableForCompletion(JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.JavaScriptResolveContext resolveContext, bool allProperties) { }
        public JetBrains.ReSharper.Psi.Tree.ITreeNode GetTreeNode() { }
        public JetBrains.ReSharper.Psi.TreeTextRange GetTreeTextRange() { }
        public bool IsValid() { }
        public JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.ResolveResultWithInfo QuickResolve(bool returnDynamicProperties) { }
        public JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.ResolveResultWithInfo Resolve() { }
        public JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.ResolveResultWithInfo Resolve(JetBrains.ReSharper.Psi.Resolve.ISymbolTable symbolTable, JetBrains.ReSharper.Psi.Resolve.IAccessContext context) { }
        public JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.ResolveResultWithInfo Resolve(JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.JavaScriptResolveContext context) { }
        public JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.ResolveResultWithInfo Resolve(JetBrains.ReSharper.Psi.Resolve.ISymbolTable symbolTable, JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.JavaScriptResolveContext context) { }
        public JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.ResolveResultWithInfo ResolveWithoutCache() { }
    }
    public class SimpleCalculationIdentifier : JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.ICalculationIdentifier
    {
        protected readonly object myIdent;
        public SimpleCalculationIdentifier(object ident) { }
        public override bool Equals(object obj) { }
        public virtual string GetDebugString() { }
        public override int GetHashCode() { }
        public override string ToString() { }
    }
}
namespace JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.TypeScript
{
    
    public interface ITsType : JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsFinalPrimitiveType, JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsPrimitiveType
    {
        JetBrains.ReSharper.Psi.JavaScript.Resolve.JsPrimitive ParentPrimitive { get; }
        JetBrains.ReSharper.Psi.JavaScript.Resolve.JsPrimitive Primitive { get; }
    }
    public class TsClassStaticType : JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.TypeScript.ITsType, JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsFinalPrimitiveType, JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsPrimitiveType
    {
        public TsClassStaticType(JetBrains.ReSharper.Psi.JavaScript.Resolve.JsPrimitive staticPrimitive, JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.JavaScriptResolveContext context) { }
        public JetBrains.ReSharper.Psi.JavaScript.Resolve.JsPrimitive ParentPrimitive { get; }
        public JetBrains.ReSharper.Psi.JavaScript.Resolve.JsPrimitive Primitive { get; }
        protected bool Equals(JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.TypeScript.TsClassStaticType other) { }
        public override bool Equals(object obj) { }
        public void FindAnnotations(System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.JavaScript.Impl.ControlFlow.Inspections.ValueAnalysis.ContractAnnotations.PreparedAnnotation> results, JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.JavaScriptResolveContext context) { }
        public void FindProperties(JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.JavaScriptResolveContext context, bool includeReadOnly, JetBrains.ReSharper.Psi.IPsiSourceFile exceptSourceFile, int exceptOffset, JetBrains.ReSharper.Psi.JavaScript.Resolve.JsSymbolTable result) { }
        public void FindSubTypes(JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.JavaScriptResolveContext context, JetBrains.ReSharper.Psi.IPsiSourceFile exceptSourceFile, int exceptOffset, JetBrains.ReSharper.Psi.JavaScript.Resolve.JsSymbolTable result) { }
        public string GetAnyName() { }
        public override int GetHashCode() { }
        public string GetPresentableName() { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.JavaScript.Resolve.IJavaScriptFunctionSignature> GetSignatures() { }
        public System.Xml.XmlNode GetXmlDoc(bool inherit) { }
        public bool IsFunction() { }
        public void ProcessDerivedTypes(JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.JavaScriptResolveContext context, JetBrains.ReSharper.Psi.JavaScript.Resolve.PrimitiveType primitiveType, int parameterIndex, bool allowIdentityLoss, object obj, int offset, System.Collections.Generic.IList<JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsFinalPrimitiveType> sourcePrimitives, JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.JsTypeExpandingContext derivedPrimitives, JetBrains.ReSharper.Psi.Resolve.ResolveErrorType resolveStatus) { }
        public void Resolve(JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.JavaScriptResolveContext context, string name, JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsDeclaredElementConsumer result, JetBrains.ReSharper.Psi.JavaScript.Resolve.SymbolType symbolType, System.Collections.Generic.IList<JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsFinalPrimitiveType> sourcePrimitives, JetBrains.ReSharper.Psi.Resolve.ResolveErrorType resolveStatus) { }
        public override string ToString() { }
    }
    public class TsDistinctDeclaredElementConsumer : JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsDeclaredElementConsumer
    {
        public TsDistinctDeclaredElementConsumer() { }
        public int Count { get; }
        public void AddToSymbolTable(JetBrains.ReSharper.Psi.JavaScript.Resolve.JsSymbolTable table) { }
        public void Consume(JetBrains.ReSharper.Psi.IDeclaredElement element) { }
    }
    public class TsFunctionLiteralType : JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.TypeScript.TsTypeBase
    {
        public TsFunctionLiteralType(JetBrains.ReSharper.Psi.JavaScript.Resolve.JsPrimitive primitive, JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.JavaScriptResolveContext context) { }
        protected override JetBrains.ReSharper.Psi.JavaScript.Resolve.JsPrimitive[] GetBaseTypes() { }
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.JavaScript.Resolve.IJavaScriptFunctionSignature> GetSignatures() { }
        public override System.Xml.XmlNode GetXmlDoc(bool inherit) { }
        public override bool IsFunction() { }
        public override void ProcessDerivedTypes(JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.JavaScriptResolveContext context, JetBrains.ReSharper.Psi.JavaScript.Resolve.PrimitiveType primitiveType, int parameterIndex, bool allowIdentityLoss, object obj, int offset, System.Collections.Generic.IList<JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsFinalPrimitiveType> sourcePrimitives, JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.JsTypeExpandingContext derivedPrimitives, JetBrains.ReSharper.Psi.Resolve.ResolveErrorType resolveStatus) { }
    }
    public class TsNamedType : JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.TypeScript.TsTypeWithSignaturesBase, JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsExpandablePrimitiveType, JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsPrimitiveType
    {
        public TsNamedType(JetBrains.ReSharper.Psi.JavaScript.Resolve.JsPrimitive primitive, JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.JavaScriptResolveContext context) { }
        public override JetBrains.ReSharper.Psi.JavaScript.Resolve.JsPrimitive ParentPrimitive { get; }
        public JetBrains.ReSharper.Psi.Resolve.ResolveErrorType Expand(JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.JsTypeExpandingContext context, bool shortCut, bool standardTypes, bool expectedTypes, bool strongTyped) { }
        public override void FindSubTypes(JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.JavaScriptResolveContext context, JetBrains.ReSharper.Psi.IPsiSourceFile exceptSourceFile, int exceptOffset, JetBrains.ReSharper.Psi.JavaScript.Resolve.JsSymbolTable result) { }
        public override string GetAnyName() { }
        protected override JetBrains.ReSharper.Psi.JavaScript.Resolve.JsPrimitive[] GetBaseTypes() { }
        public override void ProcessDerivedTypes(JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.JavaScriptResolveContext context, JetBrains.ReSharper.Psi.JavaScript.Resolve.PrimitiveType primitiveType, int parameterIndex, bool allowIdentityLoss, object obj, int offset, System.Collections.Generic.IList<JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsFinalPrimitiveType> sourcePrimitives, JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.JsTypeExpandingContext derivedPrimitives, JetBrains.ReSharper.Psi.Resolve.ResolveErrorType resolveStatus) { }
        public override void Resolve(JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.JavaScriptResolveContext context, string name, JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsDeclaredElementConsumer result, JetBrains.ReSharper.Psi.JavaScript.Resolve.SymbolType symbolType, System.Collections.Generic.IList<JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsFinalPrimitiveType> sourcePrimitives, JetBrains.ReSharper.Psi.Resolve.ResolveErrorType resolveStatus) { }
    }
    public class TsObjectLiteralType : JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.TypeScript.TsTypeWithSignaturesBase
    {
        public TsObjectLiteralType(JetBrains.ReSharper.Psi.JavaScript.Resolve.JsPrimitive primitive, JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.JavaScriptResolveContext context) { }
        protected override JetBrains.ReSharper.Psi.JavaScript.Resolve.JsPrimitive[] GetBaseTypes() { }
        public override void ProcessDerivedTypes(JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.JavaScriptResolveContext context, JetBrains.ReSharper.Psi.JavaScript.Resolve.PrimitiveType primitiveType, int parameterIndex, bool allowIdentityLoss, object obj, int offset, System.Collections.Generic.IList<JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsFinalPrimitiveType> sourcePrimitives, JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.JsTypeExpandingContext derivedPrimitives, JetBrains.ReSharper.Psi.Resolve.ResolveErrorType resolveStatus) { }
    }
    public class TsPrimitiveTypeConsumer : JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.IJsPrimitiveTypeConsumer
    {
        public TsPrimitiveTypeConsumer() { }
        public int Count { get; }
        public void Add(JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsPrimitiveType primitiveType) { }
        [JetBrains.Annotations.PureAttribute()]
        public JetBrains.Util.dataStructures.FrugalLocalList<JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsPrimitiveTypeDescription>.FrugalLocalListEnumerator GetEnumerator() { }
        public JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsPrimitiveTypeDescription TheOnlyPrimitiveType() { }
    }
    public class static TsResolveImplUtil
    {
        public static readonly JetBrains.ReSharper.Psi.JavaScript.Resolve.JsPrimitive FunctionPrimitive;
        public static readonly JetBrains.ReSharper.Psi.JavaScript.Resolve.JsPrimitive ObjectPrimitive;
        public static JetBrains.ReSharper.Psi.JavaScript.Resolve.JsPrimitive[] GetBaseTypes(JetBrains.ReSharper.Psi.JavaScript.Resolve.JsPrimitive type, JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.JavaScriptResolveContext context, bool addSelf, bool recurse) { }
        public static JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsFinalPrimitiveType GetTypeForLiteral(JetBrains.ReSharper.Psi.JavaScript.Resolve.JsPrimitive primitive, JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.JavaScriptResolveContext context) { }
        public static JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.TypeScript.ITsType GetTypeForNamedType(JetBrains.ReSharper.Psi.JavaScript.Resolve.JsPrimitive primitive, JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.JavaScriptResolveContext context) { }
    }
    public abstract class TsTypeBase : JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.TypeScript.ITsType, JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsFinalPrimitiveType, JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsPrimitiveType
    {
        protected readonly JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.JavaScriptResolveContext myContext;
        protected readonly JetBrains.ReSharper.Psi.JavaScript.Resolve.JsPrimitive myPrimitive;
        protected TsTypeBase(JetBrains.ReSharper.Psi.JavaScript.Resolve.JsPrimitive primitive, JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.JavaScriptResolveContext context) { }
        public virtual JetBrains.ReSharper.Psi.JavaScript.Resolve.JsPrimitive ParentPrimitive { get; }
        public JetBrains.ReSharper.Psi.JavaScript.Resolve.JsPrimitive Primitive { get; }
        protected bool Equals(JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.TypeScript.TsTypeBase other) { }
        public override bool Equals(object obj) { }
        public void FindAnnotations(System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.JavaScript.Impl.ControlFlow.Inspections.ValueAnalysis.ContractAnnotations.PreparedAnnotation> results, JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.JavaScriptResolveContext context) { }
        public void FindProperties(JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.JavaScriptResolveContext context, bool includeReadOnly, JetBrains.ReSharper.Psi.IPsiSourceFile exceptSourceFile, int exceptOffset, JetBrains.ReSharper.Psi.JavaScript.Resolve.JsSymbolTable result) { }
        public virtual void FindSubTypes(JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.JavaScriptResolveContext context, JetBrains.ReSharper.Psi.IPsiSourceFile exceptSourceFile, int exceptOffset, JetBrains.ReSharper.Psi.JavaScript.Resolve.JsSymbolTable result) { }
        public virtual string GetAnyName() { }
        protected abstract JetBrains.ReSharper.Psi.JavaScript.Resolve.JsPrimitive[] GetBaseTypes();
        public override int GetHashCode() { }
        public virtual string GetPresentableName() { }
        public abstract System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.JavaScript.Resolve.IJavaScriptFunctionSignature> GetSignatures();
        public virtual System.Xml.XmlNode GetXmlDoc(bool inherit) { }
        public abstract bool IsFunction();
        public virtual void ProcessDerivedTypes(JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.JavaScriptResolveContext context, JetBrains.ReSharper.Psi.JavaScript.Resolve.PrimitiveType primitiveType, int parameterIndex, bool allowIdentityLoss, object obj, int offset, System.Collections.Generic.IList<JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsFinalPrimitiveType> sourcePrimitives, JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.JsTypeExpandingContext derivedPrimitives, JetBrains.ReSharper.Psi.Resolve.ResolveErrorType resolveStatus) { }
        public virtual void Resolve(JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.JavaScriptResolveContext context, string name, JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsDeclaredElementConsumer result, JetBrains.ReSharper.Psi.JavaScript.Resolve.SymbolType symbolType, System.Collections.Generic.IList<JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsFinalPrimitiveType> sourcePrimitives, JetBrains.ReSharper.Psi.Resolve.ResolveErrorType resolveStatus) { }
        public override string ToString() { }
    }
    public class TsTypeForUnresolvedScope : JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsFinalPrimitiveType, JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsPrimitiveType
    {
        public TsTypeForUnresolvedScope(JetBrains.ReSharper.Psi.JavaScript.Resolve.JsPrimitive scope, System.Collections.Generic.IList<JetBrains.ReSharper.Psi.JavaScript.Resolve.JsPrimitive> expandedPrimitives = null) { }
        public void FindAnnotations(System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.JavaScript.Impl.ControlFlow.Inspections.ValueAnalysis.ContractAnnotations.PreparedAnnotation> results, JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.JavaScriptResolveContext context) { }
        public void FindProperties(JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.JavaScriptResolveContext context, bool includeReadOnly, JetBrains.ReSharper.Psi.IPsiSourceFile exceptSourceFile, int exceptOffset, JetBrains.ReSharper.Psi.JavaScript.Resolve.JsSymbolTable result) { }
        public void FindSubTypes(JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.JavaScriptResolveContext context, JetBrains.ReSharper.Psi.IPsiSourceFile exceptSourceFile, int exceptOffset, JetBrains.ReSharper.Psi.JavaScript.Resolve.JsSymbolTable result) { }
        public string GetAnyName() { }
        public string GetPresentableName() { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.JavaScript.Resolve.IJavaScriptFunctionSignature> GetSignatures() { }
        public System.Xml.XmlNode GetXmlDoc(bool inherit) { }
        public bool IsFunction() { }
        public void ProcessDerivedTypes(JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.JavaScriptResolveContext context, JetBrains.ReSharper.Psi.JavaScript.Resolve.PrimitiveType primitiveType, int parameterIndex, bool allowIdentityLoss, object obj, int offset, System.Collections.Generic.IList<JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsFinalPrimitiveType> sourcePrimitives, JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.JsTypeExpandingContext derivedPrimitives, JetBrains.ReSharper.Psi.Resolve.ResolveErrorType resolveStatus) { }
        public void Resolve(JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.JavaScriptResolveContext context, string name, JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsDeclaredElementConsumer result, JetBrains.ReSharper.Psi.JavaScript.Resolve.SymbolType symbolType, System.Collections.Generic.IList<JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsFinalPrimitiveType> sourcePrimitives, JetBrains.ReSharper.Psi.Resolve.ResolveErrorType resolveStatus) { }
    }
    public abstract class TsTypeWithSignaturesBase : JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.TypeScript.TsTypeBase
    {
        protected TsTypeWithSignaturesBase(JetBrains.ReSharper.Psi.JavaScript.Resolve.JsPrimitive primitive, JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.JavaScriptResolveContext context) { }
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.JavaScript.Resolve.IJavaScriptFunctionSignature> GetSignatures() { }
        public override bool IsFunction() { }
        public override void ProcessDerivedTypes(JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.JavaScriptResolveContext context, JetBrains.ReSharper.Psi.JavaScript.Resolve.PrimitiveType primitiveType, int parameterIndex, bool allowIdentityLoss, object obj, int offset, System.Collections.Generic.IList<JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsFinalPrimitiveType> sourcePrimitives, JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.JsTypeExpandingContext derivedPrimitives, JetBrains.ReSharper.Psi.Resolve.ResolveErrorType resolveStatus) { }
    }
}
namespace JetBrains.ReSharper.Psi.JavaScript.Impl.Services
{
    
    public interface IJavaScriptDependencyProvider
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.IPsiSourceFile> GetDependencies(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile);
    }
    public interface IJavaScriptSourceFilesVisibilityManager
    {
        JetBrains.ReSharper.Psi.JavaScript.Impl.Services.JavaScriptSourceFilesVisibilityFilter CreateFilter(JetBrains.ReSharper.Psi.IPsiSourceFile fromFile);
    }
    public interface IJavaScriptSymbolVisibilityManager
    {
        JetBrains.ReSharper.Psi.JavaScript.Impl.Services.JavaScriptSymbolVisibilityFilter CreateFilter(JetBrains.ReSharper.Psi.IPsiSourceFile fromFile, JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.JsQualifierKind qualifierKind);
    }
    public class JavaScriptDeclaredElementType : JetBrains.ReSharper.Psi.DeclaredElementType
    {
        public static readonly JetBrains.ReSharper.Psi.JavaScript.Impl.Services.JavaScriptDeclaredElementType Function;
        public static readonly JetBrains.ReSharper.Psi.JavaScript.Impl.Services.JavaScriptDeclaredElementType ImplicitProperty;
        public static readonly JetBrains.ReSharper.Psi.JavaScript.Impl.Services.JavaScriptDeclaredElementType Label;
        public static readonly JetBrains.ReSharper.Psi.JavaScript.Impl.Services.JavaScriptDeclaredElementType Parameter;
        public static readonly JetBrains.ReSharper.Psi.JavaScript.Impl.Services.JavaScriptDeclaredElementType Property;
        public static readonly JetBrains.ReSharper.Psi.JavaScript.Impl.Services.JavaScriptDeclaredElementType Variable;
        protected JavaScriptDeclaredElementType(string name, JetBrains.UI.Icons.IconId imageName) { }
        protected override JetBrains.ReSharper.Psi.IDeclaredElementPresenter DefaultPresenter { get; }
        public override string PresentableName { get; }
        protected override JetBrains.UI.Icons.IconId GetImage() { }
        public override bool IsPresentable(JetBrains.ReSharper.Psi.PsiLanguageType language) { }
    }
    public class JavaScriptElementFactoryImpl : JetBrains.ReSharper.Psi.JavaScript.Services.JavaScriptElementFactory
    {
        public JavaScriptElementFactoryImpl([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Modules.IPsiModule module, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.PsiLanguageType language, bool applyCodeFormatter) { }
        public override JetBrains.ReSharper.Psi.JavaScript.Tree.IBlock CreateBlock(string format, params object[] args) { }
        public override JetBrains.ReSharper.Psi.JavaScript.Tree.ICompoundExpression CreateCompound(string format, params object[] args) { }
        public override JetBrains.ReSharper.Psi.JavaScript.Impl.Tree.IDocCommentNode CreateDocComment(string text) { }
        public override JetBrains.ReSharper.Psi.JavaScript.Tree.IBlock CreateEmptyBlock() { }
        public override JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression CreateExpression(string format, params object[] args) { }
        public override JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptFile CreateFile(string format, params object[] args) { }
        protected JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptFile CreateFileImpl(string text, params object[] args) { }
        public override JetBrains.ReSharper.Psi.JavaScript.Tree.IForInitializer CreateForExpressionInitializer([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression expression) { }
        public override JetBrains.ReSharper.Psi.JavaScript.Tree.IForInitializer CreateForInitializer(string format, params object[] args) { }
        public override JetBrains.ReSharper.Psi.JavaScript.Tree.IIdentifierExpression CreateIdentifierExpression(string name) { }
        public override JetBrains.ReSharper.Psi.JavaScript.Tree.IIdentifierExpression CreateIdentifierExpressionExpectKeyword(string name) { }
        public override JetBrains.ReSharper.Psi.JavaScript.Tree.IObjectPropertyAccessor CreateObjectPropertyAccessor(JetBrains.ReSharper.Psi.JavaScript.Tree.AccessorKind kind, string name) { }
        public override JetBrains.ReSharper.Psi.JavaScript.Tree.IObjectPropertyInitializer CreateObjectPropertyInitializer(string name, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression expression) { }
        public override JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptParameterDeclaration CreateParameterDeclaration(string name) { }
        public override JetBrains.ReSharper.Psi.JavaScript.Tree.IPropertyName CreatePropertyName(string name) { }
        public override JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatement CreateStatement(string format, params object[] args) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.JavaScript.LanguageImpl.JavaScriptLanguage))]
    public class JavaScriptOccerrencesFinder : JetBrains.ReSharper.Psi.Impl.Search.Occurences.OccurrencesFinderImplBase
    {
        public override bool CompareLeafNodex(JetBrains.ReSharper.Psi.Tree.ITreeNode node1, JetBrains.ReSharper.Psi.Tree.ITreeNode node2) { }
    }
    public class JavaScriptSourceFilesVisibilityFilter
    {
        public bool IsVisible(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
    }
    public class JavaScriptSymbolVisibilityFilter
    {
        public bool IsVisible(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
        public bool IsVisible(JetBrains.ReSharper.Psi.JavaScript.Caches.IJavaScriptSymbol symbol) { }
    }
    public class OnlyFrameworkFilesFilter : JetBrains.ReSharper.Psi.JavaScript.Impl.Services.IJavaScriptSourceFilesVisibilityFilter
    {
        public bool IsVisible(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
    }
}
namespace JetBrains.ReSharper.Psi.JavaScript.Impl.Services.TypeScript
{
    
    public class TypeScriptDeclaredElementType : JetBrains.ReSharper.Psi.JavaScript.Impl.Services.JavaScriptDeclaredElementType
    {
        public static readonly JetBrains.ReSharper.Psi.JavaScript.Impl.Services.TypeScript.TypeScriptDeclaredElementType AccessorMember;
        public static readonly JetBrains.ReSharper.Psi.JavaScript.Impl.Services.TypeScript.TypeScriptDeclaredElementType Class;
        public static readonly JetBrains.ReSharper.Psi.JavaScript.Impl.Services.TypeScript.TypeScriptDeclaredElementType Constructor;
        public static readonly JetBrains.ReSharper.Psi.JavaScript.Impl.Services.TypeScript.TypeScriptDeclaredElementType Enum;
        public static readonly JetBrains.ReSharper.Psi.JavaScript.Impl.Services.TypeScript.TypeScriptDeclaredElementType EnumMember;
        public static readonly JetBrains.ReSharper.Psi.JavaScript.Impl.Services.TypeScript.TypeScriptDeclaredElementType ExportedModuleMember;
        public static readonly JetBrains.ReSharper.Psi.JavaScript.Impl.Services.TypeScript.TypeScriptDeclaredElementType FieldMember;
        public static readonly JetBrains.ReSharper.Psi.JavaScript.Impl.Services.TypeScript.TypeScriptDeclaredElementType FunctionMember;
        public static readonly JetBrains.ReSharper.Psi.JavaScript.Impl.Services.TypeScript.TypeScriptDeclaredElementType Interface;
        public static readonly JetBrains.ReSharper.Psi.JavaScript.Impl.Services.TypeScript.TypeScriptDeclaredElementType LocalModuleMember;
        public static readonly JetBrains.ReSharper.Psi.JavaScript.Impl.Services.TypeScript.TypeScriptDeclaredElementType Module;
        protected override JetBrains.ReSharper.Psi.IDeclaredElementPresenter DefaultPresenter { get; }
        public bool ProvidesType { get; }
        public override bool IsPresentable(JetBrains.ReSharper.Psi.PsiLanguageType language) { }
    }
}
namespace JetBrains.ReSharper.Psi.JavaScript.Impl.SymbolFilters
{
    
    public interface IFunctionSignatureFilter
    {
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.JavaScript.Resolve.IJavaScriptFunctionSignature> FilterSignatures(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.JavaScript.Resolve.IJavaScriptFunctionSignature> signatures);
    }
    public interface IJavaScriptSymbolFilter
    {
        System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.JavaScript.Caches.IJavaScriptSymbol> FilterSymbols(System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.JavaScript.Caches.IJavaScriptSymbol> symbols);
    }
}
namespace JetBrains.ReSharper.Psi.JavaScript.Impl.Tree
{
    
    public class AlienCommentToken : JetBrains.ReSharper.Psi.JavaScript.Impl.Tree.JavaScriptGenericToken
    {
        public AlienCommentToken(string text) { }
    }
    public class AlienToken : JetBrains.ReSharper.Psi.JavaScript.Parsing.JavaScriptTokenBase
    {
        public AlienToken(string text) { }
        public override JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType NodeType { get; }
        public override string GetText() { }
        public override int GetTextLength() { }
    }
    public sealed class ChildRole
    {
        public const short JS_ACCESSOR_BODY = 45;
        public const short JS_ACCESSOR_TYPE = 44;
        public const short JS_ALIEN = 43;
        public const short JS_ARGUMENT = 31;
        public const short JS_ARROW = 49;
        public const short JS_BASE_TYPE_CLAUSE = 54;
        public const short JS_BLOCK = 8;
        public const short JS_CASE_CLAUSE = 25;
        public const short JS_CASE_CLAUSES_LIST = 40;
        public const short JS_CATCH = 37;
        public const short JS_COLON = 26;
        public const short JS_COMMA = 35;
        public const short JS_COMPOUND_EXPRESSION = 13;
        public const short JS_COMPOUND_EXPRESSION2 = 14;
        public const short JS_DECLARATION = 23;
        public const short JS_DECLARATION_LIST = 15;
        public const short JS_DOT = 34;
        public const short JS_ELLIPSIS = 56;
        public const short JS_ENUM_MEMBER = 56;
        public const short JS_EQ = 24;
        public const short JS_EXPRESSION = 16;
        public const short JS_EXPRESSION2 = 17;
        public const short JS_EXPRESSION3 = 18;
        public const short JS_EXTERNAL_NAME = 62;
        public const short JS_FILE_SECTION = 41;
        public const short JS_FILE_SECTIONS_SEPARATOR = 42;
        public const short JS_FINALLY = 38;
        public const short JS_FOR_INITIALIZER = 12;
        public const short JS_GT = 53;
        public const short JS_KEYWORD = 4;
        public const short JS_KEYWORD2 = 5;
        public const short JS_LBRACE = 19;
        public const short JS_LBRACKET = 21;
        public const short JS_LITERAL = 29;
        public const short JS_LPARENTH = 6;
        public const short JS_LT = 52;
        public const short JS_MEMBER = 50;
        public const short JS_MODULE_DECLARATION_NAME = 61;
        public const short JS_MODULE_NAME = 48;
        public const short JS_NAME = 1;
        public const short JS_OVERLOAD = 55;
        public const short JS_PARAMETER = 9;
        public const short JS_PARAMETERS = 36;
        public const short JS_PROPERTIES_LIST = 39;
        public const short JS_PROPERTY = 27;
        public const short JS_PROPERTY_NAME = 28;
        public const short JS_QUESTION = 33;
        public const short JS_RBRACE = 20;
        public const short JS_RBRACKET = 22;
        public const short JS_RPARENTH = 7;
        public const short JS_SEMICOLON = 10;
        public const short JS_SEMICOLON2 = 11;
        public const short JS_SIGN = 32;
        public const short JS_SIGNATURE = 51;
        public const short JS_STATEMENT = 2;
        public const short JS_STATEMENT2 = 3;
        public const short JS_TYPE_ANNOTATION = 47;
        public const short JS_TYPE_ARGUMENTS_LIST = 60;
        public const short JS_TYPE_PARAMETER = 58;
        public const short JS_TYPE_PARAMETER_CONSTRAINT = 57;
        public const short JS_TYPE_PARAMETERS = 59;
        public const short JS_TYPE_USAGE = 46;
        public const short LAST = 100;
        public const short NONE = 0;
    }
    public class static ElementBitsets
    {
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet CASE_CLAUSE_BIT_SET;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FOR_INITIALIZER_BIT_SET;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet JAVA_SCRIPT_EXPRESSION_BIT_SET;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet JAVA_SCRIPT_STATEMENT_BIT_SET;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet JAVA_SCRIPT_STATEMENT_WITH_PARENTHESIS_BIT_SET;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet MEMBER_EXPRESSION_BIT_SET;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet OBJECT_PROPERTY_DECLARATION_BIT_SET;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet PROPERTY_NAME_BIT_SET;
    }
    public abstract class ElementType
    {
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType ACCESSOR_BODY;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType ACCESSOR_SIGNATURE;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType ARRAY_LITERAL;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType BINARY_EXPRESSION;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType BLOCK;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType BREAK_STATEMENT;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType CASE_CASE_CLAUSE;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType CASE_CLAUSES_LIST;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType CATCH_BLOCK;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType COMPOUND_EXPRESSION;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType CONDITIONAL_TERNARY_EXPRESSION;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType CONTINUE_STATEMENT;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType DEBUG_STATEMENT;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType DEFAULT_CLAUSE;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType DO_STATEMENT;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType EMPTY_STATEMENT;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType ERROR_ELEMENT;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType EXPRESSION_STATEMENT;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType FINALLY_BLOCK;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType FOR_DECLARATION_INITIALIZER;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType FOR_EXPRESSION_INITIALIZER;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType FOR_STATEMENT;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType FOREACH_STATEMENT;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType FUNCTION_EXPRESSION;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType FUNCTION_EXPRESSION_SIGNATURE;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType FUNCTION_STATEMENT;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType IDENTIFIER_EXPRESSION;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType IF_STATEMENT;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType INDEX_EXPRESSION;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType INVOCATION_EXPRESSION;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType JAVA_SCRIPT_FILE;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType JAVA_SCRIPT_FILE_SECTION;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType JAVA_SCRIPT_LITERAL_EXPRESSION;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType JAVA_SCRIPT_PARAMETER_DECLARATION;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType JAVA_SCRIPT_PARAMETER_LIST;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType LABELLED_STATEMENT;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType NEW_EXPRESSION;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType OBJECT_LITERAL;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType OBJECT_PROPERTIES_LIST;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType OBJECT_PROPERTY_ACCESSOR;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType OBJECT_PROPERTY_INITIALIZER;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType PARENTHESIZED_EXPRESSION;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType POSTFIX_EXPRESSION;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType PREFIX_EXPRESSION;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType PROPERTY_NAME_IDENTIFIER;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType PROPERTY_NAME_NUMERIC_LITERAL;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType PROPERTY_NAME_STRING_LITERAL;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType REFERENCE_EXPRESSION;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType RETURN_STATEMENT;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType SWITCH_STATEMENT;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType THIS_EXPRESSION;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType THROW_STATEMENT;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType TRY_STATEMENT;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType VARIABLE_DECLARATION;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType VARIABLE_DECLARATION_LIST;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType VARIABLE_STATEMENT;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType WHILE_STATEMENT;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType WITH_STATEMENT;
    }
    public interface IDocCommentNode : JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptCommentNode, JetBrains.ReSharper.Psi.Tree.IComment, JetBrains.ReSharper.Psi.Tree.ICommentNode, JetBrains.ReSharper.Psi.Tree.ITokenNode, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.JavaScript.Impl.Tree.IDocCommentNode ReplaceBy(JetBrains.ReSharper.Psi.JavaScript.Impl.Tree.IDocCommentNode docCommentNode);
    }
    public interface IJsOptimizedDeclaration : JetBrains.ReSharper.Psi.Tree.IDeclaration, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Tree.IXmlDocOwnerTreeNode
    {
        JetBrains.ReSharper.Psi.JavaScript.DeclaredElements.IJavaScriptTypeOwner GetDeclaredElementOptimized(JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsDocumentOffsetProvider context);
    }
    public abstract class JavaScriptCompositeElement : JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeElement
    {
        public override JetBrains.ReSharper.Psi.PsiLanguageType Language { get; }
    }
    public abstract class JavaScriptExpressionBase : JetBrains.ReSharper.Psi.JavaScript.Impl.Tree.JavaScriptCompositeElement
    {
        public JetBrains.ReSharper.Psi.Tree.ExpressionAccessType GetAccessType() { }
        public abstract JetBrains.ReSharper.Psi.JavaScript.Resolve.IJavaScriptType GetJsType(JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsLocalElementResolver context);
        public JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression ReplaceBy<TExpression>(TExpression expression)
            where TExpression :  class, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression { }
    }
    public abstract class JavaScriptFileBase : JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.FileElementBase { }
    public abstract class JavaScriptFunctionLikeBase : JetBrains.ReSharper.Psi.JavaScript.Impl.Tree.JavaScriptExpressionBase, JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsRuleProvider
    {
        protected JavaScriptFunctionLikeBase() { }
        public virtual System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.Tree.IDeclaration> DeclarationsInScope { get; }
        public System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptDeclaredElementProvider> DeclaredElementProviders { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptDocCommentBlockNode> DocCommentBlocks { get; }
        public JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptDocCommentBlockNode FirstDocCommentBlock { get; }
        public abstract JetBrains.ReSharper.Psi.Tree.ITreeNode FirstNodeForHighlighting { get; }
        public int LevelDelta { get; }
        public abstract JetBrains.ReSharper.Psi.JavaScript.Tree.IJsSignatureNode SignatureNode { get; }
        public JetBrains.ReSharper.Psi.Resolve.ISymbolTable AddDeclarationsAfterElement(JetBrains.ReSharper.Psi.Resolve.ISymbolTable parentTable, JetBrains.ReSharper.Psi.Tree.ITreeNode element, int level, JetBrains.ReSharper.Psi.Resolve.SymbolTableMode mode) { }
        public JetBrains.ReSharper.Psi.Resolve.ISymbolTable AddDeclarationsBeforeElement(JetBrains.ReSharper.Psi.Resolve.ISymbolTable parentTable, JetBrains.ReSharper.Psi.Tree.ITreeNode element, int level, JetBrains.ReSharper.Psi.Resolve.SymbolTableMode mode) { }
        public JetBrains.ReSharper.Psi.Resolve.ISymbolTable AddGlobalDeclarations(JetBrains.ReSharper.Psi.Resolve.ISymbolTable parentTable, int level, JetBrains.ReSharper.Psi.Resolve.SymbolTableMode mode) { }
        public virtual void AddRules(JetBrains.ReSharper.Psi.JavaScript.Resolve.IJavaScriptCacheBuilderContext context) { }
        protected System.Collections.Generic.IList<JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptDeclaredElementProvider> CalculateDeclaredElementProviders() { }
        public abstract JetBrains.ReSharper.Psi.JavaScript.Tree.IBlock GetBlock();
        public JetBrains.ReSharper.Psi.Tree.ITreeNode GetBody() { }
        public virtual System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.IDeclaredElement> GetDeclaredElementsInScope(JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsDocumentOffsetProvider context) { }
        protected System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.JavaScript.Resolve.IJavaScriptFunctionSignature> GetDocCommentSignatures() { }
        public override JetBrains.ReSharper.Psi.JavaScript.Resolve.IJavaScriptType GetJsType(JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsLocalElementResolver context) { }
        public JetBrains.ReSharper.Psi.JavaScript.Resolve.IJavaScriptType GetJsType(JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsDocumentOffsetProvider context) { }
        public virtual JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptTreeNode GetParentForAutoFormat() { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.JavaScript.Resolve.IJavaScriptFunctionSignature> GetSignatures() { }
        public System.Xml.XmlNode GetXMLDoc(bool inherit) { }
        public virtual System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.JavaScript.Tree.IJsSignatureNode> OverloadSignatureNodes() { }
    }
    public class JavaScriptGenericToken : JetBrains.ReSharper.Psi.JavaScript.Parsing.JavaScriptTokenBase
    {
        public JavaScriptGenericToken(JetBrains.ReSharper.Psi.Parsing.TokenNodeType nodeType, string text) { }
        public override JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType NodeType { get; }
        public override string GetText() { }
        public override int GetTextLength() { }
    }
    public abstract class JavaScriptSignatureNodeBase : JetBrains.ReSharper.Psi.JavaScript.Impl.Tree.JavaScriptExpressionBase, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IIncrementalScope, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IScope, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptScope, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptTypedNode, JetBrains.ReSharper.Psi.JavaScript.Tree.IJsSignatureNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Tree.IXmlDocOwnerTreeNode
    {
        protected JavaScriptSignatureNodeBase() { }
        public virtual System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.Tree.IDeclaration> DeclarationsInScope { get; }
        public int LevelDelta { get; }
        public virtual JetBrains.ReSharper.Psi.JavaScript.Resolve.IJavaScriptFunctionSignature Signature { get; }
        public JetBrains.ReSharper.Psi.Resolve.ISymbolTable AddDeclarationsAfterElement(JetBrains.ReSharper.Psi.Resolve.ISymbolTable parentTable, JetBrains.ReSharper.Psi.Tree.ITreeNode element, int level, JetBrains.ReSharper.Psi.Resolve.SymbolTableMode mode) { }
        public virtual JetBrains.ReSharper.Psi.Resolve.ISymbolTable AddDeclarationsBeforeElement(JetBrains.ReSharper.Psi.Resolve.ISymbolTable parentTable, JetBrains.ReSharper.Psi.Tree.ITreeNode element, int level, JetBrains.ReSharper.Psi.Resolve.SymbolTableMode mode) { }
        public JetBrains.ReSharper.Psi.Resolve.ISymbolTable AddGlobalDeclarations(JetBrains.ReSharper.Psi.Resolve.ISymbolTable parentTable, int level, JetBrains.ReSharper.Psi.Resolve.SymbolTableMode mode) { }
        protected virtual System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Tree.IDeclaration> CalculateDeclarationsInScope() { }
        public System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.IDeclaredElement> GetDeclaredElementsInScope(JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsDocumentOffsetProvider context) { }
        public override JetBrains.ReSharper.Psi.JavaScript.Resolve.IJavaScriptType GetJsType(JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsLocalElementResolver context) { }
        public JetBrains.ReSharper.Psi.JavaScript.Resolve.IJavaScriptType GetJsType(JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsDocumentOffsetProvider context) { }
        public abstract JetBrains.Util.Pair<string, string> GetOwnerFunctionPresentation();
        public abstract JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptParameterDeclarationBase> GetParameters();
        public JetBrains.ReSharper.Psi.JavaScript.Resolve.JsPrimitive GetPrimitive(JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsDocumentOffsetProvider context) { }
        public System.Xml.XmlNode GetXMLDoc(bool inherit) { }
    }
    public class PsiGeneratedGetterTestUtil : JetBrains.ReSharper.Psi.Parsing.PsiGetterTestUtil { }
    public class StatementsRange : JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatementsRange, JetBrains.ReSharper.Psi.Tree.IStatementsRange
    {
        public static readonly JetBrains.ReSharper.Psi.JavaScript.Impl.Tree.StatementsRange Empty;
        public StatementsRange(JetBrains.ReSharper.Psi.ITreeRange treeRange) { }
        public StatementsRange(JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatement first, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatement last) { }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Tree.IStatement> Statements { get; }
        public JetBrains.ReSharper.Psi.ITreeRange TreeRange { get; }
    }
    public abstract class TokenType
    {
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType ALIEN;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType AMPER;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType AMPER2;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType AMPEREQ;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType ASTERISK;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType BREAK_KEYWORD;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType CAROT;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType CAROTEQ;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType CASE_KEYWORD;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType CATCH_KEYWORD;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType COLON;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType COMMA;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType CONTINUE_KEYWORD;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType DEBUG_KEYWORD;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType DEFAULT_KEYWORD;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType DELETE_KEYWORD;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType DIVIDE;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType DIVIDEEQ;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType DO_KEYWORD;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType DOT;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType ELSE_KEYWORD;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType EQ;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType EQ2;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType EQ3;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType EXCLAMATION;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType FALSE_KEYWORD;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType FINALLY_KEYWORD;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType FOR_KEYWORD;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType FUNCTION_KEYWORD;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType GENERATED_CODE_SEPARATOR;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType GT;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType GT3;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType GT3EQ;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType GTEQ;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType IDENTIFIER;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType IF_KEYWORD;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType IN_KEYWORD;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType INSTANCEOF_KEYWORD;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType LBRACE;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType LBRACKET;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType LPARENTH;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType LSHIFT;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType LSHIFTEQ;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType LT;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType LTEQ;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType MINUS;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType MINUS2;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType MINUSEQ;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType NEW_KEYWORD;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType NOTEQ;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType NOTEQ2;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType NULL_KEYWORD;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType NUMERIC_LITERAL;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType PERCENT;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType PERCENTEQ;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType PIPE;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType PIPE2;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType PIPEEQ;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType PLUS;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType PLUS2;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType PLUSEQ;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType QUESTION;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType RBRACE;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType RBRACKET;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType REGULAR_EXPRESSION_LITERAL;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType RETURN_KEYWORD;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType RPARENTH;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType RSHIFT;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType RSHIFTEQ;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType SEMICOLON;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType STRING_LITERAL;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType SWITCH_KEYWORD;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType THIS_KEYWORD;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType THROW_KEYWORD;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType TILDE;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType TIMESEQ;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType TRUE_KEYWORD;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType TRY_KEYWORD;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType TYPEOF_KEYWORD;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType VAR_KEYWORD;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType VOID_KEYWORD;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType WHILE_KEYWORD;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType WITH_KEYWORD;
    }
    public abstract class WhitespaceBase : JetBrains.ReSharper.Psi.JavaScript.Parsing.JavaScriptTokenBase, JetBrains.ReSharper.Psi.JavaScript.Tree.IWhitespaceNode, JetBrains.ReSharper.Psi.Tree.ITokenNode, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        [JetBrains.Annotations.NotNullAttribute()]
        protected readonly string myText;
        protected WhitespaceBase([JetBrains.Annotations.NotNullAttribute()] string text) { }
        public abstract bool IsNewLine { get; }
        public override string GetText() { }
        public override int GetTextLength() { }
        public override bool IsFiltered() { }
        public override string ToString() { }
    }
}
namespace JetBrains.ReSharper.Psi.JavaScript.Impl.Tree.TypeScript
{
    
    public class static ElementBitsets
    {
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet TS_BASE_TYPE_CLAUSE_BIT_SET;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet TS_CASE_CLAUSE_BIT_SET;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet TS_CLASS_MEMBER_DECLARATION_BIT_SET;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet TS_EXPRESSION_BIT_SET;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet TS_FOR_INITIALIZER_BIT_SET;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet TS_IMPORT_MODULE_CLAUSE_BIT_SET;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet TS_LAMBDA_EXPRESSION_BIT_SET;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet TS_LAMBDA_EXPRESSION_SIGNATURE_BIT_SET;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet TS_MEMBER_EXPRESSION_BIT_SET;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet TS_OBJECT_PROPERTY_DECLARATION_BIT_SET;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet TS_PARAMETERS_OWNER_BIT_SET;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet TS_PROPERTY_NAME_BIT_SET;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet TS_STATEMENT_BIT_SET;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet TS_STATEMENT_WITH_PARENTHESIS_BIT_SET;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet TS_TYPE_DECLARATION_BIT_SET;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet TS_TYPE_MEMBER_DECLARATION_BIT_SET;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet TS_TYPE_PARAMETERS_OWNER_BIT_SET;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet TS_TYPE_USAGE_BIT_SET;
    }
    public abstract class ElementType
    {
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType ERROR_ELEMENT;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType TS_ACCESSOR_BODY;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType TS_ACCESSOR_SIGNATURE;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType TS_AMBIENT_MODULE_NAME;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType TS_ARRAY_LITERAL;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType TS_ARRAY_TYPE_USAGE;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType TS_BINARY_EXPRESSION;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType TS_BLOCK;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType TS_BLOCK_LAMBDA_EXPRESSION;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType TS_BREAK_STATEMENT;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType TS_CALL_SIGNATURE_DECLARATION;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType TS_CASE_CASE_CLAUSE;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType TS_CASE_CLAUSES_LIST;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType TS_CAST_EXPRESSION;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType TS_CATCH_BLOCK;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType TS_CLASS_DECLARATION;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType TS_COMPOUND_EXPRESSION;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType TS_CONDITIONAL_TERNARY_EXPRESSION;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType TS_CONSTRUCTOR_DECLARATION;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType TS_CONSTRUCTOR_OVERLOAD_DECLARATION;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType TS_CONTINUE_STATEMENT;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType TS_DEBUG_STATEMENT;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType TS_DECLARED_TYPE_USAGE;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType TS_DEFAULT_CLAUSE;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType TS_DO_STATEMENT;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType TS_EMPTY_STATEMENT;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType TS_ENUM_DECLARATION;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType TS_ENUM_MEMBER_DECLARATION;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType TS_EXPRESSION_LAMBDA_EXPRESSION;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType TS_EXPRESSION_STATEMENT;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType TS_EXTENDS_CLAUSE;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType TS_EXTERNAL_MODULE_REFERENCE_NAME;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType TS_FILE;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType TS_FILE_SECTION;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType TS_FINALLY_BLOCK;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType TS_FOR_DECLARATION_INITIALIZER;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType TS_FOR_EXPRESSION_INITIALIZER;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType TS_FOR_STATEMENT;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType TS_FOREACH_STATEMENT;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType TS_FUNCTION_EXPRESSION;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType TS_FUNCTION_EXPRESSION_SIGNATURE;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType TS_FUNCTION_SIGNATURE_DECLARATION;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType TS_FUNCTION_STATEMENT;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType TS_FUNCTION_STATEMENT_SIGNATURE;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType TS_FUNCTION_TYPE_USAGE;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType TS_IDENTIFIER_EXPRESSION;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType TS_IF_STATEMENT;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType TS_IMPLEMENTS_CLAUSE;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType TS_IMPORT_DECLARATION;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType TS_INDEX_EXPRESSION;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType TS_INDEX_SIGNATURE_DECLARATION;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType TS_INTERFACE_DECLARATION;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType TS_INVOCATION_EXPRESSION;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType TS_LABELLED_STATEMENT;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType TS_LAMBDA_EXPRESSION_FULL_SIGNATURE;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType TS_LAMBDA_EXPRESSION_SIMPLE_SIGNATURE;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType TS_LITERAL_EXPRESSION;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType TS_MEMBER_ACCESSOR_DECLARATION;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType TS_MEMBER_ACCESSOR_SIGNATURE;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType TS_MEMBER_FUNCTION_DECLARATION;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType TS_MEMBER_FUNCTION_OVERLOAD_DECLARATION;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType TS_MEMBER_VARIABLE_DECLARATION;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType TS_MODULE_DECLARATION;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType TS_MODULE_DECLARATION_NAME;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType TS_MODULE_QUALIFIED_NAME;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType TS_NEW_EXPRESSION;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType TS_OBJECT_LITERAL;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType TS_OBJECT_PROPERTIES_LIST;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType TS_OBJECT_PROPERTY_ACCESSOR;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType TS_OBJECT_PROPERTY_INITIALIZER;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType TS_OBJECT_TYPE_USAGE;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType TS_PARAMETER_DECLARATION;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType TS_PARAMETERS_LIST;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType TS_PARENTHESIZED_EXPRESSION;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType TS_POSTFIX_EXPRESSION;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType TS_PREFIX_EXPRESSION;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType TS_PROPERTY_NAME_IDENTIFIER;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType TS_PROPERTY_NAME_NUMERIC_LITERAL;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType TS_PROPERTY_NAME_STRING_LITERAL;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType TS_PROPERTY_SIGNATURE_DECLARATION;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType TS_REFERENCE_EXPRESSION;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType TS_REFERENCE_NAME;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType TS_RETURN_STATEMENT;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType TS_SUPER_EXPRESSION;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType TS_SWITCH_STATEMENT;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType TS_THIS_EXPRESSION;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType TS_THROW_STATEMENT;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType TS_TRY_STATEMENT;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType TS_TYPE_ANNOTATION;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType TS_TYPE_ARGUMENT_LIST;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType TS_TYPE_PARAMETER_DECLARATION;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType TS_TYPE_PARAMETERS;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType TS_VARIABLE_DECLARATION;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType TS_VARIABLE_DECLARATION_STATEMENT;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType TS_VARIABLE_DECLARATIONS_LIST;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType TS_WHILE_STATEMENT;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType TS_WITH_STATEMENT;
    }
    public class PsiGeneratedGetterTestUtil : JetBrains.ReSharper.Psi.Parsing.PsiGetterTestUtil { }
    public abstract class TokenType
    {
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType ALIEN;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType AMPER;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType AMPER2;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType AMPEREQ;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType ARROW;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType ASTERISK;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType BREAK_KEYWORD;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType CAROT;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType CAROTEQ;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType CASE_KEYWORD;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType CATCH_KEYWORD;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType CLASS_KEYWORD;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType COLON;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType COMMA;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType CONSTRUCTOR_KEYWORD;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType CONTINUE_KEYWORD;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType DEBUG_KEYWORD;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType DECLARE_KEYWORD;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType DEFAULT_KEYWORD;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType DELETE_KEYWORD;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType DIVIDE;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType DIVIDEEQ;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType DO_KEYWORD;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType DOT;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType ELLIPSIS;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType ELSE_KEYWORD;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType ENUM_KEYWORD;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType EQ;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType EQ2;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType EQ3;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType EXCLAMATION;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType EXPORT_KEYWORD;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType EXTENDS_KEYWORD;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType FALSE_KEYWORD;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType FINALLY_KEYWORD;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType FOR_KEYWORD;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType FUNCTION_KEYWORD;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType GENERATED_CODE_SEPARATOR;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType GT;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType GT3;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType GT3EQ;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType GTEQ;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType IDENTIFIER;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType IF_KEYWORD;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType IMPLEMENTS_KEYWORD;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType IMPORT_KEYWORD;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType IN_KEYWORD;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType INSTANCEOF_KEYWORD;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType INTERFACE_KEYWORD;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType LBRACE;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType LBRACKET;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType LPARENTH;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType LSHIFT;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType LSHIFTEQ;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType LT;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType LTEQ;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType MINUS;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType MINUS2;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType MINUSEQ;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType MODULE_KEYWORD;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType NEW_KEYWORD;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType NOTEQ;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType NOTEQ2;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType NULL_KEYWORD;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType NUMERIC_LITERAL;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType PERCENT;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType PERCENTEQ;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType PIPE;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType PIPE2;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType PIPEEQ;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType PLUS;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType PLUS2;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType PLUSEQ;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType PRIVATE_KEYWORD;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType PUBLIC_KEYWORD;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType QUESTION;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType RBRACE;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType RBRACKET;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType REGULAR_EXPRESSION_LITERAL;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType RETURN_KEYWORD;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType RPARENTH;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType RSHIFT;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType RSHIFTEQ;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType SEMICOLON;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType STATIC_KEYWORD;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType STRING_LITERAL;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType SUPER_KEYWORD;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType SWITCH_KEYWORD;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType THIS_KEYWORD;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType THROW_KEYWORD;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType TILDE;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType TIMESEQ;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType TRUE_KEYWORD;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType TRY_KEYWORD;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType TYPEOF_KEYWORD;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType VAR_KEYWORD;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType VOID_KEYWORD;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType WHILE_KEYWORD;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType WITH_KEYWORD;
    }
    public abstract class TypeScriptSignatureNodeBase : JetBrains.ReSharper.Psi.JavaScript.Impl.Tree.JavaScriptSignatureNodeBase, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IIncrementalScope, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IScope, JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsRuleProvider, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptScope, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptTypedNode, JetBrains.ReSharper.Psi.JavaScript.Tree.IJsSignatureNode, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsSignatureNode, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        public virtual void AddRules(JetBrains.ReSharper.Psi.JavaScript.Resolve.IJavaScriptCacheBuilderContext context) { }
        public abstract JetBrains.ReSharper.Psi.JavaScript.Resolve.IJavaScriptType GetReturnType(JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsLocalElementResolver context);
        public abstract JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsParameterDeclarationBase> GetTsParameters();
        public virtual bool IsExplicitConstructor() { }
    }
}
namespace JetBrains.ReSharper.Psi.JavaScript.Impl.Util
{
    
    public class static JavaScriptIdentifierUtil
    {
        public static JetBrains.ReSharper.Psi.JavaScript.DeclaredElements.IJavaScriptTypeOwner CreateDeclaredElement(JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptDeclaration node, JetBrains.ReSharper.Psi.JavaScript.Tree.IIdentifierExpression nameNode, JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsDocumentOffsetProvider context) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static string GetIdentifierName(JetBrains.ReSharper.Psi.JavaScript.Tree.IIdentifierExpressionBase identifierExpression) { }
        public static JetBrains.ReSharper.Psi.TreeTextRange GetTreeTextRangeOfIdentifier(JetBrains.ReSharper.Psi.JavaScript.Tree.IIdentifierExpression identifierExpressionNode) { }
        public static bool IsMissingDeclarationName(this string name) { }
        public static bool IsValidJavaScriptReferenceExpressionName(this JetBrains.ReSharper.Psi.LanguageService languageService, string name) { }
        public static void ReplaceIdentifier(JetBrains.ReSharper.Psi.Tree.ITreeNode parent, JetBrains.ReSharper.Psi.JavaScript.Tree.IIdentifierExpression nameNode, string name) { }
    }
    public class static JavaScriptPsiImplUtil
    {
        public const int FileOffset = -2;
        public const string GlobalPropertyName = "_$_$_$ReShArPeRGlObAl$_$_$_";
        public const string PrototypePropertyName = "prototype";
        public const string SystemPropertyNamePrefix = "_$_$_$ReShArPeR";
        public static T AddListItemAfter<T>(JetBrains.ReSharper.Psi.Tree.ITreeNode holder, short listRole, short elementRole, short sepRole, JetBrains.ReSharper.Psi.Parsing.TokenNodeType separator, T element, JetBrains.ReSharper.Psi.Tree.ITreeNode anchor)
            where T : JetBrains.ReSharper.Psi.Tree.ITreeNode { }
        public static T AddListItemBefore<T>(JetBrains.ReSharper.Psi.Tree.ITreeNode holder, short listRole, short elementRole, short sepRole, JetBrains.ReSharper.Psi.Parsing.TokenNodeType separator, T element, JetBrains.ReSharper.Psi.Tree.ITreeNode anchor)
            where T : JetBrains.ReSharper.Psi.Tree.ITreeNode { }
        public static System.Collections.Generic.IList<JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptDeclaredElementProvider> GetDeclarationsInStatements<TStatement>(System.Collections.Generic.IList<TStatement> statements)
            where TStatement : JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatement { }
        public static System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.IDeclaredElement> GetDeclaredElementsFromDeclarationList(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Tree.IDeclaration> declarations, JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsDocumentOffsetProvider context) { }
        public static System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.IDeclaredElement> GetDeclaredElementsFromProviderList(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptDeclaredElementProvider> providers, JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsDocumentOffsetProvider context) { }
        public static bool IsLocalDeclaration(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration) { }
        public static void RemoveListItem(JetBrains.ReSharper.Psi.Tree.ITreeNode holder, short listRole, short elementRole, short sepRole, JetBrains.ReSharper.Psi.Tree.ITreeNode item) { }
    }
    public class static JavaScriptUtilLiterals
    {
        public static string GetInnerText([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITokenNode literal) { }
    }
}
namespace JetBrains.ReSharper.Psi.JavaScript.Impl.Util.TypeScript
{
    
    public class static TypeScriptIdentifierUtil
    {
        public const string FileExternalModulePrefix = "_$_$_$ReShArPeRExt";
        public const string ParentForLocalModuleMember = "_$_$_$ReShArPeRModuleBody";
        public const string StaticNamespace = "_$_$_$ReShArPeRStatic";
        public static JetBrains.ReSharper.Psi.JavaScript.Impl.DeclaredElements.TypeScript.TsTypeElementBase CreateDeclaredElement(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITypeScriptTreeNode declaration, string name, JetBrains.ReSharper.Psi.JavaScript.Impl.Services.TypeScript.TypeScriptDeclaredElementType type, JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsDocumentOffsetProvider context, JetBrains.ReSharper.Psi.TreeTextRange nameRange, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.TsModifiers modifiers, string additionalParentNames = "") { }
        public static JetBrains.ReSharper.Psi.JavaScript.DeclaredElements.IJavaScriptTypeOwner CreateDeclaredElement(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITypeScriptGlobalDeclaration node, JetBrains.ReSharper.Psi.JavaScript.Tree.IIdentifierExpression nameNode, JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsDocumentOffsetProvider context) { }
        public static string GetExternalModuleNameForFile(JetBrains.ReSharper.Psi.IPsiSourceFile file) { }
        public static JetBrains.ReSharper.Psi.JavaScript.Resolve.IJavaScriptType GetUnresolvedScope(JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsDocumentOffsetProvider context, JetBrains.ReSharper.Psi.Tree.ITreeNode reference) { }
    }
}
namespace JetBrains.ReSharper.Psi.JavaScript
{
    
    [JetBrains.Application.Settings.SettingsKeyAttribute(typeof(JetBrains.ReSharper.Settings.CodeInspectionSettings), "JavaScript type resolve settings")]
    public class JavaScriptResolveSettingsKey
    {
        [JetBrains.Application.Settings.SettingsEntryAttribute(false, "Analyse property context when inspecting code")]
        public bool FullResolveForDynamicReferences;
        [JetBrains.Application.Settings.SettingsEntryAttribute(false, "Optimize cache for smartness (maybe slow)")]
        public bool SmartCache;
    }
}
namespace JetBrains.ReSharper.Psi.JavaScript.LanguageImpl
{
    
    public interface IJavaScriptDialectProvider
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.PsiLanguageType GetDialectLanguage(JetBrains.ProjectModel.IProjectFile projectFile);
    }
    public interface IObjectLiteralExpectedTypeProvider
    {
        JetBrains.ReSharper.Psi.JavaScript.Resolve.IJavaScriptType GetJsType(JetBrains.ReSharper.Psi.JavaScript.Tree.IObjectLiteral objectLiteral, JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsLocalElementResolver context);
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Resolve.ISymbolFilter> GetPropertyFilters(JetBrains.ReSharper.Psi.JavaScript.Tree.IObjectLiteral objectLiteral, JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.JavaScriptResolveContext resolveContext);
    }
    public abstract class JavaScriptBasedLanguageService : JetBrains.ReSharper.Psi.LanguageService
    {
        protected JavaScriptBasedLanguageService(JetBrains.ReSharper.Psi.PsiLanguageType psiLanguageType, JetBrains.ReSharper.Psi.IConstantValueService constantValueService) { }
    }
    [JetBrains.ReSharper.Psi.LanguageDefinitionAttribute("JAVA_SCRIPT")]
    public class JavaScriptLanguage : JetBrains.ReSharper.Psi.KnownLanguage
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static readonly JetBrains.ReSharper.Psi.JavaScript.LanguageImpl.JavaScriptLanguage Instance;
        public const string Name = "JAVA_SCRIPT";
        protected JavaScriptLanguage([JetBrains.Annotations.NotNullAttribute()] string name) { }
        protected JavaScriptLanguage([JetBrains.Annotations.NotNullAttribute()] string name, [JetBrains.Annotations.NotNullAttribute()] string presentableName) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.JavaScript.LanguageImpl.JavaScriptLanguage))]
    public class JavaScriptLanguageService : JetBrains.ReSharper.Psi.JavaScript.LanguageImpl.JavaScriptBasedLanguageService
    {
        protected readonly JetBrains.ReSharper.Psi.Util.CommonIdentifierIntern myIdentifierIntern;
        protected readonly JetBrains.ReSharper.Psi.TreeBuilder.MarkerListCache myMarkerListCache;
        public JavaScriptLanguageService(JetBrains.ReSharper.Psi.JavaScript.LanguageImpl.JavaScriptLanguage language, JetBrains.ReSharper.Psi.IConstantValueService constantValueService, JetBrains.ReSharper.Psi.JavaScript.Services.IJavaScriptCodeFormatter codeFormatter, JetBrains.ReSharper.Psi.Util.CommonIdentifierIntern identifierIntern, JetBrains.ReSharper.Psi.TreeBuilder.MarkerListCache markerListCache) { }
        public override JetBrains.ReSharper.Psi.ExtensionsAPI.Caches2.ILanguageCacheProvider CacheProvider { get; }
        public override JetBrains.ReSharper.Psi.CodeStyle.ICodeFormatter CodeFormatter { get; }
        public virtual bool FullResolveForDynamicReferences { get; }
        public override bool IsCaseSensitive { get; }
        public virtual bool SmartCache { get; }
        public override bool SupportTypeMemberCache { get; }
        public override JetBrains.ReSharper.Psi.ITypePresenter TypePresenter { get; }
        public override JetBrains.ReSharper.Psi.Pointers.IDeclaredElementPointer<T> CreateElementPointer<T>(T declaredElement)
            where T : JetBrains.ReSharper.Psi.IDeclaredElement { }
        public override JetBrains.ReSharper.Psi.Parsing.ILexer CreateFilteringLexer(JetBrains.ReSharper.Psi.Parsing.ILexer lexer) { }
        public override JetBrains.ReSharper.Psi.Parsing.IParser CreateParser(JetBrains.ReSharper.Psi.Parsing.ILexer lexer, JetBrains.ReSharper.Psi.Modules.IPsiModule module, JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
        public virtual JetBrains.ReSharper.Psi.JavaScript.Impl.ControlFlow.IJsControlFlowBuilder GetControlFlowBuilder() { }
        public override JetBrains.ReSharper.Psi.Parsing.ILexerFactory GetPrimaryLexerFactory() { }
        public override JetBrains.ReSharper.Psi.ReferenceAccessType GetReferenceAccessType(JetBrains.ReSharper.Psi.IDeclaredElement target, JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public override bool IsValidName(JetBrains.ReSharper.Psi.DeclaredElementType elementType, string name) { }
    }
    public class JavaScriptLexerFactory : JetBrains.ReSharper.Psi.Parsing.ILexerFactory
    {
        public JetBrains.ReSharper.Psi.Parsing.ILexer CreateLexer(JetBrains.Text.IBuffer buffer) { }
    }
    [JetBrains.ProjectModel.ProjectFileTypeAttribute(typeof(JetBrains.ProjectModel.JavaScriptProjectFileType))]
    public class JavaScriptProjectFileLanguageService : JetBrains.ReSharper.Psi.IProjectFileLanguageService
    {
        public JavaScriptProjectFileLanguageService(JetBrains.ProjectModel.JavaScriptProjectFileType javaScriptProjectFileType, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.JavaScript.LanguageImpl.IJavaScriptDialectProvider> dialects) { }
        public virtual JetBrains.UI.Icons.IconId Icon { get; }
        public JetBrains.ProjectModel.ProjectFileType LanguageType { get; }
        public virtual JetBrains.ReSharper.Psi.Parsing.ILexerFactory GetMixedLexerFactory(JetBrains.ProjectModel.ISolution solution, JetBrains.Text.IBuffer buffer, JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile = null) { }
        public JetBrains.ReSharper.Psi.PreProcessingDirective[] GetPreprocessorDefines(JetBrains.ProjectModel.IProject project) { }
        public virtual JetBrains.ReSharper.Psi.PsiLanguageType GetPsiLanguageType(JetBrains.ProjectModel.IProjectFile projectFile) { }
        public virtual JetBrains.ReSharper.Psi.PsiLanguageType GetPsiLanguageType(JetBrains.ProjectModel.ProjectFileType languageType) { }
        public virtual JetBrains.ReSharper.Psi.IPsiSourceFileProperties GetPsiProperties(JetBrains.ProjectModel.IProjectFile projectFile, JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
    }
    public class VBScriptDefaultPsiProjectFileProperties : JetBrains.ReSharper.Psi.Impl.DefaultPsiProjectFileProperties
    {
        public VBScriptDefaultPsiProjectFileProperties(JetBrains.ProjectModel.IProjectFile projectFile, JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
        public override bool ProvidesCodeModel { get; }
        public override bool ShouldBuildPsi { get; }
    }
    [JetBrains.ProjectModel.ProjectFileTypeAttribute(typeof(JetBrains.ProjectModel.VBScriptProjectFileType))]
    public class VBScriptProjectFileLanguageService : JetBrains.ReSharper.Psi.IProjectFileLanguageService
    {
        public VBScriptProjectFileLanguageService(JetBrains.ProjectModel.VBScriptProjectFileType vbScriptProjectFileType) { }
        public JetBrains.UI.Icons.IconId Icon { get; }
        public JetBrains.ProjectModel.ProjectFileType LanguageType { get; }
        public JetBrains.ReSharper.Psi.Parsing.ILexerFactory GetMixedLexerFactory(JetBrains.ProjectModel.ISolution solution, JetBrains.Text.IBuffer buffer, JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile = null) { }
        public JetBrains.ReSharper.Psi.PreProcessingDirective[] GetPreprocessorDefines(JetBrains.ProjectModel.IProject project) { }
        public JetBrains.ReSharper.Psi.PsiLanguageType GetPsiLanguageType(JetBrains.ProjectModel.IProjectFile projectFile) { }
        public JetBrains.ReSharper.Psi.PsiLanguageType GetPsiLanguageType(JetBrains.ProjectModel.ProjectFileType languageType) { }
        public JetBrains.ReSharper.Psi.IPsiSourceFileProperties GetPsiProperties(JetBrains.ProjectModel.IProjectFile projectFile, JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
    }
}
namespace JetBrains.ReSharper.Psi.JavaScript.LanguageImpl.JSon
{
    
    [JetBrains.ReSharper.Psi.LanguageDefinitionAttribute("JSON")]
    public class JsonLanguage : JetBrains.ReSharper.Psi.KnownLanguage
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static readonly JetBrains.ReSharper.Psi.JavaScript.LanguageImpl.JSon.JsonLanguage Instance;
        public const string Name = "JSON";
        protected JsonLanguage([JetBrains.Annotations.NotNullAttribute()] string name) { }
        protected JsonLanguage([JetBrains.Annotations.NotNullAttribute()] string name, [JetBrains.Annotations.NotNullAttribute()] string presentableName) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.JavaScript.LanguageImpl.JSon.JsonLanguage))]
    public class JsonLanguageService : JetBrains.ReSharper.Psi.JavaScript.LanguageImpl.JavaScriptBasedLanguageService
    {
        public JsonLanguageService(JetBrains.ReSharper.Psi.JavaScript.LanguageImpl.JSon.JsonLanguage jsonLanguage, JetBrains.ReSharper.Psi.IConstantValueService constantValueService, JetBrains.ReSharper.Psi.JavaScript.Services.IJavaScriptCodeFormatter codeFormatter, JetBrains.ReSharper.Psi.Util.CommonIdentifierIntern identifierIntern, JetBrains.ReSharper.Psi.TreeBuilder.MarkerListCache markerListCache) { }
        public override JetBrains.ReSharper.Psi.ExtensionsAPI.Caches2.ILanguageCacheProvider CacheProvider { get; }
        public override JetBrains.ReSharper.Psi.CodeStyle.ICodeFormatter CodeFormatter { get; }
        public override bool IsCaseSensitive { get; }
        public override bool SupportTypeMemberCache { get; }
        public override JetBrains.ReSharper.Psi.ITypePresenter TypePresenter { get; }
        public override JetBrains.ReSharper.Psi.Pointers.IDeclaredElementPointer<T> CreateElementPointer<T>(T declaredElement)
            where T : JetBrains.ReSharper.Psi.IDeclaredElement { }
        public override JetBrains.ReSharper.Psi.Parsing.ILexer CreateFilteringLexer(JetBrains.ReSharper.Psi.Parsing.ILexer lexer) { }
        public override JetBrains.ReSharper.Psi.Parsing.IParser CreateParser(JetBrains.ReSharper.Psi.Parsing.ILexer lexer, JetBrains.ReSharper.Psi.Modules.IPsiModule module, JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
        public override JetBrains.ReSharper.Psi.Parsing.ILexerFactory GetPrimaryLexerFactory() { }
        public override JetBrains.ReSharper.Psi.ReferenceAccessType GetReferenceAccessType(JetBrains.ReSharper.Psi.IDeclaredElement target, JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public override bool IsValidName(JetBrains.ReSharper.Psi.DeclaredElementType elementType, string name) { }
    }
    public class JsonLexerFactory : JetBrains.ReSharper.Psi.Parsing.ILexerFactory
    {
        public JetBrains.ReSharper.Psi.Parsing.ILexer CreateLexer(JetBrains.Text.IBuffer buffer) { }
    }
}
namespace JetBrains.ReSharper.Psi.JavaScript.LanguageImpl.ResJSon
{
    
    [JetBrains.ProjectModel.ProjectFileTypeAttribute(typeof(JetBrains.ProjectModel.ResJsonProjectFileType))]
    public class ResJsonProjectFileLanguageService : JetBrains.ReSharper.Psi.IProjectFileLanguageService
    {
        public ResJsonProjectFileLanguageService(JetBrains.ProjectModel.ResJsonProjectFileType resJsonProjectFileType) { }
        public JetBrains.UI.Icons.IconId Icon { get; }
        public JetBrains.ProjectModel.ProjectFileType LanguageType { get; }
        public virtual JetBrains.ReSharper.Psi.Parsing.ILexerFactory GetMixedLexerFactory(JetBrains.ProjectModel.ISolution solution, JetBrains.Text.IBuffer buffer, JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile = null) { }
        public JetBrains.ReSharper.Psi.PreProcessingDirective[] GetPreprocessorDefines(JetBrains.ProjectModel.IProject project) { }
        public virtual JetBrains.ReSharper.Psi.PsiLanguageType GetPsiLanguageType(JetBrains.ProjectModel.IProjectFile projectFile) { }
        public virtual JetBrains.ReSharper.Psi.PsiLanguageType GetPsiLanguageType(JetBrains.ProjectModel.ProjectFileType languageType) { }
        public virtual JetBrains.ReSharper.Psi.IPsiSourceFileProperties GetPsiProperties(JetBrains.ProjectModel.IProjectFile projectFile, JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
    }
}
namespace JetBrains.ReSharper.Psi.JavaScript.LanguageImpl.TypeScript
{
    
    [JetBrains.ReSharper.Psi.LanguageDefinitionAttribute("TYPE_SCRIPT")]
    public class TypeScriptLanguage : JetBrains.ReSharper.Psi.JavaScript.LanguageImpl.JavaScriptLanguage
    {
        public static readonly JetBrains.ReSharper.Psi.JavaScript.LanguageImpl.TypeScript.TypeScriptLanguage Instance;
        public const string Name = "TYPE_SCRIPT";
        protected TypeScriptLanguage([JetBrains.Annotations.NotNullAttribute()] string name) { }
        protected TypeScriptLanguage([JetBrains.Annotations.NotNullAttribute()] string name, [JetBrains.Annotations.NotNullAttribute()] string presentableName) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.JavaScript.LanguageImpl.TypeScript.TypeScriptLanguage))]
    public class TypeScriptLanguageService : JetBrains.ReSharper.Psi.JavaScript.LanguageImpl.JavaScriptLanguageService
    {
        public TypeScriptLanguageService(JetBrains.ReSharper.Psi.JavaScript.LanguageImpl.TypeScript.TypeScriptLanguage language, JetBrains.ReSharper.Psi.IConstantValueService constantValueService, JetBrains.ReSharper.Psi.JavaScript.Services.IJavaScriptCodeFormatter codeFormatter, JetBrains.ReSharper.Psi.Util.CommonIdentifierIntern identifierIntern, JetBrains.ReSharper.Psi.TreeBuilder.MarkerListCache listCache) { }
        public override bool FullResolveForDynamicReferences { get; }
        public override JetBrains.ReSharper.Psi.Parsing.ILexer CreateFilteringLexer(JetBrains.ReSharper.Psi.Parsing.ILexer lexer) { }
        public override JetBrains.ReSharper.Psi.Parsing.IParser CreateParser(JetBrains.ReSharper.Psi.Parsing.ILexer lexer, JetBrains.ReSharper.Psi.Modules.IPsiModule module, JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
        public override JetBrains.ReSharper.Psi.JavaScript.Impl.ControlFlow.IJsControlFlowBuilder GetControlFlowBuilder() { }
        public override JetBrains.ReSharper.Psi.Parsing.ILexerFactory GetPrimaryLexerFactory() { }
        public override bool IsValidName(JetBrains.ReSharper.Psi.DeclaredElementType elementType, string name) { }
    }
    public class TypeScriptLexerFactory : JetBrains.ReSharper.Psi.Parsing.ILexerFactory
    {
        public JetBrains.ReSharper.Psi.Parsing.ILexer CreateLexer(JetBrains.Text.IBuffer buffer) { }
    }
    [JetBrains.ProjectModel.ProjectFileTypeAttribute(typeof(JetBrains.ProjectModel.TypeScriptProjectFileType))]
    public class TypeScriptProjectFileLanguageService : JetBrains.ReSharper.Psi.JavaScript.LanguageImpl.JavaScriptProjectFileLanguageService
    {
        public TypeScriptProjectFileLanguageService(JetBrains.ProjectModel.TypeScriptProjectFileType projectFileType, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.JavaScript.LanguageImpl.IJavaScriptDialectProvider> dialects) { }
        public override JetBrains.UI.Icons.IconId Icon { get; }
        public override JetBrains.ReSharper.Psi.Parsing.ILexerFactory GetMixedLexerFactory(JetBrains.ProjectModel.ISolution solution, JetBrains.Text.IBuffer buffer, JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile = null) { }
        public override JetBrains.ReSharper.Psi.PsiLanguageType GetPsiLanguageType(JetBrains.ProjectModel.IProjectFile projectFile) { }
        public override JetBrains.ReSharper.Psi.PsiLanguageType GetPsiLanguageType(JetBrains.ProjectModel.ProjectFileType languageType) { }
        public override JetBrains.ReSharper.Psi.IPsiSourceFileProperties GetPsiProperties(JetBrains.ProjectModel.IProjectFile projectFile, JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
    }
}
namespace JetBrains.ReSharper.Psi.JavaScript.Naming
{
    
    [JetBrains.Application.Configuration.Upgrade.GlobalSettingsUpgraderAttribute()]
    [JetBrains.ProjectModel.Settings.Upgrade.SolutionSettingsUpgraderAttribute()]
    public class JavaScriptCustomRulesNamingSettingsUpgrade : JetBrains.ReSharper.Psi.Naming.Settings.Upgrade.CustomRulesNamingSettingsUpgrade<JetBrains.ReSharper.Psi.JavaScript.Naming.JavaScriptNamingSettingsKey>
    {
        public JavaScriptCustomRulesNamingSettingsUpgrade(JetBrains.Application.Parts.IPartsCatalogueSet partsSet, JetBrains.ProjectModel.ISolution solution = null) { }
        protected override JetBrains.ReSharper.Psi.Naming.Settings.CustomRulesNamingSettingsBase GetSpecificSettings(JetBrains.ReSharper.Psi.CodeStyle.SettingsUpgrade.CodeStyleSettingsObsolete codeStyleSettings) { }
    }
    public class JavaScriptNameCompletionUtil : JetBrains.ReSharper.Psi.Naming.Extentions.NameCompletionUtil
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static System.Collections.Generic.IList<string> SuggestNamesAt(JetBrains.ReSharper.Psi.Tree.IFile file, JetBrains.ReSharper.Psi.TreeOffset offset, string prefix) { }
    }
    [JetBrains.ReSharper.Psi.Naming.Elements.NamedElementsBagAttribute(typeof(JetBrains.ReSharper.Psi.JavaScript.LanguageImpl.JavaScriptLanguage))]
    public class JavaScriptNamedElements : JetBrains.ReSharper.Psi.Naming.Elements.ElementKindOfElementType
    {
        public static readonly JetBrains.ReSharper.Psi.Naming.Elements.IElementKind JS_CONSTRUCTOR;
        public static readonly JetBrains.ReSharper.Psi.Naming.Elements.IElementKind JS_FUNCTION;
        public static readonly JetBrains.ReSharper.Psi.Naming.Elements.IElementKind JS_GLOBAL_VARIABLE;
        public static readonly JetBrains.ReSharper.Psi.Naming.Elements.IElementKind JS_LABEL;
        public static readonly JetBrains.ReSharper.Psi.Naming.Elements.IElementKind JS_LOCAL_VARIABLE;
        public static readonly JetBrains.ReSharper.Psi.Naming.Elements.IElementKind JS_OBJECT_PROPERTY_OF_FUNCTION;
        public static readonly JetBrains.ReSharper.Psi.Naming.Elements.IElementKind JS_PARAMETER;
        protected JavaScriptNamedElements([JetBrains.Annotations.NotNullAttribute()] string name, string presentableName, System.Func<JetBrains.ReSharper.Psi.IDeclaredElement, bool> isApplicable, JetBrains.ReSharper.Psi.Naming.Settings.NamingRule namingRule) { }
        public override JetBrains.ReSharper.Psi.PsiLanguageType Language { get; }
        public override JetBrains.ReSharper.Psi.Naming.Settings.NamingRule GetDefaultRule() { }
    }
    [JetBrains.ReSharper.Psi.Naming.Interfaces.NamingConsistencyCheckerAttribute(typeof(JetBrains.ReSharper.Psi.JavaScript.LanguageImpl.JavaScriptLanguage))]
    public class JavaScriptNamingConsistencyChecker : JetBrains.ReSharper.Psi.Naming.Interfaces.INamingConsistencyChecker
    {
        public void Check(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration, JetBrains.ReSharper.Psi.Naming.Interfaces.INamingPolicyProvider namingPolicyProvider, out bool isFinalResult, out JetBrains.ReSharper.Psi.Naming.Impl.NamingConsistencyCheckResult result) { }
        public static JetBrains.ReSharper.Psi.Naming.Impl.NamingConsistencyCheckResult GetCheckResult(JetBrains.ReSharper.Psi.Naming.NamingManager namingManager, JetBrains.ReSharper.Psi.Naming.Settings.NamingPolicy policy, string shortName, string ruleName, JetBrains.ReSharper.Psi.Naming.Interfaces.INamingPolicyProvider namingPolicyProvider) { }
        public bool IsApplicable(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
    }
    public class JavaScriptNamingPolicyProvider : JetBrains.ReSharper.Psi.Naming.Impl.CustomRulesBasedPolicyProvider<JetBrains.ReSharper.Psi.JavaScript.Naming.JavaScriptNamingSettingsKey>
    {
        public JavaScriptNamingPolicyProvider(JetBrains.ReSharper.Psi.PsiLanguageType language, JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, JetBrains.Application.Settings.IContextBoundSettingsStore settingsStore) { }
        protected override JetBrains.ReSharper.Psi.Naming.Settings.NamingPolicy UndefinedPolicy { get; }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.JavaScript.LanguageImpl.JavaScriptLanguage))]
    public class JavaScriptNamingPolicyProviderFactory : JetBrains.ReSharper.Psi.Naming.Interfaces.INamingPolicyProviderFactory
    {
        public JavaScriptNamingPolicyProviderFactory(JetBrains.ReSharper.Psi.PsiLanguageType language) { }
        public JetBrains.ReSharper.Psi.Naming.Interfaces.INamingPolicyProvider CreatePolicyProvider(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, JetBrains.Application.Settings.IContextBoundSettingsStore settingsStore) { }
    }
    [JetBrains.Application.Settings.SettingsKeyAttribute(typeof(JetBrains.ReSharper.Psi.Naming.Settings.NamingSettings), "JavaScript naming settings")]
    public class JavaScriptNamingSettingsKey : JetBrains.ReSharper.Psi.Naming.Settings.CustomRulesNamingSettingsKeyBase { }
    [System.ObsoleteAttribute("Deprecated, use JavaScriptNamingSettingsKey")]
    public class JavaScriptNamingStyleSettings : JetBrains.ReSharper.Psi.Naming.Settings.CustomRulesNamingSettingsBase
    {
        public override object Clone() { }
    }
}
namespace JetBrains.ReSharper.Psi.JavaScript.Parsing
{
    
    public interface IJavaScriptParser : JetBrains.ReSharper.Psi.Parsing.IParser
    {
        JetBrains.ReSharper.Psi.JavaScript.Tree.ICompoundExpression ParseCompoundExpression();
        JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression ParseExpression();
        JetBrains.ReSharper.Psi.Tree.IChameleonNode ParseFileSection();
        JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatement ParseStatement();
    }
    public interface IJavaScriptTokenNodeType { }
    public class JavaScriptLexer : JetBrains.ReSharper.Psi.Parsing.FilteringLexerBase
    {
        public JavaScriptLexer(JetBrains.ReSharper.Psi.Parsing.ILexer lexer) { }
        public bool JustSkippedNewLine { get; }
        public static bool IsWhitespace(string s) { }
        protected override bool Skip(JetBrains.ReSharper.Psi.Parsing.TokenNodeType tokenType) { }
        protected override void SkipFilteredTokens() { }
    }
    public class JavaScriptLexerGenerated : JetBrains.ReSharper.Psi.Parsing.IIncrementalLexer, JetBrains.ReSharper.Psi.Parsing.ILexer, JetBrains.ReSharper.Psi.Parsing.ILexerEx
    {
        protected JetBrains.ReSharper.Psi.Parsing.LexerDictionary<JetBrains.ReSharper.Psi.Parsing.TokenNodeType> myKeywords;
        protected JetBrains.ReSharper.Psi.Parsing.LexerDictionary<JetBrains.ReSharper.Psi.Parsing.TokenNodeType> myKeywordsReserved;
        protected bool myMakeDivide;
        protected const int YYINITIAL = 0;
        public JavaScriptLexerGenerated(JetBrains.Text.IBuffer buffer) { }
        public JavaScriptLexerGenerated(JetBrains.Text.IBuffer buffer, int startOffset, int endOffset) { }
        public JetBrains.Text.IBuffer Buffer { get; }
        protected int BufferEnd { set; }
        protected int BufferIndex { get; set; }
        protected int BufferStart { get; set; }
        public virtual object CurrentPosition { get; set; }
        public int EOFPos { get; }
        public int LexemIndent { get; }
        public uint LexerStateEx { get; }
        protected int LexicalState { get; }
        public virtual int TokenEnd { get; }
        public virtual int TokenStart { get; }
        public virtual JetBrains.ReSharper.Psi.Parsing.TokenNodeType TokenType { get; }
        public virtual JetBrains.ReSharper.Psi.Parsing.TokenNodeType _locateToken() { }
        public virtual void Advance() { }
        public bool IsReserved(string name) { }
        public virtual void Start() { }
        public virtual void Start(int startOffset, int endOffset, uint state) { }
    }
    public class JavaScriptLexerImpl : JetBrains.ReSharper.Psi.JavaScript.Parsing.JavaScriptLexerGenerated
    {
        public JavaScriptLexerImpl(JetBrains.Text.IBuffer buffer) { }
        public override JetBrains.ReSharper.Psi.Parsing.TokenNodeType _locateToken() { }
        public static bool IsReservedJavaScriptKeyword(string name) { }
        protected virtual void SetKeywordMaps() { }
    }
    public class JavaScriptQuickParser : JetBrains.ReSharper.Psi.JavaScript.Parsing.IJavaScriptParser, JetBrains.ReSharper.Psi.Parsing.IParser
    {
        protected readonly JetBrains.ReSharper.Psi.Util.CommonIdentifierIntern myIdentifierIntern;
        protected readonly JetBrains.ReSharper.Psi.Parsing.ILexer myLexer;
        protected readonly JetBrains.ReSharper.Psi.TreeBuilder.MarkerListCache myListCache;
        public JavaScriptQuickParser(JetBrains.ReSharper.Psi.Parsing.ILexer lexer, JetBrains.ReSharper.Psi.Util.CommonIdentifierIntern identifierIntern, JetBrains.ReSharper.Psi.TreeBuilder.MarkerListCache listCache) { }
        protected virtual JetBrains.ReSharper.Psi.PsiLanguageType Language { get; }
        protected virtual JetBrains.ReSharper.Psi.JavaScript.Parsing.JavaScriptTreeBuilder CreateTreeBuilder(JetBrains.ReSharper.Psi.Util.ITokenIntern intern, System.Collections.Generic.List<JetBrains.ReSharper.Psi.TreeBuilder.Marker> listFromCache) { }
        public JetBrains.ReSharper.Psi.JavaScript.Tree.ICompoundExpression ParseCompoundExpression() { }
        public JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression ParseExpression() { }
        public JetBrains.ReSharper.Psi.Tree.IFile ParseFile() { }
        public JetBrains.ReSharper.Psi.TreeBuilder.ITreeStructure<JetBrains.ReSharper.Psi.TreeBuilder.PsiBuilderTreeNode> ParseFileAndGetLightPsi() { }
        public JetBrains.ReSharper.Psi.Tree.IChameleonNode ParseFileSection() { }
        public JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatement ParseStatement() { }
    }
    public abstract class JavaScriptTokenBase : JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.LeafElementBase, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptTreeNode, JetBrains.ReSharper.Psi.Tree.ITokenNode, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        public override JetBrains.ReSharper.Psi.PsiLanguageType Language { get; }
        public virtual void Accept(JetBrains.ReSharper.Psi.JavaScript.Tree.TreeNodeVisitor visitor) { }
        public virtual void Accept<TContext>(JetBrains.ReSharper.Psi.JavaScript.Tree.TreeNodeVisitor<TContext> visitor, TContext context) { }
        public virtual TResult Accept<TContext, TResult>(JetBrains.ReSharper.Psi.JavaScript.Tree.TreeNodeVisitor<TContext, TResult> visitor, TContext context) { }
        public override System.Text.StringBuilder GetText(System.Text.StringBuilder to) { }
        public override JetBrains.Text.IBuffer GetTextAsBuffer() { }
        public JetBrains.ReSharper.Psi.Parsing.TokenNodeType GetTokenType() { }
        public override string ToString() { }
    }
    public class JavaScriptTokenType
    {
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType ABSTRACT_KEYWORD_RESERVED;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType ALIEN;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType ALIEN_COMMENT;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType AMPER;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType AMPER2;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType AMPEREQ;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType ARROW;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType ASTERISK;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType AT;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType BAD;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType BOOLEAN_KEYWORD_RESERVED;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType BREAK_KEYWORD;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType BYTE_KEYWORD_RESERVED;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType C_STYLE_COMMENT;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType CAROT;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType CAROTEQ;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType CASE_KEYWORD;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType CATCH_KEYWORD;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType CHAR_KEYWORD_RESERVED;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType CLASS_KEYWORD_RESERVED;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType COLON;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType COMMA;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet COMMENTS_OR_WHITE_SPACES;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType CONST_KEYWORD_RESERVED;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType CONTINUE_KEYWORD;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType DEBUG_KEYWORD;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType DEFAULT_KEYWORD;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType DELETE_KEYWORD;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType DIVIDE;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType DIVIDEEQ;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType DO_KEYWORD;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType DOLLAR;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType DOT;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType DOUBLE_KEYWORD_RESERVED;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType ELLIPSIS;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType ELSE_KEYWORD;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType END_OF_LINE_COMMENT;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType ENUM_KEYWORD_RESERVED;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType EOF;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType EQ;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType EQ2;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType EQ3;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType EXCLAMATION;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType EXPORT_KEYWORD_RESERVED;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType EXTENDS_KEYWORD_RESERVED;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType FALSE_KEYWORD;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType FINAL_KEYWORD_RESERVED;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType FINALLY_KEYWORD;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType FLOAT_KEYWORD_RESERVED;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType FOR_KEYWORD;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType FUNCTION_KEYWORD;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType GENERATED_CODE_SEPARATOR;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType GOTO_KEYWORD_RESERVED;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType GT;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType GT3;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType GT3EQ;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType GTEQ;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType HTML_COMMENT_END;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType HTML_COMMENT_START;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType IDENTIFIER;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType IF_KEYWORD;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType IMPLEMENTS_KEYWORD_RESERVED;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType IMPORT_KEYWORD_RESERVED;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType IN_KEYWORD;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType INSTANCEOF_KEYWORD;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType INT_KEYWORD_RESERVED;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType INTERFACE_KEYWORD_RESERVED;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet KEYWORDS_ES5;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet KEYWORDS_ES6;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet KEYWORDS_RESERVED;
        public const int LAST_TOKEN_TYPE_INDEX = 1128;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType LBRACE;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType LBRACKET;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet LITERALS;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType LONG_KEYWORD_RESERVED;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType LPARENTH;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType LSHIFT;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType LSHIFTEQ;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType LT;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType LTEQ;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType MINUS;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType MINUS2;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType MINUSEQ;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType NATIVE_KEYWORD_RESERVED;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType NEW_KEYWORD;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType NEW_LINE;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType NOTEQ;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType NOTEQ2;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType NULL_KEYWORD;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType NUMERIC_LITERAL;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType PACKAGE_KEYWORD_RESERVED;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType PERCENT;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType PERCENTEQ;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType PIPE;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType PIPE2;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType PIPEEQ;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType PLUS;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType PLUS2;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType PLUSEQ;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType PRIVATE_KEYWORD_RESERVED;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType PROTECTED_KEYWORD_RESERVED;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType PUBLIC_KEYWORD_RESERVED;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType QUESTION;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType RBRACE;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType RBRACKET;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType REGULAR_EXPRESSION_LITERAL;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType RETURN_KEYWORD;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType RPARENTH;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType RSHIFT;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType RSHIFTEQ;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType SEMICOLON;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType SHORT_KEYWORD_RESERVED;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType STAR;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType STATIC_KEYWORD_RESERVED;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType STRING_LITERAL;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType SUPER_KEYWORD_RESERVED;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType SWITCH_KEYWORD;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType SYNCHRONIZED_KEYWORD_RESERVED;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType THIS_KEYWORD;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType THROW_KEYWORD;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType THROWS_KEYWORD_RESERVED;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType TILDE;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType TIMESEQ;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType TRANSIENT_KEYWORD_RESERVED;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType TRUE_KEYWORD;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType TRY_KEYWORD;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType TYPEOF_KEYWORD;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType UNDERSCORE;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType VAR_KEYWORD;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType VOID_KEYWORD;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType VOLATILE_KEYWORD_RESERVED;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType WHILE_KEYWORD;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType WHITE_SPACE;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType WITH_KEYWORD;
        public static bool IsDocComment(JetBrains.Text.IBuffer buffer, JetBrains.ReSharper.Psi.TreeOffset startOffset, JetBrains.ReSharper.Psi.TreeOffset endOffset) { }
        protected class FixedTokenElement : JetBrains.ReSharper.Psi.JavaScript.Parsing.JavaScriptTokenBase
        {
            public FixedTokenElement(JetBrains.ReSharper.Psi.JavaScript.Parsing.JavaScriptTokenType.FixedTokenNodeType keywordTokenNodeType) { }
            public override JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType NodeType { get; }
            public override string GetText() { }
            public override int GetTextLength() { }
        }
        protected class FixedTokenNodeType : JetBrains.ReSharper.Psi.JavaScript.Parsing.JavaScriptTokenType.JavaScriptTokenNodeType
        {
            public FixedTokenNodeType(string s, string representation, int index) { }
            public override JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.LeafElementBase Create(JetBrains.Text.IBuffer buffer, JetBrains.ReSharper.Psi.TreeOffset startOffset, JetBrains.ReSharper.Psi.TreeOffset endOffset) { }
        }
        public abstract class JavaScriptTokenNodeType : JetBrains.ReSharper.Psi.Parsing.TokenNodeType, JetBrains.ReSharper.Psi.JavaScript.Parsing.IJavaScriptTokenNodeType
        {
            protected JavaScriptTokenNodeType(string s, int index, string representation = "") { }
            public override bool IsComment { get; }
            public override bool IsConstantLiteral { get; }
            public override bool IsIdentifier { get; }
            public override bool IsKeyword { get; }
            public override bool IsStringLiteral { get; }
            public override bool IsWhitespace { get; }
            public override string TokenRepresentation { get; }
            public override JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.LeafElementBase Create(JetBrains.Text.IBuffer buffer, JetBrains.ReSharper.Psi.TreeOffset startOffset, JetBrains.ReSharper.Psi.TreeOffset endOffset) { }
        }
        protected class KeywordTokenNodeType : JetBrains.ReSharper.Psi.JavaScript.Parsing.JavaScriptTokenType.FixedTokenNodeType
        {
            public KeywordTokenNodeType(string s, string representation, int index) { }
            public override bool IsKeyword { get; }
        }
    }
    public class JavaScriptTreeBuilder : JetBrains.ReSharper.Psi.TreeBuilder.TreeStructureBuilderBase, JetBrains.ReSharper.Psi.TreeBuilder.IPsiBuilderTokenFactory
    {
        protected JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType ACCESSOR_BODY;
        protected JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType ARRAY_LITERAL;
        protected JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType BINARY_EXPRESSION;
        protected JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType BLOCK;
        protected JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType BREAK_STATEMENT;
        protected JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType CASE_CASE_CLAUSE;
        protected JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType CASE_CLAUSES_LIST;
        protected JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType CATCH_BLOCK;
        protected JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType COMPOUND_EXPRESSION;
        protected JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType CONDITIONAL_TERNARY_EXPRESSION;
        protected JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType CONTINUE_STATEMENT;
        protected JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType DEBUG_STATEMENT;
        protected JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType DEFAULT_CLAUSE;
        protected JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType DO_STATEMENT;
        protected JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType EMPTY_STATEMENT;
        protected JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType EXPRESSION_STATEMENT;
        protected JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType FILE;
        protected JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType FILE_SECTION;
        protected JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType FINALLY_BLOCK;
        protected JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType FOR_DECLARATION_INITIALIZER;
        protected JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType FOR_EXPRESSION_INITIALIZER;
        protected JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType FOR_STATEMENT;
        protected JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType FOREACH_STATEMENT;
        protected JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType FUNCTION_EXPRESSION;
        protected JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType FUNCTION_STATEMENT;
        protected JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType IDENTIFIER_EXPRESSION;
        protected JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType IF_STATEMENT;
        protected JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType INDEX_EXPRESSION;
        protected JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType INVOCATION_EXPRESSION;
        protected JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType JAVA_SCRIPT_PARAMETER_DECLARATION;
        protected JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType JAVA_SCRIPT_PARAMETER_LIST;
        protected JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType LABELLED_STATEMENT;
        protected JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType LITERAL_EXPRESSION;
        protected JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType NEW_EXPRESSION;
        protected JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType OBJECT_LITERAL;
        protected JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType OBJECT_PROPERTIES_LIST;
        protected JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType OBJECT_PROPERTY_ACCESSOR;
        protected JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType OBJECT_PROPERTY_INITIALIZER;
        protected static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet ourExpressionFirst;
        protected static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet ourStatementFirst;
        protected JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType PARENTHESIZED_EXPRESSION;
        protected JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType POSTFIX_EXPRESSION;
        protected JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType PREFIX_EXPRESSION;
        protected JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType PROPERTY_NAME_IDENTIFIER;
        protected JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType PROPERTY_NAME_NUMERIC_LITERAL;
        protected JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType PROPERTY_NAME_STRING_LITERAL;
        protected JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType REFERENCE_EXPRESSION;
        protected JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType RETURN_STATEMENT;
        protected JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType SWITCH_STATEMENT;
        protected JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType THIS_EXPRESSION;
        protected JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType THROW_STATEMENT;
        protected JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType TRY_STATEMENT;
        protected JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType VARIABLE_DECLARATION;
        protected JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType VARIABLE_DECLARATION_LIST;
        protected JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType VARIABLE_STATEMENT;
        protected JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType WHILE_STATEMENT;
        protected JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType WITH_STATEMENT;
        public JavaScriptTreeBuilder(JetBrains.ReSharper.Psi.Parsing.ILexer lexer, JetBrains.ReSharper.Psi.Util.ITokenIntern intern, System.Collections.Generic.List<JetBrains.ReSharper.Psi.TreeBuilder.Marker> listFromCache) { }
        protected virtual JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet AllKeywords { get; }
        protected override JetBrains.ReSharper.Psi.TreeBuilder.PsiBuilder Builder { get; }
        protected override JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet CommentsOrWhiteSpacesTokens { get; }
        protected virtual JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet ExpressionFirst { get; }
        protected virtual JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet JavaScriptLanguageKeywords { get; }
        protected virtual JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet MemberExpressionFirst { get; }
        protected override JetBrains.ReSharper.Psi.Parsing.TokenNodeType NewLine { get; }
        protected virtual JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet ObjectLiteralNameFirst { get; }
        protected virtual JetBrains.ReSharper.Psi.Parsing.TokenNodeType[][] Operators { get; }
        protected virtual JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet StatementFirst { get; }
        protected virtual bool CanBeIdentifier(JetBrains.ReSharper.Psi.Parsing.TokenNodeType tt) { }
        public JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.LeafElementBase CreateToken(JetBrains.ReSharper.Psi.Parsing.TokenNodeType tokenNodeType, JetBrains.Text.IBuffer buffer, int startOffset, int endOffset) { }
        protected override string GetExpectedMessage(string name) { }
        protected virtual void InitElementTypes() { }
        protected new void MarkErrorAndSkipToken(string message) { }
        protected virtual void ParseAccessorSignature() { }
        protected void ParseArgumentListAux(JetBrains.ReSharper.Psi.Parsing.TokenNodeType open, JetBrains.ReSharper.Psi.Parsing.TokenNodeType close) { }
        protected void ParseBlock() { }
        public void ParseCompoundExpression() { }
        protected void ParseDocCommentsAndSkipSpaces() { }
        protected virtual void ParseFunctionExpressionSignature() { }
        protected virtual void ParseFunctionStatement() { }
        protected virtual bool ParseIdentifierExpression() { }
        protected void ParseIdentifierNameExpression() { }
        public void ParseJavaScriptExpression() { }
        public virtual void ParseJavaScriptFile() { }
        public void ParseJavaScriptFileSection() { }
        protected bool ParseMemberExpressionFollows(bool stopAtInvocation) { }
        protected virtual bool ParseMemberExpressionFollowsImpl(bool stopAtInvocation) { }
        protected virtual bool ParseMemberExpressionImpl(bool stopAtInvocation) { }
        protected void ParseObjectLiteral() { }
        protected virtual void ParseParameterDeclaration() { }
        protected void ParseParametersList() { }
        protected virtual void ParseParenthesizedExpression() { }
        protected virtual bool ParsePrefixPostfixExpression() { }
        protected void ParseSemicolon() { }
        public virtual void ParseStatement() { }
        protected virtual void ParseVariableDeclaration(bool canBeKeyword) { }
        protected void ParseVariableDeclarationList(bool canBeAnyKeyword) { }
        protected virtual void ParseVariableStatement() { }
    }
}
namespace JetBrains.ReSharper.Psi.JavaScript.Parsing.TypeScript
{
    
    public class TypeScriptLexer : JetBrains.ReSharper.Psi.JavaScript.Parsing.JavaScriptLexerImpl
    {
        public TypeScriptLexer(JetBrains.Text.IBuffer buffer) { }
        protected override void SetKeywordMaps() { }
    }
    [JetBrains.Annotations.UsedImplicitlyAttribute()]
    public class TypeScriptTokenType : JetBrains.ReSharper.Psi.JavaScript.Parsing.JavaScriptTokenType
    {
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType CLASS_KEYWORD;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType CONSTRUCTOR_KEYWORD;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType DECLARE_KEYWORD;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType ENUM_KEYWORD;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType EXPORT_KEYWORD;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType EXTENDS_KEYWORD;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType IMPLEMENTS_KEYWORD;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType IMPORT_KEYWORD;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType INTERFACE_KEYWORD;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet KEYWORDS_RESERVED_TYPE_SCRIPT;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet KEYWORDS_TYPE_SCRIPT;
        public static readonly JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet KEYWORDS_TYPE_SCRIPT_NEW;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType MODULE_KEYWORD;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType PRIVATE_KEYWORD;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType PUBLIC_KEYWORD;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType STATIC_KEYWORD;
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType SUPER_KEYWORD;
    }
}
namespace JetBrains.ReSharper.Psi.JavaScript.Resolve
{
    
    public class AnnoAssocProvider : JetBrains.ReSharper.Psi.JavaScript.Resolve.ICustomAnnotationRule
    {
        public AnnoAssocProvider(JetBrains.ReSharper.Psi.JavaScript.Resolve.IAnnotationDataProviderWithContext<JetBrains.ReSharper.Psi.JavaScript.Resolve.IJavaScriptType> from, JetBrains.ReSharper.Psi.JavaScript.Resolve.IAnnotationDataProviderWithContext<JetBrains.ReSharper.Psi.JavaScript.Resolve.IJavaScriptType> to, bool allowIdentityLoss, bool hasIdentityLoss) { }
        public JetBrains.ReSharper.Psi.JavaScript.Resolve.IJavaScriptType GetJavaScriptType(JetBrains.ReSharper.Psi.JavaScript.Tree.IInvocationExpression expr, JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsLocalElementResolver context) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.JavaScript.Resolve.AnnotationRuleInfo> GetRules(JetBrains.ReSharper.Psi.JavaScript.Tree.IInvocationExpression expr, JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsLocalElementResolver context) { }
    }
    public class AnnoAssocSeqProvider : JetBrains.ReSharper.Psi.JavaScript.Resolve.ICustomAnnotationRule
    {
        public AnnoAssocSeqProvider(JetBrains.ReSharper.Psi.JavaScript.Resolve.IAnnotationDataProviderWithContext<JetBrains.ReSharper.Psi.JavaScript.Resolve.IJavaScriptType> from, JetBrains.ReSharper.Psi.JavaScript.Resolve.IAnnotationDataProviderWithContext<JetBrains.ReSharper.Psi.JavaScript.Resolve.IJavaScriptType> to, bool allowIdentityLoss, bool hasIdentityLoss) { }
        public JetBrains.ReSharper.Psi.JavaScript.Resolve.IJavaScriptType GetJavaScriptType(JetBrains.ReSharper.Psi.JavaScript.Tree.IInvocationExpression expr, JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsLocalElementResolver context) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.JavaScript.Resolve.AnnotationRuleInfo> GetRules(JetBrains.ReSharper.Psi.JavaScript.Tree.IInvocationExpression expr, JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsLocalElementResolver context) { }
    }
    public class AnnoGlobalTypeProvider : JetBrains.ReSharper.Psi.JavaScript.Resolve.IAnnotationDataProviderWithContext<JetBrains.ReSharper.Psi.JavaScript.Resolve.IJavaScriptType>
    {
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.JavaScript.Resolve.IJavaScriptType> GetValue(JetBrains.ReSharper.Psi.JavaScript.Tree.IInvocationExpression expr, JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsLocalElementResolver context) { }
    }
    public class AnnoNamedPropertyValueProvider : JetBrains.ReSharper.Psi.JavaScript.Resolve.IAnnotationDataProvider<JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression>
    {
        public AnnoNamedPropertyValueProvider(JetBrains.ReSharper.Psi.JavaScript.Resolve.IAnnotationDataProvider<JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression> expressionProvider, string propertyName) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression> GetValue(JetBrains.ReSharper.Psi.JavaScript.Tree.IInvocationExpression expr) { }
    }
    public class AnnoObjectLiteralTypeProvider : JetBrains.ReSharper.Psi.JavaScript.Resolve.IAnnotationDataProviderWithContext<JetBrains.ReSharper.Psi.JavaScript.Resolve.IJavaScriptType>
    {
        public AnnoObjectLiteralTypeProvider(JetBrains.ReSharper.Psi.JavaScript.Resolve.IAnnotationDataProvider<JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression> expression = null, int offset = 0) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.JavaScript.Resolve.IJavaScriptType> GetValue(JetBrains.ReSharper.Psi.JavaScript.Tree.IInvocationExpression expr, JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsLocalElementResolver context) { }
    }
    public class AnnoObjLiteralNamesProvider : JetBrains.ReSharper.Psi.JavaScript.Resolve.IAnnotationDataProvider<JetBrains.Util.Pair<string, int>>
    {
        public AnnoObjLiteralNamesProvider(JetBrains.ReSharper.Psi.JavaScript.Resolve.IAnnotationDataProvider<JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression> expressionProvider) { }
        public System.Collections.Generic.IEnumerable<JetBrains.Util.Pair<string, int>> GetValue(JetBrains.ReSharper.Psi.JavaScript.Tree.IInvocationExpression expr) { }
    }
    public class AnnoObjLiteralValuesProvider : JetBrains.ReSharper.Psi.JavaScript.Resolve.IAnnotationDataProvider<JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression>
    {
        public AnnoObjLiteralValuesProvider(JetBrains.ReSharper.Psi.JavaScript.Resolve.IAnnotationDataProvider<JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression> expressionProvider) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression> GetValue(JetBrains.ReSharper.Psi.JavaScript.Tree.IInvocationExpression expr) { }
    }
    public class AnnoParameterDataProvider : JetBrains.ReSharper.Psi.JavaScript.Resolve.IAnnotationDataProvider<JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression>
    {
        public AnnoParameterDataProvider(int startFrom, int until) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression> GetValue(JetBrains.ReSharper.Psi.JavaScript.Tree.IInvocationExpression expr) { }
    }
    public class AnnoPropertyRegistrationProvider : JetBrains.ReSharper.Psi.JavaScript.Resolve.ICustomAnnotationRule
    {
        public AnnoPropertyRegistrationProvider(JetBrains.ReSharper.Psi.JavaScript.Resolve.IAnnotationDataProviderWithContext<JetBrains.ReSharper.Psi.JavaScript.Resolve.IJavaScriptType> objects, JetBrains.ReSharper.Psi.JavaScript.Resolve.IAnnotationDataProvider<JetBrains.Util.Pair<string, int>> property, bool isAssigned, JetBrains.ReSharper.Psi.JavaScript.Impl.Services.JavaScriptDeclaredElementType elementType, JetBrains.ReSharper.Psi.JavaScript.Resolve.IAnnotationDataProviderWithContext<>[] types) { }
        public JetBrains.ReSharper.Psi.JavaScript.Resolve.IAnnotationDataProviderWithContext<JetBrains.ReSharper.Psi.JavaScript.Resolve.IJavaScriptType> Objects { get; }
        public JetBrains.ReSharper.Psi.JavaScript.Resolve.IAnnotationDataProvider<JetBrains.Util.Pair<string, int>> Property { get; }
        public JetBrains.ReSharper.Psi.JavaScript.Resolve.IJavaScriptType GetJavaScriptType(JetBrains.ReSharper.Psi.JavaScript.Tree.IInvocationExpression expr, JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsLocalElementResolver context) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.JavaScript.Resolve.AnnotationRuleInfo> GetRules(JetBrains.ReSharper.Psi.JavaScript.Tree.IInvocationExpression expr, JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsLocalElementResolver context) { }
    }
    public class AnnoReturnTypeProvider : JetBrains.ReSharper.Psi.JavaScript.Resolve.ICustomAnnotationRule
    {
        public AnnoReturnTypeProvider(JetBrains.ReSharper.Psi.JavaScript.Resolve.IAnnotationDataProviderWithContext<JetBrains.ReSharper.Psi.JavaScript.Resolve.IJavaScriptType> types) { }
        public JetBrains.ReSharper.Psi.JavaScript.Resolve.IJavaScriptType GetJavaScriptType(JetBrains.ReSharper.Psi.JavaScript.Tree.IInvocationExpression expr, JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsLocalElementResolver context) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.JavaScript.Resolve.AnnotationRuleInfo> GetRules(JetBrains.ReSharper.Psi.JavaScript.Tree.IInvocationExpression expr, JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsLocalElementResolver context) { }
    }
    public class AnnoStringDataProvider : JetBrains.ReSharper.Psi.JavaScript.Resolve.IAnnotationDataProvider<JetBrains.Util.Pair<string, int>>
    {
        public AnnoStringDataProvider(JetBrains.ReSharper.Psi.JavaScript.Resolve.IAnnotationDataProvider<JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression> expressionProvider, string format = null) { }
        public JetBrains.ReSharper.Psi.JavaScript.Resolve.IAnnotationDataProvider<JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression> ExpressionProvider { get; }
        public string Format { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.Util.Pair<string, int>> GetValue(JetBrains.ReSharper.Psi.JavaScript.Tree.IInvocationExpression expr) { }
    }
    public class AnnoSymbolByNameProvider : JetBrains.ReSharper.Psi.JavaScript.Resolve.IAnnotationDataProviderWithContext<JetBrains.ReSharper.Psi.JavaScript.Resolve.IJavaScriptType>
    {
        public AnnoSymbolByNameProvider(JetBrains.ReSharper.Psi.JavaScript.Resolve.IAnnotationDataProvider<JetBrains.Util.Pair<string, int>> stringProvider, JetBrains.ReSharper.Psi.JavaScript.Resolve.IAnnotationDataProviderWithContext<JetBrains.ReSharper.Psi.JavaScript.Resolve.IJavaScriptType> types) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.JavaScript.Resolve.IJavaScriptType> GetValue(JetBrains.ReSharper.Psi.JavaScript.Tree.IInvocationExpression expr, JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsLocalElementResolver context) { }
    }
    public struct AnnotationRuleInfo
    {
        public AnnotationRuleInfo(JetBrains.ReSharper.Psi.JavaScript.Resolve.JsRuleType ruleType, JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsPrimitiveTypeDescription keyType, JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsPrimitiveTypeDescription assocType = null, JetBrains.ReSharper.Psi.JavaScript.Impl.Services.JavaScriptDeclaredElementType elementType = null) { }
        public JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsPrimitiveTypeDescription AssocType { get; }
        public JetBrains.ReSharper.Psi.JavaScript.Impl.Services.JavaScriptDeclaredElementType ElementType { get; }
        public JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsPrimitiveTypeDescription KeyType { get; }
        public JetBrains.ReSharper.Psi.JavaScript.Resolve.JsRuleType RuleType { get; }
    }
    public class AnnoThisDataProvider : JetBrains.ReSharper.Psi.JavaScript.Resolve.IAnnotationDataProvider<JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression>
    {
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression> GetValue(JetBrains.ReSharper.Psi.JavaScript.Tree.IInvocationExpression expr) { }
    }
    public class AnnoTypeDataProvider : JetBrains.ReSharper.Psi.JavaScript.Resolve.IAnnotationDataProviderWithContext<JetBrains.ReSharper.Psi.JavaScript.Resolve.IJavaScriptType>
    {
        public AnnoTypeDataProvider(JetBrains.ReSharper.Psi.JavaScript.Resolve.IAnnotationDataProvider<JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression> expressionProvider, bool processStrings = True) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.JavaScript.Resolve.IJavaScriptType> GetValue(JetBrains.ReSharper.Psi.JavaScript.Tree.IInvocationExpression expr, JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsLocalElementResolver context) { }
    }
    public class AnnoTypeDerivativeDataProvider : JetBrains.ReSharper.Psi.JavaScript.Resolve.IAnnotationDataProviderWithContext<JetBrains.ReSharper.Psi.JavaScript.Resolve.IJavaScriptType>
    {
        public AnnoTypeDerivativeDataProvider(JetBrains.ReSharper.Psi.JavaScript.Resolve.IAnnotationDataProviderWithContext<JetBrains.ReSharper.Psi.JavaScript.Resolve.IJavaScriptType> types, JetBrains.ReSharper.Psi.JavaScript.Resolve.PrimitiveType derivativeType, bool allowIdentityLoss = True, int parameterNum = -1) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.JavaScript.Resolve.IJavaScriptType> GetValue(JetBrains.ReSharper.Psi.JavaScript.Tree.IInvocationExpression expr, JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsLocalElementResolver context) { }
    }
    public class CustomFunctionAnnotation
    {
        public CustomFunctionAnnotation(string[] names, JetBrains.Util.Pair<, >[] paramConditions, int minArgNumber, int maxArgNumber, params JetBrains.ReSharper.Psi.JavaScript.Resolve.ICustomAnnotationRule[] rules) { }
        public CustomFunctionAnnotation(string[] names, int minArgNumber, int maxArgNumber, params JetBrains.ReSharper.Psi.JavaScript.Resolve.ICustomAnnotationRule[] rules) { }
        public CustomFunctionAnnotation(string name, int minArgNumber, int maxArgNumber, params JetBrains.ReSharper.Psi.JavaScript.Resolve.ICustomAnnotationRule[] rules) { }
        public int MaxArgNumber { get; }
        public int MinArgNumber { get; }
        public string[][] Names { get; }
        public JetBrains.Util.Pair<, >[] ParamConditions { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.JavaScript.Resolve.ICustomAnnotationRule> Rules { get; }
        public void AddRules(JetBrains.ReSharper.Psi.JavaScript.Tree.IInvocationExpression expr, JetBrains.ReSharper.Psi.JavaScript.Resolve.IJavaScriptCacheBuilderContext context) { }
        public JetBrains.ReSharper.Psi.JavaScript.Resolve.IJavaScriptType GetJavaScriptType(JetBrains.ReSharper.Psi.JavaScript.Tree.IInvocationExpression expr, JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsLocalElementResolver context) { }
        public System.Collections.Generic.IEnumerable<string> GetLastNames() { }
        public bool Match(JetBrains.ReSharper.Psi.JavaScript.Tree.IInvocationExpression expr, JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsLocalElementResolver context, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression invokedExpression, bool resolveThroughLocalVars, bool useResolve) { }
    }
    public class FullJavaScriptType
    {
        public static readonly JetBrains.ReSharper.Psi.JavaScript.Resolve.FullJavaScriptType Empty;
        public bool IsUnknown { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsFinalPrimitiveType> Primitives { get; }
        public JetBrains.ReSharper.Psi.Resolve.ResolveErrorType ResolveStatus { get; }
        public bool StrongTyped { get; }
        public string GetPresentableName() { }
        public JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetProperties(JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.JavaScriptResolveContext context, bool includeReadOnly = True, JetBrains.ReSharper.Psi.IPsiSourceFile exceptSourceFile = null, int exceptOffset = -1) { }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Psi.JavaScript.Resolve.IJavaScriptFunctionSignature> GetSignatures() { }
        public JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetSubTypes(JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.JavaScriptResolveContext context, JetBrains.ReSharper.Psi.IPsiSourceFile exceptSourceFile = null, int exceptOffset = -1) { }
        public bool HasSignatures() { }
        public string ListPrimitives() { }
        public JetBrains.ReSharper.Psi.JavaScript.Caches.JsSimpleDeclaredElementList Resolve(JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.JavaScriptResolveContext context, string name) { }
        public JetBrains.ReSharper.Psi.JavaScript.Caches.JsSimpleDeclaredElementList ResolveType(JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.JavaScriptResolveContext context, string name) { }
        public override string ToString() { }
    }
    public interface IAnnotationDataProvider<TData>
    
    {
        System.Collections.Generic.IEnumerable<TData> GetValue(JetBrains.ReSharper.Psi.JavaScript.Tree.IInvocationExpression expr);
    }
    public interface IAnnotationDataProviderWithContext<TData>
    
    {
        System.Collections.Generic.IEnumerable<TData> GetValue(JetBrains.ReSharper.Psi.JavaScript.Tree.IInvocationExpression expr, JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsLocalElementResolver context);
    }
    public interface ICustomAnnotationRule
    {
        JetBrains.ReSharper.Psi.JavaScript.Resolve.IJavaScriptType GetJavaScriptType(JetBrains.ReSharper.Psi.JavaScript.Tree.IInvocationExpression expr, JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsLocalElementResolver context);
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.JavaScript.Resolve.AnnotationRuleInfo> GetRules(JetBrains.ReSharper.Psi.JavaScript.Tree.IInvocationExpression expr, JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsLocalElementResolver context);
    }
    public interface IDeclarationReference : JetBrains.ReSharper.Psi.JavaScript.Resolve.IJavaScriptCompleteableReference, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.Util.IUserDataHolder
    {
        JetBrains.ReSharper.Psi.JavaScript.Resolve.IJavaScriptType GetJsType(JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsLocalElementResolver context);
    }
    public interface IJavaScriptCacheBuilderContext : JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsDocumentOffsetProvider, JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsLocalElementResolver
    {
        void AddAssocRule(JetBrains.ReSharper.Psi.JavaScript.Resolve.JsRuleType ruleType, JetBrains.ReSharper.Psi.JavaScript.Resolve.JsTypingType typing, JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsPrimitiveTypeDescription keyType, JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsPrimitiveTypeDescription type);
        void AddAssocRule(JetBrains.ReSharper.Psi.JavaScript.Resolve.JsRuleType ruleType, JetBrains.ReSharper.Psi.JavaScript.Resolve.JsTypingType typing, JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsPrimitiveTypeDescription keyType, JetBrains.ReSharper.Psi.JavaScript.Resolve.IJavaScriptType type);
        void AddAssocRule(JetBrains.ReSharper.Psi.JavaScript.Resolve.JsRuleType ruleType, JetBrains.ReSharper.Psi.JavaScript.Resolve.JsTypingType typing, JetBrains.ReSharper.Psi.JavaScript.Resolve.IJavaScriptType keyType, JetBrains.ReSharper.Psi.JavaScript.Resolve.IJavaScriptType type);
        void AddDeclarationInfo(JetBrains.ReSharper.Psi.JavaScript.Resolve.IJavaScriptType keyType, JetBrains.ReSharper.Psi.JavaScript.Impl.Services.JavaScriptDeclaredElementType elementType, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.TsModifiers modifiers);
        void AddDeclarationInfo(JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsPrimitiveTypeDescription keyType, JetBrains.ReSharper.Psi.JavaScript.Impl.Services.JavaScriptDeclaredElementType elementType, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.TsModifiers modifiers);
    }
    public interface IJavaScriptCompleteableReference : JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.Util.IUserDataHolder
    {
        JetBrains.ReSharper.Psi.JavaScript.Resolve.FullJavaScriptType GetParentJsType(JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.JavaScriptResolveContext resolveContext);
        JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetSymbolTableForCompletion(JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.JavaScriptResolveContext resolveContext, bool allProperties = False);
    }
    public interface IJavaScriptFunctionSignature
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.JavaScript.DocComments.IBasicDocSignature DocSignature { get; }
        System.Collections.Generic.IList<JetBrains.ReSharper.Psi.IDeclaredElement> Parameters { get; }
        int ParametersCount { get; }
        JetBrains.ReSharper.Psi.IPsiSourceFile SourceFile { get; }
    }
    public interface IJavaScriptType
    {
        int Count { get; }
        JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsPrimitiveTypeDescription this[int i] { get; }
        JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsPrimitiveTypeDescription PrimitiveTypeDescription { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.JavaScript.Resolve.IJavaScriptType GetDerivedType(JetBrains.ReSharper.Psi.JavaScript.Resolve.PrimitiveType primitiveType, int offset, int parameterIndex = -1, bool allowIdentityLoss = True, JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsInvocationInfo info = null);
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.JavaScript.Resolve.IJavaScriptType GetPropertyReferenceType(string name, int offset);
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.JavaScript.Resolve.IJavaScriptType GetTypeReferenceType(string name, int offset);
        bool IsEmpty();
        JetBrains.ReSharper.Psi.JavaScript.Resolve.IJavaScriptType NoIdentityChange();
    }
    public interface IJsAdditionalTypeInfo { }
    public interface IJsDeclaredElementConsumer
    {
        int Count { get; }
        void Consume(JetBrains.ReSharper.Psi.IDeclaredElement element);
    }
    public interface IJsDocumentOffsetProvider
    {
        JetBrains.ReSharper.Psi.JavaScript.Services.JavaScriptServices JavaScriptServices { get; }
        int GetDocumentStartOffset(JetBrains.ReSharper.Psi.Tree.ITreeNode node);
        int GetDocumentStartOffset(JetBrains.ReSharper.Psi.Tree.ITreeNode node, JetBrains.ReSharper.Psi.TreeTextRange range);
    }
    public interface IJsDynamicPrimitiveType : JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsFinalPrimitiveType, JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsPrimitiveType
    {
        JetBrains.ReSharper.Psi.JavaScript.Resolve.JsPrimitive Primitive { get; }
    }
    public interface IJsExpandablePrimitiveType : JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsPrimitiveType
    {
        JetBrains.ReSharper.Psi.Resolve.ResolveErrorType Expand(JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.JsTypeExpandingContext context, bool shortCut, bool standardTypes, bool expectedTypes, bool strongTyped);
    }
    public interface IJsExternalPrimitiveType : JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsFinalPrimitiveType, JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsPrimitiveType
    {
        JetBrains.ReSharper.Psi.IDeclaredElement GetDeclaredElement();
        string GetName();
    }
    public interface IJsFinalPrimitiveType : JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsPrimitiveType
    {
        void FindAnnotations(System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.JavaScript.Impl.ControlFlow.Inspections.ValueAnalysis.ContractAnnotations.PreparedAnnotation> results, JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.JavaScriptResolveContext context);
        void FindProperties(JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.JavaScriptResolveContext context, bool includeReadOnly, JetBrains.ReSharper.Psi.IPsiSourceFile exceptSourceFile, int exceptOffset, JetBrains.ReSharper.Psi.JavaScript.Resolve.JsSymbolTable result);
        void FindSubTypes(JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.JavaScriptResolveContext context, JetBrains.ReSharper.Psi.IPsiSourceFile exceptSourceFile, int exceptOffset, JetBrains.ReSharper.Psi.JavaScript.Resolve.JsSymbolTable result);
        string GetAnyName();
        string GetPresentableName();
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.JavaScript.Resolve.IJavaScriptFunctionSignature> GetSignatures();
        System.Xml.XmlNode GetXmlDoc(bool inherit);
        bool IsFunction();
        void ProcessDerivedTypes(JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.JavaScriptResolveContext context, JetBrains.ReSharper.Psi.JavaScript.Resolve.PrimitiveType primitiveType, int parameterIndex, bool allowIdentityLoss, object obj, int offset, System.Collections.Generic.IList<JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsFinalPrimitiveType> sourcePrimitives, JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.JsTypeExpandingContext derivedPrimitives, JetBrains.ReSharper.Psi.Resolve.ResolveErrorType resolveStatus);
        void Resolve(JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.JavaScriptResolveContext context, string name, JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsDeclaredElementConsumer result, JetBrains.ReSharper.Psi.JavaScript.Resolve.SymbolType symbolType, System.Collections.Generic.IList<JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsFinalPrimitiveType> sourcePrimitives, JetBrains.ReSharper.Psi.Resolve.ResolveErrorType resolveStatus);
    }
    public interface IJsInvocationInfo : JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsAdditionalTypeInfo { }
    public interface IJsLocalElementResolver : JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsDocumentOffsetProvider
    {
        JetBrains.ReSharper.Psi.IDeclaredElement GetResolvedElement(JetBrains.ReSharper.Psi.JavaScript.Resolve.IReferenceExpressionReference reference, bool returnDynamicProperties);
        bool SmartCache();
    }
    public interface IJsPrimitiveType { }
    public interface IJsPrimitiveTypeDescription : JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsExpandablePrimitiveType, JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsPrimitiveType
    {
        JetBrains.ReSharper.Psi.JavaScript.Resolve.JsPrimitive FirstPrimitive { get; }
        JetBrains.ReSharper.Psi.JavaScript.Resolve.JsPrimitive ParentPrimitive { get; }
        JetBrains.ReSharper.Psi.JavaScript.Resolve.JsPrimitive Primitive { get; }
        bool ContainsGlobalSymbols();
        JetBrains.ReSharper.Psi.JavaScript.Resolve.FullJavaScriptType ExpandIndependently(JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.JavaScriptResolveContext context, bool strongTyped);
        JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsPrimitiveTypeDescription GetDerivedType(JetBrains.ReSharper.Psi.JavaScript.Resolve.PrimitiveType primitiveType, int parameterIndex, bool allowIdentityLoss, JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsInvocationInfo info, int offset = -1);
        JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsPrimitiveTypeDescription GetPropertyReferenceType(string name, bool allowIdentityLoss, int offset = -1);
        JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsPrimitiveTypeDescription GetTypeReferenceType(string name, int offset);
        JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsPrimitiveTypeDescription SetAllowIdentityLoss(bool value);
    }
    public interface IJsResolveContext : JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsDocumentOffsetProvider, JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsLocalElementResolver
    {
        JetBrains.ReSharper.Psi.JavaScript.Caches.IJavaScriptTypeFileCache TypeFileCache { get; }
        JetBrains.ReSharper.Psi.JavaScript.Impl.Services.JavaScriptSourceFilesVisibilityFilter VisibilityFilter { get; }
    }
    public interface IJsRuleProvider
    {
        void AddRules(JetBrains.ReSharper.Psi.JavaScript.Resolve.IJavaScriptCacheBuilderContext context);
    }
    public interface IReferenceExpressionReference : JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IQualifiableReferenceBase, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IReferenceWithGlobalSymbolTable, JetBrains.ReSharper.Psi.JavaScript.Resolve.IJavaScriptCompleteableReference, JetBrains.ReSharper.Psi.JavaScript.Resolve.IReferenceWithContext, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.Util.IUserDataHolder
    {
        bool IsDynamic { get; }
        JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.IReferenceExpressionReferenceOwner Owner { get; }
        JetBrains.ReSharper.Psi.JavaScript.Resolve.IJavaScriptType GetJsType(JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsLocalElementResolver context);
        JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.ResolveResultWithInfo QuickResolve(bool returnDynamicProperties = True);
        JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.ResolveResultWithInfo Resolve(JetBrains.ReSharper.Psi.Resolve.ISymbolTable symbolTable, JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.JavaScriptResolveContext context);
    }
    public interface IReferenceWithContext
    {
        JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.ResolveResultWithInfo Resolve(JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.JavaScriptResolveContext context);
    }
    public class JavaScriptComplexType : JetBrains.ReSharper.Psi.JavaScript.Resolve.IJavaScriptType
    {
        public JavaScriptComplexType(params JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsPrimitiveTypeDescription[] primitives) { }
        public int Count { get; }
        public JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsPrimitiveTypeDescription this[int i] { get; }
        public JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsPrimitiveTypeDescription PrimitiveTypeDescription { get; }
        protected bool Equals(JetBrains.ReSharper.Psi.JavaScript.Resolve.IJavaScriptType other) { }
        public override bool Equals(object obj) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ReSharper.Psi.JavaScript.Resolve.IJavaScriptType GetDerivedType(JetBrains.ReSharper.Psi.JavaScript.Resolve.PrimitiveType primitiveType, int offset, int parameterIndex = -1, bool allowIdentityLoss = True, JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsInvocationInfo info = null) { }
        public override int GetHashCode() { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ReSharper.Psi.JavaScript.Resolve.IJavaScriptType GetPropertyReferenceType(string name, int offset) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ReSharper.Psi.JavaScript.Resolve.IJavaScriptType GetTypeReferenceType(string name, int offset) { }
        public bool IsEmpty() { }
        public JetBrains.ReSharper.Psi.JavaScript.Resolve.IJavaScriptType NoIdentityChange() { }
        public override string ToString() { }
    }
    public class static JavaScriptType
    {
        public static readonly JetBrains.ReSharper.Psi.JavaScript.Resolve.IJavaScriptType Empty;
        public static readonly JetBrains.ReSharper.Psi.JavaScript.Resolve.JsPrimitive GlobalPrimitive;
        public static readonly JetBrains.ReSharper.Psi.JavaScript.Resolve.IJavaScriptType GlobalType;
        public static readonly JetBrains.ReSharper.Psi.JavaScript.Resolve.JsPrimitive GlobalTypePrimitive;
        public static readonly JetBrains.ReSharper.Psi.JavaScript.Resolve.IJavaScriptType GlobalTypeType;
        public static JetBrains.ReSharper.Psi.JavaScript.Resolve.IJavaScriptType CreateCompositeType(params JetBrains.ReSharper.Psi.JavaScript.Resolve.IJavaScriptType[] list) { }
        public static JetBrains.ReSharper.Psi.JavaScript.Resolve.IJavaScriptType CreateCompositeType(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.JavaScript.Resolve.IJavaScriptType> list) { }
        public static JetBrains.ReSharper.Psi.JavaScript.Resolve.IJavaScriptType CreateConstructedFromGlobalType(string name) { }
        public static JetBrains.ReSharper.Psi.JavaScript.Resolve.IJavaScriptType CreatePrimitiveType(JetBrains.ReSharper.Psi.JavaScript.Resolve.JsPrimitive primitive, int offset, bool allowIdentityLoss = True) { }
        public static JetBrains.ReSharper.Psi.JavaScript.Resolve.IJavaScriptType CreateTypeFromArray(JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsPrimitiveTypeDescription[] list) { }
        public static JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsPrimitiveTypeDescription TypeFromPrimitive(JetBrains.ReSharper.Psi.JavaScript.Resolve.JsPrimitive primitive, bool allowIdentityLoss, int offset = -1) { }
    }
    public class static JavaScriptTypeEx
    {
        public static JetBrains.ReSharper.Psi.JavaScript.Resolve.FullJavaScriptType Expand(this JetBrains.ReSharper.Psi.JavaScript.Resolve.IJavaScriptType type, JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.JavaScriptResolveContext context, bool shortCut = False) { }
        public static System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.JavaScript.Impl.ControlFlow.Inspections.ValueAnalysis.ContractAnnotations.PreparedAnnotation> GetAnnotations(this JetBrains.ReSharper.Psi.JavaScript.Resolve.IJavaScriptType type, JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.JavaScriptResolveContext context) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Resolve.IJavaScriptType GetConstructedType(this JetBrains.ReSharper.Psi.JavaScript.Resolve.IJavaScriptType type, JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsInvocationInfo invocationInfo, int offset = -1) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Resolve.IJavaScriptType GetElementType(this JetBrains.ReSharper.Psi.JavaScript.Resolve.IJavaScriptType type, int offset) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Resolve.IJavaScriptType GetParameterType(this JetBrains.ReSharper.Psi.JavaScript.Resolve.IJavaScriptType type, int parameterIndex) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Resolve.IJavaScriptType GetPrototypeType(this JetBrains.ReSharper.Psi.JavaScript.Resolve.IJavaScriptType type, int offset) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Resolve.IJavaScriptType GetReturnType(this JetBrains.ReSharper.Psi.JavaScript.Resolve.IJavaScriptType type, int paramNumber, JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsInvocationInfo invocationInfo) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Resolve.IJavaScriptType GetThisParameterType(this JetBrains.ReSharper.Psi.JavaScript.Resolve.IJavaScriptType type) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsPrimitiveTypeDescription> IteratePrimitives(this JetBrains.ReSharper.Psi.JavaScript.Resolve.IJavaScriptType type) { }
    }
    public class static JsAnnotations
    {
        public static readonly JetBrains.ReSharper.Psi.JavaScript.Resolve.AnnoGlobalTypeProvider Global;
        public static readonly JetBrains.ReSharper.Psi.JavaScript.Resolve.AnnoObjectLiteralTypeProvider ObjectLiteral;
        public static readonly JetBrains.ReSharper.Psi.JavaScript.Resolve.AnnoThisDataProvider This;
        public static JetBrains.ReSharper.Psi.JavaScript.Resolve.AnnoPropertyRegistrationProvider AddProperties(this JetBrains.ReSharper.Psi.JavaScript.Resolve.IAnnotationDataProviderWithContext<JetBrains.ReSharper.Psi.JavaScript.Resolve.IJavaScriptType> to, JetBrains.ReSharper.Psi.JavaScript.Resolve.IAnnotationDataProvider<JetBrains.Util.Pair<string, int>> props, bool isAssigned, JetBrains.ReSharper.Psi.JavaScript.Impl.Services.JavaScriptDeclaredElementType elementType, params JetBrains.ReSharper.Psi.JavaScript.Resolve.IAnnotationDataProviderWithContext<>[] types) { }
        public static JetBrains.ReSharper.Psi.JavaScript.Resolve.AnnoAssocSeqProvider AssocSeqWith(this JetBrains.ReSharper.Psi.JavaScript.Resolve.IAnnotationDataProviderWithContext<JetBrains.ReSharper.Psi.JavaScript.Resolve.IJavaScriptType> from, JetBrains.ReSharper.Psi.JavaScript.Resolve.IAnnotationDataProviderWithContext<JetBrains.ReSharper.Psi.JavaScript.Resolve.IJavaScriptType> to, bool allowIdentityLoss, bool hasIdentityLoss) { }
        public static JetBrains.ReSharper.Psi.JavaScript.Resolve.AnnoAssocProvider AssocWith(this JetBrains.ReSharper.Psi.JavaScript.Resolve.IAnnotationDataProviderWithContext<JetBrains.ReSharper.Psi.JavaScript.Resolve.IJavaScriptType> from, JetBrains.ReSharper.Psi.JavaScript.Resolve.IAnnotationDataProviderWithContext<JetBrains.ReSharper.Psi.JavaScript.Resolve.IJavaScriptType> to, bool allowIdentityLoss, bool hasIdentityLoss) { }
        public static JetBrains.ReSharper.Psi.JavaScript.Resolve.AnnoTypeDerivativeDataProvider Derivative(this JetBrains.ReSharper.Psi.JavaScript.Resolve.IAnnotationDataProviderWithContext<JetBrains.ReSharper.Psi.JavaScript.Resolve.IJavaScriptType> provider, JetBrains.ReSharper.Psi.JavaScript.Resolve.PrimitiveType derivativeType, bool allowIdentityLoss = True, int parNum = -1) { }
        public static JetBrains.ReSharper.Psi.JavaScript.Resolve.AnnoObjectLiteralTypeProvider ObjectLiterals(this JetBrains.ReSharper.Psi.JavaScript.Resolve.IAnnotationDataProvider<JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression> provider) { }
        public static JetBrains.ReSharper.Psi.JavaScript.Resolve.AnnoObjLiteralNamesProvider ObjLiteralNames(this JetBrains.ReSharper.Psi.JavaScript.Resolve.IAnnotationDataProvider<JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression> provider) { }
        public static JetBrains.ReSharper.Psi.JavaScript.Resolve.AnnoObjLiteralValuesProvider ObjLiteralValues(this JetBrains.ReSharper.Psi.JavaScript.Resolve.IAnnotationDataProvider<JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression> provider) { }
        public static JetBrains.ReSharper.Psi.JavaScript.Resolve.AnnoNamedPropertyValueProvider ObjNamedProperty(this JetBrains.ReSharper.Psi.JavaScript.Resolve.IAnnotationDataProvider<JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression> provider, string propertyName) { }
        public static JetBrains.ReSharper.Psi.JavaScript.Resolve.AnnoParameterDataProvider Param(int num) { }
        public static JetBrains.ReSharper.Psi.JavaScript.Resolve.AnnoParameterDataProvider ParamsFrom(int num) { }
        public static JetBrains.ReSharper.Psi.JavaScript.Resolve.AnnoReturnTypeProvider Return(this JetBrains.ReSharper.Psi.JavaScript.Resolve.IAnnotationDataProviderWithContext<JetBrains.ReSharper.Psi.JavaScript.Resolve.IJavaScriptType> provider) { }
        public static JetBrains.ReSharper.Psi.JavaScript.Resolve.AnnoStringDataProvider Strings(this JetBrains.ReSharper.Psi.JavaScript.Resolve.IAnnotationDataProvider<JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression> provider, string format = null) { }
        public static JetBrains.ReSharper.Psi.JavaScript.Resolve.AnnoSymbolByNameProvider SymbolsByName(this JetBrains.ReSharper.Psi.JavaScript.Resolve.IAnnotationDataProvider<JetBrains.Util.Pair<string, int>> provider, JetBrains.ReSharper.Psi.JavaScript.Resolve.IAnnotationDataProviderWithContext<JetBrains.ReSharper.Psi.JavaScript.Resolve.IJavaScriptType> types) { }
        public static JetBrains.ReSharper.Psi.JavaScript.Resolve.AnnoTypeDataProvider Types(this JetBrains.ReSharper.Psi.JavaScript.Resolve.IAnnotationDataProvider<JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression> provider) { }
    }
    public class JsCustomAnnotationDeclarationReferenceOwner : JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.IDeclarationReferenceOwner
    {
        public JsCustomAnnotationDeclarationReferenceOwner(JetBrains.ReSharper.Psi.JavaScript.Tree.IInvocationExpression invocation, string name, int position, JetBrains.ReSharper.Psi.JavaScript.Resolve.AnnoStringDataProvider stringDataProvider, JetBrains.ReSharper.Psi.JavaScript.Resolve.JsPrimitive primitive) { }
        public string DeclaredName { get; }
        public bool IsDynamic { get; }
        public JetBrains.ReSharper.Psi.Tree.ITreeNode OwnerTreeNode { get; }
        public JetBrains.ReSharper.Psi.JavaScript.Resolve.IDeclarationReference Reference { get; }
        public JetBrains.ReSharper.Psi.JavaScript.DeclaredElements.IJavaScriptTypeOwner GetDeclaredElement(JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsDocumentOffsetProvider context) { }
        public JetBrains.ReSharper.Psi.TreeTextRange GetNameRange() { }
        public JetBrains.ReSharper.Psi.JavaScript.Resolve.FullJavaScriptType GetParentJsType(JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.JavaScriptResolveContext resolveContext) { }
        public JetBrains.ReSharper.Psi.JavaScript.Resolve.IJavaScriptType GetParentJsType(JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsDocumentOffsetProvider context) { }
        public JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetSymbolTableForCompletion(JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.JavaScriptResolveContext resolveContext, bool allProperties = False) { }
        public void LogCompletion(JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.JavaScriptResolveContext resolveContext, bool allProperties = False) { }
        public void SetName(string name) { }
    }
    [JetBrains.ReSharper.Psi.PsiComponentAttribute()]
    [JetBrains.ReSharper.Psi.Resolve.ReferenceProviderFactoryAttribute()]
    public class JsCustomAnnotationProvider : JetBrains.ReSharper.Psi.Resolve.IReferenceProviderFactory
    {
        public JsCustomAnnotationProvider() { }
        public event System.Action OnChanged;
        public JetBrains.ReSharper.Psi.JavaScript.Resolve.CustomFunctionAnnotation GetAnnotationFor(JetBrains.ReSharper.Psi.JavaScript.Tree.IInvocationExpression expression, JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsLocalElementResolver context, bool useResolve) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.JavaScript.Resolve.CustomFunctionAnnotation> GetAnnotations() { }
    }
    public class JsCustomAnnotationReferenceProvider : JetBrains.ReSharper.Psi.Resolve.IReferenceFactory
    {
        public JetBrains.ReSharper.Psi.Resolve.IReference[] GetReferences(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.Resolve.IReference[] oldReferences) { }
        public bool HasReference(JetBrains.ReSharper.Psi.Tree.ITreeNode element, System.Collections.Generic.ICollection<string> names) { }
    }
    public class JsDynamicPrimitiveType : JetBrains.ReSharper.Psi.JavaScript.Resolve.JsDynamicPrimitiveTypeBase
    {
        public JsDynamicPrimitiveType(JetBrains.ReSharper.Psi.JavaScript.Resolve.JsPrimitive primitive, bool allowIdentityLoss, JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsAdditionalTypeInfo info = null) { }
        protected override JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsAdditionalTypeInfo AdditionalInfo { get; }
        public override bool AllowIdentityLoss { get; }
        public override JetBrains.ReSharper.Psi.JavaScript.Resolve.JsPrimitive Primitive { get; }
        public override void FindAnnotations(System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.JavaScript.Impl.ControlFlow.Inspections.ValueAnalysis.ContractAnnotations.PreparedAnnotation> results, JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.JavaScriptResolveContext context) { }
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.JavaScript.Resolve.IJavaScriptFunctionSignature> GetSignatures() { }
        public override bool IsFunction() { }
        public override void ProcessDerivedTypes(JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.JavaScriptResolveContext context, JetBrains.ReSharper.Psi.JavaScript.Resolve.PrimitiveType primitiveType, int parameterIndex, bool allowIdentityLoss, object obj, int offset, System.Collections.Generic.IList<JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsFinalPrimitiveType> sourcePrimitives, JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.JsTypeExpandingContext derivedPrimitives, JetBrains.ReSharper.Psi.Resolve.ResolveErrorType resolveStatus) { }
    }
    public abstract class JsDynamicPrimitiveTypeBase : JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsDynamicPrimitiveType, JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsExpandablePrimitiveType, JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsFinalPrimitiveType, JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsPrimitiveType
    {
        protected abstract JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsAdditionalTypeInfo AdditionalInfo { get; }
        public abstract bool AllowIdentityLoss { get; }
        protected virtual bool IsAlwaysDeclared { get; }
        public abstract JetBrains.ReSharper.Psi.JavaScript.Resolve.JsPrimitive Primitive { get; }
        public bool Equals(JetBrains.ReSharper.Psi.JavaScript.Resolve.JsDynamicPrimitiveTypeBase other) { }
        public override bool Equals(object obj) { }
        public virtual JetBrains.ReSharper.Psi.Resolve.ResolveErrorType Expand(JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.JsTypeExpandingContext context, bool shortCut, bool standardTypes, bool expectedTypes, bool strongTyped) { }
        public abstract void FindAnnotations(System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.JavaScript.Impl.ControlFlow.Inspections.ValueAnalysis.ContractAnnotations.PreparedAnnotation> results, JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.JavaScriptResolveContext context);
        public virtual void FindProperties(JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.JavaScriptResolveContext context, bool includeReadOnly, JetBrains.ReSharper.Psi.IPsiSourceFile exceptSourceFile, int exceptOffset, JetBrains.ReSharper.Psi.JavaScript.Resolve.JsSymbolTable result) { }
        public void FindSubTypes(JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.JavaScriptResolveContext context, JetBrains.ReSharper.Psi.IPsiSourceFile exceptSourceFile, int exceptOffset, JetBrains.ReSharper.Psi.JavaScript.Resolve.JsSymbolTable result) { }
        public string GetAnyName() { }
        public override int GetHashCode() { }
        public string GetPresentableName() { }
        public abstract System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.JavaScript.Resolve.IJavaScriptFunctionSignature> GetSignatures();
        public System.Xml.XmlNode GetXmlDoc(bool inherit) { }
        public abstract bool IsFunction();
        public virtual void ProcessDerivedTypes(JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.JavaScriptResolveContext context, JetBrains.ReSharper.Psi.JavaScript.Resolve.PrimitiveType primitiveType, int parameterIndex, bool allowIdentityLoss, object obj, int offset, System.Collections.Generic.IList<JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsFinalPrimitiveType> sourcePrimitives, JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.JsTypeExpandingContext derivedPrimitives, JetBrains.ReSharper.Psi.Resolve.ResolveErrorType resolveStatus) { }
        public virtual void Resolve(JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.JavaScriptResolveContext context, string name, JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsDeclaredElementConsumer result, JetBrains.ReSharper.Psi.JavaScript.Resolve.SymbolType symbolType, System.Collections.Generic.IList<JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsFinalPrimitiveType> sourcePrimitives, JetBrains.ReSharper.Psi.Resolve.ResolveErrorType resolveStatus) { }
        public JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsExpandablePrimitiveType SetAllowIdentityLoss(bool value) { }
        public override string ToString() { }
    }
    public class JsGlobalPrimitiveType : JetBrains.ReSharper.Psi.JavaScript.Resolve.JsDynamicPrimitiveTypeBase
    {
        public JsGlobalPrimitiveType(JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.JavaScriptResolveContext context) { }
        protected override JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsAdditionalTypeInfo AdditionalInfo { get; }
        public override bool AllowIdentityLoss { get; }
        protected override bool IsAlwaysDeclared { get; }
        public override JetBrains.ReSharper.Psi.JavaScript.Resolve.JsPrimitive Primitive { get; }
        public override JetBrains.ReSharper.Psi.Resolve.ResolveErrorType Expand(JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.JsTypeExpandingContext context, bool shortCut, bool standardTypes, bool expectedTypes, bool strongTyped) { }
        public override void FindAnnotations(System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.JavaScript.Impl.ControlFlow.Inspections.ValueAnalysis.ContractAnnotations.PreparedAnnotation> results, JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.JavaScriptResolveContext context) { }
        public override void FindProperties(JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.JavaScriptResolveContext context, bool includeReadOnly, JetBrains.ReSharper.Psi.IPsiSourceFile exceptSourceFile, int exceptOffset, JetBrains.ReSharper.Psi.JavaScript.Resolve.JsSymbolTable result) { }
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.JavaScript.Resolve.IJavaScriptFunctionSignature> GetSignatures() { }
        public override bool IsFunction() { }
        public override void ProcessDerivedTypes(JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.JavaScriptResolveContext context, JetBrains.ReSharper.Psi.JavaScript.Resolve.PrimitiveType primitiveType, int parameterIndex, bool allowIdentityLoss, object obj, int offset, System.Collections.Generic.IList<JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsFinalPrimitiveType> sourcePrimitives, JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.JsTypeExpandingContext derivedPrimitives, JetBrains.ReSharper.Psi.Resolve.ResolveErrorType resolveStatus) { }
        public override void Resolve(JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.JavaScriptResolveContext context, string name, JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsDeclaredElementConsumer result, JetBrains.ReSharper.Psi.JavaScript.Resolve.SymbolType symbolType, System.Collections.Generic.IList<JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsFinalPrimitiveType> sourcePrimitives, JetBrains.ReSharper.Psi.Resolve.ResolveErrorType resolveStatus) { }
    }
    public class JsInfoWithParentPrimitives : System.Collections.Generic.HashSet<JetBrains.ReSharper.Psi.JavaScript.Resolve.JsPrimitive>, JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsAdditionalTypeInfo
    {
        public JsInfoWithParentPrimitives([JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.JavaScript.Resolve.JsPrimitive> collection) { }
        public string ListPrimitives() { }
    }
    public struct JsPrimitive : JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsAdditionalTypeInfo, System.IEquatable<JetBrains.ReSharper.Psi.JavaScript.Resolve.JsPrimitive>
    {
        public JsPrimitive(JetBrains.ReSharper.Psi.JavaScript.Resolve.JsPrimitiveInfo info, JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
        public JsPrimitive(JetBrains.ReSharper.Psi.JavaScript.Resolve.PrimitiveType primitiveType, string name, int offset, JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
        public JsPrimitive(JetBrains.ReSharper.Psi.JavaScript.Resolve.JsPrimitive basePrimitive, JetBrains.ReSharper.Psi.JavaScript.Resolve.PrimitiveType derivedType, int parameterIndex = -1) { }
        public JetBrains.ReSharper.Psi.JavaScript.Resolve.JsPrimitive BasePrimitive { get; }
        public JetBrains.ReSharper.Psi.JavaScript.Resolve.PrimitiveType BasePrimitiveType { get; }
        public JetBrains.ReSharper.Psi.JavaScript.Resolve.JsPrimitiveInfo Info { get; }
        public bool IsDerived { get; }
        public string Name { get; }
        public JetBrains.ReSharper.Psi.Tree.ITreeNode Node { get; }
        public int Offset { get; }
        public int ParameterIndex { get; }
        public JetBrains.ReSharper.Psi.JavaScript.Resolve.PrimitiveType PrimitiveType { get; }
        public JetBrains.ReSharper.Psi.IPsiSourceFile SourceFile { get; }
        public static JetBrains.ReSharper.Psi.JavaScript.Resolve.JsPrimitive CreateGlobalPrimitive(string name) { }
        public static JetBrains.ReSharper.Psi.JavaScript.Resolve.JsPrimitive CreatePrimitiveForConstructedFromGlobalType(string name) { }
        public bool Equals(JetBrains.ReSharper.Psi.JavaScript.Resolve.JsPrimitive other) { }
        public override bool Equals(object obj) { }
        public bool EqualsWithOtherData(JetBrains.ReSharper.Psi.JavaScript.Resolve.JsPrimitive other) { }
        public override int GetHashCode() { }
        [JetBrains.Annotations.PureAttribute()]
        public string GetPresentableName() { }
        public string GetShortString() { }
        public override string ToString() { }
    }
    public struct JsPrimitiveInfo : System.IEquatable<JetBrains.ReSharper.Psi.JavaScript.Resolve.JsPrimitiveInfo>
    {
        public JsPrimitiveInfo(uint typeCode, int offset, string name) { }
        public JsPrimitiveInfo(JetBrains.ReSharper.Psi.JavaScript.Resolve.PrimitiveType primitiveType, int offset, string name) { }
        public string Name { get; set; }
        public int Offset { get; set; }
        public JetBrains.ReSharper.Psi.JavaScript.Resolve.PrimitiveType PrimaryType { get; }
        public JetBrains.ReSharper.Psi.JavaScript.Resolve.PrimitiveType PrimitiveType { get; }
        public uint TypeCode { get; set; }
        public bool Equals(JetBrains.ReSharper.Psi.JavaScript.Resolve.JsPrimitiveInfo other) { }
        public override bool Equals(object obj) { }
        public bool EqualsWithOtherData(JetBrains.ReSharper.Psi.JavaScript.Resolve.JsPrimitiveInfo other) { }
        public override int GetHashCode() { }
        public static JetBrains.ReSharper.Psi.JavaScript.Resolve.PrimitiveType GetPrimaryType(uint typeCode) { }
        public static JetBrains.ReSharper.Psi.JavaScript.Resolve.PrimitiveType GetPrimitiveType(uint typeCode) { }
    }
    public abstract class JsPrimitiveTypeDescription : JetBrains.ReSharper.Psi.JavaScript.Resolve.IJavaScriptType, JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsExpandablePrimitiveType, JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsPrimitiveType, JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsPrimitiveTypeDescription
    {
        public const byte AllowIdentityLossMask = 1;
        public const byte HasInfoMask = 128;
        public const byte HasParamNumMask = 64;
        public const int LocalOffsetSize = 4;
        protected readonly byte[] myData;
        protected readonly JetBrains.ReSharper.Psi.IPsiSourceFile myFile;
        protected readonly object[] myPtrs;
        public const int ParameterSize = 1;
        public const byte PrimitiveTypeMask = 63;
        public const int PrimitiveTypeSize = 1;
        public const int ServiceBytesSize = 2;
        protected JsPrimitiveTypeDescription(JetBrains.ReSharper.Psi.IPsiSourceFile file, byte[] data, object[] ptrs) { }
        public bool AllowIdentityLoss { get; }
        public int Count { get; }
        public byte[] Data { get; }
        protected abstract int FirstDataPos { get; }
        public JetBrains.ReSharper.Psi.JavaScript.Resolve.JsPrimitive FirstPrimitive { get; }
        protected abstract int FirstPtrsPos { get; }
        public JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsPrimitiveTypeDescription this[int i] { get; }
        public JetBrains.ReSharper.Psi.JavaScript.Resolve.JsPrimitive ParentPrimitive { get; }
        public JetBrains.ReSharper.Psi.JavaScript.Resolve.JsPrimitive Primitive { get; }
        public JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsPrimitiveTypeDescription PrimitiveTypeDescription { get; }
        public object[] Ptrs { get; }
        public bool ContainsGlobalSymbols() { }
        public bool Equals(JetBrains.ReSharper.Psi.JavaScript.Resolve.JsPrimitiveTypeDescription other) { }
        public override bool Equals(object obj) { }
        public JetBrains.ReSharper.Psi.Resolve.ResolveErrorType Expand(JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.JsTypeExpandingContext context, bool shortCut, bool standardTypes, bool expectedTypes, bool strongTyped) { }
        public JetBrains.ReSharper.Psi.JavaScript.Resolve.FullJavaScriptType ExpandIndependently(JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.JavaScriptResolveContext context, bool strongTyped) { }
        public abstract JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsPrimitiveTypeDescription GetDerivedType(JetBrains.ReSharper.Psi.JavaScript.Resolve.PrimitiveType primitiveType, int parameterIndex, bool allowIdentityLoss, JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsInvocationInfo info, int offset = -1);
        public JetBrains.ReSharper.Psi.JavaScript.Resolve.IJavaScriptType GetDerivedType(JetBrains.ReSharper.Psi.JavaScript.Resolve.PrimitiveType primitiveType, int offset, int parameterIndex = -1, bool allowIdentityLoss = True, JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsInvocationInfo info = null) { }
        public override int GetHashCode() { }
        protected virtual int GetOffset() { }
        public JetBrains.ReSharper.Psi.JavaScript.Resolve.IJavaScriptType GetPropertyReferenceType(string name, int offset) { }
        public abstract JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsPrimitiveTypeDescription GetPropertyReferenceType(string name, bool allowIdentityLoss, int offset = -1);
        public abstract JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsPrimitiveTypeDescription GetTypeReferenceType(string name, int offset);
        public bool IsEmpty() { }
        public JetBrains.ReSharper.Psi.JavaScript.Resolve.IJavaScriptType NoIdentityChange() { }
        protected void ReadPrimitive(ref int dataPos, ref int ptrPos, out JetBrains.ReSharper.Psi.JavaScript.Resolve.PrimitiveType p, out int paramNum, out object info, out int offset) { }
        protected void ReadPrimitive(ref int dataPos, ref int ptrPos, ref JetBrains.ReSharper.Psi.JavaScript.Resolve.JsPrimitive primitive) { }
        public JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsPrimitiveTypeDescription SetAllowIdentityLoss(bool value) { }
        public override string ToString() { }
    }
    public class JsPrimitiveTypeDescriptionFromCache : JetBrains.ReSharper.Psi.JavaScript.Resolve.JsPrimitiveTypeDescription
    {
        public JsPrimitiveTypeDescriptionFromCache(JetBrains.ReSharper.Psi.IPsiSourceFile file, byte[] data, object[] ptrs, int dataPos, int ptrsPos) { }
        protected override int FirstDataPos { get; }
        protected override int FirstPtrsPos { get; }
        public override JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsPrimitiveTypeDescription GetDerivedType(JetBrains.ReSharper.Psi.JavaScript.Resolve.PrimitiveType primitiveType, int parameterIndex, bool allowIdentityLoss, JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsInvocationInfo info, int offset = -1) { }
        public override JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsPrimitiveTypeDescription GetPropertyReferenceType(string name, bool allowIdentityLoss, int offset = -1) { }
        public override JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsPrimitiveTypeDescription GetTypeReferenceType(string name, int offset) { }
    }
    public class JsPrimitiveTypeDescriptionStandalone : JetBrains.ReSharper.Psi.JavaScript.Resolve.JsPrimitiveTypeDescription
    {
        public JsPrimitiveTypeDescriptionStandalone(JetBrains.ReSharper.Psi.IPsiSourceFile file, byte[] data, object[] ptrs, int offset) { }
        protected override int FirstDataPos { get; }
        protected override int FirstPtrsPos { get; }
        public int Offset { get; }
        public override JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsPrimitiveTypeDescription GetDerivedType(JetBrains.ReSharper.Psi.JavaScript.Resolve.PrimitiveType primitiveType, int parameterIndex, bool allowIdentityLoss, JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsInvocationInfo info, int offset = -1) { }
        protected override int GetOffset() { }
        public override JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsPrimitiveTypeDescription GetPropertyReferenceType(string name, bool allowIdentityLoss, int offset = -1) { }
        public override JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsPrimitiveTypeDescription GetTypeReferenceType(string name, int offset) { }
    }
    public class JsPrimitiveTypeList : System.Collections.Generic.List<JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsPrimitiveType>
    {
        public JsPrimitiveTypeList([JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsPrimitiveType> collection) { }
        public override string ToString() { }
    }
    public class JsResolveErrorType : JetBrains.ReSharper.Psi.Resolve.ResolveErrorType
    {
        public static readonly JetBrains.ReSharper.Psi.JavaScript.Resolve.JsResolveErrorType HIGH_CONFIDENCE_ERROR;
        public static readonly JetBrains.ReSharper.Psi.JavaScript.Resolve.JsResolveErrorType MAYBE_ERROR;
        public static readonly JetBrains.ReSharper.Psi.JavaScript.Resolve.JsResolveErrorType NOT_ENOUGH_INFO;
        public static readonly JetBrains.ReSharper.Psi.JavaScript.Resolve.JsResolveErrorType PARENT_NOT_RESOLVED;
        public static readonly JetBrains.ReSharper.Psi.JavaScript.Resolve.JsResolveErrorType STRICT_NOT_RESOLVED;
        protected JsResolveErrorType(string name) { }
    }
    public class static JsResolveErrorTypeExtensions
    {
        public static bool IsResolvedOk(this JetBrains.ReSharper.Psi.Resolve.ResolveErrorType status) { }
        public static bool IsResolvedWithStrictError(this JetBrains.ReSharper.Psi.Resolve.ResolveErrorType status) { }
    }
    public enum JsRuleType
    {
        Unknown = 0,
        ReadOnly = 1,
        Modification = 2,
        Assignment = 3,
        Declaration = 4,
    }
    public class JsSymbolTable : JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.SymbolTableBase, JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsDeclaredElementConsumer
    {
        public JsSymbolTable(JetBrains.ReSharper.Psi.JavaScript.Services.JavaScriptServices jsServices, int capacity = 0, JetBrains.ReSharper.Psi.Dependencies.ISymbolTableDependencySet dependencySet = null) { }
        public int Count { get; }
        public void AddOrChangeSymbol(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, string alias = null) { }
        public void AddSymbol(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, string alias = null) { }
        public void Consume(JetBrains.ReSharper.Psi.IDeclaredElement element) { }
        public bool Contains(string name) { }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Psi.IDeclaredElement> DeclaredElementsByName(string name) { }
        public override void ForAllSymbolInfos(System.Action<JetBrains.ReSharper.Psi.Resolve.ISymbolInfo> processor) { }
        public override JetBrains.ReSharper.Psi.Dependencies.ISymbolTableDependencySet GetDependencySet() { }
        public override System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Resolve.ISymbolInfo> GetSymbolInfos(string name) { }
        public override System.Collections.Generic.IEnumerable<string> Names() { }
    }
    public enum JsTypingType
    {
        Dynamic = 0,
        ImplicitTyping = 1,
        ExplicitTyping = 2,
    }
    public class NoCheck : JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsAdditionalTypeInfo
    {
        public static JetBrains.ReSharper.Psi.JavaScript.Resolve.NoCheck Instance;
    }
    public enum PrimitiveType
    {
        Unknown = 16,
        GlobalSymbol = 17,
        LocalSymbol = 18,
        Function = 19,
        ObjectLiteral = 20,
        ArrayLiteral = 21,
        Type = 22,
        LocalType = 23,
        ExportedScope = 24,
        LocalScope = 25,
        Parameter = 10,
        Constructed = 11,
        Prototype = 12,
        ThisParameter = 13,
        Returned = 14,
        ElementType = 15,
    }
    public struct PrimitiveTypeBuilder
    {
        public void AddPrimitive(JetBrains.ReSharper.Psi.JavaScript.Resolve.JsPrimitive p, bool atStart, JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsInvocationInfo info = null) { }
        public JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsPrimitiveTypeDescription Build(bool allowIdentityLoss = True, int offset = -1) { }
    }
    public class static PrimitiveTypeExtensions
    {
        public static JetBrains.ReSharper.Psi.JavaScript.Resolve.JsPrimitive GetTypeParent(this JetBrains.ReSharper.Psi.JavaScript.Resolve.JsPrimitive primitive) { }
        public static JetBrains.ReSharper.Psi.JavaScript.Resolve.JsPrimitive GetTypeReferenceType(this JetBrains.ReSharper.Psi.JavaScript.Resolve.JsPrimitive primitive, string name) { }
        public static bool HasName(this JetBrains.ReSharper.Psi.JavaScript.Resolve.PrimitiveType type) { }
        public static bool IsDerived(this JetBrains.ReSharper.Psi.JavaScript.Resolve.PrimitiveType type) { }
        public static bool IsLocal(this JetBrains.ReSharper.Psi.JavaScript.Resolve.PrimitiveType type) { }
        public static bool IsScope(this JetBrains.ReSharper.Psi.JavaScript.Resolve.PrimitiveType type) { }
        public static bool IsType(this JetBrains.ReSharper.Psi.JavaScript.Resolve.PrimitiveType type) { }
        public static JetBrains.ReSharper.Psi.JavaScript.Resolve.SymbolType ToSymbolType(this JetBrains.ReSharper.Psi.JavaScript.Resolve.PrimitiveType type) { }
    }
    public class static ResolveConstants
    {
        public const string COMPLETION_INSERTS = "__";
    }
    public enum SymbolType
    {
        JsSymbol = 0,
        TypeScriptType = 1,
        NotConvertableToSymbolType = 100,
    }
}
namespace JetBrains.ReSharper.Psi.JavaScript.Resolve.TypeScript
{
    
    public interface IModuleNameReference : JetBrains.ReSharper.Psi.JavaScript.Resolve.IJavaScriptCompleteableReference, JetBrains.ReSharper.Psi.JavaScript.Resolve.IReferenceWithContext, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.Util.IUserDataHolder
    {
        bool IsDynamic { get; }
        bool IsQualified { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsReferenceName Owner { get; }
        JetBrains.ReSharper.Psi.JavaScript.Resolve.IJavaScriptType GetJsType(JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsLocalElementResolver context);
    }
    public class static TsResolveUtil
    {
        public static void AddScopeToPossibleParentList(System.Collections.Generic.IList<JetBrains.ReSharper.Psi.JavaScript.Resolve.JsPrimitive> expandedPrimitives, System.Collections.Generic.List<JetBrains.ReSharper.Psi.JavaScript.Resolve.JsPrimitive> possibleParents, JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, int offset, string name, bool isExported) { }
    }
}
namespace JetBrains.ReSharper.Psi.JavaScript.Resources
{
    
    public sealed class PsiJavaScriptThemedIcons
    {
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Psi.JavaScript;component/resources/PsiJavaScriptThemedIcons/T" +
            "hemedIcons.PsiJavaScript.Generated.Xaml", 6, "Js")]
        public sealed class Js : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Psi.JavaScript;component/resources/PsiJavaScriptThemedIcons/T" +
            "hemedIcons.PsiJavaScript.Generated.Xaml", 2, "JsFunction")]
        public sealed class JsFunction : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Psi.JavaScript;component/resources/PsiJavaScriptThemedIcons/T" +
            "hemedIcons.PsiJavaScript.Generated.Xaml", 0, "JsLabel")]
        public sealed class JsLabel : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Psi.JavaScript;component/resources/PsiJavaScriptThemedIcons/T" +
            "hemedIcons.PsiJavaScript.Generated.Xaml", 4, "JsMsAjaxNs")]
        public sealed class JsMsAjaxNs : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Psi.JavaScript;component/resources/PsiJavaScriptThemedIcons/T" +
            "hemedIcons.PsiJavaScript.Generated.Xaml", 7, "JsParameter")]
        public sealed class JsParameter : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Psi.JavaScript;component/resources/PsiJavaScriptThemedIcons/T" +
            "hemedIcons.PsiJavaScript.Generated.Xaml", 5, "JsProperty")]
        public sealed class JsProperty : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Psi.JavaScript;component/resources/PsiJavaScriptThemedIcons/T" +
            "hemedIcons.PsiJavaScript.Generated.Xaml", 3, "JsVariable")]
        public sealed class JsVariable : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Psi.JavaScript;component/resources/PsiJavaScriptThemedIcons/T" +
            "hemedIcons.PsiJavaScript.Generated.Xaml", 1, "TypeScript")]
        public sealed class TypeScript : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
    }
}
namespace JetBrains.ReSharper.Psi.JavaScript.Services
{
    
    public interface IJavaScriptCodeFormatter : JetBrains.ReSharper.Psi.CodeStyle.ICodeFormatter
    {
        void Format(JetBrains.ReSharper.Psi.Tree.ITreeNode root, JetBrains.ReSharper.Psi.JavaScript.CodeStyle.JavaScriptFormatProfile profile, JetBrains.Application.Progress.IProgressIndicator progressIndicator, JetBrains.Application.Settings.IContextBoundSettingsStore overrideSettingsStore = null);
        void Format(JetBrains.ReSharper.Psi.Tree.ITreeNode firstElement, JetBrains.ReSharper.Psi.Tree.ITreeNode lastElement, JetBrains.ReSharper.Psi.JavaScript.CodeStyle.JavaScriptFormatProfile profile, JetBrains.Application.Progress.IProgressIndicator progressIndicator, JetBrains.Application.Settings.IContextBoundSettingsStore overrideSettingsStore = null);
        void FormatDocComment(JetBrains.ReSharper.Psi.Tree.IDocCommentBlockNode docCommentBlock);
        JetBrains.ReSharper.Psi.JavaScript.CodeStyle.JavaScriptFormatProfile GetProfile(JetBrains.ReSharper.Psi.CodeStyle.CodeFormatProfile profile);
    }
    public interface IJavaScriptDependencyManager
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.IPsiSourceFile> GetDependencies(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile);
        [JetBrains.Annotations.CanBeNullAttribute()]
        System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.IPsiSourceFile> GetTransitiveDependencies(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile);
    }
    public interface IJavaScriptSignaturesResolver
    {
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.JavaScript.Resolve.IJavaScriptFunctionSignature> FilterSignatures(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.JavaScript.Resolve.IJavaScriptFunctionSignature> signatures);
    }
    public interface IJavaScriptSymbolResolver
    {
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.JavaScript.Caches.IJavaScriptSymbol> FilterSymbols(System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.JavaScript.Caches.IJavaScriptSymbol> symbols);
    }
    public abstract class JavaScriptElementFactory
    {
        public JetBrains.ProjectModel.ISolution Solution { get; set; }
        [JetBrains.Annotations.NotNullAttribute()]
        public abstract JetBrains.ReSharper.Psi.JavaScript.Tree.IBlock CreateBlock([JetBrains.Annotations.NotNullAttribute()] string format, params object[] args);
        [JetBrains.Annotations.NotNullAttribute()]
        public abstract JetBrains.ReSharper.Psi.JavaScript.Tree.ICompoundExpression CreateCompound(string format, params object[] args);
        public abstract JetBrains.ReSharper.Psi.JavaScript.Impl.Tree.IDocCommentNode CreateDocComment(string second);
        [JetBrains.Annotations.NotNullAttribute()]
        public abstract JetBrains.ReSharper.Psi.JavaScript.Tree.IBlock CreateEmptyBlock();
        [JetBrains.Annotations.NotNullAttribute()]
        public abstract JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression CreateExpression(string format, params object[] args);
        [JetBrains.Annotations.NotNullAttribute()]
        public abstract JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptFile CreateFile(string format, params object[] args);
        [JetBrains.Annotations.NotNullAttribute()]
        public abstract JetBrains.ReSharper.Psi.JavaScript.Tree.IForInitializer CreateForExpressionInitializer([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression expression);
        [JetBrains.Annotations.NotNullAttribute()]
        public abstract JetBrains.ReSharper.Psi.JavaScript.Tree.IForInitializer CreateForInitializer(string format, params object[] args);
        public abstract JetBrains.ReSharper.Psi.JavaScript.Tree.IIdentifierExpression CreateIdentifierExpression(string name);
        public abstract JetBrains.ReSharper.Psi.JavaScript.Tree.IIdentifierExpression CreateIdentifierExpressionExpectKeyword(string name);
        [JetBrains.Annotations.NotNullAttribute()]
        public abstract JetBrains.ReSharper.Psi.JavaScript.Tree.IObjectPropertyAccessor CreateObjectPropertyAccessor(JetBrains.ReSharper.Psi.JavaScript.Tree.AccessorKind kind, string name);
        [JetBrains.Annotations.NotNullAttribute()]
        public abstract JetBrains.ReSharper.Psi.JavaScript.Tree.IObjectPropertyInitializer CreateObjectPropertyInitializer(string name, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression expression);
        [JetBrains.Annotations.NotNullAttribute()]
        public abstract JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptParameterDeclaration CreateParameterDeclaration(string name);
        [JetBrains.Annotations.NotNullAttribute()]
        public abstract JetBrains.ReSharper.Psi.JavaScript.Tree.IPropertyName CreatePropertyName(string name);
        [JetBrains.Annotations.NotNullAttribute()]
        public abstract JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatement CreateStatement(string format, params object[] args);
        public static JetBrains.ReSharper.Psi.JavaScript.Services.JavaScriptElementFactory GetInstance([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Modules.IPsiModule psiModule, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.PsiLanguageType language) { }
        public static JetBrains.ReSharper.Psi.JavaScript.Services.JavaScriptElementFactory GetInstance([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Modules.IPsiModule psiModule, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.PsiLanguageType language, bool applyCodeFormatter) { }
        public static JetBrains.ReSharper.Psi.JavaScript.Services.JavaScriptElementFactory GetInstance([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode context) { }
        public static JetBrains.ReSharper.Psi.JavaScript.Services.JavaScriptElementFactory GetInstance([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode context, bool applyCodeFormatter) { }
    }
    [JetBrains.ReSharper.Psi.PsiComponentAttribute()]
    public class JavaScriptServices
    {
        public JavaScriptServices(JetBrains.ReSharper.Psi.IPsiServices psiServices, JetBrains.ReSharper.Psi.JavaScript.Services.IJavaScriptSignaturesResolver signaturesResolver, JetBrains.ReSharper.Psi.Web.Services.ISourceFilesResolver sourceFilesResolver, JetBrains.ReSharper.Psi.JavaScript.Services.IJavaScriptSymbolResolver symbolResolver, JetBrains.ReSharper.Psi.JavaScript.Services.IJavaScriptDependencyManager dependencyManager, JetBrains.ReSharper.Psi.JavaScript.Impl.Services.IJavaScriptSymbolVisibilityManager symbolVisibilityManager, JetBrains.ReSharper.Psi.JavaScript.Impl.Services.IJavaScriptSourceFilesVisibilityManager scriptSourceFilesVisibilityManager, JetBrains.ReSharper.Psi.JavaScript.DeclaredElements.IJavaScriptSymbolInfoService symbolInfoService, JetBrains.ReSharper.Psi.JavaScript.Caches.IJavaScriptTypeCache typeCache, JetBrains.Application.Settings.ISettingsOptimization settingsOptimization, JetBrains.ReSharper.Psi.LanguageManager languageManager) { }
        public JetBrains.ReSharper.Psi.JavaScript.Services.IJavaScriptDependencyManager DependencyManager { get; }
        public JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsResolveContext EmptyContext { get; }
        public JetBrains.ReSharper.Psi.IPsiServices PsiServices { get; }
        public JetBrains.ReSharper.Psi.JavaScript.Impl.Services.IJavaScriptSourceFilesVisibilityManager ScriptSourceFilesVisibilityManager { get; }
        public JetBrains.Application.Settings.ISettingsOptimization SettingsOptimization { get; }
        public JetBrains.ReSharper.Psi.JavaScript.Services.IJavaScriptSignaturesResolver SignaturesResolver { get; }
        public virtual bool SortFilesInCompletionItemInfo { get; }
        public JetBrains.ReSharper.Psi.Web.Services.ISourceFilesResolver SourceFilesResolver { get; }
        public JetBrains.ReSharper.Psi.JavaScript.DeclaredElements.IJavaScriptSymbolInfoService SymbolInfoService { get; }
        public JetBrains.ReSharper.Psi.JavaScript.Services.IJavaScriptSymbolResolver SymbolResolver { get; }
        public JetBrains.ReSharper.Psi.JavaScript.Impl.Services.IJavaScriptSymbolVisibilityManager SymbolVisibilityManager { get; }
        public JetBrains.ReSharper.Psi.JavaScript.Caches.IJavaScriptTypeCache TypeCache { get; }
    }
}
namespace JetBrains.ReSharper.Psi.JavaScript.Tree
{
    
    public class static AccessorBodyNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.IAccessorBody GetByAccessorSignature(JetBrains.ReSharper.Psi.JavaScript.Tree.IAccessorSignature param) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.IAccessorBody GetByBlock(JetBrains.ReSharper.Psi.JavaScript.Tree.IBlock param) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.IAccessorBody GetByParameter(JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptParameterDeclaration param) { }
    }
    public enum AccessorKind : byte
    {
        Getter = 0,
        Setter = 1,
    }
    public class static AccessorSignatureNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.IAccessorSignature GetByParameter(JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptParameterDeclaration param) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.IAccessorSignature GetByParameterList(JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptParameterList param) { }
    }
    public class static ArrayLiteralNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.IArrayLiteral GetByArrayElement(JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression param) { }
    }
    public class static BinaryExpressionNavigator
    {
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.IBinaryExpression GetByLeftOperand(JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression leftOp) { }
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.IBinaryExpression GetByRightOperand(JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression rightOp) { }
    }
    public class static BlockNavigator
    {
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.IBlock GetByDocCommentBlock(JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptDocCommentBlockNode docCommentBlock) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.IBlock GetByStatement(JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatement param) { }
    }
    public class static BreakStatementNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.IBreakStatement GetByValue(JetBrains.ReSharper.Psi.JavaScript.Tree.ICompoundExpression param) { }
    }
    public class static CaseCaseClauseNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.ICaseCaseClause GetByStatement(JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatement param) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.ICaseCaseClause GetByValue(JetBrains.ReSharper.Psi.JavaScript.Tree.ICompoundExpression param) { }
    }
    public class static CaseClauseNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.ICaseClause GetByStatement(JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatement param) { }
    }
    public class static CaseClausesListNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.ICaseClausesList GetByCaseClause(JetBrains.ReSharper.Psi.JavaScript.Tree.ICaseClause param) { }
    }
    public class static CatchBlockNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.ICatchBlock GetByBlock(JetBrains.ReSharper.Psi.JavaScript.Tree.IBlock param) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.ICatchBlock GetByVariableDeclaration(JetBrains.ReSharper.Psi.JavaScript.Tree.IVariableDeclaration param) { }
    }
    public enum CommentType : byte
    {
        END_OF_LINE_COMMENT = 0,
        DOC_COMMENT = 1,
        MULTILINE_COMMENT = 2,
    }
    public class static CompoundExpressionNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.ICompoundExpression GetByExpression(JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression param) { }
    }
    public class static ConditionalTernaryExpressionNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.IConditionalTernaryExpression GetByConditionOperand(JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression param) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.IConditionalTernaryExpression GetByElseResult(JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression param) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.IConditionalTernaryExpression GetByThenResult(JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression param) { }
    }
    public enum ConstantValueTypes
    {
        Null = 0,
        True = 1,
        False = 2,
        String = 3,
        Numeric = 4,
        Unknown = 5,
    }
    public class static ContinueStatementNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.IContinueStatement GetByValue(JetBrains.ReSharper.Psi.JavaScript.Tree.ICompoundExpression param) { }
    }
    public class static DebugStatementNavigator { }
    public class static DefaultClauseNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.IDefaultClause GetByStatement(JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatement param) { }
    }
    public class static DocCommentBlockNodeNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptDocCommentBlockNode GetByDocCommentNode(JetBrains.ReSharper.Psi.JavaScript.Impl.Tree.IDocCommentNode docCommentNode) { }
    }
    public class static DoStatementNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.IDoStatement GetByCondition(JetBrains.ReSharper.Psi.JavaScript.Tree.ICompoundExpression param) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.IDoStatement GetByStatement(JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatement param) { }
    }
    public class static EmptyStatementNavigator { }
    public class static ExpressionStatementNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.IExpressionStatement GetByExpression(JetBrains.ReSharper.Psi.JavaScript.Tree.ICompoundExpression param) { }
    }
    public class static FinallyBlockNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.IFinallyBlock GetByBlock(JetBrains.ReSharper.Psi.JavaScript.Tree.IBlock param) { }
    }
    public class static ForDeclarationInitializerNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.IForDeclarationInitializer GetByDeclaration(JetBrains.ReSharper.Psi.JavaScript.Tree.IVariableDeclaration param) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.IForDeclarationInitializer GetByDeclarationList(JetBrains.ReSharper.Psi.JavaScript.Tree.IVariableDeclarationList param) { }
    }
    public class static ForeachStatementNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.IForeachStatement GetByForInitializer(JetBrains.ReSharper.Psi.JavaScript.Tree.IForInitializer param) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.IForeachStatement GetByForIterator(JetBrains.ReSharper.Psi.JavaScript.Tree.ICompoundExpression param) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.IForeachStatement GetByStatement(JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatement param) { }
    }
    public class static ForExpressionInitializerNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.IForExpressionInitializer GetByExpression(JetBrains.ReSharper.Psi.JavaScript.Tree.ICompoundExpression param) { }
    }
    public class static ForInitializerNavigator { }
    public class static ForStatementNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.IForStatement GetByForCondition(JetBrains.ReSharper.Psi.JavaScript.Tree.ICompoundExpression param) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.IForStatement GetByForInitializer(JetBrains.ReSharper.Psi.JavaScript.Tree.IForInitializer param) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.IForStatement GetByForIterator(JetBrains.ReSharper.Psi.JavaScript.Tree.ICompoundExpression param) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.IForStatement GetByStatement(JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatement param) { }
    }
    public class static FunctionExpressionNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.IFunctionExpression GetByBlock(JetBrains.ReSharper.Psi.JavaScript.Tree.IBlock param) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.IFunctionExpression GetByParameter(JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptParameterDeclaration param) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.IFunctionExpression GetBySignature(JetBrains.ReSharper.Psi.JavaScript.Tree.IFunctionExpressionSignature param) { }
    }
    public class static FunctionExpressionSignatureNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.IFunctionExpressionSignature GetByNameNode(JetBrains.ReSharper.Psi.JavaScript.Tree.IIdentifierExpression param) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.IFunctionExpressionSignature GetByParameter(JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptParameterDeclaration param) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.IFunctionExpressionSignature GetByParameterList(JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptParameterList param) { }
    }
    public class static FunctionLikeExtentions
    {
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptParameterDeclaration AddParameterDeclarationAfter(this JetBrains.ReSharper.Psi.JavaScript.Tree.IJsSignatureNodeInPars func, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptParameterDeclaration parameterDeclaration, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptParameterDeclaration anchor) { }
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptParameterDeclaration AddParameterDeclarationBefore(this JetBrains.ReSharper.Psi.JavaScript.Tree.IJsSignatureNodeInPars func, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptParameterDeclaration parameterDeclaration, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptParameterDeclaration anchor) { }
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.IBlockScope GetBlockScope(this JetBrains.ReSharper.Psi.JavaScript.Tree.IBlock param) { }
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.IJsFunctionLike GetFunctionLike(this JetBrains.ReSharper.Psi.JavaScript.Tree.IJsSignatureNode node) { }
        public static System.Collections.Generic.IList<JetBrains.ReSharper.Psi.JavaScript.Tree.IReturnStatement> GetFunctionReturns(this JetBrains.ReSharper.Psi.JavaScript.Tree.IJsFunctionLike functionExpression) { }
        public static JetBrains.Util.Pair<string, string> GetOwnerFunctionPresentationInternal(this JetBrains.ReSharper.Psi.JavaScript.Tree.IJsSignatureNode node, JetBrains.DocumentModel.DocumentRange startDocumentRange, string onInvalidRange, string nodeName, string name, JetBrains.ReSharper.Psi.Tree.ITreeNode endNode) { }
        public static string GetParametersListPresentation(this JetBrains.ReSharper.Psi.JavaScript.Tree.IJsSignatureNode node) { }
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.IJsSignatureNode GetSignatureNode(this JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptParameterList list) { }
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.IJsSignatureNode GetSignatureNode(this JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptParameterDeclaration parameter) { }
        public static bool HasRealParent(this JetBrains.ReSharper.Psi.JavaScript.DeclaredElements.IJavaScriptTypeOwner element) { }
        public static void RemoveParameterDeclaration(this JetBrains.ReSharper.Psi.JavaScript.Tree.IJsSignatureNodeInPars func, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptParameterDeclaration parameterDeclaration) { }
    }
    public class static FunctionStatementNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.IFunctionStatement GetByExpression(JetBrains.ReSharper.Psi.JavaScript.Tree.IFunctionExpression param) { }
    }
    public interface IAccessorBody : JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IIncrementalScope, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IScope, JetBrains.ReSharper.Psi.JavaScript.Tree.IBlockScope, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptScope, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptTreeNode, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptTypedNode, JetBrains.ReSharper.Psi.JavaScript.Tree.IJsFunctionLike, JetBrains.ReSharper.Psi.JavaScript.Tree.IJsSignaturesOwner, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Tree.IXmlDocOwnerTreeNode
    {
        JetBrains.ReSharper.Psi.JavaScript.Tree.IAccessorSignature AccessorSignature { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.IBlock Block { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptParameterDeclaration> Parameters { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeEnumerable<JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptParameterDeclaration> ParametersEnumerable { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.IAccessorSignature SetAccessorSignature(JetBrains.ReSharper.Psi.JavaScript.Tree.IAccessorSignature param);
        JetBrains.ReSharper.Psi.JavaScript.Tree.IBlock SetBlock(JetBrains.ReSharper.Psi.JavaScript.Tree.IBlock param);
    }
    public interface IAccessorSignature : JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IIncrementalScope, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IScope, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptScope, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptTreeNode, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptTypedNode, JetBrains.ReSharper.Psi.JavaScript.Tree.IJsSignatureNode, JetBrains.ReSharper.Psi.JavaScript.Tree.IJsSignatureNodeInPars, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.Tree.ITokenNode LPar { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptParameterList ParameterList { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptParameterDeclaration> Parameters { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeEnumerable<JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptParameterDeclaration> ParametersEnumerable { get; }
        JetBrains.ReSharper.Psi.Tree.ITokenNode RPar { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptParameterList SetParameterList(JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptParameterList param);
    }
    public interface IArrayLiteral : JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptTreeNode, JetBrains.ReSharper.Psi.JavaScript.Tree.IMemberExpression, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression> ArrayElements { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeEnumerable<JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression> ArrayElementsEnumerable { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<JetBrains.ReSharper.Psi.Tree.ITokenNode> Comma { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeEnumerable<JetBrains.ReSharper.Psi.Tree.ITokenNode> CommaEnumerable { get; }
        JetBrains.ReSharper.Psi.Tree.ITokenNode LBracket { get; }
        JetBrains.ReSharper.Psi.Tree.ITokenNode RBracket { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression AddArrayElementAfter(JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression arguemnt, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression anchor);
        JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression AddArrayElementBefore(JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression arguemnt, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression anchor);
        void RemoveArrayElement(JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression arguemnt);
    }
    public interface IBinaryExpression : JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        bool IsAssignment { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression LeftOperand { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression RightOperand { get; }
        JetBrains.ReSharper.Psi.Tree.ITokenNode Sign { get; }
    }
    public interface IBlock : JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatement, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptTreeNode, JetBrains.ReSharper.Psi.JavaScript.Tree.IStatementsOwner, JetBrains.ReSharper.Psi.Tree.IChameleonNode, JetBrains.ReSharper.Psi.Tree.IStatement, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.Tree.ITokenNode LBrace { get; }
        JetBrains.ReSharper.Psi.Tree.ITokenNode RBrace { get; }
        new JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatement> Statements { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeEnumerable<JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatement> StatementsEnumerable { get; }
    }
    public interface IBlockScope : JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IIncrementalScope, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IScope, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptScope, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.JavaScript.Tree.IBlock GetBlock();
        JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptTreeNode GetParentForAutoFormat();
    }
    public interface IBreakStatement : JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatement, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptTreeNode, JetBrains.ReSharper.Psi.Tree.IStatement, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.Tree.ITokenNode BreakKeyword { get; }
        JetBrains.ReSharper.Psi.Tree.ITokenNode Semicolon { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Resolve.IReference TargetReference { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.ICompoundExpression Value { get; }
        void EnsureSemicolon();
        JetBrains.ReSharper.Psi.JavaScript.Tree.ICompoundExpression SetValue(JetBrains.ReSharper.Psi.JavaScript.Tree.ICompoundExpression param);
    }
    public interface ICaseCaseClause : JetBrains.ReSharper.Psi.JavaScript.Tree.ICaseClause, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptTreeNode, JetBrains.ReSharper.Psi.JavaScript.Tree.IStatementsOwner, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.Tree.ITokenNode CaseKeyword { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.ICompoundExpression Value { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.ICompoundExpression SetValue(JetBrains.ReSharper.Psi.JavaScript.Tree.ICompoundExpression param);
    }
    public interface ICaseClause : JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptTreeNode, JetBrains.ReSharper.Psi.JavaScript.Tree.IStatementsOwner, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.Tree.ITokenNode Colon { get; }
        new JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatement> Statements { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeEnumerable<JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatement> StatementsEnumerable { get; }
    }
    public interface ICaseClausesList : JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<JetBrains.ReSharper.Psi.JavaScript.Tree.ICaseClause> CaseClauses { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeEnumerable<JetBrains.ReSharper.Psi.JavaScript.Tree.ICaseClause> CaseClausesEnumerable { get; }
    }
    public interface ICatchBlock : JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.JavaScript.Tree.IBlock Block { get; }
        JetBrains.ReSharper.Psi.Tree.ITokenNode CatchKeyword { get; }
        JetBrains.ReSharper.Psi.Tree.ITokenNode LPar { get; }
        JetBrains.ReSharper.Psi.Tree.ITokenNode RPar { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.IVariableDeclaration VariableDeclaration { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.IBlock SetBlock(JetBrains.ReSharper.Psi.JavaScript.Tree.IBlock param);
        JetBrains.ReSharper.Psi.JavaScript.Tree.IVariableDeclaration SetVariableDeclaration(JetBrains.ReSharper.Psi.JavaScript.Tree.IVariableDeclaration param);
    }
    public interface ICompoundExpression : JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<JetBrains.ReSharper.Psi.Tree.ITokenNode> Comma { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeEnumerable<JetBrains.ReSharper.Psi.Tree.ITokenNode> CommaEnumerable { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression> Expressions { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeEnumerable<JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression> ExpressionsEnumerable { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression LastExpression { get; }
    }
    public interface IConditionalTernaryExpression : JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.Tree.ITokenNode Colon { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression ConditionOperand { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression ElseResult { get; }
        JetBrains.ReSharper.Psi.Tree.ITokenNode Question { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression ThenResult { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression SetConditionOperand(JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression param);
        JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression SetElseResult(JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression param);
        JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression SetThenResult(JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression param);
    }
    public interface IContinueStatement : JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatement, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptTreeNode, JetBrains.ReSharper.Psi.Tree.IStatement, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.Tree.ITokenNode ContinueKeyword { get; }
        JetBrains.ReSharper.Psi.Tree.ITokenNode Semicolon { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Resolve.IReference TargetReference { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.ICompoundExpression Value { get; }
        void EnsureSemicolon();
        JetBrains.ReSharper.Psi.JavaScript.Tree.ICompoundExpression SetValue(JetBrains.ReSharper.Psi.JavaScript.Tree.ICompoundExpression param);
    }
    public interface IDebugStatement : JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatement, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptTreeNode, JetBrains.ReSharper.Psi.Tree.IStatement, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.Tree.ITokenNode DebugKeyword { get; }
        JetBrains.ReSharper.Psi.Tree.ITokenNode Semicolon { get; }
        void EnsureSemicolon();
    }
    public interface IDefaultClause : JetBrains.ReSharper.Psi.JavaScript.Tree.ICaseClause, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptTreeNode, JetBrains.ReSharper.Psi.JavaScript.Tree.IStatementsOwner, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.Tree.ITokenNode DefaultKeyword { get; }
    }
    public class static IdentifierExpressionNavigator { }
    public interface IDoStatement : JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatement, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatementWithParenthesis, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptTreeNode, JetBrains.ReSharper.Psi.Tree.IStatement, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.JavaScript.Tree.ICompoundExpression Condition { get; }
        JetBrains.ReSharper.Psi.Tree.ITokenNode DoKeyword { get; }
        JetBrains.ReSharper.Psi.Tree.ITokenNode Semicolon { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatement Statement { get; }
        JetBrains.ReSharper.Psi.Tree.ITokenNode WhileKeyword { get; }
        void EnsureSemicolon();
        JetBrains.ReSharper.Psi.JavaScript.Tree.ICompoundExpression SetCondition(JetBrains.ReSharper.Psi.JavaScript.Tree.ICompoundExpression param);
        JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatement SetStatement(JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatement param);
    }
    public interface IEmptyStatement : JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatement, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptTreeNode, JetBrains.ReSharper.Psi.Tree.IStatement, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.Tree.ITokenNode Semicolon { get; }
    }
    public interface IExpressionStatement : JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatement, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptTreeNode, JetBrains.ReSharper.Psi.Tree.IStatement, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.JavaScript.Tree.ICompoundExpression Expression { get; }
        JetBrains.ReSharper.Psi.Tree.ITokenNode Semicolon { get; }
        void EnsureSemicolon();
        JetBrains.ReSharper.Psi.JavaScript.Tree.ICompoundExpression SetExpression(JetBrains.ReSharper.Psi.JavaScript.Tree.ICompoundExpression param);
    }
    public interface IFinallyBlock : JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.JavaScript.Tree.IBlock Block { get; }
        JetBrains.ReSharper.Psi.Tree.ITokenNode FinallyKeyword { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.IBlock SetBlock(JetBrains.ReSharper.Psi.JavaScript.Tree.IBlock param);
    }
    public interface IForDeclarationInitializer : JetBrains.ReSharper.Psi.JavaScript.Tree.IForInitializer, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.JavaScript.Tree.IVariableDeclarationList DeclarationList { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<JetBrains.ReSharper.Psi.JavaScript.Tree.IVariableDeclaration> Declarations { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeEnumerable<JetBrains.ReSharper.Psi.JavaScript.Tree.IVariableDeclaration> DeclarationsEnumerable { get; }
        JetBrains.ReSharper.Psi.Tree.ITokenNode VarKeyword { get; }
        void RemoveVariableDeclaration(JetBrains.ReSharper.Psi.JavaScript.Tree.IVariableDeclaration variableDeclaration);
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.JavaScript.Tree.IForInitializer ReplaceBy(JetBrains.ReSharper.Psi.JavaScript.Tree.IForInitializer newInitializer);
        JetBrains.ReSharper.Psi.JavaScript.Tree.IVariableDeclarationList SetDeclarationList(JetBrains.ReSharper.Psi.JavaScript.Tree.IVariableDeclarationList param);
    }
    public interface IForeachStatement : JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatement, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatementWithParenthesis, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptTreeNode, JetBrains.ReSharper.Psi.Tree.IStatement, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.JavaScript.Tree.IForInitializer ForInitializer { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.ICompoundExpression ForIterator { get; }
        JetBrains.ReSharper.Psi.Tree.ITokenNode ForKeyword { get; }
        JetBrains.ReSharper.Psi.Tree.ITokenNode InKeyword { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatement Statement { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.IForInitializer SetForInitializer(JetBrains.ReSharper.Psi.JavaScript.Tree.IForInitializer param);
        JetBrains.ReSharper.Psi.JavaScript.Tree.ICompoundExpression SetForIterator(JetBrains.ReSharper.Psi.JavaScript.Tree.ICompoundExpression param);
        JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatement SetStatement(JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatement param);
    }
    public interface IForExpressionInitializer : JetBrains.ReSharper.Psi.JavaScript.Tree.IForInitializer, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.JavaScript.Tree.ICompoundExpression Expression { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.ICompoundExpression SetExpression(JetBrains.ReSharper.Psi.JavaScript.Tree.ICompoundExpression param);
    }
    public interface IForInitializer : JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode { }
    public interface IForStatement : JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatement, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatementWithParenthesis, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptTreeNode, JetBrains.ReSharper.Psi.Tree.IStatement, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.JavaScript.Tree.ICompoundExpression ForCondition { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.IForInitializer ForInitializer { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.ICompoundExpression ForIterator { get; }
        JetBrains.ReSharper.Psi.Tree.ITokenNode ForKeyword { get; }
        JetBrains.ReSharper.Psi.Tree.ITokenNode Semicolon1 { get; }
        JetBrains.ReSharper.Psi.Tree.ITokenNode Semicolon2 { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatement Statement { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.ICompoundExpression SetForCondition(JetBrains.ReSharper.Psi.JavaScript.Tree.ICompoundExpression param);
        JetBrains.ReSharper.Psi.JavaScript.Tree.IForInitializer SetForInitializer(JetBrains.ReSharper.Psi.JavaScript.Tree.IForInitializer param);
        JetBrains.ReSharper.Psi.JavaScript.Tree.ICompoundExpression SetForIterator(JetBrains.ReSharper.Psi.JavaScript.Tree.ICompoundExpression param);
        JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatement SetStatement(JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatement param);
    }
    public class static IfStatementNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.IIfStatement GetByCondition(JetBrains.ReSharper.Psi.JavaScript.Tree.ICompoundExpression param) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.IIfStatement GetByElse(JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatement param) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.IIfStatement GetByThen(JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatement param) { }
    }
    public interface IFunctionExpression : JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IIncrementalScope, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IScope, JetBrains.ReSharper.Psi.JavaScript.Impl.Tree.IJsOptimizedDeclaration, JetBrains.ReSharper.Psi.JavaScript.Tree.IBlockScope, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptDeclaration, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptScope, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptTreeNode, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptTypedNode, JetBrains.ReSharper.Psi.JavaScript.Tree.IJsFunctionLike, JetBrains.ReSharper.Psi.JavaScript.Tree.IJsSignaturesOwner, JetBrains.ReSharper.Psi.JavaScript.Tree.IMemberExpression, JetBrains.ReSharper.Psi.Tree.IDeclaration, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Tree.IXmlDocOwnerTreeNode
    {
        JetBrains.ReSharper.Psi.JavaScript.Tree.IBlock Block { get; }
        bool HasName { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptParameterDeclaration> Parameters { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeEnumerable<JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptParameterDeclaration> ParametersEnumerable { get; }
        string PossibleName { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.IFunctionExpressionSignature Signature { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.IBlock SetBlock(JetBrains.ReSharper.Psi.JavaScript.Tree.IBlock param);
        JetBrains.ReSharper.Psi.JavaScript.Tree.IFunctionExpressionSignature SetSignature(JetBrains.ReSharper.Psi.JavaScript.Tree.IFunctionExpressionSignature param);
    }
    public interface IFunctionExpressionSignature : JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IIncrementalScope, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IScope, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptScope, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptTreeNode, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptTypedNode, JetBrains.ReSharper.Psi.JavaScript.Tree.IJsSignatureNode, JetBrains.ReSharper.Psi.JavaScript.Tree.IJsSignatureNodeInPars, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.Tree.ITokenNode FunctionKeyword { get; }
        JetBrains.ReSharper.Psi.Tree.ITokenNode LPar { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.IIdentifierExpression NameNode { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptParameterList ParameterList { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptParameterDeclaration> Parameters { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeEnumerable<JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptParameterDeclaration> ParametersEnumerable { get; }
        JetBrains.ReSharper.Psi.Tree.ITokenNode RPar { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.IIdentifierExpression SetNameNode(JetBrains.ReSharper.Psi.JavaScript.Tree.IIdentifierExpression param);
        JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptParameterList SetParameterList(JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptParameterList param);
    }
    public interface IFunctionStatement : JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptDeclaredElementProvider, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatement, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptTreeNode, JetBrains.ReSharper.Psi.Tree.IStatement, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.JavaScript.Tree.IFunctionExpression Expression { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.IFunctionExpression SetExpression(JetBrains.ReSharper.Psi.JavaScript.Tree.IFunctionExpression param);
    }
    public interface IIdentifierExpression : JetBrains.ReSharper.Psi.JavaScript.Tree.IIdentifierExpressionBase, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.Tree.ITokenNode AlienToken { get; }
        JetBrains.ReSharper.Psi.Tree.ITokenNode NameToken { get; }
    }
    public interface IIdentifierExpressionBase : JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        bool IsDynamic { get; }
    }
    public interface IIfStatement : JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatement, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatementWithParenthesis, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptTreeNode, JetBrains.ReSharper.Psi.Tree.IStatement, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.JavaScript.Tree.ICompoundExpression Condition { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatement Else { get; }
        JetBrains.ReSharper.Psi.Tree.ITokenNode ElseKeyword { get; }
        JetBrains.ReSharper.Psi.Tree.ITokenNode IfKeyword { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatement Then { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.ICompoundExpression SetCondition(JetBrains.ReSharper.Psi.JavaScript.Tree.ICompoundExpression param);
        JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatement SetElse(JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatement param);
        JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatement SetThen(JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatement param);
    }
    public interface IIndexExpression : JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptTreeNode, JetBrains.ReSharper.Psi.JavaScript.Tree.IMemberExpression, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        string AccessedPropertyName { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.JavaScript.Resolve.IReferenceExpressionReference AccessedPropertyReference { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression> Arguments { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeEnumerable<JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression> ArgumentsEnumerable { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<JetBrains.ReSharper.Psi.Tree.ITokenNode> Comma { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeEnumerable<JetBrains.ReSharper.Psi.Tree.ITokenNode> CommaEnumerable { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.IMemberExpression IndexedExpression { get; }
        JetBrains.ReSharper.Psi.Tree.ITokenNode LBracket { get; }
        JetBrains.ReSharper.Psi.Tree.ITokenNode RBracket { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.IMemberExpression SetIndexedExpression(JetBrains.ReSharper.Psi.JavaScript.Tree.IMemberExpression param);
    }
    public interface IInvocationExpression : JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptTreeNode, JetBrains.ReSharper.Psi.JavaScript.Tree.IMemberExpression, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression> Arguments { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeEnumerable<JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression> ArgumentsEnumerable { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<JetBrains.ReSharper.Psi.Tree.ITokenNode> Comma { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeEnumerable<JetBrains.ReSharper.Psi.Tree.ITokenNode> CommaEnumerable { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression InvokedExpression { get; }
        JetBrains.ReSharper.Psi.Tree.ITokenNode LParenth { get; }
        JetBrains.ReSharper.Psi.Tree.ITokenNode RParenth { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression AddArgumentAfter(JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression param, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression anchor);
        JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression AddArgumentBefore(JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression param, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression anchor);
        JetBrains.ReSharper.Psi.JavaScript.Resolve.CustomFunctionAnnotation GetCustomFunctionAnnotation(JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsLocalElementResolver context, bool useResolve);
        void RemoveArgument(JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression param);
        JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression SetInvokedExpression(JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression param);
    }
    public interface IJavaScriptCommentNode : JetBrains.ReSharper.Psi.Tree.IComment, JetBrains.ReSharper.Psi.Tree.ICommentNode, JetBrains.ReSharper.Psi.Tree.ITokenNode, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.JavaScript.Tree.CommentType CommentType { get; }
    }
    public interface IJavaScriptDeclaration : JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptTreeNode, JetBrains.ReSharper.Psi.Tree.IDeclaration, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Tree.IXmlDocOwnerTreeNode
    {
        bool IsDynamic { get; }
    }
    public interface IJavaScriptDeclaredElementProvider : JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.Tree.IDeclaration GetDeclaration();
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IDeclaredElement> GetDeclaredElements(JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsDocumentOffsetProvider context);
    }
    public interface IJavaScriptDocCommentBlockNode : JetBrains.ReSharper.Psi.Tree.IDocCommentBlockNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Xml.XmlDocComments.IDocCommentBlockNodeWithPsi<JetBrains.ReSharper.Psi.JavaScript.Impl.DocComments.JavaScriptDocCommentXmlPsi, JetBrains.ReSharper.Psi.JavaScript.Impl.Tree.IDocCommentNode>
    {
        JetBrains.ReSharper.Psi.Tree.ReferenceCollection DocCommentReferences { get; }
    }
    public interface IJavaScriptExpression : JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.Tree.ExpressionAccessType GetAccessType();
        JetBrains.ReSharper.Psi.JavaScript.Resolve.IJavaScriptType GetJsType(JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsLocalElementResolver context);
        JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression ReplaceBy<TExpression>(TExpression expression)
            where TExpression :  class, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression;
    }
    public interface IJavaScriptFile : JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IIncrementalScope, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IScope, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptScope, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptTreeNode, JetBrains.ReSharper.Psi.Tree.IFile, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatement> AllStatements { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeEnumerable<JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatement> AllStatementsEnumerable { get; }
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptDocCommentBlockNode> DocCommentBlocks { get; }
        JetBrains.ReSharper.Psi.JavaScript.Services.JavaScriptServices JsServices { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptFileSection> Sections { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeEnumerable<JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptFileSection> SectionsEnumerable { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<JetBrains.ReSharper.Psi.Tree.ITokenNode> Separator { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeEnumerable<JetBrains.ReSharper.Psi.Tree.ITokenNode> SeparatorEnumerable { get; }
    }
    public interface IJavaScriptFileSection : JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptTreeNode, JetBrains.ReSharper.Psi.JavaScript.Tree.IStatementsOwner, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        new JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatement> Statements { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeEnumerable<JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatement> StatementsEnumerable { get; }
    }
    public interface IJavaScriptIdentifierNode : JetBrains.ReSharper.Psi.Tree.IIdentifier, JetBrains.ReSharper.Psi.Tree.ITokenNode, JetBrains.ReSharper.Psi.Tree.ITreeNode { }
    public interface IJavaScriptLiteralExpression : JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptTreeNode, JetBrains.ReSharper.Psi.JavaScript.Tree.IMemberExpression, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.JavaScript.Tree.ConstantValueTypes ConstantValueType { get; }
        JetBrains.ReSharper.Psi.Tree.ITokenNode Literal { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        string GetStringValue();
    }
    public interface IJavaScriptParameterDeclaration : JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptDeclaration, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptParameterDeclarationBase, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptTreeNode, JetBrains.ReSharper.Psi.Tree.IDeclaration, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Tree.IXmlDocOwnerTreeNode
    {
        JetBrains.ReSharper.Psi.JavaScript.Tree.IIdentifierExpression NameNode { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.IIdentifierExpression SetNameNode(JetBrains.ReSharper.Psi.JavaScript.Tree.IIdentifierExpression param);
    }
    public interface IJavaScriptParameterDeclarationBase : JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptDeclaration, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptTreeNode, JetBrains.ReSharper.Psi.Tree.IDeclaration, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Tree.IXmlDocOwnerTreeNode
    {
        JetBrains.ReSharper.Psi.JavaScript.DeclaredElements.IJavaScriptLocalElement DeclaredElement { get; }
    }
    public interface IJavaScriptParameterList : JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<JetBrains.ReSharper.Psi.Tree.ITokenNode> Comma { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeEnumerable<JetBrains.ReSharper.Psi.Tree.ITokenNode> CommaEnumerable { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptParameterDeclaration> Parameters { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeEnumerable<JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptParameterDeclaration> ParametersEnumerable { get; }
    }
    public interface IJavaScriptScope : JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IIncrementalScope, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IScope, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.Tree.IDeclaration> DeclarationsInScope { get; }
        System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.IDeclaredElement> GetDeclaredElementsInScope(JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsDocumentOffsetProvider context);
    }
    public interface IJavaScriptStatement : JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptTreeNode, JetBrains.ReSharper.Psi.Tree.IStatement, JetBrains.ReSharper.Psi.Tree.ITreeNode { }
    public interface IJavaScriptStatementsRange : JetBrains.ReSharper.Psi.Tree.IStatementsRange { }
    public interface IJavaScriptStatementWithParenthesis : JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatement, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptTreeNode, JetBrains.ReSharper.Psi.Tree.IStatement, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.Tree.ITokenNode LPar { get; }
        JetBrains.ReSharper.Psi.Tree.ITokenNode RPar { get; }
    }
    public interface IJavaScriptTreeNode : JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        void Accept(JetBrains.ReSharper.Psi.JavaScript.Tree.TreeNodeVisitor visitor);
        void Accept<TContext>(JetBrains.ReSharper.Psi.JavaScript.Tree.TreeNodeVisitor<TContext> visitor, TContext context);
        TReturn Accept<TContext, TReturn>(JetBrains.ReSharper.Psi.JavaScript.Tree.TreeNodeVisitor<TContext, TReturn> visitor, TContext context);
    }
    public interface IJavaScriptTypedNode
    {
        JetBrains.ReSharper.Psi.JavaScript.Resolve.IJavaScriptType GetJsType(JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsDocumentOffsetProvider context);
    }
    public interface IJsFunctionLike : JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IIncrementalScope, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IScope, JetBrains.ReSharper.Psi.JavaScript.Tree.IBlockScope, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptScope, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptTreeNode, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptTypedNode, JetBrains.ReSharper.Psi.JavaScript.Tree.IJsSignaturesOwner, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Tree.IXmlDocOwnerTreeNode
    {
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptDocCommentBlockNode> DocCommentBlocks { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptDocCommentBlockNode FirstDocCommentBlock { get; }
        JetBrains.ReSharper.Psi.Tree.ITreeNode FirstNodeForHighlighting { get; }
    }
    public interface IJsSignatureNode : JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IIncrementalScope, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IScope, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptScope, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptTypedNode, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.JavaScript.Resolve.IJavaScriptFunctionSignature Signature { get; }
        JetBrains.Util.Pair<string, string> GetOwnerFunctionPresentation();
        JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptParameterDeclarationBase> GetParameters();
    }
    public interface IJsSignatureNodeInPars : JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IIncrementalScope, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IScope, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptScope, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptTypedNode, JetBrains.ReSharper.Psi.JavaScript.Tree.IJsSignatureNode, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.Tree.ITokenNode GetLPar();
        JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptParameterList GetParameterList();
        JetBrains.ReSharper.Psi.Tree.ITokenNode GetRPar();
    }
    public interface IJsSignaturesOwner : JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IIncrementalScope, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IScope, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptScope, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptTypedNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Tree.IXmlDocOwnerTreeNode
    {
        JetBrains.ReSharper.Psi.JavaScript.Tree.IJsSignatureNode SignatureNode { get; }
        JetBrains.ReSharper.Psi.Tree.ITreeNode GetBody();
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.JavaScript.Resolve.IJavaScriptFunctionSignature> GetSignatures();
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.JavaScript.Tree.IJsSignatureNode> OverloadSignatureNodes();
    }
    public interface ILabelledStatement : JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IScope, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatement, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptTreeNode, JetBrains.ReSharper.Psi.Tree.IDeclaration, JetBrains.ReSharper.Psi.Tree.IStatement, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Tree.IXmlDocOwnerTreeNode
    {
        JetBrains.ReSharper.Psi.Tree.ITokenNode Colon { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.IIdentifierExpression NameNode { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatement Statement { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.IIdentifierExpression SetNameNode(JetBrains.ReSharper.Psi.JavaScript.Tree.IIdentifierExpression param);
        JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatement SetStatement(JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatement param);
    }
    public interface IMemberExpression : JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode { }
    public class static IndexExpressionNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.IIndexExpression GetByArgument(JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression param) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.IIndexExpression GetByIndexedExpression(JetBrains.ReSharper.Psi.JavaScript.Tree.IMemberExpression param) { }
    }
    public interface INewExpression : JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptTreeNode, JetBrains.ReSharper.Psi.JavaScript.Tree.IMemberExpression, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.JavaScript.Tree.IMemberExpression Expression { get; }
        JetBrains.ReSharper.Psi.Tree.ITokenNode NewKeyword { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.IMemberExpression SetExpression(JetBrains.ReSharper.Psi.JavaScript.Tree.IMemberExpression param);
    }
    public class static InvocationExpressionNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.IInvocationExpression GetByArgument(JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression param) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.IInvocationExpression GetByInvokedExpression(JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression param) { }
    }
    public interface IObjectLiteral : JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptTreeNode, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptTypedNode, JetBrains.ReSharper.Psi.JavaScript.Tree.IMemberExpression, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.Tree.ITokenNode LBrace { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<JetBrains.ReSharper.Psi.JavaScript.Tree.IObjectPropertyDeclaration> Properties { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeEnumerable<JetBrains.ReSharper.Psi.JavaScript.Tree.IObjectPropertyDeclaration> PropertiesEnumerable { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.IObjectPropertiesList PropertiesList { get; }
        JetBrains.ReSharper.Psi.Tree.ITokenNode RBrace { get; }
        T AddObjectPropertyAfter<T>(T param, JetBrains.ReSharper.Psi.JavaScript.Tree.IObjectPropertyDeclaration anchor)
            where T :  class, JetBrains.ReSharper.Psi.JavaScript.Tree.IObjectPropertyDeclaration;
        T AddObjectPropertyBefore<T>(T param, JetBrains.ReSharper.Psi.JavaScript.Tree.IObjectPropertyDeclaration anchor)
            where T :  class, JetBrains.ReSharper.Psi.JavaScript.Tree.IObjectPropertyDeclaration;
        void RemoveObjectProperty(JetBrains.ReSharper.Psi.JavaScript.Tree.IObjectPropertyDeclaration param);
        JetBrains.ReSharper.Psi.JavaScript.Tree.IObjectPropertiesList SetPropertiesList(JetBrains.ReSharper.Psi.JavaScript.Tree.IObjectPropertiesList param);
    }
    public interface IObjectPropertiesList : JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<JetBrains.ReSharper.Psi.Tree.ITokenNode> Comma { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeEnumerable<JetBrains.ReSharper.Psi.Tree.ITokenNode> CommaEnumerable { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<JetBrains.ReSharper.Psi.JavaScript.Tree.IObjectPropertyDeclaration> Properties { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeEnumerable<JetBrains.ReSharper.Psi.JavaScript.Tree.IObjectPropertyDeclaration> PropertiesEnumerable { get; }
    }
    public interface IObjectPropertyAccessor : JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptTreeNode, JetBrains.ReSharper.Psi.JavaScript.Tree.IObjectPropertyDeclaration, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Tree.IXmlDocOwnerTreeNode
    {
        JetBrains.ReSharper.Psi.JavaScript.Tree.IAccessorBody AccessorBody { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.AccessorKind AccessorKind { get; }
        JetBrains.ReSharper.Psi.Tree.ITokenNode AccessorType { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.IAccessorBody SetAccessorBody(JetBrains.ReSharper.Psi.JavaScript.Tree.IAccessorBody param);
    }
    public interface IObjectPropertyDeclaration : JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Tree.IXmlDocOwnerTreeNode
    {
        string DeclaredName { get; }
        bool IsDynamic { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.IPropertyName PropertyName { get; }
        JetBrains.ReSharper.Psi.JavaScript.Resolve.IDeclarationReference Reference { get; }
        JetBrains.ReSharper.Psi.TreeTextRange GetNameRange();
        JetBrains.ReSharper.Psi.JavaScript.Tree.IPropertyName SetPropertyName(JetBrains.ReSharper.Psi.JavaScript.Tree.IPropertyName param);
    }
    public interface IObjectPropertyInitializer : JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptTreeNode, JetBrains.ReSharper.Psi.JavaScript.Tree.IObjectPropertyDeclaration, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Tree.IXmlDocOwnerTreeNode
    {
        JetBrains.ReSharper.Psi.Tree.ITokenNode Colon { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression Value { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression SetValue(JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression param);
    }
    public interface IParenthesizedExpression : JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptTreeNode, JetBrains.ReSharper.Psi.JavaScript.Tree.IMemberExpression, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.JavaScript.Tree.ICompoundExpression Expressions { get; }
        JetBrains.ReSharper.Psi.Tree.ITokenNode LPar { get; }
        JetBrains.ReSharper.Psi.Tree.ITokenNode RPar { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.ICompoundExpression SetExpressions(JetBrains.ReSharper.Psi.JavaScript.Tree.ICompoundExpression param);
    }
    public interface IPostfixExpression : JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression Operand { get; }
        JetBrains.ReSharper.Psi.Tree.ITokenNode Sign { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression SetOperand(JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression param);
    }
    public interface IPrefixExpression : JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression Operand { get; }
        JetBrains.ReSharper.Psi.Tree.ITokenNode Sign { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression SetOperand(JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression param);
    }
    public interface IPropertyName : JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        bool IsDynamic { get; }
        int NameOffsetFromStart { get; }
        string ProjectedName { get; }
        JetBrains.ReSharper.Psi.TreeTextRange GetReferenceTreeTextRange();
        void SetName(string name);
    }
    public interface IPropertyNameIdentifier : JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptTreeNode, JetBrains.ReSharper.Psi.JavaScript.Tree.IPropertyName, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.JavaScript.Tree.IIdentifierExpression NameNode { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.IIdentifierExpression SetNameNode(JetBrains.ReSharper.Psi.JavaScript.Tree.IIdentifierExpression param);
    }
    public interface IPropertyNameNumericLiteral : JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptTreeNode, JetBrains.ReSharper.Psi.JavaScript.Tree.IPropertyName, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.Tree.ITokenNode Literal { get; }
    }
    public interface IPropertyNameStringLiteral : JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptTreeNode, JetBrains.ReSharper.Psi.JavaScript.Tree.IPropertyName, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.Tree.ITokenNode Literal { get; }
    }
    public interface IReferenceExpression : JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptTreeNode, JetBrains.ReSharper.Psi.JavaScript.Tree.IMemberExpression, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.Tree.ITokenNode Dot { get; }
        bool IsDynamic { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        string Name { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.IIdentifierExpression NameIdentifier { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression Qualifier { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.JavaScript.Resolve.IReferenceExpressionReference Reference { get; }
        JetBrains.ReSharper.Psi.JavaScript.Resolve.IJavaScriptType GetQualifierJsType(JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsLocalElementResolver context);
    }
    public interface IReturnStatement : JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatement, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptTreeNode, JetBrains.ReSharper.Psi.Tree.IStatement, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.Tree.ITokenNode ReturnKeyword { get; }
        JetBrains.ReSharper.Psi.Tree.ITokenNode Semicolon { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.ICompoundExpression Value { get; }
        void EnsureSemicolon();
        JetBrains.ReSharper.Psi.JavaScript.Tree.ICompoundExpression SetValue(JetBrains.ReSharper.Psi.JavaScript.Tree.ICompoundExpression param);
    }
    public interface IStatementsOwner : JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatement> Statements { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        TStatement AddStatementAfter<TStatement>([JetBrains.Annotations.NotNullAttribute()] TStatement param, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatement anchor)
            where TStatement :  class, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatement;
        [JetBrains.Annotations.NotNullAttribute()]
        TStatement AddStatementAfterRange<TStatement>([JetBrains.Annotations.NotNullAttribute()] TStatement param, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatementsRange anchor)
            where TStatement :  class, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatement;
        [JetBrains.Annotations.NotNullAttribute()]
        TStatement AddStatementBefore<TStatement>([JetBrains.Annotations.NotNullAttribute()] TStatement param, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatement anchor)
            where TStatement :  class, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatement;
        [JetBrains.Annotations.NotNullAttribute()]
        TStatement AddStatementBeforeRange<TStatement>([JetBrains.Annotations.NotNullAttribute()] TStatement param, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatementsRange anchor)
            where TStatement :  class, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatement;
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatementsRange AddStatementsRangeAfter([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatementsRange range, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatement anchor);
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatementsRange AddStatementsRangeAfter([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatementsRange range, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatementsRange anchor);
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatementsRange AddStatementsRangeBefore([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatementsRange range, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatement anchor);
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatementsRange AddStatementsRangeBefore([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatementsRange range, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatementsRange anchor);
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatementsRange GetAllStatementsRange();
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatementsRange GetStatementsRange(JetBrains.ReSharper.Psi.TreeTextRange treeTextRange);
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatementsRange GetStatementsRange([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatement first, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatement last);
        void RemoveStatement([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatement param);
        void RemoveStatementsRange([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatementsRange range);
    }
    public interface ISwitchStatement : JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatement, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatementWithParenthesis, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptTreeNode, JetBrains.ReSharper.Psi.Tree.IStatement, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<JetBrains.ReSharper.Psi.JavaScript.Tree.ICaseClause> CaseClauses { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.ICaseClausesList CaseClausesList { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.ICompoundExpression Condition { get; }
        JetBrains.ReSharper.Psi.Tree.ITokenNode LBrace { get; }
        JetBrains.ReSharper.Psi.Tree.ITokenNode RBrace { get; }
        JetBrains.ReSharper.Psi.Tree.ITokenNode SwitchKeyword { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.ICaseClausesList SetCaseClausesList(JetBrains.ReSharper.Psi.JavaScript.Tree.ICaseClausesList param);
        JetBrains.ReSharper.Psi.JavaScript.Tree.ICompoundExpression SetCondition(JetBrains.ReSharper.Psi.JavaScript.Tree.ICompoundExpression param);
    }
    public interface IThisExpression : JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptTreeNode, JetBrains.ReSharper.Psi.JavaScript.Tree.IMemberExpression, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.Tree.ITokenNode ThisKeyword { get; }
    }
    public interface IThrowStatement : JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatement, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptTreeNode, JetBrains.ReSharper.Psi.Tree.IStatement, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.Tree.ITokenNode Semicolon { get; }
        JetBrains.ReSharper.Psi.Tree.ITokenNode ThrowKeyword { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.ICompoundExpression Value { get; }
        void EnsureSemicolon();
        JetBrains.ReSharper.Psi.JavaScript.Tree.ICompoundExpression SetValue(JetBrains.ReSharper.Psi.JavaScript.Tree.ICompoundExpression param);
    }
    public interface ITryStatement : JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatement, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptTreeNode, JetBrains.ReSharper.Psi.Tree.IStatement, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.JavaScript.Tree.IBlock Block { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.ICatchBlock Catch { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.IBlock CatchBlock { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.IFinallyBlock Finally { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.IBlock FinallyBlock { get; }
        JetBrains.ReSharper.Psi.Tree.ITokenNode TryKeyword { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.IBlock SetBlock(JetBrains.ReSharper.Psi.JavaScript.Tree.IBlock param);
        JetBrains.ReSharper.Psi.JavaScript.Tree.ICatchBlock SetCatch(JetBrains.ReSharper.Psi.JavaScript.Tree.ICatchBlock param);
        JetBrains.ReSharper.Psi.JavaScript.Tree.IBlock SetCatchBlock(JetBrains.ReSharper.Psi.JavaScript.Tree.IBlock param);
        JetBrains.ReSharper.Psi.JavaScript.Tree.IFinallyBlock SetFinally(JetBrains.ReSharper.Psi.JavaScript.Tree.IFinallyBlock param);
        JetBrains.ReSharper.Psi.JavaScript.Tree.IBlock SetFinallyBlock(JetBrains.ReSharper.Psi.JavaScript.Tree.IBlock param);
    }
    public interface IVariableDeclaration : JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptDeclaration, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptDeclaredElementProvider, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptTreeNode, JetBrains.ReSharper.Psi.Tree.IDeclaration, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Tree.IXmlDocOwnerTreeNode
    {
        JetBrains.ReSharper.Psi.Tree.ITokenNode Eq { get; }
        bool IsCatchVariable { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.IIdentifierExpression NameNode { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression Value { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.IIdentifierExpression SetNameNode(JetBrains.ReSharper.Psi.JavaScript.Tree.IIdentifierExpression param);
        JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression SetValue(JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression param);
    }
    public interface IVariableDeclarationList : JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<JetBrains.ReSharper.Psi.Tree.ITokenNode> Comma { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeEnumerable<JetBrains.ReSharper.Psi.Tree.ITokenNode> CommaEnumerable { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<JetBrains.ReSharper.Psi.JavaScript.Tree.IVariableDeclaration> VariableDeclarations { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeEnumerable<JetBrains.ReSharper.Psi.JavaScript.Tree.IVariableDeclaration> VariableDeclarationsEnumerable { get; }
    }
    public interface IVariableStatement : JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatement, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptTreeNode, JetBrains.ReSharper.Psi.Tree.IStatement, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.JavaScript.Tree.IVariableDeclarationList DeclarationList { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<JetBrains.ReSharper.Psi.JavaScript.Tree.IVariableDeclaration> Declarations { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeEnumerable<JetBrains.ReSharper.Psi.JavaScript.Tree.IVariableDeclaration> DeclarationsEnumerable { get; }
        JetBrains.ReSharper.Psi.Tree.ITokenNode Semicolon { get; }
        JetBrains.ReSharper.Psi.Tree.ITokenNode VarKeyword { get; }
        void EnsureSemicolon();
        void RemoveVariableDeclaration(JetBrains.ReSharper.Psi.JavaScript.Tree.IVariableDeclaration variableDeclaration);
        JetBrains.ReSharper.Psi.JavaScript.Tree.IVariableDeclarationList SetDeclarationList(JetBrains.ReSharper.Psi.JavaScript.Tree.IVariableDeclarationList param);
    }
    public interface IWhileStatement : JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatement, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatementWithParenthesis, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptTreeNode, JetBrains.ReSharper.Psi.Tree.IStatement, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.JavaScript.Tree.ICompoundExpression Condition { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatement Statement { get; }
        JetBrains.ReSharper.Psi.Tree.ITokenNode WhileKeyword { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.ICompoundExpression SetCondition(JetBrains.ReSharper.Psi.JavaScript.Tree.ICompoundExpression param);
        JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatement SetStatement(JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatement param);
    }
    public interface IWhitespaceNode : JetBrains.ReSharper.Psi.Tree.ITokenNode, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        bool IsNewLine { get; }
    }
    public interface IWithStatement : JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatement, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatementWithParenthesis, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptTreeNode, JetBrains.ReSharper.Psi.Tree.IStatement, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.JavaScript.Tree.ICompoundExpression Condition { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatement Statement { get; }
        JetBrains.ReSharper.Psi.Tree.ITokenNode WithKeyword { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.ICompoundExpression SetCondition(JetBrains.ReSharper.Psi.JavaScript.Tree.ICompoundExpression param);
        JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatement SetStatement(JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatement param);
    }
    public abstract class JavaScriptCompositeNodeType : JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeNodeType
    {
        protected JavaScriptCompositeNodeType(string s, int index) { }
    }
    public class static JavaScriptExpressionExtentions
    {
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.ICompoundExpression GetExpressionThroughParenthesis(this JetBrains.ReSharper.Psi.JavaScript.Tree.ICompoundExpression expression) { }
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression GetExpressionThroughParenthesis(this JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression expression) { }
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression GetOwnerExpressionThroughParenthesis(this JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression expression) { }
        public static bool IsProperExpressionStatement(JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression expression, out JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression wrongSubexpression) { }
    }
    public class static JavaScriptExpressionNavigator { }
    public class static JavaScriptFileNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptFile GetByAllStatement(JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatement param) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptFile GetBySection(JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptFileSection param) { }
    }
    public class static JavaScriptFileSectionNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptFileSection GetByStatement(JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatement param) { }
    }
    public class static JavaScriptLiteralExpressionNavigator { }
    public class static JavaScriptParameterDeclarationNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptParameterDeclaration GetByNameNode(JetBrains.ReSharper.Psi.JavaScript.Tree.IIdentifierExpression param) { }
    }
    public class static JavaScriptParameterListNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptParameterList GetByParameter(JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptParameterDeclaration param) { }
    }
    public class static JavaScriptStatementExtensions
    {
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.IStatementsOwner GetOrCreateStatementsOwner<TStatement>(this JetBrains.ReSharper.Psi.JavaScript.Services.JavaScriptElementFactory factory, ref TStatement statement)
            where TStatement :  class, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatement { }
        public static void Remove(this JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatement src) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static TStatement ReplaceBy<TStatement>(this JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatement src, TStatement stmt)
            where TStatement :  class, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatement { }
    }
    public class static JavaScriptStatementNavigator { }
    public class static JavaScriptStatementWithParenthesisNavigator { }
    public class static JsTreeNodeExtensions
    {
        public static JetBrains.ReSharper.Psi.JavaScript.LanguageImpl.JavaScriptLanguageService GetLanguageService(this JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptTreeNode node) { }
    }
    public class static LabelledStatementNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.ILabelledStatement GetByNameNode(JetBrains.ReSharper.Psi.JavaScript.Tree.IIdentifierExpression param) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.ILabelledStatement GetByStatement(JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatement param) { }
    }
    public class static MemberExpressionNavigator { }
    public class static NewExpressionNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.INewExpression GetByExpression(JetBrains.ReSharper.Psi.JavaScript.Tree.IMemberExpression param) { }
    }
    public class static ObjectLiteralNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.IObjectLiteral GetByPropertie(JetBrains.ReSharper.Psi.JavaScript.Tree.IObjectPropertyDeclaration param) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.IObjectLiteral GetByPropertiesList(JetBrains.ReSharper.Psi.JavaScript.Tree.IObjectPropertiesList param) { }
    }
    public class static ObjectPropertiesListNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.IObjectPropertiesList GetByPropertie(JetBrains.ReSharper.Psi.JavaScript.Tree.IObjectPropertyDeclaration param) { }
    }
    public class static ObjectPropertyAccessorNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.IObjectPropertyAccessor GetByAccessorBody(JetBrains.ReSharper.Psi.JavaScript.Tree.IAccessorBody param) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.IObjectPropertyAccessor GetByPropertyName(JetBrains.ReSharper.Psi.JavaScript.Tree.IPropertyName param) { }
    }
    public class static ObjectPropertyDeclarationExtensions
    {
        public static JetBrains.DocumentModel.DocumentRange GetNameDocumentRange(this JetBrains.ReSharper.Psi.JavaScript.Tree.IObjectPropertyDeclaration declaration) { }
    }
    public class static ObjectPropertyDeclarationNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.IObjectPropertyDeclaration GetByPropertyName(JetBrains.ReSharper.Psi.JavaScript.Tree.IPropertyName param) { }
    }
    public class static ObjectPropertyInitializerNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.IObjectPropertyInitializer GetByPropertyName(JetBrains.ReSharper.Psi.JavaScript.Tree.IPropertyName param) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.IObjectPropertyInitializer GetByValue(JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression param) { }
    }
    public class static ParenthesizedExpressionNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.IParenthesizedExpression GetByExpressions(JetBrains.ReSharper.Psi.JavaScript.Tree.ICompoundExpression param) { }
    }
    public class static PostfixExpressionNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.IPostfixExpression GetByOperand(JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression param) { }
    }
    public class static PrefixExpressionNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.IPrefixExpression GetByOperand(JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression param) { }
    }
    public class static PropertyNameIdentifierNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.IPropertyNameIdentifier GetByNameNode(JetBrains.ReSharper.Psi.JavaScript.Tree.IIdentifierExpression param) { }
    }
    public class static PropertyNameNavigator { }
    public class static PropertyNameNumericLiteralNavigator { }
    public class static PropertyNameStringLiteralNavigator { }
    public class static ReferenceExpressionNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.IReferenceExpression GetByNameIdentifier(JetBrains.ReSharper.Psi.JavaScript.Tree.IIdentifierExpression param) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.IReferenceExpression GetByQualifier(JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression param) { }
    }
    public class static ReturnStatementNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.IReturnStatement GetByValue(JetBrains.ReSharper.Psi.JavaScript.Tree.ICompoundExpression param) { }
    }
    public class static StatementsOwnerExtentions
    {
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.IStatementsOwner GetOrCreateOwnerBlock(ref JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatement statement) { }
    }
    public class static StatemetnsOwnerNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.IStatementsOwner GetByStatement(JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatement statement) { }
    }
    public class static SwitchStatementNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.ISwitchStatement GetByCaseClausesList(JetBrains.ReSharper.Psi.JavaScript.Tree.ICaseClausesList param) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.ISwitchStatement GetByCondition(JetBrains.ReSharper.Psi.JavaScript.Tree.ICompoundExpression param) { }
    }
    public class static ThisExpressionNavigator { }
    public class static ThrowStatementNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.IThrowStatement GetByValue(JetBrains.ReSharper.Psi.JavaScript.Tree.ICompoundExpression param) { }
    }
    public abstract class TreeNodeVisitor
    {
        public virtual void VisitAccessorBody([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IAccessorBody accessorBodyParam) { }
        public virtual void VisitAccessorSignature([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IAccessorSignature accessorSignatureParam) { }
        public virtual void VisitArrayLiteral([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IArrayLiteral arrayLiteralParam) { }
        public virtual void VisitBinaryExpression([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IBinaryExpression binaryExpressionParam) { }
        public virtual void VisitBlock([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IBlock blockParam) { }
        public virtual void VisitBreakStatement([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IBreakStatement breakStatementParam) { }
        public virtual void VisitCaseCaseClause([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.ICaseCaseClause caseCaseClauseParam) { }
        public virtual void VisitCaseClause([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.ICaseClause caseClauseParam) { }
        public virtual void VisitCaseClausesList([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.ICaseClausesList caseClausesListParam) { }
        public virtual void VisitCatchBlock([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.ICatchBlock catchBlockParam) { }
        public virtual void VisitCompoundExpression([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.ICompoundExpression compoundExpressionParam) { }
        public virtual void VisitConditionalTernaryExpression([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IConditionalTernaryExpression conditionalTernaryExpressionParam) { }
        public virtual void VisitContinueStatement([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IContinueStatement continueStatementParam) { }
        public virtual void VisitDebugStatement([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IDebugStatement debugStatementParam) { }
        public virtual void VisitDefaultClause([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IDefaultClause defaultClauseParam) { }
        public virtual void VisitDocCommentBlockNode(JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptDocCommentBlockNode xmlDoc) { }
        public virtual void VisitDoStatement([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IDoStatement doStatementParam) { }
        public virtual void VisitEmptyStatement([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IEmptyStatement emptyStatementParam) { }
        public virtual void VisitExpressionStatement([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IExpressionStatement expressionStatementParam) { }
        public virtual void VisitFinallyBlock([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IFinallyBlock finallyBlockParam) { }
        public virtual void VisitForDeclarationInitializer([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IForDeclarationInitializer forDeclarationInitializerParam) { }
        public virtual void VisitForeachStatement([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IForeachStatement foreachStatementParam) { }
        public virtual void VisitForExpressionInitializer([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IForExpressionInitializer forExpressionInitializerParam) { }
        public virtual void VisitForInitializer([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IForInitializer forInitializerParam) { }
        public virtual void VisitForStatement([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IForStatement forStatementParam) { }
        public virtual void VisitFunctionExpression([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IFunctionExpression functionExpressionParam) { }
        public virtual void VisitFunctionExpressionSignature([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IFunctionExpressionSignature functionExpressionSignatureParam) { }
        public virtual void VisitFunctionStatement([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IFunctionStatement functionStatementParam) { }
        public virtual void VisitIdentifierExpression([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IIdentifierExpression identifierExpressionParam) { }
        public virtual void VisitIfStatement([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IIfStatement ifStatementParam) { }
        public virtual void VisitIndexExpression([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IIndexExpression indexExpressionParam) { }
        public virtual void VisitInvocationExpression([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IInvocationExpression invocationExpressionParam) { }
        public virtual void VisitJavaScriptExpression([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression javaScriptExpressionParam) { }
        public virtual void VisitJavaScriptFile([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptFile javaScriptFileParam) { }
        public virtual void VisitJavaScriptFileSection([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptFileSection javaScriptFileSectionParam) { }
        public virtual void VisitJavaScriptLiteralExpression([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptLiteralExpression javaScriptLiteralExpressionParam) { }
        public virtual void VisitJavaScriptParameterDeclaration([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptParameterDeclaration javaScriptParameterDeclarationParam) { }
        public virtual void VisitJavaScriptParameterList([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptParameterList javaScriptParameterListParam) { }
        public virtual void VisitJavaScriptStatement([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatement javaScriptStatementParam) { }
        public virtual void VisitJavaScriptStatementWithParenthesis([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatementWithParenthesis javaScriptStatementWithParenthesisParam) { }
        public virtual void VisitLabelledStatement([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.ILabelledStatement labelledStatementParam) { }
        public virtual void VisitMemberExpression([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IMemberExpression memberExpressionParam) { }
        public virtual void VisitNewExpression([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.INewExpression newExpressionParam) { }
        public virtual void VisitNode([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode node) { }
        public virtual void VisitObjectLiteral([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IObjectLiteral objectLiteralParam) { }
        public virtual void VisitObjectPropertiesList([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IObjectPropertiesList objectPropertiesListParam) { }
        public virtual void VisitObjectPropertyAccessor([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IObjectPropertyAccessor objectPropertyAccessorParam) { }
        public virtual void VisitObjectPropertyDeclaration([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IObjectPropertyDeclaration objectPropertyDeclarationParam) { }
        public virtual void VisitObjectPropertyInitializer([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IObjectPropertyInitializer objectPropertyInitializerParam) { }
        public virtual void VisitParenthesizedExpression([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IParenthesizedExpression parenthesizedExpressionParam) { }
        public virtual void VisitPostfixExpression([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IPostfixExpression postfixExpressionParam) { }
        public virtual void VisitPrefixExpression([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IPrefixExpression prefixExpressionParam) { }
        public virtual void VisitPropertyName([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IPropertyName propertyNameParam) { }
        public virtual void VisitPropertyNameIdentifier([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IPropertyNameIdentifier propertyNameIdentifierParam) { }
        public virtual void VisitPropertyNameNumericLiteral([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IPropertyNameNumericLiteral propertyNameNumericLiteralParam) { }
        public virtual void VisitPropertyNameStringLiteral([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IPropertyNameStringLiteral propertyNameStringLiteralParam) { }
        public virtual void VisitReferenceExpression([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IReferenceExpression referenceExpressionParam) { }
        public virtual void VisitReturnStatement([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IReturnStatement returnStatementParam) { }
        public virtual void VisitSwitchStatement([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.ISwitchStatement switchStatementParam) { }
        public virtual void VisitThisExpression([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IThisExpression thisExpressionParam) { }
        public virtual void VisitThrowStatement([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IThrowStatement throwStatementParam) { }
        public virtual void VisitTryStatement([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.ITryStatement tryStatementParam) { }
        public virtual void VisitVariableDeclaration([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IVariableDeclaration variableDeclarationParam) { }
        public virtual void VisitVariableDeclarationList([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IVariableDeclarationList variableDeclarationListParam) { }
        public virtual void VisitVariableStatement([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IVariableStatement variableStatementParam) { }
        public virtual void VisitWhileStatement([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IWhileStatement whileStatementParam) { }
        public virtual void VisitWithStatement([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IWithStatement withStatementParam) { }
    }
    public abstract class TreeNodeVisitor<TContext>
    
    {
        public virtual void VisitAccessorBody([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IAccessorBody accessorBodyParam, TContext context) { }
        public virtual void VisitAccessorSignature([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IAccessorSignature accessorSignatureParam, TContext context) { }
        public virtual void VisitArrayLiteral([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IArrayLiteral arrayLiteralParam, TContext context) { }
        public virtual void VisitBinaryExpression([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IBinaryExpression binaryExpressionParam, TContext context) { }
        public virtual void VisitBlock([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IBlock blockParam, TContext context) { }
        public virtual void VisitBreakStatement([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IBreakStatement breakStatementParam, TContext context) { }
        public virtual void VisitCaseCaseClause([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.ICaseCaseClause caseCaseClauseParam, TContext context) { }
        public virtual void VisitCaseClause([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.ICaseClause caseClauseParam, TContext context) { }
        public virtual void VisitCaseClausesList([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.ICaseClausesList caseClausesListParam, TContext context) { }
        public virtual void VisitCatchBlock([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.ICatchBlock catchBlockParam, TContext context) { }
        public virtual void VisitCompoundExpression([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.ICompoundExpression compoundExpressionParam, TContext context) { }
        public virtual void VisitConditionalTernaryExpression([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IConditionalTernaryExpression conditionalTernaryExpressionParam, TContext context) { }
        public virtual void VisitContinueStatement([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IContinueStatement continueStatementParam, TContext context) { }
        public virtual void VisitDebugStatement([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IDebugStatement debugStatementParam, TContext context) { }
        public virtual void VisitDefaultClause([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IDefaultClause defaultClauseParam, TContext context) { }
        public virtual void VisitDocCommentBlockNode(JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptDocCommentBlockNode xmlDoc, TContext context) { }
        public virtual void VisitDoStatement([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IDoStatement doStatementParam, TContext context) { }
        public virtual void VisitEmptyStatement([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IEmptyStatement emptyStatementParam, TContext context) { }
        public virtual void VisitExpressionStatement([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IExpressionStatement expressionStatementParam, TContext context) { }
        public virtual void VisitFinallyBlock([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IFinallyBlock finallyBlockParam, TContext context) { }
        public virtual void VisitForDeclarationInitializer([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IForDeclarationInitializer forDeclarationInitializerParam, TContext context) { }
        public virtual void VisitForeachStatement([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IForeachStatement foreachStatementParam, TContext context) { }
        public virtual void VisitForExpressionInitializer([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IForExpressionInitializer forExpressionInitializerParam, TContext context) { }
        public virtual void VisitForInitializer([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IForInitializer forInitializerParam, TContext context) { }
        public virtual void VisitForStatement([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IForStatement forStatementParam, TContext context) { }
        public virtual void VisitFunctionExpression([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IFunctionExpression functionExpressionParam, TContext context) { }
        public virtual void VisitFunctionExpressionSignature([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IFunctionExpressionSignature functionExpressionSignatureParam, TContext context) { }
        public virtual void VisitFunctionStatement([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IFunctionStatement functionStatementParam, TContext context) { }
        public virtual void VisitIdentifierExpression([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IIdentifierExpression identifierExpressionParam, TContext context) { }
        public virtual void VisitIfStatement([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IIfStatement ifStatementParam, TContext context) { }
        public virtual void VisitIndexExpression([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IIndexExpression indexExpressionParam, TContext context) { }
        public virtual void VisitInvocationExpression([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IInvocationExpression invocationExpressionParam, TContext context) { }
        public virtual void VisitJavaScriptExpression([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression javaScriptExpressionParam, TContext context) { }
        public virtual void VisitJavaScriptFile([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptFile javaScriptFileParam, TContext context) { }
        public virtual void VisitJavaScriptFileSection([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptFileSection javaScriptFileSectionParam, TContext context) { }
        public virtual void VisitJavaScriptLiteralExpression([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptLiteralExpression javaScriptLiteralExpressionParam, TContext context) { }
        public virtual void VisitJavaScriptParameterDeclaration([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptParameterDeclaration javaScriptParameterDeclarationParam, TContext context) { }
        public virtual void VisitJavaScriptParameterList([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptParameterList javaScriptParameterListParam, TContext context) { }
        public virtual void VisitJavaScriptStatement([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatement javaScriptStatementParam, TContext context) { }
        public virtual void VisitJavaScriptStatementWithParenthesis([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatementWithParenthesis javaScriptStatementWithParenthesisParam, TContext context) { }
        public virtual void VisitLabelledStatement([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.ILabelledStatement labelledStatementParam, TContext context) { }
        public virtual void VisitMemberExpression([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IMemberExpression memberExpressionParam, TContext context) { }
        public virtual void VisitNewExpression([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.INewExpression newExpressionParam, TContext context) { }
        public virtual void VisitNode([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode node, TContext context) { }
        public virtual void VisitObjectLiteral([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IObjectLiteral objectLiteralParam, TContext context) { }
        public virtual void VisitObjectPropertiesList([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IObjectPropertiesList objectPropertiesListParam, TContext context) { }
        public virtual void VisitObjectPropertyAccessor([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IObjectPropertyAccessor objectPropertyAccessorParam, TContext context) { }
        public virtual void VisitObjectPropertyDeclaration([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IObjectPropertyDeclaration objectPropertyDeclarationParam, TContext context) { }
        public virtual void VisitObjectPropertyInitializer([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IObjectPropertyInitializer objectPropertyInitializerParam, TContext context) { }
        public virtual void VisitParenthesizedExpression([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IParenthesizedExpression parenthesizedExpressionParam, TContext context) { }
        public virtual void VisitPostfixExpression([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IPostfixExpression postfixExpressionParam, TContext context) { }
        public virtual void VisitPrefixExpression([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IPrefixExpression prefixExpressionParam, TContext context) { }
        public virtual void VisitPropertyName([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IPropertyName propertyNameParam, TContext context) { }
        public virtual void VisitPropertyNameIdentifier([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IPropertyNameIdentifier propertyNameIdentifierParam, TContext context) { }
        public virtual void VisitPropertyNameNumericLiteral([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IPropertyNameNumericLiteral propertyNameNumericLiteralParam, TContext context) { }
        public virtual void VisitPropertyNameStringLiteral([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IPropertyNameStringLiteral propertyNameStringLiteralParam, TContext context) { }
        public virtual void VisitReferenceExpression([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IReferenceExpression referenceExpressionParam, TContext context) { }
        public virtual void VisitReturnStatement([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IReturnStatement returnStatementParam, TContext context) { }
        public virtual void VisitSwitchStatement([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.ISwitchStatement switchStatementParam, TContext context) { }
        public virtual void VisitThisExpression([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IThisExpression thisExpressionParam, TContext context) { }
        public virtual void VisitThrowStatement([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IThrowStatement throwStatementParam, TContext context) { }
        public virtual void VisitTryStatement([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.ITryStatement tryStatementParam, TContext context) { }
        public virtual void VisitVariableDeclaration([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IVariableDeclaration variableDeclarationParam, TContext context) { }
        public virtual void VisitVariableDeclarationList([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IVariableDeclarationList variableDeclarationListParam, TContext context) { }
        public virtual void VisitVariableStatement([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IVariableStatement variableStatementParam, TContext context) { }
        public virtual void VisitWhileStatement([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IWhileStatement whileStatementParam, TContext context) { }
        public virtual void VisitWithStatement([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IWithStatement withStatementParam, TContext context) { }
    }
    public abstract class TreeNodeVisitor<TContext, TReturn>
    
    
    {
        public virtual TReturn VisitAccessorBody([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IAccessorBody accessorBodyParam, TContext context) { }
        public virtual TReturn VisitAccessorSignature([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IAccessorSignature accessorSignatureParam, TContext context) { }
        public virtual TReturn VisitArrayLiteral([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IArrayLiteral arrayLiteralParam, TContext context) { }
        public virtual TReturn VisitBinaryExpression([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IBinaryExpression binaryExpressionParam, TContext context) { }
        public virtual TReturn VisitBlock([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IBlock blockParam, TContext context) { }
        public virtual TReturn VisitBreakStatement([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IBreakStatement breakStatementParam, TContext context) { }
        public virtual TReturn VisitCaseCaseClause([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.ICaseCaseClause caseCaseClauseParam, TContext context) { }
        public virtual TReturn VisitCaseClause([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.ICaseClause caseClauseParam, TContext context) { }
        public virtual TReturn VisitCaseClausesList([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.ICaseClausesList caseClausesListParam, TContext context) { }
        public virtual TReturn VisitCatchBlock([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.ICatchBlock catchBlockParam, TContext context) { }
        public virtual TReturn VisitCompoundExpression([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.ICompoundExpression compoundExpressionParam, TContext context) { }
        public virtual TReturn VisitConditionalTernaryExpression([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IConditionalTernaryExpression conditionalTernaryExpressionParam, TContext context) { }
        public virtual TReturn VisitContinueStatement([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IContinueStatement continueStatementParam, TContext context) { }
        public virtual TReturn VisitDebugStatement([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IDebugStatement debugStatementParam, TContext context) { }
        public virtual TReturn VisitDefaultClause([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IDefaultClause defaultClauseParam, TContext context) { }
        public virtual TReturn VisitDocCommentBlockNode(JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptDocCommentBlockNode xmlDoc, TContext context) { }
        public virtual TReturn VisitDoStatement([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IDoStatement doStatementParam, TContext context) { }
        public virtual TReturn VisitEmptyStatement([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IEmptyStatement emptyStatementParam, TContext context) { }
        public virtual TReturn VisitExpressionStatement([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IExpressionStatement expressionStatementParam, TContext context) { }
        public virtual TReturn VisitFinallyBlock([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IFinallyBlock finallyBlockParam, TContext context) { }
        public virtual TReturn VisitForDeclarationInitializer([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IForDeclarationInitializer forDeclarationInitializerParam, TContext context) { }
        public virtual TReturn VisitForeachStatement([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IForeachStatement foreachStatementParam, TContext context) { }
        public virtual TReturn VisitForExpressionInitializer([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IForExpressionInitializer forExpressionInitializerParam, TContext context) { }
        public virtual TReturn VisitForInitializer([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IForInitializer forInitializerParam, TContext context) { }
        public virtual TReturn VisitForStatement([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IForStatement forStatementParam, TContext context) { }
        public virtual TReturn VisitFunctionExpression([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IFunctionExpression functionExpressionParam, TContext context) { }
        public virtual TReturn VisitFunctionExpressionSignature([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IFunctionExpressionSignature functionExpressionSignatureParam, TContext context) { }
        public virtual TReturn VisitFunctionStatement([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IFunctionStatement functionStatementParam, TContext context) { }
        public virtual TReturn VisitIdentifierExpression([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IIdentifierExpression identifierExpressionParam, TContext context) { }
        public virtual TReturn VisitIfStatement([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IIfStatement ifStatementParam, TContext context) { }
        public virtual TReturn VisitIndexExpression([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IIndexExpression indexExpressionParam, TContext context) { }
        public virtual TReturn VisitInvocationExpression([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IInvocationExpression invocationExpressionParam, TContext context) { }
        public virtual TReturn VisitJavaScriptExpression([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression javaScriptExpressionParam, TContext context) { }
        public virtual TReturn VisitJavaScriptFile([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptFile javaScriptFileParam, TContext context) { }
        public virtual TReturn VisitJavaScriptFileSection([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptFileSection javaScriptFileSectionParam, TContext context) { }
        public virtual TReturn VisitJavaScriptLiteralExpression([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptLiteralExpression javaScriptLiteralExpressionParam, TContext context) { }
        public virtual TReturn VisitJavaScriptParameterDeclaration([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptParameterDeclaration javaScriptParameterDeclarationParam, TContext context) { }
        public virtual TReturn VisitJavaScriptParameterList([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptParameterList javaScriptParameterListParam, TContext context) { }
        public virtual TReturn VisitJavaScriptStatement([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatement javaScriptStatementParam, TContext context) { }
        public virtual TReturn VisitJavaScriptStatementWithParenthesis([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatementWithParenthesis javaScriptStatementWithParenthesisParam, TContext context) { }
        public virtual TReturn VisitLabelledStatement([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.ILabelledStatement labelledStatementParam, TContext context) { }
        public virtual TReturn VisitMemberExpression([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IMemberExpression memberExpressionParam, TContext context) { }
        public virtual TReturn VisitNewExpression([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.INewExpression newExpressionParam, TContext context) { }
        public virtual TReturn VisitNode([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode node, TContext context) { }
        public virtual TReturn VisitObjectLiteral([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IObjectLiteral objectLiteralParam, TContext context) { }
        public virtual TReturn VisitObjectPropertiesList([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IObjectPropertiesList objectPropertiesListParam, TContext context) { }
        public virtual TReturn VisitObjectPropertyAccessor([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IObjectPropertyAccessor objectPropertyAccessorParam, TContext context) { }
        public virtual TReturn VisitObjectPropertyDeclaration([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IObjectPropertyDeclaration objectPropertyDeclarationParam, TContext context) { }
        public virtual TReturn VisitObjectPropertyInitializer([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IObjectPropertyInitializer objectPropertyInitializerParam, TContext context) { }
        public virtual TReturn VisitParenthesizedExpression([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IParenthesizedExpression parenthesizedExpressionParam, TContext context) { }
        public virtual TReturn VisitPostfixExpression([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IPostfixExpression postfixExpressionParam, TContext context) { }
        public virtual TReturn VisitPrefixExpression([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IPrefixExpression prefixExpressionParam, TContext context) { }
        public virtual TReturn VisitPropertyName([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IPropertyName propertyNameParam, TContext context) { }
        public virtual TReturn VisitPropertyNameIdentifier([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IPropertyNameIdentifier propertyNameIdentifierParam, TContext context) { }
        public virtual TReturn VisitPropertyNameNumericLiteral([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IPropertyNameNumericLiteral propertyNameNumericLiteralParam, TContext context) { }
        public virtual TReturn VisitPropertyNameStringLiteral([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IPropertyNameStringLiteral propertyNameStringLiteralParam, TContext context) { }
        public virtual TReturn VisitReferenceExpression([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IReferenceExpression referenceExpressionParam, TContext context) { }
        public virtual TReturn VisitReturnStatement([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IReturnStatement returnStatementParam, TContext context) { }
        public virtual TReturn VisitSwitchStatement([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.ISwitchStatement switchStatementParam, TContext context) { }
        public virtual TReturn VisitThisExpression([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IThisExpression thisExpressionParam, TContext context) { }
        public virtual TReturn VisitThrowStatement([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IThrowStatement throwStatementParam, TContext context) { }
        public virtual TReturn VisitTryStatement([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.ITryStatement tryStatementParam, TContext context) { }
        public virtual TReturn VisitVariableDeclaration([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IVariableDeclaration variableDeclarationParam, TContext context) { }
        public virtual TReturn VisitVariableDeclarationList([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IVariableDeclarationList variableDeclarationListParam, TContext context) { }
        public virtual TReturn VisitVariableStatement([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IVariableStatement variableStatementParam, TContext context) { }
        public virtual TReturn VisitWhileStatement([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IWhileStatement whileStatementParam, TContext context) { }
        public virtual TReturn VisitWithStatement([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IWithStatement withStatementParam, TContext context) { }
    }
    public class static TryStatementNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.ITryStatement GetByBlock(JetBrains.ReSharper.Psi.JavaScript.Tree.IBlock param) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.ITryStatement GetByCatch(JetBrains.ReSharper.Psi.JavaScript.Tree.ICatchBlock param) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.ITryStatement GetByCatchBlock(JetBrains.ReSharper.Psi.JavaScript.Tree.IBlock param) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.ITryStatement GetByFinally(JetBrains.ReSharper.Psi.JavaScript.Tree.IFinallyBlock param) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.ITryStatement GetByFinallyBlock(JetBrains.ReSharper.Psi.JavaScript.Tree.IBlock param) { }
    }
    public class static VariableDeclarationListNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.IVariableDeclarationList GetByVariableDeclaration(JetBrains.ReSharper.Psi.JavaScript.Tree.IVariableDeclaration param) { }
    }
    public class static VariableDeclarationNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.IVariableDeclaration GetByNameNode(JetBrains.ReSharper.Psi.JavaScript.Tree.IIdentifierExpression param) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.IVariableDeclaration GetByValue(JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression param) { }
    }
    public class static VariableStatementNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.IVariableStatement GetByDeclaration(JetBrains.ReSharper.Psi.JavaScript.Tree.IVariableDeclaration param) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.IVariableStatement GetByDeclarationList(JetBrains.ReSharper.Psi.JavaScript.Tree.IVariableDeclarationList param) { }
    }
    public class static WhileStatementNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.IWhileStatement GetByCondition(JetBrains.ReSharper.Psi.JavaScript.Tree.ICompoundExpression param) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.IWhileStatement GetByStatement(JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatement param) { }
    }
    public class static WithStatementNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.IWithStatement GetByCondition(JetBrains.ReSharper.Psi.JavaScript.Tree.ICompoundExpression param) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.IWithStatement GetByStatement(JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatement param) { }
    }
}
namespace JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript
{
    
    public interface ITsAccessorBody : JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IIncrementalScope, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IScope, JetBrains.ReSharper.Psi.JavaScript.Tree.IBlockScope, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptScope, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptTreeNode, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptTypedNode, JetBrains.ReSharper.Psi.JavaScript.Tree.IJsFunctionLike, JetBrains.ReSharper.Psi.JavaScript.Tree.IJsSignaturesOwner, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsFunctionLike, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsSignaturesOwner, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITypeScriptTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Tree.IXmlDocOwnerTreeNode
    {
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsAccessorSignature AccessorSignature { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsBlock Block { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsParameterDeclaration> Parameters { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeEnumerable<JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsParameterDeclaration> ParametersEnumerable { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsAccessorSignature SetAccessorSignature(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsAccessorSignature param);
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsBlock SetBlock(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsBlock param);
    }
    public interface ITsAccessorSignature : JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IIncrementalScope, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IScope, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptScope, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptTypedNode, JetBrains.ReSharper.Psi.JavaScript.Tree.IJsSignatureNode, JetBrains.ReSharper.Psi.JavaScript.Tree.IJsSignatureNodeInPars, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsParametersOwner, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsSignatureNode, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsSignatureNodeInPars, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeParametersOwner, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITypeScriptTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.Tree.ITokenNode LPar { get; }
        JetBrains.ReSharper.Psi.Tree.ITokenNode RPar { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeAnnotation TypeAnnotation { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeAnnotation SetTypeAnnotation(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeAnnotation param);
    }
    public interface ITsAmbientModuleName : JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITypeScriptTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        string ModuleName { get; }
        string Name { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsExpression NameExpression { get; }
        JetBrains.ReSharper.Psi.JavaScript.DeclaredElements.IJavaScriptTypeOwner GetDeclaredElement(JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsDocumentOffsetProvider context);
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsExpression SetNameExpression(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsExpression param);
    }
    public interface ITsArrayLiteral : JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptTreeNode, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsExpression, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsMemberExpression, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITypeScriptTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsExpression> ArrayElements { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeEnumerable<JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsExpression> ArrayElementsEnumerable { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<JetBrains.ReSharper.Psi.Tree.ITokenNode> Comma { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeEnumerable<JetBrains.ReSharper.Psi.Tree.ITokenNode> CommaEnumerable { get; }
        JetBrains.ReSharper.Psi.Tree.ITokenNode LBracket { get; }
        JetBrains.ReSharper.Psi.Tree.ITokenNode RBracket { get; }
    }
    public interface ITsArrayTypeUsage : JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeUsage, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITypeScriptTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.Tree.ITokenNode LBracket { get; }
        JetBrains.ReSharper.Psi.Tree.ITokenNode RBracket { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeUsage ReturnTypeUsage { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeUsage SetReturnTypeUsage(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeUsage param);
    }
    public interface ITsBaseTypeClause : JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITypeScriptTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeUsage> BaseTypes { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeEnumerable<JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeUsage> BaseTypesEnumerable { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.TsBaseTypeClauseKind ClauseKind { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<JetBrains.ReSharper.Psi.Tree.ITokenNode> Separator { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeEnumerable<JetBrains.ReSharper.Psi.Tree.ITokenNode> SeparatorEnumerable { get; }
    }
    public interface ITsBinaryExpression : JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptTreeNode, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsExpression, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITypeScriptTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.Tree.ITokenNode Sign { get; }
    }
    public interface ITsBlock : JetBrains.ReSharper.Psi.JavaScript.Tree.IBlock, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatement, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptTreeNode, JetBrains.ReSharper.Psi.JavaScript.Tree.IStatementsOwner, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsStatement, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITypeScriptTreeNode, JetBrains.ReSharper.Psi.Tree.IChameleonNode, JetBrains.ReSharper.Psi.Tree.IStatement, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        new JetBrains.ReSharper.Psi.Tree.ITokenNode LBrace { get; }
        new JetBrains.ReSharper.Psi.Tree.ITokenNode RBrace { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsStatement> Statements { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeEnumerable<JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsStatement> StatementsEnumerable { get; }
    }
    public interface ITsBlockLambdaExpression : JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IIncrementalScope, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IScope, JetBrains.ReSharper.Psi.JavaScript.Tree.IBlockScope, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptScope, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptTreeNode, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptTypedNode, JetBrains.ReSharper.Psi.JavaScript.Tree.IJsFunctionLike, JetBrains.ReSharper.Psi.JavaScript.Tree.IJsSignaturesOwner, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsExpression, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsFunctionLike, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsLambdaExpression, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsSignaturesOwner, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITypeScriptTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Tree.IXmlDocOwnerTreeNode
    {
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsBlock Block { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsBlock SetBlock(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsBlock param);
    }
    public interface ITsBreakStatement : JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatement, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptTreeNode, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsStatement, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITypeScriptTreeNode, JetBrains.ReSharper.Psi.Tree.IStatement, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.Tree.ITokenNode BreakKeyword { get; }
        JetBrains.ReSharper.Psi.Tree.ITokenNode Semicolon { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsCompoundExpression Value { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsCompoundExpression SetValue(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsCompoundExpression param);
    }
    public interface ITsCallSignatureDeclaration : JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IIncrementalScope, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IScope, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptScope, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptTypedNode, JetBrains.ReSharper.Psi.JavaScript.Tree.IJsSignatureNode, JetBrains.ReSharper.Psi.JavaScript.Tree.IJsSignatureNodeInPars, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsParametersOwner, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsSignatureNode, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsSignatureNodeInPars, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeMemberDeclaration, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeParametersOwner, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITypeScriptTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.Tree.ITokenNode LPar { get; }
        JetBrains.ReSharper.Psi.Tree.ITokenNode NewKeyword { get; }
        JetBrains.ReSharper.Psi.Tree.ITokenNode RPar { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeParameterDeclaration> TypeParameterDeclarations { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeEnumerable<JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeParameterDeclaration> TypeParameterDeclarationsEnumerable { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeParameters TypeParametersSpecification { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeParameters SetTypeParametersSpecification(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeParameters param);
    }
    public interface ITsCaseCaseClause : JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsCaseClause, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITypeScriptTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.Tree.ITokenNode CaseKeyword { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsCompoundExpression Value { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsCompoundExpression SetValue(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsCompoundExpression param);
    }
    public interface ITsCaseClause : JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITypeScriptTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.Tree.ITokenNode Colon { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsStatement> Statements { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeEnumerable<JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsStatement> StatementsEnumerable { get; }
    }
    public interface ITsCaseClausesList : JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITypeScriptTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsCaseClause> CaseClauses { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeEnumerable<JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsCaseClause> CaseClausesEnumerable { get; }
    }
    public interface ITsCastExpression : JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptTreeNode, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsExpression, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsMemberExpression, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITypeScriptTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsExpression Expression { get; }
        JetBrains.ReSharper.Psi.Tree.ITokenNode Gt { get; }
        JetBrains.ReSharper.Psi.Tree.ITokenNode Lt { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeUsage TypeUsage { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsExpression SetExpression(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsExpression param);
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeUsage SetTypeUsage(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeUsage param);
    }
    public interface ITsCatchBlock : JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITypeScriptTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsBlock Block { get; }
        JetBrains.ReSharper.Psi.Tree.ITokenNode CatchKeyword { get; }
        JetBrains.ReSharper.Psi.Tree.ITokenNode LPar { get; }
        JetBrains.ReSharper.Psi.Tree.ITokenNode RPar { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsVariableDeclaration VariableDeclaration { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsBlock SetBlock(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsBlock param);
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsVariableDeclaration SetVariableDeclaration(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsVariableDeclaration param);
    }
    public interface ITsClassDeclaration : JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptDeclaration, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptDeclaredElementProvider, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatement, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptTreeNode, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsStatement, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeDeclaration, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeParametersOwner, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITypeScriptGlobalDeclaration, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITypeScriptModifiersOwner, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITypeScriptTreeNode, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITypeScriptTypeMemberOwner, JetBrains.ReSharper.Psi.Tree.IDeclaration, JetBrains.ReSharper.Psi.Tree.IStatement, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Tree.IXmlDocOwnerTreeNode
    {
        JetBrains.ReSharper.Psi.Tree.ITokenNode ClassKeyword { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsClassMemberDeclaration> ClassMembers { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeEnumerable<JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsClassMemberDeclaration> ClassMembersEnumerable { get; }
        new JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeParameters TypeParametersSpecification { get; }
        new JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeParameters SetTypeParametersSpecification(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeParameters param);
    }
    public interface ITsClassMemberDeclaration : JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITypeScriptModifiersOwner, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITypeScriptTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.TsAccessModifier AccessRights { get; }
    }
    public interface ITsCompoundExpression : JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITypeScriptTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<JetBrains.ReSharper.Psi.Tree.ITokenNode> Comma { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeEnumerable<JetBrains.ReSharper.Psi.Tree.ITokenNode> CommaEnumerable { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsExpression> Expressions { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeEnumerable<JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsExpression> ExpressionsEnumerable { get; }
    }
    public interface ITsConditionalTernaryExpression : JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptTreeNode, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsExpression, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITypeScriptTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.Tree.ITokenNode Colon { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsExpression ConditionOperand { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsExpression ElseResult { get; }
        JetBrains.ReSharper.Psi.Tree.ITokenNode Question { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsExpression ThenResult { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsExpression SetConditionOperand(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsExpression param);
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsExpression SetElseResult(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsExpression param);
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsExpression SetThenResult(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsExpression param);
    }
    public interface ITsConstructorDeclaration : JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IIncrementalScope, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IScope, JetBrains.ReSharper.Psi.JavaScript.Tree.IBlockScope, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptScope, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptTreeNode, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptTypedNode, JetBrains.ReSharper.Psi.JavaScript.Tree.IJsFunctionLike, JetBrains.ReSharper.Psi.JavaScript.Tree.IJsSignaturesOwner, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsClassMemberDeclaration, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsFunctionLike, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsSignaturesOwner, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITypeScriptModifiersOwner, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITypeScriptTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Tree.IXmlDocOwnerTreeNode
    {
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsBlock Block { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsConstructorOverloadDeclaration LastOverload { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsConstructorOverloadDeclaration> Overloads { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeEnumerable<JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsConstructorOverloadDeclaration> OverloadsEnumerable { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsClassDeclaration Owner { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsBlock SetBlock(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsBlock param);
    }
    public interface ITsConstructorOverloadDeclaration : JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IIncrementalScope, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IScope, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptScope, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptTypedNode, JetBrains.ReSharper.Psi.JavaScript.Tree.IJsSignatureNode, JetBrains.ReSharper.Psi.JavaScript.Tree.IJsSignatureNodeInPars, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsParametersOwner, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsSignatureNode, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsSignatureNodeInPars, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeParametersOwner, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITypeScriptModifiersOwner, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITypeScriptTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.Tree.ITokenNode ConstructorKeyword { get; }
        bool IsOverloadOrAmbient { get; }
        JetBrains.ReSharper.Psi.Tree.ITokenNode LPar { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<JetBrains.ReSharper.Psi.Tree.ITokenNode> ModifierKeyword { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeEnumerable<JetBrains.ReSharper.Psi.Tree.ITokenNode> ModifierKeywordEnumerable { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsConstructorDeclaration Owner { get; }
        JetBrains.ReSharper.Psi.Tree.ITokenNode RPar { get; }
        JetBrains.ReSharper.Psi.Tree.ITokenNode Semicolon { get; }
    }
    public interface ITsContinueStatement : JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatement, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptTreeNode, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsStatement, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITypeScriptTreeNode, JetBrains.ReSharper.Psi.Tree.IStatement, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.Tree.ITokenNode ContinueKeyword { get; }
        JetBrains.ReSharper.Psi.Tree.ITokenNode Semicolon { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsCompoundExpression Value { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsCompoundExpression SetValue(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsCompoundExpression param);
    }
    public interface ITsDebugStatement : JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatement, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptTreeNode, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsStatement, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITypeScriptTreeNode, JetBrains.ReSharper.Psi.Tree.IStatement, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.Tree.ITokenNode DebugKeyword { get; }
        JetBrains.ReSharper.Psi.Tree.ITokenNode Semicolon { get; }
    }
    public interface ITsDeclaredTypeUsage : JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeUsage, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITypeScriptTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsReferenceName ModuleName { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsReferenceName SetModuleName(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsReferenceName param);
    }
    public interface ITsDefaultClause : JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsCaseClause, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITypeScriptTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.Tree.ITokenNode DefaultKeyword { get; }
    }
    public interface ITsDoStatement : JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatement, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptTreeNode, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsStatement, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsStatementWithParenthesis, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITypeScriptTreeNode, JetBrains.ReSharper.Psi.Tree.IStatement, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsCompoundExpression Condition { get; }
        JetBrains.ReSharper.Psi.Tree.ITokenNode DoKeyword { get; }
        JetBrains.ReSharper.Psi.Tree.ITokenNode Semicolon { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsStatement Statement { get; }
        JetBrains.ReSharper.Psi.Tree.ITokenNode WhileKeyword { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsCompoundExpression SetCondition(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsCompoundExpression param);
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsStatement SetStatement(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsStatement param);
    }
    public interface ITsEmptyStatement : JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatement, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptTreeNode, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsStatement, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITypeScriptTreeNode, JetBrains.ReSharper.Psi.Tree.IStatement, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.Tree.ITokenNode Semicolon { get; }
    }
    public interface ITsEnumDeclaration : JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatement, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptTreeNode, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsStatement, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITypeScriptTreeNode, JetBrains.ReSharper.Psi.Tree.IDeclaration, JetBrains.ReSharper.Psi.Tree.IStatement, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Tree.IXmlDocOwnerTreeNode
    {
        JetBrains.ReSharper.Psi.Tree.ITokenNode EnumKeyword { get; }
        JetBrains.ReSharper.Psi.Tree.ITokenNode LBrace { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsEnumMemberDeclaration> Members { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeEnumerable<JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsEnumMemberDeclaration> MembersEnumerable { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<JetBrains.ReSharper.Psi.Tree.ITokenNode> ModifierKeyword { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeEnumerable<JetBrains.ReSharper.Psi.Tree.ITokenNode> ModifierKeywordEnumerable { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsIdentifierExpression NameNode { get; }
        JetBrains.ReSharper.Psi.Tree.ITokenNode RBrace { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<JetBrains.ReSharper.Psi.Tree.ITokenNode> Separator { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeEnumerable<JetBrains.ReSharper.Psi.Tree.ITokenNode> SeparatorEnumerable { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsIdentifierExpression SetNameNode(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsIdentifierExpression param);
    }
    public interface ITsEnumMemberDeclaration : JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITypeScriptTreeNode, JetBrains.ReSharper.Psi.Tree.IDeclaration, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Tree.IXmlDocOwnerTreeNode
    {
        JetBrains.ReSharper.Psi.Tree.ITokenNode Eq { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsIdentifierExpression NameNode { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsExpression Value { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsIdentifierExpression SetNameNode(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsIdentifierExpression param);
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsExpression SetValue(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsExpression param);
    }
    public interface ITsExpression : JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptTreeNode, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITypeScriptTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode { }
    public interface ITsExpressionLambdaExpression : JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IIncrementalScope, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IScope, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptScope, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptTreeNode, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptTypedNode, JetBrains.ReSharper.Psi.JavaScript.Tree.IJsSignaturesOwner, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsExpression, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsLambdaExpression, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsSignaturesOwner, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITypeScriptTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Tree.IXmlDocOwnerTreeNode
    {
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsExpression Expression { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsExpression SetExpression(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsExpression param);
    }
    public interface ITsExpressionStatement : JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatement, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptTreeNode, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsStatement, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITypeScriptTreeNode, JetBrains.ReSharper.Psi.Tree.IStatement, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsCompoundExpression Expression { get; }
        JetBrains.ReSharper.Psi.Tree.ITokenNode Semicolon { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsCompoundExpression SetExpression(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsCompoundExpression param);
    }
    public interface ITsExtendsClause : JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsBaseTypeClause, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITypeScriptTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.Tree.ITokenNode ExtendsKeyword { get; }
    }
    public interface ITsExternalModuleReferenceName : JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsImportModuleClause, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITypeScriptTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsAmbientModuleName AmbientName { get; }
        JetBrains.ReSharper.Psi.Tree.ITokenNode LPar { get; }
        JetBrains.ReSharper.Psi.Tree.ITokenNode ModuleKeyword { get; }
        JetBrains.ReSharper.Psi.Tree.ITokenNode RPar { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsAmbientModuleName SetAmbientName(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsAmbientModuleName param);
    }
    public interface ITsFile : JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IIncrementalScope, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IScope, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptFile, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptScope, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptTreeNode, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITypeScriptModuleScope, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITypeScriptTreeNode, JetBrains.ReSharper.Psi.Tree.IFile, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsStatement> AllStatements { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeEnumerable<JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsStatement> AllStatementsEnumerable { get; }
        bool IsExternalModule { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsFileSection> Sections { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeEnumerable<JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsFileSection> SectionsEnumerable { get; }
        new JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<JetBrains.ReSharper.Psi.Tree.ITokenNode> Separator { get; }
        new JetBrains.ReSharper.Psi.Tree.TreeNodeEnumerable<JetBrains.ReSharper.Psi.Tree.ITokenNode> SeparatorEnumerable { get; }
    }
    public interface ITsFileSection : JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITypeScriptTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsStatement> Statements { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeEnumerable<JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsStatement> StatementsEnumerable { get; }
    }
    public interface ITsFinallyBlock : JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITypeScriptTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsBlock Block { get; }
        JetBrains.ReSharper.Psi.Tree.ITokenNode FinallyKeyword { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsBlock SetBlock(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsBlock param);
    }
    public interface ITsForDeclarationInitializer : JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsForInitializer, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITypeScriptTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsVariableDeclarationsList DeclarationList { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsVariableDeclaration> Declarations { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeEnumerable<JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsVariableDeclaration> DeclarationsEnumerable { get; }
        JetBrains.ReSharper.Psi.Tree.ITokenNode VarKeyword { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsVariableDeclarationsList SetDeclarationList(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsVariableDeclarationsList param);
    }
    public interface ITsForeachStatement : JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatement, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptTreeNode, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsStatement, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsStatementWithParenthesis, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITypeScriptTreeNode, JetBrains.ReSharper.Psi.Tree.IStatement, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsForInitializer ForInitializer { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsCompoundExpression ForIterator { get; }
        JetBrains.ReSharper.Psi.Tree.ITokenNode ForKeyword { get; }
        JetBrains.ReSharper.Psi.Tree.ITokenNode InKeyword { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsStatement Statement { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsForInitializer SetForInitializer(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsForInitializer param);
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsCompoundExpression SetForIterator(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsCompoundExpression param);
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsStatement SetStatement(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsStatement param);
    }
    public interface ITsForExpressionInitializer : JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsForInitializer, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITypeScriptTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsCompoundExpression Expression { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsCompoundExpression SetExpression(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsCompoundExpression param);
    }
    public interface ITsForInitializer : JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITypeScriptTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode { }
    public interface ITsForStatement : JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatement, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptTreeNode, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsStatement, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsStatementWithParenthesis, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITypeScriptTreeNode, JetBrains.ReSharper.Psi.Tree.IStatement, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsCompoundExpression ForCondition { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsForInitializer ForInitializer { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsCompoundExpression ForIterator { get; }
        JetBrains.ReSharper.Psi.Tree.ITokenNode ForKeyword { get; }
        JetBrains.ReSharper.Psi.Tree.ITokenNode Semicolon1 { get; }
        JetBrains.ReSharper.Psi.Tree.ITokenNode Semicolon2 { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsStatement Statement { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsCompoundExpression SetForCondition(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsCompoundExpression param);
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsForInitializer SetForInitializer(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsForInitializer param);
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsCompoundExpression SetForIterator(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsCompoundExpression param);
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsStatement SetStatement(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsStatement param);
    }
    public interface ITsFunctionExpression : JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IIncrementalScope, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IScope, JetBrains.ReSharper.Psi.JavaScript.Tree.IBlockScope, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptScope, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptTreeNode, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptTypedNode, JetBrains.ReSharper.Psi.JavaScript.Tree.IJsFunctionLike, JetBrains.ReSharper.Psi.JavaScript.Tree.IJsSignaturesOwner, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsExpression, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsFunctionLike, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsMemberExpression, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsParametersOwner, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsSignaturesOwner, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITypeScriptTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Tree.IXmlDocOwnerTreeNode
    {
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsBlock Block { get; }
        new JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsParameterDeclaration> Parameters { get; }
        new JetBrains.ReSharper.Psi.Tree.TreeNodeEnumerable<JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsParameterDeclaration> ParametersEnumerable { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsFunctionExpressionSignature Signature { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsBlock SetBlock(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsBlock param);
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsFunctionExpressionSignature SetSignature(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsFunctionExpressionSignature param);
    }
    public interface ITsFunctionExpressionSignature : JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IIncrementalScope, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IScope, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptScope, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptTypedNode, JetBrains.ReSharper.Psi.JavaScript.Tree.IJsSignatureNode, JetBrains.ReSharper.Psi.JavaScript.Tree.IJsSignatureNodeInPars, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsParametersOwner, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsSignatureNode, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsSignatureNodeInPars, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeParametersOwner, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITypeScriptModifiersOwner, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITypeScriptTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        [JetBrains.Annotations.NotNullAttribute()]
        string DeclaredName { get; }
        JetBrains.ReSharper.Psi.Tree.ITokenNode FunctionKeyword { get; }
        JetBrains.ReSharper.Psi.Tree.ITokenNode LPar { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsIdentifierExpression NameNode { get; }
        JetBrains.ReSharper.Psi.Tree.ITokenNode RPar { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeAnnotation TypeAnnotation { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeParameters TypeParametersSpecification { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsIdentifierExpression SetNameNode(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsIdentifierExpression param);
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeAnnotation SetTypeAnnotation(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeAnnotation param);
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeParameters SetTypeParametersSpecification(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeParameters param);
    }
    public interface ITsFunctionLike : JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IIncrementalScope, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IScope, JetBrains.ReSharper.Psi.JavaScript.Tree.IBlockScope, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptScope, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptTreeNode, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptTypedNode, JetBrains.ReSharper.Psi.JavaScript.Tree.IJsFunctionLike, JetBrains.ReSharper.Psi.JavaScript.Tree.IJsSignaturesOwner, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsSignaturesOwner, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Tree.IXmlDocOwnerTreeNode { }
    public interface ITsFunctionSignatureDeclaration : JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IIncrementalScope, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IScope, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptScope, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptTypedNode, JetBrains.ReSharper.Psi.JavaScript.Tree.IJsSignatureNode, JetBrains.ReSharper.Psi.JavaScript.Tree.IJsSignatureNodeInPars, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsParametersOwner, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsSignatureNode, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsSignatureNodeInPars, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeMemberDeclaration, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeParametersOwner, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITypeScriptTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        [JetBrains.Annotations.NotNullAttribute()]
        string DeclaredName { get; }
        JetBrains.ReSharper.Psi.Tree.ITokenNode LPar { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsIdentifierExpression Name { get; }
        JetBrains.ReSharper.Psi.Tree.ITokenNode Question { get; }
        JetBrains.ReSharper.Psi.Tree.ITokenNode RPar { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeParameters TypeParametersSpecification { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsIdentifierExpression SetName(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsIdentifierExpression param);
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeParameters SetTypeParametersSpecification(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeParameters param);
    }
    public interface ITsFunctionStatement : JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IIncrementalScope, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IScope, JetBrains.ReSharper.Psi.JavaScript.Tree.IBlockScope, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptDeclaration, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptDeclaredElementProvider, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptScope, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatement, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptTreeNode, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptTypedNode, JetBrains.ReSharper.Psi.JavaScript.Tree.IJsFunctionLike, JetBrains.ReSharper.Psi.JavaScript.Tree.IJsSignaturesOwner, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsFunctionLike, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsSignaturesOwner, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsStatement, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITypeScriptGlobalDeclaration, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITypeScriptModifiersOwner, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITypeScriptTreeNode, JetBrains.ReSharper.Psi.Tree.IDeclaration, JetBrains.ReSharper.Psi.Tree.IStatement, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Tree.IXmlDocOwnerTreeNode
    {
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsBlock Block { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsFunctionStatementSignature LastOverload { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsFunctionStatementSignature> Signatures { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeEnumerable<JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsFunctionStatementSignature> SignaturesEnumerable { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsBlock SetBlock(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsBlock param);
    }
    public interface ITsFunctionStatementSignature : JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITypeScriptModifiersOwner, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITypeScriptTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        bool IsOverloadOrAmbient { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<JetBrains.ReSharper.Psi.Tree.ITokenNode> ModifierKeyword { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeEnumerable<JetBrains.ReSharper.Psi.Tree.ITokenNode> ModifierKeywordEnumerable { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsFunctionStatement Owner { get; }
        JetBrains.ReSharper.Psi.Tree.ITokenNode Semicolon { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsFunctionExpressionSignature Signature { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsFunctionExpressionSignature SetSignature(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsFunctionExpressionSignature param);
    }
    public interface ITsFunctionTypeUsage : JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IIncrementalScope, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IScope, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptScope, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptTypedNode, JetBrains.ReSharper.Psi.JavaScript.Tree.IJsSignatureNode, JetBrains.ReSharper.Psi.JavaScript.Tree.IJsSignatureNodeInPars, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsParametersOwner, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsSignatureNode, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsSignatureNodeInPars, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeParametersOwner, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeUsage, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITypeScriptTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.Tree.ITokenNode Arrow { get; }
        JetBrains.ReSharper.Psi.Tree.ITokenNode LPar { get; }
        JetBrains.ReSharper.Psi.Tree.ITokenNode NewKeyword { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeUsage ReturnTypeUsage { get; }
        JetBrains.ReSharper.Psi.Tree.ITokenNode RPar { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeParameters TypeParametersSpecification { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeUsage SetReturnTypeUsage(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeUsage param);
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeParameters SetTypeParametersSpecification(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeParameters param);
    }
    public interface ITsIdentifierExpression : JetBrains.ReSharper.Psi.JavaScript.Tree.IIdentifierExpression, JetBrains.ReSharper.Psi.JavaScript.Tree.IIdentifierExpressionBase, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptTreeNode, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITypeScriptTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        new JetBrains.ReSharper.Psi.Tree.ITokenNode AlienToken { get; }
        new JetBrains.ReSharper.Psi.Tree.ITokenNode NameToken { get; }
    }
    public interface ITsIfStatement : JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatement, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptTreeNode, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsStatement, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsStatementWithParenthesis, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITypeScriptTreeNode, JetBrains.ReSharper.Psi.Tree.IStatement, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsCompoundExpression Condition { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsStatement Else { get; }
        JetBrains.ReSharper.Psi.Tree.ITokenNode ElseKeyword { get; }
        JetBrains.ReSharper.Psi.Tree.ITokenNode IfKeyword { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsStatement Then { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsCompoundExpression SetCondition(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsCompoundExpression param);
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsStatement SetElse(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsStatement param);
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsStatement SetThen(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsStatement param);
    }
    public interface ITsImplementsClause : JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsBaseTypeClause, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITypeScriptTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.Tree.ITokenNode ImplementsKeyword { get; }
    }
    public interface ITsImportDeclaration : JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptDeclaredElementProvider, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatement, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptTreeNode, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsStatement, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITypeScriptTreeNode, JetBrains.ReSharper.Psi.Tree.IDeclaration, JetBrains.ReSharper.Psi.Tree.IStatement, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Tree.IXmlDocOwnerTreeNode
    {
        JetBrains.ReSharper.Psi.Tree.ITokenNode ImportKeyword { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsImportModuleClause ModuleReference { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsIdentifierExpression NameIdentifier { get; }
        JetBrains.ReSharper.Psi.Tree.ITokenNode SignEq { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsImportModuleClause SetModuleReference(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsImportModuleClause param);
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsIdentifierExpression SetNameIdentifier(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsIdentifierExpression param);
    }
    public interface ITsImportModuleClause : JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITypeScriptTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.JavaScript.Resolve.IJavaScriptType GetJsType(JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsLocalElementResolver context);
    }
    public interface ITsIndexExpression : JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptTreeNode, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsExpression, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsMemberExpression, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITypeScriptTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsExpression> Arguments { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeEnumerable<JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsExpression> ArgumentsEnumerable { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<JetBrains.ReSharper.Psi.Tree.ITokenNode> Comma { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeEnumerable<JetBrains.ReSharper.Psi.Tree.ITokenNode> CommaEnumerable { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsMemberExpression IndexedExpression { get; }
        JetBrains.ReSharper.Psi.Tree.ITokenNode LBracket { get; }
        JetBrains.ReSharper.Psi.Tree.ITokenNode RBracket { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsMemberExpression SetIndexedExpression(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsMemberExpression param);
    }
    public interface ITsIndexSignatureDeclaration : JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IIncrementalScope, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IScope, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptScope, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptTypedNode, JetBrains.ReSharper.Psi.JavaScript.Tree.IJsSignatureNode, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsParametersOwner, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeMemberDeclaration, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITypeScriptTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.Tree.ITokenNode LBracket { get; }
        JetBrains.ReSharper.Psi.Tree.ITokenNode RBracket { get; }
    }
    public interface ITsInterfaceDeclaration : JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptDeclaration, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptDeclaredElementProvider, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatement, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptTreeNode, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsStatement, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeDeclaration, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeParametersOwner, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITypeScriptGlobalDeclaration, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITypeScriptModifiersOwner, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITypeScriptTreeNode, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITypeScriptTypeMemberOwner, JetBrains.ReSharper.Psi.Tree.IDeclaration, JetBrains.ReSharper.Psi.Tree.IStatement, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Tree.IXmlDocOwnerTreeNode
    {
        JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<JetBrains.ReSharper.Psi.Tree.ITokenNode> InterfaceKeyword { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeEnumerable<JetBrains.ReSharper.Psi.Tree.ITokenNode> InterfaceKeywordEnumerable { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeMemberDeclaration> InterfaceMembers { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeEnumerable<JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeMemberDeclaration> InterfaceMembersEnumerable { get; }
        new JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeParameters TypeParametersSpecification { get; }
        new JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeParameters SetTypeParametersSpecification(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeParameters param);
    }
    public interface ITsInvocationExpression : JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptTreeNode, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsExpression, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsMemberExpression, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITypeScriptTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsExpression> Arguments { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeEnumerable<JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsExpression> ArgumentsEnumerable { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<JetBrains.ReSharper.Psi.Tree.ITokenNode> Comma { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeEnumerable<JetBrains.ReSharper.Psi.Tree.ITokenNode> CommaEnumerable { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsExpression InvokedExpression { get; }
        JetBrains.ReSharper.Psi.Tree.ITokenNode LParenth { get; }
        JetBrains.ReSharper.Psi.Tree.ITokenNode RParenth { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeArgumentList TypeArgumentList { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeUsage> TypeArguments { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeEnumerable<JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeUsage> TypeArgumentsEnumerable { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsExpression SetInvokedExpression(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsExpression param);
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeArgumentList SetTypeArgumentList(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeArgumentList param);
    }
    public interface ITsLabelledStatement : JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatement, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptTreeNode, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsStatement, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITypeScriptTreeNode, JetBrains.ReSharper.Psi.Tree.IStatement, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.Tree.ITokenNode Colon { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsIdentifierExpression NameNode { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsStatement Statement { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsIdentifierExpression SetNameNode(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsIdentifierExpression param);
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsStatement SetStatement(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsStatement param);
    }
    public interface ITsLambdaExpression : JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IIncrementalScope, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IScope, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptScope, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptTreeNode, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptTypedNode, JetBrains.ReSharper.Psi.JavaScript.Tree.IJsSignaturesOwner, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsExpression, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsSignaturesOwner, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITypeScriptTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Tree.IXmlDocOwnerTreeNode
    {
        JetBrains.ReSharper.Psi.Tree.ITokenNode Arrow { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsLambdaExpressionSignature Signature { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsLambdaExpressionSignature SetSignature(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsLambdaExpressionSignature param);
    }
    public interface ITsLambdaExpressionFullSignature : JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IIncrementalScope, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IScope, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptScope, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptTypedNode, JetBrains.ReSharper.Psi.JavaScript.Tree.IJsSignatureNode, JetBrains.ReSharper.Psi.JavaScript.Tree.IJsSignatureNodeInPars, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsLambdaExpressionSignature, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsParametersOwner, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsSignatureNode, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsSignatureNodeInPars, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeParametersOwner, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITypeScriptTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.Tree.ITokenNode LPar { get; }
        JetBrains.ReSharper.Psi.Tree.ITokenNode RPar { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeAnnotation TypeAnnotation { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeParameters TypeParametersSpecification { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeAnnotation SetTypeAnnotation(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeAnnotation param);
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeParameters SetTypeParametersSpecification(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeParameters param);
    }
    public interface ITsLambdaExpressionSignature : JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IIncrementalScope, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IScope, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptScope, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptTypedNode, JetBrains.ReSharper.Psi.JavaScript.Tree.IJsSignatureNode, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsSignatureNode, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITypeScriptTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode { }
    public interface ITsLambdaExpressionSimpleSignature : JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IIncrementalScope, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IScope, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptDeclaration, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptParameterDeclarationBase, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptScope, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptTreeNode, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptTypedNode, JetBrains.ReSharper.Psi.JavaScript.Tree.IJsSignatureNode, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsLambdaExpressionSignature, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsParameterDeclarationBase, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsSignatureNode, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITypeScriptTreeNode, JetBrains.ReSharper.Psi.Tree.IDeclaration, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Tree.IXmlDocOwnerTreeNode
    {
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsIdentifierExpression NameNode { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsIdentifierExpression SetNameNode(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsIdentifierExpression param);
    }
    public interface ITsLiteralExpression : JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptLiteralExpression, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptTreeNode, JetBrains.ReSharper.Psi.JavaScript.Tree.IMemberExpression, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsExpression, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsMemberExpression, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITypeScriptTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        new JetBrains.ReSharper.Psi.Tree.ITokenNode Literal { get; }
    }
    public interface ITsMemberAccessorDeclaration : JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IIncrementalScope, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IScope, JetBrains.ReSharper.Psi.JavaScript.Tree.IBlockScope, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptScope, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptTreeNode, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptTypedNode, JetBrains.ReSharper.Psi.JavaScript.Tree.IJsFunctionLike, JetBrains.ReSharper.Psi.JavaScript.Tree.IJsSignaturesOwner, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsClassMemberDeclaration, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsFunctionLike, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsSignaturesOwner, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITypeScriptModifiersOwner, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITypeScriptTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Tree.IXmlDocOwnerTreeNode
    {
        JetBrains.ReSharper.Psi.Tree.ITokenNode AccessorType { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsBlock Block { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        string DeclaredName { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.TsPropertyAccessorKind Kind { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<JetBrains.ReSharper.Psi.Tree.ITokenNode> ModifierKeyword { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeEnumerable<JetBrains.ReSharper.Psi.Tree.ITokenNode> ModifierKeywordEnumerable { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsIdentifierExpression Name { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsParameterDeclaration> Parameters { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeEnumerable<JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsParameterDeclaration> ParametersEnumerable { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsMemberAccessorSignature Signature { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsBlock SetBlock(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsBlock param);
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsIdentifierExpression SetName(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsIdentifierExpression param);
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsMemberAccessorSignature SetSignature(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsMemberAccessorSignature param);
    }
    public interface ITsMemberAccessorSignature : JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IIncrementalScope, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IScope, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptScope, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptTypedNode, JetBrains.ReSharper.Psi.JavaScript.Tree.IJsSignatureNode, JetBrains.ReSharper.Psi.JavaScript.Tree.IJsSignatureNodeInPars, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsParametersOwner, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsSignatureNode, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsSignatureNodeInPars, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITypeScriptTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.Tree.ITokenNode LPar { get; }
        JetBrains.ReSharper.Psi.Tree.ITokenNode RPar { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeAnnotation TypeAnnotation { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeAnnotation SetTypeAnnotation(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeAnnotation param);
    }
    public interface ITsMemberExpression : JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptTreeNode, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsExpression, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITypeScriptTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode { }
    public interface ITsMemberFunctionDeclaration : JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IIncrementalScope, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IScope, JetBrains.ReSharper.Psi.JavaScript.Tree.IBlockScope, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptScope, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptTreeNode, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptTypedNode, JetBrains.ReSharper.Psi.JavaScript.Tree.IJsFunctionLike, JetBrains.ReSharper.Psi.JavaScript.Tree.IJsSignaturesOwner, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsClassMemberDeclaration, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsFunctionLike, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsSignaturesOwner, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITypeScriptModifiersOwner, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITypeScriptTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Tree.IXmlDocOwnerTreeNode
    {
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsBlock Block { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsMemberFunctionOverloadDeclaration LastOverload { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsMemberFunctionOverloadDeclaration> Overloads { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeEnumerable<JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsMemberFunctionOverloadDeclaration> OverloadsEnumerable { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsClassDeclaration Owner { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsBlock SetBlock(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsBlock param);
    }
    public interface ITsMemberFunctionOverloadDeclaration : JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IIncrementalScope, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IScope, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptScope, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptTypedNode, JetBrains.ReSharper.Psi.JavaScript.Tree.IJsSignatureNode, JetBrains.ReSharper.Psi.JavaScript.Tree.IJsSignatureNodeInPars, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsParametersOwner, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsSignatureNode, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsSignatureNodeInPars, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeParametersOwner, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITypeScriptModifiersOwner, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITypeScriptTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.TsAccessModifier AccessRights { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        string DeclaredName { get; }
        bool IsOverloadOrAmbient { get; }
        JetBrains.ReSharper.Psi.Tree.ITokenNode LPar { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<JetBrains.ReSharper.Psi.Tree.ITokenNode> ModifierKeyword { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeEnumerable<JetBrains.ReSharper.Psi.Tree.ITokenNode> ModifierKeywordEnumerable { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsIdentifierExpression Name { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsMemberFunctionDeclaration Owner { get; }
        JetBrains.ReSharper.Psi.Tree.ITokenNode RPar { get; }
        JetBrains.ReSharper.Psi.Tree.ITokenNode Semicolon { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeAnnotation TypeAnnotation { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeParameters TypeParametersSpecification { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsIdentifierExpression SetName(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsIdentifierExpression param);
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeAnnotation SetTypeAnnotation(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeAnnotation param);
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeParameters SetTypeParametersSpecification(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeParameters param);
    }
    public interface ITsMemberVariableDeclaration : JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsClassMemberDeclaration, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITypeScriptModifiersOwner, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITypeScriptTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        [JetBrains.Annotations.NotNullAttribute()]
        string DeclaredName { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<JetBrains.ReSharper.Psi.Tree.ITokenNode> ModifierKeyword { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeEnumerable<JetBrains.ReSharper.Psi.Tree.ITokenNode> ModifierKeywordEnumerable { get; }
        JetBrains.ReSharper.Psi.Tree.ITokenNode Semicolon { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsVariableDeclaration VariableDeclaration { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsVariableDeclaration SetVariableDeclaration(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsVariableDeclaration param);
    }
    public interface ITsModuleDeclaration : JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IIncrementalScope, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IScope, JetBrains.ReSharper.Psi.JavaScript.Tree.IBlockScope, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptDeclaredElementProvider, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptScope, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatement, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptTreeNode, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsStatement, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITypeScriptModifiersOwner, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITypeScriptModuleScope, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITypeScriptTreeNode, JetBrains.ReSharper.Psi.Tree.IStatement, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsBlock Block { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<JetBrains.ReSharper.Psi.Tree.ITokenNode> ModifierKeyword { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeEnumerable<JetBrains.ReSharper.Psi.Tree.ITokenNode> ModifierKeywordEnumerable { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<JetBrains.ReSharper.Psi.Tree.ITokenNode> ModuleKeyword { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeEnumerable<JetBrains.ReSharper.Psi.Tree.ITokenNode> ModuleKeywordEnumerable { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsModuleDeclarationName ModuleNameNode { get; }
        string PresentableFullName { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsBlock SetBlock(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsBlock param);
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsModuleDeclarationName SetModuleNameNode(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsModuleDeclarationName param);
    }
    public interface ITsModuleDeclarationName : JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITypeScriptTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsAmbientModuleName ExternalName { get; }
        bool IsDynamic { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsModuleQualifiedName Name { get; }
        string PresentableFullName { get; }
        JetBrains.ReSharper.Psi.Resolve.ISymbolTable AddGlobalDeclarations(JetBrains.ReSharper.Psi.Resolve.ISymbolTable parentTable, int level, JetBrains.ReSharper.Psi.Resolve.SymbolTableMode mode);
        JetBrains.ReSharper.Psi.JavaScript.DeclaredElements.IJavaScriptTypeOwner GetDeclaredElement(JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsDocumentOffsetProvider context, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsModuleDeclaration tsModuleDeclaration);
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IDeclaredElement> GetDeclaredElements(JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsDocumentOffsetProvider context);
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsAmbientModuleName SetExternalName(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsAmbientModuleName param);
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsModuleQualifiedName SetName(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsModuleQualifiedName param);
    }
    public interface ITsModuleQualifiedName : JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.IDeclarationReferenceOwner, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITypeScriptTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.Tree.ITokenNode Dot { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        string FullName { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsIdentifierExpression NameIdentifier { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.IList<string> Names { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsModuleQualifiedName Qualifier { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsIdentifierExpression SetNameIdentifier(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsIdentifierExpression param);
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsModuleQualifiedName SetQualifier(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsModuleQualifiedName param);
    }
    public interface ITsNewExpression : JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptTreeNode, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsExpression, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsMemberExpression, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITypeScriptTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsMemberExpression Expression { get; }
        JetBrains.ReSharper.Psi.Tree.ITokenNode NewKeyword { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsMemberExpression SetExpression(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsMemberExpression param);
    }
    public interface ITsObjectLiteral : JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptTreeNode, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsExpression, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsMemberExpression, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITypeScriptTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.Tree.ITokenNode LBrace { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsObjectPropertyDeclaration> Properties { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeEnumerable<JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsObjectPropertyDeclaration> PropertiesEnumerable { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsObjectPropertiesList PropertiesList { get; }
        JetBrains.ReSharper.Psi.Tree.ITokenNode RBrace { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsObjectPropertiesList SetPropertiesList(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsObjectPropertiesList param);
    }
    public interface ITsObjectPropertiesList : JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITypeScriptTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<JetBrains.ReSharper.Psi.Tree.ITokenNode> Comma { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeEnumerable<JetBrains.ReSharper.Psi.Tree.ITokenNode> CommaEnumerable { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsObjectPropertyDeclaration> Properties { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeEnumerable<JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsObjectPropertyDeclaration> PropertiesEnumerable { get; }
    }
    public interface ITsObjectPropertyAccessor : JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsObjectPropertyDeclaration, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITypeScriptTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsAccessorBody AccessorBody { get; }
        JetBrains.ReSharper.Psi.Tree.ITokenNode AccessorType { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsAccessorBody SetAccessorBody(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsAccessorBody param);
    }
    public interface ITsObjectPropertyDeclaration : JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITypeScriptTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsPropertyName PropertyName { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsPropertyName SetPropertyName(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsPropertyName param);
    }
    public interface ITsObjectPropertyInitializer : JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsObjectPropertyDeclaration, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITypeScriptTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.Tree.ITokenNode Colon { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsExpression Value { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsExpression SetValue(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsExpression param);
    }
    public interface ITsObjectTypeUsage : JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeUsage, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITypeScriptTreeNode, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITypeScriptTypeMemberOwner, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.Tree.ITokenNode LBrace { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeMemberDeclaration> Members { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeEnumerable<JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeMemberDeclaration> MembersEnumerable { get; }
        JetBrains.ReSharper.Psi.Tree.ITokenNode RBrace { get; }
    }
    public interface ITsParameterDeclaration : JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptDeclaration, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptParameterDeclarationBase, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptTreeNode, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsParameterDeclarationBase, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITypeScriptModifiersOwner, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITypeScriptTreeNode, JetBrains.ReSharper.Psi.Tree.IDeclaration, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Tree.IXmlDocOwnerTreeNode
    {
        JetBrains.ReSharper.Psi.Tree.ITokenNode Ellipsis { get; }
        JetBrains.ReSharper.Psi.Tree.ITokenNode Eq { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<JetBrains.ReSharper.Psi.Tree.ITokenNode> ModifierKeyword { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeEnumerable<JetBrains.ReSharper.Psi.Tree.ITokenNode> ModifierKeywordEnumerable { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsIdentifierExpression NameNode { get; }
        JetBrains.ReSharper.Psi.Tree.ITokenNode Question { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeAnnotation TypeAnnotation { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsExpression Value { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsIdentifierExpression SetNameNode(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsIdentifierExpression param);
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeAnnotation SetTypeAnnotation(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeAnnotation param);
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsExpression SetValue(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsExpression param);
    }
    public interface ITsParameterDeclarationBase : JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptDeclaration, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptParameterDeclarationBase, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptTreeNode, JetBrains.ReSharper.Psi.Tree.IDeclaration, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Tree.IXmlDocOwnerTreeNode
    {
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.TsParameterKind Kind { get; }
        JetBrains.ReSharper.Psi.JavaScript.Resolve.IJavaScriptType GetParameterType(JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsLocalElementResolver context);
    }
    public interface ITsParametersList : JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITypeScriptTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<JetBrains.ReSharper.Psi.Tree.ITokenNode> Comma { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeEnumerable<JetBrains.ReSharper.Psi.Tree.ITokenNode> CommaEnumerable { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsParameterDeclaration> Parameters { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeEnumerable<JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsParameterDeclaration> ParametersEnumerable { get; }
    }
    public interface ITsParametersOwner : JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITypeScriptTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.TsParametersOwnerClassification Classification { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsParametersList ParameterList { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsParameterDeclaration> Parameters { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeEnumerable<JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsParameterDeclaration> ParametersEnumerable { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsParametersList SetParameterList(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsParametersList param);
    }
    public interface ITsParenthesizedExpression : JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptTreeNode, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsExpression, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsMemberExpression, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITypeScriptTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsCompoundExpression Expressions { get; }
        JetBrains.ReSharper.Psi.Tree.ITokenNode LPar { get; }
        JetBrains.ReSharper.Psi.Tree.ITokenNode RPar { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsCompoundExpression SetExpressions(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsCompoundExpression param);
    }
    public interface ITsPostfixExpression : JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptTreeNode, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsExpression, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITypeScriptTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsExpression Operand { get; }
        JetBrains.ReSharper.Psi.Tree.ITokenNode Sign { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsExpression SetOperand(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsExpression param);
    }
    public interface ITsPrefixExpression : JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptTreeNode, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsExpression, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITypeScriptTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsExpression Operand { get; }
        JetBrains.ReSharper.Psi.Tree.ITokenNode Sign { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsExpression SetOperand(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsExpression param);
    }
    public interface ITsPropertyName : JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITypeScriptTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode { }
    public interface ITsPropertyNameIdentifier : JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsPropertyName, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITypeScriptTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsIdentifierExpression NameNode { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsIdentifierExpression SetNameNode(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsIdentifierExpression param);
    }
    public interface ITsPropertyNameNumericLiteral : JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsPropertyName, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITypeScriptTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.Tree.ITokenNode Literal { get; }
    }
    public interface ITsPropertyNameStringLiteral : JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsPropertyName, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITypeScriptTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.Tree.ITokenNode Literal { get; }
    }
    public interface ITsPropertySignatureDeclaration : JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeMemberDeclaration, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITypeScriptTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        [JetBrains.Annotations.NotNullAttribute()]
        string DeclaredName { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsIdentifierExpression Name { get; }
        JetBrains.ReSharper.Psi.Tree.ITokenNode Question { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsIdentifierExpression SetName(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsIdentifierExpression param);
    }
    public interface ITsReferenceExpression : JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptTreeNode, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsExpression, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsMemberExpression, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITypeScriptTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.Tree.ITokenNode Dot { get; }
    }
    public interface ITsReferenceName : JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsImportModuleClause, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITypeScriptTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.Tree.ITokenNode Dot { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        string FullName { get; }
        bool IsDynamic { get; }
        bool IsQualified { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsIdentifierExpression NameIdentifier { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.IList<string> Names { get; }
        JetBrains.ReSharper.Psi.Tree.ITreeNode NameTreeNode { get; }
        int OffsetFromNameNode { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsReferenceName Qualifier { get; }
        JetBrains.ReSharper.Psi.JavaScript.Resolve.TypeScript.IModuleNameReference Reference { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        string ShortName { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeArgumentList TypeArguments { get; }
        JetBrains.ReSharper.Psi.JavaScript.Resolve.TypeScript.IModuleNameReference BindingModification(JetBrains.ReSharper.Psi.JavaScript.Resolve.TypeScript.IModuleNameReference reference, JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, string name);
        JetBrains.ReSharper.Psi.JavaScript.Resolve.IJavaScriptType GetQualifierJsType(JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsLocalElementResolver context);
        int GetReferenceExpressionReferenceDocumentOffset(JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsLocalElementResolver context);
        string GetReferenceExpressionReferenceName();
        JetBrains.ReSharper.Psi.TreeTextRange GetReferenceExpressionReferenceTreeRange();
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsIdentifierExpression SetNameIdentifier(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsIdentifierExpression param);
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsReferenceName SetQualifier(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsReferenceName param);
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeArgumentList SetTypeArguments(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeArgumentList param);
    }
    public interface ITsReturnStatement : JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatement, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptTreeNode, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsStatement, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITypeScriptTreeNode, JetBrains.ReSharper.Psi.Tree.IStatement, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.Tree.ITokenNode ReturnKeyword { get; }
        JetBrains.ReSharper.Psi.Tree.ITokenNode Semicolon { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsCompoundExpression Value { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsCompoundExpression SetValue(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsCompoundExpression param);
    }
    public interface ITsSignatureNode : JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IIncrementalScope, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IScope, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptScope, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptTypedNode, JetBrains.ReSharper.Psi.JavaScript.Tree.IJsSignatureNode, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.JavaScript.Resolve.IJavaScriptType GetReturnType(JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsLocalElementResolver context);
        JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsParameterDeclarationBase> GetTsParameters();
        bool IsExplicitConstructor();
    }
    public interface ITsSignatureNodeInPars : JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IIncrementalScope, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IScope, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptScope, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptTypedNode, JetBrains.ReSharper.Psi.JavaScript.Tree.IJsSignatureNode, JetBrains.ReSharper.Psi.JavaScript.Tree.IJsSignatureNodeInPars, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsSignatureNode, JetBrains.ReSharper.Psi.Tree.ITreeNode { }
    public interface ITsSignaturesOwner : JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IIncrementalScope, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IScope, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptScope, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptTypedNode, JetBrains.ReSharper.Psi.JavaScript.Tree.IJsSignaturesOwner, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Tree.IXmlDocOwnerTreeNode
    {
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsSignatureNode TsSignatureNode { get; }
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsSignatureNode> OverloadSignatureNodes();
    }
    public interface ITsStatement : JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatement, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptTreeNode, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITypeScriptTreeNode, JetBrains.ReSharper.Psi.Tree.IStatement, JetBrains.ReSharper.Psi.Tree.ITreeNode { }
    public interface ITsStatementWithParenthesis : JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatement, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptTreeNode, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsStatement, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITypeScriptTreeNode, JetBrains.ReSharper.Psi.Tree.IStatement, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.Tree.ITokenNode LPar { get; }
        JetBrains.ReSharper.Psi.Tree.ITokenNode RPar { get; }
    }
    public interface ITsSuperExpression : JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITypeScriptTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.Tree.ITokenNode SuperKeyword { get; }
    }
    public interface ITsSwitchStatement : JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatement, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptTreeNode, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsStatement, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsStatementWithParenthesis, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITypeScriptTreeNode, JetBrains.ReSharper.Psi.Tree.IStatement, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsCaseClausesList CaseClausesList { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsCompoundExpression Condition { get; }
        JetBrains.ReSharper.Psi.Tree.ITokenNode LBrace { get; }
        JetBrains.ReSharper.Psi.Tree.ITokenNode RBrace { get; }
        JetBrains.ReSharper.Psi.Tree.ITokenNode SwitchKeyword { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsCaseClausesList SetCaseClausesList(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsCaseClausesList param);
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsCompoundExpression SetCondition(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsCompoundExpression param);
    }
    public interface ITsThisExpression : JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptTreeNode, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsExpression, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsMemberExpression, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITypeScriptTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.Tree.ITokenNode ThisKeyword { get; }
    }
    public interface ITsThrowStatement : JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatement, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptTreeNode, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsStatement, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITypeScriptTreeNode, JetBrains.ReSharper.Psi.Tree.IStatement, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.Tree.ITokenNode Semicolon { get; }
        JetBrains.ReSharper.Psi.Tree.ITokenNode ThrowKeyword { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsCompoundExpression Value { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsCompoundExpression SetValue(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsCompoundExpression param);
    }
    public interface ITsTryStatement : JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatement, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptTreeNode, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsStatement, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITypeScriptTreeNode, JetBrains.ReSharper.Psi.Tree.IStatement, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsBlock Block { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsCatchBlock Catch { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsBlock CatchBlock { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsFinallyBlock Finally { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsBlock FinallyBlock { get; }
        JetBrains.ReSharper.Psi.Tree.ITokenNode TryKeyword { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsBlock SetBlock(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsBlock param);
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsCatchBlock SetCatch(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsCatchBlock param);
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsBlock SetCatchBlock(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsBlock param);
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsFinallyBlock SetFinally(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsFinallyBlock param);
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsBlock SetFinallyBlock(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsBlock param);
    }
    public interface ITsTypeAnnotation : JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITypeScriptTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.Tree.ITokenNode Colon { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeUsage TypeUsage { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeUsage SetTypeUsage(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeUsage param);
    }
    public interface ITsTypeArgumentList : JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITypeScriptTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.Tree.ITokenNode Gt { get; }
        JetBrains.ReSharper.Psi.Tree.ITokenNode Lt { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<JetBrains.ReSharper.Psi.Tree.ITokenNode> Separator { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeEnumerable<JetBrains.ReSharper.Psi.Tree.ITokenNode> SeparatorEnumerable { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeUsage> TypeArguments { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeEnumerable<JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeUsage> TypeArgumentsEnumerable { get; }
    }
    public interface ITsTypeDeclaration : JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptDeclaration, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptDeclaredElementProvider, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptTreeNode, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITypeScriptGlobalDeclaration, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITypeScriptModifiersOwner, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITypeScriptTreeNode, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITypeScriptTypeMemberOwner, JetBrains.ReSharper.Psi.Tree.IDeclaration, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Tree.IXmlDocOwnerTreeNode
    {
        JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsBaseTypeClause> BaseTypeClauses { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeEnumerable<JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsBaseTypeClause> BaseTypeClausesEnumerable { get; }
        JetBrains.ReSharper.Psi.Tree.ITokenNode LBrace { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<JetBrains.ReSharper.Psi.Tree.ITokenNode> ModifierKeyword { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeEnumerable<JetBrains.ReSharper.Psi.Tree.ITokenNode> ModifierKeywordEnumerable { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsIdentifierExpression NameNode { get; }
        JetBrains.ReSharper.Psi.Tree.ITokenNode RBrace { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeParameterDeclaration> TypeParameterDeclarations { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeEnumerable<JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeParameterDeclaration> TypeParameterDeclarationsEnumerable { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeParameters TypeParametersSpecification { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsIdentifierExpression SetNameNode(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsIdentifierExpression param);
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeParameters SetTypeParametersSpecification(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeParameters param);
    }
    public interface ITsTypeMemberDeclaration : JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITypeScriptTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.Tree.ITokenNode Semicolon { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeAnnotation TypeAnnotation { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeAnnotation SetTypeAnnotation(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeAnnotation param);
    }
    public interface ITsTypeParameterDeclaration : JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITypeScriptTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.Tree.ITokenNode ExtendsKeyword { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsIdentifierExpression NameNode { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeUsage TypeConstraint { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsIdentifierExpression SetNameNode(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsIdentifierExpression param);
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeUsage SetTypeConstraint(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeUsage param);
    }
    public interface ITsTypeParameters : JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITypeScriptTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.Tree.ITokenNode Gt { get; }
        JetBrains.ReSharper.Psi.Tree.ITokenNode Lt { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<JetBrains.ReSharper.Psi.Tree.ITokenNode> Separator { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeEnumerable<JetBrains.ReSharper.Psi.Tree.ITokenNode> SeparatorEnumerable { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeParameterDeclaration> TypeParameterDeclarations { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeEnumerable<JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeParameterDeclaration> TypeParameterDeclarationsEnumerable { get; }
    }
    public interface ITsTypeParametersOwner : JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITypeScriptTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode { }
    public interface ITsTypeUsage : JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITypeScriptTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.TsTypeUsageKind Kind { get; }
        JetBrains.ReSharper.Psi.JavaScript.Resolve.IJavaScriptType GetJsType(JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsLocalElementResolver context);
    }
    public interface ITsVariableDeclaration : JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptDeclaration, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptTreeNode, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITypeScriptGlobalDeclaration, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITypeScriptModifiersOwner, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITypeScriptTreeNode, JetBrains.ReSharper.Psi.Tree.IDeclaration, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Tree.IXmlDocOwnerTreeNode
    {
        JetBrains.ReSharper.Psi.Tree.ITokenNode Eq { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsIdentifierExpression NameNode { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeAnnotation TypeAnnotation { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsExpression Value { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsIdentifierExpression SetNameNode(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsIdentifierExpression param);
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeAnnotation SetTypeAnnotation(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeAnnotation param);
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsExpression SetValue(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsExpression param);
    }
    public interface ITsVariableDeclarationsList : JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITypeScriptTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<JetBrains.ReSharper.Psi.Tree.ITokenNode> Comma { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeEnumerable<JetBrains.ReSharper.Psi.Tree.ITokenNode> CommaEnumerable { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsVariableDeclaration> VariableDeclarations { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeEnumerable<JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsVariableDeclaration> VariableDeclarationsEnumerable { get; }
    }
    public interface ITsVariableDeclarationStatement : JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatement, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptTreeNode, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsStatement, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITypeScriptTreeNode, JetBrains.ReSharper.Psi.Tree.IStatement, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsVariableDeclarationsList DeclarationList { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsVariableDeclaration> Declarations { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeEnumerable<JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsVariableDeclaration> DeclarationsEnumerable { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<JetBrains.ReSharper.Psi.Tree.ITokenNode> ModifierKeyword { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeEnumerable<JetBrains.ReSharper.Psi.Tree.ITokenNode> ModifierKeywordEnumerable { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.TsModifiers Modifiers { get; }
        JetBrains.ReSharper.Psi.Tree.ITokenNode Semicolon { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeCollection<JetBrains.ReSharper.Psi.Tree.ITokenNode> VarKeyword { get; }
        JetBrains.ReSharper.Psi.Tree.TreeNodeEnumerable<JetBrains.ReSharper.Psi.Tree.ITokenNode> VarKeywordEnumerable { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsVariableDeclarationsList SetDeclarationList(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsVariableDeclarationsList param);
    }
    public interface ITsWhileStatement : JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatement, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptTreeNode, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsStatement, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsStatementWithParenthesis, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITypeScriptTreeNode, JetBrains.ReSharper.Psi.Tree.IStatement, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsCompoundExpression Condition { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsStatement Statement { get; }
        JetBrains.ReSharper.Psi.Tree.ITokenNode WhileKeyword { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsCompoundExpression SetCondition(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsCompoundExpression param);
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsStatement SetStatement(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsStatement param);
    }
    public interface ITsWithStatement : JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatement, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptTreeNode, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsStatement, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsStatementWithParenthesis, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITypeScriptTreeNode, JetBrains.ReSharper.Psi.Tree.IStatement, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsCompoundExpression Condition { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsStatement Statement { get; }
        JetBrains.ReSharper.Psi.Tree.ITokenNode WithKeyword { get; }
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsCompoundExpression SetCondition(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsCompoundExpression param);
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsStatement SetStatement(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsStatement param);
    }
    public interface ITypeScriptGlobalDeclaration : JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptDeclaration, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptTreeNode, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITypeScriptModifiersOwner, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITypeScriptTreeNode, JetBrains.ReSharper.Psi.Tree.IDeclaration, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Tree.IXmlDocOwnerTreeNode { }
    public interface ITypeScriptModifiersOwner : JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITypeScriptTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.TsModifiers Modifiers { get; }
    }
    public interface ITypeScriptModuleScope : JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITypeScriptTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        [JetBrains.Annotations.NotNullAttribute()]
        string ExternalName { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        string FullName { get; }
        bool IsExternal { get; }
        bool IsGlobal { get; }
        JetBrains.ReSharper.Psi.JavaScript.Resolve.IJavaScriptType GetParentJsType(JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsDocumentOffsetProvider context);
        JetBrains.ReSharper.Psi.JavaScript.Resolve.IJavaScriptType GetParentJsTypeForLocalElements(JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsDocumentOffsetProvider context);
    }
    public interface ITypeScriptTreeNode : JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        void Accept(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.TsTreeNodeVisitor visitor);
        void Accept<TContext>(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.TsTreeNodeVisitor<TContext> visitor, TContext context);
        TReturn Accept<TContext, TReturn>(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.TsTreeNodeVisitor<TContext, TReturn> visitor, TContext context);
    }
    public interface ITypeScriptTypeMemberOwner
    {
        JetBrains.ReSharper.Psi.JavaScript.Resolve.IJavaScriptType GetParentJsType(JetBrains.ReSharper.Psi.JavaScript.Resolve.IJsDocumentOffsetProvider context);
    }
    public enum TsAccessModifier
    {
        Public = 0,
        Private = 1,
    }
    public class static TsAccessorBodyNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsAccessorBody GetByAccessorSignature(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsAccessorSignature param) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsAccessorBody GetByBlock(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsBlock param) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsAccessorBody GetByParameter(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsParameterDeclaration param) { }
    }
    public class static TsAccessorSignatureNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsAccessorSignature GetByParameter(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsParameterDeclaration param) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsAccessorSignature GetByParameterList(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsParametersList param) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsAccessorSignature GetByTypeAnnotation(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeAnnotation param) { }
    }
    public class static TsAmbientModuleNameNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsAmbientModuleName GetByNameExpression(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsExpression param) { }
    }
    public class static TsArrayLiteralNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsArrayLiteral GetByArrayElement(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsExpression param) { }
    }
    public class static TsArrayTypeUsageNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsArrayTypeUsage GetByReturnTypeUsage(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeUsage param) { }
    }
    public enum TsBaseTypeClauseKind
    {
        Implements = 0,
        Extends = 1,
    }
    public class static TsBaseTypeClauseNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsBaseTypeClause GetByBaseType(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeUsage param) { }
    }
    public class static TsBinaryExpressionNavigator { }
    public class static TsBlockLambdaExpressionNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsBlockLambdaExpression GetByBlock(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsBlock param) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsBlockLambdaExpression GetBySignature(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsLambdaExpressionSignature param) { }
    }
    public class static TsBlockNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsBlock GetByStatement(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsStatement param) { }
    }
    public class static TsBreakStatementNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsBreakStatement GetByValue(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsCompoundExpression param) { }
    }
    public class static TsCallSignatureDeclarationNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsCallSignatureDeclaration GetByParameter(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsParameterDeclaration param) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsCallSignatureDeclaration GetByParameterList(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsParametersList param) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsCallSignatureDeclaration GetByTypeAnnotation(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeAnnotation param) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsCallSignatureDeclaration GetByTypeParameterDeclaration(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeParameterDeclaration param) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsCallSignatureDeclaration GetByTypeParametersSpecification(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeParameters param) { }
    }
    public class static TsCaseCaseClauseNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsCaseCaseClause GetByStatement(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsStatement param) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsCaseCaseClause GetByValue(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsCompoundExpression param) { }
    }
    public class static TsCaseClauseNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsCaseClause GetByStatement(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsStatement param) { }
    }
    public class static TsCaseClausesListNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsCaseClausesList GetByCaseClause(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsCaseClause param) { }
    }
    public class static TsCastExpressionNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsCastExpression GetByExpression(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsExpression param) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsCastExpression GetByTypeUsage(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeUsage param) { }
    }
    public class static TsCatchBlockNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsCatchBlock GetByBlock(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsBlock param) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsCatchBlock GetByVariableDeclaration(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsVariableDeclaration param) { }
    }
    public class static TsClassDeclarationNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsClassDeclaration GetByBaseTypeClause(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsBaseTypeClause param) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsClassDeclaration GetByClassMember(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsClassMemberDeclaration param) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsClassDeclaration GetByNameNode(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsIdentifierExpression param) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsClassDeclaration GetByTypeParameterDeclaration(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeParameterDeclaration param) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsClassDeclaration GetByTypeParametersSpecification(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeParameters param) { }
    }
    public class static TsClassMemberDeclarationNavigator { }
    public class static TsCompoundExpressionNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsCompoundExpression GetByExpression(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsExpression param) { }
    }
    public class static TsConditionalTernaryExpressionNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsConditionalTernaryExpression GetByConditionOperand(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsExpression param) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsConditionalTernaryExpression GetByElseResult(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsExpression param) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsConditionalTernaryExpression GetByThenResult(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsExpression param) { }
    }
    public class static TsConstructorDeclarationNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsConstructorDeclaration GetByBlock(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsBlock param) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsConstructorDeclaration GetByOverload(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsConstructorOverloadDeclaration param) { }
    }
    public class static TsConstructorOverloadDeclarationNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsConstructorOverloadDeclaration GetByParameter(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsParameterDeclaration param) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsConstructorOverloadDeclaration GetByParameterList(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsParametersList param) { }
    }
    public class static TsContinueStatementNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsContinueStatement GetByValue(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsCompoundExpression param) { }
    }
    public class static TsDebugStatementNavigator { }
    public class static TsDeclaredTypeUsageNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsDeclaredTypeUsage GetByModuleName(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsReferenceName param) { }
    }
    public class static TsDefaultClauseNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsDefaultClause GetByStatement(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsStatement param) { }
    }
    public class static TsDoStatementNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsDoStatement GetByCondition(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsCompoundExpression param) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsDoStatement GetByStatement(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsStatement param) { }
    }
    public class static TsEmptyStatementNavigator { }
    public class static TsEnumDeclarationNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsEnumDeclaration GetByMember(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsEnumMemberDeclaration param) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsEnumDeclaration GetByNameNode(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsIdentifierExpression param) { }
    }
    public class static TsEnumMemberDeclarationNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsEnumMemberDeclaration GetByNameNode(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsIdentifierExpression param) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsEnumMemberDeclaration GetByValue(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsExpression param) { }
    }
    public class static TsExpressionLambdaExpressionNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsExpressionLambdaExpression GetByExpression(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsExpression param) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsExpressionLambdaExpression GetBySignature(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsLambdaExpressionSignature param) { }
    }
    public class static TsExpressionNavigator { }
    public class static TsExpressionStatementNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsExpressionStatement GetByExpression(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsCompoundExpression param) { }
    }
    public class static TsExtendsClauseNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsExtendsClause GetByBaseType(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeUsage param) { }
    }
    public class static TsExternalModuleReferenceNameNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsExternalModuleReferenceName GetByAmbientName(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsAmbientModuleName param) { }
    }
    public class static TsFileNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsFile GetByAllStatement(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsStatement param) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsFile GetBySection(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsFileSection param) { }
    }
    public class static TsFileSectionNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsFileSection GetByStatement(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsStatement param) { }
    }
    public class static TsFinallyBlockNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsFinallyBlock GetByBlock(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsBlock param) { }
    }
    public class static TsForDeclarationInitializerNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsForDeclarationInitializer GetByDeclaration(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsVariableDeclaration param) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsForDeclarationInitializer GetByDeclarationList(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsVariableDeclarationsList param) { }
    }
    public class static TsForeachStatementNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsForeachStatement GetByForInitializer(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsForInitializer param) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsForeachStatement GetByForIterator(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsCompoundExpression param) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsForeachStatement GetByStatement(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsStatement param) { }
    }
    public class static TsForExpressionInitializerNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsForExpressionInitializer GetByExpression(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsCompoundExpression param) { }
    }
    public class static TsForInitializerNavigator { }
    public class static TsForStatementNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsForStatement GetByForCondition(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsCompoundExpression param) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsForStatement GetByForInitializer(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsForInitializer param) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsForStatement GetByForIterator(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsCompoundExpression param) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsForStatement GetByStatement(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsStatement param) { }
    }
    public class static TsFunctionExpressionNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsFunctionExpression GetByBlock(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsBlock param) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsFunctionExpression GetByParameter(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsParameterDeclaration param) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsFunctionExpression GetByParameterList(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsParametersList param) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsFunctionExpression GetBySignature(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsFunctionExpressionSignature param) { }
    }
    public class static TsFunctionExpressionSignatureNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsFunctionExpressionSignature GetByNameNode(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsIdentifierExpression param) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsFunctionExpressionSignature GetByParameter(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsParameterDeclaration param) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsFunctionExpressionSignature GetByParameterList(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsParametersList param) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsFunctionExpressionSignature GetByTypeAnnotation(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeAnnotation param) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsFunctionExpressionSignature GetByTypeParametersSpecification(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeParameters param) { }
    }
    public class static TsFunctionExtensions { }
    public class static TsFunctionSignatureDeclarationNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsFunctionSignatureDeclaration GetByName(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsIdentifierExpression param) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsFunctionSignatureDeclaration GetByParameter(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsParameterDeclaration param) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsFunctionSignatureDeclaration GetByParameterList(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsParametersList param) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsFunctionSignatureDeclaration GetByTypeAnnotation(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeAnnotation param) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsFunctionSignatureDeclaration GetByTypeParametersSpecification(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeParameters param) { }
    }
    public class static TsFunctionStatementNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsFunctionStatement GetByBlock(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsBlock param) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsFunctionStatement GetBySignature(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsFunctionStatementSignature param) { }
    }
    public class static TsFunctionStatementSignatureNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsFunctionStatementSignature GetBySignature(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsFunctionExpressionSignature param) { }
    }
    public class static TsFunctionTypeUsageNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsFunctionTypeUsage GetByParameter(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsParameterDeclaration param) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsFunctionTypeUsage GetByParameterList(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsParametersList param) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsFunctionTypeUsage GetByReturnTypeUsage(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeUsage param) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsFunctionTypeUsage GetByTypeParametersSpecification(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeParameters param) { }
    }
    public class static TsIdentifierExpressionNavigator { }
    public class static TsIfStatementNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsIfStatement GetByCondition(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsCompoundExpression param) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsIfStatement GetByElse(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsStatement param) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsIfStatement GetByThen(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsStatement param) { }
    }
    public class static TsImplementsClauseNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsImplementsClause GetByBaseType(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeUsage param) { }
    }
    public class static TsImportDeclarationNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsImportDeclaration GetByModuleReference(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsImportModuleClause param) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsImportDeclaration GetByNameIdentifier(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsIdentifierExpression param) { }
    }
    public class static TsImportModuleClauseNavigator { }
    public class static TsIndexExpressionNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsIndexExpression GetByArgument(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsExpression param) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsIndexExpression GetByIndexedExpression(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsMemberExpression param) { }
    }
    public class static TsIndexSignatureDeclarationNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsIndexSignatureDeclaration GetByParameter(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsParameterDeclaration param) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsIndexSignatureDeclaration GetByParameterList(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsParametersList param) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsIndexSignatureDeclaration GetByTypeAnnotation(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeAnnotation param) { }
    }
    public class static TsInterfaceDeclarationNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsInterfaceDeclaration GetByBaseTypeClause(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsBaseTypeClause param) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsInterfaceDeclaration GetByInterfaceMember(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeMemberDeclaration param) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsInterfaceDeclaration GetByNameNode(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsIdentifierExpression param) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsInterfaceDeclaration GetByTypeParameterDeclaration(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeParameterDeclaration param) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsInterfaceDeclaration GetByTypeParametersSpecification(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeParameters param) { }
    }
    public class static TsInvocationExpressionNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsInvocationExpression GetByArgument(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsExpression param) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsInvocationExpression GetByInvokedExpression(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsExpression param) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsInvocationExpression GetByTypeArgument(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeUsage param) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsInvocationExpression GetByTypeArgumentList(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeArgumentList param) { }
    }
    public class static TsLabelledStatementNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsLabelledStatement GetByNameNode(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsIdentifierExpression param) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsLabelledStatement GetByStatement(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsStatement param) { }
    }
    public class static TsLambdaExpressionFullSignatureNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsLambdaExpressionFullSignature GetByParameter(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsParameterDeclaration param) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsLambdaExpressionFullSignature GetByParameterList(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsParametersList param) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsLambdaExpressionFullSignature GetByTypeAnnotation(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeAnnotation param) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsLambdaExpressionFullSignature GetByTypeParametersSpecification(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeParameters param) { }
    }
    public class static TsLambdaExpressionNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsLambdaExpression GetBySignature(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsLambdaExpressionSignature param) { }
    }
    public class static TsLambdaExpressionSignatureNavigator { }
    public class static TsLambdaExpressionSimpleSignatureNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsLambdaExpressionSimpleSignature GetByNameNode(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsIdentifierExpression param) { }
    }
    public class static TsLiteralExpressionNavigator { }
    public class static TsMemberAccessorDeclarationNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsMemberAccessorDeclaration GetByBlock(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsBlock param) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsMemberAccessorDeclaration GetByName(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsIdentifierExpression param) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsMemberAccessorDeclaration GetByParameter(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsParameterDeclaration param) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsMemberAccessorDeclaration GetBySignature(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsMemberAccessorSignature param) { }
    }
    public class static TsMemberAccessorSignatureNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsMemberAccessorSignature GetByParameter(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsParameterDeclaration param) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsMemberAccessorSignature GetByParameterList(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsParametersList param) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsMemberAccessorSignature GetByTypeAnnotation(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeAnnotation param) { }
    }
    public class static TsMemberExpressionNavigator { }
    public class static TsMemberFunctionDeclarationNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsMemberFunctionDeclaration GetByBlock(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsBlock param) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsMemberFunctionDeclaration GetByOverload(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsMemberFunctionOverloadDeclaration param) { }
    }
    public class static TsMemberFunctionOverloadDeclarationNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsMemberFunctionOverloadDeclaration GetByName(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsIdentifierExpression param) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsMemberFunctionOverloadDeclaration GetByParameter(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsParameterDeclaration param) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsMemberFunctionOverloadDeclaration GetByParameterList(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsParametersList param) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsMemberFunctionOverloadDeclaration GetByTypeAnnotation(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeAnnotation param) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsMemberFunctionOverloadDeclaration GetByTypeParametersSpecification(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeParameters param) { }
    }
    public class static TsMemberVariableDeclarationNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsMemberVariableDeclaration GetByVariableDeclaration(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsVariableDeclaration param) { }
    }
    [System.FlagsAttribute()]
    public enum TsModifiers
    {
        None = 0,
        Export = 1,
        Declare = 2,
        Static = 4,
        Private = 8,
        Public = 16,
    }
    public class static TsModifierUtil
    {
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.TsModifiers TokenNodeToModifier(JetBrains.ReSharper.Psi.Tree.ITokenNode node) { }
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.TsModifiers TokenNodeTypeToModifier(JetBrains.ReSharper.Psi.Parsing.TokenNodeType tokenNodeType) { }
    }
    public class static TsModifiesOwnerExtensions
    {
        public static bool HasModifier([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITypeScriptModifiersOwner owner, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.TsModifiers modifiers) { }
        public static bool IsAmbient([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITypeScriptModifiersOwner owner) { }
        public static bool IsExported([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITypeScriptTreeNode node) { }
    }
    public class static TsModuleDeclarationNameNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsModuleDeclarationName GetByExternalName(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsAmbientModuleName param) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsModuleDeclarationName GetByName(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsModuleQualifiedName param) { }
    }
    public class static TsModuleDeclarationNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsModuleDeclaration GetByBlock(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsBlock param) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsModuleDeclaration GetByModuleNameNode(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsModuleDeclarationName param) { }
    }
    public class static TsModuleQualifiedNameNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsModuleQualifiedName GetByNameIdentifier(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsIdentifierExpression param) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsModuleQualifiedName GetByQualifier(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsModuleQualifiedName param) { }
    }
    public class static TsNewExpressionNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsNewExpression GetByExpression(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsMemberExpression param) { }
    }
    public class static TsObjectLiteralNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsObjectLiteral GetByPropertie(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsObjectPropertyDeclaration param) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsObjectLiteral GetByPropertiesList(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsObjectPropertiesList param) { }
    }
    public class static TsObjectPropertiesListNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsObjectPropertiesList GetByPropertie(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsObjectPropertyDeclaration param) { }
    }
    public class static TsObjectPropertyAccessorNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsObjectPropertyAccessor GetByAccessorBody(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsAccessorBody param) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsObjectPropertyAccessor GetByPropertyName(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsPropertyName param) { }
    }
    public class static TsObjectPropertyDeclarationNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsObjectPropertyDeclaration GetByPropertyName(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsPropertyName param) { }
    }
    public class static TsObjectPropertyInitializerNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsObjectPropertyInitializer GetByPropertyName(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsPropertyName param) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsObjectPropertyInitializer GetByValue(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsExpression param) { }
    }
    public class static TsObjectTypeUsageNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsObjectTypeUsage GetByMember(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeMemberDeclaration param) { }
    }
    public class static TsParameterDeclarationNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsParameterDeclaration GetByNameNode(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsIdentifierExpression param) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsParameterDeclaration GetByTypeAnnotation(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeAnnotation param) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsParameterDeclaration GetByValue(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsExpression param) { }
    }
    public enum TsParameterKind
    {
        Required = 0,
        Optional = 1,
        Rest = 2,
    }
    public class static TsParametersListNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsParametersList GetByParameter(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsParameterDeclaration param) { }
    }
    public enum TsParametersOwnerClassification
    {
        Declaration = 0,
        Implementation = 1,
    }
    public class static TsParametersOwnerNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsParametersOwner GetByParameter(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsParameterDeclaration param) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsParametersOwner GetByParameterList(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsParametersList param) { }
    }
    public class static TsParenthesizedExpressionNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsParenthesizedExpression GetByExpressions(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsCompoundExpression param) { }
    }
    public class static TsPostfixExpressionNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsPostfixExpression GetByOperand(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsExpression param) { }
    }
    public class static TsPrefixExpressionNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsPrefixExpression GetByOperand(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsExpression param) { }
    }
    public enum TsPropertyAccessorKind
    {
        Getter = 0,
        Setter = 1,
    }
    public class static TsPropertyNameIdentifierNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsPropertyNameIdentifier GetByNameNode(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsIdentifierExpression param) { }
    }
    public class static TsPropertyNameNavigator { }
    public class static TsPropertyNameNumericLiteralNavigator { }
    public class static TsPropertyNameStringLiteralNavigator { }
    public class static TsPropertySignatureDeclarationNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsPropertySignatureDeclaration GetByName(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsIdentifierExpression param) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsPropertySignatureDeclaration GetByTypeAnnotation(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeAnnotation param) { }
    }
    public class static TsReferenceExpressionNavigator { }
    public class static TsReferenceNameNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsReferenceName GetByNameIdentifier(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsIdentifierExpression param) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsReferenceName GetByQualifier(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsReferenceName param) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsReferenceName GetByTypeArguments(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeArgumentList param) { }
    }
    public class static TsReturnStatementNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsReturnStatement GetByValue(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsCompoundExpression param) { }
    }
    public class static TsStatementExtensions
    {
        public static bool HasAmbientOwner([JetBrains.Annotations.CanBeNullAttribute()] this JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsStatement typeScriptVariableStatement) { }
    }
    public class static TsStatementNavigator { }
    public class static TsStatementWithParenthesisNavigator { }
    public class static TsSuperExpressionNavigator { }
    public class static TsSwitchStatementNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsSwitchStatement GetByCaseClausesList(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsCaseClausesList param) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsSwitchStatement GetByCondition(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsCompoundExpression param) { }
    }
    public class static TsThisExpressionNavigator { }
    public class static TsThrowStatementNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsThrowStatement GetByValue(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsCompoundExpression param) { }
    }
    public abstract class TsTreeNodeVisitor
    {
        public virtual void VisitNode([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode node) { }
        public virtual void VisitTsAccessorBody([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsAccessorBody tsAccessorBodyParam) { }
        public virtual void VisitTsAccessorSignature([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsAccessorSignature tsAccessorSignatureParam) { }
        public virtual void VisitTsAmbientModuleName([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsAmbientModuleName tsAmbientModuleNameParam) { }
        public virtual void VisitTsArrayLiteral([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsArrayLiteral tsArrayLiteralParam) { }
        public virtual void VisitTsArrayTypeUsage([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsArrayTypeUsage tsArrayTypeUsageParam) { }
        public virtual void VisitTsBaseTypeClause([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsBaseTypeClause tsBaseTypeClauseParam) { }
        public virtual void VisitTsBinaryExpression([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsBinaryExpression tsBinaryExpressionParam) { }
        public virtual void VisitTsBlock([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsBlock tsBlockParam) { }
        public virtual void VisitTsBlockLambdaExpression([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsBlockLambdaExpression tsBlockLambdaExpressionParam) { }
        public virtual void VisitTsBreakStatement([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsBreakStatement tsBreakStatementParam) { }
        public virtual void VisitTsCallSignatureDeclaration([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsCallSignatureDeclaration tsCallSignatureDeclarationParam) { }
        public virtual void VisitTsCaseCaseClause([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsCaseCaseClause tsCaseCaseClauseParam) { }
        public virtual void VisitTsCaseClause([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsCaseClause tsCaseClauseParam) { }
        public virtual void VisitTsCaseClausesList([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsCaseClausesList tsCaseClausesListParam) { }
        public virtual void VisitTsCastExpression([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsCastExpression tsCastExpressionParam) { }
        public virtual void VisitTsCatchBlock([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsCatchBlock tsCatchBlockParam) { }
        public virtual void VisitTsClassDeclaration([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsClassDeclaration tsClassDeclarationParam) { }
        public virtual void VisitTsClassMemberDeclaration([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsClassMemberDeclaration tsClassMemberDeclarationParam) { }
        public virtual void VisitTsCompoundExpression([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsCompoundExpression tsCompoundExpressionParam) { }
        public virtual void VisitTsConditionalTernaryExpression([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsConditionalTernaryExpression tsConditionalTernaryExpressionParam) { }
        public virtual void VisitTsConstructorDeclaration([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsConstructorDeclaration tsConstructorDeclarationParam) { }
        public virtual void VisitTsConstructorOverloadDeclaration([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsConstructorOverloadDeclaration tsConstructorOverloadDeclarationParam) { }
        public virtual void VisitTsContinueStatement([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsContinueStatement tsContinueStatementParam) { }
        public virtual void VisitTsDebugStatement([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsDebugStatement tsDebugStatementParam) { }
        public virtual void VisitTsDeclaredTypeUsage([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsDeclaredTypeUsage tsDeclaredTypeUsageParam) { }
        public virtual void VisitTsDefaultClause([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsDefaultClause tsDefaultClauseParam) { }
        public virtual void VisitTsDoStatement([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsDoStatement tsDoStatementParam) { }
        public virtual void VisitTsEmptyStatement([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsEmptyStatement tsEmptyStatementParam) { }
        public virtual void VisitTsEnumDeclaration([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsEnumDeclaration tsEnumDeclarationParam) { }
        public virtual void VisitTsEnumMemberDeclaration([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsEnumMemberDeclaration tsEnumMemberDeclarationParam) { }
        public virtual void VisitTsExpression([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsExpression tsExpressionParam) { }
        public virtual void VisitTsExpressionLambdaExpression([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsExpressionLambdaExpression tsExpressionLambdaExpressionParam) { }
        public virtual void VisitTsExpressionStatement([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsExpressionStatement tsExpressionStatementParam) { }
        public virtual void VisitTsExtendsClause([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsExtendsClause tsExtendsClauseParam) { }
        public virtual void VisitTsExternalModuleReferenceName([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsExternalModuleReferenceName tsExternalModuleReferenceNameParam) { }
        public virtual void VisitTsFile([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsFile tsFileParam) { }
        public virtual void VisitTsFileSection([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsFileSection tsFileSectionParam) { }
        public virtual void VisitTsFinallyBlock([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsFinallyBlock tsFinallyBlockParam) { }
        public virtual void VisitTsForDeclarationInitializer([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsForDeclarationInitializer tsForDeclarationInitializerParam) { }
        public virtual void VisitTsForeachStatement([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsForeachStatement tsForeachStatementParam) { }
        public virtual void VisitTsForExpressionInitializer([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsForExpressionInitializer tsForExpressionInitializerParam) { }
        public virtual void VisitTsForInitializer([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsForInitializer tsForInitializerParam) { }
        public virtual void VisitTsForStatement([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsForStatement tsForStatementParam) { }
        public virtual void VisitTsFunctionExpression([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsFunctionExpression tsFunctionExpressionParam) { }
        public virtual void VisitTsFunctionExpressionSignature([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsFunctionExpressionSignature tsFunctionExpressionSignatureParam) { }
        public virtual void VisitTsFunctionSignatureDeclaration([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsFunctionSignatureDeclaration tsFunctionSignatureDeclarationParam) { }
        public virtual void VisitTsFunctionStatement([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsFunctionStatement tsFunctionStatementParam) { }
        public virtual void VisitTsFunctionStatementSignature([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsFunctionStatementSignature tsFunctionStatementSignatureParam) { }
        public virtual void VisitTsFunctionTypeUsage([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsFunctionTypeUsage tsFunctionTypeUsageParam) { }
        public virtual void VisitTsIdentifierExpression([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsIdentifierExpression tsIdentifierExpressionParam) { }
        public virtual void VisitTsIfStatement([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsIfStatement tsIfStatementParam) { }
        public virtual void VisitTsImplementsClause([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsImplementsClause tsImplementsClauseParam) { }
        public virtual void VisitTsImportDeclaration([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsImportDeclaration tsImportDeclarationParam) { }
        public virtual void VisitTsImportModuleClause([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsImportModuleClause tsImportModuleClauseParam) { }
        public virtual void VisitTsIndexExpression([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsIndexExpression tsIndexExpressionParam) { }
        public virtual void VisitTsIndexSignatureDeclaration([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsIndexSignatureDeclaration tsIndexSignatureDeclarationParam) { }
        public virtual void VisitTsInterfaceDeclaration([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsInterfaceDeclaration tsInterfaceDeclarationParam) { }
        public virtual void VisitTsInvocationExpression([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsInvocationExpression tsInvocationExpressionParam) { }
        public virtual void VisitTsLabelledStatement([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsLabelledStatement tsLabelledStatementParam) { }
        public virtual void VisitTsLambdaExpression([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsLambdaExpression tsLambdaExpressionParam) { }
        public virtual void VisitTsLambdaExpressionFullSignature([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsLambdaExpressionFullSignature tsLambdaExpressionFullSignatureParam) { }
        public virtual void VisitTsLambdaExpressionSignature([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsLambdaExpressionSignature tsLambdaExpressionSignatureParam) { }
        public virtual void VisitTsLambdaExpressionSimpleSignature([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsLambdaExpressionSimpleSignature tsLambdaExpressionSimpleSignatureParam) { }
        public virtual void VisitTsLiteralExpression([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsLiteralExpression tsLiteralExpressionParam) { }
        public virtual void VisitTsMemberAccessorDeclaration([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsMemberAccessorDeclaration tsMemberAccessorDeclarationParam) { }
        public virtual void VisitTsMemberAccessorSignature([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsMemberAccessorSignature tsMemberAccessorSignatureParam) { }
        public virtual void VisitTsMemberExpression([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsMemberExpression tsMemberExpressionParam) { }
        public virtual void VisitTsMemberFunctionDeclaration([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsMemberFunctionDeclaration tsMemberFunctionDeclarationParam) { }
        public virtual void VisitTsMemberFunctionOverloadDeclaration([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsMemberFunctionOverloadDeclaration tsMemberFunctionOverloadDeclarationParam) { }
        public virtual void VisitTsMemberVariableDeclaration([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsMemberVariableDeclaration tsMemberVariableDeclarationParam) { }
        public virtual void VisitTsModuleDeclaration([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsModuleDeclaration tsModuleDeclarationParam) { }
        public virtual void VisitTsModuleDeclarationName([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsModuleDeclarationName tsModuleDeclarationNameParam) { }
        public virtual void VisitTsModuleQualifiedName([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsModuleQualifiedName tsModuleQualifiedNameParam) { }
        public virtual void VisitTsNewExpression([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsNewExpression tsNewExpressionParam) { }
        public virtual void VisitTsObjectLiteral([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsObjectLiteral tsObjectLiteralParam) { }
        public virtual void VisitTsObjectPropertiesList([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsObjectPropertiesList tsObjectPropertiesListParam) { }
        public virtual void VisitTsObjectPropertyAccessor([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsObjectPropertyAccessor tsObjectPropertyAccessorParam) { }
        public virtual void VisitTsObjectPropertyDeclaration([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsObjectPropertyDeclaration tsObjectPropertyDeclarationParam) { }
        public virtual void VisitTsObjectPropertyInitializer([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsObjectPropertyInitializer tsObjectPropertyInitializerParam) { }
        public virtual void VisitTsObjectTypeUsage([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsObjectTypeUsage tsObjectTypeUsageParam) { }
        public virtual void VisitTsParameterDeclaration([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsParameterDeclaration tsParameterDeclarationParam) { }
        public virtual void VisitTsParametersList([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsParametersList tsParametersListParam) { }
        public virtual void VisitTsParametersOwner([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsParametersOwner tsParametersOwnerParam) { }
        public virtual void VisitTsParenthesizedExpression([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsParenthesizedExpression tsParenthesizedExpressionParam) { }
        public virtual void VisitTsPostfixExpression([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsPostfixExpression tsPostfixExpressionParam) { }
        public virtual void VisitTsPrefixExpression([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsPrefixExpression tsPrefixExpressionParam) { }
        public virtual void VisitTsPropertyName([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsPropertyName tsPropertyNameParam) { }
        public virtual void VisitTsPropertyNameIdentifier([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsPropertyNameIdentifier tsPropertyNameIdentifierParam) { }
        public virtual void VisitTsPropertyNameNumericLiteral([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsPropertyNameNumericLiteral tsPropertyNameNumericLiteralParam) { }
        public virtual void VisitTsPropertyNameStringLiteral([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsPropertyNameStringLiteral tsPropertyNameStringLiteralParam) { }
        public virtual void VisitTsPropertySignatureDeclaration([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsPropertySignatureDeclaration tsPropertySignatureDeclarationParam) { }
        public virtual void VisitTsReferenceExpression([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsReferenceExpression tsReferenceExpressionParam) { }
        public virtual void VisitTsReferenceName([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsReferenceName tsReferenceNameParam) { }
        public virtual void VisitTsReturnStatement([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsReturnStatement tsReturnStatementParam) { }
        public virtual void VisitTsStatement([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsStatement tsStatementParam) { }
        public virtual void VisitTsStatementWithParenthesis([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsStatementWithParenthesis tsStatementWithParenthesisParam) { }
        public virtual void VisitTsSuperExpression([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsSuperExpression tsSuperExpressionParam) { }
        public virtual void VisitTsSwitchStatement([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsSwitchStatement tsSwitchStatementParam) { }
        public virtual void VisitTsThisExpression([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsThisExpression tsThisExpressionParam) { }
        public virtual void VisitTsThrowStatement([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsThrowStatement tsThrowStatementParam) { }
        public virtual void VisitTsTryStatement([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTryStatement tsTryStatementParam) { }
        public virtual void VisitTsTypeAnnotation([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeAnnotation tsTypeAnnotationParam) { }
        public virtual void VisitTsTypeArgumentList([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeArgumentList tsTypeArgumentListParam) { }
        public virtual void VisitTsTypeDeclaration([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeDeclaration tsTypeDeclarationParam) { }
        public virtual void VisitTsTypeMemberDeclaration([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeMemberDeclaration tsTypeMemberDeclarationParam) { }
        public virtual void VisitTsTypeParameterDeclaration([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeParameterDeclaration tsTypeParameterDeclarationParam) { }
        public virtual void VisitTsTypeParameters([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeParameters tsTypeParametersParam) { }
        public virtual void VisitTsTypeParametersOwner([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeParametersOwner tsTypeParametersOwnerParam) { }
        public virtual void VisitTsTypeUsage([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeUsage tsTypeUsageParam) { }
        public virtual void VisitTsVariableDeclaration([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsVariableDeclaration tsVariableDeclarationParam) { }
        public virtual void VisitTsVariableDeclarationsList([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsVariableDeclarationsList tsVariableDeclarationsListParam) { }
        public virtual void VisitTsVariableDeclarationStatement([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsVariableDeclarationStatement tsVariableDeclarationStatementParam) { }
        public virtual void VisitTsWhileStatement([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsWhileStatement tsWhileStatementParam) { }
        public virtual void VisitTsWithStatement([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsWithStatement tsWithStatementParam) { }
    }
    public abstract class TsTreeNodeVisitor<TContext>
    
    {
        public virtual void VisitNode([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode node, TContext context) { }
        public virtual void VisitTsAccessorBody([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsAccessorBody tsAccessorBodyParam, TContext context) { }
        public virtual void VisitTsAccessorSignature([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsAccessorSignature tsAccessorSignatureParam, TContext context) { }
        public virtual void VisitTsAmbientModuleName([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsAmbientModuleName tsAmbientModuleNameParam, TContext context) { }
        public virtual void VisitTsArrayLiteral([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsArrayLiteral tsArrayLiteralParam, TContext context) { }
        public virtual void VisitTsArrayTypeUsage([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsArrayTypeUsage tsArrayTypeUsageParam, TContext context) { }
        public virtual void VisitTsBaseTypeClause([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsBaseTypeClause tsBaseTypeClauseParam, TContext context) { }
        public virtual void VisitTsBinaryExpression([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsBinaryExpression tsBinaryExpressionParam, TContext context) { }
        public virtual void VisitTsBlock([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsBlock tsBlockParam, TContext context) { }
        public virtual void VisitTsBlockLambdaExpression([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsBlockLambdaExpression tsBlockLambdaExpressionParam, TContext context) { }
        public virtual void VisitTsBreakStatement([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsBreakStatement tsBreakStatementParam, TContext context) { }
        public virtual void VisitTsCallSignatureDeclaration([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsCallSignatureDeclaration tsCallSignatureDeclarationParam, TContext context) { }
        public virtual void VisitTsCaseCaseClause([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsCaseCaseClause tsCaseCaseClauseParam, TContext context) { }
        public virtual void VisitTsCaseClause([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsCaseClause tsCaseClauseParam, TContext context) { }
        public virtual void VisitTsCaseClausesList([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsCaseClausesList tsCaseClausesListParam, TContext context) { }
        public virtual void VisitTsCastExpression([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsCastExpression tsCastExpressionParam, TContext context) { }
        public virtual void VisitTsCatchBlock([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsCatchBlock tsCatchBlockParam, TContext context) { }
        public virtual void VisitTsClassDeclaration([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsClassDeclaration tsClassDeclarationParam, TContext context) { }
        public virtual void VisitTsClassMemberDeclaration([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsClassMemberDeclaration tsClassMemberDeclarationParam, TContext context) { }
        public virtual void VisitTsCompoundExpression([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsCompoundExpression tsCompoundExpressionParam, TContext context) { }
        public virtual void VisitTsConditionalTernaryExpression([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsConditionalTernaryExpression tsConditionalTernaryExpressionParam, TContext context) { }
        public virtual void VisitTsConstructorDeclaration([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsConstructorDeclaration tsConstructorDeclarationParam, TContext context) { }
        public virtual void VisitTsConstructorOverloadDeclaration([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsConstructorOverloadDeclaration tsConstructorOverloadDeclarationParam, TContext context) { }
        public virtual void VisitTsContinueStatement([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsContinueStatement tsContinueStatementParam, TContext context) { }
        public virtual void VisitTsDebugStatement([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsDebugStatement tsDebugStatementParam, TContext context) { }
        public virtual void VisitTsDeclaredTypeUsage([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsDeclaredTypeUsage tsDeclaredTypeUsageParam, TContext context) { }
        public virtual void VisitTsDefaultClause([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsDefaultClause tsDefaultClauseParam, TContext context) { }
        public virtual void VisitTsDoStatement([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsDoStatement tsDoStatementParam, TContext context) { }
        public virtual void VisitTsEmptyStatement([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsEmptyStatement tsEmptyStatementParam, TContext context) { }
        public virtual void VisitTsEnumDeclaration([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsEnumDeclaration tsEnumDeclarationParam, TContext context) { }
        public virtual void VisitTsEnumMemberDeclaration([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsEnumMemberDeclaration tsEnumMemberDeclarationParam, TContext context) { }
        public virtual void VisitTsExpression([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsExpression tsExpressionParam, TContext context) { }
        public virtual void VisitTsExpressionLambdaExpression([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsExpressionLambdaExpression tsExpressionLambdaExpressionParam, TContext context) { }
        public virtual void VisitTsExpressionStatement([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsExpressionStatement tsExpressionStatementParam, TContext context) { }
        public virtual void VisitTsExtendsClause([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsExtendsClause tsExtendsClauseParam, TContext context) { }
        public virtual void VisitTsExternalModuleReferenceName([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsExternalModuleReferenceName tsExternalModuleReferenceNameParam, TContext context) { }
        public virtual void VisitTsFile([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsFile tsFileParam, TContext context) { }
        public virtual void VisitTsFileSection([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsFileSection tsFileSectionParam, TContext context) { }
        public virtual void VisitTsFinallyBlock([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsFinallyBlock tsFinallyBlockParam, TContext context) { }
        public virtual void VisitTsForDeclarationInitializer([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsForDeclarationInitializer tsForDeclarationInitializerParam, TContext context) { }
        public virtual void VisitTsForeachStatement([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsForeachStatement tsForeachStatementParam, TContext context) { }
        public virtual void VisitTsForExpressionInitializer([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsForExpressionInitializer tsForExpressionInitializerParam, TContext context) { }
        public virtual void VisitTsForInitializer([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsForInitializer tsForInitializerParam, TContext context) { }
        public virtual void VisitTsForStatement([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsForStatement tsForStatementParam, TContext context) { }
        public virtual void VisitTsFunctionExpression([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsFunctionExpression tsFunctionExpressionParam, TContext context) { }
        public virtual void VisitTsFunctionExpressionSignature([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsFunctionExpressionSignature tsFunctionExpressionSignatureParam, TContext context) { }
        public virtual void VisitTsFunctionSignatureDeclaration([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsFunctionSignatureDeclaration tsFunctionSignatureDeclarationParam, TContext context) { }
        public virtual void VisitTsFunctionStatement([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsFunctionStatement tsFunctionStatementParam, TContext context) { }
        public virtual void VisitTsFunctionStatementSignature([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsFunctionStatementSignature tsFunctionStatementSignatureParam, TContext context) { }
        public virtual void VisitTsFunctionTypeUsage([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsFunctionTypeUsage tsFunctionTypeUsageParam, TContext context) { }
        public virtual void VisitTsIdentifierExpression([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsIdentifierExpression tsIdentifierExpressionParam, TContext context) { }
        public virtual void VisitTsIfStatement([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsIfStatement tsIfStatementParam, TContext context) { }
        public virtual void VisitTsImplementsClause([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsImplementsClause tsImplementsClauseParam, TContext context) { }
        public virtual void VisitTsImportDeclaration([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsImportDeclaration tsImportDeclarationParam, TContext context) { }
        public virtual void VisitTsImportModuleClause([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsImportModuleClause tsImportModuleClauseParam, TContext context) { }
        public virtual void VisitTsIndexExpression([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsIndexExpression tsIndexExpressionParam, TContext context) { }
        public virtual void VisitTsIndexSignatureDeclaration([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsIndexSignatureDeclaration tsIndexSignatureDeclarationParam, TContext context) { }
        public virtual void VisitTsInterfaceDeclaration([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsInterfaceDeclaration tsInterfaceDeclarationParam, TContext context) { }
        public virtual void VisitTsInvocationExpression([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsInvocationExpression tsInvocationExpressionParam, TContext context) { }
        public virtual void VisitTsLabelledStatement([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsLabelledStatement tsLabelledStatementParam, TContext context) { }
        public virtual void VisitTsLambdaExpression([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsLambdaExpression tsLambdaExpressionParam, TContext context) { }
        public virtual void VisitTsLambdaExpressionFullSignature([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsLambdaExpressionFullSignature tsLambdaExpressionFullSignatureParam, TContext context) { }
        public virtual void VisitTsLambdaExpressionSignature([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsLambdaExpressionSignature tsLambdaExpressionSignatureParam, TContext context) { }
        public virtual void VisitTsLambdaExpressionSimpleSignature([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsLambdaExpressionSimpleSignature tsLambdaExpressionSimpleSignatureParam, TContext context) { }
        public virtual void VisitTsLiteralExpression([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsLiteralExpression tsLiteralExpressionParam, TContext context) { }
        public virtual void VisitTsMemberAccessorDeclaration([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsMemberAccessorDeclaration tsMemberAccessorDeclarationParam, TContext context) { }
        public virtual void VisitTsMemberAccessorSignature([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsMemberAccessorSignature tsMemberAccessorSignatureParam, TContext context) { }
        public virtual void VisitTsMemberExpression([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsMemberExpression tsMemberExpressionParam, TContext context) { }
        public virtual void VisitTsMemberFunctionDeclaration([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsMemberFunctionDeclaration tsMemberFunctionDeclarationParam, TContext context) { }
        public virtual void VisitTsMemberFunctionOverloadDeclaration([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsMemberFunctionOverloadDeclaration tsMemberFunctionOverloadDeclarationParam, TContext context) { }
        public virtual void VisitTsMemberVariableDeclaration([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsMemberVariableDeclaration tsMemberVariableDeclarationParam, TContext context) { }
        public virtual void VisitTsModuleDeclaration([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsModuleDeclaration tsModuleDeclarationParam, TContext context) { }
        public virtual void VisitTsModuleDeclarationName([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsModuleDeclarationName tsModuleDeclarationNameParam, TContext context) { }
        public virtual void VisitTsModuleQualifiedName([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsModuleQualifiedName tsModuleQualifiedNameParam, TContext context) { }
        public virtual void VisitTsNewExpression([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsNewExpression tsNewExpressionParam, TContext context) { }
        public virtual void VisitTsObjectLiteral([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsObjectLiteral tsObjectLiteralParam, TContext context) { }
        public virtual void VisitTsObjectPropertiesList([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsObjectPropertiesList tsObjectPropertiesListParam, TContext context) { }
        public virtual void VisitTsObjectPropertyAccessor([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsObjectPropertyAccessor tsObjectPropertyAccessorParam, TContext context) { }
        public virtual void VisitTsObjectPropertyDeclaration([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsObjectPropertyDeclaration tsObjectPropertyDeclarationParam, TContext context) { }
        public virtual void VisitTsObjectPropertyInitializer([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsObjectPropertyInitializer tsObjectPropertyInitializerParam, TContext context) { }
        public virtual void VisitTsObjectTypeUsage([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsObjectTypeUsage tsObjectTypeUsageParam, TContext context) { }
        public virtual void VisitTsParameterDeclaration([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsParameterDeclaration tsParameterDeclarationParam, TContext context) { }
        public virtual void VisitTsParametersList([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsParametersList tsParametersListParam, TContext context) { }
        public virtual void VisitTsParametersOwner([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsParametersOwner tsParametersOwnerParam, TContext context) { }
        public virtual void VisitTsParenthesizedExpression([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsParenthesizedExpression tsParenthesizedExpressionParam, TContext context) { }
        public virtual void VisitTsPostfixExpression([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsPostfixExpression tsPostfixExpressionParam, TContext context) { }
        public virtual void VisitTsPrefixExpression([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsPrefixExpression tsPrefixExpressionParam, TContext context) { }
        public virtual void VisitTsPropertyName([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsPropertyName tsPropertyNameParam, TContext context) { }
        public virtual void VisitTsPropertyNameIdentifier([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsPropertyNameIdentifier tsPropertyNameIdentifierParam, TContext context) { }
        public virtual void VisitTsPropertyNameNumericLiteral([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsPropertyNameNumericLiteral tsPropertyNameNumericLiteralParam, TContext context) { }
        public virtual void VisitTsPropertyNameStringLiteral([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsPropertyNameStringLiteral tsPropertyNameStringLiteralParam, TContext context) { }
        public virtual void VisitTsPropertySignatureDeclaration([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsPropertySignatureDeclaration tsPropertySignatureDeclarationParam, TContext context) { }
        public virtual void VisitTsReferenceExpression([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsReferenceExpression tsReferenceExpressionParam, TContext context) { }
        public virtual void VisitTsReferenceName([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsReferenceName tsReferenceNameParam, TContext context) { }
        public virtual void VisitTsReturnStatement([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsReturnStatement tsReturnStatementParam, TContext context) { }
        public virtual void VisitTsStatement([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsStatement tsStatementParam, TContext context) { }
        public virtual void VisitTsStatementWithParenthesis([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsStatementWithParenthesis tsStatementWithParenthesisParam, TContext context) { }
        public virtual void VisitTsSuperExpression([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsSuperExpression tsSuperExpressionParam, TContext context) { }
        public virtual void VisitTsSwitchStatement([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsSwitchStatement tsSwitchStatementParam, TContext context) { }
        public virtual void VisitTsThisExpression([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsThisExpression tsThisExpressionParam, TContext context) { }
        public virtual void VisitTsThrowStatement([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsThrowStatement tsThrowStatementParam, TContext context) { }
        public virtual void VisitTsTryStatement([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTryStatement tsTryStatementParam, TContext context) { }
        public virtual void VisitTsTypeAnnotation([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeAnnotation tsTypeAnnotationParam, TContext context) { }
        public virtual void VisitTsTypeArgumentList([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeArgumentList tsTypeArgumentListParam, TContext context) { }
        public virtual void VisitTsTypeDeclaration([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeDeclaration tsTypeDeclarationParam, TContext context) { }
        public virtual void VisitTsTypeMemberDeclaration([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeMemberDeclaration tsTypeMemberDeclarationParam, TContext context) { }
        public virtual void VisitTsTypeParameterDeclaration([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeParameterDeclaration tsTypeParameterDeclarationParam, TContext context) { }
        public virtual void VisitTsTypeParameters([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeParameters tsTypeParametersParam, TContext context) { }
        public virtual void VisitTsTypeParametersOwner([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeParametersOwner tsTypeParametersOwnerParam, TContext context) { }
        public virtual void VisitTsTypeUsage([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeUsage tsTypeUsageParam, TContext context) { }
        public virtual void VisitTsVariableDeclaration([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsVariableDeclaration tsVariableDeclarationParam, TContext context) { }
        public virtual void VisitTsVariableDeclarationsList([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsVariableDeclarationsList tsVariableDeclarationsListParam, TContext context) { }
        public virtual void VisitTsVariableDeclarationStatement([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsVariableDeclarationStatement tsVariableDeclarationStatementParam, TContext context) { }
        public virtual void VisitTsWhileStatement([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsWhileStatement tsWhileStatementParam, TContext context) { }
        public virtual void VisitTsWithStatement([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsWithStatement tsWithStatementParam, TContext context) { }
    }
    public abstract class TsTreeNodeVisitor<TContext, TReturn>
    
    
    {
        public virtual TReturn VisitNode([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode node, TContext context) { }
        public virtual TReturn VisitTsAccessorBody([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsAccessorBody tsAccessorBodyParam, TContext context) { }
        public virtual TReturn VisitTsAccessorSignature([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsAccessorSignature tsAccessorSignatureParam, TContext context) { }
        public virtual TReturn VisitTsAmbientModuleName([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsAmbientModuleName tsAmbientModuleNameParam, TContext context) { }
        public virtual TReturn VisitTsArrayLiteral([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsArrayLiteral tsArrayLiteralParam, TContext context) { }
        public virtual TReturn VisitTsArrayTypeUsage([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsArrayTypeUsage tsArrayTypeUsageParam, TContext context) { }
        public virtual TReturn VisitTsBaseTypeClause([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsBaseTypeClause tsBaseTypeClauseParam, TContext context) { }
        public virtual TReturn VisitTsBinaryExpression([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsBinaryExpression tsBinaryExpressionParam, TContext context) { }
        public virtual TReturn VisitTsBlock([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsBlock tsBlockParam, TContext context) { }
        public virtual TReturn VisitTsBlockLambdaExpression([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsBlockLambdaExpression tsBlockLambdaExpressionParam, TContext context) { }
        public virtual TReturn VisitTsBreakStatement([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsBreakStatement tsBreakStatementParam, TContext context) { }
        public virtual TReturn VisitTsCallSignatureDeclaration([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsCallSignatureDeclaration tsCallSignatureDeclarationParam, TContext context) { }
        public virtual TReturn VisitTsCaseCaseClause([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsCaseCaseClause tsCaseCaseClauseParam, TContext context) { }
        public virtual TReturn VisitTsCaseClause([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsCaseClause tsCaseClauseParam, TContext context) { }
        public virtual TReturn VisitTsCaseClausesList([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsCaseClausesList tsCaseClausesListParam, TContext context) { }
        public virtual TReturn VisitTsCastExpression([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsCastExpression tsCastExpressionParam, TContext context) { }
        public virtual TReturn VisitTsCatchBlock([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsCatchBlock tsCatchBlockParam, TContext context) { }
        public virtual TReturn VisitTsClassDeclaration([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsClassDeclaration tsClassDeclarationParam, TContext context) { }
        public virtual TReturn VisitTsClassMemberDeclaration([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsClassMemberDeclaration tsClassMemberDeclarationParam, TContext context) { }
        public virtual TReturn VisitTsCompoundExpression([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsCompoundExpression tsCompoundExpressionParam, TContext context) { }
        public virtual TReturn VisitTsConditionalTernaryExpression([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsConditionalTernaryExpression tsConditionalTernaryExpressionParam, TContext context) { }
        public virtual TReturn VisitTsConstructorDeclaration([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsConstructorDeclaration tsConstructorDeclarationParam, TContext context) { }
        public virtual TReturn VisitTsConstructorOverloadDeclaration([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsConstructorOverloadDeclaration tsConstructorOverloadDeclarationParam, TContext context) { }
        public virtual TReturn VisitTsContinueStatement([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsContinueStatement tsContinueStatementParam, TContext context) { }
        public virtual TReturn VisitTsDebugStatement([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsDebugStatement tsDebugStatementParam, TContext context) { }
        public virtual TReturn VisitTsDeclaredTypeUsage([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsDeclaredTypeUsage tsDeclaredTypeUsageParam, TContext context) { }
        public virtual TReturn VisitTsDefaultClause([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsDefaultClause tsDefaultClauseParam, TContext context) { }
        public virtual TReturn VisitTsDoStatement([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsDoStatement tsDoStatementParam, TContext context) { }
        public virtual TReturn VisitTsEmptyStatement([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsEmptyStatement tsEmptyStatementParam, TContext context) { }
        public virtual TReturn VisitTsEnumDeclaration([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsEnumDeclaration tsEnumDeclarationParam, TContext context) { }
        public virtual TReturn VisitTsEnumMemberDeclaration([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsEnumMemberDeclaration tsEnumMemberDeclarationParam, TContext context) { }
        public virtual TReturn VisitTsExpression([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsExpression tsExpressionParam, TContext context) { }
        public virtual TReturn VisitTsExpressionLambdaExpression([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsExpressionLambdaExpression tsExpressionLambdaExpressionParam, TContext context) { }
        public virtual TReturn VisitTsExpressionStatement([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsExpressionStatement tsExpressionStatementParam, TContext context) { }
        public virtual TReturn VisitTsExtendsClause([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsExtendsClause tsExtendsClauseParam, TContext context) { }
        public virtual TReturn VisitTsExternalModuleReferenceName([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsExternalModuleReferenceName tsExternalModuleReferenceNameParam, TContext context) { }
        public virtual TReturn VisitTsFile([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsFile tsFileParam, TContext context) { }
        public virtual TReturn VisitTsFileSection([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsFileSection tsFileSectionParam, TContext context) { }
        public virtual TReturn VisitTsFinallyBlock([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsFinallyBlock tsFinallyBlockParam, TContext context) { }
        public virtual TReturn VisitTsForDeclarationInitializer([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsForDeclarationInitializer tsForDeclarationInitializerParam, TContext context) { }
        public virtual TReturn VisitTsForeachStatement([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsForeachStatement tsForeachStatementParam, TContext context) { }
        public virtual TReturn VisitTsForExpressionInitializer([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsForExpressionInitializer tsForExpressionInitializerParam, TContext context) { }
        public virtual TReturn VisitTsForInitializer([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsForInitializer tsForInitializerParam, TContext context) { }
        public virtual TReturn VisitTsForStatement([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsForStatement tsForStatementParam, TContext context) { }
        public virtual TReturn VisitTsFunctionExpression([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsFunctionExpression tsFunctionExpressionParam, TContext context) { }
        public virtual TReturn VisitTsFunctionExpressionSignature([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsFunctionExpressionSignature tsFunctionExpressionSignatureParam, TContext context) { }
        public virtual TReturn VisitTsFunctionSignatureDeclaration([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsFunctionSignatureDeclaration tsFunctionSignatureDeclarationParam, TContext context) { }
        public virtual TReturn VisitTsFunctionStatement([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsFunctionStatement tsFunctionStatementParam, TContext context) { }
        public virtual TReturn VisitTsFunctionStatementSignature([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsFunctionStatementSignature tsFunctionStatementSignatureParam, TContext context) { }
        public virtual TReturn VisitTsFunctionTypeUsage([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsFunctionTypeUsage tsFunctionTypeUsageParam, TContext context) { }
        public virtual TReturn VisitTsIdentifierExpression([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsIdentifierExpression tsIdentifierExpressionParam, TContext context) { }
        public virtual TReturn VisitTsIfStatement([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsIfStatement tsIfStatementParam, TContext context) { }
        public virtual TReturn VisitTsImplementsClause([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsImplementsClause tsImplementsClauseParam, TContext context) { }
        public virtual TReturn VisitTsImportDeclaration([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsImportDeclaration tsImportDeclarationParam, TContext context) { }
        public virtual TReturn VisitTsImportModuleClause([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsImportModuleClause tsImportModuleClauseParam, TContext context) { }
        public virtual TReturn VisitTsIndexExpression([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsIndexExpression tsIndexExpressionParam, TContext context) { }
        public virtual TReturn VisitTsIndexSignatureDeclaration([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsIndexSignatureDeclaration tsIndexSignatureDeclarationParam, TContext context) { }
        public virtual TReturn VisitTsInterfaceDeclaration([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsInterfaceDeclaration tsInterfaceDeclarationParam, TContext context) { }
        public virtual TReturn VisitTsInvocationExpression([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsInvocationExpression tsInvocationExpressionParam, TContext context) { }
        public virtual TReturn VisitTsLabelledStatement([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsLabelledStatement tsLabelledStatementParam, TContext context) { }
        public virtual TReturn VisitTsLambdaExpression([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsLambdaExpression tsLambdaExpressionParam, TContext context) { }
        public virtual TReturn VisitTsLambdaExpressionFullSignature([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsLambdaExpressionFullSignature tsLambdaExpressionFullSignatureParam, TContext context) { }
        public virtual TReturn VisitTsLambdaExpressionSignature([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsLambdaExpressionSignature tsLambdaExpressionSignatureParam, TContext context) { }
        public virtual TReturn VisitTsLambdaExpressionSimpleSignature([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsLambdaExpressionSimpleSignature tsLambdaExpressionSimpleSignatureParam, TContext context) { }
        public virtual TReturn VisitTsLiteralExpression([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsLiteralExpression tsLiteralExpressionParam, TContext context) { }
        public virtual TReturn VisitTsMemberAccessorDeclaration([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsMemberAccessorDeclaration tsMemberAccessorDeclarationParam, TContext context) { }
        public virtual TReturn VisitTsMemberAccessorSignature([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsMemberAccessorSignature tsMemberAccessorSignatureParam, TContext context) { }
        public virtual TReturn VisitTsMemberExpression([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsMemberExpression tsMemberExpressionParam, TContext context) { }
        public virtual TReturn VisitTsMemberFunctionDeclaration([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsMemberFunctionDeclaration tsMemberFunctionDeclarationParam, TContext context) { }
        public virtual TReturn VisitTsMemberFunctionOverloadDeclaration([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsMemberFunctionOverloadDeclaration tsMemberFunctionOverloadDeclarationParam, TContext context) { }
        public virtual TReturn VisitTsMemberVariableDeclaration([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsMemberVariableDeclaration tsMemberVariableDeclarationParam, TContext context) { }
        public virtual TReturn VisitTsModuleDeclaration([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsModuleDeclaration tsModuleDeclarationParam, TContext context) { }
        public virtual TReturn VisitTsModuleDeclarationName([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsModuleDeclarationName tsModuleDeclarationNameParam, TContext context) { }
        public virtual TReturn VisitTsModuleQualifiedName([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsModuleQualifiedName tsModuleQualifiedNameParam, TContext context) { }
        public virtual TReturn VisitTsNewExpression([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsNewExpression tsNewExpressionParam, TContext context) { }
        public virtual TReturn VisitTsObjectLiteral([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsObjectLiteral tsObjectLiteralParam, TContext context) { }
        public virtual TReturn VisitTsObjectPropertiesList([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsObjectPropertiesList tsObjectPropertiesListParam, TContext context) { }
        public virtual TReturn VisitTsObjectPropertyAccessor([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsObjectPropertyAccessor tsObjectPropertyAccessorParam, TContext context) { }
        public virtual TReturn VisitTsObjectPropertyDeclaration([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsObjectPropertyDeclaration tsObjectPropertyDeclarationParam, TContext context) { }
        public virtual TReturn VisitTsObjectPropertyInitializer([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsObjectPropertyInitializer tsObjectPropertyInitializerParam, TContext context) { }
        public virtual TReturn VisitTsObjectTypeUsage([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsObjectTypeUsage tsObjectTypeUsageParam, TContext context) { }
        public virtual TReturn VisitTsParameterDeclaration([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsParameterDeclaration tsParameterDeclarationParam, TContext context) { }
        public virtual TReturn VisitTsParametersList([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsParametersList tsParametersListParam, TContext context) { }
        public virtual TReturn VisitTsParametersOwner([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsParametersOwner tsParametersOwnerParam, TContext context) { }
        public virtual TReturn VisitTsParenthesizedExpression([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsParenthesizedExpression tsParenthesizedExpressionParam, TContext context) { }
        public virtual TReturn VisitTsPostfixExpression([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsPostfixExpression tsPostfixExpressionParam, TContext context) { }
        public virtual TReturn VisitTsPrefixExpression([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsPrefixExpression tsPrefixExpressionParam, TContext context) { }
        public virtual TReturn VisitTsPropertyName([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsPropertyName tsPropertyNameParam, TContext context) { }
        public virtual TReturn VisitTsPropertyNameIdentifier([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsPropertyNameIdentifier tsPropertyNameIdentifierParam, TContext context) { }
        public virtual TReturn VisitTsPropertyNameNumericLiteral([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsPropertyNameNumericLiteral tsPropertyNameNumericLiteralParam, TContext context) { }
        public virtual TReturn VisitTsPropertyNameStringLiteral([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsPropertyNameStringLiteral tsPropertyNameStringLiteralParam, TContext context) { }
        public virtual TReturn VisitTsPropertySignatureDeclaration([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsPropertySignatureDeclaration tsPropertySignatureDeclarationParam, TContext context) { }
        public virtual TReturn VisitTsReferenceExpression([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsReferenceExpression tsReferenceExpressionParam, TContext context) { }
        public virtual TReturn VisitTsReferenceName([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsReferenceName tsReferenceNameParam, TContext context) { }
        public virtual TReturn VisitTsReturnStatement([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsReturnStatement tsReturnStatementParam, TContext context) { }
        public virtual TReturn VisitTsStatement([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsStatement tsStatementParam, TContext context) { }
        public virtual TReturn VisitTsStatementWithParenthesis([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsStatementWithParenthesis tsStatementWithParenthesisParam, TContext context) { }
        public virtual TReturn VisitTsSuperExpression([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsSuperExpression tsSuperExpressionParam, TContext context) { }
        public virtual TReturn VisitTsSwitchStatement([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsSwitchStatement tsSwitchStatementParam, TContext context) { }
        public virtual TReturn VisitTsThisExpression([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsThisExpression tsThisExpressionParam, TContext context) { }
        public virtual TReturn VisitTsThrowStatement([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsThrowStatement tsThrowStatementParam, TContext context) { }
        public virtual TReturn VisitTsTryStatement([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTryStatement tsTryStatementParam, TContext context) { }
        public virtual TReturn VisitTsTypeAnnotation([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeAnnotation tsTypeAnnotationParam, TContext context) { }
        public virtual TReturn VisitTsTypeArgumentList([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeArgumentList tsTypeArgumentListParam, TContext context) { }
        public virtual TReturn VisitTsTypeDeclaration([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeDeclaration tsTypeDeclarationParam, TContext context) { }
        public virtual TReturn VisitTsTypeMemberDeclaration([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeMemberDeclaration tsTypeMemberDeclarationParam, TContext context) { }
        public virtual TReturn VisitTsTypeParameterDeclaration([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeParameterDeclaration tsTypeParameterDeclarationParam, TContext context) { }
        public virtual TReturn VisitTsTypeParameters([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeParameters tsTypeParametersParam, TContext context) { }
        public virtual TReturn VisitTsTypeParametersOwner([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeParametersOwner tsTypeParametersOwnerParam, TContext context) { }
        public virtual TReturn VisitTsTypeUsage([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeUsage tsTypeUsageParam, TContext context) { }
        public virtual TReturn VisitTsVariableDeclaration([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsVariableDeclaration tsVariableDeclarationParam, TContext context) { }
        public virtual TReturn VisitTsVariableDeclarationsList([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsVariableDeclarationsList tsVariableDeclarationsListParam, TContext context) { }
        public virtual TReturn VisitTsVariableDeclarationStatement([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsVariableDeclarationStatement tsVariableDeclarationStatementParam, TContext context) { }
        public virtual TReturn VisitTsWhileStatement([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsWhileStatement tsWhileStatementParam, TContext context) { }
        public virtual TReturn VisitTsWithStatement([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsWithStatement tsWithStatementParam, TContext context) { }
    }
    public class static TsTryStatementNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTryStatement GetByBlock(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsBlock param) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTryStatement GetByCatch(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsCatchBlock param) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTryStatement GetByCatchBlock(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsBlock param) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTryStatement GetByFinally(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsFinallyBlock param) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTryStatement GetByFinallyBlock(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsBlock param) { }
    }
    public class static TsTypeAnnotationNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeAnnotation GetByTypeUsage(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeUsage param) { }
    }
    public class static TsTypeArgumentListNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeArgumentList GetByTypeArgument(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeUsage param) { }
    }
    public class static TsTypeDeclarationNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITypeScriptTreeNode GetByBaseTypeClause(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsBaseTypeClause param) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITypeScriptTreeNode GetByNameNode(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsIdentifierExpression param) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITypeScriptTreeNode GetByTypeParameterDeclaration(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeParameterDeclaration param) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITypeScriptTreeNode GetByTypeParametersSpecification(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeParameters param) { }
    }
    public class static TsTypeMemberDeclarationNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeMemberDeclaration GetByTypeAnnotation(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeAnnotation param) { }
    }
    public class static TsTypeParameterDeclarationNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeParameterDeclaration GetByNameNode(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsIdentifierExpression param) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeParameterDeclaration GetByTypeConstraint(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeUsage param) { }
    }
    public class static TsTypeParametersNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeParameters GetByTypeParameterDeclaration(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeParameterDeclaration param) { }
    }
    public class static TsTypeParametersOwnerNavigator { }
    public enum TsTypeUsageKind
    {
        DeclaredTypeUsage = 0,
        ArrayTypeUsage = 1,
        FunctionTypeUsage = 2,
        ObjectTypeUsage = 3,
    }
    public class static TsTypeUsageNavigator { }
    public class static TsVariableDeclarationNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsVariableDeclaration GetByNameNode(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsIdentifierExpression param) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsVariableDeclaration GetByTypeAnnotation(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeAnnotation param) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsVariableDeclaration GetByValue(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsExpression param) { }
    }
    public class static TsVariableDeclarationsListNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsVariableDeclarationsList GetByVariableDeclaration(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsVariableDeclaration param) { }
    }
    public class static TsVariableDeclarationStatementNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsVariableDeclarationStatement GetByDeclaration(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsVariableDeclaration param) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsVariableDeclarationStatement GetByDeclarationList(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsVariableDeclarationsList param) { }
    }
    public class static TsWhileStatementNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsWhileStatement GetByCondition(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsCompoundExpression param) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsWhileStatement GetByStatement(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsStatement param) { }
    }
    public class static TsWithStatementNavigator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsWithStatement GetByCondition(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsCompoundExpression param) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.ContractAnnotationAttribute("null <= null")]
        [JetBrains.Annotations.PureAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsWithStatement GetByStatement(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsStatement param) { }
    }
}
namespace JetBrains.ReSharper.Psi.JavaScript.Util
{
    
    public class static ComputeConstantValueUtil
    {
        public static readonly object BooleanFalse;
        public static readonly object BooleanTrue;
        public static readonly object DoubleNaN;
        public static readonly object DoubleNegativeInf;
        public static readonly object DoublePositiveInf;
        public static readonly object Integer0;
        public static readonly object Integer1;
        public static readonly object NullValue;
        public static readonly object UndefinedValue;
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static object Compute([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression expresion, bool canBeReduced = False) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static object GetNumericLiteralValue([JetBrains.Annotations.CanBeNullAttribute()] string value) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression RenderValue(object value, JetBrains.ReSharper.Psi.JavaScript.Services.JavaScriptElementFactory factory) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static string RenderValueToString(object value) { }
    }
    public class static JavaScriptExpressionUtil
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.ICompoundExpression CastExpressionToBoolean([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.ICompoundExpression expression) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression CastExpressionToBoolean([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression expression) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.ICompoundExpression CreateLogicallyNegatedExpression([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.ICompoundExpression expression) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression CreateLogicallyNegatedExpression([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression expression) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression GetOperandThroughParenthesis([JetBrains.Annotations.CanBeNullAttribute()] this JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression expression) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatement GetStatementToBeVisibleFromAll<TElement>([JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IEnumerable<TElement> elements)
            where TElement : JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptTreeNode { }
        public static bool IsAlienExpression(this JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression expression) { }
        public static bool IsAlienExpression(this JetBrains.ReSharper.Psi.JavaScript.Tree.ICompoundExpression compoundExpression) { }
        public static bool IsCursorAtSign([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IBinaryExpression condition, JetBrains.ReSharper.Psi.TreeOffset treeOffset) { }
        public static bool IsCursorAtSign([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IBinaryExpression condition, JetBrains.ReSharper.Psi.TreeTextRange treeOffset) { }
        public static bool IsKnownToBeBoolean([JetBrains.Annotations.CanBeNullAttribute()] this JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression expression) { }
        public static bool IsRedundant([JetBrains.Annotations.CanBeNullAttribute()] this JetBrains.ReSharper.Psi.JavaScript.Tree.IParenthesizedExpression expression) { }
        public static bool NeedToParenthesize([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression replacedExpression, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression newExpression) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.ICompoundExpression TransformCompoundLastExpression([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.ICompoundExpression expression, [JetBrains.Annotations.NotNullAttribute()] System.Func<JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression> processor) { }
    }
    public class static StatementUtil
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatement FindLoop([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptTreeNode GetBlockParentNode(this JetBrains.ReSharper.Psi.JavaScript.Tree.IBlock block) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatement GetLoopBody([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatement loop) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatement GetParentStatement(this JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatement statement, bool labelledStatements, bool includeObligatoryBlocks = False) { }
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatement GetPreviousStatement(JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatement statement) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatement GetSingleStatementThroughBlocks([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatement statement) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatementsRange GetStatementsRange([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IPsiServices psiServices, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DocumentModel.DocumentRange documentRange) { }
        public static T InsertStatement<T, U>([JetBrains.Annotations.NotNullAttribute()] T statement, [JetBrains.Annotations.NotNullAttribute()] ref U anchor, bool before)
            where T :  class, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatement
            where U :  class, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatement { }
        public static T InsertStatement<T>(T statement, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatementsRange anchor, bool before)
            where T :  class, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatement { }
        public static T Replace<T>(JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatementsRange statementsRange, T statement)
            where T :  class, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatement { }
    }
    public class static StringLiteralCharacterUtil
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public static string ConvertValueToPresentationSequence(char value, JetBrains.ReSharper.Psi.JavaScript.Util.StringLiteralPresentationForm presentationForm) { }
        public static int GetCharPresentationLength(string presentation, int firstCharInPresentationIndex) { }
        public static bool TryConvertPresentationToValue([JetBrains.Annotations.NotNullAttribute()] string charPresentation, JetBrains.ReSharper.Psi.JavaScript.Util.StringLiteralPresentationForm presentationForm, out string result) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static string TryConvertValueToPresentationSequence(char value, JetBrains.ReSharper.Psi.JavaScript.Util.StringLiteralPresentationForm presentationForm) { }
    }
    public enum StringLiteralPresentationForm
    {
        SINGLE_QUOTED = 0,
        DOUBLE_QUOTED = 1,
    }
    public class static StringLiteralUtil
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public static string ConvertValueToPresentation([JetBrains.Annotations.NotNullAttribute()] string value, JetBrains.ReSharper.Psi.JavaScript.Util.StringLiteralPresentationForm presentationForm) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static string TryConvertPresentationToValue([JetBrains.Annotations.NotNullAttribute()] string value, char quote) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static string TryConvertPresentationToValue([JetBrains.Annotations.NotNullAttribute()] string value, JetBrains.ReSharper.Psi.JavaScript.Util.StringLiteralPresentationForm presentationForm) { }
    }
}
namespace JetBrains.ReSharper.Psi.Json.CodeStyle
{
    
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.JavaScript.LanguageImpl.JSon.JsonLanguage))]
    public class JsonCodeFormatter : JetBrains.ReSharper.Psi.JavaScript.CodeStyle.JavaScriptCodeFormatterBase
    {
        public JsonCodeFormatter(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ReSharper.Psi.PsiLanguageType language, JetBrains.Application.Settings.ISettingsStore settingsStore, JetBrains.Application.Settings.ISettingsOptimization settingsOptimization, JetBrains.DataFlow.IViewable<JetBrains.ReSharper.Psi.JavaScript.CodeStyle.IJavaScriptCodeFormatterExtension> extensions) { }
    }
}
namespace JetBrains.ReSharper.Psi.Json.Impl.Finder
{
    
    [JetBrains.ReSharper.Psi.PsiSharedComponentAttribute()]
    public class JsonSearcherFactory : JetBrains.ReSharper.Psi.JavaScript.Impl.Finder.JavaScriptSearcherFactoryBase<JetBrains.ReSharper.Psi.JavaScript.LanguageImpl.JSon.JsonLanguage>
    {
        public JsonSearcherFactory(JetBrains.ReSharper.Psi.JavaScript.DeclaredElements.IJavaScriptSymbolInfoService infoService, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.JavaScript.Impl.Finder.ISourceFileFilterForDeclaredElementSearch> filters) { }
    }
}
namespace JetBrains.ReSharper.Psi.TypeScript.Gen
{
    
    public sealed class ErrorMessages
    {
        public static string GetErrorMessage0() { }
        public static string GetErrorMessage1() { }
        public static string GetErrorMessage10() { }
        public static string GetErrorMessage11() { }
        public static string GetErrorMessage12() { }
        public static string GetErrorMessage13() { }
        public static string GetErrorMessage14() { }
        public static string GetErrorMessage15() { }
        public static string GetErrorMessage16() { }
        public static string GetErrorMessage17() { }
        public static string GetErrorMessage18() { }
        public static string GetErrorMessage19() { }
        public static string GetErrorMessage2() { }
        public static string GetErrorMessage20() { }
        public static string GetErrorMessage21() { }
        public static string GetErrorMessage22() { }
        public static string GetErrorMessage23() { }
        public static string GetErrorMessage24() { }
        public static string GetErrorMessage25() { }
        public static string GetErrorMessage26() { }
        public static string GetErrorMessage27() { }
        public static string GetErrorMessage28() { }
        public static string GetErrorMessage29() { }
        public static string GetErrorMessage3() { }
        public static string GetErrorMessage30() { }
        public static string GetErrorMessage31() { }
        public static string GetErrorMessage32() { }
        public static string GetErrorMessage33() { }
        public static string GetErrorMessage34() { }
        public static string GetErrorMessage35() { }
        public static string GetErrorMessage36() { }
        public static string GetErrorMessage37() { }
        public static string GetErrorMessage38() { }
        public static string GetErrorMessage39() { }
        public static string GetErrorMessage4() { }
        public static string GetErrorMessage40() { }
        public static string GetErrorMessage41() { }
        public static string GetErrorMessage42() { }
        public static string GetErrorMessage43() { }
        public static string GetErrorMessage44() { }
        public static string GetErrorMessage45() { }
        public static string GetErrorMessage46() { }
        public static string GetErrorMessage47() { }
        public static string GetErrorMessage48() { }
        public static string GetErrorMessage49() { }
        public static string GetErrorMessage5() { }
        public static string GetErrorMessage50() { }
        public static string GetErrorMessage51() { }
        public static string GetErrorMessage52() { }
        public static string GetErrorMessage53() { }
        public static string GetErrorMessage54() { }
        public static string GetErrorMessage55() { }
        public static string GetErrorMessage56() { }
        public static string GetErrorMessage57() { }
        public static string GetErrorMessage58() { }
        public static string GetErrorMessage59() { }
        public static string GetErrorMessage6() { }
        public static string GetErrorMessage60() { }
        public static string GetErrorMessage61() { }
        public static string GetErrorMessage62() { }
        public static string GetErrorMessage63() { }
        public static string GetErrorMessage64() { }
        public static string GetErrorMessage65() { }
        public static string GetErrorMessage66() { }
        public static string GetErrorMessage67() { }
        public static string GetErrorMessage68() { }
        public static string GetErrorMessage69() { }
        public static string GetErrorMessage7() { }
        public static string GetErrorMessage70() { }
        public static string GetErrorMessage71() { }
        public static string GetErrorMessage72() { }
        public static string GetErrorMessage73() { }
        public static string GetErrorMessage8() { }
        public static string GetErrorMessage9() { }
    }
    public class static TokenBitsets
    {
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet ElementBitset_0;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet ElementBitset_1;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet ElementBitset_2;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet ElementBitset_3;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet ElementBitset_4;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet ElementBitset_5;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet ElementBitset_6;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet ElementBitset_7;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet ElementBitset_8;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_tsAccessorBody;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_tsAccessorSignature;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_tsAmbientModuleName;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_tsArgumentListAux;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_tsArgumentListAux2;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_tsArrayLiteral;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_tsArrayTypeUsage;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_tsAssignmentOperatorAux;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_tsBaseTypeClause;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_tsBinaryExpression;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_tsBinaryOperatorAux;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_tsBlock;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_tsBlockLambdaExpression;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_tsBreakStatement;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_tsCallSignatureDeclaration;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_tsCaseCaseClause;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_tsCaseClause;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_tsCaseClausesList;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_tsCastExpression;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_tsCatchBlock;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_tsClassDeclaration;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_tsClassMemberDeclaration;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_tsCompoundExpression;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_tsConditionalTernaryExpression;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_tsConstructorDeclaration;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_tsConstructorOverloadDeclaration;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_tsContinueStatement;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_tsDebugStatement;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_tsDeclaredTypeUsage;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_tsDefaultClause;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_tsDoStatement;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_tsEmptyStatement;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_tsEnumDeclaration;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_tsEnumMemberDeclaration;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_tsExpression;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_tsExpressionLambdaExpression;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_tsExpressionStatement;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_tsExtendsClause;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_tsExternalModuleReferenceName;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_tsFile;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_tsFileSection;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_tsFinallyBlock;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_tsForDeclarationInitializer;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_tsForeachStatement;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_tsForeachStatementAux;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_tsForExpressionInitializer;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_tsForInitializer;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_tsForStatement;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_tsForStatementAux;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_tsFunctionExpression;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_tsFunctionExpressionSignature;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_tsFunctionSignatureDeclaration;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_tsFunctionStatement;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_tsFunctionStatementSignature;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_tsFunctionTypeUsage;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_tsIdentifierExpression;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_tsIfStatement;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_tsImplementsClause;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_tsImportDeclaration;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_tsImportModuleClause;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_tsIndexExpression;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_tsIndexSignatureDeclaration;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_tsInitialiser;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_tsInterfaceDeclaration;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_tsInvocationExpression;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_tsLabelledStatement;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_tsLambdaExpression;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_tsLambdaExpressionFullSignature;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_tsLambdaExpressionSignature;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_tsLambdaExpressionSimpleSignature;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_tsLiteralExpression;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_tsMemberAccessorDeclaration;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_tsMemberAccessorSignature;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_tsMemberExpression;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_tsMemberFunctionDeclaration;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_tsMemberFunctionOverloadDeclaration;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_tsMemberVariableDeclaration;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_tsModifiersList;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_tsModuleDeclaration;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_tsModuleDeclarationName;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_tsModuleQualifiedName;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_tsNewExpression;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_tsNoNewLineExpressionAndSemi;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_tsObjectLiteral;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_tsObjectPropertiesList;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_tsObjectPropertyAccessor;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_tsObjectPropertyDeclaration;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_tsObjectPropertyInitializer;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_tsObjectTypeUsage;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_tsParameterDeclaration;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_tsParametersList;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_tsParametersOwner;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_tsParenthesizedExpression;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_tsPostfixExpression;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_tsPrefixExpression;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_tsPropertyName;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_tsPropertyNameIdentifier;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_tsPropertyNameNumericLiteral;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_tsPropertyNameStringLiteral;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_tsPropertySignatureDeclaration;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_tsReferenceExpression;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_tsReferenceName;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_tsReturnStatement;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_tsSemicolon;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_tsStatement;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_tsStatementsList;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_tsStatementWithParenthesis;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_tsSuperExpression;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_tsSwitchStatement;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_tsThisExpression;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_tsThrowStatement;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_tsTryStatement;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_tsTypeAnnotation;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_tsTypeArgumentList;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_tsTypeDeclaration;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_tsTypeMemberDeclaration;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_tsTypeParameterDeclaration;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_tsTypeParameters;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_tsTypeParametersOwner;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_tsTypeUsage;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_tsVariableDeclaration;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_tsVariableDeclarationsList;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_tsVariableDeclarationStatement;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_tsWhileStatement;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet FIRST_tsWithStatement;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet TokenBitset_0;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet TokenBitset_1;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet TokenBitset_10;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet TokenBitset_11;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet TokenBitset_12;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet TokenBitset_13;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet TokenBitset_14;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet TokenBitset_15;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet TokenBitset_16;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet TokenBitset_17;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet TokenBitset_18;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet TokenBitset_19;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet TokenBitset_2;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet TokenBitset_20;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet TokenBitset_21;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet TokenBitset_22;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet TokenBitset_23;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet TokenBitset_24;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet TokenBitset_25;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet TokenBitset_26;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet TokenBitset_27;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet TokenBitset_28;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet TokenBitset_29;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet TokenBitset_3;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet TokenBitset_30;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet TokenBitset_31;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet TokenBitset_32;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet TokenBitset_4;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet TokenBitset_5;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet TokenBitset_6;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet TokenBitset_7;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet TokenBitset_8;
        public static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet TokenBitset_9;
    }
}