[assembly: JetBrains.UI.Icons.CompiledIcons.CompiledIconsPackAttribute(IconNames=new string[] {
        "RazorSection",
        "Razor",
        "RazorHelperMethod",
        "RazorHelperMethodVs"}, IconPackResourceIdentification="JetBrains.ReSharper.Psi.Razor;component/resources/PsiRazorIcons/ThemedIcons.PsiRa" +
    "zor.Generated.Xaml")]
[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]
[assembly: System.Windows.Markup.XmlnsDefinitionAttribute("urn:shemas-jetbrains-com:ui-application-icons-psi-razor", "JetBrains.ReSharper.Psi.Razor.Resources")]

namespace JetBrains.ReSharper.Psi.Razor.CodeStyle
{
    
    [JetBrains.Application.Settings.SettingsKeyAttribute(typeof(JetBrains.ReSharper.Settings.CodeStyleSettings), "Razor code style settings")]
    public class RazorCodeStyleSettingsKey
    {
        [JetBrains.Application.Settings.SettingsEntryAttribute(true, "Prefer qualified reference")]
        public bool PreferQualifiedReference;
    }
}
namespace JetBrains.ReSharper.Psi.Razor.CodeStyle.SettingsUpgrade
{
    
    [JetBrains.ReSharper.Psi.CodeStyle.SettingsUpgrade.CodeStyleSettingsAttribute("Razor")]
    [System.ObsoleteAttribute("Deprecated, use RazorCodeStyleSettingsKey")]
    public class RazorCodeStyleSettings : JetBrains.Application.Configuration.IXmlReadable, System.ICloneable
    {
        public RazorCodeStyleSettings() { }
        public JetBrains.ReSharper.Psi.Razor.CodeStyle.SettingsUpgrade.RazorUsingsSettings UsingsSettings { get; }
        public object Clone() { }
        public void ReadFromXml(System.Xml.XmlElement element) { }
    }
    [System.ObsoleteAttribute()]
    public class RazorUsingsSettings : JetBrains.Application.Configuration.IXmlReadable
    {
        public RazorUsingsSettings() { }
        [JetBrains.Application.Configuration.XmlExternalizableAttribute(true)]
        public bool PreferQualifiedReference { get; set; }
        public JetBrains.ReSharper.Psi.Razor.CodeStyle.SettingsUpgrade.RazorUsingsSettings Clone() { }
        public void ReadFromXml(System.Xml.XmlElement element) { }
    }
    [JetBrains.Application.Configuration.Upgrade.GlobalSettingsUpgraderAttribute()]
    [JetBrains.ProjectModel.Settings.Upgrade.SolutionSettingsUpgraderAttribute()]
    public class RazorUsingsSettingsUpgrade : JetBrains.ReSharper.Psi.Naming.Settings.Upgrade.CodeStyleSettingsUpgrade
    {
        public RazorUsingsSettingsUpgrade(JetBrains.Application.Parts.IPartsCatalogueSet partsSet, JetBrains.ProjectModel.ISolution solution = null) { }
        protected override void DoUpgrade(JetBrains.ReSharper.Psi.CodeStyle.SettingsUpgrade.CodeStyleSettingsObsolete codeStyleSettings, JetBrains.Application.Settings.IContextBoundSettingsStore contextBoundSettingsStore) { }
    }
}
namespace JetBrains.ReSharper.Psi.Razor.DeclaredElements
{
    
    public interface IRazorDeclaredElement : JetBrains.ReSharper.Psi.IDeclaredElement { }
    public interface IRazorSectionDeclaredElement : JetBrains.ReSharper.Psi.IDeclaredElement, JetBrains.ReSharper.Psi.Razor.DeclaredElements.IRazorDeclaredElement
    {
        JetBrains.DocumentModel.DocumentRange DocumentRange { get; }
        JetBrains.ReSharper.Psi.IPsiSourceFile GetSourceFile();
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Razor.DeclaredElements.IRazorSectionDeclaredElement SetName(string newName);
    }
}
namespace JetBrains.ReSharper.Psi.Razor.Generate
{
    
    public interface IRazorCodeGenerator
    {
        JetBrains.ReSharper.Psi.PsiLanguageType Language { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Web.Generation.GenerationResults Generate([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Razor.Tree.IRazorFile file);
        string MakeSafeName(string name);
    }
    public abstract class RazorCodeGenerator : JetBrains.ReSharper.Psi.Razor.Generate.IRazorCodeGenerator, JetBrains.ReSharper.Psi.Razor.Impl.Generate.IRazorCodeGeneratorInternal
    {
        public const string DEFAULT_NAMESPACE = "ASP";
        public const string DEFINE_SECTION_METHOD_TO_NAME = "DefineSection";
        public static readonly JetBrains.ReSharper.Psi.IClrTypeName HELPER_RESULT;
        public const string INCLUDE_FILE_NAME = "_PageStart.cshtml";
        public const string MVC_INCLUDE_FILE_NAME = "_ViewStart.cshtml";
        public const string TEMPLATED_DELEGATE_ITEM_PARAMETER = "item";
        public const string WRITE_LITERAL_METHOD_NAME = "W‌riteLiteral";
        public const string WRITE_LITERAL_TO_METHOD_NAME = "W‌riteLiteralTo";
        public const string WRITE_METHOD_NAME = "W‌rite";
        public const string WRITE_METHOD_TO_NAME = "W‌riteTo";
        protected RazorCodeGenerator(JetBrains.Application.IApplicationDescriptor applicationDescriptor) { }
        public JetBrains.Application.IApplicationDescriptor ApplicationDescriptor { get; }
        public abstract string BlockEnd { get; }
        public abstract string BlockStart { get; }
        public abstract string ClassTemplateEnd { get; }
        public abstract string ClassTemplateStart { get; }
        public abstract string CommentEnd { get; }
        public abstract string CommentStart { get; }
        public JetBrains.ReSharper.Psi.Impl.Shared.MappedRangeType DefaultRazorRangeType { get; }
        public abstract string ExecuteEnd { get; }
        public abstract string ExecuteStart { get; }
        public abstract string FileHeader { get; }
        public abstract string FileTemplateEnd { get; }
        public abstract string FileTemplateStart { get; }
        public abstract string FunctionsEnd { get; }
        public abstract string FunctionsStart { get; }
        public abstract string HelperDelegateParameterName { get; }
        public abstract string HelperLambdaEnd { get; }
        public abstract string HelperLambdaStart { get; }
        public abstract string HelperStart { get; }
        public JetBrains.ReSharper.Psi.Impl.Shared.MappedRangeType HtmlRangeType { get; }
        public abstract string IgnoreEolComment { get; }
        public JetBrains.ReSharper.Psi.Impl.Shared.MappedRangeType ImplicitExpressionRangeType { get; }
        public abstract string ImportNamespaceEnd { get; }
        public abstract JetBrains.ReSharper.Psi.PsiLanguageType Language { get; }
        public JetBrains.ReSharper.Psi.Impl.Shared.MappedRangeType NamespaceImportRangeType { get; }
        public abstract string SectionEnd { get; }
        public abstract string SectionStart { get; }
        public abstract string StatementEnd { get; }
        public abstract string StatementEndComment { get; }
        public abstract string StatementStart { get; }
        public abstract string StatementStartComment { get; }
        public JetBrains.ReSharper.Psi.Impl.Shared.MappedRangeType StatementWithKeywordRangeType { get; }
        public abstract string StaticExecuteStart { get; }
        public abstract string StaticHelperStart { get; }
        public abstract string TemplatedDelegateEnd { get; }
        public abstract string TemplatedDelegateStart { get; }
        public abstract string TemplateDelegateParameterName { get; }
        public abstract string TypedParameterPrefix { get; }
        public abstract string TypedParameterSuffix { get; }
        public abstract string WriteEnd { get; }
        public abstract string WriteHtmlEnd { get; }
        public abstract string WriteHtmlStart { get; }
        public abstract string WriteStart { get; }
        public abstract void EscapeCommentText(JetBrains.ReSharper.Psi.Tree.ITreeNode node, JetBrains.ReSharper.Psi.Web.Generation.GenerationResults context);
        public abstract void EscapeHtmlText(JetBrains.ReSharper.Psi.Tree.ITreeNode node, JetBrains.ReSharper.Psi.Web.Generation.GenerationResults context, JetBrains.ReSharper.Psi.Razor.Impl.Generate.RazorCodeGeneratorProcessor processor);
        public JetBrains.ReSharper.Psi.Web.Generation.GenerationResults Generate(JetBrains.ReSharper.Psi.Razor.Tree.IRazorFile file) { }
        public string GetClassName(JetBrains.ProjectModel.IProjectFile projectFile) { }
        public string GetNamespace(JetBrains.ProjectModel.IProjectFile projectFile) { }
        public abstract string GetPageBaseType(JetBrains.ReSharper.Psi.Web.Cache.WebConfigData webConfigData);
        public bool IsHelperPage(JetBrains.ProjectModel.IProjectFile projectFile) { }
        public abstract string MakeSafeName(string name);
    }
}
namespace JetBrains.ReSharper.Psi.Razor.Impl.CodeStyle
{
    
    public class InsideMixedFormatterCookie { }
    public class MixedRangeFormatter
    {
        public MixedRangeFormatter(JetBrains.ReSharper.Psi.Tree.IFile originalFile, JetBrains.ReSharper.Psi.Tree.IFile generatedFile, JetBrains.ReSharper.Psi.Tree.ITreeNode firstElement, JetBrains.ReSharper.Psi.Tree.ITreeNode lastElement, JetBrains.ReSharper.Psi.CodeStyle.CodeFormatProfile profile, JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
        public void Format() { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.Razor.RazorLanguage))]
    public class RazorCodeFormatter : JetBrains.ReSharper.Psi.Html.Impl.CodeStyle.HtmlCodeFormatter
    {
        public RazorCodeFormatter(JetBrains.ReSharper.Psi.Razor.RazorLanguage language, JetBrains.ReSharper.Psi.Html.Parsing.IHtmlTokenNodeTypes tokenNodeTypes, JetBrains.Application.Settings.ISettingsStore settingsStore, JetBrains.Application.Settings.ISettingsOptimization settingsOptimization) { }
        protected override void DoIndent(JetBrains.ReSharper.Psi.Impl.CodeStyle.CodeFormattingContext context, JetBrains.ReSharper.Psi.Html.CodeStyle.HtmlCodeFormattingSettings settings, JetBrains.ReSharper.Psi.CodeStyle.CodeFormatProfile profile, JetBrains.Application.Progress.IProgressIndicator progress) { }
        protected override void RunFormatterForGeneratedLanguage(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, JetBrains.ReSharper.Psi.PsiLanguageType language, JetBrains.DocumentModel.DocumentRange range, JetBrains.ReSharper.Psi.CodeStyle.CodeFormatProfile profile, JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
        public override bool TryCustomFormat(JetBrains.ReSharper.Psi.Tree.ITreeNode firstElement, JetBrains.ReSharper.Psi.Tree.ITreeNode lastElement, JetBrains.ReSharper.Psi.CodeStyle.CodeFormatProfile profile, JetBrains.Application.Progress.IProgressIndicator progressIndicator = null) { }
    }
    public class RazorIndentingVisitor : JetBrains.ReSharper.Psi.Razor.Tree.RazorTreeVisitor<JetBrains.ReSharper.Psi.Impl.CodeStyle.FormattingStageContext, string>
    {
        public RazorIndentingVisitor(JetBrains.ReSharper.Psi.Html.Impl.CodeStyle.HtmlIndentingVisitor baseVisitor) { }
        public JetBrains.ReSharper.Psi.Html.Impl.CodeStyle.HtmlIndentingVisitor BaseVisitor { get; }
        public string GetIndentForPairedWrapper(JetBrains.ReSharper.Psi.Razor.Tree.IRazorTreeNode node, JetBrains.ReSharper.Psi.Impl.CodeStyle.FormattingStageContext context) { }
        public override string VisitRazorBlockMarkup(JetBrains.ReSharper.Psi.Razor.Tree.IRazorBlockMarkup node, JetBrains.ReSharper.Psi.Impl.CodeStyle.FormattingStageContext context) { }
        public override string VisitRazorFunctionsBlock(JetBrains.ReSharper.Psi.Razor.Tree.IRazorFunctionsBlock node, JetBrains.ReSharper.Psi.Impl.CodeStyle.FormattingStageContext context) { }
        public override string VisitRazorSection(JetBrains.ReSharper.Psi.Razor.Tree.IRazorSection node, JetBrains.ReSharper.Psi.Impl.CodeStyle.FormattingStageContext context) { }
    }
}
namespace JetBrains.ReSharper.Psi.Razor.Impl.CustomHandlers
{
    
