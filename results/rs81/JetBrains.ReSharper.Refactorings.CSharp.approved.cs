[assembly: System.Runtime.CompilerServices.InternalsVisibleToAttribute(@"JetBrains.ReSharper.Refactorings.Test.CSharp, PublicKey=002400000480000094000000060200000024000052534131000400000100010087f63ba6a789c30e210e7ec987234ad9fe33baf7367993bab1b312d6f72ca296b91ed5c658964ffb9e7570eb184a527c68c6bdba41cfe67d8cfd3f888234206bf39205a3652d3af3445bb6f715fdac532e289fea41229bac37762b67eb16f58fee717d2465fca9ee17f08ed16772a1fc52c1c17022e1f0d9bdd004524a663aca")]
[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]

namespace JetBrains.ReSharper.Refactorings.CSharp.Anotype2DeclaredType
{
    
    public class CsAnonymous2Declared : JetBrains.ReSharper.Refactorings.Anotype2DeclaredType.Anonymous2Declared
    {
        public CsAnonymous2Declared(JetBrains.ReSharper.Refactorings.Anotype2DeclaredType.Anonymous2DeclaredWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public override void ChangeReference(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.IClass clsss, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution) { }
        public override JetBrains.ReSharper.Psi.IClass CreateClassDeclaration(System.Collections.Generic.IList<JetBrains.ReSharper.Psi.ITypeParameter> usedTypeParameters, ref JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution) { }
        public override System.Collections.Generic.IList<JetBrains.ReSharper.Psi.ITypeParameter> GetUsagedTypeParameters() { }
        public override System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Tree.ITreeNode> SearchForAnonymousTypes(JetBrains.Application.Progress.SubProgressIndicator pi) { }
        public void TryChangeReference(System.Func<bool> action) { }
    }
}
namespace JetBrains.ReSharper.Refactorings.CSharp.ChangeSignature
{
    
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.CSharp.CSharpLanguage))]
    public class CSharpChangeSignature : JetBrains.ReSharper.Refactorings.ChangeSignature.ChangeSignature
    {
        public CSharpChangeSignature(JetBrains.ReSharper.Psi.PsiLanguageType language) { }
        protected override JetBrains.ReSharper.Psi.Tree.IArgument AddArgumentAfter(JetBrains.ReSharper.Psi.Tree.IArgumentsOwner owner, JetBrains.ReSharper.Psi.Tree.IArgument argument, JetBrains.ReSharper.Psi.Tree.IArgument tag, JetBrains.ReSharper.Refactorings.ChangeSignature.ChangeSignatureParameter parameter) { }
        public override JetBrains.ReSharper.Psi.IParametersOwner AddDefaultConstructorDeclaration(JetBrains.ReSharper.Psi.IConstructor defaultConstructor) { }
        public override void BindReferenceExpression(JetBrains.ReSharper.Psi.Tree.IExpression expression, JetBrains.ReSharper.Psi.IDeclaredElement element) { }
        public override void ChangeDeclaration(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration, System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Tree.IDeclaration> parameterDeclarations, JetBrains.ReSharper.Refactorings.ChangeSignature.ChangeSignatureModel changeSignatureModel, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution, System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<JetBrains.ReSharper.Psi.Tree.IArgument, JetBrains.ReSharper.Refactorings.ChangeSignature.ChangeSignatureModel.ArgumentAction>> postActionsList) { }
        protected override void ChangeDefaultConstructor(JetBrains.ReSharper.Psi.IConstructor constructor, JetBrains.ReSharper.Refactorings.ChangeSignature.ChangeSignatureModel model, System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<JetBrains.ReSharper.Psi.Tree.IArgument, JetBrains.ReSharper.Refactorings.ChangeSignature.ChangeSignatureModel.ArgumentAction>> postActions) { }
        public override bool CheckIfMethodGroup(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public override JetBrains.ReSharper.Psi.Tree.IArgument CreateArgument(JetBrains.ReSharper.Psi.Tree.ITreeNode context, bool isInternal, JetBrains.ReSharper.Psi.ParameterKind parameterKind, string parameterName, JetBrains.ReSharper.Refactorings.ChangeSignature.IParameterValue defaultValue, out JetBrains.ReSharper.Refactorings.ChangeSignature.ChangeSignatureModel.ArgumentAction postAction) { }
        public override JetBrains.ReSharper.Psi.Tree.IExpression CreateExpression(string text, JetBrains.ReSharper.Psi.Modules.IPsiModule module) { }
        public override JetBrains.ReSharper.Refactorings.ChangeSignature.ChangeSignatureModel CreateModel(JetBrains.ReSharper.Psi.IParametersOwner owner, JetBrains.Application.Progress.IProgressIndicator progressIndicator = null) { }
        public override JetBrains.ReSharper.Refactorings.ChangeSignature.ChangeSignatureModel CreateModel(JetBrains.ReSharper.Psi.IParametersOwner parametersOwner, JetBrains.ReSharper.Refactorings.PushPullTool.Fixes.FixNode fix, JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
        public override JetBrains.ReSharper.Psi.Tree.IParameterDeclaration CreateParameterDeclaration(JetBrains.ReSharper.Psi.Modules.IPsiModule module, string name, JetBrains.ReSharper.Psi.IType type, JetBrains.ReSharper.Psi.ParameterKind parameterKind, bool isParams, bool isVarArg, JetBrains.ReSharper.Psi.Tree.IDeclaration originalDeclaration, bool isThis, JetBrains.ReSharper.Refactorings.ChangeSignature.IParameterValue defaultValue, JetBrains.ReSharper.Refactorings.ChangeSignature.ChangeSignatureModel model) { }
        public override void CreateProxy(JetBrains.ReSharper.Refactorings.ChangeSignature.ChangeSignatureModel changeSignatureModel, System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<JetBrains.ReSharper.Psi.Tree.IArgument, JetBrains.ReSharper.Refactorings.ChangeSignature.ChangeSignatureModel.ArgumentAction>> postActionsList) { }
        public override JetBrains.ReSharper.Psi.Tree.IExpression CreateReferenceExpression(string name, JetBrains.ReSharper.Psi.Modules.IPsiModule module) { }
        public override JetBrains.ReSharper.Psi.Tree.IExpression CreateThisExpression(JetBrains.ReSharper.Psi.Modules.IPsiModule module) { }
        public override JetBrains.ReSharper.Psi.ILocalVariable DeclareLocalVariable(string variableName, JetBrains.ReSharper.Psi.IType variableType, ref JetBrains.ReSharper.Psi.Tree.IExpression beforeExpression, JetBrains.ReSharper.Refactorings.ChangeSignature.IElementsSet elementsToKeep) { }
        public override System.Collections.Generic.Dictionary<int, JetBrains.ReSharper.Refactorings.ChangeSignature.ArgumentInfo> GetArgumentInfos(JetBrains.ReSharper.Psi.Resolve.IReference reference, bool isExtentionCall, JetBrains.ReSharper.Psi.Tree.IArgumentsOwner owner) { }
        public override bool IsAvailable(JetBrains.ReSharper.Psi.IParametersOwner owner) { }
        public override bool IsExtensionCallReference(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public override bool IsLocalEqualToFieldOrAutoProperty(JetBrains.ReSharper.Psi.ITypeMember fieldOrProperty, JetBrains.ReSharper.Psi.IDeclaredElement local, JetBrains.ReSharper.Psi.Tree.ITreeNode place) { }
        public override void RemoveArgument(JetBrains.ReSharper.Psi.Tree.IArgumentsOwner argumentsOwner, JetBrains.ReSharper.Psi.Tree.IArgument toRemove) { }
        protected override JetBrains.ReSharper.Psi.Tree.IArgument ReplaceBy(JetBrains.ReSharper.Psi.Tree.IArgument argument, JetBrains.ReSharper.Psi.Tree.IArgument sharpArgument, JetBrains.ReSharper.Refactorings.ChangeSignature.ChangeSignatureParameter parameter) { }
    }
    public class CSharpChangeSignatureModel : JetBrains.ReSharper.Refactorings.ChangeSignature.ChangeSignatureModel
    {
        public override System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Tree.IDeclaration> BuildParameters(JetBrains.ReSharper.Psi.IParametersOwner parametersOwner, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution) { }
        public override bool CanChangeName() { }
        public override bool CanChangeSignature() { }
        public override bool CanChangeType() { }
        public override bool CanMoveDown(int index) { }
        public override void ChangeImplicitReferences(System.Action<JetBrains.ReSharper.Psi.Resolve.IReference> action) { }
        public override object Clone() { }
        public override bool ConflictsWithOtherInstance(JetBrains.ReSharper.Psi.TypeMemberInstance typeMemberInstance) { }
        public override JetBrains.ReSharper.Psi.Tree.IArgumentsOwner GetCallPreview(JetBrains.ReSharper.Psi.Tree.IArgumentsOwner call, JetBrains.ReSharper.Refactorings.ChangeSignature.ChangeSignatureParameter parameter, JetBrains.ReSharper.Psi.IDeclaredElement argumentValue) { }
        public override string GetOptionalDescription() { }
        public override string GetParameterKindDescription(JetBrains.ReSharper.Psi.ParameterKind kind, bool isParams, bool isVarArg, bool isThis) { }
        public override string GetPreview() { }
        public override JetBrains.ReSharper.Feature.Services.Psi.IUnresolvedTypesChooser GetUnresolvedTypesChooser(JetBrains.ReSharper.Psi.Tree.ITreeNode context) { }
        protected override bool IsUnsafeType(JetBrains.ReSharper.Psi.IType type) { }
        public override string PresentDefaultValue(JetBrains.ReSharper.Psi.IParameter value) { }
        protected override void SetArgumentKind(JetBrains.ReSharper.Psi.Tree.IArgument argument, JetBrains.ReSharper.Psi.ParameterKind kind) { }
    }
}
namespace JetBrains.ReSharper.Refactorings.CSharp.ChangeSignature.WorkItemsFixes
{
    
    [JetBrains.ReSharper.Refactorings.PushPullValue.Nodes.WorkItemFixAttribute()]
    public class AddParameterFix : JetBrains.ReSharper.Refactorings.PushPullValue.Nodes.WorkItemFixBase
    {
        public override string Description { get; }
        protected override bool Execute(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Refactorings.PushPullValue.Nodes.IWorkItemNode> workItems, JetBrains.ProjectModel.ISolution solution) { }
        public bool ExecuteSession(JetBrains.ReSharper.Refactorings.PushPullValue.Nodes.IWorkItemNode workItem) { }
        public override bool IsAvailable(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Refactorings.PushPullValue.Nodes.IWorkItemNode> workItems) { }
    }
}
namespace JetBrains.ReSharper.Refactorings.CSharp.ChangeStaticness
{
    
    public class CSharpMakeStatic : JetBrains.ReSharper.Refactorings.ChangeStaticness.ToStatic.MakeStatic
    {
        public CSharpMakeStatic(JetBrains.ReSharper.Refactorings.ChangeStaticness.ToStatic.MakeStaticWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public override JetBrains.ReSharper.Refactorings.Inline.InlineHelper InlineHelper { get; }
        public override void AddArgument(JetBrains.ReSharper.Psi.Resolve.IReference reference, string name) { }
        public override void AddArgumentAndBind(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.IOverridableMember member, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution, JetBrains.ReSharper.Psi.DisposableMarker marker) { }
        public override JetBrains.ReSharper.Psi.IParameter AddParameter(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration, JetBrains.ReSharper.Psi.IType type, string name) { }
        public override void BindTo(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.IOverridableMember member, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution) { }
        public override void CallInline(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Refactorings.Inline.CallSiteContext context, JetBrains.ReSharper.Refactorings.Inline.InlinedCallInfo info, System.Collections.Generic.IList<string> lambdaParameterNames) { }
        public override JetBrains.ReSharper.Psi.Resolve.IReference ConvertMethodGroupToLambda(JetBrains.ReSharper.Psi.Resolve.IReference reference, System.Collections.Generic.IList<JetBrains.ReSharper.Psi.IParameter> inlinedMethodInfo) { }
        public override void FixOtherArguments(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Refactorings.Inline.InlinedCallInfo info, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution) { }
        public override void Qualify(JetBrains.ReSharper.Psi.Tree.ITreeNode node, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IParameter parameter) { }
        public override int ReferencesToThis(JetBrains.ReSharper.Psi.Tree.IExpression expression) { }
        public override void Replace(JetBrains.ReSharper.Psi.Tree.ITreeNode node, string name) { }
        public override void SetStatic(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration) { }
    }
    public class CSharpMakeStaticHelper : JetBrains.ReSharper.Refactorings.ChangeStaticness.ToStatic.IMakeStaticHelper, JetBrains.ReSharper.Refactorings.IWorkflowExec
    {
        public bool IsLanguageSupported { get; }
        public bool CheckElement(JetBrains.ReSharper.Psi.IOverridableMember overridableMember) { }
        public JetBrains.ReSharper.Psi.Tree.ITreeNode GetInvocation(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public string GetTitle() { }
        public bool IsThis(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public bool IsWriting(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
    }
}
namespace JetBrains.ReSharper.Refactorings.CSharp.ClassFromParameters
{
    
    public sealed class CsClassFromParameters : JetBrains.ReSharper.Refactorings.ClassFromParameters.ClassFromParametersBase
    {
        public CsClassFromParameters(JetBrains.ReSharper.Refactorings.ClassFromParameters.ClassFromParametersWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public override void FixUsage(JetBrains.ReSharper.Refactorings.ClassFromParameters.PreProcessedCall call, string name) { }
        public override bool IsPureRecursiveCall(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.IOverridableMember calledMethod, JetBrains.ReSharper.Psi.ITypeElement typeElement) { }
        public override JetBrains.ReSharper.Refactorings.ClassFromParameters.PreProcessedCall PreProcessCall(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public override void Transform(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.IProperty property, JetBrains.ReSharper.Psi.IParameter parameter) { }
    }
}
namespace JetBrains.ReSharper.Refactorings.CSharp.Common
{
    
    public class CsProperty2FunctionDeclarationProcessor : JetBrains.ReSharper.Refactorings.Common.Convert.Property2FunctionDeclarationProcessor<JetBrains.ReSharper.Psi.CSharp.Tree.IMethodDeclaration>
    {
        protected override JetBrains.ReSharper.Psi.CSharp.Tree.IMethodDeclaration AddAccessor(JetBrains.ReSharper.Psi.CSharp.Tree.IMethodDeclaration newDeclaration, JetBrains.ReSharper.Psi.IProperty property) { }
        protected override bool CheckIsAuto(JetBrains.ReSharper.Psi.IProperty property) { }
        public static JetBrains.ReSharper.Psi.CSharp.Tree.IMethodDeclaration CreateAccessorDeclaration(bool withBody, JetBrains.ReSharper.Psi.IProperty property, JetBrains.ReSharper.Psi.IAccessor accessor, string accessorName, string accessorTemplate) { }
        protected override JetBrains.ReSharper.Psi.IProperty CreateFieldForAutoProperty(JetBrains.ReSharper.Psi.IProperty property) { }
        protected override void FixCommentToGetter(JetBrains.ReSharper.Psi.Tree.IDocCommentBlockOwnerNode owner) { }
        protected override void FixCommentToSetter(JetBrains.ReSharper.Psi.Tree.IDocCommentBlockOwnerNode owner) { }
        protected override string GetterPattern(bool isAbstract, bool isInterface) { }
        protected override void RemoveBaseDeclaration(JetBrains.ReSharper.Psi.IProperty property) { }
        protected override void RemoveGetter(JetBrains.ReSharper.Psi.IProperty property) { }
        protected override void RemoveSetter(JetBrains.ReSharper.Psi.IProperty property) { }
        protected override string SetterPattern(bool isAbstract, bool isInterface, JetBrains.ReSharper.Psi.IProperty property) { }
    }
    public class CsProperty2FunctionReferencesProcessor : JetBrains.ReSharper.Refactorings.Common.Convert.Property2FunctionReferencesProcessor
    {
        public CsProperty2FunctionReferencesProcessor(JetBrains.ReSharper.Refactorings.Property2Function.Property2FunctionBase refactoring) { }
        public override void ReplaceReadOccurence(JetBrains.ReSharper.Psi.Tree.IExpression expression) { }
        public override bool ReplaceReadWriteOccurence(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.Tree.IExpression expression) { }
        public override bool ReplaceWriteProperty(JetBrains.ReSharper.Psi.Tree.IExpression expression, JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public override bool TryTransformMthodCall(JetBrains.ReSharper.Psi.Tree.IExpression expression) { }
    }
}
namespace JetBrains.ReSharper.Refactorings.CSharp.Constructor2FactoryMethod
{
    
    public class CSharpConstructorToFactoryMethod : JetBrains.ReSharper.Refactorings.Constructor2FactoryMethod.ConstructorToFactoryMethodBase
    {
        public CSharpConstructorToFactoryMethod(JetBrains.ReSharper.Refactorings.Constructor2FactoryMethod.Constructor2FactoryMethodWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public override void ConvertUsage(JetBrains.ReSharper.Psi.ITypeMember method, JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public override JetBrains.ReSharper.Psi.ITypeMember CreateFactoryMethodDeclaration(JetBrains.ReSharper.Psi.ITypeElement targetTypeElement, JetBrains.ReSharper.Psi.IConstructor constructorToCall, string factorymethodName) { }
        public override string GetModifiersString(JetBrains.ReSharper.Psi.IParameter x) { }
        public override bool IsBaseConstructorInitializer(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
    }
}
namespace JetBrains.ReSharper.Refactorings.CSharp.Convert
{
    
    public class CsConvert : JetBrains.ReSharper.Refactorings.Convert.Common.ConvertTypeBase<JetBrains.ReSharper.Psi.CSharp.Tree.IClassMemberDeclaration, JetBrains.ReSharper.Psi.CSharp.Tree.IClassLikeDeclaration>
    {
        public System.Collections.Generic.Dictionary<JetBrains.ReSharper.Psi.CSharp.Tree.IClassLikeDeclaration, JetBrains.ReSharper.Psi.CSharp.Tree.IClassLikeDeclaration> myPartsMap;
        public CsConvert(JetBrains.ReSharper.Refactorings.Convert.Common.IConvertTypeWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public override bool AllImplementationsAreExplicit { get; }
        public override void AddInterface(JetBrains.ReSharper.Psi.ITypeElement typeElement, JetBrains.ReSharper.Psi.IExplicitImplementation interfaceToAdd) { }
        protected override void AddSuperInterface(JetBrains.ReSharper.Psi.Tree.ITypeDeclaration to, JetBrains.ReSharper.Psi.IDeclaredType newSuprtType) { }
        protected override bool CanCallMoreGeneric(JetBrains.ReSharper.Psi.OverridableMemberInstance moreGenericInstance, JetBrains.ReSharper.Psi.OverridableMemberInstance lessGenericInstance, JetBrains.ReSharper.Psi.CSharp.Tree.IClassLikeDeclaration classDecl) { }
        public override void CreateClassDeclaration(JetBrains.ReSharper.Psi.IInterface @interface) { }
        public override void ImplementsMembersAbstract() { }
        protected override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.CSharp.Tree.IClassMemberDeclaration> MakeAbstractDeclaration(JetBrains.ReSharper.Psi.CSharp.Tree.IClassLikeDeclaration classDecl, JetBrains.ReSharper.Refactorings.Convert.Common.ElementInstancePointer pointer, int indexForVB, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IType> lsitOfTypes, bool makePrivate) { }
        protected override void MakeCallMoreGeneric(JetBrains.ReSharper.Psi.CSharp.Tree.IClassLikeDeclaration classToAddNewDeclaration, JetBrains.ReSharper.Refactorings.Convert.Common.ElementInstancePointer memberCaller, JetBrains.ReSharper.Refactorings.Convert.Common.ElementInstancePointer memberCallee, JetBrains.ReSharper.Psi.IType type) { }
        protected override void MakePrivateImplementation(JetBrains.ReSharper.Refactorings.Convert.Common.ElementInstancePointer pointer, JetBrains.ReSharper.Psi.CSharp.Tree.IClassMemberDeclaration newDecl) { }
        public override void MakePublic(JetBrains.ReSharper.Psi.IOverridableMember member) { }
        public override void MakePublicOverride(JetBrains.ReSharper.Psi.IOverridableMember member, JetBrains.ReSharper.Psi.IDeclaredType declTypeToRemove) { }
        public override bool MakeVirtual(JetBrains.ReSharper.Psi.IOverridableMember member) { }
        protected override void Privatizate(JetBrains.ReSharper.Psi.CSharp.Tree.IClassMemberDeclaration newDecl) { }
        public override void ProcessOtherMember(JetBrains.ReSharper.Psi.ITypeMember member) { }
        public override bool ProcessOverridableMember(JetBrains.ReSharper.Psi.IOverridableMember overridable, JetBrains.Application.Progress.IProgressIndicator pi) { }
        public override void RemoveDeclaration(JetBrains.ReSharper.Psi.IOverridableMember member) { }
        public override void RemoveInterface(JetBrains.ReSharper.Psi.ITypeElement implementor, JetBrains.ReSharper.Psi.IInterface interfaceToRemove) { }
        public override void ReplaceMembers(JetBrains.ReSharper.Psi.IClass clsss) { }
    }
    public class InterfaceMembersCollector : JetBrains.ReSharper.Refactorings.Convert.Common.InterfaceMembersCollectorBase
    {
        public InterfaceMembersCollector(bool keepAllExplicitlyImplemented) { }
        public static System.Collections.Generic.IList<JetBrains.ReSharper.Refactorings.Convert.Common.ElementInstancePointer> GetInterfaceMembers(JetBrains.ReSharper.Psi.Tree.ITypeDeclaration typeDeclaration, bool keepAllNotExplicitlyImplemented) { }
        protected override bool IsPrimaryTypeMember(JetBrains.ReSharper.Psi.ITypeMember overridableMember) { }
        protected override void ProcessPrivateImplementations(JetBrains.ReSharper.Psi.IOverridableMember overridableMember, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution, JetBrains.ReSharper.Refactorings.Convert.Common.InterfaceMembersCollectorBase.OverridableMemberInfo overridableMemberInfo, bool processingInheritedMembers) { }
    }
}
namespace JetBrains.ReSharper.Refactorings.CSharp
{
    
    public class CSharpIntroduceVariableHelper : JetBrains.ReSharper.Refactorings.IntroduceVariable.IntroduceVariableHelper
    {
        public override bool IsLanguageSupported { get; }
        public override bool CheckAvailability(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public override bool CheckOccurrence(JetBrains.ReSharper.Psi.Tree.ITreeNode masterExpression, JetBrains.ReSharper.Psi.Tree.ITreeNode occurrence) { }
        public override JetBrains.ReSharper.Psi.Tree.ITreeNode GetScope(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.CSharp.CSharpLanguage))]
    public class CSharpRefactoringLanguageService : JetBrains.ReSharper.Refactorings.InternalRefactoringLanguageService
    {
        public override JetBrains.ReSharper.Refactorings.RefactoringsHelper Helper { get; }
        public override JetBrains.ReSharper.Refactorings.Convert.Common.IConvert CreateAbstract2Interface(JetBrains.ReSharper.Refactorings.Convert.Abstract2Interface.Abstract2InterfaceWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public override JetBrains.ReSharper.Refactorings.Move.AdjustNamespaces.AdjustNamespacesHelperBase CreateAdjustNamespaceHelper() { }
        public override JetBrains.ReSharper.Refactorings.Anotype2DeclaredType.Anonymous2Declared CreateAnonymous2Declared(JetBrains.ReSharper.Refactorings.Anotype2DeclaredType.Anonymous2DeclaredWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public override JetBrains.ReSharper.Refactorings.ClassFromParameters.ClassFromParametersBase CreateClassFromParameters(JetBrains.ReSharper.Refactorings.ClassFromParameters.ClassFromParametersWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public override JetBrains.ReSharper.Refactorings.Constructor2FactoryMethod.ConstructorToFactoryMethodBase CreateConstructor2FactoryMethod(JetBrains.ReSharper.Refactorings.Constructor2FactoryMethod.Constructor2FactoryMethodWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public override JetBrains.ReSharper.Refactorings.EncapsulateField.EncapsulateFieldBase CreateEncapsulateField(JetBrains.ReSharper.Refactorings.EncapsulateField.EncapsulateFieldWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public override JetBrains.ReSharper.Refactorings.ExtractClass.ExtractClassHelper CreateExtractClassHelper(JetBrains.ReSharper.Refactorings.ExtractClass.ExtractClassWorkflow workflow) { }
        public override JetBrains.ReSharper.Refactorings.InlineClass.InlineClassHelper CreateInlineClassHelper(JetBrains.ReSharper.Refactorings.InlineClass.InlineClassWorkflow workflow) { }
        public override JetBrains.ReSharper.Refactorings.InlineField.InlineFieldBase CreateInlineField(JetBrains.ReSharper.Refactorings.InlineField.InlineFieldWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public override JetBrains.ReSharper.Refactorings.Inline.InlineMethod CreateInlineMethod(JetBrains.ReSharper.Refactorings.Inline.InlineMethodWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public override JetBrains.ReSharper.Refactorings.InlineParameter.InlineParameterBase CreateInlineParameter(JetBrains.ReSharper.Refactorings.InlineParameter.InlineParameterWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public override JetBrains.ReSharper.Refactorings.InlineParameter.InlineParameterHelper CreateInlineParameterHelper() { }
        public override JetBrains.ReSharper.Refactorings.InlineVar.InlineVarBase CreateInlineVar(JetBrains.ReSharper.Refactorings.InlineVar.InlineVarWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public override JetBrains.ReSharper.Refactorings.Convert.Common.IConvert CreateInterface2Abstract(JetBrains.ReSharper.Refactorings.Convert.Interface2Abstract.Interface2AbstractWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public override JetBrains.ReSharper.Refactorings.IntroduceField.IntroFieldBase CreateIntroduceField(JetBrains.ReSharper.Refactorings.IntroduceField.IntroFieldWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public override JetBrains.ReSharper.Refactorings.IntroduceVariable.IntroduceVariableBase CreateIntroduceVariable(JetBrains.ReSharper.Refactorings.IntroduceVariable.IntroduceLocalWorkflowBase workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public override JetBrains.ReSharper.Refactorings.IntroduceVariable.IntroduceVariableHelper CreateIntroduceVariableHelper() { }
        public override JetBrains.ReSharper.Refactorings.IntroduceParameter.IntroduceParameterBase CreateIntroRefactoring(JetBrains.ReSharper.Refactorings.IntroduceParameter.IntroduceParameterWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public override JetBrains.ReSharper.Refactorings.ChangeStaticness.ToStatic.MakeStatic CreateMakeStatic(JetBrains.ReSharper.Refactorings.ChangeStaticness.ToStatic.MakeStaticWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public override JetBrains.ReSharper.Refactorings.ChangeStaticness.ToStatic.IMakeStaticHelper CreateMakeStaticHelper() { }
        public override JetBrains.ReSharper.Refactorings.MoveInstanceMethod.MoveInstanceMethodHelper CreateMoveInstanceMethodHelper(JetBrains.ReSharper.Refactorings.MoveInstanceMethod.MoveInstanceMethodWorkflow moveInstanceMethodWorkflow) { }
        public override JetBrains.ReSharper.Refactorings.Move.MoveIntoMatchingFile.MoveIntoMatchingFilesHelperBase CreateMoveIntoMatchingFilesHelper() { }
        public override JetBrains.ReSharper.Refactorings.MoveStaticMembers.MoveStaticMembers CreateMoveStaticMembers(JetBrains.ReSharper.Refactorings.MoveStaticMembers.MoveStaticMembersWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public override JetBrains.ReSharper.Refactorings.MoveStaticMembers.MoveStaticMembersHelper CreateMoveStaticMembersHelper() { }
        public override JetBrains.ReSharper.Refactorings.Move.MoveTypeDeclarationToFile.MoveToFileHelperBase CreateMoveToFileHelper() { }
        public override JetBrains.ReSharper.Refactorings.Move.MoveToFolder.MoveToFolderHelperBase CreateMoveToFolderHelper() { }
        public override JetBrains.ReSharper.Refactorings.Move.MoveToNamespace.MoveToNamespaceHelperBase CreateMoveToNamespaceHelper() { }
        public override JetBrains.ReSharper.Refactorings.Property2Auto.Property2AutoBase CreateProperty2Auto(JetBrains.ReSharper.Refactorings.Property2Auto.Property2AutoWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public override JetBrains.ReSharper.Refactorings.SafeDeleteTheSecond.SafeDeleteBase CreateSafeDeleteBase(JetBrains.ReSharper.Refactorings.SafeDeleteTheSecond.SafeDeleteWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public override JetBrains.ReSharper.Refactorings.SafeDeleteFolder.SafeDeleteFolderHelperBase CreateSafeDeleteFolderHelper() { }
        public override JetBrains.ReSharper.Refactorings.SafeDeleteTheSecond.SafeDeleteHelperUnsupported CreateSafeDeleteHelper() { }
        public override JetBrains.ReSharper.Refactorings.Static2Extension.Static2ExtensionBase CreateStatic2Extension(JetBrains.ReSharper.Refactorings.Static2Extension.Static2ExtensionWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public override JetBrains.ReSharper.Refactorings.TransformOutParameters.TransformOutParametersHelper CreateTransformOutParametersHelper(JetBrains.ReSharper.Refactorings.TransformOutParameters.TransformOutParametersWorkflow workflow) { }
        public override JetBrains.ReSharper.Refactorings.UseBaseType.UseBaseTypeBase CreateUseBaseType(JetBrains.ReSharper.Refactorings.UseBaseType.UseBaseTypeWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public override JetBrains.ReSharper.Refactorings.ExtractClass.ExtractClassRefactoringExec ExtractClassExec(JetBrains.ReSharper.Refactorings.ExtractClass.ExtractClassWorkflow workflow) { }
        public override JetBrains.ReSharper.Refactorings.MoveMembers.ImplExtractInterface.IExtractInterface ExtractInterfaceRefactoring(JetBrains.ReSharper.Refactorings.MoveMembers.ImplExtractInterface.ExtractInterfaceWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public override JetBrains.ReSharper.Refactorings.MoveMembers.ImplExtractSuperclass.IExtractSuperclass ExtractSuperclassRefactoring(JetBrains.ReSharper.Refactorings.MoveMembers.ImplExtractSuperclass.ExtractSuperclassWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public override JetBrains.ReSharper.Refactorings.Common.Convert.IConvertRefactoring Function2Indexer(JetBrains.ReSharper.Refactorings.Function2Property.Function2PropertyWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public override JetBrains.ReSharper.Refactorings.Common.Convert.IConvertRefactoring Function2Property(JetBrains.ReSharper.Refactorings.Function2Property.Function2PropertyWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public override JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage GetFunction2PropertyUI(JetBrains.ReSharper.Refactorings.Function2Property.Function2PropertyWorkflow workflow) { }
        public override JetBrains.ReSharper.Refactorings.Common.Convert.IConvertRefactoring Indexer2Function(JetBrains.ReSharper.Refactorings.Property2Function.Property2FunctionWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public override JetBrains.ReSharper.Refactorings.InlineClass.IInlineClassRefactoringExec InlineClassExec(JetBrains.ReSharper.Refactorings.InlineClass.InlineClassWorkflow workflow) { }
        public override JetBrains.ReSharper.Refactorings.Iterator2Function.Iterator2FunctionBase Iterator2Function(JetBrains.ReSharper.Refactorings.Iterator2Function.Iterator2FunctionWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public override JetBrains.ReSharper.Refactorings.MoveInnerClass.IMoveTypeToOuterScope MoveTypeToOuterScope(JetBrains.ReSharper.Refactorings.MoveInnerClass.MoveTypeToOuterScopeRefactoring refactoring) { }
        public override JetBrains.ReSharper.Refactorings.Common.Convert.IConvertRefactoring Property2Function(JetBrains.ReSharper.Refactorings.Property2Function.Property2FunctionWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public override JetBrains.ReSharper.Refactorings.MoveMembers.ImplPullUp.IPullUp PullUpRefactoring(JetBrains.ReSharper.Refactorings.MoveMembers.ImplPullUp.PullUpWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public override JetBrains.ReSharper.Refactorings.MoveMembers.ImplPushDown.IPushDown PushDownRefactoring(JetBrains.ReSharper.Refactorings.MoveMembers.ImplPushDown.PushDownWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
    }
    public class CSharpRefactoringsHelper : JetBrains.ReSharper.Refactorings.RefactoringsHelper
    {
        public override bool CanBeDefault(JetBrains.ReSharper.Psi.Tree.IExpression expression) { }
        public override bool CanContainExtensionMethods(JetBrains.ReSharper.Psi.IClass @class) { }
        public override bool CanExtractSuperclass(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration) { }
        public override bool CanUseExplicitly(JetBrains.ReSharper.Psi.IType type) { }
        public override bool CanUseInstanceFields(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public override bool CheckAnonymous2Declared(JetBrains.Application.DataContext.IDataContext context, out JetBrains.ReSharper.Psi.Tree.ITreeNode objectCreationElement) { }
        public override bool CheckForIntroduceAccessible(JetBrains.ReSharper.Psi.Tree.ITreeNode expression) { }
        public override JetBrains.ReSharper.Refactorings.InlineVar.RDAnalysis.InlineVarAnalyserBase CreateInlineVarAnalyser(JetBrains.ReSharper.Refactorings.InlineVar.InlineVarWorkflow workflow) { }
        public override JetBrains.ReSharper.Refactorings.IntroduceField.IntroFieldAnalyser CreateIntroFieldAnalyser() { }
        public virtual JetBrains.ReSharper.Refactorings.IntroduceParameter.IntroduceParameterBase CreateIntroRefactoring(JetBrains.ReSharper.Refactorings.IntroduceParameter.IntroduceParameterWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public override JetBrains.ReSharper.Refactorings.Property2Auto.IProperty2AutoChecker CreateProperty2AutoChecker() { }
        public override bool DeclarationHasBody(JetBrains.ReSharper.Psi.IDeclaredElement element) { }
        public override bool ExtentionMethodsSupported(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public override bool Function2PropertyAvailable(JetBrains.ReSharper.Psi.IMethod method) { }
        public override JetBrains.ReSharper.Psi.Tree.IArgumentsOwner GetArgumentsOwner(ref JetBrains.ReSharper.Psi.Resolve.IReference reference, bool replaceMethodGroup) { }
        public override JetBrains.ReSharper.Psi.Tree.ITreeNode GetContainingLambda(JetBrains.ReSharper.Psi.Tree.ITreeNode expression) { }
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IDeclaredElement> GetLocals(JetBrains.ReSharper.Psi.Tree.IExpression expression, JetBrains.ReSharper.Psi.IParametersOwner owner) { }
        public override T GetMainElement<T>(T parametersOwner)
            where T : JetBrains.ReSharper.Psi.IDeclaredElement { }
        public override JetBrains.ReSharper.Psi.IDeclaredElement GetPrimaryQueryElement(JetBrains.ReSharper.Psi.IDeclaredElement variable) { }
        public override JetBrains.ReSharper.Refactorings.Util.ReferenceComparatorDelegate GetReferenceComparator() { }
        public override bool GetShouldBeConstant(JetBrains.ReSharper.Psi.Tree.IExpression expression) { }
        public override JetBrains.ReSharper.Psi.Tree.ITreeNode GetStatementVisibleForAll(System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Tree.IExpression> expressions) { }
        public override JetBrains.ReSharper.Psi.Tree.ITypeDeclaration GetTypeDeclarationForField(JetBrains.ReSharper.Psi.Tree.ITypeDeclaration typeDeclaration, out bool baseTypeChoosed) { }
        public override bool HasIndexerToFunction() { }
        public override bool HasIninializer(JetBrains.ReSharper.Psi.IField field) { }
        public override bool IndexerIsPresented() { }
        public override bool InitializerIsRecursive(JetBrains.ReSharper.Psi.IDeclaredElement element) { }
        public override JetBrains.ReSharper.Psi.Tree.IExpression IntroParameterGetInitializer(JetBrains.ReSharper.Psi.ILocalVariable variable) { }
        public override bool IsAsyncMethod(JetBrains.ReSharper.Psi.ITypeMember member) { }
        public override bool IsCSharp3Supported(JetBrains.ReSharper.Psi.IDeclaredElement element) { }
        public override bool IsInvocationReference(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public override bool IsIterator(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration) { }
        public override bool IsLetVariable(JetBrains.ReSharper.Psi.IDeclaredElement element) { }
        public override bool IsNew(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration) { }
        public override bool IsPartialMethod(JetBrains.ReSharper.Psi.ITypeMember member) { }
        public override bool IsReferenceName(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public override JetBrains.ReSharper.Refactorings.Helpers.INamespaceRedundancyProblemFixer NamespaceRedundancyFileFixer(JetBrains.ReSharper.Psi.INamespace @namespace, JetBrains.ReSharper.Psi.Tree.IFile file) { }
        public override bool ReferencesRangeVariables(JetBrains.ReSharper.Psi.Tree.IExpression expression) { }
        public override JetBrains.ReSharper.Psi.Resolve.IReference RemoveQualification(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public override void SetNew(JetBrains.ReSharper.Psi.Tree.ITypeMemberDeclaration typeMember, bool isNew) { }
    }
    public class ElementSearcherInSubquery : JetBrains.ReSharper.Psi.IRecursiveElementProcessor
    {
        public bool ProcessingIsFinished { get; }
        public static bool Contains(JetBrains.ReSharper.Refactorings.CSharp.IntroduceVariable.SubQuerySelection selection, JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public bool InteriorShouldBeProcessed(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public void ProcessAfterInterior(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public void ProcessBeforeInterior(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
    }
    public class ReferenceCollectorOfQuerySelection : JetBrains.ReSharper.Psi.IRecursiveElementProcessor
    {
        public bool ProcessingIsFinished { get; }
        public static System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.Resolve.IReference> GetNotSelectedReferences(JetBrains.ReSharper.Refactorings.CSharp.IntroduceVariable.SubQuerySelection selection) { }
        public static System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.Resolve.IReference> GetSelectedReferences(JetBrains.ReSharper.Refactorings.CSharp.IntroduceVariable.SubQuerySelection selection) { }
        public bool InteriorShouldBeProcessed(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public void ProcessAfterInterior(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public void ProcessBeforeInterior(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
    }
}
namespace JetBrains.ReSharper.Refactorings.CSharp.EncapsulateField
{
    
    public class CSharpEncapsulateField : JetBrains.ReSharper.Refactorings.EncapsulateField.EncapsulateFieldBase
    {
        public CSharpEncapsulateField(JetBrains.ReSharper.Refactorings.EncapsulateField.EncapsulateFieldWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public override void AddReadAccessor(JetBrains.ReSharper.Psi.IProperty property, JetBrains.ReSharper.Psi.IField field) { }
        public override void AddWriteAccessor(JetBrains.ReSharper.Psi.IProperty property, JetBrains.ReSharper.Psi.IField field) { }
        public static JetBrains.ReSharper.Psi.IField AnalyseGetterReturn(JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpStatement statement) { }
        public static JetBrains.ReSharper.Psi.IField AnalyseSetter(JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpStatement statement) { }
        public static JetBrains.ReSharper.Psi.IField CheckAccessor(JetBrains.ReSharper.Psi.IProperty property, JetBrains.ReSharper.Refactorings.CSharp.EncapsulateField.CSharpEncapsulateField.AnalyseStatement analyse, JetBrains.ReSharper.Psi.AccessorKind kind) { }
        public override JetBrains.ReSharper.Psi.IProperty CreatePropertyDeclaration(JetBrains.ReSharper.Psi.IField field, string fieldNewName) { }
        public override JetBrains.ReSharper.Psi.IField GetBackingFieldForGetter(JetBrains.ReSharper.Psi.IProperty property) { }
        public override JetBrains.ReSharper.Psi.IField GetBackingFieldForSetter(JetBrains.ReSharper.Psi.IProperty property) { }
        public override void ProcessReference(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.ReferenceAccessType accessType, JetBrains.ReSharper.Psi.IProperty property) { }
        public void ReplaceReference(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.IProperty property) { }
        public delegate JetBrains.ReSharper.Psi.IField AnalyseStatement(JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpStatement statement);
    }
}
namespace JetBrains.ReSharper.Refactorings.CSharp.ExtractClass
{
    
    public class CsExtractClassAnalyzer : JetBrains.ReSharper.Refactorings.ExtractClass.Analysis.ExtractClassAnalyzer
    {
        public CsExtractClassAnalyzer(JetBrains.ReSharper.Refactorings.ExtractClass.ExtractClassWorkflow workflow, JetBrains.Util.FileSystemPath pathName) { }
        protected override void CreateConstructors() { }
        public override void InitializeMembers(System.Func<JetBrains.ReSharper.Psi.ITypeMember, bool> isMemberIncluded) { }
        public JetBrains.ReSharper.Refactorings.CSharp.ExtractClass.CsExtractClassAnalyzer.ReferenceResult ProcessReference(JetBrains.ReSharper.Psi.Tree.IExpression expression) { }
        public enum ReferenceResult
        {
            Param = 0,
            Free = 1,
            Included = 2,
            Literal = 3,
            None = 4,
        }
    }
    public class CsExtractClassHelper : JetBrains.ReSharper.Refactorings.ExtractClass.ExtractClassHelper
    {
        public override bool IsLanguageSupported { get; }
        protected static System.Collections.Generic.JetHashSet<JetBrains.ReSharper.Psi.ITypeParameter> CollectParameters(System.Collections.Generic.JetHashSet<JetBrains.ReSharper.Psi.ITypeParameter> sourceTypeTypeParameters, JetBrains.ReSharper.Psi.ITypeElement source) { }
        public override JetBrains.ReSharper.Psi.Tree.ITypeDeclaration CreateTargetTypeElement(out System.Collections.Generic.Dictionary<, > typeParams, JetBrains.ReSharper.Refactorings.ExtractClass.ExtractClassWorkflow workflow) { }
        public override JetBrains.ReSharper.Refactorings.ExtractClass.Analysis.ExtractClassAnalyzer GetAnalyzer(JetBrains.ReSharper.Refactorings.ExtractClass.ExtractClassWorkflow extractClassWorkflow, JetBrains.ReSharper.Psi.ITypeElement owner, string namespaceName, JetBrains.Util.FileSystemPath pathName) { }
        protected static System.Collections.Generic.List<JetBrains.ReSharper.Psi.ITypeParameter> GetUsedTypeParameters(JetBrains.ReSharper.Psi.CSharp.Tree.IClassLikeDeclaration sourceTypeDeclaration) { }
        public override JetBrains.ReSharper.Psi.Tree.ITypeDeclaration InsertSibling(JetBrains.ReSharper.Psi.Tree.ITypeDeclaration declarationToInsert, JetBrains.ReSharper.Psi.Tree.ITypeDeclaration tagDeclaration) { }
        public override JetBrains.ReSharper.Psi.Tree.ITypeDeclaration InsertToNewFile(JetBrains.ReSharper.Psi.Tree.ITypeDeclaration declarationToInsert, JetBrains.ReSharper.Psi.Tree.ITypeDeclaration tagDeclaration, string targetNamespace, JetBrains.ProjectModel.IProjectFile fileNearby) { }
    }
    public class CsExtractClassRefactoringExec : JetBrains.ReSharper.Refactorings.ExtractClass.ExtractClassRefactoringExec
    {
        public CsExtractClassRefactoringExec(JetBrains.ReSharper.Refactorings.ExtractClass.ExtractClassWorkflow workflow) { }
        public void AddAccessorsToProperty(JetBrains.ReSharper.Psi.IProperty property, JetBrains.ReSharper.Psi.IField field) { }
        public void AddConstructors() { }
        public override void AddField(JetBrains.ReSharper.Psi.ITypeElement sourceTypeElement, JetBrains.ReSharper.Psi.ITypeElement targetTypeElement) { }
        public override void AddProperties() { }
        public void ChangeAccessModifiers(JetBrains.ReSharper.Psi.IProperty property) { }
        public void CreateConstructor(JetBrains.ReSharper.Refactorings.ExtractClass.ConstructorInfo constructorInfo, bool insertThis) { }
        public override void CreateConstructors() { }
        public bool CreateDelegatingCopy(JetBrains.ReSharper.Refactorings.ExtractClass.Info.MemberInfo member, JetBrains.ReSharper.Psi.Tree.ITypeMemberDeclaration memberDeclaration, JetBrains.ReSharper.Psi.CSharp.Tree.IClassLikeDeclaration targetTypeDeclaration, JetBrains.ReSharper.Refactorings.Util.NewTypeImages.ResolveImagesRepository repository) { }
        public JetBrains.ReSharper.Psi.CSharp.Tree.IPropertyDeclaration CreatePropertyDeclaration(JetBrains.ReSharper.Psi.Tree.ITypeDeclaration sourceTypeDeclaration, JetBrains.ReSharper.Psi.IType type, JetBrains.ReSharper.Psi.Tree.ITypeMemberDeclaration fieldDeclaration, bool addSetter, bool isStatic) { }
        public override bool CutAndPaste(JetBrains.ReSharper.Refactorings.Util.NewTypeImages.ResolveImagesRepository repository, System.Collections.Generic.Dictionary<JetBrains.ReSharper.Psi.ITypeParameter, JetBrains.ReSharper.Psi.ITypeParameter> createdTypeParametersMap, JetBrains.Application.Progress.IProgressIndicator pi) { }
        public void FixExtensionMethod(JetBrains.ReSharper.Psi.CSharp.Tree.IMethodDeclaration targetMethodDeclaration) { }
        public override void Rebind(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Refactorings.ExtractClass.Info.MemberInfo memberToRebind, JetBrains.ReSharper.Psi.IDeclaredElement propertyMember) { }
        public override void ResolveConflicts(JetBrains.Application.Progress.IProgressIndicator subPi) { }
    }
}
namespace JetBrains.ReSharper.Refactorings.CSharp.ExtractMethod2.Common
{
    
    public enum CSharpExtractMethodExtractedEntityKind
    {
        Method = 0,
        Property = 1,
        ChainedConstructor = 2,
    }
    public abstract class CSharpExtractMethodParameter
    {
        protected CSharpExtractMethodParameter() { }
        [JetBrains.Annotations.UsedImplicitlyAttribute()]
        public string DisplayKind { get; }
        public bool HasDeclarationInside { get; set; }
        public bool HasDeclarationOutside { get; set; }
        public bool HasUsagesOutside { get; set; }
        public int Index { get; set; }
        public virtual bool IsForReturnValue { get; }
        public JetBrains.ReSharper.Refactorings.CSharp.ExtractMethod2.Common.CSharpExtractMethodParameterKind Kind { get; set; }
        public string Name { get; set; }
        public System.Collections.Generic.List<JetBrains.ReSharper.Psi.TreeTextRange> Ranges { get; set; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Naming.Impl.NameRoot> Roots { get; set; }
        public bool UserIncluded { get; set; }
        public virtual void AddCall(JetBrains.ReSharper.Psi.CSharp.CSharpElementFactory factory, JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpExpression call, JetBrains.ReSharper.Psi.CSharp.Tree.IBlock blockForCallSite, JetBrains.ReSharper.Refactorings.CSharp.ExtractMethod2.ControlFlow.ICSharpExtractMethodControlFlowInspectionResult inspectionResult) { }
        protected void AddDefaultExit(JetBrains.ReSharper.Psi.CSharp.Tree.IBlock blockForCallSite, JetBrains.ReSharper.Psi.CSharp.CSharpElementFactory factory, JetBrains.ReSharper.Refactorings.CSharp.ExtractMethod2.ControlFlow.ICSharpExtractMethodControlFlowInspectionResult inspectionResult) { }
        public virtual bool CanUseWithReturnValue(JetBrains.ReSharper.Refactorings.CSharp.ExtractMethod2.Common.CSharpExtractMethodParameter returnValueParameter) { }
        public static JetBrains.ReSharper.Refactorings.CSharp.ExtractMethod2.Common.CSharpExtractMethodParameter Create(JetBrains.ReSharper.Psi.ITypeOwner typeOwner, bool declarationIsLocal) { }
        public virtual JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpExpression CreateArgumentValue(JetBrains.ReSharper.Psi.CSharp.CSharpElementFactory factory) { }
        public virtual JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpStatement CreateAssignmentToReturnValue(JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpStatement statement) { }
        public virtual JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpStatement CreateReturnValue(JetBrains.ReSharper.Psi.CSharp.CSharpElementFactory factory, JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpStatement originalStatement, JetBrains.ReSharper.Refactorings.CSharp.ExtractMethod2.ControlFlow.ICSharpExtractMethodControlFlowInspectionResult inspector, bool isExitClassA) { }
        public virtual string Dump() { }
        public abstract JetBrains.ReSharper.Psi.IType GetParameterType(JetBrains.ReSharper.Psi.Modules.IPsiModule module);
        public virtual bool IsFieldLike() { }
        public virtual void SuggestName(JetBrains.ReSharper.Psi.Naming.Extentions.INamesCollection collection) { }
    }
    public enum CSharpExtractMethodParameterKind
    {
        PassByValue = 0,
        ReturnOnly = 1,
        Return = 2,
        CanReturn = 3,
        PassThrough = 4,
        DoNotPass = 5,
    }
    public class CSharpExtractMethodParameterWithVariable : JetBrains.ReSharper.Refactorings.CSharp.ExtractMethod2.Common.CSharpExtractMethodParameter
    {
        protected CSharpExtractMethodParameterWithVariable(JetBrains.ReSharper.Psi.ITypeOwner typeOwner, bool isFieldLike) { }
        public JetBrains.ReSharper.Psi.ITypeOwner TypeOwner { get; }
        public override void AddCall(JetBrains.ReSharper.Psi.CSharp.CSharpElementFactory factory, JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpExpression call, JetBrains.ReSharper.Psi.CSharp.Tree.IBlock blockForCallSite, JetBrains.ReSharper.Refactorings.CSharp.ExtractMethod2.ControlFlow.ICSharpExtractMethodControlFlowInspectionResult inspectionResult) { }
        public override JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpExpression CreateArgumentValue(JetBrains.ReSharper.Psi.CSharp.CSharpElementFactory factory) { }
        public override JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpStatement CreateReturnValue(JetBrains.ReSharper.Psi.CSharp.CSharpElementFactory factory, JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpStatement originalStatement, JetBrains.ReSharper.Refactorings.CSharp.ExtractMethod2.ControlFlow.ICSharpExtractMethodControlFlowInspectionResult inspector, bool isExitClassA) { }
        public override string Dump() { }
        public override JetBrains.ReSharper.Psi.IType GetParameterType(JetBrains.ReSharper.Psi.Modules.IPsiModule module) { }
        public override bool IsFieldLike() { }
        public void MakeParameterResolving(JetBrains.ReSharper.Refactorings.CSharp.ExtractMethod2.ControlFlow.ReturnedValueGroup valueGroup, JetBrains.ReSharper.Refactorings.CSharp.ExtractMethod2.ControlFlow.ReturnedValueGroup reachingValuesGroup) { }
        public override void SuggestName(JetBrains.ReSharper.Psi.Naming.Extentions.INamesCollection collection) { }
    }
    public abstract class CSharpExtractMethodRunner : JetBrains.ReSharper.Refactorings.Util.NewTypeImages.IResolveImagesLanguageSupport
    {
        protected readonly System.Collections.Generic.Dictionary<JetBrains.ReSharper.Refactorings.CSharp.ExtractMethod2.Common.CSharpExtractMethodParameter, JetBrains.ReSharper.Psi.Tree.IDeclaration> myCreatedDeclarations;
        protected JetBrains.ReSharper.Psi.CSharp.CSharpElementFactory myFactory;
        protected readonly JetBrains.ReSharper.Refactorings.CSharp.ExtractMethod2.ControlFlow.ICSharpExtractMethodControlFlowInspectionResult myInspectionResult;
        protected readonly JetBrains.ReSharper.Refactorings.CSharp.ExtractMethod2.Common.IExtractMethodWorkflow myWorkflow;
        protected CSharpExtractMethodRunner(JetBrains.ReSharper.Refactorings.CSharp.ExtractMethod2.Common.IExtractMethodWorkflow workflow, JetBrains.ReSharper.Refactorings.CSharp.ExtractMethod2.ControlFlow.ICSharpExtractMethodControlFlowInspectionResult inspectionResult) { }
        public bool HasUnsafeCode { get; set; }
        public bool IsAsync { get; set; }
        protected void AddArguments(JetBrains.ReSharper.Psi.CSharp.CSharpElementFactory factory, JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpArgumentsOwner call) { }
        protected JetBrains.ReSharper.Psi.CSharp.Tree.IClassMemberDeclaration CreateDeclarationInternal(JetBrains.ReSharper.Psi.Modules.IPsiModule module, out JetBrains.ReSharper.Psi.CSharp.Tree.IBlock body) { }
        protected JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpExpression CreateMethodCall(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration) { }
        protected void InitRepository() { }
        protected static bool IsAsyncReturnType(JetBrains.ReSharper.Psi.IType type) { }
        public bool IsExternallyVisibleSymbol(JetBrains.ReSharper.Psi.IDeclaredElement element) { }
        public bool IsFromExtendsList(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public bool IsReferenceName(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        protected virtual bool IsTopScope(JetBrains.ReSharper.Psi.CSharp.Tree.IBlock block) { }
        protected System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Refactorings.CSharp.ExtractMethod2.Common.CSharpExtractMethodParameter> ParametersToDeclare() { }
        public void RemoveUnusedUsing(JetBrains.ReSharper.Psi.Tree.IFile file, System.Collections.Generic.JetHashSet<JetBrains.ReSharper.Psi.Tree.ITreeNode> usings) { }
        public void SaveUnusedUsings(JetBrains.ReSharper.Psi.Tree.IFile file, JetBrains.ReSharper.Refactorings.Move.Common.UnusedUsingSaver saver) { }
    }
    public class CSharpExtractMethodTargetSiteContext
    {
        public bool BaseTypeIsSelected { get; }
        public bool IsExtractedFromUnsafeCode { get; set; }
        public JetBrains.ReSharper.Psi.CSharp.Tree.IClassMemberDeclaration AddDeclaration(JetBrains.ReSharper.Psi.CSharp.Tree.IClassMemberDeclaration declaration) { }
        public static JetBrains.ReSharper.Refactorings.CSharp.ExtractMethod2.Common.CSharpExtractMethodTargetSiteContext FindTargetSite([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.CSharp.Tree.IClassMemberDeclaration owner) { }
    }
    public abstract class CSharpExtractMethodWorkflowBase : JetBrains.ReSharper.Refactorings.Workflow.DrivenRefactoringWorkflow, JetBrains.ReSharper.Refactorings.CSharp.ExtractMethod2.Common.IExtractMethodWithModifiersWorkflow, JetBrains.ReSharper.Refactorings.CSharp.ExtractMethod2.Common.IExtractMethodWorkflow
    {
        protected CSharpExtractMethodWorkflowBase(JetBrains.ProjectModel.ISolution solution, string actionId) { }
        public JetBrains.ReSharper.Psi.AccessRights AccessRights { get; set; }
        public override JetBrains.ReSharper.Refactorings.Workflow.RefactoringActionGroup ActionGroup { get; }
        public JetBrains.ReSharper.Refactorings.CSharp.ExtractMethod2.ControlFlow.ICSharpExtractMethodControlFlowInspectionResult AnalysisResult { get; }
        public bool CanExtractChainedConstructor { get; }
        public bool CanExtractProperty { get; }
        public JetBrains.ReSharper.Refactorings.CSharp.ExtractMethod2.Common.CSharpExtractMethodParameter DefaultReturnParameter { get; }
        public bool EnablePrivate { get; }
        public JetBrains.ReSharper.Refactorings.CSharp.ExtractMethod2.Common.CSharpExtractMethodExtractedEntityKind ExtractedEntityKind { get; set; }
        public override JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage FirstPendingRefactoringPage { get; }
        public override string HelpKeyword { get; }
        public bool MakeStatic { get; set; }
        public bool MakeVirtual { get; set; }
        public string MethodName { get; set; }
        public override bool MightModifyManyDocuments { get; }
        public JetBrains.ReSharper.Psi.Naming.Settings.NamingPolicy NamingPolicy { get; }
        public JetBrains.ReSharper.Psi.IPsiSourceFile SourceFile { get; }
        public JetBrains.ReSharper.Refactorings.CSharp.ExtractMethod2.Common.CSharpExtractMethodTargetSiteContext TargetSiteContext { get; set; }
        public override string Title { get; }
        public void AdditionalAnalysisOfReturnValues(JetBrains.ReSharper.Refactorings.CSharp.ExtractMethod2.ControlFlow.ICSharpExtractMethodControlFlowInspectionResult result) { }
        protected abstract JetBrains.ReSharper.Refactorings.CSharp.ExtractMethod2.ControlFlow.ICSharpExtractMethodControlFlowInspectionResult AnalizeDataFlow();
        public static bool CanPassAsParameter(JetBrains.ReSharper.Refactorings.CSharp.ExtractMethod2.ControlFlow.ICSharpExtractMethodControlFlowInspectionResult inspectionResult, JetBrains.ReSharper.Refactorings.CSharp.ExtractMethod2.Common.CSharpExtractMethodParameter parameter) { }
        public abstract JetBrains.ReSharper.Psi.Tree.ITreeNode CreatePreviewElement();
        public string Dump() { }
        protected virtual bool GetCanExtractChainedConstructor() { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Refactorings.CSharp.ExtractMethod2.Common.CSharpExtractMethodParameter> GetPossibleParameters() { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Refactorings.CSharp.ExtractMethod2.Common.CSharpExtractMethodParameter> GetPossibleReturnParameters() { }
        public override bool Initialize(JetBrains.Application.DataContext.IDataContext context) { }
        public static bool IsSelectedWithSemicolon(JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpExpression expression, JetBrains.Util.TextRange randomRange) { }
        public virtual bool IsValid() { }
        public JetBrains.ReSharper.Psi.CSharp.Tree.IBlock PrepareBody(JetBrains.ReSharper.Psi.CSharp.Tree.IBlock body, JetBrains.ReSharper.Psi.CSharp.CSharpElementFactory factory) { }
    }
    public class ExtractMethodChooseMethodKind : System.Windows.Forms.UserControl, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage
    {
        public ExtractMethodChooseMethodKind(JetBrains.ReSharper.Refactorings.CSharp.ExtractMethod2.Common.CSharpExtractMethodWorkflowBase workflow) { }
        public JetBrains.DataFlow.IProperty<bool> ContinueEnabled { get; }
        public string Description { get; }
        public bool DoNotShow { get; }
        public string Title { get; }
        public JetBrains.UI.CrossFramework.EitherControl View { get; }
        public JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage Commit(JetBrains.Application.Progress.IProgressIndicator pi) { }
        protected override void Dispose(bool disposing) { }
        public bool Initialize(JetBrains.Application.Progress.IProgressIndicator pi) { }
        public bool RefreshContents(JetBrains.Application.Progress.IProgressIndicator pi) { }
    }
    public class ExtractMethodOptionsPage : System.Windows.Forms.UserControl, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage
    {
        public ExtractMethodOptionsPage(JetBrains.ReSharper.Refactorings.CSharp.ExtractMethod2.Common.IExtractMethodWorkflow workflow, bool isTestShell = False) { }
        public JetBrains.DataFlow.IProperty<bool> ContinueEnabled { get; }
        public string Description { get; }
        public bool DoNotShow { get; }
        public string Title { get; }
        public JetBrains.UI.CrossFramework.EitherControl View { get; }
        public JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage Commit(JetBrains.Application.Progress.IProgressIndicator pi) { }
        protected override void Dispose(bool disposing) { }
        public bool Initialize(JetBrains.Application.Progress.IProgressIndicator pi) { }
        public bool RefreshContents(JetBrains.Application.Progress.IProgressIndicator pi) { }
    }
    public class static ExtractMethodWorkflowEx
    {
        public static JetBrains.ReSharper.Psi.Resolve.ISubstitution CreateSubstitution(this JetBrains.ReSharper.Refactorings.CSharp.ExtractMethod2.Common.IExtractMethodWorkflow workflow, JetBrains.ReSharper.Psi.IMethod createdMethod) { }
    }
    public interface IExtractMethodWithModifiersWorkflow : JetBrains.ReSharper.Refactorings.CSharp.ExtractMethod2.Common.IExtractMethodWorkflow
    {
        JetBrains.ReSharper.Psi.AccessRights AccessRights { get; set; }
        bool EnablePrivate { get; }
        bool MakeStatic { get; set; }
        bool MakeVirtual { get; set; }
    }
    public interface IExtractMethodWorkflow
    {
        JetBrains.ReSharper.Refactorings.CSharp.ExtractMethod2.ControlFlow.ICSharpExtractMethodControlFlowInspectionResult AnalysisResult { get; }
        JetBrains.ReSharper.Refactorings.CSharp.ExtractMethod2.Common.CSharpExtractMethodExtractedEntityKind ExtractedEntityKind { get; }
        string MethodName { get; set; }
        JetBrains.ReSharper.Psi.Naming.Settings.NamingPolicy NamingPolicy { get; }
        JetBrains.ProjectModel.ISolution Solution { get; }
        JetBrains.ReSharper.Psi.IPsiSourceFile SourceFile { get; }
        void AdditionalAnalysisOfReturnValues(JetBrains.ReSharper.Refactorings.CSharp.ExtractMethod2.ControlFlow.ICSharpExtractMethodControlFlowInspectionResult result);
        JetBrains.ReSharper.Psi.Tree.ITreeNode CreatePreviewElement();
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Refactorings.CSharp.ExtractMethod2.Common.CSharpExtractMethodParameter> GetPossibleParameters();
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Refactorings.CSharp.ExtractMethod2.Common.CSharpExtractMethodParameter> GetPossibleReturnParameters();
        bool IsValid();
        JetBrains.ReSharper.Psi.CSharp.Tree.IBlock PrepareBody(JetBrains.ReSharper.Psi.CSharp.Tree.IBlock body, JetBrains.ReSharper.Psi.CSharp.CSharpElementFactory factory);
    }
}
namespace JetBrains.ReSharper.Refactorings.CSharp.ExtractMethod2.ControlFlow
{
    
    public class CSharpExtractMethodControlFlowInspectionResultWithoutGraph : JetBrains.ReSharper.Refactorings.CSharp.ExtractMethod2.ControlFlow.ICSharpExtractMethodControlFlowInspectionResult
    {
        public CSharpExtractMethodControlFlowInspectionResultWithoutGraph(JetBrains.ReSharper.Psi.ITreeRange treeRange, bool isExpression) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Refactorings.CSharp.ExtractMethod2.Common.CSharpExtractMethodParameter> AllParameters { get; }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Psi.CSharp.Tree.IAwaitExpression> AwaitExpressions { get; }
        public bool CanBeInstance { get; }
        public bool CanBeStatic { get; }
        public bool CanHaveRefOutParameters { get; }
        public System.Collections.Generic.HashSet<JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpStatement> ExitsClassA { get; }
        public System.Collections.Generic.HashSet<JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpStatement> ExitsClassB { get; }
        public System.Collections.Generic.List<JetBrains.ReSharper.Refactorings.CSharp.ExtractMethod2.Common.CSharpExtractMethodParameter> ExtraReturnParameters { get; }
        public bool HasFallthroughExit { get; }
        public bool HasMultipleEntries { get; }
        public bool HasMultipleExitsProblem { get; }
        public bool HasRefOutParametersProblem { get; }
        public JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpTypeMemberDeclaration OwnerTypeMember { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IField> ReadonlyFields { get; }
        public JetBrains.ReSharper.Refactorings.CSharp.ExtractMethod2.Common.CSharpExtractMethodParameter ReturnValueParameter { get; set; }
        public System.Collections.Generic.HashSet<JetBrains.ReSharper.Psi.ITypeParameter> UsedTypeParameters { get; }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Psi.CSharp.Tree.IYieldStatement> YieldStatements { get; }
        public string Dump() { }
        public bool IsValid() { }
    }
    public class CSharpExtractMethodControlFlowInspector : JetBrains.ReSharper.Psi.ControlFlow.Impl.ControlFlowGrafInspector<JetBrains.ReSharper.Refactorings.CSharp.ExtractMethod2.ControlFlow.CSharpExtractMethodInspectionContext>, JetBrains.ReSharper.Refactorings.CSharp.ExtractMethod2.ControlFlow.ICSharpExtractMethodControlFlowInspectionResult
    {
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Refactorings.CSharp.ExtractMethod2.Common.CSharpExtractMethodParameter> AllParameters { get; }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Psi.CSharp.Tree.IAwaitExpression> AwaitExpressions { get; }
        public bool CanBeInstance { get; }
        public bool CanBeStatic { get; }
        public bool CanHaveRefOutParameters { get; }
        public System.Collections.Generic.HashSet<JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpStatement> ExitsClassA { get; }
        public System.Collections.Generic.HashSet<JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpStatement> ExitsClassB { get; }
        public int ExitsCount { get; }
        public System.Collections.Generic.List<JetBrains.ReSharper.Refactorings.CSharp.ExtractMethod2.Common.CSharpExtractMethodParameter> ExtraReturnParameters { get; }
        public bool HasFallthroughExit { get; }
        public bool HasMultipleEntries { get; }
        public bool HasMultipleExitsProblem { get; }
        public bool HasRefOutParametersProblem { get; }
        public JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpTypeMemberDeclaration OwnerTypeMember { get; }
        public System.Collections.Generic.Dictionary<JetBrains.ReSharper.Psi.ITypeOwner, JetBrains.ReSharper.Refactorings.CSharp.ExtractMethod2.Common.CSharpExtractMethodParameter> ParametersFromVariables { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IField> ReadonlyFields { get; }
        public JetBrains.ReSharper.Refactorings.CSharp.ExtractMethod2.Common.CSharpExtractMethodParameter ReturnValueParameter { get; set; }
        public System.Collections.Generic.HashSet<JetBrains.ReSharper.Psi.ITypeParameter> UsedTypeParameters { get; }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Psi.CSharp.Tree.IYieldStatement> YieldStatements { get; }
        public static JetBrains.ReSharper.Refactorings.CSharp.ExtractMethod2.ControlFlow.ICSharpExtractMethodControlFlowInspectionResult Analyse(JetBrains.ReSharper.Psi.ITreeRange treeRange, bool isExpression, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.CSharp.ExtractMethod2.Common.IExtractMethodWorkflow workflow) { }
        public string Dump() { }
        protected override void InspectLeafElementAndSetContextToExits(JetBrains.ReSharper.Psi.ControlFlow.IControlFlowElement element, JetBrains.ReSharper.Refactorings.CSharp.ExtractMethod2.ControlFlow.CSharpExtractMethodInspectionContext context) { }
        public bool IsValid() { }
    }
    public class CSharpExtractMethodInspectionContext
    {
        public CSharpExtractMethodInspectionContext() { }
        public CSharpExtractMethodInspectionContext(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Refactorings.CSharp.ExtractMethod2.ControlFlow.CSharpExtractMethodInspectionContext> contexts) { }
        public System.Collections.Generic.HashSet<JetBrains.ReSharper.Psi.IDeclaredElement> DefautlIsOverridden { get; }
        public System.Collections.Generic.HashSet<JetBrains.ReSharper.Psi.IDeclaredElement> DefautlIsOverriddenInside { get; }
        public JetBrains.Util.OneToSetMap<JetBrains.ReSharper.Psi.IDeclaredElement, JetBrains.ReSharper.Psi.Tree.ITreeNode> ReachingWiteUsages { get; }
        public System.Collections.Generic.HashSet<JetBrains.ReSharper.Psi.CSharp.Tree.IYieldStatement> YieldStatements { get; }
        public JetBrains.ReSharper.Refactorings.CSharp.ExtractMethod2.ControlFlow.CSharpExtractMethodInspectionContext Clone() { }
        public bool Equals(JetBrains.ReSharper.Refactorings.CSharp.ExtractMethod2.ControlFlow.CSharpExtractMethodInspectionContext other) { }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
        public JetBrains.ReSharper.Refactorings.CSharp.ExtractMethod2.ControlFlow.CSharpExtractMethodInspectionContext RemoveYield(JetBrains.ReSharper.Psi.CSharp.Tree.IYieldStatement yieldStatement) { }
        public JetBrains.ReSharper.Refactorings.CSharp.ExtractMethod2.ControlFlow.CSharpExtractMethodInspectionContext Write(JetBrains.ReSharper.Psi.ITypeOwner typeOwner, JetBrains.ReSharper.Psi.Tree.ITreeNode treeNode, bool writeOnly) { }
        public JetBrains.ReSharper.Refactorings.CSharp.ExtractMethod2.ControlFlow.CSharpExtractMethodInspectionContext Yield(JetBrains.ReSharper.Psi.CSharp.Tree.IYieldStatement yieldStatement) { }
    }
    public class CSharpExtractMethodInspectionContextFactory : JetBrains.ReSharper.Psi.ControlFlow.IControlFlowContextFactory<JetBrains.ReSharper.Refactorings.CSharp.ExtractMethod2.ControlFlow.CSharpExtractMethodInspectionContext>
    {
        public JetBrains.ReSharper.Refactorings.CSharp.ExtractMethod2.ControlFlow.CSharpExtractMethodInspectionContext InitialContext { get; }
        public JetBrains.ReSharper.Refactorings.CSharp.ExtractMethod2.ControlFlow.CSharpExtractMethodInspectionContext CloneContext(JetBrains.ReSharper.Refactorings.CSharp.ExtractMethod2.ControlFlow.CSharpExtractMethodInspectionContext context) { }
        public JetBrains.ReSharper.Refactorings.CSharp.ExtractMethod2.ControlFlow.CSharpExtractMethodInspectionContext Merge(System.Collections.Generic.IList<JetBrains.ReSharper.Refactorings.CSharp.ExtractMethod2.ControlFlow.CSharpExtractMethodInspectionContext> contexts) { }
    }
    public interface ICSharpExtractMethodControlFlowInspectionResult
    {
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Refactorings.CSharp.ExtractMethod2.Common.CSharpExtractMethodParameter> AllParameters { get; }
        System.Collections.Generic.IList<JetBrains.ReSharper.Psi.CSharp.Tree.IAwaitExpression> AwaitExpressions { get; }
        bool CanBeInstance { get; }
        bool CanBeStatic { get; }
        bool CanHaveRefOutParameters { get; }
        System.Collections.Generic.HashSet<JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpStatement> ExitsClassA { get; }
        System.Collections.Generic.HashSet<JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpStatement> ExitsClassB { get; }
        System.Collections.Generic.List<JetBrains.ReSharper.Refactorings.CSharp.ExtractMethod2.Common.CSharpExtractMethodParameter> ExtraReturnParameters { get; }
        bool HasFallthroughExit { get; }
        bool HasMultipleEntries { get; }
        bool HasMultipleExitsProblem { get; }
        bool HasRefOutParametersProblem { get; }
        JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpTypeMemberDeclaration OwnerTypeMember { get; }
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IField> ReadonlyFields { get; }
        JetBrains.ReSharper.Refactorings.CSharp.ExtractMethod2.Common.CSharpExtractMethodParameter ReturnValueParameter { get; set; }
        System.Collections.Generic.HashSet<JetBrains.ReSharper.Psi.ITypeParameter> UsedTypeParameters { get; }
        System.Collections.Generic.IList<JetBrains.ReSharper.Psi.CSharp.Tree.IYieldStatement> YieldStatements { get; }
        string Dump();
        bool IsValid();
    }
    public enum ReturnedValueGroup
    {
        NoGroup = 0,
        True = 1,
        False = 2,
        NotNull = 3,
    }
}
namespace JetBrains.ReSharper.Refactorings.CSharp.ExtractMethod2.FromExpression
{
    
    public class CSharpExtractMethodFromExpressionWorkflow : JetBrains.ReSharper.Refactorings.CSharp.ExtractMethod2.Common.CSharpExtractMethodWorkflowBase
    {
        public CSharpExtractMethodFromExpressionWorkflow(JetBrains.ProjectModel.ISolution solution, string actionId) { }
        public JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpExpression Expression { get; }
        protected override JetBrains.ReSharper.Refactorings.CSharp.ExtractMethod2.ControlFlow.ICSharpExtractMethodControlFlowInspectionResult AnalizeDataFlow() { }
        public override JetBrains.ReSharper.Psi.Tree.ITreeNode CreatePreviewElement() { }
        public override JetBrains.ReSharper.Refactorings.Workflow.IRefactoringExecuter CreateRefactoring(JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public override bool IsAvailable(JetBrains.Application.DataContext.IDataContext context) { }
        public override bool IsValid() { }
    }
    public class CSharpExtractMethodRunnerFromExpression : JetBrains.ReSharper.Refactorings.CSharp.ExtractMethod2.Common.CSharpExtractMethodRunner
    {
        public CSharpExtractMethodRunnerFromExpression(JetBrains.ReSharper.Refactorings.CSharp.ExtractMethod2.Common.CSharpExtractMethodWorkflowBase workflow, JetBrains.ReSharper.Refactorings.CSharp.ExtractMethod2.ControlFlow.ICSharpExtractMethodControlFlowInspectionResult inspectionResult, JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpExpression expression) { }
        public JetBrains.ReSharper.Psi.CSharp.Tree.IClassMemberDeclaration CreateDeclaration() { }
        public void ReplaceExpression(JetBrains.ReSharper.Psi.CSharp.Tree.IClassMemberDeclaration newDeclaration) { }
    }
}
namespace JetBrains.ReSharper.Refactorings.CSharp.ExtractMethod2.FromStatements
{
    
    public class CSharpExtractMethodFromStatementsWorkflow : JetBrains.ReSharper.Refactorings.CSharp.ExtractMethod2.Common.CSharpExtractMethodWorkflowBase
    {
        public CSharpExtractMethodFromStatementsWorkflow(JetBrains.ProjectModel.ISolution solution, string actionId) { }
        public JetBrains.ReSharper.Psi.CSharp.ICSharpStatementsRange StatementsRange { get; }
        protected override JetBrains.ReSharper.Refactorings.CSharp.ExtractMethod2.ControlFlow.ICSharpExtractMethodControlFlowInspectionResult AnalizeDataFlow() { }
        public override JetBrains.ReSharper.Psi.Tree.ITreeNode CreatePreviewElement() { }
        public override JetBrains.ReSharper.Refactorings.Workflow.IRefactoringExecuter CreateRefactoring(JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        protected override bool GetCanExtractChainedConstructor() { }
        public override bool IsAvailable(JetBrains.Application.DataContext.IDataContext context) { }
        public override bool IsValid() { }
    }
    public class CSharpExtractMethodRunnerFromStatements : JetBrains.ReSharper.Refactorings.CSharp.ExtractMethod2.Common.CSharpExtractMethodRunner
    {
        public CSharpExtractMethodRunnerFromStatements(JetBrains.ReSharper.Refactorings.CSharp.ExtractMethod2.Common.IExtractMethodWorkflow workflow, JetBrains.ReSharper.Refactorings.CSharp.ExtractMethod2.ControlFlow.ICSharpExtractMethodControlFlowInspectionResult inspectionResult, JetBrains.ReSharper.Psi.CSharp.ICSharpStatementsRange statements) { }
        public JetBrains.ReSharper.Psi.Tree.IDeclaration CreateDeclaration() { }
        protected override bool IsTopScope(JetBrains.ReSharper.Psi.CSharp.Tree.IBlock block) { }
        public void UpdateCallSite(JetBrains.ReSharper.Psi.CSharp.CSharpElementFactory factory, JetBrains.ReSharper.Psi.CSharp.Tree.IClassMemberDeclaration newDeclaration) { }
    }
}
namespace JetBrains.ReSharper.Refactorings.CSharp.ExtractMethod2.Parameters
{
    
    public class CSharpExtractMethodParameterFromLambdaParameter : JetBrains.ReSharper.Refactorings.CSharp.ExtractMethod2.Common.CSharpExtractMethodParameterWithVariable
    {
        public CSharpExtractMethodParameterFromLambdaParameter(JetBrains.ReSharper.Psi.CSharp.DeclaredElements.ILambdaParameter parameter, bool isFieldLike) { }
        public override string ToString() { }
    }
    public class CSharpExtractMethodParameterFromLocalVariable : JetBrains.ReSharper.Refactorings.CSharp.ExtractMethod2.Common.CSharpExtractMethodParameterWithVariable
    {
        public CSharpExtractMethodParameterFromLocalVariable(JetBrains.ReSharper.Psi.ILocalVariable localVariable, bool isFieldLike) { }
        public override string ToString() { }
    }
    public class CSharpExtractMethodParameterFromOwnerParameter : JetBrains.ReSharper.Refactorings.CSharp.ExtractMethod2.Common.CSharpExtractMethodParameterWithVariable
    {
        public CSharpExtractMethodParameterFromOwnerParameter(JetBrains.ReSharper.Psi.IParameter localVariable, bool isFieldLike) { }
        public override string ToString() { }
    }
    public class CSharpExtractMethodParameterFromQueryDeclaredElement : JetBrains.ReSharper.Refactorings.CSharp.ExtractMethod2.Common.CSharpExtractMethodParameterWithVariable
    {
        public CSharpExtractMethodParameterFromQueryDeclaredElement(JetBrains.ReSharper.Psi.CSharp.Tree.Query.IQueryDeclaredElement localVariable, bool isFieldLike) { }
        public override string ToString() { }
    }
    public class CSharpExtractMethodParameterInstantBool : JetBrains.ReSharper.Refactorings.CSharp.ExtractMethod2.Common.CSharpExtractMethodParameter
    {
        public CSharpExtractMethodParameterInstantBool(JetBrains.ReSharper.Refactorings.CSharp.ExtractMethod2.Common.CSharpExtractMethodParameter extraReturnParameter) { }
        public override void AddCall(JetBrains.ReSharper.Psi.CSharp.CSharpElementFactory factory, JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpExpression call, JetBrains.ReSharper.Psi.CSharp.Tree.IBlock blockForCallSite, JetBrains.ReSharper.Refactorings.CSharp.ExtractMethod2.ControlFlow.ICSharpExtractMethodControlFlowInspectionResult inspectionResult) { }
        public override JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpStatement CreateReturnValue(JetBrains.ReSharper.Psi.CSharp.CSharpElementFactory factory, JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpStatement originalStatement, JetBrains.ReSharper.Refactorings.CSharp.ExtractMethod2.ControlFlow.ICSharpExtractMethodControlFlowInspectionResult inspector, bool isExitClassA) { }
        public override string Dump() { }
        public override JetBrains.ReSharper.Psi.IType GetParameterType(JetBrains.ReSharper.Psi.Modules.IPsiModule module) { }
        public override void SuggestName(JetBrains.ReSharper.Psi.Naming.Extentions.INamesCollection collection) { }
        public override string ToString() { }
    }
    public class CSharpExtractMethodParameterReturnExpression : JetBrains.ReSharper.Refactorings.CSharp.ExtractMethod2.Common.CSharpExtractMethodParameter
    {
        public CSharpExtractMethodParameterReturnExpression(JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpExpression expression) { }
        public JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpExpression Expression { get; }
        public override void AddCall(JetBrains.ReSharper.Psi.CSharp.CSharpElementFactory factory, JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpExpression call, JetBrains.ReSharper.Psi.CSharp.Tree.IBlock blockForCallSite, JetBrains.ReSharper.Refactorings.CSharp.ExtractMethod2.ControlFlow.ICSharpExtractMethodControlFlowInspectionResult inspectionResult) { }
        public override JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpStatement CreateReturnValue(JetBrains.ReSharper.Psi.CSharp.CSharpElementFactory factory, JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpStatement originalStatement, JetBrains.ReSharper.Refactorings.CSharp.ExtractMethod2.ControlFlow.ICSharpExtractMethodControlFlowInspectionResult inspector, bool isExitClassA) { }
        public override string Dump() { }
        public override JetBrains.ReSharper.Psi.IType GetParameterType(JetBrains.ReSharper.Psi.Modules.IPsiModule module) { }
        public override void SuggestName(JetBrains.ReSharper.Psi.Naming.Extentions.INamesCollection collection) { }
        public override string ToString() { }
    }
    public class CSharpExtractMethodParameterReturnValue : JetBrains.ReSharper.Refactorings.CSharp.ExtractMethod2.Common.CSharpExtractMethodParameter
    {
        public CSharpExtractMethodParameterReturnValue(JetBrains.ReSharper.Psi.IType type, System.Collections.Generic.List<JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpExpression> expressionsForNaming, JetBrains.ReSharper.Refactorings.CSharp.ExtractMethod2.Common.CSharpExtractMethodParameterKind kind) { }
        public override bool IsForReturnValue { get; }
        public override void AddCall(JetBrains.ReSharper.Psi.CSharp.CSharpElementFactory factory, JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpExpression call, JetBrains.ReSharper.Psi.CSharp.Tree.IBlock blockForCallSite, JetBrains.ReSharper.Refactorings.CSharp.ExtractMethod2.ControlFlow.ICSharpExtractMethodControlFlowInspectionResult inspectionResult) { }
        public override JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpStatement CreateAssignmentToReturnValue(JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpStatement statement) { }
        public override JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpStatement CreateReturnValue(JetBrains.ReSharper.Psi.CSharp.CSharpElementFactory factory, JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpStatement originalStatement, JetBrains.ReSharper.Refactorings.CSharp.ExtractMethod2.ControlFlow.ICSharpExtractMethodControlFlowInspectionResult inspector, bool isExitClassA) { }
        public override string Dump() { }
        public override JetBrains.ReSharper.Psi.IType GetParameterType(JetBrains.ReSharper.Psi.Modules.IPsiModule module) { }
        public override void SuggestName(JetBrains.ReSharper.Psi.Naming.Extentions.INamesCollection collection) { }
        public override string ToString() { }
    }
    public class CSharpExtractMethodParameterReturnValueConditional : JetBrains.ReSharper.Refactorings.CSharp.ExtractMethod2.Common.CSharpExtractMethodParameter
    {
        public CSharpExtractMethodParameterReturnValueConditional(JetBrains.ReSharper.Refactorings.CSharp.ExtractMethod2.ControlFlow.ReturnedValueGroup returnValueGroup, JetBrains.ReSharper.Psi.IType type, System.Collections.Generic.List<JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpExpression> expressionsForNaming, JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpStatement fallThroughExit) { }
        public override bool IsForReturnValue { get; }
        public override void AddCall(JetBrains.ReSharper.Psi.CSharp.CSharpElementFactory factory, JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpExpression call, JetBrains.ReSharper.Psi.CSharp.Tree.IBlock blockForCallSite, JetBrains.ReSharper.Refactorings.CSharp.ExtractMethod2.ControlFlow.ICSharpExtractMethodControlFlowInspectionResult inspectionResult) { }
        public override JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpStatement CreateReturnValue(JetBrains.ReSharper.Psi.CSharp.CSharpElementFactory factory, JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpStatement originalStatement, JetBrains.ReSharper.Refactorings.CSharp.ExtractMethod2.ControlFlow.ICSharpExtractMethodControlFlowInspectionResult inspector, bool isExitClassA) { }
        public override string Dump() { }
        public override JetBrains.ReSharper.Psi.IType GetParameterType(JetBrains.ReSharper.Psi.Modules.IPsiModule module) { }
        public override void SuggestName(JetBrains.ReSharper.Psi.Naming.Extentions.INamesCollection collection) { }
        public override string ToString() { }
    }
    public class CSharpExtractMethodParameterTrueWhenReturns : JetBrains.ReSharper.Refactorings.CSharp.ExtractMethod2.Common.CSharpExtractMethodParameter
    {
        public CSharpExtractMethodParameterTrueWhenReturns(JetBrains.ReSharper.Refactorings.CSharp.ExtractMethod2.Common.CSharpExtractMethodParameter simpleReturn) { }
        public override void AddCall(JetBrains.ReSharper.Psi.CSharp.CSharpElementFactory factory, JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpExpression call, JetBrains.ReSharper.Psi.CSharp.Tree.IBlock blockForCallSite, JetBrains.ReSharper.Refactorings.CSharp.ExtractMethod2.ControlFlow.ICSharpExtractMethodControlFlowInspectionResult inspectionResult) { }
        public override JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpExpression CreateArgumentValue(JetBrains.ReSharper.Psi.CSharp.CSharpElementFactory factory) { }
        public override JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpStatement CreateReturnValue(JetBrains.ReSharper.Psi.CSharp.CSharpElementFactory factory, JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpStatement originalStatement, JetBrains.ReSharper.Refactorings.CSharp.ExtractMethod2.ControlFlow.ICSharpExtractMethodControlFlowInspectionResult inspector, bool isExitClassA) { }
        public override string Dump() { }
        public override JetBrains.ReSharper.Psi.IType GetParameterType(JetBrains.ReSharper.Psi.Modules.IPsiModule module) { }
        public override void SuggestName(JetBrains.ReSharper.Psi.Naming.Extentions.INamesCollection collection) { }
        public override string ToString() { }
    }
    public class CSharpExtractMethodParameterVoidReturn : JetBrains.ReSharper.Refactorings.CSharp.ExtractMethod2.Common.CSharpExtractMethodParameter
    {
        public CSharpExtractMethodParameterVoidReturn(JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpTypeMemberDeclaration ownerTypeMember) { }
        public override void AddCall(JetBrains.ReSharper.Psi.CSharp.CSharpElementFactory factory, JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpExpression call, JetBrains.ReSharper.Psi.CSharp.Tree.IBlock blockForCallSite, JetBrains.ReSharper.Refactorings.CSharp.ExtractMethod2.ControlFlow.ICSharpExtractMethodControlFlowInspectionResult inspectionResult) { }
        public override JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpStatement CreateReturnValue(JetBrains.ReSharper.Psi.CSharp.CSharpElementFactory factory, JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpStatement originalStatement, JetBrains.ReSharper.Refactorings.CSharp.ExtractMethod2.ControlFlow.ICSharpExtractMethodControlFlowInspectionResult inspector, bool isExitClassA) { }
        public override string Dump() { }
        public override JetBrains.ReSharper.Psi.IType GetParameterType(JetBrains.ReSharper.Psi.Modules.IPsiModule module) { }
        public override void SuggestName(JetBrains.ReSharper.Psi.Naming.Extentions.INamesCollection collection) { }
        public override string ToString() { }
    }
    public class CSharpExtractMethodParameterYieldOneValueWithReturn : JetBrains.ReSharper.Refactorings.CSharp.ExtractMethod2.Common.CSharpExtractMethodParameter
    {
        public CSharpExtractMethodParameterYieldOneValueWithReturn(JetBrains.ReSharper.Psi.IType type, System.Collections.Generic.List<JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpExpression> expressionsForNaming) { }
        public override void AddCall(JetBrains.ReSharper.Psi.CSharp.CSharpElementFactory factory, JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpExpression call, JetBrains.ReSharper.Psi.CSharp.Tree.IBlock blockForCallSite, JetBrains.ReSharper.Refactorings.CSharp.ExtractMethod2.ControlFlow.ICSharpExtractMethodControlFlowInspectionResult inspectionResult) { }
        public override bool CanUseWithReturnValue(JetBrains.ReSharper.Refactorings.CSharp.ExtractMethod2.Common.CSharpExtractMethodParameter returnValueParameter) { }
        public override JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpExpression CreateArgumentValue(JetBrains.ReSharper.Psi.CSharp.CSharpElementFactory factory) { }
        public override JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpStatement CreateReturnValue(JetBrains.ReSharper.Psi.CSharp.CSharpElementFactory factory, JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpStatement originalStatement, JetBrains.ReSharper.Refactorings.CSharp.ExtractMethod2.ControlFlow.ICSharpExtractMethodControlFlowInspectionResult inspector, bool isExitClassA) { }
        public override string Dump() { }
        public override JetBrains.ReSharper.Psi.IType GetParameterType(JetBrains.ReSharper.Psi.Modules.IPsiModule module) { }
        public override void SuggestName(JetBrains.ReSharper.Psi.Naming.Extentions.INamesCollection collection) { }
        public override string ToString() { }
    }
    public class CSharpExtractMethodParameterYieldReturnValue : JetBrains.ReSharper.Refactorings.CSharp.ExtractMethod2.Common.CSharpExtractMethodParameter
    {
        public CSharpExtractMethodParameterYieldReturnValue(JetBrains.ReSharper.Psi.IType type) { }
        public override void AddCall(JetBrains.ReSharper.Psi.CSharp.CSharpElementFactory factory, JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpExpression call, JetBrains.ReSharper.Psi.CSharp.Tree.IBlock blockForCallSite, JetBrains.ReSharper.Refactorings.CSharp.ExtractMethod2.ControlFlow.ICSharpExtractMethodControlFlowInspectionResult inspectionResult) { }
        public override JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpStatement CreateReturnValue(JetBrains.ReSharper.Psi.CSharp.CSharpElementFactory factory, JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpStatement originalStatement, JetBrains.ReSharper.Refactorings.CSharp.ExtractMethod2.ControlFlow.ICSharpExtractMethodControlFlowInspectionResult inspector, bool isExitClassA) { }
        public override string Dump() { }
        public override JetBrains.ReSharper.Psi.IType GetParameterType(JetBrains.ReSharper.Psi.Modules.IPsiModule module) { }
        public override void SuggestName(JetBrains.ReSharper.Psi.Naming.Extentions.INamesCollection collection) { }
        public override string ToString() { }
    }
}
namespace JetBrains.ReSharper.Refactorings.CSharp.Function2Indexer
{
    
    public class CsFunction2Indexer : JetBrains.ReSharper.Refactorings.CSharp.Function2Property.CsFunction2Property
    {
        public CsFunction2Indexer(JetBrains.ReSharper.Refactorings.Function2Property.Function2PropertyWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        protected override void CheckConflictWithClassName(JetBrains.ReSharper.Psi.ITypeElement element) { }
        public override void CheckConflictWithProperty(JetBrains.ReSharper.Psi.IProperty property, JetBrains.ReSharper.Psi.IDeclaredElement existingDeclaration, bool isBase, bool isInheritor) { }
        protected override JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpExpression CreateExpressionForSetter(JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpExpression qualifier, JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpExpression expression, JetBrains.ReSharper.Psi.CSharp.Tree.IInvocationExpression invocationExpression) { }
        protected override JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpExpression CreateGetterExpression(JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpExpression qualifierExpression, JetBrains.ReSharper.Psi.CSharp.Tree.IInvocationExpression invocationExpression) { }
        protected override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.ITypeMember> GetMembers(JetBrains.ReSharper.Psi.ITypeElement containingType, JetBrains.ReSharper.Psi.IMethod method) { }
        public override bool InitialValidate() { }
        public override void PropcessMethod(JetBrains.ReSharper.Psi.IDeclaredElement element) { }
        protected override void RenameParameter(JetBrains.ReSharper.Psi.IMethod method, JetBrains.ReSharper.Psi.IProperty existingProperty) { }
        protected override JetBrains.ReSharper.Refactorings.Function2Property.PropertySearchResultBase TestPropertyParameters(JetBrains.ReSharper.Psi.IProperty property) { }
    }
}
namespace JetBrains.ReSharper.Refactorings.CSharp.Function2Property
{
    
    public class CsFunction2Property : JetBrains.ReSharper.Refactorings.Function2Property.Function2PropertyBase
    {
        public CsFunction2Property(JetBrains.ReSharper.Refactorings.Function2Property.Function2PropertyWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        protected override bool AreEquals(string name1, string name2) { }
        protected override void CheckConflictWithClassName(JetBrains.ReSharper.Psi.ITypeElement element) { }
        public override void CheckConflictWithMethod(JetBrains.ReSharper.Psi.IMethod method, JetBrains.ReSharper.Psi.IDeclaredElement existingDeclaration, bool isBase, bool isInheritor) { }
        public override void CheckConflictWithProperty(JetBrains.ReSharper.Psi.IProperty property, JetBrains.ReSharper.Psi.IDeclaredElement existingDeclaration, bool isBase, bool isInheritor) { }
        protected override bool CheckExplicitImplementationList(JetBrains.ReSharper.Psi.IOverridableMember accessor, JetBrains.ReSharper.Psi.IMethod method) { }
        protected void CheckGenericParameters() { }
        protected JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpExpression CreateArrayExpressionForParams([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.CSharp.Tree.IInvocationExpression invocationExpression, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IMethod method) { }
        protected virtual JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpExpression CreateExpressionForSetter(JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpExpression qualifier, JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpExpression expression, JetBrains.ReSharper.Psi.CSharp.Tree.IInvocationExpression invocationExpression) { }
        protected virtual JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpExpression CreateGetterExpression(JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpExpression qualifierExpression, JetBrains.ReSharper.Psi.CSharp.Tree.IInvocationExpression invocationExpression) { }
        public override void ExecuteReferencesRefactoring(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public override bool InitialValidate() { }
        public override void PropcessMethod([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.IDeclaredElement element) { }
        protected override JetBrains.ReSharper.Refactorings.Function2Property.PropertySearchResultBase TestPropertyParameters(JetBrains.ReSharper.Psi.IProperty property) { }
        protected class OutRefParameterConflict : JetBrains.ReSharper.Refactorings.Conflicts.IConflict, System.IEquatable<JetBrains.ReSharper.Refactorings.CSharp.Function2Property.CsFunction2Property.OutRefParameterConflict>
        {
            public string Description { get; }
            public bool IsValid { get; }
            public JetBrains.ReSharper.Refactorings.Conflicts.ConflictSeverity Severity { get; }
            public bool Equals(JetBrains.ReSharper.Refactorings.CSharp.Function2Property.CsFunction2Property.OutRefParameterConflict outRefParameterConflict) { }
            public override bool Equals(object obj) { }
            public override int GetHashCode() { }
        }
    }
}
namespace JetBrains.ReSharper.Refactorings.CSharp.Helpers
{
    
    public class CSharpNamespaceRedundancyFileFixer : JetBrains.ReSharper.Refactorings.Helpers.INamespaceRedundancyProblemFixer
    {
        public CSharpNamespaceRedundancyFileFixer(JetBrains.ReSharper.Psi.INamespace @namespace, JetBrains.ReSharper.Psi.Tree.IFile file) { }
        public bool IsEmpty { get; }
        public JetBrains.ProjectModel.IProjectFile ProjectFile { get; }
        public void FixUsages() { }
    }
}
namespace JetBrains.ReSharper.Refactorings.CSharp.Indexer2Function
{
    
    public class CsIndexer2Function : JetBrains.ReSharper.Refactorings.Indexer2Function.Indexer2FunctionBase
    {
        public CsIndexer2Function(JetBrains.ReSharper.Refactorings.Property2Function.Property2FunctionWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        protected override bool AreEquals(string name1, string name2) { }
        protected override void CheckConflictWithClassName(JetBrains.ReSharper.Psi.ITypeElement element) { }
        public override void ExecuteDeclarationRefactoring(JetBrains.ReSharper.Psi.IDeclaredElement propertyOrMethod, JetBrains.Application.Progress.IProgressIndicator pi) { }
        protected override bool SkipIndexerReference(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public override bool TryNewTypeDeclaration(JetBrains.ReSharper.Refactorings.Indexer2Function.IndexersSearchData data, JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
    }
}
namespace JetBrains.ReSharper.Refactorings.CSharp.Inline.ArgUtil
{
    
    public class static CSharpArgumentsUtil
    {
        public static JetBrains.ReSharper.Refactorings.Inline.ArgUtil.ArgumentFromParameter GetArgumentFromParameter(JetBrains.ReSharper.Psi.IParameter parameter, JetBrains.ReSharper.Psi.IParametersOwner parametersOwner, JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpArgumentsOwner argumentsOwner) { }
    }
}
namespace JetBrains.ReSharper.Refactorings.CSharp.Inline
{
    
    public class CSharpInlinedCodeTransformer : JetBrains.ReSharper.Refactorings.Inline.InlinedCodeTransformerBase<JetBrains.ReSharper.Psi.CSharp.Tree.IReferenceExpression, JetBrains.ReSharper.Psi.CSharp.Tree.IReturnStatement>
    {
        public CSharpInlinedCodeTransformer(JetBrains.ReSharper.Psi.Tree.ITreeNode expression, JetBrains.ReSharper.Refactorings.Inline.InlinedCallInfo inlinedCallInfo, JetBrains.ReSharper.Refactorings.Inline.CallSiteContext context) { }
        protected override JetBrains.ReSharper.Psi.Tree.ITreeNode AddActionRemoveReturn(JetBrains.ReSharper.Psi.CSharp.Tree.IReturnStatement returnStatement) { }
        protected override JetBrains.ReSharper.Psi.Tree.ITreeNode AddActionReplaceExpressionWithAssignedExpression(JetBrains.ReSharper.Psi.CSharp.Tree.IReferenceExpression expression) { }
        protected override JetBrains.ReSharper.Psi.Tree.ITreeNode AddActionReplaceExpressionWithTemp(JetBrains.ReSharper.Psi.Tree.IExpression expression, string newTempName) { }
        protected override JetBrains.ReSharper.Psi.Tree.ITreeNode AddActionReplaceParameterWithArgumentExpression(JetBrains.ReSharper.Psi.CSharp.Tree.IReferenceExpression expression, JetBrains.ReSharper.Psi.IParameter parameter, JetBrains.ReSharper.Refactorings.Inline.InlinedArgumentInfo info) { }
        protected override JetBrains.ReSharper.Psi.Tree.ITreeNode AddActionReplaceReturnWithAssignmentToTemp(JetBrains.ReSharper.Psi.CSharp.Tree.IReturnStatement returnStatement) { }
        protected override JetBrains.ReSharper.Psi.Tree.ITreeNode AddActionReplaceWithDefaultParamValue(JetBrains.ReSharper.Psi.CSharp.Tree.IReferenceExpression expression, JetBrains.ReSharper.Psi.IParameter parameter) { }
        protected override JetBrains.ReSharper.Psi.Tree.ITreeNode AddActionSetQualifier(JetBrains.ReSharper.Psi.CSharp.Tree.IReferenceExpression expression) { }
        protected override JetBrains.ReSharper.Psi.Tree.ITreeNode ChangeName(JetBrains.ReSharper.Psi.Tree.ITreeNode element, string name) { }
        public static JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpExpression EnCastExpression(JetBrains.ReSharper.Psi.IType castType, JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpExpression expression, JetBrains.ReSharper.Refactorings.Inline.CallSiteContext context, JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpTreeNode typeUsageContext) { }
        public static JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpExpression EnCastExpressionToArray(System.Collections.Generic.List<JetBrains.ReSharper.Psi.Tree.IArgument> args, JetBrains.ReSharper.Refactorings.Inline.CallSiteContext context, JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpTreeNode typeUsageContext) { }
        protected override bool IsSetterParameter(JetBrains.ReSharper.Psi.IParameter parameter) { }
        protected override JetBrains.ReSharper.Psi.Tree.ITreeNode ReplaceByQualifier(JetBrains.ReSharper.Psi.CSharp.Tree.IReferenceExpression expression, JetBrains.ReSharper.Refactorings.Inline.InlinedCallInfo info) { }
        protected override JetBrains.ReSharper.Psi.Tree.ITreeNode ReplaceReturnWithAssignment(JetBrains.ReSharper.Psi.CSharp.Tree.IReturnStatement returnStatement) { }
        protected override void TransformElement(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        protected override bool ValueIsNotNull(JetBrains.ReSharper.Psi.CSharp.Tree.IReturnStatement statement) { }
    }
    public class CSharpInlineHelper : JetBrains.ReSharper.Refactorings.Inline.InlineHelper
    {
        public CSharpInlineHelper(JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Resolve.IReference> AllNotQualifiableReferences(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public override bool CanHaveSideEffects([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.IExpression expression) { }
        public override bool CanHaveSideEffects(JetBrains.ReSharper.Psi.Resolve.IReference reference, out JetBrains.ReSharper.Psi.Tree.IExpression qualifier, bool isStatic) { }
        public override bool CanHaveSideEffects(JetBrains.ReSharper.Psi.Tree.IArgument argument) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Psi.CSharp.Tree.IBlock EnBlock(JetBrains.ReSharper.Psi.Resolve.IReference reference, out JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpStatement tag) { }
        public static JetBrains.ReSharper.Psi.Tree.IArgumentsOwner GetArguemntOwnerOfReference(ref JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public override System.Collections.Generic.Dictionary<int, JetBrains.ReSharper.Refactorings.Inline.InlinedArgumentInfo> GetArgument2Infos(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Refactorings.Inline.InlinedMethodInfo inlinedMethodInfo, System.Collections.Generic.Dictionary<JetBrains.ReSharper.Psi.IParameter, JetBrains.ReSharper.Refactorings.Inline.ArgUtil.ArgumentFromParameter> parameter2argument) { }
        public override JetBrains.ReSharper.Psi.Tree.IArgumentsOwner GetArgumentOwner(ref JetBrains.ReSharper.Psi.Resolve.IReference reference, bool replaceMethodGroup) { }
        public override JetBrains.ReSharper.Psi.Tree.ITreeNode GetContainingStatement(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public override System.Collections.Generic.Dictionary<JetBrains.ReSharper.Psi.IParameter, JetBrains.ReSharper.Refactorings.Inline.ArgUtil.ArgumentFromParameter> GetParameter2Argument(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.IParametersOwner parametersOwner) { }
        public override void InsertReturnValueTempVariable(JetBrains.ReSharper.Refactorings.Inline.InlinedCallInfo inlinedCallInfo, JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Refactorings.Inline.CallSiteContext context) { }
        public override void InsertTempForArgument(JetBrains.ReSharper.Refactorings.Inline.InlinedParameterInfo parameterInfo, JetBrains.ReSharper.Refactorings.Inline.InlinedArgumentInfo argumentInfo, JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Refactorings.Inline.CallSiteContext context, JetBrains.ReSharper.Psi.ExtensionsAPI.ReferenceIdentitySaver saver) { }
        public override void InsertTempForQualifier(JetBrains.ReSharper.Refactorings.Inline.InlinedCallInfo inlinedCallInfo, JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Refactorings.Inline.CallSiteContext context, JetBrains.ReSharper.Psi.ExtensionsAPI.ReferenceIdentitySaver saver) { }
        public override void InsertTempVariableForAssignedValue(JetBrains.ReSharper.Refactorings.Inline.InlinedCallInfo inlinedCallInfo, JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Refactorings.Inline.CallSiteContext context) { }
        public override bool IsSourceOfAssignment(JetBrains.ReSharper.Psi.Resolve.IReference reference, out JetBrains.ReSharper.Psi.Tree.IExpression destination, JetBrains.ReSharper.Refactorings.Inline.InlinedCallKinds inlinedCallKinds) { }
        public override void RemoveCastFromElement(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public override void ReplaceTypeParameter(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.ITypeParameter parameter, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution) { }
    }
    public class CSharpInlineMethod : JetBrains.ReSharper.Refactorings.Inline.InlineMethod
    {
        public CSharpInlineMethod(JetBrains.ReSharper.Refactorings.Inline.InlineMethodWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public override JetBrains.ReSharper.Refactorings.Inline.InlineHelper InlineHelper { get; }
        public override bool AllReturnsAreLast(JetBrains.ReSharper.Psi.IDeclaredElement element) { }
        public override JetBrains.ReSharper.Psi.Tree.ITreeNode GetBody(JetBrains.ReSharper.Psi.Tree.IDeclaration decl) { }
        public override JetBrains.ReSharper.Psi.Tree.ITreeNode GetContainingStatement(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public override JetBrains.ReSharper.Psi.Tree.ITreeNode GetContextForNaming(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public override bool GetIsDestinationOfAssignment(JetBrains.ReSharper.Psi.Resolve.IReference reference, out JetBrains.ReSharper.Psi.Tree.IExpression expression) { }
        public override bool GetIsPropertyInitializer(JetBrains.ReSharper.Psi.Resolve.IReference reference, out JetBrains.ReSharper.Psi.Tree.IExpression expression) { }
        public override bool GetThisIsUsedOnce(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
        public override bool GetUsedAsDelegate(JetBrains.ReSharper.Refactorings.Inline.InlinedMethodInfo info, JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public override bool Ignore(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public override bool IsFromStatement(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public override bool IsLastStatement(JetBrains.ReSharper.Psi.Resolve.IReference reference, out JetBrains.ReSharper.Psi.Tree.ITreeNode lastStatement) { }
        public override bool IsReturned(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Refactorings.Inline.InlinedCallKinds inlinedCallKind) { }
        public override bool IsReturnStatementOnly(JetBrains.ReSharper.Psi.IDeclaredElement element, out JetBrains.ReSharper.Psi.Tree.IExpression returnedExpression, out JetBrains.ReSharper.Psi.Tree.ITreeNode blockOfStatements) { }
        public override bool ReplaceCall([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.Tree.IExpression returnedExpression, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Refactorings.Inline.InlinedCallInfo inlinedCallInfo, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Refactorings.Inline.CallSiteContext context) { }
        public override void ReplaceMethodGroup(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Refactorings.Inline.CallSiteContext context, JetBrains.ReSharper.Refactorings.Inline.InlinedCallInfo inlinedCallInfo) { }
        public override bool ReplacePropertyInitializer(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.Tree.ITreeNode container, JetBrains.ReSharper.Refactorings.Inline.InlinedCallInfo inlinedCallInfo, JetBrains.ReSharper.Refactorings.Inline.CallSiteContext context, bool replaceOriginal) { }
        public override bool ReplaceStatement(ref JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.Tree.ITreeNode container, JetBrains.ReSharper.Refactorings.Inline.InlinedCallInfo inlinedCallInfo, JetBrains.ReSharper.Refactorings.Inline.CallSiteContext context, bool replaceOriginal) { }
        public override System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Resolve.IReference> TransformReference(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
    }
    public class static CSharpInlineMethodUtil
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Psi.Resolve.IReference ConvertMethodGroup([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Resolve.IReference reference, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver, System.Collections.Generic.IList<JetBrains.ReSharper.Psi.IParameter> parameters) { }
    }
    public class ReturnProblemAnalyser
    {
        public static bool AllReturnStatementsAreLast(JetBrains.ReSharper.Psi.CSharp.Tree.IBlock block) { }
    }
    public class ReturnsCounter : JetBrains.ReSharper.Psi.IRecursiveElementProcessor
    {
        public bool ProcessingIsFinished { get; }
        public static bool HasOneReturnSatement(JetBrains.ReSharper.Psi.CSharp.Tree.IBlock block, out JetBrains.ReSharper.Psi.CSharp.Tree.IReturnStatement returnStatement) { }
        public bool InteriorShouldBeProcessed(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public void ProcessAfterInterior(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public void ProcessBeforeInterior(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
    }
    public class ThisReferencesFinder : JetBrains.ReSharper.Psi.IRecursiveElementProcessor
    {
        public ThisReferencesFinder(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public bool HasOneReference { get; }
        public bool HasReferences { get; }
        public bool ProcessingIsFinished { get; }
        public int ReferencesCount { get; }
        public bool InteriorShouldBeProcessed(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public void ProcessAfterInterior(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public void ProcessBeforeInterior(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
    }
}
namespace JetBrains.ReSharper.Refactorings.CSharp.InlineClass
{
    
    public class CsInlineClassAnalyzer : JetBrains.ReSharper.Refactorings.InlineClass.InlineClassAnalyzer
    {
        public CsInlineClassAnalyzer(JetBrains.ReSharper.Refactorings.InlineClass.InlineClassWorkflow inlineClassWorkflow, JetBrains.ReSharper.Psi.ITypeOwner element, JetBrains.ReSharper.Psi.ITypeElement owner) { }
        protected override void AddMemberInfo(JetBrains.ReSharper.Psi.ITypeMember member) { }
        public override void Analyze() { }
        protected override void FillTargetTypeElements() { }
        protected JetBrains.ReSharper.Psi.ITypeMember GetBackingElement(JetBrains.ReSharper.Psi.CSharp.Tree.IPropertyDeclaration propertyDeclaration) { }
        protected override void InitializeMembers(JetBrains.ReSharper.Psi.ITypeOwner element, JetBrains.ReSharper.Psi.ITypeElement owner) { }
    }
    public class CsInlineClassHelper : JetBrains.ReSharper.Refactorings.InlineClass.InlineClassHelper
    {
        public override JetBrains.ReSharper.Refactorings.InlineClass.InlineClassAnalyzer GetAnalyzer(JetBrains.ReSharper.Refactorings.InlineClass.InlineClassWorkflow inlineClassWorkflow, JetBrains.ReSharper.Psi.ITypeOwner element, JetBrains.ReSharper.Psi.ITypeElement owner) { }
    }
    public class CsInlineClassRefactoringExec : JetBrains.ReSharper.Refactorings.InlineClass.IInlineClassRefactoringExec, JetBrains.ReSharper.Refactorings.IRefactoringExec
    {
        public CsInlineClassRefactoringExec(JetBrains.ReSharper.Refactorings.InlineClass.InlineClassWorkflow workflow) { }
        public JetBrains.ReSharper.Psi.Modules.IPsiModule PsiModule { get; set; }
        public JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver RefactoringDriver { get; set; }
        public JetBrains.ReSharper.Refactorings.Util.NewTypeImages.ResolveImagesRepository Repository { get; }
        public JetBrains.ReSharper.Refactorings.InlineClass.InlineClassWorkflow Workflow { get; set; }
        public void CutAndPaste(JetBrains.Application.Progress.IProgressIndicator subPi) { }
        public void ProceedConstructor(System.Collections.Generic.Dictionary<JetBrains.ReSharper.Psi.Tree.IParameterDeclaration, JetBrains.ReSharper.Psi.Tree.IArgument> parameters2Arguments, JetBrains.ReSharper.Psi.CSharp.Tree.IConstructorDeclaration ctor) { }
        public void Rebind(JetBrains.Application.Progress.IProgressIndicator subPi) { }
    }
}
namespace JetBrains.ReSharper.Refactorings.CSharp.InlineField
{
    
    public class CSharpInlineField : JetBrains.ReSharper.Refactorings.InlineField.InlineFieldBase
    {
        public CSharpInlineField(JetBrains.ReSharper.Refactorings.InlineField.InlineFieldWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public override JetBrains.ReSharper.Refactorings.Inline.InlineHelper InlineHelper { get; }
        public override bool CanInlineReference(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public override bool GetCanUseRefOut(JetBrains.ReSharper.Psi.Tree.IExpression expression) { }
        public override JetBrains.ReSharper.Psi.Tree.ITreeNode GetContainingDeclarationBlock(JetBrains.ReSharper.Psi.Tree.IExpression expression) { }
        public override JetBrains.ReSharper.Psi.Tree.IExpression GetInitializerExpression(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public override JetBrains.ReSharper.Psi.Tree.IExpression GetInitializerExpression(JetBrains.ReSharper.Psi.IField field) { }
        public override bool HasSideEffects(JetBrains.ReSharper.Psi.Tree.IExpression expression) { }
        public override bool Ignore(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public override string InsertTempVariable(JetBrains.ReSharper.Psi.Tree.ITreeNode tag, string name, JetBrains.ReSharper.Psi.Tree.IExpression expression) { }
        public static bool IsInitializationOfField(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.IField field, out JetBrains.ReSharper.Psi.Tree.IExpression initializer) { }
        public override void ProcessReferenceWithContext(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Refactorings.Inline.CallSiteContext context, JetBrains.ReSharper.Refactorings.Inline.InlinedCallInfo info) { }
        public override void RemoveAssgnment(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public override void RemoveField(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration) { }
        public override void ReplaceExpression(JetBrains.ReSharper.Psi.Resolve.IReference reference, string localName) { }
        public override bool ThisIsUsed(JetBrains.ReSharper.Psi.Tree.IExpression expression) { }
    }
    public class CSharpInlineFieldInspectionContextFactory : JetBrains.ReSharper.Psi.ControlFlow.IControlFlowContextFactory<JetBrains.ReSharper.Refactorings.InlineField.InlineFieldInspectionContext>
    {
        public JetBrains.ReSharper.Refactorings.InlineField.InlineFieldInspectionContext InitialContext { get; }
        public JetBrains.ReSharper.Refactorings.InlineField.InlineFieldInspectionContext CloneContext(JetBrains.ReSharper.Refactorings.InlineField.InlineFieldInspectionContext context) { }
        public JetBrains.ReSharper.Refactorings.InlineField.InlineFieldInspectionContext Merge(System.Collections.Generic.IList<JetBrains.ReSharper.Refactorings.InlineField.InlineFieldInspectionContext> contexts) { }
    }
    public class CSharpInlineFieldInspector : JetBrains.ReSharper.Refactorings.CSharp.Util.RDInspectorOfVariable<JetBrains.ReSharper.Refactorings.InlineField.InlineFieldInspectionContext>
    {
        public CSharpInlineFieldInspector(JetBrains.ReSharper.Psi.ControlFlow.Impl.ControlFlowGraf controlFlowGraf, JetBrains.ReSharper.Refactorings.InlineField.InlineFieldRefactoring executer) { }
        protected override bool CustomInspection(JetBrains.ReSharper.Psi.ControlFlow.IControlFlowElement controlFlowElement, JetBrains.ReSharper.Refactorings.InlineField.InlineFieldInspectionContext context, JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
    }
}
namespace JetBrains.ReSharper.Refactorings.CSharp.InlineParameter
{
    
    public class CSharpInlineParameter : JetBrains.ReSharper.Refactorings.InlineParameter.InlineParameterBase
    {
        public CSharpInlineParameter(JetBrains.ReSharper.Refactorings.InlineParameter.InlineParameterWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public override JetBrains.ReSharper.Refactorings.Inline.InlineHelper InlineHelper { get; }
        public override void AddArgument(JetBrains.ReSharper.Psi.Tree.IArgumentsOwner owner, JetBrains.ReSharper.Psi.Tree.IArgument copy) { }
        public override void AddArgumentFromExpression(JetBrains.ReSharper.Psi.Tree.IArgumentsOwner argumentsOwner, JetBrains.ReSharper.Psi.Tree.IExpression expression) { }
        public override void AddArgumentFromParameter(JetBrains.ReSharper.Psi.Tree.IArgumentsOwner argumentsOwner, JetBrains.ReSharper.Psi.IParameter parameter, JetBrains.ReSharper.Psi.ParameterKind kind) { }
        public override JetBrains.ReSharper.Psi.Tree.IParametersOwnerDeclaration AddDeclarationToFile(JetBrains.ReSharper.Psi.Tree.IParametersOwnerDeclaration newParametersOwnerDeclaration, JetBrains.ReSharper.Psi.IParametersOwner parametersOwner) { }
        public override JetBrains.ReSharper.Psi.IParameter AddParameter(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration, JetBrains.ReSharper.Psi.IParameter parameter) { }
        public override JetBrains.ReSharper.Psi.Tree.IArgument CreateArgument(JetBrains.ReSharper.Psi.Tree.IExpression expression) { }
        public override JetBrains.ReSharper.Psi.Tree.IArgumentsOwner CreateCallToConstructor(JetBrains.ReSharper.Psi.IConstructor constructor) { }
        public override JetBrains.ReSharper.Psi.Tree.IArgumentsOwner CreateCallToMethod(JetBrains.ReSharper.Psi.IMethod method) { }
        public override JetBrains.ReSharper.Psi.Tree.IParametersOwnerDeclaration CreateNewDeclaration(JetBrains.ReSharper.Psi.IParametersOwner owner) { }
        public override void RemoveArguments(JetBrains.ReSharper.Psi.Tree.IArgumentsOwner owner, System.Collections.Generic.List<JetBrains.ReSharper.Psi.Tree.IArgument> arguments) { }
        public override void ReplaceArguments(JetBrains.ReSharper.Psi.Tree.IArgumentsOwner owner, System.Collections.Generic.List<JetBrains.ReSharper.Psi.Tree.IArgument> arguments) { }
        public override void ReplaceBody(JetBrains.ReSharper.Refactorings.Inline.CallSiteContext context, JetBrains.ReSharper.Refactorings.Inline.InlinedCallInfo info, JetBrains.ReSharper.Psi.IParametersOwner owner, JetBrains.ReSharper.Psi.Tree.ITreeNode body, JetBrains.ReSharper.Refactorings.InlineParameter.Impl.InlineParameterEngine engine) { }
        public override void ReplaceDeclarations(JetBrains.ReSharper.Psi.IParametersOwner parametersOwner) { }
        public override JetBrains.ReSharper.Psi.Tree.IExpression ReplaceExpression<T>(T expression, string name)
            where T : JetBrains.ReSharper.Psi.Tree.IExpression { }
        public override JetBrains.ReSharper.Psi.Tree.IExpression ReplaceWithThis(JetBrains.ReSharper.Psi.Tree.IExpression expression) { }
    }
    public class CSharpInlineParameterHelper : JetBrains.ReSharper.Refactorings.InlineParameter.InlineParameterHelper
    {
        public override bool IsLanguageSupported { get; }
        public override JetBrains.ReSharper.Psi.Tree.IArgumentsOwner CopyArgumentsOwner(JetBrains.ReSharper.Psi.Tree.IArgumentsOwner owner) { }
        public override JetBrains.ReSharper.Psi.Tree.IExpression CreateThisExpression(JetBrains.ReSharper.Psi.Modules.IPsiModule project) { }
        public override JetBrains.ReSharper.Psi.Tree.IArgumentsOwner GetArgumentsOwner(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public override JetBrains.ReSharper.Psi.Tree.IExpression GetArgumentValue(JetBrains.ReSharper.Psi.Tree.IArgument argument) { }
        public override JetBrains.ReSharper.Psi.ITypeMember GetCalledMember(JetBrains.ReSharper.Psi.Tree.IArgumentsOwner owner) { }
        public override JetBrains.ReSharper.Psi.Tree.ITreeNode GetContextOfParameterOwner(JetBrains.ReSharper.Psi.IParametersOwner owner) { }
        public override JetBrains.ReSharper.Psi.Tree.IExpression GetInvocation(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public override JetBrains.ReSharper.Psi.IParameter GetParameterFromArgument(JetBrains.ReSharper.Psi.Tree.IArgument argument) { }
        public override JetBrains.ReSharper.Psi.Tree.IExpression GetQualifier(JetBrains.ReSharper.Psi.Tree.IArgumentsOwner owner, out bool hasThisQualifier) { }
        public override JetBrains.ReSharper.Psi.Resolve.IReference GetReference(JetBrains.ReSharper.Psi.Tree.IArgumentsOwner argumentsOwner) { }
        public override bool IsThisExpression(JetBrains.ReSharper.Psi.Tree.IArgument argument) { }
        public override bool IsThisExpression(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public override JetBrains.ReSharper.Psi.Tree.ITreeNode Qualify(JetBrains.ReSharper.Psi.Tree.ITreeNode element, string name, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Refactorings.InlineParameter.Data.ParameterOwnerUsageUpdater> updaters, JetBrains.ReSharper.Refactorings.InlineParameter.Data.SuggestedParameter thisSuggestion) { }
        public override JetBrains.ReSharper.Psi.Tree.ITreeNode ReplaceThisReferences(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.IDeclaredType type, JetBrains.ReSharper.Psi.ExtensionsAPI.ReferenceIdentitySaver saver, JetBrains.Util.Key<string> key, out bool hasUnresolvedThis, bool hasThisQualifier) { }
    }
}
namespace JetBrains.ReSharper.Refactorings.CSharp.InlineVar
{
    
    public class CSharpInlineVar : JetBrains.ReSharper.Refactorings.InlineVar.InlineVarBase
    {
        public CSharpInlineVar(JetBrains.ReSharper.Refactorings.InlineVar.InlineVarWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public override JetBrains.ReSharper.Refactorings.Inline.InlineHelper InlineHelper { get; }
        public override bool Ignore(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public override void ProcessReferenceWithContext(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Refactorings.Inline.CallSiteContext context, JetBrains.ReSharper.Refactorings.Inline.InlinedCallInfo info) { }
        public override void RemoveAssignment(JetBrains.ReSharper.Psi.Tree.ITreeNode expression) { }
        public override void RemoveVariableDeclaration(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration) { }
    }
    public class CSharpInlineVarAnalyser : JetBrains.ReSharper.Refactorings.InlineVar.RDAnalysis.InlineVarAnalyserBase
    {
        public CSharpInlineVarAnalyser(JetBrains.ReSharper.Refactorings.InlineVar.InlineVarWorkflow workflow) { }
        public override JetBrains.ReSharper.Psi.Tree.ITreeNode AssignmentExpression { get; }
        public override JetBrains.ReSharper.Psi.Tree.IExpression Expression { get; }
        public override bool InlineAll { get; set; }
        public override System.Collections.Generic.List<JetBrains.ReSharper.Psi.Resolve.IReference> References { get; }
        public override JetBrains.Util.Pair<bool, string> Run(JetBrains.ReSharper.Psi.IDeclaredElement variable, JetBrains.ReSharper.Psi.Tree.ITreeNode element, System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Resolve.IReference> references) { }
    }
    public class CSharpInlineVarContextFactory : JetBrains.ReSharper.Psi.ControlFlow.IControlFlowContextFactory<JetBrains.ReSharper.Refactorings.InlineVar.RDAnalysis.InlineVarContext>
    {
        public JetBrains.ReSharper.Refactorings.InlineVar.RDAnalysis.InlineVarContext InitialContext { get; }
        public JetBrains.ReSharper.Refactorings.InlineVar.RDAnalysis.InlineVarContext CloneContext(JetBrains.ReSharper.Refactorings.InlineVar.RDAnalysis.InlineVarContext context) { }
        public JetBrains.ReSharper.Refactorings.InlineVar.RDAnalysis.InlineVarContext Merge(System.Collections.Generic.IList<JetBrains.ReSharper.Refactorings.InlineVar.RDAnalysis.InlineVarContext> contexts) { }
    }
    public class CSharpInlineVarInspector : JetBrains.ReSharper.Refactorings.CSharp.Util.RDInspectorOfVariable<JetBrains.ReSharper.Refactorings.InlineVar.RDAnalysis.InlineVarContext>
    {
        public CSharpInlineVarInspector(JetBrains.ReSharper.Psi.ControlFlow.Impl.ControlFlowGraf controlFlowGraf, JetBrains.ReSharper.Psi.CSharp.Tree.IAssignmentExpression assignmentExpression, JetBrains.ReSharper.Psi.ITypeOwner variable) { }
        protected override bool CustomInspection(JetBrains.ReSharper.Psi.ControlFlow.IControlFlowElement controlFlowElement, JetBrains.ReSharper.Refactorings.InlineVar.RDAnalysis.InlineVarContext context, JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
    }
}
namespace JetBrains.ReSharper.Refactorings.CSharp.InplaceRefactorings
{
    
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class CSharpExtensionMethodOnPasteProvider : JetBrains.ReSharper.InplaceRefactorings.CutCopyPaste.ExtensionMethodImportOnPasteProviderBase
    {
        protected override JetBrains.ReSharper.InplaceRefactorings.CutCopyPaste.ExtensionMethodImportOnPasteProviderBase.ExtensionMethodReferenceData CreateReferenceData(string referenceName, JetBrains.ReSharper.Psi.IMethod targetExtensionMethod) { }
        protected override bool IsYourReference(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.CSharp.CSharpLanguage))]
    public class CSharpInplaceChangeSignatureHelper : JetBrains.ReSharper.InplaceRefactorings.ChangeSignature.IInplaceChangeSignatureHelper
    {
        public JetBrains.ReSharper.InplaceRefactorings.ChangeSignature.IVisualizationModelLanguageHelper VisualizationModelLanguageHelper { get; }
        public JetBrains.ReSharper.Psi.TreeTextRange GetParameterListRange(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration) { }
        public JetBrains.ReSharper.InplaceRefactorings.ChangeSignature.SignatureKind GetSignatureKind(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration) { }
        public virtual JetBrains.ReSharper.Psi.TreeTextRange GetSignatureRange(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration) { }
        public bool IsValidConstructorName(JetBrains.ReSharper.Psi.Tree.ITypeMemberDeclaration constructorDeclaration, JetBrains.ReSharper.Psi.ITypeElement containingType) { }
    }
}
namespace JetBrains.ReSharper.Refactorings.CSharp.IntroducePartOfString
{
    
    public class IntroducePartOfStringRefactoring : JetBrains.ReSharper.Refactorings.IntroduceVariable.IntroduceLocalRefactoring
    {
        public IntroducePartOfStringRefactoring(JetBrains.ReSharper.Refactorings.IntroduceVariable.IntroduceLocalWorkflowBase workFlow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        protected override string CanNotPreformActionText { get; }
        protected override JetBrains.ReSharper.Feature.Services.Refactorings.ReplaceInfo CreateReplaceInfo() { }
        protected override void ValueSelectedCallback(JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.Hotspot oldHotspot) { }
    }
    public class IntroducePartOfStringWorkflow : JetBrains.ReSharper.Refactorings.IntroduceVariable.IntroduceLocalWorkflowBase
    {
        public IntroducePartOfStringWorkflow(JetBrains.ProjectModel.ISolution solution, string actionId) { }
        public JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpLiteralExpression OwnerExpression { get; }
        public JetBrains.ReSharper.Psi.TreeTextRange SelectionTreeRange { get; }
        public override string Title { get; }
        public override JetBrains.ReSharper.Refactorings.Workflow.IRefactoringExecuter CreateRefactoring(JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public override bool Initialize(JetBrains.Application.DataContext.IDataContext context) { }
        public override bool IsAvailable(JetBrains.Application.DataContext.IDataContext context) { }
    }
    [JetBrains.ReSharper.Refactorings.Workflow.RefactoringWorkflowProviderAttribute()]
    public class IntroducePartOfStringWorkflowProvider : JetBrains.ReSharper.Feature.Services.ActionsMenu.IWorkflowProvider<JetBrains.ReSharper.Refactorings.Workflow.IRefactoringWorkflow, JetBrains.ReSharper.Refactorings.Workflow.RefactoringActionGroup>, JetBrains.ReSharper.Refactorings.IntroduceVariable.Impl.IIntroduceVariableWorkflowProvider, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringWorkflowProvider
    {
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Refactorings.Workflow.IRefactoringWorkflow> CreateWorkflow(JetBrains.Application.DataContext.IDataContext dataContext) { }
    }
}
namespace JetBrains.ReSharper.Refactorings.CSharp.IntroduceVariable
{
    
    public class CSharpIntroduceVariable : JetBrains.ReSharper.Refactorings.IntroduceVariable.IntroduceVariableBase
    {
        public CSharpIntroduceVariable(JetBrains.ReSharper.Refactorings.IntroduceVariable.IntroduceLocalWorkflowBase workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public static bool Contains(JetBrains.ReSharper.Refactorings.CSharp.IntroduceVariable.SubQuerySelection selection, JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public override JetBrains.ReSharper.Feature.Services.Refactorings.ReplaceInfo Process(System.Collections.Generic.List<JetBrains.ReSharper.Psi.Tree.ITreeNode> expressions, JetBrains.ReSharper.Psi.Tree.ITreeNode sourceExpression) { }
        public override void ValueSelectedCallback(JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.Hotspot hotspot) { }
    }
    public class IntroduceSubqueryRefactoring : JetBrains.ReSharper.Refactorings.IntroduceVariable.IntroduceLocalRefactoring
    {
        public IntroduceSubqueryRefactoring(JetBrains.ReSharper.Refactorings.CSharp.IntroduceVariable.IntroduceSubqueryWorkflow workFlow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        protected override string CanNotPreformActionText { get; }
        protected override JetBrains.ReSharper.Feature.Services.Refactorings.ReplaceInfo CreateReplaceInfo() { }
        public JetBrains.ReSharper.Feature.Services.Refactorings.ReplaceInfo TransformSubQuery(JetBrains.ReSharper.Refactorings.CSharp.IntroduceVariable.SubQuerySelection selection) { }
        protected override void ValueSelectedCallback(JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.Hotspot oldHotspot) { }
    }
    public class IntroduceSubqueryWorkflow : JetBrains.ReSharper.Refactorings.IntroduceVariable.IntroduceLocalWorkflowBase
    {
        public IntroduceSubqueryWorkflow(JetBrains.ProjectModel.ISolution solution, string actionId) { }
        public JetBrains.ReSharper.Refactorings.CSharp.IntroduceVariable.SubQuerySelection SubQuerySelection { get; }
        public override string Title { get; }
        public override JetBrains.ReSharper.Refactorings.Workflow.IRefactoringExecuter CreateRefactoring(JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public override bool Initialize(JetBrains.Application.DataContext.IDataContext context) { }
        public override bool IsAvailable(JetBrains.Application.DataContext.IDataContext context) { }
    }
    public class SubQuerySelection
    {
        public SubQuerySelection(JetBrains.ReSharper.Psi.Tree.IExpression expression, JetBrains.ReSharper.Psi.Tree.ITreeNode clause, JetBrains.ReSharper.Psi.Tree.ITreeNode firstClause) { }
        public JetBrains.ReSharper.Psi.Tree.IExpression Expression { get; }
        public JetBrains.ReSharper.Psi.Tree.ITreeNode FirstSelectedClause { get; }
        public JetBrains.ReSharper.Psi.Tree.ITreeNode LastSelectedClause { get; }
    }
}
namespace JetBrains.ReSharper.Refactorings.CSharp.IntroField
{
    
    public class CSharpIntroField : JetBrains.ReSharper.Refactorings.IntroduceField.IntroFieldBase
    {
        public CSharpIntroField(JetBrains.ReSharper.Refactorings.IntroduceField.IntroFieldWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public override void AddAssignment(JetBrains.ReSharper.Psi.IParameter parameter, JetBrains.ReSharper.Psi.ITypeMember member, JetBrains.ReSharper.Psi.Tree.IExpression expression) { }
        public override JetBrains.ReSharper.Psi.ITypeMember AddField(JetBrains.ReSharper.Psi.Tree.ITypeDeclaration typeDeclaration, JetBrains.ReSharper.Psi.Tree.IExpression initExpression, System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Tree.ITreeNode> tags) { }
        public override JetBrains.ReSharper.Psi.Tree.IExpression GetInitializer(JetBrains.ReSharper.Psi.ILocalVariable variable) { }
        public override bool ReplaceUsages(System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Tree.ITreeNode> expressions, JetBrains.ReSharper.Psi.ITypeMember field, JetBrains.ReSharper.Psi.Tree.ITreeNode initializer) { }
        public override bool ReplaceVariableDeclaration(JetBrains.ReSharper.Psi.ILocalVariable variable, JetBrains.ReSharper.Psi.ITypeMember field, JetBrains.ReSharper.Psi.Tree.IExpression initializer) { }
    }
    public class CSharpIntroFieldAnalyser : JetBrains.ReSharper.Refactorings.IntroduceField.IntroFieldAnalyser
    {
        public override bool CanBeConstant(JetBrains.ReSharper.Psi.ILocalVariable variable) { }
        public override JetBrains.ReSharper.Psi.Tree.ITreeNode GetBlock(JetBrains.ReSharper.Psi.Tree.IDeclaration decl) { }
        public static JetBrains.ReSharper.Psi.Tree.ITreeNode GetBodyOfDeclaration(JetBrains.ReSharper.Psi.Tree.IDeclaration decl) { }
        public override JetBrains.ReSharper.Psi.Tree.ITreeNode GetInitializer(JetBrains.ReSharper.Psi.ILocalVariable variable) { }
        public override bool IsFromConstructor(JetBrains.ReSharper.Psi.ILocalVariable variable, bool isStatic) { }
        public override bool IsFromConstructor(JetBrains.ReSharper.Psi.Tree.ITreeNode element, bool isStatic) { }
    }
}
namespace JetBrains.ReSharper.Refactorings.CSharp.IntroParameter
{
    
    public class CSharpIntroParameter : JetBrains.ReSharper.Refactorings.IntroduceParameter.IntroduceParameterBase
    {
        public CSharpIntroParameter(JetBrains.ReSharper.Refactorings.IntroduceParameter.IntroduceParameterWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public override JetBrains.ReSharper.Refactorings.Inline.InlineHelper InlineHelper { get; }
        public override JetBrains.ReSharper.Psi.Resolve.IReference AddBaseClause(JetBrains.ReSharper.Psi.IDeclaredElement element) { }
        public override void AddParameter(JetBrains.ReSharper.Psi.IType type, string name, JetBrains.ReSharper.Psi.Tree.IDeclaration declaration, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution, JetBrains.ReSharper.Psi.Tree.ITreeNode defaultValue) { }
        public override void CallInline(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Refactorings.Inline.CallSiteContext context, JetBrains.ReSharper.Refactorings.Inline.InlinedCallInfo info, System.Collections.Generic.IList<string> lambdaParameterNames, int lastArgIndex) { }
        public override void FixOtherArguments(ref JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Refactorings.Inline.InlinedCallInfo info, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution) { }
        public override void RemoveLocalVariable(JetBrains.ReSharper.Psi.ILocalVariable variable) { }
        public override void ReplaceExpression(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public override bool ThisIsUsed(JetBrains.ReSharper.Psi.Tree.ITreeNode expression) { }
    }
    public class static CSharpIntroParameterUtil
    {
        public static void CallInline(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Refactorings.Inline.InlinedCallInfo info, JetBrains.ReSharper.Refactorings.Inline.CallSiteContext context, System.Collections.Generic.ICollection<string> lambdaParameterNames, JetBrains.ReSharper.Refactorings.Inline.InlineHelper helper, int lastArgIndex, bool first, string parameterName) { }
        public static void FixOtherParameters(ref JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Refactorings.Inline.InlinedCallInfo info, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution) { }
    }
}
namespace JetBrains.ReSharper.Refactorings.CSharp.Iterator2Function
{
    
    public class CsIterator2Function : JetBrains.ReSharper.Refactorings.Iterator2Function.Iterator2FunctionBase
    {
        public CsIterator2Function(JetBrains.ReSharper.Refactorings.Iterator2Function.Iterator2FunctionWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        protected override void CollectListNameSuggestions(JetBrains.ReSharper.Psi.Tree.IDeclaration iterator, JetBrains.ReSharper.Psi.Naming.Extentions.EntryOptions options, JetBrains.ReSharper.Psi.Naming.Extentions.INamesCollection suggestion) { }
        protected override JetBrains.ReSharper.Psi.IDeclaredType GetDeclaredElementReturnType(JetBrains.ReSharper.Psi.IDeclaredElement iterator) { }
        public override JetBrains.ReSharper.Feature.Services.Refactorings.ReplaceInfo ProcessIterator(JetBrains.ReSharper.Psi.Tree.IDeclaration iterator, JetBrains.ReSharper.Psi.IType elementType, bool returnsEnumerator, JetBrains.Application.Progress.IProgressIndicator pi) { }
    }
}
namespace JetBrains.ReSharper.Refactorings.CSharp.Move.AdjustNamespaces
{
    
    public class CSharpAdjustNamespaceHelper : JetBrains.ReSharper.Refactorings.Move.AdjustNamespaces.AdjustNamespacesHelperBase
    {
        public override bool IsLanguageSupported { get; }
        public override bool FileHasProblems(JetBrains.ReSharper.Psi.Tree.IFile file, string expectedNamespace) { }
        public override void FixFile(JetBrains.ReSharper.Psi.Tree.IFile file, string expectedNamespaceName, JetBrains.ReSharper.Refactorings.Util.NewTypeImages.ResolveImagesRepository repository, System.Collections.Generic.List<JetBrains.ReSharper.Psi.IDeclaredElement> importedNamespaces) { }
        public override JetBrains.ReSharper.Psi.IDeclaredElement GetImportedSymbolOfUsing(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public override System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Tree.ITypeDeclaration> GetTopLevelTypeDeclarations(JetBrains.ReSharper.Psi.Tree.IFile file) { }
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Tree.ITreeNode> GetUsingsFromFile(JetBrains.ReSharper.Psi.Tree.IFile file, System.Collections.Generic.IList<JetBrains.ReSharper.Psi.INamespace> namespaces) { }
        public override bool IsFromExtendsList(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public override bool IsReferenceName(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public override void RemoveUnusedUsing(JetBrains.ReSharper.Psi.Tree.IFile file, System.Collections.Generic.JetHashSet<JetBrains.ReSharper.Psi.Tree.ITreeNode> usings) { }
        public override void RemoveUsing(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public override void SaveUnusedUsings(JetBrains.ReSharper.Psi.Tree.IFile file, JetBrains.ReSharper.Refactorings.Move.Common.UnusedUsingSaver saver) { }
    }
}
namespace JetBrains.ReSharper.Refactorings.CSharp.Move.Common
{
    
    public class static CSharpMoveUtil
    {
        public static JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpFile CopyFileAndFixNamespaces(JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpFile newFile, JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpFile oldFile, string expectedNamespaceName, System.Collections.Generic.IList<JetBrains.ReSharper.Psi.IDeclaredElement> importedNamespaces) { }
        public static void EnsurePreimportedNamespaces(JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpFile file) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Tree.ITypeDeclaration> GetTopLevelTypeDeclarations(JetBrains.ReSharper.Psi.Tree.IFile file) { }
        public static System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Tree.ITreeNode> GetUsingsFromFiles(JetBrains.ReSharper.Psi.Tree.IFile file, System.Collections.Generic.IList<JetBrains.ReSharper.Psi.INamespace> namespaces) { }
    }
}
namespace JetBrains.ReSharper.Refactorings.CSharp.Move.MoveToFile
{
    
    public class CSharpMoveToFileHelper : JetBrains.ReSharper.Refactorings.Move.MoveTypeDeclarationToFile.MoveToFileHelperBase
    {
        public override bool IsLanguageSupported { get; }
        public override bool FileHasOtherDeclarations(JetBrains.ReSharper.Psi.Tree.ITypeDeclaration declaration) { }
        public override bool IsFromExtendsList(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public override bool IsReferenceName(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public override bool MoveDeclaration(JetBrains.ReSharper.Psi.Tree.ITypeDeclaration declaration, JetBrains.ReSharper.Refactorings.Util.NewTypeImages.ResolveImagesRepository repository, JetBrains.ReSharper.Psi.Tree.IFile file, JetBrains.ReSharper.Refactorings.Move.MoveTypeDeclarationToFile.MoveToFileWorkflow workflow) { }
        public override void RemoveUnusedUsing(JetBrains.ReSharper.Psi.Tree.IFile file, System.Collections.Generic.JetHashSet<JetBrains.ReSharper.Psi.Tree.ITreeNode> usings) { }
        public override void SaveUnusedUsings(JetBrains.ReSharper.Psi.Tree.IFile file, JetBrains.ReSharper.Refactorings.Move.Common.UnusedUsingSaver saver) { }
    }
}
namespace JetBrains.ReSharper.Refactorings.CSharp.Move.MoveToFolder
{
    
    public class CSharpMoveToFolderHelper : JetBrains.ReSharper.Refactorings.Move.MoveToFolder.MoveToFolderHelperBase
    {
        public override bool CanMoveSingleTypeDeclaration { get; }
        public override bool IsLanguageSupported { get; }
        public override bool DeclarationCanProvideName(JetBrains.ReSharper.Psi.Tree.ITypeDeclaration declaration) { }
        public override string GetCanMoveToProjectFolderError(JetBrains.ProjectModel.IProjectFolder projectFolder) { }
        public override System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Tree.ITypeDeclaration> GetTopLevelTypeDeclarations(JetBrains.ReSharper.Psi.Tree.IFile file) { }
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Tree.ITreeNode> GetUsingsFromFile(JetBrains.ReSharper.Psi.Tree.IFile file, System.Collections.Generic.IList<JetBrains.ReSharper.Psi.INamespace> namespaces) { }
        public override bool IsFromExtendsList(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public override bool IsReferenceName(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public override void MakePublic(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration) { }
        public override bool MoveFewDeclarations(JetBrains.ReSharper.Psi.Tree.IFile sourceFile, JetBrains.ReSharper.Psi.Tree.IFile targetFile, bool fixNamespaces, string name, JetBrains.ReSharper.Refactorings.Util.NewTypeImages.ResolveImagesRepository repository, System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Tree.ITypeDeclaration> children) { }
        public override bool MoveSingleDeclaration(JetBrains.ReSharper.Psi.Tree.ITypeDeclaration typeDeclaration, JetBrains.ReSharper.Psi.Tree.IFile targetFile, string expectedNamespaceName, JetBrains.ReSharper.Refactorings.Util.NewTypeImages.ResolveImagesRepository repository) { }
        public override bool MoveWholeFile(JetBrains.ReSharper.Psi.Tree.IFile sourceFile, JetBrains.ReSharper.Psi.Tree.IFile targetFile, bool fixNamespaces, string expectedNamespaceName, JetBrains.ReSharper.Refactorings.Util.NewTypeImages.ResolveImagesRepository repository) { }
        public override void RemoveUnusedUsing(JetBrains.ReSharper.Psi.Tree.IFile file, System.Collections.Generic.JetHashSet<JetBrains.ReSharper.Psi.Tree.ITreeNode> usings) { }
        public override void RemoveUsing(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public override void SaveUnusedUsings(JetBrains.ReSharper.Psi.Tree.IFile file, JetBrains.ReSharper.Refactorings.Move.Common.UnusedUsingSaver saver) { }
    }
}
namespace JetBrains.ReSharper.Refactorings.CSharp.Move.MoveToNamespace
{
    
    public class CSharpMoveToNamespaceHelper : JetBrains.ReSharper.Refactorings.Move.MoveToNamespace.MoveToNamespaceHelperBase
    {
        public override bool IsLanguageSupported { get; }
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Tree.ITreeNode> GetUsingsFromFile(JetBrains.ReSharper.Psi.Tree.IFile file, System.Collections.Generic.IList<JetBrains.ReSharper.Psi.INamespace> namespaces) { }
        public override bool IsFromExtendsList(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public override bool IsReferenceName(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public override void MovePrimaryDeclaration(JetBrains.ReSharper.Psi.Tree.ITypeDeclaration typeDeclaration, string newNamespaceName, JetBrains.ReSharper.Refactorings.Util.NewTypeImages.ResolveImagesRepository repository) { }
        public override void RemoveUnusedUsing(JetBrains.ReSharper.Psi.Tree.IFile file, System.Collections.Generic.JetHashSet<JetBrains.ReSharper.Psi.Tree.ITreeNode> usings) { }
        public override void RemoveUsing(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public override void SaveUnusedUsings(JetBrains.ReSharper.Psi.Tree.IFile file, JetBrains.ReSharper.Refactorings.Move.Common.UnusedUsingSaver saver) { }
    }
}
namespace JetBrains.ReSharper.Refactorings.CSharp.Move.MovoIntoMatchingFiles
{
    
    public class CSharpMoveIntoMatchingFilesHelper : JetBrains.ReSharper.Refactorings.Move.MoveIntoMatchingFile.MoveIntoMatchingFilesHelperBase
    {
        public override bool IsLanguageSupported { get; }
        public override JetBrains.ReSharper.Psi.Tree.INamespaceDeclaration GetOwnerNamespaceDeclaration(JetBrains.ReSharper.Psi.Tree.ITypeDeclaration typeDeclaration) { }
        public override System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Tree.ITypeDeclaration> GetTopLevelTypeDeclarations(JetBrains.ReSharper.Psi.Tree.IFile file) { }
        public override bool IsFromExtendsList(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public override bool IsReferenceName(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public override void MoveDeclarationFromFile(JetBrains.ReSharper.Refactorings.Move.MoveIntoMatchingFile.Impl.MovedDeclaration declaration, JetBrains.ReSharper.Refactorings.Util.NewTypeImages.ResolveImagesRepository repository) { }
        public override void RemoveUnusedUsing(JetBrains.ReSharper.Psi.Tree.IFile file, System.Collections.Generic.JetHashSet<JetBrains.ReSharper.Psi.Tree.ITreeNode> usings) { }
        public override void SaveUnusedUsings(JetBrains.ReSharper.Psi.Tree.IFile file, JetBrains.ReSharper.Refactorings.Move.Common.UnusedUsingSaver saver) { }
    }
}
namespace JetBrains.ReSharper.Refactorings.CSharp.MoveMembers
{
    
    public class CsExtractInterface : JetBrains.ReSharper.Refactorings.CSharp.MoveMembers.CsPullUpBase<JetBrains.ReSharper.Refactorings.MoveMembers.ImplExtractInterface.IExtractInterfaceItemInfo, JetBrains.ReSharper.Refactorings.MoveMembers.ImplExtractInterface.ExtractInterfaceStaticAnalyser>, JetBrains.ReSharper.Refactorings.IRefactoringExec, JetBrains.ReSharper.Refactorings.MoveMembers.Common.IMove<JetBrains.ReSharper.Refactorings.MoveMembers.ImplExtractInterface.IExtractInterfaceItemInfo>, JetBrains.ReSharper.Refactorings.MoveMembers.ImplExtractInterface.IExtractInterface
    {
        public CsExtractInterface(JetBrains.ReSharper.Refactorings.MoveMembers.ImplExtractInterface.ExtractInterfaceWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public void GetBaseConstructorDeclarationToInsert(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration) { }
    }
    public class CSharpExtractSuperclass : JetBrains.ReSharper.Refactorings.CSharp.MoveMembers.CsPullUpBase<JetBrains.ReSharper.Refactorings.MoveMembers.ImplExtractSuperclass.IExtractSuperclassItemInfo, JetBrains.ReSharper.Refactorings.MoveMembers.ImplExtractSuperclass.ExtractSuperclassStaticAnalyser>, JetBrains.ReSharper.Refactorings.IRefactoringExec, JetBrains.ReSharper.Refactorings.MoveMembers.Common.IMove<JetBrains.ReSharper.Refactorings.MoveMembers.ImplExtractSuperclass.IExtractSuperclassItemInfo>, JetBrains.ReSharper.Refactorings.MoveMembers.ImplExtractSuperclass.IExtractSuperclass
    {
        public CSharpExtractSuperclass(JetBrains.ReSharper.Refactorings.MoveMembers.ImplExtractSuperclass.ExtractSuperclassWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public void GetBaseConstructorDeclarationToInsert(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration) { }
    }
    public class CSharpMoveMembersHelper<TMemberInfo> : JetBrains.ReSharper.Refactorings.MoveMembers.Common.MoveMembersHelper<TMemberInfo>
        where TMemberInfo : JetBrains.ReSharper.Refactorings.CommonUI.IMemberInfo
    {
        public CSharpMoveMembersHelper(JetBrains.ReSharper.Refactorings.MoveMembers.Common.IMoveMembersExecuter executer) { }
        public override void AddBaseInterface(JetBrains.ReSharper.Psi.ITypeElement element, JetBrains.ReSharper.Psi.IDeclaredType info) { }
        public override void AddImplementsSpecification(JetBrains.ReSharper.Psi.Tree.IDeclaration decl, JetBrains.ReSharper.Psi.ITypeElement element, bool nameIsItem, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public override void CheckConstructorReferenceConflict(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public override JetBrains.ReSharper.Psi.Tree.ITypeDeclaration CreateTargetTypeElement(string name, JetBrains.ReSharper.Psi.ITypeElement sourceClass, System.Collections.Generic.List<JetBrains.ReSharper.Psi.ITypeParameter> parameters, bool createClass, bool preserveAccessRigths) { }
        public override System.Collections.Generic.IList<JetBrains.Util.Pair<TMemberInfo, JetBrains.ReSharper.Psi.Tree.IDeclaration>> CutDeclarations(System.Collections.Generic.IEnumerable<TMemberInfo> memberInfos, JetBrains.Application.Progress.SubProgressIndicator pi) { }
        public override void GenerateConstructors(JetBrains.ReSharper.Psi.ITypeElement targetType, JetBrains.ReSharper.Psi.Tree.ITypeDeclaration typeDeclaration, JetBrains.ReSharper.Psi.Pointers.IDeclaredElementPointer<JetBrains.ReSharper.Psi.IConstructor> baseConstructor) { }
        public override JetBrains.ReSharper.Psi.IConstructor GetBaseConstructorDeclarationToInsert(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration) { }
        public override JetBrains.ReSharper.Psi.Tree.ITypeDeclaration InsertSibling(JetBrains.ReSharper.Psi.Tree.ITypeDeclaration declarationToInsert, JetBrains.ReSharper.Psi.Tree.ITypeDeclaration tagDeclaration) { }
        public override JetBrains.ReSharper.Psi.Tree.ITypeDeclaration InsertToNewFile(JetBrains.ReSharper.Psi.Tree.ITypeDeclaration declarationToInsert, JetBrains.ReSharper.Psi.Tree.ITypeDeclaration tagDeclaration, string ns, JetBrains.ProjectModel.IProjectFile fileNearby) { }
        public override bool IsQualifierValid(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public override void MakeOverride(JetBrains.ReSharper.Psi.ITypeMember member) { }
        public override void MakeProtected(JetBrains.ReSharper.Psi.IDeclaredElement element) { }
        public override void MakePublic(JetBrains.ReSharper.Psi.ITypeMember member) { }
        public override void MakeTypeElementAbstract(JetBrains.ReSharper.Psi.ITypeElement element) { }
        public override void PasteDeclarations(System.Collections.Generic.IList<JetBrains.Util.Pair<TMemberInfo, JetBrains.ReSharper.Psi.Tree.IDeclaration>> declarations, JetBrains.ReSharper.Psi.ITypeElement targetType, JetBrains.ProjectModel.IProjectFile projectFile, JetBrains.ReSharper.Psi.Tree.ITypeDeclaration targetTypeDeclaration, JetBrains.Application.Progress.SubProgressIndicator pi) { }
        public override void RemoveDeclaration(JetBrains.ReSharper.Psi.ITypeMember member) { }
        public override void RemoveSuperType(JetBrains.ReSharper.Psi.Tree.ITypeDeclaration typeDeclaration, JetBrains.ReSharper.Psi.IDeclaredType type) { }
        public override void SetSuperclass(JetBrains.ReSharper.Psi.Tree.ITypeDeclaration sourceClass, JetBrains.ReSharper.Psi.ITypeElement newSuper, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution) { }
        public override bool TryProcessMultyFieldForResolve(JetBrains.ReSharper.Psi.IRecursiveElementProcessor collector, JetBrains.ReSharper.Psi.Tree.IDeclaration declaration) { }
    }
    public class CsPullUp : JetBrains.ReSharper.Refactorings.CSharp.MoveMembers.CsPullUpBase<JetBrains.ReSharper.Refactorings.MoveMembers.ImplPullUp.IPullUpItemInfo, JetBrains.ReSharper.Refactorings.MoveMembers.ImplPullUp.PullUpStaticAnalyser>, JetBrains.ReSharper.Refactorings.IRefactoringExec, JetBrains.ReSharper.Refactorings.MoveMembers.Common.IMove<JetBrains.ReSharper.Refactorings.MoveMembers.ImplPullUp.IPullUpItemInfo>, JetBrains.ReSharper.Refactorings.MoveMembers.ImplPullUp.IPullUp
    {
        public CsPullUp(JetBrains.ReSharper.Refactorings.MoveMembers.ImplBaseUp.PullUpBaseWorkflow<JetBrains.ReSharper.Refactorings.MoveMembers.ImplPullUp.PullUpStaticAnalyser, JetBrains.ReSharper.Refactorings.MoveMembers.ImplPullUp.IPullUpItemInfo> workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public void GetBaseConstructorDeclarationToInsert(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration) { }
    }
    public abstract class CsPullUpBase<TMemberInfo, TStaticAnalyser> : JetBrains.ReSharper.Refactorings.MoveMembers.ImplBaseUp.PullUpBase<TMemberInfo, TStaticAnalyser>
        where TMemberInfo :  class, JetBrains.ReSharper.Refactorings.MoveMembers.ImplBaseUp.IPullUpBaseItemInfo
        where TStaticAnalyser : JetBrains.ReSharper.Refactorings.MoveMembers.ImplBaseUp.PullUpBaseStaticAnalyser<>
    {
        protected CsPullUpBase(JetBrains.ReSharper.Refactorings.MoveMembers.ImplBaseUp.PullUpBaseWorkflow<TStaticAnalyser, TMemberInfo> workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public override bool CheckConflictsWithTargetClassName(JetBrains.ReSharper.Psi.ITypeElement element, string name) { }
        public override JetBrains.ReSharper.Refactorings.MoveMembers.Common.MoveMembersHelper<TMemberInfo> GetHelper() { }
        public override bool IsInstanceSpecificEventAccess(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
    }
    public class CsPushDown : JetBrains.ReSharper.Refactorings.MoveMembers.ImplPushDown.PushDownBase
    {
        public CsPushDown(JetBrains.ReSharper.Refactorings.MoveMembers.ImplPushDown.PushDownWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public override bool CheckConflictsWithTargetClassName(JetBrains.ReSharper.Psi.ITypeElement element, string name) { }
        public override JetBrains.ReSharper.Refactorings.MoveMembers.Common.MoveMembersHelper<JetBrains.ReSharper.Refactorings.MoveMembers.ImplPushDown.IPushDownItemInfo> GetHelper() { }
        public override bool IsInstanceSpecificEventAccess(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
    }
}
namespace JetBrains.ReSharper.Refactorings.CSharp.MoveStaticMembers
{
    
    public class CSharpMoveStaticMembersHelper : JetBrains.ReSharper.Refactorings.MoveStaticMembers.MoveStaticMembersHelper
    {
        public override bool IsLanguageSupported { get; }
    }
}
namespace JetBrains.ReSharper.Refactorings.CSharp.MoveTypeToOuterScope
{
    
    public class CSharpMoveTypeToOuterScope2 : JetBrains.ReSharper.Refactorings.MoveInnerClass.MoveTypeToOuterScopeImplBase<JetBrains.ReSharper.Psi.CSharp.Tree.IProperTypeDeclaration, JetBrains.ReSharper.Psi.CSharp.Tree.IClassLikeDeclaration>
    {
        public CSharpMoveTypeToOuterScope2(JetBrains.ReSharper.Refactorings.MoveInnerClass.MoveTypeToOuterScopeRefactoring refactoring) { }
        protected override JetBrains.ReSharper.Psi.CSharp.Tree.IProperTypeDeclaration CutDeclaration(JetBrains.ReSharper.Psi.CSharp.Tree.IProperTypeDeclaration declaration) { }
        protected void DeclareTypeParameterWithConstraints(string name, System.Collections.Generic.IList<JetBrains.ReSharper.Psi.CSharp.Tree.ITypeParameterConstraintsClause> constraints, JetBrains.ReSharper.Psi.CSharp.Tree.IProperTypeDeclaration declaration) { }
        protected override JetBrains.ReSharper.Psi.AccessRights GetAccessRights(JetBrains.ReSharper.Psi.CSharp.Tree.IProperTypeDeclaration typeDeclaration) { }
        protected override JetBrains.ReSharper.Psi.AccessRights GetAccessRights(JetBrains.ReSharper.Psi.CSharp.Tree.IClassLikeDeclaration typeDeclaration) { }
        protected static System.Collections.Generic.IList<JetBrains.ReSharper.Psi.CSharp.Tree.ITypeParameterConstraintsClause> GetConstraintsFor(JetBrains.ReSharper.Psi.ITypeParameter typeParameter, JetBrains.ReSharper.Psi.CSharp.Tree.IClassLikeDeclaration typeDeclaration) { }
        protected override JetBrains.ReSharper.Psi.CSharp.Tree.IClassLikeDeclaration GetContainingTypeDeclaration(JetBrains.ReSharper.Psi.CSharp.Tree.IProperTypeDeclaration declaration) { }
        public override bool IsContextUnsafe(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        protected static JetBrains.ReSharper.Psi.Tree.ITokenNode NewModifier(JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpModifiersOwnerDeclaration node) { }
        protected override JetBrains.ReSharper.Psi.CSharp.Tree.IProperTypeDeclaration PasteDeclaration(JetBrains.ReSharper.Psi.CSharp.Tree.IProperTypeDeclaration declarationCopy, JetBrains.ReSharper.Psi.CSharp.Tree.IClassLikeDeclaration oldContainingDeclaration) { }
        protected override void RemoveNewKeyword(JetBrains.ReSharper.Psi.CSharp.Tree.IProperTypeDeclaration declaration) { }
        protected override void SetAccessRights(JetBrains.ReSharper.Psi.CSharp.Tree.IProperTypeDeclaration typeDeclaration, JetBrains.ReSharper.Psi.AccessRights accessRights) { }
    }
}
namespace JetBrains.ReSharper.Refactorings.CSharp.Property2Auto.Analysis
{
    
    public class AssignmentsToFieldContext
    {
        public JetBrains.ReSharper.Refactorings.CSharp.Property2Auto.Analysis.States FieldState { get; }
        public void Assigned() { }
        public JetBrains.ReSharper.Refactorings.CSharp.Property2Auto.Analysis.AssignmentsToFieldContext Clone() { }
        public bool Equals(JetBrains.ReSharper.Refactorings.CSharp.Property2Auto.Analysis.AssignmentsToFieldContext obj) { }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
        public void MergeWith(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Refactorings.CSharp.Property2Auto.Analysis.AssignmentsToFieldContext> contexts) { }
        public void Read() { }
    }
    public class AssignmentsToFieldContextFactory : JetBrains.ReSharper.Psi.ControlFlow.IControlFlowContextFactory<JetBrains.ReSharper.Refactorings.CSharp.Property2Auto.Analysis.AssignmentsToFieldContext>
    {
        public JetBrains.ReSharper.Refactorings.CSharp.Property2Auto.Analysis.AssignmentsToFieldContext InitialContext { get; }
        public JetBrains.ReSharper.Refactorings.CSharp.Property2Auto.Analysis.AssignmentsToFieldContext CloneContext(JetBrains.ReSharper.Refactorings.CSharp.Property2Auto.Analysis.AssignmentsToFieldContext context) { }
        public JetBrains.ReSharper.Refactorings.CSharp.Property2Auto.Analysis.AssignmentsToFieldContext Merge(System.Collections.Generic.IList<JetBrains.ReSharper.Refactorings.CSharp.Property2Auto.Analysis.AssignmentsToFieldContext> contexts) { }
    }
    public class AssignmentsToFieldInspector : JetBrains.ReSharper.Psi.ControlFlow.Impl.ControlFlowGrafInspector<JetBrains.ReSharper.Refactorings.CSharp.Property2Auto.Analysis.AssignmentsToFieldContext>
    {
        public AssignmentsToFieldInspector(JetBrains.ReSharper.Psi.ControlFlow.Impl.ControlFlowGraf controlFlowGraf, JetBrains.ReSharper.Refactorings.Property2Auto.Property2AutoRefactoring executer) { }
        protected override void InspectLeafElementAndSetContextToExits(JetBrains.ReSharper.Psi.ControlFlow.IControlFlowElement controlFlowElement, JetBrains.ReSharper.Refactorings.CSharp.Property2Auto.Analysis.AssignmentsToFieldContext context) { }
    }
    public enum States
    {
        MayNotUsed = 0,
        ReadBeforeWrite = 1,
        Write = 2,
    }
}
namespace JetBrains.ReSharper.Refactorings.CSharp.Property2Auto
{
    
    public class CsProperty2Auto : JetBrains.ReSharper.Refactorings.Property2Auto.Property2AutoBase
    {
        public CsProperty2Auto(JetBrains.ReSharper.Refactorings.Property2Auto.Property2AutoWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public override void CheckInitializer() { }
        public override JetBrains.ReSharper.Psi.IProperty CreateDeclaration(JetBrains.ReSharper.Psi.AccessRights propertyRights, JetBrains.ReSharper.Psi.AccessRights setterRights, JetBrains.ReSharper.Psi.AccessRights getterRights) { }
        public override void RemoveOldDeclarations() { }
        public override void ScanForConflicts(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public override void ScanUsagesFromStructConstructor(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public class AssignmentStatementsSearcher : JetBrains.ReSharper.Psi.IRecursiveElementProcessor
        {
            public System.Collections.Generic.List<JetBrains.ReSharper.Psi.CSharp.Tree.IAssignmentExpression> Expressions;
            public AssignmentStatementsSearcher() { }
            public bool ProcessingIsFinished { get; }
            public bool InteriorShouldBeProcessed(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
            public void ProcessAfterInterior(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
            public void ProcessBeforeInterior(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        }
    }
    public class CsProperty2AutoChecker : JetBrains.ReSharper.Refactorings.Property2Auto.IProperty2AutoChecker
    {
        public bool IsPropertyWithBackingField(JetBrains.ReSharper.Psi.IProperty property, out JetBrains.ReSharper.Psi.IField field) { }
    }
}
namespace JetBrains.ReSharper.Refactorings.CSharp.Property2Function
{
    
    public class CsProperty2Function : JetBrains.ReSharper.Refactorings.Property2Function.Property2FunctionBase
    {
        public CsProperty2Function(JetBrains.ReSharper.Refactorings.Property2Function.Property2FunctionWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        protected override bool AreEquals(string name1, string name2) { }
        protected override void CheckConflictWithClassName(JetBrains.ReSharper.Psi.ITypeElement element) { }
        public override void ProcessProperty(JetBrains.ReSharper.Psi.IDeclaredElement propertyOrMethod) { }
        public override void ReplaceReadOccurence(JetBrains.ReSharper.Psi.Tree.IExpression expression) { }
        public override void TryMakeConflictForNotExpression(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public override bool TryTransformMethodCall(JetBrains.ReSharper.Psi.Tree.IExpression expression) { }
    }
}
namespace JetBrains.ReSharper.Refactorings.CSharp.Rename
{
    
    [JetBrains.ReSharper.Psi.ShellFeaturePartAttribute()]
    public class AnonymousTypePropertyRenamesFactory : JetBrains.ReSharper.Refactorings.Rename.AtomicRenamesFactory
    {
        public override JetBrains.ReSharper.Refactorings.RenameModel.RenameAvailabilityCheckResult CheckRenameAvailability(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Refactorings.RenameModel.AtomicRenameBase> CreateAtomicRenames(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, string newName, bool doNotAddBindingConflicts) { }
        public override bool IsApplicable(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
    }
    [JetBrains.ReSharper.Refactorings.Rename.DerivedRenamesEvaluatorAttribute()]
    public class ConstructorParameterRenameEvaluator : JetBrains.ReSharper.Refactorings.Rename.IDerivedRenamesEvaluator
    {
        public bool SuggestedElementsHaveDerivedName { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IDeclaredElement> CreateFromElement(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IDeclaredElement> CreateFromReference(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
    }
    [JetBrains.ReSharper.Refactorings.Rename.RenamePartAttribute()]
    public class CSharpPrimaryDeclaredElementForRenameProvider : JetBrains.ReSharper.Refactorings.Rename.IPrimaryDeclaredElementForRenameProvider
    {
        public JetBrains.ReSharper.Psi.IDeclaredElement GetPrimaryDeclaredElement(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.CSharp.CSharpLanguage))]
    public class CSharpRenameHelper : JetBrains.ReSharper.Refactorings.Rename.RenameHelperBase
    {
        public override bool IsLanguageSupported { get; }
        public override void AddExtraNames(JetBrains.ReSharper.Psi.Naming.Extentions.INamesCollection suggestion, JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
        public override System.Collections.Generic.IList<JetBrains.ReSharper.Refactorings.Conflicts.IConflictSearcher> AdditionalConflictsSearchers(JetBrains.ReSharper.Psi.IDeclaredElement element, string newName) { }
        public override void AdditionalReferenceProcessing(JetBrains.ReSharper.Psi.IDeclaredElement newTarget, JetBrains.ReSharper.Psi.Resolve.IReference reference, System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.Resolve.IReference> newReferences) { }
        public override JetBrains.ReSharper.Psi.Resolve.IReference BindReferenceToNamespace(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.INamespace ns) { }
        public override bool DoNotProcess(JetBrains.ReSharper.Psi.IDeclaredElement element) { }
        public override bool DoNotProcessReference(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Resolve.IReference> GetCustomUsages(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
        public override JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage GetPageBeforeInitial(JetBrains.ReSharper.Refactorings.Rename.RenameWorkflow renameWorkflow) { }
        public override JetBrains.ReSharper.Psi.DeclaredElementInstance GetSubst(JetBrains.ReSharper.Psi.IDeclaredElement element) { }
        public override JetBrains.Util.OneToSetMap<JetBrains.ReSharper.Psi.Pointers.IDeclaredElementPointer<JetBrains.ReSharper.Psi.IDeclaredElement>, JetBrains.ReSharper.Psi.IReferencePointer> GetSuspiciousReferences(JetBrains.ReSharper.Psi.IDeclaredElement element) { }
        public override bool IsAlias(JetBrains.ReSharper.Psi.IDeclaredElement element) { }
        public override bool IsLocalRename(JetBrains.ReSharper.Psi.IDeclaredElement primevalDeclaredElement) { }
        public override void JoinTransformAnonymous(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public override JetBrains.ReSharper.Psi.Resolve.IReference TransformProjectedInitializer(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
    }
    [JetBrains.ReSharper.Psi.ShellFeaturePartAttribute()]
    public class CSharpSpecificElementsRenamesFactory : JetBrains.ReSharper.Refactorings.Rename.AtomicRenamesFactory
    {
        public override JetBrains.ReSharper.Refactorings.RenameModel.RenameAvailabilityCheckResult CheckRenameAvailability(JetBrains.ReSharper.Psi.IDeclaredElement element) { }
        public override bool IsApplicable(JetBrains.ReSharper.Psi.IDeclaredElement element) { }
        public class CSharpRenameAvailabilityCheckResult : JetBrains.ReSharper.Refactorings.RenameModel.RenameAvailabilityCheckResult
        {
            public static readonly JetBrains.ReSharper.Refactorings.CSharp.Rename.CSharpSpecificElementsRenamesFactory.CSharpRenameAvailabilityCheckResult IsAccessor;
            public static readonly JetBrains.ReSharper.Refactorings.CSharp.Rename.CSharpSpecificElementsRenamesFactory.CSharpRenameAvailabilityCheckResult IsIndexer;
        }
    }
    [JetBrains.ReSharper.Refactorings.Rename.DerivedRenamesEvaluatorAttribute()]
    public class EventRenameEvaluator : JetBrains.ReSharper.Refactorings.Rename.IDerivedRenamesEvaluator
    {
        public bool SuggestedElementsHaveDerivedName { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IDeclaredElement> CreateFromElement(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IDeclaredElement> CreateFromReference(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
    }
    [JetBrains.ReSharper.Refactorings.Rename.DerivedRenamesEvaluatorAttribute()]
    public class FieldDerivedRenames : JetBrains.ReSharper.Refactorings.Rename.IDerivedRenamesEvaluator
    {
        public bool SuggestedElementsHaveDerivedName { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IDeclaredElement> CreateFromElement(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IDeclaredElement> CreateFromReference(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
    }
    [JetBrains.ReSharper.Refactorings.Rename.DerivedRenamesEvaluatorAttribute()]
    public class PropertyDerivedRenameEvaluator : JetBrains.ReSharper.Refactorings.Rename.IDerivedRenamesEvaluator
    {
        public bool SuggestedElementsHaveDerivedName { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IDeclaredElement> CreateFromElement(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IDeclaredElement> CreateFromReference(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
    }
}
namespace JetBrains.ReSharper.Refactorings.CSharp.Rename.Impl
{
    
    public class CSharpAnonymousTypePropertyAtomicRename : JetBrains.ReSharper.Refactorings.RenameModel.AnonymousTypePropertyAtomicRenameBase
    {
        public CSharpAnonymousTypePropertyAtomicRename(JetBrains.ReSharper.Psi.IDeclaredElement originalElement, string newName) { }
        protected override int CompareReferencesOnMemberDeclarations(JetBrains.ReSharper.Psi.Resolve.IReference r1, JetBrains.ReSharper.Psi.Resolve.IReference r2) { }
        protected override JetBrains.ReSharper.Psi.IDeclaredElement SetName(JetBrains.ReSharper.Psi.IDeclaredElement element, string name) { }
    }
    [JetBrains.ReSharper.Refactorings.Rename.RenamePartAttribute()]
    public class CSharpRenameSuspiciousNamesService : JetBrains.ReSharper.Refactorings.Rename.IRenameSuspiciousNamesService
    {
        public string[] GetPossibleReferenceNames(JetBrains.ReSharper.Psi.IDeclaredElement element, string newName) { }
    }
}
namespace JetBrains.ReSharper.Refactorings.CSharp.SafeDeleteFolder
{
    
    public class CSharpSafeDeleteFolderHelper : JetBrains.ReSharper.Refactorings.SafeDeleteFolder.SafeDeleteFolderHelperBase
    {
        public override bool IsLanguageSupported { get; }
        public override System.Collections.Generic.IList<JetBrains.ReSharper.Psi.IDeclaredElement> GetExternalDeclaredElements(JetBrains.ReSharper.Psi.Tree.IFile file) { }
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Tree.ITreeNode> GetUsingsFromFile(JetBrains.ReSharper.Psi.Tree.IFile file, System.Collections.Generic.IList<JetBrains.ReSharper.Psi.INamespace> namespaces) { }
        public override void RemoveUsing(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
    }
}
namespace JetBrains.ReSharper.Refactorings.CSharp.SafeDeleteTheSecond
{
    
    public class CSharpSafeDelete : JetBrains.ReSharper.Refactorings.SafeDeleteTheSecond.SafeDeleteBase
    {
        public CSharpSafeDelete(JetBrains.ReSharper.Refactorings.SafeDeleteTheSecond.SafeDeleteWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public override System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Tree.IArgument> GetArgumentsToRemove(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.IParametersOwner owner, JetBrains.ReSharper.Psi.IParameter parameter) { }
        public override bool IsExtensionCall(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public override bool IsMethodGroup(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public override bool IsPartial(JetBrains.ReSharper.Psi.IMethod method) { }
        public override bool IsReferenceOnConstructor(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public override bool IsSingleAndCallsToBase(JetBrains.ReSharper.Psi.IConstructor constructor) { }
        public override void MakeVirtual(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration) { }
        public override void RemoveArgument(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Refactorings.SafeDeleteTheSecond.Removers.ArgumentRemover remover, JetBrains.ReSharper.Refactorings.SafeDeleteTheSecond.Removers.ArgumentRemover.PerReferenceData data) { }
        public override bool RemoveCallToBaseMethod(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public override void RemoveDeclaration(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration) { }
        public override bool RemoveExpression(JetBrains.ReSharper.Psi.Tree.IExpression expression) { }
        public override bool RemoveInvocationStatement(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public override void RemoveNewRedundantUsings(JetBrains.ReSharper.Psi.Tree.IFile file, System.Collections.Generic.JetHashSet<JetBrains.ReSharper.Psi.Tree.ITreeNode> oldUsings, JetBrains.Application.Progress.SubProgressIndicator pi) { }
        public override bool RemoveSubscription(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public override void RemoveTypeParameterDeclaration(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration) { }
        public override bool ReplaceExplicitImplementation(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public override void ReplaceExplicitImplementation(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration) { }
        public override void SaveUnusedUsings(JetBrains.ReSharper.Psi.Tree.IFile file) { }
        public override void SetBaseTypes(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.IDeclaredType baseClass, System.Collections.Generic.IList<JetBrains.ReSharper.Psi.IDeclaredType> allSuperTypes, JetBrains.ReSharper.Psi.ITypeElement baseElementToRemove) { }
        public override void TryRemoveNullChecking(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration) { }
    }
    public class CSharpSafeDeleteHelper : JetBrains.ReSharper.Refactorings.SafeDeleteTheSecond.SafeDeleteHelperUnsupported
    {
        public override bool IsLanguageSupported { get; }
        public override bool CanBeRemoved(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration) { }
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Tree.ITreeNode> GetUsingsFromFile(JetBrains.ReSharper.Psi.Tree.IFile file, System.Collections.Generic.IList<JetBrains.ReSharper.Psi.INamespace> namespaces) { }
        public override bool IsBaseClassSpecifier(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public override bool IsInterfaceImplementationSpecifier(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public override void RemoveUsing(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
    }
}
namespace JetBrains.ReSharper.Refactorings.CSharp.src.ExtractMethod2.Common
{
    
    public class ParametersCheckList : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector
    {
        public ParametersCheckList() { }
        public void InitializeComponent() { }
    }
}
namespace JetBrains.ReSharper.Refactorings.CSharp.Static2Extension
{
    
    public class CsStatic2Extension : JetBrains.ReSharper.Refactorings.Static2Extension.Static2ExtensionBase
    {
        public CsStatic2Extension(JetBrains.ReSharper.Refactorings.Static2Extension.Static2ExtensionWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public override void MakeCallExtension(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public override void MakeCallPlainStatic(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
    }
}
namespace JetBrains.ReSharper.Refactorings.CSharp.TransformOutParameters
{
    
    public class CSharpTransformOutParametersHelper : JetBrains.ReSharper.Refactorings.TransformOutParameters.TransformOutParametersHelper
    {
        public const string TUPLE_METHOD_CREATE = "Create";
        public const string TUPLE_METHOD_ITEM = "Item";
        public CSharpTransformOutParametersHelper(JetBrains.ReSharper.Refactorings.TransformOutParameters.TransformOutParametersWorkflow workflow) { }
        public override bool IsLanguageSupported { get; }
        protected override System.Windows.Documents.Run CreateTypeElementRun(string name, JetBrains.ReSharper.Refactorings.TransformOutParameters.HighlightingParameters highlighting) { }
        public override JetBrains.ReSharper.Psi.IMethod GetIMethodForOutParamByNode([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode node) { }
        protected override string GetLineCommentPrefix() { }
        public override System.Collections.Generic.List<object> GetViewModel(JetBrains.ReSharper.Psi.IMethod method, JetBrains.ReSharper.Refactorings.TransformOutParameters.HighlightingParameters highlighting, System.Func<JetBrains.ReSharper.Psi.IParameter, object, object> parameterViewModelTransformer, bool isModelForTransformedMethod) { }
        public override System.Windows.Controls.TextBlock GetViewModel(JetBrains.ReSharper.Psi.IParameter param, JetBrains.ReSharper.Refactorings.TransformOutParameters.HighlightingParameters highlighting, string punctuationSuffix = null) { }
        public override System.Windows.UIElement GetViewModelAfterParameters(JetBrains.ReSharper.Psi.IMethod method, JetBrains.ReSharper.Refactorings.TransformOutParameters.HighlightingParameters highlighting) { }
        public override System.Windows.UIElement GetViewModelBeforeParameters(JetBrains.ReSharper.Psi.IMethod method, JetBrains.ReSharper.Refactorings.TransformOutParameters.HighlightingParameters highlighting) { }
        public override bool IsOutParameter(JetBrains.ReSharper.Psi.IParameter parameter) { }
        public override void JoinDeclarationsAndAssignments([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Tree.IDeclaration method, [JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.Tree.IStatement> statementsToUse, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Refactorings.TransformOutParameters.TransformOutParametersRefactoring transformOutParametersRefactoring) { }
        public override void RefactoringPostVerificationStage(JetBrains.ReSharper.Psi.IMethod method, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Refactorings.TransformOutParameters.TransformOutParametersRefactoring refactoring) { }
        public override void TransformDeclaration(JetBrains.ReSharper.Psi.IMethod method, JetBrains.ReSharper.Psi.Tree.IDeclaration declaration, JetBrains.ReSharper.Refactorings.TransformOutParameters.TransformOutParametersRefactoring refactoring) { }
        public override void TransformReference([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.IType initialReturnType, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Refactorings.TransformOutParameters.TransformOutParametersRefactoring refactoring) { }
    }
}
namespace JetBrains.ReSharper.Refactorings.CSharp.UseBaseType
{
    
    public class CsConstraintSearcherUtil : JetBrains.ReSharper.Refactorings.UseBaseType.ConstraintSearch.ConstraintSearcherUtil
    {
        public CsConstraintSearcherUtil(JetBrains.ReSharper.Refactorings.UseBaseType.UseBaseTypeRefactoring executer) { }
        public override JetBrains.ReSharper.Psi.Tree.ITreeNode GetDirectlyUsedElement(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public override void ProcessUp(JetBrains.ReSharper.Psi.Tree.ITreeNode directlyUsedElement, JetBrains.ReSharper.Refactorings.UseBaseType.TypeUsageSearch.TypeElementUsage usage) { }
        public void ProcessUsagesOfLocalVariable(JetBrains.ReSharper.Psi.ILocalVariable localVariable, JetBrains.ReSharper.Refactorings.UseBaseType.TypeUsageSearch.TypeElementUsage usage) { }
        public override bool TryFindArgumentConstraint(JetBrains.ReSharper.Psi.Tree.ITreeNode preparedElement, out JetBrains.ReSharper.Psi.IParameter parameter) { }
        public override bool TryFindAssignmentConstraint(JetBrains.ReSharper.Psi.Tree.ITreeNode preparedElement, out JetBrains.ReSharper.Psi.IDeclaredElement assignmentDest) { }
        public override bool TryFindExtensionMethodConstraint(JetBrains.ReSharper.Psi.Tree.ITreeNode treeNode, out JetBrains.ReSharper.Psi.IParameter extensionParameter) { }
        public override bool TryFindInitializerConstraint(JetBrains.ReSharper.Psi.Tree.ITreeNode preparedElement, out JetBrains.ReSharper.Psi.IDeclaredElement initializedElement) { }
        public override bool TryFindSimpleReturnConstraint(JetBrains.ReSharper.Psi.Tree.ITreeNode preparedElement, out JetBrains.ReSharper.Psi.ITypeMember returnFromMember) { }
        public override bool TryFindTypeMemberConstraint(JetBrains.ReSharper.Psi.Tree.ITreeNode preparedElement, out JetBrains.ReSharper.Psi.ITypeMember memberCalled, out JetBrains.ReSharper.Psi.Tree.ExpressionAccessType memberAccessType) { }
    }
    public class CsTypeUsageSearcherUtil : JetBrains.ReSharper.Refactorings.UseBaseType.TypeUsageSearch.TypeUsageSearcherUtil
    {
        public override int GetArrayRank(JetBrains.ReSharper.Psi.Tree.ITreeNode typUsageElement) { }
        public override bool TryFindChilidTypeElement(JetBrains.ReSharper.Psi.Resolve.IReference reference, out JetBrains.ReSharper.Psi.ITypeElement childTypeElement) { }
        public override bool TryFindConstrainedParameter(JetBrains.ReSharper.Psi.Resolve.IReference reference, out JetBrains.ReSharper.Psi.ITypeParameter parameter) { }
        public override bool TryFindDelegateDeclaration(JetBrains.ReSharper.Psi.Resolve.IReference reference, out JetBrains.ReSharper.Psi.ITypeElement delegateElement) { }
        public override bool TryFindTypeParameterOwner(JetBrains.ReSharper.Psi.Resolve.IReference reference, out JetBrains.ReSharper.Psi.Tree.ITreeNode typeUsageElement, out JetBrains.ReSharper.Psi.ITypeParameter parameter) { }
    }
    public class CsUseBaseType : JetBrains.ReSharper.Refactorings.UseBaseType.UseBaseTypeBase
    {
        public CsUseBaseType(JetBrains.ReSharper.Refactorings.UseBaseType.UseBaseTypeWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public override bool MethodGroupTypeMatch { get; }
        public override JetBrains.ReSharper.Psi.Resolve.IReference BindUsage(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public override bool CheckConstraintElement(JetBrains.ReSharper.Psi.IDeclaredElement element) { }
        public override void CreateAnonymousDelegateDependency(JetBrains.ReSharper.Psi.IParametersOwner owner, JetBrains.ReSharper.Refactorings.UseBaseType.Dependences.Node node, int index, out JetBrains.ReSharper.Psi.IParameter delegateParameter) { }
        public override bool GetCastExpressionExpression(JetBrains.ReSharper.Psi.Resolve.IReference reference, out JetBrains.ReSharper.Psi.Tree.IExpression expression) { }
        public override JetBrains.ReSharper.Refactorings.UseBaseType.ConstraintSearch.ConstraintSearcherUtil GetConstraintSearcherUtil() { }
        public override bool GetConstructedExpression(JetBrains.ReSharper.Psi.Resolve.IReference reference, out JetBrains.ReSharper.Psi.Tree.IExpression expression) { }
        public override JetBrains.ReSharper.Psi.IDeclaredElement[] GetDeclaredElements(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public override JetBrains.ReSharper.Psi.IDeclaredElement GetDelegateDeclaration(JetBrains.ReSharper.Psi.Tree.ITreeNode directlyUsedElement) { }
        public override bool GetIsExpression(JetBrains.ReSharper.Psi.Resolve.IReference reference, out JetBrains.ReSharper.Psi.Tree.IExpression expression) { }
        public override bool GetTypeOfExpression(JetBrains.ReSharper.Psi.Resolve.IReference reference, out JetBrains.ReSharper.Psi.Tree.IExpression expression) { }
        public override JetBrains.ReSharper.Refactorings.UseBaseType.TypeUsageSearch.TypeUsageSearcherUtil GetTypeUsageSearcherUtil() { }
    }
}
namespace JetBrains.ReSharper.Refactorings.CSharp.Util
{
    
    public class ClassLikeDeclarationReplacer
    {
        public static JetBrains.ReSharper.Refactorings.CSharp.Util.ClassLikeDeclarationReplacer.ITag Replace(JetBrains.ReSharper.Psi.CSharp.Tree.IClassLikeDeclaration decl, JetBrains.ReSharper.Psi.CSharp.Tree.IClassLikeDeclaration newDecl, JetBrains.ReSharper.Refactorings.CSharp.Util.ReplaceActions action) { }
        public abstract class ITag : System.IDisposable
        {
            protected JetBrains.ReSharper.Psi.CSharp.Tree.IClassLikeDeclaration myNewDecl;
            protected JetBrains.ReSharper.Psi.CSharp.Tree.IClassLikeDeclaration myOldDecl;
            protected ITag(JetBrains.ReSharper.Psi.CSharp.Tree.IClassLikeDeclaration oldDecl, JetBrains.ReSharper.Psi.CSharp.Tree.IClassLikeDeclaration newDecl, JetBrains.ReSharper.Refactorings.CSharp.Util.ReplaceActions action) { }
            public JetBrains.ReSharper.Refactorings.CSharp.Util.ReplaceActions Action { get; }
            public JetBrains.ReSharper.Psi.CSharp.Tree.IClassLikeDeclaration NewDecl { get; }
            public abstract void Dispose();
        }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.CSharp.CSharpLanguage))]
    public class CsConstructionUtil : JetBrains.ReSharper.Refactorings.Util.ConstructionUtil
    {
        public override JetBrains.ReSharper.Psi.ITypeElement AddClassBefore(string className, JetBrains.ReSharper.Psi.Tree.IDeclaration tag, bool topLevel, bool isClass) { }
        public override JetBrains.ReSharper.Psi.ITypeElement AddClassBeforeFromMember(string className, JetBrains.ReSharper.Psi.ITypeMember tag, bool topLevel, bool isClass) { }
        public override JetBrains.ReSharper.Psi.Tree.IDeclaration AddEmptyConstructor(JetBrains.ReSharper.Psi.ITypeElement @class, JetBrains.ReSharper.Psi.Tree.IDeclaration tag) { }
        public override JetBrains.ReSharper.Psi.Tree.IDeclaration AddField(JetBrains.ReSharper.Psi.ITypeElement @class, JetBrains.ReSharper.Psi.Naming.Impl.NameRoot name, JetBrains.ReSharper.Psi.IType type, JetBrains.ReSharper.Psi.Tree.IDeclaration tag, JetBrains.ReSharper.Psi.AccessRights accessRights, System.Collections.Generic.JetHashSet<string> namesSet) { }
        public override JetBrains.ReSharper.Psi.IParameter AddFirstParameter(JetBrains.ReSharper.Psi.IParametersOwner owner, string name, JetBrains.ReSharper.Psi.IDeclaredType type) { }
        public override JetBrains.ReSharper.Psi.IParameter AddLastParameter(JetBrains.ReSharper.Psi.IParametersOwner owner, string name, JetBrains.ReSharper.Psi.IDeclaredType type) { }
        public override JetBrains.ReSharper.Psi.Tree.IDeclaration AddProperty(JetBrains.ReSharper.Psi.ITypeElement @class, JetBrains.ReSharper.Psi.Tree.IDeclaration fieldDeclaration, JetBrains.ReSharper.Psi.Naming.Impl.NameRoot basicName, JetBrains.ReSharper.Psi.Tree.IDeclaration tag, bool isWritable, JetBrains.ReSharper.Psi.AccessRights accessRights, System.Collections.Generic.JetHashSet<string> namesSet) { }
        protected override void AddToCollection(System.Collections.Generic.JetHashSet<string> namesSet, string fieldName) { }
        public override JetBrains.ReSharper.Psi.ITypeMember AddTypeMemberDeclaration(JetBrains.ReSharper.Psi.ITypeElement element, JetBrains.ReSharper.Psi.Tree.IDeclaration declaration, JetBrains.ReSharper.Psi.Tree.IDeclaration tag, bool after) { }
        public override JetBrains.ReSharper.Psi.Tree.IDeclaration AddTypeParameter(JetBrains.ReSharper.Psi.ITypeElement @class, string name, JetBrains.ReSharper.Psi.ITypeParameter originalTypeParameter) { }
        public override JetBrains.ReSharper.Psi.ITypeParameter AddTypeParameter(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration, string shortname) { }
        public override void InitFieldInConstructor(JetBrains.ReSharper.Psi.Tree.IDeclaration constructorDecl, JetBrains.ReSharper.Psi.Tree.IDeclaration fieldDecl, JetBrains.ReSharper.Psi.IParameter parameter) { }
        protected override bool IsInCollection(System.Collections.Generic.JetHashSet<string> namesSet, string fieldName) { }
        public override void MakeFirstPrameterThis(JetBrains.ReSharper.Psi.IMethod method, bool addThis, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver Driver) { }
        public override void RemoveParameter(JetBrains.ReSharper.Psi.IParametersOwner owner, JetBrains.ReSharper.Psi.IParameter parameter) { }
        public override void RemoveTypeMember(JetBrains.ReSharper.Psi.Tree.ITypeMemberDeclaration member) { }
        public override void SetAccessRights(JetBrains.ReSharper.Psi.IDeclaredElement owner, JetBrains.ReSharper.Psi.AccessRights rights) { }
        public override bool TryProcessMultyFieldForResolve(JetBrains.ReSharper.Psi.IRecursiveElementProcessor processor, JetBrains.ReSharper.Psi.Tree.IDeclaration declaration) { }
        public static bool TryProcessMultyFieldForResolve(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration, JetBrains.ReSharper.Psi.IRecursiveElementProcessor collector) { }
    }
    public class CSharpAbstractor
    {
        public CSharpAbstractor([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Refactorings.MoveMembers.Common.IMoveMembersExecuter executer, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Modules.IPsiModule project) { }
        public T MakeDeclaration<T>(JetBrains.ReSharper.Psi.Tree.IDeclaration initialDecl, bool abstr)
            where T :  class, JetBrains.ReSharper.Psi.Tree.IDeclaration { }
        public T MakeDeclaration<T>(JetBrains.ReSharper.Psi.IDeclaredElement element, bool abstr)
            where T :  class, JetBrains.ReSharper.Psi.Tree.IDeclaration { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.CSharp.CSharpLanguage))]
    public class CSharpExpressionTypeSuggestion : JetBrains.ReSharper.Feature.Services.TypeSuggestion.ExpressionTypeSuggestionBase
    {
        public override JetBrains.ReSharper.Feature.Services.TypeSuggestion.SuggestedTypeKinds GetTypeKind(JetBrains.ReSharper.Psi.Tree.IExpression expression) { }
    }
    public class static CSharpPsiUtil
    {
        public static JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpNamespaceDeclaration CreateNamespaceDeclaration([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpFile file, string name, JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpNamespaceDeclaration anchor) { }
        public static JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpExpression GetInitializerExpression(JetBrains.ReSharper.Psi.CSharp.Tree.ILocalVariableDeclaration variableDeclaration) { }
        public static void RemoveDeclaration(JetBrains.ReSharper.Psi.CSharp.Tree.ILocalVariableDeclaration variableDeclaration, JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpExpression referenceExpression) { }
        public static void RemoveDeclaration(JetBrains.ReSharper.Psi.CSharp.Tree.ILocalConstantDeclaration constantDecl) { }
        public static JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpExpression TransformComplexAssignment(JetBrains.ReSharper.Psi.CSharp.Tree.IAssignmentExpression assignmentExpression, JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpExpression operand) { }
        public static JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpExpression TransformPostfixExpression(JetBrains.ReSharper.Psi.CSharp.Tree.IPostfixOperatorExpression postfixOperatorExpression, JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpExpression operand) { }
        public static JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpExpression TransformPrefixExpression(JetBrains.ReSharper.Psi.CSharp.Tree.IPrefixOperatorExpression prefixOperatorExpression, JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpExpression operand) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.CSharp.CSharpLanguage))]
    public class CSharpRefactoringDataConstantsService : JetBrains.ReSharper.Refactorings.ExtensionsApi.IRefactoringDataConstantsService
    {
        public bool IsNameNodeSelected(JetBrains.ReSharper.Psi.Tree.ITreeNode node, JetBrains.DocumentModel.DocumentRange documentRange) { }
    }
    public class static CSharpUnusedUsingsUtil
    {
        public static void AddFileToUsingSaver(JetBrains.ReSharper.Refactorings.Move.Common.UnusedUsingSaver saver, JetBrains.ReSharper.Psi.Tree.IFile file) { }
        public static void RemoveNewUsusedUsings(JetBrains.ReSharper.Psi.Tree.IFile file, System.Collections.Generic.JetHashSet<JetBrains.ReSharper.Psi.Tree.ITreeNode> oldUnusedUsings) { }
    }
    public class MethodGroupTransformer
    {
        public static JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpExpression ReplaceMethodGroupWithAnonymousFunction(JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpExpression referenceExpression, System.Collections.Generic.List<string> parameterNames, System.Collections.Generic.List<JetBrains.ReSharper.Psi.IType> parameterTypes, string parameterNameToRemove, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution) { }
    }
    public class static QuerySelectionUtil
    {
        public static JetBrains.ReSharper.Refactorings.CSharp.IntroduceVariable.SubQuerySelection GetSelectedExpression(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
    }
    public abstract class RDInspectorOfVariable<TInspectorContext> : JetBrains.ReSharper.Psi.ControlFlow.Impl.ControlFlowGrafInspector<TInspectorContext>
        where TInspectorContext :  class, JetBrains.ReSharper.Refactorings.InlineVar.RDAnalysis.IRDInspectorOfVariableContext
    {
        protected RDInspectorOfVariable(JetBrains.ReSharper.Psi.ControlFlow.Impl.ControlFlowGraf controlFlowGraf, JetBrains.ReSharper.Psi.ITypeOwner element, JetBrains.ReSharper.Psi.ControlFlow.IControlFlowContextFactory<TInspectorContext> factory) { }
        protected abstract bool CustomInspection(JetBrains.ReSharper.Psi.ControlFlow.IControlFlowElement controlFlowElement, TInspectorContext context, JetBrains.ReSharper.Psi.Tree.ITreeNode element);
        protected override void InspectLeafElementAndSetContextToExits(JetBrains.ReSharper.Psi.ControlFlow.IControlFlowElement controlFlowElement, TInspectorContext context) { }
    }
    public enum ReplaceActions
    {
        Replace = 0,
        PlaceBefore = 1,
        PlaceAfter = 2,
    }
}