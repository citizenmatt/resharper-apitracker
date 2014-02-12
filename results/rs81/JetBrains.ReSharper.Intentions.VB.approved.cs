[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]

namespace JetBrains.ReSharper.Intentions.VB.ContextActions
{
    
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Adds missing accessor to a property or any missing accessors to an event.", Group="VB", Name="Add other accessor(s)", Priority=-1)]
    public class AddOtherAccessorsAction : JetBrains.ReSharper.Intentions.Extensibility.ContextActionBase
    {
        public AddOtherAccessorsAction(JetBrains.ReSharper.Feature.Services.VB.Bulbs.IVBContextActionDataProvider dataProvider) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Replaces auto-property with property that utilizes backing field.", Group="VB", Name="Replace auto-property with backing field")]
    public class AutomaticToBackingFieldAction : JetBrains.ReSharper.Intentions.Extensibility.ContextActionBase
    {
        public AutomaticToBackingFieldAction(JetBrains.ReSharper.Feature.Services.VB.Bulbs.IVBContextActionDataProvider provider) { }
        public override string Text { get; }
        public static JetBrains.ReSharper.Psi.VB.Tree.IVariableDeclaration Execute(JetBrains.ReSharper.Psi.VB.Tree.IPropertyDeclaration propertyDeclaration) { }
        public static JetBrains.ReSharper.Psi.VB.Tree.IVariableDeclaration Execute(JetBrains.ReSharper.Psi.VB.Tree.IPropertyDeclaration propertyDeclaration, System.Action<JetBrains.ReSharper.Psi.VB.Tree.IPropertyDeclaration, JetBrains.ReSharper.Psi.IField> acessorsCreator) { }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public static string GetText() { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
        public static bool IsAvailable(JetBrains.ReSharper.Psi.VB.Tree.IPropertyDeclaration declaration) { }
        public static void PostExecute(JetBrains.ReSharper.Psi.VB.Tree.IPropertyDeclaration propertyDeclaration, JetBrains.ReSharper.Psi.VB.Tree.IVariableDeclaration fieldDeclaration, JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Replaces property that utilizes backing field with auto-property.", Group="VB", Name="Replace backing field with auto-property")]
    public class BackingFieldToAutomaticAction : JetBrains.ReSharper.Intentions.Extensibility.BulbActionBase, JetBrains.ReSharper.Intentions.Extensibility.IContextAction
    {
        public BackingFieldToAutomaticAction(JetBrains.ReSharper.Feature.Services.VB.Bulbs.IVBContextActionDataProvider dataProvider) { }
        public override string Text { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public static JetBrains.ReSharper.Psi.IField GetField(JetBrains.ReSharper.Psi.VB.Tree.IPropertyDeclaration propertyDeclaration) { }
        public bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Available on an access modifier keyword and allows changing access rights of a de" +
        "claration.", Group="VB", Name="Change member visibility", Priority=1)]
    public class ChangeModifierAction : JetBrains.ReSharper.Intentions.VB.ContextActions.Util.VBContextActionBase
    {
        public ChangeModifierAction(JetBrains.ReSharper.Feature.Services.VB.Bulbs.IVBContextActionDataProvider dataProvider) { }
        public override JetBrains.ReSharper.Intentions.Extensibility.IBulbAction[] Items { get; }
        protected override void ExecuteInternal(params object[] pars) { }
        protected override bool IsAvailableInternal() { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Creates overload without given parameter. Invokes current member.", Group="VB", Name="Create overload without parameter")]
    public class CreateOverloadAction : JetBrains.ReSharper.Intentions.VB.ContextActions.Util.OneItemContextActionBase
    {
        public CreateOverloadAction(JetBrains.ReSharper.Feature.Services.VB.Bulbs.IVBContextActionDataProvider dataProvider) { }
        public override string Text { get; }
        protected override void ExecuteInternal() { }
        protected override bool IsAvailableInternal() { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Works on \'For Each\' statements executed on a collection that allows direct access" +
        " to its elements by index. It converts such \'For Each\' statement to \'For\' on var" +
        "iable statement.", Group="VB", Name="Convert \'For Each\' to \'For\' on variable loop")]
    public class ForEachToForAction : JetBrains.ReSharper.Intentions.VB.ContextActions.Util.OneItemContextActionBase
    {
        public ForEachToForAction(JetBrains.ReSharper.Feature.Services.VB.Bulbs.IVBContextActionDataProvider dataProvider) { }
        public override string Text { get; }
        protected override void ExecuteInternal() { }
        protected override object[] ExecuteInternalEx(params object[] param) { }
        protected override object[] ExecuteInternalPostPSITransaction(params object[] data) { }
        protected override bool IsAvailableInternal() { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Converts \'Function\' to \'Sub\' removing \'As\' clause.", Group="VB", Name="Convert \'Function\' to \'Sub\'")]
    public class FunctionToSubAction : JetBrains.ReSharper.Intentions.VB.ContextActions.Util.OneItemContextActionBase
    {
        public FunctionToSubAction(JetBrains.ReSharper.Feature.Services.VB.Bulbs.IVBContextActionDataProvider dataProvider) { }
        public override string Text { get; }
        protected override void ExecuteInternal() { }
        protected override bool IsAvailableInternal() { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Works on \'If\' statement that compares value of an expression with one or more con" +
        "stants. It converts such \'If\' statement into a \'Select Case\' statement.", Group="VB", Name="Convert \'If\' statement to \'Select Case\' statement")]
    public class IfToSelectCaseAction : JetBrains.ReSharper.Intentions.VB.ContextActions.Util.OneItemContextActionBase
    {
        public IfToSelectCaseAction(JetBrains.ReSharper.Feature.Services.VB.Bulbs.IVBContextActionDataProvider dataProvider) { }
        public override string Text { get; }
        protected override void ExecuteInternal() { }
        protected override bool IsAvailableInternal() { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Works on an interface member or an abstract member. Searches for classes where th" +
        "is member needs to be implemented and allows to implement it in one of them.", Group="VB", Name="Implement abstract member")]
    public class ImplementAbstractMemberAction : JetBrains.ReSharper.Intentions.Implementor.ImplementMemberBase, JetBrains.ReSharper.Intentions.Extensibility.IContextAction
    {
        public ImplementAbstractMemberAction(JetBrains.ReSharper.Feature.Services.VB.Bulbs.IVBContextActionDataProvider dataProvider) { }
        protected JetBrains.ReSharper.Feature.Services.VB.Bulbs.IVBContextActionDataProvider DataProvider { get; }
        public override string Text { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        protected override string GetGeneratorKind() { }
        protected override JetBrains.ReSharper.Psi.IOverridableMember GetMemberToImplement() { }
        protected override System.Collections.Generic.List<JetBrains.ReSharper.Psi.ITypeElement> GetTargetTypes(JetBrains.Application.Progress.IProgressIndicator progress) { }
        public bool IBulbAction_IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
        protected override string SelectPartText() { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Works on a virtual member. Searches for classes where this member can be implemen" +
        "ted and allows to implement it in one or all of them.", Group="VB", Name="Implement virtual member")]
    public class ImplementVirtualMemberAction : JetBrains.ReSharper.Intentions.VB.ContextActions.ImplementAbstractMemberAction
    {
        public ImplementVirtualMemberAction(JetBrains.ReSharper.Feature.Services.VB.Bulbs.IVBContextActionDataProvider dataProvider) { }
        public override string Text { get; }
        protected override string GetGeneratorKind() { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
        protected override string SelectPartText() { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Introduces variable from expression statement", Group="VB", Name="Introduce variable from expression statement")]
    public class IntroduceVariableAction : JetBrains.ReSharper.Feature.Services.Bulbs.BulbItemImpl, JetBrains.ReSharper.Intentions.Extensibility.IContextAction
    {
        public IntroduceVariableAction(JetBrains.ReSharper.Feature.Services.VB.Bulbs.IVBContextActionDataProvider dataProvider) { }
        public override string Text { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Inverts guard condition of an \'If\' statement and swaps the branches\' code accordi" +
        "ngly.", Group="VB", Name="Invert \'If\' statement")]
    public class InvertIfAction : JetBrains.ReSharper.Intentions.VB.ContextActions.Util.OneItemContextActionBase
    {
        public InvertIfAction(JetBrains.ReSharper.Feature.Services.VB.Bulbs.IVBContextActionDataProvider dataProvider) { }
        public override string Text { get; }
        protected override void ExecuteInternal() { }
        protected override bool IsAvailableInternal() { }
        public JetBrains.ReSharper.Psi.TreeTextRange MakeTextRange(JetBrains.ReSharper.Psi.VB.Tree.IVBStatementsRange statements) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Works on an expression of System.ICollection type or other expression whose value" +
        " can be iterated with \'foreach\' statement. Generates a \'For Each\' statement iter" +
        "ating the expression.", Group="VB", Name="Iterate via \'For Each\'")]
    public class IterateViaForEachAction : JetBrains.ReSharper.Intentions.VB.ContextActions.Util.OneItemContextActionBase
    {
        public IterateViaForEachAction(JetBrains.ReSharper.Feature.Services.VB.Bulbs.IVBContextActionDataProvider dataProvider) { }
        public override string Text { get; }
        protected override void ExecuteInternal() { }
        protected override object[] ExecuteInternalEx(params object[] param) { }
        protected override object[] ExecuteInternalPostPSITransaction(params object[] data) { }
        protected override bool IsAvailableInternal() { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Works on an assignment to a variable that was declared without initializer. Moves" +
        " the declaration to the current point and merges it with the assignment.", Group="VB", Name="Join local variable declaration and assignment")]
    public class JoinDeclarationAction : JetBrains.ReSharper.Intentions.VB.ContextActions.Util.OneItemContextActionBase
    {
        public JoinDeclarationAction(JetBrains.ReSharper.Feature.Services.VB.Bulbs.IVBContextActionDataProvider dataProvider) { }
        public override string Text { get; }
        protected override void ExecuteInternal() { }
        protected override bool IsAvailableInternal() { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Annotates with \'value can be null\' attribute. The attribute can be configured via" +
        " external annotations.", Group="VB", Name="Annotate with \'value can be null\' attribute", Priority=-1)]
    public class MarkCanBeNullAction : JetBrains.ReSharper.Intentions.VB.ContextActions.MarkNullableActionBase
    {
        public MarkCanBeNullAction(JetBrains.ReSharper.Feature.Services.VB.Bulbs.IVBContextActionDataProvider dataProvider) { }
        protected override string AttributeShortName { get; }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Annotates with \'value cannot be null\' attribute. The attribute can be configured " +
        "via external annotations.", Group="VB", Name="Annotate with \'value cannot be null\' attribute", Priority=-1)]
    public class MarkNotNullAction : JetBrains.ReSharper.Intentions.VB.ContextActions.MarkNullableActionBase
    {
        public MarkNotNullAction(JetBrains.ReSharper.Feature.Services.VB.Bulbs.IVBContextActionDataProvider dataProvider) { }
        protected override string AttributeShortName { get; }
    }
    public abstract class MarkNullableActionBase : JetBrains.ReSharper.Intentions.Extensibility.ContextActionBase
    {
        public MarkNullableActionBase(JetBrains.ReSharper.Feature.Services.VB.Bulbs.IVBContextActionDataProvider dataProvider) { }
        protected abstract string AttributeShortName { get; }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Merges two nested \'If\' statements to a single \'If\' statement that checks conjunct" +
        "ion of the original conditions.", Group="VB", Name="Merge nested \'If\' statements")]
    public class MergeIfsAction : JetBrains.ReSharper.Intentions.VB.ContextActions.Util.OneItemContextActionBase
    {
        public MergeIfsAction(JetBrains.ReSharper.Feature.Services.VB.Bulbs.IVBContextActionDataProvider dataProvider) { }
        public override string Text { get; }
        protected override void ExecuteInternal() { }
        protected override bool IsAvailableInternal() { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Moves current type to another file so that its name matches the name of the type." +
        "", Group="VB", Name="Move type to another file to match its name", Priority=1)]
    public class MoveTypeToAnotherFileAction : JetBrains.ReSharper.Intentions.Extensibility.IBulbAction, JetBrains.ReSharper.Intentions.Extensibility.IContextAction
    {
        public MoveTypeToAnotherFileAction(JetBrains.ReSharper.Feature.Services.VB.Bulbs.IVBContextActionDataProvider dataProvider) { }
        public string Text { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        public void Execute(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        public bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Renames current file to match the name of the only top-level type declared therei" +
        "n.", Group="VB", Name="Match file name with type name", Priority=1)]
    public class RenameFileToMatchTypeNameAction : JetBrains.ReSharper.Feature.Services.Bulbs.BulbItemImpl, JetBrains.ReSharper.Intentions.Extensibility.IContextAction
    {
        public RenameFileToMatchTypeNameAction(JetBrains.ReSharper.Feature.Services.VB.Bulbs.IVBContextActionDataProvider dataProvider) { }
        public override string Text { get; }
        public static int CountTopLevelTypeDeclarations(JetBrains.ReSharper.Psi.VB.Tree.IVBTypeAndNamespaceHolderDeclaration declaration) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public static string GetFileName(JetBrains.ReSharper.Psi.IDeclaredElement element, JetBrains.ProjectModel.IProjectFile projectFile) { }
        public bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
        public static bool TypeNameNameDoesNotCorrespondWithFileName(JetBrains.ReSharper.Psi.IDeclaredElement element, JetBrains.ProjectModel.IProjectFile projectFile) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Reverses source and destination parts of an assignment statement.", Group="VB", Name="Reverse assignment statement")]
    public class ReverseAssignmentAction : JetBrains.ReSharper.Intentions.VB.ContextActions.Util.OneItemContextActionBase
    {
        public ReverseAssignmentAction(JetBrains.ReSharper.Feature.Services.VB.Bulbs.IVBContextActionDataProvider dataProvider) { }
        public override string Text { get; }
        protected override void ExecuteInternal() { }
        protected override bool IsAvailableInternal() { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Explicitly specifies type in implicitly typed local variable declaration.", Group="VB", Name="Specify type in local variable declaration")]
    public class SpecifyTypeAction : JetBrains.ReSharper.Intentions.VB.ContextActions.Util.OneItemContextActionBase
    {
        public SpecifyTypeAction(JetBrains.ReSharper.Feature.Services.VB.Bulbs.IVBContextActionDataProvider dataProvider) { }
        public override string Text { get; }
        protected override void ExecuteInternal() { }
        protected override bool IsAvailableInternal() { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Moves variable initializer from declaration statement to separate assignment stat" +
        "ement.", Group="VB", Name="Split local variable declaration and assignment")]
    public class SplitDeclarationAction : JetBrains.ReSharper.Intentions.VB.ContextActions.Util.OneItemContextActionBase
    {
        public SplitDeclarationAction(JetBrains.ReSharper.Feature.Services.VB.Bulbs.IVBContextActionDataProvider dataProvider) { }
        public override string Text { get; }
        protected override void ExecuteInternal() { }
        protected override bool IsAvailableInternal() { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Works on variable declaration statement that declares multiple variables. It spli" +
        "ts such statement into multiple statements each declaring a single variable.", Group="VB", Name="Split declaration list")]
    public class SplitDeclarationsListAction : JetBrains.ReSharper.Intentions.VB.ContextActions.Util.OneItemContextActionBase
    {
        public SplitDeclarationsListAction(JetBrains.ReSharper.Feature.Services.VB.Bulbs.IVBContextActionDataProvider dataProvider) { }
        public override string Text { get; }
        protected override void ExecuteInternal() { }
        protected override bool IsAvailableInternal() { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Works on \'If\' statement whose condition is conjunction (\'AndAlso\') of two simpler" +
        " conditions. It converts such \'If\' statement into two nested \'If\' statements.", Group="VB", Name="Splits \'If\' statement to nested statements")]
    public class SplitIfAction : JetBrains.ReSharper.Intentions.VB.ContextActions.Util.OneItemContextActionBase
    {
        public SplitIfAction(JetBrains.ReSharper.Feature.Services.VB.Bulbs.IVBContextActionDataProvider dataProvider) { }
        public override string Text { get; }
        protected override void ExecuteInternal() { }
        protected override bool IsAvailableInternal() { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Splits string literal into two literals.", Group="VB", Name="Split string literal", Priority=9)]
    public class SplitStringAction : JetBrains.ReSharper.Intentions.VB.ContextActions.Util.OneItemContextActionBase
    {
        public SplitStringAction(JetBrains.ReSharper.Feature.Services.VB.Bulbs.IVBContextActionDataProvider dataProvider) { }
        public override string Text { get; }
        protected override void ExecuteInternal() { }
        protected override object[] ExecuteInternalEx(params object[] param) { }
        protected override object[] ExecuteInternalPostPSITransaction(params object[] data) { }
        protected override bool IsAvailableInternal() { }
    }
    public class StringRepresentationConverter
    {
        public string DeQuote(string txt) { }
        public string Quote(string str) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Converts \'Sub\' to \'Function\' adding \'As\' clause.", Group="VB", Name="Convert \'Sub\' to \'Function\'")]
    public class SubToFunctionAction : JetBrains.ReSharper.Intentions.VB.ContextActions.Util.OneItemContextActionBase
    {
        public SubToFunctionAction(JetBrains.ReSharper.Feature.Services.VB.Bulbs.IVBContextActionDataProvider dataProvider) { }
        public override string Text { get; }
        protected override void ExecuteInternal() { }
        protected override object[] ExecuteInternalEx(params object[] param) { }
        protected override object[] ExecuteInternalPostPSITransaction(params object[] data) { }
        protected override bool IsAvailableInternal() { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Surrounds block with \'With\' construct.", Group="VB", Name="Surround with \'With\'")]
    public class SurroundWithWithAction : JetBrains.ReSharper.Intentions.VB.ContextActions.Util.OneItemContextActionBase
    {
        public SurroundWithWithAction(JetBrains.ReSharper.Feature.Services.VB.Bulbs.IVBContextActionDataProvider dataProvider) { }
        public override string Text { get; }
        protected override void ExecuteInternal() { }
        protected override object[] ExecuteInternalEx(params object[] param) { }
        protected override object[] ExecuteInternalPostPSITransaction(params object[] data) { }
        protected override bool IsAvailableInternal() { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Converts local variable declaration to implicitly typed declaration.", Group="VB", Name="Convert to implicitly typed local variable declaration")]
    public class ToImplicitlyTypedAction : JetBrains.ReSharper.Intentions.Extensibility.ContextActionBase
    {
        public ToImplicitlyTypedAction(JetBrains.ReSharper.Feature.Services.VB.Bulbs.IVBContextActionDataProvider dataProvider) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Inserts method\'s inferred type arguments.", Group="VB", Name="Insert inferred type arguments")]
    public class UseExplicitTypeParametersAction : JetBrains.ReSharper.Intentions.Extensibility.ContextActionBase
    {
        public UseExplicitTypeParametersAction(JetBrains.ReSharper.Feature.Services.VB.Bulbs.IVBContextActionDataProvider dataProvider) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class VBContextActions
    {
        public const string GroupID = "VB";
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Optionally creates and initializes auto-property from constructor parameter", Group="VB", Name="Initialize auto-property from constructor parameter", Priority=1)]
    public class VBInitializeAutoPropertyAction : JetBrains.ReSharper.Intentions.ContextActions.InitializeAutoPropertyActionBase
    {
        public VBInitializeAutoPropertyAction(JetBrains.ReSharper.Feature.Services.VB.Bulbs.IVBContextActionDataProvider dataProvider) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Optionally creates and initializes field from constructor parameter", Group="VB", Name="Initialize field from constructor parameter", Priority=1)]
    public class VBInitializeFieldAction : JetBrains.ReSharper.Intentions.ContextActions.InitializeFieldActionBase
    {
        public VBInitializeFieldAction(JetBrains.ReSharper.Feature.Services.VB.Bulbs.IVBContextActionDataProvider dataProvider) { }
    }
}
namespace JetBrains.ReSharper.Intentions.VB.ContextActions.FormatString
{
    
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Converts concatenation of a few strings and other objects to the use of string.Fo" +
        "rmat method.", Group="VB", Name="Use format string", Priority=10)]
    public class AddFormatItemAction : JetBrains.ReSharper.Intentions.ContextActions.ClrFormatString.ClrAddFormatItemAction
    {
        public AddFormatItemAction(JetBrains.ReSharper.Feature.Services.VB.Bulbs.IVBContextActionDataProvider dataProvider) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Removes format string item and proper formatting method argument", Group="VB", Name="Remove format item", Priority=10)]
    public class RemoveFormatItemAction : JetBrains.ReSharper.Intentions.ContextActions.ClrFormatString.ClrRemoveFormatItemAction
    {
        public RemoveFormatItemAction(JetBrains.ReSharper.Feature.Services.VB.Bulbs.IVBContextActionDataProvider dataProvaider) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Surrounds string with String.Format() call.", Group="VB", Name="Surround with format", Priority=11)]
    public class SurroundWithFormatAction : JetBrains.ReSharper.Intentions.ContextActions.ClrFormatString.ClrSurroundWithFormatAction
    {
        public SurroundWithFormatAction(JetBrains.ReSharper.Feature.Services.VB.Bulbs.IVBContextActionDataProvider dataProvider) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Adds new format item to format string and new argument to Format method invocatio" +
        "n", Group="VB", Name="Add new format item", Priority=30)]
    public class UseFormatStringAction : JetBrains.ReSharper.Intentions.ContextActions.ClrFormatString.ClrUseFormatStringAction
    {
        public UseFormatStringAction(JetBrains.ReSharper.Feature.Services.VB.Bulbs.IVBContextActionDataProvider dataProvider) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Moves concatenation argument to new argument of format method and injects a forma" +
        "t item to format string argument.", Group="VB", Name="Move concatenation argument to formatting argument", Priority=10)]
    public class UseFormatStringForSingleArgumentAction : JetBrains.ReSharper.Intentions.CSharp.ContextActions.ClrUseFormatStringForSingleArgumentAction
    {
        public UseFormatStringForSingleArgumentAction(JetBrains.ReSharper.Feature.Services.VB.Bulbs.IVBContextActionDataProvider dataProvider) { }
    }
}
namespace JetBrains.ReSharper.Intentions.VB.ContextActions.Util
{
    
    [System.ObsoleteAttribute("Use ContextActionBase")]
    public abstract class OneItemContextActionBase : JetBrains.ReSharper.Intentions.VB.ContextActions.Util.VBContextActionBase, JetBrains.ReSharper.Intentions.Extensibility.IBulbAction
    {
        public OneItemContextActionBase(JetBrains.ReSharper.Feature.Services.VB.Bulbs.IVBContextActionDataProvider dataProvider) { }
        public override JetBrains.ReSharper.Intentions.Extensibility.IBulbAction[] Items { get; }
        public abstract string Text { get; }
        public void Execute(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        protected abstract void ExecuteInternal();
        protected override void ExecuteInternal(params object[] param) { }
    }
    public class ReferenceNameFinder
    {
        public static System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Tree.IExpression> GetExpressions(JetBrains.ReSharper.Psi.VB.Tree.IReferenceName referenceName, JetBrains.ReSharper.Psi.VB.Tree.IVBTreeNode scope) { }
    }
    [System.ObsoleteAttribute("Use ContextActionBase")]
    public abstract class VBContextActionBase : JetBrains.ReSharper.Intentions.Legacy.ContextActionBase_Obsolete
    {
        protected VBContextActionBase(JetBrains.ReSharper.Feature.Services.VB.Bulbs.IVBContextActionDataProvider dataProvider) { }
        protected JetBrains.ReSharper.Feature.Services.VB.Bulbs.IVBContextActionDataProvider Provider { get; }
    }
}
namespace JetBrains.ReSharper.Intentions.VB.DisableWarning
{
    
    [JetBrains.ReSharper.Intentions.Extensibility.CustomHighlightingActionProviderAttribute(typeof(JetBrains.ProjectModel.VBProjectFileType))]
    public class DisableByCommentWarningActionProvider : JetBrains.ReSharper.Intentions.Extensibility.ICustomHighlightingActionProvider
    {
        public DisableByCommentWarningActionProvider(JetBrains.ReSharper.Daemon.HighlightingSettingsManager highlightingSettingsManager) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> GetActions(JetBrains.ReSharper.Daemon.IHighlighting highlighting, JetBrains.DocumentModel.DocumentRange highlightingRange, JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, string inspectionTitle) { }
    }
}
namespace JetBrains.ReSharper.Intentions.VB.Options
{
    
    [JetBrains.UI.Options.OptionsPageAttribute("VbnetContextActions", "Context Actions", typeof(JetBrains.ReSharper.Daemon.Src.Bulbs.Resources.BulbThemedIcons.ContextAction), HelpKeyword="Reference__Options__Languages__Visual_Basic__NET__Context_Actions", ParentId="Vbnet", Sequence=3D, SupportedEditions=new string[] {
            "Vbnet"})]
    public class VbnetContextActionsPage : JetBrains.ReSharper.Intentions.Options.ContextActionsPageBase
    {
        public const string PID = "VbnetContextActions";
        public VbnetContextActionsPage(JetBrains.Threading.IThreading threading, JetBrains.DataFlow.Lifetime lifetime, JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionTable contextActionTable, JetBrains.UI.Application.UIApplication uiApplication, JetBrains.Application.Interop.NativeHook.IWindowsHookManager windowsHookManager, JetBrains.ActionManagement.IActionManager actionManager, JetBrains.UI.Options.OptionsSettingsSmartContext smartContext) { }
        public override string Id { get; }
    }
}
namespace JetBrains.ReSharper.Intentions.VB.QuickFixes
{
    
    public class AddAsyncModifierFix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public AddAsyncModifierFix(JetBrains.ReSharper.Daemon.VB.Errors.AwaitExpressionNotUnderAsyncMethodError error) { }
        public override string Text { get; }
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class AddAwaitFix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public AddAwaitFix(JetBrains.ReSharper.Psi.VB.Tree.IInvocationStatement invocationStatement) { }
        public override string Text { get; }
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class AddCallKeywordFix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public AddCallKeywordFix(JetBrains.ReSharper.Daemon.VB.Errors.InvalidExpressionStatementError error) { }
        public AddCallKeywordFix(JetBrains.ReSharper.Daemon.VB.Errors.InvalidInvocationStatementExpressionError error) { }
        public AddCallKeywordFix(JetBrains.ReSharper.Daemon.VB.Errors.InvalidInvocationStatementStartExpressionError error) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class AddClassConstraint3Fix : JetBrains.ReSharper.Intentions.VB.QuickFixes.AddConstraintFixBase
    {
        public AddClassConstraint3Fix(JetBrains.ReSharper.Daemon.VB.Errors.PossibleAssignmentToReadonlyFieldWarning error) { }
        protected override string ConstraintText { get; }
        protected override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.VB.Tree.ITypeParameterConstraint> AddConstraint() { }
        protected override void ProcessAddedConstraint(JetBrains.ReSharper.Psi.VB.Tree.ITypeParameterConstraint constraint) { }
    }
    public abstract class AddConstraintFixBase : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        protected AddConstraintFixBase(JetBrains.ReSharper.Psi.ITypeParameter typeParameter) { }
        protected abstract string ConstraintText { get; }
        public override string Text { get; }
        protected JetBrains.ReSharper.Psi.ITypeParameter TypeParameter { get; }
        protected abstract System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.VB.Tree.ITypeParameterConstraint> AddConstraint();
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
        protected abstract void ProcessAddedConstraint(JetBrains.ReSharper.Psi.VB.Tree.ITypeParameterConstraint constraint);
    }
    public class AddGetAccessorFix : JetBrains.ReSharper.Intentions.VB.QuickFixes.VBAddAccessorFixBase
    {
        public AddGetAccessorFix(JetBrains.ReSharper.Daemon.VB.Errors.ReadAccessToPropertyWithoutGetterError error) { }
        public AddGetAccessorFix(JetBrains.ReSharper.Psi.IProperty property) { }
        protected override JetBrains.ReSharper.Psi.AccessorKind AccessorKind { get; }
        protected override string AccessorName { get; }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class AddIteratorModifierFix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public AddIteratorModifierFix(JetBrains.ReSharper.Daemon.VB.Errors.YieldStatementNotUnderIteratorMethodError error) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class AddOverloadsFix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public AddOverloadsFix(JetBrains.ReSharper.Daemon.VB.Errors.ShadowsOverridableMemberWarning warning) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class AddParameterFix : JetBrains.ReSharper.Intentions.QuickFixes.AddParameterFixBase
    {
        public AddParameterFix(JetBrains.ReSharper.Daemon.VB.Errors.ProblemInResolveError error) { }
        public AddParameterFix(JetBrains.ReSharper.Daemon.VB.Errors.IncorrectArgumentNumberError error) { }
        public AddParameterFix(JetBrains.ReSharper.Daemon.VB.Errors.IncorrectArgumentNumberMultipleCandidatesError error) { }
        public AddParameterFix(JetBrains.ReSharper.Daemon.VB.Errors.CannotConvertTypeInArgumentError error) { }
        public AddParameterFix(JetBrains.ReSharper.Daemon.VB.Errors.CannotConvertTypeInArgumentWarning error) { }
        public AddParameterFix(JetBrains.ReSharper.Daemon.VB.Errors.ImpossibleConvertTypeInArgumentWarning error) { }
        public AddParameterFix(JetBrains.ReSharper.Daemon.VB.Errors.IncorrectArgumentTypesError error) { }
        protected override JetBrains.ReSharper.Psi.Tree.IExpression ArgumentExpression(JetBrains.ReSharper.Psi.IArgumentInfo argumentInfo) { }
        protected override JetBrains.ReSharper.Psi.IParameter FindMatchingParameter(JetBrains.ReSharper.Psi.IArgumentInfo argumentInfo, JetBrains.ReSharper.Psi.IParametersOwner target) { }
        protected override JetBrains.ReSharper.Psi.IInvocationInfo GetInvocation() { }
        protected override JetBrains.ReSharper.Psi.IInvocationInfo MakeArgumentsOwnerCopy(JetBrains.ReSharper.Psi.IInvocationInfo argumentsInfo) { }
        protected override JetBrains.ReSharper.Psi.ParameterKind ParameterKindFromArgument(JetBrains.ReSharper.Psi.IArgumentInfo argument) { }
        protected override bool ParametersOwnerIsSuitableToAddParameter(JetBrains.ReSharper.Psi.IParametersOwner parametersOwner, JetBrains.ReSharper.Psi.IInvocationInfo argumentsOwner) { }
        protected override bool RemoveArgument(JetBrains.ReSharper.Psi.IInvocationInfo invocationInfo, JetBrains.ReSharper.Psi.IArgumentInfo argumentInfo) { }
    }
    public class AddSetAccessorFix : JetBrains.ReSharper.Intentions.VB.QuickFixes.VBAddAccessorFixBase
    {
        public AddSetAccessorFix(JetBrains.ReSharper.Daemon.VB.Errors.ReadonlyAssignmentTargetError error) { }
        public AddSetAccessorFix(JetBrains.ReSharper.Daemon.VB.Errors.WriteAccessToPropertyWithoutSetterError error) { }
        public AddSetAccessorFix(JetBrains.ReSharper.Psi.IProperty property) { }
        protected override JetBrains.ReSharper.Psi.AccessorKind AccessorKind { get; }
        protected override string AccessorName { get; }
    }
    public class AddShadowsFix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public AddShadowsFix(JetBrains.ReSharper.Daemon.VB.Errors.ShadowsOverridableMemberWarning warning) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class AddTypeArgListFix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public AddTypeArgListFix(JetBrains.ReSharper.Daemon.VB.Errors.TypeInferenceError err) { }
        public AddTypeArgListFix(JetBrains.ReSharper.Daemon.VB.Errors.TypeInferenceMultipleCandidatesError err) { }
        public AddTypeArgListFix(JetBrains.ReSharper.Daemon.VB.Errors.TypeParametersNumberMismatchError err) { }
        public AddTypeArgListFix(JetBrains.ReSharper.Daemon.VB.Errors.TypeParametersNumberMismatchMultipleCandidatesError err) { }
        public AddTypeArgListFix(JetBrains.ReSharper.Daemon.VB.Errors.ProblemInResolveError err) { }
        public AddTypeArgListFix(JetBrains.ReSharper.Daemon.VB.Errors.NoTypeArgumentsInUsageError err) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class CastFix : JetBrains.ReSharper.Intentions.Extensibility.IQuickFix
    {
        public CastFix(JetBrains.ReSharper.Daemon.VB.Errors.CannotConvertTypeInArgumentError error) { }
        public CastFix(JetBrains.ReSharper.Daemon.VB.Errors.CannotConvertTypeInArgumentWarning error) { }
        public CastFix(JetBrains.ReSharper.Daemon.VB.Errors.ImpossibleConvertTypeInArgumentWarning error) { }
        public CastFix(JetBrains.ReSharper.Daemon.VB.Errors.IncorrectArgumentTypesError error) { }
        public CastFix(JetBrains.ReSharper.Daemon.VB.Errors.MultipleResolveCandidatesError error) { }
        public CastFix(JetBrains.ReSharper.Daemon.VB.Errors.IncorrectArgumentNumberError error) { }
        public CastFix(JetBrains.ReSharper.Daemon.VB.Errors.IncorrectArgumentNumberMultipleCandidatesError error) { }
        public CastFix(JetBrains.ReSharper.Daemon.VB.Errors.StrictnessFailedError error) { }
        public CastFix(JetBrains.ReSharper.Daemon.VB.Errors.MoreApplicableNotFoundError error) { }
        public CastFix(JetBrains.ReSharper.Daemon.VB.Errors.MoreSpecificNotFoundError error) { }
        public CastFix(JetBrains.ReSharper.Daemon.VB.Errors.IncorrectArrayElementTypeError error) { }
        public CastFix(JetBrains.ReSharper.Daemon.VB.Errors.CannotConvertTypeInAssignmentError error) { }
        public CastFix(JetBrains.ReSharper.Daemon.VB.Errors.CannotConvertTypeInAssignmentWarning error) { }
        public CastFix(JetBrains.ReSharper.Daemon.VB.Errors.ImpossibleConvertTypeInAssignmentWarning error) { }
        public CastFix(JetBrains.ReSharper.Daemon.VB.Errors.CannotConvertTypeInMemberInitializerError error) { }
        public CastFix(JetBrains.ReSharper.Daemon.VB.Errors.CannotConvertTypeInMemberInitializerWarning error) { }
        public CastFix(JetBrains.ReSharper.Daemon.VB.Errors.ImpossibleConvertTypeInMemberInitializerWarning error) { }
        public CastFix(JetBrains.ReSharper.Daemon.VB.Errors.CannotConvertTypeInDeclarationError error) { }
        public CastFix(JetBrains.ReSharper.Daemon.VB.Errors.CannotConvertTypeInDeclarationWarning error) { }
        public CastFix(JetBrains.ReSharper.Daemon.VB.Errors.ImpossibleConvertTypeInDeclarationWarning error) { }
        public CastFix(JetBrains.ReSharper.Daemon.VB.Errors.InvalidCastError error) { }
        public CastFix(JetBrains.ReSharper.Daemon.VB.Errors.CannotConvertTypeInReturnError error) { }
        public CastFix(JetBrains.ReSharper.Daemon.VB.Errors.CannotConvertTypeInReturnWarning error) { }
        public CastFix(JetBrains.ReSharper.Daemon.VB.Errors.ImpossibleConvertTypeInReturnWarning error) { }
        public CastFix(JetBrains.ReSharper.Daemon.VB.Errors.CannotDetermineNullCoalescingExpressionType2Error error) { }
        public CastFix(JetBrains.ReSharper.Daemon.VB.Errors.CannotDetermineNullCoalescingExpressionTypeError error) { }
        public CastFix(JetBrains.ReSharper.Daemon.VB.Errors.CannotDetermineTernaryExpressionTypeError error) { }
        public CastFix(JetBrains.ReSharper.Daemon.VB.Errors.CannotDetermineTernaryExpressionType2Error error) { }
        public CastFix(JetBrains.ReSharper.Daemon.VB.Errors.LateBoundThroughtInterfaceError error) { }
        public CastFix(JetBrains.ReSharper.Daemon.VB.Errors.LateBoundExtensionMethodsError error) { }
        public CastFix(JetBrains.ReSharper.Psi.IArgumentInfo argumentInfo) { }
        public JetBrains.ReSharper.Intentions.Extensibility.IBulbAction[] Items { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        public bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
        protected virtual System.Nullable<bool> IsValidTryCast(JetBrains.ReSharper.Psi.VB.Tree.IVBExpression vbExpression, JetBrains.ReSharper.Psi.IType targetType) { }
        protected virtual System.Collections.Generic.IEnumerable<JetBrains.Util.Pair<JetBrains.ReSharper.Psi.VB.Tree.IVBExpression, JetBrains.ReSharper.Psi.IType>> ToVB(System.Collections.Generic.IEnumerable<JetBrains.Util.Pair<JetBrains.ReSharper.Psi.Tree.IExpression, JetBrains.ReSharper.Psi.IType>> src) { }
    }
    public class CastInBinaryFix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public CastInBinaryFix(JetBrains.ReSharper.Psi.VB.Tree.IVBBinaryExpression binaryExpression) { }
        public override string Text { get; }
        protected JetBrains.ReSharper.Psi.VB.Tree.IVBExpression CreateCast(JetBrains.ReSharper.Psi.VB.Tree.IVBExpression expression) { }
        protected JetBrains.ReSharper.Psi.VB.Tree.IVBExpression CreateCast(JetBrains.Util.Pair<JetBrains.ReSharper.Psi.VB.Tree.IVBExpression, JetBrains.ReSharper.Psi.IType> p, bool canReturnExpr) { }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
        protected bool IsAvailableEx(JetBrains.ReSharper.Psi.VB.Tree.IVBExpression expression) { }
    }
    public class ChangeSignatureFixUtil
    {
        public static JetBrains.ReSharper.Psi.IParametersOwner GetAddHandlerDelegate(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
    }
    [JetBrains.Annotations.UsedImplicitlyAttribute()]
    public class ChangeTypeItemsCreator
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Psi.IClrDeclaredElement DeclaredElementFromExpression([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.VB.Tree.IVBExpression vbExpression) { }
        public static JetBrains.ReSharper.Intentions.Extensibility.IBulbAction[] FromArgument(JetBrains.ReSharper.Psi.VB.IVBArgumentInfo vbArgumentInfo) { }
        public static JetBrains.ReSharper.Intentions.Extensibility.IBulbAction[] FromAssigment(JetBrains.ReSharper.Psi.VB.Tree.IAssignmentStatement assignmentStatement) { }
        public static JetBrains.ReSharper.Intentions.Extensibility.IBulbAction[] FromConditional(JetBrains.ReSharper.Psi.VB.Tree.IConditionalExpression conditionalExpression) { }
        public static JetBrains.ReSharper.Intentions.Extensibility.IBulbAction[] FromDeclaration(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration, JetBrains.ReSharper.Psi.VB.Tree.IVBExpression vbExpression) { }
        public static JetBrains.ReSharper.Intentions.Extensibility.IBulbAction[] FromMemberInitializer(JetBrains.ReSharper.Psi.VB.Tree.IMemberInitializer initializer) { }
        public static JetBrains.ReSharper.Intentions.Extensibility.IBulbAction[] FromReturn(JetBrains.ReSharper.Psi.VB.Tree.IReturnStatement returnStatement) { }
        public static JetBrains.ReSharper.Intentions.Extensibility.IBulbAction[] FromUnknownParentOfExpresion(JetBrains.ReSharper.Psi.VB.Tree.IVBExpression vbExpression) { }
        public static System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IType> ParamArrayPosibleTypes(JetBrains.ReSharper.Psi.VB.IVBArgumentInfo vbArgumentInfo) { }
    }
    public class CorrectSharedAccessFix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public CorrectSharedAccessFix(JetBrains.ReSharper.Daemon.VB.Errors.StaticElementInNonStaticContextWarning warning) { }
        public override string Text { get; }
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class CreateAbstractMethodForDelegateAction : JetBrains.ReSharper.Intentions.VB.QuickFixes.CreateMethodForDelegateAction
    {
        public CreateAbstractMethodForDelegateAction(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        protected override JetBrains.ReSharper.Feature.Services.Intentions.CreateDeclaration.CreateMethodDeclarationContext CreateContext() { }
        protected override JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.ICreationTarget GetTarget() { }
        protected override string GetTextFormat() { }
    }
    public class CreateAbstractMethodFromUsageAction : JetBrains.ReSharper.Intentions.VB.QuickFixes.CreateMethodFromUsageAction
    {
        public CreateAbstractMethodFromUsageAction(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        protected override JetBrains.ReSharper.Feature.Services.Intentions.CreateDeclaration.CreateMethodDeclarationContext CreateContext() { }
        protected override JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.ICreationTarget GetTarget() { }
        protected override string GetTextFormat() { }
    }
    public class CreateAbstractPropertyFromUsage : JetBrains.ReSharper.Intentions.VB.QuickFixes.CreatePropertyFromUsageFix
    {
        public CreateAbstractPropertyFromUsage(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        protected override JetBrains.ReSharper.Feature.Services.Intentions.CreateDeclaration.CreatePropertyDeclarationContext CreateContext() { }
        protected override bool IsAvailableInternal() { }
        protected override string TextFormat() { }
    }
    public class CreateAbstractReadOnlyPropertyFromUsageFix : JetBrains.ReSharper.Intentions.VB.QuickFixes.CreateReadOnlyPropertyFromUsageFix
    {
        public CreateAbstractReadOnlyPropertyFromUsageFix(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        protected override JetBrains.ReSharper.Feature.Services.Intentions.CreateDeclaration.CreatePropertyDeclarationContext CreateContext() { }
        protected override bool IsAvailableInternal() { }
        protected override string TextFormat() { }
    }
    public abstract class CreateClassFromQualifierBase : JetBrains.ReSharper.Intentions.CreateFromUsage.CreateFromUsageActionBase2<JetBrains.ReSharper.Feature.Services.Intentions.CreateDeclaration.CreateClassDeclarationContext, JetBrains.ReSharper.Psi.Resolve.IReference>
    {
        protected CreateClassFromQualifierBase(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        protected JetBrains.ReSharper.Psi.VB.Tree.IReferenceExpression ReferenceExpression { get; }
        public override string Text { get; }
        protected override JetBrains.ReSharper.Feature.Services.Intentions.CreateDeclaration.CreateClassDeclarationContext CreateContext() { }
        protected override JetBrains.ReSharper.Feature.Services.Intentions.IntentionResult ExecuteIntention(JetBrains.ReSharper.Feature.Services.Intentions.CreateDeclaration.CreateClassDeclarationContext context) { }
        public override JetBrains.ReSharper.Intentions.CreateFromUsage.ICreatedElementConsistencyGroup GetConsistencyGroup() { }
        protected abstract string GetItemText();
        protected override bool IsAvailableInternal() { }
    }
    public class CreateClassFromQualifierFix : JetBrains.ReSharper.Intentions.VB.QuickFixes.CreateClassFromQualifierBase
    {
        public CreateClassFromQualifierFix(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        protected override string GetItemText() { }
        protected override JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.ICreationTarget GetTarget() { }
        protected override bool IsAvailableInternal() { }
    }
    public class CreateClassFromUsageFix : JetBrains.ReSharper.Intentions.VB.QuickFixes.CreateClassFromUsageFixBase
    {
        public CreateClassFromUsageFix(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        protected override string GetItemText() { }
        protected override JetBrains.ReSharper.Psi.VB.Tree.IVBTreeNode GetScope() { }
        protected override JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.ICreationTarget GetTarget() { }
        protected override bool IsQualifierRedundant(JetBrains.ReSharper.Psi.IDeclaredElement element) { }
    }
    public abstract class CreateClassFromUsageFixBase : JetBrains.ReSharper.Intentions.CreateFromUsage.CreateFromUsageActionBase2<JetBrains.ReSharper.Feature.Services.Intentions.CreateDeclaration.CreateClassDeclarationContext, JetBrains.ReSharper.Psi.Resolve.IReference>
    {
        public CreateClassFromUsageFixBase(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        protected JetBrains.ReSharper.Psi.VB.Tree.IReferenceName ReferenceName { get; }
        public override string Text { get; }
        protected override JetBrains.ReSharper.Feature.Services.Intentions.CreateDeclaration.CreateClassDeclarationContext CreateContext() { }
        protected override JetBrains.ReSharper.Feature.Services.Intentions.IntentionResult ExecuteIntention(JetBrains.ReSharper.Feature.Services.Intentions.CreateDeclaration.CreateClassDeclarationContext context) { }
        public override JetBrains.ReSharper.Intentions.CreateFromUsage.ICreatedElementConsistencyGroup GetConsistencyGroup() { }
        protected abstract string GetItemText();
        protected abstract JetBrains.ReSharper.Psi.VB.Tree.IVBTreeNode GetScope();
        protected override bool IsAvailableInternal() { }
        protected abstract bool IsQualifierRedundant(JetBrains.ReSharper.Psi.IDeclaredElement element);
    }
    public class CreateConstructorFromUsageFix : JetBrains.ReSharper.Intentions.CreateFromUsage.CreateFromUsageActionBase<JetBrains.ReSharper.Psi.Resolve.IReference>, JetBrains.ReSharper.Intentions.Extensibility.IQuickFix
    {
        public CreateConstructorFromUsageFix(JetBrains.ReSharper.Daemon.VB.Errors.CannotConvertTypeInArgumentError error) { }
        public CreateConstructorFromUsageFix(JetBrains.ReSharper.Daemon.VB.Errors.CannotConvertTypeInArgumentWarning error) { }
        public CreateConstructorFromUsageFix(JetBrains.ReSharper.Daemon.VB.Errors.ImpossibleConvertTypeInArgumentWarning error) { }
        public CreateConstructorFromUsageFix(JetBrains.ReSharper.Daemon.VB.Errors.IncorrectArgumentNumberError error) { }
        public CreateConstructorFromUsageFix(JetBrains.ReSharper.Daemon.VB.Errors.IncorrectArgumentNumberMultipleCandidatesError error) { }
        public CreateConstructorFromUsageFix(JetBrains.ReSharper.Daemon.VB.Errors.ArgumentsMismatchError error) { }
        public CreateConstructorFromUsageFix(JetBrains.ReSharper.Daemon.VB.Errors.IncorrectArgumentTypesError error) { }
        public CreateConstructorFromUsageFix(JetBrains.ReSharper.Daemon.VB.Errors.StrictnessFailedError error) { }
        public CreateConstructorFromUsageFix(JetBrains.ReSharper.Daemon.VB.Errors.MoreApplicableNotFoundError error) { }
        public CreateConstructorFromUsageFix(JetBrains.ReSharper.Daemon.VB.Errors.NoMatchingInInterfaceError error) { }
        public CreateConstructorFromUsageFix(JetBrains.ReSharper.Daemon.VB.Errors.NoMatchingInInterfaceMultipleCandidatesError error) { }
        public CreateConstructorFromUsageFix(JetBrains.ReSharper.Daemon.VB.Errors.MoreSpecificNotFoundError error) { }
        public JetBrains.ReSharper.Intentions.Extensibility.IBulbAction[] BulbActionItems { get; }
        protected virtual bool CanAddMemberTo(JetBrains.ReSharper.Psi.IDeclaredType declaredType) { }
        protected override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IBulbAction> CreateBulbActions() { }
        protected virtual JetBrains.ReSharper.Feature.Services.Intentions.CreateDeclaration.CreateConstructorDeclarationContext GetContext() { }
        protected override JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.ICreationTarget GetTarget() { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> IQuickFix_CreateBulbItems() { }
        public bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class CreateDefaultPropertyFromUsageFix : JetBrains.ReSharper.Intentions.CreateFromUsage.CreateFromUsageActionBase<JetBrains.ReSharper.Psi.Resolve.IReference>, JetBrains.ReSharper.Intentions.Extensibility.IQuickFix
    {
        public CreateDefaultPropertyFromUsageFix(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        protected override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IBulbAction> CreateBulbActions() { }
        protected virtual JetBrains.ReSharper.Feature.Services.Intentions.CreateDeclaration.CreatePropertyDeclarationContext GetContext() { }
        protected override JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.ICreationTarget GetTarget() { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> IQuickFix_CreateBulbItems() { }
        public bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public abstract class CreateDelegateFixBase : JetBrains.ReSharper.Intentions.CreateFromUsage.CreateFromUsageActionBase2<JetBrains.ReSharper.Feature.Services.Intentions.CreateDeclaration.CreateDelegateDeclarationContext, JetBrains.ReSharper.Psi.Resolve.IReference>
    {
        protected readonly JetBrains.ReSharper.Psi.VB.Tree.IReferenceName myReferenceName;
        protected CreateDelegateFixBase(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        protected override JetBrains.ReSharper.Feature.Services.Intentions.CreateDeclaration.CreateDelegateDeclarationContext CreateContext() { }
        protected override JetBrains.ReSharper.Feature.Services.Intentions.IntentionResult ExecuteIntention(JetBrains.ReSharper.Feature.Services.Intentions.CreateDeclaration.CreateDelegateDeclarationContext context) { }
        public override JetBrains.ReSharper.Intentions.CreateFromUsage.ICreatedElementConsistencyGroup GetConsistencyGroup() { }
        protected override bool IsAvailableInternal() { }
    }
    public class CreateDelegateFromUsageFix : JetBrains.ReSharper.Intentions.VB.QuickFixes.CreateDelegateFixBase
    {
        public CreateDelegateFromUsageFix(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public override string Text { get; }
        protected override JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.ICreationTarget GetTarget() { }
    }
    public class CreateEnumMemberFromUsageFix : JetBrains.ReSharper.Intentions.CreateFromUsage.CreateFromUsageActionBase2<JetBrains.ReSharper.Feature.Services.Intentions.CreateDeclaration.CreateEnumMemberDeclarationContext, JetBrains.ReSharper.Psi.Resolve.IReference>
    {
        public CreateEnumMemberFromUsageFix(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public override string Text { get; }
        protected override JetBrains.ReSharper.Feature.Services.Intentions.CreateDeclaration.CreateEnumMemberDeclarationContext CreateContext() { }
        protected override JetBrains.ReSharper.Feature.Services.Intentions.IntentionResult ExecuteIntention(JetBrains.ReSharper.Feature.Services.Intentions.CreateDeclaration.CreateEnumMemberDeclarationContext context) { }
        public override JetBrains.ReSharper.Intentions.CreateFromUsage.ICreatedElementConsistencyGroup GetConsistencyGroup() { }
        protected override JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.ICreationTarget GetTarget() { }
        protected override bool IsAvailableInternal() { }
    }
    public class CreateEventFromUsageFix : JetBrains.ReSharper.Intentions.CreateFromUsage.CreateFromUsageActionBase2<JetBrains.ReSharper.Feature.Services.Intentions.CreateDeclaration.CreateEventDeclarationContext, JetBrains.ReSharper.Psi.Resolve.IReference>
    {
        public CreateEventFromUsageFix(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public override string Text { get; }
        protected override JetBrains.ReSharper.Feature.Services.Intentions.CreateDeclaration.CreateEventDeclarationContext CreateContext() { }
        protected override JetBrains.ReSharper.Feature.Services.Intentions.IntentionResult ExecuteIntention(JetBrains.ReSharper.Feature.Services.Intentions.CreateDeclaration.CreateEventDeclarationContext context) { }
        public override JetBrains.ReSharper.Intentions.CreateFromUsage.ICreatedElementConsistencyGroup GetConsistencyGroup() { }
        protected override JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.ICreationTarget GetTarget() { }
        protected override bool IsAvailableInternal() { }
    }
    public class CreateFieldFromInitializerFix : JetBrains.ReSharper.Intentions.CreateFromUsage.CreateFromUsageActionBase2<JetBrains.ReSharper.Feature.Services.Intentions.CreateDeclaration.CreateFieldDeclarationContext, JetBrains.ReSharper.Psi.Resolve.IReference>
    {
        public CreateFieldFromInitializerFix(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public override string Text { get; }
        protected override JetBrains.ReSharper.Feature.Services.Intentions.CreateDeclaration.CreateFieldDeclarationContext CreateContext() { }
        protected override JetBrains.ReSharper.Feature.Services.Intentions.IntentionResult ExecuteIntention(JetBrains.ReSharper.Feature.Services.Intentions.CreateDeclaration.CreateFieldDeclarationContext context) { }
        public override JetBrains.ReSharper.Intentions.CreateFromUsage.ICreatedElementConsistencyGroup GetConsistencyGroup() { }
        protected override JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.ICreationTarget GetTarget() { }
        protected override bool IsAvailableInternal() { }
    }
    public class CreateFieldFromUsageFix : JetBrains.ReSharper.Intentions.CreateFromUsage.CreateFromUsageActionBase2<JetBrains.ReSharper.Feature.Services.Intentions.CreateDeclaration.CreateFieldDeclarationContext, JetBrains.ReSharper.Psi.Resolve.IReference>
    {
        public CreateFieldFromUsageFix(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public override string Text { get; }
        protected override JetBrains.ReSharper.Feature.Services.Intentions.CreateDeclaration.CreateFieldDeclarationContext CreateContext() { }
        protected override JetBrains.ReSharper.Feature.Services.Intentions.IntentionResult ExecuteIntention(JetBrains.ReSharper.Feature.Services.Intentions.CreateDeclaration.CreateFieldDeclarationContext context) { }
        public override JetBrains.ReSharper.Intentions.CreateFromUsage.ICreatedElementConsistencyGroup GetConsistencyGroup() { }
        protected override JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.ICreationTarget GetTarget() { }
        protected override bool IsAvailableInternal() { }
    }
    public class CreateFromUsageFix : JetBrains.ReSharper.Intentions.CreateFromUsage.CreateFromUsageFixBase
    {
        public CreateFromUsageFix(JetBrains.ReSharper.Daemon.VB.Errors.NotResolvedError err) { }
        public CreateFromUsageFix(JetBrains.ReSharper.Daemon.VB.Errors.CannotConvertTypeInArgumentError err) { }
        public CreateFromUsageFix(JetBrains.ReSharper.Daemon.VB.Errors.CannotConvertTypeInArgumentWarning err) { }
        public CreateFromUsageFix(JetBrains.ReSharper.Daemon.VB.Errors.ImpossibleConvertTypeInArgumentWarning err) { }
        public CreateFromUsageFix(JetBrains.ReSharper.Daemon.VB.Errors.IncorrectArgumentTypesError err) { }
        public CreateFromUsageFix(JetBrains.ReSharper.Daemon.VB.Errors.IncorrectArgumentNumberMultipleCandidatesError err) { }
        public CreateFromUsageFix(JetBrains.ReSharper.Daemon.VB.Errors.ArgumentsMismatchError err) { }
        public CreateFromUsageFix(JetBrains.ReSharper.Daemon.VB.Errors.IncorrectArgumentNumberError err) { }
        public CreateFromUsageFix(JetBrains.ReSharper.Daemon.VB.Errors.StrictnessFailedError err) { }
        public CreateFromUsageFix(JetBrains.ReSharper.Daemon.VB.Errors.MoreApplicableNotFoundError err) { }
        public CreateFromUsageFix(JetBrains.ReSharper.Daemon.VB.Errors.NoMatchingInInterfaceError err) { }
        public CreateFromUsageFix(JetBrains.ReSharper.Daemon.VB.Errors.NoMatchingInInterfaceMultipleCandidatesError err) { }
        public CreateFromUsageFix(JetBrains.ReSharper.Daemon.VB.Errors.IncorrectSignatureInDelegateCreationError err) { }
        public CreateFromUsageFix(JetBrains.ReSharper.Daemon.VB.Errors.IncorrectSignatureInDelegateCreationMultipleCandidatesError err) { }
        public CreateFromUsageFix(JetBrains.ReSharper.Daemon.VB.Errors.MoreSpecificNotFoundError err) { }
        public CreateFromUsageFix(JetBrains.ReSharper.Daemon.VB.Errors.NoTypeParametersInCandidateError err) { }
        public CreateFromUsageFix(JetBrains.ReSharper.Daemon.VB.Errors.TypeParametersNumberMismatchError err) { }
        public CreateFromUsageFix(JetBrains.ReSharper.Daemon.VB.Errors.TypeParametersNumberMismatchMultipleCandidatesError err) { }
        public CreateFromUsageFix(JetBrains.ReSharper.Daemon.VB.Errors.TypeExpectedNoCandidateError err) { }
        public CreateFromUsageFix(JetBrains.ReSharper.Daemon.VB.Errors.NoTypeArgumentsInUsageError err) { }
        public CreateFromUsageFix(JetBrains.ReSharper.Daemon.VB.Errors.AccessRightsError err) { }
        public CreateFromUsageFix(JetBrains.ReSharper.Daemon.VB.Errors.MultipleAccessRightsError err) { }
        public CreateFromUsageFix(JetBrains.ReSharper.Daemon.VB.Errors.MultipleAccessRights2Error err) { }
        public CreateFromUsageFix(JetBrains.ReSharper.Daemon.VB.Errors.FieldExpectedNoCandidateError err) { }
        public CreateFromUsageFix(JetBrains.ReSharper.Daemon.VB.Errors.NotValidError err) { }
        public CreateFromUsageFix(JetBrains.ReSharper.Daemon.VB.Errors.MethodExpectedError err) { }
        public CreateFromUsageFix(JetBrains.ReSharper.Daemon.VB.Errors.MethodExpectedMultipleCandidatesError err) { }
    }
    public class CreateLocalFromUsageFix : JetBrains.ReSharper.Intentions.Extensibility.BulbActionBase, JetBrains.ReSharper.Intentions.CreateFromUsage.ICreateFromUsageAction
    {
        public CreateLocalFromUsageFix(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public JetBrains.ReSharper.Intentions.Extensibility.IBulbAction GetBulbItem() { }
        public JetBrains.ReSharper.Intentions.CreateFromUsage.ICreatedElementConsistencyGroup GetConsistencyGroup() { }
    }
    public class CreateMethodForDelegateAction : JetBrains.ReSharper.Intentions.CreateFromUsage.CreateFromUsageActionBase2<JetBrains.ReSharper.Feature.Services.Intentions.CreateDeclaration.CreateMethodDeclarationContext, JetBrains.ReSharper.Psi.Resolve.IReference>
    {
        public CreateMethodForDelegateAction(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public override string Text { get; }
        protected void $VB$ClosureStub_UpdateContextAndExecute_MyBase(JetBrains.ReSharper.Feature.Services.Intentions.CreateDeclaration.CreateMethodDeclarationContext p0, JetBrains.ProjectModel.ISolution p1, JetBrains.TextControl.ITextControl p2) { }
        protected override JetBrains.ReSharper.Feature.Services.Intentions.CreateDeclaration.CreateMethodDeclarationContext CreateContext() { }
        protected override JetBrains.ReSharper.Feature.Services.Intentions.IntentionResult ExecuteIntention(JetBrains.ReSharper.Feature.Services.Intentions.CreateDeclaration.CreateMethodDeclarationContext context) { }
        public override JetBrains.ReSharper.Intentions.CreateFromUsage.ICreatedElementConsistencyGroup GetConsistencyGroup() { }
        public static JetBrains.ReSharper.Psi.Resolve.IResolveResult GetDelegate(JetBrains.ReSharper.Psi.Resolve.IReference qualifiableReference) { }
        protected override JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.ICreationTarget GetTarget() { }
        protected virtual string GetTextFormat() { }
        protected override bool IsAvailableInternal() { }
        protected override void UpdateContextAndExecute(JetBrains.ReSharper.Feature.Services.Intentions.CreateDeclaration.CreateMethodDeclarationContext context, JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
    }
    public class CreateMethodFromUsageAction : JetBrains.ReSharper.Intentions.CreateFromUsage.CreateFromUsageActionBase2<JetBrains.ReSharper.Feature.Services.Intentions.CreateDeclaration.CreateMethodDeclarationContext, JetBrains.ReSharper.Psi.Resolve.IReference>
    {
        public CreateMethodFromUsageAction(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public override string Text { get; }
        protected override JetBrains.ReSharper.Feature.Services.Intentions.CreateDeclaration.CreateMethodDeclarationContext CreateContext() { }
        protected override JetBrains.ReSharper.Feature.Services.Intentions.IntentionResult ExecuteIntention(JetBrains.ReSharper.Feature.Services.Intentions.CreateDeclaration.CreateMethodDeclarationContext context) { }
        public override JetBrains.ReSharper.Intentions.CreateFromUsage.ICreatedElementConsistencyGroup GetConsistencyGroup() { }
        protected override JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.ICreationTarget GetTarget() { }
        protected static string GetTargetMethodName(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        protected virtual string GetTextFormat() { }
        protected override bool IsAvailableInternal() { }
    }
    public class CreateNestedClassFromQualifierFix : JetBrains.ReSharper.Intentions.VB.QuickFixes.CreateClassFromQualifierBase
    {
        public CreateNestedClassFromQualifierFix(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        protected override string GetItemText() { }
        protected override JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.ICreationTarget GetTarget() { }
        protected override bool IsAvailableInternal() { }
    }
    public class CreateNestedClassFromUsageFix : JetBrains.ReSharper.Intentions.VB.QuickFixes.CreateClassFromUsageFixBase
    {
        public CreateNestedClassFromUsageFix(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        protected override string GetItemText() { }
        protected override JetBrains.ReSharper.Psi.VB.Tree.IVBTreeNode GetScope() { }
        protected override JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.ICreationTarget GetTarget() { }
        protected override bool IsAvailableInternal() { }
        protected override bool IsQualifierRedundant(JetBrains.ReSharper.Psi.IDeclaredElement element) { }
    }
    public class CreateNestedDelegateFromUsageFix : JetBrains.ReSharper.Intentions.VB.QuickFixes.CreateDelegateFixBase
    {
        public CreateNestedDelegateFromUsageFix(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public override string Text { get; }
        protected override JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.ICreationTarget GetTarget() { }
    }
    public class CreateParameterAndUpdateUsagesItem : JetBrains.ReSharper.Intentions.Extensibility.BulbActionBase, JetBrains.ReSharper.Intentions.CreateFromUsage.ICreateFromUsageAction
    {
        public CreateParameterAndUpdateUsagesItem(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public JetBrains.ReSharper.Intentions.Extensibility.IBulbAction GetBulbItem() { }
        public JetBrains.ReSharper.Intentions.CreateFromUsage.ICreatedElementConsistencyGroup GetConsistencyGroup() { }
    }
    public class CreateParameterFromUsageFix
    {
        public static JetBrains.ReSharper.Psi.IParametersOwner GetParametersOwner(JetBrains.ReSharper.Psi.Tree.ITreeNode referenceExpression) { }
        public static JetBrains.ReSharper.Psi.IType GetTypeFromConstraints(System.Collections.Generic.IList<JetBrains.ReSharper.Psi.ExpectedTypes.ExpectedType> types, JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public static bool MayBeOverriden(JetBrains.ReSharper.Psi.ITypeMember overridableMember) { }
    }
    public class CreateParameterItem : JetBrains.ReSharper.Intentions.Extensibility.BulbActionBase, JetBrains.ReSharper.Intentions.CreateFromUsage.ICreateFromUsageAction
    {
        public CreateParameterItem(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public JetBrains.ReSharper.Intentions.Extensibility.IBulbAction GetBulbItem() { }
        public JetBrains.ReSharper.Intentions.CreateFromUsage.ICreatedElementConsistencyGroup GetConsistencyGroup() { }
    }
    public class CreatePropertyFromInitializerFix : JetBrains.ReSharper.Intentions.CreateFromUsage.CreateFromUsageActionBase2<JetBrains.ReSharper.Feature.Services.Intentions.CreateDeclaration.CreatePropertyDeclarationContext, JetBrains.ReSharper.Psi.Resolve.IReference>
    {
        public CreatePropertyFromInitializerFix(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public override string Text { get; }
        protected override JetBrains.ReSharper.Feature.Services.Intentions.CreateDeclaration.CreatePropertyDeclarationContext CreateContext() { }
        protected override JetBrains.ReSharper.Feature.Services.Intentions.IntentionResult ExecuteIntention(JetBrains.ReSharper.Feature.Services.Intentions.CreateDeclaration.CreatePropertyDeclarationContext context) { }
        public override JetBrains.ReSharper.Intentions.CreateFromUsage.ICreatedElementConsistencyGroup GetConsistencyGroup() { }
        protected override JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.ICreationTarget GetTarget() { }
        protected override bool IsAvailableInternal() { }
    }
    public class CreatePropertyFromUsageFix : JetBrains.ReSharper.Intentions.VB.QuickFixes.CreateFromUsage.Property.CreatePropertyFromUsageFixBase
    {
        public CreatePropertyFromUsageFix(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public override string Text { get; }
        protected virtual string TextFormat() { }
    }
    public class CreatePropertyInAttributeFix : JetBrains.ReSharper.Intentions.CreateFromUsage.CreateFromUsageActionBase2<JetBrains.ReSharper.Feature.Services.Intentions.CreateDeclaration.CreatePropertyDeclarationContext, JetBrains.ReSharper.Psi.Resolve.IReference>
    {
        public CreatePropertyInAttributeFix(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public override string Text { get; }
        protected override JetBrains.ReSharper.Feature.Services.Intentions.CreateDeclaration.CreatePropertyDeclarationContext CreateContext() { }
        protected override JetBrains.ReSharper.Feature.Services.Intentions.IntentionResult ExecuteIntention(JetBrains.ReSharper.Feature.Services.Intentions.CreateDeclaration.CreatePropertyDeclarationContext context) { }
        public override JetBrains.ReSharper.Intentions.CreateFromUsage.ICreatedElementConsistencyGroup GetConsistencyGroup() { }
        protected override JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.ICreationTarget GetTarget() { }
        protected override bool IsAvailableInternal() { }
    }
    public class CreateReadOnlyPropertyFromUsageFix : JetBrains.ReSharper.Intentions.VB.QuickFixes.CreateFromUsage.Property.CreatePropertyFromUsageFixBase
    {
        public CreateReadOnlyPropertyFromUsageFix(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public override string Text { get; }
        protected override JetBrains.ReSharper.Feature.Services.Intentions.CreateDeclaration.CreatePropertyDeclarationContext CreateContext() { }
        protected override bool IsAvailableInternal() { }
        protected virtual string TextFormat() { }
    }
    public class EnumerateToArrayFix : JetBrains.ReSharper.Intentions.VB.QuickFixes.MultipleEnumerationFixBase
    {
        public EnumerateToArrayFix(JetBrains.ReSharper.Daemon.VB.Errors.PossibleMultipleEnumerationWarning warning) { }
        public override string Text { get; }
        protected override void EnumerateGenericIEnumerable(JetBrains.ReSharper.Psi.IType enumerableType, JetBrains.ReSharper.Psi.VB.Tree.IVBExpression valueExpression) { }
        protected override void EnumerateIEnumerable(JetBrains.ReSharper.Psi.VB.Tree.IVBExpression valueExpression) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class EnumerateToListFix : JetBrains.ReSharper.Intentions.VB.QuickFixes.MultipleEnumerationFixBase
    {
        public EnumerateToListFix(JetBrains.ReSharper.Daemon.VB.Errors.PossibleMultipleEnumerationWarning warning) { }
        public override string Text { get; }
        protected override void EnumerateGenericIEnumerable(JetBrains.ReSharper.Psi.IType enumerableType, JetBrains.ReSharper.Psi.VB.Tree.IVBExpression valueExpression) { }
        protected override void EnumerateIEnumerable(JetBrains.ReSharper.Psi.VB.Tree.IVBExpression valueExpression) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class EnumerateWithAsArrayMethodFix : JetBrains.ReSharper.Intentions.VB.QuickFixes.MultipleEnumerationFixBase
    {
        public EnumerateWithAsArrayMethodFix(JetBrains.ReSharper.Daemon.VB.Errors.PossibleMultipleEnumerationWarning warning) { }
        public override string Text { get; }
        protected override void EnumerateGenericIEnumerable(JetBrains.ReSharper.Psi.IType enumerableType, JetBrains.ReSharper.Psi.VB.Tree.IVBExpression valueExpression) { }
        protected override void EnumerateIEnumerable(JetBrains.ReSharper.Psi.VB.Tree.IVBExpression valueExpression) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class EnumerateWithAsListMethodFix : JetBrains.ReSharper.Intentions.VB.QuickFixes.MultipleEnumerationFixBase
    {
        public EnumerateWithAsListMethodFix(JetBrains.ReSharper.Daemon.VB.Errors.PossibleMultipleEnumerationWarning warning) { }
        public override string Text { get; }
        protected override void EnumerateGenericIEnumerable(JetBrains.ReSharper.Psi.IType enumerableType, JetBrains.ReSharper.Psi.VB.Tree.IVBExpression valueExpression) { }
        protected override void EnumerateIEnumerable(JetBrains.ReSharper.Psi.VB.Tree.IVBExpression valueExpression) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class FixAsyncMethodReturnTypeFix : JetBrains.ReSharper.Intentions.VB.QuickFixes.FixReturnTypeFixBase
    {
        public FixAsyncMethodReturnTypeFix(JetBrains.ReSharper.Psi.VB.Tree.IMethodDeclaration methodDeclaration) { }
        protected override JetBrains.ReSharper.Psi.VB.Tree.IVBDeclaration Declaration { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
    }
    public class FixAsyncMethodReturnTypeFix2 : JetBrains.ReSharper.Intentions.VB.QuickFixes.FixReturnTypeFixBase
    {
        public FixAsyncMethodReturnTypeFix2(JetBrains.ReSharper.Psi.VB.Tree.IMethodDeclaration methodDeclaration) { }
        protected override JetBrains.ReSharper.Psi.VB.Tree.IVBDeclaration Declaration { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        protected override JetBrains.ReSharper.Psi.IType GetAsyncElementReturnType() { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class FixFloatingPointComparingFix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public FixFloatingPointComparingFix(JetBrains.ReSharper.Daemon.VB.Errors.CompareOfFloatsByEqualityOperatorWarning warning) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public abstract class FixReturnTypeFixBase : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        protected abstract JetBrains.ReSharper.Psi.VB.Tree.IVBDeclaration Declaration { get; }
        public override string Text { get; }
        protected virtual JetBrains.ReSharper.Psi.IType GetAsyncElementReturnType() { }
        protected JetBrains.ReSharper.Psi.IType GetAsyncReturnType() { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class ImplementMemberFix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public ImplementMemberFix(JetBrains.ReSharper.Daemon.VB.Errors.MissingMemberImplementationError error) { }
        public ImplementMemberFix(JetBrains.ReSharper.Daemon.VB.Errors.MissingMemberImplementation2Error error) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class ImplementsVsInheritsKeywordsImplementsFix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public ImplementsVsInheritsKeywordsImplementsFix(JetBrains.ReSharper.Daemon.VB.Errors.ImplementKeywordWithNotInterfaceError error) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class ImplementsVsInheritsKeywordsInheritsFix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public ImplementsVsInheritsKeywordsInheritsFix(JetBrains.ReSharper.Daemon.VB.Errors.ClassShouldInheritClassError error) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class ImportMethodFixItem : JetBrains.ReSharper.Feature.Services.Bulbs.BulbItemImpl
    {
        public ImportMethodFixItem(System.Collections.Generic.KeyValuePair<JetBrains.ReSharper.Psi.INamespace, System.Collections.Generic.IList<JetBrains.ReSharper.Psi.IMethod>> method, JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public System.Collections.Generic.KeyValuePair<JetBrains.ReSharper.Psi.INamespace, System.Collections.Generic.IList<JetBrains.ReSharper.Psi.IMethod>> Methods { get; }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
    }
    public class ImportMethodQuickFix : JetBrains.ReSharper.Intentions.Extensibility.IQuickFix
    {
        public ImportMethodQuickFix(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public ImportMethodQuickFix(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.Resolve.ResolveErrorType[] acceptedResolveErrors) { }
        public ImportMethodQuickFix(JetBrains.ReSharper.Daemon.VB.Errors.NotResolvedError error) { }
        public ImportMethodQuickFix(JetBrains.ReSharper.Daemon.VB.Errors.NoTypeArgumentsInUsageError error) { }
        public ImportMethodQuickFix(JetBrains.ReSharper.Daemon.VB.Errors.NoTypeParametersInCandidateError error) { }
        public ImportMethodQuickFix(JetBrains.ReSharper.Daemon.VB.Errors.TypeParametersNumberMismatchError error) { }
        public ImportMethodQuickFix(JetBrains.ReSharper.Daemon.VB.Errors.TypeParametersNumberMismatchMultipleCandidatesError error) { }
        public ImportMethodQuickFix(JetBrains.ReSharper.Daemon.VB.Errors.IncorrectArgumentNumberError error) { }
        public ImportMethodQuickFix(JetBrains.ReSharper.Daemon.VB.Errors.IncorrectArgumentNumberMultipleCandidatesError error) { }
        public ImportMethodQuickFix(JetBrains.ReSharper.Daemon.VB.Errors.TypeInferenceError error) { }
        public ImportMethodQuickFix(JetBrains.ReSharper.Daemon.VB.Errors.QueryTypeInferenceError error) { }
        public ImportMethodQuickFix(JetBrains.ReSharper.Daemon.VB.Errors.TypeInferenceMultipleCandidatesError error) { }
        public ImportMethodQuickFix(JetBrains.ReSharper.Daemon.VB.Errors.QueryTypeInferenceMultipleCandidatesError error) { }
        public ImportMethodQuickFix(JetBrains.ReSharper.Daemon.VB.Errors.CannotConvertTypeInArgumentError error) { }
        public ImportMethodQuickFix(JetBrains.ReSharper.Daemon.VB.Errors.CannotConvertTypeInArgumentWarning error) { }
        public ImportMethodQuickFix(JetBrains.ReSharper.Daemon.VB.Errors.ImpossibleConvertTypeInArgumentWarning error) { }
        public ImportMethodQuickFix(JetBrains.ReSharper.Daemon.VB.Errors.IncorrectArgumentTypesError error) { }
        public ImportMethodQuickFix(JetBrains.ReSharper.Daemon.VB.Errors.StrictnessFailedError error) { }
        public ImportMethodQuickFix(JetBrains.ReSharper.Daemon.VB.Errors.MoreApplicableNotFoundError error) { }
        public ImportMethodQuickFix(JetBrains.ReSharper.Daemon.VB.Errors.MoreSpecificNotFoundError error) { }
        public virtual JetBrains.ReSharper.Intentions.Extensibility.IBulbAction[] Items { get; }
        public JetBrains.ReSharper.Psi.Resolve.IReference Reference { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        protected virtual bool FilterByModule(JetBrains.ReSharper.Psi.IMethod method, JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
        protected JetBrains.Util.OneToListMap<JetBrains.ReSharper.Psi.INamespace, JetBrains.ReSharper.Psi.IMethod> Suggestions() { }
    }
    public class ImportMethodQuickPopupFix : JetBrains.ReSharper.Intentions.VB.QuickFixes.ImportMethodQuickFix, JetBrains.ReSharper.Intentions.Extensibility.IPopupBulbAction
    {
        public ImportMethodQuickPopupFix(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.Resolve.ResolveErrorType[] acceptedResolveErrors) { }
        public ImportMethodQuickPopupFix(JetBrains.ReSharper.Daemon.VB.Errors.NotResolvedError error) { }
        public ImportMethodQuickPopupFix(JetBrains.ReSharper.Daemon.VB.Errors.MultipleResolveCandidatesError error) { }
        public ImportMethodQuickPopupFix(JetBrains.ReSharper.Daemon.VB.Errors.NoTypeArgumentsInUsageError error) { }
        public ImportMethodQuickPopupFix(JetBrains.ReSharper.Daemon.VB.Errors.NoTypeParametersInCandidateError error) { }
        public ImportMethodQuickPopupFix(JetBrains.ReSharper.Daemon.VB.Errors.TypeParametersNumberMismatchError error) { }
        public ImportMethodQuickPopupFix(JetBrains.ReSharper.Daemon.VB.Errors.TypeParametersNumberMismatchMultipleCandidatesError error) { }
        public ImportMethodQuickPopupFix(JetBrains.ReSharper.Daemon.VB.Errors.IncorrectArgumentNumberError error) { }
        public ImportMethodQuickPopupFix(JetBrains.ReSharper.Daemon.VB.Errors.IncorrectArgumentNumberMultipleCandidatesError error) { }
        public JetBrains.UI.Anchoring2D[] PopupAnchorings { get; }
        public JetBrains.ReSharper.Intentions.Extensibility.IBulbAction[] PopupBulbActionItems { get; }
        public string PopupKey { get; }
        public string PopupMenuCaption { get; }
        public void FillMenuItemDescriptor(JetBrains.ReSharper.Intentions.Extensibility.IBulbAction key, JetBrains.UI.PopupMenu.IMenuItemDescriptor descriptor) { }
        public bool IPopupBulbActionIsAvailable(JetBrains.Util.IUserDataHolder cache) { }
        public void OnPopupShown(JetBrains.DataFlow.Lifetime showingLifetime) { }
    }
    public class IncreaseVisibilityFix : JetBrains.ReSharper.Intentions.QuickFixes.IncreaseVisibilityFixBase
    {
        public IncreaseVisibilityFix(JetBrains.ReSharper.Daemon.VB.Errors.InconsistentAccessibilityInDerivationError error) { }
        public IncreaseVisibilityFix(JetBrains.ReSharper.Daemon.VB.Errors.InconsistentAccessibilityInMemberTypeError error) { }
        public IncreaseVisibilityFix(JetBrains.ReSharper.Daemon.VB.Errors.InconsistentAccessibilityInParameterTypeError error) { }
        public IncreaseVisibilityFix(JetBrains.ReSharper.Daemon.VB.Errors.InconsistentAccessibilityInReturnTypeError error) { }
        public IncreaseVisibilityFix(JetBrains.ReSharper.Daemon.VB.Errors.InconsistentAccessibilityInTypeArgumentError error) { }
        public IncreaseVisibilityFix(JetBrains.ReSharper.Daemon.VB.Errors.InconsistentAccessibilityInTypeParameterConstraintError error) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class InvokeAsExtensionMethodFix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public InvokeAsExtensionMethodFix(JetBrains.ReSharper.Daemon.VB.Errors.InvokeAsExtensionMethodWarning warning) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class MakeNonReadonly3Fix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public MakeNonReadonly3Fix(JetBrains.ReSharper.Daemon.VB.Errors.PossibleAssignmentToReadonlyFieldWarning error) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class MakeNotInheritableFix : JetBrains.ReSharper.Intentions.QuickFixes.ModifierFixBase
    {
        public MakeNotInheritableFix(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
        protected override string ModifiersText { get; }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
        protected override void SetModifiers(JetBrains.ReSharper.Psi.Tree.IModifiersOwnerDeclaration declaration) { }
    }
    public class MakePropertyReadOnlyFix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public MakePropertyReadOnlyFix(JetBrains.ReSharper.Daemon.VB.Errors.PropertyMustHaveSetterAndGetterError error) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class MakePropertyWriteOnlyFix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public MakePropertyWriteOnlyFix(JetBrains.ReSharper.Daemon.VB.Errors.PropertyMustHaveSetterAndGetterError error) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class MergeTryStatementsFix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public MergeTryStatementsFix(JetBrains.ReSharper.Daemon.VB.Errors.TryStatementsCanBeMergedWarning warning) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public abstract class MultipleEnumerationFixBase : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        protected MultipleEnumerationFixBase(JetBrains.ReSharper.Daemon.VB.Errors.PossibleMultipleEnumerationWarning warning) { }
        protected abstract void EnumerateGenericIEnumerable(JetBrains.ReSharper.Psi.IType enumerableType, JetBrains.ReSharper.Psi.VB.Tree.IVBExpression valueExpression);
        protected abstract void EnumerateIEnumerable(JetBrains.ReSharper.Psi.VB.Tree.IVBExpression valueExpression);
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class OptimizeImportsFix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public OptimizeImportsFix(JetBrains.ReSharper.Daemon.VB.Errors.UnusedImportClauseWarning highlight) { }
        public override string Text { get; }
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        public override void Execute(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class ReferenceMethodQuickFix : JetBrains.ReSharper.Intentions.Extensibility.IQuickFix
    {
        public ReferenceMethodQuickFix(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public ReferenceMethodQuickFix(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.Resolve.ResolveErrorType[] acceptedResolveErrors) { }
        public ReferenceMethodQuickFix(JetBrains.ReSharper.Daemon.VB.Errors.NotResolvedError error) { }
        public ReferenceMethodQuickFix(JetBrains.ReSharper.Daemon.VB.Errors.MultipleResolveCandidatesError error) { }
        public ReferenceMethodQuickFix(JetBrains.ReSharper.Daemon.VB.Errors.NoTypeArgumentsInUsageError error) { }
        public ReferenceMethodQuickFix(JetBrains.ReSharper.Daemon.VB.Errors.NoTypeParametersInCandidateError error) { }
        public ReferenceMethodQuickFix(JetBrains.ReSharper.Daemon.VB.Errors.TypeParametersNumberMismatchError error) { }
        public ReferenceMethodQuickFix(JetBrains.ReSharper.Daemon.VB.Errors.TypeParametersNumberMismatchMultipleCandidatesError error) { }
        public ReferenceMethodQuickFix(JetBrains.ReSharper.Daemon.VB.Errors.IncorrectArgumentNumberError error) { }
        public ReferenceMethodQuickFix(JetBrains.ReSharper.Daemon.VB.Errors.IncorrectArgumentNumberMultipleCandidatesError error) { }
        public ReferenceMethodQuickFix(JetBrains.ReSharper.Daemon.VB.Errors.TypeInferenceError error) { }
        public ReferenceMethodQuickFix(JetBrains.ReSharper.Daemon.VB.Errors.QueryTypeInferenceError error) { }
        public ReferenceMethodQuickFix(JetBrains.ReSharper.Daemon.VB.Errors.TypeInferenceMultipleCandidatesError error) { }
        public ReferenceMethodQuickFix(JetBrains.ReSharper.Daemon.VB.Errors.QueryTypeInferenceMultipleCandidatesError error) { }
        public ReferenceMethodQuickFix(JetBrains.ReSharper.Daemon.VB.Errors.CannotConvertTypeInArgumentError error) { }
        public ReferenceMethodQuickFix(JetBrains.ReSharper.Daemon.VB.Errors.CannotConvertTypeInArgumentWarning error) { }
        public ReferenceMethodQuickFix(JetBrains.ReSharper.Daemon.VB.Errors.ImpossibleConvertTypeInArgumentWarning error) { }
        public ReferenceMethodQuickFix(JetBrains.ReSharper.Daemon.VB.Errors.IncorrectArgumentTypesError error) { }
        public ReferenceMethodQuickFix(JetBrains.ReSharper.Daemon.VB.Errors.StrictnessFailedError error) { }
        public ReferenceMethodQuickFix(JetBrains.ReSharper.Daemon.VB.Errors.MoreApplicableNotFoundError error) { }
        public ReferenceMethodQuickFix(JetBrains.ReSharper.Daemon.VB.Errors.MoreSpecificNotFoundError error) { }
        public virtual JetBrains.ReSharper.Intentions.Extensibility.IBulbAction[] Items { get; }
        public JetBrains.ReSharper.Psi.Resolve.IReference Reference { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        public bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class RemoveAsyncModifierFix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public RemoveAsyncModifierFix(JetBrains.ReSharper.Psi.VB.Tree.IVBDeclaration declaration) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class RemoveAwaitFix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public RemoveAwaitFix(JetBrains.ReSharper.Psi.VB.Tree.IAwaitExpression awaitExpression) { }
        public override string Text { get; }
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class RemoveCaseStatementFix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public RemoveCaseStatementFix(JetBrains.ReSharper.Daemon.VB.Errors.RedundantEmptyCaseElseWarning warning) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class RemoveExceptionFix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public RemoveExceptionFix(JetBrains.ReSharper.Daemon.VB.Errors.PossibleIntendedRethrowWarning warning) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class RemoveExplicitArraySizeFix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public RemoveExplicitArraySizeFix(JetBrains.ReSharper.Daemon.VB.Errors.RedundantExplicitArraySizeWarning warning) { }
        public RemoveExplicitArraySizeFix(JetBrains.ReSharper.Daemon.VB.Errors.PartialArrayBoundsSpecificationError error) { }
        public RemoveExplicitArraySizeFix(JetBrains.ReSharper.Daemon.VB.Errors.ExplicitInitializationForArrayWithExplicitBoundsError error) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class RemoveIteratorModifierFix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public RemoveIteratorModifierFix(JetBrains.ReSharper.Psi.VB.Tree.IVBDeclaration declaration) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class RemoveModifierFix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public RemoveModifierFix(JetBrains.ReSharper.Psi.Tree.ITokenNode modifier, JetBrains.ReSharper.Psi.VB.Tree.IModifiersList modifiersList) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class RemoveRedundantCastFix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public RemoveRedundantCastFix(JetBrains.ReSharper.Daemon.VB.Errors.RedundantCastWarning warning) { }
        public RemoveRedundantCastFix(JetBrains.ReSharper.Daemon.VB.Errors.RedundantDirectCastWithValueTypeWarning warning) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class RemoveRedundantQualifierFix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public RemoveRedundantQualifierFix(JetBrains.ReSharper.Psi.Tree.ITreeNode qualifier) { }
        public override string Text { get; }
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class RemoveTypeArgumentsFix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public RemoveTypeArgumentsFix(JetBrains.ReSharper.Daemon.VB.Errors.NoTypeParametersInCandidateError error) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class RemoveUnreachableCodeFix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public RemoveUnreachableCodeFix(JetBrains.ReSharper.Daemon.VB.Errors.UnreachableCodeWarning error) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class ReplaceConditionalWithBranchFix : JetBrains.ReSharper.Intentions.VB.QuickFixes.ReplaceFixBase
    {
        public ReplaceConditionalWithBranchFix(JetBrains.ReSharper.Daemon.VB.Errors.ConditionalTernaryEqualBranchWarning warning) { }
    }
    public abstract class ReplaceFixBase : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        protected ReplaceFixBase(JetBrains.ReSharper.Psi.VB.Tree.IVBExpression expressionToReplace, JetBrains.ReSharper.Psi.VB.Tree.IVBExpression expressionToSubstitute, string text) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class ReplaceIIfWithBranchFix : JetBrains.ReSharper.Intentions.VB.QuickFixes.ReplaceFixBase
    {
        public ReplaceIIfWithBranchFix(JetBrains.ReSharper.Daemon.VB.Errors.IIfEqualBranchWarning warning) { }
    }
    public class ReplaceWithBoolConstFix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public ReplaceWithBoolConstFix(JetBrains.ReSharper.Daemon.VB.Errors.RedundantLogicalConditionalExpressionOperandWarning warning) { }
        public ReplaceWithBoolConstFix(JetBrains.ReSharper.Daemon.VB.Errors.EqualExpressionComparisonWarning warning) { }
        public ReplaceWithBoolConstFix(JetBrains.ReSharper.Daemon.VB.Errors.ConditionIsAlwaysTrueOrFalseWarning warning) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class ReplaceWithOperatorIsFix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public ReplaceWithOperatorIsFix(JetBrains.ReSharper.Daemon.VB.Errors.OperatorIsCanBeUsedWarning warning) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class ReplaceWithTryCastAndCheckForNullFix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public ReplaceWithTryCastAndCheckForNullFix(JetBrains.ReSharper.Daemon.VB.Errors.CanBeReplacedWithTryCastAndCheckForNullWarning warning) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class ReplaceWithUppercaseSuffixFix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public ReplaceWithUppercaseSuffixFix(JetBrains.ReSharper.Daemon.VB.Errors.LongLiteralEndingLowerLWarning warning) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class SimplifyConditionalOperatorFix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public SimplifyConditionalOperatorFix(JetBrains.ReSharper.Daemon.VB.Errors.SimplifyConditionalOperatorWarning warning) { }
        public SimplifyConditionalOperatorFix(JetBrains.ReSharper.Daemon.VB.Errors.SimplifyIIfWarning warning) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class SpecifyStringComparisonFix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public SpecifyStringComparisonFix(JetBrains.ReSharper.Daemon.VB.Errors.SpecifyStringComparisonWarning warning) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.QuickFixAttribute()]
    public class UnmarkNullnessFix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public UnmarkNullnessFix(JetBrains.ReSharper.Daemon.VB.Errors.AnnotationRedundanceInHierarchyWarning warning) { }
        public UnmarkNullnessFix(JetBrains.ReSharper.Daemon.VB.Errors.AnnotationConflictInHierarchyWarning warning) { }
        public UnmarkNullnessFix(JetBrains.ReSharper.Daemon.VB.Errors.AnnotationRedundanceAtValueTypeWarning warning) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public abstract class VBAddAccessorFixBase : JetBrains.ReSharper.Intentions.QuickFixes.AddAccessorFixBase
    {
        protected VBAddAccessorFixBase(JetBrains.ReSharper.Psi.IProperty property, JetBrains.ReSharper.Intentions.QuickFixes.AddAccessorFixBase.AccessorPrefix accessorPrefix) { }
        protected VBAddAccessorFixBase(JetBrains.ReSharper.Psi.IProperty property) { }
        public override string Text { get; }
    }
    [System.ObsoleteAttribute("Use ChangeTypeFix")]
    public class VBChangeTypeFix : JetBrains.ReSharper.Intentions.QuickFixes.QuickFix
    {
        public VBChangeTypeFix(JetBrains.ReSharper.Daemon.VB.Errors.CannotConvertTypeInArgumentError error) { }
        public VBChangeTypeFix(JetBrains.ReSharper.Daemon.VB.Errors.CannotConvertTypeInArgumentWarning error) { }
        public VBChangeTypeFix(JetBrains.ReSharper.Daemon.VB.Errors.ImpossibleConvertTypeInArgumentWarning error) { }
        public VBChangeTypeFix(JetBrains.ReSharper.Daemon.VB.Errors.CannotConvertTypeInMemberInitializerError error) { }
        public VBChangeTypeFix(JetBrains.ReSharper.Daemon.VB.Errors.CannotConvertTypeInMemberInitializerWarning error) { }
        public VBChangeTypeFix(JetBrains.ReSharper.Daemon.VB.Errors.ImpossibleConvertTypeInMemberInitializerWarning error) { }
        public VBChangeTypeFix(JetBrains.ReSharper.Daemon.VB.Errors.IncorrectArrayElementTypeError error) { }
        public VBChangeTypeFix(JetBrains.ReSharper.Daemon.VB.Errors.CannotConvertTypeInAssignmentError error) { }
        public VBChangeTypeFix(JetBrains.ReSharper.Daemon.VB.Errors.CannotConvertTypeInAssignmentWarning error) { }
        public VBChangeTypeFix(JetBrains.ReSharper.Daemon.VB.Errors.ImpossibleConvertTypeInAssignmentWarning error) { }
        public VBChangeTypeFix(JetBrains.ReSharper.Daemon.VB.Errors.CannotConvertTypeInDeclarationError error) { }
        public VBChangeTypeFix(JetBrains.ReSharper.Daemon.VB.Errors.CannotConvertTypeInDeclarationWarning error) { }
        public VBChangeTypeFix(JetBrains.ReSharper.Daemon.VB.Errors.ImpossibleConvertTypeInDeclarationWarning error) { }
        public VBChangeTypeFix(JetBrains.ReSharper.Daemon.VB.Errors.CannotConvertTypeInReturnError error) { }
        public VBChangeTypeFix(JetBrains.ReSharper.Daemon.VB.Errors.CannotConvertTypeInReturnWarning error) { }
        public VBChangeTypeFix(JetBrains.ReSharper.Daemon.VB.Errors.ImpossibleConvertTypeInReturnWarning error) { }
        public VBChangeTypeFix(JetBrains.ReSharper.Daemon.VB.Errors.CannotDetermineNullCoalescingExpressionType2Error error) { }
        public VBChangeTypeFix(JetBrains.ReSharper.Daemon.VB.Errors.CannotDetermineNullCoalescingExpressionTypeError error) { }
        public VBChangeTypeFix(JetBrains.ReSharper.Daemon.VB.Errors.CannotDetermineTernaryExpressionTypeError error) { }
        public VBChangeTypeFix(JetBrains.ReSharper.Daemon.VB.Errors.CannotDetermineTernaryExpressionType2Error error) { }
        public VBChangeTypeFix(JetBrains.ReSharper.Daemon.VB.Errors.WrongReturnTypeOfAsyncLambdaError error) { }
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.VB.VBLanguage))]
    public class VBImportTypeUtilComponent : JetBrains.ReSharper.Intentions.QuickFixes.IImportTypeUtilComponent
    {
        public System.Collections.Generic.IList<JetBrains.ReSharper.Psi.ITypeElement> Alternatives(JetBrains.ReSharper.Psi.Resolve.IReference reference, System.Func<JetBrains.ReSharper.Psi.Tree.ITreeNode, System.Func<string, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IClrDeclaredElement>>> getTypesCacheFunc) { }
        public JetBrains.ReSharper.Psi.IReferencePointer CreateReferencePointer(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public bool ReferenceTargetCanBeType(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
    }
    public class VBMakeReadonlyFix : JetBrains.ReSharper.Intentions.QuickFixes.UsageChecking.MakeReadonlyFix
    {
        public VBMakeReadonlyFix(JetBrains.ReSharper.Daemon.VB.Errors.NonReadonlyFieldInGetHashCodeWarning warning) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.VB.VBLanguage))]
    public class VBQuickFixUtilComponent : JetBrains.ReSharper.Intentions.QuickFixes.IQuickFixUtilComponent
    {
        public JetBrains.ReSharper.Psi.Resolve.IReference BindTo(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.ITypeElement typeElement, out System.Action<> moveCaretToTypeArgumentsAction, bool targetHasGenericOverloads) { }
    }
    public class WrapWithGetTypeFix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public WrapWithGetTypeFix(JetBrains.ReSharper.Daemon.VB.Errors.NotValidError err) { }
        public override string Text { get; }
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
}
namespace JetBrains.ReSharper.Intentions.VB.QuickFixes.CreateFromUsage.Property
{
    
    public abstract class CreatePropertyFromUsageFixBase : JetBrains.ReSharper.Intentions.CreateFromUsage.CreateFromUsageActionBase2<JetBrains.ReSharper.Feature.Services.Intentions.CreateDeclaration.CreatePropertyDeclarationContext, JetBrains.ReSharper.Psi.Resolve.IReference>
    {
        protected readonly JetBrains.ReSharper.Psi.VB.Tree.IReferenceExpression myReferenceExpression;
        public CreatePropertyFromUsageFixBase(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        protected bool CanAddMemberTo(JetBrains.ReSharper.Psi.IDeclaredType declaredType) { }
        protected bool CheckResolveResult(JetBrains.ReSharper.Psi.Resolve.IReference reference1) { }
        protected override JetBrains.ReSharper.Feature.Services.Intentions.CreateDeclaration.CreatePropertyDeclarationContext CreateContext() { }
        protected override JetBrains.ReSharper.Feature.Services.Intentions.IntentionResult ExecuteIntention(JetBrains.ReSharper.Feature.Services.Intentions.CreateDeclaration.CreatePropertyDeclarationContext context) { }
        public override JetBrains.ReSharper.Intentions.CreateFromUsage.ICreatedElementConsistencyGroup GetConsistencyGroup() { }
        protected override JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.ICreationTarget GetTarget() { }
        protected override bool IsAvailableInternal() { }
    }
}
namespace JetBrains.ReSharper.Intentions.VB.QuickFixes.CreateFromUsage.Util
{
    
    public class OwnerUtil
    {
        public static JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.ICreationTarget GetOwnerForNestedTypeDeclaration([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.VB.Tree.IReferenceName referenceName) { }
        public static JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.ICreationTarget GetOwnerForNestedTypeDeclaration([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.VB.Tree.IReferenceExpression referenceExpression) { }
        public static JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.ICreationTarget GetOwnerForTypeDeclaration([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.VB.Tree.IReferenceName referenceName) { }
        public static JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.ICreationTarget GetOwnerForTypeDeclaration([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.VB.Tree.IReferenceExpression referenceExpression) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.ITypeTarget GetOwnerForTypeMemberDeclaration([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
    }
}
namespace JetBrains.ReSharper.Intentions.VB.QuickFixes.UsageChecking
{
    
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.VB.VBLanguage))]
    public class VbFixTypeHelper : JetBrains.ReSharper.Intentions.QuickFixes.UsageChecking.IFixTypeLanguageHelper
    {
        public void FixArrayLengthAccess(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public bool IsArrayLengthAccess(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.ILocalVariable> LocalsToCorrectType(JetBrains.ReSharper.Psi.IDeclaredElement element, JetBrains.ReSharper.Psi.IType newType, JetBrains.ReSharper.Psi.Tree.IExpression usage) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.VB.VBLanguage))]
    public class VBIntroduceFromParameterHelper : JetBrains.ReSharper.Intentions.QuickFixes.UsageChecking.IIntroduceFromParameterLanguageHelper
    {
        public bool CaseSensitive { get; }
        public string IntroduceFieldPattern { get; }
        public void AddAssignmentToBody(JetBrains.ReSharper.Psi.Tree.IParametersOwnerDeclaration constructorDeclaration, JetBrains.ReSharper.Psi.Tree.IStatement anchorStatement, bool insertBefore, JetBrains.ReSharper.Psi.IParameter parameter, string memberName) { }
        public JetBrains.ReSharper.Psi.Tree.ITypeMemberDeclaration AddConstructorDeclaration(JetBrains.ReSharper.Psi.Tree.ITypeDeclaration typeDeclaration) { }
        public void AddConstructorDeclarationStubToStruct(JetBrains.ReSharper.Psi.Tree.ITypeDeclaration structDeclaration) { }
        public JetBrains.ReSharper.Psi.Tree.IParameterDeclaration AddConstructorParameter(JetBrains.ReSharper.Psi.Tree.ITypeMemberDeclaration ctorDeclaration, string name, JetBrains.ReSharper.Psi.IType type) { }
        public void AddTypeMemberDeclaration(JetBrains.ReSharper.Psi.Tree.ITypeDeclaration targetTypeDeclaration, JetBrains.ReSharper.Psi.Tree.ITypeMemberDeclaration anchorMember, bool insertBefore, string pattern, string name, JetBrains.ReSharper.Psi.IType type) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Tree.IStatement> BodyStatements(JetBrains.ReSharper.Psi.Tree.IFunctionDeclaration functionDeclaration) { }
        public bool HasChainedConstructorInitializer(JetBrains.ReSharper.Psi.Tree.ITypeMemberDeclaration ctorDeclaration, ref int argumentsCount, ref JetBrains.ReSharper.Psi.IConstructor targetConstructor) { }
        public string IntroduceAutoPropertyPattern(JetBrains.ReSharper.Psi.Tree.ITreeNode context) { }
        public bool IsParameterToMemberAssignment(JetBrains.ReSharper.Psi.Tree.IStatement statement, ref JetBrains.ReSharper.Psi.ITypeMember member, ref JetBrains.ReSharper.Psi.IParameter parameter) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Tree.ITypeMemberDeclaration> NeighbourDeclarations(JetBrains.ReSharper.Psi.Tree.IParametersOwnerDeclaration constructorDeclaration) { }
        public void PassParameterToChainedConstructorInitializer(JetBrains.ReSharper.Psi.Tree.ITypeMemberDeclaration ctorDeclaration, string parameterName, int atIndex) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.VB.VBLanguage))]
    public class VBMakeReturnTypeVoidHelper : JetBrains.ReSharper.Intentions.QuickFixes.UsageChecking.IMakeReturnTypeVoidLanguageHelper
    {
        public string QuickFixText { get; }
        public bool IsReturnScope(JetBrains.ReSharper.Psi.Tree.ITreeNode node) { }
        public bool IsReturnStatement(JetBrains.ReSharper.Psi.Tree.IStatement statement, ref JetBrains.ReSharper.Psi.Tree.IExpression returnValue) { }
        public void RemoveReturnValue(JetBrains.ReSharper.Psi.Tree.IStatement statement, ref JetBrains.ReSharper.Psi.Tree.IStatement expressionStatementLeft) { }
    }
    public class VBRemoveLabelFix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public VBRemoveLabelFix(JetBrains.ReSharper.Daemon.UsageChecking.UnusedLabelWarning error) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.VB.VBLanguage))]
    public class VBRemoveUnusedVarHelper : JetBrains.ReSharper.Intentions.QuickFixes.UsageChecking.IRemoveUnusedVarHelper
    {
        public bool CanRemoveUsage(JetBrains.ReSharper.Psi.Tree.IExpression usage) { }
        public bool CanRemoveVariableDeclaration(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration) { }
        public void RemoveUsage(JetBrains.ReSharper.Psi.Tree.IExpression usage, ref JetBrains.ReSharper.Psi.Tree.ITreeNode rangeToHighlight) { }
        public void RemoveVariableDeclaration(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration, ref JetBrains.ReSharper.Psi.Tree.ITreeNode rangeToHighlight) { }
    }
    public class VBToConstFix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public VBToConstFix(JetBrains.ReSharper.Daemon.UsageChecking.ConvertToConstantWarningBase error) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
}
namespace JetBrains.ReSharper.Intentions.VB.Util
{
    
    [Microsoft.VisualBasic.CompilerServices.StandardModuleAttribute()]
    public sealed class AsyncUtil
    {
        public static JetBrains.ReSharper.Psi.IType CreateTaskOfReturnType(JetBrains.ReSharper.Psi.IParametersOwner method) { }
        public static void SetAsync(JetBrains.ReSharper.Psi.VB.Tree.IVBDeclaration declaration, bool value) { }
        public static void SetIterator(JetBrains.ReSharper.Psi.VB.Tree.IVBDeclaration declaration, bool value) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.VB.VBLanguage))]
    public class VBCommentCodeHelper : JetBrains.ReSharper.Intentions.Util.ICommentCodeLanguageHelper
    {
        public bool CanCommentDeclaration(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration) { }
        public System.Action CommentDeclaration(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration) { }
        public System.Action CommentTextRange(JetBrains.ReSharper.Psi.Tree.IFile file, JetBrains.ReSharper.Psi.TreeTextRange range, JetBrains.DocumentModel.IDocument document) { }
    }
    public class VBExtensionMethodsUtil : JetBrains.ReSharper.Intentions.Util.ExtensionMethodImportUtilBase<JetBrains.ReSharper.Psi.VB.IVBInvocationInfo>
    {
        public static readonly JetBrains.ReSharper.Psi.Resolve.ResolveErrorType[] QueryResolve;
        protected VBExtensionMethodsUtil(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.Resolve.ResolveErrorType[] acceptedResolveErrors) { }
        public static System.Collections.Generic.IList<JetBrains.ReSharper.Psi.IMethod> GetAlternatives(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.Resolve.ResolveErrorType[] acceptedResolveErrors) { }
        protected override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IMethod> GetCandidateMethods(JetBrains.ReSharper.Psi.VB.IVBInvocationInfo invocationInfo) { }
        protected override InvocationCandidate[] GetInvocationInfo(ref JetBrains.ReSharper.Psi.Resolve.ResolveErrorType acceptedResolveErrors) { }
        protected override string Present(JetBrains.ReSharper.Psi.IDeclaredElement method) { }
        protected override JetBrains.ReSharper.Psi.Resolve.ResolveErrorType ResolveOverloadsForExtensionMethods(JetBrains.ReSharper.Intentions.Util.ExtensionMethodImportUtilBase<JetBrains.ReSharper.Psi.VB.IVBInvocationInfo>.InvocationCandidate invocation, JetBrains.ReSharper.Psi.IMethod method) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.VB.VBLanguage))]
    public class VBSetBodyUtil : JetBrains.ReSharper.Intentions.Util.SetBodyUtil
    {
        protected override JetBrains.ReSharper.Psi.Tree.IFunctionDeclaration EnsureAccessor(JetBrains.ReSharper.Psi.Tree.ITypeMemberDeclaration destination, JetBrains.ReSharper.Psi.AccessorKind kind) { }
        public override void SetBody(JetBrains.ReSharper.Psi.Tree.IFunctionDeclaration destination, JetBrains.ReSharper.Psi.Tree.ITreeNode body) { }
    }
}