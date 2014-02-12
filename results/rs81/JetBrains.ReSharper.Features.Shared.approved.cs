[assembly: JetBrains.UI.Icons.CompiledIcons.CompiledIconsPackAttribute(IconNames=new string[] {
        "StackTraceExplorerToolWindow"}, IconPackResourceIdentification="JetBrains.ReSharper.Features.Shared;component/resources/FeaturesSharedThemedIcons" +
    "/ThemedIcons.FeaturesShared.Generated.Xaml")]
[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]
[assembly: System.Windows.Markup.XmlnsDefinitionAttribute("urn:shemas-jetbrains-com:ui-application-icons-features-shared", "JetBrains.ReSharper.Features.Shared.Resources")]

namespace JetBrains.ReSharper.Feature.Services.StackTrace
{
    
    public class static DeclaredElementsSerializer
    {
        public static JetBrains.ReSharper.Psi.IDeclaredElement[] DeserializeAllResolvableElements(string data, JetBrains.ProjectModel.ISolution solution) { }
        public static string SerializeElements(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IClrDeclaredElement> elements) { }
    }
    public abstract class StackTraceBuilderWithResolveBase : JetBrains.IDE.StackTrace.StackTraceBuilderBase
    {
        public StackTraceBuilderWithResolveBase(JetBrains.ProjectModel.ISolution solution, JetBrains.IDE.StackTrace.StackTracePathResolverCache pathResolverCache, string text) { }
        protected override void AppendIdentifierName(JetBrains.Util.StackTraceParser.IdentifierNode node) { }
        public override void VisitMethod(JetBrains.Util.StackTraceParser.MethodNode node) { }
        public override void VisitParameter(JetBrains.Util.StackTraceParser.ParameterNode node) { }
    }
    public class StackTraceHtmlBuilderWithResolve : JetBrains.ReSharper.Feature.Services.StackTrace.StackTraceBuilderWithResolveBase
    {
        public const string LinkEmuCss = "\r\n    <style type=\"text/css\"> \r\n      .hoverLinkEmuLink {\r\n        text-decoratio" +
            "n: underline;\r\n        cursor: pointer;\r\n      }\r\n      \r\n      .normalLinkEmuLi" +
            "nk {\r\n      }\r\n    </style>\r\n    ";
        public const string LinkEmuScript = @"
    <script language=""javascript"">
      var linkPressedStatus = new Array();

      function linkEmuMouseDown(e, obj) {
        linkPressedStatus[obj.location] = true;
        return true;
      }
      
      function linkEmuMouseUp(e, obj) {
        if (linkPressedStatus[obj.location]) {
          linkPressedStatus[obj.location] = false;
          window.location.href = obj.location;
        }
        
        return true;
      }
      
      function toggleLinkEmuStyle(obj, hover) {
        obj.className = hover ? ""hoverLinkEmuLink"" : ""normalLinkEmuLink"";
      }
      
      function linkEmuMouseEnter(e, obj) {
        linkPressedStatus[obj.location] = false;
        toggleLinkEmuStyle(obj, true);
      }
      
      function linkEmuMouseMove(e, obj) {
        linkPressedStatus[obj.location] = false;
        toggleLinkEmuStyle(obj, true);
      }
      
