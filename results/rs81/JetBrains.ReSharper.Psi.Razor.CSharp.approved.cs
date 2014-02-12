[assembly: JetBrains.UI.Icons.CompiledIcons.CompiledIconsPackAttribute(IconNames=new string[] {
        "RazorCS"}, IconPackResourceIdentification="JetBrains.ReSharper.Psi.Razor.CSharp;component/resources/PsiRazorCSharpThemedIcon" +
    "s/ThemedIcons.PsiRazorCSharp.Generated.Xaml")]
[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]
[assembly: System.Windows.Markup.XmlnsDefinitionAttribute("urn:shemas-jetbrains-com:ui-application-icons-psi-razor-csharp", "JetBrains.ReSharper.Psi.Razor.CSharp.Resources")]

namespace JetBrains.ReSharper.Psi.Razor.CSharp.CodeStyle
{
    
    [JetBrains.Application.Settings.SettingsKeyAttribute(typeof(JetBrains.ReSharper.Psi.CSharp.CodeStyle.FormatSettings.CSharpFormatSettingsKey), "Code formatting in Razor C#")]
    public class RazorCSharpFormatSettings
    {
        [JetBrains.Application.Settings.SettingsEntryAttribute(false, "Override brace style for C# to always use \"At end of line (K&&R style)\"")]
        public bool AlwaysUseEndOfLineBraceStyle;
    }
}
namespace JetBrains.ReSharper.Psi.Razor.CSharp.Generate
{
    
    [JetBrains.ProjectModel.ProjectFileTypeAttribute(typeof(JetBrains.ProjectModel.RazorCSharpProjectFileType))]
    public class RazorCSharpCodeGenerator : JetBrains.ReSharper.Psi.Razor.Generate.RazorCodeGenerator
    {
        public RazorCSharpCodeGenerator(JetBrains.ReSharper.Psi.ILanguageManager languageManager, JetBrains.Application.IApplicationDescriptor applicationDescriptor) { }
        public override string BlockEnd { get; }
        public override string BlockStart { get; }
        public override string ClassTemplateEnd { get; }
        public override string ClassTemplateStart { get; }
        public override string CommentEnd { get; }
        public override string CommentStart { get; }
        public override string ExecuteEnd { get; }
        public override string ExecuteStart { get; }
        public override string FileHeader { get; }
        public override string FileTemplateEnd { get; }
        public override string FileTemplateStart { get; }
        public override string FunctionsEnd { get; }
        public override string FunctionsStart { get; }
        public override string HelperDelegateParameterName { get; }
        public override string HelperLambdaEnd { get; }
        public override string HelperLambdaStart { get; }
        public override string HelperStart { get; }
        public override string IgnoreEolComment { get; }
        public override string ImportNamespaceEnd { get; }
        public override JetBrains.ReSharper.Psi.PsiLanguageType Language { get; }
        public override string SectionEnd { get; }
        public override string SectionStart { get; }
        public override string StatementEnd { get; }
        public override string StatementEndComment { get; }
        public override string StatementStart { get; }
        public override string StatementStartComment { get; }
        public override string StaticExecuteStart { get; }
        public override string StaticHelperStart { get; }
        public override string TemplatedDelegateEnd { get; }
        public override string TemplatedDelegateStart { get; }
        public override string TemplateDelegateParameterName { get; }
        public override string TypedParameterPrefix { get; }
        public override string TypedParameterSuffix { get; }
        public override string WriteEnd { get; }
        public override string WriteHtmlEnd { get; }
        public override string WriteHtmlStart { get; }
        public override string WriteStart { get; }
        public override void EscapeCommentText(JetBrains.ReSharper.Psi.Tree.ITreeNode node, JetBrains.ReSharper.Psi.Web.Generation.GenerationResults context) { }
        public override void EscapeHtmlText(JetBrains.ReSharper.Psi.Tree.ITreeNode node, JetBrains.ReSharper.Psi.Web.Generation.GenerationResults context, JetBrains.ReSharper.Psi.Razor.Impl.Generate.RazorCodeGeneratorProcessor processor) { }
        public override string GetPageBaseType(JetBrains.ReSharper.Psi.Web.Cache.WebConfigData webConfigData) { }
        public override string MakeSafeName(string name) { }
    }
}
namespace JetBrains.ReSharper.Psi.Razor.CSharp.Impl.CodeStyle
{
    
