[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]

namespace JetBrains.ReSharper.Refactorings.VB.AdjustNamespaces
{
    
    public class VBAdjustNamespaceHelper : JetBrains.ReSharper.Refactorings.Move.AdjustNamespaces.AdjustNamespacesHelperBase
    {
        public override bool IsLanguageSupported { get; }
        public override bool FileHasProblems(JetBrains.ReSharper.Psi.Tree.IFile file, string expectedNamespace) { }
        public override void FixFile(JetBrains.ReSharper.Psi.Tree.IFile file, string expectedNamespaceName, JetBrains.ReSharper.Refactorings.Util.NewTypeImages.ResolveImagesRepository repository, System.Collections.Generic.List<JetBrains.ReSharper.Psi.IDeclaredElement> elements) { }
        public override JetBrains.ReSharper.Psi.IDeclaredElement GetImportedSymbolOfUsing(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public override System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Tree.ITypeDeclaration> GetTopLevelTypeDeclarations(JetBrains.ReSharper.Psi.Tree.IFile file) { }
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Tree.ITreeNode> GetUsingsFromFile(JetBrains.ReSharper.Psi.Tree.IFile file, System.Collections.Generic.IList<JetBrains.ReSharper.Psi.INamespace> namespaces) { }
        public override bool IsExternallyVisibleSymbol(JetBrains.ReSharper.Psi.IDeclaredElement element) { }
        public override bool IsFromExtendsList(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public override bool IsReferenceName(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public override void RemoveUnusedUsing(JetBrains.ReSharper.Psi.Tree.IFile file, System.Collections.Generic.JetHashSet<JetBrains.ReSharper.Psi.Tree.ITreeNode> usings) { }
        public override void RemoveUsing(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public override void SaveUnusedUsings(JetBrains.ReSharper.Psi.Tree.IFile file, JetBrains.ReSharper.Refactorings.Move.Common.UnusedUsingSaver saver) { }
    }
    public class VBMoveIntoMatchingFilesHelper : JetBrains.ReSharper.Refactorings.Move.MoveIntoMatchingFile.MoveIntoMatchingFilesHelperBase
    {
        public override bool IsLanguageSupported { get; }
        public override JetBrains.ReSharper.Psi.Tree.INamespaceDeclaration GetOwnerNamespaceDeclaration(JetBrains.ReSharper.Psi.Tree.ITypeDeclaration typeDeclaration) { }
        public override System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Tree.ITypeDeclaration> GetTopLevelTypeDeclarations(JetBrains.ReSharper.Psi.Tree.IFile file) { }
        public override bool IsExternallyVisibleSymbol(JetBrains.ReSharper.Psi.IDeclaredElement element) { }
        public override bool IsFromExtendsList(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public override bool IsReferenceName(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public override void MoveDeclarationFromFile(JetBrains.ReSharper.Refactorings.Move.MoveIntoMatchingFile.Impl.MovedDeclaration declaration, JetBrains.ReSharper.Refactorings.Util.NewTypeImages.ResolveImagesRepository repository) { }
        public override void RemoveUnusedUsing(JetBrains.ReSharper.Psi.Tree.IFile file, System.Collections.Generic.JetHashSet<JetBrains.ReSharper.Psi.Tree.ITreeNode> usings) { }
        public override void SaveUnusedUsings(JetBrains.ReSharper.Psi.Tree.IFile file, JetBrains.ReSharper.Refactorings.Move.Common.UnusedUsingSaver saver) { }
    }
    public class VBMoveToFileHelper : JetBrains.ReSharper.Refactorings.Move.MoveTypeDeclarationToFile.MoveToFileHelperBase
    {
        public override bool IsLanguageSupported { get; }
        public override bool FileHasOtherDeclarations(JetBrains.ReSharper.Psi.Tree.ITypeDeclaration declaration) { }
        public override bool IsExternallyVisibleSymbol(JetBrains.ReSharper.Psi.IDeclaredElement element) { }
        public override bool IsFromExtendsList(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public override bool IsReferenceName(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public override bool MoveDeclaration(JetBrains.ReSharper.Psi.Tree.ITypeDeclaration declaration, JetBrains.ReSharper.Refactorings.Util.NewTypeImages.ResolveImagesRepository repository, JetBrains.ReSharper.Psi.Tree.IFile file, JetBrains.ReSharper.Refactorings.Move.MoveTypeDeclarationToFile.MoveToFileWorkflow workflow) { }
        public override void RemoveUnusedUsing(JetBrains.ReSharper.Psi.Tree.IFile file, System.Collections.Generic.JetHashSet<JetBrains.ReSharper.Psi.Tree.ITreeNode> usings) { }
        public override void SaveUnusedUsings(JetBrains.ReSharper.Psi.Tree.IFile file, JetBrains.ReSharper.Refactorings.Move.Common.UnusedUsingSaver saver) { }
    }
    public class VBMoveToFolderHelper : JetBrains.ReSharper.Refactorings.Move.MoveToFolder.MoveToFolderHelperBase
    {
        public override bool CanMoveSingleTypeDeclaration { get; }
        public override bool IsLanguageSupported { get; }
        public override bool DeclarationCanProvideName(JetBrains.ReSharper.Psi.Tree.ITypeDeclaration declaration) { }
        public override System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Tree.ITypeDeclaration> GetTopLevelTypeDeclarations(JetBrains.ReSharper.Psi.Tree.IFile file) { }
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Tree.ITreeNode> GetUsingsFromFile(JetBrains.ReSharper.Psi.Tree.IFile file, System.Collections.Generic.IList<JetBrains.ReSharper.Psi.INamespace> namespaces) { }
        public override bool IsExternallyVisibleSymbol(JetBrains.ReSharper.Psi.IDeclaredElement element) { }
        public override bool IsFromExtendsList(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public override bool IsReferenceName(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public override void MakePublic(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration) { }
        public override bool MoveFewDeclarations(JetBrains.ReSharper.Psi.Tree.IFile sourceFile, JetBrains.ReSharper.Psi.Tree.IFile targetFile, bool fixNamespaces, string expectedNamespaceName, JetBrains.ReSharper.Refactorings.Util.NewTypeImages.ResolveImagesRepository repository, System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Tree.ITypeDeclaration> children) { }
        public override bool MoveSingleDeclaration(JetBrains.ReSharper.Psi.Tree.ITypeDeclaration typeDeclaration, JetBrains.ReSharper.Psi.Tree.IFile targetFile, string expectedNamespaceName, JetBrains.ReSharper.Refactorings.Util.NewTypeImages.ResolveImagesRepository repository) { }
        public override bool MoveWholeFile(JetBrains.ReSharper.Psi.Tree.IFile sourceFile, JetBrains.ReSharper.Psi.Tree.IFile targetFile, bool fixNamespaces, string expectedNamespaceName, JetBrains.ReSharper.Refactorings.Util.NewTypeImages.ResolveImagesRepository repository) { }
        public override void RemoveUnusedUsing(JetBrains.ReSharper.Psi.Tree.IFile file, System.Collections.Generic.JetHashSet<JetBrains.ReSharper.Psi.Tree.ITreeNode> usings) { }
        public override void RemoveUsing(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public override void SaveUnusedUsings(JetBrains.ReSharper.Psi.Tree.IFile file, JetBrains.ReSharper.Refactorings.Move.Common.UnusedUsingSaver saver) { }
    }
    public class VBMoveToNamespaceHelper : JetBrains.ReSharper.Refactorings.Move.MoveToNamespace.MoveToNamespaceHelperBase
    {
        public override bool IsLanguageSupported { get; }
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Tree.ITreeNode> GetUsingsFromFile(JetBrains.ReSharper.Psi.Tree.IFile file, System.Collections.Generic.IList<JetBrains.ReSharper.Psi.INamespace> namespaces) { }
        public override bool IsExternallyVisibleSymbol(JetBrains.ReSharper.Psi.IDeclaredElement element) { }
        public override bool IsFromExtendsList(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public override bool IsReferenceName(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public override void MovePrimaryDeclaration(JetBrains.ReSharper.Psi.Tree.ITypeDeclaration typeDeclaration, string newNamespaceName, JetBrains.ReSharper.Refactorings.Util.NewTypeImages.ResolveImagesRepository repository) { }
        public override void RemoveUnusedUsing(JetBrains.ReSharper.Psi.Tree.IFile file, System.Collections.Generic.JetHashSet<JetBrains.ReSharper.Psi.Tree.ITreeNode> usings) { }
        public override void RemoveUsing(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public override void SaveUnusedUsings(JetBrains.ReSharper.Psi.Tree.IFile file, JetBrains.ReSharper.Refactorings.Move.Common.UnusedUsingSaver saver) { }
        public override string ValidateNamespaceName(string newNamespace, JetBrains.ReSharper.Psi.Tree.IDeclaration declaration) { }
    }
    public class VBMoveUtil
    {
        public static JetBrains.ReSharper.Psi.VB.Tree.IVBFile CopyFileAndFixNamespaces(JetBrains.ReSharper.Psi.VB.Tree.IVBFile newFile, JetBrains.ReSharper.Psi.VB.Tree.IVBFile oldFile, string expectedNamespaceName, System.Collections.Generic.IList<JetBrains.ReSharper.Psi.IDeclaredElement> importedNamespaces) { }
        public static string GetNamespaceName(string namespaceName, string defaultNamespaceName) { }
        public static System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Tree.ITypeDeclaration> GetTopLevelTypeDeclarations(JetBrains.ReSharper.Psi.Tree.IFile file) { }
        public static System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Tree.ITreeNode> GetUsingsFromFile(JetBrains.ReSharper.Psi.Tree.IFile file, System.Collections.Generic.IList<JetBrains.ReSharper.Psi.INamespace> namespaces) { }
        public static bool IsExternallyVisibleSymbol(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
    }
}
namespace JetBrains.ReSharper.Refactorings.VB.ChangeStaticness
{
    
    public class VBMakeStatic : JetBrains.ReSharper.Refactorings.ChangeStaticness.ToStatic.MakeStatic
    {
        public VBMakeStatic(JetBrains.ReSharper.Refactorings.ChangeStaticness.ToStatic.MakeStaticWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public override JetBrains.ReSharper.Refactorings.Inline.InlineHelper InlineHelper { get; }
        public override void AddArgument(JetBrains.ReSharper.Psi.Resolve.IReference reference, string name) { }
        public override void AddArgumentAndBind(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.IOverridableMember member, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution, JetBrains.ReSharper.Psi.DisposableMarker marker) { }
        public override JetBrains.ReSharper.Psi.IParameter AddParameter(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration, JetBrains.ReSharper.Psi.IType type, string name) { }
        public override void BindTo(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.IOverridableMember member, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution) { }
        public override void CallInline(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Refactorings.Inline.CallSiteContext context, JetBrains.ReSharper.Refactorings.Inline.InlinedCallInfo info, System.Collections.Generic.IList<string> lambdaParameterNames) { }
        public override JetBrains.ReSharper.Psi.Resolve.IReference ConvertMethodGroupToLambda(JetBrains.ReSharper.Psi.Resolve.IReference reference, System.Collections.Generic.IList<JetBrains.ReSharper.Psi.IParameter> parameters) { }
        public override void FixOtherArguments(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Refactorings.Inline.InlinedCallInfo info, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution) { }
        public override void Qualify(JetBrains.ReSharper.Psi.Tree.ITreeNode node, JetBrains.ReSharper.Psi.IParameter parameter) { }
        public override int ReferencesToThis(JetBrains.ReSharper.Psi.Tree.IExpression expression) { }
        public override void Replace(JetBrains.ReSharper.Psi.Tree.ITreeNode node, string name) { }
        public override void SetStatic(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration) { }
    }
    public class VBMakeStaticHelper : JetBrains.ReSharper.Refactorings.ChangeStaticness.ToStatic.IMakeStaticHelper
    {
        public bool IsLanguageSupported { get; }
        public bool CheckElement(JetBrains.ReSharper.Psi.IOverridableMember overridableMember) { }
        public JetBrains.ReSharper.Psi.Tree.ITreeNode GetInvocation(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public string GetTitle() { }
        public bool IsThis(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public bool IsWriting(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
    }
}
namespace JetBrains.ReSharper.Refactorings.VB.ClassFromParameters
{
    
    public class VBClassFromParameters : JetBrains.ReSharper.Refactorings.ClassFromParameters.ClassFromParametersBase
    {
        public VBClassFromParameters(JetBrains.ReSharper.Refactorings.ClassFromParameters.ClassFromParametersWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public override void FixUsage(JetBrains.ReSharper.Refactorings.ClassFromParameters.PreProcessedCall call, string name) { }
        public override bool IsPureRecursiveCall(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.IOverridableMember calledMethod, JetBrains.ReSharper.Psi.ITypeElement typeElement) { }
        public override JetBrains.ReSharper.Refactorings.ClassFromParameters.PreProcessedCall PreProcessCall(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public override void Transform(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.IProperty property, JetBrains.ReSharper.Psi.IParameter parameter) { }
    }
}
namespace JetBrains.ReSharper.Refactorings.VB.Constructor2FactoryMethod
{
    
    public class VBConstructor2FactoryMethod : JetBrains.ReSharper.Refactorings.Constructor2FactoryMethod.ConstructorToFactoryMethodBase
    {
        public VBConstructor2FactoryMethod(JetBrains.ReSharper.Refactorings.Constructor2FactoryMethod.Constructor2FactoryMethodWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public override void ConvertUsage(JetBrains.ReSharper.Psi.ITypeMember method, JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public override JetBrains.ReSharper.Psi.ITypeMember CreateFactoryMethodDeclaration(JetBrains.ReSharper.Psi.ITypeElement targetTypeElement, JetBrains.ReSharper.Psi.IConstructor constructorToCall, string factorymethodName) { }
        public override string GetModifiersString(JetBrains.ReSharper.Psi.IParameter x) { }
        public override bool IsBaseConstructorInitializer(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
    }
}
namespace JetBrains.ReSharper.Refactorings.VB.Convert
{
    
    public class InterfaceMembersCollector : JetBrains.ReSharper.Refactorings.Convert.Common.InterfaceMembersCollectorBase
    {
        public InterfaceMembersCollector(bool keepAllExplicitlyImplemented) { }
        public static System.Collections.Generic.IList<JetBrains.ReSharper.Refactorings.Convert.Common.ElementInstancePointer> GetInterfaceMembers(JetBrains.ReSharper.Psi.Tree.ITypeDeclaration typeDeclaration, bool keepAllNotExplicitlyImplemented) { }
        protected override bool IsPrimaryTypeMember(JetBrains.ReSharper.Psi.ITypeMember overridableMember) { }
        protected override void ProcessPrivateImplementations(JetBrains.ReSharper.Psi.IOverridableMember overridableMember, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution, JetBrains.ReSharper.Refactorings.Convert.Common.InterfaceMembersCollectorBase.OverridableMemberInfo overridableMemberInfo, bool processingInheritedMembers) { }
    }
    public class VBConvert : JetBrains.ReSharper.Refactorings.Convert.Common.ConvertTypeBase<JetBrains.ReSharper.Psi.Tree.ITypeMemberDeclaration, JetBrains.ReSharper.Psi.VB.Tree.IClassLikeDeclaration>
    {
        public System.Collections.Generic.Dictionary<JetBrains.ReSharper.Psi.VB.Tree.IClassLikeDeclaration, JetBrains.ReSharper.Psi.VB.Tree.IClassLikeDeclaration> myPartsMap;
        public VBConvert(JetBrains.ReSharper.Refactorings.Convert.Common.IConvertTypeWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public override void AddImplements(JetBrains.ReSharper.Psi.IClass inheritor) { }
        public override void AddImplementsSpecifications() { }
        public override void AddInterface(JetBrains.ReSharper.Psi.ITypeElement typeElement, JetBrains.ReSharper.Psi.IExplicitImplementation interfaceToAdd) { }
        public override void AddInterfaceSpecificationToOverride(JetBrains.ReSharper.Psi.IOverridableMember over, JetBrains.ReSharper.Psi.IClass @class) { }
        protected override void AddSuperInterface(JetBrains.ReSharper.Psi.Tree.ITypeDeclaration newDecl, JetBrains.ReSharper.Psi.IDeclaredType newSuprtType) { }
        protected override bool CanCallMoreGeneric(JetBrains.ReSharper.Psi.OverridableMemberInstance moreGenericInstance, JetBrains.ReSharper.Psi.OverridableMemberInstance lessGenericInstance, JetBrains.ReSharper.Psi.VB.Tree.IClassLikeDeclaration clsss) { }
        public override void CreateClassDeclaration(JetBrains.ReSharper.Psi.IInterface interfccc) { }
        public override void FixImplementsToInherits(JetBrains.ReSharper.Psi.ITypeElement implementor, JetBrains.ReSharper.Psi.IInterface initialInterface) { }
        public override void ImplementsMembersAbstract() { }
        protected override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Tree.ITypeMemberDeclaration> MakeAbstractDeclaration(JetBrains.ReSharper.Psi.VB.Tree.IClassLikeDeclaration classDecl, JetBrains.ReSharper.Refactorings.Convert.Common.ElementInstancePointer pointer, int indexForVB, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IType> lsitOfTypes, bool makePrivate) { }
        protected override void MakeCallMoreGeneric(JetBrains.ReSharper.Psi.VB.Tree.IClassLikeDeclaration classToAddNewDeclaration, JetBrains.ReSharper.Refactorings.Convert.Common.ElementInstancePointer memberCaller, JetBrains.ReSharper.Refactorings.Convert.Common.ElementInstancePointer memberCallee, JetBrains.ReSharper.Psi.IType type) { }
        protected override void MakePrivateImplementation(JetBrains.ReSharper.Refactorings.Convert.Common.ElementInstancePointer pointer, JetBrains.ReSharper.Psi.Tree.ITypeMemberDeclaration newDecl) { }
        public override void MakePublic(JetBrains.ReSharper.Psi.IOverridableMember member) { }
        public override void MakePublicOverride(JetBrains.ReSharper.Psi.IOverridableMember member, JetBrains.ReSharper.Psi.IDeclaredType declTypeToRemove) { }
        public override bool MakeVirtual(JetBrains.ReSharper.Psi.IOverridableMember member) { }
        protected override void Privatizate(JetBrains.ReSharper.Psi.Tree.ITypeMemberDeclaration newDecl) { }
        public override void ProcessOtherMember(JetBrains.ReSharper.Psi.ITypeMember member) { }
        public override bool ProcessOverridableMember(JetBrains.ReSharper.Psi.IOverridableMember overridable, JetBrains.Application.Progress.IProgressIndicator pi) { }
        public override void RemoveDeclaration(JetBrains.ReSharper.Psi.IOverridableMember member) { }
        public override void RemoveInherits(JetBrains.ReSharper.Psi.IClass clsss, JetBrains.ReSharper.Psi.IClass source) { }
        public override void RemoveInterface(JetBrains.ReSharper.Psi.ITypeElement implementor, JetBrains.ReSharper.Psi.IInterface interfaceToRemove) { }
        public override void ReplaceMembers(JetBrains.ReSharper.Psi.IClass clsss) { }
    }
}
namespace JetBrains.ReSharper.Refactorings.VB
{
    
    public class ConvertRefactoringUtil
    {
        public static JetBrains.ReSharper.Refactorings.VB.ConvertRefactoringUtil.Data Analyse(JetBrains.ReSharper.Psi.VB.Tree.IReferenceExpression referenceExpression, JetBrains.ReSharper.Psi.IMethod method, bool isGetter) { }
        public class Data
        {
            public Data(bool isExpanded, JetBrains.ReSharper.Refactorings.VB.ConvertRefactoringUtil.ReferenceKind referencekind, System.Collections.Generic.IList<JetBrains.ReSharper.Psi.VB.Tree.IVBArgument> arguments, JetBrains.ReSharper.Refactorings.VB.ConvertRefactoringUtil.ReplacerDelegate replacer, JetBrains.ReSharper.Psi.VB.Tree.IVBStatement immediateStatement, JetBrains.ReSharper.Psi.VB.Tree.IIndexExpression indexExpr, bool emptyExpanded) { }
            public System.Collections.Generic.IList<JetBrains.ReSharper.Psi.VB.Tree.IVBArgument> Arguments { get; }
            public JetBrains.ReSharper.Psi.VB.Tree.IVBStatement ImmediateStatement { get; }
            public bool IsExpanded { get; }
            public JetBrains.ReSharper.Refactorings.VB.ConvertRefactoringUtil.ReferenceKind Referencekind { get; }
            public JetBrains.ReSharper.Refactorings.VB.ConvertRefactoringUtil.ReplacerDelegate Replacer { get; }
            public bool IsExpandedArg(JetBrains.ReSharper.Psi.VB.Tree.IVBArgument arg) { }
            public bool IsLastArgument(JetBrains.ReSharper.Psi.VB.Tree.IVBArgument argument) { }
        }
        public enum ReferenceKind
        {
            Index = 0,
            Delegating = 1,
            BracketsLessCall = 2,
            ReturnValueIn = 3,
            ReturnValueOut = 4,
        }
        public delegate void ReplacerDelegate(object elementToInsert);
    }
    public class DefaultNamespaceChecker
    {
        public DefaultNamespaceChecker(JetBrains.ReSharper.Psi.VB.Tree.IVBFile file) { }
        public bool Check(string namespaceName) { }
        public static JetBrains.CommonControls.Validation.IValidator CreateValidator(System.Windows.Forms.Control namespaceNameControl, JetBrains.ReSharper.Psi.VB.Tree.IVBFile file) { }
    }
    public class DefaultNamespaceConflict : JetBrains.ReSharper.Refactorings.Conflicts.IConflict
    {
        public DefaultNamespaceConflict(JetBrains.ProjectModel.IProject project) { }
        public string Description { get; }
        public bool IsValid { get; }
        public JetBrains.ReSharper.Refactorings.Conflicts.ConflictSeverity Severity { get; }
    }
    public class VBAnonymousTypeAtomicRename : JetBrains.ReSharper.Refactorings.RenameModel.AnonymousTypePropertyAtomicRenameBase
    {
        public VBAnonymousTypeAtomicRename(JetBrains.ReSharper.Psi.IDeclaredElement originalElement, string newName) { }
        protected override int CompareReferencesOnMemberDeclarations(JetBrains.ReSharper.Psi.Resolve.IReference r1, JetBrains.ReSharper.Psi.Resolve.IReference r2) { }
        protected override JetBrains.ReSharper.Psi.IDeclaredElement SetName(JetBrains.ReSharper.Psi.IDeclaredElement element, string name) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.VB.VBLanguage))]
    public class VBChangeSignature : JetBrains.ReSharper.Refactorings.ChangeSignature.ChangeSignature
    {
        protected override JetBrains.ReSharper.Psi.Tree.IArgument AddArgumentAfter(JetBrains.ReSharper.Psi.Tree.IArgumentsOwner owner, JetBrains.ReSharper.Psi.Tree.IArgument argument, JetBrains.ReSharper.Psi.Tree.IArgument tag, JetBrains.ReSharper.Refactorings.ChangeSignature.ChangeSignatureParameter parameter) { }
        public override JetBrains.ReSharper.Psi.IParametersOwner AddDefaultConstructorDeclaration(JetBrains.ReSharper.Psi.IConstructor defaultConstructor) { }
        public override void BindReferenceExpression(JetBrains.ReSharper.Psi.Tree.IExpression expression, JetBrains.ReSharper.Psi.IDeclaredElement element) { }
        public override void ChangeDeclaration(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration, System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Tree.IDeclaration> parameterDeclarations, JetBrains.ReSharper.Refactorings.ChangeSignature.ChangeSignatureModel changeSignatureModel, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution, System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<JetBrains.ReSharper.Psi.Tree.IArgument, JetBrains.ReSharper.Refactorings.ChangeSignature.ChangeSignatureModel.ArgumentAction>> postActionsList) { }
        protected override void ChangeDefaultConstructor(JetBrains.ReSharper.Psi.IConstructor constructor, JetBrains.ReSharper.Refactorings.ChangeSignature.ChangeSignatureModel model, System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<JetBrains.ReSharper.Psi.Tree.IArgument, JetBrains.ReSharper.Refactorings.ChangeSignature.ChangeSignatureModel.ArgumentAction>> postActions) { }
        public override bool CheckIfMethodGroup(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public override JetBrains.ReSharper.Psi.Tree.IArgument CreateArgument(JetBrains.ReSharper.Psi.Tree.ITreeNode context, bool isInternal, JetBrains.ReSharper.Psi.ParameterKind parameterKind, string parameterName, JetBrains.ReSharper.Refactorings.ChangeSignature.IParameterValue defaultValue, out JetBrains.ReSharper.Refactorings.ChangeSignature.ChangeSignatureModel.ArgumentAction postAction) { }
        public override JetBrains.ReSharper.Psi.Tree.IExpression CreateExpression(string text, JetBrains.ReSharper.Psi.Modules.IPsiModule module) { }
        public override JetBrains.ReSharper.Refactorings.ChangeSignature.ChangeSignatureModel CreateModel(JetBrains.ReSharper.Psi.IParametersOwner owner, JetBrains.Application.Progress.IProgressIndicator progressIndicator = null) { }
        public override JetBrains.ReSharper.Refactorings.ChangeSignature.ChangeSignatureModel CreateModel(JetBrains.ReSharper.Psi.IParametersOwner owner, JetBrains.ReSharper.Refactorings.PushPullTool.Fixes.FixNode fix, JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
        public override JetBrains.ReSharper.Psi.Tree.IParameterDeclaration CreateParameterDeclaration(JetBrains.ReSharper.Psi.Modules.IPsiModule module, string name, JetBrains.ReSharper.Psi.IType type, JetBrains.ReSharper.Psi.ParameterKind parameterKind, bool isParams, bool isVarArg, JetBrains.ReSharper.Psi.Tree.IDeclaration originalDeclaration, bool isThis, JetBrains.ReSharper.Refactorings.ChangeSignature.IParameterValue defaultValue, JetBrains.ReSharper.Refactorings.ChangeSignature.ChangeSignatureModel model) { }
        public override void CreateProxy(JetBrains.ReSharper.Refactorings.ChangeSignature.ChangeSignatureModel changeSignatureModel, System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<JetBrains.ReSharper.Psi.Tree.IArgument, JetBrains.ReSharper.Refactorings.ChangeSignature.ChangeSignatureModel.ArgumentAction>> postActionsList) { }
        public override JetBrains.ReSharper.Psi.Tree.IExpression CreateReferenceExpression(string name, JetBrains.ReSharper.Psi.Modules.IPsiModule module) { }
        public override JetBrains.ReSharper.Psi.Tree.IExpression CreateThisExpression(JetBrains.ReSharper.Psi.Modules.IPsiModule module) { }
        public override JetBrains.ReSharper.Psi.ILocalVariable DeclareLocalVariable(string variableName, JetBrains.ReSharper.Psi.IType variableType, ref JetBrains.ReSharper.Psi.Tree.IExpression beforeExpression, JetBrains.ReSharper.Refactorings.ChangeSignature.IElementsSet elementsToKeep) { }
        public override System.Collections.Generic.Dictionary<int, JetBrains.ReSharper.Refactorings.ChangeSignature.ArgumentInfo> GetArgumentInfos(JetBrains.ReSharper.Psi.Resolve.IReference reference, bool isExtentionCall, JetBrains.ReSharper.Psi.Tree.IArgumentsOwner owner) { }
        public override bool IsAvailable(JetBrains.ReSharper.Psi.IParametersOwner owner) { }
        public override bool IsExtensionCallReference(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public override bool IsIngoredInternal(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public override bool IsLocalEqualToFieldOrAutoProperty(JetBrains.ReSharper.Psi.ITypeMember fieldOrProperty, JetBrains.ReSharper.Psi.IDeclaredElement local, JetBrains.ReSharper.Psi.Tree.ITreeNode place) { }
        public override void RemoveArgument(JetBrains.ReSharper.Psi.Tree.IArgumentsOwner argumentsOwner, JetBrains.ReSharper.Psi.Tree.IArgument toRemove) { }
        protected override JetBrains.ReSharper.Psi.Tree.IArgument ReplaceBy(JetBrains.ReSharper.Psi.Tree.IArgument argument, JetBrains.ReSharper.Psi.Tree.IArgument sharpArgument, JetBrains.ReSharper.Refactorings.ChangeSignature.ChangeSignatureParameter parameter) { }
    }
    public class VBChangeSignatureModel : JetBrains.ReSharper.Refactorings.ChangeSignature.ChangeSignatureModel
    {
        public VBChangeSignatureModel(JetBrains.ReSharper.Psi.IParametersOwner parametersOwner, bool isClone, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
        public VBChangeSignatureModel(JetBrains.ReSharper.Psi.IParametersOwner parametersOwner, JetBrains.ReSharper.Refactorings.PushPullTool.Fixes.FixNode fix, bool isClone, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
        public override System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Tree.IDeclaration> BuildParameters(JetBrains.ReSharper.Psi.IParametersOwner parametersOwner, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution) { }
        public override bool CanMoveDown(int index) { }
        public override object Clone() { }
        public override bool ConflictsWithOtherInstance(JetBrains.ReSharper.Psi.TypeMemberInstance typeMemberInstance) { }
        public override JetBrains.ReSharper.Psi.Tree.IArgumentsOwner GetCallPreview(JetBrains.ReSharper.Psi.Tree.IArgumentsOwner call, JetBrains.ReSharper.Refactorings.ChangeSignature.ChangeSignatureParameter changeSignatureParameter, JetBrains.ReSharper.Psi.IDeclaredElement argumentvalue) { }
        public override string GetOptionalDescription() { }
        public override string GetParameterKindDescription(JetBrains.ReSharper.Psi.ParameterKind kind, bool isParams = False, bool isVarArg = False, bool isThis = False) { }
        public override string GetPreview() { }
        public override JetBrains.ReSharper.Feature.Services.Psi.IUnresolvedTypesChooser GetUnresolvedTypesChooser(JetBrains.ReSharper.Psi.Tree.ITreeNode context) { }
        public override bool HasHandler(JetBrains.ReSharper.Psi.IMethod method) { }
        public override string PresentDefaultValue(JetBrains.ReSharper.Psi.IParameter value) { }
    }
    public class VBControlFlowAnalyzer
    {
        public VBControlFlowAnalyzer(JetBrains.ReSharper.Psi.ITreeRange treeRange) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.ControlFlow.IControlFlowRib> ExitRibs { get; }
        public JetBrains.ReSharper.Refactorings.ExtractMethod.ExtractMethodAvailabilityCheckResult CheckEntriesAndExits() { }
        public bool CrossUsedAnotypes() { }
        public System.Collections.Generic.ICollection<JetBrains.ReSharper.Refactorings.ExtractMethod.LocalVariable> GetVariables() { }
    }
    public class VBCopyTypeConflictSearcher : JetBrains.ReSharper.Refactorings.Conflicts.IConflictSearcher
    {
        public VBCopyTypeConflictSearcher(JetBrains.ReSharper.Psi.ITypeElement typeElement, string newName) { }
        public JetBrains.ReSharper.Refactorings.Conflicts.ConflictSearchResult SearchConflicts(JetBrains.Application.Progress.IProgressIndicator pi, bool canPerformRefactoring) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.VB.VBLanguage))]
    public class VBExtractMethodFactory : JetBrains.ReSharper.Refactorings.ExtractMethod.IExtractMethodFactory
    {
        public JetBrains.ReSharper.Refactorings.ExtractMethod.ExtractMethodAvailabilityCheckResult CheckAvailability(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        public JetBrains.ReSharper.Refactorings.ExtractMethod.IExtractMethod CreateExtractMethod(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        public JetBrains.ReSharper.Psi.ITreeRange GetTreeRange(JetBrains.ProjectModel.ISolution solution, JetBrains.DocumentModel.DocumentRange documentRange) { }
    }
    public class VBFunction2Indexer : JetBrains.ReSharper.Refactorings.VB.VBFunction2Property
    {
        public VBFunction2Indexer(JetBrains.ReSharper.Refactorings.Function2Property.Function2PropertyWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        protected override void CheckConflictWithClassName(JetBrains.ReSharper.Psi.ITypeElement element) { }
        public override void CheckConflictWithMethod(JetBrains.ReSharper.Psi.IMethod method, JetBrains.ReSharper.Psi.IDeclaredElement existingDeclaration, bool isBase, bool isInheritor) { }
        public override void CheckConflictWithProperty(JetBrains.ReSharper.Psi.IProperty property, JetBrains.ReSharper.Psi.IDeclaredElement existingDeclaration, bool isBase, bool isInheritor) { }
        protected override JetBrains.ReSharper.Psi.VB.Tree.IPropertyDeclaration CreatePropertyDeclaration(JetBrains.ReSharper.Psi.VB.VBElementFactory factory, bool isInterface, bool isAbstract) { }
        public override string[] GetAllNames() { }
        protected override JetBrains.ReSharper.Refactorings.Function2Property.PropertySearchResultBase TestPropertyParameters(JetBrains.ReSharper.Psi.IProperty prop) { }
        protected override JetBrains.ReSharper.Psi.VB.Tree.IPropertyDeclaration ValidatePropertyToComplete(JetBrains.ReSharper.Psi.VB.Tree.IPropertyDeclaration propertyToComplete) { }
    }
    public class VBFunction2Property : JetBrains.ReSharper.Refactorings.Function2Property.Function2PropertyBase
    {
        public VBFunction2Property(JetBrains.ReSharper.Refactorings.Function2Property.Function2PropertyWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        protected override bool AreEquals(string name1, string name2) { }
        public override void CheckConflictWithMethod(JetBrains.ReSharper.Psi.IMethod method, JetBrains.ReSharper.Psi.IDeclaredElement existingDeclaration, bool isBase, bool isInheritor) { }
        public override void CheckConflictWithProperty(JetBrains.ReSharper.Psi.IProperty property, JetBrains.ReSharper.Psi.IDeclaredElement existingDeclaration, bool isBase, bool isInheritor) { }
        protected override bool CheckExplicitImplementationList(JetBrains.ReSharper.Psi.IOverridableMember accessor, JetBrains.ReSharper.Psi.IMethod method) { }
        public JetBrains.ReSharper.Psi.VB.Tree.IAccessorDeclaration CreateAccessorDeclaration(JetBrains.ReSharper.Psi.VB.VBElementFactory factory, JetBrains.ReSharper.Psi.AccessorKind kind, string name, JetBrains.ReSharper.Psi.IType propertyType) { }
        protected virtual JetBrains.ReSharper.Psi.VB.Tree.IPropertyDeclaration CreatePropertyDeclaration(JetBrains.ReSharper.Psi.VB.VBElementFactory factory, bool isInterface, bool isAbstract) { }
        public override void ExecuteReferencesRefactoring(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public override bool InitialValidate() { }
        public override void PropcessMethod(JetBrains.ReSharper.Psi.IDeclaredElement element) { }
        protected override void RenameParameter(JetBrains.ReSharper.Psi.IMethod method, JetBrains.ReSharper.Psi.IProperty existingProperty) { }
        protected override JetBrains.ReSharper.Refactorings.Function2Property.PropertySearchResultBase TestPropertyParameters(JetBrains.ReSharper.Psi.IProperty prop) { }
        protected virtual JetBrains.ReSharper.Psi.VB.Tree.IPropertyDeclaration ValidatePropertyToComplete(JetBrains.ReSharper.Psi.VB.Tree.IPropertyDeclaration propertyToComplete) { }
    }
    public class VBIndexer2Function : JetBrains.ReSharper.Refactorings.Indexer2Function.Indexer2FunctionBase
    {
        public VBIndexer2Function(JetBrains.ReSharper.Refactorings.Property2Function.Property2FunctionWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        protected override bool AreEquals(string name1, string name2) { }
        public override void ExecuteDeclarationRefactoring(JetBrains.ReSharper.Psi.IDeclaredElement propertyOrMethod, JetBrains.Application.Progress.IProgressIndicator pi) { }
        protected override bool SkipIndexerReference(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public override bool TryNewTypeDeclaration(JetBrains.ReSharper.Refactorings.Indexer2Function.IndexersSearchData data, JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.VB.VBLanguage))]
    public class VBInstanceObjectUsageChecker : JetBrains.ReSharper.Refactorings.Util.InstanceObjectUsageChecker
    {
        public JetBrains.ReSharper.Refactorings.Util.InstanceObjectUsageResult GetCheckResult(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public class MyCollector : JetBrains.ReSharper.Psi.IRecursiveElementProcessor, JetBrains.ReSharper.Refactorings.Util.InstanceObjectUsageResult
        {
            public MyCollector() { }
            public bool ProcessingIsFinished { get; }
            public bool UsesBaseObject { get; }
            public bool UsesThisObject { get; }
            public bool InteriorShouldBeProcessed(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
            public void ProcessAfterInterior(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
            public void ProcessBeforeInterior(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.VB.VBLanguage))]
    public class VBLanguageSpecificCopyType : JetBrains.ReSharper.Refactorings.CopyType.ICopyType
    {
        public JetBrains.ReSharper.Psi.Tree.ITypeDeclaration CreateCopy(JetBrains.ReSharper.Psi.Tree.ITypeDeclaration typeDeclaration, JetBrains.ReSharper.Psi.Tree.IFile file, string qualifiedName) { }
        public string GenerateFileName(JetBrains.ReSharper.Psi.Tree.ITypeDeclaration typeDeclaration, string name) { }
        public JetBrains.ReSharper.Refactorings.Conflicts.IConflictSearcher GetConflictSearcher(JetBrains.ReSharper.Psi.ITypeElement typeElement, string qualifiedName) { }
        public JetBrains.CommonControls.Validation.IValidator[] GetValidators(System.Windows.Forms.Control namespaceNameControl, JetBrains.ReSharper.Psi.ITypeElement typeElement) { }
        public bool IsAvailable(JetBrains.ReSharper.Psi.Tree.ITypeDeclaration typeDeclaration) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.VB.VBLanguage))]
    public class VBMakeMethodNonStatic : JetBrains.ReSharper.Refactorings.MakeMethodNonStatic.IMakeMethodNonStatic
    {
        public JetBrains.ReSharper.Psi.Tree.IDeclaration AddDeclaration(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration, JetBrains.ReSharper.Psi.Tree.IDeclaration methodOwnerDeclaration) { }
        public void BindToThis(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public JetBrains.ReSharper.Psi.IDeclaredElement PatchDeclaration(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration, int thisParameterIndex, bool createVar, JetBrains.ReSharper.Psi.ITypeElement newMethodOwner, System.Collections.Generic.IList<JetBrains.ReSharper.Psi.ITypeParameter> typeParams, JetBrains.ReSharper.Psi.IInterface @interface, JetBrains.ReSharper.Psi.AccessRights accessRights, System.Collections.Generic.Dictionary<JetBrains.ReSharper.Psi.ITypeParameter, JetBrains.ReSharper.Psi.ITypeParameter> newToOldTypeParameters) { }
        public void PatchMethodReference(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution, int thisParameterIndex, string thisParameterName, System.Collections.Generic.Dictionary<JetBrains.ReSharper.Psi.ITypeParameter, JetBrains.ReSharper.Psi.ITypeParameter> newToOldTypeParametersMap, System.Collections.Generic.IList<JetBrains.ReSharper.Psi.ITypeParameter> methodTypeParams) { }
        public void PatchRecursiveCall(JetBrains.ReSharper.Psi.Tree.ITreeNode referenceElement, int thisParameterIndex, string thisParameterName) { }
        public JetBrains.ReSharper.Refactorings.MakeMethodNonStatic.Conflicts ReferenceConflicts(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.IFunction method, int thisParamIndex, JetBrains.ReSharper.Psi.AccessRights accessRights, JetBrains.ReSharper.Psi.ITypeElement targetType) { }
        public void RemoveDeclaration(JetBrains.ReSharper.Psi.Tree.IDeclaration methodDeclaration) { }
        public bool Suitable(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration) { }
        public class MyAccessChecker : JetBrains.ReSharper.Refactorings.Util.AccessRightsChecker, JetBrains.ReSharper.Psi.Resolve.IAccessContext
        {
            public MyAccessChecker(JetBrains.ReSharper.Psi.AccessRights accessRights, JetBrains.ReSharper.Psi.ITypeElement targetType, JetBrains.ReSharper.Psi.VB.Tree.IReferenceExpression place) { }
            protected override JetBrains.ReSharper.Psi.Resolve.IAccessContext BuildAccessContext(ref JetBrains.ReSharper.Psi.ITypeMember accessedElement, ref JetBrains.ReSharper.Psi.AccessRights accessRights) { }
            public JetBrains.ReSharper.Psi.ITypeElement GetAccessContainingTypeElement() { }
            public JetBrains.ReSharper.Psi.Modules.IPsiModule GetPsiModule() { }
            public JetBrains.ReSharper.Psi.Resolve.QualifierKind GetQualifierKind() { }
            public JetBrains.ReSharper.Psi.ITypeElement GetQualifierTypeElement() { }
            public JetBrains.ReSharper.Psi.Resolve.Staticness GetStaticness() { }
        }
    }
    public class VBMoveStaticMembers : JetBrains.ReSharper.Refactorings.MoveStaticMembers.MoveStaticMembers
    {
        public VBMoveStaticMembers(JetBrains.ReSharper.Refactorings.MoveStaticMembers.MoveStaticMembersWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public override System.Collections.Generic.Dictionary<JetBrains.ReSharper.Psi.ITypeParameter, JetBrains.ReSharper.Psi.ITypeParameter> PasteDeclaration(JetBrains.ReSharper.Refactorings.MoveStaticMembers.Impl.TypeMemberCopy memberInfo, ref JetBrains.ReSharper.Psi.ITypeMember newTypeMember) { }
        public override void RemoveOldDeclaration(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration) { }
    }
    public class VBMoveStaticMembersHelper : JetBrains.ReSharper.Refactorings.MoveStaticMembers.MoveStaticMembersHelper
    {
        public override bool IsLanguageSupported { get; }
    }
    public class VBProperty2FunctionDeclarationProcessor : JetBrains.ReSharper.Refactorings.Common.Convert.Property2FunctionDeclarationProcessor<JetBrains.ReSharper.Psi.VB.Tree.IMethodDeclaration>
    {
        protected override JetBrains.ReSharper.Psi.VB.Tree.IMethodDeclaration AddAccessor(JetBrains.ReSharper.Psi.VB.Tree.IMethodDeclaration declaration, JetBrains.ReSharper.Psi.IProperty property) { }
        protected override bool CheckIsAuto(JetBrains.ReSharper.Psi.IProperty property) { }
        public static JetBrains.ReSharper.Psi.VB.Tree.IMethodDeclaration CreateAccessorDeclaration(bool withBody, JetBrains.ReSharper.Psi.IProperty prop, JetBrains.ReSharper.Psi.IAccessor accessor, string accessorName, string accessorTemplate) { }
        protected override JetBrains.ReSharper.Psi.IProperty CreateFieldForAutoProperty(JetBrains.ReSharper.Psi.IProperty propty) { }
        protected override string GetterPattern(bool isAbstract, bool isInterface) { }
        protected override void RemoveBaseDeclaration(JetBrains.ReSharper.Psi.IProperty property) { }
        protected override void RemoveGetter(JetBrains.ReSharper.Psi.IProperty property) { }
        protected override void RemoveSetter(JetBrains.ReSharper.Psi.IProperty property) { }
        protected override string SetterPattern(bool isAbstract, bool isInterface, JetBrains.ReSharper.Psi.IProperty prop) { }
    }
    public class VBProperty2FunctionReferencesProcessor : JetBrains.ReSharper.Refactorings.Common.Convert.Property2FunctionReferencesProcessor
    {
        public VBProperty2FunctionReferencesProcessor(JetBrains.ReSharper.Refactorings.Property2Function.Property2FunctionBase refactoring) { }
        public override void ReplaceReadOccurence(JetBrains.ReSharper.Psi.Tree.IExpression expression) { }
        public override bool ReplaceReadWriteOccurence(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.Tree.IExpression expression) { }
        public override bool ReplaceWriteProperty(JetBrains.ReSharper.Psi.Tree.IExpression expression, JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public override bool TryTransformMthodCall(JetBrains.ReSharper.Psi.Tree.IExpression expression) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.VB.VBLanguage))]
    public class VBRefactoringLanguageService : JetBrains.ReSharper.Refactorings.InternalRefactoringLanguageService
    {
        public override JetBrains.ReSharper.Refactorings.RefactoringsHelper Helper { get; }
        public override JetBrains.ReSharper.Refactorings.Convert.Common.IConvert CreateAbstract2Interface(JetBrains.ReSharper.Refactorings.Convert.Abstract2Interface.Abstract2InterfaceWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public override JetBrains.ReSharper.Refactorings.Move.AdjustNamespaces.AdjustNamespacesHelperBase CreateAdjustNamespaceHelper() { }
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
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.VB.VBLanguage))]
    public class VBRefactoringService : JetBrains.ReSharper.Refactorings.RefactoringService
    {
        public JetBrains.ReSharper.Psi.ILocalScope[] FindScopesByDeclaredElement(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
    }
    public class VBRefactoringsHelper : JetBrains.ReSharper.Refactorings.RefactoringsHelper
    {
        public override bool CanContainExtensionMethods(JetBrains.ReSharper.Psi.IClass @class) { }
        public override bool CanExtractSuperclass(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration) { }
        public override bool CanUseExplicitly(JetBrains.ReSharper.Psi.IType type) { }
        public override bool CanUseInstanceFields(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public override bool CheckForIntroduceAccessible(JetBrains.ReSharper.Psi.Tree.ITreeNode expression) { }
        public override JetBrains.ReSharper.Refactorings.InlineVar.RDAnalysis.InlineVarAnalyserBase CreateInlineVarAnalyser(JetBrains.ReSharper.Refactorings.InlineVar.InlineVarWorkflow workflow) { }
        public override JetBrains.ReSharper.Refactorings.IntroduceField.IntroFieldAnalyser CreateIntroFieldAnalyser() { }
        public override JetBrains.ReSharper.Refactorings.Property2Auto.IProperty2AutoChecker CreateProperty2AutoChecker() { }
        public override bool DeclarationHasBody(JetBrains.ReSharper.Psi.IDeclaredElement element) { }
        public override bool ExtentionMethodsSupported(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public override bool FailOnReferencesToLocals(JetBrains.ReSharper.Psi.Tree.IExpression expression) { }
        public override bool Function2PropertyAvailable(JetBrains.ReSharper.Psi.IMethod method) { }
        public override JetBrains.ReSharper.Psi.Tree.IArgumentsOwner GetArgumentsOwner(ref JetBrains.ReSharper.Psi.Resolve.IReference reference, bool replaceMethodGroup) { }
        public override string GetDeclareStaticText() { }
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IDeclaredElement> GetLocals(JetBrains.ReSharper.Psi.Tree.IExpression expression, JetBrains.ReSharper.Psi.IParametersOwner owner) { }
        public override string GetMakeMethodNonStaticTitle() { }
        public override JetBrains.ReSharper.Refactorings.Util.ReferenceComparatorDelegate GetReferenceComparator() { }
        public override JetBrains.ReSharper.Psi.Tree.ITreeNode GetStatementVisibleForAll(System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Tree.IExpression> expressions) { }
        public override JetBrains.ReSharper.Psi.Tree.ITypeDeclaration GetTypeDeclarationForField(JetBrains.ReSharper.Psi.Tree.ITypeDeclaration typeDeclaration, out bool baseTypeChoosed) { }
        public override bool HasIninializer(JetBrains.ReSharper.Psi.IField field) { }
        public override bool IndexerIsPresented() { }
        public override JetBrains.ReSharper.Psi.Tree.IExpression IntroParameterGetInitializer(JetBrains.ReSharper.Psi.ILocalVariable variable) { }
        public override bool IsIterator(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration) { }
        public override bool IsNew(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration) { }
        public override bool IsPartialMethod(JetBrains.ReSharper.Psi.ITypeMember member) { }
        public override bool IsReferenceName(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public override JetBrains.ReSharper.Refactorings.Helpers.INamespaceRedundancyProblemFixer NamespaceRedundancyFileFixer(JetBrains.ReSharper.Psi.INamespace @namespace, JetBrains.ReSharper.Psi.Tree.IFile file) { }
        public override string PresentAccessRights(JetBrains.ReSharper.Psi.AccessRights rights, bool useMenemonics) { }
        public override bool ReferencesRangeVariables(JetBrains.ReSharper.Psi.Tree.IExpression expression) { }
        public override void SetNew(JetBrains.ReSharper.Psi.Tree.ITypeMemberDeclaration typeMember, bool isNew) { }
    }
    public sealed class VBRenameAvailabilityCheckResult : JetBrains.ReSharper.Refactorings.RenameModel.RenameAvailabilityCheckResult
    {
        public static readonly JetBrains.ReSharper.Refactorings.VB.VBRenameAvailabilityCheckResult CannotRenameLambda;
        public static readonly JetBrains.ReSharper.Refactorings.VB.VBRenameAvailabilityCheckResult CannotRenamePropertyAccessor;
    }
    public class VBStatementExtractMethod : JetBrains.ReSharper.Refactorings.ExtractMethod.StatementExtractMethodBase
    {
        public VBStatementExtractMethod(JetBrains.ReSharper.Psi.VB.Tree.IVBStatementsRange statementsRange) { }
        protected override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.ControlFlow.IControlFlowRib> ExitRibs { get; }
        public override bool IsValid { get; }
        public override JetBrains.ReSharper.Psi.PsiLanguageType Language { get; }
        public override JetBrains.ReSharper.Psi.PsiLanguageType LanguageType { get; }
        public override System.Collections.Generic.ICollection<JetBrains.ReSharper.Refactorings.ExtractMethod.LocalVariable> LocalVariables { get; }
        public override JetBrains.ReSharper.Refactorings.ExtractMethod.ExtractMethodAvailabilityCheckResult Check() { }
        protected override JetBrains.ReSharper.Refactorings.ExtractMethod.ExtractMethodParameter CreateParameter(JetBrains.ReSharper.Refactorings.ExtractMethod.LocalVariable localVariable, bool isReturned) { }
        public override bool Execute(JetBrains.Application.Progress.IProgressIndicator pi) { }
        public override string PreviewDeclaration() { }
        protected override JetBrains.ReSharper.Refactorings.ExtractMethod.ExtractMethodParameter UpdateParameter(JetBrains.ReSharper.Refactorings.ExtractMethod.ExtractMethodParameter parameter, bool isReturned) { }
    }
}
namespace JetBrains.ReSharper.Refactorings.VB.DefaultPropertyToFunction
{
    
    public class DefaultPropertyToFunctionWorkflow : JetBrains.ReSharper.Refactorings.Indexer2Function.Indexer2FunctionWorkflow
    {
        public DefaultPropertyToFunctionWorkflow(JetBrains.ProjectModel.ISolution solution, string actionId) { }
        public override string PropertyName { get; }
        public override string Title { get; }
        protected override bool CheckLanguage(JetBrains.ReSharper.Psi.IDeclaredElement element) { }
        protected override void InitPropertyName(JetBrains.ReSharper.Psi.IProperty indexer) { }
    }
}
namespace JetBrains.ReSharper.Refactorings.VB.EncapsulateField
{
    
    public class VBEncapsulateField : JetBrains.ReSharper.Refactorings.EncapsulateField.EncapsulateFieldBase
    {
        public VBEncapsulateField(JetBrains.ReSharper.Refactorings.EncapsulateField.EncapsulateFieldWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public override void AddReadAccessor(JetBrains.ReSharper.Psi.IProperty property, JetBrains.ReSharper.Psi.IField field) { }
        public override void AddWriteAccessor(JetBrains.ReSharper.Psi.IProperty property, JetBrains.ReSharper.Psi.IField field) { }
        public static JetBrains.ReSharper.Psi.IField AnalyseGetterReturn(JetBrains.ReSharper.Psi.VB.Tree.IVBStatement statement) { }
        public static JetBrains.ReSharper.Psi.IField AnalyseSetter(JetBrains.ReSharper.Psi.VB.Tree.IVBStatement statement) { }
        public static JetBrains.ReSharper.Psi.IField CheckAccessor(JetBrains.ReSharper.Psi.IProperty property, JetBrains.ReSharper.Refactorings.VB.EncapsulateField.VBEncapsulateField.AnalyseStatement analyse, JetBrains.ReSharper.Psi.AccessorKind kind) { }
        public override JetBrains.ReSharper.Psi.IProperty CreatePropertyDeclaration(JetBrains.ReSharper.Psi.IField field, string myFieldNewName) { }
        public JetBrains.ReSharper.Psi.VB.Tree.IAccessorDeclaration CreateReadAccessor(JetBrains.ReSharper.Psi.IField field) { }
        public JetBrains.ReSharper.Psi.VB.Tree.IAccessorDeclaration CreateWriteAccessor(JetBrains.ReSharper.Psi.IField field) { }
        public override JetBrains.ReSharper.Psi.IField GetBackingFieldForGetter(JetBrains.ReSharper.Psi.IProperty property) { }
        public override JetBrains.ReSharper.Psi.IField GetBackingFieldForSetter(JetBrains.ReSharper.Psi.IProperty property) { }
        public override void ProcessReference(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.ReferenceAccessType accessType, JetBrains.ReSharper.Psi.IProperty property) { }
        public delegate JetBrains.ReSharper.Psi.IField AnalyseStatement(JetBrains.ReSharper.Psi.VB.Tree.IVBStatement statement);
    }
}
namespace JetBrains.ReSharper.Refactorings.VB.ExtractClass
{
    
    public class VbExtractClassAnalyzer : JetBrains.ReSharper.Refactorings.ExtractClass.Analysis.ExtractClassAnalyzer
    {
        public VbExtractClassAnalyzer(JetBrains.ReSharper.Refactorings.ExtractClass.ExtractClassWorkflow extractClassWorkflow, JetBrains.Util.FileSystemPath fileSystemPath) { }
        protected override void CreateConstructors() { }
        public override void InitializeMembers(System.Func<JetBrains.ReSharper.Psi.ITypeMember, bool> isMemberIncluded) { }
        public enum ReferenceResult
        {
            Param = 0,
            Free = 1,
            Included = 2,
            Literal = 3,
            None = 4,
        }
    }
    public class VbExtractClassHelper : JetBrains.ReSharper.Refactorings.ExtractClass.ExtractClassHelper
    {
        public override bool IsLanguageSupported { get; }
        protected static System.Collections.Generic.JetHashSet<JetBrains.ReSharper.Psi.VB.Tree.ITypeParameterOfTypeDeclaration> CollectParameters(System.Collections.Generic.JetHashSet<JetBrains.ReSharper.Psi.VB.Tree.ITypeParameterOfTypeDeclaration> sourceTypeTypeParameters, JetBrains.ReSharper.Psi.VB.Tree.ITypeParameterOfTypeOwnerDeclaration source) { }
        public override JetBrains.ReSharper.Psi.Tree.ITypeDeclaration CreateTargetTypeElement(out System.Collections.Generic.Dictionary<, > typeParams, JetBrains.ReSharper.Refactorings.ExtractClass.ExtractClassWorkflow workflow) { }
        public override JetBrains.ReSharper.Refactorings.ExtractClass.Analysis.ExtractClassAnalyzer GetAnalyzer(JetBrains.ReSharper.Refactorings.ExtractClass.ExtractClassWorkflow extractClassWorkflow, JetBrains.ReSharper.Psi.ITypeElement owner, string name, JetBrains.Util.FileSystemPath fileSystemPath) { }
        protected static System.Collections.Generic.List<JetBrains.ReSharper.Psi.VB.Tree.ITypeParameterOfTypeDeclaration> GetUsedTypeParameters(JetBrains.ReSharper.Psi.VB.Tree.ITypeParameterOfTypeOwnerDeclaration sourceTypeDeclaration) { }
        public override JetBrains.ReSharper.Psi.Tree.ITypeDeclaration InsertSibling(JetBrains.ReSharper.Psi.Tree.ITypeDeclaration declarationToInsert, JetBrains.ReSharper.Psi.Tree.ITypeDeclaration tagDeclaration) { }
        public override JetBrains.ReSharper.Psi.Tree.ITypeDeclaration InsertToNewFile(JetBrains.ReSharper.Psi.Tree.ITypeDeclaration declarationToInsert, JetBrains.ReSharper.Psi.Tree.ITypeDeclaration tagDeclaration, string targetNamespace, JetBrains.ProjectModel.IProjectFile fileNearby) { }
        public override bool TryProcessMultyFieldForResolve(JetBrains.ReSharper.Psi.IRecursiveElementProcessor collector, JetBrains.ReSharper.Psi.Tree.IDeclaration declaration) { }
    }
    public class VbExtractClassRefactoringExec : JetBrains.ReSharper.Refactorings.ExtractClass.ExtractClassRefactoringExec
    {
        public VbExtractClassRefactoringExec(JetBrains.ReSharper.Refactorings.ExtractClass.ExtractClassWorkflow extractClassWorkflow) { }
        public override void AddField(JetBrains.ReSharper.Psi.ITypeElement sourceTypeElement, JetBrains.ReSharper.Psi.ITypeElement targetTypeElement) { }
        public override void AddProperties() { }
        public override void CreateConstructors() { }
        public override bool CutAndPaste(JetBrains.ReSharper.Refactorings.Util.NewTypeImages.ResolveImagesRepository repository, System.Collections.Generic.Dictionary<JetBrains.ReSharper.Psi.ITypeParameter, JetBrains.ReSharper.Psi.ITypeParameter> createdTypeParametersMap, JetBrains.Application.Progress.IProgressIndicator pi) { }
        public override void Rebind(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Refactorings.ExtractClass.Info.MemberInfo memberToRebind, JetBrains.ReSharper.Psi.IDeclaredElement propertyMember) { }
        public override void ResolveConflicts(JetBrains.Application.Progress.IProgressIndicator subPi) { }
    }
}
namespace JetBrains.ReSharper.Refactorings.VB.ExtractMethod
{
    
    public class VBExpressionExtractMethod : JetBrains.ReSharper.Refactorings.ExtractMethod.ExpressionExtractMethodBase
    {
        public VBExpressionExtractMethod(JetBrains.ReSharper.Psi.VB.Tree.IVBExpression expression, System.Collections.Generic.ICollection<JetBrains.ReSharper.Refactorings.ExtractMethod.LocalVariable> localVariables) { }
        public override JetBrains.ReSharper.Psi.PsiLanguageType Language { get; }
        public override JetBrains.ReSharper.Psi.PsiLanguageType LanguageType { get; }
        protected override JetBrains.ReSharper.Refactorings.ExtractMethod.ExtractMethodParameter CreateParameter(JetBrains.ReSharper.Refactorings.ExtractMethod.LocalVariable variable) { }
        public override bool Execute(JetBrains.Application.Progress.IProgressIndicator pi) { }
        public override void PostExecute(JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
        public override string PreviewDeclaration() { }
    }
}
namespace JetBrains.ReSharper.Refactorings.VB.Inline.ArgUtil
{
    
    public class VBArgumentsUtil
    {
        public static JetBrains.ReSharper.Refactorings.Inline.ArgUtil.ArgumentFromParameter GetArgumentFromParameter(JetBrains.ReSharper.Psi.IParameter parameter, JetBrains.ReSharper.Psi.VB.Tree.IVBArgumentsOwner argumentsOwner, JetBrains.ReSharper.Psi.IParametersOwner parametersOwner) { }
    }
}
namespace JetBrains.ReSharper.Refactorings.VB.Inline
{
    
    public class ReturnProblemAnalyser
    {
        public static bool AllReturnStatementsAreLast(JetBrains.ReSharper.Psi.VB.Tree.IBlock block) { }
    }
    public class ReturnsCounter : JetBrains.ReSharper.Psi.IRecursiveElementProcessor
    {
        public bool ProcessingIsFinished { get; }
        public static bool HasOneReturnSatement(JetBrains.ReSharper.Psi.VB.Tree.IBlock block, ref JetBrains.ReSharper.Psi.VB.Tree.IReturnStatement returnStatement) { }
        public bool InteriorShouldBeProcessed(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public void ProcessAfterInterior(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public void ProcessBeforeInterior(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
    }
    public class ThisReferenceCounter : JetBrains.ReSharper.Psi.IRecursiveElementProcessor
    {
        public ThisReferenceCounter(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public bool HasOneReference { get; }
        public bool HasReferences { get; }
        public bool ProcessingIsFinished { get; }
        public int ReferencesCount { get; set; }
        public bool InteriorShouldBeProcessed(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public void ProcessAfterInterior(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public void ProcessBeforeInterior(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
    }
    public class VBInlinedCodeTransformer : JetBrains.ReSharper.Refactorings.Inline.InlinedCodeTransformerBase<JetBrains.ReSharper.Psi.VB.Tree.IReferenceExpression, JetBrains.ReSharper.Psi.VB.Tree.IReturnStatement>
    {
        public VBInlinedCodeTransformer(JetBrains.ReSharper.Psi.Tree.ITreeNode expression, JetBrains.ReSharper.Refactorings.Inline.InlinedCallInfo inlinedCallInfo, JetBrains.ReSharper.Refactorings.Inline.CallSiteContext context) { }
        protected override JetBrains.ReSharper.Psi.Tree.ITreeNode AddActionRemoveReturn(JetBrains.ReSharper.Psi.VB.Tree.IReturnStatement returnStatement) { }
        protected override JetBrains.ReSharper.Psi.Tree.ITreeNode AddActionReplaceExpressionWithAssignedExpression(JetBrains.ReSharper.Psi.VB.Tree.IReferenceExpression expression) { }
        protected override JetBrains.ReSharper.Psi.Tree.ITreeNode AddActionReplaceExpressionWithTemp(JetBrains.ReSharper.Psi.Tree.IExpression expression, string newTempName) { }
        protected override JetBrains.ReSharper.Psi.Tree.ITreeNode AddActionReplaceParameterWithArgumentExpression(JetBrains.ReSharper.Psi.VB.Tree.IReferenceExpression expression, JetBrains.ReSharper.Psi.IParameter parameter, JetBrains.ReSharper.Refactorings.Inline.InlinedArgumentInfo callInfo) { }
        protected override JetBrains.ReSharper.Psi.Tree.ITreeNode AddActionReplaceReturnWithAssignmentToTemp(JetBrains.ReSharper.Psi.VB.Tree.IReturnStatement returnStatement) { }
        protected override JetBrains.ReSharper.Psi.Tree.ITreeNode AddActionReplaceWithDefaultParamValue(JetBrains.ReSharper.Psi.VB.Tree.IReferenceExpression expression, JetBrains.ReSharper.Psi.IParameter parameter) { }
        protected override JetBrains.ReSharper.Psi.Tree.ITreeNode AddActionSetQualifier(JetBrains.ReSharper.Psi.VB.Tree.IReferenceExpression expression) { }
        protected override JetBrains.ReSharper.Psi.Tree.ITreeNode ChangeName(JetBrains.ReSharper.Psi.Tree.ITreeNode element, string name) { }
        protected override bool IsExtensionMethod(JetBrains.ReSharper.Psi.VB.Tree.IReferenceExpression expression) { }
        protected override bool IsSetterParameter(JetBrains.ReSharper.Psi.IParameter parameter) { }
        protected override JetBrains.ReSharper.Psi.Tree.ITreeNode ReplaceByQualifier(JetBrains.ReSharper.Psi.VB.Tree.IReferenceExpression expression, JetBrains.ReSharper.Refactorings.Inline.InlinedCallInfo info) { }
        protected override JetBrains.ReSharper.Psi.Tree.ITreeNode ReplaceReturnWithAssignment(JetBrains.ReSharper.Psi.VB.Tree.IReturnStatement returnStatement) { }
        protected override void TransformElement(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        protected override bool ValueIsNotNull(JetBrains.ReSharper.Psi.VB.Tree.IReturnStatement statement) { }
    }
    public class VBInlineHelper : JetBrains.ReSharper.Refactorings.Inline.InlineHelper
    {
        public VBInlineHelper(JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Resolve.IReference> AllNotQualifiableReferences(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public override bool CanHaveSideEffects(JetBrains.ReSharper.Psi.Tree.IExpression expression) { }
        public override bool CanHaveSideEffects(JetBrains.ReSharper.Psi.Tree.IArgument argument) { }
        public override bool CanHaveSideEffects(JetBrains.ReSharper.Psi.Resolve.IReference reference, ref JetBrains.ReSharper.Psi.Tree.IExpression qualifier, bool isStatic) { }
        public static JetBrains.ReSharper.Psi.VB.Tree.IVBStatement CreateVariableDeclarationStatement(JetBrains.ReSharper.Psi.VB.Tree.IVBExpression newExpression, JetBrains.ReSharper.Psi.Tree.ITreeNode contextNode, ref string name, string suggestName, JetBrains.ReSharper.Psi.IExpressionType expressionType, JetBrains.ReSharper.Refactorings.Inline.CallSiteContext context) { }
        public static JetBrains.ReSharper.Psi.VB.Tree.IBlock EnBlock(JetBrains.ReSharper.Psi.Resolve.IReference reference, ref JetBrains.ReSharper.Psi.VB.Tree.IVBStatement tag, JetBrains.ReSharper.Psi.ExtensionsAPI.ReferenceIdentitySaver parentSaver) { }
        public override System.Collections.Generic.Dictionary<int, JetBrains.ReSharper.Refactorings.Inline.InlinedArgumentInfo> GetArgument2Infos(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Refactorings.Inline.InlinedMethodInfo inlinedMethodInfo, System.Collections.Generic.Dictionary<JetBrains.ReSharper.Psi.IParameter, JetBrains.ReSharper.Refactorings.Inline.ArgUtil.ArgumentFromParameter> parameter2argument) { }
        public override JetBrains.ReSharper.Psi.Tree.IArgumentsOwner GetArgumentOwner(ref JetBrains.ReSharper.Psi.Resolve.IReference reference, bool replaceMethodGroup) { }
        public static JetBrains.ReSharper.Psi.VB.Tree.IVBExpression GetArgumentValue(JetBrains.ReSharper.Psi.Tree.IArgument arguemnt) { }
        public override JetBrains.ReSharper.Psi.Tree.ITreeNode GetContainingStatement(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public static JetBrains.ReSharper.Psi.VB.Tree.IVBExpression GetInvokedElement(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public override System.Collections.Generic.Dictionary<JetBrains.ReSharper.Psi.IParameter, JetBrains.ReSharper.Refactorings.Inline.ArgUtil.ArgumentFromParameter> GetParameter2Argument(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.IParametersOwner parametersOwner) { }
        public override void InsertReturnValueTempVariable(JetBrains.ReSharper.Refactorings.Inline.InlinedCallInfo inlinedCallInfo, JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Refactorings.Inline.CallSiteContext context) { }
        public override void InsertTempForArgument(JetBrains.ReSharper.Refactorings.Inline.InlinedParameterInfo parameterInfo, JetBrains.ReSharper.Refactorings.Inline.InlinedArgumentInfo argumentInfo, JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Refactorings.Inline.CallSiteContext context, JetBrains.ReSharper.Psi.ExtensionsAPI.ReferenceIdentitySaver saver) { }
        public override void InsertTempForQualifier(JetBrains.ReSharper.Refactorings.Inline.InlinedCallInfo inlinedCallInfo, JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Refactorings.Inline.CallSiteContext context, JetBrains.ReSharper.Psi.ExtensionsAPI.ReferenceIdentitySaver saver) { }
        public override void InsertTempVariableForAssignedValue(JetBrains.ReSharper.Refactorings.Inline.InlinedCallInfo inlinedCallInfo, JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Refactorings.Inline.CallSiteContext context) { }
        public override bool IsSourceOfAssignment(JetBrains.ReSharper.Psi.Resolve.IReference reference, ref JetBrains.ReSharper.Psi.Tree.IExpression destination, JetBrains.ReSharper.Refactorings.Inline.InlinedCallKinds inlinedCallKinds) { }
        public override void RemoveCastFromElement(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public override void ReplaceTypeParameter(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.ITypeParameter parameter, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution) { }
    }
    public class VBInlineMethod : JetBrains.ReSharper.Refactorings.Inline.InlineMethod
    {
        public VBInlineMethod(JetBrains.ReSharper.Refactorings.Inline.InlineMethodWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public override JetBrains.ReSharper.Refactorings.Inline.InlineHelper InlineHelper { get; }
        public override bool AllReturnsAreLast(JetBrains.ReSharper.Psi.IDeclaredElement element) { }
        public override JetBrains.ReSharper.Psi.Tree.ITreeNode GetBody(JetBrains.ReSharper.Psi.Tree.IDeclaration decl) { }
        public override bool GetIsDestinationOfAssignment(JetBrains.ReSharper.Psi.Resolve.IReference reference, ref JetBrains.ReSharper.Psi.Tree.IExpression expression) { }
        public override bool GetThisIsUsedOnce(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
        public override bool GetUsedAsDelegate(JetBrains.ReSharper.Refactorings.Inline.InlinedMethodInfo info, JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public override bool IsFromStatement(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public override bool IsLastStatement(JetBrains.ReSharper.Psi.Resolve.IReference reference, ref JetBrains.ReSharper.Psi.Tree.ITreeNode lastStatement) { }
        public override bool IsReturned(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Refactorings.Inline.InlinedCallKinds inlinedCallKind) { }
        public override bool IsReturnStatementOnly(JetBrains.ReSharper.Psi.IDeclaredElement element, ref JetBrains.ReSharper.Psi.Tree.IExpression returnedExpression, ref JetBrains.ReSharper.Psi.Tree.ITreeNode blockOfStatements) { }
        public override bool IsSetterParameter(JetBrains.ReSharper.Psi.IParameter parameter) { }
        public static bool IsSetterParameterShared(JetBrains.ReSharper.Psi.IParameter parameter) { }
        public override bool ReplaceCall(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.Tree.IExpression returnedExpression, JetBrains.ReSharper.Refactorings.Inline.InlinedCallInfo inlinedCallInfo, JetBrains.ReSharper.Refactorings.Inline.CallSiteContext context) { }
        public override bool ReplaceStatement(ref JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.Tree.ITreeNode elementOfStatements, JetBrains.ReSharper.Refactorings.Inline.InlinedCallInfo inlinedCallInfo, JetBrains.ReSharper.Refactorings.Inline.CallSiteContext context, bool replaceOriginal) { }
    }
}
namespace JetBrains.ReSharper.Refactorings.VB.InlineClass
{
    
    public class VBInlineClassAnalyzer : JetBrains.ReSharper.Refactorings.InlineClass.InlineClassAnalyzer
    {
        public VBInlineClassAnalyzer(JetBrains.ReSharper.Refactorings.InlineClass.InlineClassWorkflow inlineClassWorkflow, JetBrains.ReSharper.Psi.ITypeOwner element, JetBrains.ReSharper.Psi.ITypeElement owner) { }
        protected override void AddMemberInfo(JetBrains.ReSharper.Psi.ITypeMember member) { }
        public override void Analyze() { }
        protected override void FillTargetTypeElements() { }
        protected override void InitializeMembers(JetBrains.ReSharper.Psi.ITypeOwner member, JetBrains.ReSharper.Psi.ITypeElement owner) { }
    }
    public class VbInlineClassHelper : JetBrains.ReSharper.Refactorings.InlineClass.InlineClassHelper
    {
        public override JetBrains.ReSharper.Refactorings.InlineClass.InlineClassAnalyzer GetAnalyzer(JetBrains.ReSharper.Refactorings.InlineClass.InlineClassWorkflow inlineClassWorkflow, JetBrains.ReSharper.Psi.ITypeOwner element, JetBrains.ReSharper.Psi.ITypeElement owner) { }
    }
    public class VBInlineClassRefactoringExec : JetBrains.ReSharper.Refactorings.InlineClass.IInlineClassRefactoringExec
    {
        public VBInlineClassRefactoringExec(JetBrains.ReSharper.Refactorings.InlineClass.InlineClassWorkflow myWorkflow) { }
        protected JetBrains.ReSharper.Psi.Modules.IPsiModule PsiModule { get; set; }
        public JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver RefactoringDriver { set; }
        protected JetBrains.ReSharper.Refactorings.Util.NewTypeImages.ResolveImagesRepository Repository { get; set; }
        protected JetBrains.ReSharper.Refactorings.InlineClass.InlineClassWorkflow Workflow { get; set; }
        public void CutAndPaste(JetBrains.Application.Progress.IProgressIndicator subPi) { }
        public void Rebind(JetBrains.Application.Progress.IProgressIndicator subPi) { }
    }
}
namespace JetBrains.ReSharper.Refactorings.VB.InlineField
{
    
    public class InlineFieldInspectionContextFactory : JetBrains.ReSharper.Psi.ControlFlow.IControlFlowContextFactory<JetBrains.ReSharper.Refactorings.InlineField.InlineFieldInspectionContext>
    {
        public JetBrains.ReSharper.Refactorings.InlineField.InlineFieldInspectionContext InitialContext { get; }
        public JetBrains.ReSharper.Refactorings.InlineField.InlineFieldInspectionContext CloneContext(JetBrains.ReSharper.Refactorings.InlineField.InlineFieldInspectionContext context) { }
        public JetBrains.ReSharper.Refactorings.InlineField.InlineFieldInspectionContext Merge(System.Collections.Generic.IList<JetBrains.ReSharper.Refactorings.InlineField.InlineFieldInspectionContext> contexts) { }
    }
    public class VBInlineField : JetBrains.ReSharper.Refactorings.InlineField.InlineFieldBase
    {
        public VBInlineField(JetBrains.ReSharper.Refactorings.InlineField.InlineFieldWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public override JetBrains.ReSharper.Refactorings.Inline.InlineHelper InlineHelper { get; }
        public override bool CanInlineReference(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public override bool GetCanUseRefOut(JetBrains.ReSharper.Psi.Tree.IExpression expression) { }
        public override JetBrains.ReSharper.Psi.Tree.ITreeNode GetContainingDeclarationBlock(JetBrains.ReSharper.Psi.Tree.IExpression expression) { }
        public override JetBrains.ReSharper.Psi.Tree.IExpression GetInitializerExpression(JetBrains.ReSharper.Psi.IField field) { }
        public override JetBrains.ReSharper.Psi.Tree.IExpression GetInitializerExpression(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public override bool HasSideEffects(JetBrains.ReSharper.Psi.Tree.IExpression expression) { }
        public override string InsertTempVariable(JetBrains.ReSharper.Psi.Tree.ITreeNode tag, string name, JetBrains.ReSharper.Psi.Tree.IExpression expression) { }
        public static bool IsInitializationOfField(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.IField field, ref JetBrains.ReSharper.Psi.Tree.IExpression initializer) { }
        public override void ProcessReferenceWithContext(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Refactorings.Inline.CallSiteContext context, JetBrains.ReSharper.Refactorings.Inline.InlinedCallInfo info) { }
        public override void RemoveAssgnment(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public override void RemoveField(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration) { }
        public override void ReplaceExpression(JetBrains.ReSharper.Psi.Resolve.IReference reference, string localName) { }
        public override bool ThisIsUsed(JetBrains.ReSharper.Psi.Tree.IExpression expression) { }
    }
    public class VBInlineFieldInspector : JetBrains.ReSharper.Refactorings.VB.Util.RDInspectorOfVariable<JetBrains.ReSharper.Refactorings.InlineField.InlineFieldInspectionContext>
    {
        public VBInlineFieldInspector(JetBrains.ReSharper.Psi.ControlFlow.Impl.ControlFlowGraf controlFlowGraf, JetBrains.ReSharper.Refactorings.InlineField.InlineFieldRefactoring executer) { }
        protected override bool CustomInspection(JetBrains.ReSharper.Psi.ControlFlow.IControlFlowElement controlFlowElement, JetBrains.ReSharper.Refactorings.InlineField.InlineFieldInspectionContext context, JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
    }
}
namespace JetBrains.ReSharper.Refactorings.VB.InlineVar
{
    
    public class InlineVarContextFactory : JetBrains.ReSharper.Psi.ControlFlow.IControlFlowContextFactory<JetBrains.ReSharper.Refactorings.InlineVar.RDAnalysis.InlineVarContext>
    {
        public JetBrains.ReSharper.Refactorings.InlineVar.RDAnalysis.InlineVarContext InitialContext { get; }
        public JetBrains.ReSharper.Refactorings.InlineVar.RDAnalysis.InlineVarContext CloneContext(JetBrains.ReSharper.Refactorings.InlineVar.RDAnalysis.InlineVarContext context) { }
        public JetBrains.ReSharper.Refactorings.InlineVar.RDAnalysis.InlineVarContext Merge(System.Collections.Generic.IList<JetBrains.ReSharper.Refactorings.InlineVar.RDAnalysis.InlineVarContext> contexts) { }
    }
    public class VBInlineVar : JetBrains.ReSharper.Refactorings.InlineVar.InlineVarBase
    {
        public VBInlineVar(JetBrains.ReSharper.Refactorings.InlineVar.InlineVarWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public override JetBrains.ReSharper.Refactorings.Inline.InlineHelper InlineHelper { get; }
        public override void ProcessReferenceWithContext(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Refactorings.Inline.CallSiteContext context, JetBrains.ReSharper.Refactorings.Inline.InlinedCallInfo info) { }
        public override void RemoveAssignment(JetBrains.ReSharper.Psi.Tree.ITreeNode expression) { }
        public override void RemoveVariableDeclaration(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration) { }
    }
    public class VBInlineVarAnalyser : JetBrains.ReSharper.Refactorings.InlineVar.RDAnalysis.InlineVarAnalyserBase
    {
        public VBInlineVarAnalyser(JetBrains.ReSharper.Refactorings.InlineVar.InlineVarWorkflow workflow) { }
        public override JetBrains.ReSharper.Psi.Tree.ITreeNode AssignmentExpression { get; }
        public override JetBrains.ReSharper.Psi.Tree.IExpression Expression { get; }
        public override bool InlineAll { get; set; }
        public override System.Collections.Generic.List<JetBrains.ReSharper.Psi.Resolve.IReference> References { get; }
        public JetBrains.ReSharper.Psi.VB.ControlFlow.IVBControlFlowGraf GetControlFlowGraf(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public override JetBrains.Util.Pair<bool, string> Run(JetBrains.ReSharper.Psi.IDeclaredElement variable, JetBrains.ReSharper.Psi.Tree.ITreeNode element, System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Resolve.IReference> foundReferences) { }
    }
    public class VBInlineVarInspector : JetBrains.ReSharper.Refactorings.VB.Util.RDInspectorOfVariable<JetBrains.ReSharper.Refactorings.InlineVar.RDAnalysis.InlineVarContext>
    {
        public VBInlineVarInspector(JetBrains.ReSharper.Psi.ControlFlow.Impl.ControlFlowGraf controlFlowGraf, JetBrains.ReSharper.Psi.ITypeOwner element, JetBrains.ReSharper.Psi.VB.Tree.IAssignmentStatement assignmentStatement) { }
        protected override bool CustomInspection(JetBrains.ReSharper.Psi.ControlFlow.IControlFlowElement controlFlowElement, JetBrains.ReSharper.Refactorings.InlineVar.RDAnalysis.InlineVarContext context, JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
    }
}
namespace JetBrains.ReSharper.Refactorings.VB.InplaceRefactorings
{
    
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class VBExtensionMethodOnPasteProvider : JetBrains.ReSharper.InplaceRefactorings.CutCopyPaste.ExtensionMethodImportOnPasteProviderBase
    {
        protected override JetBrains.ReSharper.InplaceRefactorings.CutCopyPaste.ExtensionMethodImportOnPasteProviderBase.ExtensionMethodReferenceData CreateReferenceData(string referenceName, JetBrains.ReSharper.Psi.IMethod targetExtensionMethod) { }
        protected override bool IsYourReference(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
    }
}
namespace JetBrains.ReSharper.Refactorings.VB.IntroducePartOfString
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
        public IntroducePartOfStringWorkflow(JetBrains.ProjectModel.ISolution solution, string aid) { }
        public JetBrains.ReSharper.Psi.VB.Tree.IVBLiteralExpression OwnerExpression { get; }
        public JetBrains.ReSharper.Psi.TreeTextRange SelectionTreeRange { get; }
        public override string Title { get; }
        public override JetBrains.ReSharper.Refactorings.Workflow.IRefactoringExecuter CreateRefactoring(JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public override bool Initialize(JetBrains.Application.DataContext.IDataContext context) { }
        public override bool IsAvailable(JetBrains.Application.DataContext.IDataContext context) { }
    }
}
namespace JetBrains.ReSharper.Refactorings.VB.IntroduceVariable
{
    
    public class IntroduceVariableResult
    {
        public readonly JetBrains.ReSharper.Psi.ITreeNodePointer<JetBrains.ReSharper.Psi.Tree.ITreeNode> NodePointer;
        public readonly JetBrains.ReSharper.Feature.Services.Refactorings.ReplaceInfo ReplaceInfo;
        public readonly string[] SuggestedNames;
        public IntroduceVariableResult(JetBrains.ReSharper.Feature.Services.Refactorings.ReplaceInfo replaceInfo, string[] suggestedNames, JetBrains.ReSharper.Psi.ITreeNodePointer<JetBrains.ReSharper.Psi.Tree.ITreeNode> nodePointer) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.VB.VBLanguage))]
    public class VBExpressionTypeSuggestion : JetBrains.ReSharper.Feature.Services.TypeSuggestion.ExpressionTypeSuggestionBase
    {
        public override JetBrains.ReSharper.Feature.Services.TypeSuggestion.SuggestedTypeKinds GetTypeKind(JetBrains.ReSharper.Psi.Tree.IExpression expression) { }
    }
    public class VBIntroduceVariable : JetBrains.ReSharper.Refactorings.IntroduceVariable.IntroduceVariableBase
    {
        public VBIntroduceVariable(JetBrains.ReSharper.Refactorings.IntroduceVariable.IntroduceLocalWorkflowBase workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public override JetBrains.ReSharper.Feature.Services.Refactorings.ReplaceInfo Process(System.Collections.Generic.List<JetBrains.ReSharper.Psi.Tree.ITreeNode> expressions, JetBrains.ReSharper.Psi.Tree.ITreeNode sourceExpression) { }
        public override void ValueSelectedCallback(JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.Hotspot hotspot) { }
    }
    public class VBIntroduceVariableHelper : JetBrains.ReSharper.Refactorings.IntroduceVariable.IntroduceVariableHelper
    {
        public override bool IsLanguageSupported { get; }
        public override bool CheckAvailability(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
    }
    public class VBIntroduceVariableUtil
    {
        public static JetBrains.ReSharper.Refactorings.VB.IntroduceVariable.IntroduceVariableResult IntroduceVariable(System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Tree.ITreeNode> expressions, JetBrains.ReSharper.Psi.Tree.ITreeNode sourceExpression, ref JetBrains.ReSharper.Psi.Tree.ITreeNode tag, bool preferImplicit) { }
    }
}
namespace JetBrains.ReSharper.Refactorings.VB.IntroField
{
    
    public class VBIntroField : JetBrains.ReSharper.Refactorings.IntroduceField.IntroFieldBase
    {
        public VBIntroField(JetBrains.ReSharper.Refactorings.IntroduceField.IntroFieldWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public override void AddAssignment(JetBrains.ReSharper.Psi.IParameter parameter, JetBrains.ReSharper.Psi.ITypeMember member, JetBrains.ReSharper.Psi.Tree.IExpression expression) { }
        public override JetBrains.ReSharper.Psi.ITypeMember AddField(JetBrains.ReSharper.Psi.Tree.ITypeDeclaration typeDeclaration, JetBrains.ReSharper.Psi.Tree.IExpression initExpression, System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Tree.ITreeNode> tags) { }
        public override JetBrains.ReSharper.Psi.Tree.IExpression GetInitializer(JetBrains.ReSharper.Psi.ILocalVariable variable) { }
        public override bool ReplaceUsages(System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Tree.ITreeNode> expressions, JetBrains.ReSharper.Psi.ITypeMember field, JetBrains.ReSharper.Psi.Tree.ITreeNode initializer) { }
        public override bool ReplaceVariableDeclaration(JetBrains.ReSharper.Psi.ILocalVariable variable, JetBrains.ReSharper.Psi.ITypeMember field, JetBrains.ReSharper.Psi.Tree.IExpression initializer) { }
    }
    public class VBIntroFieldAnalyser : JetBrains.ReSharper.Refactorings.IntroduceField.IntroFieldAnalyser
    {
        public override bool CanBeConstant(JetBrains.ReSharper.Psi.ILocalVariable variable) { }
        public override JetBrains.ReSharper.Psi.Tree.ITreeNode GetBlock(JetBrains.ReSharper.Psi.Tree.IDeclaration decl) { }
        public static JetBrains.ReSharper.Psi.Tree.ITreeNode GetBody(JetBrains.ReSharper.Psi.Tree.IDeclaration decl) { }
        public override JetBrains.ReSharper.Psi.Tree.ITreeNode GetInitializer(JetBrains.ReSharper.Psi.ILocalVariable variable) { }
        public override bool IsFromConstructor(JetBrains.ReSharper.Psi.ILocalVariable variable, bool isStatic) { }
        public override bool IsFromConstructor(JetBrains.ReSharper.Psi.Tree.ITreeNode element, bool isStatic) { }
    }
}
namespace JetBrains.ReSharper.Refactorings.VB.IntroParameter
{
    
    public class VBIntroParameter : JetBrains.ReSharper.Refactorings.IntroduceParameter.IntroduceParameterBase
    {
        public VBIntroParameter(JetBrains.ReSharper.Refactorings.IntroduceParameter.IntroduceParameterWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public override JetBrains.ReSharper.Refactorings.Inline.InlineHelper InlineHelper { get; }
        public override JetBrains.ReSharper.Psi.Resolve.IReference AddBaseClause(JetBrains.ReSharper.Psi.IDeclaredElement element) { }
        public override void AddParameter(JetBrains.ReSharper.Psi.IType type, string name, JetBrains.ReSharper.Psi.Tree.IDeclaration declaration, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution, JetBrains.ReSharper.Psi.Tree.ITreeNode defaultValue) { }
        public override void CallInline(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Refactorings.Inline.CallSiteContext context, JetBrains.ReSharper.Refactorings.Inline.InlinedCallInfo info, System.Collections.Generic.IList<string> lambdaParameterNames, int index) { }
        public override void FixOtherArguments(ref JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Refactorings.Inline.InlinedCallInfo info, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution) { }
        public int inc(ref int he) { }
        public override void RemoveLocalVariable(JetBrains.ReSharper.Psi.ILocalVariable variable) { }
        public override void ReplaceExpression(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public override bool ThisIsUsed(JetBrains.ReSharper.Psi.Tree.ITreeNode expression) { }
    }
    public class VBIntroParameterUtil
    {
        public static void FixArguments(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Refactorings.Inline.InlinedCallInfo info) { }
    }
}
namespace JetBrains.ReSharper.Refactorings.VB.Iterator2Function
{
    
    public class VBIterator2Function : JetBrains.ReSharper.Refactorings.Iterator2Function.Iterator2FunctionBase
    {
        public VBIterator2Function(JetBrains.ReSharper.Refactorings.Iterator2Function.Iterator2FunctionWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        protected override void CollectListNameSuggestions(JetBrains.ReSharper.Psi.Tree.IDeclaration iterator, JetBrains.ReSharper.Psi.Naming.Extentions.EntryOptions options, JetBrains.ReSharper.Psi.Naming.Extentions.INamesCollection suggestion) { }
        protected override JetBrains.ReSharper.Psi.IDeclaredType GetDeclaredElementReturnType(JetBrains.ReSharper.Psi.IDeclaredElement iterator) { }
        public override JetBrains.ReSharper.Feature.Services.Refactorings.ReplaceInfo ProcessIterator(JetBrains.ReSharper.Psi.Tree.IDeclaration iterator, JetBrains.ReSharper.Psi.IType elementType, bool returnsEnumerator, JetBrains.Application.Progress.IProgressIndicator pi) { }
    }
}
namespace JetBrains.ReSharper.Refactorings.VB.JetBrains.ReSharper.Refactorings.VB.InlineParameter
{
    
    public class VBInlineParameter : JetBrains.ReSharper.Refactorings.InlineParameter.InlineParameterBase
    {
        public VBInlineParameter(JetBrains.ReSharper.Refactorings.InlineParameter.InlineParameterWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
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
    public class VbInlineParameterHelper : JetBrains.ReSharper.Refactorings.InlineParameter.InlineParameterHelper
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
        public override JetBrains.ReSharper.Psi.Tree.IExpression GetQualifier(JetBrains.ReSharper.Psi.Tree.IArgumentsOwner owner, ref bool hasThisQualifier) { }
        public override JetBrains.ReSharper.Psi.Resolve.IReference GetReference(JetBrains.ReSharper.Psi.Tree.IArgumentsOwner argumentsOwner) { }
        public override bool IsThisExpression(JetBrains.ReSharper.Psi.Tree.IArgument argument) { }
        public override bool IsThisExpression(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public override JetBrains.ReSharper.Psi.Tree.ITreeNode Qualify(JetBrains.ReSharper.Psi.Tree.ITreeNode element, string name, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Refactorings.InlineParameter.Data.ParameterOwnerUsageUpdater> updaters, JetBrains.ReSharper.Refactorings.InlineParameter.Data.SuggestedParameter thisSuggestion) { }
        public override JetBrains.ReSharper.Psi.Tree.ITreeNode ReplaceThisReferences(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.IDeclaredType type, JetBrains.ReSharper.Psi.ExtensionsAPI.ReferenceIdentitySaver saver, JetBrains.Util.Key<string> key, ref bool hasUnresolvedThis, bool hasThisQualifier) { }
    }
}
namespace JetBrains.ReSharper.Refactorings.VB.JetBrains.ReSharper.Refactorings.VB.Rename
{
    
    [JetBrains.ReSharper.Psi.ShellFeaturePartAttribute()]
    public class VBAnonymousPropertyRenamesFactory : JetBrains.ReSharper.Refactorings.Rename.AtomicRenamesFactory
    {
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Refactorings.RenameModel.AtomicRenameBase> CreateAtomicRenames(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, string newName, bool doNotAddBindingConflicts) { }
        public override bool IsApplicable(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.VB.VBLanguage))]
    public class VBRenameHelper : JetBrains.ReSharper.Refactorings.Rename.RenameHelperBase
    {
        public override bool IsLanguageSupported { get; }
        public override System.Collections.Generic.IList<JetBrains.ReSharper.Refactorings.Conflicts.IConflictSearcher> AdditionalConflictsSearchers(JetBrains.ReSharper.Psi.IDeclaredElement element, string newName) { }
        public override void AdditionalReferenceProcessing(JetBrains.ReSharper.Psi.IDeclaredElement newTarget, JetBrains.ReSharper.Psi.Resolve.IReference reference, System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.Resolve.IReference> newReferences) { }
        public override JetBrains.ReSharper.Psi.Resolve.IReference BindReferenceToNamespace(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.INamespace ns) { }
        public override bool DoNotProcess(JetBrains.ReSharper.Psi.IDeclaredElement element) { }
        public override JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage GetPageBeforeInitial(JetBrains.ReSharper.Refactorings.Rename.RenameWorkflow renameWorkflow) { }
        public override bool IsLocalRename(JetBrains.ReSharper.Psi.IDeclaredElement primevalDeclaredElement) { }
        public override void JoinTransformAnonymous(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public override JetBrains.ReSharper.Psi.Resolve.IReference TransformProjectedInitializer(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
    }
    [JetBrains.ReSharper.Psi.ShellFeaturePartAttribute()]
    public class VBSpecificElementsRenamesFactory : JetBrains.ReSharper.Refactorings.Rename.AtomicRenamesFactory
    {
        public override JetBrains.ReSharper.Refactorings.RenameModel.RenameAvailabilityCheckResult CheckRenameAvailability(JetBrains.ReSharper.Psi.IDeclaredElement element) { }
        public override bool IsApplicable(JetBrains.ReSharper.Psi.IDeclaredElement element) { }
    }
}
namespace JetBrains.ReSharper.Refactorings.VB.MoveMembers
{
    
    public class VBExtractInterface : JetBrains.ReSharper.Refactorings.MoveMembers.ImplBaseUp.VBExtractInterfaceBase
    {
        public VBExtractInterface(JetBrains.ReSharper.Refactorings.MoveMembers.ImplBaseUp.PullUpBaseWorkflow<JetBrains.ReSharper.Refactorings.MoveMembers.ImplExtractInterface.ExtractInterfaceStaticAnalyser, JetBrains.ReSharper.Refactorings.MoveMembers.ImplExtractInterface.IExtractInterfaceItemInfo> workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public override JetBrains.ReSharper.Refactorings.MoveMembers.Common.MoveMembersHelper<JetBrains.ReSharper.Refactorings.MoveMembers.ImplExtractInterface.IExtractInterfaceItemInfo> GetHelper() { }
        public override bool IsInstanceSpecificEventAccess(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
    }
    public class VBExtractSuperclass : JetBrains.ReSharper.Refactorings.MoveMembers.ImplBaseUp.VBExtractSuperclassBase
    {
        public VBExtractSuperclass(JetBrains.ReSharper.Refactorings.MoveMembers.ImplBaseUp.PullUpBaseWorkflow<JetBrains.ReSharper.Refactorings.MoveMembers.ImplExtractSuperclass.ExtractSuperclassStaticAnalyser, JetBrains.ReSharper.Refactorings.MoveMembers.ImplExtractSuperclass.IExtractSuperclassItemInfo> workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public override JetBrains.ReSharper.Refactorings.MoveMembers.Common.MoveMembersHelper<JetBrains.ReSharper.Refactorings.MoveMembers.ImplExtractSuperclass.IExtractSuperclassItemInfo> GetHelper() { }
        public override bool IsInstanceSpecificEventAccess(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
    }
    public class VBMoveMembersHelper<MEMBER_INFO> : JetBrains.ReSharper.Refactorings.MoveMembers.Common.MoveMembersHelper<MEMBER_INFO>
        where MEMBER_INFO : JetBrains.ReSharper.Refactorings.CommonUI.IMemberInfo
    {
        public VBMoveMembersHelper(JetBrains.ReSharper.Refactorings.MoveMembers.Common.IMoveMembersExecuter executer) { }
        public override void AddBaseInterface(JetBrains.ReSharper.Psi.ITypeElement element, JetBrains.ReSharper.Psi.IDeclaredType info) { }
        public override void AddImplementsSpecification(JetBrains.ReSharper.Psi.Tree.IDeclaration decl, JetBrains.ReSharper.Psi.ITypeElement element, bool nameIsItem, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public override void CheckConstructorReferenceConflict(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public override JetBrains.ReSharper.Psi.Tree.ITypeDeclaration CreateTargetTypeElement(string name, JetBrains.ReSharper.Psi.ITypeElement sourceClass, System.Collections.Generic.List<JetBrains.ReSharper.Psi.ITypeParameter> parameters, bool createClass, bool preserveAccessRigths) { }
        public override System.Collections.Generic.IList<JetBrains.Util.Pair<MEMBER_INFO, JetBrains.ReSharper.Psi.Tree.IDeclaration>> CutDeclarations(System.Collections.Generic.IEnumerable<MEMBER_INFO> memberInfos, JetBrains.Application.Progress.SubProgressIndicator pi) { }
        public override void GenerateConstructors(JetBrains.ReSharper.Psi.ITypeElement targetType, JetBrains.ReSharper.Psi.Tree.ITypeDeclaration typeDeclaration, JetBrains.ReSharper.Psi.Pointers.IDeclaredElementPointer<JetBrains.ReSharper.Psi.IConstructor> baseConstructor) { }
        public override JetBrains.ReSharper.Psi.IConstructor GetBaseConstructorDeclarationToInsert(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration) { }
        public override JetBrains.ReSharper.Psi.Tree.ITypeDeclaration InsertSibling(JetBrains.ReSharper.Psi.Tree.ITypeDeclaration decl, JetBrains.ReSharper.Psi.Tree.ITypeDeclaration sourceClass) { }
        public override JetBrains.ReSharper.Psi.Tree.ITypeDeclaration InsertToNewFile(JetBrains.ReSharper.Psi.Tree.ITypeDeclaration decl, JetBrains.ReSharper.Psi.Tree.ITypeDeclaration sourceClass, string ns, JetBrains.ProjectModel.IProjectFile fileNearby) { }
        public override bool IsQualifierValid(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public override void MakeOverride(JetBrains.ReSharper.Psi.ITypeMember member) { }
        public override void MakeProtected(JetBrains.ReSharper.Psi.IDeclaredElement element) { }
        public override void MakePublic(JetBrains.ReSharper.Psi.ITypeMember member) { }
        public override void MakeTypeElementAbstract(JetBrains.ReSharper.Psi.ITypeElement element) { }
        public override void PasteDeclarations(System.Collections.Generic.IList<JetBrains.Util.Pair<MEMBER_INFO, JetBrains.ReSharper.Psi.Tree.IDeclaration>> declarations, JetBrains.ReSharper.Psi.ITypeElement targetType, JetBrains.ProjectModel.IProjectFile projectFile, JetBrains.ReSharper.Psi.Tree.ITypeDeclaration targetTypeDeclaration, JetBrains.Application.Progress.SubProgressIndicator pi) { }
        public override void RemoveDeclaration(JetBrains.ReSharper.Psi.ITypeMember member) { }
        public override void RemoveSuperType(JetBrains.ReSharper.Psi.Tree.ITypeDeclaration typeDeclaration, JetBrains.ReSharper.Psi.IDeclaredType type) { }
        public override void SetSuperclass(JetBrains.ReSharper.Psi.Tree.ITypeDeclaration sourceClass, JetBrains.ReSharper.Psi.ITypeElement newSuper, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution) { }
        public override bool TryProcessMultyFieldForResolve(JetBrains.ReSharper.Psi.IRecursiveElementProcessor collector, JetBrains.ReSharper.Psi.Tree.IDeclaration declaration) { }
    }
    public class VBPullUp : JetBrains.ReSharper.Refactorings.MoveMembers.ImplBaseUp.VBPullUpBase
    {
        public VBPullUp(JetBrains.ReSharper.Refactorings.MoveMembers.ImplPullUp.PullUpWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public override JetBrains.ReSharper.Refactorings.MoveMembers.Common.MoveMembersHelper<JetBrains.ReSharper.Refactorings.MoveMembers.ImplPullUp.IPullUpItemInfo> GetHelper() { }
        public override bool IsInstanceSpecificEventAccess(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
    }
    public class VBPushDown : JetBrains.ReSharper.Refactorings.MoveMembers.ImplPushDown.PushDownBase
    {
        public VBPushDown(JetBrains.ReSharper.Refactorings.MoveMembers.ImplPushDown.PushDownWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public override bool CheckConflictsWithTargetClassName(JetBrains.ReSharper.Psi.ITypeElement element, string name) { }
        public override JetBrains.ReSharper.Refactorings.MoveMembers.Common.MoveMembersHelper<JetBrains.ReSharper.Refactorings.MoveMembers.ImplPushDown.IPushDownItemInfo> GetHelper() { }
        public override bool IsInstanceSpecificEventAccess(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
    }
}
namespace JetBrains.ReSharper.Refactorings.VB.MoveTypeToOuterScope
{
    
    public class VBMoveTypeToOuterScope : JetBrains.ReSharper.Refactorings.MoveInnerClass.MoveTypeToOuterScopeImplBase<JetBrains.ReSharper.Psi.VB.Tree.IVBNestedTypeDeclaration, JetBrains.ReSharper.Psi.VB.Tree.IClassLikeDeclaration>
    {
        protected override JetBrains.ReSharper.Psi.VB.Tree.IVBNestedTypeDeclaration CutDeclaration(JetBrains.ReSharper.Psi.VB.Tree.IVBNestedTypeDeclaration declaration) { }
        protected override JetBrains.ReSharper.Psi.AccessRights GetAccessRights(JetBrains.ReSharper.Psi.VB.Tree.IVBNestedTypeDeclaration typeDeclaration) { }
        protected override JetBrains.ReSharper.Psi.AccessRights GetAccessRights(JetBrains.ReSharper.Psi.VB.Tree.IClassLikeDeclaration typeDeclaration) { }
        protected override JetBrains.ReSharper.Psi.VB.Tree.IClassLikeDeclaration GetContainingTypeDeclaration(JetBrains.ReSharper.Psi.VB.Tree.IVBNestedTypeDeclaration declaration) { }
        protected override JetBrains.ReSharper.Psi.VB.Tree.IVBNestedTypeDeclaration PasteDeclaration(JetBrains.ReSharper.Psi.VB.Tree.IVBNestedTypeDeclaration declarationCopy, JetBrains.ReSharper.Psi.VB.Tree.IClassLikeDeclaration containingDeclaration) { }
        protected override void SetAccessRights(JetBrains.ReSharper.Psi.VB.Tree.IVBNestedTypeDeclaration typeDeclaration, JetBrains.ReSharper.Psi.AccessRights accessRights) { }
    }
}
namespace JetBrains.ReSharper.Refactorings.VB.Property2Auto.Analysis
{
    
    public class AssignmentsToFieldContext
    {
        public JetBrains.ReSharper.Refactorings.VB.Property2Auto.Analysis.States FieldState { get; }
        public void Assigned() { }
        public JetBrains.ReSharper.Refactorings.VB.Property2Auto.Analysis.AssignmentsToFieldContext Clone() { }
        public bool Equals(JetBrains.ReSharper.Refactorings.VB.Property2Auto.Analysis.AssignmentsToFieldContext obj) { }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
        public void MergeWith(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Refactorings.VB.Property2Auto.Analysis.AssignmentsToFieldContext> contexts) { }
        public void Read() { }
    }
    public class AssignmentsToFieldContextFactory : JetBrains.ReSharper.Psi.ControlFlow.IControlFlowContextFactory<JetBrains.ReSharper.Refactorings.VB.Property2Auto.Analysis.AssignmentsToFieldContext>
    {
        public JetBrains.ReSharper.Refactorings.VB.Property2Auto.Analysis.AssignmentsToFieldContext InitialContext { get; }
        public JetBrains.ReSharper.Refactorings.VB.Property2Auto.Analysis.AssignmentsToFieldContext CloneContext(JetBrains.ReSharper.Refactorings.VB.Property2Auto.Analysis.AssignmentsToFieldContext context) { }
        public JetBrains.ReSharper.Refactorings.VB.Property2Auto.Analysis.AssignmentsToFieldContext Merge(System.Collections.Generic.IList<JetBrains.ReSharper.Refactorings.VB.Property2Auto.Analysis.AssignmentsToFieldContext> contexts) { }
    }
    public class AssignmentsToFieldInspector : JetBrains.ReSharper.Psi.ControlFlow.Impl.ControlFlowGrafInspector<JetBrains.ReSharper.Refactorings.VB.Property2Auto.Analysis.AssignmentsToFieldContext>
    {
        public AssignmentsToFieldInspector(JetBrains.ReSharper.Psi.ControlFlow.Impl.ControlFlowGraf controlFlowGraf, JetBrains.ReSharper.Refactorings.Property2Auto.Property2AutoRefactoring executer) { }
        protected override void InspectLeafElementAndSetContextToExits(JetBrains.ReSharper.Psi.ControlFlow.IControlFlowElement controlFlowElement, JetBrains.ReSharper.Refactorings.VB.Property2Auto.Analysis.AssignmentsToFieldContext context) { }
    }
    public enum States
    {
        MayNotUsed = 0,
        ReadBeforeWrite = 1,
        Write = 2,
    }
}
namespace JetBrains.ReSharper.Refactorings.VB.Property2Auto
{
    
    public class VBProperty2Auto : JetBrains.ReSharper.Refactorings.Property2Auto.Property2AutoBase
    {
        public VBProperty2Auto(JetBrains.ReSharper.Refactorings.Property2Auto.Property2AutoWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public override void CheckInitializer() { }
        public override JetBrains.ReSharper.Psi.IProperty CreateDeclaration(JetBrains.ReSharper.Psi.AccessRights propertyRights, JetBrains.ReSharper.Psi.AccessRights setterRights, JetBrains.ReSharper.Psi.AccessRights getterRights) { }
        public override void RemoveOldDeclarations() { }
        public override void ScanForConflicts(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public override void ScanUsagesFromStructConstructor(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public class AssignmentStatementsSearcher : JetBrains.ReSharper.Psi.IRecursiveElementProcessor
        {
            public System.Collections.Generic.List<JetBrains.ReSharper.Psi.VB.Tree.IAssignmentStatement> Expressions;
            public AssignmentStatementsSearcher() { }
            public bool ProcessingIsFinished { get; }
            public bool InteriorShouldBeProcessed(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
            public void ProcessAfterInterior(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
            public void ProcessBeforeInterior(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        }
    }
    public class VBProperty2AutoChecker : JetBrains.ReSharper.Refactorings.Property2Auto.IProperty2AutoChecker
    {
        public bool IsPropertyWithBackingField(JetBrains.ReSharper.Psi.IProperty property, ref JetBrains.ReSharper.Psi.IField field) { }
    }
}
namespace JetBrains.ReSharper.Refactorings.VB.Property2FunctionScope
{
    
    public class VBPropertyToFunction : JetBrains.ReSharper.Refactorings.Property2Function.Property2FunctionBase
    {
        public VBPropertyToFunction(JetBrains.ReSharper.Refactorings.Property2Function.Property2FunctionWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        protected override bool AreEquals(string name1, string name2) { }
        public override void ProcessProperty(JetBrains.ReSharper.Psi.IDeclaredElement propOrMethod) { }
        protected override bool SkipIndexerReference(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public override void TryMakeConflictForNotExpression(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public override bool TryTransformMethodCall(JetBrains.ReSharper.Psi.Tree.IExpression expression) { }
    }
}
namespace JetBrains.ReSharper.Refactorings.VB.PushPullTool.Fixes
{
    
    public class PullThroughCtorFix : JetBrains.ReSharper.Refactorings.PushPullTool.Fixes.FixNode
    {
        public PullThroughCtorFix(JetBrains.ReSharper.Refactorings.PushPullTool.CallNode node, JetBrains.ReSharper.Psi.ITypeElement typeElement) { }
        public JetBrains.ReSharper.Psi.ITypeElement TypeElement { get; }
        public override void CreateParentNodes(JetBrains.ReSharper.Psi.IParametersOwner parametersOwner, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Resolve.IReference> references) { }
        public override bool ExecuteFix(JetBrains.Application.Progress.IProgressIndicator pi) { }
        public override JetBrains.ReSharper.Refactorings.PushPullTool.Fixes.FixPresentation GetPresentation(JetBrains.ReSharper.Refactorings.PushPullTool.CallPresentation callpresentation) { }
        public override void ReloadPresentation() { }
    }
}
namespace JetBrains.ReSharper.Refactorings.VB.Rename.DerivedRenames
{
    
    [JetBrains.ReSharper.Refactorings.Rename.DerivedRenamesEvaluatorAttribute()]
    public class ConstructorParameterRenameEvaluator : JetBrains.ReSharper.Refactorings.Rename.IDerivedRenamesEvaluator
    {
        public bool SuggestedElementsHaveDerivedName { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IDeclaredElement> CreateFromElement(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IDeclaredElement> CreateFromReference(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
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
    [JetBrains.ReSharper.Refactorings.Rename.DerivedRenamesEvaluatorAttribute()]
    public class TypeDerivedRenamesEvaluator : JetBrains.ReSharper.Refactorings.Rename.IDerivedRenamesEvaluator
    {
        public bool SuggestedElementsHaveDerivedName { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IDeclaredElement> CreateFromElement(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IDeclaredElement> CreateFromReference(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
    }
}
namespace JetBrains.ReSharper.Refactorings.VB.RenameNamespace
{
    
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.VB.VBLanguage))]
    public class VBRenameNamespace : JetBrains.ReSharper.Refactorings.RenameNamespace.IRenameNamespace
    {
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Refactorings.RenameNamespace.INamespaceDeclarationUpdater> BuildNamespaceDeclarationUpdatersForFile(JetBrains.ReSharper.Psi.INamespace @namespace, JetBrains.ReSharper.Psi.Tree.IFile file, string newName) { }
        public JetBrains.ReSharper.Refactorings.Conflicts.IConflictSearcher GetConflictSearcher(JetBrains.ReSharper.Psi.INamespace @namespace, System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.IReferencePointer> references, string newName) { }
    }
}
namespace JetBrains.ReSharper.Refactorings.VB.SafeDeleteFolder
{
    
    public class VBSafeDeleteFolderHelper : JetBrains.ReSharper.Refactorings.SafeDeleteFolder.SafeDeleteFolderHelperBase
    {
        public override bool IsLanguageSupported { get; }
        public override System.Collections.Generic.IList<JetBrains.ReSharper.Psi.IDeclaredElement> GetExternalDeclaredElements(JetBrains.ReSharper.Psi.Tree.IFile file) { }
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Tree.ITreeNode> GetUsingsFromFile(JetBrains.ReSharper.Psi.Tree.IFile file, System.Collections.Generic.IList<JetBrains.ReSharper.Psi.INamespace> namespaces) { }
        public override void RemoveUsing(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
    }
}
namespace JetBrains.ReSharper.Refactorings.VB.SafeDeleteTheSecond
{
    
    public class VBSafeDelete : JetBrains.ReSharper.Refactorings.SafeDeleteTheSecond.SafeDeleteBase
    {
        public VBSafeDelete(JetBrains.ReSharper.Refactorings.SafeDeleteTheSecond.SafeDeleteWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
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
        public override void RemoveImplicitAccessor(JetBrains.ReSharper.Psi.IAccessor accessor) { }
        public override bool RemoveInterfaceMemberSpecification(JetBrains.ReSharper.Psi.Resolve.IReference reference, bool remove) { }
        public override void RemoveNewRedundantUsings(JetBrains.ReSharper.Psi.Tree.IFile file, System.Collections.Generic.JetHashSet<JetBrains.ReSharper.Psi.Tree.ITreeNode> oldUsings, JetBrains.Application.Progress.SubProgressIndicator pi) { }
        public override bool RemoveSubscription(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public override void RemoveTypeParameterDeclaration(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration) { }
        public override bool ReplaceExplicitImplementation(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public override void ReplaceExplicitImplementation(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration) { }
        public override void SaveUnusedUsings(JetBrains.ReSharper.Psi.Tree.IFile file) { }
        public override void SetBaseTypes(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.IDeclaredType baseClass, System.Collections.Generic.IList<JetBrains.ReSharper.Psi.IDeclaredType> allSuperTypes, JetBrains.ReSharper.Psi.ITypeElement baseElementToRemove) { }
        public override void TryRemoveNullChecking(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration) { }
    }
    public class VBSafeDeleteHelper : JetBrains.ReSharper.Refactorings.SafeDeleteTheSecond.SafeDeleteHelperUnsupported
    {
        public override bool IsLanguageSupported { get; }
        public override bool CanBeRemoved(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration) { }
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Tree.ITreeNode> GetUsingsFromFile(JetBrains.ReSharper.Psi.Tree.IFile file, System.Collections.Generic.IList<JetBrains.ReSharper.Psi.INamespace> namespaces) { }
        public override bool IsBaseClassSpecifier(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public override bool IsInterfaceImplementationSpecifier(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public override void RemoveUsing(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
    }
}
namespace JetBrains.ReSharper.Refactorings.VB.Static2Extension
{
    
    public class VBStatic2Extension : JetBrains.ReSharper.Refactorings.Static2Extension.Static2ExtensionBase
    {
        public VBStatic2Extension(JetBrains.ReSharper.Refactorings.Static2Extension.Static2ExtensionWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public override void MakeCallExtension(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public override void MakeCallPlainStatic(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
    }
}
namespace JetBrains.ReSharper.Refactorings.VB.TransformOutParameters
{
    
    public class VBTransformOutParametersHelper : JetBrains.ReSharper.Refactorings.TransformOutParameters.TransformOutParametersHelper
    {
        public const string TUPLE_METHOD_CREATE = "Create";
        public const string TUPLE_METHOD_ITEM = "Item";
        public VBTransformOutParametersHelper(JetBrains.ReSharper.Refactorings.TransformOutParameters.TransformOutParametersWorkflow workflow) { }
        public override bool IsLanguageSupported { get; }
        protected override System.Windows.Documents.Run CreateTypeElementRun(string name, JetBrains.ReSharper.Refactorings.TransformOutParameters.HighlightingParameters highlighting) { }
        public override JetBrains.ReSharper.Psi.IMethod GetIMethodForOutParamByNode([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode node) { }
        protected override string GetLineCommentPrefix() { }
        public override System.Collections.Generic.List<object> GetViewModel(JetBrains.ReSharper.Psi.IMethod method, JetBrains.ReSharper.Refactorings.TransformOutParameters.HighlightingParameters highlighting, System.Func<JetBrains.ReSharper.Psi.IParameter, object, object> parameterViewModelTransformer, bool isModelForTransformedMethod) { }
        public override System.Windows.Controls.TextBlock GetViewModel(JetBrains.ReSharper.Psi.IParameter param, JetBrains.ReSharper.Refactorings.TransformOutParameters.HighlightingParameters highlighting, string punctuationSuffix = null) { }
        public override System.Windows.UIElement GetViewModelAfterParameters(JetBrains.ReSharper.Psi.IMethod method, JetBrains.ReSharper.Refactorings.TransformOutParameters.HighlightingParameters highlighting) { }
        public override System.Windows.UIElement GetViewModelBeforeParameters(JetBrains.ReSharper.Psi.IMethod method, JetBrains.ReSharper.Refactorings.TransformOutParameters.HighlightingParameters highlighting) { }
        public override bool IsOutParameter(JetBrains.ReSharper.Psi.IParameter parameter) { }
        public override void JoinDeclarationsAndAssignments(JetBrains.ReSharper.Psi.Tree.IDeclaration parametersOwnerDeclaration, System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.Tree.IStatement> statementsToUse, JetBrains.ReSharper.Refactorings.TransformOutParameters.TransformOutParametersRefactoring transformOutParametersRefactoring) { }
        public override void RefactoringPostVerificationStage(JetBrains.ReSharper.Psi.IMethod method, JetBrains.ReSharper.Refactorings.TransformOutParameters.TransformOutParametersRefactoring refactoring) { }
        public override void TransformDeclaration(JetBrains.ReSharper.Psi.IMethod method, JetBrains.ReSharper.Psi.Tree.IDeclaration declaration, JetBrains.ReSharper.Refactorings.TransformOutParameters.TransformOutParametersRefactoring refactoring) { }
        public override void TransformReference([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.IType initialReturnType, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Refactorings.TransformOutParameters.TransformOutParametersRefactoring refactoring) { }
    }
}
namespace JetBrains.ReSharper.Refactorings.VB.UseBaseType
{
    
    public class VBConstraintSearcherUtil : JetBrains.ReSharper.Refactorings.UseBaseType.ConstraintSearch.ConstraintSearcherUtil
    {
        public VBConstraintSearcherUtil(JetBrains.ReSharper.Refactorings.UseBaseType.UseBaseTypeRefactoring executer) { }
        public JetBrains.ReSharper.Refactorings.UseBaseType.Dependences.GraphBuilder Builder { get; }
        public override JetBrains.ReSharper.Psi.Tree.ITreeNode GetDirectlyUsedElement(JetBrains.ReSharper.Psi.Tree.ITreeNode someElement) { }
        public override void ProcessUp(JetBrains.ReSharper.Psi.Tree.ITreeNode directlyUsedElement, JetBrains.ReSharper.Refactorings.UseBaseType.TypeUsageSearch.TypeElementUsage usage) { }
        public override bool TryFindArgumentConstraint(JetBrains.ReSharper.Psi.Tree.ITreeNode preparedElement, ref JetBrains.ReSharper.Psi.IParameter parameter) { }
        public override bool TryFindAssignmentConstraint(JetBrains.ReSharper.Psi.Tree.ITreeNode preparedElement, ref JetBrains.ReSharper.Psi.IDeclaredElement assignmentDest) { }
        public override bool TryFindInitializerConstraint(JetBrains.ReSharper.Psi.Tree.ITreeNode preparedElement, ref JetBrains.ReSharper.Psi.IDeclaredElement initializedElement) { }
        public override bool TryFindSimpleReturnConstraint(JetBrains.ReSharper.Psi.Tree.ITreeNode preparedElement, ref JetBrains.ReSharper.Psi.ITypeMember returnFromMember) { }
        public override bool TryFindTypeMemberConstraint(JetBrains.ReSharper.Psi.Tree.ITreeNode preparedElement, ref JetBrains.ReSharper.Psi.ITypeMember memberCalled, ref JetBrains.ReSharper.Psi.Tree.ExpressionAccessType memberAccessType) { }
    }
    public class VBTypeUsageSearcherUtil : JetBrains.ReSharper.Refactorings.UseBaseType.TypeUsageSearch.TypeUsageSearcherUtil
    {
        public override int GetArrayRank(JetBrains.ReSharper.Psi.Tree.ITreeNode typUsageElement) { }
        public override bool TryFindChilidTypeElement(JetBrains.ReSharper.Psi.Resolve.IReference reference, ref JetBrains.ReSharper.Psi.ITypeElement childTypeElement) { }
        public override bool TryFindConstrainedParameter(JetBrains.ReSharper.Psi.Resolve.IReference reference, ref JetBrains.ReSharper.Psi.ITypeParameter parameter) { }
        public override bool TryFindDelegateDeclaration(JetBrains.ReSharper.Psi.Resolve.IReference reference, ref JetBrains.ReSharper.Psi.ITypeElement delegateElement) { }
        public override bool TryFindTypeParameterOwner(JetBrains.ReSharper.Psi.Resolve.IReference reference, ref JetBrains.ReSharper.Psi.Tree.ITreeNode typeUsageElement, ref JetBrains.ReSharper.Psi.ITypeParameter parameter) { }
    }
    public class VBUseBaseType : JetBrains.ReSharper.Refactorings.UseBaseType.UseBaseTypeBase
    {
        public VBUseBaseType(JetBrains.ReSharper.Refactorings.UseBaseType.UseBaseTypeWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public override bool MethodGroupTypeMatch { get; }
        public override JetBrains.ReSharper.Psi.Resolve.IReference BindUsage(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public override bool CheckConstraintElement(JetBrains.ReSharper.Psi.IDeclaredElement element) { }
        public override bool GetCastExpressionExpression(JetBrains.ReSharper.Psi.Resolve.IReference reference, ref JetBrains.ReSharper.Psi.Tree.IExpression expression) { }
        public override JetBrains.ReSharper.Refactorings.UseBaseType.ConstraintSearch.ConstraintSearcherUtil GetConstraintSearcherUtil() { }
        public override bool GetConstructedExpression(JetBrains.ReSharper.Psi.Resolve.IReference reference, ref JetBrains.ReSharper.Psi.Tree.IExpression expression) { }
        public override JetBrains.ReSharper.Psi.IDeclaredElement[] GetDeclaredElements(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public override JetBrains.ReSharper.Psi.IDeclaredElement GetDelegateDeclaration(JetBrains.ReSharper.Psi.Tree.ITreeNode directlyUsedElement) { }
        public override bool GetIsExpression(JetBrains.ReSharper.Psi.Resolve.IReference reference, ref JetBrains.ReSharper.Psi.Tree.IExpression expression) { }
        public override bool GetTypeOfExpression(JetBrains.ReSharper.Psi.Resolve.IReference reference, ref JetBrains.ReSharper.Psi.Tree.IExpression expression) { }
        public override JetBrains.ReSharper.Refactorings.UseBaseType.TypeUsageSearch.TypeUsageSearcherUtil GetTypeUsageSearcherUtil() { }
    }
}
namespace JetBrains.ReSharper.Refactorings.VB.Util
{
    
    public class ClassLikeDeclarationReplacer
    {
        public static JetBrains.ReSharper.Refactorings.VB.Util.ClassLikeDeclarationReplacer.ITag Replace(JetBrains.ReSharper.Psi.VB.Tree.IClassLikeDeclaration decl, JetBrains.ReSharper.Psi.VB.Tree.IClassLikeDeclaration newDecl, JetBrains.ReSharper.Refactorings.VB.Util.ReplaceActions action) { }
        public abstract class ITag : System.IDisposable
        {
            protected readonly JetBrains.ReSharper.Refactorings.VB.Util.ReplaceActions myAction;
            protected JetBrains.ReSharper.Psi.VB.Tree.IClassLikeDeclaration myNewDecl;
            protected JetBrains.ReSharper.Psi.VB.Tree.IClassLikeDeclaration myOldDecl;
            protected ITag(JetBrains.ReSharper.Psi.VB.Tree.IClassLikeDeclaration oldDecl, JetBrains.ReSharper.Psi.VB.Tree.IClassLikeDeclaration newDecl, JetBrains.ReSharper.Refactorings.VB.Util.ReplaceActions aaction) { }
            public JetBrains.ReSharper.Refactorings.VB.Util.ReplaceActions Action { get; }
            public JetBrains.ReSharper.Psi.VB.Tree.IClassLikeDeclaration NewDecl { get; }
            public abstract void Dispose();
        }
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
    public class VBAbstractor
    {
        public VBAbstractor(JetBrains.ReSharper.Refactorings.MoveMembers.Common.IMoveMembersExecuter executer, JetBrains.ReSharper.Psi.Modules.IPsiModule module) { }
        public T MakeDeclaration<T>(JetBrains.ReSharper.Psi.Tree.IDeclaration initialDecl, bool abstr)
            where T :  class, JetBrains.ReSharper.Psi.Tree.IDeclaration { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.VB.VBLanguage))]
    public class VBConstructionUtil : JetBrains.ReSharper.Refactorings.Util.ConstructionUtil
    {
        public override JetBrains.ReSharper.Psi.ITypeElement AddClassBefore(string className, JetBrains.ReSharper.Psi.Tree.IDeclaration tag, bool topLevel, bool isClass) { }
        public override JetBrains.ReSharper.Psi.ITypeElement AddClassBeforeFromMember(string className, JetBrains.ReSharper.Psi.ITypeMember tag, bool topLevel, bool isClass) { }
        public override JetBrains.ReSharper.Psi.Tree.IDeclaration AddEmptyConstructor(JetBrains.ReSharper.Psi.ITypeElement @class, JetBrains.ReSharper.Psi.Tree.IDeclaration tag) { }
        public override JetBrains.ReSharper.Psi.Tree.IDeclaration AddField(JetBrains.ReSharper.Psi.ITypeElement @class, JetBrains.ReSharper.Psi.Naming.Impl.NameRoot name, JetBrains.ReSharper.Psi.IType type, JetBrains.ReSharper.Psi.Tree.IDeclaration tag, JetBrains.ReSharper.Psi.AccessRights accessRights, System.Collections.Generic.JetHashSet<string> namesSet) { }
        public override JetBrains.ReSharper.Psi.IParameter AddFirstParameter(JetBrains.ReSharper.Psi.IParametersOwner owner, string name, JetBrains.ReSharper.Psi.IDeclaredType type) { }
        public override JetBrains.ReSharper.Psi.Tree.IDeclaration AddProperty(JetBrains.ReSharper.Psi.ITypeElement @class, JetBrains.ReSharper.Psi.Tree.IDeclaration fieldDeclaration, JetBrains.ReSharper.Psi.Naming.Impl.NameRoot basicName, JetBrains.ReSharper.Psi.Tree.IDeclaration tag, bool isWritable, JetBrains.ReSharper.Psi.AccessRights accessRights, System.Collections.Generic.JetHashSet<string> namesSet) { }
        protected override void AddToCollection(System.Collections.Generic.JetHashSet<string> namesSet, string fieldName) { }
        public override JetBrains.ReSharper.Psi.ITypeMember AddTypeMemberDeclaration(JetBrains.ReSharper.Psi.ITypeElement element, JetBrains.ReSharper.Psi.Tree.IDeclaration declaration, JetBrains.ReSharper.Psi.Tree.IDeclaration tag, bool after) { }
        public override JetBrains.ReSharper.Psi.Tree.IDeclaration AddTypeParameter(JetBrains.ReSharper.Psi.ITypeElement @class, string name, JetBrains.ReSharper.Psi.ITypeParameter originalTypeParameter) { }
        public override JetBrains.ReSharper.Psi.ITypeParameter AddTypeParameter(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration, string shortname) { }
        public override void InitFieldInConstructor(JetBrains.ReSharper.Psi.Tree.IDeclaration constructorDecl, JetBrains.ReSharper.Psi.Tree.IDeclaration fieldDecl, JetBrains.ReSharper.Psi.IParameter parameter) { }
        protected override bool IsInCollection(System.Collections.Generic.JetHashSet<string> namesSet, string fieldName) { }
        public override void MakeFirstPrameterThis(JetBrains.ReSharper.Psi.IMethod method, bool addThis, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public override void RemoveParameter(JetBrains.ReSharper.Psi.IParametersOwner owner, JetBrains.ReSharper.Psi.IParameter parameter) { }
        public override void RemoveTypeMember(JetBrains.ReSharper.Psi.Tree.ITypeMemberDeclaration member) { }
        public override void SetAccessRights(JetBrains.ReSharper.Psi.IDeclaredElement o, JetBrains.ReSharper.Psi.AccessRights rights) { }
    }
    public class VBPullPushEditor<MEMBER_INFO>
        where MEMBER_INFO : JetBrains.ReSharper.Refactorings.CommonUI.IMemberInfo
    {
        public static void AddBaseInterface(JetBrains.ReSharper.Psi.ITypeElement element, JetBrains.ReSharper.Psi.IDeclaredType baseType) { }
        public static void AddImplementsSpecification(JetBrains.ReSharper.Psi.Tree.IDeclaration newAbstractDecl, JetBrains.ReSharper.Psi.ITypeElement targetInterface, bool nameIsItem, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public static JetBrains.ReSharper.Psi.Tree.ITypeDeclaration CreateTargetTypeElement(string name, JetBrains.ReSharper.Psi.ITypeElement sourceClass, System.Collections.Generic.List<JetBrains.ReSharper.Psi.ITypeParameter> typeParameters, bool createClass, bool preserveAccessRights) { }
        public static System.Collections.Generic.List<JetBrains.Util.Pair<MEMBER_INFO, JetBrains.ReSharper.Psi.Tree.IDeclaration>> CutDeclarations(System.Collections.Generic.IEnumerable<MEMBER_INFO> includedMembers, JetBrains.ReSharper.Refactorings.MoveMembers.Common.IMoveMembersExecuter executer) { }
        public static JetBrains.ReSharper.Psi.Tree.ITypeDeclaration InsertSibling(JetBrains.ReSharper.Psi.Tree.ITypeDeclaration declarationToInsert, JetBrains.ReSharper.Psi.Tree.ITypeDeclaration tagDeclaration) { }
        public static JetBrains.ReSharper.Psi.Tree.ITypeDeclaration InsertToNewFile(JetBrains.ReSharper.Psi.Tree.ITypeDeclaration decl, JetBrains.ReSharper.Psi.Tree.ITypeDeclaration sourceClass, string ns, JetBrains.ProjectModel.IProjectFile fileNearby) { }
        public static void MakeOverride(JetBrains.ReSharper.Psi.ITypeMember member) { }
        public static void MakeProtected(JetBrains.ReSharper.Psi.IDeclaredElement element) { }
        public static void MakePublic(JetBrains.ReSharper.Psi.ITypeMember member) { }
        public static void MakeTypeElementAbstract(JetBrains.ReSharper.Psi.ITypeElement element) { }
        public static void PasteDeclarations(System.Collections.Generic.IList<JetBrains.Util.Pair<MEMBER_INFO, JetBrains.ReSharper.Psi.Tree.IDeclaration>> declarations, JetBrains.ReSharper.Psi.ITypeElement targetType, JetBrains.ReSharper.Refactorings.MoveMembers.Common.IMoveMembersExecuter executer) { }
        public static void RemoveDeclaration(JetBrains.ReSharper.Psi.ITypeMember member) { }
        public static void SetSuperType(JetBrains.ReSharper.Psi.Tree.ITypeDeclaration sourceClass, JetBrains.ReSharper.Psi.ITypeElement newSuper, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution) { }
        public static bool TryStoreReferencesForField(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration, JetBrains.ReSharper.Psi.IRecursiveElementProcessor collector) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.VB.VBLanguage))]
    public class VBRefactoringDataConstantsService : JetBrains.ReSharper.Refactorings.ExtensionsApi.IRefactoringDataConstantsService
    {
        public bool IsNameNodeSelected(JetBrains.ReSharper.Psi.Tree.ITreeNode node, JetBrains.DocumentModel.DocumentRange documentRange) { }
    }
    public class VBUnusedUsingsUtil
    {
        public static void AddFileToUsingSaver(JetBrains.ReSharper.Refactorings.Move.Common.UnusedUsingSaver saver, JetBrains.ReSharper.Psi.Tree.IFile file) { }
        public static void RemoveNewUnusedUsings(JetBrains.ReSharper.Psi.Tree.IFile file, System.Collections.Generic.JetHashSet<JetBrains.ReSharper.Psi.Tree.ITreeNode> oldUnusedUsings) { }
    }
}