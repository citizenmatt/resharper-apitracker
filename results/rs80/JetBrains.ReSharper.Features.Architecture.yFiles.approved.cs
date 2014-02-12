[assembly: JetBrains.Application.Install.InstallFileAttribute("yFilesAlgorithms", JetBrains.Application.Install.InstallationData.InstallationTargetDirRoot.InstallDir, "", JetBrains.Application.Install.InstallationData.InstallationSourceDirRoot2.ProductBinariesDir, "yWorks.yFilesWPF.Viewer.dll")]
[assembly: JetBrains.Application.Install.InstallFileAttribute("yFilesViewer", JetBrains.Application.Install.InstallationData.InstallationTargetDirRoot.InstallDir, "", JetBrains.Application.Install.InstallationData.InstallationSourceDirRoot2.ProductBinariesDir, "yWorks.yFilesWPF.Adapter.dll")]
[assembly: JetBrains.Application.Install.InstallFileAttribute("yFilesAdapter", JetBrains.Application.Install.InstallationData.InstallationTargetDirRoot.InstallDir, "", JetBrains.Application.Install.InstallationData.InstallationSourceDirRoot2.ProductBinariesDir, "yWorks.yFilesWPF.Algorithms.dll")]
[assembly: JetBrains.UI.Icons.CompiledIcons.CompiledIconsPackAttribute(IconNames=new string[] {
        "ArchScrollDown",
        "ZoomOut",
        "MetricDisplay",
        "ExpandGraph",
        "GraphDiff",
        "ScrollLeft",
        "CollapseGraph",
        "TransitiveEdges",
        "ZoomIn",
        "ScrollRight",
        "ArchScrollUp",
        "SaveGraph"}, IconPackResourceIdentification="JetBrains.ReSharper.Features.Architecture.yFiles;component/resources/Architecture" +
    "ToolIcons/ThemedIcons.ArchitectureTool.Generated.Xaml")]
[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]
[assembly: System.Runtime.Versioning.TargetFrameworkAttribute(".NETFramework,Version=v4.0", FrameworkDisplayName=".NET Framework 4")]
[assembly: System.Windows.Markup.XmlnsDefinitionAttribute("urn:shemas-jetbrains-com:ui-application-icons-architecture-tool", "JetBrains.ReSharper.Features.Architecture.yFiles.Resources")]

namespace Demo.yFiles.Graph.SimpleEditor
{
    