    [JetBrains.ProjectModel.ProjectFileTypeAttribute(typeof(JetBrains.ProjectModel.RazorCSharpProjectFileType))]
    public class RazorCSharpCustomFormattingInfoProvider : JetBrains.ReSharper.Psi.CSharp.Impl.CodeStyle.DummyCSharpCustomFormattingInfoProvider
    {
        public RazorCSharpCustomFormattingInfoProvider(JetBrains.ReSharper.Psi.Razor.Impl.CustomHandlers.IRazorPsiServices psiServices, JetBrains.ReSharper.Psi.Razor.Generate.RazorCodeGenerator codeGenerator) { }
        public override JetBrains.ReSharper.Psi.CSharp.CodeStyle.CSharpCodeFormattingSettings AdjustFormattingSettings(JetBrains.ReSharper.Psi.CSharp.CodeStyle.CSharpCodeFormattingSettings settings, JetBrains.Application.Settings.IContextBoundSettingsStore contextBoundSettingsStore, JetBrains.Application.Settings.ISettingsOptimization settingsOptimization) { }
        public override bool AllowDecoration(JetBrains.ReSharper.Psi.CSharp.Impl.CodeStyle.CSharpCodeFormattingContext context) { }
        public override bool CanDeBlock(JetBrains.ReSharper.Psi.CSharp.Tree.IBlock node) { }
        public override bool CanModifyInsideNodeRange(JetBrains.ReSharper.Psi.Tree.ITreeNode leftElement, JetBrains.ReSharper.Psi.Tree.ITreeNode rightElement) { }
        public override bool CanModifyNode(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public override bool CanWrap(JetBrains.ReSharper.Psi.Impl.CodeStyle.FormattingStageContext context) { }
        public override JetBrains.ReSharper.Psi.CSharp.Impl.CodeStyle.SpaceType GetBlockSpaceType(JetBrains.ReSharper.Psi.CSharp.Impl.CodeStyle.CSharpFmtStageContext context) { }
        public override JetBrains.ReSharper.Psi.Tree.ITreeNode GetLChild(JetBrains.ReSharper.Psi.CSharp.Impl.CodeStyle.CSharpFmtStageContext context) { }
        public override void RunFormatterForEmbeddedLanguages(JetBrains.ReSharper.Psi.Tree.IFile currentFile, JetBrains.ReSharper.Psi.TreeTextRange range, JetBrains.ReSharper.Psi.CodeStyle.CodeFormatProfile profile, JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
        public override JetBrains.ReSharper.Psi.CSharp.Impl.CodeStyle.SpaceType VisitArgumentList(JetBrains.ReSharper.Psi.CSharp.Impl.CodeStyle.CSharpFmtStageContext context) { }
        public override JetBrains.ReSharper.Psi.CSharp.Impl.CodeStyle.SpaceType VisitInvocationExpression(JetBrains.ReSharper.Psi.CSharp.Impl.CodeStyle.CSharpFmtStageContext context) { }
    }
}
namespace JetBrains.ReSharper.Psi.Razor.CSharp.Impl.CustomHandlers
{
    
    public class CannotStartRegenerationException : System.Exception
    {
        public CannotStartRegenerationException(string message) { }
    }
    [JetBrains.ProjectModel.ProjectFileTypeAttribute(typeof(JetBrains.ProjectModel.RazorCSharpProjectFileType))]
    public sealed class RazorCSharpPsiServices : JetBrains.ReSharper.Psi.Razor.Impl.CustomHandlers.RazorPsiServicesBase
    {
        public RazorCSharpPsiServices(JetBrains.ReSharper.Psi.Razor.Generate.RazorCodeGenerator generator) { }
        public override JetBrains.ReSharper.Psi.Tree.ITreeNode AddIgnoreEolCommentMarker(JetBrains.ReSharper.Psi.Tree.ITreeNode node, bool checkIfExists = True) { }
        public override void BreakHtmlRangesIfNeeded(JetBrains.ReSharper.Psi.Razor.Tree.IRazorFile file, JetBrains.ReSharper.Psi.TreeOffset offset) { }
        public override JetBrains.ReSharper.Psi.Tree.ICommentNode CreateCommentToIgnoreEol(JetBrains.ReSharper.Psi.Tree.ITreeNode codeBehindContext) { }
        public override void DeleteIgnoreEolCommentMarker(JetBrains.ReSharper.Psi.Tree.ITreeNode node) { }
        public override void DetachServiceCommentMarker(JetBrains.ReSharper.Psi.Tree.IStatement statement) { }
        public override void DetachServiceCommentMarkerAfterDeclarations(JetBrains.ReSharper.Psi.Tree.ITreeNode statement) { }
        public override JetBrains.ReSharper.Psi.Tree.ITreeNode GetCodeBehindStatementByGeneratedRange(JetBrains.ReSharper.Psi.Tree.IFile codeBehindFile, JetBrains.ReSharper.Psi.TreeTextRange generatedRange, bool first) { }
        public override string GetDelegateParameterName(JetBrains.ReSharper.Psi.Tree.ITreeNode razorNode) { }
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Tree.ITreeNode> GetElementsFromCodebehindNode(JetBrains.ReSharper.Psi.Tree.ITreeNode codeBehindStatement) { }
        public JetBrains.Util.Pair<JetBrains.ReSharper.Psi.Tree.ITreeNode, bool> GetHelperByReturnStatement(JetBrains.ReSharper.Psi.Tree.ITreeNode node) { }
        public override JetBrains.Util.Pair<JetBrains.ReSharper.Psi.Tree.ITreeNode, bool> GetHelperBySystemStatement(JetBrains.ReSharper.Psi.Tree.ITreeNode node) { }
        public override JetBrains.Util.JetTuple<string, JetBrains.ReSharper.Psi.ITreeRange> GetHelperInfo(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration) { }
        public override string GetHtmlWriteLiteralStart(string parameter) { }
        public override string GetHtmlWriteStart(string parameter) { }
        public override JetBrains.Util.Pair<JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Razor.Impl.CustomHandlers.OriginalStatementType> GetOriginalNodeAndType(JetBrains.ReSharper.Psi.Tree.ITreeNode codeBehindStatement, bool first) { }
        public JetBrains.Util.Pair<JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Razor.Impl.CustomHandlers.OriginalStatementType> GetOriginalNodeAndType(JetBrains.ReSharper.Psi.CSharp.Tree.IBlock block, JetBrains.ReSharper.Psi.Tree.ITreeNode codeBehindStatement, bool first, System.Predicate<JetBrains.Util.Pair<JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Razor.Impl.CustomHandlers.OriginalStatementType>> checker) { }
        protected override JetBrains.Util.Pair<JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Razor.Impl.CustomHandlers.OriginalStatementType> GetOriginalNodeAndTypeWithChecker(JetBrains.ReSharper.Psi.Tree.ITreeNode codeBehindStatement, bool first, System.Predicate<JetBrains.Util.Pair<JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Razor.Impl.CustomHandlers.OriginalStatementType>> checker) { }
        public override JetBrains.ReSharper.Psi.Tree.IComment GetServiceCommentAfter(JetBrains.ReSharper.Psi.Tree.ITreeNode statement) { }
        public override JetBrains.ReSharper.Psi.Resolve.Managed.IManagedExpression GetWriteArgumentValue(JetBrains.ReSharper.Psi.Resolve.Managed.IManagedExpression expression, JetBrains.ReSharper.Psi.Razor.Impl.CustomHandlers.RazorMethodType methodType) { }
        public override bool IsEmptyWriteLiteral(JetBrains.ReSharper.Psi.Tree.ITreeNode codeBehindStatement) { }
        public override bool IsMethodWithRazorMarkup(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration) { }
        public override bool IsSpecialMethodInvocation(JetBrains.ReSharper.Psi.Tree.IStatement statement, params JetBrains.ReSharper.Psi.Razor.Impl.CustomHandlers.RazorMethodType[] methodTypes) { }
        public override bool IsSpecialMethodInvocation(JetBrains.ReSharper.Psi.Tree.IExpression expression, params JetBrains.ReSharper.Psi.Razor.Impl.CustomHandlers.RazorMethodType[] methodTypes) { }
        public override bool IsSpecialStatementDelimeter(JetBrains.ReSharper.Psi.Tree.ITreeNode node) { }
        protected override bool IsSystemStatement(JetBrains.ReSharper.Psi.Tree.IStatement codeBehindStatement) { }
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Tree.ITreeNode> SplitCodebehindNode(JetBrains.ReSharper.Psi.Tree.ITreeNode codeBehindStatement) { }
    }
    [JetBrains.ProjectModel.ProjectFileTypeAttribute(typeof(JetBrains.ProjectModel.RazorCSharpProjectFileType))]
    public class RazorCSharpTreeRangeBuilder : JetBrains.ReSharper.Psi.Util.ITreeRangeBuilder
    {
        public RazorCSharpTreeRangeBuilder(JetBrains.ReSharper.Psi.Razor.Impl.CustomHandlers.IRazorPsiServices razorPsiServices) { }
        public bool IsWhitespaceTokenOrSpecialToken(JetBrains.ReSharper.Psi.Tree.ITreeNode node) { }
        public bool SupportsLanguage(JetBrains.ReSharper.Psi.PsiLanguageType language) { }
    }
}
namespace JetBrains.ReSharper.Psi.Razor.CSharp.Impl
{
    
