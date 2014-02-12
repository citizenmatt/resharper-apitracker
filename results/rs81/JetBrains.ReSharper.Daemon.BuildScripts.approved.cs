[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("InvalidAttributeValue", null, "CodeSmell", "Invalid attribute value", "Highlights an attribute that has invalid value", JetBrains.ReSharper.Daemon.Severity.WARNING, false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("UknownTaskAttribute", null, "CodeSmell", "Unknown task attribute", "Highlights an unknown task attribute", JetBrains.ReSharper.Daemon.Severity.WARNING, false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("UnknownItemGroup", null, "CodeSmell", "Unknown item group", "Highlights an unknown item group", JetBrains.ReSharper.Daemon.Severity.WARNING, false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("MultipleOutputTags", null, "CodeSmell", "Multiple output tags defined", "Highlights a task with multiple output tags", JetBrains.ReSharper.Daemon.Severity.WARNING, false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("TasksNotLoaded", null, "CodeSmell", "Unknown tasks assembly", "Highlights tags where ReSharper failed to find tasks definitions", JetBrains.ReSharper.Daemon.Severity.WARNING, false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("OutputTagRequired", null, "CodeSmell", "Output tag required", "Highlights a task that requires an output tag", JetBrains.ReSharper.Daemon.Severity.WARNING, false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("UnknownTarget", null, "CodeSmell", "Unknown target", "Highlights an unknown target", JetBrains.ReSharper.Daemon.Severity.WARNING, false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("UnknownMetadata", null, "CodeSmell", "Unknown metadata", "Highlights an unknown metadata", JetBrains.ReSharper.Daemon.Severity.WARNING, false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("UnknownTask", null, "CodeSmell", "Unknown task", "Highlights an unknown task", JetBrains.ReSharper.Daemon.Severity.WARNING, false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("UnknownProperty", null, "CodeSmell", "Unknown property", "Highlights an unknown property", JetBrains.ReSharper.Daemon.Severity.WARNING, false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("InvalidTaskElement", null, "CodeSmell", "Invalid task element", "Highlights an invalid task element", JetBrains.ReSharper.Daemon.Severity.DO_NOT_SHOW, false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("WrongMetadataUse", null, "CodeSmell", "Wrong metadata use", "Highlights wrong metadata use", JetBrains.ReSharper.Daemon.Severity.DO_NOT_SHOW, false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("MissingAttribute", null, "CodeSmell", "Missing required attribute", "Highlights a tag which has missing required attribute", JetBrains.ReSharper.Daemon.Severity.WARNING, false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("UnknownOutputParameter", null, "CodeSmell", "Unknown output parameter", "Highlights an unknown output parameter of a task", JetBrains.ReSharper.Daemon.Severity.WARNING, false)]
[assembly: JetBrains.ReSharper.Daemon.RegisterStaticHighlightingsGroupAttribute("BuildScriptErrors", "Build Scripts Errors", true)]
[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]

namespace JetBrains.ReSharper.Daemon.BuildScripts.DaemonStage.Highlightings
{
    
    public abstract class AttributeRequiredWarning : JetBrains.ReSharper.Daemon.BuildScripts.DaemonStage.Highlightings.TaskHighlightingBase
    {
        public const string SeverityId = "MissingAttribute";
        protected AttributeRequiredWarning(JetBrains.ProjectModel.IProjectFile projectFile, string name, JetBrains.ReSharper.Psi.Xml.Impl.Tree.XmlIdentifier tokenNode) { }
        public string AttributeName { get; }
        public override string ToolTip { get; }
        public JetBrains.ReSharper.Psi.Tree.ITreeNode TreeNode { get; }
    }
    public class BuildScriptReferenceHighlightingBase : JetBrains.ReSharper.Daemon.BuildScripts.DaemonStage.Highlightings.ScriptHighlightingBase, JetBrains.ReSharper.Daemon.BuildScripts.DaemonStage.Highlightings.IReferenceHighlighting
    {
        public BuildScriptReferenceHighlightingBase(string name, JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public JetBrains.ReSharper.Psi.Resolve.IReference Reference { get; set; }
    }
    public class BuildScriptStaticHighlightingsGroups
    {
        public const string BuildScriptErrorsGroup = "BuildScriptErrors";
    }
    [JetBrains.ReSharper.Daemon.StaticSeverityHighlightingAttribute(JetBrains.ReSharper.Daemon.Severity.ERROR, "BuildScriptErrors", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class ErrorElementHighlighting : JetBrains.ReSharper.Daemon.IHighlighting
    {
        public ErrorElementHighlighting(JetBrains.ReSharper.Psi.ExtensionsAPI.Tree.ErrorElement element) { }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public bool IsValid() { }
    }
    public class ScriptHighlightingBase : JetBrains.ReSharper.Daemon.IHighlighting
    {
        protected string myName;
        public ScriptHighlightingBase(string name) { }
        public string ErrorStripeToolTip { get; }
        public string Name { get; }
        public int NavigationOffsetPatch { get; }
        public virtual string ToolTip { get; }
        public bool IsValid() { }
    }
    public class TaskHighlightingBase : JetBrains.ReSharper.Daemon.BuildScripts.DaemonStage.Highlightings.ScriptHighlightingBase
    {
        public TaskHighlightingBase(JetBrains.ProjectModel.IProjectFile projectFile, string name) { }
        public JetBrains.ProjectModel.IProjectFile ProjectFile { get; }
    }
    public abstract class UnknownAttributeHighlighting : JetBrains.ReSharper.Daemon.IHighlighting
    {
        public const string SeverityId = "UknownTaskAttribute";
        protected UnknownAttributeHighlighting(string name, string[] validNames, string tagName) { }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public bool IsValid() { }
    }
    public class UnresolvedPropertyHighlightingBase : JetBrains.ReSharper.Daemon.BuildScripts.DaemonStage.Highlightings.BuildScriptReferenceHighlightingBase
    {
        public const string SeverityId = "UnknownProperty";
        public UnresolvedPropertyHighlightingBase(string name, JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public override string ToolTip { get; }
    }
    public class UnresolvedTargetHighlightingBase : JetBrains.ReSharper.Daemon.BuildScripts.DaemonStage.Highlightings.BuildScriptReferenceHighlightingBase
    {
        public const string SeverityId = "UnknownTarget";
        public UnresolvedTargetHighlightingBase(string name, JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public override string ToolTip { get; }
    }
    public class UnresolvedTaskHighlightingBase : JetBrains.ReSharper.Daemon.BuildScripts.DaemonStage.Highlightings.TaskHighlightingBase
    {
        public const string SeverityId = "UnknownTask";
        public UnresolvedTaskHighlightingBase(JetBrains.ProjectModel.IProjectFile projectFile, string name) { }
        public override string ToolTip { get; }
    }
}
namespace JetBrains.ReSharper.Daemon.BuildScripts.DaemonStage.Highlightings.MSBuild
{
    
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("MissingAttribute", "MSBUILD_BUILD_SCRIPT", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class MissingMSBuildAttributeHighlighting : JetBrains.ReSharper.Daemon.BuildScripts.DaemonStage.Highlightings.AttributeRequiredWarning
    {
        public MissingMSBuildAttributeHighlighting(JetBrains.ProjectModel.IProjectFile projectFile, string name, JetBrains.ReSharper.Psi.Xml.Impl.Tree.XmlIdentifier tokenNode) { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("MultipleOutputTags", "MSBUILD_BUILD_SCRIPT", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.UNRESOLVED_ERROR)]
    public class MSBuildMultipleOutputTagsHighlighting : JetBrains.ReSharper.Daemon.BuildScripts.DaemonStage.Highlightings.ScriptHighlightingBase
    {
        public const string SeverityId = "MultipleOutputTags";
        public MSBuildMultipleOutputTagsHighlighting(string name) { }
        public override string ToolTip { get; }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("OutputTagRequired", "MSBUILD_BUILD_SCRIPT", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class MSBuildOutputTagRequiredHighlighting : JetBrains.ReSharper.Daemon.IHighlighting
    {
        public const string SeverityId = "OutputTagRequired";
        public MSBuildOutputTagRequiredHighlighting(string attributeName, JetBrains.ReSharper.Psi.BuildScripts.Tree.IBuildScriptTag parent, JetBrains.ReSharper.Psi.BuildScripts.MSBuild.Tasks.OutputAttributeType type) { }
        public string AttributeName { get; }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public JetBrains.ReSharper.Psi.BuildScripts.Tree.IBuildScriptTag Parent { get; }
        public string ToolTip { get; }
        public JetBrains.ReSharper.Psi.BuildScripts.MSBuild.Tasks.OutputAttributeType Type { get; }
        public bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("UknownTaskAttribute", "MSBUILD_BUILD_SCRIPT", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class UnknownMSBuildAttributeHighlighting : JetBrains.ReSharper.Daemon.BuildScripts.DaemonStage.Highlightings.UnknownAttributeHighlighting
    {
        public UnknownMSBuildAttributeHighlighting(string name, string[] validNames, string tagName) { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("UnknownOutputParameter", "MSBUILD_BUILD_SCRIPT", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class UnknownMSBuildOutputParameterHighlighting : JetBrains.ReSharper.Daemon.IHighlighting
    {
        public const string SeverityId = "UnknownOutputParameter";
        public UnknownMSBuildOutputParameterHighlighting(string name, string[] validNames, string tagName) { }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("UnknownItemGroup", "MSBUILD_BUILD_SCRIPT", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.UNRESOLVED_ERROR)]
    public class UnresolvedMSBuildItemGroupHighlighting : JetBrains.ReSharper.Daemon.BuildScripts.DaemonStage.Highlightings.BuildScriptReferenceHighlightingBase
    {
        public const string SeverityId = "UnknownItemGroup";
        public UnresolvedMSBuildItemGroupHighlighting(string name, JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public override string ToolTip { get; }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("UnknownMetadata", "MSBUILD_BUILD_SCRIPT", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.UNRESOLVED_ERROR)]
    public class UnresolvedMSBuildItemMetadataHighlighting : JetBrains.ReSharper.Daemon.BuildScripts.DaemonStage.Highlightings.BuildScriptReferenceHighlightingBase
    {
        public const string SeverityId = "UnknownMetadata";
        public UnresolvedMSBuildItemMetadataHighlighting(string name, JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public override string ToolTip { get; }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("UnknownProperty", "MSBUILD_BUILD_SCRIPT", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.UNRESOLVED_ERROR)]
    public class UnresolvedMSBuildPropertyHighlighting : JetBrains.ReSharper.Daemon.BuildScripts.DaemonStage.Highlightings.UnresolvedPropertyHighlightingBase
    {
        public UnresolvedMSBuildPropertyHighlighting(string name, JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("UnknownTarget", "MSBUILD_BUILD_SCRIPT", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.UNRESOLVED_ERROR)]
    public class UnresolvedMSBuildTargetHighlighting : JetBrains.ReSharper.Daemon.BuildScripts.DaemonStage.Highlightings.UnresolvedTargetHighlightingBase
    {
        public UnresolvedMSBuildTargetHighlighting(string name, JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("UnknownTask", "MSBUILD_BUILD_SCRIPT", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.UNRESOLVED_ERROR)]
    public class UnresolvedMSBuildTaskHighlighting : JetBrains.ReSharper.Daemon.BuildScripts.DaemonStage.Highlightings.UnresolvedTaskHighlightingBase
    {
        public UnresolvedMSBuildTaskHighlighting(string name, JetBrains.ReSharper.Psi.BuildScripts.Tree.IBuildScriptTag tag) { }
        public JetBrains.ReSharper.Psi.BuildScripts.Tree.IBuildScriptTag Tag { get; }
        public override string ToolTip { get; }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("WrongMetadataUse", "MSBUILD_BUILD_SCRIPT", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.UNRESOLVED_ERROR)]
    public class WrongMSBuildItemMetadataHighlighting : JetBrains.ReSharper.Daemon.BuildScripts.DaemonStage.Highlightings.BuildScriptReferenceHighlightingBase
    {
        public const string SeverityId = "WrongMetadataUse";
        public WrongMSBuildItemMetadataHighlighting(string name, JetBrains.ReSharper.Psi.Resolve.IReference reference, string currentItemGroupName, System.Collections.Generic.IEnumerable<string> availableMetadataItems) { }
        public override string ToolTip { get; }
    }
}
namespace JetBrains.ReSharper.Daemon.BuildScripts.DaemonStage.Highlightings.NAnt
{
    
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("InvalidAttributeValue", "NANT_BUILD_SCRIPT", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public sealed class InvalidAttributeValueHighlighting : JetBrains.ReSharper.Daemon.IHighlighting
    {
        public const string SeverityId = "InvalidAttributeValue";
        public InvalidAttributeValueHighlighting(string name, JetBrains.ReSharper.Psi.BuildScripts.NAnt.Tasks.Validator validator) { }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("MissingAttribute", "NANT_BUILD_SCRIPT", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class MissingNAntAttributeHighlighting : JetBrains.ReSharper.Daemon.BuildScripts.DaemonStage.Highlightings.AttributeRequiredWarning
    {
        public MissingNAntAttributeHighlighting(JetBrains.ProjectModel.IProjectFile projectFile, string name, JetBrains.ReSharper.Psi.Xml.Impl.Tree.XmlIdentifier tokenNode) { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("TasksNotLoaded", "NANT_BUILD_SCRIPT", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.WARNING)]
    public class TasksNotLoadedHighlighting : JetBrains.ReSharper.Daemon.IHighlighting
    {
        public const string SeverityId = "TasksNotLoaded";
        public string ErrorStripeToolTip { get; }
        public JetBrains.ReSharper.Psi.BuildScripts.NAnt.Tree.NAntLoadTasksTag LoadTasksTag { get; }
        public int NavigationOffsetPatch { get; }
        public string ToolTip { get; }
        public bool IsValid() { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("UknownTaskAttribute", "NANT_BUILD_SCRIPT", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class UnknownNAntAttributeHighlighting : JetBrains.ReSharper.Daemon.BuildScripts.DaemonStage.Highlightings.UnknownAttributeHighlighting
    {
        public UnknownNAntAttributeHighlighting(string name, string[] validNames, string tagName) { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("InvalidTaskElement", "NANT_BUILD_SCRIPT", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class UnknownTaskElementWarning : JetBrains.ReSharper.Daemon.BuildScripts.DaemonStage.Highlightings.TaskHighlightingBase
    {
        public const string SeverityId = "InvalidTaskElement";
        public UnknownTaskElementWarning(JetBrains.ProjectModel.IProjectFile projectFile, string name, System.Collections.Generic.List<string> validElements, string tagName) { }
        public string ErrorStripeToolTip { get; }
        public int NavigationOffsetPatch { get; }
        public override string ToolTip { get; }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("UnknownProperty", "NANT_BUILD_SCRIPT", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.UNRESOLVED_ERROR)]
    public class UnresolvedNAntPropertyHighlighting : JetBrains.ReSharper.Daemon.BuildScripts.DaemonStage.Highlightings.UnresolvedPropertyHighlightingBase
    {
        public UnresolvedNAntPropertyHighlighting(string name, JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("UnknownTarget", "NANT_BUILD_SCRIPT", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.UNRESOLVED_ERROR)]
    public class UnresolvedNAntTargetHighlighting : JetBrains.ReSharper.Daemon.BuildScripts.DaemonStage.Highlightings.UnresolvedTargetHighlightingBase
    {
        public UnresolvedNAntTargetHighlighting(string name, JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
    }
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("UnknownTask", "NANT_BUILD_SCRIPT", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.UNRESOLVED_ERROR)]
    public class UnresolvedNAntTaskHighlighting : JetBrains.ReSharper.Daemon.BuildScripts.DaemonStage.Highlightings.UnresolvedTaskHighlightingBase
    {
        public UnresolvedNAntTaskHighlighting(JetBrains.ProjectModel.IProjectFile projectFile, string name) { }
    }
}
namespace JetBrains.ReSharper.Daemon.BuildScripts.DaemonStage
{
    
    public class MSBuildDaemonStageProcess : JetBrains.ReSharper.Daemon.BuildScripts.DaemonStage.ScriptDaemonStageProcessBase<JetBrains.ReSharper.Psi.BuildScripts.MSBuild.MSBuildLanguageService>
    {
        public MSBuildDaemonStageProcess(JetBrains.ReSharper.Daemon.IDaemonProcess process, JetBrains.Application.Settings.IContextBoundSettingsStore settingStore) { }
        protected override void ProcessAttribute(JetBrains.ReSharper.Psi.BuildScripts.Tree.IBuildScriptAttribute attribute, JetBrains.ReSharper.Psi.BuildScripts.MSBuild.MSBuildLanguageService languageService, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer consumer) { }
        protected override void ProcessElement(JetBrains.ReSharper.Psi.BuildScripts.Tree.BuildScriptTagBase element, JetBrains.ReSharper.Psi.BuildScripts.MSBuild.MSBuildLanguageService languageService, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer consumer) { }
        protected override void ProcessTag(JetBrains.ReSharper.Psi.BuildScripts.Tree.IBuildScriptTag tag, JetBrains.ReSharper.Psi.BuildScripts.MSBuild.MSBuildLanguageService languageService, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer consumer) { }
    }
    public class NAntDaemonStageProcess : JetBrains.ReSharper.Daemon.BuildScripts.DaemonStage.ScriptDaemonStageProcessBase<JetBrains.ReSharper.Psi.BuildScripts.NAnt.NAntLanguageService>
    {
        public NAntDaemonStageProcess(JetBrains.ReSharper.Daemon.IDaemonProcess process, JetBrains.Application.Settings.IContextBoundSettingsStore settingsStore) { }
        protected override void ProcessAttribute(JetBrains.ReSharper.Psi.BuildScripts.Tree.IBuildScriptAttribute attribute, JetBrains.ReSharper.Psi.BuildScripts.NAnt.NAntLanguageService languageService, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer consumer) { }
        protected override void ProcessElement(JetBrains.ReSharper.Psi.BuildScripts.Tree.BuildScriptTagBase element, JetBrains.ReSharper.Psi.BuildScripts.NAnt.NAntLanguageService languageService, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer consumer) { }
        protected override void ProcessTag(JetBrains.ReSharper.Psi.BuildScripts.Tree.IBuildScriptTag tag, JetBrains.ReSharper.Psi.BuildScripts.NAnt.NAntLanguageService languageService, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer consumer) { }
    }
    [JetBrains.ReSharper.Daemon.DaemonStageAttribute(StagesBefore=new System.Type[] {
            typeof(JetBrains.ReSharper.Daemon.BuildScripts.DaemonStage.ScriptErrorElementStage)})]
    public class ScriptDaemonStage : JetBrains.ReSharper.Daemon.IDaemonStage
    {
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Daemon.IDaemonStageProcess> CreateProcess(JetBrains.ReSharper.Daemon.IDaemonProcess process, JetBrains.Application.Settings.IContextBoundSettingsStore settings, JetBrains.ReSharper.Daemon.DaemonProcessKind processKind) { }
        public JetBrains.ReSharper.Daemon.ErrorStripeRequest NeedsErrorStripe(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, JetBrains.Application.Settings.IContextBoundSettingsStore settings) { }
    }
    public abstract class ScriptDaemonStageProcessBase<TLanguageService> : JetBrains.ReSharper.Daemon.IDaemonStageProcess
        where TLanguageService : JetBrains.ReSharper.Psi.BuildScripts.BuildScriptLanguageServiceBase
    {
        protected readonly JetBrains.ReSharper.Daemon.IDaemonProcess myProcess;
        protected ScriptDaemonStageProcessBase(JetBrains.ReSharper.Daemon.IDaemonProcess process, JetBrains.Application.Settings.IContextBoundSettingsStore settingStore) { }
        public JetBrains.ReSharper.Daemon.IDaemonProcess DaemonProcess { get; }
        public void Execute(System.Action<JetBrains.ReSharper.Daemon.DaemonStageResult> committer) { }
        protected abstract void ProcessAttribute(JetBrains.ReSharper.Psi.BuildScripts.Tree.IBuildScriptAttribute attribute, TLanguageService languageService, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer consumer);
        protected virtual void ProcessElement(JetBrains.ReSharper.Psi.BuildScripts.Tree.BuildScriptTagBase element, TLanguageService languageService, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer consumer) { }
        protected abstract void ProcessTag(JetBrains.ReSharper.Psi.BuildScripts.Tree.IBuildScriptTag tag, TLanguageService languageService, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer consumer);
    }
    [JetBrains.ReSharper.Daemon.DaemonStageAttribute()]
    public class ScriptErrorElementStage : JetBrains.ReSharper.Daemon.IDaemonStage
    {
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Daemon.IDaemonStageProcess> CreateProcess(JetBrains.ReSharper.Daemon.IDaemonProcess process, JetBrains.Application.Settings.IContextBoundSettingsStore settings, JetBrains.ReSharper.Daemon.DaemonProcessKind processKind) { }
        public JetBrains.ReSharper.Daemon.ErrorStripeRequest NeedsErrorStripe(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, JetBrains.Application.Settings.IContextBoundSettingsStore settings) { }
    }
}
namespace JetBrains.ReSharper.Daemon.BuildScripts
{
    
    [JetBrains.ProjectModel.ProjectFileTypeAttribute(typeof(JetBrains.ProjectModel.MSBuildProjectFileType))]
    public class MSBuildHighlightingSuppressor : JetBrains.ReSharper.Daemon.IHighlightingSuppressor
    {
        public JetBrains.DataFlow.IProperty<bool> ShouldSuppress(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ProjectModel.IProjectFile projectFile, JetBrains.TextControl.ITextControl textControl) { }
    }
    public class MSBuildTaskValidator : JetBrains.ReSharper.Daemon.BuildScripts.TaskValidator
    {
        public override void Validate(JetBrains.ProjectModel.IProjectFile projectFile, JetBrains.ReSharper.Psi.BuildScripts.Tree.IBuildScriptTag tag, JetBrains.ReSharper.Psi.BuildScripts.ITask task, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer consumer) { }
    }
    public class NAntTaskValidator : JetBrains.ReSharper.Daemon.BuildScripts.TaskValidator
    {
        public override void Validate(JetBrains.ProjectModel.IProjectFile projectFile, JetBrains.ReSharper.Psi.BuildScripts.Tree.IBuildScriptTag tag, JetBrains.ReSharper.Psi.BuildScripts.ITask task, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer consumer) { }
    }
    public abstract class TaskValidator
    {
        public abstract void Validate(JetBrains.ProjectModel.IProjectFile projectFile, JetBrains.ReSharper.Psi.BuildScripts.Tree.IBuildScriptTag tag, JetBrains.ReSharper.Psi.BuildScripts.ITask task, JetBrains.ReSharper.Daemon.Stages.IHighlightingConsumer highlightings);
    }
}