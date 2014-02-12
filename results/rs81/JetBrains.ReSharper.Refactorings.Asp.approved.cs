[assembly: JetBrains.ActionManagement.ActionsXmlAttribute("JetBrains.ReSharper.Refactorings.Asp.resources.Actions.xml")]
[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]

namespace JetBrains.ReSharper.Refactorings.Asp.InplaceRefactorings
{
    
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class AspImportOnPasteProvider : JetBrains.ReSharper.InplaceRefactorings.CutCopyPaste.IImportOnPasteProvider
    {
        public JetBrains.ReSharper.InplaceRefactorings.CutCopyPaste.ReferenceData CreateReferenceData(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.ResolveResultWithInfo resolveResult) { }
    }
}
namespace JetBrains.ReSharper.Refactorings.Asp.Masterpage
{
    
    public abstract class AspRefactoringWorkflowBase : JetBrains.ReSharper.Refactorings.Workflow.DrivenRefactoringWorkflow
    {
        protected AspRefactoringWorkflowBase(JetBrains.ProjectModel.ISolution solution, string actionId) { }
        public JetBrains.ReSharper.Psi.Asp.Tree.IAspFile AspFile { get; }
        public JetBrains.Application.DataContext.IDataContext DataContext { get; }
        public override string HelpKeyword { get; }
        public override bool Initialize(JetBrains.Application.DataContext.IDataContext context) { }
        protected abstract bool Initialize([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Asp.Tree.IAspFile aspFile, [JetBrains.Annotations.NotNullAttribute()] JetBrains.TextControl.ITextControl textControl);
        public override bool IsAvailable(JetBrains.Application.DataContext.IDataContext context) { }
        protected abstract bool IsAvailable([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Asp.Tree.IAspFile aspFileNode, [JetBrains.Annotations.NotNullAttribute()] JetBrains.TextControl.ITextControl textControl);
    }
    public class ExtractContentPlaceholder : JetBrains.ReSharper.Refactorings.Common.RefactoringExecBase<JetBrains.ReSharper.Refactorings.Asp.Masterpage.ExtractContentPlaceholderWorkflow, JetBrains.ReSharper.Refactorings.Asp.Masterpage.ExtractContentPlaceholderRefactoring>
    {
        public ExtractContentPlaceholder(JetBrains.ReSharper.Refactorings.Asp.Masterpage.ExtractContentPlaceholderWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
    }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "ExtractContentPlaceholder"})]
    public class ExtractContentPlaceholderAction : JetBrains.ReSharper.Refactorings.Workflow.RefactoringAction
    {
        public ExtractContentPlaceholderAction() { }
    }
    public class ExtractContentPlaceholderRefactoring : JetBrains.ReSharper.Refactorings.Common.DrivenRefactoring<JetBrains.ReSharper.Refactorings.Asp.Masterpage.ExtractContentPlaceholderWorkflow, JetBrains.ReSharper.Refactorings.Asp.Masterpage.ExtractContentPlaceholder>
    {
        public ExtractContentPlaceholderRefactoring(JetBrains.ReSharper.Refactorings.Asp.Masterpage.ExtractContentPlaceholderWorkflow workFlow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver, JetBrains.TextControl.ITextControl textControl) { }
        public override bool Execute(JetBrains.Application.Progress.IProgressIndicator pi) { }
    }
    public class ExtractContentPlaceholderWorkflow : JetBrains.ReSharper.Refactorings.Asp.Masterpage.AspRefactoringWorkflowBase
    {
        public ExtractContentPlaceholderWorkflow(JetBrains.ProjectModel.ISolution solution, string actionId) { }
        public override JetBrains.ReSharper.Refactorings.Workflow.RefactoringActionGroup ActionGroup { get; }
        public override JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage FirstPendingRefactoringPage { get; }
        public override bool MightModifyManyDocuments { get; }
        public override string Title { get; }
        public override JetBrains.ReSharper.Refactorings.Workflow.IRefactoringExecuter CreateRefactoring(JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        protected override bool Initialize(JetBrains.ReSharper.Psi.Asp.Tree.IAspFile aspFile, JetBrains.TextControl.ITextControl textControl) { }
        protected override bool IsAvailable(JetBrains.ReSharper.Psi.Asp.Tree.IAspFile aspFile, JetBrains.TextControl.ITextControl textControl) { }
    }
    public interface IExtractContentPlaceholderTemplateProvider
    {
        System.Guid TemplateId { get; }
    }
    public class InlineContent : JetBrains.ReSharper.Refactorings.Common.RefactoringExecBase<JetBrains.ReSharper.Refactorings.Asp.Masterpage.InlineContentWorkflow, JetBrains.ReSharper.Refactorings.Asp.Masterpage.InlineContentRefactoring>
    {
        public InlineContent(JetBrains.ReSharper.Refactorings.Asp.Masterpage.InlineContentWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
    }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "InlineContent"})]
    public class InlineContentAction : JetBrains.ReSharper.Refactorings.Workflow.RefactoringAction
    {
        public InlineContentAction() { }
    }
    public class InlineContentRefactoring : JetBrains.ReSharper.Refactorings.Common.DrivenRefactoring<JetBrains.ReSharper.Refactorings.Asp.Masterpage.InlineContentWorkflow, JetBrains.ReSharper.Refactorings.Asp.Masterpage.InlineContent>
    {
        public InlineContentRefactoring(JetBrains.ReSharper.Refactorings.Asp.Masterpage.InlineContentWorkflow workFlow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver, JetBrains.ReSharper.Psi.Html.Tree.IHtmlTag contentTag) { }
        public override bool Execute(JetBrains.Application.Progress.IProgressIndicator pi) { }
    }
    public class InlineContentWorkflow : JetBrains.ReSharper.Refactorings.Asp.Masterpage.AspRefactoringWorkflowBase
    {
        public InlineContentWorkflow(JetBrains.ProjectModel.ISolution solution, string actionId) { }
        public override JetBrains.ReSharper.Refactorings.Workflow.RefactoringActionGroup ActionGroup { get; }
        public override JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage FirstPendingRefactoringPage { get; }
        public override bool MightModifyManyDocuments { get; }
        public override string Title { get; }
        public override JetBrains.ReSharper.Refactorings.Workflow.IRefactoringExecuter CreateRefactoring(JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        protected override bool Initialize(JetBrains.ReSharper.Psi.Asp.Tree.IAspFile aspFile, JetBrains.TextControl.ITextControl textControl) { }
        protected override bool IsAvailable(JetBrains.ReSharper.Psi.Asp.Tree.IAspFile aspFile, JetBrains.TextControl.ITextControl textControl) { }
    }
}
namespace JetBrains.ReSharper.Refactorings.Asp.Move
{
    
