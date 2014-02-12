[assembly: JetBrains.ReSharper.Daemon.ConfigurableSeverityImplementedForLanguageAttribute(typeof(JetBrains.ReSharper.Daemon.UsageChecking.UnusedMemberGlobalWarning), "JAVA_SCRIPT")]
[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("MisuseOfOwnerFunctionThis", null, "CodeSmell", "Misuse of \'this\' qualifier in inner function", "Property with qualifier \'this\' that is used in an inner function matches by name " +
    "with property defined in the outer function.", JetBrains.ReSharper.Daemon.Severity.WARNING, false, Internal=false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("ErrorInXmlDocReference", null, "CodeSmell", "Error in Xml doc comment reference", "Error in Xml doc comment reference.", JetBrains.ReSharper.Daemon.Severity.ERROR, false, Internal=false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("ParameterValueIsNotUsed", null, "CodeSmell", "Parameter value is not used", "Parameter value is not used because it is overridden in the function body.", JetBrains.ReSharper.Daemon.Severity.WARNING, false, Internal=false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("ElidedTrailingElement", null, "CodeSmell", "A trailing element of an array is elided", "If an element is elided at the end of an array, that element does not contribute " +
    "to the length of the Array.", JetBrains.ReSharper.Daemon.Severity.WARNING, false, Internal=false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("UnusedProperty", null, "DeclarationRedundancy", "Unused property or function", "Property or function is declared but never used.", JetBrains.ReSharper.Daemon.Severity.WARNING, true, Internal=false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("UsageOfDefinitelyUnassignedValue", null, "CodeSmell", "Usage of unassigned local variable", "Variable is used but is wasn\'t assigned a value.", JetBrains.ReSharper.Daemon.Severity.WARNING, false, Internal=false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("TsDeclarationHides", null, "CodeSmell", "Declaration hides declaration from outer scope", "Declaration hides declaration from outer scope.", JetBrains.ReSharper.Daemon.Severity.WARNING, false, Internal=false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("LValueIsExpected", null, "CodeSmell", "L-value expected error", "Use of inappropriate value to the left of assignment operator", JetBrains.ReSharper.Daemon.Severity.ERROR, false, Internal=false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("MultipleDeclarationsInForeach", null, "CodeSmell", "Multiple declarations in \'for in\' error", "Multiple variable declarations are not allowed in \'for-in\' loop", JetBrains.ReSharper.Daemon.Severity.ERROR, false, Internal=false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("LabelOrSemicolonExpected", null, "CodeSmell", "Use of expression after break or continue", "\'break\' and \'continue\' statements can only be followed by label name", JetBrains.ReSharper.Daemon.Severity.ERROR, false, Internal=false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("ThrowMustBeFollowedByExpression", null, "CodeSmell", "Expression is expected after \'throw\' statement", "\'throw\' statement should be followed by expression", JetBrains.ReSharper.Daemon.Severity.ERROR, false, Internal=false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("PropertyGetterCannotHaveParameters", null, "CodeSmell", "Property getter cannot have parameters", "Property getter cannot have parameters", JetBrains.ReSharper.Daemon.Severity.ERROR, false, Internal=false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("PropertySetterMustHaveSingleParameter", null, "CodeSmell", "Property setter must have a single parameter", "Property setter must have a single parameter", JetBrains.ReSharper.Daemon.Severity.ERROR, false, Internal=false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("EmptyObjectPropertyDeclaration", null, "CodeSmell", "Object property declaration is expected", "Object property declaration is expected", JetBrains.ReSharper.Daemon.Severity.ERROR, false, Internal=false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("NotResolved", null, "CodeSmell", "Cannot resolve symbol", "Cannot resolve symbol", JetBrains.ReSharper.Daemon.Severity.WARNING, false, Internal=false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("JsUnreachableCode", null, "CodeRedundancy", "Unreachable code", "\\n          Code is unreachable\\n        ", JetBrains.ReSharper.Daemon.Severity.WARNING, false, Internal=false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("AssignedValueIsNeverUsed", null, "CodeRedundancy", "Assigned value is never used", "\\n          A variable was assigned a value but never used\\n        ", JetBrains.ReSharper.Daemon.Severity.WARNING, false, Internal=false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("JumpMustBeInLoop", null, "CodeSmell", "Use \'break\' or \'continue\' outside of loop body", "\\n          \'break\' and \'continue\' without label should be in a loop body\\n      " +
    "  ", JetBrains.ReSharper.Daemon.Severity.WARNING, false, Internal=false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("UnusedParameter", null, "DeclarationRedundancy", "Unused parameter", "Parameter of function is declared but never used.", JetBrains.ReSharper.Daemon.Severity.WARNING, false, Internal=false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("UnusedLocals", null, "DeclarationRedundancy", "Unused local variable of function", "Local variable or function is declared but never used.", JetBrains.ReSharper.Daemon.Severity.WARNING, false, Internal=false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("DuplicatingLocalDeclaration", null, "DeclarationRedundancy", "Duplicate local declaration", "Duplicate declaration of a local variable, function or parameter.", JetBrains.ReSharper.Daemon.Severity.WARNING, false, Internal=false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("UsingOfReservedWord", null, "BestPractice", "Use of future reserved word", "The word is reserved for future versions of ECMAScript.", JetBrains.ReSharper.Daemon.Severity.WARNING, false, Internal=false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("StatementIsNotTerminated", null, "BestPractice", "Statement is not terminated with semicolon", "Semicolon is missing at the end of the statement.", JetBrains.ReSharper.Daemon.Severity.WARNING, false, Internal=false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("HeuristicallyUnreachableCode", null, "CodeSmell", "Heuristically unreachable code", "Heuristically unreachable code.", JetBrains.ReSharper.Daemon.Severity.WARNING, false, Internal=false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("ExpressionIsAlwaysConst", null, "CodeSmell", "Expression is always constant", "Expression is always constant.", JetBrains.ReSharper.Daemon.Severity.WARNING, false, Internal=false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("QualifiedExpressionMaybeNull", null, "CodeSmell", "Qualifier can be \'null\' or \'undefined\'", "Qualifier can be \'null\' or \'undefined\'.", JetBrains.ReSharper.Daemon.Severity.WARNING, false, Internal=false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("QualifiedExpressionIsNull", null, "CodeSmell", "Qualifier is \'null\' or \'undefined\'", "Qualifier is \'null\' or \'undefined\'.", JetBrains.ReSharper.Daemon.Severity.WARNING, false, Internal=false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("InvokedExpressionMaybeNonFunction", null, "CodeSmell", "Invoked expression is not a function value", "Invoked expression is not a function value.", JetBrains.ReSharper.Daemon.Severity.WARNING, false, Internal=false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("InvocationOfNonFunction", null, "CodeSmell", "Invocation of non-function expression", "Invocation of non-function expression.", JetBrains.ReSharper.Daemon.Severity.WARNING, false, Internal=false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("ConditionIsAlwaysConst", null, "CodeSmell", "Condition is always constant", "Condition is always constant.", JetBrains.ReSharper.Daemon.Severity.WARNING, false, Internal=false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("DuplicatingPropertyDeclaration", null, "CodeSmell", "Duplicate property declaration", "Duplicate declaration of a literal object property.", JetBrains.ReSharper.Daemon.Severity.WARNING, false, Internal=false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("DuplicatingSwitchLabel", null, "CodeSmell", "Duplicate switch label", "Duplicate switch label.", JetBrains.ReSharper.Daemon.Severity.WARNING, false, Internal=false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("WrongExpressionStatement", null, "CodeSmell", "Suspicious expression statement", "Expression statement is neither an assignment statement nor a function call.", JetBrains.ReSharper.Daemon.Severity.WARNING, false, Internal=false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("ThisInGlobalContext", null, "CodeSmell", "Use of \'this\' in global context", "Use of \'this\' in global context.", JetBrains.ReSharper.Daemon.Severity.WARNING, false, Internal=false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("XmlDocCommentSyntaxProblem", null, "CodeSmell", "Illegal syntax in XML code comment", "Illegal syntax in XML code comment.", JetBrains.ReSharper.Daemon.Severity.WARNING, false, Internal=false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("AssignToImplicitGlobalInFunctionScope", null, "CodeSmell", "Assignment to an implicitly declared global variable", "Assignment to an implicitly declared global variable.", JetBrains.ReSharper.Daemon.Severity.WARNING, false, Internal=false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("UseOfImplicitGlobalInFunctionScope", null, "CodeSmell", "Use of implicitly declared global variable", "Use of implicitly declared global variable.", JetBrains.ReSharper.Daemon.Severity.WARNING, false, Internal=false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("PossiblyUnassignedProperty", null, "CodeSmell", "Use of possibly unassigned property or global variable", "\\n          Use of possibly unassigned property or global variable.\\n        ", JetBrains.ReSharper.Daemon.Severity.HINT, false, Internal=false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("InconsistentFunctionReturns", null, "CodeSmell", "Inconsistent function returns", "Some of function exits return value but the others don\'t.", JetBrains.ReSharper.Daemon.Severity.WARNING, false, Internal=false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("ReturnFromGlobalScopetWithValue", null, "CodeSmell", "Return statement with a value in the global scope", "Return statement with a value in the global scope.", JetBrains.ReSharper.Daemon.Severity.WARNING, false, Internal=false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("NotAllPathsReturnValue", null, "CodeSmell", "Not all code paths return a value", "Function has return statements with specified value but there are execution paths" +
    " that don\'t contain any return statement.", JetBrains.ReSharper.Daemon.Severity.WARNING, false, Internal=false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("UsageOfPossiblyUnassignedValue", null, "CodeSmell", "Usage of possibly unassigned local variable", "Variable is assigned not on all execution paths.", JetBrains.ReSharper.Daemon.Severity.WARNING, false, Internal=false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterStaticHighlightingsGroupAttribute("TypeScriptErrors", "TypeScript Compiler Errors", true)]
[assembly: JetBrains.ReSharper.Daemon.RegisterStaticHighlightingsGroupAttribute("JScriptErrors", "JavaScript Errors", true)]
[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]

namespace JetBrains.ReSharper.Daemon.JavaScript.Errors
{
    
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "JScriptErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class JSSyntaxError : JetBrains.ReSharper.Daemon.Impl.SyntaxErrorBase, JetBrains.ReSharper.Daemon.IHighlighting, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public JSSyntaxError(string toolTip, JetBrains.DocumentModel.DocumentRange range) { }
        public JetBrains.DocumentModel.DocumentRange CalculateRange() { }
    }
}
namespace JetBrains.ReSharper.Daemon.JavaScript.Highlightings
{
    
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.INFO, "IdentifierHighlightings", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.DEADCODE, ShowToolTipInStatusBar=false)]
    public sealed class JavaScriptDocCommentHighlighting : JetBrains.ReSharper.Daemon.ICustomAttributeIdHighlighting, JetBrains.ReSharper.Daemon.IHighlighting
    {
        public JavaScriptDocCommentHighlighting(string attributeId) { }
        public string AttributeId { get; }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public bool IsValid() { }
    }
    public abstract class JavaScriptHighlightingBase : JetBrains.ReSharper.Daemon.IHighlighting
    {
        public abstract bool IsValid();
    }
    [JetBrains.ReSharper.Daemon.DaemonTooltipProviderAttribute(typeof(JetBrains.ReSharper.Daemon.JavaScript.Prelude.JavaScriptIdentifierTooltipProvider))]
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.INFO, "IdentifierHighlightings", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.NONE, ShowToolTipInStatusBar=false)]
    public sealed class JavaScriptIdentifierHighlighting : JetBrains.ReSharper.Daemon.ICustomAttributeIdHighlighting, JetBrains.ReSharper.Daemon.IHighlighting
    {
        public JavaScriptIdentifierHighlighting(string attributeId) { }
        public string AttributeId { get; }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public bool IsValid() { }
    }
}
namespace JetBrains.ReSharper.Daemon.JavaScript.Impl
{
    
    public abstract class JavaScriptDaemonStageBase : JetBrains.ReSharper.Daemon.IDaemonStage
    {
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Daemon.IDaemonStageProcess> CreateProcess(JetBrains.ReSharper.Daemon.IDaemonProcess process, JetBrains.Application.Settings.IContextBoundSettingsStore settings, JetBrains.ReSharper.Daemon.DaemonProcessKind processKind) { }
        protected abstract JetBrains.ReSharper.Daemon.IDaemonStageProcess CreateProcess(JetBrains.ReSharper.Daemon.IDaemonProcess process, JetBrains.Application.Settings.IContextBoundSettingsStore settings, JetBrains.ReSharper.Daemon.DaemonProcessKind processKind, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptFile file);
        protected virtual bool IsSupported(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
        public abstract JetBrains.ReSharper.Daemon.ErrorStripeRequest NeedsErrorStripe(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, JetBrains.Application.Settings.IContextBoundSettingsStore settings);
    }
    public abstract class JavaScriptDaemonStageProcessBase : JetBrains.ReSharper.Psi.JavaScript.Tree.TreeNodeVisitor<JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer>, JetBrains.ReSharper.Daemon.IDaemonStageProcess, JetBrains.ReSharper.Psi.IRecursiveElementProcessor<JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer>
    {
        protected readonly JetBrains.ReSharper.Daemon.IDaemonProcess myDaemonProcess;
        protected readonly JetBrains.Application.Settings.IContextBoundSettingsStore mySettingsStore;
        protected JavaScriptDaemonStageProcessBase(JetBrains.ReSharper.Daemon.IDaemonProcess process, JetBrains.Application.Settings.IContextBoundSettingsStore settingsStore, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptFile file) { }
        public JetBrains.ReSharper.Daemon.IDaemonProcess DaemonProcess { get; }
        protected internal JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptFile File { get; }
        protected JetBrains.ReSharper.Psi.IPsiServices PsiServices { get; }
        protected JetBrains.Application.Settings.IContextBoundSettingsStore SettingsStore { get; }
        public abstract void Execute(System.Action<JetBrains.ReSharper.Daemon.DaemonStageResult> committer);
        protected void HighlightInFile(System.Action<JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptFile, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer> fileHighlighter, System.Action<JetBrains.ReSharper.Daemon.DaemonStageResult> commiter) { }
        public virtual bool InteriorShouldBeProcessed(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer context) { }
        public bool IsProcessingFinished(JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer context) { }
        public virtual void ProcessAfterInterior(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer consumer) { }
        public virtual void ProcessBeforeInterior(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer consumer) { }
    }
}
namespace JetBrains.ReSharper.Daemon.JavaScript.Prelude
{
    
    public class JavaScriptFileStructure : JetBrains.ReSharper.Daemon.Stages.FileStructureBase
    {
        public JavaScriptFileStructure(JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptFile file) { }
    }
    [JetBrains.ReSharper.Daemon.Stages.FileStructureExplorerAttribute()]
    public class JavaScriptFileStructureExplorer : JetBrains.ReSharper.Daemon.Stages.IFileStructureExplorer
    {
        public JetBrains.ReSharper.Daemon.Stages.IFileStructure Run(System.Predicate<JetBrains.DocumentModel.DocumentRange> isRangeInvalidated, JetBrains.ReSharper.Psi.IPsiSourceFile psiSourceFile, JetBrains.Application.Settings.IContextBoundSettingsStore settingsStore, JetBrains.ReSharper.Psi.Tree.IFile file1) { }
    }
    [JetBrains.ProjectModel.ProjectFileTypeAttribute(typeof(JetBrains.ProjectModel.JavaScriptProjectFileType))]
    public class JavaScriptSyntaxHighlighting : JetBrains.ReSharper.Daemon.SyntaxHighlighting
    {
        public JavaScriptSyntaxHighlighting(JetBrains.ProjectModel.JavaScriptProjectFileType projectFileType, JetBrains.ProjectModel.SolutionsManager solutionManager, JetBrains.TextControl.DefaultTextControlSchemeManager defaultTextControlSchemeManager) { }
        public override JetBrains.Util.TextRange GetAttributesForOffset(JetBrains.TextControl.ITextControl textControl, int offset, out JetBrains.TextControl.DocumentMarkup.HighlighterAttributes attributes) { }
    }
}
namespace JetBrains.ReSharper.Daemon.JavaScript.Prelude.TypeScript
{
    
    public abstract class TsDaemonStageProcessBase : JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.TsTreeNodeVisitor<JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer>, JetBrains.ReSharper.Daemon.IDaemonStageProcess, JetBrains.ReSharper.Psi.IRecursiveElementProcessor<JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer>
    {
        protected readonly JetBrains.ReSharper.Daemon.IDaemonProcess myDaemonProcess;
        protected readonly JetBrains.Application.Settings.IContextBoundSettingsStore mySettingsStore;
        protected TsDaemonStageProcessBase(JetBrains.ReSharper.Daemon.IDaemonProcess process, JetBrains.Application.Settings.IContextBoundSettingsStore settingsStore, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptFile file) { }
        public JetBrains.ReSharper.Daemon.IDaemonProcess DaemonProcess { get; }
        protected internal JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptFile File { get; }
        protected JetBrains.ReSharper.Psi.IPsiServices PsiServices { get; }
        protected JetBrains.Application.Settings.IContextBoundSettingsStore SettingsStore { get; }
        public abstract void Execute(System.Action<JetBrains.ReSharper.Daemon.DaemonStageResult> committer);
        protected void HighlightInFile(System.Action<JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptFile, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer> fileHighlighter, System.Action<JetBrains.ReSharper.Daemon.DaemonStageResult> commiter) { }
        public virtual bool InteriorShouldBeProcessed(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer context) { }
        public bool IsProcessingFinished(JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer context) { }
        public virtual void ProcessAfterInterior(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer consumer) { }
        public virtual void ProcessBeforeInterior(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer consumer) { }
    }
}
namespace JetBrains.ReSharper.Daemon.JavaScript.Stages
{
    
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "TypeScriptErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR, ToolTipFormatString="Property accessors may not be declared in ambient classes")]
    public class AccessorIsNotAllowedInAmbientDeclaraionsError : JetBrains.ReSharper.Daemon.JavaScript.Highlightings.JavaScriptHighlightingBase, JetBrains.ReSharper.Daemon.IHighlighting, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "Property accessors may not be declared in ambient classes";
        public AccessorIsNotAllowedInAmbientDeclaraionsError(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsMemberAccessorDeclaration accessor) { }
        public JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsMemberAccessorDeclaration Accessor { get; }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "TypeScriptErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR, ToolTipFormatString="Ambient declaration can not have body")]
    public class AmbientFunctionHasBodyError : JetBrains.ReSharper.Daemon.JavaScript.Highlightings.JavaScriptHighlightingBase, JetBrains.ReSharper.Daemon.IHighlighting, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "Ambient declaration can not have body";
        public AmbientFunctionHasBodyError(JetBrains.ReSharper.Psi.Tree.ITreeNode lBraceNode, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsFunctionStatementSignature signature) { }
        public string ErrorStripeToolTip { get; }
        public JetBrains.ReSharper.Psi.Tree.ITreeNode LBraceNode { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsFunctionStatementSignature Signature { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "TypeScriptErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR, ToolTipFormatString="Ambient declarations can not have initializer.")]
    public class AmbientHasInitializerError : JetBrains.ReSharper.Daemon.JavaScript.Highlightings.JavaScriptHighlightingBase, JetBrains.ReSharper.Daemon.IHighlighting, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "Ambient declarations can not have initializer.";
        public AmbientHasInitializerError(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsVariableDeclaration declaration) { }
        public JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsVariableDeclaration Declaration { get; }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "TypeScriptErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR, ToolTipFormatString="Ambient {0} can not have body")]
    public class AmbientMemberHasBodyError : JetBrains.ReSharper.Daemon.JavaScript.Highlightings.JavaScriptHighlightingBase, JetBrains.ReSharper.Daemon.IHighlighting, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "Ambient {0} can not have body";
        public AmbientMemberHasBodyError(JetBrains.ReSharper.Psi.Tree.ITreeNode lBraceNode, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsClassMemberDeclaration signature, string myName) { }
        public string ErrorStripeToolTip { get; }
        public JetBrains.ReSharper.Psi.Tree.ITreeNode LBraceNode { get; }
        public string MyName { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsClassMemberDeclaration Signature { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("WrongExpressionStatement", "JAVA_SCRIPT", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.WARNING, ToolTipFormatString="Anonymous function is used as declaration")]
    public class AnonymousFunctionUsedAsExpressionsStatementWarning : JetBrains.ReSharper.Daemon.JavaScript.Highlightings.JavaScriptHighlightingBase, JetBrains.ReSharper.Daemon.IHighlighting, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "WrongExpressionStatement";
        protected const string MESSAGE = "Anonymous function is used as declaration";
        public AnonymousFunctionUsedAsExpressionsStatementWarning(JetBrains.ReSharper.Psi.JavaScript.Tree.IFunctionExpression functionExpression) { }
        public string ErrorStripeToolTip { get; }
        public JetBrains.ReSharper.Psi.JavaScript.Tree.IFunctionExpression FunctionExpression { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "TypeScriptErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR, ToolTipFormatString="Parameters in signatures may not have default values, use \'?\' to specify optional" +
        " parameters")]
    public class ArgumentsInSignaturesMayNotHaveDefaultValuesError : JetBrains.ReSharper.Daemon.JavaScript.Highlightings.JavaScriptHighlightingBase, JetBrains.ReSharper.Daemon.IHighlighting, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "Parameters in signatures may not have default values, use \'?\' to specify optional" +
            " parameters";
        public ArgumentsInSignaturesMayNotHaveDefaultValuesError(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsParameterDeclaration parameter) { }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsParameterDeclaration Parameter { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("AssignedValueIsNeverUsed", "JAVA_SCRIPT", AttributeId="ReSharper Dead Code", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.DEADCODE, ToolTipFormatString="Value assigned is not used in any execution path")]
    public class AssignedValueIsNeverUsedWarning : JetBrains.ReSharper.Daemon.JavaScript.Highlightings.JavaScriptHighlightingBase, JetBrains.ReSharper.Daemon.IHighlighting, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "AssignedValueIsNeverUsed";
        protected const string MESSAGE = "Value assigned is not used in any execution path";
        public AssignedValueIsNeverUsedWarning(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.ITreeRange treeRange) { }
        public JetBrains.ReSharper.Psi.Tree.ITreeNode Element { get; }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public JetBrains.ReSharper.Psi.ITreeRange TreeRange { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("AssignToImplicitGlobalInFunctionScope", "JAVA_SCRIPT", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.WARNING, ToolTipFormatString="Assignment to an implicitly declared global variable \'{0}\'")]
    public class AssignToImplicitGlobalInFunctionScopeWarning : JetBrains.ReSharper.Daemon.JavaScript.Highlightings.JavaScriptHighlightingBase, JetBrains.ReSharper.Daemon.IHighlighting, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "AssignToImplicitGlobalInFunctionScope";
        protected const string MESSAGE = "Assignment to an implicitly declared global variable \'{0}\'";
        public AssignToImplicitGlobalInFunctionScopeWarning(JetBrains.ReSharper.Psi.JavaScript.Tree.IBinaryExpression expression, string variableName) { }
        public string ErrorStripeToolTip { get; }
        public JetBrains.ReSharper.Psi.JavaScript.Tree.IBinaryExpression Expression { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public string VariableName { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "TypeScriptErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR, ToolTipFormatString="\'Rest\' parameter can not have optional mark \'?\'")]
    public class CanNotUseDefaultValueForParametersOfAmbientDeclarationsError : JetBrains.ReSharper.Daemon.JavaScript.Highlightings.JavaScriptHighlightingBase, JetBrains.ReSharper.Daemon.IHighlighting, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "\'Rest\' parameter can not have optional mark \'?\'";
        public CanNotUseDefaultValueForParametersOfAmbientDeclarationsError(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsParameterDeclaration parameter) { }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsParameterDeclaration Parameter { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "TypeScriptErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR, ToolTipFormatString="Class can only extend one other class")]
    public class ClassCanOnlyExtendOneOtherClassError : JetBrains.ReSharper.Daemon.JavaScript.Highlightings.JavaScriptHighlightingBase, JetBrains.ReSharper.Daemon.IHighlighting, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "Class can only extend one other class";
        public ClassCanOnlyExtendOneOtherClassError(JetBrains.ReSharper.Psi.Tree.ITreeNode typeUsageNode) { }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public JetBrains.ReSharper.Psi.Tree.ITreeNode TypeUsageNode { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("ConditionIsAlwaysConst", "JAVA_SCRIPT", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.WARNING, ToolTipFormatString="Condition is always \'{0}\'.")]
    public class ConditionIsAlwaysConstWarning : JetBrains.ReSharper.Daemon.JavaScript.Highlightings.JavaScriptHighlightingBase, JetBrains.ReSharper.Daemon.IHighlighting, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "ConditionIsAlwaysConst";
        protected const string MESSAGE = "Condition is always \'{0}\'.";
        public ConditionIsAlwaysConstWarning(JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression expression, bool value) { }
        public string ErrorStripeToolTip { get; }
        public JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression Expression { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public bool Value { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("DuplicatingLocalDeclaration", "JAVA_SCRIPT", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.WARNING, ToolTipFormatString="Declaration hides {0} from outer scope")]
    public class DeclarationHidesWarning : JetBrains.ReSharper.Daemon.JavaScript.Highlightings.JavaScriptHighlightingBase, JetBrains.ReSharper.Daemon.IHighlighting, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "DuplicatingLocalDeclaration";
        protected const string MESSAGE = "Declaration hides {0} from outer scope";
        public DeclarationHidesWarning(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration, JetBrains.ReSharper.Psi.IDeclaredElement hiddenElement) { }
        public JetBrains.ReSharper.Psi.Tree.IDeclaration Declaration { get; }
        public string ErrorStripeToolTip { get; }
        public JetBrains.ReSharper.Psi.IDeclaredElement HiddenElement { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("XmlDocCommentSyntaxProblem", "JAVA_SCRIPT", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.WARNING, ToolTipFormatString="{0}")]
    public class DocCommentXmlSyntaxWarning : JetBrains.ReSharper.Daemon.JavaScript.Highlightings.JavaScriptHighlightingBase, JetBrains.ReSharper.Daemon.IHighlighting, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "XmlDocCommentSyntaxProblem";
        protected const string MESSAGE = "{0}";
        public DocCommentXmlSyntaxWarning(JetBrains.ReSharper.Daemon.IHighlighting baseHighlighting, JetBrains.DocumentModel.DocumentRange documentRange) { }
        public JetBrains.ReSharper.Daemon.IHighlighting BaseHighlighting { get; }
        public JetBrains.DocumentModel.DocumentRange DocumentRange { get; }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "TypeScriptErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR, ToolTipFormatString="Duplicate ambient declaration in this context. (Is the enclosing module or class " +
        "already ambient?)")]
    public class DuplicateAmbientDeclarationError : JetBrains.ReSharper.Daemon.JavaScript.Highlightings.JavaScriptHighlightingBase, JetBrains.ReSharper.Daemon.IHighlighting, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "Duplicate ambient declaration in this context. (Is the enclosing module or class " +
            "already ambient?)";
        public DuplicateAmbientDeclarationError(JetBrains.ReSharper.Psi.Tree.ITreeNode modifier) { }
        public string ErrorStripeToolTip { get; }
        public JetBrains.ReSharper.Psi.Tree.ITreeNode Modifier { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "TypeScriptErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR, ToolTipFormatString="Duplicated modifier.")]
    public class DuplicateModifierError : JetBrains.ReSharper.Daemon.JavaScript.Highlightings.JavaScriptHighlightingBase, JetBrains.ReSharper.Daemon.IHighlighting, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "Duplicated modifier.";
        public DuplicateModifierError(JetBrains.ReSharper.Psi.Tree.ITreeNode modifierNode) { }
        public string ErrorStripeToolTip { get; }
        public JetBrains.ReSharper.Psi.Tree.ITreeNode ModifierNode { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("DuplicatingLocalDeclaration", "JAVA_SCRIPT", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.WARNING, ToolTipFormatString="Duplicate declaration")]
    public class DuplicatingLocalDeclarationWarning : JetBrains.ReSharper.Daemon.JavaScript.Highlightings.JavaScriptHighlightingBase, JetBrains.ReSharper.Daemon.IHighlighting, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "DuplicatingLocalDeclaration";
        protected const string MESSAGE = "Duplicate declaration";
        public DuplicatingLocalDeclarationWarning(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration) { }
        public JetBrains.ReSharper.Psi.Tree.IDeclaration Declaration { get; }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("DuplicatingPropertyDeclaration", "JAVA_SCRIPT", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.WARNING, ToolTipFormatString="Duplicate property declaration")]
    public class DuplicatingPropertyDeclarationWarning : JetBrains.ReSharper.Daemon.JavaScript.Highlightings.JavaScriptHighlightingBase, JetBrains.ReSharper.Daemon.IHighlighting, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "DuplicatingPropertyDeclaration";
        protected const string MESSAGE = "Duplicate property declaration";
        public DuplicatingPropertyDeclarationWarning(JetBrains.ReSharper.Psi.JavaScript.Tree.IObjectPropertyDeclaration declaration) { }
        public JetBrains.ReSharper.Psi.JavaScript.Tree.IObjectPropertyDeclaration Declaration { get; }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("DuplicatingSwitchLabel", "JAVA_SCRIPT", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.WARNING, ToolTipFormatString="Duplicate switch label")]
    public class DuplicatingSwitchLabelWarning : JetBrains.ReSharper.Daemon.JavaScript.Highlightings.JavaScriptHighlightingBase, JetBrains.ReSharper.Daemon.IHighlighting, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "DuplicatingSwitchLabel";
        protected const string MESSAGE = "Duplicate switch label";
        public DuplicatingSwitchLabelWarning(JetBrains.ReSharper.Psi.JavaScript.Tree.ICaseCaseClause caseClause) { }
        public JetBrains.ReSharper.Psi.JavaScript.Tree.ICaseCaseClause CaseClause { get; }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("ElidedTrailingElement", "JAVA_SCRIPT", AttributeId="ReSharper Warning", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.WARNING, ToolTipFormatString="When element is elided at the end of an array, that element does not contribute t" +
        "o the length of the Array.")]
    public class ElidedTrailingElementWarning : JetBrains.ReSharper.Daemon.JavaScript.Highlightings.JavaScriptHighlightingBase, JetBrains.ReSharper.Daemon.IHighlighting, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "ElidedTrailingElement";
        protected const string MESSAGE = "When element is elided at the end of an array, that element does not contribute t" +
            "o the length of the Array.";
        public ElidedTrailingElementWarning(JetBrains.DocumentModel.DocumentRange documentRange, JetBrains.ReSharper.Psi.JavaScript.Tree.IArrayLiteral arrayLiteral) { }
        public JetBrains.ReSharper.Psi.JavaScript.Tree.IArrayLiteral ArrayLiteral { get; }
        public JetBrains.DocumentModel.DocumentRange DocumentRange { get; }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("EmptyObjectPropertyDeclaration", "JAVA_SCRIPT", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR, ToolTipFormatString="Object property declaration is expected")]
    public class EmptyObjectPropertyDeclarationError : JetBrains.ReSharper.Daemon.JavaScript.Highlightings.JavaScriptHighlightingBase, JetBrains.ReSharper.Daemon.IHighlighting, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "EmptyObjectPropertyDeclaration";
        protected const string MESSAGE = "Object property declaration is expected";
        public EmptyObjectPropertyDeclarationError(JetBrains.ReSharper.Psi.Tree.ITreeNode firstNode, JetBrains.ReSharper.Psi.Tree.ITreeNode lastNode, JetBrains.DocumentModel.DocumentRange documentRange) { }
        public JetBrains.DocumentModel.DocumentRange DocumentRange { get; }
        public string ErrorStripeToolTip { get; }
        public JetBrains.ReSharper.Psi.Tree.ITreeNode FirstNode { get; }
        public JetBrains.ReSharper.Psi.Tree.ITreeNode LastNode { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("ErrorInXmlDocReference", "JAVA_SCRIPT", AttributeId="ReSharper Warning", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.WARNING, ToolTipFormatString="{0}")]
    public class ErrorInXmlDocReferenceWarning : JetBrains.ReSharper.Daemon.JavaScript.Highlightings.JavaScriptHighlightingBase, JetBrains.ReSharper.Daemon.IHighlighting, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "ErrorInXmlDocReference";
        protected const string MESSAGE = "{0}";
        public ErrorInXmlDocReferenceWarning(JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptDocCommentBlockNode docCommentNode, JetBrains.ReSharper.Psi.Resolve.IPathReference pathReference, JetBrains.DocumentModel.DocumentRange documentRange, string tooltip) { }
        public JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptDocCommentBlockNode DocCommentNode { get; }
        public JetBrains.DocumentModel.DocumentRange DocumentRange { get; }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.Resolve.IPathReference PathReference { get; }
        public string Tooltip { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("ExpressionIsAlwaysConst", "JAVA_SCRIPT", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.WARNING, ToolTipFormatString="Expressions is always \'{0}\'.")]
    public class ExpressionIsAlwaysConstWarning : JetBrains.ReSharper.Daemon.JavaScript.Highlightings.JavaScriptHighlightingBase, JetBrains.ReSharper.Daemon.IHighlighting, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "ExpressionIsAlwaysConst";
        protected const string MESSAGE = "Expressions is always \'{0}\'.";
        public ExpressionIsAlwaysConstWarning(JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression expression, JetBrains.ReSharper.Psi.JavaScript.Impl.ControlFlow.Inspections.ValueAnalysis.Values.JsVariableStateExtended value) { }
        public string ErrorStripeToolTip { get; }
        public JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression Expression { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public JetBrains.ReSharper.Psi.JavaScript.Impl.ControlFlow.Inspections.ValueAnalysis.Values.JsVariableStateExtended Value { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "TypeScriptErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR, ToolTipFormatString="Function declaration should have implementation")]
    public class FunctionDoesntHaveBodyError : JetBrains.ReSharper.Daemon.JavaScript.Highlightings.JavaScriptHighlightingBase, JetBrains.ReSharper.Daemon.IHighlighting, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "Function declaration should have implementation";
        public FunctionDoesntHaveBodyError(JetBrains.ReSharper.Psi.Tree.ITreeNode semicolon, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsFunctionStatementSignature signature) { }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.Tree.ITreeNode Semicolon { get; }
        public JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsFunctionStatementSignature Signature { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "TypeScriptErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR, ToolTipFormatString="Function statement shoud have name")]
    public class FunctionStatementShouldDeclareNameError : JetBrains.ReSharper.Daemon.JavaScript.Highlightings.JavaScriptHighlightingBase, JetBrains.ReSharper.Daemon.IHighlighting, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "Function statement shoud have name";
        public FunctionStatementShouldDeclareNameError(JetBrains.ReSharper.Psi.Tree.ITreeNode functionKeyword, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsFunctionStatementSignature signature) { }
        public string ErrorStripeToolTip { get; }
        public JetBrains.ReSharper.Psi.Tree.ITreeNode FunctionKeyword { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsFunctionStatementSignature Signature { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "TypeScriptErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR, ToolTipFormatString="Property getter can not have parameters")]
    public class GetterCanNotHaveParametersError : JetBrains.ReSharper.Daemon.JavaScript.Highlightings.JavaScriptHighlightingBase, JetBrains.ReSharper.Daemon.IHighlighting, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "Property getter can not have parameters";
        public GetterCanNotHaveParametersError(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsMemberAccessorDeclaration accessor, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsParameterDeclaration parameter) { }
        public JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsMemberAccessorDeclaration Accessor { get; }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsParameterDeclaration Parameter { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("HeuristicallyUnreachableCode", "JAVA_SCRIPT", AttributeId="ReSharper Dead Code", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.DEADCODE, ToolTipFormatString="Code is heuristically unreachable")]
    public class HeuristicallyUnreachableCodeWarning : JetBrains.ReSharper.Daemon.JavaScript.Highlightings.JavaScriptHighlightingBase, JetBrains.ReSharper.Daemon.IHighlighting, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "HeuristicallyUnreachableCode";
        protected const string MESSAGE = "Code is heuristically unreachable";
        public HeuristicallyUnreachableCodeWarning(JetBrains.ReSharper.Psi.ITreeRange treeRange) { }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public JetBrains.ReSharper.Psi.ITreeRange TreeRange { get; }
        public override bool IsValid() { }
    }
    public class IdentifierHighlighterProcess : JetBrains.ReSharper.Daemon.JavaScript.Impl.JavaScriptDaemonStageProcessBase
    {
        public IdentifierHighlighterProcess(JetBrains.ReSharper.Daemon.Stages.Resolve.ResolveHighlighterRegistrar resolveHighlighterRegistrar, JetBrains.ReSharper.Daemon.IDaemonProcess daemonProcess, JetBrains.Application.Settings.IContextBoundSettingsStore settingsStore, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptFile file, JetBrains.ReSharper.Daemon.DaemonProcessKind processKind) { }
        public override void Execute(System.Action<JetBrains.ReSharper.Daemon.DaemonStageResult> committer) { }
        public override void VisitNode(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer consumer) { }
    }
    [JetBrains.ReSharper.Daemon.DaemonStageAttribute(StagesAfter=new System.Type[] {
            typeof(JetBrains.ReSharper.Daemon.UsageChecking.CollectUsagesStage)}, StagesBefore=new System.Type[] {
            typeof(JetBrains.ReSharper.Daemon.JavaScript.Stages.SmartResolver.SmartResolverStage)})]
    public class IdentifierHighlightingStage : JetBrains.ReSharper.Daemon.JavaScript.Impl.JavaScriptDaemonStageBase
    {
        public IdentifierHighlightingStage(JetBrains.ReSharper.Daemon.Stages.Resolve.ResolveHighlighterRegistrar resolveHighlighterRegistrar) { }
        protected override JetBrains.ReSharper.Daemon.IDaemonStageProcess CreateProcess(JetBrains.ReSharper.Daemon.IDaemonProcess process, JetBrains.Application.Settings.IContextBoundSettingsStore settings, JetBrains.ReSharper.Daemon.DaemonProcessKind processKind, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptFile file) { }
        public override JetBrains.ReSharper.Daemon.ErrorStripeRequest NeedsErrorStripe(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, JetBrains.Application.Settings.IContextBoundSettingsStore settings) { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "TypeScriptErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR, ToolTipFormatString="\'implements\' clause is unexpected for interface declaration, use \'extends\' instea" +
        "d")]
    public class ImplementsClauseIsUnexpectedError : JetBrains.ReSharper.Daemon.JavaScript.Highlightings.JavaScriptHighlightingBase, JetBrains.ReSharper.Daemon.IHighlighting, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "\'implements\' clause is unexpected for interface declaration, use \'extends\' instea" +
            "d";
        public ImplementsClauseIsUnexpectedError(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsImplementsClause implementsClause) { }
        public string ErrorStripeToolTip { get; }
        public JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsImplementsClause ImplementsClause { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("InconsistentFunctionReturns", "JAVA_SCRIPT", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.WARNING, ToolTipFormatString="Return statement should have value")]
    public class InconsistentFunctionReturnsWarning : JetBrains.ReSharper.Daemon.JavaScript.Highlightings.JavaScriptHighlightingBase, JetBrains.ReSharper.Daemon.IHighlighting, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "InconsistentFunctionReturns";
        protected const string MESSAGE = "Return statement should have value";
        public InconsistentFunctionReturnsWarning(JetBrains.ReSharper.Psi.JavaScript.Tree.IReturnStatement returnStatement) { }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.JavaScript.Tree.IReturnStatement ReturnStatement { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "TypeScriptErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR, ToolTipFormatString="Staticness of overload does not argee with definition")]
    public class InconsistentOverloadStaticnesError : JetBrains.ReSharper.Daemon.JavaScript.Highlightings.JavaScriptHighlightingBase, JetBrains.ReSharper.Daemon.IHighlighting, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "Staticness of overload does not argee with definition";
        public InconsistentOverloadStaticnesError(JetBrains.ReSharper.Psi.Tree.ITreeNode highlightedNode, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsClassMemberDeclaration member) { }
        public string ErrorStripeToolTip { get; }
        public JetBrains.ReSharper.Psi.Tree.ITreeNode HighlightedNode { get; }
        public JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsClassMemberDeclaration Member { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "TypeScriptErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR, ToolTipFormatString="Visibility of overload does not argee with definition")]
    public class InconsistentOverloadVisibilityError : JetBrains.ReSharper.Daemon.JavaScript.Highlightings.JavaScriptHighlightingBase, JetBrains.ReSharper.Daemon.IHighlighting, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "Visibility of overload does not argee with definition";
        public InconsistentOverloadVisibilityError(JetBrains.ReSharper.Psi.Tree.ITreeNode highlightedNode, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsClassMemberDeclaration member) { }
        public string ErrorStripeToolTip { get; }
        public JetBrains.ReSharper.Psi.Tree.ITreeNode HighlightedNode { get; }
        public JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsClassMemberDeclaration Member { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "TypeScriptErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR, ToolTipFormatString="Base type can not be {0}")]
    public class IncorrectBaseTypeError : JetBrains.ReSharper.Daemon.JavaScript.Highlightings.JavaScriptHighlightingBase, JetBrains.ReSharper.Daemon.IHighlighting, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "Base type can not be {0}";
        public IncorrectBaseTypeError(string typeUsageType, JetBrains.ReSharper.Psi.Tree.ITreeNode typeUsageNode) { }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public JetBrains.ReSharper.Psi.Tree.ITreeNode TypeUsageNode { get; }
        public string TypeUsageType { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "TypeScriptErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR, ToolTipFormatString="Index signature parameter may not be optional")]
    public class IndexSignatureParameterCanNotBeOptionalError : JetBrains.ReSharper.Daemon.JavaScript.Highlightings.JavaScriptHighlightingBase, JetBrains.ReSharper.Daemon.IHighlighting, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "Index signature parameter may not be optional";
        public IndexSignatureParameterCanNotBeOptionalError(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsParameterDeclaration parameter) { }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsParameterDeclaration Parameter { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "TypeScriptErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR, ToolTipFormatString="Index signature parameter may not be rest")]
    public class IndexSignatureParameterCanNotBeRestError : JetBrains.ReSharper.Daemon.JavaScript.Highlightings.JavaScriptHighlightingBase, JetBrains.ReSharper.Daemon.IHighlighting, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "Index signature parameter may not be rest";
        public IndexSignatureParameterCanNotBeRestError(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsParameterDeclaration parameter) { }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsParameterDeclaration Parameter { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "TypeScriptErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR, ToolTipFormatString="Index signature parameter may not have default value")]
    public class IndexSignatureParameterCanNotHaveDefaultValueError : JetBrains.ReSharper.Daemon.JavaScript.Highlightings.JavaScriptHighlightingBase, JetBrains.ReSharper.Daemon.IHighlighting, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "Index signature parameter may not have default value";
        public IndexSignatureParameterCanNotHaveDefaultValueError(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsParameterDeclaration parameter) { }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsParameterDeclaration Parameter { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "TypeScriptErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR, ToolTipFormatString="Index signatures may take one and only one parameter")]
    public class IndexSignatureShouldTakeOneParameterError : JetBrains.ReSharper.Daemon.JavaScript.Highlightings.JavaScriptHighlightingBase, JetBrains.ReSharper.Daemon.IHighlighting, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "Index signatures may take one and only one parameter";
        public IndexSignatureShouldTakeOneParameterError(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsIndexSignatureDeclaration signature) { }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsIndexSignatureDeclaration Signature { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("InvocationOfNonFunction", "JAVA_SCRIPT", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.WARNING, ToolTipFormatString="Invoked expressions is not a function.")]
    public class InvocationOfNonFunctionWarning : JetBrains.ReSharper.Daemon.JavaScript.Highlightings.JavaScriptHighlightingBase, JetBrains.ReSharper.Daemon.IHighlighting, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "InvocationOfNonFunction";
        protected const string MESSAGE = "Invoked expressions is not a function.";
        public InvocationOfNonFunctionWarning(JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression expression) { }
        public string ErrorStripeToolTip { get; }
        public JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression Expression { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("InvokedExpressionMaybeNonFunction", "JAVA_SCRIPT", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.WARNING, ToolTipFormatString="Invoked expressions can be non-function.")]
    public class InvokedExpressionMaybeNonFunctionWarning : JetBrains.ReSharper.Daemon.JavaScript.Highlightings.JavaScriptHighlightingBase, JetBrains.ReSharper.Daemon.IHighlighting, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "InvokedExpressionMaybeNonFunction";
        protected const string MESSAGE = "Invoked expressions can be non-function.";
        public InvokedExpressionMaybeNonFunctionWarning(JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression expression) { }
        public string ErrorStripeToolTip { get; }
        public JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression Expression { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("LabelOrSemicolonExpected", "JAVA_SCRIPT", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR, ToolTipFormatString="Label name or \';\' expected")]
    public class LabelOrSemicolonExpectedError : JetBrains.ReSharper.Daemon.JavaScript.Highlightings.JavaScriptHighlightingBase, JetBrains.ReSharper.Daemon.IHighlighting, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "LabelOrSemicolonExpected";
        protected const string MESSAGE = "Label name or \';\' expected";
        public LabelOrSemicolonExpectedError(JetBrains.ReSharper.Psi.JavaScript.Tree.ICompoundExpression compoundExpression) { }
        public JetBrains.ReSharper.Psi.JavaScript.Tree.ICompoundExpression CompoundExpression { get; }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("LValueIsExpected", "JAVA_SCRIPT", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR, ToolTipFormatString="L-value is expected")]
    public class LValueIsExpectedError : JetBrains.ReSharper.Daemon.JavaScript.Highlightings.JavaScriptHighlightingBase, JetBrains.ReSharper.Daemon.IHighlighting, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "LValueIsExpected";
        protected const string MESSAGE = "L-value is expected";
        public LValueIsExpectedError(JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptTreeNode expression) { }
        public string ErrorStripeToolTip { get; }
        public JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptTreeNode Expression { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "TypeScriptErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR, ToolTipFormatString="{0} should have implementation")]
    public class MemberDoesntHaveBodyError : JetBrains.ReSharper.Daemon.JavaScript.Highlightings.JavaScriptHighlightingBase, JetBrains.ReSharper.Daemon.IHighlighting, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "{0} should have implementation";
        public MemberDoesntHaveBodyError(JetBrains.ReSharper.Psi.Tree.ITreeNode semicolon, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsClassMemberDeclaration signature, string myName) { }
        public string ErrorStripeToolTip { get; }
        public string MyName { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.Tree.ITreeNode Semicolon { get; }
        public JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsClassMemberDeclaration Signature { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("MisuseOfOwnerFunctionThis", "JAVA_SCRIPT", AttributeId="ReSharper Warning", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.WARNING, ToolTipFormatString="Suspicious use of \'this\' qualifier from inner function")]
    public class MisuseOfOwnerFunctionThisWarning : JetBrains.ReSharper.Daemon.JavaScript.Highlightings.JavaScriptHighlightingBase, JetBrains.ReSharper.Daemon.IHighlighting, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "MisuseOfOwnerFunctionThis";
        protected const string MESSAGE = "Suspicious use of \'this\' qualifier from inner function";
        public MisuseOfOwnerFunctionThisWarning(JetBrains.ReSharper.Psi.JavaScript.Tree.IReferenceExpression referenceExpression, JetBrains.ReSharper.Psi.JavaScript.Tree.IJsFunctionLike functionExpression, string name) { }
        public string ErrorStripeToolTip { get; }
        public JetBrains.ReSharper.Psi.JavaScript.Tree.IJsFunctionLike FunctionExpression { get; }
        public string Name { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.JavaScript.Tree.IReferenceExpression ReferenceExpression { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "TypeScriptErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR, ToolTipFormatString="Wrong external module reference name. String literal is expected.")]
    public class ModuleReferenceNameShouldBeStringLiteralError : JetBrains.ReSharper.Daemon.JavaScript.Highlightings.JavaScriptHighlightingBase, JetBrains.ReSharper.Daemon.IHighlighting, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "Wrong external module reference name. String literal is expected.";
        public ModuleReferenceNameShouldBeStringLiteralError(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsExpression expression) { }
        public string ErrorStripeToolTip { get; }
        public JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsExpression Expression { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("MultipleDeclarationsInForeach", "JAVA_SCRIPT", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR, ToolTipFormatString="Only one variable can be declared in for header")]
    public class MultipleDeclarationsInForeachError : JetBrains.ReSharper.Daemon.JavaScript.Highlightings.JavaScriptHighlightingBase, JetBrains.ReSharper.Daemon.IHighlighting, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "MultipleDeclarationsInForeach";
        protected const string MESSAGE = "Only one variable can be declared in for header";
        public MultipleDeclarationsInForeachError(JetBrains.ReSharper.Psi.JavaScript.Tree.IForDeclarationInitializer initializer) { }
        public string ErrorStripeToolTip { get; }
        public JetBrains.ReSharper.Psi.JavaScript.Tree.IForDeclarationInitializer Initializer { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("NotAllPathsReturnValue", "JAVA_SCRIPT", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.WARNING, ToolTipFormatString="Not all code paths return a value")]
    public class NotAllPathsReturnValueWarning : JetBrains.ReSharper.Daemon.JavaScript.Highlightings.JavaScriptHighlightingBase, JetBrains.ReSharper.Daemon.IHighlighting, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "NotAllPathsReturnValue";
        protected const string MESSAGE = "Not all code paths return a value";
        public NotAllPathsReturnValueWarning(JetBrains.ReSharper.Psi.JavaScript.Tree.IJsFunctionLike functionLike, JetBrains.DocumentModel.DocumentRange documentRange) { }
        public JetBrains.DocumentModel.DocumentRange DocumentRange { get; }
        public string ErrorStripeToolTip { get; }
        public JetBrains.ReSharper.Psi.JavaScript.Tree.IJsFunctionLike FunctionLike { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("NotResolved", "JAVA_SCRIPT", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.UNRESOLVED_ERROR, ToolTipFormatString="Cannot resolve symbol \'{0}\'")]
    public class NotResolvedError : JetBrains.ReSharper.Daemon.JavaScript.Highlightings.JavaScriptHighlightingBase, JetBrains.ReSharper.Daemon.IHighlighting, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "NotResolved";
        protected const string MESSAGE = "Cannot resolve symbol \'{0}\'";
        public NotResolvedError(JetBrains.ReSharper.Psi.JavaScript.Resolve.IReferenceExpressionReference reference) { }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.JavaScript.Resolve.IReferenceExpressionReference Reference { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("UnusedLocals", "JAVA_SCRIPT", AttributeId="ReSharper Dead Code", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.DEADCODE, ToolTipFormatString="Function \'{0}\' is never used because it is overridden in the owner function body")]
    public class OverriddenUnusedLocalFunctionWarning : JetBrains.ReSharper.Daemon.JavaScript.Highlightings.JavaScriptHighlightingBase, JetBrains.ReSharper.Daemon.IHighlighting, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "UnusedLocals";
        protected const string MESSAGE = "Function \'{0}\' is never used because it is overridden in the owner function body";
        public OverriddenUnusedLocalFunctionWarning(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration) { }
        public JetBrains.ReSharper.Psi.Tree.IDeclaration Declaration { get; }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("UnusedParameter", "JAVA_SCRIPT", AttributeId="ReSharper Dead Code", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.DEADCODE, ToolTipFormatString="Value of parameter \'{0}\' is never used because it is overridden in the function b" +
        "ody")]
    public class OverriddenUnusedParameterWarning : JetBrains.ReSharper.Daemon.JavaScript.Highlightings.JavaScriptHighlightingBase, JetBrains.ReSharper.Daemon.IHighlighting, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "UnusedParameter";
        protected const string MESSAGE = "Value of parameter \'{0}\' is never used because it is overridden in the function b" +
            "ody";
        public OverriddenUnusedParameterWarning(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration) { }
        public JetBrains.ReSharper.Psi.Tree.IDeclaration Declaration { get; }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("ParameterValueIsNotUsed", "JAVA_SCRIPT", AttributeId="ReSharper Warning", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.WARNING, ToolTipFormatString="Parameter value is not used because it is overridden in method body")]
    public class ParameterValueIsNotUsedWarning : JetBrains.ReSharper.Daemon.JavaScript.Highlightings.JavaScriptHighlightingBase, JetBrains.ReSharper.Daemon.IHighlighting, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "ParameterValueIsNotUsed";
        protected const string MESSAGE = "Parameter value is not used because it is overridden in method body";
        public ParameterValueIsNotUsedWarning(JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptParameterDeclaration parameter) { }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptParameterDeclaration Parameter { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("PossiblyUnassignedProperty", "JAVA_SCRIPT", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.WARNING, ToolTipFormatString="Property or global variable \'{0}\' is possibly never assigned")]
    public class PossiblyUnassignedPropertyWarning : JetBrains.ReSharper.Daemon.JavaScript.Highlightings.JavaScriptHighlightingBase, JetBrains.ReSharper.Daemon.IHighlighting, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "PossiblyUnassignedProperty";
        protected const string MESSAGE = "Property or global variable \'{0}\' is possibly never assigned";
        public PossiblyUnassignedPropertyWarning(JetBrains.ReSharper.Psi.JavaScript.Tree.IReferenceExpression expression, string variableName) { }
        public string ErrorStripeToolTip { get; }
        public JetBrains.ReSharper.Psi.JavaScript.Tree.IReferenceExpression Expression { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public string VariableName { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("PropertyGetterCannotHaveParameters", "JAVA_SCRIPT", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR, ToolTipFormatString="Property getter cannot have parameters")]
    public class PropertyGetterCannotHaveParametersError : JetBrains.ReSharper.Daemon.JavaScript.Highlightings.JavaScriptHighlightingBase, JetBrains.ReSharper.Daemon.IHighlighting, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "PropertyGetterCannotHaveParameters";
        protected const string MESSAGE = "Property getter cannot have parameters";
        public PropertyGetterCannotHaveParametersError(JetBrains.ReSharper.Psi.JavaScript.Tree.IAccessorBody declaration) { }
        public JetBrains.ReSharper.Psi.JavaScript.Tree.IAccessorBody Declaration { get; }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("PropertySetterMustHaveSingleParameter", "JAVA_SCRIPT", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR, ToolTipFormatString="Property setter must have a single parameter")]
    public class PropertySetterMustHaveSingleParameterError : JetBrains.ReSharper.Daemon.JavaScript.Highlightings.JavaScriptHighlightingBase, JetBrains.ReSharper.Daemon.IHighlighting, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "PropertySetterMustHaveSingleParameter";
        protected const string MESSAGE = "Property setter must have a single parameter";
        public PropertySetterMustHaveSingleParameterError(JetBrains.ReSharper.Psi.JavaScript.Tree.IAccessorBody declaration) { }
        public JetBrains.ReSharper.Psi.JavaScript.Tree.IAccessorBody Declaration { get; }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("QualifiedExpressionIsNull", "JAVA_SCRIPT", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.WARNING, ToolTipFormatString="Qualifier is \'null\' or \'undefined\'.")]
    public class QualifiedExpressionIsNullWarning : JetBrains.ReSharper.Daemon.JavaScript.Highlightings.JavaScriptHighlightingBase, JetBrains.ReSharper.Daemon.IHighlighting, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "QualifiedExpressionIsNull";
        protected const string MESSAGE = "Qualifier is \'null\' or \'undefined\'.";
        public QualifiedExpressionIsNullWarning(JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression expression) { }
        public string ErrorStripeToolTip { get; }
        public JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression Expression { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("QualifiedExpressionMaybeNull", "JAVA_SCRIPT", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.WARNING, ToolTipFormatString="Qualifier can be \'null\' or \'undefined\'.")]
    public class QualifiedExpressionMaybeNullWarning : JetBrains.ReSharper.Daemon.JavaScript.Highlightings.JavaScriptHighlightingBase, JetBrains.ReSharper.Daemon.IHighlighting, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "QualifiedExpressionMaybeNull";
        protected const string MESSAGE = "Qualifier can be \'null\' or \'undefined\'.";
        public QualifiedExpressionMaybeNullWarning(JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression expression) { }
        public string ErrorStripeToolTip { get; }
        public JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression Expression { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "TypeScriptErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR, ToolTipFormatString="\'Rest\' parameter can not have default value")]
    public class RestParameterCanNotHaveDefaultValueError : JetBrains.ReSharper.Daemon.JavaScript.Highlightings.JavaScriptHighlightingBase, JetBrains.ReSharper.Daemon.IHighlighting, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "\'Rest\' parameter can not have default value";
        public RestParameterCanNotHaveDefaultValueError(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsParameterDeclaration parameter) { }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsParameterDeclaration Parameter { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "TypeScriptErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR, ToolTipFormatString="\'Rest\' parameter can not have optional mark \'?\'")]
    public class RestParameterCanNotHaveOptionalMarkError : JetBrains.ReSharper.Daemon.JavaScript.Highlightings.JavaScriptHighlightingBase, JetBrains.ReSharper.Daemon.IHighlighting, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "\'Rest\' parameter can not have optional mark \'?\'";
        public RestParameterCanNotHaveOptionalMarkError(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsParameterDeclaration parameter) { }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsParameterDeclaration Parameter { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("ReturnFromGlobalScopetWithValue", "JAVA_SCRIPT", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.WARNING, ToolTipFormatString="Return from global scope shouldn\'t have value")]
    public class ReturnFromGlobalScopetWithValueWarning : JetBrains.ReSharper.Daemon.JavaScript.Highlightings.JavaScriptHighlightingBase, JetBrains.ReSharper.Daemon.IHighlighting, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "ReturnFromGlobalScopetWithValue";
        protected const string MESSAGE = "Return from global scope shouldn\'t have value";
        public ReturnFromGlobalScopetWithValueWarning(JetBrains.ReSharper.Psi.JavaScript.Tree.IReturnStatement returnStatement) { }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.JavaScript.Tree.IReturnStatement ReturnStatement { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "TypeScriptErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR, ToolTipFormatString="Property setter hould have one parameter")]
    public class SetterShouldHaveOneParameterError : JetBrains.ReSharper.Daemon.JavaScript.Highlightings.JavaScriptHighlightingBase, JetBrains.ReSharper.Daemon.IHighlighting, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "Property setter hould have one parameter";
        public SetterShouldHaveOneParameterError(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsMemberAccessorDeclaration accessor) { }
        public JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsMemberAccessorDeclaration Accessor { get; }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("StatementIsNotTerminated", "JAVA_SCRIPT", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.WARNING, ToolTipFormatString="Statement is not terminated")]
    public class StatementIsNotTerminatedWarning : JetBrains.ReSharper.Daemon.JavaScript.Highlightings.JavaScriptHighlightingBase, JetBrains.ReSharper.Daemon.IHighlighting, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "StatementIsNotTerminated";
        protected const string MESSAGE = "Statement is not terminated";
        public StatementIsNotTerminatedWarning(JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatement statement, JetBrains.DocumentModel.DocumentRange range) { }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.DocumentModel.DocumentRange Range { get; }
        public JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatement Statement { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.DaemonStageAttribute()]
    public class SyntaxHighlightingStage : JetBrains.ReSharper.Daemon.JavaScript.Impl.JavaScriptDaemonStageBase
    {
        protected override JetBrains.ReSharper.Daemon.IDaemonStageProcess CreateProcess(JetBrains.ReSharper.Daemon.IDaemonProcess process, JetBrains.Application.Settings.IContextBoundSettingsStore settings, JetBrains.ReSharper.Daemon.DaemonProcessKind processKind, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptFile file) { }
        public override JetBrains.ReSharper.Daemon.ErrorStripeRequest NeedsErrorStripe(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, JetBrains.Application.Settings.IContextBoundSettingsStore settings) { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("ThisInGlobalContext", "JAVA_SCRIPT", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.WARNING, ToolTipFormatString="\'this\' shouldn\'t be used in global context")]
    public class ThisInGlobalContextWarning : JetBrains.ReSharper.Daemon.JavaScript.Highlightings.JavaScriptHighlightingBase, JetBrains.ReSharper.Daemon.IHighlighting, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "ThisInGlobalContext";
        protected const string MESSAGE = "\'this\' shouldn\'t be used in global context";
        public ThisInGlobalContextWarning(JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression javaScriptExpression) { }
        public string ErrorStripeToolTip { get; }
        public JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression JavaScriptExpression { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("ThrowMustBeFollowedByExpression", "JAVA_SCRIPT", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR, ToolTipFormatString="Throw must be followed by an expression")]
    public class ThrowMustBeFollowedByExpressionError : JetBrains.ReSharper.Daemon.JavaScript.Highlightings.JavaScriptHighlightingBase, JetBrains.ReSharper.Daemon.IHighlighting, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "ThrowMustBeFollowedByExpression";
        protected const string MESSAGE = "Throw must be followed by an expression";
        public ThrowMustBeFollowedByExpressionError(JetBrains.ReSharper.Psi.JavaScript.Tree.IThrowStatement throwStatement) { }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.JavaScript.Tree.IThrowStatement ThrowStatement { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("TsDeclarationHides", "TYPE_SCRIPT", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.WARNING, ToolTipFormatString="Declaration hides {0} from outer scope")]
    public class TsDeclarationHidesWarning : JetBrains.ReSharper.Daemon.JavaScript.Highlightings.JavaScriptHighlightingBase, JetBrains.ReSharper.Daemon.IHighlighting, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "TsDeclarationHides";
        protected const string MESSAGE = "Declaration hides {0} from outer scope";
        public TsDeclarationHidesWarning(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration, JetBrains.ReSharper.Psi.IDeclaredElement hiddenElement) { }
        public JetBrains.ReSharper.Psi.Tree.IDeclaration Declaration { get; }
        public string ErrorStripeToolTip { get; }
        public JetBrains.ReSharper.Psi.IDeclaredElement HiddenElement { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "TypeScriptErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR, ToolTipFormatString="Type parameter constraint should be a class or interface")]
    public class TypeParameterConstraintShouldBeDeclaredTypeError : JetBrains.ReSharper.Daemon.JavaScript.Highlightings.JavaScriptHighlightingBase, JetBrains.ReSharper.Daemon.IHighlighting, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "Type parameter constraint should be a class or interface";
        public TypeParameterConstraintShouldBeDeclaredTypeError(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeParameterDeclaration typeParameter, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeUsage typeUsage) { }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeParameterDeclaration TypeParameter { get; }
        public JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeUsage TypeUsage { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "TypeScriptErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR, ToolTipFormatString="Ambient declarations are only allowed at the top-level or module scopes.")]
    public class UnexpectedAmbientDeclarationError : JetBrains.ReSharper.Daemon.JavaScript.Highlightings.JavaScriptHighlightingBase, JetBrains.ReSharper.Daemon.IHighlighting, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "Ambient declarations are only allowed at the top-level or module scopes.";
        public UnexpectedAmbientDeclarationError(JetBrains.ReSharper.Psi.Tree.ITreeNode modifierNode) { }
        public string ErrorStripeToolTip { get; }
        public JetBrains.ReSharper.Psi.Tree.ITreeNode ModifierNode { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "TypeScriptErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR, ToolTipFormatString="{0} is not allowed in this context")]
    public class UnexpectedDeclarationInNonModuleContextError : JetBrains.ReSharper.Daemon.JavaScript.Highlightings.JavaScriptHighlightingBase, JetBrains.ReSharper.Daemon.IHighlighting, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "{0} is not allowed in this context";
        public UnexpectedDeclarationInNonModuleContextError(JetBrains.ReSharper.Psi.Tree.ITreeNode typeUsageNode, string name) { }
        public string ErrorStripeToolTip { get; }
        public string Name { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public JetBrains.ReSharper.Psi.Tree.ITreeNode TypeUsageNode { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "TypeScriptErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR, ToolTipFormatString="Export declarations are only allowed at the top-level or module scopes.")]
    public class UnexpectedExportDeclarationError : JetBrains.ReSharper.Daemon.JavaScript.Highlightings.JavaScriptHighlightingBase, JetBrains.ReSharper.Daemon.IHighlighting, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "Export declarations are only allowed at the top-level or module scopes.";
        public UnexpectedExportDeclarationError(JetBrains.ReSharper.Psi.Tree.ITreeNode modifierNode) { }
        public string ErrorStripeToolTip { get; }
        public JetBrains.ReSharper.Psi.Tree.ITreeNode ModifierNode { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "TypeScriptErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR, ToolTipFormatString="Unexpected modifier.")]
    public class UnexpectedModifierError : JetBrains.ReSharper.Daemon.JavaScript.Highlightings.JavaScriptHighlightingBase, JetBrains.ReSharper.Daemon.IHighlighting, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "Unexpected modifier.";
        public UnexpectedModifierError(JetBrains.ReSharper.Psi.Tree.ITreeNode modifierNode) { }
        public string ErrorStripeToolTip { get; }
        public JetBrains.ReSharper.Psi.Tree.ITreeNode ModifierNode { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "TypeScriptErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR, ToolTipFormatString="Optional parameters may only be followed by other optional parameters")]
    public class UnexpectedRequiredParameterAfterOptionalError : JetBrains.ReSharper.Daemon.JavaScript.Highlightings.JavaScriptHighlightingBase, JetBrains.ReSharper.Daemon.IHighlighting, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "Optional parameters may only be followed by other optional parameters";
        public UnexpectedRequiredParameterAfterOptionalError(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsParameterDeclaration parameter) { }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsParameterDeclaration Parameter { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "TypeScriptErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR, ToolTipFormatString="\'Rest\' parameter should be the last")]
    public class UnexpectedRequiredParameterAfterRestError : JetBrains.ReSharper.Daemon.JavaScript.Highlightings.JavaScriptHighlightingBase, JetBrains.ReSharper.Daemon.IHighlighting, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "\'Rest\' parameter should be the last";
        public UnexpectedRequiredParameterAfterRestError(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsParameterDeclaration parameter) { }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsParameterDeclaration Parameter { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("JsUnreachableCode", "JAVA_SCRIPT", AttributeId="ReSharper Dead Code", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.DEADCODE, ToolTipFormatString="Code is unreachable")]
    public class UnreachableCodeWarning : JetBrains.ReSharper.Daemon.JavaScript.Highlightings.JavaScriptHighlightingBase, JetBrains.ReSharper.Daemon.IHighlighting, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "JsUnreachableCode";
        protected const string MESSAGE = "Code is unreachable";
        public UnreachableCodeWarning(JetBrains.ReSharper.Psi.ITreeRange treeRange) { }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public JetBrains.ReSharper.Psi.ITreeRange TreeRange { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("JumpMustBeInLoop", "JAVA_SCRIPT", AttributeId="ReSharper Warning", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.WARNING, ToolTipFormatString="\'break\' must be in loop or switch statement")]
    public class UnresolvedJumpBreakMustBeInLoopWarning : JetBrains.ReSharper.Daemon.JavaScript.Highlightings.JavaScriptHighlightingBase, JetBrains.ReSharper.Daemon.IHighlighting, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "JumpMustBeInLoop";
        protected const string MESSAGE = "\'break\' must be in loop or switch statement";
        public UnresolvedJumpBreakMustBeInLoopWarning(JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatement statement) { }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatement Statement { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("JumpMustBeInLoop", "JAVA_SCRIPT", AttributeId="ReSharper Warning", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.WARNING, ToolTipFormatString="\'continue\' must be in loop")]
    public class UnresolvedJumpContinueMustBeInLoopWarning : JetBrains.ReSharper.Daemon.JavaScript.Highlightings.JavaScriptHighlightingBase, JetBrains.ReSharper.Daemon.IHighlighting, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "JumpMustBeInLoop";
        protected const string MESSAGE = "\'continue\' must be in loop";
        public UnresolvedJumpContinueMustBeInLoopWarning(JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatement statement) { }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptStatement Statement { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("UnusedLocals", "JAVA_SCRIPT", AttributeId="ReSharper Dead Code", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.DEADCODE, ToolTipFormatString="Local function \'{0}\' is never used")]
    public class UnusedLocalFunctionWarning : JetBrains.ReSharper.Daemon.JavaScript.Highlightings.JavaScriptHighlightingBase, JetBrains.ReSharper.Daemon.IHighlighting, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "UnusedLocals";
        protected const string MESSAGE = "Local function \'{0}\' is never used";
        public UnusedLocalFunctionWarning(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration) { }
        public JetBrains.ReSharper.Psi.Tree.IDeclaration Declaration { get; }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("UnusedLocals", "JAVA_SCRIPT", AttributeId="ReSharper Dead Code", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.DEADCODE, ToolTipFormatString="Local variable \'{0}\' is never used")]
    public class UnusedLocalVariableWarning : JetBrains.ReSharper.Daemon.JavaScript.Highlightings.JavaScriptHighlightingBase, JetBrains.ReSharper.Daemon.IHighlighting, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "UnusedLocals";
        protected const string MESSAGE = "Local variable \'{0}\' is never used";
        public UnusedLocalVariableWarning(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration) { }
        public JetBrains.ReSharper.Psi.Tree.IDeclaration Declaration { get; }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("UnusedParameter", "JAVA_SCRIPT", AttributeId="ReSharper Dead Code", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.DEADCODE, ToolTipFormatString="Parameter \'{0}\' is never used")]
    public class UnusedParameterWarning : JetBrains.ReSharper.Daemon.JavaScript.Highlightings.JavaScriptHighlightingBase, JetBrains.ReSharper.Daemon.IHighlighting, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "UnusedParameter";
        protected const string MESSAGE = "Parameter \'{0}\' is never used";
        public UnusedParameterWarning(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration) { }
        public JetBrains.ReSharper.Psi.Tree.IDeclaration Declaration { get; }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("UnusedProperty", "JAVA_SCRIPT", AttributeId="ReSharper Dead Code", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.DEADCODE, ToolTipFormatString="{0} \'{1}\' is never used")]
    public class UnusedPropertyWarning : JetBrains.ReSharper.Daemon.JavaScript.Highlightings.JavaScriptHighlightingBase, JetBrains.ReSharper.Daemon.IHighlighting, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "UnusedProperty";
        protected const string MESSAGE = "{0} \'{1}\' is never used";
        public UnusedPropertyWarning(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration) { }
        public JetBrains.ReSharper.Psi.Tree.IDeclaration Declaration { get; }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("UsageOfDefinitelyUnassignedValue", "JAVA_SCRIPT", AttributeId="ReSharper Warning", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.WARNING, ToolTipFormatString="Usage of unassigned value")]
    public class UsageOfDefinitelyUnassignedValueWarning : JetBrains.ReSharper.Daemon.JavaScript.Highlightings.JavaScriptHighlightingBase, JetBrains.ReSharper.Daemon.IHighlighting, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "UsageOfDefinitelyUnassignedValue";
        protected const string MESSAGE = "Usage of unassigned value";
        public UsageOfDefinitelyUnassignedValueWarning(JetBrains.ReSharper.Psi.JavaScript.Tree.IReferenceExpression expression) { }
        public string ErrorStripeToolTip { get; }
        public JetBrains.ReSharper.Psi.JavaScript.Tree.IReferenceExpression Expression { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("UsageOfPossiblyUnassignedValue", "JAVA_SCRIPT", AttributeId="ReSharper Warning", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.WARNING, ToolTipFormatString="Usage of possibly unassigned value")]
    public class UsageOfPossiblyUnassignedValueWarning : JetBrains.ReSharper.Daemon.JavaScript.Highlightings.JavaScriptHighlightingBase, JetBrains.ReSharper.Daemon.IHighlighting, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "UsageOfPossiblyUnassignedValue";
        protected const string MESSAGE = "Usage of possibly unassigned value";
        public UsageOfPossiblyUnassignedValueWarning(JetBrains.ReSharper.Psi.JavaScript.Tree.IReferenceExpression expression) { }
        public string ErrorStripeToolTip { get; }
        public JetBrains.ReSharper.Psi.JavaScript.Tree.IReferenceExpression Expression { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("UseOfImplicitGlobalInFunctionScope", "JAVA_SCRIPT", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.WARNING, ToolTipFormatString="Use of an implicitly declared global variable \'{0}\'")]
    public class UseOfImplicitGlobalInFunctionScopeWarning : JetBrains.ReSharper.Daemon.JavaScript.Highlightings.JavaScriptHighlightingBase, JetBrains.ReSharper.Daemon.IHighlighting, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "UseOfImplicitGlobalInFunctionScope";
        protected const string MESSAGE = "Use of an implicitly declared global variable \'{0}\'";
        public UseOfImplicitGlobalInFunctionScopeWarning(JetBrains.ReSharper.Psi.JavaScript.Tree.IReferenceExpression expression, string variableName) { }
        public string ErrorStripeToolTip { get; }
        public JetBrains.ReSharper.Psi.JavaScript.Tree.IReferenceExpression Expression { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public string VariableName { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("UsingOfReservedWord", "JAVA_SCRIPT", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.WARNING, ToolTipFormatString="Use of future reserved word")]
    public class UsingOfReservedWordWarning : JetBrains.ReSharper.Daemon.JavaScript.Highlightings.JavaScriptHighlightingBase, JetBrains.ReSharper.Daemon.IHighlighting, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "UsingOfReservedWord";
        protected const string MESSAGE = "Use of future reserved word";
        public UsingOfReservedWordWarning(JetBrains.ReSharper.Psi.Tree.ITreeNode declaration) { }
        public JetBrains.ReSharper.Psi.Tree.ITreeNode Declaration { get; }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("WrongExpressionStatement", "JAVA_SCRIPT", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.WARNING, ToolTipFormatString="Expression statement is not assignment or call")]
    public class WrongExpressionStatementWarning : JetBrains.ReSharper.Daemon.JavaScript.Highlightings.JavaScriptHighlightingBase, JetBrains.ReSharper.Daemon.IHighlighting, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "WrongExpressionStatement";
        protected const string MESSAGE = "Expression statement is not assignment or call";
        public WrongExpressionStatementWarning(JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression javaScriptExpression) { }
        public string ErrorStripeToolTip { get; }
        public JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression JavaScriptExpression { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
}
namespace JetBrains.ReSharper.Daemon.JavaScript.Stages.ControlFlow
{
    
    public class ControlFlowAnalysisProcess : JetBrains.ReSharper.Daemon.JavaScript.Impl.JavaScriptDaemonStageProcessBase
    {
        public ControlFlowAnalysisProcess(JetBrains.ReSharper.Daemon.IDaemonProcess process, JetBrains.Application.Settings.IContextBoundSettingsStore settingsStore, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptFile file) { }
        public override void Execute(System.Action<JetBrains.ReSharper.Daemon.DaemonStageResult> committer) { }
        protected virtual System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Daemon.JavaScript.Stages.SmartResolver.JsSmartResolverProcess> GetSmartResolverProcess(JetBrains.ReSharper.Daemon.IDaemonProcess process) { }
        protected virtual bool SignatureIsPublic(JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptScope signatureOwner) { }
        public override void VisitAccessorBody(JetBrains.ReSharper.Psi.JavaScript.Tree.IAccessorBody accessorBodyParam, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer consumer) { }
        public override void VisitFunctionExpression(JetBrains.ReSharper.Psi.JavaScript.Tree.IFunctionExpression functionExpression, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer consumer) { }
        public void VisitFunctionLike(JetBrains.ReSharper.Psi.JavaScript.Tree.IJsFunctionLike functionExpression, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer consumer) { }
        public override void VisitJavaScriptFile(JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptFile javaScriptFileParam, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer context) { }
    }
    [JetBrains.ReSharper.Daemon.DaemonStageAttribute(StagesBefore=new System.Type[] {
            typeof(JetBrains.ReSharper.Daemon.JavaScript.Stages.SmartResolver.SmartResolverStage),
            typeof(JetBrains.ReSharper.Daemon.JavaScript.Stages.IdentifierHighlightingStage),
            typeof(JetBrains.ReSharper.Daemon.JavaScript.Stages.FileStructureState.JavaScriptFileIndexStage)})]
    public class ControlFlowAnalysisStage : JetBrains.ReSharper.Daemon.JavaScript.Impl.JavaScriptDaemonStageBase
    {
        protected override JetBrains.ReSharper.Daemon.IDaemonStageProcess CreateProcess(JetBrains.ReSharper.Daemon.IDaemonProcess process, JetBrains.Application.Settings.IContextBoundSettingsStore settings, JetBrains.ReSharper.Daemon.DaemonProcessKind processKind, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptFile file) { }
        public override JetBrains.ReSharper.Daemon.ErrorStripeRequest NeedsErrorStripe(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, JetBrains.Application.Settings.IContextBoundSettingsStore settings) { }
    }
}
namespace JetBrains.ReSharper.Daemon.JavaScript.Stages.FileStructureState
{
    
    public class JavaScriptFileIndexProcess : JetBrains.ReSharper.Daemon.JavaScript.Impl.JavaScriptDaemonStageProcessBase
    {
        public JavaScriptFileIndexProcess(JetBrains.ReSharper.Daemon.IDaemonProcess process, JetBrains.Application.Settings.IContextBoundSettingsStore settingsStore, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptFile file) { }
        public JetBrains.Util.OneToSetMap<JetBrains.ReSharper.Psi.JavaScript.Tree.IBlockScope, string> FieldsDefinedInFunction { get; }
        public JetBrains.Util.OneToListMap<JetBrains.ReSharper.Psi.JavaScript.Tree.IBlockScope, JetBrains.ReSharper.Psi.JavaScript.Tree.IReturnStatement> FunctionReturns { get; }
        public System.Collections.Generic.List<JetBrains.ReSharper.Psi.JavaScript.Tree.IBlockScope> Functions { get; }
        public override void Execute(System.Action<JetBrains.ReSharper.Daemon.DaemonStageResult> committer) { }
        public override void ProcessBeforeInterior(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer consumer) { }
        public override void VisitAccessorBody(JetBrains.ReSharper.Psi.JavaScript.Tree.IAccessorBody accessorBodyParam, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer context) { }
        public override void VisitBinaryExpression(JetBrains.ReSharper.Psi.JavaScript.Tree.IBinaryExpression binaryExpressionParam, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer context) { }
        public override void VisitFunctionExpression(JetBrains.ReSharper.Psi.JavaScript.Tree.IFunctionExpression functionExpressionParam, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer context) { }
        public override void VisitReturnStatement(JetBrains.ReSharper.Psi.JavaScript.Tree.IReturnStatement returnStatementParam, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer context) { }
    }
    [JetBrains.ReSharper.Daemon.DaemonStageAttribute()]
    public class JavaScriptFileIndexStage : JetBrains.ReSharper.Daemon.JavaScript.Impl.JavaScriptDaemonStageBase
    {
        protected override JetBrains.ReSharper.Daemon.IDaemonStageProcess CreateProcess(JetBrains.ReSharper.Daemon.IDaemonProcess process, JetBrains.Application.Settings.IContextBoundSettingsStore settings, JetBrains.ReSharper.Daemon.DaemonProcessKind processKind, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptFile file) { }
        public override JetBrains.ReSharper.Daemon.ErrorStripeRequest NeedsErrorStripe(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, JetBrains.Application.Settings.IContextBoundSettingsStore settings) { }
    }
}
namespace JetBrains.ReSharper.Daemon.JavaScript.Stages.InspectionsStage
{
    
    public interface IJavaScriptInspectionsProcessFactory
    {
        JetBrains.ReSharper.Daemon.IDaemonStageProcess CreateInspectionsProcess(JetBrains.ReSharper.Daemon.IDaemonProcess process, JetBrains.Application.Settings.IContextBoundSettingsStore settings, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptFile file);
    }
    public class InspectionsProcess : JetBrains.ReSharper.Daemon.JavaScript.Impl.JavaScriptDaemonStageProcessBase
    {
        public InspectionsProcess(JetBrains.ReSharper.Daemon.IDaemonProcess process, JetBrains.Application.Settings.IContextBoundSettingsStore settings, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptFile file) { }
        protected virtual void AddThisInGlobalContextWarning(JetBrains.ReSharper.Psi.JavaScript.Tree.IThisExpression thisExpression, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer consumer) { }
        protected virtual void AnalyseReturns(JetBrains.ReSharper.Psi.JavaScript.Tree.IReturnStatement returnStatement, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer context) { }
        public override void Execute(System.Action<JetBrains.ReSharper.Daemon.DaemonStageResult> committer) { }
        public static void HighlightMissedItemsInObjectLiteralExpression(JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptFile javaScriptFile, JetBrains.ReSharper.Psi.JavaScript.Tree.IObjectLiteral objectLiteral, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer consumer) { }
        public static void HighlightMissedTrailingElementInArrayLiteral(JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptFile javaScriptFile, JetBrains.ReSharper.Psi.JavaScript.Tree.IArrayLiteral arrayLiteral, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer consumer) { }
        public static void HighlightReservedWordInObjectProperty(JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptFile javaScriptFile, JetBrains.ReSharper.Psi.JavaScript.Tree.IObjectPropertyDeclaration declaration, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer consumer) { }
        public override void ProcessAfterInterior(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer consumer) { }
        public override void ProcessBeforeInterior(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer consumer) { }
        public override void VisitArrayLiteral(JetBrains.ReSharper.Psi.JavaScript.Tree.IArrayLiteral arrayLiteral, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer consumer) { }
        public override void VisitBinaryExpression(JetBrains.ReSharper.Psi.JavaScript.Tree.IBinaryExpression binaryExpression, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer consumer) { }
        public override void VisitBreakStatement(JetBrains.ReSharper.Psi.JavaScript.Tree.IBreakStatement breakStatementParam, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer context) { }
        public override void VisitContinueStatement(JetBrains.ReSharper.Psi.JavaScript.Tree.IContinueStatement continueStatementParam, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer context) { }
        public override void VisitDebugStatement(JetBrains.ReSharper.Psi.JavaScript.Tree.IDebugStatement debugStatementParam, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer context) { }
        public override void VisitDocCommentBlockNode(JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptDocCommentBlockNode xmlDoc, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer context) { }
        public override void VisitExpressionStatement(JetBrains.ReSharper.Psi.JavaScript.Tree.IExpressionStatement expressionStatement, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer consumer) { }
        public override void VisitFunctionStatement(JetBrains.ReSharper.Psi.JavaScript.Tree.IFunctionStatement functionStatement, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer consumer) { }
        public override void VisitLabelledStatement(JetBrains.ReSharper.Psi.JavaScript.Tree.ILabelledStatement labelStatement, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer consumer) { }
        public override void VisitNewExpression(JetBrains.ReSharper.Psi.JavaScript.Tree.INewExpression newExpression, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer consumer) { }
        public override void VisitNode(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer consumer) { }
        public override void VisitObjectLiteral(JetBrains.ReSharper.Psi.JavaScript.Tree.IObjectLiteral objectLiteral, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer consumer) { }
        public override void VisitObjectPropertyDeclaration(JetBrains.ReSharper.Psi.JavaScript.Tree.IObjectPropertyDeclaration declaration, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer consumer) { }
        public override void VisitReferenceExpression(JetBrains.ReSharper.Psi.JavaScript.Tree.IReferenceExpression referenceExpression, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer consumer) { }
        public override void VisitReturnStatement(JetBrains.ReSharper.Psi.JavaScript.Tree.IReturnStatement returnStatement, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer context) { }
        public override void VisitSwitchStatement(JetBrains.ReSharper.Psi.JavaScript.Tree.ISwitchStatement switchStatement, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer consumer) { }
        public override void VisitThisExpression(JetBrains.ReSharper.Psi.JavaScript.Tree.IThisExpression thisExpression, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer consumer) { }
        public override void VisitThrowStatement(JetBrains.ReSharper.Psi.JavaScript.Tree.IThrowStatement throwStatementParam, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer context) { }
        public override void VisitVariableStatement(JetBrains.ReSharper.Psi.JavaScript.Tree.IVariableStatement variableStatementParam, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer context) { }
    }
    [JetBrains.ReSharper.Daemon.DaemonStageAttribute(StagesBefore=new System.Type[] {
            typeof(JetBrains.ReSharper.Daemon.JavaScript.Stages.SmartResolver.SmartResolverStage),
            typeof(JetBrains.ReSharper.Daemon.JavaScript.Stages.FileStructureState.JavaScriptFileIndexStage)})]
    public class InspectionsStage : JetBrains.ReSharper.Daemon.JavaScript.Impl.JavaScriptDaemonStageBase
    {
        public InspectionsStage(JetBrains.ProjectModel.FileTypes.ProjectFileTypeServices services) { }
        protected override JetBrains.ReSharper.Daemon.IDaemonStageProcess CreateProcess(JetBrains.ReSharper.Daemon.IDaemonProcess process, JetBrains.Application.Settings.IContextBoundSettingsStore settings, JetBrains.ReSharper.Daemon.DaemonProcessKind processKind, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptFile file) { }
        public override JetBrains.ReSharper.Daemon.ErrorStripeRequest NeedsErrorStripe(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, JetBrains.Application.Settings.IContextBoundSettingsStore settings) { }
    }
    [JetBrains.ProjectModel.ProjectFileTypeAttribute(typeof(JetBrains.ProjectModel.KnownProjectFileType))]
    public class JavaScriptInspectionsProcessFactory : JetBrains.ReSharper.Daemon.JavaScript.Stages.InspectionsStage.IJavaScriptInspectionsProcessFactory
    {
        public virtual JetBrains.ReSharper.Daemon.IDaemonStageProcess CreateInspectionsProcess(JetBrains.ReSharper.Daemon.IDaemonProcess process, JetBrains.Application.Settings.IContextBoundSettingsStore settings, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptFile file) { }
    }
}
namespace JetBrains.ReSharper.Daemon.JavaScript.Stages.JSon
{
    
    [JetBrains.ReSharper.Daemon.DaemonStageAttribute(StagesBefore=new System.Type[] {
            typeof(JetBrains.ReSharper.Daemon.JavaScript.Stages.SmartResolver.SmartResolverStage)})]
    public class IdentifierHighlightingStage : JetBrains.ReSharper.Daemon.JavaScript.Stages.JSon.JsonDaemonStageBase
    {
        public IdentifierHighlightingStage(JetBrains.ReSharper.Daemon.Stages.Resolve.ResolveHighlighterRegistrar resolveHighlighterRegistrar) { }
        protected override JetBrains.ReSharper.Daemon.IDaemonStageProcess CreateProcess(JetBrains.ReSharper.Daemon.IDaemonProcess process, JetBrains.Application.Settings.IContextBoundSettingsStore settings, JetBrains.ReSharper.Daemon.DaemonProcessKind processKind, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptFile file) { }
        public override JetBrains.ReSharper.Daemon.ErrorStripeRequest NeedsErrorStripe(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, JetBrains.Application.Settings.IContextBoundSettingsStore settings) { }
    }
    public abstract class JsonDaemonStageBase : JetBrains.ReSharper.Daemon.IDaemonStage
    {
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Daemon.IDaemonStageProcess> CreateProcess(JetBrains.ReSharper.Daemon.IDaemonProcess process, JetBrains.Application.Settings.IContextBoundSettingsStore settings, JetBrains.ReSharper.Daemon.DaemonProcessKind processKind) { }
        protected abstract JetBrains.ReSharper.Daemon.IDaemonStageProcess CreateProcess(JetBrains.ReSharper.Daemon.IDaemonProcess process, JetBrains.Application.Settings.IContextBoundSettingsStore settings, JetBrains.ReSharper.Daemon.DaemonProcessKind processKind, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptFile file);
        protected static bool IsSupported(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
        public abstract JetBrains.ReSharper.Daemon.ErrorStripeRequest NeedsErrorStripe(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, JetBrains.Application.Settings.IContextBoundSettingsStore settings);
    }
    public class JsonIdentifierHighlighterProcess : JetBrains.ReSharper.Daemon.JavaScript.Stages.IdentifierHighlighterProcess
    {
        public JsonIdentifierHighlighterProcess(JetBrains.ReSharper.Daemon.Stages.Resolve.ResolveHighlighterRegistrar resolveHighlighterRegistrar, JetBrains.ReSharper.Daemon.IDaemonProcess daemonProcess, JetBrains.Application.Settings.IContextBoundSettingsStore settingsStore, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptFile file, JetBrains.ReSharper.Daemon.DaemonProcessKind processKind) { }
    }
    public class JsonInspectionsProcess : JetBrains.ReSharper.Daemon.JavaScript.Impl.JavaScriptDaemonStageProcessBase
    {
        public JsonInspectionsProcess(JetBrains.ReSharper.Daemon.IDaemonProcess process, JetBrains.Application.Settings.IContextBoundSettingsStore settingsStore, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptFile file) { }
        public override void Execute(System.Action<JetBrains.ReSharper.Daemon.DaemonStageResult> committer) { }
        public override void VisitArrayLiteral(JetBrains.ReSharper.Psi.JavaScript.Tree.IArrayLiteral arrayLiteral, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer consumer) { }
        public override void VisitObjectLiteral(JetBrains.ReSharper.Psi.JavaScript.Tree.IObjectLiteral objectLiteral, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer consumer) { }
        public override void VisitObjectPropertyDeclaration(JetBrains.ReSharper.Psi.JavaScript.Tree.IObjectPropertyDeclaration declaration, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer consumer) { }
    }
    [JetBrains.ReSharper.Daemon.DaemonStageAttribute(StagesBefore=new System.Type[] {
            typeof(JetBrains.ReSharper.Daemon.JavaScript.Stages.SmartResolver.SmartResolverStage)})]
    public class JsonInspectionsStage : JetBrains.ReSharper.Daemon.JavaScript.Stages.JSon.JsonDaemonStageBase
    {
        protected override JetBrains.ReSharper.Daemon.IDaemonStageProcess CreateProcess(JetBrains.ReSharper.Daemon.IDaemonProcess process, JetBrains.Application.Settings.IContextBoundSettingsStore settings, JetBrains.ReSharper.Daemon.DaemonProcessKind processKind, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptFile file) { }
        public override JetBrains.ReSharper.Daemon.ErrorStripeRequest NeedsErrorStripe(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, JetBrains.Application.Settings.IContextBoundSettingsStore settings) { }
    }
}
namespace JetBrains.ReSharper.Daemon.JavaScript.Stages.Resolve
{
    
    public class ResolveProblemHighlighter
    {
        public ResolveProblemHighlighter([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.IFile file, JetBrains.ReSharper.Daemon.Stages.Resolve.ResolveHighlighterRegistrar resolveHighlighterRegistrar, JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.JavaScriptResolveContext context) { }
        public void CheckForResolveProblems(JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer consumer, JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public void CheckForResolveProblems(JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer consumer, JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
    }
}
namespace JetBrains.ReSharper.Daemon.JavaScript.Stages.SmartResolver
{
    
    public class JsSmartResolverProcess : JetBrains.ReSharper.Daemon.JavaScript.Impl.JavaScriptDaemonStageProcessBase
    {
        public JsSmartResolverProcess(JetBrains.ReSharper.Daemon.IDaemonProcess daemonProcess, JetBrains.Application.Settings.IContextBoundSettingsStore settingsStore, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptFile file) { }
        public System.Collections.Generic.Dictionary<JetBrains.ReSharper.Psi.IDeclaredElement, bool> SymbolUsedProperty { get; }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Psi.IDeclaredElement> UnusedSymbols { get; }
        public override void Execute(System.Action<JetBrains.ReSharper.Daemon.DaemonStageResult> committer) { }
        protected virtual JetBrains.ReSharper.Daemon.JavaScript.Stages.SmartResolver.JsSmartResolverProcess.NonQualifiedResolver GetNonQualifiedResolver(JetBrains.ReSharper.Daemon.Stages.DefaultHighlightingConsumer consumer) { }
        protected class NonQualifiedResolver : JetBrains.ReSharper.Psi.Resolve.AllNonQualifiedReferencesResolver
        {
            protected readonly JetBrains.ReSharper.Daemon.Stages.DefaultHighlightingConsumer myConsumer;
            protected readonly JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptFile myFile;
            protected readonly JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.JavaScriptResolveContext myJsResolveContext;
            protected readonly JetBrains.ReSharper.Daemon.JavaScript.Stages.SmartResolver.JsSmartResolverProcess mySmartResolverProcess;
            public NonQualifiedResolver(JetBrains.ReSharper.Daemon.Stages.DefaultHighlightingConsumer consumer, JetBrains.ReSharper.Daemon.JavaScript.Stages.SmartResolver.JsSmartResolverProcess smartResolverProcess, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptFile file) { }
            protected bool IsLocalElement(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
            protected virtual void ProcessReferences(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
            protected virtual bool ShouldCheckConflictsWithOuterScope(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
            protected virtual void VisitDeclaration(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration) { }
            protected virtual void VisitElement(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
            protected void VisitReferenceExpressionReference(JetBrains.ReSharper.Psi.JavaScript.Resolve.IReferenceExpressionReference reference) { }
        }
    }
    [JetBrains.ReSharper.Daemon.DaemonStageAttribute(StagesBefore=new System.Type[] {
            typeof(JetBrains.ReSharper.Daemon.Stages.GlobalFileStructureCollectorStage)})]
    public class SmartResolverStage : JetBrains.ReSharper.Daemon.JavaScript.Impl.JavaScriptDaemonStageBase
    {
        protected override JetBrains.ReSharper.Daemon.IDaemonStageProcess CreateProcess(JetBrains.ReSharper.Daemon.IDaemonProcess process, JetBrains.Application.Settings.IContextBoundSettingsStore settings, JetBrains.ReSharper.Daemon.DaemonProcessKind processKind, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptFile file) { }
        public override JetBrains.ReSharper.Daemon.ErrorStripeRequest NeedsErrorStripe(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, JetBrains.Application.Settings.IContextBoundSettingsStore settings) { }
    }
}
namespace JetBrains.ReSharper.Daemon.JavaScript.Stages.TypeScript.Inspections
{
    
    [JetBrains.ReSharper.Daemon.DaemonStageAttribute(StagesBefore=new System.Type[] {
            typeof(JetBrains.ReSharper.Daemon.JavaScript.Stages.SmartResolver.SmartResolverStage),
            typeof(JetBrains.ReSharper.Daemon.JavaScript.Stages.FileStructureState.JavaScriptFileIndexStage)})]
    public class TsInspectionsStage : JetBrains.ReSharper.Daemon.JavaScript.Stages.InspectionsStage.InspectionsStage
    {
        public TsInspectionsStage(JetBrains.ProjectModel.FileTypes.ProjectFileTypeServices services) { }
        protected override JetBrains.ReSharper.Daemon.IDaemonStageProcess CreateProcess(JetBrains.ReSharper.Daemon.IDaemonProcess process, JetBrains.Application.Settings.IContextBoundSettingsStore settings, JetBrains.ReSharper.Daemon.DaemonProcessKind processKind, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptFile file) { }
        protected override bool IsSupported(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
    }
}
namespace JetBrains.ReSharper.Daemon.JavaScript.Stages.TypeScript.SmartResolver
{
    
    public class TsSmartResolverProcess : JetBrains.ReSharper.Daemon.JavaScript.Stages.SmartResolver.JsSmartResolverProcess
    {
        public TsSmartResolverProcess(JetBrains.ReSharper.Daemon.IDaemonProcess daemonProcess, JetBrains.Application.Settings.IContextBoundSettingsStore settingsStore, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptFile file) { }
        protected override JetBrains.ReSharper.Daemon.JavaScript.Stages.SmartResolver.JsSmartResolverProcess.NonQualifiedResolver GetNonQualifiedResolver(JetBrains.ReSharper.Daemon.Stages.DefaultHighlightingConsumer consumer) { }
        protected class TsNonQualifiedResolver : JetBrains.ReSharper.Daemon.JavaScript.Stages.SmartResolver.JsSmartResolverProcess.NonQualifiedResolver
        {
            public TsNonQualifiedResolver(JetBrains.ReSharper.Daemon.Stages.DefaultHighlightingConsumer consumer, JetBrains.ReSharper.Daemon.JavaScript.Stages.SmartResolver.JsSmartResolverProcess smartResolverProcess, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptFile file) { }
            public override void ProcessAfterInterior(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
            public override void ProcessBeforeInterior(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
            protected override void ProcessReferences(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
            protected override bool ShouldCheckConflictsWithOuterScope(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
            protected override void VisitDeclaration(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration) { }
        }
    }
    [JetBrains.ReSharper.Daemon.DaemonStageAttribute(StagesBefore=new System.Type[] {
            typeof(JetBrains.ReSharper.Daemon.Stages.GlobalFileStructureCollectorStage)})]
    public class TsSmartResolverStage : JetBrains.ReSharper.Daemon.JavaScript.Stages.SmartResolver.SmartResolverStage
    {
        protected override JetBrains.ReSharper.Daemon.IDaemonStageProcess CreateProcess(JetBrains.ReSharper.Daemon.IDaemonProcess process, JetBrains.Application.Settings.IContextBoundSettingsStore settings, JetBrains.ReSharper.Daemon.DaemonProcessKind processKind, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptFile file) { }
        protected override bool IsSupported(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
    }
}
namespace JetBrains.ReSharper.Daemon.JavaScript.Stages.TypeScript.Syntax
{
    
    public class TsSyntaxHighlightingProcess : JetBrains.ReSharper.Daemon.JavaScript.Prelude.TypeScript.TsDaemonStageProcessBase
    {
        public TsSyntaxHighlightingProcess(JetBrains.ReSharper.Daemon.IDaemonProcess process, JetBrains.Application.Settings.IContextBoundSettingsStore settingsStore, JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsFile file) { }
        public override void Execute(System.Action<JetBrains.ReSharper.Daemon.DaemonStageResult> committer) { }
        public override void VisitNode(JetBrains.ReSharper.Psi.Tree.ITreeNode node, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer context) { }
        public override void VisitTsArrayTypeUsage(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsArrayTypeUsage arrayTypeParam, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer context) { }
        public override void VisitTsBaseTypeClause(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsBaseTypeClause tsBaseTypeClauseParam, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer context) { }
        public override void VisitTsClassDeclaration(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsClassDeclaration tsClassDeclaration, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer context) { }
        public override void VisitTsClassMemberDeclaration(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsClassMemberDeclaration classMember, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer context) { }
        public override void VisitTsConstructorDeclaration(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsConstructorDeclaration tsConstructorDeclaration, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer context) { }
        public override void VisitTsConstructorOverloadDeclaration(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsConstructorOverloadDeclaration constructorOverloadDeclaration, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer context) { }
        public override void VisitTsEnumDeclaration(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsEnumDeclaration tsEnumDeclaration, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer context) { }
        public override void VisitTsExternalModuleReferenceName(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsExternalModuleReferenceName tsExternalModuleReferenceName, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer context) { }
        public override void VisitTsFunctionStatement(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsFunctionStatement tsFunctionStatement, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer context) { }
        public override void VisitTsFunctionStatementSignature(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsFunctionStatementSignature tsFunctionStatementSignatureParam, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer context) { }
        public override void VisitTsIndexSignatureDeclaration(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsIndexSignatureDeclaration indexSignature, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer context) { }
        public override void VisitTsInterfaceDeclaration(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsInterfaceDeclaration tsInterfaceDeclaration, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer context) { }
        public override void VisitTsMemberAccessorDeclaration(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsMemberAccessorDeclaration memberAccessorDeclaration, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer context) { }
        public override void VisitTsMemberFunctionDeclaration(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsMemberFunctionDeclaration memberFunctionDeclaration, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer context) { }
        public override void VisitTsMemberFunctionOverloadDeclaration(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsMemberFunctionOverloadDeclaration tsMemberFunctionOverloadDeclaration, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer context) { }
        public override void VisitTsMemberVariableDeclaration(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsMemberVariableDeclaration tsMemberVariableDeclaration, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer context) { }
        public override void VisitTsParametersList(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsParametersList tsParametersList, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer context) { }
        public override void VisitTsTypeParameterDeclaration(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsTypeParameterDeclaration typeParameterDeclaration, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer context) { }
        public override void VisitTsVariableDeclaration(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsVariableDeclaration variableDeclaration, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer context) { }
        public override void VisitTsVariableDeclarationStatement(JetBrains.ReSharper.Psi.JavaScript.Tree.TypeScript.ITsVariableDeclarationStatement typeScriptVariableStatement, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer context) { }
    }
    [JetBrains.ReSharper.Daemon.DaemonStageAttribute()]
    public class TypeScriptSyntaxErrorHighlightingStage : JetBrains.ReSharper.Daemon.JavaScript.Impl.JavaScriptDaemonStageBase
    {
        protected override JetBrains.ReSharper.Daemon.IDaemonStageProcess CreateProcess(JetBrains.ReSharper.Daemon.IDaemonProcess process, JetBrains.Application.Settings.IContextBoundSettingsStore settings, JetBrains.ReSharper.Daemon.DaemonProcessKind processKind, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptFile file) { }
        protected override bool IsSupported(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
        public override JetBrains.ReSharper.Daemon.ErrorStripeRequest NeedsErrorStripe(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, JetBrains.Application.Settings.IContextBoundSettingsStore settings) { }
    }
}
namespace JetBrains.ReSharper.Daemon.JavaScript.Util
{
    
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class JavaScriptIdentifierHighlightingUtil
    {
        public JavaScriptIdentifierHighlightingUtil(JetBrains.ReSharper.Psi.JavaScript.Services.JavaScriptServices javaScriptServices) { }
        public void HighlightIdentifiersIn(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer consumer, JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptFile file, JetBrains.ReSharper.Psi.JavaScript.Impl.Resolve.JavaScriptResolveContext context) { }
    }
    public class static SyntaxCheckerUtil
    {
        public static bool CanBeInvoked(JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression invokedExpression) { }
        public static bool CanBeNewArgument(JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression expression) { }
        public static bool IsIdentifierExpression(JetBrains.ReSharper.Psi.JavaScript.Tree.ICompoundExpression value) { }
        public static bool IsLValue(JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression expression) { }
    }
}