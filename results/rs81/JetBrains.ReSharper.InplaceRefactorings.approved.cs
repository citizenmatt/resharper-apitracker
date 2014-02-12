[assembly: JetBrains.TextControl.DocumentMarkup.RegisterHighlighterAttribute("ReSharper Name or Signature Changed", "{6E22FFEA-D2F2-4834-B5C7-B6CE1AE3F5B1}", EffectColor="DarkGray", EffectType=JetBrains.TextControl.DocumentMarkup.EffectType.DOTTED_OUTLINE, Layer=4999, VSPriority=10001)]
[assembly: JetBrains.UI.Icons.CompiledIcons.CompiledIconsPackAttribute(IconNames=new string[] {
        "AddedParameter",
        "RemovedParameter"}, IconPackResourceIdentification="JetBrains.ReSharper.InplaceRefactorings;component/resources/RefactoringsInplaceTh" +
    "emedIcons/ThemedIcons.RefactoringsInplace.Generated.Xaml")]
[assembly: System.Runtime.CompilerServices.InternalsVisibleToAttribute(@"JetBrains.ReSharper.FeaturesTests, PublicKey=002400000480000094000000060200000024000052534131000400000100010087f63ba6a789c30e210e7ec987234ad9fe33baf7367993bab1b312d6f72ca296b91ed5c658964ffb9e7570eb184a527c68c6bdba41cfe67d8cfd3f888234206bf39205a3652d3af3445bb6f715fdac532e289fea41229bac37762b67eb16f58fee717d2465fca9ee17f08ed16772a1fc52c1c17022e1f0d9bdd004524a663aca")]
[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]
[assembly: System.Windows.Markup.XmlnsDefinitionAttribute("urn:shemas-jetbrains-com:ui-application-icons-refactorings-inplace", "JetBrains.ReSharper.InplaceRefactorings.Resources")]

namespace JetBrains.ReSharper.InplaceRefactorings.ChangeSignature
{
    