    public interface IRazorPsiServices
    {
        System.Collections.Generic.HashSet<string> ServiceComments { get; }
        JetBrains.ReSharper.Psi.Tree.ITreeNode AddIgnoreEolCommentMarker([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode node, bool checkIfExists = True);
        void BreakHtmlRangesIfNeeded([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Razor.Tree.IRazorFile file, JetBrains.ReSharper.Psi.TreeOffset offset);
        bool CanBeHelper(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration);
        void DeleteIgnoreEolCommentMarker([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode node);
        void DetachServiceCommentMarker(JetBrains.ReSharper.Psi.Tree.IStatement statement);
        void DetachServiceCommentMarkerAfterDeclarations(JetBrains.ReSharper.Psi.Tree.ITreeNode statement);
        JetBrains.ReSharper.Psi.Tree.ITreeNode GetCodeBehindStatementFromOriginalTreeTextRange([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Razor.Tree.IRazorFile file, JetBrains.ReSharper.Psi.TreeTextRange range, bool atStart);
        JetBrains.ReSharper.Psi.Razor.Tree.IRazorCodeBlock GetCodeBlockByServiceEndComment(JetBrains.ReSharper.Psi.Tree.ITreeNode node);
        string GetDelegateParameterName(JetBrains.ReSharper.Psi.Tree.ITreeNode razorNode);
        JetBrains.ReSharper.Psi.Razor.Tree.IRazorFunctionsBlock GetFunctionsBlockByServiceEndComment(JetBrains.ReSharper.Psi.Tree.ITreeNode node);
        JetBrains.ReSharper.Psi.TreeTextRange<JetBrains.ReSharper.Psi.Generated> GetGeneratedTreeRange(JetBrains.ReSharper.Psi.TreeTextRange<JetBrains.ReSharper.Psi.Original> originalTreeRange, JetBrains.ReSharper.Psi.Impl.Shared.RangeTranslatorWithGeneratedRangeMap rangeTranslator);
        JetBrains.Util.Pair<JetBrains.ReSharper.Psi.Tree.ITreeNode, bool> GetHelperBySystemStatement(JetBrains.ReSharper.Psi.Tree.ITreeNode node);
        JetBrains.Util.JetTuple<string, JetBrains.ReSharper.Psi.ITreeRange> GetHelperInfo(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration);
        string GetHtmlWriteLiteralStart(string parameter);
        string GetHtmlWriteStart(string parameter);
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Tree.ITreeNode GetNextWhitespaceNode([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode lastRazorNode);
        JetBrains.ReSharper.Psi.Tree.ITreeNode GetOriginalAnchor(JetBrains.ReSharper.Psi.Tree.ITreeNode codeBehindStatement, bool first, JetBrains.ReSharper.Psi.Tree.ITreeNode stopAt = null);
        JetBrains.Util.Pair<JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Razor.Impl.CustomHandlers.OriginalStatementType> GetOriginalAnchorAndType([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode codeBehindStatement, bool first, JetBrains.ReSharper.Psi.Tree.ITreeNode stopAt = null, System.Predicate<JetBrains.Util.Pair<JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Razor.Impl.CustomHandlers.OriginalStatementType>> checker = null);
        JetBrains.Util.Pair<JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Razor.Impl.CustomHandlers.OriginalStatementType> GetOriginalNodeAndType([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode codeBehindStatement, bool first);
        JetBrains.Util.Pair<JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.Util.OperationResultType> GetOriginalNodeForTypeMember([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode typeMember, bool first);
        JetBrains.Util.Pair<JetBrains.ReSharper.Psi.ITreeRange, JetBrains.Util.OperationResultType> GetOriginalNodesForCode([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode generatedCode, bool checkForCode = True);
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Tree.ITreeNode GetPrevWhitespaceNode([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode firstRazorNode);
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Tree.IComment GetServiceCommentAfter(JetBrains.ReSharper.Psi.Tree.ITreeNode statement);
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Resolve.Managed.IManagedExpression GetWriteArgumentValue(JetBrains.ReSharper.Psi.Resolve.Managed.IManagedExpression expression, JetBrains.ReSharper.Psi.Razor.Impl.CustomHandlers.RazorMethodType methodType);
        bool IsEmptyWriteLiteral(JetBrains.ReSharper.Psi.Tree.ITreeNode codeBehindStatement);
        bool IsHelper(JetBrains.ReSharper.Psi.IMethod element);
        bool IsMethodWithRazorMarkup([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Tree.IDeclaration declaration);
        bool IsServiceCode(JetBrains.ReSharper.Psi.Tree.ITreeNode codeBehindStatement);
        bool IsSpecialMethodInvocation([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Tree.IExpression expression, params JetBrains.ReSharper.Psi.Razor.Impl.CustomHandlers.RazorMethodType[] methodTypes);
        bool IsSpecialMethodInvocation([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Tree.IStatement statement, params JetBrains.ReSharper.Psi.Razor.Impl.CustomHandlers.RazorMethodType[] methodTypes);
        bool IsSpecialStatementDelimeter(JetBrains.ReSharper.Psi.Tree.ITreeNode node);
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Tree.ITreeNode> SplitCodebehindNode([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode codeBehindStatement);
        JetBrains.ReSharper.Psi.Tree.ITreeNode UnwrapAtBoth(JetBrains.ReSharper.Psi.Tree.ITreeNode nodeToUnwrap, JetBrains.ReSharper.Psi.Tree.ITreeNode stopAtParent = null);
        JetBrains.ReSharper.Psi.Tree.ITreeNode UnwrapAtEnd(JetBrains.ReSharper.Psi.Tree.ITreeNode nodeToUnwrap, JetBrains.ReSharper.Psi.Tree.ITreeNode stopAtParent = null);
        JetBrains.ReSharper.Psi.Tree.ITreeNode UnwrapAtEndSafely(JetBrains.ReSharper.Psi.Tree.ITreeNode nodeToUnwrap, System.Func<JetBrains.ReSharper.Psi.Tree.ITreeNode, bool> stopAt = null);
        JetBrains.ReSharper.Psi.Tree.ITreeNode UnwrapAtStart(JetBrains.ReSharper.Psi.Tree.ITreeNode nodeToUnwrap, JetBrains.ReSharper.Psi.Tree.ITreeNode stopAtParent = null);
        JetBrains.ReSharper.Psi.Tree.ITreeNode UnwrapAtStartSafely(JetBrains.ReSharper.Psi.Tree.ITreeNode nodeToUnwrap, System.Func<JetBrains.ReSharper.Psi.Tree.ITreeNode, bool> stopAt = null);
    }
    public enum OriginalStatementType
    {
        CodeStatementInsideBlock = 0,
        HtmlMarkup = 1,
        EscapedCodeStatement = 2,
        Section = 3,
        UnmappedServiceCode = 4,
        Other = 5,
        Whitespace = 6,
        HelperOrSystemStatement = 7,
        UnknownOrError = 8,
    }
    public abstract class RazorCustomModificationHandler : JetBrains.ReSharper.Psi.Web.CodeBehindSupport.CustomModificationHandler<JetBrains.ReSharper.Psi.Razor.Tree.IRazorExecuteCode, JetBrains.ReSharper.Psi.Razor.Tree.IRazorNamespaceImport>
    {
        protected RazorCustomModificationHandler(JetBrains.ReSharper.Psi.ILanguageManager languageManager, JetBrains.ReSharper.Psi.Razor.Impl.IRazorRegenerator decompiler, JetBrains.ReSharper.Psi.Razor.Impl.CustomHandlers.IRazorPsiServices razorPsiServices, JetBrains.ProjectModel.ProjectFileType projectFileType, JetBrains.ReSharper.Psi.IProjectFileLanguageService projectFileLanguageService) { }
        public JetBrains.ReSharper.Psi.Razor.Impl.CustomHandlers.IRazorPsiServices RazorPsiServices { get; }
        public JetBrains.ReSharper.Psi.Razor.Impl.IRazorRegenerator Regenerator { get; }
        protected override void AddSuperClassDirectiveToOriginalFile(JetBrains.ReSharper.Psi.Tree.IFile originalFile, JetBrains.ReSharper.Psi.Tree.ITreeNode anchor, JetBrains.ReSharper.Psi.Tree.ITreeNode superClassGeneratedNode) { }
        public bool CanUseAliases() { }
        public abstract JetBrains.ReSharper.Psi.Tree.ITreeNode CreateCodebehindMarker(JetBrains.ReSharper.Psi.Modules.IPsiModule module);
        public abstract System.IDisposable CreateDisableCodeFormatter();
        protected override JetBrains.ReSharper.Psi.Razor.Tree.IRazorExecuteCode CreateInlineCodeBlock(string text, JetBrains.ReSharper.Psi.Tree.ITreeNode anchor) { }
        protected override JetBrains.ReSharper.Psi.TreeTextRange CreateTypeMemberNode(JetBrains.ReSharper.Psi.Tree.IFile originalFile, string text, JetBrains.ReSharper.Psi.Tree.ITreeNode first, JetBrains.ReSharper.Psi.Tree.ITreeNode last) { }
        protected override JetBrains.ReSharper.Psi.TreeTextRange CreateUsingNode(bool before, JetBrains.ReSharper.Psi.Razor.Tree.IRazorNamespaceImport anchor, JetBrains.ReSharper.Psi.Tree.ITreeNode usingDirective, JetBrains.ReSharper.Psi.Tree.IFile originalFile) { }
        public override JetBrains.ReSharper.Psi.Tree.ITreeNode FixupAnchorForAddingTypeMember(JetBrains.ReSharper.Psi.IPsiServices psiServices, JetBrains.ReSharper.Psi.Tree.IFile generatedFile, JetBrains.ReSharper.Psi.Tree.ITreeNode anchor, bool willInsertBefore, JetBrains.ReSharper.Psi.Tree.ITreeNode classDeclaration) { }
        protected override JetBrains.ReSharper.Psi.TreeTextRange GetCodeTreeTextRange(JetBrains.ReSharper.Psi.Razor.Tree.IRazorExecuteCode codeBlock) { }
        protected JetBrains.ReSharper.Psi.TreeTextRange GetCodeTreeTextRange2(JetBrains.ReSharper.Psi.Razor.Tree.IRazorCode codeBlock) { }
        protected override JetBrains.ReSharper.Psi.TreeTextRange GetExistingTypeMembersRange(JetBrains.ReSharper.Psi.Tree.IFile originalFile) { }
        public JetBrains.ReSharper.Psi.Razor.Parsing.RazorElementFactory GetRazorElementFactory(JetBrains.ReSharper.Psi.Tree.ITreeNode node) { }
        public JetBrains.ReSharper.Psi.LanguageService GetRazorLanguageService(JetBrains.ReSharper.Psi.Tree.ITreeNode node) { }
        public JetBrains.ReSharper.Psi.PsiLanguageType GetRazorLanguageType(JetBrains.ReSharper.Psi.Tree.ITreeNode node) { }
        protected override JetBrains.ReSharper.Psi.Tree.ITreeNode GetSuperClassNodeFromOriginalFile(JetBrains.ReSharper.Psi.Tree.IFile originalFile) { }
        protected abstract string GetUsingDirectiveInsideText(JetBrains.ReSharper.Psi.Tree.ITreeNode usingDirective);
        protected override JetBrains.ReSharper.Psi.Tree.ITreeNode HandleAddTypeMember(JetBrains.ReSharper.Psi.IPsiServices psiServices, JetBrains.ReSharper.Psi.Tree.ITreeNode addedNode) { }
        public virtual void HandleRemoveTypeMember(JetBrains.ReSharper.Psi.IPsiServices psiServices, JetBrains.ReSharper.Psi.Tree.ITreeNode node, System.Action action) { }
        protected override void RemoveUsingNode(JetBrains.ReSharper.Psi.Tree.IFile originalFile, JetBrains.ReSharper.Psi.Razor.Tree.IRazorNamespaceImport directiveInOriginalFile) { }
    }
    public class RazorMethodType : JetBrains.Util.EnumPattern
    {
        public static readonly JetBrains.ReSharper.Psi.Razor.Impl.CustomHandlers.RazorMethodType DefineSection;
        public static readonly JetBrains.ReSharper.Psi.Razor.Impl.CustomHandlers.RazorMethodType None;
        public static readonly JetBrains.ReSharper.Psi.Razor.Impl.CustomHandlers.RazorMethodType[] SpecialMethods;
        public static readonly JetBrains.ReSharper.Psi.Razor.Impl.CustomHandlers.RazorMethodType Write;
        public static readonly JetBrains.ReSharper.Psi.Razor.Impl.CustomHandlers.RazorMethodType WriteLiteral;
        public static readonly JetBrains.ReSharper.Psi.IClrTypeName WriteParameterAttributeName;
        public System.Collections.Generic.HashSet<string> GeneratedNames { get; }
        public System.Collections.Generic.IDictionary<string, int> ParameterPosition { get; }
    }
    public abstract class RazorPsiServicesBase : JetBrains.ReSharper.Psi.Razor.Impl.CustomHandlers.IRazorPsiServices
    {
        protected RazorPsiServicesBase(JetBrains.ReSharper.Psi.Razor.Generate.RazorCodeGenerator generator) { }
        protected JetBrains.ReSharper.Psi.Razor.Generate.RazorCodeGenerator Generator { get; }
        public System.Collections.Generic.HashSet<string> ServiceComments { get; }
        public System.Collections.Generic.HashSet<string> ServiceEndComments { get; }
        public abstract JetBrains.ReSharper.Psi.Tree.ITreeNode AddIgnoreEolCommentMarker(JetBrains.ReSharper.Psi.Tree.ITreeNode node, bool checkIfExists = True);
        public abstract void BreakHtmlRangesIfNeeded(JetBrains.ReSharper.Psi.Razor.Tree.IRazorFile file, JetBrains.ReSharper.Psi.TreeOffset offset);
        public virtual bool CanBeHelper(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration) { }
        public abstract JetBrains.ReSharper.Psi.Tree.ICommentNode CreateCommentToIgnoreEol(JetBrains.ReSharper.Psi.Tree.ITreeNode codeBehindContext);
        public abstract void DeleteIgnoreEolCommentMarker(JetBrains.ReSharper.Psi.Tree.ITreeNode node);
        public abstract void DetachServiceCommentMarker(JetBrains.ReSharper.Psi.Tree.IStatement statement);
        public abstract void DetachServiceCommentMarkerAfterDeclarations(JetBrains.ReSharper.Psi.Tree.ITreeNode statement);
        public abstract JetBrains.ReSharper.Psi.Tree.ITreeNode GetCodeBehindStatementByGeneratedRange(JetBrains.ReSharper.Psi.Tree.IFile codeBehindFile, JetBrains.ReSharper.Psi.TreeTextRange generatedRange, bool first);
        public JetBrains.ReSharper.Psi.Tree.ITreeNode GetCodeBehindStatementFromOriginalTreeTextRange(JetBrains.ReSharper.Psi.Razor.Tree.IRazorFile file, JetBrains.ReSharper.Psi.TreeTextRange range, bool atStart) { }
        public JetBrains.ReSharper.Psi.Razor.Tree.IRazorCodeBlock GetCodeBlockByServiceEndComment(JetBrains.ReSharper.Psi.Tree.ITreeNode node) { }
        public abstract string GetDelegateParameterName(JetBrains.ReSharper.Psi.Tree.ITreeNode razorNode);
        public abstract System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Tree.ITreeNode> GetElementsFromCodebehindNode(JetBrains.ReSharper.Psi.Tree.ITreeNode codeBehindStatement);
        public JetBrains.ReSharper.Psi.Razor.Tree.IRazorFunctionsBlock GetFunctionsBlockByServiceEndComment(JetBrains.ReSharper.Psi.Tree.ITreeNode node) { }
        public JetBrains.ReSharper.Psi.TreeTextRange<JetBrains.ReSharper.Psi.Generated> GetGeneratedTreeRange(JetBrains.ReSharper.Psi.TreeTextRange<JetBrains.ReSharper.Psi.Original> originalTreeRange, JetBrains.ReSharper.Psi.Impl.Shared.RangeTranslatorWithGeneratedRangeMap rangeTranslator) { }
        public abstract JetBrains.Util.Pair<JetBrains.ReSharper.Psi.Tree.ITreeNode, bool> GetHelperBySystemStatement(JetBrains.ReSharper.Psi.Tree.ITreeNode node);
        public abstract JetBrains.Util.JetTuple<string, JetBrains.ReSharper.Psi.ITreeRange> GetHelperInfo(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration);
        public abstract string GetHtmlWriteLiteralStart(string parameter);
        public abstract string GetHtmlWriteStart(string parameter);
        public JetBrains.ReSharper.Psi.Tree.ITreeNode GetNextWhitespaceNode(JetBrains.ReSharper.Psi.Tree.ITreeNode lastRazorNode) { }
        public JetBrains.ReSharper.Psi.Tree.ITreeNode GetOriginalAnchor(JetBrains.ReSharper.Psi.Tree.ITreeNode codeBehindStatement, bool first, JetBrains.ReSharper.Psi.Tree.ITreeNode stopAt = null) { }
        public JetBrains.Util.Pair<JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Razor.Impl.CustomHandlers.OriginalStatementType> GetOriginalAnchorAndType(JetBrains.ReSharper.Psi.Tree.ITreeNode codeBehindStatement, bool first, JetBrains.ReSharper.Psi.Tree.ITreeNode stopAt, System.Predicate<JetBrains.Util.Pair<JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Razor.Impl.CustomHandlers.OriginalStatementType>> checker) { }
        public abstract JetBrains.Util.Pair<JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Razor.Impl.CustomHandlers.OriginalStatementType> GetOriginalNodeAndType(JetBrains.ReSharper.Psi.Tree.ITreeNode codeBehindStatement, bool first);
        public JetBrains.Util.Pair<JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Razor.Impl.CustomHandlers.OriginalStatementType> GetOriginalNodeAndType(JetBrains.ReSharper.Psi.Tree.IStatement codeBehindStatement, bool first, JetBrains.ReSharper.Psi.TreeTextRange<JetBrains.ReSharper.Psi.Generated> generatedTreeRange) { }
        protected abstract JetBrains.Util.Pair<JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Razor.Impl.CustomHandlers.OriginalStatementType> GetOriginalNodeAndTypeWithChecker(JetBrains.ReSharper.Psi.Tree.ITreeNode codeBehindStatement, bool first, System.Predicate<JetBrains.Util.Pair<JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Razor.Impl.CustomHandlers.OriginalStatementType>> checker);
        public JetBrains.Util.Pair<JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.Util.OperationResultType> GetOriginalNodeForTypeMember(JetBrains.ReSharper.Psi.Tree.ITreeNode typeMember, bool first) { }
        public JetBrains.Util.Pair<JetBrains.ReSharper.Psi.ITreeRange, JetBrains.Util.OperationResultType> GetOriginalNodesForCode(JetBrains.ReSharper.Psi.Tree.ITreeNode generatedCode, bool checkForCode = True) { }
        public JetBrains.ReSharper.Psi.Tree.ITreeNode GetPrevWhitespaceNode(JetBrains.ReSharper.Psi.Tree.ITreeNode firstRazorNode) { }
        public abstract JetBrains.ReSharper.Psi.Tree.IComment GetServiceCommentAfter(JetBrains.ReSharper.Psi.Tree.ITreeNode statement);
        protected JetBrains.ReSharper.Psi.Html.Tree.IHtmlToken GetTokenAtEndOffset(JetBrains.ReSharper.Psi.Impl.Shared.RangeTranslatorWithGeneratedRangeMap rangeTranslator, JetBrains.ReSharper.Psi.TreeOffset offset, int maxLength, bool checkForCodeToken, bool breakup = True) { }
        protected JetBrains.ReSharper.Psi.Html.Tree.IHtmlToken GetTokenAtStartOffset(JetBrains.ReSharper.Psi.Impl.Shared.RangeTranslatorWithGeneratedRangeMap rangeTranslator, JetBrains.ReSharper.Psi.TreeOffset offset, int maxLength, bool checkForCodeToken, bool breakup = True) { }
        public abstract JetBrains.ReSharper.Psi.Resolve.Managed.IManagedExpression GetWriteArgumentValue(JetBrains.ReSharper.Psi.Resolve.Managed.IManagedExpression expression, JetBrains.ReSharper.Psi.Razor.Impl.CustomHandlers.RazorMethodType methodType);
        public abstract bool IsEmptyWriteLiteral(JetBrains.ReSharper.Psi.Tree.ITreeNode codeBehindStatement);
        public bool IsHelper(JetBrains.ReSharper.Psi.IMethod method) { }
        public abstract bool IsMethodWithRazorMarkup(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration);
        public virtual bool IsServiceCode(JetBrains.ReSharper.Psi.Tree.ITreeNode codeBehindStatement) { }
        public abstract bool IsSpecialMethodInvocation(JetBrains.ReSharper.Psi.Tree.IExpression expression, params JetBrains.ReSharper.Psi.Razor.Impl.CustomHandlers.RazorMethodType[] methodTypes);
        public abstract bool IsSpecialMethodInvocation(JetBrains.ReSharper.Psi.Tree.IStatement statement, params JetBrains.ReSharper.Psi.Razor.Impl.CustomHandlers.RazorMethodType[] methodTypes);
        public abstract bool IsSpecialStatementDelimeter(JetBrains.ReSharper.Psi.Tree.ITreeNode node);
        protected abstract bool IsSystemStatement(JetBrains.ReSharper.Psi.Tree.IStatement codeBehindStatement);
        public abstract System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Tree.ITreeNode> SplitCodebehindNode(JetBrains.ReSharper.Psi.Tree.ITreeNode codeBehindStatement);
        public JetBrains.ReSharper.Psi.Tree.ITreeNode UnwrapAtBoth(JetBrains.ReSharper.Psi.Tree.ITreeNode nodeToUnwrap, JetBrains.ReSharper.Psi.Tree.ITreeNode stopAtParent = null) { }
        public JetBrains.ReSharper.Psi.Tree.ITreeNode UnwrapAtBothSafely(JetBrains.ReSharper.Psi.Tree.ITreeNode nodeToUnwrap, System.Func<JetBrains.ReSharper.Psi.Tree.ITreeNode, bool> stopAt, bool unwrapOnlySimpleConstructs) { }
        public JetBrains.ReSharper.Psi.Tree.ITreeNode UnwrapAtEnd(JetBrains.ReSharper.Psi.Tree.ITreeNode nodeToUnwrap, JetBrains.ReSharper.Psi.Tree.ITreeNode stopAtParent = null) { }
        public JetBrains.ReSharper.Psi.Tree.ITreeNode UnwrapAtEndSafely(JetBrains.ReSharper.Psi.Tree.ITreeNode nodeToUnwrap, System.Func<JetBrains.ReSharper.Psi.Tree.ITreeNode, bool> stopAt = null) { }
        public JetBrains.ReSharper.Psi.Tree.ITreeNode UnwrapAtStart(JetBrains.ReSharper.Psi.Tree.ITreeNode nodeToUnwrap, JetBrains.ReSharper.Psi.Tree.ITreeNode stopAtParent = null) { }
        public JetBrains.ReSharper.Psi.Tree.ITreeNode UnwrapAtStartSafely(JetBrains.ReSharper.Psi.Tree.ITreeNode nodeToUnwrap, System.Func<JetBrains.ReSharper.Psi.Tree.ITreeNode, bool> stopAt = null) { }
    }
}
namespace JetBrains.ReSharper.Psi.Razor.Impl.DeclaredElements
{
    
    public class RazorDeclaredElementType : JetBrains.ReSharper.Psi.DeclaredElementTypeBase
    {
        public static readonly JetBrains.ReSharper.Psi.Razor.Impl.DeclaredElements.RazorDeclaredElementType RazorSectionDeclaredElementType;
        protected override JetBrains.ReSharper.Psi.IDeclaredElementPresenter DefaultPresenter { get; }
        protected override JetBrains.UI.Icons.IconId GetImage() { }
    }
}
namespace JetBrains.ReSharper.Psi.Razor.Impl.Generate
{
    
    public interface IRazorCodeGeneratorInternal : JetBrains.ReSharper.Psi.Razor.Generate.IRazorCodeGenerator
    {
        JetBrains.Application.IApplicationDescriptor ApplicationDescriptor { get; }
        string BlockEnd { get; }
        string BlockStart { get; }
        string ClassTemplateEnd { get; }
        string ClassTemplateStart { get; }
        string CommentEnd { get; }
        string CommentStart { get; }
        JetBrains.ReSharper.Psi.Impl.Shared.MappedRangeType DefaultRazorRangeType { get; }
        string ExecuteEnd { get; }
        string ExecuteStart { get; }
        string FileHeader { get; }
        string FileTemplateEnd { get; }
        string FileTemplateStart { get; }
        string FunctionsEnd { get; }
        string FunctionsStart { get; }
        string HelperDelegateParameterName { get; }
        string HelperLambdaEnd { get; }
        string HelperLambdaStart { get; }
        string HelperStart { get; }
        JetBrains.ReSharper.Psi.Impl.Shared.MappedRangeType HtmlRangeType { get; }
        string IgnoreEolComment { get; }
        JetBrains.ReSharper.Psi.Impl.Shared.MappedRangeType ImplicitExpressionRangeType { get; }
        string ImportNamespaceEnd { get; }
        JetBrains.ReSharper.Psi.Impl.Shared.MappedRangeType NamespaceImportRangeType { get; }
        string SectionEnd { get; }
        string SectionStart { get; }
        string StatementEnd { get; }
        string StatementEndComment { get; }
        string StatementStart { get; }
        string StatementStartComment { get; }
        JetBrains.ReSharper.Psi.Impl.Shared.MappedRangeType StatementWithKeywordRangeType { get; }
        string StaticExecuteStart { get; }
        string StaticHelperStart { get; }
        string TemplatedDelegateEnd { get; }
        string TemplatedDelegateStart { get; }
        string TemplateDelegateParameterName { get; }
        string TypedParameterPrefix { get; }
        string TypedParameterSuffix { get; }
        string WriteEnd { get; }
        string WriteHtmlEnd { get; }
        string WriteHtmlStart { get; }
        string WriteStart { get; }
        void EscapeCommentText(JetBrains.ReSharper.Psi.Tree.ITreeNode node, JetBrains.ReSharper.Psi.Web.Generation.GenerationResults context);
        void EscapeHtmlText(JetBrains.ReSharper.Psi.Tree.ITreeNode node, JetBrains.ReSharper.Psi.Web.Generation.GenerationResults context, JetBrains.ReSharper.Psi.Razor.Impl.Generate.RazorCodeGeneratorProcessor processor);
        string GetClassName([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IProjectFile projectFile);
        string GetNamespace([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IProjectFile projectFile);
        string GetPageBaseType([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Web.Cache.WebConfigData webConfigData);
        bool IsHelperPage([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IProjectFile projectFile);
    }
    public class RazorCodeGeneratorProcessor : JetBrains.ReSharper.Psi.IRecursiveElementProcessor<JetBrains.ReSharper.Psi.Web.Generation.GenerationResults>
    {
        public RazorCodeGeneratorProcessor(JetBrains.ReSharper.Psi.Razor.Impl.Generate.IRazorCodeGeneratorInternal codeGenerator, JetBrains.ReSharper.Psi.Razor.Parsing.IRazorTokenNodeTypes tokenTypes) { }
        public JetBrains.ReSharper.Psi.Razor.Parsing.IRazorTokenNodeTypes RazorTokenNodeTypes { get; }
        public void CheckForInterrupt() { }
        public object[] GetWriteParameters(string directWriteMethodName, string delegatedWritemethodName) { }
        public bool InteriorShouldBeProcessed(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.Web.Generation.GenerationResults context) { }
        public bool IsProcessingFinished(JetBrains.ReSharper.Psi.Web.Generation.GenerationResults context) { }
        public void ProcessAfterInterior(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.Web.Generation.GenerationResults context) { }
        public void ProcessBeforeInterior(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.Web.Generation.GenerationResults context) { }
    }
}
namespace JetBrains.ReSharper.Psi.Razor.Impl
{
    
    public interface IRazorRegenerator
    {
        JetBrains.ReSharper.Psi.ITreeRange GenerateAndInsertRazorStatements(JetBrains.ReSharper.Psi.Tree.ITreeNode parent, JetBrains.ReSharper.Psi.Tree.ITreeNode anchor, JetBrains.ReSharper.Psi.ITreeRange codeBehindStatements, bool before, JetBrains.ReSharper.Psi.ITreeRange rangeToTrack = null);
        JetBrains.Util.Pair<JetBrains.ReSharper.Psi.Razor.Tree.IRazorHelper, JetBrains.ReSharper.Psi.Impl.Shared.IGeneratedRangeMap> GenerateRazorHelper(JetBrains.ReSharper.Psi.Razor.Tree.IRazorFile parent, JetBrains.ReSharper.Psi.Tree.IDeclaration codeBehindMethod);
    }
    public abstract class RazorCodeBehindGeneratedDocumentService : JetBrains.ReSharper.Psi.Web.Generation.GeneratedDocumentServiceBase
    {
        protected readonly JetBrains.ReSharper.Psi.Razor.Impl.Generate.IRazorCodeGeneratorInternal RazorCodeGenerator;
        protected RazorCodeBehindGeneratedDocumentService([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Razor.Impl.Generate.IRazorCodeGeneratorInternal razorCodeGenerator, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.ExtensionsAPI.FileDependency fileDependency) { }
        public override JetBrains.ReSharper.Psi.ExtensionsAPI.ISecondaryLexingProcess CreateSecondaryLexingService(JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Psi.Parsing.MixedLexer mixedLexer, JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile = null) { }
        public override JetBrains.ReSharper.Psi.ExtensionsAPI.ISecondaryDocumentGenerationResult Generate(JetBrains.ReSharper.Psi.Files.PrimaryFileModificationInfo modificationInfo) { }
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.PsiLanguageType> GetSecondaryPsiLanguageTypes(JetBrains.ProjectModel.IProject project) { }
        public override bool IsSecondaryPsiLanguageType(JetBrains.ProjectModel.IProject project, JetBrains.ReSharper.Psi.PsiLanguageType language) { }
        public override JetBrains.ReSharper.Psi.Parsing.ILexerFactory LexerFactoryWithPreprocessor(JetBrains.ReSharper.Psi.PsiLanguageType primaryLanguage) { }
        protected override bool ReparseOriginalFile(JetBrains.ReSharper.Psi.TreeTextRange treeTextRange, string newText, JetBrains.ReSharper.Psi.Impl.Shared.RangeTranslatorWithGeneratedRangeMap rangeTranslator) { }
    }
    [JetBrains.ReSharper.Psi.PsiIconManagerExtensionAttribute()]
    public class RazorCSharpHelperImageProvider : JetBrains.ReSharper.Psi.IPsiIconManagerExtension
    {
        public RazorCSharpHelperImageProvider(JetBrains.ProjectModel.FileTypes.IProjectFileTypeServices projectFileTypeServices, JetBrains.Application.Settings.ISettingsStore settingsStore) { }
        public JetBrains.UI.Icons.IconId GetImageId(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, JetBrains.ReSharper.Psi.PsiLanguageType languageType, out bool canApplyExtensions) { }
    }
    public class RazorPsiProjectFileProperties : JetBrains.ReSharper.Psi.Impl.DefaultPsiProjectFileProperties
    {
        public RazorPsiProjectFileProperties(JetBrains.ProjectModel.IProjectFile projectFile, JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
        public override bool ProvidesCodeModel { get; }
        public override System.Collections.Generic.IEnumerable<string> GetPreImportedNamespaces() { }
    }
    public class RazorSecondaryLexingProcess : JetBrains.ReSharper.Psi.ExtensionsAPI.ISecondaryLexingProcess
    {
        public RazorSecondaryLexingProcess(JetBrains.ReSharper.Psi.Parsing.MixedLexer mixedLexer, JetBrains.ReSharper.Psi.PsiLanguageType codeBehindLanguage) { }
        public bool CanHandle(JetBrains.ProjectModel.ProjectFileType projectFileType) { }
        public JetBrains.ReSharper.Psi.Parsing.ILexer TryCreateCodeBehindLexer(JetBrains.ReSharper.Psi.Parsing.ILexer baseLexer) { }
    }
}
namespace JetBrains.ReSharper.Psi.Razor.Impl.Parsing
{
    
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.Razor.RazorLanguage))]
    public sealed class RazorTokenNodeTypes : JetBrains.ReSharper.Psi.Html.Impl.Parsing.HtmlTokenNodeTypes, JetBrains.ReSharper.Psi.Html.Parsing.IHtmlCompoundTokenNodeTypes, JetBrains.ReSharper.Psi.Html.Parsing.IHtmlTokenNodeTypes, JetBrains.ReSharper.Psi.Razor.Parsing.IRazorTokenNodeTypes
    {
        public RazorTokenNodeTypes(JetBrains.ReSharper.Psi.Razor.RazorLanguage lang) { }
        public JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet CodeNodeTypesSet { get; }
        public JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet ExtendedCodeNodeTypesSet { get; }
        public JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet LeftBracketTypesSet { get; }
        public JetBrains.ReSharper.Psi.Parsing.TokenNodeType RAW_HTML { get; }
        public JetBrains.ReSharper.Psi.Parsing.TokenNodeType RAZOR_BLOCK_MARKUP_END { get; }
        public JetBrains.ReSharper.Psi.Parsing.TokenNodeType RAZOR_BLOCK_MARKUP_START { get; }
        public JetBrains.ReSharper.Psi.Parsing.TokenNodeType RAZOR_CODE { get; }
        public JetBrains.ReSharper.Psi.Parsing.TokenNodeType RAZOR_CODE_CLOSED_BRACKET { get; }
        public JetBrains.ReSharper.Psi.Parsing.TokenNodeType RAZOR_CODE_OPENED_BRACKET { get; }
        public JetBrains.ReSharper.Psi.Parsing.TokenNodeType RAZOR_COMMENT_BODY { get; }
        public JetBrains.ReSharper.Psi.Parsing.TokenNodeType RAZOR_COMMENT_END { get; }
        public JetBrains.ReSharper.Psi.Parsing.TokenNodeType RAZOR_COMMENT_START { get; }
        public JetBrains.ReSharper.Psi.Parsing.TokenNodeType RAZOR_ERROR_BODY_EXPECTED { get; }
        public JetBrains.ReSharper.Psi.Parsing.TokenNodeType RAZOR_ERROR_CONDITION_EXPECTED { get; }
        public JetBrains.ReSharper.Psi.Parsing.TokenNodeType RAZOR_ERROR_IDENTIFIER_EXPECTED { get; }
        public JetBrains.ReSharper.Psi.Parsing.TokenNodeType RAZOR_IDENTIFIER { get; }
        public JetBrains.ReSharper.Psi.Parsing.TokenNodeType RAZOR_IMPLICIT_CODE { get; }
        public JetBrains.ReSharper.Psi.Parsing.TokenNodeType RAZOR_KEYWORD { get; }
        public JetBrains.ReSharper.Psi.Parsing.TokenNodeType RAZOR_LINE_MARKUP_END { get; }
        public JetBrains.ReSharper.Psi.Parsing.TokenNodeType RAZOR_NAMESPACE_CODE { get; }
        public JetBrains.ReSharper.Psi.Parsing.TokenNodeType RAZOR_SECTION_CLOSED_BRACKET { get; }
        public JetBrains.ReSharper.Psi.Parsing.TokenNodeType RAZOR_SECTION_OPENED_BRACKET { get; }
        public JetBrains.ReSharper.Psi.Parsing.TokenNodeType RAZOR_SPACE { get; }
        public JetBrains.ReSharper.Psi.Html.Parsing.HtmlTokenNodeType<JetBrains.ReSharper.Psi.Razor.Parsing.IRazorTokenNodeTypes> RAZOR_STUB_CODE { get; }
        public JetBrains.ReSharper.Psi.Parsing.TokenNodeType RAZOR_TEMPLATE_END { get; }
        public JetBrains.ReSharper.Psi.Parsing.TokenNodeType RAZOR_TEMPLATE_START { get; }
        public JetBrains.ReSharper.Psi.Parsing.TokenNodeType RAZOR_TRANSITION { get; }
        public JetBrains.ReSharper.Psi.Parsing.TokenNodeType RAZOR_TRANSITION_CODE { get; }
        public JetBrains.ReSharper.Psi.Parsing.TokenNodeType RAZOR_WRAPPER_CLOSED_BRACKET { get; }
        public JetBrains.ReSharper.Psi.Parsing.TokenNodeType RAZOR_WRAPPER_CODE { get; }
        public JetBrains.ReSharper.Psi.Parsing.TokenNodeType RAZOR_WRAPPER_IMPLICIT_CODE { get; }
        public JetBrains.ReSharper.Psi.Parsing.TokenNodeType RAZOR_WRAPPER_OPENED_BRACKET { get; }
        public JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet RightBracketTypesSet { get; }
        public override short GetChildRole(JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.TreeElement child) { }
        public override bool IsNonHtmlToken(JetBrains.ReSharper.Psi.Parsing.TokenNodeType tokenNodeType) { }
    }
}
namespace JetBrains.ReSharper.Psi.Razor.Impl.PsiModules.WebApp.Helpers
{
    
    [JetBrains.ReSharper.Psi.Web.Impl.PsiModules.WebApp.WebAppPsiModuleHandlerHelperFactoryAttribute()]
    public class WebAppRazorFileHelperFactory : JetBrains.ReSharper.Psi.Web.Impl.PsiModules.IWebPsiModuleHandlerHelperFactory, JetBrains.ReSharper.Psi.Web.Impl.PsiModules.WebApp.IWebAppPsiModuleHandlerHelperFactory
    {
        public WebAppRazorFileHelperFactory(JetBrains.ReSharper.Psi.PsiSourceFilePropertiesManager psiSourceFilePropertiesManager, JetBrains.ReSharper.Psi.PsiProjectFileTypeCoordinator psiProjectFileTypeCoordinator, JetBrains.ReSharper.Psi.PsiSourceFilePropertiesManager propertiesManager) { }
        public JetBrains.ReSharper.Psi.Web.Impl.PsiModules.IWebPsiModuleHandlerHelper CreateHelper(JetBrains.DataFlow.Lifetime helperLifetime, JetBrains.ReSharper.Psi.Web.Impl.PsiModules.IWebProjectPsiModuleHandler handler, JetBrains.ReSharper.Psi.Web.Cache.IWebConfigCache webConfigCache, JetBrains.ReSharper.Psi.Web.PsiModules.IAspFileDataCache aspFileDataCache) { }
    }
}
namespace JetBrains.ReSharper.Psi.Razor.Impl.PsiModules.Website.Helpers
{
    
    [JetBrains.ReSharper.Psi.Web.Impl.PsiModules.Website.WebsitePsiModuleHandlerHelperFactoryAttribute()]
    public class WebsiteRazorFileHelperFactory : JetBrains.ReSharper.Psi.Web.Impl.PsiModules.IWebPsiModuleHandlerHelperFactory, JetBrains.ReSharper.Psi.Web.Impl.PsiModules.Website.IWebsitePsiModuleHandlerHelperFactory
    {
        public WebsiteRazorFileHelperFactory(JetBrains.ReSharper.Psi.PsiSourceFilePropertiesManager psiSourceFilePropertiesManager, JetBrains.ReSharper.Psi.PsiProjectFileTypeCoordinator psiProjectFileTypeCoordinator, JetBrains.ReSharper.Psi.PsiSourceFilePropertiesManager propertiesManager) { }
        public JetBrains.ReSharper.Psi.Web.Impl.PsiModules.IWebPsiModuleHandlerHelper CreateHelper(JetBrains.DataFlow.Lifetime helperLifetime, JetBrains.ReSharper.Psi.Web.Impl.PsiModules.IWebProjectPsiModuleHandler handler, JetBrains.ReSharper.Psi.Web.Cache.IWebConfigCache webConfigCache, JetBrains.ReSharper.Psi.Web.PsiModules.IAspFileDataCache aspFileDataCache) { }
    }
}
namespace JetBrains.ReSharper.Psi.Razor.Impl.PsiModules.Website.Modules
{
    
    public class WebsiteRazorFolderModule : JetBrains.ReSharper.Psi.Modules.ProjectPsiModuleBase, JetBrains.ReSharper.Psi.Modules.IProjectPsiModule, JetBrains.ReSharper.Psi.Modules.IPsiModule, JetBrains.ReSharper.Psi.Web.Impl.PsiModules.Website.Modules.IWebsitePsiModule, JetBrains.ReSharper.Psi.Web.Impl.WebConfig.PsiModules.Website.Modules.IWebConfigReferenceConsumerModule
    {
        public WebsiteRazorFolderModule([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Web.Impl.PsiModules.IWebProjectPsiModuleHandler handler, JetBrains.Util.FileSystemPath folderPath, JetBrains.ReSharper.Psi.PsiProjectFileTypeCoordinator psiProjectFileTypeCoordinator) { }
        public JetBrains.Util.FileSystemPath FolderPath { get; }
        public JetBrains.ProjectModel.IProjectItem MainProjectItem { get; }
        public override System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.PreProcessingDirective> GetAllDefines() { }
        protected override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Modules.IPsiModuleReference> GetReferencesInternal() { }
    }
}
namespace JetBrains.ReSharper.Psi.Razor.Impl.PsiModules.Website.Properties
{
    
    [JetBrains.ProjectModel.ProjectFileTypeAttribute(typeof(JetBrains.ProjectModel.RazorProjectFileType))]
    public class WebsiteRazorAppCodeFileProperties : JetBrains.ReSharper.Psi.Web.Impl.PsiModules.Website.Properties.IWebsiteAppCodePsiSourceFilePropertiesFactory
    {
        public WebsiteRazorAppCodeFileProperties(JetBrains.ReSharper.Psi.IProjectFileLanguageService projectFileLanguageService) { }
        public JetBrains.ReSharper.Psi.IPsiSourceFileProperties CreateProperties(JetBrains.ProjectModel.IProjectFile projectFile, JetBrains.ReSharper.Psi.IPsiSourceFile psiSourceFile, JetBrains.ReSharper.Psi.PsiSourceFilePropertiesManager propertiesManager, JetBrains.ReSharper.Psi.Web.Cache.IWebConfigCache webConfigCache) { }
    }
    public class WebsiteRazorFileProperties : JetBrains.ReSharper.Psi.Web.Impl.PsiModules.Website.Properties.WebsitePsiSourceFileProperties
    {
        public WebsiteRazorFileProperties(JetBrains.ProjectModel.IProjectFile projectFile, JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, JetBrains.ReSharper.Psi.PsiSourceFilePropertiesManager propertiesManager) { }
        public override string GetDefaultNamespace() { }
        public override System.Collections.Generic.IEnumerable<string> GetPreImportedNamespaces() { }
    }
}
namespace JetBrains.ReSharper.Psi.Razor.Impl.PsiModules.Website.ReferenceProviders
{
    
    [JetBrains.ReSharper.Psi.Web.Impl.PsiModules.WebApp.WebAppCommonReferenceProviderFactoryAttribute()]
    public class WebAppRazorReferenceProviderFactory : JetBrains.ReSharper.Psi.Web.Impl.PsiModules.IWebCommonReferenceProviderFactory, JetBrains.ReSharper.Psi.Web.Impl.PsiModules.WebApp.IWebAppCommonReferenceProviderFactory
    {
        public WebAppRazorReferenceProviderFactory(JetBrains.ReSharper.Psi.Web.PsiModules.IWebAssemblyReferenceFactory assemblyReferenceFactory, JetBrains.Application.IShellLocks locks) { }
        public JetBrains.ReSharper.Psi.Web.Impl.PsiModules.IWebCommonReferenceProvider CreateReferenceProvider(JetBrains.DataFlow.Lifetime helperLifetime, JetBrains.ReSharper.Psi.Web.Impl.PsiModules.IWebProjectPsiModuleHandler handler, JetBrains.ReSharper.Psi.Web.PsiModules.IAspFileDataCache aspFileDataCache) { }
    }
    [JetBrains.ReSharper.Psi.Web.Impl.PsiModules.Website.WebsiteCommonReferenceProviderFactoryAttribute()]
    public class WebsiteRazorReferenceProviderFactory : JetBrains.ReSharper.Psi.Web.Impl.PsiModules.IWebCommonReferenceProviderFactory, JetBrains.ReSharper.Psi.Web.Impl.PsiModules.Website.IWebsiteCommonReferenceProviderFactory
    {
        public WebsiteRazorReferenceProviderFactory(JetBrains.ReSharper.Psi.Web.PsiModules.IWebAssemblyReferenceFactory assemblyReferenceFactory, JetBrains.Application.IShellLocks locks) { }
        public JetBrains.ReSharper.Psi.Web.Impl.PsiModules.IWebCommonReferenceProvider CreateReferenceProvider(JetBrains.DataFlow.Lifetime helperLifetime, JetBrains.ReSharper.Psi.Web.Impl.PsiModules.IWebProjectPsiModuleHandler handler, JetBrains.ReSharper.Psi.Web.PsiModules.IAspFileDataCache aspFileDataCache) { }
    }
}
namespace JetBrains.ReSharper.Psi.Razor.Impl.PsiModules.Website
{
    
    [JetBrains.ProjectModel.ProjectFileTypeAttribute(typeof(JetBrains.ProjectModel.RazorProjectFileType))]
    public class WebRazorProjectFileClassifier : JetBrains.ReSharper.Psi.Web.PsiModules.IWebProjectFileClassifier
    {
        public bool CanBeAppCodeFile(JetBrains.ProjectModel.IProjectFile projectFile) { }
        public bool CanBeAspFile(JetBrains.ProjectModel.IProjectFile projectFile) { }
        public bool CanBeCodeBehindFile(JetBrains.ProjectModel.IProjectFile projectFile) { }
    }
}
namespace JetBrains.ReSharper.Psi.Razor.Impl.References
{
    
    public class DynamicSymbolTable : JetBrains.ReSharper.Psi.Resolve.ISymbolTable
    {
        public static readonly JetBrains.ReSharper.Psi.Resolve.ISymbolTable INSTANCE;
        public void ForAllSymbolInfos(System.Action<JetBrains.ReSharper.Psi.Resolve.ISymbolInfo> processor) { }
        public JetBrains.ReSharper.Psi.Dependencies.ISymbolTableDependencySet GetDependencySet() { }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Resolve.ISymbolInfo> GetSymbolInfos(string name) { }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Resolve.ISymbolInfo> GetSymbolInfosConstitutingResolveResult(string name, out JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IResolveInfo resolveInfo) { }
        public System.Collections.Generic.IEnumerable<string> Names() { }
    }
    public abstract class RazorCodeBehindReferenceProvider<TAssigmentEpression, TLiteralExpression> : JetBrains.ReSharper.Psi.Resolve.IReferenceFactory
        where TAssigmentEpression :  class, JetBrains.ReSharper.Psi.Tree.ITreeNode
        where TLiteralExpression :  class, JetBrains.ReSharper.Psi.Tree.ILiteralExpression
    {
        protected RazorCodeBehindReferenceProvider(JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Psi.Razor.IRazorServices razorServices, System.Func<TAssigmentEpression, JetBrains.Util.Pair<JetBrains.ReSharper.Psi.Tree.IExpression, JetBrains.ReSharper.Psi.Tree.IExpression>> assigmentChecker) { }
        public JetBrains.ReSharper.Psi.Resolve.IReference[] GetReferences(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.Resolve.IReference[] oldReferences) { }
        public virtual bool HasReference(JetBrains.ReSharper.Psi.Tree.ITreeNode element, System.Collections.Generic.ICollection<string> names) { }
        protected abstract bool IsAppropriateNode(JetBrains.ReSharper.Psi.Tree.ITreeNode element);
    }
    public sealed class RazorFileLateBoundReference<TOwner, TToken> : JetBrains.ReSharper.Psi.Html.Impl.References.HtmlFileLateBoundReference<TOwner, TToken>, JetBrains.ReSharper.Psi.Razor.References.IRazorReference, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.Util.IUserDataHolder
        where TOwner : JetBrains.ReSharper.Psi.Tree.ITreeNode
        where TToken :  class, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        public RazorFileLateBoundReference(TOwner owner, JetBrains.ReSharper.Psi.Resolve.IQualifier qualifier, TToken token, JetBrains.ReSharper.Psi.TreeTextRange rangeWithin) { }
        public override bool IsWebRootPathSupported() { }
    }
    public class RazorFileReference<TToken> : JetBrains.ReSharper.Psi.Html.Impl.References.HtmlFileReference<JetBrains.ReSharper.Psi.Tree.IExpression, TToken>, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IQualifiableReferenceBase, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IQualifiableReferenceWithGlobalSymbolTable, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IReferenceWithGlobalSymbolTable, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IReferenceWithQualifier, JetBrains.ReSharper.Psi.Razor.References.IRazorFileReference, JetBrains.ReSharper.Psi.Razor.References.IRazorReference, JetBrains.ReSharper.Psi.Resolve.ICompleteableReference, JetBrains.ReSharper.Psi.Resolve.IFileReference, JetBrains.ReSharper.Psi.Resolve.IPathReference, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.Util.IUserDataHolder
        where TToken :  class, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        public RazorFileReference(JetBrains.ReSharper.Psi.Tree.IExpression owner, JetBrains.ReSharper.Psi.Resolve.IQualifier qualifier, TToken token, JetBrains.ReSharper.Psi.TreeTextRange rangeWithin, JetBrains.ProjectModel.ProjectFileType expectedFileType, bool noCircular, bool allowEmptyName = False) { }
        public override string GetName() { }
        public override JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetReferenceSymbolTable(bool useReferenceName) { }
        public override JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.ResolveResultWithInfo GetResolveResult(JetBrains.ReSharper.Psi.Resolve.ISymbolTable symbolTable, string referenceName) { }
        public override bool IsValid() { }
    }
    public sealed class RazorFolderLateBoundReference<TOwner, TToken> : JetBrains.ReSharper.Psi.Html.Impl.References.HtmlFolderLateBoundReference<TOwner, TToken>, JetBrains.ReSharper.Psi.Razor.References.IRazorReference, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.Util.IUserDataHolder
        where TOwner : JetBrains.ReSharper.Psi.Tree.ITreeNode
        where TToken :  class, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        public RazorFolderLateBoundReference(TOwner owner, JetBrains.ReSharper.Psi.Resolve.IQualifier qualifier, TToken token, JetBrains.ReSharper.Psi.TreeTextRange rangeWithin) { }
        public override bool IsWebRootPathSupported() { }
    }
    public sealed class RazorFolderReference<TToken> : JetBrains.ReSharper.Psi.Html.Impl.References.HtmlFolderReference<JetBrains.ReSharper.Psi.Tree.IExpression, TToken>, JetBrains.ReSharper.Psi.Razor.References.IRazorReference, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.Util.IUserDataHolder
        where TToken :  class, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        public RazorFolderReference(JetBrains.ReSharper.Psi.Tree.IExpression owner, JetBrains.ReSharper.Psi.Resolve.IQualifier qualifier, TToken token, JetBrains.ReSharper.Psi.TreeTextRange rangeWithin) { }
        public override bool IsValid() { }
    }
    public sealed class RazorLayoutReference<TToken> : JetBrains.ReSharper.Psi.Razor.Impl.References.RazorFileReference<TToken>, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IQualifiableReferenceBase, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IQualifiableReferenceWithGlobalSymbolTable, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IReferenceWithGlobalSymbolTable, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IReferenceWithQualifier, JetBrains.ReSharper.Psi.Razor.References.IRazorFileReference, JetBrains.ReSharper.Psi.Razor.References.IRazorLayoutReference, JetBrains.ReSharper.Psi.Razor.References.IRazorReference, JetBrains.ReSharper.Psi.Resolve.ICompleteableReference, JetBrains.ReSharper.Psi.Resolve.IFileReference, JetBrains.ReSharper.Psi.Resolve.IPathReference, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.Util.IUserDataHolder
        where TToken :  class, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        public RazorLayoutReference(JetBrains.ReSharper.Psi.Tree.IExpression owner, JetBrains.ReSharper.Psi.Resolve.IQualifier qualifier, TToken token, JetBrains.ReSharper.Psi.TreeTextRange rangeWithin, JetBrains.ProjectModel.ProjectFileType expectedFileType, bool noCircular, bool allowEmptyName) { }
    }
    public class RazorReferenceProvider<TAssigmentEpression> : JetBrains.ReSharper.Psi.Resolve.IReferenceFactory
        where TAssigmentEpression :  class, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        public RazorReferenceProvider(JetBrains.ReSharper.Psi.Razor.IRazorServices razorServices, System.Func<TAssigmentEpression, JetBrains.Util.Pair<JetBrains.ReSharper.Psi.Tree.IExpression, JetBrains.ReSharper.Psi.Tree.IExpression>> assigmentChecker) { }
        public JetBrains.ReSharper.Psi.Resolve.IReference[] GetReferences(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.Resolve.IReference[] oldReferences) { }
        public bool HasReference(JetBrains.ReSharper.Psi.Tree.ITreeNode element, System.Collections.Generic.ICollection<string> names) { }
    }
    public class RazorResolveErrorType : JetBrains.ReSharper.Psi.Resolve.ResolveErrorType
    {
        public static readonly JetBrains.ReSharper.Psi.Razor.Impl.References.RazorResolveErrorType RAZOR_SECTION_NOT_RESOLVED;
    }
    public class RazorSectionDeclarationReference<TLiteralExpression> : JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.TreeReferenceBase<JetBrains.ReSharper.Psi.Tree.IExpression>, JetBrains.ReSharper.Psi.Razor.References.IRazorReference, JetBrains.ReSharper.Psi.Razor.References.IRazorSectionDeclarationReference, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.Util.IUserDataHolder
        where TLiteralExpression :  class, JetBrains.ReSharper.Psi.Tree.ILiteralExpression
    {
        public RazorSectionDeclarationReference([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.IExpression owner) { }
        public override JetBrains.ReSharper.Psi.Resolve.IReference BindTo(JetBrains.ReSharper.Psi.IDeclaredElement element) { }
        public override JetBrains.ReSharper.Psi.Resolve.IReference BindTo(JetBrains.ReSharper.Psi.IDeclaredElement element, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution) { }
        public JetBrains.ReSharper.Psi.Razor.References.IRazorSectionDeclarationReference BindTo(string name) { }
        public override JetBrains.ReSharper.Psi.Resolve.IAccessContext GetAccessContext() { }
        public override string GetName() { }
        public override JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetReferenceSymbolTable(bool useReferenceName) { }
        public override JetBrains.ReSharper.Psi.TreeTextRange GetTreeTextRange() { }
        public override JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.ResolveResultWithInfo ResolveWithoutCache() { }
    }
    public class RazorSectionReference<TAssigmentEpression> : JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.TreeReferenceBase<JetBrains.ReSharper.Psi.Razor.Tree.IRazorSection>, JetBrains.ReSharper.Psi.Html.References.IHtmlCompleteableReference, JetBrains.ReSharper.Psi.Razor.References.IRazorReference, JetBrains.ReSharper.Psi.Razor.References.IRazorSectionReference, JetBrains.ReSharper.Psi.Resolve.ICompleteableReference, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.Util.IUserDataHolder
        where TAssigmentEpression :  class, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        public RazorSectionReference([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Razor.Tree.IRazorSection owner, JetBrains.ReSharper.Psi.Razor.IRazorServices razorServices, System.Func<TAssigmentEpression, JetBrains.Util.Pair<JetBrains.ReSharper.Psi.Tree.IExpression, JetBrains.ReSharper.Psi.Tree.IExpression>> assigmentChecker) { }
        public override JetBrains.ReSharper.Psi.Resolve.IReference BindTo(JetBrains.ReSharper.Psi.IDeclaredElement element) { }
        public override JetBrains.ReSharper.Psi.Resolve.IReference BindTo(JetBrains.ReSharper.Psi.IDeclaredElement element, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution) { }
        public override JetBrains.ReSharper.Psi.Resolve.IAccessContext GetAccessContext() { }
        public JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetCompletionSymbolTable() { }
        public override string GetName() { }
        public override JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetReferenceSymbolTable(bool useReferenceName) { }
        public override JetBrains.ReSharper.Psi.TreeTextRange GetTreeTextRange() { }
        public override JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.ResolveResultWithInfo ResolveWithoutCache() { }
    }
    [JetBrains.ReSharper.Psi.Resolve.ReferenceProviderFactoryAttribute()]
    public class RazorUrlAttributeValueReferenceProvider : JetBrains.ReSharper.Psi.Html.Impl.References.HtmlAttributeValueReferenceFactoryBase<JetBrains.ReSharper.Psi.Html.Html.IHtmlDeclaredElementTypes, JetBrains.ProjectModel.RazorProjectFileType>, JetBrains.ReSharper.Psi.Html.Impl.References.IHtmlUrlReferenceProviderOverride
    {
        public RazorUrlAttributeValueReferenceProvider(JetBrains.ReSharper.Psi.Html.Html.IHtmlDeclaredElementTypes htmlDeclaredElementTypes) { }
        protected override bool CanHaveReference(JetBrains.ReSharper.Psi.Html.Impl.References.HtmlAttributeValueEntry entry, System.Collections.Generic.IEnumerable<string> names) { }
        protected override JetBrains.ReSharper.Psi.Resolve.IReference[] CreateReferences(JetBrains.ReSharper.Psi.Html.Impl.References.HtmlAttributeValueEntry entry) { }
        public override bool IsApplicable(JetBrains.ReSharper.Psi.Html.Impl.References.HtmlAttributeValueEntry entry) { }
        public override bool IsApplicableToFile(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, JetBrains.ReSharper.Psi.Tree.IFile file) { }
    }
}
namespace JetBrains.ReSharper.Psi.Razor.Impl.Searching
{
    
    public class RazorReferenceSearcher : JetBrains.ReSharper.Psi.ExtensionsAPI.IDomainSpecificSearcher
    {
        public RazorReferenceSearcher(System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.IDeclaredElement> elements, bool findCandidates) { }
        public bool ProcessElement<TResult>(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.Search.IFindResultConsumer<TResult> consumer) { }
        public bool ProcessProjectItem<TResult>(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, JetBrains.ReSharper.Psi.Search.IFindResultConsumer<TResult> consumer) { }
    }
    [JetBrains.ReSharper.Psi.PsiSharedComponentAttribute()]
    public class RazorSearchFactory : JetBrains.ReSharper.Psi.ExtensionsAPI.IDomainSpecificSearcherFactory
    {
        public RazorSearchFactory(JetBrains.ReSharper.Psi.Search.SearchDomainFactory searchDomainFactory) { }
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
namespace JetBrains.ReSharper.Psi.Razor.Impl.Tree.Mvc
{
    
    public sealed class RazorModelDirective : JetBrains.ReSharper.Psi.Razor.Impl.Tree.RazorCode, JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.ICompositeElement, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode, JetBrains.ReSharper.Psi.Razor.Mvc.Tree.IRazorModelDirective, JetBrains.ReSharper.Psi.Razor.Tree.IRazorBaseTypeDirective, JetBrains.ReSharper.Psi.Razor.Tree.IRazorCode, JetBrains.ReSharper.Psi.Razor.Tree.IRazorCompositeElement, JetBrains.ReSharper.Psi.Razor.Tree.IRazorTreeNode, JetBrains.ReSharper.Psi.Razor.Tree.IRazorWrapper, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebCodeBlock, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode
    {
        public RazorModelDirective([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType nodeType, JetBrains.ReSharper.Psi.Razor.Parsing.IRazorTokenNodeTypes tokenTypes) { }
        public override JetBrains.ReSharper.Psi.ITreeRange ContentRange { get; }
        public override TReturn AcceptVisitor<TContext, TReturn>(JetBrains.ReSharper.Psi.Html.Tree.HtmlTreeVisitor<TContext, TReturn> visitor, TContext context) { }
    }
    public class RazorMvcFile : JetBrains.ReSharper.Psi.Razor.Impl.Tree.RazorFile, JetBrains.ReSharper.Psi.Html.Tree.IHtmlFile, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTagContainer, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTagContainerMarker, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode, JetBrains.ReSharper.Psi.Razor.Mvc.Tree.IRazorMvcFile, JetBrains.ReSharper.Psi.Razor.Tree.IRazorFile, JetBrains.ReSharper.Psi.Tree.IFile, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebFile, JetBrains.ReSharper.Psi.Web.Tree.IWebFileWithCodeBehind, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode
    {
        public RazorMvcFile(JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType nodeType, JetBrains.ReSharper.Psi.Razor.Parsing.IRazorTokenNodeTypes tokenTypes) { }
    }
}
namespace JetBrains.ReSharper.Psi.Razor.Impl.Tree
{
    
    public class RazorBlockMarkup : JetBrains.ReSharper.Psi.Razor.Impl.Tree.RazorCompositeElement, JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.ICompositeElement, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTagContainerMarker, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode, JetBrains.ReSharper.Psi.Razor.Tree.IRazorBlockMarkup, JetBrains.ReSharper.Psi.Razor.Tree.IRazorCompositeElement, JetBrains.ReSharper.Psi.Razor.Tree.IRazorHtmlMarkup, JetBrains.ReSharper.Psi.Razor.Tree.IRazorPairWrapper, JetBrains.ReSharper.Psi.Razor.Tree.IRazorTreeNode, JetBrains.ReSharper.Psi.Razor.Tree.IRazorWrapper, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode
    {
        public RazorBlockMarkup([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType nodeType, JetBrains.ReSharper.Psi.Razor.Parsing.IRazorTokenNodeTypes tokenTypes) { }
        public JetBrains.ReSharper.Psi.Razor.Tree.IRazorToken CloseBraceToken { get; }
        public JetBrains.ReSharper.Psi.ITreeRange ContentRange { get; }
        public JetBrains.ReSharper.Psi.Razor.Tree.IRazorToken OpenBraceToken { get; }
        public override TReturn AcceptVisitor<TContext, TReturn>(JetBrains.ReSharper.Psi.Html.Tree.HtmlTreeVisitor<TContext, TReturn> visitor, TContext context) { }
    }
    public sealed class RazorChildRole : JetBrains.ReSharper.Psi.Html.Impl.Tree.HtmlChildRole
    {
        public const short ERROR = 171;
        public const short RAZOR_CODE = 166;
        public const short RAZOR_COMMENT = 169;
        public const short RAZOR_IDENTIFIER = 167;
        public const short RAZOR_KEYWORD = 165;
        public const short RAZOR_PAIR_CLOSE_WRAPPER = 173;
        public const short RAZOR_PAIR_OPEN_WRAPPER = 172;
        public const short RAZOR_SPACE = 170;
        public const short RAZOR_TRANSITION = 164;
        public const short RAZOR_WRAPPER = 168;
    }
    public abstract class RazorCode : JetBrains.ReSharper.Psi.Razor.Impl.Tree.RazorCompositeElement, JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.ICompositeElement, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode, JetBrains.ReSharper.Psi.Razor.Tree.IRazorCode, JetBrains.ReSharper.Psi.Razor.Tree.IRazorCompositeElement, JetBrains.ReSharper.Psi.Razor.Tree.IRazorTreeNode, JetBrains.ReSharper.Psi.Razor.Tree.IRazorWrapper, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebCodeBlock, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode
    {
        protected RazorCode([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType nodeType, JetBrains.ReSharper.Psi.Razor.Parsing.IRazorTokenNodeTypes tokenTypes) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Tree.ITreeNode> CodeNodes { get; }
        public virtual JetBrains.ReSharper.Psi.ITreeRange ContentRange { get; }
        public virtual JetBrains.ReSharper.Psi.Razor.Tree.IRazorToken Keyword { get; }
    }
    public sealed class RazorCodeBlock : JetBrains.ReSharper.Psi.Razor.Impl.Tree.RazorStatement, JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.ICompositeElement, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTagContainerMarker, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode, JetBrains.ReSharper.Psi.Razor.Tree.IRazorCode, JetBrains.ReSharper.Psi.Razor.Tree.IRazorCodeBlock, JetBrains.ReSharper.Psi.Razor.Tree.IRazorCompositeElement, JetBrains.ReSharper.Psi.Razor.Tree.IRazorExecuteCode, JetBrains.ReSharper.Psi.Razor.Tree.IRazorStatement, JetBrains.ReSharper.Psi.Razor.Tree.IRazorTreeNode, JetBrains.ReSharper.Psi.Razor.Tree.IRazorWrapper, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebCodeBlock, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode
    {
        public RazorCodeBlock([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType nodeType, JetBrains.ReSharper.Psi.Razor.Parsing.IRazorTokenNodeTypes tokenTypes) { }
        public override JetBrains.ReSharper.Psi.Razor.Tree.IRazorToken Keyword { get; }
    }
    public abstract class RazorCodeContainer : JetBrains.ReSharper.Psi.Razor.Impl.Tree.RazorCode
    {
        protected RazorCodeContainer([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType nodeType, JetBrains.ReSharper.Psi.Razor.Parsing.IRazorTokenNodeTypes tokenTypes) { }
    }
    public class RazorCodeToken : JetBrains.ReSharper.Psi.Razor.Impl.Tree.RazorToken, JetBrains.ReSharper.Psi.Html.Tree.IHtmlToken, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode, JetBrains.ReSharper.Psi.Razor.Tree.IRazorCodeToken, JetBrains.ReSharper.Psi.Razor.Tree.IRazorToken, JetBrains.ReSharper.Psi.Razor.Tree.IRazorTreeNode, JetBrains.ReSharper.Psi.Tree.ITokenNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode { }
    public class RazorComment : JetBrains.ReSharper.Psi.Razor.Impl.Tree.RazorCompositeElement, JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.ICompositeElement, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode, JetBrains.ReSharper.Psi.Html.Tree.IWebComment, JetBrains.ReSharper.Psi.Razor.Tree.IRazorComment, JetBrains.ReSharper.Psi.Razor.Tree.IRazorCompositeElement, JetBrains.ReSharper.Psi.Razor.Tree.IRazorTreeNode, JetBrains.ReSharper.Psi.Tree.IComment, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode
    {
        public RazorComment([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType nodeType, JetBrains.ReSharper.Psi.Razor.Parsing.IRazorTokenNodeTypes tokenTypes) { }
        public string CommentText { get; }
        public override TReturn AcceptVisitor<TContext, TReturn>(JetBrains.ReSharper.Psi.Html.Tree.HtmlTreeVisitor<TContext, TReturn> visitor, TContext context) { }
        public JetBrains.ReSharper.Psi.TreeTextRange GetCommentRange() { }
    }
    public abstract class RazorCompositeElement : JetBrains.ReSharper.Psi.Html.Impl.Tree.HtmlCompositeElement, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode, JetBrains.ReSharper.Psi.Razor.Tree.IRazorTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode
    {
        protected RazorCompositeElement([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType nodeType, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Razor.Parsing.IRazorTokenNodeTypes tokenTypes) { }
        public JetBrains.ReSharper.Psi.Razor.Parsing.IRazorTokenNodeTypes TokenTypes { get; }
    }
    public class RazorEmptyDirective : JetBrains.ReSharper.Psi.Html.Impl.Tree.HtmlErrorElement, JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.ICompositeElement, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode, JetBrains.ReSharper.Psi.Razor.Tree.IRazorCode, JetBrains.ReSharper.Psi.Razor.Tree.IRazorCompositeElement, JetBrains.ReSharper.Psi.Razor.Tree.IRazorExecuteCode, JetBrains.ReSharper.Psi.Razor.Tree.IRazorImplicitExpression, JetBrains.ReSharper.Psi.Razor.Tree.IRazorTreeNode, JetBrains.ReSharper.Psi.Razor.Tree.IRazorWrapper, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebCodeBlock, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode
    {
        public const string ErrorDescriptionText = "\"@\" must be followed by a valid code block.";
        public RazorEmptyDirective([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType nodeType, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Razor.Parsing.IRazorTokenNodeTypes tokenTypes) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Tree.ITreeNode> CodeNodes { get; }
        public JetBrains.ReSharper.Psi.ITreeRange ContentRange { get; }
        public JetBrains.ReSharper.Psi.Razor.Tree.IRazorToken Keyword { get; }
        public JetBrains.ReSharper.Psi.Razor.Parsing.IRazorTokenNodeTypes TokenTypes { get; }
        public override short GetChildRole(JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.TreeElement child) { }
    }
    public class RazorFile : JetBrains.ReSharper.Psi.Html.Impl.Tree.HtmlFile, JetBrains.ReSharper.Psi.Html.Tree.IHtmlFile, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTagContainer, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTagContainerMarker, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode, JetBrains.ReSharper.Psi.Razor.Tree.IRazorFile, JetBrains.ReSharper.Psi.Tree.IFile, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebFile, JetBrains.ReSharper.Psi.Web.Tree.IWebFileWithCodeBehind, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode
    {
        public RazorFile(JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType nodeType, JetBrains.ReSharper.Psi.Razor.Parsing.IRazorTokenNodeTypes tokenTypes) { }
        public JetBrains.ReSharper.Psi.Razor.Tree.IRazorBaseTypeDirective BaseTypeDirective { get; }
        public System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.Razor.Tree.IRazorFunctionsBlock> FunctionsBlocks { get; }
        public System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.Razor.Tree.IRazorHelper> Helpers { get; }
        public System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.Razor.Tree.IRazorNamespaceImport> NamespaceImports { get; }
        protected override JetBrains.ReSharper.Psi.Html.Impl.Tree.HtmlFileData CreateData(JetBrains.ReSharper.Psi.Tree.IFile file) { }
        protected override JetBrains.ReSharper.Psi.Parsing.TokenNodeType GetReparsableNodeType(JetBrains.ReSharper.Psi.Tree.ITreeNode node) { }
        protected override JetBrains.ReSharper.Psi.Parsing.TokenNodeType GetReparsableNodeTypeByParent(JetBrains.ReSharper.Psi.Tree.ITreeNode node) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IDeclaredType> GetSuperTypes() { }
        public JetBrains.ReSharper.Psi.Tree.ITypeDeclaration GetTypeDeclaration() { }
    }
    public class RazorFileData : JetBrains.ReSharper.Psi.Html.Impl.Tree.HtmlFileData
    {
        public RazorFileData(JetBrains.ReSharper.Psi.Tree.ITreeNode node) { }
        public JetBrains.ReSharper.Psi.Razor.Tree.IRazorBaseTypeDirective BaseTypeDirective { get; }
        public System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.Razor.Tree.IRazorFunctionsBlock> FunctionsBlocks { get; }
        public System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.Razor.Tree.IRazorHelper> Helpers { get; }
        public System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.Razor.Tree.IRazorNamespaceImport> NamespaceImports { get; }
        protected override bool InteriorShouldBeProcessed(JetBrains.ReSharper.Psi.Tree.ITreeNode node) { }
        protected override bool ProcessNode(JetBrains.ReSharper.Psi.Tree.ITreeNode node) { }
        protected override void RemoveDeadElements() { }
        protected override void SortElements() { }
    }
    public sealed class RazorFunctionsBlock : JetBrains.ReSharper.Psi.Razor.Impl.Tree.RazorCodeContainer, JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.ICompositeElement, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode, JetBrains.ReSharper.Psi.Razor.Tree.IRazorCode, JetBrains.ReSharper.Psi.Razor.Tree.IRazorCompositeElement, JetBrains.ReSharper.Psi.Razor.Tree.IRazorFunctionsBlock, JetBrains.ReSharper.Psi.Razor.Tree.IRazorPairWrapper, JetBrains.ReSharper.Psi.Razor.Tree.IRazorTreeNode, JetBrains.ReSharper.Psi.Razor.Tree.IRazorWrapper, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebCodeBlock, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode
    {
        public RazorFunctionsBlock([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType nodeType, JetBrains.ReSharper.Psi.Razor.Parsing.IRazorTokenNodeTypes tokenTypes) { }
        public JetBrains.ReSharper.Psi.Razor.Tree.IRazorToken CloseBraceToken { get; }
        public JetBrains.ReSharper.Psi.Razor.Tree.IRazorToken OpenBraceToken { get; }
        public override TReturn AcceptVisitor<TContext, TReturn>(JetBrains.ReSharper.Psi.Html.Tree.HtmlTreeVisitor<TContext, TReturn> visitor, TContext context) { }
    }
    public sealed class RazorHelper : JetBrains.ReSharper.Psi.Razor.Impl.Tree.RazorCodeContainer, JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.ICompositeElement, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTagContainerMarker, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode, JetBrains.ReSharper.Psi.Razor.Tree.IRazorCode, JetBrains.ReSharper.Psi.Razor.Tree.IRazorCompositeElement, JetBrains.ReSharper.Psi.Razor.Tree.IRazorDelegate, JetBrains.ReSharper.Psi.Razor.Tree.IRazorHelper, JetBrains.ReSharper.Psi.Razor.Tree.IRazorTreeNode, JetBrains.ReSharper.Psi.Razor.Tree.IRazorWrapper, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebCodeBlock, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode
    {
        public RazorHelper([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType nodeType, JetBrains.ReSharper.Psi.Razor.Parsing.IRazorTokenNodeTypes tokenTypes) { }
        public override TReturn AcceptVisitor<TContext, TReturn>(JetBrains.ReSharper.Psi.Html.Tree.HtmlTreeVisitor<TContext, TReturn> visitor, TContext context) { }
    }
    public sealed class RazorImplicitExpression : JetBrains.ReSharper.Psi.Razor.Impl.Tree.RazorCode, JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.ICompositeElement, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode, JetBrains.ReSharper.Psi.Razor.Tree.IRazorCode, JetBrains.ReSharper.Psi.Razor.Tree.IRazorCompositeElement, JetBrains.ReSharper.Psi.Razor.Tree.IRazorExecuteCode, JetBrains.ReSharper.Psi.Razor.Tree.IRazorImplicitExpression, JetBrains.ReSharper.Psi.Razor.Tree.IRazorTreeNode, JetBrains.ReSharper.Psi.Razor.Tree.IRazorWrapper, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebCodeBlock, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode
    {
        public RazorImplicitExpression([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType nodeType, JetBrains.ReSharper.Psi.Razor.Parsing.IRazorTokenNodeTypes tokenTypes) { }
        public override TReturn AcceptVisitor<TContext, TReturn>(JetBrains.ReSharper.Psi.Html.Tree.HtmlTreeVisitor<TContext, TReturn> visitor, TContext context) { }
    }
    public class RazorInclude : JetBrains.ReSharper.Psi.Razor.Impl.Tree.RazorCompositeElement, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode, JetBrains.ReSharper.Psi.Razor.Tree.IRazorInclude, JetBrains.ReSharper.Psi.Razor.Tree.IRazorTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode
    {
        public RazorInclude([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType nodeType, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Razor.Parsing.IRazorTokenNodeTypes tokenTypes) { }
        public override TReturn AcceptVisitor<TContext, TReturn>(JetBrains.ReSharper.Psi.Html.Tree.HtmlTreeVisitor<TContext, TReturn> visitor, TContext context) { }
    }
    public sealed class RazorInheritsDirective : JetBrains.ReSharper.Psi.Razor.Impl.Tree.RazorCode, JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.ICompositeElement, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode, JetBrains.ReSharper.Psi.Razor.Tree.IRazorBaseTypeDirective, JetBrains.ReSharper.Psi.Razor.Tree.IRazorCode, JetBrains.ReSharper.Psi.Razor.Tree.IRazorCompositeElement, JetBrains.ReSharper.Psi.Razor.Tree.IRazorInheritsDirective, JetBrains.ReSharper.Psi.Razor.Tree.IRazorTreeNode, JetBrains.ReSharper.Psi.Razor.Tree.IRazorWrapper, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebCodeBlock, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode
    {
        public RazorInheritsDirective([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType nodeType, JetBrains.ReSharper.Psi.Razor.Parsing.IRazorTokenNodeTypes tokenTypes) { }
        public override JetBrains.ReSharper.Psi.ITreeRange ContentRange { get; }
        public override TReturn AcceptVisitor<TContext, TReturn>(JetBrains.ReSharper.Psi.Html.Tree.HtmlTreeVisitor<TContext, TReturn> visitor, TContext context) { }
    }
    public class RazorLineMarkup : JetBrains.ReSharper.Psi.Razor.Impl.Tree.RazorCompositeElement, JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.ICompositeElement, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTagContainerMarker, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode, JetBrains.ReSharper.Psi.Razor.Tree.IRazorCompositeElement, JetBrains.ReSharper.Psi.Razor.Tree.IRazorHtmlMarkup, JetBrains.ReSharper.Psi.Razor.Tree.IRazorLineMarkup, JetBrains.ReSharper.Psi.Razor.Tree.IRazorTreeNode, JetBrains.ReSharper.Psi.Razor.Tree.IRazorWrapper, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode
    {
        public RazorLineMarkup([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType nodeType, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Razor.Parsing.IRazorTokenNodeTypes tokenTypes) { }
        public JetBrains.ReSharper.Psi.ITreeRange ContentRange { get; }
        public override TReturn AcceptVisitor<TContext, TReturn>(JetBrains.ReSharper.Psi.Html.Tree.HtmlTreeVisitor<TContext, TReturn> visitor, TContext context) { }
    }
    public sealed class RazorNamespaceImport : JetBrains.ReSharper.Psi.Razor.Impl.Tree.RazorCode, JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.ICompositeElement, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode, JetBrains.ReSharper.Psi.Razor.Tree.IRazorCode, JetBrains.ReSharper.Psi.Razor.Tree.IRazorCompositeElement, JetBrains.ReSharper.Psi.Razor.Tree.IRazorNamespaceImport, JetBrains.ReSharper.Psi.Razor.Tree.IRazorTreeNode, JetBrains.ReSharper.Psi.Razor.Tree.IRazorWrapper, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebCodeBlock, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode
    {
        public RazorNamespaceImport([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType nodeType, JetBrains.ReSharper.Psi.Razor.Parsing.IRazorTokenNodeTypes tokenTypes) { }
        public override JetBrains.ReSharper.Psi.ITreeRange ContentRange { get; }
        public override TReturn AcceptVisitor<TContext, TReturn>(JetBrains.ReSharper.Psi.Html.Tree.HtmlTreeVisitor<TContext, TReturn> visitor, TContext context) { }
    }
    public class RazorReservedKeyword : JetBrains.ReSharper.Psi.Html.Impl.Tree.HtmlErrorElement, JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.ICompositeElement, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode, JetBrains.ReSharper.Psi.Razor.Tree.IRazorCompositeElement, JetBrains.ReSharper.Psi.Razor.Tree.IRazorTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode
    {
        public RazorReservedKeyword([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType nodeType, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Razor.Parsing.IRazorTokenNodeTypes tokenTypes) { }
        public override string ErrorDescription { get; set; }
        public override short GetChildRole(JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.TreeElement child) { }
    }
    public sealed class RazorSection : JetBrains.ReSharper.Psi.Razor.Impl.Tree.RazorCode, JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.ICompositeElement, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTagContainerMarker, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode, JetBrains.ReSharper.Psi.Razor.Tree.IRazorCode, JetBrains.ReSharper.Psi.Razor.Tree.IRazorCompositeElement, JetBrains.ReSharper.Psi.Razor.Tree.IRazorPairWrapper, JetBrains.ReSharper.Psi.Razor.Tree.IRazorSection, JetBrains.ReSharper.Psi.Razor.Tree.IRazorTreeNode, JetBrains.ReSharper.Psi.Razor.Tree.IRazorWrapper, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebCodeBlock, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode
    {
        public RazorSection([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType nodeType, JetBrains.ReSharper.Psi.Razor.Parsing.IRazorTokenNodeTypes tokenTypes) { }
        public JetBrains.ReSharper.Psi.Razor.Tree.IRazorToken CloseBraceToken { get; }
        public override JetBrains.ReSharper.Psi.ITreeRange ContentRange { get; }
        public JetBrains.ReSharper.Psi.Razor.Tree.IRazorToken NameToken { get; }
        public JetBrains.ReSharper.Psi.Razor.Tree.IRazorToken OpenBraceToken { get; }
        public override TReturn AcceptVisitor<TContext, TReturn>(JetBrains.ReSharper.Psi.Html.Tree.HtmlTreeVisitor<TContext, TReturn> visitor, TContext context) { }
        public string GetName() { }
        public JetBrains.ReSharper.Psi.TreeTextRange GetNameRange() { }
        public void SetName(string name) { }
    }
    public class RazorStatement : JetBrains.ReSharper.Psi.Razor.Impl.Tree.RazorCodeContainer, JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.ICompositeElement, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTagContainerMarker, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode, JetBrains.ReSharper.Psi.Razor.Tree.IRazorCode, JetBrains.ReSharper.Psi.Razor.Tree.IRazorCompositeElement, JetBrains.ReSharper.Psi.Razor.Tree.IRazorExecuteCode, JetBrains.ReSharper.Psi.Razor.Tree.IRazorStatement, JetBrains.ReSharper.Psi.Razor.Tree.IRazorTreeNode, JetBrains.ReSharper.Psi.Razor.Tree.IRazorWrapper, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebCodeBlock, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode
    {
        public RazorStatement([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType nodeType, JetBrains.ReSharper.Psi.Razor.Parsing.IRazorTokenNodeTypes tokenTypes) { }
        public override JetBrains.ReSharper.Psi.ITreeRange ContentRange { get; }
        public override TReturn AcceptVisitor<TContext, TReturn>(JetBrains.ReSharper.Psi.Html.Tree.HtmlTreeVisitor<TContext, TReturn> visitor, TContext context) { }
    }
    public sealed class RazorTag : JetBrains.ReSharper.Psi.Html.Impl.Tree.HtmlTag
    {
        public RazorTag(JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType nodeType, JetBrains.ReSharper.Psi.Html.Parsing.IHtmlTokenNodeTypes tokenTypes) { }
        public override JetBrains.ReSharper.Psi.Tree.IChameleonNode ReSync(JetBrains.ReSharper.Psi.Parsing.CachingLexer cachingLexer, JetBrains.ReSharper.Psi.TreeTextRange changedRange, int insertedTextLen) { }
    }
    public sealed class RazorTagHeader : JetBrains.ReSharper.Psi.Html.Impl.Tree.HtmlTagHeader
    {
        public RazorTagHeader(JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType nodeType, JetBrains.ReSharper.Psi.Html.Parsing.IHtmlTokenNodeTypes tokenTypes) { }
        public override JetBrains.ReSharper.Psi.Tree.IChameleonNode ReSync(JetBrains.ReSharper.Psi.Parsing.CachingLexer cachingLexer, JetBrains.ReSharper.Psi.TreeTextRange changedRange, int insertedTextLen) { }
    }
    public class RazorTemplate : JetBrains.ReSharper.Psi.Razor.Impl.Tree.RazorCompositeElement, JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.ICompositeElement, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTagContainerMarker, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode, JetBrains.ReSharper.Psi.Razor.Tree.IRazorCompositeElement, JetBrains.ReSharper.Psi.Razor.Tree.IRazorDelegate, JetBrains.ReSharper.Psi.Razor.Tree.IRazorHtmlMarkup, JetBrains.ReSharper.Psi.Razor.Tree.IRazorTemplate, JetBrains.ReSharper.Psi.Razor.Tree.IRazorTreeNode, JetBrains.ReSharper.Psi.Razor.Tree.IRazorWrapper, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode
    {
        public RazorTemplate([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeType nodeType, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Razor.Parsing.IRazorTokenNodeTypes tokenTypes) { }
        public JetBrains.ReSharper.Psi.ITreeRange ContentRange { get; }
        public override TReturn AcceptVisitor<TContext, TReturn>(JetBrains.ReSharper.Psi.Html.Tree.HtmlTreeVisitor<TContext, TReturn> visitor, TContext context) { }
    }
    public class RazorToken : JetBrains.ReSharper.Psi.Html.Impl.Tree.HtmlToken<JetBrains.ReSharper.Psi.Razor.Parsing.IRazorTokenNodeTypes>, JetBrains.ReSharper.Psi.Html.Tree.IHtmlToken, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode, JetBrains.ReSharper.Psi.Razor.Tree.IRazorToken, JetBrains.ReSharper.Psi.Razor.Tree.IRazorTreeNode, JetBrains.ReSharper.Psi.Tree.ITokenNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode { }
}
namespace JetBrains.ReSharper.Psi.Razor
{
    
    public interface IRazorServices
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Tree.IExpression GetAnnotatedLiteralExpression<TAssigmentEpression>([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode element, [JetBrains.Annotations.NotNullAttribute()] string attributeShortName, System.Func<TAssigmentEpression, JetBrains.Util.Pair<JetBrains.ReSharper.Psi.Tree.IExpression, JetBrains.ReSharper.Psi.Tree.IExpression>> assigmentChecker)
            where TAssigmentEpression :  class, JetBrains.ReSharper.Psi.Tree.ITreeNode;
    }
    public class RazorKeywords
    {
        public const string Class = "class";
        public const string Functions = "functions";
        public const string Helper = "helper";
        public const string Inherits = "inherits";
        public const string Layout = "layout";
        public const string LineMarkup = ":";
        public const string Model = "model";
        public const string Namespace = "namespace";
        public const string Section = "section";
        public const char Transition = '@';
    }
    [JetBrains.ReSharper.Psi.LanguageDefinitionAttribute("Razor")]
    public class RazorLanguage : JetBrains.ReSharper.Psi.Html.HtmlLanguage
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static readonly JetBrains.ReSharper.Psi.Razor.RazorLanguage Instance;
        public const string Name = "Razor";
        protected RazorLanguage(string name) { }
        protected RazorLanguage(string name, string presentableName) { }
    }
    public abstract class RazorLanguageService : JetBrains.ReSharper.Psi.Html.HtmlLanguageService
    {
        protected RazorLanguageService(JetBrains.ReSharper.Psi.Razor.RazorLanguage razorLanguage, JetBrains.ReSharper.Psi.IConstantValueService constantValueService, JetBrains.ReSharper.Psi.Razor.Parsing.IRazorTokenNodeTypes tokenNodeTypes, JetBrains.ReSharper.Psi.Html.IHtmlCodeFormatter codeFormatter, JetBrains.ReSharper.Psi.Html.Parsing.IWebTreeBuilderFactory webTreeBuilderFactory) { }
        public virtual JetBrains.ReSharper.Psi.Parsing.ILexerFactory GetPrimaryLexerFactory() { }
    }
    public abstract class RazorProjectFileLanguageService : JetBrains.ReSharper.Psi.Html.HtmlProjectFileLanguageService, JetBrains.ReSharper.Psi.IProjectFileLanguageService, JetBrains.ReSharper.Psi.Web.IWebProjectFileLanguageService
    {
        protected RazorProjectFileLanguageService(JetBrains.ProjectModel.RazorProjectFileType razorProjectFileType) { }
        public override JetBrains.UI.Icons.IconId Icon { get; }
        protected virtual JetBrains.ReSharper.Psi.PsiLanguageType PsiLanguageType { get; }
        public abstract JetBrains.ReSharper.Psi.PsiLanguageType GetCodeBehindLanguage(JetBrains.Text.IBuffer buffer);
        public override JetBrains.ReSharper.Psi.IPsiSourceFileProperties GetPsiProperties(JetBrains.ProjectModel.IProjectFile projectFile, JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
    }
}
namespace JetBrains.ReSharper.Psi.Razor.Mvc.Impl
{
    
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class RazorMvcModuleFactory : JetBrains.Application.IChangeProvider
    {
        public RazorMvcModuleFactory(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.ChangeManager changeManager, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Psi.Modules.IPsiModules psiModules) { }
        protected virtual void ProcessSourceFile(JetBrains.ReSharper.Psi.Modules.PsiModuleChangeBuilder builder, JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
    }
    public sealed class RazorMvcPsiProjectFileProperties : JetBrains.ReSharper.Psi.Razor.Impl.RazorPsiProjectFileProperties
    {
        public RazorMvcPsiProjectFileProperties(JetBrains.ProjectModel.IProjectFile projectFile, JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
        public override System.Collections.Generic.IEnumerable<string> GetPreImportedNamespaces() { }
    }
}
namespace JetBrains.ReSharper.Psi.Razor.Mvc.Tree
{
    
    public interface IRazorModelDirective : JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.ICompositeElement, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode, JetBrains.ReSharper.Psi.Razor.Tree.IRazorBaseTypeDirective, JetBrains.ReSharper.Psi.Razor.Tree.IRazorCode, JetBrains.ReSharper.Psi.Razor.Tree.IRazorCompositeElement, JetBrains.ReSharper.Psi.Razor.Tree.IRazorTreeNode, JetBrains.ReSharper.Psi.Razor.Tree.IRazorWrapper, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebCodeBlock, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode { }
    public interface IRazorMvcFile : JetBrains.ReSharper.Psi.Html.Tree.IHtmlFile, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTagContainer, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTagContainerMarker, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode, JetBrains.ReSharper.Psi.Razor.Tree.IRazorFile, JetBrains.ReSharper.Psi.Tree.IFile, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebFile, JetBrains.ReSharper.Psi.Web.Tree.IWebFileWithCodeBehind, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode { }
    public abstract class RazorMvcElementTypes : JetBrains.ReSharper.Psi.Razor.Tree.RazorElementTypes
    {
        protected RazorMvcElementTypes(JetBrains.ReSharper.Psi.Razor.Parsing.IRazorTokenNodeTypes tokenTypes) { }
    }
}
namespace JetBrains.ReSharper.Psi.Razor.Mvc
{
    
    public class static Util
    {
        public static bool IsMvcExtensionsApplied([JetBrains.Annotations.CanBeNullAttribute()] this JetBrains.ProjectModel.IProjectElement projectFile) { }
    }
}
namespace JetBrains.ReSharper.Psi.Razor.Parsing
{
    
    public interface IRazorTokenNodeType : JetBrains.ReSharper.Psi.Html.Parsing.IHtmlTokenNodeType<JetBrains.ReSharper.Psi.Razor.Parsing.IRazorTokenNodeTypes>, JetBrains.ReSharper.Psi.Parsing.ITokenNodeType { }
    public interface IRazorTokenNodeTypes : JetBrains.ReSharper.Psi.Html.Parsing.IHtmlCompoundTokenNodeTypes, JetBrains.ReSharper.Psi.Html.Parsing.IHtmlTokenNodeTypes
    {
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet CodeNodeTypesSet { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet ExtendedCodeNodeTypesSet { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet LeftBracketTypesSet { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Parsing.TokenNodeType RAZOR_BLOCK_MARKUP_END { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Parsing.TokenNodeType RAZOR_BLOCK_MARKUP_START { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Parsing.TokenNodeType RAZOR_CODE { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Parsing.TokenNodeType RAZOR_CODE_CLOSED_BRACKET { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Parsing.TokenNodeType RAZOR_CODE_OPENED_BRACKET { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Parsing.TokenNodeType RAZOR_COMMENT_BODY { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Parsing.TokenNodeType RAZOR_COMMENT_END { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Parsing.TokenNodeType RAZOR_COMMENT_START { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Parsing.TokenNodeType RAZOR_ERROR_BODY_EXPECTED { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Parsing.TokenNodeType RAZOR_ERROR_CONDITION_EXPECTED { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Parsing.TokenNodeType RAZOR_ERROR_IDENTIFIER_EXPECTED { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Parsing.TokenNodeType RAZOR_IDENTIFIER { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Parsing.TokenNodeType RAZOR_IMPLICIT_CODE { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Parsing.TokenNodeType RAZOR_KEYWORD { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Parsing.TokenNodeType RAZOR_LINE_MARKUP_END { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Parsing.TokenNodeType RAZOR_NAMESPACE_CODE { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Parsing.TokenNodeType RAZOR_SECTION_CLOSED_BRACKET { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Parsing.TokenNodeType RAZOR_SECTION_OPENED_BRACKET { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Parsing.TokenNodeType RAZOR_SPACE { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Html.Parsing.HtmlTokenNodeType<JetBrains.ReSharper.Psi.Razor.Parsing.IRazorTokenNodeTypes> RAZOR_STUB_CODE { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Parsing.TokenNodeType RAZOR_TEMPLATE_END { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Parsing.TokenNodeType RAZOR_TEMPLATE_START { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Parsing.TokenNodeType RAZOR_TRANSITION { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Parsing.TokenNodeType RAZOR_TRANSITION_CODE { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Parsing.TokenNodeType RAZOR_WRAPPER_CLOSED_BRACKET { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Parsing.TokenNodeType RAZOR_WRAPPER_CODE { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Parsing.TokenNodeType RAZOR_WRAPPER_IMPLICIT_CODE { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Parsing.TokenNodeType RAZOR_WRAPPER_OPENED_BRACKET { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet RightBracketTypesSet { get; }
    }
    public class RazorCodeTokenNodeType : JetBrains.ReSharper.Psi.Razor.Parsing.RazorTokenNodeType
    {
        public override JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.LeafElementBase Create(JetBrains.Text.IBuffer buffer, JetBrains.ReSharper.Psi.TreeOffset startOffset, JetBrains.ReSharper.Psi.TreeOffset endOffset) { }
    }
    public abstract class RazorElementFactory : JetBrains.ReSharper.Psi.Html.Parsing.HtmlElementFactory
    {
        protected RazorElementFactory(JetBrains.ReSharper.Psi.Html.Parsing.IWebTreeBuilderFactory builderFactory) { }
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Tree.ITreeNode> CompileText(string text, JetBrains.ReSharper.Psi.Tree.ITreeNode contextElement, JetBrains.ReSharper.Psi.Html.Parsing.HtmlContextType htmlContextType = 0) { }
        public JetBrains.ReSharper.Psi.Razor.Tree.IRazorBlockMarkup CreateBlockMarkup(string text, JetBrains.ReSharper.Psi.Tree.ITreeNode contextElement, JetBrains.ReSharper.Psi.SandBoxContextType contextType = 1) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ReSharper.Psi.Razor.Tree.IRazorComment CreateComment(string text, JetBrains.ReSharper.Psi.Tree.ITreeNode contextElement) { }
        [JetBrains.Annotations.NotNullAttribute()]
        protected TConstructType CreateConstruct<TConstructType>(string text, string format, string name, JetBrains.ReSharper.Psi.Tree.ITreeNode contextElement, JetBrains.ReSharper.Psi.SandBoxContextType contextType = 1)
            where TConstructType :  class, JetBrains.ReSharper.Psi.Razor.Tree.IRazorTreeNode { }
        [JetBrains.Annotations.NotNullAttribute()]
        public abstract JetBrains.ReSharper.Psi.Razor.Tree.IRazorFunctionsBlock CreateFunctionsBlock(string text, JetBrains.ReSharper.Psi.Tree.ITreeNode contextElement);
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ReSharper.Psi.Razor.Tree.IRazorImplicitExpression CreateImplicitExpression(string text, JetBrains.ReSharper.Psi.Tree.ITreeNode contextElement, JetBrains.ReSharper.Psi.SandBoxContextType contextType = 1) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ReSharper.Psi.Razor.Tree.IRazorImplicitExpression CreateImplicitExpressionInPars(string text, JetBrains.ReSharper.Psi.Tree.ITreeNode contextElement, JetBrains.ReSharper.Psi.SandBoxContextType contextType = 1) { }
        public JetBrains.ReSharper.Psi.Razor.Tree.IRazorInheritsDirective CreateInheritsDirective(string superClassName, JetBrains.ReSharper.Psi.Tree.ITreeNode contextElement) { }
        public JetBrains.ReSharper.Psi.Razor.Tree.IRazorLineMarkup CreateLineMarkup(string text, JetBrains.ReSharper.Psi.Tree.ITreeNode contextElement, JetBrains.ReSharper.Psi.SandBoxContextType contextType = 1) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public abstract JetBrains.ReSharper.Psi.Razor.Tree.IRazorNamespaceImport CreateNamespaceImport(string namespaceName, JetBrains.ReSharper.Psi.Tree.ITreeNode contextElement);
        [JetBrains.Annotations.NotNullAttribute()]
        public abstract JetBrains.ReSharper.Psi.Razor.Tree.IRazorStatement CreateStatement(string text, JetBrains.ReSharper.Psi.Tree.ITreeNode contextElement, JetBrains.ReSharper.Psi.SandBoxContextType contextType = 1);
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ReSharper.Psi.Razor.Tree.IRazorStatement CreateStatementWithKeyword(string text, JetBrains.ReSharper.Psi.Tree.ITreeNode contextElement) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.ReSharper.Psi.Razor.Parsing.RazorElementFactory GetInstance(JetBrains.ReSharper.Psi.PsiLanguageType lang, JetBrains.ReSharper.Psi.ILanguageManager languageManager = null) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Psi.Razor.Tree.IRazorImplicitExpression TryCreateImplicitExpression(string text, JetBrains.ReSharper.Psi.Tree.ITreeNode contextElement) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.Razor.RazorLanguage))]
    public class RazorParserNodeTypeSets
    {
        public RazorParserNodeTypeSets(JetBrains.ReSharper.Psi.Razor.Parsing.IRazorTokenNodeTypes tokenTypes) { }
        public JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet AfterTransitionNodeTypes { get; }
        public JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet BlockMarkupNodeTypes { get; }
        public JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet CommentNodeTypes { get; }
        public JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet ErrorNodeTypes { get; }
        public JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet ImplicitWrappedCodeNodeTypes { get; }
        public JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet LineMarkupNodeTypes { get; }
        public JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet[] OnlyCodeNodeTypes { get; }
        public JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet[] RazorCodeNodeTypes { get; }
        public JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet[] RazorPureCodeNodeTypes { get; }
        public JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet[] RazorPureOrderedNodeTypes { get; }
        public JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet RazorTypeExpectedNodes { get; }
        public JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet[] SectionNodeTypes { get; }
        public JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet TemplateNodeTypes { get; }
    }
    public class RazorTokenNodeType : JetBrains.ReSharper.Psi.Html.Parsing.HtmlTokenNodeType<JetBrains.ReSharper.Psi.Razor.Parsing.IRazorTokenNodeTypes>, JetBrains.ReSharper.Psi.Html.Parsing.IHtmlTokenNodeType<JetBrains.ReSharper.Psi.Razor.Parsing.IRazorTokenNodeTypes>, JetBrains.ReSharper.Psi.Parsing.ITokenNodeType, JetBrains.ReSharper.Psi.Razor.Parsing.IRazorTokenNodeType
    {
        public override bool IsComment { get; }
        public override bool IsWhitespace { get; }
        public override JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.LeafElementBase Create(JetBrains.Text.IBuffer buffer, JetBrains.ReSharper.Psi.TreeOffset startOffset, JetBrains.ReSharper.Psi.TreeOffset endOffset) { }
    }
    public abstract class RazorTreeBuilder : JetBrains.ReSharper.Psi.Html.Parsing.HtmlTreeBuilderBase<JetBrains.ReSharper.Psi.Razor.Tree.IRazorFile, JetBrains.ReSharper.Psi.Razor.Impl.Tree.RazorFile, JetBrains.ReSharper.Psi.Razor.Tree.RazorElementTypes, JetBrains.ReSharper.Psi.Razor.Parsing.IRazorTokenNodeTypes>
    {
        protected RazorTreeBuilder(JetBrains.ReSharper.Psi.Razor.RazorLanguage language, JetBrains.ReSharper.Psi.Razor.Tree.RazorElementTypes elementTypes, JetBrains.ReSharper.Psi.Razor.Parsing.IRazorTokenNodeTypes tokenTypes, JetBrains.ReSharper.Psi.Razor.Parsing.RazorParserNodeTypeSets razorParserNodeTypeSets, System.Collections.Generic.ICollection<string> templatesMimeTypes, int depthThreshold) { }
        public override bool CanHaveServerSideNodes { get; }
        protected System.Collections.Generic.IDictionary<string, System.Func<JetBrains.ReSharper.Psi.Html.Parsing.HtmlTokenNodeType<JetBrains.ReSharper.Psi.Razor.Parsing.IRazorTokenNodeTypes>, System.Func<JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeElement, JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeElement>, JetBrains.Util.JetTuple<JetBrains.ReSharper.Psi.Html.Parsing.HtmlTokenNodeType<JetBrains.ReSharper.Psi.Razor.Parsing.IRazorTokenNodeTypes>, JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeElement, System.Predicate<>[], System.Func<JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeElement, JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeElement>>>> CodeParsers { get; }
        protected System.Collections.Generic.IDictionary<string, JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet[]> CodeTokens { get; }
        protected override JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet HandlingTokens { get; }
        protected virtual string IncludeFileName { get; }
        protected override JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeElement AddHtmlIncludeEnd(JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeElement parent, JetBrains.ReSharper.Psi.Html.Impl.Tree.HtmlIncludeEnd includeEnd) { }
        protected static System.Predicate<>[] ConvertNodeTypeSetsToPredicates(JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet[] nodeTypeSets) { }
        protected override JetBrains.ReSharper.Psi.Razor.Impl.Tree.RazorFile CreateFile(JetBrains.ReSharper.Psi.Html.Parsing.HtmlStackedLexer stackedLexer, out JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeElement compositeElement) { }
        protected override void CreateTokenError(ref JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeElement parent, string description, ref JetBrains.ReSharper.Psi.Html.Parsing.HtmlTokenNodeType<> tokenType) { }
        protected override JetBrains.ReSharper.Psi.Html.Parsing.HtmlTreeBuilderBase<JetBrains.ReSharper.Psi.Razor.Tree.IRazorFile, JetBrains.ReSharper.Psi.Razor.Impl.Tree.RazorFile, JetBrains.ReSharper.Psi.Razor.Tree.RazorElementTypes, JetBrains.ReSharper.Psi.Razor.Parsing.IRazorTokenNodeTypes>.FindParentToClose DoFindParentToClose(JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeElement e) { }
        protected override bool IsStopFindOpenTag(JetBrains.ReSharper.Psi.Tree.ITreeNode node) { }
        protected override bool ParseAdditionalConstruct(ref JetBrains.ReSharper.Psi.Html.Parsing.HtmlTokenNodeType<> tokenType, ref JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeElement compositeElement) { }
        protected static System.Func<JetBrains.ReSharper.Psi.Html.Parsing.HtmlTokenNodeType<JetBrains.ReSharper.Psi.Razor.Parsing.IRazorTokenNodeTypes>, System.Func<JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeElement, JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeElement>, JetBrains.Util.JetTuple<JetBrains.ReSharper.Psi.Html.Parsing.HtmlTokenNodeType<JetBrains.ReSharper.Psi.Razor.Parsing.IRazorTokenNodeTypes>, JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeElement, System.Predicate<>[], System.Func<JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeElement, JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeElement>>> ParseRazorCodeHandler<T>([JetBrains.Annotations.NotNullAttribute()] System.Func<T> creator, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet[] nodeTypeSets, [JetBrains.Annotations.CanBeNullAttribute()] System.Func<JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeElement, JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeElement> parenter)
            where T : JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeElement { }
        protected static System.Func<JetBrains.ReSharper.Psi.Html.Parsing.HtmlTokenNodeType<JetBrains.ReSharper.Psi.Razor.Parsing.IRazorTokenNodeTypes>, System.Func<JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeElement, JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeElement>, JetBrains.Util.JetTuple<JetBrains.ReSharper.Psi.Html.Parsing.HtmlTokenNodeType<JetBrains.ReSharper.Psi.Razor.Parsing.IRazorTokenNodeTypes>, JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeElement, System.Predicate<>[], System.Func<JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeElement, JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeElement>>> ParseRazorCodeHandler<T>([JetBrains.Annotations.NotNullAttribute()] System.Func<T> creator, [JetBrains.Annotations.NotNullAttribute()] params JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.NodeTypeSet[] nodeTypeSets)
            where T : JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeElement { }
        public override System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Tree.ITreeNode> SearchServerSideNodes(JetBrains.ReSharper.Psi.Tree.ITreeNode nestedFile) { }
        protected static JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeElement SetOriginalParent(JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeElement element) { }
        protected override JetBrains.ReSharper.Psi.Html.Parsing.ServerSideNodeKinds ToNodeWithKind(JetBrains.ReSharper.Psi.Tree.ITreeNode node) { }
    }
    public abstract class RazorTreeBuilderFactory : JetBrains.ReSharper.Psi.Html.Parsing.HtmlTreeBuilderFactory
    {
        protected RazorTreeBuilderFactory(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.Settings.ISettingsStore settingsStore, JetBrains.ReSharper.Psi.Razor.RazorLanguage language, JetBrains.ReSharper.Psi.Razor.Tree.RazorElementTypes elementTypes, JetBrains.ReSharper.Psi.Razor.Parsing.IRazorTokenNodeTypes tokenTypes, JetBrains.ReSharper.Psi.PerformanceThreshold.PerformanceThresholds thresholds) { }
        public virtual JetBrains.ReSharper.Psi.Html.Parsing.IWebTreeBuilder CreateTreeBuilder() { }
    }
}
namespace JetBrains.ReSharper.Psi.Razor.References
{
    
    public interface IRazorFileReference : JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IQualifiableReferenceBase, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IQualifiableReferenceWithGlobalSymbolTable, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IReferenceWithGlobalSymbolTable, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IReferenceWithQualifier, JetBrains.ReSharper.Psi.Razor.References.IRazorReference, JetBrains.ReSharper.Psi.Resolve.ICompleteableReference, JetBrains.ReSharper.Psi.Resolve.IFileReference, JetBrains.ReSharper.Psi.Resolve.IPathReference, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.Util.IUserDataHolder { }
    public interface IRazorLayoutReference : JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IQualifiableReferenceBase, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IQualifiableReferenceWithGlobalSymbolTable, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IReferenceWithGlobalSymbolTable, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IReferenceWithQualifier, JetBrains.ReSharper.Psi.Razor.References.IRazorFileReference, JetBrains.ReSharper.Psi.Razor.References.IRazorReference, JetBrains.ReSharper.Psi.Resolve.ICompleteableReference, JetBrains.ReSharper.Psi.Resolve.IFileReference, JetBrains.ReSharper.Psi.Resolve.IPathReference, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.Util.IUserDataHolder { }
    public interface IRazorReference : JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.Util.IUserDataHolder { }
    public interface IRazorSectionDeclarationReference : JetBrains.ReSharper.Psi.Razor.References.IRazorReference, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.Util.IUserDataHolder
    {
        JetBrains.ReSharper.Psi.Razor.References.IRazorSectionDeclarationReference BindTo(string name);
    }
    public interface IRazorSectionReference : JetBrains.ReSharper.Psi.Html.References.IHtmlCompleteableReference, JetBrains.ReSharper.Psi.Razor.References.IRazorReference, JetBrains.ReSharper.Psi.Resolve.ICompleteableReference, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.Util.IUserDataHolder { }
}
namespace JetBrains.ReSharper.Psi.Razor.Resources
{
    
    public sealed class PsiRazorThemedIcons
    {
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Psi.Razor;component/resources/PsiRazorIcons/ThemedIcons.PsiRa" +
            "zor.Generated.Xaml", 1, "Razor")]
        public sealed class Razor : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Psi.Razor;component/resources/PsiRazorIcons/ThemedIcons.PsiRa" +
            "zor.Generated.Xaml", 2, "RazorHelperMethod")]
        public sealed class RazorHelperMethod : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Psi.Razor;component/resources/PsiRazorIcons/ThemedIcons.PsiRa" +
            "zor.Generated.Xaml", 3, "RazorHelperMethodVs")]
        public sealed class RazorHelperMethodVs : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Psi.Razor;component/resources/PsiRazorIcons/ThemedIcons.PsiRa" +
            "zor.Generated.Xaml", 0, "RazorSection")]
        public sealed class RazorSection : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
    }
}
namespace JetBrains.ReSharper.Psi.Razor.Tree
{
    
    public interface IRazorBaseTypeDirective : JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.ICompositeElement, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode, JetBrains.ReSharper.Psi.Razor.Tree.IRazorCode, JetBrains.ReSharper.Psi.Razor.Tree.IRazorCompositeElement, JetBrains.ReSharper.Psi.Razor.Tree.IRazorTreeNode, JetBrains.ReSharper.Psi.Razor.Tree.IRazorWrapper, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebCodeBlock, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode { }
    public interface IRazorBlockMarkup : JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.ICompositeElement, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTagContainerMarker, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode, JetBrains.ReSharper.Psi.Razor.Tree.IRazorCompositeElement, JetBrains.ReSharper.Psi.Razor.Tree.IRazorHtmlMarkup, JetBrains.ReSharper.Psi.Razor.Tree.IRazorPairWrapper, JetBrains.ReSharper.Psi.Razor.Tree.IRazorTreeNode, JetBrains.ReSharper.Psi.Razor.Tree.IRazorWrapper, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode { }
    public interface IRazorCode : JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.ICompositeElement, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode, JetBrains.ReSharper.Psi.Razor.Tree.IRazorCompositeElement, JetBrains.ReSharper.Psi.Razor.Tree.IRazorTreeNode, JetBrains.ReSharper.Psi.Razor.Tree.IRazorWrapper, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebCodeBlock, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode
    {
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Tree.ITreeNode> CodeNodes { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Razor.Tree.IRazorToken Keyword { get; }
    }
    public interface IRazorCodeBlock : JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.ICompositeElement, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTagContainerMarker, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode, JetBrains.ReSharper.Psi.Razor.Tree.IRazorCode, JetBrains.ReSharper.Psi.Razor.Tree.IRazorCompositeElement, JetBrains.ReSharper.Psi.Razor.Tree.IRazorExecuteCode, JetBrains.ReSharper.Psi.Razor.Tree.IRazorStatement, JetBrains.ReSharper.Psi.Razor.Tree.IRazorTreeNode, JetBrains.ReSharper.Psi.Razor.Tree.IRazorWrapper, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebCodeBlock, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode { }
    public interface IRazorCodeToken : JetBrains.ReSharper.Psi.Html.Tree.IHtmlToken, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode, JetBrains.ReSharper.Psi.Razor.Tree.IRazorToken, JetBrains.ReSharper.Psi.Razor.Tree.IRazorTreeNode, JetBrains.ReSharper.Psi.Tree.ITokenNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode { }
    public interface IRazorComment : JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.ICompositeElement, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode, JetBrains.ReSharper.Psi.Html.Tree.IWebComment, JetBrains.ReSharper.Psi.Razor.Tree.IRazorCompositeElement, JetBrains.ReSharper.Psi.Razor.Tree.IRazorTreeNode, JetBrains.ReSharper.Psi.Tree.IComment, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode { }
    public interface IRazorCompositeElement : JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.ICompositeElement, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode, JetBrains.ReSharper.Psi.Razor.Tree.IRazorTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode { }
    public interface IRazorDelegate : JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.ICompositeElement, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTagContainerMarker, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode, JetBrains.ReSharper.Psi.Razor.Tree.IRazorCompositeElement, JetBrains.ReSharper.Psi.Razor.Tree.IRazorTreeNode, JetBrains.ReSharper.Psi.Razor.Tree.IRazorWrapper, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode { }
    public interface IRazorExecuteCode : JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.ICompositeElement, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode, JetBrains.ReSharper.Psi.Razor.Tree.IRazorCode, JetBrains.ReSharper.Psi.Razor.Tree.IRazorCompositeElement, JetBrains.ReSharper.Psi.Razor.Tree.IRazorTreeNode, JetBrains.ReSharper.Psi.Razor.Tree.IRazorWrapper, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebCodeBlock, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode { }
    public interface IRazorFile : JetBrains.ReSharper.Psi.Html.Tree.IHtmlFile, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTagContainer, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTagContainerMarker, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode, JetBrains.ReSharper.Psi.Tree.IFile, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebFile, JetBrains.ReSharper.Psi.Web.Tree.IWebFileWithCodeBehind, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode
    {
        JetBrains.ReSharper.Psi.Razor.Tree.IRazorBaseTypeDirective BaseTypeDirective { get; }
        System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.Razor.Tree.IRazorFunctionsBlock> FunctionsBlocks { get; }
        System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.Razor.Tree.IRazorHelper> Helpers { get; }
        System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.Razor.Tree.IRazorNamespaceImport> NamespaceImports { get; }
        JetBrains.ReSharper.Psi.Razor.Parsing.IRazorTokenNodeTypes TokenTypes { get; }
    }
    public interface IRazorFunctionsBlock : JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.ICompositeElement, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode, JetBrains.ReSharper.Psi.Razor.Tree.IRazorCode, JetBrains.ReSharper.Psi.Razor.Tree.IRazorCompositeElement, JetBrains.ReSharper.Psi.Razor.Tree.IRazorPairWrapper, JetBrains.ReSharper.Psi.Razor.Tree.IRazorTreeNode, JetBrains.ReSharper.Psi.Razor.Tree.IRazorWrapper, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebCodeBlock, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode { }
    public interface IRazorHelper : JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.ICompositeElement, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTagContainerMarker, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode, JetBrains.ReSharper.Psi.Razor.Tree.IRazorCode, JetBrains.ReSharper.Psi.Razor.Tree.IRazorCompositeElement, JetBrains.ReSharper.Psi.Razor.Tree.IRazorDelegate, JetBrains.ReSharper.Psi.Razor.Tree.IRazorTreeNode, JetBrains.ReSharper.Psi.Razor.Tree.IRazorWrapper, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebCodeBlock, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode { }
    public interface IRazorHtmlMarkup : JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.ICompositeElement, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTagContainerMarker, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode, JetBrains.ReSharper.Psi.Razor.Tree.IRazorCompositeElement, JetBrains.ReSharper.Psi.Razor.Tree.IRazorTreeNode, JetBrains.ReSharper.Psi.Razor.Tree.IRazorWrapper, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode { }
    public interface IRazorImplicitExpression : JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.ICompositeElement, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode, JetBrains.ReSharper.Psi.Razor.Tree.IRazorCode, JetBrains.ReSharper.Psi.Razor.Tree.IRazorCompositeElement, JetBrains.ReSharper.Psi.Razor.Tree.IRazorExecuteCode, JetBrains.ReSharper.Psi.Razor.Tree.IRazorTreeNode, JetBrains.ReSharper.Psi.Razor.Tree.IRazorWrapper, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebCodeBlock, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode { }
    public interface IRazorInclude : JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode, JetBrains.ReSharper.Psi.Razor.Tree.IRazorTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode { }
    public interface IRazorInheritsDirective : JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.ICompositeElement, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode, JetBrains.ReSharper.Psi.Razor.Tree.IRazorBaseTypeDirective, JetBrains.ReSharper.Psi.Razor.Tree.IRazorCode, JetBrains.ReSharper.Psi.Razor.Tree.IRazorCompositeElement, JetBrains.ReSharper.Psi.Razor.Tree.IRazorTreeNode, JetBrains.ReSharper.Psi.Razor.Tree.IRazorWrapper, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebCodeBlock, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode { }
    public interface IRazorLineMarkup : JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.ICompositeElement, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTagContainerMarker, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode, JetBrains.ReSharper.Psi.Razor.Tree.IRazorCompositeElement, JetBrains.ReSharper.Psi.Razor.Tree.IRazorHtmlMarkup, JetBrains.ReSharper.Psi.Razor.Tree.IRazorTreeNode, JetBrains.ReSharper.Psi.Razor.Tree.IRazorWrapper, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode { }
    public interface IRazorNamespaceImport : JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.ICompositeElement, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode, JetBrains.ReSharper.Psi.Razor.Tree.IRazorCode, JetBrains.ReSharper.Psi.Razor.Tree.IRazorCompositeElement, JetBrains.ReSharper.Psi.Razor.Tree.IRazorTreeNode, JetBrains.ReSharper.Psi.Razor.Tree.IRazorWrapper, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebCodeBlock, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode { }
    public interface IRazorPairWrapper : JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.ICompositeElement, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode, JetBrains.ReSharper.Psi.Razor.Tree.IRazorCompositeElement, JetBrains.ReSharper.Psi.Razor.Tree.IRazorTreeNode, JetBrains.ReSharper.Psi.Razor.Tree.IRazorWrapper, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode
    {
        JetBrains.ReSharper.Psi.Razor.Tree.IRazorToken CloseBraceToken { get; }
        JetBrains.ReSharper.Psi.Razor.Tree.IRazorToken OpenBraceToken { get; }
    }
    public interface IRazorSection : JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.ICompositeElement, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTagContainerMarker, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode, JetBrains.ReSharper.Psi.Razor.Tree.IRazorCode, JetBrains.ReSharper.Psi.Razor.Tree.IRazorCompositeElement, JetBrains.ReSharper.Psi.Razor.Tree.IRazorPairWrapper, JetBrains.ReSharper.Psi.Razor.Tree.IRazorTreeNode, JetBrains.ReSharper.Psi.Razor.Tree.IRazorWrapper, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebCodeBlock, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode
    {
        JetBrains.ReSharper.Psi.Razor.Tree.IRazorToken NameToken { get; }
        string GetName();
        JetBrains.ReSharper.Psi.TreeTextRange GetNameRange();
        void SetName(string name);
    }
    public interface IRazorStatement : JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.ICompositeElement, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTagContainerMarker, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode, JetBrains.ReSharper.Psi.Razor.Tree.IRazorCode, JetBrains.ReSharper.Psi.Razor.Tree.IRazorCompositeElement, JetBrains.ReSharper.Psi.Razor.Tree.IRazorExecuteCode, JetBrains.ReSharper.Psi.Razor.Tree.IRazorTreeNode, JetBrains.ReSharper.Psi.Razor.Tree.IRazorWrapper, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebCodeBlock, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode { }
    public interface IRazorTemplate : JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.ICompositeElement, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTagContainerMarker, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode, JetBrains.ReSharper.Psi.Razor.Tree.IRazorCompositeElement, JetBrains.ReSharper.Psi.Razor.Tree.IRazorDelegate, JetBrains.ReSharper.Psi.Razor.Tree.IRazorHtmlMarkup, JetBrains.ReSharper.Psi.Razor.Tree.IRazorTreeNode, JetBrains.ReSharper.Psi.Razor.Tree.IRazorWrapper, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode { }
    public interface IRazorToken : JetBrains.ReSharper.Psi.Html.Tree.IHtmlToken, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode, JetBrains.ReSharper.Psi.Razor.Tree.IRazorTreeNode, JetBrains.ReSharper.Psi.Tree.ITokenNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode { }
    public interface IRazorTreeNode : JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode
    {
        JetBrains.ReSharper.Psi.Razor.Parsing.IRazorTokenNodeTypes TokenTypes { get; }
    }
    public interface IRazorWrapper : JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.ICompositeElement, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTreeNode, JetBrains.ReSharper.Psi.Razor.Tree.IRazorCompositeElement, JetBrains.ReSharper.Psi.Razor.Tree.IRazorTreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Web.Tree.IWebTreeNode
    {
        JetBrains.ReSharper.Psi.ITreeRange ContentRange { get; }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.Razor.RazorLanguage))]
    public class RazorElementTypes : JetBrains.ReSharper.Psi.Html.Tree.HtmlElementTypes
    {
        public readonly JetBrains.ReSharper.Psi.Razor.Tree.RazorElementTypes.RazorBlockMarkupNodeType RazorBlockMarkup;
        public readonly JetBrains.ReSharper.Psi.Razor.Tree.RazorElementTypes.RazorCodeBlockNodeType RazorCodeBlock;
        public readonly JetBrains.ReSharper.Psi.Razor.Tree.RazorElementTypes.RazorCommentNodeType RazorComment;
        public readonly JetBrains.ReSharper.Psi.Razor.Tree.RazorElementTypes.RazorEmptyDirectiveNodeType RazorEmptyDirective;
        public readonly JetBrains.ReSharper.Psi.Razor.Tree.RazorElementTypes.RazorFunctionsBlockNodeType RazorFunctionsBlock;
        public readonly JetBrains.ReSharper.Psi.Razor.Tree.RazorElementTypes.RazorHelperNodeType RazorHelper;
        public readonly JetBrains.ReSharper.Psi.Razor.Tree.RazorElementTypes.RazorImplicitExpressionNodeType RazorImplicitExpression;
        public readonly JetBrains.ReSharper.Psi.Razor.Tree.RazorElementTypes.RazorIncludeNodeType RazorInclude;
        public readonly JetBrains.ReSharper.Psi.Razor.Tree.RazorElementTypes.RazorInheritsDirectiveNodeType RazorInheritsDirective;
        public readonly JetBrains.ReSharper.Psi.Razor.Tree.RazorElementTypes.RazorLineMarkupNodeType RazorLineMarkup;
        public readonly JetBrains.ReSharper.Psi.Razor.Tree.RazorElementTypes.RazorModelDirectiveNodeType RazorModelDirective;
        public readonly JetBrains.ReSharper.Psi.Razor.Tree.RazorElementTypes.RazorNamespaceImportNodeType RazorNamespaceImport;
        public readonly JetBrains.ReSharper.Psi.Razor.Tree.RazorElementTypes.RazorReservedKeywordNodeType RazorReservedKeyword;
        public readonly JetBrains.ReSharper.Psi.Razor.Tree.RazorElementTypes.RazorSectionNodeType RazorSection;
        public readonly JetBrains.ReSharper.Psi.Razor.Tree.RazorElementTypes.RazorStatementNodeType RazorStatement;
        public readonly JetBrains.ReSharper.Psi.Razor.Tree.RazorElementTypes.RazorTemplateNodeType RazorTemplate;
        public RazorElementTypes(JetBrains.ReSharper.Psi.Razor.Parsing.IRazorTokenNodeTypes tokenTypes) { }
        public JetBrains.ReSharper.Psi.Razor.Tree.RazorElementTypes.RazorFileNodeType RazorFile { get; set; }
        public class RazorBlockMarkupNodeType : JetBrains.ReSharper.Psi.Razor.Tree.RazorElementTypes.RazorCompositeNodeType<JetBrains.ReSharper.Psi.Razor.Impl.Tree.RazorBlockMarkup>
        {
            public RazorBlockMarkupNodeType(JetBrains.ReSharper.Psi.Razor.Parsing.IRazorTokenNodeTypes tokenTypes, int index) { }
            public override JetBrains.ReSharper.Psi.Razor.Impl.Tree.RazorBlockMarkup Create() { }
        }
        public class RazorCodeBlockNodeType : JetBrains.ReSharper.Psi.Razor.Tree.RazorElementTypes.RazorCompositeNodeType<JetBrains.ReSharper.Psi.Razor.Impl.Tree.RazorCodeBlock>
        {
            public RazorCodeBlockNodeType(JetBrains.ReSharper.Psi.Razor.Parsing.IRazorTokenNodeTypes tokenTypes, int index) { }
            public override JetBrains.ReSharper.Psi.Razor.Impl.Tree.RazorCodeBlock Create() { }
        }
        public class RazorCommentNodeType : JetBrains.ReSharper.Psi.Razor.Tree.RazorElementTypes.RazorCompositeNodeType<JetBrains.ReSharper.Psi.Razor.Impl.Tree.RazorComment>
        {
            public RazorCommentNodeType(JetBrains.ReSharper.Psi.Razor.Parsing.IRazorTokenNodeTypes tokenTypes, int index) { }
            public override JetBrains.ReSharper.Psi.Razor.Impl.Tree.RazorComment Create() { }
        }
        public abstract class RazorCompositeNodeType<T> : JetBrains.ReSharper.Psi.Html.Tree.HtmlElementTypes.HtmlCompositeNodeType<T, JetBrains.ReSharper.Psi.Razor.Parsing.IRazorTokenNodeTypes>
            where T : JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.CompositeElement
        {
            protected RazorCompositeNodeType(string s, JetBrains.ReSharper.Psi.Razor.Parsing.IRazorTokenNodeTypes tokenTypes, int index) { }
        }
        public class RazorEmptyDirectiveNodeType : JetBrains.ReSharper.Psi.Razor.Tree.RazorElementTypes.RazorCompositeNodeType<JetBrains.ReSharper.Psi.Razor.Impl.Tree.RazorEmptyDirective>
        {
            public RazorEmptyDirectiveNodeType(JetBrains.ReSharper.Psi.Razor.Parsing.IRazorTokenNodeTypes tokenTypes, int index) { }
            public override JetBrains.ReSharper.Psi.Razor.Impl.Tree.RazorEmptyDirective Create() { }
        }
        public class RazorFileNodeType : JetBrains.ReSharper.Psi.Razor.Tree.RazorElementTypes.RazorCompositeNodeType<JetBrains.ReSharper.Psi.Razor.Impl.Tree.RazorFile>
        {
            public RazorFileNodeType(JetBrains.ReSharper.Psi.Razor.Parsing.IRazorTokenNodeTypes tokenTypes, int index) { }
            protected RazorFileNodeType(string s, JetBrains.ReSharper.Psi.Razor.Parsing.IRazorTokenNodeTypes tokenTypes, int index) { }
            public override JetBrains.ReSharper.Psi.Razor.Impl.Tree.RazorFile Create() { }
        }
        public class RazorFunctionsBlockNodeType : JetBrains.ReSharper.Psi.Razor.Tree.RazorElementTypes.RazorCompositeNodeType<JetBrains.ReSharper.Psi.Razor.Impl.Tree.RazorFunctionsBlock>
        {
            public RazorFunctionsBlockNodeType(JetBrains.ReSharper.Psi.Razor.Parsing.IRazorTokenNodeTypes tokenTypes, int index) { }
            public override JetBrains.ReSharper.Psi.Razor.Impl.Tree.RazorFunctionsBlock Create() { }
        }
        public class RazorHelperNodeType : JetBrains.ReSharper.Psi.Razor.Tree.RazorElementTypes.RazorCompositeNodeType<JetBrains.ReSharper.Psi.Razor.Impl.Tree.RazorHelper>
        {
            public RazorHelperNodeType(JetBrains.ReSharper.Psi.Razor.Parsing.IRazorTokenNodeTypes tokenTypes, int index) { }
            public override JetBrains.ReSharper.Psi.Razor.Impl.Tree.RazorHelper Create() { }
        }
        public class RazorImplicitExpressionNodeType : JetBrains.ReSharper.Psi.Razor.Tree.RazorElementTypes.RazorCompositeNodeType<JetBrains.ReSharper.Psi.Razor.Impl.Tree.RazorImplicitExpression>
        {
            public RazorImplicitExpressionNodeType(JetBrains.ReSharper.Psi.Razor.Parsing.IRazorTokenNodeTypes tokenTypes, int index) { }
            public override JetBrains.ReSharper.Psi.Razor.Impl.Tree.RazorImplicitExpression Create() { }
        }
        public class RazorIncludeNodeType : JetBrains.ReSharper.Psi.Razor.Tree.RazorElementTypes.RazorCompositeNodeType<JetBrains.ReSharper.Psi.Razor.Impl.Tree.RazorInclude>
        {
            public RazorIncludeNodeType(JetBrains.ReSharper.Psi.Razor.Parsing.IRazorTokenNodeTypes tokenTypes, int index) { }
            public override JetBrains.ReSharper.Psi.Razor.Impl.Tree.RazorInclude Create() { }
        }
        public class RazorInheritsDirectiveNodeType : JetBrains.ReSharper.Psi.Razor.Tree.RazorElementTypes.RazorCompositeNodeType<JetBrains.ReSharper.Psi.Razor.Impl.Tree.RazorInheritsDirective>
        {
            public RazorInheritsDirectiveNodeType(JetBrains.ReSharper.Psi.Razor.Parsing.IRazorTokenNodeTypes tokenTypes, int index) { }
            public override JetBrains.ReSharper.Psi.Razor.Impl.Tree.RazorInheritsDirective Create() { }
        }
        public class RazorLineMarkupNodeType : JetBrains.ReSharper.Psi.Razor.Tree.RazorElementTypes.RazorCompositeNodeType<JetBrains.ReSharper.Psi.Razor.Impl.Tree.RazorLineMarkup>
        {
            public RazorLineMarkupNodeType(JetBrains.ReSharper.Psi.Razor.Parsing.IRazorTokenNodeTypes tokenTypes, int index) { }
            public override JetBrains.ReSharper.Psi.Razor.Impl.Tree.RazorLineMarkup Create() { }
        }
        public class RazorModelDirectiveNodeType : JetBrains.ReSharper.Psi.Razor.Tree.RazorElementTypes.RazorCompositeNodeType<JetBrains.ReSharper.Psi.Razor.Impl.Tree.Mvc.RazorModelDirective>
        {
            public RazorModelDirectiveNodeType(JetBrains.ReSharper.Psi.Razor.Parsing.IRazorTokenNodeTypes tokenTypes, int index) { }
            public override JetBrains.ReSharper.Psi.Razor.Impl.Tree.Mvc.RazorModelDirective Create() { }
        }
        public class RazorNamespaceImportNodeType : JetBrains.ReSharper.Psi.Razor.Tree.RazorElementTypes.RazorCompositeNodeType<JetBrains.ReSharper.Psi.Razor.Impl.Tree.RazorNamespaceImport>
        {
            public RazorNamespaceImportNodeType(JetBrains.ReSharper.Psi.Razor.Parsing.IRazorTokenNodeTypes tokenTypes, int index) { }
            public override JetBrains.ReSharper.Psi.Razor.Impl.Tree.RazorNamespaceImport Create() { }
        }
        public class RazorReservedKeywordNodeType : JetBrains.ReSharper.Psi.Razor.Tree.RazorElementTypes.RazorCompositeNodeType<JetBrains.ReSharper.Psi.Razor.Impl.Tree.RazorReservedKeyword>
        {
            public RazorReservedKeywordNodeType(JetBrains.ReSharper.Psi.Razor.Parsing.IRazorTokenNodeTypes tokenTypes, int index) { }
            public override JetBrains.ReSharper.Psi.Razor.Impl.Tree.RazorReservedKeyword Create() { }
        }
        public class RazorSectionNodeType : JetBrains.ReSharper.Psi.Razor.Tree.RazorElementTypes.RazorCompositeNodeType<JetBrains.ReSharper.Psi.Razor.Impl.Tree.RazorSection>
        {
            public RazorSectionNodeType(JetBrains.ReSharper.Psi.Razor.Parsing.IRazorTokenNodeTypes tokenTypes, int index) { }
            public override JetBrains.ReSharper.Psi.Razor.Impl.Tree.RazorSection Create() { }
        }
        public class RazorStatementNodeType : JetBrains.ReSharper.Psi.Razor.Tree.RazorElementTypes.RazorCompositeNodeType<JetBrains.ReSharper.Psi.Razor.Impl.Tree.RazorStatement>
        {
            public RazorStatementNodeType(JetBrains.ReSharper.Psi.Razor.Parsing.IRazorTokenNodeTypes tokenTypes, int index) { }
            public override JetBrains.ReSharper.Psi.Razor.Impl.Tree.RazorStatement Create() { }
        }
        public class RazorTagHeaderNodeType : JetBrains.ReSharper.Psi.Html.Tree.HtmlElementTypes.HTML_TAG_HEADER_NODE_TYPE
        {
            public RazorTagHeaderNodeType(JetBrains.ReSharper.Psi.Razor.Parsing.IRazorTokenNodeTypes tokenTypes, int index) { }
            public override JetBrains.ReSharper.Psi.Html.Impl.Tree.HtmlTagHeader Create() { }
        }
        public class RazorTagNodeType : JetBrains.ReSharper.Psi.Html.Tree.HtmlElementTypes.HTML_TAG_NODE_TYPE
        {
            public RazorTagNodeType(JetBrains.ReSharper.Psi.Razor.Parsing.IRazorTokenNodeTypes tokenTypes, int index) { }
            public override JetBrains.ReSharper.Psi.Html.Impl.Tree.HtmlTag Create() { }
        }
        public class RazorTemplateNodeType : JetBrains.ReSharper.Psi.Razor.Tree.RazorElementTypes.RazorCompositeNodeType<JetBrains.ReSharper.Psi.Razor.Impl.Tree.RazorTemplate>
        {
            public RazorTemplateNodeType(JetBrains.ReSharper.Psi.Razor.Parsing.IRazorTokenNodeTypes tokenTypes, int index) { }
            public override JetBrains.ReSharper.Psi.Razor.Impl.Tree.RazorTemplate Create() { }
        }
    }
    public abstract class RazorTreeVisitor<TContext, TReturn> : JetBrains.ReSharper.Psi.Html.Tree.IInheritedLanguageHtmlTreeVisitor<TContext, TReturn>
    
    
    {
        protected RazorTreeVisitor(JetBrains.ReSharper.Psi.Html.Tree.HtmlTreeVisitor<TContext, TReturn> baseVisitor) { }
        public JetBrains.ReSharper.Psi.Html.Tree.HtmlTreeVisitor<TContext, TReturn> BaseVisitor { get; }
        public virtual TReturn VisitRazorBaseType(JetBrains.ReSharper.Psi.Razor.Tree.IRazorBaseTypeDirective node, TContext context) { }
        public virtual TReturn VisitRazorBlockMarkup(JetBrains.ReSharper.Psi.Razor.Tree.IRazorBlockMarkup node, TContext context) { }
        public virtual TReturn VisitRazorCode(JetBrains.ReSharper.Psi.Razor.Tree.IRazorCode node, TContext context) { }
        public virtual TReturn VisitRazorComment(JetBrains.ReSharper.Psi.Razor.Tree.IRazorComment node, TContext context) { }
        public virtual TReturn VisitRazorFunctionsBlock(JetBrains.ReSharper.Psi.Razor.Tree.IRazorFunctionsBlock node, TContext context) { }
        public virtual TReturn VisitRazorHelper(JetBrains.ReSharper.Psi.Razor.Tree.IRazorHelper node, TContext context) { }
        public virtual TReturn VisitRazorHtmlMarkup(JetBrains.ReSharper.Psi.Razor.Tree.IRazorHtmlMarkup node, TContext context) { }
        public virtual TReturn VisitRazorImplicitExpression(JetBrains.ReSharper.Psi.Razor.Tree.IRazorImplicitExpression node, TContext context) { }
        public virtual TReturn VisitRazorInclude(JetBrains.ReSharper.Psi.Razor.Tree.IRazorInclude node, TContext context) { }
        public virtual TReturn VisitRazorLineMarkup(JetBrains.ReSharper.Psi.Razor.Tree.IRazorLineMarkup node, TContext context) { }
        public virtual TReturn VisitRazorNamespace(JetBrains.ReSharper.Psi.Razor.Tree.IRazorNamespaceImport node, TContext context) { }
        public virtual TReturn VisitRazorSection(JetBrains.ReSharper.Psi.Razor.Tree.IRazorSection node, TContext context) { }
        public virtual TReturn VisitRazorStatement(JetBrains.ReSharper.Psi.Razor.Tree.IRazorStatement node, TContext context) { }
        public virtual TReturn VisitRazorTemplate(JetBrains.ReSharper.Psi.Razor.Tree.IRazorTemplate node, TContext context) { }
        public virtual TReturn VisitRazorWrapper(JetBrains.ReSharper.Psi.Razor.Tree.IRazorWrapper node, TContext context) { }
    }
    public class static RazorTreeVisitorExtensions
    {
        public static JetBrains.ReSharper.Psi.Razor.Tree.RazorTreeVisitor<TContext, TReturn> ToRazor<TContext, TReturn>(this JetBrains.ReSharper.Psi.Html.Tree.HtmlTreeVisitor<TContext, TReturn> visitor) { }
    }
}
namespace JetBrains.ReSharper.Psi.Razor.Utils
{
    
    public class RazorAddHandlerCookie { }
    public class static RazorModificationUtil
    {
        public static TNode AddAtStart<TNode>(JetBrains.ReSharper.Psi.Razor.Tree.IRazorFile file, TNode what)
            where TNode : JetBrains.ReSharper.Psi.Tree.ITreeNode { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static T AddChildAfter<T>([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode anchor, [JetBrains.Annotations.NotNullAttribute()] T child)
            where T : JetBrains.ReSharper.Psi.Tree.ITreeNode { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static T AddChildBefore<T>([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode anchor, [JetBrains.Annotations.NotNullAttribute()] T child)
            where T : JetBrains.ReSharper.Psi.Tree.ITreeNode { }
        public static TRazorNode AddDirectiveAfter<TRazorNode>(this JetBrains.ReSharper.Psi.Razor.Tree.IRazorFile file, TRazorNode directive, JetBrains.ReSharper.Psi.Tree.ITreeNode anchor, bool alwaysAddEol = True)
            where TRazorNode : JetBrains.ReSharper.Psi.Razor.Tree.IRazorTreeNode { }
        public static JetBrains.ReSharper.Psi.Razor.Tree.IRazorInheritsDirective AddInheritsDirectiveAfter(this JetBrains.ReSharper.Psi.Razor.Tree.IRazorFile file, JetBrains.ReSharper.Psi.Razor.Tree.IRazorInheritsDirective directive, JetBrains.ReSharper.Psi.Tree.ITreeNode anchor, bool alwaysAddEol = True) { }
        public static JetBrains.ReSharper.Psi.Razor.Tree.IRazorNamespaceImport AddNamespaceImport(this JetBrains.ReSharper.Psi.Razor.Tree.IRazorFile file, JetBrains.ReSharper.Psi.Razor.Tree.IRazorNamespaceImport directive) { }
        public static JetBrains.ReSharper.Psi.Razor.Tree.IRazorNamespaceImport AddNamespaceImportAfter(this JetBrains.ReSharper.Psi.Razor.Tree.IRazorFile file, JetBrains.ReSharper.Psi.Razor.Tree.IRazorNamespaceImport directive, JetBrains.ReSharper.Psi.Tree.ITreeNode anchor) { }
        public static JetBrains.ReSharper.Psi.Razor.Tree.IRazorNamespaceImport AddNamespaceImportBefore(this JetBrains.ReSharper.Psi.Razor.Tree.IRazorFile file, JetBrains.ReSharper.Psi.Razor.Tree.IRazorNamespaceImport directive, JetBrains.ReSharper.Psi.Tree.ITreeNode anchor) { }
        public static void BreakHtmlRangesIfNeeded(JetBrains.ReSharper.Psi.Razor.Tree.IRazorFile file, JetBrains.ReSharper.Psi.TreeOffset offset) { }
        public static JetBrains.ReSharper.Psi.Tree.ITreeNode GetAnchorAfterBaseTypeDirective(this JetBrains.ReSharper.Psi.Razor.Tree.IRazorBaseTypeDirective baseTypeDirective) { }
        public static JetBrains.ReSharper.Psi.Tree.ITreeNode GetAnchorAfterNamespaceImport(this JetBrains.ReSharper.Psi.Razor.Tree.IRazorNamespaceImport namespaceImport) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.ReSharper.Psi.Razor.Tree.IRazorFile GetRazorFile([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Tree.ITreeNode treeNode) { }
        public static bool IsHtmlContext(this JetBrains.ReSharper.Psi.Tree.ITreeNode parent) { }
        public static void RemoveNamespaceImport(this JetBrains.ReSharper.Psi.Razor.Tree.IRazorFile file, JetBrains.ReSharper.Psi.Razor.Tree.IRazorNamespaceImport directive) { }
    }
    public class static RazorTreeExtensions
    {
        public static bool ContainsExclusive([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.TreeTextRange treeTextRange, JetBrains.ReSharper.Psi.TreeOffset offset) { }
    }
    public class static RazorTreeUtil
    {
        public static short GetChildRole(JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.TreeElement child, JetBrains.ReSharper.Psi.Razor.Parsing.IRazorTokenNodeTypes nodeTypes) { }
        public static JetBrains.ReSharper.Psi.ITreeRange GetContentRange([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.ICompositeElement element, params short[] skipRoles) { }
        public static int GetParenthesisBalance([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Razor.Tree.IRazorCode code) { }
        public static JetBrains.ReSharper.Psi.Tree.IChameleonNode ReSync(JetBrains.ReSharper.Psi.Tree.IChameleonNode chameleon, System.Func<JetBrains.ReSharper.Psi.Tree.IChameleonNode> resync) { }
    }
}