      function linkEmuMouseLeave(e, obj) {
        linkPressedStatus[obj.location] = false;
        toggleLinkEmuStyle(obj, false);
      }
    </script>
    ";
        protected readonly System.Text.StringBuilder Result;
        public StackTraceHtmlBuilderWithResolve(string text, JetBrains.ProjectModel.ISolution solution, JetBrains.IDE.StackTrace.StackTracePathResolverCache pathResolverCache) { }
        public string Html { get; }
        protected override void Append(string text) { }
        protected override void AppendPath(string path, int line, int column) { }
        protected override void AppendQuoted(string text) { }
        protected override void AppendQuotedNodeText(JetBrains.Util.StackTraceParser.StackTraceNode node) { }
        public void BuildFooter() { }
        public void BuildHeader() { }
        protected override System.IDisposable Colorize(string color) { }
        protected static string EscapeHtmlString(string s) { }
        protected override System.IDisposable Link(string href) { }
        protected override System.IDisposable LinkEmuLink(string href) { }
        protected override void LinkGenerated(string uri, JetBrains.ProjectModel.IProjectFile file, int line, int col) { }
    }
    public class static StackTraceResolveHelper
    {
        public static string[] GetTypeComponenets(JetBrains.Util.StackTraceParser.IdentifierNode typeNode) { }
        public static bool IsTypeParametersCountMatched(JetBrains.ReSharper.Psi.ITypeMember typeMember, JetBrains.Util.StackTraceParser.IdentifierNode node) { }
        public static System.Collections.Generic.IList<JetBrains.ReSharper.Feature.Services.StackTrace.StackTraceResolveHelper.ResolvedMethod> Resolve(this JetBrains.Util.StackTraceParser.MethodNode node, JetBrains.ProjectModel.ISolution solution) { }
        public static System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.ITypeElement> ResolveType(this JetBrains.Util.StackTraceParser.IdentifierNode node, JetBrains.ProjectModel.ISolution solution) { }
        public class ResolvedMethod
        {
            public JetBrains.ReSharper.Psi.IFunction Method { get; set; }
            public JetBrains.Util.TextRange MethodNameRange { get; set; }
            public JetBrains.Util.TextRange TypeRange { get; set; }
        }
    }
    public class StackTraceWpfBuilderWithResolve : JetBrains.ReSharper.Feature.Services.StackTrace.StackTraceBuilderWithResolveBase
    {
        public StackTraceWpfBuilderWithResolve(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ProjectModel.ISolution solution, JetBrains.UI.ActiveText.LinkNavigator linkNavigator, JetBrains.IDE.StackTrace.StackTracePathResolverCache pathResolverCache, string text) { }
        public StackTraceWpfBuilderWithResolve(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ProjectModel.ISolution solution, JetBrains.UI.ActiveText.LinkNavigator linkNavigator, JetBrains.IDE.StackTrace.StackTracePathResolverCache pathResolverCache, string text, System.Windows.Media.Color expectedBackground) { }
        public string BareText { get; }
        public System.Collections.Generic.IEnumerable<System.Windows.Documents.Block> Blocks { get; }
        protected override void Append(string text) { }
        protected override void AppendPath(string path, int line, int column) { }
        protected override void AppendQuoted(string text) { }
        protected override void AppendQuotedNodeText(JetBrains.Util.StackTraceParser.StackTraceNode node) { }
        protected override System.IDisposable Colorize(string color) { }
        protected override System.IDisposable Link(string href) { }
        protected override System.IDisposable LinkEmuLink(string href) { }
        protected override void LinkGenerated(string uri, JetBrains.ProjectModel.IProjectFile file, int line, int col) { }
    }
}
namespace JetBrains.ReSharper.Features.Shared.GroupingManagement
{
    
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class GroupingManager
    {
        public GroupingManager(JetBrains.ReSharper.Feature.Services.IFeaturePartsContainer container) { }
        public System.Collections.Generic.IEnumerable<JetBrains.TreeModels.TreeModelGrouping<TItem>> GetGroupings<TItem>(JetBrains.IDE.TreeBrowser.TreeModelBrowserDescriptorBase descriptor)
            where TItem :  class { }
        public static JetBrains.ReSharper.Features.Shared.GroupingManagement.GroupingManager GetInstance(JetBrains.ProjectModel.ISolution solution) { }
    }
    public interface IGroupingProvider<T>
        where T :  class
    {
        System.Collections.Generic.ICollection<JetBrains.TreeModels.TreeModelGrouping<T>> GetGroupings(JetBrains.IDE.TreeBrowser.TreeModelBrowserDescriptorBase descriptor);
        bool IsApplicable(JetBrains.IDE.TreeBrowser.TreeModelBrowserDescriptorBase descriptor);
    }
}
namespace JetBrains.ReSharper.Features.Shared.Occurences
{
    