    public class ChangeSignatureInfo : JetBrains.ReSharper.InplaceRefactorings.IRefactoringInfo
    {
        public readonly JetBrains.ReSharper.Psi.Tree.IDeclaration Declaration;
        public readonly JetBrains.ReSharper.InplaceRefactorings.ChangeSignature.RestoreSignatureInfo RestoreSignatureInfo;
        public readonly JetBrains.ReSharper.InplaceRefactorings.ChangeSignature.SignatureChange SignatureChange;
        public ChangeSignatureInfo(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration, bool hasBaseMember, System.Collections.Generic.IList<JetBrains.ReSharper.InplaceRefactorings.ChangeSignature.SignatureData> signatures, JetBrains.ReSharper.InplaceRefactorings.ChangeSignature.RestoreSignatureInfo restoreSignatureInfo, JetBrains.UI.Icons.IThemedIconManager themedIconManager) { }
        public string ContextActionTitle { get; }
        public JetBrains.ReSharper.Refactorings.Workflow.IRefactoringWorkflow CreateRefactoringWorkflow() { }
        public System.Text.StringBuilder DumpSignatures(JetBrains.ReSharper.Psi.PsiLanguageType language) { }
        public bool MakesSenseToRunRefactoring() { }
    }
    public interface IInplaceChangeSignatureHelper
    {
        JetBrains.ReSharper.InplaceRefactorings.ChangeSignature.IVisualizationModelLanguageHelper VisualizationModelLanguageHelper { get; }
        JetBrains.ReSharper.Psi.TreeTextRange GetParameterListRange(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration);
        JetBrains.ReSharper.InplaceRefactorings.ChangeSignature.SignatureKind GetSignatureKind(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration);
        JetBrains.ReSharper.Psi.TreeTextRange GetSignatureRange(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration);
        bool IsValidConstructorName(JetBrains.ReSharper.Psi.Tree.ITypeMemberDeclaration constructorDeclaration, JetBrains.ReSharper.Psi.ITypeElement containingType);
    }
    public class InplaceChangeSignatureWorkflow : JetBrains.ReSharper.Refactorings.Workflow.RefactoringWorkflowBase
    {
        public InplaceChangeSignatureWorkflow(JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.InplaceRefactorings.ChangeSignature.ChangeSignatureInfo info, JetBrains.UI.Icons.IThemedIconManager themedIconManager) { }
        public override JetBrains.ReSharper.Refactorings.Workflow.RefactoringActionGroup ActionGroup { get; }
        public override string ActionId { get; }
        public override JetBrains.ReSharper.Refactorings.Conflicts.IConflictSearcher ConflictSearcher { get; }
        public JetBrains.ReSharper.Refactorings.ChangeSignature.IChangeSignatureTestData Data { get; set; }
        public override JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage FirstPendingRefactoringPage { get; }
        public override bool HasUI { get; }
        public override string HelpKeyword { get; }
        public override JetBrains.UI.Icons.IconId Icon { get; }
        public override bool MightModifyManyDocuments { get; }
        public JetBrains.ReSharper.Refactorings.ChangeSignature.ChangeSignatureModel Model { get; }
        public JetBrains.ReSharper.InplaceRefactorings.ChangeSignature.SignatureChange SignatureChange { get; }
        public override JetBrains.ProjectModel.ISolution Solution { get; }
        public override string Title { get; }
        public override bool Execute(JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
        public override bool Initialize(JetBrains.Application.DataContext.IDataContext context) { }
        public override bool IsAvailable(JetBrains.Application.DataContext.IDataContext context) { }
        public override bool PostExecute(JetBrains.Application.Progress.IProgressIndicator pi) { }
        public override bool PreExecute(JetBrains.Application.Progress.IProgressIndicator taskExecutorCreator) { }
        public void RunActionWithOriginalSignature(System.Action<JetBrains.ReSharper.Psi.IDeclaredElement> action) { }
        public override void SuccessfulFinish(JetBrains.Application.Progress.IProgressIndicator pi) { }
    }
    public interface IVisualizationModelLanguageHelper
    {
        string ParameterTypeAndNameSeparator { get; }
        bool ParameterTypeBeforeName { get; }
        bool ReturnTypeFirst { get; }
        string ReturnTypeSeparator { get; }
        bool SkipEmptyParameterList { get; }
        bool SkipVoidReturnType { get; }
        string ParameterModifierText(JetBrains.ReSharper.Psi.ParameterKind kind, bool isParams = False, bool isVarArg = False, bool isThis = False);
        string StartKeyword(JetBrains.ReSharper.InplaceRefactorings.ChangeSignature.SignatureData signature);
    }
    public class ParameterData
    {
        public JetBrains.ReSharper.Psi.DefaultValue DefaultValue;
        public readonly bool IsParams;
        public readonly bool IsThis;
        public readonly bool IsVarArg;
        public readonly JetBrains.ReSharper.Psi.ParameterKind Kind;
        public readonly string Name;
        public ParameterData(JetBrains.ReSharper.Psi.IType type, string name, JetBrains.ReSharper.Psi.ParameterKind kind, bool isParams = False, bool isVarArg = False, bool isThis = False, JetBrains.ReSharper.Psi.DefaultValue defaultValue = null) { }
        public JetBrains.ReSharper.Psi.IType Type { get; }
        public override bool Equals(object obj) { }
        public JetBrains.ReSharper.Refactorings.ChangeSignature.IParameterValue GetDefaultValue(JetBrains.ReSharper.Psi.PsiLanguageType type) { }
        public override int GetHashCode() { }
        public bool IsValid() { }
        public string TestDump(JetBrains.ReSharper.Psi.PsiLanguageType language) { }
    }
    public class RestoreSignatureInfo
    {
        public RestoreSignatureInfo(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration) { }
        public void RestoreSignature(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration) { }
    }
    public class SignatureChange
    {
        public SignatureChange(JetBrains.ReSharper.InplaceRefactorings.ChangeSignature.SignatureData oldSignature, JetBrains.ReSharper.InplaceRefactorings.ChangeSignature.SignatureData newSignature, System.Nullable<>[] parameterChanges, System.Collections.Generic.ICollection<JetBrains.ReSharper.InplaceRefactorings.ChangeSignature.SignatureChange.NewParameter> newParameters, string newName, JetBrains.ReSharper.Psi.IType newReturnType) { }
        public string NewName { get; }
        public System.Collections.Generic.ICollection<JetBrains.ReSharper.InplaceRefactorings.ChangeSignature.SignatureChange.NewParameter> NewParameters { get; }
        public JetBrains.ReSharper.Psi.IType NewReturnType { get; }
        public JetBrains.ReSharper.InplaceRefactorings.ChangeSignature.SignatureData NewSignature { get; }
        public JetBrains.ReSharper.InplaceRefactorings.ChangeSignature.SignatureData OldSignature { get; }
        public System.Nullable<>[] ParameterChanges { get; }
        public bool MakesSenseToRunRefactoring(bool isMethodVirtual) { }
        public void TestDump(System.IO.TextWriter writer, JetBrains.ReSharper.Psi.PsiLanguageType language) { }
        public struct NewParameter
        {
            public readonly JetBrains.ReSharper.InplaceRefactorings.ChangeSignature.ParameterData Data;
            public readonly int Index;
            public NewParameter(int index, JetBrains.ReSharper.InplaceRefactorings.ChangeSignature.ParameterData data) { }
        }
        public struct ParameterChange
        {
            public JetBrains.ReSharper.Psi.DefaultValue NewDefaultValue;
            public readonly int NewIndex;
            public readonly System.Nullable<bool> NewIsParams;
            public readonly System.Nullable<bool> NewIsThis;
            public readonly System.Nullable<bool> NewIsVarArg;
            public readonly System.Nullable<JetBrains.ReSharper.Psi.ParameterKind> NewKind;
            public readonly string NewName;
            public ParameterChange(int newIndex, string newName = null, JetBrains.ReSharper.Psi.IType newType = null, System.Nullable<JetBrains.ReSharper.Psi.ParameterKind> newKind = null, System.Nullable<bool> newIsParams = null, System.Nullable<bool> newIsVarArg = null, System.Nullable<bool> newIsThis = null, JetBrains.ReSharper.Psi.DefaultValue newDefaultValue = null) { }
            public ParameterChange(int newIndex, JetBrains.ReSharper.InplaceRefactorings.ChangeSignature.ParameterData oldParameterData, JetBrains.ReSharper.InplaceRefactorings.ChangeSignature.ParameterData newParameterData) { }
            public JetBrains.ReSharper.Psi.IType NewType { get; }
        }
    }
    public class SignatureData
    {
        public readonly bool IsCorrect;
        public readonly JetBrains.ReSharper.InplaceRefactorings.ChangeSignature.SignatureKind Kind;
        public readonly string Name;
        public readonly JetBrains.ReSharper.InplaceRefactorings.ChangeSignature.ParameterData[] Parameters;
        public SignatureData(JetBrains.ReSharper.InplaceRefactorings.ChangeSignature.SignatureKind kind, string name, JetBrains.ReSharper.InplaceRefactorings.ChangeSignature.ParameterData[] parameters, JetBrains.ReSharper.Psi.IType type, bool isCorrect) { }
        public JetBrains.ReSharper.Psi.IType Type { get; }
        public static JetBrains.ReSharper.InplaceRefactorings.ChangeSignature.SignatureData Build(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration, JetBrains.ReSharper.Psi.IParametersOwner parametersOwner) { }
        public bool Equals(JetBrains.ReSharper.InplaceRefactorings.ChangeSignature.SignatureData signature) { }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
        public bool IsValid() { }
        public string TestDump(JetBrains.ReSharper.Psi.PsiLanguageType language) { }
    }
    public enum SignatureKind
    {
        METHOD = 0,
        CONSTRUCTOR = 1,
        PROPERTY = 2,
        INDEXER = 3,
    }
}
namespace JetBrains.ReSharper.InplaceRefactorings.CutCopyPaste
{
    
