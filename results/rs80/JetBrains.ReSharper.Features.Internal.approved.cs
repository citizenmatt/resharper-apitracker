[assembly: JetBrains.ActionManagement.ActionsXmlAttribute("JetBrains.ReSharper.Features.Internal.resources.Actions.xml")]
[assembly: JetBrains.UI.Icons.CompiledIcons.CompiledIconsPackAttribute(IconNames=new string[] {
        "CodeBehindToolWindow",
        "QuickStartToolWindow",
        "TypeBrowserToolWindow"}, IconPackResourceIdentification="JetBrains.ReSharper.Features.Internal;component/resources/FeaturesInternalThemedI" +
    "cons/ThemedIcons.FeaturesInternal.Generated.Xaml")]
[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]
[assembly: System.Windows.Markup.XmlnsDefinitionAttribute("urn:shemas-jetbrains-com:ui-application-icons-features-internal", "JetBrains.ReSharper.Features.Internal.Resources")]

namespace JetBrains.IntegrationTestsUI
{
    
    public abstract class TargetVsVersionBaseAction : JetBrains.ActionManagement.IActionHandler
    {
        protected virtual string ProcessorArchitecture { get; set; }
        protected virtual string VsVersion { get; set; }
        public void Execute(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.DelegateExecute nextExecute) { }
        public bool Update(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.ActionPresentation presentation, JetBrains.ActionManagement.DelegateUpdate nextUpdate) { }
    }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "IntegrationTests.TargetVsVersion.Default"})]
    public class TargetVsVersionDefaultAction : JetBrains.IntegrationTestsUI.TargetVsVersionBaseAction { }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "IntegrationTests.TargetVsVersion.Standalone32"})]
    public class TargetVsVersionStandalone32Action : JetBrains.IntegrationTestsUI.TargetVsVersionBaseAction
    {
        protected override string ProcessorArchitecture { get; }
        protected override string VsVersion { get; }
    }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "IntegrationTests.TargetVsVersion.Standalone64"})]
    public class TargetVsVersionStandalone64Action : JetBrains.IntegrationTestsUI.TargetVsVersionBaseAction
    {
        protected override string ProcessorArchitecture { get; }
        protected override string VsVersion { get; }
    }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "IntegrationTests.TargetVsVersion.VS10"})]
    public class TargetVsVersionVS10Action : JetBrains.IntegrationTestsUI.TargetVsVersionBaseAction
    {
        protected override string VsVersion { get; }
    }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "IntegrationTests.TargetVsVersion.VS11"})]
    public class TargetVsVersionVS11Action : JetBrains.IntegrationTestsUI.TargetVsVersionBaseAction
    {
        protected override string VsVersion { get; }
    }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "IntegrationTests.TargetVsVersion.VS12"})]
    public class TargetVsVersionVS12Action : JetBrains.IntegrationTestsUI.TargetVsVersionBaseAction
    {
        protected override string VsVersion { get; }
    }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "IntegrationTests.TargetVsVersion.VS8"})]
    public class TargetVsVersionVS8Action : JetBrains.IntegrationTestsUI.TargetVsVersionBaseAction
    {
        protected override string VsVersion { get; }
    }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "IntegrationTests.TargetVsVersion.VS9"})]
    public class TargetVsVersionVS9Action : JetBrains.IntegrationTestsUI.TargetVsVersionBaseAction
    {
        protected override string VsVersion { get; }
    }
}
namespace JetBrains.ReSharper.Features.Internal.Annotator
{
    
