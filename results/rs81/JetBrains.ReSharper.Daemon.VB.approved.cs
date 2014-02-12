[assembly: JetBrains.ReSharper.Daemon.CompilerIdForLanguageAttribute(typeof(JetBrains.ReSharper.Daemon.UsageChecking.UnusedVariableCompilerWarning), "VBASIC", "BC42024")]
[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("RedundantMyBaseQualifier", null, "CodeRedundancy", "Redundant \'MyBase.\' qualifier", "\'MyBase.\' qualifier is redundant and can be safely removed without changing code " +
    "semantics.", JetBrains.ReSharper.Daemon.Severity.WARNING, false, Internal=false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("UnusedImportClause", null, "CodeRedundancy", "Unused import clause", "Import clause is not used in the file and could be safely removed", JetBrains.ReSharper.Daemon.Severity.WARNING, false, Internal=false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("VBWarnings::WME006", null, "CompilerWarnings", "WME006:Namespace should be default namespace of this project", "WME006:Namespace should be default namespace of this project", JetBrains.ReSharper.Daemon.Severity.WARNING, false, Internal=false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("RedundantMyClassQualifier", null, "CodeRedundancy", "Redundant \'MyClass.\' qualifier", "\'MyClass.\' qualifier is redundant and can be safely removed without changing code" +
    " semantics.", JetBrains.ReSharper.Daemon.Severity.WARNING, false, Internal=false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("SimplifyIIf", null, "BestPractice", "Simplify \'IIf\'", "\\n              \'IIf\' contains \'True\' or \'False\' in result branch, for example\\n " +
    "             <pre>\\n                IIf(condition, True, elseBranch)\\n          " +
    "      IIf(condition, thenBranch : True)\\n              </pre>\\n              ", JetBrains.ReSharper.Daemon.Severity.SUGGESTION, false, Internal=false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("SimplifyConditionalOperator", null, "BestPractice", "Simplify conditional operator", "\\n              Conditional operator contains \'True\' or \'False\' in result branch," +
    " for example\\n              <pre>\\n                If(condition, True, elseBranc" +
    "h)\\n                If(condition, thenBranch : True)\\n              </pre>\\n    " +
    "          ", JetBrains.ReSharper.Daemon.Severity.SUGGESTION, false, Internal=false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("RedundantIteratorKeyword", null, "CodeRedundancy", "Iterator function without Yield statements", "Iterator function without Yield statements", JetBrains.ReSharper.Daemon.Severity.WARNING, false, Internal=false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("RedundantQualifier", null, "CodeRedundancy", "Redundant qualifier", "Qualifier is redundant", JetBrains.ReSharper.Daemon.Severity.WARNING, false, Internal=false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("RedundantMeQualifier", null, "CodeRedundancy", "Redundant \'Me.\' qualifier", "\'Me.\' qualifier is redundant and can be safely removed without changing code sema" +
    "ntics.", JetBrains.ReSharper.Daemon.Severity.WARNING, false, Internal=false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("VbUnreachableCode", null, "CodeRedundancy", "Unreachable code", "Code is unreachable", JetBrains.ReSharper.Daemon.Severity.WARNING, false, Internal=false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("InactivePreprocessorBranch", null, "CodeInfo", "Inactive preprocessor branch", "Inactive preprocessor branch", JetBrains.ReSharper.Daemon.Severity.WARNING, false, Internal=false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("RedundantEmptyCaseElse", null, "CodeRedundancy", "Redundant empty Case Else statement", "Redundant empty Case Else statement", JetBrains.ReSharper.Daemon.Severity.WARNING, false, Internal=false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("RedundantArrayLowerBoundSpecification", null, "CodeRedundancy", "Redundant array lower bound specification", "Array lower bound specification is redundant", JetBrains.ReSharper.Daemon.Severity.WARNING, false, Internal=false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("PossibleWriteToMe", null, "CodeSmell", "Possible write to \'Me\'", "Possible write to \'Me\'.", JetBrains.ReSharper.Daemon.Severity.WARNING, false, Internal=false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("NotAssignedOutParameter", null, "CodeSmell", "\'out\' parameter is not assigned upon exit", "\'out\' parameter is not assigned upon exit", JetBrains.ReSharper.Daemon.Severity.WARNING, false, Internal=false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("VBWarnings::BC42358", null, "CompilerWarnings", " BC42358: Because this call is not awaited, execution of the current method conti" +
    "nues before the call is completed. Consider applying the \'Await\' operator to the" +
    " result of the call.", " BC42358: Because this call is not awaited, execution of the current method conti" +
    "nues before the call is completed. Consider applying the \'Await\' operator to the" +
    " result of the call.", JetBrains.ReSharper.Daemon.Severity.WARNING, false, Internal=false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("VBWarnings::BC400005", null, "CompilerWarnings", " BC400005:Member shadows an overriable member", " BC400005:Member shadows an overriable member", JetBrains.ReSharper.Daemon.Severity.WARNING, false, Internal=false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("VBWarnings::BC42356", null, "CompilerWarnings", " BC42356:Async method lacks \'Await\' operators", " BC42356:Async method lacks \'Await\' operators", JetBrains.ReSharper.Daemon.Severity.WARNING, false, Internal=false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("VBWarnings::BC42349", null, "CompilerWarnings", "BC42349:Redundant DirectCast to the equals value type", "BC42349:Redundant DirectCast to the equals value type", JetBrains.ReSharper.Daemon.Severity.WARNING, false, Internal=false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("VBWarnings::BC40056", null, "CompilerWarnings", "BC40056:Namespace or type specified in the Imports \'name\' doesn\'t contain any pub" +
    "lic member or cannot be found", "BC40056:Namespace or type specified in the Imports \'name\' doesn\'t contain any pub" +
    "lic member or cannot be found", JetBrains.ReSharper.Daemon.Severity.WARNING, false, Internal=false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("VBWarnings::BC42104", null, "CompilerWarnings", "BC42104:Variable is used before it has been assigned a value", "BC42104:Variable is used before it has been assigned a value", JetBrains.ReSharper.Daemon.Severity.WARNING, false, Internal=false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("VBWarnings::BC42322", null, "CompilerWarnings", "BC42322:Runtime errors might occur when converting X to Y", "BC42322:Runtime errors might occur when converting X to Y", JetBrains.ReSharper.Daemon.Severity.WARNING, false, Internal=false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("VBWarnings::BC42016", null, "CompilerWarnings", "BC42016:Runtime errors might occur when converting X to Y", "BC42016:Runtime errors might occur when converting X to Y", JetBrains.ReSharper.Daemon.Severity.WARNING, false, Internal=false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("VBWarnings::BC42025", null, "CompilerWarnings", "BC42025:Access of shared member through an instance", "BC42025:Access of shared member through an instance", JetBrains.ReSharper.Daemon.Severity.WARNING, false, Internal=false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("VBWarnings::BC40008", null, "CompilerWarnings", "BC40008:Use obsolete member (without message)", "BC40008:Use obsolete member (without message)", JetBrains.ReSharper.Daemon.Severity.WARNING, false, Internal=false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("VBWarnings::BC40000", null, "CompilerWarnings", "BC40000:Use obsolete member", "BC40000:Use obsolete member", JetBrains.ReSharper.Daemon.Severity.WARNING, false, Internal=false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("VBWarnings::BC42304", null, "CompilerWarnings", "BC42304:Syntax error in XML comment", "BC42304:Syntax error in XML comment", JetBrains.ReSharper.Daemon.Severity.WARNING, false, Internal=false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("VBWarnings::BC42309", null, "CompilerWarnings", "BC42309:XML comment has a tag with a \'cref\' attribute that could not be resolved", "BC42309:XML comment has a tag with a \'cref\' attribute that could not be resolved", JetBrains.ReSharper.Daemon.Severity.WARNING, false, Internal=false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("VBWarnings::BC42353", null, "CompilerWarnings", "BC42353,BC42354,BC42355:Function doesn\'t return a value on all code paths", "BC42353,BC42354,BC42355:Function doesn\'t return a value on all code paths", JetBrains.ReSharper.Daemon.Severity.WARNING, false, Internal=false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("VBWarnings::BC42105", null, "CompilerWarnings", "BC42105,BC42106,BC42107:Function doesn\'t return a value on all code paths", "BC42105,BC42106,BC42107:Function doesn\'t return a value on all code paths", JetBrains.ReSharper.Daemon.Severity.WARNING, false, Internal=false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterStaticHighlightingsGroupAttribute("VBErrors", "VB Compiler Errors", true)]
[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]

namespace JetBrains.ReSharper.Daemon.VB.Errors
{
    
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.UNRESOLVED_ERROR)]
    public class AccessRightsError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "Cannot access {0} {1} \'{2}\' here";
        public AccessRightsError(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.Resolve.IReference Reference { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("AccessToDisposedClosure", "VBASIC", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.WARNING)]
    public class AccessToDisposedClosureWarning : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "AccessToDisposedClosure";
        protected const string MESSAGE = "Access to disposed closure";
        public AccessToDisposedClosureWarning(JetBrains.ReSharper.Psi.VB.Tree.IReferenceExpression expression) { }
        public string ErrorStripeToolTip { get; }
        public JetBrains.ReSharper.Psi.VB.Tree.IReferenceExpression Expression { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("AccessToForEachVariableInClosure", "VBASIC", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.WARNING)]
    public class AccessToForEachVariableInClosureWarning : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "AccessToForEachVariableInClosure";
        protected const string MESSAGE = "Access to foreach variable in closure. May have different behaviour when compiled" +
            " with different versions of compiler";
        public AccessToForEachVariableInClosureWarning(JetBrains.ReSharper.Psi.VB.Tree.IReferenceExpression expression) { }
        public string ErrorStripeToolTip { get; }
        public JetBrains.ReSharper.Psi.VB.Tree.IReferenceExpression Expression { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("AccessToModifiedClosure", "VBASIC", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.WARNING)]
    public class AccessToModifiedClosureWarning : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "AccessToModifiedClosure";
        protected const string MESSAGE = "Access to modified closure";
        public AccessToModifiedClosureWarning(JetBrains.ReSharper.Psi.VB.Tree.IReferenceExpression expression) { }
        public string ErrorStripeToolTip { get; }
        public JetBrains.ReSharper.Psi.VB.Tree.IReferenceExpression Expression { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("AnnotationConflictInHierarchy", "VBASIC", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.WARNING)]
    public class AnnotationConflictInHierarchyWarning : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "AnnotationConflictInHierarchy";
        protected const string MESSAGE = "Nullness annotation conflicts with annotation in super type";
        public AnnotationConflictInHierarchyWarning(JetBrains.ReSharper.Psi.VB.Tree.IAttribute attribute, JetBrains.ReSharper.Psi.VB.Tree.IAttributesOwnerDeclaration declaration) { }
        public JetBrains.ReSharper.Psi.VB.Tree.IAttribute Attribute { get; }
        public JetBrains.ReSharper.Psi.VB.Tree.IAttributesOwnerDeclaration Declaration { get; }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("AnnotationRedundanceAtValueType", "VBASIC", AttributeId="ReSharper Dead Code", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.DEADCODE)]
    public class AnnotationRedundanceAtValueTypeWarning : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "AnnotationRedundanceAtValueType";
        protected const string MESSAGE = "Applying nullness annotation to {0} type is meaningless";
        public AnnotationRedundanceAtValueTypeWarning(JetBrains.ReSharper.Psi.VB.Tree.IAttribute attribute, JetBrains.ReSharper.Psi.VB.Tree.IAttributesOwnerDeclaration declaration, bool isVoid) { }
        public JetBrains.ReSharper.Psi.VB.Tree.IAttribute Attribute { get; }
        public JetBrains.ReSharper.Psi.VB.Tree.IAttributesOwnerDeclaration Declaration { get; }
        public string ErrorStripeToolTip { get; }
        public bool IsVoid { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("AnnotationRedundanceInHierarchy", "VBASIC", AttributeId="ReSharper Dead Code", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.DEADCODE)]
    public class AnnotationRedundanceInHierarchyWarning : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "AnnotationRedundanceInHierarchy";
        protected const string MESSAGE = "Base declaration has the same annotation";
        public AnnotationRedundanceInHierarchyWarning(JetBrains.ReSharper.Psi.VB.Tree.IAttribute attribute, JetBrains.ReSharper.Psi.VB.Tree.IAttributesOwnerDeclaration declaration) { }
        public JetBrains.ReSharper.Psi.VB.Tree.IAttribute Attribute { get; }
        public JetBrains.ReSharper.Psi.VB.Tree.IAttributesOwnerDeclaration Declaration { get; }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class ArgumentsMismatchError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "Arguments mismatch";
        public ArgumentsMismatchError(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.Resolve.IReference Reference { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class ArrayBoundSpecificationForNonTopLevelArrayError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "When initializing an array of arrays, bounds can only be specified for the top-le" +
            "vel array";
        public ArrayBoundSpecificationForNonTopLevelArrayError(JetBrains.ReSharper.Psi.VB.Tree.IArrayBound boundSpecificationExpression) { }
        public JetBrains.ReSharper.Psi.VB.Tree.IArrayBound BoundSpecificationExpression { get; }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class ArrayBoundSpecificationInTypeSpecifierError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "Array bounds cannot appear in type specifiers";
        public ArrayBoundSpecificationInTypeSpecifierError(JetBrains.ReSharper.Psi.VB.Tree.IArrayBound bound) { }
        public JetBrains.ReSharper.Psi.VB.Tree.IArrayBound Bound { get; }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class ArrayExceeds32DimensionsError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "Array exceeds the limit of 32 dimensions";
        public ArrayExceeds32DimensionsError(JetBrains.ReSharper.Psi.VB.Tree.IArrayModifier arrayModifier) { }
        public JetBrains.ReSharper.Psi.VB.Tree.IArrayModifier ArrayModifier { get; }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class ArrayInitializerExpectedError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "Array initializer is expected";
        public ArrayInitializerExpectedError(JetBrains.ReSharper.Psi.VB.Tree.IVBExpression initializer) { }
        public string ErrorStripeToolTip { get; }
        public JetBrains.ReSharper.Psi.VB.Tree.IVBExpression Initializer { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class ArrayInitializerHasTooFewDimensionsError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "Array initializer has too few dimensions";
        public ArrayInitializerHasTooFewDimensionsError(JetBrains.ReSharper.Psi.VB.Tree.IVBExpression expression) { }
        public string ErrorStripeToolTip { get; }
        public JetBrains.ReSharper.Psi.VB.Tree.IVBExpression Expression { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class ArrayInitializerHasTooManyDimensionsError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "Array initializer has too many dimensions";
        public ArrayInitializerHasTooManyDimensionsError(JetBrains.ReSharper.Psi.VB.Tree.IVBExpression expression) { }
        public string ErrorStripeToolTip { get; }
        public JetBrains.ReSharper.Psi.VB.Tree.IVBExpression Expression { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class ArrayInitializerSizeMismatchError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "Array initializer length does not match the specified array size";
        public ArrayInitializerSizeMismatchError(JetBrains.ReSharper.Psi.VB.Tree.IAnonymousArrayCreationExpression initializer) { }
        public string ErrorStripeToolTip { get; }
        public JetBrains.ReSharper.Psi.VB.Tree.IAnonymousArrayCreationExpression Initializer { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class ArrayLowerBoundsCanBeOnlyZeroError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "Lower array bounds can only be set to \'0\'";
        public ArrayLowerBoundsCanBeOnlyZeroError(JetBrains.ReSharper.Psi.VB.Tree.IVBExpression lowerBoundExpression) { }
        public string ErrorStripeToolTip { get; }
        public JetBrains.ReSharper.Psi.VB.Tree.IVBExpression LowerBoundExpression { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class ArrayModifiersSpecificationOnBothVariableAndItsTypeError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "Array modifiers cannot be specified on both a variable and its type";
        public ArrayModifiersSpecificationOnBothVariableAndItsTypeError(JetBrains.ReSharper.Psi.VB.Tree.ITypeUsage typeUsage) { }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public JetBrains.ReSharper.Psi.VB.Tree.ITypeUsage TypeUsage { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("RedundantAssignment", "VBASIC", AttributeId="ReSharper Dead Code", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.DEADCODE)]
    public class AssignmentNotUsedWarning : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "RedundantAssignment";
        protected const string MESSAGE = "Value assigned is not used in any execution path";
        public AssignmentNotUsedWarning(JetBrains.ReSharper.Psi.VB.Tree.IAssignmentStatement statement) { }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.VB.Tree.IAssignmentStatement Statement { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class AssignmentToMeError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "\'Me\' cannot be the target of an assignment";
        public AssignmentToMeError(JetBrains.ReSharper.Psi.VB.Tree.IInstanceExpression instanceExpression) { }
        public string ErrorStripeToolTip { get; }
        public JetBrains.ReSharper.Psi.VB.Tree.IInstanceExpression InstanceExpression { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class AsyncMehodCannotHaveByRefParametersError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "Async {0} cannot have ByRef parameters";
        public AsyncMehodCannotHaveByRefParametersError(JetBrains.ReSharper.Psi.IParameter parameter, string name) { }
        public string ErrorStripeToolTip { get; }
        public string Name { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.IParameter Parameter { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("VBWarnings::BC42358", "VBASIC", CompilerIds=new string[] {
            "BC42358"}, CompilerIdsWithDescription=" BC42358: Because this call is not awaited, execution of the current method conti" +
        "nues before the call is completed. Consider applying the \'Await\' operator to the" +
        " result of the call.", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.WARNING)]
    public class AsyncMethodInvocationWithoutAwaitWarning : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "VBWarnings::BC42358";
        protected const string MESSAGE = "Because this call is not awaited, execution of the current method continues befor" +
            "e the call is completed. Consider applying the \'Await\' operator to the result of" +
            " the call.";
        public AsyncMethodInvocationWithoutAwaitWarning(JetBrains.ReSharper.Psi.VB.Tree.IInvocationStatement invocation, JetBrains.ReSharper.Psi.VB.Tree.IIndexExpression indexExpression) { }
        public string ErrorStripeToolTip { get; }
        public JetBrains.ReSharper.Psi.VB.Tree.IIndexExpression IndexExpression { get; }
        public JetBrains.ReSharper.Psi.VB.Tree.IInvocationStatement Invocation { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("VBWarnings::BC42356", "VBASIC", AttributeId="ReSharper Dead Code", CompilerIds=new string[] {
            "BC42356"}, CompilerIdsWithDescription=" BC42356:Async method lacks \'Await\' operators", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.DEADCODE)]
    public class AsyncMethodWithoutAwait2Warning : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "VBWarnings::BC42356";
        protected const string MESSAGE = "Async method without Await operator";
        public AsyncMethodWithoutAwait2Warning(JetBrains.ReSharper.Psi.VB.Tree.IVBDeclaration declaration) { }
        public JetBrains.ReSharper.Psi.VB.Tree.IVBDeclaration Declaration { get; }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("VBWarnings::BC42356", "VBASIC", CompilerIds=new string[] {
            "BC42356"}, CompilerIdsWithDescription=" BC42356:Async method lacks \'Await\' operators", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.WARNING)]
    public class AsyncMethodWithoutAwaitWarning : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "VBWarnings::BC42356";
        protected const string MESSAGE = "Async method without Await operator";
        public AsyncMethodWithoutAwaitWarning(JetBrains.ReSharper.Psi.VB.Tree.IVBDeclaration declaration) { }
        public JetBrains.ReSharper.Psi.VB.Tree.IVBDeclaration Declaration { get; }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class AsyncModifierIsNotValidOnThisItemError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "The modifier \'Async\' is not valid for this item";
        public AsyncModifierIsNotValidOnThisItemError(JetBrains.ReSharper.Psi.VB.Tree.IModifiersList modifiersList, JetBrains.ReSharper.Psi.Tree.ITokenNode tokenNode) { }
        public string ErrorStripeToolTip { get; }
        public JetBrains.ReSharper.Psi.VB.Tree.IModifiersList ModifiersList { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.Tree.ITokenNode TokenNode { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class AsyncOrIteratorLambdaToExpressionTreeError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "Async or Iterator lambda expression cannot be converted to expression trees";
        public AsyncOrIteratorLambdaToExpressionTreeError(JetBrains.ReSharper.Psi.VB.Tree.ILambdaExpression lambdaExpression) { }
        public string ErrorStripeToolTip { get; }
        public JetBrains.ReSharper.Psi.VB.Tree.ILambdaExpression LambdaExpression { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class AttributeNameExpectedError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "\'{0}\' is not an attribute";
        public AttributeNameExpectedError(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.Resolve.IReference Reference { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class AutoPropertyWithParametersError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "Auto property cannot have parameters";
        public AutoPropertyWithParametersError(JetBrains.ReSharper.Psi.VB.Tree.IPropertyDeclaration declaration) { }
        public JetBrains.ReSharper.Psi.VB.Tree.IPropertyDeclaration Declaration { get; }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR, OverloadResolvePriority=10)]
    public class AwaitCannotBeUsedInCatchFinallySyncLockError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "\'Await\' cannot be used in a Try Catch or a Try Finally or a SyncLock";
        public AwaitCannotBeUsedInCatchFinallySyncLockError(JetBrains.ReSharper.Psi.VB.Tree.IAwaitExpression awaitExpression) { }
        public JetBrains.ReSharper.Psi.VB.Tree.IAwaitExpression AwaitExpression { get; }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR, OverloadResolvePriority=10)]
    public class AwaitCannotBeUsedInQueryExpressionError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "\'Await\' cannot currently be used in a LINQ query";
        public AwaitCannotBeUsedInQueryExpressionError(JetBrains.ReSharper.Psi.VB.Tree.IAwaitExpression awaitExpression) { }
        public JetBrains.ReSharper.Psi.VB.Tree.IAwaitExpression AwaitExpression { get; }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR, OverloadResolvePriority=10)]
    public class AwaitExpressionNotUnderAsyncMethodError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "Await can only be used in a method marked with the \'Async\' modifier";
        public AwaitExpressionNotUnderAsyncMethodError(JetBrains.ReSharper.Psi.VB.Tree.IAwaitExpression awaitExpression) { }
        public JetBrains.ReSharper.Psi.VB.Tree.IAwaitExpression AwaitExpression { get; }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class BadAwaitPatternError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "Type \'{0}\' doesn\'t follow the await pattern";
        public BadAwaitPatternError(JetBrains.ReSharper.Psi.VB.Tree.IAwaitExpression awaitExpression, JetBrains.ReSharper.Psi.IExpressionType expressionType) { }
        public JetBrains.ReSharper.Psi.VB.Tree.IAwaitExpression AwaitExpression { get; }
        public string ErrorStripeToolTip { get; }
        public JetBrains.ReSharper.Psi.IExpressionType ExpressionType { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("BaseMethodCallWithDefaultParameter", "VBASIC", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.WARNING)]
    public class BaseMethodCallWithDefaultParameterWarning : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "BaseMethodCallWithDefaultParameter";
        protected const string MESSAGE = "Call to base member with implicit default parameters";
        public BaseMethodCallWithDefaultParameterWarning(JetBrains.ReSharper.Psi.VB.Tree.IReferenceExpression expression, JetBrains.ReSharper.Psi.Tree.ITreeNode errorPosition) { }
        public JetBrains.ReSharper.Psi.Tree.ITreeNode ErrorPosition { get; }
        public string ErrorStripeToolTip { get; }
        public JetBrains.ReSharper.Psi.VB.Tree.IReferenceExpression Expression { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("BaseObjectEqualsIsObjectEquals", "VBASIC", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.WARNING)]
    public class BaseObjectEqualsIsObjectEqualsWarning : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "BaseObjectEqualsIsObjectEquals";
        protected const string MESSAGE = "Call to \'MyBase.Equals(...)\' is reference equality";
        public BaseObjectEqualsIsObjectEqualsWarning(JetBrains.ReSharper.Psi.Tree.IExpression expression) { }
        public string ErrorStripeToolTip { get; }
        public JetBrains.ReSharper.Psi.Tree.IExpression Expression { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("BaseObjectGetHashCodeCallInGetHashCode", "VBASIC", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.WARNING)]
    public class BaseObjectGetHashCodeCallInGetHashCodeWarning : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "BaseObjectGetHashCodeCallInGetHashCode";
        protected const string MESSAGE = "Overriden GetHashCode calls base \'Object.GetHashCode()\'";
        public BaseObjectGetHashCodeCallInGetHashCodeWarning(JetBrains.ReSharper.Psi.VB.Tree.IReferenceExpression referenceExpression) { }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.VB.Tree.IReferenceExpression ReferenceExpression { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("CanBeReplacedWithTryCastAndCheckForNull", "VBASIC", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.WARNING)]
    public class CanBeReplacedWithTryCastAndCheckForNullWarning : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "CanBeReplacedWithTryCastAndCheckForNull";
        protected const string MESSAGE = "Can be replaced with \'Dim {0}{3} = TryCast({1}, {2}) If ({0} IsNot Nothing) ... E" +
            "ndIf\'";
        public CanBeReplacedWithTryCastAndCheckForNullWarning(JetBrains.ReSharper.Psi.VB.Tree.IBlockIfStatement ifStatement, JetBrains.ReSharper.Psi.IType type, JetBrains.ReSharper.Psi.VB.Tree.IVBExpression castSource, string castDestVarName, bool useVar, JetBrains.ReSharper.Psi.VB.Tree.IVBStatement targetVarDeclaration, System.Collections.Generic.List<string> uniqueNames) { }
        public string CastDestVarName { get; }
        public JetBrains.ReSharper.Psi.VB.Tree.IVBExpression CastSource { get; }
        public string ErrorStripeToolTip { get; }
        public JetBrains.ReSharper.Psi.VB.Tree.IBlockIfStatement IfStatement { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.VB.Tree.IVBStatement TargetVarDeclaration { get; }
        public string ToolTip { get; }
        public JetBrains.ReSharper.Psi.IType Type { get; }
        public System.Collections.Generic.List<string> UniqueNames { get; }
        public bool UseVar { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", AttributeId="ReSharper Underlined Error Highlighting", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.UNRESOLVED_ERROR)]
    public class CannotApplyBinaryOperatorError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "Cannot apply operator \'{0}\' to operands of type \'{1}\' and \'{2}\'";
        public CannotApplyBinaryOperatorError(JetBrains.ReSharper.Psi.VB.Tree.IVBOperatorReference reference, JetBrains.ReSharper.Psi.VB.Tree.IVBBinaryExpression expression) { }
        public string ErrorStripeToolTip { get; }
        public JetBrains.ReSharper.Psi.VB.Tree.IVBBinaryExpression Expression { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.VB.Tree.IVBOperatorReference Reference { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", AttributeId="ReSharper Underlined Error Highlighting", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.UNRESOLVED_ERROR)]
    public class CannotApplyUnaryOperatorError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "Cannot apply operator \'{0}\' to operand of type \'{1}\'";
        public CannotApplyUnaryOperatorError(JetBrains.ReSharper.Psi.VB.Tree.IVBOperatorReference reference) { }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.VB.Tree.IVBOperatorReference Reference { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class CannotAwaitNothingError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "Cannot await Nothing. Consider awaiting \'TaskEx.Yield()\' instead";
        public CannotAwaitNothingError(JetBrains.ReSharper.Psi.VB.Tree.IAwaitExpression awaitExpression) { }
        public JetBrains.ReSharper.Psi.VB.Tree.IAwaitExpression AwaitExpression { get; }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", AttributeId="ReSharper Underlined Error Highlighting", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.UNRESOLVED_ERROR)]
    public class CannotBeIndexedError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "Cannot apply indexing to type \'{0}\'";
        public CannotBeIndexedError(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.IType type) { }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.Resolve.IReference Reference { get; }
        public string ToolTip { get; }
        public JetBrains.ReSharper.Psi.IType Type { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class CannotConvertTypeInArgumentError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "{0}";
        public CannotConvertTypeInArgumentError(JetBrains.ReSharper.Psi.VB.IVBArgumentInfo argument, JetBrains.ReSharper.Psi.IType targetType) { }
        public JetBrains.ReSharper.Psi.VB.IVBArgumentInfo Argument { get; }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.IType TargetType { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("VBWarnings::BC42016", "VBASIC", CompilerIds=new string[] {
            "BC42016"}, CompilerIdsWithDescription="BC42016:Runtime errors might occur when converting X to Y", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class CannotConvertTypeInArgumentWarning : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "VBWarnings::BC42016";
        protected const string MESSAGE = "{0}";
        public CannotConvertTypeInArgumentWarning(JetBrains.ReSharper.Psi.VB.IVBArgumentInfo argument, JetBrains.ReSharper.Psi.IType targetType) { }
        public JetBrains.ReSharper.Psi.VB.IVBArgumentInfo Argument { get; }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.IType TargetType { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class CannotConvertTypeInAssignmentError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "{0}";
        public CannotConvertTypeInAssignmentError(JetBrains.ReSharper.Psi.VB.Tree.IAssignmentStatement assignmentStatement, JetBrains.ReSharper.Psi.IExpressionType sourceType, JetBrains.ReSharper.Psi.IType targetType) { }
        public JetBrains.ReSharper.Psi.VB.Tree.IAssignmentStatement AssignmentStatement { get; }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.IExpressionType SourceType { get; }
        public JetBrains.ReSharper.Psi.IType TargetType { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("VBWarnings::BC42016", "VBASIC", CompilerIds=new string[] {
            "BC42016"}, CompilerIdsWithDescription="BC42016:Runtime errors might occur when converting X to Y", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class CannotConvertTypeInAssignmentWarning : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "VBWarnings::BC42016";
        protected const string MESSAGE = "{0}";
        public CannotConvertTypeInAssignmentWarning(JetBrains.ReSharper.Psi.VB.Tree.IAssignmentStatement assignmentStatement, JetBrains.ReSharper.Psi.IExpressionType sourceType, JetBrains.ReSharper.Psi.IType targetType) { }
        public JetBrains.ReSharper.Psi.VB.Tree.IAssignmentStatement AssignmentStatement { get; }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.IExpressionType SourceType { get; }
        public JetBrains.ReSharper.Psi.IType TargetType { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class CannotConvertTypeInAsyncReturnError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "{0}";
        public CannotConvertTypeInAsyncReturnError(JetBrains.ReSharper.Psi.VB.Tree.IReturnStatement returnStatement, JetBrains.ReSharper.Psi.VB.Tree.IVBExpression expression, JetBrains.ReSharper.Psi.IType targetType) { }
        public string ErrorStripeToolTip { get; }
        public JetBrains.ReSharper.Psi.VB.Tree.IVBExpression Expression { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.VB.Tree.IReturnStatement ReturnStatement { get; }
        public JetBrains.ReSharper.Psi.IType TargetType { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("VBWarnings::BC42016", "VBASIC", CompilerIds=new string[] {
            "BC42016"}, CompilerIdsWithDescription="BC42016:Runtime errors might occur when converting X to Y", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class CannotConvertTypeInAsyncReturnWarning : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "VBWarnings::BC42016";
        protected const string MESSAGE = "{0}";
        public CannotConvertTypeInAsyncReturnWarning(JetBrains.ReSharper.Psi.VB.Tree.IReturnStatement returnStatement, JetBrains.ReSharper.Psi.VB.Tree.IVBExpression expression, JetBrains.ReSharper.Psi.IType targetType) { }
        public string ErrorStripeToolTip { get; }
        public JetBrains.ReSharper.Psi.VB.Tree.IVBExpression Expression { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.VB.Tree.IReturnStatement ReturnStatement { get; }
        public JetBrains.ReSharper.Psi.IType TargetType { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class CannotConvertTypeInDeclarationError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "{0}";
        public CannotConvertTypeInDeclarationError(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration, JetBrains.ReSharper.Psi.VB.Tree.IVBExpression expression, JetBrains.ReSharper.Psi.IType targetType) { }
        public JetBrains.ReSharper.Psi.Tree.IDeclaration Declaration { get; }
        public string ErrorStripeToolTip { get; }
        public JetBrains.ReSharper.Psi.VB.Tree.IVBExpression Expression { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.IType TargetType { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("VBWarnings::BC42016", "VBASIC", CompilerIds=new string[] {
            "BC42016"}, CompilerIdsWithDescription="BC42016:Runtime errors might occur when converting X to Y", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class CannotConvertTypeInDeclarationWarning : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "VBWarnings::BC42016";
        protected const string MESSAGE = "{0}";
        public CannotConvertTypeInDeclarationWarning(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration, JetBrains.ReSharper.Psi.VB.Tree.IVBExpression expression, JetBrains.ReSharper.Psi.IType targetType) { }
        public JetBrains.ReSharper.Psi.Tree.IDeclaration Declaration { get; }
        public string ErrorStripeToolTip { get; }
        public JetBrains.ReSharper.Psi.VB.Tree.IVBExpression Expression { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.IType TargetType { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class CannotConvertTypeInMemberInitializerError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "{0}";
        public CannotConvertTypeInMemberInitializerError(JetBrains.ReSharper.Psi.VB.Tree.IMemberInitializer initializer, JetBrains.ReSharper.Psi.VB.Tree.IVBExpression expression, JetBrains.ReSharper.Psi.IType targetType) { }
        public string ErrorStripeToolTip { get; }
        public JetBrains.ReSharper.Psi.VB.Tree.IVBExpression Expression { get; }
        public JetBrains.ReSharper.Psi.VB.Tree.IMemberInitializer Initializer { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.IType TargetType { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("VBWarnings::BC42016", "VBASIC", CompilerIds=new string[] {
            "BC42016"}, CompilerIdsWithDescription="BC42016:Runtime errors might occur when converting X to Y", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class CannotConvertTypeInMemberInitializerWarning : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "VBWarnings::BC42016";
        protected const string MESSAGE = "{0}";
        public CannotConvertTypeInMemberInitializerWarning(JetBrains.ReSharper.Psi.VB.Tree.IMemberInitializer initializer, JetBrains.ReSharper.Psi.VB.Tree.IVBExpression expression, JetBrains.ReSharper.Psi.IType targetType) { }
        public string ErrorStripeToolTip { get; }
        public JetBrains.ReSharper.Psi.VB.Tree.IVBExpression Expression { get; }
        public JetBrains.ReSharper.Psi.VB.Tree.IMemberInitializer Initializer { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.IType TargetType { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class CannotConvertTypeInReturnError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "{0}";
        public CannotConvertTypeInReturnError(JetBrains.ReSharper.Psi.VB.Tree.IReturnStatement returnStatement, JetBrains.ReSharper.Psi.VB.Tree.IVBExpression expression, JetBrains.ReSharper.Psi.IType targetType) { }
        public string ErrorStripeToolTip { get; }
        public JetBrains.ReSharper.Psi.VB.Tree.IVBExpression Expression { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.VB.Tree.IReturnStatement ReturnStatement { get; }
        public JetBrains.ReSharper.Psi.IType TargetType { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("VBWarnings::BC42016", "VBASIC", CompilerIds=new string[] {
            "BC42016"}, CompilerIdsWithDescription="BC42016:Runtime errors might occur when converting X to Y", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class CannotConvertTypeInReturnWarning : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "VBWarnings::BC42016";
        protected const string MESSAGE = "{0}";
        public CannotConvertTypeInReturnWarning(JetBrains.ReSharper.Psi.VB.Tree.IReturnStatement returnStatement, JetBrains.ReSharper.Psi.VB.Tree.IVBExpression expression, JetBrains.ReSharper.Psi.IType targetType) { }
        public string ErrorStripeToolTip { get; }
        public JetBrains.ReSharper.Psi.VB.Tree.IVBExpression Expression { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.VB.Tree.IReturnStatement ReturnStatement { get; }
        public JetBrains.ReSharper.Psi.IType TargetType { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class CannotConvertTypeInYieldError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "{0}";
        public CannotConvertTypeInYieldError(JetBrains.ReSharper.Psi.VB.Tree.IYieldStatement yieldStatement, JetBrains.ReSharper.Psi.IType targetType) { }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.IType TargetType { get; }
        public string ToolTip { get; }
        public JetBrains.ReSharper.Psi.VB.Tree.IYieldStatement YieldStatement { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("VBWarnings::BC42016", "VBASIC", CompilerIds=new string[] {
            "BC42016"}, CompilerIdsWithDescription="BC42016:Runtime errors might occur when converting X to Y", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class CannotConvertTypeInYieldWarning : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "VBWarnings::BC42016";
        protected const string MESSAGE = "{0}";
        public CannotConvertTypeInYieldWarning(JetBrains.ReSharper.Psi.VB.Tree.IYieldStatement yieldStatement, JetBrains.ReSharper.Psi.IType targetType) { }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.IType TargetType { get; }
        public string ToolTip { get; }
        public JetBrains.ReSharper.Psi.VB.Tree.IYieldStatement YieldStatement { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", AttributeId="ReSharper Underlined Error Highlighting", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.UNRESOLVED_ERROR)]
    public class CannotCreateInstanceOfInterfaceError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "Cannot create an instance of interface \'{0}\'";
        public CannotCreateInstanceOfInterfaceError(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.IInterface @interface) { }
        public string ErrorStripeToolTip { get; }
        public JetBrains.ReSharper.Psi.IInterface Interface { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.Resolve.IReference Reference { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", AttributeId="ReSharper Underlined Error Highlighting", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.UNRESOLVED_ERROR)]
    public class CannotCreateInstanceOfTypeParameterError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "Cannot create an instance of type parameter \'{0}\' because it does not have a \'New" +
            "\' constraint";
        public CannotCreateInstanceOfTypeParameterError(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.ITypeParameter typeParameter) { }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.Resolve.IReference Reference { get; }
        public string ToolTip { get; }
        public JetBrains.ReSharper.Psi.ITypeParameter TypeParameter { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class CannotDetermineNullCoalescingExpressionType2Error : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "Cannot infer a common type because more than one type is possible for \'{0}\' and \'" +
            "{1}\'";
        public CannotDetermineNullCoalescingExpressionType2Error(JetBrains.ReSharper.Psi.VB.Tree.IConditionalExpression expression) { }
        public string ErrorStripeToolTip { get; }
        public JetBrains.ReSharper.Psi.VB.Tree.IConditionalExpression Expression { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class CannotDetermineNullCoalescingExpressionTypeError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "Cannot infer a common type for \'{0}\' and \'{1}\', and Option Strict On does not all" +
            "ow \'Object\' to be assumed";
        public CannotDetermineNullCoalescingExpressionTypeError(JetBrains.ReSharper.Psi.VB.Tree.IConditionalExpression expression) { }
        public string ErrorStripeToolTip { get; }
        public JetBrains.ReSharper.Psi.VB.Tree.IConditionalExpression Expression { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class CannotDetermineTernaryExpressionType2Error : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "Cannot infer a common type because more than one type is possible for \'{0}\' and \'" +
            "{1}\'";
        public CannotDetermineTernaryExpressionType2Error(JetBrains.ReSharper.Psi.VB.Tree.IConditionalExpression expression) { }
        public string ErrorStripeToolTip { get; }
        public JetBrains.ReSharper.Psi.VB.Tree.IConditionalExpression Expression { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class CannotDetermineTernaryExpressionTypeError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "Cannot infer a common type for \'{0}\' and \'{1}\', and Option Strict On does not all" +
            "ow \'Object\' to be assumed";
        public CannotDetermineTernaryExpressionTypeError(JetBrains.ReSharper.Psi.VB.Tree.IConditionalExpression expression) { }
        public string ErrorStripeToolTip { get; }
        public JetBrains.ReSharper.Psi.VB.Tree.IConditionalExpression Expression { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class CannotInferElementTypeOfAnonymousArrayError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "Cannot infer an element type of anonymous array, and Option Strict On does not al" +
            "low \'Object\' to be assumed";
        public CannotInferElementTypeOfAnonymousArrayError(JetBrains.ReSharper.Psi.VB.Tree.IAnonymousArrayCreationExpression anonymousArrayCreation) { }
        public JetBrains.ReSharper.Psi.VB.Tree.IAnonymousArrayCreationExpression AnonymousArrayCreation { get; }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class CannotInferReturnTypeError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "Cannot infer a return type. Consider adding an \'As\' clause to specify the return " +
            "type";
        public CannotInferReturnTypeError(JetBrains.ReSharper.Psi.VB.Tree.ILambdaExpression lambdaExpression) { }
        public string ErrorStripeToolTip { get; }
        public JetBrains.ReSharper.Psi.VB.Tree.ILambdaExpression LambdaExpression { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class CannotUseBothAsyncAndIteratorModifiersError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "\'Async\' and \'Iterator\' modifiers cannot be used together";
        public CannotUseBothAsyncAndIteratorModifiersError(JetBrains.ReSharper.Psi.VB.Tree.IVBDeclaration declaration, JetBrains.ReSharper.Psi.Tree.ITokenNode asyncNode, JetBrains.ReSharper.Psi.Tree.ITokenNode iteratorNode) { }
        public JetBrains.ReSharper.Psi.Tree.ITokenNode AsyncNode { get; }
        public JetBrains.ReSharper.Psi.VB.Tree.IVBDeclaration Declaration { get; }
        public string ErrorStripeToolTip { get; }
        public JetBrains.ReSharper.Psi.Tree.ITokenNode IteratorNode { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class CannotUseNonEmptyInitializerIfDimensionIsNonConstantError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "Array initializer cannot be specified for a non-constant dimension; use empty ini" +
            "tializer \'{}\' instead";
        public CannotUseNonEmptyInitializerIfDimensionIsNonConstantError(JetBrains.ReSharper.Psi.VB.Tree.IAnonymousArrayCreationExpression arrayCreationExpression) { }
        public JetBrains.ReSharper.Psi.VB.Tree.IAnonymousArrayCreationExpression ArrayCreationExpression { get; }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class CantUseAccessorDirectlyError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "Cannot call method \'{0}()\'. Use {1} \'{2}\' instead";
        public CantUseAccessorDirectlyError(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
        public JetBrains.ReSharper.Psi.IDeclaredElement DeclaredElement { get; }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.Resolve.IReference Reference { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class CircularTypeDependencyError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "Circular {0} dependency involving \'{1}\' and \'{2}\'";
        public CircularTypeDependencyError(JetBrains.ReSharper.Psi.VB.Tree.IClassLikeDeclaration declaration, JetBrains.ReSharper.Psi.ITypeElement superClass) { }
        public JetBrains.ReSharper.Psi.VB.Tree.IClassLikeDeclaration Declaration { get; }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.ITypeElement SuperClass { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class ClassCannotInheritSealedClassError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "Class cannot inherit sealed class";
        public ClassCannotInheritSealedClassError(JetBrains.ReSharper.Psi.VB.Tree.IClassBaseClause element) { }
        public JetBrains.ReSharper.Psi.VB.Tree.IClassBaseClause Element { get; }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class ClassShouldInheritClassError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "Inherits keyword must be used with class";
        public ClassShouldInheritClassError(JetBrains.ReSharper.Psi.VB.Tree.IClassBaseClause element) { }
        public JetBrains.ReSharper.Psi.VB.Tree.IClassBaseClause Element { get; }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("CompareOfFloatsByEqualityOperator", "VBASIC", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.WARNING)]
    public class CompareOfFloatsByEqualityOperatorWarning : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "CompareOfFloatsByEqualityOperator";
        protected const string MESSAGE = "Comparison of floating point numbers with equality operator. {0}";
        public CompareOfFloatsByEqualityOperatorWarning(JetBrains.ReSharper.Psi.VB.Tree.IRelationalExpression expression, JetBrains.ReSharper.Daemon.VB.Stages.Analysis.CompareOfFloatsByEqualityOperatorAnalyzer.IssueType issueType, JetBrains.ReSharper.Daemon.VB.Stages.Analysis.CompareOfFloatsByEqualityOperatorAnalyzer.SuspiciousConstant constant) { }
        public JetBrains.ReSharper.Daemon.VB.Stages.Analysis.CompareOfFloatsByEqualityOperatorAnalyzer.SuspiciousConstant Constant { get; }
        public string ErrorStripeToolTip { get; }
        public JetBrains.ReSharper.Psi.VB.Tree.IRelationalExpression Expression { get; }
        public JetBrains.ReSharper.Daemon.VB.Stages.Analysis.CompareOfFloatsByEqualityOperatorAnalyzer.IssueType IssueType { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class ConditionalExpressionArgIsNotBoolError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "Condition argument must be \'Boolean\'";
        public ConditionalExpressionArgIsNotBoolError(JetBrains.ReSharper.Psi.VB.Tree.IConditionalExpression expression, JetBrains.ReSharper.Psi.VB.Tree.IVBExpression condition) { }
        public JetBrains.ReSharper.Psi.VB.Tree.IVBExpression Condition { get; }
        public string ErrorStripeToolTip { get; }
        public JetBrains.ReSharper.Psi.VB.Tree.IConditionalExpression Expression { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class ConditionalExpressionWrongArgsNumberError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "\'If\' operator requires either two or three operands";
        public ConditionalExpressionWrongArgsNumberError(JetBrains.ReSharper.Psi.VB.Tree.IConditionalExpression expression) { }
        public string ErrorStripeToolTip { get; }
        public JetBrains.ReSharper.Psi.VB.Tree.IConditionalExpression Expression { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("ConditionalTernaryEqualBranch", "VBASIC", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.WARNING)]
    public class ConditionalTernaryEqualBranchWarning : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "ConditionalTernaryEqualBranch";
        protected const string MESSAGE = "Conditional expression has identical true and false branches";
        public ConditionalTernaryEqualBranchWarning(JetBrains.ReSharper.Psi.VB.Tree.IConditionalExpression expression) { }
        public string ErrorStripeToolTip { get; }
        public JetBrains.ReSharper.Psi.VB.Tree.IConditionalExpression Expression { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("ConditionIsAlwaysTrueOrFalse", "VBASIC", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.WARNING, OverloadResolvePriority=10)]
    public class ConditionIsAlwaysTrueOrFalseWarning : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "ConditionIsAlwaysTrueOrFalse";
        protected const string MESSAGE = "Expression is always {0}";
        public ConditionIsAlwaysTrueOrFalseWarning(JetBrains.ReSharper.Psi.VB.Tree.IVBExpression expression, bool expressionConstantValue) { }
        public string ErrorStripeToolTip { get; }
        public JetBrains.ReSharper.Psi.VB.Tree.IVBExpression Expression { get; }
        public bool ExpressionConstantValue { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class ConstantAssignmentTargetError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "Constant cannot be used as an assignment target";
        public ConstantAssignmentTargetError(JetBrains.ReSharper.Psi.VB.Tree.IVBExpression destination, JetBrains.ReSharper.Psi.IDeclaredElement element) { }
        public JetBrains.ReSharper.Psi.VB.Tree.IVBExpression Destination { get; }
        public JetBrains.ReSharper.Psi.IDeclaredElement Element { get; }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class ConstantInitializerMustBeConstantError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "Constant expression is required";
        public ConstantInitializerMustBeConstantError(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration, JetBrains.ReSharper.Psi.VB.Tree.IVBExpression expression) { }
        public JetBrains.ReSharper.Psi.Tree.IDeclaration Declaration { get; }
        public string ErrorStripeToolTip { get; }
        public JetBrains.ReSharper.Psi.VB.Tree.IVBExpression Expression { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class ConstantMustHaveInitializerError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "Constant must have a value";
        public ConstantMustHaveInitializerError(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration) { }
        public JetBrains.ReSharper.Psi.Tree.IDeclaration Declaration { get; }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class ConstructorInitializerMissingError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "Base class \'{0}\' doesn\'t contain parameterless constructor";
        public ConstructorInitializerMissingError(JetBrains.ReSharper.Psi.VB.Tree.IConstructorDeclaration constructorDeclaration, JetBrains.ReSharper.Psi.IClass baseClass) { }
        public JetBrains.ReSharper.Psi.IClass BaseClass { get; }
        public JetBrains.ReSharper.Psi.VB.Tree.IConstructorDeclaration ConstructorDeclaration { get; }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class DefaultMemberShouldBePropertyError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "Default member \'{0}\' is not a property";
        public DefaultMemberShouldBePropertyError(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.Resolve.IReference Reference { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", AttributeId="ReSharper Underlined Error Highlighting", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.UNRESOLVED_ERROR)]
    public class DefaultPropertyNotFoundError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "{0} \'{1}\' cannot be indexed because it has no default property";
        public DefaultPropertyNotFoundError(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.ITypeElement typeElement) { }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.Resolve.IReference Reference { get; }
        public string ToolTip { get; }
        public JetBrains.ReSharper.Psi.ITypeElement TypeElement { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class DefaultPropertyWithoutParametersError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "Properties with no required parameters cannot be declared \'Default\'";
        public DefaultPropertyWithoutParametersError(JetBrains.ReSharper.Psi.VB.Tree.IPropertyDeclaration declaration) { }
        public JetBrains.ReSharper.Psi.VB.Tree.IPropertyDeclaration Declaration { get; }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class DuplicateInterfaceInImplementsListError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "Duplicate base type specification";
        public DuplicateInterfaceInImplementsListError(JetBrains.ReSharper.Psi.VB.Tree.IDeclaredTypeUsage typeUsage) { }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public JetBrains.ReSharper.Psi.VB.Tree.IDeclaredTypeUsage TypeUsage { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class DuplicateLabelError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "Label \'{0}\' is already defined in the current method or multiline lambda expressi" +
            "on";
        public DuplicateLabelError(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration) { }
        public JetBrains.ReSharper.Psi.Tree.IDeclaration Declaration { get; }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class DuplicateLocalDeclarationError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "{0} \'{1}\' hides a variable in an enclosing block, a previously defined range vari" +
            "able, or an implicitly declared variable in a query expression";
        public DuplicateLocalDeclarationError(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration) { }
        public JetBrains.ReSharper.Psi.Tree.IDeclaration Declaration { get; }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class DuplicateMemberDeclarationError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "Member with the same name or signature is already declared in {0} \'{1}\'";
        public DuplicateMemberDeclarationError(JetBrains.ReSharper.Psi.VB.Tree.IVBDeclaration declaration, JetBrains.ReSharper.Psi.ITypeElement containingType) { }
        public JetBrains.ReSharper.Psi.ITypeElement ContainingType { get; }
        public JetBrains.ReSharper.Psi.VB.Tree.IVBDeclaration Declaration { get; }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class DuplicateTypeDeclarationError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "Duplicate definition \'{0}\'";
        public DuplicateTypeDeclarationError(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration, JetBrains.ReSharper.Psi.IDeclaredElement[] duplicates) { }
        public JetBrains.ReSharper.Psi.Tree.IDeclaration Declaration { get; }
        public JetBrains.ReSharper.Psi.IDeclaredElement[] Duplicates { get; }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("EqualExpressionComparison", "VBASIC", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.WARNING)]
    public class EqualExpressionComparisonWarning : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "EqualExpressionComparison";
        protected const string MESSAGE = "Similar expressions comparison";
        public EqualExpressionComparisonWarning(JetBrains.ReSharper.Psi.VB.Tree.IVBExpression expression, bool expressionConstantValue) { }
        public string ErrorStripeToolTip { get; }
        public JetBrains.ReSharper.Psi.VB.Tree.IVBExpression Expression { get; }
        public bool ExpressionConstantValue { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class EventExpectedError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "Event name expected but {0} name found";
        public EventExpectedError(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.Resolve.IReference Reference { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class EventExpectedMultipleCandidatesError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "Event name expected";
        public EventExpectedMultipleCandidatesError(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.Resolve.IReference Reference { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class EventMustHaveDelegateTypeError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "Events declared with an \'As\' clause must have a delegate type";
        public EventMustHaveDelegateTypeError(JetBrains.ReSharper.Psi.VB.Tree.IEventDeclaration declaration) { }
        public JetBrains.ReSharper.Psi.VB.Tree.IEventDeclaration Declaration { get; }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class EventTypeMustReturnVoidError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "Events cannot be declared with a delegate type that has a return type";
        public EventTypeMustReturnVoidError(JetBrains.ReSharper.Psi.VB.Tree.IEventDeclaration declaration) { }
        public JetBrains.ReSharper.Psi.VB.Tree.IEventDeclaration Declaration { get; }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class ExplicitInitializationForArrayWithExplicitBoundsError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "Explicit initialization is not permitted for arrays declared with explicit bounds" +
            "";
        public ExplicitInitializationForArrayWithExplicitBoundsError(JetBrains.ReSharper.Psi.VB.Tree.IVBDeclaration declaration, JetBrains.ReSharper.Psi.VB.Tree.IArrayModifier arrayModifier) { }
        public JetBrains.ReSharper.Psi.VB.Tree.IArrayModifier ArrayModifier { get; }
        public JetBrains.ReSharper.Psi.VB.Tree.IVBDeclaration Declaration { get; }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class ExpressionDoesnotProduceValueError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "Expression does not produce a value";
        public ExpressionDoesnotProduceValueError(JetBrains.ReSharper.Psi.VB.Tree.IVBExpression expression) { }
        public string ErrorStripeToolTip { get; }
        public JetBrains.ReSharper.Psi.VB.Tree.IVBExpression Expression { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class ExpressionRangeVariableDeclarationWithExplicitTypeError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "\'Only \'let\' query statement can contain explicit type name in variable declaratio" +
            "n";
        public ExpressionRangeVariableDeclarationWithExplicitTypeError(JetBrains.ReSharper.Psi.VB.Tree.IExpressionRangeVariableDeclaration declaration) { }
        public JetBrains.ReSharper.Psi.VB.Tree.IExpressionRangeVariableDeclaration Declaration { get; }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class ExpressionTypeIsNotAwaitableError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "Type \'{0}\' is not awaitable";
        public ExpressionTypeIsNotAwaitableError(JetBrains.ReSharper.Psi.VB.Tree.IAwaitExpression awaitExpression, JetBrains.ReSharper.Psi.IExpressionType expressionType) { }
        public JetBrains.ReSharper.Psi.VB.Tree.IAwaitExpression AwaitExpression { get; }
        public string ErrorStripeToolTip { get; }
        public JetBrains.ReSharper.Psi.IExpressionType ExpressionType { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class ExtensionMethodInStaticContextError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "Cannot invoke an extension method \'{0}\' over implicit class instance in static co" +
            "ntext";
        public ExtensionMethodInStaticContextError(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.Resolve.IReference Reference { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class FieldExpectedError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "Field name expected, but {0} name found";
        public FieldExpectedError(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public JetBrains.ReSharper.Psi.IDeclaredElement DeclaredElement { get; }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.Resolve.IReference Reference { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class FieldExpectedNoCandidateError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "Field name expected";
        public FieldExpectedNoCandidateError(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.Resolve.IReference Reference { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class FieldOrPropertyExpectedError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "Field or Property name expected, but {0} name found";
        public FieldOrPropertyExpectedError(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.Resolve.IReference Reference { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("LoopCanBeConvertedToQuery", "VBASIC", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.WARNING)]
    public class ForeachCanBeConvertedToQueryWarning : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "LoopCanBeConvertedToQuery";
        protected const string MESSAGE = "Loop can be converted into LINQ-expression";
        public ForeachCanBeConvertedToQueryWarning(JetBrains.ReSharper.Psi.VB.Tree.IForEachStatement loop) { }
        public string ErrorStripeToolTip { get; }
        public JetBrains.ReSharper.Psi.VB.Tree.IForEachStatement Loop { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("LoopCanBePartlyConvertedToQuery", "VBASIC", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.WARNING)]
    public class ForeachCanBePartlyConvertedToQueryWarning : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "LoopCanBePartlyConvertedToQuery";
        protected const string MESSAGE = "Part of loop\'s body can be converted into LINQ-expression";
        public ForeachCanBePartlyConvertedToQueryWarning(JetBrains.ReSharper.Psi.VB.Tree.IForEachStatement loop) { }
        public string ErrorStripeToolTip { get; }
        public JetBrains.ReSharper.Psi.VB.Tree.IForEachStatement Loop { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("GCSuppressFinalizeForTypeWithoutDestructor", "VBASIC", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.WARNING)]
    public class GCSuppressFinalizeForTypeWithoutDestructorWarning : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "GCSuppressFinalizeForTypeWithoutDestructor";
        protected const string MESSAGE = "\'GC.SuppressFinalize\' is invoked for type without destructor";
        public GCSuppressFinalizeForTypeWithoutDestructorWarning(JetBrains.ReSharper.Psi.VB.Tree.IIndexExpression expression) { }
        public string ErrorStripeToolTip { get; }
        public JetBrains.ReSharper.Psi.VB.Tree.IIndexExpression Expression { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class HandlesFieldWithoutEventsError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "Handles clause requires a WithEvents variable defined in the containing type or o" +
            "ne of its base types";
        public HandlesFieldWithoutEventsError(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.IDeclaredElement field) { }
        public string ErrorStripeToolTip { get; }
        public JetBrains.ReSharper.Psi.IDeclaredElement Field { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.Resolve.IReference Reference { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class HandlesMethodSignatureMismatchError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "Method \'{0}\' cannot handle event \'{1}\' because they do not have a compatible sign" +
            "ature";
        public HandlesMethodSignatureMismatchError(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.IMethod method, JetBrains.ReSharper.Psi.IEvent evt) { }
        public string ErrorStripeToolTip { get; }
        public JetBrains.ReSharper.Psi.IEvent Evt { get; }
        public JetBrains.ReSharper.Psi.IMethod Method { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.Resolve.IReference Reference { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("ConditionalTernaryEqualBranch", "VBASIC", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.WARNING)]
    public class IIfEqualBranchWarning : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "ConditionalTernaryEqualBranch";
        protected const string MESSAGE = "\'IIf\' invocation with identical second and third arguments";
        public IIfEqualBranchWarning(JetBrains.ReSharper.Psi.VB.Tree.IIndexExpression expression, JetBrains.ReSharper.Psi.VB.Tree.IVBExpression thenExpression) { }
        public string ErrorStripeToolTip { get; }
        public JetBrains.ReSharper.Psi.VB.Tree.IIndexExpression Expression { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.VB.Tree.IVBExpression ThenExpression { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class ImplementKeywordWithNotInterfaceError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "Implements keyword must be used with an interface";
        public ImplementKeywordWithNotInterfaceError(JetBrains.ReSharper.Psi.VB.Tree.ITypeImplementsClause element, JetBrains.ReSharper.Psi.VB.Tree.IDeclaredTypeUsage typeUsage) { }
        public JetBrains.ReSharper.Psi.VB.Tree.ITypeImplementsClause Element { get; }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public JetBrains.ReSharper.Psi.VB.Tree.IDeclaredTypeUsage TypeUsage { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("VBWarnings::BC42105", "VBASIC", CompilerIds=new string[] {
            "BC42105",
            "BC42106",
            "BC42107"}, CompilerIdsWithDescription="BC42105,BC42106,BC42107:Function doesn\'t return a value on all code paths", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class ImplicitReturnFromReferenceTypeFunctionWarning : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "VBWarnings::BC42105";
        protected const string MESSAGE = "{0} doesn\'t return a value on all code paths";
        public ImplicitReturnFromReferenceTypeFunctionWarning(JetBrains.ReSharper.Psi.Tree.ITreeNode node, JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
        public JetBrains.ReSharper.Psi.IDeclaredElement DeclaredElement { get; }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.Tree.ITreeNode Node { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("VBWarnings::BC42353", "VBASIC", CompilerIds=new string[] {
            "BC42353",
            "BC42354",
            "BC42355"}, CompilerIdsWithDescription="BC42353,BC42354,BC42355:Function doesn\'t return a value on all code paths", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class ImplicitReturnFromValueTypeFunctionWarning : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "VBWarnings::BC42353";
        protected const string MESSAGE = "{0} doesn\'t return a value on all code paths. Are you missing a \'Return\' statemen" +
            "t?";
        public ImplicitReturnFromValueTypeFunctionWarning(JetBrains.ReSharper.Psi.Tree.ITreeNode node, JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
        public JetBrains.ReSharper.Psi.IDeclaredElement DeclaredElement { get; }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.Tree.ITreeNode Node { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("VBWarnings::BC42322", "VBASIC", CompilerIds=new string[] {
            "BC42322"}, CompilerIdsWithDescription="BC42322:Runtime errors might occur when converting X to Y", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class ImpossibleConvertTypeInArgumentWarning : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "VBWarnings::BC42322";
        protected const string MESSAGE = "{0}";
        public ImpossibleConvertTypeInArgumentWarning(JetBrains.ReSharper.Psi.VB.IVBArgumentInfo argument, JetBrains.ReSharper.Psi.IType targetType) { }
        public JetBrains.ReSharper.Psi.VB.IVBArgumentInfo Argument { get; }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.IType TargetType { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("VBWarnings::BC42322", "VBASIC", CompilerIds=new string[] {
            "BC42322"}, CompilerIdsWithDescription="BC42322:Runtime errors might occur when converting X to Y", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class ImpossibleConvertTypeInAssignmentWarning : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "VBWarnings::BC42322";
        protected const string MESSAGE = "{0}";
        public ImpossibleConvertTypeInAssignmentWarning(JetBrains.ReSharper.Psi.VB.Tree.IAssignmentStatement assignmentStatement, JetBrains.ReSharper.Psi.IExpressionType sourceType, JetBrains.ReSharper.Psi.IType targetType) { }
        public JetBrains.ReSharper.Psi.VB.Tree.IAssignmentStatement AssignmentStatement { get; }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.IExpressionType SourceType { get; }
        public JetBrains.ReSharper.Psi.IType TargetType { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("VBWarnings::BC42322", "VBASIC", CompilerIds=new string[] {
            "BC42322"}, CompilerIdsWithDescription="BC42322:Runtime errors might occur when converting X to Y", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class ImpossibleConvertTypeInAsyncReturnWarning : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "VBWarnings::BC42322";
        protected const string MESSAGE = "{0}";
        public ImpossibleConvertTypeInAsyncReturnWarning(JetBrains.ReSharper.Psi.VB.Tree.IReturnStatement returnStatement, JetBrains.ReSharper.Psi.VB.Tree.IVBExpression expression, JetBrains.ReSharper.Psi.IType targetType) { }
        public string ErrorStripeToolTip { get; }
        public JetBrains.ReSharper.Psi.VB.Tree.IVBExpression Expression { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.VB.Tree.IReturnStatement ReturnStatement { get; }
        public JetBrains.ReSharper.Psi.IType TargetType { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("VBWarnings::BC42322", "VBASIC", CompilerIds=new string[] {
            "BC42322"}, CompilerIdsWithDescription="BC42322:Runtime errors might occur when converting X to Y", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class ImpossibleConvertTypeInDeclarationWarning : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "VBWarnings::BC42322";
        protected const string MESSAGE = "{0}";
        public ImpossibleConvertTypeInDeclarationWarning(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration, JetBrains.ReSharper.Psi.VB.Tree.IVBExpression expression, JetBrains.ReSharper.Psi.IType targetType) { }
        public JetBrains.ReSharper.Psi.Tree.IDeclaration Declaration { get; }
        public string ErrorStripeToolTip { get; }
        public JetBrains.ReSharper.Psi.VB.Tree.IVBExpression Expression { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.IType TargetType { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("VBWarnings::BC42322", "VBASIC", CompilerIds=new string[] {
            "BC42322"}, CompilerIdsWithDescription="BC42322:Runtime errors might occur when converting X to Y", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class ImpossibleConvertTypeInMemberInitializerWarning : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "VBWarnings::BC42322";
        protected const string MESSAGE = "{0}";
        public ImpossibleConvertTypeInMemberInitializerWarning(JetBrains.ReSharper.Psi.VB.Tree.IMemberInitializer initializer, JetBrains.ReSharper.Psi.VB.Tree.IVBExpression expression, JetBrains.ReSharper.Psi.IType targetType) { }
        public string ErrorStripeToolTip { get; }
        public JetBrains.ReSharper.Psi.VB.Tree.IVBExpression Expression { get; }
        public JetBrains.ReSharper.Psi.VB.Tree.IMemberInitializer Initializer { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.IType TargetType { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("VBWarnings::BC42322", "VBASIC", CompilerIds=new string[] {
            "BC42322"}, CompilerIdsWithDescription="BC42322:Runtime errors might occur when converting X to Y", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class ImpossibleConvertTypeInReturnWarning : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "VBWarnings::BC42322";
        protected const string MESSAGE = "{0}";
        public ImpossibleConvertTypeInReturnWarning(JetBrains.ReSharper.Psi.VB.Tree.IReturnStatement returnStatement, JetBrains.ReSharper.Psi.VB.Tree.IVBExpression expression, JetBrains.ReSharper.Psi.IType targetType) { }
        public string ErrorStripeToolTip { get; }
        public JetBrains.ReSharper.Psi.VB.Tree.IVBExpression Expression { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.VB.Tree.IReturnStatement ReturnStatement { get; }
        public JetBrains.ReSharper.Psi.IType TargetType { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("VBWarnings::BC42322", "VBASIC", CompilerIds=new string[] {
            "BC42322"}, CompilerIdsWithDescription="BC42322:Runtime errors might occur when converting X to Y", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class ImpossibleConvertTypeInYieldWarning : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "VBWarnings::BC42322";
        protected const string MESSAGE = "{0}";
        public ImpossibleConvertTypeInYieldWarning(JetBrains.ReSharper.Psi.VB.Tree.IYieldStatement yieldStatement, JetBrains.ReSharper.Psi.IType targetType) { }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.IType TargetType { get; }
        public string ToolTip { get; }
        public JetBrains.ReSharper.Psi.VB.Tree.IYieldStatement YieldStatement { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("ImpureMethodCallOnReadonlyValueField", "VBASIC", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.WARNING)]
    public class ImpureMethodCallOnReadonlyValueFieldWarning : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "ImpureMethodCallOnReadonlyValueField";
        protected const string MESSAGE = "Impure method is called for readonly field of value type";
        public ImpureMethodCallOnReadonlyValueFieldWarning(JetBrains.ReSharper.Psi.VB.Tree.IReferenceExpression expression) { }
        public string ErrorStripeToolTip { get; }
        public JetBrains.ReSharper.Psi.VB.Tree.IReferenceExpression Expression { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class InaccessibleAccessorError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "{0} \'{1}\' cannot be used in this context because the {2} accessor is inaccessible" +
            "";
        public InaccessibleAccessorError(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.IProperty property, JetBrains.ReSharper.Psi.AccessorKind kind) { }
        public string ErrorStripeToolTip { get; }
        public JetBrains.ReSharper.Psi.AccessorKind Kind { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.IProperty Property { get; }
        public JetBrains.ReSharper.Psi.Resolve.IReference Reference { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("InactivePreprocessorBranch", "VBASIC", AttributeId="ReSharper Dead Code", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.DEADCODE)]
    public class InactivePreprocessorBranchInfo : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "InactivePreprocessorBranch";
        protected const string MESSAGE = "Inactive preprocessor branch";
        public InactivePreprocessorBranchInfo(JetBrains.ReSharper.Psi.VB.Tree.IInactivePreprocessorBranch node) { }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.VB.Tree.IInactivePreprocessorBranch Node { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class InconsistentAccessibilityInDerivationError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "Inconsistent accessibility: base {0} \'{1}\' is less accessible than {2} \'{3}\'";
        public InconsistentAccessibilityInDerivationError(JetBrains.ReSharper.Psi.ITypeElement derivedTypeElement, JetBrains.ReSharper.Psi.VB.Tree.IDeclaredTypeUsage baseTypeUsageNode, JetBrains.ReSharper.Psi.ITypeElement baseTypeElement) { }
        public JetBrains.ReSharper.Psi.ITypeElement BaseTypeElement { get; }
        public JetBrains.ReSharper.Psi.VB.Tree.IDeclaredTypeUsage BaseTypeUsageNode { get; }
        public JetBrains.ReSharper.Psi.ITypeElement DerivedTypeElement { get; }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class InconsistentAccessibilityInMemberTypeError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "Inconsistent accessibility: {0} type \'{1}\' is less accessible than {2} \'{3}\'";
        public InconsistentAccessibilityInMemberTypeError(JetBrains.ReSharper.Psi.Tree.ITreeNode typeUsageNode, JetBrains.ReSharper.Psi.IType usedType, JetBrains.ReSharper.Psi.ITypeMember typeMember) { }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public JetBrains.ReSharper.Psi.ITypeMember TypeMember { get; }
        public JetBrains.ReSharper.Psi.Tree.ITreeNode TypeUsageNode { get; }
        public JetBrains.ReSharper.Psi.IType UsedType { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class InconsistentAccessibilityInParameterTypeError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "Inconsistent accessibility: parameter type \'{0}\' is less accessible than {1} \'{2}" +
            "\'";
        public InconsistentAccessibilityInParameterTypeError(JetBrains.ReSharper.Psi.VB.Tree.ITypeUsage typeUsageNode, JetBrains.ReSharper.Psi.IType usedType, JetBrains.ReSharper.Psi.ITypeMember typeMember) { }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public JetBrains.ReSharper.Psi.ITypeMember TypeMember { get; }
        public JetBrains.ReSharper.Psi.VB.Tree.ITypeUsage TypeUsageNode { get; }
        public JetBrains.ReSharper.Psi.IType UsedType { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class InconsistentAccessibilityInReturnTypeError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "Inconsistent accessibility: return type \'{0}\' is less accessible than {1} \'{2}\'";
        public InconsistentAccessibilityInReturnTypeError(JetBrains.ReSharper.Psi.VB.Tree.ITypeUsage typeUsageNode, JetBrains.ReSharper.Psi.IType usedType, JetBrains.ReSharper.Psi.ITypeMember typeMember) { }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public JetBrains.ReSharper.Psi.ITypeMember TypeMember { get; }
        public JetBrains.ReSharper.Psi.VB.Tree.ITypeUsage TypeUsageNode { get; }
        public JetBrains.ReSharper.Psi.IType UsedType { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class InconsistentAccessibilityInTypeArgumentError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "Inconsistent accessibility: type argument \'{0}\' is less accessible than {1} \'{2}\'" +
            "";
        public InconsistentAccessibilityInTypeArgumentError(JetBrains.ReSharper.Psi.Tree.ITreeNode typeUsageNode, JetBrains.ReSharper.Psi.IType usedType, JetBrains.ReSharper.Psi.ITypeMember typeMember) { }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public JetBrains.ReSharper.Psi.ITypeMember TypeMember { get; }
        public JetBrains.ReSharper.Psi.Tree.ITreeNode TypeUsageNode { get; }
        public JetBrains.ReSharper.Psi.IType UsedType { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class InconsistentAccessibilityInTypeParameterConstraintError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "Inconsistent accessibility: constraint type \'{0}\' is less accessible than {1} \'{2" +
            "}\'";
        public InconsistentAccessibilityInTypeParameterConstraintError(JetBrains.ReSharper.Psi.VB.Tree.ITypeUsage typeUsageNode, JetBrains.ReSharper.Psi.IType usedType, JetBrains.ReSharper.Psi.ITypeMember typeMember) { }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public JetBrains.ReSharper.Psi.ITypeMember TypeMember { get; }
        public JetBrains.ReSharper.Psi.VB.Tree.ITypeUsage TypeUsageNode { get; }
        public JetBrains.ReSharper.Psi.IType UsedType { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class IncorrectArgumentNumberError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "Incorrect number of arguments in reference to \'{0}\'";
        public IncorrectArgumentNumberError(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.Resolve.IReference Reference { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class IncorrectArgumentNumberMultipleCandidatesError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "Incorrect number of arguments. Candidates are: {0}";
        public IncorrectArgumentNumberMultipleCandidatesError(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.Resolve.IReference Reference { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class IncorrectArgumentTypesError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "Incorrect argument types. Candidates are: {0}";
        public IncorrectArgumentTypesError(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.Resolve.IReference Reference { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class IncorrectArrayElementTypeError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "Cannot convert expression of type \'{0}\' to type \'{1}\'";
        public IncorrectArrayElementTypeError(JetBrains.ReSharper.Psi.VB.Tree.IVBExpression initializerExpression, JetBrains.ReSharper.Psi.IType targetType) { }
        public string ErrorStripeToolTip { get; }
        public JetBrains.ReSharper.Psi.VB.Tree.IVBExpression InitializerExpression { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.IType TargetType { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class IncorrectMidStatementSyntaxError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "A Mid assignment statement should have syntax \'Mid(String, Integer, [Optional]Int" +
            "eger) = String\'";
        public IncorrectMidStatementSyntaxError(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.Resolve.IReference Reference { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class IncorrectSignatureInDelegateCreationError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "Method \'{0}\' does not have a signature compatible with delegate \'{1}\'";
        public IncorrectSignatureInDelegateCreationError(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.IDelegate @delegate, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution) { }
        public JetBrains.ReSharper.Psi.IDelegate Delegate { get; }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.Resolve.IReference Reference { get; }
        public JetBrains.ReSharper.Psi.Resolve.ISubstitution Substitution { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class IncorrectSignatureInDelegateCreationMultipleCandidatesError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "Method with the following signature is expected: \'{0} {1}{2}\'";
        public IncorrectSignatureInDelegateCreationMultipleCandidatesError(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.IDelegate @delegate, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution) { }
        public JetBrains.ReSharper.Psi.IDelegate Delegate { get; }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.Resolve.IReference Reference { get; }
        public JetBrains.ReSharper.Psi.Resolve.ISubstitution Substitution { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("RedundantAssignment", "VBASIC", AttributeId="ReSharper Dead Code", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.DEADCODE)]
    public class InitializerNotUsedWarning : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "RedundantAssignment";
        protected const string MESSAGE = "Value assigned is not used in any execution path";
        public InitializerNotUsedWarning(JetBrains.ReSharper.Psi.VB.Tree.ILocalVariableDeclaration declaration) { }
        public JetBrains.ReSharper.Psi.VB.Tree.ILocalVariableDeclaration Declaration { get; }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class InstanceExpressionInStaticContextError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "\'{0}\' is valid only within an instance method";
        public InstanceExpressionInStaticContextError(JetBrains.ReSharper.Psi.VB.Tree.IInstanceExpression expression) { }
        public string ErrorStripeToolTip { get; }
        public JetBrains.ReSharper.Psi.VB.Tree.IInstanceExpression Expression { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class InterfaceCannotInheritNestedError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "Interface \'{0}\' cannot inherit from a type nested within it";
        public InterfaceCannotInheritNestedError(JetBrains.ReSharper.Psi.VB.Tree.IInterfaceInheritsClause element, JetBrains.ReSharper.Psi.VB.Tree.IDeclaredTypeUsage typeUsage, JetBrains.ReSharper.Psi.ITypeElement outerInterface) { }
        public JetBrains.ReSharper.Psi.VB.Tree.IInterfaceInheritsClause Element { get; }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.ITypeElement OuterInterface { get; }
        public string ToolTip { get; }
        public JetBrains.ReSharper.Psi.VB.Tree.IDeclaredTypeUsage TypeUsage { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class InterfaceInheritsKeywordWithNotInterfaceError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "Inherits keyword must be used with an interface";
        public InterfaceInheritsKeywordWithNotInterfaceError(JetBrains.ReSharper.Psi.VB.Tree.IInterfaceInheritsClause element, JetBrains.ReSharper.Psi.VB.Tree.IDeclaredTypeUsage typeUsage) { }
        public JetBrains.ReSharper.Psi.VB.Tree.IInterfaceInheritsClause Element { get; }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public JetBrains.ReSharper.Psi.VB.Tree.IDeclaredTypeUsage TypeUsage { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class InterfaceNotInImplementsListError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "Interface \'{0}\' is not implemented by this class";
        public InterfaceNotInImplementsListError(JetBrains.ReSharper.Psi.VB.Tree.IVBTypeMemberDeclaration declaration, JetBrains.ReSharper.Psi.VB.Tree.IInterfaceMemberSpecifier implementsSpecifier, JetBrains.ReSharper.Psi.IDeclaredType interfaceType) { }
        public JetBrains.ReSharper.Psi.VB.Tree.IVBTypeMemberDeclaration Declaration { get; }
        public string ErrorStripeToolTip { get; }
        public JetBrains.ReSharper.Psi.VB.Tree.IInterfaceMemberSpecifier ImplementsSpecifier { get; }
        public JetBrains.ReSharper.Psi.IDeclaredType InterfaceType { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class InvalidCastError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "{0}";
        public InvalidCastError(JetBrains.ReSharper.Psi.VB.Tree.ICastExpression expression, JetBrains.ReSharper.Psi.VB.Tree.ITypeUsage typeUsage, JetBrains.ReSharper.Psi.IType expressionType, JetBrains.ReSharper.Psi.IType castType) { }
        public JetBrains.ReSharper.Psi.IType CastType { get; }
        public string ErrorStripeToolTip { get; }
        public JetBrains.ReSharper.Psi.VB.Tree.ICastExpression Expression { get; }
        public JetBrains.ReSharper.Psi.IType ExpressionType { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public JetBrains.ReSharper.Psi.VB.Tree.ITypeUsage TypeUsage { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class InvalidExpressionStatementError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "Only index expression is allowed as a statement";
        public InvalidExpressionStatementError(JetBrains.ReSharper.Psi.VB.Tree.IVBExpression expression, JetBrains.ReSharper.Psi.VB.Tree.IVBExpression statementExpression) { }
        public string ErrorStripeToolTip { get; }
        public JetBrains.ReSharper.Psi.VB.Tree.IVBExpression Expression { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.VB.Tree.IVBExpression StatementExpression { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class InvalidInvocationStatementExpressionError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "Only index expression is allowed as a statement";
        public InvalidInvocationStatementExpressionError(JetBrains.ReSharper.Psi.VB.Tree.IVBExpression expression, JetBrains.ReSharper.Psi.VB.Tree.IVBExpression statementExpression) { }
        public string ErrorStripeToolTip { get; }
        public JetBrains.ReSharper.Psi.VB.Tree.IVBExpression Expression { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.VB.Tree.IVBExpression StatementExpression { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class InvalidInvocationStatementStartExpressionError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "Only member access expression can start an invocation statement";
        public InvalidInvocationStatementStartExpressionError(JetBrains.ReSharper.Psi.VB.Tree.IVBExpression expression, JetBrains.ReSharper.Psi.VB.Tree.IVBExpression statementExpression) { }
        public string ErrorStripeToolTip { get; }
        public JetBrains.ReSharper.Psi.VB.Tree.IVBExpression Expression { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.VB.Tree.IVBExpression StatementExpression { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class InvalidModifierAndAccessRightCombinationError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "\'{0}\' and \'{1}\' cannot be combined";
        public InvalidModifierAndAccessRightCombinationError(JetBrains.ReSharper.Psi.VB.Tree.IVBModifiersOwnerDeclaration declaration, JetBrains.ReSharper.Psi.Parsing.TokenNodeType modifier) { }
        public JetBrains.ReSharper.Psi.VB.Tree.IVBModifiersOwnerDeclaration Declaration { get; }
        public string ErrorStripeToolTip { get; }
        public JetBrains.ReSharper.Psi.Parsing.TokenNodeType Modifier { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("InvokeAsExtensionMethod", "VBASIC", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.WARNING)]
    public class InvokeAsExtensionMethodWarning : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "InvokeAsExtensionMethod";
        protected const string MESSAGE = "Invoke as extension method";
        public InvokeAsExtensionMethodWarning(JetBrains.ReSharper.Psi.VB.Tree.IIndexExpression indexExpression, JetBrains.ReSharper.Psi.Resolve.IReference methodReference) { }
        public string ErrorStripeToolTip { get; }
        public JetBrains.ReSharper.Psi.VB.Tree.IIndexExpression IndexExpression { get; }
        public JetBrains.ReSharper.Psi.Resolve.IReference MethodReference { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class IsExpressionOperandMustBeReferenceTypeError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "\'Is\' expression operand must be reference or nullable type";
        public IsExpressionOperandMustBeReferenceTypeError(JetBrains.ReSharper.Psi.VB.Tree.IVBExpression expression) { }
        public string ErrorStripeToolTip { get; }
        public JetBrains.ReSharper.Psi.VB.Tree.IVBExpression Expression { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class IteratorIsNotValidOnAutoImplementedPropertyError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "Auto-implemented properties cannot be declared \'Iterator\'";
        public IteratorIsNotValidOnAutoImplementedPropertyError(JetBrains.ReSharper.Psi.VB.Tree.IModifiersList modifiersList, JetBrains.ReSharper.Psi.Tree.ITokenNode tokenNode) { }
        public string ErrorStripeToolTip { get; }
        public JetBrains.ReSharper.Psi.VB.Tree.IModifiersList ModifiersList { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.Tree.ITokenNode TokenNode { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class IteratorMethodCannotHaveByRefParametersError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "Iterator {0} cannot have ByRef parameters";
        public IteratorMethodCannotHaveByRefParametersError(JetBrains.ReSharper.Psi.IParameter parameter, string name) { }
        public string ErrorStripeToolTip { get; }
        public string Name { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.IParameter Parameter { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("RedundantIteratorKeyword", "VBASIC", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.WARNING)]
    public class IteratorMethodWithoutYieldWarning : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "RedundantIteratorKeyword";
        protected const string MESSAGE = "Iterator without Yield Statement";
        public IteratorMethodWithoutYieldWarning(JetBrains.ReSharper.Psi.VB.Tree.IVBDeclaration declaration) { }
        public JetBrains.ReSharper.Psi.VB.Tree.IVBDeclaration Declaration { get; }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class IteratorModifierIsNotValidOnThisItemError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "The modifier \'Iterator\' is not valid for this item";
        public IteratorModifierIsNotValidOnThisItemError(JetBrains.ReSharper.Psi.VB.Tree.IModifiersList modifiersList, JetBrains.ReSharper.Psi.Tree.ITokenNode tokenNode) { }
        public string ErrorStripeToolTip { get; }
        public JetBrains.ReSharper.Psi.VB.Tree.IModifiersList ModifiersList { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.Tree.ITokenNode TokenNode { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class JumpFromFinallyError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "Branching out of a \'Finally\' is not valid";
        public JumpFromFinallyError(JetBrains.ReSharper.Psi.Tree.ITreeNode node) { }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.Tree.ITreeNode Node { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class LateBoundExtensionMethodsError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "Dynamic extension methods are not supported";
        public LateBoundExtensionMethodsError(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.Resolve.IReference Reference { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class LateBoundThroughtInterfaceError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "Latebound overload resolution cannot be applied to \'{0}\' because the accessing in" +
            "stance is an interface type";
        public LateBoundThroughtInterfaceError(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.Resolve.IReference Reference { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("LocalVariableHidesMember", "VBASIC", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.WARNING)]
    public class LocalVariableHidesMemberWarning : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "LocalVariableHidesMember";
        protected const string MESSAGE = "{0} \'{1}\' hides {2} \'{3}\'";
        public LocalVariableHidesMemberWarning(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration, JetBrains.ReSharper.Psi.ITypeMember hiddenMember) { }
        public JetBrains.ReSharper.Psi.Tree.IDeclaration Declaration { get; }
        public string ErrorStripeToolTip { get; }
        public JetBrains.ReSharper.Psi.ITypeMember HiddenMember { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("LongLiteralEndingLowerL", "VBASIC", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.WARNING)]
    public class LongLiteralEndingLowerLWarning : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "LongLiteralEndingLowerL";
        protected const string MESSAGE = "Long literal ending with \'l\' instead of \'L\'";
        public LongLiteralEndingLowerLWarning(JetBrains.ReSharper.Psi.VB.Tree.IVBLiteralExpression literalExpression) { }
        public string ErrorStripeToolTip { get; }
        public JetBrains.ReSharper.Psi.VB.Tree.IVBLiteralExpression LiteralExpression { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class MemberIsReadonlyError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "{0} \'{1}\' is \'ReadOnly\'";
        public MemberIsReadonlyError(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.IDeclaredElement element) { }
        public JetBrains.ReSharper.Psi.IDeclaredElement Element { get; }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.Resolve.IReference Reference { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class MemberIsSharedError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "Shared field or property \'{0}\' cannot be assigned in an object initializer";
        public MemberIsSharedError(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.Resolve.IReference Reference { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class MethodDiffersOnlyByOptionalParamerterError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "Method differs only by optional parameter is already declared in {0} \'{1}\'";
        public MethodDiffersOnlyByOptionalParamerterError(JetBrains.ReSharper.Psi.VB.Tree.IVBDeclaration declaration, JetBrains.ReSharper.Psi.ITypeElement containingType) { }
        public JetBrains.ReSharper.Psi.ITypeElement ContainingType { get; }
        public JetBrains.ReSharper.Psi.VB.Tree.IVBDeclaration Declaration { get; }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class MethodExpectedError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "Method name expected but {0} name found";
        public MethodExpectedError(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.Resolve.IReference Reference { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class MethodExpectedMultipleCandidatesError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "Method name expected";
        public MethodExpectedMultipleCandidatesError(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.Resolve.IReference Reference { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("FunctionNeverReturns", "VBASIC", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.WARNING)]
    public class MethodNeverReturnsWarning : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "FunctionNeverReturns";
        protected const string MESSAGE = "Function never returns";
        public MethodNeverReturnsWarning(JetBrains.ReSharper.Psi.Tree.ITreeNode endDeclaration) { }
        public JetBrains.ReSharper.Psi.Tree.ITreeNode EndDeclaration { get; }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class MidStatementArgumentIsNotVariableError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "Only variable or property can be the target of an assignemnt";
        public MidStatementArgumentIsNotVariableError(JetBrains.ReSharper.Psi.VB.Tree.IVBArgument firstArgument) { }
        public string ErrorStripeToolTip { get; }
        public JetBrains.ReSharper.Psi.VB.Tree.IVBArgument FirstArgument { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class MissingMemberImplementation2Error : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "Missing implementation of members:{0}{1}";
        public MissingMemberImplementation2Error(JetBrains.ReSharper.Psi.VB.Tree.IClassLikeDeclaration declaration, JetBrains.ReSharper.Psi.VB.Tree.IDeclaredTypeUsage typeUsage, System.Collections.Generic.IList<JetBrains.ReSharper.Psi.OverridableMemberInstance> missingMembers) { }
        public JetBrains.ReSharper.Psi.VB.Tree.IClassLikeDeclaration Declaration { get; }
        public string ErrorStripeToolTip { get; }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Psi.OverridableMemberInstance> MissingMembers { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public JetBrains.ReSharper.Psi.VB.Tree.IDeclaredTypeUsage TypeUsage { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class MissingMemberImplementationError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "Missing implementation of members from base types:{0}{1}";
        public MissingMemberImplementationError(JetBrains.ReSharper.Psi.VB.Tree.IClassLikeDeclaration declaration, System.Collections.Generic.IList<JetBrains.ReSharper.Psi.OverridableMemberInstance> missingMembers) { }
        public JetBrains.ReSharper.Psi.VB.Tree.IClassLikeDeclaration Declaration { get; }
        public string ErrorStripeToolTip { get; }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Psi.OverridableMemberInstance> MissingMembers { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class MissingPartialDeclarationError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "Duplicate definition \'{0}\'. Modifier \'Partial\' is possibly missing";
        public MissingPartialDeclarationError(JetBrains.ReSharper.Psi.VB.Tree.IClassLikeDeclaration declaration) { }
        public JetBrains.ReSharper.Psi.VB.Tree.IClassLikeDeclaration Declaration { get; }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("RedundantAssignment", "VBASIC", AttributeId="ReSharper Dead Code", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.DEADCODE)]
    public class ModifiedValueNotUsedWarning : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "RedundantAssignment";
        protected const string MESSAGE = "Value assigned is not used in any execution path";
        public ModifiedValueNotUsedWarning(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public JetBrains.ReSharper.Psi.Tree.ITreeNode Element { get; }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class MoreApplicableNotFoundError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "Unable to choose a more applicable candidate. Candidates are: {0}";
        public MoreApplicableNotFoundError(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.Resolve.IReference Reference { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class MoreSpecificNotFoundError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "Unable to choose a more specific candidate. Candidates are: {0}";
        public MoreSpecificNotFoundError(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.Resolve.IReference Reference { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class MultilineLambdaToExpressionTreeError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "Multiline lambda cannot be converted to expression trees";
        public MultilineLambdaToExpressionTreeError(JetBrains.ReSharper.Psi.VB.Tree.ILambdaExpression lambdaExpression) { }
        public string ErrorStripeToolTip { get; }
        public JetBrains.ReSharper.Psi.VB.Tree.ILambdaExpression LambdaExpression { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class MultipleAccessRights2Error : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "Cannot access {0} \'{1}\' here due to protection level";
        public MultipleAccessRights2Error(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.Resolve.IReference Reference { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class MultipleAccessRightsError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "Cannot access {0} {1} \'{2}\' here";
        public MultipleAccessRightsError(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.Resolve.IReference Reference { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("VBWarnings::BC42309", "VBASIC", CompilerIds=new string[] {
            "BC42309"}, CompilerIdsWithDescription="BC42309:XML comment has a tag with a \'cref\' attribute that could not be resolved", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.UNRESOLVED_ERROR)]
    public class MultipleCandidatesInDocCommentWarning : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "VBWarnings::BC42309";
        protected const string MESSAGE = "Ambiguous reference \'{0}\'";
        public MultipleCandidatesInDocCommentWarning(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.Resolve.IReference Reference { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class MultipleInterfaceImplementationError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "{0} \'{1}\' is already implemented in this class";
        public MultipleInterfaceImplementationError(JetBrains.ReSharper.Psi.VB.Tree.IVBTypeMemberDeclaration declaration, JetBrains.ReSharper.Psi.VB.Tree.IInterfaceMemberSpecifier implementsSpecifier, JetBrains.ReSharper.Psi.OverridableMemberInstance interfaceMember) { }
        public JetBrains.ReSharper.Psi.VB.Tree.IVBTypeMemberDeclaration Declaration { get; }
        public string ErrorStripeToolTip { get; }
        public JetBrains.ReSharper.Psi.VB.Tree.IInterfaceMemberSpecifier ImplementsSpecifier { get; }
        public JetBrains.ReSharper.Psi.OverridableMemberInstance InterfaceMember { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("MultipleNullableAttributesUsage", "VBASIC", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.WARNING)]
    public class MultipleNullableAttributesUsageWarning : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "MultipleNullableAttributesUsage";
        protected const string MESSAGE = "Multiple nullness attributes usage";
        public MultipleNullableAttributesUsageWarning(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration) { }
        public JetBrains.ReSharper.Psi.Tree.IDeclaration Declaration { get; }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class MultipleOverridesError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "{0} \'{1}\' overrides multiple members with the same name and signature:{2}{3}";
        public MultipleOverridesError(JetBrains.ReSharper.Psi.VB.Tree.IVBTypeMemberDeclaration declaration, System.Collections.Generic.IList<JetBrains.ReSharper.Psi.TypeMemberInstance> overriddenMembers) { }
        public JetBrains.ReSharper.Psi.VB.Tree.IVBTypeMemberDeclaration Declaration { get; }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Psi.TypeMemberInstance> OverriddenMembers { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class MultipleResolveCandidatesError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "Ambiguous {0}:{1}{2}match";
        public MultipleResolveCandidatesError(string type, JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.Resolve.IReference Reference { get; }
        public string ToolTip { get; }
        public string Type { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class NamespaceExpectedError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "Namespace name expected, but {0} name found";
        public NamespaceExpectedError(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public JetBrains.ReSharper.Psi.IDeclaredElement DeclaredElement { get; }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.Resolve.IReference Reference { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class NamespaceExpectedNoCandidateError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "Namespace name expected";
        public NamespaceExpectedNoCandidateError(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.Resolve.IReference Reference { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class NegativeArrayCreationParameterError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "Cannot create an array of negative size";
        public NegativeArrayCreationParameterError(JetBrains.ReSharper.Psi.VB.Tree.IVBExpression expression) { }
        public string ErrorStripeToolTip { get; }
        public JetBrains.ReSharper.Psi.VB.Tree.IVBExpression Expression { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class NoDefaultConstructorInBaseClassError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "Base class \'{0}\' doesn\'t contain parameterless constructor";
        public NoDefaultConstructorInBaseClassError(JetBrains.ReSharper.Psi.VB.Tree.IClassDeclaration classDeclaration, JetBrains.ReSharper.Psi.IClass baseClass) { }
        public JetBrains.ReSharper.Psi.IClass BaseClass { get; }
        public JetBrains.ReSharper.Psi.VB.Tree.IClassDeclaration ClassDeclaration { get; }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class NoMatchingInInterfaceError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "There is no matching {0} \'{1}{2}\' in interface \'{3}\'";
        public NoMatchingInInterfaceError(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.IInterface @interface, JetBrains.ReSharper.Psi.IDeclaredElement declarationElement, JetBrains.ReSharper.Psi.IDeclaredElement interfaceElement) { }
        public JetBrains.ReSharper.Psi.IDeclaredElement DeclarationElement { get; }
        public string ErrorStripeToolTip { get; }
        public JetBrains.ReSharper.Psi.IInterface Interface { get; }
        public JetBrains.ReSharper.Psi.IDeclaredElement InterfaceElement { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.Resolve.IReference Reference { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class NoMatchingInInterfaceMultipleCandidatesError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "There is no matching {0} \'{1}{2}\' in interface \'{3}\'. Candidates are: {4}";
        public NoMatchingInInterfaceMultipleCandidatesError(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.IInterface @interface, JetBrains.ReSharper.Psi.IDeclaredElement declarationElement) { }
        public JetBrains.ReSharper.Psi.IDeclaredElement DeclarationElement { get; }
        public string ErrorStripeToolTip { get; }
        public JetBrains.ReSharper.Psi.IInterface Interface { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.Resolve.IReference Reference { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("NonReadonlyFieldInGetHashCode", "VBASIC", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.WARNING)]
    public class NonReadonlyFieldInGetHashCodeWarning : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "NonReadonlyFieldInGetHashCode";
        protected const string MESSAGE = "Non-readonly field referenced in \'GetHashCode()\'";
        public NonReadonlyFieldInGetHashCodeWarning(JetBrains.ReSharper.Psi.VB.Tree.IReferenceExpression referenceExpression, JetBrains.ReSharper.Psi.IField field) { }
        public string ErrorStripeToolTip { get; }
        public JetBrains.ReSharper.Psi.IField Field { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.VB.Tree.IReferenceExpression ReferenceExpression { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class NonSharedMethodWithSharedHandlesVariableError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "Events of shared WithEvents variables cannot be handled by non-shared methods";
        public NonSharedMethodWithSharedHandlesVariableError(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.Resolve.IReference Reference { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class NonStaticElementInStaticContextError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "Cannot access non-shared {0} \'{1}\' in shared context";
        public NonStaticElementInStaticContextError(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.Resolve.IReference Reference { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("PossibleMultipleWriteAccessInDoubleCheckLocking", "VBASIC", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.WARNING)]
    public class NonVolatileFieldInDoubleCheckLockingWarning : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "PossibleMultipleWriteAccessInDoubleCheckLocking";
        protected const string MESSAGE = "Posible incorrect implementation of Double-Check Locking. Checked field must be v" +
            "olatile or assigned from local variable after \'Thread.MemoryBarrier()\' call";
        public NonVolatileFieldInDoubleCheckLockingWarning(JetBrains.ReSharper.Psi.VB.Tree.IReferenceExpression referenceExpression) { }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.VB.Tree.IReferenceExpression ReferenceExpression { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("NotAssignedOutParameter", "VBASIC", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.WARNING)]
    public class NotAssignedOutParameterWarning : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "NotAssignedOutParameter";
        protected const string MESSAGE = "{0}";
        public NotAssignedOutParameterWarning(JetBrains.ReSharper.Psi.IDeclaredElement[] variables, JetBrains.ReSharper.Psi.Tree.ITreeNode exitElement) { }
        public string ErrorStripeToolTip { get; }
        public JetBrains.ReSharper.Psi.Tree.ITreeNode ExitElement { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public JetBrains.ReSharper.Psi.IDeclaredElement[] Variables { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class NothingToOverrideError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "{0} \'{1}\' cannot be declared \'Overrides\' because there is no matching member to o" +
            "verride in the base class";
        public NothingToOverrideError(JetBrains.ReSharper.Psi.VB.Tree.IVBTypeMemberDeclaration declaration) { }
        public JetBrains.ReSharper.Psi.VB.Tree.IVBTypeMemberDeclaration Declaration { get; }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", AttributeId="ReSharper Error Highlighting", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.UNRESOLVED_ERROR)]
    public class NotResolvedError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "Cannot resolve symbol \'{0}\'";
        public NotResolvedError(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.Resolve.IReference Reference { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", AttributeId="ReSharper Underlined Error Highlighting", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.UNRESOLVED_ERROR)]
    public class NotResolvedForEachPatternError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "Type \'{0}\' is not enumerable";
        public NotResolvedForEachPatternError(JetBrains.ReSharper.Psi.VB.Tree.IForEachStatement statement, JetBrains.ReSharper.Psi.IType declaredType) { }
        public JetBrains.ReSharper.Psi.IType DeclaredType { get; }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.VB.Tree.IForEachStatement Statement { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("VBWarnings::BC40056", "VBASIC", CompilerIds=new string[] {
            "BC40056"}, CompilerIdsWithDescription="BC40056:Namespace or type specified in the Imports \'name\' doesn\'t contain any pub" +
        "lic member or cannot be found", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.WARNING)]
    public class NotResolvedImportWarning : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "VBWarnings::BC40056";
        protected const string MESSAGE = "Namespace or type specified in the Imports \'{0}\' doesn\'t contain any public membe" +
            "r or cannot be found";
        public NotResolvedImportWarning(JetBrains.ReSharper.Psi.VB.Tree.IImportClause importClause, JetBrains.ReSharper.Psi.VB.Tree.IReferenceName referenceName) { }
        public string ErrorStripeToolTip { get; }
        public JetBrains.ReSharper.Psi.VB.Tree.IImportClause ImportClause { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.VB.Tree.IReferenceName ReferenceName { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", AttributeId="ReSharper Underlined Error Highlighting", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.UNRESOLVED_ERROR)]
    public class NotResolvedInAsyncError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "\'{0}\' is not a member of \'{1}\'";
        public NotResolvedInAsyncError(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.IDeclaredType declaredType) { }
        public JetBrains.ReSharper.Psi.IDeclaredType DeclaredType { get; }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.Resolve.IReference Reference { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("VBWarnings::BC42309", "VBASIC", AttributeId="ReSharper Error Highlighting", CompilerIds=new string[] {
            "BC42309"}, CompilerIdsWithDescription="BC42309:XML comment has a tag with a \'cref\' attribute that could not be resolved", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.UNRESOLVED_ERROR)]
    public class NotResolvedInDocCommentWarning : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "VBWarnings::BC42309";
        protected const string MESSAGE = "Cannot resolve symbol \'{0}\'";
        public NotResolvedInDocCommentWarning(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.Resolve.IReference Reference { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("NotResolvedInText", "VBASIC", AttributeId="ReSharper Error Highlighting", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.WARNING)]
    public class NotResolvedInTextWarning : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "NotResolvedInText";
        protected const string MESSAGE = "Cannot resolve symbol \'{0}\'";
        public NotResolvedInTextWarning(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.Resolve.IReference Reference { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class NotValidError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "{0} name is not valid at this point";
        public NotValidError(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.Resolve.IReference Reference { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class NoTypeArgumentsInUsageError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "Reference to \'{0}\' requires {1} type {2}";
        public NoTypeArgumentsInUsageError(JetBrains.ReSharper.Psi.Resolve.IReference reference, int parametersCount) { }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public int ParametersCount { get; }
        public JetBrains.ReSharper.Psi.Resolve.IReference Reference { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class NoTypeParametersInCandidateError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "\'{0}\' does not have type parameters";
        public NoTypeParametersInCandidateError(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.VB.Tree.ITypeArgumentList typeArgumentList) { }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.Resolve.IReference Reference { get; }
        public string ToolTip { get; }
        public JetBrains.ReSharper.Psi.VB.Tree.ITypeArgumentList TypeArgumentList { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class ObsoleteElementError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "{0}";
        public ObsoleteElementError(JetBrains.ReSharper.Psi.Resolve.IReference reference, string obsoleteMessage) { }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public string ObsoleteMessage { get; }
        public JetBrains.ReSharper.Psi.Resolve.IReference Reference { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("VBWarnings::BC40000", "VBASIC", CompilerIds=new string[] {
            "BC40000"}, CompilerIdsWithDescription="BC40000:Use obsolete member", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.WARNING)]
    public class ObsoleteElementWarning : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "VBWarnings::BC40000";
        protected const string MESSAGE = "{0}";
        public ObsoleteElementWarning(JetBrains.ReSharper.Psi.Resolve.IReference reference, string obsoleteMessage) { }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public string ObsoleteMessage { get; }
        public JetBrains.ReSharper.Psi.Resolve.IReference Reference { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("VBWarnings::BC40008", "VBASIC", CompilerIds=new string[] {
            "BC40008"}, CompilerIdsWithDescription="BC40008:Use obsolete member (without message)", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.WARNING)]
    public class ObsoleteElementWithoutMessageWarning : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "VBWarnings::BC40008";
        protected const string MESSAGE = "{0}";
        public ObsoleteElementWithoutMessageWarning(JetBrains.ReSharper.Psi.Resolve.IReference reference, string obsoleteMessage) { }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public string ObsoleteMessage { get; }
        public JetBrains.ReSharper.Psi.Resolve.IReference Reference { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("OperatorIsCanBeUsed", "VBASIC", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.WARNING)]
    public class OperatorIsCanBeUsedWarning : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "OperatorIsCanBeUsed";
        protected const string MESSAGE = "Operator \'TypeOf ... Is ...\' can be used";
        public OperatorIsCanBeUsedWarning(JetBrains.ReSharper.Psi.VB.Tree.IVBExpression expression, JetBrains.ReSharper.Psi.IDeclaredType type, JetBrains.ReSharper.Psi.VB.Tree.IVBExpression qualifier) { }
        public string ErrorStripeToolTip { get; }
        public JetBrains.ReSharper.Psi.VB.Tree.IVBExpression Expression { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.VB.Tree.IVBExpression Qualifier { get; }
        public string ToolTip { get; }
        public JetBrains.ReSharper.Psi.IDeclaredType Type { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class OverrideOrImplementDiffersInOptionalError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "\'{0}\' cannot {1} \'{2}\' because they differ by optional parameter";
        public OverrideOrImplementDiffersInOptionalError(JetBrains.ReSharper.Psi.IOverridableMember member, JetBrains.ReSharper.Psi.VB.Tree.IVBTypeMemberDeclaration memberDeclaration, JetBrains.ReSharper.Psi.IOverridableMember superMember, JetBrains.ReSharper.Psi.IParameter conflictParameter) { }
        public JetBrains.ReSharper.Psi.IParameter ConflictParameter { get; }
        public string ErrorStripeToolTip { get; }
        public JetBrains.ReSharper.Psi.IOverridableMember Member { get; }
        public JetBrains.ReSharper.Psi.VB.Tree.IVBTypeMemberDeclaration MemberDeclaration { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.IOverridableMember SuperMember { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class OverrideOrImplementDiffersInOptionalValueError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "\'{0}\' cannot {1} \'{2}\' because they differ by the default values of optional para" +
            "meter";
        public OverrideOrImplementDiffersInOptionalValueError(JetBrains.ReSharper.Psi.IOverridableMember member, JetBrains.ReSharper.Psi.VB.Tree.IVBTypeMemberDeclaration memberDeclaration, JetBrains.ReSharper.Psi.IOverridableMember superMember, JetBrains.ReSharper.Psi.IParameter conflictParameter) { }
        public JetBrains.ReSharper.Psi.IParameter ConflictParameter { get; }
        public string ErrorStripeToolTip { get; }
        public JetBrains.ReSharper.Psi.IOverridableMember Member { get; }
        public JetBrains.ReSharper.Psi.VB.Tree.IVBTypeMemberDeclaration MemberDeclaration { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.IOverridableMember SuperMember { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class OverrideOrImplementDiffersInParamArrayError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "\'{0}\' cannot {1} \'{2}\' because they differ by \'ParamArray\' parameter";
        public OverrideOrImplementDiffersInParamArrayError(JetBrains.ReSharper.Psi.IOverridableMember member, JetBrains.ReSharper.Psi.VB.Tree.IVBTypeMemberDeclaration memberDeclaration, JetBrains.ReSharper.Psi.IOverridableMember superMember, JetBrains.ReSharper.Psi.IParameter conflictParameter) { }
        public JetBrains.ReSharper.Psi.IParameter ConflictParameter { get; }
        public string ErrorStripeToolTip { get; }
        public JetBrains.ReSharper.Psi.IOverridableMember Member { get; }
        public JetBrains.ReSharper.Psi.VB.Tree.IVBTypeMemberDeclaration MemberDeclaration { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.IOverridableMember SuperMember { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("ParameterHidesMember", "VBASIC", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.WARNING)]
    public class ParameterHidesMemberWarning : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "ParameterHidesMember";
        protected const string MESSAGE = "Parameter \'{0}\' hides {1} \'{2}\'";
        public ParameterHidesMemberWarning(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration, JetBrains.ReSharper.Psi.ITypeMember hiddenMember) { }
        public JetBrains.ReSharper.Psi.Tree.IDeclaration Declaration { get; }
        public string ErrorStripeToolTip { get; }
        public JetBrains.ReSharper.Psi.ITypeMember HiddenMember { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("RedundantAssignment", "VBASIC", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.WARNING)]
    public class ParameterValueIsOverridenWarning : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "RedundantAssignment";
        protected const string MESSAGE = "The value passed to the method is never used because it is overwritten in the met" +
            "hod body before being read";
        public ParameterValueIsOverridenWarning(JetBrains.ReSharper.Psi.Tree.IParameterDeclaration declaration) { }
        public JetBrains.ReSharper.Psi.Tree.IParameterDeclaration Declaration { get; }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class PartialArrayBoundsSpecificationError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "Array modifier cannot contain both specified and unspecified bounds";
        public PartialArrayBoundsSpecificationError(JetBrains.ReSharper.Psi.VB.Tree.IArrayModifier arrayModifier) { }
        public JetBrains.ReSharper.Psi.VB.Tree.IArrayModifier ArrayModifier { get; }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class PartialDeclarationCannotBeAsyncError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "\'Async\' modifier cannot be used in partial method declaration";
        public PartialDeclarationCannotBeAsyncError(JetBrains.ReSharper.Psi.VB.Tree.IModifiersList modifiersList, JetBrains.ReSharper.Psi.Tree.ITokenNode asyncNode) { }
        public JetBrains.ReSharper.Psi.Tree.ITokenNode AsyncNode { get; }
        public string ErrorStripeToolTip { get; }
        public JetBrains.ReSharper.Psi.VB.Tree.IModifiersList ModifiersList { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("PossibleAssignmentToReadonlyField", "VBASIC", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.WARNING)]
    public class PossibleAssignmentToReadonlyFieldWarning : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "PossibleAssignmentToReadonlyField";
        protected const string MESSAGE = "Assignment to a property of a readonly field can be useless. Field type is not kn" +
            "own to be reference type";
        public PossibleAssignmentToReadonlyFieldWarning(JetBrains.ReSharper.Psi.VB.Tree.IReferenceExpression expression) { }
        public string ErrorStripeToolTip { get; }
        public JetBrains.ReSharper.Psi.VB.Tree.IReferenceExpression Expression { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("PossibleIntendedRethrow", "VBASIC", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.WARNING)]
    public class PossibleIntendedRethrowWarning : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "PossibleIntendedRethrow";
        protected const string MESSAGE = "Exception rethrow possibly intended";
        public PossibleIntendedRethrowWarning(JetBrains.ReSharper.Psi.VB.Tree.IThrowStatement statement) { }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.VB.Tree.IThrowStatement Statement { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("PossibleMultipleEnumeration", "VBASIC", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.WARNING)]
    public class PossibleMultipleEnumerationWarning : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "PossibleMultipleEnumeration";
        protected const string MESSAGE = "Possible multiple enumeration of IEnumerable";
        public PossibleMultipleEnumerationWarning(JetBrains.ReSharper.Psi.Tree.IExpression usage, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.VB.Tree.IVBExpression> allUsages) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.VB.Tree.IVBExpression> AllUsages { get; }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public JetBrains.ReSharper.Psi.Tree.IExpression Usage { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("PossibleMultipleWriteAccessInDoubleCheckLocking", "VBASIC", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.WARNING)]
    public class PossibleMultipleWriteAccessInDoubleCheckLockingWarning : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "PossibleMultipleWriteAccessInDoubleCheckLocking";
        protected const string MESSAGE = "Posible incorrect implementation of Double-Check Locking. Possible multiple write" +
            " access to checked field";
        public PossibleMultipleWriteAccessInDoubleCheckLockingWarning(JetBrains.ReSharper.Psi.VB.Tree.IReferenceExpression referenceExpression) { }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.VB.Tree.IReferenceExpression ReferenceExpression { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("PossibleWriteToMe", "VBASIC", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.WARNING)]
    public class PossibleWriteToMeWarning : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "PossibleWriteToMe";
        protected const string MESSAGE = "Possible write to \'Me\'";
        public PossibleWriteToMeWarning(JetBrains.ReSharper.Psi.VB.Tree.IInstanceExpression expression) { }
        public string ErrorStripeToolTip { get; }
        public JetBrains.ReSharper.Psi.VB.Tree.IInstanceExpression Expression { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.UNRESOLVED_ERROR)]
    public class ProblemInResolveError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "Cannot resolve symbol \'{0}\'. Error type: {1}";
        public ProblemInResolveError(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.Resolve.ResolveErrorType errorType) { }
        public string ErrorStripeToolTip { get; }
        public JetBrains.ReSharper.Psi.Resolve.ResolveErrorType ErrorType { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.Resolve.IReference Reference { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class PropertyCanHaveOnlySetterAndGetterError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "Property might have only \'Get\' and a \'Set\'";
        public PropertyCanHaveOnlySetterAndGetterError(JetBrains.ReSharper.Psi.VB.Tree.IAccessorDeclaration accessorDeclaration) { }
        public JetBrains.ReSharper.Psi.VB.Tree.IAccessorDeclaration AccessorDeclaration { get; }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class PropertyMustHaveSetterAndGetterError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "Property without a \'ReadOnly\' or \'WriteOnly\' specifier must provide both a \'Get\' " +
            "and a \'Set\'";
        public PropertyMustHaveSetterAndGetterError(JetBrains.ReSharper.Psi.VB.Tree.IPropertyDeclaration propertyDeclaration) { }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.VB.Tree.IPropertyDeclaration PropertyDeclaration { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class PropertyShouldBeParameterlessError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "\'{0}\' should be parameterless in order to initialize it through an object initial" +
            "izer";
        public PropertyShouldBeParameterlessError(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.Resolve.IReference Reference { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class PropertyWithoutSetterError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "Cannot assign to a property without setter or with inaccessible setter";
        public PropertyWithoutSetterError(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.IProperty property) { }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.IProperty Property { get; }
        public JetBrains.ReSharper.Psi.Resolve.IReference Reference { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("PureAttributeOnVoidMethod", "VBASIC", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.WARNING)]
    public class PureAttributeOnVoidMethodWarning : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "PureAttributeOnVoidMethod";
        protected const string MESSAGE = "Annotating \'Sub\' by <Pure> is meaningless";
        public PureAttributeOnVoidMethodWarning(JetBrains.ReSharper.Psi.VB.Tree.IAttribute attribute) { }
        public JetBrains.ReSharper.Psi.VB.Tree.IAttribute Attribute { get; }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class QueryTypeInferenceError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "Type arguments for \'{0}\' cannot be inferred from the query";
        public QueryTypeInferenceError(JetBrains.ReSharper.Psi.Resolve.IReference Reference, JetBrains.ReSharper.Psi.IMethod method) { }
        public string ErrorStripeToolTip { get; }
        public JetBrains.ReSharper.Psi.IMethod Method { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.Resolve.IReference Reference { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class QueryTypeInferenceMultipleCandidatesError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "Type arguments cannot be inferred from the query. Candidates are: {0}";
        public QueryTypeInferenceMultipleCandidatesError(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.Resolve.IReference Reference { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("ReadAccessInDoubleCheckLocking", "VBASIC", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.WARNING)]
    public class ReadAccessInDoubleCheckLockingWarning : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "ReadAccessInDoubleCheckLocking";
        protected const string MESSAGE = "Posible incorrect implementation of Double-Check Locking. Read access to checked " +
            "field";
        public ReadAccessInDoubleCheckLockingWarning(JetBrains.ReSharper.Psi.VB.Tree.IReferenceExpression referenceExpression) { }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.VB.Tree.IReferenceExpression ReferenceExpression { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class ReadAccessToPropertyWithoutGetterError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "{0} \'{1}\' has no getter";
        public ReadAccessToPropertyWithoutGetterError(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.IProperty property) { }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.IProperty Property { get; }
        public JetBrains.ReSharper.Psi.Resolve.IReference Reference { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("VBWarnings::BC42104", "VBASIC", CompilerIds=new string[] {
            "BC42104"}, CompilerIdsWithDescription="BC42104:Variable is used before it has been assigned a value", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.WARNING)]
    public class ReadBeforeWriteWarning : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "VBWarnings::BC42104";
        protected const string MESSAGE = "Variable \'{0}\' might not be initialized before accessing. A null reference except" +
            "ion could occur at runtime";
        public ReadBeforeWriteWarning(JetBrains.ReSharper.Psi.Tree.ITreeNode accessExpression, JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
        public JetBrains.ReSharper.Psi.Tree.ITreeNode AccessExpression { get; }
        public JetBrains.ReSharper.Psi.IDeclaredElement DeclaredElement { get; }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class ReadonlyAssignmentTargetError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "\'ReadOnly\' {0} cannot be used as an assignment target";
        public ReadonlyAssignmentTargetError(JetBrains.ReSharper.Psi.VB.Tree.IVBExpression destination, JetBrains.ReSharper.Psi.IDeclaredElement element) { }
        public JetBrains.ReSharper.Psi.VB.Tree.IVBExpression Destination { get; }
        public JetBrains.ReSharper.Psi.IDeclaredElement Element { get; }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class ReadOnlyPropertyWithoutGetterError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "\'ReadOnly\' property must provide getter";
        public ReadOnlyPropertyWithoutGetterError(JetBrains.ReSharper.Psi.VB.Tree.IPropertyDeclaration propertyDeclaration) { }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.VB.Tree.IPropertyDeclaration PropertyDeclaration { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class ReadOnlyPropertyWithSetterError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "\'ReadOnly\' property must not have setter";
        public ReadOnlyPropertyWithSetterError(JetBrains.ReSharper.Psi.VB.Tree.IPropertyDeclaration propertyDeclaration, JetBrains.ReSharper.Psi.VB.Tree.IAccessorDeclaration accessorDeclaration) { }
        public JetBrains.ReSharper.Psi.VB.Tree.IAccessorDeclaration AccessorDeclaration { get; }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.VB.Tree.IPropertyDeclaration PropertyDeclaration { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("RedundantArrayLowerBoundSpecification", "VBASIC", AttributeId="ReSharper Dead Code", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.DEADCODE)]
    public class RedundantArrayLowerBoundSpecificationWarning : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "RedundantArrayLowerBoundSpecification";
        protected const string MESSAGE = "Redundant array lower bound specification";
        public RedundantArrayLowerBoundSpecificationWarning(JetBrains.ReSharper.Psi.VB.Tree.IArrayBound arrayBound) { }
        public JetBrains.ReSharper.Psi.VB.Tree.IArrayBound ArrayBound { get; }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("RedundantCast", "VBASIC", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.WARNING)]
    public class RedundantCastWarning : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "RedundantCast";
        protected const string MESSAGE = "Type cast is redundant";
        public RedundantCastWarning(JetBrains.ReSharper.Psi.VB.Tree.ICastExpression expression, JetBrains.ReSharper.Psi.VB.Tree.ITypeUsage typeUsage) { }
        public string ErrorStripeToolTip { get; }
        public JetBrains.ReSharper.Psi.VB.Tree.ICastExpression Expression { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public JetBrains.ReSharper.Psi.VB.Tree.ITypeUsage TypeUsage { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("VBWarnings::BC42349", "VBASIC", AttributeId="ReSharper Dead Code", CompilerIds=new string[] {
            "BC42349"}, CompilerIdsWithDescription="BC42349:Redundant DirectCast to the equals value type", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.DEADCODE)]
    public class RedundantDirectCastWithValueTypeWarning : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "VBWarnings::BC42349";
        protected const string MESSAGE = "Using DirectCast operator to cast a value-type to the same type is obsolete";
        public RedundantDirectCastWithValueTypeWarning(JetBrains.ReSharper.Psi.VB.Tree.ICastExpression expression, JetBrains.ReSharper.Psi.VB.Tree.ITypeUsage typeUsage) { }
        public string ErrorStripeToolTip { get; }
        public JetBrains.ReSharper.Psi.VB.Tree.ICastExpression Expression { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public JetBrains.ReSharper.Psi.VB.Tree.ITypeUsage TypeUsage { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("RedundantEmptyCaseElse", "VBASIC", AttributeId="ReSharper Dead Code", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.DEADCODE)]
    public class RedundantEmptyCaseElseWarning : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "RedundantEmptyCaseElse";
        protected const string MESSAGE = "Redundant empty Case Else";
        public RedundantEmptyCaseElseWarning(JetBrains.ReSharper.Psi.VB.Tree.ICaseStatement caseStatement) { }
        public JetBrains.ReSharper.Psi.VB.Tree.ICaseStatement CaseStatement { get; }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("RedundantExplicitArraySize", "VBASIC", AttributeId="ReSharper Dead Code", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.DEADCODE)]
    public class RedundantExplicitArraySizeWarning : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "RedundantExplicitArraySize";
        protected const string MESSAGE = "Redundant explicit array size specification";
        public RedundantExplicitArraySizeWarning(JetBrains.ReSharper.Psi.VB.Tree.IArrayBound sizeExpression) { }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.VB.Tree.IArrayBound SizeExpression { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("RedundantLogicalConditionalExpressionOperand", "VBASIC", AttributeId="ReSharper Dead Code", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.DEADCODE)]
    public class RedundantLogicalConditionalExpressionOperandWarning : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "RedundantLogicalConditionalExpressionOperand";
        protected const string MESSAGE = "Redundant operand in logical conditional expression";
        public RedundantLogicalConditionalExpressionOperandWarning(JetBrains.ReSharper.Psi.VB.Tree.IVBBinaryExpression conditionalExpression, JetBrains.ReSharper.Psi.Tree.IExpression operand) { }
        public JetBrains.ReSharper.Psi.VB.Tree.IVBBinaryExpression ConditionalExpression { get; }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.Tree.IExpression Operand { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("RedundantMeQualifier", "VBASIC", AttributeId="ReSharper Dead Code", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.DEADCODE)]
    public class RedundantMeQualifierWarning : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "RedundantMeQualifier";
        protected const string MESSAGE = "Qualifier \'Me.\' is redundant";
        public RedundantMeQualifierWarning(JetBrains.ReSharper.Psi.VB.Tree.IVBExpression qualifier, JetBrains.ReSharper.Psi.Tree.ITokenNode dot) { }
        public JetBrains.ReSharper.Psi.Tree.ITokenNode Dot { get; }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.VB.Tree.IVBExpression Qualifier { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("RedundantMyBaseQualifier", "VBASIC", AttributeId="ReSharper Dead Code", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.DEADCODE)]
    public class RedundantMyBaseQualifierWarning : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "RedundantMyBaseQualifier";
        protected const string MESSAGE = "Qualifier \'MyBase.\' is redundant";
        public RedundantMyBaseQualifierWarning(JetBrains.ReSharper.Psi.VB.Tree.IVBExpression qualifier, JetBrains.ReSharper.Psi.Tree.ITokenNode dot) { }
        public JetBrains.ReSharper.Psi.Tree.ITokenNode Dot { get; }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.VB.Tree.IVBExpression Qualifier { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("RedundantMyClassQualifier", "VBASIC", AttributeId="ReSharper Dead Code", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.DEADCODE)]
    public class RedundantMyClassQualifierWarning : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "RedundantMyClassQualifier";
        protected const string MESSAGE = "Qualifier \'MyClass.\' is redundant";
        public RedundantMyClassQualifierWarning(JetBrains.ReSharper.Psi.VB.Tree.IVBExpression qualifier, JetBrains.ReSharper.Psi.Tree.ITokenNode dot) { }
        public JetBrains.ReSharper.Psi.Tree.ITokenNode Dot { get; }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.VB.Tree.IVBExpression Qualifier { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("RedundantQualifier", "VBASIC", AttributeId="ReSharper Dead Code", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.DEADCODE)]
    public class RedundantQualifierWarning : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "RedundantQualifier";
        protected const string MESSAGE = "Qualifier is redundant";
        public RedundantQualifierWarning(JetBrains.ReSharper.Psi.Tree.ITreeNode qualifier, JetBrains.ReSharper.Psi.Tree.ITokenNode dot) { }
        public JetBrains.ReSharper.Psi.Tree.ITokenNode Dot { get; }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.Tree.ITreeNode Qualifier { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class RefArgumentTypeMismatchError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "The argument type does not match \'ByRef\' parameter type";
        public RefArgumentTypeMismatchError(JetBrains.ReSharper.Psi.VB.IVBArgumentInfo argument) { }
        public JetBrains.ReSharper.Psi.VB.IVBArgumentInfo Argument { get; }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("ReferenceEqualsWithValueType", "VBASIC", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.WARNING)]
    public class ReferenceEqualsWithValueTypeWarning : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "ReferenceEqualsWithValueType";
        protected const string MESSAGE = "\'Object.ReferenceEquals\' is always false because it is called with value type";
        public ReferenceEqualsWithValueTypeWarning(JetBrains.ReSharper.Psi.VB.Tree.IIndexExpression expression) { }
        public string ErrorStripeToolTip { get; }
        public JetBrains.ReSharper.Psi.VB.Tree.IIndexExpression Expression { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class ReturnNoExpressionFromFunctionError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "\'Return\' statement in a Function, Get, or Operator must return a value";
        public ReturnNoExpressionFromFunctionError(JetBrains.ReSharper.Psi.VB.Tree.IReturnStatement returnStatement) { }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.VB.Tree.IReturnStatement ReturnStatement { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class ReturnValueFromAsyncTaskFunctionError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "\'Return\' statement in this Async method cannot return a value. Consider changing " +
            "the method return type to \'Task(Of T)\'";
        public ReturnValueFromAsyncTaskFunctionError(JetBrains.ReSharper.Psi.VB.Tree.IReturnStatement returnStatement) { }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.VB.Tree.IReturnStatement ReturnStatement { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class ReturnValueFromIteratorError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "To return a value from an Iterator function, use \'Yield\'";
        public ReturnValueFromIteratorError(JetBrains.ReSharper.Psi.VB.Tree.IReturnStatement returnStatement) { }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.VB.Tree.IReturnStatement ReturnStatement { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class ReturnValueFromSubError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "\'Return\' statement in a Sub or a Set cannot return a value";
        public ReturnValueFromSubError(JetBrains.ReSharper.Psi.VB.Tree.IReturnStatement returnStatement) { }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.VB.Tree.IReturnStatement ReturnStatement { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("ReturnValueOfPureMethodIsNotUsed", "VBASIC", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.WARNING)]
    public class ReturnValueOfPureMethodIsNotUsedWarning : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "ReturnValueOfPureMethodIsNotUsed";
        protected const string MESSAGE = "Return value of pure method is not used";
        public ReturnValueOfPureMethodIsNotUsedWarning(JetBrains.ReSharper.Psi.VB.Tree.IInvocationStatement invocationStatement, JetBrains.ReSharper.Psi.Resolve.IReference invocationReference) { }
        public string ErrorStripeToolTip { get; }
        public JetBrains.ReSharper.Psi.Resolve.IReference InvocationReference { get; }
        public JetBrains.ReSharper.Psi.VB.Tree.IInvocationStatement InvocationStatement { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("VBWarnings::BC400005", "VBASIC", CompilerIds=new string[] {
            "BC400005"}, CompilerIdsWithDescription=" BC400005:Member shadows an overriable member", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.WARNING)]
    public class ShadowsOverridableMemberWarning : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "VBWarnings::BC400005";
        protected const string MESSAGE = "{0} \'{1}\' shadows an overridable method in the base class \'{2}\'";
        public ShadowsOverridableMemberWarning(JetBrains.ReSharper.Psi.VB.Tree.IVBTypeMemberDeclaration derivedMemberDeclaration, JetBrains.ReSharper.Psi.IOverridableMember baseMember) { }
        public JetBrains.ReSharper.Psi.IOverridableMember BaseMember { get; }
        public JetBrains.ReSharper.Psi.VB.Tree.IVBTypeMemberDeclaration DerivedMemberDeclaration { get; }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class SharedMemeberInModuleError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "Member in a Module cannot be declared \'Shared\'";
        public SharedMemeberInModuleError(JetBrains.ReSharper.Psi.VB.Tree.IVBModifiersOwnerDeclaration declaration) { }
        public JetBrains.ReSharper.Psi.VB.Tree.IVBModifiersOwnerDeclaration Declaration { get; }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class ShouldBeInvocableError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "Method, property, delegate or event is expected";
        public ShouldBeInvocableError(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.Resolve.IReference Reference { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class ShouldBeInvocableOrArrayError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "Expression is not an array or a method, and cannot have an argument list";
        public ShouldBeInvocableOrArrayError(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.Resolve.IReference Reference { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class ShouldBeSimpleNameError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "{0} \'{1}\' should be used as simple name";
        public ShouldBeSimpleNameError(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.Resolve.IReference Reference { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("SimplifyConditionalOperator", "VBASIC", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.WARNING)]
    public class SimplifyConditionalOperatorWarning : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "SimplifyConditionalOperator";
        protected const string MESSAGE = "Simplify conditional operator";
        public SimplifyConditionalOperatorWarning(JetBrains.ReSharper.Psi.VB.Tree.IConditionalExpression conditionalExpression, System.Nullable<bool> thenLiteralValue, System.Nullable<bool> elseLiteralValue) { }
        public JetBrains.ReSharper.Psi.VB.Tree.IConditionalExpression ConditionalExpression { get; }
        public System.Nullable<bool> ElseLiteralValue { get; }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public System.Nullable<bool> ThenLiteralValue { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("SimplifyIIf", "VBASIC", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.WARNING)]
    public class SimplifyIIfWarning : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "SimplifyIIf";
        protected const string MESSAGE = "Simplify \'IIf\'";
        public SimplifyIIfWarning(JetBrains.ReSharper.Psi.VB.Tree.IIndexExpression iIfExpression, System.Nullable<bool> thenLiteralValue, System.Nullable<bool> elseLiteralValue) { }
        public System.Nullable<bool> ElseLiteralValue { get; }
        public string ErrorStripeToolTip { get; }
        public JetBrains.ReSharper.Psi.VB.Tree.IIndexExpression IIfExpression { get; }
        public int NavigationOffsetPatch { get; }
        public System.Nullable<bool> ThenLiteralValue { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class SingleLineIteratorLambdaError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "Single-line lambda cannot have the \'Iterator\' modifier";
        public SingleLineIteratorLambdaError(JetBrains.ReSharper.Psi.VB.Tree.ILambdaExpression lambdaExpression) { }
        public string ErrorStripeToolTip { get; }
        public JetBrains.ReSharper.Psi.VB.Tree.ILambdaExpression LambdaExpression { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("SpecifyStringComparison", "VBASIC", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.WARNING)]
    public class SpecifyStringComparisonWarning : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "SpecifyStringComparison";
        protected const string MESSAGE = "Specify string comparison explicitly";
        public SpecifyStringComparisonWarning(JetBrains.ReSharper.Psi.VB.Tree.IVBExpression expression, JetBrains.ReSharper.Psi.VB.Tree.IVBExpression arg1, JetBrains.ReSharper.Psi.VB.Tree.IVBExpression arg2, bool negate, bool invariantCulture, bool ignoreCase) { }
        public JetBrains.ReSharper.Psi.VB.Tree.IVBExpression Arg1 { get; }
        public JetBrains.ReSharper.Psi.VB.Tree.IVBExpression Arg2 { get; }
        public string ErrorStripeToolTip { get; }
        public JetBrains.ReSharper.Psi.VB.Tree.IVBExpression Expression { get; }
        public bool IgnoreCase { get; }
        public bool InvariantCulture { get; }
        public int NavigationOffsetPatch { get; }
        public bool Negate { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("VBWarnings::BC42025", "VBASIC", CompilerIds=new string[] {
            "BC42025"}, CompilerIdsWithDescription="BC42025:Access of shared member through an instance", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.WARNING)]
    public class StaticElementInNonStaticContextWarning : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "VBWarnings::BC42025";
        protected const string MESSAGE = "Access of shared member, constant member, enum member or nested type through an i" +
            "nstance; qualifying expression will not be evaluated";
        public StaticElementInNonStaticContextWarning(JetBrains.ReSharper.Psi.VB.Tree.IReferenceExpressionReference reference, JetBrains.ReSharper.Psi.VB.Tree.IReferenceExpression referenceExpression) { }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.VB.Tree.IReferenceExpressionReference Reference { get; }
        public JetBrains.ReSharper.Psi.VB.Tree.IReferenceExpression ReferenceExpression { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("StaticFieldInGenericType", "VBASIC", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.WARNING)]
    public class StaticFieldInGenericTypeWarning : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "StaticFieldInGenericType";
        protected const string MESSAGE = "Shared field in generic type";
        public StaticFieldInGenericTypeWarning(JetBrains.ReSharper.Psi.VB.Tree.IVariableDeclaration fieldDeclaration) { }
        public string ErrorStripeToolTip { get; }
        public JetBrains.ReSharper.Psi.VB.Tree.IVariableDeclaration FieldDeclaration { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("StaticFieldInitializersReferesToFieldBelow", "VBASIC", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.WARNING)]
    public class StaticFieldInitializersReferesToFieldBelowWarning : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "StaticFieldInitializersReferesToFieldBelow";
        protected const string MESSAGE = "Shared field initializer refers to shared field below or in other part";
        public StaticFieldInitializersReferesToFieldBelowWarning(JetBrains.ReSharper.Psi.VB.Tree.IVBExpression expression) { }
        public string ErrorStripeToolTip { get; }
        public JetBrains.ReSharper.Psi.VB.Tree.IVBExpression Expression { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class StrictnessFailedError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "No accessible \'{0}\' can be called without a narrowing conversion. Candidates are:" +
            " {1}";
        public StrictnessFailedError(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.Resolve.IReference Reference { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class SubCannotBeIteratorMethodError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "Sub cannot be Iterator";
        public SubCannotBeIteratorMethodError(JetBrains.ReSharper.Psi.Tree.ITokenNode subKeyword) { }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.Tree.ITokenNode SubKeyword { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class SubCannotHaveReturnTypeError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "\'Sub\' cannot have return type";
        public SubCannotHaveReturnTypeError(JetBrains.ReSharper.Psi.VB.Tree.IMethodDeclarationBase declaration) { }
        public JetBrains.ReSharper.Psi.VB.Tree.IMethodDeclarationBase Declaration { get; }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("VBWarnings::BC42304", "VBASIC", AttributeId="ReSharper Underlined Error Highlighting", CompilerIds=new string[] {
            "BC42304"}, CompilerIdsWithDescription="BC42304:Syntax error in XML comment", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class SyntaxErrorInDocCommentWarning : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "VBWarnings::BC42304";
        protected const string MESSAGE = "Syntax error";
        public SyntaxErrorInDocCommentWarning(JetBrains.DocumentModel.DocumentRange range) { }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.DocumentModel.DocumentRange Range { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("ThreadStaticAtInstanceField", "VBASIC", AttributeId="ReSharper Dead Code", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.DEADCODE)]
    public class ThreadStaticAtInstanceFieldWarning : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "ThreadStaticAtInstanceField";
        protected const string MESSAGE = "<ThreadStatic> doesn\'t work with instance fields";
        public ThreadStaticAtInstanceFieldWarning(JetBrains.ReSharper.Psi.VB.Tree.IAttribute attribute, JetBrains.ReSharper.Psi.VB.Tree.IVariableDeclaration fieldDeclaration) { }
        public JetBrains.ReSharper.Psi.VB.Tree.IAttribute Attribute { get; }
        public string ErrorStripeToolTip { get; }
        public JetBrains.ReSharper.Psi.VB.Tree.IVariableDeclaration FieldDeclaration { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("ThreadStaticFieldHasInitializer", "VBASIC", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.WARNING)]
    public class ThreadStaticFieldHasInitializerWarning : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "ThreadStaticFieldHasInitializer";
        protected const string MESSAGE = "Thread static field has initializer";
        public ThreadStaticFieldHasInitializerWarning(JetBrains.ReSharper.Psi.VB.Tree.IVariableDeclaration fieldDeclaration) { }
        public string ErrorStripeToolTip { get; }
        public JetBrains.ReSharper.Psi.VB.Tree.IVariableDeclaration FieldDeclaration { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class TryCastWithGenericTypeWithoutClassError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "\'TryCast\' operands must be class-constrained type parameter, but \'{0}\' has no cla" +
            "ss constraint";
        public TryCastWithGenericTypeWithoutClassError(JetBrains.ReSharper.Psi.VB.Tree.ICastExpression expression, JetBrains.ReSharper.Psi.VB.Tree.ITypeUsage typeUsage, JetBrains.ReSharper.Psi.IType castType) { }
        public JetBrains.ReSharper.Psi.IType CastType { get; }
        public string ErrorStripeToolTip { get; }
        public JetBrains.ReSharper.Psi.VB.Tree.ICastExpression Expression { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public JetBrains.ReSharper.Psi.VB.Tree.ITypeUsage TypeUsage { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class TryCastWithValueTypeError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "\'TryCast\' operand must be reference type, but \'{0}\' is a value type";
        public TryCastWithValueTypeError(JetBrains.ReSharper.Psi.VB.Tree.ICastExpression expression, JetBrains.ReSharper.Psi.VB.Tree.ITypeUsage typeUsage, JetBrains.ReSharper.Psi.IType castType) { }
        public JetBrains.ReSharper.Psi.IType CastType { get; }
        public string ErrorStripeToolTip { get; }
        public JetBrains.ReSharper.Psi.VB.Tree.ICastExpression Expression { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public JetBrains.ReSharper.Psi.VB.Tree.ITypeUsage TypeUsage { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("TryStatementsCanBeMerged", "VBASIC", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.WARNING)]
    public class TryStatementsCanBeMergedWarning : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "TryStatementsCanBeMerged";
        protected const string MESSAGE = "try-catch and try-finally statements can be merged";
        public TryStatementsCanBeMergedWarning(JetBrains.ReSharper.Psi.VB.Tree.ITryStatement tryStatement, JetBrains.ReSharper.Psi.VB.Tree.ITryStatement childTryStatement) { }
        public JetBrains.ReSharper.Psi.VB.Tree.ITryStatement ChildTryStatement { get; }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public JetBrains.ReSharper.Psi.VB.Tree.ITryStatement TryStatement { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class TypeExpectedError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "Type name expected, but {0} name found";
        public TypeExpectedError(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public JetBrains.ReSharper.Psi.IDeclaredElement DeclaredElement { get; }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.Resolve.IReference Reference { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class TypeExpectedNoCandidateError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "Type name expected";
        public TypeExpectedNoCandidateError(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.Resolve.IReference Reference { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class TypeInferenceError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "Type arguments for \'{0}\' cannot be inferred from the usage. Try specifying type a" +
            "rguments explicitly";
        public TypeInferenceError(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.IMethod method) { }
        public string ErrorStripeToolTip { get; }
        public JetBrains.ReSharper.Psi.IMethod Method { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.Resolve.IReference Reference { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class TypeInferenceMultipleCandidatesError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "Type arguments cannot be inferred from the usage. Try specifying type arguments e" +
            "xplicitly. Candidates are: {0}";
        public TypeInferenceMultipleCandidatesError(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.Resolve.IReference Reference { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class TypeParametersNumberMismatchError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "Incorrect number of type parameters in reference to \'{0}\'";
        public TypeParametersNumberMismatchError(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.VB.Tree.ITypeArgumentList typeArgumentList) { }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.Resolve.IReference Reference { get; }
        public string ToolTip { get; }
        public JetBrains.ReSharper.Psi.VB.Tree.ITypeArgumentList TypeArgumentList { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class TypeParametersNumberMismatchMultipleCandidatesError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "Incorrect number of type parameters. Candidates are: {0}";
        public TypeParametersNumberMismatchMultipleCandidatesError(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.VB.Tree.ITypeArgumentList typeArgumentList) { }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.Resolve.IReference Reference { get; }
        public string ToolTip { get; }
        public JetBrains.ReSharper.Psi.VB.Tree.ITypeArgumentList TypeArgumentList { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("VbUnreachableCode", "VBASIC", AttributeId="ReSharper Dead Code", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.DEADCODE)]
    public class UnreachableCodeWarning : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "VbUnreachableCode";
        protected const string MESSAGE = "Code is unreachable";
        public UnreachableCodeWarning(JetBrains.ReSharper.Psi.ITreeRange treeRange) { }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public JetBrains.ReSharper.Psi.ITreeRange TreeRange { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class UnresolvedBranchStatementError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "Unresolved jump";
        public UnresolvedBranchStatementError(JetBrains.ReSharper.Psi.Tree.ITreeNode node) { }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.Tree.ITreeNode Node { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("UnusedImportClause", "VBASIC", AttributeId="ReSharper Dead Code", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.DEADCODE)]
    public class UnusedImportClauseWarning : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "UnusedImportClause";
        protected const string MESSAGE = "Import clause is not required by the code and can be safely removed";
        public UnusedImportClauseWarning(JetBrains.ReSharper.Psi.VB.Tree.IImportClause clause) { }
        public JetBrains.ReSharper.Psi.VB.Tree.IImportClause Clause { get; }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class UseLocalVariableBeforeDeclaration2Error : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "Type of {0} \'{1}\' cannot be inferred from an expression containing \'{1}\'";
        public UseLocalVariableBeforeDeclaration2Error(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.Resolve.IReference Reference { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class UseLocalVariableBeforeDeclarationError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "Cannot use {0} \'{1}\' before it is declared";
        public UseLocalVariableBeforeDeclarationError(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.Resolve.IReference Reference { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class UsingVariableIsNotDisposableError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "Cannot implicitly convert type \'{0}\' to \'System.IDisposable\'";
        public UsingVariableIsNotDisposableError(JetBrains.ReSharper.Psi.VB.Tree.IUsingVariableDeclaration declaration, JetBrains.ReSharper.Psi.IType variableType) { }
        public JetBrains.ReSharper.Psi.VB.Tree.IUsingVariableDeclaration Declaration { get; }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public JetBrains.ReSharper.Psi.IType VariableType { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class VariableExpectedError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "Variable name expected";
        public VariableExpectedError(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.Resolve.IReference Reference { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class VB11LanguageFeatureError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "Visual Basic 11.0 language feature";
        public VB11LanguageFeatureError(JetBrains.ReSharper.Psi.Tree.ITreeNode node) { }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.Tree.ITreeNode Node { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class WinRTArrayParameterBothDirectionsError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "WinRT parameters of array type cannot be both annotated with \'ReadOnlyArrayAttrib" +
            "ute\' and \'WriteOnlyArrayAttribute\' atributes";
        public WinRTArrayParameterBothDirectionsError(JetBrains.ReSharper.Psi.VB.Tree.IRegularParameterDeclaration declaration) { }
        public JetBrains.ReSharper.Psi.VB.Tree.IRegularParameterDeclaration Declaration { get; }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class WinRTArrayParameterNoDirectionError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "WinRT parameters of array type must be annotated with either \'ReadOnlyArrayAttrib" +
            "ute\' or \'WriteOnlyArrayAttribute\' attribute";
        public WinRTArrayParameterNoDirectionError(JetBrains.ReSharper.Psi.VB.Tree.IRegularParameterDeclaration declaration) { }
        public JetBrains.ReSharper.Psi.VB.Tree.IRegularParameterDeclaration Declaration { get; }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class WinRTArrayParameterOutReadOnlyError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "WinRT out parameters of array type cannot be annotated with \'ReadOnlyArrayAttribu" +
            "te\' since the contents of output arrays are writable";
        public WinRTArrayParameterOutReadOnlyError(JetBrains.ReSharper.Psi.VB.Tree.IRegularParameterDeclaration declaration) { }
        public JetBrains.ReSharper.Psi.VB.Tree.IRegularParameterDeclaration Declaration { get; }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class WinRTAsyncInfoInterfaceError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "Custom async operations are not supported, use AsyncInfoFactory instead";
        public WinRTAsyncInfoInterfaceError(JetBrains.ReSharper.Psi.VB.Tree.IDeclaredTypeUsage typeUsage, JetBrains.ReSharper.Psi.IInterface baseInterfaceType, JetBrains.ReSharper.Psi.VB.Tree.IClassLikeDeclaration currentTypeDeclaration) { }
        public JetBrains.ReSharper.Psi.IInterface BaseInterfaceType { get; }
        public JetBrains.ReSharper.Psi.VB.Tree.IClassLikeDeclaration CurrentTypeDeclaration { get; }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public JetBrains.ReSharper.Psi.VB.Tree.IDeclaredTypeUsage TypeUsage { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class WinRTCaseSensitiveNames2Error : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "{0} name \'{1}\' and {2} name \'{3}\' cannot differ in case only";
        public WinRTCaseSensitiveNames2Error(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration, JetBrains.ReSharper.Psi.IDeclaredElement conflictedElement) { }
        public JetBrains.ReSharper.Psi.IDeclaredElement ConflictedElement { get; }
        public JetBrains.ReSharper.Psi.Tree.IDeclaration Declaration { get; }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class WinRTConflictWithGeneratedError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "Type declaration has the same name as interface \'{0}\' generated for type \'{1}\'";
        public WinRTConflictWithGeneratedError(JetBrains.ReSharper.Psi.VB.Tree.IVBTypeDeclaration declaration, string name) { }
        public JetBrains.ReSharper.Psi.VB.Tree.IVBTypeDeclaration Declaration { get; }
        public string ErrorStripeToolTip { get; }
        public string Name { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class WinRTConstructorOutParameterError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "WinRT do not supports \'out\' parameters on constructors";
        public WinRTConstructorOutParameterError(JetBrains.ReSharper.Psi.VB.Tree.IRegularParameterDeclaration declaration) { }
        public JetBrains.ReSharper.Psi.VB.Tree.IRegularParameterDeclaration Declaration { get; }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class WinRTConstructorOverloadsError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "WinRT types cannot have multiple constructors with same number of arguments";
        public WinRTConstructorOverloadsError(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration) { }
        public JetBrains.ReSharper.Psi.Tree.IDeclaration Declaration { get; }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class WinRTConstructorReturnValueNameError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "The parameterized constructor has a parameter named \'value\' which is the same as " +
            "the default return value name. Consider using another name for the parameter";
        public WinRTConstructorReturnValueNameError(JetBrains.ReSharper.Psi.VB.Tree.IRegularParameterDeclaration declaration) { }
        public JetBrains.ReSharper.Psi.VB.Tree.IRegularParameterDeclaration Declaration { get; }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class WinRTEnumUnderlyingTypeError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "WinRT enumeration type should be backed by values of type \'Integer\' or \'UInteger\'" +
            "";
        public WinRTEnumUnderlyingTypeError(JetBrains.ReSharper.Psi.VB.Tree.IDeclaredTypeUsage typeUsage) { }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public JetBrains.ReSharper.Psi.VB.Tree.IDeclaredTypeUsage TypeUsage { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class WinRTExternalConstantError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "WinRT type cannot contain externally visible constants";
        public WinRTExternalConstantError(JetBrains.ReSharper.Psi.VB.Tree.IConstantDeclaration declaration) { }
        public JetBrains.ReSharper.Psi.VB.Tree.IConstantDeclaration Declaration { get; }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class WinRTExternalFieldError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "WinRT class cannot contain externally visible fields";
        public WinRTExternalFieldError(JetBrains.ReSharper.Psi.VB.Tree.IVariableDeclaration declaration) { }
        public JetBrains.ReSharper.Psi.VB.Tree.IVariableDeclaration Declaration { get; }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class WinRTExternalMethodError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "Attribute \'System.Runtime.InteropServices.PreserveSigAttribute\' is not supported " +
            "in WinRT";
        public WinRTExternalMethodError(JetBrains.ReSharper.Psi.VB.Tree.IExternalMethodDeclaration declaration) { }
        public JetBrains.ReSharper.Psi.VB.Tree.IExternalMethodDeclaration Declaration { get; }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class WinRTFieldInitializerInStructError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "Field in WinRT structure cannot have initializer";
        public WinRTFieldInitializerInStructError(JetBrains.ReSharper.Psi.VB.Tree.IVariableDeclaration declaration) { }
        public JetBrains.ReSharper.Psi.VB.Tree.IVariableDeclaration Declaration { get; }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class WinRTIndexerDeclarationError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "WinRT does not support properties with parameters";
        public WinRTIndexerDeclarationError(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration) { }
        public JetBrains.ReSharper.Psi.Tree.IDeclaration Declaration { get; }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class WinRTInheritanceIsNotAllowedError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "Implementation inheritance is not allowed in WinRT";
        public WinRTInheritanceIsNotAllowedError(JetBrains.ReSharper.Psi.VB.Tree.IDeclaredTypeUsage typeUsage, JetBrains.ReSharper.Psi.VB.Tree.IClassDeclaration currentClassDeclaration) { }
        public JetBrains.ReSharper.Psi.VB.Tree.IClassDeclaration CurrentClassDeclaration { get; }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public JetBrains.ReSharper.Psi.VB.Tree.IDeclaredTypeUsage TypeUsage { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class WinRTInternalInterfaceError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "Implementing friend interface is not allowed in WinRT";
        public WinRTInternalInterfaceError(JetBrains.ReSharper.Psi.VB.Tree.IDeclaredTypeUsage typeUsage, JetBrains.ReSharper.Psi.IInterface baseInterfaceType, JetBrains.ReSharper.Psi.VB.Tree.IClassLikeDeclaration currentTypeDeclaration) { }
        public JetBrains.ReSharper.Psi.IInterface BaseInterfaceType { get; }
        public JetBrains.ReSharper.Psi.VB.Tree.IClassLikeDeclaration CurrentTypeDeclaration { get; }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public JetBrains.ReSharper.Psi.VB.Tree.IDeclaredTypeUsage TypeUsage { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class WinRTInvalidFieldTypeError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "WinRT field cannot be of type \'{0}\'. Each field in a WinRT structure can only be " +
            "UInt8, Int16, UInt16, Int32, UInt32, Int64, UInt64, Single, Double, Boolean, Str" +
            "ing, Enum, Char, or itself a structure";
        public WinRTInvalidFieldTypeError(JetBrains.ReSharper.Psi.Tree.ITreeNode node, JetBrains.ReSharper.Psi.IType type) { }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.Tree.ITreeNode Node { get; }
        public string ToolTip { get; }
        public JetBrains.ReSharper.Psi.IType Type { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class WinRTInvalidReturnValueNameError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "Method has as invalid return value name";
        public WinRTInvalidReturnValueNameError(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration) { }
        public JetBrains.ReSharper.Psi.Tree.IDeclaration Declaration { get; }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class WinRTInvalidRootNamespaceError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "Namespace with public types should start with common prefix \'{0}\'";
        public WinRTInvalidRootNamespaceError(JetBrains.ReSharper.Psi.VB.Tree.IVBNamespaceDeclaration declaration, JetBrains.ReSharper.Psi.INamespace rootNamespace) { }
        public JetBrains.ReSharper.Psi.VB.Tree.IVBNamespaceDeclaration Declaration { get; }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.INamespace RootNamespace { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class WinRTInvalidTypeError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "Type \'{0}\' is not a valid WinRT type";
        public WinRTInvalidTypeError(JetBrains.ReSharper.Psi.Tree.ITreeNode node, JetBrains.ReSharper.Psi.IType type) { }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.Tree.ITreeNode Node { get; }
        public string ToolTip { get; }
        public JetBrains.ReSharper.Psi.IType Type { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class WinRTMemberIsVirtualError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "WinRT {0} cannot be \'Overridable\'";
        public WinRTMemberIsVirtualError(JetBrains.ReSharper.Psi.VB.Tree.IVBTypeMemberDeclaration declaration) { }
        public JetBrains.ReSharper.Psi.VB.Tree.IVBTypeMemberDeclaration Declaration { get; }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class WinRTMemberMultipleImplementsError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "{0} \'{1}\' implements more than one interface member. Please make sure this member" +
            " only implements one interface member";
        public WinRTMemberMultipleImplementsError(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration) { }
        public JetBrains.ReSharper.Psi.Tree.IDeclaration Declaration { get; }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class WinRTMethodIsGenericError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "WinRT method cannot be generic";
        public WinRTMethodIsGenericError(JetBrains.ReSharper.Psi.VB.Tree.IMethodDeclaration declaration) { }
        public JetBrains.ReSharper.Psi.VB.Tree.IMethodDeclaration Declaration { get; }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class WinRTMultipleDefaultFunctionsError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "Multiple {0} with the same number of parameters cannot be marked with \'DefaultOve" +
            "rloadAttribute\'";
        public WinRTMultipleDefaultFunctionsError(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration) { }
        public JetBrains.ReSharper.Psi.Tree.IDeclaration Declaration { get; }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class WinRTMultiRankArraysError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "Arrays in WinRT public API should be single-dimensional";
        public WinRTMultiRankArraysError(JetBrains.ReSharper.Psi.Tree.ITreeNode node) { }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.Tree.ITreeNode Node { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class WinRTNestedArraysError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "Arrays cannot be nested in WinRT public API";
        public WinRTNestedArraysError(JetBrains.ReSharper.Psi.Tree.ITreeNode node) { }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.Tree.ITreeNode Node { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class WinRTNestedTypeError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "WinRT type cannot be nested";
        public WinRTNestedTypeError(JetBrains.ReSharper.Psi.VB.Tree.IVBTypeDeclaration declaration) { }
        public JetBrains.ReSharper.Psi.VB.Tree.IVBTypeDeclaration Declaration { get; }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class WinRTNonWinRTInterfaceError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "WinRT types can only implement other WinRT interfaces";
        public WinRTNonWinRTInterfaceError(JetBrains.ReSharper.Psi.VB.Tree.IDeclaredTypeUsage typeUsage, JetBrains.ReSharper.Psi.IInterface baseInterfaceType, JetBrains.ReSharper.Psi.VB.Tree.IClassLikeDeclaration currentTypeDeclaration) { }
        public JetBrains.ReSharper.Psi.IInterface BaseInterfaceType { get; }
        public JetBrains.ReSharper.Psi.VB.Tree.IClassLikeDeclaration CurrentTypeDeclaration { get; }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public JetBrains.ReSharper.Psi.VB.Tree.IDeclaredTypeUsage TypeUsage { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class WinRTOperatorDeclarationError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "WinRT does not support operator overloads";
        public WinRTOperatorDeclarationError(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration) { }
        public JetBrains.ReSharper.Psi.Tree.IDeclaration Declaration { get; }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class WinRTOptionalParameterError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "WinRT method cannot have optional parameters";
        public WinRTOptionalParameterError(JetBrains.ReSharper.Psi.VB.Tree.IRegularParameterDeclaration declaration) { }
        public JetBrains.ReSharper.Psi.VB.Tree.IRegularParameterDeclaration Declaration { get; }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class WinRTParameterArrayError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "WinRT method cannot have parameter arrays";
        public WinRTParameterArrayError(JetBrains.ReSharper.Psi.VB.Tree.IRegularParameterDeclaration declaration) { }
        public JetBrains.ReSharper.Psi.VB.Tree.IRegularParameterDeclaration Declaration { get; }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class WinRTParametrizedEventError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "WinRT does not support events with parameters";
        public WinRTParametrizedEventError(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration) { }
        public JetBrains.ReSharper.Psi.Tree.IDeclaration Declaration { get; }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class WinRTPointerTypeError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "Pointer types are not allowed in WinRT public API";
        public WinRTPointerTypeError(JetBrains.ReSharper.Psi.Tree.ITreeNode node) { }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.Tree.ITreeNode Node { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class WinRTPropertyHasNoGetterError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "WinRT does not support setter-only properties";
        public WinRTPropertyHasNoGetterError(JetBrains.ReSharper.Psi.VB.Tree.IPropertyDeclaration declaration) { }
        public JetBrains.ReSharper.Psi.VB.Tree.IPropertyDeclaration Declaration { get; }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class WinRTProtectedConstructorError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "WinRT constructor cannot be protected";
        public WinRTProtectedConstructorError(JetBrains.ReSharper.Psi.VB.Tree.IConstructorDeclaration declaration) { }
        public JetBrains.ReSharper.Psi.VB.Tree.IConstructorDeclaration Declaration { get; }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class WinRTProtectedMemberIsStaticError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "WinRT shared {0} cannot be protected";
        public WinRTProtectedMemberIsStaticError(JetBrains.ReSharper.Psi.VB.Tree.IVBTypeMemberDeclaration declaration) { }
        public JetBrains.ReSharper.Psi.VB.Tree.IVBTypeMemberDeclaration Declaration { get; }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class WinRTRefParameterError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "WinRT method cannot have \'ByRef\' parameters";
        public WinRTRefParameterError(JetBrains.ReSharper.Psi.VB.Tree.IRegularParameterDeclaration declaration) { }
        public JetBrains.ReSharper.Psi.VB.Tree.IRegularParameterDeclaration Declaration { get; }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class WinRTReturnValueNameCollideError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "Method has the return value named \'{0}\' which is the same as a parameter name. Wi" +
            "nRT method parameters and return value must have unique names";
        public WinRTReturnValueNameCollideError(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration, string returnValueName) { }
        public JetBrains.ReSharper.Psi.Tree.IDeclaration Declaration { get; }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public string ReturnValueName { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class WinRTReturnValueNameDiffersError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "Method has return value name that differs from implemented interface method retur" +
            "n value name \'{0}\'. Please make sure that the names are identical";
        public WinRTReturnValueNameDiffersError(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration, string returnValueName) { }
        public JetBrains.ReSharper.Psi.Tree.IDeclaration Declaration { get; }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public string ReturnValueName { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class WinRTRootNamespaceDoesntExistsError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "All public types should belong to namespaces with a common prefix";
        public WinRTRootNamespaceDoesntExistsError(JetBrains.ReSharper.Psi.VB.Tree.IVBNamespaceDeclaration declaration) { }
        public JetBrains.ReSharper.Psi.VB.Tree.IVBNamespaceDeclaration Declaration { get; }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("VBWarnings::WME006", "VB", CompilerIds=new string[] {
            "WME006"}, CompilerIdsWithDescription="WME006:Namespace should be default namespace of this project", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class WinRTRootNamespaceShouldBeDefaultWarning : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        public const string HIGHLIGHTING_ID = "VBWarnings::WME006";
        protected const string MESSAGE = "Namespace \'{0}\' should be the default namespace of this project";
        public WinRTRootNamespaceShouldBeDefaultWarning(JetBrains.ReSharper.Psi.VB.Tree.IVBNamespaceDeclaration declaration, JetBrains.ReSharper.Psi.INamespace rootNamespace) { }
        public JetBrains.ReSharper.Psi.VB.Tree.IVBNamespaceDeclaration Declaration { get; }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.INamespace RootNamespace { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class WinRTSameOverloadsError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "Overloads with the same number of parameters are not allowed. Please mark one of " +
            "them with \'DefaultOverloadAttribute\'";
        public WinRTSameOverloadsError(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration) { }
        public JetBrains.ReSharper.Psi.Tree.IDeclaration Declaration { get; }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class WinRTShouldBeSealedError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "WinRT type should be \'NotInheritable\'";
        public WinRTShouldBeSealedError(JetBrains.ReSharper.Psi.VB.Tree.IClassDeclaration declaration) { }
        public JetBrains.ReSharper.Psi.VB.Tree.IClassDeclaration Declaration { get; }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class WinRTStaticInstanceNamesUniqueError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "WinRT type cannot contain both Shared and instance {0} with name \'{1}\'";
        public WinRTStaticInstanceNamesUniqueError(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration) { }
        public JetBrains.ReSharper.Psi.Tree.IDeclaration Declaration { get; }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class WinRTStructureContainsNotPublicFieldError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "WinRT structure may only contain public fields";
        public WinRTStructureContainsNotPublicFieldError(JetBrains.ReSharper.Psi.VB.Tree.IVBTypeMemberDeclaration declaration) { }
        public JetBrains.ReSharper.Psi.VB.Tree.IVBTypeMemberDeclaration Declaration { get; }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class WinRTStructureIsEmptyError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "WinRT structure should contain at least one public field";
        public WinRTStructureIsEmptyError(JetBrains.ReSharper.Psi.VB.Tree.IStructureDeclaration declaration) { }
        public JetBrains.ReSharper.Psi.VB.Tree.IStructureDeclaration Declaration { get; }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class WinRTTypeIsGenericError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "WinRT type cannot be generic";
        public WinRTTypeIsGenericError(JetBrains.ReSharper.Psi.VB.Tree.ITypeParameterOfTypeOwnerDeclaration declaration) { }
        public JetBrains.ReSharper.Psi.VB.Tree.ITypeParameterOfTypeOwnerDeclaration Declaration { get; }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class WinRTTypeWithoutNamespaceError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "All public types should belong to namespaces with a common prefix";
        public WinRTTypeWithoutNamespaceError(JetBrains.ReSharper.Psi.VB.Tree.IVBTypeDeclaration declaration) { }
        public JetBrains.ReSharper.Psi.VB.Tree.IVBTypeDeclaration Declaration { get; }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class WithEventsVariableHasWrongTypeError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "\'WithEvents\' variables can only be typed as classes, interfaces or type parameter" +
            "s with class constraints";
        public WithEventsVariableHasWrongTypeError(JetBrains.ReSharper.Psi.VB.Tree.IVariableDeclaration declaration) { }
        public JetBrains.ReSharper.Psi.VB.Tree.IVariableDeclaration Declaration { get; }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class WriteAccessToPropertyWithoutSetterError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "{0} \'{1}\' has no setter";
        public WriteAccessToPropertyWithoutSetterError(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.IProperty property) { }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.IProperty Property { get; }
        public JetBrains.ReSharper.Psi.Resolve.IReference Reference { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class WriteOnlyPropertyWithGetterError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "\'WriteOnly\' property must not have getter";
        public WriteOnlyPropertyWithGetterError(JetBrains.ReSharper.Psi.VB.Tree.IPropertyDeclaration propertyDeclaration, JetBrains.ReSharper.Psi.VB.Tree.IAccessorDeclaration accessorDeclaration) { }
        public JetBrains.ReSharper.Psi.VB.Tree.IAccessorDeclaration AccessorDeclaration { get; }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.VB.Tree.IPropertyDeclaration PropertyDeclaration { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class WriteOnlyPropertyWithoutSetterError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "\'WriteOnly\' property must provide setter";
        public WriteOnlyPropertyWithoutSetterError(JetBrains.ReSharper.Psi.VB.Tree.IPropertyDeclaration propertyDeclaration) { }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.VB.Tree.IPropertyDeclaration PropertyDeclaration { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class WrongConstantTypeError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "Constants must be of an intrinsic or enumerated type, not a class, structure, typ" +
            "e parameter, or array type";
        public WrongConstantTypeError(JetBrains.ReSharper.Psi.VB.Tree.ITypeUsage typeUsage, JetBrains.ReSharper.Psi.Tree.IDeclaration declaration) { }
        public JetBrains.ReSharper.Psi.Tree.IDeclaration Declaration { get; }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public JetBrains.ReSharper.Psi.VB.Tree.ITypeUsage TypeUsage { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class WrongReturnTypeOfAsyncLambdaError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "The Async lambda expression must either be Sub or Function that returns Task or T" +
            "ask(Of T)";
        public WrongReturnTypeOfAsyncLambdaError(JetBrains.ReSharper.Psi.VB.Tree.ILambdaExpression lambdaExpression) { }
        public string ErrorStripeToolTip { get; }
        public JetBrains.ReSharper.Psi.VB.Tree.ILambdaExpression LambdaExpression { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class WrongReturnTypeOfAsyncMethodError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "The Async method must either be Sub or Function that returns Task or Task(Of T)";
        public WrongReturnTypeOfAsyncMethodError(JetBrains.ReSharper.Psi.VB.Tree.IMethodDeclaration methodDeclaration) { }
        public string ErrorStripeToolTip { get; }
        public JetBrains.ReSharper.Psi.VB.Tree.IMethodDeclaration MethodDeclaration { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class WrongReturnTypeOfIteratorLambdaError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "The return type of an Iterator lambda expression must be IEnumerable(Of T), IEnum" +
            "erator(Of T), IEnumerable or IEnumerator";
        public WrongReturnTypeOfIteratorLambdaError(JetBrains.ReSharper.Psi.VB.Tree.ILambdaExpression lambdaExpression) { }
        public string ErrorStripeToolTip { get; }
        public JetBrains.ReSharper.Psi.VB.Tree.ILambdaExpression LambdaExpression { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class WrongReturnTypeOfIteratorMethodError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "The return type of an Iterator {0} must be IEnumerable(Of T), IEnumerator(Of T), " +
            "IEnumerable or IEnumerator";
        public WrongReturnTypeOfIteratorMethodError(JetBrains.ReSharper.Psi.VB.Tree.IVBFunctionDeclaration declaration, string name) { }
        public JetBrains.ReSharper.Psi.VB.Tree.IVBFunctionDeclaration Declaration { get; }
        public string ErrorStripeToolTip { get; }
        public string Name { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR, OverloadResolvePriority=10)]
    public class YieldCannotBeUsedInCatchFinallySyncLockError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "\'Yield\' cannot be used in a Try Catch or a Try Finally or a SyncLock";
        public YieldCannotBeUsedInCatchFinallySyncLockError(JetBrains.ReSharper.Psi.VB.Tree.IYieldStatement yieldStatement) { }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public JetBrains.ReSharper.Psi.VB.Tree.IYieldStatement YieldStatement { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR, OverloadResolvePriority=10)]
    public class YieldCannotBeUsedInQueryExpressionError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "\'Yield\' cannot currently be used in a LINQ query";
        public YieldCannotBeUsedInQueryExpressionError(JetBrains.ReSharper.Psi.VB.Tree.IYieldStatement yieldStatement) { }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public JetBrains.ReSharper.Psi.VB.Tree.IYieldStatement YieldStatement { get; }
        public override bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR, OverloadResolvePriority=10)]
    public class YieldStatementNotUnderIteratorMethodError : JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase, JetBrains.ReSharper.Daemon.Impl.IHighlightingWithRange
    {
        protected const string MESSAGE = "Yield can only be used in a method marked with the \'Iterator\' modifier";
        public YieldStatementNotUnderIteratorMethodError(JetBrains.ReSharper.Psi.VB.Tree.IYieldStatement yieldStatement) { }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public JetBrains.ReSharper.Psi.VB.Tree.IYieldStatement YieldStatement { get; }
        public override bool IsValid() { }
    }
}
namespace JetBrains.ReSharper.Daemon.VB.Stages.Analysis
{
    
    [JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzerAttribute(new System.Type[] {
            typeof(JetBrains.ReSharper.Psi.VB.Tree.IArrayModifier)})]
    public class ArrayBoundsCountAnalyzer : JetBrains.ReSharper.Daemon.Stages.Dispatcher.IElementProblemAnalyzer
    {
        public void Run(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzerData data, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer consumer) { }
    }
    [JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzerAttribute(new System.Type[] {
            typeof(JetBrains.ReSharper.Psi.VB.Tree.ILocalDeclarationList)}, HighlightingTypes=new System.Type[] {
            typeof(JetBrains.ReSharper.Daemon.VB.Errors.ArrayExceeds32DimensionsError),
            typeof(JetBrains.ReSharper.Daemon.VB.Errors.ExplicitInitializationForArrayWithExplicitBoundsError),
            typeof(JetBrains.ReSharper.Daemon.VB.Errors.ArrayModifiersSpecificationOnBothVariableAndItsTypeError),
            typeof(JetBrains.ReSharper.Daemon.VB.Errors.IncorrectArrayElementTypeError),
            typeof(JetBrains.ReSharper.Daemon.VB.Errors.ArrayInitializerExpectedError),
            typeof(JetBrains.ReSharper.Daemon.VB.Errors.ArrayInitializerSizeMismatchError),
            typeof(JetBrains.ReSharper.Daemon.VB.Errors.ArrayBoundSpecificationInTypeSpecifierError)})]
    public class ArrayDeclarationListAnalyzer : JetBrains.ReSharper.Daemon.Stages.Dispatcher.IElementProblemAnalyzer
    {
        public void Run(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzerData data, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer consumer) { }
    }
    [JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzerAttribute(new System.Type[] {
            typeof(JetBrains.ReSharper.Psi.VB.Tree.ILambdaParameterDeclaration)}, HighlightingTypes=new System.Type[] {
            typeof(JetBrains.ReSharper.Daemon.VB.Errors.ArrayBoundSpecificationInTypeSpecifierError)})]
    public class ArrayParameterInLambdaAnalyzer : JetBrains.ReSharper.Daemon.Stages.Dispatcher.IElementProblemAnalyzer
    {
        public void Run(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzerData data, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer consumer) { }
    }
    [JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzerAttribute(new System.Type[] {
            typeof(JetBrains.ReSharper.Psi.VB.Tree.IVariableDeclarationList)}, HighlightingTypes=new System.Type[] {
            typeof(JetBrains.ReSharper.Daemon.VB.Errors.ArrayExceeds32DimensionsError),
            typeof(JetBrains.ReSharper.Daemon.VB.Errors.ExplicitInitializationForArrayWithExplicitBoundsError),
            typeof(JetBrains.ReSharper.Daemon.VB.Errors.ArrayModifiersSpecificationOnBothVariableAndItsTypeError),
            typeof(JetBrains.ReSharper.Daemon.VB.Errors.IncorrectArrayElementTypeError),
            typeof(JetBrains.ReSharper.Daemon.VB.Errors.ArrayInitializerExpectedError),
            typeof(JetBrains.ReSharper.Daemon.VB.Errors.ArrayInitializerSizeMismatchError),
            typeof(JetBrains.ReSharper.Daemon.VB.Errors.ArrayBoundSpecificationInTypeSpecifierError)})]
    public class ArrayVariableDeclarationAnalyzer : JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzer<JetBrains.ReSharper.Psi.VB.Tree.IVariableDeclarationList>
    {
        protected override void Run(JetBrains.ReSharper.Psi.VB.Tree.IVariableDeclarationList variableDeclarationList, JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzerData data, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer consumer) { }
    }
    [JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzerAttribute(new System.Type[] {
            typeof(JetBrains.ReSharper.Psi.VB.Tree.IModifiersList)}, HighlightingTypes=new System.Type[] {
            typeof(JetBrains.ReSharper.Daemon.VB.Errors.AsyncModifierIsNotValidOnThisItemError),
            typeof(JetBrains.ReSharper.Daemon.VB.Errors.IteratorIsNotValidOnAutoImplementedPropertyError),
            typeof(JetBrains.ReSharper.Daemon.VB.Errors.IteratorModifierIsNotValidOnThisItemError),
            typeof(JetBrains.ReSharper.Daemon.VB.Errors.CannotUseBothAsyncAndIteratorModifiersError)})]
    public class AsyncAndIteratorModifierListProblemAnalyzer : JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzer<JetBrains.ReSharper.Psi.VB.Tree.IModifiersList>
    {
        protected override void Run(JetBrains.ReSharper.Psi.VB.Tree.IModifiersList element, JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzerData data, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer consumer) { }
    }
    [JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzerAttribute(new System.Type[] {
            typeof(JetBrains.ReSharper.Psi.VB.Tree.IInvocationStatement)}, HighlightingTypes=new System.Type[] {
            typeof(JetBrains.ReSharper.Daemon.VB.Errors.AsyncMethodInvocationWithoutAwaitWarning)})]
    public class AsyncMethodInvocationProblemAnalyzer : JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzer<JetBrains.ReSharper.Psi.VB.Tree.IInvocationStatement>
    {
        protected override void Run(JetBrains.ReSharper.Psi.VB.Tree.IInvocationStatement invocationStmt, JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzerData data, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer consumer) { }
    }
    [JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzerAttribute(new System.Type[] {
            typeof(JetBrains.ReSharper.Psi.VB.Tree.IMethodDeclaration)}, HighlightingTypes=new System.Type[] {
            typeof(JetBrains.ReSharper.Daemon.VB.Errors.WrongReturnTypeOfAsyncMethodError),
            typeof(JetBrains.ReSharper.Daemon.VB.Errors.AsyncMehodCannotHaveByRefParametersError),
            typeof(JetBrains.ReSharper.Daemon.VB.Errors.AsyncMethodWithoutAwaitWarning)})]
    public class AsyncMethodProblemAnalyzer : JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzer<JetBrains.ReSharper.Psi.VB.Tree.IMethodDeclaration>
    {
        protected override void Run(JetBrains.ReSharper.Psi.VB.Tree.IMethodDeclaration element, JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzerData data, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer consumer) { }
    }
    [Microsoft.VisualBasic.CompilerServices.StandardModuleAttribute()]
    public sealed class AsyncProblemAnalyzerUtil
    {
        public static bool HasAwaitExpression(JetBrains.ReSharper.Psi.VB.Tree.IVBTreeNode body) { }
        public static bool IsCorrectAsyncReturnType(JetBrains.ReSharper.Psi.IType returnType) { }
    }
    [JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzerAttribute(new System.Type[] {
            typeof(JetBrains.ReSharper.Psi.VB.Tree.IAwaitExpression)}, HighlightingTypes=new System.Type[] {
            typeof(JetBrains.ReSharper.Daemon.VB.Errors.AwaitExpressionNotUnderAsyncMethodError),
            typeof(JetBrains.ReSharper.Daemon.VB.Errors.AwaitCannotBeUsedInCatchFinallySyncLockError),
            typeof(JetBrains.ReSharper.Daemon.VB.Errors.AwaitCannotBeUsedInQueryExpressionError),
            typeof(JetBrains.ReSharper.Daemon.VB.Errors.CannotAwaitNothingError),
            typeof(JetBrains.ReSharper.Daemon.VB.Errors.ExpressionTypeIsNotAwaitableError)})]
    public class AwaitExpressionAnalyzer : JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzer<JetBrains.ReSharper.Psi.VB.Tree.IAwaitExpression>
    {
        protected override void Run(JetBrains.ReSharper.Psi.VB.Tree.IAwaitExpression awaitExpression, JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzerData data, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer consumer) { }
    }
    [JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzerAttribute(new System.Type[] {
            typeof(JetBrains.ReSharper.Psi.VB.Tree.IBlockIfStatement)}, HighlightingTypes=new System.Type[] {
            typeof(JetBrains.ReSharper.Daemon.VB.Errors.CanBeReplacedWithTryCastAndCheckForNullWarning)})]
    public class CheckedCastProblemAnalyzer : JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzer<JetBrains.ReSharper.Psi.VB.Tree.IBlockIfStatement>
    {
        protected override void Run(JetBrains.ReSharper.Psi.VB.Tree.IBlockIfStatement ifStatement, JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzerData data, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer consumer) { }
    }
    [JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzerAttribute(new System.Type[] {
            typeof(JetBrains.ReSharper.Psi.VB.Tree.IRelationalExpression)}, HighlightingTypes=new System.Type[] {
            typeof(JetBrains.ReSharper.Daemon.VB.Errors.CompareOfFloatsByEqualityOperatorWarning)})]
    public class CompareOfFloatsByEqualityOperatorAnalyzer : JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzer<JetBrains.ReSharper.Psi.VB.Tree.IRelationalExpression>
    {
        public static bool IsNaN(JetBrains.ReSharper.Psi.VB.Tree.IVBExpression expression) { }
        protected override void Run(JetBrains.ReSharper.Psi.VB.Tree.IRelationalExpression equalityExpression, JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzerData data, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer consumer) { }
        public enum IssueType
        {
            CONSTANT_OP_SOMETHING = 1,
            SOMETHING_OP_CONSTANT = 0,
            SOMETHING_OP_SOMETHING = 2,
        }
        public enum SuspiciousConstant
        {
            NEGATIVE_INFINITY = 3,
            NONE = 0,
            NOT_A_NUMBER = 1,
            POSITIVE_INFINITY = 2,
        }
    }
    [JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzerAttribute(new System.Type[] {
            typeof(JetBrains.ReSharper.Psi.VB.Tree.IConditionalExpression)}, HighlightingTypes=new System.Type[] {
            typeof(JetBrains.ReSharper.Daemon.VB.Errors.CannotDetermineTernaryExpressionType2Error),
            typeof(JetBrains.ReSharper.Daemon.VB.Errors.CannotDetermineTernaryExpressionTypeError)})]
    public class ConditionalNullCoalescingAnalyzer : JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzer<JetBrains.ReSharper.Psi.VB.Tree.IConditionalExpression>
    {
        protected override void Run(JetBrains.ReSharper.Psi.VB.Tree.IConditionalExpression expression, JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzerData data, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer consumer) { }
    }
    [JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzerAttribute(new System.Type[] {
            typeof(JetBrains.ReSharper.Psi.VB.Tree.IConditionalExpression)}, HighlightingTypes=new System.Type[] {
            typeof(JetBrains.ReSharper.Daemon.VB.Errors.ConditionalTernaryEqualBranchWarning),
            typeof(JetBrains.ReSharper.Daemon.VB.Errors.SimplifyConditionalOperatorWarning),
            typeof(JetBrains.ReSharper.Daemon.VB.Errors.CannotDetermineTernaryExpressionType2Error),
            typeof(JetBrains.ReSharper.Daemon.VB.Errors.CannotDetermineTernaryExpressionTypeError)})]
    public class ConditionalTernaryAnalyzer : JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzer<JetBrains.ReSharper.Psi.VB.Tree.IConditionalExpression>
    {
        public static System.Nullable<bool> GetBooleanLiteralValue(JetBrains.ReSharper.Psi.VB.Tree.IVBExpression expression) { }
        protected override void Run(JetBrains.ReSharper.Psi.VB.Tree.IConditionalExpression expression, JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzerData data, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer consumer) { }
    }
    [JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzerAttribute(new System.Type[] {
            typeof(JetBrains.ReSharper.Psi.VB.Tree.IBlockIfStatement)}, HighlightingTypes=new System.Type[] {
            typeof(JetBrains.ReSharper.Daemon.VB.Errors.ReadAccessInDoubleCheckLockingWarning),
            typeof(JetBrains.ReSharper.Daemon.VB.Errors.PossibleMultipleWriteAccessInDoubleCheckLockingWarning),
            typeof(JetBrains.ReSharper.Daemon.VB.Errors.NonVolatileFieldInDoubleCheckLockingWarning)})]
    public class DoubleCheckLockingProblemAnalyzer : JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzer<JetBrains.ReSharper.Psi.VB.Tree.IBlockIfStatement>
    {
        public DoubleCheckLockingProblemAnalyzer(JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Psi.Services.StructuralSearch.StructuralSearchEngine structuralSearchEngine) { }
        protected override void Run(JetBrains.ReSharper.Psi.VB.Tree.IBlockIfStatement ifStatement, JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzerData data, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer consumer) { }
    }
    [JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzerAttribute(new System.Type[] {
            typeof(JetBrains.ReSharper.Psi.VB.Tree.IIndexExpression)}, HighlightingTypes=new System.Type[] {
            typeof(JetBrains.ReSharper.Daemon.UsageChecking.SuspiciousCastWarning)})]
    public class EnumerableConversionInvocationProblemAnalyzer : JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzer<JetBrains.ReSharper.Psi.VB.Tree.IIndexExpression>
    {
        public static JetBrains.ReSharper.Psi.Resolve.ExtensionMethods.ExtensionInstance<JetBrains.ReSharper.Psi.IMethod> GetInvokedConversionMethod(JetBrains.ReSharper.Psi.VB.Tree.IIndexExpression expression, ref JetBrains.ReSharper.Psi.IType sourceType, ref JetBrains.ReSharper.Psi.IType targetType) { }
        protected override void Run(JetBrains.ReSharper.Psi.VB.Tree.IIndexExpression expression, JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzerData data, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer consumer) { }
    }
    [JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzerAttribute(new System.Type[] {
            typeof(JetBrains.ReSharper.Psi.VB.Tree.IRelationalExpression)}, HighlightingTypes=new System.Type[] {
            typeof(JetBrains.ReSharper.Daemon.VB.Errors.EqualExpressionComparisonWarning)})]
    public class EqualExpressionComparisonAnalyser : JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzer<JetBrains.ReSharper.Psi.VB.Tree.IRelationalExpression>
    {
        protected override void Run(JetBrains.ReSharper.Psi.VB.Tree.IRelationalExpression relationalExpression, JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzerData data, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer consumer) { }
    }
    [JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzerAttribute(new System.Type[] {
            typeof(JetBrains.ReSharper.Psi.VB.Tree.IIsExpression)}, HighlightingTypes=new System.Type[] {
            typeof(JetBrains.ReSharper.Daemon.VB.Errors.EqualExpressionComparisonWarning)})]
    public class EqualExpressionComparisonByIsAnalyser : JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzer<JetBrains.ReSharper.Psi.VB.Tree.IIsExpression>
    {
        protected override void Run(JetBrains.ReSharper.Psi.VB.Tree.IIsExpression isExpression, JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzerData data, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer consumer) { }
    }
    [JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzerAttribute(new System.Type[] {
            typeof(JetBrains.ReSharper.Psi.VB.Tree.IIsNotExpression)}, HighlightingTypes=new System.Type[] {
            typeof(JetBrains.ReSharper.Daemon.VB.Errors.EqualExpressionComparisonWarning)})]
    public class EqualExpressionComparisonByIsNotAnalyser : JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzer<JetBrains.ReSharper.Psi.VB.Tree.IIsNotExpression>
    {
        protected override void Run(JetBrains.ReSharper.Psi.VB.Tree.IIsNotExpression isNotExpression, JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzerData data, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer consumer) { }
    }
    public class EqualsMethodAnalyzer
    {
        public static JetBrains.ReSharper.Psi.IMethod GetEqualsInvocationArguments(JetBrains.ReSharper.Psi.VB.Tree.IIndexExpression invocationExpression, ref JetBrains.ReSharper.Psi.VB.Tree.IVBExpression arg0, ref JetBrains.ReSharper.Psi.VB.Tree.IVBExpression arg1) { }
    }
    [JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzerAttribute(new System.Type[] {
            typeof(JetBrains.ReSharper.Psi.VB.Tree.IForEachStatement)}, HighlightingTypes=new System.Type[] {
            typeof(JetBrains.ReSharper.Daemon.UsageChecking.SuspiciousCastWarning)})]
    public class ForEachStatementProblemAnalyzer : JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzer<JetBrains.ReSharper.Psi.VB.Tree.IForEachStatement>
    {
        protected override void Run(JetBrains.ReSharper.Psi.VB.Tree.IForEachStatement statement, JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzerData data, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer consumer) { }
    }
    [JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzerAttribute(new System.Type[] {
            typeof(JetBrains.ReSharper.Psi.VB.Tree.IIndexExpression)}, HighlightingTypes=new System.Type[] {
            typeof(JetBrains.ReSharper.Daemon.VB.Errors.ConditionalTernaryEqualBranchWarning),
            typeof(JetBrains.ReSharper.Daemon.VB.Errors.SimplifyIIfWarning),
            typeof(JetBrains.ReSharper.Daemon.VB.Errors.IIfEqualBranchWarning)})]
    public class IIfAnalyzer : JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzer<JetBrains.ReSharper.Psi.VB.Tree.IIndexExpression>
    {
        protected override void Run(JetBrains.ReSharper.Psi.VB.Tree.IIndexExpression expression, JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzerData data, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer consumer) { }
    }
    [JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzerAttribute(new System.Type[] {
            typeof(JetBrains.ReSharper.Psi.VB.Tree.IIsExpression),
            typeof(JetBrains.ReSharper.Psi.VB.Tree.IIsNotExpression)}, HighlightingTypes=new System.Type[] {
            typeof(JetBrains.ReSharper.Daemon.VB.Errors.IsExpressionOperandMustBeReferenceTypeError),
            typeof(JetBrains.ReSharper.Daemon.UsageChecking.SuspiciousComparisonWarning)})]
    public class IsExpressionProblemAnalyzer : JetBrains.ReSharper.Daemon.Stages.Dispatcher.IElementProblemAnalyzer
    {
        public void Run(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzerData data, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer consumer) { }
    }
    [JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzerAttribute(new System.Type[] {
            typeof(JetBrains.ReSharper.Psi.VB.Tree.IMethodDeclaration)}, HighlightingTypes=new System.Type[] {
            typeof(JetBrains.ReSharper.Daemon.VB.Errors.SubCannotBeIteratorMethodError),
            typeof(JetBrains.ReSharper.Daemon.VB.Errors.WrongReturnTypeOfIteratorMethodError),
            typeof(JetBrains.ReSharper.Daemon.VB.Errors.IteratorMethodCannotHaveByRefParametersError),
            typeof(JetBrains.ReSharper.Daemon.VB.Errors.IteratorMethodWithoutYieldWarning)})]
    public class IteratorMethodProblemAnalyzer : JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzer<JetBrains.ReSharper.Psi.VB.Tree.IMethodDeclaration>
    {
        protected override void Run(JetBrains.ReSharper.Psi.VB.Tree.IMethodDeclaration element, JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzerData data, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer consumer) { }
    }
    [Microsoft.VisualBasic.CompilerServices.StandardModuleAttribute()]
    public sealed class IteratorProblemAnalyzerUtil
    {
        public static bool HasYieldStatement(JetBrains.ReSharper.Psi.VB.Tree.IVBTreeNode body) { }
        public static bool IsCorrectIteratorReturnType(JetBrains.ReSharper.Psi.IType returnType) { }
    }
    [JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzerAttribute(new System.Type[] {
            typeof(JetBrains.ReSharper.Psi.VB.Tree.IPropertyDeclaration)}, HighlightingTypes=new System.Type[] {
            typeof(JetBrains.ReSharper.Daemon.VB.Errors.WrongReturnTypeOfIteratorMethodError),
            typeof(JetBrains.ReSharper.Daemon.VB.Errors.IteratorMethodWithoutYieldWarning)})]
    public class IteratorPropertyProblemAnalyzer : JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzer<JetBrains.ReSharper.Psi.VB.Tree.IPropertyDeclaration>
    {
        protected override void Run(JetBrains.ReSharper.Psi.VB.Tree.IPropertyDeclaration element, JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzerData data, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer consumer) { }
    }
    [JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzerAttribute(new System.Type[] {
            typeof(JetBrains.ReSharper.Psi.VB.Tree.ILambdaExpression)}, HighlightingTypes=new System.Type[] {
            typeof(JetBrains.ReSharper.Daemon.VB.Errors.CannotUseBothAsyncAndIteratorModifiersError),
            typeof(JetBrains.ReSharper.Daemon.VB.Errors.MultilineLambdaToExpressionTreeError),
            typeof(JetBrains.ReSharper.Daemon.VB.Errors.AsyncOrIteratorLambdaToExpressionTreeError),
            typeof(JetBrains.ReSharper.Daemon.VB.Errors.CannotInferReturnTypeError),
            typeof(JetBrains.ReSharper.Daemon.VB.Errors.AsyncMehodCannotHaveByRefParametersError),
            typeof(JetBrains.ReSharper.Daemon.VB.Errors.IteratorMethodCannotHaveByRefParametersError),
            typeof(JetBrains.ReSharper.Daemon.VB.Errors.WrongReturnTypeOfAsyncLambdaError),
            typeof(JetBrains.ReSharper.Daemon.VB.Errors.SubCannotBeIteratorMethodError),
            typeof(JetBrains.ReSharper.Daemon.VB.Errors.WrongReturnTypeOfIteratorLambdaError),
            typeof(JetBrains.ReSharper.Daemon.VB.Errors.AsyncMethodWithoutAwaitWarning),
            typeof(JetBrains.ReSharper.Daemon.VB.Errors.IteratorMethodWithoutYieldWarning)})]
    public class LambdaExpressionAnalyzer : JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzer<JetBrains.ReSharper.Psi.VB.Tree.ILambdaExpression>
    {
        protected override void Run(JetBrains.ReSharper.Psi.VB.Tree.ILambdaExpression lambdaExpression, JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzerData data, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer consumer) { }
    }
    [JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzerAttribute(new System.Type[] {
            typeof(JetBrains.ReSharper.Psi.VB.Tree.IVBLiteralExpression)}, HighlightingTypes=new System.Type[] {
            typeof(JetBrains.ReSharper.Daemon.VB.Errors.LongLiteralEndingLowerLWarning)})]
    public class LongLiteralEndingLowerLProblemAnalyzer : JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzer<JetBrains.ReSharper.Psi.VB.Tree.IVBLiteralExpression>
    {
        protected override void Run(JetBrains.ReSharper.Psi.VB.Tree.IVBLiteralExpression literalExpression, JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzerData data, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer consumer) { }
    }
    [JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzerAttribute(new System.Type[] {
            typeof(JetBrains.ReSharper.Psi.VB.Tree.IIsExpression)}, HighlightingTypes=new System.Type[] {
            typeof(JetBrains.ReSharper.Daemon.VB.Errors.OperatorIsCanBeUsedWarning)})]
    public class MethodGetTypeEqualsOperatorGetTypeProblemAnalyzer : JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzer<JetBrains.ReSharper.Psi.VB.Tree.IIsExpression>
    {
        public MethodGetTypeEqualsOperatorGetTypeProblemAnalyzer(JetBrains.ReSharper.Psi.Services.StructuralSearch.StructuralSearchEngine engine, JetBrains.ProjectModel.ISolution solution) { }
        protected override void Run(JetBrains.ReSharper.Psi.VB.Tree.IIsExpression expression, JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzerData data, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer consumer) { }
    }
    [JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzerAttribute(new System.Type[] {
            typeof(JetBrains.ReSharper.Psi.VB.Tree.IMidAssignmentStatement)}, HighlightingTypes=new System.Type[] {
            typeof(JetBrains.ReSharper.Daemon.VB.Errors.InvalidCastError)})]
    public class MidAssignmentAnalyzer : JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzer<JetBrains.ReSharper.Psi.VB.Tree.IMidAssignmentStatement>
    {
        protected override void Run(JetBrains.ReSharper.Psi.VB.Tree.IMidAssignmentStatement element, JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzerData data, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer consumer) { }
    }
    [JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzerAttribute(new System.Type[] {
            typeof(JetBrains.ReSharper.Psi.VB.Tree.IThrowStatement)}, HighlightingTypes=new System.Type[] {
            typeof(JetBrains.ReSharper.Daemon.VB.Errors.PossibleIntendedRethrowWarning)})]
    public class PossibleIntendedRethrowAnalyzer : JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzer<JetBrains.ReSharper.Psi.VB.Tree.IThrowStatement>
    {
        protected override void Run(JetBrains.ReSharper.Psi.VB.Tree.IThrowStatement throwStatement, JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzerData data, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer consumer) { }
    }
    [JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzerAttribute(new System.Type[] {
            typeof(JetBrains.ReSharper.Psi.VB.Tree.IExpressionRangeVariableDeclaration)}, HighlightingTypes=new System.Type[] {
            typeof(JetBrains.ReSharper.Daemon.VB.Errors.ExpressionRangeVariableDeclarationWithExplicitTypeError)})]
    public class QueryExpressionRangeProblemAnalyzer : JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzer<JetBrains.ReSharper.Psi.VB.Tree.IExpressionRangeVariableDeclaration>
    {
        protected override void Run(JetBrains.ReSharper.Psi.VB.Tree.IExpressionRangeVariableDeclaration exprRangeVariableDeclaration, JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzerData data, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer consumer) { }
    }
    [JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzerAttribute(new System.Type[] {
            typeof(JetBrains.ReSharper.Psi.VB.Tree.ICaseStatement)})]
    public class RedundandEmptyCaseElseAnalyzer : JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzer<JetBrains.ReSharper.Psi.VB.Tree.ICaseStatement>
    {
        protected override void Run(JetBrains.ReSharper.Psi.VB.Tree.ICaseStatement caseStatement, JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzerData data, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer consumer) { }
    }
    [JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzerAttribute(new System.Type[] {
            typeof(JetBrains.ReSharper.Psi.VB.Tree.IVBBinaryExpression)}, HighlightingTypes=new System.Type[] {
            typeof(JetBrains.ReSharper.Daemon.VB.Errors.RedundantLogicalConditionalExpressionOperandWarning)})]
    public class RedundantLogicalOperandAnalyzer : JetBrains.ReSharper.Daemon.Stages.Dispatcher.IElementProblemAnalyzer
    {
        public void Run(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzerData data, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer consumer) { }
    }
    [JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzerAttribute(new System.Type[] {
            typeof(JetBrains.ReSharper.Psi.VB.Tree.IReferenceExpression)}, HighlightingTypes=new System.Type[] {
            typeof(JetBrains.ReSharper.Daemon.VB.Errors.NonReadonlyFieldInGetHashCodeWarning),
            typeof(JetBrains.ReSharper.Daemon.VB.Errors.BaseObjectGetHashCodeCallInGetHashCodeWarning)})]
    public class ReferenceInGetHashCodeProblemAnalyzer : JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzer<JetBrains.ReSharper.Psi.VB.Tree.IReferenceExpression>
    {
        protected override void Run(JetBrains.ReSharper.Psi.VB.Tree.IReferenceExpression referenceExpression, JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzerData data, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer consumer) { }
    }
    [JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzerAttribute(new System.Type[] {
            typeof(JetBrains.ReSharper.Psi.VB.Tree.IVBExpression)}, HighlightingTypes=new System.Type[] {
            typeof(JetBrains.ReSharper.Daemon.VB.Errors.SpecifyStringComparisonWarning)})]
    public class SpecifyStringComparisonAnalyzer : JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzer<JetBrains.ReSharper.Psi.VB.Tree.IVBExpression>
    {
        public SpecifyStringComparisonAnalyzer(JetBrains.ReSharper.Daemon.VB.Stages.Analysis.SpecifyStringComparisonAnalyzer.Matchers matchers) { }
        protected override void Run(JetBrains.ReSharper.Psi.VB.Tree.IVBExpression element, JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzerData data, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer consumer) { }
        [JetBrains.ReSharper.Psi.PsiSharedComponentAttribute()]
        public class Matchers
        {
            public Matchers(JetBrains.ReSharper.Psi.Services.StructuralSearch.StructuralSearchEngine ssrEngine, JetBrains.ReSharper.Psi.ILanguageManager languageManager) { }
            public JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralMatcher ToLower { get; set; }
            public JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralMatcher ToLowerInvariant { get; set; }
            public JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralMatcher ToUpper { get; set; }
            public JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralMatcher ToUpperInvariant { get; set; }
            public bool EnsureCreatedIfAvailable() { }
        }
    }
    [JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzerAttribute(new System.Type[] {
            typeof(JetBrains.ReSharper.Psi.VB.Tree.IVariableDeclaration)}, HighlightingTypes=new System.Type[] {
            typeof(JetBrains.ReSharper.Daemon.VB.Errors.StaticFieldInGenericTypeWarning)})]
    public class StaticFieCodeSmellsldsInGenericTypeProblemAnalyzer : JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzer<JetBrains.ReSharper.Psi.VB.Tree.IVariableDeclaration>
    {
        protected override void Run(JetBrains.ReSharper.Psi.VB.Tree.IVariableDeclaration variableDeclaration, JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzerData data, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer consumer) { }
    }
    [JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzerAttribute(new System.Type[] {
            typeof(JetBrains.ReSharper.Psi.VB.Tree.IVariableDeclarationList)})]
    public class StaticFieldInitializationOrderAnalyzer : JetBrains.ReSharper.Daemon.Stages.Dispatcher.IElementProblemAnalyzer
    {
        public void Run(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzerData data, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer consumer) { }
    }
    [JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzerAttribute(new System.Type[] {
            typeof(JetBrains.ReSharper.Psi.VB.Tree.IVariableDeclaration)}, HighlightingTypes=new System.Type[] {
            typeof(JetBrains.ReSharper.Daemon.VB.Errors.ThreadStaticAtInstanceFieldWarning),
            typeof(JetBrains.ReSharper.Daemon.VB.Errors.ThreadStaticFieldHasInitializerWarning)})]
    public class ThreadStaticProblemAnalyzer : JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzer<JetBrains.ReSharper.Psi.VB.Tree.IVariableDeclaration>
    {
        protected override void Run(JetBrains.ReSharper.Psi.VB.Tree.IVariableDeclaration fieldDeclaration, JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzerData data, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer consumer) { }
    }
    [JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzerAttribute(new System.Type[] {
            typeof(JetBrains.ReSharper.Psi.VB.Tree.ITryStatement)}, HighlightingTypes=new System.Type[] {
            typeof(JetBrains.ReSharper.Daemon.VB.Errors.TryStatementsCanBeMergedWarning)})]
    public class TryStatementProblemAnalyzer : JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzer<JetBrains.ReSharper.Psi.VB.Tree.ITryStatement>
    {
        protected override void Run(JetBrains.ReSharper.Psi.VB.Tree.ITryStatement tryStatement, JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzerData data, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer consumer) { }
    }
    [JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzerAttribute(new System.Type[] {
            typeof(JetBrains.ReSharper.Psi.VB.Tree.ITypeOfIsExpression)}, HighlightingTypes=new System.Type[] {
            typeof(JetBrains.ReSharper.Daemon.UsageChecking.SuspiciousTypeCheckWarning)})]
    public class TypeofIsExpressionAnalyzer : JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzer<JetBrains.ReSharper.Psi.VB.Tree.ITypeOfIsExpression>
    {
        protected override void Run(JetBrains.ReSharper.Psi.VB.Tree.ITypeOfIsExpression element, JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzerData data, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer consumer) { }
    }
    [JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzerAttribute(new System.Type[] {
            typeof(JetBrains.ReSharper.Psi.VB.Tree.IClassBaseClause)}, HighlightingTypes=new System.Type[] {
            typeof(JetBrains.ReSharper.Daemon.VB.Errors.ClassShouldInheritClassError),
            typeof(JetBrains.ReSharper.Daemon.VB.Errors.ClassCannotInheritSealedClassError)})]
    public class VBBaseClauseAnalyzer : JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzer<JetBrains.ReSharper.Psi.VB.Tree.IClassBaseClause>
    {
        protected override void Run(JetBrains.ReSharper.Psi.VB.Tree.IClassBaseClause element, JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzerData data, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer consumer) { }
    }
    [JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzerAttribute(new System.Type[] {
            typeof(JetBrains.ReSharper.Psi.VB.Tree.ICastExpression)}, HighlightingTypes=new System.Type[] {
            typeof(JetBrains.ReSharper.Daemon.VB.Errors.InvalidCastError),
            typeof(JetBrains.ReSharper.Daemon.VB.Errors.TryCastWithValueTypeError),
            typeof(JetBrains.ReSharper.Daemon.VB.Errors.TryCastWithGenericTypeWithoutClassError),
            typeof(JetBrains.ReSharper.Daemon.VB.Errors.RedundantDirectCastWithValueTypeWarning),
            typeof(JetBrains.ReSharper.Daemon.VB.Errors.RedundantCastWarning),
            typeof(JetBrains.ReSharper.Daemon.UsageChecking.SuspiciousCastWarning)})]
    public class VBCastExpressionAnalyzer : JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzer<JetBrains.ReSharper.Psi.VB.Tree.ICastExpression>
    {
        protected override void Run(JetBrains.ReSharper.Psi.VB.Tree.ICastExpression element, JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzerData data, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer consumer) { }
    }
    public abstract class VBClassInheritanceProblemAnalyzerBase
    {
        protected readonly JetBrains.Util.OneToListMap<JetBrains.ReSharper.Psi.OverridableMemberInstance, JetBrains.ReSharper.Psi.IOverridableMember> myImplementedSuperMembers;
        protected readonly JetBrains.Util.OneToListMap<JetBrains.ReSharper.Psi.OverridableMemberInstance, JetBrains.ReSharper.Psi.IOverridableMember> myOverridenSuperMembers;
        protected readonly JetBrains.Util.OneToListMap<string, JetBrains.ReSharper.Psi.TypeMemberInstance> mySuperClassMembers;
        protected readonly JetBrains.Util.OneToSetMap<string, JetBrains.ReSharper.Psi.OverridableMemberInstance> mySuperInterfaceMembers;
        public VBClassInheritanceProblemAnalyzerBase(JetBrains.ReSharper.Psi.VB.Tree.IClassLikeDeclaration typeDeclaration) { }
        protected abstract void AddHighlighting(JetBrains.ReSharper.Daemon.VB.Stages.VBHighlightingBase highlighting);
        protected abstract void AddHighlighting(JetBrains.ReSharper.Daemon.IHighlighting highlighting, JetBrains.DocumentModel.DocumentRange range);
        public void Run() { }
    }
    [JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzerAttribute(new System.Type[] {
            typeof(JetBrains.ReSharper.Psi.VB.Tree.IConditionalExpression)}, HighlightingTypes=new System.Type[] {
            typeof(JetBrains.ReSharper.Daemon.VB.Errors.ConditionalExpressionWrongArgsNumberError),
            typeof(JetBrains.ReSharper.Daemon.VB.Errors.ConditionalExpressionArgIsNotBoolError)})]
    public class VBConditionalExpressionAnalyzer : JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzer<JetBrains.ReSharper.Psi.VB.Tree.IConditionalExpression>
    {
        protected override void Run(JetBrains.ReSharper.Psi.VB.Tree.IConditionalExpression element, JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzerData data, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer consumer) { }
    }
    [JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzerAttribute(new System.Type[] {
            typeof(JetBrains.ReSharper.Psi.VB.Tree.IConstantDeclaration)}, HighlightingTypes=new System.Type[] {
            typeof(JetBrains.ReSharper.Daemon.VB.Errors.ConstantInitializerMustBeConstantError),
            typeof(JetBrains.ReSharper.Daemon.VB.Errors.WrongConstantTypeError),
            typeof(JetBrains.ReSharper.Daemon.VB.Errors.ConstantMustHaveInitializerError)})]
    public class VBConstantDeclarationAnalyzer : JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzer<JetBrains.ReSharper.Psi.VB.Tree.IConstantDeclaration>
    {
        public static bool IsGoodConstantType(JetBrains.ReSharper.Psi.IType type) { }
        protected override void Run(JetBrains.ReSharper.Psi.VB.Tree.IConstantDeclaration element, JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzerData data, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer consumer) { }
    }
    [JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzerAttribute(new System.Type[] {
            typeof(JetBrains.ReSharper.Psi.VB.Tree.IIndexExpression)}, HighlightingTypes=new System.Type[] {
            typeof(JetBrains.ReSharper.Daemon.VB.Errors.EqualExpressionComparisonWarning),
            typeof(JetBrains.ReSharper.Daemon.VB.Errors.BaseObjectEqualsIsObjectEqualsWarning),
            typeof(JetBrains.ReSharper.Daemon.UsageChecking.SuspiciousComparisonWarning)})]
    public class VBEqualsMethodAnalyzer : JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzer<JetBrains.ReSharper.Psi.VB.Tree.IIndexExpression>
    {
        protected override void Run(JetBrains.ReSharper.Psi.VB.Tree.IIndexExpression indexExpression, JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzerData data, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer consumer) { }
    }
    [JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzerAttribute(new System.Type[] {
            typeof(JetBrains.ReSharper.Psi.VB.Tree.IEventDeclaration)}, HighlightingTypes=new System.Type[] {
            typeof(JetBrains.ReSharper.Daemon.VB.Errors.EventMustHaveDelegateTypeError),
            typeof(JetBrains.ReSharper.Daemon.VB.Errors.EventTypeMustReturnVoidError)})]
    public class VBEventDeclarationAnalyzer : JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzer<JetBrains.ReSharper.Psi.VB.Tree.IEventDeclaration>
    {
        protected override void Run(JetBrains.ReSharper.Psi.VB.Tree.IEventDeclaration element, JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzerData data, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer consumer) { }
    }
    [JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzerAttribute(new System.Type[] {
            typeof(JetBrains.ReSharper.Psi.VB.Tree.IReferenceExpression)}, HighlightingTypes=new System.Type[] {
            typeof(JetBrains.ReSharper.Daemon.VB.Errors.ImpureMethodCallOnReadonlyValueFieldWarning)})]
    public class VBImpureMethodCallForReadonlyStructFieldAnalyzer : JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzer<JetBrains.ReSharper.Psi.VB.Tree.IReferenceExpression>
    {
        public VBImpureMethodCallForReadonlyStructFieldAnalyzer(JetBrains.ReSharper.Psi.CodeAnnotations.CodeAnnotationsCache annotationCache) { }
        protected override void Run(JetBrains.ReSharper.Psi.VB.Tree.IReferenceExpression element, JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzerData data, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer consumer) { }
    }
    [JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzerAttribute(new System.Type[] {
            typeof(JetBrains.ReSharper.Psi.VB.Tree.IMethodDeclaration),
            typeof(JetBrains.ReSharper.Psi.Tree.IParameterDeclaration),
            typeof(JetBrains.ReSharper.Psi.VB.Tree.IVariableDeclaration),
            typeof(JetBrains.ReSharper.Psi.VB.Tree.IPropertyDeclaration),
            typeof(JetBrains.ReSharper.Psi.VB.Tree.IOperatorDeclaration)}, HighlightingTypes=new System.Type[] {
            typeof(JetBrains.ReSharper.Daemon.VB.Errors.AnnotationRedundanceInHierarchyWarning),
            typeof(JetBrains.ReSharper.Daemon.VB.Errors.AnnotationConflictInHierarchyWarning),
            typeof(JetBrains.ReSharper.Daemon.VB.Errors.AnnotationRedundanceAtValueTypeWarning),
            typeof(JetBrains.ReSharper.Daemon.VB.Errors.MultipleNullableAttributesUsageWarning)})]
    public class VBIncorrectNullableAttributeUsageAnalyzer : JetBrains.ReSharper.Daemon.Stages.Dispatcher.IElementProblemAnalyzer
    {
        public VBIncorrectNullableAttributeUsageAnalyzer(JetBrains.ReSharper.Psi.CodeAnnotations.CodeAnnotationsCache codeAnnotationsCache) { }
        public void Run(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzerData data, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer consumer) { }
    }
    [JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzerAttribute(new System.Type[] {
            typeof(JetBrains.ReSharper.Psi.VB.Tree.IInterfaceInheritsClause)}, HighlightingTypes=new System.Type[] {
            typeof(JetBrains.ReSharper.Daemon.VB.Errors.InterfaceInheritsKeywordWithNotInterfaceError),
            typeof(JetBrains.ReSharper.Daemon.VB.Errors.InterfaceCannotInheritNestedError),
            typeof(JetBrains.ReSharper.Daemon.VB.Errors.DuplicateInterfaceInImplementsListError)})]
    public class VBInterfaceInheritsClauseAnalyzer : JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzer<JetBrains.ReSharper.Psi.VB.Tree.IInterfaceInheritsClause>
    {
        protected override void Run(JetBrains.ReSharper.Psi.VB.Tree.IInterfaceInheritsClause element, JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzerData data, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer consumer) { }
    }
    [JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzerAttribute(new System.Type[] {
            typeof(JetBrains.ReSharper.Psi.VB.Tree.IInvocationStatement)}, HighlightingTypes=new System.Type[] {
            typeof(JetBrains.ReSharper.Daemon.VB.Errors.InvalidInvocationStatementExpressionError),
            typeof(JetBrains.ReSharper.Daemon.VB.Errors.InvalidInvocationStatementStartExpressionError)})]
    public class VBInvocationStatementAnalyzer : JetBrains.ReSharper.Daemon.Stages.Dispatcher.IElementProblemAnalyzer
    {
        public static bool NeedCallKeyword(JetBrains.ReSharper.Psi.VB.Tree.IVBExpression expression) { }
        public void Run(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzerData data, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer consumer) { }
    }
    [JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzerAttribute(new System.Type[] {
            typeof(JetBrains.ReSharper.Psi.VB.Tree.ILocalVariableDeclaration)}, HighlightingTypes=new System.Type[] {
            typeof(JetBrains.ReSharper.Daemon.VB.Errors.ConstantInitializerMustBeConstantError),
            typeof(JetBrains.ReSharper.Daemon.VB.Errors.WrongConstantTypeError),
            typeof(JetBrains.ReSharper.Daemon.VB.Errors.ConstantMustHaveInitializerError)})]
    public class VBLocalConstantDeclarationAnalyzer : JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzer<JetBrains.ReSharper.Psi.VB.Tree.ILocalVariableDeclaration>
    {
        protected override void Run(JetBrains.ReSharper.Psi.VB.Tree.ILocalVariableDeclaration element, JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzerData data, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer consumer) { }
    }
    [JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzerAttribute(new System.Type[] {
            typeof(JetBrains.ReSharper.Psi.VB.Tree.IVBModifiersOwnerDeclaration)}, HighlightingTypes=new System.Type[] {
            typeof(JetBrains.ReSharper.Daemon.VB.Errors.InvalidModifierAndAccessRightCombinationError)})]
    public class VBModifiersProblemAnalyzer : JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzer<JetBrains.ReSharper.Psi.VB.Tree.IVBModifiersOwnerDeclaration>
    {
        protected override void Run(JetBrains.ReSharper.Psi.VB.Tree.IVBModifiersOwnerDeclaration element, JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzerData data, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer consumer) { }
    }
    [JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzerAttribute(new System.Type[] {
            typeof(JetBrains.ReSharper.Psi.VB.Tree.IMethodDeclarationBase)}, HighlightingTypes=new System.Type[] {
            typeof(JetBrains.ReSharper.Daemon.VB.Errors.PureAttributeOnVoidMethodWarning)})]
    public class VBPureAnnotationProblemAnalyzer : JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzer<JetBrains.ReSharper.Psi.VB.Tree.IMethodDeclarationBase>
    {
        public VBPureAnnotationProblemAnalyzer(JetBrains.ReSharper.Psi.CodeAnnotations.CodeAnnotationsCache codeAnnotationsCache) { }
        protected override void Run(JetBrains.ReSharper.Psi.VB.Tree.IMethodDeclarationBase element, JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzerData data, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer consumer) { }
    }
    [JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzerAttribute(new System.Type[] {
            typeof(JetBrains.ReSharper.Psi.VB.Tree.IInvocationStatement)}, HighlightingTypes=new System.Type[] {
            typeof(JetBrains.ReSharper.Daemon.VB.Errors.ReturnValueOfPureMethodIsNotUsedWarning)})]
    public class VBPureMethodCallProblemAnalyzer : JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzer<JetBrains.ReSharper.Psi.VB.Tree.IInvocationStatement>
    {
        public VBPureMethodCallProblemAnalyzer(JetBrains.ReSharper.Psi.CodeAnnotations.CodeAnnotationsCache annotationCache) { }
        protected override void Run(JetBrains.ReSharper.Psi.VB.Tree.IInvocationStatement element, JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzerData data, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer consumer) { }
    }
    [JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzerAttribute(new System.Type[] {
            typeof(JetBrains.ReSharper.Psi.VB.Tree.IReferenceExpression)})]
    public class VBReadWriteAccessAnalyzer : JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzer<JetBrains.ReSharper.Psi.VB.Tree.IReferenceExpression>
    {
        protected override void Run(JetBrains.ReSharper.Psi.VB.Tree.IReferenceExpression referenceExpression, JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzerData data, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer consumer) { }
    }
    [JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzerAttribute(new System.Type[] {
            typeof(JetBrains.ReSharper.Psi.VB.Tree.IIndexExpression)}, HighlightingTypes=new System.Type[] {
            typeof(JetBrains.ReSharper.Daemon.VB.Errors.ConditionIsAlwaysTrueOrFalseWarning),
            typeof(JetBrains.ReSharper.Daemon.VB.Errors.ReferenceEqualsWithValueTypeWarning),
            typeof(JetBrains.ReSharper.Daemon.VB.Errors.EqualExpressionComparisonWarning),
            typeof(JetBrains.ReSharper.Daemon.VB.Errors.ConditionIsAlwaysTrueOrFalseWarning),
            typeof(JetBrains.ReSharper.Daemon.UsageChecking.SuspiciousComparisonWarning)})]
    public class VBReferenceEqualsMethodAnalyzer : JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzer<JetBrains.ReSharper.Psi.VB.Tree.IIndexExpression>
    {
        protected override void Run(JetBrains.ReSharper.Psi.VB.Tree.IIndexExpression indexExpression, JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzerData data, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer consumer) { }
    }
    [JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzerAttribute(new System.Type[] {
            typeof(JetBrains.ReSharper.Psi.VB.Tree.ITypeImplementsClause)}, HighlightingTypes=new System.Type[] {
            typeof(JetBrains.ReSharper.Daemon.VB.Errors.ImplementKeywordWithNotInterfaceError),
            typeof(JetBrains.ReSharper.Daemon.VB.Errors.DuplicateInterfaceInImplementsListError)})]
    public class VBTypeImplementsClauseAnalyzer : JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzer<JetBrains.ReSharper.Psi.VB.Tree.ITypeImplementsClause>
    {
        protected override void Run(JetBrains.ReSharper.Psi.VB.Tree.ITypeImplementsClause element, JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzerData data, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer consumer) { }
    }
    [JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzerAttribute(new System.Type[] {
            typeof(JetBrains.ReSharper.Psi.VB.Tree.IInstanceExpression)}, HighlightingTypes=new System.Type[] {
            typeof(JetBrains.ReSharper.Daemon.VB.Errors.AssignmentToMeError),
            typeof(JetBrains.ReSharper.Daemon.VB.Errors.PossibleWriteToMeWarning)})]
    public class WriteToInstanceExpressionAnalyzer : JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzer<JetBrains.ReSharper.Psi.VB.Tree.IInstanceExpression>
    {
        protected override void Run(JetBrains.ReSharper.Psi.VB.Tree.IInstanceExpression instanceExpression, JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzerData data, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer consumer) { }
    }
    [JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzerAttribute(new System.Type[] {
            typeof(JetBrains.ReSharper.Psi.VB.Tree.IYieldStatement)}, HighlightingTypes=new System.Type[] {
            typeof(JetBrains.ReSharper.Daemon.VB.Errors.CannotConvertTypeInYieldError),
            typeof(JetBrains.ReSharper.Daemon.VB.Errors.CannotConvertTypeInYieldWarning),
            typeof(JetBrains.ReSharper.Daemon.VB.Errors.ImpossibleConvertTypeInYieldWarning),
            typeof(JetBrains.ReSharper.Daemon.VB.Errors.YieldStatementNotUnderIteratorMethodError),
            typeof(JetBrains.ReSharper.Daemon.VB.Errors.YieldCannotBeUsedInCatchFinallySyncLockError),
            typeof(JetBrains.ReSharper.Daemon.VB.Errors.YieldCannotBeUsedInQueryExpressionError)})]
    public class YieldStatementAnalyzer : JetBrains.ReSharper.Daemon.VB.Stages.Analysis.TypeCheck.TypeCheckAnalyzer, JetBrains.ReSharper.Daemon.Stages.Dispatcher.IElementProblemAnalyzer
    {
        public void Run(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzerData data, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer consumer) { }
        protected void Run(JetBrains.ReSharper.Psi.VB.Tree.IYieldStatement yieldStatement, JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzerData data, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer consumer) { }
    }
}
namespace JetBrains.ReSharper.Daemon.VB.Stages.Analysis.ArrayCreation
{
    
    [JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzerAttribute(new System.Type[] {
            typeof(JetBrains.ReSharper.Psi.VB.Tree.IAnonymousArrayCreationExpression)}, HighlightingTypes=new System.Type[] {
            typeof(JetBrains.ReSharper.Daemon.VB.Errors.CannotInferElementTypeOfAnonymousArrayError)})]
    public class AnonymousArrayCreationAnalyzer : JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzer<JetBrains.ReSharper.Psi.VB.Tree.IAnonymousArrayCreationExpression>
    {
        protected override void Run(JetBrains.ReSharper.Psi.VB.Tree.IAnonymousArrayCreationExpression element, JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzerData data, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer consumer) { }
    }
    [JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzerAttribute(new System.Type[] {
            typeof(JetBrains.ReSharper.Psi.VB.Tree.IArrayBound)}, HighlightingTypes=new System.Type[] {
            typeof(JetBrains.ReSharper.Daemon.VB.Errors.NegativeArrayCreationParameterError),
            typeof(JetBrains.ReSharper.Daemon.VB.Errors.ArrayLowerBoundsCanBeOnlyZeroError),
            typeof(JetBrains.ReSharper.Daemon.VB.Errors.RedundantArrayLowerBoundSpecificationWarning)})]
    public class ArrayBoundAnalyzer : JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzer<JetBrains.ReSharper.Psi.VB.Tree.IArrayBound>
    {
        public static System.Nullable<long> BoundToLong([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.VB.Tree.IVBExpression bound) { }
        public static bool IsIntegerZeroExpression(JetBrains.ReSharper.Psi.VB.Tree.IVBExpression vbExpression) { }
        protected override void Run(JetBrains.ReSharper.Psi.VB.Tree.IArrayBound arrayBound, JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzerData data, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer consumer) { }
    }
    [JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzerAttribute(new System.Type[] {
            typeof(JetBrains.ReSharper.Psi.VB.Tree.IArrayCreationExpression)}, HighlightingTypes=new System.Type[] {
            typeof(JetBrains.ReSharper.Daemon.VB.Errors.ArrayBoundSpecificationForNonTopLevelArrayError),
            typeof(JetBrains.ReSharper.Daemon.VB.Errors.RedundantExplicitArraySizeWarning),
            typeof(JetBrains.ReSharper.Daemon.VB.Errors.CannotUseNonEmptyInitializerIfDimensionIsNonConstantError),
            typeof(JetBrains.ReSharper.Daemon.VB.Errors.ArrayInitializerHasTooFewDimensionsError),
            typeof(JetBrains.ReSharper.Daemon.VB.Errors.ArrayInitializerHasTooManyDimensionsError),
            typeof(JetBrains.ReSharper.Daemon.VB.Errors.IncorrectArrayElementTypeError),
            typeof(JetBrains.ReSharper.Daemon.VB.Errors.ArrayInitializerExpectedError),
            typeof(JetBrains.ReSharper.Daemon.VB.Errors.ArrayInitializerSizeMismatchError)})]
    public class ArrayCreationProblemAnalyzer : JetBrains.ReSharper.Daemon.Stages.Dispatcher.IElementProblemAnalyzer
    {
        public static System.Nullable<>[] CheckArrayInitializer(JetBrains.ReSharper.Daemon.IDaemonProcess process, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer consumer, JetBrains.ReSharper.Psi.VB.Tree.IAnonymousArrayCreationExpression initializer, System.Nullable<>[] size, JetBrains.ReSharper.Psi.IType elementType, bool[] sizeConstantness, bool isInternalInitializer) { }
        public static System.Collections.Generic.IList<JetBrains.ReSharper.Psi.VB.Tree.IArrayBound> GetArrayBounds(JetBrains.ReSharper.Psi.VB.Tree.IArrayModifier arrayModifier) { }
        public static System.Nullable<long> GetArrayBoundValue(JetBrains.ReSharper.Psi.VB.Tree.IArrayBound arrayBound, ref bool sizesContainsError, ref bool sizeIsNonConstant) { }
        public static JetBrains.ReSharper.Psi.IType GetArrayElementType(JetBrains.ReSharper.Psi.IType type) { }
        public void Run(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzerData data, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer consumer) { }
    }
    [JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzerAttribute(new System.Type[] {
            typeof(JetBrains.ReSharper.Psi.VB.Tree.IArrayModifiersList)}, HighlightingTypes=new System.Type[] {
            typeof(JetBrains.ReSharper.Daemon.VB.Errors.PartialArrayBoundsSpecificationError),
            typeof(JetBrains.ReSharper.Daemon.VB.Errors.ArrayBoundSpecificationForNonTopLevelArrayError)})]
    public class ArrayModifiresListAnalyzer : JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzer<JetBrains.ReSharper.Psi.VB.Tree.IArrayModifiersList>
    {
        protected override void Run(JetBrains.ReSharper.Psi.VB.Tree.IArrayModifiersList arrayModifiersList, JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzerData data, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer consumer) { }
    }
}
namespace JetBrains.ReSharper.Daemon.VB.Stages.Analysis.TypeCheck
{
    
    public class TypeCheckAnalyzer
    {
        protected void Check(JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer consumer, JetBrains.ReSharper.Psi.IExpressionType expressionType, JetBrains.ReSharper.Psi.IType targetType, JetBrains.ReSharper.Psi.ITypeConversionRule rule, bool strictOff, System.Func<JetBrains.ReSharper.Daemon.IHighlighting> createError, System.Func<JetBrains.ReSharper.Daemon.IHighlighting> createCannotConvertWarning, System.Func<JetBrains.ReSharper.Daemon.IHighlighting> createImpossibleConvertWarning) { }
        protected void CheckInitializerOwnerDeclaration(JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer consumer, JetBrains.ReSharper.Psi.Tree.IInitializerOwnerDeclaration initializerOwner) { }
    }
    [JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzerAttribute(new System.Type[] {
            typeof(JetBrains.ReSharper.Psi.VB.Tree.IVBArgument)}, HighlightingTypes=new System.Type[] {
            typeof(JetBrains.ReSharper.Daemon.VB.Errors.CannotConvertTypeInArgumentWarning),
            typeof(JetBrains.ReSharper.Daemon.VB.Errors.ImpossibleConvertTypeInArgumentWarning)})]
    public class VBArgumentAnalyzer : JetBrains.ReSharper.Daemon.VB.Stages.Analysis.TypeCheck.TypeCheckAnalyzer, JetBrains.ReSharper.Daemon.Stages.Dispatcher.IElementProblemAnalyzer
    {
        public void Run(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzerData data, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer consumer) { }
    }
}
namespace JetBrains.ReSharper.Daemon.VB.Stages
{
    
    [JetBrains.ReSharper.Daemon.DaemonStageAttribute(StagesBefore=new System.Type[] {
            typeof(JetBrains.ReSharper.Daemon.VB.Stages.VBSmartResolverStage)})]
    public class NewLanguageConstructStage : JetBrains.ReSharper.Daemon.VB.Stages.VBDaemonStageBase
    {
        public override JetBrains.ReSharper.Daemon.IDaemonStageProcess CreateProcess(JetBrains.ReSharper.Daemon.IDaemonProcess process, JetBrains.Application.Settings.IContextBoundSettingsStore settings, JetBrains.ReSharper.Daemon.DaemonProcessKind processKind, JetBrains.ReSharper.Psi.VB.Tree.IVBFile vbFile) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.VB.VBLanguage))]
    public class VBCompilerWarningPreprocessor : JetBrains.ReSharper.Daemon.Stages.ICompilerWarningPreProcessor
    {
        public bool PreProcess(System.Collections.Generic.IList<string> compilerIds, JetBrains.ReSharper.Psi.Tree.IFile file, ref System.Nullable<> severity, ref string attributeId) { }
    }
    public abstract class VBDaemonStageBase : JetBrains.ReSharper.Daemon.IDaemonStage
    {
        public abstract JetBrains.ReSharper.Daemon.IDaemonStageProcess CreateProcess(JetBrains.ReSharper.Daemon.IDaemonProcess process, JetBrains.Application.Settings.IContextBoundSettingsStore settings, JetBrains.ReSharper.Daemon.DaemonProcessKind processKind, JetBrains.ReSharper.Psi.VB.Tree.IVBFile file);
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Daemon.IDaemonStageProcess> CreateProcess(JetBrains.ReSharper.Daemon.IDaemonProcess process, JetBrains.Application.Settings.IContextBoundSettingsStore settings, JetBrains.ReSharper.Daemon.DaemonProcessKind processKind) { }
        protected virtual bool IsSupported(JetBrains.ReSharper.Psi.IPsiSourceFile projectFile, JetBrains.Application.Settings.IContextBoundSettingsStore settingsStore) { }
        public virtual JetBrains.ReSharper.Daemon.ErrorStripeRequest NeedsErrorStripe(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, JetBrains.Application.Settings.IContextBoundSettingsStore settingsStore) { }
    }
    public abstract class VBDaemonStageProcessBase : JetBrains.ReSharper.Psi.VB.Tree.TreeNodeVisitor<JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer>, JetBrains.ReSharper.Daemon.IDaemonStageProcess, JetBrains.ReSharper.Psi.IRecursiveElementProcessor<JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer>
    {
        protected VBDaemonStageProcessBase(JetBrains.ReSharper.Daemon.IDaemonProcess daemonProcess, JetBrains.Application.Settings.IContextBoundSettingsStore settingsStore, JetBrains.ReSharper.Psi.VB.Tree.IVBFile file) { }
        public JetBrains.ReSharper.Daemon.IDaemonProcess DaemonProcess { get; }
        public JetBrains.DocumentModel.IDocument Document { get; }
        public JetBrains.ReSharper.Psi.VB.Tree.IVBFile File { get; }
        public JetBrains.Application.Settings.IContextBoundSettingsStore SettingsStore { get; }
        public JetBrains.ReSharper.Psi.VB.Types.IVBTypeConversionRule TypeConversionRule { get; }
        public abstract void Execute(System.Action<JetBrains.ReSharper.Daemon.DaemonStageResult> committer);
        protected void HighlightInFile(System.Action<JetBrains.ReSharper.Psi.VB.Tree.IVBFile, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer> fileHighlighter, System.Action<JetBrains.ReSharper.Daemon.DaemonStageResult> commiter) { }
        public virtual bool InteriorShouldBeProcessed(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer context) { }
        public bool IsProcessingFinished(JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer context) { }
        public virtual void ProcessAfterInterior(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer consumer) { }
        public virtual void ProcessBeforeInterior(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer consumer) { }
    }
    [JetBrains.ReSharper.Daemon.DaemonStageAttribute(StagesAfter=new System.Type[] {
            typeof(JetBrains.ReSharper.Daemon.LanguageSpecificDaemonStage)}, StagesBefore=new System.Type[] {
            typeof(JetBrains.ReSharper.Daemon.UsageChecking.CollectUsagesStage)})]
    public class VBErrorStage : JetBrains.ReSharper.Daemon.VB.Stages.VBDaemonStageBase
    {
        public VBErrorStage(JetBrains.ReSharper.Daemon.Stages.Dispatcher.ElementProblemAnalyzerRegistrar analyzerRegistrar) { }
        public override JetBrains.ReSharper.Daemon.IDaemonStageProcess CreateProcess(JetBrains.ReSharper.Daemon.IDaemonProcess process, JetBrains.Application.Settings.IContextBoundSettingsStore settings, JetBrains.ReSharper.Daemon.DaemonProcessKind processKind, JetBrains.ReSharper.Psi.VB.Tree.IVBFile vbFile) { }
        protected override bool IsSupported(JetBrains.ReSharper.Psi.IPsiSourceFile projectFile, JetBrains.Application.Settings.IContextBoundSettingsStore settingsStore) { }
    }
    [JetBrains.ReSharper.Daemon.Stages.FileStructureExplorerAttribute()]
    public class VbFileStructureExplorer : JetBrains.ReSharper.Daemon.Stages.IFileStructureExplorer
    {
        public JetBrains.ReSharper.Daemon.Stages.IFileStructure Run(System.Predicate<JetBrains.DocumentModel.DocumentRange> isRangeInvalidated, JetBrains.ReSharper.Psi.IPsiSourceFile psiSourceFile, JetBrains.Application.Settings.IContextBoundSettingsStore settingsStore, JetBrains.ReSharper.Psi.Tree.IFile file1) { }
    }
    public abstract class VBHighlightingBase : JetBrains.ReSharper.Daemon.IHighlighting
    {
        public abstract bool IsValid();
    }
    [Microsoft.VisualBasic.CompilerServices.StandardModuleAttribute()]
    public sealed class VBHighlightingConsumerExtension
    {
        public static void AddHighlighting(this JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer consumer, JetBrains.ReSharper.Daemon.IHighlighting error, JetBrains.DocumentModel.DocumentRange range) { }
        public static void AddHighlighting(this JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer consumer, JetBrains.ReSharper.Daemon.IHighlighting error) { }
    }
    [JetBrains.ReSharper.Daemon.DaemonStageAttribute(StagesAfter=new System.Type[] {
            typeof(JetBrains.ReSharper.Daemon.UsageChecking.CollectUsagesStage)}, StagesBefore=new System.Type[] {
            typeof(JetBrains.ReSharper.Daemon.VB.Stages.VBSmartResolverStage)})]
    public class VBIdentifierHighlighterStage : JetBrains.ReSharper.Daemon.VB.Stages.VBDaemonStageBase
    {
        public VBIdentifierHighlighterStage(JetBrains.ReSharper.Daemon.Stages.Resolve.ResolveHighlighterRegistrar resolveHighlighterRegistrar) { }
        public override JetBrains.ReSharper.Daemon.IDaemonStageProcess CreateProcess(JetBrains.ReSharper.Daemon.IDaemonProcess process, JetBrains.Application.Settings.IContextBoundSettingsStore settings, JetBrains.ReSharper.Daemon.DaemonProcessKind processKind, JetBrains.ReSharper.Psi.VB.Tree.IVBFile file1) { }
        protected override bool IsSupported(JetBrains.ReSharper.Psi.IPsiSourceFile projectFile, JetBrains.Application.Settings.IContextBoundSettingsStore settingsStore) { }
    }
    [JetBrains.ReSharper.Daemon.DaemonTooltipProviderAttribute(typeof(JetBrains.ReSharper.Daemon.VB.Stages.VBIdentifierTooltipProvider))]
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.INFO, "IdentifierHighlightings", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.NONE, ShowToolTipInStatusBar=false)]
    public sealed class VBIdentifierHighlighting : JetBrains.ReSharper.Daemon.ICustomAttributeIdHighlighting
    {
        public VBIdentifierHighlighting(string attributeId) { }
        public string AttributeId { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public bool IsValid() { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute(JetBrains.Application.Components.ProgramConfigurations.NONE | JetBrains.Application.Components.ProgramConfigurations.STANDALONE | JetBrains.Application.Components.ProgramConfigurations.TEST | JetBrains.Application.Components.ProgramConfigurations.COMMAND_LINE | JetBrains.Application.Components.ProgramConfigurations.ALL)]
    public class VBIdentifierTooltipProvider : JetBrains.ReSharper.Daemon.IdentifierTooltipProvider<JetBrains.ReSharper.Psi.VB.VBLanguage>
    {
        public VBIdentifierTooltipProvider(JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Feature.Services.Descriptions.IDeclaredElementDescriptionPresenter presenter) { }
    }
    public abstract class VBIncrementalDaemonStageProcess : JetBrains.ReSharper.Daemon.VB.Stages.VBDaemonStageProcessBase
    {
        protected VBIncrementalDaemonStageProcess(JetBrains.ReSharper.Daemon.IDaemonProcess daemonProcess, JetBrains.Application.Settings.IContextBoundSettingsStore settingsStore, JetBrains.ReSharper.Psi.VB.Tree.IVBFile vbFile) { }
        public override void Execute(System.Action<JetBrains.ReSharper.Daemon.DaemonStageResult> committer) { }
    }
    [JetBrains.ReSharper.Psi.Naming.Interfaces.NamingConsistencyCheckerAttribute(typeof(JetBrains.ReSharper.Psi.VB.VBLanguage))]
    public sealed class VBNamingConsistencyChecker : JetBrains.ReSharper.Psi.Naming.Impl.ClrNamingConsistencyCheckerBase
    {
        public VBNamingConsistencyChecker(JetBrains.Application.Settings.ISettingsStore settingsStore) { }
        public override bool IsApplicable(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
        protected override bool IsUnnamedElement(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration) { }
    }
    public class VBSmartResolverProcess : JetBrains.ReSharper.Daemon.IDaemonStageProcess
    {
        public VBSmartResolverProcess(JetBrains.ReSharper.Daemon.IDaemonProcess daemonProcess, JetBrains.ReSharper.Psi.VB.Tree.IVBFile file) { }
        public JetBrains.ReSharper.Daemon.IDaemonProcess DaemonProcess { get; }
        public void Execute(System.Action<JetBrains.ReSharper.Daemon.DaemonStageResult> committer) { }
        public JetBrains.ReSharper.Psi.DeclaredElementInstance GetUnqualifiedResolve(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public bool HasLocalDeclarationConflict(JetBrains.ReSharper.Psi.IDeclaredElement element) { }
        public bool IsImportClauseUsed(JetBrains.ReSharper.Psi.VB.Tree.IImportClause clause) { }
    }
    [JetBrains.ReSharper.Daemon.DaemonStageAttribute(StagesAfter=new System.Type[] {
            typeof(JetBrains.ReSharper.Daemon.UsageChecking.CollectUsagesStage)}, StagesBefore=new System.Type[] {
            typeof(JetBrains.ReSharper.Daemon.Stages.GlobalFileStructureCollectorStage)})]
    public class VBSmartResolverStage : JetBrains.ReSharper.Daemon.VB.Stages.VBDaemonStageBase
    {
        public override JetBrains.ReSharper.Daemon.IDaemonStageProcess CreateProcess(JetBrains.ReSharper.Daemon.IDaemonProcess process, JetBrains.Application.Settings.IContextBoundSettingsStore settings, JetBrains.ReSharper.Daemon.DaemonProcessKind processKind, JetBrains.ReSharper.Psi.VB.Tree.IVBFile vbFile) { }
        public override JetBrains.ReSharper.Daemon.ErrorStripeRequest NeedsErrorStripe(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, JetBrains.Application.Settings.IContextBoundSettingsStore settingsStore) { }
    }
    [JetBrains.ProjectModel.ProjectFileTypeAttribute(typeof(JetBrains.ProjectModel.VBProjectFileType))]
    public class VBSyntaxHighlighting : JetBrains.ReSharper.Daemon.SyntaxHighlighting
    {
        public VBSyntaxHighlighting(JetBrains.ProjectModel.VBProjectFileType projectFileType, JetBrains.ProjectModel.SolutionsManager solutionManager, JetBrains.TextControl.DefaultTextControlSchemeManager defaultTextControlSchemeManager) { }
        public override JetBrains.Util.TextRange GetAttributesForOffset(JetBrains.TextControl.ITextControl textControl, int offset, ref JetBrains.TextControl.DocumentMarkup.HighlighterAttributes attributes) { }
    }
    [JetBrains.ReSharper.Daemon.DaemonStageAttribute(StagesBefore=new System.Type[] {
            typeof(JetBrains.ReSharper.Daemon.LanguageSpecificDaemonStage)})]
    public class VBWinRTStage : JetBrains.ReSharper.Daemon.VB.Stages.VBDaemonStageBase
    {
        public override JetBrains.ReSharper.Daemon.IDaemonStageProcess CreateProcess(JetBrains.ReSharper.Daemon.IDaemonProcess process, JetBrains.Application.Settings.IContextBoundSettingsStore settings, JetBrains.ReSharper.Daemon.DaemonProcessKind processKind, JetBrains.ReSharper.Psi.VB.Tree.IVBFile file) { }
    }
}
namespace JetBrains.ReSharper.Daemon.VB.Stages.ResolveHandlers
{
    
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.VB.VBLanguage))]
    public class DocCommentErrorHandler : JetBrains.ReSharper.Daemon.Stages.Resolve.IResolveProblemHighlighter
    {
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Resolve.ResolveErrorType> ErrorTypes { get; }
        public JetBrains.ReSharper.Daemon.IHighlighting Run(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.VB.VBLanguage))]
    public class DynamicErrorHandler : JetBrains.ReSharper.Daemon.Stages.Resolve.IResolveProblemHighlighter
    {
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Resolve.ResolveErrorType> ErrorTypes { get; }
        public JetBrains.ReSharper.Daemon.IHighlighting Run(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.VB.VBLanguage))]
    public class IncorrectAwaitablePatternErrorHandler : JetBrains.ReSharper.Daemon.Stages.Resolve.IResolveProblemHighlighter
    {
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Resolve.ResolveErrorType> ErrorTypes { get; }
        public JetBrains.ReSharper.Daemon.IHighlighting Run(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.VB.VBLanguage))]
    public class IncorrectParameterNumberInMidErrorHandler : JetBrains.ReSharper.Daemon.Stages.Resolve.IResolveProblemHighlighter
    {
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Resolve.ResolveErrorType> ErrorTypes { get; }
        public JetBrains.ReSharper.Daemon.IHighlighting Run(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.VB.VBLanguage))]
    public class IncorrectQualifierUsageErrorHandler : JetBrains.ReSharper.Daemon.Stages.Resolve.IResolveProblemHighlighter
    {
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Resolve.ResolveErrorType> ErrorTypes { get; }
        public JetBrains.ReSharper.Daemon.IHighlighting Run(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.VB.VBLanguage))]
    public class IncorrectSignatureErrorHandler : JetBrains.ReSharper.Daemon.Stages.Resolve.IResolveProblemHighlighter
    {
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Resolve.ResolveErrorType> ErrorTypes { get; }
        public JetBrains.ReSharper.Daemon.IHighlighting Run(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.VB.VBLanguage))]
    public class MultipleCandidatesErrorHandler : JetBrains.ReSharper.Daemon.Stages.Resolve.IResolveProblemHighlighter
    {
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Resolve.ResolveErrorType> ErrorTypes { get; }
        public JetBrains.ReSharper.Daemon.IHighlighting Run(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.VB.VBLanguage))]
    public class NamespaceExpectedErrorHandler : JetBrains.ReSharper.Daemon.Stages.Resolve.IResolveProblemHighlighter
    {
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Resolve.ResolveErrorType> ErrorTypes { get; }
        public JetBrains.ReSharper.Daemon.IHighlighting Run(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.VB.VBLanguage))]
    public class NotAttributeErrorHandler : JetBrains.ReSharper.Daemon.Stages.Resolve.IResolveProblemHighlighter
    {
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Resolve.ResolveErrorType> ErrorTypes { get; }
        public JetBrains.ReSharper.Daemon.IHighlighting Run(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.VB.VBLanguage))]
    public class NotEventErrorHandler : JetBrains.ReSharper.Daemon.Stages.Resolve.IResolveProblemHighlighter
    {
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Resolve.ResolveErrorType> ErrorTypes { get; }
        public JetBrains.ReSharper.Daemon.IHighlighting Run(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.VB.VBLanguage))]
    public class NotInvocableErrorHandler : JetBrains.ReSharper.Daemon.Stages.Resolve.IResolveProblemHighlighter
    {
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Resolve.ResolveErrorType> ErrorTypes { get; }
        public JetBrains.ReSharper.Daemon.IHighlighting Run(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.VB.VBLanguage))]
    public class NotMethodErrorHandler : JetBrains.ReSharper.Daemon.Stages.Resolve.IResolveProblemHighlighter
    {
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Resolve.ResolveErrorType> ErrorTypes { get; }
        public JetBrains.ReSharper.Daemon.IHighlighting Run(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.VB.VBLanguage))]
    public class NotPropertyInDictionaryAccessErrorHandler : JetBrains.ReSharper.Daemon.Stages.Resolve.IResolveProblemHighlighter
    {
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Resolve.ResolveErrorType> ErrorTypes { get; }
        public JetBrains.ReSharper.Daemon.IHighlighting Run(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.VB.VBLanguage))]
    public class NotResolvedInterfaceSpecifierErrorHandler : JetBrains.ReSharper.Daemon.Stages.Resolve.IResolveProblemHighlighter
    {
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Resolve.ResolveErrorType> ErrorTypes { get; }
        public JetBrains.ReSharper.Daemon.IHighlighting Run(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.VB.VBLanguage))]
    public class NotValidHereErrorHandler : JetBrains.ReSharper.Daemon.Stages.Resolve.IResolveProblemHighlighter
    {
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Resolve.ResolveErrorType> ErrorTypes { get; }
        public JetBrains.ReSharper.Daemon.IHighlighting Run(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.VB.VBLanguage))]
    public class NotVariableErrorHandler : JetBrains.ReSharper.Daemon.Stages.Resolve.IResolveProblemHighlighter
    {
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Resolve.ResolveErrorType> ErrorTypes { get; }
        public JetBrains.ReSharper.Daemon.IHighlighting Run(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.VB.VBLanguage))]
    public class NotVariableInInitializerErrorHandler : JetBrains.ReSharper.Daemon.Stages.Resolve.IResolveProblemHighlighter
    {
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Resolve.ResolveErrorType> ErrorTypes { get; }
        public JetBrains.ReSharper.Daemon.IHighlighting Run(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.VB.VBLanguage))]
    public class TypeExpectedErrorHandler : JetBrains.ReSharper.Daemon.Stages.Resolve.IResolveProblemHighlighter
    {
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Resolve.ResolveErrorType> ErrorTypes { get; }
        public JetBrains.ReSharper.Daemon.IHighlighting Run(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.VB.VBLanguage))]
    public class UseLocalBeforeDeclarationErrorHandler : JetBrains.ReSharper.Daemon.Stages.Resolve.IResolveProblemHighlighter
    {
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Resolve.ResolveErrorType> ErrorTypes { get; }
        public JetBrains.ReSharper.Daemon.IHighlighting Run(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
    }
}
namespace JetBrains.ReSharper.Daemon.VB.Stages.UsageChecking
{
    
    public class VBPresentationHelper : JetBrains.ReSharper.Daemon.UsageChecking.IPresentationHelper
    {
        public string DeclaredElementName(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
        public string GetInternalTerm(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration) { }
        public string GetReadOnlyTerm(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration) { }
        public string GetSealedTerm(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration) { }
        public string GetStaticTerm() { }
        public string GetVirtualTerm(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration) { }
        public JetBrains.DocumentModel.DocumentRange LowerAccessHighlightingRange(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration) { }
        public JetBrains.DocumentModel.DocumentRange ReturnTypeRange(JetBrains.ReSharper.Psi.Tree.IFunctionDeclaration declaration) { }
        public JetBrains.DocumentModel.DocumentRange TypeUsageRange(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration) { }
        public JetBrains.DocumentModel.DocumentRange VirtualMemberNeverOverridenRange(JetBrains.ReSharper.Psi.Tree.ITypeMemberDeclaration declaration) { }
    }
    public class VBSpecificElementPropertiesCalculator : JetBrains.ReSharper.Daemon.UsageChecking.ILanguageSpecificElementPropertiesCalculator
    {
        public bool CanConvertToConstant(JetBrains.ReSharper.Psi.IField field) { }
        public bool CanConvertToConstant(JetBrains.ReSharper.Psi.ILocalVariable local) { }
        public bool IsAutoProperty(JetBrains.ReSharper.Psi.IProperty property) { }
        public bool IsInitializedInDeclaration(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration) { }
        public bool IsPartialClass(JetBrains.ReSharper.Psi.IClass @class) { }
        public bool IsPartialMethod(JetBrains.ReSharper.Psi.IMethod method) { }
        public bool IsRedundantOverload(JetBrains.ReSharper.Psi.ITypeMember member) { }
        public bool IsStaticClass(JetBrains.ReSharper.Psi.IClass @class) { }
        public bool IsUsedInTermsOfCompiler(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration) { }
        public bool MethodDeclarationHasBody(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration) { }
    }
    [Microsoft.VisualBasic.CompilerServices.StandardModuleAttribute()]
    public sealed class VBTypeConstraintsUtil
    {
        public static System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.ILocalVariable> LocalsToCorrectType(JetBrains.ReSharper.Psi.IDeclaredElement element, JetBrains.ReSharper.Psi.IType newType, JetBrains.ReSharper.Psi.VB.Tree.IVBExpression usage) { }
        public static System.Collections.Generic.ICollection<JetBrains.ReSharper.Daemon.UsageChecking.ITypeUsageConstraint> TypeConstraintsFromUsage(JetBrains.ReSharper.Psi.IDeclaredElement element, JetBrains.ReSharper.Psi.IType elementType, JetBrains.ReSharper.Psi.VB.Tree.IVBExpression expression) { }
    }
    public class VBUsageAnalyzer : JetBrains.ReSharper.Daemon.UsageChecking.UsageAnalyzer
    {
        public VBUsageAnalyzer(JetBrains.DataFlow.Lifetime lt, JetBrains.DataFlow.IViewable<JetBrains.ReSharper.Daemon.UsageChecking.IUsageInspectionsSupressor> supressors) { }
        protected override bool CheckFieldMutableAccess(JetBrains.ReSharper.Daemon.UsageChecking.UsageState accessState, JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.IField field) { }
        protected override JetBrains.ReSharper.Daemon.UsageChecking.VariableUsageState GetExpressionAccessState(JetBrains.ReSharper.Psi.Tree.IExpression expr) { }
        protected override JetBrains.ReSharper.Daemon.UsageChecking.UsageState GetParameterUsageState(JetBrains.ReSharper.Psi.IParameter parameter, JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        protected override bool IsAssignToDelegate(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.IMethod method) { }
        protected override bool IsCallToBase(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.IOverridableMember member) { }
        protected override bool IsReturnValueUsed(JetBrains.ReSharper.Psi.Tree.IExpression expression, bool isCallToBase) { }
        protected override bool IsTypeof(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Tree.ITypeMemberDeclaration> MembersToRehighlight(JetBrains.ReSharper.Daemon.IDaemonProcess daemonProcess) { }
        protected override void ProcessDeclaration(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration, JetBrains.ReSharper.Psi.IDeclaredElement element, JetBrains.ReSharper.Daemon.UsageChecking.UsageAnalyzer.IParameters parameters) { }
        public override void ProcessElement(JetBrains.ReSharper.Psi.Tree.ITreeNode node, JetBrains.ReSharper.Daemon.UsageChecking.UsageAnalyzer.IParameters parameters) { }
        protected override void ProcessMemberUsage(JetBrains.ReSharper.Psi.ITypeMember member, JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Daemon.UsageChecking.UsageAnalyzer.IParameters parameters) { }
        protected override System.Collections.Generic.ICollection<JetBrains.ReSharper.Daemon.UsageChecking.ITypeUsageConstraint> TypeConstraintsFromUsage(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, JetBrains.ReSharper.Psi.IType elementType, JetBrains.ReSharper.Psi.Tree.IExpression expression) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.VB.VBLanguage))]
    public class VBUsageCheckingServices : JetBrains.ReSharper.Daemon.UsageChecking.CLRUsageCheckingServices
    {
        public VBUsageCheckingServices(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ReSharper.Psi.ExtensionsAPI.FileDependency fileDependency, JetBrains.Application.Settings.ISettingsStore settingsStore, JetBrains.DataFlow.IViewable<JetBrains.ReSharper.Daemon.UsageChecking.IUsageInspectionsSupressor> supressors) { }
        public override bool GetUnusedDeclarationsSupported(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
    }
}
namespace JetBrains.ReSharper.Daemon.VB.Util
{
    
    [Microsoft.VisualBasic.CompilerServices.StandardModuleAttribute()]
    public sealed class VBDaemonUtil
    {
        public static JetBrains.ReSharper.Psi.Tree.ITreeNode GetContainingFunctionDeclaration(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public static bool IsIterator(JetBrains.ReSharper.Psi.VB.Tree.IVBDeclaration declaration) { }
        public static bool IsUnderAnonymousMethod(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
    }
}
namespace JetBrains.ReSharper.Daemon.VB
{
    
    [JetBrains.ProjectModel.ProjectFileTypeAttribute(typeof(JetBrains.ProjectModel.VBProjectFileType))]
    public class VBHighlightingSuppressor : JetBrains.ReSharper.Daemon.IHighlightingSuppressor
    {
        public VBHighlightingSuppressor(JetBrains.Application.Settings.ISettingsStore settingsStore, JetBrains.Threading.IThreading locks) { }
        public JetBrains.DataFlow.IProperty<bool> ShouldSuppress(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ProjectModel.IProjectFile projectFile, JetBrains.TextControl.ITextControl textControl) { }
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "VBErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class VBSyntaxError : JetBrains.ReSharper.Daemon.Impl.SyntaxErrorBase
    {
        public VBSyntaxError(string toolTip) { }
    }
}