    public abstract class ExtensionMethodImportOnPasteProviderBase : JetBrains.ReSharper.InplaceRefactorings.CutCopyPaste.IImportOnPasteProvider
    {
        protected abstract JetBrains.ReSharper.InplaceRefactorings.CutCopyPaste.ExtensionMethodImportOnPasteProviderBase.ExtensionMethodReferenceData CreateReferenceData(string referenceName, JetBrains.ReSharper.Psi.IMethod targetExtensionMethod);
        public JetBrains.ReSharper.InplaceRefactorings.CutCopyPaste.ReferenceData CreateReferenceData(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.ResolveResultWithInfo resolveResult) { }
        protected abstract bool IsYourReference(JetBrains.ReSharper.Psi.Resolve.IReference reference);
        protected abstract class ExtensionMethodReferenceData : JetBrains.ReSharper.InplaceRefactorings.CutCopyPaste.TypeReferenceData
        {
            protected ExtensionMethodReferenceData(string referenceName, JetBrains.ReSharper.Psi.IMethod targetExtensionMethod) { }
            public override bool BindReference(JetBrains.ReSharper.Psi.Resolve.IReference @ref, JetBrains.ReSharper.Psi.IDeclaredElement target) { }
            protected abstract bool BindReference(JetBrains.ReSharper.Psi.Resolve.IReference @ref, JetBrains.ReSharper.Psi.IMethod targetMethod);
            public override JetBrains.ReSharper.Psi.IDeclaredElement FindTarget(JetBrains.ReSharper.Psi.Modules.IPsiModule sourceModule, JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext context) { }
            public virtual JetBrains.ReSharper.InplaceRefactorings.CutCopyPaste.ReferenceData.NeedToBind NeedToBindInPastedCode(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.IDeclaredElement target) { }
            protected abstract JetBrains.ReSharper.InplaceRefactorings.CutCopyPaste.ReferenceData.NeedToBind NeedToBindInPastedCode(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.IMethod targetMethod);
        }
    }
    public interface IImportOnPasteProvider
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.InplaceRefactorings.CutCopyPaste.ReferenceData CreateReferenceData(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.ResolveResultWithInfo resolveResult);
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Imports types and extension methods for pasted code fragment", Group="Common", Name="Import types for pasted code", Priority=1)]
    public class ImportsForPastedContextAction : JetBrains.ReSharper.Intentions.Extensibility.IContextAction, JetBrains.ReSharper.Intentions.Extensibility.IPopupBulbAction
    {
        public ImportsForPastedContextAction(JetBrains.ReSharper.Feature.Services.Bulbs.LanguageIndependentContextActionDataProvider provider) { }
        public JetBrains.ReSharper.Intentions.Extensibility.IBulbAction[] Items { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        public bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public abstract class ReferenceData
    {
        protected ReferenceData(string referenceName) { }
        public string ReferenceName { get; }
        public virtual bool BindReference(JetBrains.ReSharper.Psi.Resolve.IReference @ref, JetBrains.ReSharper.Psi.IDeclaredElement target) { }
        public abstract JetBrains.ReSharper.Psi.IDeclaredElement FindTarget(JetBrains.ReSharper.Psi.Modules.IPsiModule sourceModule, JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext context);
        public virtual JetBrains.ReSharper.InplaceRefactorings.CutCopyPaste.ReferenceData.NeedToBind NeedToBindInPastedCode(JetBrains.ReSharper.Psi.Resolve.IReference reference, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IDeclaredElement target) { }
        public enum NeedToBind
        {
            Yes = 0,
            No = 1,
            MayBeAffectedByOtherReferences = 2,
        }
    }
    public class TypeReferenceData : JetBrains.ReSharper.InplaceRefactorings.CutCopyPaste.ReferenceData
    {
        public TypeReferenceData(string referenceName, string targetTypeClrName, string targetModuleName) { }
        public override bool BindReference(JetBrains.ReSharper.Psi.Resolve.IReference @ref, JetBrains.ReSharper.Psi.IDeclaredElement target) { }
        public override JetBrains.ReSharper.Psi.IDeclaredElement FindTarget(JetBrains.ReSharper.Psi.Modules.IPsiModule sourceModule, JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext context) { }
    }
}
namespace JetBrains.ReSharper.InplaceRefactorings
{
    