    public abstract class AnnotationsApplier
    {
        public abstract void ApplySingleAnnotation(JetBrains.ReSharper.Psi.IAttributesOwner declaredElement, System.Nullable<JetBrains.ReSharper.Psi.CodeAnnotations.CodeAnnotationNullableValue> mark, [JetBrains.Annotations.CanBeNullAttribute()] string contract);
        public abstract void Commit();
    }
    public class AnnotationsStorage : System.Collections.Generic.IEnumerable<JetBrains.Util.JetTuple<JetBrains.ReSharper.Psi.IAttributesOwner, System.Nullable<JetBrains.ReSharper.Psi.CodeAnnotations.CodeAnnotationNullableValue>, string>>, System.Collections.IEnumerable
    {
        public AnnotationsStorage() { }
        public System.Nullable<JetBrains.ReSharper.Psi.CodeAnnotations.CodeAnnotationNullableValue> this[JetBrains.ReSharper.Psi.IAttributesOwner owner] { get; set; }
        public bool AnnotaionsSetEquals(JetBrains.ReSharper.Features.Internal.Annotator.AnnotationsStorage other) { }
        public JetBrains.ReSharper.Features.Internal.Annotator.AnnotationsStorage Clone() { }
        public bool ContainsAttributeOwner(JetBrains.ReSharper.Psi.IAttributesOwner owner) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public string GetContract(JetBrains.ReSharper.Psi.IAttributesOwner method) { }
        public System.Collections.Generic.IEnumerator<JetBrains.Util.JetTuple<JetBrains.ReSharper.Psi.IAttributesOwner, System.Nullable<JetBrains.ReSharper.Psi.CodeAnnotations.CodeAnnotationNullableValue>, string>> GetEnumerator() { }
        public void SetContract(JetBrains.ReSharper.Psi.IAttributesOwner method, [JetBrains.Annotations.CanBeNullAttribute()] string value) { }
    }
    public class Annotator
    {
        public Annotator(JetBrains.ReSharper.Features.Internal.Annotator.IAnnotatingArea annotatingArea, JetBrains.Application.CommandProcessing.ICommandProcessor commandProcessor, JetBrains.ReSharper.Psi.Search.SearchDomainFactory searchDomainFactory) { }
        public Annotator(JetBrains.ReSharper.Features.Internal.Annotator.IAnnotatingArea annotatingArea, JetBrains.ReSharper.Features.Internal.Annotator.AnnotationsApplier annotationsApplier, JetBrains.ReSharper.Features.Internal.Annotator.PredefinedContext predefinedContext, JetBrains.Application.CommandProcessing.ICommandProcessor commandProcessor, JetBrains.ReSharper.Psi.Search.SearchDomainFactory searchDomainFactory) { }
        public void Annotate(JetBrains.Application.Progress.IProgressIndicator progress) { }
        public void Run() { }
    }
    public class AnnotatorDialog : System.Windows.Forms.Form
    {
        public AnnotatorDialog(JetBrains.ProjectModel.ISolution solution) { }
        public bool AnalyzeInterfaces { get; }
        public bool DumpModuleVersion { get; }
        public string IgnoredDeclarationsDirectory { get; }
        public bool IsXmlFilesOutput { get; }
        public string OutputXmlFilesDirectory { get; }
        public string PreDefinedAnnotationsDirectory { get; }
        public System.Collections.Generic.ICollection<JetBrains.ProjectModel.Model2.Assemblies.Interfaces.IAssembly> SelectedAssemblies { get; }
        public System.Collections.Generic.ICollection<JetBrains.ProjectModel.IProject> SelectedProjects { get; }
        public bool SeparateInterfacesFiles { get; }
        protected override void Dispose(bool disposing) { }
        public static System.Collections.Generic.List<JetBrains.ProjectModel.IProject> Run(JetBrains.ProjectModel.ISolution solution) { }
    }
    public class static AnnotatorUtil
    {
        public const string TerminatingMethodContract = "=>void";
        public static void ApplyInspectionAttribute(JetBrains.ReSharper.Psi.CSharp.Tree.IAttributesOwnerDeclaration declaration, System.Nullable<JetBrains.ReSharper.Psi.CodeAnnotations.CodeAnnotationNullableValue> mark, string contract) { }
        public static bool ShouldSkipHierarchyConsistencyCheck(JetBrains.ReSharper.Psi.IOverridableMember overridableMember) { }
    }
    public class AssemblyAnnotatingArea : JetBrains.ReSharper.Features.Internal.Annotator.IAnnotatingArea
    {
        public AssemblyAnnotatingArea(JetBrains.ReSharper.Psi.IPsiServices psiServices, System.Collections.Generic.IEnumerable<JetBrains.ProjectModel.Model2.Assemblies.Interfaces.IAssembly> assemblies, bool annotateInterfaces = False, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IDeclaredElement> ignoredElements = null) { }
        public bool AnalyzeInterfaces { get; }
        public string Name { get; }
        public JetBrains.ReSharper.Psi.Search.ISearchDomain SearchDomain { get; }
        public bool TakeAccountOnHierarchy { get; }
        public bool Contains(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
        public void ForEachInDeclarations(System.Action<JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpTypeMemberDeclaration> action) { }
        public void IgnoreElement(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
    }
    public class ExportDialog : System.Windows.Forms.Form
    {
        public ExportDialog(JetBrains.ProjectModel.ISolution solution) { }
        public string BaseDir { get; }
        public bool CreateSeparateDirectoryForEachProject { get; }
        public bool ExportOnlyPublicAPI { get; }
        public System.Collections.Generic.HashSet<string> SelectedAttributes { get; }
        public System.Collections.Generic.ICollection<JetBrains.ProjectModel.IProject> SelectedProjects { get; }
        public string Suffix { get; }
        protected override void Dispose(bool disposing) { }
    }
    public interface IAnnotatingArea
    {
        bool AnalyzeInterfaces { get; }
        string Name { get; }
        JetBrains.ReSharper.Psi.Search.ISearchDomain SearchDomain { get; }
        bool TakeAccountOnHierarchy { get; }
        bool Contains(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement);
        void ForEachInDeclarations([JetBrains.Annotations.InstantHandleAttribute()] System.Action<JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpTypeMemberDeclaration> action);
        void IgnoreElement(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement);
    }
    public class MultiProjectAnnotatingArea : JetBrains.ReSharper.Features.Internal.Annotator.IAnnotatingArea
    {
        public MultiProjectAnnotatingArea(System.Collections.Generic.IEnumerable<JetBrains.ProjectModel.IProject> projects, bool annotateInterfaces = False, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IDeclaredElement> ignoredElements = null) { }
        public bool AnalyzeInterfaces { get; }
        public string Name { get; }
        public JetBrains.ReSharper.Psi.Search.ISearchDomain SearchDomain { get; }
        public bool TakeAccountOnHierarchy { get; }
        public bool Contains(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
        public void ForEachInDeclarations(System.Action<JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpTypeMemberDeclaration> action) { }
        public void IgnoreElement(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
    }
    public class PredefinedContext
    {
        public static readonly System.Collections.Generic.KeyValuePair<string, bool> TerminatingMethod;
        public PredefinedContext() { }
        public JetBrains.ReSharper.Features.Internal.Annotator.AnnotationsStorage Annotations { get; }
        public void CollectAnnotations(JetBrains.ProjectModel.ISolution solution, string preDefinedAnnotationsDirectory) { }
        public void CollectAnnotations(JetBrains.ProjectModel.ISolution solution, System.IO.TextReader inStream) { }
    }
    public class SingleDeclarationAnnotatingArea : JetBrains.ReSharper.Features.Internal.Annotator.IAnnotatingArea
    {
        public SingleDeclarationAnnotatingArea(JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpTypeMemberDeclaration declaration) { }
        public bool AnalyzeInterfaces { get; }
        public string Name { get; }
        public JetBrains.ReSharper.Psi.Search.ISearchDomain SearchDomain { get; }
        public bool TakeAccountOnHierarchy { get; }
        public bool Contains(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
        public void ForEachInDeclarations(System.Action<JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpTypeMemberDeclaration> action) { }
        public void IgnoreElement(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
    }
    public class ToSourceCodeAnnotationsApplier : JetBrains.ReSharper.Features.Internal.Annotator.AnnotationsApplier
    {
        public override void ApplySingleAnnotation(JetBrains.ReSharper.Psi.IAttributesOwner declaredElement, System.Nullable<JetBrains.ReSharper.Psi.CodeAnnotations.CodeAnnotationNullableValue> mark, string contract) { }
        public override void Commit() { }
    }
}
namespace JetBrains.ReSharper.Features.Internal.ChangeManagerViewer
{
    
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "ViewChangeManager"})]
    public class ViewChangeManagerAction : JetBrains.ActionManagement.IActionHandler
    {
        public void Execute(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.DelegateExecute nextExecute) { }
        public bool Update(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.ActionPresentation presentation, JetBrains.ActionManagement.DelegateUpdate nextUpdate) { }
    }
    public class ViewChangeManagerExecuter : JetBrains.ReSharper.Features.Internal.ProjectDependenciesBuilder.AbstractGraphWriter.IGraph<JetBrains.Application.IChangeProvider, JetBrains.Application.IChangeProvider>, System.Collections.Generic.IEqualityComparer<JetBrains.Application.IChangeProvider>
    {
        public ViewChangeManagerExecuter(JetBrains.Application.Changes.ChangeManagerImpl manager) { }
        public System.Collections.Generic.IEnumerable<JetBrains.Application.IChangeProvider> Groups { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.Application.IChangeProvider> Nodes { get; }
        public JetBrains.Application.IChangeProvider RootGroup { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.Application.IChangeProvider> Ancestors(JetBrains.Application.IChangeProvider node) { }
        public System.Collections.Generic.IEnumerable<JetBrains.Application.IChangeProvider> Descendants(JetBrains.Application.IChangeProvider node) { }
        public bool Equals(JetBrains.Application.IChangeProvider x, JetBrains.Application.IChangeProvider y) { }
        public int GetHashCode(JetBrains.Application.IChangeProvider obj) { }
        public JetBrains.Application.IChangeProvider OwnerGroup(JetBrains.Application.IChangeProvider node) { }
        public string PresentGroup(JetBrains.Application.IChangeProvider groupIndex) { }
        public string PresentNode(JetBrains.Application.IChangeProvider node) { }
    }
}
namespace JetBrains.ReSharper.Features.Internal.CodeBehind
{
    
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "ViewCodeBehind1",
            "ViewCodeBehind2",
            "ViewCodeBehind3",
            "ViewCodeBehind4",
            "ViewCodeBehind5",
            "ViewCodeBehind6",
            "ViewCodeBehind7",
            "ViewCodeBehind8",
            "ViewCodeBehind9"})]
    public class ViewCodeBehindAction : JetBrains.ActionManagement.IActionHandler
    {
        public ViewCodeBehindAction(string handlerId) { }
        public void Execute(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.DelegateExecute nextExecute) { }
        public bool Update(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.ActionPresentation presentation, JetBrains.ActionManagement.DelegateUpdate nextUpdate) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class ViewCodeBehindManager
    {
        public ViewCodeBehindManager(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ReSharper.Features.Internal.CodeBehind.ViewCodeBehindToolWindowDescriptor toolWindowDescriptor, JetBrains.UI.ToolWindowManagement.ToolWindowManager toolWindowManager, JetBrains.TextControl.TextControlManager textControlManager, JetBrains.DocumentModel.IInMemoryDocumentFactory shellDocumentFactory, JetBrains.TextControl.DefaultTextControlSchemeManager defaultTextControlSchemeManager, JetBrains.TextControl.DocumentMarkup.IDocumentMarkupManager documentMarkupManager, JetBrains.ProjectModel.ISolution solution) { }
        public void Show(JetBrains.ReSharper.Psi.Tree.IFile file, string title) { }
    }
    [JetBrains.UI.ToolWindowManagement.ToolWindowDescriptorAttribute(Icon=typeof(JetBrains.ReSharper.Features.Internal.Resources.FeaturesInternalThemedIcons.CodeBehindToolWindow), ProductNeutralId="Resharper.CodeBehindToolwindow", Text="Code Behind", Type=JetBrains.UI.ToolWindowManagement.ToolWindowType.MultiInstance, VisibilityPersistenceScope=JetBrains.UI.ToolWindowManagement.ToolWindowVisibilityPersistenceScope.Solution)]
    public class ViewCodeBehindToolWindowDescriptor : JetBrains.UI.ToolWindowManagement.ToolWindowDescriptor
    {
        public ViewCodeBehindToolWindowDescriptor(JetBrains.Application.IApplicationDescriptor applicationDescriptor) { }
    }
}
namespace JetBrains.ReSharper.Features.Internal.CommandPrompt
{
    
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "NavigateToCommandPrompt"})]
    public class OpenCommandPromptAction : JetBrains.ReSharper.Features.Finding.NavigateFromHere.ContextNavigationActionBase<JetBrains.ReSharper.Features.Internal.CommandPrompt.OpenCommandPromptProvider> { }
    [JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextNavigationProviderAttribute()]
    public class OpenCommandPromptProvider : JetBrains.ReSharper.Features.Internal.CommandPrompt.OpenCommandPromptProviderBase
    {
        protected override System.Diagnostics.ProcessStartInfo GetProcessStartInfo(JetBrains.Util.FileSystemPath path) { }
        protected override string GetTitle() { }
    }
    public abstract class OpenCommandPromptProviderBase : JetBrains.ReSharper.Feature.Services.ActionsMenu.IWorkflowProvider<JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextNavigation, JetBrains.ReSharper.Feature.Services.ContextNavigation.NavigationActionGroup>, JetBrains.ReSharper.Feature.Services.ContextNavigation.INavigateFromHereProvider
    {
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextNavigation> CreateWorkflow(JetBrains.Application.DataContext.IDataContext dataContext) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        protected virtual JetBrains.Util.FileSystemPath GetPathByContext([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.DataContext.IDataContext context) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        protected abstract System.Diagnostics.ProcessStartInfo GetProcessStartInfo([JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.FileSystemPath path);
        protected abstract string GetTitle();
    }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "NavigateToWindowsExplorer"})]
    public class OpenWindowsExplorerAction : JetBrains.ReSharper.Features.Finding.NavigateFromHere.ContextNavigationActionBase<JetBrains.ReSharper.Features.Internal.CommandPrompt.OpenWindowsExplorerProvider> { }
    [JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextNavigationProviderAttribute()]
    public class OpenWindowsExplorerProvider : JetBrains.ReSharper.Features.Internal.CommandPrompt.OpenCommandPromptProviderBase
    {
        protected override System.Diagnostics.ProcessStartInfo GetProcessStartInfo(JetBrains.Util.FileSystemPath path) { }
        protected override string GetTitle() { }
    }
}
namespace JetBrains.ReSharper.Features.Internal.ControlFlowGraphViewer
{
    