    [JetBrains.ReSharper.Psi.ExtensionsAPI.GeneratedDocumentServiceAttribute(typeof(JetBrains.ProjectModel.RazorCSharpProjectFileType))]
    public class RazorCSharpCodeBehindGeneratedDocumentService : JetBrains.ReSharper.Psi.Razor.Impl.RazorCodeBehindGeneratedDocumentService
    {
        public RazorCSharpCodeBehindGeneratedDocumentService(JetBrains.ReSharper.Psi.ExtensionsAPI.FileDependency fileDependency, JetBrains.ReSharper.Psi.Razor.Impl.Generate.IRazorCodeGeneratorInternal codeGenerator, JetBrains.ReSharper.Psi.Razor.Impl.CustomHandlers.IRazorPsiServices razorPsiServices) { }
        protected override bool CustomPromoteChange(JetBrains.ReSharper.Psi.TreeTextRange originalRange, string oldText, string newText, JetBrains.ReSharper.Psi.Impl.Shared.RangeTranslatorWithGeneratedRangeMap rangeTranslator, JetBrains.ReSharper.Psi.Tree.IFile generatedFile, JetBrains.ReSharper.Psi.Transactions.IPsiTransactionAction transactionAction) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.Razor.CSharp.RazorCSharpLanguage))]
    public class RazorCSharpLanguageService : JetBrains.ReSharper.Psi.Razor.RazorLanguageService
    {
        public RazorCSharpLanguageService(JetBrains.ReSharper.Psi.Razor.CSharp.RazorCSharpLanguage razorCSharpLanguage, JetBrains.ReSharper.Psi.IConstantValueService constantValueService, JetBrains.ReSharper.Psi.Razor.Parsing.IRazorTokenNodeTypes tokenNodeTypes, JetBrains.ReSharper.Psi.Html.IHtmlCodeFormatter codeFormatter, JetBrains.ReSharper.Psi.Html.Parsing.IWebTreeBuilderFactory webTreeBuilderFactory) { }
        public override bool SupportTypeMemberCache { get; }
        public override JetBrains.ReSharper.Psi.Parsing.ILexerFactory GetPrimaryLexerFactory() { }
    }
}
namespace JetBrains.ReSharper.Psi.Razor.CSharp.Impl.References
{
    
    public class RazorCSharpCodeBehindReferenceProvider : JetBrains.ReSharper.Psi.Razor.Impl.References.RazorCodeBehindReferenceProvider<JetBrains.ReSharper.Psi.CSharp.Tree.IAssignmentExpression, JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpLiteralExpression>
    {
        public RazorCSharpCodeBehindReferenceProvider(JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Psi.Razor.IRazorServices razorServices, System.Func<JetBrains.ReSharper.Psi.CSharp.Tree.IAssignmentExpression, JetBrains.Util.Pair<JetBrains.ReSharper.Psi.Tree.IExpression, JetBrains.ReSharper.Psi.Tree.IExpression>> assigmentChecker) { }
        protected override bool IsAppropriateNode(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
    }
    [JetBrains.ReSharper.Psi.Resolve.ReferenceProviderFactoryAttribute()]
    public class RazorCSharpReferenceProviderFactory : JetBrains.ReSharper.Psi.Resolve.IReferenceProviderFactory
    {
        public RazorCSharpReferenceProviderFactory(JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Psi.Razor.IRazorServices razorServices) { }
        public event System.Action OnChanged;
        public JetBrains.ReSharper.Psi.Resolve.IReferenceFactory CreateFactory(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, JetBrains.ReSharper.Psi.Tree.IFile file) { }
    }
}
namespace JetBrains.ReSharper.Psi.Razor.CSharp.Impl.Regenerator
{
    