    public interface IInplaceRefactoringsLanguageSpecifics
    {
        System.Collections.Generic.IEnumerable<JetBrains.DocumentModel.DocumentRange> UsingListRanges(JetBrains.ReSharper.Psi.Tree.IFile file);
    }
    public class static InplaceRefactoringsServices
    {
        public static bool EndsWithErrorElement(this JetBrains.ReSharper.Psi.Tree.ITreeNode node) { }
        public static JetBrains.ReSharper.InplaceRefactorings.ChangeSignature.IInplaceChangeSignatureHelper GetInplaceChangeSignatureHelper(this JetBrains.ReSharper.Psi.Tree.IDeclaration declaration) { }
        public static JetBrains.ReSharper.InplaceRefactorings.MoveStaticMembers.IInplaceMoveStaticMembersHelper GetInplaceMoveStaticMembersHelper(this JetBrains.ReSharper.Psi.Tree.ITreeNode node) { }
        public static JetBrains.ReSharper.InplaceRefactorings.IInplaceRefactoringsLanguageSpecifics GetInplaceRefactoringsLanguageSpecifics(this JetBrains.ReSharper.Psi.Tree.ITreeNode node) { }
        public static JetBrains.ReSharper.Psi.TreeTextRange GetSignatureRange(this JetBrains.ReSharper.Psi.Tree.IDeclaration declaration) { }
    }
}
namespace JetBrains.ReSharper.InplaceRefactorings.MoveStaticMembers
{
    