    public class ControlFlowGraphView : JetBrains.ReSharper.Features.Internal.ProjectDependenciesBuilder.AbstractGraphWriter.IGraph<JetBrains.ReSharper.Psi.ControlFlow.IControlFlowElement, JetBrains.ReSharper.Psi.ControlFlow.IControlFlowElement>, System.Collections.Generic.IEqualityComparer<JetBrains.ReSharper.Psi.ControlFlow.IControlFlowElement>
    {
        public ControlFlowGraphView(JetBrains.ReSharper.Psi.ControlFlow.IControlFlowGraf graf) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.ControlFlow.IControlFlowElement> Groups { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.ControlFlow.IControlFlowElement> Nodes { get; }
        public JetBrains.ReSharper.Psi.ControlFlow.IControlFlowElement RootGroup { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.ControlFlow.IControlFlowElement> Ancestors(JetBrains.ReSharper.Psi.ControlFlow.IControlFlowElement node) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.ControlFlow.IControlFlowElement> Descendants(JetBrains.ReSharper.Psi.ControlFlow.IControlFlowElement node) { }
        public bool Equals(JetBrains.ReSharper.Psi.ControlFlow.IControlFlowElement x, JetBrains.ReSharper.Psi.ControlFlow.IControlFlowElement y) { }
        public int GetHashCode(JetBrains.ReSharper.Psi.ControlFlow.IControlFlowElement obj) { }
        public JetBrains.ReSharper.Psi.ControlFlow.IControlFlowElement OwnerGroup(JetBrains.ReSharper.Psi.ControlFlow.IControlFlowElement node) { }
        public string PresentGroup(JetBrains.ReSharper.Psi.ControlFlow.IControlFlowElement groupIndex) { }
        public string PresentNode(JetBrains.ReSharper.Psi.ControlFlow.IControlFlowElement element) { }
    }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "ViewControlFlowGraph"})]
    public class ViewControlFlowGraphAction : JetBrains.ActionManagement.IActionHandler
    {
        public void Execute(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.DelegateExecute nextExecute) { }
        public bool Update(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.ActionPresentation presentation, JetBrains.ActionManagement.DelegateUpdate nextUpdate) { }
    }
}
namespace JetBrains.ReSharper.Features.Internal.DocumentMarkupDiagnistics
{
    
