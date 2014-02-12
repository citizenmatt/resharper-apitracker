[assembly: System.Runtime.CompilerServices.InternalsVisibleToAttribute(@"JetBrains.ReSharper.IntentionsTests, PublicKey=002400000480000094000000060200000024000052534131000400000100010087f63ba6a789c30e210e7ec987234ad9fe33baf7367993bab1b312d6f72ca296b91ed5c658964ffb9e7570eb184a527c68c6bdba41cfe67d8cfd3f888234206bf39205a3652d3af3445bb6f715fdac532e289fea41229bac37762b67eb16f58fee717d2465fca9ee17f08ed16772a1fc52c1c17022e1f0d9bdd004524a663aca")]
[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]

namespace JetBrains.ReSharper.Intentions.CSharp.ContextActions
{
    
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Adds explicit name specification to anonymous type property declaration.", Group="C#", Name="Add explicit name of anonymous property")]
    public class AddAnonymousFieldNameAction : JetBrains.ReSharper.Intentions.Extensibility.IContextAction
    {
        public AddAnonymousFieldNameAction(JetBrains.ReSharper.Feature.Services.CSharp.Bulbs.ICSharpContextActionDataProvider dataProvider) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        public bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Add exception xml comment tag.", Group="C#", Name="Add exception xml comment tag", Priority=1)]
    public class AddExceptionDocCommentAction : JetBrains.ReSharper.Intentions.Extensibility.ContextActionBase
    {
        public AddExceptionDocCommentAction(JetBrains.ReSharper.Feature.Services.CSharp.Bulbs.ICSharpContextActionDataProvider provider) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Adds name to selected argument.", Group="C#", Name="Add name to argument ", Priority=-1)]
    public class AddNamedArgumentAction : JetBrains.ReSharper.Intentions.Extensibility.ContextActionBase
    {
        public AddNamedArgumentAction(JetBrains.ReSharper.Feature.Services.CSharp.Bulbs.ICSharpContextActionDataProvider provider) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public static JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpArgument GetArgumentNearestToCaret(JetBrains.ReSharper.Feature.Services.CSharp.Bulbs.ICSharpContextActionDataProvider dataProvider) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Adds second accessor to an event or a property.", Group="C#", Name="Add another accessor", Priority=-1)]
    public class AddSecondAccessorAction : JetBrains.ReSharper.Intentions.Extensibility.ContextActionBase
    {
        public AddSecondAccessorAction(JetBrains.ReSharper.Feature.Services.CSharp.Bulbs.ICSharpContextActionDataProvider provider) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class AddsToCollectionInitializerItem : JetBrains.ReSharper.Intentions.Extensibility.BulbActionBase
    {
        public override string Text { get; }
        public static JetBrains.ReSharper.Psi.CSharp.Tree.ICollectionElementInitializer AddElementInitializer(JetBrains.ReSharper.Psi.CSharp.Tree.IObjectCreationExpression expression, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpExpression> elementExpressions) { }
        public static JetBrains.ReSharper.Intentions.Extensibility.IBulbAction CreateBulbItem(JetBrains.ReSharper.Feature.Services.CSharp.Bulbs.ICSharpContextActionDataProvider provider) { }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public static void PostProcess(JetBrains.ReSharper.Psi.CSharp.Tree.IObjectCreationExpression creationExpression, JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
        public static JetBrains.ReSharper.Psi.CSharp.Tree.ICollectionElementInitializer ProcessSingleAddCall(JetBrains.ReSharper.Psi.CSharp.Tree.IBlock block, JetBrains.ReSharper.Psi.CSharp.Tree.IObjectCreationExpression creationExpression, JetBrains.ReSharper.Psi.CSharp.Tree.IInvocationExpression call) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Converts variable declaration of type that implements the System.IDisposable inte" +
        "rface into \'using\' statement. This is useful for enforcing lifetime for disposab" +
        "le objects.", Group="C#", Name="Put inside \'using\' construct")]
    public class AddUsingAction : JetBrains.ReSharper.Intentions.CSharp.ContextActions.Util.OneItemContextActionBase
    {
        public AddUsingAction(JetBrains.ReSharper.Feature.Services.CSharp.Bulbs.ICSharpContextActionDataProvider dataProvider) { }
        public override string Text { get; }
        protected override void ExecuteInternal() { }
        protected override bool IsAvailableInternal() { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Adds assert statement that performs null reference check for a variable at the ca" +
        "ret. Assert expression can be customized by changing \'asrtn\' Live Template ", Group="C#", Name="Assert reference is not null")]
    public class AssertNotNullAction : JetBrains.ReSharper.Intentions.Extensibility.ContextActionBase
    {
        public AssertNotNullAction(JetBrains.ReSharper.Feature.Services.CSharp.Bulbs.ICSharpContextActionDataProvider dataProvider) { }
        public override string Text { get; }
        public static System.Action<JetBrains.TextControl.ITextControl> AddAssert(JetBrains.ReSharper.Psi.CSharp.Tree.IReferenceExpression target, JetBrains.ProjectModel.ISolution solution) { }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public static string GetText([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.CSharp.Tree.IReferenceExpression forTarget) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
        public static bool IsAvailableFor([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.CSharp.Tree.IReferenceExpression referenceExpression, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.DocumentModel.IDocument document) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Replaces auto-property with property that utilizes backing field.", Group="C#", Name="Replace auto-property with backing field")]
    public class AutomaticToBackingFieldAction : JetBrains.ReSharper.Intentions.Extensibility.ContextActionBase
    {
        public AutomaticToBackingFieldAction(JetBrains.ReSharper.Feature.Services.CSharp.Bulbs.ICSharpContextActionDataProvider provider) { }
        public override string Text { get; }
        public static JetBrains.ReSharper.Psi.CSharp.Tree.IFieldDeclaration Execute(JetBrains.ReSharper.Psi.CSharp.Tree.IPropertyDeclaration propertyDeclaration) { }
        public static JetBrains.ReSharper.Psi.CSharp.Tree.IFieldDeclaration Execute(JetBrains.ReSharper.Psi.CSharp.Tree.IPropertyDeclaration propertyDeclaration, System.Action<JetBrains.ReSharper.Psi.CSharp.Tree.IPropertyDeclaration, JetBrains.ReSharper.Psi.IField> acessorsCreator) { }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public static string GetText() { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
        public static bool IsAvailable(JetBrains.ReSharper.Psi.CSharp.Tree.IPropertyDeclaration declaration) { }
        public static void PostExecute(JetBrains.ReSharper.Psi.CSharp.Tree.IPropertyDeclaration propertyDeclaration, JetBrains.ReSharper.Psi.CSharp.Tree.IFieldDeclaration fieldDeclaration, JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Replaces property that utilizes backing field with auto-property.", Group="C#", Name="Replace backing field with auto-property")]
    public class BackingFieldToAutomaticAction : JetBrains.ReSharper.Intentions.Extensibility.BulbActionBase, JetBrains.ReSharper.Intentions.Extensibility.IContextAction
    {
        public BackingFieldToAutomaticAction(JetBrains.ReSharper.Feature.Services.CSharp.Bulbs.ICSharpContextActionDataProvider dataProvider) { }
        public override string Text { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public static JetBrains.ReSharper.Psi.IField GetField(JetBrains.ReSharper.Psi.CSharp.Tree.IPropertyDeclaration propertyDeclaration) { }
        public bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Available on an access modifier keyword and allows changing access rights of a de" +
        "claration.", Group="C#", Name="Change member visibility", Priority=-1)]
    public class ChangeModifierAction : JetBrains.ReSharper.Intentions.Extensibility.IContextAction
    {
        public ChangeModifierAction(JetBrains.ReSharper.Feature.Services.CSharp.Bulbs.ICSharpContextActionDataProvider dataProvider) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        public bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Makes type member abstract, virtual or non-abstract and non-virtual.", Group="C#", Name="To abstract/To virtual/To non-abstract/To non-virtual", Priority=-2)]
    public class ChangeOverridableKindAction : JetBrains.ReSharper.Intentions.Extensibility.IContextAction
    {
        public ChangeOverridableKindAction(JetBrains.ReSharper.Feature.Services.CSharp.Bulbs.ICSharpContextActionDataProvider dataProvider) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        public bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
        [JetBrains.ReSharper.Psi.PsiSharedComponentAttribute()]
        public class PatternsAndMatchers
        {
            public PatternsAndMatchers(JetBrains.ReSharper.Psi.Services.StructuralSearch.StructuralSearchEngine ssrEngine, JetBrains.ReSharper.Psi.ILanguageManager languageManager) { }
            public JetBrains.ReSharper.Psi.Services.StructuralSearch.ISequenceStructuralMatcher ThrowNewNotImplementedExMatcher { get; }
        }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Puts the current statement under an \'if\' statement that performs null reference c" +
        "heck for a variable at the caret.", Group="C#", Name="Check if reference is not null", Priority=2)]
    public class CheckReferenceNullAction : JetBrains.ReSharper.Intentions.Extensibility.ContextActionBase
    {
        public CheckReferenceNullAction(JetBrains.ReSharper.Feature.Services.CSharp.Bulbs.ICSharpContextActionDataProvider dataProvider) { }
        public override string Text { get; }
        public static System.Action<JetBrains.TextControl.ITextControl> Execute(JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpExpression expressionToCheck, JetBrains.ProjectModel.ISolution solution, JetBrains.DocumentModel.DocumentRange documentCaret) { }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public static string GetText(JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpExpression expression) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
        public static bool IsAvailableForExpression(System.Func<JetBrains.ReSharper.Psi.ControlFlow.CSharp.ICSharpControlFlowAnalysisResult> controlFlowAnalysisResult, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpExpression expression) { }
        public static bool IsDocumentRangesValid(JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpExpression expression) { }
        public class ModificationResult
        {
            public readonly JetBrains.ReSharper.Psi.Tree.ITreeNode CaretElement;
            public readonly JetBrains.ReSharper.Feature.Services.Refactorings.ReplaceInfo IntroducedVariable;
            public ModificationResult(JetBrains.ReSharper.Feature.Services.Refactorings.ReplaceInfo replaceInfo, JetBrains.ReSharper.Psi.Tree.ITreeNode caretElement) { }
            public ModificationResult(JetBrains.ReSharper.Psi.Tree.ITreeNode caretElement) { }
        }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Converts null coalescing operator to ternary conditional operator.", Group="C#", Name="Convert coalescing operator to ternary")]
    public class CoalescingToTernaryAction : JetBrains.ReSharper.Intentions.CSharp.ContextActions.Util.OneItemContextActionBase
    {
        public CoalescingToTernaryAction(JetBrains.ReSharper.Feature.Services.CSharp.Bulbs.ICSharpContextActionDataProvider dataProvider) { }
        public override string Text { get; }
        protected override void ExecuteInternal() { }
        protected override bool IsAvailableInternal() { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Creates class that implements interface or inherits class.", Group="C#", Name="Create derived type")]
    public class CreateDerivedTypeAction : JetBrains.ReSharper.Intentions.Extensibility.ContextActionBase
    {
        public CreateDerivedTypeAction(JetBrains.ReSharper.Feature.Services.CSharp.Bulbs.ICSharpContextActionDataProvider dataProvider) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Creates overload without given parameter. Calls current method.", Group="C#", Name="Create overload without parameter")]
    public class CreateOverloadAction : JetBrains.ReSharper.Intentions.CSharp.ContextActions.Util.OneItemContextActionBase
    {
        public CreateOverloadAction(JetBrains.ReSharper.Feature.Services.CSharp.Bulbs.ICSharpContextActionDataProvider dataProvider) { }
        public override string Text { get; }
        protected override void ExecuteInternal() { }
        protected override object[] ExecuteInternalEx(params object[] param) { }
        protected override object[] ExecuteInternalPostPSITransaction(params object[] data) { }
        protected override bool IsAvailableInternal() { }
    }
    public class static CSharpContextActions
    {
        public const string GroupID = "C#";
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Optionally creates and initializes auto-property from constructor parameter.", Group="C#", Name="Initialize auto-property from constructor parameter", Priority=1)]
    public class CSharpInitializeAutoPropertyAction : JetBrains.ReSharper.Intentions.ContextActions.InitializeAutoPropertyActionBase
    {
        public CSharpInitializeAutoPropertyAction(JetBrains.ReSharper.Feature.Services.CSharp.Bulbs.ICSharpContextActionDataProvider dataProvider) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Optionally creates and initializes field from constructor parameter", Group="C#", Name="Initialize field from constructor parameter", Priority=2)]
    public class CSharpInitializeFieldAction : JetBrains.ReSharper.Intentions.ContextActions.InitializeFieldActionBase
    {
        public CSharpInitializeFieldAction(JetBrains.ReSharper.Feature.Services.CSharp.Bulbs.ICSharpContextActionDataProvider dataProvider) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Converts usage of equality operator (\'==\') to a call to object.Equals method.", Group="C#", Name="Convert \'==\' to \'Equals\'")]
    public class EqualityOperatorToEqualsAction : JetBrains.ReSharper.Intentions.CSharp.ContextActions.Util.OneItemContextActionBase
    {
        public EqualityOperatorToEqualsAction(JetBrains.ReSharper.Feature.Services.CSharp.Bulbs.ICSharpContextActionDataProvider dataProvider) { }
        public override string Text { get; }
        protected override void ExecuteInternal() { }
        protected override bool IsAvailableInternal() { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Converts a call to instance Equals method into usage of equality (\'==\') or inequa" +
        "lity (\'!=\') operator.", Group="C#", Name="Convert instance \'Equals\' to static \'Equals\'")]
    public class EqualsThisToEqualsOperatorAction : JetBrains.ReSharper.Intentions.CSharp.ContextActions.Util.OneItemContextActionBase
    {
        public EqualsThisToEqualsOperatorAction(JetBrains.ReSharper.Feature.Services.CSharp.Bulbs.ICSharpContextActionDataProvider dataProvider) { }
        public override string Text { get; }
        protected override void ExecuteInternal() { }
        protected override bool IsAvailableInternal() { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Converts a call to the static object.Equals method into usage of equality (\'==\') " +
        "or inequality (\'!=\') operator.", Group="C#", Name="Convert \'Equals\' to \'==\' operator")]
    public class EqualsToEqualityOperatorAction : JetBrains.ReSharper.Intentions.CSharp.ContextActions.Util.OneItemContextActionBase
    {
        public EqualsToEqualityOperatorAction(JetBrains.ReSharper.Feature.Services.CSharp.Bulbs.ICSharpContextActionDataProvider dataProvider) { }
        public override string Text { get; }
        protected override void ExecuteInternal() { }
        protected override bool IsAvailableInternal() { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Converts explicit implementation of an interface method to implicit one.", Group="C#", Name="Convert explicit to implicit implementation")]
    public class ExplicitToImplicitMemberAction : JetBrains.ReSharper.Intentions.CSharp.ContextActions.Util.OneItemContextActionBase
    {
        public ExplicitToImplicitMemberAction(JetBrains.ReSharper.Feature.Services.CSharp.Bulbs.ICSharpContextActionDataProvider dataProvider) { }
        public override string Text { get; }
        public static void ExecuteEx(JetBrains.ReSharper.Psi.CSharp.Tree.IInterfaceQualificationOwner owner) { }
        protected override void ExecuteInternal() { }
        public static bool IsAvailable(JetBrains.ReSharper.Psi.CSharp.Tree.IInterfaceQualificationOwner owner) { }
        protected override bool IsAvailableInternal() { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Works on \'foreach\' statements executed on a collection that allows direct access " +
        "to its elements by index. It converts such \'foreach\' statement to \'for\' statemen" +
        "t.", Group="C#", Name="Convert \'foreach\' to \'for\' loop")]
    public class ForeachToForAction : JetBrains.ReSharper.Intentions.Extensibility.ContextActionBase
    {
        public ForeachToForAction(JetBrains.ReSharper.Feature.Services.CSharp.Bulbs.ICSharpContextActionDataProvider dataProvider) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Merges two nested \'if\' statements to a single \'if\' statement that checks conjunct" +
        "ion of the original conditions.", Group="C#", Name="Merge nested \'if\' statements")]
    public class IfAndMergeAction : JetBrains.ReSharper.Intentions.Extensibility.ContextActionBase
    {
        public IfAndMergeAction(JetBrains.ReSharper.Feature.Services.CSharp.Bulbs.ICSharpContextActionDataProvider provider) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Works on \'if\' statements that compare value of an expression with one or more con" +
        "stants. It converts such \'if\' statements into a single \'switch\' statement.", Group="C#", Name="Convert \'if\' statement to \'switch\' statement", Priority=-1)]
    public class IfToSwitchAction : JetBrains.ReSharper.Intentions.CSharp.ContextActions.Util.OneItemContextActionBase
    {
        public IfToSwitchAction(JetBrains.ReSharper.Feature.Services.CSharp.Bulbs.ICSharpContextActionDataProvider dataProvider) { }
        public override string Text { get; }
        public static void Execute(JetBrains.ReSharper.Psi.CSharp.Tree.IIfStatement ifStatement) { }
        protected override void ExecuteInternal() { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
        protected override bool IsAvailableInternal() { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Works on \'if\' statement that returns value or performs assignment inside each bra" +
        "nch. It converts the statement to a ternary expression (\'x ? a : b\')", Group="C#", Name="Convert \'if\' statement to ternary expression")]
    public class IfToTernaryAction : JetBrains.ReSharper.Intentions.Extensibility.ContextActionBase
    {
        public static readonly JetBrains.Util.Key<string> Key;
        public IfToTernaryAction(JetBrains.ReSharper.Feature.Services.CSharp.Bulbs.ICSharpContextActionDataProvider provider) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Adds placeholders for custom implementation of \'add\' and \'remove\' methods for an " +
        "event.", Group="C#", Name="Implement custom event accessors")]
    public class ImplementEventAction : JetBrains.ReSharper.Intentions.Extensibility.ContextActionBase
    {
        public ImplementEventAction(JetBrains.ReSharper.Feature.Services.CSharp.Bulbs.ICSharpContextActionDataProvider provider) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Creates method to invoke PropertyChanged event with string literal parameter and " +
        "adds ReSharper annotation to enable identifying this method by INotifyPropertyCh" +
        "anged support", Group="C#", Name="Implement INotifyPropertyChanged pattern", Priority=10)]
    public class ImplementNotifyPropertyChangedAction : JetBrains.ReSharper.Intentions.Extensibility.BulbActionBase, JetBrains.ReSharper.Intentions.Extensibility.IContextAction
    {
        public ImplementNotifyPropertyChangedAction(JetBrains.ReSharper.Feature.Services.CSharp.Bulbs.ICSharpContextActionDataProvider provider) { }
        public override string Text { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Converts implicit implementation of an interface member to explicit one.", Group="C#", Name="Convert implicit to explicit interface implementation", Priority=-1)]
    public class ImplicitToExplicitMemberAction : JetBrains.ReSharper.Intentions.Extensibility.ContextActionBase
    {
        public ImplicitToExplicitMemberAction(JetBrains.ReSharper.Feature.Services.CSharp.Bulbs.ICSharpContextActionDataProvider provider) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Replaces usages of the type in the method with anonymous type usages.", Disabled=true, Group="C#", Name="Inline as anonymous type action")]
    public class InlineAsAnonymousTypeAction : JetBrains.ReSharper.Intentions.CSharp.ContextActions.Util.OneItemContextActionBase
    {
        public InlineAsAnonymousTypeAction(JetBrains.ReSharper.Feature.Services.CSharp.Bulbs.ICSharpContextActionDataProvider dataProvider) { }
        public override string Text { get; }
        protected override void ExecuteInternal() { }
        protected override bool IsAvailableInternal() { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Adds proper signature to parameterless declaration of an anonymous method.", Group="C#", Name="Insert anonymous method signature")]
    public class InsertAnonymousMethodSignatureAction : JetBrains.ReSharper.Intentions.Extensibility.ContextActionBase
    {
        public InsertAnonymousMethodSignatureAction(JetBrains.ReSharper.Feature.Services.CSharp.Bulbs.ICSharpContextActionDataProvider dataProvider) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Introduces variable from expression statement", Group="C#", Name="Introduce variable from expression statement", Priority=5)]
    public class IntroduceVariableAction : JetBrains.ReSharper.Intentions.Extensibility.BulbActionBase, JetBrains.ReSharper.Intentions.Extensibility.IContextAction
    {
        public IntroduceVariableAction(JetBrains.ReSharper.Feature.Services.CSharp.Bulbs.ICSharpContextActionDataProvider dataProvider) { }
        public override string Text { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Inverts guard condition of an \'if\' statement and swaps the branches\' code accordi" +
        "ngly.", Group="C#", Name="Invert \'if\' statement")]
    public class InvertIfAction : JetBrains.ReSharper.Intentions.Extensibility.ContextActionBase
    {
        public InvertIfAction(JetBrains.ReSharper.Feature.Services.CSharp.Bulbs.ICSharpContextActionDataProvider dataProvider) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class InvertIfComponent : JetBrains.ReSharper.Daemon.CSharp.Stages.Analysis.IfStatementPatternAnalyzer.IInvertIfComponent
    {
        public bool CanInvertIf([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.CSharp.Tree.IIfStatement ifStatement, JetBrains.ReSharper.Psi.ControlFlow.CSharp.ICSharpControlFlowGraf graf) { }
        public bool CanReduceNesting(JetBrains.ReSharper.Psi.CSharp.Tree.IIfStatement ifStatement, JetBrains.ReSharper.Psi.ControlFlow.CSharp.ICSharpControlFlowGraf graf) { }
    }
    public class static InvertIfUtil
    {
        public static bool CanInvertIf([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.CSharp.Tree.IIfStatement statement, JetBrains.ReSharper.Psi.ControlFlow.IControlFlowGraf graf) { }
        public static bool CanReduceNesting(JetBrains.ReSharper.Psi.CSharp.Tree.IIfStatement ifStatement, JetBrains.ReSharper.Psi.ControlFlow.CSharp.ICSharpControlFlowGraf graf) { }
        public static void DoInvertIf([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.CSharp.Tree.IIfStatement ifStatement, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.ControlFlow.CSharp.ICSharpControlFlowGraf graf) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Invert logical expression", Group="C#", Name="Invert logical expression")]
    public class InvertLogicalExpressionAction : JetBrains.ReSharper.Intentions.Extensibility.ContextActionBase
    {
        public InvertLogicalExpressionAction(JetBrains.ReSharper.Feature.Services.CSharp.Bulbs.ICSharpContextActionDataProvider provider) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public static JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpExpression GetParentThroughParenthesis(JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpExpression toTestExpr) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpExpression GetTopBooleanExpression([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpExpression booleanExpr) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
        public static bool IsBooleanExpression([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpExpression expression) { }
        public static bool IsBooleanExpression([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpExpression toTestExpr, JetBrains.ReSharper.Intentions.CSharp.ContextActions.InvertLogicalExpressionAction.ParenthesisCheck dir) { }
        public enum ParenthesisCheck
        {
            Up = 0,
            Down = 1,
        }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Changes invocation syntax from extension method to static method.", Group="C#", Name="Invoke as static method")]
    public class InvokeAsStaticMethodAction : JetBrains.ReSharper.Intentions.Extensibility.ContextActionBase
    {
        public InvokeAsStaticMethodAction(JetBrains.ReSharper.Feature.Services.CSharp.Bulbs.ICSharpContextActionDataProvider provider) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Creates event invocator.", Group="C#", Name="Create event invocator", Priority=1)]
    public class InvokeEventAction : JetBrains.ReSharper.Intentions.Extensibility.IContextAction
    {
        public InvokeEventAction(JetBrains.ReSharper.Feature.Services.CSharp.Bulbs.ICSharpContextActionDataProvider dataProvider) { }
        public JetBrains.ReSharper.Intentions.Extensibility.IBulbAction[] Items { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        public bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Works on an expression of System.ICollection type or other expression whose value" +
        " can be iterated with \'foreach\' statement. Generates a \'foreach\' statement itera" +
        "ting the expression.", Group="C#", Name="Iterate via \'foreach\'", Priority=1)]
    public class IterateViaForeachAction : JetBrains.ReSharper.Intentions.Extensibility.ContextActionBase
    {
        public IterateViaForeachAction(JetBrains.ReSharper.Feature.Services.CSharp.Bulbs.ICSharpContextActionDataProvider dataProvider) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Works on an assignment to a variable that was declared without initializer. Moves" +
        " the declaration to the current point and merges it with the assignment.", Group="C#", Name="Join local variable declaration and assignment")]
    public class JoinDeclarationAction : JetBrains.ReSharper.Intentions.Extensibility.ContextActionBase
    {
        public JoinDeclarationAction(JetBrains.ReSharper.Feature.Services.CSharp.Bulbs.ICSharpContextActionDataProvider dataProvider) { }
        public override string Text { get; }
        public static JetBrains.ReSharper.Psi.CSharp.Tree.IDeclarationStatement Execute(JetBrains.ReSharper.Psi.CSharp.Tree.IAssignmentExpression assignmentExpression, JetBrains.ReSharper.Psi.CSharp.Tree.ILocalVariableDeclaration variableDeclaration) { }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
        public static bool IsAvailable(JetBrains.ReSharper.Psi.CSharp.Tree.IAssignmentExpression assignmentExpression, JetBrains.ReSharper.Psi.CSharp.Tree.ILocalVariableDeclaration localVariableDeclaration, System.Predicate<JetBrains.ReSharper.Psi.TreeTextRange> rangeChecker) { }
    }
    public class static MethodGroupUtil
    {
        public static JetBrains.ReSharper.Psi.CSharp.Tree.IReferenceExpression FindReferenceExpression(JetBrains.ReSharper.Feature.Services.CSharp.Bulbs.ICSharpContextActionDataProvider provider) { }
        public static JetBrains.ReSharper.Psi.IDeclaredType GetExpressionType(JetBrains.ReSharper.Psi.CSharp.Tree.IReferenceExpression referenceExpression) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Works on fields initialized in the declaration. It moves the initialization to co" +
        "nstructors.", Group="C#", Name="Move initialization to constructor(s)")]
    public class MoveInitializationAction : JetBrains.ReSharper.Intentions.Extensibility.ContextActionBase
    {
        public MoveInitializationAction(JetBrains.ReSharper.Feature.Services.CSharp.Bulbs.ICSharpContextActionDataProvider dataProvider) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Moves variable to outer scope.", Group="C#", Name="Move to outer scope")]
    public class MoveToOuterScopeAction : JetBrains.ReSharper.Intentions.CSharp.ContextActions.Util.OneItemContextActionBase
    {
        public MoveToOuterScopeAction(JetBrains.ReSharper.Feature.Services.CSharp.Bulbs.ICSharpContextActionDataProvider dataProvider) { }
        public override string Text { get; }
        protected override void ExecuteInternal() { }
        protected override bool IsAvailableInternal() { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Moves current type to another file so that its name matches the name of the type." +
        "", Group="C#", Name="Move type to another file to match its name", Priority=1)]
    public class MoveTypeToAnotherFileAction : JetBrains.ReSharper.Intentions.Extensibility.IBulbAction, JetBrains.ReSharper.Intentions.Extensibility.IContextAction
    {
        public MoveTypeToAnotherFileAction(JetBrains.ReSharper.Feature.Services.CSharp.Bulbs.ICSharpContextActionDataProvider dataProvider) { }
        public JetBrains.ReSharper.Intentions.Extensibility.IBulbAction[] Items { get; }
        public string Text { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        public void Execute(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        public bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Negates logical expression", Group="C#", Name="Negate logical expression")]
    public class NegateLogicalExpressionAction : JetBrains.ReSharper.Intentions.Extensibility.ContextActionBase
    {
        public NegateLogicalExpressionAction(JetBrains.ReSharper.Feature.Services.CSharp.Bulbs.ICSharpContextActionDataProvider provider) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public static JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpExpression GetParentThroughParenthesis(JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpExpression toTestExpr) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpExpression GetTopBooleanExpression([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpExpression booleanExpr) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
        public static bool IsBooleanExpression([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpExpression expression) { }
        public static bool IsBooleanExpression([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpExpression toTestExpr, JetBrains.ReSharper.Intentions.CSharp.ContextActions.NegateLogicalExpressionAction.ParenthesisCheck dir) { }
        public enum ParenthesisCheck
        {
            Up = 0,
            Down = 1,
        }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Adds call to the notification method", Group="C#", Name="Notify property changes")]
    public class NotifyPropertyChangeAction : JetBrains.ReSharper.Intentions.Extensibility.IContextAction
    {
        public NotifyPropertyChangeAction(JetBrains.ReSharper.Feature.Services.CSharp.Bulbs.ICSharpContextActionDataProvider provider) { }
        public JetBrains.ReSharper.Intentions.Extensibility.IBulbAction[] Items { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        public bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Removes unnecessary braces around one or more statements in the code", Group="C#", Name="Remove braces")]
    public class RemoveBracesAction : JetBrains.ReSharper.Intentions.Extensibility.ContextActionBase
    {
        public RemoveBracesAction(JetBrains.ReSharper.Feature.Services.CSharp.Bulbs.ICSharpContextActionDataProvider dataProvider) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder userDataHolder) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Removes parenthesis in case they are redundant ", Group="C#", Name="Remove redundant parenthesis")]
    public class RemoveParenthesisAction : JetBrains.ReSharper.Intentions.Extensibility.ContextActionBase
    {
        public RemoveParenthesisAction(JetBrains.ReSharper.Feature.Services.CSharp.Bulbs.ICSharpContextActionDataProvider provider) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Removes region and corresponding endregion pair of directives", Group="C#", Name="Remove #region, #endregion directives")]
    public class RemoveRegionAction : JetBrains.ReSharper.Intentions.CSharp.ContextActions.Util.OneItemContextActionBase
    {
        public RemoveRegionAction(JetBrains.ReSharper.Feature.Services.CSharp.Bulbs.ICSharpContextActionDataProvider dataProvider) { }
        public override string Text { get; }
        protected override void ExecuteInternal() { }
        protected override bool IsAvailableInternal() { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Renames current file to match the name of the only top-level type declared therei" +
        "n.", Group="C#", Name="Match file name with type name", Priority=1)]
    public class RenameFileToMatchTypeNameAction : JetBrains.ReSharper.Intentions.Extensibility.ContextActionBase
    {
        public RenameFileToMatchTypeNameAction(JetBrains.ReSharper.Feature.Services.CSharp.Bulbs.ICSharpContextActionDataProvider dataProvider) { }
        public override string Text { get; }
        public static int CountTopLevelTypeDeclarations(JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpTypeAndNamespaceHolderDeclaration declaration) { }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
        public static bool TypeNameNameDoesNotCorrespondWithFileName(JetBrains.ReSharper.Psi.IDeclaredElement element, JetBrains.ProjectModel.IProjectFile projectFile) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Creates return statement with value that is taken as an expression statement", Group="C#", Name="Create return from expression statement")]
    public class ReturnValueAction : JetBrains.ReSharper.Intentions.CSharp.ContextActions.Util.OneItemContextActionBase
    {
        public ReturnValueAction(JetBrains.ReSharper.Feature.Services.CSharp.Bulbs.ICSharpContextActionDataProvider dataProvider) { }
        public override string Text { get; }
        protected override void ExecuteInternal() { }
        protected override object[] ExecuteInternalEx(params object[] param) { }
        protected override object[] ExecuteInternalPostPSITransaction(params object[] data) { }
        protected override bool IsAvailableInternal() { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Reverses source and destination parts of an assignment statement.", Group="C#", Name="Reverse assignment statement")]
    public class ReverseAssignmentAction : JetBrains.ReSharper.Intentions.CSharp.ContextActions.Util.OneItemContextActionBase
    {
        public ReverseAssignmentAction(JetBrains.ReSharper.Feature.Services.CSharp.Bulbs.ICSharpContextActionDataProvider dataProvider) { }
        public override string Text { get; }
        protected override void ExecuteInternal() { }
        protected override bool IsAvailableInternal() { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Works on an \'if\' statement, which condition is a conjunction (\'&&\') of two simple" +
        "r conditions. It converts the \'if\' statement into two nested \'if\' statements.", Group="C#", Name="Split \'if\' with \'&&\'-condition into nested \'if\'-statements")]
    public class SplitAndInIfAction : JetBrains.ReSharper.Intentions.Extensibility.ContextActionBase
    {
        public SplitAndInIfAction(JetBrains.ReSharper.Feature.Services.CSharp.Bulbs.ICSharpContextActionDataProvider provider) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
        public static bool IsCursorAtAndSign<TExpression>(JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpExpression expression, JetBrains.ReSharper.Psi.TreeOffset textOffset)
            where TExpression :  class, JetBrains.ReSharper.Psi.CSharp.Tree.IBinaryExpression { }
        public static bool IsToTheRightOfCursor(JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpExpression expression, JetBrains.ReSharper.Psi.TreeOffset treeOffset) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Works on a \'return\' statement, which condition is a conjunction (\'&&\') of two sim" +
        "pler conditions. It converts the \'return\' statement into a guarding \'if\' stateme" +
        "nt and a \'return\'.", Group="C#", Name="Split \'return\' with \'&&\'-condition into guarding \'if\' and \'return\'")]
    public class SplitAndInReturnAction : JetBrains.ReSharper.Intentions.Extensibility.ContextActionBase
    {
        public SplitAndInReturnAction(JetBrains.ReSharper.Feature.Services.CSharp.Bulbs.ICSharpContextActionDataProvider provider) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Moves variable initializer from declaration statement to separate assignment stat" +
        "ement.", Group="C#", Name="Split local variable declaration and assignment")]
    public class SplitDeclarationAction : JetBrains.ReSharper.Intentions.CSharp.ContextActions.Util.OneItemContextActionBase
    {
        public SplitDeclarationAction(JetBrains.ReSharper.Feature.Services.CSharp.Bulbs.ICSharpContextActionDataProvider dataProvider) { }
        public override string Text { get; }
        protected override void ExecuteInternal() { }
        protected override bool IsAvailableInternal() { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Works on variable declaration statement that declares multiple variables. It spli" +
        "ts such statement into multiple statements each declaring a single variable.", Group="C#", Name="Split declaration list")]
    public class SplitDeclarationsListAction : JetBrains.ReSharper.Intentions.CSharp.ContextActions.Util.OneItemContextActionBase
    {
        public SplitDeclarationsListAction(JetBrains.ReSharper.Feature.Services.CSharp.Bulbs.ICSharpContextActionDataProvider dataProvider) { }
        public override string Text { get; }
        public static void Execute(JetBrains.ReSharper.Psi.CSharp.Tree.IMultipleDeclaration element) { }
        protected override void ExecuteInternal() { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
        public static bool IsAvailable(JetBrains.ReSharper.Psi.CSharp.Tree.IMultipleDeclaration element) { }
        protected override bool IsAvailableInternal() { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Works on an \'if\' statement, which condition is a disjunction (\'||\') of two simple" +
        "r conditions. It converts the \'if\' statement into an assignment to a temporary v" +
        "ariable and an two \'if\' statements.", Group="C#", Name="Split \'if\' with \'||\'-condition into assignment to temporary variable and two \'if\'" +
        "-statements")]
    public class SplitOrInIfAction : JetBrains.ReSharper.Intentions.Extensibility.ContextActionBase
    {
        public SplitOrInIfAction(JetBrains.ReSharper.Feature.Services.CSharp.Bulbs.ICSharpContextActionDataProvider provider) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Works on an \'return\' statement, which condition is a disjunction (\'||\') of two si" +
        "mpler conditions. It converts the \'return\' statement into an assignment to a tem" +
        "porary variable, \'if\' statement and \'return\' statement.", Group="C#", Name="Split \'return\' with \'||\'-condition into assignment to temporary variable, \'if\'-st" +
        "atement and \'return\'")]
    public class SplitOrInReturnAction : JetBrains.ReSharper.Intentions.Extensibility.ContextActionBase
    {
        public SplitOrInReturnAction(JetBrains.ReSharper.Feature.Services.CSharp.Bulbs.ICSharpContextActionDataProvider provider) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Replaces original variable with several ones declared in inner blocks of the curr" +
        "ent block.", Group="C#", Name="Splits variable into several ones")]
    public class SplitVariableAction : JetBrains.ReSharper.Intentions.CSharp.ContextActions.Util.OneItemContextActionBase
    {
        public SplitVariableAction(JetBrains.ReSharper.Feature.Services.CSharp.Bulbs.ICSharpContextActionDataProvider dataProvider) { }
        public override string Text { get; }
        protected override void ExecuteInternal() { }
        protected override object[] ExecuteInternalEx(params object[] param) { }
        protected override object[] ExecuteInternalPostPSITransaction(params object[] data) { }
        protected override bool IsAvailableInternal() { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Converts \'switch\' statements into one or multiple nested \'if\' statements each che" +
        "cking for individual value.", Group="C#", Name="Convert \'switch\' statement to \'if\' statement")]
    public class SwitchToIfElseAction : JetBrains.ReSharper.Intentions.Extensibility.ContextActionBase
    {
        public SwitchToIfElseAction(JetBrains.ReSharper.Feature.Services.CSharp.Bulbs.ICSharpContextActionDataProvider provider) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Inverts condition and swaps branches of a ternary expression.", Group="C#", Name="Invert ternary condition")]
    public class TernarySwarpAction : JetBrains.ReSharper.Intentions.CSharp.ContextActions.Util.OneItemContextActionBase
    {
        public TernarySwarpAction(JetBrains.ReSharper.Feature.Services.CSharp.Bulbs.ICSharpContextActionDataProvider dataProvider) { }
        public override string Text { get; }
        protected override void ExecuteInternal() { }
        protected override bool IsAvailableInternal() { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Converts ternary conditional operator comparing value with null to coalescing ope" +
        "rator.", Group="C#", Name="Convert ternary to coalescing operator")]
    public class TernaryToCoalescingAction : JetBrains.ReSharper.Intentions.CSharp.ContextActions.Util.OneItemContextActionBase
    {
        public TernaryToCoalescingAction(JetBrains.ReSharper.Feature.Services.CSharp.Bulbs.ICSharpContextActionDataProvider dataProvider) { }
        public override string Text { get; }
        public static void Execute(JetBrains.ReSharper.Psi.CSharp.Tree.IConditionalTernaryExpression expression, JetBrains.ReSharper.Psi.CSharp.CSharpElementFactory factory) { }
        protected override void ExecuteInternal() { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
        public static bool IsAvailable(JetBrains.ReSharper.Psi.CSharp.Tree.IConditionalTernaryExpression expression) { }
        protected override bool IsAvailableInternal() { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Converts ternary expression whose value is returned or assigned to an \'if\' statem" +
        "ent.", Group="C#", Name="Convert ternary expression to \'if\' statement")]
    public class TernaryToIfAction : JetBrains.ReSharper.Intentions.Extensibility.ContextActionBase
    {
        public TernaryToIfAction(JetBrains.ReSharper.Feature.Services.CSharp.Bulbs.ICSharpContextActionDataProvider provider) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public abstract class ToNamedMethodActionBase
    {
        protected ToNamedMethodActionBase(JetBrains.ReSharper.Feature.Services.CSharp.Bulbs.ICSharpContextActionDataProvider dataProvider) { }
        public JetBrains.ReSharper.Feature.Services.CSharp.Bulbs.ICSharpContextActionDataProvider DataProvider { get; }
        public JetBrains.ReSharper.Intentions.Extensibility.IBulbAction[] Items { get; }
        protected abstract JetBrains.ReSharper.Psi.CSharp.Tree.IAnonymousFunctionExpression GetFunctionExpression();
        public bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Makes abstract member virtual.", Group="C#", Name="Make abstract member virtual", Priority=1)]
    public class ToVirtualAction : JetBrains.ReSharper.Intentions.Extensibility.ContextActionBase
    {
        public ToVirtualAction(JetBrains.ReSharper.Feature.Services.CSharp.Bulbs.ICSharpContextActionDataProvider provider) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Replace type with \'var\'.", Group="C#", Name="Replaces explicit type specification with \'var\'", Priority=1)]
    public class TypeToVarAction : JetBrains.ReSharper.Intentions.Extensibility.ContextActionBase
    {
        public TypeToVarAction(JetBrains.ReSharper.Feature.Services.CSharp.Bulbs.ICSharpContextActionDataProvider dataProvider) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
        protected bool IsAvailableInternal() { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Adds explicit type specification to array creation expression.", Group="C#", Name="Specify array type explicitly")]
    public class UseExplicitArrayAction : JetBrains.ReSharper.Intentions.Extensibility.ContextActionBase
    {
        public UseExplicitArrayAction(JetBrains.ReSharper.Feature.Services.CSharp.Bulbs.ICSharpContextActionDataProvider provider) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
        protected bool IsAvailableImpl() { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Replace \'var\' with explicit type declaration.", Group="C#", Name="Replaces \'var\' with explicit type declaration", Priority=1)]
    public class VarToTypeAction : JetBrains.ReSharper.Intentions.Extensibility.ContextActionBase
    {
        public VarToTypeAction(JetBrains.ReSharper.Feature.Services.CSharp.Bulbs.ICSharpContextActionDataProvider dataProvider) { }
        public override string Text { get; }
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
}
namespace JetBrains.ReSharper.Intentions.CSharp.ContextActions.Annotations
{
    
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Annotates a method with \'value can be null\' attribute. The attribute can be confi" +
        "gured via external annotations.", Group="C#", Name="Annotate method with \'value can be null\' attribute", Priority=-1)]
    public class MarkCanBeNullAction : JetBrains.ReSharper.Intentions.CSharp.ContextActions.Annotations.MarkNullableActionBase
    {
        public MarkCanBeNullAction(JetBrains.ReSharper.Feature.Services.CSharp.Bulbs.ICSharpContextActionDataProvider dataProvider) { }
        protected override string AttributeShortName { get; }
        public override string Text { get; }
        protected override bool IsAvailable(JetBrains.ReSharper.Psi.ControlFlow.CSharp.CSharpControlFlowNullReferenceState state) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Annotates a method with \'value cannot be null\' attribute. The attribute can be co" +
        "nfigured via external annotations.", Group="C#", Name="Annotate method with \'value cannot be null\' attribute", Priority=-1)]
    public class MarkNotNullAction : JetBrains.ReSharper.Intentions.CSharp.ContextActions.Annotations.MarkNullableActionBase
    {
        public MarkNotNullAction(JetBrains.ReSharper.Feature.Services.CSharp.Bulbs.ICSharpContextActionDataProvider dataProvider) { }
        protected override string AttributeShortName { get; }
        public override string Text { get; }
        protected override bool IsAvailable(JetBrains.ReSharper.Psi.ControlFlow.CSharp.CSharpControlFlowNullReferenceState state) { }
    }
    public abstract class MarkNullableActionBase : JetBrains.ReSharper.Intentions.Extensibility.ContextActionBase, JetBrains.ReSharper.Intentions.Extensibility.IContextAction
    {
        protected readonly JetBrains.ReSharper.Feature.Services.CSharp.Bulbs.ICSharpContextActionDataProvider Provider;
        protected MarkNullableActionBase(JetBrains.ReSharper.Feature.Services.CSharp.Bulbs.ICSharpContextActionDataProvider dataProvider) { }
        protected abstract string AttributeShortName { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
        protected abstract bool IsAvailable(JetBrains.ReSharper.Psi.ControlFlow.CSharp.CSharpControlFlowNullReferenceState state);
    }
}
namespace JetBrains.ReSharper.Intentions.CSharp.ContextActions.Check
{
    
    public class MemberInfo
    {
        public string ElementName { get; }
        public JetBrains.ReSharper.Intentions.CSharp.ContextActions.Check.MemberKind MemberKind { get; }
        public static JetBrains.ReSharper.Intentions.CSharp.ContextActions.Check.MemberInfo CreateConstructor([JetBrains.Annotations.NotNullAttribute()] string typeFullName, [JetBrains.Annotations.CanBeNullAttribute()] params string[] arguments) { }
        public static JetBrains.ReSharper.Intentions.CSharp.ContextActions.Check.MemberInfo CreateMethod([JetBrains.Annotations.NotNullAttribute()] string typeFullName, [JetBrains.Annotations.NotNullAttribute()] string name, [JetBrains.Annotations.CanBeNullAttribute()] params string[] arguments) { }
        public static JetBrains.ReSharper.Intentions.CSharp.ContextActions.Check.MemberInfo CreateProperty([JetBrains.Annotations.NotNullAttribute()] string typeFullName, [JetBrains.Annotations.NotNullAttribute()] string name, [JetBrains.Annotations.CanBeNullAttribute()] params string[] arguments) { }
    }
    public enum MemberKind
    {
        Constructor = 0,
        Method = 1,
        Property = 2,
    }
}
namespace JetBrains.ReSharper.Intentions.CSharp.ContextActions.FormatString
{
    
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Adds new format item to format string and new argument to Format method invocatio" +
        "n", Group="C#", Name="Add new format item", Priority=10)]
    public class AddFormatItemAction : JetBrains.ReSharper.Intentions.ContextActions.ClrFormatString.ClrAddFormatItemAction
    {
        public AddFormatItemAction(JetBrains.ReSharper.Feature.Services.CSharp.Bulbs.ICSharpContextActionDataProvider dataProvider) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Removes format string item and proper formatting method argument", Group="C#", Name="Remove format item", Priority=10)]
    public class RemoveFormatItemAction : JetBrains.ReSharper.Intentions.ContextActions.ClrFormatString.ClrRemoveFormatItemAction
    {
        public RemoveFormatItemAction(JetBrains.ReSharper.Feature.Services.CSharp.Bulbs.ICSharpContextActionDataProvider dataProvider) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Surrounds string with string.Format() call.", Group="C#", Name="Surround with format", Priority=11)]
    public class SurroundWithFormatAction : JetBrains.ReSharper.Intentions.ContextActions.ClrFormatString.ClrSurroundWithFormatAction
    {
        public SurroundWithFormatAction(JetBrains.ReSharper.Feature.Services.CSharp.Bulbs.ICSharpContextActionDataProvider dataProvider) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Converts concatenation of a few strings and other objects to the use of string.Fo" +
        "rmat method.", Group="C#", Name="Use format string", Priority=30)]
    public class UseFormatStringAction : JetBrains.ReSharper.Intentions.ContextActions.ClrFormatString.ClrUseFormatStringAction
    {
        public UseFormatStringAction(JetBrains.ReSharper.Feature.Services.CSharp.Bulbs.ICSharpContextActionDataProvider dataProvider) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Moves concatenation argument to new argument of format method and injects a forma" +
        "t item to format string argument.", Group="C#", Name="Move concatenation argument to formatting argument", Priority=10)]
    public class UseFormatStringForSingleArgumentAction : JetBrains.ReSharper.Intentions.CSharp.ContextActions.ClrUseFormatStringForSingleArgumentAction
    {
        public UseFormatStringForSingleArgumentAction(JetBrains.ReSharper.Feature.Services.CSharp.Bulbs.ICSharpContextActionDataProvider dataProvider) { }
    }
}
namespace JetBrains.ReSharper.Intentions.CSharp.ContextActions.ImplementOrOverrideMember
{
    
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Works on an interface member or an abstract member. Searches for classes where th" +
        "is member needs to be implemented and allows to implement it in one of them.", Group="C#", Name="Implement abstract member")]
    public class ImplementAbstractMemberAction : JetBrains.ReSharper.Intentions.Implementor.ImplementMemberBase, JetBrains.ReSharper.Intentions.Extensibility.IContextAction
    {
        public ImplementAbstractMemberAction(JetBrains.ReSharper.Feature.Services.CSharp.Bulbs.ICSharpContextActionDataProvider dataProvider) { }
        public JetBrains.ReSharper.Feature.Services.CSharp.Bulbs.ICSharpContextActionDataProvider DataProvider { get; }
        public override string Text { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        protected override string GetGeneratorKind() { }
        protected override JetBrains.ReSharper.Psi.IOverridableMember GetMemberToImplement() { }
        protected override System.Collections.Generic.List<JetBrains.ReSharper.Psi.ITypeElement> GetTargetTypes(JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
        protected override string SelectPartText() { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Works on a virtual member. Searches for classes where this member can be overridd" +
        "en and allows to override it in one or all of them.", Group="C#", Name="Override virtual member")]
    public class OverrideMemberAction : JetBrains.ReSharper.Intentions.CSharp.ContextActions.ImplementOrOverrideMember.ImplementAbstractMemberAction
    {
        public OverrideMemberAction(JetBrains.ReSharper.Feature.Services.CSharp.Bulbs.ICSharpContextActionDataProvider dataProvider) { }
        public override string Text { get; }
        protected override string GetGeneratorKind() { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
        protected override string SelectPartText() { }
    }
}
namespace JetBrains.ReSharper.Intentions.CSharp.ContextActions.Misc
{
    
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Converts regular string \"\" to verbatim string @\"\".", Group="C#", Name="Convert to verbatim string", Priority=8)]
    public class ConvertRegularStringToVerbatimAction : JetBrains.ReSharper.Intentions.Extensibility.ContextActionBase
    {
        public static readonly JetBrains.Util.Key<string> AvailableKey;
        public ConvertRegularStringToVerbatimAction(JetBrains.ReSharper.Feature.Services.CSharp.Bulbs.ICSharpContextActionDataProvider provider) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static string GetValue([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Tree.IExpression literal) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
        public static bool IsRegularString([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Tree.IExpression stringLiteral) { }
        public static bool IsString([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Tree.IExpression expression) { }
        public static bool IsVerbatimString([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Tree.IExpression stringLiteral) { }
    }
}
namespace JetBrains.ReSharper.Intentions.CSharp.ContextActions.Partial
{
    
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Converts private void method to partial method defining declaration.", Group="C#", Name="Make method partial")]
    public class MakeMethodPartialAction : JetBrains.ReSharper.Intentions.Extensibility.IContextAction
    {
        public MakeMethodPartialAction(JetBrains.ReSharper.Feature.Services.CSharp.Bulbs.ICSharpContextActionDataProvider dataProvider) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        public bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Merges all declarations of a partial method into single declaration.", Group="C#", Name="Merge partial method declarations")]
    public class MergePartialMethodsDeclarationsAction : JetBrains.ReSharper.Intentions.Extensibility.IContextAction
    {
        public MergePartialMethodsDeclarationsAction(JetBrains.ReSharper.Feature.Services.CSharp.Bulbs.ICSharpContextActionDataProvider provider) { }
        public JetBrains.ReSharper.Intentions.Extensibility.IBulbAction[] Items { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        public bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Merges all declarations of a partial type into single declaration.", Group="C#", Name="Merge partial type declarations")]
    public class MergePartialTypesDeclarationsAction : JetBrains.ReSharper.Intentions.Extensibility.IContextAction
    {
        public MergePartialTypesDeclarationsAction(JetBrains.ReSharper.Feature.Services.CSharp.Bulbs.ICSharpContextActionDataProvider provider) { }
        public JetBrains.ReSharper.Intentions.Extensibility.IBulbAction[] Items { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        public bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
}
namespace JetBrains.ReSharper.Intentions.CSharp.ContextActions.Query
{
    
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Converts LINQ query to extension methods call.", Group="C#", Name="Convert LINQ to method chain")]
    public class QueryToExtensionMethodAction : JetBrains.ReSharper.Intentions.Extensibility.IContextAction
    {
        public QueryToExtensionMethodAction(JetBrains.ReSharper.Feature.Services.CSharp.Bulbs.ICSharpContextActionDataProvider provider) { }
        public JetBrains.ReSharper.Intentions.Extensibility.IBulbAction[] Items { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        public bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
}
namespace JetBrains.ReSharper.Intentions.CSharp.ContextActions.Util
{
    
    public class ControlFlowReachabitityChecker
    {
        public ControlFlowReachabitityChecker(JetBrains.ReSharper.Psi.ControlFlow.IControlFlowGraf graf, JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpTreeNode[] elements) { }
        public bool IsReachable(JetBrains.ReSharper.Psi.ControlFlow.CSharp.ICSharpControlFlowElement element) { }
    }
    [System.ObsoleteAttribute("Use IContextAction")]
    public abstract class CSharpContextActionBase : JetBrains.ReSharper.Intentions.Legacy.ContextActionBase_Obsolete
    {
        protected CSharpContextActionBase(JetBrains.ReSharper.Feature.Services.CSharp.Bulbs.ICSharpContextActionDataProvider provider) { }
        protected JetBrains.ReSharper.Feature.Services.CSharp.Bulbs.ICSharpContextActionDataProvider Provider { get; }
    }
    [System.ObsoleteAttribute("Use ContextActionBase")]
    public abstract class OneItemContextActionBase : JetBrains.ReSharper.Intentions.CSharp.ContextActions.Util.CSharpContextActionBase, JetBrains.ReSharper.Intentions.Extensibility.IBulbAction
    {
        protected OneItemContextActionBase(JetBrains.ReSharper.Feature.Services.CSharp.Bulbs.ICSharpContextActionDataProvider provider) { }
        public override JetBrains.ReSharper.Intentions.Extensibility.IBulbAction[] Items { get; }
        public abstract string Text { get; }
        public void Execute(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        protected override void ExecuteInternal(params object[] param) { }
        protected abstract void ExecuteInternal();
        protected override object[] ExecuteInternalPostPSITransaction(params object[] data) { }
        protected void SetCaret(int offset) { }
    }
    public class StatementsRangeWrapper
    {
        public StatementsRangeWrapper(JetBrains.ReSharper.Psi.CSharp.ICSharpStatementsRange range) { }
        public JetBrains.ReSharper.Psi.CSharp.ICSharpStatementsRange StatementsRange { get; }
        public bool Contains(JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpTreeNode element) { }
    }
    public class TypeDeclarationMergingBuilder
    {
        public TypeDeclarationMergingBuilder(JetBrains.ReSharper.Psi.ITypeElement element) { }
        public void AddClassLikeDeclaration(JetBrains.ReSharper.Psi.CSharp.Tree.IClassLikeDeclaration declaration) { }
        public JetBrains.ReSharper.Psi.CSharp.Tree.IClassLikeDeclaration CreateClassLikeDeclaration(JetBrains.ReSharper.Psi.CSharp.CSharpElementFactory factory) { }
    }
}
namespace JetBrains.ReSharper.Intentions.CSharp.DisableWarning
{
    
    [JetBrains.ReSharper.Intentions.Extensibility.CustomHighlightingActionProviderAttribute(typeof(JetBrains.ProjectModel.CSharpProjectFileType))]
    public class DisableByCommentWarningActionProvider : JetBrains.ReSharper.Intentions.Extensibility.ICustomHighlightingActionProvider
    {
        public DisableByCommentWarningActionProvider(JetBrains.ReSharper.Daemon.HighlightingSettingsManager manager) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> GetActions(JetBrains.ReSharper.Daemon.IHighlighting highlighting, JetBrains.DocumentModel.DocumentRange highlightingRange, JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, string inspectionTitle) { }
    }
    [JetBrains.ReSharper.Intentions.Extensibility.CustomHighlightingActionProviderAttribute(typeof(JetBrains.ProjectModel.CSharpProjectFileType))]
    public class DisableByPragmaWarningActionProvider : JetBrains.ReSharper.Intentions.Extensibility.ICustomHighlightingActionProvider
    {
        public DisableByPragmaWarningActionProvider(JetBrains.ReSharper.Daemon.HighlightingSettingsManager highlightingSettingsManager) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> GetActions(JetBrains.ReSharper.Daemon.IHighlighting highlighting, JetBrains.DocumentModel.DocumentRange highlightingRange, JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, string inspectionTitle) { }
    }
}
namespace JetBrains.ReSharper.Intentions.CSharp.Options
{
    
    [JetBrains.UI.Options.OptionsPageAttribute("CsharpContextActions", "Context Actions", typeof(JetBrains.ReSharper.Daemon.Src.Bulbs.Resources.BulbThemedIcons.ContextAction), HelpKeyword="Reference__Options__Languages__CSharp__Context_Actions", ParentId="Csharp", Sequence=4D, SupportedEditions=new string[] {
            "Csharp"})]
    public class CsharpContextActionsPage : JetBrains.ReSharper.Intentions.Options.ContextActionsPageBase
    {
        [JetBrains.Annotations.UsedImplicitlyAttribute()]
        public const string PID = "CsharpContextActions";
        public CsharpContextActionsPage(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionTable contextActionTable, JetBrains.UI.Application.UIApplication uiApplication, JetBrains.Application.Interop.NativeHook.IWindowsHookManager windowsHookManager, JetBrains.ActionManagement.IActionManager actionManager, JetBrains.UI.Options.OptionsSettingsSmartContext smartContext, JetBrains.Threading.IThreading threading) { }
        public override string Id { get; }
    }
}
namespace JetBrains.ReSharper.Intentions.CSharp.QuickFixes
{
    
    public class AddAddressOfFix : JetBrains.ReSharper.Intentions.QuickFixBase_Obsolete
    {
        public AddAddressOfFix(JetBrains.ReSharper.Daemon.CSharp.Errors.NoInitializerInUsingFixedDeclarationError error) { }
        protected override bool IsValid { get; }
        public override string Text { get; }
        protected override void ExecutePostTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        protected override void ExecuteTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        protected override bool IsAvailableEx() { }
    }
    public class AddAwaitFix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public AddAwaitFix(JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpExpression expression, JetBrains.ReSharper.Psi.IType targetType = null) { }
        public AddAwaitFix(JetBrains.ReSharper.Daemon.CSharp.Errors.IncorrectArgumentTypeError error) { }
        public override string Text { get; }
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class AddBodyFix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public AddBodyFix(JetBrains.ReSharper.Daemon.CSharp.Errors.NonexternOperatorWithoutBodyError error) { }
        public AddBodyFix(JetBrains.ReSharper.Daemon.CSharp.Errors.ConstructorMustHaveBodyError error) { }
        public AddBodyFix(JetBrains.ReSharper.Daemon.CSharp.Errors.DestructorMustHaveBodyError error) { }
        public AddBodyFix(JetBrains.ReSharper.Daemon.CSharp.Errors.NonabstractMethodWithoutBodyError error) { }
        public AddBodyFix(JetBrains.ReSharper.Daemon.CSharp.Errors.NonabstractAccessorWithoutBodyError error) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class AddBracesFix : JetBrains.ReSharper.Intentions.QuickFixBase_Obsolete
    {
        public AddBracesFix(JetBrains.ReSharper.Daemon.CSharp.Errors.CollectionInitializerElementIsAssignmentError error) { }
        protected override bool IsValid { get; }
        public override string Text { get; }
        protected override void ExecuteTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        protected override bool IsAvailableEx() { }
    }
    public class AddBreakFix : JetBrains.ReSharper.Intentions.QuickFixBase_Obsolete
    {
        public AddBreakFix(JetBrains.ReSharper.Daemon.CSharp.Errors.BreakStatementMissing1Error error) { }
        public AddBreakFix(JetBrains.ReSharper.Daemon.CSharp.Errors.BreakStatementMissing2Error error) { }
        protected override bool IsValid { get; }
        public override string Text { get; }
        protected override void ExecuteTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        protected override bool IsAvailableEx() { }
    }
    public class AddCaseLabelFix : JetBrains.ReSharper.Intentions.QuickFixBase_Obsolete
    {
        public AddCaseLabelFix(JetBrains.ReSharper.Daemon.CSharp.Errors.CaseLabelIsMissingError error) { }
        protected override bool IsValid { get; }
        public override string Text { get; }
        protected override void ExecutePostTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        protected override void ExecuteTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        protected override bool IsAvailableEx() { }
    }
    public class AddCatchFix : JetBrains.ReSharper.Intentions.QuickFixBase_Obsolete
    {
        public AddCatchFix(JetBrains.ReSharper.Daemon.CSharp.Errors.ExpectedCatchOrFinallyError error) { }
        protected override bool IsValid { get; }
        public override string Text { get; }
        protected override void ExecutePostTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        protected override void ExecuteTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        protected override bool IsAvailableEx() { }
    }
    public class AddClassConstraint2Fix : JetBrains.ReSharper.Intentions.CSharp.QuickFixes.AddConstraintFix2Base
    {
        public AddClassConstraint2Fix(JetBrains.ReSharper.Daemon.CSharp.Errors.TypeArgumentIsNotReferenceTypeError error) { }
        public AddClassConstraint2Fix(JetBrains.ReSharper.Daemon.CSharp.Errors.CompareNonConstrainedGenericWithNullWarning error) { }
        protected override string ConstraintText { get; }
        protected override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.CSharp.Tree.ITypeParameterConstraint> AddConstraint() { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
        protected override void ProcessAddedConstraint(JetBrains.ReSharper.Psi.CSharp.Tree.ITypeParameterConstraint constraint) { }
    }
    public class AddClassConstraint3Fix : JetBrains.ReSharper.Intentions.CSharp.QuickFixes.AddConstraintFixBase
    {
        public AddClassConstraint3Fix(JetBrains.ReSharper.Daemon.CSharp.Errors.PossibleAssignmentToReadonlyFieldWarning error) { }
        protected override string ConstraintText { get; }
        protected override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.CSharp.Tree.ITypeParameterConstraint> AddConstraint() { }
        protected override void ProcessAddedConstraint(JetBrains.ReSharper.Psi.CSharp.Tree.ITypeParameterConstraint constraint) { }
    }
    public class AddClassConstraintFix : JetBrains.ReSharper.Intentions.CSharp.QuickFixes.AddConstraintFixBase
    {
        public AddClassConstraintFix(JetBrains.ReSharper.Daemon.CSharp.Errors.AssignNullToTypeParameterWithoutClassConstraintError error) { }
        public AddClassConstraintFix(JetBrains.ReSharper.Daemon.CSharp.Errors.InitializeTypeParameterWithoutClassConstraintWithNullError error) { }
        public AddClassConstraintFix(JetBrains.ReSharper.Daemon.CSharp.Errors.AsOperatorWithUnconstrainedTypeParameterError error) { }
        public AddClassConstraintFix(JetBrains.ReSharper.Daemon.CSharp.Errors.ClassTypeParameterInValueTypeParameterConstrantListError error) { }
        protected override string ConstraintText { get; }
        protected override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.CSharp.Tree.ITypeParameterConstraint> AddConstraint() { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
        protected override void ProcessAddedConstraint(JetBrains.ReSharper.Psi.CSharp.Tree.ITypeParameterConstraint constraint) { }
    }
    public abstract class AddConstraintFix2Base : JetBrains.ReSharper.Intentions.CSharp.QuickFixes.AddConstraintFixBase
    {
        protected AddConstraintFix2Base(JetBrains.ReSharper.Psi.IType argumentType) { }
    }
    public abstract class AddConstraintFixBase : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        protected AddConstraintFixBase(JetBrains.ReSharper.Psi.ITypeParameter typeParameter) { }
        protected abstract string ConstraintText { get; }
        public override string Text { get; }
        protected JetBrains.ReSharper.Psi.ITypeParameter TypeParameter { get; }
        protected abstract System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.CSharp.Tree.ITypeParameterConstraint> AddConstraint();
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
        protected abstract void ProcessAddedConstraint(JetBrains.ReSharper.Psi.CSharp.Tree.ITypeParameterConstraint constraint);
    }
    public class AddDocCommentFix : JetBrains.ReSharper.Intentions.QuickFixBase_Obsolete
    {
        public AddDocCommentFix(JetBrains.ReSharper.Daemon.CSharp.Errors.PublicOrProtectedMemberNotDocumentedWarning error) { }
        public AddDocCommentFix(JetBrains.ReSharper.Daemon.CSharp.Errors.ParameterNotDocumentedWarning error) { }
        public AddDocCommentFix(JetBrains.ReSharper.Daemon.CSharp.Errors.TypeParameterNotDocumentedWarning error) { }
        protected override bool IsValid { get; }
        public override string Text { get; }
        protected override void ExecutePostTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        protected override void ExecuteTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        protected override bool IsAvailableEx() { }
    }
    public class AddEventAccessorFix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public AddEventAccessorFix(JetBrains.ReSharper.Daemon.CSharp.Errors.EventPropertyMustDeclareAdderAndRemoverError error) { }
        public AddEventAccessorFix(JetBrains.ReSharper.Daemon.CSharp.Errors.ExplicitEventImplementationMustUsePropertySyntaxError error) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class AddExceptionFix : JetBrains.ReSharper.Intentions.QuickFixBase_Obsolete
    {
        public AddExceptionFix(JetBrains.ReSharper.Daemon.CSharp.Errors.ThrowInsideFinallyAndCatchError error) { }
        protected override bool IsValid { get; }
        public override string Text { get; }
        protected override void ExecuteTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        protected override bool IsAvailableEx() { }
    }
    public class AddFinallyFix : JetBrains.ReSharper.Intentions.QuickFixBase_Obsolete
    {
        public AddFinallyFix(JetBrains.ReSharper.Daemon.CSharp.Errors.ExpectedCatchOrFinallyError error) { }
        protected override bool IsValid { get; }
        public override string Text { get; }
        protected override void ExecutePostTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        protected override void ExecuteTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        protected override bool IsAvailableEx() { }
    }
    public class AddGetAccessorFix : JetBrains.ReSharper.Intentions.CSharp.QuickFixes.CSharpAddAccessorFixBase
    {
        public AddGetAccessorFix(JetBrains.ReSharper.Daemon.CSharp.Errors.ReadAccessToPropertyWithoutGetterError error) { }
        public AddGetAccessorFix(JetBrains.ReSharper.Daemon.CSharp.Errors.AccessorIsMissingInImplementationError error) { }
        public AddGetAccessorFix(JetBrains.ReSharper.Daemon.CSharp.Errors.AccessorMissingError error) { }
        public AddGetAccessorFix(JetBrains.ReSharper.Daemon.CSharp.Errors.AbstractAccessorIsNotImplementedError error) { }
        public AddGetAccessorFix(JetBrains.ReSharper.Daemon.CSharp.Errors.CannotOverrideUnexistingAccessorError error) { }
        public AddGetAccessorFix(JetBrains.ReSharper.Daemon.CSharp.Errors.AddedAccessorInPrivateImplementationError error) { }
        public AddGetAccessorFix(JetBrains.ReSharper.Daemon.CSharp.Errors.AccessRightsInSingleAccessorError error) { }
        public AddGetAccessorFix(JetBrains.ReSharper.Daemon.CSharp.Errors.NotReadablePropertyInMemberInitializerError error) { }
        protected override JetBrains.ReSharper.Psi.AccessorKind AccessorKind { get; }
        protected override string AccessorName { get; }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class AddGetSetAccessorsFix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public AddGetSetAccessorsFix(JetBrains.ReSharper.Daemon.CSharp.Errors.AccessorMissingError error) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class AddInitializerFix : JetBrains.ReSharper.Intentions.CSharp.QuickFixes.AddInitializerFixBase
    {
        public AddInitializerFix(JetBrains.ReSharper.Daemon.CSharp.Errors.ConstructorInitializerMissingError error) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public abstract class AddInitializerFixBase : JetBrains.ReSharper.Intentions.Extensibility.BulbActionBase, JetBrains.ReSharper.Intentions.Extensibility.IQuickFix
    {
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        public abstract bool IsAvailable(JetBrains.Util.IUserDataHolder cache);
        protected static bool IsAvailableEx(JetBrains.ReSharper.Psi.CSharp.Tree.IClassDeclaration classDeclaration) { }
    }
    public class AddNewConstraintFix : JetBrains.ReSharper.Intentions.CSharp.QuickFixes.AddConstraintFixBase
    {
        public AddNewConstraintFix(JetBrains.ReSharper.Daemon.CSharp.Errors.CannotCreateInstanceOfTypeParameterWithoutNewConstraintError error) { }
        protected override string ConstraintText { get; }
        protected override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.CSharp.Tree.ITypeParameterConstraint> AddConstraint() { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
        protected override void ProcessAddedConstraint(JetBrains.ReSharper.Psi.CSharp.Tree.ITypeParameterConstraint constraint) { }
    }
    public class AddParameterFix : JetBrains.ReSharper.Intentions.QuickFixes.AddParameterFixBase
    {
        public AddParameterFix(JetBrains.ReSharper.Daemon.CSharp.Errors.IncorrectArgumentNumberError error) { }
        public AddParameterFix(JetBrains.ReSharper.Daemon.CSharp.Errors.IncorrectArgumentsError error) { }
        public AddParameterFix(JetBrains.ReSharper.Daemon.CSharp.Errors.IncorrectArgumentTypeError error) { }
        public AddParameterFix(JetBrains.ReSharper.Daemon.CSharp.Errors.MultipleResolveCandidatesError error) { }
        public AddParameterFix(JetBrains.ReSharper.Daemon.CSharp.Errors.NamedArgumentListDoesnotMatchParametersError error) { }
        protected override JetBrains.ReSharper.Psi.Tree.IExpression ArgumentExpression(JetBrains.ReSharper.Psi.IArgumentInfo argumentInfo) { }
        protected override JetBrains.ReSharper.Psi.IParameter FindMatchingParameter(JetBrains.ReSharper.Psi.IArgumentInfo argumentInfo, JetBrains.ReSharper.Psi.IParametersOwner target) { }
        protected override JetBrains.ReSharper.Psi.IInvocationInfo GetInvocation() { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        protected override JetBrains.ReSharper.Psi.IInvocationInfo MakeArgumentsOwnerCopy(JetBrains.ReSharper.Psi.IInvocationInfo info) { }
        protected override JetBrains.ReSharper.Psi.ParameterKind ParameterKindFromArgument(JetBrains.ReSharper.Psi.IArgumentInfo argument) { }
        protected override bool ParametersOwnerIsSuitableToAddParameter(JetBrains.ReSharper.Psi.IParametersOwner parametersOwner, JetBrains.ReSharper.Psi.IInvocationInfo argumentsOwner) { }
        protected override bool RemoveArgument(JetBrains.ReSharper.Psi.IInvocationInfo info, JetBrains.ReSharper.Psi.IArgumentInfo argumentInfo) { }
    }
    public class AddParams2Fix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public AddParams2Fix(JetBrains.ReSharper.Daemon.CSharp.Errors.BaseMemberHasParamsWarning error) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class AddParamsFix : JetBrains.ReSharper.Intentions.QuickFixBase_Obsolete
    {
        public AddParamsFix(JetBrains.ReSharper.Daemon.CSharp.Errors.NotImplementParamsDiffersError error) { }
        protected override bool IsValid { get; }
        public override string Text { get; }
        protected override void ExecuteTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        protected override bool IsAvailableEx() { }
    }
    public class AddReturnFix : JetBrains.ReSharper.Intentions.QuickFixBase_Obsolete
    {
        public AddReturnFix(JetBrains.ReSharper.Daemon.CSharp.Errors.MissedReturnStatementError error) { }
        protected override bool IsValid { get; }
        public override string Text { get; }
        protected override void ExecutePostTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        protected override void ExecuteTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        protected override bool IsAvailableEx() { }
    }
    public class AddSemicolonFix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public AddSemicolonFix(JetBrains.ReSharper.Daemon.CSharp.Errors.MissingSemicolonAfterLabelError error) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class AddSetAccessorFix : JetBrains.ReSharper.Intentions.CSharp.QuickFixes.CSharpAddAccessorFixBase
    {
        public AddSetAccessorFix(JetBrains.ReSharper.Daemon.CSharp.Errors.ReadonlyAssignmentTargetError error) { }
        public AddSetAccessorFix(JetBrains.ReSharper.Daemon.CSharp.Errors.AccessorMissingError error) { }
        public AddSetAccessorFix(JetBrains.ReSharper.Daemon.CSharp.Errors.WriteAccessToPropertyWithoutSetterError error) { }
        public AddSetAccessorFix(JetBrains.ReSharper.Daemon.CSharp.Errors.AccessorIsMissingInImplementationError error) { }
        public AddSetAccessorFix(JetBrains.ReSharper.Daemon.CSharp.Errors.AbstractAccessorIsNotImplementedError error) { }
        public AddSetAccessorFix(JetBrains.ReSharper.Daemon.CSharp.Errors.CannotOverrideUnexistingAccessorError error) { }
        public AddSetAccessorFix(JetBrains.ReSharper.Daemon.CSharp.Errors.AddedAccessorInPrivateImplementationError error) { }
        public AddSetAccessorFix(JetBrains.ReSharper.Daemon.CSharp.Errors.AccessRightsInSingleAccessorError error) { }
        public AddSetAccessorFix(JetBrains.ReSharper.Daemon.CSharp.Errors.NotWritablePropertyInMemberInitializerError error) { }
        protected override JetBrains.ReSharper.Psi.AccessorKind AccessorKind { get; }
        protected override string AccessorName { get; }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class AddThisInitializerFix : JetBrains.ReSharper.Intentions.QuickFixBase_Obsolete
    {
        public AddThisInitializerFix(JetBrains.ReSharper.Daemon.CSharp.Errors.ConstructorInitializerMissingError error) { }
        protected override bool IsValid { get; }
        public override string Text { get; }
        protected override void ExecutePostTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        protected override void ExecuteTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        protected override bool IsAvailableEx() { }
    }
    public class AddToInterfaceFix : JetBrains.ReSharper.Intentions.QuickFixBase_Obsolete
    {
        public AddToInterfaceFix(JetBrains.ReSharper.Daemon.CSharp.Errors.ExplicitImplementationIsNotInterfaceMemberError error) { }
        protected override bool IsValid { get; }
        public override string Text { get; }
        protected override void ExecuteTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        protected override bool IsAvailableEx() { }
    }
    public class AddTypeArgListFix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public AddTypeArgListFix(JetBrains.ReSharper.Daemon.CSharp.Errors.TypeParametersNumberMismatchError error) { }
        public AddTypeArgListFix(JetBrains.ReSharper.Daemon.CSharp.Errors.TypeParametersNumberMismatchMultipleCandidatesError error) { }
        public AddTypeArgListFix(JetBrains.ReSharper.Daemon.CSharp.Errors.TypeInferenceMultipleCandidatesError error) { }
        public AddTypeArgListFix(JetBrains.ReSharper.Daemon.CSharp.Errors.TypeInferenceError error) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class AssertNotNullFix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public static readonly JetBrains.Util.Key InstanceKey;
        public AssertNotNullFix(JetBrains.ReSharper.Daemon.CSharp.Errors.PossibleNullReferenceExceptionWarning error) { }
        public AssertNotNullFix(JetBrains.ReSharper.Daemon.CSharp.Errors.PossibleInvalidOperationExceptionWarning error) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class AssignDefaultValueFix : JetBrains.ReSharper.Intentions.QuickFixBase_Obsolete
    {
        public AssignDefaultValueFix(JetBrains.ReSharper.Daemon.CSharp.Errors.AssignNullToTypeParameterWithoutClassConstraintError error) { }
        public AssignDefaultValueFix(JetBrains.ReSharper.Daemon.CSharp.Errors.InitializeTypeParameterWithoutClassConstraintWithNullError error) { }
        protected override bool IsValid { get; }
        public override string Text { get; }
        protected override void ExecuteTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        protected override bool IsAvailableEx() { }
    }
    public class AssignToFieldFix : JetBrains.ReSharper.Intentions.QuickFixBase_Obsolete
    {
        public AssignToFieldFix(JetBrains.ReSharper.Daemon.CSharp.Errors.ValueParameterNotUsedWarning error) { }
        protected override bool IsValid { get; }
        public override string Text { get; }
        protected override void ExecuteTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        protected override bool IsAvailableEx() { }
    }
    public class CallConstructorFix : JetBrains.ReSharper.Intentions.CSharp.QuickFixes.CallFixBase
    {
        public CallConstructorFix(JetBrains.ReSharper.Daemon.CSharp.Errors.CannotUseConstructorWithoutBracketsError error) { }
        protected override JetBrains.ReSharper.Psi.Tree.ITreeNode ExecuteEx(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        protected override bool IsAvailableEx(JetBrains.ReSharper.Psi.IDeclaredElement resolveResult, JetBrains.ReSharper.Psi.Tree.ITreeNode referenceName) { }
    }
    public abstract class CallFixBase : JetBrains.ReSharper.Intentions.QuickFixBase_Obsolete
    {
        protected CallFixBase(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        protected JetBrains.ReSharper.Psi.CSharp.CSharpElementFactory Factory { get; }
        protected override bool IsValid { get; }
        public override string Text { get; }
        protected abstract JetBrains.ReSharper.Psi.Tree.ITreeNode ExecuteEx(JetBrains.ReSharper.Psi.Tree.ITreeNode element);
        protected override void ExecutePostTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        protected override void ExecuteTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        protected abstract bool IsAvailableEx(JetBrains.ReSharper.Psi.IDeclaredElement resolveResult, JetBrains.ReSharper.Psi.Tree.ITreeNode element);
        protected override bool IsAvailableEx() { }
    }
    public class CallMethodFix : JetBrains.ReSharper.Intentions.CSharp.QuickFixes.CallFixBase
    {
        public CallMethodFix(JetBrains.ReSharper.Daemon.CSharp.Errors.InvalidExpressionStatementError error) { }
        public CallMethodFix(JetBrains.ReSharper.Daemon.CSharp.Errors.CannotUseInvocableError error) { }
        protected override JetBrains.ReSharper.Psi.Tree.ITreeNode ExecuteEx(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        protected override bool IsAvailableEx(JetBrains.ReSharper.Psi.IDeclaredElement resolveResult, JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
    }
    public class CallStructConstructorFix : JetBrains.ReSharper.Intentions.QuickFixBase_Obsolete
    {
        public CallStructConstructorFix(JetBrains.ReSharper.Daemon.CSharp.Errors.NotInitializedThisInStructError error) { }
        protected override bool IsValid { get; }
        public override string Text { get; }
        protected override void ExecuteTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        protected override bool IsAvailableEx() { }
    }
    public class CastEnumsFix : JetBrains.ReSharper.Intentions.QuickFixBase_Obsolete
    {
        public CastEnumsFix(JetBrains.ReSharper.Daemon.CSharp.Errors.CannotApplyBinaryOperatorMultipleCandidatesError error) { }
        public CastEnumsFix(JetBrains.ReSharper.Daemon.CSharp.Errors.CannotApplyBinaryOperatorError error) { }
        protected override bool IsValid { get; }
        public override string Text { get; }
        protected override void ExecuteTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        protected override bool IsAvailableEx() { }
    }
    public abstract class CastFixBase : JetBrains.ReSharper.Intentions.QuickFixBase_Obsolete
    {
        protected CastFixBase(bool removeInnerCasts) { }
        protected abstract bool AsCast { get; }
        protected virtual bool SkipImplicitConversions { get; }
        protected static bool CanCastToTypeUsingAsCast(JetBrains.ReSharper.Psi.IType type) { }
        protected JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpExpression CreateCast(JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpExpression expression) { }
        protected JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpExpression CreateCast(JetBrains.Util.Pair<JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpExpression, JetBrains.ReSharper.Psi.IType> p, bool canReturnExpr) { }
        protected string GetText(bool multipleError, JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpExpression expr) { }
        protected bool IsAvailableEx(JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpExpression expression) { }
        protected virtual JetBrains.Util.Pair<, >[] PossibleTypes(JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpExpression expression) { }
    }
    public class CastFixItem : JetBrains.ReSharper.Intentions.Extensibility.BulbActionBase
    {
        public override string Text { get; }
        public static JetBrains.ReSharper.Intentions.Extensibility.BulbActionBase CreateSafeCast(JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpExpression expression, JetBrains.Util.Pair<JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpExpression, JetBrains.ReSharper.Psi.IType> target, string message) { }
        public static JetBrains.ReSharper.Intentions.Extensibility.BulbActionBase CreateUnSafeCast(JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpExpression expression, JetBrains.Util.Pair<JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpExpression, JetBrains.ReSharper.Psi.IType> target, string message) { }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
    }
    public abstract class CastInArgumentBase : JetBrains.ReSharper.Intentions.CSharp.QuickFixes.CastFixBase
    {
        protected bool mySkipImplicitConversions;
        protected CastInArgumentBase([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpArgument argument, bool removeInnerCasts) { }
        protected CastInArgumentBase(JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpExpression expression, bool removeInnerCasts) { }
        protected override bool IsValid { get; }
        protected override JetBrains.ReSharper.Intentions.Extensibility.IBulbAction[] Items { get; }
        protected override bool SkipImplicitConversions { get; }
        public override string Text { get; }
        protected override void ExecuteTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        protected static JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpArgument FindArgument(JetBrains.ReSharper.Psi.Resolve.IReference reference, bool returnReferenceElement) { }
        protected static JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpExpression GetExpression(JetBrains.ReSharper.Psi.CSharp.ICSharpArgumentInfo argument) { }
        protected override bool IsAvailableEx() { }
    }
    public class CastInArgumentFix : JetBrains.ReSharper.Intentions.CSharp.QuickFixes.CastInArgumentBase
    {
        public CastInArgumentFix(JetBrains.ReSharper.Daemon.CSharp.Errors.IncorrectArgumentTypeError error) { }
        public CastInArgumentFix(JetBrains.ReSharper.Daemon.CSharp.Errors.MultipleResolveCandidatesError error) { }
        public CastInArgumentFix(JetBrains.ReSharper.Daemon.CSharp.Errors.IncorrectArgumentsError error) { }
        public CastInArgumentFix(JetBrains.ReSharper.Daemon.CSharp.Errors.IncorrectArgumentNumberError error) { }
        public CastInArgumentFix(JetBrains.ReSharper.Daemon.CSharp.Errors.IndexerIncorrectArgumentNumberError error) { }
        protected override bool AsCast { get; }
    }
    public class CastInArrayElementFix : JetBrains.ReSharper.Intentions.CSharp.QuickFixes.CastInArrayElementFixBase
    {
        public CastInArrayElementFix(JetBrains.ReSharper.Daemon.CSharp.Errors.IncorrectArrayElementTypeError error) { }
        protected override bool AsCast { get; }
    }
    public abstract class CastInArrayElementFixBase : JetBrains.ReSharper.Intentions.CSharp.QuickFixes.CastFixBase, JetBrains.ReSharper.Intentions.Extensibility.IBulbAction
    {
        public CastInArrayElementFixBase(JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpExpression initializerExpression, bool removeInnerCasts) { }
        protected override bool IsValid { get; }
        public override string Text { get; }
        protected override void ExecuteTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        protected override bool IsAvailableEx() { }
    }
    public abstract class CastInAssignmentBase : JetBrains.ReSharper.Intentions.CSharp.QuickFixes.CastFixBase, JetBrains.ReSharper.Intentions.Extensibility.IBulbAction
    {
        protected readonly JetBrains.ReSharper.Psi.CSharp.Tree.IAssignmentExpression myAssignmentExpression;
        public CastInAssignmentBase(JetBrains.ReSharper.Psi.CSharp.Tree.IAssignmentExpression assignmentExpression, bool removeInnerCasts) { }
        protected override bool IsValid { get; }
        public override string Text { get; }
        protected override void ExecuteTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        protected override bool IsAvailableEx() { }
    }
    public class CastInAssignmentFix : JetBrains.ReSharper.Intentions.CSharp.QuickFixes.CastInAssignmentBase
    {
        public CastInAssignmentFix(JetBrains.ReSharper.Daemon.CSharp.Errors.IncorrectAssignmentTypeError error) { }
        protected override bool AsCast { get; }
    }
    public class CastInBinaryFix : JetBrains.ReSharper.Intentions.CSharp.QuickFixes.CastFixBase, JetBrains.ReSharper.Intentions.Extensibility.IBulbAction
    {
        public CastInBinaryFix(JetBrains.ReSharper.Daemon.CSharp.Errors.CannotApplyBinaryOperatorMultipleCandidatesError error) { }
        public CastInBinaryFix(JetBrains.ReSharper.Daemon.CSharp.Errors.CannotApplyBinaryOperatorError error) { }
        protected override bool AsCast { get; }
        protected override bool IsValid { get; }
        public override string Text { get; }
        protected override void ExecuteTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        protected override bool IsAvailableEx() { }
    }
    public class CastInComparisonFix : JetBrains.ReSharper.Intentions.QuickFixBase_Obsolete
    {
        public CastInComparisonFix(JetBrains.ReSharper.Daemon.CSharp.Errors.PossibleUnintendedReferenceComparisonWarning error) { }
        protected override bool IsValid { get; }
        public override string Text { get; }
        protected override void ExecuteTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        protected override bool IsAvailableEx() { }
    }
    public class CastInDimensionFix : JetBrains.ReSharper.Intentions.CSharp.QuickFixes.CastFixBase, JetBrains.ReSharper.Intentions.Extensibility.IBulbAction
    {
        public CastInDimensionFix(JetBrains.ReSharper.Daemon.CSharp.Errors.NonIntegerArrayCreationParameterError error) { }
        public CastInDimensionFix(JetBrains.ReSharper.Daemon.CSharp.Errors.CannotImplicitlyConvertTypeError error) { }
        public CastInDimensionFix(JetBrains.ReSharper.Daemon.CSharp.Errors.TypeIsNotEnumerableError error) { }
        public CastInDimensionFix(JetBrains.ReSharper.Daemon.CSharp.Errors.NonDisposableTypeInUsingStatementError error) { }
        protected override bool AsCast { get; }
        protected override bool IsValid { get; }
        public override string Text { get; }
        protected override void ExecuteTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        protected override bool IsAvailableEx() { }
    }
    public class CastInGotoFix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public CastInGotoFix(JetBrains.ReSharper.Daemon.CSharp.Errors.CannotImplicitlyConvertGotoCaseValueToGoverningTypeWarning error) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public abstract class CastInInitializerBase : JetBrains.ReSharper.Intentions.CSharp.QuickFixes.CastFixBase, JetBrains.ReSharper.Intentions.Extensibility.IBulbAction
    {
        protected JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpExpression myValue;
        protected CastInInitializerBase(JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpExpression value, bool removeInnerCasts) { }
        protected override bool IsValid { get; }
        public override string Text { get; }
        protected override void ExecuteTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        protected override bool IsAvailableEx() { }
    }
    public class CastInInitializerFix : JetBrains.ReSharper.Intentions.CSharp.QuickFixes.CastInInitializerBase
    {
        public CastInInitializerFix(JetBrains.ReSharper.Daemon.CSharp.Errors.IncorrectInitializerTypeError error) { }
        protected override bool AsCast { get; }
    }
    public class CastInLambdaBodyExpressionFix : JetBrains.ReSharper.Intentions.CSharp.QuickFixes.CastInLambdaBodyExpressionFixBase
    {
        public CastInLambdaBodyExpressionFix(JetBrains.ReSharper.Daemon.CSharp.Errors.IncorrectLambdaBodyExpressionTypeError error) { }
        protected override bool AsCast { get; }
    }
    public abstract class CastInLambdaBodyExpressionFixBase : JetBrains.ReSharper.Intentions.CSharp.QuickFixes.CastFixBase
    {
        protected CastInLambdaBodyExpressionFixBase(JetBrains.ReSharper.Daemon.CSharp.Errors.IncorrectLambdaBodyExpressionTypeError error) { }
        protected override bool IsValid { get; }
        public override string Text { get; }
        protected override void ExecuteTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        protected override bool IsAvailableEx() { }
    }
    public abstract class CastInReturnBase : JetBrains.ReSharper.Intentions.CSharp.QuickFixes.CastFixBase, JetBrains.ReSharper.Intentions.Extensibility.IBulbAction
    {
        protected CastInReturnBase(JetBrains.ReSharper.Psi.CSharp.Tree.IReturnStatement returnStatement, bool removeInnerCasts) { }
        protected override bool IsValid { get; }
        public override string Text { get; }
        protected override void ExecuteTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        protected override bool IsAvailableEx() { }
    }
    public class CastInReturnFix : JetBrains.ReSharper.Intentions.CSharp.QuickFixes.CastInReturnBase
    {
        public CastInReturnFix(JetBrains.ReSharper.Daemon.CSharp.Errors.IncorrectReturnTypeError error) { }
        protected override bool AsCast { get; }
    }
    public class CastOnAccessErrorFix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public CastOnAccessErrorFix(JetBrains.ReSharper.Daemon.CSharp.Errors.CannotAccessExplicitImplementationError error) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class CastToCommonType2Fix : JetBrains.ReSharper.Intentions.CSharp.QuickFixes.CastFixBase
    {
        public CastToCommonType2Fix(JetBrains.ReSharper.Daemon.CSharp.Errors.InvalidNullCoalescingOperandsError error) { }
        protected override bool AsCast { get; }
        protected override bool IsValid { get; }
        public override string Text { get; }
        protected override void ExecuteTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        protected override bool IsAvailableEx() { }
    }
    public class CastToCommonTypeFix : JetBrains.ReSharper.Intentions.CSharp.QuickFixes.CastFixBase, JetBrains.ReSharper.Intentions.Extensibility.IBulbAction
    {
        public CastToCommonTypeFix(JetBrains.ReSharper.Daemon.CSharp.Errors.CannotDetermineTernaryExpressionTypeError error) { }
        public CastToCommonTypeFix(JetBrains.ReSharper.Daemon.CSharp.Errors.CannotDetermineTernaryExpressionType2Error error) { }
        protected override bool AsCast { get; }
        protected override bool IsValid { get; }
        public override string Text { get; }
        protected override void ExecuteTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        protected override bool IsAvailableEx() { }
    }
    public class ChangeAllocatedTypeFix : JetBrains.ReSharper.Intentions.QuickFixBase_Obsolete
    {
        public ChangeAllocatedTypeFix(JetBrains.ReSharper.Daemon.CSharp.Errors.IncorrectStackAllockInitializerTypeError error) { }
        protected override bool IsValid { get; }
        public override string Text { get; }
        protected override void ExecuteTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        protected override bool IsAvailableEx() { }
    }
    public class ChangeArgTypeInArgumentFix : JetBrains.ReSharper.Intentions.CSharp.QuickFixes.ChangeTypeFixBase
    {
        public ChangeArgTypeInArgumentFix(JetBrains.ReSharper.Daemon.CSharp.Errors.IncorrectArgumentTypeError error) { }
        public ChangeArgTypeInArgumentFix(JetBrains.ReSharper.Daemon.CSharp.Errors.RefOutArgumentTypeMismatchError error) { }
        protected override JetBrains.ReSharper.Psi.IClrDeclaredElement GetDeclaredElement() { }
        protected override JetBrains.ReSharper.Psi.IType GetTargetType() { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class ChangeArgumentKind2Fix : JetBrains.ReSharper.Intentions.Extensibility.IQuickFix
    {
        public ChangeArgumentKind2Fix(JetBrains.ReSharper.Daemon.CSharp.Errors.MultipleResolveCandidatesError error) { }
        public ChangeArgumentKind2Fix(JetBrains.ReSharper.Daemon.CSharp.Errors.IncorrectArgumentsError error) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        public bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class ChangeArgumentKindFix : JetBrains.ReSharper.Intentions.QuickFixBase_Obsolete
    {
        public ChangeArgumentKindFix(JetBrains.ReSharper.Daemon.CSharp.Errors.IncorrectArgumentKindError error) { }
        protected override bool IsValid { get; }
        public override string Text { get; }
        protected override void ExecuteTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        protected override bool IsAvailableEx() { }
    }
    public class ChangeArrayElementTypeFix : JetBrains.ReSharper.Intentions.CSharp.QuickFixes.ChangeTypeFixBase
    {
        public ChangeArrayElementTypeFix(JetBrains.ReSharper.Daemon.CSharp.Errors.IncorrectArrayElementTypeError error) { }
        public ChangeArrayElementTypeFix(JetBrains.ReSharper.Daemon.CSharp.Errors.CoVariantArrayConversionWarning error) { }
        protected override JetBrains.ReSharper.Psi.IClrDeclaredElement GetDeclaredElement() { }
        protected override JetBrains.ReSharper.Psi.IType GetTargetType() { }
    }
    public class ChangeDelegateSignatureFix : JetBrains.ReSharper.Intentions.QuickFixes.ChangeSignatureFixBase
    {
        public ChangeDelegateSignatureFix(JetBrains.ReSharper.Daemon.CSharp.Errors.IncorrectSignatureInDelegateCreationError error) { }
    }
    public class ChangeFieldTypeFromVarFix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public ChangeFieldTypeFromVarFix(JetBrains.ReSharper.Daemon.CSharp.Errors.NotResolvedError error) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class ChangeForeachVarTypeFix : JetBrains.ReSharper.Intentions.CSharp.QuickFixes.ChangeTypeFixBase
    {
        public ChangeForeachVarTypeFix(JetBrains.ReSharper.Daemon.CSharp.Errors.IncorrectForeachVariableTypeError error) { }
        public ChangeForeachVarTypeFix(JetBrains.ReSharper.Daemon.CSharp.Errors.MoreSpecificForeachVariableTypeAvailableWarning error) { }
        protected override JetBrains.ReSharper.Psi.IClrDeclaredElement GetDeclaredElement() { }
        protected override JetBrains.ReSharper.Psi.IType GetTargetType() { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class ChangeInstantiatedTypeFix : JetBrains.ReSharper.Intentions.QuickFixBase_Obsolete
    {
        public ChangeInstantiatedTypeFix(JetBrains.ReSharper.Daemon.CSharp.Errors.IncorrectInitializerTypeError error) { }
        public ChangeInstantiatedTypeFix(JetBrains.ReSharper.Daemon.CSharp.Errors.IncorrectAssignmentTypeError error) { }
        protected override bool IsValid { get; }
        public override string Text { get; }
        protected override void ExecutePostTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        protected override void ExecuteTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        protected override bool IsAvailableEx() { }
    }
    public class ChangeInvokedDelegateTypeFix : JetBrains.ReSharper.Intentions.CSharp.QuickFixes.ChangeTypeFixBase
    {
        public ChangeInvokedDelegateTypeFix(JetBrains.ReSharper.Daemon.CSharp.Errors.IncorrectArgumentNumberError error) { }
        public ChangeInvokedDelegateTypeFix(JetBrains.ReSharper.Daemon.CSharp.Errors.IncorrectArgumentsError error) { }
        public ChangeInvokedDelegateTypeFix(JetBrains.ReSharper.Daemon.CSharp.Errors.IncorrectSignatureInDelegateCreationError error) { }
        public ChangeInvokedDelegateTypeFix(JetBrains.ReSharper.Daemon.CSharp.Errors.IncorrectArgumentTypeError error) { }
        protected override JetBrains.ReSharper.Psi.IClrDeclaredElement GetDeclaredElement() { }
        protected override JetBrains.ReSharper.Psi.IType GetTargetType() { }
    }
    public class ChangeMethodSignatureFix : JetBrains.ReSharper.Intentions.QuickFixes.ChangeSignatureFixBase
    {
        public ChangeMethodSignatureFix(JetBrains.ReSharper.Daemon.CSharp.Errors.IncorrectSignatureInDelegateCreationError error) { }
        public ChangeMethodSignatureFix(JetBrains.ReSharper.Daemon.CSharp.Errors.IncorrectInitializerTypeError error) { }
    }
    public class ChangeParameterTypeInArgumentFix : JetBrains.ReSharper.Intentions.Extensibility.IQuickFix
    {
        public ChangeParameterTypeInArgumentFix(JetBrains.ReSharper.Daemon.CSharp.Errors.IncorrectArgumentTypeError error) { }
        public ChangeParameterTypeInArgumentFix(JetBrains.ReSharper.Daemon.CSharp.Errors.RefOutArgumentTypeMismatchError error) { }
        public ChangeParameterTypeInArgumentFix(JetBrains.ReSharper.Daemon.CSharp.Errors.CoVariantArrayConversionWarning error) { }
        public ChangeParameterTypeInArgumentFix(JetBrains.ReSharper.Daemon.CSharp.Errors.WrongReturnTypeOfAsyncAnonymousFunctionError error) { }
        public JetBrains.ReSharper.Intentions.Extensibility.IBulbAction[] Items { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        public bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class ChangeRequiredBaseTypeFix : JetBrains.ReSharper.Intentions.Extensibility.BulbActionBase, JetBrains.ReSharper.Intentions.Extensibility.IQuickFix
    {
        public ChangeRequiredBaseTypeFix(JetBrains.ReSharper.Daemon.CSharp.Errors.RequiredBaseTypesIsNotInheritedWarning error) { }
        public override string Text { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class ChangeSignatureOfDelegateArgumentFix : JetBrains.ReSharper.Intentions.Extensibility.IQuickFix
    {
        public ChangeSignatureOfDelegateArgumentFix(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        public bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public abstract class ChangeTextFixBase : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        protected void ExecutePostReplaceSuggestion(JetBrains.TextControl.ITextControl textControl, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Psi.Resolve.IReference reference, System.Collections.Generic.List<string> items) { }
    }
    public abstract class ChangeTypeFixBase : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public override string Text { get; }
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        protected abstract JetBrains.ReSharper.Psi.IClrDeclaredElement GetDeclaredElement();
        protected abstract JetBrains.ReSharper.Psi.IType GetTargetType();
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class ChangeTypeInAssignmentFix : JetBrains.ReSharper.Intentions.QuickFixes.QuickFix
    {
        public ChangeTypeInAssignmentFix(JetBrains.ReSharper.Daemon.CSharp.Errors.IncorrectAssignmentTypeError error) { }
    }
    public class ChangeTypeInInitializerFix : JetBrains.ReSharper.Intentions.QuickFixes.QuickFix
    {
        public ChangeTypeInInitializerFix(JetBrains.ReSharper.Daemon.CSharp.Errors.IncorrectInitializerTypeError error) { }
        public ChangeTypeInInitializerFix(JetBrains.ReSharper.Daemon.CSharp.Errors.IncorrectStackAllockInitializerTypeError error) { }
    }
    public abstract class ChangeTypeInReturnFix : JetBrains.ReSharper.Intentions.CSharp.QuickFixes.ChangeTypeFixBase
    {
        protected ChangeTypeInReturnFix(JetBrains.ReSharper.Psi.CSharp.Tree.IReturnStatement returnStatement) { }
        protected override JetBrains.ReSharper.Psi.IClrDeclaredElement GetDeclaredElement() { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        protected override JetBrains.ReSharper.Psi.IType GetTargetType() { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class ChangeTypeInYieldFix : JetBrains.ReSharper.Intentions.CSharp.QuickFixes.ChangeTypeFixBase
    {
        public ChangeTypeInYieldFix(JetBrains.ReSharper.Daemon.CSharp.Errors.IncorrectYieldReturnTypeError error) { }
        protected bool IsValid { get; }
        protected override JetBrains.ReSharper.Psi.IClrDeclaredElement GetDeclaredElement() { }
        protected override JetBrains.ReSharper.Psi.IType GetTargetType() { }
    }
    public class static ChangeTypeItemsCreator
    {
        public static JetBrains.ReSharper.Intentions.QuickFixes.ChangeTypeFixItem[] FromArgument(JetBrains.ReSharper.Psi.CSharp.ICSharpArgumentInfo csharpArgumentInfo) { }
        public static JetBrains.ReSharper.Intentions.QuickFixes.ChangeTypeFixItem[] FromAssigment(JetBrains.ReSharper.Psi.CSharp.Tree.IAssignmentExpression assignmentExpression) { }
        public static JetBrains.ReSharper.Intentions.QuickFixes.ChangeTypeFixItem[] FromConditionalTernary(JetBrains.ReSharper.Psi.CSharp.Tree.IConditionalTernaryExpression conditionalExpression) { }
        public static JetBrains.ReSharper.Intentions.QuickFixes.ChangeTypeFixItem[] FromDeclaration(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration, JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpExpression csharpExpression) { }
        public static JetBrains.ReSharper.Intentions.QuickFixes.ChangeTypeFixItem[] FromMemberInitializer(JetBrains.ReSharper.Psi.CSharp.Tree.IMemberInitializer initializer) { }
        public static JetBrains.ReSharper.Intentions.QuickFixes.ChangeTypeFixItem[] FromNullCoalescing(JetBrains.ReSharper.Psi.CSharp.Tree.INullCoalescingExpression nullCoalescingExpression) { }
        public static JetBrains.ReSharper.Intentions.QuickFixes.ChangeTypeFixItem[] FromReturn(JetBrains.ReSharper.Psi.CSharp.Tree.IReturnStatement returnStatement) { }
        public static JetBrains.ReSharper.Intentions.QuickFixes.ChangeTypeFixItem[] FromUnknownParentOfExpresion(JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpExpression csharpExpression) { }
        public static JetBrains.ReSharper.Intentions.QuickFixes.ChangeTypeFixItem[] FromVariableInitializer(JetBrains.ReSharper.Psi.CSharp.Tree.IVariableInitializer variableInitializer) { }
        public static System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IType> ParamArrayPosibleTypes(JetBrains.ReSharper.Psi.CSharp.ICSharpArgumentInfo csharpArgumentInfo) { }
    }
    public class ChangeTypeOfArrayFix : JetBrains.ReSharper.Intentions.CSharp.QuickFixes.ChangeTypeFixBase
    {
        public ChangeTypeOfArrayFix(JetBrains.ReSharper.Daemon.CSharp.Errors.IncorrectArrayElementTypeError error) { }
        public ChangeTypeOfArrayFix(JetBrains.ReSharper.Daemon.CSharp.Errors.InvalidArrayInitializerError error) { }
        public ChangeTypeOfArrayFix(JetBrains.ReSharper.Daemon.CSharp.Errors.ArrayInitializerExpectedError error) { }
        protected bool IsValid { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        protected override JetBrains.ReSharper.Psi.IClrDeclaredElement GetDeclaredElement() { }
        protected override JetBrains.ReSharper.Psi.IType GetTargetType() { }
    }
    public class ChangeTypeOfNewFix : JetBrains.ReSharper.Intentions.QuickFixBase_Obsolete
    {
        public ChangeTypeOfNewFix(JetBrains.ReSharper.Daemon.CSharp.Errors.IncorrectArrayElementTypeError error) { }
        public ChangeTypeOfNewFix(JetBrains.ReSharper.Daemon.CSharp.Errors.ArrayInitializerExpectedError error) { }
        public ChangeTypeOfNewFix(JetBrains.ReSharper.Daemon.CSharp.Errors.InvalidArrayInitializerError error) { }
        protected override bool IsValid { get; }
        public override string Text { get; }
        protected override void ExecuteTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        protected override bool IsAvailableEx() { }
    }
    public abstract class ChangeValueTypeFixBase : JetBrains.ReSharper.Intentions.CSharp.QuickFixes.ChangeTypeFixBase
    {
        protected readonly JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpExpression myExpression;
        protected ChangeValueTypeFixBase(JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpExpression expression) { }
        protected bool IsValid { get; }
        protected override JetBrains.ReSharper.Psi.IClrDeclaredElement GetDeclaredElement() { }
    }
    public class ChangeValueTypeInConditionFix : JetBrains.ReSharper.Intentions.CSharp.QuickFixes.ChangeValueTypeFixBase
    {
        public ChangeValueTypeInConditionFix(JetBrains.ReSharper.Daemon.CSharp.Errors.CannotImplicitlyConvertTypeError error) { }
        protected override JetBrains.ReSharper.Psi.IType GetTargetType() { }
    }
    public class ChangeValueTypeInDimensionFix : JetBrains.ReSharper.Intentions.CSharp.QuickFixes.ChangeValueTypeFixBase
    {
        public ChangeValueTypeInDimensionFix(JetBrains.ReSharper.Daemon.CSharp.Errors.NonIntegerArrayCreationParameterError error) { }
        protected override JetBrains.ReSharper.Psi.IType GetTargetType() { }
    }
    public class ChangeValueTypeInGotoCaseFix : JetBrains.ReSharper.Intentions.CSharp.QuickFixes.ChangeValueTypeFixBase
    {
        public ChangeValueTypeInGotoCaseFix(JetBrains.ReSharper.Daemon.CSharp.Errors.CannotImplicitlyConvertGotoCaseValueToGoverningTypeWarning error) { }
        protected override JetBrains.ReSharper.Psi.IType GetTargetType() { }
    }
    public class ChangeValueTypeInReturnFix : JetBrains.ReSharper.Intentions.CSharp.QuickFixes.ChangeValueTypeFixBase
    {
        public ChangeValueTypeInReturnFix(JetBrains.ReSharper.Daemon.CSharp.Errors.IncorrectLambdaBodyExpressionTypeError error) { }
        protected override JetBrains.ReSharper.Psi.IType GetTargetType() { }
    }
    public class ChangeValueTypeInYieldFix : JetBrains.ReSharper.Intentions.CSharp.QuickFixes.ChangeValueTypeFixBase
    {
        public ChangeValueTypeInYieldFix(JetBrains.ReSharper.Daemon.CSharp.Errors.IncorrectYieldReturnTypeError error) { }
        protected override JetBrains.ReSharper.Psi.IType GetTargetType() { }
    }
    public class CheckNullFix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public static readonly JetBrains.Util.Key InstanceKey;
        public CheckNullFix(JetBrains.ReSharper.Daemon.CSharp.Errors.PossibleNullReferenceExceptionWarning error) { }
        public CheckNullFix(JetBrains.ReSharper.Daemon.CSharp.Errors.PossibleInvalidOperationExceptionWarning error) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class ChooseTypeFix : JetBrains.ReSharper.Intentions.Extensibility.IQuickFix
    {
        public ChooseTypeFix(JetBrains.ReSharper.Daemon.CSharp.Errors.MultipleResolveCandidatesError error) { }
        public ChooseTypeFix(JetBrains.ReSharper.Daemon.CSharp.Errors.MultipleCandidatesInDocCommentWarning error) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        public bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class CommentAssignmentFix : JetBrains.ReSharper.Intentions.QuickFixBase_Obsolete
    {
        public CommentAssignmentFix(JetBrains.ReSharper.Daemon.CSharp.Errors.AssignmentNotUsedWarning error) { }
        protected override bool IsValid { get; }
        public override string Text { get; }
        protected override void ExecutePostTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        protected override void ExecuteTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        protected override bool IsAvailableEx() { }
    }
    public class CommentUnreachableCodeFix : JetBrains.ReSharper.Intentions.QuickFixBase_Obsolete
    {
        public CommentUnreachableCodeFix(JetBrains.ReSharper.Daemon.CSharp.Errors.UnreachableCodeWarning error) { }
        public CommentUnreachableCodeFix(JetBrains.ReSharper.Daemon.CSharp.Errors.UnreachableCodeCompilerWarning error) { }
        protected override bool IsValid { get; }
        public override string Text { get; }
        protected override void ExecutePostTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        protected override void ExecuteTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        protected override bool IsAvailableEx() { }
    }
    public class CompareWithDefaultValueFix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public CompareWithDefaultValueFix(JetBrains.ReSharper.Daemon.CSharp.Errors.CannotImplicitlyConvertTypeError error) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class ConvertCollectionInArgumentFix : JetBrains.ReSharper.Intentions.QuickFixBase_Obsolete
    {
        public ConvertCollectionInArgumentFix(JetBrains.ReSharper.Daemon.CSharp.Errors.IncorrectArgumentTypeError error) { }
        protected override bool IsValid { get; }
        public override string Text { get; }
        public static void ExecuteEx(JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpExpression expression) { }
        protected override void ExecuteTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        public static string GetText(JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpExpression expression) { }
        public static bool IsAvailable(JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpExpression expression) { }
        protected override bool IsAvailableEx() { }
    }
    public class ConvertCollectionInArrayElementFix : JetBrains.ReSharper.Intentions.QuickFixBase_Obsolete
    {
        public ConvertCollectionInArrayElementFix(JetBrains.ReSharper.Daemon.CSharp.Errors.IncorrectArrayElementTypeError error) { }
        protected override bool IsValid { get; }
        public override string Text { get; }
        protected override void ExecuteTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        protected override bool IsAvailableEx() { }
    }
    public class ConvertIfDoToWhileFix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public ConvertIfDoToWhileFix(JetBrains.ReSharper.Daemon.CSharp.Errors.ConvertIfDoToWhileWarning warning) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class ConvertIfToOrFix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public ConvertIfToOrFix(JetBrains.ReSharper.Daemon.CSharp.Errors.ConvertIfToOrExpressionWarning warning) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class ConvertToLocalVariableFix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public ConvertToLocalVariableFix(JetBrains.ReSharper.Daemon.CSharp.Errors.PrivateFieldCanBeConvertedToLocalVariableWarning warning) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class ConvertToMethodFix : JetBrains.ReSharper.Intentions.QuickFixBase_Obsolete
    {
        public ConvertToMethodFix(JetBrains.ReSharper.Daemon.CSharp.Errors.ConversionToInterfaceError error) { }
        public ConvertToMethodFix(JetBrains.ReSharper.Daemon.CSharp.Errors.ConversionToObjectError error) { }
        public ConvertToMethodFix(JetBrains.ReSharper.Daemon.CSharp.Errors.ConversionFromInterfaceError error) { }
        public ConvertToMethodFix(JetBrains.ReSharper.Daemon.CSharp.Errors.ConversionFromObjectError error) { }
        public ConvertToMethodFix(JetBrains.ReSharper.Daemon.CSharp.Errors.ConversionToDerivedClassError error) { }
        public ConvertToMethodFix(JetBrains.ReSharper.Daemon.CSharp.Errors.ConversionToBaseClassError error) { }
        public ConvertToMethodFix(JetBrains.ReSharper.Daemon.CSharp.Errors.ConversionFromDerivedClassError error) { }
        public ConvertToMethodFix(JetBrains.ReSharper.Daemon.CSharp.Errors.ConversionFromBaseClassError error) { }
        public ConvertToMethodFix(JetBrains.ReSharper.Daemon.CSharp.Errors.NoEnclosingTypeInConversionOperatorError error) { }
        protected override bool IsValid { get; }
        public override string Text { get; }
        protected override void ExecuteTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        protected override bool IsAvailableEx() { }
    }
    public class CopyDefaultValueFromBaseFix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public CopyDefaultValueFromBaseFix(JetBrains.ReSharper.Daemon.CSharp.Errors.OptionalParameterHierarchyMismatch_MissingWarning error) { }
        public CopyDefaultValueFromBaseFix(JetBrains.ReSharper.Daemon.CSharp.Errors.OptionalParameterHierarchyMismatch_MismatchWarning error) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class CopyInterfaceAccessorBodyFix : JetBrains.ReSharper.Intentions.CSharp.QuickFixes.CopyInterfaceMemberFixBase
    {
        public CopyInterfaceAccessorBodyFix(JetBrains.ReSharper.Daemon.CSharp.Errors.InterfaceAccessorWithBodyError error) { }
        public CopyInterfaceAccessorBodyFix(JetBrains.ReSharper.Daemon.CSharp.Errors.AbstractAccessorWithBodyError error) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
        protected override void PostExecute() { }
        protected override void SetBody(JetBrains.ReSharper.Psi.Tree.ITypeMemberDeclaration member) { }
    }
    public abstract class CopyInterfaceMemberFixBase : JetBrains.ReSharper.Intentions.Implementor.ImplementMemberBase, JetBrains.ReSharper.Intentions.Extensibility.IQuickFix
    {
        protected CopyInterfaceMemberFixBase(JetBrains.ReSharper.Psi.CSharp.Tree.IClassMemberDeclaration declaration) { }
        protected JetBrains.ReSharper.Psi.CSharp.Tree.IClassMemberDeclaration Declaration { get; }
        public override string Text { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        protected override string GetGeneratorKind() { }
        protected override JetBrains.ReSharper.Psi.IOverridableMember GetMemberToImplement() { }
        protected override System.Collections.Generic.List<JetBrains.ReSharper.Psi.ITypeElement> GetTargetTypes(JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
        protected override string SelectPartText() { }
    }
    public class CopyInterfaceMethodBodyFix : JetBrains.ReSharper.Intentions.CSharp.QuickFixes.CopyInterfaceMemberFixBase
    {
        public CopyInterfaceMethodBodyFix(JetBrains.ReSharper.Daemon.CSharp.Errors.InterfaceMethodWithBodyError error) { }
        public CopyInterfaceMethodBodyFix(JetBrains.ReSharper.Daemon.CSharp.Errors.AbstractMethodWithBodyError error) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
        protected override void SetBody(JetBrains.ReSharper.Psi.Tree.ITypeMemberDeclaration member) { }
    }
    public class CopyLocalFix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public CopyLocalFix(JetBrains.ReSharper.Psi.CSharp.Tree.IReferenceExpression expression) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class CopyObsoleteFromBaseFix : JetBrains.ReSharper.Intentions.QuickFixBase_Obsolete
    {
        public CopyObsoleteFromBaseFix(JetBrains.ReSharper.Daemon.CSharp.Errors.OverrideObsoleteMemberWithoutObsoleteAttributeWarning error) { }
        protected override bool IsValid { get; }
        public override string Text { get; }
        protected override void ExecuteTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        protected override bool IsAvailableEx() { }
    }
    public class CopyToLocalVar2Fix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public CopyToLocalVar2Fix(JetBrains.ReSharper.Daemon.CSharp.Errors.CannotUseThisInAnonymousMethodInStructError error) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class CopyToLocalVarFix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public CopyToLocalVarFix(JetBrains.ReSharper.Daemon.CSharp.Errors.AccessToRefOutParameterFromAnonymousMethodError error) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class CorrectStaticAccessFix : JetBrains.ReSharper.Intentions.QuickFixBase_Obsolete
    {
        public CorrectStaticAccessFix(JetBrains.ReSharper.Daemon.CSharp.Errors.StaticElementInNonStaticContextError error) { }
        protected override bool IsValid { get; }
        public override string Text { get; }
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        protected override void ExecuteTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        protected override bool IsAvailableEx() { }
    }
    public class CreateAbstractMethodForDelegateAction : JetBrains.ReSharper.Intentions.CSharp.QuickFixes.CreateMethodForDelegateAction
    {
        public CreateAbstractMethodForDelegateAction(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        protected override JetBrains.ReSharper.Feature.Services.Intentions.CreateDeclaration.CreateMethodDeclarationContext CreateContext() { }
        protected override JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.ICreationTarget GetTarget() { }
        protected override string GetTextFormat() { }
    }
    public class CreateAbstractMethodFromUsageAction : JetBrains.ReSharper.Intentions.CSharp.QuickFixes.CreateMethodFromUsageAction
    {
        public CreateAbstractMethodFromUsageAction(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        protected override JetBrains.ReSharper.Feature.Services.Intentions.CreateDeclaration.CreateMethodDeclarationContext CreateContext() { }
        protected override JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.ICreationTarget GetTarget() { }
        protected override string GetTextFormat() { }
    }
    public class CreateAttributePropertyAction : JetBrains.ReSharper.Intentions.CreateFromUsage.CreateFromUsageActionBase2<JetBrains.ReSharper.Feature.Services.Intentions.CreateDeclaration.CreatePropertyDeclarationContext, JetBrains.ReSharper.Psi.Resolve.IReference>
    {
        public CreateAttributePropertyAction(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public virtual char Accelerator { get; }
        public override string Text { get; }
        protected override JetBrains.ReSharper.Feature.Services.Intentions.CreateDeclaration.CreatePropertyDeclarationContext CreateContext() { }
        protected override JetBrains.ReSharper.Feature.Services.Intentions.IntentionResult ExecuteIntention(JetBrains.ReSharper.Feature.Services.Intentions.CreateDeclaration.CreatePropertyDeclarationContext context) { }
        public override JetBrains.ReSharper.Intentions.CreateFromUsage.ICreatedElementConsistencyGroup GetConsistencyGroup() { }
        public virtual int GetPriority() { }
        protected override JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.ICreationTarget GetTarget() { }
        protected override bool IsAvailableInternal() { }
    }
    public class CreateBaseMemberFix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public CreateBaseMemberFix(JetBrains.ReSharper.Daemon.CSharp.Errors.NoSuitableMemberForOverrideError error) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public abstract class CreateClassFromNewBase : JetBrains.ReSharper.Intentions.CreateFromUsage.CreateFromUsageActionBase2<JetBrains.ReSharper.Feature.Services.Intentions.CreateDeclaration.CreateClassDeclarationContext, JetBrains.ReSharper.Psi.Resolve.IReference>
    {
        protected CreateClassFromNewBase(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public virtual char Accelerator { get; }
        protected JetBrains.ReSharper.Psi.CSharp.Tree.IReferenceName ReferenceName { get; }
        public override string Text { get; }
        protected override JetBrains.ReSharper.Feature.Services.Intentions.CreateDeclaration.CreateClassDeclarationContext CreateContext() { }
        protected override JetBrains.ReSharper.Feature.Services.Intentions.IntentionResult ExecuteIntention(JetBrains.ReSharper.Feature.Services.Intentions.CreateDeclaration.CreateClassDeclarationContext context) { }
        public override JetBrains.ReSharper.Intentions.CreateFromUsage.ICreatedElementConsistencyGroup GetConsistencyGroup() { }
        protected abstract string GetItemText();
        protected abstract JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpTreeNode GetScope();
        protected override bool IsAvailableInternal() { }
        protected abstract bool IsQualifierRedundant(JetBrains.ReSharper.Psi.IDeclaredElement element);
    }
    public class CreateClassFromNewItem : JetBrains.ReSharper.Intentions.CSharp.QuickFixes.CreateClassFromNewBase
    {
        public CreateClassFromNewItem(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        protected override string GetItemText() { }
        public virtual int GetPriority() { }
        protected override JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpTreeNode GetScope() { }
        protected override JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.ICreationTarget GetTarget() { }
        protected override bool IsAvailableInternal() { }
        protected override bool IsQualifierRedundant(JetBrains.ReSharper.Psi.IDeclaredElement element) { }
    }
    public class CreateClassFromQualifierAction : JetBrains.ReSharper.Intentions.CSharp.QuickFixes.CreateClassFromQualifierActionBase
    {
        public CreateClassFromQualifierAction(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        protected override string GetItemText() { }
        protected override JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.ICreationTarget GetTarget() { }
        protected override bool IsAvailableInternal() { }
    }
    public abstract class CreateClassFromQualifierActionBase : JetBrains.ReSharper.Intentions.CreateFromUsage.CreateFromUsageActionBase2<JetBrains.ReSharper.Feature.Services.Intentions.CreateDeclaration.CreateClassDeclarationContext, JetBrains.ReSharper.Psi.Resolve.IReference>
    {
        protected CreateClassFromQualifierActionBase(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        protected JetBrains.ReSharper.Psi.CSharp.Tree.IReferenceExpression ReferenceExpression { get; }
        public override string Text { get; }
        protected override JetBrains.ReSharper.Feature.Services.Intentions.CreateDeclaration.CreateClassDeclarationContext CreateContext() { }
        protected override JetBrains.ReSharper.Feature.Services.Intentions.IntentionResult ExecuteIntention(JetBrains.ReSharper.Feature.Services.Intentions.CreateDeclaration.CreateClassDeclarationContext context) { }
        public override JetBrains.ReSharper.Intentions.CreateFromUsage.ICreatedElementConsistencyGroup GetConsistencyGroup() { }
        protected abstract string GetItemText();
        protected override bool IsAvailableInternal() { }
    }
    public class CreateConstructorFromUsageAction : JetBrains.ReSharper.Intentions.CreateFromUsage.CreateFromUsageActionBase2<JetBrains.ReSharper.Feature.Services.Intentions.CreateDeclaration.CreateConstructorDeclarationContext, JetBrains.ReSharper.Psi.Resolve.IReference>
    {
        public CreateConstructorFromUsageAction(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public virtual char Accelerator { get; }
        public override string Text { get; }
        protected override JetBrains.ReSharper.Feature.Services.Intentions.CreateDeclaration.CreateConstructorDeclarationContext CreateContext() { }
        protected override JetBrains.ReSharper.Feature.Services.Intentions.IntentionResult ExecuteIntention(JetBrains.ReSharper.Feature.Services.Intentions.CreateDeclaration.CreateConstructorDeclarationContext context) { }
        public override JetBrains.ReSharper.Intentions.CreateFromUsage.ICreatedElementConsistencyGroup GetConsistencyGroup() { }
        public virtual int GetPriority() { }
        protected override JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.ICreationTarget GetTarget() { }
        protected override bool IsAvailableInternal() { }
    }
    public class CreateDefaultConstructorFix : JetBrains.ReSharper.Intentions.QuickFixes.CreateDefaultConstructorFixBase, JetBrains.ReSharper.Intentions.Extensibility.IQuickFix
    {
        public CreateDefaultConstructorFix(JetBrains.ReSharper.Daemon.CSharp.Errors.ConstructorInitializerMissingError error) { }
        public CreateDefaultConstructorFix(JetBrains.ReSharper.Daemon.CSharp.Errors.NoDefaultConstructorInBaseClassError error) { }
        protected override JetBrains.ReSharper.Psi.AccessRights AccessRights { get; }
        protected override JetBrains.ReSharper.Psi.IClass BaseClass { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class CreateDefaultConstructorForTypeArgumentFix : JetBrains.ReSharper.Intentions.QuickFixes.CreateDefaultConstructorFixBase, JetBrains.ReSharper.Intentions.Extensibility.IQuickFix
    {
        public CreateDefaultConstructorForTypeArgumentFix(JetBrains.ReSharper.Daemon.CSharp.Errors.TypeArgumentHasNoDefaultConstructorError error) { }
        protected override JetBrains.ReSharper.Psi.AccessRights AccessRights { get; }
        protected override JetBrains.ReSharper.Psi.IClass BaseClass { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class CreateDefiningDeclarationFix : JetBrains.ReSharper.Intentions.Extensibility.IQuickFix
    {
        public CreateDefiningDeclarationFix(JetBrains.ReSharper.Daemon.CSharp.Errors.PartialMethodWithoutDefiningDeclarationError error) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        public bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public abstract class CreateDelegateFromUsageBase : JetBrains.ReSharper.Intentions.CreateFromUsage.CreateFromUsageActionBase2<JetBrains.ReSharper.Feature.Services.Intentions.CreateDeclaration.CreateDelegateDeclarationContext, JetBrains.ReSharper.Psi.Resolve.IReference>
    {
        protected CreateDelegateFromUsageBase(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        protected JetBrains.ReSharper.Psi.CSharp.Tree.IReferenceName ReferenceName { get; }
        public override string Text { get; }
        protected override JetBrains.ReSharper.Feature.Services.Intentions.CreateDeclaration.CreateDelegateDeclarationContext CreateContext() { }
        protected override JetBrains.ReSharper.Feature.Services.Intentions.IntentionResult ExecuteIntention(JetBrains.ReSharper.Feature.Services.Intentions.CreateDeclaration.CreateDelegateDeclarationContext context) { }
        public override JetBrains.ReSharper.Intentions.CreateFromUsage.ICreatedElementConsistencyGroup GetConsistencyGroup() { }
        protected abstract bool GetIsNested();
        protected override bool IsAvailableInternal() { }
        public static bool IsDelegate(JetBrains.ReSharper.Psi.CSharp.Tree.IReferenceName reference) { }
    }
    public class CreateDelegateFromUsageItem : JetBrains.ReSharper.Intentions.CSharp.QuickFixes.CreateDelegateFromUsageBase
    {
        public CreateDelegateFromUsageItem(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        protected override bool GetIsNested() { }
        public virtual int GetPriority() { }
        protected override JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.ICreationTarget GetTarget() { }
        protected override bool IsAvailableInternal() { }
    }
    public class CreateEnumMemberFromUsageAction : JetBrains.ReSharper.Intentions.CreateFromUsage.CreateFromUsageActionBase2<JetBrains.ReSharper.Feature.Services.Intentions.CreateDeclaration.CreateEnumMemberDeclarationContext, JetBrains.ReSharper.Psi.Resolve.IReference>
    {
        public CreateEnumMemberFromUsageAction(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public override string Text { get; }
        protected override JetBrains.ReSharper.Feature.Services.Intentions.CreateDeclaration.CreateEnumMemberDeclarationContext CreateContext() { }
        protected override JetBrains.ReSharper.Feature.Services.Intentions.IntentionResult ExecuteIntention(JetBrains.ReSharper.Feature.Services.Intentions.CreateDeclaration.CreateEnumMemberDeclarationContext context) { }
        public override JetBrains.ReSharper.Intentions.CreateFromUsage.ICreatedElementConsistencyGroup GetConsistencyGroup() { }
        protected override JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.ICreationTarget GetTarget() { }
        protected override bool IsAvailableInternal() { }
    }
    public class CreateEventFromUsageAction : JetBrains.ReSharper.Intentions.CreateFromUsage.CreateFromUsageActionBase2<JetBrains.ReSharper.Feature.Services.Intentions.CreateDeclaration.CreateEventDeclarationContext, JetBrains.ReSharper.Psi.Resolve.IReference>
    {
        public CreateEventFromUsageAction(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public virtual char Accelerator { get; }
        public override string Text { get; }
        protected override JetBrains.ReSharper.Feature.Services.Intentions.CreateDeclaration.CreateEventDeclarationContext CreateContext() { }
        protected override JetBrains.ReSharper.Feature.Services.Intentions.IntentionResult ExecuteIntention(JetBrains.ReSharper.Feature.Services.Intentions.CreateDeclaration.CreateEventDeclarationContext context) { }
        public override JetBrains.ReSharper.Intentions.CreateFromUsage.ICreatedElementConsistencyGroup GetConsistencyGroup() { }
        public virtual int GetPriority() { }
        protected override JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.ICreationTarget GetTarget() { }
        protected override bool IsAvailableInternal() { }
    }
    public class CreateFieldFromObjectCreationAction : JetBrains.ReSharper.Intentions.CreateFromUsage.CreateFromUsageActionBase2<JetBrains.ReSharper.Feature.Services.Intentions.CreateDeclaration.CreateFieldDeclarationContext, JetBrains.ReSharper.Psi.Resolve.IReference>
    {
        public CreateFieldFromObjectCreationAction(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public override string Text { get; }
        protected override JetBrains.ReSharper.Feature.Services.Intentions.CreateDeclaration.CreateFieldDeclarationContext CreateContext() { }
        protected override JetBrains.ReSharper.Feature.Services.Intentions.IntentionResult ExecuteIntention(JetBrains.ReSharper.Feature.Services.Intentions.CreateDeclaration.CreateFieldDeclarationContext context) { }
        public override JetBrains.ReSharper.Intentions.CreateFromUsage.ICreatedElementConsistencyGroup GetConsistencyGroup() { }
        protected override JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.ICreationTarget GetTarget() { }
        protected override bool IsAvailableInternal() { }
    }
    public class CreateFieldFromUsageAction : JetBrains.ReSharper.Intentions.CreateFromUsage.CreateFromUsageActionBase2<JetBrains.ReSharper.Feature.Services.Intentions.CreateDeclaration.CreateFieldDeclarationContext, JetBrains.ReSharper.Psi.Resolve.IReference>
    {
        public CreateFieldFromUsageAction(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public override string Text { get; }
        protected override JetBrains.ReSharper.Feature.Services.Intentions.CreateDeclaration.CreateFieldDeclarationContext CreateContext() { }
        protected override JetBrains.ReSharper.Feature.Services.Intentions.IntentionResult ExecuteIntention(JetBrains.ReSharper.Feature.Services.Intentions.CreateDeclaration.CreateFieldDeclarationContext context) { }
        public override JetBrains.ReSharper.Intentions.CreateFromUsage.ICreatedElementConsistencyGroup GetConsistencyGroup() { }
        protected override JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.ICreationTarget GetTarget() { }
        protected override bool IsAvailableInternal() { }
    }
    public class CreateFromUsageFix : JetBrains.ReSharper.Intentions.CreateFromUsage.CreateFromUsageFixBase
    {
        public CreateFromUsageFix(JetBrains.ReSharper.Daemon.CSharp.Errors.NotResolvedError error) { }
        public CreateFromUsageFix(JetBrains.ReSharper.Daemon.CSharp.Errors.AccessRightsError error) { }
        public CreateFromUsageFix(JetBrains.ReSharper.Daemon.CSharp.Errors.NotResolvedCollectionInitializerError error) { }
        public CreateFromUsageFix(JetBrains.ReSharper.Daemon.CSharp.Errors.IncorrectArgumentTypeError error) { }
        public CreateFromUsageFix(JetBrains.ReSharper.Daemon.CSharp.Errors.MultipleResolveCandidatesError error) { }
        public CreateFromUsageFix(JetBrains.ReSharper.Daemon.CSharp.Errors.IncorrectArgumentNumberError error) { }
        public CreateFromUsageFix(JetBrains.ReSharper.Daemon.CSharp.Errors.IncorrectArgumentsError error) { }
        public CreateFromUsageFix(JetBrains.ReSharper.Daemon.CSharp.Errors.IncorrectSignatureInDelegateCreationError error) { }
        public CreateFromUsageFix(JetBrains.ReSharper.Daemon.CSharp.Errors.NamedArgumentListDoesnotMatchParametersError error) { }
        public CreateFromUsageFix(JetBrains.ReSharper.Daemon.CSharp.Errors.NotMethodAsDelegateCreationParameterError error) { }
        public CreateFromUsageFix(JetBrains.ReSharper.Daemon.CSharp.Errors.UnexpectedElementTypeError error) { }
    }
    public class CreateGetSetPropertyFromTypeUsageItem : JetBrains.ReSharper.Intentions.CSharp.QuickFixes.CreatePropertyBase
    {
        public CreateGetSetPropertyFromTypeUsageItem(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public override string Text { get; }
        protected override JetBrains.ReSharper.Feature.Services.Intentions.CreateDeclaration.CreatePropertyDeclarationContext CreateContext() { }
        protected virtual string GetTextFormat() { }
        protected override bool IsAvailableInternal() { }
    }
    public class CreateGetSetPropertyFromUsageItem : JetBrains.ReSharper.Intentions.CSharp.QuickFixes.CreatePropertyBase
    {
        public CreateGetSetPropertyFromUsageItem(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public override string Text { get; }
        protected override JetBrains.ReSharper.Feature.Services.Intentions.CreateDeclaration.CreatePropertyDeclarationContext CreateContext() { }
        protected virtual string GetTextFormat() { }
        protected override bool IsAvailableInternal() { }
    }
    public class CreateIndexerFromUsageFix : JetBrains.ReSharper.Intentions.CreateFromUsage.CreateFromUsageActionBase<JetBrains.ReSharper.Psi.Resolve.IReference>, JetBrains.ReSharper.Intentions.Extensibility.IQuickFix
    {
        public CreateIndexerFromUsageFix(JetBrains.ReSharper.Daemon.CSharp.Errors.IndexerNotResolvedError error) { }
        public CreateIndexerFromUsageFix(JetBrains.ReSharper.Daemon.CSharp.Errors.IndexerIncorrectArgumentNumberError error) { }
        protected override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IBulbAction> CreateBulbActions() { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        protected virtual JetBrains.ReSharper.Feature.Services.Intentions.CreateDeclaration.CreatePropertyDeclarationContext GetContext() { }
        protected override JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.ICreationTarget GetTarget() { }
        public bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class CreateLocalVarFromUsageAction : JetBrains.ReSharper.Intentions.Extensibility.BulbActionBase, JetBrains.ReSharper.Intentions.CreateFromUsage.ICreateFromUsageAction, JetBrains.ReSharper.Intentions.Extensibility.IBulbAction
    {
        public CreateLocalVarFromUsageAction(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public JetBrains.ReSharper.Intentions.Extensibility.IBulbAction GetBulbItem() { }
        public JetBrains.ReSharper.Intentions.CreateFromUsage.ICreatedElementConsistencyGroup GetConsistencyGroup() { }
        public static JetBrains.ReSharper.Psi.ExpectedTypes.IExpectedTypeConstraint VariableTypeConstraint(JetBrains.ReSharper.Psi.Tree.ITreeNode scope, JetBrains.ReSharper.Psi.CSharp.Tree.IReferenceExpression referenceExpression, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpExpression> additionalUsages = null) { }
    }
    public class CreateMatchingOperatorFix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public CreateMatchingOperatorFix(JetBrains.ReSharper.Daemon.CSharp.Errors.MatchingOperatorRequiredError error) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class CreateMatchingTrueFalseFix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public CreateMatchingTrueFalseFix(JetBrains.ReSharper.Daemon.CSharp.Errors.ConditionalLogicTrueFalseOperatorMissingError error) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class CreateMethodForDelegateAction : JetBrains.ReSharper.Intentions.CreateFromUsage.CreateFromUsageActionBase2<JetBrains.ReSharper.Feature.Services.Intentions.CreateDeclaration.CreateMethodDeclarationContext, JetBrains.ReSharper.Psi.Resolve.IReference>
    {
        public CreateMethodForDelegateAction(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public override string Text { get; }
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
        protected virtual string GetTextFormat() { }
        public static JetBrains.ReSharper.Intentions.CreateFromUsage.ConsistencyGroupByNaming InferConsistencyGroup(JetBrains.ReSharper.Psi.Resolve.IReference reference, out bool staticIsSuggested, System.Collections.Generic.IList<JetBrains.ReSharper.Psi.AccessRights> possibleAccessRights) { }
        protected override bool IsAvailableInternal() { }
    }
    public class CreateNestedClassFromNewItem : JetBrains.ReSharper.Intentions.CSharp.QuickFixes.CreateClassFromNewBase
    {
        public CreateNestedClassFromNewItem(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        protected override string GetItemText() { }
        public virtual int GetPriority() { }
        protected override JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpTreeNode GetScope() { }
        protected override JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.ICreationTarget GetTarget() { }
        protected override bool IsAvailableInternal() { }
        protected override bool IsQualifierRedundant(JetBrains.ReSharper.Psi.IDeclaredElement element) { }
    }
    public class CreateNestedClassFromQualifierAction : JetBrains.ReSharper.Intentions.CSharp.QuickFixes.CreateClassFromQualifierActionBase
    {
        public CreateNestedClassFromQualifierAction(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        protected override string GetItemText() { }
        protected override JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.ICreationTarget GetTarget() { }
        protected override bool IsAvailableInternal() { }
    }
    public class CreateNestedDelegateFromUsageItem : JetBrains.ReSharper.Intentions.CSharp.QuickFixes.CreateDelegateFromUsageBase
    {
        public CreateNestedDelegateFromUsageItem(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        protected override bool GetIsNested() { }
        public virtual int GetPriority() { }
        protected override JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.ICreationTarget GetTarget() { }
    }
    public class CreateParameterFromUsageAction : JetBrains.ReSharper.Intentions.Extensibility.BulbActionBase, JetBrains.ReSharper.Intentions.CreateFromUsage.ICreateFromUsageAction, JetBrains.ReSharper.Intentions.Extensibility.IBulbAction
    {
        public CreateParameterFromUsageAction(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public JetBrains.ReSharper.Intentions.Extensibility.IBulbAction GetBulbItem() { }
        public JetBrains.ReSharper.Intentions.CreateFromUsage.ICreatedElementConsistencyGroup GetConsistencyGroup() { }
    }
    public abstract class CreatePropertyBase : JetBrains.ReSharper.Intentions.CreateFromUsage.CreateFromUsageActionBase2<JetBrains.ReSharper.Feature.Services.Intentions.CreateDeclaration.CreatePropertyDeclarationContext, JetBrains.ReSharper.Psi.Resolve.IReference>
    {
        protected CreatePropertyBase(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public JetBrains.ReSharper.Psi.CSharp.Tree.IReferenceExpression ReferenceExpression { get; }
        protected bool CheckResolveResult() { }
        protected override JetBrains.ReSharper.Feature.Services.Intentions.IntentionResult ExecuteIntention(JetBrains.ReSharper.Feature.Services.Intentions.CreateDeclaration.CreatePropertyDeclarationContext context) { }
        public override JetBrains.ReSharper.Intentions.CreateFromUsage.ICreatedElementConsistencyGroup GetConsistencyGroup() { }
        protected override JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.ICreationTarget GetTarget() { }
        protected override bool IsAvailableInternal() { }
        protected JetBrains.ReSharper.Feature.Services.Intentions.CreateDeclaration.CreatePropertyDeclarationContext PrepareContext() { }
    }
    public class CreatePropertyFromObjectCreationItem : JetBrains.ReSharper.Intentions.CSharp.QuickFixes.CreatePropertyBase
    {
        public CreatePropertyFromObjectCreationItem(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public override string Text { get; }
        protected override JetBrains.ReSharper.Feature.Services.Intentions.CreateDeclaration.CreatePropertyDeclarationContext CreateContext() { }
        protected static JetBrains.ReSharper.Psi.ITypeElement GetContainerObject(JetBrains.ReSharper.Psi.CSharp.Tree.IInitializerElement memberInitializer) { }
        protected JetBrains.ReSharper.Psi.CSharp.Tree.IMemberInitializer GetMemberInitializer() { }
        protected override bool IsAvailableInternal() { }
    }
    public class CreatePropertyFromTypeUsageItem : JetBrains.ReSharper.Intentions.CSharp.QuickFixes.CreatePropertyBase
    {
        public CreatePropertyFromTypeUsageItem(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public override string Text { get; }
        protected override JetBrains.ReSharper.Feature.Services.Intentions.CreateDeclaration.CreatePropertyDeclarationContext CreateContext() { }
        protected virtual string GetTextFormat() { }
        protected override bool IsAvailableInternal() { }
    }
    public class CreatePropertyFromUsageItem : JetBrains.ReSharper.Intentions.CSharp.QuickFixes.CreatePropertyBase
    {
        public CreatePropertyFromUsageItem(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public override string Text { get; }
        protected override JetBrains.ReSharper.Feature.Services.Intentions.CreateDeclaration.CreatePropertyDeclarationContext CreateContext() { }
        protected virtual string GetTextFormat() { }
        protected override bool IsAvailableInternal() { }
    }
    public class CreateStaticClassAction : JetBrains.ReSharper.Intentions.CreateFromUsage.CreateFromUsageActionBase2<JetBrains.ReSharper.Feature.Services.Intentions.CreateDeclaration.CreateClassDeclarationContext, JetBrains.ReSharper.Psi.Resolve.IReference>
    {
        public CreateStaticClassAction(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public virtual char Accelerator { get; }
        public override string Text { get; }
        protected override JetBrains.ReSharper.Feature.Services.Intentions.CreateDeclaration.CreateClassDeclarationContext CreateContext() { }
        protected override JetBrains.ReSharper.Feature.Services.Intentions.IntentionResult ExecuteIntention(JetBrains.ReSharper.Feature.Services.Intentions.CreateDeclaration.CreateClassDeclarationContext context) { }
        public override JetBrains.ReSharper.Intentions.CreateFromUsage.ICreatedElementConsistencyGroup GetConsistencyGroup() { }
        public virtual int GetPriority() { }
        protected override JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.ICreationTarget GetTarget() { }
        protected override bool IsAvailableInternal() { }
    }
    public class CreateTypeParamFromUsage2Item : JetBrains.ReSharper.Intentions.Extensibility.BulbActionBase
    {
        public CreateTypeParamFromUsage2Item(JetBrains.ReSharper.Psi.ITypeParametersOwner target, string name) { }
        public override string Text { get; }
        protected override void ExecuteBeforeProgressAndTransaction(JetBrains.ProjectModel.ISolution solution) { }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
    }
    public class CreateTypeParamFromUsageAction : JetBrains.ReSharper.Intentions.Extensibility.BulbActionBase, JetBrains.ReSharper.Intentions.CreateFromUsage.ICreateFromUsageAction, JetBrains.ReSharper.Intentions.Extensibility.IBulbAction
    {
        public CreateTypeParamFromUsageAction(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public JetBrains.ReSharper.Intentions.Extensibility.IBulbAction GetBulbItem() { }
        public JetBrains.ReSharper.Intentions.CreateFromUsage.ICreatedElementConsistencyGroup GetConsistencyGroup() { }
        public int GetPriority() { }
    }
    public class CreateTypeParamFromUsageFix2 : JetBrains.ReSharper.Intentions.Extensibility.IQuickFix
    {
        public CreateTypeParamFromUsageFix2(JetBrains.ReSharper.Daemon.CSharp.Errors.NotResolvedError error) { }
        public JetBrains.ReSharper.Intentions.Extensibility.IBulbAction[] Items { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        public bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public abstract class CSharpAddAccessorFixBase : JetBrains.ReSharper.Intentions.QuickFixes.AddAccessorFixBase
    {
        protected CSharpAddAccessorFixBase(JetBrains.ReSharper.Psi.IProperty property, JetBrains.ReSharper.Intentions.QuickFixes.AddAccessorFixBase.AccessorPrefix accessorPrefix) { }
        protected CSharpAddAccessorFixBase(JetBrains.ReSharper.Psi.IProperty property) { }
        public override string Text { get; }
        protected static JetBrains.ReSharper.Psi.IProperty GetByAccessor(JetBrains.ReSharper.Psi.CSharp.Tree.IAccessorDeclaration accessorDeclaration) { }
    }
    public class CSharpExtensionMethodsResolveUtil : JetBrains.ReSharper.Intentions.Util.ExtensionMethodImportUtilBase<JetBrains.ReSharper.Psi.CSharp.ICSharpInvocationInfo>
    {
        public static System.Collections.Generic.IList<JetBrains.ReSharper.Psi.IMethod> GetAlternatives(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.Resolve.ResolveErrorType[] acceptedResolveErrors) { }
        protected override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IMethod> GetCandidateMethods(JetBrains.ReSharper.Psi.CSharp.ICSharpInvocationInfo invocationInfo) { }
        protected override InvocationCandidate[] GetInvocationInfo(ref JetBrains.ReSharper.Psi.Resolve.ResolveErrorType acceptedResolveErrors) { }
        protected override string Present(JetBrains.ReSharper.Psi.IDeclaredElement method) { }
        protected override JetBrains.ReSharper.Psi.Resolve.ResolveErrorType ResolveOverloadsForExtensionMethods(JetBrains.ReSharper.Intentions.Util.ExtensionMethodImportUtilBase<JetBrains.ReSharper.Psi.CSharp.ICSharpInvocationInfo>.InvocationCandidate candidate, JetBrains.ReSharper.Psi.IMethod method) { }
    }
    public class static CSharpImportTypeUtil
    {
        public static JetBrains.ReSharper.Psi.Resolve.IReference GetReferenceByUsage(JetBrains.ReSharper.Psi.CSharp.Tree.IDeclaredTypeUsage typeUsage) { }
        public static JetBrains.ReSharper.Psi.Resolve.IReference GetReferenceByUsage(JetBrains.ReSharper.Psi.CSharp.Tree.ITypeUsage typeUsage) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.CSharp.CSharpLanguage))]
    public class CSharpImportTypeUtilComponent : JetBrains.ReSharper.Intentions.QuickFixes.IImportTypeUtilComponent
    {
        public System.Collections.Generic.IList<JetBrains.ReSharper.Psi.ITypeElement> Alternatives(JetBrains.ReSharper.Psi.Resolve.IReference reference, System.Func<JetBrains.ReSharper.Psi.Tree.ITreeNode, System.Func<string, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IClrDeclaredElement>>> getTypesCacheFunc) { }
        public JetBrains.ReSharper.Psi.IReferencePointer CreateReferencePointer(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public bool ReferenceTargetCanBeType(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
    }
    public class CSharpMakeInternalFix : JetBrains.ReSharper.Intentions.QuickFixes.MakeInternalFix
    {
        public CSharpMakeInternalFix(JetBrains.ReSharper.Daemon.CSharp.Errors.AccessRightsError error) { }
        public CSharpMakeInternalFix(JetBrains.ReSharper.Daemon.CSharp.Errors.NotWritablePropertyInMemberInitializerError error) { }
        public CSharpMakeInternalFix(JetBrains.ReSharper.Daemon.CSharp.Errors.NotReadablePropertyInMemberInitializerError error) { }
        public CSharpMakeInternalFix(JetBrains.ReSharper.Daemon.CSharp.Errors.InaccessibleAccessorError error) { }
        public CSharpMakeInternalFix(JetBrains.ReSharper.Daemon.CSharp.Errors.VirtualMemberCannotBePrivateError error) { }
        public CSharpMakeInternalFix(JetBrains.ReSharper.Daemon.CSharp.Errors.PrivateMemberCannotBePolymorhicError error) { }
        public CSharpMakeInternalFix(JetBrains.ReSharper.Daemon.CSharp.Errors.AbstractMemberCannotBePrivateError error) { }
        public CSharpMakeInternalFix(JetBrains.ReSharper.Daemon.CSharp.Errors.InaccessibleDefaultConstructorInBaseClassError error) { }
        public CSharpMakeInternalFix(JetBrains.ReSharper.Daemon.CSharp.Errors.NewProtectedMemberInStructError error) { }
        public CSharpMakeInternalFix(JetBrains.ReSharper.Daemon.CSharp.Errors.NewProtectedMemberInSealedClassWarning error) { }
        public CSharpMakeInternalFix(JetBrains.ReSharper.Daemon.CSharp.Errors.StaticClassMemberCannotBeProtectedError error) { }
    }
    public class CSharpMakeNonStaticFix : JetBrains.ReSharper.Intentions.QuickFixes.MakeNonStaticFix
    {
        public CSharpMakeNonStaticFix(JetBrains.ReSharper.Daemon.CSharp.Errors.AccessModifierInStaticConstructorError error) { }
        public CSharpMakeNonStaticFix(JetBrains.ReSharper.Daemon.CSharp.Errors.IndexerCannotBeStaticError error) { }
        public CSharpMakeNonStaticFix(JetBrains.ReSharper.Daemon.CSharp.Errors.CannotUseThisBaseInStaticContextError error) { }
        public CSharpMakeNonStaticFix(JetBrains.ReSharper.Daemon.CSharp.Errors.InitializerInStaticConstructorError error) { }
        public CSharpMakeNonStaticFix(JetBrains.ReSharper.Daemon.CSharp.Errors.StaticElementInNonStaticContextError error) { }
        public CSharpMakeNonStaticFix(JetBrains.ReSharper.Daemon.CSharp.Errors.NotImplementStaticError error) { }
        public CSharpMakeNonStaticFix(JetBrains.ReSharper.Daemon.CSharp.Errors.PolymorphicMemberCannotBeStaticError error) { }
        public CSharpMakeNonStaticFix(JetBrains.ReSharper.Daemon.CSharp.Errors.ParametersInStaticConstructorError error) { }
        public CSharpMakeNonStaticFix(JetBrains.ReSharper.Daemon.CSharp.Errors.StaticFieldOrPropertyInMemberInitializerError error) { }
        protected CSharpMakeNonStaticFix(JetBrains.ReSharper.Psi.IDeclaredElement element) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class CSharpMakeProtectedFix : JetBrains.ReSharper.Intentions.QuickFixes.MakeProtectedFix
    {
        public CSharpMakeProtectedFix(JetBrains.ReSharper.Daemon.CSharp.Errors.AccessRightsError error) { }
        public CSharpMakeProtectedFix(JetBrains.ReSharper.Daemon.CSharp.Errors.NotWritablePropertyInMemberInitializerError error) { }
        public CSharpMakeProtectedFix(JetBrains.ReSharper.Daemon.CSharp.Errors.NotReadablePropertyInMemberInitializerError error) { }
        public CSharpMakeProtectedFix(JetBrains.ReSharper.Daemon.CSharp.Errors.InaccessibleAccessorError error) { }
        public CSharpMakeProtectedFix(JetBrains.ReSharper.Daemon.CSharp.Errors.PublicConstructorInAbstractClassWarning error) { }
        public CSharpMakeProtectedFix(JetBrains.ReSharper.Daemon.CSharp.Errors.PrivateMemberCannotBePolymorhicError error) { }
        public CSharpMakeProtectedFix(JetBrains.ReSharper.Daemon.CSharp.Errors.VirtualMemberCannotBePrivateError error) { }
        public CSharpMakeProtectedFix(JetBrains.ReSharper.Daemon.CSharp.Errors.AbstractMemberCannotBePrivateError error) { }
        public CSharpMakeProtectedFix(JetBrains.ReSharper.Daemon.CSharp.Errors.InaccessibleDefaultConstructorInBaseClassError error) { }
    }
    public class CSharpMakePublicFix : JetBrains.ReSharper.Intentions.QuickFixes.MakePublicFix
    {
        public CSharpMakePublicFix(JetBrains.ReSharper.Daemon.CSharp.Errors.NotReadablePropertyInMemberInitializerError error) { }
        public CSharpMakePublicFix(JetBrains.ReSharper.Daemon.CSharp.Errors.InaccessibleAccessorError error) { }
        public CSharpMakePublicFix(JetBrains.ReSharper.Daemon.CSharp.Errors.VirtualMemberCannotBePrivateError error) { }
        public CSharpMakePublicFix(JetBrains.ReSharper.Daemon.CSharp.Errors.PrivateMemberCannotBePolymorhicError error) { }
        public CSharpMakePublicFix(JetBrains.ReSharper.Daemon.CSharp.Errors.AbstractMemberCannotBePrivateError error) { }
        public CSharpMakePublicFix(JetBrains.ReSharper.Daemon.CSharp.Errors.NewProtectedMemberInStructError error) { }
        public CSharpMakePublicFix(JetBrains.ReSharper.Daemon.CSharp.Errors.NewProtectedMemberInSealedClassWarning error) { }
        public CSharpMakePublicFix(JetBrains.ReSharper.Daemon.CSharp.Errors.StaticClassMemberCannotBeProtectedError error) { }
        public CSharpMakePublicFix(JetBrains.ReSharper.Daemon.CSharp.Errors.NotImplementNotPublicError error) { }
    }
    public class CSharpMakeReadonlyFix : JetBrains.ReSharper.Intentions.QuickFixes.UsageChecking.MakeReadonlyFix
    {
        public CSharpMakeReadonlyFix(JetBrains.ReSharper.Daemon.CSharp.Errors.NonReadonlyFieldInGetHashCodeWarning warning) { }
    }
    public class static CSharpQuickFixUtil
    {
        public const int NOT_ACTION = -1;
        public static string Escape(string name) { }
        public static JetBrains.ReSharper.Psi.IOverridableMember FindBaseOverridableMember(JetBrains.ReSharper.Psi.ITypeElement typeElement, System.Predicate<JetBrains.ReSharper.Psi.IOverridableMember> test) { }
        public static JetBrains.ReSharper.Psi.Resolve.IReference GetReferenceByLValue(JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpExpression lvalue) { }
        public static JetBrains.ReSharper.Psi.Resolve.IReference GetReferenceByRValue(JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpExpression rvalue) { }
        public static JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpExpression InitializerToExpression(JetBrains.ReSharper.Psi.CSharp.Tree.IVariableInitializer initializer) { }
        public static void ReplaceDeclarationWithAssignment(JetBrains.ReSharper.Psi.CSharp.Tree.ILocalVariableDeclaration declaration, JetBrains.ReSharper.Psi.CSharp.CSharpElementFactory factory, JetBrains.ReSharper.Psi.IDeclaredElement newVariable) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.CSharp.CSharpLanguage))]
    public class CSharpQuickFixUtilComponent : JetBrains.ReSharper.Intentions.QuickFixes.IQuickFixUtilComponent
    {
        public JetBrains.ReSharper.Psi.Resolve.IReference BindTo(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.ITypeElement typeElement, out System.Action<> moveCaretToTypeArgumentsAction, bool targetHasGenericOverloads) { }
    }
    public class EnumerateToArrayFix : JetBrains.ReSharper.Intentions.CSharp.QuickFixes.MultipleEnumerationFixBase
    {
        public EnumerateToArrayFix(JetBrains.ReSharper.Daemon.CSharp.Errors.PossibleMultipleEnumerationWarning warning) { }
        public override string Text { get; }
        protected override void EnumerateGenericIEnumerable(JetBrains.ReSharper.Psi.IType enumerableType, JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpExpression valueExpression) { }
        protected override void EnumerateIEnumerable(JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpExpression valueExpression) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class EnumerateToListFix : JetBrains.ReSharper.Intentions.CSharp.QuickFixes.MultipleEnumerationFixBase
    {
        public EnumerateToListFix(JetBrains.ReSharper.Daemon.CSharp.Errors.PossibleMultipleEnumerationWarning warning) { }
        public override string Text { get; }
        protected override void EnumerateGenericIEnumerable(JetBrains.ReSharper.Psi.IType enumerableType, JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpExpression valueExpression) { }
        protected override void EnumerateIEnumerable(JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpExpression valueExpression) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class EnumerateWithAsArrayMethodFix : JetBrains.ReSharper.Intentions.CSharp.QuickFixes.MultipleEnumerationFixBase
    {
        public EnumerateWithAsArrayMethodFix(JetBrains.ReSharper.Daemon.CSharp.Errors.PossibleMultipleEnumerationWarning warning) { }
        public override string Text { get; }
        protected override void EnumerateGenericIEnumerable(JetBrains.ReSharper.Psi.IType enumerableType, JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpExpression valueExpression) { }
        protected override void EnumerateIEnumerable(JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpExpression valueExpression) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class EnumerateWithAsListMethodFix : JetBrains.ReSharper.Intentions.CSharp.QuickFixes.MultipleEnumerationFixBase
    {
        public EnumerateWithAsListMethodFix(JetBrains.ReSharper.Daemon.CSharp.Errors.PossibleMultipleEnumerationWarning warning) { }
        public override string Text { get; }
        protected override void EnumerateGenericIEnumerable(JetBrains.ReSharper.Psi.IType enumerableType, JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpExpression valueExpression) { }
        protected override void EnumerateIEnumerable(JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpExpression valueExpression) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class FixAccessorRightsFix : JetBrains.ReSharper.Intentions.Extensibility.IQuickFix
    {
        public FixAccessorRightsFix(JetBrains.ReSharper.Daemon.CSharp.Errors.AccessorAccessRightsShouldBeMoreRestrictiveError error) { }
        public FixAccessorRightsFix(JetBrains.ReSharper.Daemon.CSharp.Errors.AbstractPrivateAccessorError error) { }
        public JetBrains.ReSharper.Intentions.Extensibility.IBulbAction[] Items { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        public bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class FixAnonymousSignatureFix : JetBrains.ReSharper.Intentions.QuickFixBase_Obsolete
    {
        public FixAnonymousSignatureFix(JetBrains.ReSharper.Daemon.CSharp.Errors.IncorrectAnonymousMethodSignatureError error) { }
        public FixAnonymousSignatureFix(JetBrains.ReSharper.Daemon.CSharp.Errors.IncorrectArgumentTypeError error) { }
        public FixAnonymousSignatureFix(JetBrains.ReSharper.Daemon.CSharp.Errors.CannotApplyBinaryOperatorMultipleCandidatesError error) { }
        public FixAnonymousSignatureFix(JetBrains.ReSharper.Daemon.CSharp.Errors.CannotApplyBinaryOperatorError error) { }
        protected override bool IsValid { get; }
        public override string Text { get; }
        public static JetBrains.ReSharper.Psi.CSharp.Tree.IAnonymousMethodParameterDeclaration CreateParameterDeclaration(JetBrains.ReSharper.Psi.CSharp.CSharpElementFactory factory, bool isParamArray, JetBrains.ReSharper.Psi.ParameterKind kind, string paramName, JetBrains.ReSharper.Psi.IType type) { }
        protected override void ExecuteTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        protected override bool IsAvailableEx() { }
    }
    public class FixAnonymousType2Fix : JetBrains.ReSharper.Intentions.Extensibility.IQuickFix
    {
        public FixAnonymousType2Fix(JetBrains.ReSharper.Daemon.CSharp.Errors.InvalidTypeInAnonymousTypePropertyError error) { }
        public JetBrains.ReSharper.Intentions.Extensibility.IBulbAction[] Items { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        public static System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.CSharp.Tree.IAnonymousObjectCreationExpression> FindSimilar(JetBrains.ReSharper.Psi.CSharp.Tree.IAnonymousObjectCreationExpression creation, System.Predicate<JetBrains.ReSharper.Psi.CSharp.Tree.IAnonymousObjectCreationExpression> areSimilar) { }
        public bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class FixAnonymousTypeFix : JetBrains.ReSharper.Intentions.Extensibility.IQuickFix
    {
        public FixAnonymousTypeFix(JetBrains.ReSharper.Daemon.CSharp.Errors.SimilarAnonymousTypeNearbyWarning error) { }
        public JetBrains.ReSharper.Intentions.Extensibility.IBulbAction[] Items { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        public bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class FixArgumentTextFix : JetBrains.ReSharper.Intentions.CSharp.QuickFixes.ChangeTextFixBase
    {
        public FixArgumentTextFix(JetBrains.ReSharper.Daemon.CSharp.Errors.NotResolvedInTextWarning error) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class FixAsyncMethodReturnTypeFix : JetBrains.ReSharper.Intentions.CSharp.QuickFixes.FixAsyncReturnTypeFixBase
    {
        public FixAsyncMethodReturnTypeFix(JetBrains.ReSharper.Psi.CSharp.Tree.IMethodDeclaration methodDeclaration) { }
        protected override JetBrains.ReSharper.Psi.Tree.IParametersOwnerDeclaration Declaration { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
    }
    public class FixAsyncMethodReturnTypeFix2 : JetBrains.ReSharper.Intentions.CSharp.QuickFixes.FixAsyncReturnTypeFixBase
    {
        public FixAsyncMethodReturnTypeFix2(JetBrains.ReSharper.Psi.CSharp.Tree.IMethodDeclaration methodDeclaration) { }
        protected override JetBrains.ReSharper.Psi.Tree.IParametersOwnerDeclaration Declaration { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        protected override JetBrains.ReSharper.Psi.IType GetAsyncElementReturnType() { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public abstract class FixAsyncReturnTypeFixBase : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        protected abstract JetBrains.ReSharper.Psi.Tree.IParametersOwnerDeclaration Declaration { get; }
        public override string Text { get; }
        protected virtual JetBrains.ReSharper.Psi.IType GetAsyncElementReturnType() { }
        protected JetBrains.ReSharper.Psi.IType GetAsyncReturnType() { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class FixBaseOverridableFix : JetBrains.ReSharper.Intentions.QuickFixBase_Obsolete
    {
        public FixBaseOverridableFix(JetBrains.ReSharper.Daemon.CSharp.Errors.NoSuitableMemberForOverrideError error) { }
        public FixBaseOverridableFix(JetBrains.ReSharper.Daemon.CSharp.Errors.NotImplementAnotherReturnTypeError error) { }
        public FixBaseOverridableFix(JetBrains.ReSharper.Daemon.CSharp.Errors.PropertyNotImplementAnotherReturnTypeError error) { }
        public FixBaseOverridableFix(JetBrains.ReSharper.Daemon.CSharp.Errors.CannotChangeReturnTypeInOverrideError error) { }
        protected override bool IsValid { get; }
        public override string Text { get; }
        protected override void ExecutePostTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        protected override void ExecuteTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        protected override bool IsAvailableEx() { }
    }
    public class FixBaseOverridableRightsFix : JetBrains.ReSharper.Intentions.CSharp.QuickFixes.FixOverridableRightsBase
    {
        public FixBaseOverridableRightsFix(JetBrains.ReSharper.Daemon.CSharp.Errors.OverrideMemberChangeAccessRightsError error) { }
        protected override JetBrains.ReSharper.Psi.IOverridableMember FindMemberToChange() { }
        protected override JetBrains.ReSharper.Psi.AccessRights GetCorrectAccessRights() { }
    }
    public class FixComponentNameFix : JetBrains.ReSharper.Intentions.CSharp.QuickFixes.ChangeTextFixBase
    {
        public FixComponentNameFix(JetBrains.ReSharper.Daemon.CSharp.Errors.NotResolvedInTextWarning error) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class FixConstraintsFix : JetBrains.ReSharper.Intentions.QuickFixBase_Obsolete
    {
        public FixConstraintsFix(JetBrains.ReSharper.Daemon.CSharp.Errors.ImplicitImplementedMethodTypeParameterConstraintMismatchError error) { }
        protected override bool IsValid { get; }
        public override string Text { get; }
        protected override void ExecuteTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        protected override bool IsAvailableEx() { }
    }
    public class FixConstraintsOrderFix : JetBrains.ReSharper.Intentions.QuickFixBase_Obsolete
    {
        public FixConstraintsOrderFix(JetBrains.ReSharper.Daemon.CSharp.Errors.ClassOrStructConstraintMustBeFirstError error) { }
        public FixConstraintsOrderFix(JetBrains.ReSharper.Daemon.CSharp.Errors.ConstructorConstraintShouldBeLastError error) { }
        public FixConstraintsOrderFix(JetBrains.ReSharper.Daemon.CSharp.Errors.ClassTypeConstraintMustBeFirstError error) { }
        protected override bool IsValid { get; }
        public override string Text { get; }
        protected override void ExecuteTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        protected override bool IsAvailableEx() { }
    }
    public class FixDelegateFix : JetBrains.ReSharper.Intentions.CSharp.QuickFixes.FixDelegateFixBase
    {
        protected readonly JetBrains.ReSharper.Psi.CSharp.Tree.IAssignmentExpression myAssignmentExpression;
        public FixDelegateFix(JetBrains.ReSharper.Daemon.CSharp.Errors.CannotApplyBinaryOperatorMultipleCandidatesError error) { }
        public FixDelegateFix(JetBrains.ReSharper.Daemon.CSharp.Errors.CannotApplyBinaryOperatorError error) { }
        public FixDelegateFix(JetBrains.ReSharper.Daemon.CSharp.Errors.IncorrectArgumentTypeError error) { }
        protected FixDelegateFix(JetBrains.ReSharper.Psi.CSharp.Tree.IAssignmentExpression assignmentExpression) { }
        protected override bool IsValid { get; }
        protected override JetBrains.ReSharper.Psi.IDeclaredType GetDeclaredType() { }
        protected override JetBrains.ReSharper.Psi.CSharp.Tree.IObjectCreationExpression GetObjectCreationExpression() { }
    }
    public abstract class FixDelegateFixBase : JetBrains.ReSharper.Intentions.QuickFixBase_Obsolete
    {
        public override string Text { get; }
        protected override void ExecuteTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        protected abstract JetBrains.ReSharper.Psi.IDeclaredType GetDeclaredType();
        protected abstract JetBrains.ReSharper.Psi.CSharp.Tree.IObjectCreationExpression GetObjectCreationExpression();
        protected override bool IsAvailableEx() { }
    }
    public class FixFieldFix : JetBrains.ReSharper.Intentions.QuickFixBase_Obsolete
    {
        public FixFieldFix(JetBrains.ReSharper.Daemon.CSharp.Errors.NotVariableAsAttributeParameterError error) { }
        protected override bool IsValid { get; }
        public override string Text { get; }
        protected override void ExecuteTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        protected override bool IsAvailableEx() { }
    }
    public class FixFloatingPointComparingFix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public FixFloatingPointComparingFix(JetBrains.ReSharper.Daemon.CSharp.Errors.CompareOfFloatsByEqualityOperatorWarning warning) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class FixInterfaceQualifierFix : JetBrains.ReSharper.Intentions.Extensibility.IQuickFix
    {
        public FixInterfaceQualifierFix(JetBrains.ReSharper.Daemon.CSharp.Errors.ExplicitQualifierIsNotInInterfaceListError error) { }
        public FixInterfaceQualifierFix(JetBrains.ReSharper.Daemon.CSharp.Errors.ExplicitQualifierIsNotInterfaceError error) { }
        public FixInterfaceQualifierFix(JetBrains.ReSharper.Daemon.CSharp.Errors.ExplicitImplementationIsNotInterfaceMemberError error) { }
        public JetBrains.ReSharper.Intentions.Extensibility.IBulbAction[] Items { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        public bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class FixIteratorReturnTypeFix : JetBrains.ReSharper.Intentions.QuickFixBase_Obsolete
    {
        public FixIteratorReturnTypeFix(JetBrains.ReSharper.Daemon.CSharp.Errors.IncorrectIteratorReturnTypeError error) { }
        protected override bool IsValid { get; }
        public override string Text { get; }
        protected override void ExecuteTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        protected override bool IsAvailableEx() { }
    }
    [JetBrains.ReSharper.Feature.Services.CodeCleanup.HighlightingModule.HighlightingCleanupItemAttribute(new JetBrains.ReSharper.Daemon.Severity[0])]
    public class FixOperatorModifiersFix : JetBrains.ReSharper.Intentions.CSharp.QuickFixes.RemoveModifiersFixBase
    {
        public FixOperatorModifiersFix(JetBrains.ReSharper.Daemon.CSharp.Errors.OperatorMustBePublicStaticError error) { }
        public FixOperatorModifiersFix(JetBrains.ReSharper.Daemon.CSharp.Errors.InvalidModifierInOperatorError error) { }
        public override string Text { get; }
        protected override void ExecutePsiTransaction() { }
        protected override bool IsAvailableEx() { }
        protected override bool MustRemove(JetBrains.ReSharper.Psi.Parsing.TokenNodeType modifierNodeType) { }
    }
    public class FixOperatorParamTypeFix : JetBrains.ReSharper.Intentions.Extensibility.IQuickFix
    {
        public FixOperatorParamTypeFix(JetBrains.ReSharper.Daemon.CSharp.Errors.AtLeastOneParameterOfSignOperatorMustBeContainingTypeError error) { }
        public FixOperatorParamTypeFix(JetBrains.ReSharper.Daemon.CSharp.Errors.IncorrectUnaryOperatorParameterError error) { }
        public FixOperatorParamTypeFix(JetBrains.ReSharper.Daemon.CSharp.Errors.IncorrectBinaryOperatorParametersError error) { }
        public FixOperatorParamTypeFix(JetBrains.ReSharper.Daemon.CSharp.Errors.UnaryOperatorParameterMustBeContainingTypeError error) { }
        public JetBrains.ReSharper.Intentions.Extensibility.IBulbAction[] Items { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        public bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class FixOperatorTypeFix : JetBrains.ReSharper.Intentions.CSharp.QuickFixes.FixOperatorTypeFixBase
    {
        public FixOperatorTypeFix(JetBrains.ReSharper.Daemon.CSharp.Errors.IncorrectIncrementDecrementOperatorTypeError error) { }
        public FixOperatorTypeFix(JetBrains.ReSharper.Daemon.CSharp.Errors.ReturnTypeOfIncDecOperatorMustBeContainingTypeError error) { }
        protected override bool IsValid { get; }
        protected override JetBrains.ReSharper.Psi.IOperator GetOperator() { }
        protected override JetBrains.ReSharper.Psi.ITypeElement GetTypeElement() { }
    }
    public abstract class FixOperatorTypeFixBase : JetBrains.ReSharper.Intentions.QuickFixBase_Obsolete
    {
        public override string Text { get; }
        protected override void ExecuteTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        protected abstract JetBrains.ReSharper.Psi.IOperator GetOperator();
        protected abstract JetBrains.ReSharper.Psi.ITypeElement GetTypeElement();
        protected override bool IsAvailableEx() { }
    }
    public abstract class FixOverridableRightsBase : JetBrains.ReSharper.Intentions.Extensibility.IQuickFix
    {
        protected readonly JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpModifiersOwnerDeclaration myDeclaration;
        protected FixOverridableRightsBase(JetBrains.ReSharper.Daemon.CSharp.Errors.OverrideMemberChangeAccessRightsError error) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        protected abstract JetBrains.ReSharper.Psi.IOverridableMember FindMemberToChange();
        protected abstract JetBrains.ReSharper.Psi.AccessRights GetCorrectAccessRights();
        public bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class FixOverridableRightsFix : JetBrains.ReSharper.Intentions.CSharp.QuickFixes.FixOverridableRightsBase
    {
        public FixOverridableRightsFix(JetBrains.ReSharper.Daemon.CSharp.Errors.OverrideMemberChangeAccessRightsError error) { }
        protected override JetBrains.ReSharper.Psi.IOverridableMember FindMemberToChange() { }
        protected override JetBrains.ReSharper.Psi.AccessRights GetCorrectAccessRights() { }
    }
    public class FixPropertyFix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public FixPropertyFix(JetBrains.ReSharper.Daemon.CSharp.Errors.NotVariableAsAttributeParameterError error) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class FixPropertyNameFix : JetBrains.ReSharper.Intentions.CSharp.QuickFixes.ChangeTextFixBase
    {
        public FixPropertyNameFix(JetBrains.ReSharper.Daemon.CSharp.Errors.NotResolvedInTextWarning error) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class FixShiftSignatureFix : JetBrains.ReSharper.Intentions.QuickFixBase_Obsolete
    {
        public FixShiftSignatureFix(JetBrains.ReSharper.Daemon.CSharp.Errors.FirstParameterOfShiftOperatorMustBeContainingTypeError error) { }
        public FixShiftSignatureFix(JetBrains.ReSharper.Daemon.CSharp.Errors.SecondParameterOfShiftOperatorMustBeIntError error) { }
        protected override bool IsValid { get; }
        public override string Text { get; }
        protected override void ExecuteTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        protected override bool IsAvailableEx() { }
    }
    public class FixStaticConstFix : JetBrains.ReSharper.Intentions.QuickFixes.MakeNonStaticFix
    {
        public FixStaticConstFix(JetBrains.ReSharper.Daemon.CSharp.Errors.ConstantMarkedAsStaticError error) { }
        public FixStaticConstFix(JetBrains.ReSharper.Daemon.CSharp.Errors.StaticClassMemberCannotBeProtectedError error) { }
        public FixStaticConstFix(JetBrains.ReSharper.Daemon.CSharp.Errors.StaticClassCannotBeSealedError error) { }
        public FixStaticConstFix(JetBrains.ReSharper.Daemon.CSharp.Errors.StaticClassCannotBeAbstractError error) { }
        public FixStaticConstFix(JetBrains.ReSharper.Daemon.CSharp.Errors.ExtendsListInStaticClassError error) { }
        public FixStaticConstFix(JetBrains.ReSharper.Daemon.CSharp.Errors.NonstaticMemberInStaticClassError error) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
        protected override void SetModifiers(JetBrains.ReSharper.Psi.Tree.IModifiersOwnerDeclaration declaration) { }
    }
    [JetBrains.ReSharper.Feature.Services.CodeCleanup.HighlightingModule.HighlightingCleanupItemAttribute(new JetBrains.ReSharper.Daemon.Severity[0])]
    public class FixStaticQualifierFix : JetBrains.ReSharper.Intentions.CSharp.QuickFixes.RedundancyHighlightingCleanupItemQuickFixBase
    {
        public FixStaticQualifierFix(JetBrains.ReSharper.Daemon.CSharp.Errors.AccessToStaticMemberViaDerivedTypeWarning error) { }
        protected override string BulkText { get; }
        public override string Text { get; }
        protected override void ExecutePsiTransaction() { }
        protected override JetBrains.ProjectModel.IProjectFile GetProjectFile() { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder userDataHolder) { }
    }
    public class FixTrueFalseTypeFix : JetBrains.ReSharper.Intentions.QuickFixBase_Obsolete
    {
        public FixTrueFalseTypeFix(JetBrains.ReSharper.Daemon.CSharp.Errors.IncorrectTrueOrFalseOperatorTypeError error) { }
        public FixTrueFalseTypeFix(JetBrains.ReSharper.Daemon.CSharp.Errors.ReturnTypeOfTrueFalseOperatorMustBeBoolError error) { }
        protected override bool IsValid { get; }
        public override string Text { get; }
        protected override void ExecuteTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        protected override bool IsAvailableEx() { }
    }
    public class GenerateArgumentStubsFix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public GenerateArgumentStubsFix(JetBrains.ReSharper.Daemon.CSharp.Errors.IncorrectArgumentNumberError error) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class IfToCoalescing2Fix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public IfToCoalescing2Fix(JetBrains.ReSharper.Daemon.CSharp.Errors.ConvertIfStatementToNullCoalescingExpression2Warning warning) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class IfToCoalescing3Fix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public IfToCoalescing3Fix(JetBrains.ReSharper.Daemon.CSharp.Errors.ConvertIfStatementToReturnNullCoalescingWarning warning) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class IfToCoalescing4Fix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public IfToCoalescing4Fix(JetBrains.ReSharper.Daemon.CSharp.Errors.ConvertIfStatementToNullCoalescingInMethodCallWarning warning) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class IfToCoalescing5Fix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public IfToCoalescing5Fix(JetBrains.ReSharper.Daemon.CSharp.Errors.ConvertIfStatementToNullCoalescingInMethodCallWithAssignmentWarning warning) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class IfToCoalescing6Fix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public IfToCoalescing6Fix(JetBrains.ReSharper.Daemon.CSharp.Errors.ConvertIfStatementToReturnMethodCallWithNullCoalescingWarning warning) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class IfToCoalescing7Fix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public IfToCoalescing7Fix(JetBrains.ReSharper.Daemon.CSharp.Errors.ConvertIfStatementToNullCoalescingExpression3Warning warning) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class IfToCoalescingFix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public IfToCoalescingFix(JetBrains.ReSharper.Daemon.CSharp.Errors.ConvertIfStatementToNullCoalescingExpression1Warning warning) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class IfToSwitchFix : JetBrains.ReSharper.Intentions.QuickFixBase_Obsolete
    {
        public static readonly JetBrains.Util.Key InstanceKey;
        public IfToSwitchFix(JetBrains.ReSharper.Daemon.CSharp.Errors.ConvertIfStatementToSwitchStatementWarning error) { }
        protected override bool IsValid { get; }
        public override string Text { get; }
        protected override void ExecuteTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
        protected override bool IsAvailableEx() { }
    }
    public class IfToTernary2Fix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public IfToTernary2Fix(JetBrains.ReSharper.Daemon.CSharp.Errors.ConvertIfStatementToReturnConditionalWarning warning) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class IfToTernary3Fix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public IfToTernary3Fix(JetBrains.ReSharper.Daemon.CSharp.Errors.ConvertIfStatementToMethodCallWarning warning) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class IfToTernary4Fix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public IfToTernary4Fix(JetBrains.ReSharper.Daemon.CSharp.Errors.ConvertIfStatementToMethodCallWithAssignmentWarning warning) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class IfToTernary5Fix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public IfToTernary5Fix(JetBrains.ReSharper.Daemon.CSharp.Errors.ConvertIfStatementToReturnMethodCallWithConditionalWarning warning) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class IfToTernaryFix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public IfToTernaryFix(JetBrains.ReSharper.Daemon.CSharp.Errors.ConvertIfStatementToConditionalTernaryExpressionWarning warning) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class IfToTernaryFixUtil
    {
        public static JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpExpression CreateTernaryExpression(JetBrains.ReSharper.Psi.CSharp.CSharpElementFactory factory, JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpExpression conditionExpression, JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpExpression thenExpression, JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpExpression elseExpression) { }
    }
    public class ImplementDisposableFix : JetBrains.ReSharper.Intentions.Extensibility.IQuickFix
    {
        public ImplementDisposableFix(JetBrains.ReSharper.Daemon.CSharp.Errors.NonDisposableTypeInUsingStatementError error) { }
        public JetBrains.ReSharper.Intentions.Extensibility.IBulbAction[] Items { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        public bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class ImplementEnumerableFix : JetBrains.ReSharper.Intentions.CSharp.QuickFixes.ImplementSpecificInterfaceFixBase
    {
        public ImplementEnumerableFix(JetBrains.ReSharper.Daemon.CSharp.Errors.TypeIsNotEnumerableError error) { }
        public ImplementEnumerableFix(JetBrains.ReSharper.Daemon.CSharp.Errors.CollectionInitializerAppliedToNonCollectionError error) { }
        protected override JetBrains.ReSharper.Psi.IDeclaredType GetImplementedInterface(JetBrains.ReSharper.Psi.ITypeElement implementor) { }
        protected override string GetText(string typePresentableName) { }
    }
    public class ImplementGenericIEnumerableForCollectionInitializerFix : JetBrains.ReSharper.Intentions.CSharp.QuickFixes.ImplementSpecificInterfaceFixBase
    {
        public ImplementGenericIEnumerableForCollectionInitializerFix(JetBrains.ReSharper.Daemon.CSharp.Errors.CollectionInitializerAppliedToNonCollectionError error) { }
        protected override JetBrains.ReSharper.Psi.IDeclaredType GetImplementedInterface(JetBrains.ReSharper.Psi.ITypeElement implementor) { }
        protected override string GetText(string typePresentableName) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class ImplementGenericIEnumerableForForeachStatementFix : JetBrains.ReSharper.Intentions.Extensibility.IQuickFix
    {
        public ImplementGenericIEnumerableForForeachStatementFix(JetBrains.ReSharper.Daemon.CSharp.Errors.TypeIsNotEnumerableError error) { }
        public JetBrains.ReSharper.Intentions.Extensibility.IBulbAction[] Items { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        public bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class ImplementGenericIEnumerableForQueryExpressionFix : JetBrains.ReSharper.Intentions.Extensibility.IQuickFix
    {
        public ImplementGenericIEnumerableForQueryExpressionFix(JetBrains.ReSharper.Daemon.CSharp.Errors.NotResolvedError error) { }
        public JetBrains.ReSharper.Intentions.Extensibility.IBulbAction[] Items { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        public bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class ImplementInterface2Fix : JetBrains.ReSharper.Intentions.CSharp.QuickFixes.ImplementInterfaceFixBase
    {
        public ImplementInterface2Fix(JetBrains.ReSharper.Daemon.CSharp.Errors.IncorrectArrayElementTypeError error) { }
        public ImplementInterface2Fix(JetBrains.ReSharper.Daemon.CSharp.Errors.IncorrectReturnTypeError error) { }
        public ImplementInterface2Fix(JetBrains.ReSharper.Daemon.CSharp.Errors.IncorrectYieldReturnTypeError error) { }
        public ImplementInterface2Fix(JetBrains.ReSharper.Daemon.CSharp.Errors.IncorrectAssignmentTypeError error) { }
        public ImplementInterface2Fix(JetBrains.ReSharper.Daemon.CSharp.Errors.IncorrectInitializerTypeError error) { }
        public ImplementInterface2Fix(JetBrains.ReSharper.Daemon.CSharp.Errors.IncorrectArgumentTypeError error) { }
        public ImplementInterface2Fix(JetBrains.ReSharper.Daemon.CSharp.Errors.TypeArgumentIsNotConvertibleToConstraintError error) { }
        protected override JetBrains.ReSharper.Psi.ITypeElement Inheritor { get; }
        protected override bool IsAvailableEx() { }
    }
    public class ImplementInterfaceFix : JetBrains.ReSharper.Intentions.CSharp.QuickFixes.ImplementInterfaceFixBase
    {
        public ImplementInterfaceFix(JetBrains.ReSharper.Daemon.CSharp.Errors.ExplicitQualifierIsNotInInterfaceListError error) { }
        protected override JetBrains.ReSharper.Psi.ITypeElement Inheritor { get; }
    }
    public abstract class ImplementInterfaceFixBase : JetBrains.ReSharper.Intentions.QuickFixBase_Obsolete
    {
        protected ImplementInterfaceFixBase(JetBrains.ReSharper.Psi.IDeclaredType interfaceType) { }
        protected abstract JetBrains.ReSharper.Psi.ITypeElement Inheritor { get; }
        protected override bool IsValid { get; }
        public override string Text { get; }
        protected override void ExecuteTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        protected override bool IsAvailableEx() { }
    }
    public class ImplementInterfaceFixItem : JetBrains.ReSharper.Intentions.Extensibility.BulbActionBase
    {
        public ImplementInterfaceFixItem(JetBrains.ReSharper.Psi.IDeclaredType implementorType, JetBrains.ReSharper.Psi.IDeclaredType interfaceToImplement, string formatString) { }
        public bool IsValid { get; }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
    }
    public class ImplementMemberAbstractFix : JetBrains.ReSharper.Intentions.Extensibility.IBulbAction, JetBrains.ReSharper.Intentions.Extensibility.IQuickFix
    {
        public ImplementMemberAbstractFix(JetBrains.ReSharper.Daemon.CSharp.Errors.InterfaceMembersNotImplementedError error) { }
        public string Text { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        public void Execute(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        public bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class ImplementMemberFix : JetBrains.ReSharper.Intentions.Extensibility.IBulbAction, JetBrains.ReSharper.Intentions.Extensibility.IQuickFix
    {
        public ImplementMemberFix(JetBrains.ReSharper.Daemon.CSharp.Errors.AbstractInheritedMemberIsNotImplementedError error) { }
        public ImplementMemberFix(JetBrains.ReSharper.Daemon.CSharp.Errors.InterfaceMembersNotImplementedError error) { }
        public string Text { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        public void Execute(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        public bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class ImplementNotifyPropertyChangedFix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public ImplementNotifyPropertyChangedFix(JetBrains.ReSharper.Daemon.CSharp.Errors.InterfaceMembersNotImplementedError error) { }
        public override string Text { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static System.Action<JetBrains.TextControl.ITextControl> EmitNotifyMethod([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpTypeDeclaration typeDeclaration, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IEvent eventMember) { }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public abstract class ImplementSpecificInterfaceFixBase : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public static readonly JetBrains.Util.Key<JetBrains.ReSharper.Psi.IDeclaredType> ImplementInterfaceKey;
        protected ImplementSpecificInterfaceFixBase(JetBrains.ReSharper.Psi.IDeclaredType implementorType) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        protected abstract JetBrains.ReSharper.Psi.IDeclaredType GetImplementedInterface(JetBrains.ReSharper.Psi.ITypeElement implementor);
        protected abstract string GetText(string typePresentableName);
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class ImportMethodFix : JetBrains.ReSharper.Intentions.Extensibility.IQuickFix
    {
        public ImportMethodFix([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.Resolve.ResolveErrorType[] acceptedResolveErrors) { }
        public ImportMethodFix([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public ImportMethodFix(JetBrains.ReSharper.Daemon.CSharp.Errors.NotResolvedError error, JetBrains.ReSharper.Psi.Resolve.ResolveErrorType[] acceptedResolveErrors) { }
        public ImportMethodFix(JetBrains.ReSharper.Daemon.CSharp.Errors.NotResolvedError error) { }
        public ImportMethodFix(JetBrains.ReSharper.Daemon.CSharp.Errors.IncorrectArgumentNumberError error) { }
        public ImportMethodFix(JetBrains.ReSharper.Daemon.CSharp.Errors.IncorrectArgumentsError error) { }
        public ImportMethodFix(JetBrains.ReSharper.Daemon.CSharp.Errors.MultipleResolveCandidatesError error) { }
        public ImportMethodFix(JetBrains.ReSharper.Daemon.CSharp.Errors.IncorrectArgumentTypeError error) { }
        public ImportMethodFix(JetBrains.ReSharper.Daemon.CSharp.Errors.NoTypeParametersInCandidateError error) { }
        public ImportMethodFix(JetBrains.ReSharper.Daemon.CSharp.Errors.TypeParametersNumberMismatchError error) { }
        public ImportMethodFix(JetBrains.ReSharper.Daemon.CSharp.Errors.TypeParametersNumberMismatchMultipleCandidatesError error) { }
        protected virtual string ItemFormat { get; }
        public JetBrains.ReSharper.Intentions.Extensibility.IBulbAction[] Items { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        protected JetBrains.ReSharper.Psi.Resolve.IReference Reference { get; set; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        public bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class ImportMethodPopupFix : JetBrains.ReSharper.Intentions.CSharp.QuickFixes.ImportMethodFix, JetBrains.ReSharper.Intentions.Extensibility.IPopupBulbAction
    {
        public ImportMethodPopupFix([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public ImportMethodPopupFix(JetBrains.ReSharper.Daemon.CSharp.Errors.NotResolvedError error) { }
        protected override string ItemFormat { get; }
        public JetBrains.UI.Anchoring2D[] PopupAnchorings { get; }
        public string PopupKey { get; }
        public string PopupMenuCaption { get; }
        public void FillMenuItemDescriptor(JetBrains.ReSharper.Intentions.Extensibility.IBulbAction key, JetBrains.UI.PopupMenu.IMenuItemDescriptor descriptor) { }
        public void OnPopupShown(JetBrains.DataFlow.Lifetime showingLifetime) { }
    }
    public class IncreaseVisibilityFix : JetBrains.ReSharper.Intentions.QuickFixes.IncreaseVisibilityFixBase
    {
        public IncreaseVisibilityFix(JetBrains.ReSharper.Daemon.CSharp.Errors.InconsistentAccessibilityInDerivationError error) { }
        public IncreaseVisibilityFix(JetBrains.ReSharper.Daemon.CSharp.Errors.InconsistentAccessibilityInMemberTypeError error) { }
        public IncreaseVisibilityFix(JetBrains.ReSharper.Daemon.CSharp.Errors.InconsistentAccessibilityInParameterTypeError error) { }
        public IncreaseVisibilityFix(JetBrains.ReSharper.Daemon.CSharp.Errors.InconsistentAccessibilityInReturnTypeError error) { }
        public IncreaseVisibilityFix(JetBrains.ReSharper.Daemon.CSharp.Errors.InconsistentAccessibilityInTypeArgumentError error) { }
        public IncreaseVisibilityFix(JetBrains.ReSharper.Daemon.CSharp.Errors.InconsistentAccessibilityInTypeParameterConstraintError error) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class InheritFromExceptionFix : JetBrains.ReSharper.Intentions.QuickFixBase_Obsolete
    {
        public InheritFromExceptionFix(JetBrains.ReSharper.Daemon.CSharp.Errors.TypeDoesNotExtendExceptionError error) { }
        public InheritFromExceptionFix(JetBrains.ReSharper.Daemon.CSharp.Errors.CatchDoesNotExtendExceptionError error) { }
        protected override bool IsValid { get; }
        public override string Text { get; }
        protected override void ExecuteTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        protected override bool IsAvailableEx() { }
    }
    public class InheritFromRequiredTypesFix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public InheritFromRequiredTypesFix(JetBrains.ReSharper.Daemon.CSharp.Errors.RequiredBaseTypesIsNotInheritedWarning error) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class InitializeBeforeRefenceFix : JetBrains.ReSharper.Intentions.CSharp.QuickFixes.InitializeVariablesFixBase
    {
        public InitializeBeforeRefenceFix(JetBrains.ReSharper.Daemon.CSharp.Errors.NotInitializedOutParameterError error) { }
        public InitializeBeforeRefenceFix(JetBrains.ReSharper.Daemon.CSharp.Errors.NotInitializedStructFieldError error) { }
        public override string Text { get; }
        public override System.Collections.Generic.IEnumerator<JetBrains.ReSharper.Psi.ITypeOwner> GetEnumerator() { }
    }
    public class InitializeConstFix : JetBrains.ReSharper.Intentions.QuickFixBase_Obsolete
    {
        public InitializeConstFix(JetBrains.ReSharper.Daemon.CSharp.Errors.ConstantInitializerMissedError error) { }
        public InitializeConstFix(JetBrains.ReSharper.Daemon.CSharp.Errors.ReferenceConstantInitializerIsNotNullError error) { }
        protected override bool IsValid { get; }
        public override string Text { get; }
        protected override void ExecutePostTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        protected override void ExecuteTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        protected override bool IsAvailableEx() { }
    }
    public class InitializeVarFix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public InitializeVarFix(JetBrains.ReSharper.Daemon.CSharp.Errors.NotInitializedLocalVariableError error) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public abstract class InitializeVariablesFixBase : JetBrains.ReSharper.Intentions.QuickFixBase_Obsolete, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.ITypeOwner>, System.Collections.IEnumerable
    {
        protected InitializeVariablesFixBase(JetBrains.ReSharper.Psi.Tree.ITreeNode exitElement) { }
        public JetBrains.ReSharper.Psi.Tree.ITreeNode ExitElement { get; }
        protected override bool IsValid { get; }
        protected override void ExecutePostTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        protected override void ExecuteTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        public abstract System.Collections.Generic.IEnumerator<JetBrains.ReSharper.Psi.ITypeOwner> GetEnumerator();
        protected override bool IsAvailableEx() { }
    }
    public class InlineMethodFix : JetBrains.ReSharper.Intentions.Extensibility.IBulbAction, JetBrains.ReSharper.Intentions.Extensibility.IQuickFix
    {
        public InlineMethodFix(JetBrains.ReSharper.Daemon.CSharp.Errors.RedundantOverloadWarningBase error) { }
        public JetBrains.ReSharper.Intentions.Extensibility.IBulbAction[] Items { get; }
        public string Text { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        public void Execute(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        public bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class IntroduceOptionalParametersFix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public IntroduceOptionalParametersFix(JetBrains.ReSharper.Daemon.CSharp.Errors.IntroduceOptionalParametersWarningBase error) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public abstract class IntroduceRefactoringFixBase : JetBrains.ReSharper.Intentions.Extensibility.IBulbAction, JetBrains.ReSharper.Intentions.Extensibility.IQuickFix
    {
        protected readonly JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpExpression myExpression;
        protected IntroduceRefactoringFixBase(JetBrains.ReSharper.Daemon.CSharp.Errors.InvalidExpressionStatementError error) { }
        protected IntroduceRefactoringFixBase(JetBrains.ReSharper.Daemon.CSharp.Errors.OutRefArgumentIsNotVariableError error) { }
        protected IntroduceRefactoringFixBase(JetBrains.ReSharper.Daemon.CSharp.Errors.OutRefArgumentIsVolatileFieldWarning error) { }
        public abstract string Text { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        public virtual void Execute(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        public bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class IntroduceVariableFix : JetBrains.ReSharper.Intentions.CSharp.QuickFixes.IntroduceRefactoringFixBase
    {
        public IntroduceVariableFix(JetBrains.ReSharper.Daemon.CSharp.Errors.InvalidExpressionStatementError error) { }
        public IntroduceVariableFix(JetBrains.ReSharper.Daemon.CSharp.Errors.OutRefArgumentIsNotVariableError error) { }
        public IntroduceVariableFix(JetBrains.ReSharper.Daemon.CSharp.Errors.OutRefArgumentIsVolatileFieldWarning error) { }
        public override string Text { get; }
        public override void Execute(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
    }
    public class InvertIfFix : JetBrains.ReSharper.Intentions.QuickFixBase_Obsolete
    {
        public static readonly JetBrains.Util.Key InstanceKey;
        public InvertIfFix(JetBrains.ReSharper.Daemon.CSharp.Errors.InvertIfWarning error) { }
        protected override bool IsValid { get; }
        public override string Text { get; }
        protected override void ExecuteTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
        protected override bool IsAvailableEx() { }
    }
    [JetBrains.ReSharper.Feature.Services.CodeCleanup.HighlightingModule.HighlightingCleanupItemAttribute(new JetBrains.ReSharper.Daemon.Severity[0])]
    public class InvokeAsExtensionMethodFix : JetBrains.ReSharper.Intentions.CSharp.QuickFixes.RedundancyHighlightingCleanupItemQuickFixBase
    {
        public InvokeAsExtensionMethodFix(JetBrains.ReSharper.Daemon.CSharp.Errors.InvokeAsExtensionMethodWarning error) { }
        protected override string BulkText { get; }
        public override string Text { get; }
        protected override void ExecutePsiTransaction() { }
        protected override JetBrains.ProjectModel.IProjectFile GetProjectFile() { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder userDataHolder) { }
    }
    public class InvokeEventFix : JetBrains.ReSharper.Intentions.Extensibility.IQuickFix
    {
        public static readonly JetBrains.Util.Key InstanceKey;
        public InvokeEventFix(JetBrains.ReSharper.Daemon.UsageChecking.EventNeverInvokedWarning error) { }
        public InvokeEventFix(JetBrains.ReSharper.Daemon.UsageChecking.VirtualEventNeverInvokedWarning error) { }
        public InvokeEventFix(JetBrains.ReSharper.Daemon.UsageChecking.InterfaceEventNeverInvokedWarning error) { }
        public JetBrains.ReSharper.Intentions.Extensibility.IBulbAction[] Items { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
    }
    public class InvokeEventFixItem : JetBrains.ReSharper.Intentions.Extensibility.BulbActionBase, JetBrains.ReSharper.Intentions.Extensibility.IBulbAction, JetBrains.ReSharper.Intentions.Util.IPartBulbItem
    {
        public override string Text { get; }
        public static JetBrains.ReSharper.Intentions.Extensibility.IBulbAction Create(JetBrains.ReSharper.Psi.CSharp.Tree.IEventDeclaration eventDeclaration) { }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public void SetWorkingPart(JetBrains.ReSharper.Psi.Tree.IDeclaration partDeclaration) { }
    }
    public class MakeAsyncFix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public MakeAsyncFix(JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpDeclaration declaration) { }
        public override string Text { get; }
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class MakeBaseVirtualFix : JetBrains.ReSharper.Intentions.QuickFixes.ModifierFixBase
    {
        public MakeBaseVirtualFix(JetBrains.ReSharper.Daemon.CSharp.Errors.NoSuitableMemberForOverrideError error) { }
        protected override string ModifiersText { get; }
        public static JetBrains.ReSharper.Psi.IOverridableMember FindBaseMember(JetBrains.ReSharper.Psi.IOverridableMember member) { }
        protected override void SetModifiers(JetBrains.ReSharper.Psi.Tree.IModifiersOwnerDeclaration declaration) { }
    }
    public class MakeClassAbstractFix : JetBrains.ReSharper.Intentions.QuickFixes.ModifierFixBase
    {
        public MakeClassAbstractFix(JetBrains.ReSharper.Daemon.CSharp.Errors.AbstractInheritedMemberIsNotImplementedError error) { }
        public MakeClassAbstractFix(JetBrains.ReSharper.Daemon.CSharp.Errors.AbstractMemberInNonabstractClassError error) { }
        protected override string ModifiersText { get; }
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
        protected override void SetModifiers(JetBrains.ReSharper.Psi.Tree.IModifiersOwnerDeclaration declaration) { }
    }
    public class MakeClassNonAbstractFix : JetBrains.ReSharper.Intentions.QuickFixes.ModifierFixBase
    {
        public MakeClassNonAbstractFix(JetBrains.ReSharper.Daemon.CSharp.Errors.ArrayElementIsStaticClassError error) { }
        public MakeClassNonAbstractFix(JetBrains.ReSharper.Daemon.CSharp.Errors.CannotCreateInstanceOfAbstractClassError error) { }
        protected override string ModifiersText { get; }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
        protected override void SetModifiers(JetBrains.ReSharper.Psi.Tree.IModifiersOwnerDeclaration declaration) { }
    }
    public class MakeClassPartialFix : JetBrains.ReSharper.Intentions.Extensibility.IQuickFix
    {
        public MakeClassPartialFix(JetBrains.ReSharper.Daemon.CSharp.Errors.PartialMethodInNonPartialTypeError error) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        public bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class MakeClassStaticFix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public MakeClassStaticFix(JetBrains.ReSharper.Daemon.CSharp.Errors.ConvertToStaticClassWarning error) { }
        public MakeClassStaticFix(JetBrains.ReSharper.Daemon.CSharp.Errors.ExtensionMethodInWrongClassError error) { }
        public MakeClassStaticFix(JetBrains.ReSharper.Daemon.UsageChecking.ClassNeverInstantiatedWarningBase error) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class MakeDefaultConstructorPublicForTypeArgumentFix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public MakeDefaultConstructorPublicForTypeArgumentFix(JetBrains.ReSharper.Daemon.CSharp.Errors.TypeArgumentHasNoDefaultConstructorError error) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class MakeMethodNonPartialFix : JetBrains.ReSharper.Intentions.Extensibility.IQuickFix
    {
        public MakeMethodNonPartialFix(JetBrains.ReSharper.Daemon.CSharp.Errors.PartialMethodInNonPartialTypeError error) { }
        public MakeMethodNonPartialFix(JetBrains.ReSharper.Daemon.CSharp.Errors.InvalidPartialMethodModifierError error) { }
        public MakeMethodNonPartialFix(JetBrains.ReSharper.Daemon.CSharp.Errors.PartialMethodWithSinglePartWarning error) { }
        public MakeMethodNonPartialFix(JetBrains.ReSharper.Daemon.CSharp.Errors.PartialMethodWithoutDefiningDeclarationError error) { }
        public JetBrains.ReSharper.Intentions.Extensibility.IBulbAction[] Items { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        public bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class MakeMethodPartialFix : JetBrains.ReSharper.Intentions.Extensibility.IQuickFix
    {
        public MakeMethodPartialFix(JetBrains.ReSharper.Daemon.CSharp.Errors.NonabstractMethodWithoutBodyError error) { }
        public MakeMethodPartialFix(JetBrains.ReSharper.Daemon.CSharp.Errors.SameSignatureMemberDeclarationError error) { }
        public JetBrains.ReSharper.Intentions.Extensibility.IBulbAction[] Items { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        public bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class MakeNewFix : JetBrains.ReSharper.Intentions.CSharp.QuickFixes.MakeNewFixBase
    {
        public MakeNewFix(JetBrains.ReSharper.Daemon.CSharp.Errors.NewModifierIsRequiredWarning error) { }
        protected override string ModifiersText { get; }
        public override string Text { get; }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
        protected override void SetModifiers(JetBrains.ReSharper.Psi.Tree.IModifiersOwnerDeclaration declaration) { }
    }
    public abstract class MakeNewFixBase : JetBrains.ReSharper.Intentions.QuickFixes.ModifierFixBase
    {
        protected MakeNewFixBase(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        protected static JetBrains.ReSharper.Psi.Tree.ITokenNode NewModifier(JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpModifiersOwnerDeclaration node) { }
    }
    public class MakeNonAbstractFix : JetBrains.ReSharper.Intentions.QuickFixes.ModifierFixBase
    {
        public static readonly JetBrains.Util.Key InstanceKey;
        public MakeNonAbstractFix(JetBrains.ReSharper.Daemon.CSharp.Errors.CannotHaveEventAccessorsInAbstractEventError error) { }
        public MakeNonAbstractFix(JetBrains.ReSharper.Daemon.CSharp.Errors.AbstractMemberInNonabstractClassError error) { }
        public MakeNonAbstractFix(JetBrains.ReSharper.Daemon.CSharp.Errors.AbstractMethodWithBodyError error) { }
        public MakeNonAbstractFix(JetBrains.ReSharper.Daemon.CSharp.Errors.AbstractMemberCannotBePrivateError error) { }
        public MakeNonAbstractFix(JetBrains.ReSharper.Daemon.CSharp.Errors.AbstractMemberCannotBeSealedError error) { }
        public MakeNonAbstractFix(JetBrains.ReSharper.Daemon.CSharp.Errors.AbstractEventWithInitializerError error) { }
        public MakeNonAbstractFix(JetBrains.ReSharper.Daemon.CSharp.Errors.AbstractMemberCannotBeVirtualError error) { }
        public MakeNonAbstractFix(JetBrains.ReSharper.Daemon.CSharp.Errors.PolymorphicMemberCannotBeStaticError error) { }
        public MakeNonAbstractFix(JetBrains.ReSharper.Daemon.CSharp.Errors.AbstractAccessorWithBodyError error) { }
        public MakeNonAbstractFix(JetBrains.ReSharper.Daemon.CSharp.Errors.ClassIsAbstractAndSealedError error) { }
        public MakeNonAbstractFix(JetBrains.ReSharper.Daemon.CSharp.Errors.AbstractBaseMemberCallError error) { }
        protected override string ModifiersText { get; }
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
        protected override void SetModifiers(JetBrains.ReSharper.Psi.Tree.IModifiersOwnerDeclaration declaration) { }
    }
    [JetBrains.ReSharper.Feature.Services.CodeCleanup.HighlightingModule.HighlightingCleanupItemAttribute(new JetBrains.ReSharper.Daemon.Severity[0])]
    public class MakeNonNewFix : JetBrains.ReSharper.Intentions.CSharp.QuickFixes.MakeNewFixBase, JetBrains.ReSharper.Feature.Services.CodeCleanup.HighlightingModule.IHighlightingsCleanupItem
    {
        public MakeNonNewFix(JetBrains.ReSharper.Daemon.CSharp.Errors.RedundantNewModifierWarning error) { }
        public MakeNonNewFix(JetBrains.ReSharper.Daemon.CSharp.Errors.OverrideMemberCannotBeNewError error) { }
        protected override string ModifiersText { get; }
        public override string Text { get; }
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        public void Execute() { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
        public bool IsAvailable(JetBrains.ReSharper.Feature.Services.CodeCleanup.CodeCleanupProfile profile) { }
        public bool IsValid() { }
        protected override void SetModifiers(JetBrains.ReSharper.Psi.Tree.IModifiersOwnerDeclaration declaration) { }
    }
    public class MakeNonReadonly2Fix : JetBrains.ReSharper.Intentions.QuickFixBase_Obsolete
    {
        public MakeNonReadonly2Fix(JetBrains.ReSharper.Daemon.CSharp.Errors.NestedObjectInitializerAppliedToValueTypeError error) { }
        protected override bool IsValid { get; }
        public override string Text { get; }
        protected override void ExecuteTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        protected override bool IsAvailableEx() { }
    }
    public class MakeNonReadonly3Fix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public MakeNonReadonly3Fix(JetBrains.ReSharper.Daemon.CSharp.Errors.PossibleAssignmentToReadonlyFieldWarning error) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class MakeNonSealedFix : JetBrains.ReSharper.Intentions.QuickFixes.ModifierFixBase
    {
        public MakeNonSealedFix(JetBrains.ReSharper.Daemon.CSharp.Errors.CannotInheritFromSealedTypeError error) { }
        public MakeNonSealedFix(JetBrains.ReSharper.Daemon.CSharp.Errors.SealedClassInTypeParameterConstraintError error) { }
        public MakeNonSealedFix(JetBrains.ReSharper.Daemon.CSharp.Errors.AbstractMemberCannotBeSealedError error) { }
        public MakeNonSealedFix(JetBrains.ReSharper.Daemon.CSharp.Errors.NonOnverrideMemberCannotBeSealedError error) { }
        protected override string ModifiersText { get; }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
        protected override void SetModifiers(JetBrains.ReSharper.Psi.Tree.IModifiersOwnerDeclaration declaration) { }
    }
    public class MakeNonVolatileFix : JetBrains.ReSharper.Intentions.QuickFixes.ModifierFixBase
    {
        public MakeNonVolatileFix(JetBrains.ReSharper.Daemon.CSharp.Errors.OverridableMemberCannotBeVolatileError error) { }
        public MakeNonVolatileFix(JetBrains.ReSharper.Daemon.CSharp.Errors.WrongVolatileFieldTypeError error) { }
        protected override string ModifiersText { get; }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
        protected override void SetModifiers(JetBrains.ReSharper.Psi.Tree.IModifiersOwnerDeclaration declaration) { }
    }
    public class MakeOverrideFix : JetBrains.ReSharper.Intentions.CSharp.QuickFixes.MakeOverrideFixBase
    {
        public MakeOverrideFix(JetBrains.ReSharper.Daemon.CSharp.Errors.OverrideKeywordIsMissingError error) { }
        public MakeOverrideFix(JetBrains.ReSharper.Daemon.CSharp.Errors.HiddenAbstractMemberError error) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public abstract class MakeOverrideFixBase : JetBrains.ReSharper.Intentions.QuickFixes.ModifierFixBase
    {
        protected MakeOverrideFixBase(JetBrains.ReSharper.Psi.IDeclaredElement member, JetBrains.ReSharper.Psi.IOverridableMember superMember) { }
        protected override string ModifiersText { get; }
        protected JetBrains.ReSharper.Psi.IOverridableMember SuperMember { get; }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
        protected override void SetModifiers(JetBrains.ReSharper.Psi.Tree.IModifiersOwnerDeclaration declaration) { }
    }
    public class MakePartialFix : JetBrains.ReSharper.Intentions.QuickFixBase_Obsolete
    {
        public MakePartialFix(JetBrains.ReSharper.Daemon.CSharp.Errors.DuplicateGlobalNameError error) { }
        public MakePartialFix(JetBrains.ReSharper.Daemon.CSharp.Errors.DuplicateSameTypeError error) { }
        protected override bool IsValid { get; }
        public override string Text { get; }
        protected override void ExecuteTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        protected override bool IsAvailableEx() { }
    }
    public class MakeSealedFix : JetBrains.ReSharper.Intentions.QuickFixes.ModifierFixBase
    {
        public MakeSealedFix(JetBrains.ReSharper.Daemon.CSharp.Errors.DoNotCallOverridableMethodsInConstructorWarning error) { }
        public MakeSealedFix(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
        protected override string ModifiersText { get; }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
        protected override void SetModifiers(JetBrains.ReSharper.Psi.Tree.IModifiersOwnerDeclaration declaration) { }
    }
    public class MakeTypeParameterVaraintFix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public MakeTypeParameterVaraintFix(JetBrains.ReSharper.Daemon.CSharp.Errors.TypeParameterCanBeVariantWarning error) { }
        public MakeTypeParameterVaraintFix(JetBrains.ReSharper.Daemon.CSharp.Errors.VarianceSafetyFailedError error) { }
        public MakeTypeParameterVaraintFix(JetBrains.ReSharper.Daemon.CSharp.Errors.CSharp40LanguageFeatureError error) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class MakeVoid2Fix : JetBrains.ReSharper.Intentions.CSharp.QuickFixes.ChangeTypeFixBase
    {
        public MakeVoid2Fix(JetBrains.ReSharper.Daemon.CSharp.Errors.MissedReturnStatementError error) { }
        public override string Text { get; }
        protected override JetBrains.ReSharper.Psi.IClrDeclaredElement GetDeclaredElement() { }
        protected override JetBrains.ReSharper.Psi.IType GetTargetType() { }
    }
    public class MakeVoidFix : JetBrains.ReSharper.Intentions.CSharp.QuickFixes.ChangeTypeInReturnFix
    {
        public MakeVoidFix(JetBrains.ReSharper.Psi.CSharp.Tree.IReturnStatement returnStatement) { }
        public MakeVoidFix(JetBrains.ReSharper.Daemon.CSharp.Errors.ReturnValueMissedError error) { }
        public MakeVoidFix(JetBrains.ReSharper.Daemon.CSharp.Errors.ReturnValueMissedAsyncError error) { }
        public override string Text { get; }
        protected override JetBrains.ReSharper.Psi.IType GetTargetType() { }
    }
    public class MergeDocCommentTagsFix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public MergeDocCommentTagsFix(JetBrains.ReSharper.Daemon.CSharp.Errors.DuplicateTypeParameterXmlDocWarning error) { }
        public MergeDocCommentTagsFix(JetBrains.ReSharper.Daemon.CSharp.Errors.DuplicateParameterXmlDocWarning error) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class MergeLocalsFix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public MergeLocalsFix(JetBrains.ReSharper.Daemon.CSharp.Errors.DuplicateLocalVariableNameError error) { }
        public MergeLocalsFix(JetBrains.ReSharper.Daemon.CSharp.Errors.DuplicateLocalVariableNameWarningError error) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class MergeTryStatementsFix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public MergeTryStatementsFix(JetBrains.ReSharper.Daemon.CSharp.Errors.TryStatementsCanBeMergedWarning warning) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class MoveInitializationFix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public static readonly JetBrains.Util.Key InstanceKey;
        public MoveInitializationFix(JetBrains.ReSharper.Daemon.CSharp.Errors.StructFieldInitializerError error) { }
        public MoveInitializationFix(JetBrains.ReSharper.Daemon.CSharp.Errors.NonStaticElementInStaticContextError error) { }
        public MoveInitializationFix(JetBrains.ReSharper.Daemon.CSharp.Errors.CannotUseThisBaseInInitializerError error) { }
        public static string StaticText { get; }
        public override string Text { get; }
        public static void Execute(JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpTypeMemberDeclaration typeMemberDeclaration) { }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
        public static bool IsAvailable(JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpTypeMemberDeclaration fieldDeclaration) { }
    }
    public class MoveModifierFix : JetBrains.ReSharper.Intentions.QuickFixBase_Obsolete
    {
        public MoveModifierFix(JetBrains.ReSharper.Daemon.CSharp.Errors.PartialModifierMustBeLastError error) { }
        protected override bool IsValid { get; }
        public static string StaticText { get; }
        public override string Text { get; }
        protected override void ExecuteTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        protected override bool IsAvailableEx() { }
    }
    public class MoveParameterToTheEndFix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public MoveParameterToTheEndFix(JetBrains.ReSharper.Daemon.CSharp.Errors.OptionalParameterBeforeRequiredError error) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class MoveToInnerScopeFix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public MoveToInnerScopeFix(JetBrains.ReSharper.Daemon.CSharp.Errors.TooWideLocalVariableScopeWarning error) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public abstract class MultipleEnumerationFixBase : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        protected MultipleEnumerationFixBase(JetBrains.ReSharper.Daemon.CSharp.Errors.PossibleMultipleEnumerationWarning warning) { }
        protected abstract void EnumerateGenericIEnumerable(JetBrains.ReSharper.Psi.IType enumerableType, JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpExpression valueExpression);
        protected abstract void EnumerateIEnumerable(JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpExpression valueExpression);
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class OptimizeImportsFix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public OptimizeImportsFix(JetBrains.ReSharper.Daemon.CSharp.Errors.UnusedUsingDirectiveWarning error) { }
        public override string Text { get; }
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        public override void Execute(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class static OwnerUtil
    {
        public static JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.ICreationTarget GetOwnerForNestedTypeDeclaration([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.CSharp.Tree.IReferenceName referenceName) { }
        public static JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.ICreationTarget GetOwnerForNestedTypeDeclaration([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.CSharp.Tree.IReferenceExpression referenceName) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.ICreationTarget GetOwnerForTypeDeclaration([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.CSharp.Tree.IReferenceName referenceName) { }
        public static JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.ICreationTarget GetOwnerForTypeDeclaration([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.CSharp.Tree.IReferenceExpression referenceExpression) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.ITypeTarget GetOwnerForTypeMemberDeclaration([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
    }
    public class ParamsParamTypeFix : JetBrains.ReSharper.Intentions.QuickFixBase_Obsolete
    {
        public ParamsParamTypeFix(JetBrains.ReSharper.Daemon.CSharp.Errors.ParamsButNotArrayError error) { }
        public ParamsParamTypeFix(JetBrains.ReSharper.Daemon.CSharp.Errors.ParamsMultiDimArrayError error) { }
        protected override bool IsValid { get; }
        public override string Text { get; }
        protected override void ExecuteTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        protected override bool IsAvailableEx() { }
    }
    public class PassCancellationTokenFix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public PassCancellationTokenFix(JetBrains.ReSharper.Daemon.CSharp.Errors.MethodSupportsCancellationWarning warning) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class ProtectedInCrefFix : JetBrains.ReSharper.Intentions.QuickFixBase_Obsolete
    {
        public ProtectedInCrefFix(JetBrains.ReSharper.Daemon.CSharp.Errors.NotResolvedInDocCommentWarning error) { }
        protected override bool IsValid { get; }
        public override string Text { get; }
        protected override void ExecuteTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        protected override bool IsAvailableEx() { }
    }
    public class PullLocalFix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public PullLocalFix(JetBrains.ReSharper.Daemon.CSharp.Errors.NotResolvedError error) { }
        public PullLocalFix(JetBrains.ReSharper.Daemon.CSharp.Errors.UseLocalVariableBeforeDeclarationError error) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public sealed class QuickFixDebugUtil
    {
        public static JetBrains.ReSharper.Intentions.Extensibility.IQuickFix CreateQuickFix(string name, string errorName, params object[] errorParams) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.QuickFixAttribute()]
    public sealed class RecursionToIterationFix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public RecursionToIterationFix(JetBrains.ReSharper.Daemon.CSharp.Errors.TailRecursiveCallWarning warning) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public abstract class RedundancyHighlightingCleanupItemQuickFixBase : JetBrains.ReSharper.Intentions.QuickFixes.Bulk.RedundancyHighlightingCleanupItemQuickFixBase<JetBrains.ReSharper.Psi.CSharp.CSharpLanguage> { }
    public class RemoveAccessorFix : JetBrains.ReSharper.Intentions.QuickFixBase_Obsolete
    {
        public RemoveAccessorFix(JetBrains.ReSharper.Daemon.CSharp.Errors.AddedAccessorInPrivateImplementationError error) { }
        public RemoveAccessorFix(JetBrains.ReSharper.Daemon.CSharp.Errors.CannotOverrideUnexistingAccessorError error) { }
        protected override bool IsValid { get; }
        public override string Text { get; }
        protected override void ExecuteTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        protected override bool IsAvailableEx() { }
    }
    [JetBrains.ReSharper.Feature.Services.CodeCleanup.HighlightingModule.HighlightingCleanupItemAttribute(new JetBrains.ReSharper.Daemon.Severity[0])]
    public class RemoveAccessorModifiersFix : JetBrains.ReSharper.Intentions.CSharp.QuickFixes.RemoveModifiersFixBase
    {
        public RemoveAccessorModifiersFix(JetBrains.ReSharper.Daemon.CSharp.Errors.AccessRightsInSingleAccessorError error) { }
        public RemoveAccessorModifiersFix(JetBrains.ReSharper.Daemon.CSharp.Errors.AccessRightsForBothAccessorsError error) { }
        public RemoveAccessorModifiersFix(JetBrains.ReSharper.Daemon.CSharp.Errors.AbstractPrivateAccessorError error) { }
        public RemoveAccessorModifiersFix(JetBrains.ReSharper.Daemon.CSharp.Errors.EventAccessorCannotHaveModifiersError error) { }
        public RemoveAccessorModifiersFix(JetBrains.ReSharper.Daemon.CSharp.Errors.InvalidPartialMethodModifierError error) { }
        public RemoveAccessorModifiersFix(JetBrains.ReSharper.Daemon.CSharp.Errors.AccessorAccessRightsShouldBeMoreRestrictiveError error) { }
        protected override bool MustRemove(JetBrains.ReSharper.Psi.Parsing.TokenNodeType modifierNodeType) { }
    }
    public class RemoveAnyModifierFix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public RemoveAnyModifierFix(JetBrains.ReSharper.Psi.CSharp.Tree.IModifiersList modifiersList, JetBrains.ReSharper.Psi.Tree.ITokenNode modifier) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    [JetBrains.ReSharper.Feature.Services.CodeCleanup.HighlightingModule.HighlightingCleanupItemAttribute(new JetBrains.ReSharper.Daemon.Severity[0])]
    public class RemoveArgumentNameFix : JetBrains.ReSharper.Intentions.CSharp.QuickFixes.RedundancyHighlightingCleanupItemQuickFixBase
    {
        public RemoveArgumentNameFix(JetBrains.ReSharper.Daemon.CSharp.Errors.RedundantArgumentNameWarning error) { }
        public RemoveArgumentNameFix(JetBrains.ReSharper.Daemon.CSharp.Errors.RedundantArgumentNameForLiteralExpressionWarning error) { }
        public RemoveArgumentNameFix(JetBrains.ReSharper.Daemon.CSharp.Errors.NamedCollectionInitializerElementError error) { }
        public RemoveArgumentNameFix(JetBrains.ReSharper.Daemon.CSharp.Errors.CSharp40LanguageFeatureError error) { }
        protected override string BulkText { get; }
        public override string Text { get; }
        protected override void ExecutePsiTransaction() { }
        protected override JetBrains.ProjectModel.IProjectFile GetProjectFile() { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class RemoveAssignmentFix : JetBrains.ReSharper.Intentions.QuickFixBase_Obsolete
    {
        public RemoveAssignmentFix(JetBrains.ReSharper.Daemon.CSharp.Errors.AssignmentNotUsedWarning error) { }
        public RemoveAssignmentFix(JetBrains.ReSharper.Daemon.CSharp.Errors.MeaninglessAssignmentWarning error) { }
        public RemoveAssignmentFix(JetBrains.ReSharper.Daemon.CSharp.Errors.AssignmentToSameVariableWarning error) { }
        protected override bool IsValid { get; }
        public override string Text { get; }
        protected override void ExecuteTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        protected override bool IsAvailableEx() { }
    }
    public class RemoveAsyncFix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public RemoveAsyncFix(JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpDeclaration declaration) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class RemoveAwaitFix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public RemoveAwaitFix(JetBrains.ReSharper.Psi.CSharp.Tree.IAwaitExpression awaitExpression) { }
        public override string Text { get; }
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class RemoveBodyFix : JetBrains.ReSharper.Intentions.QuickFixBase_Obsolete
    {
        public RemoveBodyFix(JetBrains.ReSharper.Daemon.CSharp.Errors.AbstractMethodWithBodyError error) { }
        public RemoveBodyFix(JetBrains.ReSharper.Daemon.CSharp.Errors.InterfaceMethodWithBodyError error) { }
        public RemoveBodyFix(JetBrains.ReSharper.Daemon.CSharp.Errors.ExternFunctionWithBodyError error) { }
        public RemoveBodyFix(JetBrains.ReSharper.Daemon.CSharp.Errors.ExternAccessorWithBodyError error) { }
        public RemoveBodyFix(JetBrains.ReSharper.Daemon.CSharp.Errors.InterfaceAccessorWithBodyError error) { }
        public RemoveBodyFix(JetBrains.ReSharper.Daemon.CSharp.Errors.AbstractAccessorWithBodyError error) { }
        protected override bool IsValid { get; }
        public override string Text { get; }
        protected override void ExecuteTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        protected override bool IsAvailableEx() { }
    }
    public class RemoveClassConstraintFix : JetBrains.ReSharper.Intentions.CSharp.QuickFixes.RemoveConstraintFixBase
    {
        public RemoveClassConstraintFix(JetBrains.ReSharper.Daemon.CSharp.Errors.DuplicateReferenceTypeParameterConstraintError error) { }
        public RemoveClassConstraintFix(JetBrains.ReSharper.Daemon.CSharp.Errors.BothValueAndReferenceTypeParameterConstraintError error) { }
        public RemoveClassConstraintFix(JetBrains.ReSharper.Daemon.CSharp.Errors.BothRefValueAndClassConstraintError error) { }
    }
    [JetBrains.ReSharper.Feature.Services.CodeCleanup.HighlightingModule.HighlightingCleanupItemAttribute(new JetBrains.ReSharper.Daemon.Severity[0])]
    public class RemoveComparisonOfBoolFix : JetBrains.ReSharper.Intentions.CSharp.QuickFixes.RedundancyHighlightingCleanupItemQuickFixBase
    {
        public RemoveComparisonOfBoolFix(JetBrains.ReSharper.Daemon.CSharp.Errors.RedundantBooleanComparisonWarning error) { }
        protected override string BulkText { get; }
        public override string Text { get; }
        protected override void ExecutePsiTransaction() { }
        protected override JetBrains.ProjectModel.IProjectFile GetProjectFile() { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder userDataHolder) { }
    }
    public abstract class RemoveConstraintFixBase : JetBrains.ReSharper.Intentions.QuickFixBase_Obsolete
    {
        protected RemoveConstraintFixBase(JetBrains.ReSharper.Psi.CSharp.Tree.ITypeParameterConstraint constraint, bool processAllClauses) { }
        protected JetBrains.ReSharper.Psi.CSharp.Tree.ITypeParameterConstraint Constraint { get; }
        protected override bool IsValid { get; }
        public override string Text { get; }
        protected override void ExecuteTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        protected override bool IsAvailableEx() { }
    }
    public class RemoveConstraintsFix : JetBrains.ReSharper.Intentions.QuickFixBase_Obsolete
    {
        public RemoveConstraintsFix(JetBrains.ReSharper.Daemon.CSharp.Errors.OverridenMethodCannotHasTypeParameterConstraintError error) { }
        public RemoveConstraintsFix(JetBrains.ReSharper.Daemon.CSharp.Errors.ExplicitImplementedMethodCannotHasTypeParameterConstraintError error) { }
        protected override bool IsValid { get; }
        public override string Text { get; }
        protected override void ExecuteTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        protected override bool IsAvailableEx() { }
    }
    public class RemoveDefaultValueFix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public RemoveDefaultValueFix(JetBrains.ReSharper.Daemon.CSharp.Errors.ExtensionMethodThisParameterCannotHaveDefaultValueError error) { }
        public RemoveDefaultValueFix(JetBrains.ReSharper.Daemon.CSharp.Errors.OptionalParameterInvalidStringValueError error) { }
        public RemoveDefaultValueFix(JetBrains.ReSharper.Daemon.CSharp.Errors.OptionalParameterInvalidValueError error) { }
        public RemoveDefaultValueFix(JetBrains.ReSharper.Daemon.CSharp.Errors.OptionalParameterRefOutError error) { }
        public RemoveDefaultValueFix(JetBrains.ReSharper.Daemon.CSharp.Errors.OptionalParameterIncompatibleTypeError error) { }
        public RemoveDefaultValueFix(JetBrains.ReSharper.Daemon.CSharp.Errors.OptionalParameterInvalidReferenceValueError error) { }
        public RemoveDefaultValueFix(JetBrains.ReSharper.Daemon.CSharp.Errors.ParamsWithDefaultValueError error) { }
        public RemoveDefaultValueFix(JetBrains.ReSharper.Daemon.CSharp.Errors.MeaninglessOptionalParameterWarning error) { }
        public RemoveDefaultValueFix(JetBrains.ReSharper.Daemon.CSharp.Errors.CSharp40LanguageFeatureError error) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class RemoveDocCommentFix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public RemoveDocCommentFix(JetBrains.ReSharper.Daemon.CSharp.Errors.DocCommentPlacedOnInvalidElementWarning error) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class RemoveDocCommentTagFix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public RemoveDocCommentTagFix(JetBrains.ReSharper.Daemon.CSharp.Errors.DuplicateTypeParameterXmlDocWarning error) { }
        public RemoveDocCommentTagFix(JetBrains.ReSharper.Daemon.CSharp.Errors.NotResolvedInDocCommentWarning error) { }
        public RemoveDocCommentTagFix(JetBrains.ReSharper.Daemon.CSharp.Errors.DuplicateParameterXmlDocWarning error) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class RemoveDoubleNegationFix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public RemoveDoubleNegationFix(JetBrains.ReSharper.Daemon.CSharp.Errors.DoubleNegationOperatorWarning error) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class RemoveDuplicateInterfaceFix : JetBrains.ReSharper.Intentions.QuickFixBase_Obsolete
    {
        public RemoveDuplicateInterfaceFix(JetBrains.ReSharper.Daemon.CSharp.Errors.DuplicateInterfaceInExtendsListError error) { }
        public RemoveDuplicateInterfaceFix(JetBrains.ReSharper.Daemon.CSharp.Errors.SuperInterfaceIsSuperOfOtherWarning error) { }
        public RemoveDuplicateInterfaceFix(JetBrains.ReSharper.Daemon.CSharp.Errors.SuperTypeDeclaredInOtherPartWarning error) { }
        protected override bool IsValid { get; }
        public override string Text { get; }
        protected override void ExecuteTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        protected override bool IsAvailableEx() { }
    }
    [JetBrains.ReSharper.Feature.Services.CodeCleanup.HighlightingModule.HighlightingCleanupItemAttribute(new JetBrains.ReSharper.Daemon.Severity[0])]
    public class RemoveEmptyConstructorFix : JetBrains.ReSharper.Intentions.CSharp.QuickFixes.RedundancyHighlightingCleanupItemQuickFixBase
    {
        public RemoveEmptyConstructorFix(JetBrains.ReSharper.Daemon.CSharp.Errors.EmptyConstructorWarning error) { }
        public RemoveEmptyConstructorFix(JetBrains.ReSharper.Daemon.CSharp.Errors.EmptyStaticConstructorWarning error) { }
        public RemoveEmptyConstructorFix(JetBrains.ReSharper.Daemon.CSharp.Errors.ParameterlessConstructorInStructError error) { }
        protected override string BulkText { get; }
        public override string Text { get; }
        protected override void ExecutePsiTransaction() { }
        protected override JetBrains.ProjectModel.IProjectFile GetProjectFile() { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder userDataHolder) { }
    }
    public class RemoveEventAccessorsFix : JetBrains.ReSharper.Intentions.QuickFixBase_Obsolete
    {
        public RemoveEventAccessorsFix(JetBrains.ReSharper.Daemon.CSharp.Errors.InterfaceAccessorWithBodyError error) { }
        public RemoveEventAccessorsFix(JetBrains.ReSharper.Daemon.CSharp.Errors.EventPropertyMustDeclareAdderAndRemoverError error) { }
        public RemoveEventAccessorsFix(JetBrains.ReSharper.Daemon.CSharp.Errors.CannotHaveEventAccessorsInAbstractEventError error) { }
        public RemoveEventAccessorsFix(JetBrains.ReSharper.Daemon.CSharp.Errors.CannotHaveEventAccessorsInInterfacesError error) { }
        protected override bool IsValid { get; }
        public override string Text { get; }
        protected override void ExecuteTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        protected override bool IsAvailableEx() { }
    }
    public class RemoveEventInitializerFix : JetBrains.ReSharper.Intentions.QuickFixBase_Obsolete
    {
        public RemoveEventInitializerFix(JetBrains.ReSharper.Daemon.CSharp.Errors.CannotHaveEventInitializersInInterfacesError error) { }
        public RemoveEventInitializerFix(JetBrains.ReSharper.Daemon.CSharp.Errors.AbstractEventWithInitializerError error) { }
        protected override bool IsValid { get; }
        public override string Text { get; }
        protected override void ExecuteTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        protected override bool IsAvailableEx() { }
    }
    [JetBrains.ReSharper.Feature.Services.CodeCleanup.HighlightingModule.HighlightingCleanupItemAttribute(new JetBrains.ReSharper.Daemon.Severity[0])]
    public class RemoveExplicitImplModifiersFix : JetBrains.ReSharper.Intentions.CSharp.QuickFixes.RemoveModifiersFixBase
    {
        public RemoveExplicitImplModifiersFix(JetBrains.ReSharper.Daemon.CSharp.Errors.InvalidModifierInExplicitDeclarationError error) { }
        public RemoveExplicitImplModifiersFix(JetBrains.ReSharper.Daemon.CSharp.Errors.AccessRightsInPrivateImplementationAccessorError error) { }
        protected override bool IsAvailableEx() { }
        protected override bool MustRemove(JetBrains.ReSharper.Psi.Parsing.TokenNodeType modifierNodeType) { }
    }
    [JetBrains.ReSharper.Feature.Services.CodeCleanup.HighlightingModule.HighlightingCleanupItemAttribute(new JetBrains.ReSharper.Daemon.Severity[0])]
    public class RemoveIfaceMemberModifiersFix : JetBrains.ReSharper.Intentions.CSharp.QuickFixes.RemoveModifiersFixBase
    {
        public RemoveIfaceMemberModifiersFix(JetBrains.ReSharper.Daemon.CSharp.Errors.InvalidInterfaceMemberModifierError error) { }
        public RemoveIfaceMemberModifiersFix(JetBrains.ReSharper.Daemon.CSharp.Errors.AccessorInInterfaceCannotHaveAccessRightsError error) { }
        protected override bool IsAvailableEx() { }
        protected override bool MustRemove(JetBrains.ReSharper.Psi.Parsing.TokenNodeType modifierNodeType) { }
    }
    public class RemoveInitializerFix : JetBrains.ReSharper.Intentions.QuickFixBase_Obsolete
    {
        public RemoveInitializerFix(JetBrains.ReSharper.Daemon.CSharp.Errors.VariableConstantInitializerNotUsedWarning error) { }
        public RemoveInitializerFix(JetBrains.ReSharper.Daemon.CSharp.Errors.VariableInitializerNotUsedWarning error) { }
        protected override bool IsValid { get; }
        public override string Text { get; }
        protected override void ExecuteTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        protected override bool IsAvailableEx() { }
    }
    public abstract class RemoveModifiersFixBase : JetBrains.ReSharper.Intentions.CSharp.QuickFixes.RedundancyHighlightingCleanupItemQuickFixBase
    {
        protected RemoveModifiersFixBase(JetBrains.ReSharper.Psi.Tree.ITokenNode modifier) { }
        protected RemoveModifiersFixBase(JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpModifiersOwnerDeclaration declaration) { }
        protected override string BulkText { get; }
        protected JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpModifiersOwnerDeclaration Declaration { get; }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecuteAfterPsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.ProjectModel.IProjectModelTransactionCookie cookie, JetBrains.Application.Progress.IProgressIndicator progress) { }
        protected override void ExecutePsiTransaction() { }
        protected JetBrains.ReSharper.Psi.CSharp.Tree.IModifiersListOwner GetModifiersOwnerNode() { }
        protected override JetBrains.ProjectModel.IProjectFile GetProjectFile() { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder userDataHolder) { }
        protected virtual bool IsAvailableEx() { }
        protected abstract bool MustRemove(JetBrains.ReSharper.Psi.Parsing.TokenNodeType modifierNodeType);
    }
    public class RemoveOverrideFix : JetBrains.ReSharper.Intentions.QuickFixes.ModifierFixBase
    {
        public RemoveOverrideFix(JetBrains.ReSharper.Daemon.CSharp.Errors.NoSuitableMemberForOverrideError error) { }
        public RemoveOverrideFix(JetBrains.ReSharper.Daemon.CSharp.Errors.OverrideMemberCannotBeNewError error) { }
        protected override string ModifiersText { get; }
        public override string Text { get; }
        protected override void SetModifiers(JetBrains.ReSharper.Psi.Tree.IModifiersOwnerDeclaration declaration) { }
    }
    public class RemoveParams2Fix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public RemoveParams2Fix(JetBrains.ReSharper.Daemon.CSharp.Errors.BaseMemberHasParamsWarning error) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class RemoveParamsFix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public RemoveParamsFix(JetBrains.ReSharper.Daemon.CSharp.Errors.RedundantParamsWarning error) { }
        public RemoveParamsFix(JetBrains.ReSharper.Daemon.CSharp.Errors.AnonymousMethodParameterParamsError error) { }
        public RemoveParamsFix(JetBrains.ReSharper.Daemon.CSharp.Errors.LambdaParameterParamsError error) { }
        public RemoveParamsFix(JetBrains.ReSharper.Daemon.CSharp.Errors.NotImplementParamsDiffersError error) { }
        public RemoveParamsFix(JetBrains.ReSharper.Daemon.CSharp.Errors.ExtensionMethodParameterCannotBeParamsError error) { }
        public RemoveParamsFix(JetBrains.ReSharper.Daemon.CSharp.Errors.ParamsMustBeLastError error) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class RemoveParamTypeSpecificationFix : JetBrains.ReSharper.Intentions.QuickFixBase_Obsolete
    {
        public RemoveParamTypeSpecificationFix(JetBrains.ReSharper.Daemon.CSharp.Errors.RedundantLambdaParameterTypeWarning error) { }
        protected override bool IsValid { get; }
        public override string Text { get; }
        public static void Execute(JetBrains.ReSharper.Psi.CSharp.Tree.ILambdaExpression declaration, JetBrains.ReSharper.Psi.CSharp.CSharpElementFactory factory) { }
        protected override void ExecuteTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        protected override bool IsAvailableEx() { }
    }
    [JetBrains.ReSharper.Feature.Services.CodeCleanup.HighlightingModule.HighlightingCleanupItemAttribute(new JetBrains.ReSharper.Daemon.Severity[0])]
    public class RemovePolymorphicFix : JetBrains.ReSharper.Intentions.CSharp.QuickFixes.RemoveModifiersFixBase
    {
        public RemovePolymorphicFix(JetBrains.ReSharper.Daemon.CSharp.Errors.StaticClassCannotBeAbstractError error) { }
        public RemovePolymorphicFix(JetBrains.ReSharper.Daemon.CSharp.Errors.NonOnverrideMemberCannotBeSealedError error) { }
        public RemovePolymorphicFix(JetBrains.ReSharper.Daemon.CSharp.Errors.NonPolymorphicMemberCannotBeAbstractError error) { }
        public RemovePolymorphicFix(JetBrains.ReSharper.Daemon.CSharp.Errors.NonPolymorphicMemberCannotBeOverrideError error) { }
        public RemovePolymorphicFix(JetBrains.ReSharper.Daemon.CSharp.Errors.NonPolymorphicMemberCannotBeVirtualError error) { }
        public RemovePolymorphicFix(JetBrains.ReSharper.Daemon.CSharp.Errors.NonPolymorphicMemberCannotBeSealedError error) { }
        public RemovePolymorphicFix(JetBrains.ReSharper.Daemon.CSharp.Errors.VirtualMemberInSealedClassError error) { }
        public RemovePolymorphicFix(JetBrains.ReSharper.Daemon.CSharp.Errors.VirtualMemberInStructError error) { }
        public RemovePolymorphicFix(JetBrains.ReSharper.Daemon.CSharp.Errors.StaticClassCannotBeSealedError error) { }
        protected override bool MustRemove(JetBrains.ReSharper.Psi.Parsing.TokenNodeType modifierNodeType) { }
    }
    public class RemoveQualificationFix : JetBrains.ReSharper.Intentions.QuickFixBase_Obsolete
    {
        public RemoveQualificationFix(JetBrains.ReSharper.Daemon.CSharp.Errors.ExplicitImplementationInInterfaceError error) { }
        protected override bool IsValid { get; }
        public override string Text { get; }
        protected override void ExecuteTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        protected override bool IsAvailableEx() { }
    }
    public class RemoveRedundantArgumentValueFix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public RemoveRedundantArgumentValueFix(JetBrains.ReSharper.Daemon.CSharp.Errors.RedundantArgumentDefaultValueWarning error) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    [JetBrains.ReSharper.Feature.Services.CodeCleanup.HighlightingModule.HighlightingCleanupItemAttribute(new JetBrains.ReSharper.Daemon.Severity[0])]
    public class RemoveRedundantArrayCreationExpressionFix : JetBrains.ReSharper.Intentions.CSharp.QuickFixes.RedundancyHighlightingCleanupItemQuickFixBase
    {
        public RemoveRedundantArrayCreationExpressionFix(JetBrains.ReSharper.Daemon.CSharp.Errors.CoVariantArrayConversionWarning warning) { }
        public RemoveRedundantArrayCreationExpressionFix(JetBrains.ReSharper.Daemon.CSharp.Errors.RedundantArrayCreationExpressionWarning warning) { }
        protected override string BulkText { get; }
        public override string Text { get; }
        protected override void ExecutePsiTransaction() { }
        protected override JetBrains.ProjectModel.IProjectFile GetProjectFile() { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    [JetBrains.ReSharper.Feature.Services.CodeCleanup.HighlightingModule.HighlightingCleanupItemAttribute(new JetBrains.ReSharper.Daemon.Severity[0])]
    public class RemoveRedundantArrayTypeFix : JetBrains.ReSharper.Intentions.CSharp.QuickFixes.RedundancyHighlightingCleanupItemQuickFixBase
    {
        public RemoveRedundantArrayTypeFix(JetBrains.ReSharper.Daemon.CSharp.Errors.RedundantExplicitArrayCreationWarning error) { }
        protected override string BulkText { get; }
        public override string Text { get; }
        protected override void ExecutePsiTransaction() { }
        protected override JetBrains.ProjectModel.IProjectFile GetProjectFile() { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder userDataHolder) { }
    }
    [JetBrains.ReSharper.Feature.Services.CodeCleanup.HighlightingModule.HighlightingCleanupItemAttribute(new JetBrains.ReSharper.Daemon.Severity[0])]
    public class RemoveRedundantBaseFix : JetBrains.ReSharper.Intentions.CSharp.QuickFixes.RedundancyHighlightingCleanupItemQuickFixBase
    {
        public RemoveRedundantBaseFix(JetBrains.ReSharper.Daemon.CSharp.Errors.RedundantBaseConstructorCallWarning error) { }
        protected override string BulkText { get; }
        public override string Text { get; }
        protected override void ExecutePsiTransaction() { }
        protected override JetBrains.ProjectModel.IProjectFile GetProjectFile() { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder userDataHolder) { }
    }
    public class RemoveRedundantCatchClauseFix : JetBrains.ReSharper.Intentions.QuickFixBase_Obsolete
    {
        public RemoveRedundantCatchClauseFix(JetBrains.ReSharper.Daemon.CSharp.Errors.RedundantCatchClauseWarning error) { }
        public RemoveRedundantCatchClauseFix(JetBrains.ReSharper.Daemon.CSharp.Errors.PreviousCatchClauseHandlesThisTypeError error) { }
        protected override bool IsValid { get; }
        public override string Text { get; }
        protected override void ExecuteTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        protected override bool IsAvailableEx() { }
    }
    [JetBrains.ReSharper.Feature.Services.CodeCleanup.HighlightingModule.HighlightingCleanupItemAttribute(new JetBrains.ReSharper.Daemon.Severity[0])]
    public class RemoveRedundantCommaFix : JetBrains.ReSharper.Intentions.CSharp.QuickFixes.RedundancyHighlightingCleanupItemQuickFixBase
    {
        public RemoveRedundantCommaFix(JetBrains.ReSharper.Daemon.CSharp.Errors.RedundantCommaInArrayInitializerWarning warning) { }
        protected override string BulkText { get; }
        public override string Text { get; }
        protected override void ExecutePsiTransaction() { }
        protected override JetBrains.ProjectModel.IProjectFile GetProjectFile() { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    [JetBrains.ReSharper.Feature.Services.CodeCleanup.HighlightingModule.HighlightingCleanupItemAttribute(new JetBrains.ReSharper.Daemon.Severity[0])]
    public class RemoveRedundantElseFix : JetBrains.ReSharper.Intentions.CSharp.QuickFixes.RedundancyHighlightingCleanupItemQuickFixBase
    {
        public RemoveRedundantElseFix(JetBrains.ReSharper.Daemon.CSharp.Errors.RedundantIfElseBlockWarning error) { }
        public RemoveRedundantElseFix(JetBrains.ReSharper.Daemon.CSharp.Errors.RedundantIfElseKeywordWarning error) { }
        protected override string BulkText { get; }
        public override string Text { get; }
        protected override void ExecutePsiTransaction() { }
        protected override JetBrains.ProjectModel.IProjectFile GetProjectFile() { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class RemoveRedundantEmptySwitchBranchFix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public RemoveRedundantEmptySwitchBranchFix(JetBrains.ReSharper.Daemon.CSharp.Errors.RedundantEmptyDefaultSwitchBranchWarning warning) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class RemoveRedundantEnumerableCastFix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public RemoveRedundantEnumerableCastFix(JetBrains.ReSharper.Daemon.CSharp.Errors.RedundantEnumerableCastCallWarning error) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class RemoveRedundantExplicitArraySizeFix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public RemoveRedundantExplicitArraySizeFix(JetBrains.ReSharper.Daemon.CSharp.Errors.RedundantExplicitArraySizeWarning error) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    [JetBrains.ReSharper.Feature.Services.CodeCleanup.HighlightingModule.HighlightingCleanupItemAttribute(new JetBrains.ReSharper.Daemon.Severity[0])]
    public class RemoveRedundantInitializerFix : JetBrains.ReSharper.Intentions.CSharp.QuickFixes.RedundancyHighlightingCleanupItemQuickFixBase
    {
        public RemoveRedundantInitializerFix(JetBrains.ReSharper.Daemon.CSharp.Errors.ObjectOrCollectionInitializerInDelegateCreationError error) { }
        public RemoveRedundantInitializerFix(JetBrains.ReSharper.Daemon.CSharp.Errors.RedundantEmptyObjectOrCollectionInitializerWarning error) { }
        protected override string BulkText { get; }
        public override string Text { get; }
        protected override void ExecutePsiTransaction() { }
        protected override JetBrains.ProjectModel.IProjectFile GetProjectFile() { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    [JetBrains.ReSharper.Feature.Services.CodeCleanup.HighlightingModule.HighlightingCleanupItemAttribute(new JetBrains.ReSharper.Daemon.Severity[0])]
    public class RemoveRedundantJumpStatementFix : JetBrains.ReSharper.Intentions.CSharp.QuickFixes.RedundancyHighlightingCleanupItemQuickFixBase
    {
        public RemoveRedundantJumpStatementFix(JetBrains.ReSharper.Daemon.CSharp.Errors.RedundantJumpStatementWarning error) { }
        protected override string BulkText { get; }
        public override string Text { get; }
        protected override void ExecutePsiTransaction() { }
        protected override JetBrains.ProjectModel.IProjectFile GetProjectFile() { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    [JetBrains.ReSharper.Feature.Services.CodeCleanup.HighlightingModule.HighlightingCleanupItemAttribute(new JetBrains.ReSharper.Daemon.Severity[0])]
    public class RemoveRedundantNullableFix : JetBrains.ReSharper.Intentions.CSharp.QuickFixes.RedundancyHighlightingCleanupItemQuickFixBase
    {
        public RemoveRedundantNullableFix(JetBrains.ReSharper.Daemon.CSharp.Errors.RedundantExplicitNullableCreationWarning error) { }
        protected override string BulkText { get; }
        public override string Text { get; }
        protected override void ExecutePsiTransaction() { }
        protected override JetBrains.ProjectModel.IProjectFile GetProjectFile() { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder userDataHolder) { }
    }
    [JetBrains.ReSharper.Feature.Services.CodeCleanup.HighlightingModule.HighlightingCleanupItemAttribute(new JetBrains.ReSharper.Daemon.Severity[0])]
    public class RemoveRedundantParens2Fix : JetBrains.ReSharper.Intentions.CSharp.QuickFixes.RedundancyHighlightingCleanupItemQuickFixBase
    {
        public RemoveRedundantParens2Fix(JetBrains.ReSharper.Daemon.CSharp.Errors.RedundantLambdaSignatureParenthesesWarning error) { }
        protected override string BulkText { get; }
        public override string Text { get; }
        protected override void ExecutePsiTransaction() { }
        protected override JetBrains.ProjectModel.IProjectFile GetProjectFile() { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class RemoveRedundantQualifierFix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public RemoveRedundantQualifierFix(JetBrains.ReSharper.Daemon.CSharp.Errors.RedundantQualifierWarning error) { }
        public RemoveRedundantQualifierFix(JetBrains.ReSharper.Daemon.CSharp.Errors.RedundantBaseQualifierWarning error) { }
        public RemoveRedundantQualifierFix(JetBrains.ReSharper.Daemon.CSharp.Errors.RedundantThisQualifierWarning error) { }
        public override string Text { get; }
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    [JetBrains.ReSharper.Feature.Services.CodeCleanup.HighlightingModule.HighlightingCleanupItemAttribute(new JetBrains.ReSharper.Daemon.Severity[0])]
    public class RemoveRedundantStringFormatFix : JetBrains.ReSharper.Intentions.CSharp.QuickFixes.RedundancyHighlightingCleanupItemQuickFixBase
    {
        public RemoveRedundantStringFormatFix(JetBrains.ReSharper.Daemon.CSharp.Errors.RedundantStringFormatCallWarning warning) { }
        protected override string BulkText { get; }
        public override string Text { get; }
        protected override void ExecutePsiTransaction() { }
        protected override JetBrains.ProjectModel.IProjectFile GetProjectFile() { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class RemoveRefOutFix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public RemoveRefOutFix(JetBrains.ReSharper.Daemon.CSharp.Errors.OptionalParameterRefOutError error) { }
        public RemoveRefOutFix(JetBrains.ReSharper.Daemon.CSharp.Errors.RefOutParameterInOperatorError error) { }
        public RemoveRefOutFix(JetBrains.ReSharper.Daemon.CSharp.Errors.RefOrOutParameterInAsyncError error) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class RemoveReturnValueFix : JetBrains.ReSharper.Intentions.Extensibility.IQuickFix
    {
        public RemoveReturnValueFix(JetBrains.ReSharper.Daemon.CSharp.Errors.ReturnTypeIsVoidError error) { }
        public RemoveReturnValueFix(JetBrains.ReSharper.Daemon.CSharp.Errors.ReturnTypeIsVoidAsyncError error) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        public bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
        public class MoveReturnValueBeforeExitItem : JetBrains.ReSharper.Intentions.Extensibility.BulbActionBase
        {
            public MoveReturnValueBeforeExitItem(JetBrains.ReSharper.Psi.CSharp.Tree.IReturnStatement returnStatement) { }
            public char Accelerator { get; }
            public override string Text { get; }
            protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        }
        public class RemoveReturnValueItem : JetBrains.ReSharper.Intentions.Extensibility.BulbActionBase
        {
            public RemoveReturnValueItem(JetBrains.ReSharper.Psi.CSharp.Tree.IReturnStatement returnStatement) { }
            public char Accelerator { get; }
            public override string Text { get; }
            protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        }
    }
    [JetBrains.ReSharper.Feature.Services.CodeCleanup.HighlightingModule.HighlightingCleanupItemAttribute(new JetBrains.ReSharper.Daemon.Severity[0])]
    public class RemoveSealedFix : JetBrains.ReSharper.Intentions.CSharp.QuickFixes.RemoveModifiersFixBase
    {
        public RemoveSealedFix(JetBrains.ReSharper.Daemon.CSharp.Errors.SealedMemberInSealedClassWarning error) { }
        public RemoveSealedFix(JetBrains.ReSharper.Daemon.CSharp.Errors.OverrideFromSealedMemberError error) { }
        public RemoveSealedFix(JetBrains.ReSharper.Daemon.CSharp.Errors.ClassIsAbstractAndSealedError error) { }
        protected override string BulkText { get; }
        public override string Text { get; }
        protected override bool MustRemove(JetBrains.ReSharper.Psi.Parsing.TokenNodeType modifierNodeType) { }
    }
    [JetBrains.ReSharper.Feature.Services.CodeCleanup.HighlightingModule.HighlightingCleanupItemAttribute(new JetBrains.ReSharper.Daemon.Severity[0])]
    public class RemoveToStringFix : JetBrains.ReSharper.Intentions.CSharp.QuickFixes.RedundancyHighlightingCleanupItemQuickFixBase
    {
        public RemoveToStringFix(JetBrains.ReSharper.Daemon.CSharp.Errors.RedundantToStringCallWarning error) { }
        public RemoveToStringFix(JetBrains.ReSharper.Daemon.CSharp.Errors.RedundantToStringCallForValueTypeWarning error) { }
        protected override string BulkText { get; }
        public override string Text { get; }
        protected override void ExecutePsiTransaction() { }
        protected override JetBrains.ProjectModel.IProjectFile GetProjectFile() { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder userDataHolder) { }
    }
    public class RemoveTypeParamsFix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public RemoveTypeParamsFix(JetBrains.ReSharper.Daemon.CSharp.Errors.AttributeCannotHaveTypeParametersError error) { }
        public RemoveTypeParamsFix(JetBrains.ReSharper.Daemon.CSharp.Errors.EnumCannotHaveTypeParametersError error) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class RemoveUnreachableCodeFix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public RemoveUnreachableCodeFix(JetBrains.ReSharper.Daemon.CSharp.Errors.NullCoalescingConditionIsAlwaysNotNullWarning error) { }
        public RemoveUnreachableCodeFix(JetBrains.ReSharper.Daemon.CSharp.Errors.UnreachableCodeWarning error) { }
        public RemoveUnreachableCodeFix(JetBrains.ReSharper.Daemon.CSharp.Errors.UnreachableCodeCompilerWarning error) { }
        public RemoveUnreachableCodeFix(JetBrains.ReSharper.Daemon.CSharp.Errors.HeuristicUnreachableCodeWarning error) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class RenameLocalWrongRefFix : JetBrains.ReSharper.Intentions.CSharp.QuickFixes.RenameWrongRefFixBase
    {
        public RenameLocalWrongRefFix(JetBrains.ReSharper.Daemon.CSharp.Errors.NotResolvedError error) { }
        public RenameLocalWrongRefFix(JetBrains.ReSharper.Daemon.CSharp.Errors.StaticElementInNonStaticContextError error) { }
        public RenameLocalWrongRefFix(JetBrains.ReSharper.Daemon.CSharp.Errors.MultipleStaticElementInNonStaticContextError error) { }
        public RenameLocalWrongRefFix(JetBrains.ReSharper.Daemon.CSharp.Errors.NonStaticElementInStaticContextError error) { }
        public RenameLocalWrongRefFix(JetBrains.ReSharper.Daemon.CSharp.Errors.MultipleNonStaticElementInStaticContextError error) { }
        public override string Text { get; }
        protected override JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpTreeNode GetScope(JetBrains.ReSharper.Psi.CSharp.Tree.IReferenceExpression expression) { }
    }
    public class RenameMember2Fix : JetBrains.ReSharper.Intentions.Extensibility.IQuickFix
    {
        public RenameMember2Fix(JetBrains.ReSharper.Daemon.CSharp.Errors.PossibleInterfaceMemberAmbiguityWarning error) { }
        public JetBrains.ReSharper.Intentions.Extensibility.IBulbAction[] Items { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        public bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class RenameMemberFix : JetBrains.ReSharper.Intentions.CSharp.QuickFixes.RenameRefactoringItem, JetBrains.ReSharper.Intentions.Extensibility.IQuickFix
    {
        public RenameMemberFix(JetBrains.ReSharper.Daemon.CSharp.Errors.LocalVariableHidesMemberWarning error) { }
        public RenameMemberFix(JetBrains.ReSharper.Daemon.CSharp.Errors.ParameterHidesMemberWarning error) { }
        public JetBrains.ReSharper.Intentions.Extensibility.IBulbAction[] Items { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        public bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class RenameWrongRefFix : JetBrains.ReSharper.Intentions.CSharp.QuickFixes.RenameWrongRefFixBase
    {
        public RenameWrongRefFix(JetBrains.ReSharper.Daemon.CSharp.Errors.NotResolvedError error) { }
        public RenameWrongRefFix(JetBrains.ReSharper.Daemon.CSharp.Errors.StaticElementInNonStaticContextError error) { }
        public RenameWrongRefFix(JetBrains.ReSharper.Daemon.CSharp.Errors.MultipleStaticElementInNonStaticContextError error) { }
        public RenameWrongRefFix(JetBrains.ReSharper.Daemon.CSharp.Errors.NonStaticElementInStaticContextError error) { }
        public RenameWrongRefFix(JetBrains.ReSharper.Daemon.CSharp.Errors.MultipleNonStaticElementInStaticContextError error) { }
        public override string Text { get; }
        protected override JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpTreeNode GetScope(JetBrains.ReSharper.Psi.CSharp.Tree.IReferenceExpression expression) { }
    }
    public abstract class RenameWrongRefFixBase : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        protected RenameWrongRefFixBase(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        protected JetBrains.ReSharper.Psi.Resolve.IReference Reference { get; }
        protected System.Collections.Generic.IList<JetBrains.ReSharper.Psi.CSharp.Tree.IReferenceExpression> CollectReferenceExpressions() { }
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        protected abstract JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpTreeNode GetScope(JetBrains.ReSharper.Psi.CSharp.Tree.IReferenceExpression expression);
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
        public class DeclaredInfoTemplateExpression : JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.SuggestedNameTemplateExpression
        {
            public DeclaredInfoTemplateExpression(System.Collections.Generic.IList<JetBrains.ReSharper.Psi.IDeclaredElement> candidates, string suggestedName) { }
            protected override bool LookupSuggestedNameIfEmpty { get; }
            protected override System.Collections.Generic.IList<JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem> GetLookupItemsImpl(JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotContext sessionContext) { }
        }
        public abstract class ReferenceOccurence<T>
            where T :  class, JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpTreeNode
        {
            protected readonly T ReferenceExpression;
            protected ReferenceOccurence(T referenceExpression) { }
            public string ReferenceName { get; }
            protected abstract bool FastFilter(JetBrains.ReSharper.Psi.IClrDeclaredElement declaredElement);
            protected static bool FilterByIsSynthetic(JetBrains.ReSharper.Psi.IDeclaredElement element) { }
            protected static bool FilterByName(JetBrains.ReSharper.Psi.IDeclaredElement element) { }
            public static System.Collections.Generic.JetHashSet<JetBrains.ReSharper.Psi.IDeclaredElement> GetCandidates(ReferenceOccurence<>[] references) { }
            protected abstract JetBrains.ReSharper.Psi.Resolve.IReference GetReference(T referenceExpresssion);
            public static JetBrains.DocumentModel.DocumentRange GetReferenceRange(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
            public JetBrains.DocumentModel.DocumentRange ReferenceRange() { }
            protected abstract bool SlowFilter(JetBrains.ReSharper.Psi.IClrDeclaredElement declaredElement);
        }
    }
    public class ReplaceConditionalTernaryByConditionFix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public ReplaceConditionalTernaryByConditionFix(JetBrains.ReSharper.Daemon.CSharp.Errors.RedundantTernaryExpressionWarning warning) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class ReplaceConditionalWithBranchFix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public ReplaceConditionalWithBranchFix(JetBrains.ReSharper.Daemon.CSharp.Errors.ConditionalTernaryEqualBranchWarning error) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public sealed class ReplaceConditionWithRespectiveBranchFix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public ReplaceConditionWithRespectiveBranchFix(JetBrains.ReSharper.Daemon.CSharp.Errors.ReferenceEqualsWithValueTypeWarning error) { }
        public ReplaceConditionWithRespectiveBranchFix(JetBrains.ReSharper.Daemon.CSharp.Errors.ConditionIsAlwaysTrueOrFalseWarning error) { }
        public ReplaceConditionWithRespectiveBranchFix(JetBrains.ReSharper.Daemon.CSharp.Errors.IsExpressionAlwaysTrueWarning error) { }
        public ReplaceConditionWithRespectiveBranchFix(JetBrains.ReSharper.Daemon.CSharp.Errors.IsExpressionAlwaysFalseWarning error) { }
        public ReplaceConditionWithRespectiveBranchFix(JetBrains.ReSharper.Daemon.UsageChecking.SuspiciousTypeCheckWarning error) { }
        public ReplaceConditionWithRespectiveBranchFix(JetBrains.ReSharper.Daemon.UsageChecking.SuspiciousComparisonWarning error) { }
        public ReplaceConditionWithRespectiveBranchFix(JetBrains.ReSharper.Daemon.CSharp.Errors.EqualExpressionComparisonWarning error) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class ReplaceDefaultValueWithDefaultFix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public ReplaceDefaultValueWithDefaultFix(JetBrains.ReSharper.Daemon.CSharp.Errors.OptionalParameterInvalidReferenceValueError error) { }
        public ReplaceDefaultValueWithDefaultFix(JetBrains.ReSharper.Daemon.CSharp.Errors.OptionalParameterInvalidStringValueError error) { }
        public ReplaceDefaultValueWithDefaultFix(JetBrains.ReSharper.Daemon.CSharp.Errors.OptionalParameterInvalidValueError error) { }
        public ReplaceDefaultValueWithDefaultFix(JetBrains.ReSharper.Daemon.CSharp.Errors.OptionalParameterIncompatibleTypeError error) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class ReplaceDestructorWithDisposeFix : JetBrains.ReSharper.Intentions.CSharp.QuickFixes.ImplementSpecificInterfaceFixBase
    {
        public ReplaceDestructorWithDisposeFix(JetBrains.ReSharper.Daemon.CSharp.Errors.DestructorOfNotClassTypeError error) { }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        protected override JetBrains.ReSharper.Psi.IDeclaredType GetImplementedInterface(JetBrains.ReSharper.Psi.ITypeElement implementor) { }
        protected override string GetText(string typePresentableName) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class ReplaceWithBoolConstFix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public ReplaceWithBoolConstFix(JetBrains.ReSharper.Daemon.CSharp.Errors.RedundantLogicalConditionalExpressionOperandWarning error) { }
        public ReplaceWithBoolConstFix(JetBrains.ReSharper.Daemon.CSharp.Errors.ReferenceEqualsWithValueTypeWarning error) { }
        public ReplaceWithBoolConstFix(JetBrains.ReSharper.Daemon.CSharp.Errors.ConditionIsAlwaysTrueOrFalseWarning error) { }
        public ReplaceWithBoolConstFix(JetBrains.ReSharper.Daemon.CSharp.Errors.ExpressionIsAlwaysNullWarning error) { }
        public ReplaceWithBoolConstFix(JetBrains.ReSharper.Daemon.CSharp.Errors.IsExpressionAlwaysTrueWarning error) { }
        public ReplaceWithBoolConstFix(JetBrains.ReSharper.Daemon.CSharp.Errors.IsExpressionAlwaysFalseWarning error) { }
        public ReplaceWithBoolConstFix(JetBrains.ReSharper.Daemon.UsageChecking.SuspiciousTypeCheckWarning error) { }
        public ReplaceWithBoolConstFix(JetBrains.ReSharper.Daemon.UsageChecking.SuspiciousComparisonWarning error) { }
        public ReplaceWithBoolConstFix(JetBrains.ReSharper.Daemon.CSharp.Errors.EqualExpressionComparisonWarning error) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class ReplaceWithExpressionFix : JetBrains.ReSharper.Intentions.QuickFixBase_Obsolete
    {
        public ReplaceWithExpressionFix(JetBrains.ReSharper.Daemon.CSharp.Errors.NestedObjectInitializerAppliedToValueTypeError error) { }
        protected override bool IsValid { get; }
        public override string Text { get; }
        protected override void ExecuteTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        protected override bool IsAvailableEx() { }
    }
    public class ReplaceWithOperatorIsFix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public ReplaceWithOperatorIsFix(JetBrains.ReSharper.Daemon.CSharp.Errors.OperatorIsCanBeUsedWarning warning) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class ReplaceWithTryCastAndCheckForNullFix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public static readonly JetBrains.Util.Key InstanceKey;
        public ReplaceWithTryCastAndCheckForNullFix(JetBrains.ReSharper.Daemon.CSharp.Errors.CanBeReplacedWithTryCastAndCheckForNullWarning warning) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class ReplaceWithUppercaseSuffixFix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public ReplaceWithUppercaseSuffixFix(JetBrains.ReSharper.Daemon.CSharp.Errors.LongLiteralEndingLowerLWarning warning) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class ReturnDefaultValueAsyncFix : JetBrains.ReSharper.Intentions.CSharp.QuickFixes.ReturnDefaultValueFix
    {
        public ReturnDefaultValueAsyncFix(JetBrains.ReSharper.Daemon.CSharp.Errors.ReturnValueMissedAsyncError error) { }
        protected override JetBrains.ReSharper.Psi.IType GetTargetType() { }
    }
    public class ReturnDefaultValueFix : JetBrains.ReSharper.Intentions.QuickFixBase_Obsolete
    {
        public ReturnDefaultValueFix(JetBrains.ReSharper.Psi.CSharp.Tree.IReturnStatement statement) { }
        public ReturnDefaultValueFix(JetBrains.ReSharper.Daemon.CSharp.Errors.ReturnValueMissedError error) { }
        protected override bool IsValid { get; }
        public override string Text { get; }
        protected override void ExecuteTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        protected virtual JetBrains.ReSharper.Psi.IType GetTargetType() { }
        protected override bool IsAvailableEx() { }
    }
    public class ReturnValueFix : JetBrains.ReSharper.Intentions.QuickFixBase_Obsolete
    {
        public ReturnValueFix(JetBrains.ReSharper.Daemon.CSharp.Errors.InvalidExpressionStatementError error) { }
        protected override bool IsValid { get; }
        public override string Text { get; }
        public static JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpExpression Execute(JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpExpression expression) { }
        protected override void ExecutePostTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        protected override void ExecuteTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        public static bool IsAvailable(JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpExpression expression) { }
        protected override bool IsAvailableEx() { }
        public static void PostExecute(JetBrains.TextControl.ITextControl textControl, JetBrains.ReSharper.Psi.Tree.ITreeNode expression) { }
    }
    public class SafeCastInArgumentFix : JetBrains.ReSharper.Intentions.CSharp.QuickFixes.CastInArgumentBase
    {
        public SafeCastInArgumentFix(JetBrains.ReSharper.Daemon.CSharp.Errors.IncorrectArgumentTypeError error) { }
        public SafeCastInArgumentFix(JetBrains.ReSharper.Daemon.CSharp.Errors.MultipleResolveCandidatesError error) { }
        public SafeCastInArgumentFix(JetBrains.ReSharper.Daemon.CSharp.Errors.IncorrectArgumentsError error) { }
        public SafeCastInArgumentFix(JetBrains.ReSharper.Daemon.CSharp.Errors.IncorrectArgumentNumberError error) { }
        public SafeCastInArgumentFix(JetBrains.ReSharper.Daemon.CSharp.Errors.IndexerIncorrectArgumentNumberError error) { }
        protected override bool AsCast { get; }
    }
    public class SafeCastInLambdaBodyExpressionFix : JetBrains.ReSharper.Intentions.CSharp.QuickFixes.CastInLambdaBodyExpressionFixBase
    {
        public SafeCastInLambdaBodyExpressionFix(JetBrains.ReSharper.Daemon.CSharp.Errors.IncorrectLambdaBodyExpressionTypeError error) { }
        protected override bool AsCast { get; }
    }
    public class SealMethodFix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public SealMethodFix(JetBrains.ReSharper.Daemon.CSharp.Errors.DoNotCallOverridableMethodsInConstructorWarning error) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class SimplifyConditionalOperatorFix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public SimplifyConditionalOperatorFix(JetBrains.ReSharper.Daemon.CSharp.Errors.SimplifyConditionalTernaryExpressionWarning warning) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class SimplifyLinqExpressionFix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public SimplifyLinqExpressionFix(JetBrains.ReSharper.Daemon.CSharp.Errors.SimplifyLinqExpressionWarning warning) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class SimplifyNegativeEqualityExpressionFix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public SimplifyNegativeEqualityExpressionFix(JetBrains.ReSharper.Daemon.CSharp.Errors.NegativeEqualityExpressionWarning error) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class SpecifyACultureInStringConversionExplicitlyFix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public SpecifyACultureInStringConversionExplicitlyFix(JetBrains.ReSharper.Daemon.CSharp.Errors.SpecifyACultureInStringConversionExplicitlyWarning warning) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class SpecifyFieldNameFix : JetBrains.ReSharper.Intentions.Extensibility.IQuickFix
    {
        public static readonly JetBrains.Util.Key<object> OurSpecifyFieldNameFixKey;
        public SpecifyFieldNameFix(JetBrains.ReSharper.Daemon.CSharp.Errors.AnonymousTypeProjectionInitializerNotMemberAccessError error) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        public bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class SpecifyStringComparisonFix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public SpecifyStringComparisonFix(JetBrains.ReSharper.Daemon.CSharp.Errors.SpecifyStringComparisonWarning warning) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class SpecifyTypeExplicitly2Fix : JetBrains.ReSharper.Intentions.QuickFixBase_Obsolete
    {
        public SpecifyTypeExplicitly2Fix(JetBrains.ReSharper.Daemon.CSharp.Errors.CSharp30LanguageFeatureError error) { }
        protected override bool IsValid { get; }
        public override string Text { get; }
        protected override void ExecuteTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
        protected override bool IsAvailableEx() { }
    }
    public class SplitUsingFix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public SplitUsingFix(JetBrains.ReSharper.Daemon.CSharp.Errors.MultipleExpressionsInUsingStatementError error) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class SurroundWithUnsafeFix : JetBrains.ReSharper.Intentions.QuickFixBase_Obsolete
    {
        public SurroundWithUnsafeFix(JetBrains.ReSharper.Daemon.CSharp.Errors.PointerInSafeContextError error) { }
        public SurroundWithUnsafeFix(JetBrains.ReSharper.Daemon.CSharp.Errors.PointerInSafeContext2Error error) { }
        public SurroundWithUnsafeFix(JetBrains.ReSharper.Daemon.CSharp.Errors.UnsafeConstructInSafeContextError error) { }
        protected override bool IsValid { get; }
        public override string Text { get; }
        protected override void ExecutePostTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        protected override void ExecuteTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        protected override bool IsAvailableEx() { }
    }
    public class ToAbstractClassFix : JetBrains.ReSharper.Intentions.CSharp.QuickFixes.ToAbstractClassFixBase
    {
        public ToAbstractClassFix(JetBrains.ReSharper.Daemon.CSharp.Errors.InterfaceInExtendsListExpectedError error) { }
        public ToAbstractClassFix(JetBrains.ReSharper.Daemon.CSharp.Errors.NotResolvedConstructorInitializerError error) { }
        public ToAbstractClassFix(JetBrains.ReSharper.Daemon.CSharp.Errors.ConstructorInInterfaceError error) { }
        public ToAbstractClassFix(JetBrains.ReSharper.Daemon.CSharp.Errors.CannotHaveEventAccessorsInInterfacesError error) { }
        public ToAbstractClassFix(JetBrains.ReSharper.Daemon.CSharp.Errors.CannotHaveEventInitializersInInterfacesError error) { }
        public ToAbstractClassFix(JetBrains.ReSharper.Daemon.CSharp.Errors.InterfaceCannotContainNonOverridableMemberError error) { }
        public ToAbstractClassFix(JetBrains.ReSharper.Daemon.CSharp.Errors.ExplicitImplementationInInterfaceError error) { }
        public override string Text { get; }
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        protected override JetBrains.ReSharper.Psi.CSharp.Tree.IInterfaceDeclaration GetInterfaceDeclaration() { }
    }
    public abstract class ToAbstractClassFixBase : JetBrains.ReSharper.Intentions.Extensibility.IBulbAction, JetBrains.ReSharper.Intentions.Extensibility.IQuickFix
    {
        public JetBrains.ReSharper.Intentions.Extensibility.IBulbAction[] Items { get; }
        public abstract string Text { get; }
        public abstract System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems();
        public void Execute(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        protected abstract JetBrains.ReSharper.Psi.CSharp.Tree.IInterfaceDeclaration GetInterfaceDeclaration();
        public bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class ToAutoProperty2Fix : JetBrains.ReSharper.Intentions.CSharp.QuickFixes.ToAutoPropertyFix
    {
        public ToAutoProperty2Fix(JetBrains.ReSharper.Daemon.CSharp.Errors.ConvertToAutoPropertyWithPrivateSetterWarning error) { }
        public override string Text { get; }
    }
    [JetBrains.ReSharper.Feature.Services.CodeCleanup.HighlightingModule.HighlightingCleanupItemAttribute(new JetBrains.ReSharper.Daemon.Severity[0])]
    public class ToAutoPropertyFix : JetBrains.ReSharper.Intentions.QuickFixes.Bulk.HighlightingCleanupItemQuickFixBase<JetBrains.ReSharper.Psi.CSharp.CSharpLanguage>
    {
        public static readonly JetBrains.Util.Key InstanceKey;
        protected ToAutoPropertyFix(JetBrains.ReSharper.Psi.IField field, JetBrains.ReSharper.Psi.CSharp.Tree.IPropertyDeclaration declaration) { }
        public ToAutoPropertyFix(JetBrains.ReSharper.Daemon.CSharp.Errors.ConvertToAutoPropertyWarning error) { }
        protected override string BulkText { get; }
        public override string Text { get; }
        protected override void ExecutePsiTransaction() { }
        protected override void FillProfile(JetBrains.ReSharper.Feature.Services.CodeCleanup.CodeCleanupProfile codeCleanupProfile) { }
        protected override JetBrains.ProjectModel.IProjectFile GetProjectFile() { }
        protected override bool IsAllowedByProfile(JetBrains.ReSharper.Feature.Services.CodeCleanup.CodeCleanupProfile colCleanupProfile) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class ToClass2Fix : JetBrains.ReSharper.Intentions.CSharp.QuickFixes.ToClassFixBase
    {
        public ToClass2Fix(JetBrains.ReSharper.Daemon.CSharp.Errors.TypeArgumentIsNotReferenceTypeError error) { }
        public ToClass2Fix(JetBrains.ReSharper.Daemon.CSharp.Errors.NonReferenceTypeInLockStatementError error) { }
        protected override bool IsValid { get; }
        protected override JetBrains.ReSharper.Psi.IStruct GetStruct() { }
    }
    public class ToClassFix : JetBrains.ReSharper.Intentions.CSharp.QuickFixes.ToClassFixBase
    {
        public ToClassFix(JetBrains.ReSharper.Daemon.CSharp.Errors.NotResolvedConstructorInitializerError error) { }
        public ToClassFix(JetBrains.ReSharper.Daemon.CSharp.Errors.CannotUseThisInAnonymousMethodInStructError error) { }
        public ToClassFix(JetBrains.ReSharper.Daemon.CSharp.Errors.DestructorOfNotClassTypeError error) { }
        public ToClassFix(JetBrains.ReSharper.Daemon.CSharp.Errors.StructFieldInitializerError error) { }
        protected override bool IsValid { get; }
        protected override JetBrains.ReSharper.Psi.IStruct GetStruct() { }
    }
    public abstract class ToClassFixBase : JetBrains.ReSharper.Intentions.QuickFixBase_Obsolete
    {
        public override string Text { get; }
        protected override void ExecutePostTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        protected override void ExecuteTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        protected abstract JetBrains.ReSharper.Psi.IStruct GetStruct();
        protected override bool IsAvailableEx() { }
    }
    public class ToDestructorFix : JetBrains.ReSharper.Intentions.QuickFixBase_Obsolete
    {
        public ToDestructorFix(JetBrains.ReSharper.Daemon.CSharp.Errors.IncorrectDestructorNameError error) { }
        protected override bool IsValid { get; }
        public override string Text { get; }
        protected override void ExecuteTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        protected override bool IsAvailableEx() { }
    }
    public class ToDirectCastFix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public ToDirectCastFix(JetBrains.ReSharper.Daemon.CSharp.Errors.PossibleNullReferenceExceptionWarning error) { }
        public ToDirectCastFix(JetBrains.ReSharper.Daemon.CSharp.Errors.PossibleInvalidOperationExceptionWarning error) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class ToImplicitFix : JetBrains.ReSharper.Intentions.QuickFixBase_Obsolete
    {
        public ToImplicitFix(JetBrains.ReSharper.Daemon.CSharp.Errors.CannotAccessExplicitImplementationError error) { }
        protected override bool IsValid { get; }
        public override string Text { get; }
        protected override void ExecuteTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        protected override bool IsAvailableEx() { }
    }
    public class ToLocalVariableFix : JetBrains.ReSharper.Intentions.QuickFixBase_Obsolete
    {
        public ToLocalVariableFix(JetBrains.ReSharper.Daemon.CSharp.Errors.ConstantIsTypeParameterError error) { }
        public ToLocalVariableFix(JetBrains.ReSharper.Daemon.CSharp.Errors.ConstantInitializerIsNotConstantError error) { }
        public ToLocalVariableFix(JetBrains.ReSharper.Daemon.CSharp.Errors.ReferenceConstantInitializerIsNotNullError error) { }
        public ToLocalVariableFix(JetBrains.ReSharper.Daemon.CSharp.Errors.ConstantInitializerMissedError error) { }
        public ToLocalVariableFix(JetBrains.ReSharper.Daemon.CSharp.Errors.InvalidConstantTypeError error) { }
        protected override bool IsValid { get; }
        public override string Text { get; }
        protected override void ExecuteTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        protected override bool IsAvailableEx() { }
    }
    public class ToMethodGroupFix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public ToMethodGroupFix(JetBrains.ReSharper.Daemon.CSharp.Errors.ConvertClosureToMethodGroupWarning error) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class ToRegularArrayFix : JetBrains.ReSharper.Intentions.QuickFixBase_Obsolete
    {
        public ToRegularArrayFix(JetBrains.ReSharper.Daemon.CSharp.Errors.FixedSizeBufferNotInStructError error) { }
        protected override bool IsValid { get; }
        public override string Text { get; }
        protected override void ExecuteTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        protected override bool IsAvailableEx() { }
    }
    public class ToStaticReadonlyFieldFix : JetBrains.ReSharper.Intentions.QuickFixBase_Obsolete
    {
        public ToStaticReadonlyFieldFix(JetBrains.ReSharper.Daemon.CSharp.Errors.ConstantIsTypeParameterError error) { }
        public ToStaticReadonlyFieldFix(JetBrains.ReSharper.Daemon.CSharp.Errors.ConstantInitializerIsNotConstantError error) { }
        public ToStaticReadonlyFieldFix(JetBrains.ReSharper.Daemon.CSharp.Errors.ReferenceConstantInitializerIsNotNullError error) { }
        public ToStaticReadonlyFieldFix(JetBrains.ReSharper.Daemon.CSharp.Errors.ConstantInitializerMissedError error) { }
        public ToStaticReadonlyFieldFix(JetBrains.ReSharper.Daemon.CSharp.Errors.InvalidConstantTypeError error) { }
        protected override bool IsValid { get; }
        public override string Text { get; }
        protected override void ExecuteTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        protected override bool IsAvailableEx() { }
    }
    public class ToVoidMethodFix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public ToVoidMethodFix(JetBrains.ReSharper.Daemon.CSharp.Errors.InterfaceCannotContainNonOverridableMemberError error) { }
        public ToVoidMethodFix(JetBrains.ReSharper.Daemon.CSharp.Errors.ConstructorInInterfaceError error) { }
        public ToVoidMethodFix(JetBrains.ReSharper.Daemon.CSharp.Errors.ConstructorNameNotMatchingClassNameError error) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.QuickFixAttribute()]
    public class UnmarkNullnessFix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public UnmarkNullnessFix(JetBrains.ReSharper.Daemon.CSharp.Errors.AnnotationRedundanceInHierarchyWarning warning) { }
        public UnmarkNullnessFix(JetBrains.ReSharper.Daemon.CSharp.Errors.AnnotationConflictInHierarchyWarning warning) { }
        public UnmarkNullnessFix(JetBrains.ReSharper.Daemon.CSharp.Errors.AnnotationRedundanceAtValueTypeWarning warning) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class UseAssignmentsFix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public static readonly JetBrains.Util.Key InstanceKey;
        public UseAssignmentsFix(JetBrains.ReSharper.Daemon.CSharp.Errors.CSharp30LanguageFeatureError error) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class UseBackingFieldFix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public static readonly JetBrains.Util.Key InstanceKey;
        public UseBackingFieldFix(JetBrains.ReSharper.Daemon.CSharp.Errors.NonabstractAccessorWithoutBodyError error) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class UseCollectionInitializerFix : JetBrains.ReSharper.Intentions.QuickFixBase_Obsolete
    {
        public UseCollectionInitializerFix(JetBrains.ReSharper.Daemon.CSharp.Errors.UseCollectionInitializerWarning error) { }
        protected override bool IsValid { get; }
        public override string Text { get; }
        protected override void ExecuteTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        protected override bool IsAvailableEx() { }
    }
    public class UseEqualsFix : JetBrains.ReSharper.Intentions.QuickFixBase_Obsolete
    {
        public UseEqualsFix(JetBrains.ReSharper.Daemon.CSharp.Errors.ReferenceEqualsWithValueTypeWarning error) { }
        protected override bool IsValid { get; }
        public override string Text { get; }
        protected override void ExecuteTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        protected override bool IsAvailableEx() { }
    }
    public class UseExplicitArrayTypeFix : JetBrains.ReSharper.Intentions.Extensibility.IQuickFix
    {
        public static readonly JetBrains.Util.Key InstanceKey;
        public UseExplicitArrayTypeFix(JetBrains.ReSharper.Daemon.CSharp.Errors.CannotInferImplicitlyTypedArrayTypeError error) { }
        public UseExplicitArrayTypeFix(JetBrains.ReSharper.Daemon.CSharp.Errors.CoVariantArrayConversionWarning error) { }
        public UseExplicitArrayTypeFix(JetBrains.ReSharper.Daemon.CSharp.Errors.CSharp30LanguageFeatureError error) { }
        public JetBrains.ReSharper.Intentions.Extensibility.IBulbAction[] Items { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        public bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class UseIndexedPropertyFix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public UseIndexedPropertyFix(JetBrains.ReSharper.Daemon.CSharp.Errors.UseIndexedPropertyWarning error) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    [JetBrains.ReSharper.Feature.Services.CodeCleanup.HighlightingModule.HighlightingCleanupItemAttribute(new JetBrains.ReSharper.Daemon.Severity[0])]
    public class UseNullableShortFormFix : JetBrains.ReSharper.Intentions.CSharp.QuickFixes.RedundancyHighlightingCleanupItemQuickFixBase
    {
        public UseNullableShortFormFix(JetBrains.ReSharper.Daemon.CSharp.Errors.ConvertNullableToShortFormWarning error) { }
        protected override string BulkText { get; }
        public override string Text { get; }
        protected override void ExecutePsiTransaction() { }
        protected override JetBrains.ProjectModel.IProjectFile GetProjectFile() { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder userDataHolder) { }
    }
    public class UseNullOrEmptyFix : JetBrains.ReSharper.Intentions.Extensibility.BulbActionBase, JetBrains.ReSharper.Intentions.Extensibility.IQuickFix
    {
        public UseNullOrEmptyFix(JetBrains.ReSharper.Daemon.CSharp.Errors.ReplaceWithStringIsNullOrEmptyWarning error) { }
        public override string Text { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class UseObjectInitializerFix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public UseObjectInitializerFix(JetBrains.ReSharper.Daemon.CSharp.Errors.UseObjectInitializerWarning error) { }
        public override string Text { get; }
        public static void ApplyInitializerUseChecker(JetBrains.ReSharper.Daemon.CSharp.Stages.ObjectCreationProblemAnalyzer.SuggestInitializerUseChecker checker, JetBrains.ReSharper.Psi.CSharp.Tree.IObjectCreationExpression expression) { }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class UseVarFix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public static readonly JetBrains.Util.Key InstanceKey;
        public UseVarFix(JetBrains.ReSharper.Daemon.CSharp.Errors.UseVarKeywordEvidentWarning error) { }
        public UseVarFix(JetBrains.ReSharper.Daemon.CSharp.Errors.UseVarKeywordEverywhereWarning error) { }
        public override string Text { get; }
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class WrapLocalFix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public WrapLocalFix(JetBrains.ReSharper.Daemon.CSharp.Errors.AccessToModifiedClosureWarning error) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class WrapWithConstructorFix : JetBrains.ReSharper.Intentions.Extensibility.IQuickFix
    {
        public WrapWithConstructorFix(JetBrains.ReSharper.Daemon.CSharp.Errors.IncorrectArgumentTypeError erorr) { }
        public WrapWithConstructorFix(JetBrains.ReSharper.Daemon.CSharp.Errors.IncorrectInitializerTypeError error) { }
        public WrapWithConstructorFix(JetBrains.ReSharper.Daemon.CSharp.Errors.IncorrectAssignmentTypeError error) { }
        public WrapWithConstructorFix(JetBrains.ReSharper.Daemon.CSharp.Errors.IncorrectReturnTypeError error) { }
        public JetBrains.ReSharper.Intentions.Extensibility.IBulbAction[] Items { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        public bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class WrapWithDelegateFix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public WrapWithDelegateFix(JetBrains.ReSharper.Daemon.CSharp.Errors.InvalidInitializerImplicitlyTypeVariableError error) { }
        public WrapWithDelegateFix(JetBrains.ReSharper.Daemon.CSharp.Errors.InvalidReferenceExpressionQualifierError error) { }
        public WrapWithDelegateFix(JetBrains.ReSharper.Daemon.CSharp.Errors.IncorrectInitializerTypeError error) { }
        public WrapWithDelegateFix(JetBrains.ReSharper.Daemon.CSharp.Errors.IncorrectArgumentTypeError error) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class WrapWithTypeofFix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public WrapWithTypeofFix(JetBrains.ReSharper.Daemon.CSharp.Errors.UnexpectedElementTypeError error) { }
        public override string Text { get; }
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
}
namespace JetBrains.ReSharper.Intentions.CSharp.QuickFixes.LinqTools
{
    
    public class ConvertForToForeachFix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public ConvertForToForeachFix(JetBrains.ReSharper.Daemon.CSharp.Errors.ForCanBeConvertedToForeachWarning warning) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder holder) { }
    }
}
namespace JetBrains.ReSharper.Intentions.CSharp.QuickFixes.UsageChecking
{
    
    public class CSharpConfigureAnnotationsFix : JetBrains.ReSharper.Intentions.QuickFixes.UsageChecking.ConfigureAnnotationsFix
    {
        public CSharpConfigureAnnotationsFix(JetBrains.ReSharper.Daemon.CSharp.Errors.PossibleNullReferenceExceptionWarning error) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.CSharp.CSharpLanguage))]
    public class CSharpFixTypeHelper : JetBrains.ReSharper.Intentions.QuickFixes.UsageChecking.IFixTypeLanguageHelper
    {
        public void FixArrayLengthAccess(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public bool IsArrayLengthAccess(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.ILocalVariable> LocalsToCorrectType(JetBrains.ReSharper.Psi.IDeclaredElement element, JetBrains.ReSharper.Psi.IType newType, JetBrains.ReSharper.Psi.Tree.IExpression usage) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.CSharp.CSharpLanguage))]
    public class CSharpIntroduceFromParameterHelper : JetBrains.ReSharper.Intentions.QuickFixes.UsageChecking.IIntroduceFromParameterLanguageHelper
    {
        public CSharpIntroduceFromParameterHelper(JetBrains.Application.Settings.ISettingsStore settingsStore) { }
        public bool CaseSensitive { get; }
        public string IntroduceFieldPattern { get; }
        public void AddAssignmentToBody(JetBrains.ReSharper.Psi.Tree.IParametersOwnerDeclaration constructorDeclaration, JetBrains.ReSharper.Psi.Tree.IStatement anchorStatement, bool insertBefore, JetBrains.ReSharper.Psi.IParameter parameter, string memberName) { }
        public JetBrains.ReSharper.Psi.Tree.ITypeMemberDeclaration AddConstructorDeclaration(JetBrains.ReSharper.Psi.Tree.ITypeDeclaration typeDeclaration) { }
        public void AddConstructorDeclarationStubToStruct(JetBrains.ReSharper.Psi.Tree.ITypeDeclaration structDeclaration) { }
        public JetBrains.ReSharper.Psi.Tree.IParameterDeclaration AddConstructorParameter(JetBrains.ReSharper.Psi.Tree.ITypeMemberDeclaration ctorDeclaration, string name, JetBrains.ReSharper.Psi.IType type) { }
        public void AddTypeMemberDeclaration(JetBrains.ReSharper.Psi.Tree.ITypeDeclaration targetTypeDeclaration, JetBrains.ReSharper.Psi.Tree.ITypeMemberDeclaration anchorMember, bool insertBefore, string pattern, string name, JetBrains.ReSharper.Psi.IType type) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Tree.IStatement> BodyStatements(JetBrains.ReSharper.Psi.Tree.IFunctionDeclaration functionDeclaration) { }
        public bool HasChainedConstructorInitializer(JetBrains.ReSharper.Psi.Tree.ITypeMemberDeclaration ctorDeclaration, out int argumentsCount, out JetBrains.ReSharper.Psi.IConstructor targetConstructor) { }
        public string IntroduceAutoPropertyPattern(JetBrains.ReSharper.Psi.Tree.ITreeNode context) { }
        public bool IsParameterToMemberAssignment(JetBrains.ReSharper.Psi.Tree.IStatement statement, out JetBrains.ReSharper.Psi.ITypeMember member, out JetBrains.ReSharper.Psi.IParameter parameter) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Tree.ITypeMemberDeclaration> NeighbourDeclarations(JetBrains.ReSharper.Psi.Tree.IParametersOwnerDeclaration constructorDeclaration) { }
        public void PassParameterToChainedConstructorInitializer(JetBrains.ReSharper.Psi.Tree.ITypeMemberDeclaration ctorDeclaration, string parameterName, int atIndex) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.CSharp.CSharpLanguage))]
    public class CSharpMakeReturnTypeVoidHelper : JetBrains.ReSharper.Intentions.QuickFixes.UsageChecking.IMakeReturnTypeVoidLanguageHelper
    {
        public string QuickFixText { get; }
        public bool IsReturnScope(JetBrains.ReSharper.Psi.Tree.ITreeNode node) { }
        public bool IsReturnStatement(JetBrains.ReSharper.Psi.Tree.IStatement statement, out JetBrains.ReSharper.Psi.Tree.IExpression returnValue) { }
        public void RemoveReturnValue(JetBrains.ReSharper.Psi.Tree.IStatement statement, out JetBrains.ReSharper.Psi.Tree.IStatement expressionStatementLeft) { }
    }
    [JetBrains.ReSharper.Feature.Services.CodeCleanup.HighlightingModule.HighlightingCleanupItemAttribute(new JetBrains.ReSharper.Daemon.Severity[0])]
    public class CSharpRemoveLabelFix : JetBrains.ReSharper.Intentions.CSharp.QuickFixes.RedundancyHighlightingCleanupItemQuickFixBase
    {
        public CSharpRemoveLabelFix(JetBrains.ReSharper.Daemon.UsageChecking.UnusedLabelWarning error) { }
        protected override string BulkText { get; }
        public override string Text { get; }
        protected override void ExecutePsiTransaction() { }
        protected override JetBrains.ProjectModel.IProjectFile GetProjectFile() { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder userDataHolder) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.CSharp.CSharpLanguage))]
    public class CSharpRemoveUnusedVarHelper : JetBrains.ReSharper.Intentions.QuickFixes.UsageChecking.IRemoveUnusedVarHelper
    {
        public bool CanRemoveUsage(JetBrains.ReSharper.Psi.Tree.IExpression usage) { }
        public bool CanRemoveVariableDeclaration(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration) { }
        public void RemoveUsage(JetBrains.ReSharper.Psi.Tree.IExpression usage, out JetBrains.ReSharper.Psi.Tree.ITreeNode rangeToHighlight) { }
        public void RemoveVariableDeclaration(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration, out JetBrains.ReSharper.Psi.Tree.ITreeNode rangeToHighlight) { }
    }
    public class CSharpToConstFix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public CSharpToConstFix(JetBrains.ReSharper.Daemon.UsageChecking.ConvertToConstantWarningBase error) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class InitializeAutoPropertyFromContructorsFix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public InitializeAutoPropertyFromContructorsFix(JetBrains.ReSharper.Daemon.UsageChecking.UnusedAutoPropertyAccessorWarningBase error) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
}
namespace JetBrains.ReSharper.Intentions.CSharp.Util
{
    
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.CSharp.CSharpLanguage))]
    public class CSharpCommentCodeHelper : JetBrains.ReSharper.Intentions.Util.ICommentCodeLanguageHelper
    {
        public bool CanCommentDeclaration(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration) { }
        public System.Action CommentDeclaration(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration) { }
        public System.Action CommentTextRange(JetBrains.ReSharper.Psi.Tree.IFile file, JetBrains.ReSharper.Psi.TreeTextRange range, JetBrains.DocumentModel.IDocument document) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.CSharp.CSharpLanguage))]
    public class CSharpSetBodyUtil : JetBrains.ReSharper.Intentions.Util.SetBodyUtil
    {
        protected override JetBrains.ReSharper.Psi.Tree.IFunctionDeclaration EnsureAccessor(JetBrains.ReSharper.Psi.Tree.ITypeMemberDeclaration destination, JetBrains.ReSharper.Psi.AccessorKind kind) { }
        public override void SetBody(JetBrains.ReSharper.Psi.Tree.IFunctionDeclaration destination, JetBrains.ReSharper.Psi.Tree.ITreeNode body) { }
    }
    public class static EqualsUtil
    {
        public static JetBrains.ReSharper.Psi.IMethod GetStaticEqualsMethod(JetBrains.ReSharper.Psi.Modules.IPsiModule module, JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext resolveContext) { }
    }
}
namespace JetBrains.ReSharper.Intentions.Xml.ContextActions
{
    
    public class CSharpXmlDocContextActionDataProvider : JetBrains.ReSharper.Feature.Services.Xml.Bulbs.XmlContextActionDataProvider
    {
        protected CSharpXmlDocContextActionDataProvider(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl, JetBrains.ReSharper.Psi.Xml.Tree.IXmlFile xmlFile, JetBrains.ReSharper.Feature.Services.Xml.Bulbs.IXmlContextActionProvider contextActionProvider) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Intentions.Xml.ContextActions.CSharpXmlDocContextActionDataProvider Create([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.ISolution solution, [JetBrains.Annotations.NotNullAttribute()] JetBrains.TextControl.ITextControl textControl) { }
    }
}