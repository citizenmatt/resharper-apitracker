[assembly: JetBrains.ActionManagement.ActionsXmlAttribute("JetBrains.ReSharper.Feature.Services.resources.Actions.xml")]
[assembly: JetBrains.TextControl.DocumentMarkup.RegisterHighlighterAttribute("ReSharper Completion Replacement Range", "{1C49BB3B-DD3B-4452-BCC8-9BADAC662993}", BackgroundColor="MistyRose:Magenta", DarkBackgroundColor="Olive", EffectType=JetBrains.TextControl.DocumentMarkup.EffectType.HIGHLIGHT, Layer=4998, VSPriority=10001)]
[assembly: JetBrains.TextControl.DocumentMarkup.RegisterHighlighterAttribute("ReSharper LiveTemplates Current HotSpot", "{D2E2AC59-C532-4447-8619-FAF7CA81AF39}", EffectColor="Red", EffectType=JetBrains.TextControl.DocumentMarkup.EffectType.SOLID_OUTLINE, Layer=4999, VSPriority=10001)]
[assembly: JetBrains.TextControl.DocumentMarkup.RegisterHighlighterAttribute("ReSharper LiveTemplates Current HotSpot mirror", "{C9518B2E-B6A8-46e5-9147-5EC105F6F68A}", EffectColor="Black", EffectType=JetBrains.TextControl.DocumentMarkup.EffectType.DOTTED_OUTLINE, Layer=4999, VSPriority=10001)]
[assembly: JetBrains.TextControl.DocumentMarkup.RegisterHighlighterAttribute("ReSharper LiveTemplates Inactive HotSpot", "{FD8EFE47-F861-4ce8-A2EC-7FAF6CA31663}", BackgroundColor="PaleGoldenrod:Yellow", DarkBackgroundColor="SaddleBrown", EffectType=JetBrains.TextControl.DocumentMarkup.EffectType.HIGHLIGHT, Layer=4999, VSPriority=10001)]
[assembly: JetBrains.UI.Icons.CompiledIcons.CompiledIconsPackAttribute(IconNames=new string[] {
        "ScopeGlobal",
        "PersonalSolutionTemplates",
        "SharedSolutionTemplates",
        "SurroundTemplate",
        "FileTemplate",
        "LiveTemplate",
        "PredefinedTemplates",
        "FileStorage"}, IconPackResourceIdentification="JetBrains.ReSharper.Feature.Services;component/resources/ServicesThemedIcons/Them" +
    "edIcons.Services.Generated.Xaml")]
[assembly: System.Runtime.CompilerServices.InternalsVisibleToAttribute(@"JetBrains.ReSharper.FeaturesTests, PublicKey=002400000480000094000000060200000024000052534131000400000100010087f63ba6a789c30e210e7ec987234ad9fe33baf7367993bab1b312d6f72ca296b91ed5c658964ffb9e7570eb184a527c68c6bdba41cfe67d8cfd3f888234206bf39205a3652d3af3445bb6f715fdac532e289fea41229bac37762b67eb16f58fee717d2465fca9ee17f08ed16772a1fc52c1c17022e1f0d9bdd004524a663aca")]
[assembly: System.Runtime.CompilerServices.InternalsVisibleToAttribute(@"JetBrains.ReSharper.Features.LinqTools, PublicKey=002400000480000094000000060200000024000052534131000400000100010087f63ba6a789c30e210e7ec987234ad9fe33baf7367993bab1b312d6f72ca296b91ed5c658964ffb9e7570eb184a527c68c6bdba41cfe67d8cfd3f888234206bf39205a3652d3af3445bb6f715fdac532e289fea41229bac37762b67eb16f58fee717d2465fca9ee17f08ed16772a1fc52c1c17022e1f0d9bdd004524a663aca")]
[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]
[assembly: System.Windows.Markup.XmlnsDefinitionAttribute("urn:shemas-jetbrains-com:ui-application-icons-services", "JetBrains.ReSharper.Feature.Services.Resources")]

namespace JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph
{
    
    public class static ArchitectureGraphElementExtentions
    {
        public static JetBrains.ProjectModel.IProjectModelElement GetElement(this JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IProjectModelGraphElement graphElement, JetBrains.ProjectModel.ISolution solution) { }
        public static string GetName(this JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IProjectModelGraphElement graphElement, JetBrains.ProjectModel.ISolution solution) { }
    }
    public class static ArchitectureGraphExtentions
    {
        public static bool ContainsEdge(this JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IArchitectureGraph graph, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IArchitectureGraphEdge edge) { }
        public static bool ContainsNode(this JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IArchitectureGraph graph, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IArchitectureGraphNode node) { }
        public static bool ContainsReference(this JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IArchitectureGraph graph, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IProjectToProjectReference reference) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IArchitectureGraphElement CreateGraphElement(this JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IArchitectureGraph graph, JetBrains.ProjectModel.IProjectModelElement element) { }
        public static bool GetGraphElement(this JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IArchitectureGraph graph, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IProjectElement element) { }
        public static void ProcessTransitiveEdges([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IArchitectureGraph graph, bool includeTransitive) { }
    }
    public class static ArchitectureGraphNodeExtentions
    {
        public static void AddEdge([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IArchitectureGraphNode node, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IArchitectureGraphEdge edge) { }
        public static System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IArchitectureGraphEdge> GetDirectEdges(this JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IArchitectureGraphNode node) { }
        public static System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IArchitectureGraphEdge> GetTransitiveEdges(this JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IArchitectureGraphNode node) { }
        public static bool RemoveEdge([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IArchitectureGraphNode node, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IArchitectureGraphEdge edge) { }
    }
    [System.FlagsAttribute()]
    public enum DependencyType
    {
        Direct = 0,
        Transitive = 1,
        Unresolved = 2,
        Invalid = 3,
    }
    [System.FlagsAttribute()]
    public enum ElementKind
    {
        Normal = 1,
        New = 2,
        Removed = 4,
        VB = 8,
        CSharp = 16,
    }
    public class FileSystemFolderGroupNode : JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IArchitectureGraphElement, JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IArchitectureGroupNode
    {
        public FileSystemFolderGroupNode(JetBrains.Util.FileSystemPath fileSystemPath) { }
        public JetBrains.Util.FileSystemPath FileSystemPath { get; }
        public bool IsValid { get; set; }
        public JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.ElementKind Kind { get; set; }
        public int Level { get; set; }
        public string Name { get; }
        public System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IArchitectureGraphElement> NestedElements { get; }
        protected bool Equals(JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.FileSystemFolderGroupNode other) { }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
    }
    public class GraphDiff
    {
        public GraphDiff() { }
        public System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IArchitectureGraphElement> ElementsToRemove { get; }
        public System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IArchitectureGraphElement> NewElements { get; }
        public void Clear() { }
        public bool IsEmpty() { }
    }
    public interface IArchitectureAssemblyNode : JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IArchitectureGraphElement, JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IArchitectureGraphNode, JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IProjectModelGraphElement { }
    public interface IArchitectureElementBuilder
    {
        JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IArchitectureAssemblyNode CreateAssemblyNode([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.Model2.Assemblies.Interfaces.IAssembly assembly);
        JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IArchitectureProjectNode CreateProjectNode([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IProject project);
        JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IArchitectureModuleToModuleReference CreateProjectRefrerenceNode([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IArchitectureGraph graph, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IProjectToProjectReference reference);
        JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IArchitectureGraphNode CreateSolutionFolderNode(JetBrains.ProjectModel.IProject project);
    }
    public interface IArchitectureGraph
    {
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IArchitectureGraphEdge> Edges { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IArchitectureGraphNode> Nodes { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ProjectModel.ISolution Solution { get; }
        void AddElement(JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IArchitectureGraphElement element);
        JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IArchitectureGraphEdge CreateEdgeFromProjectModel([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IProjectModelElement element);
        JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IArchitectureGraphNode CreateNodeFromProjectModel([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IProjectModelElement element);
        bool RemoveElement(JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IArchitectureGraphElement element);
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IProjectModelGraphElement TryGetGraphElement(JetBrains.ProjectModel.IProjectElement element);
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IProjectModelGraphElement TryGetGraphElement(string persistentId);
    }
    public interface IArchitectureGraphEdge : JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IArchitectureGraphElement
    {
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IArchitectureGraphNode Source { get; set; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IArchitectureGraphNode Target { get; set; }
        JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.DependencyType Type { get; set; }
    }
    public interface IArchitectureGraphElement
    {
        bool IsValid { get; set; }
        JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.ElementKind Kind { get; set; }
        string Name { get; }
    }
    public interface IArchitectureGraphNode : JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IArchitectureGraphElement
    {
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IArchitectureGraphEdge> Incoming { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IArchitectureGraphEdge> Outcoming { get; }
        JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.NodeType Type { get; set; }
        void AddIncomingEdge([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IArchitectureGraphEdge edge);
        void AddOutcomingEdge([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IArchitectureGraphEdge edge);
        bool RemoveIncomingEdge(JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IArchitectureGraphEdge edge);
        bool RemoveOutcomingEdge(JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IArchitectureGraphEdge edge);
    }
    public interface IArchitectureGroupNode : JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IArchitectureGraphElement
    {
        int Level { get; set; }
        System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IArchitectureGraphElement> NestedElements { get; }
    }
    public interface IArchitectureModuleToModuleReference : JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IArchitectureGraphEdge, JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IArchitectureGraphElement, JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IProjectModelEdge, JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IProjectModelGraphElement
    {
        [JetBrains.Annotations.NotNullAttribute()]
        new JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IArchitectureGraphNode Source { get; set; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        new JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IArchitectureGraphNode Target { get; set; }
        int Weight { get; set; }
    }
    public interface IArchitecturePersistentGraph : JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IArchitectureGraph
    {
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.GraphDiff DiffToCurrentSolution { get; }
        bool IsBinded { get; }
        void BindToCurrentSolution(JetBrains.ProjectModel.ISolution solution);
    }
    public interface IArchitectureProjectNode : JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IArchitectureGraphElement, JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IArchitectureGraphNode, JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IProjectModelGraphElement, JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IProjectModelNode { }
    public interface IArchitectureViewGraph : JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IArchitectureGraph
    {
        System.Collections.Generic.Dictionary<object, JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IArchitectureGraphElement> CustomElements { get; }
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IArchitectureGroupNode> GroupNodes { get; }
        int MaxLevel { get; set; }
        JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IArchitecturePersistentGraph PersistentOwner { get; }
        bool ShowDiff { get; }
        void Dump(System.IO.TextWriter writer);
    }
    public interface IProjectModelEdge : JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IArchitectureGraphEdge, JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IArchitectureGraphElement, JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IProjectModelGraphElement { }
    public interface IProjectModelGraphElement : JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IArchitectureGraphElement
    {
        bool IsBinded { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ProjectModel.IProjectModelElementPointer ProjectItemPointer { get; }
        string SolutionIdentifier { get; }
        void Bind(JetBrains.ProjectModel.IProjectModelElement projectModelElement);
    }
    public interface IProjectModelNode : JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IArchitectureGraphElement, JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IArchitectureGraphNode, JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IProjectModelGraphElement { }
    [System.FlagsAttribute()]
    public enum NodeType
    {
        Normal = 0,
        Hub = 1,
        Isolated = 2,
        Invalid = 3,
    }
}
namespace JetBrains.ReSharper.Feature.Services.ArchitectureModel.GraphGrouping
{
    
    public class ArchitectureGrouping : JetBrains.TreeModels.TreeModelGrouping<JetBrains.ReSharper.Feature.Services.Search.IOccurence>
    {
        public ArchitectureGrouping(string name, JetBrains.ReSharper.Feature.Services.ArchitectureModel.Manager.GroupingId groupingId, params JetBrains.TreeModels.ITreeGroupProvider<>[] groups) { }
        public JetBrains.ReSharper.Feature.Services.ArchitectureModel.Manager.GroupingId GroupingId { get; }
    }
    public class ContainingSolutionFolderGrouping : JetBrains.ReSharper.Feature.Services.ArchitectureModel.GraphGrouping.IGraphGrouping
    {
        public ContainingSolutionFolderGrouping(JetBrains.ProjectModel.ISolution solution) { }
        public JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IArchitectureGroupNode GetParentNode(JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IArchitectureGraphElement node, JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IArchitectureViewGraph graph) { }
    }
    [JetBrains.ReSharper.Psi.ShellFeaturePartAttribute()]
    public class DefaultGroupingProvider : JetBrains.ReSharper.Feature.Services.ArchitectureModel.GraphGrouping.IGraphGroupingProvider
    {
        public virtual System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.ArchitectureModel.GraphGrouping.IGraphGrouping> GetGroupings(JetBrains.ProjectModel.ISolution solution) { }
        public virtual bool IsApplicable(JetBrains.ReSharper.Feature.Services.ArchitectureModel.Manager.GroupingId id) { }
    }
    public class FileStructureGrouping : JetBrains.ReSharper.Feature.Services.ArchitectureModel.GraphGrouping.IGraphGrouping
    {
        public FileStructureGrouping(JetBrains.ProjectModel.ISolution solution) { }
        public JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IArchitectureGroupNode GetParentNode(JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IArchitectureGraphElement node, JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IArchitectureViewGraph graph) { }
    }
    [JetBrains.ReSharper.Psi.ShellFeaturePartAttribute()]
    public class FileStructureGroupingProvider : JetBrains.ReSharper.Feature.Services.ArchitectureModel.GraphGrouping.IGraphGroupingProvider
    {
        public System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.ArchitectureModel.GraphGrouping.IGraphGrouping> GetGroupings(JetBrains.ProjectModel.ISolution solution) { }
        public bool IsApplicable(JetBrains.ReSharper.Feature.Services.ArchitectureModel.Manager.GroupingId id) { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class GraphGroupingManager
    {
        public GraphGroupingManager(JetBrains.ReSharper.Feature.Services.IFeaturePartsContainer shellFeatureParts) { }
        public void GroupGraph(JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IArchitectureViewGraph graph, JetBrains.ReSharper.Feature.Services.ArchitectureModel.Manager.GroupingId id) { }
    }
    public interface IGraphGrouping
    {
        JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IArchitectureGroupNode GetParentNode(JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IArchitectureGraphElement node, JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IArchitectureViewGraph graph);
    }
    public interface IGraphGroupingProvider
    {
        System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.ArchitectureModel.GraphGrouping.IGraphGrouping> GetGroupings(JetBrains.ProjectModel.ISolution solution);
        bool IsApplicable(JetBrains.ReSharper.Feature.Services.ArchitectureModel.Manager.GroupingId id);
    }
}
namespace JetBrains.ReSharper.Feature.Services.ArchitectureModel.Impl.Graph
{
    
    public abstract class ArchitectureGraphBase : JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IArchitectureGraph
    {
        protected readonly System.Collections.Generic.JetHashSet<JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IArchitectureGraphEdge> myEdges;
        protected readonly System.Collections.Generic.JetHashSet<JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IArchitectureGraphNode> myNodes;
        protected ArchitectureGraphBase([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ProjectModel.ISolution solution) { }
        public System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IArchitectureGraphEdge> Edges { get; }
        public bool IsBinded { get; }
        public System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IArchitectureGraphNode> Nodes { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ProjectModel.ISolution Solution { get; set; }
        public virtual void AddEdge(JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IArchitectureGraphEdge edge) { }
        public virtual void AddElement(JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IArchitectureGraphElement element) { }
        public virtual void AddNode(JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IArchitectureGraphNode node) { }
        public JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IArchitectureGraphEdge CreateEdgeFromProjectModel([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IProjectModelElement element) { }
        public JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IArchitectureGraphNode CreateNodeFromProjectModel([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IProjectModelElement element) { }
        public virtual bool RemoveElement(JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IArchitectureGraphElement element) { }
        public abstract JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IProjectModelGraphElement TryGetGraphElement(JetBrains.ProjectModel.IProjectElement element);
        public abstract JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IProjectModelGraphElement TryGetGraphElement(string persistentId);
    }
    public abstract class ArchitectureGraphElementBase : JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IArchitectureGraphElement, JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IProjectModelGraphElement
    {
        protected ArchitectureGraphElementBase(JetBrains.ProjectModel.IProjectModelElementPointer projectItemPointer, string solutionIdentifier, string name) { }
        protected ArchitectureGraphElementBase(string solutionIdentifier, string name) { }
        public bool IsBinded { get; set; }
        public bool IsValid { get; set; }
        public JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.ElementKind Kind { get; set; }
        public string Name { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ProjectModel.IProjectModelElementPointer ProjectItemPointer { get; }
        public string SolutionIdentifier { get; }
        public void Bind(JetBrains.ProjectModel.IProjectModelElement projectModelElement) { }
        public virtual bool Equals(object obj) { }
        public bool Equals([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Feature.Services.ArchitectureModel.Impl.Graph.ArchitectureGraphElementBase element) { }
        public virtual int GetHashCode() { }
    }
    public abstract class ArchitectureGraphNode : JetBrains.ReSharper.Feature.Services.ArchitectureModel.Impl.Graph.ArchitectureGraphNodeBase
    {
        public ArchitectureGraphNode(JetBrains.ProjectModel.IProjectModelElementPointer pointer, string solutionIdentifier, string name) { }
        public ArchitectureGraphNode([JetBrains.Annotations.NotNullAttribute()] string solutionIdentifier, string name) { }
        public virtual System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IArchitectureGraphEdge> Incoming { get; set; }
        public virtual System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IArchitectureGraphEdge> Outcoming { get; set; }
    }
    public class ArchitectureGraphNodeBase : JetBrains.ReSharper.Feature.Services.ArchitectureModel.Impl.Graph.ArchitectureGraphElementBase, JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IArchitectureGraphElement, JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IArchitectureGraphNode
    {
        protected ArchitectureGraphNodeBase(JetBrains.ProjectModel.IProjectModelElementPointer pointer, string solutionIdentifier, string name) { }
        protected ArchitectureGraphNodeBase(string solutionIdentifier, string name) { }
        public virtual System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IArchitectureGraphEdge> Incoming { get; set; }
        public virtual System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IArchitectureGraphEdge> Outcoming { get; set; }
        public JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.NodeType Type { get; set; }
        public virtual void AddIncomingEdge(JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IArchitectureGraphEdge edge) { }
        public virtual void AddOutcomingEdge(JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IArchitectureGraphEdge edge) { }
        protected bool RemoveEdge(JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IArchitectureGraphEdge edge, [JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IArchitectureGraphEdge> edges) { }
        public virtual bool RemoveIncomingEdge(JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IArchitectureGraphEdge edge) { }
        public virtual bool RemoveOutcomingEdge(JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IArchitectureGraphEdge edge) { }
    }
    public class ArchitecturePersistentGraph : JetBrains.ReSharper.Feature.Services.ArchitectureModel.Impl.Graph.ArchitectureGraphBase, JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IArchitectureGraph, JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IArchitecturePersistentGraph
    {
        protected readonly System.Collections.Generic.Dictionary<string, JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IProjectModelGraphElement> BindingMap;
        public ArchitecturePersistentGraph([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ProjectModel.ISolution solution) { }
        public ArchitecturePersistentGraph() { }
        public JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.GraphDiff DiffToCurrentSolution { get; }
        public override void AddEdge(JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IArchitectureGraphEdge edge) { }
        public override void AddNode(JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IArchitectureGraphNode node) { }
        public void BindToCurrentSolution(JetBrains.ProjectModel.ISolution solution) { }
        public override JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IProjectModelGraphElement TryGetGraphElement(JetBrains.ProjectModel.IProjectElement element) { }
        public override JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IProjectModelGraphElement TryGetGraphElement(string persistentId) { }
    }
    public class ArchitectureViewModelGraph : JetBrains.ReSharper.Feature.Services.ArchitectureModel.Impl.Graph.ArchitectureGraphBase, JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IArchitectureGraph, JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IArchitectureViewGraph
    {
        public ArchitectureViewModelGraph([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IArchitecturePersistentGraph persistentOwner, bool showDiff) { }
        public System.Collections.Generic.Dictionary<object, JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IArchitectureGraphElement> CustomElements { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IArchitectureGroupNode> GroupNodes { get; }
        public int MaxLevel { get; set; }
        public JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IArchitecturePersistentGraph PersistentOwner { get; }
        public bool ShowDiff { get; }
        public override void AddEdge(JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IArchitectureGraphEdge edge) { }
        public override void AddNode(JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IArchitectureGraphNode node) { }
        public void Dump(System.IO.TextWriter writer) { }
        public override JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IProjectModelGraphElement TryGetGraphElement(JetBrains.ProjectModel.IProjectElement projectModelElement) { }
        public override JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IProjectModelGraphElement TryGetGraphElement(string persistentId) { }
    }
    public class SimpleWrapperView : JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IArchitectureGraph, JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IArchitectureViewGraph
    {
        public SimpleWrapperView(JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IArchitecturePersistentGraph persistentGraph) { }
        public System.Collections.Generic.Dictionary<object, JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IArchitectureGraphElement> CustomElements { get; }
        public System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IArchitectureGraphEdge> Edges { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IArchitectureGroupNode> GroupNodes { get; }
        public int MaxLevel { get; set; }
        public System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IArchitectureGraphNode> Nodes { get; }
        public JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IArchitecturePersistentGraph PersistentOwner { get; }
        public bool ShowDiff { get; }
        public JetBrains.ProjectModel.ISolution Solution { get; }
        public void AddElement(JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IArchitectureGraphElement element) { }
        public JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IArchitectureGraphEdge CreateEdgeFromProjectModel(JetBrains.ProjectModel.IProjectModelElement element) { }
        public JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IArchitectureGraphNode CreateNodeFromProjectModel(JetBrains.ProjectModel.IProjectModelElement element) { }
        public void Dump(System.IO.TextWriter writer) { }
        public bool RemoveElement(JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IArchitectureGraphElement element) { }
        public JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IProjectModelGraphElement TryGetGraphElement(JetBrains.ProjectModel.IProjectElement element) { }
        public JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IProjectModelGraphElement TryGetGraphElement(string persistentId) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.ArchitectureModel.Impl.Manager
{
    
    [JetBrains.ProjectModel.SolutionComponentAttribute(JetBrains.Application.Components.ProgramConfigurations.NONE | JetBrains.Application.Components.ProgramConfigurations.STANDALONE | JetBrains.Application.Components.ProgramConfigurations.TEST | JetBrains.Application.Components.ProgramConfigurations.VS_ADDIN | JetBrains.Application.Components.ProgramConfigurations.COMMAND_LINE | JetBrains.Application.Components.ProgramConfigurations.ALL)]
    public class ArchitectureGraphManager : JetBrains.ReSharper.Feature.Services.ArchitectureModel.Manager.IArchitectureGraphManager
    {
        public ArchitectureGraphManager([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Feature.Services.ArchitectureModel.GraphGrouping.GraphGroupingManager graphGroupingManager) { }
        protected virtual void CreateGroupNodes(JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IArchitecturePersistentGraph persistentGraph, JetBrains.ReSharper.Feature.Services.ArchitectureModel.Manager.GraphInputSettings userInputSettings, JetBrains.ReSharper.Feature.Services.ArchitectureModel.Impl.Graph.ArchitectureViewModelGraph viewGraph) { }
        protected virtual void FillViewModelGraph(JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IArchitecturePersistentGraph persistentGraph, JetBrains.ReSharper.Feature.Services.ArchitectureModel.Manager.GraphInputSettings userInputSettings, JetBrains.ReSharper.Feature.Services.ArchitectureModel.Impl.Graph.ArchitectureViewModelGraph viewGraph) { }
        public JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IArchitectureViewGraph GetViewModel(JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IArchitecturePersistentGraph persistentGraph, JetBrains.ReSharper.Feature.Services.ArchitectureModel.Manager.GraphInputSettings userInputSettings) { }
        public JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IArchitecturePersistentGraph LoadFromSolution(JetBrains.ProjectModel.ISolution solution) { }
        public void WriteToXml(JetBrains.Util.FileSystemPath path, JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IArchitecturePersistentGraph persistentGraph) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.ArchitectureModel.Impl.PersistenceProvider
{
    
    public class AssemblyNodePersistenceProvider
    {
        public bool IsApplicable(JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IArchitectureGraphElement graphElement) { }
        public System.Xml.XmlElement WriteToXml(JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IArchitectureGraphElement graphElement, System.Xml.XmlDocument document) { }
    }
    [JetBrains.ReSharper.Psi.ShellFeaturePartAttribute()]
    public class ModulePersistentProvider : JetBrains.ReSharper.Feature.Services.ArchitectureModel.PersistenceProvider.IArchitecturePersistenceProvider
    {
        public virtual bool IsApplicable(JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IArchitectureGraphElement graphElement) { }
        public virtual bool IsApplicable(System.Xml.XmlElement xmlElement) { }
        public virtual void ReadFromXml(System.Xml.XmlElement xmlElement, JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IArchitectureGraph graph) { }
        public virtual System.Xml.XmlElement WriteToXml(JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IProjectModelGraphElement graphElement, System.Xml.XmlDocument document) { }
    }
    [JetBrains.ReSharper.Psi.ShellFeaturePartAttribute()]
    public class ReferencePersistenceProvider : JetBrains.ReSharper.Feature.Services.ArchitectureModel.PersistenceProvider.IArchitecturePersistenceProvider
    {
        public virtual bool IsApplicable(JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IArchitectureGraphElement graphElement) { }
        public virtual bool IsApplicable(System.Xml.XmlElement xmlElement) { }
        public virtual void ReadFromXml(System.Xml.XmlElement xmlElement, JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IArchitectureGraph graph) { }
        public virtual System.Xml.XmlElement WriteToXml(JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IProjectModelGraphElement graphElement, System.Xml.XmlDocument document) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.ArchitectureModel.Impl.Util
{
    
    public class GraphUtils
    {
        public static System.Collections.Generic.ICollection<JetBrains.ProjectModel.IProject> CollectProjects(System.Collections.Generic.List<JetBrains.ProjectModel.IProjectModelElement> elements) { }
        public static void Dfs([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IModule module, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IArchitectureGraph graph, System.Func<JetBrains.ProjectModel.IModule, bool> moduleFunc, System.Action<JetBrains.ProjectModel.IProjectToProjectReference, JetBrains.ProjectModel.IProject> referenceAction) { }
        public static JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.GraphDiff GetDiff(JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IArchitectureGraph oldView, JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IArchitectureGraph newView) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.ArchitectureModel.Manager
{
    
    public class GraphInputSettings
    {
        public GraphInputSettings(System.Collections.Generic.ICollection<JetBrains.ProjectModel.IModule> scope, bool includeTransitive, JetBrains.ReSharper.Feature.Services.ArchitectureModel.Manager.GroupingId groupingId, bool showDiff) { }
        public GraphInputSettings(System.Collections.Generic.ICollection<JetBrains.ProjectModel.IModule> selectedProjects, bool showDiff) { }
        public JetBrains.ReSharper.Feature.Services.ArchitectureModel.Manager.GroupingId GroupingId { get; }
        public bool IncludeTransitive { get; }
        public System.Collections.Generic.ICollection<JetBrains.ProjectModel.IModule> Scope { get; }
        public bool ShowDiff { get; }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class GraphPersistence : JetBrains.ReSharper.Feature.Services.ArchitectureModel.Manager.IGraphPersistence
    {
        public GraphPersistence(JetBrains.ReSharper.Feature.Services.IFeaturePartsContainer shellFeaturePartsContainer) { }
        public JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IArchitecturePersistentGraph ReadGraphFromXml(System.Xml.XmlDocument document) { }
        public void WriteToXml(JetBrains.Util.FileSystemPath path, JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IArchitecturePersistentGraph persistentGraph) { }
    }
    public class GroupingId : JetBrains.Util.EnumPattern
    {
        public static JetBrains.ReSharper.Feature.Services.ArchitectureModel.Manager.GroupingId FileStructure;
        public static JetBrains.ReSharper.Feature.Services.ArchitectureModel.Manager.GroupingId None;
        public static JetBrains.ReSharper.Feature.Services.ArchitectureModel.Manager.GroupingId SolutionFolders;
        public GroupingId([JetBrains.Annotations.NotNullAttribute()] string name) { }
    }
    public interface IArchitectureGraphManager
    {
        JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IArchitectureViewGraph GetViewModel(JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IArchitecturePersistentGraph persistentGraph, JetBrains.ReSharper.Feature.Services.ArchitectureModel.Manager.GraphInputSettings userInputSettings);
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IArchitecturePersistentGraph LoadFromSolution(JetBrains.ProjectModel.ISolution solution);
    }
    public interface IGraphPersistence
    {
        JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IArchitecturePersistentGraph ReadGraphFromXml([JetBrains.Annotations.NotNullAttribute()] System.Xml.XmlDocument document);
        void WriteToXml(JetBrains.Util.FileSystemPath path, JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IArchitecturePersistentGraph persistentGraph);
    }
}
namespace JetBrains.ReSharper.Feature.Services.ArchitectureModel.PersistenceProvider
{
    
    public interface IArchitecturePersistenceProvider
    {
        bool IsApplicable([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IArchitectureGraphElement graphElement);
        bool IsApplicable([JetBrains.Annotations.NotNullAttribute()] System.Xml.XmlElement xmlElement);
        void ReadFromXml([JetBrains.Annotations.NotNullAttribute()] System.Xml.XmlElement xmlElement, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IArchitectureGraph graph);
        System.Xml.XmlElement WriteToXml([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IProjectModelGraphElement graphElement, [JetBrains.Annotations.NotNullAttribute()] System.Xml.XmlDocument document);
    }
    public interface IDotWriter
    {
        bool IsApplicable(JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IArchitectureGraphElement element);
        void Write(JetBrains.ReSharper.Feature.Services.ArchitectureModel.Graph.IArchitectureGraphElement element, System.Xml.XmlWriter textWriter);
    }
}
namespace JetBrains.ReSharper.Feature.Services.Bookmarks
{
    
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class BookmarkPersister
    {
        public BookmarkPersister(JetBrains.Threading.IThreading threading, JetBrains.DataFlow.Lifetime lifetime, JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Settings.ISettingsStore settingsStore, JetBrains.ReSharper.Feature.Services.Bookmarks.Model.IBookmarkManager bookmarkManager, JetBrains.ProjectModel.ProjectModelElementPointerManager elementPointerManager) { }
    }
    public class static BookmarksHelper
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Feature.Services.Bookmarks.Model.BookmarkData AddBookmark([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ProjectModel.ISolution solution, [JetBrains.Annotations.NotNullAttribute()] string owner, [JetBrains.Annotations.NotNullAttribute()] string id, JetBrains.ReSharper.Feature.Services.Bookmarks.Model.BookmarkPersistence persistence, JetBrains.DocumentModel.DocumentRange range) { }
        public static System.IDisposable AdviseAddBookmark([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Feature.Services.Bookmarks.Model.IBookmarkManager manager, [JetBrains.Annotations.NotNullAttribute()] string owner, [JetBrains.Annotations.NotNullAttribute()] System.Action<JetBrains.ReSharper.Feature.Services.Bookmarks.Model.AddRemoveBookmarkEventArgs<JetBrains.ReSharper.Feature.Services.Bookmarks.Model.IBookmarkManager, JetBrains.ReSharper.Feature.Services.Bookmarks.Model.BookmarkData>> handler) { }
        public static void AdviseAddSpecificBookmark<TManager, TKey, TData>([JetBrains.Annotations.NotNullAttribute()] this TManager manager, JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] System.Action<JetBrains.ReSharper.Feature.Services.Bookmarks.Model.AddRemoveBookmarkEventArgs<TManager, TData>> handler)
            where TManager :  class, JetBrains.ReSharper.Feature.Services.Bookmarks.Model.ISpecificBookmarkManager<, , >
        
            where TData : JetBrains.ReSharper.Feature.Services.Bookmarks.Model.BookmarkDataBase<> { }
        public static System.IDisposable AdviseMoveBookmark([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Feature.Services.Bookmarks.Model.IBookmarkManager manager, [JetBrains.Annotations.NotNullAttribute()] string owner, [JetBrains.Annotations.NotNullAttribute()] System.Action<JetBrains.ReSharper.Feature.Services.Bookmarks.Model.MoveBookmarkEventArgs<JetBrains.ReSharper.Feature.Services.Bookmarks.Model.IBookmarkManager, JetBrains.ReSharper.Feature.Services.Bookmarks.Model.BookmarkData>> handler) { }
        public static System.IDisposable AdviseRemoveBookmark([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Feature.Services.Bookmarks.Model.IBookmarkManager manager, [JetBrains.Annotations.NotNullAttribute()] string owner, [JetBrains.Annotations.NotNullAttribute()] System.Action<JetBrains.ReSharper.Feature.Services.Bookmarks.Model.AddRemoveBookmarkEventArgs<JetBrains.ReSharper.Feature.Services.Bookmarks.Model.IBookmarkManager, JetBrains.ReSharper.Feature.Services.Bookmarks.Model.BookmarkData>> handler) { }
        public static void AdviseRemoveSpecificBookmark<TManager, TKey, TData>([JetBrains.Annotations.NotNullAttribute()] this TManager manager, JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] System.Action<JetBrains.ReSharper.Feature.Services.Bookmarks.Model.AddRemoveBookmarkEventArgs<TManager, TData>> handler)
            where TManager :  class, JetBrains.ReSharper.Feature.Services.Bookmarks.Model.ISpecificBookmarkManager<, , >
        
            where TData : JetBrains.ReSharper.Feature.Services.Bookmarks.Model.BookmarkDataBase<> { }
        public static void ClearAllBookmarks<TManager, TKey, TData>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Feature.Services.Bookmarks.Model.ISpecificBookmarkManager<TManager, TKey, TData> manager)
            where TManager :  class, JetBrains.ReSharper.Feature.Services.Bookmarks.Model.ISpecificBookmarkManager<, , >
        
            where TData : JetBrains.ReSharper.Feature.Services.Bookmarks.Model.BookmarkDataBase<> { }
        public static void ClearBookmarksInDocument<TManager, TKey, TData>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Feature.Services.Bookmarks.Model.ISpecificBookmarkManager<TManager, TKey, TData> manager, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IProjectFile projectFile)
            where TManager :  class, JetBrains.ReSharper.Feature.Services.Bookmarks.Model.ISpecificBookmarkManager<, , >
        
            where TData : JetBrains.ReSharper.Feature.Services.Bookmarks.Model.BookmarkDataBase<> { }
        public static void ClearBookmarksInLine<TManager, TKey, TData>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Feature.Services.Bookmarks.Model.ISpecificBookmarkManager<TManager, TKey, TData> manager, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IProjectFile projectFile, JetBrains.Util.dataStructures.TypedIntrinsics.Int32<JetBrains.DocumentModel.DocLine> line)
            where TManager :  class, JetBrains.ReSharper.Feature.Services.Bookmarks.Model.ISpecificBookmarkManager<, , >
        
            where TData : JetBrains.ReSharper.Feature.Services.Bookmarks.Model.BookmarkDataBase<> { }
        public static void ClearBookmarksInLine<TManager, TKey, TData>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Feature.Services.Bookmarks.Model.ISpecificBookmarkManager<TManager, TKey, TData> manager, JetBrains.ProjectModel.IProjectModelElementPointer file, JetBrains.Util.dataStructures.TypedIntrinsics.Int32<JetBrains.DocumentModel.DocLine> line)
            where TManager :  class, JetBrains.ReSharper.Feature.Services.Bookmarks.Model.ISpecificBookmarkManager<, , >
        
            where TData : JetBrains.ReSharper.Feature.Services.Bookmarks.Model.BookmarkDataBase<> { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Feature.Services.Bookmarks.Model.BookmarkData FindBookmark([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Feature.Services.Bookmarks.Model.IBookmarkManager manager, [JetBrains.Annotations.NotNullAttribute()] string id) { }
        public static JetBrains.UI.RichText.RichText FormatPlace([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Feature.Services.Bookmarks.Model.BookmarkPlacement placement, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IProjectItem bookmarkFile, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ProjectModel.IProjectFile localFile) { }
        public static JetBrains.UI.RichText.RichText FormatPlace([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Feature.Services.Bookmarks.Model.BookmarkPlacement placement, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IProjectItem bookmarkFile) { }
        public static JetBrains.UI.RichText.RichText FormatPlace<TKey>([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Feature.Services.Bookmarks.Model.BookmarkDataBase<TKey> data, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IProjectItem bookmarkFile, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ProjectModel.IProjectFile localFile) { }
        public static JetBrains.UI.RichText.RichText FormatPlace<TKey>([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Feature.Services.Bookmarks.Model.BookmarkDataBase<TKey> data, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IProjectItem bookmarkFile) { }
        public static int GetBookmarkCoordsOffset(this JetBrains.DocumentModel.IDocument document, JetBrains.DocumentModel.DocumentCoords coords) { }
        public static JetBrains.ReSharper.Feature.Services.Bookmarks.Model.IBookmarkManager GetBookmarkManager(this JetBrains.ProjectModel.ISolution solution) { }
        public static System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.Bookmarks.Model.BookmarkData> GetBookmarks([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Feature.Services.Bookmarks.Model.IBookmarkManager manager, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IProjectModelElementPointer file, JetBrains.Util.dataStructures.TypedIntrinsics.Int32<JetBrains.DocumentModel.DocLine> line) { }
        public static System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.Bookmarks.Model.BookmarkData> GetBookmarks([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Feature.Services.Bookmarks.Model.IBookmarkManager manager, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IProjectFile file, JetBrains.Util.dataStructures.TypedIntrinsics.Int32<JetBrains.DocumentModel.DocLine> line) { }
        public static System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.Bookmarks.Model.BookmarkData> GetBookmarksForDocument([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Feature.Services.Bookmarks.Model.IBookmarkManager manager, [JetBrains.Annotations.NotNullAttribute()] string owner, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IProjectModelElementPointer file) { }
        public static string GetDisplayName([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Feature.Services.Bookmarks.Model.BookmarkPlacement placement, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.ISolution solution) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ProjectModel.IProjectFile GetProjectFile([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Feature.Services.Bookmarks.Model.BookmarkPlacement placement, JetBrains.ProjectModel.ISolution solution) { }
        public static JetBrains.ProjectModel.IProjectFile GetProjectFile([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Feature.Services.Bookmarks.Model.BookmarkData data, JetBrains.ProjectModel.ISolution solution) { }
        public static JetBrains.Util.TextRange GetTextRangeByCoords(this JetBrains.DocumentModel.IDocument document, JetBrains.DocumentModel.DocumentCoords coords) { }
        public static JetBrains.Util.OperationResult GoToBookmark<TKey>(this JetBrains.ReSharper.Feature.Services.Bookmarks.Model.BookmarkDataBase<TKey> data, JetBrains.ProjectModel.ISolution solution, JetBrains.UI.PopupWindowManager.PopupWindowContextSource windowContext) { }
    }
    [JetBrains.Application.Settings.SettingsKeyAttribute(typeof(JetBrains.Application.Settings.HousekeepingSettings), "Bookmarks settings")]
    public class BookmarksSettingsKey { }
    [JetBrains.Application.Settings.SettingsIndexedKeyAttribute(typeof(JetBrains.ReSharper.Feature.Services.Bookmarks.BookmarksSettingsKey), "Bookmarks settings", typeof(string))]
    public class NumberedBookmarksSettingsKey
    {
        [JetBrains.Application.Settings.SettingsEntryAttribute("", "Bookmark coords in a file")]
        public string Coords;
        [JetBrains.Application.Settings.SettingsEntryAttribute("", "Bookmark file id")]
        public string FileId;
        [JetBrains.Application.Settings.SettingsEntryAttribute("", "Bookmark owner")]
        public string Owner;
    }
    public abstract class SpecificBookmarkManagerBase<TManager, TKey, TData> : JetBrains.ReSharper.Feature.Services.Bookmarks.Model.ISpecificBookmarkManager<TManager, TKey, TData>
        where TManager :  class, JetBrains.ReSharper.Feature.Services.Bookmarks.Model.ISpecificBookmarkManager<, , >
    
        where TData : JetBrains.ReSharper.Feature.Services.Bookmarks.Model.BookmarkDataBase<>
    {
        protected SpecificBookmarkManagerBase(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ProjectModel.ISolution solution, string ownerId, JetBrains.ProjectModel.ProjectModelElementPointerManager elementPointerManager) { }
        public JetBrains.DataFlow.ISignal<JetBrains.ReSharper.Feature.Services.Bookmarks.Model.AddRemoveBookmarkEventArgs<TManager, TData>> AddRemoveSignal { get; }
        protected JetBrains.ReSharper.Feature.Services.Bookmarks.Model.IBookmarkManager BookmarkManager { get; }
        protected JetBrains.ProjectModel.ProjectModelElementPointerManager ElementPointerManager { get; }
        public JetBrains.DataFlow.ISignal<JetBrains.ReSharper.Feature.Services.Bookmarks.Model.MoveBookmarkEventArgs<TManager, TData>> MoveSignal { get; }
        protected string OwnerId { get; }
        protected JetBrains.ProjectModel.ISolution Solution { get; }
        protected TData AddBookmark(string bookmarkKey, JetBrains.ProjectModel.IProjectModelElement file, JetBrains.DocumentModel.DocumentCoords coords) { }
        protected void AddBookmark(TKey specificBookmarkKey, JetBrains.ProjectModel.IProjectModelElement file, JetBrains.DocumentModel.DocumentCoords coords) { }
        protected virtual void BookmarkAdded(JetBrains.ReSharper.Feature.Services.Bookmarks.Model.AddRemoveBookmarkEventArgs<JetBrains.ReSharper.Feature.Services.Bookmarks.Model.IBookmarkManager, JetBrains.ReSharper.Feature.Services.Bookmarks.Model.BookmarkData> args) { }
        protected virtual void BookmarkMoved(JetBrains.ReSharper.Feature.Services.Bookmarks.Model.MoveBookmarkEventArgs<JetBrains.ReSharper.Feature.Services.Bookmarks.Model.IBookmarkManager, JetBrains.ReSharper.Feature.Services.Bookmarks.Model.BookmarkData> args) { }
        protected virtual void BookmarkRemoved(JetBrains.ReSharper.Feature.Services.Bookmarks.Model.AddRemoveBookmarkEventArgs<JetBrains.ReSharper.Feature.Services.Bookmarks.Model.IBookmarkManager, JetBrains.ReSharper.Feature.Services.Bookmarks.Model.BookmarkData> args) { }
        protected abstract TData ConvertData(JetBrains.ReSharper.Feature.Services.Bookmarks.Model.BookmarkData data);
        protected System.Collections.Generic.IEnumerable<TData> ConvertData(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.Bookmarks.Model.BookmarkData> bookmarks) { }
        protected abstract string ConvertSpecificKey(TKey specificKey);
        public TData GetBookmark(TKey numberedBookmarkId) { }
        public TData[] GetBookmarks() { }
        public TData[] GetBookmarksForDocument(JetBrains.ProjectModel.IProjectFile file) { }
        public bool HasAnyBookmark() { }
        public bool HasBookmark(TKey bookmarkKey) { }
        public bool HasBookmarks([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IProjectFile file) { }
        public bool IsBookmarkValid(TKey bookmarkKey) { }
        public void MoveBookmark(TKey bookmarkKey, JetBrains.DocumentModel.DocumentCoords newCoords) { }
        public bool RemoveBookmark(TKey numberedBookmarkId) { }
    }
    public class static XmlDocumentHelper
    {
        public static System.Collections.Generic.IEnumerable<System.Xml.XmlElement> GetChildElements(this System.Xml.XmlNode node) { }
        public static System.Collections.Generic.IEnumerable<System.Xml.XmlElement> GetChildElements(this System.Xml.XmlNode node, string name) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.Bookmarks.Manager
{
    
    public abstract class PlacementProviderBase<TData> : JetBrains.ReSharper.Feature.Services.Bookmarks.Model.IPlacementProvider
        where TData :  class
    {
        protected abstract TData DeserializeData(string serialized);
        protected abstract System.Nullable<JetBrains.DocumentModel.DocumentCoords> FindCoords(TData placementData, JetBrains.DocumentModel.IDocument document);
        protected abstract TData GetPlacementData(JetBrains.ReSharper.Feature.Services.Bookmarks.Model.BookmarkData markData);
        protected abstract string SerializeData(TData data);
    }
}
namespace JetBrains.ReSharper.Feature.Services.Bookmarks.Model
{
    
    public class AddRemoveBookmarkEventArgs<TMgr, TData> : JetBrains.ReSharper.Feature.Services.Bookmarks.Model.BookmarkEventArgs<TMgr, TData>
        where TMgr :  class
        where TData :  class
    {
        public AddRemoveBookmarkEventArgs([JetBrains.Annotations.NotNullAttribute()] TMgr manager, [JetBrains.Annotations.NotNullAttribute()] TData data, JetBrains.DataFlow.AddRemove action) { }
        public JetBrains.DataFlow.AddRemove Action { get; }
    }
    public class BookmarkData : JetBrains.ReSharper.Feature.Services.Bookmarks.Model.BookmarkDataBase<string>
    {
        public BookmarkData(JetBrains.ProjectModel.ISolution solution, [JetBrains.Annotations.NotNullAttribute()] string owner, [JetBrains.Annotations.NotNullAttribute()] string id, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IProjectModelElementPointer file, JetBrains.ReSharper.Feature.Services.Bookmarks.Model.BookmarkPersistence persistence, JetBrains.Util.dataStructures.TypedIntrinsics.Int32<JetBrains.DocumentModel.DocLine> line, JetBrains.Util.dataStructures.TypedIntrinsics.Int32<JetBrains.DocumentModel.DocColumn> column) { }
        public BookmarkData(JetBrains.ProjectModel.ISolution solution, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Feature.Services.Bookmarks.Model.BookmarkData data, JetBrains.DocumentModel.DocumentCoords newCoords) { }
        public BookmarkData(JetBrains.ProjectModel.ISolution solution, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Feature.Services.Bookmarks.Model.BookmarkData data, JetBrains.ProjectModel.IProjectModelElementPointer file) { }
        public BookmarkData(JetBrains.ProjectModel.ISolution solution, [JetBrains.Annotations.NotNullAttribute()] string owner, [JetBrains.Annotations.NotNullAttribute()] string id, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IProjectModelElementPointer file, JetBrains.ReSharper.Feature.Services.Bookmarks.Model.BookmarkPersistence persistence, JetBrains.DocumentModel.DocumentCoords coords) { }
        public string Owner { get; }
        public JetBrains.ReSharper.Feature.Services.Bookmarks.Model.BookmarkPersistence Persistence { get; }
    }
    public abstract class BookmarkDataBase<TKey>
    
    {
        protected BookmarkDataBase(JetBrains.ProjectModel.ISolution solution, [JetBrains.Annotations.NotNullAttribute()] TKey bookmarkId, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Feature.Services.Bookmarks.Model.BookmarkPlacement placement, JetBrains.DocumentModel.IRangeMarker rangeMarker = null) { }
        protected BookmarkDataBase(JetBrains.ProjectModel.ISolution solution, TKey bookmarkId, JetBrains.ProjectModel.IProjectModelElementPointer file, JetBrains.DocumentModel.DocumentCoords coords) { }
        public TKey BookmarkId { get; }
        public JetBrains.ReSharper.Feature.Services.Bookmarks.Model.BookmarkPlacement Placement { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.DocumentModel.IRangeMarker RangeMarker { get; }
        public JetBrains.DocumentModel.DocumentCoords GetLiveCoords() { }
    }
    public abstract class BookmarkEventArgs<TMgr, TData>
        where TMgr :  class
        where TData :  class
    {
        protected BookmarkEventArgs([JetBrains.Annotations.NotNullAttribute()] TMgr manager, [JetBrains.Annotations.NotNullAttribute()] TData data) { }
        public TData Data { get; }
        public TMgr Manager { get; }
    }
    public enum BookmarkPersistence
    {
        NonPersistable = 0,
        Local = 1,
        Shared = 2,
    }
    public class BookmarkPlacement : System.IEquatable<JetBrains.ReSharper.Feature.Services.Bookmarks.Model.BookmarkPlacement>
    {
        public BookmarkPlacement(JetBrains.ProjectModel.IProjectModelElementPointer file, JetBrains.DocumentModel.DocumentCoords docCoords) { }
        public JetBrains.DocumentModel.DocumentCoords DocCoords { get; }
        public JetBrains.ProjectModel.IProjectModelElementPointer File { get; }
        public bool Equals(JetBrains.ReSharper.Feature.Services.Bookmarks.Model.BookmarkPlacement other) { }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
    }
    public interface IBookmarkManager
    {
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.DataFlow.ISignal<JetBrains.ReSharper.Feature.Services.Bookmarks.Model.AddRemoveBookmarkEventArgs<JetBrains.ReSharper.Feature.Services.Bookmarks.Model.IBookmarkManager, JetBrains.ReSharper.Feature.Services.Bookmarks.Model.BookmarkData>> AddRemoveSignal { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.DataFlow.ISignal<JetBrains.ReSharper.Feature.Services.Bookmarks.Model.MoveBookmarkEventArgs<JetBrains.ReSharper.Feature.Services.Bookmarks.Model.IBookmarkManager, JetBrains.ReSharper.Feature.Services.Bookmarks.Model.BookmarkData>> MoveSignal { get; }
        void AddBookmark([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Feature.Services.Bookmarks.Model.BookmarkData data);
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Feature.Services.Bookmarks.Model.BookmarkData GetBookmark(string id);
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.Bookmarks.Model.BookmarkData> GetBookmarks();
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.Bookmarks.Model.BookmarkData> GetBookmarksForDocument([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IProjectModelElementPointer file);
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.Bookmarks.Model.BookmarkData> GetBookmarksForOwner(string owner);
        bool HasBookmark([JetBrains.Annotations.NotNullAttribute()] string id);
        bool HasBookmarks([JetBrains.Annotations.NotNullAttribute()] string owner);
        bool HasBookmarks([JetBrains.Annotations.NotNullAttribute()] string owner, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IProjectModelElementPointer file);
        bool IsBookmarkValid(string id);
        void MoveBookmark([JetBrains.Annotations.NotNullAttribute()] string id, JetBrains.DocumentModel.DocumentCoords newCoords);
        void RemoveBookmark([JetBrains.Annotations.NotNullAttribute()] string id);
    }
    public interface IPlacementProvider
    {
        object DeserializeData(string serialized);
        System.Nullable<JetBrains.DocumentModel.DocumentCoords> FindCoords(object placementData, JetBrains.DocumentModel.IDocument document);
        object GetPlacementData(JetBrains.ReSharper.Feature.Services.Bookmarks.Model.BookmarkData markData);
        string SerializeData(object placementData);
    }
    public interface ISpecificBookmarkManager<TManager, TKey, TData>
        where TManager :  class, JetBrains.ReSharper.Feature.Services.Bookmarks.Model.ISpecificBookmarkManager<, , >
    
        where TData : JetBrains.ReSharper.Feature.Services.Bookmarks.Model.BookmarkDataBase<>
    {
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.DataFlow.ISignal<JetBrains.ReSharper.Feature.Services.Bookmarks.Model.AddRemoveBookmarkEventArgs<TManager, TData>> AddRemoveSignal { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.DataFlow.ISignal<JetBrains.ReSharper.Feature.Services.Bookmarks.Model.MoveBookmarkEventArgs<TManager, TData>> MoveSignal { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        TData GetBookmark(TKey key);
        [JetBrains.Annotations.NotNullAttribute()]
        TData[] GetBookmarks();
        [JetBrains.Annotations.NotNullAttribute()]
        TData[] GetBookmarksForDocument([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IProjectFile file);
        void MoveBookmark(TKey bookmarkKey, JetBrains.DocumentModel.DocumentCoords newCoords);
        bool RemoveBookmark(TKey key);
    }
    public class MoveBookmarkEventArgs<TManager, TData> : JetBrains.ReSharper.Feature.Services.Bookmarks.Model.BookmarkEventArgs<TManager, TData>
        where TManager :  class
        where TData :  class
    {
        public MoveBookmarkEventArgs([JetBrains.Annotations.NotNullAttribute()] TManager manager, [JetBrains.Annotations.NotNullAttribute()] TData data, JetBrains.DocumentModel.DocumentCoords oldCoords) { }
        public JetBrains.DocumentModel.DocumentCoords OldCoords { get; }
    }
    public class PlacementData { }
    public class PlacementProviderAttribute : JetBrains.ProjectModel.SolutionComponentAttribute
    {
        public PlacementProviderAttribute(string providerName) { }
        public string ProviderName { get; }
    }
}
namespace JetBrains.ReSharper.Feature.Services.CallHierarchy
{
    
    public abstract class CallHierarchyFinder
    {
        public abstract System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.CallHierarchy.FindResults.CallHierarchyFindResult> FindImplementingConstructors([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.ITypeParameter typeParameter, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Progress.IProgressIndicator progressIndicator);
        public abstract System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.CallHierarchy.FindResults.CallHierarchyFindResult> FindImplementors(JetBrains.ReSharper.Psi.PsiLanguageType language, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.DeclaredElementInstance<JetBrains.ReSharper.Psi.IOverridableMember> overridableMember, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Progress.IProgressIndicator progressIndicator);
        public abstract System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.CallHierarchy.FindResults.CallHierarchyFindResult> FindIncoming([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.DeclaredElementInstance<JetBrains.ReSharper.Psi.ITypeMember> typeMemberInstance, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Progress.IProgressIndicator progressIndicator);
        public abstract System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.CallHierarchy.FindResults.CallHierarchyFindResult> FindIncoming([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.IInitializerOwnerDeclaration initializerOwnerDeclaration, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Progress.IProgressIndicator progressIndicator);
        public abstract System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.CallHierarchy.FindResults.CallHierarchyFindResult> FindOutgoing([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.DeclaredElementInstance<JetBrains.ReSharper.Psi.ITypeMember> typeMemberInstance, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Progress.IProgressIndicator progressIndicator);
        public abstract System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.CallHierarchy.FindResults.CallHierarchyFindResult> FindOutgoing([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.IExpression expression, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Progress.IProgressIndicator progressIndicator);
        public static JetBrains.ReSharper.Feature.Services.CallHierarchy.CallHierarchyFinder GetInstance(JetBrains.ReSharper.Psi.Services.CachingFinder finder) { }
    }
    public interface ICallHierarchyFindResultVisitor<TData, TReturn>
    
    
    {
        TReturn VisitIncomingEventSubscription(JetBrains.ReSharper.Feature.Services.CallHierarchy.FindResults.CallHierarchyFindResultIncomingEventSubscription @event, TData data);
        TReturn VisitIncomingInitializerOwner(JetBrains.ReSharper.Feature.Services.CallHierarchy.FindResults.CallHierarchyFindResultIncomingInitializerOwner owner, TData data);
        TReturn VisitIncomingTypeMember(JetBrains.ReSharper.Feature.Services.CallHierarchy.FindResults.CallHierarchyFindResultIncomingTypeMember member, TData data);
        TReturn VisitOutgoingClosure(JetBrains.ReSharper.Feature.Services.CallHierarchy.FindResults.CallHierarchyFindResultOutgoingClosure closure, TData data);
        TReturn VisitOutgoingExpression(JetBrains.ReSharper.Feature.Services.CallHierarchy.FindResults.CallHierarchyFindResultOutgoingExpression expression, TData data);
        TReturn VisitOutgoingImplementorMember(JetBrains.ReSharper.Feature.Services.CallHierarchy.FindResults.CallHierarchyFindResultOutgoingImplementorMember member, TData data);
        TReturn VisitOutgoingImplicitConstructor(JetBrains.ReSharper.Feature.Services.CallHierarchy.FindResults.CallHierarchyFindResultOutgoingImplicitConstructor implicitConstructor, TData data);
        TReturn VisitOutgoingInitializer(JetBrains.ReSharper.Feature.Services.CallHierarchy.FindResults.CallHierarchyFindResultOutgoingInitializer initalizer, TData data);
        TReturn VisitOutgoingOverridableMember(JetBrains.ReSharper.Feature.Services.CallHierarchy.FindResults.CallHierarchyFindResultOutgoingOverridableMember member, TData data);
        TReturn VisitOutgoingQuery(JetBrains.ReSharper.Feature.Services.CallHierarchy.FindResults.CallHierarchyFindResultOutgoingQuery query, TData data);
        TReturn VisitOutgoingTypeMember(JetBrains.ReSharper.Feature.Services.CallHierarchy.FindResults.CallHierarchyFindResultOutgoingTypeMember member, TData data);
        TReturn VisitOutgoingTypeParameterConstructor(JetBrains.ReSharper.Feature.Services.CallHierarchy.FindResults.CallHierarchyFindResultOutgoingTypeParameterConstructor constructor, TData data);
        TReturn VisitOutgoingUnresolved(JetBrains.ReSharper.Feature.Services.CallHierarchy.FindResults.CallHierarchyFindResultOutgoingUnresolved unresolved, TData data);
    }
}
namespace JetBrains.ReSharper.Feature.Services.CallHierarchy.FindResults
{
    
    public abstract class CallHierarchyFindResult
    {
        protected CallHierarchyFindResult([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode referenceElement) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Psi.Tree.ITreeNode ReferenceElement { get; }
        public abstract TReturn Accept<TData, TReturn>(JetBrains.ReSharper.Feature.Services.CallHierarchy.ICallHierarchyFindResultVisitor<TData, TReturn> visitor, TData data);
        public abstract int GetGroupingHashCode();
        public abstract bool GroupingEquals(object obj);
    }
    public class CallHierarchyFindResultIncomingEventSubscription : JetBrains.ReSharper.Feature.Services.CallHierarchy.FindResults.CallHierarchyFindResult
    {
        public CallHierarchyFindResultIncomingEventSubscription(JetBrains.ReSharper.Psi.DeclaredElementInstance<JetBrains.ReSharper.Psi.IEvent> eventInstance, JetBrains.ReSharper.Psi.ITypeMember containingMember, bool subsitutionIsOk, JetBrains.ReSharper.Psi.Tree.ITreeNode reference) { }
        public JetBrains.ReSharper.Psi.ITypeMember ContainingMember { get; }
        public JetBrains.ReSharper.Psi.DeclaredElementInstance<JetBrains.ReSharper.Psi.IEvent> EventInstance { get; }
        public bool SubstitutionIsOk { get; }
        public override TReturn Accept<TData, TReturn>(JetBrains.ReSharper.Feature.Services.CallHierarchy.ICallHierarchyFindResultVisitor<TData, TReturn> visitor, TData data) { }
        public override int GetGroupingHashCode() { }
        public override bool GroupingEquals(object obj) { }
    }
    public class CallHierarchyFindResultIncomingInitializerOwner : JetBrains.ReSharper.Feature.Services.CallHierarchy.FindResults.CallHierarchyFindResult
    {
        public CallHierarchyFindResultIncomingInitializerOwner(JetBrains.ReSharper.Psi.Tree.IInitializerOwnerDeclaration initializerOwnerDeclaration) { }
        public JetBrains.ReSharper.Psi.Tree.IInitializerOwnerDeclaration InitializerOwnerDeclaration { get; }
        public override TReturn Accept<TData, TReturn>(JetBrains.ReSharper.Feature.Services.CallHierarchy.ICallHierarchyFindResultVisitor<TData, TReturn> visitor, TData data) { }
        public override int GetGroupingHashCode() { }
        public override bool GroupingEquals(object obj) { }
    }
    public class CallHierarchyFindResultIncomingTypeMember : JetBrains.ReSharper.Feature.Services.CallHierarchy.FindResults.CallHierarchyFindResult
    {
        public CallHierarchyFindResultIncomingTypeMember(JetBrains.ReSharper.Psi.DeclaredElementInstance<JetBrains.ReSharper.Psi.ITypeMember> typeMemberInstance, bool subsitutionIsOk, JetBrains.ReSharper.Psi.Tree.ITreeNode reference) { }
        public bool SubstitutionIsOk { get; }
        public JetBrains.ReSharper.Psi.DeclaredElementInstance<JetBrains.ReSharper.Psi.ITypeMember> TypeMemberInstance { get; }
        public override TReturn Accept<TData, TReturn>(JetBrains.ReSharper.Feature.Services.CallHierarchy.ICallHierarchyFindResultVisitor<TData, TReturn> visitor, TData data) { }
        public override int GetGroupingHashCode() { }
        public override bool GroupingEquals(object obj) { }
    }
    public class CallHierarchyFindResultOutgoingClosure : JetBrains.ReSharper.Feature.Services.CallHierarchy.FindResults.CallHierarchyFindResultOutgoingExpression
    {
        public CallHierarchyFindResultOutgoingClosure(JetBrains.ReSharper.Psi.Tree.IExpression expression) { }
        public override TReturn Accept<TData, TReturn>(JetBrains.ReSharper.Feature.Services.CallHierarchy.ICallHierarchyFindResultVisitor<TData, TReturn> visitor, TData data) { }
    }
    public class CallHierarchyFindResultOutgoingExpression : JetBrains.ReSharper.Feature.Services.CallHierarchy.FindResults.CallHierarchyFindResult
    {
        protected CallHierarchyFindResultOutgoingExpression(JetBrains.ReSharper.Psi.Tree.IExpression expression) { }
        public JetBrains.ReSharper.Psi.Tree.IExpression Expression { get; }
        public override TReturn Accept<TData, TReturn>(JetBrains.ReSharper.Feature.Services.CallHierarchy.ICallHierarchyFindResultVisitor<TData, TReturn> visitor, TData data) { }
        public override int GetGroupingHashCode() { }
        public override bool GroupingEquals(object obj) { }
    }
    public class CallHierarchyFindResultOutgoingImplementorMember : JetBrains.ReSharper.Feature.Services.CallHierarchy.FindResults.CallHierarchyFindResult
    {
        public CallHierarchyFindResultOutgoingImplementorMember(JetBrains.ReSharper.Psi.DeclaredElementInstance<JetBrains.ReSharper.Psi.ITypeMember> typeMemberInstance, bool subsitutionIsOk, bool isQuasiImpelementation) { }
        public bool IsQuasiImplementaion { get; }
        public bool SubstitutionIsOk { get; }
        public JetBrains.ReSharper.Psi.DeclaredElementInstance<JetBrains.ReSharper.Psi.ITypeMember> TypeMemberInstance { get; }
        public override TReturn Accept<TData, TReturn>(JetBrains.ReSharper.Feature.Services.CallHierarchy.ICallHierarchyFindResultVisitor<TData, TReturn> visitor, TData data) { }
        public override int GetGroupingHashCode() { }
        public override bool GroupingEquals(object obj) { }
    }
    public class CallHierarchyFindResultOutgoingImplicitConstructor : JetBrains.ReSharper.Feature.Services.CallHierarchy.FindResults.CallHierarchyFindResult
    {
        public CallHierarchyFindResultOutgoingImplicitConstructor([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.DeclaredElementInstance<JetBrains.ReSharper.Psi.ITypeMember> typeMemberInstance, bool subsitutionIsOk) { }
        public bool SubstitutionIsOk { get; }
        public JetBrains.ReSharper.Psi.DeclaredElementInstance<JetBrains.ReSharper.Psi.ITypeMember> TypeMemberInstance { get; }
        public override TReturn Accept<TData, TReturn>(JetBrains.ReSharper.Feature.Services.CallHierarchy.ICallHierarchyFindResultVisitor<TData, TReturn> visitor, TData data) { }
        public override int GetGroupingHashCode() { }
        public override bool GroupingEquals(object obj) { }
    }
    public class CallHierarchyFindResultOutgoingInitializer : JetBrains.ReSharper.Feature.Services.CallHierarchy.FindResults.CallHierarchyFindResultOutgoingExpression
    {
        public CallHierarchyFindResultOutgoingInitializer(JetBrains.ReSharper.Psi.Tree.IExpression expression) { }
        public override TReturn Accept<TData, TReturn>(JetBrains.ReSharper.Feature.Services.CallHierarchy.ICallHierarchyFindResultVisitor<TData, TReturn> visitor, TData data) { }
    }
    public class CallHierarchyFindResultOutgoingOverridableMember : JetBrains.ReSharper.Feature.Services.CallHierarchy.FindResults.CallHierarchyFindResult
    {
        public CallHierarchyFindResultOutgoingOverridableMember([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.DeclaredElementInstance<JetBrains.ReSharper.Psi.IOverridableMember> overridableMemberInstance, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode referenceElement, bool substitutionIsOk) { }
        public int EstimatedInheritors { get; }
        public JetBrains.ReSharper.Psi.DeclaredElementInstance<JetBrains.ReSharper.Psi.IOverridableMember> OverridableMemberInstance { get; }
        public bool SubstitutionIsOk { get; }
        public override TReturn Accept<TData, TReturn>(JetBrains.ReSharper.Feature.Services.CallHierarchy.ICallHierarchyFindResultVisitor<TData, TReturn> visitor, TData data) { }
        public override int GetGroupingHashCode() { }
        public override bool GroupingEquals(object obj) { }
    }
    public class CallHierarchyFindResultOutgoingQuery : JetBrains.ReSharper.Feature.Services.CallHierarchy.FindResults.CallHierarchyFindResultOutgoingExpression
    {
        public CallHierarchyFindResultOutgoingQuery(JetBrains.ReSharper.Psi.Tree.IExpression expression) { }
        public override TReturn Accept<TData, TReturn>(JetBrains.ReSharper.Feature.Services.CallHierarchy.ICallHierarchyFindResultVisitor<TData, TReturn> visitor, TData data) { }
    }
    public class CallHierarchyFindResultOutgoingTypeMember : JetBrains.ReSharper.Feature.Services.CallHierarchy.FindResults.CallHierarchyFindResult
    {
        public CallHierarchyFindResultOutgoingTypeMember([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.DeclaredElementInstance<JetBrains.ReSharper.Psi.ITypeMember> typeMemberInstance, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode referenceElement, bool subsitutionIsOk) { }
        public bool SubstitutionIsOk { get; }
        public JetBrains.ReSharper.Psi.DeclaredElementInstance<JetBrains.ReSharper.Psi.ITypeMember> TypeMemberInstance { get; }
        public override TReturn Accept<TData, TReturn>(JetBrains.ReSharper.Feature.Services.CallHierarchy.ICallHierarchyFindResultVisitor<TData, TReturn> visitor, TData data) { }
        public override int GetGroupingHashCode() { }
        public override bool GroupingEquals(object obj) { }
    }
    public class CallHierarchyFindResultOutgoingTypeParameterConstructor : JetBrains.ReSharper.Feature.Services.CallHierarchy.FindResults.CallHierarchyFindResult
    {
        public CallHierarchyFindResultOutgoingTypeParameterConstructor([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.ITypeParameter typeParameter, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode referenceElement) { }
        public int EstimatedInheritors { get; }
        public JetBrains.ReSharper.Psi.ITypeParameter TypeParameter { get; }
        public override TReturn Accept<TData, TReturn>(JetBrains.ReSharper.Feature.Services.CallHierarchy.ICallHierarchyFindResultVisitor<TData, TReturn> visitor, TData data) { }
        public override int GetGroupingHashCode() { }
        public override bool GroupingEquals(object obj) { }
    }
    public class CallHierarchyFindResultOutgoingUnresolved : JetBrains.ReSharper.Feature.Services.CallHierarchy.FindResults.CallHierarchyFindResult
    {
        public CallHierarchyFindResultOutgoingUnresolved(JetBrains.ReSharper.Psi.Tree.ITreeNode referenceElement) { }
        public override TReturn Accept<TData, TReturn>(JetBrains.ReSharper.Feature.Services.CallHierarchy.ICallHierarchyFindResultVisitor<TData, TReturn> visitor, TData data) { }
        public override int GetGroupingHashCode() { }
        public override bool GroupingEquals(object obj) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.CallHierarchy.Impl
{
    
    public class CallHierarchyFinderImpl : JetBrains.ReSharper.Feature.Services.CallHierarchy.CallHierarchyFinder
    {
        public CallHierarchyFinderImpl(JetBrains.ReSharper.Psi.Services.CachingFinder finder) { }
        public override System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.CallHierarchy.FindResults.CallHierarchyFindResult> FindImplementingConstructors([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.ITypeParameter typeParameter, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
        public override System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.CallHierarchy.FindResults.CallHierarchyFindResult> FindImplementors([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.PsiLanguageType language, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.DeclaredElementInstance<JetBrains.ReSharper.Psi.IOverridableMember> overridableMember, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
        public override System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.CallHierarchy.FindResults.CallHierarchyFindResult> FindIncoming([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.DeclaredElementInstance<JetBrains.ReSharper.Psi.ITypeMember> typeMember, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
        public override System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.CallHierarchy.FindResults.CallHierarchyFindResult> FindIncoming([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.IInitializerOwnerDeclaration initializerOwnerDeclaration, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
        public override System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.CallHierarchy.FindResults.CallHierarchyFindResult> FindOutgoing([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.DeclaredElementInstance<JetBrains.ReSharper.Psi.ITypeMember> typeMemberInstance, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
        public override System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.CallHierarchy.FindResults.CallHierarchyFindResult> FindOutgoing([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.IExpression expression, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
    }
    public class CallHierarchyImplementorsSearchHelper
    {
        public CallHierarchyImplementorsSearchHelper(JetBrains.ReSharper.Psi.Services.CachingFinder finder) { }
        public System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.CallHierarchy.FindResults.CallHierarchyFindResult> FindImplementingConstructors(JetBrains.ReSharper.Psi.ITypeParameter typeParameter, JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
        public System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.CallHierarchy.FindResults.CallHierarchyFindResult> FindImplementors(JetBrains.ReSharper.Psi.PsiLanguageType language, JetBrains.ReSharper.Psi.DeclaredElementInstance<JetBrains.ReSharper.Psi.IOverridableMember> sourceMemberInstance, JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
    }
    public class CallHierarchyIncomingSearchHelper
    {
        public CallHierarchyIncomingSearchHelper(JetBrains.ReSharper.Psi.Services.CachingFinder finder) { }
        public System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.CallHierarchy.FindResults.CallHierarchyFindResult> FindCalledBy([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.DeclaredElementInstance<JetBrains.ReSharper.Psi.ITypeMember> sourceTypeMember, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
        public class Context
        {
            public JetBrains.Util.OneToListMap<JetBrains.ReSharper.Psi.ITypeMember, JetBrains.ReSharper.Psi.Resolve.ISubstitution> BaseElements { get; }
            public JetBrains.ReSharper.Psi.Tree.IDeclaration ContainingDeclaration { get; }
            public JetBrains.ReSharper.Psi.ITypeMember ContainingTypeMember { get; }
            public JetBrains.ReSharper.Psi.PsiLanguageType Language { get; }
            public JetBrains.ReSharper.Psi.Resolve.ISubstitution ParentSubstitution { get; }
            public JetBrains.ReSharper.Psi.ITypeMember ParentTypeElement { get; }
            public JetBrains.ReSharper.Psi.Resolve.IReference Reference { get; }
            public JetBrains.ReSharper.Psi.Tree.ITreeNode ReferenceElement { get; }
            public JetBrains.ReSharper.Psi.DeclaredElementInstance<JetBrains.ReSharper.Psi.ITypeMember> SourceElement { get; }
            [JetBrains.Annotations.CanBeNullAttribute()]
            public static JetBrains.ReSharper.Feature.Services.CallHierarchy.Impl.CallHierarchyIncomingSearchHelper.Context Create(JetBrains.ReSharper.Psi.DeclaredElementInstance<JetBrains.ReSharper.Psi.ITypeMember> sourceElement, JetBrains.Util.OneToListMap<JetBrains.ReSharper.Psi.ITypeMember, JetBrains.ReSharper.Psi.Resolve.ISubstitution> baseElements, JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
        }
    }
    public class CallHierarchyOutgoingSearchHelper
    {
        public static System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.CallHierarchy.FindResults.CallHierarchyFindResult> FindOutgoing([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.DeclaredElementInstance<JetBrains.ReSharper.Psi.ITypeMember> typeMemberInstance, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
        public static System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.CallHierarchy.FindResults.CallHierarchyFindResult> FindSourceElementsOutgoing([JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.Tree.ITreeNode> declarations, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Resolve.ISubstitution sourceSubstitution, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
    }
    public enum EventAccessType
    {
        None = 0,
        Add = 1,
        Remove = 2,
        Raise = 3,
    }
    public interface ICallHierarchyLanguageSpecific
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.IEvent ExtractEventReadWrite([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Resolve.IReference reference, out bool isSubscription);
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.IConstructor ExtractImplicitBaseConstructorCall([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IConstructor constructor);
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Tree.IExpression> ExtractInitializersFromDeclaration([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.IInitializerOwnerDeclaration initializerOwner);
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Feature.Services.CallHierarchy.FindResults.CallHierarchyFindResult ExtractSubscriber([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Resolve.IReference reference);
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.CallHierarchy.FindResults.CallHierarchyFindResult> ExtractSubscribersFromDeclaration([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.ITypeMember delegateTypeMember, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Progress.IProgressIndicator pi);
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Tree.IExpression GetClosure([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode element);
        JetBrains.ReSharper.Feature.Services.CallHierarchy.Impl.EventAccessType GetEventAccessType(JetBrains.ReSharper.Psi.Resolve.IReference reference);
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Tree.IExpression GetQuery(JetBrains.ReSharper.Psi.Tree.ITreeNode element);
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Tree.ITreeNode GetReferenceElement(JetBrains.ReSharper.Psi.Resolve.IReference reference);
        string GetUnresolvedPresentation(JetBrains.ReSharper.Psi.Tree.ITreeNode unresolvedElement);
        bool IsIncomingSkippedReference([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Resolve.IReference reference);
        bool IsMethodGroupReference([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Resolve.IReference reference);
    }
}
namespace JetBrains.ReSharper.Feature.Services.CallHierarchy.Strategy
{
    
    [JetBrains.Annotations.BaseTypeRequiredAttribute(typeof(JetBrains.ReSharper.Feature.Services.CallHierarchy.Strategy.ICallHierarchyFindResultSubdivider))]
    [JetBrains.Annotations.MeansImplicitUseAttribute()]
    [System.AttributeUsageAttribute(System.AttributeTargets.Class | System.AttributeTargets.All)]
    public class CallHierarchyFindResultSubdividerAttribute : JetBrains.ReSharper.Psi.ShellFeaturePartAttribute { }
    public interface ICallHierarchyFindResultSubdivider
    {
        object GetSubdivider(JetBrains.ReSharper.Feature.Services.CallHierarchy.FindResults.CallHierarchyFindResult result);
        bool IsApplicable(JetBrains.ReSharper.Feature.Services.CallHierarchy.FindResults.CallHierarchyFindResult result);
    }
}
namespace JetBrains.ReSharper.Feature.Services.CallHierarchy.View
{
    
    [JetBrains.ReSharper.Feature.Services.CallHierarchy.View.CallHierarchyIncomingTypeMemberNodePresenterAttribute()]
    public class CallHierarchyIncomingTypeMemberNodePresenter : JetBrains.ReSharper.Feature.Services.CallHierarchy.View.ICallHierarchyIncomingTypeMemberNodePresenter
    {
        public virtual JetBrains.DocumentModel.DocumentRange GetPreviewableDocumentRange(JetBrains.ReSharper.Feature.Services.CallHierarchy.View.ICallHierarchyPresentableNode node) { }
        public virtual bool IsApplicable(JetBrains.ReSharper.Feature.Services.CallHierarchy.View.ICallHierarchyPresentableNode nodeToPresent) { }
        public virtual void Present(JetBrains.ReSharper.Feature.Services.CallHierarchy.View.ICallHierarchyPresentableNode node, JetBrains.TreeModels.TreeModelNode structureElement, JetBrains.CommonControls.PresentableItem presentableItem, JetBrains.UI.TreeView.PresentationState state, JetBrains.ReSharper.Feature.Services.CallHierarchy.View.ICallHierarchyNodePresenter presenter) { }
    }
    [JetBrains.Annotations.BaseTypeRequiredAttribute(typeof(JetBrains.ReSharper.Feature.Services.CallHierarchy.View.ICallHierarchyIncomingTypeMemberNodePresenter))]
    [JetBrains.Annotations.MeansImplicitUseAttribute()]
    [System.AttributeUsageAttribute(System.AttributeTargets.Class | System.AttributeTargets.All)]
    public class CallHierarchyIncomingTypeMemberNodePresenterAttribute : JetBrains.ReSharper.Psi.ShellFeaturePartAttribute { }
    public interface ICallHierarchyIncomingTypeMemberNodePresenter
    {
        JetBrains.DocumentModel.DocumentRange GetPreviewableDocumentRange(JetBrains.ReSharper.Feature.Services.CallHierarchy.View.ICallHierarchyPresentableNode node);
        bool IsApplicable(JetBrains.ReSharper.Feature.Services.CallHierarchy.View.ICallHierarchyPresentableNode nodeToPresent);
        void Present(JetBrains.ReSharper.Feature.Services.CallHierarchy.View.ICallHierarchyPresentableNode node, JetBrains.TreeModels.TreeModelNode structureElement, JetBrains.CommonControls.PresentableItem presentableItem, JetBrains.UI.TreeView.PresentationState state, JetBrains.ReSharper.Feature.Services.CallHierarchy.View.ICallHierarchyNodePresenter presenter);
    }
    public interface ICallHierarchyNodePresenter
    {
        void UpdateItem(object value, JetBrains.TreeModels.TreeModelNode structureElement, JetBrains.CommonControls.IPresentableItem item, JetBrains.UI.TreeView.PresentationState state);
    }
    public interface ICallHierarchyPresentableNode
    {
        JetBrains.ReSharper.Psi.Pointers.IElementInstancePointer<JetBrains.ReSharper.Psi.ITypeMember> ElementInstancePointer { get; }
        System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.Tree.ITreeNode> GetOccurences();
    }
}
namespace JetBrains.ReSharper.Feature.Services.Clipboard
{
    
    [JetBrains.Application.ShellComponentAttribute()]
    public class ClipboardHelper
    {
        public ClipboardHelper(JetBrains.Threading.IThreading threading, JetBrains.UI.Clipboard clipboard, JetBrains.ReSharper.Feature.Services.Clipboard.ClipboardManager clipboardManager, JetBrains.DataFlow.Lifetime lifetime) { }
        protected JetBrains.UI.Clipboard Clipboard { get; }
        protected JetBrains.ReSharper.Feature.Services.Clipboard.ClipboardManager ClipboardManager { get; }
        public static JetBrains.ReSharper.Feature.Services.Clipboard.ClipboardHelper Instance { get; }
        public virtual void QueueAction(string name, [JetBrains.Annotations.NotNullAttribute()] System.Action<JetBrains.UI.Clipboard, JetBrains.ReSharper.Feature.Services.Clipboard.ClipboardManager> action) { }
    }
    public abstract class ClipboardManager
    {
        public abstract System.Collections.Generic.IEnumerable<System.Windows.Forms.IDataObject> ClipboardEntries { get; }
        public abstract void AddClipboardEntry(System.Windows.Forms.IDataObject dataObject);
        public abstract void RegisterCopyHandler(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ReSharper.Feature.Services.Clipboard.ClipboardManager.Handler handler);
        public abstract void RegisterCutHandler(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ReSharper.Feature.Services.Clipboard.ClipboardManager.Handler handler);
        public abstract void RegisterPasteHandler(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ReSharper.Feature.Services.Clipboard.ClipboardManager.Handler handler);
        public delegate void Handler(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.DelegateExecute nextExecute);
    }
}
namespace JetBrains.ReSharper.Feature.Services.CodeCleanup
{
    
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class CodeCleanup
    {
        public CodeCleanup(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ReSharper.Feature.Services.CodeCleanup.CodeCleanupSettingsComponent settings, JetBrains.DocumentManagers.DocumentManager documentManager, JetBrains.ProjectModel.impl.SpecialFiles.SpecialFilesManager specialFilesManager) { }
        public static JetBrains.ReSharper.Feature.Services.CodeCleanup.CodeCleanup GetInstance(JetBrains.ProjectModel.ISolution solution) { }
        public bool IsAvailable(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, JetBrains.DocumentModel.DocumentRange range) { }
        public bool IsSuitableFile(JetBrains.ProjectModel.IProjectFile projectFile) { }
        public void Run(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, JetBrains.DocumentModel.DocumentRange range, ref int caret, JetBrains.ReSharper.Feature.Services.CodeCleanup.CodeCleanupProfile profile, JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
        public enum DefaultProfileType
        {
            FULL = 0,
            REFORMAT = 1,
        }
    }
    [System.ComponentModel.TypeConverterAttribute(typeof(JetBrains.ReSharper.Feature.Services.CodeCleanup.CodeCleanupBoolOptionDescriptor.BooleanTypeConverter))]
    public class CodeCleanupBoolOptionDescriptor : JetBrains.ReSharper.Feature.Services.CodeCleanup.CodeCleanupOptionDescriptor<bool>
    {
        public CodeCleanupBoolOptionDescriptor(string name) { }
        public override bool Load(System.Xml.XmlElement element) { }
        public override string Present(JetBrains.ReSharper.Feature.Services.CodeCleanup.CodeCleanupProfile profile) { }
        public override void Save(System.Xml.XmlElement element, bool value) { }
    }
    [System.ComponentModel.TypeConverterAttribute(typeof(JetBrains.ReSharper.Feature.Services.CodeCleanup.CodeCleanupOptionDescriptor.EnumTypeConverter))]
    public class CodeCleanupEnumOptionDescriptor<T> : JetBrains.ReSharper.Feature.Services.CodeCleanup.CodeCleanupOptionDescriptor<T>
        where T :  struct
    {
        public CodeCleanupEnumOptionDescriptor(string name) { }
        public override T Load(System.Xml.XmlElement element) { }
        public override string Present(JetBrains.ReSharper.Feature.Services.CodeCleanup.CodeCleanupProfile profile) { }
        public override void Save(System.Xml.XmlElement element, T value) { }
    }
    [JetBrains.Annotations.BaseTypeRequiredAttribute(typeof(JetBrains.ReSharper.Feature.Services.CodeCleanup.ICodeCleanupModule))]
    [JetBrains.Annotations.MeansImplicitUseAttribute()]
    [System.AttributeUsageAttribute(System.AttributeTargets.Class | System.AttributeTargets.All)]
    public class CodeCleanupModuleAttribute : JetBrains.Application.ShellComponentAttribute
    {
        public CodeCleanupModuleAttribute() { }
        public System.Type[] ModulesAfter { get; set; }
        public System.Type[] ModulesBefore { get; set; }
    }
    public abstract class CodeCleanupOptionDescriptor
    {
        public const string AspCategory = "ASP.NET";
        public const string CSharpCategory = "C#";
        public const string CssCategory = "CSS";
        public const string HtmlCategory = "HTML";
        public const string JavaScriptCategory = "JavaScript";
        public const string VBasicCategory = "Visual Basic .NET";
        public const string XamlCategory = "XAML";
        public const string XmlCategory = "XML";
        protected CodeCleanupOptionDescriptor(string name, System.Type type) { }
        public string Name { get; }
        public System.Type Type { get; }
        public abstract string Present(JetBrains.ReSharper.Feature.Services.CodeCleanup.CodeCleanupProfile profile);
        public class EnumTypeConverter : System.ComponentModel.EnumConverter
        {
            public EnumTypeConverter(System.Type type) { }
            public override object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value) { }
            public override object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destType) { }
        }
    }
    public abstract class CodeCleanupOptionDescriptor<T> : JetBrains.ReSharper.Feature.Services.CodeCleanup.CodeCleanupOptionDescriptor
        where T : new()
    {
        protected CodeCleanupOptionDescriptor(string name) { }
        public T DefaultValue { get; }
        public abstract T Load(System.Xml.XmlElement element);
        public abstract void Save(System.Xml.XmlElement element, T value);
    }
    public class CodeCleanupProfile
    {
        public CodeCleanupProfile(bool isDefault, string profileContents) { }
        public bool IsDefault { get; }
        public string Name { get; set; }
        public string ProfileContents { get; }
        public JetBrains.ReSharper.Feature.Services.CodeCleanup.CodeCleanupProfile Clone() { }
        public object GetSetting(JetBrains.ReSharper.Feature.Services.CodeCleanup.CodeCleanupOptionDescriptor key) { }
        public T GetSetting<T>(JetBrains.ReSharper.Feature.Services.CodeCleanup.CodeCleanupOptionDescriptor<T> key)
            where T : new() { }
        public void SetSetting(JetBrains.ReSharper.Feature.Services.CodeCleanup.CodeCleanupOptionDescriptor key, object value) { }
        public void SetSetting<T>(JetBrains.ReSharper.Feature.Services.CodeCleanup.CodeCleanupOptionDescriptor<T> key, T value)
            where T : new() { }
    }
    [JetBrains.Application.Settings.SettingsKeyAttribute(typeof(JetBrains.ReSharper.Settings.CodeStyleSettings), "Code Cleanup settings")]
    public class CodeCleanupSettings
    {
        [JetBrains.Application.Settings.SettingsIndexedEntryAttribute("Custom profiles collection")]
        public JetBrains.Application.Settings.Store.IIndexedEntry<string, string> Profiles;
        [JetBrains.Application.Settings.SettingsEntryAttribute(null, "Recently used profile")]
        public string RecentlyUsedProfile;
        [JetBrains.Application.Settings.SettingsEntryAttribute(null, "Profile to use for silent cleanup")]
        public string SilentCleanupProfile;
    }
    [JetBrains.ReSharper.Psi.PsiSharedComponentAttribute()]
    public class CodeCleanupSettingsComponent
    {
        protected readonly System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.CodeCleanup.ICodeCleanupModule> myModules;
        public CodeCleanupSettingsComponent(JetBrains.DataFlow.Lifetime lifetime, JetBrains.DataFlow.IViewable<JetBrains.ReSharper.Feature.Services.CodeCleanup.ICodeCleanupModule> modules) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.CodeCleanup.ICodeCleanupModule> Modules { get; }
        public JetBrains.ReSharper.Feature.Services.CodeCleanup.CodeCleanupProfile CreateEmptyProfile(string name) { }
        public JetBrains.ReSharper.Feature.Services.CodeCleanup.CodeCleanupProfile GetDefaultProfile(JetBrains.ReSharper.Feature.Services.CodeCleanup.CodeCleanup.DefaultProfileType profileType) { }
        public System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.CodeCleanup.CodeCleanupProfile> GetProfiles(JetBrains.Application.Settings.IContextBoundSettingsStore store) { }
        public JetBrains.ReSharper.Feature.Services.CodeCleanup.CodeCleanupProfile GetRecentlyUsedProfile(JetBrains.Application.Settings.IContextBoundSettingsStore store) { }
        public JetBrains.ReSharper.Feature.Services.CodeCleanup.CodeCleanupProfile GetSilentCleanupProfile(JetBrains.Application.Settings.IContextBoundSettingsStore store) { }
        public void SetProfiles(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.CodeCleanup.CodeCleanupProfile> profiles, JetBrains.Application.Settings.IContextBoundSettingsStore store) { }
        public void SetRecentlyUsedProfileName(JetBrains.Application.Settings.IContextBoundSettingsStore store, string name) { }
        public void SetSilentCleanupProfileName(JetBrains.Application.Settings.IContextBoundSettingsStore store, string name) { }
    }
    [JetBrains.Application.Configuration.Upgrade.GlobalSettingsUpgraderAttribute()]
    public class CodeCleanupSettingsUpgrader : JetBrains.Application.Configuration.Upgrade.IGlobalSettingsUpgrader, JetBrains.Application.Configuration.Upgrade.ISettingsUpgrader { }
    public interface ICodeCleanupModule
    {
        System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.CodeCleanup.CodeCleanupOptionDescriptor> Descriptors { get; }
        bool IsAvailableOnSelection { get; }
        JetBrains.ReSharper.Psi.PsiLanguageType LanguageType { get; }
        bool IsAvailable([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile);
        void Process([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.DocumentModel.IRangeMarker rangeMarker, JetBrains.ReSharper.Feature.Services.CodeCleanup.CodeCleanupProfile profile, JetBrains.Application.Progress.IProgressIndicator progressIndicator);
        void SetDefaultSetting(JetBrains.ReSharper.Feature.Services.CodeCleanup.CodeCleanupProfile profile, JetBrains.ReSharper.Feature.Services.CodeCleanup.CodeCleanup.DefaultProfileType profileType);
    }
    public interface IFileHeaderUtils
    {
        System.Collections.Generic.IEnumerable<System.Collections.Generic.IEnumerable<JetBrains.ReSharper.LiveTemplates.TemplateField>> EnumerateFieldGroups();
    }
}
namespace JetBrains.ReSharper.Feature.Services.CodeCleanup.HighlightingModule
{
    
    [JetBrains.Annotations.BaseTypeRequiredAttribute(typeof(JetBrains.ReSharper.Feature.Services.CodeCleanup.HighlightingModule.IHighlightingsCleanupItem))]
    [JetBrains.Annotations.MeansImplicitUseAttribute()]
    public class HighlightingCleanupItemAttribute : JetBrains.Application.Parts.PartAttribute
    {
        public HighlightingCleanupItemAttribute(params JetBrains.ReSharper.Daemon.Severity[] severity) { }
        public JetBrains.ReSharper.Daemon.Severity[] AllowedSeverity { get; }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class HighlightingCleanupItemTable
    {
        public HighlightingCleanupItemTable(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.Parts.IPartsCatalogueSet catalog) { }
        public static JetBrains.ReSharper.Feature.Services.CodeCleanup.HighlightingModule.HighlightingCleanupItemTable Instance { get; }
        public JetBrains.ReSharper.Feature.Services.CodeCleanup.HighlightingModule.IHighlightingsCleanupItem CreateCleanupItem(JetBrains.ReSharper.Daemon.IHighlighting highlighting, JetBrains.ReSharper.Feature.Services.CodeCleanup.CodeCleanupProfile profile, ref bool skippedHighightings) { }
    }
    public abstract class HighlightingCleanupModuleBase
    {
        public static readonly JetBrains.ReSharper.Feature.Services.CodeCleanup.HighlightingModule.HighlightingCleanupModuleBase.RemoveOnlyRedundanciesOfTypeDescriptor REMOVE_ONLY_REDUNDANCIES_OF_TYPE_DESCRIPTOR;
        public static readonly JetBrains.ReSharper.Feature.Services.CodeCleanup.CodeCleanupBoolOptionDescriptor REMOVE_REDUNDANCIES_DESCRIPTOR;
        public static JetBrains.ReSharper.Feature.Services.CodeCleanup.CodeCleanupProfile CreateProfileForRedundancyItem(JetBrains.ReSharper.Feature.Services.CodeCleanup.HighlightingModule.IHighlightingsCleanupItem item) { }
        public static void FillProfileForRedundancyItem(JetBrains.ReSharper.Feature.Services.CodeCleanup.HighlightingModule.IHighlightingsCleanupItem item, JetBrains.ReSharper.Feature.Services.CodeCleanup.CodeCleanupProfile profile) { }
        public static bool IsRedundancyItemAllowedByProfile(JetBrains.ReSharper.Feature.Services.CodeCleanup.CodeCleanupProfile profile, JetBrains.ReSharper.Feature.Services.CodeCleanup.HighlightingModule.IHighlightingsCleanupItem item) { }
        public class RemoveOnlyRedundanciesOfTypeDescriptor : JetBrains.ReSharper.Feature.Services.CodeCleanup.CodeCleanupOptionDescriptor<JetBrains.ReSharper.Feature.Services.CodeCleanup.HighlightingModule.HighlightingCleanupModuleBase.RemoveOnlyRedundanciesOfTypeOptions>
        {
            public RemoveOnlyRedundanciesOfTypeDescriptor() { }
            public override JetBrains.ReSharper.Feature.Services.CodeCleanup.HighlightingModule.HighlightingCleanupModuleBase.RemoveOnlyRedundanciesOfTypeOptions Load(System.Xml.XmlElement element) { }
            public override string Present(JetBrains.ReSharper.Feature.Services.CodeCleanup.CodeCleanupProfile profile) { }
            public override void Save(System.Xml.XmlElement element, JetBrains.ReSharper.Feature.Services.CodeCleanup.HighlightingModule.HighlightingCleanupModuleBase.RemoveOnlyRedundanciesOfTypeOptions value) { }
        }
        public class RemoveOnlyRedundanciesOfTypeOptions
        {
            public RemoveOnlyRedundanciesOfTypeOptions() { }
            public RemoveOnlyRedundanciesOfTypeOptions(string allowedTypes) { }
            public string AllowedTypes { get; set; }
            public bool IsHighlightingAllowed(JetBrains.ReSharper.Feature.Services.CodeCleanup.HighlightingModule.IHighlightingsCleanupItem item) { }
        }
    }
    public abstract class HighlightingCleanupModuleBase<TPsiLanguage> : JetBrains.ReSharper.Feature.Services.CodeCleanup.HighlightingModule.HighlightingCleanupModuleBase, JetBrains.ReSharper.Feature.Services.CodeCleanup.ICodeCleanupModule
        where TPsiLanguage : JetBrains.ReSharper.Psi.PsiLanguageType
    {
        public abstract System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.CodeCleanup.CodeCleanupOptionDescriptor> Descriptors { get; }
        public virtual bool IsAvailableOnSelection { get; }
        public abstract JetBrains.ReSharper.Psi.PsiLanguageType LanguageType { get; }
        protected abstract bool IsAvailable(JetBrains.ReSharper.Feature.Services.CodeCleanup.CodeCleanupProfile profile);
        public virtual bool IsAvailable(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
        public virtual void Process(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, JetBrains.DocumentModel.IRangeMarker rangeMarker, JetBrains.ReSharper.Feature.Services.CodeCleanup.CodeCleanupProfile profile, JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
        public abstract void SetDefaultSetting(JetBrains.ReSharper.Feature.Services.CodeCleanup.CodeCleanupProfile profile, JetBrains.ReSharper.Feature.Services.CodeCleanup.CodeCleanup.DefaultProfileType profileType);
    }
    public interface IHighlightingsCleanupItem
    {
        void Execute();
        bool IsAvailable(JetBrains.ReSharper.Feature.Services.CodeCleanup.CodeCleanupProfile profile);
        bool IsValid();
    }
}
namespace JetBrains.ReSharper.Feature.Services.CodeCompletion
{
    
    public enum AutocompletionBehaviour
    {
        NoRecommendation = 0,
        DoNotAutocomplete = 1,
        AutocompleteWithInsert = 2,
        AutocompleteWithReplace = 3,
    }
    public class AutomaticCodeCompletionSession : JetBrains.ReSharper.Feature.Services.CodeCompletion.CodeCompletionSession
    {
        public AutomaticCodeCompletionSession(JetBrains.TextControl.ITextControl textControl, System.Collections.Generic.IList<JetBrains.ReSharper.Feature.Services.CodeCompletion.IAutomaticCodeCompletionStrategy> strategies, JetBrains.ReSharper.Feature.Services.CodeCompletion.CodeCompletionParameters modifer, JetBrains.ReSharper.Feature.Services.CodeCompletion.IntellisenseManager manager, JetBrains.DataFlow.Lifetime lifetime, bool isEnabledInTests, System.Action<JetBrains.ReSharper.Feature.Services.CodeCompletion.ICodeCompletionResult> onSessionFinished, JetBrains.Application.ActivityTrackingNew.IActivityTracking activityTracking) { }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Feature.Services.CodeCompletion.IAutomaticCodeCompletionStrategy> Strategies { get; }
        public override bool CaretPositionIsValid() { }
        public void ExecuteCompletion(bool async) { }
        public void ExecuteDelayed(JetBrains.Application.Settings.ISettingsStore settingsStore) { }
        public void ExecuteRightAway(bool async, JetBrains.ReSharper.Feature.Services.CodeCompletion.EvaluationMode evaluationMode = 0) { }
        public void ProcessSubsequentTyping(char c, JetBrains.TextControl.ITextControl textControl) { }
    }
    public class static AutomaticCodeCompletionStrategyEx
    {
        public static bool MatchText(this JetBrains.ReSharper.Feature.Services.CodeCompletion.IAutomaticCodeCompletionStrategy strategy, JetBrains.TextControl.ITextControl textControl, int length, System.Func<string, bool> matcher, bool ignoreSpaces = False) { }
        public static bool MatchToken<TToken>(this JetBrains.ReSharper.Feature.Services.CodeCompletion.IAutomaticCodeCompletionStrategy strategy, JetBrains.ReSharper.Psi.Tree.IFile file, JetBrains.TextControl.ITextControl textControl, System.Func<TToken, bool> matcher)
            where TToken :  class, JetBrains.ReSharper.Psi.Tree.ITokenNode { }
        public static bool MatchToken(this JetBrains.ReSharper.Feature.Services.CodeCompletion.IAutomaticCodeCompletionStrategy strategy, JetBrains.ReSharper.Psi.Tree.IFile file, JetBrains.TextControl.ITextControl textControl, System.Func<JetBrains.ReSharper.Psi.Tree.ITokenNode, bool> matcher) { }
        public static bool MatchTokenType(this JetBrains.ReSharper.Feature.Services.CodeCompletion.IAutomaticCodeCompletionStrategy strategy, JetBrains.ReSharper.Psi.Tree.IFile file, JetBrains.TextControl.ITextControl textControl, System.Func<JetBrains.ReSharper.Psi.Parsing.TokenNodeType, bool> matcher) { }
    }
    public class CodeCompletionCache
    {
        protected CodeCompletionCache() { }
        public JetBrains.ReSharper.Feature.Services.Lookup.DeclaredElementLookupItem GetLookupItem(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, System.Func<JetBrains.ReSharper.Feature.Services.Lookup.DeclaredElementLookupItem> factory, System.Action<JetBrains.ReSharper.Feature.Services.Lookup.DeclaredElementLookupItem> initialize) { }
    }
    public class CodeCompletionModifierProvider
    {
        public virtual JetBrains.ReSharper.Feature.Services.CodeCompletion.CodeCompletionParameters GetModifier(JetBrains.Application.Settings.IContextBoundSettingsStore settingsStore, JetBrains.ReSharper.Feature.Services.CodeCompletion.CodeCompletionSession session, JetBrains.ReSharper.Feature.Services.CodeCompletion.CodeCompletionType codeCompletionType) { }
        public virtual JetBrains.ReSharper.Feature.Services.CodeCompletion.CodeCompletionParameters GetModifier(System.Collections.Generic.List<JetBrains.ReSharper.Feature.Services.CodeCompletion.CodeCompletionType> codeCompletionTypes, JetBrains.ReSharper.Feature.Services.CodeCompletion.CodeCompletionType codeCompletionType) { }
        public JetBrains.ReSharper.Feature.Services.CodeCompletion.CodeCompletionParameters GetModifier(System.Collections.Generic.List<JetBrains.ReSharper.Feature.Services.CodeCompletion.CodeCompletionType> codeCompletionTypes) { }
        public static JetBrains.ReSharper.Feature.Services.CodeCompletion.CodeCompletionParameters GetModifierBasic(JetBrains.Application.Settings.IContextBoundSettingsStore settingsStore, JetBrains.ReSharper.Feature.Services.CodeCompletion.CodeCompletionSession session, JetBrains.ReSharper.Feature.Services.CodeCompletion.CodeCompletionType codeCompletionType, bool ignoreSmartCompletionAfterAutomatic = True, bool ignoreBasicCompletionAfterAutomatic = True, bool ignoreBasicAfterSmart = True) { }
        public static JetBrains.ReSharper.Feature.Services.CodeCompletion.CodeCompletionParameters GetModifierBasic(System.Collections.Generic.List<JetBrains.ReSharper.Feature.Services.CodeCompletion.CodeCompletionType> codeCompletionTypes, JetBrains.ReSharper.Feature.Services.CodeCompletion.CodeCompletionType codeCompletionType, bool ignoreSmartCompletionAfterAutomatic = True, bool ignoreBasicCompletionAfterAutomatic = True, bool ignoreBasicAfterSmart = True, bool ignoreImportAfterBasic = False, bool ignoreImportAfterAuto = False) { }
    }
    public class CodeCompletionParameters : JetBrains.Util.EnumPattern
    {
        public static readonly JetBrains.ReSharper.Feature.Services.CodeCompletion.CodeCompletionParameters Double;
        public static readonly JetBrains.ReSharper.Feature.Services.CodeCompletion.CodeCompletionParameters None;
        public static readonly JetBrains.ReSharper.Feature.Services.CodeCompletion.CodeCompletionParameters Single;
        public CodeCompletionParameters([JetBrains.Annotations.NotNullAttribute()] string name, int multiplier) { }
        public CodeCompletionParameters([JetBrains.Annotations.NotNullAttribute()] string name, int multiplier, JetBrains.ReSharper.Feature.Services.CodeCompletion.CodeCompletionType[] codeCompletionTypes, JetBrains.ReSharper.Feature.Services.CodeCompletion.CodeCompletionType lastCodeCompletionType, JetBrains.ReSharper.Feature.Services.CodeCompletion.AutocompletionBehaviour initialAutocompletionBehaviour = 0, JetBrains.ReSharper.Feature.Services.Lookup.LookupFocusBehaviour initialLookupFocusBehaviour = 0, JetBrains.ReSharper.Feature.Services.CodeCompletion.EvaluationMode evaluationMode = 0) { }
        public JetBrains.ReSharper.Feature.Services.CodeCompletion.CodeCompletionType[] CodeCompletionTypes { get; }
        public JetBrains.ReSharper.Feature.Services.CodeCompletion.EvaluationMode EvaluationMode { get; set; }
        public JetBrains.ReSharper.Feature.Services.CodeCompletion.AutocompletionBehaviour InitialAutocompletionBehavior { get; set; }
        public JetBrains.ReSharper.Feature.Services.Lookup.LookupFocusBehaviour InitialLookupFocusBehaviour { get; set; }
        public JetBrains.ReSharper.Feature.Services.CodeCompletion.CodeCompletionType LastCodeCompletionType { get; }
        public int Multiplier { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Feature.Services.CodeCompletion.ICodeCompletionResult PreviousResult { get; set; }
        public bool SingleCompletionMode { get; set; }
        public void Clear() { }
        public static JetBrains.ReSharper.Feature.Services.CodeCompletion.CodeCompletionParameters CreateDouble(JetBrains.ReSharper.Feature.Services.CodeCompletion.CodeCompletionType[] codeCompletionTypes, JetBrains.ReSharper.Feature.Services.CodeCompletion.CodeCompletionType lastCodeCompletionType) { }
        public static JetBrains.ReSharper.Feature.Services.CodeCompletion.CodeCompletionParameters CreateMultiple(int multiplier, JetBrains.ReSharper.Feature.Services.CodeCompletion.CodeCompletionType[] codeCompleTypes, JetBrains.ReSharper.Feature.Services.CodeCompletion.CodeCompletionType lastCodeCompletionType) { }
        public static JetBrains.ReSharper.Feature.Services.CodeCompletion.CodeCompletionParameters CreateSingle(JetBrains.ReSharper.Feature.Services.CodeCompletion.CodeCompletionType codeCompletionType) { }
        public static JetBrains.ReSharper.Feature.Services.CodeCompletion.CodeCompletionParameters CreateSingle(JetBrains.ReSharper.Feature.Services.CodeCompletion.CodeCompletionType[] codeCompletionTypes, JetBrains.ReSharper.Feature.Services.CodeCompletion.CodeCompletionType lastCodeCompletionType) { }
        public JetBrains.UI.RichText.RichTextBlock[] RenderCodeCompletionType() { }
        public override string ToString() { }
    }
    public enum CodeCompletionPopupType
    {
        AutomaticAfterDot = 0,
        AutomaticIdentifier = 1,
    }
    public abstract class CodeCompletionSession : JetBrains.ReSharper.Feature.Services.CodeCompletion.ICodeCompletionSession
    {
        protected CodeCompletionSession(JetBrains.DataFlow.Lifetime lifetime, JetBrains.TextControl.ITextControl textControl, JetBrains.ReSharper.Feature.Services.CodeCompletion.CodeCompletionParameters parameters, JetBrains.ReSharper.Feature.Services.CodeCompletion.IntellisenseManager completionManager, System.Action<JetBrains.ReSharper.Feature.Services.CodeCompletion.ICodeCompletionResult> onSessionFinished) { }
        protected JetBrains.ReSharper.Feature.Services.CodeCompletion.IntellisenseManager CompletionManager { get; }
        public bool Finished { get; set; }
        protected JetBrains.DataFlow.Lifetime Lifetime { get; }
        public JetBrains.ReSharper.Feature.Services.CodeCompletion.CodeCompletionParameters Parameters { get; set; }
        protected System.Action<JetBrains.ReSharper.Feature.Services.CodeCompletion.ICodeCompletionResult> SessionFinished { get; }
        public JetBrains.TextControl.ITextControl TextControl { get; }
        protected virtual void AdjustLookupOptions(JetBrains.ReSharper.Feature.Services.Lookup.LookupWindowOptions options) { }
        public virtual bool CaretPositionIsValid() { }
        protected void ShowEmptyLookup() { }
        protected void ShowHint(JetBrains.ReSharper.Feature.Services.CodeCompletion.ICodeCompletionResult result) { }
        protected void ShowLookup(JetBrains.ReSharper.Feature.Services.CodeCompletion.ICodeCompletionResult result, bool initialPrefixIsShortest, System.Action onItemCompleted, bool forceSoft, bool autmaticCompletion = False) { }
        protected void UpdateLookup(JetBrains.ReSharper.Feature.Services.CodeCompletion.ICodeCompletionResult result, System.Action onItemCompleted, bool forceSoft, JetBrains.ReSharper.Feature.Services.Lookup.ItemsLocation location, JetBrains.ReSharper.Feature.Services.CodeCompletion.ICodeCompletionResult previousResult) { }
    }
    public class CodeCompletionType : JetBrains.Util.EnumPattern
    {
        public static readonly JetBrains.ReSharper.Feature.Services.CodeCompletion.CodeCompletionType AutomaticCompletion;
        public static readonly JetBrains.ReSharper.Feature.Services.CodeCompletion.CodeCompletionType BasicCompletion;
        public static readonly JetBrains.ReSharper.Feature.Services.CodeCompletion.CodeCompletionType ImportCompletion;
        public static readonly JetBrains.ReSharper.Feature.Services.CodeCompletion.CodeCompletionType SmartCompletion;
    }
    public class static CodeCompletionUtil
    {
        public static bool CanBeInstantiated(JetBrains.ReSharper.Psi.IDeclaredType type) { }
        public static System.Collections.Generic.IEnumerable<JetBrains.Util.Pair<JetBrains.ReSharper.Psi.IType, JetBrains.ReSharper.Psi.ExpectedTypes.TailType>> GetExpectedTypes(System.Collections.Generic.IList<JetBrains.ReSharper.Psi.ExpectedTypes.ExpectedType> types, JetBrains.ReSharper.Psi.Resolve.IAccessContext accessContext, System.Func<JetBrains.ReSharper.Psi.IType, bool> predicate) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static TReference GetReference<TReference>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Tree.IFile file, JetBrains.ReSharper.Psi.TreeTextRange range)
            where TReference :  class, JetBrains.ReSharper.Psi.Resolve.IReference { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static TReference GetReference<TReference>([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Tree.IFile file, JetBrains.ReSharper.Psi.TreeTextRange range, [JetBrains.Annotations.InstantHandleAttribute()] System.Predicate<TReference> acceptPredicate)
            where TReference :  class, JetBrains.ReSharper.Psi.Resolve.IReference { }
        public static System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.ITypeElement> GetSeeAlsoTypes(JetBrains.ReSharper.Psi.Modules.IPsiModule module, JetBrains.ReSharper.Psi.ITypeElement typeElement) { }
        public static JetBrains.ReSharper.Psi.IType GetTypeToInstantiate(JetBrains.ReSharper.Psi.IDeclaredType expectedType) { }
        public static System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.DeclaredElementInstance<JetBrains.ReSharper.Psi.ITypeMember>> IterateStaticMembers(JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.CodeCompletionContext basicContext, JetBrains.ReSharper.Psi.IDeclaredType declaredType, JetBrains.ReSharper.Psi.ITypeElement typeElement, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution, JetBrains.ReSharper.Psi.Tree.ITreeNode accessElement, System.Collections.Generic.IList<JetBrains.ReSharper.Psi.ExpectedTypes.ExpectedType> expectedTypes, [JetBrains.Annotations.CanBeNullAttribute()] System.Func<JetBrains.ReSharper.Psi.ITypeMember, bool> memberFilter) { }
    }
    public class CombinedLookupItem : JetBrains.ReSharper.Feature.Services.Lookup.TextLookupItemBase, JetBrains.ReSharper.Feature.Services.Lookup.IDescriptionProvidingLookupItem
    {
        public CombinedLookupItem(JetBrains.ReSharper.Feature.Services.Lookup.TextLookupItemBase[] lookupItems, JetBrains.ReSharper.Feature.Services.Lookup.TextLookupItemBase sampleMatchItem = null, bool autocomplete = True, bool exactMatch = False) { }
        public CombinedLookupItem(JetBrains.ReSharper.Feature.Services.Lookup.TextLookupItemBase[] lookupItems, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.Lookup.TextLookupItemBase> displayItems, JetBrains.ReSharper.Feature.Services.Lookup.TextLookupItemBase sampleMatchItem = null, bool autocomplete = True, bool exactMatch = False) { }
        public override JetBrains.UI.Icons.IconId Image { get; }
        public JetBrains.ReSharper.Feature.Services.Lookup.TextLookupItemBase[] LookupItems { get; }
        public override string Text { get; set; }
        public override void Accept(JetBrains.TextControl.ITextControl textControl, JetBrains.Util.TextRange nameRange, JetBrains.ReSharper.Feature.Services.Lookup.LookupItemInsertType lookupItemInsertType, JetBrains.ReSharper.Feature.Services.Lookup.Suffix suffix, JetBrains.ProjectModel.ISolution solution, bool keepCaretStill) { }
        public override bool AcceptIfOnlyMatched(JetBrains.ReSharper.Feature.Services.Lookup.LookupItemAcceptanceContext itemAcceptanceContext) { }
        public JetBrains.UI.RichText.RichTextBlock GetDescription() { }
        protected override JetBrains.UI.RichText.RichText GetDisplayName() { }
        public override JetBrains.ReSharper.Feature.Services.Lookup.MatchingResult Match(string prefix, JetBrains.TextControl.ITextControl textControl) { }
    }
    public class CompletionEvaluationScheme
    {
        public CompletionEvaluationScheme(JetBrains.ReSharper.Feature.Services.CodeCompletion.CompletionEvaluationStep primaryStep, JetBrains.ReSharper.Feature.Services.CodeCompletion.CompletionEvaluationStep[] additionalSteps) { }
        public JetBrains.ReSharper.Feature.Services.CodeCompletion.CompletionEvaluationStep[] AdditionalSteps { get; }
        public JetBrains.ReSharper.Feature.Services.CodeCompletion.CompletionEvaluationStep PrimaryStep { get; }
    }
    public class CompletionEvaluationStep
    {
        public CompletionEvaluationStep(JetBrains.ReSharper.Feature.Services.CodeCompletion.EvaluationMode evaluationMode) { }
        public JetBrains.ReSharper.Feature.Services.CodeCompletion.EvaluationMode EvaluationMode { get; }
    }
    [JetBrains.Application.ShellComponentAttribute(JetBrains.Application.Components.ProgramConfigurations.NONE | JetBrains.Application.Components.ProgramConfigurations.STANDALONE | JetBrains.Application.Components.ProgramConfigurations.TEST | JetBrains.Application.Components.ProgramConfigurations.ALL)]
    public class DefaultCodeCompletionHost : JetBrains.ReSharper.Feature.Services.CodeCompletion.ICodeCompletionHost
    {
        public void CloseHostCodeCompletion() { }
        public System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem> GetSnippets() { }
        public void InvokeHostCodeCompletion() { }
        public void UpdateSnippets() { }
    }
    public class static DoubleCodeCompletionUtil
    {
        public static bool IsAutoPlusBasic(JetBrains.ReSharper.Feature.Services.CodeCompletion.CodeCompletionType[] codeCompletionTypes) { }
        public static bool IsAutoPlusBasicPlusImport(JetBrains.ReSharper.Feature.Services.CodeCompletion.CodeCompletionType[] codeCompletionTypes) { }
        public static bool IsAutoPlusDoubleBasic(JetBrains.ReSharper.Feature.Services.CodeCompletion.CodeCompletionType[] codeCompletionTypes) { }
        public static bool IsAutoPlusDoubleImport(JetBrains.ReSharper.Feature.Services.CodeCompletion.CodeCompletionType[] codeCompletionTypes) { }
        public static bool IsAutoPlusImport(JetBrains.ReSharper.Feature.Services.CodeCompletion.CodeCompletionType[] codeCompletionTypes) { }
        public static bool IsBasicPlusImport(JetBrains.ReSharper.Feature.Services.CodeCompletion.CodeCompletionType[] codeCompletionTypes) { }
        public static bool IsDoubleBasic(JetBrains.ReSharper.Feature.Services.CodeCompletion.CodeCompletionType[] codeCompletionTypes) { }
        public static bool IsDoubleImport(JetBrains.ReSharper.Feature.Services.CodeCompletion.CodeCompletionType[] codeCompletionTypes) { }
        public static bool IsTripleBasic(JetBrains.ReSharper.Feature.Services.CodeCompletion.CodeCompletionType[] codeCompletionTypes) { }
    }
    public enum EditorBrowsableProcessingType
    {
        All = 0,
        Normal = 1,
        Advanced = 2,
    }
    public enum EvaluationMode
    {
        Full = 0,
        Light = 1,
        OnlyDynamicRules = 2,
    }
    public abstract class FilterByExactPosition : JetBrains.ReSharper.Feature.Services.Lookup.ILookupItemsPreference
    {
        public abstract int Order { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem> FilterItems(System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem> items) { }
        protected abstract int GetPosition(JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem lookupItem);
    }
    public class GlobalCompletionSettings
    {
        public GlobalCompletionSettings(bool completeOnSpace, string completeOnChar) { }
        public string CompleteOnChar { get; }
        public bool CompleteOnSpace { get; }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class GlobalCompletionSettingsService : JetBrains.ReSharper.Feature.Services.CodeCompletion.IGlobalCompletionSettingsService
    {
        public virtual JetBrains.ReSharper.Feature.Services.CodeCompletion.GlobalCompletionSettings GetSettingsForLanguage(JetBrains.ReSharper.Psi.PsiLanguageType language) { }
    }
    public interface IAutomaticCodeCompletionStrategy
    {
        JetBrains.ReSharper.Feature.Services.CodeCompletion.CodeCompletionType CodeCompletionType { get; }
        bool ForceHideCompletion { get; }
        JetBrains.ReSharper.Psi.PsiLanguageType Language { get; }
        bool AcceptsFile(JetBrains.ReSharper.Psi.Tree.IFile file, JetBrains.TextControl.ITextControl textControl);
        bool AcceptTyping(char c, JetBrains.TextControl.ITextControl textControl, JetBrains.Application.Settings.IContextBoundSettingsStore boundSettingsStore);
        JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.AutopopupType IsEnabledInSettings(JetBrains.Application.Settings.IContextBoundSettingsStore settingsStore, JetBrains.TextControl.ITextControl textControl);
        bool ProcessSubsequentTyping(char c, JetBrains.TextControl.ITextControl textControl);
    }
    public interface ICodeCompletionHost
    {
        void CloseHostCodeCompletion();
        void InvokeHostCodeCompletion();
    }
    public interface ICodeCompletionResult
    {
        System.Collections.Generic.List<string> ActiveContextIds { get; }
        JetBrains.ReSharper.Feature.Services.CodeCompletion.AutocompletionBehaviour AutocompletionBehaviour { get; }
        System.Func<char, JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.CompletionAction> CharsThatContinueCompletion { get; }
        System.Collections.Generic.List<System.Action<JetBrains.DataFlow.Lifetime>> EmptyListHandlers { get; }
        JetBrains.ReSharper.Feature.Services.Lookup.LookupItemInsertType EnterInsertType { get; }
        JetBrains.ReSharper.Feature.Services.CodeCompletion.EvaluationMode EvaluationMode { get; }
        int InitialCaretOffset { get; }
        bool IsDynamic { get; }
        JetBrains.ReSharper.Feature.Services.Lookup.LookupFocusBehaviour LookupFocusBehaviour { get; }
        System.Collections.Generic.IList<JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem> LookupItems { get; }
        JetBrains.Util.TextRange LookupWindowRange { get; }
        int Multiplier { get; }
        JetBrains.ReSharper.Feature.Services.Lookup.ILookupItemSelectionStrategy SelectionStrategy { get; }
        bool SingleCompletionMode { get; }
        JetBrains.ReSharper.Feature.Services.Lookup.LookupItemInsertType TabInsertType { get; }
        JetBrains.ReSharper.Feature.Services.Lookup.FilteredLookupItems GetFilteredLookupItems();
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem GetFirstFilteredItem(out bool thereAreMoreItems);
    }
    public interface ICodeCompletionSession { }
    public interface IGlobalCompletionSettingsService
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Feature.Services.CodeCompletion.GlobalCompletionSettings GetSettingsForLanguage(JetBrains.ReSharper.Psi.PsiLanguageType language);
    }
    public interface IImportCompletionCacheProvider { }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class ImportCompletionCache
    {
        public ImportCompletionCache(JetBrains.Application.IShellLocks locks) { }
        public void CacheItem(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, string key, System.Collections.Generic.List<JetBrains.ReSharper.Psi.ITypeElement> typeElements, JetBrains.ReSharper.Feature.Services.Lookup.ITextualDeclaredElementLookupItem item) { }
        public void Clear() { }
        public void Clear(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
        public JetBrains.ReSharper.Feature.Services.Lookup.ITextualDeclaredElementLookupItem GetCachedItem(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, string key, out System.Collections.Generic.List<> typeElements) { }
        public static JetBrains.ReSharper.Feature.Services.CodeCompletion.ImportCompletionCache GetInstance(JetBrains.ProjectModel.ISolution solution) { }
        public System.Collections.Generic.List<JetBrains.ReSharper.Psi.ITypeElement> GetResult(JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.CodeCompletionContext context, JetBrains.ReSharper.Psi.Resolve.ElementAccessContext accessContext, JetBrains.Text.IdentifierMatcher prefixMatcher = null, bool filterByAccess = True) { }
        public bool HasResultsFor(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
        public void StartWarmUp(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ReSharper.Psi.Caches.ISymbolCache symbolCache, JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class ImportCompletionCacheHelper : JetBrains.Application.IChangeProvider
    {
        public ImportCompletionCacheHelper(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Psi.Modules.IPsiModules psiModules, JetBrains.ReSharper.Psi.Caches.ISymbolCache symbolCache, JetBrains.Application.Settings.ISettingsStore settingsStore, JetBrains.ReSharper.Psi.ILanguageManager languageManager, JetBrains.DocumentManagers.DocumentManager documentManager, JetBrains.ReSharper.Psi.Files.PsiFiles psiFiles, JetBrains.Application.ChangeManager changeManager, JetBrains.ReSharper.Feature.Services.CodeCompletion.ImportCompletionCache cache, JetBrains.DocumentModel.Impl.DocumentChangeManager documentChangeManager, JetBrains.DocumentManagers.SolutionDocumentChangeProvider solutionDocumentChangeProvider, JetBrains.TextControl.ITextControlManager textControlManager) { }
        public object Execute(JetBrains.Application.IChangeMap changeMap) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.KnownLanguage))]
    public class IncludeTemplatesRule : JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ItemsProviderOfSpecificContext<JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ISpecificCodeCompletionContext>
    {
        public IncludeTemplatesRule(JetBrains.ReSharper.Psi.PsiLanguageType language, JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.HotspotSessionExecutor hotspotSessionExecutor) { }
        protected override bool AddLookupItems(JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ISpecificCodeCompletionContext context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector) { }
        protected override bool IsAvailable(JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ISpecificCodeCompletionContext context) { }
        protected override void TransformItems(JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ISpecificCodeCompletionContext context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class IntellisenseManager
    {
        public IntellisenseManager(
                    JetBrains.ProjectModel.ISolution solution, 
                    JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.IntellisensePartsContainer intellisenseParts, 
                    JetBrains.DocumentManagers.DocumentManager documentManager, 
                    System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.CodeCompletion.IAutomaticCodeCompletionStrategy> strategies, 
                    JetBrains.TextControl.ITextControlManager textControlManager, 
                    JetBrains.ReSharper.Feature.Services.CodeCompletion.PreferencePolicy.CompletionStatisticsManager completionStatisticsManager, 
                    JetBrains.ReSharper.Feature.Services.Lookup.ILookupWindowManager lookupWindowManager, 
                    JetBrains.ReSharper.Psi.Caches.ISymbolCache cacheManager, 
                    JetBrains.UI.CommonControls.Fonts.FontsManager fontsManager, 
                    JetBrains.ReSharper.Psi.IPsiServices psiServices, 
                    JetBrains.Application.IShellLocks locks, 
                    JetBrains.DataFlow.Lifetime lifetime, 
                    JetBrains.ReSharper.Psi.ILanguageManager languageManager, 
                    JetBrains.Application.Settings.ISettingsStore settingsStore, 
                    JetBrains.ReSharper.Psi.PsiIconManager psiIconManager, 
                    JetBrains.ReSharper.Feature.Services.Descriptions.IDeclaredElementDescriptionPresenter declaredElementDescriptionPresenter, 
                    JetBrains.ReSharper.Feature.Services.Lookup.LookupItemsOwnerFactory lookupItemsOwnerFactory, 
                    JetBrains.Application.ActivityTrackingNew.IActivityTracking activityTracking) { }
        public JetBrains.ReSharper.Feature.Services.CodeCompletion.PreferencePolicy.CompletionStatisticsManager CompletionStatisticsManager { get; }
        public JetBrains.ReSharper.Feature.Services.Descriptions.IDeclaredElementDescriptionPresenter DeclaredElementDescriptionPresenter { get; }
        public JetBrains.DocumentManagers.DocumentManager DocumentManager { get; }
        public JetBrains.UI.CommonControls.Fonts.FontsManager FontsManager { get; }
        public bool IsEnabledInTests { get; set; }
        public JetBrains.Application.IShellLocks Locks { get; }
        public JetBrains.ReSharper.Feature.Services.Lookup.ILookupWindowManager LookupWindowManager { get; }
        public JetBrains.ReSharper.Psi.PsiIconManager PsiIconManager { get; }
        public JetBrains.ReSharper.Psi.IPsiServices PsiServices { get; }
        public JetBrains.Application.Settings.ISettingsStore SettingsStore { get; }
        public JetBrains.ProjectModel.ISolution Solution { get; }
        public JetBrains.ReSharper.Psi.Caches.ISymbolCache SymbolCache { get; }
        public void ExecuteAutoCompletion<TKeyClass>(JetBrains.TextControl.ITextControl textControl, JetBrains.ProjectModel.ISolution solution, System.Linq.Expressions.Expression<System.Func<TKeyClass, JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.AutopopupType>> lambdaexpression) { }
        public void ExecuteCompletionAsync(JetBrains.TextControl.ITextControl textControl, JetBrains.ReSharper.Psi.PsiLanguageType language, JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.AutopopupType autopopupType, JetBrains.ReSharper.Feature.Services.CodeCompletion.CodeCompletionType codeCompletionType) { }
        public bool ExecuteManualCompletion(JetBrains.ReSharper.Feature.Services.CodeCompletion.CodeCompletionType codeCompletionType, JetBrains.TextControl.ITextControl textControl, JetBrains.ProjectModel.ISolution solution, System.Action onItemCompleted, JetBrains.ReSharper.Feature.Services.CodeCompletion.EvaluationMode evaluationMode, JetBrains.ReSharper.Feature.Services.CodeCompletion.AutocompletionBehaviour autocompletionBehaviourInitial = 0, JetBrains.ReSharper.Feature.Services.Lookup.LookupReplaceBehaviour replaceBehaviour = 2, JetBrains.ReSharper.Feature.Services.Lookup.LookupFocusBehaviour lookupFocusBehaviour = 0, bool forceDoNotAutocomplete = False, bool forceSingleCompletion = False, JetBrains.ReSharper.Feature.Services.CodeCompletion.ICodeCompletionResult previousResult = null, bool rescheduleOnInterrupt = False) { }
        public JetBrains.ReSharper.Feature.Services.CodeCompletion.CompletionEvaluationStep[] GetCompletionEvaluationSteps(JetBrains.ReSharper.Feature.Services.CodeCompletion.CodeCompletionParameters codeCompletionParameters, JetBrains.ReSharper.Feature.Services.CodeCompletion.ICodeCompletionResult previousResult) { }
        public JetBrains.ReSharper.Feature.Services.CodeCompletion.ICodeCompletionResult GetCompletionResult(JetBrains.ReSharper.Feature.Services.CodeCompletion.CodeCompletionParameters parameters, JetBrains.TextControl.ITextControl textControl) { }
        public JetBrains.ReSharper.Feature.Services.CodeCompletion.ICodeCompletionResult GetCompletionResult(JetBrains.ReSharper.Feature.Services.CodeCompletion.CodeCompletionParameters parameters, JetBrains.TextControl.ITextControl textControl, System.Collections.Generic.List<JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ISpecificCodeCompletionContext> contexts) { }
        [System.ObsoleteAttribute("Inject IntellisenseManager")]
        public static JetBrains.ReSharper.Feature.Services.CodeCompletion.IntellisenseManager GetInstance(JetBrains.ProjectModel.ISolution solution) { }
        public JetBrains.ReSharper.Feature.Services.CodeCompletion.EvaluationMode GetPrimaryEvaluationMode(JetBrains.ReSharper.Feature.Services.CodeCompletion.CodeCompletionType codeCompletionType) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.CodeCompletion.IAutomaticCodeCompletionStrategy> GetStratagies(JetBrains.TextControl.ITextControl textControl, char c) { }
        public void ReRunSession(JetBrains.TextControl.ITextControl textControl, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Feature.Services.Lookup.LookupFocusBehaviour focusBehaviour) { }
        public System.Collections.Generic.List<JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ISpecificCodeCompletionContext> SpecificCodeCompletionContexts(JetBrains.ReSharper.Feature.Services.CodeCompletion.CodeCompletionParameters parameters, JetBrains.TextControl.ITextControl textControl) { }
        public void StartAutomaticCompletion(JetBrains.TextControl.ITextControl textControl, System.Collections.Generic.IList<JetBrains.ReSharper.Feature.Services.CodeCompletion.IAutomaticCodeCompletionStrategy> strategies) { }
    }
    public class ManualCodeCompletionSession : JetBrains.ReSharper.Feature.Services.CodeCompletion.CodeCompletionSession
    {
        protected readonly bool myRescheduleOnInterrupt;
        public ManualCodeCompletionSession(JetBrains.DataFlow.Lifetime lifetime, JetBrains.TextControl.ITextControl textControl, System.Action onItemCompleted, JetBrains.ReSharper.Feature.Services.CodeCompletion.CodeCompletionParameters parameters, JetBrains.ReSharper.Feature.Services.CodeCompletion.IntellisenseManager manager, JetBrains.Application.Settings.ISettingsStore settingsStore, System.Action<JetBrains.ReSharper.Feature.Services.CodeCompletion.ICodeCompletionResult> onSessionFinished, JetBrains.ReSharper.Feature.Services.Lookup.LookupReplaceBehaviour replaceBehaviour = 2, bool forceDoNotAutocomplete = False, bool rescheduleOnInterrupt = False) { }
        protected override void AdjustLookupOptions(JetBrains.ReSharper.Feature.Services.Lookup.LookupWindowOptions options) { }
        public bool ExecuteRightAway(bool async, JetBrains.ReSharper.Feature.Services.CodeCompletion.EvaluationMode evaluationMode = 0) { }
    }
    public abstract class MissingMemberLookupItemBase : JetBrains.ReSharper.Feature.Services.Lookup.DeclaredElementLookupItem
    {
        protected string myInterfaceName;
        protected bool myIsExplicitImplementation;
        protected MissingMemberLookupItemBase(string name, JetBrains.ReSharper.Psi.OverridableMemberInstance instance, bool isExplicitImplementation, JetBrains.ReSharper.Feature.Services.Lookup.IElementPointerFactory elementPointerFactory, JetBrains.ReSharper.Psi.PsiLanguageType languageType, JetBrains.ReSharper.Feature.Services.Lookup.ILookupItemsOwner owner) { }
        public override void Accept(JetBrains.TextControl.ITextControl textControl, JetBrains.Util.TextRange nameRange, JetBrains.ReSharper.Feature.Services.Lookup.LookupItemInsertType lookupItemInsertType, JetBrains.ReSharper.Feature.Services.Lookup.Suffix suffix, JetBrains.ProjectModel.ISolution solution, bool keepCaretStill) { }
        protected abstract void RemoveIdentifier(JetBrains.TextControl.ITextControl textControl, JetBrains.ProjectModel.ISolution solution);
        protected abstract void SetOptions(JetBrains.ReSharper.Feature.Services.Generate.IGeneratorContext context);
    }
    public class static NamesCorellationUtil
    {
        public static int GetCorellation(string identifier1, string identifier2, JetBrains.ReSharper.Psi.Naming.NamingManager namingManager, JetBrains.ReSharper.Psi.Naming.Interfaces.INamingPolicyProvider policyProvider) { }
        public static int GetCorellation(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Naming.Impl.NameRoot> expectedRoots, string name, JetBrains.ReSharper.Psi.Naming.NamingManager namingManager, JetBrains.ReSharper.Psi.Naming.Interfaces.INamingPolicyProvider policyProvider) { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class NextTypingHandler
    {
        public NextTypingHandler(JetBrains.DataFlow.Lifetime lifetime, JetBrains.TextControl.Impl.TextControlTypingHandlers textControlTypingHandlers) { }
        public void HandleNextTyping(JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] System.Action<char> handler) { }
    }
    public enum ParenthesesInsertType
    {
        Both = 0,
        Left = 1,
        None = 2,
    }
    public class SimpleTextLookupItem : JetBrains.ReSharper.Feature.Services.Lookup.TextLookupItem
    {
        public SimpleTextLookupItem(string text, JetBrains.DocumentModel.IRangeMarker completionMarker) { }
    }
    public class SmartCompletionSymbolFilter : JetBrains.ReSharper.Psi.Resolve.ISymbolFilter
    {
        public SmartCompletionSymbolFilter(JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ExpectedTypeCompletionContextBase.ExpectedIType expectedIType, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution) { }
        public JetBrains.ReSharper.Psi.Resolve.ResolveErrorType ErrorType { get; }
        public JetBrains.ReSharper.Psi.Resolve.FilterRunType RunType { get; }
        public JetBrains.ReSharper.Psi.Resolve.ISubstitution Substitution { get; set; }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Resolve.ISymbolInfo> FilterArray(System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Resolve.ISymbolInfo> data) { }
        public JetBrains.ReSharper.Psi.Resolve.ISymbolInfo IsSymbolSuitable(JetBrains.ReSharper.Psi.Resolve.ISymbolInfo si, JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ExpectedTypeCompletionContextBase.ExpectedIType expectedType, out System.Nullable<> withTypeInference) { }
    }
    public class SmartCompletionSymbolFilterFactory
    {
        public SmartCompletionSymbolFilterFactory() { }
        public JetBrains.ReSharper.Feature.Services.CodeCompletion.SmartCompletionSymbolFilter GetFilter(JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ExpectedTypeCompletionContextBase.ExpectedIType type, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.CodeCompletion.BaseRules
{
    
    public class BaseDynamicRule
    {
        public static readonly JetBrains.Util.Key PrefixKey;
    }
    public class EscItem
    {
        public JetBrains.ReSharper.Psi.IDeclaredElement[] Prefix { get; set; }
        public System.Collections.Generic.List<JetBrains.ReSharper.Feature.Services.CodeCompletion.BaseRules.EscSymbol> Symbols { get; set; }
        public override string ToString() { }
    }
    public class EscResult
    {
        public EscResult() { }
        public System.Collections.Generic.List<JetBrains.ReSharper.Feature.Services.CodeCompletion.BaseRules.EscItem> Items { get; }
        public void Sort(System.Collections.Generic.IComparer<JetBrains.ReSharper.Feature.Services.CodeCompletion.BaseRules.EscItem> resultComparer) { }
    }
    public class EscSymbol
    {
        public EscSymbol(JetBrains.ReSharper.Psi.Resolve.ISymbolInfo symbolInfo, System.Nullable<bool> withTypeInference) { }
        public JetBrains.ReSharper.Psi.Resolve.ISymbolInfo SymbolInfo { get; set; }
        public System.Nullable<bool> WithTypeInference { get; set; }
    }
    public class static ExpandBasicCompletionHelper
    {
        public static JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetSymbolTable(JetBrains.ReSharper.Psi.Resolve.ICompleteableReference reference, System.Collections.Generic.List<JetBrains.ReSharper.Psi.Resolve.ISymbolFilter> filters, bool isQualified, JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.CodeCompletionContext basicContext, JetBrains.ReSharper.Feature.Services.CodeCompletion.ImportCompletionCache cache, out bool showContainer) { }
        public static bool IsAvailableEx(JetBrains.ReSharper.Feature.Services.CodeCompletion.CodeCompletionType[] codeCompletionTypes) { }
    }
    public abstract class ExpandImportCompletionProviderBase<TContext> : JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ItemsProviderOfSpecificContext<TContext>
        where TContext :  class, JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ISpecificCodeCompletionContext
    {
        protected readonly JetBrains.DataFlow.Lifetime myLifetime;
        protected JetBrains.ReSharper.Psi.Modules.ModuleReferencerService myModuleReferencerService;
        protected ExpandImportCompletionProviderBase(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ReSharper.Psi.Modules.ModuleReferencerService moduleReferencerService) { }
        protected override bool AddLookupItems(TContext context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector) { }
        protected abstract JetBrains.ReSharper.Feature.Services.Lookup.ITextualDeclaredElementLookupItem CreateLookupItem(TContext context, System.Linq.IGrouping<string, JetBrains.ReSharper.Psi.ITypeElement> typeElements);
        protected abstract JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.TextLookupRanges GetRanges(TContext context);
        protected abstract JetBrains.ReSharper.Psi.Tree.ITreeNode GetTreeNode(TContext context);
        public override bool IsAvailableEx(JetBrains.ReSharper.Feature.Services.CodeCompletion.CodeCompletionType[] codeCompletionTypes, TContext context) { }
        protected abstract bool IsQualifiedContext(TContext context);
    }
    public class ExpandSmartCompletionEventsFilter : JetBrains.ReSharper.Psi.Resolve.SimpleSymbolFilter
    {
        public override JetBrains.ReSharper.Psi.Resolve.ResolveErrorType ErrorType { get; }
        public override bool Accepts(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution) { }
    }
    public class static ExpandSmartCompletionHelper
    {
        public static void AddLookupItems(JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.Lookup.TextLookupItemBase> lookupItems, JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.TextLookupRanges ranges, JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.CodeCompletionContext context, JetBrains.ReSharper.Feature.Services.Lookup.TextLookupItemBase[] initialLookupItems, int priority, System.Nullable<bool> withTypeInference) { }
        public static bool CheckAvailability(JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.CodeCompletionContext context, JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ExpectedTypeCompletionContextBase expectedTypeContext) { }
        public static bool CheckOverload(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, System.Collections.Generic.Dictionary<string, System.Collections.Generic.HashSet<JetBrains.ReSharper.Psi.IDeclaredElement>> overloadCache) { }
        public static JetBrains.ReSharper.Feature.Services.CodeCompletion.BaseRules.EscResult GetTablesSorted(JetBrains.ReSharper.Psi.Resolve.ISymbolTable initialTable, int depth, JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ExpectedTypeCompletionContextBase expectedTypeContext, JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.CodeCompletionContext context, JetBrains.ReSharper.Psi.Resolve.IAccessContext accessContext, System.Func<JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ExpectedTypeCompletionContextBase.ExpectedIType, JetBrains.ReSharper.Psi.Resolve.ISymbolTable, System.Collections.Generic.List<JetBrains.ReSharper.Feature.Services.CodeCompletion.BaseRules.EscSymbol>> expectedTypeFilters, JetBrains.ReSharper.Psi.Resolve.ISymbolFilter[] filters, int maxSymbols, JetBrains.ReSharper.Feature.Services.CodeCompletion.BaseRules.ExtensionMethodsProvider extensionMethodsProvider = null) { }
        public static bool IsAvailableEx(JetBrains.ReSharper.Feature.Services.CodeCompletion.CodeCompletionType[] codeCompletionTypes) { }
    }
    public class ExpandSmartCompletionPublicFilter : JetBrains.ReSharper.Psi.Resolve.SimpleSymbolFilter
    {
        public override JetBrains.ReSharper.Psi.Resolve.ResolveErrorType ErrorType { get; }
        public override bool Accepts(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution) { }
    }
    public class ExpandSmartCompletionStaticFilter : JetBrains.ReSharper.Psi.Resolve.SimpleSymbolInfoFilter
    {
        public ExpandSmartCompletionStaticFilter(bool onlyForClasses) { }
        public override JetBrains.ReSharper.Psi.Resolve.ResolveErrorType ErrorType { get; }
        public override bool Accepts(JetBrains.ReSharper.Psi.Resolve.ISymbolInfo datum) { }
    }
    public class static ExpandSmartCompletionWithStaticMembersHelper
    {
        public static bool AddLookupItems(JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.CodeCompletionContext basicContext, JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ExpectedTypeCompletionContextBase expectedTypeContext, JetBrains.ReSharper.Psi.ExpectedTypes.TailType tailType, JetBrains.ReSharper.Psi.Resolve.ICompleteableReference reference, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector, JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.TextLookupRanges ranges, System.Func<JetBrains.ReSharper.Psi.Resolve.ISymbolTable, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector> fillItems, System.Func<JetBrains.ReSharper.Psi.IDeclaredElement, JetBrains.ReSharper.Feature.Services.Lookup.DeclaredElementLookupItem> factory, System.Func<JetBrains.ReSharper.Psi.Resolve.IAccessContext, JetBrains.ReSharper.Psi.Resolve.ISymbolFilter[]> filters) { }
        public static bool IsAvailable(JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.CodeCompletionContext context, JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ExpectedTypeCompletionContextBase expectedTypeContext) { }
        public static bool IsAvailableEx(JetBrains.ReSharper.Feature.Services.CodeCompletion.CodeCompletionType[] codeCompletionTypes) { }
    }
    public class ExtensionMethodsProvider
    {
        public ExtensionMethodsProvider(JetBrains.ReSharper.Psi.ExtensionMethods.IExtensionMethodRegistry extensionMethodRegistry, JetBrains.ReSharper.Psi.ITypeConversionRule typeConversionRule) { }
        public System.Collections.Generic.List<JetBrains.ReSharper.Psi.IMethod> CandidatesApplicableForType(JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext resolveContext, JetBrains.ReSharper.Psi.IType type, JetBrains.ReSharper.Psi.PsiLanguageType languageType) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.CodeCompletion.CompletionInDocComments
{
    
    public abstract class CodeCompletionContextProviderInDocCommentBase : JetBrains.ReSharper.Feature.Services.CodeCompletion.Impl.CodeCompletionContextProviderBase
    {
        public override JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ISpecificCodeCompletionContext GetCompletionContext(JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.CodeCompletionContext context) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        protected abstract JetBrains.ReSharper.Psi.Tree.ITokenNode GetTokenNode(JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.CodeCompletionContext context);
    }
    public class ContextInDocComment : JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.SpecificCodeCompletionContext
    {
        public ContextInDocComment(JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.CodeCompletionContext context, JetBrains.DocumentModel.DocumentRange completionRange, JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.TextLookupRanges textLookupRanges) { }
        public JetBrains.DocumentModel.DocumentRange CompletionRange { get; }
        public override string ContextId { get; }
        public JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.TextLookupRanges TextLookupRanges { get; }
    }
    public class DocCommentElementsItemsProvider : JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ItemsProviderOfSpecificContext<JetBrains.ReSharper.Feature.Services.CodeCompletion.CompletionInDocComments.ContextInDocComment>
    {
        protected virtual void AddExtraItems(JetBrains.ReSharper.Feature.Services.CodeCompletion.CompletionInDocComments.ContextInDocComment context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector) { }
        protected override bool AddLookupItems(JetBrains.ReSharper.Feature.Services.CodeCompletion.CompletionInDocComments.ContextInDocComment context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector) { }
        protected override JetBrains.ReSharper.Feature.Services.CodeCompletion.AutocompletionBehaviour GetAutocompletionBehaviour(JetBrains.ReSharper.Feature.Services.CodeCompletion.CompletionInDocComments.ContextInDocComment specificContext) { }
        protected virtual string[][] GetClosedTags() { }
        protected virtual string[][] GetComplexTags() { }
        protected override JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.TextLookupRanges GetDefaultRanges(JetBrains.ReSharper.Feature.Services.CodeCompletion.CompletionInDocComments.ContextInDocComment context) { }
        protected virtual string[] GetSimpleTags() { }
        protected override bool IsAvailable(JetBrains.ReSharper.Feature.Services.CodeCompletion.CompletionInDocComments.ContextInDocComment context) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.CodeCompletion.Impl
{
    
    public abstract class CodeCompletionContextProviderBase : JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ICodeCompletionContextProvider
    {
        protected JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.TextLookupRanges CalculateDefaultRanges(JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.CodeCompletionContext context) { }
        public abstract JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ISpecificCodeCompletionContext GetCompletionContext(JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.CodeCompletionContext context);
        public static JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.TextLookupRanges GetTextLookupRanges(JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.CodeCompletionContext context, JetBrains.Util.TextRange completedElementRange) { }
        public abstract bool IsApplicable(JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.CodeCompletionContext context);
    }
    public abstract class FileReferenceItemsProvider<TContext> : JetBrains.ReSharper.Feature.Services.CodeCompletion.Impl.ItemsProviderWithSymbolTable<TContext, JetBrains.ReSharper.Psi.Resolve.IFileReference, JetBrains.ReSharper.Psi.Tree.IFile>
        where TContext :  class, JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ISpecificCodeCompletionContext
    {
        protected override JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem CreateLookupItem(string name, JetBrains.ReSharper.Psi.DeclaredElementInstance<JetBrains.ReSharper.Psi.IDeclaredElement> declaredElementInstance, TContext context, JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.TextLookupRanges ranges, JetBrains.ReSharper.Psi.ExpectedTypes.TailType tailType) { }
        protected override JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetCompletionSymbolTable(JetBrains.ReSharper.Psi.Resolve.IFileReference reference, TContext context) { }
        protected class FileDeclaredElementLookupItem<TContext> : JetBrains.ReSharper.Feature.Services.Lookup.Impl.DeclaredElementLookupItem<JetBrains.ReSharper.Psi.Resolve.IFileReference, JetBrains.ReSharper.Psi.Tree.IFile>
            where TContext :  class, JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ISpecificCodeCompletionContext
        {
            public FileDeclaredElementLookupItem(string name, JetBrains.ReSharper.Psi.DeclaredElementInstance<JetBrains.ReSharper.Psi.IDeclaredElement> declaredElementInstance, TContext context, JetBrains.ReSharper.Psi.PsiLanguageType language, JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.TextLookupRanges ranges) { }
            protected override bool IsReferenceValid(JetBrains.Util.TextRange nameRange, JetBrains.ReSharper.Psi.Resolve.IFileReference reference) { }
        }
    }
    public class static ImportCompletionUtil
    {
        public static JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetCompletionSymbolTableForImportCompletion(JetBrains.ReSharper.Psi.Resolve.IReference reference, System.Collections.Generic.ICollection<string> namespacesNamesToSearch, bool namespacesCaseSensitive) { }
        public static JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetFilesCompletionSymbolTableForImportCompletion(JetBrains.Util.FileSystemPath basePath, JetBrains.ProjectModel.IProjectFile projectFile, JetBrains.ProjectModel.ProjectFileType expectedFileType, System.Collections.Generic.ICollection<string> expectedExtensions, string prefix) { }
    }
    public abstract class ItemsProviderWithSymbolTable<TContext, TReference, TFile> : JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ItemsProviderOfSpecificContext<TContext>
        where TContext :  class, JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ISpecificCodeCompletionContext
        where TReference :  class, JetBrains.ReSharper.Psi.Resolve.ICompleteableReference
        where TFile :  class, JetBrains.ReSharper.Psi.Tree.IFile
    {
        protected override bool AddLookupItems(TContext context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector) { }
        protected virtual void AddLookupItemsForDeclaredElement(TContext context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector, JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.TextLookupRanges ranges, JetBrains.ReSharper.Psi.DeclaredElementInstance<JetBrains.ReSharper.Psi.IDeclaredElement> instance, string name) { }
        protected virtual void AddLookupItemsForDeclaredElement(TContext context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector, JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.TextLookupRanges ranges, JetBrains.ReSharper.Psi.DeclaredElementInstance<JetBrains.ReSharper.Psi.IDeclaredElement> instance, TReference reference, string name) { }
        protected virtual JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem CreateLookupItem(string name, JetBrains.ReSharper.Psi.DeclaredElementInstance<JetBrains.ReSharper.Psi.IDeclaredElement> instance, TContext context, JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.TextLookupRanges ranges, JetBrains.ReSharper.Psi.ExpectedTypes.TailType tailType) { }
        protected JetBrains.Text.IdentifierMatcher CreatePrefixMatcher(TContext context, JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.TextLookupRanges ranges) { }
        protected virtual bool EvaluateLookupItems(TReference reference, TContext context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector, JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.TextLookupRanges ranges) { }
        protected abstract JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.TextLookupRanges EvaluateRanges(TContext context);
        protected void EvaluateSymbolTable([JetBrains.Annotations.NotNullAttribute()] TReference reference, [JetBrains.Annotations.NotNullAttribute()] TContext context, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.TextLookupRanges ranges, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Resolve.ISymbolTable table) { }
        protected abstract JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetCompletionSymbolTable(TReference reference, TContext context);
        protected static string GetPrefix(TContext context, JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.TextLookupRanges ranges) { }
        protected abstract TReference GetReference(TContext context);
        protected virtual bool IsIncluded(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution, TContext context) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure
{
    
    public class CodeCompletionContext : JetBrains.Util.UserDataHolder
    {
        public CodeCompletionContext(JetBrains.ReSharper.Feature.Services.CodeCompletion.IntellisenseManager completionManager, JetBrains.ReSharper.Feature.Services.CodeCompletion.CodeCompletionParameters parameters, JetBrains.TextControl.ITextControl textControl, JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, JetBrains.ReSharper.Psi.Tree.IFile file, JetBrains.DocumentModel.DocumentRange caretRange, JetBrains.ReSharper.Psi.TreeOffset caretTreeRange, JetBrains.ReSharper.Psi.TreeTextRange selectedTreeRange, JetBrains.DocumentModel.DocumentRange selectedRange, JetBrains.Application.Settings.ISettingsStore settingsStore, JetBrains.ReSharper.Psi.ILanguageManager languageManager, JetBrains.ReSharper.Feature.Services.Lookup.LookupItemsOwnerFactory lookupItemsOwnerFactory) { }
        public JetBrains.DocumentModel.DocumentRange CaretDocumentRange { get; }
        public JetBrains.ReSharper.Psi.TreeOffset CaretTreeOffset { get; }
        public JetBrains.ReSharper.Feature.Services.CodeCompletion.CodeCompletionType CodeCompletionType { get; }
        public JetBrains.ReSharper.Feature.Services.CodeCompletion.IntellisenseManager CompletionManager { get; }
        public JetBrains.Application.Settings.IContextBoundSettingsStore ContextBoundSettingsStore { get; }
        public JetBrains.ReSharper.Feature.Services.Descriptions.IDeclaredElementDescriptionPresenter DeclaredElementDescriptionPresenter { get; }
        public JetBrains.ReSharper.Psi.IDeclaredElementPresenter DeclaredElementPresenter { get; }
        public JetBrains.DocumentModel.IDocument Document { get; }
        public JetBrains.ReSharper.Feature.Services.CodeCompletion.EditorBrowsableProcessingType EditorBrowsableProcessing { get; set; }
        public JetBrains.ReSharper.Psi.Tree.IFile File { get; }
        public JetBrains.Text.IdentifierMatchingStyle IdentifierMatchingStyle { get; set; }
        public bool KeywordCompletionEnabled { get; set; }
        public int KeywordCompletionMinLength { get; set; }
        public JetBrains.ReSharper.Psi.PsiLanguageType Language { get; }
        public JetBrains.ReSharper.Psi.ILanguageManager LanguageManager { get; }
        public JetBrains.ReSharper.Feature.Services.Lookup.ILookupItemsOwner LookupItemsOwner { get; }
        public JetBrains.ReSharper.Psi.Naming.Interfaces.INamingPolicyProvider NamingPolicyProvider { get; }
        public JetBrains.ReSharper.Feature.Services.CodeCompletion.CodeCompletionParameters Parameters { get; set; }
        public JetBrains.ReSharper.Feature.Services.CodeCompletion.ParenthesesInsertType ParenthesesInsertType { get; set; }
        public JetBrains.ReSharper.Psi.PsiIconManager PsiIconManager { get; }
        public JetBrains.DocumentModel.DocumentRange SelectedRange { get; }
        public JetBrains.ReSharper.Psi.TreeTextRange SelectedTreeRange { get; }
        public JetBrains.Application.Settings.ISettingsStore SettingsStore { get; }
        public bool ShowSignatures { get; }
        public JetBrains.ProjectModel.ISolution Solution { get; }
        public JetBrains.ReSharper.Psi.IPsiSourceFile SourceFile { get; }
        public JetBrains.TextControl.ITextControl TextControl { get; }
    }
    public abstract class CompletingCharsProviderBase<TContext> : JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ICompletingCharsProvider
        where TContext :  class, JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ISpecificCodeCompletionContext
    {
        protected virtual JetBrains.ReSharper.Feature.Services.Lookup.LookupItemInsertType GetEnterAction(TContext context, JetBrains.Application.Settings.IContextBoundSettingsStore settingsStore) { }
        protected virtual JetBrains.ReSharper.Feature.Services.Lookup.LookupItemInsertType GetTabAction(TContext context, JetBrains.Application.Settings.IContextBoundSettingsStore settingsStore) { }
        protected abstract bool IsApplicable(TContext context);
        protected virtual JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.CompletionAction IsCharacterAcceptable(char c, TContext context, JetBrains.Application.Settings.IContextBoundSettingsStore settingsStore) { }
    }
    public abstract class CompletingCharsProviderWithSetting<TContext, TSettingKey> : JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.CompletingCharsProviderBase<TContext>
        where TContext :  class, JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ISpecificCodeCompletionContext
    
    {
        protected abstract System.Linq.Expressions.Expression<System.Func<TSettingKey, bool>> GetCompleteOnSpaceSettingKey();
        protected override JetBrains.ReSharper.Feature.Services.Lookup.LookupItemInsertType GetEnterAction(TContext context, JetBrains.Application.Settings.IContextBoundSettingsStore settingsStore) { }
        protected abstract System.Linq.Expressions.Expression<System.Func<TSettingKey, JetBrains.ReSharper.Feature.Services.Lookup.LookupItemInsertType>> GetEnterActionSettingKey();
        protected abstract System.Linq.Expressions.Expression<System.Func<TSettingKey, string>> GetNonCompletingCharactersSettingKey();
        protected override JetBrains.ReSharper.Feature.Services.Lookup.LookupItemInsertType GetTabAction(TContext context, JetBrains.Application.Settings.IContextBoundSettingsStore settingsStore) { }
        protected abstract System.Linq.Expressions.Expression<System.Func<TSettingKey, JetBrains.ReSharper.Feature.Services.Lookup.LookupItemInsertType>> GetTabActionSettingKey();
        protected override JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.CompletionAction IsCharacterAcceptable(char c, TContext context, JetBrains.Application.Settings.IContextBoundSettingsStore settingsStore) { }
    }
    public abstract class CompletingCharsProviderWithSettingOther<TContext> : JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.CompletingCharsProviderWithSetting<TContext, JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.IntelliSenseCompletingCharactersSettingsKey>
        where TContext :  class, JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ISpecificCodeCompletionContext
    {
        protected override System.Linq.Expressions.Expression<System.Func<JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.IntelliSenseCompletingCharactersSettingsKey, bool>> GetCompleteOnSpaceSettingKey() { }
        protected override System.Linq.Expressions.Expression<System.Func<JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.IntelliSenseCompletingCharactersSettingsKey, JetBrains.ReSharper.Feature.Services.Lookup.LookupItemInsertType>> GetEnterActionSettingKey() { }
        protected override System.Linq.Expressions.Expression<System.Func<JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.IntelliSenseCompletingCharactersSettingsKey, string>> GetNonCompletingCharactersSettingKey() { }
        protected override System.Linq.Expressions.Expression<System.Func<JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.IntelliSenseCompletingCharactersSettingsKey, JetBrains.ReSharper.Feature.Services.Lookup.LookupItemInsertType>> GetTabActionSettingKey() { }
    }
    public class ExcludeFilter : JetBrains.ReSharper.Psi.Resolve.ISymbolFilter
    {
        public ExcludeFilter(JetBrains.ReSharper.Psi.Resolve.ISymbolTable completionSymbolTable) { }
        public JetBrains.ReSharper.Psi.Resolve.ResolveErrorType ErrorType { get; }
        public JetBrains.ReSharper.Psi.Resolve.FilterRunType RunType { get; }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Resolve.ISymbolInfo> FilterArray(System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Resolve.ISymbolInfo> data) { }
    }
    public class ExpectedTypeCompletionContextBase
    {
        public ExpectedTypeCompletionContextBase(System.Collections.Generic.IList<JetBrains.ReSharper.Psi.ExpectedTypes.ExpectedType> expectedTypes, JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.CodeCompletionContext context) { }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ExpectedTypeCompletionContextBase.ExpectedIType> ExpectedITypes { get; }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Psi.ExpectedTypes.ExpectedType> ExpectedTypes { get; }
        public class ExpectedIType
        {
            public ExpectedIType(JetBrains.ReSharper.Psi.IType type, System.Collections.Generic.IList<JetBrains.ReSharper.Psi.ExpectedTypes.ExpectedType> expectedTypes, bool acceptsPlain, bool requiresConstant, bool expectedOut, string expectedName, JetBrains.ReSharper.Psi.Naming.Extentions.INamesCollection expectedRoots, JetBrains.ReSharper.Psi.IDeclaredType declaredType, bool expectedRef) { }
            public bool AcceptsPlain { get; }
            public JetBrains.ReSharper.Psi.IDeclaredType DeclaredType { get; }
            public string ExpectedName { get; }
            public bool ExpectedOut { get; }
            public bool ExpectedRef { get; }
            public JetBrains.ReSharper.Psi.Naming.Extentions.INamesCollection ExpectedRoots { get; }
            public System.Collections.Generic.IList<JetBrains.ReSharper.Psi.ExpectedTypes.ExpectedType> ExpectedTypes { get; }
            public bool RequiresConstant { get; }
            public JetBrains.ReSharper.Psi.IType Type { get; }
        }
    }
    public interface ICodeCompletionContextProvider
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ISpecificCodeCompletionContext GetCompletionContext(JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.CodeCompletionContext createCodeCompletionContext);
        bool IsApplicable(JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.CodeCompletionContext context);
    }
    public interface ICodeCompletionItemsProvider
    {
        bool IsDynamic { get; }
        void AddItemsGroups([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ISpecificCodeCompletionContext context, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Feature.Services.CodeCompletion.IntellisenseManager intellisenseManager, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector, object data);
        bool AddLookupItems([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ISpecificCodeCompletionContext context, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector, object data);
        void DecorateItems([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ISpecificCodeCompletionContext context, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector, object data);
        JetBrains.ReSharper.Feature.Services.CodeCompletion.AutocompletionBehaviour GetAutocompletionBehaviour([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ISpecificCodeCompletionContext context, object data);
        JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.TextLookupRanges GetDefaultRanges([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ISpecificCodeCompletionContext context);
        JetBrains.ReSharper.Feature.Services.Lookup.LookupFocusBehaviour GetLookupFocusBehaviour([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ISpecificCodeCompletionContext context, object data);
        object IsAvailable([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ISpecificCodeCompletionContext context);
        bool IsAvailableEx([JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IList<JetBrains.ReSharper.Feature.Services.CodeCompletion.CodeCompletionType> codeCompletionTypes, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ISpecificCodeCompletionContext context);
        bool IsEvaluationModeSupported(JetBrains.ReSharper.Feature.Services.CodeCompletion.CodeCompletionParameters parameters);
        void TransformItems([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ISpecificCodeCompletionContext context, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector, object data);
    }
    public interface ICompletingCharsProvider
    {
        JetBrains.ReSharper.Feature.Services.Lookup.LookupItemInsertType GetEnterAction(JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ISpecificCodeCompletionContext context, JetBrains.Application.Settings.IContextBoundSettingsStore settingsStore);
        JetBrains.ReSharper.Feature.Services.Lookup.LookupItemInsertType GetTabAction(JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ISpecificCodeCompletionContext context, JetBrains.Application.Settings.IContextBoundSettingsStore settingsStore);
        bool IsApplicable(JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ISpecificCodeCompletionContext context);
        JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.CompletionAction IsCharacterAcceptable(char c, JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ISpecificCodeCompletionContext context, JetBrains.Application.Settings.IContextBoundSettingsStore settingsStore);
    }
    public interface ICompletionRangesProvider : JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ICodeCompletionItemsProvider { }
    public interface ILookupItemPresenter
    {
        JetBrains.UI.RichText.RichTextBlock Present(JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem lookupItem);
    }
    [JetBrains.Annotations.MeansImplicitUseAttribute()]
    [System.AttributeUsageAttribute(System.AttributeTargets.Class | System.AttributeTargets.All)]
    public class IntellisensePartAttribute : JetBrains.Application.Parts.PartAttribute { }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class IntellisensePartsContainer
    {
        public IntellisensePartsContainer(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.Parts.IPartsCatalogueSet catalogueSet, JetBrains.Application.Components.IComponentContainer parentContainer) { }
        public System.Collections.Generic.IEnumerable<T> GetParts<T>()
            where T :  class { }
    }
    public interface ISpecificCodeCompletionContext : JetBrains.ReSharper.Feature.Services.Lookup.IElementPointerFactory
    {
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.CodeCompletionContext BasicContext { get; }
        string ContextId { get; }
        JetBrains.ReSharper.Psi.PsiLanguageType Language { get; }
    }
    public class ItemsProviderOfSpecificContext<TContext> : JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ICodeCompletionItemsProvider
        where TContext :  class, JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ISpecificCodeCompletionContext
    {
        public virtual bool IsDynamic { get; }
        protected virtual void AddItemsGroups([JetBrains.Annotations.NotNullAttribute()] TContext context, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Feature.Services.CodeCompletion.IntellisenseManager intellisenseManager) { }
        protected virtual bool AddLookupItems([JetBrains.Annotations.NotNullAttribute()] TContext context, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector) { }
        protected virtual void DecorateItems([JetBrains.Annotations.NotNullAttribute()] TContext context, [JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem> items) { }
        public JetBrains.ReSharper.Feature.Services.CodeCompletion.AutocompletionBehaviour GetAutocompletionBehaviour(JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ISpecificCodeCompletionContext context, object data) { }
        protected virtual JetBrains.ReSharper.Feature.Services.CodeCompletion.AutocompletionBehaviour GetAutocompletionBehaviour(TContext specificContext) { }
        protected virtual JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.TextLookupRanges GetDefaultRanges([JetBrains.Annotations.NotNullAttribute()] TContext context) { }
        protected virtual JetBrains.ReSharper.Feature.Services.Lookup.LookupFocusBehaviour GetLookupFocusBehaviour(TContext context) { }
        protected virtual bool IsAvailable([JetBrains.Annotations.NotNullAttribute()] TContext context) { }
        public bool IsAvailableEx(System.Collections.Generic.IList<JetBrains.ReSharper.Feature.Services.CodeCompletion.CodeCompletionType> codeCompletionTypes, JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ISpecificCodeCompletionContext context) { }
        public virtual bool IsAvailableEx(JetBrains.ReSharper.Feature.Services.CodeCompletion.CodeCompletionType[] codeCompletionTypes, TContext specificContext) { }
        public virtual bool IsEvaluationModeSupported(JetBrains.ReSharper.Feature.Services.CodeCompletion.CodeCompletionParameters parameters) { }
        protected virtual void TransformItems([JetBrains.Annotations.NotNullAttribute()] TContext context, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector) { }
    }
    public abstract class ItemsProviderOfSpecificContextWithSharedData<TContext, TData> : JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ICodeCompletionItemsProvider
        where TContext :  class, JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ISpecificCodeCompletionContext
    
    {
        public virtual bool IsDynamic { get; }
        protected virtual void AddItemsGroups(TContext context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector, JetBrains.ReSharper.Feature.Services.CodeCompletion.IntellisenseManager completionManager, TData data) { }
        protected virtual bool AddLookupItems([JetBrains.Annotations.NotNullAttribute()] TContext context, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector, TData data) { }
        protected virtual void DecorateItems([JetBrains.Annotations.NotNullAttribute()] TContext context, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector, TData data) { }
        protected virtual JetBrains.ReSharper.Feature.Services.CodeCompletion.AutocompletionBehaviour GetAutocompletionBehaviour(TContext speciificContext, TData data) { }
        protected virtual JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.TextLookupRanges GetDefaultRanges(TContext context) { }
        protected virtual JetBrains.ReSharper.Feature.Services.Lookup.LookupFocusBehaviour GetLookupFocusBehaviour(TContext context, TData data) { }
        protected abstract TData IsAvailable([JetBrains.Annotations.NotNullAttribute()] TContext context);
        public virtual bool IsAvailableEx(JetBrains.ReSharper.Feature.Services.CodeCompletion.CodeCompletionType[] codeCompletionTypes, TContext context) { }
        public virtual bool IsCharacterAcceptable(TContext specificContext, char c, TData data) { }
        public virtual bool IsEvaluationModeSupported(JetBrains.ReSharper.Feature.Services.CodeCompletion.CodeCompletionParameters parameters) { }
        protected virtual void TransformItems(TContext context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector, TData data) { }
    }
    public abstract class ItemsProviderOfSymbolTableBase<TContext> : JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ItemsProviderOfSpecificContext<TContext>
        where TContext :  class, JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ISpecificCodeCompletionContext
    {
        protected override bool AddLookupItems(TContext context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector) { }
        protected abstract void CollectElement(JetBrains.ReSharper.Psi.Resolve.ISymbolInfo symbolInfo, TContext context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector);
        [JetBrains.Annotations.CanBeNullAttribute()]
        protected virtual JetBrains.Text.IdentifierMatcher GetIdentifierMatcher([JetBrains.Annotations.NotNullAttribute()] TContext context) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        protected abstract string GetPreffix([JetBrains.Annotations.NotNullAttribute()] TContext context);
        [JetBrains.Annotations.CanBeNullAttribute()]
        protected abstract JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetSymbolTable([JetBrains.Annotations.NotNullAttribute()] TContext context);
        protected override bool IsAvailable(TContext context) { }
    }
    public abstract class ReparsedCodeCompletionContext
    {
        protected ReparsedCodeCompletionContext([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.IFile file, JetBrains.ReSharper.Psi.TreeTextRange range, string newText) { }
        protected int NewRangeLength { get; }
        protected JetBrains.ReSharper.Psi.Tree.IFile OriginalFile { get; }
        protected JetBrains.ReSharper.Psi.TreeTextRange Range { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Psi.Resolve.IReference Reference { get; }
        public JetBrains.ReSharper.Psi.Tree.ITreeNode RootNode { get; }
        protected int StartOffsetInNewNode { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Psi.Tree.ITreeNode TreeNode { get; }
        protected virtual JetBrains.ReSharper.Psi.Resolve.IReference FindReference(JetBrains.ReSharper.Psi.TreeTextRange referenceRange, JetBrains.ReSharper.Psi.Tree.ITreeNode treeNode) { }
        protected virtual JetBrains.ReSharper.Psi.TreeTextRange GetRangeOfReference(int startOffsetInNewNode) { }
        protected abstract JetBrains.ReSharper.Psi.Services.IReparseContext GetReparseContext(JetBrains.ReSharper.Psi.Tree.IFile file, JetBrains.ReSharper.Psi.TreeTextRange range);
        public void Init() { }
        public virtual JetBrains.Util.TextRange ToDocumentRange(JetBrains.ReSharper.Psi.TreeTextRange treeRange) { }
        public JetBrains.ReSharper.Psi.TreeTextRange ToOriginalTreeRange(JetBrains.ReSharper.Psi.TreeTextRange treeRange) { }
    }
    public class SimpleCompletingCharsProvider : JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ICompletingCharsProvider
    {
        public static JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.SimpleCompletingCharsProvider Instance;
        public JetBrains.ReSharper.Feature.Services.Lookup.LookupItemInsertType GetEnterAction(JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ISpecificCodeCompletionContext context, JetBrains.Application.Settings.IContextBoundSettingsStore settingsStore) { }
        public JetBrains.ReSharper.Feature.Services.Lookup.LookupItemInsertType GetTabAction(JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ISpecificCodeCompletionContext context, JetBrains.Application.Settings.IContextBoundSettingsStore settingsStore) { }
        public bool IsApplicable(JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ISpecificCodeCompletionContext context) { }
        public JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.CompletionAction IsCharacterAcceptable(char c, JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ISpecificCodeCompletionContext context, JetBrains.Application.Settings.IContextBoundSettingsStore settingsStore) { }
        public static JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.CompletionAction IsCharacterAcceptableBasic(char c) { }
    }
    public abstract class SpecificCodeCompletionContext : JetBrains.Util.UserDataHolder, JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ISpecificCodeCompletionContext, JetBrains.ReSharper.Feature.Services.Lookup.IElementPointerFactory
    {
        protected SpecificCodeCompletionContext([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.CodeCompletionContext context) { }
        public JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.CodeCompletionContext BasicContext { get; }
        public abstract string ContextId { get; }
        public virtual JetBrains.ReSharper.Psi.PsiLanguageType Language { get; }
        public virtual JetBrains.ReSharper.Psi.Pointers.IElementInstancePointer<T> CreateElementPointer<T>(JetBrains.ReSharper.Psi.DeclaredElementInstance<T> instance)
            where T :  class, JetBrains.ReSharper.Psi.IDeclaredElement { }
        protected static JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.CompletionAction IsCharacterAcceptableBasic(char c) { }
    }
    public class TextLookupRanges
    {
        public TextLookupRanges(JetBrains.Util.TextRange insertRange, JetBrains.Util.TextRange replaceRange) { }
        public JetBrains.Util.TextRange InsertRange { get; }
        public JetBrains.Util.TextRange ReplaceRange { get; }
        public JetBrains.Util.TextRange GetPrefixRange([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.CodeCompletionContext context) { }
        public JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.TextLookupRanges WithInsertRange(JetBrains.Util.TextRange insertRange) { }
        public JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.TextLookupRanges WithReplaceRange(JetBrains.Util.TextRange replaceRange) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.CodeCompletion.PreferencePolicy
{
    
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class CompletionStatisticsManager
    {
        public string LastChoiceContextId;
        public string LastChoiceItemId;
        public CompletionStatisticsManager(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Psi.Impl.PsiConfigurationImpl configuration) { }
        public void AddStatistics(string contextId, string itemId) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static string GetContextIdentifier([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public int GetPosition(JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem lookupItem, string contextId) { }
        protected class ItemStatistics
        {
            public ItemStatistics() { }
            public ItemStatistics(JetBrains.ReSharper.Feature.Services.CodeCompletion.PreferencePolicy.CompletionStatisticsManager.PriorityStringList items) { }
            public void AddCompletedItemId(string itemId) { }
            public int GetItemScore(string itemId) { }
            public JetBrains.ReSharper.Feature.Services.CodeCompletion.PreferencePolicy.CompletionStatisticsManager.ItemStatistics Read(System.IO.BinaryReader reader) { }
            public void Write(System.IO.BinaryWriter writer) { }
        }
        protected class PriorityStringList
        {
            public PriorityStringList() { }
            public PriorityStringList(System.Collections.Generic.Dictionary<string, int> priorities) { }
            public int GetPriority(string itemId) { }
            public void IncreasePriority(string item) { }
            public void Read(System.IO.BinaryReader reader) { }
            public void Write(System.IO.BinaryWriter writer) { }
        }
    }
}
namespace JetBrains.ReSharper.Feature.Services.CodeCompletion.PreferencePolicy.Upgrade
{
    
    [JetBrains.ProjectModel.Settings.Upgrade.SolutionSettingsUpgraderAttribute()]
    public class CompletionStatisticsManagerUpgrader : JetBrains.Application.Configuration.Upgrade.ISettingsUpgrader, JetBrains.ProjectModel.Settings.Upgrade.ISolutionSettingsUpgrader
    {
        public CompletionStatisticsManagerUpgrader(JetBrains.ReSharper.Feature.Services.CodeCompletion.PreferencePolicy.CompletionStatisticsManager manager) { }
        public void Upgrade(JetBrains.Application.Configuration.IComponentSettingsProvider legacySettingsProvider, JetBrains.Application.Settings.IContextBoundSettingsStore boundSettingsStore, JetBrains.DataFlow.Lifetime upgradeLifetime) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings
{
    
    [JetBrains.Application.Settings.SettingsKeyAttribute(typeof(JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.CodeCompletionSettingsKey), "Automatic code completion")]
    public class AutopopupEnabledSettingsKey
    {
        [JetBrains.Application.Settings.SettingsEntryAttribute(true, "Enable automatic ReSharper IntelliSense popup")]
        public bool AutopopupEnabled;
    }
    public enum AutopopupType
    {
        NoAutopopup = 0,
        SoftAutopopup = 1,
        HardAutopopup = 2,
    }
    [JetBrains.Application.Settings.SettingsKeyAttribute(typeof(JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.IntellisenseSettingsKey), "Code completion settings")]
    public class CodeCompletionSettingsKey
    {
        [JetBrains.Application.Settings.SettingsEntryAttribute(false, "Automatically complete items in Symbol completion")]
        public bool AutoCompleteBasicCompletion;
        [JetBrains.Application.Settings.SettingsEntryAttribute(false, "Automatically complete items In Import completion")]
        public bool AutoCompleteImportCompletion;
        [JetBrains.Application.Settings.SettingsEntryAttribute(true, "Automatically complete items in Smart completion")]
        public bool AutoCompleteSmartCompletion;
        [JetBrains.Application.Settings.SettingsEntryAttribute(0, "Automatic popup delay (in milliseconds)")]
        public int AutoPopupDelay;
        [JetBrains.Application.Settings.SettingsEntryAttribute(true, "Show confirmation dialog before adding reference")]
        public bool ConfirmReferenceAdd;
        [JetBrains.Application.Settings.SettingsEntryAttribute(JetBrains.ReSharper.Feature.Services.CodeCompletion.EditorBrowsableProcessingType.All, "Editor browsable processing")]
        public JetBrains.ReSharper.Feature.Services.CodeCompletion.EditorBrowsableProcessingType EditorBrowsableProcessing;
        [JetBrains.Application.Settings.SettingsEntryAttribute(JetBrains.ReSharper.Feature.Services.Lookup.LookupItemInsertType.Insert, "Enter key action")]
        public JetBrains.ReSharper.Feature.Services.Lookup.LookupItemInsertType EnterKeyInsertType;
        [JetBrains.Application.Settings.SettingsEntryAttribute(false, "Extension methods in smart completion")]
        public bool ExtensionMethodsInSmartCompletion;
        [JetBrains.Application.Settings.SettingsEntryAttribute(true, "Import items in automatic completion")]
        public bool ImportItemsInAutomaticCompletion;
        [JetBrains.Application.Settings.SettingsEntryAttribute(true, "Import items in basic completion")]
        public bool ImportItemsInBasicCompletion;
        [JetBrains.Application.Settings.SettingsEntryAttribute(true, "Keyword completion enabled")]
        public bool KeywordCompletionEnabled;
        [JetBrains.Application.Settings.SettingsEntryAttribute(4, "Keyword completion minimal length")]
        public int KeywordCompletionMinLength;
        [JetBrains.Application.Settings.SettingsEntryAttribute(true, "Use middle matching in completion list")]
        public bool MiddleMatchingCompletion;
        [JetBrains.Application.Settings.SettingsEntryAttribute(JetBrains.ReSharper.Feature.Services.CodeCompletion.ParenthesesInsertType.Both, "Parentheses insertion type")]
        public JetBrains.ReSharper.Feature.Services.CodeCompletion.ParenthesesInsertType ParenthesesInsertType;
        [JetBrains.Application.Settings.SettingsEntryAttribute(JetBrains.ReSharper.Feature.Services.Lookup.LookupItemInsertType.Replace, "Tab key action")]
        public JetBrains.ReSharper.Feature.Services.Lookup.LookupItemInsertType TabKeyInsertType;
    }
    public enum CompletionAction
    {
        Accept = 0,
        NotAccept = 1,
        NotAcceptWithContinuation = 2,
        Terminate = 3,
    }
    [JetBrains.Application.Settings.SettingsKeyAttribute(typeof(JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.CodeCompletionSettingsKey), "Other")]
    public class IntelliSenseCompletingCharactersSettingsKey
    {
        [JetBrains.Application.Settings.SettingsEntryAttribute(true, "Complete on space")]
        public bool CompleteOnSpace;
        [JetBrains.Application.Settings.SettingsEntryAttribute(JetBrains.ReSharper.Feature.Services.Lookup.LookupItemInsertType.Insert, "Enter action")]
        public JetBrains.ReSharper.Feature.Services.Lookup.LookupItemInsertType EnterAction;
        [JetBrains.Application.Settings.SettingsEntryAttribute("", "Non-completing characters")]
        public string NonCompletingCharacters;
        [JetBrains.Application.Settings.SettingsEntryAttribute(JetBrains.ReSharper.Feature.Services.Lookup.LookupItemInsertType.Replace, "Tab action")]
        public JetBrains.ReSharper.Feature.Services.Lookup.LookupItemInsertType TabAction;
    }
    [JetBrains.Application.Settings.SettingsKeyAttribute(typeof(JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.CodeCompletionSettingsKey), "IntelliSense enabling settings set")]
    public class IntellisenseEnabledSettingsKey { }
    public enum IntellisenseEnabledType
    {
        Enabled = 0,
        Disabled = 1,
        PerTechnology = 2,
    }
    [JetBrains.Application.Settings.SettingsKeyAttribute(typeof(JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.CodeCompletionSettingsKey), "IntelliSense globally enabled")]
    public class IntellisenseGloballyEnabledSettingsKey
    {
        [JetBrains.Application.Settings.SettingsEntryAttribute(JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.IntellisenseEnabledType.Enabled, "Specifies whether to override VS IntelliSense with ReSharper IntelliSense for sym" +
            "bol code completion, automatic code completion and Parameter Info")]
        public JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.IntellisenseEnabledType IntellisenseEnabled;
    }
    [JetBrains.Application.Settings.SettingsKeyAttribute(typeof(JetBrains.Application.Settings.HousekeepingSettings), "IntelliSense housekeeping settings")]
    public class IntellisenseHousekeepingSettings
    {
        [JetBrains.Application.Settings.SettingsEntryAttribute(false, "Whether hint was shown")]
        public bool HintUsed;
    }
    [JetBrains.Application.Configuration.Upgrade.GlobalSettingsUpgraderAttribute()]
    public class IntellisenseHousekeepingSettingsUpgrader : JetBrains.Application.Configuration.SettingTablesUpgrader
    {
        public IntellisenseHousekeepingSettingsUpgrader(JetBrains.Application.Env.RunsProducts.ProductConfigurations productConfigurations) { }
        protected override void DoUpgrade(JetBrains.Application.Configuration.IComponentSettingsProvider legacySettingsProvider, JetBrains.Application.Settings.IContextBoundSettingsStore boundSettingsStore, JetBrains.DataFlow.Lifetime upgradeLifetime, JetBrains.Application.Configuration.SettingsTableBase workspaceSettingsTable, JetBrains.Application.Configuration.SettingsTableBase globalSettingsTable) { }
    }
    [JetBrains.Application.Settings.SettingsKeyAttribute(typeof(JetBrains.ReSharper.Settings.CodeEditingSettings), "IntelliSense settings")]
    public class IntellisenseSettingsKey { }
    public abstract class LanguageSpecificIntellisenseManager
    {
        protected JetBrains.Application.Settings.ISettingsStore SettingsStore;
        protected LanguageSpecificIntellisenseManager(JetBrains.Application.Settings.ISettingsStore settingsStore) { }
        public bool GetAutoppopupEnabled(JetBrains.Application.Settings.IContextBoundSettingsStore contextBoundSettingsStore) { }
        public bool GetIntellisenseEnabled(JetBrains.Application.Settings.IContextBoundSettingsStore boundSettingsStore) { }
        protected abstract bool GetIntellisenseEnabledSpecific(JetBrains.Application.Settings.IContextBoundSettingsStore boundSettingsStore);
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class UseReSharperIntelliSenseActivityTrackingProvider : JetBrains.Application.ActivityTrackingNew.IActivityTrackingStatisticsProvider
    {
        public UseReSharperIntelliSenseActivityTrackingProvider(JetBrains.DataFlow.Lifetime lifetime) { }
        public void GetActivityStatistics(JetBrains.ActivityTracking.ActivityLog log) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.CodeCompletion.SettingsUpgrade
{
    
    [System.ObsoleteAttribute("Deprecated, use CodeCompletionSettingsKey")]
    public class CodeCompletionSettings : JetBrains.Application.Configuration.IXmlReadable
    {
        [JetBrains.Application.Configuration.XmlExternalizableAttribute(false)]
        public readonly JetBrains.DataFlow.Property<bool> AutoCompleteBasicCompletion;
        [JetBrains.Application.Configuration.XmlExternalizableAttribute(false)]
        public readonly JetBrains.DataFlow.Property<bool> AutoCompleteClassNameCompletion;
        [JetBrains.Application.Configuration.XmlExternalizableAttribute(true)]
        public readonly JetBrains.DataFlow.Property<bool> AutoCompleteSmartCompletion;
        [JetBrains.Application.Configuration.XmlExternalizableAttribute(true)]
        public readonly JetBrains.DataFlow.Property<bool> AutoPopupAfterDot;
        [JetBrains.Application.Configuration.XmlExternalizableAttribute(true)]
        public readonly JetBrains.DataFlow.Property<bool> AutoPopupAfterNew;
        [JetBrains.Application.Configuration.XmlExternalizableAttribute(0, SettingName="AutoPopupDelay2")]
        public readonly JetBrains.DataFlow.Property<int> AutoPopupDelay;
        [JetBrains.Application.Configuration.XmlExternalizableAttribute(true)]
        public readonly JetBrains.DataFlow.Property<bool> AutoPopupOnIdentifier;
        [JetBrains.Application.Configuration.XmlExternalizableAttribute(JetBrains.ReSharper.Feature.Services.CodeCompletion.EditorBrowsableProcessingType.All)]
        public readonly JetBrains.DataFlow.Property<JetBrains.ReSharper.Feature.Services.CodeCompletion.EditorBrowsableProcessingType> EditorBrowsableProcessing;
        [JetBrains.Application.Configuration.XmlExternalizableAttribute(JetBrains.ReSharper.Feature.Services.CodeCompletion.ParenthesesInsertType.Both)]
        public readonly JetBrains.DataFlow.Property<JetBrains.ReSharper.Feature.Services.CodeCompletion.ParenthesesInsertType> InsertType;
        [JetBrains.Application.Configuration.XmlExternalizableAttribute(true)]
        public readonly JetBrains.DataFlow.Property<bool> KeywordCompletionEnabled;
        [JetBrains.Application.Configuration.XmlExternalizableAttribute(4)]
        public readonly JetBrains.DataFlow.Property<int> KeywordCompletionMinLength;
        [JetBrains.Application.Configuration.XmlExternalizableAttribute(true)]
        public readonly JetBrains.DataFlow.Property<bool> MiddleMatchingCompletion;
        public CodeCompletionSettings(JetBrains.Application.Configuration.IComponentSettingsProvider shellSettings, JetBrains.DataFlow.Lifetime lifetime) { }
    }
    [JetBrains.Application.Configuration.Upgrade.GlobalSettingsUpgraderAttribute()]
    public class CodeCompletionSettingsUpgrader : JetBrains.Application.Configuration.Upgrade.IGlobalSettingsUpgrader, JetBrains.Application.Configuration.Upgrade.ISettingsUpgrader
    {
        public void Upgrade(JetBrains.Application.Configuration.IComponentSettingsProvider legacySettingsProvider, JetBrains.Application.Settings.IContextBoundSettingsStore boundSettingsStore, JetBrains.DataFlow.Lifetime upgradeLifetime) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.Colors
{
    
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class ColorDeclaredElementDataRules
    {
        public ColorDeclaredElementDataRules(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.DataContext.DataContexts dataContexts) { }
    }
    public interface IColorDeclaredElementSearcher
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        System.Collections.Generic.IEnumerable<string> GetWords([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Colors.IColorDeclaredElement element);
    }
    [JetBrains.ReSharper.Psi.PsiSharedComponentAttribute()]
    public class InjectionAttributeNames : JetBrains.ReSharper.Psi.Impl.Reflection2.ExternalAnnotations.IExternalAnnotationsAttributeWatcher
    {
        public static readonly JetBrains.ReSharper.Psi.IClrTypeName[] AllInjectionsClrNames;
        public static readonly JetBrains.ReSharper.Psi.IClrTypeName HtmlAttributeValueClrTypeName;
        public static readonly JetBrains.ReSharper.Psi.IClrTypeName HtmlElementAttributesClrTypeName;
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IClrTypeName> AttributeClrNamesToWatch { get; }
    }
}
namespace JetBrains.ReSharper.Feature.Services.Comment
{
    
    public interface IBlockCommentActionProvider
    {
        string EndBlockCommentMarker { get; }
        string NestedEndBlockCommentMarker { get; }
        string NestedStartBlockCommentMarker { get; }
        string StartBlockCommentMarker { get; }
        JetBrains.Util.TextRange GetBlockComment(JetBrains.ReSharper.Psi.Parsing.CachingLexer lexer);
        int InsertBockCommentPosition(JetBrains.ReSharper.Psi.Parsing.ILexer lexer, int position);
    }
    public interface ILineCommentActionProvider
    {
        string EndLineCommentMarker { get; }
        string StartLineCommentMarker { get; }
        JetBrains.Util.TextRange GetLineCommentRange(JetBrains.ReSharper.Psi.Parsing.CachingLexer lexer, JetBrains.Util.TextRange lineRange, out int startCommentLength, out int endCommentLength, out bool doNotUncomment);
    }
    public abstract class SimpleLineCommentActionProvider : JetBrains.ReSharper.Feature.Services.Comment.ILineCommentActionProvider
    {
        public string EndLineCommentMarker { get; }
        public abstract string StartLineCommentMarker { get; }
        protected virtual int GetEndCommentLength(JetBrains.ReSharper.Psi.Parsing.CachingLexer lexer) { }
        public JetBrains.Util.TextRange GetLineCommentRange(JetBrains.ReSharper.Psi.Parsing.CachingLexer lexer, JetBrains.Util.TextRange lineRange, out int startCommentLength, out int endCommentLength, out bool doNotUncomment) { }
        protected virtual int GetStartCommentLength(JetBrains.ReSharper.Psi.Parsing.CachingLexer lexer) { }
        protected abstract bool IsEndOfLineComment(JetBrains.ReSharper.Psi.Parsing.TokenNodeType tokenType, string tokenText);
        protected abstract bool IsNewLine(JetBrains.ReSharper.Psi.Parsing.TokenNodeType tokenType);
        protected abstract bool IsWhitespace(JetBrains.ReSharper.Psi.Parsing.TokenNodeType tokenType);
    }
}
namespace JetBrains.ReSharper.Feature.Services.CompleteStatement
{
    
    public abstract class ElementBasedCompleteStatementActionProvider : JetBrains.ReSharper.Feature.Services.CompleteStatement.ICompleteStatementActionProvider
    {
        protected ElementBasedCompleteStatementActionProvider() { }
        public void CompleteStatement(JetBrains.TextControl.ITextControl textControl, JetBrains.ProjectModel.ISolution solution) { }
        protected void Fix<T>([JetBrains.Annotations.NotNullAttribute()] System.Action<T, JetBrains.ReSharper.Feature.Services.CompleteStatement.ElementBasedCompleteStatementActionProvider.FixContext> fixer)
            where T :  class, JetBrains.ReSharper.Psi.Tree.ITreeNode { }
        protected void Fix([JetBrains.Annotations.NotNullAttribute()] System.Action<JetBrains.ReSharper.Feature.Services.CompleteStatement.ElementBasedCompleteStatementActionProvider.FixContext> fixer) { }
        protected static JetBrains.Util.dataStructures.TypedIntrinsics.Int32<JetBrains.DocumentModel.DocLine> GetEndLine(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        protected static JetBrains.Util.TextRange GetRange(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Tree.ITreeNode> elements) { }
        protected static JetBrains.Util.dataStructures.TypedIntrinsics.Int32<JetBrains.DocumentModel.DocLine> GetStartLine(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        protected void StopAt<T>()
            where T :  class, JetBrains.ReSharper.Psi.Tree.ITreeNode { }
        protected void StopAt<T>(System.Predicate<T> predicate)
            where T :  class, JetBrains.ReSharper.Psi.Tree.ITreeNode { }
        protected static bool StopAtError(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Feature.Services.CompleteStatement.ElementBasedCompleteStatementActionProvider.FixContext fixContext) { }
        protected class FixContext
        {
            public FixContext(JetBrains.TextControl.ITextControl textControl, JetBrains.ProjectModel.ISolution solution) { }
            public bool ChangeDone { get; }
            public bool DoSmartEnter { get; }
            public bool FixingStopped { get; }
            public JetBrains.ProjectModel.ISolution Solution { get; }
            public JetBrains.TextControl.ITextControl TextControl { get; }
            public bool TreeBroken { get; }
            public System.Nullable<int> UnresolvedErrorOffset { get; }
            public JetBrains.Util.dataStructures.TypedIntrinsics.Int32<JetBrains.DocumentModel.DocLine> GetCaretLine() { }
            public JetBrains.Util.TextRange GetRangeToFormat() { }
            public void InsertAfter(JetBrains.DocumentModel.DocumentRange elementRange, string str) { }
            public void InsertAfter(JetBrains.ReSharper.Psi.Tree.ITreeNode element, string str) { }
            public void NewIteration() { }
            public void PostponeFormat(JetBrains.DocumentModel.IRangeMarker marker) { }
            public void PostponeFormat(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
            public void RegisterBrokenTree() { }
            public void RegisterChange() { }
            public void RegisterPoint(bool doSmartEnter, int offset) { }
            public void RegisterPointAfter(bool doSmartEnter, JetBrains.DocumentModel.DocumentRange elementRange, int offset = 0) { }
            public void RegisterPointAfter(bool doSmartEnter, JetBrains.DocumentModel.DocumentRange elementRange, string added) { }
            public void RegisterPointBefore(bool doSmartEnter, JetBrains.DocumentModel.DocumentRange elementRange, string added) { }
            public void Replace(JetBrains.ReSharper.Psi.Tree.ITreeNode element, string str) { }
            public void Replace(JetBrains.DocumentModel.DocumentRange elementRange, string str) { }
            public void StopFixing() { }
        }
    }
    public interface ICompleteStatementActionProvider
    {
        void CompleteStatement([JetBrains.Annotations.NotNullAttribute()] JetBrains.TextControl.ITextControl textControl, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.ISolution solution);
    }
}
namespace JetBrains.ReSharper.Feature.Services.Descriptions
{
    
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class DeclaredElementDescriptionPresenter : JetBrains.ReSharper.Feature.Services.Descriptions.IDeclaredElementDescriptionPresenter
    {
        public DeclaredElementDescriptionPresenter(JetBrains.DataFlow.IViewable<JetBrains.ReSharper.Feature.Services.Descriptions.IDeclaredElementDescriptionProvider> providers, JetBrains.DataFlow.Lifetime lifetime) { }
        public JetBrains.UI.RichText.RichTextBlock GetDeclaredElementDescription([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IDeclaredElement element, JetBrains.ReSharper.Feature.Services.Descriptions.DeclaredElementDescriptionStyle style = null, JetBrains.ReSharper.Psi.PsiLanguageType language = null, JetBrains.ReSharper.Psi.Modules.IPsiModule module = null) { }
        public bool IsDeclaredElementObsolete(JetBrains.ReSharper.Psi.IDeclaredElement element) { }
        public bool IsDeclaredElementObsolete(JetBrains.ReSharper.Psi.IDeclaredElement element, out JetBrains.UI.RichText.RichTextBlock obsoleteDescription, JetBrains.ReSharper.Feature.Services.Descriptions.DeclaredElementDescriptionStyle style = null) { }
    }
    [JetBrains.Annotations.BaseTypeRequiredAttribute(typeof(JetBrains.ReSharper.Feature.Services.Descriptions.IDeclaredElementDescriptionProvider))]
    [JetBrains.Annotations.MeansImplicitUseAttribute()]
    [System.AttributeUsageAttribute(System.AttributeTargets.Class | System.AttributeTargets.All, AllowMultiple=false, Inherited=false)]
    public sealed class DeclaredElementDescriptionProviderAttribute : JetBrains.ProjectModel.SolutionComponentAttribute { }
    public interface IDeclaredElementDescriptionProvider
    {
        int Priority { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.UI.RichText.RichTextBlock GetElementDescription([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IDeclaredElement element, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Feature.Services.Descriptions.DeclaredElementDescriptionStyle style, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.PsiLanguageType language, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Modules.IPsiModule module);
        System.Nullable<bool> IsElementObsolete([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IDeclaredElement element, out JetBrains.UI.RichText.RichTextBlock obsoleteDescription, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Feature.Services.Descriptions.DeclaredElementDescriptionStyle style);
    }
}
namespace JetBrains.ReSharper.Feature.Services.Explanatory
{
    
    [JetBrains.Application.ShellComponentAttribute()]
    public class CodeInspectionWikiDataProvider : JetBrains.ReSharper.Feature.Services.Explanatory.ICodeInspectionWikiDataProvider
    {
        public CodeInspectionWikiDataProvider(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Threading.IThreading threading) { }
        protected void LoadData(string content) { }
        protected virtual void StartDownloading(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Threading.IThreading threading) { }
        public bool TryGetValue(string attributeId, out string url) { }
    }
    public interface ICodeInspectionWikiDataProvider
    {
        bool TryGetValue(string attributeId, out string url);
    }
}
namespace JetBrains.ReSharper.Feature.Services.Filtering
{
    
    public class CamelCasePrefixMatcher : JetBrains.ReSharper.Feature.Services.Filtering.PrefixMatcher
    {
        public CamelCasePrefixMatcher(string prefix, bool appendEnding, bool bMatchBeginningOfStringOnly) { }
        public override string BuildRegexString(string prefix) { }
        public System.Collections.Generic.IEnumerable<JetBrains.Util.TextRange> Match(string nameToMatch) { }
    }
    public class FilteringPrefixMatcher : JetBrains.ReSharper.Feature.Services.Filtering.PrefixMatcher
    {
        public FilteringPrefixMatcher([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Feature.Services.Filtering.PrefixMatcher matcher, [JetBrains.Annotations.NotNullAttribute()] System.Func<string, bool> funcFilter) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ReSharper.Feature.Services.Filtering.PrefixMatcher Matcher { get; }
        public override string BuildRegexString(string prefix) { }
        public override bool IsMatch(string nameToMatch) { }
    }
    public class PlainPrefixMatcher : JetBrains.ReSharper.Feature.Services.Filtering.PrefixMatcher
    {
        public PlainPrefixMatcher(string prefix, bool appendEnding, bool includeStartLine) { }
        public override string BuildRegexString(string prefix) { }
    }
    public abstract class PrefixMatcher
    {
        protected const string LOWERCASE_OR_DIGIT = "[_\\p{Ll}\\d]*";
        protected PrefixMatcher(string prefix, bool appendEnding, bool bMatchBeginningOfStringOnly) { }
        public bool AppendEnding { get; }
        public string FilteringPrefix { get; }
        public bool IsValid { get; }
        public bool MatchBeginningOfStringOnly { get; }
        protected System.Text.RegularExpressions.Regex MatchingRegex { get; }
        public string Prefix { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public abstract string BuildRegexString([JetBrains.Annotations.NotNullAttribute()] string prefix);
        public string GetSuffix(string nameToMatch) { }
        protected static bool IsAllUppercase(string text) { }
        public virtual bool IsMatch(string nameToMatch) { }
        protected static string TransformAbbreviation(string abbreviation, string expandor, bool captureCharacters) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.Generate.Actions
{
    
    public abstract class GenerateActionBase<TGenerateActionProvider> : JetBrains.ReSharper.Feature.Services.ActionsMenu.ExtensibleAction<TGenerateActionProvider, JetBrains.ReSharper.Feature.Services.Generate.Actions.IGenerateActionWorkflow, JetBrains.ReSharper.Feature.Services.Generate.Actions.GenerateActionGroup>
        where TGenerateActionProvider :  class, JetBrains.ReSharper.Feature.Services.ActionsMenu.IWorkflowProvider<, >, JetBrains.ReSharper.Feature.Services.Generate.Actions.IGenerateActionProvider
    {
        protected override bool AssertsMenuItemsMnemonics { get; }
        protected override JetBrains.UI.RichText.RichText Caption { get; }
        protected override bool ShowMenuWithOneItem { get; }
        protected override int CompareWorkflowItems(JetBrains.Util.Pair<JetBrains.ReSharper.Feature.Services.Generate.Actions.IGenerateActionWorkflow, TGenerateActionProvider> item1, JetBrains.Util.Pair<JetBrains.ReSharper.Feature.Services.Generate.Actions.IGenerateActionWorkflow, TGenerateActionProvider> item2) { }
        protected override void Execute(JetBrains.Application.DataContext.IDataContext context, JetBrains.ReSharper.Feature.Services.Generate.Actions.IGenerateActionWorkflow workflow) { }
        protected override JetBrains.UI.Icons.IconId GetIcon(JetBrains.Application.DataContext.IDataContext dataContext) { }
        protected override System.Collections.Generic.ICollection<TGenerateActionProvider> GetWorkflowProviders() { }
        protected override bool IsAvailable(JetBrains.Application.DataContext.IDataContext context, JetBrains.ReSharper.Feature.Services.Generate.Actions.IGenerateActionWorkflow workflow) { }
        protected override bool IsEnabled(JetBrains.Application.DataContext.IDataContext context, JetBrains.ReSharper.Feature.Services.Generate.Actions.IGenerateActionWorkflow workflow) { }
    }
    public sealed class GenerateActionGroup : JetBrains.ReSharper.Feature.Services.ActionsMenu.ActionGroup
    {
        public static readonly JetBrains.ReSharper.Feature.Services.Generate.Actions.GenerateActionGroup ASP;
        public static readonly JetBrains.ReSharper.Feature.Services.Generate.Actions.GenerateActionGroup CLR_LANGUAGE;
        public static readonly JetBrains.ReSharper.Feature.Services.Generate.Actions.GenerateActionGroup FILE_TEMPLATES;
        public static readonly JetBrains.ReSharper.Feature.Services.Generate.Actions.GenerateActionGroup SOLUTION_EXPLORER;
        public static readonly JetBrains.ReSharper.Feature.Services.Generate.Actions.GenerateActionGroup XAML;
        public GenerateActionGroup([JetBrains.Annotations.NotNullAttribute()] string name, float order) { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class GenerateManager
    {
        public GenerateManager(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.Generate.Actions.IGenerateActionProvider> providers) { }
        public static JetBrains.ReSharper.Feature.Services.Generate.Actions.GenerateManager Instance { get; }
        public System.Collections.Generic.IEnumerable<TGenerateProvider> GetGenerationProviders<TGenerateProvider>()
            where TGenerateProvider :  class, JetBrains.ReSharper.Feature.Services.Generate.Actions.IGenerateActionProvider { }
    }
    [JetBrains.Annotations.BaseTypeRequiredAttribute(typeof(JetBrains.ReSharper.Feature.Services.Generate.Actions.IGenerateActionProvider))]
    [JetBrains.Annotations.MeansImplicitUseAttribute()]
    [System.AttributeUsageAttribute(System.AttributeTargets.Class | System.AttributeTargets.All)]
    public class GenerateProviderAttribute : JetBrains.Application.ShellComponentAttribute { }
    public interface IGenerateActionProvider : JetBrains.ReSharper.Feature.Services.ActionsMenu.IWorkflowProvider<JetBrains.ReSharper.Feature.Services.Generate.Actions.IGenerateActionWorkflow, JetBrains.ReSharper.Feature.Services.Generate.Actions.GenerateActionGroup> { }
    public interface IGenerateActionWorkflow : JetBrains.ReSharper.Feature.Services.ActionsMenu.IWorkflow<JetBrains.ReSharper.Feature.Services.Generate.Actions.GenerateActionGroup>
    {
        double Order { get; }
        void Execute(JetBrains.Application.DataContext.IDataContext context);
        bool IsAvailable(JetBrains.Application.DataContext.IDataContext dataContext);
        bool IsEnabled(JetBrains.Application.DataContext.IDataContext context);
    }
}
namespace JetBrains.ReSharper.Feature.Services.Generate
{
    
    public abstract class CodeBehindGeneratorBuilderBase<TGeneratorContext, TCodeBehindContext> : JetBrains.ReSharper.Feature.Services.Generate.GeneratorBuilderBase<TGeneratorContext>
        where TGeneratorContext :  class, JetBrains.ReSharper.Feature.Services.Generate.IGeneratorContext
        where TCodeBehindContext :  class, JetBrains.ReSharper.Feature.Services.Generate.IGeneratorContext
    {
        protected const string OpenCodeBehindForUndoOptionKey = "OpenCodebehindForUndoKey";
        protected JetBrains.ReSharper.Feature.Services.Generate.IGeneratorBuilder CodeBehindBuilder { get; }
        protected abstract JetBrains.ReSharper.Feature.Services.Generate.IGeneratorBuilder CreateCodeBehindBuilder();
        protected abstract TCodeBehindContext CreateCodeBehindContext(TGeneratorContext context);
        protected override System.Collections.Generic.IList<JetBrains.ReSharper.Feature.Services.Generate.IGeneratorOption> GetGlobalOptions(TGeneratorContext context) { }
        protected override System.Collections.Generic.IList<JetBrains.ReSharper.Feature.Services.Generate.IGeneratorOption> GetInputElementOptions(JetBrains.ReSharper.Feature.Services.Generate.IGeneratorElement inputElement, TGeneratorContext context) { }
        protected override bool HasProcessableElements(TGeneratorContext context, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.Generate.IGeneratorElement> elements) { }
        public virtual bool HasProcessableElements(TGeneratorContext context, TCodeBehindContext codeBehindContext, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.Generate.IGeneratorElement> elements) { }
        protected override bool IsAvaliable(TGeneratorContext context) { }
        public virtual bool IsAvaliable(TGeneratorContext context, TCodeBehindContext codeBehindContext) { }
        protected override void Process(TGeneratorContext context) { }
        public virtual void Process(TGeneratorContext context, TCodeBehindContext codeBehindContext) { }
    }
    public abstract class GenerateEventSubscriptionsBuilderBase<TGeneratorContext> : JetBrains.ReSharper.Feature.Services.Generate.GeneratorBuilderBase<TGeneratorContext>
        where TGeneratorContext :  class, JetBrains.ReSharper.Feature.Services.Generate.IGeneratorContext
    {
        protected const string EventHandlerPrefixOptionKey = "EventHandlerPrefixOptionKey";
        protected const string EventHandlerSuffix = "_On";
        protected virtual string GetEventName(JetBrains.ReSharper.Feature.Services.Generate.IGeneratorElement element) { }
        protected override System.Collections.Generic.IList<JetBrains.ReSharper.Feature.Services.Generate.IGeneratorOption> GetGlobalOptions(TGeneratorContext context) { }
        protected virtual string MakeEventHandlerName(TGeneratorContext context, string prefix, JetBrains.ReSharper.Psi.Naming.Interfaces.INamingLanguageService namingService, JetBrains.ReSharper.Feature.Services.Generate.IGeneratorElement element, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITypeDeclaration codeBehindTypeDeclaration) { }
        protected virtual string SuggestEventHandlerPrefix(TGeneratorContext context) { }
    }
    [JetBrains.Application.Settings.SettingsKeyAttribute(typeof(JetBrains.Application.Settings.EnvironmentSettings), "MRU settings for the Generate dialog")]
    public class GenerateMruSettings
    {
        [JetBrains.Application.Settings.SettingsIndexedEntryAttribute("Whether to group items to generate by type")]
        public JetBrains.Application.Settings.Store.IIndexedEntry<string, bool> GroupByType;
        [JetBrains.Application.Settings.SettingsIndexedEntryAttribute("Whether to sort items to generate by name")]
        public JetBrains.Application.Settings.Store.IIndexedEntry<string, bool> SortByName;
    }
    [JetBrains.Application.Settings.SettingsIndexedKeyAttribute(typeof(JetBrains.ReSharper.Settings.CodeStyleSettings), "How the code is generated by the Generate feature", typeof(string))]
    public class GenerateSettings
    {
        [JetBrains.Application.Settings.SettingsIndexedEntryAttribute("Bag of raw settings")]
        public JetBrains.Application.Settings.Store.IIndexedEntry<string, string> Options;
    }
    public class static GenerateUtil
    {
        public static JetBrains.ReSharper.Psi.IOverridableMember FindOverride([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.ITypeElement element, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.OverridableMemberInstance rootMember, bool includeBaseTypes = False) { }
        public static JetBrains.ReSharper.Psi.OverridableMemberInstance GetObjectMember([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.ITypeElement containingType, string shortName) { }
        public static System.Collections.Generic.IList<JetBrains.ReSharper.Psi.OverridableMemberInstance> GetOverridableMembersOrder([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.ITypeElement typeElement, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution, bool reversed) { }
        public static System.Collections.Generic.IList<JetBrains.ReSharper.Psi.OverridableMemberInstance> GetOverridableMembersOrder([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.ITypeElement typeElement, bool reversed) { }
        public static bool HasOverride([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.ITypeElement element, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.OverridableMemberInstance rootMember) { }
        public static bool HasOverrideInHierarchy([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.ITypeElement element, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.OverridableMemberInstance rootMember) { }
        public static bool HasOverrideOfObjectMethodInHierarchy(JetBrains.ReSharper.Psi.ITypeElement containingType, string shortName) { }
    }
    public class GeneratorAccessContext : JetBrains.ReSharper.Psi.Resolve.IAccessContext
    {
        public GeneratorAccessContext(JetBrains.ReSharper.Psi.ITypeElement accessPoint) { }
        public JetBrains.ReSharper.Psi.ITypeElement GetAccessContainingTypeElement() { }
        public JetBrains.ReSharper.Psi.Modules.IPsiModule GetPsiModule() { }
        public virtual JetBrains.ReSharper.Psi.Resolve.QualifierKind GetQualifierKind() { }
        public JetBrains.ReSharper.Psi.ITypeElement GetQualifierTypeElement() { }
        public JetBrains.ReSharper.Psi.Resolve.Staticness GetStaticness() { }
    }
    [JetBrains.Annotations.BaseTypeRequiredAttribute(typeof(JetBrains.ReSharper.Feature.Services.Generate.IGeneratorBuilder))]
    [JetBrains.Annotations.MeansImplicitUseAttribute()]
    [System.AttributeUsageAttribute(System.AttributeTargets.Class | System.AttributeTargets.All, AllowMultiple=true, Inherited=false)]
    public sealed class GeneratorBuilderAttribute : JetBrains.ProjectModel.SolutionComponentAttribute
    {
        public GeneratorBuilderAttribute(string kind) { }
        public GeneratorBuilderAttribute(string kind, System.Type languageType) { }
        public GeneratorBuilderAttribute(string kind, System.Type languageType, System.Type projectFileType) { }
        public string Kind { get; set; }
        public System.Type LanguageType { get; set; }
        public System.Type ProjectFileType { get; set; }
    }
    public abstract class GeneratorBuilderBase<TGeneratorContext> : JetBrains.ReSharper.Feature.Services.Generate.IGeneratorBuilder, JetBrains.ReSharper.Feature.Services.Generate.IGeneratorOptionsProvider
        where TGeneratorContext :  class, JetBrains.ReSharper.Feature.Services.Generate.IGeneratorContext
    {
        public abstract double Priority { get; }
        protected virtual System.Collections.Generic.IList<JetBrains.ReSharper.Feature.Services.Generate.IGeneratorOption> GetGlobalOptions(TGeneratorContext context) { }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Feature.Services.Generate.IGeneratorOption> GetGlobalOptions(JetBrains.ReSharper.Feature.Services.Generate.IGeneratorContext context) { }
        protected virtual System.Collections.Generic.IList<JetBrains.ReSharper.Feature.Services.Generate.IGeneratorOption> GetInputElementOptions(JetBrains.ReSharper.Feature.Services.Generate.IGeneratorElement inputElement, TGeneratorContext context) { }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Feature.Services.Generate.IGeneratorOption> GetInputElementOptions(JetBrains.ReSharper.Feature.Services.Generate.IGeneratorElement inputElement, JetBrains.ReSharper.Feature.Services.Generate.IGeneratorContext context) { }
        protected virtual System.Collections.Generic.IList<JetBrains.ReSharper.Feature.Services.Generate.IGeneratorOption> GetOutputElementOptions(JetBrains.ReSharper.Feature.Services.Generate.IGeneratorElement outputElement, TGeneratorContext context) { }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Feature.Services.Generate.IGeneratorOption> GetOutputElementOptions(JetBrains.ReSharper.Feature.Services.Generate.IGeneratorElement outputElement, JetBrains.ReSharper.Feature.Services.Generate.IGeneratorContext context) { }
        public bool HasProcessableElements(JetBrains.ReSharper.Feature.Services.Generate.IGeneratorContext context, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.Generate.IGeneratorElement> elements) { }
        protected virtual bool HasProcessableElements(TGeneratorContext context, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.Generate.IGeneratorElement> elements) { }
        protected virtual bool IsAvaliable(TGeneratorContext context) { }
        public bool IsAvaliable(JetBrains.ReSharper.Feature.Services.Generate.IGeneratorContext context) { }
        protected abstract void Process(TGeneratorContext context);
        public void Process(JetBrains.ReSharper.Feature.Services.Generate.IGeneratorContext context) { }
    }
    public class GeneratorConstructorDeclarationElement : JetBrains.ReSharper.Feature.Services.Generate.GeneratorDeclarationElement
    {
        public GeneratorConstructorDeclarationElement(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration, JetBrains.ReSharper.Feature.Services.Generate.GeneratorDeclaredElement<JetBrains.ReSharper.Psi.IConstructor> delegatedConstructor) { }
        public JetBrains.ReSharper.Feature.Services.Generate.GeneratorDeclaredElement<JetBrains.ReSharper.Psi.IConstructor> DelegatedConstructor { get; set; }
    }
    public abstract class GeneratorContextBase : JetBrains.ReSharper.Feature.Services.Generate.IGeneratorContext, System.IDisposable
    {
        protected GeneratorContextBase([JetBrains.Annotations.NotNullAttribute()] string kind, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
        public abstract JetBrains.ReSharper.Psi.Tree.ITreeNode Anchor { get; set; }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Feature.Services.Generate.IGeneratorOption> GlobalOptions { get; }
        public JetBrains.Util.OneToListMap<JetBrains.ReSharper.Feature.Services.Generate.IGeneratorElement, JetBrains.ReSharper.Feature.Services.Generate.IGeneratorOption> InputElementOptions { get; }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Feature.Services.Generate.IGeneratorElement> InputElements { get; }
        public string Kind { get; }
        public abstract JetBrains.ReSharper.Psi.PsiLanguageType Language { get; }
        public JetBrains.Util.OneToListMap<JetBrains.ReSharper.Feature.Services.Generate.IGeneratorElement, JetBrains.ReSharper.Feature.Services.Generate.IGeneratorOption> OutputElementOptions { get; }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Feature.Services.Generate.IGeneratorElement> OutputElements { get; }
        public virtual JetBrains.ReSharper.Psi.PsiLanguageType PresentationLanguage { get; }
        public abstract JetBrains.ProjectModel.IProject Project { get; }
        public JetBrains.ProjectModel.ProjectFileType ProjectFileType { get; }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Feature.Services.Generate.IGeneratorElement> ProvidedElements { get; }
        public abstract JetBrains.ReSharper.Psi.Modules.IPsiModule PsiModule { get; }
        public abstract JetBrains.ReSharper.Psi.Tree.ITreeNode Root { get; }
        public virtual void Dispose() { }
        public bool GetElementBooleanOption(JetBrains.ReSharper.Feature.Services.Generate.IGeneratorElement element, string id) { }
        public string GetElementOptionValue(JetBrains.ReSharper.Feature.Services.Generate.IGeneratorElement element, string id) { }
        public string GetGlobalOptionValue(string id) { }
        public abstract JetBrains.ReSharper.Psi.TreeTextRange GetSelectionTreeRange();
        public void SetElementOptionValue(JetBrains.ReSharper.Feature.Services.Generate.IGeneratorElement element, string id, string value) { }
        public void SetGlobalOptionValue(string id, string value) { }
    }
    public class GeneratorDeclarationElement : JetBrains.ReSharper.Feature.Services.Generate.GeneratorElementBase
    {
        public GeneratorDeclarationElement(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration) { }
        public JetBrains.ReSharper.Psi.Tree.IDeclaration Declaration { get; }
        public override string TestDescriptor { get; }
        public override object GetGroupingObject() { }
        public override object GetPresentationObject() { }
        public override bool Matches(string searchText, JetBrains.Text.IdentifierMatcher matcher) { }
    }
    public class GeneratorDeclaredElement : JetBrains.ReSharper.Feature.Services.Generate.GeneratorElementBase
    {
        public GeneratorDeclaredElement([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IClrDeclaredElement declaredElement) { }
        public GeneratorDeclaredElement([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IClrDeclaredElement declaredElement, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution) { }
        public GeneratorDeclaredElement([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IClrDeclaredElement declaredElement, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution, object groupElement) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ReSharper.Psi.IDeclaredElement DeclaredElement { get; }
        public JetBrains.ReSharper.Psi.Resolve.ISubstitution Substitution { get; }
        public override string TestDescriptor { get; }
        public override object GetGroupingObject() { }
        public override object GetPresentationObject() { }
        public override bool Matches(string searchText, JetBrains.Text.IdentifierMatcher matcher) { }
    }
    public class GeneratorDeclaredElement<T> : JetBrains.ReSharper.Feature.Services.Generate.GeneratorDeclaredElement
        where T :  class, JetBrains.ReSharper.Psi.IClrDeclaredElement
    {
        public GeneratorDeclaredElement([JetBrains.Annotations.NotNullAttribute()] T declaredElement) { }
        public GeneratorDeclaredElement([JetBrains.Annotations.NotNullAttribute()] T declaredElement, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution) { }
        protected GeneratorDeclaredElement([JetBrains.Annotations.NotNullAttribute()] T declaredElement, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution, object groupElement) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public T DeclaredElement { get; }
    }
    public class GeneratorDelagateDeclarationElement : JetBrains.ReSharper.Feature.Services.Generate.GeneratorDeclarationElement
    {
        public GeneratorDelagateDeclarationElement(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration, JetBrains.ReSharper.Feature.Services.Generate.GeneratorDeclaredElement<JetBrains.ReSharper.Psi.IOverridableMember> delegatedMember) { }
        public JetBrains.ReSharper.Feature.Services.Generate.GeneratorDeclaredElement<JetBrains.ReSharper.Psi.IOverridableMember> DelegatedMember { get; set; }
    }
    public class GeneratorDelegatingElement : JetBrains.ReSharper.Feature.Services.Generate.GeneratorDeclaredElement<JetBrains.ReSharper.Psi.IOverridableMember>
    {
        public GeneratorDelegatingElement(JetBrains.ReSharper.Psi.IOverridableMember overridableMember, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution, JetBrains.ReSharper.Psi.ITypeOwner owner) { }
        public JetBrains.ReSharper.Psi.ITypeOwner Owner { get; }
    }
    public abstract class GeneratorElementBase : JetBrains.Util.UserDataHolder, JetBrains.ReSharper.Feature.Services.Generate.IGeneratorElement
    {
        public bool Emphasize { get; set; }
        public abstract string TestDescriptor { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public abstract object GetGroupingObject();
        [JetBrains.Annotations.NotNullAttribute()]
        public abstract object GetPresentationObject();
        public static string GetTestDescriptor(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution) { }
        public abstract bool Matches(string searchText, JetBrains.Text.IdentifierMatcher matcher);
    }
    [JetBrains.Annotations.BaseTypeRequiredAttribute(typeof(JetBrains.ReSharper.Feature.Services.Generate.IGeneratorElementProvider))]
    [JetBrains.Annotations.MeansImplicitUseAttribute()]
    [System.AttributeUsageAttribute(System.AttributeTargets.Class | System.AttributeTargets.All, AllowMultiple=true, Inherited=false)]
    public sealed class GeneratorElementProviderAttribute : JetBrains.ProjectModel.SolutionComponentAttribute
    {
        public GeneratorElementProviderAttribute(string kind) { }
        public GeneratorElementProviderAttribute(string kind, System.Type languageType) { }
        public GeneratorElementProviderAttribute(string kind, System.Type languageType, System.Type projectFileType) { }
        public string Kind { get; set; }
        public System.Type LanguageType { get; set; }
        public System.Type ProjectFileType { get; set; }
    }
    public abstract class GeneratorEqualityBuilderBase<TGeneratorContext> : JetBrains.ReSharper.Feature.Services.Generate.GeneratorBuilderBase<TGeneratorContext>
        where TGeneratorContext :  class, JetBrains.ReSharper.Feature.Services.Generate.IGeneratorContext
    {
        protected const string CanBeNullOption = "CanBeNull";
        protected const string StringComparisonOption = "StringComparison";
        protected const string StringIgnoreCaseOption = "StringIgnoreCase";
        [JetBrains.Annotations.PureAttribute()]
        protected abstract JetBrains.ReSharper.Psi.ITypeElement GetContainingType(TGeneratorContext context);
        protected System.Collections.Generic.List<JetBrains.ReSharper.Feature.Services.Generate.GeneratorEqualityMember> GetEqualityMembers(TGeneratorContext context) { }
        protected override System.Collections.Generic.IList<JetBrains.ReSharper.Feature.Services.Generate.IGeneratorOption> GetGlobalOptions(TGeneratorContext context) { }
        protected override System.Collections.Generic.IList<JetBrains.ReSharper.Feature.Services.Generate.IGeneratorOption> GetInputElementOptions(JetBrains.ReSharper.Feature.Services.Generate.IGeneratorElement inputElement, TGeneratorContext context) { }
        protected override bool HasProcessableElements(TGeneratorContext context, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.Generate.IGeneratorElement> elements) { }
    }
    public abstract class GeneratorEqualityComparerBuilderBase<TGeneratorContext> : JetBrains.ReSharper.Feature.Services.Generate.GeneratorEqualityBuilderBase<TGeneratorContext>
        where TGeneratorContext :  class, JetBrains.ReSharper.Feature.Services.Generate.IGeneratorContext
    {
        protected const string ComparerNamePrefixOption = "ComparerNamePrefix";
        protected const string ExposeViaPropertyOption = "ExposeViaProperty";
        protected override System.Collections.Generic.IList<JetBrains.ReSharper.Feature.Services.Generate.IGeneratorOption> GetGlobalOptions(TGeneratorContext context) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        protected static JetBrains.ReSharper.Psi.IDeclaredType GetIEqualityComparerType([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IType elementType, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Modules.IPsiModule module, JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext context) { }
        protected static string RenderNames(JetBrains.ReSharper.Feature.Services.Generate.IGeneratorContext context, bool bakeProperty, JetBrains.ReSharper.Psi.IDeclaredElement containingType, System.Collections.Generic.List<JetBrains.ReSharper.Feature.Services.Generate.GeneratorEqualityMember> members, out string fieldName, out string propertyName) { }
    }
    public sealed class GeneratorEqualityMember
    {
        public GeneratorEqualityMember([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.ITypeOwner member, bool canBeNull, string stringComparison) { }
        public bool CanBeNull { get; }
        public string StringComparison { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ReSharper.Psi.ITypeOwner TypeMember { get; }
    }
    public abstract class GeneratorEqualityMembersBuilderBase<TGeneratorContext> : JetBrains.ReSharper.Feature.Services.Generate.GeneratorEqualityBuilderBase<TGeneratorContext>
        where TGeneratorContext :  class, JetBrains.ReSharper.Feature.Services.Generate.IGeneratorContext
    {
        protected const string ChangeEqualsOption = "ChangeEquals";
        protected const string ChangeGetHashCodeOption = "ChangeGetHashCode";
        protected const string EqualityOperatorsOption = "EqualityOperators";
        protected const string ImplementIEquatableOption = "ImplementIEquatable";
        protected const string RegionName = "Equality members";
        protected const string TypeEqualityCheck = "TypeEqualityCheck";
        [JetBrains.Annotations.CanBeNullAttribute()]
        protected virtual JetBrains.ReSharper.Psi.IOperator FindEqualityOperator([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.ITypeElement type) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        protected virtual JetBrains.ReSharper.Psi.IOverridableMember FindGetHashCode([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.ITypeElement type, bool includeBaseTypes = False) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        protected virtual JetBrains.ReSharper.Psi.IOperator FindInequalityOperator(JetBrains.ReSharper.Psi.ITypeElement type) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        protected virtual JetBrains.ReSharper.Psi.IOverridableMember FindObjectEquals([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.ITypeElement type, bool includeBaseTypes = False) { }
        protected virtual JetBrains.ReSharper.Psi.IOverridableMember FindTypedEquals(JetBrains.ReSharper.Psi.ITypeElement type) { }
        protected static JetBrains.ReSharper.Psi.ITypeElement GetEquatableInterface(JetBrains.ReSharper.Psi.ITypeElement type) { }
        protected override System.Collections.Generic.IList<JetBrains.ReSharper.Feature.Services.Generate.IGeneratorOption> GetGlobalOptions(TGeneratorContext context) { }
        protected bool HasEquatable(JetBrains.ReSharper.Psi.ITypeElement type) { }
        protected override bool IsAvaliable(TGeneratorContext context) { }
        protected static int ParseTypeCheckMode([JetBrains.Annotations.CanBeNullAttribute()] string value) { }
    }
    public class GeneratorEventElement : JetBrains.ReSharper.Feature.Services.Generate.GeneratorDeclaredElement<JetBrains.ReSharper.Psi.IEvent>
    {
        public GeneratorEventElement([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IEvent declaredElement) { }
        public GeneratorEventElement([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IEvent declaredElement, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution) { }
        public GeneratorEventElement([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IEvent declaredElement, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution, object groupElement) { }
        public JetBrains.ReSharper.Psi.IField Field { get; }
        public string HandlerName { get; set; }
        public override string TestDescriptor { get; }
    }
    public class GeneratorEventHandlerElement : JetBrains.ReSharper.Feature.Services.Generate.GeneratorDeclarationElement
    {
        public GeneratorEventHandlerElement([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Feature.Services.Generate.GeneratorDeclaredElement handledEvent, JetBrains.ReSharper.Psi.Tree.IDeclaration declaration) { }
        public JetBrains.ReSharper.Feature.Services.Generate.GeneratorDeclaredElement HandledEvent { get; }
    }
    public abstract class GeneratorEventsProviderBase<TGeneratorContext> : JetBrains.ReSharper.Feature.Services.Generate.GeneratorProviderBase<TGeneratorContext>
        where TGeneratorContext :  class, JetBrains.ReSharper.Feature.Services.Generate.IGeneratorContext
    {
        protected virtual System.Collections.Generic.List<JetBrains.ReSharper.Psi.DeclaredElementInstance<JetBrains.ReSharper.Psi.IEvent>> CollectInstanceEvents(JetBrains.ReSharper.Psi.ITypeElement typeElement, JetBrains.ReSharper.Psi.Resolve.IAccessContext accessContext, JetBrains.ReSharper.Psi.Modules.IPsiModule module, JetBrains.ReSharper.Psi.PsiLanguageType codeBehindLanguage) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class GeneratorManager
    {
        public GeneratorManager(JetBrains.DataFlow.Lifetime lifetime, JetBrains.DataFlow.IViewable<JetBrains.ReSharper.Feature.Services.Generate.IGeneratorBuilder> builders, JetBrains.DataFlow.IViewable<JetBrains.ReSharper.Feature.Services.Generate.IGeneratorElementProvider> providers) { }
        public JetBrains.ReSharper.Feature.Services.Generate.IGeneratorContext CreateContext(string kind, JetBrains.Application.DataContext.IDataContext context) { }
        public JetBrains.ReSharper.Feature.Services.Generate.IGeneratorContext CreateContext(string kind, JetBrains.ReSharper.Psi.PsiLanguageType languageType, JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        public JetBrains.ReSharper.Feature.Services.Generate.IGeneratorContext CreateContext(string kind, JetBrains.ReSharper.Psi.Tree.ITypeDeclaration declaration, JetBrains.ReSharper.Psi.Tree.ITreeNode anchor) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public System.Collections.Generic.IList<JetBrains.ReSharper.Feature.Services.Generate.IGeneratorBuilder> GetBuilders([JetBrains.Annotations.NotNullAttribute()] string kind, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.PsiLanguageType languageType, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ProjectModel.ProjectFileType projectFileType) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public System.Collections.Generic.IList<JetBrains.ReSharper.Feature.Services.Generate.IGeneratorElementProvider> GetElementProviders([JetBrains.Annotations.NotNullAttribute()] string kind, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.PsiLanguageType languageType, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ProjectModel.ProjectFileType projectFileType) { }
        public static JetBrains.ReSharper.Feature.Services.Generate.GeneratorManager GetInstance(JetBrains.ProjectModel.ISolution solution) { }
        public JetBrains.ReSharper.Psi.PsiLanguageType GetPsiLanguageFromContext(JetBrains.Application.DataContext.IDataContext context) { }
    }
    public abstract class GeneratorOptionBase
    {
        protected GeneratorOptionBase(string id, string title) { }
        public bool HasDependentOptions { get; set; }
        public string ID { get; }
        public bool OverridesGlobalOption { get; set; }
        public bool Persist { get; set; }
        public string Title { get; }
    }
    public class GeneratorOptionBoolean : JetBrains.ReSharper.Feature.Services.Generate.GeneratorOptionBase, JetBrains.ReSharper.Feature.Services.Generate.IGeneratorOption
    {
        public GeneratorOptionBoolean(string id, string title, bool value) { }
        public JetBrains.ReSharper.Feature.Services.Generate.GeneratorOptionKind Kind { get; }
        public string Value { get; set; }
        public System.Collections.Generic.IList<string> GetPossibleValues() { }
        public bool IsValidValue(string value) { }
    }
    public enum GeneratorOptionKind
    {
        Boolean = 0,
        Selector = 1,
        Text = 2,
    }
    public class GeneratorOptionSelector : JetBrains.ReSharper.Feature.Services.Generate.GeneratorOptionBase, JetBrains.ReSharper.Feature.Services.Generate.IGeneratorOption
    {
        public GeneratorOptionSelector(string id, string title, string value, System.Collections.Generic.IList<string> values) { }
        public JetBrains.ReSharper.Feature.Services.Generate.GeneratorOptionKind Kind { get; }
        public string Value { get; set; }
        public System.Collections.Generic.IList<string> GetPossibleValues() { }
        public bool IsValidValue(string value) { }
    }
    public class GeneratorOptionSelectorFromSettings<TEnum> : JetBrains.ReSharper.Feature.Services.Generate.GeneratorOptionBase, JetBrains.ReSharper.Feature.Services.Generate.IGeneratorOption, JetBrains.ReSharper.Feature.Services.Generate.IGeneratorOptionFromSettings
        where TEnum :  struct
    {
        public GeneratorOptionSelectorFromSettings([JetBrains.Annotations.NotNullAttribute()] string id, [JetBrains.Annotations.NotNullAttribute()] string title, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.SettingsScalarEntry settingsEntry, [JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.Dictionary<TEnum, string> labels) { }
        public JetBrains.ReSharper.Feature.Services.Generate.GeneratorOptionKind Kind { get; }
        public string Value { get; set; }
        public System.Collections.Generic.IList<string> GetPossibleValues() { }
        public bool IsValidValue(string value) { }
        public void LoadOption(JetBrains.Application.Settings.IContextBoundSettingsStore store) { }
        public void SaveOption(JetBrains.Application.Settings.IContextBoundSettingsStore store) { }
    }
    public class GeneratorOptionText : JetBrains.ReSharper.Feature.Services.Generate.GeneratorOptionBase, JetBrains.ReSharper.Feature.Services.Generate.IGeneratorOption
    {
        public GeneratorOptionText(string id, string title, string value) { }
        public JetBrains.ReSharper.Feature.Services.Generate.GeneratorOptionKind Kind { get; }
        public string Value { get; set; }
        public System.Collections.Generic.IList<string> GetPossibleValues() { }
        public bool IsValidValue(string value) { }
    }
    public class GeneratorOverrideDeclarationElement : JetBrains.ReSharper.Feature.Services.Generate.GeneratorDeclarationElement
    {
        public GeneratorOverrideDeclarationElement(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration, JetBrains.ReSharper.Feature.Services.Generate.GeneratorDeclaredElement<JetBrains.ReSharper.Psi.IOverridableMember> inheritedElement) { }
        public JetBrains.ReSharper.Feature.Services.Generate.GeneratorDeclaredElement<JetBrains.ReSharper.Psi.IOverridableMember> InheritedElement { get; }
    }
    public class GeneratorPropertyDeclarationElement : JetBrains.ReSharper.Feature.Services.Generate.GeneratorDeclarationElement
    {
        public GeneratorPropertyDeclarationElement(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration, JetBrains.ReSharper.Feature.Services.Generate.GeneratorDeclaredElement<JetBrains.ReSharper.Psi.IField> field) { }
        public JetBrains.ReSharper.Feature.Services.Generate.GeneratorDeclaredElement<JetBrains.ReSharper.Psi.IField> Field { get; set; }
    }
    public abstract class GeneratorProviderBase<TGeneratorContext> : JetBrains.ReSharper.Feature.Services.Generate.IGeneratorElementProvider
        where TGeneratorContext :  class, JetBrains.ReSharper.Feature.Services.Generate.IGeneratorContext
    {
        public abstract double Priority { get; }
        public void Populate(JetBrains.ReSharper.Feature.Services.Generate.IGeneratorContext context) { }
        public abstract void Populate(TGeneratorContext context);
    }
    public class GeneratorQualifiedAccessContext : JetBrains.ReSharper.Psi.Resolve.IAccessContext
    {
        public GeneratorQualifiedAccessContext(JetBrains.ReSharper.Psi.ITypeElement accessPoint, JetBrains.ReSharper.Psi.ITypeOwner qualifier) { }
        public JetBrains.ReSharper.Psi.ITypeElement GetAccessContainingTypeElement() { }
        public JetBrains.ReSharper.Psi.Modules.IPsiModule GetPsiModule() { }
        public JetBrains.ReSharper.Psi.Resolve.QualifierKind GetQualifierKind() { }
        public JetBrains.ReSharper.Psi.ITypeElement GetQualifierTypeElement() { }
        public JetBrains.ReSharper.Psi.Resolve.Staticness GetStaticness() { }
    }
    [JetBrains.Application.Configuration.Upgrade.GlobalSettingsUpgraderAttribute()]
    public class GeneratorSettingsUpgrader : JetBrains.Application.Configuration.SettingTablesUpgrader
    {
        public GeneratorSettingsUpgrader(JetBrains.Application.Env.RunsProducts.ProductConfigurations productConfigurations) { }
        protected override void DoUpgrade(JetBrains.Application.Configuration.IComponentSettingsProvider legacySettingsProvider, JetBrains.Application.Settings.IContextBoundSettingsStore boundSettingsStore, JetBrains.DataFlow.Lifetime upgradeLifetime, JetBrains.Application.Configuration.SettingsTableBase workspaceSettingsTable, JetBrains.Application.Configuration.SettingsTableBase globalSettingsTable) { }
        public static JetBrains.Util.Pair<string, string> ParseIndexerAndOptionName(string fullSettingName) { }
        public static string ParseIndexerName(string fullSettingName, string tail) { }
    }
    public class static GeneratorStandardKinds
    {
        public const string Constructor = "Constructor";
        public const string Delegating = "Delegating";
        public const string EqualityComparer = "EqualityComparer";
        public const string EqualityMembers = "EqualityMembers";
        public const string EventSubscriptions = "EventSubscriptions";
        public const string Formatting = "Formatting";
        public const string Implementations = "Implementations";
        public const string Overrides = "Overrides";
        public const string PartialMethods = "PartialMethods";
        public const string Properties = "Properties";
        public const string ReadProperties = "ReadProperties";
    }
    public class static GeneratorWorkflowFactory
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Feature.Services.Generate.IGeneratorWorkflow CreateWorkflow(string kind, JetBrains.Application.DataContext.IDataContext dataContext) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Feature.Services.Generate.IGeneratorWorkflow CreateWorkflow(string kind, JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl, JetBrains.ReSharper.Psi.PsiLanguageType languageType) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Feature.Services.Generate.IGeneratorWorkflow CreateWorkflowWithoutTextControl(string kind, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITypeDeclaration declaration, JetBrains.ReSharper.Psi.Tree.ITreeNode anchor) { }
    }
    public interface IGeneratorBuilder : JetBrains.ReSharper.Feature.Services.Generate.IGeneratorOptionsProvider
    {
        double Priority { get; }
        bool HasProcessableElements(JetBrains.ReSharper.Feature.Services.Generate.IGeneratorContext context, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.Generate.IGeneratorElement> elements);
        bool IsAvaliable(JetBrains.ReSharper.Feature.Services.Generate.IGeneratorContext context);
        void Process(JetBrains.ReSharper.Feature.Services.Generate.IGeneratorContext context);
    }
    public interface IGeneratorContext : System.IDisposable
    {
        JetBrains.ReSharper.Psi.Tree.ITreeNode Anchor { get; set; }
        System.Collections.Generic.IList<JetBrains.ReSharper.Feature.Services.Generate.IGeneratorOption> GlobalOptions { get; }
        JetBrains.Util.OneToListMap<JetBrains.ReSharper.Feature.Services.Generate.IGeneratorElement, JetBrains.ReSharper.Feature.Services.Generate.IGeneratorOption> InputElementOptions { get; }
        System.Collections.Generic.IList<JetBrains.ReSharper.Feature.Services.Generate.IGeneratorElement> InputElements { get; }
        string Kind { get; }
        JetBrains.ReSharper.Psi.PsiLanguageType Language { get; }
        JetBrains.Util.OneToListMap<JetBrains.ReSharper.Feature.Services.Generate.IGeneratorElement, JetBrains.ReSharper.Feature.Services.Generate.IGeneratorOption> OutputElementOptions { get; }
        System.Collections.Generic.IList<JetBrains.ReSharper.Feature.Services.Generate.IGeneratorElement> OutputElements { get; }
        JetBrains.ReSharper.Psi.PsiLanguageType PresentationLanguage { get; }
        JetBrains.ProjectModel.IProject Project { get; }
        JetBrains.ProjectModel.ProjectFileType ProjectFileType { get; }
        System.Collections.Generic.IList<JetBrains.ReSharper.Feature.Services.Generate.IGeneratorElement> ProvidedElements { get; }
        JetBrains.ReSharper.Psi.Modules.IPsiModule PsiModule { get; }
        JetBrains.ReSharper.Psi.Tree.ITreeNode Root { get; }
        string GetElementOptionValue(JetBrains.ReSharper.Feature.Services.Generate.IGeneratorElement element, string id);
        string GetGlobalOptionValue(string id);
        JetBrains.ReSharper.Psi.TreeTextRange GetSelectionTreeRange();
        void SetElementOptionValue(JetBrains.ReSharper.Feature.Services.Generate.IGeneratorElement element, string id, string value);
        void SetGlobalOptionValue(string id, string value);
    }
    public interface IGeneratorContextFactory
    {
        JetBrains.ReSharper.Feature.Services.Generate.IGeneratorContext Create(string kind, JetBrains.Application.DataContext.IDataContext context);
        JetBrains.ReSharper.Feature.Services.Generate.IGeneratorContext Create(string kind, JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl);
        JetBrains.ReSharper.Feature.Services.Generate.IGeneratorContext Create(string kind, JetBrains.ReSharper.Psi.Tree.ITypeDeclaration declaration, JetBrains.ReSharper.Psi.Tree.ITreeNode anchor);
    }
    public interface IGeneratorElement
    {
        bool Emphasize { get; }
        string TestDescriptor { get; }
        object GetGroupingObject();
        object GetPresentationObject();
        bool Matches(string searchText, JetBrains.Text.IdentifierMatcher matcher);
    }
    public interface IGeneratorElementPresenter
    {
        void InitGeneratorPresenter(JetBrains.UI.TreeView.StructuredPresenter<JetBrains.TreeModels.TreeModelNode, JetBrains.CommonControls.IPresentableItem> presenter);
    }
    public interface IGeneratorElementProvider
    {
        double Priority { get; }
        void Populate(JetBrains.ReSharper.Feature.Services.Generate.IGeneratorContext context);
    }
    public interface IGeneratorOption
    {
        bool HasDependentOptions { get; }
        string ID { get; }
        JetBrains.ReSharper.Feature.Services.Generate.GeneratorOptionKind Kind { get; }
        bool OverridesGlobalOption { get; set; }
        bool Persist { get; }
        string Title { get; }
        string Value { get; set; }
        System.Collections.Generic.IList<string> GetPossibleValues();
        bool IsValidValue(string value);
    }
    public interface IGeneratorOptionFromSettings : JetBrains.ReSharper.Feature.Services.Generate.IGeneratorOption
    {
        void LoadOption(JetBrains.Application.Settings.IContextBoundSettingsStore store);
        void SaveOption(JetBrains.Application.Settings.IContextBoundSettingsStore store);
    }
    public interface IGeneratorOptionsProvider
    {
        System.Collections.Generic.IList<JetBrains.ReSharper.Feature.Services.Generate.IGeneratorOption> GetGlobalOptions(JetBrains.ReSharper.Feature.Services.Generate.IGeneratorContext context);
        System.Collections.Generic.IList<JetBrains.ReSharper.Feature.Services.Generate.IGeneratorOption> GetInputElementOptions(JetBrains.ReSharper.Feature.Services.Generate.IGeneratorElement inputElement, JetBrains.ReSharper.Feature.Services.Generate.IGeneratorContext context);
        System.Collections.Generic.IList<JetBrains.ReSharper.Feature.Services.Generate.IGeneratorOption> GetOutputElementOptions(JetBrains.ReSharper.Feature.Services.Generate.IGeneratorElement outputElement, JetBrains.ReSharper.Feature.Services.Generate.IGeneratorContext context);
    }
    public interface IGeneratorWorkflow : System.IDisposable
    {
        JetBrains.ReSharper.Feature.Services.Generate.IGeneratorContext Context { get; }
        void BuildInputOptions();
        void Finish(string commandName);
        System.IDisposable Generate(JetBrains.Application.Progress.IProgressIndicator progressIndicator);
        void GenerateAndFinish(string commandName, JetBrains.Application.Progress.IProgressIndicator progressIndicator);
        bool HasBuildableInputElements();
        void RollbackGenerate();
    }
    public interface IMemberBodyOperations
    {
        JetBrains.Util.TextRange GetBodyRange(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration);
        void RemoveBody(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration);
        JetBrains.Util.TextRange SetBody(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration, JetBrains.ReSharper.Psi.GenerateMemberBody.MethodImplementationKind implementationKind);
        JetBrains.Util.TextRange SetBodyToDefault(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration);
        JetBrains.Util.TextRange SetDelegatingCall(JetBrains.ReSharper.Psi.Tree.ITypeMemberDeclaration declaration, JetBrains.ReSharper.Psi.IClrDeclaredElement qualifier, JetBrains.ReSharper.Psi.IOverridableMember delegateTo);
        JetBrains.Util.TextRange SetParameterlessMethodCall(JetBrains.ReSharper.Psi.Tree.ITypeMemberDeclaration declaration, JetBrains.ReSharper.Psi.IMethod methodToCall);
    }
    public class static InheritanceAnalyzer
    {
        public static System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.OverridableMemberInstance> GetMissingMembers(JetBrains.ReSharper.Psi.ITypeElement typeElement) { }
        public static System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.OverridableMemberInstance> GetOverridableMembers(JetBrains.ReSharper.Psi.ITypeElement typeElement) { }
        public interface IInheritanceAnalyzer
        {
            System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.OverridableMemberInstance> IInheritanceAnalyzer_GetMissingMembers(JetBrains.ReSharper.Psi.Tree.ITypeDeclaration typeDeclaration);
            System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.OverridableMemberInstance> IInheritanceAnalyzer_GetOverridableMembers(JetBrains.ReSharper.Psi.Tree.ITypeDeclaration typeDeclaration);
        }
    }
    public class static MemberBodyUtil
    {
        public static JetBrains.Util.TextRange GetBodyTextRange([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITypeMemberDeclaration declaration) { }
        public static JetBrains.Util.TextRange MakeBodyCallMethod(JetBrains.ReSharper.Psi.Tree.ITypeMemberDeclaration declaration, JetBrains.ReSharper.Psi.IMethod methodToCall) { }
        public static JetBrains.Util.TextRange SetBodyToDefault(JetBrains.ReSharper.Psi.Tree.ITypeMemberDeclaration declaration) { }
        public static JetBrains.Util.TextRange SetBodyToDefault(JetBrains.ReSharper.Psi.Tree.IFunctionDeclaration declaration) { }
    }
    public class static NotifyPropertyChangedUtil
    {
        public static System.Collections.Generic.IList<JetBrains.ReSharper.Psi.IProperty> FindDependentProperties([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.ITypeElement containingType, [JetBrains.Annotations.NotNullAttribute()] params JetBrains.ReSharper.Psi.ITypeMember[] propertyOrFields) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Psi.IMethod GetNotifierByPresentation([JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IMethod> notifiers, [JetBrains.Annotations.NotNullAttribute()] string format, [JetBrains.Annotations.NotNullAttribute()] string presentation, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.PsiLanguageType language) { }
        public static System.Collections.Generic.IList<JetBrains.ReSharper.Psi.IMethod> GetNotifyMethods([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IClass classType, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Modules.IPsiModule module, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.ITypeConversionRule rule) { }
        public static string PresentNotifier([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IMethod method, [JetBrains.Annotations.NotNullAttribute()] string format, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.PsiLanguageType language) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Collections.Generic.List<string> PresentNotifiersNames([JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IMethod> notifiers, [JetBrains.Annotations.NotNullAttribute()] string format, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.PsiLanguageType language) { }
        public static bool RequiresEqualityCheck([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IMethod method) { }
        public static JetBrains.ReSharper.Feature.Services.Generate.NotifyPropertyChangedUtil.NotifyMethodType ValidateNotifierSignature([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IMethod method) { }
        public enum NotifyMethodType
        {
            NotNotifier = 0,
            StringBasedNotifier = 1,
            LambdaBasedNotifier = 2,
            LambdaWithParameterNotifier = 3,
            SetFieldNotifier = 4,
        }
    }
}
namespace JetBrains.ReSharper.Feature.Services.Hyperlink
{
    
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class HyperlinkManager
    {
        public HyperlinkManager(JetBrains.ReSharper.Psi.IPsiServices services, JetBrains.DataFlow.Lifetime lifetime, JetBrains.ProjectModel.ISolution solution, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.Hyperlink.IHyperlinkProvider> providers, JetBrains.TextControl.ITextControlManager textman, JetBrains.ActionManagement.IActionManager actionManager, JetBrains.Application.IShellLocks locks, JetBrains.Application.Settings.ISettingsStore settingsStore) { }
    }
    [JetBrains.Annotations.MeansImplicitUseAttribute()]
    [System.AttributeUsageAttribute(System.AttributeTargets.Class | System.AttributeTargets.All)]
    public class HyperlinkProviderAttribute : JetBrains.ProjectModel.SolutionComponentAttribute { }
    public interface IHyperlink
    {
        JetBrains.TextControl.DocumentMarkup.IHighlighter CreateHighlighter(JetBrains.TextControl.ITextControl textControl);
        void Navigate(JetBrains.Application.DataContext.IDataContext dataContext);
    }
    public interface IHyperlinkProvider
    {
        System.Windows.Forms.MouseButtons ActivationMouseButtons { get; }
        System.Windows.Forms.Keys ModifierKeys { get; }
        JetBrains.ReSharper.Feature.Services.Hyperlink.IHyperlink CreateHyperlink(JetBrains.Application.DataContext.IDataContext context);
    }
}
namespace JetBrains.ReSharper.Feature.Services.Intentions
{
    
    public struct AttributeArguments
    {
        public JetBrains.ReSharper.Psi.AttributeValue[] FixedArguments { get; set; }
        public JetBrains.Util.Pair<, >[] NamedArguments { get; set; }
    }
    public interface IAnnotateWithAttributeIntention
    {
        void Annotate([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.IDeclaration declaration, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.ITypeElement markBy, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.AttributeValue[] fixedArguments, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.Pair<, >[] namedArguments);
        bool HasAnnotation([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.IDeclaration declaration, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.ITypeElement markBy);
        void UpdateAnnotations([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.IDeclaration markedDeclaration, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Feature.Services.Intentions.UpdateArgumentsDelegate provideArguments);
    }
    public interface IChangeBaseTypeRequiredIntention
    {
        System.Action<JetBrains.TextControl.ITextControl> Execute([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IClass classToProcess, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IDeclaredType fromType, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IDeclaredType toType);
    }
    public interface IChangeSignatureIntention
    {
        void ChangeSignature(JetBrains.ReSharper.Psi.Tree.IParametersOwnerDeclaration signatureToChange, JetBrains.ReSharper.Psi.IParametersOwner sourcePattern, JetBrains.ReSharper.Psi.Resolve.ISubstitution sourceSubstitution, JetBrains.ReSharper.Feature.Services.Intentions.SignatureChangeKind changeKind);
    }
    public class IntentionResult
    {
        public IntentionResult([JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IList<JetBrains.ReSharper.Feature.Services.Intentions.Impl.TemplateFieldHolders.ITemplateFieldHolder> holders, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITypeMemberDeclaration resultDeclaration, JetBrains.Util.TextRange prefferedSelection) { }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Feature.Services.Intentions.Impl.TemplateFieldHolders.ITemplateFieldHolder> Holders { get; }
        public JetBrains.DocumentModel.DocumentRange PrefferedSelection { get; }
        public JetBrains.ReSharper.Psi.Tree.ITypeMemberDeclaration ResultDeclaration { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ReSharper.Feature.Services.Intentions.IntentionResult WithPrefferedSelection(JetBrains.Util.TextRange prefferedSelection) { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class IntentionResultBehavior
    {
        public IntentionResultBehavior(JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.HotspotSessionExecutor hotspotSessionExecutor) { }
        protected JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.HotspotSessionExecutor HotspotSessionExecutor { get; }
        public void OnHotspotSessionExecutionStarted(JetBrains.ReSharper.Feature.Services.Intentions.IntentionResult result, JetBrains.TextControl.ITextControl textControl) { }
        protected virtual void OnHotspotSessionExecutionStartedInternal(JetBrains.ReSharper.Feature.Services.Intentions.IntentionResult result, JetBrains.TextControl.ITextControl textControl) { }
        protected static void SetCaretPosition(JetBrains.TextControl.ITextControl textControl, JetBrains.ReSharper.Feature.Services.Intentions.IntentionResult result) { }
    }
    public class static IntentionResultExtensions
    {
        public static void ExecuteTemplate(this JetBrains.ReSharper.Feature.Services.Intentions.IntentionResult result) { }
    }
    public interface ISetAccessRightsIntention
    {
        void SetAccessRights(JetBrains.ReSharper.Psi.Tree.IAccessRightsOwnerDeclaration declaration, JetBrains.ReSharper.Psi.AccessRights accessRights);
    }
    public enum SignatureChangeKind
    {
        OnlyReturnType = 0,
        WholeSignature = 1,
    }
    public delegate System.Nullable<JetBrains.ReSharper.Feature.Services.Intentions.AttributeArguments> UpdateArgumentsDelegate(JetBrains.ReSharper.Psi.IAttributeInstance instance);
}
namespace JetBrains.ReSharper.Feature.Services.Intentions.CreateDeclaration
{
    
    public class CreateClassDeclarationContext : JetBrains.ReSharper.Feature.Services.Intentions.CreateDeclaration.CreateContextBase
    {
        public JetBrains.ReSharper.Psi.AccessRights AccessRights;
        public JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.SimpleTypeImage BaseType;
        public bool CantBeClass;
        public bool CantBeEnum;
        public bool CantBeInterface;
        public bool CantBeStruct;
        public string ClassName;
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.MemberSignature ConstructorSignature;
        public bool IsInterface;
        public bool IsPartial;
        public bool IsStatic;
        public int TypeArgumentsCount;
    }
    public class CreateConstDeclarationContext : JetBrains.ReSharper.Feature.Services.Intentions.CreateDeclaration.CreateContextBase
    {
        public string FieldName;
        public JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.SimpleTypeImage Type;
    }
    public class CreateConstructorDeclarationContext : JetBrains.ReSharper.Feature.Services.Intentions.CreateDeclaration.CreateContextBase
    {
        public JetBrains.ReSharper.Psi.AccessRights AccessRights;
        public JetBrains.ReSharper.Psi.ITypeElement Class;
        public JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.MemberSignature ConstructorSignature;
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Feature.Services.Intentions.Impl.MemberBodyTemplates.IMemberBodyTemplateFieldHolderFactory MemberBodyTemplateFieldFactory;
    }
    public class CreateContextBase
    {
        public JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.ICreationTarget Target;
    }
    public class CreateDelegateDeclarationContext : JetBrains.ReSharper.Feature.Services.Intentions.CreateDeclaration.CreateContextBase
    {
        public JetBrains.ReSharper.Psi.AccessRights AccessRights;
        public string DelegateName;
        public int TypeArgumentsCount;
        public CreateDelegateDeclarationContext() { }
    }
    public class CreateEnumMemberDeclarationContext : JetBrains.ReSharper.Feature.Services.Intentions.CreateDeclaration.CreateContextBase
    {
        public string EnumMemberName;
    }
    public class CreateEventDeclarationContext : JetBrains.ReSharper.Feature.Services.Intentions.CreateDeclaration.CreateContextBase
    {
        public JetBrains.ReSharper.Psi.AccessRights AccessRights;
        public string EventName;
        public JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.ITypeImage EventType;
        public bool IsStatic;
    }
    public class CreateFieldDeclarationContext : JetBrains.ReSharper.Feature.Services.Intentions.CreateDeclaration.CreateContextBase
    {
        public JetBrains.ReSharper.Psi.AccessRights AccessRights;
        public string FieldName;
        public bool IsStatic;
        public JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.SimpleTypeImage Type;
    }
    public class CreateMethodDeclarationContext : JetBrains.ReSharper.Feature.Services.Intentions.CreateDeclaration.CreateContextBase
    {
        public JetBrains.ReSharper.Psi.AccessRights AccessRights;
        public bool ExecuteTemplateOverMemberBody;
        public bool ExecuteTemplateOverName;
        public bool ExecuteTemplateOverParameters;
        public bool ExecuteTemplateOverReturnType;
        public bool IsAbstract;
        public bool IsStatic;
        public string MethodName;
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.MemberSignature> MethodSignatures;
        public JetBrains.ReSharper.Psi.Resolve.IReference SourceReferenceExpressionReference;
        public System.Collections.Generic.IList<JetBrains.ReSharper.Psi.IType> TypeArguments;
        public CreateMethodDeclarationContext() { }
    }
    public class CreatePropertyDeclarationContext : JetBrains.ReSharper.Feature.Services.Intentions.CreateDeclaration.CreateContextBase
    {
        public JetBrains.ReSharper.Psi.AccessRights AccessRights;
        public JetBrains.ReSharper.Psi.GenerateMemberBody.AccessorImplementationKind AccessrorImplementationKind;
        public bool IsStatic;
        public JetBrains.ReSharper.Feature.Services.Intentions.CreateDeclaration.OverridableKind OverridableKind;
        public string PropertyName;
        public JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.MemberSignature PropertySignature;
        public JetBrains.ReSharper.Feature.Services.Intentions.CreateDeclaration.ReadWriteKind ReadWriteKind;
    }
    public interface ICreateConstDeclarationIntention
    {
        JetBrains.ReSharper.Feature.Services.Intentions.IntentionResult ExecuteEx(JetBrains.ReSharper.Feature.Services.Intentions.CreateDeclaration.CreateConstDeclarationContext context);
    }
    public interface ICreateNameSpaceDeclarationIntention
    {
        JetBrains.ReSharper.Psi.Tree.ITypeAndNamespaceHolderDeclaration CreateOrFindNameSpace(JetBrains.ReSharper.Psi.Tree.IFile file, string nameSpaceName);
    }
    public interface ICreateTypeParameterDeclarationIntention
    {
        void ExecuteEx(JetBrains.ReSharper.Psi.ITypeParametersOwner destination, string newTypeParamName);
    }
    public enum OverridableKind
    {
        REGULAR = 0,
        ABSTRACT = 1,
        VIRTUAL = 2,
        OVERRIDE = 3,
    }
    public enum ReadWriteKind
    {
        READ_WRITE = 0,
        READ_ONLY = 1,
        WRITE_ONLY = 2,
    }
}
namespace JetBrains.ReSharper.Feature.Services.Intentions.DataProviders
{
    
    public class ComplexTypeImage : JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.ITypeImage
    {
        public ComplexTypeImage(JetBrains.ReSharper.Psi.IDeclaredType parentType, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.ITypeImage> childTypes) { }
        public System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.ITypeImage> ChildTypes { get; }
        public JetBrains.ReSharper.Psi.IDeclaredType ParentType { get; }
    }
    public class CreateNewFileTarget : JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.ICreateNewFileTarget, JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.ICreationTarget, JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.ITargetPostExecute, JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.ITargetPreExecute, JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.ITopLevelScopeTarget
    {
        public CreateNewFileTarget(JetBrains.ReSharper.Psi.Tree.ITreeNode anchor, JetBrains.ProjectModel.IProjectFolder targetFolder, JetBrains.Util.FileSystemPath targetPath, string targetNamespaceName, string fileName, JetBrains.ProjectModel.ProjectFileType fileType, JetBrains.ReSharper.Psi.Resolve.IReference referenceToBind) { }
        public JetBrains.ReSharper.Psi.Tree.ITreeNode Anchor { get; }
        public string FileName { get; }
        public JetBrains.ProjectModel.ProjectFileType FileType { get; }
        public JetBrains.ReSharper.Psi.Resolve.IReference ReferenceToBind { get; }
        public JetBrains.ProjectModel.IProjectFolder TargetFolder { get; }
        public JetBrains.ReSharper.Psi.PsiLanguageType TargetLanguage { get; }
        public string TargetNamespaceName { get; }
        public JetBrains.Util.FileSystemPath TargetPath { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Tree.ITreeNode> GetPossibleTargetDeclarations() { }
        public JetBrains.ReSharper.Psi.Tree.ITreeNode GetTargetDeclaration() { }
        public JetBrains.ReSharper.Psi.Tree.IFile GetTargetDeclarationFile() { }
        public JetBrains.ProjectModel.IProject GetTargetProject() { }
        public void PostExecute(JetBrains.ReSharper.Psi.IDeclaredElement creationResult) { }
        public void PreExecute() { }
    }
    public class FileTarget : JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.TopLevelTargetBase, JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.ICreationTarget, JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.IFileTarget, JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.ITopLevelScopeTarget
    {
        public FileTarget([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.IFile targetFile, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode anchor = null) { }
        public JetBrains.ReSharper.Psi.Tree.ITreeNode GetTargetDeclaration() { }
    }
    public interface ITypeImage { }
    public class MemberSignature
    {
        public MemberSignature([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.ITypeImage returnType, [JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.ParameterInfoBase> parameters) { }
        public MemberSignature([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.ITypeImage returnType, [JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.ParameterInfoBase> parameters, JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.ParameterInfoBase thisParameter) { }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.ParameterInfoBase> Parameters { get; set; }
        public JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.ITypeImage ReturnType { get; set; }
        public JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.ParameterInfoBase ThisParameter { get; set; }
    }
    public class MemberSignatureProvider
    {
        public MemberSignatureProvider(JetBrains.ReSharper.Psi.IPsiServices psiServices, JetBrains.ReSharper.Psi.PsiLanguageType language) { }
        public JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.MemberSignature CreateFromDelegate([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IDelegate @delegate, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution, JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
        public JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.MemberSignature CreateFromMethod([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IMethod method, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution, JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
        public JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.ParameterInfoBase CreateFromParameter([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IParameter paramer, JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
        public JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.MemberSignature CreateFromTypes([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.IType returnType, [JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IEnumerable<JetBrains.Util.Pair<JetBrains.ReSharper.Psi.IType, string>> parameterTypes, JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
        public JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.MemberSignature CreateFromTypes([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.IType returnType, [JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IType> parameterTypes, JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
    }
    public class NamedParameterInfo : JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.ParameterInfoBase
    {
        public NamedParameterInfo([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.ITypeImage type, JetBrains.ReSharper.Psi.ParameterKind parameterKind, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Resolve.IReference nameReference) { }
        public JetBrains.ReSharper.Psi.Resolve.IReference NameReference { get; }
    }
    public class NamespaceByNameTarget : JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.TopLevelTargetBase, JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.ICreationTarget, JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.INamespaceByNameTarget, JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.ITargetPreExecute, JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.ITopLevelScopeTarget
    {
        public NamespaceByNameTarget([JetBrains.Annotations.NotNullAttribute()] string targetNamespace, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.IFile targetF, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode anchor = null) { }
        public string TargetNamespaceName { get; }
        public JetBrains.ReSharper.Psi.Tree.ITreeNode GetTargetDeclaration() { }
        public void PreExecute() { }
    }
    public class NamespaceTarget : JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.TopLevelTargetBase, JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.ICreationTarget, JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.INamespaceTarget, JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.ITargetPreExecute, JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.ITopLevelScopeTarget
    {
        public NamespaceTarget([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.INamespace targetNamespace, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.IFile targetFile, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode anchor = null) { }
        public JetBrains.ReSharper.Psi.INamespace TargetNamespace { get; }
        public JetBrains.ReSharper.Psi.Tree.ITreeNode GetTargetDeclaration() { }
        public void PreExecute() { }
    }
    public class NoTypeImage : JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.ITypeImage { }
    public abstract class ParameterInfoBase
    {
        protected ParameterInfoBase([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.ITypeImage type, JetBrains.ReSharper.Psi.ParameterKind parameterKind) { }
        public JetBrains.ReSharper.Psi.ParameterKind ParameterKind { get; }
        public JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.ITypeImage Type { get; }
    }
    public class RegularParameterInfo : JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.ParameterInfoBase
    {
        public RegularParameterInfo([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.ITypeImage type, JetBrains.ReSharper.Psi.ParameterKind parameterKind, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Naming.Extentions.INamesCollection namesCollection) { }
        public RegularParameterInfo([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.ITypeImage type, JetBrains.ReSharper.Psi.ParameterKind parameterKind, JetBrains.ReSharper.Psi.IPsiServices psiServices, JetBrains.ReSharper.Psi.PsiLanguageType language, JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, [JetBrains.Annotations.CanBeNullAttribute()] string proposedName = null) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ReSharper.Psi.Naming.Extentions.INamesCollection NamesCollection { get; }
    }
    public class SimpleTypeImage : JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.ITypeImage
    {
        public SimpleTypeImage([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IType type) { }
        public SimpleTypeImage([JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IType> candidateTypes) { }
        public System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.IType> Candidates { get; }
    }
    public abstract class TopLevelTargetBase
    {
        protected TopLevelTargetBase([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.IFile targetFile, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode anchor = null) { }
        public JetBrains.ReSharper.Psi.Tree.ITreeNode Anchor { get; }
        public JetBrains.ReSharper.Psi.Tree.IFile TargetFile { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Tree.ITreeNode> GetPossibleTargetDeclarations() { }
        public JetBrains.ReSharper.Psi.Tree.IFile GetTargetDeclarationFile() { }
        public JetBrains.ProjectModel.IProject GetTargetProject() { }
    }
    public class TypeDeclarationTarget : JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.ICreationTarget, JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.ITypeDeclarationTarget
    {
        public TypeDeclarationTarget([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITypeDeclaration targetTypeDeclaration, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode anchor = null) { }
        public JetBrains.ReSharper.Psi.Tree.ITreeNode Anchor { get; }
        public JetBrains.ReSharper.Psi.Tree.ITypeDeclaration TargetTypeDeclaration { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Tree.ITreeNode> GetPossibleTargetDeclarations() { }
        public JetBrains.ReSharper.Psi.Tree.ITreeNode GetTargetDeclaration() { }
        public JetBrains.ReSharper.Psi.Tree.IFile GetTargetDeclarationFile() { }
    }
    public class TypeTarget : JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.ICreationTarget, JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.ITargetSetPart, JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.ITypeTarget
    {
        public TypeTarget([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.ITypeElement targetType, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode anchor = null) { }
        public JetBrains.ReSharper.Psi.Tree.ITreeNode Anchor { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Tree.IDeclaration> AvailableTargets { get; }
        public JetBrains.ReSharper.Psi.ITypeElement TargetType { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Tree.ITreeNode> GetPossibleTargetDeclarations() { }
        public JetBrains.ReSharper.Psi.Tree.ITreeNode GetTargetDeclaration() { }
        public JetBrains.ReSharper.Psi.Tree.IFile GetTargetDeclarationFile() { }
        public void SetPart(JetBrains.ReSharper.Psi.Tree.IDeclaration typePart) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.Intentions.Impl.DeclarationBuilders
{
    
    public class static ClassDeclarationBuilder
    {
        public static JetBrains.ReSharper.Feature.Services.Intentions.IntentionResult CreateClass(JetBrains.ReSharper.Feature.Services.Intentions.CreateDeclaration.CreateClassDeclarationContext context) { }
    }
    public class static ConstDeclarationBuilder
    {
        public static JetBrains.ReSharper.Feature.Services.Intentions.IntentionResult Create(JetBrains.ReSharper.Feature.Services.Intentions.CreateDeclaration.CreateConstDeclarationContext context) { }
    }
    public class static ConstructorDeclarationBuilder
    {
        public static JetBrains.ReSharper.Feature.Services.Intentions.IntentionResult Create(JetBrains.ReSharper.Feature.Services.Intentions.CreateDeclaration.CreateConstructorDeclarationContext context) { }
    }
    public class static DelegateDeclarationBuilder
    {
        public static JetBrains.ReSharper.Feature.Services.Intentions.IntentionResult Create(JetBrains.ReSharper.Feature.Services.Intentions.CreateDeclaration.CreateDelegateDeclarationContext context) { }
    }
    public class static EnumMemberDeclarationBuilder
    {
        public static JetBrains.ReSharper.Feature.Services.Intentions.IntentionResult Create(JetBrains.ReSharper.Feature.Services.Intentions.CreateDeclaration.CreateEnumMemberDeclarationContext context) { }
    }
    public class static EventDeclarationBuilder
    {
        public static JetBrains.ReSharper.Feature.Services.Intentions.IntentionResult Create(JetBrains.ReSharper.Feature.Services.Intentions.CreateDeclaration.CreateEventDeclarationContext context) { }
    }
    public class static FieldDeclarationBuilder
    {
        public static JetBrains.ReSharper.Feature.Services.Intentions.IntentionResult Create(JetBrains.ReSharper.Feature.Services.Intentions.CreateDeclaration.CreateFieldDeclarationContext context) { }
    }
    public interface IReverseSubstitution
    {
        JetBrains.ReSharper.Feature.Services.Intentions.Impl.DeclarationBuilders.IReverseSubstitution Extend(JetBrains.ReSharper.Psi.IType sourceType, JetBrains.ReSharper.Psi.ITypeParameter destinationTypeParameter);
        JetBrains.ReSharper.Feature.Services.Intentions.Impl.DeclarationBuilders.IReverseSubstitution Extend(System.Collections.Generic.IDictionary<JetBrains.ReSharper.Psi.IType, JetBrains.ReSharper.Psi.ITypeParameter> dictionary);
        JetBrains.ReSharper.Psi.IType Substitute([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IType sourceType);
        JetBrains.ReSharper.Psi.IType SubstituteDeep([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IType sourceType);
    }
    public class static MethodDeclarationBuilder
    {
        public static JetBrains.ReSharper.Feature.Services.Intentions.IntentionResult Create(JetBrains.ReSharper.Feature.Services.Intentions.CreateDeclaration.CreateMethodDeclarationContext context) { }
    }
    public class static ParametersDeclarationBuilder
    {
        public static void CreateParameters([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.IParametersOwnerDeclaration parametersOwnerDeclaration, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.MemberSignature memberSignature, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Feature.Services.Intentions.Impl.DeclarationBuilders.IReverseSubstitution reverseSubstitution, [JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.List<JetBrains.ReSharper.Feature.Services.Intentions.Impl.TemplateFieldHolders.ITemplateFieldHolder> holders) { }
    }
    public class static PropertyDeclarationBuilder
    {
        public static JetBrains.ReSharper.Feature.Services.Intentions.IntentionResult CreateProperty(JetBrains.ReSharper.Feature.Services.Intentions.CreateDeclaration.CreatePropertyDeclarationContext context) { }
    }
    public class static ReturnTypeBuilder
    {
        public static void CreateReturnType(JetBrains.ReSharper.Psi.Tree.ITypeOwnerDeclaration typeOwnerDeclaration, JetBrains.ReSharper.Feature.Services.Intentions.Impl.DeclarationBuilders.IReverseSubstitution reverseSubstitution, JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.ITypeImage returnTypeImage, System.Collections.Generic.List<JetBrains.ReSharper.Feature.Services.Intentions.Impl.TemplateFieldHolders.ITemplateFieldHolder> holders, bool executeTemplate, bool executeTemplateOverVoid) { }
    }
    public class ReverseSubstitution : JetBrains.ReSharper.Feature.Services.Intentions.Impl.DeclarationBuilders.IReverseSubstitution
    {
        public static readonly JetBrains.ReSharper.Feature.Services.Intentions.Impl.DeclarationBuilders.IReverseSubstitution Empty;
        public JetBrains.ReSharper.Feature.Services.Intentions.Impl.DeclarationBuilders.IReverseSubstitution Extend(JetBrains.ReSharper.Psi.IType sourceType, JetBrains.ReSharper.Psi.ITypeParameter destinationTypeParameter) { }
        public JetBrains.ReSharper.Feature.Services.Intentions.Impl.DeclarationBuilders.IReverseSubstitution Extend(System.Collections.Generic.IDictionary<JetBrains.ReSharper.Psi.IType, JetBrains.ReSharper.Psi.ITypeParameter> dictionary) { }
        public JetBrains.ReSharper.Psi.IType Substitute([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IType sourceType) { }
        public JetBrains.ReSharper.Psi.IType SubstituteDeep(JetBrains.ReSharper.Psi.IType sourceType) { }
    }
    public class static TypeUsageBuilder
    {
        public static JetBrains.ReSharper.Psi.IType CreateType([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.ITypeImage image, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Feature.Services.Intentions.Impl.DeclarationBuilders.IReverseSubstitution reverseSubstitution, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITypeOwnerDeclaration context, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Feature.Services.Intentions.Impl.LanguageSpecific.Finders.TypeUsageFinder finder, [JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.Intentions.Impl.TemplateFieldHolders.ITemplateFieldHolder> holders) { }
        public static JetBrains.ReSharper.Psi.IType CreateTypeSimple([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.ITypeImage image, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode context, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Feature.Services.Intentions.Impl.LanguageSpecific.Finders.TypeUsageFinder finder, [JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.Intentions.Impl.TemplateFieldHolders.ITemplateFieldHolder> holders) { }
        public static JetBrains.ReSharper.Psi.IType TypeFromTypeImage([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.ITypeImage image, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode context, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Feature.Services.Intentions.Impl.LanguageSpecific.Finders.TypeUsageFinder finder, [JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.Intentions.Impl.TemplateFieldHolders.ITemplateFieldHolder> holders, System.Func<System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IType>, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IType>> expandTypes, System.Predicate<JetBrains.ReSharper.Psi.IType> isResolved) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.Intentions.Impl.LanguageSpecific.Finders
{
    
    public abstract class ClassExtendsFinder : JetBrains.ReSharper.Feature.Services.Intentions.Impl.TemplateFieldHolders.NestedFinder
    {
        public ClassExtendsFinder(JetBrains.ReSharper.Feature.Services.Intentions.Impl.TemplateFieldHolders.NestedFinder parent) { }
        public override string ToString() { }
    }
    public class ClassLikeDeclarationFinder : JetBrains.ReSharper.Feature.Services.Intentions.Impl.LanguageSpecific.Finders.MarkDeclarationFinder<JetBrains.ReSharper.Psi.Tree.ITypeDeclaration>
    {
        public ClassLikeDeclarationFinder(JetBrains.ReSharper.Psi.Tree.ITypeDeclaration parent) { }
    }
    public abstract class ConstructorInitializerArgumentsFinder : JetBrains.ReSharper.Feature.Services.Intentions.Impl.LanguageSpecific.Finders.MarkDeclarationFinder<JetBrains.ReSharper.Psi.Tree.ITypeMemberDeclaration>
    {
        protected ConstructorInitializerArgumentsFinder(JetBrains.ReSharper.Psi.Tree.ITypeMemberDeclaration declaration) { }
        public override string ToString() { }
    }
    public abstract class FinderFactory
    {
        public abstract JetBrains.ReSharper.Feature.Services.Intentions.Impl.LanguageSpecific.Finders.ClassExtendsFinder CreateClassExtendsFinder(JetBrains.ReSharper.Feature.Services.Intentions.Impl.LanguageSpecific.Finders.ClassLikeDeclarationFinder parent);
        public JetBrains.ReSharper.Feature.Services.Intentions.Impl.LanguageSpecific.Finders.ClassLikeDeclarationFinder CreateClassLikeDeclarationFinder(JetBrains.ReSharper.Psi.Tree.ITypeDeclaration typeDeclaration) { }
        public abstract JetBrains.ReSharper.Feature.Services.Intentions.Impl.LanguageSpecific.Finders.ConstructorInitializerArgumentsFinder CreateConstructorInitializerArgumentsFinder(JetBrains.ReSharper.Psi.Tree.ITypeMemberDeclaration declaration);
        public abstract JetBrains.ReSharper.Feature.Services.Intentions.Impl.LanguageSpecific.Finders.MethodNameFinder CreateMethodNameFinder(JetBrains.ReSharper.Feature.Services.Intentions.Impl.LanguageSpecific.Finders.ParametersOwnerDeclarationFinder parent);
        public JetBrains.ReSharper.Feature.Services.Intentions.Impl.LanguageSpecific.Finders.ParametersOwnerDeclarationFinder CreateParametersOwnerDeclarationFinder(JetBrains.ReSharper.Psi.Tree.IParametersOwnerDeclaration parametersOwnerDeclaration) { }
        public abstract JetBrains.ReSharper.Feature.Services.Intentions.Impl.LanguageSpecific.Finders.ParamNameFinder CreateParamNameFinder(JetBrains.ReSharper.Feature.Services.Intentions.Impl.LanguageSpecific.Finders.ParametersOwnerDeclarationFinder parent, int paramIndex);
        public abstract JetBrains.ReSharper.Feature.Services.Intentions.Impl.LanguageSpecific.Finders.ParamTypeUsageFinder CreateParamTypeUsageFinder(JetBrains.ReSharper.Feature.Services.Intentions.Impl.LanguageSpecific.Finders.ParametersOwnerDeclarationFinder parent, int paramIndex);
        public abstract JetBrains.ReSharper.Feature.Services.Intentions.Impl.LanguageSpecific.Finders.ReturnTypeFinder CreateReturnTypeFinder(JetBrains.ReSharper.Feature.Services.Intentions.Impl.LanguageSpecific.Finders.TypeOwnerDeclarationFinder parent);
        public abstract JetBrains.ReSharper.Feature.Services.Intentions.Impl.LanguageSpecific.Finders.TypeArgumentFinder CreateTypeArgumentFinder(JetBrains.ReSharper.Feature.Services.Intentions.Impl.LanguageSpecific.Finders.TypeUsageFinder parent, int typeArgIndex);
        public abstract JetBrains.ReSharper.Feature.Services.Intentions.Impl.LanguageSpecific.Finders.TypeKindFinder CreateTypeKindFinders(JetBrains.ReSharper.Feature.Services.Intentions.Impl.LanguageSpecific.Finders.ClassLikeDeclarationFinder parent);
        public JetBrains.ReSharper.Feature.Services.Intentions.Impl.LanguageSpecific.Finders.TypeOwnerDeclarationFinder CreateTypeOwnerDeclarationFinder(JetBrains.ReSharper.Psi.Tree.ITypeOwnerDeclaration typeOwnerDeclaration) { }
    }
    public class MarkDeclarationFinder<T> : JetBrains.ReSharper.Feature.Services.Intentions.Impl.TemplateFieldHolders.NestedFinder
        where T :  class, JetBrains.ReSharper.Psi.Tree.IDeclaration
    {
        public MarkDeclarationFinder(T declaration) { }
        public JetBrains.ReSharper.Psi.PsiLanguageType Language { get; }
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Tree.ITreeNode> Find(JetBrains.ReSharper.Psi.Tree.IDeclaration obj) { }
        public override string ToString() { }
    }
    public abstract class MethodNameFinder : JetBrains.ReSharper.Feature.Services.Intentions.Impl.TemplateFieldHolders.NestedFinder
    {
        public MethodNameFinder(JetBrains.ReSharper.Feature.Services.Intentions.Impl.TemplateFieldHolders.NestedFinder parent) { }
        public override string ToString() { }
    }
    public class ParametersOwnerDeclarationFinder : JetBrains.ReSharper.Feature.Services.Intentions.Impl.LanguageSpecific.Finders.MarkDeclarationFinder<JetBrains.ReSharper.Psi.Tree.IParametersOwnerDeclaration>
    {
        public ParametersOwnerDeclarationFinder(JetBrains.ReSharper.Psi.Tree.IParametersOwnerDeclaration declaration) { }
    }
    public abstract class ParamNameFinder : JetBrains.ReSharper.Feature.Services.Intentions.Impl.TemplateFieldHolders.NestedFinder
    {
        protected ParamNameFinder(JetBrains.ReSharper.Feature.Services.Intentions.Impl.LanguageSpecific.Finders.ParametersOwnerDeclarationFinder parent, int paramIndex) { }
        public int ParamIndex { get; set; }
        public override string ToString() { }
    }
    public abstract class ParamTypeUsageFinder : JetBrains.ReSharper.Feature.Services.Intentions.Impl.LanguageSpecific.Finders.TypeUsageFinder
    {
        protected ParamTypeUsageFinder(JetBrains.ReSharper.Feature.Services.Intentions.Impl.LanguageSpecific.Finders.ParametersOwnerDeclarationFinder parent, int paramIndex) { }
        public int ParamIndex { get; }
        public override string ToString() { }
    }
    public abstract class ReturnTypeFinder : JetBrains.ReSharper.Feature.Services.Intentions.Impl.LanguageSpecific.Finders.TypeUsageFinder
    {
        protected ReturnTypeFinder(JetBrains.ReSharper.Feature.Services.Intentions.Impl.TemplateFieldHolders.NestedFinder parent) { }
        public override string ToString() { }
    }
    public abstract class TypeArgumentFinder : JetBrains.ReSharper.Feature.Services.Intentions.Impl.LanguageSpecific.Finders.TypeUsageFinder
    {
        protected TypeArgumentFinder(JetBrains.ReSharper.Feature.Services.Intentions.Impl.LanguageSpecific.Finders.TypeUsageFinder parent, int typeArgIndex) { }
        public int TypeArgIndex { get; }
        public override string ToString() { }
    }
    public abstract class TypeKindFinder
    {
        public TypeKindFinder(JetBrains.ReSharper.Feature.Services.Intentions.Impl.LanguageSpecific.Finders.ClassLikeDeclarationFinder parent) { }
        protected JetBrains.ReSharper.Feature.Services.Intentions.Impl.LanguageSpecific.Finders.ClassLikeDeclarationFinder Parent { get; }
        public abstract System.Collections.Generic.IEnumerable<JetBrains.DocumentModel.DocumentRange> GetTypeKindRanges(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration);
        public override string ToString() { }
    }
    public class TypeOwnerDeclarationFinder : JetBrains.ReSharper.Feature.Services.Intentions.Impl.LanguageSpecific.Finders.MarkDeclarationFinder<JetBrains.ReSharper.Psi.Tree.ITypeOwnerDeclaration>
    {
        public TypeOwnerDeclarationFinder(JetBrains.ReSharper.Psi.Tree.ITypeOwnerDeclaration declaration) { }
    }
    public abstract class TypeUsageFinder : JetBrains.ReSharper.Feature.Services.Intentions.Impl.TemplateFieldHolders.NestedFinder
    {
        protected TypeUsageFinder(JetBrains.ReSharper.Feature.Services.Intentions.Impl.TemplateFieldHolders.NestedFinder parent) { }
        public abstract JetBrains.ReSharper.Psi.PsiLanguageType Language { get; }
    }
}
namespace JetBrains.ReSharper.Feature.Services.Intentions.Impl.LanguageSpecific
{
    
    public interface IMemberBodyTemplateItemsProvider
    {
        System.Collections.Generic.IList<JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem> GetLookupItems(JetBrains.ReSharper.Psi.Tree.ITypeMemberDeclaration declaration);
    }
    public abstract class IntentionLanguageSpecific
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public abstract string ClassKeyword { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public abstract string EnumKeyword { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public abstract JetBrains.ReSharper.Feature.Services.Intentions.Impl.LanguageSpecific.Finders.FinderFactory FinderFactory { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public abstract string InterfaceKeyword { get; }
        public abstract bool IsVoidMethodDeclarationHasTypeUsage { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public abstract string StructKeyword { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public abstract JetBrains.ReSharper.Psi.Tree.IFunctionDeclaration AddAccessorDeclaration([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITypeMemberDeclaration ownerDeclaration, JetBrains.ReSharper.Psi.AccessorKind kind);
        public abstract void AddBaseConstructorCall([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITypeMemberDeclaration constructorDeclaration);
        public abstract void AddBaseType([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITypeDeclaration typeDeclaration, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IDeclaredType inheritsFrom);
        [JetBrains.Annotations.NotNullAttribute()]
        public abstract JetBrains.ReSharper.Psi.Tree.ITypeMemberDeclaration AddToOwnerDeclaration([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITypeMemberDeclaration declarationToAdd, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITypeDeclaration typeDeclaration, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.ICreationTarget target);
        [JetBrains.Annotations.NotNullAttribute()]
        public abstract T AddToTarget<T>([JetBrains.Annotations.NotNullAttribute()] T declarationToAdd, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.ICreationTarget target);
        [JetBrains.Annotations.NotNullAttribute()]
        public abstract JetBrains.ReSharper.Psi.ITypeParameter AddTypeParameter([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.IDeclaration typeParametersOwner, [JetBrains.Annotations.NotNullAttribute()] string typeParameterName);
        public abstract bool CanUseExplicitly([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IType type, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode context);
        [JetBrains.Annotations.NotNullAttribute()]
        public abstract JetBrains.ReSharper.Psi.Tree.ITypeDeclaration CreateClassDeclaration([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Modules.IPsiModule module, bool isStatic);
        [JetBrains.Annotations.NotNullAttribute()]
        public abstract JetBrains.ReSharper.Psi.Tree.ITypeMemberDeclaration CreateConstDeclaration([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Modules.IPsiModule psiModule, JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext context);
        [JetBrains.Annotations.NotNullAttribute()]
        public abstract JetBrains.ReSharper.Psi.Tree.ITypeMemberDeclaration CreateConstructorDeclaration([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Modules.IPsiModule psiModule);
        [JetBrains.Annotations.NotNullAttribute()]
        public abstract JetBrains.ReSharper.Psi.Tree.ITypeMemberDeclaration CreateDelegateDeclaration([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Modules.IPsiModule psiModule);
        [JetBrains.Annotations.NotNullAttribute()]
        public abstract JetBrains.ReSharper.Psi.Tree.ITypeMemberDeclaration CreateEnumMember([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Modules.IPsiModule psiModule);
        [JetBrains.Annotations.NotNullAttribute()]
        public abstract JetBrains.ReSharper.Psi.Tree.ITypeMemberDeclaration CreateEventDeclaration([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Modules.IPsiModule psiModule, JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext context);
        [JetBrains.Annotations.NotNullAttribute()]
        public abstract JetBrains.ReSharper.Psi.Tree.ITypeMemberDeclaration CreateFieldDeclaration([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Modules.IPsiModule psiModule, JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext context);
        [JetBrains.Annotations.NotNullAttribute()]
        public abstract JetBrains.ReSharper.Psi.Tree.ITypeMemberDeclaration CreateIndexerDeclaration([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Modules.IPsiModule psiModule, bool inInterface, JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext context);
        [JetBrains.Annotations.NotNullAttribute()]
        public abstract JetBrains.ReSharper.Psi.Tree.ITypeDeclaration CreateInterfaceDeclaration([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Modules.IPsiModule module);
        [JetBrains.Annotations.NotNullAttribute()]
        public abstract JetBrains.ReSharper.Psi.Tree.ITypeMemberDeclaration CreateMethodDeclaration([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Modules.IPsiModule psiModule, bool inInterface, JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext resolveContext);
        [JetBrains.Annotations.NotNullAttribute()]
        public abstract JetBrains.ReSharper.Psi.Tree.ITypeMemberDeclaration CreatePropertyDeclaration([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Modules.IPsiModule psiModule, bool inInterface, JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext context);
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.ReSharper.Feature.Services.Intentions.Impl.LanguageSpecific.IntentionLanguageSpecific GetForLanguage([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.PsiLanguageType languageType) { }
        public static JetBrains.ReSharper.Psi.ITypeConversionRule GetTypeConversion([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode expression) { }
        public abstract JetBrains.ReSharper.Psi.ITypeConversionRule GetTypeConversionRule(JetBrains.ReSharper.Psi.Tree.ITreeNode expression);
        [JetBrains.Annotations.NotNullAttribute()]
        public abstract System.Collections.Generic.IList<string> GuessTypeParamNames(int count, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode context);
        public abstract bool IsPurePropertyDeclaration([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITypeMemberDeclaration declaration);
        public abstract void SetAccessorBodies(JetBrains.ReSharper.Psi.Tree.ITypeMemberDeclaration typeMemberDeclaration, JetBrains.ReSharper.Psi.GenerateMemberBody.AccessorImplementationKind accessrorImplementationKind, System.Collections.Generic.List<JetBrains.ReSharper.Feature.Services.Intentions.Impl.TemplateFieldHolders.ITemplateFieldHolder> holders);
        public abstract void SetAccessorOwnerName([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITypeMemberDeclaration accessorOwnerDeclaration, [JetBrains.Annotations.CanBeNullAttribute()] string name);
        public abstract void SetIsParamArray(JetBrains.ReSharper.Psi.Tree.IParameterDeclaration parameterDeclaration, bool isSet);
        public abstract void SetPartial([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITypeDeclaration declaration, bool isPartial);
        public abstract void ToExtensionMethod([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITypeMemberDeclaration method);
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Feature.Services.Intentions.Impl.LanguageSpecific.IntentionLanguageSpecific TryGetForLanguage([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.PsiLanguageType languageType) { }
        public abstract bool TypeMembersAreStaticImplicitly(JetBrains.ReSharper.Psi.Tree.IDeclaration targetDeclaration);
        public abstract bool TypeSupportsOnlyStaticMembers(JetBrains.ReSharper.Psi.Tree.ITreeNode targetDeclaration);
    }
    public class NullMemberBodyTemplateItemsProvider : JetBrains.ReSharper.Feature.Services.Intentions.Impl.LanguageSpecific.IMemberBodyTemplateItemsProvider
    {
        public System.Collections.Generic.IList<JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem> GetLookupItems(JetBrains.ReSharper.Psi.Tree.ITypeMemberDeclaration declaration) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.Intentions.Impl.MemberBodyTemplates
{
    
    public sealed class CallMethodTemplateFieldHolderFactory : JetBrains.ReSharper.Feature.Services.Intentions.Impl.MemberBodyTemplates.IMemberBodyTemplateFieldHolderFactory
    {
        public CallMethodTemplateFieldHolderFactory(JetBrains.ReSharper.Psi.IMethod methodToCall) { }
        public JetBrains.ReSharper.Feature.Services.Intentions.Impl.TemplateFieldHolders.ITemplateFieldHolder CreateBodyTemplateHolder(JetBrains.ReSharper.Psi.Tree.ITypeMemberDeclaration declaration) { }
    }
    public class DefaultMemberBodyTemplateExpression : JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotExpression, System.ICloneable
    {
        public DefaultMemberBodyTemplateExpression([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.PsiLanguageType languageType) { }
        public DefaultMemberBodyTemplateExpression([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Feature.Services.Intentions.Impl.LanguageSpecific.IMemberBodyTemplateItemsProvider provider) { }
        public object Clone() { }
        public string EvaluateQuickResult(JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotContext context) { }
        public JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.HotspotItems GetLookupItems(JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotContext context) { }
        public void HandleExpansion(JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotContext context) { }
        public string Serialize() { }
    }
    public class DefaultMemberBodyTemplateField : JetBrains.ReSharper.LiveTemplates.TemplateField
    {
        public DefaultMemberBodyTemplateField([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITypeMemberDeclaration declaration) { }
    }
    public sealed class DefaultMemberBodyTemplateFieldHolderFactory : JetBrains.ReSharper.Feature.Services.Intentions.Impl.MemberBodyTemplates.IMemberBodyTemplateFieldHolderFactory
    {
        public static JetBrains.ReSharper.Feature.Services.Intentions.Impl.TemplateFieldHolders.ITemplateFieldHolder Create(JetBrains.ReSharper.Psi.Tree.ITypeMemberDeclaration declaration) { }
        public JetBrains.ReSharper.Feature.Services.Intentions.Impl.TemplateFieldHolders.ITemplateFieldHolder CreateBodyTemplateHolder([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITypeMemberDeclaration declaration) { }
    }
    public interface IMemberBodyTemplateFieldHolderFactory
    {
        JetBrains.ReSharper.Feature.Services.Intentions.Impl.TemplateFieldHolders.ITemplateFieldHolder CreateBodyTemplateHolder(JetBrains.ReSharper.Psi.Tree.ITypeMemberDeclaration declaration);
    }
    public abstract class MemberBodyLookupBase : JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem
    {
        protected MemberBodyLookupBase(JetBrains.ReSharper.Psi.PsiLanguageType languageType) { }
        public bool CanShrink { get; }
        public abstract JetBrains.UI.RichText.RichText DisplayName { get; }
        public JetBrains.UI.RichText.RichText DisplayTypeName { get; }
        public string Identity { get; }
        public bool IgnoreSoftOnSpace { get; set; }
        public JetBrains.UI.Icons.IconId Image { get; }
        public bool IsDynamic { get; }
        public int Multiplier { get; set; }
        public string OrderingString { get; }
        public void Accept(JetBrains.TextControl.ITextControl textControl, JetBrains.Util.TextRange nameRange, JetBrains.ReSharper.Feature.Services.Lookup.LookupItemInsertType lookupItemInsertType, JetBrains.ReSharper.Feature.Services.Lookup.Suffix suffix, JetBrains.ProjectModel.ISolution solution, bool keepCaretStill) { }
        public bool AcceptIfOnlyMatched(JetBrains.ReSharper.Feature.Services.Lookup.LookupItemAcceptanceContext itemAcceptanceContext) { }
        protected abstract void DoCommand(JetBrains.ReSharper.Psi.Tree.ITreeNode element);
        public JetBrains.Util.TextRange GetVisualReplaceRange(JetBrains.TextControl.ITextControl textControl, JetBrains.Util.TextRange nameRange) { }
        public JetBrains.ReSharper.Feature.Services.Lookup.MatchingResult Match(string prefix, JetBrains.TextControl.ITextControl textControl) { }
        public bool Shrink() { }
        public void Unshrink() { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.Intentions.Impl.TemplateFieldHolders
{
    
    public class FindersTemplateFieldHolder : JetBrains.ReSharper.Feature.Services.Intentions.Impl.TemplateFieldHolders.ITemplateFieldHolder
    {
        public FindersTemplateFieldHolder(JetBrains.ReSharper.LiveTemplates.TemplateField field, params JetBrains.ReSharper.Feature.Services.Intentions.Impl.TemplateFieldHolders.ITemplateFieldFinder[] finders) { }
        public void AddFinder(JetBrains.ReSharper.Feature.Services.Intentions.Impl.TemplateFieldHolders.ITemplateFieldFinder finder) { }
        public JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.HotspotInfo GetInfo(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration) { }
    }
    public interface ITemplateFieldFinder
    {
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Tree.ITreeNode> Find(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration);
    }
    public interface ITemplateFieldHolder
    {
        JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.HotspotInfo GetInfo(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration);
    }
    public abstract class NestedFinder : JetBrains.ReSharper.Feature.Services.Intentions.Impl.TemplateFieldHolders.ITemplateFieldFinder
    {
        protected NestedFinder(JetBrains.ReSharper.Feature.Services.Intentions.Impl.TemplateFieldHolders.NestedFinder parent) { }
        protected JetBrains.ReSharper.Feature.Services.Intentions.Impl.TemplateFieldHolders.NestedFinder Parent { get; }
        public string Path { get; }
        public abstract System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Tree.ITreeNode> Find(JetBrains.ReSharper.Psi.Tree.IDeclaration obj);
    }
    public class RangeMarkerTemplateFieldHolder : JetBrains.ReSharper.Feature.Services.Intentions.Impl.TemplateFieldHolders.ITemplateFieldHolder
    {
        public RangeMarkerTemplateFieldHolder(JetBrains.ReSharper.LiveTemplates.TemplateField field, JetBrains.DocumentModel.IRangeMarker rangeMarker) { }
        public RangeMarkerTemplateFieldHolder(JetBrains.ReSharper.LiveTemplates.TemplateField field, JetBrains.DocumentModel.IRangeMarker[] rangeMarkers) { }
        public JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.HotspotInfo GetInfo(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration) { }
    }
    public class SimpleTemplateFieldFinder : JetBrains.ReSharper.Feature.Services.Intentions.Impl.TemplateFieldHolders.ITemplateFieldFinder
    {
        public SimpleTemplateFieldFinder([JetBrains.Annotations.NotNullAttribute()] System.Func<JetBrains.ReSharper.Psi.Tree.IDeclaration, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Tree.ITreeNode>> func) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Tree.ITreeNode> Find(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration) { }
    }
    public class SmartTemplateFieldHolder : JetBrains.ReSharper.Feature.Services.Intentions.Impl.TemplateFieldHolders.ITemplateFieldHolder
    {
        public SmartTemplateFieldHolder(JetBrains.ReSharper.LiveTemplates.TemplateField field, JetBrains.ReSharper.Psi.Tree.ITreeNode treeNode) { }
        public SmartTemplateFieldHolder(JetBrains.ReSharper.LiveTemplates.TemplateField field, JetBrains.ReSharper.Psi.ITreeRange treeRange) { }
        public void Dispose() { }
        public JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.HotspotInfo GetInfo(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.Intentions.Util
{
    
    public class static CreateMethodUtil<TMethodReference>
        where TMethodReference :  class, JetBrains.ReSharper.Psi.Resolve.IReference
    {
        public static JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.MemberSignature CreateEventHandlerSignature(JetBrains.ReSharper.Psi.Tree.ITypeDeclaration targetTypeDeclaration, JetBrains.ReSharper.Psi.IDelegate @delegate, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution) { }
        public static System.Action CreateMethod(TMethodReference newReference, JetBrains.ReSharper.Psi.Tree.ITypeDeclaration targetTypeDeclaration, JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.MemberSignature signature, JetBrains.ReSharper.Psi.AccessRights accessRights, System.Func<TMethodReference, string> suggestMethodName, bool executeTemplateOverReturnType = False) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Psi.Tree.ITypeDeclaration GetTargetTypeDeclaration([JetBrains.Annotations.NotNullAttribute()] TMethodReference valueReference) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Psi.Tree.ITypeDeclaration GetTargetTypeDeclaration([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.ITypeElement typeElement) { }
    }
    public class static TypeProcessUtil
    {
        public static JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.ITypeImage CreateMethodGroupTypeImage(JetBrains.ReSharper.Psi.Modules.IPsiModule psiModule, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IType> parameterTypes, JetBrains.ReSharper.Psi.IType returnType, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution, JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext context) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IExpressionType> FilterVoid([JetBrains.Annotations.NotNullAttribute()] this System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IExpressionType> typeToFilter) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.ReSharper.Psi.IDeclaredType GetDeclaredTypeForAnonymousFunction([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Modules.IPsiModule psiModule, bool hasReturnValue, System.Collections.Generic.IList<JetBrains.ReSharper.Psi.IType> typeParameters, out int typeArgsToSkip, JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext context) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.LinqTools
{
    
    public class Cache
    {
        public Cache(JetBrains.ReSharper.Psi.Modules.IPsiModule module, JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext context) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Psi.IMethod AggregateMethod { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Psi.IMethod AllMethod { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Psi.IMethod AnyMethod { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Psi.IMethod AnyWithWhereMethod { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Psi.IMethod CastMethod { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Psi.IMethod ConcatMethod { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Psi.IMethod ContainsMethod { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Psi.IMethod CountMethod { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Psi.IMethod CountWithWhereMethod { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Psi.IMethod DictionaryAddMethod { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Psi.IClass DictionaryClass { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Psi.IMethod DistinctMethod { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Psi.IMethod DistinctWithComparerMethod { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Psi.IClass EnumerableClass { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Psi.IMethod FirstOrDefaultMethod { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Psi.IMethod FirstOrDefaultWithWhereMethod { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Psi.IMethod ICollectionAddMethod { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Psi.IInterface ICollectionInterface { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Psi.IMethod IEnumerableGetEnumeratorMethod { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Psi.IInterface IEnumerableInterface { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Psi.IMethod IEnumerableNonGenericGetEnumeratorMethod { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Psi.IInterface IEnumerableNonGenericInterface { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Psi.IInterface IEnumeratorInterface { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Psi.IInterface IEnumeratorNonGenericInterface { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Psi.IInterface IEqualityComparerInterface { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Psi.IInterface IListInterface { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Psi.IMethod ListAddMethod { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Psi.IClass ListClass { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Psi.IMethod ListToArrayMethod { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Psi.IMethod LongCountMethod { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Psi.IMethod LongCountWithWhereMethod { get; }
        public JetBrains.ReSharper.Psi.Modules.IPsiModule Module { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Psi.IMethod ObjectEqualsMethod { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Psi.IMethod OfTypeMethod { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Psi.IMethod SelectMethod { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Psi.IMethod SelectWithIndexMethod { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Psi.IMethod StaticEqualsMethod { get; }
        public JetBrains.ReSharper.Psi.Caches.ISymbolScope SymbolScope { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Psi.IMethod TakeWhileMethod { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Psi.IMethod TakeWhileWithIndexMethod { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Psi.IMethod ToArrayMethod { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Psi.IMethod ToDictionaryMethod { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Psi.IMethod ToDictionaryWithComparerMethod { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Psi.IMethod ToDictionaryWithElementSelectorAndComparerMethod { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Psi.IMethod ToDictionaryWithElementSelectorMethod { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Psi.IMethod ToListMethod { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Psi.IMethod WhereMethod { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Psi.IMethod WhereWithIndexMethod { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Psi.IMethod MaxMethod(JetBrains.ReSharper.Feature.Services.LinqTools.MinMaxMethodType type) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Psi.IMethod MinMethod(JetBrains.ReSharper.Feature.Services.LinqTools.MinMaxMethodType type) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Psi.IMethod SumMethod(JetBrains.ReSharper.Feature.Services.LinqTools.SumMethodType type) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Psi.IMethod SumMethodWithSelect(JetBrains.ReSharper.Feature.Services.LinqTools.SumMethodType type) { }
    }
    [JetBrains.ReSharper.Psi.PsiComponentAttribute()]
    public class CacheMap : JetBrains.ReSharper.Psi.Caches.InvalidatingPsiCache
    {
        public CacheMap() { }
        public JetBrains.ReSharper.Feature.Services.LinqTools.Cache GetItem(JetBrains.ReSharper.Psi.Modules.IPsiModule module, JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext context) { }
        protected override void InvalidateOnPhysicalChange() { }
    }
    public class CopyToPhysicalMap
    {
        public static readonly JetBrains.ReSharper.Feature.Services.LinqTools.CopyToPhysicalMap TRIVIAL;
        public CopyToPhysicalMap(System.Func<JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode> copyToPhysical, System.Func<JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode> phisicalToCopy) { }
        public JetBrains.ReSharper.Psi.Tree.IStatement this[JetBrains.ReSharper.Psi.Tree.IStatement statement] { get; }
        public JetBrains.ReSharper.Psi.Tree.IExpression this[JetBrains.ReSharper.Psi.Tree.IExpression expression] { get; }
        public JetBrains.ReSharper.Psi.ITypeOwner this[JetBrains.ReSharper.Psi.ITypeOwner variable] { get; }
        public JetBrains.ReSharper.Psi.Tree.IStatement PhysicalToCopy(JetBrains.ReSharper.Psi.Tree.IStatement statement) { }
        public JetBrains.ReSharper.Psi.Tree.IExpression PhysicalToCopy(JetBrains.ReSharper.Psi.Tree.IExpression expression) { }
        public JetBrains.ReSharper.Psi.ITypeOwner PhysicalToCopy(JetBrains.ReSharper.Psi.ITypeOwner variable) { }
    }
    public class static ElementPointerExtensions
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static TElement GetOrNull<TElement>([JetBrains.Annotations.CanBeNullAttribute()] this JetBrains.ReSharper.Feature.Services.LinqTools.IElementPointer<TElement> pointer, JetBrains.ReSharper.Psi.Tree.ITreeNode scope)
            where TElement :  class, JetBrains.ReSharper.Psi.Tree.ITreeNode { }
    }
    public class ElementPointersStore
    {
        public ElementPointersStore() { }
        public JetBrains.ReSharper.Feature.Services.LinqTools.IElementPointer<TElement> CreatePointer<TElement>([JetBrains.Annotations.NotNullAttribute()] TElement element)
            where TElement :  class, JetBrains.ReSharper.Psi.Tree.ITreeNode { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Feature.Services.LinqTools.IElementPointer<TElement> CreatePointerOrNull<TElement>([JetBrains.Annotations.CanBeNullAttribute()] TElement element)
            where TElement :  class, JetBrains.ReSharper.Psi.Tree.ITreeNode { }
        public void EndTransformations(JetBrains.ReSharper.Psi.Tree.ITreeNode scopeToClear) { }
        public void StartTransformations() { }
    }
    [System.FlagsAttribute()]
    public enum EscapeType
    {
        BREAK = 1,
        CONTINUE = 2,
        RETURN = 4,
        GOTO = 8,
        ALL = 15,
    }
    public class FixedElementPointer<TElement> : JetBrains.ReSharper.Feature.Services.LinqTools.IElementPointer<TElement>
        where TElement :  class, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        public FixedElementPointer(TElement element) { }
        public TElement Get(JetBrains.ReSharper.Psi.Tree.ITreeNode scope) { }
    }
    public interface IElementPointer<out TElement>
        where out TElement :  class, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        TElement Get(JetBrains.ReSharper.Psi.Tree.ITreeNode scope);
    }
    public interface ILinqToolsLanguageHelper
    {
        string[] AssignAnyPatterns { get; }
        string[] AssignmentAndReturnPatterns { get; }
        bool CanOmitTrivialSelect { get; }
        string[] CastPatterns { get; }
        string[] CountPatterns { get; }
        string[] DeclarationAndReturnPatterns { get; }
        string[] DistinctPatterns { get; }
        string[] DistinctPatternsWithContinue { get; }
        string[] DistinctSetVarDeclPatterns { get; }
        string[] ElementAccessPatterns { get; }
        string[] EqualsPatterns { get; }
        string[] FirstOrDefaultPatternsWithBreak { get; }
        string[] FirstOrDefaultPatternsWithReturn { get; }
        string[] ForLoopPatterns { get; }
        string FromQueryExplicitTypeFormatString { get; }
        string FromQueryFormatString { get; }
        string[] IfAnyPatterns { get; }
        string[] IfAnyPatternsWithBreak { get; }
        string LetQueryFormatString { get; }
        string[] MaxPatterns { get; }
        string[] MinPatterns { get; }
        string[] OfTypePatterns { get; }
        string[] OfTypePatternsWithContinue1 { get; }
        string[] OfTypePatternsWithContinue2 { get; }
        string[] ReturnAnyPatterns { get; }
        string SelectIntoQueryFormatString { get; }
        string[] SelectOrLetPatterns { get; }
        string SelectQueryFormatString { get; }
        string[] SumPatterns { get; }
        string[] TakeWhilePatterns { get; }
        string[] TypeInstantiationOneParamPatterns { get; }
        string[] TypeInstantiationPatterns { get; }
        System.Collections.Generic.IEnumerable<System.Type> TypesToMarkOnCopy { get; }
        bool VariablesInLoopCollectionConflictWithIterator { get; }
        string[] WhereInversePatterns { get; }
        string[] WherePatterns { get; }
        string WhereQueryFormatString { get; }
        string[] YieldReturnPatterns { get; }
        JetBrains.ReSharper.Psi.Tree.IStatement AddStatement(JetBrains.ReSharper.Psi.Tree.IStatement statement, ref JetBrains.ReSharper.Psi.Tree.IStatement anchor, bool before);
        bool CanReplaceCastOperator(JetBrains.ReSharper.Psi.IType sourceType, JetBrains.ReSharper.Psi.IType targetType, JetBrains.ReSharper.Psi.Tree.ITreeNode context);
        void ChangeVariableType(JetBrains.ReSharper.Psi.Tree.ITypeOwnerDeclaration declaration, JetBrains.ReSharper.Psi.IType newType);
        bool CheckNoEscapes(JetBrains.ReSharper.Psi.Tree.IStatement statement, JetBrains.ReSharper.Feature.Services.LinqTools.EscapeType escapeTypes, System.Predicate<JetBrains.ReSharper.Psi.Tree.IStatement> filter);
        JetBrains.ReSharper.Psi.ConstantValue ConvertConstantValueToTypeImplicit(JetBrains.ReSharper.Psi.ConstantValue value, JetBrains.ReSharper.Psi.IType type, JetBrains.ReSharper.Psi.Tree.IFile context);
        void CopyLocal(JetBrains.ReSharper.Psi.Tree.IExpression refExpression);
        JetBrains.ReSharper.Psi.Tree.IStatement CreateAddValueStatement(JetBrains.ReSharper.Psi.Modules.IPsiModule module, JetBrains.ReSharper.Psi.ITypeOwner targetVar, JetBrains.ReSharper.Psi.Tree.IExpression expression);
        JetBrains.ReSharper.Psi.Tree.IStatement CreateAssignmentStatement(JetBrains.ReSharper.Psi.Modules.IPsiModule module, JetBrains.ReSharper.Psi.ITypeOwner targetVar, JetBrains.ReSharper.Psi.Tree.IExpression expression);
        JetBrains.ReSharper.Psi.Tree.IExpression CreateCastExpression(JetBrains.ReSharper.Psi.Modules.IPsiModule module, JetBrains.ReSharper.Psi.Tree.IExpression expression, JetBrains.ReSharper.Psi.IType type);
        JetBrains.ReSharper.Psi.ILocalVariable CreateDummyVariable(JetBrains.ReSharper.Psi.Modules.IPsiModule module, JetBrains.ReSharper.Psi.IType type);
        JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder CreateElementPlaceholder(string name, JetBrains.ReSharper.Psi.Tree.ITreeNode node);
        JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder CreateExpressionPlaceholder(string name);
        JetBrains.ReSharper.Psi.Tree.IStatement CreateForeachStatement(JetBrains.ReSharper.Psi.Tree.ITreeNode context, JetBrains.ReSharper.Psi.IType elementType, bool useImplicitType, string iteratorName, JetBrains.ReSharper.Psi.Tree.IExpression enumerableExpr, JetBrains.ReSharper.Psi.Tree.IStatementsRange body, bool forceUseBlock);
        JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder CreateIdentifierPlaceholder(string name);
        JetBrains.ReSharper.Psi.Tree.IStatement CreateIfStatement(JetBrains.ReSharper.Psi.Modules.IPsiModule module, JetBrains.ReSharper.Psi.Tree.IExpression condition, JetBrains.ReSharper.Psi.Tree.IStatementsRange thenStatements);
        JetBrains.ReSharper.Psi.Tree.IExpression CreateInvocationExpression(JetBrains.ReSharper.Psi.Modules.IPsiModule module, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.IMethod targetMethod, System.Collections.Generic.IList<JetBrains.ReSharper.Psi.IType> typeArgs, [JetBrains.Annotations.CanBeNullAttribute()] object qualifier, string methodName, params object[] args);
        JetBrains.ReSharper.Psi.Tree.IStatement CreateInvocationStatement(JetBrains.ReSharper.Psi.Modules.IPsiModule module, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.IMethod targetMethod, System.Collections.Generic.IList<JetBrains.ReSharper.Psi.IType> typeArgs, [JetBrains.Annotations.CanBeNullAttribute()] object qualifier, string methodName, params object[] args);
        JetBrains.ReSharper.Psi.Tree.IExpression CreateLambdaExpression(JetBrains.ReSharper.Psi.Modules.IPsiModule module, string[] argNames, JetBrains.ReSharper.Psi.Tree.IExpression body);
        JetBrains.ReSharper.Psi.Tree.IExpression CreateLogicalAndExpression(JetBrains.ReSharper.Psi.Modules.IPsiModule module, JetBrains.ReSharper.Psi.Tree.IExpression condition1, JetBrains.ReSharper.Psi.Tree.IExpression condition2);
        JetBrains.ReSharper.Psi.Tree.IExpression CreateOneElementArrayCreationExpression(JetBrains.ReSharper.Psi.Modules.IPsiModule module, JetBrains.ReSharper.Psi.IType elementType, JetBrains.ReSharper.Psi.Tree.IExpression element);
        JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralSearchPattern CreatePattern(string text, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder> placeholders);
        JetBrains.ReSharper.Psi.Tree.IExpression CreateQueryExpression(JetBrains.ReSharper.Psi.Modules.IPsiModule module, string text, System.Collections.Generic.IEnumerable<object> args);
        JetBrains.ReSharper.Psi.Tree.IStatement CreateReturnStatement(JetBrains.ReSharper.Psi.Modules.IPsiModule module, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Tree.IExpression returnValue);
        JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder CreateStatementPlaceholder(string name);
        JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder CreateStatementsPlaceholder(string name);
        JetBrains.ReSharper.Psi.Tree.IExpression CreateSumExpression(JetBrains.ReSharper.Psi.Modules.IPsiModule module, JetBrains.ReSharper.Psi.Tree.IExpression operand1, JetBrains.ReSharper.Psi.Tree.IExpression operand2);
        JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder CreateTypePlaceholder(string name);
        JetBrains.ReSharper.Psi.Tree.IExpression CreateVariableUsageExpression(JetBrains.ReSharper.Psi.Modules.IPsiModule module, JetBrains.ReSharper.Psi.ITypeOwner variable);
        JetBrains.ReSharper.Psi.Tree.IExpression CreateVariableUsageExpression(JetBrains.ReSharper.Psi.Modules.IPsiModule module, string variableName);
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.ILocalVariable DeclareTempVariable(JetBrains.ReSharper.Psi.IType type, string name, ref JetBrains.ReSharper.Psi.Tree.IStatementsRange beforeStatementsRange);
        JetBrains.ReSharper.Psi.Tree.IExpression ElementAccessByArgument(JetBrains.ReSharper.Psi.Tree.IExpression argument);
        JetBrains.ReSharper.Psi.Resolve.IReference ElementAccessReference(JetBrains.ReSharper.Psi.Tree.IExpression expression);
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Tree.IExpression GenerateFunctionalForm(JetBrains.ReSharper.Psi.Tree.IExpression queryExpression, JetBrains.ReSharper.Psi.Tree.ITreeNode context);
        JetBrains.ReSharper.Psi.Tree.IExpression GetInitializer(JetBrains.ReSharper.Psi.Tree.IDeclaration localVarDeclaration);
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Tree.ITreeNode GetScopeToCopy(JetBrains.ReSharper.Psi.Tree.IStatement loop);
        bool HasAwaitExpressions(JetBrains.ReSharper.Psi.Tree.IExpression expression);
        JetBrains.ReSharper.Psi.Tree.IExpression InvertCondition(JetBrains.ReSharper.Psi.Tree.IExpression condition);
        JetBrains.ReSharper.Psi.Resolve.IReference InvocationExpressionReference(JetBrains.ReSharper.Psi.Tree.IExpression expression);
        bool IsCastExpression(JetBrains.ReSharper.Psi.Tree.IExpression expression, out JetBrains.ReSharper.Psi.Tree.IExpression operand);
        bool IsCastExpressionOperand(JetBrains.ReSharper.Psi.Tree.IExpression expression, out JetBrains.ReSharper.Psi.Tree.IExpression castExpr);
        bool IsForeachStatement(JetBrains.ReSharper.Psi.Tree.IStatement statement, [JetBrains.Annotations.NotNullAttribute()] out JetBrains.ReSharper.Psi.Tree.IStatementsRange body, [JetBrains.Annotations.NotNullAttribute()] out JetBrains.ReSharper.Psi.ILocalVariable iteratorVar, [JetBrains.Annotations.NotNullAttribute()] out JetBrains.ReSharper.Psi.Tree.IExpression collectionExpr);
        bool IsForStatement(JetBrains.ReSharper.Psi.Tree.IStatement statement, [JetBrains.Annotations.NotNullAttribute()] out JetBrains.ReSharper.Psi.Tree.IStatementsRange body);
        bool IsImplicitlyTyped(JetBrains.ReSharper.Psi.ILocalVariable local);
        bool IsInvocation(JetBrains.ReSharper.Psi.Tree.IStatement statement, out JetBrains.ReSharper.Psi.IMethod targetMethod, out JetBrains.ReSharper.Psi.Tree.IExpression qualifier, out System.Collections.Generic.IList<> args);
        bool IsInvocation(JetBrains.ReSharper.Psi.Tree.IExpression expression, out JetBrains.ReSharper.Psi.IMethod targetMethod, out JetBrains.ReSharper.Psi.Tree.IExpression qualifier, out System.Collections.Generic.IList<> args);
        bool IsInvocationQualifier(JetBrains.ReSharper.Psi.Tree.IExpression qualifier, out JetBrains.ReSharper.Psi.Tree.IExpression invocation, [JetBrains.Annotations.CanBeNullAttribute()] out JetBrains.ReSharper.Psi.IMethod targetMethod, out System.Collections.Generic.IList<> args);
        bool IsLabelStatement(JetBrains.ReSharper.Psi.Tree.IStatement statement);
        bool IsLastExecutedStatement(JetBrains.ReSharper.Psi.Tree.IStatement statement, bool allowIfs, out JetBrains.ReSharper.Psi.Tree.IExpression valueReturned, out JetBrains.ReSharper.Psi.Tree.IStatement returnStatementToRemove);
        bool IsLoopBodyBlock(JetBrains.ReSharper.Psi.Tree.IStatement statement);
        bool IsReturnOwner(JetBrains.ReSharper.Psi.Tree.ITreeNode node, out JetBrains.ReSharper.Psi.IType returnType);
        bool IsSimpleExpression(JetBrains.ReSharper.Psi.Tree.IExpression expression);
        bool IsVariableAssignment(JetBrains.ReSharper.Psi.Tree.IStatement statement, out JetBrains.ReSharper.Psi.ITypeOwner variable, out JetBrains.ReSharper.Psi.Tree.IExpression valueAssigned);
        bool IsVariableAssignmentValue(JetBrains.ReSharper.Psi.Tree.IExpression expression, out JetBrains.ReSharper.Psi.Tree.IStatement statement, out JetBrains.ReSharper.Psi.ITypeOwner variable);
        bool IsVariableUsage(JetBrains.ReSharper.Psi.Tree.IExpression expression, string name);
        bool IsWriteElementAccess(JetBrains.ReSharper.Psi.Tree.IExpression refExpr);
        bool IsYieldStatement(JetBrains.ReSharper.Psi.Tree.IStatement statement);
        JetBrains.ReSharper.Psi.Tree.IExpression ReferenceExpressionByQualifier(JetBrains.ReSharper.Psi.Tree.IExpression qualifier);
        JetBrains.ReSharper.Psi.Tree.IExpression ReferenceExpressionByReference(JetBrains.ReSharper.Psi.Resolve.IReference reference);
        JetBrains.ReSharper.Psi.Resolve.IReference ReferenceExpressionReference(JetBrains.ReSharper.Psi.Tree.IExpression expression);
        void RemoveStatement(JetBrains.ReSharper.Psi.Tree.IStatement statement);
        void RenameVarRef(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.Tree.IExpression newExpr, ref JetBrains.ReSharper.Psi.Tree.IExpression expr);
        JetBrains.ReSharper.Psi.Tree.IExpression ReplaceBy(JetBrains.ReSharper.Psi.Tree.IExpression oldExpr, JetBrains.ReSharper.Psi.Tree.IExpression newExpr);
        JetBrains.ReSharper.Psi.Tree.IStatement ReplaceBy(JetBrains.ReSharper.Psi.Tree.IStatement oldStatement, JetBrains.ReSharper.Psi.Tree.IStatement newStatement);
        void SetInitializer(JetBrains.ReSharper.Psi.Tree.IDeclaration localVarDeclaration, JetBrains.ReSharper.Psi.Tree.IExpression value);
        void SetTypeOrVar(JetBrains.ReSharper.Psi.Tree.ITypeOwnerDeclaration localVarDeclaration, JetBrains.ReSharper.Psi.IType type);
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Tree.ITypeOwnerDeclaration SingleVariableDeclaration(JetBrains.ReSharper.Psi.Tree.IStatement statement);
        JetBrains.ReSharper.Psi.Tree.IStatementsRange SkipStatements(System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Tree.IStatement> statements, int n);
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Tree.IStatement> StatementsAfter(JetBrains.ReSharper.Psi.Tree.IStatement statement);
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Tree.IStatement> StatementsBefore(JetBrains.ReSharper.Psi.Tree.IStatement statement);
        JetBrains.ReSharper.Psi.Tree.IStatementsRange StatementsToRange(System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Tree.IStatement> statements);
        JetBrains.ReSharper.Psi.Tree.IStatementsRange StatementToRange([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.IStatement statement);
        JetBrains.ReSharper.Psi.Tree.IStatementsRange ToStatementsRange(JetBrains.ReSharper.Psi.ITreeRange treeRange);
        JetBrains.ReSharper.Psi.ITypeConversionRule TypeConversionRule(JetBrains.ReSharper.Psi.Tree.ITreeNode context);
        bool VarCanAggregateMultipleTimes(JetBrains.ReSharper.Psi.ILocalVariable workingVar, JetBrains.ReSharper.Psi.Tree.IStatement setVarDeclStatement);
    }
    public interface IStructuralSearchMatchersCacheExtension
    {
        JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralMatcher CreateExpressionMatcher(JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralSearchPattern pattern);
        JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralMatcher CreateStatementMatcher(JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralSearchPattern pattern);
    }
    public class static LinqToolsUtil
    {
        public static JetBrains.ReSharper.Psi.ITypeOwner AsLocal(this JetBrains.ReSharper.Psi.IDeclaredElement element) { }
        public static bool CheckNoEscapes(JetBrains.ReSharper.Psi.Tree.IStatementsRange range, JetBrains.ReSharper.Feature.Services.LinqTools.EscapeType escapeTypes) { }
        public static bool CheckNoEscapes(JetBrains.ReSharper.Psi.Tree.IStatement statement, JetBrains.ReSharper.Feature.Services.LinqTools.EscapeType escapeTypes) { }
        public static bool CheckNoEscapes(JetBrains.ReSharper.Psi.Tree.IStatement statement, JetBrains.ReSharper.Feature.Services.LinqTools.EscapeType escapeTypes, System.Predicate<JetBrains.ReSharper.Psi.Tree.IStatement> filter) { }
        public static JetBrains.ReSharper.Psi.Tree.IExpression CreateLambdaExpression(this JetBrains.ReSharper.Feature.Services.LinqTools.ILinqToolsLanguageHelper helper, JetBrains.ReSharper.Psi.Modules.IPsiModule module, string argName, JetBrains.ReSharper.Psi.Tree.IExpression body) { }
        public static System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralSearchPattern> CreatePatterns(this JetBrains.ReSharper.Feature.Services.LinqTools.ILinqToolsLanguageHelper helper, System.Collections.Generic.IEnumerable<string> texts, params JetBrains.ReSharper.Psi.Services.StructuralSearch.IPlaceholder[] nonStandardPlaceholers) { }
        public static System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IParameter> FetchRefOrOutParameters(JetBrains.ReSharper.Psi.Tree.ITreeNode place) { }
        public static JetBrains.ReSharper.Psi.Tree.IExpression GetInitializer(this JetBrains.ReSharper.Psi.Tree.IDeclaration localVarDeclaration) { }
        public static JetBrains.ReSharper.Psi.IDeclaredElement GetReferenceExpressionTarget(this JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralMatchResult matchResult, string placeholderName) { }
        public static bool HasAwaitExpressions(JetBrains.ReSharper.Psi.Tree.IExpression expression) { }
        public static JetBrains.ReSharper.Psi.Tree.IExpression InvertCondition(this JetBrains.ReSharper.Psi.Tree.IExpression condition) { }
        public static bool IsCastExpression(this JetBrains.ReSharper.Psi.Tree.IExpression expression, out JetBrains.ReSharper.Psi.Tree.IExpression operand) { }
        public static bool IsCastExpressionOperand(this JetBrains.ReSharper.Psi.Tree.IExpression expression, out JetBrains.ReSharper.Psi.Tree.IExpression castExpr) { }
        public static bool IsDefaultValue(this JetBrains.ReSharper.Psi.ConstantValue value, JetBrains.ReSharper.Psi.IType type, JetBrains.ReSharper.Psi.Tree.ITreeNode context) { }
        public static bool IsForeachStatement(this JetBrains.ReSharper.Psi.Tree.IStatement statement) { }
        public static bool IsForeachStatement(this JetBrains.ReSharper.Psi.Tree.IStatement statement, [JetBrains.Annotations.NotNullAttribute()] out JetBrains.ReSharper.Psi.Tree.IStatementsRange body, [JetBrains.Annotations.NotNullAttribute()] out JetBrains.ReSharper.Psi.ILocalVariable iteratorVar, [JetBrains.Annotations.NotNullAttribute()] out JetBrains.ReSharper.Psi.Tree.IExpression collectionExpr) { }
        public static bool IsForStatement(this JetBrains.ReSharper.Psi.Tree.IStatement statement, [JetBrains.Annotations.NotNullAttribute()] out JetBrains.ReSharper.Psi.Tree.IStatementsRange body) { }
        public static bool IsForStatement(this JetBrains.ReSharper.Psi.Tree.IStatement statement) { }
        public static bool IsImplicitlyTyped(this JetBrains.ReSharper.Psi.ILocalVariable local) { }
        public static bool IsInvocation(this JetBrains.ReSharper.Psi.Tree.IStatement statement, out JetBrains.ReSharper.Psi.IMethod targetMethod, out JetBrains.ReSharper.Psi.Tree.IExpression qualifier, out System.Collections.Generic.IList<> args) { }
        public static bool IsInvocation(this JetBrains.ReSharper.Psi.Tree.IStatement statement, JetBrains.ReSharper.Psi.IMethod targetMethod, out JetBrains.ReSharper.Psi.Tree.IExpression qualifier, out System.Collections.Generic.IList<> args) { }
        public static bool IsInvocation(this JetBrains.ReSharper.Psi.Tree.IExpression expression, out JetBrains.ReSharper.Psi.IMethod targetMethod, out JetBrains.ReSharper.Psi.Tree.IExpression qualifier, out System.Collections.Generic.IList<> args) { }
        public static bool IsInvocation(this JetBrains.ReSharper.Psi.Tree.IExpression expression, JetBrains.ReSharper.Psi.IMethod targetMethod, out JetBrains.ReSharper.Psi.Tree.IExpression qualifier, out System.Collections.Generic.IList<> args) { }
        public static bool IsLastExecutedStatement(JetBrains.ReSharper.Psi.Tree.IStatement statement, out JetBrains.ReSharper.Psi.Tree.IExpression valueReturned, out JetBrains.ReSharper.Psi.Tree.IStatement returnStatementToRemove) { }
        public static bool IsLastExecutedStatement(JetBrains.ReSharper.Psi.Tree.IStatement statement, bool allowIfs, out JetBrains.ReSharper.Psi.Tree.IExpression valueReturned, out JetBrains.ReSharper.Psi.Tree.IStatement returnStatementToRemove) { }
        public static bool IsReferenceExpressionTo([JetBrains.Annotations.CanBeNullAttribute()] this JetBrains.ReSharper.Psi.Tree.IExpression expression, JetBrains.ReSharper.Psi.IDeclaredElement target) { }
        public static bool IsReferenceExpressionTo(this JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralMatchResult matchResult, string placeholderName, JetBrains.ReSharper.Psi.IDeclaredElement target) { }
        public static bool IsUsed(JetBrains.ReSharper.Psi.IDeclaredElement element, JetBrains.ReSharper.Psi.Tree.ITreeNode scope, System.Predicate<JetBrains.ReSharper.Psi.Resolve.IReference> filter = null) { }
        public static bool IsUsed(JetBrains.ReSharper.Psi.IDeclaredElement element, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Tree.IStatement> statements, System.Predicate<JetBrains.ReSharper.Psi.Resolve.IReference> filter = null) { }
        public static bool IsUsed(JetBrains.ReSharper.Psi.IDeclaredElement element, JetBrains.ReSharper.Psi.Search.ISearchDomain searchDomain, System.Predicate<JetBrains.ReSharper.Psi.Resolve.IReference> filter) { }
        public static bool IsUsedExcept(JetBrains.ReSharper.Psi.IDeclaredElement element, JetBrains.ReSharper.Psi.Tree.IStatement loop, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Tree.IStatement> statements) { }
        public static bool IsUsedExcept(JetBrains.ReSharper.Psi.IDeclaredElement element, JetBrains.ReSharper.Psi.Tree.IStatement loop, JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public static bool IsVariableAssignment(this JetBrains.ReSharper.Psi.Tree.IStatement statement, out JetBrains.ReSharper.Psi.ITypeOwner variable, out JetBrains.ReSharper.Psi.Tree.IExpression valueAssigned) { }
        public static bool IsVariableAssignmentValue(this JetBrains.ReSharper.Psi.Tree.IExpression expression, out JetBrains.ReSharper.Psi.Tree.IStatement statement, out JetBrains.ReSharper.Psi.ITypeOwner variable) { }
        public static JetBrains.ReSharper.Feature.Services.LinqTools.ILinqToolsLanguageHelper LanguageHelper([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Tree.ITreeNode node) { }
        public static JetBrains.ReSharper.Feature.Services.LinqTools.ILinqToolsLanguageHelper LanguageHelper(this JetBrains.ReSharper.Psi.PsiLanguageType language) { }
        public static TResult PerformActionOnCopy<TLoop, TResult>(TLoop loop, System.Func<TLoop, JetBrains.ReSharper.Feature.Services.LinqTools.CopyToPhysicalMap, TResult> action, TResult defaultResult)
            where TLoop :  class, JetBrains.ReSharper.Psi.Tree.IStatement { }
        public static JetBrains.ReSharper.Psi.IDeclaredElement ReferenceExpressionTarget([JetBrains.Annotations.CanBeNullAttribute()] this JetBrains.ReSharper.Psi.Tree.IExpression expression) { }
        public static void RenameVariable(JetBrains.ReSharper.Psi.ITypeOwner variable, string newName) { }
        public static void RenameVarRefs(JetBrains.ReSharper.Psi.ITypeOwner var, string newName, JetBrains.ReSharper.Psi.Tree.ITreeNode scope, ref JetBrains.ReSharper.Psi.Tree.IExpression expr) { }
        public static JetBrains.ReSharper.Psi.Tree.IExpression ReplaceBy(this JetBrains.ReSharper.Psi.Tree.IExpression oldExpr, JetBrains.ReSharper.Psi.Tree.IExpression newExpr) { }
        public static JetBrains.ReSharper.Psi.Tree.IStatement ReplaceBy(this JetBrains.ReSharper.Psi.Tree.IStatement oldStatement, JetBrains.ReSharper.Psi.Tree.IStatement newStatement) { }
        public static void SetInitializer(this JetBrains.ReSharper.Psi.Tree.IDeclaration localVarDeclaration, JetBrains.ReSharper.Psi.Tree.IExpression value) { }
        public static void SetTypeOrVar(this JetBrains.ReSharper.Psi.Tree.ITypeOwnerDeclaration localVarDeclaration, JetBrains.ReSharper.Psi.IType type) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Psi.Tree.ITypeOwnerDeclaration SingleVariableDeclaration(this JetBrains.ReSharper.Psi.Tree.IStatement declarationStatement) { }
        public static JetBrains.ReSharper.Psi.ILocalVariable SingleVariableUsed(System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.ILocalVariable> variables, JetBrains.ReSharper.Psi.Tree.IExpression expression) { }
        public static JetBrains.ReSharper.Psi.ILocalVariable SingleVariableUsed(System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.ILocalVariable> variables, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Tree.IStatement> statements) { }
        public static JetBrains.ReSharper.Psi.Tree.IStatementsRange SkipOneStatement(this JetBrains.ReSharper.Feature.Services.LinqTools.ILinqToolsLanguageHelper helper, System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Tree.IStatement> statements) { }
        public static System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Tree.IStatement> Substatements(this JetBrains.ReSharper.Psi.Tree.IStatement statement) { }
        public static JetBrains.ReSharper.Psi.Tree.IStatementsRange ToStatementRange([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Tree.IStatement statement) { }
        public static System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.ILocalVariable> VariablesUsed(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.ILocalVariable> variables, JetBrains.ReSharper.Psi.Tree.IExpression expression) { }
        public static System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.ILocalVariable> VariablesUsed(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.ILocalVariable> variables, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Tree.IStatement> statements) { }
    }
    public enum MinMaxMethodType
    {
        Int = 0,
        Long = 1,
        Float = 2,
        Double = 3,
        Decimal = 4,
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class StructuralSearchMatchersCache
    {
        public StructuralSearchMatchersCache(JetBrains.DataFlow.Lifetime lifetime, JetBrains.DataFlow.IViewable<JetBrains.ReSharper.Feature.Services.LinqTools.IStructuralSearchMatchersCacheExtension> extensions) { }
        public void DropMatcherForPattern(JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralSearchPattern pattern) { }
        public static JetBrains.ReSharper.Feature.Services.LinqTools.StructuralSearchMatchersCache GetInstance(JetBrains.ProjectModel.ISolution solution) { }
        public static JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralMatchResult MatchPatterns(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Tree.IStatement> statements, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralSearchPattern> patterns) { }
        public static JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralMatchResult MatchPatterns(JetBrains.ReSharper.Psi.Tree.IExpression expression, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Services.StructuralSearch.IStructuralSearchPattern> patterns) { }
    }
    public enum SumMethodType
    {
        Int = 0,
        Long = 1,
        Float = 2,
        Double = 3,
        Decimal = 4,
    }
    public class TreeNodeMarker<TElement> : JetBrains.ReSharper.Psi.TreeNodeMarker
        where TElement :  class, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        public TreeNodeMarker() { }
        public TreeNodeMarker(TElement element) { }
        public void Dispose(JetBrains.ReSharper.Psi.Tree.ITreeNode root) { }
        public TElement FindMarkedNode([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode root) { }
        public System.Collections.Generic.IEnumerable<TElement> FindMarkedNodes([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode root) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public TElement Get(JetBrains.ReSharper.Psi.Tree.ITreeNode root) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public TElement GetAndDispose(JetBrains.ReSharper.Psi.Tree.ITreeNode root) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.LinqTools.ToLinq
{
    
    public class ActionPartInfo
    {
        public ActionPartInfo(JetBrains.ReSharper.Feature.Services.LinqTools.ToLinq.IActionQuery query) { }
        public ActionPartInfo(JetBrains.ReSharper.Feature.Services.LinqTools.ToLinq.IActionQuery query, System.Collections.Generic.IList<JetBrains.ReSharper.Feature.Services.LinqTools.ToLinq.ISequenceQuery> additionalFilters) { }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Feature.Services.LinqTools.ToLinq.ISequenceQuery> AdditionalFilters { get; }
        public JetBrains.ReSharper.Feature.Services.LinqTools.ToLinq.IActionQuery Query { get; }
    }
    public class static ForLoopUtil
    {
        public static JetBrains.ReSharper.Feature.Services.LinqTools.ToLinq.ForLoopUtil.ForToForeachInfo CheckCanConvertForToForeach(JetBrains.ReSharper.Psi.Tree.IStatement forLoop) { }
        public static JetBrains.ReSharper.Psi.Tree.IStatement ConvertForToForeach(JetBrains.ReSharper.Psi.Tree.IStatement loop, JetBrains.ReSharper.Feature.Services.LinqTools.ToLinq.ForLoopUtil.ForToForeachInfo info, out bool newTempVarIntroduced) { }
        public static bool DeclareTempVarAndReplaceElementAccesses(JetBrains.ReSharper.Psi.Tree.IStatement forLoop, JetBrains.ReSharper.Psi.IType elementType, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Tree.IExpression> elementAccesses, JetBrains.ReSharper.Feature.Services.LinqTools.Cache cache, out JetBrains.ReSharper.Psi.ILocalVariable tempVar, out JetBrains.ReSharper.Psi.Tree.IStatementsRange statementsRange, out System.Collections.Generic.IEnumerable<> replacedAccesses, out bool newTempVarIntroduced) { }
        public static bool PreCheckForLoop(JetBrains.ReSharper.Psi.Tree.IStatement forLoop, JetBrains.ReSharper.Feature.Services.LinqTools.Cache cache, out JetBrains.ReSharper.Psi.Tree.IExpression collectionExpr, out JetBrains.ReSharper.Psi.IType collectionType, out JetBrains.ReSharper.Psi.IType elementType, out JetBrains.ReSharper.Psi.ILocalVariable indexVar, out System.Collections.Generic.ICollection<> elementAccesses) { }
        public class ForToForeachInfo
        {
            public readonly JetBrains.ReSharper.Psi.Tree.IExpression CollectionExpr;
            public readonly System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.Tree.IExpression> ElementAccesses;
            public readonly JetBrains.ReSharper.Psi.IType ElementType;
            public ForToForeachInfo(JetBrains.ReSharper.Psi.Tree.IExpression collectionExpr, JetBrains.ReSharper.Psi.IType elementType, System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.Tree.IExpression> elementAccesses) { }
        }
    }
    public class static GenerateCode
    {
        public static bool CanConvertLoopToLoop(JetBrains.ReSharper.Feature.Services.LinqTools.ToLinq.SequencePartInfo sequencePartInfo, out JetBrains.ReSharper.Psi.ILocalVariable workingVariable) { }
        public static void ConvertLoopToLoop(JetBrains.ReSharper.Psi.Tree.IStatement loop, System.Collections.Generic.IList<JetBrains.ReSharper.Feature.Services.LinqTools.ToLinq.ISequenceQuery> queries, JetBrains.ReSharper.Psi.ILocalVariable workingVariable, JetBrains.ReSharper.Psi.Tree.IStatementsRange restStatements, JetBrains.ReSharper.Feature.Services.LinqTools.CopyToPhysicalMap copyToPhysicalMap, JetBrains.ReSharper.Feature.Services.LinqTools.Cache cache) { }
        public static void ConvertLoopToQuery(JetBrains.ReSharper.Psi.Tree.IStatement loop, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.LinqTools.ToLinq.ISequenceQuery> queries, JetBrains.ReSharper.Feature.Services.LinqTools.ToLinq.IActionQuery actionQuery, JetBrains.ReSharper.Feature.Services.LinqTools.CopyToPhysicalMap copyToPhysicalMap, JetBrains.ReSharper.Feature.Services.LinqTools.Cache cache) { }
    }
    public struct GenerateFunctionalQueryParams
    {
        public GenerateFunctionalQueryParams(JetBrains.ReSharper.Psi.Tree.IExpression enumerableExpression, JetBrains.ReSharper.Psi.IType elementType, JetBrains.ReSharper.Feature.Services.LinqTools.CopyToPhysicalMap copyToPhysicalMap, JetBrains.ReSharper.Feature.Services.LinqTools.Cache cache) { }
        public JetBrains.ReSharper.Feature.Services.LinqTools.Cache Cache { get; }
        public JetBrains.ReSharper.Feature.Services.LinqTools.CopyToPhysicalMap CopyToPhysicalMap { get; }
        public JetBrains.ReSharper.Psi.IType ElementType { get; }
        public JetBrains.ReSharper.Psi.Tree.IExpression EnumerableExpression { get; }
        public JetBrains.ReSharper.Psi.Tree.IExpression SelectExpression { get; }
        public JetBrains.ReSharper.Psi.ILocalVariable SelectInputVariable { get; }
        public JetBrains.ReSharper.Psi.Tree.IExpression WhereExpression { get; }
        public JetBrains.ReSharper.Psi.ILocalVariable WhereVariable { get; }
        public void SetSelectExpression(JetBrains.ReSharper.Psi.Tree.IExpression expression, JetBrains.ReSharper.Psi.ILocalVariable inputVariable) { }
        public void SetWhereExpression(JetBrains.ReSharper.Psi.Tree.IExpression expression, JetBrains.ReSharper.Psi.ILocalVariable variable) { }
    }
    public interface IActionQuery : JetBrains.ReSharper.Feature.Services.LinqTools.ToLinq.IFunctionalQuery, JetBrains.ReSharper.Feature.Services.LinqTools.ToLinq.IQuery
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.ILocalVariable InputVariable { get; }
        bool CanIncludeSelect(JetBrains.ReSharper.Feature.Services.LinqTools.Cache cache);
        bool CanIncludeWhere(JetBrains.ReSharper.Feature.Services.LinqTools.Cache cache);
        JetBrains.ReSharper.Psi.Tree.IStatementsRange ConvertLoop(JetBrains.ReSharper.Psi.Tree.IStatement loop, JetBrains.ReSharper.Feature.Services.LinqTools.ToLinq.GenerateFunctionalQueryParams @params);
    }
    public interface IAdditiveResult
    {
        bool CanAnyAccessChangeValue { get; }
        bool CanOverwriteDefaultValue { get; }
        JetBrains.ReSharper.Psi.Tree.IStatement AddValueInAssignment(JetBrains.ReSharper.Psi.Tree.IStatement assignment, JetBrains.ReSharper.Psi.ITypeOwner targetVar, JetBrains.ReSharper.Psi.Tree.IExpression valueExpr);
        JetBrains.ReSharper.Psi.Tree.IStatement AddValueInDeclaration(JetBrains.ReSharper.Psi.Tree.ITypeOwnerDeclaration declaration);
        bool CanMergeWithAssignmentOrInitialization(JetBrains.ReSharper.Psi.Tree.IExpression value);
        bool CanMoveDeclarationOrAssignment(JetBrains.ReSharper.Psi.Tree.IExpression value);
        JetBrains.ReSharper.Psi.Tree.IStatement CreateAddValueStatement(JetBrains.ReSharper.Psi.ITypeOwner additiveVariable);
        JetBrains.ReSharper.Psi.Tree.IStatement CreateSetValueStatement(JetBrains.ReSharper.Psi.ITypeOwner additiveVariable);
        bool IsDefaultVariableValue(JetBrains.ReSharper.Psi.Tree.IExpression value);
        JetBrains.ReSharper.Psi.Tree.IStatement SetValueInAssignment(JetBrains.ReSharper.Psi.Tree.IStatement assignment, JetBrains.ReSharper.Psi.ITypeOwner targetVar, JetBrains.ReSharper.Psi.Tree.IExpression valueExpr);
        JetBrains.ReSharper.Psi.Tree.IStatement SetValueInDeclaration(JetBrains.ReSharper.Psi.Tree.ITypeOwnerDeclaration declaration);
    }
    public interface IFunctionalQuery : JetBrains.ReSharper.Feature.Services.LinqTools.ToLinq.IQuery { }
    public interface IQuery
    {
        System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.Tree.IExpression> ExpressionsInLambdas { get; }
        System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.ILocalVariable> InputVariables { get; }
        string TestDump { get; }
    }
    public interface ISequenceQuery : JetBrains.ReSharper.Feature.Services.LinqTools.ToLinq.IQuery
    {
        bool AffectsIndex { get; }
    }
    public class static MatchAndConvert
    {
        public static bool Match(JetBrains.ReSharper.Psi.Tree.IStatement loop, JetBrains.ReSharper.Feature.Services.LinqTools.ToLinq.MatchAndConvert.Action action, out JetBrains.ReSharper.Feature.Services.LinqTools.ToLinq.SequencePartInfo sequencePartInfo, out JetBrains.ReSharper.Feature.Services.LinqTools.ToLinq.ActionPartInfo actionPartInfo) { }
        public enum Action
        {
            ExtractSequencePart = 0,
            Match = 1,
            ConvertToQuery = 2,
            ConvertToLoop = 3,
            ConvertToAny = 4,
        }
    }
    public class SequencePartInfo
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        public readonly JetBrains.ReSharper.Psi.ILocalVariable IndexVariable;
        public readonly System.Collections.Generic.IList<JetBrains.ReSharper.Feature.Services.LinqTools.ToLinq.ISequenceQuery> Queries;
        public readonly JetBrains.ReSharper.Psi.Tree.IStatementsRange RestPart;
        public readonly System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.ILocalVariable> WorkingVariables;
        public SequencePartInfo(System.Collections.Generic.IList<JetBrains.ReSharper.Feature.Services.LinqTools.ToLinq.ISequenceQuery> queries, System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.ILocalVariable> workingVariables, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.ILocalVariable indexVariable, JetBrains.ReSharper.Psi.Tree.IStatementsRange restPart) { }
        public void TestDump(System.IO.TextWriter writer) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.LiveTemplates.Builder
{
    
    public class CollectedFields
    {
        public CollectedFields(JetBrains.DocumentModel.DocumentRange documentRange) { }
        public JetBrains.DocumentModel.DocumentRange DocumentRange { get; }
        public System.Collections.Generic.ICollection<JetBrains.ReSharper.LiveTemplates.TemplateField> Fields { get; }
        public void AddField(JetBrains.ReSharper.LiveTemplates.TemplateField field) { }
        public string SuggestFieldName(string baseName) { }
    }
    [JetBrains.Annotations.BaseTypeRequiredAttribute(typeof(JetBrains.ReSharper.Feature.Services.LiveTemplates.Builder.IFieldEvaluatorFactory))]
    [System.AttributeUsageAttribute(System.AttributeTargets.Class | System.AttributeTargets.All)]
    public class FieldEvaluatorFactoryAttribute : JetBrains.ProjectModel.SolutionComponentAttribute { }
    public interface IFieldEvaluator : JetBrains.ReSharper.Psi.IRecursiveElementProcessor
    {
        OptionalField[] Fields { get; }
    }
    public interface IFieldEvaluatorFactory
    {
        JetBrains.ReSharper.Feature.Services.LiveTemplates.Builder.IFieldEvaluator CreateFieldEvaluator(JetBrains.ReSharper.Feature.Services.LiveTemplates.Builder.CollectedFields context);
    }
    public class TemplateBuilderResult
    {
        public TemplateBuilderResult(JetBrains.ReSharper.LiveTemplates.Templates.Template template, System.Collections.Generic.IList<JetBrains.ReSharper.Feature.Services.LiveTemplates.Builder.TemplateBuilderResult.OptionalField> fields, System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.LiveTemplates.Context.ITemplateContext> contextCandidates) { }
        public System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.LiveTemplates.Context.ITemplateContext> ContextCandidates { get; }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Feature.Services.LiveTemplates.Builder.TemplateBuilderResult.OptionalField> Fields { get; }
        public JetBrains.ReSharper.LiveTemplates.Templates.Template Template { get; }
        public string Apply(System.Collections.Generic.IList<JetBrains.ReSharper.Feature.Services.LiveTemplates.Builder.TemplateBuilderResult.OptionalField> optionalFields) { }
        public class OptionalField
        {
            public OptionalField(JetBrains.ReSharper.LiveTemplates.TemplateField templateField, System.Collections.Generic.IList<JetBrains.ReSharper.Feature.Services.LiveTemplates.Builder.TextChangeBase> changes) { }
            public System.Collections.Generic.IList<JetBrains.ReSharper.Feature.Services.LiveTemplates.Builder.TextChangeBase> Changes { get; }
            public JetBrains.ReSharper.LiveTemplates.TemplateField TemplateField { get; }
        }
    }
    public abstract class TextChangeBase
    {
        protected JetBrains.Util.TextRange myRange;
        protected TextChangeBase(JetBrains.Util.TextRange range) { }
        public static string Apply(string text, System.Collections.Generic.IList<JetBrains.ReSharper.Feature.Services.LiveTemplates.Builder.TextChangeBase> changes) { }
        public static string Apply(string text, System.Collections.Generic.IList<JetBrains.ReSharper.Feature.Services.LiveTemplates.Builder.TextChangeBase> changesToApply, System.Collections.Generic.IList<JetBrains.ReSharper.Feature.Services.LiveTemplates.Builder.TextChangeBase> changesToMap) { }
        protected abstract string GetNewText(string oldText);
        public void Map(JetBrains.Util.TextRange range) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.LiveTemplates.Context
{
    
    public class ErrorNodeFinder
    {
        public ErrorNodeFinder(JetBrains.ReSharper.Psi.Tree.ITreeNode stopper) { }
        public JetBrains.ReSharper.Psi.Tree.IErrorElement Error { get; }
        public bool FindLastError(JetBrains.ReSharper.Psi.Tree.ITreeNode node) { }
        public JetBrains.ReSharper.Psi.TreeTextRange GetBigErrorRange() { }
    }
    public class FileContextAcceptor : JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ScopedTemplateAcceptorBase
    {
        public FileContextAcceptor(JetBrains.ProjectModel.IProjectFile projectFile) { }
        public override string ToString() { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class FileNameScopeProvider : JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.IScopeProvider
    {
        public JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint CreateScope(System.Guid scopeGuid, string typeName, System.Collections.Generic.IEnumerable<JetBrains.Util.Pair<string, string>> customProperties) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint> ProvideScopePoints(JetBrains.ReSharper.Feature.Services.LiveTemplates.Context.TemplateAcceptanceContext context) { }
        public JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint ReadFromXml(System.Xml.XmlElement scopeElement) { }
    }
    public class FileNameTemplateContext : JetBrains.ReSharper.Feature.Services.LiveTemplates.Context.TemplateContext
    {
        public FileNameTemplateContext(string fileMask) { }
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint> ScopePoints { get; }
        public static JetBrains.ReSharper.Feature.Services.LiveTemplates.Context.FileNameTemplateContext ReadFromXml(System.Xml.XmlElement element) { }
    }
    public class InFileWithMask : JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.InAnyFile
    {
        public InFileWithMask(string fileMask) { }
        public string FileMask { get; }
        public override string PresentableShortName { get; }
        public override System.Collections.Generic.IEnumerable<JetBrains.Util.Pair<string, string>> EnumerateCustomProperties() { }
        public override System.Guid GetDefaultUID() { }
        public override bool IsSubsetOf(JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint other) { }
        public override string ToString() { }
        public override System.Xml.XmlElement WriteToXml(System.Xml.XmlElement element) { }
    }
    public class InProjectFile : JetBrains.ReSharper.Feature.Services.LiveTemplates.Context.InFileWithMask
    {
        public InProjectFile(JetBrains.ProjectModel.IProjectFile projectFile) { }
        public override System.Guid GetDefaultUID() { }
        public override bool IsSubsetOf(JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint other) { }
        public override string ToString() { }
    }
    public interface ITemplateContext
    {
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint> ScopePoints { get; }
    }
    public interface ITemplateContextFactory
    {
        JetBrains.ReSharper.Feature.Services.LiveTemplates.Context.ITemplateContext ReadFromXml(System.Xml.XmlElement element);
    }
    public interface ITemplateContextUI : System.IDisposable
    {
        System.Windows.Forms.Control ContextOptionsUI { get; }
        JetBrains.ReSharper.Feature.Services.LiveTemplates.Context.ITemplateContext TemplateContext { get; }
        string Title { get; }
        bool Valid { get; }
        public event System.EventHandler ValidChanged;
    }
    public class TemplateAcceptanceContext : JetBrains.Util.UserDataHolder
    {
        public TemplateAcceptanceContext(JetBrains.ProjectModel.ISolution solution, JetBrains.DocumentModel.IDocument document, int caretOffset) { }
        public TemplateAcceptanceContext(JetBrains.ProjectModel.IProjectFile projectFile) { }
        public TemplateAcceptanceContext(JetBrains.ProjectModel.IProjectFolder projectFolder) { }
        public int CaretOffset { get; }
        public JetBrains.DocumentModel.IDocument Document { get; }
        public JetBrains.ProjectModel.IProjectFile ProjectFile { get; }
        public JetBrains.ProjectModel.IProjectFolder ProjectFolder { get; }
        public JetBrains.ProjectModel.ISolution Solution { get; }
        public JetBrains.ReSharper.Psi.IPsiSourceFile SourceFile { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ProjectModel.IProject GetProject() { }
    }
    public abstract class TemplateContext : JetBrains.ReSharper.Feature.Services.LiveTemplates.Context.ITemplateContext
    {
        public abstract System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint> ScopePoints { get; }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class TemplateContextLoader
    {
        public TemplateContextLoader(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.LiveTemplates.Context.ITemplateContextFactory> contextFactories) { }
        public static JetBrains.ReSharper.Feature.Services.LiveTemplates.Context.TemplateContextLoader Instance { get; }
        public JetBrains.ReSharper.Feature.Services.LiveTemplates.Context.ITemplateContext ReadFromXml(System.Xml.XmlElement element) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.LiveTemplates.FileTemplates
{
    
    public class CustomLocationAutomation : JetBrains.ReSharper.Feature.Services.LiveTemplates.FileTemplates.SectionLocationAutomationBase
    {
        public CustomLocationAutomation(JetBrains.DataFlow.Lifetime lifetime, string configString, JetBrains.ReSharper.Feature.Services.LiveTemplates.FileTemplates.ITemplateSectionAutomation parentSection) { }
        public JetBrains.DataFlow.IProperty<string> Explanation { get; }
        public JetBrains.DataFlow.IProperty<string> File { get; }
        public JetBrains.DataFlow.IProperty<string> Folder { get; }
        public JetBrains.DataFlow.IProperty<string> Project { get; }
        public override string GetSerializedConfig() { }
        public override void InitializeDefaultValues() { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class CustomLocationSelector : JetBrains.ReSharper.Feature.Services.LiveTemplates.FileTemplates.ISectionFilenameSelector
    {
        public string Id { get; }
        public string Name { get; }
        public JetBrains.ReSharper.Feature.Services.LiveTemplates.FileTemplates.ISectionLocationAutomation CreateAutomation(JetBrains.DataFlow.Lifetime lifetime, string selectorConfig, JetBrains.ReSharper.Feature.Services.LiveTemplates.FileTemplates.ITemplateSectionAutomation parentSection) { }
        public static string ResolvePlaceholders(string source, JetBrains.Util.FileSystemPath mainPath) { }
        public static string ResolvePlaceholders(string source, string name, string fullname) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.LiveTemplates.FileTemplates.SuggestedSectionFile> SuggestFilenames(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint> mainScopePoints, JetBrains.ProjectModel.IProjectFolder mainFolder, JetBrains.ProjectModel.IProjectFile mainFile, string configString) { }
    }
    public class EnterNameForm : System.Windows.Forms.Form, JetBrains.CommonControls.Validation.IValidatorProvider
    {
        public EnterNameForm(JetBrains.ReSharper.LiveTemplates.Templates.Template template, JetBrains.ProjectModel.IProjectFolder projectFolder) { }
        public string EntityName { get; set; }
        public System.Collections.Generic.IEnumerable<JetBrains.CommonControls.Validation.IValidator> Validators { get; }
    }
    public class ExtensionFilenameSelector : JetBrains.ReSharper.Feature.Services.LiveTemplates.FileTemplates.ISectionFilenameSelector
    {
        public string Id { get; }
        public string Name { get; }
        public JetBrains.ReSharper.Feature.Services.LiveTemplates.FileTemplates.ISectionLocationAutomation CreateAutomation(JetBrains.DataFlow.Lifetime lifetime, string selectorConfig, JetBrains.ReSharper.Feature.Services.LiveTemplates.FileTemplates.ITemplateSectionAutomation parentSection) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.LiveTemplates.FileTemplates.SuggestedSectionFile> SuggestFilenames(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint> mainScopePoints, JetBrains.ProjectModel.IProjectFolder mainFolder, JetBrains.ProjectModel.IProjectFile mainFile, string config) { }
    }
    public class ExtensionLocationAutomation : JetBrains.ReSharper.Feature.Services.LiveTemplates.FileTemplates.SectionLocationAutomationBase
    {
        public ExtensionLocationAutomation(JetBrains.DataFlow.Lifetime lifetime, string selectorConfig) { }
        public JetBrains.DataFlow.IProperty<string> Extension { get; }
        public override string GetSerializedConfig() { }
    }
    [JetBrains.UI.Wpf.ViewAttribute(JetBrains.UI.Wpf.ViewKind.Wpf)]
    public class ExtensionLocationView : System.Windows.Controls.DockPanel, JetBrains.UI.Wpf.IView, JetBrains.UI.Wpf.IView<JetBrains.ReSharper.Feature.Services.LiveTemplates.FileTemplates.ExtensionLocationAutomation>, System.Windows.Markup.IComponentConnector
    {
        public ExtensionLocationView() { }
        public void InitializeComponent() { }
    }
    public class FileTemplateContext : JetBrains.ReSharper.Feature.Services.LiveTemplates.Context.TemplateContext
    {
        public FileTemplateContext(JetBrains.ReSharper.Feature.Services.LiveTemplates.Support.IFileTemplatesSupport fileTemplatesSupport) { }
        public JetBrains.ReSharper.Feature.Services.LiveTemplates.Support.IFileTemplatesSupport FileTemplatesSupport { get; }
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint> ScopePoints { get; }
        public void BindToSupport(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.LiveTemplates.Support.IFileTemplatesSupport> fileTemplatesSupports) { }
        public static JetBrains.ReSharper.Feature.Services.LiveTemplates.FileTemplates.FileTemplateContext ReadFromXml(System.Xml.XmlElement element) { }
    }
    public class static FileTemplateProperties
    {
        public static readonly JetBrains.ReSharper.Feature.Services.LiveTemplates.FileTemplates.FileTemplateProperties.Property<string> Extension;
        public static readonly JetBrains.ReSharper.Feature.Services.LiveTemplates.FileTemplates.FileTemplateProperties.Property<string> FileName;
        public static readonly JetBrains.ReSharper.Feature.Services.LiveTemplates.FileTemplates.FileTemplateProperties.Property<bool> ValidateFileName;
        public class Property<T>
        
        {
            public Property(string propertyName, System.Func<string, T> parse) { }
            public T Get(JetBrains.ReSharper.LiveTemplates.Templates.Template template) { }
            public void Set(JetBrains.ReSharper.LiveTemplates.Templates.Template template, T value) { }
        }
    }
    public class FileTemplatesContextForm : System.Windows.Forms.Form
    {
        public FileTemplatesContextForm(JetBrains.ReSharper.Feature.Services.LiveTemplates.Context.ITemplateContext templateContext) { }
        public JetBrains.ReSharper.Feature.Services.LiveTemplates.Context.ITemplateContext Context { get; }
        public JetBrains.ReSharper.Feature.Services.LiveTemplates.Support.IFileTemplatesSupport FileTemplatesSupport { get; }
    }
    public class FileTemplatesFamily : JetBrains.ReSharper.Feature.Services.LiveTemplates.Storages.TemplateFamily
    {
        public override JetBrains.ReSharper.Feature.Services.LiveTemplates.Settings.TemplateApplicability Applicability { get; }
        public void BindToSupports(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.LiveTemplates.Support.IFileTemplatesSupport> fileTemplatesSupports) { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class FileTemplatesManager
    {
        public static readonly JetBrains.Application.DataContext.DataConstant<System.Collections.Generic.ICollection<JetBrains.ReSharper.LiveTemplates.Templates.Template>> First20FileTemplatesForProjectFolderDataConstant;
        public FileTemplatesManager(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ActionManagement.IActionManager actionManager, JetBrains.DataFlow.IViewable<JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.IScopeCategoryUIProvider> scopeCategoryUIProviders, [JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.LiveTemplates.Support.IFileTemplatesSupport> fileTemplateSupporters, JetBrains.Application.Settings.ISettingsStore settingsStore, JetBrains.ReSharper.Feature.Services.LiveTemplates.Settings.StoredTemplatesProvider storedTemplatesProvider, JetBrains.Application.ChangeManager changeManager) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.LiveTemplates.FileTemplates.ISectionFilenameSelector> FileNameSelectors { get; set; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.LiveTemplates.Support.IFileTemplatesSupport> FileTemplatesSupports { get; }
        public static JetBrains.ReSharper.Feature.Services.LiveTemplates.FileTemplates.FileTemplatesManager Instance { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.LiveTemplates.Support.QuickListSupport> QuickListSupports { get; }
        public JetBrains.ReSharper.Feature.Services.LiveTemplates.Context.TemplateAcceptanceContext CreateAcceptanceContext(JetBrains.Application.DataContext.IDataContext dataContext) { }
        public virtual JetBrains.ProjectModel.IProjectFile CreateFileFromTemplate(string fileNameNoExtension, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IProjectFolder targetFolder, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.LiveTemplates.Templates.Template template, System.Action<JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotSession> init = null) { }
        public System.Collections.Generic.ICollection<JetBrains.ReSharper.LiveTemplates.Templates.Template> GetFileTemplatesForActions(JetBrains.Application.DataContext.IDataContext ctx) { }
    }
    [JetBrains.Application.Configuration.XmlConfigurableAttribute(ConfigurationResourceName="JetBrains.ReSharper.Feature.Services.src.LiveTemplates.FileTemplates.FileTemplate" +
        "sManager.xml")]
    public class FileTemplatesReader : JetBrains.ReSharper.Feature.Services.LiveTemplates.LiveTemplates.OldTemplatesReader, JetBrains.Application.Configuration.IXmlReadable, JetBrains.Application.Configuration.IXmlUpgradable
    {
        public FileTemplatesReader(JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.LiveTemplates.Support.IFileTemplatesSupport> fileTemplateSupporters, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.Application.Settings.ISettingsStore settingsStore, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.IViewable<JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.IScopeCategoryUIProvider> scopeCategoryUIProviders, JetBrains.Threading.IThreading threading) { }
        public JetBrains.ReSharper.Feature.Services.LiveTemplates.FileTemplates.FileTemplatesFamily FileTemplatesTemplateFamily { get; }
        public System.Collections.Generic.IEnumerable<string> LegacyTagNames { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.LiveTemplates.QuickLists.QuickListEx> LoadedQuickLists { get; }
        public override void ConfigureFromXml(System.Xml.XmlElement element) { }
        public void ReadFromXml(System.Xml.XmlElement element) { }
        public bool UpgradeFromXml(System.Xml.XmlElement element, System.Version version) { }
    }
    public class static FileTemplateUtil
    {
        public static bool CanCreateFileFromTemplate(JetBrains.Application.DataContext.IDataContext context) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ProjectModel.IProjectFolder GetProjectFolderFromContext([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.DataContext.IDataContext context) { }
        public static bool IsAvailable(JetBrains.Application.DataContext.IDataContext context, JetBrains.ReSharper.LiveTemplates.Templates.Template template) { }
    }
    public interface ISectionFilenameSelector
    {
        string Id { get; }
        string Name { get; }
        JetBrains.ReSharper.Feature.Services.LiveTemplates.FileTemplates.ISectionLocationAutomation CreateAutomation(JetBrains.DataFlow.Lifetime lifetime, string selectorConfig, JetBrains.ReSharper.Feature.Services.LiveTemplates.FileTemplates.ITemplateSectionAutomation parentSection);
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.LiveTemplates.FileTemplates.SuggestedSectionFile> SuggestFilenames(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint> mainScopePoints, JetBrains.ProjectModel.IProjectFolder mainFolder, JetBrains.ProjectModel.IProjectFile mainFile, string config);
    }
    public interface ISectionLocationAutomation : JetBrains.UI.Wpf.IAutomation, System.ComponentModel.INotifyPropertyChanged
    {
        JetBrains.DataFlow.SimpleSignal Changed { get; }
        string GetSerializedConfig();
        void InitializeDefaultValues();
    }
    public interface ITemplateSectionAutomation
    {
        JetBrains.DataFlow.IProperty<string> MainFilename { get; }
    }
    public abstract class SectionLocationAutomationBase : JetBrains.UI.Wpf.AAutomation, JetBrains.ReSharper.Feature.Services.LiveTemplates.FileTemplates.ISectionLocationAutomation, JetBrains.UI.Wpf.IAutomation, System.ComponentModel.INotifyPropertyChanged
    {
        public SectionLocationAutomationBase(JetBrains.DataFlow.Lifetime lifetime) { }
        public JetBrains.DataFlow.SimpleSignal Changed { get; }
        public virtual string GetSerializedConfig() { }
        public virtual void InitializeDefaultValues() { }
    }
    public struct SuggestedSectionFile
    {
        public string Filename;
        public JetBrains.ProjectModel.IProjectFolder ProjectFolder;
    }
}
namespace JetBrains.ReSharper.Feature.Services.LiveTemplates.Formatting
{
    
    public interface ITemplateFormatter
    {
        bool SupportsShorteningQualifiedReferences { get; }
        void BeforeFormatting(JetBrains.DocumentModel.DocumentRange documentRange, JetBrains.ProjectModel.ISolution solution);
        void ShortenQualifiedReferences(JetBrains.DocumentModel.DocumentRange documentRange, JetBrains.ProjectModel.ISolution solution);
    }
}
namespace JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots
{
    
    public class BeforeHotspotUpdateEventArgs : System.EventArgs
    {
        public readonly JetBrains.DataFlow.Lifetime UpdateLifetime;
        public BeforeHotspotUpdateEventArgs(JetBrains.DataFlow.Lifetime updateLifetime) { }
    }
    public class CurrentHotspotChangedEventArgs
    {
        public CurrentHotspotChangedEventArgs(JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.Hotspot oldHotspot) { }
        public JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.Hotspot OldHotspot { get; }
    }
    public class Hotspot
    {
        public Hotspot(JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.HotspotInfo hotspotInfo, JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotSession hotspotSession) { }
        public string CurrentValue { get; }
        public JetBrains.DocumentModel.IRangeMarker DriverRangeMarker { get; }
        public JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotExpression Expression { get; }
        public JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotSession HotspotSession { get; }
        public bool IsExpandAndSkip { get; }
        public bool IsStopAt { get; }
        public bool KeepExistingText { get; }
        public string Name { get; }
        public System.Collections.Generic.ICollection<JetBrains.DocumentModel.IRangeMarker> PassiveRangeMarkers { get; }
        public JetBrains.DocumentModel.IRangeMarker RangeMarker { get; }
        public System.Collections.Generic.List<JetBrains.DocumentModel.IRangeMarker> RangeMarkers { get; }
        public void Activate() { }
        public void AddRangeMarker(JetBrains.DocumentModel.IRangeMarker rangeMarker) { }
        public void AddTextProcessor(System.Func<JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.Hotspot, JetBrains.DocumentModel.DocumentRange, string, string> processor) { }
        public JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.HotspotItems Evaluate() { }
        public void Freeze() { }
        public JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.HotspotItems GetLookupItems() { }
        public bool IsRelated(JetBrains.DocumentModel.DocumentChange d) { }
        public bool IsValid() { }
        public bool QuickEvaluate() { }
        public void Unfreeze() { }
        public void Update(JetBrains.DocumentModel.DocumentChange d) { }
    }
    public class HotspotContext : JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotContext
    {
        public HotspotContext(JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotSessionContext hotspotSessionContext, JetBrains.DocumentModel.DocumentRange expressionRange, JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotSession hotspotSession) { }
        public JetBrains.DocumentModel.DocumentRange ExpressionRange { get; }
        public JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotSession HotspotSession { get; }
        public JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotSessionContext SessionContext { get; }
    }
    public class HotspotInfo
    {
        public HotspotInfo(JetBrains.ReSharper.LiveTemplates.TemplateField templateField, params JetBrains.DocumentModel.DocumentRange[] documentRanges) { }
        public HotspotInfo(JetBrains.ReSharper.LiveTemplates.TemplateField templateField, System.Collections.Generic.IEnumerable<JetBrains.DocumentModel.DocumentRange> documentRanges) { }
        public bool KeepExistingText { get; set; }
        public JetBrains.DocumentModel.DocumentRange[] Ranges { get; }
        public JetBrains.ReSharper.LiveTemplates.TemplateField TemplateField { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.DocumentModel.DocumentRange> EnumerateHotspotAndExpressionRanges() { }
    }
    public class HotspotItems
    {
        public static readonly JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.HotspotItems Empty;
        public HotspotItems([JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IList<JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem> items) { }
        public HotspotItems(System.Collections.Generic.IList<JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem> items, JetBrains.ReSharper.Feature.Services.Lookup.LookupFocusBehaviour focusBehaviour) { }
        public HotspotItems([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem item) { }
        public bool ActLikeCompletion { get; set; }
        public JetBrains.ReSharper.Feature.Services.Lookup.LookupFocusBehaviour FocusBehaviour { get; set; }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem> Items { get; }
        public virtual void OnTyping(JetBrains.ReSharper.Feature.Services.Lookup.Lookup lookup, char c) { }
    }
    public class HotspotSession : JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.HotspotSessionBase
    {
        public readonly JetBrains.DataFlow.ISignal<JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.CurrentHotspotChangedEventArgs> CurrentHotspotChanged2;
        public HotspotSession([JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.HotspotInfo> hotspots, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotSessionContext executionContext, JetBrains.Application.CommandProcessing.ICommandProcessor commandProcessor, JetBrains.Application.IShellLocks threading) { }
        public JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.HotspotItems CurrentLookupItems { get; }
        public System.Collections.Generic.ICollection<JetBrains.DocumentModel.IRangeMarker> MirrorMarkers { get; }
        public event System.Action<JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.HotspotSession, JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.Hotspot> CurrentHotspotChanged;
        public override void EnsureDocumentSubsribed(JetBrains.DocumentModel.IDocument document) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.HotspotSessionUi Execute(System.IDisposable tryFinallyCookie = null) { }
        public override void GoToNextHotspot() { }
        public void GoToPreviousHotspot() { }
    }
    public abstract class HotspotSessionBase : JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotSession
    {
        protected int CurrentHotspotIndex;
        protected readonly JetBrains.DataFlow.LifetimeDefinition LifetimeDef;
        protected readonly System.Collections.Generic.List<JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.Hotspot> myHotspots;
        protected HotspotSessionBase(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.HotspotInfo> hotspotInfos, JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotSessionContext executionContext) { }
        public System.Collections.Generic.IEnumerable<JetBrains.DocumentModel.IRangeMarker> AllDriverMarkers { get; }
        public JetBrains.DataFlow.ISignal<JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.BeforeHotspotUpdateEventArgs> BeforeHotspotUpdate { get; }
        public JetBrains.DataFlow.ISignal<JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.HotspotSessionClosedEventArgs> Closed { get; }
        public JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotSessionContext Context { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.Hotspot CurrentHotspot { get; set; }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.Hotspot> Hotspots { get; }
        public bool IsFinished { get; }
        public bool IsFrozen { get; set; }
        public bool IsUpdating { get; set; }
        public JetBrains.DataFlow.Lifetime Lifetime { get; }
        public event System.EventHandler HotspotUpdated;
        public virtual void EndSession(JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.TerminationType terminationType) { }
        public virtual void EnsureDocumentSubsribed(JetBrains.DocumentModel.IDocument document) { }
        protected JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.HotspotItems EvaluateHotspot(JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.Hotspot hotspot) { }
        public string GetVariableResult([System.ComponentModel.LocalizableAttribute(false)] string variableName) { }
        public abstract void GoToNextHotspot();
        protected bool HaveNextHotspot(out JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.Hotspot newHotspot, out int newIndex, out JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.HotspotItems lookupItems) { }
        public void NotifyDocumentIsUsed(JetBrains.DocumentModel.IDocument document) { }
        protected void OnHotspotUpdated() { }
        protected void SortHotspots() { }
        protected class UpdateHotspotAction
        {
            public UpdateHotspotAction(JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.HotspotSessionBase hotspotSession, JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.Hotspot hotspot, JetBrains.DocumentModel.DocumentChange args) { }
            public virtual void Execute() { }
        }
    }
    public class HotspotSessionClosedEventArgs : System.EventArgs
    {
        public readonly JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.TerminationType TerminationType;
        public HotspotSessionClosedEventArgs(JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.TerminationType terminationType) { }
    }
    public class HotspotSessionContext : JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotSessionContext
    {
        public HotspotSessionContext([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.ISolution solution, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DocumentModel.IDocument document, int startOffset, JetBrains.ReSharper.Feature.Services.Lookup.LookupItemsOwnerFactory lookupItemsOwnerFactory, bool textControlAllowed = True) { }
        public System.Collections.Generic.IEnumerable<JetBrains.DocumentModel.IDocument> Documents { get; }
        public bool IsTextControlAllowed { get; set; }
        public JetBrains.ReSharper.Feature.Services.Lookup.ILookupItemsOwner LookupItemsOwner { get; }
        public JetBrains.ProjectModel.ISolution Solution { get; }
        public int StartOffset { get; }
        public void EnsureDocumentIsUsed(JetBrains.DocumentModel.IDocument document) { }
    }
    public class HotspotSessionController
    {
        public HotspotSessionController(JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.HotspotInfo[] hotspotInfos, JetBrains.Util.TextRange endRange, JetBrains.TextControl.ITextControl editor, JetBrains.ReSharper.Feature.Services.LiveTemplates.LiveTemplates.LiveTemplatesManager.EscapeAction escapeAction, JetBrains.ProjectModel.ISolution solution) { }
        public void Finalize(JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotSessionContext executionContext, JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.TerminationType terminationType) { }
        public JetBrains.Util.TextRange GetFieldsRange(JetBrains.DocumentModel.IDocument document) { }
        public void Init(JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotSessionContext hotspotSessionContext) { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class HotspotSessionExecutor : JetBrains.Application.IObsoleteTearDown
    {
        public HotspotSessionExecutor(JetBrains.DataFlow.Lifetime lifetime, JetBrains.TextControl.Util.TextControlChangeUnitFactory textControlChangeUnitFactory, JetBrains.ActionManagement.IActionManager actionManager, JetBrains.Application.Settings.ISettingsStore settingsStore, JetBrains.Application.IShellLocks locks, JetBrains.ReSharper.Feature.Services.Lookup.ILookupWindowManager lookupWindowManager) { }
        public JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.HotspotSessionUi CurrentSession { get; }
        [System.ObsoleteAttribute("Inject HotspotSessionExecutor")]
        public static JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.HotspotSessionExecutor Instance { get; }
    }
    public class HotspotSessionNonInteractive : JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.HotspotSessionBase
    {
        public HotspotSessionNonInteractive(JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.HotspotInfo> hotspotInfos, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotSessionContext hotspotSessionContext, JetBrains.Application.CommandProcessing.ICommandProcessor commandProcessor, JetBrains.Threading.IThreading threading) { }
        public void Expand() { }
        public override void GoToNextHotspot() { }
    }
    public class HotspotSessionUi
    {
        public const string CURRENT_HOTSPOT_HIGHLIGHTER = "ReSharper LiveTemplates Current HotSpot";
        public const string CURRENT_HOTSPOT_MIRRORS_HIGHLIGHTER = "ReSharper LiveTemplates Current HotSpot mirror";
        public const string OTHER_HOTSPOTS_HIGHLIGHTER = "ReSharper LiveTemplates Inactive HotSpot";
        public HotspotSessionUi(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.HotspotSession hotspotSession, JetBrains.ActionManagement.IActionManager actionManager, JetBrains.Application.Settings.ISettingsStore settingsStore, JetBrains.Application.IShellLocks locks, JetBrains.ReSharper.Feature.Services.Lookup.ILookupWindowManager lookupWindowManager, JetBrains.IDE.EditorManager editorManager, JetBrains.DocumentManagers.DocumentManager documentManager) { }
        public JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.HotspotSession HotspotSession { get; }
        public event System.EventHandler Cancelled;
        public void CloseSession() { }
    }
    public class static HotspotSessionUtils
    {
        public static void AcceptSession(JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotSession session, JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotSessionContext executionContext) { }
    }
    public interface IHotspotContext
    {
        JetBrains.DocumentModel.DocumentRange ExpressionRange { get; }
        JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotSession HotspotSession { get; }
        JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotSessionContext SessionContext { get; }
    }
    public interface IHotspotExpression : System.ICloneable
    {
        string EvaluateQuickResult(JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotContext context);
        JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.HotspotItems GetLookupItems(JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotContext context);
        void HandleExpansion(JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotContext context);
        string Serialize();
    }
    public interface IHotspotExpressionAdvanced
    {
        System.Collections.Generic.IEnumerable<JetBrains.DocumentModel.IRangeMarker> GetAdditionalRangeMarkers();
        string GetPlaceholder(JetBrains.DocumentModel.IDocument document);
    }
    public interface IHotspotService
    {
        void AcceptSessionDocument(JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotSession hotspotSession, JetBrains.DocumentModel.IDocument document);
    }
    public interface IHotspotSession
    {
        System.Collections.Generic.IEnumerable<JetBrains.DocumentModel.IRangeMarker> AllDriverMarkers { get; }
        JetBrains.DataFlow.ISignal<JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.BeforeHotspotUpdateEventArgs> BeforeHotspotUpdate { get; }
        JetBrains.DataFlow.ISignal<JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.HotspotSessionClosedEventArgs> Closed { get; }
        JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotSessionContext Context { get; }
        JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.Hotspot CurrentHotspot { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.IList<JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.Hotspot> Hotspots { get; }
        bool IsFinished { get; }
        bool IsUpdating { get; set; }
        JetBrains.DataFlow.Lifetime Lifetime { get; }
        [JetBrains.Annotations.UsedImplicitlyAttribute()]
        public event System.EventHandler HotspotUpdated;
        void EndSession(JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.TerminationType terminationType);
        void EnsureDocumentSubsribed(JetBrains.DocumentModel.IDocument document);
        string GetVariableResult([System.ComponentModel.LocalizableAttribute(false)] string variableName);
        void GoToNextHotspot();
        void NotifyDocumentIsUsed(JetBrains.DocumentModel.IDocument document);
    }
    public interface IHotspotSessionContext
    {
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.IEnumerable<JetBrains.DocumentModel.IDocument> Documents { get; }
        bool IsTextControlAllowed { get; set; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Feature.Services.Lookup.ILookupItemsOwner LookupItemsOwner { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ProjectModel.ISolution Solution { get; }
        int StartOffset { get; }
        void EnsureDocumentIsUsed(JetBrains.DocumentModel.IDocument document);
    }
    public class LiveTemplateHotspotSessionController : JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.LiveTemplateSessionController
    {
        public LiveTemplateHotspotSessionController(JetBrains.ReSharper.LiveTemplates.Templates.Template template, JetBrains.ProjectModel.ISolution solution) { }
        public void Finalize(JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotSessionContext executionContext, JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.TerminationType terminationType) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.HotspotInfo> Init(string actionName, JetBrains.TextControl.ITextControl textControl, ref int startOffset, JetBrains.ProjectModel.ISolution solution, string alternativeText = null) { }
    }
    public abstract class LiveTemplateSessionController
    {
        protected LiveTemplateSessionController(JetBrains.ReSharper.LiveTemplates.Templates.Template template) { }
        protected JetBrains.ReSharper.LiveTemplates.Templates.Template Template { get; }
    }
    public class NameSuggestionsExpression : JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotExpression, System.ICloneable
    {
        public NameSuggestionsExpression(System.Collections.Generic.ICollection<string> names) { }
        public object Clone() { }
        public string EvaluateQuickResult(JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotContext context) { }
        public JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.HotspotItems GetLookupItems(JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotContext context) { }
        public void HandleExpansion(JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotContext context) { }
        public string Serialize() { }
    }
    public class ReformatAndShortenBulkOperation
    {
        public ReformatAndShortenBulkOperation(JetBrains.ReSharper.LiveTemplates.Templates.Template template, JetBrains.ProjectModel.ISolution solution, JetBrains.DocumentModel.IDocument document, JetBrains.DocumentModel.IRangeMarker templateRangeMarker, System.Collections.Generic.IEnumerable<JetBrains.DocumentModel.IRangeMarker> nonFormattableMarkers) { }
        public void ExecuteBulkOperation() { }
    }
    public abstract class SuggestedNameTemplateExpression : JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotExpression, System.ICloneable
    {
        protected SuggestedNameTemplateExpression(string suggestedName) { }
        protected virtual bool LookupSuggestedNameIfEmpty { get; }
        public object Clone() { }
        public virtual string EvaluateQuickResult(JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotContext context) { }
        public JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.HotspotItems GetLookupItems(JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotContext context) { }
        protected abstract System.Collections.Generic.IList<JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem> GetLookupItemsImpl(JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotContext context);
        public virtual void HandleExpansion(JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotContext context) { }
        public string Serialize() { }
    }
    public enum TerminationType
    {
        Cancelled = 0,
        Terminated = 1,
        Finished = 2,
    }
    public sealed class TextHotspotExpression : JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotExpression, System.ICloneable
    {
        public TextHotspotExpression(System.Collections.Generic.IList<string> text) { }
        public object Clone() { }
        public string EvaluateQuickResult(JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotContext context) { }
        public JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.HotspotItems GetLookupItems(JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotContext context) { }
        public void HandleExpansion(JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotContext context) { }
        public string Serialize() { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.LiveTemplates.LiveTemplates
{
    
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.KnownLanguage))]
    public class LanguageCaseProvider
    {
        public virtual bool IsCaseSensitive() { }
    }
    public class LiveTemplatesFamily : JetBrains.ReSharper.Feature.Services.LiveTemplates.Storages.TemplateFamily
    {
        public LiveTemplatesFamily() { }
        public override JetBrains.ReSharper.Feature.Services.LiveTemplates.Settings.TemplateApplicability Applicability { get; }
        public System.Collections.Generic.JetHashSet<JetBrains.ReSharper.Feature.Services.LiveTemplates.QuickLists.TemplateReference> DisabledTemplates { get; }
        public override void ReadFromXml(System.Xml.XmlElement element) { }
        public override void UpgradeFromXml(System.Xml.XmlElement element, System.Version version) { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class LiveTemplatesManager
    {
        public LiveTemplatesManager(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.CommandProcessing.ICommandProcessor commandProcessor, JetBrains.Application.IShellLocks threading, JetBrains.ReSharper.Psi.ILanguageManager languageManager, JetBrains.ReSharper.Feature.Services.LiveTemplates.Settings.StoredTemplatesProvider storedTemplatesProvider, JetBrains.ProjectModel.Settings.Cache.SettingsCacheManager settingsCacheManager) { }
        [System.ObsoleteAttribute("Inject it!")]
        public static JetBrains.ReSharper.Feature.Services.LiveTemplates.LiveTemplates.LiveTemplatesManager Instance { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        [JetBrains.Annotations.PureAttribute()]
        public JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.HotspotSession CreateHotspotSessionAtopExistingText([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.ISolution solution, JetBrains.Util.TextRange endSelectionRange, [JetBrains.Annotations.NotNullAttribute()] JetBrains.TextControl.ITextControl textControl, JetBrains.ReSharper.Feature.Services.LiveTemplates.LiveTemplates.LiveTemplatesManager.EscapeAction escapeAction, [JetBrains.Annotations.NotNullAttribute()] params JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.HotspotInfo[] hotspotInfos) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.HotspotSession CreateHotspotSessionFromTemplate(JetBrains.ReSharper.LiveTemplates.Templates.Template template, JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl, System.Action<JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotSession> init = null) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.HotspotSession CreateHotspotSessionFromTemplate(string actionName, JetBrains.ReSharper.LiveTemplates.Templates.Template template, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.ISolution solution, [JetBrains.Annotations.NotNullAttribute()] JetBrains.TextControl.ITextControl textControl, System.Action<JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotSession> init = null) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.HotspotSession CreateHotspotSessionFromTemplate(string actionName, JetBrains.ReSharper.LiveTemplates.Templates.Template template, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.ISolution solution, [JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IDictionary<JetBrains.TextControl.ITextControl, JetBrains.ReSharper.LiveTemplates.Templates.TemplateSection> textControlTexts, System.Action<JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotSession> init = null) { }
        public void ExpandTemplateInDocument([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.LiveTemplates.Templates.Template template, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.ISolution solution, JetBrains.DocumentModel.IDocument document, int startOffset) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.LiveTemplates.Templates.Template> GetAvailableTemplates(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl, bool matchPrefix) { }
        public static string GetPrefix(JetBrains.DocumentModel.IDocument document, int caretOffset) { }
        public static string GetPrefix(JetBrains.DocumentModel.IDocument document, int caretOffset, params char[] allowedChars) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.LiveTemplates.Templates.Template> GetTemplates(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        public void ResetTemplatesCache() { }
        public enum EscapeAction
        {
            RestoreToOriginalText = 0,
            LeaveTextAndCaret = 1,
        }
    }
    [JetBrains.Application.Configuration.XmlConfigurableAttribute(ConfigurationResourceName="JetBrains.ReSharper.Feature.Services.src.LiveTemplates.LiveTemplates.LiveTemplate" +
        "sManager.xml")]
    public class LiveTemplatesReader : JetBrains.ReSharper.Feature.Services.LiveTemplates.LiveTemplates.OldTemplatesReader, JetBrains.Application.Configuration.IXmlReadable, JetBrains.Application.Configuration.IXmlUpgradable
    {
        public LiveTemplatesReader(JetBrains.Application.Settings.ISettingsStore settingsStore, JetBrains.Threading.IThreading threading) { }
        public System.Collections.Generic.IEnumerable<string> LegacyTagNames { get; }
        public override void ConfigureFromXml(System.Xml.XmlElement element) { }
        public void ReadFromXml(System.Xml.XmlElement element) { }
        public bool UpgradeFromXml(System.Xml.XmlElement element, System.Version version) { }
    }
    public abstract class OldTemplatesReader : JetBrains.Application.Configuration.IXmlConfigurable
    {
        protected bool myDumpingDefaults;
        public void ConfigureAndDump() { }
        public abstract void ConfigureFromXml(System.Xml.XmlElement element);
    }
}
namespace JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros
{
    
    public class ConstantMacroParameter : JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.IMacroParameterValue, System.ICloneable
    {
        public ConstantMacroParameter([JetBrains.Annotations.NotNullAttribute()] string value) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public string Value { get; }
        public object Clone() { }
        [JetBrains.Annotations.NotNullAttribute()]
        public string GetText([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotContext context) { }
        public JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.IMacroParameterValueNew GetValue(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotSession session) { }
    }
    public class ConstantMacroParameterValue : JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.IMacroParameterValueNew
    {
        public ConstantMacroParameterValue(string value) { }
        public string GetValue() { }
    }
    public class DelegateMacroParameter : JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.IMacroParameterValueNew
    {
        public DelegateMacroParameter([JetBrains.Annotations.NotNullAttribute()] System.Func<string> returnValue) { }
        public string GetValue() { }
    }
    [JetBrains.Annotations.UsedImplicitlyAttribute()]
    public class EverywhereImpl : JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.MacroImplementationScopeProviderBase
    {
        public EverywhereImpl() { }
    }
    [JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.MacroDefinitionAttribute("guessElementType", LongDescription="Analyzes code and guesses type of element of a collection.", ShortDescription="Guess element type of collection represented by {#0:variable}")]
    public class GuessElementTypeMacroDef : JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.Implementations.TypeSuggestionMacroDefBase { }
    [JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.MacroImplementationAttribute(Definition=typeof(JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.GuessElementTypeMacroDef))]
    public class GuessElementTypeMacroImpl : JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.Implementations.TypeSuggestionMacroImplBase
    {
        public GuessElementTypeMacroImpl(JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.MacroParameterValueCollection arguments) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        protected override System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.IType> GuessTypes(string variable, JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotContext context) { }
    }
    public interface IMacroCallExpression : JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotExpression, System.ICloneable
    {
        void AddParameter(JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.IMacroParameterValue parameter);
        string GetPlaceholder(JetBrains.DocumentModel.IDocument document);
    }
    public interface IMacroDefinition
    {
        JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.ParameterInfo[] Parameters { get; }
        string GetPlaceholder(JetBrains.DocumentModel.IDocument document, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.IMacroParameterValue> parameters);
    }
    public interface IMacroImplementation
    {
        string EvaluateQuickResult(JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotContext context);
        JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.HotspotItems GetLookupItems(JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotContext context);
        bool HandleExpansion(JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotContext context);
    }
    public interface IMacroImplementationScopeProvider
    {
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint> GetScopes();
    }
    public interface IMacroParameterValue : System.ICloneable
    {
        [System.ObsoleteAttribute("GetValue shall be used instead")]
        string GetText(JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotContext context);
        JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.IMacroParameterValueNew GetValue(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotSession session);
    }
    public interface IMacroParameterValueNew
    {
        string GetValue();
    }
    public interface IMacroUtil
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.IDeclaredElement AsDeclaredElement([JetBrains.Annotations.NotNullAttribute()] string text, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotContext context);
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Tree.IExpression AsExpression([JetBrains.Annotations.NotNullAttribute()] string text, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotContext context);
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.IType AsType([JetBrains.Annotations.NotNullAttribute()] string typeName, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotContext hotspotContext);
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IDeclaredElement CreateVariableDeclaredElement([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotContext hotspotContext);
        [JetBrains.Annotations.NotNullAttribute()]
        string GetDefaultNamespace([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotContext context);
        [JetBrains.Annotations.CanBeNullAttribute()]
        System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.IType> GetElementTypes([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.IExpression collectionExpression);
        [JetBrains.Annotations.CanBeNullAttribute()]
        System.Collections.Generic.IList<JetBrains.ReSharper.Psi.IType> GetExpectedTypes([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotContext context);
        [JetBrains.Annotations.CanBeNullAttribute()]
        System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.IType> GetKeyTypes([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.IExpression collectionExpression);
        [JetBrains.Annotations.CanBeNullAttribute()]
        System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.IType> GetValueTypes([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.IExpression collectionExpression);
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Services.CodeInsight.VariablesList GetVisibleVariables([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotContext hotspotContext);
        void SortNames([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotContext context, [JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.List<string> names);
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.IList<string> SuggestNames([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotContext context);
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.IList<JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem> SuggestVariableTypes(JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotContext context);
    }
    public class MacroCallExpressionNew : JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotExpression, JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.IMacroCallExpression, System.ICloneable
    {
        public MacroCallExpressionNew(JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.IMacroDefinition definition) { }
        public JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.IMacroDefinition Definition { get; }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.IMacroParameterValue> Parameters { get; }
        public void AddParameter(JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.IMacroParameterValue parameter) { }
        public void AddParameters(System.Collections.Generic.IList<string> parameters) { }
        public object Clone() { }
        public string EvaluateQuickResult(JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotContext context) { }
        public JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.HotspotItems GetLookupItems(JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotContext context) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.IMacroParameterValueNew> GetParameterValues(JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotSession session) { }
        public string GetPlaceholder(JetBrains.DocumentModel.IDocument document) { }
        public void HandleExpansion(JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotContext context) { }
        public string Serialize() { }
        public void SetParameterValue(int parameter, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.IMacroParameterValue val) { }
    }
    [JetBrains.Annotations.BaseTypeRequiredAttribute(typeof(JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.IMacroDefinition))]
    [JetBrains.Annotations.MeansImplicitUseAttribute()]
    [System.AttributeUsageAttribute(System.AttributeTargets.Class | System.AttributeTargets.All, AllowMultiple=false)]
    public class MacroDefinitionAttribute : JetBrains.Application.ShellComponentAttribute
    {
        public MacroDefinitionAttribute(string name) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public string LongDescription { get; set; }
        public string Name { get; set; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public string ShortDescription { get; set; }
    }
    [JetBrains.Annotations.BaseTypeRequiredAttribute(typeof(JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.IMacroImplementation))]
    [JetBrains.Annotations.MeansImplicitUseAttribute()]
    [System.AttributeUsageAttribute(System.AttributeTargets.Class | System.AttributeTargets.All, AllowMultiple=false)]
    public class MacroImplementationAttribute : JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.MacroImplementationAttributeBase
    {
        public MacroImplementationAttribute() { }
        public bool IsExpandAndSkip { get; set; }
        public System.Type ScopeProvider { get; set; }
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint> GetScopes() { }
    }
    public abstract class MacroImplementationAttributeBase : JetBrains.Application.ShellComponentAttribute
    {
        public System.Type Definition { get; set; }
        public abstract System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint> GetScopes();
    }
    public abstract class MacroImplementationScopeProviderBase : JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.IMacroImplementationScopeProvider
    {
        protected MacroImplementationScopeProviderBase(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint> scopes) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint> GetScopes() { }
    }
    public class MacroLexerGenerated : JetBrains.ReSharper.Psi.Parsing.IIncrementalLexer, JetBrains.ReSharper.Psi.Parsing.ILexer, JetBrains.ReSharper.Psi.Parsing.ILexerEx
    {
        protected JetBrains.ReSharper.Psi.Parsing.TokenNodeType currTokenType;
        protected const int YYINITIAL = 0;
        public MacroLexerGenerated(JetBrains.Text.IBuffer buffer) { }
        public MacroLexerGenerated(JetBrains.Text.IBuffer buffer, int startOffset, int endOffset) { }
        public JetBrains.Text.IBuffer Buffer { get; }
        public object CurrentPosition { get; set; }
        public int EOFPos { get; }
        public int LexemIndent { get; }
        public uint LexerStateEx { get; }
        public int TokenEnd { get; }
        public int TokenStart { get; }
        public JetBrains.ReSharper.Psi.Parsing.TokenNodeType TokenType { get; }
        public JetBrains.ReSharper.Psi.Parsing.TokenNodeType _locateToken() { }
        public void Advance() { }
        protected void locateToken() { }
        protected JetBrains.ReSharper.Psi.Parsing.TokenNodeType makeToken(JetBrains.ReSharper.Psi.Parsing.TokenNodeType type) { }
        public void Start() { }
        public void Start(int startOffset, int endOffset, uint state) { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class MacroManager
    {
        public MacroManager(JetBrains.DataFlow.Lifetime lifetime, JetBrains.DataFlow.IViewable<JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.IMacroDefinition> macroDefinitions, JetBrains.DataFlow.IViewable<JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.IMacroImplementation> macroImplementations, JetBrains.Application.Components.IComponentContainer containerForFactoring) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.IMacroDefinition> Definitions { get; }
        public static JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.MacroManager Instance { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.IMacroImplementation CreateImplementation(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.IMacroDefinition def, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint> actualScopePoints, JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotSession session, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.IMacroParameterValueNew> values) { }
        public static JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.MacroDefinitionAttribute GetAttribute(JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.IMacroDefinition macro) { }
        public static JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.MacroImplementationAttribute GetAttribute(JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.IMacroImplementation macro) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.IMacroDefinition GetMacroDefinition(string macroName) { }
        public string GetMacroName(JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.IMacroDefinition macro) { }
        public string GetMacroShortDescription(JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.IMacroDefinition macro) { }
    }
    public class MacroParameterValueCollection : System.Collections.Generic.List<JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.IMacroParameterValueNew> { }
    public class static MacroParameterValueCollectionEx
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.IMacroParameterValueNew OptionalFirstOrDefault([JetBrains.Annotations.CanBeNullAttribute()] this JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.MacroParameterValueCollection c) { }
        public static JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.MacroParameterValueCollection ToParameters(this System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.IMacroParameterValueNew> l) { }
    }
    public class static MacroParser
    {
        public static JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotExpression Parse(string expression) { }
        public static JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.IMacroParameterValue ParseParameter(string parameter) { }
    }
    public class static MacroUtil
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Psi.Tree.IFile GetFile([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotContext hotspotContext) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.ReSharper.Psi.PsiLanguageType GetLanguageType([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotContext context) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.IMacroUtil GetMacroUtil([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.PsiLanguageType languageType) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.IMacroUtil GetMacroUtil([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotContext context) { }
        public static bool IsImplicitlyConvertibleTo([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IType from, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IType to, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.PsiLanguageType languageType) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.HotspotItems SimpleEvaluateResult(string text) { }
    }
    public abstract class MacroUtilBase : JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.IMacroUtil
    {
        protected MacroUtilBase(JetBrains.ReSharper.Psi.PsiLanguageType language) { }
        protected JetBrains.ReSharper.Psi.PsiLanguageType LanguageType { get; }
        public abstract JetBrains.ReSharper.Psi.IDeclaredElement AsDeclaredElement(string text, JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotContext context);
        public JetBrains.ReSharper.Psi.Tree.IExpression AsExpression(string text, JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotContext context) { }
        public JetBrains.ReSharper.Psi.IType AsType(string typeName, JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotContext hotspotContext) { }
        protected abstract JetBrains.ReSharper.Psi.Tree.IExpression CreateExpression(JetBrains.ReSharper.Psi.Modules.IPsiModule module, string text);
        public abstract JetBrains.ReSharper.Psi.IDeclaredElement CreateVariableDeclaredElement(JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotContext hotspotContext);
        public virtual string GetDefaultNamespace(JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotContext context) { }
        public virtual System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.IType> GetElementTypes(JetBrains.ReSharper.Psi.Tree.IExpression collectionExpression) { }
        protected virtual System.Collections.Generic.IList<JetBrains.ReSharper.Psi.IType> GetExpectedConcreteTypes(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Psi.IType> GetExpectedTypes(JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotContext context) { }
        protected virtual System.Collections.Generic.IList<JetBrains.ReSharper.Psi.ExpectedTypes.ExpectedType> GetExpectedTypes(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public virtual System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.IType> GetKeyTypes(JetBrains.ReSharper.Psi.Tree.IExpression collectionExpression) { }
        protected static System.Collections.Generic.ICollection<JetBrains.Util.Pair<JetBrains.ReSharper.Psi.IType, JetBrains.ReSharper.Psi.IType>> GetKeyValueTypePairs(JetBrains.ReSharper.Psi.IDeclaredType declaredType, JetBrains.ReSharper.Psi.Modules.IPsiModule module) { }
        public virtual System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.IType> GetValueTypes(JetBrains.ReSharper.Psi.Tree.IExpression collectionExpression) { }
        public JetBrains.ReSharper.Psi.Services.CodeInsight.VariablesList GetVisibleVariables(JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotContext hotspotContext) { }
        protected string LookupDefaultNamespace(JetBrains.ProjectModel.IProjectFolder folder, JetBrains.ProjectModel.IProjectItem excludeItem) { }
        protected bool PerformActionOnNode<T>([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotContext context, [JetBrains.Annotations.NotNullAttribute()] System.Action<T> action)
            where T :  class, JetBrains.ReSharper.Psi.Tree.ITreeNode { }
        public abstract void SortNames(JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotContext context, System.Collections.Generic.List<string> names);
        public System.Collections.Generic.IList<string> SuggestNames(JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotContext context) { }
        [JetBrains.Annotations.NotNullAttribute()]
        protected abstract System.Collections.Generic.IList<string> SuggestNamesForIdentifier(JetBrains.ReSharper.Psi.Tree.IIdentifier treeNode);
        public virtual System.Collections.Generic.IList<JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem> SuggestVariableTypes(JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotContext context) { }
    }
    public class ParameterInfo
    {
        public ParameterInfo(JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.ParameterType parameterType) { }
        public JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.ParameterType ParameterType { get; }
    }
    public enum ParameterType
    {
        String = 0,
        Type = 1,
        VariableReference = 2,
    }
    public abstract class SimpleMacroDefinition : JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.IMacroDefinition
    {
        public virtual JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.ParameterInfo[] Parameters { get; }
        public virtual string GetPlaceholder(JetBrains.DocumentModel.IDocument document, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.IMacroParameterValue> parameters) { }
    }
    public abstract class SimpleMacroImplementation : JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.IMacroImplementation
    {
        public virtual string EvaluateQuickResult(JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotContext context) { }
        public virtual JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.HotspotItems GetLookupItems(JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotContext context) { }
        public virtual bool HandleExpansion(JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotContext context) { }
    }
    [JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.MacroDefinitionAttribute("suggestIndexVariable", LongDescription="Suggests non-used name which can be used for an index variable at the evaluation " +
        "point.", ShortDescription="Suggest name for an index variable")]
    public class SuggestIndexVariableNameMacroDef : JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.SimpleMacroDefinition { }
    [JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.MacroImplementationAttribute(Definition=typeof(JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.SuggestIndexVariableNameMacroDef))]
    public class SuggestIndexVariableNameMacroImpl : JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.SuggestVariableNameMacroImplBase
    {
        protected override System.Collections.Generic.IEnumerable<JetBrains.Util.Pair<string, bool>> GenerateNames(JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotContext context) { }
    }
    public abstract class SuggestVariableNameMacroImplBase : JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.SimpleMacroImplementation
    {
        [JetBrains.Annotations.NotNullAttribute()]
        protected abstract System.Collections.Generic.IEnumerable<JetBrains.Util.Pair<string, bool>> GenerateNames([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotContext context);
        public override JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.HotspotItems GetLookupItems(JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotContext context) { }
    }
    public class VariableMacroParameter : JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.IMacroParameterValue, System.ICloneable
    {
        public VariableMacroParameter(string variableName) { }
        public string VariableName { get; }
        public object Clone() { }
        public string GetText(JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotContext context) { }
        public JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.IMacroParameterValueNew GetValue(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotSession session) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.Implementations
{
    
    [JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.MacroDefinitionAttribute("arrayVariable", LongDescription="Suggests variable which type is array type", ShortDescription="Suggest an array variable")]
    public class ArrayVariableMacroDef : JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.SimpleMacroDefinition { }
    [JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.MacroImplementationAttribute(Definition=typeof(JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.Implementations.ArrayVariableMacroDef))]
    public class ArrayVariableMacroImpl : JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.SimpleMacroImplementation
    {
        public override JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.HotspotItems GetLookupItems(JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotContext context) { }
    }
    public abstract class BaseCompletionMacroImpl : JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.SimpleMacroImplementation
    {
        protected abstract JetBrains.ReSharper.Feature.Services.CodeCompletion.CodeCompletionType CompletionType { get; }
        public override bool HandleExpansion(JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotContext context) { }
    }
    [JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.MacroDefinitionAttribute("complete", LongDescription="Show basic code completion list at the point where the variable is evaluated", ShortDescription="Execute basic completion")]
    public class BasicCompletionMacroDef : JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.SimpleMacroDefinition { }
    [JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.MacroImplementationAttribute(Definition=typeof(JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.Implementations.BasicCompletionMacroDef))]
    public class BasicCompletionMacroImpl : JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.Implementations.BaseCompletionMacroImpl
    {
        protected override JetBrains.ReSharper.Feature.Services.CodeCompletion.CodeCompletionType CompletionType { get; }
    }
    [JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.MacroDefinitionAttribute("fixedTypeName", LongDescription="Evaluates to selected type name.", ShortDescription="Insert reference to {#0:type}")]
    public class BindToTypeMacroDef : JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.SimpleMacroDefinition
    {
        public override JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.ParameterInfo[] Parameters { get; }
    }
    [JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.MacroImplementationAttribute(Definition=typeof(JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.Implementations.BindToTypeMacroDef))]
    public class BindToTypeMacroImpl : JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.SimpleMacroImplementation
    {
        public BindToTypeMacroImpl(JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.MacroParameterValueCollection arguments) { }
        public override string EvaluateQuickResult(JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotContext context) { }
        public override JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.HotspotItems GetLookupItems(JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotContext context) { }
    }
    [JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.MacroDefinitionAttribute("capitalize", LongDescription="Capitalizes string value (i.e. changes case of the first letter to upper)", ShortDescription="Value of {#0:another variable} with the first character in upper case")]
    public class CapitalizeMacroDef : JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.SimpleMacroDefinition
    {
        public override JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.ParameterInfo[] Parameters { get; }
    }
    [JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.MacroImplementationAttribute(Definition=typeof(JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.Implementations.CapitalizeMacroDef))]
    public class CapitalizeMacroImpl : JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.SimpleMacroImplementation
    {
        public CapitalizeMacroImpl(JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.MacroParameterValueCollection arguments) { }
        public override string EvaluateQuickResult(JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotContext context) { }
    }
    [JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.MacroDefinitionAttribute("clipboard", LongDescription="Evaluates to current textual clipboard content", ShortDescription="Clipboard content")]
    public class ClipboardContentsMacro : JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.SimpleMacroDefinition { }
    [JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.MacroImplementationAttribute(Definition=typeof(JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.Implementations.ClipboardContentsMacro))]
    public class ClipboardContentsMacroImpl : JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.SimpleMacroImplementation
    {
        public override JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.HotspotItems GetLookupItems(JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotContext context) { }
    }
    [JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.MacroDefinitionAttribute("constant", LongDescription="Evaluates to the specified constant value.", ShortDescription="{#0:Constant value}")]
    public class ConstantMacroDef : JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.SimpleMacroDefinition
    {
        public override JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.ParameterInfo[] Parameters { get; }
        public override string GetPlaceholder(JetBrains.DocumentModel.IDocument document, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.IMacroParameterValue> parameters) { }
    }
    [JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.MacroImplementationAttribute(Definition=typeof(JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.Implementations.ConstantMacroDef), ScopeProvider=typeof(JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.EverywhereImpl))]
    public class ConstantMacroImpl : JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.SimpleMacroImplementation
    {
        public ConstantMacroImpl(JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.MacroParameterValueCollection parameters) { }
        public override string EvaluateQuickResult(JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotContext context) { }
    }
    [JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.MacroDefinitionAttribute("typeMember", LongDescription="Evaluates to short name of the most inner containing type member (e.g. method or " +
        "property).", ShortDescription="Containing type member name")]
    public class ContainingTypeMemberNameMacroDef : JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.SimpleMacroDefinition { }
    [JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.MacroImplementationAttribute(Definition=typeof(JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.Implementations.ContainingTypeMemberNameMacroDef))]
    public class ContainingTypeMemberNameMacroImpl : JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.SimpleMacroImplementation
    {
        public override JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.HotspotItems GetLookupItems(JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotContext context) { }
    }
    [JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.MacroDefinitionAttribute("typeName", LongDescription="Evaluates to short name of the most inner containing type.", ShortDescription="Containing type name")]
    public class ContainingTypeNameMacroDef : JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.SimpleMacroDefinition { }
    [JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.MacroImplementationAttribute(Definition=typeof(JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.Implementations.ContainingTypeNameMacroDef))]
    public class ContainingTypeNameMacroImpl : JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.SimpleMacroImplementation
    {
        public override JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.HotspotItems GetLookupItems(JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotContext context) { }
    }
    [JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.MacroDefinitionAttribute("context", LongDescription="Provides list of items describing current context. This includes file name, conta" +
        "ining type name, namespace name, etc.", ShortDescription="Provides list of items describing current context")]
    public class ContextMacroDef : JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.SimpleMacroDefinition { }
    [JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.MacroImplementationAttribute(Definition=typeof(JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.Implementations.ContextMacroDef), ScopeProvider=typeof(JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.EverywhereImpl))]
    public class ContextMacroImpl : JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.SimpleMacroImplementation
    {
        public ContextMacroImpl(JetBrains.ReSharper.Feature.Services.LiveTemplates.LiveTemplates.LiveTemplatesManager manager, JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotSession session) { }
        public override JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.HotspotItems GetLookupItems(JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotContext context) { }
    }
    [JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.MacroDefinitionAttribute("getCreationTime", LongDescription="Evaluates file creation date and time", ShortDescription="Date and time when the file was created in specified {#0:format}")]
    public class CreatedDateTimeMacroDef : JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.SimpleMacroDefinition
    {
        public override JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.ParameterInfo[] Parameters { get; }
    }
    [JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.MacroImplementationAttribute(Definition=typeof(JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.Implementations.CreatedDateTimeMacroDef))]
    public class CreatedDateTimeMacroImpl : JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.SimpleMacroImplementation
    {
        public CreatedDateTimeMacroImpl(JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.MacroParameterValueCollection arguments) { }
        public override JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.HotspotItems GetLookupItems(JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotContext context) { }
    }
    [JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.MacroDefinitionAttribute("getCurrentDate", LongDescription="Evaluates current date", ShortDescription="Current date in specified {#0:format}")]
    public class CurrentDateMacroDef : JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.SimpleMacroDefinition
    {
        public override JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.ParameterInfo[] Parameters { get; }
    }
    [JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.MacroImplementationAttribute(Definition=typeof(JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.Implementations.CurrentDateMacroDef))]
    public class CurrentDateMacroImpl : JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.SimpleMacroImplementation
    {
        public CurrentDateMacroImpl(JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.MacroParameterValueCollection arguments) { }
        public override JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.HotspotItems GetLookupItems(JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotContext context) { }
    }
    [JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.MacroDefinitionAttribute("getCurrentTime", LongDescription="Evaluates current date", ShortDescription="Current date and time in specified {#0:format}")]
    public class CurrentDateTimeMacroDef : JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.SimpleMacroDefinition
    {
        public override JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.ParameterInfo[] Parameters { get; }
    }
    [JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.MacroImplementationAttribute(Definition=typeof(JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.Implementations.CurrentDateTimeMacroDef))]
    public class CurrentDateTimeMacroImpl : JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.SimpleMacroImplementation
    {
        public CurrentDateTimeMacroImpl(JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.MacroParameterValueCollection arguments) { }
        public override JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.HotspotItems GetLookupItems(JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotContext context) { }
    }
    [JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.MacroDefinitionAttribute("getCurrentNamespace", LongDescription="Evaluates name of the containing namespace", ShortDescription="Containing namespace")]
    public class CurrentNamespaceMacroDef : JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.SimpleMacroDefinition { }
    [JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.MacroImplementationAttribute(Definition=typeof(JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.Implementations.CurrentNamespaceMacroDef))]
    public class CurrentNamespaceMacroImpl : JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.SimpleMacroImplementation
    {
        public override JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.HotspotItems GetLookupItems(JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotContext context) { }
    }
    [JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.MacroDefinitionAttribute("decapitalize", LongDescription="Decapitalizes string value (i.e. changes case of the first letter to lower)", ShortDescription="Value of {#0:another variable} with the first character in lower case")]
    public class DecapitalizeMacroDef : JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.SimpleMacroDefinition
    {
        public override JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.ParameterInfo[] Parameters { get; }
    }
    [JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.MacroImplementationAttribute(Definition=typeof(JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.Implementations.DecapitalizeMacroDef))]
    public class DecapitalizeMacroImpl : JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.SimpleMacroImplementation
    {
        public DecapitalizeMacroImpl(JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.MacroParameterValueCollection arguments) { }
        public override string EvaluateQuickResult(JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotContext context) { }
    }
    [JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.MacroDefinitionAttribute("getDefaultNamespace", LongDescription="Gets default namespace for the current project", ShortDescription="Default namespace")]
    public class DefaultNamespaceMacroDef : JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.SimpleMacroDefinition { }
    [JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.MacroImplementationAttribute(Definition=typeof(JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.Implementations.DefaultNamespaceMacroDef))]
    public class DefaultNamespaceMacroImpl : JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.SimpleMacroImplementation
    {
        public override JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.HotspotItems GetLookupItems(JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotContext context) { }
    }
    [JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.MacroDefinitionAttribute("fileDefaultNamespace", LongDescription="Gets default namespace for the current file", ShortDescription="Default namespace for current file")]
    public class FileDefaultNamespaceMacroDef : JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.SimpleMacroDefinition { }
    [JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.MacroImplementationAttribute(Definition=typeof(JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.Implementations.FileDefaultNamespaceMacroDef))]
    public class FileDefaultNamespaceMacroImpl : JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.SimpleMacroImplementation
    {
        public override JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.HotspotItems GetLookupItems(JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotContext context) { }
    }
    [JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.MacroDefinitionAttribute("getFileName", LongDescription="Evaluates current file name", ShortDescription="Current file name")]
    public class FileNameMacroDef : JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.SimpleMacroDefinition { }
    [JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.MacroImplementationAttribute(Definition=typeof(JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.Implementations.FileNameMacroDef))]
    public class FileNameMacroImpl : JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.SimpleMacroImplementation
    {
        public override JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.HotspotItems GetLookupItems(JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotContext context) { }
    }
    [JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.MacroDefinitionAttribute("getFileNameWithoutExtension", LongDescription="Evaluates current file name without extension", ShortDescription="Current file name without extension")]
    public class FileNameWithoutExtensionMacroDef : JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.SimpleMacroDefinition { }
    [JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.MacroImplementationAttribute(Definition=typeof(JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.Implementations.FileNameWithoutExtensionMacroDef))]
    public class FileNameWithoutExtensionMacroImpl : JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.SimpleMacroImplementation
    {
        public override JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.HotspotItems GetLookupItems(JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotContext context) { }
    }
    [JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.MacroDefinitionAttribute("getFullUserName", LongDescription="Evaluates full name of the current user", ShortDescription="Full user name of the current user")]
    public class FullUserNameMacroDef : JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.SimpleMacroDefinition { }
    [JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.MacroImplementationAttribute(Definition=typeof(JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.Implementations.FullUserNameMacroDef))]
    public class FullUserNameMacroImpl : JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.SimpleMacroImplementation
    {
        public override JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.HotspotItems GetLookupItems(JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotContext context) { }
    }
    public abstract class GeneratorMacro : JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.SimpleMacroImplementation
    {
        protected abstract string CommandName { get; }
        protected abstract JetBrains.ReSharper.Psi.PsiLanguageType Language { get; }
        protected abstract string WorkflowKind { get; }
        public override string EvaluateQuickResult(JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotContext context) { }
        public override bool HandleExpansion(JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotContext context) { }
    }
    [JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.MacroDefinitionAttribute("guessExpectedElementType", LongDescription="Guess element type if a collection type is expected at this point", ShortDescription="Guess element type for expected collection type")]
    public class GuessExpectedElementTypeMacroDef : JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.SimpleMacroDefinition
    {
        public override string GetPlaceholder(JetBrains.DocumentModel.IDocument document, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.IMacroParameterValue> parameters) { }
    }
    [JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.MacroImplementationAttribute(Definition=typeof(JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.Implementations.GuessExpectedElementTypeMacroDef))]
    public class GuessExpectedElementTypeMacroImpl : JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.SimpleMacroImplementation
    {
        public override JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.HotspotItems GetLookupItems(JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotContext context) { }
    }
    [JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.MacroDefinitionAttribute("guessExpectedType", LongDescription="Guess type expected at this point", ShortDescription="Guess type expected at this point")]
    public class GuessExpectedTypeMacroDef : JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.SimpleMacroDefinition
    {
        public override JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.ParameterInfo[] Parameters { get; }
        public override string GetPlaceholder(JetBrains.DocumentModel.IDocument document, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.IMacroParameterValue> parameters) { }
    }
    [JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.MacroImplementationAttribute(Definition=typeof(JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.Implementations.GuessExpectedTypeMacroDef))]
    public class GuessExpectedTypeMacroImpl : JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.SimpleMacroImplementation
    {
        public GuessExpectedTypeMacroImpl(JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.MacroParameterValueCollection arguments) { }
        public override string EvaluateQuickResult(JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotContext context) { }
        public override JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.HotspotItems GetLookupItems(JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotContext context) { }
    }
    [JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.MacroDefinitionAttribute("guessKeyType", LongDescription="Analyzes code and guesses type of key of a dictionary collection.", ShortDescription="Guess key type of dictionary represented by {#0:variable}")]
    public class GuessKeyTypeMacroDef : JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.Implementations.TypeSuggestionMacroDefBase { }
    [JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.MacroImplementationAttribute(Definition=typeof(JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.Implementations.GuessKeyTypeMacroDef))]
    public class GuessKeyTypeMacroImpl : JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.Implementations.TypeSuggestionMacroImplBase
    {
        public GuessKeyTypeMacroImpl(JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.MacroParameterValueCollection arguments) { }
        protected override System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.IType> GuessTypes(string text, JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotContext context) { }
    }
    [JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.MacroDefinitionAttribute("guessValueType", LongDescription="Analyzes code and guesses type of value of a dictionary collection.", ShortDescription="Guess value type of dictionary represented by {#0:variable}")]
    public class GuessValueTypeMacroDef : JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.Implementations.TypeSuggestionMacroDefBase { }
    [JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.MacroImplementationAttribute(Definition=typeof(JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.Implementations.GuessValueTypeMacroDef))]
    public class GuessValueTypeMacroImpl : JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.Implementations.TypeSuggestionMacroImplBase
    {
        public GuessValueTypeMacroImpl(JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.MacroParameterValueCollection arguments) { }
        protected override System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.IType> GuessTypes(string text, JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotContext context) { }
    }
    [JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.MacroDefinitionAttribute("guid", LongDescription="Generates new Globally Unique Identifier (GUID)", ShortDescription="New GUID")]
    public class GuidMacroDef : JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.SimpleMacroDefinition
    {
        public string GetPlaceholder(JetBrains.DocumentModel.IDocument document) { }
    }
    [JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.MacroImplementationAttribute(Definition=typeof(JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.Implementations.GuidMacroDef))]
    public class GuidMacroImpl : JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.SimpleMacroImplementation
    {
        public override JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.HotspotItems GetLookupItems(JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotContext context) { }
    }
    [JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.MacroDefinitionAttribute("lineNumber", LongDescription="Evaluates to number of the line macro is evaluated at.", ShortDescription="Current line number")]
    public class LineNumberMacroDef : JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.SimpleMacroDefinition { }
    [JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.MacroImplementationAttribute(Definition=typeof(JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.Implementations.LineNumberMacroDef))]
    public class LineNumberMacroImpl : JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.SimpleMacroImplementation
    {
        public override string EvaluateQuickResult(JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotContext context) { }
    }
    [JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.MacroDefinitionAttribute("list", LongDescription="Displays the specified list of values.", ShortDescription="{#0:Comma-delimited list of values}")]
    public class ListMacroDef : JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.SimpleMacroDefinition
    {
        public override JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.ParameterInfo[] Parameters { get; }
        public override string GetPlaceholder(JetBrains.DocumentModel.IDocument document, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.IMacroParameterValue> parameters) { }
        public static System.Collections.Generic.IEnumerable<string> ParseList(string list) { }
    }
    [JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.MacroImplementationAttribute(Definition=typeof(JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.Implementations.ListMacroDef), ScopeProvider=typeof(JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.EverywhereImpl))]
    public class ListMacroImpl : JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.SimpleMacroImplementation
    {
        public ListMacroImpl(JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.MacroParameterValueCollection parameters) { }
        public override JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.HotspotItems GetLookupItems(JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotContext context) { }
    }
    [JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.MacroDefinitionAttribute("getOutputName", LongDescription="Evaluates output assembly name for the current project", ShortDescription="Current project output assembly name")]
    public class OutputNameMacroDef : JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.SimpleMacroDefinition { }
    [JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.MacroImplementationAttribute(Definition=typeof(JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.Implementations.OutputNameMacroDef))]
    public class OutputNameMacroImpl : JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.SimpleMacroImplementation
    {
        public override JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.HotspotItems GetLookupItems(JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotContext context) { }
    }
    [JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.MacroDefinitionAttribute("parameterOfType", LongDescription="Suggests parameters of the specified type.", ShortDescription="Suggest parameter of {#0:type}")]
    public class ParameterOfTypeMacroDef : JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.SimpleMacroDefinition
    {
        public override JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.ParameterInfo[] Parameters { get; }
    }
    [JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.MacroImplementationAttribute(Definition=typeof(JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.Implementations.ParameterOfTypeMacroDef))]
    public class ParameterOfTypeMacroImpl : JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.SimpleMacroImplementation
    {
        public ParameterOfTypeMacroImpl(JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.MacroParameterValueCollection arguments) { }
        public override JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.HotspotItems GetLookupItems(JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotContext context) { }
    }
    [JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.MacroDefinitionAttribute("getProjectName", LongDescription="Evaluates current project name", ShortDescription="Name of the current project")]
    public class ProjectNameMacroDef : JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.SimpleMacroDefinition { }
    [JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.MacroImplementationAttribute(Definition=typeof(JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.Implementations.ProjectNameMacroDef))]
    public class ProjectNameMacroImpl : JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.SimpleMacroImplementation
    {
        public override JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.HotspotItems GetLookupItems(JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotContext context) { }
    }
    [JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.MacroDefinitionAttribute("completeSmart", LongDescription="Show smart code completion list at the point where the variable is evaluated", ShortDescription="Execute smart completion")]
    public class SmartCompletionMacroDef : JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.SimpleMacroDefinition { }
    [JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.MacroImplementationAttribute(Definition=typeof(JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.Implementations.SmartCompletionMacroDef))]
    public class SmartCompletionMacroImpl : JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.Implementations.BaseCompletionMacroImpl
    {
        protected override JetBrains.ReSharper.Feature.Services.CodeCompletion.CodeCompletionType CompletionType { get; }
    }
    [JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.MacroDefinitionAttribute("getSolutionName", LongDescription="Evaluates current solution name", ShortDescription="Current solution name")]
    public class SolutionNameMacroDef : JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.SimpleMacroDefinition { }
    [JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.MacroImplementationAttribute(Definition=typeof(JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.Implementations.SolutionNameMacroDef))]
    public class SolutionNameMacroImpl : JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.SimpleMacroImplementation
    {
        public override JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.HotspotItems GetLookupItems(JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotContext context) { }
    }
    [JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.MacroDefinitionAttribute("spacestounderstrokes", LongDescription="Changes spaces to \'_\' (i.e. \"do something useful\" into \"do_something_useful\"", ShortDescription="Value of {#0:another variable}, where spaces will be replaced with \'_\'")]
    public class SpacesToUnderstrokesMacroDef : JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.SimpleMacroDefinition
    {
        public override JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.ParameterInfo[] Parameters { get; }
    }
    [JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.MacroImplementationAttribute(Definition=typeof(JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.Implementations.SpacesToUnderstrokesMacroDef))]
    public class SpacesToUnderstrokesMacroImpl : JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.SimpleMacroImplementation
    {
        public SpacesToUnderstrokesMacroImpl(JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.MacroParameterValueCollection arguments) { }
        public override string EvaluateQuickResult(JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotContext context) { }
    }
    [JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.MacroDefinitionAttribute("enumerableVariable", LongDescription="Suggests visible variable that can be enumerated (that is, used in foreach loop a" +
        "s collection)", ShortDescription="Suggest enumerable variable")]
    public class SuggestEnumerableVariableMacroDef : JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.SimpleMacroDefinition { }
    [JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.MacroImplementationAttribute(Definition=typeof(JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.Implementations.SuggestEnumerableVariableMacroDef))]
    public class SuggestEnumerableVariableMacroImpl : JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.SimpleMacroImplementation
    {
        public override JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.HotspotItems GetLookupItems(JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotContext context) { }
    }
    public class SuggestParameterNameExpression : JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotExpression, JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotExpressionAdvanced, System.ICloneable
    {
        public SuggestParameterNameExpression(JetBrains.ReSharper.Psi.Naming.Extentions.INamesCollection namesCollection, JetBrains.ReSharper.Psi.PsiLanguageType language) { }
        public object Clone() { }
        public string EvaluateQuickResult(JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotContext context) { }
        public System.Collections.Generic.IEnumerable<JetBrains.DocumentModel.IRangeMarker> GetAdditionalRangeMarkers() { }
        public JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.HotspotItems GetLookupItems(JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotContext context) { }
        public string GetPlaceholder(JetBrains.DocumentModel.IDocument document) { }
        public void HandleExpansion(JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotContext context) { }
        public string Serialize() { }
    }
    [JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.MacroDefinitionAttribute("suggestVariableName", LongDescription="When exectuted in variable declaration (where variable name should stand), sugges" +
        "ts name for the variable.", ShortDescription="Suggest name for a variable")]
    public class SuggestVariableNameMacroDef : JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.SimpleMacroDefinition { }
    [JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.MacroImplementationAttribute(Definition=typeof(JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.Implementations.SuggestVariableNameMacroDef))]
    public class SuggestVariableNameMacroImpl : JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.SuggestVariableNameMacroImplBase
    {
        public SuggestVariableNameMacroImpl(JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.MacroParameterValueCollection arguments) { }
        [JetBrains.Annotations.NotNullAttribute()]
        protected override System.Collections.Generic.IEnumerable<JetBrains.Util.Pair<string, bool>> GenerateNames([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotContext context) { }
    }
    [JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.MacroDefinitionAttribute("variableOfType", LongDescription="Suggests variables of the specified type.", ShortDescription="Suggest variable of {#0:type}")]
    public class SuggestVariableOfTypeMacroDef : JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.SimpleMacroDefinition
    {
        public override JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.ParameterInfo[] Parameters { get; }
    }
    [JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.MacroImplementationAttribute(Definition=typeof(JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.Implementations.SuggestVariableOfTypeMacroDef))]
    public class SuggestVariableOfTypeMacroImpl : JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.SimpleMacroImplementation
    {
        public SuggestVariableOfTypeMacroImpl(JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.MacroParameterValueCollection arguments) { }
        public override JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.HotspotItems GetLookupItems(JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotContext context) { }
    }
    [JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.MacroDefinitionAttribute("suggestVariableType", LongDescription="Suggest type for a new variable declared in the template", ShortDescription="Suggest type for a new variable")]
    public class SuggestVariableTypeMacroDef : JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.SimpleMacroDefinition { }
    [JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.MacroImplementationAttribute(Definition=typeof(JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.Implementations.SuggestVariableTypeMacroDef))]
    public class SuggestVariableTypeMacroImpl : JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.SimpleMacroImplementation
    {
        public override JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.HotspotItems GetLookupItems(JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotContext context) { }
    }
    [JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.MacroDefinitionAttribute("completeType", LongDescription="Show type completion list at the point where the variable is evaluated", ShortDescription="Execute type completion")]
    public class TypeNameCompletionMacroDef : JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.SimpleMacroDefinition
    {
        public override JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.ParameterInfo[] Parameters { get; }
    }
    [JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.MacroImplementationAttribute(Definition=typeof(JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.Implementations.TypeNameCompletionMacroDef))]
    public class TypeNameCompletionMacroImpl : JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.Implementations.BaseCompletionMacroImpl
    {
        public TypeNameCompletionMacroImpl(JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.MacroParameterValueCollection arguments) { }
        protected override JetBrains.ReSharper.Feature.Services.CodeCompletion.CodeCompletionType CompletionType { get; }
        public override string EvaluateQuickResult(JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotContext context) { }
    }
    public abstract class TypeSuggestionMacroDefBase : JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.SimpleMacroDefinition
    {
        public override JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.ParameterInfo[] Parameters { get; }
        public override string GetPlaceholder(JetBrains.DocumentModel.IDocument document, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.IMacroParameterValue> parameters) { }
    }
    public abstract class TypeSuggestionMacroImplBase : JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.SimpleMacroImplementation
    {
        protected TypeSuggestionMacroImplBase(JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.MacroParameterValueCollection arguments) { }
        public override JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.HotspotItems GetLookupItems(JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotContext context) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        protected abstract System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.IType> GuessTypes(string variable, JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotContext context);
    }
    public class TypeTemplateExpression : JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotExpression, JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotExpressionAdvanced, System.ICloneable
    {
        public TypeTemplateExpression(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IType> types, JetBrains.ReSharper.Psi.Modules.IPsiModule module, JetBrains.ReSharper.Psi.PsiLanguageType language) { }
        public object Clone() { }
        public string EvaluateQuickResult(JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotContext context) { }
        public System.Collections.Generic.IEnumerable<JetBrains.DocumentModel.IRangeMarker> GetAdditionalRangeMarkers() { }
        public JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.HotspotItems GetLookupItems(JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotContext context) { }
        public string GetPlaceholder(JetBrains.DocumentModel.IDocument document) { }
        public string Serialize() { }
    }
    [JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.MacroDefinitionAttribute("getUserName", LongDescription="Evaluates current user name", ShortDescription="Short name of the current user")]
    public class UserNameMacroDef : JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.SimpleMacroDefinition { }
    [JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.MacroImplementationAttribute(Definition=typeof(JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.Implementations.UserNameMacroDef))]
    public class UserNameMacroImpl : JetBrains.ReSharper.Feature.Services.LiveTemplates.Macros.SimpleMacroImplementation
    {
        public override string EvaluateQuickResult(JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotContext context) { }
        public override JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.HotspotItems GetLookupItems(JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotContext context) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.LiveTemplates
{
    
    public class static MaskListParser
    {
        public static string[] GetMasks(string pattern) { }
    }
    public class static SignalUtil
    {
        public static JetBrains.DataFlow.ISignal<TSignal> PropagateFromProperty<TValue, TSignal>(JetBrains.DataFlow.Lifetime lifetime, JetBrains.DataFlow.IProperty<TValue> untypedProperty, System.Func<TValue, JetBrains.DataFlow.ISignal<TSignal>> signalProducer) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.LiveTemplates.QuickLists
{
    
    public interface IQuickListProvider
    {
        JetBrains.ReSharper.Feature.Services.LiveTemplates.QuickLists.QuickList QuickList { get; set; }
    }
    public class QuickList : System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.LiveTemplates.QuickLists.TemplateReference>, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.LiveTemplates.QuickLists.TemplateReference>, System.Collections.Generic.IList<JetBrains.ReSharper.Feature.Services.LiveTemplates.QuickLists.TemplateReference>, System.Collections.IEnumerable
    {
        public QuickList() { }
        public int Count { get; }
        public bool IsReadOnly { get; }
        public JetBrains.ReSharper.Feature.Services.LiveTemplates.QuickLists.TemplateReference this[int index] { get; set; }
        public System.Collections.Generic.JetHashSet<JetBrains.ReSharper.Feature.Services.LiveTemplates.QuickLists.TemplateReference> RemovedEntries { get; }
        public void Add(JetBrains.ReSharper.Feature.Services.LiveTemplates.QuickLists.TemplateReference item) { }
        public void Add(JetBrains.ReSharper.LiveTemplates.Templates.Template template) { }
        public void Clear() { }
        public void ConfigureFromXml(System.Xml.XmlElement element) { }
        public bool Contains(JetBrains.ReSharper.Feature.Services.LiveTemplates.QuickLists.TemplateReference item) { }
        public void CopyTo(JetBrains.ReSharper.Feature.Services.LiveTemplates.QuickLists.TemplateReference[] array, int arrayIndex) { }
        public System.Collections.IEnumerator GetEnumerator() { }
        public int IndexOf(JetBrains.ReSharper.Feature.Services.LiveTemplates.QuickLists.TemplateReference item) { }
        public void Insert(int index, JetBrains.ReSharper.Feature.Services.LiveTemplates.QuickLists.TemplateReference item) { }
        public void LoadFromXml(System.Xml.XmlElement element) { }
        public bool Remove(JetBrains.ReSharper.Feature.Services.LiveTemplates.QuickLists.TemplateReference item) { }
        public void RemoveAt(int index) { }
    }
    public class QuickListEx
    {
        public QuickListEx(System.Guid quickListUID, string quickListTitle, JetBrains.ReSharper.Feature.Services.LiveTemplates.QuickLists.QuickList quickList) { }
        public QuickListEx(System.Guid uid, string quickListTitle) { }
        public JetBrains.ReSharper.Feature.Services.LiveTemplates.QuickLists.QuickList QuickList { get; }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Feature.Services.LiveTemplates.QuickLists.TemplateReference> TemplateReferences { get; }
        public void SaveToStore(JetBrains.Application.Settings.IContextBoundSettingsStore store) { }
        public void SetEntries(JetBrains.Util.OneToSetMap<int, JetBrains.ReSharper.Feature.Services.LiveTemplates.QuickLists.TemplateReference> map) { }
    }
    public class TemplateReference : System.IEquatable<JetBrains.ReSharper.Feature.Services.LiveTemplates.QuickLists.TemplateReference>
    {
        public TemplateReference(System.Guid guid, string name) { }
        public TemplateReference(JetBrains.ReSharper.LiveTemplates.Templates.Template template) { }
        public string Name { get; }
        [System.ObsoleteAttribute()]
        public JetBrains.ReSharper.LiveTemplates.Templates.Template Template { get; }
        public System.Guid UID { get; }
        public static JetBrains.ReSharper.Feature.Services.LiveTemplates.QuickLists.TemplateReference CreateFromXml(System.Xml.XmlElement element) { }
        public bool Equals(JetBrains.ReSharper.Feature.Services.LiveTemplates.QuickLists.TemplateReference templateReference) { }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope
{
    
    public class Everywhere : JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.TemplateScopePoint
    {
        public override string PresentableShortName { get; }
        public override System.Guid GetDefaultUID() { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class EverywhereScopeProvider : JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ScopeProvider
    {
        public EverywhereScopeProvider() { }
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint> ProvideScopePoints(JetBrains.ReSharper.Feature.Services.LiveTemplates.Context.TemplateAcceptanceContext context) { }
    }
    public class FileMaskScopeConfig : JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ScopeOptionsUIBase, System.Windows.Markup.IComponentConnector
    {
        public FileMaskScopeConfig(JetBrains.ReSharper.Feature.Services.LiveTemplates.Context.InFileWithMask fileMask) { }
        public override void Done() { }
        public void InitializeComponent() { }
    }
    [JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ScopeCategoryUIProviderAttribute(Priority=100D, ScopeFilter=JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ScopeFilter.Project)]
    public class GlobalProjectScopeCategoryUIProvider : JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ScopeCategoryUIProvider
    {
        public GlobalProjectScopeCategoryUIProvider() { }
        public override string CategoryCaption { get; }
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint> BuildAllPoints() { }
        public override string Present(JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint point) { }
    }
    public interface IMainScopePoint : JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint
    {
        string QuickListTitle { get; }
        System.Guid QuickListUID { get; }
    }
    public class InAnyFile : JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.Everywhere
    {
        public override System.Guid GetDefaultUID() { }
    }
    public class InAnyLanguageFile : JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.InAnyFile
    {
        public override System.Guid GetDefaultUID() { }
        protected virtual System.Collections.Generic.IEnumerable<string> GetExtensions() { }
        public override bool IsSubsetOf(JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint other) { }
    }
    public class InAnyProject : JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.Everywhere
    {
        public virtual string DefaultFileName { get; }
        public override string PresentableShortName { get; }
        public override System.Guid GetDefaultUID() { }
    }
    public class InLanguageSpecificProject : JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.InAnyProject
    {
        public InLanguageSpecificProject(JetBrains.ProjectModel.Properties.ProjectLanguage projectLanguage) { }
        public JetBrains.ProjectModel.Properties.ProjectLanguage ProjectLanguage { get; }
        public override System.Guid GetDefaultUID() { }
        public override bool IsSubsetOf(JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint other) { }
    }
    public interface IScopeCategoryUIProvider
    {
        string CategoryCaption { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.UI.Icons.IconId Icon { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.IMainScopePoint MainPoint { get; }
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint> BuildAllPoints();
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint> BuildDefaultScopes();
        JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ScopeOptionsUIBase CreateUI(JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint point);
        bool HaveOptionsUIFor(JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint point);
        string Present(JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint point);
    }
    public interface IScopeProvider
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint CreateScope(System.Guid scopeGuid, string typeName, System.Collections.Generic.IEnumerable<JetBrains.Util.Pair<string, string>> customProperties);
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint> ProvideScopePoints(JetBrains.ReSharper.Feature.Services.LiveTemplates.Context.TemplateAcceptanceContext context);
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint ReadFromXml([JetBrains.Annotations.NotNullAttribute()] System.Xml.XmlElement scopeElement);
    }
    public interface ITemplateScopePoint
    {
        string Prefix { get; }
        string PresentableShortName { get; }
        JetBrains.ReSharper.Psi.PsiLanguageType RelatedLanguage { get; }
        System.Guid UID { get; set; }
        string CalcPrefix(JetBrains.DocumentModel.IDocument document, int caretOffset);
        System.Collections.Generic.IEnumerable<JetBrains.Util.Pair<string, string>> EnumerateCustomProperties();
        System.Guid GetDefaultUID();
        string GetTagName();
        bool IsSubsetOf(JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint other);
        [JetBrains.Annotations.NotNullAttribute()]
        System.Xml.XmlElement WriteToXml(System.Xml.XmlElement element);
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class ScopeCategoryManager
    {
        public ScopeCategoryManager(JetBrains.DataFlow.Lifetime lifetime, JetBrains.DataFlow.IViewable<JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.IScopeCategoryUIProvider> providers) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.IScopeCategoryUIProvider> EnumerateProviders() { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.IScopeCategoryUIProvider> FilterProviders(JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ScopeFilter filter) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.IScopeCategoryUIProvider> GetCoveredProviders(JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ScopeFilter scopeFilter, JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint scopePoint) { }
        public JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.IScopeCategoryUIProvider GetSupportingProvider(JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ScopeFilter scopeFilter, JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint scopePoint) { }
    }
    public abstract class ScopeCategoryUIProvider : JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.IScopeCategoryUIProvider
    {
        protected ScopeCategoryUIProvider(JetBrains.UI.Icons.IconId iconName = null) { }
        public abstract string CategoryCaption { get; }
        public JetBrains.UI.Icons.IconId Icon { get; }
        public JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.IMainScopePoint MainPoint { get; set; }
        public abstract System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint> BuildAllPoints();
        public virtual System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint> BuildDefaultScopes() { }
        public virtual JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ScopeOptionsUIBase CreateUI(JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint point) { }
        public virtual bool HaveOptionsUIFor(JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint point) { }
        public virtual string Present(JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint point) { }
    }
    [JetBrains.Annotations.BaseTypeRequiredAttribute(typeof(JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.IScopeCategoryUIProvider))]
    [JetBrains.Annotations.MeansImplicitUseAttribute()]
    [System.AttributeUsageAttribute(System.AttributeTargets.Class | System.AttributeTargets.All, AllowMultiple=false)]
    public class ScopeCategoryUIProviderAttribute : JetBrains.Application.ShellComponentAttribute
    {
        public ScopeCategoryUIProviderAttribute() { }
        public double Priority { get; set; }
        public JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ScopeFilter ScopeFilter { get; set; }
    }
    public abstract class ScopedTemplateAcceptorBase
    {
        protected readonly System.Collections.Generic.IList<JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint> myScopePoints;
        protected ScopedTemplateAcceptorBase(JetBrains.ReSharper.Feature.Services.LiveTemplates.Context.TemplateAcceptanceContext context, JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.IScopeProvider scopeProvider) { }
        public virtual bool Accepts(JetBrains.ReSharper.Feature.Services.LiveTemplates.Context.ITemplateContext templateContext) { }
    }
    public class ScopedTemplateContext : JetBrains.ReSharper.Feature.Services.LiveTemplates.Context.TemplateContext
    {
        public ScopedTemplateContext(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint> scopePoints) { }
        public string Present { get; }
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint> ScopePoints { get; }
        public override string ToString() { }
    }
    public enum ScopeFilter
    {
        Language = 0,
        Project = 1,
        Default = 0,
    }
    public class ScopeListItem : JetBrains.UI.Avalon.TreeListView.ObservableObject
    {
        public System.Windows.Media.Brush BackgroundColor { get; }
        public bool CanExpand { get; set; }
        public bool Checked { get; set; }
        public string DisplayText { get; }
        public bool IsIncluded { get; set; }
        public JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ScopeOptionsUIBase OptionsUI { get; set; }
        public JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.IScopeCategoryUIProvider Provider { get; set; }
        public JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint ScopePoint { get; set; }
        public void OnItemChanged() { }
    }
    public class ScopeOptionsUIBase : System.Windows.Controls.UserControl
    {
        public ScopeOptionsUIBase() { }
        public event System.Action<JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint> OnNewScopePoint;
        public virtual void Done() { }
        protected void InvokeNewScopePoint(JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint point) { }
    }
    public abstract class ScopeProvider : JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.IScopeProvider
    {
        protected readonly System.Collections.Generic.ICollection<System.Func<string, JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint>> Creators;
        protected ScopeProvider() { }
        public virtual JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint CreateScope(System.Guid scopeGuid, string typeName, System.Collections.Generic.IEnumerable<JetBrains.Util.Pair<string, string>> customProperties) { }
        public abstract System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint> ProvideScopePoints(JetBrains.ReSharper.Feature.Services.LiveTemplates.Context.TemplateAcceptanceContext context);
        public virtual JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint ReadFromXml(System.Xml.XmlElement scopeElement) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        protected JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint TryToCreate<TScope>(string typeName)
            where TScope : JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint, new () { }
    }
    public class ScopeSelectorControl : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector
    {
        public ScopeSelectorControl() { }
        public JetBrains.UI.Controls.Misc.FilterController<JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ScopeSelectorControl.CategoryItem> FilterController { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint> GetSelectedPoints() { }
        public void Init(JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ScopeFilter scopeFilter) { }
        public void InitializeComponent() { }
        public void SelectPoints([JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint> points) { }
        public class CategoryItem
        {
            public CategoryItem(JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.IScopeCategoryUIProvider provider) { }
            public JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.IScopeCategoryUIProvider Provider { get; }
            public override string ToString() { }
        }
    }
    public class ScopeSelectorDialog : System.Windows.Window, System.Windows.Markup.IComponentConnector
    {
        public ScopeSelectorDialog(JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ScopeFilter scopeFilter) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint> GetSelectedPoints() { }
        public void InitializeComponent() { }
        public void SelectPoints(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint> points) { }
    }
    public abstract class TemplateHighlightingProvider
    {
        public virtual string GetHighlightingAttributeId(JetBrains.ReSharper.Psi.Parsing.TokenNodeType tokenType) { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class TemplateScopeManager
    {
        public TemplateScopeManager(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.IScopeProvider> providers) { }
        public static JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.TemplateScopeManager Instance { get; }
        public static System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint> EnumerateMatchedRealScopePoints([JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint> realScopePoints, [JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint> allowedScopePoints) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint> EnumerateRealScopePoints(JetBrains.ReSharper.Feature.Services.LiveTemplates.Context.TemplateAcceptanceContext tac) { }
        public JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint ReadFromStore(JetBrains.Application.Settings.IContextBoundSettingsStore store, JetBrains.Application.Settings.GuidIndex templateUidIndex, JetBrains.Application.Settings.GuidIndex scopeUidIndex) { }
        public JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint ReadFromXml([JetBrains.Annotations.CanBeNullAttribute()] System.Xml.XmlElement scopeElement) { }
        public static bool ScopePointsHaveIntersections([JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint> sp1, [JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint> sp2) { }
        public static bool TemplateIsAvailable(JetBrains.ReSharper.LiveTemplates.Templates.Template template, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint> realScopePoints) { }
    }
    public abstract class TemplateScopePoint : JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint
    {
        protected readonly System.Collections.Generic.ICollection<System.Type> AdditionalSuperTypes;
        public const string AttrType = "type";
        protected string myPrefix;
        protected TemplateScopePoint() { }
        public string Prefix { get; }
        public virtual string PresentableShortName { get; }
        public virtual JetBrains.ReSharper.Psi.PsiLanguageType RelatedLanguage { get; }
        public System.Guid UID { get; set; }
        public virtual string CalcPrefix(JetBrains.DocumentModel.IDocument document, int caretOffset) { }
        public virtual System.Collections.Generic.IEnumerable<JetBrains.Util.Pair<string, string>> EnumerateCustomProperties() { }
        public abstract System.Guid GetDefaultUID();
        public string GetTagName() { }
        public virtual bool IsSubsetOf(JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint other) { }
        public virtual System.Xml.XmlElement WriteToXml(System.Xml.XmlElement element) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.LiveTemplates.Settings
{
    
    [JetBrains.Application.ShellComponentAttribute()]
    public class DefaultTemplatesConverter
    {
        public DefaultTemplatesConverter(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.Settings.ISettingsStore settingsStore, JetBrains.Threading.IThreading threading, JetBrains.DataFlow.IViewable<JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.IScopeCategoryUIProvider> scopeCategoryUIProviders, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.LiveTemplates.Support.IFileTemplatesSupport> fileTemplateSupporters) { }
        public void Convert() { }
    }
    [JetBrains.Application.Settings.SettingsIndexedKeyAttribute(typeof(JetBrains.ReSharper.Feature.Services.LiveTemplates.Settings.QuickListSettings), "Quicklist entry", typeof(JetBrains.Application.Settings.GuidIndex))]
    public class EntrySettings
    {
        [JetBrains.Application.Settings.SettingsEntryAttribute(null, "Entry name")]
        public string EntryName;
        [JetBrains.Application.Settings.SettingsEntryAttribute(null, "Entry position")]
        public int Position;
    }
    [JetBrains.Application.Settings.SettingsIndexedKeyAttribute(typeof(JetBrains.ReSharper.Feature.Services.LiveTemplates.Settings.TemplateSettings), "Template field", typeof(string))]
    public class FieldSettings
    {
        [JetBrains.Application.Settings.SettingsEntryAttribute(null, "Field expression")]
        public string Expression;
        [JetBrains.Application.Settings.SettingsEntryAttribute(0, "Editable occurence")]
        public int InitialRange;
        [JetBrains.Application.Settings.SettingsEntryAttribute(null, "Editable section")]
        public JetBrains.Application.Settings.GuidIndex InitialSection;
        [JetBrains.Application.Settings.SettingsEntryAttribute(-1, "Position in the list")]
        public int Order;
    }
    [JetBrains.Application.Configuration.Upgrade.GlobalSettingsUpgraderAttribute()]
    public class GlobalTemplatesUpgrader : JetBrains.Application.Configuration.Upgrade.IGlobalSettingsUpgrader, JetBrains.Application.Configuration.Upgrade.ISettingsUpgrader
    {
        public GlobalTemplatesUpgrader(JetBrains.ReSharper.Feature.Services.LiveTemplates.Settings.StoredTemplatesProvider storedTemplatesProvider, JetBrains.DataFlow.IViewable<JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.IScopeCategoryUIProvider> scopeCategoryUIProviders, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.LiveTemplates.Support.IFileTemplatesSupport> fileTemplateSupporters, JetBrains.Threading.IThreading threading) { }
        public void Upgrade(JetBrains.Application.Configuration.IComponentSettingsProvider legacySettingsProvider, JetBrains.Application.Settings.IContextBoundSettingsStore boundSettingsStore, JetBrains.DataFlow.Lifetime upgradeLifetime) { }
    }
    public interface ITemplateStore
    {
        JetBrains.ReSharper.LiveTemplates.Templates.Template GetTemplate(System.Guid uid, JetBrains.ReSharper.Feature.Services.LiveTemplates.Settings.TemplateApplicability applicability);
    }
    [JetBrains.Application.Settings.SettingsKeyAttribute(typeof(JetBrains.Application.Settings.HousekeepingSettings), "IntelliSense housekeeping settings")]
    public class LiveTemplatesHousekeepingSettings
    {
        [JetBrains.Application.Settings.SettingsEntryAttribute(false, "Whether hint was shown")]
        public bool HotspotSessionHintIsShown;
    }
    [JetBrains.Application.Configuration.Upgrade.GlobalSettingsUpgraderAttribute()]
    public class LiveTemplatesHousekeepingSettingsUpgrader : JetBrains.Application.Configuration.SettingTablesUpgrader
    {
        public LiveTemplatesHousekeepingSettingsUpgrader(JetBrains.Application.Env.RunsProducts.ProductConfigurations productConfigurations) { }
        protected override void DoUpgrade(JetBrains.Application.Configuration.IComponentSettingsProvider legacySettingsProvider, JetBrains.Application.Settings.IContextBoundSettingsStore boundSettingsStore, JetBrains.DataFlow.Lifetime upgradeLifetime, JetBrains.Application.Configuration.SettingsTableBase workspaceSettingsTable, JetBrains.Application.Configuration.SettingsTableBase globalSettingsTable) { }
    }
    [JetBrains.Application.Settings.SettingsKeyAttribute(typeof(JetBrains.ReSharper.Settings.PatternsAndTemplatesSettingsKey), "Live templates library")]
    public class LiveTemplatesSettings { }
    [JetBrains.ProjectModel.ProjectComponentAttribute()]
    public class ProjectTemplateStorage : JetBrains.ReSharper.Feature.Services.LiveTemplates.Settings.ITemplateStore
    {
        public ProjectTemplateStorage(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ProjectModel.IProject project, JetBrains.ReSharper.Feature.Services.LiveTemplates.Settings.StoredTemplatesProvider storedTemplatesProvider) { }
        public JetBrains.ReSharper.LiveTemplates.Templates.Template GetTemplate(System.Guid uid, JetBrains.ReSharper.Feature.Services.LiveTemplates.Settings.TemplateApplicability applicability) { }
    }
    [JetBrains.Application.Settings.SettingsIndexedKeyAttribute(typeof(JetBrains.ReSharper.Feature.Services.LiveTemplates.Settings.LiveTemplatesSettings), "Quicklist", typeof(JetBrains.Application.Settings.GuidIndex))]
    public class QuickListSettings
    {
        [JetBrains.Application.Settings.SettingsEntryAttribute(null, "List name")]
        public string Name;
    }
    [JetBrains.Application.Settings.SettingsIndexedKeyAttribute(typeof(JetBrains.ReSharper.Feature.Services.LiveTemplates.Settings.TemplateSettings), "Template scope", typeof(JetBrains.Application.Settings.GuidIndex))]
    public class ScopeSettings
    {
        [JetBrains.Application.Settings.SettingsIndexedEntryAttribute("Custom properties")]
        public JetBrains.Application.Settings.Store.IIndexedEntry<string, string> CustomProperties;
        [JetBrains.Application.Settings.SettingsEntryAttribute(null, "Scope type")]
        public string Type;
    }
    [JetBrains.Application.Settings.SettingsKeyAttribute(typeof(JetBrains.ReSharper.Feature.Services.LiveTemplates.Settings.SectionSettings), "Plain text section")]
    public class SectionPlainSettings
    {
        [JetBrains.Application.Settings.SettingsEntryAttribute(null, "Text")]
        public string Text;
    }
    [JetBrains.Application.Settings.SettingsKeyAttribute(typeof(JetBrains.ReSharper.Feature.Services.LiveTemplates.Settings.SectionSettings), "Reference section")]
    public class SectionReferenceSettings
    {
        [JetBrains.Application.Settings.SettingsIndexedEntryAttribute("Fields mapping")]
        public JetBrains.Application.Settings.Store.IIndexedEntry<string, string> FieldMapping;
        [JetBrains.Application.Settings.SettingsEntryAttribute(null, "Template guid")]
        public JetBrains.Application.Settings.GuidIndex TemplateUid;
    }
    [JetBrains.Application.Settings.SettingsIndexedKeyAttribute(typeof(JetBrains.ReSharper.Feature.Services.LiveTemplates.Settings.TemplateSettings), "Template section", typeof(JetBrains.Application.Settings.GuidIndex))]
    public class SectionSettings
    {
        [JetBrains.Application.Settings.SettingsEntryAttribute(null, "Location selector config")]
        public string LocationSelectorConfig;
        [JetBrains.Application.Settings.SettingsEntryAttribute(null, "Location selector name")]
        public string LocationSelectorName;
        [JetBrains.Application.Settings.SettingsEntryAttribute(-1, "Position in the list")]
        public int Order;
        [JetBrains.Application.Settings.SettingsEntryAttribute(null, "Section type")]
        public JetBrains.ReSharper.LiveTemplates.Templates.TemplateSectionType Type;
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class StoredTemplatesProvider
    {
        public readonly JetBrains.DataFlow.ISignal<JetBrains.DataFlow.CancelEventArgs<JetBrains.ReSharper.LiveTemplates.Templates.Template>> BeforeDeleteTemplateSignal;
        public readonly JetBrains.DataFlow.SimpleSignal ChangedSignal;
        public StoredTemplatesProvider(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.Settings.ISettingsStore settingsStore) { }
        public static JetBrains.ReSharper.Feature.Services.LiveTemplates.Settings.StoredTemplatesProvider Instance { get; }
        public JetBrains.Application.Settings.SettingsKey SettingsKey { get; }
        public bool ConfirmTemplateDelete(JetBrains.ReSharper.LiveTemplates.Templates.Template template) { }
        public void DeleteTemplate(JetBrains.ReSharper.LiveTemplates.Templates.Template template, JetBrains.Application.Settings.IContextBoundSettingsStore store) { }
        public static void DumpToFile(JetBrains.Util.FileSystemPath pathFileStorage, JetBrains.Application.Settings.ISettingsStore existingStore, JetBrains.Threading.IThreading threading, System.Action<JetBrains.Application.Settings.IContextBoundSettingsStore> fSave) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public virtual System.Collections.Generic.IEnumerable<JetBrains.ReSharper.LiveTemplates.Templates.Template> EnumerateTemplates([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.IContextBoundSettingsStore store, JetBrains.ReSharper.Feature.Services.LiveTemplates.Settings.TemplateApplicability applicability, bool enabledOnly = True) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.LiveTemplates.Templates.Template GetTemplate(System.Func<JetBrains.DataFlow.Lifetime, JetBrains.Application.DataContext.DataContexts, JetBrains.Application.DataContext.IDataContext> FContext, System.Guid guid, JetBrains.ReSharper.Feature.Services.LiveTemplates.Settings.TemplateApplicability applicability) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.LiveTemplates.Templates.Template GetTemplate(JetBrains.Application.Settings.IContextBoundSettingsStore store, System.Guid guid, JetBrains.ReSharper.Feature.Services.LiveTemplates.Settings.TemplateApplicability applicability) { }
        public bool IsTemplateIsDefinedInSettings(System.Guid uid, JetBrains.Application.Settings.IContextBoundSettingsStore store) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Feature.Services.LiveTemplates.QuickLists.QuickListEx LoadQuickList(JetBrains.Application.Settings.IContextBoundSettingsStore store, System.Guid quickListUID) { }
        protected void SomethingChanged() { }
        [JetBrains.Application.ShellComponentAttribute()]
        public class DefaultFileTemplates : JetBrains.Application.Settings.IHaveDefaultSettingsStream
        {
            public string Name { get; }
            public System.IO.Stream GetDefaultSettingsStream(JetBrains.DataFlow.Lifetime lifetime) { }
        }
        [JetBrains.Application.ShellComponentAttribute()]
        public class DefaultLiveTemplates : JetBrains.Application.Settings.IHaveDefaultSettingsStream
        {
            public string Name { get; }
            public System.IO.Stream GetDefaultSettingsStream(JetBrains.DataFlow.Lifetime lifetime) { }
        }
        [JetBrains.Application.ShellComponentAttribute()]
        public class DefaultSurroundTemplates : JetBrains.Application.Settings.IHaveDefaultSettingsStream
        {
            public string Name { get; }
            public System.IO.Stream GetDefaultSettingsStream(JetBrains.DataFlow.Lifetime lifetime) { }
        }
    }
    public class static StoredTemplatesUtil
    {
        public static void SetIfChanged<TKeyClass, TValueClass>(this JetBrains.Application.Settings.IContextBoundSettingsStore store, System.Linq.Expressions.Expression<System.Func<TKeyClass, TValueClass>> expression, TValueClass value, System.Collections.Generic.IDictionary<JetBrains.Application.Settings.SettingsKey, object> mappingKeys) { }
        public static void UpdateIndexedEntry<TKeyClass, TEntryClass, TEntryValue>(this JetBrains.Application.Settings.IContextBoundSettingsStore store, System.Linq.Expressions.Expression<System.Func<TKeyClass, JetBrains.Application.Settings.Store.IIndexedEntry<TEntryClass, TEntryValue>>> expression, System.Collections.Generic.Dictionary<TEntryClass, TEntryValue> entriesToSave, System.Collections.Generic.Dictionary<JetBrains.Application.Settings.SettingsKey, object> templateMapping) { }
    }
    public enum TemplateApplicability
    {
        Live = 0,
        Surround = 1,
        File = 2,
    }
    [JetBrains.Application.Settings.SettingsIndexedKeyAttribute(typeof(JetBrains.ReSharper.Feature.Services.LiveTemplates.Settings.LiveTemplatesSettings), "Single template", typeof(JetBrains.Application.Settings.GuidIndex))]
    public class TemplateSettings
    {
        [JetBrains.Application.Settings.SettingsIndexedEntryAttribute("Template applicability")]
        public JetBrains.Application.Settings.Store.IIndexedEntry<JetBrains.ReSharper.Feature.Services.LiveTemplates.Settings.TemplateApplicability, bool> Applicability;
        [JetBrains.Application.Settings.SettingsIndexedEntryAttribute("Categories")]
        public JetBrains.Application.Settings.Store.IIndexedEntry<string, string> Categories;
        [JetBrains.Application.Settings.SettingsIndexedEntryAttribute("Custom properties")]
        public JetBrains.Application.Settings.Store.IIndexedEntry<string, string> CustomProperties;
        [JetBrains.Application.Settings.SettingsEntryAttribute(null, "Template description")]
        public string Description;
        [JetBrains.Application.Settings.SettingsEntryAttribute(false, "Template is disabled")]
        public bool IsDisabled;
        [JetBrains.Application.Settings.SettingsEntryAttribute(false, "Is invisible")]
        public bool IsInvisible;
        [JetBrains.Application.Settings.SettingsEntryAttribute(false, "Reformat after expansion")]
        public bool Reformat;
        [JetBrains.Application.Settings.SettingsEntryAttribute(null, "Template shortcut")]
        public string Shortcut;
        [JetBrains.Application.Settings.SettingsEntryAttribute(false, "Shorten qualified references")]
        public bool ShortenQualifiedReferences;
        [JetBrains.Application.Settings.SettingsEntryAttribute(null, "Template text")]
        public string Text;
    }
}
namespace JetBrains.ReSharper.Feature.Services.LiveTemplates.Storages
{
    
    public class ApplicabilityDescriptor
    {
        public string DefaultTemplateText { get; set; }
        public string FamilyTitle { get; set; }
        public JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ScopeFilter ScopeFilter { get; set; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.UI.Icons.IconId TemplateImage { get; set; }
    }
    public class FileStorage : JetBrains.ReSharper.Feature.Services.LiveTemplates.Storages.TemplateStorageBase
    {
        public FileStorage(string filePath, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Feature.Services.LiveTemplates.Storages.ITemplateFamily family) { }
        protected FileStorage([JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.FileSystemPath filePath, JetBrains.ReSharper.Feature.Services.LiveTemplates.Settings.TemplateApplicability applicability) { }
        protected override bool ReadOnly { get; }
    }
    public interface ITemplateFamily
    {
        JetBrains.ReSharper.Feature.Services.LiveTemplates.Settings.TemplateApplicability Applicability { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Feature.Services.LiveTemplates.Storages.ITemplateStorage PredefinedStorage { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.DataFlow.CollectionEvents<JetBrains.ReSharper.Feature.Services.LiveTemplates.Storages.ITemplateStorage> TemplateStorages { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Feature.Services.LiveTemplates.Storages.ITemplateStorage UserStorage { get; }
        bool UidUsed(System.Guid uid);
    }
    public interface ITemplateStorage
    {
        JetBrains.DataFlow.ICollectionEvents<JetBrains.ReSharper.LiveTemplates.Templates.Template> Templates { get; }
        string Intern(string value);
    }
    public class ManagedQuickLists
    {
        public ManagedQuickLists(JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Feature.Services.LiveTemplates.Storages.ITemplateFamily templateFamily, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.LiveTemplates.Support.QuickListSupport> quickListSupports) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.LiveTemplates.QuickLists.QuickListEx> QuickListsEx { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.LiveTemplates.QuickLists.QuickListEx> MatchOldQuicklists(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.LiveTemplates.QuickLists.QuickList> quickLists) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.LiveTemplates.QuickLists.QuickList> ReadFromXml(System.Xml.XmlElement element, bool configure) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.LiveTemplates.QuickLists.QuickList> UpgradeFromXml(System.Xml.XmlElement element) { }
    }
    public class PredefinedStorage : JetBrains.ReSharper.Feature.Services.LiveTemplates.Storages.TemplateStorageBase
    {
        public PredefinedStorage([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Feature.Services.LiveTemplates.Storages.ITemplateFamily family) { }
        protected override bool ReadOnly { get; }
        public void ApplyChangedTemplate(JetBrains.ReSharper.LiveTemplates.Templates.Template changedTemplate) { }
        public void ReadChangesFromUserSettings(System.Xml.XmlElement element) { }
        public void ReadConfigurationFile(System.Xml.XmlElement element) { }
        protected override void ReplaceTemplate(JetBrains.ReSharper.LiveTemplates.Templates.Template toReplace, JetBrains.ReSharper.LiveTemplates.Templates.Template replaceWith) { }
    }
    public class SerializationStorage : JetBrains.ReSharper.Feature.Services.LiveTemplates.Storages.FileStorage
    {
        public SerializationStorage(JetBrains.Util.FileSystemPath filePath, JetBrains.ReSharper.Feature.Services.LiveTemplates.Settings.TemplateApplicability applicability) { }
        public string LoadedFamilyTitle { get; }
        protected override bool OnTemplateAdded(JetBrains.ReSharper.LiveTemplates.Templates.Template template) { }
        public override void ReadTemplates(System.Xml.XmlElement element, JetBrains.ReSharper.Feature.Services.LiveTemplates.Settings.TemplateApplicability applicability) { }
    }
    public class SolutionStorage : JetBrains.ReSharper.Feature.Services.LiveTemplates.Storages.TemplateStorageBase
    {
        public SolutionStorage(JetBrains.ReSharper.Feature.Services.LiveTemplates.Storages.SolutionStorageScope scope) { }
        protected override bool ReadOnly { get; }
    }
    public enum SolutionStorageScope
    {
        Global = 0,
        User = 1,
    }
    [JetBrains.ProjectModel.Settings.Upgrade.SolutionSettingsUpgraderAttribute()]
    public class SolutionTemplatesUpgrader : JetBrains.Application.Configuration.Upgrade.ISettingsUpgrader, JetBrains.ProjectModel.Settings.Upgrade.ISolutionSettingsUpgrader
    {
        public void Upgrade(JetBrains.Application.Configuration.IComponentSettingsProvider legacySettingsProvider, JetBrains.Application.Settings.IContextBoundSettingsStore boundSettingsStore, JetBrains.DataFlow.Lifetime upgradeLifetime) { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class StoragesLegacyHacks
    {
        public StoragesLegacyHacks(JetBrains.UI.Application.IUIApplication environment) { }
        public JetBrains.ReSharper.Feature.Services.LiveTemplates.Storages.ApplicabilityDescriptor GetDescriptor(JetBrains.ReSharper.Feature.Services.LiveTemplates.Settings.TemplateApplicability applicability) { }
    }
    public abstract class TemplateFamily : JetBrains.ReSharper.Feature.Services.LiveTemplates.Storages.ITemplateFamily
    {
        protected TemplateFamily() { }
        public abstract JetBrains.ReSharper.Feature.Services.LiveTemplates.Settings.TemplateApplicability Applicability { get; }
        public JetBrains.ReSharper.Feature.Services.LiveTemplates.Storages.ITemplateStorage PredefinedStorage { get; }
        public string ReSharper1XKindName { get; set; }
        public JetBrains.DataFlow.CollectionEvents<JetBrains.ReSharper.Feature.Services.LiveTemplates.Storages.ITemplateStorage> TemplateStorages { get; }
        public JetBrains.ReSharper.Feature.Services.LiveTemplates.Storages.ITemplateStorage UserStorage { get; }
        public void ConfigureFromXml(System.Xml.XmlElement element) { }
        public virtual void ReadFromXml(System.Xml.XmlElement element) { }
        public bool UidUsed(System.Guid uid) { }
        public virtual void UpgradeFromXml(System.Xml.XmlElement element, System.Version version) { }
    }
    public abstract class TemplateStorageBase : JetBrains.ReSharper.Feature.Services.LiveTemplates.Storages.ITemplateStorage
    {
        protected TemplateStorageBase([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Feature.Services.LiveTemplates.Storages.ITemplateFamily family = null) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        protected JetBrains.ReSharper.Feature.Services.LiveTemplates.Storages.ITemplateFamily Family { get; }
        protected abstract bool ReadOnly { get; }
        public JetBrains.DataFlow.ICollectionEvents<JetBrains.ReSharper.LiveTemplates.Templates.Template> Templates { get; }
        protected void AddTemplateInternal([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.LiveTemplates.Templates.Template template) { }
        public string Intern(string value) { }
        protected virtual bool OnTemplateAdded(JetBrains.ReSharper.LiveTemplates.Templates.Template template) { }
        public virtual void ReadTemplates([JetBrains.Annotations.NotNullAttribute()] System.Xml.XmlElement element, JetBrains.ReSharper.Feature.Services.LiveTemplates.Settings.TemplateApplicability applicability) { }
        protected virtual void ReplaceTemplate(JetBrains.ReSharper.LiveTemplates.Templates.Template toReplace, JetBrains.ReSharper.LiveTemplates.Templates.Template replaceWith) { }
    }
    public class UserStorage : JetBrains.ReSharper.Feature.Services.LiveTemplates.Storages.TemplateStorageBase
    {
        public UserStorage([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Feature.Services.LiveTemplates.Storages.ITemplateFamily family) { }
        protected override bool ReadOnly { get; }
        public void ReadUserSettings(System.Xml.XmlElement element) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.LiveTemplates.Support
{
    
    [JetBrains.Application.ShellComponentAttribute()]
    public class AllFileScopeProvider : JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ScopeProvider
    {
        public AllFileScopeProvider() { }
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint> ProvideScopePoints(JetBrains.ReSharper.Feature.Services.LiveTemplates.Context.TemplateAcceptanceContext context) { }
    }
    [JetBrains.ReSharper.Feature.Services.LiveTemplates.Support.FileTemplatesAttribute()]
    public sealed class AllFileTemplatesSupport : JetBrains.ReSharper.Feature.Services.LiveTemplates.Support.IFileTemplatesSupport
    {
        public static readonly JetBrains.ReSharper.Feature.Services.LiveTemplates.Support.IFileTemplatesSupport Instance;
        public string Name { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint> ScopePoints { get; }
        public bool Accepts(JetBrains.ProjectModel.IProject project) { }
    }
    [JetBrains.Annotations.MeansImplicitUseAttribute()]
    [System.AttributeUsageAttribute(System.AttributeTargets.Class | System.AttributeTargets.All, AllowMultiple=false)]
    public class FileTemplatesAttribute : JetBrains.Application.ShellComponentAttribute { }
    public interface IFileTemplatesSupport
    {
        string Name { get; }
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint> ScopePoints { get; }
        bool Accepts(JetBrains.ProjectModel.IProject project);
    }
    public class QuickListSupport
    {
        public QuickListSupport(JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.IMainScopePoint mainPoint) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.IMainScopePoint MainPoint { get; }
        public string Title { get; }
        public bool AcceptAcceptanceContext(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint> realScopePoints) { }
        [System.ObsoleteAttribute("Deprecated, use overload with scope points")]
        public bool AcceptAcceptanceContext(JetBrains.ReSharper.Feature.Services.LiveTemplates.Context.TemplateAcceptanceContext context) { }
        [System.ObsoleteAttribute("Deprecated, use overload with scope points")]
        public bool AcceptTemplateContext(JetBrains.ReSharper.Feature.Services.LiveTemplates.Context.ITemplateContext context) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.LiveTemplates.SurroundTemplates
{
    
    public class SupportedQuickList
    {
        public SupportedQuickList(JetBrains.ReSharper.Feature.Services.LiveTemplates.Support.QuickListSupport quickListSupport, JetBrains.ReSharper.Feature.Services.LiveTemplates.QuickLists.QuickList quickList) { }
        public JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.IMainScopePoint MainPoint { get; }
        public JetBrains.ReSharper.Feature.Services.LiveTemplates.QuickLists.QuickList QuickList { get; }
        public JetBrains.ReSharper.Feature.Services.LiveTemplates.Support.QuickListSupport QuickListSupport { get; }
        public override string ToString() { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class SurroundManager
    {
        public SurroundManager(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ReSharper.Feature.Services.LiveTemplates.LiveTemplates.LiveTemplatesManager liveTemplatesManager, JetBrains.DataFlow.IViewable<JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.IScopeCategoryUIProvider> scopeCategoryUIProviders, JetBrains.Application.Settings.ISettingsStore settingsStore, JetBrains.ReSharper.Feature.Services.LiveTemplates.Settings.StoredTemplatesProvider storedTemplatesProvider, JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.TemplateScopeManager templateScopeManager) { }
        public static JetBrains.ReSharper.Feature.Services.LiveTemplates.SurroundTemplates.SurroundManager Instance { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.LiveTemplates.Support.QuickListSupport> QuickListSupports { get; }
        public void Execute(JetBrains.ReSharper.LiveTemplates.Templates.Template surround, JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        public System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.LiveTemplates.SurroundTemplates.SurroundManager.SurroundTemplateItem> GetSurroundTemplates(JetBrains.ReSharper.Feature.Services.LiveTemplates.Context.TemplateAcceptanceContext context) { }
        public System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.LiveTemplates.SurroundTemplates.SurroundManager.SurroundTemplateItem> GetSurroundTemplates(System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint> realScopePoints, System.Func<JetBrains.DataFlow.Lifetime, JetBrains.Application.DataContext.DataContexts, JetBrains.Application.DataContext.IDataContext> dataContext) { }
        public class SurroundTemplateItem
        {
            public string Mnemonic;
            public JetBrains.ReSharper.LiveTemplates.Templates.Template Template;
        }
    }
    public class SurroundTemplatesFamily : JetBrains.ReSharper.Feature.Services.LiveTemplates.Storages.TemplateFamily
    {
        public override JetBrains.ReSharper.Feature.Services.LiveTemplates.Settings.TemplateApplicability Applicability { get; }
    }
    [JetBrains.Application.Configuration.XmlConfigurableAttribute(ConfigurationResourceName="JetBrains.ReSharper.Feature.Services.src.LiveTemplates.SurroundTemplates.Surround" +
        "Manager.xml")]
    public class SurroundTemplatesReader : JetBrains.ReSharper.Feature.Services.LiveTemplates.LiveTemplates.OldTemplatesReader, JetBrains.Application.Configuration.IXmlReadable, JetBrains.Application.Configuration.IXmlUpgradable
    {
        public SurroundTemplatesReader(JetBrains.DataFlow.Lifetime lifetime, JetBrains.DataFlow.IViewable<JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.IScopeCategoryUIProvider> scopeCategoryUIProviders, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.Application.Settings.ISettingsStore settingsStore, JetBrains.Threading.IThreading threading) { }
        public System.Collections.Generic.IEnumerable<string> LegacyTagNames { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.LiveTemplates.QuickLists.QuickListEx> LoadedQuickLists { get; }
        public JetBrains.ReSharper.Feature.Services.LiveTemplates.SurroundTemplates.SurroundTemplatesFamily SurroundsTemplateFamily { get; }
        public override void ConfigureFromXml(System.Xml.XmlElement element) { }
        public void ReadFromXml(System.Xml.XmlElement element) { }
        public bool UpgradeFromXml(System.Xml.XmlElement element, System.Version version) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.LiveTemplates.Templates
{
    
    public class TemplateLexer : JetBrains.ReSharper.Psi.Parsing.ILexer
    {
        public TemplateLexer(JetBrains.Text.IBuffer buffer, JetBrains.ReSharper.Psi.Parsing.ILexerFactory lexerFactory) { }
        public JetBrains.Text.IBuffer Buffer { get; }
        public object CurrentPosition { get; set; }
        public int TokenEnd { get; }
        public int TokenStart { get; }
        public JetBrains.ReSharper.Psi.Parsing.TokenNodeType TokenType { get; }
        public void Advance() { }
        public void Start() { }
    }
    public class static TemplateUtil
    {
        public static System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.LiveTemplates.QuickLists.TemplateReference> EnumerateReferences(System.Xml.XmlElement element) { }
        public static System.Collections.Generic.IEnumerable<JetBrains.ReSharper.LiveTemplates.Templates.Template> EnumerateTemplatesFromFolderStructure(JetBrains.ReSharper.Feature.Services.LiveTemplates.Storages.ITemplateStorage storage, [JetBrains.Annotations.NotNullAttribute()] System.Xml.XmlElement element, JetBrains.ReSharper.Feature.Services.LiveTemplates.Settings.TemplateApplicability applicability) { }
        public static JetBrains.ReSharper.Feature.Services.LiveTemplates.Templates.TemplateUtil.TemplateExpansionData GetHotspots(System.Collections.Generic.ICollection<JetBrains.ReSharper.LiveTemplates.TemplateField> templateFields, JetBrains.DocumentModel.IDocument document, int startOffset, string text, JetBrains.ProjectModel.ISolution solution) { }
        public static string GetPresentableName(this JetBrains.ReSharper.LiveTemplates.Templates.Template template) { }
        public static string GetSurroundMnemonic(int index) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.TextControl.ITextControl GetTextControl(JetBrains.DocumentModel.DocumentRange range, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ProjectModel.ISolution solution, bool existingOnly = False) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.TextControl.ITextControl GetTextControl(JetBrains.DocumentModel.IDocument document, JetBrains.ProjectModel.ISolution solution, bool existingOnly = False) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.TextControl.ITextControl GetTextControl(JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotContext context) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.TextControl.ITextControl GetTextControl(JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotSession hotspotSession) { }
        public static void ReplacePlaceholders(System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<JetBrains.ReSharper.LiveTemplates.TemplateField, System.Collections.Generic.IList<JetBrains.DocumentModel.IRangeMarker>>> hotspotRanges, JetBrains.DocumentModel.IDocument document) { }
        public class TemplateExpansionData
        {
            public TemplateExpansionData() { }
            public JetBrains.DocumentModel.IRangeMarker EndRange { get; set; }
            public JetBrains.Util.OneToListMap<JetBrains.ReSharper.LiveTemplates.TemplateField, JetBrains.DocumentModel.IRangeMarker> HotspotRanges { get; }
            public System.Collections.Generic.ICollection<JetBrains.DocumentModel.IRangeMarker> RangesToRemove { get; }
            public JetBrains.DocumentModel.IRangeMarker SelectionRange { get; set; }
            public bool SelectionRangeInverted { get; set; }
            public System.Collections.Generic.ICollection<JetBrains.DocumentModel.IRangeMarker> SelectionTextRanges { get; }
        }
    }
}
namespace JetBrains.ReSharper.Feature.Services.LiveTemplates.Util
{
    
    public class static TemplateActionsUtil
    {
        public static JetBrains.ReSharper.Feature.Services.LiveTemplates.Util.TemplateLookupItem[] GetLookupItems(JetBrains.TextControl.ITextControl editor, JetBrains.ProjectModel.ISolution solution, bool showDescription, bool matchPrefix) { }
    }
    public class TemplateLookupItem : JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem
    {
        public TemplateLookupItem(JetBrains.ReSharper.Psi.PsiIconManager psiIconManager, JetBrains.ReSharper.LiveTemplates.Templates.Template template, bool showDescription) { }
        public bool CanShrink { get; }
        public JetBrains.UI.RichText.RichText DisplayName { get; }
        public JetBrains.UI.RichText.RichText DisplayTypeName { get; }
        public string Identity { get; }
        public bool IgnoreSoftOnSpace { get; set; }
        public JetBrains.UI.Icons.IconId Image { get; }
        public bool IsDynamic { get; }
        public int Multiplier { get; set; }
        public string OrderingString { get; set; }
        public JetBrains.ReSharper.LiveTemplates.Templates.Template Template { get; }
        public void Accept(JetBrains.TextControl.ITextControl textControl, JetBrains.Util.TextRange nameRange, JetBrains.ReSharper.Feature.Services.Lookup.LookupItemInsertType lookupItemInsertType, JetBrains.ReSharper.Feature.Services.Lookup.Suffix suffix, JetBrains.ProjectModel.ISolution solution, bool keepCaretStill) { }
        public bool AcceptIfOnlyMatched(JetBrains.ReSharper.Feature.Services.Lookup.LookupItemAcceptanceContext itemAcceptanceContext) { }
        public object GetData(string dataID) { }
        public JetBrains.Util.TextRange GetVisualReplaceRange(JetBrains.TextControl.ITextControl textControl, JetBrains.Util.TextRange nameRange) { }
        public JetBrains.ReSharper.Feature.Services.Lookup.MatchingResult Match(string prefix, JetBrains.TextControl.ITextControl textControl) { }
        public bool Shrink() { }
        public void Unshrink() { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.Lookup
{
    
    public delegate void AfterCompletionHandler(JetBrains.TextControl.ITextControl textControl, ref JetBrains.Util.TextRange nameRange, ref JetBrains.Util.TextRange decorationRange, JetBrains.ReSharper.Psi.ExpectedTypes.TailType tailType, ref JetBrains.ReSharper.Feature.Services.Lookup.Suffix suffix, ref JetBrains.DocumentModel.IRangeMarker caretPositionRangeMarker);
    public class AsyncLookupParameterInfoHandler : JetBrains.ReSharper.Feature.Services.ParameterInfo.IParameterInfoProvider, System.IDisposable
    {
        public JetBrains.ReSharper.Feature.Services.ParameterInfo.IParameterInfoContext Context { get; }
        public JetBrains.UI.PopupWindowManager.HideFlags HideFlags { get; }
        public event System.EventHandler ContextChanged;
        public JetBrains.UI.PopupWindowManager.IPopupWindowContext CreatePopupWindowContext(JetBrains.DataFlow.Lifetime lifetime) { }
        public void Dispose() { }
        public static void DoWithHandler(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ReSharper.Feature.Services.Lookup.ILookup lookup, bool automatic, System.Action<JetBrains.ReSharper.Feature.Services.Lookup.AsyncLookupParameterInfoHandler> afterCreated) { }
    }
    public class AttributeLookupItem : JetBrains.ReSharper.Feature.Services.Lookup.TextLookupItemBase, JetBrains.ReSharper.Feature.Services.Lookup.IDeclaredElementLookupItem, JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem, JetBrains.Util.IUserDataHolder
    {
        public AttributeLookupItem(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, JetBrains.ReSharper.Feature.Services.Lookup.IElementPointerFactory elementPointerFactory, JetBrains.ReSharper.Psi.PsiLanguageType languageType, bool showContainer, JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.CodeCompletionContext basicContext) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.DeclaredElementInstance> AllDeclaredElements { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Pointers.IElementInstancePointer<JetBrains.ReSharper.Psi.IDeclaredElement>> DeclaredElementPointers { get; }
        public override JetBrains.UI.Icons.IconId Image { get; }
        public JetBrains.ReSharper.Psi.PsiLanguageType LanguageType { get; }
        public JetBrains.ReSharper.Psi.DeclaredElementInstance PreferredDeclaredElement { get; }
        protected override JetBrains.UI.RichText.RichText GetDisplayName() { }
        protected override void OnAfterComplete(JetBrains.TextControl.ITextControl textControl, ref JetBrains.Util.TextRange nameRange, ref JetBrains.Util.TextRange decorationRange, JetBrains.ReSharper.Psi.ExpectedTypes.TailType tailType, ref JetBrains.ReSharper.Feature.Services.Lookup.Suffix suffix, ref JetBrains.DocumentModel.IRangeMarker caretPositionRangeMarker) { }
    }
    public class CachingLookupItemPainter : JetBrains.ReSharper.Feature.Services.Lookup.LookupItemPainter
    {
        public CachingLookupItemPainter(JetBrains.ReSharper.Feature.Services.Lookup.LookupWindowOptions lookupWindowOptions, JetBrains.ProjectModel.ISolution solution, JetBrains.UI.Icons.IThemedIconManager themedIconManager) { }
        public override System.Drawing.Size GetSize(JetBrains.ReSharper.Feature.Services.Lookup.LookupListItem listViewItem, JetBrains.UI.IGraphicsContainer g) { }
    }
    public class CharSuffix : JetBrains.ReSharper.Feature.Services.Lookup.Suffix
    {
        public CharSuffix(char presentation) { }
        public override bool HasPresentation { get; }
        public override char Presentation { get; }
        public override void Playback(JetBrains.TextControl.ITextControl textControl) { }
    }
    public struct CompletionConfiguration
    {
        public static readonly JetBrains.ReSharper.Feature.Services.Lookup.CompletionConfiguration Empty;
        public CompletionConfiguration(JetBrains.Util.TextRange range, string text, int caretOffset) { }
        public int CaretOffset { get; }
        public JetBrains.Util.TextRange Range { get; }
        public string Text { get; }
    }
    public delegate void CompletionConfigurationProcessor(JetBrains.TextControl.ITextControl textControl, JetBrains.Util.TextRange nameRange, JetBrains.ReSharper.Feature.Services.Lookup.LookupItemInsertType insertType, JetBrains.ReSharper.Feature.Services.Lookup.Suffix suffix, ref JetBrains.ReSharper.Feature.Services.Lookup.CompletionConfiguration configuration);
    public delegate void CompletionHandler(object sender, JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem lookupItem, JetBrains.ReSharper.Feature.Services.Lookup.Suffix suffix, JetBrains.ReSharper.Feature.Services.Lookup.LookupItemInsertType lookupItemInsertType);
    public class ContextTracker : JetBrains.Application.IChangeProvider, System.IDisposable
    {
        public ContextTracker(JetBrains.TextControl.ITextControl textControl, JetBrains.Util.TextRange textRange, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Feature.Services.Lookup.ILookupWindowManager lookupWindowManager) { }
        public bool DisallowChangesAfterInitialOffset { get; set; }
        public JetBrains.Util.TextRange FullRange { get; }
        public bool InitialPrefixIsShortest { get; set; }
        public bool IsValid { get; }
        public System.Nullable<JetBrains.ReSharper.Feature.Services.Lookup.LookupItemAcceptanceContext> ItemAcceptanceContext { get; }
        public event System.EventHandler ContextChanged;
        public void Dispose() { }
    }
    public abstract class CreateLocalVariableLookupItemBase : JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem
    {
        protected readonly string myExpectedName;
        protected readonly System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Naming.Impl.NameRoot> myExpectedRoots;
        protected readonly JetBrains.ReSharper.Psi.ITypePointer myTypePointer;
        protected CreateLocalVariableLookupItemBase(JetBrains.ReSharper.Psi.IType type, string expectedName, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Naming.Impl.NameRoot> expectedRoots, JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
        protected abstract string ArgumentModifier { get; }
        public bool CanShrink { get; }
        public JetBrains.UI.RichText.RichText DisplayName { get; }
        public JetBrains.UI.RichText.RichText DisplayTypeName { get; }
        public string Identity { get; }
        public bool IgnoreSoftOnSpace { get; set; }
        public JetBrains.UI.Icons.IconId Image { get; }
        public bool IsDynamic { get; }
        protected abstract JetBrains.ReSharper.Psi.PsiLanguageType Language { get; }
        public int Multiplier { get; set; }
        public string OrderingString { get; }
        public bool ShowType { get; set; }
        public JetBrains.ReSharper.Psi.ExpectedTypes.TailType TailType { get; set; }
        public virtual void Accept(JetBrains.TextControl.ITextControl textControl, JetBrains.Util.TextRange nameRange, JetBrains.ReSharper.Feature.Services.Lookup.LookupItemInsertType lookupItemInsertType, JetBrains.ReSharper.Feature.Services.Lookup.Suffix suffix, JetBrains.ProjectModel.ISolution solution, bool keepCaretStill) { }
        public bool AcceptIfOnlyMatched(JetBrains.ReSharper.Feature.Services.Lookup.LookupItemAcceptanceContext itemAcceptanceContext) { }
        protected abstract JetBrains.ReSharper.Psi.Tree.IDeclaration CreateLocalVariableDeclaration(JetBrains.ReSharper.Psi.Tree.ITreeNode nameElement, string safeName, JetBrains.ReSharper.Feature.Services.Lookup.CreateLocalVariableLookupItemBase.ElementFinder nameElementFinder);
        public JetBrains.Util.TextRange GetVisualReplaceRange(JetBrains.TextControl.ITextControl textControl, JetBrains.Util.TextRange nameRange) { }
        public JetBrains.ReSharper.Feature.Services.Lookup.MatchingResult Match(string prefix, JetBrains.TextControl.ITextControl textControl) { }
        public bool Shrink() { }
        public void Unshrink() { }
        protected sealed class ElementFinder : JetBrains.ReSharper.Psi.IRecursiveElementProcessor
        {
            public ElementFinder(JetBrains.Util.Key<object> key) { }
            public JetBrains.ReSharper.Psi.Tree.ITreeNode Element { get; }
            public bool ProcessingIsFinished { get; }
            public bool InteriorShouldBeProcessed(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
            public void ProcessAfterInterior(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
            public void ProcessBeforeInterior(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        }
    }
    public abstract class DeclaredElementLookupItem : JetBrains.ReSharper.Feature.Services.Lookup.TextLookupItemBase, JetBrains.ReSharper.Feature.Services.Lookup.IDeclaredElementLookupItem, JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem, JetBrains.ReSharper.Feature.Services.Lookup.IParameterInfoProvidingLookupItem, JetBrains.ReSharper.Feature.Services.Lookup.ITextualDeclaredElementLookupItem, JetBrains.ReSharper.Feature.Services.Lookup.ITextualLookupItem, JetBrains.Util.IUserDataHolder
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public static readonly JetBrains.ReSharper.Psi.DeclaredElementPresenterStyle DefaultPresenterStyle;
        protected readonly JetBrains.ReSharper.Psi.Pointers.IElementInstancePointer<JetBrains.ReSharper.Psi.IDeclaredElement> myPointer;
        protected readonly string myShortName;
        protected DeclaredElementLookupItem([JetBrains.Annotations.NotNullAttribute()] string name, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.DeclaredElementInstance instance, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Feature.Services.Lookup.IElementPointerFactory elementPointerFactory, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.PsiLanguageType languageType, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Feature.Services.Lookup.ILookupItemsOwner owner) { }
        public virtual System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.DeclaredElementInstance> AllDeclaredElements { get; }
        public bool Bind { get; set; }
        public virtual System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.ExpectedTypes.InvocationCandidate> Candidates { get; }
        public override bool CanShrink { get; }
        public virtual System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Pointers.IElementInstancePointer<JetBrains.ReSharper.Psi.IDeclaredElement>> DeclaredElementPointers { get; }
        public virtual bool HasCandidates { get; }
        public JetBrains.ReSharper.Psi.ExpectedTypes.HeadType HeadType { get; set; }
        public bool Highlight { get; set; }
        public override string Identity { get; }
        public override JetBrains.UI.Icons.IconId Image { get; }
        public bool IsObsolete { get; set; }
        public JetBrains.ReSharper.Psi.PsiLanguageType LanguageType { get; }
        public JetBrains.ReSharper.Feature.Services.Lookup.ILookupItemsOwner Owner { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public virtual JetBrains.ReSharper.Psi.DeclaredElementInstance PreferredDeclaredElement { get; }
        public virtual JetBrains.ReSharper.Psi.DeclaredElementPresenterStyle PresenterStyle { get; }
        public string Qualifier { get; }
        public JetBrains.ReSharper.Psi.Resolve.QualifierKind QualifierKind { get; set; }
        public string ShortName { get; }
        public JetBrains.ProjectModel.ISolution Solution { get; }
        public override string Text { get; set; }
        protected void AddContainerToName([JetBrains.Annotations.NotNullAttribute()] JetBrains.UI.RichText.RichText displayName) { }
        protected virtual string BuildDisplayNameText(out JetBrains.Util.TextRange nameRange) { }
        public virtual System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.ParameterInfo.ICandidate> CreateCandidates() { }
        protected override JetBrains.UI.RichText.RichText GetDisplayName() { }
        protected virtual string GetPresentedName(JetBrains.ReSharper.Psi.DeclaredElementInstance instance, out JetBrains.ReSharper.Psi.DeclaredElementPresenterMarking marking) { }
        protected virtual string GetText() { }
        protected virtual string MakeSafe(string shortName) { }
        public override JetBrains.ReSharper.Feature.Services.Lookup.MatchingResult Match(string prefix, JetBrains.TextControl.ITextControl textControl) { }
        protected override void OnAfterComplete(JetBrains.TextControl.ITextControl textControl, ref JetBrains.Util.TextRange nameRange, ref JetBrains.Util.TextRange decorationRange, JetBrains.ReSharper.Psi.ExpectedTypes.TailType tailType, ref JetBrains.ReSharper.Feature.Services.Lookup.Suffix suffix, ref JetBrains.DocumentModel.IRangeMarker caretPositionRangeMarker) { }
        [JetBrains.Annotations.NotNullAttribute()]
        protected string Replace([JetBrains.Annotations.NotNullAttribute()] string str, JetBrains.Util.TextRange range, [JetBrains.Annotations.CanBeNullAttribute()] string replace) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        protected JetBrains.ReSharper.Psi.DeclaredElementInstance<JetBrains.ReSharper.Psi.IDeclaredElement> SafeResolveElementPointer() { }
        public override bool Shrink() { }
        public override void Unshrink() { }
        protected void UpdatePresentation() { }
    }
    public class DeclaredElementLookupItemImpl : JetBrains.ReSharper.Feature.Services.Lookup.DeclaredElementLookupItem
    {
        public DeclaredElementLookupItemImpl([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.DeclaredElementInstance instance, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Feature.Services.Lookup.IElementPointerFactory elementPointerFactory, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.PsiLanguageType languageType, JetBrains.ReSharper.Feature.Services.Lookup.ILookupItemsOwner owner) { }
    }
    public class DefaultElementPointerFactory : JetBrains.ReSharper.Feature.Services.Lookup.IElementPointerFactory
    {
        public static readonly JetBrains.ReSharper.Feature.Services.Lookup.DefaultElementPointerFactory Instance;
    }
    public class DefaultSuffixFactory : JetBrains.ReSharper.Feature.Services.Lookup.ISuffixFactory
    {
        public static readonly JetBrains.ReSharper.Feature.Services.Lookup.ISuffixFactory Instance;
        public virtual JetBrains.ReSharper.Feature.Services.Lookup.Suffix CreateSuffixForChar(char c) { }
        public virtual JetBrains.ReSharper.Feature.Services.Lookup.Suffix CreateSuffixForEnter() { }
        public virtual JetBrains.ReSharper.Feature.Services.Lookup.Suffix CreateSuffixForForceInsert() { }
        public virtual JetBrains.ReSharper.Feature.Services.Lookup.Suffix CreateSuffixForTab() { }
    }
    public class EnterSuffix : JetBrains.ReSharper.Feature.Services.Lookup.Suffix
    {
        public override bool HasPresentation { get; }
        public override char Presentation { get; }
        public override void Playback(JetBrains.TextControl.ITextControl textControl) { }
    }
    public sealed class FilteredLookupItems
    {
        public FilteredLookupItems(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem> sortedItems, string prefix, JetBrains.TextControl.ITextControl textControl, System.Func<JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem, string, JetBrains.TextControl.ITextControl, JetBrains.ReSharper.Feature.Services.Lookup.MatchingResult> matchFunc, bool preserveOrder = False, System.Collections.Generic.JetHashSet<JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem> stableItems = null, JetBrains.ReSharper.Feature.Services.Lookup.ItemsLocation stableItemsLocation = 2) { }
        public System.Collections.Generic.IList<JetBrains.Util.Pair<JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem, JetBrains.ReSharper.Feature.Services.Lookup.MatchingResult>> Items { get; }
        public System.Collections.Generic.SortedList<int, System.Collections.Generic.List<JetBrains.Util.Pair<JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem, JetBrains.ReSharper.Feature.Services.Lookup.MatchingResult>>> ScoredItems { get; }
        public JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem GetClosestItem() { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem> GetContinuation(char c) { }
        public bool HasContinuation(char c) { }
    }
    public class GroupedItemsCollector
    {
        public GroupedItemsCollector() { }
        public System.Collections.Generic.List<System.Action<JetBrains.DataFlow.Lifetime>> EmptyListHandlers { get; set; }
        public System.Collections.Generic.List<JetBrains.ReSharper.Feature.Services.Lookup.ILookupItemsPreference> Filters { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem> Items { get; }
        public JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.TextLookupRanges Ranges { get; }
        public JetBrains.ReSharper.Feature.Services.Lookup.ILookupItemSelectionStrategy SelectionStrategy { get; }
        public event System.Action<JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem> ItemAdded;
        public void AddAtDefaultPlace(JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem item) { }
        public void AddEmptyListHandler(System.Action<JetBrains.DataFlow.Lifetime> emptyListTooltip) { }
        public void AddFilter(JetBrains.ReSharper.Feature.Services.Lookup.ILookupItemsPreference filter) { }
        public void AddRanges(JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.TextLookupRanges ranges) { }
        public void AddToBottom(JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem item) { }
        public void AddToTop(JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem item) { }
        public void Clear() { }
        public System.IDisposable HandleItems(System.Action<JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem> handler) { }
        public void Remove(JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem item) { }
    }
    public interface IDeclaredElementLookupItem : JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem, JetBrains.Util.IUserDataHolder
    {
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.DeclaredElementInstance> AllDeclaredElements { get; }
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Pointers.IElementInstancePointer<JetBrains.ReSharper.Psi.IDeclaredElement>> DeclaredElementPointers { get; }
        JetBrains.ReSharper.Psi.PsiLanguageType LanguageType { get; }
        JetBrains.ReSharper.Psi.DeclaredElementInstance PreferredDeclaredElement { get; }
    }
    public interface IDescriptionProvidingLookupItem
    {
        JetBrains.UI.RichText.RichTextBlock GetDescription();
    }
    public interface IElementPointerFactory
    {
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Pointers.IElementInstancePointer<T> CreateElementPointer<T>([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.DeclaredElementInstance<T> instance)
            where T :  class, JetBrains.ReSharper.Psi.IDeclaredElement;
    }
    public interface IKeywordLookupItem { }
    public interface IListItemDescriptor
    {
        JetBrains.UI.Icons.IconId Image { get; }
        JetBrains.UI.RichText.RichText RichText { get; }
        object Tag { get; }
    }
    public interface IListItemPainter<T> : JetBrains.UI.Components.CustomListBox.IItemPainter<T>, System.IDisposable
        where T :  class, JetBrains.ReSharper.Feature.Services.Lookup.IListItemDescriptor
    {
        JetBrains.UI.Controls.CustomListBoxControl<T> ListBox { get; set; }
        void Add(T item);
        void Clear();
        bool ConstrainToWidth(int width, System.Drawing.Graphics g);
        void ResetConstraints();
    }
    public interface ILookup : JetBrains.Util.IUserDataHolder, System.IDisposable
    {
        bool IsClosed { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem> Items { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Feature.Services.Lookup.LookupWindowOptions Options { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        string Prefix { get; }
        JetBrains.ReSharper.Feature.Services.Lookup.LookupSelection Selection { get; }
        JetBrains.ProjectModel.ISolution Solution { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.TextControl.ITextControl TextControl { get; }
        JetBrains.Util.TextRange TextRange { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Feature.Services.Lookup.ILookupWindow Window { get; }
        public event JetBrains.ReSharper.Feature.Services.Lookup.ItemsHandler BeforeShownItemsUpdated;
        public event System.EventHandler Closed;
        public event System.EventHandler CurrentItemChanged;
        public event JetBrains.ReSharper.Feature.Services.Lookup.CompletionHandler ItemCompleted;
        public event System.EventHandler<JetBrains.DataFlow.EventArgs<char>> Typing;
        bool ApplyItemOnTyping(char c);
        void Close();
        bool Complete(JetBrains.ReSharper.Feature.Services.Lookup.Suffix suffix, JetBrains.ReSharper.Feature.Services.Lookup.LookupItemInsertType lookupItemInsertType);
        JetBrains.ReSharper.Feature.Services.Lookup.LookupItemCompletor CreateCompletor(JetBrains.ReSharper.Feature.Services.Lookup.Suffix sufix, JetBrains.ReSharper.Feature.Services.Lookup.LookupItemInsertType insertType);
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem> GetContinuation(char c);
        void HandleKeyDown(System.Windows.Forms.KeyEventArgs args);
        bool HasContinuationInCurrentItemsList(char c);
        JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.CompletionAction IsCharacterAcceptable(char c);
        void NotifyTyping(char c);
        void ShowLookup();
        void WaitForCurrentItems();
    }
    public interface ILookupItem
    {
        bool CanShrink { get; }
        JetBrains.UI.RichText.RichText DisplayName { get; }
        JetBrains.UI.RichText.RichText DisplayTypeName { get; }
        string Identity { get; }
        bool IgnoreSoftOnSpace { get; set; }
        JetBrains.UI.Icons.IconId Image { get; }
        bool IsDynamic { get; }
        int Multiplier { get; set; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        string OrderingString { get; }
        void Accept(JetBrains.TextControl.ITextControl textControl, JetBrains.Util.TextRange nameRange, JetBrains.ReSharper.Feature.Services.Lookup.LookupItemInsertType lookupItemInsertType, JetBrains.ReSharper.Feature.Services.Lookup.Suffix suffix, JetBrains.ProjectModel.ISolution solution, bool keepCaretStill);
        bool AcceptIfOnlyMatched(JetBrains.ReSharper.Feature.Services.Lookup.LookupItemAcceptanceContext itemAcceptanceContext);
        JetBrains.Util.TextRange GetVisualReplaceRange(JetBrains.TextControl.ITextControl textControl, JetBrains.Util.TextRange nameRange);
        JetBrains.ReSharper.Feature.Services.Lookup.MatchingResult Match(string prefix, JetBrains.TextControl.ITextControl textControl);
        bool Shrink();
        void Unshrink();
    }
    public interface ILookupItemSelectionStrategy
    {
        JetBrains.ReSharper.Feature.Services.Lookup.LookupSelection GetSelection(JetBrains.ReSharper.Feature.Services.Lookup.FilteredLookupItems items, JetBrains.ReSharper.Feature.Services.Lookup.LookupSelection currentSelection, JetBrains.ReSharper.Feature.Services.Lookup.LookupSelectionKind lookupSelectionKind);
    }
    public interface ILookupItemsOwner
    {
        JetBrains.ReSharper.Feature.Services.CodeCompletion.EditorBrowsableProcessingType EditorBrowsableProcessing { get; }
        JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.IntellisenseEnabledType IntellisenseEnabled { get; }
        bool KeywordCompletionEnabled { get; }
        int KeywordCompletionMinLength { get; }
        JetBrains.Text.IdentifierMatchingStyle MatchingStyle { get; }
        bool ParameterInfoAutopopupOn { get; }
        JetBrains.ReSharper.Feature.Services.CodeCompletion.ParenthesesInsertType ParenthesesInsertType { get; set; }
        JetBrains.ReSharper.Feature.Services.Lookup.LookupItemsOwnerFactory Services { get; }
        bool ShowSignatures { get; }
    }
    public interface ILookupItemsPreference
    {
        int Order { get; }
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem> FilterItems(System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem> items);
    }
    public interface ILookupItemsSource
    {
        JetBrains.ReSharper.Feature.Services.Lookup.ILookupItemSelectionStrategy SelectionStrategy { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Feature.Services.Lookup.LookupItems GetLookupItems(JetBrains.ReSharper.Feature.Services.Lookup.LookupItemAcceptanceContext context, System.Comparison<JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem> displayOrder);
    }
    public interface ILookupServiceProvider
    {
        void BindToDeclaredElement<T>([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.ISolution solution, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Pointers.IElementInstancePointer<T> instance, [JetBrains.Annotations.NotNullAttribute()] JetBrains.TextControl.ITextControl textControl, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.TextRange range)
            where T : JetBrains.ReSharper.Psi.IDeclaredElement;
        JetBrains.Util.TextRange BindToDeclaredElements<T>([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.ISolution solution, [JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.Pointers.IElementInstancePointer<T>> instances, [JetBrains.Annotations.NotNullAttribute()] JetBrains.TextControl.ITextControl textControl, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.TextRange range)
            where T : JetBrains.ReSharper.Psi.IDeclaredElement;
        void BindToType([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.ISolution solution, [JetBrains.Annotations.NotNullAttribute()] JetBrains.TextControl.ITextControl textControl, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.TextRange textRange, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.ITypePointer typePointer);
        string BuildQualifierText(JetBrains.ReSharper.Psi.DeclaredElementInstance declaredElementInstance, JetBrains.ReSharper.Psi.Resolve.QualifierKind qualifierKind);
    }
    public interface ILookupWindow : System.Windows.Forms.IWin32Window
    {
        System.Drawing.Rectangle Bounds { get; }
        System.Drawing.Rectangle CurrentItemBounds { get; }
        JetBrains.ReSharper.Feature.Services.Lookup.Lookup Lookup { get; }
        public event System.EventHandler Scrolled;
        public event System.EventHandler ShowAfter;
        public event System.EventHandler ShowBefore;
        public event System.EventHandler WindowClose;
        public event System.EventHandler WindowHidden;
        public event System.EventHandler WindowResized;
        void HandleKeyDown(System.Windows.Forms.KeyEventArgs keyEventArgs);
        void HideCompletionType();
        void HideProgressAnimation();
        void ShowCompletionType(JetBrains.UI.RichText.RichTextBlock[] completionType);
        void ShowProgressAnimation(bool delayed = True);
    }
    public interface ILookupWindowManager
    {
        JetBrains.ReSharper.Feature.Services.Lookup.ILookup CurrentLookup { get; set; }
        bool IsExternalDocumentChangeAllowed { get; }
        bool IsShowing { get; }
        JetBrains.Application.Settings.ISettingsStore SettingsStore { get; }
        public event System.EventHandler AfterLookupWindowShown;
        public event System.EventHandler BeforeLookupWindowShown;
        public event System.EventHandler LookupWindowClosed;
        JetBrains.ReSharper.Feature.Services.Lookup.ILookup CreateLookup(JetBrains.TextControl.ITextControl textControl, JetBrains.Util.TextRange textRange, JetBrains.ReSharper.Feature.Services.Lookup.ILookupItemsSource lookupItems, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Feature.Services.Lookup.LookupWindowOptions windowOptions);
        JetBrains.UI.Components.Theming.ColorTheme GetColorScheme();
        System.IDisposable GetExternalDocumentChangeCookie();
        System.Drawing.Font GetLookupwindowFont(bool useCompletionVsFond);
        void HideLookup();
        void HideProgressAnimation();
        void ShowProgressAnimation();
        void UpdateLookup(JetBrains.ReSharper.Feature.Services.Lookup.ILookup lookup, JetBrains.ReSharper.Feature.Services.Lookup.ILookupItemsSource lookupItems, JetBrains.ReSharper.Feature.Services.Lookup.LookupWindowOptions windowOptions, JetBrains.Util.TextRange textRange, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.UI.RichText.RichTextBlock[] completionType);
    }
    public interface IParameterInfoProvidingLookupItem
    {
        bool HasCandidates { get; }
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.ParameterInfo.ICandidate> CreateCandidates();
    }
    public interface ISuffixFactory
    {
        JetBrains.ReSharper.Feature.Services.Lookup.Suffix CreateSuffixForChar(char c);
        JetBrains.ReSharper.Feature.Services.Lookup.Suffix CreateSuffixForEnter();
        JetBrains.ReSharper.Feature.Services.Lookup.Suffix CreateSuffixForForceInsert();
        JetBrains.ReSharper.Feature.Services.Lookup.Suffix CreateSuffixForTab();
    }
    public delegate void ItemsHandler(object sender, System.Collections.Generic.IList<JetBrains.Util.Pair<JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem, JetBrains.ReSharper.Feature.Services.Lookup.MatchingResult>> items);
    public enum ItemsLocation
    {
        Top = 0,
        Bottom = 1,
        Mixed = 2,
    }
    public interface ITextualDeclaredElementLookupItem : JetBrains.ReSharper.Feature.Services.Lookup.IDeclaredElementLookupItem, JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem, JetBrains.ReSharper.Feature.Services.Lookup.ITextualLookupItem, JetBrains.Util.IUserDataHolder
    {
        bool Bind { get; set; }
    }
    public interface ITextualLookupItem : JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem, JetBrains.Util.IUserDataHolder
    {
        int InsertCaretOffset { get; set; }
        string InsertText { get; set; }
        JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.TextLookupRanges Ranges { get; }
        int ReplaceCaretOffset { get; set; }
        string ReplaceText { get; set; }
        JetBrains.ReSharper.Psi.ExpectedTypes.TailType TailType { get; set; }
        JetBrains.DocumentModel.IRangeMarker VisualReplaceRangeMarker { get; set; }
        public event JetBrains.ReSharper.Feature.Services.Lookup.AfterCompletionHandler AfterComplete;
        public event JetBrains.ReSharper.Feature.Services.Lookup.CompletionConfigurationProcessor PreviewCompletion;
        void InitializeRanges(JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.TextLookupRanges ranges, JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.CodeCompletionContext basicContext);
    }
    public interface IWrappedLookupItem : JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem
    {
        JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem Item { get; }
    }
    public class KeywordLookupItem : JetBrains.ReSharper.Feature.Services.Lookup.TextLookupItem, JetBrains.ReSharper.Feature.Services.Lookup.IKeywordLookupItem
    {
        public KeywordLookupItem(string text) { }
        protected override void InsertTailType(JetBrains.TextControl.ITextControl textControl, JetBrains.ProjectModel.ISolution solution, int offset, JetBrains.ReSharper.Psi.ExpectedTypes.TailType tailType) { }
        protected override void PlaybackSuffix(JetBrains.TextControl.ITextControl textControl, JetBrains.ReSharper.Feature.Services.Lookup.Suffix suffix) { }
    }
    public class LazyLookupItemPainter : JetBrains.ReSharper.Feature.Services.Lookup.CachingLookupItemPainter
    {
        public LazyLookupItemPainter(JetBrains.ReSharper.Feature.Services.Lookup.LookupWindowOptions lookupWindowOptions, JetBrains.ProjectModel.ISolution solution, JetBrains.UI.Icons.IThemedIconManager iconman) { }
        public int MaxItemWidth { get; }
        public event System.EventHandler MaxItemSizeInvalidated;
        public override bool ConstrainToWidth(int width, System.Drawing.Graphics g) { }
        public override void Draw(JetBrains.ReSharper.Feature.Services.Lookup.LookupListItem item, System.Drawing.Graphics g, System.Drawing.Rectangle boundingRect, JetBrains.UI.Components.CustomListBox.DrawMode drawMode, bool hovered) { }
        public override System.Drawing.Size GetSize(JetBrains.ReSharper.Feature.Services.Lookup.LookupListItem item, JetBrains.UI.IGraphicsContainer g) { }
        public override void ResetConstraints() { }
    }
    public class Lookup : JetBrains.ReSharper.Feature.Services.Lookup.LookupBase
    {
        public Lookup([JetBrains.Annotations.NotNullAttribute()] JetBrains.TextControl.ITextControl textControl, JetBrains.Util.TextRange textRange, JetBrains.ReSharper.Feature.Services.Lookup.ILookupItemsSource lookupItemsSource, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Feature.Services.Lookup.LookupWindowOptions options, [JetBrains.Annotations.NotNullAttribute()] System.Func<JetBrains.ReSharper.Feature.Services.Lookup.Lookup, JetBrains.ReSharper.Feature.Services.Lookup.LookupWindow> windowBuilder, JetBrains.ReSharper.Feature.Services.Lookup.ILookupWindowManager lookupWindowManager, JetBrains.ReSharper.Feature.Services.Lookup.LookupSummaryTrackerManager lookupSummaryTrackerManager, JetBrains.Application.CommandProcessing.ICommandProcessor commandProcessor, JetBrains.Application.IShellLocks shellLocks, JetBrains.TextControl.DocumentMarkup.IDocumentMarkupManager documentMarkupManager, JetBrains.Application.Settings.ISettingsStore settingsStore, JetBrains.Threading.IThreading threading) { }
        public override bool IsClosed { get; }
        public override JetBrains.ReSharper.Feature.Services.Lookup.LookupSelection Selection { get; set; }
        public override JetBrains.Util.TextRange TextRange { get; }
        public override JetBrains.ReSharper.Feature.Services.Lookup.ILookupWindow Window { get; }
        public event JetBrains.ReSharper.Feature.Services.Lookup.ItemsHandler BeforeShownItemsUpdated;
        public event System.EventHandler Closed;
        public event System.EventHandler CurrentItemChanged;
        public event System.EventHandler<JetBrains.DataFlow.EventArgs<char>> Typing;
        public override void Close() { }
        public void Complete(JetBrains.ReSharper.Feature.Services.Lookup.LookupItemInsertType lookupItemInsertType) { }
        public override bool Complete(JetBrains.ReSharper.Feature.Services.Lookup.Suffix suffix, JetBrains.ReSharper.Feature.Services.Lookup.LookupItemInsertType lookupItemInsertType) { }
        public override void Dispose() { }
        public override System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<object, object>> EnumerateData() { }
        public override T GetData<T>(JetBrains.Util.Key<T> key)
            where T :  class { }
        public override void HandleKeyDown(System.Windows.Forms.KeyEventArgs args) { }
        public new JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.CompletionAction IsCharacterAcceptable(char c) { }
        public void NotifyCurrentItemChanged() { }
        public override void NotifyTyping(char c) { }
        public override void PutData<T>(JetBrains.Util.Key<T> key, T val)
            where T :  class { }
        public override void ShowLookup() { }
        public void UpdateSelection(JetBrains.ReSharper.Feature.Services.Lookup.ILookupItemsSource lookupItemsSource, JetBrains.Util.TextRange textRange, JetBrains.UI.RichText.RichTextBlock[] completionType) { }
        public override void WaitForCurrentItems() { }
    }
    public class LookupActions
    {
        public LookupActions(JetBrains.ReSharper.Feature.Services.Lookup.LookupBase lookup) { }
        public void AddActionHandlers(JetBrains.DataFlow.Lifetime lifetime) { }
    }
    public class LookupAndParameterInfoLayouters
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public readonly JetBrains.TextControl.ITextControl TextControl;
        protected JetBrains.UI.IPopupLayouter CreateLayouter(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ReSharper.Feature.Services.Lookup.LookupAndParameterInfoLayouters.LayouterIds id, JetBrains.UI.IAnchoringRect anchor, bool bAllowNonStrictRecursion) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.UI.IPopupLayouter CreateLookupLayouter([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.UI.IAnchoringRect anchor) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.UI.IPopupLayouter CreateLookupTooltipLayouter([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.UI.IAnchoringRect anchor) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.UI.IPopupLayouter CreateParameterInfoLayouter([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.UI.IAnchoringRect anchor) { }
        protected void DirtyHackLookupAndParameterInfoDispositions() { }
        protected static System.Collections.Generic.ICollection<JetBrains.UI.Anchoring2D> GetAvailDispositions(JetBrains.ReSharper.Feature.Services.Lookup.LookupAndParameterInfoLayouters.LayouterIds id) { }
        protected void UpdateLayout() { }
        public enum LayouterIds
        {
            Lookup = 0,
            ParameterInfo = 1,
            LookupTooltip = 2,
        }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class LookupAndParameterInfoLayoutersManager
    {
        public LookupAndParameterInfoLayoutersManager([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Threading.IThreading threading) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ReSharper.Feature.Services.Lookup.LookupAndParameterInfoLayoutersManager.LayoutersForTextControls TextControls { get; }
        public class LayoutersForTextControls
        {
            public LayoutersForTextControls([JetBrains.Annotations.NotNullAttribute()] System.Func<JetBrains.TextControl.ITextControl, JetBrains.ReSharper.Feature.Services.Lookup.LookupAndParameterInfoLayouters> FGetForTextControl) { }
            public JetBrains.ReSharper.Feature.Services.Lookup.LookupAndParameterInfoLayouters this[JetBrains.TextControl.ITextControl textcontrol] { get; }
        }
    }
    public abstract class LookupBase : JetBrains.ReSharper.Feature.Services.Lookup.ILookup, JetBrains.Util.IUserDataHolder, System.IDisposable
    {
        protected JetBrains.ReSharper.Feature.Services.Lookup.FilteredLookupItems myCurrentItems;
        protected bool myInterruptCurrentItemsEvaluation;
        protected readonly System.Collections.Generic.Dictionary<string, JetBrains.ReSharper.Feature.Services.Lookup.LookupBase.MatchInfo> myLookupItemsMatchCache;
        protected JetBrains.ReSharper.Feature.Services.Lookup.LookupWindowOptions myOptions;
        protected JetBrains.ReSharper.Feature.Services.Lookup.ContextTracker myPrefixTracker;
        protected readonly JetBrains.ProjectModel.ISolution mySolution;
        protected System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem> mySortedItems;
        protected System.Collections.Generic.JetHashSet<JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem> myStableItems;
        protected readonly JetBrains.TextControl.ITextControl myTextControl;
        protected readonly JetBrains.Threading.IThreading myThreading;
        protected LookupBase([JetBrains.Annotations.NotNullAttribute()] JetBrains.TextControl.ITextControl textControl, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Feature.Services.Lookup.LookupWindowOptions options, JetBrains.Threading.IThreading threading) { }
        public bool InterruptCurrentItemsEvaluation { get; set; }
        public abstract bool IsClosed { get; }
        public System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem> Items { get; }
        public JetBrains.ReSharper.Feature.Services.Lookup.LookupWindowOptions Options { get; set; }
        public string Prefix { get; }
        public abstract JetBrains.ReSharper.Feature.Services.Lookup.LookupSelection Selection { get; set; }
        public JetBrains.ProjectModel.ISolution Solution { get; }
        public JetBrains.TextControl.ITextControl TextControl { get; }
        public abstract JetBrains.Util.TextRange TextRange { get; }
        public abstract JetBrains.ReSharper.Feature.Services.Lookup.ILookupWindow Window { get; }
        public event JetBrains.ReSharper.Feature.Services.Lookup.ItemsHandler BeforeShownItemsUpdated;
        public event System.EventHandler Closed;
        public event System.EventHandler CurrentItemChanged;
        public event JetBrains.ReSharper.Feature.Services.Lookup.CompletionHandler ItemCompleted;
        public event System.EventHandler<JetBrains.DataFlow.EventArgs<char>> Typing;
        public bool ApplyItemOnTyping(char c) { }
        public abstract void Close();
        public abstract bool Complete(JetBrains.ReSharper.Feature.Services.Lookup.Suffix suffix, JetBrains.ReSharper.Feature.Services.Lookup.LookupItemInsertType lookupItemInsertType);
        public JetBrains.ReSharper.Feature.Services.Lookup.LookupItemCompletor CreateCompletor(JetBrains.ReSharper.Feature.Services.Lookup.Suffix suffix, JetBrains.ReSharper.Feature.Services.Lookup.LookupItemInsertType lookupItemInsertType) { }
        public abstract void Dispose();
        public abstract System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<object, object>> EnumerateData();
        protected JetBrains.ReSharper.Feature.Services.Lookup.FilteredLookupItems EvaluateCurrentItems(string prefix, bool preserveOrder = False, System.Collections.Generic.JetHashSet<JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem> stableItems = null) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem> GetContinuation(char c) { }
        public abstract T GetData<T>(JetBrains.Util.Key<T> key)
            where T :  class;
        public virtual void HandleKeyDown(System.Windows.Forms.KeyEventArgs args) { }
        public bool HasContinuationInCurrentItemsList(char c) { }
        public JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.CompletionAction IsCharacterAcceptable(char c) { }
        public JetBrains.ReSharper.Feature.Services.Lookup.MatchingResult Match(JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem item, string prefix, JetBrains.TextControl.ITextControl textControl) { }
        public abstract void NotifyTyping(char c);
        public abstract void PutData<T>(JetBrains.Util.Key<T> key, T val)
            where T :  class;
        public abstract void ShowLookup();
        public abstract void WaitForCurrentItems();
        protected class MatchInfo
        {
            public MatchInfo() { }
            [JetBrains.Annotations.CanBeNullAttribute()]
            public JetBrains.ReSharper.Feature.Services.Lookup.MatchingResult GetResultForPrefix(string prefix) { }
            public void SaveResultForPrefix(string prefix, JetBrains.ReSharper.Feature.Services.Lookup.MatchingResult result) { }
        }
    }
    public enum LookupCompletionStyle
    {
        ApplyItemOnTypingAnyNonCharacter = 0,
        ApplyItemOnTypingSpecificSymbol = 1,
    }
    public enum LookupFocusBehaviour
    {
        Hard = 0,
        Soft = 1,
        SoftWhenEmpty = 2,
        HardAtStart = 3,
    }
    public class LookupHighlightingTracker
    {
        public const string CompletionReplacementID = "ReSharper Completion Replacement Range";
        public LookupHighlightingTracker(JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.TextControl.ITextControl textControl, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem lookupItem, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Feature.Services.Lookup.ContextTracker tracker, JetBrains.Application.IShellLocks shellLocks, JetBrains.TextControl.DocumentMarkup.IDocumentMarkupManager documentMarkupManager) { }
        public void StartHighlighting() { }
    }
    public struct LookupItemAcceptanceContext
    {
        public LookupItemAcceptanceContext(JetBrains.TextControl.ITextControl textControl, JetBrains.Util.TextRange textRange, int absoluteOffset) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public string Prefix { get; }
        public JetBrains.Util.TextRange PrefixRange { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public string Suffix { get; }
        public JetBrains.Util.TextRange SuffixRange { get; }
        public JetBrains.Util.TextRange TextRange { get; }
    }
    public class LookupItemCompletor
    {
        public LookupItemCompletor(JetBrains.TextControl.ITextControl textControl, JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem item, JetBrains.ReSharper.Feature.Services.Lookup.LookupItemInsertType type, JetBrains.Util.TextRange range, JetBrains.ReSharper.Feature.Services.Lookup.Suffix suffix, JetBrains.ProjectModel.ISolution solution) { }
        public JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem Item { get; }
        public JetBrains.Util.TextRange Range { get; }
        public JetBrains.ReSharper.Feature.Services.Lookup.Suffix Suffix { get; }
        public JetBrains.ReSharper.Feature.Services.Lookup.LookupItemInsertType Type { get; }
        public event JetBrains.ReSharper.Feature.Services.Lookup.CompletionHandler BeforeCompleted;
        public event JetBrains.ReSharper.Feature.Services.Lookup.CompletionHandler Completed;
        public void CompleteItem() { }
        public void ScheduleCompletion() { }
    }
    public enum LookupItemInsertType
    {
        Insert = 0,
        Replace = 1,
    }
    public class LookupItemPainter : JetBrains.ReSharper.Feature.Services.Lookup.IListItemPainter<JetBrains.ReSharper.Feature.Services.Lookup.LookupListItem>, JetBrains.UI.Components.CustomListBox.IItemPainter<JetBrains.ReSharper.Feature.Services.Lookup.LookupListItem>, System.IDisposable
    {
        public LookupItemPainter(JetBrains.ReSharper.Feature.Services.Lookup.LookupWindowOptions lookupWindowOptions, JetBrains.ProjectModel.ISolution solution, JetBrains.UI.Icons.IThemedIconManager themedIconManager) { }
        public bool LeftAlign { get; set; }
        public JetBrains.UI.Controls.CustomListBoxControl<JetBrains.ReSharper.Feature.Services.Lookup.LookupListItem> ListBox { get; set; }
        public JetBrains.UI.RenderParams RenderParams { get; }
        public int TextOffset { get; }
        public void Add(JetBrains.ReSharper.Feature.Services.Lookup.LookupListItem item) { }
        public void Clear() { }
        protected bool ConstrainItemToWidth(JetBrains.ReSharper.Feature.Services.Lookup.LookupListItem item, int width, System.Drawing.Graphics g) { }
        public virtual bool ConstrainToWidth(int width, System.Drawing.Graphics g) { }
        public void Dispose() { }
        public virtual void Draw(JetBrains.ReSharper.Feature.Services.Lookup.LookupListItem item, System.Drawing.Graphics g, System.Drawing.Rectangle boundingRect, JetBrains.UI.Components.CustomListBox.DrawMode drawMode, bool hovered) { }
        public System.Windows.Forms.ListViewItem GetItemAt(System.Windows.Forms.ListView ListView, System.Drawing.Point point) { }
        protected virtual System.Drawing.Size GetNameSize(JetBrains.UI.IGraphicsContainer g, JetBrains.ReSharper.Feature.Services.Lookup.LookupListItem lookupListItem) { }
        public virtual System.Drawing.Size GetSize(JetBrains.ReSharper.Feature.Services.Lookup.LookupListItem listViewItem, JetBrains.UI.IGraphicsContainer g) { }
        protected System.Drawing.Size GetSizeCore(JetBrains.ReSharper.Feature.Services.Lookup.LookupListItem listViewItem, JetBrains.UI.IGraphicsContainer g) { }
        public bool IsHandled(JetBrains.ReSharper.Feature.Services.Lookup.LookupListItem item) { }
        public virtual void ResetConstraints() { }
    }
    public class LookupItems
    {
        public LookupItems([JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem> itemsOrderedByPriority, [JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem> itemsOrderedByDisplay) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem> ItemsOrderedByDisplay { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem> ItemsOrderedByPriority { get; }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class LookupItemsOwnerFactory
    {
        public readonly JetBrains.ReSharper.Feature.Services.Descriptions.IDeclaredElementDescriptionPresenter DeclaredElementDescriptionPresenter;
        public readonly JetBrains.ReSharper.Psi.ILanguageManager LanguageManager;
        public readonly JetBrains.ReSharper.Psi.PsiIconManager PsiIconManager;
        public readonly JetBrains.Application.Settings.ISettingsStore SettingsStore;
        public readonly JetBrains.ProjectModel.ISolution Solution;
        public LookupItemsOwnerFactory(JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Psi.PsiIconManager psiIconManager, JetBrains.ReSharper.Feature.Services.Descriptions.IDeclaredElementDescriptionPresenter declaredElementDescriptionPresenter, JetBrains.ReSharper.Psi.ILanguageManager languageManager, JetBrains.Application.Settings.ISettingsStore settingsStore, JetBrains.DocumentManagers.DocumentManager documentManager, JetBrains.ReSharper.Psi.IPsiServices services) { }
        public JetBrains.DocumentManagers.DocumentManager DocumentManager { get; }
        public JetBrains.ReSharper.Psi.IPsiServices PsiServices { get; }
        public JetBrains.ReSharper.Feature.Services.Lookup.ILookupItemsOwner CreateLookupItemsOwner(JetBrains.TextControl.ITextControl textControl) { }
        public JetBrains.ReSharper.Feature.Services.Lookup.ILookupItemsOwner CreateLookupItemsOwner(System.Func<JetBrains.DataFlow.Lifetime, JetBrains.Application.DataContext.DataContexts, JetBrains.Application.DataContext.IDataContext> func) { }
    }
    public class LookupListItem : JetBrains.ReSharper.Feature.Services.Lookup.IListItemDescriptor
    {
        public LookupListItem([JetBrains.Annotations.NotNullAttribute()] JetBrains.UI.RichText.RichText nameText, [JetBrains.Annotations.NotNullAttribute()] JetBrains.UI.RichText.RichText typeText) { }
        public LookupListItem(JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem item, JetBrains.ReSharper.Feature.Services.Lookup.MatchingResult matchingResult, bool highlightNewItems, int multiplier, System.Drawing.Color matchingColor) { }
        public bool CanShrink { get; }
        public bool HighlightNewItems { get; }
        public JetBrains.UI.Icons.IconId Image { get; }
        public JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem LookupItem { get; }
        public JetBrains.ReSharper.Feature.Services.Lookup.MatchingResult MatchingResult { set; }
        public int Multiplier { get; set; }
        public JetBrains.UI.RichText.RichText RichText { get; }
        public object Tag { get; }
        public JetBrains.UI.RichText.RichText TypeText { get; }
        public void CancelShrink() { }
        public bool Highlight() { }
        public bool Shrink() { }
        public override string ToString() { }
    }
    public class LookupPopupWindowContext : JetBrains.UI.PopupWindowManager.PopupWindowContext
    {
        public LookupPopupWindowContext(JetBrains.DataFlow.Lifetime aa, JetBrains.ReSharper.Feature.Services.Lookup.ILookup lookup, JetBrains.ActionManagement.IActionManager actionManager, JetBrains.Application.Interop.NativeHook.IWindowsHookManager windowsHookManager, JetBrains.ReSharper.Feature.Services.Lookup.LookupAndParameterInfoLayoutersManager lookupAndParameterInfoLayoutersManager) { }
        public override JetBrains.UI.IPopupLayouter CreateLayouter(JetBrains.DataFlow.Lifetime lifetime) { }
    }
    public enum LookupReplaceBehaviour
    {
        AlwaysInsert = 0,
        AlwaysReplace = 1,
        EnterInsertsTabReplaces = 2,
    }
    public struct LookupSelection
    {
        public static readonly JetBrains.ReSharper.Feature.Services.Lookup.LookupSelection Empty;
        public LookupSelection(JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem item, JetBrains.ReSharper.Feature.Services.Lookup.LookupSelectionKind kind) { }
        public JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem Item { get; }
        public JetBrains.ReSharper.Feature.Services.Lookup.LookupSelectionKind Kind { get; }
    }
    public enum LookupSelectionKind
    {
        Selected = 0,
        Focused = 1,
    }
    public class LookupShimPopupWindowContext : JetBrains.UI.PopupWindowManager.IPopupWindowContext
    {
        public LookupShimPopupWindowContext() { }
        public JetBrains.UI.PopupWindowManager.IPopupWindowContext PopupWindowContext { get; set; }
        public event System.EventHandler AnyOtherAction;
        public event System.EventHandler Deactivated;
        public event System.EventHandler EscapePressed;
        public event System.EventHandler Scroll;
        public event System.EventHandler SelectionChanged;
        public JetBrains.UI.IPopupLayouter CreateLayouter(JetBrains.DataFlow.Lifetime lifetime) { }
        public void Dispose() { }
        public void FireAnyOtherAction() { }
        public void FireDeactivated() { }
        public void FireScroll() { }
        public void FireSelectionChanged() { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class LookupSummaryTrackerManager
    {
        public LookupSummaryTrackerManager(JetBrains.Application.IShellLocks locks, JetBrains.Application.Interop.NativeHook.IWindowsHookManager windowsHookManager, JetBrains.ReSharper.Feature.Services.Lookup.LookupAndParameterInfoLayoutersManager layoutersManager) { }
        public void TrackWindow(JetBrains.ReSharper.Feature.Services.Lookup.ILookup lookup) { }
    }
    public class static LookupUtil
    {
        public static void AddContainerToDisplayName(JetBrains.ReSharper.Psi.PsiLanguageType languageType, JetBrains.UI.RichText.RichText displayName, JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
        public static void AddEmphasize(JetBrains.UI.RichText.RichText richText, JetBrains.Util.TextRange textRange) { }
        public static void AddInformationText(JetBrains.UI.RichText.RichText displayName, string text) { }
        public static void AddInformationText(JetBrains.UI.RichText.RichText displayName, string text, JetBrains.UI.RichText.TextStyle textStyle) { }
        public static void AssertDocumentRangeIsValid(JetBrains.Util.TextRange range, JetBrains.DocumentModel.IDocument document, object host) { }
        public static JetBrains.Util.TextRange BindRange<T>(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl, JetBrains.Util.TextRange nameRange, System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.Pointers.IElementInstancePointer<T>> pointers, JetBrains.ReSharper.Psi.PsiLanguageType languageType)
            where T : JetBrains.ReSharper.Psi.IDeclaredElement { }
        public static void BindRange<T>(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl, JetBrains.Util.TextRange nameRange, JetBrains.ReSharper.Psi.Pointers.IElementInstancePointer<T> pointer, JetBrains.ReSharper.Psi.PsiLanguageType languageType)
            where T : JetBrains.ReSharper.Psi.IDeclaredElement { }
        public static JetBrains.ReSharper.Feature.Services.Lookup.LookupItemCompletor CreateCompletor(JetBrains.ReSharper.Feature.Services.Lookup.LookupItemAcceptanceContext itemAcceptanceContext, JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem item, JetBrains.ReSharper.Feature.Services.Lookup.LookupItemInsertType lookupItemInsertType, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Feature.Services.Lookup.Suffix suffix, JetBrains.TextControl.ITextControl textControl) { }
        public static JetBrains.Text.IdentifierMatcher CreateMatcher(string prefix, JetBrains.Text.IdentifierMatchingStyle matchingStyle, JetBrains.Text.IdentifierMatchingFlags identifierMatchingFlags = 1) { }
        public static JetBrains.UI.RichText.RichText FormatLookupString(string text) { }
        public static JetBrains.UI.RichText.RichText FormatLookupString(string text, System.Drawing.Color color) { }
        public static string GetContainer(JetBrains.ReSharper.Psi.PsiLanguageType languageType, JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
        public static JetBrains.UI.RichText.RichTextBlock GetDescriptionForDeclaredElementLookupItem(JetBrains.ReSharper.Feature.Services.Lookup.IDeclaredElementLookupItem declaredElementLookupItem) { }
        public static int GetEffectiveCaretOffset(JetBrains.TextControl.ITextControl textControl) { }
        public static System.Collections.Generic.IList<JetBrains.Util.Diff.DiffFragment> GetInsertionData(this JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem lookupItem) { }
        public static void InsertTailType(JetBrains.TextControl.ITextControl textControl, int offset, JetBrains.ReSharper.Psi.ExpectedTypes.TailType tailType, JetBrains.ProjectModel.ISolution solution, bool emulateTypingOfSpace) { }
        public static JetBrains.ReSharper.Feature.Services.Lookup.MatchingResult MatchesPrefixSimple(string text, string prefix) { }
        public static JetBrains.ReSharper.Feature.Services.Lookup.MatchingResult MatchPrefix(JetBrains.Text.IdentifierMatcher identifierMatcher, string text) { }
        public static void MoveParameterInfoOnTop(JetBrains.ProjectModel.ISolution solution) { }
        public static int NameComparison(JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem lookupItemX, JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem lookupItemY) { }
        public static void ShowParameterInfo(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl, JetBrains.ReSharper.Feature.Services.Lookup.ILookupItemsOwner owner) { }
        public static void ShowParameterInfo(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl, JetBrains.Util.TextRange range, JetBrains.ReSharper.Psi.IDeclaredElement signature, JetBrains.ReSharper.Feature.Services.Lookup.ILookupItemsOwner owner) { }
        public static System.Collections.Generic.IList<JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem> SortByName(System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem> items) { }
        public static void StrikeOut(JetBrains.UI.RichText.RichText richText) { }
    }
    public class LookupWindow : JetBrains.UI.CommonControls.Controls.FormOwnedByMainWindow, JetBrains.CommonControls.IConstrainableControl, JetBrains.ReSharper.Feature.Services.Lookup.ILookupWindow, System.Windows.Forms.IWin32Window
    {
        protected JetBrains.UI.Controls.CustomListBoxControl<JetBrains.ReSharper.Feature.Services.Lookup.LookupListItem> myListBox;
        public LookupWindow([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.UI.Application.IMainWindow mainWindow, int maximumItems, bool isCyclingSelection, JetBrains.UI.Icons.IThemedIconManager themedIconManager, JetBrains.Application.IShellLocks shellLocks, JetBrains.UI.Theming.ITheming theming) { }
        public bool AutoActivate { get; set; }
        public System.Drawing.Color BorderColor { get; set; }
        protected override System.Windows.Forms.CreateParams CreateParams { get; }
        public System.Drawing.Rectangle CurrentItemBounds { get; }
        protected JetBrains.ReSharper.Feature.Services.Lookup.IListItemPainter<JetBrains.ReSharper.Feature.Services.Lookup.LookupListItem> ItemPainter { get; set; }
        protected JetBrains.UI.Controls.CustomListBoxControl<JetBrains.ReSharper.Feature.Services.Lookup.LookupListItem> ListBox { get; }
        public JetBrains.ReSharper.Feature.Services.Lookup.Lookup Lookup { get; }
        protected JetBrains.ReSharper.Feature.Services.Lookup.LookupItemPainter LookupItemPainter { get; }
        protected int SelectedIndex { get; set; }
        public JetBrains.ReSharper.Feature.Services.Lookup.LookupSelection Selection { get; set; }
        protected override bool ShowWithoutActivation { get; }
        public JetBrains.DataFlow.ISimpleSignal WantsResize { get; }
        public event JetBrains.ReSharper.Feature.Services.Lookup.ItemsHandler BeforeShownItemsUpdated;
        public event System.EventHandler CurrentItemChanged;
        public event System.EventHandler Scrolled;
        public event System.EventHandler ShowAfter;
        public event System.EventHandler ShowBefore;
        public event System.EventHandler WindowClose;
        public event System.EventHandler WindowHidden;
        public event System.EventHandler WindowResized;
        public void AttachLookup(JetBrains.ReSharper.Feature.Services.Lookup.Lookup lookup) { }
        public System.IDisposable CreateUpdateCookie() { }
        protected override void DestroyHandle() { }
        public void DetachLookup() { }
        protected override void Dispose(bool disposing) { }
        public System.Drawing.Size GetDesiredSize(JetBrains.UI.IGraphicsContainer gc, System.Drawing.Size limit) { }
        public void HandleDoubleClick() { }
        public void HandleKeyDown(System.Windows.Forms.KeyEventArgs e) { }
        public void HandleKeyPress(System.Windows.Forms.KeyPressEventArgs e) { }
        public void HideCompletionType() { }
        public void HideProgressAnimation() { }
        public void InitNormalLayout() { }
        public void InitProgressLayout(int maxItems, bool isEmpty) { }
        protected void MoveSelectionDown() { }
        protected void MoveSelectionPageDown() { }
        protected void MoveSelectionPageUp() { }
        protected void MoveSelectionUp() { }
        protected override void OnClosed(System.EventArgs e) { }
        protected override void OnClosing(System.ComponentModel.CancelEventArgs e) { }
        protected override void OnHandleCreated(System.EventArgs e) { }
        protected void OnListboxScrolled(object sender, System.EventArgs e) { }
        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e) { }
        protected override void OnVisibleChanged(System.EventArgs e) { }
        public void PerformActionOnSelectedItem(bool selectedByMouse) { }
        public void SetLayout(JetBrains.UI.LayoutResult layout) { }
        public void SetList(System.Collections.Generic.ICollection<JetBrains.Util.Pair<JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem, JetBrains.ReSharper.Feature.Services.Lookup.MatchingResult>> items, bool updateSize, JetBrains.TextControl.ITextControl textControl, bool highlightNewItems) { }
        public bool Show(int offset) { }
        public void ShowCompletionType(JetBrains.UI.RichText.RichTextBlock[] completionType) { }
        public void ShowProgressAnimation(bool delayed = True) { }
        protected override void WndProc(ref System.Windows.Forms.Message m) { }
    }
    [JetBrains.Application.ShellComponentAttribute(JetBrains.Application.Components.ProgramConfigurations.NONE | JetBrains.Application.Components.ProgramConfigurations.STANDALONE | JetBrains.Application.Components.ProgramConfigurations.VS_ADDIN | JetBrains.Application.Components.ProgramConfigurations.ALL)]
    public sealed class LookupWindowManagerImpl : JetBrains.ReSharper.Feature.Services.Lookup.ILookupWindowManager
    {
        public LookupWindowManagerImpl(JetBrains.UI.Application.IMainWindow mainWindow, JetBrains.ReSharper.Feature.Services.Lookup.LookupSummaryTrackerManager lookupSummaryTrackerManager, JetBrains.Application.IShellLocks shellLocks, JetBrains.Application.CommandProcessing.ICommandProcessor commandProcessor, JetBrains.TextControl.DocumentMarkup.IDocumentMarkupManager documentMarkupManager, JetBrains.Application.Settings.ISettingsStore settings, JetBrains.UI.CommonControls.Fonts.FontsManager fontsManager, JetBrains.UI.Icons.IThemedIconManager themedIconManager, JetBrains.UI.Theming.ITheming theming, JetBrains.Threading.IThreading threading) { }
        public JetBrains.ReSharper.Feature.Services.Lookup.ILookup CurrentLookup { get; set; }
        public bool IsExternalDocumentChangeAllowed { get; }
        public bool IsShowing { get; }
        public JetBrains.Application.Settings.ISettingsStore SettingsStore { get; }
        public event System.EventHandler AfterLookupWindowShown;
        public event System.EventHandler BeforeLookupWindowShown;
        public event System.EventHandler LookupWindowClosed;
        public JetBrains.ReSharper.Feature.Services.Lookup.ILookup CreateLookup([JetBrains.Annotations.NotNullAttribute()] JetBrains.TextControl.ITextControl textControl, JetBrains.Util.TextRange textRange, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Feature.Services.Lookup.ILookupItemsSource lookupItems, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Feature.Services.Lookup.LookupWindowOptions windowOptions) { }
        public JetBrains.UI.Components.Theming.ColorTheme GetColorScheme() { }
        public System.IDisposable GetExternalDocumentChangeCookie() { }
        public System.Drawing.Font GetLookupwindowFont(bool useCompletionVsFond) { }
        public void HideLookup() { }
        public void HideProgressAnimation() { }
        public void ShowProgressAnimation() { }
        public void UpdateLookup(JetBrains.ReSharper.Feature.Services.Lookup.ILookup lookup, JetBrains.ReSharper.Feature.Services.Lookup.ILookupItemsSource lookupItems, JetBrains.ReSharper.Feature.Services.Lookup.LookupWindowOptions windowOptions, JetBrains.Util.TextRange range, JetBrains.UI.RichText.RichTextBlock[] completionType) { }
    }
    public class LookupWindowOptions
    {
        public LookupWindowOptions(JetBrains.ReSharper.Feature.Services.Lookup.ILookupWindowManager lookupWindowManager, JetBrains.TextControl.ITextControl textControl, JetBrains.ReSharper.Feature.Services.Lookup.LookupItemInsertType customEnterInsertType, JetBrains.ReSharper.Feature.Services.Lookup.LookupItemInsertType customTabInsertType) { }
        public bool CaseSensitive { get; set; }
        public System.Func<char, JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.CompletionAction> CharsThatContinueCompletion { get; set; }
        public JetBrains.ReSharper.Feature.Services.Lookup.LookupCompletionStyle CompletionAcceptanceStyle { get; set; }
        public bool DisallowChangesAfterInitialOffset { get; set; }
        public JetBrains.ReSharper.Feature.Services.Lookup.LookupItemInsertType EnterInsertType { get; }
        public JetBrains.ReSharper.Feature.Services.Lookup.LookupFocusBehaviour FocusBehaviour { get; set; }
        public bool HighlightReplaceRange { get; set; }
        public bool InitialPrefixIsShortest { get; set; }
        public bool IsAutomaticCompletion { get; set; }
        public bool IsDynamic { get; set; }
        public bool IsEmpty { get; set; }
        public bool IsHelper { get; set; }
        public JetBrains.ReSharper.Feature.Services.Lookup.ItemsLocation ItemsLocation { get; set; }
        public bool LeftAlignTypes { get; set; }
        public System.Drawing.Font LookupFont { get; set; }
        public int Multiplier { get; set; }
        public bool NarrowList { get; set; }
        public bool PreserveUndoStack { get; set; }
        public JetBrains.ReSharper.Feature.Services.Lookup.LookupWindowRenderOptions RenderOptions { get; }
        public JetBrains.ReSharper.Feature.Services.Lookup.LookupReplaceBehaviour ReplaceBehaviour { get; set; }
        public bool ShowParameterInfo { get; set; }
        public JetBrains.ReSharper.Feature.Services.Lookup.ISuffixFactory SuffixFactory { get; set; }
        public JetBrains.ReSharper.Feature.Services.Lookup.LookupItemInsertType TabInsertType { get; }
        public JetBrains.ReSharper.Feature.Services.Lookup.LookupWindowOptions Clone() { }
        public JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.CompletionAction IsCharacterAcceptable(char c) { }
    }
    public class LookupWindowRenderOptions
    {
        public System.Drawing.Color Background;
        public System.Drawing.Color Border;
        public System.Drawing.Color HoverItemBackground;
        public System.Drawing.Color HoverItemBorder;
        public System.Drawing.Color HoverItemForeground;
        public System.Drawing.Color ItemBackground;
        public System.Drawing.Color ItemBorder;
        public System.Drawing.Color ItemForeground;
        public System.Drawing.Color NewItemColor;
        public System.Drawing.Color SelectedItemBackground;
        public System.Drawing.Color SelectedItemBorder;
        public System.Drawing.Color SelectedItemForeground;
        public LookupWindowRenderOptions(JetBrains.UI.Components.Theming.ColorTheme theme) { }
    }
    [JetBrains.Application.ShellComponentAttribute(JetBrains.Application.Components.ProgramConfigurations.NONE | JetBrains.Application.Components.ProgramConfigurations.VS_ADDIN | JetBrains.Application.Components.ProgramConfigurations.ALL)]
    public class LookupWindowsSharedCache
    {
        public LookupWindowsSharedCache() { }
        public static JetBrains.ReSharper.Feature.Services.Lookup.LookupWindowsSharedCache Instance { get; }
        public JetBrains.ReSharper.Feature.Services.Lookup.LookupWindowsSharedCache.ICache GetCache([JetBrains.Annotations.NotNullAttribute()] System.Drawing.Font font) { }
        public interface ICache : System.IDisposable
        {
            int Height { get; set; }
            int this[System.Drawing.FontStyle fontStyle, string s] { get; set; }
        }
    }
    public sealed class MatchingResult
    {
        public MatchingResult() { }
        public MatchingResult(System.Collections.Generic.IEnumerable<int> indicies, [JetBrains.Annotations.CanBeNullAttribute()] string mostLikelyContinuation, int score) { }
        public MatchingResult(int prefixLength, string mostLikelyContinuation, int score) { }
        public System.Collections.Generic.IEnumerable<int> HighlightedRanges { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public string MostLikelyContinuation { get; }
        public int Score { get; }
        public JetBrains.ReSharper.Feature.Services.Lookup.MatchingResult Add(int startOffset, int length) { }
        public JetBrains.ReSharper.Feature.Services.Lookup.MatchingResult Shift(int offset) { }
        public JetBrains.ReSharper.Feature.Services.Lookup.MatchingResult Trim(int offset) { }
    }
    public class MethodsLookupItem : JetBrains.ReSharper.Feature.Services.Lookup.DeclaredElementLookupItem
    {
        [JetBrains.Annotations.NotNullAttribute()]
        protected static readonly JetBrains.ReSharper.Psi.DeclaredElementPresenterStyle DefaultNoParametersPresenter;
        protected readonly System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Pointers.IElementInstancePointer<JetBrains.ReSharper.Psi.IDeclaredElement>> myOtherMethods;
        public MethodsLookupItem(JetBrains.ReSharper.Psi.PsiLanguageType languageType, string name, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.DeclaredElementInstance<JetBrains.ReSharper.Psi.IMethod>> methods, JetBrains.ReSharper.Feature.Services.Lookup.IElementPointerFactory elementPointerFactory, JetBrains.ReSharper.Feature.Services.Lookup.ILookupItemsOwner owner) { }
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.DeclaredElementInstance> AllDeclaredElements { get; }
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.ExpectedTypes.InvocationCandidate> Candidates { get; }
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Pointers.IElementInstancePointer<JetBrains.ReSharper.Psi.IDeclaredElement>> DeclaredElementPointers { get; }
        public System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.DeclaredElementInstance<JetBrains.ReSharper.Psi.IMethod>> Methods { get; }
        protected virtual JetBrains.ReSharper.Psi.DeclaredElementPresenterStyle NoParametersPresenter { get; }
        protected override string GetPresentedName(JetBrains.ReSharper.Psi.DeclaredElementInstance instance, out JetBrains.ReSharper.Psi.DeclaredElementPresenterMarking marking) { }
        protected override void OnAfterComplete(JetBrains.TextControl.ITextControl textControl, ref JetBrains.Util.TextRange nameRange, ref JetBrains.Util.TextRange decorationRange, JetBrains.ReSharper.Psi.ExpectedTypes.TailType tailType, ref JetBrains.ReSharper.Feature.Services.Lookup.Suffix suffix, ref JetBrains.DocumentModel.IRangeMarker caretPositionRangeMarker) { }
    }
    public class MyExplicitLocationFilter : JetBrains.ReSharper.Feature.Services.Lookup.ILookupItemsPreference
    {
        public MyExplicitLocationFilter(System.Collections.Generic.HashSet<JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem> bottomItems, System.Collections.Generic.HashSet<JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem> topItems) { }
        public int Order { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem> FilterItems(System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem> items) { }
    }
    public class PassThroughSuffixFactory : JetBrains.ReSharper.Feature.Services.Lookup.DefaultSuffixFactory
    {
        public static readonly JetBrains.ReSharper.Feature.Services.Lookup.ISuffixFactory Instance;
        public override JetBrains.ReSharper.Feature.Services.Lookup.Suffix CreateSuffixForEnter() { }
    }
    public class PreProcessorLookupItem : JetBrains.ReSharper.Feature.Services.Lookup.TextLookupItem, JetBrains.ReSharper.Feature.Services.Lookup.IKeywordLookupItem
    {
        public PreProcessorLookupItem(string text, string typeText, bool emphasize) { }
    }
    public class SelectionStrategy : JetBrains.ReSharper.Feature.Services.Lookup.ILookupItemSelectionStrategy
    {
        public SelectionStrategy(System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem> fullList) { }
        public JetBrains.ReSharper.Feature.Services.Lookup.LookupSelection GetSelection(JetBrains.ReSharper.Feature.Services.Lookup.FilteredLookupItems items, JetBrains.ReSharper.Feature.Services.Lookup.LookupSelection currentSelection, JetBrains.ReSharper.Feature.Services.Lookup.LookupSelectionKind lookupSelectionKind) { }
    }
    public class SelectionStrategyWithPreferences : JetBrains.ReSharper.Feature.Services.Lookup.ILookupItemSelectionStrategy
    {
        public SelectionStrategyWithPreferences(System.Collections.Generic.List<JetBrains.ReSharper.Feature.Services.Lookup.ILookupItemsPreference> filters) { }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem> GetAllPreferredItems(JetBrains.ReSharper.Feature.Services.Lookup.FilteredLookupItems items) { }
        public JetBrains.ReSharper.Feature.Services.Lookup.LookupSelection GetSelection(JetBrains.ReSharper.Feature.Services.Lookup.FilteredLookupItems items, JetBrains.ReSharper.Feature.Services.Lookup.LookupSelection currentSelection, JetBrains.ReSharper.Feature.Services.Lookup.LookupSelectionKind lookupSelectionKind) { }
    }
    public class StaticLookupItemsSource : JetBrains.ReSharper.Feature.Services.Lookup.ILookupItemsSource
    {
        public StaticLookupItemsSource([JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem> lookupItems, JetBrains.ReSharper.Feature.Services.Lookup.ILookupItemSelectionStrategy selectionStrategy, bool sorted) { }
        public JetBrains.ReSharper.Feature.Services.Lookup.ILookupItemSelectionStrategy SelectionStrategy { get; }
        public JetBrains.ReSharper.Feature.Services.Lookup.LookupItems GetLookupItems(JetBrains.ReSharper.Feature.Services.Lookup.LookupItemAcceptanceContext context, System.Comparison<JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem> displayOrder) { }
    }
    public abstract class Suffix
    {
        public static readonly JetBrains.ReSharper.Feature.Services.Lookup.Suffix Empty;
        public abstract bool HasPresentation { get; }
        public virtual bool IsEmpty { get; }
        public abstract char Presentation { get; }
        public abstract void Playback(JetBrains.TextControl.ITextControl textControl);
    }
    public class TextLookupItem : JetBrains.ReSharper.Feature.Services.Lookup.TextLookupItemBase
    {
        public TextLookupItem(string text, bool isDynamic = False) { }
        public TextLookupItem(string text, string typeText, bool isDynamic = False) { }
        public TextLookupItem(string text, JetBrains.UI.Icons.IconId image, bool isDynamic = False) { }
        public TextLookupItem(string text, string typeText, bool emphasize, bool isDynamic = False) { }
        public override JetBrains.UI.Icons.IconId Image { get; }
        protected override JetBrains.UI.RichText.RichText GetDisplayName() { }
        public override void Unshrink() { }
    }
    public abstract class TextLookupItemBase : JetBrains.Util.UserDataHolder, JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem, JetBrains.ReSharper.Feature.Services.Lookup.ITextualLookupItem, JetBrains.Util.IUserDataHolder
    {
        protected TextLookupItemBase() { }
        protected TextLookupItemBase(bool isDynamic) { }
        public virtual bool CanShrink { get; }
        protected virtual JetBrains.ReSharper.Psi.CodeStyle.Casing Casing { get; }
        public virtual bool DisableFormatter { get; set; }
        public JetBrains.UI.RichText.RichText DisplayName { get; }
        public JetBrains.UI.RichText.RichText DisplayTypeName { get; set; }
        public virtual string Identity { get; }
        public bool IgnoreSoftOnSpace { get; set; }
        public abstract JetBrains.UI.Icons.IconId Image { get; }
        public int InsertCaretOffset { get; set; }
        public string InsertText { get; set; }
        public bool IsDynamic { get; }
        public int Multiplier { get; set; }
        public string OrderingString { get; set; }
        public JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.TextLookupRanges Ranges { get; }
        public virtual bool RemovesTypeQualifier { get; }
        public int ReplaceCaretOffset { get; set; }
        public string ReplaceText { get; set; }
        public bool SaneDecoration { get; set; }
        public bool ShowContainer { get; set; }
        public JetBrains.ReSharper.Psi.ExpectedTypes.TailType TailType { get; set; }
        public virtual string Text { get; set; }
        public System.Drawing.Color TextColor { get; set; }
        public JetBrains.DocumentModel.IRangeMarker VisualReplaceRangeMarker { get; set; }
        public event JetBrains.ReSharper.Feature.Services.Lookup.AfterCompletionHandler AfterComplete;
        public event System.EventHandler BeforeComplete;
        public event JetBrains.ReSharper.Feature.Services.Lookup.CompletionConfigurationProcessor PreviewCompletion;
        public virtual void Accept(JetBrains.TextControl.ITextControl textControl, JetBrains.Util.TextRange nameRange, JetBrains.ReSharper.Feature.Services.Lookup.LookupItemInsertType lookupItemInsertType, JetBrains.ReSharper.Feature.Services.Lookup.Suffix suffix, JetBrains.ProjectModel.ISolution solution, bool keepCaretStill) { }
        public virtual bool AcceptIfOnlyMatched(JetBrains.ReSharper.Feature.Services.Lookup.LookupItemAcceptanceContext itemAcceptanceContext) { }
        protected virtual JetBrains.Util.TextRange DoReplaceText(JetBrains.TextControl.ITextControl textcontrol, JetBrains.Util.TextRange replaceRange, string typeInName) { }
        public void ForceBeforeComplete() { }
        protected virtual JetBrains.UI.RichText.RichText GetDisplayName() { }
        public static System.Func<string, JetBrains.ReSharper.Feature.Services.Lookup.MatchingResult> GetPrefixMatcher(string prefix, JetBrains.Text.IdentifierMatchingStyle matchingStyle) { }
        public static System.Func<string, JetBrains.ReSharper.Feature.Services.Lookup.MatchingResult> GetPrefixMatcherEx(string prefix, JetBrains.TextControl.ITextControl textControl) { }
        public JetBrains.Util.TextRange GetVisualReplaceRange(JetBrains.TextControl.ITextControl textControl, JetBrains.Util.TextRange nameRange) { }
        public void InitializeRanges(JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.TextLookupRanges ranges, JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.CodeCompletionContext basicContext) { }
        protected virtual void InsertTailType(JetBrains.TextControl.ITextControl textControl, JetBrains.ProjectModel.ISolution solution, int offset, JetBrains.ReSharper.Psi.ExpectedTypes.TailType tailType) { }
        protected void Invalidate() { }
        protected void InvokeOnAfterComplete(JetBrains.TextControl.ITextControl textControl, ref JetBrains.Util.TextRange nameRange, ref JetBrains.Util.TextRange decorationRange, JetBrains.ReSharper.Psi.ExpectedTypes.TailType tailType, ref JetBrains.ReSharper.Feature.Services.Lookup.Suffix suffix, ref JetBrains.DocumentModel.IRangeMarker caretPositionRangeMarker) { }
        public virtual JetBrains.ReSharper.Feature.Services.Lookup.MatchingResult Match(string prefix, JetBrains.TextControl.ITextControl textControl) { }
        protected virtual void OnAfterComplete(JetBrains.TextControl.ITextControl textControl, ref JetBrains.Util.TextRange nameRange, ref JetBrains.Util.TextRange decorationRange, JetBrains.ReSharper.Psi.ExpectedTypes.TailType tailType, ref JetBrains.ReSharper.Feature.Services.Lookup.Suffix suffix, ref JetBrains.DocumentModel.IRangeMarker caretPositionRangeMarker) { }
        protected virtual void PlaybackSuffix(JetBrains.TextControl.ITextControl textControl, JetBrains.ReSharper.Feature.Services.Lookup.Suffix suffix) { }
        public virtual bool Shrink() { }
        public override string ToString() { }
        public virtual void Unshrink() { }
    }
    public class TypeLookupItem : JetBrains.ReSharper.Feature.Services.Lookup.TextLookupItemBase, JetBrains.ReSharper.Feature.Services.Lookup.IDeclaredElementLookupItem, JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem, JetBrains.ReSharper.Feature.Services.Lookup.ITextualDeclaredElementLookupItem, JetBrains.ReSharper.Feature.Services.Lookup.ITextualLookupItem, JetBrains.Util.IUserDataHolder
    {
        protected readonly JetBrains.ReSharper.Psi.ITypePointer myTypePointer;
        public TypeLookupItem(JetBrains.ReSharper.Psi.ITypePointer typePointer, JetBrains.ReSharper.Psi.PsiLanguageType languageType, JetBrains.ReSharper.Feature.Services.Lookup.ILookupItemsOwner owner) { }
        public TypeLookupItem(JetBrains.ReSharper.Psi.IType type, JetBrains.ReSharper.Psi.PsiLanguageType languageType, JetBrains.ReSharper.Feature.Services.Lookup.ILookupItemsOwner owner) { }
        public virtual System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.DeclaredElementInstance> AllDeclaredElements { get; }
        public bool Bind { get; set; }
        protected JetBrains.ReSharper.Psi.IDeclaredElement[] Candidates { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        protected JetBrains.ReSharper.Psi.IDeclaredElement DeclaredElement { get; }
        public virtual System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Pointers.IElementInstancePointer<JetBrains.ReSharper.Psi.IDeclaredElement>> DeclaredElementPointers { get; }
        public override JetBrains.UI.Icons.IconId Image { get; }
        public JetBrains.ReSharper.Psi.PsiLanguageType LanguageType { get; }
        public JetBrains.ReSharper.Feature.Services.Lookup.ILookupItemsOwner Owner { get; }
        public JetBrains.ReSharper.Psi.DeclaredElementInstance PreferredDeclaredElement { get; }
        protected override JetBrains.UI.RichText.RichText GetDisplayName() { }
        protected virtual JetBrains.ReSharper.Psi.ITypePointer GetTypePointerForBinding() { }
        protected override void OnAfterComplete(JetBrains.TextControl.ITextControl textControl, ref JetBrains.Util.TextRange nameRange, ref JetBrains.Util.TextRange decorationRange, JetBrains.ReSharper.Psi.ExpectedTypes.TailType tailType, ref JetBrains.ReSharper.Feature.Services.Lookup.Suffix suffix, ref JetBrains.DocumentModel.IRangeMarker caretPositionRangeMarker) { }
    }
    public class TypeNameCodeCompletionLookupItem : JetBrains.ReSharper.Feature.Services.Lookup.DeclaredElementLookupItem
    {
        protected TypeNameCodeCompletionLookupItem(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, JetBrains.ReSharper.Feature.Services.Lookup.IElementPointerFactory elementPointerFactory, JetBrains.ReSharper.Psi.PsiLanguageType languageType, JetBrains.ReSharper.Feature.Services.Lookup.ILookupItemsOwner owner) { }
        protected override JetBrains.UI.RichText.RichText GetDisplayName() { }
    }
    public class VariableComparer : System.Collections.Generic.IComparer<JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem>
    {
        public int Compare(JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem x, JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem y) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.Lookup.Impl
{
    
    public class CreateNewEventHandlerLookupItem<TMethodReference> : JetBrains.ReSharper.Feature.Services.Lookup.Impl.CreateNewMethodLookupItem<TMethodReference>
        where TMethodReference :  class, JetBrains.ReSharper.Psi.Resolve.IReference
    {
        protected CreateNewEventHandlerLookupItem(TMethodReference reference, JetBrains.ReSharper.Psi.IDeclaredType eventType, JetBrains.ReSharper.Psi.IDelegate @delegate, JetBrains.ReSharper.Psi.Tree.ITypeDeclaration targetTypeDeclaration, System.Func<TMethodReference, string> suggestNameFunc) { }
    }
    public class CreateNewMethodLookupItem<TMethodReference> : JetBrains.ReSharper.Feature.Services.Lookup.TextLookupItemBase
        where TMethodReference :  class, JetBrains.ReSharper.Psi.Resolve.IReference
    {
        public CreateNewMethodLookupItem(TMethodReference methodReference, JetBrains.ReSharper.Psi.Tree.ITypeDeclaration targetTypeDeclaration, System.Func<TMethodReference, string> suggestNameFunc, JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.MemberSignature memberSignature, JetBrains.ReSharper.Psi.AccessRights accessRights) { }
        public override JetBrains.UI.Icons.IconId Image { get; }
        public override void Accept(JetBrains.TextControl.ITextControl textControl, JetBrains.Util.TextRange nameRange, JetBrains.ReSharper.Feature.Services.Lookup.LookupItemInsertType lookupItemInsertType, JetBrains.ReSharper.Feature.Services.Lookup.Suffix suffix, JetBrains.ProjectModel.ISolution solution, bool keepCaretStill) { }
        protected override JetBrains.UI.RichText.RichText GetDisplayName() { }
        public override JetBrains.ReSharper.Feature.Services.Lookup.MatchingResult Match(string prefix, JetBrains.TextControl.ITextControl textControl) { }
    }
    public class DeclaredElementLookupItem<T, TPsiFileType> : JetBrains.ReSharper.Feature.Services.Lookup.DeclaredElementLookupItem
        where T :  class, JetBrains.ReSharper.Psi.Resolve.IReference
        where TPsiFileType :  class, JetBrains.ReSharper.Psi.Tree.IFile
    {
        protected readonly JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ISpecificCodeCompletionContext Context;
        public DeclaredElementLookupItem(JetBrains.ReSharper.Psi.DeclaredElementInstance<JetBrains.ReSharper.Psi.IDeclaredElement> declaredElementInstanceInstance, string name, string displayName, JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ISpecificCodeCompletionContext context, JetBrains.ReSharper.Psi.PsiLanguageType languageType, JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.TextLookupRanges ranges, JetBrains.ReSharper.Psi.PsiLanguageType presentationLanguageType = null) { }
        protected int CustomCaretOffset { get; set; }
        protected JetBrains.ReSharper.Feature.Services.Lookup.Suffix Suffix { get; }
        public override void Accept(JetBrains.TextControl.ITextControl textControl, JetBrains.Util.TextRange nameRange, JetBrains.ReSharper.Feature.Services.Lookup.LookupItemInsertType lookupItemInsertType, JetBrains.ReSharper.Feature.Services.Lookup.Suffix suffix, JetBrains.ProjectModel.ISolution solution, bool keepCaretStill) { }
        protected virtual JetBrains.ReSharper.Psi.Resolve.IReference BindReferenceAfterComplete(JetBrains.TextControl.ITextControl textControl, JetBrains.Util.TextRange nameRange) { }
        protected virtual void DecorateDisplayName([JetBrains.Annotations.NotNullAttribute()] JetBrains.UI.RichText.RichText displayName, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.DeclaredElementInstance preferredDeclaredElement) { }
        protected virtual JetBrains.UI.RichText.RichText GetDisplayName() { }
        protected override string GetPresentedName([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.DeclaredElementInstance instance, out JetBrains.ReSharper.Psi.DeclaredElementPresenterMarking marking) { }
        protected override string GetText() { }
        protected virtual bool IsReferenceValid(JetBrains.Util.TextRange nameRange, [JetBrains.Annotations.NotNullAttribute()] T reference) { }
        protected override void OnAfterComplete(JetBrains.TextControl.ITextControl textControl, ref JetBrains.Util.TextRange nameRange, ref JetBrains.Util.TextRange decorationRange, JetBrains.ReSharper.Psi.ExpectedTypes.TailType tailType, ref JetBrains.ReSharper.Feature.Services.Lookup.Suffix suffix, ref JetBrains.DocumentModel.IRangeMarker caretPositionRangeMarker) { }
    }
    public class UnitTestCategoryLookupItem : JetBrains.ReSharper.Feature.Services.Lookup.TextLookupItem
    {
        public UnitTestCategoryLookupItem(string text, JetBrains.UI.Icons.IconId image, JetBrains.DocumentModel.IRangeMarker completionMarker) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.Lookup.Settings
{
    
    [JetBrains.Application.Settings.SettingsKeyAttribute(typeof(JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.IntellisenseSettingsKey), "Lookup window settings")]
    public class LookupWindowSettingsKey
    {
        [JetBrains.Application.Settings.SettingsEntryAttribute(true, "Highlight newly added items")]
        public bool HighlightAddedItems;
        [JetBrains.Application.Settings.SettingsEntryAttribute(11, "Lookup window height")]
        public int LookupHeight;
        [JetBrains.Application.Settings.SettingsEntryAttribute(true, "Narrow down lookup list on typing")]
        public bool NarrowList;
        [JetBrains.Application.Settings.SettingsEntryAttribute(true, "Show completion type")]
        public bool ShowCompletionType;
        [JetBrains.Application.Settings.SettingsEntryAttribute(false, "Show function signatures")]
        public bool ShowSignatures;
        [JetBrains.Application.Settings.SettingsEntryAttribute(false, "Show function summary")]
        public bool ShowSummary;
        [JetBrains.Application.Settings.SettingsEntryAttribute(true, "Use completion font for lookups")]
        public bool UseCompletionFontForLookups;
    }
}
namespace JetBrains.ReSharper.Feature.Services.Lookup.SettingsUpgrade
{
    
    [System.ObsoleteAttribute("Deprecated, use LookupWindowSettingsKey")]
    public sealed class LookupOptions : JetBrains.Application.Configuration.IXmlReadable
    {
        [JetBrains.Application.Configuration.XmlExternalizableAttribute(11)]
        public readonly JetBrains.DataFlow.Property<int> LookupHeight;
        [JetBrains.Application.Configuration.XmlExternalizableAttribute(true)]
        public readonly JetBrains.DataFlow.Property<bool> NarrowList;
        [JetBrains.Application.Configuration.XmlExternalizableAttribute(false)]
        public readonly JetBrains.DataFlow.Property<bool> ShowSignatures;
        [JetBrains.Application.Configuration.XmlExternalizableAttribute(false)]
        public readonly JetBrains.DataFlow.Property<bool> ShowSummary;
        public LookupOptions(JetBrains.Application.Configuration.IComponentSettingsProvider shellSettingsComponent, JetBrains.DataFlow.Lifetime lifetime) { }
    }
    [JetBrains.Application.Configuration.Upgrade.GlobalSettingsUpgraderAttribute()]
    public class LookupWindowSettingsUpgrade : JetBrains.Application.Configuration.Upgrade.IGlobalSettingsUpgrader, JetBrains.Application.Configuration.Upgrade.ISettingsUpgrader
    {
        public void Upgrade(JetBrains.Application.Configuration.IComponentSettingsProvider legacySettingsProvider, JetBrains.Application.Settings.IContextBoundSettingsStore boundSettingsStore, JetBrains.DataFlow.Lifetime upgradeLifetime) { }
    }
    [System.ObsoleteAttribute("Deprecated, use LookupWindowSettingsKey")]
    public class OldFontsManagerSettings : JetBrains.Application.Configuration.IXmlReadable
    {
        [JetBrains.Application.Configuration.XmlExternalizableAttribute(true)]
        public readonly JetBrains.DataFlow.Property<bool> UseCompletionFontForLookups;
        public OldFontsManagerSettings(JetBrains.Application.Configuration.IComponentSettingsProvider shellSettingsComponent, JetBrains.DataFlow.Lifetime lifetime) { }
        public void ReadFromXml(System.Xml.XmlElement element) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.Lookup.Theming
{
    
    public class LookupThemeColor : JetBrains.UI.Components.Theming.ThemeColor
    {
        public static readonly JetBrains.ReSharper.Feature.Services.Lookup.Theming.LookupThemeColor LookupHoverItemBackground;
        public static readonly JetBrains.ReSharper.Feature.Services.Lookup.Theming.LookupThemeColor LookupHoverItemBorder;
        public static readonly JetBrains.ReSharper.Feature.Services.Lookup.Theming.LookupThemeColor LookupHoverItemForeground;
        public static readonly JetBrains.ReSharper.Feature.Services.Lookup.Theming.LookupThemeColor LookupItemBackground;
        public static readonly JetBrains.ReSharper.Feature.Services.Lookup.Theming.LookupThemeColor LookupItemBorder;
        public static readonly JetBrains.ReSharper.Feature.Services.Lookup.Theming.LookupThemeColor LookupItemForeground;
        public static readonly JetBrains.ReSharper.Feature.Services.Lookup.Theming.LookupThemeColor LookupMatchedTextForeground;
        public static readonly JetBrains.ReSharper.Feature.Services.Lookup.Theming.LookupThemeColor LookupSelectedItemBackground;
        public static readonly JetBrains.ReSharper.Feature.Services.Lookup.Theming.LookupThemeColor LookupSelectedItemBorder;
        public static readonly JetBrains.ReSharper.Feature.Services.Lookup.Theming.LookupThemeColor LookupSelectedItemForeground;
        public static readonly JetBrains.ReSharper.Feature.Services.Lookup.Theming.LookupThemeColor LookupWindowBackground;
        public static readonly JetBrains.ReSharper.Feature.Services.Lookup.Theming.LookupThemeColor LookupWindowBorder;
        public static readonly JetBrains.ReSharper.Feature.Services.Lookup.Theming.LookupThemeColor NewItemColor;
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class LookupThemeColorFiller : JetBrains.UI.Components.Theming.IThemeColorFiller
    {
        public virtual void FillColorTheme(JetBrains.UI.Components.Theming.ColorTheme t) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.MatchingBrace
{
    
    public interface ISimpleMatchingBraceProvider
    {
        int Compare(JetBrains.ReSharper.Psi.Parsing.TokenNodeType x, JetBrains.ReSharper.Psi.Parsing.TokenNodeType y);
        bool IsLeftBracket(JetBrains.ReSharper.Psi.Parsing.TokenNodeType tokenType);
        bool IsRightBracket(JetBrains.ReSharper.Psi.Parsing.TokenNodeType tokenType);
        bool Match(JetBrains.ReSharper.Psi.Parsing.TokenNodeType token1, JetBrains.ReSharper.Psi.Parsing.TokenNodeType token2);
    }
    public class MatchingBraceHighlightingInfo
    {
        public readonly bool IsMatched;
        public readonly int Position1;
        public readonly int Position2;
        public MatchingBraceHighlightingInfo(int position1, int position2, bool isMatched) { }
        public System.Func<JetBrains.UI.RichText.RichTextBlock> InvisibleBraceHintProvider { get; set; }
    }
    public class static MatchingBraceUtil
    {
        public static bool IsPositionVisible(JetBrains.TextControl.ITextControl textControl, int position) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.UI.RichText.RichTextBlock PrepareRichText(JetBrains.TextControl.ITextControl textControl, JetBrains.ReSharper.Psi.Tree.ITreeNode construct, JetBrains.ReSharper.Psi.Tree.ITreeNode stopperNode, bool addStopperStyle) { }
    }
    public class static XmlLikeMatchingBraceUtil
    {
        public static string GetHeaderName(JetBrains.ReSharper.Psi.Parsing.CachingLexer lexer, JetBrains.ReSharper.Feature.Services.MatchingBrace.XmlLikeTokenProcessor processor) { }
        public static JetBrains.ReSharper.Feature.Services.MatchingBrace.MatchingBraceHighlightingInfo TryHighlightToLeft(JetBrains.ReSharper.Psi.Parsing.CachingLexer lexer, int caretPos, JetBrains.ReSharper.Feature.Services.MatchingBrace.XmlLikeToLeftTokenProcessor processor, JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl, System.Func<JetBrains.ProjectModel.ISolution, JetBrains.TextControl.ITextControl, int, System.Func<JetBrains.UI.RichText.RichTextBlock>> createInvisibleHint) { }
        public static JetBrains.ReSharper.Feature.Services.MatchingBrace.MatchingBraceHighlightingInfo TryHighlightToRight(JetBrains.ReSharper.Psi.Parsing.CachingLexer lexer, int caretPos, JetBrains.ReSharper.Feature.Services.MatchingBrace.XmlLikeToRightTokenProcessor processor) { }
    }
    public abstract class XmlLikeTokenProcessor
    {
        protected readonly System.Collections.Generic.Stack<JetBrains.Util.Pair<JetBrains.ReSharper.Feature.Services.MatchingBrace.XmlLikeTokenProcessor.State, string>> myStates;
        protected readonly System.Collections.Generic.Stack<JetBrains.ReSharper.Psi.Parsing.TokenNodeType> myTokens;
        protected XmlLikeTokenProcessor(int deltha) { }
        protected JetBrains.ReSharper.Feature.Services.MatchingBrace.XmlLikeTokenProcessor.State CurrentState { get; }
        protected JetBrains.Util.Pair<JetBrains.ReSharper.Feature.Services.MatchingBrace.XmlLikeTokenProcessor.State, string> CurrentStatePair { get; }
        protected string CurrentTagName { get; }
        protected JetBrains.ReSharper.Psi.Parsing.TokenNodeType CurrentToken { get; }
        public bool IsMatched { get; }
        public bool CanStartHighlighting(JetBrains.ReSharper.Psi.Parsing.TokenNodeType token) { }
        public static JetBrains.ReSharper.Psi.Parsing.TokenNodeType GetNextToken(JetBrains.ReSharper.Psi.Parsing.CachingLexer lexer) { }
        public static JetBrains.ReSharper.Psi.Parsing.TokenNodeType GetPrevToken(JetBrains.ReSharper.Psi.Parsing.CachingLexer lexer) { }
        protected abstract JetBrains.ReSharper.Feature.Services.MatchingBrace.XmlLikeTokenProcessor.TrailingTagAction GetTrailingAction(JetBrains.ReSharper.Psi.Parsing.TokenNodeType originalToken, JetBrains.ReSharper.Psi.Parsing.TokenNodeType token);
        public abstract bool IsCommentEnd(JetBrains.ReSharper.Psi.Parsing.TokenNodeType tokenType);
        public abstract bool IsCommentStart(JetBrains.ReSharper.Psi.Parsing.TokenNodeType tokenType);
        public abstract bool IsIdentifier(JetBrains.ReSharper.Psi.Parsing.TokenNodeType tokenType);
        public abstract bool IsPiEnd(JetBrains.ReSharper.Psi.Parsing.TokenNodeType tokenType);
        public abstract bool IsPiStart(JetBrains.ReSharper.Psi.Parsing.TokenNodeType tokenType);
        protected virtual bool IsSkipToken(JetBrains.ReSharper.Psi.Parsing.TokenNodeType token) { }
        public abstract bool IsTagEnd(JetBrains.ReSharper.Psi.Parsing.TokenNodeType tokenType);
        public abstract bool IsTagEnd1(JetBrains.ReSharper.Psi.Parsing.TokenNodeType tokenType);
        public abstract bool IsTagStart(JetBrains.ReSharper.Psi.Parsing.TokenNodeType tokenType);
        public abstract bool IsTagStart1(JetBrains.ReSharper.Psi.Parsing.TokenNodeType tokenType);
        public bool Match(JetBrains.ReSharper.Psi.Parsing.CachingLexer lexer, out int pos) { }
        protected abstract bool TokenAllowed(JetBrains.ReSharper.Psi.Parsing.TokenNodeType token, JetBrains.ReSharper.Psi.Parsing.TokenNodeType currentToken, JetBrains.ReSharper.Feature.Services.MatchingBrace.XmlLikeTokenProcessor.State state, string tagName);
        protected abstract void UpdateStacks(JetBrains.ReSharper.Psi.Parsing.TokenNodeType token, JetBrains.ReSharper.Psi.Parsing.TokenNodeType currentToken, JetBrains.ReSharper.Feature.Services.MatchingBrace.XmlLikeTokenProcessor.State state, string tagName, JetBrains.ReSharper.Psi.Parsing.CachingLexer lexer);
        protected enum State
        {
            NOT_STARTED = 0,
            STARTED = 1,
            TAG = 2,
            HEADER = 3,
            FOOTER = 4,
            HEADER_OR_FOOTER = 5,
        }
        protected enum TrailingTagAction
        {
            SKIP = 0,
            STOP_OK = 1,
            STOP_ERROR = 2,
        }
    }
    public abstract class XmlLikeToLeftTokenProcessor : JetBrains.ReSharper.Feature.Services.MatchingBrace.XmlLikeTokenProcessor
    {
        protected XmlLikeToLeftTokenProcessor() { }
        protected override JetBrains.ReSharper.Feature.Services.MatchingBrace.XmlLikeTokenProcessor.TrailingTagAction GetTrailingAction(JetBrains.ReSharper.Psi.Parsing.TokenNodeType originalToken, JetBrains.ReSharper.Psi.Parsing.TokenNodeType token) { }
        protected override bool TokenAllowed(JetBrains.ReSharper.Psi.Parsing.TokenNodeType token, JetBrains.ReSharper.Psi.Parsing.TokenNodeType currentToken, JetBrains.ReSharper.Feature.Services.MatchingBrace.XmlLikeTokenProcessor.State state, string tagName) { }
        protected override void UpdateStacks(JetBrains.ReSharper.Psi.Parsing.TokenNodeType token, JetBrains.ReSharper.Psi.Parsing.TokenNodeType currentToken, JetBrains.ReSharper.Feature.Services.MatchingBrace.XmlLikeTokenProcessor.State state, string tagName, JetBrains.ReSharper.Psi.Parsing.CachingLexer lexer) { }
    }
    public abstract class XmlLikeToRightTokenProcessor : JetBrains.ReSharper.Feature.Services.MatchingBrace.XmlLikeTokenProcessor
    {
        protected XmlLikeToRightTokenProcessor() { }
        protected override JetBrains.ReSharper.Feature.Services.MatchingBrace.XmlLikeTokenProcessor.TrailingTagAction GetTrailingAction(JetBrains.ReSharper.Psi.Parsing.TokenNodeType originalToken, JetBrains.ReSharper.Psi.Parsing.TokenNodeType token) { }
        protected override bool TokenAllowed(JetBrains.ReSharper.Psi.Parsing.TokenNodeType token, JetBrains.ReSharper.Psi.Parsing.TokenNodeType currentToken, JetBrains.ReSharper.Feature.Services.MatchingBrace.XmlLikeTokenProcessor.State state, string tagName) { }
        protected override void UpdateStacks(JetBrains.ReSharper.Psi.Parsing.TokenNodeType token, JetBrains.ReSharper.Psi.Parsing.TokenNodeType currentToken, JetBrains.ReSharper.Feature.Services.MatchingBrace.XmlLikeTokenProcessor.State state, string tagName, JetBrains.ReSharper.Psi.Parsing.CachingLexer lexer) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.Options
{
    
    [JetBrains.Application.ShellComponentAttribute()]
    public class HostAutoFormatSettings
    {
        public static JetBrains.ReSharper.Feature.Services.Options.HostAutoFormatSettings Instance { get; }
        public virtual bool PrettyListingIsEnabled { get; }
        public virtual void DisableAutoFormat(JetBrains.DataFlow.Lifetime lifetime) { }
    }
    public enum SmartBraceInsertType
    {
        DISABLED = 0,
        ON_LBRACE = 1,
        ON_ENTER = 2,
    }
    public class static TypingAssistOptions
    {
        public static readonly System.Linq.Expressions.Expression<System.Func<JetBrains.ReSharper.Feature.Services.Options.TypingAssistSettings, JetBrains.ReSharper.Feature.Services.Options.SmartBraceInsertType>> BraceInsertTypeExpression;
        public static readonly System.Linq.Expressions.Expression<System.Func<JetBrains.ReSharper.Feature.Services.Options.TypingAssistSettings, bool>> FormatBlockOnRBraceExpression;
        public static readonly System.Linq.Expressions.Expression<System.Func<JetBrains.ReSharper.Feature.Services.Options.TypingAssistSettings, bool>> FormatStatementOnSemicolonExpression;
        public static readonly System.Linq.Expressions.Expression<System.Func<JetBrains.ReSharper.Feature.Services.Options.TypingAssistSettings, bool>> SmartIndentOnEnterExpression;
        public static readonly System.Linq.Expressions.Expression<System.Func<JetBrains.ReSharper.Feature.Services.Options.TypingAssistSettings, bool>> SmartParenthEnabledExpression;
    }
    [JetBrains.Application.Settings.SettingsKeyAttribute(typeof(JetBrains.ReSharper.Settings.CodeEditingSettings), "Typing assistance settings")]
    public class TypingAssistSettings
    {
        [JetBrains.Application.Settings.SettingsEntryAttribute(JetBrains.ReSharper.Feature.Services.Options.SmartBraceInsertType.ON_LBRACE, "Auto-insert closing brace")]
        public JetBrains.ReSharper.Feature.Services.Options.SmartBraceInsertType BraceInsertType;
        [JetBrains.Application.Settings.SettingsEntryAttribute(true, "Auto-format on closing brace")]
        public bool FormatBlockOnRBrace;
        [JetBrains.Application.Settings.SettingsEntryAttribute(true, "Auto-format on semicolon")]
        public bool FormatStatementOnSemicolon;
        [JetBrains.Application.Settings.SettingsEntryAttribute(false, "Auto-format on enter")]
        public bool SmartIndentOnEnter;
        [JetBrains.Application.Settings.SettingsEntryAttribute(true, "Auto-insert pair brackets, parentheses and quotes")]
        public bool SmartParenthEnabled;
    }
}
namespace JetBrains.ReSharper.Feature.Services.Options.Upgrade
{
    
    [JetBrains.Application.Configuration.Upgrade.GlobalSettingsUpgraderAttribute()]
    public class TypingAssistSettingsUpgrader : JetBrains.Application.Configuration.SettingTablesUpgrader
    {
        public TypingAssistSettingsUpgrader(JetBrains.Application.Env.RunsProducts.ProductConfigurations productConfigurations) { }
        protected override void DoUpgrade(JetBrains.Application.Configuration.IComponentSettingsProvider legacySettingsProvider, JetBrains.Application.Settings.IContextBoundSettingsStore boundSettingsStore, JetBrains.DataFlow.Lifetime upgradeLifetime, JetBrains.Application.Configuration.SettingsTableBase workspaceSettingsTable, JetBrains.Application.Configuration.SettingsTableBase globalSettingsTable) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.ParameterInfo
{
    
    public class AttributeInfoCandidate : JetBrains.ReSharper.Feature.Services.ParameterInfo.ParameterInfoCandidate
    {
        public readonly System.Collections.Generic.List<JetBrains.ReSharper.Psi.ITypeMember> PublicMembers;
        public AttributeInfoCandidate(JetBrains.ReSharper.Psi.PsiLanguageType language, JetBrains.ReSharper.Psi.ExpectedTypes.InvocationCandidate invocationCandidate, System.Collections.Generic.List<JetBrains.ReSharper.Psi.ITypeMember> publicProperties, int positionalParametersCount) { }
        public AttributeInfoCandidate(JetBrains.ReSharper.Psi.PsiLanguageType language, JetBrains.ReSharper.Psi.ExpectedTypes.InvocationCandidate invocationCandidate, JetBrains.ReSharper.Psi.IClass attributeClass, int positionalParametersCount) { }
        public override bool Equals(object obj) { }
        public static System.Collections.Generic.List<JetBrains.ReSharper.Psi.ITypeMember> GetAssignableMembers(JetBrains.ReSharper.Psi.IClass attributeClass, JetBrains.ReSharper.Psi.Modules.IPsiModule module) { }
        public override int GetHashCode() { }
        protected override System.Collections.Generic.IList<string> GetParameterNames() { }
        public override void GetParametersInfo(out string paramNames, out JetBrains.UI.RichText.RichTextBlock paramDescriptions, out bool isParamsArray) { }
        protected override string GetSignatureInternal(out JetBrains.Util.TextRange parameterRanges, out JetBrains.ReSharper.Feature.Services.ParameterInfo.ExtensionMethodInfo extensionMethodInfo) { }
    }
    public abstract class CachingCandidate : JetBrains.ReSharper.Feature.Services.ParameterInfo.ICandidate
    {
        protected CachingCandidate() { }
        public abstract bool IsFilteredOut { get; set; }
        public abstract bool IsObsolete { get; }
        protected virtual int MaxNamedParameters { get; }
        public abstract JetBrains.UI.RichText.RichTextBlock ObsoleteDescription { get; }
        public abstract int PositionalParameterCount { get; }
        public abstract JetBrains.UI.RichText.RichTextBlock GetDescription();
        protected abstract System.Collections.Generic.IList<string> GetParameterNames();
        protected static int GetParameterPosition(System.Collections.Generic.IList<string> names, string name) { }
        public abstract void GetParametersInfo(out string paramNames, out JetBrains.UI.RichText.RichTextBlock paramDescriptions, out bool isParamsArray);
        public virtual System.Collections.Generic.IList<bool> GetParametersObsoleteFlags() { }
        public virtual System.Collections.Generic.IList<JetBrains.UI.RichText.TextStyle> GetParameterStyles() { }
        public JetBrains.UI.RichText.RichText GetSignature(string[] namedArguments, out JetBrains.Util.TextRange parameterRanges, out int mapToOriginalOrder, out JetBrains.ReSharper.Feature.Services.ParameterInfo.ExtensionMethodInfo extensionMethodInfo) { }
        protected abstract string GetSignatureInternal(string[] namedArguments, out JetBrains.Util.TextRange parameterRanges, out int mapToOriginalOrder, out JetBrains.ReSharper.Feature.Services.ParameterInfo.ExtensionMethodInfo extensionMethodInfo);
        protected static System.Collections.Generic.IList<string> GetUsedNames(string[] namedArguments, out int firstNamed) { }
        public abstract bool Matches(JetBrains.ReSharper.Psi.IDeclaredElement signature);
        protected virtual string SortSignature(string[] namedArguments, string signature, ref JetBrains.Util.TextRange parameterRanges, out int mapToOriginalOrder) { }
    }
    public class ExtensionMethodInfo
    {
        public readonly JetBrains.Util.TextRange FirstParameterRange;
        public static readonly JetBrains.ReSharper.Feature.Services.ParameterInfo.ExtensionMethodInfo NoExtension;
        public readonly JetBrains.Util.TextRange ThisKeywordRange;
        public ExtensionMethodInfo(JetBrains.Util.TextRange firstParameterRange, JetBrains.Util.TextRange thisKeywordRange) { }
    }
    public interface ICandidate
    {
        bool IsFilteredOut { get; set; }
        bool IsObsolete { get; }
        JetBrains.UI.RichText.RichTextBlock ObsoleteDescription { get; }
        int PositionalParameterCount { get; }
        JetBrains.UI.RichText.RichTextBlock GetDescription();
        void GetParametersInfo(out string paramNames, out JetBrains.UI.RichText.RichTextBlock paramDescriptions, out bool isParamsArray);
        JetBrains.UI.RichText.RichText GetSignature(string[] namedArguments, out JetBrains.Util.TextRange parameterRanges, out int mapToOriginalOrder, out JetBrains.ReSharper.Feature.Services.ParameterInfo.ExtensionMethodInfo extensionMethodInfo);
        bool Matches(JetBrains.ReSharper.Psi.IDeclaredElement signature);
    }
    public interface IParameterInfoContext
    {
        int Argument { get; }
        JetBrains.ReSharper.Feature.Services.ParameterInfo.ICandidate[] Candidates { get; }
        JetBrains.ReSharper.Feature.Services.ParameterInfo.ICandidate DefaultCandidate { get; }
        string[] NamedArguments { get; set; }
        System.Type ParameterListNodeType { get; }
        System.Collections.Generic.ICollection<System.Type> ParameterNodeTypes { get; }
        JetBrains.Util.TextRange Range { get; }
    }
    public interface IParameterInfoContextFactory
    {
        System.Collections.Generic.IEnumerable<char> ImportantChars { get; }
        JetBrains.ReSharper.Psi.PsiLanguageType Language { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Feature.Services.ParameterInfo.IParameterInfoContext CreateContext([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.ISolution solution, [JetBrains.Annotations.NotNullAttribute()] JetBrains.DocumentModel.IDocument document, int caretOffset, int expectedLParenthOffset, char invocationChar, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.IContextBoundSettingsStore contextBoundSettingsStore);
        bool IsIntellisenseEnabled([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.ISolution solution, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.IContextBoundSettingsStore contextBoundSettingsStore);
        bool ShouldPopup([JetBrains.Annotations.NotNullAttribute()] JetBrains.DocumentModel.IDocument document, int caretOffset, char c, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.ISolution solution, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.IContextBoundSettingsStore contextBoundSettingsStore);
    }
    public interface IParameterInfoProvider : System.IDisposable
    {
        JetBrains.ReSharper.Feature.Services.ParameterInfo.IParameterInfoContext Context { get; }
        JetBrains.UI.PopupWindowManager.HideFlags HideFlags { get; }
        public event System.EventHandler ContextChanged;
        JetBrains.UI.PopupWindowManager.IPopupWindowContext CreatePopupWindowContext(JetBrains.DataFlow.Lifetime lifetime);
    }
    public class ObjectInitializerCandidate : JetBrains.ReSharper.Feature.Services.ParameterInfo.CachingCandidate
    {
        public ObjectInitializerCandidate(JetBrains.ReSharper.Psi.IType constructedType, System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.Resolve.ISymbolInfo> memberInfos, JetBrains.ReSharper.Psi.PsiLanguageType languageType) { }
        public override bool IsFilteredOut { get; set; }
        public override bool IsObsolete { get; }
        public int MembersCount { get; }
        public override JetBrains.UI.RichText.RichTextBlock ObsoleteDescription { get; }
        public override int PositionalParameterCount { get; }
        public static JetBrains.ReSharper.Feature.Services.ParameterInfo.ObjectInitializerCandidate Create(JetBrains.ReSharper.Psi.IType type, JetBrains.ReSharper.Psi.PsiLanguageType language, params JetBrains.ReSharper.Psi.Resolve.ISymbolFilter[] filters) { }
        public override JetBrains.UI.RichText.RichTextBlock GetDescription() { }
        protected override System.Collections.Generic.IList<string> GetParameterNames() { }
        public override void GetParametersInfo(out string paramNames, out JetBrains.UI.RichText.RichTextBlock paramDescriptions, out bool isParamsArray) { }
        public override System.Collections.Generic.IList<bool> GetParametersObsoleteFlags() { }
        protected override string GetSignatureInternal(string[] namedArguments, out JetBrains.Util.TextRange parameterRanges, out int mapToOriginalOrder, out JetBrains.ReSharper.Feature.Services.ParameterInfo.ExtensionMethodInfo extensionMethodInfo) { }
        public override bool Matches(JetBrains.ReSharper.Psi.IDeclaredElement signature) { }
    }
    public class ParameterInfoCandidate : JetBrains.ReSharper.Feature.Services.ParameterInfo.CachingCandidate
    {
        public readonly JetBrains.ReSharper.Psi.PsiLanguageType Language;
        protected ParameterInfoCandidate(JetBrains.ReSharper.Psi.PsiLanguageType language, JetBrains.ReSharper.Psi.ExpectedTypes.InvocationCandidate invocationCandidate, int positionalParameterCount) { }
        public JetBrains.ReSharper.Psi.ExpectedTypes.InvocationCandidate InvocationCandidate { get; }
        public bool IsExtensionMethod { get; }
        public override bool IsFilteredOut { get; set; }
        public override bool IsObsolete { get; }
        protected override int MaxNamedParameters { get; }
        public override JetBrains.UI.RichText.RichTextBlock ObsoleteDescription { get; }
        public override int PositionalParameterCount { get; }
        public static JetBrains.ReSharper.Feature.Services.ParameterInfo.ICandidate[] CreateCandidates(JetBrains.ReSharper.Psi.PsiLanguageType language, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.ExpectedTypes.InvocationCandidate> invocationCandidates) { }
        public static JetBrains.ReSharper.Feature.Services.ParameterInfo.ICandidate[] CreateCandidates(JetBrains.ReSharper.Psi.PsiLanguageType language, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.ExpectedTypes.InvocationCandidate> invocationCandidates, System.Converter<JetBrains.ReSharper.Psi.ExpectedTypes.InvocationCandidate, JetBrains.ReSharper.Feature.Services.ParameterInfo.ICandidate> creator) { }
        public override bool Equals(object obj) { }
        protected string FormatDelegate([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IDelegate @delegate, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution, JetBrains.ReSharper.Psi.DeclaredElementPresenterStyle presenter) { }
        public static System.Converter<JetBrains.ReSharper.Psi.ExpectedTypes.InvocationCandidate, JetBrains.ReSharper.Feature.Services.ParameterInfo.ICandidate> GetDefaultConverter(JetBrains.ReSharper.Psi.PsiLanguageType language) { }
        public override JetBrains.UI.RichText.RichTextBlock GetDescription() { }
        public override int GetHashCode() { }
        protected override System.Collections.Generic.IList<string> GetParameterNames() { }
        public override void GetParametersInfo(out string paramNames, out JetBrains.UI.RichText.RichTextBlock paramDescriptions, out bool isParamsArray) { }
        protected virtual JetBrains.ReSharper.Psi.DeclaredElementPresenterStyle GetPresenter() { }
        protected override string GetSignatureInternal(string[] namedArguments, out JetBrains.Util.TextRange parameterRanges, out int mapToOriginalOrder, out JetBrains.ReSharper.Feature.Services.ParameterInfo.ExtensionMethodInfo extensionMethodInfo) { }
        protected virtual string GetSignatureInternal(out JetBrains.Util.TextRange parameterRanges, out JetBrains.ReSharper.Feature.Services.ParameterInfo.ExtensionMethodInfo extensionMethodInfo) { }
        protected virtual JetBrains.Util.TextRange GetThisKeywordRange(JetBrains.Util.TextRange parameterRange) { }
        public override bool Matches(JetBrains.ReSharper.Psi.IDeclaredElement signature) { }
        protected virtual bool PresentReturnType(JetBrains.ReSharper.Psi.IParametersOwner parametersOwner) { }
    }
    public class ParameterInfoContextBase : JetBrains.ReSharper.Feature.Services.ParameterInfo.IParameterInfoContext
    {
        public ParameterInfoContextBase(int parameter, JetBrains.ReSharper.Feature.Services.ParameterInfo.ICandidate[] candidates, JetBrains.Util.TextRange range, int selectedInvocable, System.Type parameterNodeListType, params System.Type[] parameterNodeTypes) { }
        public int Argument { get; set; }
        public virtual JetBrains.ReSharper.Feature.Services.ParameterInfo.ICandidate[] Candidates { get; }
        public JetBrains.ReSharper.Feature.Services.ParameterInfo.ICandidate DefaultCandidate { get; }
        public string[] NamedArguments { get; set; }
        public System.Type ParameterListNodeType { get; }
        public System.Collections.Generic.ICollection<System.Type> ParameterNodeTypes { get; }
        public JetBrains.Util.TextRange Range { get; }
        public override bool Equals(object obj) { }
        public void FilterOut(int invocation) { }
        public override int GetHashCode() { }
        protected virtual string GetSortString(JetBrains.ReSharper.Feature.Services.ParameterInfo.ICandidate candidate) { }
    }
    [JetBrains.Annotations.MeansImplicitUseAttribute()]
    [System.AttributeUsageAttribute(System.AttributeTargets.Class | System.AttributeTargets.All)]
    public class ParameterInfoContextFactoryAttribute : JetBrains.ReSharper.Psi.LanguageAttribute
    {
        public ParameterInfoContextFactoryAttribute(System.Type language) { }
    }
    public class static ParameterInfoContextUtil
    {
        public static bool EqualCandidates(JetBrains.ReSharper.Feature.Services.ParameterInfo.IParameterInfoContext cntx1, JetBrains.ReSharper.Feature.Services.ParameterInfo.IParameterInfoContext cntx2) { }
        public static bool EqualNamedArgs(string[] namedArgs1, string[] namedArgs2) { }
    }
    public abstract class ParameterInfoPopupController
    {
        protected ParameterInfoPopupController(JetBrains.ReSharper.Psi.ILanguageManager languageManager) { }
        public abstract bool IsParameterInfoShownInCurrentContext { get; }
        protected JetBrains.ReSharper.Psi.ILanguageManager LanguageManager { get; }
        public abstract bool SupportsSignatureSwitching { get; }
        public event System.EventHandler AfterParameterWindowClosed;
        public event System.EventHandler BeforeParameterWindowShown;
        public abstract JetBrains.ReSharper.Feature.Services.ParameterInfo.IParameterInfoContext CreateContext(JetBrains.ProjectModel.ISolution solution, JetBrains.DocumentModel.IDocument document, int caretOffset, int expectedLParenthOffset);
        public abstract void EmulateTyping(char c, JetBrains.TextControl.ITextControl textControl);
        public static JetBrains.ReSharper.Feature.Services.ParameterInfo.ParameterInfoPopupController GetInstance(JetBrains.ProjectModel.ISolution solution) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Feature.Services.ParameterInfo.ParameterInfoPopupController GetInstance(JetBrains.Application.DataContext.IDataContext dataContext) { }
        public abstract bool IsParameterInfoAvailable(JetBrains.Application.DataContext.IDataContext context);
        public abstract void MoveParameterInfoOnTop();
        public abstract void PopupParameterInfo(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl, int expectedLParOffset, JetBrains.ReSharper.Psi.IDeclaredElement signature);
        public abstract void PopupParameterInfo(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl);
        public abstract void PopupParameterInfo(JetBrains.Application.DataContext.IDataContext context);
        public abstract void PopupParameterInfo(JetBrains.ReSharper.Feature.Services.ParameterInfo.IParameterInfoProvider provider, JetBrains.TextControl.ITextControl textControl);
        protected void RaiseAfterParameterInfoWindowClosed() { }
        protected void RaiseBeforeParameterInfoWindowShown() { }
        public abstract void ShowDocForNextSignature();
        public abstract void ShowDocForPreviousSignature();
    }
    public class TypeArgumentCandidate : JetBrains.ReSharper.Feature.Services.ParameterInfo.CachingCandidate
    {
        public TypeArgumentCandidate(JetBrains.ReSharper.Psi.ITypeParametersOwner typeElement, JetBrains.ReSharper.Psi.PsiLanguageType language) { }
        public override bool IsFilteredOut { get; set; }
        public override bool IsObsolete { get; }
        public override JetBrains.UI.RichText.RichTextBlock ObsoleteDescription { get; }
        public override int PositionalParameterCount { get; }
        public override bool Equals(object obj) { }
        public override JetBrains.UI.RichText.RichTextBlock GetDescription() { }
        public override int GetHashCode() { }
        protected override System.Collections.Generic.IList<string> GetParameterNames() { }
        public override void GetParametersInfo(out string paramNames, out JetBrains.UI.RichText.RichTextBlock paramDescriptions, out bool isParamsArray) { }
        protected override string GetSignatureInternal(string[] namedArguments, out JetBrains.Util.TextRange parameterRanges, out int mapToOriginalOrder, out JetBrains.ReSharper.Feature.Services.ParameterInfo.ExtensionMethodInfo extensionMethodInfo) { }
        public override bool Matches(JetBrains.ReSharper.Psi.IDeclaredElement signature) { }
        public bool Matches(int iParameter, System.Collections.Generic.IList<JetBrains.ReSharper.Psi.IType> typeArguments) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.ParameterInfo.Settings
{
    
    [JetBrains.Application.Settings.SettingsKeyAttribute(typeof(JetBrains.ReSharper.Feature.Services.CodeCompletion.Settings.IntellisenseSettingsKey), "Parameter Info settings")]
    public class ParameterInfoSettingsKey
    {
        [JetBrains.Application.Settings.SettingsEntryAttribute(0, "Automatic Parameter Info delay in milliseconds")]
        public int AutopopupDelay;
        [JetBrains.Application.Settings.SettingsEntryAttribute(true, "Enable automatic Parameter Info popup")]
        public bool AutopopupOn;
        [JetBrains.Application.Settings.SettingsEntryAttribute(false, "Keyword completion minimal length")]
        public bool DelegatesAsLambdas;
        [JetBrains.Application.Settings.SettingsEntryAttribute(true, "Show all candidates in Parameter Info popup")]
        public bool ShowAllCandidates;
        [JetBrains.Application.Settings.SettingsEntryAttribute(true, "Use arrows (instead of Parameter Info shortcut) in Parameter Info popup")]
        public bool UseArrowsForSignatureNavigation;
    }
}
namespace JetBrains.ReSharper.Feature.Services.ParameterInfo.SettingsUpgrade
{
    
    [System.ObsoleteAttribute("Deprecated, use ParameterInfoSettingsKey")]
    public class ParameterInfoSettings : JetBrains.Application.Configuration.IXmlReadable
    {
        [JetBrains.Application.Configuration.XmlExternalizableAttribute(0, SettingName="AutopopupDelay2")]
        public readonly JetBrains.DataFlow.Property<int> AutopopupDelay;
        [JetBrains.Application.Configuration.XmlExternalizableAttribute(true)]
        public readonly JetBrains.DataFlow.Property<bool> AutopopupOn;
        [JetBrains.Application.Configuration.XmlExternalizableAttribute(false)]
        public readonly JetBrains.DataFlow.Property<bool> DelegatesAsLambdas;
        [JetBrains.Application.Configuration.XmlExternalizableAttribute(false)]
        public readonly JetBrains.DataFlow.Property<bool> ShowOneCandidate;
        [JetBrains.Application.Configuration.XmlExternalizableAttribute(true)]
        public readonly JetBrains.DataFlow.Property<bool> UseArrowsForSignatureNavigation;
        public ParameterInfoSettings(JetBrains.Application.Configuration.IComponentSettingsProvider shellSettingsComponent, JetBrains.DataFlow.Lifetime lifetime) { }
    }
    [JetBrains.Application.Configuration.Upgrade.GlobalSettingsUpgraderAttribute()]
    public class ParameterInfoSettingsUpgrade : JetBrains.Application.Configuration.Upgrade.IGlobalSettingsUpgrader, JetBrains.Application.Configuration.Upgrade.ISettingsUpgrader
    {
        public void Upgrade(JetBrains.Application.Configuration.IComponentSettingsProvider legacySettingsProvider, JetBrains.Application.Settings.IContextBoundSettingsStore boundSettingsStore, JetBrains.DataFlow.Lifetime upgradeLifetime) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.PathTracker
{
    
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class PathReferenceTracker
    {
        public PathReferenceTracker(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ProjectModel.ISolution solution, JetBrains.Threading.IThreading invocator, JetBrains.UI.Application.Progress.UITaskExecutor uiTaskExecutor, JetBrains.Application.ChangeManager changeManager, JetBrains.ProjectModel.ProjectFileExtensions projectFileExtensions, JetBrains.Application.Settings.ISettingsStore store) { }
        public bool Enabled { get; set; }
    }
    [JetBrains.Application.Settings.SettingsKeyAttribute(typeof(JetBrains.ReSharper.Settings.CodeEditingSettings), "Tracks references to files in string values inside source code")]
    public class PathReferenceTrackerSettings
    {
        [JetBrains.Application.Settings.SettingsEntryAttribute(false, "Whether the feature is enabled")]
        public bool IsEnabled;
    }
    public class static PathReferenceTrackerSettingsAccessor
    {
        public static readonly System.Linq.Expressions.Expression<System.Func<JetBrains.ReSharper.Feature.Services.PathTracker.PathReferenceTrackerSettings, bool>> IsEnabled;
    }
    [JetBrains.Application.Configuration.Upgrade.GlobalSettingsUpgraderAttribute()]
    public class PathReferenceTrackerSettingsUpgrader : JetBrains.Application.Configuration.IXmlReadable, JetBrains.Application.Configuration.Upgrade.IGlobalSettingsUpgrader, JetBrains.Application.Configuration.Upgrade.ISettingsUpgrader { }
}
namespace JetBrains.ReSharper.Feature.Services.Psi
{
    
    public interface IUnresolvedTypesChooser
    {
        void AddUnresolvedTypes(string typeText, System.Collections.Generic.Dictionary<string, JetBrains.ReSharper.Feature.Services.Psi.UnresolvedDeclaredType> result);
        JetBrains.ReSharper.Psi.IType Apply(string typeText, System.Collections.Generic.Dictionary<string, JetBrains.ReSharper.Feature.Services.Psi.UnresolvedDeclaredType> boundTypes);
    }
    public abstract class ReferencedCodeSearchHelperBase
    {
        protected System.Collections.Generic.ICollection<JetBrains.Util.JetTuple<JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.ReSharper.Psi.IClrDeclaredElement>> GetConversionOperators(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.Tree.IExpression expression) { }
    }
    public class UnresolvedDeclaredType
    {
        public UnresolvedDeclaredType(string shortName, int typeArgsNumber, JetBrains.ReSharper.Psi.Tree.ITreeNode context) { }
        public System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.ITypeElement> Candidates { get; }
        public JetBrains.ReSharper.Psi.ITypeElement Resolution { get; set; }
        public void SuggestTypeElements(string shortName, int typeArgsNumber, JetBrains.ReSharper.Psi.Tree.ITreeNode context) { }
        public override string ToString() { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.QuickDoc
{
    
    public interface IQuickDocPresenter
    {
        string GetHtml(JetBrains.ReSharper.Psi.PsiLanguageType presentationLanguage);
        [JetBrains.Annotations.CanBeNullAttribute()]
        string GetId();
        void OpenInEditor();
        void ReadMore();
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Feature.Services.QuickDoc.IQuickDocPresenter Resolve(string id);
    }
    public interface IQuickDocProvider
    {
        bool CanNavigate(JetBrains.Application.DataContext.IDataContext context);
        void Resolve(JetBrains.Application.DataContext.IDataContext context, System.Action<JetBrains.ReSharper.Feature.Services.QuickDoc.IQuickDocPresenter, JetBrains.ReSharper.Psi.PsiLanguageType> resolved);
    }
    [JetBrains.Annotations.BaseTypeRequiredAttribute(typeof(JetBrains.ReSharper.Feature.Services.QuickDoc.IQuickDocProvider))]
    [JetBrains.Annotations.MeansImplicitUseAttribute()]
    [System.AttributeUsageAttribute(System.AttributeTargets.Class | System.AttributeTargets.All, AllowMultiple=false)]
    public class QuickDocProviderAttribute : JetBrains.ProjectModel.SolutionComponentAttribute
    {
        public QuickDocProviderAttribute(int priority) { }
        public int Priority { get; }
    }
}
namespace JetBrains.ReSharper.Feature.Services.QuickDoc.Presenters
{
    
    public class QuickDocCommentNodePresenter : JetBrains.ReSharper.Feature.Services.QuickDoc.IQuickDocPresenter
    {
        public QuickDocCommentNodePresenter(JetBrains.ReSharper.Feature.Services.Navigation.NavigationManager navigationManager, JetBrains.ReSharper.Feature.Services.QuickDoc.Providers.QuickDocTypeMemberProvider quickDocTypeMemberProvider, JetBrains.ReSharper.Psi.ITreeNodePointer<JetBrains.ReSharper.Psi.Tree.IDocCommentBlockNode> commentNode) { }
        public string GetHtml(JetBrains.ReSharper.Psi.PsiLanguageType presentationLanguage) { }
        public string GetId() { }
        public void OpenInEditor() { }
        public void ReadMore() { }
        public JetBrains.ReSharper.Feature.Services.QuickDoc.IQuickDocPresenter Resolve(string id) { }
    }
    public class QuickDocDescriptionPresenter : JetBrains.ReSharper.Feature.Services.QuickDoc.IQuickDocPresenter
    {
        public QuickDocDescriptionPresenter(JetBrains.ReSharper.Feature.Services.Navigation.NavigationManager navigationManager, JetBrains.ReSharper.Psi.IDeclaredElement element, JetBrains.ReSharper.Feature.Services.Descriptions.IDeclaredElementDescriptionPresenter presenter) { }
        public string GetHtml(JetBrains.ReSharper.Psi.PsiLanguageType presentationLanguage) { }
        public string GetId() { }
        public void OpenInEditor() { }
        public void ReadMore() { }
        public JetBrains.ReSharper.Feature.Services.QuickDoc.IQuickDocPresenter Resolve(string id) { }
    }
    public class QuickDocEmptyPresenter : JetBrains.ReSharper.Feature.Services.QuickDoc.IQuickDocPresenter
    {
        public string GetHtml(JetBrains.ReSharper.Psi.PsiLanguageType presentationLanguage) { }
        public string GetId() { }
        public void OpenInEditor() { }
        public void ReadMore() { }
        public JetBrains.ReSharper.Feature.Services.QuickDoc.IQuickDocPresenter Resolve(string id) { }
    }
    public class QuickDocLocalSymbolPresenter : JetBrains.ReSharper.Feature.Services.QuickDoc.IQuickDocPresenter
    {
        public QuickDocLocalSymbolPresenter(JetBrains.ReSharper.Feature.Services.Navigation.NavigationManager navigationManager, JetBrains.ReSharper.Feature.Services.QuickDoc.Providers.QuickDocTypeMemberProvider quickDocTypeMemberProvider, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IClrDeclaredElement element) { }
        public string GetHtml(JetBrains.ReSharper.Psi.PsiLanguageType presentationLanguage) { }
        public string GetId() { }
        public void OpenInEditor() { }
        public void ReadMore() { }
        public JetBrains.ReSharper.Feature.Services.QuickDoc.IQuickDocPresenter Resolve(string id) { }
    }
    public class QuickDocTypeMemberPresenter : JetBrains.ReSharper.Feature.Services.QuickDoc.IQuickDocPresenter
    {
        public QuickDocTypeMemberPresenter(JetBrains.ReSharper.Feature.Services.Navigation.NavigationManager navigationManager, JetBrains.UI.Application.HelpSystem helpSystem, JetBrains.ReSharper.Feature.Services.QuickDoc.Providers.QuickDocTypeMemberProvider quickDocTypeMemberProvider, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.ITypeMember element) { }
        public string GetHtml(JetBrains.ReSharper.Psi.PsiLanguageType presentationLanguage) { }
        public string GetId() { }
        public void OpenInEditor() { }
        public void ReadMore() { }
        public JetBrains.ReSharper.Feature.Services.QuickDoc.IQuickDocPresenter Resolve(string id) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.QuickDoc.Providers
{
    
    [JetBrains.ReSharper.Feature.Services.QuickDoc.QuickDocProviderAttribute(0)]
    public class QuickDocCommentNodeProvider : JetBrains.ReSharper.Feature.Services.QuickDoc.IQuickDocProvider
    {
        public QuickDocCommentNodeProvider(JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Feature.Services.Navigation.NavigationManager navigationManager, JetBrains.ReSharper.Psi.Files.IPsiFiles psiFiles, JetBrains.ReSharper.Psi.ILanguageManager languageManager, JetBrains.ReSharper.Feature.Services.QuickDoc.Providers.QuickDocTypeMemberProvider quickDocTypeMemberProvider) { }
        public bool CanNavigate(JetBrains.Application.DataContext.IDataContext context) { }
        public void Resolve(JetBrains.Application.DataContext.IDataContext context, System.Action<JetBrains.ReSharper.Feature.Services.QuickDoc.IQuickDocPresenter, JetBrains.ReSharper.Psi.PsiLanguageType> resolved) { }
    }
    [JetBrains.ReSharper.Feature.Services.QuickDoc.QuickDocProviderAttribute(1)]
    public class QuickDocDescriptionProvider : JetBrains.ReSharper.Feature.Services.QuickDoc.IQuickDocProvider
    {
        public QuickDocDescriptionProvider(JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Feature.Services.Navigation.NavigationManager navigationManager, JetBrains.ReSharper.Feature.Services.Descriptions.IDeclaredElementDescriptionPresenter descriptionPresenter, JetBrains.DocumentManagers.DocumentManager documentManager) { }
        public bool CanNavigate(JetBrains.Application.DataContext.IDataContext context) { }
        public void Resolve(JetBrains.Application.DataContext.IDataContext context, System.Action<JetBrains.ReSharper.Feature.Services.QuickDoc.IQuickDocPresenter, JetBrains.ReSharper.Psi.PsiLanguageType> resolved) { }
    }
    [JetBrains.ReSharper.Feature.Services.QuickDoc.QuickDocProviderAttribute(0)]
    public class QuickDocLocalSymbolProvider : JetBrains.ReSharper.Feature.Services.QuickDoc.IQuickDocProvider
    {
        public QuickDocLocalSymbolProvider(JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Feature.Services.Navigation.NavigationManager navigationManager, JetBrains.DocumentManagers.DocumentManager documentManager, JetBrains.ReSharper.Feature.Services.QuickDoc.Providers.QuickDocTypeMemberProvider quickDocTypeMemberProvider) { }
        public bool CanNavigate(JetBrains.Application.DataContext.IDataContext context) { }
        public void Resolve(JetBrains.Application.DataContext.IDataContext context, System.Action<JetBrains.ReSharper.Feature.Services.QuickDoc.IQuickDocPresenter, JetBrains.ReSharper.Psi.PsiLanguageType> resolved) { }
    }
    [JetBrains.ReSharper.Feature.Services.QuickDoc.QuickDocProviderAttribute(0)]
    public class QuickDocTypeMemberProvider : JetBrains.ReSharper.Feature.Services.QuickDoc.IQuickDocProvider
    {
        public QuickDocTypeMemberProvider(JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Feature.Services.Navigation.NavigationManager navigationManager, JetBrains.DocumentManagers.DocumentManager documentManager, JetBrains.UI.Application.HelpSystem helpSystem) { }
        public bool CanNavigate(JetBrains.Application.DataContext.IDataContext context) { }
        public void Resolve(JetBrains.Application.DataContext.IDataContext context, System.Action<JetBrains.ReSharper.Feature.Services.QuickDoc.IQuickDocPresenter, JetBrains.ReSharper.Psi.PsiLanguageType> resolved) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Feature.Services.QuickDoc.IQuickDocPresenter Resolve(string id, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Modules.IPsiModule module, JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext context) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.QuickDoc.Render
{
    
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.KnownLanguage))]
    public class CommonXmlDocHeaderPresenter : JetBrains.ReSharper.Feature.Services.QuickDoc.Render.IXmlDocHeaderPresenter
    {
        public CommonXmlDocHeaderPresenter(JetBrains.ReSharper.Psi.PsiLanguageType language) { }
        public virtual void Present(System.Text.StringBuilder header, JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, JetBrains.ReSharper.Psi.Modules.IPsiModule module) { }
    }
    public abstract class HtmlAttributesPresenterBase : JetBrains.ReSharper.Feature.Services.QuickDoc.Render.IHtmlAttributesPresenter
    {
        protected HtmlAttributesPresenterBase(JetBrains.ReSharper.Psi.PsiLanguageType language, JetBrains.ReSharper.Feature.Services.QuickDoc.Render.IHtmlEnumPresenter enumPresenter) { }
        protected abstract string GetArrayBrackets();
        protected abstract char GetAttributeCloseChar();
        protected abstract char GetAttributeOpenChar();
        protected abstract string GetAttributePropertyAssignChar();
        protected abstract string GetNew();
        protected abstract string GetNewLine();
        protected abstract string GetNull();
        protected abstract string GetTypeOf();
        protected abstract JetBrains.ReSharper.Feature.Services.QuickDoc.Render.IHtmlTypePresenter GetTypePresenter();
        public void PresentForParameter(System.Text.StringBuilder builder, JetBrains.ReSharper.Psi.IAttributesOwner attributesOwner) { }
        public void PresentForTypeMember(System.Text.StringBuilder builder, JetBrains.ReSharper.Psi.IAttributesOwner attributesOwner) { }
    }
    public abstract class HtmlEnumPresenterBase : JetBrains.ReSharper.Feature.Services.QuickDoc.Render.IHtmlEnumPresenter
    {
        protected HtmlEnumPresenterBase(JetBrains.ReSharper.Psi.PsiLanguageType language) { }
        protected abstract JetBrains.ReSharper.Psi.Tree.ITreeNode ExtractTreeNode([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IField element);
        public string Present([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IField element) { }
        public string Present(JetBrains.ReSharper.Psi.ConstantValue value) { }
        protected virtual string PresentEnum(JetBrains.ReSharper.Psi.ConstantValue value, bool isFieldDeclaration) { }
        protected abstract string TryGetXmlDocId(JetBrains.ReSharper.Psi.Tree.ITreeNode child);
    }
    public interface IHtmlAttributesPresenter
    {
        void PresentForParameter(System.Text.StringBuilder builder, JetBrains.ReSharper.Psi.IAttributesOwner attributesOwner);
        void PresentForTypeMember(System.Text.StringBuilder builder, JetBrains.ReSharper.Psi.IAttributesOwner attributesOwner);
    }
    public interface IHtmlEnumPresenter
    {
        string Present(JetBrains.ReSharper.Psi.IField element);
        string Present(JetBrains.ReSharper.Psi.ConstantValue value);
    }
    public interface IHtmlTypePresenter
    {
        void PresentName(System.Text.StringBuilder builder, JetBrains.ReSharper.Psi.IType type);
    }
    public interface IXmlDocHeaderPresenter
    {
        void Present([JetBrains.Annotations.NotNullAttribute()] System.Text.StringBuilder header, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Modules.IPsiModule module);
    }
    public interface IXmlDocLocator
    {
        JetBrains.ReSharper.Psi.Tree.IDocCommentBlockNode FindCommentNode(JetBrains.ReSharper.Psi.Tree.IFile file, JetBrains.DocumentModel.DocumentRange range);
    }
    public delegate string ProcessCref(string cref, string linkText, bool addHyperlink, JetBrains.ReSharper.Psi.Modules.IPsiModule module, JetBrains.ReSharper.Psi.PsiLanguageType languageType);
    public class static XmlDocHtmlPresenter
    {
        public static string Run(System.Xml.XmlNode node, JetBrains.ReSharper.Psi.Modules.IPsiModule module, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, JetBrains.ReSharper.Psi.PsiLanguageType languageType, JetBrains.ReSharper.Feature.Services.QuickDoc.Render.XmlDocHtmlUtil.NavigationStyle navigationStyle, JetBrains.ReSharper.Feature.Services.QuickDoc.Render.ProcessCref processCref) { }
        public static string UriToXmlDocId(System.Uri uri) { }
        public static string UriToXmlDocId(string hyperlink) { }
    }
    public class static XmlDocHtmlUtil
    {
        public const string GOTO_LINK = "about:goto";
        public const string QUICK_DOC_HTML_STYLE = @"    <style type=""text/css"">
       body,tbody {font: normal 8pt verdana,arial,helvetica; color: InfoText; background-color: InfoBackground; margin: 0px; padding: 0px; overflow-y: expression(document.body.scrollHeight > document.body.clientHeight ? 'scroll' : 'hidden'); }
       h1 {margin: 5px 0px 0px 0px; font: bold 9pt verdana,arial,helvetica;}
       table.list {margin: 5px 0 5px 0}
       table.list tr th {font-size: 8pt; font-weight: bold;}
       table.list tr {font-size: 8pt; text-align: left;}
       td.pdef {white-space: nowrap; vertical-align: top;}
       pre.outline {margin: 5px 0 5px 0;}
       dl.headers {font-size: 10pt; margin: 5px 0 10px 0;}
       dl.headers dt {float:left;}
       dl.headers dd {padding-left: 50px;}
       dl.headers dt em {display:block; font:100% normal; padding-left: 15px;}
       br {clear:left;}
       a:visited{color:#06c;}
    </style>
";
        public const string READMORE_LINK = "about:readmore";
        public const string XmlIdHyperlinkProtoScheme = "cref";
        public static string BuildHtml(System.Func<System.Text.StringBuilder, System.Text.StringBuilder> appendHtmlBody, JetBrains.ReSharper.Feature.Services.QuickDoc.Render.XmlDocHtmlUtil.NavigationStyle navigationStyle) { }
        public static void CloseAttributesRegion(System.Text.StringBuilder header) { }
        public static void CloseCollapsedRegion(System.Text.StringBuilder header) { }
        public static string Hyperlink(string name, string sXmlDocId) { }
        public static string Hyperlink(string name, string sXmlDocId, [JetBrains.Annotations.CanBeNullAttribute()] string tooltip) { }
        public static void OpenAttributesRegion(System.Text.StringBuilder header, string regionTitle) { }
        public static void OpenCollapsedRegion(System.Text.StringBuilder header, string regionTitle) { }
        public static string ProcessCRef(string cref, string linkText, bool addHyperlink, JetBrains.ReSharper.Psi.Modules.IPsiModule module, JetBrains.ReSharper.Psi.PsiLanguageType languageType, JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext context) { }
        [System.FlagsAttribute()]
        public enum NavigationStyle
        {
            None = 0,
            Goto = 1,
            ReadMore = 2,
            All = 3,
        }
    }
    public abstract class XmlDocImagesProvider
    {
        public abstract JetBrains.Util.FileSystemPath InlineCollapsPath { get; }
        public abstract string InlineCollapsPathJS { get; }
        public abstract JetBrains.Util.FileSystemPath InlineExpandPath { get; }
        public abstract string InlineExpandPathJS { get; }
        public static JetBrains.ReSharper.Feature.Services.QuickDoc.Render.XmlDocImagesProvider GetInstance() { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.RearrangeCode
{
    
    [System.FlagsAttribute()]
    public enum Direction : uint
    {
        Up = 1u,
        Down = 2u,
        Left = 4u,
        Right = 8u,
        LeftRight = 12u,
        UpDown = 3u,
        All = 15u,
        Any = 15u,
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class ElementRearranger
    {
        public ElementRearranger(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.RearrangeCode.IRearrangeableElementType> elementTypes) { }
        public static JetBrains.ReSharper.Feature.Services.RearrangeCode.ElementRearranger Instance { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public System.Collections.Generic.IList<JetBrains.ReSharper.Feature.Services.RearrangeCode.IRearrangeable> GetApplicableElements(JetBrains.ReSharper.Feature.Services.RearrangeCode.Direction direction, [JetBrains.Annotations.NotNullAttribute()] JetBrains.TextControl.ITextControl textControl, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ProjectModel.ISolution solution) { }
    }
    public interface IRearrangeable
    {
        JetBrains.DocumentModel.DocumentRange Range { get; }
        JetBrains.ReSharper.Feature.Services.RearrangeCode.Direction SupportedDirections { get; }
        string Title { get; }
        bool CanMove(JetBrains.ReSharper.Feature.Services.RearrangeCode.Direction direction);
        JetBrains.DocumentModel.DocumentRange Move(JetBrains.ReSharper.Feature.Services.RearrangeCode.Direction direction);
    }
    public interface IRearrangeableElementType
    {
        JetBrains.ReSharper.Feature.Services.RearrangeCode.IRearrangeable CreateElement([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl);
    }
    public abstract class RearrangeableElement : JetBrains.ReSharper.Feature.Services.RearrangeCode.IRearrangeable
    {
        protected abstract JetBrains.ReSharper.Psi.Tree.ITreeNode Element { get; }
        public virtual JetBrains.DocumentModel.DocumentRange Range { get; }
        public abstract JetBrains.ReSharper.Feature.Services.RearrangeCode.Direction SupportedDirections { get; }
        public abstract string Title { get; }
        public abstract bool CanMove(JetBrains.ReSharper.Feature.Services.RearrangeCode.Direction direction);
        protected abstract JetBrains.ReSharper.Psi.Tree.ITreeNode Move(JetBrains.ReSharper.Feature.Services.RearrangeCode.Direction direction);
    }
    public abstract class RearrangeableElementAppendRemove<TElement, TParent> : JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableSingleElementBase<TElement>
        where TElement :  class, JetBrains.ReSharper.Psi.Tree.ITreeNode
        where TParent :  class, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        protected RearrangeableElementAppendRemove(TElement element, string title, JetBrains.ReSharper.Feature.Services.RearrangeCode.Direction directionType) { }
        protected abstract TParent Parent { get; }
        protected abstract TElement AddAfter(TParent parent, TElement child, TElement anchor);
        protected abstract TElement AddBefore(TParent parent, TElement child, TElement anchor);
        protected abstract System.Collections.Generic.IEnumerable<TElement> GetChildren(TParent parent);
        protected override System.Collections.Generic.IEnumerable<TElement> GetSiblings() { }
        protected override JetBrains.ReSharper.Psi.Tree.ITreeNode Move(JetBrains.ReSharper.Feature.Services.RearrangeCode.Direction direction) { }
        protected abstract void RemoveChild(TParent parent, TElement child);
    }
    public abstract class RearrangeableElementSwap<TElem> : JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableSingleElementBase<TElem>
        where TElem :  class, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        protected RearrangeableElementSwap(TElem element, string title, JetBrains.ReSharper.Feature.Services.RearrangeCode.Direction directionType) { }
        protected override JetBrains.ReSharper.Psi.Tree.ITreeNode Move(JetBrains.ReSharper.Feature.Services.RearrangeCode.Direction direction) { }
        protected virtual TElem Swap(TElem child, TElem target) { }
    }
    [JetBrains.Annotations.MeansImplicitUseAttribute()]
    [System.AttributeUsageAttribute(System.AttributeTargets.Class | System.AttributeTargets.All, AllowMultiple=false)]
    public class RearrangeableElementTypeAttribute : JetBrains.Application.ShellComponentAttribute
    {
        public const int DEFAULT_LEVEL = 100;
        public const int HUMBLE_LEVEL = -100;
        public RearrangeableElementTypeAttribute() { }
        public bool Internal { get; set; }
        public int Level { get; set; }
    }
    public class RearrangeableLines : JetBrains.ReSharper.Feature.Services.RearrangeCode.IRearrangeable
    {
        public RearrangeableLines([JetBrains.Annotations.NotNullAttribute()] JetBrains.TextControl.ITextControl textControl, JetBrains.Util.dataStructures.TypedIntrinsics.Int32<JetBrains.DocumentModel.DocLine> startLine, JetBrains.Util.dataStructures.TypedIntrinsics.Int32<JetBrains.DocumentModel.DocLine> endLine, JetBrains.ProjectModel.ISolution solution) { }
        public JetBrains.DocumentModel.DocumentRange Range { get; }
        public JetBrains.ReSharper.Feature.Services.RearrangeCode.Direction SupportedDirections { get; }
        public string Title { get; }
        public bool CanMove(JetBrains.ReSharper.Feature.Services.RearrangeCode.Direction direction) { }
        public JetBrains.DocumentModel.DocumentRange Move(JetBrains.ReSharper.Feature.Services.RearrangeCode.Direction direction) { }
    }
    public abstract class RearrangeableLogicalItemBase<THolder> : JetBrains.ReSharper.Feature.Services.RearrangeCode.IRearrangeable
        where THolder : JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        protected RearrangeableLogicalItemBase(System.Collections.Generic.IList<JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableLogicalItemBase<THolder>.ILogicalItem> selectedItems, THolder holder, System.Collections.Generic.IList<JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableLogicalItemBase<THolder>.ILogicalItem> holderItems) { }
        protected THolder Holder { get; }
        protected System.Collections.Generic.IList<JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableLogicalItemBase<THolder>.ILogicalItem> HolderItems { get; }
        public JetBrains.DocumentModel.DocumentRange Range { get; }
        protected System.Collections.Generic.IList<JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableLogicalItemBase<THolder>.ILogicalItem> SelectedItems { get; }
        public abstract JetBrains.ReSharper.Feature.Services.RearrangeCode.Direction SupportedDirections { get; }
        public virtual string Title { get; }
        protected JetBrains.ReSharper.Psi.ITreeRange TreeRange { get; }
        public abstract bool CanMove(JetBrains.ReSharper.Feature.Services.RearrangeCode.Direction direction);
        public abstract JetBrains.DocumentModel.DocumentRange Move(JetBrains.ReSharper.Feature.Services.RearrangeCode.Direction direction);
        public interface ILogicalItem<THolder>
            where THolder : JetBrains.ReSharper.Psi.Tree.ITreeNode
        {
            bool IsWhitespace { get; }
            string Title { get; }
            JetBrains.ReSharper.Psi.ITreeRange TreeRange { get; }
            JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableLogicalItemBase<THolder>.LogicalItemBase.SelectionType GetSelectionType(JetBrains.Util.TextRange selection);
        }
        protected class LogicalEmptyLines<THolder> : JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableLogicalItemBase<THolder>.LogicalItemBase
            where THolder : JetBrains.ReSharper.Psi.Tree.ITreeNode
        {
            public LogicalEmptyLines(JetBrains.ReSharper.Psi.Util.TreeRange treeRange) { }
            public override bool IsWhitespace { get; }
        }
        public class LogicalItemBase<THolder> : JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableLogicalItemBase<THolder>.ILogicalItem
            where THolder : JetBrains.ReSharper.Psi.Tree.ITreeNode
        {
            public LogicalItemBase(JetBrains.ReSharper.Psi.Util.TreeRange treeRange, string title) { }
            public virtual bool IsWhitespace { get; }
            public string Title { get; }
            public JetBrains.ReSharper.Psi.ITreeRange TreeRange { get; }
            public JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableLogicalItemBase<THolder>.LogicalItemBase.SelectionType GetSelectionType(JetBrains.Util.TextRange selection) { }
            public enum SelectionType<THolder>
                where THolder : JetBrains.ReSharper.Psi.Tree.ITreeNode
            {
                NotSelected = 0,
                Selected = 1,
                Broken = 2,
            }
        }
        public abstract class TypeBase<THolder> : JetBrains.ReSharper.Feature.Services.RearrangeCode.IRearrangeableElementType
            where THolder : JetBrains.ReSharper.Psi.Tree.ITreeNode
        {
            protected static bool CheckHolderIsValid(JetBrains.ReSharper.Psi.Tree.ITreeNode holder, JetBrains.Util.TextRange selection) { }
            public abstract JetBrains.ReSharper.Feature.Services.RearrangeCode.IRearrangeable CreateElement(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl);
            protected abstract JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableLogicalItemBase<THolder>.ILogicalItem CreateItem([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode cursor, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableLogicalItemBase<THolder>.ILogicalItem prevItem);
            protected System.Collections.Generic.IList<JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableLogicalItemBase<THolder>.ILogicalItem> GetItemsInNode(JetBrains.ReSharper.Psi.Tree.ITreeNode block, bool supportWhitespaces) { }
            protected System.Collections.Generic.IList<JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableLogicalItemBase<THolder>.ILogicalItem> GetSelectedItems(JetBrains.Util.TextRange selection, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableLogicalItemBase<THolder>.ILogicalItem> items) { }
            protected abstract bool TreeNodeIsNewLine(JetBrains.ReSharper.Psi.Tree.ITreeNode node);
        }
    }
    public abstract class RearrangeableSingleElementBase<TElem> : JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableElement
        where TElem :  class, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        protected RearrangeableSingleElementBase(TElem element, string title, JetBrains.ReSharper.Feature.Services.RearrangeCode.Direction directionType) { }
        protected override JetBrains.ReSharper.Psi.Tree.ITreeNode Element { get; }
        public override JetBrains.ReSharper.Feature.Services.RearrangeCode.Direction SupportedDirections { get; }
        protected TElem TElement { get; }
        public override string Title { get; }
        public override bool CanMove(JetBrains.ReSharper.Feature.Services.RearrangeCode.Direction direction) { }
        protected abstract System.Collections.Generic.IEnumerable<TElem> GetSiblings();
        public abstract class TypeBase<TElem> : JetBrains.ReSharper.Feature.Services.RearrangeCode.RearrangeableSingleElementBase<TElem>.TypeBase<TElem>
            where TElem :  class, JetBrains.ReSharper.Psi.Tree.ITreeNode { }
        public abstract class TypeBase<TElem, TSelElem> : JetBrains.ReSharper.Feature.Services.RearrangeCode.IRearrangeableElementType
            where TElem :  class, JetBrains.ReSharper.Psi.Tree.ITreeNode
            where TSelElem :  class, JetBrains.ReSharper.Psi.Tree.ITreeNode
        {
            public JetBrains.ReSharper.Feature.Services.RearrangeCode.IRearrangeable CreateElement(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
            protected abstract JetBrains.ReSharper.Feature.Services.RearrangeCode.IRearrangeable CreateElement([JetBrains.Annotations.NotNullAttribute()] TSelElem element);
            protected virtual TSelElem GetSelectedElement(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        }
    }
}
namespace JetBrains.ReSharper.Feature.Services.Refactorings
{
    
    [JetBrains.Application.Settings.SettingsKeyAttribute(typeof(JetBrains.ReSharper.Settings.CodeStyleSettings), "“Introduce Local Variable” refactoring settings regarding the use of the “var” ke" +
        "yword rather than explicit type")]
    public class IntroduceVariableUseVarSettings
    {
        [JetBrains.Application.Settings.SettingsEntryAttribute(false, "Introduce variables with “var” type when the type is NOT evident from the assigne" +
            "d value")]
        public bool UseVarForIntroduceVariableRefactoring;
        [JetBrains.Application.Settings.SettingsEntryAttribute(true, "Introduce variables with “var” type when the type is evident from the assigned va" +
            "lue (e.g. new clause)")]
        public bool UseVarForIntroduceVariableRefactoringEvident;
    }
    public class ReplaceInfo
    {
        public ReplaceInfo([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotExpression typeExpression, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.DocumentModel.IRangeMarker typeRangeMarker, JetBrains.ReSharper.Psi.Tree.ITreeNode[] nameElements, JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotExpression nameExpression, JetBrains.ReSharper.Psi.Files.IPsiFiles psiFiles) { }
        public JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.HotspotInfo GetNameTemplateFieldInfo() { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.HotspotInfo GetTypeTemplateFieldInfo() { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.Resources
{
    
    [JetBrains.Application.ShellComponentAttribute(JetBrains.Application.Sharing.Common, JetBrains.Application.Lifecycle.DemandReclaimable, JetBrains.Application.Creation.AnyThread, JetBrains.Application.Access.AnyThread)]
    public class IconsForIconThemeSelectionSamplePsiServices : JetBrains.UI.Icons.Settings.IIconsForIconThemeSelectionSample { }
    public sealed class ServicesThemedIcons
    {
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Feature.Services;component/resources/ServicesThemedIcons/Them" +
            "edIcons.Services.Generated.Xaml", 7, "FileStorage")]
        public sealed class FileStorage : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Feature.Services;component/resources/ServicesThemedIcons/Them" +
            "edIcons.Services.Generated.Xaml", 4, "FileTemplate")]
        public sealed class FileTemplate : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Feature.Services;component/resources/ServicesThemedIcons/Them" +
            "edIcons.Services.Generated.Xaml", 5, "LiveTemplate")]
        public sealed class LiveTemplate : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Feature.Services;component/resources/ServicesThemedIcons/Them" +
            "edIcons.Services.Generated.Xaml", 1, "PersonalSolutionTemplates")]
        public sealed class PersonalSolutionTemplates : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Feature.Services;component/resources/ServicesThemedIcons/Them" +
            "edIcons.Services.Generated.Xaml", 6, "PredefinedTemplates")]
        public sealed class PredefinedTemplates : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Feature.Services;component/resources/ServicesThemedIcons/Them" +
            "edIcons.Services.Generated.Xaml", 0, "ScopeGlobal")]
        public sealed class ScopeGlobal : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Feature.Services;component/resources/ServicesThemedIcons/Them" +
            "edIcons.Services.Generated.Xaml", 2, "SharedSolutionTemplates")]
        public sealed class SharedSolutionTemplates : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Feature.Services;component/resources/ServicesThemedIcons/Them" +
            "edIcons.Services.Generated.Xaml", 3, "SurroundTemplate")]
        public sealed class SurroundTemplate : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
    }
}
namespace JetBrains.ReSharper.Feature.Services.SearchAndNavigation
{
    
    public class static SearchAndNavigationOptions
    {
        public static readonly System.Linq.Expressions.Expression<System.Func<JetBrains.ReSharper.Feature.Services.SearchAndNavigation.SearchAndNavigationSettings, bool>> AutoExpandResultsExpression;
        public static readonly System.Linq.Expressions.Expression<System.Func<JetBrains.ReSharper.Feature.Services.SearchAndNavigation.SearchAndNavigationSettings, int>> DefaultOccurencesGroupingIndexExpression;
        public static readonly System.Linq.Expressions.Expression<System.Func<JetBrains.ReSharper.Feature.Services.SearchAndNavigation.SearchAndNavigationSettings, bool>> EnableGotoEverything;
        public static readonly System.Linq.Expressions.Expression<System.Func<JetBrains.ReSharper.Feature.Services.SearchAndNavigation.SearchAndNavigationSettings, bool>> GotoSingleHierarchyItemImmediatelyExpression;
        public static readonly System.Linq.Expressions.Expression<System.Func<JetBrains.ReSharper.Feature.Services.SearchAndNavigation.SearchAndNavigationSettings, bool>> GotoSingleUsageImmediatelyExpression;
        public static readonly System.Linq.Expressions.Expression<System.Func<JetBrains.ReSharper.Feature.Services.SearchAndNavigation.SearchAndNavigationSettings, bool>> MergeOccurencesExpression;
        public static readonly System.Linq.Expressions.Expression<System.Func<JetBrains.ReSharper.Feature.Services.SearchAndNavigation.SearchAndNavigationSettings, bool>> NavigateByControlClickExpression;
    }
    [JetBrains.Application.Settings.SettingsKeyAttribute(typeof(JetBrains.Application.Settings.EnvironmentSettings), "Search and navigation settings")]
    public class SearchAndNavigationSettings
    {
        [JetBrains.Application.Settings.SettingsEntryAttribute(false, "Whether search results trees and similar trees should be expanded by default")]
        public bool AutoExpandResults;
        [JetBrains.Application.Settings.SettingsEntryAttribute(12, "Default grouping for occurrences")]
        public int DefaultOccurencesGroupingIndex;
        [JetBrains.Application.Settings.SettingsEntryAttribute(true, "Enable \'Go to Everything\'")]
        public bool EnableGotoEverything;
        [JetBrains.Application.Settings.SettingsEntryAttribute(true, "Whether a single item in hierarchy lists should be executed immediately")]
        public bool GotoSingleHierarchyItemImmediately;
        [JetBrains.Application.Settings.SettingsEntryAttribute(true, "Whether a single item in usage lists should be executed immediately")]
        public bool GotoSingleUsageImmediately;
        [JetBrains.Application.Settings.SettingsEntryAttribute(false, "Whether to merge occurrences on a single line")]
        public bool MergeOccurences;
        [JetBrains.Application.Settings.SettingsEntryAttribute(true, "Whether navigation is invoked with Ctrl+Click")]
        public bool NavigateByControlClick;
    }
    [JetBrains.Application.Configuration.Upgrade.GlobalSettingsUpgraderAttribute()]
    public class SearchAndNavigationSettingsUpgrader : JetBrains.Application.Configuration.SettingTablesUpgrader
    {
        public SearchAndNavigationSettingsUpgrader(JetBrains.Application.Env.RunsProducts.ProductConfigurations productConfigurations) { }
        protected override void DoUpgrade(JetBrains.Application.Configuration.IComponentSettingsProvider legacySettingsProvider, JetBrains.Application.Settings.IContextBoundSettingsStore boundSettingsStore, JetBrains.DataFlow.Lifetime upgradeLifetime, JetBrains.Application.Configuration.SettingsTableBase workspaceSettingsTable, JetBrains.Application.Configuration.SettingsTableBase globalSettingsTable) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.SelectEmbracingConstruct
{
    
    public abstract class DotSelection<TFile> : JetBrains.ReSharper.Feature.Services.SelectEmbracingConstruct.SelectedRangeBase<TFile>
        where TFile : JetBrains.ReSharper.Psi.Tree.IFile
    {
        protected readonly bool SelectBetterToken;
        protected readonly bool UseCamelHumps;
        protected DotSelection(TFile fileNode, JetBrains.ReSharper.Psi.TreeOffset offset, bool selectBetterToken, bool useCamelHumps) { }
        public override JetBrains.ReSharper.Feature.Services.SelectEmbracingConstruct.ISelectedRange Parent { get; }
        protected abstract JetBrains.ReSharper.Feature.Services.SelectEmbracingConstruct.ISelectedRange CreateTokenPartSelection(JetBrains.ReSharper.Psi.Tree.ITokenNode tokenNode, JetBrains.ReSharper.Psi.TreeTextRange treeTextRange);
        protected abstract JetBrains.ReSharper.Feature.Services.SelectEmbracingConstruct.ISelectedRange CreateTreeNodeSelection(JetBrains.ReSharper.Psi.Tree.ITokenNode tokenNode);
        protected abstract JetBrains.ReSharper.Feature.Services.SelectEmbracingConstruct.ISelectedRange GetParentInternal(JetBrains.ReSharper.Psi.Tree.ITokenNode tokenNode);
        protected abstract bool IsLiteralToken(JetBrains.ReSharper.Psi.Tree.ITokenNode token);
        protected abstract bool IsNewLineToken(JetBrains.ReSharper.Psi.Tree.ITokenNode token);
        protected virtual bool IsPrevTokenBetter(JetBrains.ReSharper.Psi.Tree.ITokenNode prevToken, JetBrains.ReSharper.Psi.Tree.ITokenNode tokenNode) { }
        protected abstract bool IsSpaceToken(JetBrains.ReSharper.Psi.Tree.ITokenNode token);
        protected abstract bool IsWordToken(JetBrains.ReSharper.Psi.Tree.ITokenNode token);
    }
    [System.FlagsAttribute()]
    public enum ExtendToTheWholeLinePolicy
    {
        DO_NOT_EXTEND = 0,
        EXTEND_LEFT_SPACES = 1,
        EXTEND_RIGHT_SPACES = 2,
        EXTEND_IF_ALL_SPACES_AROUND = 3,
        EXTEND_TAIL_EVEN_IF_NO_SPACES_BEFORE = 7,
    }
    public interface ISelectedRange
    {
        JetBrains.ReSharper.Feature.Services.SelectEmbracingConstruct.ExtendToTheWholeLinePolicy ExtendToWholeLine { get; }
        JetBrains.ReSharper.Feature.Services.SelectEmbracingConstruct.ISelectedRange Parent { get; }
        JetBrains.DocumentModel.DocumentRange Range { get; }
    }
    public interface ISelectedTreeRange : JetBrains.ReSharper.Feature.Services.SelectEmbracingConstruct.ISelectedRange
    {
        JetBrains.ReSharper.Psi.TreeTextRange TreeRange { get; }
    }
    public interface ISelectEmbracingConstructProvider
    {
        JetBrains.ReSharper.Feature.Services.SelectEmbracingConstruct.ISelectedRange GetSelectedRange(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, JetBrains.DocumentModel.DocumentRange documentRange);
        bool IsAvailable(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile);
    }
    public class NestedPsiWrapperSelection<TFile, TNestedFile> : JetBrains.ReSharper.Feature.Services.SelectEmbracingConstruct.ISelectedRange, JetBrains.ReSharper.Feature.Services.SelectEmbracingConstruct.ISelectedTreeRange
        where TFile : JetBrains.ReSharper.Psi.Tree.IFile
        where TNestedFile : JetBrains.ReSharper.Psi.Tree.IFile
    {
        public NestedPsiWrapperSelection(TFile fileNode, JetBrains.ReSharper.Psi.Tree.ITreeNode psiContainer, TNestedFile nestedPsiFile, JetBrains.ReSharper.Feature.Services.SelectEmbracingConstruct.ISelectedRange nestedSelectedRange, System.Func<TFile, JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Feature.Services.SelectEmbracingConstruct.ISelectedRange> createTreeNodeSelection) { }
        public JetBrains.ReSharper.Feature.Services.SelectEmbracingConstruct.ExtendToTheWholeLinePolicy ExtendToWholeLine { get; }
        public JetBrains.ReSharper.Feature.Services.SelectEmbracingConstruct.ISelectedRange Parent { get; }
        public JetBrains.DocumentModel.DocumentRange Range { get; }
        public JetBrains.ReSharper.Psi.TreeTextRange TreeRange { get; }
    }
    public abstract class SelectedRangeBase<TFile> : JetBrains.ReSharper.Feature.Services.SelectEmbracingConstruct.ISelectedRange
        where TFile : JetBrains.ReSharper.Psi.Tree.IFile
    {
        protected SelectedRangeBase([JetBrains.Annotations.NotNullAttribute()] TFile fileNode, JetBrains.DocumentModel.DocumentRange documentRange) { }
        public virtual JetBrains.ReSharper.Feature.Services.SelectEmbracingConstruct.ExtendToTheWholeLinePolicy ExtendToWholeLine { get; }
        protected TFile FileNode { get; }
        public abstract JetBrains.ReSharper.Feature.Services.SelectEmbracingConstruct.ISelectedRange Parent { get; }
        public JetBrains.DocumentModel.DocumentRange Range { get; }
    }
    public class static SelectEmbracingConstructAlgorithm
    {
        public static JetBrains.Util.TextRange Execute(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, JetBrains.DocumentModel.DocumentRange documentRange, JetBrains.ReSharper.Feature.Services.SelectEmbracingConstruct.ISelectEmbracingConstructProvider provider) { }
        public static JetBrains.DocumentModel.DocumentRange ExtendSelectionToWholeLines(JetBrains.DocumentModel.DocumentRange documentRange, JetBrains.ReSharper.Feature.Services.SelectEmbracingConstruct.ExtendToTheWholeLinePolicy extensionPolicy) { }
    }
    public class static SelectEmbracingConstructUtil
    {
        public static bool NewNodesBetterThenOldNodes([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode newFirst, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode newLast, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode first, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode last) { }
        public static JetBrains.Util.Pair<JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode> TryFindAllNonWhitespaceChildren([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode parent, System.Func<JetBrains.ReSharper.Psi.Tree.ITreeNode, bool> isWhitespace) { }
        public static JetBrains.Util.Pair<JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode> TryFindAllSiblings([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode first, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode last, System.Func<JetBrains.ReSharper.Psi.Tree.ITreeNode, bool> isExpectedNode, System.Func<JetBrains.ReSharper.Psi.Tree.ITreeNode, bool> isDelimiter, System.Func<JetBrains.ReSharper.Psi.Tree.ITreeNode, bool> isWhitespace) { }
        public static JetBrains.Util.Pair<JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode> TryFindCommentsRange<TCommentNode>(JetBrains.ReSharper.Psi.Tree.ITreeNode comment, System.Func<JetBrains.ReSharper.Psi.Tree.ITreeNode, bool> isWhitespace, System.Func<JetBrains.ReSharper.Psi.Tree.ITreeNode, bool> isNewLine) { }
        public static JetBrains.Util.Pair<JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode> TryFindRangeInsideBraces([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode lBrace, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode rBrace, System.Func<JetBrains.ReSharper.Psi.Tree.ITreeNode, bool> isWhitespace) { }
        public static JetBrains.Util.Pair<JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode> TryFindRangeSeparatedByEmptyLines<TCommentNode>(JetBrains.ReSharper.Psi.Tree.ITreeNode first, JetBrains.ReSharper.Psi.Tree.ITreeNode last, System.Func<JetBrains.ReSharper.Psi.Tree.ITreeNode, bool> isExpectedNode, System.Func<JetBrains.ReSharper.Psi.Tree.ITreeNode, bool> isExpectedSeparator, System.Func<JetBrains.ReSharper.Psi.Tree.ITreeNode, bool> isWhitespace, System.Func<JetBrains.ReSharper.Psi.Tree.ITreeNode, bool> isNewLine) { }
    }
    public abstract class TokenPartSelection<TFile> : JetBrains.ReSharper.Feature.Services.SelectEmbracingConstruct.SelectedRangeBase<TFile>, JetBrains.ReSharper.Feature.Services.SelectEmbracingConstruct.ISelectedRange, JetBrains.ReSharper.Feature.Services.SelectEmbracingConstruct.ISelectedTreeRange
        where TFile : JetBrains.ReSharper.Psi.Tree.IFile
    {
        protected TokenPartSelection(TFile fileNode, JetBrains.ReSharper.Psi.TreeTextRange treeTextRange, JetBrains.ReSharper.Psi.Tree.ITokenNode token) { }
        public override JetBrains.ReSharper.Feature.Services.SelectEmbracingConstruct.ExtendToTheWholeLinePolicy ExtendToWholeLine { get; }
        public JetBrains.ReSharper.Psi.Tree.ITokenNode Token { get; }
        public JetBrains.ReSharper.Psi.TreeTextRange TreeRange { get; }
        public static JetBrains.ReSharper.Psi.TreeTextRange GetLocalParent(string text, JetBrains.ReSharper.Psi.TreeTextRange range) { }
    }
    public abstract class TreeNodeSelection<TFile> : JetBrains.ReSharper.Feature.Services.SelectEmbracingConstruct.SelectedRangeBase<TFile>, JetBrains.ReSharper.Feature.Services.SelectEmbracingConstruct.ISelectedRange, JetBrains.ReSharper.Feature.Services.SelectEmbracingConstruct.ISelectedTreeRange
        where TFile : JetBrains.ReSharper.Psi.Tree.IFile
    {
        protected TreeNodeSelection(TFile fileNode, JetBrains.ReSharper.Psi.Tree.ITreeNode node) { }
        protected JetBrains.ReSharper.Psi.Tree.ITreeNode TreeNode { get; }
        public JetBrains.ReSharper.Psi.TreeTextRange TreeRange { get; }
    }
    public abstract class TreeRangeSelection<TFile> : JetBrains.ReSharper.Feature.Services.SelectEmbracingConstruct.SelectedRangeBase<TFile>, JetBrains.ReSharper.Feature.Services.SelectEmbracingConstruct.ISelectedRange, JetBrains.ReSharper.Feature.Services.SelectEmbracingConstruct.ISelectedTreeRange
        where TFile : JetBrains.ReSharper.Psi.Tree.IFile
    {
        protected TreeRangeSelection(TFile fileNode, JetBrains.ReSharper.Psi.Tree.ITreeNode first, JetBrains.ReSharper.Psi.Tree.ITreeNode last) { }
        protected JetBrains.ReSharper.Psi.Tree.ITreeNode FirstNode { get; }
        protected JetBrains.ReSharper.Psi.Tree.ITreeNode LastNode { get; }
        public JetBrains.ReSharper.Psi.TreeTextRange TreeRange { get; }
    }
}
namespace JetBrains.ReSharper.Feature.Services.src.LiveTemplates.FileTemplates
{
    
    [JetBrains.UI.Wpf.ViewAttribute(JetBrains.UI.Wpf.ViewKind.Wpf)]
    public class RelativeLocationView : System.Windows.Controls.Grid, JetBrains.UI.Wpf.IView, JetBrains.UI.Wpf.IView<JetBrains.ReSharper.Feature.Services.LiveTemplates.FileTemplates.CustomLocationAutomation>, System.Windows.Markup.IComponentConnector
    {
        public RelativeLocationView() { }
        public void InitializeComponent() { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.SymbolIcons
{
    
    [JetBrains.Application.Settings.SettingsKeyAttribute(typeof(JetBrains.UI.Icons.Settings.ThemedIconSettings), "Controls theme selection for source code symbol icons.")]
    public class PsiSymbolIconSettings
    {
        [JetBrains.Application.Settings.SettingsEntryAttribute(0, "Selects the icon theme to use when rendering source code symbol icons.")]
        public JetBrains.ReSharper.Feature.Services.SymbolIcons.PsiSymbolIconThemeSelection PsiSymbolIconThemeSelection;
    }
    public class static PsiSymbolIconThemeAspect
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public static readonly JetBrains.UI.Icons.IconThemeAspect SymbolsIdea;
        [JetBrains.Annotations.NotNullAttribute()]
        public static readonly JetBrains.UI.Icons.IconThemeAspect SymbolsVs08;
        [JetBrains.Annotations.NotNullAttribute()]
        public static readonly JetBrains.UI.Icons.IconThemeAspect SymbolsVs11Color;
        [JetBrains.Annotations.NotNullAttribute()]
        public static readonly JetBrains.UI.Icons.IconThemeAspect SymbolsVs11Gray;
        [JetBrains.Annotations.NotNullAttribute()]
        public static readonly JetBrains.UI.Icons.IconThemeAspect SymbolsVs11GrayDark;
        public class static AspectListsForFallback
        {
            public static readonly JetBrains.UI.Icons.IconThemeAspect[] SymbolsIdea_WithFallback;
            public static readonly JetBrains.UI.Icons.IconThemeAspect[] SymbolsVs08_WithFallback;
            public static readonly JetBrains.UI.Icons.IconThemeAspect[] SymbolsVs11Color_WithFallback;
            public static readonly JetBrains.UI.Icons.IconThemeAspect[] SymbolsVs11Gray_WithFallback;
            public static readonly JetBrains.UI.Icons.IconThemeAspect[] SymbolsVs11GrayDark_WithFallback;
        }
        public class static Constants
        {
            public static readonly string AspectName;
            public static readonly double AspectPriority;
        }
    }
    public enum PsiSymbolIconThemeSelection
    {
        Automatic = 0,
        SymbolsVs08 = 1,
        SymbolsIdea = 2,
        SymbolsVs11Gray = 3,
        SymbolsVs11Color = 4,
        SymbolsVs11GrayDark = 5,
    }
    public class PsiSymbolIconThemeSelectionControlAutomation : JetBrains.UI.Controls.StackPanelAutomation
    {
        public PsiSymbolIconThemeSelectionControlAutomation(JetBrains.DataFlow.Lifetime lifetime, JetBrains.UI.Options.OptionsSettingsSmartContext settings, JetBrains.Threading.IThreading threading, JetBrains.UI.Icons.ThemedIconManager.IconIdOwnersMap iconowners, JetBrains.Util.ILogger logger) { }
        public PsiSymbolIconThemeSelectionControlAutomation(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.Settings.IContextBoundSettingsStoreLive settings, JetBrains.Threading.IThreading threading, JetBrains.UI.Icons.ThemedIconManager.IconIdOwnersMap iconowners, JetBrains.Util.ILogger logger, int dummyToHideCtorFromContainer) { }
    }
    [JetBrains.Application.ShellComponentAttribute(JetBrains.Application.Sharing.Common, JetBrains.Application.Lifecycle.DemandReclaimable, JetBrains.Application.Creation.PrimaryThread, JetBrains.Application.Access.PrimaryThread)]
    public class PsiSymbolIconThemeSettingsLoader : JetBrains.UI.Icons.Settings.IThemedIconThemeOracle
    {
        public PsiSymbolIconThemeSettingsLoader([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.Lifetime lifetime, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Settings.ISettingsStore store, JetBrains.DataFlow.IProperty<JetBrains.UI.Icons.IconThemeAspect[]> propAutoSelectOverride) { }
        public JetBrains.DataFlow.IProperty<JetBrains.UI.Icons.IconThemeAspect[]> SuggestedIconTheme { get; }
    }
}
namespace JetBrains.ReSharper.Feature.Services.Tips
{
    
    public class static Language
    {
        public const string ASP = "asp";
        public const string CSHARP = "c#";
        public const string VB = "vb";
        public static int LanguageToOrder(string language) { }
    }
    public abstract class TipsManager
    {
        public static JetBrains.ReSharper.Feature.Services.Tips.TipsManager Instance { get; }
        public abstract void ActivityIsUsed(string activityId, [JetBrains.Annotations.CanBeNullAttribute()] string language);
        public abstract void DisableTips();
        public abstract void FeatureIsUsed(string featureId, JetBrains.DocumentModel.IDocument document, JetBrains.ProjectModel.ISolution solution);
        public abstract void FeatureIsUsed(string featureId, JetBrains.Application.DataContext.IDataContext context);
        public abstract void FeatureIsUsed(string featureId, [JetBrains.Annotations.CanBeNullAttribute()] string language);
        public abstract void ShowTips(bool onStartup);
    }
    [JetBrains.Application.Settings.SettingsKeyAttribute(typeof(JetBrains.UI.UserInterfaceSettings), "TipsManager settings")]
    public class TipsManagerSettings
    {
        [JetBrains.Application.Settings.SettingsEntryAttribute(true, "Show tips on startup")]
        public bool ShowTipsOnStartup;
    }
}
namespace JetBrains.ReSharper.Feature.Services.TodoItems
{
    
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.KnownLanguage))]
    public class DefaultTodoContentsProvider : JetBrains.ReSharper.Feature.Services.TodoItems.ITodoContentsProvider
    {
        public virtual System.Nullable<JetBrains.Util.TextRange> GetTokenContentsRange(string documentText, JetBrains.Util.TextRange tokenRange, JetBrains.ReSharper.Psi.Parsing.TokenNodeType tokenType) { }
    }
    public interface ITodoContentsProvider
    {
        System.Nullable<JetBrains.Util.TextRange> GetTokenContentsRange(string documentText, JetBrains.Util.TextRange tokenRange, JetBrains.ReSharper.Psi.Parsing.TokenNodeType tokenType);
    }
    public interface ITodoItemFactory
    {
        JetBrains.ReSharper.Feature.Services.TodoItems.TodoItem CreateTodoItem(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, string name, string text, JetBrains.Util.TextRange textRange, JetBrains.ReSharper.Feature.Services.TodoItems.TodoPresentationStyle style, JetBrains.Util.TextRange tagRange, JetBrains.ReSharper.Feature.Services.TodoItems.TodoItemBinding itemBinding, string clrName, string languageName, bool caseSensitive);
    }
    public interface ITodoManagerFileService
    {
        void EnumerateTokens([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.IFile file, System.Collections.Generic.List<JetBrains.ReSharper.Feature.Services.TodoItems.TodoItem> items, JetBrains.Util.LocalList<JetBrains.ReSharper.Feature.Services.TodoItems.ITodoContentsProvider> providers, JetBrains.Application.SeldomInterruptChecker checker, JetBrains.ReSharper.Feature.Services.TodoItems.ITodoMatcher[] matchers, JetBrains.ReSharper.Psi.Caches.ISymbolCache symbolCache);
    }
    public interface ITodoMatch
    {
        int Offset { get; }
        JetBrains.ReSharper.Feature.Services.TodoItems.TodoPresentationStyle Style { get; set; }
        JetBrains.Util.TextRange TagRange { get; set; }
        string Text { get; }
    }
    public interface ITodoMatcher
    {
        JetBrains.Application.Settings.GuidIndex Id { get; }
        string Name { get; }
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.TodoItems.ITodoMatch> GetMatches(string text, JetBrains.Util.TextRange matchingRange);
        bool ShouldProcessToken(JetBrains.ReSharper.Psi.Parsing.TokenNodeType type);
    }
    public class RegexMatch : JetBrains.ReSharper.Feature.Services.TodoItems.ITodoMatch
    {
        public RegexMatch(string text, int offset) { }
        public int Offset { get; }
        public JetBrains.ReSharper.Feature.Services.TodoItems.TodoPresentationStyle Style { get; set; }
        public JetBrains.Util.TextRange TagRange { get; set; }
        public string Text { get; }
    }
    [JetBrains.Application.Settings.SettingsKeyAttribute(typeof(JetBrains.UI.UserInterfaceSettings), "To-do grouping settings")]
    public class TodoGroupingSettings
    {
        public static System.Linq.Expressions.Expression<System.Func<JetBrains.ReSharper.Feature.Services.TodoItems.TodoGroupingSettings, int>> DefaultGroupingIndexExpression;
        [JetBrains.Application.Settings.SettingsEntryAttribute(11, "Default grouping for to-do items")]
        public int GroupingIndex;
    }
    public enum TodoIconStyle
    {
        None = 0,
        Edit = 1,
        Error = 2,
        Info = 3,
        Question = 4,
        Warning = 5,
        Low = 5,
        High = 2,
        Normal = 3,
    }
    public class TodoItem
    {
        public TodoItem(JetBrains.ReSharper.Psi.Caches.ISymbolCache symbolCache, JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, string text, JetBrains.Util.TextRange textRange) { }
        public JetBrains.ReSharper.Feature.Services.TodoItems.TodoItemBinding Binding { get; }
        public bool CaseSensitiveBinding { get; }
        public string ClrName { get; }
        public JetBrains.ReSharper.Psi.PsiLanguageType LanguageType { get; set; }
        public string Name { get; set; }
        public JetBrains.ReSharper.Psi.DeclaredElementEnvoy<JetBrains.ReSharper.Psi.INamespace> NamespaceEnvoy { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ProjectModel.IProjectFile ProjectFile { get; }
        public JetBrains.ReSharper.Psi.IPsiSourceFile SourceFile { get; set; }
        public JetBrains.ReSharper.Feature.Services.TodoItems.TodoPresentationStyle Style { get; set; }
        public JetBrains.Util.TextRange TagRange { get; set; }
        public string Text { get; set; }
        public JetBrains.Util.TextRange TextRange { get; set; }
        public JetBrains.ReSharper.Psi.DeclaredElementEnvoy<JetBrains.ReSharper.Psi.ITypeElement> TypeElementEnvoy { get; }
        public JetBrains.DocumentModel.DocumentRange GetDocumentRange() { }
        public string GetPresentableProjectPath() { }
        public override string ToString() { }
    }
    public enum TodoItemBinding
    {
        None = 0,
        Type = 1,
        Namespace = 2,
    }
    [JetBrains.ReSharper.Psi.PsiComponentAttribute()]
    public class TodoManager : JetBrains.Application.Settings.Extentions.ICachedSettingsReader<JetBrains.ReSharper.Feature.Services.TodoItems.ITodoMatcher[]>, JetBrains.ReSharper.Feature.Services.TodoItems.ITodoItemFactory, JetBrains.ReSharper.Psi.Caches.IBackgroundCache, JetBrains.ReSharper.Psi.Caches.ICache, JetBrains.ReSharper.Psi.Caches.IPersistentCache
    {
        public TodoManager(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.Settings.ISettingsStore settings, JetBrains.ProjectModel.Settings.Cache.SettingsCacheManager settingsCacheManager, JetBrains.Application.IShellLocks locks, JetBrains.ReSharper.Psi.Caches.ISymbolCache symbolCache, JetBrains.ReSharper.Feature.Services.TodoItems.TodoPatternStorage patternStorage, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Psi.PsiProjectFileTypeCoordinator projectFileTypeCoordinator, JetBrains.ReSharper.Psi.ILanguages languages, JetBrains.ReSharper.Psi.ILanguageManager languageManager, JetBrains.ReSharper.Psi.Caches.IPersistentIndexManager persistentIndexManager) { }
        public System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.TodoItems.TodoItem> AllItems { get; }
        public System.Collections.Generic.IEnumerable<string> AllNames { get; }
        public System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.IPsiSourceFile> DirtyFiles { get; }
        public int DisplayChangeTimeStamp { get; }
        public bool HasDirtyFiles { get; }
        public JetBrains.Application.Settings.SettingsKey KeyExposed { get; }
        public JetBrains.ProjectModel.ISolution Solution { get; }
        public int StructureChangeTimeStamp { get; }
        public object SyncRoot { get; }
        public event System.Action OnSettingsChanged;
        public event System.Action Updated;
        protected void FireOnUpdated() { }
        public void Flush() { }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Feature.Services.TodoItems.TodoItem> GetItemsForFile(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
        public void Merge(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, object builtPart) { }
        public void MergePersistent(JetBrains.ReSharper.Psi.IPsiSourceFile sf, object buildData) { }
        public void OnPsiChange(JetBrains.ReSharper.Psi.Tree.ITreeNode elementContainingChanges, JetBrains.ReSharper.Psi.PsiChangedElementType type) { }
        protected virtual void OnUpdated() { }
        public JetBrains.ReSharper.Feature.Services.TodoItems.ITodoMatcher[] ReadData(JetBrains.Application.Settings.IContextBoundSettingsStore store) { }
        protected void RescanDirtyFiles() { }
        public void Reset() { }
        public bool UpToDate(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.KnownLanguage))]
    public class TodoManagerFileService : JetBrains.ReSharper.Feature.Services.TodoItems.ITodoManagerFileService
    {
        public virtual void EnumerateTokens(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, JetBrains.ReSharper.Psi.Tree.IFile file, System.Collections.Generic.List<JetBrains.ReSharper.Feature.Services.TodoItems.TodoItem> items, JetBrains.Util.LocalList<JetBrains.ReSharper.Feature.Services.TodoItems.ITodoContentsProvider> providers, JetBrains.Application.SeldomInterruptChecker checker, JetBrains.ReSharper.Feature.Services.TodoItems.ITodoMatcher[] matchers, JetBrains.ReSharper.Psi.Caches.ISymbolCache symbolCache) { }
    }
    [JetBrains.Application.Settings.SettingsIndexedKeyAttribute(typeof(JetBrains.ReSharper.Feature.Services.TodoItems.TodoSettings), "To-do patterns", typeof(JetBrains.Application.Settings.GuidIndex))]
    public class TodoPatternsSettings
    {
        [JetBrains.Application.Settings.SettingsEntryAttribute(false, "Match case sensitively")]
        public bool CaseSensitive;
        [JetBrains.Application.Settings.SettingsEntryAttribute("Black", "Color for matches of the pattern")]
        public System.Drawing.Color Color;
        [JetBrains.Application.Settings.SettingsEntryAttribute(false, "Match in comments")]
        public bool MatchComments;
        [JetBrains.Application.Settings.SettingsEntryAttribute(false, "Match in identifiers")]
        public bool MatchIdentifiers;
        [JetBrains.Application.Settings.SettingsEntryAttribute(false, "Match in strings")]
        public bool MatchStrings;
        [JetBrains.Application.Settings.SettingsEntryAttribute("", "Name of the pattern")]
        public string Name;
        [JetBrains.Application.Settings.SettingsEntryAttribute("", "Regular expression")]
        public string Pattern;
        [JetBrains.Application.Settings.SettingsEntryAttribute(JetBrains.ReSharper.Feature.Services.TodoItems.TodoIconStyle.None, "Custom icon to display for the match")]
        public JetBrains.ReSharper.Feature.Services.TodoItems.TodoIconStyle TodoIconStyle;
        public TodoPatternsSettings() { }
        public bool Equals(JetBrains.ReSharper.Feature.Services.TodoItems.TodoPatternsSettings other) { }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
    }
    [JetBrains.Application.Configuration.Upgrade.GlobalSettingsUpgraderAttribute()]
    public class TodoPatternsSettingsUpgrader : JetBrains.Application.Configuration.Upgrade.IGlobalSettingsUpgrader, JetBrains.Application.Configuration.Upgrade.ISettingsUpgrader
    {
        public void Upgrade(JetBrains.Application.Configuration.IComponentSettingsProvider legacySettingsProvider, JetBrains.Application.Settings.IContextBoundSettingsStore boundSettingsStore, JetBrains.DataFlow.Lifetime upgradeLifetime) { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class TodoPatternStorage
    {
        public TodoPatternStorage(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.Settings.ISettingsStore settingsStore) { }
        public void AdvisePatternsChange(JetBrains.DataFlow.Lifetime lifetime, System.Action action) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.TodoItems.ITodoMatcher> GetMatchersForContext(System.Func<JetBrains.DataFlow.Lifetime, JetBrains.Application.DataContext.DataContexts, JetBrains.Application.DataContext.IDataContext> context) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.TodoItems.ITodoMatcher> GetMatchersForContext(JetBrains.Application.Settings.IContextBoundSettingsStore contextBoundSettingsStore) { }
        public JetBrains.ReSharper.Feature.Services.TodoItems.TodoPresentationStyle GetStyle(System.Drawing.Color color, JetBrains.ReSharper.Feature.Services.TodoItems.TodoIconStyle icon) { }
        public string InternName(string name) { }
        public JetBrains.Util.Pair<bool, int> UpdateHash() { }
        [JetBrains.Application.ShellComponentAttribute()]
        public class TodoPatternStorageDefault : JetBrains.Application.Settings.IHaveDefaultSettingsStream
        {
            public string Name { get; }
            public System.IO.Stream GetDefaultSettingsStream(JetBrains.DataFlow.Lifetime lifetime) { }
        }
    }
    public class TodoPresentationStyle
    {
        public TodoPresentationStyle(System.Drawing.Color color, JetBrains.ReSharper.Feature.Services.TodoItems.TodoIconStyle icon) { }
        public System.Drawing.Color Color { get; }
        public JetBrains.ReSharper.Feature.Services.TodoItems.TodoIconStyle Icon { get; }
        public bool Equals(JetBrains.ReSharper.Feature.Services.TodoItems.TodoPresentationStyle other) { }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
    }
    public class TodoRegexMatcher : JetBrains.ReSharper.Feature.Services.TodoItems.ITodoMatcher
    {
        public TodoRegexMatcher(JetBrains.Application.Settings.GuidIndex id, System.Text.RegularExpressions.Regex regularExpression, JetBrains.ReSharper.Feature.Services.TodoItems.TodoPresentationStyle style, string name) { }
        public JetBrains.Application.Settings.GuidIndex Id { get; }
        public bool MatchComments { get; set; }
        public bool MatchIdentifiers { get; set; }
        public bool MatchStringLiterals { get; set; }
        public string Name { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.TodoItems.ITodoMatch> GetMatches(string input, JetBrains.Util.TextRange range) { }
        public bool ShouldProcessToken(JetBrains.ReSharper.Psi.Parsing.TokenNodeType type) { }
    }
    [JetBrains.Application.Settings.SettingsKeyAttribute(typeof(JetBrains.ReSharper.Settings.PatternsAndTemplatesSettingsKey), "To-do items settings")]
    public class TodoSettings { }
}
namespace JetBrains.ReSharper.Feature.Services.TypeSuggestion
{
    
    public class ExpressionTypeSuggestion
    {
        public JetBrains.ReSharper.Feature.Services.TypeSuggestion.SuggestedConstKinds SuggestedConstKind { get; }
        public JetBrains.ReSharper.Feature.Services.TypeSuggestion.SuggestedTypeKinds SuggestedTypeKind { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ReSharper.Psi.IType Type { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.ReSharper.Feature.Services.TypeSuggestion.ExpressionTypeSuggestion Suggest([JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Tree.IExpression> expressions, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.PsiLanguageType language, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.ITypeConversionRule typeConversionRule) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.KnownLanguage))]
    public class ExpressionTypeSuggestionBase
    {
        public virtual JetBrains.ReSharper.Feature.Services.TypeSuggestion.SuggestedTypeKinds GetTypeKind(JetBrains.ReSharper.Psi.Tree.IExpression expression) { }
    }
    public enum SuggestedConstKinds
    {
        ConstOnly = 0,
        CanBeConst = 1,
        NoConst = 2,
    }
    public enum SuggestedTypeKinds
    {
        VarOnly = 0,
        CanBeVar = 1,
        NoVar = 2,
    }
}
namespace JetBrains.ReSharper.Feature.Services.TypingAssist
{
    
    public class ActionContext : JetBrains.ReSharper.Feature.Services.TypingAssist.IActionContext, JetBrains.TextControl.ITextControlHandlerContext
    {
        public ActionContext(JetBrains.DataFlow.Lifetime lifetime, string actionId, JetBrains.TextControl.ITextControl textControl, JetBrains.ActionManagement.DelegateExecute handler) { }
        public string ActionId { get; }
        public JetBrains.TextControl.ITextControl TextControl { get; }
        public void CallNext() { }
        public JetBrains.Util.EnsureWritableResult EnsureWritable() { }
    }
    public abstract class BracketMatcher
    {
        protected BracketMatcher(System.Collections.Generic.IEnumerable<JetBrains.Util.Pair<JetBrains.ReSharper.Psi.Parsing.TokenNodeType, JetBrains.ReSharper.Psi.Parsing.TokenNodeType>> brackets) { }
        public int Direction(JetBrains.ReSharper.Psi.Parsing.TokenNodeType type) { }
        public bool FindMatchingBracket(JetBrains.ReSharper.Psi.Parsing.CachingLexer cachingLexer) { }
        public bool FindMatchingBracket(JetBrains.ReSharper.Psi.Parsing.CachingLexer cachingLexer, out int pos) { }
        public bool IsStackEmpty() { }
        public bool ProceedStack(JetBrains.ReSharper.Psi.Parsing.TokenNodeType tokenType) { }
    }
    public interface IActionContext : JetBrains.TextControl.ITextControlHandlerContext
    {
        string ActionId { get; }
    }
    public interface ISecondaryTypingAssist { }
    public interface ISecondaryTypingAssistWithBraces : JetBrains.ReSharper.Feature.Services.TypingAssist.ISecondaryTypingAssist
    {
        JetBrains.Util.Pair<JetBrains.ReSharper.Psi.ITreeRange, JetBrains.ReSharper.Psi.ITreeRangePointer> GetRangeToFormatAfterRBrace(JetBrains.TextControl.ITextControl textControl);
    }
    public interface ITypingAssistManager
    {
        void AddActionHandler(JetBrains.DataFlow.Lifetime lifetime, string actionId, JetBrains.ReSharper.Feature.Services.TypingAssist.ITypingHandler typingHandler, System.Func<JetBrains.ReSharper.Feature.Services.TypingAssist.IActionContext, bool> action, System.Predicate<JetBrains.ReSharper.Feature.Services.TypingAssist.IActionContext> checker = null);
        void AddTypingHandler(JetBrains.DataFlow.Lifetime lifetime, char c, JetBrains.ReSharper.Feature.Services.TypingAssist.ITypingHandler typingHandler, System.Func<JetBrains.TextControl.ITypingContext, bool> action, System.Predicate<JetBrains.TextControl.ITypingContext> checker = null);
    }
    public interface ITypingHandler
    {
        bool QuickCheckAvailability(JetBrains.TextControl.ITextControl textControl, JetBrains.ReSharper.Psi.IPsiSourceFile projectFile);
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class SkippingTypingAssist
    {
        public SkippingTypingAssist(JetBrains.DataFlow.Lifetime lifetime, JetBrains.TextControl.ITextControlManager textControlManager, JetBrains.TextControl.Impl.TextControlTypingHandlers textControlTypingHandlers, JetBrains.DocumentManagers.DocumentManager documentManager, JetBrains.Application.ChangeManager changeManager) { }
        public void SetCharsToSkip(JetBrains.DocumentModel.IDocument document, string s) { }
        public bool ShouldSkip(JetBrains.DocumentModel.IDocument document, char c) { }
        public bool SkipIfNeeded(JetBrains.DocumentModel.IDocument document, char c) { }
    }
    public abstract class TypingAssistBase
    {
        public const string SmartBackspaceCommandID = "Smart backspace";
        public const string SmartDeleteCommandID = "Smart delete";
        protected TypingAssistBase(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Settings.ISettingsStore settingsStore, JetBrains.ReSharper.Psi.Services.CachingLexerService cachingLexerService, JetBrains.Application.CommandProcessing.ICommandProcessor commandProcessor, JetBrains.ReSharper.Psi.IPsiServices psiServices) { }
        public JetBrains.Application.CommandProcessing.ICommandProcessor CommandProcessor { get; }
        public JetBrains.ReSharper.Psi.IPsiServices PsiServices { get; }
        public JetBrains.Application.Settings.ISettingsStore SettingsStore { get; }
        public JetBrains.ProjectModel.ISolution Solution { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Psi.Parsing.CachingLexer GetCachingLexer(JetBrains.TextControl.ITextControl textControl) { }
        protected TEntry GetTypingAssistOption<TSettings, TEntry>(JetBrains.TextControl.ITextControl textControl, System.Linq.Expressions.Expression<System.Func<TSettings, TEntry>> expression) { }
        public virtual int LexerToTextControl(JetBrains.TextControl.ITextControl textControl, int offset) { }
        public virtual int TextControlToLexer(JetBrains.TextControl.ITextControl textControl, int offset) { }
    }
    public abstract class TypingAssistForCLikeLanguage<TLanguage, TCodeFormatter> : JetBrains.ReSharper.Feature.Services.TypingAssist.TypingAssistLanguageBase<TLanguage, TCodeFormatter>
        where TLanguage : JetBrains.ReSharper.Psi.PsiLanguageType
        where TCodeFormatter :  class, JetBrains.ReSharper.Psi.CodeStyle.ICodeFormatter
    {
        protected TypingAssistForCLikeLanguage(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Settings.ISettingsStore settingsStore, JetBrains.ReSharper.Psi.Services.CachingLexerService cachingLexerService, JetBrains.Application.CommandProcessing.ICommandProcessor commandProcessor, JetBrains.ReSharper.Psi.IPsiServices psiServices) { }
        protected void DoFormatStatementOnSemicolon(JetBrains.TextControl.ITextControl textControl, System.Predicate<JetBrains.ReSharper.Psi.Tree.ITreeNode> isSuitableParent, System.Func<JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Tree.ITreeNode> getParentToFormat) { }
        protected JetBrains.ReSharper.Psi.ITreeRange FormatIfTypesMatch<TNode>(JetBrains.ReSharper.Psi.Tree.ITreeNode node, System.Func<TNode, JetBrains.ReSharper.Psi.Tree.ITreeNode> getLBrace, System.Func<TNode, JetBrains.ReSharper.Psi.Tree.ITreeNode> getRBrace, System.Func<TNode, JetBrains.ReSharper.Psi.Tree.ITreeNode> getWhatToFormat)
            where TNode :  class, JetBrains.ReSharper.Psi.Tree.ITreeNode { }
        protected abstract bool IsLBrace(JetBrains.TextControl.ITextControl textControl, JetBrains.ReSharper.Psi.Tree.ITreeNode node);
        protected abstract bool IsRBrace(JetBrains.TextControl.ITextControl textControl, JetBrains.ReSharper.Psi.Tree.ITreeNode node);
        protected abstract bool IsSemicolon(JetBrains.TextControl.ITextControl textControl, JetBrains.ReSharper.Psi.Tree.ITreeNode node);
    }
    public abstract class TypingAssistLanguageBase<TLanguage, TCodeFormatter> : JetBrains.ReSharper.Feature.Services.TypingAssist.TypingAssistBase
        where TLanguage : JetBrains.ReSharper.Psi.PsiLanguageType
        where TCodeFormatter :  class, JetBrains.ReSharper.Psi.CodeStyle.ICodeFormatter
    {
        protected TypingAssistLanguageBase(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Settings.ISettingsStore settingsStore, JetBrains.ReSharper.Psi.Services.CachingLexerService cachingLexerService, JetBrains.Application.CommandProcessing.ICommandProcessor commandProcessor, JetBrains.ReSharper.Psi.IPsiServices psiServices) { }
        protected virtual JetBrains.ReSharper.Psi.Tree.IFile CommitPsi(JetBrains.TextControl.ITextControl textControl) { }
        protected void FormatRange(JetBrains.ReSharper.Psi.ITreeRange rangeToFormat, JetBrains.ReSharper.Psi.ITreeRangePointer caretPointer, JetBrains.TextControl.ITextControl textControl) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public TCodeFormatter GetCodeFormatter([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode node) { }
        protected bool IsActionHandlerAvailabile(JetBrains.ReSharper.Feature.Services.TypingAssist.IActionContext context) { }
        protected abstract bool IsSupported(JetBrains.TextControl.ITextControl textControl);
        protected bool IsTypingHandlerAvailable(JetBrains.TextControl.ITypingContext context) { }
        protected bool IsTypingSmartLBraceHandlerAvailable(JetBrains.TextControl.ITypingContext context) { }
        protected bool IsTypingSmartParenthesisHandlerAvailable(JetBrains.TextControl.ITypingContext context) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class TypingAssistManager : JetBrains.ReSharper.Feature.Services.TypingAssist.ITypingAssistManager
    {
        public TypingAssistManager(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControlManager textControlManager, JetBrains.ActionManagement.IActionManager actionManager) { }
        public void Act(JetBrains.TextControl.ITextControl textControl, string actionId, JetBrains.ActionManagement.DelegateExecute nextExecute) { }
        public void AddActionHandler(JetBrains.DataFlow.Lifetime lifetime, string actionId, JetBrains.ReSharper.Feature.Services.TypingAssist.ITypingHandler typingHandler, System.Func<JetBrains.ReSharper.Feature.Services.TypingAssist.IActionContext, bool> action, System.Predicate<JetBrains.ReSharper.Feature.Services.TypingAssist.IActionContext> checker = null) { }
        public void AddTypingHandler(JetBrains.DataFlow.Lifetime lifetime, char c, JetBrains.ReSharper.Feature.Services.TypingAssist.ITypingHandler typingHandler, System.Func<JetBrains.TextControl.ITypingContext, bool> action, System.Predicate<JetBrains.TextControl.ITypingContext> checker = null) { }
    }
    public class static TypingAssistUtils
    {
        public static JetBrains.ReSharper.Psi.Tree.IFile CommitPsi<TLanguage>(this JetBrains.ReSharper.Feature.Services.TypingAssist.TypingAssistBase typingAssist, JetBrains.TextControl.ITextControl textControl)
            where TLanguage : JetBrains.ReSharper.Psi.PsiLanguageType { }
        public static JetBrains.ReSharper.Psi.ITreeRangePointer CreateRangePointer(this JetBrains.ReSharper.Psi.Tree.ITokenNode tokenNode) { }
        public static bool HandleDeleteNewLine(this JetBrains.ReSharper.Feature.Services.TypingAssist.TypingAssistBase typingAssist, JetBrains.TextControl.ITextControl textControl, System.Func<JetBrains.ReSharper.Psi.Parsing.CachingLexer, bool> isNewLine) { }
        public static bool IsSupported<TProjectFileType>(this JetBrains.ReSharper.Feature.Services.TypingAssist.TypingAssistBase typingAssist, JetBrains.TextControl.ITextControl textControl)
            where TProjectFileType : JetBrains.ProjectModel.ProjectFileType { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.Util
{
    
    public class static ActionUtil
    {
        public static bool CommitAndWaitForCaches([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.IPsiServices psiServices, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ActionManagement.IActionHandler actionhandler) { }
        public static bool ExecuteWithCachesReady([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.IPsiServices psiServices, [JetBrains.Annotations.NotNullAttribute()] string title, [JetBrains.Annotations.NotNullAttribute()] System.Action action) { }
        public static bool ShowIfPopupWindowContext([JetBrains.Annotations.NotNullAttribute()] this JetBrains.UI.Tooltips.ITooltipManager tooltipman, [JetBrains.Annotations.NotNullAttribute()] string message, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.DataContext.IDataContext context) { }
        public static JetBrains.ReSharper.Psi.Files.CommitCookie WaitForCaches([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Files.CommitCookie cookie, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ActionManagement.IActionHandler actionhandler) { }
    }
    public class static AddNewItemUtil
    {
        public static JetBrains.ProjectModel.IProjectFile AddFile(JetBrains.ProjectModel.IProjectFolder parentFolder, string fileName, string fileText = "", System.Action<JetBrains.ProjectModel.IProjectFile> setFileProperties = null) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ProjectModel.IProjectFolder GetOrCreateProjectFolder([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ProjectModel.IProjectFolder baseFolder, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Util.FileSystemPath path, JetBrains.ProjectModel.IProjectModelTransactionCookie cookie = null) { }
        public static string SuggestDerivedName(JetBrains.ProjectModel.IProjectFolder projectFolder, string baseFileName) { }
    }
    public class static BaseClassUtil
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Resolve.IReference> GetBaseDeclarationsReferences([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ReSharper.Psi.Tree.ITypeDeclaration declaration) { }
    }
    public class static CodeInsightUtil
    {
        public static System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Tree.ITreeNode> EnumerateElementsUp(JetBrains.TextControl.ITextControl textControl, JetBrains.ProjectModel.ISolution solution) { }
        public static string GetName([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Naming.NamingManager namingManager, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IType type, JetBrains.ReSharper.Psi.Naming.Impl.NameRoot root, bool longerNamesFirst, JetBrains.ReSharper.Psi.Naming.Settings.NamedElementKinds namingEntityKind, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode context, [JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.List<string> alreadySuggested, JetBrains.ReSharper.Psi.Naming.Impl.ScopeKind scopeKind) { }
        public static bool IsBrowsable(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, bool showNever, bool showAdvanced) { }
        public static bool IsObsolete(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Collections.Generic.IEnumerable<string> SuggestNames([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.IFile file, JetBrains.ReSharper.Psi.Naming.Settings.NamedElementKinds namingEntityKind, [JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IType> types, [JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Naming.Impl.NameRoot> defaultNames) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Collections.Generic.IEnumerable<string> SuggestNames([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.IFile file, JetBrains.ReSharper.Psi.TreeOffset offset, JetBrains.ReSharper.Psi.Naming.Settings.NamedElementKinds namingEntityKind, [JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IType> types, [JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Naming.Impl.NameRoot> defaultRoots, bool longerNamesFirst) { }
    }
    public class CustomColorMatrix
    {
        public float[][] Matrix { set; }
        public System.Drawing.Bitmap Apply(System.Drawing.Image originalImage) { }
    }
    [JetBrains.ProjectModel.ProjectFileTypeAttribute(typeof(JetBrains.ProjectModel.KnownProjectFileType))]
    public class DefaultFileTypeSpecificOwnerUtil : JetBrains.ReSharper.Feature.Services.Util.IFileTypeSpecificOwnerUtil
    {
        public virtual bool CanContainSeveralClasses(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
        public virtual bool CanDeclarationBeOverloaded(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration) { }
        public virtual bool CanHaveConstructors(JetBrains.ReSharper.Psi.Tree.ITypeDeclaration typeElement) { }
        public virtual bool CanImplementInterfaces(JetBrains.ReSharper.Psi.Tree.ITypeDeclaration typeElement) { }
        public virtual JetBrains.ReSharper.Psi.ITypeElement GetContainingTypeForReference(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public virtual JetBrains.DocumentModel.DocumentRange GetDocumentRangeForPartiallyUnmappedNode(JetBrains.ReSharper.Psi.Tree.ITreeNode node) { }
        public virtual JetBrains.Util.FileSystemPath GetFolderForElementsMovedToExternalScope(JetBrains.ProjectModel.IProjectFile projectFile, string @namespace, JetBrains.ReSharper.Psi.Tree.ITreeNode referenceNode) { }
        public virtual System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.IClrTypeName> GetMvcViewWithModelBaseTypes() { }
        public virtual string GetNamespaceForElementsMovedToExternalScope(JetBrains.ReSharper.Psi.Tree.ITypeDeclaration typeDeclaration, JetBrains.ReSharper.Psi.Tree.ITreeNode referenceNode) { }
        public virtual string GetPrettyName(JetBrains.ReSharper.Psi.Tree.ITypeDeclaration element, bool mustBeIdentifier) { }
        public virtual System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Tree.ITypeDeclaration> GetRelatedAndFilterHidden(JetBrains.ReSharper.Psi.Tree.ITypeDeclaration declaration) { }
        public virtual System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Tree.IDeclaration> GetRelatedDeclarations(JetBrains.ReSharper.Psi.Tree.ITypeDeclaration typeDeclaration) { }
        public virtual bool HasUglyName(JetBrains.ReSharper.Psi.Tree.ITypeDeclaration declaration) { }
        public virtual bool IsCodeBehindClass(JetBrains.ReSharper.Psi.Tree.ITypeDeclaration declaration) { }
        public virtual bool IsHidden(JetBrains.ReSharper.Psi.Tree.ITypeDeclaration declaration) { }
        public virtual bool IsOperationPossibleOnUnmappedRange(JetBrains.ReSharper.Psi.Tree.ITreeNode node) { }
        public virtual bool IsOperationPossibleOnUnmappedRange(JetBrains.ReSharper.Psi.ITreeRange range) { }
        public virtual bool IsUserTextDeclaration(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration) { }
        public virtual bool SuperClassCanBeChanged(JetBrains.ReSharper.Psi.Tree.ITypeDeclaration typeElement) { }
        public virtual bool SuperClassNameMustBeFull(JetBrains.ReSharper.Psi.Tree.ITypeDeclaration typeElement) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public sealed class ExternalAnnotationsImporter
    {
        public ExternalAnnotationsImporter(JetBrains.ProjectModel.ISolution solution, JetBrains.ProjectModel.Settings.Store.SolutionSettings solutionSettings) { }
        public bool ImportAnnotation([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode anchor, JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
        public bool PromptAnnotationsImport([JetBrains.Annotations.NotNullAttribute()] string featureSpecificPrompt) { }
    }
    public interface IBaseClassUtil
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Resolve.IReference> GetBaseDeclarationsReferences(JetBrains.ReSharper.Psi.Tree.ITypeDeclaration declaration);
    }
    public interface IEventHandlerReferenceAnalyzer
    {
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.IType TryGetSenderType(JetBrains.ReSharper.Psi.Resolve.IReference reference);
    }
    public interface IImplicitReference : JetBrains.ReSharper.Feature.Services.Util.IPrefferedReference, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.Util.IUserDataHolder { }
    public class static ImageUtil
    {
        public static System.Drawing.Image AdjustBrightness(this System.Drawing.Image image, int value) { }
        public static System.Drawing.Bitmap AdjustContrast(this System.Drawing.Image image, float value) { }
        public static System.Drawing.Image MakeGrayscale(this System.Drawing.Image original) { }
    }
    public interface ISelectionStorer
    {
        void RestoreSelection();
    }
    public interface ITypeValidator
    {
        bool IsValidExpression(string expr);
        bool IsValidName(string name);
        bool IsValidParameterType(string type);
        bool IsValidReturnType(string type);
    }
    public class static MemberPresentationUtil
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.UI.Icons.IconId GetImage(JetBrains.ReSharper.Psi.IOverridableMember overridableMember) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.CommonControls.PresentableItemImage GetPresentableImage(JetBrains.ReSharper.Psi.IOverridableMember overridableMember) { }
    }
    public class MenuElement<T>
    
    {
        public MenuElement(T data) { }
        public T Data { get; }
    }
    public class static SelectionStorer
    {
        public static JetBrains.ReSharper.Feature.Services.Util.ISelectionStorer Create(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.Util.TextRange selectionRange) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.Util.ClrLanguages
{
    
    public class FormattingFunctionInvocationInfo
    {
        public JetBrains.ReSharper.Psi.Util.IStringConcatenationClrWrapper FormatStringConcatenation { get; }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Tree.IExpression> FormattingArguments { get; }
        public bool HasCustomFormatProvider { get; }
        public bool HasExplicitParamArrayArgument { get; }
        public JetBrains.ReSharper.Psi.Util.IFunctionInvocationClrWrapper Invocation { get; }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class FormattingFunctionInvocationInfoProvider
    {
        public FormattingFunctionInvocationInfoProvider(JetBrains.ReSharper.Psi.CodeAnnotations.CodeAnnotationsCache codeAnnotationsCache) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Feature.Services.Util.ClrLanguages.FormattingFunctionInvocationInfo TryGetByExpression(JetBrains.ReSharper.Psi.Tree.IArgumentsOwner argumentsOwner) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.Validators
{
    
    public class static PropertyValidatorFactory
    {
        public static System.IDisposable CreateNewNameValidator([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.IProperty<string> property, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Pointers.IDeclaredElementPointer<JetBrains.ReSharper.Psi.IDeclaredElement> source, [JetBrains.Annotations.NotNullAttribute()] string message) { }
        public static System.IDisposable CreateNewNameValidator([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.IProperty<string> property, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IDeclaredElement source, [JetBrains.Annotations.NotNullAttribute()] string message) { }
        public static System.IDisposable CreateNewNameValidator([JetBrains.Annotations.NotNullAttribute()] JetBrains.DataFlow.IProperty<string> property, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.PsiLanguageType language, [JetBrains.Annotations.NotNullAttribute()] string message) { }
        public static bool IsValidNewName([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Pointers.IDeclaredElementPointer<JetBrains.ReSharper.Psi.IDeclaredElement> pointer, [JetBrains.Annotations.CanBeNullAttribute()] string value) { }
        public static bool IsValidNewName([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IDeclaredElement element, [JetBrains.Annotations.CanBeNullAttribute()] string value) { }
    }
    [System.ObsoleteAttribute("Cannot be injected, replace with validator provider.")]
    public class TextIsValidNameAttribute : JetBrains.CommonControls.Validation.ValidationAttribute
    {
        public TextIsValidNameAttribute(string message, JetBrains.CommonControls.Validation.ValidatorSeverity severity) { }
        public override JetBrains.CommonControls.Validation.IValidator BuildValidator(System.Windows.Forms.Control control, object host) { }
    }
    [System.ObsoleteAttribute("Cannot be injected, replace with validator provider.")]
    public class TextIsValidNewNameAttribute : JetBrains.CommonControls.Validation.ValidationAttribute
    {
        public TextIsValidNewNameAttribute(string message, JetBrains.CommonControls.Validation.ValidatorSeverity severity, string declaredElementFieldOrPropertyName) { }
        public override JetBrains.CommonControls.Validation.IValidator BuildValidator(System.Windows.Forms.Control control, object host) { }
    }
    public class TextIsValidQualifiedNameValidator : JetBrains.CommonControls.Validation.TextValidator
    {
        public TextIsValidQualifiedNameValidator(System.Windows.Forms.Control control, JetBrains.CommonControls.Validation.ValidatorSeverity severity, string message, JetBrains.ReSharper.Psi.PsiLanguageType languageType, JetBrains.Application.Interop.NativeHook.IWindowsHookManager windowsHookManager, JetBrains.UI.Application.IUIApplication environment) { }
    }
    public class TextIsValidShortNameValidator : JetBrains.CommonControls.Validation.TextValidator
    {
        public TextIsValidShortNameValidator(System.Windows.Forms.Control control, JetBrains.CommonControls.Validation.ValidatorSeverity severity, string message, JetBrains.ReSharper.Psi.PsiLanguageType languageType, JetBrains.Application.Interop.NativeHook.IWindowsHookManager windowsHookManager, JetBrains.UI.Application.IUIApplication environment) { }
    }
}
namespace JetBrains.ReSharper.LiveTemplates
{
    
    public class TemplateField
    {
        public TemplateField([JetBrains.Annotations.NotNullAttribute()] string name, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotExpression expression, int initialRange) { }
        public TemplateField([JetBrains.Annotations.NotNullAttribute()] string name, [JetBrains.Annotations.CanBeNullAttribute()] string expression, int initialRange) { }
        public TemplateField([JetBrains.Annotations.NotNullAttribute()] [System.ComponentModel.LocalizableAttribute(false)] string name, int initialRange) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotExpression Expression { get; set; }
        public int InitialRange { get; set; }
        public System.Guid InitialSection { get; set; }
        [JetBrains.Annotations.NotNullAttribute()]
        public string Name { get; set; }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ReSharper.LiveTemplates.TemplateField Clone() { }
        public string GetPlaceholder(JetBrains.DocumentModel.IDocument document) { }
        public override string ToString() { }
    }
    public class static TemplateKeywords
    {
        public const string END_KEYWORD = "END";
        public static readonly System.Collections.Generic.List<string> KEYWORDS;
        public const string SELECTION_END_KEYWORD = "SELEND";
        public const string SELECTION_KEYWORD = "SELECTION";
        public const string SELECTION_START_KEYWORD = "SELSTART";
    }
    public enum TemplateKind
    {
        LiveTemplate = 0,
        Surround = 1,
        FileTemplate = 2,
    }
}
namespace JetBrains.ReSharper.LiveTemplates.Templates
{
    
    public class Template
    {
        public bool IsDisabled;
        public Template(string shortcut, string description, string text, bool reformat, bool shortenQualifiedReferences, bool invisible, JetBrains.ReSharper.Feature.Services.LiveTemplates.Settings.TemplateApplicability applicability) { }
        public Template(string text, JetBrains.ReSharper.Feature.Services.LiveTemplates.Settings.TemplateApplicability applicability) { }
        public JetBrains.ReSharper.Feature.Services.LiveTemplates.Settings.TemplateApplicability Applicability { get; set; }
        [JetBrains.Annotations.NotNullAttribute()]
        public System.Collections.Generic.ICollection<string> Categories { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [System.ObsoleteAttribute("Collection of scope points shall be used instead")]
        public JetBrains.ReSharper.Feature.Services.LiveTemplates.Context.ITemplateContext Context { get; set; }
        [JetBrains.Annotations.NotNullAttribute()]
        public string Description { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public string DescriptionRaw { get; set; }
        [JetBrains.Annotations.NotNullAttribute()]
        public System.Collections.Generic.IList<JetBrains.ReSharper.LiveTemplates.TemplateField> Fields { get; }
        public bool Invisible { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public string this[string key] { get; set; }
        public bool Reformat { get; set; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint> ScopePoints { get; }
        public System.Collections.Generic.IList<JetBrains.ReSharper.LiveTemplates.Templates.TemplateSection> Sections { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public string Shortcut { get; set; }
        public bool ShortenQualifiedReferences { get; set; }
        [JetBrains.Annotations.NotNullAttribute()]
        public string Text { get; set; }
        public System.Guid UID { get; set; }
        public void BindReferencedSections(JetBrains.Application.Settings.IContextBoundSettingsStore store) { }
        public JetBrains.ReSharper.LiveTemplates.Templates.Template Clone(bool generateNewUID) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.LiveTemplates.Templates.Template CreateFromXml(JetBrains.ReSharper.Feature.Services.LiveTemplates.Storages.ITemplateStorage storage, [JetBrains.Annotations.NotNullAttribute()] System.Xml.XmlElement templateElement, JetBrains.ReSharper.Feature.Services.LiveTemplates.Settings.TemplateApplicability applicability) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.LiveTemplates.Templates.Template ReadFromStore(System.Guid uid, JetBrains.Application.Settings.IContextBoundSettingsStore store, JetBrains.ReSharper.Feature.Services.LiveTemplates.Settings.TemplateApplicability applicability) { }
        public void SaveToStore(JetBrains.Application.Settings.ISettingsStore ustore, JetBrains.Application.DataContext.IDataContext dc = null) { }
        public void SaveToStore(JetBrains.Application.Settings.IContextBoundSettingsStore store) { }
        public void SetScopePoints(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint> templateScopePoints) { }
    }
    public class static TemplateEx
    {
        public static System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.LanguageService> LanguageServices([JetBrains.Annotations.CanBeNullAttribute()] this System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint> points) { }
        public static System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Parsing.ILexerFactory> LexerFactories([JetBrains.Annotations.CanBeNullAttribute()] this System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint> points) { }
        public static bool TagWith([JetBrains.Annotations.CanBeNullAttribute()] this JetBrains.ReSharper.LiveTemplates.Templates.Template template, string newTag) { }
    }
    public class TemplateReferenceSection : JetBrains.ReSharper.LiveTemplates.Templates.TemplateSection
    {
        public TemplateReferenceSection() { }
        public System.Collections.Generic.IDictionary<string, string> FieldMapping { get; set; }
        public System.Guid TemplateUid { get; set; }
        public override void SaveToStore(JetBrains.Application.Settings.IContextBoundSettingsStore store, System.Collections.Generic.Dictionary<JetBrains.Application.Settings.SettingsKey, object> sectionMapping, int sectionNo) { }
    }
    public class TemplateSection
    {
        public TemplateSection() { }
        public string LocationSelectorConfig { get; set; }
        public string LocationSelectorName { get; set; }
        public JetBrains.ReSharper.LiveTemplates.Templates.TemplateSectionType Type { get; set; }
        public System.Guid UID { get; set; }
        public virtual void SaveToStore(JetBrains.Application.Settings.IContextBoundSettingsStore store, System.Collections.Generic.Dictionary<JetBrains.Application.Settings.SettingsKey, object> sectionMapping, int sectionNo) { }
    }
    public enum TemplateSectionType
    {
        PlainText = 0,
        TemplateReference = 1,
    }
    public class TemplateTextSection : JetBrains.ReSharper.LiveTemplates.Templates.TemplateSection
    {
        public TemplateTextSection() { }
        public string Text { get; set; }
        public override void SaveToStore(JetBrains.Application.Settings.IContextBoundSettingsStore store, System.Collections.Generic.Dictionary<JetBrains.Application.Settings.SettingsKey, object> sectionMapping, int sectionNo) { }
    }
    public class static TemplateTokenType
    {
        public static readonly JetBrains.ReSharper.Psi.Parsing.TokenNodeType VARIABLE_PLACEHOLDER;
    }
}