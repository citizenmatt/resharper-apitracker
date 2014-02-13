[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]

namespace JetBrains.ReSharper.Intentions.JavaScript.ContextActions
{
    
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Adds braces around if/else/for/do/while/with statement body", Group="JavaScript", Name="Add braces")]
    public class AddBracesAction : JetBrains.ReSharper.Intentions.Extensibility.ContextActionBase
    {
        public AddBracesAction(JetBrains.ReSharper.Feature.Services.JavaScript.Bulbs.IJavaScriptContextActionDataProvider provider) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator pi) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Add xml-doc comments", Group="JavaScript", Name="Add xml-doc comments")]
    public class AddDocCommentAction : JetBrains.ReSharper.Intentions.JavaScript.ContextActions.DocCommentActionBase
    {
        public AddDocCommentAction(JetBrains.ReSharper.Feature.Services.JavaScript.Bulbs.IJavaScriptContextActionDataProvider provider) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Add xml comment reference to the file where the referenced symbol is declared", Group="JavaScript", Name="Add Xml Comment Reference")]
    public class AddReferenceAction : JetBrains.ReSharper.Intentions.Extensibility.IContextAction
    {
        public AddReferenceAction(JetBrains.ReSharper.Feature.Services.JavaScript.Bulbs.IJavaScriptContextActionDataProvider dataProvider) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        public bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Computes value of the current experssion and replace it (e.g. 1 + 1 replaced by 2" +
        ")", Group="JavaScript", Name="Compute constant value", Priority=15)]
    public class ComputeConstantValueAction : JetBrains.ReSharper.Intentions.Extensibility.ContextActionBase
    {
        public ComputeConstantValueAction(JetBrains.ReSharper.Feature.Services.JavaScript.Bulbs.IJavaScriptContextActionDataProvider provider) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public abstract class ConvertNumericBaseAction : JetBrains.ReSharper.Intentions.Extensibility.ContextActionBase
    {
        protected ConvertNumericBaseAction(JetBrains.ReSharper.Feature.Services.JavaScript.Bulbs.IJavaScriptContextActionDataProvider provider) { }
        [JetBrains.Annotations.NotNullAttribute()]
        protected abstract string CreateReplacement(int value);
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
        protected abstract bool IsAvailableImpl([JetBrains.Annotations.NotNullAttribute()] string literalValue, out int value);
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Converts numeric literal from decimal to hexadecimal form", Group="JavaScript", Name="Convert to hex", Priority=15)]
    public class DecToHexAction : JetBrains.ReSharper.Intentions.JavaScript.ContextActions.ConvertNumericBaseAction
    {
        public DecToHexAction(JetBrains.ReSharper.Feature.Services.JavaScript.Bulbs.IJavaScriptContextActionDataProvider provider) { }
        public override string Text { get; }
        protected override string CreateReplacement(int value) { }
        protected override bool IsAvailableImpl(string literalValue, out int value) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Converts numeric literal from decimal to octal form", Group="JavaScript", Name="Convert to oct", Priority=15)]
    public class DecToOctAction : JetBrains.ReSharper.Intentions.JavaScript.ContextActions.ConvertNumericBaseAction
    {
        public DecToOctAction(JetBrains.ReSharper.Feature.Services.JavaScript.Bulbs.IJavaScriptContextActionDataProvider provider) { }
        public override string Text { get; }
        protected override string CreateReplacement(int value) { }
        protected override bool IsAvailableImpl(string literalValue, out int value) { }
    }
    public abstract class DocCommentActionBase : JetBrains.ReSharper.Intentions.Extensibility.ContextActionBase
    {
        protected readonly JetBrains.ReSharper.Feature.Services.JavaScript.Bulbs.IJavaScriptContextActionDataProvider myProvider;
        protected DocCommentActionBase(JetBrains.ReSharper.Feature.Services.JavaScript.Bulbs.IJavaScriptContextActionDataProvider provider) { }
        protected void DoWork(JetBrains.ReSharper.Psi.JavaScript.Tree.IFunctionExpression function) { }
        protected static System.Action<JetBrains.TextControl.ITextControl> HotSpotsForEmptyTags(JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptDocCommentBlockNode block) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Flips left and right arguments for selected operator e.g. null == x to x == null." +
        "", Group="JavaScript", Name="Flip an operator arguments", Priority=-15)]
    public class FlipOperatorArgumentsAction : JetBrains.ReSharper.Intentions.Extensibility.ContextActionBase
    {
        public FlipOperatorArgumentsAction(JetBrains.ReSharper.Feature.Services.JavaScript.Bulbs.IJavaScriptContextActionDataProvider provider) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Flips the current relational expression e.g. x > 1 to x < 1.", Group="JavaScript", Name="Flip an relational expression", Priority=-15)]
    public class FlipRelationalExpressionAction : JetBrains.ReSharper.Intentions.Extensibility.ContextActionBase
    {
        public FlipRelationalExpressionAction(JetBrains.ReSharper.Feature.Services.JavaScript.Bulbs.IJavaScriptContextActionDataProvider provider) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Converts ECMAScript 5 get-accessor to simple property", Group="JavaScript", Name="Convert object literal get-accessor to simple property")]
    public class GetAccessorToPropertyAction : JetBrains.ReSharper.Intentions.Extensibility.ContextActionBase
    {
        public GetAccessorToPropertyAction(JetBrains.ReSharper.Feature.Services.JavaScript.Bulbs.IJavaScriptContextActionDataProvider provider) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Converts numeric literal from hexadecimal to decimal form", Group="JavaScript", Name="Convert to dec", Priority=15)]
    public class HexToDecAction : JetBrains.ReSharper.Intentions.JavaScript.ContextActions.ConvertNumericBaseAction
    {
        public HexToDecAction(JetBrains.ReSharper.Feature.Services.JavaScript.Bulbs.IJavaScriptContextActionDataProvider provider) { }
        public override string Text { get; }
        protected override string CreateReplacement(int value) { }
        protected override bool IsAvailableImpl(string literalValue, out int value) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Merges two nested \'if\' statements to a single \'if\' statement that checks conjunct" +
        "ion of the original conditions.", Group="JavaScript", Name="Merge nested \'if\' statements")]
    public class IfAndMergeAction : JetBrains.ReSharper.Intentions.JavaScript.ContextActions.IfMergeActionBase
    {
        public IfAndMergeAction(JetBrains.ReSharper.Feature.Services.JavaScript.Bulbs.IJavaScriptContextActionDataProvider provider) { }
        protected override bool CanMergeIfs(JetBrains.ReSharper.Psi.JavaScript.Tree.IIfStatement groundIf, JetBrains.ReSharper.Psi.JavaScript.Tree.IIfStatement upperIf) { }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        protected override JetBrains.ReSharper.Psi.JavaScript.Tree.IBlock GetBranchBlock(JetBrains.ReSharper.Psi.JavaScript.Tree.IIfStatement upperIf) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
        protected override JetBrains.ReSharper.Psi.JavaScript.Tree.IIfStatement OuterStatementNavigator(JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatement statement) { }
    }
    public abstract class IfMergeActionBase : JetBrains.ReSharper.Intentions.Extensibility.ContextActionBase
    {
        protected readonly JetBrains.ReSharper.Feature.Services.JavaScript.Bulbs.IJavaScriptContextActionDataProvider Provider;
        protected IfMergeActionBase(JetBrains.ReSharper.Feature.Services.JavaScript.Bulbs.IJavaScriptContextActionDataProvider provider) { }
        public override string Text { get; }
        protected virtual bool CanMergeIfs([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IIfStatement groundIf, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IIfStatement upperIf) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        protected JetBrains.ReSharper.Psi.JavaScript.Tree.IBlock CheckInnerAsLastStatement([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IIfStatement groundIf, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IIfStatement upperIf) { }
        protected static void CopyStatementsToUpperBlock([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatement statementsSource, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatementsRange toMove) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        protected JetBrains.ReSharper.Psi.JavaScript.Tree.IIfStatement FindInnerIfStatement() { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        protected JetBrains.ReSharper.Psi.JavaScript.Tree.IIfStatement FindOuterIfStatement(JetBrains.ReSharper.Psi.JavaScript.Tree.IIfStatement innerIfStatement) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        protected abstract JetBrains.ReSharper.Psi.JavaScript.Tree.IBlock GetBranchBlock(JetBrains.ReSharper.Psi.JavaScript.Tree.IIfStatement upperIf);
        protected static bool NotAffectedByIf(JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatement statement) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        protected abstract JetBrains.ReSharper.Psi.JavaScript.Tree.IIfStatement OuterStatementNavigator([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatement statement);
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Merges \'if\' statement with nested \'if\' statement in else branch with equal body t" +
        "o a single \'if\' statement that checks disjunction of the original conditions.", Group="JavaScript", Name="Merge two \'if\' statements")]
    public class IfOrMergeAction : JetBrains.ReSharper.Intentions.JavaScript.ContextActions.IfMergeActionBase
    {
        public IfOrMergeAction(JetBrains.ReSharper.Feature.Services.JavaScript.Bulbs.IJavaScriptContextActionDataProvider provider) { }
        protected override bool CanMergeIfs(JetBrains.ReSharper.Psi.JavaScript.Tree.IIfStatement groundIf, JetBrains.ReSharper.Psi.JavaScript.Tree.IIfStatement upperIf) { }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        protected override JetBrains.ReSharper.Psi.JavaScript.Tree.IBlock GetBranchBlock(JetBrains.ReSharper.Psi.JavaScript.Tree.IIfStatement upperIf) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
        protected override JetBrains.ReSharper.Psi.JavaScript.Tree.IIfStatement OuterStatementNavigator(JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatement statement) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Works on \'if\' statement that returns value or performs assignment inside each bra" +
        "nch. It converts the statement to a ternary expression (\'x ? a : b\')", Group="JavaScript", Name="Convert \'if\' statement to ternary expression")]
    public class IfToTernaryAction : JetBrains.ReSharper.Intentions.Extensibility.ContextActionBase
    {
        public IfToTernaryAction(JetBrains.ReSharper.Feature.Services.JavaScript.Bulbs.IJavaScriptContextActionDataProvider provider) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Introduces variable from expression statement", Group="JavaScript", Name="Introduce variable from expression statement", Priority=5)]
    public class IntroduceVariableAction : JetBrains.ReSharper.Intentions.Extensibility.ContextActionBase
    {
        public IntroduceVariableAction(JetBrains.ReSharper.Feature.Services.JavaScript.Bulbs.IJavaScriptContextActionDataProvider dataProvider) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Inverts guard condition of an \'if\' statement and swaps the branches\' code accordi" +
        "ngly", Group="JavaScript", Name="Invert \'if\' statement")]
    public class InvertIfAction : JetBrains.ReSharper.Intentions.Extensibility.ContextActionBase
    {
        public InvertIfAction(JetBrains.ReSharper.Feature.Services.JavaScript.Bulbs.IJavaScriptContextActionDataProvider provider) { }
        public override string Text { get; }
        public static void Execute([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IIfStatement ifStatement, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.ControlFlow.IJsControlFlowGraf graf) { }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Inverts logical expression", Group="JavaScript", Name="Invert logical expression")]
    public class InvertLogicalExpressionAction : JetBrains.ReSharper.Intentions.Extensibility.ContextActionBase
    {
        public InvertLogicalExpressionAction(JetBrains.ReSharper.Feature.Services.JavaScript.Bulbs.IJavaScriptContextActionDataProvider provider) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression GetParentThroughParenthesis(JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression toTestExpr) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression GetTopBooleanExpression([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression booleanExpr) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
        public static bool IsBooleanExpression([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression expression) { }
        public static bool IsBooleanExpression([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression expression, JetBrains.ReSharper.Intentions.JavaScript.ContextActions.InvertLogicalExpressionAction.ParenthesisCheck dir) { }
        public enum ParenthesisCheck
        {
            UP = 0,
            DOWN = 1,
        }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Inverts condition and swaps branches of a ternary expression", Group="JavaScript", Name="Invert ternary condition")]
    public class InvertTernaryAction : JetBrains.ReSharper.Intentions.Extensibility.ContextActionBase
    {
        public InvertTernaryAction(JetBrains.ReSharper.Feature.Services.JavaScript.Bulbs.IJavaScriptContextActionDataProvider provider) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class static JavaScriptContextActions
    {
        public const string GroupID = "JavaScript";
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Concatenates two string literals into one", Group="JavaScript", Name="Join string literals")]
    public class JoinStringLiteralsAction : JetBrains.ReSharper.Intentions.Extensibility.ContextActionBase
    {
        public JoinStringLiteralsAction(JetBrains.ReSharper.Feature.Services.JavaScript.Bulbs.IJavaScriptContextActionDataProvider provider) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Replaces a conditional expression with an inverted negative, e.g. converts x > 1 " +
        "to !(x <= 1).", Group="JavaScript", Name="Invert relational operator and negate condition", Priority=15)]
    public class NegateRelationalAction : JetBrains.ReSharper.Intentions.Extensibility.ContextActionBase
    {
        public NegateRelationalAction(JetBrains.ReSharper.Feature.Services.JavaScript.Bulbs.IJavaScriptContextActionDataProvider provider) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Converts numeric literal from octal to decimal form", Group="JavaScript", Name="Convert to dec", Priority=15)]
    public class OctToDecAction : JetBrains.ReSharper.Intentions.JavaScript.ContextActions.ConvertNumericBaseAction
    {
        public OctToDecAction(JetBrains.ReSharper.Feature.Services.JavaScript.Bulbs.IJavaScriptContextActionDataProvider provider) { }
        public override string Text { get; }
        protected override string CreateReplacement(int value) { }
        protected override bool IsAvailableImpl(string literalValue, out int value) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Converts object literal property to ECMAScript 5 accessors pair with backing fiel" +
        "d", Group="JavaScript", Name="Convert object literal property to accessors pair with backing field")]
    public class PropertyToAccessorsAction : JetBrains.ReSharper.Intentions.Extensibility.ContextActionBase
    {
        public PropertyToAccessorsAction(JetBrains.ReSharper.Feature.Services.JavaScript.Bulbs.IJavaScriptContextActionDataProvider provider) { }
        public override string Text { get; }
        public static System.Action<JetBrains.TextControl.ITextControl> CreateRenameHotspot(JetBrains.ProjectModel.ISolution solution, System.Collections.Generic.IList<string> suggestions, JetBrains.Util.TextRange endRange, params JetBrains.DocumentModel.DocumentRange[] ranges) { }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Collections.Generic.IList<string> GetLocalNameSuggestions(JetBrains.ReSharper.Psi.Naming.NamingManager manager, JetBrains.ReSharper.Psi.Tree.ITreeNode context, string fieldName, JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Converts object literal property to ECMAScript 5 get-accessor", Group="JavaScript", Name="Convert object literal property to get-accessor")]
    public class PropertyToGetAccessorAction : JetBrains.ReSharper.Intentions.Extensibility.ContextActionBase
    {
        public PropertyToGetAccessorAction(JetBrains.ReSharper.Feature.Services.JavaScript.Bulbs.IJavaScriptContextActionDataProvider provider) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Removes unneccessary braces around one or more statements in the code", Group="JavaScript", Name="Remove braces")]
    public class RemoveBracesAction : JetBrains.ReSharper.Intentions.Extensibility.ContextActionBase
    {
        public RemoveBracesAction(JetBrains.ReSharper.Feature.Services.JavaScript.Bulbs.IJavaScriptContextActionDataProvider dataProvider) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator pi) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Removes parenthesis in case they are redundant", Group="JavaScript", Name="Remove redundant parenthesis")]
    public class RemoveParenthesisAction : JetBrains.ReSharper.Intentions.Extensibility.ContextActionBase
    {
        public RemoveParenthesisAction(JetBrains.ReSharper.Feature.Services.JavaScript.Bulbs.IJavaScriptContextActionDataProvider provider) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Replace single-quoted string literal with double-quoted and vice versa", Group="JavaScript", Name="Replace single-quoted string literal with double-quoted")]
    public class ReplaceStringLiteralQuotesAction : JetBrains.ReSharper.Intentions.Extensibility.ContextActionBase
    {
        public ReplaceStringLiteralQuotesAction(JetBrains.ReSharper.Feature.Services.JavaScript.Bulbs.IJavaScriptContextActionDataProvider provider) { }
        public override string Text { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptLiteralExpression Execute([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode token) { }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
        [JetBrains.Annotations.PureAttribute()]
        public static bool IsSingleQuoted([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode token) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Reverses source and destination parts of an assignment statement.", Group="JavaScript", Name="Reverse assignment statement")]
    public class ReverseAssignmentAction : JetBrains.ReSharper.Intentions.Extensibility.ContextActionBase
    {
        public ReverseAssignmentAction(JetBrains.ReSharper.Feature.Services.JavaScript.Bulbs.IJavaScriptContextActionDataProvider dataProvider) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator pi) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public abstract class SplitActionBase : JetBrains.ReSharper.Intentions.Extensibility.ContextActionBase
    {
        protected readonly JetBrains.ReSharper.Feature.Services.JavaScript.Bulbs.IJavaScriptContextActionDataProvider Provider;
        protected SplitActionBase(JetBrains.ReSharper.Feature.Services.JavaScript.Bulbs.IJavaScriptContextActionDataProvider provider) { }
        [JetBrains.Annotations.NotNullAttribute()]
        protected JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression BuildLeftCondition([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Services.JavaScriptElementFactory factory, [JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression> expressions, [JetBrains.Annotations.NotNullAttribute()] string sign) { }
        [JetBrains.Annotations.NotNullAttribute()]
        protected JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression BuildRightCondition([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Services.JavaScriptElementFactory factory, [JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression> expressions, [JetBrains.Annotations.NotNullAttribute()] string sign) { }
        [JetBrains.Annotations.NotNullAttribute()]
        protected static System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression> CollectExpressions(JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression expression, JetBrains.ReSharper.Psi.Parsing.TokenNodeType sign, System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression> consumer = null) { }
        protected static bool IsCursorAtAndSign(JetBrains.ReSharper.Psi.JavaScript.Tree.IBinaryExpression condition, JetBrains.ReSharper.Psi.TreeOffset offset, JetBrains.ReSharper.Psi.Parsing.TokenNodeType sign) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Works on an \'if\' statement, which condition is a conjunction (\'&&\') of two simple" +
        "r conditions. It converts the \'if\' statement into two nested \'if\' statements.", Group="JavaScript", Name="Split \'if\' with \'&&\'-condition into nested \'if\'-statements")]
    public class SplitAndInIfAction : JetBrains.ReSharper.Intentions.JavaScript.ContextActions.SplitActionBase
    {
        public SplitAndInIfAction(JetBrains.ReSharper.Feature.Services.JavaScript.Bulbs.IJavaScriptContextActionDataProvider provider) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        protected JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression FindIfStatementCondition(out JetBrains.ReSharper.Psi.JavaScript.Tree.IIfStatement ifStatement) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Works on a \'return\' statement, which condition is a conjunction (\'&&\') of two sim" +
        "pler conditions. It converts the \'return\' statement into a guarding \'if\' stateme" +
        "nt and a \'return\'.", Group="JavaScript", Name="Split \'return\' with \'&&\'-condition into guarding \'if\' and \'return\'")]
    public class SplitAndInReturnAction : JetBrains.ReSharper.Intentions.JavaScript.ContextActions.SplitActionBase
    {
        public SplitAndInReturnAction(JetBrains.ReSharper.Feature.Services.JavaScript.Bulbs.IJavaScriptContextActionDataProvider provider) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        protected JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression FindReturnStatementValue(out JetBrains.ReSharper.Psi.JavaScript.Tree.IReturnStatement returnStatement) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Moves variable initializer from declaration statement to separate assignment stat" +
        "ement.", Group="JavaScript", Name="Split variable declaration and assignment")]
    public class SplitDeclarationAction : JetBrains.ReSharper.Intentions.Extensibility.ContextActionBase
    {
        public SplitDeclarationAction(JetBrains.ReSharper.Feature.Services.JavaScript.Bulbs.IJavaScriptContextActionDataProvider dataProvider) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Works on variable declaration statement that declares multiple variables. It spli" +
        "ts such statement into multiple statements each declaring a single variable.", Group="JavaScript", Name="Split into separate declarations")]
    public class SplitDeclarationsListAction : JetBrains.ReSharper.Intentions.Extensibility.ContextActionBase
    {
        public SplitDeclarationsListAction(JetBrains.ReSharper.Feature.Services.JavaScript.Bulbs.IJavaScriptContextActionDataProvider dataProvider) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator pi) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Works on an \'if\' statement, which condition is a disjunction (\'||\') of two simple" +
        "r conditions. It converts the \'if\' statement into an assignment to a temporary v" +
        "ariable and an two \'if\' statements.", Group="JavaScript", Name="Split \'if\' with \'||\'-condition into assigment to temporary variable and two \'if\'-" +
        "statements")]
    public class SplitOrInIfAction : JetBrains.ReSharper.Intentions.JavaScript.ContextActions.SplitActionBase
    {
        public SplitOrInIfAction(JetBrains.ReSharper.Feature.Services.JavaScript.Bulbs.IJavaScriptContextActionDataProvider provider) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        protected JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression FindIfStatementCondition(out JetBrains.ReSharper.Psi.JavaScript.Tree.IIfStatement ifStatement) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Works on an \'return\' statement, which condition is a disjunction (\'||\') of two si" +
        "mpler conditions. It converts the \'return\' statement into an assignment to a tem" +
        "porary variable, \'if\' statement and \'return\' statement.", Group="JavaScript", Name="Split \'return\' with \'||\'-condition into assigment to temporary variable, \'if\'-sta" +
        "tement and \'return\'")]
    public class SplitOrInReturnAction : JetBrains.ReSharper.Intentions.JavaScript.ContextActions.SplitActionBase
    {
        public SplitOrInReturnAction(JetBrains.ReSharper.Feature.Services.JavaScript.Bulbs.IJavaScriptContextActionDataProvider provider) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        protected JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression FindReturnStatementValue(out JetBrains.ReSharper.Psi.JavaScript.Tree.IReturnStatement returnStatement) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Converts ternary expression whose value is returned or assigned to an \'if\' statem" +
        "ent", Group="JavaScript", Name="Convert ternary expression to \'if\' statement")]
    public class TernaryToIfAction : JetBrains.ReSharper.Intentions.Extensibility.ContextActionBase
    {
        public TernaryToIfAction(JetBrains.ReSharper.Feature.Services.JavaScript.Bulbs.IJavaScriptContextActionDataProvider provider) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Converts property assignment in constructors to accessor property definition via " +
        "Object.defineProperty() call", Group="JavaScript", Name="Convert property assignment in constructors to accessor property definition with " +
        "backing field")]
    public class ToAccessorPropertyDefinitionAction : JetBrains.ReSharper.Intentions.JavaScript.ContextActions.ToPropertyDefinitionActionBase
    {
        public ToAccessorPropertyDefinitionAction(JetBrains.ReSharper.Feature.Services.JavaScript.Bulbs.IJavaScriptContextActionDataProvider provider) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> CreatePropertyDescriptor(JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Psi.JavaScript.Tree.IBinaryExpression assignment, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatement statement) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Converts property assignment in constructors to data property definition via Obje" +
        "ct.defineProperty() call", Group="JavaScript", Name="Convert property assignment in constructors to data property definition")]
    public class ToDataPropertyDefinitionAction : JetBrains.ReSharper.Intentions.JavaScript.ContextActions.ToPropertyDefinitionActionBase
    {
        public ToDataPropertyDefinitionAction(JetBrains.ReSharper.Feature.Services.JavaScript.Bulbs.IJavaScriptContextActionDataProvider provider) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> CreatePropertyDescriptor(JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Psi.JavaScript.Tree.IBinaryExpression assignment, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatement statement) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Converts property assignment in constructors to get-accessor property definition " +
        "via Object.defineProperty() call", Group="JavaScript", Name="Convert property assignment in constructors to get-accessor property definition")]
    public class ToGetAccessorPropertyDefinitionAction : JetBrains.ReSharper.Intentions.JavaScript.ContextActions.ToPropertyDefinitionActionBase
    {
        public ToGetAccessorPropertyDefinitionAction(JetBrains.ReSharper.Feature.Services.JavaScript.Bulbs.IJavaScriptContextActionDataProvider provider) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> CreatePropertyDescriptor(JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Psi.JavaScript.Tree.IBinaryExpression assignment, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatement statement) { }
    }
    public abstract class ToPropertyDefinitionActionBase : JetBrains.ReSharper.Intentions.Extensibility.ContextActionBase
    {
        protected readonly JetBrains.ReSharper.Feature.Services.JavaScript.Bulbs.IJavaScriptContextActionDataProvider Provider;
        protected ToPropertyDefinitionActionBase(JetBrains.ReSharper.Feature.Services.JavaScript.Bulbs.IJavaScriptContextActionDataProvider provider) { }
        protected abstract System.Action<JetBrains.TextControl.ITextControl> CreatePropertyDescriptor([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.ISolution solution, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IBinaryExpression assignment, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatement statement);
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        protected JetBrains.ReSharper.Psi.JavaScript.Tree.IBinaryExpression FindConstructorFieldAssign(out JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatement statement) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
}
namespace JetBrains.ReSharper.Intentions.JavaScript.ContextActions.CreateFromUsage
{
    
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Creates property, function, local variable or parameter from usage", Group="JavaScript", Name="Create From Usage")]
    public class CreateFromUsageAction : JetBrains.ReSharper.Intentions.Extensibility.IContextAction
    {
        public CreateFromUsageAction(JetBrains.ReSharper.Feature.Services.JavaScript.Bulbs.IJavaScriptContextActionDataProvider dataProvider) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        public bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class CreateFromUsageContextProviders
    {
        public CreateFromUsageContextProviders(JetBrains.DataFlow.Lifetime lifetime, JetBrains.DataFlow.IViewable<JetBrains.ReSharper.Intentions.JavaScript.ContextActions.CreateFromUsage.ICreatePropertyFromUsageContextProvier> providers) { }
        public System.Collections.Generic.ICollection<JetBrains.ReSharper.Intentions.JavaScript.ContextActions.CreateFromUsage.IJsCreateFromUsageBulbItem> ProvideContexts(JetBrains.ReSharper.Psi.JavaScript.Resolve.FullJavaScriptType type, JetBrains.ReSharper.Intentions.JavaScript.ContextActions.CreateFromUsage.UsageInfo usageInfo) { }
    }
    public class static CreateFromUsageUtil
    {
        public static string GetObjectLocationPresentation(JetBrains.ReSharper.Psi.Tree.ITreeNode expression) { }
        public static string GetObjectLocationPresentationStructured(JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression expression) { }
    }
    public class CreatePropertyFromUsageItem : JetBrains.ReSharper.Intentions.Extensibility.BulbActionBase, JetBrains.ReSharper.Intentions.JavaScript.ContextActions.CreateFromUsage.IJsCreateFromUsageBulbItem
    {
        public CreatePropertyFromUsageItem(JetBrains.ReSharper.Intentions.JavaScript.ContextActions.CreateFromUsage.ICreatePropertyFromUsageContext context, JetBrains.ReSharper.Intentions.JavaScript.ContextActions.CreateFromUsage.UsageInfo usageInfo) { }
        public JetBrains.ProjectModel.IProjectFile ProjectFile { get; }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
    }
    public interface ICreatePropertyFromUsageContext
    {
        int Line { get; }
        string LocationText { get; }
        string PresentationTextTemplate { get; }
        JetBrains.ProjectModel.IProjectFile ProjectFile { get; }
        System.Action<JetBrains.TextControl.ITextControl> CreateProperty(JetBrains.ReSharper.Intentions.JavaScript.ContextActions.CreateFromUsage.UsageInfo usageInfo);
    }
    public interface ICreatePropertyFromUsageContextProvier
    {
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.JavaScript.ContextActions.CreateFromUsage.IJsCreateFromUsageBulbItem> ProvideContexts(JetBrains.ReSharper.Intentions.JavaScript.ContextActions.CreateFromUsage.CreateFromUsageContextProviders providers, JetBrains.ReSharper.Psi.JavaScript.Resolve.FullJavaScriptType type, JetBrains.ReSharper.Intentions.JavaScript.ContextActions.CreateFromUsage.UsageInfo usageInfo);
    }
    public interface IJsCreateFromUsageBulbItem
    {
        JetBrains.ProjectModel.IProjectFile ProjectFile { get; }
    }
    public interface IPropertyInfo
    {
        System.Collections.Generic.IList<JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression> Arguments { get; }
        bool IsMethod { get; }
        string Name { get; }
    }
    public class UsageInfo : JetBrains.ReSharper.Intentions.JavaScript.ContextActions.CreateFromUsage.IPropertyInfo
    {
        public UsageInfo(string name, bool isMethod, System.Collections.Generic.IList<JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression> arguments, JetBrains.ReSharper.Psi.JavaScript.Resolve.IReferenceExpressionReference reference, JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.JavaScriptResolveContext context) { }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression> Arguments { get; }
        public JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.JavaScriptResolveContext Context { get; }
        public object InitializerName { get; }
        public bool IsMethod { get; }
        public string Name { get; }
        public JetBrains.ReSharper.Psi.JavaScript.Resolve.IReferenceExpressionReference Reference { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public System.Action<JetBrains.TextControl.ITextControl> CreateInitializerExpression(JetBrains.ReSharper.Psi.JavaScript.Services.JavaScriptElementFactory factory, JetBrains.ReSharper.Psi.Tree.ITreeNode context, System.Func<JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression> addToUserCode) { }
        public static void SetSelection(JetBrains.DocumentModel.IRangeMarker finishRangeMarker, JetBrains.ProjectModel.ISolution solution) { }
    }
}
namespace JetBrains.ReSharper.Intentions.JavaScript.ContextActions.CreateFromUsage.TypeScript
{
    
    public class static TsCreateFromUsageUtils
    {
        public static System.Collections.Generic.IList<System.Collections.Generic.IList<string>> AddParametersToMethod(JetBrains.ReSharper.Intentions.JavaScript.ContextActions.CreateFromUsage.UsageInfo usageInfo, JetBrains.ReSharper.Psi.JavaScript.Impl.Services.TypeScript.TsElementFactory factory, JetBrains.ReSharper.Psi.Tree.ITreeNode context, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsSignatureNodeInPars signature) { }
        public static System.Action<JetBrains.TextControl.ITextControl> MakeHotSpotsForCreatedMethod(JetBrains.ReSharper.Psi.JavaScript.Impl.Services.TypeScript.TsElementFactory factory, JetBrains.ReSharper.Psi.JavaScript.Tree.IJsSignatureNodeInPars newFunction, System.Collections.Generic.IList<System.Collections.Generic.IList<string>> allSuggestions, JetBrains.DocumentModel.DocumentRange bodyOrReturnTypeRange) { }
        public static System.Action<JetBrains.TextControl.ITextControl> PositionAfterName(JetBrains.ReSharper.Psi.Tree.ITreeNode nameNode) { }
    }
}
namespace JetBrains.ReSharper.Intentions.JavaScript.ContextActions.DataProviders
{
    
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionDataBuilderAttribute(typeof(JetBrains.ReSharper.Feature.Services.JavaScript.Bulbs.IJavaScriptContextActionDataProvider))]
    public class JavaScriptContextActionDataBuilder : JetBrains.ReSharper.Feature.Services.Bulbs.IContextActionDataBuilder
    {
        public JetBrains.ReSharper.Feature.Services.Bulbs.IContextActionDataProvider Build(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
    }
}
namespace JetBrains.ReSharper.Intentions.JavaScript.ContextActions.TypeScript
{
    
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Infers type and generates interface", Group="TypeScript", Name="Change \'Any\' to type")]
    public class ChangeAnyToTypeAction : JetBrains.ReSharper.Intentions.JavaScript.QuickFixes.TypeScript.GenerateInterfaceForJsVariable.GenerateInterfaceItemBase, JetBrains.ReSharper.Intentions.Extensibility.IContextAction
    {
        public ChangeAnyToTypeAction(JetBrains.ReSharper.Feature.Services.JavaScript.Bulbs.TypeScript.ITypeScriptContextActionDataProvider provider) { }
        public override string Text { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class static TypeScriptContextActions
    {
        public const string GroupID = "TypeScript";
    }
}
namespace JetBrains.ReSharper.Intentions.JavaScript.ContextActions.TypeScript.DataProviders
{
    
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionDataBuilderAttribute(typeof(JetBrains.ReSharper.Feature.Services.JavaScript.Bulbs.TypeScript.ITypeScriptContextActionDataProvider))]
    public class TsContextActionDataBuilder : JetBrains.ReSharper.Feature.Services.Bulbs.IContextActionDataBuilder
    {
        public JetBrains.ReSharper.Feature.Services.Bulbs.IContextActionDataProvider Build(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
    }
}
namespace JetBrains.ReSharper.Intentions.JavaScript.QuickFixes
{
    
    public class AddReturnValueStatementFix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public AddReturnValueStatementFix(JetBrains.ReSharper.Daemon.JavaScript.Stages.NotAllPathsReturnValueWarning warning) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator pi) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class DeclaredVariableForFieldFix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public DeclaredVariableForFieldFix(JetBrains.ReSharper.Daemon.JavaScript.Stages.MisuseOfOwnerFunctionThisWarning warning) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class DeclareLocalVariableFix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public DeclareLocalVariableFix(JetBrains.ReSharper.Daemon.JavaScript.Stages.AssignToImplicitGlobalInFunctionScopeWarning warning) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator pi) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class ExplicitlyQualifyWithWindowFix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public ExplicitlyQualifyWithWindowFix(JetBrains.ReSharper.Daemon.JavaScript.Stages.AssignToImplicitGlobalInFunctionScopeWarning warning) { }
        public ExplicitlyQualifyWithWindowFix(JetBrains.ReSharper.Daemon.JavaScript.Stages.UseOfImplicitGlobalInFunctionScopeWarning warning) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator pi) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class MergeLocalDeclarationsFix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public MergeLocalDeclarationsFix(JetBrains.ReSharper.Daemon.JavaScript.Stages.DuplicatingLocalDeclarationWarning warning) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator pi) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class PropertyGetterCannotHaveParametersFix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public PropertyGetterCannotHaveParametersFix(JetBrains.ReSharper.Daemon.JavaScript.Stages.PropertyGetterCannotHaveParametersError error) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class PropertySetterMustHaveSingleParameterFix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public PropertySetterMustHaveSingleParameterFix(JetBrains.ReSharper.Daemon.JavaScript.Stages.PropertySetterMustHaveSingleParameterError error) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class QuoteNameFix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public QuoteNameFix(JetBrains.ReSharper.Daemon.JavaScript.Stages.UsingOfReservedWordWarning warning) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator pi) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class RemoveRedundantLocalFunctionNameFix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public RemoveRedundantLocalFunctionNameFix(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class RemoveReturnValueFix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public RemoveReturnValueFix(JetBrains.ReSharper.Daemon.JavaScript.Stages.ReturnFromGlobalScopetWithValueWarning warning) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class RemoveTrailingElements : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public RemoveTrailingElements(JetBrains.ReSharper.Daemon.JavaScript.Stages.ElidedTrailingElementWarning warning) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class RemoveUnusedParameterFix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public RemoveUnusedParameterFix(JetBrains.ReSharper.Daemon.JavaScript.Stages.UnusedParameterWarning warning) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class ReturnValueFix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public ReturnValueFix(JetBrains.ReSharper.Daemon.JavaScript.Stages.InconsistentFunctionReturnsWarning warning) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator pi) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class SpecifyElidedTrailingElements : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public SpecifyElidedTrailingElements(JetBrains.ReSharper.Daemon.JavaScript.Stages.ElidedTrailingElementWarning warning) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class TerminateStatementsFix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public TerminateStatementsFix(JetBrains.ReSharper.Daemon.JavaScript.Stages.StatementIsNotTerminatedWarning warning) { }
        public override string Text { get; }
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator pi) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
}
namespace JetBrains.ReSharper.Intentions.JavaScript.QuickFixes.DisableWarnings
{
    
    public abstract class DisableByCommentFixBase : JetBrains.ReSharper.Intentions.Extensibility.IBulbAction
    {
        protected readonly string myId;
        protected DisableByCommentFixBase(JetBrains.DocumentModel.DocumentRange range, string id) { }
        protected abstract string ClosingText { get; }
        protected abstract string OpeningText { get; }
        public abstract string Text { get; }
        public void Execute(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
    }
}
namespace JetBrains.ReSharper.Intentions.JavaScript.QuickFixes.TypeScript
{
    
    public class ConvertJsFunctionFix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public ConvertJsFunctionFix(JetBrains.ReSharper.Daemon.JavaScript.Stages.JsFunctionCanBeConvertedToLambdaWarning warning) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator pi) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
}
namespace JetBrains.ReSharper.Intentions.JavaScript.QuickFixes.TypeScript.GenerateInterfaceForJsVariable
{
    
    public class GenerateInterfaceForVariableFix : JetBrains.ReSharper.Intentions.Extensibility.IQuickFix
    {
        public GenerateInterfaceForVariableFix(JetBrains.ReSharper.Daemon.JavaScript.Stages.TsNotResolvedError error) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        public bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public abstract class GenerateInterfaceItemBase : JetBrains.ReSharper.Intentions.Extensibility.BulbActionBase
    {
        protected JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsFile TargetFile { get; set; }
        protected JetBrains.ReSharper.Psi.IPsiSourceFile TargetPsiSourceFile { get; set; }
        protected void CreateFile(JetBrains.ReSharper.Psi.IPsiSourceFile sourcePsiSourceFile, JetBrains.ReSharper.Psi.Tree.ITreeNode contextNode, string jsFilename) { }
        protected void DoGenerateInterface([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Resolve.FullJavaScriptType fullJavaScriptType, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsDeclaredTypeUsage declaredTypeUsage, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.JavaScriptResolveContext context, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsStatement anchor, JetBrains.Application.Progress.IProgressIndicator progress) { }
        protected virtual string RecursiveGenerateStub(JetBrains.ReSharper.Psi.JavaScript.Resolve.FullJavaScriptType fullJavaScriptType) { }
        protected class static TsTypeUsageForJsGlobalVariableLookupItemFactory
        {
            public static JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem CreateLookupItemByName(string nameInterface, JetBrains.ReSharper.Psi.JavaScript.Services.JavaScriptServices services, JetBrains.ReSharper.Feature.Services.Lookup.ILookupItemsOwner owner) { }
            public static JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem TryCreateLookupItemForStandartType(JetBrains.ReSharper.Feature.Services.Lookup.ILookupItemsOwner owner, JetBrains.ReSharper.Psi.JavaScript.Resolve.FullJavaScriptType fullJavaScriptType, JetBrains.ReSharper.Psi.JavaScript.Services.JavaScriptServices services) { }
        }
        protected sealed class TypeUsageHotspotExpression : JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotExpression, System.ICloneable
        {
            public TypeUsageHotspotExpression([JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IList<string> names, JetBrains.ReSharper.Psi.JavaScript.Resolve.FullJavaScriptType fullJavaScriptType, JetBrains.ReSharper.Psi.JavaScript.Services.JavaScriptServices javaScriptServices, JetBrains.TextControl.ITextControl textControl) { }
            public object Clone() { }
            public string EvaluateQuickResult(JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotContext context) { }
            public JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.HotspotItems GetLookupItems(JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotContext context) { }
            public void HandleExpansion(JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotContext context) { }
            public string Serialize() { }
        }
    }
}