    [JetBrains.ActionManagement.ActionHandlerAttribute()]
    public class DumpDocumentMarkupAction : JetBrains.ActionManagement.IActionHandler
    {
        public void Execute(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.DelegateExecute nextExecute) { }
        public bool Update(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.ActionPresentation presentation, JetBrains.ActionManagement.DelegateUpdate nextUpdate) { }
    }
}
namespace JetBrains.ReSharper.Features.Internal.DumpSymbolCache
{
    
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "DumpSymbolCache"})]
    public class DumpSymbolCacheAction : JetBrains.ActionManagement.IActionHandler
    {
        public void Execute(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.DelegateExecute nextExecute) { }
        public bool Update(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.ActionPresentation presentation, JetBrains.ActionManagement.DelegateUpdate nextUpdate) { }
    }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "DumpSymbolCacheForFile"})]
    public class DumpSymbolCacheForFileAction : JetBrains.ActionManagement.IActionHandler
    {
        public void Execute(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.DelegateExecute nextExecute) { }
        public bool Update(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.ActionPresentation presentation, JetBrains.ActionManagement.DelegateUpdate nextUpdate) { }
    }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "PsiFilesCacheStats"})]
    public class PsiFilesCacheStats : JetBrains.ActionManagement.IActionHandler
    {
        public void Execute(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.DelegateExecute nextExecute) { }
        public bool Update(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.ActionPresentation presentation, JetBrains.ActionManagement.DelegateUpdate nextUpdate) { }
    }
}
namespace JetBrains.ReSharper.Features.Internal.GotoTestData
{
    
    [JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextNavigationProviderAttribute()]
    public class OpenTestDataInFarProvider : JetBrains.ReSharper.Features.Internal.CommandPrompt.OpenCommandPromptProviderBase
    {
        protected override JetBrains.Util.FileSystemPath GetPathByContext(JetBrains.Application.DataContext.IDataContext context) { }
        protected override System.Diagnostics.ProcessStartInfo GetProcessStartInfo(JetBrains.Util.FileSystemPath path) { }
        protected override string GetTitle() { }
    }
}
namespace JetBrains.ReSharper.Features.Internal.MvcAnnotator
{
    
    [JetBrains.ActionManagement.ActionHandlerAttribute()]
    public class MvcAnnotatorActionHandler : JetBrains.ActionManagement.IActionHandler
    {
        public void Execute(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.DelegateExecute nextExecute) { }
        public bool Update(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.ActionPresentation presentation, JetBrains.ActionManagement.DelegateUpdate nextUpdate) { }
    }
}
namespace JetBrains.ReSharper.Features.Internal.ProjectDependenciesBuilder.AbstractGraphWriter
{
    