    [JetBrains.ProjectModel.ProjectFileTypeAttribute(typeof(JetBrains.ProjectModel.RazorCSharpProjectFileType))]
    public class RazorCSharpRegenerator : JetBrains.ReSharper.Psi.Razor.Impl.IRazorRegenerator
    {
        public RazorCSharpRegenerator(JetBrains.ReSharper.Psi.ILanguageManager languageManager, JetBrains.ReSharper.Psi.Razor.Generate.RazorCodeGenerator codeGenerator, JetBrains.ReSharper.Psi.Razor.Impl.CustomHandlers.IRazorPsiServices razorPsiServices, JetBrains.ProjectModel.ProjectFileType projectFileType, JetBrains.ReSharper.Psi.IProjectFileLanguageService projectFileLanguageService) { }
        public JetBrains.ReSharper.Psi.Razor.Generate.RazorCodeGenerator CodeGenerator { get; }
        public JetBrains.ReSharper.Psi.Razor.Impl.CustomHandlers.IRazorPsiServices RazorPsiServices { get; }
        public void GenerateAndInsertRazorHelper(JetBrains.ReSharper.Psi.Razor.Tree.IRazorFile parent, JetBrains.ReSharper.Psi.Tree.ITreeNode anchor, JetBrains.ReSharper.Psi.Tree.IDeclaration codeBehindMethod, bool before = True) { }
        public JetBrains.ReSharper.Psi.ITreeRange GenerateAndInsertRazorStatements(JetBrains.ReSharper.Psi.Tree.ITreeNode parent, JetBrains.ReSharper.Psi.Tree.ITreeNode anchor, JetBrains.ReSharper.Psi.ITreeRange codeBehindStatements, bool before, JetBrains.ReSharper.Psi.ITreeRange rangeToTrack = null) { }
        public JetBrains.Util.Pair<JetBrains.ReSharper.Psi.Razor.Tree.IRazorHelper, JetBrains.ReSharper.Psi.Impl.Shared.IGeneratedRangeMap> GenerateRazorHelper(JetBrains.ReSharper.Psi.Razor.Tree.IRazorFile parent, JetBrains.ReSharper.Psi.Tree.IDeclaration codeBehindMethod) { }
        public JetBrains.ReSharper.Psi.Razor.Parsing.RazorElementFactory GetRazorElementFactory(JetBrains.ReSharper.Psi.Tree.ITreeNode node) { }
        public class RazorCodeGenerationResult
        {
            public string Code { get; set; }
            public JetBrains.ReSharper.Psi.ITreeRange Range { get; set; }
            public JetBrains.ReSharper.Psi.Impl.Shared.IGeneratedRangeMap RangeMap { get; set; }
        }
    }
}
namespace JetBrains.ReSharper.Psi.Razor.CSharp.Mvc.Parsing
{
    