    public interface IInplaceMoveStaticMembersHelper
    {
        JetBrains.ReSharper.Psi.Tree.ITypeMemberDeclaration AddMemberDeclaration(JetBrains.ReSharper.Psi.Tree.ITypeDeclaration typeDeclaration, JetBrains.ReSharper.Psi.Tree.ITypeMemberDeclaration memberDeclaration);
        void DeleteMemberDeclaration(JetBrains.ReSharper.Psi.Tree.ITypeMemberDeclaration memberDeclaration);
        JetBrains.ReSharper.Psi.Tree.ITypeMemberDeclaration ReplaceMemberDeclaration(JetBrains.ReSharper.Psi.Tree.ITypeMemberDeclaration oldDeclaration, JetBrains.ReSharper.Psi.Tree.ITypeMemberDeclaration newDeclaration);
    }
}
namespace JetBrains.ReSharper.InplaceRefactorings.Rename
{
    
    public interface IInplaceRenameLanguageSpecifics
    {
        bool SuggestRenameOnRenamingReference(JetBrains.ReSharper.Psi.Resolve.IReference reference);
    }
    public class InplaceRenameWorkflow : JetBrains.ReSharper.Refactorings.Rename.RenameWorkflow
    {
        public InplaceRenameWorkflow(JetBrains.Application.IShellLocks shellLocks, JetBrains.ReSharper.Psi.Search.SearchDomainFactory searchDomainFactory, JetBrains.ReSharper.Refactorings.Rename.RenameRefactoringService renameRefactoringService, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Psi.IDeclaredElement element, string newName, System.Func<bool> restoreNameAction, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Tree.IDeclaration declaration, string actionId) { }
        public override JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage CommitInitialStage(string name, JetBrains.Application.Progress.IProgressIndicator pi, bool searchText) { }
        public override bool Initialize(JetBrains.Application.DataContext.IDataContext context) { }
    }
}
namespace JetBrains.ReSharper.InplaceRefactorings.Resources
{
    
    public sealed class RefactoringsInplaceThemedIcons
    {
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.InplaceRefactorings;component/resources/RefactoringsInplaceTh" +
            "emedIcons/ThemedIcons.RefactoringsInplace.Generated.Xaml", 0, "AddedParameter")]
        public sealed class AddedParameter : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.InplaceRefactorings;component/resources/RefactoringsInplaceTh" +
            "emedIcons/ThemedIcons.RefactoringsInplace.Generated.Xaml", 1, "RemovedParameter")]
        public sealed class RemovedParameter : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
    }
}