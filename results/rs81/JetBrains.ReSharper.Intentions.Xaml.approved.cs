[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]

namespace JetBrains.ReSharper.Intentions.Xaml.ContextActions
{
    
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Changes XAML type or type member access rights", Group="XAML", Name="Change XAML type or type member access rights")]
    public class AccessRightContextAction : JetBrains.ReSharper.Intentions.Extensibility.IContextAction
    {
        public AccessRightContextAction(JetBrains.ReSharper.Feature.Services.Xml.Bulbs.XmlContextActionDataProvider provider) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        public bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public abstract class AddGridDefinitionActionBase : JetBrains.ReSharper.Intentions.Extensibility.ContextActionBase
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        protected string DefinitionName;
        protected AddGridDefinitionActionBase([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Feature.Services.Xml.Bulbs.XmlContextActionDataProvider provider) { }
        protected abstract bool IsAddBefore { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
        protected virtual void ProcessDefinition([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xaml.Tree.IXamlObjectElement definition, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xaml.Tree.IXamlPropertyElement definitionsProperty) { }
        [JetBrains.Annotations.NotNullAttribute()]
        protected virtual string ProcessIndex(int index, int countBefore) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Adds grid column/row definition after definition under caret and updates usages", Group="XAML", Name="Add grid column/row definition after current one", Priority=20)]
    public class AddGridDefinitionAfterAction : JetBrains.ReSharper.Intentions.Xaml.ContextActions.AddGridDefinitionActionBase
    {
        public AddGridDefinitionAfterAction([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Feature.Services.Xml.Bulbs.XmlContextActionDataProvider provider) { }
        protected override bool IsAddBefore { get; }
        public override string Text { get; }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Adds grid column/row definition before definition under caret and updates usages", Group="XAML", Name="Add grid column/row definition before current one", Priority=30)]
    public class AddGridDefinitionBeforeAction : JetBrains.ReSharper.Intentions.Xaml.ContextActions.AddGridDefinitionActionBase
    {
        public AddGridDefinitionBeforeAction([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Feature.Services.Xml.Bulbs.XmlContextActionDataProvider provider) { }
        protected override bool IsAddBefore { get; }
        public override string Text { get; }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Switches between static and dynamic resource reference", Group="XAML", Name="Change resource reference from static to dynamic or vice versa", Priority=-10)]
    public class ChangeResourceUsageStaticnessAction : JetBrains.ReSharper.Intentions.Extensibility.IContextAction
    {
        public ChangeResourceUsageStaticnessAction(JetBrains.ReSharper.Feature.Services.Xml.Bulbs.XmlContextActionDataProvider provider) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        public bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Creates XAML resource", Group="XAML", Name="Create XAML resource")]
    public class CreateResourceFromUsageAction : JetBrains.ReSharper.Intentions.Extensibility.IContextAction
    {
        public CreateResourceFromUsageAction(JetBrains.ReSharper.Feature.Services.Xml.Bulbs.XmlContextActionDataProvider provider) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        public bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Extracts property setter to XAML style", Group="XAML", Name="Extract property setter to style", Priority=-12)]
    public sealed class MovePropertyToStyleAction : JetBrains.ReSharper.Intentions.Extensibility.ContextActionBase
    {
        public MovePropertyToStyleAction([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Feature.Services.Xml.Bulbs.XmlContextActionDataProvider provider) { }
        public override string Text { get; }
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Qualifies property setter owner type", Group="XAML", Name="Qualify property setter owner type", Priority=-1)]
    public class QualifyPropertyAttributeTypeFix : JetBrains.ReSharper.Intentions.Extensibility.ContextActionBase
    {
        public QualifyPropertyAttributeTypeFix(JetBrains.ReSharper.Feature.Services.Xml.Bulbs.XmlContextActionDataProvider provider) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Qualifies binding property path owner type. Available only in WPF", Group="XAML", Name="Qualify property path owner type")]
    public class QualifyPropertyPathTypeFix : JetBrains.ReSharper.Intentions.Extensibility.ContextActionBase
    {
        public QualifyPropertyPathTypeFix(JetBrains.ReSharper.Feature.Services.Xml.Bulbs.XmlContextActionDataProvider provider) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Removes grid column/row definition and updates usages", Group="XAML", Name="Remove grid column/row definition", Priority=10)]
    public class RemoveGridDefinitionAction : JetBrains.ReSharper.Intentions.Xaml.ContextActions.AddGridDefinitionActionBase
    {
        public RemoveGridDefinitionAction([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Feature.Services.Xml.Bulbs.XmlContextActionDataProvider provider) { }
        protected override bool IsAddBefore { get; }
        public override string Text { get; }
        protected override void ProcessDefinition(JetBrains.ReSharper.Psi.Xaml.Tree.IXamlObjectElement definition, JetBrains.ReSharper.Psi.Xaml.Tree.IXamlPropertyElement definitionsProperty) { }
        protected override string ProcessIndex(int index, int countBefore) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Removes markup extension property", Group="XAML", Name="Remove markup extension property", Priority=-2)]
    public class RemoveMarkupPropertyAction : JetBrains.ReSharper.Intentions.Extensibility.ContextActionBase
    {
        public RemoveMarkupPropertyAction(JetBrains.ReSharper.Feature.Services.Xml.Bulbs.XmlContextActionDataProvider provider) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Opens path mapping settings for current project", Group="XAML", Name="Edit path mapping", Priority=0)]
    public class RunPathMappingEditorAction : JetBrains.ReSharper.Intentions.Extensibility.IContextAction
    {
        public RunPathMappingEditorAction(JetBrains.ReSharper.Feature.Services.Xaml.Bulbs.XamlContextActionDataProvider provider) { }
        public JetBrains.ReSharper.Intentions.Extensibility.IBulbAction[] Items { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        public bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class static XamlContextActions
    {
        public const string GroupID = "XAML";
    }
}
namespace JetBrains.ReSharper.Intentions.Xaml.QuickFixes
{
    
    [JetBrains.ReSharper.Feature.Services.Bulbs.QuickFixAttribute()]
    public class AccessRightsQuickFix : JetBrains.ReSharper.Intentions.Extensibility.IQuickFix
    {
        public AccessRightsQuickFix([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Daemon.Xaml.Highlightings.XamlAccessRightsErrorHighlighting error) { }
        public AccessRightsQuickFix([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Daemon.Xaml.Highlightings.XamlTypeDeclarationAccessRightsErrorHighlighting error) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        public bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.QuickFixAttribute()]
    public class AddGridDefinitionsFix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public AddGridDefinitionsFix([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Daemon.Xaml.Highlightings.XamlGridIndexOutOfRangeHighlighting highlighting) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.QuickFixAttribute()]
    public class AddGridSpecificationFix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public AddGridSpecificationFix(JetBrains.ReSharper.Daemon.Xaml.Highlightings.XamlMissingGridIndexHighlighting highlighting) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.QuickFixAttribute()]
    public class ChangeResourceUsageStaticnessQuickFix : JetBrains.ReSharper.Intentions.Extensibility.IQuickFix
    {
        public static readonly JetBrains.Util.Key<object> QUICK_FIX_CREATED;
        public ChangeResourceUsageStaticnessQuickFix(JetBrains.ReSharper.Daemon.Xaml.Highlightings.XamlDynamicResourceNotAllowedErrorHighlighting highlighting) { }
        public JetBrains.ReSharper.Intentions.Extensibility.IBulbAction[] Items { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        public bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.QuickFixAttribute()]
    public class ChangeSignatureQuickFix : JetBrains.ReSharper.Intentions.Xaml.QuickFixes.XamlQuickFix
    {
        public ChangeSignatureQuickFix(JetBrains.ReSharper.Daemon.Xaml.Highlightings.XamlEventHandlerSignatureError highlighting) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.QuickFixAttribute()]
    public class CreateEventHandlerQuickFix : JetBrains.ReSharper.Intentions.Xaml.QuickFixes.XamlQuickFix
    {
        public CreateEventHandlerQuickFix(JetBrains.ReSharper.Daemon.Xaml.Highlightings.XamlEventHandlerSignatureError error) { }
        public CreateEventHandlerQuickFix(JetBrains.ReSharper.Daemon.Xaml.Highlightings.XamlEventHandlerNotResolvedError error) { }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecuteAfterPsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.ProjectModel.IProjectModelTransactionCookie cookie, JetBrains.Application.Progress.IProgressIndicator progress) { }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.QuickFixAttribute()]
    public class CreateNamespaceAliasFromUsageQuickFix : JetBrains.ReSharper.Intentions.Xaml.QuickFixes.XamlQuickFix
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        protected readonly JetBrains.ReSharper.Psi.Xaml.Tree.IXamlNamespaceAliasReference AliasReference;
        public CreateNamespaceAliasFromUsageQuickFix(JetBrains.ReSharper.Daemon.Xaml.Highlightings.XamlNotResolvedError error) { }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.QuickFixAttribute()]
    public class CreateResourceFromUsageOrFixStaticnessQuickFix : JetBrains.ReSharper.Intentions.Extensibility.IQuickFix
    {
        public CreateResourceFromUsageOrFixStaticnessQuickFix([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Daemon.Xaml.Highlightings.XamlStaticResourceNotResolvedHighlighting highlighting) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        public bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.QuickFixAttribute()]
    public class CreateTypeQuickFix : JetBrains.ReSharper.Intentions.Xaml.QuickFixes.CreateTypeQuickFixBase
    {
        public CreateTypeQuickFix(JetBrains.ReSharper.Daemon.Xaml.Highlightings.XamlTypeNotResolvedError error) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        protected JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.ICreationTarget CreateTargetFile([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Xaml.Tree.IXamlTypeReference reference, JetBrains.ReSharper.Psi.IPsiSourceFile srcProjectFile, out JetBrains.ReSharper.Psi.Tree.IFile dstPsiFile, out string namespaceName) { }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecuteAfterPsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.ProjectModel.IProjectModelTransactionCookie cookie, JetBrains.Application.Progress.IProgressIndicator progress) { }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
    }
    public abstract class CreateTypeQuickFixBase : JetBrains.ReSharper.Intentions.Xaml.QuickFixes.XamlQuickFix
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        protected readonly JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.ITypeTarget CreationTarget;
        [JetBrains.Annotations.CanBeNullAttribute()]
        protected readonly JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.SimpleTypeImage ExpectedTypes;
        [JetBrains.Annotations.CanBeNullAttribute()]
        protected readonly JetBrains.ReSharper.Psi.Xaml.Tree.IXamlTypeReference Reference;
        [JetBrains.Annotations.NotNullAttribute()]
        protected readonly System.Collections.Generic.List<string> TargetNamespaces;
        [JetBrains.Annotations.CanBeNullAttribute()]
        protected readonly JetBrains.ProjectModel.IProject TargetProject;
        protected CreateTypeQuickFixBase(JetBrains.ReSharper.Daemon.Xaml.Highlightings.XamlTypeNotResolvedError error, string text) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.QuickFixAttribute()]
    public class CreateXamlTypeQuickFix : JetBrains.ReSharper.Intentions.Xaml.QuickFixes.CreateTypeQuickFixBase
    {
        public CreateXamlTypeQuickFix(JetBrains.ReSharper.Daemon.Xaml.Highlightings.XamlTypeNotResolvedError error) { }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecuteAfterPsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.ProjectModel.IProjectModelTransactionCookie cookie, JetBrains.Application.Progress.IProgressIndicator progress) { }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.QuickFixAttribute()]
    public class CreateXKeyAttributeQuickFix : JetBrains.ReSharper.Intentions.Xaml.QuickFixes.XamlQuickFix
    {
        public CreateXKeyAttributeQuickFix(JetBrains.ReSharper.Daemon.Xaml.Highlightings.XamlXKeyAttributeRequiredHighlighting highlighting) { }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.QuickFixAttribute()]
    public class QualifyPropertyPathTypeFix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public QualifyPropertyPathTypeFix(JetBrains.ReSharper.Daemon.Xaml.Highlightings.XamlBindingWithContextNotResolvedHighlighting highlighting) { }
        public QualifyPropertyPathTypeFix(JetBrains.ReSharper.Daemon.Xaml.Highlightings.XamlBindingWithoutContextNotResolvedHighlighting highlighting) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.QuickFixAttribute()]
    public class RemoveElementQuickFix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public RemoveElementQuickFix(JetBrains.ReSharper.Daemon.Xaml.Highlightings.XamlRedundantNamespaceAliasHighlighting highlighting) { }
        public RemoveElementQuickFix(JetBrains.ReSharper.Daemon.Xaml.Highlightings.XamlRedundantResourceHighlighting highlighting) { }
        public RemoveElementQuickFix(JetBrains.ReSharper.Daemon.Xaml.Highlightings.XamlRedundantFreezeAttributeHighlighting highlighting) { }
        public RemoveElementQuickFix(JetBrains.ReSharper.Daemon.Xaml.Highlightings.XamlRedundantNameAttributeHighlighting highlighting) { }
        public RemoveElementQuickFix(JetBrains.ReSharper.Daemon.Xaml.Highlightings.XamlValueTypeResourceCannotHaveNameHighlighting highlighting) { }
        public RemoveElementQuickFix(JetBrains.ReSharper.Daemon.Xaml.Highlightings.XamlRedundantGridDefinitionsAttributeHighlighting highlighting) { }
        public RemoveElementQuickFix(JetBrains.ReSharper.Daemon.Xaml.Highlightings.XamlRedundantGridSpanAttributeHighlighting highlighting) { }
        public RemoveElementQuickFix(JetBrains.ReSharper.Daemon.Xaml.Highlightings.XamlRedundantCollectionPropertyHighlighting highlighting) { }
        public RemoveElementQuickFix(JetBrains.ReSharper.Daemon.Xaml.Highlightings.XamlRedundantAttachedPropertySetterHighlighting highlighting) { }
        public RemoveElementQuickFix(JetBrains.ReSharper.Daemon.Xaml.Highlightings.XamlRedundantStyledValueHighlighting highlighting) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
        public static void RemoveNode([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode treeNode) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.QuickFixAttribute(typeof(JetBrains.ReSharper.Intentions.Xaml.QuickFixes.RemoveElementQuickFix), JetBrains.Util.BeforeOrAfter.After)]
    public class RemoveMultipleElementsQuickFix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public RemoveMultipleElementsQuickFix([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Daemon.Xaml.Highlightings.XamlRedundantStyledValueHighlighting highlighting) { }
        public RemoveMultipleElementsQuickFix([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Daemon.Xaml.Highlightings.XamlRedundantNamespaceAliasHighlighting highlighting) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.QuickFixAttribute()]
    public class RemoveRangeQuickFix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public RemoveRangeQuickFix(JetBrains.ReSharper.Daemon.Xaml.Highlightings.XamlRedundantPropertyTypeQualifierHighlighting highlighting) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.QuickFixAttribute()]
    public class SpecifyDataContextTypeQuickFix : JetBrains.ReSharper.Intentions.Extensibility.IQuickFix
    {
        public SpecifyDataContextTypeQuickFix([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Daemon.Xaml.Highlightings.XamlBindingWithContextNotResolvedHighlighting error) { }
        public SpecifyDataContextTypeQuickFix([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Daemon.Xaml.Highlightings.XamlBindingWithoutContextNotResolvedHighlighting error) { }
        public JetBrains.ReSharper.Intentions.Extensibility.IBulbAction[] Items { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        public bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
        protected static bool IsTopLevelBindingPropertyReference(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.QuickFixAttribute()]
    public class XamlChangePathMappingQuickFix : JetBrains.ReSharper.Intentions.Extensibility.IQuickFix
    {
        public XamlChangePathMappingQuickFix(JetBrains.ReSharper.Daemon.Xaml.Highlightings.XamlPathWarningHighlighting highlighting) { }
        protected XamlChangePathMappingQuickFix(JetBrains.ReSharper.Psi.Xaml.Tree.IXamlPathReference pathReferecne) { }
        public JetBrains.ReSharper.Intentions.Extensibility.IBulbAction[] Items { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        public bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.QuickFixAttribute()]
    public class XamlCreatePropertyQuickFix : JetBrains.ReSharper.Intentions.Extensibility.IQuickFix
    {
        public XamlCreatePropertyQuickFix([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Daemon.Xaml.Highlightings.XamlNotResolvedError error) { }
        public XamlCreatePropertyQuickFix([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Daemon.Xaml.Highlightings.XamlBindingWithContextNotResolvedHighlighting error) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        protected virtual JetBrains.Util.Pair<JetBrains.ReSharper.Psi.Tree.ITypeDeclaration, TIntention> GetTargetDeclaration<TIntention>(JetBrains.ReSharper.Psi.Resolve.IReference reference)
            where TIntention :  class { }
        public bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.QuickFixAttribute()]
    public class XamlCreateTypeMemberQuickFix : JetBrains.ReSharper.Intentions.Extensibility.IQuickFix
    {
        public XamlCreateTypeMemberQuickFix([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Daemon.Xaml.Highlightings.XamlNotResolvedError highlighting) { }
        public XamlCreateTypeMemberQuickFix([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Daemon.Xaml.Highlightings.XamlBindingWithContextNotResolvedHighlighting highlighting) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        [JetBrains.Annotations.ContractAnnotationAttribute("null=>null")]
        protected virtual JetBrains.ReSharper.Psi.Tree.ITypeDeclaration GetTargetDeclaration([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.QuickFixAttribute()]
    public class XamlImportPathQuickFix : JetBrains.ReSharper.Intentions.Extensibility.IQuickFix
    {
        public XamlImportPathQuickFix(JetBrains.ReSharper.Daemon.Xaml.Highlightings.XamlPathWarningHighlighting highlighting) { }
        public JetBrains.ReSharper.Intentions.Extensibility.IBulbAction[] Items { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        public bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.QuickFixAttribute()]
    public class XamlImportTypeQuickFix : JetBrains.ReSharper.Intentions.Extensibility.IQuickFix
    {
        public XamlImportTypeQuickFix(JetBrains.ReSharper.Daemon.Xaml.Highlightings.XamlTypeNotResolvedError error) { }
        public XamlImportTypeQuickFix(JetBrains.ReSharper.Daemon.Xaml.Highlightings.XamlNotResolvedLateBoundHighlighting error) { }
        protected virtual string ItemFormat { get; }
        public JetBrains.ReSharper.Intentions.Extensibility.IBulbAction[] Items { get; }
        protected JetBrains.ReSharper.Psi.Xaml.Tree.IXamlTypeReference Reference { get; }
        protected virtual JetBrains.ReSharper.Intentions.Xaml.QuickFixes.XamlImportTypeQuickFixItem CreateBulbItem(JetBrains.ReSharper.Psi.ITypeElement element, System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.Xaml.Tree.IXamlTypeReference> references) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        protected virtual System.Collections.Generic.List<JetBrains.ReSharper.Psi.ITypeElement> EvaluateAlternatives() { }
        protected System.Collections.Generic.List<JetBrains.ReSharper.Psi.ITypeElement> EvaluateAlternatives(JetBrains.ReSharper.Psi.Xaml.Tree.IXamlTypeReference reference, JetBrains.ReSharper.Psi.Caches.ISymbolScope symbolScope) { }
        public static System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.ITypeElement> GetAlternatives(JetBrains.ReSharper.Psi.Xaml.Tree.IXamlTypeReference typeReference) { }
        public bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public class XamlImportTypeQuickFixItem : JetBrains.ReSharper.Intentions.Extensibility.BulbActionBase
    {
        public XamlImportTypeQuickFixItem(JetBrains.ReSharper.Psi.ITypeElement element, System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.Xaml.Tree.IXamlTypeReference> references, string importFormat) { }
        protected System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.Xaml.Tree.IXamlTypeReference> References { get; }
        public override string Text { get; }
        public JetBrains.ReSharper.Psi.ITypeElement TypeElement { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.QuickFixAttribute()]
    public class XamlIncludeProjectItemQuickFix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public XamlIncludeProjectItemQuickFix(JetBrains.ReSharper.Daemon.Xaml.Highlightings.XamlPathWarningHighlighting highlighting) { }
        public override string Text { get; }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecuteAfterPsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.ProjectModel.IProjectModelTransactionCookie cookie, JetBrains.Application.Progress.IProgressIndicator progress) { }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ProjectModel.IProjectFolder LocateProjectFolder([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Resolve.IFileReference reference) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.QuickFixAttribute()]
    public class XamlLanguageLevelQuickFix : JetBrains.ReSharper.Intentions.Extensibility.IQuickFix
    {
        public XamlLanguageLevelQuickFix(JetBrains.ReSharper.Daemon.Xaml.Highlightings.XamlLanguageLevelResolveErrorHighlighting highlighting) { }
        public XamlLanguageLevelQuickFix(JetBrains.ReSharper.Daemon.Xaml.Highlightings.XamlLanguageLevelErrorHighlighting highlighting) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        public bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.QuickFixAttribute()]
    public class XamlMethodQuickFix : JetBrains.ReSharper.Intentions.Extensibility.IQuickFix
    {
        public XamlMethodQuickFix(JetBrains.ReSharper.Daemon.Xaml.Highlightings.XamlMethodErrorHiglighting higlighting) { }
        public XamlMethodQuickFix(JetBrains.ReSharper.Daemon.Xaml.Highlightings.XamlConstructorWarningHiglighting higlighting) { }
        public JetBrains.ReSharper.Intentions.Extensibility.IBulbAction[] Items { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        public bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
    public abstract class XamlQuickFix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        protected XamlQuickFix(string text) { }
        public override string Text { get; }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.QuickFixAttribute()]
    public class XamlReferenceModuleAndImportTypeQuickFix : JetBrains.ReSharper.Intentions.Xaml.QuickFixes.XamlImportTypeQuickFix
    {
        public XamlReferenceModuleAndImportTypeQuickFix(JetBrains.ReSharper.Daemon.Xaml.Highlightings.XamlTypeNotResolvedError error) { }
        public XamlReferenceModuleAndImportTypeQuickFix(JetBrains.ReSharper.Daemon.Xaml.Highlightings.XamlNotResolvedLateBoundHighlighting error) { }
        public XamlReferenceModuleAndImportTypeQuickFix(JetBrains.ReSharper.Daemon.Xaml.Highlightings.XamlBindingWithContextNotResolvedHighlighting error) { }
        protected override string ItemFormat { get; }
        protected override JetBrains.ReSharper.Intentions.Xaml.QuickFixes.XamlImportTypeQuickFixItem CreateBulbItem(JetBrains.ReSharper.Psi.ITypeElement element, System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.Xaml.Tree.IXamlTypeReference> references) { }
        protected override System.Collections.Generic.List<JetBrains.ReSharper.Psi.ITypeElement> EvaluateAlternatives() { }
    }
    public class XamlTypeCompletionExpression : JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotExpression, System.ICloneable
    {
        public XamlTypeCompletionExpression() { }
        public XamlTypeCompletionExpression([JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.ITypeElement> possibleTypes) { }
        public object Clone() { }
        public virtual string EvaluateQuickResult(JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotContext context) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Collections.Generic.IList<JetBrains.ReSharper.Psi.ITypeElement> FindPossibleTypes([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Resolve.IReference reference, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
        public virtual JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.HotspotItems GetLookupItems(JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotContext context) { }
        public virtual void HandleExpansion(JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.IHotspotContext context) { }
        public string Serialize() { }
        protected sealed class TypeLookupItem : JetBrains.ReSharper.Feature.Services.Lookup.DeclaredElementLookupItem
        {
            public TypeLookupItem([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.DeclaredElementInstance instance, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Feature.Services.Lookup.IElementPointerFactory pointerFactory, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Feature.Services.Lookup.ILookupItemsOwner owner) { }
            protected override JetBrains.UI.RichText.RichText GetDisplayName() { }
            protected override void OnAfterComplete(JetBrains.TextControl.ITextControl textControl, ref JetBrains.Util.TextRange nameRange, ref JetBrains.Util.TextRange decorationRange, JetBrains.ReSharper.Psi.ExpectedTypes.TailType tailType, ref JetBrains.ReSharper.Feature.Services.Lookup.Suffix suffix, ref JetBrains.DocumentModel.IRangeMarker caretPositionRangeMarker) { }
        }
    }
}
namespace JetBrains.ReSharper.Intentions.Xaml.Util
{
    
    public class static CreateResourceUtil
    {
        public static System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IBulbAction> CreateCreateResourceBulbItems(JetBrains.ReSharper.Psi.Xaml.Tree.IResourceReference resourceReference) { }
    }
    public class CreateTypeUtil
    {
        public static void BindTypeReferences(JetBrains.ReSharper.Psi.Xaml.Tree.IXamlTypeReference xamlTypeReference, JetBrains.ReSharper.Psi.IPsiServices psiServices, JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, JetBrains.ReSharper.Psi.ITypeElement typeElement, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution) { }
        public static JetBrains.ReSharper.Psi.Transactions.TransactionResult CreateType(JetBrains.ProjectModel.IProject projectFileType, JetBrains.ReSharper.Psi.IPsiServices psiServices, JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.ICreationTarget target, string className, bool isPartial, JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.SimpleTypeImage baseTypeImage, out System.Action action) { }
        public static JetBrains.ReSharper.Psi.Tree.ITypeDeclaration FindTypeDeclaration(JetBrains.ReSharper.Psi.Tree.ITreeNode element, [JetBrains.Annotations.NotNullAttribute()] string qualifiedName) { }
    }
}