    public class RazorCSharpMvcRawLexer : JetBrains.ReSharper.Psi.Html.Parsing.IHtmlCompoundLexer, JetBrains.ReSharper.Psi.Parsing.ILexer, JetBrains.ReSharper.Psi.Parsing.ILexerEx
    {
        protected const int YY_AFTER_MARKUP_IN_CODE = 19;
        protected const int YY_BEFORE_FUNCTIONS_CODE = 15;
        protected const int YY_BEFORE_LINE_MARKUP_IN_CODE = 23;
        protected const int YY_COMMENT_MARKUP = 36;
        protected const int YY_FINISH_MARKUP_IN_TEXT_TAG = 35;
        protected const int YY_IN_BLOCK_CODE = 13;
        protected const int YY_IN_CODE = 10;
        protected const int YY_IN_CODE_CAN_BE_LINE_MARKUP = 20;
        protected const int YY_IN_CODE_CAN_BE_MARKUP = 17;
        protected const int YY_IN_CODE_CAN_BE_MARKUP_AFTER_BRACKET = 62;
        protected const int YY_IN_CODE_CAN_BE_TEMPLATE = 21;
        protected const int YY_IN_CODE_CHAR_LITERAL = 61;
        protected const int YY_IN_CODE_OPENED_BRACKET = 11;
        protected const int YY_IN_CODE_SHOULD_BE_MARKUP = 18;
        protected const int YY_IN_CODE_STRING_LITERAL = 59;
        protected const int YY_IN_CODE_TRY_CATCH_CODE = 54;
        protected const int YY_IN_CODE_VERBATIM_STRING_LITERAL = 60;
        protected const int YY_IN_CODE_WITH_CONDITION = 49;
        protected const int YY_IN_CODE_WITH_CONDITION_BODY = 50;
        protected const int YY_IN_COMMENT = 37;
        protected const int YY_IN_DO_WHILE_CODE = 52;
        protected const int YY_IN_DO_WHILE_CONDITION_CODE = 53;
        protected const int YY_IN_FUNCTIONS_CODE = 14;
        protected const int YY_IN_HELPER = 48;
        protected const int YY_IN_IF_ELSE_CODE = 51;
        protected const int YY_IN_IMPLICIT_CODE = 5;
        protected const int YY_IN_IMPLICIT_CODE_CHAR_LITERAL = 65;
        protected const int YY_IN_IMPLICIT_CODE_IN_BRACKETS = 7;
        protected const int YY_IN_IMPLICIT_CODE_IN_PARENTHESES = 6;
        protected const int YY_IN_IMPLICIT_CODE_STRING_LITERAL = 63;
        protected const int YY_IN_IMPLICIT_CODE_VERBATIM_STRING_LITERAL = 64;
        protected const int YY_IN_PARENTHESES_CODE = 12;
        protected const int YY_IN_SECTION = 38;
        protected const int YY_IN_SECTION_BEFORE_BODY = 41;
        protected const int YY_IN_SECTION_BODY = 42;
        protected const int YY_IN_SECTION_EXPECT_BODY = 40;
        protected const int YY_IN_SECTION_IDENTIFIER = 39;
        protected const int YY_IN_SWITCH_CASE = 58;
        protected const int YY_IN_TEMPLATE = 22;
        protected const int YY_IN_TRANSITION = 3;
        protected const int YY_IN_TRANSITION_CODE = 43;
        protected const int YY_IN_TRY_CATCH_CATCH_CODE = 56;
        protected const int YY_IN_TRY_CATCH_CODE = 55;
        protected const int YY_IN_TRY_CATCH_FINALLY_CODE = 57;
        protected const int YY_IN_USING = 1;
        protected const int YY_IN_WRAPPED_CODE_OPENED_BRACKET = 16;
        protected const int YY_IN_WRAPPED_IMPLICIT_CODE = 4;
        protected const int YY_IN_WRAPPED_IMPLICIT_CODE_CLOSING_PARENTHESES = 9;
        protected const int YY_IN_WRAPPED_IMPLICIT_CODE_OPENED_PARENTHESES = 8;
        protected const int YY_LINE_MARKUP_IN_CODE = 24;
        protected const int YY_MARKUP_IN_CODE = 26;
        protected const int YY_MARKUP_IN_TEXT_TAG = 27;
        protected const int YY_NAMESPACE_END = 47;
        protected const int YY_NAMESPACE_EXPECTED = 46;
        protected const int YY_SCRIPT_MARKUP_IN_CODE = 28;
        protected const int YY_SCRIPT_MARKUP_IN_CODE_DOUBLEQUOTED_LITERAL = 29;
        protected const int YY_SCRIPT_MARKUP_IN_CODE_SINGLEQUOTED_LITERAL = 30;
        protected const int YY_SCRIPT_MARKUP_IN_TEXT_TAG = 31;
        protected const int YY_SCRIPT_MARKUP_IN_TEXT_TAG_DOUBLEQUOTED_LITERAL = 32;
        protected const int YY_SCRIPT_MARKUP_IN_TEXT_TAG_SINGLEQUOTED_LITERAL = 33;
        protected const int YY_START_MARKUP_IN_TEXT_TAG = 34;
        protected const int YY_TRANSITION_IN_MARKUP = 25;
        protected const int YY_TYPE_EXPECTED = 45;
        protected const int YY_TYPE_WITH_SPACE_EXPECTED = 44;
        protected const int YY_WRAP_TRANSITION = 2;
        protected const int YYINITIAL = 0;
        public RazorCSharpMvcRawLexer(JetBrains.ReSharper.Psi.Razor.Parsing.IRazorTokenNodeTypes tokenNodeTypes, JetBrains.Text.IBuffer buffer) { }
        public RazorCSharpMvcRawLexer(JetBrains.Text.IBuffer buffer) { }
        public RazorCSharpMvcRawLexer(JetBrains.Text.IBuffer buffer, int startOffset, int endOffset) { }
        public JetBrains.Text.IBuffer Buffer { get; }
        protected int BufferEnd { get; set; }
        protected int BufferIndex { get; set; }
        protected int BufferStart { get; set; }
        public virtual object CurrentPosition { get; set; }
        public int EOFPos { get; }
        public int LexemIndent { get; }
        public virtual uint LexerStateEx { get; }
        protected int LexicalState { get; set; }
        public short NStates { get; }
        protected int parentheses { get; set; }
        public virtual int TokenEnd { get; }
        public virtual int TokenStart { get; }
        public JetBrains.ReSharper.Psi.Parsing.TokenNodeType TokenType { get; }
        public JetBrains.ReSharper.Psi.Html.Parsing.IHtmlCompoundTokenNodeTypes TokenTypes { get; }
        public JetBrains.ReSharper.Psi.Parsing.TokenNodeType _locateToken() { }
        public virtual void Advance() { }
        protected bool IsScriptTag(string tag) { }
        protected JetBrains.ReSharper.Psi.Parsing.TokenNodeType makeToken(JetBrains.ReSharper.Psi.Parsing.TokenNodeType type) { }
        protected JetBrains.ReSharper.Psi.Parsing.TokenNodeType PopEofToken() { }
        protected void PopState() { }
        protected void PopTag(System.Action onEmpty, string tagName = null) { }
        protected void PopTags() { }
        protected void PushEofToken(JetBrains.ReSharper.Psi.Parsing.TokenNodeType token) { }
        protected void PushState(int state) { }
        protected void PushTag(string tagName) { }
        protected void PushTags() { }
        public void Start() { }
        public virtual void Start(int startOffset, int endOffset, uint state) { }
    }
    public sealed class RazorCSharpMvcTreeBuilder : JetBrains.ReSharper.Psi.Razor.CSharp.Parsing.RazorCSharpTreeBuilder
    {
        public RazorCSharpMvcTreeBuilder(JetBrains.ReSharper.Psi.Razor.CSharp.Mvc.RazorCSharpMvcLanguage language, JetBrains.ReSharper.Psi.Razor.CSharp.Mvc.Tree.RazorCSharpMvcElementTypes elementTypes, JetBrains.ReSharper.Psi.Razor.Parsing.IRazorTokenNodeTypes tokenTypes, JetBrains.ReSharper.Psi.Razor.Parsing.RazorParserNodeTypeSets razorParserNodeTypeSets, System.Collections.Generic.ICollection<string> templatesMimeTypes, int depthThreshold) { }
        protected override string IncludeFileName { get; }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.Razor.CSharp.Mvc.RazorCSharpMvcLanguage))]
    public sealed class RazorCSharpMvcTreeBuilderFactory : JetBrains.ReSharper.Psi.Razor.CSharp.Parsing.RazorCSharpTreeBuilderFactory
    {
        public RazorCSharpMvcTreeBuilderFactory(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.Settings.ISettingsStore settingsStore, JetBrains.ReSharper.Psi.Razor.CSharp.Mvc.RazorCSharpMvcLanguage language, JetBrains.ReSharper.Psi.Razor.CSharp.Mvc.Tree.RazorCSharpMvcElementTypes elementTypes, JetBrains.ReSharper.Psi.Razor.Parsing.IRazorTokenNodeTypes tokenTypes, JetBrains.ReSharper.Psi.Razor.Parsing.RazorParserNodeTypeSets razorParserNodeTypeSets, JetBrains.ReSharper.Psi.PerformanceThreshold.PerformanceThresholds thresholds) { }
        public override JetBrains.ReSharper.Psi.Html.Parsing.IWebTreeBuilder CreateTreeBuilder() { }
    }
}
namespace JetBrains.ReSharper.Psi.Razor.CSharp.Mvc
{
    