    public class HighlightEdgeStyle : yWorks.yFiles.UI.Drawing.jbloajbggadfhtmfcarqkfb<System.Windows.Media.Visual>
    {
        public HighlightEdgeStyle() { }
        protected override System.Windows.Media.Visual CreateVisual(yWorks.yFiles.UI.Model.lpnfr edge, yWorks.Canvas.Drawing.hokctldoapmjgd renderContext) { }
        protected override System.Windows.Media.Visual UpdateVisual(yWorks.yFiles.UI.Model.lpnfr edge, yWorks.Canvas.Drawing.hokctldoapmjgd renderContext, System.Windows.Media.Visual oldVisual) { }
    }
    public class ItemHoverInputMode : yWorks.Canvas.Input.moblnkmketcrqtehklhlkosrhcc
    {
        public ItemHoverInputMode() { }
        public yWorks.yFiles.UI.Model.GraphItemTypes HoverItems { get; set; }
        public event Demo.yFiles.Graph.SimpleEditor.MouseHoverEvent ItemHover;
        public override void Install(yWorks.Canvas.Input.nckoqgqsnfitggbkm context) { }
    }
    public delegate void MouseHoverEvent(object sender, Demo.yFiles.Graph.SimpleEditor.MouseHoverEventArgs args);
    public class MouseHoverEventArgs : System.EventArgs
    {
        public MouseHoverEventArgs(yWorks.Canvas.Model.margcjbioi modelItem, yWorks.Canvas.Model.margcjbioi oldItem) { }
        [yWorks.Support.Annotations.CanBeNullAttribute()]
        public yWorks.Canvas.Model.margcjbioi Item { get; }
        [yWorks.Support.Annotations.CanBeNullAttribute()]
        public yWorks.Canvas.Model.margcjbioi OldItem { get; }
    }
}
namespace JetBrains.ReSharper.Features.Architecture.yFiles.Actions
{
    
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "CollapseGraph"})]
    public class CollapseGraphAction : JetBrains.ActionManagement.IActionHandler
    {
        public void Execute(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.DelegateExecute nextExecute) { }
        public bool Update(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.ActionPresentation presentation, JetBrains.ActionManagement.DelegateUpdate nextUpdate) { }
    }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "CouplingCalculationEnabled"})]
    public class CouplingCalculationEnabledAction : JetBrains.ActionManagement.IActionHandler
    {
        public void Execute(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.DelegateExecute nextExecute) { }
        public bool Update(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.ActionPresentation presentation, JetBrains.ActionManagement.DelegateUpdate nextUpdate) { }
    }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "ExpandGraph"})]
    public class ExpandGraphAction : JetBrains.ActionManagement.IActionHandler
    {
        public void Execute(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.DelegateExecute nextExecute) { }
        public bool Update(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.ActionPresentation presentation, JetBrains.ActionManagement.DelegateUpdate nextUpdate) { }
    }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "ExportToPicture"})]
    public class ExportToPictureAction : JetBrains.ActionManagement.IActionHandler
    {
        public void Execute(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.DelegateExecute nextExecute) { }
        public bool Update(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.ActionPresentation presentation, JetBrains.ActionManagement.DelegateUpdate nextUpdate) { }
    }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "HideTransitiveClosure"})]
    public class HideTransitiveClosure : JetBrains.ActionManagement.IActionHandler
    {
        public void Execute(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.DelegateExecute nextExecute) { }
        public bool Update(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.ActionPresentation presentation, JetBrains.ActionManagement.DelegateUpdate nextUpdate) { }
    }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "OpenArchitectureGraph"})]
    public class OpenArchitectureGraphAction : JetBrains.ActionManagement.IActionHandler
    {
        public void Execute(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.DelegateExecute nextExecute) { }
        public bool Update(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.ActionPresentation presentation, JetBrains.ActionManagement.DelegateUpdate nextUpdate) { }
    }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "SaveArchitectureGraph"})]
    public class SaveArchitectureGraphAction : JetBrains.ActionManagement.IActionHandler
    {
        public void Execute(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.DelegateExecute nextExecute) { }
        public bool Update(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.ActionPresentation presentation, JetBrains.ActionManagement.DelegateUpdate nextUpdate) { }
    }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "ShowDiff"})]
    public class ShowDiffAction : JetBrains.ActionManagement.IActionHandler
    {
        public void Execute(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.DelegateExecute nextExecute) { }
        public bool Update(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.ActionPresentation presentation, JetBrains.ActionManagement.DelegateUpdate nextUpdate) { }
    }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "ShowOnlySelected"})]
    public class ShowOnlySelectedItemsAction : JetBrains.ActionManagement.IActionHandler
    {
        public void Execute(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.DelegateExecute nextExecute) { }
        public bool Update(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.ActionPresentation presentation, JetBrains.ActionManagement.DelegateUpdate nextUpdate) { }
    }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "ShowThisAndDependent"})]
    public class ShowThisAndDependentAction : JetBrains.ActionManagement.IActionHandler
    {
        public void Execute(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.DelegateExecute nextExecute) { }
        public bool Update(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.ActionPresentation presentation, JetBrains.ActionManagement.DelegateUpdate nextUpdate) { }
    }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "ShowThisAndReferenced"})]
    public class ShowThisAndReferencedAction : JetBrains.ActionManagement.IActionHandler
    {
        public void Execute(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.DelegateExecute nextExecute) { }
        public bool Update(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.ActionPresentation presentation, JetBrains.ActionManagement.DelegateUpdate nextUpdate) { }
    }
}
namespace JetBrains.ReSharper.Features.Architecture.yFiles
{
    
