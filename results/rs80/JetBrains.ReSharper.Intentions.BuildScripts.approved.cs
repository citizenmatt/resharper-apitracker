[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]

namespace JetBrains.ReSharper.Intentions.BuildScripts
{
    
    [JetBrains.Application.ShellComponentAttribute()]
    public class BuildScriptQuickFixRegistrarComponent
    {
        public BuildScriptQuickFixRegistrarComponent(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ReSharper.Daemon.IQuickFixes table) { }
    }
}
namespace JetBrains.ReSharper.Intentions.BuildScripts.ContextActions
{
    
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionDataBuilderAttribute(typeof(JetBrains.ReSharper.Intentions.BuildScripts.ContextActions.IBuildScriptContextActionDataProvider))]
    public class BuildScriptContextActionDataBuilder : JetBrains.ReSharper.Feature.Services.Bulbs.IContextActionDataBuilder
    {
        public JetBrains.ReSharper.Feature.Services.Bulbs.IContextActionDataProvider Build(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
    }
    public class BuildScriptContextActionDataProvider : JetBrains.ReSharper.Feature.Services.Bulbs.CachedContextActionDataProviderBase<JetBrains.ReSharper.Psi.BuildScripts.Tree.IBuildFile>, JetBrains.ReSharper.Feature.Services.Bulbs.IContextActionDataProvider, JetBrains.ReSharper.Feature.Services.Bulbs.IContextActionDataProvider<JetBrains.ReSharper.Psi.BuildScripts.Tree.IBuildFile>, JetBrains.ReSharper.Intentions.BuildScripts.ContextActions.IBuildScriptContextActionDataProvider
    {
        public BuildScriptContextActionDataProvider(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl, JetBrains.ReSharper.Psi.BuildScripts.Tree.IBuildFile file) { }
    }
    public class static BuildScriptContextActions
    {
        public const string GroupID = "Build scripts";
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Creates a property gathering all target dependencies. This allows to hook up into" +
        " the build process", Group="Build scripts", Name="Generate property for target dependencies", Priority=0)]
    public class CreatePropertyForTargetDependencyContextAction : JetBrains.ReSharper.Intentions.Extensibility.IContextAction
    {
        public CreatePropertyForTargetDependencyContextAction(JetBrains.ReSharper.Intentions.BuildScripts.ContextActions.IBuildScriptContextActionDataProvider dataProvider) { }
        public JetBrains.ReSharper.Intentions.Extensibility.IBulbAction[] Items { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        public bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Generates xml schema definition for custom tasks, properties and item groups", Group="Build scripts", Name="Generate XSD")]
    public class GenerateXSDContextAction : JetBrains.ReSharper.Intentions.Legacy.ContextActionBase_Obsolete, JetBrains.ReSharper.Intentions.Extensibility.IBulbAction
    {
        public GenerateXSDContextAction(JetBrains.ReSharper.Intentions.BuildScripts.ContextActions.IBuildScriptContextActionDataProvider dataProvider) { }
        public override JetBrains.ReSharper.Intentions.Extensibility.IBulbAction[] Items { get; }
        public string Text { get; }
        public void Execute(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        protected override void ExecuteInternal(params object[] param) { }
        protected override bool IsAvailableInternal() { }
    }
    public interface IBuildScriptContextActionDataProvider : JetBrains.ReSharper.Feature.Services.Bulbs.IContextActionDataProvider, JetBrains.ReSharper.Feature.Services.Bulbs.IContextActionDataProvider<JetBrains.ReSharper.Psi.BuildScripts.Tree.IBuildFile> { }
}
namespace JetBrains.ReSharper.Intentions.BuildScripts.Options
{
    
    [JetBrains.UI.Options.OptionsPageAttribute("BuildScriptContextActions", "Context Actions", typeof(JetBrains.ReSharper.Daemon.Src.Bulbs.Resources.BulbThemedIcons.ContextAction), HelpKeyword="Reference__Options__Languages__Build_Scripts__Context_Actions", ParentId="BuildScripts")]
    public class BuildScriptContextActionsPage : JetBrains.ReSharper.Intentions.Options.ContextActionsPageBase
    {
        [JetBrains.Annotations.PublicAPIAttribute()]
        public const string PID = "BuildScriptContextActions";
        public BuildScriptContextActionsPage(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionTable contextActionTable, JetBrains.UI.Application.UIApplication uiApplication, JetBrains.Application.Interop.NativeHook.IWindowsHookManager windowsHookManager, JetBrains.ActionManagement.IActionManager actionManager, JetBrains.UI.Options.OptionsSettingsSmartContext smartContext, JetBrains.Threading.IThreading threading) { }
        public override string Id { get; }
    }
}
namespace JetBrains.ReSharper.Intentions.BuildScripts.QuickFixes
{
    
    public class AddAttributeQuickFix : JetBrains.ReSharper.Intentions.Extensibility.IQuickFix
    {
        public AddAttributeQuickFix(JetBrains.ReSharper.Daemon.BuildScripts.DaemonStage.Highlightings.AttributeRequiredWarning warning) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        public bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class AddOutputTagQuickFix : JetBrains.ReSharper.Intentions.Extensibility.IQuickFix
    {
        public AddOutputTagQuickFix(JetBrains.ReSharper.Daemon.BuildScripts.DaemonStage.Highlightings.MSBuild.MSBuildOutputTagRequiredHighlighting highlighting) { }
        public JetBrains.ReSharper.Intentions.Extensibility.IBulbAction[] Items { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        public bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class IgnorePropertyQuickFix : JetBrains.ReSharper.Intentions.Extensibility.IQuickFix
    {
        public IgnorePropertyQuickFix(JetBrains.ReSharper.Daemon.BuildScripts.DaemonStage.Highlightings.ScriptHighlightingBase highlighting) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        public bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class LocateAssemblyQuickFix : JetBrains.ReSharper.Intentions.Extensibility.IQuickFix
    {
        public LocateAssemblyQuickFix(JetBrains.ReSharper.Daemon.BuildScripts.DaemonStage.Highlightings.NAnt.TasksNotLoadedHighlighting highlighting) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        public bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class RenameMSBuildItemGroupReferencesQuickFix : JetBrains.ReSharper.Intentions.BuildScripts.QuickFixes.RenameReferencesQuickFixBase
    {
        public RenameMSBuildItemGroupReferencesQuickFix(JetBrains.ReSharper.Daemon.BuildScripts.DaemonStage.Highlightings.MSBuild.UnresolvedMSBuildItemGroupHighlighting highlighting) { }
    }
    public class RenameMSBuildPropertyReferencesQuickFix : JetBrains.ReSharper.Intentions.BuildScripts.QuickFixes.RenameReferencesQuickFixBase
    {
        public RenameMSBuildPropertyReferencesQuickFix(JetBrains.ReSharper.Daemon.BuildScripts.DaemonStage.Highlightings.MSBuild.UnresolvedMSBuildPropertyHighlighting highlighting) { }
    }
    public class RenameMSBuildTargetReferencesQuickFix : JetBrains.ReSharper.Intentions.BuildScripts.QuickFixes.RenameReferencesQuickFixBase
    {
        public RenameMSBuildTargetReferencesQuickFix(JetBrains.ReSharper.Daemon.BuildScripts.DaemonStage.Highlightings.MSBuild.UnresolvedMSBuildTargetHighlighting highlighting) { }
    }
    public class RenameNAntPropertyReferencesQuickFix : JetBrains.ReSharper.Intentions.BuildScripts.QuickFixes.RenameReferencesQuickFixBase
    {
        public RenameNAntPropertyReferencesQuickFix(JetBrains.ReSharper.Daemon.BuildScripts.DaemonStage.Highlightings.NAnt.UnresolvedNAntPropertyHighlighting highlighting) { }
    }
    public class RenameNAntTargetReferencesQuickFix : JetBrains.ReSharper.Intentions.BuildScripts.QuickFixes.RenameReferencesQuickFixBase
    {
        public RenameNAntTargetReferencesQuickFix(JetBrains.ReSharper.Daemon.BuildScripts.DaemonStage.Highlightings.NAnt.UnresolvedNAntTargetHighlighting highlighting) { }
    }
    public class RenameReferencesQuickFixBase : JetBrains.ReSharper.Intentions.QuickFixBase_Obsolete
    {
        public RenameReferencesQuickFixBase(string referenceName, JetBrains.ReSharper.Psi.BuildScripts.BuildScriptDeclaredElementType referenceType, JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        protected override bool IsValid { get; }
        public override string Text { get; }
        protected override void ExecutePostTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        protected override void ExecuteTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        protected override bool IsAvailableEx() { }
    }
    public class UnresolvedMSBuildItemGroupQuickFix : JetBrains.ReSharper.Intentions.Extensibility.IQuickFix
    {
        public UnresolvedMSBuildItemGroupQuickFix(JetBrains.ReSharper.Daemon.BuildScripts.DaemonStage.Highlightings.MSBuild.UnresolvedMSBuildItemGroupHighlighting highlighting) { }
        public JetBrains.ReSharper.Intentions.Extensibility.IBulbAction[] Items { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        public bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class UnresolvedMSBuildPropertyQuickFix : JetBrains.ReSharper.Intentions.Extensibility.IQuickFix
    {
        public UnresolvedMSBuildPropertyQuickFix(JetBrains.ReSharper.Daemon.BuildScripts.DaemonStage.Highlightings.ScriptHighlightingBase highlighting) { }
        public JetBrains.ReSharper.Intentions.Extensibility.IBulbAction[] Items { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        public bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class UnresolvedMSBuildTargetQuickFix : JetBrains.ReSharper.Intentions.Extensibility.IQuickFix
    {
        public UnresolvedMSBuildTargetQuickFix(JetBrains.ReSharper.Daemon.BuildScripts.DaemonStage.Highlightings.MSBuild.UnresolvedMSBuildTargetHighlighting highlighting) { }
        public JetBrains.ReSharper.Intentions.Extensibility.IBulbAction[] Items { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        public bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class UnresolvedMSBuildTaskQuickFix : JetBrains.ReSharper.Intentions.Extensibility.IQuickFix
    {
        public UnresolvedMSBuildTaskQuickFix(JetBrains.ReSharper.Daemon.BuildScripts.DaemonStage.Highlightings.MSBuild.UnresolvedMSBuildTaskHighlighting highlighting) { }
        public JetBrains.ReSharper.Intentions.Extensibility.IBulbAction[] Items { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        public bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class UnresolvedNAntPropertyQuickFix : JetBrains.ReSharper.Intentions.Extensibility.IQuickFix
    {
        public UnresolvedNAntPropertyQuickFix(JetBrains.ReSharper.Daemon.BuildScripts.DaemonStage.Highlightings.NAnt.UnresolvedNAntPropertyHighlighting highlighting) { }
        public JetBrains.ReSharper.Intentions.Extensibility.IBulbAction[] Items { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        public bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class UnresolvedNAntTargetQuickFix : JetBrains.ReSharper.Intentions.Extensibility.IQuickFix
    {
        public UnresolvedNAntTargetQuickFix(JetBrains.ReSharper.Daemon.BuildScripts.DaemonStage.Highlightings.NAnt.UnresolvedNAntTargetHighlighting highlighting) { }
        public JetBrains.ReSharper.Intentions.Extensibility.IBulbAction[] Items { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        public bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class UnresolvedNAntTaskQuickFix : JetBrains.ReSharper.Intentions.Extensibility.IQuickFix
    {
        public UnresolvedNAntTaskQuickFix(JetBrains.ReSharper.Daemon.BuildScripts.DaemonStage.Highlightings.NAnt.UnresolvedNAntTaskHighlighting highlighting) { }
        public UnresolvedNAntTaskQuickFix(JetBrains.ReSharper.Daemon.BuildScripts.DaemonStage.Highlightings.AttributeRequiredWarning highlighting) { }
        public UnresolvedNAntTaskQuickFix(JetBrains.ReSharper.Daemon.BuildScripts.DaemonStage.Highlightings.NAnt.UnknownTaskElementWarning highlighting) { }
        public JetBrains.ReSharper.Intentions.Extensibility.IBulbAction[] Items { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        public bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
}