    [JetBrains.ReSharper.Psi.LanguageDefinitionAttribute("Razor CSharp Mvc", Edition="Csharp")]
    public class RazorCSharpMvcLanguage : JetBrains.ReSharper.Psi.Razor.CSharp.RazorCSharpLanguage
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static readonly JetBrains.ReSharper.Psi.Razor.CSharp.Mvc.RazorCSharpMvcLanguage Instance;
        public const string Name = "Razor CSharp Mvc";
        protected RazorCSharpMvcLanguage(string name) { }
        protected RazorCSharpMvcLanguage(string name, string presentableName) { }
    }
    [JetBrains.ProjectModel.ProjectFileTypeAttribute(typeof(JetBrains.ProjectModel.RazorCSharpProjectFileType))]
    public class RazorCSharpMvcProjectFileLanguageService : JetBrains.ReSharper.Psi.Razor.CSharp.RazorCSharpProjectFileLanguageService
    {
        public RazorCSharpMvcProjectFileLanguageService(JetBrains.ProjectModel.RazorCSharpProjectFileType razorCSharpProjectFileType) { }
        protected override JetBrains.ReSharper.Psi.PsiLanguageType PsiLanguageType { get; }
        public override JetBrains.ReSharper.Psi.PsiLanguageType GetPsiLanguageType(JetBrains.ProjectModel.IProjectFile projectFile) { }
        public override JetBrains.ReSharper.Psi.IPsiSourceFileProperties GetPsiProperties(JetBrains.ProjectModel.IProjectFile projectFile, JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
    }
}
namespace JetBrains.ReSharper.Psi.Razor.CSharp.Mvc.Tree
{
    
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.Razor.CSharp.Mvc.RazorCSharpMvcLanguage))]
    public class RazorCSharpMvcElementTypes : JetBrains.ReSharper.Psi.Razor.Mvc.Tree.RazorMvcElementTypes
    {
        public RazorCSharpMvcElementTypes(JetBrains.ReSharper.Psi.Razor.Parsing.IRazorTokenNodeTypes tokenTypes) { }
    }
}
namespace JetBrains.ReSharper.Psi.Razor.CSharp.Parsing
{
    
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.Razor.CSharp.RazorCSharpLanguage))]
    public class RazorCSharpElementFactory : JetBrains.ReSharper.Psi.Razor.Parsing.RazorElementFactory
    {
        public RazorCSharpElementFactory(JetBrains.ReSharper.Psi.Html.Parsing.IWebTreeBuilderFactory builderFactory) { }
        public override JetBrains.ReSharper.Psi.Razor.Tree.IRazorFunctionsBlock CreateFunctionsBlock(string text, JetBrains.ReSharper.Psi.Tree.ITreeNode contextElement) { }
        public override JetBrains.ReSharper.Psi.Razor.Tree.IRazorNamespaceImport CreateNamespaceImport(string namespaceName, JetBrains.ReSharper.Psi.Tree.ITreeNode contextElement) { }
        public override JetBrains.ReSharper.Psi.Razor.Tree.IRazorStatement CreateStatement(string text, JetBrains.ReSharper.Psi.Tree.ITreeNode contextElement, JetBrains.ReSharper.Psi.SandBoxContextType contextType = 1) { }
    }
    public class RazorCSharpRawLexer : JetBrains.ReSharper.Psi.Html.Parsing.IHtmlCompoundLexer, JetBrains.ReSharper.Psi.Parsing.ILexer, JetBrains.ReSharper.Psi.Parsing.ILexerEx
    {
        protected const int YY_AFTER_MARKUP_IN_CODE = 19;
        protected const int YY_BEFORE_FUNCTIONS_CODE = 15;
        protected const int YY_BEFORE_LINE_MARKUP_IN_CODE = 23;
        protected const int YY_COMMENT_MARKUP = 36;
        protected const int YY_FINISH_MARKUP_IN_TEXT_TAG = 35;
        protected const int YY_IN_BLOCK_CODE = 13;
        protected const int YY_IN_CODE = 10;
        protected const int YY_IN_CODE_CAN_BE_LINE_MARKUP = 20;
        protected const int YY_IN_CODE_CAN_BE_MARKUP = 17;
        protected const int YY_IN_CODE_CAN_BE_MARKUP_AFTER_BRACKET = 62;
        protected const int YY_IN_CODE_CAN_BE_TEMPLATE = 21;
        protected const int YY_IN_CODE_CHAR_LITERAL = 61;
        protected const int YY_IN_CODE_OPENED_BRACKET = 11;
        protected const int YY_IN_CODE_SHOULD_BE_MARKUP = 18;
        protected const int YY_IN_CODE_STRING_LITERAL = 59;
        protected const int YY_IN_CODE_TRY_CATCH_CODE = 54;
        protected const int YY_IN_CODE_VERBATIM_STRING_LITERAL = 60;
        protected const int YY_IN_CODE_WITH_CONDITION = 49;
        protected const int YY_IN_CODE_WITH_CONDITION_BODY = 50;
        protected const int YY_IN_COMMENT = 37;
        protected const int YY_IN_DO_WHILE_CODE = 52;
        protected const int YY_IN_DO_WHILE_CONDITION_CODE = 53;
        protected const int YY_IN_FUNCTIONS_CODE = 14;
        protected const int YY_IN_HELPER = 48;
        protected const int YY_IN_IF_ELSE_CODE = 51;
        protected const int YY_IN_IMPLICIT_CODE = 5;
        protected const int YY_IN_IMPLICIT_CODE_CHAR_LITERAL = 65;
        protected const int YY_IN_IMPLICIT_CODE_IN_BRACKETS = 7;
        protected const int YY_IN_IMPLICIT_CODE_IN_PARENTHESES = 6;
        protected const int YY_IN_IMPLICIT_CODE_STRING_LITERAL = 63;
        protected const int YY_IN_IMPLICIT_CODE_VERBATIM_STRING_LITERAL = 64;
        protected const int YY_IN_PARENTHESES_CODE = 12;
        protected const int YY_IN_SECTION = 38;
        protected const int YY_IN_SECTION_BEFORE_BODY = 41;
        protected const int YY_IN_SECTION_BODY = 42;
        protected const int YY_IN_SECTION_EXPECT_BODY = 40;
        protected const int YY_IN_SECTION_IDENTIFIER = 39;
        protected const int YY_IN_SWITCH_CASE = 58;
        protected const int YY_IN_TEMPLATE = 22;
        protected const int YY_IN_TRANSITION = 3;
        protected const int YY_IN_TRANSITION_CODE = 43;
        protected const int YY_IN_TRY_CATCH_CATCH_CODE = 56;
        protected const int YY_IN_TRY_CATCH_CODE = 55;
        protected const int YY_IN_TRY_CATCH_FINALLY_CODE = 57;
        protected const int YY_IN_USING = 1;
        protected const int YY_IN_WRAPPED_CODE_OPENED_BRACKET = 16;
        protected const int YY_IN_WRAPPED_IMPLICIT_CODE = 4;
        protected const int YY_IN_WRAPPED_IMPLICIT_CODE_CLOSING_PARENTHESES = 9;
        protected const int YY_IN_WRAPPED_IMPLICIT_CODE_OPENED_PARENTHESES = 8;
        protected const int YY_LINE_MARKUP_IN_CODE = 24;
        protected const int YY_MARKUP_IN_CODE = 26;
        protected const int YY_MARKUP_IN_TEXT_TAG = 27;
        protected const int YY_NAMESPACE_END = 47;
        protected const int YY_NAMESPACE_EXPECTED = 46;
        protected const int YY_SCRIPT_MARKUP_IN_CODE = 28;
        protected const int YY_SCRIPT_MARKUP_IN_CODE_DOUBLEQUOTED_LITERAL = 29;
        protected const int YY_SCRIPT_MARKUP_IN_CODE_SINGLEQUOTED_LITERAL = 30;
        protected const int YY_SCRIPT_MARKUP_IN_TEXT_TAG = 31;
        protected const int YY_SCRIPT_MARKUP_IN_TEXT_TAG_DOUBLEQUOTED_LITERAL = 32;
        protected const int YY_SCRIPT_MARKUP_IN_TEXT_TAG_SINGLEQUOTED_LITERAL = 33;
        protected const int YY_START_MARKUP_IN_TEXT_TAG = 34;
        protected const int YY_TRANSITION_IN_MARKUP = 25;
        protected const int YY_TYPE_EXPECTED = 45;
        protected const int YY_TYPE_WITH_SPACE_EXPECTED = 44;
        protected const int YY_WRAP_TRANSITION = 2;
        protected const int YYINITIAL = 0;
        public RazorCSharpRawLexer(JetBrains.ReSharper.Psi.Razor.Parsing.IRazorTokenNodeTypes tokenNodeTypes, JetBrains.Text.IBuffer buffer) { }
        public RazorCSharpRawLexer(JetBrains.Text.IBuffer buffer) { }
        public RazorCSharpRawLexer(JetBrains.Text.IBuffer buffer, int startOffset, int endOffset) { }
        public JetBrains.Text.IBuffer Buffer { get; }
        protected int BufferEnd { get; set; }
        protected int BufferIndex { get; set; }
        protected int BufferStart { get; set; }
        public virtual object CurrentPosition { get; set; }
        public int EOFPos { get; }
        public int LexemIndent { get; }
        public virtual uint LexerStateEx { get; }
        protected int LexicalState { get; set; }
        public short NStates { get; }
        protected int parentheses { get; set; }
        public virtual int TokenEnd { get; }
        public virtual int TokenStart { get; }
        public JetBrains.ReSharper.Psi.Parsing.TokenNodeType TokenType { get; }
        public JetBrains.ReSharper.Psi.Html.Parsing.IHtmlCompoundTokenNodeTypes TokenTypes { get; }
        public JetBrains.ReSharper.Psi.Parsing.TokenNodeType _locateToken() { }
        public virtual void Advance() { }
        protected bool IsScriptTag(string tag) { }
        protected JetBrains.ReSharper.Psi.Parsing.TokenNodeType makeToken(JetBrains.ReSharper.Psi.Parsing.TokenNodeType type) { }
        protected JetBrains.ReSharper.Psi.Parsing.TokenNodeType PopEofToken() { }
        protected void PopState() { }
        protected void PopTag(System.Action onEmpty, string tagName = null) { }
        protected void PopTags() { }
        protected void PushEofToken(JetBrains.ReSharper.Psi.Parsing.TokenNodeType token) { }
        protected void PushState(int state) { }
        protected void PushTag(string tagName) { }
        protected void PushTags() { }
        public void Start() { }
        public virtual void Start(int startOffset, int endOffset, uint state) { }
    }
    public class RazorCSharpTreeBuilder : JetBrains.ReSharper.Psi.Razor.Parsing.RazorTreeBuilder
    {
        public RazorCSharpTreeBuilder(JetBrains.ReSharper.Psi.Razor.CSharp.RazorCSharpLanguage language, JetBrains.ReSharper.Psi.Razor.Tree.RazorElementTypes elementTypes, JetBrains.ReSharper.Psi.Razor.Parsing.IRazorTokenNodeTypes tokenTypes, JetBrains.ReSharper.Psi.Razor.Parsing.RazorParserNodeTypeSets razorParserNodeTypeSets, System.Collections.Generic.ICollection<string> templatesMimeTypes, int depthThreshold) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.Razor.CSharp.RazorCSharpLanguage))]
    public class RazorCSharpTreeBuilderFactory : JetBrains.ReSharper.Psi.Razor.Parsing.RazorTreeBuilderFactory
    {
        public RazorCSharpTreeBuilderFactory(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.Settings.ISettingsStore settingsStore, JetBrains.ReSharper.Psi.Razor.CSharp.RazorCSharpLanguage language, JetBrains.ReSharper.Psi.Razor.Tree.RazorElementTypes elementTypes, JetBrains.ReSharper.Psi.Razor.Parsing.IRazorTokenNodeTypes tokenTypes, JetBrains.ReSharper.Psi.Razor.Parsing.RazorParserNodeTypeSets razorParserNodeTypeSets, JetBrains.ReSharper.Psi.PerformanceThreshold.PerformanceThresholds thresholds) { }
        public override JetBrains.ReSharper.Psi.Html.Parsing.IWebTreeBuilder CreateTreeBuilder() { }
    }
}
namespace JetBrains.ReSharper.Psi.Razor.CSharp
{
    