    [JetBrains.Application.ShellComponentAttribute()]
    public class ArchitectureGraphViewer
    {
        public static readonly JetBrains.Application.DataContext.DataConstant<JetBrains.ReSharper.Features.Architecture.yFiles.Toolbox.ArchitectureToolboxDescriptor> ArchitectureToolboxDescriptor;
        protected virtual JetBrains.ReSharper.Features.Architecture.yFiles.Graph.YFilesArchitectureGraphDescriptor CreateGraphDescriptor(JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IArchitecturePersistentGraph persistentGraph, JetBrains.ActionManagement.IActionManager actionManager, JetBrains.ReSharper.Features.Architecture.yFiles.Graph.YFilesGraphWrapper yFilesGraphWrapper, JetBrains.DataFlow.LifetimeDefinition lifetimeDefinition) { }
        protected virtual JetBrains.ReSharper.Features.Architecture.yFiles.Toolbox.ArchitectureToolboxDescriptor CreateToolboxDescriptor(JetBrains.ReSharper.Features.Architecture.yFiles.Graph.YFilesArchitectureGraphDescriptor graphDescriptor, JetBrains.ProjectModel.ISolution solution) { }
        protected virtual JetBrains.ReSharper.Features.Architecture.yFiles.Graph.YFilesGraphWrapper CreateYFilesWrapper(JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IArchitectureViewGraph viewGraph, JetBrains.DataFlow.Lifetime lifetime) { }
        public virtual void Open([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IArchitecturePersistentGraph persistentGraph) { }
        public virtual JetBrains.ReSharper.Features.Architecture.yFiles.Toolbox.ArchitectureToolboxDescriptor OpenFromSolution([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IArchitecturePersistentGraph persistentGraph, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.ISolution solution, [JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.List<JetBrains.ProjectModel.IProject> selectedProjects) { }
        protected virtual void OpenTabView(JetBrains.ProjectModel.ISolution solution, System.Collections.Generic.List<JetBrains.ProjectModel.IProject> selectedProjects, JetBrains.ReSharper.Features.Architecture.yFiles.Graph.YFilesArchitectureGraphDescriptor descriptor, JetBrains.ReSharper.Features.Architecture.yFiles.Toolbox.ArchitectureGrid gridControl, JetBrains.ReSharper.Features.Architecture.yFiles.Toolbox.ArchitectureToolBoxPanelWPF toolBoxView) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class GraphSynchronizer : JetBrains.Application.IChangeProvider
    {
        public GraphSynchronizer(JetBrains.Application.ChangeManager changeManager, JetBrains.DataFlow.Lifetime lifetime, JetBrains.ProjectModel.ISolution solution) { }
        public object Execute(JetBrains.Application.IChangeMap changeMap) { }
        public void Subscribe(JetBrains.ReSharper.Features.Architecture.yFiles.Toolbox.ArchitectureToolboxDescriptor descriptor) { }
        public void UnSubscribe(JetBrains.ReSharper.Features.Architecture.yFiles.Toolbox.ArchitectureToolboxDescriptor descriptor) { }
    }
}
namespace JetBrains.ReSharper.Features.Architecture.yFiles.CodeMetrics
{
    
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class CodeMetricsManager
    {
        public CodeMetricsManager(JetBrains.ProjectModel.ISolution solution) { }
        public virtual void CalculateCoupling(JetBrains.ReSharper.Features.Architecture.yFiles.Toolbox.ArchitectureToolboxDescriptor architectureToolboxDescriptor) { }
        protected virtual void UpdateReferences(JetBrains.ReSharper.Features.Architecture.yFiles.Toolbox.ArchitectureToolboxDescriptor descriptor, JetBrains.ReSharper.Features.Architecture.yFiles.CodeMetrics.ProjectReferencesCoupling couplingData) { }
    }
    public class CouplingHelper : JetBrains.ReSharper.Psi.IAsyncCommitClient
    {
        public JetBrains.DataFlow.ISignal<bool> Done;
        public JetBrains.DataFlow.ISignal<bool> Interrupted;
        public JetBrains.DataFlow.ISignal<JetBrains.ReSharper.Features.Architecture.yFiles.CodeMetrics.ProjectReferencesCoupling> ProjectCalculationFinished;
        public JetBrains.DataFlow.ISignal<JetBrains.ProjectModel.IProject> ProjectIsBeingAnalyzed;
        public CouplingHelper([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.ISolution solution, JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.IShellLocks locks, JetBrains.ReSharper.Features.Architecture.yFiles.Toolbox.ArchitectureToolboxDescriptor owner) { }
        public System.Action BeforeCommit() { }
        public void CalculateCoupling(System.Collections.Generic.IEnumerable<JetBrains.ProjectModel.IProject> projects) { }
        public void OnInterrupt() { }
        public void Stop() { }
    }
    public class ProjectReferencesCoupling
    {
        public ProjectReferencesCoupling(JetBrains.ProjectModel.IProject owner) { }
        public JetBrains.ProjectModel.IProject Owner { get; }
        public System.Collections.Generic.Dictionary<JetBrains.ProjectModel.IProject, int> ReferencesWeight { get; }
        public void Increment(JetBrains.ProjectModel.IProject referencedProject) { }
    }
    public class ReferencesWeightConsumer : JetBrains.ReSharper.Feature.Services.Search.SearchResultsConsumer
    {
        public ReferencesWeightConsumer(JetBrains.ProjectModel.IProject project) { }
        public JetBrains.ReSharper.Features.Architecture.yFiles.CodeMetrics.ProjectReferencesCoupling CalculatedCoupling { get; }
        public override JetBrains.ReSharper.Feature.Services.Search.IOccurence Build(JetBrains.ReSharper.Psi.Search.FindResult result) { }
    }
}
namespace JetBrains.ReSharper.Features.Architecture.yFiles.Graph
{
    
    public class GroupNodeControl : yWorks.yFiles.UI.Drawing.NodeControl
    {
        public GroupNodeControl(System.Windows.Media.SolidColorBrush backgroundBrush) { }
        public System.Windows.Media.SolidColorBrush BackgroundBrush { get; set; }
    }
    public class GroupNodeControlStyle : yWorks.yFiles.UI.Drawing.NodeControlNodeStyle, System.ICloneable, yWorks.Canvas.Model.rnkrraalpktkdmkjhhf<yWorks.yFiles.UI.Model.INode>, yWorks.yFiles.UI.Drawing.anjhjelslsnc<yWorks.yFiles.UI.Model.INode>, yWorks.yFiles.UI.Drawing.ejntrdlsjq, yWorks.yFiles.UI.Drawing.ihjeekgdarliacnc<yWorks.yFiles.UI.Model.INode>, yWorks.yFiles.UI.Drawing.saggalnahlalljjfktiqt
    {
        public GroupNodeControlStyle(string groupNodeTemplate, System.Windows.Media.SolidColorBrush brush) { }
        public yWorks.yFiles.UI.Drawing.NodeControl CreateControl(yWorks.Canvas.Drawing.hokctldoapmjgd ctx, yWorks.yFiles.UI.Model.INode node) { }
    }
    public class YFilesArchitectureGraphDescriptor
    {
        public YFilesArchitectureGraphDescriptor(JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IArchitecturePersistentGraph persistentGraph, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Features.Architecture.yFiles.Graph.YFilesGraphWrapper yFilesGraphWrapper, JetBrains.ActionManagement.IActionManager actionManager, JetBrains.DataFlow.IViewable<JetBrains.ProjectModel.ISolution> solutions, JetBrains.DataFlow.LifetimeDefinition lifetimeDefinition) { }
        public JetBrains.DataFlow.IProperty<JetBrains.UI.Icons.IconId> Image { get; }
        public JetBrains.DataFlow.LifetimeDefinition LifetimeDefinition { get; }
        public JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IArchitecturePersistentGraph PersistentGraph { get; }
        public JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IArchitectureViewGraph ViewGraph { get; }
        public System.Windows.Controls.Control YFilesControl { get; }
        public JetBrains.ReSharper.Features.Architecture.yFiles.Graph.YFilesGraphWrapper YFilesGraphWrapper { get; }
    }
    public class YFilesGraphWrapper
    {
        protected static System.Windows.Media.Color DarkGroupInDark;
        protected static System.Windows.Media.Color DarkGroupInLight;
        protected string FamilyName;
        protected static int GroupNodeHeight;
        public JetBrains.DataFlow.ISignal<bool> ItemDeletedSignal;
        protected static System.Windows.Media.Color LightGroupInDark;
        protected static System.Windows.Media.Color LightGroupInLight;
        public YFilesGraphWrapper(JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IArchitectureViewGraph graph, JetBrains.DataFlow.Lifetime lifetime) { }
        protected yWorks.yFiles.UI.Drawing.ejntrdlsjq AssemblyNodeStyle { get; set; }
        protected yWorks.yFiles.UI.Drawing.qiktgtmsfj DefaultEdgeStyle { get; set; }
        public JetBrains.Threading.GroupingEvent DoLayoutGroupingEvent { get; }
        protected yWorks.yFiles.UI.Drawing.qiktgtmsfj FadedEdgesStyle { get; set; }
        protected yWorks.yFiles.UI.Drawing.kafmlcflcnj FadedNewNodeLabelStyle { get; set; }
        protected yWorks.yFiles.UI.Drawing.ejntrdlsjq FadedNewNodeStyle { get; set; }
        protected yWorks.yFiles.UI.Drawing.kafmlcflcnj FadedNodeLabelStyle { get; set; }
        protected yWorks.yFiles.UI.Drawing.ejntrdlsjq FadedNodeStyle { get; set; }
        protected yWorks.yFiles.UI.Drawing.kafmlcflcnj FadedRemovedNodeLabelStyle { get; set; }
        protected yWorks.yFiles.UI.Drawing.ejntrdlsjq FadedRemovedNodeStyle { get; set; }
        public yWorks.yFiles.UI.Model.lagtfq FullGraph { get; }
        public JetBrains.ReSharper.Features.Architecture.yFiles.src.UI.GraphControlWindow GraphControlWindow { get; }
        protected yWorks.yFiles.UI.Drawing.kafmlcflcnj GroupNodeLabelStyle { get; set; }
        protected yWorks.yFiles.UI.Drawing.ejntrdlsjq GroupNodeStyle { get; set; }
        protected yWorks.yFiles.UI.Drawing.kafmlcflcnj HighlightedNewNodeLabelStyle { get; set; }
        protected yWorks.yFiles.UI.Drawing.ejntrdlsjq HighlightedNewNodeStyle { get; set; }
        protected yWorks.yFiles.UI.Drawing.kafmlcflcnj HighlightedNodeLabelStyle { get; set; }
        protected yWorks.yFiles.UI.Drawing.ejntrdlsjq HighlightedNodeStyle { get; set; }
        protected yWorks.yFiles.UI.Drawing.kafmlcflcnj HighlightedRemovedNodeLabelStyle { get; set; }
        protected yWorks.yFiles.UI.Drawing.ejntrdlsjq HighlightedRemovedNodeStyle { get; set; }
        public bool IsDarkTheme { get; }
        protected yWorks.yFiles.UI.Drawing.kafmlcflcnj ItemNodeLabelStyle { get; set; }
        protected yWorks.yFiles.UI.Drawing.qiktgtmsfj NewEdgesStyle { get; set; }
        protected yWorks.yFiles.UI.Drawing.kafmlcflcnj NewNodeLabelStyle { get; set; }
        protected yWorks.yFiles.UI.Drawing.ejntrdlsjq NewNodesStyle { get; set; }
        protected yWorks.yFiles.UI.Drawing.ejntrdlsjq ProcessingProjectStyle { get; set; }
        protected yWorks.yFiles.UI.Drawing.ejntrdlsjq ReferencedNodeStyle { get; set; }
        protected yWorks.yFiles.UI.Drawing.kafmlcflcnj ReferencesWeightStyle { get; set; }
        protected yWorks.yFiles.UI.Drawing.ejntrdlsjq RegularItemNodeStyle { get; set; }
        protected yWorks.yFiles.UI.Drawing.qiktgtmsfj RemovedEdgesStyle { get; set; }
        protected yWorks.yFiles.UI.Drawing.kafmlcflcnj RemovedNodeLabelStyle { get; set; }
        protected yWorks.yFiles.UI.Drawing.ejntrdlsjq RemovedNodesStyle { get; set; }
        protected yWorks.yFiles.UI.Drawing.qiktgtmsfj SelectedEdgeStyle { get; set; }
        protected yWorks.yFiles.UI.Drawing.ejntrdlsjq SelectedNodeStyle { get; set; }
        public bool ShowMetrics { get; set; }
        protected yWorks.yFiles.UI.Drawing.qiktgtmsfj UnusedEdgeStyle { get; set; }
        protected yWorks.yFiles.UI.Drawing.qiktgtmsfj UnusedFadedEdgeStyle { get; set; }
        public JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IArchitectureViewGraph ViewModelGraph { get; set; }
        protected virtual yWorks.Canvas.Geometry.Structs.RectD CalculateCollapsedGroupNodeSize(yWorks.yFiles.UI.Model.INode representative, JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IArchitectureGroupNode initialGroupNode) { }
        public void CollapseAll() { }
        protected virtual void DoLayout(System.Collections.Generic.List<yWorks.yFiles.UI.Model.INode> affectedNodes) { }
        public void ExpandAll() { }
        public void ExportToBmp(JetBrains.Util.FileSystemPath path) { }
        protected virtual void FoldGraph() { }
        protected virtual yWorks.yFiles.UI.Drawing.qiktgtmsfj GetEdgeStyle(JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IArchitectureGraphEdge edge, yWorks.yFiles.UI.Model.lpnfr yEdge) { }
        protected virtual yWorks.yFiles.UI.Drawing.kafmlcflcnj GetNodeLabelStyle(JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IArchitectureGraphElement node) { }
        protected virtual yWorks.yFiles.UI.Drawing.ejntrdlsjq GetNodeStyle(JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IArchitectureGraphElement node, yWorks.yFiles.UI.Model.INode yNode) { }
        public System.Collections.Generic.ICollection<JetBrains.ProjectModel.IModule> GetSelectedProjects([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.ISolution solution) { }
        public void HighlightAnalyzedProject(JetBrains.ProjectModel.IProject project) { }
        protected virtual void InitializeDiffStyles() { }
        protected virtual void InitializeEdgeStyle() { }
        protected virtual void InitializeFonts() { }
        protected virtual void InitializeGroupNodesStyle() { }
        protected virtual void InitializeInputMode() { }
        protected virtual void InitializeItemNodesStyle() { }
        protected virtual void InitializeLabelsStyle() { }
        protected virtual void InitializeLayouters() { }
        protected virtual void InitializeSnapping() { }
        protected virtual void ProcessEdgeHover(Demo.yFiles.Graph.SimpleEditor.MouseHoverEventArgs args) { }
        protected virtual void ProcessNodeHover(Demo.yFiles.Graph.SimpleEditor.MouseHoverEventArgs args) { }
        public void RefreshLayout() { }
        public void RefreshStyles(System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IArchitectureGraphElement> dataElements) { }
        public void RefreshStyles() { }
        public void Select(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IArchitectureGraphElement> graphElements) { }
        public void UpdateYFilesGraph(JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.GraphDiff graphDiff, bool showCodeMetrics) { }
    }
    public class YFilesToolWindowPopupContext : JetBrains.UI.PopupWindowManager.PopupWindowContext
    {
        public YFilesToolWindowPopupContext(yWorks.yFiles.UI.GraphControl graphControl, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ActionManagement.IActionManager actionManager, yWorks.Canvas.Geometry.Structs.PointD coords) { }
        public override JetBrains.UI.IPopupLayouter CreateLayouter(JetBrains.DataFlow.Lifetime lifetime) { }
    }
}
namespace JetBrains.ReSharper.Features.Architecture.yFiles.Resources
{
    
    public sealed class ArchitectureToolThemedIcons
    {
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Features.Architecture.yFiles;component/resources/Architecture" +
            "ToolIcons/ThemedIcons.ArchitectureTool.Generated.Xaml", 0, "ArchScrollDown")]
        public sealed class ArchScrollDown : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Features.Architecture.yFiles;component/resources/Architecture" +
            "ToolIcons/ThemedIcons.ArchitectureTool.Generated.Xaml", 10, "ArchScrollUp")]
        public sealed class ArchScrollUp : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Features.Architecture.yFiles;component/resources/Architecture" +
            "ToolIcons/ThemedIcons.ArchitectureTool.Generated.Xaml", 6, "CollapseGraph")]
        public sealed class CollapseGraph : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Features.Architecture.yFiles;component/resources/Architecture" +
            "ToolIcons/ThemedIcons.ArchitectureTool.Generated.Xaml", 3, "ExpandGraph")]
        public sealed class ExpandGraph : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Features.Architecture.yFiles;component/resources/Architecture" +
            "ToolIcons/ThemedIcons.ArchitectureTool.Generated.Xaml", 4, "GraphDiff")]
        public sealed class GraphDiff : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Features.Architecture.yFiles;component/resources/Architecture" +
            "ToolIcons/ThemedIcons.ArchitectureTool.Generated.Xaml", 2, "MetricDisplay")]
        public sealed class MetricDisplay : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Features.Architecture.yFiles;component/resources/Architecture" +
            "ToolIcons/ThemedIcons.ArchitectureTool.Generated.Xaml", 11, "SaveGraph")]
        public sealed class SaveGraph : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Features.Architecture.yFiles;component/resources/Architecture" +
            "ToolIcons/ThemedIcons.ArchitectureTool.Generated.Xaml", 5, "ScrollLeft")]
        public sealed class ScrollLeft : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Features.Architecture.yFiles;component/resources/Architecture" +
            "ToolIcons/ThemedIcons.ArchitectureTool.Generated.Xaml", 9, "ScrollRight")]
        public sealed class ScrollRight : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Features.Architecture.yFiles;component/resources/Architecture" +
            "ToolIcons/ThemedIcons.ArchitectureTool.Generated.Xaml", 7, "TransitiveEdges")]
        public sealed class TransitiveEdges : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Features.Architecture.yFiles;component/resources/Architecture" +
            "ToolIcons/ThemedIcons.ArchitectureTool.Generated.Xaml", 8, "ZoomIn")]
        public sealed class ZoomIn : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Features.Architecture.yFiles;component/resources/Architecture" +
            "ToolIcons/ThemedIcons.ArchitectureTool.Generated.Xaml", 1, "ZoomOut")]
        public sealed class ZoomOut : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
    }
}
namespace JetBrains.ReSharper.Features.Architecture.yFiles.src.UI
{
    
