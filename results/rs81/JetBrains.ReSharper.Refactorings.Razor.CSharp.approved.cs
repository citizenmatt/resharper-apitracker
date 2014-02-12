[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]

namespace JetBrains.ReSharper.Refactorings.Razor.CSharp.ExtractMethod
{
    
    [JetBrains.ReSharper.Refactorings.Workflow.RefactoringWorkflowProviderAttribute()]
    public class RazorCSharpExtractHelperProvider : JetBrains.ReSharper.Feature.Services.ActionsMenu.IWorkflowProvider<JetBrains.ReSharper.Refactorings.Workflow.IRefactoringWorkflow, JetBrains.ReSharper.Refactorings.Workflow.RefactoringActionGroup>, JetBrains.ReSharper.Refactorings.ExtractMethod.IExtractMethodWorkflowProvider, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringWorkflowProvider
    {
        public RazorCSharpExtractHelperProvider(JetBrains.ProjectModel.FileTypes.IProjectFileTypeServices projectFileTypeServices) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Refactorings.Workflow.IRefactoringWorkflow> CreateWorkflow(JetBrains.Application.DataContext.IDataContext dataContext) { }
    }
    public class RazorCSharpExtractHelperRefactoring : JetBrains.ReSharper.Refactorings.Workflow.IRefactoringExecuter
    {
        public RazorCSharpExtractHelperRefactoring(JetBrains.ReSharper.Refactorings.Razor.CSharp.ExtractMethod.RazorCSharpExtractHelperWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public bool Execute(JetBrains.Application.Progress.IProgressIndicator pi) { }
    }
    public class RazorCSharpExtractHelperWorkflow : JetBrains.ReSharper.Refactorings.Workflow.DrivenRefactoringWorkflow, JetBrains.ReSharper.Refactorings.CSharp.ExtractMethod2.Common.IExtractMethodWorkflow
    {
        public RazorCSharpExtractHelperWorkflow(JetBrains.ProjectModel.FileTypes.IProjectFileTypeServices projectFileTypeServices, JetBrains.ProjectModel.ISolution solution, string actionId) { }
        public override JetBrains.ReSharper.Refactorings.Workflow.RefactoringActionGroup ActionGroup { get; }
        public JetBrains.ReSharper.Refactorings.CSharp.ExtractMethod2.ControlFlow.ICSharpExtractMethodControlFlowInspectionResult AnalysisResult { get; }
        public JetBrains.ReSharper.Psi.ITreeNodePointer<JetBrains.ReSharper.Psi.CSharp.Tree.IClassLikeDeclaration> ClassDeclarationPointer { get; }
        public JetBrains.ReSharper.Refactorings.CSharp.ExtractMethod2.Common.CSharpExtractMethodExtractedEntityKind ExtractedEntityKind { get; }
        public override JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage FirstPendingRefactoringPage { get; }
        public override string HelpKeyword { get; }
        public string HtmlWriterParameterName { get; }
        public string MethodName { get; set; }
        public override bool MightModifyManyDocuments { get; }
        public JetBrains.ReSharper.Psi.Naming.Settings.NamingPolicy NamingPolicy { get; }
        public JetBrains.ReSharper.Psi.Razor.Generate.RazorCodeGenerator RazorCodeGenerator { get; }
        public JetBrains.ReSharper.Psi.Razor.Tree.IRazorFile RazorFile { get; }
        public JetBrains.ReSharper.Psi.Razor.Impl.CustomHandlers.IRazorPsiServices RazorPsiServices { get; }
        public JetBrains.ReSharper.Psi.TreeTextRange RazorRange { get; }
        protected JetBrains.ReSharper.Psi.Razor.Impl.IRazorRegenerator RazorRegenerator { get; }
        public JetBrains.ReSharper.Psi.IPsiSourceFile SourceFile { get; }
        public JetBrains.ReSharper.Psi.CSharp.ICSharpStatementsRange StatementsRange { get; }
        public override string Title { get; }
        public void AdditionalAnalysisOfReturnValues(JetBrains.ReSharper.Refactorings.CSharp.ExtractMethod2.ControlFlow.ICSharpExtractMethodControlFlowInspectionResult result) { }
        public JetBrains.ReSharper.Psi.Tree.ITreeNode CreatePreviewElement() { }
        public override JetBrains.ReSharper.Refactorings.Workflow.IRefactoringExecuter CreateRefactoring(JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public string Dump() { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Refactorings.CSharp.ExtractMethod2.Common.CSharpExtractMethodParameter> GetPossibleParameters() { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Refactorings.CSharp.ExtractMethod2.Common.CSharpExtractMethodParameter> GetPossibleReturnParameters() { }
        public override bool Initialize(JetBrains.Application.DataContext.IDataContext context) { }
        public override bool IsAvailable(JetBrains.Application.DataContext.IDataContext context) { }
        public bool IsValid() { }
        public JetBrains.ReSharper.Psi.CSharp.Tree.IBlock PrepareBody(JetBrains.ReSharper.Psi.CSharp.Tree.IBlock body, JetBrains.ReSharper.Psi.CSharp.CSharpElementFactory factory) { }
    }
    public class RazorExtractHelperReturnValue : JetBrains.ReSharper.Refactorings.CSharp.ExtractMethod2.Common.CSharpExtractMethodParameter
    {
        public RazorExtractHelperReturnValue(JetBrains.ReSharper.Refactorings.Razor.CSharp.ExtractMethod.RazorCSharpExtractHelperWorkflow workflow) { }
        public override void AddCall(JetBrains.ReSharper.Psi.CSharp.CSharpElementFactory factory, JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpExpression call, JetBrains.ReSharper.Psi.CSharp.Tree.IBlock blockForCallSite, JetBrains.ReSharper.Refactorings.CSharp.ExtractMethod2.ControlFlow.ICSharpExtractMethodControlFlowInspectionResult inspectionResult) { }
        public override JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpStatement CreateReturnValue(JetBrains.ReSharper.Psi.CSharp.CSharpElementFactory factory, JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpStatement originalStatement, JetBrains.ReSharper.Refactorings.CSharp.ExtractMethod2.ControlFlow.ICSharpExtractMethodControlFlowInspectionResult inspector, bool isExitClassA) { }
        public override string Dump() { }
        public override JetBrains.ReSharper.Psi.IType GetParameterType(JetBrains.ReSharper.Psi.Modules.IPsiModule module) { }
        public override void SuggestName(JetBrains.ReSharper.Psi.Naming.Extentions.INamesCollection collection) { }
        public override string ToString() { }
    }
}
namespace JetBrains.ReSharper.Refactorings.Razor.CSharp.InplaceRefactorings
{
    
    [JetBrains.ProjectModel.ProjectFileTypeAttribute(typeof(JetBrains.ProjectModel.RazorCSharpProjectFileType))]
    public class RazorCSharpInplaceChangeSignatureHelper : JetBrains.ReSharper.Refactorings.CSharp.InplaceRefactorings.CSharpInplaceChangeSignatureHelper
    {
        public RazorCSharpInplaceChangeSignatureHelper(JetBrains.ReSharper.Psi.Razor.Impl.CustomHandlers.IRazorPsiServices razorPsiServices) { }
        public override JetBrains.ReSharper.Psi.TreeTextRange GetSignatureRange(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration) { }
    }
}
namespace JetBrains.ReSharper.Refactorings.Razor.CSharp.MoveHelper
{
    
    public class MoveHelper { }
}