    public class ExternalLibrariesNodeValue
    {
        public bool IsValid { get; }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
        public static JetBrains.ReSharper.Features.Shared.Occurences.ExternalLibrariesNodeValue GetInstance(JetBrains.ProjectModel.ISolution solution) { }
        public void Present(JetBrains.ReSharper.Features.Shared.TreePsiBrowser.TreeModelBrowserPresenter presenter, JetBrains.TreeModels.TreeModelNode modelNode, JetBrains.CommonControls.IPresentableItem item, JetBrains.UI.TreeView.PresentationState state) { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class OccurencePresentationManager
    {
        public OccurencePresentationManager(JetBrains.ReSharper.Feature.Services.IFeaturePartsContainer container) { }
        public static JetBrains.ReSharper.Features.Shared.Occurences.OccurencePresentationManager Instance { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.UI.PopupMenu.IMenuItemDescriptor DescribeOccurence(JetBrains.ReSharper.Feature.Services.Search.IOccurence occurence) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.UI.PopupMenu.IMenuItemDescriptor DescribeOccurence(JetBrains.ReSharper.Feature.Services.Search.IOccurence occurence, System.Nullable<JetBrains.ReSharper.Feature.Services.Occurences.OccurencePresentationOptions> featureSpecificPresentationOptions) { }
        public bool DescribeOccurence(JetBrains.UI.PopupMenu.IMenuItemDescriptor descriptor, JetBrains.ReSharper.Feature.Services.Search.IOccurence occurence, System.Nullable<JetBrains.ReSharper.Feature.Services.Occurences.OccurencePresentationOptions> featureSpecificPresentationOptions) { }
        public void DescribeOccurence(JetBrains.UI.PopupMenu.IMenuItemDescriptor descriptor, JetBrains.ReSharper.Feature.Services.Search.IOccurence occurence) { }
        public JetBrains.UI.PopupMenu.IMenuItemDescriptor DescribeOccurenceWithMatchingChars(JetBrains.ReSharper.Feature.Services.Search.IOccurence occurence, System.Nullable<JetBrains.ReSharper.Feature.Services.Occurences.OccurencePresentationOptions> options, JetBrains.ReSharper.Feature.Services.Goto.MatchingInfo matchingInfo) { }
        public static JetBrains.ReSharper.Feature.Services.Occurences.OccurencePresentationOptions MergePresentationOptions(JetBrains.ReSharper.Feature.Services.Occurences.OccurencePresentationOptions occurenceSpecificOptions, JetBrains.ReSharper.Feature.Services.Occurences.OccurencePresentationOptions featureOptions) { }
    }
}
namespace JetBrains.ReSharper.Features.Shared.Resources
{
    
    public sealed class FeaturesSharedThemedIcons
    {
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Features.Shared;component/resources/FeaturesSharedThemedIcons" +
            "/ThemedIcons.FeaturesShared.Generated.Xaml", 0, "StackTraceExplorerToolWindow")]
        public sealed class StackTraceExplorerToolWindow : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
    }
}
namespace JetBrains.ReSharper.Features.Shared.StackTrace
{
    