    public class GraphWriter<TGraphGroupNode, TGraphNode>
    
    
    {
        public GraphWriter(JetBrains.ReSharper.Features.Internal.ProjectDependenciesBuilder.AbstractGraphWriter.IGraph<TGraphGroupNode, TGraphNode> graph) { }
        public void Write(System.IO.StreamWriter writer) { }
    }
    public interface IGraph<TGraphGroupNode, TGraphNode> : System.Collections.Generic.IEqualityComparer<TGraphGroupNode>
    
    
    {
        System.Collections.Generic.IEnumerable<TGraphGroupNode> Groups { get; }
        System.Collections.Generic.IEnumerable<TGraphNode> Nodes { get; }
        TGraphGroupNode RootGroup { get; }
        System.Collections.Generic.IEnumerable<TGraphNode> Ancestors(TGraphNode node);
        System.Collections.Generic.IEnumerable<TGraphNode> Descendants(TGraphNode node);
        TGraphGroupNode OwnerGroup(TGraphNode node);
        string PresentGroup(TGraphGroupNode groupIndex);
        string PresentNode(TGraphNode node);
    }
}
namespace JetBrains.ReSharper.Features.Internal.ProjectDependenciesBuilder
{
    
    public class BuildDependeciesController : JetBrains.ReSharper.Features.Common.UI.CheckedTreeViewController<JetBrains.ReSharper.Features.Common.UI.ProjectInHierarchyItem>
    {
        public BuildDependeciesController(System.Collections.Generic.ICollection<JetBrains.ReSharper.Features.Common.UI.ProjectInHierarchyItem> selectedItems, [JetBrains.Annotations.CanBeNullAttribute()] System.Comparison<JetBrains.ReSharper.Features.Common.UI.ProjectInHierarchyItem> nodesComparer, JetBrains.ReSharper.Features.Internal.ProjectDependenciesBuilder.DependenciesBuilder dependenciesBuilder) { }
        public void AddAncestors() { }
        public void AddDescendants() { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class BuildDependenciesFeatureManager
    {
        public BuildDependenciesFeatureManager(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.Settings.ISettingsStore settingsStore, JetBrains.ProjectModel.ISolution solution) { }
        public bool ExcludeTerminalNodes { get; set; }
        public bool IsIncluded(string name) { }
        public void SetExcluded(System.Collections.Generic.IEnumerable<string> excluded) { }
    }
    [JetBrains.Application.Settings.SettingsKeyAttribute(typeof(JetBrains.Application.Settings.HousekeepingSettings), "Build dependencies featue")]
    public class BuildDependenciesManagerSettingsKey
    {
        [JetBrains.Application.Settings.SettingsIndexedEntryAttribute("Excluded project names")]
        public JetBrains.Application.Settings.Store.IIndexedEntry<string, string> ExcludedProjects;
        [JetBrains.Application.Settings.SettingsEntryAttribute(true, "Exclude terminal nodes")]
        public bool ExcludeTerminalNodes;
    }
    public class BuildDependenciesWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector
    {
        public BuildDependenciesWindow(JetBrains.ReSharper.Features.Internal.ProjectDependenciesBuilder.BuildDependeciesController controller, bool excludeTerminalNodes) { }
        public System.Windows.Media.SolidColorBrush ButtonsPanelBrush { get; set; }
        public bool ExcludeTerminalNodes { get; set; }
        public void InitializeComponent() { }
    }
    public class DependenciesBuilder : JetBrains.ReSharper.Features.Internal.ProjectDependenciesBuilder.AbstractGraphWriter.IGraph<int, int>, System.Collections.Generic.IEqualityComparer<int>
    {
        public DependenciesBuilder(JetBrains.ProjectModel.ISolution solution) { }
        public bool FilterTerminating { get; set; }
        public System.Collections.Generic.IEnumerable<int> Groups { get; }
        public System.Collections.Generic.IEnumerable<int> Nodes { get; }
        public int RootGroup { get; }
        public void AddSurroundingNodes(System.Collections.Generic.ICollection<JetBrains.ReSharper.Features.Common.UI.ProjectInHierarchyItem> allItems, bool anc) { }
        public void Analyse(JetBrains.Application.Progress.IProgressIndicator pi) { }
        public System.Collections.Generic.IEnumerable<int> Ancestors(int node) { }
        public System.Collections.Generic.List<JetBrains.ReSharper.Features.Common.UI.ProjectInHierarchyItem> BuildNodes(JetBrains.ReSharper.Features.Internal.ProjectDependenciesBuilder.BuildDependenciesFeatureManager manager) { }
        public System.Collections.Generic.IEnumerable<int> Descendants(int node) { }
        public void Dump(System.Collections.Generic.List<JetBrains.ReSharper.Features.Common.UI.ProjectInHierarchyItem> items, JetBrains.Application.Progress.IProgressIndicator pi) { }
        public bool Equals(int x, int y) { }
        public int GetHashCode(int obj) { }
        public int OwnerGroup(int node) { }
        public string PresentGroup(int groupIndex) { }
        public string PresentNode(int node) { }
    }
}
namespace JetBrains.ReSharper.Features.Internal.ProjectModel
{
    
    [JetBrains.ActionManagement.ActionHandlerAttribute()]
    public class DumpProjectModelActionHandler : JetBrains.ActionManagement.IActionHandler
    {
        public void Execute(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.DelegateExecute nextExecute) { }
        public bool Update(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.ActionPresentation presentation, JetBrains.ActionManagement.DelegateUpdate nextUpdate) { }
    }
}
namespace JetBrains.ReSharper.Features.Internal.PsiBrowser
{
    
    [JetBrains.Application.ShellComponentAttribute()]
    public class PsiBrowserSettings
    {
        public static JetBrains.ReSharper.Features.Internal.PsiBrowser.PsiBrowserSettings Instance { get; }
        public bool ShowCachedTree { get; set; }
        public bool ShowWhitespaces { get; set; }
        public bool SyncWithEditor { get; set; }
    }
    [JetBrains.UI.ToolWindowManagement.ToolWindowDescriptorAttribute(Icon=typeof(JetBrains.ReSharper.Psi.Resources.PsiSymbolsThemedIcons.Constructor), ProductNeutralId="PsiBrowserWindow", Text="PSI Browser", Type=JetBrains.UI.ToolWindowManagement.ToolWindowType.SingleInstance, VisibilityPersistenceScope=JetBrains.UI.ToolWindowManagement.ToolWindowVisibilityPersistenceScope.Solution)]
    public class PsiBrowserToolWindowDescriptor : JetBrains.UI.ToolWindowManagement.ToolWindowDescriptor
    {
        public PsiBrowserToolWindowDescriptor(JetBrains.Application.IApplicationDescriptor applicationDescriptor) { }
    }
}
namespace JetBrains.ReSharper.Features.Internal.PsiCleanup
{
    
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "PsiCleanup"})]
    public class PsiCleanupAction : JetBrains.ActionManagement.IActionHandler
    {
        public void Execute(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.DelegateExecute nextExecute) { }
        public bool Update(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.ActionPresentation presentation, JetBrains.ActionManagement.DelegateUpdate nextUpdate) { }
    }
}
namespace JetBrains.ReSharper.Features.Internal.PsiModuleBrowser
{
    