    public class GraphControlWindow : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector
    {
        public GraphControlWindow() { }
        public void InitializeComponent() { }
    }
    [System.Windows.Data.ValueConversionAttribute(typeof(double), typeof(double))]
    public class ZoomConverter : System.Windows.Data.IValueConverter
    {
        public object Convert(object value, System.Type targetType, object parameter, System.Globalization.CultureInfo culture) { }
        public object ConvertBack(object value, System.Type targetType, object parameter, System.Globalization.CultureInfo culture) { }
    }
}
namespace JetBrains.ReSharper.Features.Architecture.yFiles.Toolbox
{
    
    public class ArchitectureGrid : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector
    {
        public ArchitectureGrid() { }
        public void InitializeComponent() { }
    }
    public class ArchitectureToolboxDescriptor : JetBrains.ReSharper.Features.Common.Occurences.OccurenceBrowserDescriptor
    {
        public ArchitectureToolboxDescriptor(JetBrains.ReSharper.Features.Architecture.yFiles.Graph.YFilesArchitectureGraphDescriptor graphDescriptor, JetBrains.ProjectModel.ISolution solution) { }
        public override string ActionBarID { get; }
        public override string ContextMenuID { get; }
        public bool CouplingCalculationEnabled { get; set; }
        public JetBrains.ReSharper.Features.Architecture.yFiles.CodeMetrics.CouplingHelper CouplingHelper { get; }
        protected override int DefaultGroupingIndex { get; set; }
        public JetBrains.ReSharper.Features.Architecture.yFiles.Graph.YFilesArchitectureGraphDescriptor GraphDescriptor { get; }
        public bool IncludeTransitive { get; set; }
        public bool IsBinded { get; }
        public override JetBrains.TreeModels.TreeModel Model { get; }
        public bool ShowPersistentDiff { get; set; }
        public void CheckOnlySelected() { }
        public void CheckSelectedAndDependent() { }
        public void CheckSelectedAndReferenced() { }
        public System.Collections.Generic.List<JetBrains.ProjectModel.IModule> GetCheckedProjects() { }
        protected virtual JetBrains.ReSharper.Feature.Services.ArchitectureModel.Manager.GraphInputSettings GetUserInput(System.Collections.Generic.List<JetBrains.ProjectModel.IModule> scope) { }
        protected override void GroupChangeCommitted(object sender, System.EventArgs e) { }
        public override bool Navigate(JetBrains.TreeModels.TreeModelNode node, JetBrains.UI.PopupWindowManager.PopupWindowContextSource windowContext, bool transferFocus, JetBrains.IDE.TabOptions options = 2) { }
        protected internal void RebindToSolution(JetBrains.ProjectModel.ISolution solution) { }
        public void SaveCurrentGraph(JetBrains.Util.FileSystemPath path) { }
        public void SetCheckedProjects(System.Collections.Generic.List<JetBrains.ProjectModel.IModule> value, bool fireEvent = True) { }
    }
    public class ArchitectureToolBoxPanel : JetBrains.IDE.TreeBrowser.TreeModelBrowserPanel
    {
        public ArchitectureToolBoxPanel(JetBrains.IDE.TreeBrowser.TreeModelBrowserDescriptor descriptor, JetBrains.UI.Application.IUIApplication environment) { }
        public JetBrains.ReSharper.Features.Architecture.yFiles.Toolbox.ArchitectureToolboxDescriptor ToolboxDescriptor { get; }
        public void CheckItems(System.Predicate<JetBrains.ReSharper.Feature.Services.Search.IOccurence> setChecked) { }
        public void CheckOnlySelectedItems() { }
        protected override JetBrains.ActionManagement.IActionBar CreateActionBar(JetBrains.ActionManagement.IActionBarManager actionBarManager, string actionID) { }
        protected override JetBrains.UI.TreeView.TreeModelPresentableView CreateView(JetBrains.TreeModels.TreeModel treeModel) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.Search.IOccurence> GetCheckedItems() { }
        protected virtual System.Collections.Generic.List<JetBrains.ProjectModel.IModule> GetScope() { }
        protected override bool Navigate(JetBrains.TreeModels.TreeModelNode node, bool transferFocus, JetBrains.IDE.TabOptions options = 2) { }
    }
    public class ArchitectureToolBoxPanelWPF : JetBrains.IDE.TreeGridBrowser.TreeGridBrowserPanel
    {
        public ArchitectureToolBoxPanelWPF(JetBrains.IDE.TreeBrowser.TreeModelBrowserDescriptor descriptor, JetBrains.DataFlow.Lifetime lifetime, JetBrains.UI.Application.IUIApplication environment, JetBrains.ActionManagement.IActionBarManager actionBarManager) { }
        public JetBrains.ReSharper.Features.Architecture.yFiles.Toolbox.ArchitectureToolboxDescriptor ToolboxDescriptor { get; }
        public void CheckItems(System.Predicate<JetBrains.ReSharper.Feature.Services.Search.IOccurence> setChecked) { }
        public void CheckOnlySelected() { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.Search.IOccurence> GetCheckedItems() { }
        protected virtual System.Collections.Generic.List<JetBrains.ProjectModel.IModule> GetScope() { }
        protected override bool Navigate(JetBrains.TreeModels.TreeModelNode node, bool transferFocus, JetBrains.IDE.TabOptions options = 2) { }
    }
    [JetBrains.Application.Settings.SettingsKeyAttribute(typeof(JetBrains.UI.UserInterfaceSettings), "Architecture view settings")]
    public class ArchitectureViewSettings
    {
        [JetBrains.Application.Settings.SettingsEntryAttribute(1, "Group by")]
        public int GroupingIndex;
    }
}
namespace JetBrains.ReSharper.Features.Architecture.yFiles.Toolbox.TreeGrouping
{
    