    public class ExceptionVisualizerInstaller : JetBrains.Application.Install.IStaticInstaller
    {
        public ExceptionVisualizerInstaller() { }
    }
    [JetBrains.ActionManagement.ActionHandlerAttribute()]
    public class ExploreStackTraceAction : JetBrains.ActionManagement.IActionHandler
    {
        public void Execute(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.DelegateExecute nextExecute) { }
        public bool Update(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.ActionPresentation presentation, JetBrains.ActionManagement.DelegateUpdate nextUpdate) { }
    }
    [JetBrains.UI.ActiveText.ProtocolHandlerAttribute(Protocol="ordinalfile", SchemeDelimiter=":")]
    public class OrdinalFileProtocolHandler : JetBrains.ReSharper.Features.Shared.StackTrace.StackTraceProtocolHandlerBase
    {
        public OrdinalFileProtocolHandler(JetBrains.ProjectModel.SolutionsManager solutionManager, JetBrains.Threading.IThreading threading) { }
        protected override void Navigate(JetBrains.ProjectModel.ISolution solution, string uri) { }
    }
    [JetBrains.UI.ActiveText.ProtocolHandlerAttribute(Protocol="projectfile", SchemeDelimiter=":")]
    public class ProjectFileProtocolHandler : JetBrains.ReSharper.Features.Shared.StackTrace.StackTraceProtocolHandlerBase
    {
        public ProjectFileProtocolHandler(JetBrains.ProjectModel.SolutionsManager solutionManager, JetBrains.Threading.IThreading threading) { }
        protected override void Navigate(JetBrains.ProjectModel.ISolution solution, string uri) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class StackTraceManager
    {
        public StackTraceManager(JetBrains.UI.Application.IUIApplication environment, JetBrains.DataFlow.Lifetime lifetime, JetBrains.ProjectModel.ISolution solution, JetBrains.ActionManagement.IActionManager actionManager, JetBrains.ActionManagement.IShortcutManager shortcutManager, JetBrains.UI.ToolWindowManagement.ToolWindowManager toolWindowManager, JetBrains.ReSharper.Psi.Files.IPsiFiles psiFiles, JetBrains.Application.IShellLocks shellLocks, JetBrains.UI.ActiveText.LinkNavigator linkNavigator, JetBrains.ReSharper.Features.Shared.StackTrace.StackTraceToolWindowDescriptor toolWindowDescriptor, JetBrains.IDE.StackTrace.StackTracePathResolverCache pathResolverCache) { }
        public static JetBrains.ReSharper.Features.Shared.StackTrace.StackTraceManager GetInstance(JetBrains.ProjectModel.ISolution solution) { }
        public void Open(string stackTraceText) { }
        [JetBrains.Threading.GuardAttribute(JetBrains.Threading.Rgc.Guarded)]
        public string RenderHtml(string text, bool scaffolding) { }
        [JetBrains.Threading.GuardAttribute(JetBrains.Threading.Rgc.Guarded)]
        public JetBrains.ReSharper.Feature.Services.StackTrace.StackTraceWpfBuilderWithResolve RenderWpf(JetBrains.DataFlow.Lifetime lifetime, string text, System.Windows.Media.Color expectedBackground) { }
    }
    public abstract class StackTraceProtocolHandlerBase : JetBrains.UI.ActiveText.ProtocolHandler
    {
        protected StackTraceProtocolHandlerBase(JetBrains.ProjectModel.SolutionsManager solutionManager, JetBrains.Threading.IThreading threading) { }
        protected static void MoveCaretTo(JetBrains.TextControl.ITextControl textControl, int line, int column) { }
        protected abstract void Navigate(JetBrains.ProjectModel.ISolution solution, string hyperlink);
        protected override void NavigateNakedLink(string link, object host) { }
        protected static bool ParsePathRef(string spec, out string path, out int line, out int column) { }
    }
    [JetBrains.UI.ToolWindowManagement.ToolWindowDescriptorAttribute(Icon=typeof(JetBrains.ReSharper.Features.Shared.Resources.FeaturesSharedThemedIcons.StackTraceExplorerToolWindow), ProductNeutralId="StackTraceManager", Text="Stack Trace Explorer", Type=JetBrains.UI.ToolWindowManagement.ToolWindowType.MultiInstance, VisibilityPersistenceScope=JetBrains.UI.ToolWindowManagement.ToolWindowVisibilityPersistenceScope.Solution)]
    public class StackTraceToolWindowDescriptor : JetBrains.UI.ToolWindowManagement.ToolWindowDescriptor
    {
        public StackTraceToolWindowDescriptor(JetBrains.Application.IApplicationDescriptor applicationDescriptor) { }
    }
    public class StackTraceViewAvalonControl : System.Windows.Controls.UserControl
    {
        public static readonly System.Windows.DependencyProperty TextProperty;
        public string Text { get; set; }
        public void EnableUiAutomationHack(System.Windows.Controls.FlowDocumentScrollViewer documentScrollViewer) { }
        public void UpdateContent() { }
    }
    public class StackTraceViewControl : JetBrains.CommonControls.Browser.HtmlViewControl, JetBrains.IDE.ResultList.IResultListHandler
    {
        public StackTraceViewControl() { }
        protected override void OnDocumentCompleted(System.Windows.Forms.WebBrowserDocumentCompletedEventArgs e) { }
    }
    [JetBrains.UI.ActiveText.ProtocolHandlerAttribute(Protocol="xmldocids", SchemeDelimiter=":")]
    public class XmlDocProtocolHandler : JetBrains.ReSharper.Features.Shared.StackTrace.StackTraceProtocolHandlerBase
    {
        public XmlDocProtocolHandler(JetBrains.ProjectModel.SolutionsManager solutionManager, JetBrains.Threading.IThreading threading, JetBrains.ActionManagement.IActionManager actionManager) { }
        protected override void Navigate(JetBrains.ProjectModel.ISolution solution, string uri) { }
    }
}
namespace JetBrains.ReSharper.Features.Shared.TreePsiBrowser
{
    
