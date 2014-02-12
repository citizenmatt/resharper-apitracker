[assembly: JetBrains.TextControl.DocumentMarkup.RegisterHighlighterAttribute("ReSharper Highlight Target Marker on Error Stripe", DarkForegroundColor="#A96ADD", EffectType=JetBrains.TextControl.DocumentMarkup.EffectType.ERROR_STRIPE_MARK, ForegroundColor="#C000FF:Magenta", HighContrastBackgroundMode=JetBrains.TextControl.DocumentMarkup.HighContrastMode.SameAsDark)]
[assembly: JetBrains.TextControl.DocumentMarkup.RegisterHighlighterAttribute("ReSharper Highlight Target", BackgroundColor="LightPink:Magenta", DarkBackgroundColor="Maroon", EffectType=JetBrains.TextControl.DocumentMarkup.EffectType.HIGHLIGHT, ErrorStripeColorHighlighterAttributeId="ReSharper Highlight Target Marker on Error Stripe", ErrorStripeKind=JetBrains.TextControl.DocumentMarkup.ErrorStripeKind.NONE, HighContrastBackgroundMode=JetBrains.TextControl.DocumentMarkup.HighContrastMode.SameAsDark, Layer=4999, VSPriority=10001)]
[assembly: JetBrains.TextControl.DocumentMarkup.RegisterHighlighterAttribute("ReSharper Highlight Marker on Error Stripe", DarkForegroundColor="#5FA2B2", EffectType=JetBrains.TextControl.DocumentMarkup.EffectType.ERROR_STRIPE_MARK, ForegroundColor="#009EFF:Cyan", HighContrastBackgroundMode=JetBrains.TextControl.DocumentMarkup.HighContrastMode.SameAsDark)]
[assembly: JetBrains.TextControl.DocumentMarkup.RegisterHighlighterAttribute("ReSharper Navigation Highlight", BackgroundColor="LightSkyBlue:Cyan", DarkBackgroundColor="DarkSlateBlue", EffectType=JetBrains.TextControl.DocumentMarkup.EffectType.HIGHLIGHT, ErrorStripeColorHighlighterAttributeId="ReSharper Navigation Highlight Marker on Error Stripe", ErrorStripeKind=JetBrains.TextControl.DocumentMarkup.ErrorStripeKind.NONE, HighContrastBackgroundMode=JetBrains.TextControl.DocumentMarkup.HighContrastMode.SameAsDark, Layer=5001, VSPriority=10001)]
[assembly: JetBrains.TextControl.DocumentMarkup.RegisterHighlighterAttribute("ReSharper Navigation Highlight Marker on Error Stripe", DarkForegroundColor="#5FA2B2", EffectType=JetBrains.TextControl.DocumentMarkup.EffectType.ERROR_STRIPE_MARK, ForegroundColor="#009EFF:Cyan", HighContrastBackgroundMode=JetBrains.TextControl.DocumentMarkup.HighContrastMode.SameAsDark)]
[assembly: JetBrains.TextControl.DocumentMarkup.RegisterHighlighterAttribute("ReSharper Read Usage", BackgroundColor="LightSkyBlue:Cyan", DarkBackgroundColor="DarkSlateBlue", EffectType=JetBrains.TextControl.DocumentMarkup.EffectType.HIGHLIGHT, ErrorStripeColorHighlighterAttributeId="ReSharper Read Usage Marker on Error Stripe", ErrorStripeKind=JetBrains.TextControl.DocumentMarkup.ErrorStripeKind.NONE, HighContrastBackgroundMode=JetBrains.TextControl.DocumentMarkup.HighContrastMode.SameAsDark, Layer=4999, VSPriority=10001)]
[assembly: JetBrains.TextControl.DocumentMarkup.RegisterHighlighterAttribute("ReSharper Read Usage Marker on Error Stripe", DarkForegroundColor="#5FA2B2", EffectType=JetBrains.TextControl.DocumentMarkup.EffectType.ERROR_STRIPE_MARK, ForegroundColor="#009EFF:Cyan", HighContrastBackgroundMode=JetBrains.TextControl.DocumentMarkup.HighContrastMode.SameAsDark)]
[assembly: JetBrains.TextControl.DocumentMarkup.RegisterHighlighterAttribute("ReSharper Write Usage", BackgroundColor="LightPink:Magenta", DarkBackgroundColor="Maroon", EffectType=JetBrains.TextControl.DocumentMarkup.EffectType.HIGHLIGHT, ErrorStripeColorHighlighterAttributeId="ReSharper Write Usage Marker on Error Stripe", ErrorStripeKind=JetBrains.TextControl.DocumentMarkup.ErrorStripeKind.NONE, HighContrastBackgroundMode=JetBrains.TextControl.DocumentMarkup.HighContrastMode.SameAsDark, Layer=4999, VSPriority=10001)]
[assembly: JetBrains.TextControl.DocumentMarkup.RegisterHighlighterAttribute("ReSharper Write Usage Marker on Error Stripe", DarkForegroundColor="#A96ADD", EffectType=JetBrains.TextControl.DocumentMarkup.EffectType.ERROR_STRIPE_MARK, ForegroundColor="#C000FF:Magenta", HighContrastBackgroundMode=JetBrains.TextControl.DocumentMarkup.HighContrastMode.SameAsDark)]
[assembly: JetBrains.TextControl.DocumentMarkup.RegisterHighlighterAttribute("ReSharper Highlight", BackgroundColor="LightSkyBlue:Cyan", DarkBackgroundColor="DarkSlateBlue", EffectType=JetBrains.TextControl.DocumentMarkup.EffectType.HIGHLIGHT, ErrorStripeColorHighlighterAttributeId="ReSharper Highlight Marker on Error Stripe", ErrorStripeKind=JetBrains.TextControl.DocumentMarkup.ErrorStripeKind.NONE, HighContrastBackgroundMode=JetBrains.TextControl.DocumentMarkup.HighContrastMode.SameAsDark, Layer=4999, VSPriority=10001)]
[assembly: JetBrains.UI.Icons.CompiledIcons.CompiledIconsPackAttribute(IconNames=new string[] {
        "UnitTestReadWriteUsage",
        "UnitTestWriteUsage",
        "UnitTestInvocationUsage",
        "UsageInterface",
        "UsageTest",
        "UnitTestInterfaceQualification",
        "FinalRec",
        "UnitTestReadUsage",
        "UsageBase",
        "UnitTestBaseMethodCall"}, IconPackResourceIdentification="JetBrains.ReSharper.Feature.Services.Navigation;component/resources/ServicesNavig" +
    "ationThemedIcons/ThemedIcons.ServicesNavigation.Generated.Xaml")]
[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]
[assembly: System.Windows.Markup.XmlnsDefinitionAttribute("urn:shemas-jetbrains-com:ui-application-icons-services-navigation", "JetBrains.ReSharper.Feature.Services.Navigation.Resources")]

namespace JetBrains.ReSharper.ExternalSources.ReSharperIntegration
{
    
