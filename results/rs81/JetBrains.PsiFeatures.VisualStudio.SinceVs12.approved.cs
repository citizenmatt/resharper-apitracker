[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]
[assembly: System.Runtime.Versioning.TargetFrameworkAttribute(".NETFramework,Version=v4.5", FrameworkDisplayName=".NET Framework 4.5")]

namespace JetBrains.PsiFeatures.VisualStudio.SinceVs12.Src.Navigation
{
    
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class NavigationExecutionHostVs12 : JetBrains.ReSharper.Features.Finding.ExecutionHosting.DefaultNavigationExecutionHost
    {
        public NavigationExecutionHostVs12(JetBrains.Util.Lazy.Lazy<JetBrains.Application.Components.Optional<Microsoft.VisualStudio.Language.Intellisense.IPeekBroker>> peekBrokerLazy) { }
        public override bool ProcessImmediateResult(JetBrains.Application.DataContext.IDataContext context, System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.Navigation.Search.IOccurence> results) { }
        public override bool ProcessImmediateResultHierarchy(JetBrains.Application.DataContext.IDataContext context, System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.Navigation.Search.IOccurence> results) { }
    }
    public class PeekDefinitionUtil
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static Microsoft.VisualStudio.Language.Intellisense.IPeekSession GetCurrentPeekSession(JetBrains.Application.DataContext.IDataContext context, out Microsoft.VisualStudio.Text.Editor.ITextView textView, [JetBrains.Annotations.NotNullAttribute()] Microsoft.VisualStudio.Language.Intellisense.IPeekBroker broker) { }
    }
}
namespace JetBrains.PsiFeatures.VisualStudio.SinceVs12.Src.PeekDefinition
{
    