    [JetBrains.UI.ToolWindowManagement.ToolWindowDescriptorAttribute(Icon=typeof(JetBrains.ReSharper.Psi.Resources.PsiSymbolsThemedIcons.Namespace), ProductNeutralId="PsiModuleBrowserWindow", Text="PSI Module Browser", Type=JetBrains.UI.ToolWindowManagement.ToolWindowType.SingleInstance, VisibilityPersistenceScope=JetBrains.UI.ToolWindowManagement.ToolWindowVisibilityPersistenceScope.Solution)]
    public class PsiModuleBrowserToolWindowDescriptor : JetBrains.UI.ToolWindowManagement.ToolWindowDescriptor
    {
        public PsiModuleBrowserToolWindowDescriptor(JetBrains.Application.IApplicationDescriptor applicationDescriptor) { }
    }
}
namespace JetBrains.ReSharper.Features.Internal.PsiViewer
{
    
    public class FindDialog : System.Windows.Forms.Form
    {
        public FindDialog() { }
        public FindDialog(JetBrains.ReSharper.Features.Internal.PsiViewer.FindModel model, JetBrains.UI.AbstractTreeBuilder.IAbstractTreeControl ownerTreeView, JetBrains.UI.AbstractTreeBuilder.IAbstractTreeNode focusedNode) { }
        public JetBrains.ReSharper.Features.Internal.PsiViewer.FindModel Model { get; set; }
        protected override void Dispose(bool disposing) { }
        public void ShowModeless() { }
    }
    public class FindModel
    {
        public FindModel(System.Action<JetBrains.UI.AbstractTreeBuilder.IAbstractTreeNode> found) { }
        public void OnFindInvoked(JetBrains.UI.AbstractTreeBuilder.IAbstractTreeControl treeControl, JetBrains.UI.AbstractTreeBuilder.IAbstractTreeNode focusedNode, JetBrains.ReSharper.Features.Internal.PsiViewer.FindModel.FindArgs args) { }
        public struct FindArgs
        {
            public bool MatchCase;
            public bool SearchUp;
            public string TextToFind;
            public FindArgs(string textToSearch, bool matchCase, bool searchUp) { }
        }
    }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "GoToPsiViewer"})]
    public class GotoPsiViewerAction : JetBrains.ReSharper.Features.Internal.PsiViewer.PsiViewerActionBase
    {
        protected override bool FromEditor { get; }
        public override bool Update(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.ActionPresentation presentation, JetBrains.ActionManagement.DelegateUpdate nextUpdate) { }
    }
    public interface IControlFlowViewer
    {
        bool CanShow(JetBrains.ReSharper.Psi.Tree.ITreeNode treeNode);
        void Show(JetBrains.ReSharper.Psi.Tree.ITreeNode treeNode);
    }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "PsiViewer"})]
    public class PsiViewerAction : JetBrains.ReSharper.Features.Internal.PsiViewer.PsiViewerActionBase
    {
        protected override bool FromEditor { get; }
    }
    public abstract class PsiViewerActionBase : JetBrains.ActionManagement.IActionHandler
    {
        protected abstract bool FromEditor { get; }
        public virtual void Execute(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.DelegateExecute nextExecute) { }
        public virtual bool Update(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.ActionPresentation presentation, JetBrains.ActionManagement.DelegateUpdate nextUpdate) { }
    }
    public class PsiViewerForm : System.Windows.Forms.Form
    {
        public PsiViewerForm(JetBrains.ReSharper.Features.Internal.PsiViewer.PsiViewerModel model, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Features.Internal.PsiViewer.IControlFlowViewer controlFlowViewer, JetBrains.UI.Application.IUIApplication environment) { }
        public JetBrains.UI.Application.IUIApplication Environment { get; }
        protected override void Dispose(bool disposing) { }
        public void ShowDialog(bool fromEditor) { }
    }
    public class PsiViewerModel : System.IDisposable
    {
        public PsiViewerModel(JetBrains.ProjectModel.ISolution activeSolution) { }
        public JetBrains.ProjectModel.ISolution ActiveSolution { get; }
        public JetBrains.UI.AbstractTreeBuilder.ITreeStructurePresenter TreePresenter { get; }
        public JetBrains.UI.AbstractTreeBuilder.IAbstractTreeStructure TreeStructure { get; }
        public void ClearAll() { }
        public void Dispose() { }
        public static JetBrains.ProjectModel.IProjectFile GetCurrentProjectItem(JetBrains.ProjectModel.ISolution solution) { }
        public void NavigateTo(object element) { }
        public void OnBindToActiveDocument() { }
        public void OnCreatePsi(string capability, JetBrains.ReSharper.Psi.LanguageService languageService, JetBrains.TextControl.IWinFormTextControl textControl) { }
        public void OnLoadAssembly(string assemblyPath) { }
        public void SetShowWhiteSpaces(bool showWhitespaces) { }
    }
}
namespace JetBrains.ReSharper.Features.Internal.QuickStart
{
    