    public class ContainingSolutionFolderProvider : JetBrains.TreeModels.ITreeGroupProvider<JetBrains.ReSharper.Feature.Services.Search.IOccurence>
    {
        public ContainingSolutionFolderProvider(JetBrains.ProjectModel.ISolution solution) { }
        public object ExtractGroupObject(JetBrains.ReSharper.Feature.Services.Search.IOccurence item) { }
    }
    public class FileStructreProvider : JetBrains.TreeModels.ITreeGroupProvider<JetBrains.ReSharper.Feature.Services.Search.IOccurence>
    {
        public FileStructreProvider(JetBrains.ProjectModel.ISolution solution) { }
        public object ExtractGroupObject(JetBrains.ReSharper.Feature.Services.Search.IOccurence item) { }
    }
    [JetBrains.ReSharper.Psi.ShellFeaturePartAttribute()]
    public class ToolboxGroupingProvider : JetBrains.ReSharper.Features.Common.Occurences.OccurenceBrowserGroupingProvider
    {
        public override System.Collections.Generic.ICollection<JetBrains.TreeModels.TreeModelGrouping<JetBrains.ReSharper.Feature.Services.Search.IOccurence>> GetGroupings(JetBrains.IDE.TreeBrowser.TreeModelBrowserDescriptorBase descriptor) { }
        public override bool IsApplicable(JetBrains.IDE.TreeBrowser.TreeModelBrowserDescriptorBase descriptor) { }
    }
}