    public class ProjectItemComparer : System.Collections.Generic.IComparer<JetBrains.ProjectModel.IProjectItem>
    {
        public static readonly JetBrains.ReSharper.Features.Shared.TreePsiBrowser.ProjectItemComparer Instance;
        public int Compare(JetBrains.ProjectModel.IProjectItem x, JetBrains.ProjectModel.IProjectItem y) { }
    }
    public class TreeModelBrowserComparer : JetBrains.Util.MultiTypeComparer
    {
        public TreeModelBrowserComparer() { }
        public TreeModelBrowserComparer(JetBrains.ProjectModel.IProjectPresentablePathProvider presentablePathProvider) { }
        protected virtual int CompareAssemblyFile(JetBrains.ProjectModel.Model2.Assemblies.Interfaces.IAssemblyFile x, JetBrains.ProjectModel.Model2.Assemblies.Interfaces.IAssemblyFile y) { }
        protected virtual int CompareDeclarationRanges(JetBrains.ReSharper.Psi.IDeclaredElement x, JetBrains.ReSharper.Psi.IDeclaredElement y) { }
        protected virtual int CompareFileSystemPath(JetBrains.Util.FileSystemPath x, JetBrains.Util.FileSystemPath y) { }
        protected virtual int CompareModule(JetBrains.ProjectModel.IModule x, JetBrains.ProjectModel.IModule y) { }
        protected virtual int CompareNamespace(JetBrains.ReSharper.Psi.INamespace x, JetBrains.ReSharper.Psi.INamespace y) { }
        protected virtual int CompareOtherDeclaredElements(JetBrains.ReSharper.Psi.IDeclaredElement x, JetBrains.ReSharper.Psi.IDeclaredElement y) { }
        protected virtual int CompareProject(JetBrains.ProjectModel.IProject x, JetBrains.ProjectModel.IProject y) { }
        protected virtual int CompareProjectFolder(JetBrains.ProjectModel.IProjectFolder x, JetBrains.ProjectModel.IProjectFolder y) { }
        protected virtual int CompareProjectItem(JetBrains.ProjectModel.IProjectItem x, JetBrains.ProjectModel.IProjectItem y) { }
        protected virtual int CompareTypeElement(JetBrains.ReSharper.Psi.ITypeElement x, JetBrains.ReSharper.Psi.ITypeElement y) { }
        protected virtual int CompareTypeMember(JetBrains.ReSharper.Psi.ITypeMember x, JetBrains.ReSharper.Psi.ITypeMember y) { }
        protected override System.Type DisambiguateTypeConflict(System.Type t1, System.Type t2) { }
        protected override object Unwrap(object wrapper) { }
    }
    public class TreeModelBrowserPresenter : JetBrains.UI.TreeView.StructuredPresenter<JetBrains.TreeModels.TreeModelNode, JetBrains.CommonControls.IPresentableItem>
    {
        public static readonly JetBrains.UI.RichText.TextStyle AdditionalInfoTextStyle;
        public static readonly JetBrains.UI.RichText.TextStyle BoldTextStyle;
        public static readonly JetBrains.UI.RichText.TextStyle DefaultTextStyle;
        public static readonly JetBrains.ReSharper.Psi.DeclaredElementPresenterStyle EnumMemberStyle;
        public static readonly JetBrains.ReSharper.Psi.DeclaredElementPresenterStyle FullNestedStyle;
        public static readonly JetBrains.ReSharper.Psi.DeclaredElementPresenterStyle KindExtensionsStyle;
        public static readonly JetBrains.UI.RichText.TextStyle OccurenceCountTextStyle;
        public static readonly JetBrains.ReSharper.Psi.DeclaredElementPresenterStyle TypeElementQualifyAfter;
        public static readonly JetBrains.ReSharper.Psi.DeclaredElementPresenterStyle TypeElementQualifyBefore;
        public static readonly JetBrains.ReSharper.Psi.DeclaredElementPresenterStyle TypeElementUnderNaturalParent;
        public static readonly JetBrains.ReSharper.Psi.DeclaredElementPresenterStyle TypeMemberStyle;
        public static readonly JetBrains.ReSharper.Psi.DeclaredElementPresenterStyle TypeMemberStyleWithContainer;
        public static readonly JetBrains.ReSharper.Psi.DeclaredElementPresenterStyle TypeMemberStyleWithFqContainer;
        public static readonly JetBrains.UI.RichText.TextStyle TypeTextStyle;
        public TreeModelBrowserPresenter() { }
        public bool DrawElementExtensions { get; set; }
        public bool GrayInternalOrPrivate { get; set; }
        public bool PostfixMemberQualification { get; set; }
        public bool PostfixTypeQualification { get; set; }
        public bool ShowOccurenceCount { get; set; }
        protected virtual void AppendOccurencesCount(JetBrains.CommonControls.IPresentableItem item, JetBrains.TreeModels.TreeModelNode node) { }
        protected void AppendOccurencesCount(JetBrains.CommonControls.IPresentableItem item, JetBrains.TreeModels.TreeModelNode node, string itemText) { }
        protected virtual JetBrains.ReSharper.Psi.PsiLanguageType GetPresentationLanguage(JetBrains.ReSharper.Psi.IDeclaredElement value) { }
        protected virtual void HighlightDeclaredElement(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, JetBrains.ReSharper.Psi.PsiLanguageType languageType, JetBrains.CommonControls.IPresentableItem item, JetBrains.TreeModels.TreeModelNode modelNode, JetBrains.ReSharper.Psi.DeclaredElementPresenterMarking marking) { }
        protected virtual bool IsNaturalParent([JetBrains.Annotations.NotNullAttribute()] object parentValue, [JetBrains.Annotations.NotNullAttribute()] object childValue) { }
        protected virtual bool IsNodeParentNatural(JetBrains.TreeModels.TreeModelNode modelNode, object childValue) { }
        protected static void MarkInvalid(JetBrains.UI.RichText.RichText richText) { }
        protected virtual void PresentAssembly(JetBrains.ProjectModel.Model2.Assemblies.Interfaces.IAssembly value, JetBrains.CommonControls.IPresentableItem item, JetBrains.TreeModels.TreeModelNode modelNode, JetBrains.UI.TreeView.PresentationState state) { }
        protected virtual void PresentAssemblyReference(JetBrains.ProjectModel.Model2.Assemblies.Interfaces.IAssemblyToAssemblyReference value, JetBrains.CommonControls.IPresentableItem item, JetBrains.TreeModels.TreeModelNode modelNode, JetBrains.UI.TreeView.PresentationState state) { }
        protected virtual void PresentDeclaredElement(JetBrains.ReSharper.Psi.IDeclaredElement value, JetBrains.CommonControls.IPresentableItem item, JetBrains.TreeModels.TreeModelNode modelNode, JetBrains.UI.TreeView.PresentationState state) { }
        protected virtual void PresentDeclaredElement(JetBrains.ReSharper.Psi.IDeclaredElement value, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution, JetBrains.CommonControls.IPresentableItem item, JetBrains.TreeModels.TreeModelNode modelNode, JetBrains.UI.TreeView.PresentationState state) { }
        protected virtual void PresentDeclaredElementEnvoy(JetBrains.ReSharper.Psi.IDeclaredElementEnvoy value, JetBrains.CommonControls.IPresentableItem item, JetBrains.TreeModels.TreeModelNode modelNode, JetBrains.UI.TreeView.PresentationState state) { }
        protected virtual void PresentExternalLibraries(JetBrains.ReSharper.Features.Shared.Occurences.ExternalLibrariesNodeValue value, JetBrains.CommonControls.IPresentableItem item, JetBrains.TreeModels.TreeModelNode modelNode, JetBrains.UI.TreeView.PresentationState state) { }
        protected virtual void PresentFileSystemPath(JetBrains.Util.FileSystemPath value, JetBrains.CommonControls.IPresentableItem item, JetBrains.TreeModels.TreeModelNode modelNode, JetBrains.UI.TreeView.PresentationState state) { }
        protected virtual void PresentModuleReference(JetBrains.ProjectModel.IProjectToModuleReference value, JetBrains.CommonControls.IPresentableItem item, JetBrains.TreeModels.TreeModelNode modelNode, JetBrains.UI.TreeView.PresentationState state) { }
        protected virtual void PresentNamespace(JetBrains.ReSharper.Psi.INamespace value, JetBrains.CommonControls.IPresentableItem item, JetBrains.TreeModels.TreeModelNode modelNode, JetBrains.UI.TreeView.PresentationState state) { }
        protected virtual void PresentObject(object value, JetBrains.CommonControls.IPresentableItem item, JetBrains.TreeModels.TreeModelNode modelNode, JetBrains.UI.TreeView.PresentationState state) { }
        protected virtual void PresentProjectItem(JetBrains.ProjectModel.IProjectItem value, JetBrains.CommonControls.IPresentableItem item, JetBrains.TreeModels.TreeModelNode modelNode, JetBrains.UI.TreeView.PresentationState state) { }
        protected virtual void PresentProjectItemEnvoy(JetBrains.ProjectModel.ProjectModelElementEnvoy value, JetBrains.CommonControls.IPresentableItem item, JetBrains.TreeModels.TreeModelNode modelNode, JetBrains.UI.TreeView.PresentationState state) { }
        protected virtual void PresentSection(JetBrains.TreeModels.TreeSection value, JetBrains.CommonControls.IPresentableItem item, JetBrains.TreeModels.TreeModelNode modelNode, JetBrains.UI.TreeView.PresentationState state) { }
        protected virtual void PresentSeparator(JetBrains.TreeModels.TreeSeparator value, JetBrains.CommonControls.IPresentableItem item, JetBrains.TreeModels.TreeModelNode modelNode, JetBrains.UI.TreeView.PresentationState state) { }
        protected virtual void PresentSpecialElement(JetBrains.Util.Pair<object, JetBrains.ReSharper.Feature.Services.Search.ISpecialElementFinder> value, JetBrains.CommonControls.IPresentableItem item, JetBrains.TreeModels.TreeModelNode structureElement, JetBrains.UI.TreeView.PresentationState state) { }
        protected virtual void PresentTypeElement(JetBrains.ReSharper.Psi.ITypeElement value, JetBrains.CommonControls.IPresentableItem item, JetBrains.TreeModels.TreeModelNode modelNode, JetBrains.UI.TreeView.PresentationState state) { }
        protected virtual void PresentTypeElement(JetBrains.ReSharper.Psi.ITypeElement value, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution, JetBrains.CommonControls.IPresentableItem item, JetBrains.TreeModels.TreeModelNode modelNode, JetBrains.UI.TreeView.PresentationState state) { }
        protected virtual void PresentTypeMember(JetBrains.ReSharper.Psi.ITypeMember value, JetBrains.CommonControls.IPresentableItem item, JetBrains.TreeModels.TreeModelNode modelNode, JetBrains.UI.TreeView.PresentationState state) { }
        protected virtual void PresentTypeMember(JetBrains.ReSharper.Psi.ITypeMember value, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution, JetBrains.CommonControls.IPresentableItem item, JetBrains.TreeModels.TreeModelNode modelNode, JetBrains.UI.TreeView.PresentationState state) { }
        protected virtual void PresentTypeOwner(JetBrains.ReSharper.Psi.ITypeOwner value, JetBrains.CommonControls.IPresentableItem item, JetBrains.TreeModels.TreeModelNode modelNode, JetBrains.UI.TreeView.PresentationState state) { }
        protected virtual void PresentTypeOwner(JetBrains.ReSharper.Psi.ITypeOwner value, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution, JetBrains.CommonControls.IPresentableItem item, JetBrains.TreeModels.TreeModelNode modelNode, JetBrains.UI.TreeView.PresentationState state) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        protected virtual object Unwrap(object value) { }
        public override void UpdateItem(object value, JetBrains.TreeModels.TreeModelNode structureElement, JetBrains.CommonControls.IPresentableItem item, JetBrains.UI.TreeView.PresentationState state) { }
    }
}
namespace JetBrains.ReSharper.Features.Shared.UnitTesting
{
    