    [JetBrains.ProjectModel.SolutionComponentAttribute(JetBrains.Application.Components.ProgramConfigurations.NONE | JetBrains.Application.Components.ProgramConfigurations.VS_ADDIN | JetBrains.Application.Components.ProgramConfigurations.ALL)]
    public class QuickStartManager
    {
        public QuickStartManager(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ProjectModel.ISolution solution, JetBrains.UI.ToolWindowManagement.ToolWindowManager toolWindowManager, JetBrains.ReSharper.Features.Internal.QuickStart.QuickStartManagerToolWindowDescriptor toolWindowDescriptor, JetBrains.ActionManagement.ActionManager actionManager, JetBrains.Application.Interop.NativeHook.IWindowsHookManager windowsHookManager, JetBrains.Application.IShellLocks shellLocks, JetBrains.ReSharper.Psi.IPsiServices psiServices, JetBrains.ActionManagement.IShortcutManager shortcutManager, JetBrains.Application.Settings.ISettingsStore settingsStore, JetBrains.Application.DataContext.DataContexts dataContexts, JetBrains.UI.Application.IUIApplication environment) { }
    }
    [JetBrains.UI.ToolWindowManagement.ToolWindowDescriptorAttribute(Icon=typeof(JetBrains.ReSharper.Features.Internal.Resources.FeaturesInternalThemedIcons.QuickStartToolWindow), ProductNeutralId="QuickStartWindow", Text="Quick Start", Type=JetBrains.UI.ToolWindowManagement.ToolWindowType.SingleInstance, VisibilityPersistenceScope=JetBrains.UI.ToolWindowManagement.ToolWindowVisibilityPersistenceScope.Solution)]
    public class QuickStartManagerToolWindowDescriptor : JetBrains.UI.ToolWindowManagement.ToolWindowDescriptor
    {
        public QuickStartManagerToolWindowDescriptor(JetBrains.Application.IApplicationDescriptor applicationDescriptor) { }
    }
}
namespace JetBrains.ReSharper.Features.Internal.Resources
{
    
    public sealed class FeaturesInternalThemedIcons
    {
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Features.Internal;component/resources/FeaturesInternalThemedI" +
            "cons/ThemedIcons.FeaturesInternal.Generated.Xaml", 0, "CodeBehindToolWindow")]
        public sealed class CodeBehindToolWindow : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Features.Internal;component/resources/FeaturesInternalThemedI" +
            "cons/ThemedIcons.FeaturesInternal.Generated.Xaml", 1, "QuickStartToolWindow")]
        public sealed class QuickStartToolWindow : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Features.Internal;component/resources/FeaturesInternalThemedI" +
            "cons/ThemedIcons.FeaturesInternal.Generated.Xaml", 2, "TypeBrowserToolWindow")]
        public sealed class TypeBrowserToolWindow : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
    }
}
namespace JetBrains.ReSharper.Features.Internal.src.Annotator
{
    
    public class ImportContractAssemblyDialog : System.Windows.Forms.Form
    {
        public ImportContractAssemblyDialog(JetBrains.ProjectModel.ISolution solution) { }
        public System.Collections.Generic.List<JetBrains.ProjectModel.Model2.Assemblies.Interfaces.IAssemblyCookie> Assemblies { get; }
        public string OutputPath { get; }
        public string OutputSuffix { get; }
        public bool OutputVersion { get; }
        protected override void Dispose(bool disposing) { }
    }
}
namespace JetBrains.ReSharper.Features.Internal.TestForm
{
    
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "ShowModalForm"})]
    public class ShowModalFormAction : JetBrains.ActionManagement.IActionHandler
    {
        public void Execute(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.DelegateExecute nextExecute) { }
        public bool Update(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.ActionPresentation presentation, JetBrains.ActionManagement.DelegateUpdate nextUpdate) { }
    }
}
namespace JetBrains.ReSharper.Features.Internal.TestNavigation
{
    
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "GoToBaseFile"})]
    public class GoToBaseFileAction : JetBrains.ReSharper.Features.Internal.TestNavigation.GoToNeighbourFileActionBase
    {
        protected override bool CreateMissingFile { get; }
        protected override JetBrains.Util.FileSystemPath TransformFileName(JetBrains.Util.FileSystemPath fileName) { }
    }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "GoToGoldFile"})]
    public class GoToGoldFileAction : JetBrains.ReSharper.Features.Internal.TestNavigation.GoToNeighbourFileActionBase
    {
        protected override bool CreateMissingFile { get; }
        protected override JetBrains.Util.FileSystemPath TransformFileName(JetBrains.Util.FileSystemPath fileName) { }
    }
    public abstract class GoToNeighbourFileActionBase : JetBrains.ActionManagement.IActionHandler
    {
        protected abstract bool CreateMissingFile { get; }
        public void Execute(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.DelegateExecute nextExecute) { }
        protected abstract JetBrains.Util.FileSystemPath TransformFileName(JetBrains.Util.FileSystemPath fileName);
        public bool Update(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.ActionPresentation presentation, JetBrains.ActionManagement.DelegateUpdate nextUpdate) { }
    }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "GoToTempFile"})]
    public class GoToTempFileAction : JetBrains.ReSharper.Features.Internal.TestNavigation.GoToNeighbourFileActionBase
    {
        protected override bool CreateMissingFile { get; }
        protected override JetBrains.Util.FileSystemPath TransformFileName(JetBrains.Util.FileSystemPath fileName) { }
    }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "GoToTestFile"})]
    public class GoToTestFileAction : JetBrains.ActionManagement.IActionHandler
    {
        public void Execute(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.DelegateExecute nextExecute) { }
        public bool Update(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.ActionPresentation presentation, JetBrains.ActionManagement.DelegateUpdate nextUpdate) { }
    }
}
namespace JetBrains.ReSharper.Features.Internal.TypeBrowser
{
    
