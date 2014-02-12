[assembly: System.Runtime.CompilerServices.InternalsVisibleToAttribute(@"ControlFlowGraphVisualizer, PublicKey=002400000480000094000000060200000024000052534131000400000100010087f63ba6a789c30e210e7ec987234ad9fe33baf7367993bab1b312d6f72ca296b91ed5c658964ffb9e7570eb184a527c68c6bdba41cfe67d8cfd3f888234206bf39205a3652d3af3445bb6f715fdac532e289fea41229bac37762b67eb16f58fee717d2465fca9ee17f08ed16772a1fc52c1c17022e1f0d9bdd004524a663aca")]
[assembly: System.Runtime.CompilerServices.InternalsVisibleToAttribute(@"DecompilerConsole, PublicKey=002400000480000094000000060200000024000052534131000400000100010087f63ba6a789c30e210e7ec987234ad9fe33baf7367993bab1b312d6f72ca296b91ed5c658964ffb9e7570eb184a527c68c6bdba41cfe67d8cfd3f888234206bf39205a3652d3af3445bb6f715fdac532e289fea41229bac37762b67eb16f58fee717d2465fca9ee17f08ed16772a1fc52c1c17022e1f0d9bdd004524a663aca")]
[assembly: System.Runtime.CompilerServices.InternalsVisibleToAttribute(@"JetBrains.Decompiler.Core.Tests, PublicKey=002400000480000094000000060200000024000052534131000400000100010087f63ba6a789c30e210e7ec987234ad9fe33baf7367993bab1b312d6f72ca296b91ed5c658964ffb9e7570eb184a527c68c6bdba41cfe67d8cfd3f888234206bf39205a3652d3af3445bb6f715fdac532e289fea41229bac37762b67eb16f58fee717d2465fca9ee17f08ed16772a1fc52c1c17022e1f0d9bdd004524a663aca")]
[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]

namespace JetBrains.Decompiler.Ast
{
    