    public sealed class RazorCSharpKeywords : JetBrains.ReSharper.Psi.Razor.RazorKeywords
    {
        public const string Do = "do";
        public const string For = "for";
        public const string Foreach = "foreach";
        public const string If = "if";
        public const string Lock = "lock";
        public const string Switch = "switch";
        public const string Try = "try";
        public const string Using = "using";
        public const string While = "while";
    }
    [JetBrains.ReSharper.Psi.LanguageDefinitionAttribute("Razor CSharp", Edition="Csharp")]
    public class RazorCSharpLanguage : JetBrains.ReSharper.Psi.Razor.RazorLanguage
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static readonly JetBrains.ReSharper.Psi.Razor.CSharp.RazorCSharpLanguage Instance;
        public const string Name = "Razor CSharp";
        protected RazorCSharpLanguage(string name) { }
        protected RazorCSharpLanguage(string name, string presentableName) { }
    }
    [JetBrains.ProjectModel.ProjectFileTypeAttribute(typeof(JetBrains.ProjectModel.RazorCSharpProjectFileType))]
    public class RazorCSharpProjectFileCustomPsiPropertiesProvider : JetBrains.ReSharper.Psi.IProjectFileCustomPsiPropertiesProvider
    {
        public T GetCustomProperties<T>(JetBrains.ProjectModel.IProjectFile projectFile, JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
    }
    [JetBrains.ProjectModel.ProjectFileTypeAttribute(typeof(JetBrains.ProjectModel.RazorCSharpProjectFileType))]
    public class RazorCSharpProjectFileLanguageService : JetBrains.ReSharper.Psi.Razor.RazorProjectFileLanguageService
    {
        public RazorCSharpProjectFileLanguageService(JetBrains.ProjectModel.RazorCSharpProjectFileType razorCSharpProjectFileType) { }
        public override JetBrains.UI.Icons.IconId Icon { get; }
        protected override JetBrains.ReSharper.Psi.PsiLanguageType PsiLanguageType { get; }
        public override JetBrains.ReSharper.Psi.PsiLanguageType GetCodeBehindLanguage(JetBrains.Text.IBuffer buffer) { }
    }
}
namespace JetBrains.ReSharper.Psi.Razor.CSharp.Resources
{
    
    public sealed class PsiRazorCSharpThemedIcons
    {
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Psi.Razor.CSharp;component/resources/PsiRazorCSharpThemedIcon" +
            "s/ThemedIcons.PsiRazorCSharp.Generated.Xaml", 0, "RazorCS")]
        public sealed class RazorCS : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
    }
}
namespace JetBrains.ReSharper.Psi.Razor.CSharp.Utils
{
    
    public class static RazorCSharpModificationUtil
    {
        public static int FixRazorFunctionsBlock([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Razor.Tree.IRazorFunctionsBlock block) { }
        public static int FixRazorSection([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Razor.Tree.IRazorSection section, JetBrains.Application.Settings.IContextBoundSettingsStore contextBoundSettingsStore) { }
    }
}