    public class static AspMoveUtil
    {
        public static System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Tree.ITypeDeclaration> GetTopLevelTypeDeclarations(JetBrains.ReSharper.Psi.Tree.IFile file) { }
    }
}
namespace JetBrains.ReSharper.Refactorings.Asp.Rename
{
    
    [JetBrains.ReSharper.Psi.ShellFeaturePartAttribute()]
    public class AspRenamesFactory : JetBrains.ReSharper.Refactorings.Rename.AtomicRenamesFactory
    {
        public override JetBrains.ReSharper.Refactorings.RenameModel.RenameAvailabilityCheckResult CheckRenameAvailability(JetBrains.ReSharper.Psi.IDeclaredElement element) { }
        public override bool IsApplicable(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
    }
    [JetBrains.ReSharper.Refactorings.Rename.RenamePartAttribute()]
    public class AspRenameSuspiciousNamesService : JetBrains.ReSharper.Refactorings.Rename.IRenameSuspiciousNamesService
    {
        public string[] GetPossibleReferenceNames(JetBrains.ReSharper.Psi.IDeclaredElement element, string newName) { }
    }
    [JetBrains.ReSharper.Refactorings.Rename.FileRenameProviderAttribute()]
    public class MvcFileRenameProvider : JetBrains.ReSharper.Refactorings.Rename.IFileRenameProvider
    {
        public MvcFileRenameProvider(JetBrains.Application.Settings.ISettingsStore settingsStore, JetBrains.Application.Settings.ISettingsOptimization settingsOptimization) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Refactorings.Rename.FileRename> GetFileRenames(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, string name) { }
    }
}
namespace JetBrains.ReSharper.Refactorings.Asp.SafeDelete
{
    
    public class AspSafeDelete : JetBrains.ReSharper.Refactorings.SafeDeleteTheSecond.SafeDeleteBase
    {
        public AspSafeDelete(JetBrains.ReSharper.Refactorings.SafeDeleteTheSecond.SafeDeleteWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public override void RemoveDeclaration(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration) { }
        public override bool RemoveReference(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
    }
    public class AspSafeDeleteHelper : JetBrains.ReSharper.Refactorings.SafeDeleteTheSecond.SafeDeleteHelperUnsupported
    {
        public override bool IsLanguageSupported { get; }
        public override bool CanBeRemoved(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration) { }
        public override bool IsBaseClassSpecifier(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public override bool IsInterfaceImplementationSpecifier(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
    }
}