    public class static AstFactory
    {
        public static JetBrains.Decompiler.Ast.IAddressOfExpression CreateAddressOf(JetBrains.Decompiler.Ast.IExpression argument) { }
        public static JetBrains.Decompiler.Ast.IAnonymousMethodExpression CreateAnonymousMethodExpression(JetBrains.Decompiler.Ast.IFunctionSignature signature, JetBrains.Decompiler.Ast.IBlockStatement body) { }
        public static JetBrains.Decompiler.Ast.IAnonymousObjectCreationExpression CreateAnonymousObjectCreation(JetBrains.Metadata.Reader.API.IMetadataType constructedType, JetBrains.Decompiler.Ast.IMemberInitializerList initializer) { }
        public static JetBrains.Decompiler.Ast.IArgListCreationExpression CreateArgListCreation(JetBrains.Decompiler.Ast.IExpression[] arguments) { }
        public static JetBrains.Decompiler.Ast.IArgListReferenceExpression CreateArgListReference() { }
        public static JetBrains.Decompiler.Ast.IArrayCreationExpression CreateArrayCreation(JetBrains.Metadata.Reader.API.IMetadataArrayType arrayType, JetBrains.Decompiler.Ast.IExpression[] dimensions, JetBrains.Decompiler.Ast.IExpressionList initializer) { }
        public static JetBrains.Decompiler.Ast.IArrayElementAccessExpression CreateArrayElementAccess(JetBrains.Decompiler.Ast.IExpression array, JetBrains.Decompiler.Ast.IExpression[] indexes) { }
        public static JetBrains.Decompiler.Ast.IAwaitExpression CreateAwait(JetBrains.Decompiler.Ast.IExpression argument, JetBrains.Metadata.Reader.API.IMetadataType resultType) { }
        public static JetBrains.Decompiler.Ast.IBaseReferenceExpression CreateBaseReference() { }
        public static JetBrains.Decompiler.Ast.IBinaryOperationExpression CreateBinaryOperation(JetBrains.Decompiler.Ast.OperationType operationType, JetBrains.Decompiler.Ast.IExpression leftArgument, JetBrains.Decompiler.Ast.IExpression rightArgument, JetBrains.Decompiler.Ast.OverflowCheckType overflowCheck = 2) { }
        public static JetBrains.Decompiler.Ast.IBlockStatement CreateBlockStatement() { }
        public static JetBrains.Decompiler.Ast.IBlockStatement CreateBlockStatement(System.Collections.Generic.IEnumerable<JetBrains.Decompiler.Ast.IStatement> statements) { }
        public static JetBrains.Decompiler.Ast.IBoxExpression CreateBox(JetBrains.Decompiler.Ast.IExpression argument, JetBrains.Metadata.Reader.API.IMetadataType sourceType) { }
        public static JetBrains.Decompiler.Ast.IBreakStatement CreateBreak() { }
        public static JetBrains.Decompiler.Ast.ICatchClause CreateCatchClause(JetBrains.Decompiler.Ast.ILocalVariableReferenceExpression variableReference, JetBrains.Decompiler.Ast.IBlockStatement body) { }
        public static JetBrains.Decompiler.Ast.ICheckCastExpression CreateCheckCast(JetBrains.Decompiler.Ast.IExpression argument, JetBrains.Metadata.Reader.API.IMetadataType type) { }
        public static JetBrains.Decompiler.Ast.ICheckFiniteExpression CreateCheckFinite(JetBrains.Decompiler.Ast.IExpression expression) { }
        public static JetBrains.Decompiler.Ast.ICommentStatement CreateComment(string text) { }
        public static JetBrains.Decompiler.Ast.IConditionalExpression CreateConditional(JetBrains.Decompiler.Ast.IExpression condition, JetBrains.Decompiler.Ast.IExpression thenExpression, JetBrains.Decompiler.Ast.IExpression elseExpression) { }
        public static JetBrains.Decompiler.Ast.IContinueStatement CreateContinue() { }
        public static JetBrains.Decompiler.Ast.IDefaultValueExpression CreateDefaultValue(JetBrains.Metadata.Reader.API.IMetadataType type) { }
        public static JetBrains.Decompiler.Ast.IDelegateCallExpression CreateDelegateCall(JetBrains.Decompiler.Ast.IExpression @delegate, JetBrains.Metadata.Reader.API.MethodSpecification invokeSpecification, JetBrains.Decompiler.Ast.IExpression[] arguments) { }
        public static JetBrains.Decompiler.Ast.IDelegateCreationExpression CreateDelegateCreation(JetBrains.Metadata.Reader.API.IMetadataType constructedType, JetBrains.Metadata.Reader.API.MethodInstantiation methodInstantiation, JetBrains.Decompiler.Ast.IExpression target) { }
        public static JetBrains.Decompiler.Ast.IDerefExpression CreateDeref(JetBrains.Decompiler.Ast.IExpression argument, bool implicit = False) { }
        public static JetBrains.Decompiler.Ast.IEmptyStatement CreateEmptyStatement() { }
        public static JetBrains.Decompiler.Ast.IEndFinallyStatement CreateEndFinally() { }
        public static JetBrains.Decompiler.Ast.IEventAccessExpression CreateEventAccess(JetBrains.Decompiler.Ast.IExpression target, JetBrains.Decompiler.Metadata.EventSpecification eventSpecification, bool isVirtual) { }
        public static JetBrains.Decompiler.Ast.IExpressionList CreateExpressionList() { }
        public static JetBrains.Decompiler.Ast.IExpressionList CreateExpressionList(System.Collections.Generic.IEnumerable<JetBrains.Decompiler.Ast.IExpression> expressions) { }
        public static JetBrains.Decompiler.Ast.IExpressionStatement CreateExpressionStatement(JetBrains.Decompiler.Ast.IExpression expression) { }
        public static JetBrains.Decompiler.Ast.IFieldAccessExpression CreateFieldAccess(JetBrains.Decompiler.Ast.IExpression target, JetBrains.Metadata.Reader.API.FieldSpecification fieldSpecification, JetBrains.Decompiler.Ast.MemberAccessKind accessKind = 0) { }
        public static JetBrains.Decompiler.Ast.IFieldMemberInitializer CreateFieldMemberInitializer(JetBrains.Metadata.Reader.API.IMetadataField field, JetBrains.Decompiler.Ast.IExpression value) { }
        public static JetBrains.Decompiler.Ast.IFieldReferenceExpression CreateFieldReference(JetBrains.Metadata.Reader.API.FieldSpecification specification) { }
        public static JetBrains.Decompiler.Ast.IFixedStatement CreateFixed(JetBrains.Decompiler.Ast.ILocalVariableReferenceExpression variableReference, JetBrains.Decompiler.Ast.IExpression initializer, JetBrains.Decompiler.Ast.IStatement body) { }
        public static JetBrains.Decompiler.Ast.IForStatement CreateFor(JetBrains.Decompiler.Ast.IStatement initializer, JetBrains.Decompiler.Ast.IExpression condition, JetBrains.Decompiler.Ast.IStatement iterator, JetBrains.Decompiler.Ast.IStatement body) { }
        public static JetBrains.Decompiler.Ast.IForEachStatement CreateForEach(JetBrains.Decompiler.Ast.ILocalVariableReferenceExpression variableReference, JetBrains.Decompiler.Ast.IExpression expression, JetBrains.Decompiler.Ast.IStatement body) { }
        public static JetBrains.Decompiler.Ast.IFunctionPointerCallExpression CreateFunctionPointerCall(JetBrains.Decompiler.Ast.IExpression functionPointer, JetBrains.Decompiler.Ast.IExpression[] arguments) { }
        public static JetBrains.Decompiler.Ast.IFunctionSignature CreateFunctionSignature() { }
        public static JetBrains.Decompiler.Ast.IGotoStatement CreateGoto(JetBrains.Decompiler.Ast.ILabel label) { }
        public static JetBrains.Decompiler.Ast.IGotoCaseStatement CreateGotoCase(JetBrains.Decompiler.Ast.Constant caseValue) { }
        public static JetBrains.Decompiler.Ast.IGotoDefaultStatement CreateGotoDefault() { }
        public static JetBrains.Decompiler.Ast.IIfStatement CreateIf(JetBrains.Decompiler.Ast.IExpression condition, JetBrains.Decompiler.Ast.IStatement then, JetBrains.Decompiler.Ast.IStatement @else) { }
        public static JetBrains.Decompiler.Ast.IIndexerCallExpression CreateIndexerCall(JetBrains.Decompiler.Ast.IExpression target, JetBrains.Decompiler.Metadata.PropertySpecification propertySpecification, bool isVirtual, JetBrains.Decompiler.Ast.IExpression[] arguments) { }
        public static JetBrains.Decompiler.Ast.IJumpStatement CreateJump(JetBrains.Metadata.Reader.API.MethodInstantiation methodInstantiation) { }
        public static JetBrains.Decompiler.Ast.ILabelDeclarationStatement CreateLabelDeclaration(JetBrains.Decompiler.Ast.ILabel label) { }
        public static JetBrains.Decompiler.Ast.ILambdaBlockExpression CreateLambdaBlockExpression(JetBrains.Decompiler.Ast.IFunctionSignature signature, JetBrains.Decompiler.Ast.IBlockStatement body) { }
        public static JetBrains.Decompiler.Ast.ILambdaExpression CreateLambdaExpression(JetBrains.Decompiler.Ast.IFunctionSignature signature, JetBrains.Decompiler.Ast.IExpression body) { }
        public static JetBrains.Decompiler.Ast.ILiteralExpression CreateLiteral(JetBrains.Decompiler.Ast.Constant value) { }
        public static JetBrains.Decompiler.Ast.ILocalVariableDeclarationStatement CreateLocalVariableDeclaration(JetBrains.Decompiler.Ast.ILocalVariableReferenceExpression variableReference, JetBrains.Decompiler.Ast.IExpression initializer = null) { }
        public static JetBrains.Decompiler.Ast.ILocalVariableDeclarationScope CreateLocalVariableDeclarationScope() { }
        public static JetBrains.Decompiler.Ast.ILocalVariableReferenceExpression CreateLocalVariableReference(JetBrains.Decompiler.Ast.ILocalVariable variable) { }
        public static JetBrains.Decompiler.Ast.ILockStatement CreateLock(JetBrains.Decompiler.Ast.IExpression expression, JetBrains.Decompiler.Ast.IStatement body) { }
        public static JetBrains.Decompiler.Ast.ILoopStatement CreateLoop(JetBrains.Decompiler.Ast.LoopType loopType, JetBrains.Decompiler.Ast.IExpression condition, JetBrains.Decompiler.Ast.IStatement body) { }
        public static JetBrains.Decompiler.Ast.IMakeRefExpression CreateMakeRef(JetBrains.Decompiler.Ast.IExpression argument) { }
        public static JetBrains.Decompiler.Ast.IMemberInitializerList CreateMemberInitializerList() { }
        public static JetBrains.Decompiler.Ast.IMemberInitializerList CreateMemberInitializerList(System.Collections.Generic.IEnumerable<JetBrains.Decompiler.Ast.IMemberInitializer> initializers) { }
        public static JetBrains.Decompiler.Ast.IMemoryCopyStatement CreateMemoryCopy(JetBrains.Decompiler.Ast.IExpression source, JetBrains.Decompiler.Ast.IExpression destination, JetBrains.Decompiler.Ast.IExpression length) { }
        public static JetBrains.Decompiler.Ast.IMemoryInitializeStatement CreateMemoryInitialize(JetBrains.Decompiler.Ast.IExpression destination, JetBrains.Decompiler.Ast.IExpression value, JetBrains.Decompiler.Ast.IExpression length) { }
        public static JetBrains.Decompiler.Ast.IMethodCallExpression CreateMethodCall(JetBrains.Decompiler.Ast.IExpression target, JetBrains.Metadata.Reader.API.MethodInstantiation methodInstantiation, bool isVirtual, JetBrains.Decompiler.Ast.IExpression[] arguments, JetBrains.Decompiler.Ast.MemberAccessKind accessKind = 0) { }
        public static JetBrains.Decompiler.Ast.IMethodPointerExpression CreateMethodPointer(JetBrains.Metadata.Reader.API.MethodInstantiation methodInstantiation) { }
        public static JetBrains.Decompiler.Ast.IMethodReferenceExpression CreateMethodReference(JetBrains.Metadata.Reader.API.MethodInstantiation methodInstantiation) { }
        public static JetBrains.Decompiler.Ast.INestedInitializer CreateNestedInitializer() { }
        public static JetBrains.Decompiler.Ast.IObjectCreationExpression CreateObjectCreation(JetBrains.Metadata.Reader.API.IMetadataType constructedType, JetBrains.Metadata.Reader.API.MethodSpecification constructorSpecification, JetBrains.Decompiler.Ast.IExpression[] arguments) { }
        public static JetBrains.Decompiler.Ast.IParameterModifierExpression CreateParameterModifier(JetBrains.Decompiler.Ast.IExpression argument, JetBrains.Decompiler.Ast.ParameterModifierKind modifierKind) { }
        public static JetBrains.Decompiler.Ast.IParameterReferenceExpression CreateParameterReference(JetBrains.Decompiler.Ast.IMethodParameter parameter) { }
        public static JetBrains.Decompiler.Ast.IPinStatement CreatePin(JetBrains.Decompiler.Ast.ILocalVariableReferenceExpression variableReference, JetBrains.Decompiler.Ast.IExpression initializer) { }
        public static JetBrains.Decompiler.Ast.IPointerElementAccessExpression CreatePointerElementAccess(JetBrains.Decompiler.Ast.IExpression pointer, JetBrains.Decompiler.Ast.IExpression index) { }
        public static JetBrains.Decompiler.Ast.IPointerIndirectionExpression CreatePointerIndirection(JetBrains.Decompiler.Ast.IExpression argument) { }
        public static JetBrains.Decompiler.Ast.IPropertyAccessExpression CreatePropertyAccess(JetBrains.Decompiler.Ast.IExpression target, JetBrains.Decompiler.Metadata.PropertySpecification propertySpecification, bool isVirtual, JetBrains.Decompiler.Ast.MemberAccessKind accessKind = 0) { }
        public static JetBrains.Decompiler.Ast.IPropertyMemberInitializer CreatePropertyMemberInitializer(JetBrains.Metadata.Reader.API.IMetadataProperty property, JetBrains.Decompiler.Ast.IExpression value) { }
        public static JetBrains.Decompiler.Ast.IRefExpression CreateRef(JetBrains.Decompiler.Ast.IExpression argument, bool implicit = False) { }
        public static JetBrains.Decompiler.Ast.IRefTypeExpression CreateRefType(JetBrains.Decompiler.Ast.IExpression argument) { }
        public static JetBrains.Decompiler.Ast.IRefTypeTokenExpression CreateRefTypeToken(JetBrains.Decompiler.Ast.IExpression argument) { }
        public static JetBrains.Decompiler.Ast.IRefValueExpression CreateRefValue(JetBrains.Decompiler.Ast.IExpression argument, JetBrains.Metadata.Reader.API.IMetadataType type) { }
        public static JetBrains.Decompiler.Ast.IRethrowStatement CreateRethrow() { }
        public static JetBrains.Decompiler.Ast.IReturnStatement CreateReturn(JetBrains.Decompiler.Ast.IExpression result) { }
        public static JetBrains.Decompiler.Ast.ISizeOfExpression CreateSizeOf(JetBrains.Metadata.Reader.API.IMetadataType type) { }
        public static JetBrains.Decompiler.Ast.IStackAllocExpression CreateStackAlloc(JetBrains.Metadata.Reader.API.IMetadataType elementType, JetBrains.Decompiler.Ast.IExpression length) { }
        public static JetBrains.Decompiler.Ast.ISwitchStatement CreateSwitch(JetBrains.Decompiler.Ast.IExpression expression, JetBrains.Decompiler.Ast.ISwitchCase[] cases, JetBrains.Decompiler.Ast.IBlockStatement defaultBlock) { }
        public static JetBrains.Decompiler.Ast.ISwitchCase CreateSwitchCase(JetBrains.Decompiler.Ast.IExpression[] values, JetBrains.Decompiler.Ast.IBlockStatement body) { }
        public static JetBrains.Decompiler.Ast.IThisReferenceExpression CreateThisReference() { }
        public static JetBrains.Decompiler.Ast.IThrowStatement CreateThrow(JetBrains.Decompiler.Ast.IExpression argument) { }
        public static JetBrains.Decompiler.Ast.ITryStatement CreateTry(JetBrains.Decompiler.Ast.IBlockStatement body, JetBrains.Decompiler.Ast.ICatchClause[] catchClauses, JetBrains.Decompiler.Ast.IBlockStatement finallyBlock, JetBrains.Decompiler.Ast.IBlockStatement faultBlock) { }
        public static JetBrains.Decompiler.Ast.ITryCastExpression CreateTryCast(JetBrains.Decompiler.Ast.IExpression argument, JetBrains.Metadata.Reader.API.IMetadataType type) { }
        public static JetBrains.Decompiler.Ast.ITypeCastExpression CreateTypeCast(JetBrains.Decompiler.Ast.IExpression argument, JetBrains.Metadata.Reader.API.IMetadataType targetType, JetBrains.Decompiler.Ast.OverflowCheckType overflowCheck) { }
        public static JetBrains.Decompiler.Ast.ITypeOfExpression CreateTypeOf(JetBrains.Metadata.Reader.API.IMetadataType type) { }
        public static JetBrains.Decompiler.Ast.ITypeReferenceExpression CreateTypeReference(JetBrains.Metadata.Reader.API.IMetadataType type) { }
        public static JetBrains.Decompiler.Ast.IUnaryOperationExpression CreateUnaryOperation(JetBrains.Decompiler.Ast.OperationType operationType, JetBrains.Decompiler.Ast.IExpression argument, JetBrains.Decompiler.Ast.OverflowCheckType overflowCheck = 2) { }
        public static JetBrains.Decompiler.Ast.IUnboxExpression CreateUnbox(JetBrains.Decompiler.Ast.IExpression argument, JetBrains.Metadata.Reader.API.IMetadataType targetType) { }
        public static JetBrains.Decompiler.Ast.IUnpinStatement CreateUnpin(JetBrains.Decompiler.Ast.ILocalVariableReferenceExpression variableReference) { }
        public static JetBrains.Decompiler.Ast.IUntypedStackAllocExpression CreateUntypedStackAlloc(JetBrains.Decompiler.Ast.IExpression length) { }
        public static JetBrains.Decompiler.Ast.IUserDefinedBinaryOperationExpression CreateUserDefinedBinaryOperation(JetBrains.Decompiler.Ast.OperationType operationType, JetBrains.Metadata.Reader.API.MethodSpecification methodSpecification, JetBrains.Metadata.Reader.API.IMetadataType resultType, JetBrains.Decompiler.Ast.IExpression leftArgument, JetBrains.Decompiler.Ast.IExpression rightArgument) { }
        public static JetBrains.Decompiler.Ast.IUserDefinedTypeCastExpression CreateUserDefinedTypeCast(JetBrains.Metadata.Reader.API.MethodSpecification methodSpecification, JetBrains.Decompiler.Ast.IExpression argument, JetBrains.Metadata.Reader.API.IMetadataType targetType) { }
        public static JetBrains.Decompiler.Ast.IUserDefinedUnaryOperationExpression CreateUserDefinedUnaryOperation(JetBrains.Decompiler.Ast.OperationType operationType, JetBrains.Metadata.Reader.API.MethodSpecification methodSpecification, JetBrains.Metadata.Reader.API.IMetadataType resultType, JetBrains.Decompiler.Ast.IExpression argument) { }
        public static JetBrains.Decompiler.Ast.IUsingStatement CreateUsing(JetBrains.Decompiler.Ast.ILocalVariableReferenceExpression variableReference, JetBrains.Decompiler.Ast.IExpression expression, JetBrains.Decompiler.Ast.IStatement body) { }
        public static JetBrains.Decompiler.Ast.IVirtualMethodPointerExpression CreateVirtualMethodPointer(JetBrains.Metadata.Reader.API.MethodInstantiation methodInstantiation, JetBrains.Decompiler.Ast.IExpression target) { }
        public static JetBrains.Decompiler.Ast.IYieldBreakStatement CreateYieldBreak() { }
        public static JetBrains.Decompiler.Ast.IYieldReturnStatement CreateYieldReturn(JetBrains.Decompiler.Ast.IExpression result) { }
    }
    public class Constant : System.IEquatable<JetBrains.Decompiler.Ast.Constant>
    {
        public static readonly JetBrains.Decompiler.Ast.Constant Null;
        public JetBrains.Metadata.Reader.API.ElementType ElementType { get; }
        public bool IsNull { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.Metadata.Reader.API.IMetadataType Type { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public object Value { get; }
        public T As<T>() { }
        public bool Equals(JetBrains.Decompiler.Ast.Constant other) { }
        public override bool Equals(object obj) { }
        public static JetBrains.Decompiler.Ast.Constant FromValueAndType([JetBrains.Annotations.CanBeNullAttribute()] object value, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Metadata.Reader.API.IMetadataType type) { }
        public override int GetHashCode() { }
        public bool Is<T>() { }
        public override string ToString() { }
    }
    public enum FunctionSignatureStyle
    {
        Full = 0,
        Compact = 1,
        CompactSingle = 2,
    }
    public interface IAbstractBinaryOperationExpression : JetBrains.Decompiler.Ast.IExpression, JetBrains.Decompiler.Ast.INode, System.ICloneable
    {
        JetBrains.Decompiler.Ast.IExpression LeftArgument { get; set; }
        JetBrains.Decompiler.Ast.OperationType OperationType { get; set; }
        JetBrains.Decompiler.Ast.IExpression RightArgument { get; set; }
    }
    public interface IAbstractGotoStatement : JetBrains.Decompiler.Ast.INode, JetBrains.Decompiler.Ast.IStatement, System.ICloneable { }
    public interface IAbstractLoopStatement : JetBrains.Decompiler.Ast.INode, JetBrains.Decompiler.Ast.IStatement, System.ICloneable
    {
        JetBrains.Decompiler.Ast.IStatement Body { get; set; }
    }
    public interface IAbstractTypeCastExpression : JetBrains.Decompiler.Ast.IExpression, JetBrains.Decompiler.Ast.INode, System.ICloneable
    {
        JetBrains.Decompiler.Ast.IExpression Argument { get; set; }
        JetBrains.Metadata.Reader.API.IMetadataType TargetType { get; set; }
    }
    public interface IAbstractUnaryOperationExpression : JetBrains.Decompiler.Ast.IExpression, JetBrains.Decompiler.Ast.INode, System.ICloneable
    {
        JetBrains.Decompiler.Ast.IExpression Argument { get; set; }
        JetBrains.Decompiler.Ast.OperationType OperationType { get; set; }
    }
    public interface IAddressOfExpression : JetBrains.Decompiler.Ast.IExpression, JetBrains.Decompiler.Ast.INode, System.ICloneable
    {
        JetBrains.Decompiler.Ast.IExpression Argument { get; set; }
    }
    public interface IAnonymousMethodExpression : JetBrains.Decompiler.Ast.ICreationExpression, JetBrains.Decompiler.Ast.IExpression, JetBrains.Decompiler.Ast.ILocalVariableDeclarationScopeOwner, JetBrains.Decompiler.Ast.INode, System.ICloneable
    {
        JetBrains.Decompiler.Ast.IBlockStatement Body { get; set; }
        JetBrains.Decompiler.Ast.IFunctionSignature Signature { get; set; }
    }
    public interface IAnonymousObjectCreationExpression : JetBrains.Decompiler.Ast.ICreationExpression, JetBrains.Decompiler.Ast.IExpression, JetBrains.Decompiler.Ast.INode, System.ICloneable
    {
        JetBrains.Decompiler.Ast.ILocalVariableDeclarationScope DeclarationScope { get; }
        JetBrains.Decompiler.Ast.IMemberInitializerList Initializer { get; set; }
    }
    public interface IArgListCreationExpression : JetBrains.Decompiler.Ast.IExpression, JetBrains.Decompiler.Ast.INode, System.ICloneable
    {
        JetBrains.Decompiler.Ast.IExpression[] Arguments { get; set; }
    }
    public interface IArgListReferenceExpression : JetBrains.Decompiler.Ast.IExpression, JetBrains.Decompiler.Ast.INode, System.ICloneable { }
    public interface IArrayCreationExpression : JetBrains.Decompiler.Ast.ICreationExpression, JetBrains.Decompiler.Ast.IExpression, JetBrains.Decompiler.Ast.INode, System.ICloneable
    {
        JetBrains.Metadata.Reader.API.IMetadataArrayType ArrayType { get; }
        JetBrains.Decompiler.Ast.IExpression[] Dimensions { get; set; }
        JetBrains.Decompiler.Ast.IExpressionList Initializer { get; set; }
    }
    public interface IArrayElementAccessExpression : JetBrains.Decompiler.Ast.IExpression, JetBrains.Decompiler.Ast.INode, System.ICloneable
    {
        JetBrains.Decompiler.Ast.IExpression Array { get; set; }
        JetBrains.Decompiler.Ast.IExpression[] Indexes { get; set; }
    }
    public interface IAwaitExpression : JetBrains.Decompiler.Ast.IExpression, JetBrains.Decompiler.Ast.INode, System.ICloneable
    {
        JetBrains.Decompiler.Ast.IExpression Argument { get; set; }
        JetBrains.Metadata.Reader.API.IMetadataType ResultType { get; }
    }
    public interface IBaseReferenceExpression : JetBrains.Decompiler.Ast.IExpression, JetBrains.Decompiler.Ast.INode, System.ICloneable { }
    public interface IBinaryOperationExpression : JetBrains.Decompiler.Ast.IAbstractBinaryOperationExpression, JetBrains.Decompiler.Ast.IExpression, JetBrains.Decompiler.Ast.INode, JetBrains.Decompiler.Ast.IOverflowCheckExpression, System.ICloneable { }
    public interface IBlockStatement : JetBrains.Decompiler.Ast.INode, JetBrains.Decompiler.Ast.IStatement, System.ICloneable
    {
        JetBrains.Decompiler.Ast.INodeList<JetBrains.Decompiler.Ast.IStatement> Statements { get; }
    }
    public interface IBoxExpression : JetBrains.Decompiler.Ast.IExpression, JetBrains.Decompiler.Ast.INode, System.ICloneable
    {
        JetBrains.Decompiler.Ast.IExpression Argument { get; set; }
        JetBrains.Metadata.Reader.API.IMetadataType SourceType { get; }
    }
    public interface IBreakStatement : JetBrains.Decompiler.Ast.IAbstractGotoStatement, JetBrains.Decompiler.Ast.INode, JetBrains.Decompiler.Ast.IStatement, System.ICloneable { }
    public interface ICatchClause : JetBrains.Decompiler.Ast.INode, System.ICloneable
    {
        JetBrains.Decompiler.Ast.IBlockStatement Body { get; set; }
        JetBrains.Decompiler.Ast.ILocalVariableReferenceExpression VariableReference { get; set; }
    }
    public interface ICheckCastExpression : JetBrains.Decompiler.Ast.IExpression, JetBrains.Decompiler.Ast.INode, System.ICloneable
    {
        JetBrains.Decompiler.Ast.IExpression Argument { get; set; }
        JetBrains.Metadata.Reader.API.IMetadataType Type { get; }
    }
    public interface ICheckFiniteExpression : JetBrains.Decompiler.Ast.IExpression, JetBrains.Decompiler.Ast.INode, System.ICloneable
    {
        JetBrains.Decompiler.Ast.IExpression Expression { get; set; }
    }
    public interface ICommentStatement : JetBrains.Decompiler.Ast.INode, JetBrains.Decompiler.Ast.IStatement, System.ICloneable
    {
        string Text { get; }
    }
    public interface IConditionalExpression : JetBrains.Decompiler.Ast.IExpression, JetBrains.Decompiler.Ast.INode, System.ICloneable
    {
        JetBrains.Decompiler.Ast.IExpression Condition { get; set; }
        JetBrains.Decompiler.Ast.IExpression Else { get; set; }
        JetBrains.Decompiler.Ast.IExpression Then { get; set; }
    }
    public interface IContinueStatement : JetBrains.Decompiler.Ast.IAbstractGotoStatement, JetBrains.Decompiler.Ast.INode, JetBrains.Decompiler.Ast.IStatement, System.ICloneable { }
    public interface ICreationExpression : JetBrains.Decompiler.Ast.IExpression, JetBrains.Decompiler.Ast.INode, System.ICloneable
    {
        JetBrains.Metadata.Reader.API.IMetadataType ConstructedType { get; }
    }
    public interface IDecompiledClass
    {
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.Decompiler.Utils.DataHolder Data { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.IList<JetBrains.Decompiler.Ast.IDecompiledEvent> Events { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.IList<JetBrains.Decompiler.Ast.IDecompiledField> Fields { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.IList<JetBrains.Decompiler.Ast.IDecompiledMethod> Methods { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.IList<JetBrains.Metadata.Reader.API.IMetadataTypeInfo> NestedTypes { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.IList<JetBrains.Decompiler.Ast.IDecompiledProperty> Properties { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.Metadata.Reader.API.IMetadataTypeInfo TypeInfo { get; }
    }
    public interface IDecompiledClassMember
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.Decompiler.Ast.IDecompiledClass OwnerClass { get; }
    }
    public interface IDecompiledEvent : JetBrains.Decompiler.Ast.IDecompiledClassMember
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.Decompiler.Ast.IDecompiledMethod Adder { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.Decompiler.Ast.IExpression Initializer { get; set; }
        bool IsFieldLike { get; set; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.Metadata.Reader.API.IMetadataEvent MetadataEvent { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.Decompiler.Ast.IDecompiledMethod Remover { get; }
    }
    public interface IDecompiledField : JetBrains.Decompiler.Ast.IDecompiledClassMember
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.Decompiler.Ast.IExpression Initializer { get; set; }
        bool IsUnsafe { get; set; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.Metadata.Reader.API.IMetadataField MetadataField { get; }
    }
    public interface IDecompiledMethod : JetBrains.Decompiler.Ast.IDecompiledClassMember, JetBrains.Decompiler.Ast.ILocalVariableDeclarationScopeOwner, JetBrains.Decompiler.Ast.INode, System.ICloneable
    {
        JetBrains.Decompiler.Ast.IBlockStatement Body { get; set; }
        new JetBrains.Decompiler.Ast.ILocalVariableDeclarationScope DeclarationScope { get; }
        JetBrains.Decompiler.Ast.IMethodCallExpression Initializer { get; set; }
        bool IsIterator { get; set; }
        bool IsUnsafe { get; set; }
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.ICollection<JetBrains.Decompiler.Ast.ILabel> Labels { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.ICollection<JetBrains.Decompiler.Ast.ILocalVariable> LocalVariables { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.Metadata.Reader.API.IMetadataMethod MetadataMethod { get; }
        JetBrains.Decompiler.Ast.IFunctionSignature Signature { get; set; }
    }
    public interface IDecompiledProperty : JetBrains.Decompiler.Ast.IDecompiledClassMember
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.Decompiler.Ast.IDecompiledMethod Getter { get; set; }
        bool IsAuto { get; set; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.Metadata.Reader.API.IMetadataProperty MetadataProperty { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.Decompiler.Ast.IDecompiledMethod Setter { get; set; }
    }
    public interface IDefaultValueExpression : JetBrains.Decompiler.Ast.IExpression, JetBrains.Decompiler.Ast.INode, System.ICloneable
    {
        JetBrains.Metadata.Reader.API.IMetadataType Type { get; }
    }
    public interface IDelegateCallExpression : JetBrains.Decompiler.Ast.IExpression, JetBrains.Decompiler.Ast.INode, System.ICloneable
    {
        JetBrains.Decompiler.Ast.IExpression[] Arguments { get; set; }
        JetBrains.Decompiler.Ast.IExpression Delegate { get; set; }
        JetBrains.Metadata.Reader.API.MethodSpecification InvokeSpecification { get; }
    }
    public interface IDelegateCreationExpression : JetBrains.Decompiler.Ast.ICreationExpression, JetBrains.Decompiler.Ast.IExpression, JetBrains.Decompiler.Ast.INode, System.ICloneable
    {
        bool IsStatic { get; }
        JetBrains.Metadata.Reader.API.MethodInstantiation MethodInstantiation { get; }
        JetBrains.Decompiler.Ast.IExpression Target { get; set; }
    }
    public interface IDerefExpression : JetBrains.Decompiler.Ast.IExpression, JetBrains.Decompiler.Ast.INode, System.ICloneable
    {
        JetBrains.Decompiler.Ast.IExpression Argument { get; set; }
        bool Implicit { get; set; }
    }
    public interface IEmptyStatement : JetBrains.Decompiler.Ast.INode, JetBrains.Decompiler.Ast.IStatement, System.ICloneable { }
    public interface IEndFinallyStatement : JetBrains.Decompiler.Ast.INode, JetBrains.Decompiler.Ast.IStatement, System.ICloneable { }
    public interface IEventAccessExpression : JetBrains.Decompiler.Ast.IExpression, JetBrains.Decompiler.Ast.IMemberAccessExpression, JetBrains.Decompiler.Ast.IMemberCallExpression, JetBrains.Decompiler.Ast.INode, System.ICloneable
    {
        JetBrains.Decompiler.Metadata.EventSpecification EventSpecification { get; }
    }
    public interface IExpression : JetBrains.Decompiler.Ast.INode, System.ICloneable { }
    public interface IExpressionList : JetBrains.Decompiler.Ast.IExpression, JetBrains.Decompiler.Ast.INode, System.ICloneable
    {
        JetBrains.Decompiler.Ast.INodeList<JetBrains.Decompiler.Ast.IExpression> Expressions { get; }
    }
    public interface IExpressionStatement : JetBrains.Decompiler.Ast.INode, JetBrains.Decompiler.Ast.IStatement, System.ICloneable
    {
        JetBrains.Decompiler.Ast.IExpression Expression { get; set; }
    }
    public interface IFieldAccessExpression : JetBrains.Decompiler.Ast.IExpression, JetBrains.Decompiler.Ast.IMemberAccessExpression, JetBrains.Decompiler.Ast.INode, System.ICloneable
    {
        JetBrains.Metadata.Reader.API.FieldSpecification FieldSpecification { get; }
    }
    public interface IFieldMemberInitializer : JetBrains.Decompiler.Ast.IMemberInitializer, JetBrains.Decompiler.Ast.INode, System.ICloneable
    {
        JetBrains.Metadata.Reader.API.IMetadataField Field { get; }
    }
    public interface IFieldReferenceExpression : JetBrains.Decompiler.Ast.IExpression, JetBrains.Decompiler.Ast.INode, System.ICloneable
    {
        JetBrains.Metadata.Reader.API.FieldSpecification FieldSpecification { get; }
    }
    public interface IFixedStatement : JetBrains.Decompiler.Ast.INode, JetBrains.Decompiler.Ast.IStatement, System.ICloneable
    {
        JetBrains.Decompiler.Ast.IStatement Body { get; set; }
        JetBrains.Decompiler.Ast.IExpression Initializer { get; set; }
        JetBrains.Decompiler.Ast.ILocalVariableReferenceExpression VariableReference { get; set; }
    }
    public interface IForEachStatement : JetBrains.Decompiler.Ast.IAbstractLoopStatement, JetBrains.Decompiler.Ast.INode, JetBrains.Decompiler.Ast.IStatement, System.ICloneable
    {
        JetBrains.Decompiler.Ast.IExpression Expression { get; set; }
        JetBrains.Decompiler.Ast.ILocalVariableReferenceExpression VariableReference { get; set; }
    }
    public interface IForStatement : JetBrains.Decompiler.Ast.IAbstractLoopStatement, JetBrains.Decompiler.Ast.INode, JetBrains.Decompiler.Ast.IStatement, System.ICloneable
    {
        JetBrains.Decompiler.Ast.IExpression Condition { get; set; }
        JetBrains.Decompiler.Ast.IStatement Initializer { get; set; }
        JetBrains.Decompiler.Ast.IStatement Iterator { get; set; }
    }
    public interface IFunctionPointerCallExpression : JetBrains.Decompiler.Ast.IExpression, JetBrains.Decompiler.Ast.INode, System.ICloneable
    {
        JetBrains.Decompiler.Ast.IExpression[] Arguments { get; set; }
        JetBrains.Decompiler.Ast.IExpression FunctionPointer { get; set; }
    }
    public interface IFunctionSignature : JetBrains.Decompiler.Ast.INode, System.ICloneable
    {
        bool HasArgList { get; set; }
        bool IsAsync { get; set; }
        System.Collections.Generic.IList<JetBrains.Decompiler.Ast.IMethodParameter> Parameters { get; }
        JetBrains.Decompiler.Ast.FunctionSignatureStyle Style { get; set; }
    }
    public interface IGotoCaseStatement : JetBrains.Decompiler.Ast.IAbstractGotoStatement, JetBrains.Decompiler.Ast.INode, JetBrains.Decompiler.Ast.IStatement, System.ICloneable
    {
        JetBrains.Decompiler.Ast.Constant CaseValue { get; }
    }
    public interface IGotoDefaultStatement : JetBrains.Decompiler.Ast.IAbstractGotoStatement, JetBrains.Decompiler.Ast.INode, JetBrains.Decompiler.Ast.IStatement, System.ICloneable { }
    public interface IGotoStatement : JetBrains.Decompiler.Ast.IAbstractGotoStatement, JetBrains.Decompiler.Ast.INode, JetBrains.Decompiler.Ast.IStatement, System.ICloneable
    {
        JetBrains.Decompiler.Ast.ILabel Label { get; }
    }
    public interface IIfStatement : JetBrains.Decompiler.Ast.INode, JetBrains.Decompiler.Ast.IStatement, System.ICloneable
    {
        JetBrains.Decompiler.Ast.IExpression Condition { get; set; }
        JetBrains.Decompiler.Ast.IStatement Else { get; set; }
        JetBrains.Decompiler.Ast.IStatement Then { get; set; }
    }
    public interface IIndexerCallExpression : JetBrains.Decompiler.Ast.IExpression, JetBrains.Decompiler.Ast.IMemberAccessExpression, JetBrains.Decompiler.Ast.IMemberCallExpression, JetBrains.Decompiler.Ast.INode, System.ICloneable
    {
        JetBrains.Decompiler.Ast.IExpression[] Arguments { get; set; }
        JetBrains.Decompiler.Metadata.PropertySpecification PropertySpecification { get; }
    }
    public interface IJumpStatement : JetBrains.Decompiler.Ast.INode, JetBrains.Decompiler.Ast.IStatement, System.ICloneable
    {
        JetBrains.Metadata.Reader.API.MethodInstantiation MethodInstantiation { get; }
    }
    public interface ILabel
    {
        JetBrains.Decompiler.Ast.IDecompiledMethod Method { get; }
        string Name { get; }
    }
    public interface ILabelDeclarationStatement : JetBrains.Decompiler.Ast.INode, JetBrains.Decompiler.Ast.IStatement, System.ICloneable
    {
        JetBrains.Decompiler.Ast.ILabel Label { get; }
    }
    public interface ILambdaBlockExpression : JetBrains.Decompiler.Ast.ICreationExpression, JetBrains.Decompiler.Ast.IExpression, JetBrains.Decompiler.Ast.ILocalVariableDeclarationScopeOwner, JetBrains.Decompiler.Ast.INode, System.ICloneable
    {
        JetBrains.Decompiler.Ast.IBlockStatement Body { get; set; }
        new JetBrains.Decompiler.Ast.ILocalVariableDeclarationScope DeclarationScope { get; }
        JetBrains.Decompiler.Ast.IFunctionSignature Signature { get; set; }
    }
    public interface ILambdaExpression : JetBrains.Decompiler.Ast.ICreationExpression, JetBrains.Decompiler.Ast.IExpression, JetBrains.Decompiler.Ast.INode, System.ICloneable
    {
        JetBrains.Decompiler.Ast.IExpression Body { get; set; }
        JetBrains.Decompiler.Ast.IFunctionSignature Signature { get; set; }
    }
    public interface ILiteralExpression : JetBrains.Decompiler.Ast.IExpression, JetBrains.Decompiler.Ast.INode, System.ICloneable
    {
        JetBrains.Decompiler.Ast.Constant Value { get; }
    }
    public interface ILocalVariable
    {
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.Decompiler.Ast.ILocalVariableDeclarationScope DeclarationScope { get; }
        JetBrains.Decompiler.Ast.LocalVariableKind Kind { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.Metadata.Reader.API.IMetadataField MetadataField { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.Metadata.Reader.API.IMethodBodyLocalVariable MetadataVariable { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.Decompiler.Ast.IDecompiledMethod Method { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        string Name { get; set; }
        JetBrains.Metadata.Reader.API.IMetadataType Type { get; set; }
    }
    public interface ILocalVariableDeclarationScope { }
    public interface ILocalVariableDeclarationScopeOwner : JetBrains.Decompiler.Ast.INode, System.ICloneable
    {
        JetBrains.Decompiler.Ast.ILocalVariableDeclarationScope DeclarationScope { get; }
    }
    public interface ILocalVariableDeclarationStatement : JetBrains.Decompiler.Ast.INode, JetBrains.Decompiler.Ast.IStatement, System.ICloneable
    {
        JetBrains.Decompiler.Ast.IExpression Initializer { get; set; }
        JetBrains.Decompiler.Ast.ILocalVariableReferenceExpression VariableReference { get; set; }
    }
    public interface ILocalVariableReferenceExpression : JetBrains.Decompiler.Ast.IExpression, JetBrains.Decompiler.Ast.INode, System.ICloneable
    {
        JetBrains.Decompiler.Ast.ILocalVariable Variable { get; }
    }
    public interface ILockStatement : JetBrains.Decompiler.Ast.INode, JetBrains.Decompiler.Ast.IStatement, System.ICloneable
    {
        JetBrains.Decompiler.Ast.IStatement Body { get; set; }
        JetBrains.Decompiler.Ast.IExpression Expression { get; set; }
    }
    public interface ILoopStatement : JetBrains.Decompiler.Ast.IAbstractLoopStatement, JetBrains.Decompiler.Ast.INode, JetBrains.Decompiler.Ast.IStatement, System.ICloneable
    {
        JetBrains.Decompiler.Ast.IExpression Condition { get; set; }
        JetBrains.Decompiler.Ast.LoopType LoopType { get; }
    }
    public interface IMakeRefExpression : JetBrains.Decompiler.Ast.IExpression, JetBrains.Decompiler.Ast.INode, System.ICloneable
    {
        JetBrains.Decompiler.Ast.IExpression Argument { get; set; }
    }
    public interface IMemberAccessExpression : JetBrains.Decompiler.Ast.IExpression, JetBrains.Decompiler.Ast.INode, System.ICloneable
    {
        JetBrains.Decompiler.Ast.MemberAccessKind AccessKind { get; }
        bool IsStatic { get; }
        JetBrains.Decompiler.Ast.IExpression Target { get; set; }
    }
    public interface IMemberCallExpression : JetBrains.Decompiler.Ast.IExpression, JetBrains.Decompiler.Ast.IMemberAccessExpression, JetBrains.Decompiler.Ast.INode, System.ICloneable
    {
        bool IsVirtual { get; }
    }
    public interface IMemberInitializer : JetBrains.Decompiler.Ast.INode, System.ICloneable
    {
        JetBrains.Decompiler.Ast.IExpression Value { get; set; }
    }
    public interface IMemberInitializerList : JetBrains.Decompiler.Ast.IExpression, JetBrains.Decompiler.Ast.INode, System.ICloneable
    {
        JetBrains.Decompiler.Ast.INodeList<JetBrains.Decompiler.Ast.IMemberInitializer> Initializers { get; }
    }
    public interface IMemoryCopyStatement : JetBrains.Decompiler.Ast.INode, JetBrains.Decompiler.Ast.IStatement, System.ICloneable
    {
        JetBrains.Decompiler.Ast.IExpression Destination { get; set; }
        JetBrains.Decompiler.Ast.IExpression Length { get; set; }
        JetBrains.Decompiler.Ast.IExpression Source { get; set; }
    }
    public interface IMemoryInitializeStatement : JetBrains.Decompiler.Ast.INode, JetBrains.Decompiler.Ast.IStatement, System.ICloneable
    {
        JetBrains.Decompiler.Ast.IExpression Destination { get; set; }
        JetBrains.Decompiler.Ast.IExpression Length { get; set; }
        JetBrains.Decompiler.Ast.IExpression Value { get; set; }
    }
    public interface IMethodCallExpression : JetBrains.Decompiler.Ast.IExpression, JetBrains.Decompiler.Ast.IMemberAccessExpression, JetBrains.Decompiler.Ast.IMemberCallExpression, JetBrains.Decompiler.Ast.INode, System.ICloneable
    {
        JetBrains.Decompiler.Ast.IExpression[] Arguments { get; set; }
        JetBrains.Metadata.Reader.API.MethodInstantiation MethodInstantiation { get; }
    }
    public interface IMethodParameter
    {
        int Index { get; set; }
        JetBrains.Decompiler.Ast.MethodParameterKind Kind { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.Metadata.Reader.API.IMetadataParameter MetadataParameter { get; }
        JetBrains.Decompiler.Ast.IDecompiledMethod Method { get; }
        string Name { get; set; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.Metadata.Reader.API.IMetadataType Type { get; }
    }
    public interface IMethodPointerExpression : JetBrains.Decompiler.Ast.IExpression, JetBrains.Decompiler.Ast.INode, System.ICloneable
    {
        JetBrains.Metadata.Reader.API.MethodInstantiation MethodInstantiation { get; }
    }
    public interface IMethodReferenceExpression : JetBrains.Decompiler.Ast.IExpression, JetBrains.Decompiler.Ast.INode, System.ICloneable
    {
        JetBrains.Metadata.Reader.API.MethodInstantiation MethodInstantiation { get; }
    }
    public interface INestedInitializer : JetBrains.Decompiler.Ast.IExpression, JetBrains.Decompiler.Ast.INode, System.ICloneable
    {
        JetBrains.Decompiler.Ast.IExpressionList CollectionInitializer { get; set; }
        JetBrains.Decompiler.Ast.IMemberInitializerList ObjectInitializer { get; set; }
    }
    public interface INode : System.ICloneable
    {
        System.Collections.Generic.IEnumerable<JetBrains.Decompiler.Ast.INode> Children { get; }
        JetBrains.Decompiler.Ast.INodeContainer Container { get; }
        JetBrains.Decompiler.Utils.DataHolder Data { get; }
        System.Collections.Generic.IEqualityComparer<JetBrains.Decompiler.Ast.INode> DeepEqualityComparer { get; }
        bool IsAttached { get; }
        JetBrains.Decompiler.Ast.INode Parent { get; }
        JetBrains.Decompiler.Ast.INode GetLeftSibling(JetBrains.Decompiler.Ast.INode child);
        JetBrains.Decompiler.Ast.INode GetRightSibling(JetBrains.Decompiler.Ast.INode child);
        void ReplaceChild(JetBrains.Decompiler.Ast.INode oldChild, JetBrains.Decompiler.Ast.INode newChild);
    }
    public interface INodeContainer
    {
        System.Collections.Generic.ICollection<JetBrains.Decompiler.Ast.INode> Nodes { get; }
        public event System.EventHandler<JetBrains.DataFlow.EventArgs<JetBrains.Decompiler.Ast.INode>> NodeAttached;
        public event System.EventHandler<JetBrains.DataFlow.EventArgs<JetBrains.Decompiler.Ast.INode>> NodeDetached;
        void AttachTree(JetBrains.Decompiler.Ast.INode root);
        void DetachTree(JetBrains.Decompiler.Ast.INode root);
    }
    public interface INodeList<T> : System.Collections.Generic.ICollection<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable
    
    {
        T First { get; }
        T Last { get; }
        void AddAfter(T anchor, T node);
        void AddBack(T node);
        void AddBefore(T anchor, T node);
        void AddFront(T node);
        T GetNext(T node);
        T GetPrevious(T node);
        void Replace(T oldNode, T newNode);
    }
    public interface IObjectCreationExpression : JetBrains.Decompiler.Ast.ICreationExpression, JetBrains.Decompiler.Ast.IExpression, JetBrains.Decompiler.Ast.INode, System.ICloneable
    {
        JetBrains.Decompiler.Ast.IExpression[] Arguments { get; set; }
        JetBrains.Decompiler.Ast.IExpressionList CollectionInitializer { get; set; }
        JetBrains.Metadata.Reader.API.MethodSpecification ConstructorSpecification { get; }
        JetBrains.Decompiler.Ast.IMemberInitializerList ObjectInitializer { get; set; }
    }
    public interface IOverflowCheckExpression : JetBrains.Decompiler.Ast.IExpression, JetBrains.Decompiler.Ast.INode, System.ICloneable
    {
        JetBrains.Decompiler.Ast.OverflowCheckType OverflowCheck { get; }
    }
    public interface IParameterModifierExpression : JetBrains.Decompiler.Ast.IExpression, JetBrains.Decompiler.Ast.INode, System.ICloneable
    {
        JetBrains.Decompiler.Ast.IExpression Argument { get; set; }
        JetBrains.Decompiler.Ast.ParameterModifierKind ModifierKind { get; }
    }
    public interface IParameterReferenceExpression : JetBrains.Decompiler.Ast.IExpression, JetBrains.Decompiler.Ast.INode, System.ICloneable
    {
        JetBrains.Decompiler.Ast.IMethodParameter Parameter { get; }
    }
    public interface IPinStatement : JetBrains.Decompiler.Ast.INode, JetBrains.Decompiler.Ast.IStatement, System.ICloneable
    {
        JetBrains.Decompiler.Ast.IExpression Initializer { get; set; }
        JetBrains.Decompiler.Ast.ILocalVariableReferenceExpression VariableReference { get; set; }
    }
    public interface IPointerElementAccessExpression : JetBrains.Decompiler.Ast.IExpression, JetBrains.Decompiler.Ast.INode, System.ICloneable
    {
        JetBrains.Decompiler.Ast.IExpression Index { get; set; }
        JetBrains.Decompiler.Ast.IExpression Pointer { get; set; }
    }
    public interface IPointerIndirectionExpression : JetBrains.Decompiler.Ast.IExpression, JetBrains.Decompiler.Ast.INode, System.ICloneable
    {
        JetBrains.Decompiler.Ast.IExpression Argument { get; set; }
    }
    public interface IPropertyAccessExpression : JetBrains.Decompiler.Ast.IExpression, JetBrains.Decompiler.Ast.IMemberAccessExpression, JetBrains.Decompiler.Ast.IMemberCallExpression, JetBrains.Decompiler.Ast.INode, System.ICloneable
    {
        JetBrains.Decompiler.Metadata.PropertySpecification PropertySpecification { get; }
    }
    public interface IPropertyMemberInitializer : JetBrains.Decompiler.Ast.IMemberInitializer, JetBrains.Decompiler.Ast.INode, System.ICloneable
    {
        JetBrains.Metadata.Reader.API.IMetadataProperty Property { get; }
    }
    public interface IRefExpression : JetBrains.Decompiler.Ast.IExpression, JetBrains.Decompiler.Ast.INode, System.ICloneable
    {
        JetBrains.Decompiler.Ast.IExpression Argument { get; set; }
        bool Implicit { get; set; }
    }
    public interface IRefTypeExpression : JetBrains.Decompiler.Ast.IExpression, JetBrains.Decompiler.Ast.INode, System.ICloneable
    {
        JetBrains.Decompiler.Ast.IExpression Argument { get; set; }
    }
    public interface IRefTypeTokenExpression : JetBrains.Decompiler.Ast.IExpression, JetBrains.Decompiler.Ast.INode, System.ICloneable
    {
        JetBrains.Decompiler.Ast.IExpression Argument { get; set; }
    }
    public interface IRefValueExpression : JetBrains.Decompiler.Ast.IExpression, JetBrains.Decompiler.Ast.INode, System.ICloneable
    {
        JetBrains.Decompiler.Ast.IExpression Argument { get; set; }
        JetBrains.Metadata.Reader.API.IMetadataType Type { get; }
    }
    public interface IRethrowStatement : JetBrains.Decompiler.Ast.INode, JetBrains.Decompiler.Ast.IStatement, System.ICloneable { }
    public interface IReturnStatement : JetBrains.Decompiler.Ast.INode, JetBrains.Decompiler.Ast.IStatement, System.ICloneable
    {
        JetBrains.Decompiler.Ast.IExpression Result { get; set; }
    }
    public interface ISizeOfExpression : JetBrains.Decompiler.Ast.IExpression, JetBrains.Decompiler.Ast.INode, System.ICloneable
    {
        JetBrains.Metadata.Reader.API.IMetadataType Type { get; }
    }
    public interface IStackAllocExpression : JetBrains.Decompiler.Ast.IExpression, JetBrains.Decompiler.Ast.INode, System.ICloneable
    {
        JetBrains.Metadata.Reader.API.IMetadataType ElementType { get; }
        JetBrains.Decompiler.Ast.IExpression Length { get; set; }
    }
    public interface IStatement : JetBrains.Decompiler.Ast.INode, System.ICloneable { }
    public interface ISwitchCase : JetBrains.Decompiler.Ast.INode, System.ICloneable
    {
        JetBrains.Decompiler.Ast.IBlockStatement Body { get; set; }
        JetBrains.Decompiler.Ast.IExpression[] Values { get; set; }
    }
    public interface ISwitchStatement : JetBrains.Decompiler.Ast.INode, JetBrains.Decompiler.Ast.IStatement, System.ICloneable
    {
        JetBrains.Decompiler.Ast.ISwitchCase[] Cases { get; set; }
        JetBrains.Decompiler.Ast.IBlockStatement Default { get; set; }
        JetBrains.Decompiler.Ast.IExpression Expression { get; set; }
    }
    public interface IThisReferenceExpression : JetBrains.Decompiler.Ast.IExpression, JetBrains.Decompiler.Ast.INode, System.ICloneable { }
    public interface IThrowStatement : JetBrains.Decompiler.Ast.INode, JetBrains.Decompiler.Ast.IStatement, System.ICloneable
    {
        JetBrains.Decompiler.Ast.IExpression Argument { get; set; }
    }
    public interface ITryCastExpression : JetBrains.Decompiler.Ast.IExpression, JetBrains.Decompiler.Ast.INode, System.ICloneable
    {
        JetBrains.Decompiler.Ast.IExpression Argument { get; set; }
        JetBrains.Metadata.Reader.API.IMetadataType Type { get; }
    }
    public interface ITryStatement : JetBrains.Decompiler.Ast.INode, JetBrains.Decompiler.Ast.IStatement, System.ICloneable
    {
        JetBrains.Decompiler.Ast.IBlockStatement Body { get; set; }
        JetBrains.Decompiler.Ast.ICatchClause[] CatchClauses { get; set; }
        JetBrains.Decompiler.Ast.IBlockStatement Fault { get; set; }
        JetBrains.Decompiler.Ast.IBlockStatement Finally { get; set; }
    }
    public interface ITypeCastExpression : JetBrains.Decompiler.Ast.IAbstractTypeCastExpression, JetBrains.Decompiler.Ast.IExpression, JetBrains.Decompiler.Ast.INode, JetBrains.Decompiler.Ast.IOverflowCheckExpression, System.ICloneable { }
    public interface ITypeOfExpression : JetBrains.Decompiler.Ast.IExpression, JetBrains.Decompiler.Ast.INode, System.ICloneable
    {
        JetBrains.Metadata.Reader.API.IMetadataType Type { get; }
    }
    public interface ITypeReferenceExpression : JetBrains.Decompiler.Ast.IExpression, JetBrains.Decompiler.Ast.INode, System.ICloneable
    {
        JetBrains.Metadata.Reader.API.IMetadataType Type { get; }
    }
    public interface IUnaryOperationExpression : JetBrains.Decompiler.Ast.IAbstractUnaryOperationExpression, JetBrains.Decompiler.Ast.IExpression, JetBrains.Decompiler.Ast.INode, JetBrains.Decompiler.Ast.IOverflowCheckExpression, System.ICloneable { }
    public interface IUnboxExpression : JetBrains.Decompiler.Ast.IExpression, JetBrains.Decompiler.Ast.INode, System.ICloneable
    {
        JetBrains.Decompiler.Ast.IExpression Argument { get; set; }
        JetBrains.Metadata.Reader.API.IMetadataType TargetType { get; }
    }
    public interface IUnpinStatement : JetBrains.Decompiler.Ast.INode, JetBrains.Decompiler.Ast.IStatement, System.ICloneable
    {
        JetBrains.Decompiler.Ast.ILocalVariableReferenceExpression VariableReference { get; set; }
    }
    public interface IUntypedStackAllocExpression : JetBrains.Decompiler.Ast.IExpression, JetBrains.Decompiler.Ast.INode, System.ICloneable
    {
        JetBrains.Decompiler.Ast.IExpression Length { get; set; }
    }
    public interface IUserDefinedBinaryOperationExpression : JetBrains.Decompiler.Ast.IAbstractBinaryOperationExpression, JetBrains.Decompiler.Ast.IExpression, JetBrains.Decompiler.Ast.INode, System.ICloneable
    {
        JetBrains.Metadata.Reader.API.MethodSpecification MethodSpecification { get; }
        JetBrains.Metadata.Reader.API.IMetadataType ResultType { get; }
    }
    public interface IUserDefinedTypeCastExpression : JetBrains.Decompiler.Ast.IAbstractTypeCastExpression, JetBrains.Decompiler.Ast.IExpression, JetBrains.Decompiler.Ast.INode, System.ICloneable
    {
        JetBrains.Metadata.Reader.API.MethodSpecification MethodSpecification { get; }
    }
    public interface IUserDefinedUnaryOperationExpression : JetBrains.Decompiler.Ast.IAbstractUnaryOperationExpression, JetBrains.Decompiler.Ast.IExpression, JetBrains.Decompiler.Ast.INode, System.ICloneable
    {
        JetBrains.Metadata.Reader.API.MethodSpecification MethodSpecification { get; }
        JetBrains.Metadata.Reader.API.IMetadataType ResultType { get; }
    }
    public interface IUsingStatement : JetBrains.Decompiler.Ast.INode, JetBrains.Decompiler.Ast.IStatement, System.ICloneable
    {
        JetBrains.Decompiler.Ast.IStatement Body { get; set; }
        JetBrains.Decompiler.Ast.IExpression Expression { get; set; }
        JetBrains.Decompiler.Ast.ILocalVariableReferenceExpression VariableReference { get; set; }
    }
    public interface IVirtualMethodPointerExpression : JetBrains.Decompiler.Ast.IExpression, JetBrains.Decompiler.Ast.INode, System.ICloneable
    {
        JetBrains.Metadata.Reader.API.MethodInstantiation MethodInstantiation { get; }
        JetBrains.Decompiler.Ast.IExpression Target { get; set; }
    }
    public interface IYieldBreakStatement : JetBrains.Decompiler.Ast.IAbstractGotoStatement, JetBrains.Decompiler.Ast.INode, JetBrains.Decompiler.Ast.IStatement, System.ICloneable { }
    public interface IYieldReturnStatement : JetBrains.Decompiler.Ast.INode, JetBrains.Decompiler.Ast.IStatement, System.ICloneable
    {
        JetBrains.Decompiler.Ast.IExpression Result { get; set; }
    }
    public enum LocalVariableKind
    {
        Regular = 0,
        Temporary = 1,
        Exception = 2,
        ForEach = 3,
        Using = 4,
        Fixed = 5,
        Closure = 6,
        Iterator = 7,
    }
    public enum LoopType
    {
        Preconditional = 0,
        Postconditional = 1,
        Unconditional = 2,
    }
    public enum MemberAccessKind
    {
        Regular = 0,
        Pointer = 1,
    }
    public enum MethodParameterKind
    {
        Regular = 0,
        AnonymousDelegate = 1,
    }
    public enum OperationType
    {
        Not = 0,
        UnaryPlus = 1,
        UnaryMinus = 2,
        LogicalNeg = 3,
        PrefixIncrement = 4,
        PrefixDecrement = 5,
        PostfixIncrement = 6,
        PostfixDecrement = 7,
        Assignment = 8,
        AssignmentAdd = 9,
        AssignmentSubtract = 10,
        AssignmentMultiply = 11,
        AssignmentDivide = 12,
        AssignmentRemainder = 13,
        AssignmentLogicalAnd = 14,
        AssignmentLogicalOr = 15,
        AssignmentLogicalXor = 16,
        AssignmentShiftLeft = 17,
        AssignmentShiftRight = 18,
        LogicalAnd = 19,
        LogicalOr = 20,
        LogicalXor = 21,
        Equal = 22,
        NotEqual = 23,
        Greater = 24,
        Less = 25,
        GreaterOrEqual = 26,
        LessOrEqual = 27,
        Add = 28,
        Subtract = 29,
        Divide = 30,
        Multiply = 31,
        Remainder = 32,
        ShiftLeft = 33,
        ShiftRight = 34,
        ConditionalAnd = 35,
        ConditionalOr = 36,
        NullCoalescing = 37,
    }
    public enum OverflowCheckType
    {
        Enabled = 0,
        Disabled = 1,
        DontCare = 2,
    }
    public enum ParameterModifierKind
    {
        Ref = 0,
        Out = 1,
    }
}
namespace JetBrains.Decompiler.Baml
{
    
    public class static BamlDecompiler
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public static string ChangeExtension([JetBrains.Annotations.NotNullAttribute()] string name) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static string Decompile([JetBrains.Annotations.NotNullAttribute()] System.IO.Stream stream, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.Decompiler.Baml.TypeSystem.ITypeSystemHelper typeSystemHelper = null, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.Decompiler.Baml.Reader.BamlPredefinedProvider predefinedProvider = null, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.Decompiler.Baml.TypeSystem.INamespaceMappingProvider mappingProvider = null) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static string Decompile([JetBrains.Annotations.NotNullAttribute()] string bamlName, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.FileSystemPath location, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Metadata.Reader.API.IAssemblyResolver resolver) { }
        public static void ForAllBamlResources([JetBrains.Annotations.NotNullAttribute()] JetBrains.Metadata.Reader.API.IMetadataAssembly metadataAssembly, [JetBrains.Annotations.NotNullAttribute()] System.Predicate<string> resourceFilter = null, [JetBrains.Annotations.NotNullAttribute()] System.Action<string, System.IO.Stream> processBaml = null, [JetBrains.Annotations.NotNullAttribute()] System.Action<string, System.IO.Stream> processXaml = null) { }
    }
}
namespace JetBrains.Decompiler.Baml.CacheBuilder
{
    
    public sealed class CacheBuilder : JetBrains.Decompiler.Baml.TreeBuilder.TreeBuilderBase, JetBrains.Decompiler.Baml.Reader.IBamlConsumer
    {
        public CacheBuilder([JetBrains.Annotations.NotNullAttribute()] JetBrains.Decompiler.Baml.Reader.BamlPredefinedProvider predefinedProvider = null) { }
        public bool IsProcessingFinished { get; }
        protected override void AddToDictionary(JetBrains.Decompiler.Baml.TreeBuilder.BamlElement keyElement, JetBrains.Decompiler.Baml.Reader.BamlKeyInfo keyInfo) { }
        public void BeginArrayProperty(JetBrains.Decompiler.Baml.Reader.BamlPropertyInfo property) { }
        public void BeginComplexProperty(JetBrains.Decompiler.Baml.Reader.BamlPropertyInfo property) { }
        public void BeginConstructorArguments() { }
        public void BeginDictionaryProperty(JetBrains.Decompiler.Baml.Reader.BamlPropertyInfo property) { }
        public void BeginElement(JetBrains.Decompiler.Baml.Reader.BamlTypeInfo type, long streamPosition) { }
        public void BeginListProperty(JetBrains.Decompiler.Baml.Reader.BamlPropertyInfo property) { }
        public void BeginStaticResource(JetBrains.Decompiler.Baml.Reader.BamlTypeInfo type) { }
        public void Connection(int connectionId) { }
        public void ConstructorParameterType(JetBrains.Decompiler.Baml.Reader.BamlTypeInfo type) { }
        public void EndArrayProperty() { }
        public void EndComplexProperty() { }
        public void EndConstructorArguments() { }
        public void EndDictionaryProperty() { }
        public void EndElement() { }
        public void EndListProperty() { }
        public void EndStaticResource() { }
        [JetBrains.Annotations.NotNullAttribute()]
        public System.Collections.Generic.IList<JetBrains.Decompiler.Baml.CacheBuilder.IResourceDictionaryRecord> GetDefinedResources(out JetBrains.Decompiler.Baml.Reader.BamlTypeInfo rootTagType) { }
        public void LiteralContent(string text) { }
        public void NamespaceMapping(string xmlNamespace, string clrNamespace, string assembly) { }
        public void OptimizedStaticResource(JetBrains.Decompiler.Baml.Reader.BamlTypeInfo type) { }
        public void OptimizedStaticResource(JetBrains.Decompiler.Baml.Reader.BamlPropertyInfo property) { }
        public void OptimizedStaticResource(string resourceKey) { }
        public void Property(JetBrains.Decompiler.Baml.Reader.BamlPropertyInfo property, string value) { }
        public void PropertyContent(JetBrains.Decompiler.Baml.Reader.BamlPropertyInfo property) { }
        public void PropertyCustom(JetBrains.Decompiler.Baml.Reader.BamlPropertyInfo property, JetBrains.Decompiler.Baml.Reader.BamlPropertyInfo propertyValue) { }
        public void PropertyCustom(JetBrains.Decompiler.Baml.Reader.BamlPropertyInfo property, string propertyValue) { }
        public void PropertyDeclaration(JetBrains.Decompiler.Baml.Reader.BamlPropertyInfo property, string value) { }
        public void PropertyResource(JetBrains.Decompiler.Baml.Reader.BamlPropertyInfo property, bool isDynamic, string resourceKey) { }
        public void PropertyResource(JetBrains.Decompiler.Baml.Reader.BamlPropertyInfo property, bool isDynamic, JetBrains.Decompiler.Baml.Reader.BamlPropertyInfo member) { }
        public void PropertyResource(JetBrains.Decompiler.Baml.Reader.BamlPropertyInfo property, bool isDynamic, JetBrains.Decompiler.Baml.Reader.BamlTypeInfo keyType) { }
        public void PropertyStaticResourceId(JetBrains.Decompiler.Baml.Reader.BamlPropertyInfo property, short staticResourceId) { }
        public void PropertyTemplateBinding(JetBrains.Decompiler.Baml.Reader.BamlPropertyInfo property, JetBrains.Decompiler.Baml.Reader.BamlPropertyInfo templateProperty) { }
        public void PropertyWithConverter(JetBrains.Decompiler.Baml.Reader.BamlPropertyInfo property, JetBrains.Decompiler.Baml.Reader.BamlTypeInfo converterType, string value) { }
        public void PropertyXStatic(JetBrains.Decompiler.Baml.Reader.BamlPropertyInfo property, JetBrains.Decompiler.Baml.Reader.BamlPropertyInfo member) { }
        public void PropertyXType(JetBrains.Decompiler.Baml.Reader.BamlPropertyInfo property, JetBrains.Decompiler.Baml.Reader.BamlTypeInfo type) { }
        public void StaticResourceId(short staticResourceId) { }
        public void Text(string value) { }
        public void TextWithConverter(string value, JetBrains.Decompiler.Baml.Reader.BamlTypeInfo converterType) { }
        public void XmlnsDeclaration(string prefix, string value) { }
    }
    public interface IResourceDictionaryRecord { }
    public sealed class MergedDictionaryRecord : JetBrains.Decompiler.Baml.CacheBuilder.IResourceDictionaryRecord
    {
        public MergedDictionaryRecord([JetBrains.Annotations.NotNullAttribute()] string dictionaryUri) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public string DictionaryUri { get; }
        public override string ToString() { }
    }
    public abstract class ResourceRecord : JetBrains.Decompiler.Baml.CacheBuilder.IResourceDictionaryRecord
    {
        protected ResourceRecord(JetBrains.Decompiler.Baml.Reader.BamlTypeInfo resourceType, [JetBrains.Annotations.CanBeNullAttribute()] string metadata = null) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public string Metadata { get; }
        public JetBrains.Decompiler.Baml.Reader.BamlTypeInfo ResourceType { get; }
        public override string ToString() { }
    }
    public sealed class StaticMemberKeyResourceRecord : JetBrains.Decompiler.Baml.CacheBuilder.ResourceRecord
    {
        public StaticMemberKeyResourceRecord(JetBrains.Decompiler.Baml.Reader.BamlPropertyInfo resourceKey, JetBrains.Decompiler.Baml.Reader.BamlTypeInfo resourceType, [JetBrains.Annotations.CanBeNullAttribute()] string metadata = null) { }
        public JetBrains.Decompiler.Baml.Reader.BamlPropertyInfo ResourceKey { get; }
        public override string ToString() { }
    }
    public sealed class StringKeyResourceRecord : JetBrains.Decompiler.Baml.CacheBuilder.ResourceRecord
    {
        public StringKeyResourceRecord([JetBrains.Annotations.NotNullAttribute()] string resourceKey, JetBrains.Decompiler.Baml.Reader.BamlTypeInfo resourceType, [JetBrains.Annotations.CanBeNullAttribute()] string metadata = null) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public string ResourceKey { get; }
        public override string ToString() { }
    }
    public sealed class TypeKeyResourceRecord : JetBrains.Decompiler.Baml.CacheBuilder.ResourceRecord
    {
        public TypeKeyResourceRecord(JetBrains.Decompiler.Baml.Reader.BamlTypeInfo resourceKey, JetBrains.Decompiler.Baml.Reader.BamlTypeInfo resourceType, [JetBrains.Annotations.CanBeNullAttribute()] string metadata = null) { }
        public JetBrains.Decompiler.Baml.Reader.BamlTypeInfo ResourceKey { get; }
        public override string ToString() { }
    }
}
namespace JetBrains.Decompiler.Baml.Reader
{
    
    [System.Diagnostics.DebuggerDisplayAttribute("Key(pos={Position,nq}}")]
    public struct BamlKeyInfo
    {
        public BamlKeyInfo(int position, bool shared) { }
        public int Position { get; }
        public bool Shared { get; }
    }
    public class static BamlKnownResources
    {
        public static JetBrains.Decompiler.Baml.Reader.BamlPropertyInfo GetMember(short memberId) { }
    }
    public sealed class BamlKnownTypes
    {
        public static JetBrains.Decompiler.Baml.Reader.BamlPropertyInfo GetPropertyInfo(short propertyId) { }
        public static JetBrains.Decompiler.Baml.Reader.BamlTypeInfo GetTypeInfo(short knownTypeId) { }
    }
    public abstract class BamlPredefinedProvider
    {
        public JetBrains.Decompiler.Baml.Reader.BamlTypeInfo Binding { get; }
        public JetBrains.Decompiler.Baml.Reader.BamlTypeInfo DynamicResource { get; }
        public JetBrains.Decompiler.Baml.Reader.BamlTypeInfo NullExtension { get; }
        public JetBrains.Decompiler.Baml.Reader.BamlTypeInfo RelativeSource { get; }
        public JetBrains.Decompiler.Baml.Reader.BamlTypeInfo StaticResource { get; }
        public JetBrains.Decompiler.Baml.Reader.BamlTypeInfo TemplateBinding { get; }
        public JetBrains.Decompiler.Baml.Reader.BamlTypeInfo XStatic { get; }
        public JetBrains.Decompiler.Baml.Reader.BamlTypeInfo XType { get; }
        public abstract JetBrains.Decompiler.Baml.Reader.BamlTypeInfo GetKnownType(short typeId);
        public abstract JetBrains.Decompiler.Baml.Reader.BamlPropertyInfo GetPropertyInfo(short propertyId);
        public abstract JetBrains.Decompiler.Baml.Reader.BamlPropertyInfo GetXStaticMember(short memberId);
    }
    [System.Diagnostics.DebuggerDisplayAttribute("{DeclaringType.FullName,nq}.{Name,nq}")]
    public struct BamlPropertyInfo : System.IEquatable<JetBrains.Decompiler.Baml.Reader.BamlPropertyInfo>
    {
        public static readonly JetBrains.Decompiler.Baml.Reader.BamlPropertyInfo Unknown;
        public BamlPropertyInfo([JetBrains.Annotations.NotNullAttribute()] string name, JetBrains.Decompiler.Baml.Reader.BamlTypeInfo declaringType) { }
        public JetBrains.Decompiler.Baml.Reader.BamlTypeInfo DeclaringType { get; }
        public bool IsUnknown { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public string Name { get; }
        public bool Equals(JetBrains.Decompiler.Baml.Reader.BamlPropertyInfo other) { }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
        public bool IsXamlPredefined([JetBrains.Annotations.NotNullAttribute()] string name) { }
        public override string ToString() { }
        public static JetBrains.Decompiler.Baml.Reader.BamlPropertyInfo XamlPredefined([JetBrains.Annotations.NotNullAttribute()] string name) { }
    }
    public class BamlReader
    {
        public BamlReader([JetBrains.Annotations.NotNullAttribute()] System.IO.Stream stream, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Decompiler.Baml.Reader.IBamlConsumer consumer, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.Decompiler.Baml.Reader.BamlPredefinedProvider predefinedProvider = null) { }
        public System.IO.Stream BaseStream { get; }
        public long Position { get; }
        public void Read() { }
        public static void Read([JetBrains.Annotations.NotNullAttribute()] System.IO.Stream stream, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Decompiler.Baml.Reader.IBamlConsumer consumer, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.Decompiler.Baml.Reader.BamlPredefinedProvider predefinedProvider = null) { }
    }
    [System.Diagnostics.DebuggerDisplayAttribute("{FullName,nq}")]
    public struct BamlTypeInfo : System.IEquatable<JetBrains.Decompiler.Baml.Reader.BamlTypeInfo>
    {
        public static readonly JetBrains.Decompiler.Baml.Reader.BamlTypeInfo PresentationOptions;
        public static readonly JetBrains.Decompiler.Baml.Reader.BamlTypeInfo Unknown;
        public static readonly JetBrains.Decompiler.Baml.Reader.BamlTypeInfo XamlPredefined;
        public static readonly JetBrains.Decompiler.Baml.Reader.BamlTypeInfo XmlPredefined;
        public BamlTypeInfo([JetBrains.Annotations.NotNullAttribute()] string typeName, [JetBrains.Annotations.NotNullAttribute()] string assembly) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public string Assembly { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public string FullName { get; }
        public bool IsUnknown { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public string Name { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public string Namespace { get; }
        public override bool Equals(object obj) { }
        public bool Equals(JetBrains.Decompiler.Baml.Reader.BamlTypeInfo other) { }
        public override int GetHashCode() { }
        public override string ToString() { }
    }
    public sealed class DefaultBamlPredefinedProvider : JetBrains.Decompiler.Baml.Reader.BamlPredefinedProvider
    {
        public static readonly JetBrains.Decompiler.Baml.Reader.BamlPredefinedProvider Instance;
        public override JetBrains.Decompiler.Baml.Reader.BamlTypeInfo GetKnownType(short typeId) { }
        public override JetBrains.Decompiler.Baml.Reader.BamlPropertyInfo GetPropertyInfo(short propertyId) { }
        public override JetBrains.Decompiler.Baml.Reader.BamlPropertyInfo GetXStaticMember(short memberId) { }
    }
    public interface IBamlConsumer
    {
        bool IsProcessingFinished { get; }
        void BeginArrayProperty(JetBrains.Decompiler.Baml.Reader.BamlPropertyInfo property);
        void BeginComplexProperty(JetBrains.Decompiler.Baml.Reader.BamlPropertyInfo property);
        void BeginConstructorArguments();
        void BeginDictionaryProperty(JetBrains.Decompiler.Baml.Reader.BamlPropertyInfo property);
        void BeginElement(JetBrains.Decompiler.Baml.Reader.BamlTypeInfo type, long streamPosition);
        void BeginKeyElement(JetBrains.Decompiler.Baml.Reader.BamlTypeInfo type, JetBrains.Decompiler.Baml.Reader.BamlKeyInfo key);
        void BeginListProperty(JetBrains.Decompiler.Baml.Reader.BamlPropertyInfo property);
        void BeginStaticResource(JetBrains.Decompiler.Baml.Reader.BamlTypeInfo type);
        void Connection(int connectionId);
        void ConstructorParameterType(JetBrains.Decompiler.Baml.Reader.BamlTypeInfo type);
        void EndArrayProperty();
        void EndComplexProperty();
        void EndConstructorArguments();
        void EndDictionaryProperty();
        void EndElement();
        void EndKeyElement();
        void EndListProperty();
        void EndStaticResource();
        void KeyAttributeString([JetBrains.Annotations.NotNullAttribute()] string keyString, JetBrains.Decompiler.Baml.Reader.BamlKeyInfo key);
        void KeyAttributeType(JetBrains.Decompiler.Baml.Reader.BamlTypeInfo type, JetBrains.Decompiler.Baml.Reader.BamlKeyInfo key);
        void LineAndPosition(int line, int position);
        void LiteralContent(string text);
        void NamespaceMapping(string xmlNamespace, string clrNamespace, string assembly);
        void OptimizedStaticResource(JetBrains.Decompiler.Baml.Reader.BamlTypeInfo type);
        void OptimizedStaticResource(JetBrains.Decompiler.Baml.Reader.BamlPropertyInfo property);
        void OptimizedStaticResource([JetBrains.Annotations.NotNullAttribute()] string resourceKey);
        void Position(int position);
        void Property(JetBrains.Decompiler.Baml.Reader.BamlPropertyInfo property, [JetBrains.Annotations.NotNullAttribute()] string value);
        void PropertyContent(JetBrains.Decompiler.Baml.Reader.BamlPropertyInfo property);
        void PropertyCustom(JetBrains.Decompiler.Baml.Reader.BamlPropertyInfo property, JetBrains.Decompiler.Baml.Reader.BamlPropertyInfo propertyValue);
        void PropertyCustom(JetBrains.Decompiler.Baml.Reader.BamlPropertyInfo property, string propertyValue);
        void PropertyDeclaration(JetBrains.Decompiler.Baml.Reader.BamlPropertyInfo property, [JetBrains.Annotations.NotNullAttribute()] string value);
        void PropertyResource(JetBrains.Decompiler.Baml.Reader.BamlPropertyInfo property, bool isDynamic, string resourceKey);
        void PropertyResource(JetBrains.Decompiler.Baml.Reader.BamlPropertyInfo property, bool isDynamic, JetBrains.Decompiler.Baml.Reader.BamlPropertyInfo member);
        void PropertyResource(JetBrains.Decompiler.Baml.Reader.BamlPropertyInfo property, bool isDynamic, JetBrains.Decompiler.Baml.Reader.BamlTypeInfo keyType);
        void PropertyStaticResourceId(JetBrains.Decompiler.Baml.Reader.BamlPropertyInfo property, short staticResourceId);
        void PropertyTemplateBinding(JetBrains.Decompiler.Baml.Reader.BamlPropertyInfo property, JetBrains.Decompiler.Baml.Reader.BamlPropertyInfo templateProperty);
        void PropertyWithConverter(JetBrains.Decompiler.Baml.Reader.BamlPropertyInfo property, JetBrains.Decompiler.Baml.Reader.BamlTypeInfo converterType, [JetBrains.Annotations.NotNullAttribute()] string value);
        void PropertyXStatic(JetBrains.Decompiler.Baml.Reader.BamlPropertyInfo property, JetBrains.Decompiler.Baml.Reader.BamlPropertyInfo member);
        void PropertyXType(JetBrains.Decompiler.Baml.Reader.BamlPropertyInfo property, JetBrains.Decompiler.Baml.Reader.BamlTypeInfo type);
        void StaticResourceId(short staticResourceId);
        void Text([JetBrains.Annotations.NotNullAttribute()] string value);
        void TextWithConverter([JetBrains.Annotations.NotNullAttribute()] string value, JetBrains.Decompiler.Baml.Reader.BamlTypeInfo converterType);
        void XmlnsDeclaration([JetBrains.Annotations.NotNullAttribute()] string prefix, [JetBrains.Annotations.NotNullAttribute()] string value);
    }
    public sealed class MetadataBamlPredefinedProvider : JetBrains.Decompiler.Baml.Reader.BamlPredefinedProvider
    {
        public MetadataBamlPredefinedProvider([JetBrains.Annotations.NotNullAttribute()] JetBrains.Metadata.Reader.API.IMetadataAssembly assembly) { }
        public override JetBrains.Decompiler.Baml.Reader.BamlTypeInfo GetKnownType(short typeId) { }
        public override JetBrains.Decompiler.Baml.Reader.BamlPropertyInfo GetPropertyInfo(short propertyId) { }
        public override JetBrains.Decompiler.Baml.Reader.BamlPropertyInfo GetXStaticMember(short memberId) { }
    }
    [System.Diagnostics.DebuggerDisplayAttribute("{Namespace,nq} ({Assembly,nq})")]
    public struct ReferencedNamespace : System.IEquatable<JetBrains.Decompiler.Baml.Reader.ReferencedNamespace>
    {
        public ReferencedNamespace([JetBrains.Annotations.NotNullAttribute()] string ns, [JetBrains.Annotations.NotNullAttribute()] string assembly) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public string Assembly { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public string Namespace { get; }
        public bool Equals(JetBrains.Decompiler.Baml.Reader.ReferencedNamespace other) { }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
    }
}
namespace JetBrains.Decompiler.Baml.Renderer
{
    
    public sealed class XamlRenderer
    {
        public XamlRenderer([JetBrains.Annotations.NotNullAttribute()] JetBrains.Decompiler.Baml.TypeSystem.INamespaceMappingProvider mappingProvider, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.Decompiler.Baml.TypeSystem.ITypeSystemHelper helper = null) { }
        public int IndentSize { get; set; }
        public int LineWidth { get; set; }
        public bool SortProperties { get; set; }
        public void EnsureCapacity(long streamLength) { }
        public string Render([JetBrains.Annotations.NotNullAttribute()] JetBrains.Decompiler.Baml.TreeBuilder.BamlObjectElement rootElement) { }
    }
}
namespace JetBrains.Decompiler.Baml.TreeBuilder
{
    
    [System.Diagnostics.DebuggerDisplayAttribute("{PropertyInfo.Name,nq}=(...)")]
    public sealed class BamlComplexProperty : JetBrains.Decompiler.Baml.TreeBuilder.BamlProperty
    {
        public BamlComplexProperty(JetBrains.Decompiler.Baml.Reader.BamlPropertyInfo property) { }
        public BamlComplexProperty(JetBrains.Decompiler.Baml.Reader.BamlPropertyInfo property, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Decompiler.Baml.TreeBuilder.BamlElement value) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.Decompiler.Baml.TreeBuilder.BamlElement Value { get; }
        public override void AddChildElement(JetBrains.Decompiler.Baml.TreeBuilder.BamlElement element) { }
    }
    [System.Diagnostics.DebuggerDisplayAttribute("ConnectionId=\"{ConnectionId,nq}\"")]
    public sealed class BamlConnectionProperty : JetBrains.Decompiler.Baml.TreeBuilder.BamlProperty
    {
        public BamlConnectionProperty(int connectionId) { }
        public int ConnectionId { get; }
        public override void AddChildElement(JetBrains.Decompiler.Baml.TreeBuilder.BamlElement element) { }
    }
    [System.Diagnostics.DebuggerDisplayAttribute("{PropertyInfo.Name,nq} (content property)")]
    public class BamlContentProperty : JetBrains.Decompiler.Baml.TreeBuilder.BamlProperty
    {
        public BamlContentProperty(JetBrains.Decompiler.Baml.Reader.BamlPropertyInfo property) { }
        [System.Diagnostics.DebuggerBrowsableAttribute(System.Diagnostics.DebuggerBrowsableState.Never)]
        public bool HasContent { get; }
        public override void AddChildElement(JetBrains.Decompiler.Baml.TreeBuilder.BamlElement element) { }
        public void AddContent([JetBrains.Annotations.NotNullAttribute()] JetBrains.Decompiler.Baml.TreeBuilder.BamlElement content) { }
        public System.Collections.Generic.IList<JetBrains.Decompiler.Baml.TreeBuilder.BamlElement> GetContents() { }
    }
    [System.Diagnostics.DebuggerDisplayAttribute("{PropertyInfo.Name,nq}=\"{Name,nq}\"")]
    public sealed class BamlDeclarationProperty : JetBrains.Decompiler.Baml.TreeBuilder.BamlProperty
    {
        public BamlDeclarationProperty(JetBrains.Decompiler.Baml.Reader.BamlPropertyInfo property, [JetBrains.Annotations.NotNullAttribute()] string name) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public string Name { get; }
        public override void AddChildElement(JetBrains.Decompiler.Baml.TreeBuilder.BamlElement element) { }
    }
    [System.Diagnostics.DebuggerDisplayAttribute("{PropertyInfo.Name,nq}=(dictionary)")]
    public sealed class BamlDictionaryProperty : JetBrains.Decompiler.Baml.TreeBuilder.BamlProperty
    {
        public BamlDictionaryProperty(JetBrains.Decompiler.Baml.Reader.BamlPropertyInfo property) { }
        [JetBrains.Annotations.NotNullAttribute()]
        [System.Diagnostics.DebuggerBrowsableAttribute(System.Diagnostics.DebuggerBrowsableState.RootHidden)]
        public System.Collections.Generic.IList<JetBrains.Decompiler.Baml.TreeBuilder.BamlObjectElement> Elements { get; }
        public override void AddChildElement(JetBrains.Decompiler.Baml.TreeBuilder.BamlElement element) { }
        public void FinishDictionary() { }
    }
    public abstract class BamlElement : JetBrains.Decompiler.Baml.TreeBuilder.BamlObject
    {
        public abstract bool IsPrimitive { get; }
    }
    [System.Diagnostics.DebuggerDisplayAttribute("{PropertyInfo.Name,nq}=(list)")]
    public sealed class BamlListProperty : JetBrains.Decompiler.Baml.TreeBuilder.BamlProperty
    {
        public BamlListProperty(JetBrains.Decompiler.Baml.Reader.BamlPropertyInfo property) { }
        [JetBrains.Annotations.NotNullAttribute()]
        [System.Diagnostics.DebuggerBrowsableAttribute(System.Diagnostics.DebuggerBrowsableState.RootHidden)]
        public System.Collections.Generic.IList<JetBrains.Decompiler.Baml.TreeBuilder.BamlElement> Elements { get; }
        public override void AddChildElement(JetBrains.Decompiler.Baml.TreeBuilder.BamlElement element) { }
    }
    [System.Diagnostics.DebuggerDisplayAttribute("xmlns:{Prefix,nq}=\"{Namespace,nq}\"")]
    public sealed class BamlNamespaceProperty : JetBrains.Decompiler.Baml.TreeBuilder.BamlProperty
    {
        public BamlNamespaceProperty([JetBrains.Annotations.NotNullAttribute()] string prefix, [JetBrains.Annotations.NotNullAttribute()] string ns) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public string Namespace { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public string Prefix { get; }
        public override void AddChildElement(JetBrains.Decompiler.Baml.TreeBuilder.BamlElement element) { }
    }
    public abstract class BamlObject { }
    [System.Diagnostics.DebuggerDisplayAttribute("<{TypeInfo.Name,nq}>")]
    public sealed class BamlObjectElement : JetBrains.Decompiler.Baml.TreeBuilder.BamlElement
    {
        public BamlObjectElement(JetBrains.Decompiler.Baml.Reader.BamlTypeInfo type) { }
        public BamlObjectElement(JetBrains.Decompiler.Baml.Reader.BamlTypeInfo type, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Decompiler.Baml.TreeBuilder.BamlElement constructorArgument) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public System.Collections.Generic.IList<JetBrains.Decompiler.Baml.TreeBuilder.BamlElement> ConstructorArguments { get; }
        public override bool IsPrimitive { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        [System.Diagnostics.DebuggerBrowsableAttribute(System.Diagnostics.DebuggerBrowsableState.RootHidden)]
        public System.Collections.Generic.IList<JetBrains.Decompiler.Baml.TreeBuilder.BamlProperty> Properties { get; }
        public JetBrains.Decompiler.Baml.Reader.BamlTypeInfo TypeInfo { get; }
        public void AddConstructorArgument([JetBrains.Annotations.NotNullAttribute()] JetBrains.Decompiler.Baml.TreeBuilder.BamlElement argument) { }
        public void AddProperty([JetBrains.Annotations.NotNullAttribute()] JetBrains.Decompiler.Baml.TreeBuilder.BamlProperty property) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.Decompiler.Baml.TreeBuilder.BamlContentProperty GetContentProperty() { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.Decompiler.Baml.TreeBuilder.BamlContentProperty GetOrCreateContentProperty() { }
    }
    public abstract class BamlProperty : JetBrains.Decompiler.Baml.TreeBuilder.BamlObject
    {
        protected BamlProperty(JetBrains.Decompiler.Baml.Reader.BamlPropertyInfo property) { }
        public JetBrains.Decompiler.Baml.Reader.BamlPropertyInfo PropertyInfo { get; }
        public abstract void AddChildElement([JetBrains.Annotations.NotNullAttribute()] JetBrains.Decompiler.Baml.TreeBuilder.BamlElement element);
    }
    [System.Diagnostics.DebuggerDisplayAttribute("{Property.Name,nq}")]
    public sealed class BamlPropertyReference : JetBrains.Decompiler.Baml.TreeBuilder.BamlElement
    {
        public BamlPropertyReference(JetBrains.Decompiler.Baml.Reader.BamlPropertyInfo property) { }
        public override bool IsPrimitive { get; }
        public JetBrains.Decompiler.Baml.Reader.BamlPropertyInfo Property { get; }
    }
    [System.Diagnostics.DebuggerDisplayAttribute("{Value}")]
    public sealed class BamlTextElement : JetBrains.Decompiler.Baml.TreeBuilder.BamlElement
    {
        public BamlTextElement([JetBrains.Annotations.NotNullAttribute()] string value) { }
        public BamlTextElement([JetBrains.Annotations.NotNullAttribute()] string value, bool disableEscaping) { }
        public bool DisableEscaping { get; }
        public override bool IsPrimitive { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public string Value { get; }
    }
    public sealed class BamlTreeBuilder : JetBrains.Decompiler.Baml.TreeBuilder.TreeBuilderBase, JetBrains.Decompiler.Baml.Reader.IBamlConsumer, JetBrains.Decompiler.Baml.TypeSystem.INamespaceMappingProvider
    {
        public BamlTreeBuilder([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.Decompiler.Baml.Reader.BamlPredefinedProvider predefinedProvider = null) { }
        public bool IsProcessingFinished { get; }
        protected override void AddToDictionary(JetBrains.Decompiler.Baml.TreeBuilder.BamlElement keyElement, JetBrains.Decompiler.Baml.Reader.BamlKeyInfo keyInfo) { }
        public void BeginArrayProperty(JetBrains.Decompiler.Baml.Reader.BamlPropertyInfo property) { }
        public void BeginComplexProperty(JetBrains.Decompiler.Baml.Reader.BamlPropertyInfo property) { }
        public void BeginConstructorArguments() { }
        public void BeginDictionaryProperty(JetBrains.Decompiler.Baml.Reader.BamlPropertyInfo property) { }
        public void BeginElement(JetBrains.Decompiler.Baml.Reader.BamlTypeInfo type, long streamPosition) { }
        public void BeginListProperty(JetBrains.Decompiler.Baml.Reader.BamlPropertyInfo property) { }
        public void BeginStaticResource(JetBrains.Decompiler.Baml.Reader.BamlTypeInfo type) { }
        public void Connection(int connectionId) { }
        public void ConstructorParameterType(JetBrains.Decompiler.Baml.Reader.BamlTypeInfo type) { }
        public void EndArrayProperty() { }
        public void EndComplexProperty() { }
        public void EndConstructorArguments() { }
        public void EndDictionaryProperty() { }
        public void EndElement() { }
        public void EndListProperty() { }
        public void EndStaticResource() { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.Decompiler.Baml.TypeSystem.INamespaceMappingProvider GetNamespaceMappingProvider() { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.Decompiler.Baml.TreeBuilder.BamlObjectElement GetResult() { }
        public void LiteralContent(string text) { }
        public void NamespaceMapping(string xmlNamespace, string clrNamespace, string assembly) { }
        public void OptimizedStaticResource(JetBrains.Decompiler.Baml.Reader.BamlTypeInfo type) { }
        public void OptimizedStaticResource(JetBrains.Decompiler.Baml.Reader.BamlPropertyInfo property) { }
        public void OptimizedStaticResource(string resourceKey) { }
        public void Property(JetBrains.Decompiler.Baml.Reader.BamlPropertyInfo property, string value) { }
        public void PropertyContent(JetBrains.Decompiler.Baml.Reader.BamlPropertyInfo property) { }
        public void PropertyCustom(JetBrains.Decompiler.Baml.Reader.BamlPropertyInfo property, string propertyValue) { }
        public void PropertyCustom(JetBrains.Decompiler.Baml.Reader.BamlPropertyInfo property, JetBrains.Decompiler.Baml.Reader.BamlPropertyInfo propertyValue) { }
        public void PropertyDeclaration(JetBrains.Decompiler.Baml.Reader.BamlPropertyInfo property, string value) { }
        public void PropertyResource(JetBrains.Decompiler.Baml.Reader.BamlPropertyInfo property, bool isDynamic, string resourceKey) { }
        public void PropertyResource(JetBrains.Decompiler.Baml.Reader.BamlPropertyInfo property, bool isDynamic, JetBrains.Decompiler.Baml.Reader.BamlPropertyInfo member) { }
        public void PropertyResource(JetBrains.Decompiler.Baml.Reader.BamlPropertyInfo property, bool isDynamic, JetBrains.Decompiler.Baml.Reader.BamlTypeInfo keyType) { }
        public void PropertyStaticResourceId(JetBrains.Decompiler.Baml.Reader.BamlPropertyInfo property, short staticResourceId) { }
        public void PropertyTemplateBinding(JetBrains.Decompiler.Baml.Reader.BamlPropertyInfo property, JetBrains.Decompiler.Baml.Reader.BamlPropertyInfo templateProperty) { }
        public void PropertyWithConverter(JetBrains.Decompiler.Baml.Reader.BamlPropertyInfo property, JetBrains.Decompiler.Baml.Reader.BamlTypeInfo converterType, string value) { }
        public void PropertyXStatic(JetBrains.Decompiler.Baml.Reader.BamlPropertyInfo property, JetBrains.Decompiler.Baml.Reader.BamlPropertyInfo member) { }
        public void PropertyXType(JetBrains.Decompiler.Baml.Reader.BamlPropertyInfo property, JetBrains.Decompiler.Baml.Reader.BamlTypeInfo type) { }
        public void StaticResourceId(short staticResourceId) { }
        public void Text(string value) { }
        public void TextWithConverter(string value, JetBrains.Decompiler.Baml.Reader.BamlTypeInfo converterType) { }
        public void XmlnsDeclaration(string prefix, string value) { }
    }
    [System.Diagnostics.DebuggerDisplayAttribute("{Type.FullName,nq}")]
    public sealed class BamlTypeReference : JetBrains.Decompiler.Baml.TreeBuilder.BamlElement
    {
        public BamlTypeReference(JetBrains.Decompiler.Baml.Reader.BamlTypeInfo type) { }
        public override bool IsPrimitive { get; }
        public JetBrains.Decompiler.Baml.Reader.BamlTypeInfo Type { get; }
    }
    [System.Diagnostics.DebuggerDisplayAttribute("{PropertyInfo.Name,nq}=\"{Value,nq}\"")]
    public sealed class BamlValueProperty : JetBrains.Decompiler.Baml.TreeBuilder.BamlProperty
    {
        public BamlValueProperty(JetBrains.Decompiler.Baml.Reader.BamlPropertyInfo property, [JetBrains.Annotations.NotNullAttribute()] string value) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public string Value { get; }
        public override void AddChildElement(JetBrains.Decompiler.Baml.TreeBuilder.BamlElement element) { }
    }
    public abstract class TreeBuilderBase
    {
        [JetBrains.Annotations.NotNullAttribute()]
        protected readonly System.Collections.Generic.Stack<JetBrains.Decompiler.Baml.TreeBuilder.BamlElement> ConstuctorArgs;
        [JetBrains.Annotations.NotNullAttribute()]
        protected readonly System.Collections.Generic.Dictionary<JetBrains.Decompiler.Baml.TreeBuilder.BamlObjectElement, JetBrains.Decompiler.Baml.TreeBuilder.TreeBuilderBase.DictionaryInfo> Dictionaries;
        [JetBrains.Annotations.NotNullAttribute()]
        protected readonly JetBrains.Decompiler.Baml.Reader.BamlPredefinedProvider Predefined;
        [JetBrains.Annotations.CanBeNullAttribute()]
        protected JetBrains.Decompiler.Baml.TreeBuilder.BamlObjectElement RootElement;
        [JetBrains.Annotations.NotNullAttribute()]
        protected readonly System.Collections.Generic.Stack<JetBrains.Decompiler.Baml.TreeBuilder.BamlObject> Stack;
        protected TreeBuilderBase([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.Decompiler.Baml.Reader.BamlPredefinedProvider predefinedProvider = null) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        protected JetBrains.Decompiler.Baml.TreeBuilder.BamlObject CurrentElement { get; }
        protected abstract void AddToDictionary([JetBrains.Annotations.NotNullAttribute()] JetBrains.Decompiler.Baml.TreeBuilder.BamlElement keyElement, JetBrains.Decompiler.Baml.Reader.BamlKeyInfo keyInfo);
        protected void AssertStacksAreEmpty() { }
        public void BeginKeyElement(JetBrains.Decompiler.Baml.Reader.BamlTypeInfo type, JetBrains.Decompiler.Baml.Reader.BamlKeyInfo key) { }
        public void EndKeyElement() { }
        public void KeyAttributeString(string keyString, JetBrains.Decompiler.Baml.Reader.BamlKeyInfo key) { }
        public void KeyAttributeType(JetBrains.Decompiler.Baml.Reader.BamlTypeInfo type, JetBrains.Decompiler.Baml.Reader.BamlKeyInfo key) { }
        public void LineAndPosition(int line, int position) { }
        public void Position(int position) { }
        protected sealed class DictionaryInfo
        {
            public DictionaryInfo() { }
            public void AddKey(JetBrains.Decompiler.Baml.Reader.BamlKeyInfo key, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Decompiler.Baml.TreeBuilder.BamlElement keyElement) { }
            public void AddResource([JetBrains.Annotations.NotNullAttribute()] object resource) { }
            public void AppendKeyFor(long currentPosition, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Decompiler.Baml.TreeBuilder.BamlObjectElement element) { }
            [JetBrains.Annotations.CanBeNullAttribute()]
            public object GetStaticResourceById(int resourceId) { }
        }
    }
}
namespace JetBrains.Decompiler.Baml.TypeSystem
{
    
    public sealed class ComposedMappingProvider : JetBrains.Decompiler.Baml.TypeSystem.INamespaceMappingProvider
    {
        public ComposedMappingProvider([JetBrains.Annotations.NotNullAttribute()] JetBrains.Decompiler.Baml.TypeSystem.INamespaceMappingProvider first, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Decompiler.Baml.TypeSystem.INamespaceMappingProvider second) { }
        public System.Collections.Generic.IEnumerable<string> GetXmlNamespace(JetBrains.Decompiler.Baml.Reader.ReferencedNamespace referencedNamespace) { }
    }
    public class static ComposedMappingProviderExtensions
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.Decompiler.Baml.TypeSystem.INamespaceMappingProvider Compose([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Decompiler.Baml.TypeSystem.INamespaceMappingProvider first, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Decompiler.Baml.TypeSystem.INamespaceMappingProvider second) { }
    }
    public class DefaultTypeSystemHelper : JetBrains.Decompiler.Baml.TypeSystem.ITypeSystemHelper
    {
        public static readonly JetBrains.Decompiler.Baml.TypeSystem.ITypeSystemHelper Instance;
        public JetBrains.Decompiler.Baml.Reader.BamlTypeInfo GetBaseType(JetBrains.Decompiler.Baml.Reader.BamlTypeInfo type, out JetBrains.Decompiler.Baml.Reader.BamlTypeInfo typeArguments) { }
        public System.Collections.Generic.IList<JetBrains.Decompiler.Baml.TypeSystem.EventConnectRecord> GetEventRecords(int connectionId, JetBrains.Decompiler.Baml.Reader.BamlTypeInfo type) { }
        public JetBrains.Decompiler.Baml.TypeSystem.FieldAccessRights GetFieldAccessRights(JetBrains.Decompiler.Baml.Reader.BamlTypeInfo type, string name) { }
        public bool IsBaseOf(JetBrains.Decompiler.Baml.Reader.BamlTypeInfo baseType, JetBrains.Decompiler.Baml.Reader.BamlTypeInfo derivedType) { }
        public bool IsMarkupExtension(JetBrains.Decompiler.Baml.Reader.BamlTypeInfo type) { }
        public bool IsXamlDeclaredType(JetBrains.Decompiler.Baml.Reader.BamlTypeInfo type, out bool isPublic) { }
    }
    public sealed class EventConnectRecord
    {
        public EventConnectRecord(JetBrains.Decompiler.Baml.Reader.BamlTypeInfo eventOwner, [JetBrains.Annotations.NotNullAttribute()] string eventName, [JetBrains.Annotations.NotNullAttribute()] string handlerName) { }
        public string EventName { get; }
        public JetBrains.Decompiler.Baml.Reader.BamlTypeInfo EventOwner { get; }
        public string HandlerName { get; }
    }
    public enum FieldAccessRights
    {
        None = 0,
        Private = 1,
        Protected = 2,
        Internal = 3,
        Public = 4,
    }
    public interface INamespaceMappingProvider
    {
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.IEnumerable<string> GetXmlNamespace(JetBrains.Decompiler.Baml.Reader.ReferencedNamespace referencedNamespace);
    }
    public interface ITypeSystemHelper
    {
        JetBrains.Decompiler.Baml.Reader.BamlTypeInfo GetBaseType(JetBrains.Decompiler.Baml.Reader.BamlTypeInfo type, out JetBrains.Decompiler.Baml.Reader.BamlTypeInfo typeArguments);
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.IList<JetBrains.Decompiler.Baml.TypeSystem.EventConnectRecord> GetEventRecords(int connectionId, JetBrains.Decompiler.Baml.Reader.BamlTypeInfo type);
        JetBrains.Decompiler.Baml.TypeSystem.FieldAccessRights GetFieldAccessRights(JetBrains.Decompiler.Baml.Reader.BamlTypeInfo type, [JetBrains.Annotations.NotNullAttribute()] string name);
        bool IsBaseOf(JetBrains.Decompiler.Baml.Reader.BamlTypeInfo baseType, JetBrains.Decompiler.Baml.Reader.BamlTypeInfo derivedType);
        bool IsMarkupExtension(JetBrains.Decompiler.Baml.Reader.BamlTypeInfo type);
        bool IsXamlDeclaredType(JetBrains.Decompiler.Baml.Reader.BamlTypeInfo type, out bool isPublic);
    }
    public sealed class MetadataTypeSystemHelper : JetBrains.Decompiler.Baml.TypeSystem.INamespaceMappingProvider, JetBrains.Decompiler.Baml.TypeSystem.ITypeSystemHelper
    {
        public MetadataTypeSystemHelper([JetBrains.Annotations.NotNullAttribute()] JetBrains.Metadata.Reader.API.IMetadataAssembly metadataAssembly) { }
        public JetBrains.Decompiler.Baml.Reader.BamlTypeInfo GetBaseType(JetBrains.Decompiler.Baml.Reader.BamlTypeInfo type, out JetBrains.Decompiler.Baml.Reader.BamlTypeInfo typeArguments) { }
        public System.Collections.Generic.IList<JetBrains.Decompiler.Baml.TypeSystem.EventConnectRecord> GetEventRecords(int connectionId, JetBrains.Decompiler.Baml.Reader.BamlTypeInfo type) { }
        public JetBrains.Decompiler.Baml.TypeSystem.FieldAccessRights GetFieldAccessRights(JetBrains.Decompiler.Baml.Reader.BamlTypeInfo type, string name) { }
        public System.Collections.Generic.IEnumerable<string> GetXmlNamespace(JetBrains.Decompiler.Baml.Reader.ReferencedNamespace referencedNamespace) { }
        public bool IsBaseOf(JetBrains.Decompiler.Baml.Reader.BamlTypeInfo baseType, JetBrains.Decompiler.Baml.Reader.BamlTypeInfo derivedType) { }
        public bool IsMarkupExtension(JetBrains.Decompiler.Baml.Reader.BamlTypeInfo type) { }
        public bool IsXamlDeclaredType(JetBrains.Decompiler.Baml.Reader.BamlTypeInfo type, out bool isPublic) { }
    }
}
namespace JetBrains.Decompiler
{
    
    public class ClassDecompiler
    {
        public ClassDecompiler(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Metadata.Reader.API.IMetadataAssembly assembly, JetBrains.Decompiler.ClassDecompilerOptions options) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.Decompiler.Ast.IDecompiledClass Decompile([JetBrains.Annotations.NotNullAttribute()] JetBrains.Metadata.Reader.API.IMetadataTypeInfo typeInfo, JetBrains.Application.Progress.IProgressIndicator indicator) { }
        public JetBrains.Decompiler.Ast.IDecompiledMethod Decompile([JetBrains.Annotations.NotNullAttribute()] JetBrains.Metadata.Reader.API.IMetadataTypeInfo typeInfo, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Metadata.Reader.API.IMetadataMethod methodInfo) { }
    }
    public class ClassDecompilerOptions
    {
        public ClassDecompilerOptions(bool decompileBodies, bool showCompilerGeneratedCode, JetBrains.Decompiler.IXmlDocProvider xmlDocProvider, bool containsUnsafeCode = False) { }
        public bool ContainsUnsafeCode { get; set; }
        public bool DecompileBodies { get; }
        public bool ShowCompilerGeneratedCode { get; }
        public JetBrains.Decompiler.IXmlDocProvider XmlDocProvider { get; }
    }
    public class DecompilerAssemblyResolver : JetBrains.Metadata.Reader.API.IAssemblyResolver
    {
        public DecompilerAssemblyResolver([JetBrains.Annotations.NotNullAttribute()] JetBrains.Metadata.Reader.API.IAssemblyResolver underlyingResolver) { }
        public JetBrains.Metadata.Access.IMetadataAccess ResolveAssembly(JetBrains.Metadata.Utils.AssemblyNameInfo name, out JetBrains.Util.FileSystemPath assemblyLocation, JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext moduleReferenceResolveContext) { }
    }
    public interface IXmlDocProvider
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        string GetXmlDoc([JetBrains.Annotations.NotNullAttribute()] JetBrains.Metadata.Reader.API.IMetadataEntity metadataEntity, JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext resolveContext);
    }
}
namespace JetBrains.Decompiler.Inspections
{
    
    public class MethodIssuesInspector
    {
        public static void MarkFailedMethod(JetBrains.Decompiler.Ast.IDecompiledMethod method) { }
        public static void Run(JetBrains.Decompiler.Ast.IDecompiledMethod method, bool warnCompilerGeneratedEntitiesAccess) { }
    }
}
namespace JetBrains.Decompiler.Metadata
{
    
    public class EventSpecification : System.IEquatable<JetBrains.Decompiler.Metadata.EventSpecification>
    {
        public EventSpecification([JetBrains.Annotations.NotNullAttribute()] JetBrains.Metadata.Reader.API.IMetadataEvent @event, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Metadata.Reader.API.IMetadataClassType ownerType) { }
        public JetBrains.Metadata.Reader.API.IMetadataEvent Event { get; }
        public JetBrains.Metadata.Reader.API.IMetadataClassType OwnerType { get; }
        public bool Equals(JetBrains.Decompiler.Metadata.EventSpecification other) { }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
        public override string ToString() { }
    }
    public class PropertySpecification : System.IEquatable<JetBrains.Decompiler.Metadata.PropertySpecification>
    {
        public PropertySpecification([JetBrains.Annotations.NotNullAttribute()] JetBrains.Metadata.Reader.API.IMetadataProperty property, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Metadata.Reader.API.IMetadataClassType ownerType) { }
        public JetBrains.Metadata.Reader.API.IMetadataClassType OwnerType { get; }
        public JetBrains.Metadata.Reader.API.IMetadataProperty Property { get; }
        public bool Equals(JetBrains.Decompiler.Metadata.PropertySpecification other) { }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
        public override string ToString() { }
    }
}
namespace JetBrains.Decompiler.Render
{
    
    public class BeginMethodCodeMarker : JetBrains.Decompiler.Render.ICodeMarker
    {
        public BeginMethodCodeMarker(JetBrains.Metadata.Reader.API.IMetadataMethod method) { }
        public JetBrains.Metadata.Reader.API.IMetadataMethod Method { get; }
    }
    public class CodeMarkerListener : JetBrains.Decompiler.Render.ICodeTextWriter
    {
        public CodeMarkerListener(JetBrains.Decompiler.Render.ICodeTextWriter writer, System.Action<JetBrains.Decompiler.Render.ICodeMarker> markerHandler) { }
        public int Indent { get; set; }
        public void WriteMarker(JetBrains.Decompiler.Render.ICodeMarker marker) { }
        public void WriteNewLine() { }
        public void WriteText(string text) { }
        public void WriteTypeName(string namespaceName, string typeName) { }
    }
    public class EndMethodCodeMarker : JetBrains.Decompiler.Render.ICodeMarker { }
    public class ExplicitInterfaceTypeNameFormatter : JetBrains.Metadata.Reader.API.IMetadataTypeVisitor
    {
        public ExplicitInterfaceTypeNameFormatter() { }
        public string Text { get; }
        public void VisitArrayType(JetBrains.Metadata.Reader.API.IMetadataArrayType arrayType) { }
        public void VisitClassType(JetBrains.Metadata.Reader.API.IMetadataClassType classType) { }
        public void VisitFunctionPointer(JetBrains.Metadata.Reader.API.IMetadataFunctionPointerType functionPointerType) { }
        public void VisitGenericArgumentReferenceType(JetBrains.Metadata.Reader.API.IMetadataGenericArgumentReferenceType genericArgumentReferenceType) { }
        public void VisitPointerType(JetBrains.Metadata.Reader.API.IMetadataPointerType pointerType) { }
        public void VisitReferenceType(JetBrains.Metadata.Reader.API.IMetadataReferenceType referenceType) { }
        public void VisitUnknownType(JetBrains.Metadata.Reader.API.IMetadataType unknownType) { }
    }
    public interface ICodeMarker { }
    public interface ICodeTextWriter
    {
        int Indent { get; set; }
        void WriteMarker(JetBrains.Decompiler.Render.ICodeMarker marker);
        void WriteNewLine();
        void WriteText(string text);
        void WriteTypeName(string namespaceName, string typeName);
    }
}
namespace JetBrains.Decompiler.Render.CSharp
{
    
    public class static AccessRightsEx
    {
        public static JetBrains.Decompiler.Render.CSharp.CSharpAccessRights GetAccessRights([JetBrains.Annotations.CanBeNullAttribute()] this JetBrains.Metadata.Reader.API.IMetadataTypeMember accessRightsOwner) { }
        public static int GetWeight(this JetBrains.Decompiler.Render.CSharp.CSharpAccessRights weight) { }
    }
    public class static AstRenderer
    {
        public static JetBrains.Decompiler.Render.ICodeTextWriter RenderConstant(this JetBrains.Decompiler.Render.ICodeTextWriter writer, JetBrains.Decompiler.Ast.Constant constant) { }
        public static JetBrains.Decompiler.Render.ICodeTextWriter RenderExpression(this JetBrains.Decompiler.Render.ICodeTextWriter writer, JetBrains.Decompiler.Ast.IExpression expression) { }
        public static JetBrains.Decompiler.Render.ICodeTextWriter RenderMethod([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Decompiler.Render.ICodeTextWriter writer, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Decompiler.Ast.IDecompiledMethod method) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.Decompiler.Render.ICodeTextWriter RenderMethodBody([JetBrains.Annotations.NotNullAttribute()] this JetBrains.Decompiler.Render.ICodeTextWriter writer, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Decompiler.Ast.IDecompiledMethod method) { }
        public static JetBrains.Decompiler.Render.ICodeTextWriter RenderStatement(this JetBrains.Decompiler.Render.ICodeTextWriter writer, JetBrains.Decompiler.Ast.IStatement statement, bool isEmbedded = False) { }
    }
    public enum CSharpAccessRights
    {
        None = 0,
        Public = 1,
        Internal = 2,
        Protected = 3,
        ProtectedInternal = 4,
        Private = 5,
    }
    public class MetadataRenderer
    {
        public MetadataRenderer(JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Metadata.Reader.API.IMetadataAssembly assembly, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Decompiler.Render.ICodeTextWriter writer, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Decompiler.ClassDecompilerOptions options, JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext resolveContext) { }
        protected virtual JetBrains.Metadata.Reader.API.ICompilerSpecificAttribute[] ExtraFilterCompilerSpecificAttributes(JetBrains.Metadata.Reader.API.ICompilerSpecificAttribute[] attributes) { }
        protected virtual JetBrains.Metadata.Reader.API.IMetadataCustomAttribute[] ExtraFilterCustomAttributes(JetBrains.Metadata.Reader.API.IMetadataCustomAttribute[] attributes) { }
        protected virtual JetBrains.Metadata.Reader.API.IMetadataSecurityAttribute[] ExtraFilterSecurityAttributes(JetBrains.Metadata.Reader.API.IMetadataSecurityAttribute[] attributes) { }
        public void RenderAssemblyInfo() { }
        public bool RenderMethod(JetBrains.Metadata.Reader.API.IMetadataMethod method, JetBrains.Application.Progress.IProgressIndicator pi) { }
        public void RenderTopLevelType(JetBrains.Metadata.Reader.API.IMetadataTypeInfo typeInfo, JetBrains.Application.Progress.IProgressIndicator indicator, bool addPartialModifier = False) { }
        protected virtual void WriteComments() { }
        protected virtual void WriteModuleAttributes() { }
    }
    public class OptimizeImportsCodeTextWriter : JetBrains.Decompiler.Render.ICodeTextWriter
    {
        public OptimizeImportsCodeTextWriter(string ownNamespaceName) { }
        public int Indent { get; set; }
        public int IndentSize { get; set; }
        public JetBrains.Decompiler.Render.CSharp.OptimizeImportsCodeTextWriter.CodeText GetCodeText() { }
        public void WriteMarker(JetBrains.Decompiler.Render.ICodeMarker marker) { }
        public void WriteNewLine() { }
        public void WriteText(string s) { }
        public void WriteTypeName(string namespaceName, string typeName) { }
        public class CodeText
        {
            public CodeText(string text, JetBrains.Util.OneToListMap<JetBrains.Metadata.Reader.API.IMetadataMethod, JetBrains.Util.TextRange> methodRanges) { }
            public JetBrains.Util.OneToListMap<JetBrains.Metadata.Reader.API.IMetadataMethod, JetBrains.Util.TextRange> MethodRanges { get; }
            public string Text { get; }
        }
    }
}
namespace JetBrains.Decompiler.Transformations
{
    
    public abstract class NodeTransformationBase<T> : JetBrains.Decompiler.Transformations.INodeTransformation
        where T :  class, JetBrains.Decompiler.Ast.INode
    {
        protected NodeTransformationBase() { }
        protected virtual bool ApplyOnce { get; }
        public System.Type BaseNodeType { get; }
        protected virtual bool IsEnabled { get; }
        public bool Apply(JetBrains.Decompiler.Ast.INode node) { }
        protected abstract bool DoApply(T node);
        protected void SuppressApply(JetBrains.Decompiler.Ast.INode node) { }
    }
}
namespace JetBrains.Decompiler.Utils
{
    
    public class DataHolder : System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<object, object>>, System.Collections.IEnumerable
    {
        public System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<object, object>> GetEnumerator() { }
        public T GetValue<T>(JetBrains.Decompiler.Utils.DataKey<T> key, T defaultValue) { }
        public T GetValue<T>(JetBrains.Decompiler.Utils.DataKey<T> key) { }
        public bool RemoveValue<T>(JetBrains.Decompiler.Utils.DataKey<T> key) { }
        public bool RemoveValueUntyped(object key) { }
        public void SetValue<T>(JetBrains.Decompiler.Utils.DataKey<T> key, T value) { }
        public void SetValueUntyped(object key, object value) { }
        public bool TryGetValue<T>(JetBrains.Decompiler.Utils.DataKey<T> key, out T value) { }
    }
    [System.Diagnostics.DebuggerDisplayAttribute("Key: {ToString()}")]
    public class DataKey<T>
    
    {
        public DataKey(string text) { }
        public string Text { get; }
        public override string ToString() { }
    }
    public class static DecompilerLicence
    {
        public static string GetDecompilerLegalNotice() { }
    }
    public class static MemberInheritanceUtil
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.Metadata.Reader.API.IMetadataTypeMember GetBaseMemberByNameAndSig([JetBrains.Annotations.NotNullAttribute()] JetBrains.Metadata.Reader.API.IMetadataTypeMember typeMember) { }
        public static JetBrains.Decompiler.Utils.MemberInheritanceUtil.InheritanceModifiers GetInheritanceModifiers([JetBrains.Annotations.NotNullAttribute()] JetBrains.Metadata.Reader.API.IMetadataTypeMember typeMember) { }
        public static JetBrains.Metadata.Reader.API.IMetadataParameter[] GetPropertyParameters(JetBrains.Metadata.Reader.API.IMetadataProperty property) { }
        public class InheritanceModifiers
        {
            public InheritanceModifiers(bool isNew = False, bool isVirtual = False, bool isOverrides = False, bool isAbstract = False, bool isSealed = False) { }
            public bool Abstract { get; }
            public bool New { get; }
            public bool Overrides { get; }
            public bool Sealed { get; }
            public bool Virtual { get; }
        }
    }
    public struct Rational
    {
        public readonly long Denominator;
        public static readonly JetBrains.Decompiler.Utils.Rational Invalid;
        public readonly long Numerator;
        public Rational(long numerator, long denominator = 1) { }
        public bool IsValid { get; }
        public double AsDouble() { }
        public bool Equals(JetBrains.Decompiler.Utils.Rational other) { }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
        public override string ToString() { }
    }
    public class static RationalUtil
    {
        public static JetBrains.Decompiler.Utils.Rational GetRationalApproximation(double r, int maximumDenominator, double epsilon) { }
    }
}