    [JetBrains.ProjectModel.SolutionComponentAttribute(JetBrains.Application.Components.ProgramConfigurations.NONE | JetBrains.Application.Components.ProgramConfigurations.STANDALONE | JetBrains.Application.Components.ProgramConfigurations.VS_ADDIN | JetBrains.Application.Components.ProgramConfigurations.ALL)]
    public class TypeBrowser
    {
        public TypeBrowser(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ProjectModel.ISolution solution, JetBrains.UI.ToolWindowManagement.ToolWindowManager toolWindowManager, JetBrains.ReSharper.Features.Internal.TypeBrowser.TypeBrowserToolWindowDescriptor toolWindowDescriptor, JetBrains.ProjectModel.ISolutionOwner solutionOwner, JetBrains.UI.Application.IUIApplication environment) { }
        public void RefreshView() { }
    }
    public class TypeBrowserDescriptor : JetBrains.ReSharper.Features.Common.TreePsiBrowser.TreeModelBrowserDescriptorPsi
    {
        public TypeBrowserDescriptor(JetBrains.ProjectModel.ISolution solution, JetBrains.UI.Application.IUIApplication environment) { }
        public override string ActionBarID { get; }
        public override string ContextMenuID { get; }
        public override JetBrains.TreeModels.TreeModel Model { get; }
        public override JetBrains.UI.TreeView.StructuredPresenter<JetBrains.TreeModels.TreeModelNode, JetBrains.CommonControls.IPresentableItem> Presenter { get; }
        public override string PreviewActionName { get; }
        public override JetBrains.IDE.TreeBrowser.PreviewSupport PreviewSupport { get; }
        public override bool QuickSearchSupported { get; }
        public override bool CustomizeActionBar(JetBrains.ActionManagement.IActionBar bar) { }
        public override System.Windows.Forms.Control PreviewCreateControl(JetBrains.UI.WindowManagement.WindowFrame framePreview) { }
        public override void PreviewUpdate(System.Windows.Forms.Control previewControl, JetBrains.TreeModels.TreeModelNode modelNode, ref JetBrains.CommonControls.IPresentableItem previewCaption) { }
        public override bool QuickSearchMatches(JetBrains.TreeModels.TreeModelNode modelNode, string quickSearchText) { }
        public void Refresh() { }
    }
    public class TypeBrowserMembersDescriptor : JetBrains.ReSharper.Features.Common.TreePsiBrowser.TreeModelBrowserDescriptorPsi
    {
        public TypeBrowserMembersDescriptor(JetBrains.ReSharper.Features.Internal.TypeBrowser.TypeBrowserDescriptor parentDescriptor, JetBrains.ProjectModel.ISolution solution) { }
        public override string ActionBarID { get; }
        public override string ContextMenuID { get; }
        public override JetBrains.TreeModels.TreeModel Model { get; }
        public JetBrains.ReSharper.Features.Internal.TypeBrowser.TypeBrowserDescriptor ParentDescriptor { get; }
        public override JetBrains.UI.TreeView.StructuredPresenter<JetBrains.TreeModels.TreeModelNode, JetBrains.CommonControls.IPresentableItem> Presenter { get; }
        public override string PreviewActionName { get; }
        public override JetBrains.IDE.TreeBrowser.PreviewSupport PreviewSupport { get; }
        public JetBrains.ReSharper.Psi.ITypeElement TypeElement { get; set; }
        public override System.Windows.Forms.Control PreviewCreateControl(JetBrains.UI.WindowManagement.WindowFrame framePreview) { }
        public override void PreviewUpdate(System.Windows.Forms.Control previewControl, JetBrains.TreeModels.TreeModelNode modelNode, ref JetBrains.CommonControls.IPresentableItem previewCaption) { }
    }
    public class TypeBrowserMembersPresenter : JetBrains.ReSharper.Features.Shared.TreePsiBrowser.TreeModelBrowserPresenter
    {
        protected override void PresentTypeMember(JetBrains.ReSharper.Psi.ITypeMember value, JetBrains.CommonControls.IPresentableItem item, JetBrains.TreeModels.TreeModelNode modelNode, JetBrains.UI.TreeView.PresentationState state) { }
    }
    public class TypeBrowserPresenter : JetBrains.ReSharper.Features.Shared.TreePsiBrowser.TreeModelBrowserPresenter
    {
        protected override bool IsNaturalParent(object parentValue, object childValue) { }
    }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "TypeBrowser.Refresh"})]
    public class TypeBrowserRefreshAction : JetBrains.ActionManagement.IActionHandler
    {
        public void Execute(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.DelegateExecute nextExecute) { }
        public bool Update(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.ActionPresentation presentation, JetBrains.ActionManagement.DelegateUpdate nextUpdate) { }
    }
    [JetBrains.Application.Settings.SettingsKeyAttribute(typeof(JetBrains.UI.UserInterfaceSettings), "Type browser settings")]
    public class TypeBrowserSettings
    {
        [JetBrains.Application.Settings.SettingsEntryAttribute(4, "Group by")]
        public int GroupingIndex;
    }
    [JetBrains.Application.Configuration.Upgrade.GlobalSettingsUpgraderAttribute()]
    public class TypeBrowserSettingsUpgrader : JetBrains.Application.Configuration.SettingTablesUpgrader
    {
        public TypeBrowserSettingsUpgrader(JetBrains.Application.Env.RunsProducts.ProductConfigurations productConfigurations) { }
        protected override void DoUpgrade(JetBrains.Application.Configuration.IComponentSettingsProvider legacySettingsProvider, JetBrains.Application.Settings.IContextBoundSettingsStore boundSettingsStore, JetBrains.DataFlow.Lifetime upgradeLifetime, JetBrains.Application.Configuration.SettingsTableBase workspaceSettingsTable, JetBrains.Application.Configuration.SettingsTableBase globalSettingsTable) { }
    }
    [JetBrains.UI.ToolWindowManagement.ToolWindowDescriptorAttribute(Icon=typeof(JetBrains.ReSharper.Features.Internal.Resources.FeaturesInternalThemedIcons.TypeBrowserToolWindow), ProductNeutralId="TypeBrowserWindow", Text="Type Browser", Type=JetBrains.UI.ToolWindowManagement.ToolWindowType.SingleInstance, VisibilityPersistenceScope=JetBrains.UI.ToolWindowManagement.ToolWindowVisibilityPersistenceScope.Solution)]
    public class TypeBrowserToolWindowDescriptor : JetBrains.UI.ToolWindowManagement.ToolWindowDescriptor
    {
        public TypeBrowserToolWindowDescriptor(JetBrains.Application.IApplicationDescriptor applicationDescriptor) { }
    }
}