    public interface IUnitTestingCategoriesAttributeProvider
    {
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IClrTypeName> CategoryAttributes { get; }
    }
    public interface IUnitTestingCategoriesProvider
    {
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IClrTypeName> AttributeTypes { get; }
        System.Collections.Generic.IEnumerable<string> Categories { get; }
        JetBrains.UI.Icons.IconId Image { get; }
    }
}
namespace JetBrains.ReSharper.Features.Shared.Util
{
    
    public abstract class DeclaredElementCandidatesNavigator
    {
        public abstract void ExecuteCandidatesWithContext(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IDeclaredElement> candidates, JetBrains.Application.DataContext.IDataContext dataContext, JetBrains.ReSharper.Psi.Services.CandidatesUtil.DeclaredElementExecutor executor, JetBrains.ReSharper.Features.Shared.Util.DeclaredElementCandidatesNavigatorImpl.DescriptorModifier modifier = null);
        public abstract void ExecuteCandidatesWithContext(System.Collections.Generic.IEnumerable<JetBrains.Util.JetTuple<JetBrains.ReSharper.Psi.IDeclaredElement, JetBrains.ReSharper.Psi.Services.CandidatesUtil.DeclaredElementExecutor>> elementExecutorPairs, JetBrains.Application.DataContext.IDataContext context, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Services.CandidatesUtil.MultiplyDeclaredElementExecutor multiplyExecutor, JetBrains.ReSharper.Features.Shared.Util.DeclaredElementCandidatesNavigatorImpl.DescriptorModifier modifier = null);
        public abstract void ExecuteCandidatesWithContext(System.Collections.Generic.IEnumerable<JetBrains.Util.JetTuple<JetBrains.ReSharper.Psi.IDeclaredElement, JetBrains.ReSharper.Psi.Services.CandidatesUtil.DeclaredElementExecutor>> elementExecutorPairs, JetBrains.Application.DataContext.IDataContext context, JetBrains.ReSharper.Features.Shared.Util.DeclaredElementCandidatesNavigatorImpl.DescriptorModifier modifier = null);
        public static JetBrains.ReSharper.Features.Shared.Util.DeclaredElementCandidatesNavigator GetInstance(JetBrains.ProjectModel.ISolution solution) { }
        public static void PromoteAndExecute(JetBrains.Application.DataContext.IDataContext dataContext, bool promoteDeclaredElement, JetBrains.Util.JetTuple<JetBrains.ReSharper.Psi.IDeclaredElement, JetBrains.ReSharper.Psi.Services.CandidatesUtil.DeclaredElementExecutor> candidate) { }
        public static JetBrains.ReSharper.Psi.IDeclaredElement PromoteDeclaredElement(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class DeclaredElementCandidatesNavigatorImpl : JetBrains.ReSharper.Features.Shared.Util.DeclaredElementCandidatesNavigator
    {
        public DeclaredElementCandidatesNavigatorImpl([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.UI.Application.IUIApplication environment) { }
        public override void ExecuteCandidatesWithContext(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IDeclaredElement> candidates, JetBrains.Application.DataContext.IDataContext dataContext, JetBrains.ReSharper.Psi.Services.CandidatesUtil.DeclaredElementExecutor executor, JetBrains.ReSharper.Features.Shared.Util.DeclaredElementCandidatesNavigatorImpl.DescriptorModifier modifier = null) { }
        public void ExecuteCandidatesWithContext(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IDeclaredElement> candidates, JetBrains.Application.DataContext.IDataContext context, JetBrains.ReSharper.Psi.Services.CandidatesUtil.MultiplyDeclaredElementExecutor executor, JetBrains.ReSharper.Features.Shared.Util.DeclaredElementCandidatesNavigatorImpl.DescriptorModifier modifier = null) { }
        public void ExecuteCandidatesWithContext(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IDeclaredElement> candidates, JetBrains.Application.DataContext.IDataContext context, bool allowMultiply, JetBrains.ReSharper.Psi.Services.CandidatesUtil.MultiplyDeclaredElementExecutor executor, JetBrains.ReSharper.Features.Shared.Util.DeclaredElementCandidatesNavigatorImpl.DescriptorModifier modifier = null) { }
        public override void ExecuteCandidatesWithContext(System.Collections.Generic.IEnumerable<JetBrains.Util.JetTuple<JetBrains.ReSharper.Psi.IDeclaredElement, JetBrains.ReSharper.Psi.Services.CandidatesUtil.DeclaredElementExecutor>> elementExecutorPairs, JetBrains.Application.DataContext.IDataContext context, JetBrains.ReSharper.Features.Shared.Util.DeclaredElementCandidatesNavigatorImpl.DescriptorModifier modifier = null) { }
        public override void ExecuteCandidatesWithContext(System.Collections.Generic.IEnumerable<JetBrains.Util.JetTuple<JetBrains.ReSharper.Psi.IDeclaredElement, JetBrains.ReSharper.Psi.Services.CandidatesUtil.DeclaredElementExecutor>> elementExecutorPairs, JetBrains.Application.DataContext.IDataContext context, JetBrains.ReSharper.Psi.Services.CandidatesUtil.MultiplyDeclaredElementExecutor multiplyExecutor, JetBrains.ReSharper.Features.Shared.Util.DeclaredElementCandidatesNavigatorImpl.DescriptorModifier modifier = null) { }
        public static JetBrains.UI.RichText.RichText GetModuleDescription(JetBrains.ReSharper.Psi.Modules.IPsiModule module) { }
        public delegate void DescriptorModifier(JetBrains.UI.PopupMenu.IMenuItemDescriptor descriptor, JetBrains.ReSharper.Psi.IDeclaredElement elementToDisplay);
    }
}