    public class FileSystemPathNavigationPoint : JetBrains.ReSharper.Feature.Services.Navigation.Navigation.INavigationPoint, JetBrains.ReSharper.Feature.Services.Navigation.Navigation.ITextNavigationPoint
    {
        public FileSystemPathNavigationPoint(JetBrains.Util.FileSystemPath file, string assemblyName, JetBrains.Util.TextRange textRange, string sourceProviderName, JetBrains.ReSharper.ExternalSources.ReSharperIntegration.FileSystemPathNavigator navigator, JetBrains.ProjectModel.ProjectFileExtensions projectFileExtensions, JetBrains.ReSharper.Psi.PsiProjectFileTypeCoordinator psiProjectFileTypeCoordinator, JetBrains.IDE.EditorManager editorManager) { }
        public JetBrains.ReSharper.Feature.Services.Navigation.Navigation.NavigationPointHighlightingInfo GetHighlightingInfo(JetBrains.ReSharper.Feature.Services.Navigation.NavigationOptions options) { }
        public JetBrains.UI.Icons.IconId GetPresentationImage() { }
        public JetBrains.UI.RichText.RichText GetPresentationText() { }
        public JetBrains.UI.RichText.RichText GetSecondaryPresentationText() { }
        public bool Navigate(JetBrains.ReSharper.Feature.Services.Navigation.NavigationOptions options) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class FileSystemPathNavigator
    {
        public FileSystemPathNavigator(JetBrains.IDE.EditorManager editorManager, JetBrains.Application.IShellLocks shellLocks, JetBrains.ProjectModel.ProjectFileExtensions projectFileExtensions, JetBrains.ReSharper.Psi.PsiProjectFileTypeCoordinator psiProjectFileTypeCoordinator) { }
        public JetBrains.ReSharper.Feature.Services.Navigation.Navigation.INavigationPoint CreateNavigationPoint(JetBrains.Util.FileSystemPath file, JetBrains.Util.TextRange offset, string assemblyName, string providerPresentableName) { }
        public JetBrains.TextControl.ITextControl GetTextControl([JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.FileSystemPath file, JetBrains.IDE.TabOptions tabOptions, bool activate = True) { }
        public void NavigateToFile([JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.FileSystemPath file, int offset, JetBrains.IDE.TabOptions tabOptions, bool activate) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.ActionsMenu
{
    
    public class ActionGroup : JetBrains.Util.EnumPattern
    {
        protected ActionGroup([JetBrains.Annotations.NotNullAttribute()] string name, float order) { }
        public float Order { get; }
    }
    public abstract class ExtensibleAction<TWorkflowProvider, TWorkflow, TActionGroup> : JetBrains.ActionManagement.IActionHandler
        where TWorkflowProvider :  class, JetBrains.ReSharper.Feature.Services.ActionsMenu.IWorkflowProvider<, >
        where TWorkflow :  class, JetBrains.ReSharper.Feature.Services.ActionsMenu.IWorkflow<>
        where TActionGroup : JetBrains.ReSharper.Feature.Services.ActionsMenu.ActionGroup
    {
        protected virtual bool AssertsMenuItemsMnemonics { get; }
        protected abstract JetBrains.UI.RichText.RichText Caption { get; }
        protected virtual bool ShowMenuWithOneItem { get; }
        protected virtual int CompareWorkflowItems(JetBrains.Util.Pair<TWorkflow, TWorkflowProvider> item1, JetBrains.Util.Pair<TWorkflow, TWorkflowProvider> item2) { }
        public void Execute(JetBrains.Application.DataContext.IDataContext dataContext, JetBrains.ActionManagement.DelegateExecute nextExecute) { }
        protected abstract void Execute([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.DataContext.IDataContext context, [JetBrains.Annotations.NotNullAttribute()] TWorkflow workflow);
        protected abstract JetBrains.UI.Icons.IconId GetIcon(JetBrains.Application.DataContext.IDataContext dataContext);
        protected abstract System.Collections.Generic.ICollection<TWorkflowProvider> GetWorkflowProviders();
        protected abstract bool IsAvailable([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.DataContext.IDataContext context, [JetBrains.Annotations.NotNullAttribute()] TWorkflow workflow);
        protected abstract bool IsEnabled([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.DataContext.IDataContext context, TWorkflow workflow);
        public virtual bool Update(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.ActionPresentation presentation, JetBrains.ActionManagement.DelegateUpdate nextUpdate) { }
    }
    public interface IOverridingWorkflowProvider
    {
        bool HideOtherActions(JetBrains.Application.DataContext.IDataContext context);
    }
    public interface IWorkflow<out TActionGroup>
        where out TActionGroup : JetBrains.ReSharper.Feature.Services.ActionsMenu.ActionGroup
    {
        TActionGroup ActionGroup { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        string ActionId { get; }
        JetBrains.UI.Icons.IconId Icon { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        string ShortActionId { get; }
        string Title { get; }
    }
    public interface IWorkflowProvider<TWorkflow, out TActionGroup>
        where TWorkflow : JetBrains.ReSharper.Feature.Services.ActionsMenu.IWorkflow<>
        where out TActionGroup : JetBrains.ReSharper.Feature.Services.ActionsMenu.ActionGroup
    {
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.IEnumerable<TWorkflow> CreateWorkflow(JetBrains.Application.DataContext.IDataContext dataContext);
    }
}
namespace JetBrains.ReSharper.Feature.Services.CodeStructure
{
    
    public class CodeStructureDeclarationAspects : JetBrains.ReSharper.Feature.Services.CodeStructure.IFileStructureAspect, JetBrains.ReSharper.Feature.Services.CodeStructure.IGotoFileMemberAspect, JetBrains.ReSharper.Feature.Services.CodeStructure.IMemberNavigationAspect
    {
        public CodeStructureDeclarationAspects([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.IDeclaration declaration) { }
        public virtual JetBrains.ReSharper.Psi.Tree.IDeclaration Declaration { get; }
        public virtual bool InitiallyExpanded { get; }
        public virtual JetBrains.DocumentModel.DocumentRange NavigationRange { get; }
        protected virtual System.Collections.Generic.IList<string> CalculateQuickSearchTexts(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration) { }
        public virtual bool CanMoveElements(JetBrains.UI.TreeView.RelativeLocation location, System.Collections.Generic.IList<JetBrains.ReSharper.Feature.Services.CodeStructure.CodeStructureElement> dropElements) { }
        public virtual bool CanRemove() { }
        public virtual bool CanRename() { }
        protected virtual bool DoPresentAsType(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
        protected virtual bool DoPresentAsTypeMember(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
        public virtual JetBrains.DocumentModel.DocumentRange[] GetNavigationRanges() { }
        public virtual System.Collections.Generic.IList<string> GetQuickSearchTexts() { }
        public JetBrains.ReSharper.Psi.IPsiSourceFile GetSourceFile() { }
        public virtual string InitialName() { }
        public virtual void MoveElements(JetBrains.UI.TreeView.RelativeLocation location, System.Collections.Generic.IList<JetBrains.ReSharper.Feature.Services.CodeStructure.CodeStructureElement> dropElements) { }
        public virtual void Present(JetBrains.UI.TreeView.StructuredPresenter<JetBrains.TreeModels.TreeModelNode, JetBrains.CommonControls.IPresentableItem> presenter, JetBrains.CommonControls.IPresentableItem item, JetBrains.TreeModels.TreeModelNode modelNode, JetBrains.UI.TreeView.PresentationState state) { }
        public virtual void Present(JetBrains.UI.PopupMenu.IMenuItemDescriptor descriptor, JetBrains.UI.TreeView.PresentationState state) { }
        public virtual void Remove() { }
        public virtual void Rename(string newName) { }
    }
    public class CodeStructureDeclarationElement : JetBrains.ReSharper.Feature.Services.CodeStructure.CodeStructureElement, JetBrains.ReSharper.Feature.Services.CodeStructure.ICodeStructureDeclarationElement
    {
        public CodeStructureDeclarationElement(JetBrains.ReSharper.Feature.Services.CodeStructure.CodeStructureElement parentElement, JetBrains.ReSharper.Psi.Tree.IDeclaration declaration) { }
        public JetBrains.ReSharper.Psi.Tree.IDeclaration Declaration { get; }
        public JetBrains.ReSharper.Psi.IDeclaredElement DeclaredElement { get; }
        public override JetBrains.ReSharper.Psi.PsiLanguageType Language { get; }
        public override JetBrains.ReSharper.Psi.Tree.ITreeNode TreeNode { get; }
        protected override void DumpSelf(System.IO.TextWriter builder) { }
        public override JetBrains.ReSharper.Feature.Services.CodeStructure.IFileStructureAspect GetFileStructureAspect() { }
        public override JetBrains.ReSharper.Feature.Services.CodeStructure.IGotoFileMemberAspect GetGotoMemberAspect() { }
        public override JetBrains.ReSharper.Feature.Services.CodeStructure.IMemberNavigationAspect GetMemberNavigationAspect() { }
        public override JetBrains.Util.TextRange GetTextRange() { }
    }
    public abstract class CodeStructureElement
    {
        protected CodeStructureElement(JetBrains.ReSharper.Feature.Services.CodeStructure.CodeStructureElement parent) { }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Feature.Services.CodeStructure.CodeStructureElement> Children { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public abstract JetBrains.ReSharper.Psi.PsiLanguageType Language { get; }
        public virtual JetBrains.ReSharper.Feature.Services.CodeStructure.CodeStructureElement Parent { get; }
        public virtual JetBrains.ReSharper.Feature.Services.CodeStructure.ICodeStructureBlockStart ParentBlock { get; }
        public virtual JetBrains.ProjectModel.ISolution Solution { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public abstract JetBrains.ReSharper.Psi.Tree.ITreeNode TreeNode { get; }
        public void AppendChild(JetBrains.ReSharper.Feature.Services.CodeStructure.CodeStructureElement element) { }
        public void Dump(System.IO.TextWriter builder, int indent = 0, char indenter =  ) { }
        protected abstract void DumpSelf(System.IO.TextWriter builder);
        [JetBrains.Annotations.CanBeNullAttribute()]
        public abstract JetBrains.ReSharper.Feature.Services.CodeStructure.IFileStructureAspect GetFileStructureAspect();
        [JetBrains.Annotations.CanBeNullAttribute()]
        public abstract JetBrains.ReSharper.Feature.Services.CodeStructure.IGotoFileMemberAspect GetGotoMemberAspect();
        [JetBrains.Annotations.CanBeNullAttribute()]
        public abstract JetBrains.ReSharper.Feature.Services.CodeStructure.IMemberNavigationAspect GetMemberNavigationAspect();
        public abstract JetBrains.Util.TextRange GetTextRange();
    }
    public class static CodeStructureElementEx
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Psi.IPsiSourceFile GetSourceFile([JetBrains.Annotations.CanBeNullAttribute()] this JetBrains.ReSharper.Feature.Services.CodeStructure.CodeStructureElement element) { }
    }
    public class CodeStructureOptions
    {
        public static readonly JetBrains.ReSharper.Feature.Services.CodeStructure.CodeStructureOptions Default;
        public bool BuildInheritanceInformation { get; set; }
    }
    public class CodeStructurePreprocessorElement : JetBrains.ReSharper.Feature.Services.CodeStructure.CodeStructureElement, JetBrains.ReSharper.Feature.Services.CodeStructure.IFileStructureAspect, JetBrains.ReSharper.Feature.Services.CodeStructure.IMemberNavigationAspect
    {
        public CodeStructurePreprocessorElement(JetBrains.ReSharper.Feature.Services.CodeStructure.CodeStructureElement parentElement, JetBrains.ReSharper.Psi.Tree.ITreeNode preprocessorDirective) { }
        public bool InitiallyExpanded { get; }
        public override JetBrains.ReSharper.Psi.PsiLanguageType Language { get; }
        public JetBrains.DocumentModel.DocumentRange NavigationRange { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Psi.Tree.ITreeNode PreprocessorDirective { get; }
        public override JetBrains.ReSharper.Psi.Tree.ITreeNode TreeNode { get; }
        public virtual bool CanMoveElements(JetBrains.UI.TreeView.RelativeLocation location, System.Collections.Generic.IList<JetBrains.ReSharper.Feature.Services.CodeStructure.CodeStructureElement> dropElements) { }
        public virtual bool CanRemove() { }
        public virtual bool CanRename() { }
        protected override void DumpSelf(System.IO.TextWriter builder) { }
        public override JetBrains.ReSharper.Feature.Services.CodeStructure.IFileStructureAspect GetFileStructureAspect() { }
        public override JetBrains.ReSharper.Feature.Services.CodeStructure.IGotoFileMemberAspect GetGotoMemberAspect() { }
        public override JetBrains.ReSharper.Feature.Services.CodeStructure.IMemberNavigationAspect GetMemberNavigationAspect() { }
        public JetBrains.DocumentModel.DocumentRange[] GetNavigationRanges() { }
        public System.Collections.Generic.IList<string> GetQuickSearchTexts() { }
        protected virtual string GetText() { }
        public override JetBrains.Util.TextRange GetTextRange() { }
        public virtual string InitialName() { }
        public virtual void MoveElements(JetBrains.UI.TreeView.RelativeLocation location, System.Collections.Generic.IList<JetBrains.ReSharper.Feature.Services.CodeStructure.CodeStructureElement> dropElements) { }
        public void Present(JetBrains.UI.TreeView.StructuredPresenter<JetBrains.TreeModels.TreeModelNode, JetBrains.CommonControls.IPresentableItem> presenter, JetBrains.CommonControls.IPresentableItem item, JetBrains.TreeModels.TreeModelNode modelNode, JetBrains.UI.TreeView.PresentationState state) { }
        public virtual void Remove() { }
        public virtual void Rename(string newName) { }
    }
    public class CodeStructurePresentationState : JetBrains.UI.TreeView.PresentationState
    {
        public CodeStructurePresentationState(JetBrains.UI.TreeView.PresentationState state) { }
        public bool QualifyNamespace { get; set; }
        public bool QualifyType { get; set; }
    }
    public class static CodeStructureProvider
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Feature.Services.CodeStructure.CodeStructureRootElement GetCodeStructureRoot([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, JetBrains.ReSharper.Feature.Services.CodeStructure.CodeStructureOptions options) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static bool HasCodeStructure([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
    }
    public class CodeStructureRootElement : JetBrains.ReSharper.Feature.Services.CodeStructure.CodeStructureElement
    {
        public CodeStructureRootElement(JetBrains.ReSharper.Psi.Tree.IFile file) { }
        public JetBrains.ReSharper.Psi.Tree.IFile File { get; }
        public override JetBrains.ReSharper.Psi.PsiLanguageType Language { get; }
        public override JetBrains.ProjectModel.ISolution Solution { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Psi.IPsiSourceFile SourceFile { get; }
        public override JetBrains.ReSharper.Psi.Tree.ITreeNode TreeNode { get; }
        public virtual JetBrains.UI.TreeView.PresentationState CreatePresentationState() { }
        protected override void DumpSelf(System.IO.TextWriter builder) { }
        public JetBrains.DocumentModel.DocumentRange GetDocumentRange() { }
        public override JetBrains.ReSharper.Feature.Services.CodeStructure.IFileStructureAspect GetFileStructureAspect() { }
        public override JetBrains.ReSharper.Feature.Services.CodeStructure.IGotoFileMemberAspect GetGotoMemberAspect() { }
        public override JetBrains.ReSharper.Feature.Services.CodeStructure.IMemberNavigationAspect GetMemberNavigationAspect() { }
        public override JetBrains.Util.TextRange GetTextRange() { }
    }
    public interface ICodeStructureBlock
    {
        JetBrains.ReSharper.Feature.Services.CodeStructure.ICodeStructureBlockStart ParentBlock { get; }
    }
    public interface ICodeStructureBlockEnd : JetBrains.ReSharper.Feature.Services.CodeStructure.ICodeStructureBlock { }
    public interface ICodeStructureBlockStart : JetBrains.ReSharper.Feature.Services.CodeStructure.ICodeStructureBlock
    {
        bool Expanded { get; set; }
    }
    public interface ICodeStructureDeclarationElement
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Tree.IDeclaration Declaration { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.IDeclaredElement DeclaredElement { get; }
    }
    public interface ICodeStructureEnregionService
    {
        JetBrains.ReSharper.Psi.PsiLanguageType Language { get; }
        JetBrains.ReSharper.Psi.Tree.ITreeNode Execute(System.Collections.Generic.IList<JetBrains.ReSharper.Feature.Services.CodeStructure.CodeStructureElement> elements);
    }
    public interface IFileStructureAspect
    {
        bool InitiallyExpanded { get; }
        JetBrains.DocumentModel.DocumentRange NavigationRange { get; }
        bool CanMoveElements(JetBrains.UI.TreeView.RelativeLocation location, System.Collections.Generic.IList<JetBrains.ReSharper.Feature.Services.CodeStructure.CodeStructureElement> dropElements);
        bool CanRemove();
        bool CanRename();
        System.Collections.Generic.IList<string> GetQuickSearchTexts();
        string InitialName();
        void MoveElements(JetBrains.UI.TreeView.RelativeLocation location, System.Collections.Generic.IList<JetBrains.ReSharper.Feature.Services.CodeStructure.CodeStructureElement> dropElements);
        void Present(JetBrains.UI.TreeView.StructuredPresenter<JetBrains.TreeModels.TreeModelNode, JetBrains.CommonControls.IPresentableItem> presenter, JetBrains.CommonControls.IPresentableItem item, JetBrains.TreeModels.TreeModelNode modelNode, JetBrains.UI.TreeView.PresentationState state);
        void Remove();
        void Rename(string newName);
    }
    public interface IGotoFileMemberAspect
    {
        JetBrains.DocumentModel.DocumentRange NavigationRange { get; }
        System.Collections.Generic.IList<string> GetQuickSearchTexts();
        JetBrains.ReSharper.Psi.IPsiSourceFile GetSourceFile();
        void Present(JetBrains.UI.PopupMenu.IMenuItemDescriptor descriptor, JetBrains.UI.TreeView.PresentationState state);
    }
    public interface IMemberNavigationAspect
    {
        JetBrains.DocumentModel.DocumentRange[] GetNavigationRanges();
    }
    public interface IProjectFileCodeStructureProvider
    {
        JetBrains.ReSharper.Feature.Services.CodeStructure.CodeStructureRootElement Build(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, JetBrains.ReSharper.Feature.Services.CodeStructure.CodeStructureOptions options);
    }
    public interface IPsiFileCodeStructureProvider
    {
        JetBrains.ReSharper.Feature.Services.CodeStructure.CodeStructureRootElement Build(JetBrains.ReSharper.Psi.Tree.IFile file, JetBrains.ReSharper.Feature.Services.CodeStructure.CodeStructureOptions options);
    }
}
namespace JetBrains.ReSharper.Feature.Services.ContextNavigation
{
    
    public class ContextNavigation : JetBrains.ReSharper.Feature.Services.ActionsMenu.IWorkflow<JetBrains.ReSharper.Feature.Services.ContextNavigation.NavigationActionGroup>
    {
        public ContextNavigation(string title, string actionId, JetBrains.ReSharper.Feature.Services.ContextNavigation.NavigationActionGroup actionGroup, System.Action execution, string shortActionId = null) { }
        public JetBrains.ReSharper.Feature.Services.ContextNavigation.NavigationActionGroup ActionGroup { get; }
        public string ActionId { get; }
        public System.Action Execution { get; }
        public JetBrains.UI.Icons.IconId Icon { get; }
        public string ShortActionId { get; }
        public string Title { get; }
    }
    [JetBrains.Annotations.BaseTypeRequiredAttribute(typeof(JetBrains.ReSharper.Feature.Services.ContextNavigation.INavigateFromHereProvider))]
    [JetBrains.Annotations.MeansImplicitUseAttribute()]
    [System.AttributeUsageAttribute(System.AttributeTargets.Class | System.AttributeTargets.All)]
    public class ContextNavigationProviderAttribute : JetBrains.Application.ShellComponentAttribute { }
    public interface INavigateFromHereProvider : JetBrains.ReSharper.Feature.Services.ActionsMenu.IWorkflowProvider<JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextNavigation, JetBrains.ReSharper.Feature.Services.ContextNavigation.NavigationActionGroup> { }
    public sealed class NavigationActionGroup : JetBrains.ReSharper.Feature.Services.ActionsMenu.ActionGroup
    {
        public static readonly JetBrains.ReSharper.Feature.Services.ContextNavigation.NavigationActionGroup Blessed;
        public static readonly JetBrains.ReSharper.Feature.Services.ContextNavigation.NavigationActionGroup Important;
        public static readonly JetBrains.ReSharper.Feature.Services.ContextNavigation.NavigationActionGroup Other;
    }
}
namespace JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextSearches.BaseSearches
{
    
    [JetBrains.ReSharper.Psi.ShellFeaturePartAttribute()]
    public class BaseContextSearch : JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextSearches.BaseSearches.HierarchyContextSearchBase, JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextSearches.IBaseContextSearch, JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextSearches.IContextSearch, JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextSearches.IRequestContextSearch<JetBrains.ReSharper.Feature.Services.Search.SearchRequests.SearchRequest>
    {
        protected override JetBrains.ReSharper.Psi.Services.ReferencePreferenceKind ReferencePreferenceKind { get; }
        protected override JetBrains.ReSharper.Feature.Services.Search.SearchRequests.SearchRequest CreateSearchRequestInternal(JetBrains.Application.DataContext.IDataContext dataContext, JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
    }
    public abstract class ContextSearchBase<TSearchRequest> : JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextSearches.IContextSearch, JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextSearches.IRequestContextSearch<TSearchRequest>
        where TSearchRequest : JetBrains.ReSharper.Feature.Services.Search.SearchRequests.SearchRequest
    {
        protected virtual JetBrains.ReSharper.Psi.Services.ReferencePreferenceKind ReferencePreferenceKind { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        protected abstract TSearchRequest CreateSearchRequest(JetBrains.Application.DataContext.IDataContext dataContext, JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, JetBrains.ReSharper.Psi.IDeclaredElement initialTarget);
        protected virtual System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.DeclaredElementInstance> GetCandidateInstances(JetBrains.Application.DataContext.IDataContext context, JetBrains.ReSharper.Psi.Services.ReferencePreferenceKind kind) { }
        protected virtual System.Collections.Generic.IList<JetBrains.ReSharper.Psi.IDeclaredElement> GetCandidates(JetBrains.Application.DataContext.IDataContext context) { }
        public virtual JetBrains.Util.JetTuple<System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IDeclaredElement>, JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextSearches.GetSearchRequest<TSearchRequest>> GetElementsAndSearchRequest(JetBrains.Application.DataContext.IDataContext dataContext) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        protected virtual JetBrains.ReSharper.Psi.Search.ISearchDomain GetSpecialFinderSearchDomain(JetBrains.ReSharper.Feature.Services.Search.ISpecialElementFinder finder, object target, JetBrains.Application.DataContext.IDataContext context) { }
        protected bool HasSearchableCandidates(JetBrains.Application.DataContext.IDataContext context) { }
        public virtual bool IsAvailable(JetBrains.Application.DataContext.IDataContext context) { }
        protected abstract bool IsAvailableInternal(JetBrains.Application.DataContext.IDataContext dataContext);
        public virtual bool IsContextApplicable(JetBrains.Application.DataContext.IDataContext dataContext) { }
    }
    [JetBrains.ReSharper.Psi.ShellFeaturePartAttribute()]
    public class DefaultDeclarationSearch : JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextSearches.BaseSearches.TypeUsageContextSearchBase<JetBrains.ReSharper.Feature.Services.Search.SearchRequests.SearchDeclarationsRequest>, JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextSearches.IContextSearch, JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextSearches.IDeclarationSearch, JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextSearches.IRequestContextSearch<JetBrains.ReSharper.Feature.Services.Search.SearchRequests.SearchDeclarationsRequest>
    {
        protected override JetBrains.ReSharper.Feature.Services.Search.SearchRequests.SearchDeclarationsRequest CreateSearchRequest(JetBrains.Application.DataContext.IDataContext dataContext, JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, JetBrains.ReSharper.Psi.IDeclaredElement initialTarget) { }
        public virtual JetBrains.ReSharper.Feature.Services.Search.SearchRequests.SearchDeclarationsRequest GetDeclarationSearchRequest(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
        public virtual bool IsGotoDeclarationApplicable(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
    }
    [JetBrains.ReSharper.Psi.ShellFeaturePartAttribute()]
    public class FindUsagesAdvancedContextSearch : JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextSearches.BaseSearches.UsagesContextSearchBase, JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextSearches.IContextSearch, JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextSearches.IFindUsagesAdvancedContextSearch, JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextSearches.IRequestContextSearch<JetBrains.ReSharper.Feature.Services.Search.SearchRequests.SearchUsagesRequest>
    {
        public FindUsagesAdvancedContextSearch(JetBrains.UI.Application.IUIApplication environment) { }
        public JetBrains.ReSharper.Feature.Services.Search.SearchRequests.SearchDeclaredElementUsagesRequest CreateAdvancedSearchRequest(JetBrains.ReSharper.Feature.Services.Navigation.AdvancedSearchingInfo searchInfo, JetBrains.Application.DataContext.IDataContext dataContext) { }
        protected override JetBrains.ReSharper.Psi.Search.ISearchDomain GetSpecialFinderSearchDomain(JetBrains.ReSharper.Feature.Services.Search.ISpecialElementFinder finder, object target, JetBrains.Application.DataContext.IDataContext context) { }
        public override bool IsAvailable(JetBrains.Application.DataContext.IDataContext dataContext) { }
    }
    [JetBrains.ReSharper.Psi.ShellFeaturePartAttribute()]
    public class FindUsagesContextSearch : JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextSearches.BaseSearches.UsagesContextSearchBase, JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextSearches.IContextSearch, JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextSearches.IFindUsagesContextSearch, JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextSearches.IMultipleCandidatesContextSearch<JetBrains.ReSharper.Feature.Services.Search.SearchRequests.SearchUsagesRequest>, JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextSearches.IRequestContextSearch<JetBrains.ReSharper.Feature.Services.Search.SearchRequests.SearchUsagesRequest> { }
    [JetBrains.ReSharper.Psi.ShellFeaturePartAttribute()]
    public class FindUsagesOfAssemblyContextSearch : JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextSearches.BaseSearches.FindUsagesProjectModelElementsContextSearch
    {
        public FindUsagesOfAssemblyContextSearch(JetBrains.TextControl.TextControlManager textControlManager, JetBrains.Application.IShellLocks locks, JetBrains.Application.Env.RunsProducts.ProductConfigurations configuration) { }
        protected override System.Collections.Generic.List<JetBrains.ReSharper.Psi.IDeclaredElement> GetTargetDeclaredElements(JetBrains.Application.DataContext.IDataContext dataContext) { }
        public override bool IsContextApplicable(JetBrains.Application.DataContext.IDataContext dataContext) { }
    }
    [JetBrains.ReSharper.Psi.ShellFeaturePartAttribute()]
    public class FindUsagesProjectModelElementsContextSearch : JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextSearches.BaseSearches.FindUsagesContextSearch
    {
        public FindUsagesProjectModelElementsContextSearch(JetBrains.TextControl.TextControlManager textControlManager, JetBrains.Application.IShellLocks locks, JetBrains.Application.Env.RunsProducts.ProductConfigurations configurations) { }
        protected override JetBrains.ReSharper.Feature.Services.Search.SearchRequests.SearchUsagesRequest CreateSearchRequest(JetBrains.Application.DataContext.IDataContext dataContext, JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, JetBrains.ReSharper.Psi.IDeclaredElement initialTarget) { }
        public override JetBrains.Util.JetTuple<System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IDeclaredElement>, JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextSearches.GetSearchRequest<JetBrains.ReSharper.Feature.Services.Search.SearchRequests.SearchUsagesRequest>> GetElementsAndSearchRequest(JetBrains.Application.DataContext.IDataContext dataContext) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        protected virtual System.Collections.Generic.List<JetBrains.ReSharper.Psi.IDeclaredElement> GetTargetDeclaredElements(JetBrains.Application.DataContext.IDataContext dataContext) { }
        protected override bool IsAvailableInternal(JetBrains.Application.DataContext.IDataContext dataContext) { }
        public override bool IsContextApplicable(JetBrains.Application.DataContext.IDataContext dataContext) { }
    }
    public abstract class HierarchyContextSearchBase : JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextSearches.BaseSearches.ContextSearchBase<JetBrains.ReSharper.Feature.Services.Search.SearchRequests.SearchRequest>
    {
        protected override JetBrains.ReSharper.Feature.Services.Search.SearchRequests.SearchRequest CreateSearchRequest(JetBrains.Application.DataContext.IDataContext dataContext, JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, JetBrains.ReSharper.Psi.IDeclaredElement initialTarget) { }
        protected abstract JetBrains.ReSharper.Feature.Services.Search.SearchRequests.SearchRequest CreateSearchRequestInternal(JetBrains.Application.DataContext.IDataContext dataContext, JetBrains.ReSharper.Psi.IDeclaredElement declaredElement);
        protected override System.Collections.Generic.IList<JetBrains.ReSharper.Psi.IDeclaredElement> GetCandidates(JetBrains.Application.DataContext.IDataContext context) { }
        protected override bool IsAvailableInternal(JetBrains.Application.DataContext.IDataContext dataContext) { }
    }
    [JetBrains.ReSharper.Psi.ShellFeaturePartAttribute()]
    public class HighlightUsagesContextSearch : JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextSearches.BaseSearches.UsagesContextSearchBase, JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextSearches.IContextSearch, JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextSearches.IHighlightUsagesContextSearch, JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextSearches.IMultipleCandidatesContextSearch<JetBrains.ReSharper.Feature.Services.Search.SearchRequests.SearchUsagesRequest>, JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextSearches.IRequestContextSearch<JetBrains.ReSharper.Feature.Services.Search.SearchRequests.SearchUsagesRequest>
    {
        protected override JetBrains.ReSharper.Feature.Services.Search.SearchRequests.SearchDeclaredElementUsagesRequest CreateMultipleSearchRequest(JetBrains.Application.DataContext.IDataContext dataContext, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IDeclaredElement> elements, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IDeclaredElement> initialTargets) { }
        protected override JetBrains.ReSharper.Feature.Services.Search.SearchRequests.SearchUsagesRequest CreateSearchRequest(JetBrains.Application.DataContext.IDataContext dataContext, JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, JetBrains.ReSharper.Psi.IDeclaredElement initialTarget) { }
        protected override JetBrains.ReSharper.Psi.Search.ISearchDomain GetSpecialFinderSearchDomain(JetBrains.ReSharper.Feature.Services.Search.ISpecialElementFinder finder, object target, JetBrains.Application.DataContext.IDataContext context) { }
        protected override bool IsAvailableInternal(JetBrains.Application.DataContext.IDataContext dataContext) { }
    }
    [JetBrains.ReSharper.Psi.ShellFeaturePartAttribute()]
    public class ImplementationContextSearch : JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextSearches.BaseSearches.TypeUsageContextSearchBase<JetBrains.ReSharper.Feature.Services.Search.SearchRequests.SearchImplementationsRequest>, JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextSearches.IContextSearch, JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextSearches.IImplementationContextSearch, JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextSearches.IRequestContextSearch<JetBrains.ReSharper.Feature.Services.Search.SearchRequests.SearchImplementationsRequest>
    {
        protected override JetBrains.ReSharper.Feature.Services.Search.SearchRequests.SearchImplementationsRequest CreateSearchRequest(JetBrains.Application.DataContext.IDataContext dataContext, JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, JetBrains.ReSharper.Psi.IDeclaredElement initialTarget) { }
        protected override bool ShouldIgnoreSingleDeclaration(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration) { }
    }
    [JetBrains.ReSharper.Psi.ShellFeaturePartAttribute()]
    public class InheritorsContextSearch : JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextSearches.BaseSearches.HierarchyContextSearchBase, JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextSearches.IContextSearch, JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextSearches.IInheritorsContextSearch, JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextSearches.IRequestContextSearch<JetBrains.ReSharper.Feature.Services.Search.SearchRequests.SearchRequest>
    {
        protected override JetBrains.ReSharper.Psi.Services.ReferencePreferenceKind ReferencePreferenceKind { get; }
        protected override JetBrains.ReSharper.Feature.Services.Search.SearchRequests.SearchRequest CreateSearchRequestInternal(JetBrains.Application.DataContext.IDataContext dataContext, JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
        protected override System.Collections.Generic.IList<JetBrains.ReSharper.Psi.IDeclaredElement> GetCandidates(JetBrains.Application.DataContext.IDataContext context) { }
    }
    [JetBrains.ReSharper.Psi.ShellFeaturePartAttribute()]
    public class TypeDeclarationContextSearch : JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextSearches.BaseSearches.ContextSearchBase<JetBrains.ReSharper.Feature.Services.Search.SearchRequests.SearchDeclarationsRequest>, JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextSearches.IContextSearch, JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextSearches.IRequestContextSearch<JetBrains.ReSharper.Feature.Services.Search.SearchRequests.SearchDeclarationsRequest>, JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextSearches.ITypeDeclarationContextSearch
    {
        protected override JetBrains.ReSharper.Psi.Services.ReferencePreferenceKind ReferencePreferenceKind { get; }
        protected override JetBrains.ReSharper.Feature.Services.Search.SearchRequests.SearchDeclarationsRequest CreateSearchRequest(JetBrains.Application.DataContext.IDataContext dataContext, JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, JetBrains.ReSharper.Psi.IDeclaredElement initialTarget) { }
        protected override System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.DeclaredElementInstance> GetCandidateInstances(JetBrains.Application.DataContext.IDataContext context, JetBrains.ReSharper.Psi.Services.ReferencePreferenceKind kind) { }
        protected override bool IsAvailableInternal(JetBrains.Application.DataContext.IDataContext dataContext) { }
    }
    public abstract class TypeUsageContextSearchBase<TSearchRequest> : JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextSearches.BaseSearches.ContextSearchBase<TSearchRequest>
        where TSearchRequest : JetBrains.ReSharper.Feature.Services.Search.SearchRequests.SearchRequest
    {
        protected override JetBrains.ReSharper.Psi.Services.ReferencePreferenceKind ReferencePreferenceKind { get; }
        protected override System.Collections.Generic.IList<JetBrains.ReSharper.Psi.IDeclaredElement> GetCandidates(JetBrains.Application.DataContext.IDataContext context) { }
        protected override bool IsAvailableInternal(JetBrains.Application.DataContext.IDataContext dataContext) { }
        protected virtual bool ShouldIgnoreSingleDeclaration(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration) { }
    }
    public class UsagesContextSearchBase : JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextSearches.BaseSearches.ContextSearchBase<JetBrains.ReSharper.Feature.Services.Search.SearchRequests.SearchUsagesRequest>, JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextSearches.IContextSearch, JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextSearches.IMultipleCandidatesContextSearch<JetBrains.ReSharper.Feature.Services.Search.SearchRequests.SearchUsagesRequest>, JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextSearches.IRequestContextSearch<JetBrains.ReSharper.Feature.Services.Search.SearchRequests.SearchUsagesRequest>
    {
        protected override JetBrains.ReSharper.Psi.Services.ReferencePreferenceKind ReferencePreferenceKind { get; }
        protected virtual JetBrains.ReSharper.Feature.Services.Search.SearchRequests.SearchDeclaredElementUsagesRequest CreateMultipleSearchRequest(JetBrains.Application.DataContext.IDataContext dataContext, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IDeclaredElement> elements, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IDeclaredElement> initialTargets) { }
        protected override JetBrains.ReSharper.Feature.Services.Search.SearchRequests.SearchUsagesRequest CreateSearchRequest(JetBrains.Application.DataContext.IDataContext dataContext, JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, JetBrains.ReSharper.Psi.IDeclaredElement initialTarget) { }
        public virtual JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextSearches.SearchMultipleDeclaredElement<JetBrains.ReSharper.Feature.Services.Search.SearchRequests.SearchUsagesRequest> GetElementsSearch(JetBrains.Application.DataContext.IDataContext dataContext, bool searchParametersOverloads) { }
        public JetBrains.ReSharper.Psi.IDeclaredElement GetSingleCandidate(JetBrains.Application.DataContext.IDataContext dataContext) { }
        protected override bool IsAvailableInternal(JetBrains.Application.DataContext.IDataContext dataContext) { }
        public JetBrains.ReSharper.Feature.Services.Search.SearchRequests.SearchUsagesRequest TryFindSpecialUsagesRequest(JetBrains.Application.DataContext.IDataContext dataContext) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextSearches
{
    
    [JetBrains.ReSharper.Psi.ShellFeaturePartAttribute()]
    public class DeclaredElementsReferencedCodeContextSearch : JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextSearches.BaseSearches.ContextSearchBase<JetBrains.ReSharper.Feature.Services.Search.SearchRequests.SearchReferencedCodeRequest>, JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextSearches.IContextSearch, JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextSearches.IMultipleCandidatesContextSearch<JetBrains.ReSharper.Feature.Services.Search.SearchRequests.SearchReferencedCodeRequest>, JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextSearches.IRequestContextSearch<JetBrains.ReSharper.Feature.Services.Search.SearchRequests.SearchReferencedCodeRequest>, JetBrains.ReSharper.Feature.Services.Navigation.IReferencedCodeContextSearch
    {
        protected override JetBrains.ReSharper.Feature.Services.Search.SearchRequests.SearchReferencedCodeRequest CreateSearchRequest(JetBrains.Application.DataContext.IDataContext dataContext, JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, JetBrains.ReSharper.Psi.IDeclaredElement initialTarget) { }
        public JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextSearches.SearchMultipleDeclaredElement<JetBrains.ReSharper.Feature.Services.Search.SearchRequests.SearchReferencedCodeRequest> GetElementsSearch(JetBrains.Application.DataContext.IDataContext dataContext, bool searchParametersOverloads) { }
        public JetBrains.ReSharper.Psi.IDeclaredElement GetSingleCandidate(JetBrains.Application.DataContext.IDataContext dataContext) { }
        protected override bool IsAvailableInternal(JetBrains.Application.DataContext.IDataContext dataContext) { }
    }
    public delegate TSearchRequest GetSearchRequest<out TSearchRequest>(JetBrains.Application.DataContext.IDataContext dataContext, JetBrains.ReSharper.Psi.IDeclaredElement promotedTarget, JetBrains.ReSharper.Psi.IDeclaredElement initialTarget);
    public interface IBaseContextSearch : JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextSearches.IContextSearch, JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextSearches.IRequestContextSearch<JetBrains.ReSharper.Feature.Services.Search.SearchRequests.SearchRequest> { }
    public interface IConflictDeclarationsContextSearch : JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextSearches.IContextSearch
    {
        System.Collections.Generic.IList<JetBrains.ReSharper.Feature.Services.Navigation.Navigation.INavigationPoint> SearchTargets(JetBrains.Application.DataContext.IDataContext dataContext);
    }
    public interface IContextSearch
    {
        bool IsAvailable(JetBrains.Application.DataContext.IDataContext dataContext);
        bool IsContextApplicable(JetBrains.Application.DataContext.IDataContext dataContext);
    }
    public interface IDeclarationSearch : JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextSearches.IContextSearch, JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextSearches.IRequestContextSearch<JetBrains.ReSharper.Feature.Services.Search.SearchRequests.SearchDeclarationsRequest>
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Feature.Services.Search.SearchRequests.SearchDeclarationsRequest GetDeclarationSearchRequest(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement);
        bool IsGotoDeclarationApplicable(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement);
    }
    public interface IExtensionMethodsContextSearch : JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextSearches.IContextSearch
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Feature.Services.Search.SearchRequests.ExtensionMethodsSearchRequest GetExtensionMethodsRequest(JetBrains.Application.DataContext.IDataContext dataContext);
    }
    public interface IFindUsagesAdvancedContextSearch : JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextSearches.IContextSearch, JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextSearches.IRequestContextSearch<JetBrains.ReSharper.Feature.Services.Search.SearchRequests.SearchUsagesRequest>
    {
        JetBrains.ReSharper.Feature.Services.Search.SearchRequests.SearchDeclaredElementUsagesRequest CreateAdvancedSearchRequest(JetBrains.ReSharper.Feature.Services.Navigation.AdvancedSearchingInfo searchInfo, JetBrains.Application.DataContext.IDataContext dataContext);
    }
    public interface IFindUsagesContextSearch : JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextSearches.IContextSearch, JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextSearches.IMultipleCandidatesContextSearch<JetBrains.ReSharper.Feature.Services.Search.SearchRequests.SearchUsagesRequest>, JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextSearches.IRequestContextSearch<JetBrains.ReSharper.Feature.Services.Search.SearchRequests.SearchUsagesRequest> { }
    public interface IFlowTargetContextSearch : JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextSearches.IContextSearch
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.Util.JetTuple<JetBrains.ReSharper.Psi.Tree.ITreeNode, System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.Tree.ITreeNode>> SearchTargetAndFinallyBlocks(JetBrains.Application.DataContext.IDataContext dataContext);
    }
    public interface IFunctionExitsContextSearch : JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextSearches.IContextSearch
    {
        System.Collections.Generic.IEnumerable<JetBrains.DocumentModel.DocumentRange> SearchTargets(JetBrains.Application.DataContext.IDataContext dataContext);
    }
    public interface IHighlightUsagesContextSearch : JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextSearches.IContextSearch, JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextSearches.IMultipleCandidatesContextSearch<JetBrains.ReSharper.Feature.Services.Search.SearchRequests.SearchUsagesRequest>, JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextSearches.IRequestContextSearch<JetBrains.ReSharper.Feature.Services.Search.SearchRequests.SearchUsagesRequest> { }
    public interface IImplementationContextSearch : JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextSearches.IContextSearch, JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextSearches.IRequestContextSearch<JetBrains.ReSharper.Feature.Services.Search.SearchRequests.SearchImplementationsRequest> { }
    public interface IImplementingMembersContextSearch : JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextSearches.IContextSearch
    {
        System.Collections.Generic.IEnumerable<JetBrains.DocumentModel.DocumentRange> GetImplementingMemebersDocumentRange(JetBrains.Application.DataContext.IDataContext dataContext);
    }
    public interface IInheritorsContextSearch : JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextSearches.IContextSearch, JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextSearches.IRequestContextSearch<JetBrains.ReSharper.Feature.Services.Search.SearchRequests.SearchRequest> { }
    public interface IMultipleCandidatesContextSearch<TSearchRequest> : JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextSearches.IContextSearch, JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextSearches.IRequestContextSearch<TSearchRequest>
        where TSearchRequest : JetBrains.ReSharper.Feature.Services.Search.SearchRequests.SearchRequest
    {
        JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextSearches.SearchMultipleDeclaredElement<TSearchRequest> GetElementsSearch(JetBrains.Application.DataContext.IDataContext dataContext, bool searchParametersOverloads);
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.IDeclaredElement GetSingleCandidate(JetBrains.Application.DataContext.IDataContext dataContext);
    }
    public interface IOverloadsContextSearch : JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextSearches.IContextSearch
    {
        System.Collections.Generic.IEnumerable<JetBrains.DocumentModel.DocumentRange> GetOverloadRanges(JetBrains.Application.DataContext.IDataContext dataContext);
    }
    public interface IParameterDeclarationContextSearch : JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextSearches.IContextSearch
    {
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IDeclaredElement> SearchTargets(JetBrains.Application.DataContext.IDataContext dataContext);
    }
    public interface IRequestContextSearch<TSearchRequest> : JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextSearches.IContextSearch
        where TSearchRequest : JetBrains.ReSharper.Feature.Services.Search.SearchRequests.SearchRequest
    {
        JetBrains.Util.JetTuple<System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IDeclaredElement>, JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextSearches.GetSearchRequest<TSearchRequest>> GetElementsAndSearchRequest(JetBrains.Application.DataContext.IDataContext dataContext);
    }
    public interface ISubstitutionContextSearch : JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextSearches.IContextSearch
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Feature.Services.Search.SearchRequests.SearchSubstitutionRequest GetSubstitutionRequest([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.DataContext.IDataContext dataContext);
    }
    public interface ITypeDeclarationContextSearch : JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextSearches.IContextSearch, JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextSearches.IRequestContextSearch<JetBrains.ReSharper.Feature.Services.Search.SearchRequests.SearchDeclarationsRequest> { }
    public abstract class ParameterDeclarationContextSearchBase
    {
        [JetBrains.Annotations.NotNullAttribute()]
        protected System.Collections.Generic.List<JetBrains.ReSharper.Psi.IDeclaredElement> GetCandidatesFromDerivedTypes(JetBrains.ReSharper.Psi.IParameter parameter, JetBrains.ReSharper.Psi.Search.ISearchDomain domain) { }
    }
    [JetBrains.ReSharper.Psi.ShellFeaturePartAttribute()]
    public class ProjectItemsReferencedCodeContextSearch : JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextSearches.BaseSearches.ContextSearchBase<JetBrains.ReSharper.Feature.Services.Search.SearchRequests.SearchReferencedCodeRequest>, JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextSearches.IContextSearch, JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextSearches.IRequestContextSearch<JetBrains.ReSharper.Feature.Services.Search.SearchRequests.SearchReferencedCodeRequest>, JetBrains.ReSharper.Feature.Services.Navigation.IReferencedCodeContextSearch
    {
        protected virtual JetBrains.ReSharper.Feature.Services.Search.SearchRequests.SearchReferencedCodeRequest CreateSearchRequest(JetBrains.Application.DataContext.IDataContext dataContext, System.Collections.Generic.IList<JetBrains.ReSharper.Psi.IDeclaredElement> declaredElements) { }
        protected override JetBrains.ReSharper.Feature.Services.Search.SearchRequests.SearchReferencedCodeRequest CreateSearchRequest(JetBrains.Application.DataContext.IDataContext dataContext, JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, JetBrains.ReSharper.Psi.IDeclaredElement initialTarget) { }
        public override JetBrains.Util.JetTuple<System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IDeclaredElement>, JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextSearches.GetSearchRequest<JetBrains.ReSharper.Feature.Services.Search.SearchRequests.SearchReferencedCodeRequest>> GetElementsAndSearchRequest(JetBrains.Application.DataContext.IDataContext dataContext) { }
        protected override bool IsAvailableInternal(JetBrains.Application.DataContext.IDataContext dataContext) { }
    }
    public delegate TSearchUsagesRequest SearchMultipleDeclaredElement<out TSearchUsagesRequest>(JetBrains.Application.DataContext.IDataContext context, System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.IDeclaredElement> declaredElements, System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.IDeclaredElement> initialTargets);
}
namespace JetBrains.ReSharper.Feature.Services.ContextNavigation.Util
{
    
    public class static ContextNavigationUtil
    {
        public static bool CheckDefaultApplicability<TLanguage>(JetBrains.Application.DataContext.IDataContext dataContext)
            where TLanguage : JetBrains.ReSharper.Psi.PsiLanguageType { }
        public static int CompareDeclaredElements(JetBrains.ReSharper.Psi.IDeclaredElement xElement, JetBrains.ReSharper.Psi.IDeclaredElement yElement) { }
        public static System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.DeclaredElementInstance> GetCandidateInstances(JetBrains.Application.DataContext.IDataContext context, JetBrains.ReSharper.Psi.Services.ReferencePreferenceKind kind) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Psi.IDeclaredElement GetDeclaredElementFromOccurence(JetBrains.ReSharper.Feature.Services.Search.IOccurence occurence) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Feature.Services.ContextNavigation.Util.IFunctionExitsFinder GetFunctionExitsFinder(JetBrains.ReSharper.Psi.PsiLanguageType languageType) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static TTreeNode GetSelectedLanguageSpecificTreeNode<TTreeNode, TLanguageType>(JetBrains.Application.DataContext.IDataContext dataContext)
            where TTreeNode :  class, JetBrains.ReSharper.Psi.Tree.ITreeNode
            where TLanguageType : JetBrains.ReSharper.Psi.PsiLanguageType { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static TTreeNode GetSelectedTreeNode<TTreeNode>(this JetBrains.Application.DataContext.IDataContext dataContext)
            where TTreeNode :  class, JetBrains.ReSharper.Psi.Tree.ITreeNode { }
        public static void HighlightResults(JetBrains.Application.DataContext.IDataContext context, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Tree.ITreeNode> targetNodes, string noResultsMessage = "No results found for this action") { }
        public static void HighlightResults(JetBrains.Application.DataContext.IDataContext dataContext, System.Collections.Generic.IEnumerable<JetBrains.DocumentModel.DocumentRange> targetRanges, string noResultsMessage) { }
        public static void Navigate(JetBrains.TextControl.ITextControl textControl, JetBrains.Util.TextRange range) { }
    }
    public interface IFunctionExitsFinder
    {
        System.Collections.Generic.IEnumerable<JetBrains.DocumentModel.DocumentRange> GetReachableExitKeywordsRanges(JetBrains.ReSharper.Psi.Tree.IDeclaration functionDeclaration);
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Tree.ITreeNode> GetReachableExitNodes(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration);
    }
}
namespace JetBrains.ReSharper.Feature.Services.Goto
{
    
    public class ChainedNavigationItemData
    {
        public ChainedNavigationItemData(JetBrains.ReSharper.Feature.Services.Goto.MatchingInfo firstWordMatchingInfo, JetBrains.ReSharper.Feature.Services.Goto.INavigationScope scopeData) { }
        public JetBrains.ReSharper.Feature.Services.Goto.MatchingInfo ChainedMatchingInfo { get; }
        public JetBrains.ReSharper.Feature.Services.Goto.INavigationScope Scope { get; }
    }
    public class FileMemberNavigationScope : JetBrains.ReSharper.Feature.Services.Goto.INavigationScope
    {
        public FileMemberNavigationScope(JetBrains.ReSharper.Psi.IPsiSourceFile scopeData, JetBrains.ReSharper.Feature.Services.Search.LibrariesFlag extendsFlag, System.Func<System.Collections.Generic.ICollection<JetBrains.ProjectModel.IProjectFile>> secondayScopeData = null) { }
        public JetBrains.ReSharper.Feature.Services.Search.LibrariesFlag ExtendedSearchFlag { get; set; }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ReSharper.Psi.IPsiSourceFile GetPrimarySourceFile() { }
        public System.Func<System.Collections.Generic.ICollection<JetBrains.ProjectModel.IProjectFile>> GetSecondaryFilesGetter() { }
        public JetBrains.ProjectModel.ISolution GetSolution() { }
    }
    public class GotoContext : JetBrains.Util.UserDataHolder { }
    public class GotoEverythingConstants
    {
        public const int InstantItemsLimit = 10;
    }
    public class GotoMenuItemUtil
    {
        public static string GetModuleName([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IModule module) { }
        public static bool IsDisambigNeeded(JetBrains.ProjectModel.IModule module) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class GotoProvidersManager
    {
        public GotoProvidersManager(JetBrains.ReSharper.Feature.Services.IFeaturePartsContainer container) { }
        public System.Collections.Generic.IEnumerable<TNavigationProvider> GetAllGotoProviders<TNavigationProvider>()
            where TNavigationProvider :  class, JetBrains.ReSharper.Feature.Services.Goto.IApplicableGotoProvider { }
    }
    public interface IApplicableGotoProvider
    {
        bool IsApplicable(JetBrains.ReSharper.Feature.Services.Goto.INavigationScope scope, JetBrains.ReSharper.Feature.Services.Goto.GotoContext gotoContext, JetBrains.Text.IdentifierMatcher matcher);
    }
    public interface IChainedOccurencesProvider
    {
        System.Collections.Generic.IEnumerable<JetBrains.Util.Pair<JetBrains.ReSharper.Feature.Services.Search.IOccurence, JetBrains.ReSharper.Feature.Services.Goto.MatchingInfo>> FindOccurences(JetBrains.Text.IdentifierMatcher matcher, JetBrains.ReSharper.Feature.Services.Goto.INavigationScope scope, JetBrains.ReSharper.Feature.Services.Search.LibrariesFlag includeLibraries, JetBrains.Application.CheckForInterrupt checkCancelled);
    }
    public interface ICompletionGotoController
    {
        bool LibrariesFlagAutoSwitch { get; set; }
        JetBrains.UI.GotoByName.GotoByNameModel Model { get; }
        void RestrictItemsPassFilter(System.Func<JetBrains.ReSharper.Psi.IDeclaredElement, bool> filter);
    }
    public interface IGotoEverythingProvider : JetBrains.ReSharper.Feature.Services.Goto.IApplicableGotoProvider, JetBrains.ReSharper.Feature.Services.Goto.IOccurenceNavigationProvider
    {
        System.Func<int, int> ItemsPriorityFunc { get; }
    }
    public interface IGotoFileMemberProvider : JetBrains.ReSharper.Feature.Services.Goto.IApplicableGotoProvider, JetBrains.ReSharper.Feature.Services.Goto.IOccurenceNavigationProvider { }
    public interface IGotoFileProvider : JetBrains.ReSharper.Feature.Services.Goto.IApplicableGotoProvider, JetBrains.ReSharper.Feature.Services.Goto.IGotoEverythingProvider, JetBrains.ReSharper.Feature.Services.Goto.IOccurenceNavigationProvider { }
    public interface IGotoRecentFilesProvider : JetBrains.ReSharper.Feature.Services.Goto.IApplicableGotoProvider, JetBrains.ReSharper.Feature.Services.Navigation.Goto.IInstantGotoProvider { }
    public interface IGotoSymbolProvider : JetBrains.ReSharper.Feature.Services.Goto.IApplicableGotoProvider, JetBrains.ReSharper.Feature.Services.Goto.IOccurenceNavigationProvider { }
    public interface IGotoTypeMemberProvider : JetBrains.ReSharper.Feature.Services.Goto.IApplicableGotoProvider, JetBrains.ReSharper.Feature.Services.Goto.IOccurenceNavigationProvider { }
    public interface IGotoTypeProvider : JetBrains.ReSharper.Feature.Services.Goto.IApplicableGotoProvider, JetBrains.ReSharper.Feature.Services.Goto.IOccurenceNavigationProvider, JetBrains.ReSharper.Feature.Services.Navigation.Goto.IInstantGotoProvider { }
    public interface INavigationScope
    {
        JetBrains.ReSharper.Feature.Services.Search.LibrariesFlag ExtendedSearchFlag { get; set; }
        JetBrains.ProjectModel.ISolution GetSolution();
    }
    public interface IOccurenceNavigationProvider : JetBrains.ReSharper.Feature.Services.Goto.IApplicableGotoProvider
    {
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.Goto.MatchingInfo> FindMatchingInfos(JetBrains.Text.IdentifierMatcher matcher, JetBrains.ReSharper.Feature.Services.Goto.INavigationScope scope, JetBrains.ReSharper.Feature.Services.Goto.GotoContext gotoContext, JetBrains.Application.CheckForInterrupt checkForInterrupt);
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.Search.IOccurence> GetOccurencesByMatchingInfo(JetBrains.ReSharper.Feature.Services.Goto.MatchingInfo navigationInfo, JetBrains.ReSharper.Feature.Services.Goto.INavigationScope scope, JetBrains.ReSharper.Feature.Services.Goto.GotoContext gotoContext, JetBrains.Application.CheckForInterrupt checkForInterrupt);
    }
    public class MatchingInfo
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Feature.Services.Goto.MatchingInfo modreq(System.Runtime.CompilerServices.IsVolatile) PreviousMatchingInfo;
        public MatchingInfo(string identifier, System.Collections.Generic.IEnumerable<JetBrains.Text.IdentifierMatch> matches, bool matchingIndiciesAreCorrect = True, System.Func<int, int> adjustmentFunc = null, string specificFilterString = null) { }
        public string Identifier { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.Text.IdentifierMatch> Matches { get; }
        public bool MatchingIndiciesAreCorrect { get; }
        public System.Func<int, int> ScoringAdjustmentFunc { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public string SpecificFilterString { get; }
        public void AssignNewMatchingIndicies(System.Collections.Generic.IEnumerable<JetBrains.Text.IdentifierMatch> matchingIndicies) { }
        protected bool Equals(JetBrains.ReSharper.Feature.Services.Goto.MatchingInfo other) { }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
    }
    public class NamespaceNavigationScope : JetBrains.ReSharper.Feature.Services.Goto.INavigationScope
    {
        public NamespaceNavigationScope(JetBrains.ReSharper.Psi.INamespace @namespace, JetBrains.ReSharper.Feature.Services.Search.LibrariesFlag flag) { }
        public JetBrains.ReSharper.Feature.Services.Search.LibrariesFlag ExtendedSearchFlag { get; set; }
        public JetBrains.ReSharper.Psi.INamespace Namespace { get; }
        public JetBrains.ProjectModel.ISolution GetSolution() { }
    }
    public class ProjectModelNavigationScope : JetBrains.ReSharper.Feature.Services.Goto.INavigationScope
    {
        public ProjectModelNavigationScope(JetBrains.ProjectModel.IProjectModelElement projectItem, JetBrains.ReSharper.Feature.Services.Search.LibrariesFlag flag) { }
        public JetBrains.ReSharper.Feature.Services.Search.LibrariesFlag ExtendedSearchFlag { get; set; }
        public JetBrains.ProjectModel.IProjectModelElement ProjectItem { get; }
        public JetBrains.ProjectModel.ISolution GetSolution() { }
    }
    public class SolutionNavigationScope : JetBrains.ReSharper.Feature.Services.Goto.INavigationScope
    {
        public SolutionNavigationScope(JetBrains.ProjectModel.ISolution solution, bool extendsFlag) { }
        public JetBrains.ReSharper.Feature.Services.Search.LibrariesFlag ExtendedSearchFlag { get; set; }
        public JetBrains.ProjectModel.ISolution GetSolution() { }
    }
    public class TypeElementNavigationScope : JetBrains.ReSharper.Feature.Services.Goto.INavigationScope
    {
        public TypeElementNavigationScope(JetBrains.ReSharper.Psi.ITypeElement typeElement, JetBrains.ReSharper.Feature.Services.Search.LibrariesFlag flag) { }
        public JetBrains.ReSharper.Feature.Services.Search.LibrariesFlag ExtendedSearchFlag { get; set; }
        public JetBrains.ReSharper.Psi.ITypeElement TypeElement { get; }
        public JetBrains.ProjectModel.ISolution GetSolution() { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.Goto.ChainedProviders
{
    
    public interface IChainedNamespacesProvider : JetBrains.ReSharper.Feature.Services.Goto.ChainedProviders.IChainedSearchProvider, JetBrains.ReSharper.Feature.Services.Goto.IApplicableGotoProvider { }
    public interface IChainedProjectElementProvider : JetBrains.ReSharper.Feature.Services.Goto.ChainedProviders.IChainedSearchEverythingProvider, JetBrains.ReSharper.Feature.Services.Goto.ChainedProviders.IChainedSearchProvider, JetBrains.ReSharper.Feature.Services.Goto.IApplicableGotoProvider { }
    public interface IChainedSearchEverythingProvider : JetBrains.ReSharper.Feature.Services.Goto.ChainedProviders.IChainedSearchProvider, JetBrains.ReSharper.Feature.Services.Goto.IApplicableGotoProvider { }
    public interface IChainedSearchProvider : JetBrains.ReSharper.Feature.Services.Goto.IApplicableGotoProvider
    {
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.Goto.ChainedNavigationItemData> GetNextChainedScopes(JetBrains.ReSharper.Feature.Services.Goto.GotoContext gotoContext, JetBrains.Text.IdentifierMatcher matcher, JetBrains.ReSharper.Feature.Services.Goto.INavigationScope containingScope, JetBrains.Application.CheckForInterrupt checkForInterrupt);
    }
    public interface IChainedSymbolProvider : JetBrains.ReSharper.Feature.Services.Goto.ChainedProviders.IChainedSearchEverythingProvider, JetBrains.ReSharper.Feature.Services.Goto.ChainedProviders.IChainedSearchProvider, JetBrains.ReSharper.Feature.Services.Goto.IApplicableGotoProvider { }
}
namespace JetBrains.ReSharper.Feature.Services.Goto.GotoProviders
{
    
    public abstract class CachedGotoSymbolBase<TCache> : JetBrains.ReSharper.Feature.Services.Goto.IApplicableGotoProvider, JetBrains.ReSharper.Feature.Services.Goto.IOccurenceNavigationProvider
        where TCache :  class
    {
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.Goto.MatchingInfo> FindMatchingInfos(JetBrains.Text.IdentifierMatcher matcher, JetBrains.ReSharper.Feature.Services.Goto.INavigationScope scope, JetBrains.ReSharper.Feature.Services.Goto.GotoContext gotoContext, JetBrains.Application.CheckForInterrupt checkForInterrupt) { }
        protected abstract TCache GetCache(JetBrains.ReSharper.Feature.Services.Goto.INavigationScope scope, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Feature.Services.Goto.GotoContext gotoContext);
        protected abstract System.Collections.Generic.IEnumerable<string> GetNames(TCache cache, JetBrains.ReSharper.Feature.Services.Goto.INavigationScope scope);
        public abstract System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.Search.IOccurence> GetOccurencesByMatchingInfo(JetBrains.ReSharper.Feature.Services.Goto.MatchingInfo navigationInfo, JetBrains.ReSharper.Feature.Services.Goto.INavigationScope scope, JetBrains.ReSharper.Feature.Services.Goto.GotoContext gotoContext, JetBrains.Application.CheckForInterrupt checkForInterrupt);
        public virtual bool IsApplicable(JetBrains.ReSharper.Feature.Services.Goto.INavigationScope scope, JetBrains.ReSharper.Feature.Services.Goto.GotoContext gotoContext, JetBrains.Text.IdentifierMatcher matcher) { }
    }
    public class static ChainedScopesUtil
    {
        public static int CalculateChainedScore(System.Collections.Generic.List<string> revertedWords, JetBrains.ReSharper.Feature.Services.Goto.MatchingInfo matchingInfo) { }
        public static bool CanNavigateToDeclaredElement(JetBrains.ReSharper.Psi.IClrDeclaredElement element) { }
        public static JetBrains.ReSharper.Psi.Caches.ISymbolScope GetDeclarationsCache(JetBrains.ReSharper.Feature.Services.Goto.INavigationScope scope, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Feature.Services.Goto.GotoContext gotoContext) { }
        public static System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.Goto.ChainedNavigationItemData> GetNextCodeModelScope(JetBrains.Text.IdentifierMatcher matcher, JetBrains.ReSharper.Feature.Services.Goto.INavigationScope containingScope, JetBrains.Application.CheckForInterrupt checkCancelled, JetBrains.ReSharper.Psi.Caches.ISymbolScope cache, bool includeTypeElements) { }
    }
    [JetBrains.ReSharper.Psi.ShellFeaturePartAttribute()]
    public class ClrGotoFileMemberProvider : JetBrains.ReSharper.Feature.Services.Goto.IApplicableGotoProvider, JetBrains.ReSharper.Feature.Services.Goto.IGotoFileMemberProvider, JetBrains.ReSharper.Feature.Services.Goto.IOccurenceNavigationProvider
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        protected virtual JetBrains.ReSharper.Feature.Services.Search.IOccurence CreateOccurence(JetBrains.ReSharper.Feature.Services.Goto.GotoProviders.ClrGotoFileMemberProvider.ClrFileMemberData clrFileMemberData) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.Goto.MatchingInfo> FindMatchingInfos(JetBrains.Text.IdentifierMatcher matcher, JetBrains.ReSharper.Feature.Services.Goto.INavigationScope scope, JetBrains.ReSharper.Feature.Services.Goto.GotoContext gotoContext, JetBrains.Application.CheckForInterrupt checkForInterrupt) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.Search.IOccurence> GetOccurencesByMatchingInfo(JetBrains.ReSharper.Feature.Services.Goto.MatchingInfo navigationInfo, JetBrains.ReSharper.Feature.Services.Goto.INavigationScope scope, JetBrains.ReSharper.Feature.Services.Goto.GotoContext gotoContext, JetBrains.Application.CheckForInterrupt checkForInterrupt) { }
        protected virtual System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.ITypeElement> GetPsiSourceFileTypeElements(JetBrains.ReSharper.Psi.IPsiSourceFile primarySourceFile) { }
        protected virtual System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.Goto.GotoProviders.ClrGotoFileMemberProvider.ClrFileMemberData> GetSecondaryMembers(JetBrains.ReSharper.Psi.IPsiSourceFile primarySourceFile, System.Func<System.Collections.Generic.ICollection<JetBrains.ProjectModel.IProjectFile>> secondaryProjectFilesGetter) { }
        public virtual bool IsApplicable(JetBrains.ReSharper.Feature.Services.Goto.INavigationScope scope, JetBrains.ReSharper.Feature.Services.Goto.GotoContext gotoContext, JetBrains.Text.IdentifierMatcher matcher) { }
        protected virtual bool IsIndexer(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
        protected virtual bool IsSourceFileAvailable(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
        protected virtual bool IsValidMemberOfSourceFile(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, JetBrains.ReSharper.Psi.IDeclaredElement typeMember, JetBrains.ReSharper.Psi.ITypeElement contatiningTypeElement) { }
        protected class ClrFileMemberData
        {
            public ClrFileMemberData(JetBrains.ReSharper.Psi.IDeclaredElement element, bool isInRelatedFile, JetBrains.ReSharper.Feature.Services.Occurences.ContainerDisplayStyle disambigStyle) { }
            public JetBrains.ReSharper.Feature.Services.Occurences.ContainerDisplayStyle ContainerDisplayStyle { get; }
            public JetBrains.ReSharper.Psi.IDeclaredElement Element { get; }
            public bool IsInRelatedFile { get; }
        }
    }
    public abstract class ClrGotoSymbolProvider : JetBrains.ReSharper.Feature.Services.Goto.GotoProviders.CachedGotoSymbolBase<JetBrains.ReSharper.Psi.Caches.ISymbolScope>, JetBrains.ReSharper.Feature.Services.Goto.ChainedProviders.IChainedSearchEverythingProvider, JetBrains.ReSharper.Feature.Services.Goto.ChainedProviders.IChainedSearchProvider, JetBrains.ReSharper.Feature.Services.Goto.ChainedProviders.IChainedSymbolProvider, JetBrains.ReSharper.Feature.Services.Goto.IApplicableGotoProvider
    {
        public System.Func<int, int> ItemsPriorityFunc { get; }
        protected override JetBrains.ReSharper.Psi.Caches.ISymbolScope GetCache(JetBrains.ReSharper.Feature.Services.Goto.INavigationScope scope, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Feature.Services.Goto.GotoContext gotoContext) { }
        protected override System.Collections.Generic.IEnumerable<string> GetNames(JetBrains.ReSharper.Psi.Caches.ISymbolScope cache, JetBrains.ReSharper.Feature.Services.Goto.INavigationScope scope) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.Goto.ChainedNavigationItemData> GetNextChainedScopes(JetBrains.ReSharper.Feature.Services.Goto.GotoContext gotoContext, JetBrains.Text.IdentifierMatcher matcher, JetBrains.ReSharper.Feature.Services.Goto.INavigationScope containingScope, JetBrains.Application.CheckForInterrupt checkForInterrupt) { }
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.Search.IOccurence> GetOccurencesByMatchingInfo(JetBrains.ReSharper.Feature.Services.Goto.MatchingInfo navigationInfo, JetBrains.ReSharper.Feature.Services.Goto.INavigationScope scope, JetBrains.ReSharper.Feature.Services.Goto.GotoContext gotoContext, JetBrains.Application.CheckForInterrupt checkForInterrupt) { }
        protected abstract System.Collections.Generic.IEnumerable<string> GetShortNamesFromCache(JetBrains.ReSharper.Psi.Caches.ISymbolScope cache);
        public override bool IsApplicable(JetBrains.ReSharper.Feature.Services.Goto.INavigationScope scope, JetBrains.ReSharper.Feature.Services.Goto.GotoContext gotoContext, JetBrains.Text.IdentifierMatcher matcher) { }
        protected virtual bool IsDeclaredElementVisible(JetBrains.ReSharper.Psi.IClrDeclaredElement element, JetBrains.Application.CheckForInterrupt checkForInterrupt, JetBrains.ReSharper.Psi.Caches.ISymbolScope cache) { }
    }
    [JetBrains.ReSharper.Psi.ShellFeaturePartAttribute()]
    public class ClrGotoTypeMemberProvider : JetBrains.ReSharper.Feature.Services.Goto.IApplicableGotoProvider, JetBrains.ReSharper.Feature.Services.Goto.IGotoEverythingProvider, JetBrains.ReSharper.Feature.Services.Goto.IGotoTypeMemberProvider, JetBrains.ReSharper.Feature.Services.Goto.IOccurenceNavigationProvider
    {
        public System.Func<int, int> ItemsPriorityFunc { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.Goto.MatchingInfo> FindMatchingInfos(JetBrains.Text.IdentifierMatcher matcher, JetBrains.ReSharper.Feature.Services.Goto.INavigationScope scope, JetBrains.ReSharper.Feature.Services.Goto.GotoContext gotoContext, JetBrains.Application.CheckForInterrupt checkForInterrupt) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.Search.IOccurence> GetOccurencesByMatchingInfo(JetBrains.ReSharper.Feature.Services.Goto.MatchingInfo navigationInfo, JetBrains.ReSharper.Feature.Services.Goto.INavigationScope scope, JetBrains.ReSharper.Feature.Services.Goto.GotoContext gotoContext, JetBrains.Application.CheckForInterrupt checkForInterrupt) { }
        public bool IsApplicable(JetBrains.ReSharper.Feature.Services.Goto.INavigationScope scope, JetBrains.ReSharper.Feature.Services.Goto.GotoContext gotoContext, JetBrains.Text.IdentifierMatcher matcher) { }
        protected virtual bool IsDeclaredElementVisible(JetBrains.ReSharper.Psi.IClrDeclaredElement element) { }
        public class DeclaredElementData
        {
            public DeclaredElementData(string shortName, JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
            public JetBrains.ReSharper.Psi.IDeclaredElement DeclaredElement { get; }
            public bool DisambigNeeded { get; set; }
            public string ShortName { get; }
        }
    }
    [JetBrains.ReSharper.Psi.ShellFeaturePartAttribute()]
    public class ClrGotoTypeProvider : JetBrains.ReSharper.Feature.Services.Goto.GotoProviders.CachedGotoSymbolBase<JetBrains.ReSharper.Psi.Caches.ISymbolScope>, JetBrains.ReSharper.Feature.Services.Goto.ChainedProviders.IChainedNamespacesProvider, JetBrains.ReSharper.Feature.Services.Goto.ChainedProviders.IChainedSearchProvider, JetBrains.ReSharper.Feature.Services.Goto.IApplicableGotoProvider, JetBrains.ReSharper.Feature.Services.Goto.IGotoEverythingProvider, JetBrains.ReSharper.Feature.Services.Goto.IGotoTypeProvider, JetBrains.ReSharper.Feature.Services.Goto.IOccurenceNavigationProvider, JetBrains.ReSharper.Feature.Services.Navigation.Goto.IInstantGotoProvider
    {
        public System.Func<int, int> ItemsPriorityFunc { get; }
        protected override JetBrains.ReSharper.Psi.Caches.ISymbolScope GetCache(JetBrains.ReSharper.Feature.Services.Goto.INavigationScope scope, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Feature.Services.Goto.GotoContext gotoContext) { }
        public System.Collections.Generic.IEnumerable<JetBrains.Util.Pair<JetBrains.ReSharper.Feature.Services.Search.IOccurence, JetBrains.ReSharper.Feature.Services.Goto.MatchingInfo>> GetMatchingOccurences(JetBrains.Text.IdentifierMatcher matcher, JetBrains.ReSharper.Feature.Services.Goto.INavigationScope scope, JetBrains.ReSharper.Feature.Services.Goto.GotoContext gotoContext, JetBrains.Application.CheckForInterrupt checkForInterrupt) { }
        protected override System.Collections.Generic.IEnumerable<string> GetNames(JetBrains.ReSharper.Psi.Caches.ISymbolScope cache, JetBrains.ReSharper.Feature.Services.Goto.INavigationScope scope) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.Goto.ChainedNavigationItemData> GetNextChainedScopes(JetBrains.ReSharper.Feature.Services.Goto.GotoContext gotoContext, JetBrains.Text.IdentifierMatcher matcher, JetBrains.ReSharper.Feature.Services.Goto.INavigationScope containingScope, JetBrains.Application.CheckForInterrupt checkForInterrupt) { }
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.Search.IOccurence> GetOccurencesByMatchingInfo(JetBrains.ReSharper.Feature.Services.Goto.MatchingInfo navigationInfo, JetBrains.ReSharper.Feature.Services.Goto.INavigationScope scope, JetBrains.ReSharper.Feature.Services.Goto.GotoContext gotoContext, JetBrains.Application.CheckForInterrupt checkForInterrupt) { }
        public override bool IsApplicable(JetBrains.ReSharper.Feature.Services.Goto.INavigationScope scope, JetBrains.ReSharper.Feature.Services.Goto.GotoContext gotoContext, JetBrains.Text.IdentifierMatcher matcher) { }
        protected virtual bool IsDeclaredElementVisible(JetBrains.ReSharper.Psi.IClrDeclaredElement element, JetBrains.Application.CheckForInterrupt checkForInterrupt, JetBrains.ReSharper.Psi.Caches.ISymbolScope cache) { }
    }
    public abstract class ClrSpecificGotoFileMemberProvider : JetBrains.ReSharper.Feature.Services.Goto.GotoProviders.ClrGotoFileMemberProvider
    {
        protected override System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.Goto.GotoProviders.ClrGotoFileMemberProvider.ClrFileMemberData> GetSecondaryMembers(JetBrains.ReSharper.Psi.IPsiSourceFile primarySourceFile, System.Func<System.Collections.Generic.ICollection<JetBrains.ProjectModel.IProjectFile>> secondaryProjectFiles) { }
        protected virtual bool IsValidSecondaryMember(JetBrains.ReSharper.Psi.IPsiSourceFile primarySourceFile, JetBrains.ReSharper.Psi.IDeclaredElement typeMember, JetBrains.ReSharper.Psi.ITypeElement containingTypeElement) { }
    }
    [JetBrains.ReSharper.Psi.ShellFeaturePartAttribute()]
    public class GotoFileProvider : JetBrains.ReSharper.Feature.Services.Goto.ChainedProviders.IChainedProjectElementProvider, JetBrains.ReSharper.Feature.Services.Goto.ChainedProviders.IChainedSearchEverythingProvider, JetBrains.ReSharper.Feature.Services.Goto.ChainedProviders.IChainedSearchProvider, JetBrains.ReSharper.Feature.Services.Goto.IApplicableGotoProvider, JetBrains.ReSharper.Feature.Services.Goto.IGotoEverythingProvider, JetBrains.ReSharper.Feature.Services.Goto.IGotoFileProvider, JetBrains.ReSharper.Feature.Services.Goto.IOccurenceNavigationProvider, JetBrains.ReSharper.Feature.Services.Navigation.Goto.IInstantGotoProvider
    {
        public System.Func<int, int> ItemsPriorityFunc { get; }
        public virtual System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.Goto.MatchingInfo> FindMatchingInfos(JetBrains.Text.IdentifierMatcher matcher, JetBrains.ReSharper.Feature.Services.Goto.INavigationScope scope, JetBrains.ReSharper.Feature.Services.Goto.GotoContext gotoContext, JetBrains.Application.CheckForInterrupt checkForInterrupt) { }
        public System.Collections.Generic.IEnumerable<JetBrains.Util.Pair<JetBrains.ReSharper.Feature.Services.Search.IOccurence, JetBrains.ReSharper.Feature.Services.Goto.MatchingInfo>> GetMatchingOccurences(JetBrains.Text.IdentifierMatcher matcher, JetBrains.ReSharper.Feature.Services.Goto.INavigationScope scope, JetBrains.ReSharper.Feature.Services.Goto.GotoContext gotoContext, JetBrains.Application.CheckForInterrupt checkForInterrupt) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.Goto.ChainedNavigationItemData> GetNextChainedScopes(JetBrains.ReSharper.Feature.Services.Goto.GotoContext gotoContext, JetBrains.Text.IdentifierMatcher matcher, JetBrains.ReSharper.Feature.Services.Goto.INavigationScope containingScope, JetBrains.Application.CheckForInterrupt checkForInterrupt) { }
        public virtual System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.Search.IOccurence> GetOccurencesByMatchingInfo(JetBrains.ReSharper.Feature.Services.Goto.MatchingInfo navigationInfo, JetBrains.ReSharper.Feature.Services.Goto.INavigationScope scope, JetBrains.ReSharper.Feature.Services.Goto.GotoContext gotoContext, JetBrains.Application.CheckForInterrupt checkForInterrupt) { }
        public virtual bool IsApplicable(JetBrains.ReSharper.Feature.Services.Goto.INavigationScope scope, JetBrains.ReSharper.Feature.Services.Goto.GotoContext gotoContext, JetBrains.Text.IdentifierMatcher matcher) { }
    }
    [JetBrains.ReSharper.Psi.ShellFeaturePartAttribute()]
    public class GotoLineNumberProvider : JetBrains.ReSharper.Feature.Services.Goto.IApplicableGotoProvider, JetBrains.ReSharper.Feature.Services.Goto.IGotoEverythingProvider, JetBrains.ReSharper.Feature.Services.Goto.IGotoFileProvider, JetBrains.ReSharper.Feature.Services.Goto.IOccurenceNavigationProvider
    {
        public GotoLineNumberProvider() { }
        public System.Func<int, int> ItemsPriorityFunc { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.Goto.MatchingInfo> FindMatchingInfos(JetBrains.Text.IdentifierMatcher matcher, JetBrains.ReSharper.Feature.Services.Goto.INavigationScope scope, JetBrains.ReSharper.Feature.Services.Goto.GotoContext gotoContext, JetBrains.Application.CheckForInterrupt checkForInterrupt) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.Search.IOccurence> GetOccurencesByMatchingInfo(JetBrains.ReSharper.Feature.Services.Goto.MatchingInfo navigationInfo, JetBrains.ReSharper.Feature.Services.Goto.INavigationScope scope, JetBrains.ReSharper.Feature.Services.Goto.GotoContext gotoContext, JetBrains.Application.CheckForInterrupt checkForInterrupt) { }
        public bool IsApplicable(JetBrains.ReSharper.Feature.Services.Goto.INavigationScope scope, JetBrains.ReSharper.Feature.Services.Goto.GotoContext gotoContext, JetBrains.Text.IdentifierMatcher matcher) { }
    }
    public interface ICacheScopeProvider
    {
        JetBrains.ReSharper.Psi.Caches.LibrarySymbolScope GetCacheScope(JetBrains.ReSharper.Feature.Services.Goto.INavigationScope scope);
    }
    public interface IGotoNamespaceProvider : JetBrains.ReSharper.Feature.Services.Goto.IApplicableGotoProvider, JetBrains.ReSharper.Feature.Services.Goto.IOccurenceNavigationProvider { }
    public abstract class NonCachedFileMemberProvider<TLanguageType> : JetBrains.ReSharper.Feature.Services.Goto.IApplicableGotoProvider, JetBrains.ReSharper.Feature.Services.Goto.IGotoFileMemberProvider, JetBrains.ReSharper.Feature.Services.Goto.IOccurenceNavigationProvider
        where TLanguageType : JetBrains.ReSharper.Psi.PsiLanguageType
    {
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.Goto.MatchingInfo> FindMatchingInfos(JetBrains.Text.IdentifierMatcher matcher, JetBrains.ReSharper.Feature.Services.Goto.INavigationScope scope, JetBrains.ReSharper.Feature.Services.Goto.GotoContext gotoContext, JetBrains.Application.CheckForInterrupt checkForInterrupt) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.Search.IOccurence> GetOccurencesByMatchingInfo(JetBrains.ReSharper.Feature.Services.Goto.MatchingInfo navigationInfo, JetBrains.ReSharper.Feature.Services.Goto.INavigationScope scope, JetBrains.ReSharper.Feature.Services.Goto.GotoContext gotoContext, JetBrains.Application.CheckForInterrupt checkForInterrupt) { }
        public bool IsApplicable(JetBrains.ReSharper.Feature.Services.Goto.INavigationScope scope, JetBrains.ReSharper.Feature.Services.Goto.GotoContext gotoContext, JetBrains.Text.IdentifierMatcher matcher) { }
        protected virtual bool IsAvailable(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class ReSharperCacheScopeProvider : JetBrains.ReSharper.Feature.Services.Goto.GotoProviders.ICacheScopeProvider
    {
        public virtual JetBrains.ReSharper.Psi.Caches.LibrarySymbolScope GetCacheScope(JetBrains.ReSharper.Feature.Services.Goto.INavigationScope scope) { }
    }
    public class static TypeMemberNavigationUtil
    {
        public static bool BasicFileMemberFilter(JetBrains.ReSharper.Psi.ITypeElement typeToSearchIn, JetBrains.ReSharper.Psi.ITypeMember member) { }
        public static System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.ITypeMember> GetFilteredTypeMembers([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.ITypeElement typeToSearchIn, [JetBrains.Annotations.CanBeNullAttribute()] System.Func<JetBrains.ReSharper.Psi.ITypeMember, JetBrains.ReSharper.Psi.ITypeElement, bool> typeMembersFilter, [JetBrains.Annotations.CanBeNullAttribute()] string shortName) { }
        public static System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.ITypeElement> GetPsiSourceFileTypeElements(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
        public static System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IDeclaredElement> GetTypeElementMembers(JetBrains.ReSharper.Psi.ITypeElement typeElement, [JetBrains.Annotations.CanBeNullAttribute()] System.Func<JetBrains.ReSharper.Psi.ITypeMember, JetBrains.ReSharper.Psi.ITypeElement, bool> typeMembersFilter, [JetBrains.Annotations.CanBeNullAttribute()] string shortName) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services
{
    
    public interface IFeaturePartsContainer
    {
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.IEnumerable<T> GetFeatureParts<T>(System.Func<T, bool> isApplicable)
            where T :  class;
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class SolutionFeaturePartsContainer
    {
        public SolutionFeaturePartsContainer(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.Parts.IPartsCatalogueSet catalogueSet, JetBrains.Application.Components.IComponentContainer parentContainer) { }
        public System.Collections.Generic.IEnumerable<T> GetFeatureParts<T>(System.Func<T, bool> isApplicable) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.Navigation
{
    
    public class AdvancedSearchingInfo
    {
        public AdvancedSearchingInfo(System.Collections.Generic.IList<JetBrains.ReSharper.Psi.IDeclaredElement> elements, JetBrains.ReSharper.Psi.Search.SearchPattern pattern, JetBrains.ReSharper.Psi.Search.ISearchDomain domain) { }
        public JetBrains.ReSharper.Psi.Search.ISearchDomain Domain { get; set; }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Psi.IDeclaredElement> Elements { get; set; }
        public JetBrains.ReSharper.Psi.Search.SearchPattern Pattern { get; set; }
    }
    public class AssemblyInfoNavigationData
    {
        public AssemblyInfoNavigationData([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.Model2.Assemblies.Interfaces.IAssembly assembly, JetBrains.ReSharper.Psi.IClrDeclaredElement target = null, int index = -1) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ProjectModel.Model2.Assemblies.Interfaces.IAssembly Assembly { get; }
        public int Index { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ReSharper.Psi.IClrDeclaredElement Target { get; }
    }
    public class CompiledElementNavigationInfo
    {
        public CompiledElementNavigationInfo([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.ICompiledElement whereToSearch, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.IDeclaredElement whatToSearch, int index = 0, bool useFocusedTextControlContent = False) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ReSharper.Psi.ICompiledElement ElementToSearchIn { get; }
        public int Index { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Psi.IDeclaredElement Target { get; }
        public bool UseFocusedTextControlContent { get; }
    }
    [JetBrains.UI.ActiveText.ProtocolHandlerAttribute(Protocol="declaredelement")]
    public class DeclaredElementProtocolHandler : JetBrains.UI.ActiveText.ProtocolHandler
    {
        public DeclaredElementProtocolHandler(JetBrains.UI.PopupWindowManager.MainWindowPopupWindowContext popupWindowContext) { }
        protected override void NavigateNakedLink(string link, object host) { }
    }
    public interface IDeclaredElementNavigationService
    {
        void ExecuteCandidates(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IDeclaredElement> candidates, JetBrains.UI.PopupWindowManager.PopupWindowContextSource source, bool transferFocus);
        void Navigate(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, JetBrains.UI.PopupWindowManager.PopupWindowContextSource windowContext, bool transferFocus, System.Nullable<JetBrains.ReSharper.Feature.Services.Occurences.OccurencePresentationOptions> options = null, JetBrains.IDE.TabOptions tabOptions = 2);
    }
    public interface IReferencedCodeContextSearch : JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextSearches.IContextSearch, JetBrains.ReSharper.Feature.Services.ContextNavigation.ContextSearches.IRequestContextSearch<JetBrains.ReSharper.Feature.Services.Search.SearchRequests.SearchReferencedCodeRequest> { }
    public abstract class NavigationManager
    {
        protected NavigationManager(JetBrains.DocumentManagers.DocumentManager documentManager, JetBrains.UI.PopupWindowManager.MainWindowPopupWindowContext mainWindowPopupWindowContext) { }
        public static JetBrains.ReSharper.Feature.Services.Navigation.NavigationManager GetInstance(JetBrains.ProjectModel.ISolution solution) { }
        public abstract System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.Navigation.Navigation.INavigationPoint> GetNavigationPoints<TNavigationProvider, TNavigationData>(TNavigationData target)
            where TNavigationProvider :  class, JetBrains.ReSharper.Feature.Services.Navigation.Navigation.INavigationProvider<>
        ;
        public abstract bool HasBackwardNavigation();
        public abstract bool HasForwardNavigation();
        public bool Navigate<TNavigationProvider, TNavigationData>([JetBrains.Annotations.NotNullAttribute()] TNavigationData target, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Feature.Services.Navigation.NavigationOptions options)
            where TNavigationProvider :  class, JetBrains.ReSharper.Feature.Services.Navigation.Navigation.INavigationProvider<> { }
        public bool Navigate<TNavigationProvider, TNavigationData>([JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IEnumerable<TNavigationData> targets, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Feature.Services.Navigation.NavigationOptions options)
            where TNavigationProvider :  class, JetBrains.ReSharper.Feature.Services.Navigation.Navigation.INavigationProvider<> { }
        public bool Navigate<TNavigationProvider, TNavigationData>(TNavigationData target, bool activate)
            where TNavigationProvider :  class, JetBrains.ReSharper.Feature.Services.Navigation.Navigation.INavigationProvider<> { }
        public abstract bool Navigate([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Feature.Services.Navigation.Navigation.INavigationPoint point, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Feature.Services.Navigation.NavigationOptions options);
        public abstract bool Navigate([JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.Navigation.Navigation.INavigationPoint> points, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Feature.Services.Navigation.NavigationOptions options);
        public abstract bool NavigateBackward();
        public abstract bool NavigateForward();
        [System.ObsoleteAttribute("Use extension method from JetBrains.ReSharper.Feature.Services.Navigation.Navigat" +
            "ion.DeclaredElementNavigationExtensions class instead")]
        public static bool NavigateToDeclaredElement(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, bool activate) { }
        [System.ObsoleteAttribute("Use extension method from JetBrains.ReSharper.Feature.Services.Navigation.Navigat" +
            "ion.NavigationExtensions.CommonElementsNavigationExtensions class instead")]
        public static bool NavigateToReference(JetBrains.ReSharper.Psi.Resolve.IReference reference, bool activate) { }
        [System.ObsoleteAttribute("Use extension method from JetBrains.ReSharper.Feature.Services.Navigation.Navigat" +
            "ion.NavigationExtensions.CommonElementsNavigationExtensions class instead")]
        public static bool NavigateToTreeNode(JetBrains.ReSharper.Psi.Tree.ITreeNode element, bool activate) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class NavigationManagerImpl : JetBrains.ReSharper.Feature.Services.Navigation.NavigationManager
    {
        public NavigationManagerImpl(JetBrains.Application.IShellLocks shellLocks, JetBrains.UI.Application.IUIApplication environment, JetBrains.DocumentManagers.DocumentManager documentManager, JetBrains.TextControl.ITextControlManager textControlManager, JetBrains.IDE.EditorManager editorManager, JetBrains.ReSharper.Feature.Services.Navigation.CustomHighlighting.CustomHighlightingManager customHighlightingManager, JetBrains.UI.PopupWindowManager.MainWindowPopupWindowContext mainWindowPopupWindowContext, JetBrains.ReSharper.Feature.Services.SolutionFeaturePartsContainer featurePartsContainer) { }
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.Navigation.Navigation.INavigationPoint> GetNavigationPoints<TNavigationProvider, TNavigationData>(TNavigationData target)
            where TNavigationProvider :  class, JetBrains.ReSharper.Feature.Services.Navigation.Navigation.INavigationProvider<> { }
        public override bool HasBackwardNavigation() { }
        public override bool HasForwardNavigation() { }
        public override bool Navigate(JetBrains.ReSharper.Feature.Services.Navigation.Navigation.INavigationPoint point, JetBrains.ReSharper.Feature.Services.Navigation.NavigationOptions options) { }
        public override bool Navigate(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.Navigation.Navigation.INavigationPoint> points, JetBrains.ReSharper.Feature.Services.Navigation.NavigationOptions options) { }
        public override bool NavigateBackward() { }
        public override bool NavigateForward() { }
        protected virtual bool PerformNavigate(JetBrains.ReSharper.Feature.Services.Navigation.Navigation.INavigationPoint point, JetBrains.ReSharper.Feature.Services.Navigation.NavigationOptions options) { }
        protected void PushHistory() { }
        protected virtual bool ShowMenu(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.Navigation.Navigation.INavigationPoint> points, JetBrains.ReSharper.Feature.Services.Navigation.NavigationOptions options) { }
        protected virtual void SynchronizeToCaret() { }
    }
    public class NavigationOptions
    {
        public bool Activate { get; }
        public JetBrains.UI.RichText.RichText Caption { get; }
        public JetBrains.IDE.FileView FileView { get; }
        public bool Highlight { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.UI.PopupWindowManager.PopupWindowContextSource PopupWindowContextSource { get; }
        public JetBrains.IDE.TabOptions TabOptions { get; }
        public static JetBrains.ReSharper.Feature.Services.Navigation.NavigationOptions Create(string caption, JetBrains.UI.PopupWindowManager.PopupWindowContextSource windowContext) { }
        public static JetBrains.ReSharper.Feature.Services.Navigation.NavigationOptions FromDataContext(JetBrains.Application.DataContext.IDataContext dataContext, JetBrains.UI.RichText.RichText caption) { }
        public static JetBrains.ReSharper.Feature.Services.Navigation.NavigationOptions FromDataContext(JetBrains.Application.DataContext.IDataContext dataContext, JetBrains.UI.RichText.RichText caption, bool activate) { }
        public static JetBrains.ReSharper.Feature.Services.Navigation.NavigationOptions FromWindowContext(JetBrains.UI.PopupWindowManager.PopupWindowContextSource windowContext, JetBrains.UI.RichText.RichText caption, bool activate, JetBrains.IDE.FileView fileView, JetBrains.IDE.TabOptions tabOptions = 2) { }
        public static JetBrains.ReSharper.Feature.Services.Navigation.NavigationOptions FromWindowContext(JetBrains.UI.PopupWindowManager.PopupWindowContextSource windowContext, JetBrains.UI.RichText.RichText caption, bool activate, JetBrains.IDE.TabOptions tabOptions = 2) { }
        public static JetBrains.ReSharper.Feature.Services.Navigation.NavigationOptions FromWindowContext(JetBrains.UI.PopupWindowManager.PopupWindowContextSource windowContext, JetBrains.UI.RichText.RichText caption) { }
    }
    [JetBrains.Annotations.MeansImplicitUseAttribute()]
    [System.AttributeUsageAttribute(System.AttributeTargets.Class | System.AttributeTargets.All, AllowMultiple=false, Inherited=false)]
    public sealed class NavigationProviderAttribute : JetBrains.ProjectModel.SolutionComponentAttribute { }
    public class ProjectFileNavigationPoint : JetBrains.ReSharper.Feature.Services.Navigation.Navigation.INavigationPoint, JetBrains.ReSharper.Feature.Services.Navigation.Navigation.IProjectFileNavigationPoint
    {
        public ProjectFileNavigationPoint(JetBrains.ProjectModel.IProjectFile projectFile) { }
        public bool IsValid { get; }
        public JetBrains.ProjectModel.IProjectFile ProjectFile { get; }
        public JetBrains.UI.Icons.IconId GetPresentationImage() { }
        public JetBrains.UI.RichText.RichText GetPresentationText() { }
        public JetBrains.UI.RichText.RichText GetSecondaryPresentationText() { }
        public bool Navigate(JetBrains.ReSharper.Feature.Services.Navigation.NavigationOptions options) { }
    }
    [JetBrains.ReSharper.Psi.SolutionFeaturePartAttribute()]
    public class ProjectFileNavigationProvider : JetBrains.ReSharper.Feature.Services.Navigation.Navigation.INavigationProvider<JetBrains.ProjectModel.IProjectModelElement>, JetBrains.ReSharper.Feature.Services.Navigation.Navigation.NavigationProviders.IProjectModelElementNavigationProvider
    {
        public virtual System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.Navigation.Navigation.INavigationPoint> CreateNavigationPoints(JetBrains.ProjectModel.IProjectModelElement element) { }
        public virtual bool IsApplicable(JetBrains.ProjectModel.IProjectModelElement element) { }
    }
    public class SearchSymbolReferencedCodeRequest : JetBrains.ReSharper.Feature.Services.Search.SearchRequests.SearchReferencedCodeRequest
    {
        public SearchSymbolReferencedCodeRequest(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IDeclaredElement> elementsToSearch, JetBrains.ProjectModel.ISolution solution) { }
        public SearchSymbolReferencedCodeRequest(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
        public override System.Collections.ICollection SearchTargets { get; }
        public override string Title { get; }
        public override System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.Search.IOccurence> Search(JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.Navigation.CustomHighlighting
{
    
    [System.FlagsAttribute()]
    public enum AutomaticHighlightingHidingPolicy
    {
        None = 0,
        DocumentChange = 1,
        SelectionChange = 2,
        TextControlFocus = 4,
    }
    public class CustomHighlightingEntry : JetBrains.TextControl.DocumentMarkup.IHighlighterTooltipProvider
    {
        public CustomHighlightingEntry(JetBrains.Util.TextRange range) { }
        public CustomHighlightingEntry(JetBrains.DocumentModel.DocumentRange range) { }
        public CustomHighlightingEntry(JetBrains.Util.TextRange range, JetBrains.ReSharper.Feature.Services.Navigation.CustomHighlighting.CustomHighlightingKind kind) { }
        public CustomHighlightingEntry(JetBrains.Util.TextRange range, string toolTip) { }
        public CustomHighlightingEntry(JetBrains.DocumentModel.DocumentRange range, JetBrains.ReSharper.Feature.Services.Navigation.CustomHighlighting.CustomHighlightingKind kind) { }
        public CustomHighlightingEntry(JetBrains.Util.TextRange range, JetBrains.ReSharper.Feature.Services.Navigation.CustomHighlighting.CustomHighlightingKind kind, string toolTip) { }
        public JetBrains.ReSharper.Feature.Services.Navigation.CustomHighlighting.CustomHighlightingKind Kind { get; }
        public JetBrains.Util.TextRange TextRange { get; }
        public JetBrains.UI.RichText.RichTextBlock GetRichTooltip(JetBrains.TextControl.DocumentMarkup.IHighlighter highlighter) { }
        public string GetTooltip(JetBrains.TextControl.DocumentMarkup.IHighlighter highlighter) { }
        public string GetTooltipForErrorStripe(JetBrains.TextControl.DocumentMarkup.IHighlighter highlighter) { }
        public override string ToString() { }
    }
    public enum CustomHighlightingKind
    {
        Target = 0,
        ReadUsage = 1,
        WriteUsage = 2,
        Navigation = 3,
        Other = 4,
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class CustomHighlightingManager
    {
        protected readonly JetBrains.TextControl.DocumentMarkup.IDocumentMarkupManager myDocumentMarkupManager;
        protected readonly JetBrains.Application.IShellLocks myLocks;
        public CustomHighlightingManager(JetBrains.DataFlow.Lifetime lifetime, JetBrains.DocumentManagers.DocumentManager documentManager, JetBrains.TextControl.DocumentMarkup.IDocumentMarkupManager documentMarkupManager, JetBrains.Application.IShellLocks locks, JetBrains.ActionManagement.IActionManager actionman, JetBrains.TextControl.ITextControlManager textman, JetBrains.IDE.ResultList.ResultListManager resultlistman) { }
        public JetBrains.ReSharper.Feature.Services.Navigation.CustomHighlighting.CustomHighlightingManager.CustomHighlightingManagerForTextControl ForTextControl([JetBrains.Annotations.NotNullAttribute()] JetBrains.TextControl.ITextControl tc) { }
        public static JetBrains.ReSharper.Feature.Services.Navigation.CustomHighlighting.CustomHighlightingManager GetInstance(JetBrains.ProjectModel.ISolution solution) { }
        public void Hide(JetBrains.ReSharper.Feature.Services.Navigation.CustomHighlighting.CustomHighlightingRequest request) { }
        public void Show(JetBrains.ReSharper.Feature.Services.Navigation.CustomHighlighting.CustomHighlightingRequest request) { }
        public struct CustomHighlightingManagerForTextControl
        {
            public bool HasRequests { get; }
            [JetBrains.Annotations.NotNullAttribute()]
            public JetBrains.TextControl.ITextControl TextControl { get; }
            public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.Navigation.CustomHighlighting.CustomHighlightingRequest> EnumerateRequests() { }
            public void HideLastHighlight() { }
        }
    }
    public class static CustomHighlightingManagerEx
    {
        public static void Show(this JetBrains.ReSharper.Feature.Services.Navigation.CustomHighlighting.CustomHighlightingManager thіs, JetBrains.TextControl.ITextControl textcontrol, System.Collections.Generic.IList<JetBrains.ReSharper.Feature.Services.Navigation.CustomHighlighting.CustomHighlightingEntry> ranges, JetBrains.ReSharper.Feature.Services.Navigation.CustomHighlighting.AutomaticHighlightingHidingPolicy hidepolicy = 0) { }
    }
    public class static CustomHighlightingManagerIds
    {
        public const string NavigationHighlighterErrorStripeID = "ReSharper Navigation Highlight Marker on Error Stripe";
        public const string NavigationHighlighterID = "ReSharper Navigation Highlight";
        public const string OtherHighlighterErrorStripeID = "ReSharper Highlight Marker on Error Stripe";
        public const string OtherHighlighterID = "ReSharper Highlight";
        public const string ReadHighlighterErrorStripeID = "ReSharper Read Usage Marker on Error Stripe";
        public const string ReadHighlighterID = "ReSharper Read Usage";
        public const string TargetHighlighterErrorStripeID = "ReSharper Highlight Target Marker on Error Stripe";
        public const string TargetHighlighterID = "ReSharper Highlight Target";
        public const string WriteHighlighterErrorStripeID = "ReSharper Write Usage Marker on Error Stripe";
        public const string WriteHighlighterID = "ReSharper Write Usage";
    }
    public class CustomHighlightingRequest
    {
        public CustomHighlightingRequest([JetBrains.Annotations.NotNullAttribute()] JetBrains.TextControl.ITextControl textControl, [JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IList<JetBrains.ReSharper.Feature.Services.Navigation.CustomHighlighting.CustomHighlightingEntry> ranges, JetBrains.ReSharper.Feature.Services.Navigation.CustomHighlighting.AutomaticHighlightingHidingPolicy hidingPolicy) { }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Feature.Services.Navigation.CustomHighlighting.CustomHighlightingEntry> Entries { get; }
        public JetBrains.ReSharper.Feature.Services.Navigation.CustomHighlighting.AutomaticHighlightingHidingPolicy HidingPolicy { get; set; }
        public object Identity { get; set; }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.TextControl.ITextControl TextControl { get; }
    }
}
namespace JetBrains.ReSharper.Feature.Services.Navigation.Goto
{
    
    public interface IGotoRecentEditsProvider : JetBrains.ReSharper.Feature.Services.Goto.IApplicableGotoProvider, JetBrains.ReSharper.Feature.Services.Navigation.Goto.IInstantGotoProvider { }
    public interface IInstantGotoProvider : JetBrains.ReSharper.Feature.Services.Goto.IApplicableGotoProvider
    {
        System.Collections.Generic.IEnumerable<JetBrains.Util.Pair<JetBrains.ReSharper.Feature.Services.Search.IOccurence, JetBrains.ReSharper.Feature.Services.Goto.MatchingInfo>> GetMatchingOccurences(JetBrains.Text.IdentifierMatcher matcher, JetBrains.ReSharper.Feature.Services.Goto.INavigationScope scope, JetBrains.ReSharper.Feature.Services.Goto.GotoContext gotoContext, JetBrains.Application.CheckForInterrupt checkForInterrupt);
    }
}
namespace JetBrains.ReSharper.Feature.Services.Navigation.GoToRelated
{
    
    [JetBrains.ReSharper.Feature.Services.Navigation.GoToRelated.RelatedFilesProviderAttribute(typeof(JetBrains.ProjectModel.KnownProjectFileType))]
    public class DefaultRelatedFilesProvider : JetBrains.ReSharper.Feature.Services.Navigation.GoToRelated.IRelatedFilesProvider
    {
        public virtual System.Collections.Generic.IEnumerable<JetBrains.Util.JetTuple<JetBrains.ProjectModel.IProjectFile, string, JetBrains.ProjectModel.IProjectFile>> GetRelatedFiles(JetBrains.ProjectModel.IProjectFile projectFile) { }
    }
    [JetBrains.ReSharper.Feature.Services.Navigation.GoToRelated.RelatedFilesProviderAttribute(typeof(JetBrains.ProjectModel.KnownProjectFileType))]
    public class DependentRelatedFilesProvider : JetBrains.ReSharper.Feature.Services.Navigation.GoToRelated.IRelatedFilesProvider
    {
        public System.Collections.Generic.IEnumerable<JetBrains.Util.JetTuple<JetBrains.ProjectModel.IProjectFile, string, JetBrains.ProjectModel.IProjectFile>> GetRelatedFiles(JetBrains.ProjectModel.IProjectFile projectFile) { }
    }
    public interface IRelatedFilesProvider
    {
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.IEnumerable<JetBrains.Util.JetTuple<JetBrains.ProjectModel.IProjectFile, string, JetBrains.ProjectModel.IProjectFile>> GetRelatedFiles([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IProjectFile projectFile);
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class RelatedFilesManager
    {
        public RelatedFilesManager(JetBrains.ProjectModel.FileTypes.IProjectFileTypeServices projectFileTypeServices) { }
        public System.Collections.Generic.IEnumerable<JetBrains.Util.JetTuple<JetBrains.ProjectModel.IProjectFile, string, JetBrains.ProjectModel.IProjectFile>> GetRelatedFiles([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IProjectFile projectFile) { }
    }
    [JetBrains.Annotations.BaseTypeRequiredAttribute(typeof(JetBrains.ReSharper.Feature.Services.Navigation.GoToRelated.IRelatedFilesProvider))]
    [JetBrains.Annotations.MeansImplicitUseAttribute()]
    [System.AttributeUsageAttribute(System.AttributeTargets.Class | System.AttributeTargets.All, AllowMultiple=false, Inherited=false)]
    public class RelatedFilesProviderAttribute : JetBrains.ProjectModel.ProjectFileTypeAttribute
    {
        public RelatedFilesProviderAttribute(System.Type type) { }
    }
    [JetBrains.ReSharper.Feature.Services.Navigation.GoToRelated.RelatedFilesProviderAttribute(typeof(JetBrains.ProjectModel.KnownProjectFileType))]
    public class TypeRelatedFilesProvider : JetBrains.ReSharper.Feature.Services.Navigation.GoToRelated.IRelatedFilesProvider
    {
        public System.Collections.Generic.IEnumerable<JetBrains.Util.JetTuple<JetBrains.ProjectModel.IProjectFile, string, JetBrains.ProjectModel.IProjectFile>> GetRelatedFiles(JetBrains.ProjectModel.IProjectFile projectFile) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.Navigation.Navigation
{
    
    public class static DeclaredElementNavigationExtensions
    {
        public static void Navigate(this JetBrains.ReSharper.Psi.IDeclaredElement target, bool transferFocus, JetBrains.UI.PopupWindowManager.PopupWindowContextSource windowContext = null, System.Nullable<JetBrains.ReSharper.Feature.Services.Occurences.OccurencePresentationOptions> options = null) { }
    }
    public class DeclaredElementNavigationPoint : JetBrains.ReSharper.Feature.Services.Navigation.Navigation.IDeclaredElementNavigationPoint, JetBrains.ReSharper.Feature.Services.Navigation.Navigation.INavigationPoint
    {
        public DeclaredElementNavigationPoint(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
        public JetBrains.UI.Icons.IconId GetPresentationImage() { }
        public JetBrains.UI.RichText.RichText GetPresentationText() { }
        public JetBrains.UI.RichText.RichText GetSecondaryPresentationText() { }
        public bool Navigate(JetBrains.ReSharper.Feature.Services.Navigation.NavigationOptions options) { }
    }
    public interface IDeclaredElementNavigationPoint : JetBrains.ReSharper.Feature.Services.Navigation.Navigation.INavigationPoint { }
    public interface INavigationPoint
    {
        JetBrains.UI.Icons.IconId GetPresentationImage();
        JetBrains.UI.RichText.RichText GetPresentationText();
        JetBrains.UI.RichText.RichText GetSecondaryPresentationText();
        bool Navigate(JetBrains.ReSharper.Feature.Services.Navigation.NavigationOptions options);
    }
    public interface INavigationProvider<in TNavigationData>
    
    {
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.Navigation.Navigation.INavigationPoint> CreateNavigationPoints(TNavigationData target);
        bool IsApplicable(TNavigationData data);
    }
    public interface IProjectFileNavigationPoint : JetBrains.ReSharper.Feature.Services.Navigation.Navigation.INavigationPoint
    {
        JetBrains.ProjectModel.IProjectFile ProjectFile { get; }
    }
    public interface ITextNavigationPoint : JetBrains.ReSharper.Feature.Services.Navigation.Navigation.INavigationPoint
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Feature.Services.Navigation.Navigation.NavigationPointHighlightingInfo GetHighlightingInfo(JetBrains.ReSharper.Feature.Services.Navigation.NavigationOptions options);
    }
    public class NavigationPointHighlightingInfo
    {
        public NavigationPointHighlightingInfo(JetBrains.TextControl.ITextControl textControl, JetBrains.Util.TextRange textRange) { }
        public JetBrains.TextControl.ITextControl TextControl { get; }
        public JetBrains.Util.TextRange TextRange { get; }
    }
    [JetBrains.ReSharper.Psi.SolutionFeaturePartAttribute()]
    public class ProjectFileTextRangeNavigationProvider : JetBrains.ReSharper.Feature.Services.Navigation.Navigation.INavigationProvider<JetBrains.ProjectModel.ProjectFileTextRange>, JetBrains.ReSharper.Feature.Services.Navigation.Navigation.NavigationProviders.IProjectFileTextRangeNavigationProvider
    {
        public virtual System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.Navigation.Navigation.INavigationPoint> CreateNavigationPoints(JetBrains.ProjectModel.ProjectFileTextRange navigationRange) { }
        public virtual bool IsApplicable(JetBrains.ProjectModel.ProjectFileTextRange data) { }
    }
    [JetBrains.ReSharper.Psi.SolutionFeaturePartAttribute()]
    public class PsiSourceFileNavigationProvider : JetBrains.ReSharper.Feature.Services.Navigation.Navigation.INavigationProvider<JetBrains.ReSharper.Feature.Services.Navigation.Navigation.PsiSourceFileRange>, JetBrains.ReSharper.Feature.Services.Navigation.Navigation.NavigationProviders.IPsiSourceFileRangeNavigationProvider
    {
        public PsiSourceFileNavigationProvider(JetBrains.ReSharper.ExternalSources.ReSharperIntegration.FileSystemPathNavigator navigator, JetBrains.ProjectModel.ProjectFileExtensions extensions, JetBrains.ReSharper.Psi.PsiProjectFileTypeCoordinator fileTypeCoordinator, JetBrains.IDE.EditorManager editorManager) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.Navigation.Navigation.INavigationPoint> CreateNavigationPoints(JetBrains.ReSharper.Feature.Services.Navigation.Navigation.PsiSourceFileRange sourceFileRange) { }
        public bool IsApplicable(JetBrains.ReSharper.Feature.Services.Navigation.Navigation.PsiSourceFileRange sourceFileRange) { }
    }
    public class PsiSourceFileRange
    {
        public PsiSourceFileRange([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, JetBrains.Util.TextRange textRange) { }
        public JetBrains.ReSharper.Psi.IPsiSourceFile SourceFile { get; }
        public JetBrains.Util.TextRange TextRange { get; }
        [System.Diagnostics.ConditionalAttribute("JET_MODE_ASSERT")]
        public void AssertIsValid() { }
        public bool IsValid() { }
    }
    public class TextNavigationPoint : JetBrains.ReSharper.Feature.Services.Navigation.Navigation.INavigationPoint, JetBrains.ReSharper.Feature.Services.Navigation.Navigation.ITextNavigationPoint
    {
        public TextNavigationPoint(JetBrains.ProjectModel.ProjectFileTextRange target) { }
        public TextNavigationPoint(JetBrains.ProjectModel.IProjectFile projectFile, int offset) { }
        public bool IsValid { get; }
        public JetBrains.ProjectModel.IProjectFile ProjectFile { get; }
        public JetBrains.Util.TextRange TextRange { get; }
        public JetBrains.ReSharper.Feature.Services.Navigation.Navigation.NavigationPointHighlightingInfo GetHighlightingInfo(JetBrains.ReSharper.Feature.Services.Navigation.NavigationOptions options) { }
        public JetBrains.UI.Icons.IconId GetPresentationImage() { }
        public JetBrains.UI.RichText.RichText GetPresentationText() { }
        public JetBrains.UI.RichText.RichText GetSecondaryPresentationText() { }
        public bool Navigate(JetBrains.ReSharper.Feature.Services.Navigation.NavigationOptions options) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.Navigation.Navigation.NavigationExtensions
{
    
    public class static CommonElementsNavigationExtensions
    {
        public static System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.Navigation.Navigation.INavigationPoint> GetNavigationPoints(this JetBrains.ReSharper.Psi.Tree.ITreeNode node) { }
        public static bool Navigate(this JetBrains.ProjectModel.IProjectModelElement projectModelElement, JetBrains.UI.PopupWindowManager.PopupWindowContextSource source, bool transferFocus) { }
        public static bool Navigate(this JetBrains.ReSharper.Feature.Services.Navigation.AssemblyInfoNavigationData assemblyInfoNavigationData, JetBrains.UI.PopupWindowManager.PopupWindowContextSource source, bool transferFocus) { }
        public static bool Navigate(this JetBrains.ProjectModel.ProjectFileTextRange projectFileTextRange, JetBrains.UI.PopupWindowManager.PopupWindowContextSource source, bool transferFocus, JetBrains.IDE.TabOptions tabOptions = 2) { }
        [System.ObsoleteAttribute("Use overload with psi source file")]
        public static bool Navigate(this JetBrains.DocumentModel.DocumentRange documentRange, JetBrains.ProjectModel.ISolution solution, bool activate, JetBrains.UI.PopupWindowManager.PopupWindowContextSource source = null) { }
        public static bool Navigate(this JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, JetBrains.Util.TextRange textRange, bool activate, JetBrains.IDE.TabOptions tabOptions = 2, JetBrains.UI.PopupWindowManager.PopupWindowContextSource source = null) { }
        public static bool NavigateToExternalSources(this JetBrains.ReSharper.Psi.ICompiledElement compiledElement, JetBrains.UI.PopupWindowManager.PopupWindowContextSource source, bool transferFocus) { }
        public static bool NavigateToExternalSources(this JetBrains.ReSharper.Feature.Services.Navigation.CompiledElementNavigationInfo compiledElementNavigationInfo, JetBrains.UI.PopupWindowManager.PopupWindowContextSource source, bool transferFocus) { }
        public static bool NavigateToNode(this JetBrains.ReSharper.Psi.Tree.ITreeNode element, bool activate) { }
        public static bool NavigateToReference(this JetBrains.ReSharper.Psi.Resolve.IReference reference, bool activate, JetBrains.UI.PopupWindowManager.PopupWindowContextSource source = null) { }
        public static bool NavigateToTreeNode(this JetBrains.ReSharper.Psi.Tree.ITreeNode element, bool activate, JetBrains.UI.PopupWindowManager.PopupWindowContextSource source = null) { }
        public static bool NavigateToVsObjectBrowser(this JetBrains.ReSharper.Psi.ICompiledElement compiledElement, JetBrains.UI.PopupWindowManager.PopupWindowContextSource source, bool transferFocus) { }
        public static bool NavigateToVsSolutionExplorer(this JetBrains.ProjectModel.IProjectItem projectItem, JetBrains.UI.PopupWindowManager.PopupWindowContextSource source, bool transferFocus) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.Navigation.Navigation.NavigationProviders
{
    
    public interface IAssemblyInfoNavigationProvider : JetBrains.ReSharper.Feature.Services.Navigation.Navigation.INavigationProvider<JetBrains.ReSharper.Feature.Services.Navigation.AssemblyInfoNavigationData> { }
    public interface IDecompiledFileNavigationProvider : JetBrains.ReSharper.Feature.Services.Navigation.Navigation.INavigationProvider<JetBrains.ReSharper.Feature.Services.Occurences.DecompiledFileNavigationData> { }
    public interface IDefaultCompiledElementNavigationProvider : JetBrains.ReSharper.Feature.Services.Navigation.Navigation.INavigationProvider<JetBrains.ReSharper.Psi.ICompiledElement> { }
    public interface IProjectFileTextRangeNavigationProvider : JetBrains.ReSharper.Feature.Services.Navigation.Navigation.INavigationProvider<JetBrains.ProjectModel.ProjectFileTextRange> { }
    public interface IProjectModelElementNavigationProvider : JetBrains.ReSharper.Feature.Services.Navigation.Navigation.INavigationProvider<JetBrains.ProjectModel.IProjectModelElement> { }
    public interface IPsiSourceFileRangeNavigationProvider : JetBrains.ReSharper.Feature.Services.Navigation.Navigation.INavigationProvider<JetBrains.ReSharper.Feature.Services.Navigation.Navigation.PsiSourceFileRange> { }
    public interface IVsObjectBrowserNavigationProvider : JetBrains.ReSharper.Feature.Services.Navigation.Navigation.INavigationProvider<JetBrains.ReSharper.Psi.ICompiledElement> { }
    public interface IVsSolutionExplorerNavigationProvider : JetBrains.ReSharper.Feature.Services.Navigation.Navigation.INavigationProvider<JetBrains.ProjectModel.IProjectModelElement>, JetBrains.ReSharper.Feature.Services.Navigation.Navigation.NavigationProviders.IProjectModelElementNavigationProvider { }
}
namespace JetBrains.ReSharper.Feature.Services.Navigation.Occurences
{
    
    public class ChainedRangeOccurence : JetBrains.ReSharper.Feature.Services.Navigation.Occurences.RangeOccurence
    {
        public ChainedRangeOccurence(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, JetBrains.ReSharper.Feature.Services.Goto.MatchingInfo matchingInfo, JetBrains.DocumentModel.DocumentRange documentRange, JetBrains.ReSharper.Feature.Services.Occurences.OccurencePresentationOptions options) { }
        public JetBrains.ReSharper.Feature.Services.Goto.MatchingInfo MatchingInfo { get; }
    }
    public class CustomRangeOccurence : JetBrains.ReSharper.Feature.Services.Navigation.Occurences.RangeOccurence
    {
        public CustomRangeOccurence(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, JetBrains.DocumentModel.DocumentRange documentRange, JetBrains.ReSharper.Feature.Services.Occurences.OccurencePresentationOptions options) { }
        protected override bool CheckForTrimmedLineOffset { get; }
        protected override bool IsTextRangeValid(int length, int startOffset, int lineLength) { }
    }
    public class FileSystemPathOccurence : JetBrains.ReSharper.Feature.Services.Search.IOccurence
    {
        public FileSystemPathOccurence(JetBrains.Util.FileSystemPath path) { }
        public bool IsValid { get; }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Feature.Services.Search.IOccurence> MergedItems { get; }
        public object MergeKey { get; }
        public JetBrains.ReSharper.Psi.DeclaredElementEnvoy<JetBrains.ReSharper.Psi.INamespace> Namespace { get; }
        public JetBrains.ReSharper.Feature.Services.Search.OccurenceType OccurenceType { get; }
        public JetBrains.Util.FileSystemPath Path { get; }
        public JetBrains.ReSharper.Feature.Services.Occurences.OccurencePresentationOptions PresentationOptions { get; set; }
        public JetBrains.ProjectModel.ProjectModelElementEnvoy ProjectModelElementEnvoy { get; }
        public JetBrains.Util.TextRange TextRange { get; }
        public JetBrains.ReSharper.Psi.DeclaredElementEnvoy<JetBrains.ReSharper.Psi.ITypeElement> TypeElement { get; }
        public JetBrains.ReSharper.Psi.DeclaredElementEnvoy<JetBrains.ReSharper.Psi.ITypeMember> TypeMember { get; }
        public string DumpToString() { }
        protected bool Equals(JetBrains.ReSharper.Feature.Services.Navigation.Occurences.FileSystemPathOccurence other) { }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
        public bool Navigate(JetBrains.ProjectModel.ISolution solution, JetBrains.UI.PopupWindowManager.PopupWindowContextSource windowContext, bool transferFocus, JetBrains.IDE.TabOptions tabOptions = 2) { }
    }
    public class RangeOccurence : JetBrains.ReSharper.Feature.Services.Search.IOccurence
    {
        public JetBrains.ReSharper.Psi.PsiLanguageType Language;
        public RangeOccurence([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, JetBrains.DocumentModel.DocumentRange documentRange, JetBrains.ReSharper.Feature.Services.Search.OccurenceType occurenceType, JetBrains.ReSharper.Feature.Services.Occurences.OccurencePresentationOptions options) { }
        public RangeOccurence([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Resolve.IReference reference, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.IDeclaredElement target, JetBrains.ReSharper.Feature.Services.Search.OccurenceType occurenceType) { }
        protected RangeOccurence(JetBrains.ReSharper.Psi.Tree.ITreeNode treeNode, JetBrains.ReSharper.Feature.Services.Search.OccurenceType occurenceKind) { }
        protected RangeOccurence(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, JetBrains.DocumentModel.DocumentRange documentRange, JetBrains.ReSharper.Feature.Services.Occurences.OccurencePresentationOptions options) { }
        public RangeOccurence(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, JetBrains.DocumentModel.DocumentRange documentRange) { }
        protected virtual bool CheckForTrimmedLineOffset { get; }
        public JetBrains.DocumentModel.DocumentCoords DocumentCoords { get; }
        public bool IsValid { get; }
        public string Line { get; }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Feature.Services.Search.IOccurence> MergedItems { get; }
        public virtual object MergeKey { get; }
        public virtual JetBrains.ReSharper.Psi.DeclaredElementEnvoy<JetBrains.ReSharper.Psi.INamespace> Namespace { get; }
        public JetBrains.Util.TextRange OccurenceRange { get; }
        public JetBrains.ReSharper.Feature.Services.Search.OccurenceType OccurenceType { get; }
        public JetBrains.ReSharper.Feature.Services.Occurences.OccurencePresentationOptions PresentationOptions { get; set; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ProjectModel.ProjectModelElementEnvoy ProjectModelElementEnvoy { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ReSharper.Psi.IPsiSourceFile SourceFile { get; }
        public JetBrains.Util.TextRange TextRange { get; }
        public virtual JetBrains.ReSharper.Psi.DeclaredElementEnvoy<JetBrains.ReSharper.Psi.ITypeElement> TypeElement { get; }
        public virtual JetBrains.ReSharper.Psi.DeclaredElementEnvoy<JetBrains.ReSharper.Psi.ITypeMember> TypeMember { get; }
        public virtual string DumpToString() { }
        public virtual string GetDisplayNameText() { }
        public JetBrains.ProjectModel.IProjectFile GetInitialProjectFile() { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ProjectModel.IProjectFile GetProjectFile() { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ReSharper.Psi.Resolve.IReference[] GetReferences() { }
        protected virtual bool IsTextRangeValid(int length, int startOffset, int lineLength) { }
        public virtual bool Navigate(JetBrains.ProjectModel.ISolution solution, JetBrains.UI.PopupWindowManager.PopupWindowContextSource windowContext, bool transferFocus, JetBrains.IDE.TabOptions tabOptions = 2) { }
        protected class TextualMergeLine
        {
            public TextualMergeLine(JetBrains.ProjectModel.IProjectFile projectFile, JetBrains.Util.dataStructures.TypedIntrinsics.Int32<JetBrains.DocumentModel.DocLine> line) { }
            public override bool Equals(object obj) { }
            public bool Equals(JetBrains.ReSharper.Feature.Services.Navigation.Occurences.RangeOccurence.TextualMergeLine obj) { }
            public override int GetHashCode() { }
        }
    }
    public class SubstitutionOccurance : JetBrains.ReSharper.Feature.Services.Navigation.Occurences.RangeOccurence
    {
        public SubstitutionOccurance([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IType substitutionType, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public override object MergeKey { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ReSharper.Psi.IType SubstitutionType { get; }
        public interface IFactory
        {
            [JetBrains.Annotations.CanBeNullAttribute()]
            JetBrains.ReSharper.Feature.Services.Navigation.Occurences.SubstitutionOccurance Create([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Resolve.IReference reference, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IType substitutionType, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.ITypeParameter typeParameter);
        }
    }
}
namespace JetBrains.ReSharper.Feature.Services.Navigation.Resources
{
    
    public sealed class ServicesNavigationThemedIcons
    {
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Feature.Services.Navigation;component/resources/ServicesNavig" +
            "ationThemedIcons/ThemedIcons.ServicesNavigation.Generated.Xaml", 6, "FinalRec")]
        public sealed class FinalRec : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Feature.Services.Navigation;component/resources/ServicesNavig" +
            "ationThemedIcons/ThemedIcons.ServicesNavigation.Generated.Xaml", 9, "UnitTestBaseMethodCall")]
        public sealed class UnitTestBaseMethodCall : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Feature.Services.Navigation;component/resources/ServicesNavig" +
            "ationThemedIcons/ThemedIcons.ServicesNavigation.Generated.Xaml", 5, "UnitTestInterfaceQualification")]
        public sealed class UnitTestInterfaceQualification : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Feature.Services.Navigation;component/resources/ServicesNavig" +
            "ationThemedIcons/ThemedIcons.ServicesNavigation.Generated.Xaml", 2, "UnitTestInvocationUsage")]
        public sealed class UnitTestInvocationUsage : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Feature.Services.Navigation;component/resources/ServicesNavig" +
            "ationThemedIcons/ThemedIcons.ServicesNavigation.Generated.Xaml", 7, "UnitTestReadUsage")]
        public sealed class UnitTestReadUsage : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Feature.Services.Navigation;component/resources/ServicesNavig" +
            "ationThemedIcons/ThemedIcons.ServicesNavigation.Generated.Xaml", 0, "UnitTestReadWriteUsage")]
        public sealed class UnitTestReadWriteUsage : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Feature.Services.Navigation;component/resources/ServicesNavig" +
            "ationThemedIcons/ThemedIcons.ServicesNavigation.Generated.Xaml", 1, "UnitTestWriteUsage")]
        public sealed class UnitTestWriteUsage : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Feature.Services.Navigation;component/resources/ServicesNavig" +
            "ationThemedIcons/ThemedIcons.ServicesNavigation.Generated.Xaml", 8, "UsageBase")]
        public sealed class UsageBase : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Feature.Services.Navigation;component/resources/ServicesNavig" +
            "ationThemedIcons/ThemedIcons.ServicesNavigation.Generated.Xaml", 3, "UsageInterface")]
        public sealed class UsageInterface : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Feature.Services.Navigation;component/resources/ServicesNavig" +
            "ationThemedIcons/ThemedIcons.ServicesNavigation.Generated.Xaml", 4, "UsageTest")]
        public sealed class UsageTest : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
    }
}
namespace JetBrains.ReSharper.Feature.Services.Occurences
{
    
    public class AssemblyInfoOccurrence : JetBrains.ReSharper.Feature.Services.Search.IOccurence
    {
        public AssemblyInfoOccurrence([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.Model2.Assemblies.Interfaces.IAssembly assembly, JetBrains.ReSharper.Psi.IClrDeclaredElement target = null, int index = -1) { }
        public int Index { get; }
        public bool IsValid { get; }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Feature.Services.Search.IOccurence> MergedItems { get; }
        public object MergeKey { get; }
        public JetBrains.ReSharper.Psi.DeclaredElementEnvoy<JetBrains.ReSharper.Psi.INamespace> Namespace { get; }
        public JetBrains.ReSharper.Feature.Services.Search.OccurenceType OccurenceType { get; }
        public JetBrains.ReSharper.Feature.Services.Occurences.OccurencePresentationOptions PresentationOptions { get; set; }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ProjectModel.ProjectModelElementEnvoy ProjectModelElementEnvoy { get; }
        public JetBrains.ReSharper.Psi.DeclaredElementEnvoy<JetBrains.ReSharper.Psi.IClrDeclaredElement> TargetEnvoy { get; }
        public JetBrains.Util.TextRange TextRange { get; }
        public JetBrains.ReSharper.Psi.DeclaredElementEnvoy<JetBrains.ReSharper.Psi.ITypeElement> TypeElement { get; }
        public JetBrains.ReSharper.Psi.DeclaredElementEnvoy<JetBrains.ReSharper.Psi.ITypeMember> TypeMember { get; }
        public string DumpToString() { }
        protected bool Equals(JetBrains.ReSharper.Feature.Services.Occurences.AssemblyInfoOccurrence other) { }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
        public bool Navigate(JetBrains.ProjectModel.ISolution solution, JetBrains.UI.PopupWindowManager.PopupWindowContextSource windowContext, bool transferFocus, JetBrains.IDE.TabOptions tabOptions) { }
        public override string ToString() { }
    }
    public class ChainedCodeModelOccurence : JetBrains.ReSharper.Feature.Services.Occurences.DeclaredElementOccurence
    {
        public ChainedCodeModelOccurence(JetBrains.ReSharper.Psi.IDeclaredElement element, JetBrains.ReSharper.Feature.Services.Goto.MatchingInfo matchingInfo, JetBrains.ReSharper.Feature.Services.Occurences.OccurencePresentationOptions options) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ReSharper.Feature.Services.Goto.MatchingInfo MatchingInfo { get; }
    }
    public class ChainedProjectModelOccurence : JetBrains.ReSharper.Feature.Services.Occurences.ProjectItemOccurence
    {
        public ChainedProjectModelOccurence(JetBrains.ProjectModel.IProjectItem item, JetBrains.ReSharper.Feature.Services.Goto.MatchingInfo info) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ReSharper.Feature.Services.Goto.MatchingInfo MatchingInfo { get; }
    }
    public class ChainedStyleProvider : JetBrains.ReSharper.Feature.Services.Occurences.IOccurenceStyleProvider
    {
        public ChainedStyleProvider(JetBrains.ReSharper.Feature.Services.Occurences.PreferLocationStyle locationStyle) { }
        public bool DisplayContainingElement { get; }
        public JetBrains.ReSharper.Feature.Services.Occurences.PreferLocationStyle LocationStyle { get; }
    }
    public class CommonStyleProvider : JetBrains.ReSharper.Feature.Services.Occurences.IOccurenceStyleProvider
    {
        public CommonStyleProvider(JetBrains.ReSharper.Feature.Services.Occurences.PreferLocationStyle locationStyle) { }
        public bool DisplayContainingElement { get; }
        public JetBrains.ReSharper.Feature.Services.Occurences.PreferLocationStyle LocationStyle { get; }
    }
    public class CompiledElementOccurence : JetBrains.ReSharper.Feature.Services.Occurences.DeclaredElementOccurence
    {
        public CompiledElementOccurence(JetBrains.ReSharper.Psi.ICompiledElement element, JetBrains.ReSharper.Feature.Services.Occurences.OccurencePresentationOptions occurencePresentationOptions, JetBrains.ReSharper.Psi.ICompiledElement searchTarget = null, int index = 0, bool useFocusedTextControl = False) { }
        public int Index { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Psi.IDeclaredElement SearchTarget { get; }
        public bool UseFocusedTextControl { get; }
        public override string DumpToString() { }
        public override bool Navigate(JetBrains.ProjectModel.ISolution solution, JetBrains.UI.PopupWindowManager.PopupWindowContextSource windowContext, bool transferFocus, JetBrains.IDE.TabOptions tabOptions = 2) { }
    }
    public enum ContainerDisplayStyle
    {
        Default = 0,
        NoContainer = 1,
        File = 2,
        Namespace = 3,
        ContainingType = 4,
    }
    public enum ContextStyle
    {
        Default = 0,
        RecentFile = 1,
        GotoRecentEdit = 2,
        Instant = 3,
    }
    public class DeclaredElementOccurence : JetBrains.CommonControls.ICachedPresentation, JetBrains.ReSharper.Feature.Services.Search.IOccurence
    {
        public DeclaredElementOccurence([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IDeclaredElement element, JetBrains.ReSharper.Feature.Services.Search.OccurenceType occurenceKind = 0) { }
        public DeclaredElementOccurence([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IDeclaredElement element, JetBrains.ReSharper.Feature.Services.Occurences.OccurencePresentationOptions options, JetBrains.ReSharper.Feature.Services.Search.OccurenceType occurenceKind = 0) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ReSharper.Psi.DeclaredElementEnvoy<JetBrains.ReSharper.Psi.IDeclaredElement> DisplayElement { get; }
        public bool IsValid { get; }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Feature.Services.Search.IOccurence> MergedItems { get; }
        public object MergeKey { get; }
        public JetBrains.ReSharper.Psi.DeclaredElementEnvoy<JetBrains.ReSharper.Psi.INamespace> Namespace { get; }
        public JetBrains.ReSharper.Psi.DeclaredElementEnvoy<JetBrains.ReSharper.Psi.IDeclaredElement> OccurenceElement { get; }
        public JetBrains.ReSharper.Feature.Services.Search.OccurenceType OccurenceType { get; }
        public JetBrains.ReSharper.Feature.Services.Occurences.OccurencePresentationOptions PresentationOptions { get; set; }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ProjectModel.ProjectModelElementEnvoy ProjectModelElementEnvoy { get; }
        public JetBrains.ReSharper.Psi.Search.SearchTargetRole SearchTargetRole { get; set; }
        public virtual JetBrains.Util.TextRange TextRange { get; }
        public virtual JetBrains.ReSharper.Psi.DeclaredElementEnvoy<JetBrains.ReSharper.Psi.ITypeElement> TypeElement { get; }
        public JetBrains.ReSharper.Psi.DeclaredElementEnvoy<JetBrains.ReSharper.Psi.ITypeMember> TypeMember { get; }
        public virtual string DumpToString() { }
        public virtual bool Navigate(JetBrains.ProjectModel.ISolution solution, JetBrains.UI.PopupWindowManager.PopupWindowContextSource windowContext, bool transferFocus, JetBrains.IDE.TabOptions tabOptions = 2) { }
        public void ResetCache() { }
    }
    [JetBrains.ReSharper.Feature.Services.Occurences.OccurenceProviderAttribute(Priority=1)]
    public class DeclaredElementOccurenceProvider : JetBrains.ReSharper.Feature.Services.Occurences.IOccurenceProvider
    {
        public JetBrains.ReSharper.Feature.Services.Search.IOccurence MakeOccurence(JetBrains.ReSharper.Psi.Search.FindResult result) { }
    }
    public class DecompiledFileNavigationData
    {
        public DecompiledFileNavigationData(JetBrains.Util.FileSystemPath fileSystemPath, JetBrains.Util.TextRange textRange) { }
        public JetBrains.Util.FileSystemPath FileSystemPath { get; }
        public JetBrains.Util.TextRange TextRange { get; }
    }
    public class DecompiledFileOccurence : JetBrains.ReSharper.Feature.Services.Search.IOccurence
    {
        public DecompiledFileOccurence(JetBrains.Util.FileSystemPath filePath, JetBrains.Util.TextRange textRange, JetBrains.UI.PopupMenu.IMenuItemDescriptor cachedPresentation) { }
        public JetBrains.UI.PopupMenu.IMenuItemDescriptor CachedPresentation { get; }
        public bool IsValid { get; }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Feature.Services.Search.IOccurence> MergedItems { get; }
        public object MergeKey { get; }
        public JetBrains.ReSharper.Psi.DeclaredElementEnvoy<JetBrains.ReSharper.Psi.INamespace> Namespace { get; }
        public JetBrains.ReSharper.Feature.Services.Search.OccurenceType OccurenceType { get; }
        public JetBrains.ReSharper.Feature.Services.Occurences.OccurencePresentationOptions PresentationOptions { get; set; }
        public JetBrains.ProjectModel.ProjectModelElementEnvoy ProjectModelElementEnvoy { get; }
        public JetBrains.Util.TextRange TextRange { get; }
        public JetBrains.ReSharper.Psi.DeclaredElementEnvoy<JetBrains.ReSharper.Psi.ITypeElement> TypeElement { get; }
        public JetBrains.ReSharper.Psi.DeclaredElementEnvoy<JetBrains.ReSharper.Psi.ITypeMember> TypeMember { get; }
        public string DumpToString() { }
        public bool Navigate(JetBrains.ProjectModel.ISolution solution, JetBrains.UI.PopupWindowManager.PopupWindowContextSource windowContext, bool transferFocus, JetBrains.IDE.TabOptions tabOptions) { }
    }
    public class FileMemberAspectOccurence : JetBrains.ReSharper.Feature.Services.Navigation.Occurences.RangeOccurence
    {
        public FileMemberAspectOccurence(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Feature.Services.CodeStructure.IGotoFileMemberAspect aspect, JetBrains.UI.TreeView.PresentationState state, JetBrains.ReSharper.Feature.Services.Occurences.OccurencePresentationOptions occurencePresentationOptions) { }
        public JetBrains.ReSharper.Feature.Services.CodeStructure.IGotoFileMemberAspect Aspect { get; }
        public override object MergeKey { get; }
        public JetBrains.UI.TreeView.PresentationState PresentationState { get; }
    }
    public enum GlobalLocationStyle
    {
        Default = 0,
        None = 1,
        File = 2,
        RelatedFile = 3,
        Type = 4,
    }
    public enum IconDisplayStyle
    {
        Default = 0,
        NoIcon = 1,
        OccurenceKind = 2,
        OccurenceEntityType = 3,
        File = 4,
    }
    public interface IOccurenceProvider
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Feature.Services.Search.IOccurence MakeOccurence([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Search.FindResult findResult);
    }
    public interface IOccurenceStyleProvider
    {
        bool DisplayContainingElement { get; }
        JetBrains.ReSharper.Feature.Services.Occurences.PreferLocationStyle LocationStyle { get; }
    }
    public class ModuleReferenceOccurence : JetBrains.ReSharper.Feature.Services.Search.IOccurence
    {
        public ModuleReferenceOccurence([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ProjectModel.IProjectToModuleReference reference, bool isNested = False) { }
        public ModuleReferenceOccurence(JetBrains.ProjectModel.IProjectToModuleReference reference, JetBrains.ReSharper.Feature.Services.Occurences.OccurencePresentationOptions presentationOptions, bool isNested) { }
        public bool IsNested { get; }
        public bool IsValid { get; }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Feature.Services.Search.IOccurence> MergedItems { get; }
        public virtual object MergeKey { get; }
        public JetBrains.ReSharper.Psi.DeclaredElementEnvoy<JetBrains.ReSharper.Psi.INamespace> Namespace { get; }
        public JetBrains.ReSharper.Feature.Services.Search.OccurenceType OccurenceType { get; }
        public JetBrains.ProjectModel.IModule Owner { get; }
        public JetBrains.ReSharper.Feature.Services.Occurences.OccurencePresentationOptions PresentationOptions { get; set; }
        public JetBrains.ProjectModel.ProjectModelElementEnvoy ProjectModelElementEnvoy { get; }
        public JetBrains.ProjectModel.IProjectToModuleReference Reference { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ProjectModel.IModule ReferencedModule { get; }
        public JetBrains.Util.TextRange TextRange { get; }
        public JetBrains.ReSharper.Psi.DeclaredElementEnvoy<JetBrains.ReSharper.Psi.ITypeElement> TypeElement { get; }
        public JetBrains.ReSharper.Psi.DeclaredElementEnvoy<JetBrains.ReSharper.Psi.ITypeMember> TypeMember { get; }
        public string DumpToString() { }
        protected bool Equals(JetBrains.ReSharper.Feature.Services.Occurences.ModuleReferenceOccurence other) { }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
        public bool Navigate(JetBrains.ProjectModel.ISolution solution, JetBrains.UI.PopupWindowManager.PopupWindowContextSource windowContext, bool transferFocus, JetBrains.IDE.TabOptions tabOptions = 2) { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class OccurenceFactory
    {
        public OccurenceFactory(JetBrains.DataFlow.Lifetime lifetime, JetBrains.DataFlow.IViewable<JetBrains.ReSharper.Feature.Services.Occurences.IOccurenceProvider> providers) { }
        public static JetBrains.ReSharper.Feature.Services.Occurences.OccurenceFactory Instance { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Feature.Services.Search.IOccurence MakeOccurence([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Search.FindResult result) { }
    }
    public struct OccurencePresentationOptions
    {
        public JetBrains.ReSharper.Feature.Services.Occurences.ContainerDisplayStyle ContainerStyle;
        public JetBrains.ReSharper.Feature.Services.Occurences.ContextStyle ContextStyle;
        public static JetBrains.ReSharper.Feature.Services.Occurences.OccurencePresentationOptions DefaultOptions;
        public JetBrains.ReSharper.Feature.Services.Occurences.IconDisplayStyle IconDisplayStyle;
        public JetBrains.ReSharper.Feature.Services.Occurences.GlobalLocationStyle LocationStyle;
        public JetBrains.ReSharper.Feature.Services.Occurences.TextDisplayStyle TextDisplayStyle;
        public OccurencePresentationOptions(JetBrains.ReSharper.Feature.Services.Occurences.IconDisplayStyle iconStyle = 0, JetBrains.ReSharper.Feature.Services.Occurences.TextDisplayStyle textStyle = 0, JetBrains.ReSharper.Feature.Services.Occurences.ContainerDisplayStyle containerStyle = 0, JetBrains.ReSharper.Feature.Services.Occurences.GlobalLocationStyle glyphStyle = 0, JetBrains.ReSharper.Feature.Services.Occurences.ContextStyle contextStyle = 0) { }
        public bool Equals(JetBrains.ReSharper.Feature.Services.Occurences.OccurencePresentationOptions other) { }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
        public override string ToString() { }
    }
    [JetBrains.Annotations.BaseTypeRequiredAttribute(typeof(JetBrains.ReSharper.Feature.Services.Occurences.IOccurenceProvider))]
    [JetBrains.Annotations.MeansImplicitUseAttribute()]
    [System.AttributeUsageAttribute(System.AttributeTargets.Class | System.AttributeTargets.All, AllowMultiple=false)]
    public class OccurenceProviderAttribute : JetBrains.Application.ShellComponentAttribute
    {
        public int Priority { get; set; }
    }
    public enum PreferLocationStyle
    {
        None = 0,
        File = 1,
        Type = 2,
    }
    public class ProjectItemOccurence : JetBrains.ReSharper.Feature.Services.Search.IOccurence
    {
        public ProjectItemOccurence(JetBrains.ProjectModel.IProjectItem projectItem, JetBrains.ReSharper.Feature.Services.Occurences.OccurencePresentationOptions options) { }
        public ProjectItemOccurence(JetBrains.ProjectModel.IProjectItem item) { }
        public bool IsValid { get; }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Feature.Services.Search.IOccurence> MergedItems { get; }
        public object MergeKey { get; }
        public JetBrains.ReSharper.Psi.DeclaredElementEnvoy<JetBrains.ReSharper.Psi.INamespace> Namespace { get; }
        public JetBrains.ReSharper.Feature.Services.Search.OccurenceType OccurenceType { get; }
        public JetBrains.ReSharper.Feature.Services.Occurences.OccurencePresentationOptions PresentationOptions { get; set; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ProjectModel.IProjectItem ProjectItem { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ProjectModel.ProjectModelElementEnvoy ProjectModelElementEnvoy { get; }
        public JetBrains.Util.TextRange TextRange { get; }
        public JetBrains.ReSharper.Psi.DeclaredElementEnvoy<JetBrains.ReSharper.Psi.ITypeElement> TypeElement { get; }
        public JetBrains.ReSharper.Psi.DeclaredElementEnvoy<JetBrains.ReSharper.Psi.ITypeMember> TypeMember { get; }
        public string DumpToString() { }
        public bool Equals(JetBrains.ReSharper.Feature.Services.Occurences.ProjectItemOccurence other) { }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
        public bool Navigate(JetBrains.ProjectModel.ISolution solution, JetBrains.UI.PopupWindowManager.PopupWindowContextSource windowContext, bool transferFocus, JetBrains.IDE.TabOptions tabOptions) { }
    }
    public class ReferenceOccurence : JetBrains.ReSharper.Feature.Services.Navigation.Occurences.RangeOccurence, JetBrains.ReSharper.Feature.Services.Search.IOccurenceKindOwner
    {
        protected System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.Occurences.OccurenceKindProviders.OccurenceKind> OccurenceKinds;
        protected readonly JetBrains.ReSharper.Psi.DeclaredElementEnvoy<JetBrains.ReSharper.Psi.IDeclaredElement> TargetEnvoy;
        public ReferenceOccurence(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.IDeclaredElement target, JetBrains.ReSharper.Feature.Services.Search.OccurenceType occurenceType, JetBrains.ProjectModel.IProjectFile projectFile = null) { }
        public ReferenceOccurence(JetBrains.ReSharper.Psi.Tree.ITreeNode treeNode, JetBrains.ReSharper.Feature.Services.Search.OccurenceType occurenceType) { }
        protected ReferenceOccurence(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.IDeclaredElement target, JetBrains.ReSharper.Feature.Services.Search.OccurenceType occurenceType, JetBrains.ProjectModel.IProjectFile projectFile = null, object o = null) { }
        public JetBrains.ReSharper.Psi.ReferenceAccessType AccessType { get; }
        public System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.Occurences.OccurenceKindProviders.OccurenceKind> Kinds { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Psi.Resolve.IReference PrimaryReference { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Psi.IDeclaredElement Target { get; }
        public override string DumpToString() { }
    }
    public enum TextDisplayStyle
    {
        Default = 0,
        NoText = 1,
        ContainingFile = 2,
        ContainingType = 3,
        IdentifierAndContext = 4,
        ChainedPME = 5,
        ChainedCME = 6,
        ChainedCMEWithSignature = 7,
        Identifier = 8,
    }
}
namespace JetBrains.ReSharper.Feature.Services.Occurences.OccurenceKindProviders
{
    
    public interface IOccurenceKindProvider
    {
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.Occurences.OccurenceKindProviders.OccurenceKind> GetAllPossibleOccurenceKinds();
        [JetBrains.Annotations.CanBeNullAttribute()]
        System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.Occurences.OccurenceKindProviders.OccurenceKind> GetOccurenceKinds(JetBrains.ReSharper.Feature.Services.Search.IOccurence occurence);
    }
    public sealed class OccurenceKind : JetBrains.Util.EnumPattern
    {
        public static readonly JetBrains.ReSharper.Feature.Services.Occurences.OccurenceKindProviders.OccurenceKind Attribute;
        public static readonly JetBrains.ReSharper.Feature.Services.Occurences.OccurenceKindProviders.OccurenceKind BaseMethodCall;
        public static readonly JetBrains.ReSharper.Feature.Services.Occurences.OccurenceKindProviders.OccurenceKind CompilerRelatedUsage;
        public static readonly JetBrains.ReSharper.Feature.Services.Occurences.OccurenceKindProviders.OccurenceKind DocumentationReference;
        public static readonly JetBrains.ReSharper.Feature.Services.Occurences.OccurenceKindProviders.OccurenceKind InterfaceQualification;
        public static readonly JetBrains.ReSharper.Feature.Services.Occurences.OccurenceKindProviders.OccurenceKind Invocation;
        public static readonly JetBrains.ReSharper.Feature.Services.Occurences.OccurenceKindProviders.OccurenceKind Other;
        public static readonly JetBrains.ReSharper.Feature.Services.Occurences.OccurenceKindProviders.OccurenceKind Read;
        public static readonly JetBrains.ReSharper.Feature.Services.Occurences.OccurenceKindProviders.OccurenceKind ReadWrite;
        public static readonly JetBrains.ReSharper.Feature.Services.Occurences.OccurenceKindProviders.OccurenceKind UnitTest;
        public static readonly JetBrains.ReSharper.Feature.Services.Occurences.OccurenceKindProviders.OccurenceKind VBHandlesClause;
        public static readonly JetBrains.ReSharper.Feature.Services.Occurences.OccurenceKindProviders.OccurenceKind Write;
        public OccurenceKind([JetBrains.Annotations.NotNullAttribute()] string name, bool isPrimary) { }
        public bool IsPrimary { get; }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class OccurenceKindManager
    {
        public OccurenceKindManager(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.Occurences.OccurenceKindProviders.IOccurenceKindProvider> providers) { }
        public System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.Occurences.OccurenceKindProviders.OccurenceKind> GetAllOccurenceKinds() { }
        public static JetBrains.ReSharper.Feature.Services.Occurences.OccurenceKindProviders.OccurenceKindManager GetInstance(JetBrains.ProjectModel.ISolution solution) { }
        public System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.Occurences.OccurenceKindProviders.OccurenceKind> GetOccurenceKinds(JetBrains.ReSharper.Feature.Services.Search.IOccurence occurence) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class ReferenceOccurenceKindProvider : JetBrains.ReSharper.Feature.Services.Occurences.OccurenceKindProviders.IOccurenceKindProvider
    {
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.Occurences.OccurenceKindProviders.OccurenceKind> GetAllPossibleOccurenceKinds() { }
        [JetBrains.Annotations.NotNullAttribute()]
        public System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.Occurences.OccurenceKindProviders.OccurenceKind> GetOccurenceKinds(JetBrains.ReSharper.Feature.Services.Search.IOccurence occurence) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.Occurences.Presentation
{
    
    public class static DeclaredElementMenuItemFormatter
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public static readonly JetBrains.ReSharper.Psi.DeclaredElementPresenterStyle ContainerPresentationStyle;
        public static void Format([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IDeclaredElement element, JetBrains.UI.PopupMenu.IMenuItemDescriptor descriptor, JetBrains.ReSharper.Feature.Services.Occurences.OccurencePresentationOptions options, bool displayShortcut = True) { }
        public static JetBrains.UI.PopupMenu.IMenuItemDescriptor Format(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
        public static JetBrains.UI.RichText.RichText FormatText(JetBrains.ReSharper.Psi.IDeclaredElement element, JetBrains.ReSharper.Psi.PsiLanguageType language, out JetBrains.ReSharper.Psi.DeclaredElementPresenterMarking marking) { }
    }
    public interface IOccurencePresenter
    {
        bool IsApplicable(JetBrains.ReSharper.Feature.Services.Search.IOccurence occurence);
        bool Present(JetBrains.UI.PopupMenu.IMenuItemDescriptor descriptor, JetBrains.ReSharper.Feature.Services.Search.IOccurence occurence, JetBrains.ReSharper.Feature.Services.Occurences.OccurencePresentationOptions occurencePresentationOptions);
    }
    public class static OccurencePresentationUtil
    {
        public static readonly string TextContainerDelimiter;
        public static void AppendRelatedFile(JetBrains.UI.PopupMenu.IMenuItemDescriptor descriptor, string relatedFileOrClassName) { }
        public static JetBrains.UI.RichText.RichText GetCroppedRichText(JetBrains.ReSharper.Feature.Services.Navigation.Occurences.RangeOccurence value, bool showCoords) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static string GetDeclaredElementText(JetBrains.ReSharper.Psi.DeclaredElementEnvoy<JetBrains.ReSharper.Psi.ITypeMember> typeMemberEnvoy, JetBrains.ReSharper.Psi.DeclaredElementEnvoy<JetBrains.ReSharper.Psi.ITypeElement> typeElementEnvoy, out JetBrains.Util.TextRange suffixRange) { }
        public static string GetElementText(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
        public static JetBrains.CommonControls.PresentableItemImage GetIcon(JetBrains.ReSharper.Feature.Services.Navigation.Occurences.RangeOccurence rangeOccurence, JetBrains.ReSharper.Feature.Services.Occurences.OccurencePresentationOptions options, JetBrains.ProjectModel.ISolution solution) { }
        public static string GetLocationText(JetBrains.ReSharper.Feature.Services.Navigation.Occurences.RangeOccurence occurence, JetBrains.ReSharper.Feature.Services.Occurences.OccurencePresentationOptions options) { }
        public static JetBrains.CommonControls.PresentableItemImage GetOccurenceKindImage(this JetBrains.ReSharper.Feature.Services.Occurences.OccurenceKindProviders.OccurenceKind occurenceKind) { }
        public static string GetPrimaryText(JetBrains.ReSharper.Feature.Services.Occurences.DeclaredElementOccurence occurence) { }
        public static string GetRangeOccurenceDisplayText(JetBrains.ReSharper.Feature.Services.Navigation.Occurences.RangeOccurence occurence, System.Nullable<JetBrains.ReSharper.Feature.Services.Occurences.OccurencePresentationOptions> featureOptions, out JetBrains.Util.TextRange suffixRange) { }
        public static JetBrains.UI.RichText.RichText GetRichText(JetBrains.ReSharper.Feature.Services.Navigation.Occurences.RangeOccurence value, bool showCoords) { }
        public static JetBrains.CommonControls.PresentableItemImage GetUnitTestUsageIcon(System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.Occurences.OccurenceKindProviders.OccurenceKind> kinds) { }
        public static bool IsSynthetic(JetBrains.ReSharper.Feature.Services.Navigation.Occurences.RangeOccurence occurence) { }
        public static void MarkInvalid(JetBrains.UI.RichText.RichText richText) { }
        public static JetBrains.ReSharper.Feature.Services.Occurences.OccurenceKindProviders.OccurenceKind MergeAccessType(JetBrains.ReSharper.Feature.Services.Occurences.OccurenceKindProviders.OccurenceKind t1, JetBrains.ReSharper.Feature.Services.Occurences.OccurenceKindProviders.OccurenceKind t2) { }
        public static void PresentChainedProjectModelOccurence(JetBrains.UI.PopupMenu.IMenuItemDescriptor descriptor, JetBrains.ProjectModel.IProjectItem projectItem, JetBrains.ReSharper.Feature.Services.Goto.MatchingInfo matchingInfo) { }
        public static void PresentContainingType(JetBrains.UI.PopupMenu.IMenuItemDescriptor descriptor, JetBrains.ReSharper.Feature.Services.Search.IOccurence occurence) { }
    }
    [JetBrains.Annotations.BaseTypeRequiredAttribute(typeof(JetBrains.ReSharper.Feature.Services.Occurences.Presentation.IOccurencePresenter))]
    [JetBrains.Annotations.MeansImplicitUseAttribute()]
    [System.AttributeUsageAttribute(System.AttributeTargets.Class | System.AttributeTargets.All)]
    public class OccurencePresenterAttribute : JetBrains.ReSharper.Psi.ShellFeaturePartAttribute
    {
        public double Priority { get; set; }
    }
}
namespace JetBrains.ReSharper.Feature.Services.Occurences.Presentation.Presenters
{
    
    [JetBrains.ReSharper.Feature.Services.Occurences.Presentation.OccurencePresenterAttribute()]
    public class ChainedCodeModelOccurencePresenter : JetBrains.ReSharper.Feature.Services.Occurences.Presentation.Presenters.DeclaredElementOccurencePresenter
    {
        protected override void DisplayCustomContainerText(JetBrains.UI.PopupMenu.IMenuItemDescriptor descriptor, JetBrains.ReSharper.Feature.Services.Search.IOccurence occurence, JetBrains.ReSharper.Feature.Services.Occurences.OccurencePresentationOptions options, JetBrains.ReSharper.Psi.IDeclaredElement element) { }
        protected override void DisplayMainText(JetBrains.UI.PopupMenu.IMenuItemDescriptor descriptor, JetBrains.ReSharper.Feature.Services.Search.IOccurence declaredElementOccurence, JetBrains.ReSharper.Feature.Services.Occurences.OccurencePresentationOptions options, JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
        public override bool IsApplicable(JetBrains.ReSharper.Feature.Services.Search.IOccurence occurence) { }
    }
    [JetBrains.ReSharper.Feature.Services.Occurences.Presentation.OccurencePresenterAttribute()]
    public class ChainedProjectModelOccurencePresenter : JetBrains.ReSharper.Feature.Services.Occurences.Presentation.Presenters.ProjectItemOccurencePresenter
    {
        public override bool IsApplicable(JetBrains.ReSharper.Feature.Services.Search.IOccurence occurence) { }
        protected override void PresentMainText(JetBrains.UI.PopupMenu.IMenuItemDescriptor descriptor, JetBrains.ReSharper.Feature.Services.Occurences.OccurencePresentationOptions options, JetBrains.ReSharper.Feature.Services.Occurences.ProjectItemOccurence projectItemOccurence, JetBrains.ProjectModel.IProjectItem projectItem) { }
    }
    [JetBrains.ReSharper.Feature.Services.Occurences.Presentation.OccurencePresenterAttribute()]
    public class ChainedRangeOccurencePresenter : JetBrains.ReSharper.Feature.Services.Occurences.Presentation.Presenters.RangeOccurencePresenter
    {
        public override bool IsApplicable(JetBrains.ReSharper.Feature.Services.Search.IOccurence occurence) { }
        public override bool Present(JetBrains.UI.PopupMenu.IMenuItemDescriptor descriptor, JetBrains.ReSharper.Feature.Services.Search.IOccurence occurence, JetBrains.ReSharper.Feature.Services.Occurences.OccurencePresentationOptions occurencePresentationOptions) { }
    }
    [JetBrains.ReSharper.Feature.Services.Occurences.Presentation.OccurencePresenterAttribute(Priority=4D)]
    public class DeclaredElementOccurencePresenter : JetBrains.ReSharper.Feature.Services.Occurences.Presentation.IOccurencePresenter
    {
        protected virtual void DisplayCustomContainerText(JetBrains.UI.PopupMenu.IMenuItemDescriptor descriptor, JetBrains.ReSharper.Feature.Services.Search.IOccurence occurence, JetBrains.ReSharper.Feature.Services.Occurences.OccurencePresentationOptions options, JetBrains.ReSharper.Psi.IDeclaredElement element) { }
        protected virtual void DisplayLocationAndGlyph(JetBrains.UI.PopupMenu.IMenuItemDescriptor descriptor, JetBrains.ReSharper.Feature.Services.Occurences.OccurencePresentationOptions options, JetBrains.ReSharper.Psi.IDeclaredElement element, JetBrains.ReSharper.Feature.Services.Occurences.DeclaredElementOccurence declaredElementOccurence) { }
        protected virtual void DisplayMainText(JetBrains.UI.PopupMenu.IMenuItemDescriptor descriptor, JetBrains.ReSharper.Feature.Services.Search.IOccurence occurence, JetBrains.ReSharper.Feature.Services.Occurences.OccurencePresentationOptions options, JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
        protected virtual void DisplayRelatedFile(JetBrains.UI.PopupMenu.IMenuItemDescriptor descriptor, JetBrains.ReSharper.Feature.Services.Occurences.OccurencePresentationOptions options, JetBrains.ReSharper.Feature.Services.Occurences.DeclaredElementOccurence declaredElementOccurence) { }
        public virtual bool IsApplicable(JetBrains.ReSharper.Feature.Services.Search.IOccurence occurence) { }
        public bool Present(JetBrains.UI.PopupMenu.IMenuItemDescriptor descriptor, JetBrains.ReSharper.Feature.Services.Search.IOccurence occurence, JetBrains.ReSharper.Feature.Services.Occurences.OccurencePresentationOptions options) { }
    }
    [JetBrains.ReSharper.Feature.Services.Occurences.Presentation.OccurencePresenterAttribute()]
    public class DecompiledFileOccurencePresenter : JetBrains.ReSharper.Feature.Services.Occurences.Presentation.IOccurencePresenter
    {
        public bool IsApplicable(JetBrains.ReSharper.Feature.Services.Search.IOccurence occurence) { }
        public bool Present(JetBrains.UI.PopupMenu.IMenuItemDescriptor descriptor, JetBrains.ReSharper.Feature.Services.Search.IOccurence occurence, JetBrains.ReSharper.Feature.Services.Occurences.OccurencePresentationOptions occurencePresentationOptions) { }
    }
    [JetBrains.ReSharper.Feature.Services.Occurences.Presentation.OccurencePresenterAttribute(Priority=5D)]
    public class FileMemberAspectOccurencePresenter : JetBrains.ReSharper.Feature.Services.Occurences.Presentation.IOccurencePresenter
    {
        public bool IsApplicable(JetBrains.ReSharper.Feature.Services.Search.IOccurence occurence) { }
        public bool Present(JetBrains.UI.PopupMenu.IMenuItemDescriptor descriptor, JetBrains.ReSharper.Feature.Services.Search.IOccurence occurence, JetBrains.ReSharper.Feature.Services.Occurences.OccurencePresentationOptions options) { }
    }
    [JetBrains.ReSharper.Feature.Services.Occurences.Presentation.OccurencePresenterAttribute()]
    public class ProjectItemOccurencePresenter : JetBrains.ReSharper.Feature.Services.Occurences.Presentation.IOccurencePresenter
    {
        public virtual bool IsApplicable(JetBrains.ReSharper.Feature.Services.Search.IOccurence occurence) { }
        public bool Present(JetBrains.UI.PopupMenu.IMenuItemDescriptor descriptor, JetBrains.ReSharper.Feature.Services.Search.IOccurence occurence, JetBrains.ReSharper.Feature.Services.Occurences.OccurencePresentationOptions options) { }
        protected virtual void PresentLocation(JetBrains.UI.PopupMenu.IMenuItemDescriptor descriptor, JetBrains.ReSharper.Feature.Services.Occurences.OccurencePresentationOptions options, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IProjectItem projectItem) { }
        protected virtual void PresentMainText(JetBrains.UI.PopupMenu.IMenuItemDescriptor descriptor, JetBrains.ReSharper.Feature.Services.Occurences.OccurencePresentationOptions options, JetBrains.ReSharper.Feature.Services.Occurences.ProjectItemOccurence projectItemOccurence, JetBrains.ProjectModel.IProjectItem projectItem) { }
    }
    [JetBrains.ReSharper.Feature.Services.Occurences.Presentation.OccurencePresenterAttribute(Priority=0D)]
    public class RangeOccurencePresenter : JetBrains.ReSharper.Feature.Services.Occurences.Presentation.IOccurencePresenter
    {
        protected static JetBrains.UI.RichText.RichText GetContextDisplayText(JetBrains.ReSharper.Feature.Services.Occurences.OccurencePresentationOptions options, JetBrains.ReSharper.Feature.Services.Navigation.Occurences.RangeOccurence rangeOccurence) { }
        protected virtual JetBrains.UI.RichText.RichText GetDisplayText(JetBrains.ReSharper.Feature.Services.Occurences.OccurencePresentationOptions options, JetBrains.ReSharper.Feature.Services.Navigation.Occurences.RangeOccurence rangeOccurence) { }
        public virtual bool IsApplicable(JetBrains.ReSharper.Feature.Services.Search.IOccurence occurence) { }
        public virtual bool Present(JetBrains.UI.PopupMenu.IMenuItemDescriptor descriptor, JetBrains.ReSharper.Feature.Services.Search.IOccurence occurence, JetBrains.ReSharper.Feature.Services.Occurences.OccurencePresentationOptions options) { }
        protected virtual void PresentReferenceOccurenceInternal(JetBrains.ReSharper.Feature.Services.Occurences.OccurencePresentationOptions options, JetBrains.ReSharper.Feature.Services.Navigation.Occurences.RangeOccurence rangeOccurence, JetBrains.UI.PopupMenu.IMenuItemDescriptor descriptor) { }
    }
    [JetBrains.ReSharper.Feature.Services.Occurences.Presentation.OccurencePresenterAttribute(Priority=10D)]
    public class RecentEditsOccurencePresenter : JetBrains.ReSharper.Feature.Services.Occurences.Presentation.Presenters.RangeOccurencePresenter
    {
        public override bool IsApplicable(JetBrains.ReSharper.Feature.Services.Search.IOccurence occurence) { }
        public override bool Present(JetBrains.UI.PopupMenu.IMenuItemDescriptor descriptor, JetBrains.ReSharper.Feature.Services.Search.IOccurence occurence, JetBrains.ReSharper.Feature.Services.Occurences.OccurencePresentationOptions options) { }
        protected virtual void PresentLocation(JetBrains.UI.PopupMenu.IMenuItemDescriptor descriptor, JetBrains.ReSharper.Feature.Services.Occurences.OccurencePresentationOptions options, JetBrains.ProjectModel.IProjectItem projectItem) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.ReferencedCode
{
    
    public class FindResultReferencedCode : JetBrains.ReSharper.Psi.Search.FindResult
    {
        public FindResultReferencedCode(JetBrains.ReSharper.Psi.Resolve.IReference reference, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IClrDeclaredElement target, JetBrains.ReSharper.Feature.Services.ReferencedCode.ReferencedCodeKind referencedCodeKind) { }
        public FindResultReferencedCode(JetBrains.ReSharper.Psi.Resolve.IReference reference, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Modules.IPsiModule> psiModules, JetBrains.ReSharper.Feature.Services.ReferencedCode.ReferencedCodeKind referencedCodeKind) { }
        public JetBrains.ReSharper.Feature.Services.ReferencedCode.ReferencedCodeKind Kind { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Modules.IPsiModule> PsiModules { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Psi.Resolve.IReference Reference { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Psi.IClrDeclaredElement TargetElement { get; }
        public override bool Equals(object other) { }
        public override int GetHashCode() { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class HiddenAssemblyReferencesManager
    {
        public const string mscorlib = "mscorlib";
        public const string PresentationFramework = "PresentationFramework";
        public const string System = "System";
        public const string SystemWindows = "System.Windows";
        public const string SystemXml = "System.Xml";
        public HiddenAssemblyReferencesManager(JetBrains.ProjectModel.ISolution solution) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ProjectModel.IProjectToModuleReference> GetHiddenReferencedModules(JetBrains.ProjectModel.IProject project) { }
        public static JetBrains.ReSharper.Feature.Services.ReferencedCode.HiddenAssemblyReferencesManager GetInstance(JetBrains.ProjectModel.ISolution solution) { }
    }
    public interface IHiddenAssemblyReferenceProvider
    {
        System.Collections.Generic.IEnumerable<JetBrains.ProjectModel.IProjectToModuleReference> GetHiddenReferencedModules(JetBrains.ProjectModel.IProject project);
        bool IsAvailable(JetBrains.ProjectModel.IProject project);
    }
    public interface IReferencedCodeSearchHelper
    {
        System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.ReferencedCode.NamespaceImportData> GetNamespaceImportsList(JetBrains.ReSharper.Psi.Tree.IFile file);
        System.Collections.Generic.ICollection<JetBrains.Util.JetTuple<JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.ReSharper.Psi.IClrDeclaredElement>> GetUpdatedTargets(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.IClrDeclaredElement target);
        bool RemoveNamespaceImport(JetBrains.ReSharper.Psi.Tree.ITreeNode importNamespaceNode);
    }
    public interface IReferncedCodeKindHolder
    {
        JetBrains.ReSharper.Feature.Services.ReferencedCode.ReferencedCodeKind Kind { get; }
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Modules.IPsiModule> ReferencedPsiModules { get; }
    }
    public class NamespaceImportData
    {
        public NamespaceImportData(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.INamespace targetNamespace, JetBrains.ReSharper.Feature.Services.ReferencedCode.NamespaceImportKind kind) { }
        public NamespaceImportData(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.Modules.IPsiModule psiModule, JetBrains.ReSharper.Feature.Services.ReferencedCode.NamespaceImportKind kind) { }
        public JetBrains.ReSharper.Feature.Services.ReferencedCode.NamespaceImportKind ImportKind { get; }
        public JetBrains.ReSharper.Psi.Resolve.IReference Reference { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Psi.Modules.IPsiModule TargetModule { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Psi.INamespace TargetNamespace { get; }
    }
    public enum NamespaceImportKind
    {
        UsedImport = 0,
        RedundantImport = 1,
        ModuleSpecificImport = 2,
    }
    public enum ReferencedCodeKind
    {
        ExtensionMethodsRedundantImport = 0,
        RedundantNamespaceImport = 1,
        DirectUsage = 2,
        RelatedUsage = 3,
        ExtensionMethodStrongCall = 4,
    }
    public class ReferencedCodeOccurence : JetBrains.ReSharper.Feature.Services.Occurences.ReferenceOccurence, JetBrains.ReSharper.Feature.Services.ReferencedCode.IReferncedCodeKindHolder
    {
        public ReferencedCodeOccurence([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Resolve.IReference reference, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.IDeclaredElement referencedElement, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Modules.IPsiModule> psiModules, JetBrains.ReSharper.Feature.Services.ReferencedCode.ReferencedCodeKind referencedCodeKind, JetBrains.ReSharper.Feature.Services.Search.OccurenceType type = 0) { }
        public JetBrains.ReSharper.Feature.Services.ReferencedCode.ReferencedCodeKind Kind { get; }
        public override object MergeKey { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Modules.IPsiModule> ReferencedPsiModules { get; }
        public override string DumpToString() { }
        protected class TextualMergeLineAndType : JetBrains.ReSharper.Feature.Services.Navigation.Occurences.RangeOccurence.TextualMergeLine
        {
            public TextualMergeLineAndType(JetBrains.ProjectModel.IProjectFile projectFile, JetBrains.Util.dataStructures.TypedIntrinsics.Int32<JetBrains.DocumentModel.DocLine> line, JetBrains.ReSharper.Psi.ITypeElement element) { }
            public JetBrains.ReSharper.Psi.ITypeElement Element { get; }
            public override bool Equals(object obj) { }
            public override int GetHashCode() { }
        }
    }
    [JetBrains.ReSharper.Feature.Services.Occurences.OccurenceProviderAttribute(Priority=10)]
    public class ReferencedCodeOccurenceProvider : JetBrains.ReSharper.Feature.Services.Occurences.IOccurenceProvider
    {
        public JetBrains.ReSharper.Feature.Services.Search.IOccurence MakeOccurence(JetBrains.ReSharper.Psi.Search.FindResult findResult) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class ReferencedCodeSearcher
    {
        public ReferencedCodeSearcher(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.IShellLocks locks, JetBrains.ReSharper.Psi.Modules.AssemblyPsiModuleFactory assemblyPsiModuleFactory, JetBrains.Application.Env.RunsProducts.ProductConfigurations configurations) { }
        protected virtual bool IsMultiThreadingEnabled { get; }
        public void ConsumeReferencedCodeUsages<T>(System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.IPsiSourceFile> targetSourceFiles, JetBrains.ReSharper.Psi.Search.IFindResultConsumer<T> consumer, JetBrains.Application.Progress.IProgressIndicator pi, bool useRetargeting = False, bool includeRelated = True) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IPsiSourceFile> ConvertToSourceFiles(System.Collections.Generic.IEnumerable<JetBrains.ProjectModel.IProjectItem> projectItems) { }
        public static JetBrains.ReSharper.Feature.Services.ReferencedCode.ReferencedCodeSearcher GetInstance(JetBrains.ProjectModel.ISolution solution) { }
        protected virtual bool ProcessReferences<T>(System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.IPsiSourceFile> targetPsiSourceFiles, JetBrains.ReSharper.Psi.Tree.IFile file, System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Resolve.IReference> fileReferences, JetBrains.ReSharper.Psi.Search.IFindResultConsumer<T> consumer, JetBrains.Util.OneToSetMap<JetBrains.ReSharper.Psi.INamespace, JetBrains.ReSharper.Psi.IMethod> extensionMethodsCache, bool useRetargeting = False, bool includeRelated = True) { }
        public static void SelectReferences(System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.Resolve.IReference> fileReferences, System.Collections.Generic.List<JetBrains.ReSharper.Psi.Resolve.IReference> selectedReferences, JetBrains.ReSharper.Psi.Tree.IFile file) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class ReferencedCodeService
    {
        public ReferencedCodeService(JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Psi.ILanguageManager languageManager) { }
        public static JetBrains.ReSharper.Feature.Services.ReferencedCode.ReferencedCodeService GetInstance(JetBrains.ProjectModel.ISolution solution) { }
        public static System.Collections.Generic.List<T> GetRedundantImportsToRemove<T>(System.Collections.Generic.IEnumerable<T> weakUsagesMap, System.Collections.Generic.IEnumerable<JetBrains.ProjectModel.IModule> usedModules, JetBrains.ProjectModel.IProject ownerProject, System.Collections.Generic.IEqualityComparer<JetBrains.ProjectModel.IModule> modulesComparer)
            where T : JetBrains.ReSharper.Feature.Services.ReferencedCode.IReferncedCodeKindHolder { }
        public static bool IsImplicitlyReferencedModule([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ProjectModel.IModule referencedModule, JetBrains.ProjectModel.Properties.ProjectLanguage projectLanguage) { }
        public bool ModulesHaveEqualOutput(JetBrains.ProjectModel.IModule x, JetBrains.ProjectModel.IModule y) { }
        public void RemoveProjectToModuleReferences(System.Collections.Generic.IEnumerable<JetBrains.ProjectModel.IProjectToModuleReference> listToRemove, JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
        public bool RemoveRedundantUsages(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Resolve.IReference> references, JetBrains.Application.Progress.IProgressIndicator progress) { }
    }
    public class static ReferencedCodeUtil
    {
        public static System.Collections.Generic.IEnumerable<JetBrains.ProjectModel.IProjectToModuleReference> GetForwardedAssemblyReferences(this System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.Modules.IPsiModule> targetPsiModules, JetBrains.ProjectModel.IProject project) { }
        public static System.Collections.Generic.List<JetBrains.ProjectModel.IModule> GetScope(System.Collections.Generic.List<JetBrains.ProjectModel.IProjectToModuleReference> assemblyReferencesToDelete) { }
        public static System.Collections.Generic.IEnumerable<JetBrains.ProjectModel.IModule> ToModules(this System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Modules.IPsiModule> psiModules) { }
    }
    public class RetargetedModulesEqualityComparer : System.Collections.Generic.IEqualityComparer<JetBrains.ProjectModel.IModule>
    {
        public RetargetedModulesEqualityComparer(JetBrains.ProjectModel.ISolution solution) { }
        public bool Equals(JetBrains.ProjectModel.IModule x, JetBrains.ProjectModel.IModule y) { }
        public int GetHashCode(JetBrains.ProjectModel.IModule module) { }
    }
    public class SearchReferencedCodeConsumer : JetBrains.ReSharper.Feature.Services.Search.SearchResultsConsumer
    {
        public SearchReferencedCodeConsumer([JetBrains.Annotations.CanBeNullAttribute()] System.Collections.Generic.List<JetBrains.ProjectModel.IModule> modulesClosure, System.Collections.Generic.IEqualityComparer<JetBrains.ReSharper.Psi.Modules.IPsiModule> comparer, System.Func<JetBrains.ReSharper.Feature.Services.ReferencedCode.FindResultReferencedCode, bool> filter, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ProjectModel.PlatformID platformId = null) { }
        public override JetBrains.ReSharper.Feature.Services.Search.IOccurence Build(JetBrains.ReSharper.Psi.Search.FindResult result) { }
    }
    public class TextualMergeLineAndModule
    {
        public TextualMergeLineAndModule(JetBrains.ProjectModel.IProjectFile projectFile, JetBrains.Util.dataStructures.TypedIntrinsics.Int32<JetBrains.DocumentModel.DocLine> line, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ProjectModel.IModule relatedModule) { }
        public bool Equals(JetBrains.ReSharper.Feature.Services.ReferencedCode.TextualMergeLineAndModule other) { }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.Search
{
    
    public class DefaultSearchDomainContext : JetBrains.ReSharper.Feature.Services.Search.ISearchDomainContext
    {
        public DefaultSearchDomainContext(JetBrains.Application.DataContext.IDataContext dataContext) { }
        protected bool IncludeExternalCodeByDefault { get; set; }
        public JetBrains.ReSharper.Feature.Services.Search.NamedSearchDomain GetDefaultDomain(bool sourcesOnly) { }
        public JetBrains.ReSharper.Feature.Services.Search.NamedSearchDomain[] GetUserSelectableVariants(bool sourcesOnly) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.KnownLanguage))]
    public class DefaultSearchReferenceVisitor : JetBrains.ReSharper.Feature.Services.Search.ISearchReferenceVisitor
    {
        public void Visit(JetBrains.ReSharper.Psi.Tree.ITreeNode element, System.Action<System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.Resolve.IReference>> action) { }
    }
    public class EmptySearchDomainContext : JetBrains.ReSharper.Feature.Services.Search.ISearchDomainContext
    {
        public static readonly JetBrains.ReSharper.Feature.Services.Search.ISearchDomainContext Instance;
        public JetBrains.ReSharper.Feature.Services.Search.NamedSearchDomain GetDefaultDomain(bool sourcesOnly) { }
        public JetBrains.ReSharper.Feature.Services.Search.NamedSearchDomain[] GetUserSelectableVariants(bool sourcesOnly) { }
    }
    public interface IOccurence
    {
        bool IsValid { get; }
        System.Collections.Generic.IList<JetBrains.ReSharper.Feature.Services.Search.IOccurence> MergedItems { get; }
        object MergeKey { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.DeclaredElementEnvoy<JetBrains.ReSharper.Psi.INamespace> Namespace { get; }
        JetBrains.ReSharper.Feature.Services.Search.OccurenceType OccurenceType { get; }
        JetBrains.ReSharper.Feature.Services.Occurences.OccurencePresentationOptions PresentationOptions { get; set; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ProjectModel.ProjectModelElementEnvoy ProjectModelElementEnvoy { get; }
        JetBrains.Util.TextRange TextRange { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.DeclaredElementEnvoy<JetBrains.ReSharper.Psi.ITypeElement> TypeElement { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.DeclaredElementEnvoy<JetBrains.ReSharper.Psi.ITypeMember> TypeMember { get; }
        string DumpToString();
        bool Navigate(JetBrains.ProjectModel.ISolution solution, JetBrains.UI.PopupWindowManager.PopupWindowContextSource windowContext, bool transferFocus, JetBrains.IDE.TabOptions tabOptions = 2);
    }
    public interface IOccurenceKindOwner
    {
        System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.Occurences.OccurenceKindProviders.OccurenceKind> Kinds { get; }
    }
    public interface ISearchDomainContext
    {
        JetBrains.ReSharper.Feature.Services.Search.NamedSearchDomain GetDefaultDomain(bool sourcesOnly = False);
        JetBrains.ReSharper.Feature.Services.Search.NamedSearchDomain[] GetUserSelectableVariants(bool sourcesOnly = False);
    }
    public interface ISearchReferenceVisitor
    {
        void Visit(JetBrains.ReSharper.Psi.Tree.ITreeNode element, System.Action<System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.Resolve.IReference>> action);
    }
    public interface ISpecialElementFinder
    {
        JetBrains.ReSharper.Psi.Services.ReferencePreferenceKind Kind { get; }
        JetBrains.ReSharper.Feature.Services.Occurences.PreferLocationStyle LocationStyle { get; }
        void FindOccurences(object target, JetBrains.ReSharper.Psi.Search.IFindResultConsumer<JetBrains.ReSharper.Feature.Services.Search.IOccurence> consumer, JetBrains.Application.Progress.IProgressIndicator progressIndicator, JetBrains.ReSharper.Psi.Search.ISearchDomain scopeDomain);
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Feature.Services.Search.ISearchDomainContext GetSearchDomainContext(object target);
        [JetBrains.Annotations.CanBeNullAttribute()]
        object GetSearchTarget([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.IFile file, System.Nullable<JetBrains.DocumentModel.DocumentRange> range, System.Nullable<int> caretOffset);
        System.Collections.Generic.IEnumerable<JetBrains.DocumentModel.DocumentRange> GetTargetRanges(object target, JetBrains.ProjectModel.IProjectFile file);
        string GetTitle();
        string Present(object target);
    }
    public enum LibrariesFlag
    {
        SolutionOnly = 0,
        SolutionAndLibraries = 1,
    }
    public class NamedSearchDomain
    {
        public NamedSearchDomain(JetBrains.ReSharper.Psi.Search.ISearchDomain searchDomain, string presentableName) { }
        public string PresentableName { get; }
        public string PresentableNameWithoutAccelerators { get; }
        public JetBrains.ReSharper.Psi.Search.ISearchDomain SearchDomain { get; }
    }
    public enum OccurenceType
    {
        Occurence = 0,
        LateBoundOccurence = 1,
        TextualOccurence = 2,
        Compiled = 3,
    }
    public class ScopeSelector : JetBrains.UI.CommonControls.SafeUserControl
    {
        public ScopeSelector(JetBrains.ReSharper.Feature.Services.Search.ISearchDomainContext searchDomainContext, JetBrains.UI.Application.IUIApplication environment) { }
        public JetBrains.ReSharper.Psi.Search.ISearchDomain SelectedSearchDomain { get; }
    }
    public class ScopeSelectorDialog : System.Windows.Forms.Form
    {
        public ScopeSelectorDialog(JetBrains.ReSharper.Feature.Services.Search.ISearchDomainContext searchDomainContext, JetBrains.UI.Application.IUIApplication environment) { }
        public JetBrains.ReSharper.Psi.Search.ISearchDomain SelectedSearchDomain { get; }
    }
    public class static SearchDomainContextUtil
    {
        public static readonly JetBrains.Application.DataContext.DataConstant<JetBrains.ReSharper.Feature.Services.Search.ISearchDomainContext> SearchDomainContextDataConstant;
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.ReSharper.Feature.Services.Search.ISearchDomainContext GetSearchDomainContext(JetBrains.Application.DataContext.IDataContext dataContext) { }
    }
    public abstract class SearchDomainVisitorParallel : JetBrains.ReSharper.Psi.Search.SearchDomainVisitor
    {
        protected SearchDomainVisitorParallel(JetBrains.ReSharper.Psi.Search.ISearchDomain searchDomain, JetBrains.Application.Progress.IProgressIndicator pi, bool async) { }
        public override bool ProcessingIsFinished { get; }
        protected abstract bool ProcessAssembly(JetBrains.ReSharper.Psi.IPsiAssembly assembly);
        protected abstract bool ProcessElement(JetBrains.ReSharper.Psi.Tree.ITreeNode element);
        protected abstract bool ProcessProjectFile(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile);
        public void Run() { }
        public override void VisitAssembly(JetBrains.ReSharper.Psi.IPsiAssembly assembly) { }
        public override void VisitElement(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public override void VisitPsiSourceFile(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
    }
    public class SearchResultsConsumer : JetBrains.ReSharper.Psi.Search.IFindResultConsumer<JetBrains.ReSharper.Feature.Services.Search.IOccurence>
    {
        public SearchResultsConsumer([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ProjectModel.PlatformID platformId = null) { }
        public virtual JetBrains.ReSharper.Feature.Services.Search.IOccurence Build(JetBrains.ReSharper.Psi.Search.FindResult result) { }
        public System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.Search.IOccurence> GetOccurences() { }
        public virtual JetBrains.ReSharper.Psi.Search.FindExecution Merge(JetBrains.ReSharper.Feature.Services.Search.IOccurence data) { }
    }
    public class static SearchResultsConsumerHelper
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ProjectModel.PlatformID TryGetCommonPlatformId(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IDeclaredElement> elements) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ProjectModel.PlatformID TryGetDeclaredElementPlatformId([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ProjectModel.PlatformID TryGetElementPlatformId([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IClrDeclaredElement element) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ProjectModel.PlatformID TryGetTypeMemberPlatformId([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.ExtensionsAPI.Caches2.CachedTypeMemberBase typeMember) { }
    }
    public class SingleDomainSearchDomainContext : JetBrains.ReSharper.Feature.Services.Search.ISearchDomainContext
    {
        public SingleDomainSearchDomainContext([JetBrains.Annotations.NotNullAttribute()] string domainName, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Search.ISearchDomain searchDomain, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.ISolution solution) { }
        public JetBrains.ReSharper.Feature.Services.Search.NamedSearchDomain GetDefaultDomain(bool sourcesOnly) { }
        public JetBrains.ReSharper.Feature.Services.Search.NamedSearchDomain[] GetUserSelectableVariants(bool sourcesOnly) { }
    }
    [JetBrains.Annotations.MeansImplicitUseAttribute()]
    public class SpecialElementFinderAttribute : JetBrains.ReSharper.Psi.PsiSharedComponentAttribute { }
    [JetBrains.ReSharper.Psi.PsiSharedComponentAttribute()]
    public class SpecialElementFinderManager
    {
        public SpecialElementFinderManager(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.Search.ISpecialElementFinder> specialFinders) { }
        public static object GetSpecialSearchTarget(JetBrains.Application.DataContext.IDataContext context, JetBrains.ReSharper.Psi.Services.ReferencePreferenceKind kind, out JetBrains.ReSharper.Feature.Services.Search.ISpecialElementFinder finder) { }
        public static object GetSpecialSearchTarget<TFinder>(JetBrains.Application.DataContext.IDataContext context, JetBrains.ReSharper.Psi.Services.ReferencePreferenceKind kind, out JetBrains.ReSharper.Feature.Services.Search.ISpecialElementFinder finder)
            where TFinder : JetBrains.ReSharper.Feature.Services.Search.ISpecialElementFinder { }
        public static object GetSpecialSearchTarget<TFinder>(JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, System.Nullable<JetBrains.DocumentModel.DocumentRange> documentRange, System.Nullable<int> caretOffset, JetBrains.ReSharper.Psi.Services.ReferencePreferenceKind kind, out JetBrains.ReSharper.Feature.Services.Search.ISpecialElementFinder finder)
            where TFinder : JetBrains.ReSharper.Feature.Services.Search.ISpecialElementFinder { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.Search.SearchRequests
{
    
    public class ExtensionMethodsSearchRequest : JetBrains.ReSharper.Feature.Services.Search.SearchRequests.SearchRequest
    {
        public ExtensionMethodsSearchRequest([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.IType type, JetBrains.ProjectModel.ISolution solution, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.IClrDeclaredElement target, JetBrains.ReSharper.Psi.Modules.IPsiModule module = null) { }
        public override System.Collections.ICollection SearchTargets { get; }
        public override JetBrains.ProjectModel.ISolution Solution { get; }
        public override string Title { get; }
        public override System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.Search.IOccurence> Search(JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
    }
    public class SearchBasesRequest : JetBrains.ReSharper.Feature.Services.Search.SearchRequests.SearchRequest
    {
        public SearchBasesRequest(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
        public override System.Collections.ICollection SearchTargets { get; }
        public override JetBrains.ProjectModel.ISolution Solution { get; }
        public override string Title { get; }
        public override int CompareOccurences(JetBrains.ReSharper.Feature.Services.Search.IOccurence x, JetBrains.ReSharper.Feature.Services.Search.IOccurence y) { }
        protected override JetBrains.Application.Progress.ITaskExecutor CreateTaskExecutor() { }
        public override System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.Search.IOccurence> Search(JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
    }
    public class SearchDeclarationsRequest : JetBrains.ReSharper.Feature.Services.Search.SearchRequests.SearchRequest
    {
        protected readonly JetBrains.ReSharper.Psi.DeclaredElementEnvoy<JetBrains.ReSharper.Psi.IDeclaredElement> myTarget;
        public SearchDeclarationsRequest(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
        public override System.Collections.ICollection SearchTargets { get; }
        public override JetBrains.ProjectModel.ISolution Solution { get; }
        public JetBrains.ReSharper.Psi.DeclaredElementEnvoy<JetBrains.ReSharper.Psi.IDeclaredElement> Target { get; }
        public override string Title { get; }
        protected override JetBrains.Application.Progress.ITaskExecutor CreateTaskExecutor() { }
        protected virtual string GetTitle(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
        public override System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.Search.IOccurence> Search(JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
    }
    public class SearchDeclaredElementUsagesRequest : JetBrains.ReSharper.Feature.Services.Search.SearchRequests.SearchUsagesRequest
    {
        public SearchDeclaredElementUsagesRequest(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IDeclaredElement> elementsToSearch, JetBrains.ReSharper.Psi.Search.SearchPattern searchPattern, JetBrains.ReSharper.Psi.Search.ISearchDomain searchDomain, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IDeclaredElement> initialTargets) { }
        public SearchDeclaredElementUsagesRequest(JetBrains.ReSharper.Psi.IDeclaredElement elementToSearch, JetBrains.ReSharper.Psi.Search.SearchPattern searchPattern, JetBrains.ReSharper.Psi.Search.ISearchDomain searchDomain, JetBrains.ReSharper.Psi.IDeclaredElement initialTarget) { }
        public SearchDeclaredElementUsagesRequest(JetBrains.ReSharper.Feature.Services.Navigation.AdvancedSearchingInfo elementsToSearch) { }
        protected System.Collections.Generic.List<JetBrains.ReSharper.Psi.DeclaredElementEnvoy<JetBrains.ReSharper.Psi.IDeclaredElement>> InitialTargetDeclaredElementEnvoys { get; }
        public bool SearchParametersOverloads { get; set; }
        protected JetBrains.ReSharper.Psi.Search.SearchPattern SearchPattern { get; }
        public override System.Collections.ICollection SearchTargets { get; }
        protected System.Collections.Generic.List<JetBrains.ReSharper.Psi.DeclaredElementEnvoy<JetBrains.ReSharper.Psi.IDeclaredElement>> TargetDeclaredElementEnvoys { get; }
        public override string Title { get; }
        protected virtual System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.Search.IOccurence> FilterOccurences(JetBrains.ReSharper.Feature.Services.Search.SearchResultsConsumer consumer) { }
        protected virtual void FindReferences(System.Collections.Generic.List<JetBrains.ReSharper.Psi.IDeclaredElement> searchElements, JetBrains.ReSharper.Feature.Services.Search.SearchResultsConsumer consumer, JetBrains.Application.Progress.IProgressIndicator progressIndicator, System.Collections.Generic.List<JetBrains.ReSharper.Psi.IDeclaredElement> initialTargets) { }
        protected virtual JetBrains.ReSharper.Feature.Services.Search.SearchResultsConsumer GetSearchResultsConsumer([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ProjectModel.PlatformID platformId) { }
        protected virtual string GetTitle(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, JetBrains.ReSharper.Psi.Search.SearchPattern searchPattern) { }
        public override System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.Search.IOccurence> Search(JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
    }
    public class SearchImplementationsRequest : JetBrains.ReSharper.Feature.Services.Search.SearchRequests.SearchDeclarationsRequest
    {
        public SearchImplementationsRequest(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, JetBrains.ReSharper.Psi.ITypeElement originType, JetBrains.ReSharper.Psi.Search.ISearchDomain searchDomain) { }
        public override int CompareOccurences(JetBrains.ReSharper.Feature.Services.Search.IOccurence x, JetBrains.ReSharper.Feature.Services.Search.IOccurence y) { }
        protected override JetBrains.Application.Progress.ITaskExecutor CreateTaskExecutor() { }
        protected override string GetTitle(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
        public override System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.Search.IOccurence> Search(JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
    }
    public class SearchInheritorsRequest : JetBrains.ReSharper.Feature.Services.Search.SearchRequests.SearchUsagesRequest
    {
        public SearchInheritorsRequest(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, JetBrains.ReSharper.Psi.Search.ISearchDomain searchDomain) { }
        public override System.Collections.ICollection SearchTargets { get; }
        public override JetBrains.ProjectModel.ISolution Solution { get; }
        public override string Title { get; }
        public override int CompareOccurences(JetBrains.ReSharper.Feature.Services.Search.IOccurence x, JetBrains.ReSharper.Feature.Services.Search.IOccurence y) { }
        public override System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.Search.IOccurence> Search(JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
    }
    public class SearchProjectItemReferencedCodeRequest : JetBrains.ReSharper.Feature.Services.Search.SearchRequests.SearchReferencedCodeRequest
    {
        public SearchProjectItemReferencedCodeRequest(System.Collections.Generic.IEnumerable<JetBrains.ProjectModel.IProjectItem> targetElements, JetBrains.ProjectModel.ISolution solution, bool includeRelated = True, bool useRetargeting = False, [JetBrains.Annotations.CanBeNullAttribute()] System.Collections.Generic.List<JetBrains.ProjectModel.IModule> referencedCodeScope = null) { }
        public override System.Collections.ICollection SearchTargets { get; }
        public override JetBrains.ProjectModel.ISolution Solution { get; }
        public override string Title { get; }
        public override System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.Search.IOccurence> Search(JetBrains.Application.Progress.IProgressIndicator pi) { }
    }
    public class SearchProjectModelUsagesRequest : JetBrains.ReSharper.Feature.Services.Search.SearchRequests.SearchDeclaredElementUsagesRequest
    {
        public SearchProjectModelUsagesRequest(System.Collections.Generic.IEnumerable<JetBrains.ProjectModel.IProjectModelElement> targets, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IDeclaredElement> nestedDelclaredElementsToSearch, JetBrains.ReSharper.Psi.Search.SearchPattern searchPattern, JetBrains.ReSharper.Psi.Search.ISearchDomain searchDomain) { }
        public override System.Collections.ICollection SearchTargets { get; }
        public override string Title { get; }
        protected override JetBrains.ReSharper.Feature.Services.Search.SearchResultsConsumer GetSearchResultsConsumer(JetBrains.ProjectModel.PlatformID platformId) { }
    }
    public abstract class SearchReferencedCodeRequest : JetBrains.ReSharper.Feature.Services.Search.SearchRequests.SearchRequest
    {
        protected SearchReferencedCodeRequest(JetBrains.ProjectModel.ISolution solution) { }
        public override JetBrains.ProjectModel.ISolution Solution { get; }
    }
    public abstract class SearchRequest
    {
        public abstract System.Collections.ICollection SearchTargets { get; }
        public abstract JetBrains.ProjectModel.ISolution Solution { get; }
        public abstract string Title { get; }
        public virtual int CompareOccurences(JetBrains.ReSharper.Feature.Services.Search.IOccurence o1, JetBrains.ReSharper.Feature.Services.Search.IOccurence o2) { }
        protected virtual JetBrains.Application.Progress.ITaskExecutor CreateTaskExecutor() { }
        public abstract System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.Search.IOccurence> Search(JetBrains.Application.Progress.IProgressIndicator progressIndicator);
        public virtual System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.Search.IOccurence> Search() { }
    }
    public delegate void SearchRequestExecutor<in TSearch>(JetBrains.Application.DataContext.IDataContext context, TSearch request);
    public class SearchSingleFileDeclaredElementRequest : JetBrains.ReSharper.Feature.Services.Search.SearchRequests.SearchDeclaredElementUsagesRequest
    {
        public SearchSingleFileDeclaredElementRequest(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IDeclaredElement> elementsToSearch, JetBrains.ReSharper.Psi.Search.ISearchDomain domain, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IDeclaredElement> initialTargets) { }
        protected override JetBrains.Application.Progress.ITaskExecutor CreateTaskExecutor() { }
        protected override System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.Search.IOccurence> FilterOccurences(JetBrains.ReSharper.Feature.Services.Search.SearchResultsConsumer consumer) { }
        protected override void FindReferences(System.Collections.Generic.List<JetBrains.ReSharper.Psi.IDeclaredElement> searchElements, JetBrains.ReSharper.Feature.Services.Search.SearchResultsConsumer consumer, JetBrains.Application.Progress.IProgressIndicator progressIndicator, System.Collections.Generic.List<JetBrains.ReSharper.Psi.IDeclaredElement> initialTargets) { }
    }
    public class SearchSpecialUsagesRequest : JetBrains.ReSharper.Feature.Services.Search.SearchRequests.SearchUsagesRequest
    {
        public SearchSpecialUsagesRequest(JetBrains.ReSharper.Feature.Services.Search.ISpecialElementFinder finder, object target, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Psi.Search.ISearchDomain searchDomain) { }
        public JetBrains.ReSharper.Feature.Services.Search.ISpecialElementFinder Finder { get; }
        public override System.Collections.ICollection SearchTargets { get; }
        public object Target { get; }
        public override string Title { get; }
        public override System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.Search.IOccurence> Search(JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
    }
    public class SearchSubstitutionRequest : JetBrains.ReSharper.Feature.Services.Search.SearchRequests.SearchRequest
    {
        public SearchSubstitutionRequest([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.ITypeParameter typeParameter, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.ISolution solution, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Search.ISearchDomain domain) { }
        public override System.Collections.ICollection SearchTargets { get; }
        public override JetBrains.ProjectModel.ISolution Solution { get; }
        public override string Title { get; }
        public override System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.Search.IOccurence> Search(JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
    }
    public abstract class SearchUsagesRequest : JetBrains.ReSharper.Feature.Services.Search.SearchRequests.SearchRequest
    {
        protected SearchUsagesRequest([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.ISolution solution, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Search.ISearchDomain searchDomain) { }
        public JetBrains.ReSharper.Psi.Search.ISearchDomain SearchDomain { get; }
        public override JetBrains.ProjectModel.ISolution Solution { get; }
        protected virtual JetBrains.ReSharper.Psi.Search.ISearchDomain CreateSearchDomain(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IDeclaredElement> targetElements, System.Collections.Generic.List<JetBrains.ReSharper.Psi.IDeclaredElement> initialTargets) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.Util
{
    
    public class static PresentationUtil
    {
        public static readonly JetBrains.ReSharper.Psi.DeclaredElementPresenterStyle QUOTED_KIND_NAME_PRESENTER;
        public static string Format(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
        public static string Format(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, JetBrains.ReSharper.Psi.PsiLanguageType language) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.ReSharper.Psi.PsiLanguageType GetDefaultPresentationLanguage(JetBrains.ReSharper.Psi.IPsiServices psiServices) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.ReSharper.Psi.PsiLanguageType GetPresentationLanguage([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.ReSharper.Psi.PsiLanguageType GetPresentationLanguageByContainer([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ProjectModel.IProjectFile projectFile, JetBrains.ProjectModel.ISolution solution) { }
        public static JetBrains.UI.RichText.RichText PresentDeclaredElement(JetBrains.ReSharper.Psi.IDeclaredElement element, JetBrains.ReSharper.Psi.DeclaredElementPresenterStyle style) { }
        public static JetBrains.UI.RichText.RichText PresentEntityWithLocation(string entityName, string location) { }
    }
}