    public class BasesPeekableItem : Microsoft.VisualStudio.Language.Intellisense.IPeekableItem
    {
        public BasesPeekableItem(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, Microsoft.VisualStudio.Language.Intellisense.IPeekResultFactory peekResultFactory, JetBrains.ProjectModel.ISolution solution) { }
        public string DisplayName { get; }
        public System.Collections.Generic.IEnumerable<Microsoft.VisualStudio.Language.Intellisense.IPeekRelationship> Relationships { get; }
        public Microsoft.VisualStudio.Language.Intellisense.IPeekResultSource GetOrCreateResultSource(string relationshipName) { }
    }
    public class BasesPeekResultSource : JetBrains.PsiFeatures.VisualStudio.SinceVs12.Src.PeekDefinition.DeclaredElementPeekResultSourceBase, Microsoft.VisualStudio.Language.Intellisense.IPeekResultSource
    {
        public BasesPeekResultSource(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, Microsoft.VisualStudio.Language.Intellisense.IPeekResultFactory peekResultFactory, JetBrains.ProjectModel.ISolution solution) { }
        public void FindResults(string relationshipName, Microsoft.VisualStudio.Language.Intellisense.IPeekResultCollection resultCollection, System.Threading.CancellationToken cancellationToken, Microsoft.VisualStudio.Language.Intellisense.IFindPeekResultsCallback callback) { }
        protected override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.Navigation.Search.IOccurence> GetResults(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
    }
    public class DeclarationsPeekResultSource : JetBrains.PsiFeatures.VisualStudio.SinceVs12.Src.PeekDefinition.DeclaredElementPeekResultSourceBase, Microsoft.VisualStudio.Language.Intellisense.IPeekResultSource
    {
        public DeclarationsPeekResultSource(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, Microsoft.VisualStudio.Language.Intellisense.IPeekResultFactory peekResultFactory, JetBrains.ProjectModel.ISolution solution) { }
        public void FindResults(string relationshipName, Microsoft.VisualStudio.Language.Intellisense.IPeekResultCollection resultCollection, System.Threading.CancellationToken cancellationToken, Microsoft.VisualStudio.Language.Intellisense.IFindPeekResultsCallback callback) { }
        protected override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.Navigation.Search.IOccurence> GetResults(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
    }
    public class DeclaredElementPeekableItem : Microsoft.VisualStudio.Language.Intellisense.IPeekableItem
    {
        public DeclaredElementPeekableItem(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, Microsoft.VisualStudio.Language.Intellisense.IPeekResultFactory peekResultFactory, JetBrains.ProjectModel.ISolution solution) { }
        public string DisplayName { get; }
        public System.Collections.Generic.IEnumerable<Microsoft.VisualStudio.Language.Intellisense.IPeekRelationship> Relationships { get; }
        public Microsoft.VisualStudio.Language.Intellisense.IPeekResultSource GetOrCreateResultSource(string relationshipName) { }
    }
    public abstract class DeclaredElementPeekResultSourceBase
    {
        protected DeclaredElementPeekResultSourceBase(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, Microsoft.VisualStudio.Language.Intellisense.IPeekResultFactory peekResultFactory, JetBrains.ProjectModel.ISolution solution) { }
        protected void FindResultsInternal(string relationshipName, Microsoft.VisualStudio.Language.Intellisense.IPeekResultCollection resultCollection, System.Threading.CancellationToken cancellationToken) { }
        protected abstract System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.Navigation.Search.IOccurence> GetResults(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement);
    }
    public class InheritorsPeekableItem : Microsoft.VisualStudio.Language.Intellisense.IPeekableItem
    {
        public InheritorsPeekableItem(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, Microsoft.VisualStudio.Language.Intellisense.IPeekResultFactory peekResultFactory, JetBrains.ProjectModel.ISolution solution) { }
        public string DisplayName { get; }
        public System.Collections.Generic.IEnumerable<Microsoft.VisualStudio.Language.Intellisense.IPeekRelationship> Relationships { get; }
        public Microsoft.VisualStudio.Language.Intellisense.IPeekResultSource GetOrCreateResultSource(string relationshipName) { }
    }
    public class InheritorsPeekResultSource : JetBrains.PsiFeatures.VisualStudio.SinceVs12.Src.PeekDefinition.DeclaredElementPeekResultSourceBase, Microsoft.VisualStudio.Language.Intellisense.IPeekResultSource
    {
        public InheritorsPeekResultSource(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, Microsoft.VisualStudio.Language.Intellisense.IPeekResultFactory peekResultFactory, JetBrains.ProjectModel.ISolution solution) { }
        public void FindResults(string relationshipName, Microsoft.VisualStudio.Language.Intellisense.IPeekResultCollection resultCollection, System.Threading.CancellationToken cancellationToken, Microsoft.VisualStudio.Language.Intellisense.IFindPeekResultsCallback callback) { }
        protected override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.Navigation.Search.IOccurence> GetResults(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
    }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "PeekDefinition"})]
    public class PeekDefinitionAction : JetBrains.ActionManagement.IActionHandler
    {
        public void Execute(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.DelegateExecute nextExecute) { }
        public bool Update(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.ActionPresentation presentation, JetBrains.ActionManagement.DelegateUpdate nextUpdate) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class PeekDefinitionManager
    {
        public const string PeekBases = "Bases";
        public const string PeekDeclaration = "Declaration";
        public const string PeekInheritors = "Inheritors";
        public const string PeekResults = "Results";
        public static object ResultsKey;
        public PeekDefinitionManager(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.IShellLocks locks) { }
        public JetBrains.ProjectModel.ISolution Solution { get; }
        protected System.Collections.Generic.IList<Microsoft.VisualStudio.Language.Intellisense.IPeekableItem> CreateBasesPeekableItem(JetBrains.ProjectModel.ISolution solution, JetBrains.DocumentModel.IDocument document, int offset, Microsoft.VisualStudio.Language.Intellisense.IPeekResultFactory peekResultFactory) { }
        protected System.Collections.Generic.IList<Microsoft.VisualStudio.Language.Intellisense.IPeekableItem> CreateDeclarationPeekableItem(JetBrains.ProjectModel.ISolution solution, JetBrains.DocumentModel.IDocument document, int offset, Microsoft.VisualStudio.Language.Intellisense.IPeekResultFactory peekResultFactory) { }
        protected System.Collections.Generic.IList<Microsoft.VisualStudio.Language.Intellisense.IPeekableItem> CreateInheritorsPeekableItem(JetBrains.ProjectModel.ISolution solution, JetBrains.DocumentModel.IDocument document, int offset, Microsoft.VisualStudio.Language.Intellisense.IPeekResultFactory peekResultFactory) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public virtual Microsoft.VisualStudio.Language.Intellisense.IDocumentPeekResult CreatePeekResult(JetBrains.ReSharper.Feature.Services.Navigation.Search.IOccurence sourceOccurence, Microsoft.VisualStudio.Language.Intellisense.IPeekResultFactory vsFactory, System.Threading.CancellationToken cancellationToken) { }
        public virtual System.Collections.Generic.IList<Microsoft.VisualStudio.Language.Intellisense.IPeekableItem> GetPeekableItems(Microsoft.VisualStudio.Language.Intellisense.IPeekSession session, JetBrains.DocumentModel.IDocument document, int offset, Microsoft.VisualStudio.Language.Intellisense.IPeekResultFactory peekResultFactory) { }
        public Microsoft.VisualStudio.Language.Intellisense.IPeekableItemSource GetPeekableItemSource(Microsoft.VisualStudio.Language.Intellisense.IPeekResultFactory peekResultFactory, Microsoft.VisualStudio.Text.ITextBuffer textBuffer, Microsoft.VisualStudio.Text.ITextDocumentFactoryService textDocumentFactoryService) { }
    }
    public class PeekResult : Microsoft.VisualStudio.Language.Intellisense.IDocumentPeekResult, Microsoft.VisualStudio.Language.Intellisense.IPeekResult, System.IDisposable
    {
        public bool CanNavigateTo { get; }
        public Microsoft.VisualStudio.Language.Intellisense.IPeekResultDisplayInfo DisplayInfo { get; }
        public string FilePath { get; }
        public Microsoft.VisualStudio.Text.IPersistentSpan IdentifyingPosition { get; }
        public bool IsReadOnly { get; }
        public Microsoft.VisualStudio.Text.IPersistentSpan Span { get; }
        public event System.EventHandler Disposed;
        public void Dispose() { }
        public void NavigateTo(Microsoft.VisualStudio.Language.Intellisense.IPeekResultScrollState scrollState) { }
    }
    public class PredefinedResultsSource : Microsoft.VisualStudio.Language.Intellisense.IPeekResultSource
    {
        public PredefinedResultsSource(System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.Navigation.Search.IOccurence> occurences, JetBrains.ProjectModel.ISolution solution, Microsoft.VisualStudio.Language.Intellisense.IPeekResultFactory peekResultFactory) { }
        public void FindResults(string relationshipName, Microsoft.VisualStudio.Language.Intellisense.IPeekResultCollection resultCollection, System.Threading.CancellationToken cancellationToken, Microsoft.VisualStudio.Language.Intellisense.IFindPeekResultsCallback callback) { }
    }
    public class ReSharperPeekableItemSource : Microsoft.VisualStudio.Language.Intellisense.IPeekableItemSource, System.IDisposable
    {
        public ReSharperPeekableItemSource(Microsoft.VisualStudio.Language.Intellisense.IPeekResultFactory peekResultFactory, JetBrains.PsiFeatures.VisualStudio.SinceVs12.Src.PeekDefinition.PeekDefinitionManager peekDefinitionManager, Microsoft.VisualStudio.Text.ITextDocumentFactoryService textDocumentFactoryService) { }
        public void AugmentPeekSession(Microsoft.VisualStudio.Language.Intellisense.IPeekSession session, System.Collections.Generic.IList<Microsoft.VisualStudio.Language.Intellisense.IPeekableItem> peekableItems) { }
        public void Dispose() { }
    }
    public class ShowOccurencesPeekableItem : Microsoft.VisualStudio.Language.Intellisense.IPeekableItem
    {
        public ShowOccurencesPeekableItem(System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.Navigation.Search.IOccurence> occurences, JetBrains.ProjectModel.ISolution solution, Microsoft.VisualStudio.Language.Intellisense.IPeekResultFactory peekResultFactory) { }
        public string DisplayName { get; }
        public System.Collections.Generic.IEnumerable<Microsoft.VisualStudio.Language.Intellisense.IPeekRelationship> Relationships { get; }
        public Microsoft.VisualStudio.Language.Intellisense.IPeekResultSource GetOrCreateResultSource(string relationshipName) { }
    }
}
namespace JetBrains.PsiFeatures.VisualStudio.SinceVs12.Src.PeekDefinition.MEF
{
    
    [Microsoft.VisualStudio.Utilities.ContentTypeAttribute("any")]
    [Microsoft.VisualStudio.Utilities.NameAttribute("ReSharperPeekableItemSourceProvider")]
    [System.ComponentModel.Composition.ExportAttribute(typeof(Microsoft.VisualStudio.Language.Intellisense.IPeekableItemSourceProvider))]
    [System.ComponentModel.Composition.ExportMetadataAttribute("Priority", 1000)]
    public class ReSharperPeekableItemSourceProvider : Microsoft.VisualStudio.Language.Intellisense.IPeekableItemSourceProvider
    {
        public Microsoft.VisualStudio.Language.Intellisense.IPeekableItemSource TryCreatePeekableItemSource(Microsoft.VisualStudio.Text.ITextBuffer textBuffer) { }
    }
}