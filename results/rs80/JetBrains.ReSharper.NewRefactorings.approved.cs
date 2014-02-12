[assembly: JetBrains.ActionManagement.ActionsXmlAttribute("JetBrains.ReSharper.Refactorings.resources.Actions.xml")]
[assembly: JetBrains.UI.Icons.CompiledIcons.CompiledIconsPackAttribute(IconNames=new string[] {
        "Subexpression",
        "RefactorThis"}, IconPackResourceIdentification="JetBrains.ReSharper.NewRefactorings;component/resources/RefactoringsThemedIcons/T" +
    "hemedIcons.Refactorings.Generated.Xaml")]
[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]
[assembly: System.Windows.Markup.XmlnsDefinitionAttribute("urn:shemas-jetbrains-com:ui-application-icons-refactorings", "JetBrains.ReSharper.Refactorings.Resources")]


public class BlockerConstraint : JetBrains.ReSharper.Refactorings.UseBaseType.ConstraintSearch.ConstraintBase
{
    public static BlockerConstraint Instance { get; }
    public override bool IsBlocker { get; }
}
public class DeclaredElementConstraint : JetBrains.ReSharper.Refactorings.UseBaseType.ConstraintSearch.ConstraintBase
{
    public DeclaredElementConstraint(JetBrains.ReSharper.Psi.IDeclaredElement element) { }
    public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IDeclaredElement> ConstraintElements { get; }
    public override bool IsBlocker { get; }
}
public class NoConstraint : JetBrains.ReSharper.Refactorings.UseBaseType.ConstraintSearch.ConstraintBase
{
    public static NoConstraint Instance { get; }
    public override bool IsBlocker { get; }
}
namespace JetBrains.ReSharper.Intentions.Util
{
    
    public class FileSpecificUtil2
    {
        public static JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.ICreateNewFileTarget GetCreationTarget([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ProjectModel.IProjectFile projectFile, [JetBrains.Annotations.CanBeNullAttribute()] string @namespace, [JetBrains.Annotations.NotNullAttribute()] string newName, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.PsiLanguageType language) { }
        public static JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.ICreateNewFileTarget GetCreationTarget([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ProjectModel.IProjectFile projectFile, [JetBrains.Annotations.CanBeNullAttribute()] string @namespace, [JetBrains.Annotations.NotNullAttribute()] string newName, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public static JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.ITypeTarget GetOwnerForTypeMemberDeclaration([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
    }
}
namespace JetBrains.ReSharper.Refactorings.Anotype2DeclaredType
{
    
    public abstract class Anonymous2Declared : JetBrains.ReSharper.Refactorings.Common.RefactoringExecBase<JetBrains.ReSharper.Refactorings.Anotype2DeclaredType.Anonymous2DeclaredWorkflow, JetBrains.ReSharper.Refactorings.Anotype2DeclaredType.Anonymous2DeclaredRefactoring>
    {
        protected Anonymous2Declared(JetBrains.ReSharper.Refactorings.Anotype2DeclaredType.Anonymous2DeclaredWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public abstract void ChangeReference(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.IClass clsss, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution);
        public abstract JetBrains.ReSharper.Psi.IClass CreateClassDeclaration(System.Collections.Generic.IList<JetBrains.ReSharper.Psi.ITypeParameter> usedTypeParameters, ref JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution);
        public abstract System.Collections.Generic.IList<JetBrains.ReSharper.Psi.ITypeParameter> GetUsagedTypeParameters();
        public abstract System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Tree.ITreeNode> SearchForAnonymousTypes(JetBrains.Application.Progress.SubProgressIndicator pi);
    }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "Anonymous2Declared"})]
    public class Anonymous2DeclaredAction : JetBrains.ReSharper.Refactorings.Workflow.ExtensibleRefactoringAction<JetBrains.ReSharper.Refactorings.Anotype2DeclaredType.IAnonymous2DeclaredWorkflowProvider>
    {
        public const string ACTION_ID = "Anonymous2Declared";
        protected override JetBrains.UI.RichText.RichText Caption { get; }
    }
    public class Anonymous2DeclaredRefactoring : JetBrains.ReSharper.Refactorings.Common.DrivenRefactoring<JetBrains.ReSharper.Refactorings.Anotype2DeclaredType.Anonymous2DeclaredWorkflow, JetBrains.ReSharper.Refactorings.Anotype2DeclaredType.Anonymous2Declared>
    {
        public Anonymous2DeclaredRefactoring(JetBrains.ReSharper.Refactorings.Anotype2DeclaredType.Anonymous2DeclaredWorkflow workFlow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ReSharper.Psi.Tree.ITreeNode ObjectCreationElement { get; }
        protected override JetBrains.ReSharper.Refactorings.Anotype2DeclaredType.Anonymous2Declared CreateRefactoringInternal(JetBrains.ReSharper.Refactorings.InternalRefactoringLanguageService service) { }
        protected override JetBrains.ReSharper.Refactorings.Anotype2DeclaredType.Anonymous2Declared CreateUnsupportedRefactoring() { }
        public override bool Execute(JetBrains.Application.Progress.IProgressIndicator pi) { }
    }
    [JetBrains.Application.Settings.SettingsKeyAttribute(typeof(JetBrains.ReSharper.Refactorings.RefactoringsMruSettings), "Anonymous to Declared Type refactoring MRU")]
    public class Anonymous2DeclaredSettings
    {
        [JetBrains.Application.Settings.SettingsEntryAttribute(false, "Generate hashcode")]
        public bool GenerateHashcode;
        [JetBrains.Application.Settings.SettingsEntryAttribute(false, "Generate ToString")]
        public bool GenerateToString;
        [JetBrains.Application.Settings.SettingsEntryAttribute(false, "Place top level")]
        public bool PlaceTopLevel;
        [JetBrains.Application.Settings.SettingsEntryAttribute(true, "Properties pattern")]
        public bool PropertiesPattern;
        [JetBrains.Application.Settings.SettingsEntryAttribute(false, "Search in all solution")]
        public bool SearchInAllSoution;
        [JetBrains.Application.Settings.SettingsEntryAttribute(true, "Show in Find Results")]
        public bool ShowInFindResults;
    }
    public class Anonymous2DeclaredTestDataProvider : JetBrains.ReSharper.Refactorings.Anotype2DeclaredType.IAnonymous2DeclaredDataProvider
    {
        public Anonymous2DeclaredTestDataProvider(bool placeTopLevel, bool searchInAllSoution, bool propertiesPattern, bool generateHashcode, bool generateTostring, bool showInFindresults, string name) { }
        public bool GenerateHashcode { get; }
        public bool GenerateTostring { get; }
        public string Name { get; }
        public bool PlaceTopLevel { get; }
        public bool PropertiesPattern { get; }
        public bool SearchInAllSoution { get; }
        public bool ShowInFindresults { get; }
    }
    public class Anonymous2DeclaredWindow : JetBrains.UI.CommonControls.SafeTableLayoutPanel, JetBrains.CommonControls.Validation.IValidatorProvider, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage
    {
        public Anonymous2DeclaredWindow(JetBrains.ReSharper.Refactorings.Anotype2DeclaredType.Anonymous2DeclaredWorkflow workflow) { }
        public JetBrains.DataFlow.IProperty<bool> ContinueEnabled { get; }
        public string Description { get; }
        public bool DoNotShow { get; }
        public string Title { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.CommonControls.Validation.IValidator> Validators { get; }
        public JetBrains.UI.CrossFramework.EitherControl View { get; }
        public JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage Commit(JetBrains.Application.Progress.IProgressIndicator pi) { }
        public bool Initialize(JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
        public bool RefreshContents(JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
    }
    public class Anonymous2DeclaredWorkflow : JetBrains.ReSharper.Refactorings.Workflow.DrivenRefactoringWorkflow
    {
        public const string TitleString = "Re&place Anonymous Type With Named Class";
        public Anonymous2DeclaredWorkflow(JetBrains.ProjectModel.ISolution solution, string actionId) { }
        public override JetBrains.ReSharper.Refactorings.Workflow.RefactoringActionGroup ActionGroup { get; }
        public System.Collections.Generic.List<JetBrains.ReSharper.Psi.IReferencePointer> ChangedReferences { get; }
        public override JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage FirstPendingRefactoringPage { get; }
        public bool GenerateHashcode { get; set; }
        public bool GenerateTostring { get; set; }
        public override string HelpKeyword { get; }
        public override bool MightModifyManyDocuments { get; }
        public string Name { get; set; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Psi.Tree.ITreeNode ObjectCreationElement { get; }
        public bool PlaceTopLevel { get; set; }
        public bool PropertiesPattern { get; set; }
        public bool SearchInAllSoution { get; set; }
        public bool ShowInFindresults { get; set; }
        public override string Title { get; }
        public bool ClassDoesNotExist(string className) { }
        public override JetBrains.ReSharper.Refactorings.Workflow.IRefactoringExecuter CreateRefactoring(JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public override bool Initialize(JetBrains.Application.DataContext.IDataContext context) { }
        public override bool IsAvailable(JetBrains.Application.DataContext.IDataContext context) { }
        public void SaveSettings() { }
        public void SetProvider(JetBrains.ReSharper.Refactorings.Anotype2DeclaredType.IAnonymous2DeclaredDataProvider provider) { }
        public override void SuccessfulFinish(JetBrains.Application.Progress.IProgressIndicator pi) { }
    }
    public abstract class DefaultAnonymous2DeclaredDataProvider : JetBrains.ReSharper.Refactorings.Anotype2DeclaredType.IAnonymous2DeclaredDataProvider
    {
        public virtual bool GenerateHashcode { get; }
        public virtual bool GenerateTostring { get; }
        public abstract string Name { get; }
        public virtual bool PlaceTopLevel { get; }
        public virtual bool PropertiesPattern { get; }
        public virtual bool SearchInAllSoution { get; }
        public virtual bool ShowInFindresults { get; }
    }
    public interface IAnonymous2DeclaredDataProvider
    {
        bool GenerateHashcode { get; }
        bool GenerateTostring { get; }
        string Name { get; }
        bool PlaceTopLevel { get; }
        bool PropertiesPattern { get; }
        bool SearchInAllSoution { get; }
        bool ShowInFindresults { get; }
    }
    public interface IAnonymous2DeclaredWorkflowProvider : JetBrains.ReSharper.Feature.Services.ActionsMenu.IWorkflowProvider<JetBrains.ReSharper.Refactorings.Workflow.IRefactoringWorkflow, JetBrains.ReSharper.Refactorings.Workflow.RefactoringActionGroup>, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringWorkflowProvider { }
}
namespace JetBrains.ReSharper.Refactorings.Anotype2DeclaredType.Search
{
    
    public class AnotypeUsageSearchDescriptor : JetBrains.ReSharper.Features.Finding.Search.SearchDescriptor
    {
        public AnotypeUsageSearchDescriptor(JetBrains.ReSharper.Feature.Services.Search.SearchRequests.SearchRequest request) { }
        public override string GetResultsTitle(JetBrains.ReSharper.Features.Common.Occurences.OccurenceSection section) { }
    }
    public class AnotypeUsageSearchRequest : JetBrains.ReSharper.Feature.Services.Search.SearchRequests.SearchRequest
    {
        public AnotypeUsageSearchRequest(JetBrains.ProjectModel.ISolution solution) { }
        public override System.Collections.ICollection SearchTargets { get; }
        public override JetBrains.ProjectModel.ISolution Solution { get; }
        public override string Title { get; }
        public void AddOccurence(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ProjectModel.ISolution solution) { }
        public override System.Collections.Generic.ICollection<JetBrains.ReSharper.Feature.Services.Search.IOccurence> Search(JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
    }
}
namespace JetBrains.ReSharper.Refactorings.ChangeSignature.AddParameterWorkItems
{
    
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "AddParameterLocal"})]
    public class AddLocalParameterAction : JetBrains.ReSharper.Refactorings.PushPullValue.ContextActions.WorkItemContextActionBase
    {
        public const string ACTION_ID = "AddParameterLocal";
        protected override JetBrains.UI.RichText.RichText Caption { get; }
    }
    public class ChangeSignatureParameterWorkItem : JetBrains.ReSharper.Refactorings.PushPullValue.Nodes.FixableWorkItem
    {
        public ChangeSignatureParameterWorkItem(JetBrains.ReSharper.Refactorings.ChangeSignature.ChangeSignatureParameter parameter, JetBrains.ReSharper.Psi.IDeclaredElement parametersOwner, int offset, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.PushPullValue.WorkItemsSession session) { }
        public JetBrains.ReSharper.Psi.IDeclaredElement InvocationOwner { get; }
        public JetBrains.ReSharper.Refactorings.ChangeSignature.ChangeSignatureParameter Parameter { get; }
        public JetBrains.ReSharper.Psi.IReferencePointer ParameterPointer { get; }
        public override JetBrains.ReSharper.Psi.PsiLanguageType PresentationLanguage { get; }
        public override bool Contains(JetBrains.DocumentModel.IDocument document, int offset) { }
    }
    public class ChangeSignatureWorkItem : JetBrains.ReSharper.Refactorings.PushPullValue.Nodes.FixableWorkItem
    {
        public ChangeSignatureWorkItem(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Refactorings.ChangeSignature.ChangeSignatureModel model) { }
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Refactorings.PushPullValue.Nodes.IWorkItemNode> Children { get; }
        public JetBrains.ReSharper.Refactorings.ChangeSignature.ChangeSignatureModel Model { get; }
        public override JetBrains.ReSharper.Psi.PsiLanguageType PresentationLanguage { get; }
        public JetBrains.ReSharper.Psi.IReferencePointer ReferencePointer { get; set; }
        public override bool Contains(JetBrains.DocumentModel.IDocument document, int caretOffset) { }
        public override bool Navigate(bool transferFocus) { }
    }
}
namespace JetBrains.ReSharper.Refactorings.ChangeSignature.AddParameterWorkItems.Fixes
{
    
    [JetBrains.ReSharper.Refactorings.PushPullValue.Nodes.WorkItemFixAttribute()]
    public class AddDefaultValueFix : JetBrains.ReSharper.Refactorings.PushPullValue.Nodes.WorkItemFixBase
    {
        public override string Description { get; }
        protected override bool Execute(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Refactorings.PushPullValue.Nodes.IWorkItemNode> workItems, JetBrains.ProjectModel.ISolution solution) { }
        public override bool IsAvailable(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Refactorings.PushPullValue.Nodes.IWorkItemNode> workItems) { }
    }
    [JetBrains.ReSharper.Refactorings.PushPullValue.Nodes.WorkItemFixAttribute()]
    public class UseExistingEntityFix : JetBrains.ReSharper.Refactorings.PushPullValue.Nodes.WorkItemFixBase
    {
        public override string Description { get; }
        protected override bool Execute(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Refactorings.PushPullValue.Nodes.IWorkItemNode> workItems, JetBrains.ProjectModel.ISolution solution) { }
        public override bool IsAvailable(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Refactorings.PushPullValue.Nodes.IWorkItemNode> workItems) { }
    }
}
namespace JetBrains.ReSharper.Refactorings.ChangeSignature
{
    
    public class ArgumentInfo
    {
        public ArgumentInfo(int argumentIndex, int parameterIndex, bool isRelativePositioned) { }
        public int ArgumentIndex { get; }
        public bool IsRelativePositioned { get; }
        public int ParameterIndex { get; }
    }
    public abstract class ChangeSignature
    {
        protected bool WasNamed;
        protected abstract JetBrains.ReSharper.Psi.Tree.IArgument AddArgumentAfter(JetBrains.ReSharper.Psi.Tree.IArgumentsOwner owner, JetBrains.ReSharper.Psi.Tree.IArgument argument, JetBrains.ReSharper.Psi.Tree.IArgument tag, JetBrains.ReSharper.Refactorings.ChangeSignature.ChangeSignatureParameter parameter);
        public abstract JetBrains.ReSharper.Psi.IParametersOwner AddDefaultConstructorDeclaration(JetBrains.ReSharper.Psi.IConstructor defaultConstructor);
        public abstract void BindReferenceExpression(JetBrains.ReSharper.Psi.Tree.IExpression expression, JetBrains.ReSharper.Psi.IDeclaredElement element);
        public abstract void ChangeDeclaration(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration, System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Tree.IDeclaration> parameterDeclarations, JetBrains.ReSharper.Refactorings.ChangeSignature.ChangeSignatureModel changeSignatureModel, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution, System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<JetBrains.ReSharper.Psi.Tree.IArgument, JetBrains.ReSharper.Refactorings.ChangeSignature.ChangeSignatureModel.ArgumentAction>> postActionsList);
        protected abstract void ChangeDefaultConstructor(JetBrains.ReSharper.Psi.IConstructor inheritorConstructor, JetBrains.ReSharper.Refactorings.ChangeSignature.ChangeSignatureModel model, System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<JetBrains.ReSharper.Psi.Tree.IArgument, JetBrains.ReSharper.Refactorings.ChangeSignature.ChangeSignatureModel.ArgumentAction>> postActions);
        public abstract bool CheckIfMethodGroup(JetBrains.ReSharper.Psi.Tree.ITreeNode element);
        public abstract JetBrains.ReSharper.Psi.Tree.IArgument CreateArgument(JetBrains.ReSharper.Psi.Tree.ITreeNode context, bool isInternal, JetBrains.ReSharper.Psi.ParameterKind parameterKind, string parameterName, JetBrains.ReSharper.Refactorings.ChangeSignature.IParameterValue defaultValue, out JetBrains.ReSharper.Refactorings.ChangeSignature.ChangeSignatureModel.ArgumentAction postAction);
        public abstract JetBrains.ReSharper.Psi.Tree.IExpression CreateExpression(string text, JetBrains.ReSharper.Psi.Modules.IPsiModule module);
        public abstract JetBrains.ReSharper.Refactorings.ChangeSignature.ChangeSignatureModel CreateModel(JetBrains.ReSharper.Psi.IParametersOwner owner, JetBrains.Application.Progress.IProgressIndicator progressIndicator = null);
        public abstract JetBrains.ReSharper.Refactorings.ChangeSignature.ChangeSignatureModel CreateModel(JetBrains.ReSharper.Psi.IParametersOwner parametersOwner, JetBrains.ReSharper.Refactorings.PushPullTool.Fixes.FixNode fix, JetBrains.Application.Progress.IProgressIndicator progressIndicator);
        public abstract JetBrains.ReSharper.Psi.Tree.IParameterDeclaration CreateParameterDeclaration(JetBrains.ReSharper.Psi.Modules.IPsiModule module, string name, JetBrains.ReSharper.Psi.IType type, JetBrains.ReSharper.Psi.ParameterKind parameterKind, bool isParams, bool isVarArg, JetBrains.ReSharper.Psi.Tree.IDeclaration originalDeclaration, bool isThis, JetBrains.ReSharper.Refactorings.ChangeSignature.IParameterValue defaultValue, JetBrains.ReSharper.Refactorings.ChangeSignature.ChangeSignatureModel model);
        public abstract void CreateProxy(JetBrains.ReSharper.Refactorings.ChangeSignature.ChangeSignatureModel changeSignatureModel, System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<JetBrains.ReSharper.Psi.Tree.IArgument, JetBrains.ReSharper.Refactorings.ChangeSignature.ChangeSignatureModel.ArgumentAction>> postActionsList);
        public abstract JetBrains.ReSharper.Psi.Tree.IExpression CreateReferenceExpression(string name, JetBrains.ReSharper.Psi.Modules.IPsiModule module);
        public abstract JetBrains.ReSharper.Psi.Tree.IExpression CreateThisExpression(JetBrains.ReSharper.Psi.Modules.IPsiModule module);
        [JetBrains.Annotations.CanBeNullAttribute()]
        public abstract JetBrains.ReSharper.Psi.ILocalVariable DeclareLocalVariable(string variableName, JetBrains.ReSharper.Psi.IType variableType, ref JetBrains.ReSharper.Psi.Tree.IExpression beforeExpression, JetBrains.ReSharper.Refactorings.ChangeSignature.IElementsSet elementsToKeep);
        public abstract System.Collections.Generic.Dictionary<int, JetBrains.ReSharper.Refactorings.ChangeSignature.ArgumentInfo> GetArgumentInfos(JetBrains.ReSharper.Psi.Resolve.IReference reference, bool isExtentionCall, JetBrains.ReSharper.Psi.Tree.IArgumentsOwner owner);
        public abstract bool IsAvailable(JetBrains.ReSharper.Psi.IParametersOwner owner);
        public abstract bool IsExtensionCallReference(JetBrains.ReSharper.Psi.Resolve.IReference reference);
        public virtual bool IsIngoredInternal(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public abstract bool IsLocalEqualToFieldOrAutoProperty(JetBrains.ReSharper.Psi.ITypeMember fieldOrProperty, JetBrains.ReSharper.Psi.IDeclaredElement local, JetBrains.ReSharper.Psi.Tree.ITreeNode place);
        public void ProcessDefaultConstructor(JetBrains.ReSharper.Psi.IConstructor constructor, JetBrains.ReSharper.Refactorings.ChangeSignature.ChangeSignatureModel model, System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<JetBrains.ReSharper.Psi.Tree.IArgument, JetBrains.ReSharper.Refactorings.ChangeSignature.ChangeSignatureModel.ArgumentAction>> postActions) { }
        public abstract void RemoveArgument(JetBrains.ReSharper.Psi.Tree.IArgumentsOwner argumentsOwner, JetBrains.ReSharper.Psi.Tree.IArgument toRemove);
        public void ReplaceAllArguments(JetBrains.ReSharper.Psi.Tree.IArgumentsOwner owner, System.Collections.Generic.Dictionary<int, System.Collections.Generic.List<JetBrains.ReSharper.Refactorings.ChangeSignature.ChangeSignatureModel.ArgumentInfo>> arguments, System.Collections.Generic.List<JetBrains.ReSharper.Refactorings.ChangeSignature.ChangeSignatureParameter> changeSignatureParameters, System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<JetBrains.ReSharper.Psi.Tree.IArgument, JetBrains.ReSharper.Refactorings.ChangeSignature.ChangeSignatureModel.ArgumentAction>> postActionsList) { }
        protected abstract JetBrains.ReSharper.Psi.Tree.IArgument ReplaceBy(JetBrains.ReSharper.Psi.Tree.IArgument argument, JetBrains.ReSharper.Psi.Tree.IArgument sharpArgument, JetBrains.ReSharper.Refactorings.ChangeSignature.ChangeSignatureParameter parameter);
    }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "ChangeSignature"})]
    public class ChangeSignatureAction : JetBrains.ReSharper.Refactorings.Workflow.ExtensibleRefactoringAction<JetBrains.ReSharper.Refactorings.ChangeSignature.IChangeSignatureWorkflowProvider>
    {
        public const string ACTION_ID = "ChangeSignature";
        protected override JetBrains.UI.RichText.RichText Caption { get; }
    }
    public class ChangeSignatureHierarchyConflictTextProvider : JetBrains.ReSharper.Refactorings.Conflicts.HierarchyConflictTextProviderBase
    {
        public override string QuasiImplements() { }
        public override string WillAlsoImplement() { }
        public override string WillAlsoOverride() { }
    }
    public abstract class ChangeSignatureModel : JetBrains.ReSharper.Feature.Services.Util.ITypeValidator, System.ICloneable
    {
        protected readonly System.Collections.Generic.List<JetBrains.ReSharper.Refactorings.ChangeSignature.ChangeSignatureParameter> myChangeSignatureParameters;
        protected System.Collections.Generic.List<JetBrains.ReSharper.Psi.IDeclaredElement> myImplicitReferences;
        protected ChangeSignatureModel(JetBrains.ReSharper.Psi.IParametersOwner parametersOwner, bool isClone, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.Application.Progress.IProgressIndicator progressIndicator, JetBrains.ReSharper.Feature.Services.Util.ITypeValidator typeValidator) { }
        public System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<JetBrains.ReSharper.Psi.IParametersOwner, JetBrains.ReSharper.Psi.Resolve.ISubstitution>> AllParametersOwners { get; }
        public JetBrains.ReSharper.Refactorings.ChangeSignature.ChangeSignatureParameter[] ChangeSignatureParameters { get; }
        public bool CreateProxy { get; set; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Refactorings.PushPullTool.Fixes.FixNode> Fixes { get; set; }
        public bool HadParams { get; }
        public bool HadThis { get; }
        public bool IsValid { get; }
        public JetBrains.ReSharper.Psi.PsiLanguageType Language { get; }
        public bool ModifiersAreAllowed { get; }
        public string Name { get; set; }
        public JetBrains.ReSharper.Psi.IParametersOwner ParametersOwner { get; }
        public string TypeName { get; set; }
        public JetBrains.ReSharper.Psi.Tree.ITreeNode TypeResolutionPoint { get; }
        public void Add(int index) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public abstract System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Tree.IDeclaration> BuildParameters(JetBrains.ReSharper.Psi.IParametersOwner parametersOwner, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution);
        public virtual bool CanChangeName() { }
        public virtual bool CanChangeSignature() { }
        public virtual bool CanChangeType() { }
        public abstract bool CanMoveDown(int index);
        public bool CanMoveUp(int index) { }
        public virtual void ChangeImplicitReferences(System.Action<JetBrains.ReSharper.Psi.Resolve.IReference> action) { }
        public void ChangeReference(JetBrains.ReSharper.Psi.Tree.IArgumentsOwner argumentsOwner, bool isInternal, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Refactorings.ChangeSignature.RebindableReference rebindableReference, System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<JetBrains.ReSharper.Psi.Tree.IArgument, JetBrains.ReSharper.Refactorings.ChangeSignature.ChangeSignatureModel.ArgumentAction>> postActionsList) { }
        public bool CheckNeedsDefaultValuesForNewParameters(JetBrains.Application.Progress.IProgressIndicator pi) { }
        public abstract object Clone();
        public abstract bool ConflictsWithOtherInstance(JetBrains.ReSharper.Psi.TypeMemberInstance typeMemberInstance);
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Refactorings.ChangeSignature.ChangeSignatureModel CreateModel(JetBrains.ReSharper.Psi.IParametersOwner parametersOwner, JetBrains.ReSharper.Refactorings.PushPullTool.Fixes.FixNode fix, JetBrains.Application.Progress.IProgressIndicator progressIndicator = null) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Refactorings.ChangeSignature.ChangeSignatureModel CreateModel(JetBrains.ReSharper.Psi.IParametersOwner parametersOwner, JetBrains.Application.Progress.IProgressIndicator progressIndicator = null) { }
        public void FindReferences(System.Predicate<JetBrains.ReSharper.Psi.Resolve.IReference> referenceHandler, System.Predicate<JetBrains.ReSharper.Refactorings.ChangeSignature.RebindableReference> rebindableReferenceHandler, JetBrains.Application.Progress.IProgressIndicator pi, bool changeRef) { }
        public abstract JetBrains.ReSharper.Psi.Tree.IArgumentsOwner GetCallPreview(JetBrains.ReSharper.Psi.Tree.IArgumentsOwner call, JetBrains.ReSharper.Refactorings.ChangeSignature.ChangeSignatureParameter changeSignatureParameter, JetBrains.ReSharper.Psi.IDeclaredElement parameter);
        public string GetErrors() { }
        public int GetIndex(JetBrains.ReSharper.Refactorings.ChangeSignature.ChangeSignatureParameter changeSignatureParameter) { }
        public virtual string GetOptionalDescription() { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public abstract string GetParameterKindDescription(JetBrains.ReSharper.Psi.ParameterKind kind, bool isParams = False, bool isVarArg = False, bool isThis = False);
        public abstract string GetPreview();
        public JetBrains.ReSharper.Psi.IType GetReturnType(JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution) { }
        public static System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.DeclaredElementInstance<JetBrains.ReSharper.Psi.ITypeOwner>> GetSuitableVariables(JetBrains.ReSharper.Psi.Tree.ITreeNode context, JetBrains.ReSharper.Psi.IType type) { }
        public abstract JetBrains.ReSharper.Feature.Services.Psi.IUnresolvedTypesChooser GetUnresolvedTypesChooser(JetBrains.ReSharper.Psi.Tree.ITreeNode context);
        public virtual bool HasHandler(JetBrains.ReSharper.Psi.IMethod method) { }
        public bool HasUnsafeTypes() { }
        public void Initialize() { }
        protected virtual bool IsUnsafeType(JetBrains.ReSharper.Psi.IType type) { }
        public bool IsValidExpression(string expr) { }
        public bool IsValidName(string name) { }
        public bool IsValidParameterType(string type) { }
        public bool IsValidReturnType(string type) { }
        public void MoveDown(int parameterIndex) { }
        public void MoveUp(int parameterIndex) { }
        public virtual string PresentDefaultValue(JetBrains.ReSharper.Psi.IParameter value) { }
        public void ReloadFixes() { }
        public bool Removable(int index) { }
        public void Remove(int index) { }
        protected virtual void SetArgumentKind(JetBrains.ReSharper.Psi.Tree.IArgument argument, JetBrains.ReSharper.Psi.ParameterKind kind) { }
        public void SetBaseReturnType(JetBrains.ReSharper.Psi.IType value) { }
        public virtual string ToString() { }
        public delegate void ArgumentAction(JetBrains.ReSharper.Psi.Tree.IArgument argument, JetBrains.ReSharper.Refactorings.ChangeSignature.IElementsSet elementsToKeep);
        public class ArgumentInfo
        {
            public readonly JetBrains.ReSharper.Psi.Tree.IArgument Argument;
            public readonly int OldIndex;
            public readonly JetBrains.ReSharper.Refactorings.ChangeSignature.ChangeSignatureModel.ArgumentAction PostAction;
            public ArgumentInfo(JetBrains.ReSharper.Psi.Tree.IArgument argument, JetBrains.ReSharper.Refactorings.ChangeSignature.ChangeSignatureModel.ArgumentAction postAction) { }
            public ArgumentInfo(JetBrains.ReSharper.Psi.Tree.IArgument argument, int oldIndex) { }
        }
    }
    public class ChangeSignatureParameter
    {
        public ChangeSignatureParameter(JetBrains.ReSharper.Refactorings.ChangeSignature.ChangeSignatureModel model, int index) { }
        public ChangeSignatureParameter(JetBrains.ReSharper.Refactorings.ChangeSignature.ChangeSignatureModel model, JetBrains.ReSharper.Psi.IParameter parameter) { }
        public JetBrains.ReSharper.Refactorings.ChangeSignature.IParameterValue DefaultValue { get; set; }
        public bool IsOptional { get; set; }
        public bool IsParams { get; set; }
        public bool IsThis { get; set; }
        public bool IsVarArg { get; set; }
        public JetBrains.ReSharper.Refactorings.ChangeSignature.ChangeSignatureModel Model { get; }
        public string OriginalName { get; }
        public int OriginalParameterIndex { get; }
        public JetBrains.ReSharper.Psi.IType OriginalParameterType { get; }
        public JetBrains.ReSharper.Psi.Tree.IParameterDeclaration ParameterDeclaration { get; set; }
        public JetBrains.ReSharper.Psi.Tree.IDeclaration ParameterDeclarationCopy { get; }
        public int ParameterIndex { get; }
        public JetBrains.ReSharper.Psi.ParameterKind ParameterKind { get; set; }
        public string ParameterModifierString { get; set; }
        public string ParameterName { get; set; }
        public JetBrains.ReSharper.Psi.IType ParameterType { get; set; }
        public string TypeName { get; set; }
        public string CheckIsValid() { }
        public bool Equals(JetBrains.ReSharper.Refactorings.ChangeSignature.ChangeSignatureParameter changeSignatureParameter) { }
        public JetBrains.ReSharper.Psi.Tree.IArgumentsOwner GetCallPreview(JetBrains.ReSharper.Psi.Tree.IArgumentsOwner call, JetBrains.ReSharper.Psi.IDeclaredElement parameter) { }
    }
    public class ChangeSignatureRefactoring
    {
        public ChangeSignatureRefactoring(JetBrains.ReSharper.Refactorings.ChangeSignature.ChangeSignatureModel model) { }
        public void Execute(JetBrains.Application.Progress.IProgressIndicator pi) { }
        public JetBrains.ReSharper.Refactorings.Conflicts.IConflictSearcher GetConflictSearcher() { }
        public System.Collections.Generic.IEnumerable<JetBrains.DocumentModel.IDocument> GetDocuments() { }
        public static bool IsAvailable(JetBrains.ReSharper.Psi.IParametersOwner parametersOwner) { }
    }
    public class ChangeSignatureRefactoringWorkflow : JetBrains.ReSharper.Refactorings.Workflow.RefactoringWorkflowBase
    {
        public override JetBrains.ReSharper.Refactorings.Workflow.RefactoringActionGroup ActionGroup { get; }
        public override string ActionId { get; }
        public override JetBrains.ReSharper.Refactorings.Conflicts.IConflictSearcher ConflictSearcher { get; }
        public JetBrains.ReSharper.Refactorings.ChangeSignature.IChangeSignatureTestData Data { get; set; }
        public override JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage FirstPendingRefactoringPage { get; }
        public override bool HasUI { get; }
        public override string HelpKeyword { get; }
        public override JetBrains.UI.Icons.IconId Icon { get; }
        public JetBrains.ReSharper.Psi.PsiLanguageType LanguageType { get; }
        public override bool MightModifyManyDocuments { get; }
        public override JetBrains.ProjectModel.ISolution Solution { get; }
        public override string Title { get; }
        public override bool Execute(JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
        public static JetBrains.ReSharper.Refactorings.ChangeSignature.Impl.UnresolvedTypeFactory GetUnresolvedTypeFactory(JetBrains.ReSharper.Refactorings.ChangeSignature.ChangeSignatureModel changeSignatureModel) { }
        public override bool Initialize(JetBrains.Application.DataContext.IDataContext context) { }
        public override bool IsAvailable(JetBrains.Application.DataContext.IDataContext context) { }
        public override bool PostExecute(JetBrains.Application.Progress.IProgressIndicator pi) { }
        public override bool PreExecute(JetBrains.Application.Progress.IProgressIndicator taskExecutorCreator) { }
        public static void ResolveTypes(JetBrains.ReSharper.Refactorings.ChangeSignature.ChangeSignatureModel model, JetBrains.ReSharper.Refactorings.ChangeSignature.Impl.UnresolvedTypeFactory unresolvedTypeFactory) { }
        public override void SuccessfulFinish(JetBrains.Application.Progress.IProgressIndicator pi) { }
    }
    public class CreateNewLocalParameterValue : JetBrains.ReSharper.Refactorings.ChangeSignature.IParameterValue
    {
        public CreateNewLocalParameterValue(JetBrains.ReSharper.Psi.IType type, string parameterName, JetBrains.ReSharper.Psi.PsiLanguageType language, JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
        public JetBrains.ReSharper.Psi.Tree.IExpression CreateExpression(JetBrains.ReSharper.Psi.Tree.ITreeNode context, out JetBrains.ReSharper.Refactorings.ChangeSignature.ExpressionAction postAction) { }
    }
    public abstract class DeclareLocalVariableHelper<TStatement, TDeclarationStatement>
        where TStatement :  class, JetBrains.ReSharper.Psi.Tree.ITreeNode
        where TDeclarationStatement :  class, TStatement
    {
        protected abstract TDeclarationStatement CreateDeclarationStatement(JetBrains.ReSharper.Psi.Modules.IPsiModule module, JetBrains.ReSharper.Psi.IType variableType, string variableName);
        public JetBrains.ReSharper.Psi.ILocalVariable DeclareLocalVariable(string variableName, JetBrains.ReSharper.Psi.IType variableType, ref JetBrains.ReSharper.Psi.Tree.IExpression beforeExpression, JetBrains.ReSharper.Refactorings.ChangeSignature.IElementsSet elementsToKeep) { }
        protected abstract JetBrains.ReSharper.Psi.ILocalVariable GetDeclaredVariable(TDeclarationStatement statement);
        protected abstract TDeclarationStatement InsertDeclarationStatement(TDeclarationStatement statement, ref TStatement beforeStatement);
    }
    public class DefaultValueOfType : JetBrains.ReSharper.Refactorings.ChangeSignature.IParameterValue
    {
        public DefaultValueOfType(JetBrains.ReSharper.Psi.IType type) { }
        public string Text { get; }
        public JetBrains.ReSharper.Psi.Tree.IExpression CreateExpression(JetBrains.ReSharper.Psi.Tree.ITreeNode context, out JetBrains.ReSharper.Refactorings.ChangeSignature.ExpressionAction postAction) { }
        public JetBrains.ReSharper.Psi.Tree.IExpression CreateExpression(JetBrains.ReSharper.Psi.Modules.IPsiModule module) { }
    }
    public delegate void ExpressionAction(JetBrains.ReSharper.Psi.Tree.IExpression expression, JetBrains.ReSharper.Refactorings.ChangeSignature.IElementsSet elementsToKeep);
    public interface IChangeSignatureTestData
    {
        bool HasPostExecute { get; }
        void Execute(JetBrains.ReSharper.Refactorings.ChangeSignature.ChangeSignatureModel model);
        void UpdateModel(ref JetBrains.ReSharper.Refactorings.ChangeSignature.ChangeSignatureModel model);
    }
    public interface IChangeSignatureWorkflowProvider : JetBrains.ReSharper.Feature.Services.ActionsMenu.IWorkflowProvider<JetBrains.ReSharper.Refactorings.Workflow.IRefactoringWorkflow, JetBrains.ReSharper.Refactorings.Workflow.RefactoringActionGroup>, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringWorkflowProvider { }
    public interface IElementsSet
    {
        bool Contains(JetBrains.ReSharper.Psi.Tree.ITreeNode element);
        void Replace(JetBrains.ReSharper.Psi.Tree.ITreeNode oldElement, JetBrains.ReSharper.Psi.Tree.ITreeNode newElement);
    }
    public interface IParameterValue
    {
        JetBrains.ReSharper.Psi.Tree.IExpression CreateExpression(JetBrains.ReSharper.Psi.Tree.ITreeNode context, out JetBrains.ReSharper.Refactorings.ChangeSignature.ExpressionAction postAction);
    }
    public class NonCompilableParameterValue : JetBrains.ReSharper.Refactorings.ChangeSignature.IParameterValue
    {
        public static readonly JetBrains.ReSharper.Refactorings.ChangeSignature.NonCompilableParameterValue INSTANCE;
        public string Text { get; }
        public JetBrains.ReSharper.Psi.Tree.IExpression CreateExpression(JetBrains.ReSharper.Psi.Tree.ITreeNode context, out JetBrains.ReSharper.Refactorings.ChangeSignature.ExpressionAction postAction) { }
    }
    public class RebindableReference
    {
        public RebindableReference(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.IDeclaredElement resolved, bool isInternal, System.Collections.Generic.Dictionary<int, JetBrains.ReSharper.Refactorings.ChangeSignature.ArgumentInfo> argumentInfo) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public System.Collections.Generic.Dictionary<int, JetBrains.ReSharper.Refactorings.ChangeSignature.ArgumentInfo> ArgumentInfo { get; }
        public bool IsInternal { get; }
        public JetBrains.ReSharper.Psi.Resolve.IReference Reference { get; set; }
        public void ReBind() { }
    }
    public class StartingFixNode : JetBrains.ReSharper.Refactorings.PushPullTool.Fixes.FixNode
    {
        public StartingFixNode(JetBrains.ReSharper.Psi.IDeclaredElement owner, JetBrains.ReSharper.Refactorings.ChangeSignature.ChangeSignatureParameter parameter, JetBrains.ReSharper.Refactorings.PushPullTool.PullParameterSession session) { }
        public override void CreateParentNodes(JetBrains.ReSharper.Psi.IParametersOwner parametersOwner, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Resolve.IReference> references) { }
        public override bool ExecuteFix(JetBrains.Application.Progress.IProgressIndicator pi) { }
        public override JetBrains.ReSharper.Refactorings.PushPullTool.Fixes.FixPresentation GetPresentation(JetBrains.ReSharper.Refactorings.PushPullTool.CallPresentation callpresentation) { }
    }
    public class TextParameterValue : JetBrains.ReSharper.Refactorings.ChangeSignature.IParameterValue
    {
        public TextParameterValue(string text) { }
        public string Text { get; }
        public JetBrains.ReSharper.Psi.Tree.IExpression CreateExpression(JetBrains.ReSharper.Psi.Tree.ITreeNode context, out JetBrains.ReSharper.Refactorings.ChangeSignature.ExpressionAction postAction) { }
    }
    public class UniqueValueOfTypeParameterValue : JetBrains.ReSharper.Refactorings.ChangeSignature.IParameterValue
    {
        public UniqueValueOfTypeParameterValue(JetBrains.ReSharper.Psi.IType type) { }
        public string Text { get; }
        public JetBrains.ReSharper.Psi.Tree.IExpression CreateExpression(JetBrains.ReSharper.Psi.Tree.ITreeNode context, out JetBrains.ReSharper.Refactorings.ChangeSignature.ExpressionAction postAction) { }
    }
}
namespace JetBrains.ReSharper.Refactorings.ChangeSignature.Impl
{
    
    public class DefaultParameterValuePage : System.Windows.Forms.UserControl, JetBrains.CommonControls.Validation.IValidatorProvider, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage
    {
        public static JetBrains.ReSharper.Refactorings.ChangeSignature.Impl.DefaultParameterValuePage.Choice DefaultChoice;
        public static JetBrains.ReSharper.Refactorings.ChangeSignature.Impl.DefaultParameterValuePage BuildPagesSequence(JetBrains.ReSharper.Refactorings.ChangeSignature.ChangeSignatureModel model) { }
        protected override void Dispose(bool disposing) { }
        public enum Choice
        {
            NonCompilable = 0,
            DefaultValue = 1,
            UniqueValue = 2,
            CreateLocal = 3,
            SpecifyValue = 4,
            ResolveByTool = 5,
        }
    }
    public sealed class UnresolvedTypeFactory
    {
        public UnresolvedTypeFactory(JetBrains.ReSharper.Feature.Services.Psi.IUnresolvedTypesChooser languageSpecificChooser) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.Psi.UnresolvedDeclaredType> UnresolvedTypes { get; }
        public void CollectUnresolvedTypes(string typeText) { }
        public JetBrains.ReSharper.Psi.IType GetResolvedType(string typeText) { }
    }
}
namespace JetBrains.ReSharper.Refactorings.ChangeStaticness.ToStatic
{
    
    public interface IMakeMethodStaticWorkflowProvider : JetBrains.ReSharper.Feature.Services.ActionsMenu.IWorkflowProvider<JetBrains.ReSharper.Refactorings.Workflow.IRefactoringWorkflow, JetBrains.ReSharper.Refactorings.Workflow.RefactoringActionGroup>, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringWorkflowProvider { }
    public interface IMakeStaticDataProvider
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        string Name { get; }
        JetBrains.ReSharper.Refactorings.ChangeStaticness.ToStatic.Model.ToStaticPolicy Policy { get; }
        bool Show { get; }
        void PreProcessParameters(System.Collections.Generic.IList<JetBrains.ReSharper.Refactorings.ChangeStaticness.ToStatic.Model.ParameterFromExpression> parameters);
    }
    public interface IMakeStaticHelper : JetBrains.ReSharper.Refactorings.IWorkflowExec
    {
        bool CheckElement([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IOverridableMember overridableMember);
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.Tree.ITreeNode GetInvocation([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode element);
        string GetTitle();
        bool IsThis([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode element);
        bool IsWriting([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode element);
    }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "MakeMethodStatic"})]
    public class MakeMethodStaticAction : JetBrains.ReSharper.Refactorings.Workflow.ExtensibleRefactoringAction<JetBrains.ReSharper.Refactorings.ChangeStaticness.ToStatic.IMakeMethodStaticWorkflowProvider>
    {
        public const string ACTION_ID = "MakeMethodStatic";
        protected override JetBrains.UI.RichText.RichText Caption { get; }
    }
    public abstract class MakeStatic : JetBrains.ReSharper.Refactorings.Common.RefactoringExecBase<JetBrains.ReSharper.Refactorings.ChangeStaticness.ToStatic.MakeStaticWorkflow, JetBrains.ReSharper.Refactorings.ChangeStaticness.ToStatic.MakeStaticRefactoring>
    {
        protected MakeStatic(JetBrains.ReSharper.Refactorings.ChangeStaticness.ToStatic.MakeStaticWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public abstract JetBrains.ReSharper.Refactorings.Inline.InlineHelper InlineHelper { get; }
        public abstract void AddArgument(JetBrains.ReSharper.Psi.Resolve.IReference reference, string marker);
        public abstract void AddArgumentAndBind(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.IOverridableMember member, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution, JetBrains.ReSharper.Psi.DisposableMarker marker);
        [JetBrains.Annotations.CanBeNullAttribute()]
        public abstract JetBrains.ReSharper.Psi.IParameter AddParameter([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.IDeclaration declaration, JetBrains.ReSharper.Psi.IType type, string name);
        public abstract void BindTo(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.IOverridableMember member, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution);
        public abstract void CallInline(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Refactorings.Inline.CallSiteContext context, JetBrains.ReSharper.Refactorings.Inline.InlinedCallInfo info, System.Collections.Generic.IList<string> lambdaParameterNames);
        [JetBrains.Annotations.CanBeNullAttribute()]
        public abstract JetBrains.ReSharper.Psi.Resolve.IReference ConvertMethodGroupToLambda([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Resolve.IReference reference, System.Collections.Generic.IList<JetBrains.ReSharper.Psi.IParameter> parameters);
        public abstract void FixOtherArguments(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Refactorings.Inline.InlinedCallInfo info, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution);
        public abstract void Qualify(JetBrains.ReSharper.Psi.Tree.ITreeNode node, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IParameter parameter);
        public abstract int ReferencesToThis(JetBrains.ReSharper.Psi.Tree.IExpression expression);
        public abstract void Replace(JetBrains.ReSharper.Psi.Tree.ITreeNode node, string name);
        public abstract void SetStatic(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration);
    }
    public class MakeStaticRefactoring : JetBrains.ReSharper.Refactorings.Common.DrivenRefactoring<JetBrains.ReSharper.Refactorings.ChangeStaticness.ToStatic.MakeStaticWorkflow, JetBrains.ReSharper.Refactorings.ChangeStaticness.ToStatic.MakeStatic>, JetBrains.ReSharper.Refactorings.IntroduceParameter.IIntroduceParameterDriver
    {
        public MakeStaticRefactoring(JetBrains.ReSharper.Refactorings.ChangeStaticness.ToStatic.MakeStaticWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Psi.Tree.IDeclaration Declaration { get; }
        public System.Collections.Generic.JetHashSet<JetBrains.ReSharper.Psi.IParameter> UsedParameters { get; set; }
        protected override JetBrains.ReSharper.Refactorings.ChangeStaticness.ToStatic.MakeStatic CreateRefactoringInternal(JetBrains.ReSharper.Refactorings.InternalRefactoringLanguageService service) { }
        protected override JetBrains.ReSharper.Refactorings.ChangeStaticness.ToStatic.MakeStatic CreateUnsupportedRefactoring() { }
        public override bool Execute(JetBrains.Application.Progress.IProgressIndicator pi) { }
        public System.Collections.Generic.Dictionary<int, JetBrains.ReSharper.Refactorings.Inline.InlinedParameterInfo> GetInlinedMethodParameterInfos(JetBrains.ReSharper.Psi.IParametersOwner owner) { }
        public JetBrains.ReSharper.Refactorings.Inline.InlineHelper GetInlineHelper(JetBrains.ReSharper.Psi.PsiLanguageType language) { }
    }
    public class MakeStaticWorkflow : JetBrains.ReSharper.Refactorings.WorkflowNew.DrivenRefactoringWorkflow2<JetBrains.ReSharper.Refactorings.ChangeStaticness.ToStatic.IMakeStaticHelper>
    {
        public MakeStaticWorkflow(JetBrains.ProjectModel.ISolution solution, string actionId, System.Predicate<JetBrains.ReSharper.Psi.Tree.IDeclaration> declarationValidator = null) { }
        public override JetBrains.ReSharper.Refactorings.Workflow.RefactoringActionGroup ActionGroup { get; }
        public bool CanAddParameters { get; }
        public JetBrains.ReSharper.Refactorings.ChangeStaticness.ToStatic.Model.ThisUsagesCollector Collector { get; }
        public JetBrains.ReSharper.Refactorings.ChangeStaticness.ToStatic.IMakeStaticDataProvider DataProvider { get; set; }
        public override JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage FirstPendingRefactoringPage { get; }
        public override string HelpKeyword { get; }
        public JetBrains.ReSharper.Psi.PsiLanguageType LanguageType { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Psi.Pointers.IDeclaredElementPointer<JetBrains.ReSharper.Psi.IOverridableMember> MemberPointer { get; }
        public override bool MightModifyManyDocuments { get; }
        public JetBrains.ReSharper.Refactorings.ChangeStaticness.ToStatic.Model.ToStaticPolicy Policy { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Psi.IPsiSourceFile SourceFile { get; }
        public string ThisParameterName { get; }
        public override string Title { get; }
        public JetBrains.ReSharper.Psi.Pointers.IDeclaredElementPointer<JetBrains.ReSharper.Psi.ITypeElement> TypeElementPointer { get; }
        public string TypeName { get; }
        public void Commit(JetBrains.ReSharper.Refactorings.ChangeStaticness.ToStatic.Model.ToStaticPolicy policy, [JetBrains.Annotations.CanBeNullAttribute()] string name) { }
        protected override JetBrains.ReSharper.Refactorings.ChangeStaticness.ToStatic.IMakeStaticHelper CreateHelper(JetBrains.ReSharper.Refactorings.IRefactoringLanguageService service) { }
        public override JetBrains.ReSharper.Refactorings.Workflow.IRefactoringExecuter CreateRefactoring(JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        protected override JetBrains.ReSharper.Refactorings.ChangeStaticness.ToStatic.IMakeStaticHelper CreateUnsupportedHelper() { }
        public override bool Initialize(JetBrains.Application.DataContext.IDataContext context) { }
        public override bool IsAvailable(JetBrains.Application.DataContext.IDataContext context) { }
        public bool IsValid() { }
        public override bool PreExecute(JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
    }
    public class Presenter : JetBrains.UI.TreeView.StructuredPresenter<JetBrains.TreeModels.TreeModelNode, JetBrains.CommonControls.IPresentableItem>
    {
        public override void UpdateItem(object value, JetBrains.TreeModels.TreeModelNode structureElement, JetBrains.CommonControls.IPresentableItem item, JetBrains.UI.TreeView.PresentationState state) { }
    }
}
namespace JetBrains.ReSharper.Refactorings.ChangeStaticness.ToStatic.Model
{
    
    public class ParameterFromExpression
    {
        public ParameterFromExpression(JetBrains.ReSharper.Psi.Tree.ITreeNode expression) { }
        public bool Included { get; set; }
        public JetBrains.ReSharper.Psi.ITreeNodePointer<JetBrains.ReSharper.Psi.Tree.ITreeNode> Pointer { get; }
        public string Presentation { get; }
        public bool Visible { get; set; }
    }
    public class ThisUsagesCollector : JetBrains.ReSharper.Psi.IRecursiveElementProcessor<JetBrains.ReSharper.Psi.IPsiServices>
    {
        public bool CanOmmitThis { get; }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Refactorings.ChangeStaticness.ToStatic.Model.ParameterFromExpression> Expressions { get; }
        public bool MustPassThis { get; }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Psi.ITreeNodePointer<JetBrains.ReSharper.Psi.Tree.ITreeNode>> ReadUsages { get; }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Psi.ITreeNodePointer<JetBrains.ReSharper.Psi.Tree.ITreeNode>> ThisUsages { get; }
        public bool UsesThis { get; }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Psi.ITreeNodePointer<JetBrains.ReSharper.Psi.Tree.ITreeNode>> WriteUsages { get; }
        public static JetBrains.ReSharper.Refactorings.ChangeStaticness.ToStatic.Model.ThisUsagesCollector CreateCollector(JetBrains.ReSharper.Psi.IOverridableMember member, JetBrains.ReSharper.Refactorings.ChangeStaticness.ToStatic.MakeStaticWorkflow workflow) { }
        public void Process() { }
    }
    public enum ToStaticPolicy
    {
        Original = 0,
        ThisOnly = 1,
        Expressions = 2,
    }
}
namespace JetBrains.ReSharper.Refactorings.ChangeStaticness.ToStatic.UI
{
    
    public class MakeStaticPage : JetBrains.UI.CommonControls.SafeTableLayoutPanel, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage
    {
        public MakeStaticPage() { }
        public MakeStaticPage(JetBrains.ReSharper.Refactorings.ChangeStaticness.ToStatic.MakeStaticWorkflow workflow, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Naming.Impl.NameRoot> roots, JetBrains.ReSharper.Psi.Naming.Settings.NamingPolicy policy) { }
        public JetBrains.DataFlow.IProperty<bool> ContinueEnabled { get; }
        public string Description { get; }
        public bool DoNotShow { get; }
        public string Title { get; }
        public JetBrains.UI.CrossFramework.EitherControl View { get; }
        public JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage Commit(JetBrains.Application.Progress.IProgressIndicator pi) { }
        protected override void Dispose(bool disposing) { }
        public bool Initialize(JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
        public bool RefreshContents(JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
    }
}
namespace JetBrains.ReSharper.Refactorings.ClassFromParameters
{
    
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "ClassFromParameters"})]
    public class ClassFromParametersAction : JetBrains.ReSharper.Refactorings.Workflow.ExtensibleRefactoringAction<JetBrains.ReSharper.Refactorings.ClassFromParameters.IClassFromParametersWorkflowProvider>
    {
        public const string ACTION_ID = "ClassFromParameters";
        protected override JetBrains.UI.RichText.RichText Caption { get; }
    }
    public abstract class ClassFromParametersBase : JetBrains.ReSharper.Refactorings.Common.RefactoringExecBase<JetBrains.ReSharper.Refactorings.ClassFromParameters.ClassFromParametersWorkflow, JetBrains.ReSharper.Refactorings.ClassFromParameters.ClassFromParametersRefactoring>
    {
        protected ClassFromParametersBase(JetBrains.ReSharper.Refactorings.ClassFromParameters.ClassFromParametersWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public abstract void FixUsage(JetBrains.ReSharper.Refactorings.ClassFromParameters.PreProcessedCall call, string name);
        public abstract bool IsPureRecursiveCall(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.IOverridableMember calledMethod, JetBrains.ReSharper.Psi.ITypeElement typeElement);
        public abstract JetBrains.ReSharper.Refactorings.ClassFromParameters.PreProcessedCall PreProcessCall(JetBrains.ReSharper.Psi.Resolve.IReference reference);
        public abstract void Transform(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.IProperty property, JetBrains.ReSharper.Psi.IParameter parameter);
    }
    public sealed class ClassFromParametersRefactoring : JetBrains.ReSharper.Refactorings.Common.DrivenRefactoring<JetBrains.ReSharper.Refactorings.ClassFromParameters.ClassFromParametersWorkflow, JetBrains.ReSharper.Refactorings.ClassFromParameters.ClassFromParametersBase>, JetBrains.ReSharper.Refactorings.ClassFromParameters.IClassFromParametersExecuter, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringExecuter
    {
        public ClassFromParametersRefactoring(JetBrains.ReSharper.Refactorings.ClassFromParameters.ClassFromParametersWorkflow workFlow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IParametersOwner> AllOverrides { get; }
        public JetBrains.ReSharper.Psi.ITypeElement NewClass { get; }
        public System.Collections.Generic.JetHashSet<int> SelelcetedParameters { get; }
        public JetBrains.ReSharper.Psi.Resolve.ISubstitution BuildSubstitution(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        protected override JetBrains.ReSharper.Refactorings.ClassFromParameters.ClassFromParametersBase CreateRefactoringInternal(JetBrains.ReSharper.Refactorings.InternalRefactoringLanguageService service) { }
        protected override JetBrains.ReSharper.Refactorings.ClassFromParameters.ClassFromParametersBase CreateUnsupportedRefactoring() { }
        public override bool Execute(JetBrains.Application.Progress.IProgressIndicator pi) { }
        public JetBrains.ReSharper.Psi.Resolve.ISubstitution FindSubstitutionOfOverride(JetBrains.ReSharper.Psi.IParametersOwner owner) { }
    }
    public class ClassFromParametersTestDataProvider : JetBrains.ReSharper.Refactorings.ClassFromParameters.IClassFromParametersDataProvider
    {
        public ClassFromParametersTestDataProvider(string selectedMembers, bool createClass, bool createNested, string typeName) { }
        public bool MakeClass { get; }
        public bool TopLevel { get; }
        public string TypeElementName { get; }
        public void SelectMembers(System.Collections.Generic.List<JetBrains.ReSharper.Refactorings.ClassFromParameters.UI.ParameterInfo> infos) { }
    }
    public class ClassFromParametersWorkflow : JetBrains.ReSharper.Refactorings.Workflow.DrivenRefactoringWorkflow
    {
        public ClassFromParametersWorkflow(JetBrains.ProjectModel.ISolution solution, string actionId) { }
        public override JetBrains.ReSharper.Refactorings.Workflow.RefactoringActionGroup ActionGroup { get; }
        public bool Ask { set; }
        public bool CanBeNested { get; }
        public override JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage FirstPendingRefactoringPage { get; }
        public override string HelpKeyword { get; }
        public bool MakeClass { get; set; }
        public override bool MightModifyManyDocuments { get; }
        public JetBrains.ReSharper.Psi.Pointers.IDeclaredElementPointer<JetBrains.ReSharper.Psi.IParametersOwner> Owner { get; }
        public System.Collections.Generic.List<JetBrains.ReSharper.Refactorings.ClassFromParameters.UI.ParameterInfo> ParameterInfos { get; }
        public override string Title { get; }
        public bool TopLevel { get; set; }
        public string TypeElementName { get; set; }
        public override JetBrains.ReSharper.Refactorings.Workflow.IRefactoringExecuter CreateRefactoring(JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public System.Collections.Generic.JetHashSet<int> GetSelelctedParameters() { }
        public override bool Initialize(JetBrains.Application.DataContext.IDataContext context) { }
        public override bool IsAvailable(JetBrains.Application.DataContext.IDataContext context) { }
        public override bool PreExecute(JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
        public void SetDataProvider(JetBrains.ReSharper.Refactorings.ClassFromParameters.IClassFromParametersDataProvider value) { }
        public override bool Validate() { }
    }
    public interface IClassFromParametersDataProvider
    {
        bool MakeClass { get; }
        bool TopLevel { get; }
        string TypeElementName { get; }
        void SelectMembers(System.Collections.Generic.List<JetBrains.ReSharper.Refactorings.ClassFromParameters.UI.ParameterInfo> infos);
    }
    public interface IClassFromParametersExecuter : JetBrains.ReSharper.Refactorings.Workflow.IRefactoringExecuter { }
    public interface IClassFromParametersWorkflowProvider : JetBrains.ReSharper.Feature.Services.ActionsMenu.IWorkflowProvider<JetBrains.ReSharper.Refactorings.Workflow.IRefactoringWorkflow, JetBrains.ReSharper.Refactorings.Workflow.RefactoringActionGroup>, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringWorkflowProvider { }
    public sealed class PreProcessedCall
    {
        public PreProcessedCall(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.Tree.IDeclaration parametersOwner) { }
        public System.Collections.Generic.JetHashSet<int> IncludedArguments { get; }
        public int IndexOfExtensionArgument { get; set; }
        public bool IsRecursiveCall { get; set; }
        public JetBrains.ReSharper.Psi.Tree.IDeclaration ParametersOwner { get; }
        public JetBrains.ReSharper.Psi.Resolve.IReference Reference { get; }
        public JetBrains.ReSharper.Psi.Resolve.ISubstitution Substitution { get; set; }
    }
}
namespace JetBrains.ReSharper.Refactorings.ClassFromParameters.UI
{
    
    public class ExtractClassFromParamsControl : JetBrains.UI.CommonControls.SafeUserControl, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage
    {
        public ExtractClassFromParamsControl(JetBrains.ReSharper.Refactorings.ClassFromParameters.ClassFromParametersWorkflow workflow) { }
        public JetBrains.DataFlow.IProperty<bool> ContinueEnabled { get; }
        public bool CurrentIsNested { get; }
        public string Description { get; }
        public bool DoNotShow { get; }
        public System.Windows.Forms.Control TargetTypeControl { get; }
        public string Title { get; }
        public JetBrains.UI.CrossFramework.EitherControl View { get; }
        public JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage Commit(JetBrains.Application.Progress.IProgressIndicator pi) { }
        public void Initialize() { }
        public bool Initialize(JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
        public bool RefreshContents(JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
    }
    public class ParameterInfo
    {
        public ParameterInfo(JetBrains.ReSharper.Psi.IParameter parameter, int index) { }
        public bool Included { get; set; }
        public int Index { get; }
        public JetBrains.ReSharper.Psi.IParameter Parameter { get; }
    }
}
namespace JetBrains.ReSharper.Refactorings.ClassFromParameters.Util
{
    
    public class SignatureGenerifier
    {
        public SignatureGenerifier() { }
        public System.Collections.Generic.Dictionary<JetBrains.ReSharper.Psi.ITypeParameter, JetBrains.ReSharper.Refactorings.ClassFromParameters.Util.TypeParameter> ParamsIndex { get; }
        public static JetBrains.ReSharper.Psi.Resolve.ISubstitution BuildSubstitution(JetBrains.ReSharper.Psi.IType mostGenericType, JetBrains.ReSharper.Psi.IType specializedType) { }
        public bool CheckTypesIdentity(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IType> types, out JetBrains.ReSharper.Refactorings.ClassFromParameters.Util.TypeBuilder builder) { }
    }
    public delegate JetBrains.ReSharper.Psi.IType TypeBuilder(JetBrains.ReSharper.Refactorings.ClassFromParameters.Util.TypeProjection projection);
    public class TypeParameter
    {
        public TypeParameter() { }
        public bool Locked { get; }
        public System.Collections.Generic.JetHashSet<JetBrains.ReSharper.Psi.ITypeParameter> Parameters { get; }
        public void Lock() { }
    }
    public delegate JetBrains.ReSharper.Psi.ITypeParameter TypeProjection(JetBrains.ReSharper.Refactorings.ClassFromParameters.Util.TypeParameter parameter);
}
namespace JetBrains.ReSharper.Refactorings.Common
{
    
    public class ConstructorsMap
    {
        public ConstructorsMap(JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public JetBrains.ReSharper.Refactorings.Util.ConstructionUtil this[JetBrains.ReSharper.Psi.PsiLanguageType langauge] { get; }
    }
    public abstract class DrivenRefactoring<TWorkflow, TRefactoring> : JetBrains.ReSharper.Refactorings.Common.DrivenRefactoringBase<TWorkflow>
        where TWorkflow : JetBrains.ReSharper.Refactorings.Workflow.DrivenRefactoringWorkflow
        where TRefactoring :  class, JetBrains.ReSharper.Refactorings.Common.IDrivenRefactoringExec
    {
        protected DrivenRefactoring(TWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        [JetBrains.Annotations.NotNullAttribute()]
        protected JetBrains.ReSharper.Refactorings.Common.ConstructorsMap Constructors { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ReSharper.Refactorings.LanguageMapOfRefactoring<TRefactoring> Exec { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        protected virtual TRefactoring CreateRefactoring(JetBrains.ReSharper.Refactorings.IRefactoringLanguageService service) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        protected virtual TRefactoring CreateRefactoringInternal(JetBrains.ReSharper.Refactorings.InternalRefactoringLanguageService service) { }
        protected virtual TRefactoring CreateUnsupportedRefactoring() { }
        protected static JetBrains.ReSharper.Refactorings.RefactoringsHelper GetHelper(JetBrains.ReSharper.Psi.PsiLanguageType language) { }
    }
    public abstract class DrivenRefactoringBase<TWorkflow> : JetBrains.ReSharper.Refactorings.Workflow.IRefactoringExecuter
        where TWorkflow : JetBrains.ReSharper.Refactorings.Workflow.DrivenRefactoringWorkflow
    {
        protected DrivenRefactoringBase([JetBrains.Annotations.NotNullAttribute()] TWorkflow workflow, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.ISolution solution, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver Driver { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ProjectModel.ISolution Solution { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public TWorkflow Workflow { get; }
        public abstract bool Execute([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Progress.IProgressIndicator pi);
    }
    public interface IDrivenRefactoringExec : JetBrains.ReSharper.Refactorings.IRefactoringExec
    {
        void SetExecuter(JetBrains.ReSharper.Refactorings.Workflow.IRefactoringExecuter executer);
    }
    public abstract class RefactoringExecBase<TWorkflow, TExecuter> : JetBrains.ReSharper.Refactorings.Common.IDrivenRefactoringExec, JetBrains.ReSharper.Refactorings.IRefactoringExec
        where TWorkflow : JetBrains.ReSharper.Refactorings.Workflow.DrivenRefactoringWorkflow
        where TExecuter : JetBrains.ReSharper.Refactorings.Workflow.IRefactoringExecuter
    {
        public RefactoringExecBase(TWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver Driver { get; }
        public TExecuter Executer { get; }
        public JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver RefactoringDriver { set; }
        public JetBrains.ProjectModel.ISolution Solution { get; }
        public TWorkflow Workflow { get; }
        public void SetExecuter(JetBrains.ReSharper.Refactorings.Workflow.IRefactoringExecuter refactoring) { }
    }
}
namespace JetBrains.ReSharper.Refactorings.Common.Convert
{
    
    public abstract class ConvertBase<WORKFLOW, EXECUTER> : JetBrains.ReSharper.Refactorings.Common.RefactoringExecBase<WORKFLOW, EXECUTER>, JetBrains.ReSharper.Refactorings.Common.Convert.IConvertConflictChecker, JetBrains.ReSharper.Refactorings.Common.Convert.IConvertRefactoring, JetBrains.ReSharper.Refactorings.IRefactoringExec
        where WORKFLOW : JetBrains.ReSharper.Refactorings.Workflow.DrivenRefactoringWorkflow, JetBrains.ReSharper.Refactorings.Common.Convert.IConvertRefactoringWorkflow
        where EXECUTER : JetBrains.ReSharper.Refactorings.Workflow.IRefactoringExecuter, JetBrains.ReSharper.Refactorings.Common.Convert.IConvertRefactoringExecuter
    {
        protected ConvertBase(WORKFLOW workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public JetBrains.ReSharper.Psi.IPsiServices PsiServices { get; set; }
        protected abstract bool AreEquals(string name1, string name2);
        protected virtual void AutoPropertyConflicts(JetBrains.ReSharper.Psi.IDeclaredElement element) { }
        protected virtual void CheckConflictWithClassName(JetBrains.ReSharper.Psi.ITypeElement element) { }
        public virtual void CheckConflictWithDecaredElement(JetBrains.ReSharper.Psi.IDeclaredElement declaration, JetBrains.ReSharper.Psi.IDeclaredElement existingDeclaration, bool isBase, bool isInheritor) { }
        public virtual void CheckConflictWithMethod(JetBrains.ReSharper.Psi.IMethod method, JetBrains.ReSharper.Psi.IDeclaredElement existingDeclaration, bool isBase, bool isInheritor) { }
        public virtual void CheckConflictWithProperty(JetBrains.ReSharper.Psi.IProperty property, JetBrains.ReSharper.Psi.IDeclaredElement existingDeclaration, bool isBase, bool isInheritor) { }
        protected bool CheckExistingPropertyConflicts([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IProperty property, bool fromBase, bool isSuperClass, bool isGetter) { }
        public abstract void ExecuteDeclarationRefactoring(JetBrains.ReSharper.Psi.IDeclaredElement propertyOrMethod, JetBrains.Application.Progress.IProgressIndicator pi);
        public abstract void ExecuteReferencesRefactoring(JetBrains.ReSharper.Psi.Resolve.IReference reference);
        protected void FireRefactoringDetails(string name, object data) { }
        public virtual string[] GetAllNames() { }
        public abstract bool InitialValidate();
        public virtual void SearchConflicts(JetBrains.ReSharper.Psi.IDeclaredElement convertedDeclaredElement, JetBrains.Application.Progress.IProgressIndicator pi) { }
        protected virtual JetBrains.ReSharper.Refactorings.Function2Property.PropertySearchResultBase TestPropertyParameters(JetBrains.ReSharper.Psi.IProperty property) { }
        protected bool TryAddConflicts(JetBrains.ReSharper.Psi.ITypeElement type, JetBrains.ReSharper.Psi.IProperty property, bool fromBase, bool isSuperClass, bool isGetter) { }
        public virtual void TryMakeConflictForNotExpression(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public virtual bool TryNewTypeDeclaration(JetBrains.ReSharper.Refactorings.Indexer2Function.IndexersSearchData data, JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public class static ElementExistConflct<WORKFLOW, EXECUTER>
            where WORKFLOW : JetBrains.ReSharper.Refactorings.Workflow.DrivenRefactoringWorkflow, JetBrains.ReSharper.Refactorings.Common.Convert.IConvertRefactoringWorkflow
            where EXECUTER : JetBrains.ReSharper.Refactorings.Workflow.IRefactoringExecuter, JetBrains.ReSharper.Refactorings.Common.Convert.IConvertRefactoringExecuter
        {
            public static JetBrains.ReSharper.Refactorings.Conflicts.IConflict Create(bool isParent, bool isChild, JetBrains.ReSharper.Psi.IDeclaredElement element) { }
        }
    }
    public class ConvertBindingSearcher : JetBrains.ReSharper.Psi.IRecursiveElementProcessor
    {
        public ConvertBindingSearcher(string[] names) { }
        public System.Collections.Generic.List<JetBrains.ReSharper.Refactorings.Util.ReferenceBinding> Bindings { get; }
        public bool IsCaseSensitive { get; set; }
        public bool ProcessingIsFinished { get; }
        public bool InteriorShouldBeProcessed(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public void ProcessAfterInterior(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public void ProcessBeforeInterior(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
    }
    public class ConvertHierarchyConflictTextProvider : JetBrains.ReSharper.Refactorings.Conflicts.HierarchyConflictTextProviderBase
    {
        public override string QuasiImplements() { }
        public override string WillAlsoImplement() { }
        public override string WillAlsoOverride() { }
    }
    public abstract class ConvertRefactoring<TWorkflow, TConvert> : JetBrains.ReSharper.Refactorings.Common.DrivenRefactoring<TWorkflow, TConvert>, JetBrains.ReSharper.Refactorings.Common.Convert.IConvertConflictChecker, JetBrains.ReSharper.Refactorings.Common.Convert.IConvertRefactoringExecuter
        where TWorkflow : JetBrains.ReSharper.Refactorings.Workflow.DrivenRefactoringWorkflow, JetBrains.ReSharper.Refactorings.Common.Convert.IConvertRefactoringWorkflow
        where TConvert :  class, JetBrains.ReSharper.Refactorings.Common.IDrivenRefactoringExec, JetBrains.ReSharper.Refactorings.Common.Convert.IConvertRefactoring
    {
        protected JetBrains.ReSharper.Psi.Resolve.IReference[] myReferences;
        protected readonly System.Collections.Generic.JetHashSet<JetBrains.ReSharper.Psi.ITypeElement> myTypes;
        protected ConvertRefactoring(TWorkflow workFlow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public System.Collections.Generic.List<JetBrains.ReSharper.Psi.IOverridableMember> AllOverrides { get; set; }
        public System.Collections.Generic.JetHashSet<JetBrains.ReSharper.Psi.ITypeElement> AllProcessedTypes { get; }
        public System.Collections.Generic.ICollection<JetBrains.ReSharper.Refactorings.Util.ReferenceBinding> Bindings { get; }
        public abstract string Caption { get; }
        public bool IsExplicitImplementation { get; }
        public JetBrains.ReSharper.Psi.IPsiServices PsiServices { get; }
        public JetBrains.ReSharper.Psi.Resolve.IReference[] References { get; }
        public virtual void AddAdditionalElements(System.Collections.Generic.List<JetBrains.ReSharper.Psi.IDeclaredElement> declaredElementsToSearch, JetBrains.ReSharper.Psi.IProperty property) { }
        public void CheckConflictWithDecaredElement(JetBrains.ReSharper.Psi.IDeclaredElement element, JetBrains.ReSharper.Psi.IDeclaredElement existingDeclaration, bool isBase, bool isInheritor) { }
        public void CheckConflictWithMethod(JetBrains.ReSharper.Psi.IMethod method, JetBrains.ReSharper.Psi.IDeclaredElement existingDeclaration, bool isBase, bool isInheritor) { }
        public void CheckConflictWithProperty(JetBrains.ReSharper.Psi.IProperty property, JetBrains.ReSharper.Psi.IDeclaredElement existingDeclaration, bool isBase, bool isInheritor) { }
        public override bool Execute(JetBrains.Application.Progress.IProgressIndicator pi) { }
        public void IterateDeclarations(JetBrains.Application.Progress.IProgressIndicator pi, System.Action<JetBrains.ReSharper.Refactorings.Common.Convert.IConvertRefactoring, JetBrains.ReSharper.Psi.IOverridableMember, JetBrains.Application.Progress.IProgressIndicator> action) { }
        public void Rebind(JetBrains.Application.Progress.SubProgressIndicator subPi) { }
        public virtual void SearchReferences(JetBrains.Application.Progress.IProgressIndicator pi) { }
        public void TryMakeConflictForNotExpression(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
    }
    public class static ConvertRefactoringUtil
    {
        public static JetBrains.ReSharper.Refactorings.Common.Convert.OverridesAskResult CheckOverrides(string caption, string entetyName, JetBrains.ReSharper.Refactorings.Common.Convert.NoAskModes askMode, JetBrains.ReSharper.Psi.Pointers.IDeclaredElementPointer<JetBrains.ReSharper.Psi.IOverridableMember> pointer) { }
        public static System.Collections.Generic.List<JetBrains.ReSharper.Refactorings.Common.Convert.ElementOverride> FindOverrides(JetBrains.ReSharper.Psi.IOverridableMember member, JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator pi) { }
        public static string TryName(string name, string[] names, bool isCaseSensitive) { }
    }
    public class ConvertSortSearcher : JetBrains.ReSharper.Psi.IRecursiveElementProcessor
    {
        public ConvertSortSearcher(JetBrains.Util.OneToListMap<JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Resolve.IReference> references, JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.Resolve.IReference referenceToSearch) { }
        public bool ProcessingIsFinished { get; }
        public bool ReferenceFound { get; }
        public bool InteriorShouldBeProcessed(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public void ProcessAfterInterior(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public void ProcessBeforeInterior(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
    }
    public delegate TMethodDeclaration CreateAccessorDelegate<TMethodDeclaration>(bool hasBody, JetBrains.ReSharper.Psi.IProperty baseProperty, JetBrains.ReSharper.Psi.IAccessor accessor, string name, string pattern);
    public class ElementOverride : System.IEquatable<JetBrains.ReSharper.Refactorings.Common.Convert.ElementOverride>
    {
        public ElementOverride(JetBrains.ReSharper.Psi.IOverridableMember member, bool isRoot) { }
        public bool IsRoot { get; }
        public JetBrains.ReSharper.Psi.IOverridableMember Member { get; }
        public bool Equals(JetBrains.ReSharper.Refactorings.Common.Convert.ElementOverride elementOverride) { }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
    }
    public interface IConvertConflictChecker
    {
        void CheckConflictWithDecaredElement([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IDeclaredElement declaration, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IDeclaredElement existingDeclaration, bool isBase, bool isInheritor);
        void CheckConflictWithMethod([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IMethod method, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IDeclaredElement existingDeclaration, bool isBase, bool isInheritor);
        void CheckConflictWithProperty([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IProperty property, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IDeclaredElement existingDeclaration, bool isBase, bool isInheritor);
    }
    public interface IConvertRefactoring : JetBrains.ReSharper.Refactorings.Common.Convert.IConvertConflictChecker, JetBrains.ReSharper.Refactorings.IRefactoringExec
    {
        void ExecuteDeclarationRefactoring(JetBrains.ReSharper.Psi.IDeclaredElement propertyOrMethod, JetBrains.Application.Progress.IProgressIndicator pi);
        void ExecuteReferencesRefactoring(JetBrains.ReSharper.Psi.Resolve.IReference reference);
        string[] GetAllNames();
        bool InitialValidate();
        void SearchConflicts(JetBrains.ReSharper.Psi.IDeclaredElement convertedDeclaredElement, JetBrains.Application.Progress.IProgressIndicator pi);
        void TryMakeConflictForNotExpression(JetBrains.ReSharper.Psi.Resolve.IReference reference);
        bool TryNewTypeDeclaration(JetBrains.ReSharper.Refactorings.Indexer2Function.IndexersSearchData data, JetBrains.ReSharper.Psi.Resolve.IReference reference);
    }
    public interface IConvertRefactoringExecuter : JetBrains.ReSharper.Refactorings.Common.Convert.IConvertConflictChecker
    {
        System.Collections.Generic.List<JetBrains.ReSharper.Psi.IOverridableMember> AllOverrides { get; }
        System.Collections.Generic.JetHashSet<JetBrains.ReSharper.Psi.ITypeElement> AllProcessedTypes { get; }
        bool IsExplicitImplementation { get; }
        void TryMakeConflictForNotExpression(JetBrains.ReSharper.Psi.Resolve.IReference reference);
    }
    public interface IConvertRefactoringWorkflow
    {
        JetBrains.ReSharper.Psi.Pointers.IDeclaredElementPointer<JetBrains.ReSharper.Psi.IOverridableMember> Pointer { get; }
    }
    [System.FlagsAttribute()]
    public enum NoAskModes
    {
        NoAsk = 0,
        Ask = 1,
        YFromBase = 4,
    }
    public enum OverridesAskResult
    {
        All = 0,
        Stop = 1,
        This = 2,
    }
    public abstract class Property2FunctionDeclarationProcessor<TMethodDeclaration>
        where TMethodDeclaration :  class, JetBrains.ReSharper.Psi.Tree.ITypeMemberDeclaration
    {
        public System.Collections.Generic.IList<JetBrains.ReSharper.Refactorings.Conflicts.IConflict> Conflicts { get; set; }
        protected abstract TMethodDeclaration AddAccessor(TMethodDeclaration declaration, JetBrains.ReSharper.Psi.IProperty property);
        protected virtual bool CheckIsAuto(JetBrains.ReSharper.Psi.IProperty property) { }
        public void ConvertProperty([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IProperty property, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Refactorings.Property2Function.Property2FunctionWorkflow workflow, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Refactorings.Common.Convert.CreateAccessorDelegate<TMethodDeclaration> getterCreator, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Refactorings.Common.Convert.CreateAccessorDelegate<TMethodDeclaration> setterCreator) { }
        protected virtual JetBrains.ReSharper.Psi.IProperty CreateFieldForAutoProperty(JetBrains.ReSharper.Psi.IProperty property) { }
        protected virtual void FixCommentToGetter(JetBrains.ReSharper.Psi.Tree.IDocCommentBlockOwnerNode owner) { }
        protected virtual void FixCommentToSetter(JetBrains.ReSharper.Psi.Tree.IDocCommentBlockOwnerNode owner) { }
        protected abstract string GetterPattern(bool isAbstract, bool isInterface);
        protected abstract void RemoveBaseDeclaration(JetBrains.ReSharper.Psi.IProperty property);
        protected abstract void RemoveGetter(JetBrains.ReSharper.Psi.IProperty property);
        protected abstract void RemoveSetter(JetBrains.ReSharper.Psi.IProperty property);
        protected abstract string SetterPattern(bool isAbstract, bool isInterface, JetBrains.ReSharper.Psi.IProperty property);
    }
    public abstract class Property2FunctionReferencesProcessor
    {
        protected JetBrains.ReSharper.Refactorings.Property2Function.Property2FunctionBase myRefactoring;
        public Property2FunctionReferencesProcessor(JetBrains.ReSharper.Refactorings.Property2Function.Property2FunctionBase refactoring) { }
        public abstract void ReplaceReadOccurence(JetBrains.ReSharper.Psi.Tree.IExpression expression);
        public abstract bool ReplaceReadWriteOccurence(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.Tree.IExpression expression);
        public abstract bool ReplaceWriteProperty(JetBrains.ReSharper.Psi.Tree.IExpression expression, JetBrains.ReSharper.Psi.Resolve.IReference reference);
        public abstract bool TryTransformMthodCall(JetBrains.ReSharper.Psi.Tree.IExpression expression);
    }
    public class UnableToContinueConvertException : System.Exception
    {
        public UnableToContinueConvertException(string message) { }
    }
}
namespace JetBrains.ReSharper.Refactorings.Common.Convert.Unsupported
{
    
    public class Function2PropertyUnsupported : JetBrains.ReSharper.Refactorings.Function2Property.Function2PropertyBase
    {
        public Function2PropertyUnsupported(JetBrains.ReSharper.Refactorings.Function2Property.Function2PropertyWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        protected override bool AreEquals(string name1, string name2) { }
        protected override bool CheckExplicitImplementationList(JetBrains.ReSharper.Psi.IOverridableMember accessor, JetBrains.ReSharper.Psi.IMethod method) { }
        public override void ExecuteDeclarationRefactoring(JetBrains.ReSharper.Psi.IDeclaredElement element, JetBrains.Application.Progress.IProgressIndicator pi) { }
        public override void ExecuteReferencesRefactoring(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public override bool InitialValidate() { }
        public override void PropcessMethod(JetBrains.ReSharper.Psi.IDeclaredElement element) { }
    }
    public class Property2FunctionUnsupported : JetBrains.ReSharper.Refactorings.Property2Function.Property2FunctionBase
    {
        public Property2FunctionUnsupported(JetBrains.ReSharper.Refactorings.Property2Function.Property2FunctionWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        protected override bool AreEquals(string name1, string name2) { }
        public override void ExecuteDeclarationRefactoring(JetBrains.ReSharper.Psi.IDeclaredElement element, JetBrains.Application.Progress.IProgressIndicator pi) { }
        public override void ExecuteReferencesRefactoring(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public override bool InitialValidate() { }
        public override void ProcessProperty(JetBrains.ReSharper.Psi.IDeclaredElement propertyOrMethod) { }
    }
}
namespace JetBrains.ReSharper.Refactorings.CommonUI
{
    
    public abstract class BaseMemberInfo : JetBrains.ReSharper.Refactorings.CommonUI.IMemberInfo, System.IDisposable
    {
        public static readonly JetBrains.ReSharper.Psi.DeclaredElementPresenterStyle PRESENTER;
        protected BaseMemberInfo(JetBrains.ReSharper.Psi.IDeclaredElement element) { }
        public abstract bool CanChangeAbstract { get; }
        public abstract bool CanHaveAbstract { get; }
        public JetBrains.ReSharper.Psi.IDeclaredElement DeclaredElement { get; }
        public abstract bool Enabled { get; }
        public abstract bool HasError { get; }
        public abstract bool HasWarning { get; }
        public abstract bool Included { get; set; }
        public abstract bool MakeAbstract { get; set; }
        public virtual JetBrains.UI.RichText.RichText RichText { get; }
        public JetBrains.UI.RichText.RichText RichTextWhite { get; }
        public abstract string ToolTip { get; }
        public virtual void Dispose() { }
        public string GetPresentation() { }
        protected virtual void SafeUpdate() { }
        public void Update() { }
    }
    public interface IMemberInfo
    {
        bool CanChangeAbstract { get; }
        bool CanHaveAbstract { get; }
        JetBrains.ReSharper.Psi.IDeclaredElement DeclaredElement { get; }
        bool Enabled { get; }
        bool HasError { get; }
        bool HasWarning { get; }
        bool Included { get; set; }
        bool MakeAbstract { get; set; }
        JetBrains.UI.RichText.RichText RichText { get; }
        JetBrains.UI.RichText.RichText RichTextWhite { get; }
        string ToolTip { get; }
        string GetPresentation();
        void Update();
    }
    public interface IMemberInfoWithDeclaration
    {
        JetBrains.ReSharper.Psi.Tree.ITypeDeclaration TypeDeclaration { get; }
    }
    public delegate void ItemChecked(JetBrains.ReSharper.Refactorings.CommonUI.IMemberInfo memberInfo);
    public class MemberListTreeControl : JetBrains.UI.CommonControls.SafeTreeList
    {
        public MemberListTreeControl(string makeAbstractColumnTitle, JetBrains.ReSharper.Psi.IPsiServices psiServices, JetBrains.UI.Application.IUIApplication environment) { }
        public event JetBrains.ReSharper.Refactorings.CommonUI.ItemChecked ItemChecked;
        protected override DevExpress.XtraTreeList.Handler.TreeListHandler CreateHandler() { }
        protected override DevExpress.XtraTreeList.ViewInfo.TreeListViewInfo CreateViewInfo() { }
        protected override void Dispose(bool disposing) { }
        protected override void OnKeyDown(System.Windows.Forms.KeyEventArgs e) { }
        protected override void OnLoaded() { }
        public void SetMemberInfos(JetBrains.ReSharper.Psi.PsiLanguageType language, System.Collections.Generic.IList<JetBrains.ReSharper.Refactorings.CommonUI.IMemberInfo> value, JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
        public delegate JetBrains.UI.RichText.RichText GetRichText(JetBrains.ReSharper.Refactorings.MoveMembers.Common.ITargetTypeWithProjectFile memberInfo);
    }
    public class NameCompletionEdit : JetBrains.ReSharper.Features.Common.UI.CompletionPickerEdit
    {
        public NameCompletionEdit(JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, JetBrains.ReSharper.Features.Common.UI.CompletionPickerEditComponents components) { }
        public JetBrains.ReSharper.Psi.Naming.Settings.NamingPolicy NamingPolicy { get; set; }
        public void SetProperties(string initialText, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Naming.Impl.NameRoot> roots, JetBrains.ReSharper.Psi.Naming.Settings.NamingPolicy namingPolicy, JetBrains.ReSharper.Psi.PsiLanguageType language) { }
    }
}
namespace JetBrains.ReSharper.Refactorings.Conflicts
{
    
    public class CompositeConflictSearcher : JetBrains.ReSharper.Refactorings.Conflicts.IConflictSearcher
    {
        public CompositeConflictSearcher(System.Collections.Generic.IList<JetBrains.ReSharper.Refactorings.Conflicts.IConflictSearcher> conflictSearchers) { }
        public JetBrains.ReSharper.Refactorings.Conflicts.ConflictSearchResult SearchConflicts(JetBrains.Application.Progress.IProgressIndicator pi, bool canPerformRefactoring) { }
    }
    [JetBrains.UI.ActiveText.ProtocolHandlerAttribute(Protocol="conflict")]
    public class ConflictProtocolHandler : JetBrains.UI.ActiveText.ProtocolHandler
    {
        protected override void NavigateNakedLink(string link, object host) { }
    }
    public class ConflictSearchResult
    {
        public ConflictSearchResult() { }
        public ConflictSearchResult([JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Refactorings.Conflicts.IConflict> conflicts) { }
        public ConflictSearchResult(bool performedRefactoring, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Refactorings.Conflicts.IConflict> conflicts) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Refactorings.Conflicts.IConflict> Conflicts { get; }
        public bool Failed { get; }
        public bool PerformedRefactoring { get; }
        public static JetBrains.ReSharper.Refactorings.Conflicts.ConflictSearchResult CreateFailedResult() { }
    }
    public enum ConflictSeverity
    {
        Warning = 0,
        Error = 1,
    }
    public class ConflictWithDeclaredElement : JetBrains.ReSharper.Refactorings.Conflicts.IConflict
    {
        public ConflictWithDeclaredElement([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
        public ConflictWithDeclaredElement([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, string conflictDescription) { }
        public ConflictWithDeclaredElement([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, string conflictDescription, JetBrains.ReSharper.Refactorings.Conflicts.ConflictSeverity severity) { }
        public JetBrains.ReSharper.Psi.IDeclaredElement DeclaredElement { get; }
        public string Description { get; }
        public bool IsValid { get; }
        public JetBrains.ReSharper.Refactorings.Conflicts.ConflictSeverity Severity { get; }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
    }
    public class ConflictWithDelegateSignature : JetBrains.ReSharper.Refactorings.Conflicts.IConflict
    {
        public ConflictWithDelegateSignature(JetBrains.ReSharper.Psi.PsiLanguageType languageType, JetBrains.ReSharper.Psi.IDelegate d) { }
        public string Description { get; }
        public bool IsValid { get; }
        public JetBrains.ReSharper.Refactorings.Conflicts.ConflictSeverity Severity { get; }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
    }
    public class ConflictWithElement : JetBrains.ReSharper.Refactorings.Conflicts.IConflict
    {
        public ConflictWithElement(JetBrains.ReSharper.Psi.Tree.ITreeNode element, string text, string tag, JetBrains.ReSharper.Refactorings.Conflicts.ConflictSeverity severity) { }
        public string Description { get; }
        public JetBrains.ReSharper.Psi.Tree.ITreeNode Element { get; }
        public bool IsValid { get; }
        public JetBrains.ReSharper.Refactorings.Conflicts.ConflictSeverity Severity { get; }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
    }
    [JetBrains.UI.ActiveText.ProtocolHandlerAttribute(Protocol="element")]
    public class ElementProtocolHandler : JetBrains.UI.ActiveText.ProtocolHandler
    {
        protected override void NavigateNakedLink(string link, object host) { }
    }
    public class HidesConflict : JetBrains.ReSharper.Refactorings.Conflicts.IConflict
    {
        public HidesConflict(JetBrains.ReSharper.Psi.PsiLanguageType languageType, JetBrains.ReSharper.Psi.ITypeMember hidden, JetBrains.ReSharper.Psi.ITypeMember hiding, bool hidingIsAlwaysSame) { }
        public string Description { get; }
        public bool IsValid { get; }
        public JetBrains.ReSharper.Psi.ITypeMember Overriden { get; }
        public JetBrains.ReSharper.Psi.ITypeMember Overriding { get; }
        public JetBrains.ReSharper.Refactorings.Conflicts.ConflictSeverity Severity { get; }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
    }
    public class HierarchyConflictConsumer
    {
        public HierarchyConflictConsumer() { }
        public System.Collections.Generic.List<JetBrains.ReSharper.Refactorings.Rename.HierarchyConflict> MyHierarchyConflicts { get; }
        public bool AddConflictsForHierarhyMember(JetBrains.ReSharper.Refactorings.OverridesSupport.HierarchyMember member) { }
    }
    public abstract class HierarchyConflictTextProviderBase
    {
        public string ImplementedInCompiledCode(string kindName) { }
        public string ImplementsFromCompiledInterface(string kindName) { }
        public string OverridenInCompiledCode(string kindName) { }
        public string OverriedFromCompiledCode(string kindName) { }
        public abstract string QuasiImplements();
        public abstract string WillAlsoImplement();
        public abstract string WillAlsoOverride();
    }
    public interface IConflict
    {
        string Description { get; }
        bool IsValid { get; }
        JetBrains.ReSharper.Refactorings.Conflicts.ConflictSeverity Severity { get; }
    }
    public interface IConflictSearcher
    {
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Refactorings.Conflicts.ConflictSearchResult SearchConflicts([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Progress.IProgressIndicator progressIndicator, bool canPerformRefactoring);
    }
    public class MemberImplementsConflict : JetBrains.ReSharper.Refactorings.Conflicts.IConflict, System.IEquatable<JetBrains.ReSharper.Refactorings.Conflicts.MemberImplementsConflict>
    {
        public MemberImplementsConflict(JetBrains.ReSharper.Psi.Pointers.IDeclaredElementPointer<JetBrains.ReSharper.Psi.IOverridableMember> memberPointer, JetBrains.ReSharper.Psi.Pointers.IDeclaredElementPointer<JetBrains.ReSharper.Psi.IOverridableMember> implementedMemberPointer, JetBrains.ReSharper.Refactorings.Conflicts.HierarchyConflictTextProviderBase textProvider) { }
        public string Description { get; }
        public JetBrains.ReSharper.Psi.IOverridableMember ImplementedMember { get; }
        public bool IsValid { get; }
        public JetBrains.ReSharper.Psi.IOverridableMember Member { get; }
        public JetBrains.ReSharper.Refactorings.Conflicts.ConflictSeverity Severity { get; }
        public bool Equals(JetBrains.ReSharper.Refactorings.Conflicts.MemberImplementsConflict memberInplementsConflict) { }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
    }
    public class NewLocalElementConflictSearcher : JetBrains.ReSharper.Refactorings.Conflicts.IConflictSearcher
    {
        public NewLocalElementConflictSearcher(JetBrains.ReSharper.Psi.Tree.ITreeNode container, string name) { }
        public NewLocalElementConflictSearcher(JetBrains.ReSharper.Psi.Tree.ITreeNode container, string name, JetBrains.ReSharper.Psi.IDeclaredElement[] elementsToIgnore) { }
        public JetBrains.ReSharper.Refactorings.Conflicts.ConflictSearchResult SearchConflicts(JetBrains.Application.Progress.IProgressIndicator pi, bool canPerformRefactoring) { }
    }
    public class NewTypeElementConflictSearcher : JetBrains.ReSharper.Refactorings.Conflicts.IConflictSearcher
    {
        public NewTypeElementConflictSearcher(string newName, JetBrains.ProjectModel.ISolution solution, JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext context) { }
        public JetBrains.ReSharper.Refactorings.Conflicts.ConflictSearchResult SearchConflicts(JetBrains.Application.Progress.IProgressIndicator pi, bool canPerformRefactoring) { }
    }
    public class NewTypeMemberConflictSearcher : JetBrains.ReSharper.Refactorings.Conflicts.IConflictSearcher
    {
        public NewTypeMemberConflictSearcher(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.ITypeMember> typeMembers, JetBrains.ReSharper.Psi.ITypeElement typeElement) { }
        public NewTypeMemberConflictSearcher([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.ITypeMember typeMember, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.ITypeElement typeElement) { }
        public JetBrains.ReSharper.Refactorings.Conflicts.ConflictSearchResult SearchConflicts(JetBrains.Application.Progress.IProgressIndicator pi, bool canPerformRefactoring) { }
    }
    public class OverridesConflict : JetBrains.ReSharper.Refactorings.Conflicts.IConflict
    {
        public OverridesConflict(JetBrains.ReSharper.Psi.PsiLanguageType languageType, JetBrains.ReSharper.Psi.IOverridableMember overriden, JetBrains.ReSharper.Psi.IOverridableMember overriding) { }
        public string Description { get; }
        public bool IsValid { get; }
        public JetBrains.ReSharper.Psi.IOverridableMember Overriden { get; }
        public JetBrains.ReSharper.Psi.IOverridableMember Overriding { get; }
        public JetBrains.ReSharper.Refactorings.Conflicts.ConflictSeverity Severity { get; }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
    }
    public class ReferenceConflict : JetBrains.ReSharper.Refactorings.Conflicts.IConflict
    {
        public string Description { get; }
        public bool IsValid { get; }
        public JetBrains.ReSharper.Psi.Resolve.IReference Reference { get; }
        public JetBrains.ReSharper.Refactorings.Conflicts.ConflictSeverity Severity { get; }
        public static JetBrains.ReSharper.Refactorings.Conflicts.ReferenceConflict CreateError(JetBrains.ReSharper.Psi.Resolve.IReference reference, string descriptionFormat, string tagFormat) { }
        public static JetBrains.ReSharper.Refactorings.Conflicts.ReferenceConflict CreateError(JetBrains.ReSharper.Psi.Resolve.IReference reference, string descriptionFormat) { }
        public static JetBrains.ReSharper.Refactorings.Conflicts.ReferenceConflict CreateWarning(JetBrains.ReSharper.Psi.Resolve.IReference reference, string descriptionFormat, string tagFormat) { }
        public static JetBrains.ReSharper.Refactorings.Conflicts.ReferenceConflict CreateWarning(JetBrains.ReSharper.Psi.Resolve.IReference reference, string descriptionFormat) { }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
    }
    [JetBrains.UI.ActiveText.ProtocolHandlerAttribute(Protocol="reference")]
    public class ReferenceProtocolHandler : JetBrains.UI.ActiveText.ProtocolHandler
    {
        protected override void NavigateNakedLink(string link, object host) { }
    }
    public class TextConflict : JetBrains.ReSharper.Refactorings.Conflicts.IConflict
    {
        public TextConflict(string myDescription, JetBrains.ReSharper.Refactorings.Conflicts.ConflictSeverity mySeverity) { }
        public string Description { get; }
        public bool IsValid { get; }
        public JetBrains.ReSharper.Refactorings.Conflicts.ConflictSeverity Severity { get; }
    }
    public class TypeMemberQualifier
    {
        public TypeMemberQualifier(JetBrains.ReSharper.Psi.Tree.ITreeNode scope) { }
        public void Collect() { }
        public void FixConflicts() { }
    }
    public class UnsupportedAspConflict : JetBrains.ReSharper.Refactorings.Conflicts.IConflict
    {
        public UnsupportedAspConflict(JetBrains.ReSharper.Psi.Tree.ITreeNode element, string presentation) { }
        public UnsupportedAspConflict(JetBrains.ReSharper.Psi.Tree.ITreeNode element, string presentation, string text) { }
        public UnsupportedAspConflict(JetBrains.ReSharper.Psi.Tree.ITreeNode element, string presentation, string text, JetBrains.ReSharper.Refactorings.Conflicts.ConflictSeverity severity) { }
        public string Description { get; }
        public JetBrains.ReSharper.Psi.Tree.ITreeNode Element { get; }
        public bool IsValid { get; }
        public JetBrains.ReSharper.Refactorings.Conflicts.ConflictSeverity Severity { get; }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
    }
    public class UnsupportedLanguageConflict : JetBrains.ReSharper.Refactorings.Conflicts.IConflict
    {
        public UnsupportedLanguageConflict(JetBrains.ReSharper.Psi.Tree.ITreeNode element, string presentation) { }
        public UnsupportedLanguageConflict(JetBrains.ReSharper.Psi.Tree.ITreeNode element, string presentation, JetBrains.ReSharper.Refactorings.Conflicts.ConflictSeverity severity) { }
        public string Description { get; }
        public JetBrains.ReSharper.Psi.Tree.ITreeNode Element { get; }
        public bool IsValid { get; }
        public JetBrains.ReSharper.Refactorings.Conflicts.ConflictSeverity Severity { get; }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
    }
    public class UnsupportedLanguageConflictSearcher<T> : JetBrains.ReSharper.Refactorings.Conflicts.IConflictSearcher
        where T :  class
    {
        public UnsupportedLanguageConflictSearcher() { }
        public void AddDeclarations(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Tree.IDeclaration> declarations) { }
        public void AddEntries<TEntity>(System.Collections.Generic.IEnumerable<TEntity> ts, JetBrains.ReSharper.Refactorings.Conflicts.UnsupportedLanguageConflictSearcher<T>.LanguageSpecificEntity<TEntity>.ElementEvaluator elementEvaluator, JetBrains.ReSharper.Refactorings.Conflicts.UnsupportedLanguageConflictSearcher<T>.LanguageSpecificEntity<TEntity>.Presenter presenter) { }
        public void AddReferences(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Resolve.IReference> references, JetBrains.ReSharper.Refactorings.Conflicts.UnsupportedLanguageConflictSearcher<T>.LanguageSpecificEntity<JetBrains.ReSharper.Psi.Resolve.IReference>.Presenter presenter) { }
        public void AddReferences(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Resolve.IReference> references) { }
        public JetBrains.ReSharper.Refactorings.Conflicts.ConflictSearchResult SearchConflicts(JetBrains.Application.Progress.IProgressIndicator pi, bool canPerformRefactoring) { }
        public interface ILanguageSpecificEntity<T>
            where T :  class
        {
            JetBrains.ReSharper.Psi.Tree.ITreeNode Element { get; }
            string Name { get; }
        }
        public class LanguageSpecificEntity<T, TEntity> : JetBrains.ReSharper.Refactorings.Conflicts.UnsupportedLanguageConflictSearcher<T>.ILanguageSpecificEntity
            where T :  class
        
        {
            public LanguageSpecificEntity([JetBrains.Annotations.NotNullAttribute()] TEntity entity, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Refactorings.Conflicts.UnsupportedLanguageConflictSearcher<T>.LanguageSpecificEntity<TEntity>.Presenter presenter, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Refactorings.Conflicts.UnsupportedLanguageConflictSearcher<T>.LanguageSpecificEntity<TEntity>.ElementEvaluator elementEvaluator) { }
            public JetBrains.ReSharper.Psi.Tree.ITreeNode Element { get; }
            public string Name { get; }
            public delegate JetBrains.ReSharper.Psi.Tree.ITreeNode ElementEvaluator<T, TEntity>(TEntity t);
            public delegate string Presenter<T, TEntity>(TEntity t);
        }
        public class ReferenceLanguageSpecificEntity<T> : JetBrains.ReSharper.Refactorings.Conflicts.UnsupportedLanguageConflictSearcher<T>.LanguageSpecificEntity<JetBrains.ReSharper.Psi.Resolve.IReference>
            where T :  class
        {
            public ReferenceLanguageSpecificEntity(JetBrains.ReSharper.Psi.Resolve.IReference entity, JetBrains.ReSharper.Refactorings.Conflicts.UnsupportedLanguageConflictSearcher<T>.LanguageSpecificEntity<JetBrains.ReSharper.Psi.Resolve.IReference>.Presenter presenter) { }
        }
    }
}
namespace JetBrains.ReSharper.Refactorings.Conflicts.Convert
{
    
    public class ConflictNotMatchedDefault : JetBrains.ReSharper.Refactorings.Conflicts.ConflictWithDeclaredElement
    {
        public ConflictNotMatchedDefault(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
    }
    public class ConflictPropertyWithGetterExist : JetBrains.ReSharper.Refactorings.Conflicts.ConflictWithDeclaredElement
    {
        public ConflictPropertyWithGetterExist(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
    }
    public class ConflictPropertyWithSetterExist : JetBrains.ReSharper.Refactorings.Conflicts.ConflictWithDeclaredElement
    {
        public ConflictPropertyWithSetterExist(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
    }
    public class ConflictWithHandlesClause : JetBrains.ReSharper.Refactorings.Conflicts.ConflictWithDeclaredElement
    {
        public ConflictWithHandlesClause(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
    }
    public class ConflictWithLastArgumentOptional : JetBrains.ReSharper.Refactorings.Conflicts.ConflictWithDeclaredElement
    {
        public ConflictWithLastArgumentOptional(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
    }
    public class ConflictWithModifiers : JetBrains.ReSharper.Refactorings.Conflicts.ConflictWithDeclaredElement
    {
        public ConflictWithModifiers(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
    }
    public class ConflictWithNotByValueParameter : JetBrains.ReSharper.Refactorings.Conflicts.ConflictWithDeclaredElement
    {
        public ConflictWithNotByValueParameter(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
    }
    public class ConflictWithParametersModifiers : JetBrains.ReSharper.Refactorings.Conflicts.ConflictWithDeclaredElement
    {
        public ConflictWithParametersModifiers(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
    }
    public class ConflictWrongIndexerName : JetBrains.ReSharper.Refactorings.Conflicts.ConflictWithDeclaredElement
    {
        public ConflictWrongIndexerName(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
    }
    public class PropertyCantHaveGenericArguments : JetBrains.ReSharper.Refactorings.Conflicts.ConflictWithDeclaredElement
    {
        public PropertyCantHaveGenericArguments(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
    }
    public class PropertyFoundButItIsNotDefault : JetBrains.ReSharper.Refactorings.Conflicts.ConflictWithDeclaredElement
    {
        public PropertyFoundButItIsNotDefault(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
    }
    public class PropertyStaticNotEqual : JetBrains.ReSharper.Refactorings.Conflicts.ConflictWithDeclaredElement
    {
        public PropertyStaticNotEqual(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
    }
    public class PropertyWithAccessorIsIsPresented : JetBrains.ReSharper.Refactorings.Conflicts.ConflictWithDeclaredElement
    {
        public PropertyWithAccessorIsIsPresented(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, string accessor) { }
    }
    public class PropertyWithAnotherTypeIsPresented : JetBrains.ReSharper.Refactorings.Conflicts.ConflictWithDeclaredElement
    {
        public PropertyWithAnotherTypeIsPresented(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
    }
}
namespace JetBrains.ReSharper.Refactorings.Conflicts.New
{
    
    public class Conflict : JetBrains.ReSharper.Refactorings.Conflicts.IConflict
    {
        public Conflict(JetBrains.ProjectModel.ISolution solution, string text, JetBrains.ReSharper.Refactorings.Conflicts.ConflictSeverity severity, params object[] parms) { }
        public string Description { get; }
        public bool IsValid { get; }
        public JetBrains.ReSharper.Refactorings.Conflicts.ConflictSeverity Severity { get; }
        public void Navigate(string link) { }
    }
    public class TaggedReference
    {
        public TaggedReference(string tag, JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public JetBrains.ReSharper.Psi.Resolve.IReference Reference { get; }
        public string Tag { get; }
    }
}
namespace JetBrains.ReSharper.Refactorings.Constructor2FactoryMethod
{
    
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "Constructor2FactoryMethodAction"})]
    public class Constructor2FactoryAction : JetBrains.ReSharper.Refactorings.Workflow.ExtensibleRefactoringAction<JetBrains.ReSharper.Refactorings.Constructor2FactoryMethod.IConstructor2FactoryWorkflowProvider>
    {
        public const string ACTION_ID = "Constructor2FactoryMethodAction";
        protected override JetBrains.UI.RichText.RichText Caption { get; }
    }
    public class Constructor2FactoryMethodData
    {
        public Constructor2FactoryMethodData(string[] factorymethodNames, string targetClassName) { }
        public string FactorymethodName { get; set; }
        public string[] FactorymethodNames { get; }
        public string TargetClassCLRName { get; set; }
        public string TargetClassName { get; set; }
    }
    public class Constructor2FactoryMethodRefactoring : JetBrains.ReSharper.Refactorings.Common.DrivenRefactoring<JetBrains.ReSharper.Refactorings.Constructor2FactoryMethod.Constructor2FactoryMethodWorkflow, JetBrains.ReSharper.Refactorings.Constructor2FactoryMethod.ConstructorToFactoryMethodBase>, JetBrains.ReSharper.Refactorings.Constructor2FactoryMethod.IConstructor2FactoryMethodExecuter, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringExecuter
    {
        public Constructor2FactoryMethodRefactoring(JetBrains.ReSharper.Refactorings.Constructor2FactoryMethod.Constructor2FactoryMethodWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ReSharper.Psi.IConstructor Constructor { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ReSharper.Psi.IClass OwnerClass { get; }
        public JetBrains.ReSharper.Psi.Tree.IDeclaration AddClassMember(JetBrains.ReSharper.Psi.Tree.IDeclaration decl) { }
        protected override JetBrains.ReSharper.Refactorings.Constructor2FactoryMethod.ConstructorToFactoryMethodBase CreateRefactoringInternal(JetBrains.ReSharper.Refactorings.InternalRefactoringLanguageService service) { }
        public void CreateTypeParameters(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration) { }
        public override bool Execute(JetBrains.Application.Progress.IProgressIndicator pi) { }
        public string GetAllParameters() { }
        public JetBrains.ReSharper.Psi.IType GetReturnType() { }
        public JetBrains.ReSharper.Psi.IType GetTypeOfImage(JetBrains.ReSharper.Psi.IType type) { }
        public JetBrains.ReSharper.Psi.IType GetTypeOfImageNoRight(JetBrains.ReSharper.Psi.IType type) { }
        public JetBrains.ReSharper.Psi.Resolve.ISubstitution MakeSubstitution(JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution) { }
        public void ProcessResolveResult(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.Resolve.ResolveErrorType result) { }
        public void ProcessResolveResultOfParameter(JetBrains.ReSharper.Psi.IParameter parameter, JetBrains.ReSharper.Psi.Resolve.ResolveErrorType result) { }
        public void SetAccessRights(JetBrains.ReSharper.Psi.Tree.IDeclaration decl) { }
    }
    [JetBrains.Application.Settings.SettingsKeyAttribute(typeof(JetBrains.ReSharper.Refactorings.RefactoringsMruSettings), "Constructor to Factory Method refactoring settings")]
    public class Constructor2FactoryMethodSettings
    {
        [JetBrains.Application.Settings.SettingsEntryAttribute("Create", "Default factory method prefix")]
        public string DefaultFactoryMethodPrefix;
        [JetBrains.Application.Settings.SettingsEntryAttribute("", "Default factory method suffix")]
        public string DefaultFactoryMethodSuffix;
    }
    [JetBrains.Application.Configuration.Upgrade.GlobalSettingsUpgraderAttribute()]
    public class Constructor2FactoryMethodSettingsUpgrader : JetBrains.Application.Configuration.SettingTablesUpgrader
    {
        public Constructor2FactoryMethodSettingsUpgrader(JetBrains.Application.Env.RunsProducts.ProductConfigurations productConfigurations) { }
        protected override void DoUpgrade(JetBrains.Application.Configuration.IComponentSettingsProvider legacySettingsProvider, JetBrains.Application.Settings.IContextBoundSettingsStore boundSettingsStore, JetBrains.DataFlow.Lifetime upgradeLifetime, JetBrains.Application.Configuration.SettingsTableBase workspaceSettingsTable, JetBrains.Application.Configuration.SettingsTableBase globalSettingsTable) { }
    }
    public class Constructor2FactoryMethodWindow : JetBrains.UI.CommonControls.SafeTableLayoutPanel, JetBrains.CommonControls.Validation.IValidatorProvider, JetBrains.ReSharper.Refactorings.Constructor2FactoryMethod.IConstructor2FactoryMethodWindow, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage
    {
        public Constructor2FactoryMethodWindow(JetBrains.ReSharper.Refactorings.Constructor2FactoryMethod.Constructor2FactoryMethodWorkflow workflow) { }
        public JetBrains.DataFlow.IProperty<bool> ContinueEnabled { get; }
        public string Description { get; }
        public bool DoNotShow { get; }
        public string Title { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.CommonControls.Validation.IValidator> Validators { get; }
        public JetBrains.UI.CrossFramework.EitherControl View { get; }
        public JetBrains.ReSharper.Refactorings.Constructor2FactoryMethod.Constructor2FactoryMethodWorkflow Workflow { get; }
        public JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage Commit(JetBrains.Application.Progress.IProgressIndicator pi) { }
        public bool Initialize(JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
        public bool RefreshContents(JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
        public void SetTestData(string methodName, string targetClass) { }
    }
    public class Constructor2FactoryMethodWorkflow : JetBrains.ReSharper.Refactorings.Workflow.DrivenRefactoringWorkflow
    {
        public Constructor2FactoryMethodWorkflow(JetBrains.ProjectModel.ISolution solution, string name, string className, string actionId) { }
        public Constructor2FactoryMethodWorkflow(JetBrains.ProjectModel.ISolution solution, string actionId) { }
        public override JetBrains.ReSharper.Refactorings.Workflow.RefactoringActionGroup ActionGroup { get; }
        public JetBrains.ReSharper.Psi.IConstructor Constructor { get; }
        public JetBrains.ReSharper.Refactorings.Constructor2FactoryMethod.Constructor2FactoryMethodData Data { get; }
        public override JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage FirstPendingRefactoringPage { get; }
        public override string HelpKeyword { get; }
        public JetBrains.ReSharper.Psi.PsiLanguageType LanguageType { get; set; }
        public override bool MightModifyManyDocuments { get; }
        public JetBrains.ReSharper.Psi.IClass OwnerClass { get; }
        public override string Title { get; }
        public override JetBrains.ReSharper.Refactorings.Workflow.IRefactoringExecuter CreateRefactoring(JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public override bool Initialize(JetBrains.Application.DataContext.IDataContext context) { }
        public override bool IsAvailable(JetBrains.Application.DataContext.IDataContext context) { }
        public override bool PreExecute(JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
        public override bool Validate() { }
    }
    public abstract class ConstructorToFactoryMethodBase : JetBrains.ReSharper.Refactorings.Common.RefactoringExecBase<JetBrains.ReSharper.Refactorings.Constructor2FactoryMethod.Constructor2FactoryMethodWorkflow, JetBrains.ReSharper.Refactorings.Constructor2FactoryMethod.Constructor2FactoryMethodRefactoring>
    {
        protected ConstructorToFactoryMethodBase(JetBrains.ReSharper.Refactorings.Constructor2FactoryMethod.Constructor2FactoryMethodWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public abstract void ConvertUsage(JetBrains.ReSharper.Psi.ITypeMember method, JetBrains.ReSharper.Psi.Resolve.IReference reference);
        public abstract JetBrains.ReSharper.Psi.ITypeMember CreateFactoryMethodDeclaration(JetBrains.ReSharper.Psi.ITypeElement targetTypeElement, JetBrains.ReSharper.Psi.IConstructor constructorToCall, string factorymethodName);
        public abstract string GetModifiersString(JetBrains.ReSharper.Psi.IParameter x);
        public virtual bool IsBaseConstructorInitializer(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
    }
    public interface IConstructor2FactoryMethodExecuter : JetBrains.ReSharper.Refactorings.Workflow.IRefactoringExecuter { }
    public interface IConstructor2FactoryMethodWindow : JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage
    {
        void SetTestData(string methodName, string targetClass);
    }
    public interface IConstructor2FactoryWorkflowProvider : JetBrains.ReSharper.Feature.Services.ActionsMenu.IWorkflowProvider<JetBrains.ReSharper.Refactorings.Workflow.IRefactoringWorkflow, JetBrains.ReSharper.Refactorings.Workflow.RefactoringActionGroup>, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringWorkflowProvider { }
}
namespace JetBrains.ReSharper.Refactorings.Constructor2FactoryMethod.Util
{
    
    [System.ObsoleteAttribute("Cannot be injected, replace with validator provider.")]
    public class TypeChooserValidatorAttribute : JetBrains.CommonControls.Validation.ValidationAttribute
    {
        public TypeChooserValidatorAttribute(string message, JetBrains.CommonControls.Validation.ValidatorSeverity severity) { }
        public TypeChooserValidatorAttribute(string message, JetBrains.CommonControls.Validation.ValidatorSeverity severity, bool canBeEmpty) { }
        public override JetBrains.CommonControls.Validation.IValidator BuildValidator(System.Windows.Forms.Control control, object host) { }
    }
}
namespace JetBrains.ReSharper.Refactorings.Convert.Abstract2Interface
{
    
    public class Abstract2InterfaceRefactoring : JetBrains.ReSharper.Refactorings.Convert.Abstract2Interface.IAbstract2InterfaceExecuter, JetBrains.ReSharper.Refactorings.Convert.Common.IConvertTypeRefactoring, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringExecuter
    {
        public Abstract2InterfaceRefactoring(JetBrains.ReSharper.Refactorings.Convert.Abstract2Interface.Abstract2InterfaceWorkflow workFlow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver Driver { get; }
        public JetBrains.ReSharper.Refactorings.LanguageMapOfRefactoring<JetBrains.ReSharper.Refactorings.Convert.Common.IConvert> Exec { get; }
        public JetBrains.ProjectModel.ISolution Solution { get; }
        public JetBrains.ReSharper.Psi.IClass SourceClass { get; }
        public JetBrains.ReSharper.Refactorings.Convert.Abstract2Interface.Abstract2InterfaceWorkflow Workflow { get; }
        public void AddInterfaceSpecificationToOverrides(JetBrains.ReSharper.Psi.IOverridableMember member, JetBrains.Application.Progress.IProgressIndicator pi) { }
        public bool Execute(JetBrains.Application.Progress.IProgressIndicator pi) { }
        public bool Ignore(JetBrains.ReSharper.Psi.IDeclaredElement element) { }
        public void MakeOverridePublic(JetBrains.ReSharper.Psi.IOverridableMember member) { }
        public void MakeOverridesPublic(JetBrains.ReSharper.Psi.IOverridableMember overridable, JetBrains.Application.Progress.IProgressIndicator pi) { }
        public bool MakeVirtual(JetBrains.ReSharper.Psi.IOverridableMember member) { }
    }
    public class Abstract2InterfaceWorkflow : JetBrains.ReSharper.Refactorings.Workflow.DrivenRefactoringWorkflow, JetBrains.ReSharper.Refactorings.Convert.Common.IConvertTypeWorkflow
    {
        public Abstract2InterfaceWorkflow(JetBrains.ProjectModel.ISolution solution, string actionId) { }
        public override JetBrains.ReSharper.Refactorings.Workflow.RefactoringActionGroup ActionGroup { get; }
        public JetBrains.ReSharper.Psi.Pointers.IDeclaredElementPointer<JetBrains.ReSharper.Psi.IClass> ClassPointer { get; }
        public override JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage FirstPendingRefactoringPage { get; }
        public override string HelpKeyword { get; }
        public override bool MightModifyManyDocuments { get; }
        public override string Title { get; }
        public override JetBrains.ReSharper.Refactorings.Workflow.IRefactoringExecuter CreateRefactoring(JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public override bool Initialize(JetBrains.Application.DataContext.IDataContext context) { }
        public override bool IsAvailable(JetBrains.Application.DataContext.IDataContext context) { }
        public override bool PreExecute(JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
        public override bool Validate() { }
    }
    public interface IAbstract2InterfaceExecuter : JetBrains.ReSharper.Refactorings.Convert.Common.IConvertTypeRefactoring, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringExecuter
    {
        void AddInterfaceSpecificationToOverrides(JetBrains.ReSharper.Psi.IOverridableMember member, JetBrains.Application.Progress.IProgressIndicator pi);
        bool Ignore(JetBrains.ReSharper.Psi.IDeclaredElement element);
        void MakeOverridePublic(JetBrains.ReSharper.Psi.IOverridableMember member);
        void MakeOverridesPublic(JetBrains.ReSharper.Psi.IOverridableMember overridable, JetBrains.Application.Progress.IProgressIndicator pi);
        bool MakeVirtual(JetBrains.ReSharper.Psi.IOverridableMember member);
    }
}
namespace JetBrains.ReSharper.Refactorings.Convert.Actions
{
    
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "Abstract2Interface"})]
    public class Abstract2InterfaceAction : JetBrains.ReSharper.Refactorings.Workflow.ExtensibleRefactoringAction<JetBrains.ReSharper.Refactorings.Convert.Actions.IAbstract2InterfaceWorkflowProvider>
    {
        public const string ACTION_ID = "Abstract2Interface";
        protected override JetBrains.UI.RichText.RichText Caption { get; }
    }
    public interface IAbstract2InterfaceWorkflowProvider : JetBrains.ReSharper.Feature.Services.ActionsMenu.IWorkflowProvider<JetBrains.ReSharper.Refactorings.Workflow.IRefactoringWorkflow, JetBrains.ReSharper.Refactorings.Workflow.RefactoringActionGroup>, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringWorkflowProvider { }
    public interface IInterface2AbstractWorkflowProvider : JetBrains.ReSharper.Feature.Services.ActionsMenu.IWorkflowProvider<JetBrains.ReSharper.Refactorings.Workflow.IRefactoringWorkflow, JetBrains.ReSharper.Refactorings.Workflow.RefactoringActionGroup>, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringWorkflowProvider { }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "Interface2Abstract"})]
    public class Interface2AbstractAction : JetBrains.ReSharper.Refactorings.Workflow.ExtensibleRefactoringAction<JetBrains.ReSharper.Refactorings.Convert.Actions.IInterface2AbstractWorkflowProvider>
    {
        public const string ACTION_ID = "Interface2Abstract";
        protected override JetBrains.UI.RichText.RichText Caption { get; }
    }
}
namespace JetBrains.ReSharper.Refactorings.Convert.Common
{
    
    public class ConvertedMemberInfo
    {
        public ConvertedMemberInfo(JetBrains.ReSharper.Refactorings.Convert.Common.MemberTypes memberTypes, JetBrains.ReSharper.Psi.ITypeMember memebr) { }
        public JetBrains.ReSharper.Psi.ITypeMember Member { get; }
        public JetBrains.ReSharper.Refactorings.Convert.Common.MemberTypes MemberTypes { get; set; }
    }
    public abstract class ConvertTypeBase<TClassMemberDecl, TClassDecl> : JetBrains.ReSharper.Refactorings.Convert.Common.IConvert, JetBrains.ReSharper.Refactorings.IRefactoringExec
        where TClassMemberDecl : JetBrains.ReSharper.Psi.Tree.IDeclaration
        where TClassDecl : JetBrains.ReSharper.Psi.Tree.IDeclaration
    {
        protected ConvertTypeBase(JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public virtual bool AllImplementationsAreExplicit { get; }
        protected JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver Driver { get; }
        protected JetBrains.ReSharper.Refactorings.Convert.Common.IConvertTypeRefactoring Executer { get; }
        public JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver RefactoringDriver { set; }
        public virtual void AddImplements(JetBrains.ReSharper.Psi.IClass inheritor) { }
        public virtual void AddImplementsSpecifications() { }
        public abstract void AddInterface(JetBrains.ReSharper.Psi.ITypeElement typeElement, JetBrains.ReSharper.Psi.IExplicitImplementation interfaceToAdd);
        public virtual void AddInterfaceSpecificationToOverride(JetBrains.ReSharper.Psi.IOverridableMember over, JetBrains.ReSharper.Psi.IClass @class) { }
        protected abstract void AddSuperInterface(JetBrains.ReSharper.Psi.Tree.ITypeDeclaration to, JetBrains.ReSharper.Psi.IDeclaredType newSuprtType);
        protected void AddSuperTypes(JetBrains.ReSharper.Psi.Tree.ITypeDeclaration to, JetBrains.ReSharper.Psi.ITypeElement toElement, JetBrains.ReSharper.Psi.Tree.ITypeDeclaration from) { }
        protected abstract bool CanCallMoreGeneric(JetBrains.ReSharper.Psi.OverridableMemberInstance moreGenericInstance, JetBrains.ReSharper.Psi.OverridableMemberInstance lessGenericInstance, TClassDecl clsss);
        protected void CollectImplementationsGroups(TClassDecl clsss, System.Collections.Generic.IList<JetBrains.ReSharper.Refactorings.Convert.Common.ElementInstancePointer> elementPointers) { }
        public abstract void CreateClassDeclaration(JetBrains.ReSharper.Psi.IInterface interfccc);
        public virtual void FixImplementsToInherits(JetBrains.ReSharper.Psi.ITypeElement implementor, JetBrains.ReSharper.Psi.IInterface @interface) { }
        protected static JetBrains.ReSharper.Psi.Resolve.ISubstitution GetMatchedSubstitutionBack(System.Collections.Generic.IList<JetBrains.ReSharper.Psi.ITypeParameter> oldParameters, System.Collections.Generic.IList<JetBrains.ReSharper.Psi.ITypeParameter> newParameters) { }
        public abstract void ImplementsMembersAbstract();
        public virtual bool IsSupported() { }
        protected abstract System.Collections.Generic.IEnumerable<TClassMemberDecl> MakeAbstractDeclaration(TClassDecl clsss, JetBrains.ReSharper.Refactorings.Convert.Common.ElementInstancePointer pointer, int indexForVB, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IType> lsitOfTypes, bool makePrivate);
        protected abstract void MakeCallMoreGeneric(TClassDecl clsss, JetBrains.ReSharper.Refactorings.Convert.Common.ElementInstancePointer memberCaller, JetBrains.ReSharper.Refactorings.Convert.Common.ElementInstancePointer memberCallee, JetBrains.ReSharper.Psi.IType type);
        protected abstract void MakePrivateImplementation(JetBrains.ReSharper.Refactorings.Convert.Common.ElementInstancePointer pointer, TClassMemberDecl newDecl);
        public abstract void MakePublic(JetBrains.ReSharper.Psi.IOverridableMember member);
        public abstract void MakePublicOverride(JetBrains.ReSharper.Psi.IOverridableMember memebr, JetBrains.ReSharper.Psi.IDeclaredType declTypeToRemove);
        public abstract bool MakeVirtual(JetBrains.ReSharper.Psi.IOverridableMember member);
        protected abstract void Privatizate(TClassMemberDecl newDecl);
        public abstract void ProcessOtherMember(JetBrains.ReSharper.Psi.ITypeMember member);
        public abstract bool ProcessOverridableMember(JetBrains.ReSharper.Psi.IOverridableMember overridable, JetBrains.Application.Progress.IProgressIndicator pi);
        public abstract void RemoveDeclaration(JetBrains.ReSharper.Psi.IOverridableMember memebr);
        public virtual void RemoveInherits(JetBrains.ReSharper.Psi.IClass clsss, JetBrains.ReSharper.Psi.IClass source) { }
        public abstract void RemoveInterface(JetBrains.ReSharper.Psi.ITypeElement implementor, JetBrains.ReSharper.Psi.IInterface interfaceToRemove);
        public abstract void ReplaceMembers(JetBrains.ReSharper.Psi.IClass clsss);
        public void SetExecuter(JetBrains.ReSharper.Refactorings.Convert.Common.IConvertTypeRefactoring refactoring) { }
    }
    public class ConvertUnsupported : JetBrains.ReSharper.Refactorings.Convert.Common.ConvertTypeBase<JetBrains.ReSharper.Psi.Tree.ITypeMemberDeclaration, JetBrains.ReSharper.Psi.Tree.ITypeDeclaration>
    {
        public ConvertUnsupported(JetBrains.ReSharper.Refactorings.Convert.Common.IConvertTypeWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public override void AddInterface(JetBrains.ReSharper.Psi.ITypeElement typeElement, JetBrains.ReSharper.Psi.IExplicitImplementation interfaceToAdd) { }
        protected override void AddSuperInterface(JetBrains.ReSharper.Psi.Tree.ITypeDeclaration to, JetBrains.ReSharper.Psi.IDeclaredType newSuprtType) { }
        protected override bool CanCallMoreGeneric(JetBrains.ReSharper.Psi.OverridableMemberInstance moreGenericInstance, JetBrains.ReSharper.Psi.OverridableMemberInstance lessGenericInstance, JetBrains.ReSharper.Psi.Tree.ITypeDeclaration clsss) { }
        public override void CreateClassDeclaration(JetBrains.ReSharper.Psi.IInterface interfccc) { }
        public override void ImplementsMembersAbstract() { }
        public override bool IsSupported() { }
        protected override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Tree.ITypeMemberDeclaration> MakeAbstractDeclaration(JetBrains.ReSharper.Psi.Tree.ITypeDeclaration clsss, JetBrains.ReSharper.Refactorings.Convert.Common.ElementInstancePointer pointer, int indexForVB, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IType> lsitOfTypes, bool makePrivate) { }
        protected override void MakeCallMoreGeneric(JetBrains.ReSharper.Psi.Tree.ITypeDeclaration clsss, JetBrains.ReSharper.Refactorings.Convert.Common.ElementInstancePointer memberCaller, JetBrains.ReSharper.Refactorings.Convert.Common.ElementInstancePointer memberCallee, JetBrains.ReSharper.Psi.IType type) { }
        protected override void MakePrivateImplementation(JetBrains.ReSharper.Refactorings.Convert.Common.ElementInstancePointer pointer, JetBrains.ReSharper.Psi.Tree.ITypeMemberDeclaration newDecl) { }
        public override void MakePublic(JetBrains.ReSharper.Psi.IOverridableMember member) { }
        public override void MakePublicOverride(JetBrains.ReSharper.Psi.IOverridableMember memebr, JetBrains.ReSharper.Psi.IDeclaredType declTypeToRemove) { }
        public override bool MakeVirtual(JetBrains.ReSharper.Psi.IOverridableMember member) { }
        protected override void Privatizate(JetBrains.ReSharper.Psi.Tree.ITypeMemberDeclaration newDecl) { }
        public override void ProcessOtherMember(JetBrains.ReSharper.Psi.ITypeMember member) { }
        public override bool ProcessOverridableMember(JetBrains.ReSharper.Psi.IOverridableMember overridable, JetBrains.Application.Progress.IProgressIndicator pi) { }
        public override void RemoveDeclaration(JetBrains.ReSharper.Psi.IOverridableMember memebr) { }
        public override void RemoveInterface(JetBrains.ReSharper.Psi.ITypeElement implementor, JetBrains.ReSharper.Psi.IInterface interfaceToRemove) { }
        public override void ReplaceMembers(JetBrains.ReSharper.Psi.IClass clsss) { }
    }
    [System.ObsoleteAttribute("Use IElementInstancePointer instead, but fix GetHashCode & Equals in it")]
    public class ElementInstancePointer
    {
        public ElementInstancePointer(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution) { }
        public JetBrains.ReSharper.Psi.IDeclaredElement DeclaredElement { get; }
        public JetBrains.ReSharper.Psi.Resolve.ISubstitution Substitution { get; }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
    }
    public class GenericSignature : System.IEquatable<JetBrains.ReSharper.Refactorings.Convert.Common.GenericSignature>
    {
        public GenericSignature(string name) { }
        public GenericSignature(JetBrains.ReSharper.Psi.InvocableSignature signature) { }
        public static JetBrains.ReSharper.Refactorings.Convert.Common.GenericSignature Create(JetBrains.ReSharper.Psi.ITypeMember member, JetBrains.ReSharper.Psi.Resolve.ISubstitution subst) { }
        public bool Equals(JetBrains.ReSharper.Refactorings.Convert.Common.GenericSignature genericSignature) { }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
    }
    public interface IConvert : JetBrains.ReSharper.Refactorings.IRefactoringExec
    {
        bool AllImplementationsAreExplicit { get; }
        void AddImplements(JetBrains.ReSharper.Psi.IClass inheritor);
        void AddImplementsSpecifications();
        void AddInterface(JetBrains.ReSharper.Psi.ITypeElement typeElement, JetBrains.ReSharper.Psi.IExplicitImplementation interfaceToAdd);
        void AddInterfaceSpecificationToOverride(JetBrains.ReSharper.Psi.IOverridableMember over, JetBrains.ReSharper.Psi.IClass @class);
        void CreateClassDeclaration(JetBrains.ReSharper.Psi.IInterface interfccc);
        void FixImplementsToInherits(JetBrains.ReSharper.Psi.ITypeElement implementor, JetBrains.ReSharper.Psi.IInterface @interface);
        void ImplementsMembersAbstract();
        bool IsSupported();
        void MakePublic(JetBrains.ReSharper.Psi.IOverridableMember member);
        void MakePublicOverride(JetBrains.ReSharper.Psi.IOverridableMember memebr, JetBrains.ReSharper.Psi.IDeclaredType declTypeToRemove);
        bool MakeVirtual(JetBrains.ReSharper.Psi.IOverridableMember member);
        void ProcessOtherMember(JetBrains.ReSharper.Psi.ITypeMember member);
        bool ProcessOverridableMember(JetBrains.ReSharper.Psi.IOverridableMember overridable, JetBrains.Application.Progress.IProgressIndicator pi);
        void RemoveDeclaration(JetBrains.ReSharper.Psi.IOverridableMember memebr);
        void RemoveInherits(JetBrains.ReSharper.Psi.IClass clsss, JetBrains.ReSharper.Psi.IClass source);
        void RemoveInterface(JetBrains.ReSharper.Psi.ITypeElement implementor, JetBrains.ReSharper.Psi.IInterface interfaceToRemove);
        void ReplaceMembers(JetBrains.ReSharper.Psi.IClass clsss);
        void SetExecuter(JetBrains.ReSharper.Refactorings.Convert.Common.IConvertTypeRefactoring refactoring);
    }
    public interface IConvertTypeRefactoring { }
    public interface IConvertTypeWorkflow { }
    public abstract class InterfaceMembersCollectorBase
    {
        protected readonly System.Collections.Generic.JetHashSet<JetBrains.ReSharper.Refactorings.Convert.Common.InterfaceMembersCollectorBase.OverridableMemberInfo> myNonMergableSignatures;
        protected readonly System.Collections.Generic.List<JetBrains.ReSharper.Refactorings.Convert.Common.ElementInstancePointer> myResult;
        protected readonly JetBrains.Util.OneToListMap<JetBrains.ReSharper.Refactorings.Convert.Common.InterfaceMembersCollectorBase.OverridableMemberInfo, JetBrains.ReSharper.Refactorings.Convert.Common.ElementInstancePointer> myResultWorkingSet;
        public InterfaceMembersCollectorBase(bool keepAllExplicitlyImplemented) { }
        protected void AddImplementation(JetBrains.ReSharper.Refactorings.Convert.Common.ElementInstancePointer implementedMemberInstance, JetBrains.ReSharper.Psi.ITypeMember implementation) { }
        public static JetBrains.ReSharper.Psi.IDeclaredType FindSuperClass(JetBrains.ReSharper.Psi.IDeclaredType type) { }
        protected JetBrains.ReSharper.Psi.ITypeMember GetImplementation(JetBrains.ReSharper.Refactorings.Convert.Common.ElementInstancePointer implementedMemberInstance) { }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Refactorings.Convert.Common.ElementInstancePointer> GetInterfaceMembers(JetBrains.ReSharper.Psi.Tree.ITypeDeclaration typeDeclaration) { }
        public static JetBrains.ReSharper.Psi.IDeclaredType GetSuperClass(JetBrains.ReSharper.Psi.Tree.ITypeDeclaration typeDeclaration) { }
        protected abstract bool IsPrimaryTypeMember(JetBrains.ReSharper.Psi.ITypeMember overridableMember);
        protected bool OverridableMemberImplementsMemberInstance(JetBrains.ReSharper.Refactorings.Convert.Common.ElementInstancePointer interfaceMemberInstance, JetBrains.ReSharper.Psi.IOverridableMember overridableMember, JetBrains.ReSharper.Psi.IType overridingCandidateType, JetBrains.ReSharper.Psi.IDeclaredType candidateQualifierType) { }
        protected abstract void ProcessPrivateImplementations(JetBrains.ReSharper.Psi.IOverridableMember overridableMember, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution, JetBrains.ReSharper.Refactorings.Convert.Common.InterfaceMembersCollectorBase.OverridableMemberInfo overridableMemberInfo, bool processingInheritedMembers);
        protected class OverridableMemberInfo
        {
            public static JetBrains.ReSharper.Refactorings.Convert.Common.InterfaceMembersCollectorBase.OverridableMemberInfo Create(JetBrains.ReSharper.Psi.IOverridableMember member, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution) { }
            public override bool Equals(object obj) { }
            public override int GetHashCode() { }
        }
    }
    public enum MemberTypes
    {
        AbstractWithPrivate = 0,
        AbstractAlone = 1,
        PublicWithPrivate = 2,
        PublicAlone = 3,
        PrivateWithPublic = 4,
        PrivateAlone = 5,
    }
    public delegate void ProcessOverridableMemberDelegate(JetBrains.ReSharper.Psi.ITypeMember member);
}
namespace JetBrains.ReSharper.Refactorings.Convert.Interface2Abstract
{
    
    public interface IInterface2AbstractExecuter : JetBrains.ReSharper.Refactorings.Convert.Common.IConvertTypeRefactoring, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringExecuter { }
    public sealed class Interface2AbstractRefactoring : JetBrains.ReSharper.Refactorings.Convert.Common.IConvertTypeRefactoring, JetBrains.ReSharper.Refactorings.Convert.Interface2Abstract.IInterface2AbstractExecuter, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringExecuter
    {
        public Interface2AbstractRefactoring(JetBrains.ReSharper.Refactorings.Convert.Interface2Abstract.Interface2AbstractWorkflow workFlow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver Driver { get; }
        public JetBrains.ReSharper.Refactorings.LanguageMapOfRefactoring<JetBrains.ReSharper.Refactorings.Convert.Common.IConvert> Exec { get; }
        public JetBrains.ReSharper.Psi.IInterface Interface { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.ITypeElement> NotRootImplementors { get; }
        public System.Collections.Generic.IList<System.Action> PostActions { get; }
        public JetBrains.ReSharper.Psi.IPsiServices PsiServices { get; }
        public JetBrains.ProjectModel.ISolution Solution { get; }
        public JetBrains.ReSharper.Refactorings.Convert.Interface2Abstract.Interface2AbstractWorkflow Workflow { get; }
        public bool Execute(JetBrains.Application.Progress.IProgressIndicator pi) { }
        public class BaseInterfaceMember
        {
            public BaseInterfaceMember(JetBrains.ReSharper.Refactorings.Convert.Interface2Abstract.Interface2AbstractRefactoring.BaseInterfaceMember.Kinds kind, JetBrains.ReSharper.Psi.ITypeMember member, JetBrains.ReSharper.Psi.IType interf) { }
            public JetBrains.ReSharper.Refactorings.Convert.Interface2Abstract.Interface2AbstractRefactoring.BaseInterfaceMember.Kinds Kind { get; set; }
            public JetBrains.ReSharper.Psi.ITypeMember Member { get; set; }
            public enum Kinds
            {
                Conflicted = 0,
                ImplementThru = 1,
            }
        }
    }
    public class Interface2AbstractWorkflow : JetBrains.ReSharper.Refactorings.Workflow.DrivenRefactoringWorkflow, JetBrains.ReSharper.Refactorings.Convert.Common.IConvertTypeWorkflow
    {
        public Interface2AbstractWorkflow(JetBrains.ProjectModel.ISolution solution, string actionId) { }
        public override JetBrains.ReSharper.Refactorings.Workflow.RefactoringActionGroup ActionGroup { get; }
        public override JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage FirstPendingRefactoringPage { get; }
        public override string HelpKeyword { get; }
        public JetBrains.ReSharper.Psi.Pointers.IDeclaredElementPointer<JetBrains.ReSharper.Psi.IInterface> InterfacePointer { get; }
        public override bool MightModifyManyDocuments { get; }
        public override string Title { get; }
        public override JetBrains.ReSharper.Refactorings.Workflow.IRefactoringExecuter CreateRefactoring(JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public override bool Initialize(JetBrains.Application.DataContext.IDataContext context) { }
        public override bool IsAvailable(JetBrains.Application.DataContext.IDataContext context) { }
        public override bool PreExecute(JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
        public override bool Validate() { }
    }
}
namespace JetBrains.ReSharper.Refactorings.ConvertRefsToBase
{
    
    public abstract class ComponentsBuilder<TVertex, TEdge>
        where TVertex :  class
        where TEdge :  class
    {
        public ComponentsBuilder(JetBrains.Util.OneToListMap<TVertex, TEdge> incomingEdges, JetBrains.Util.OneToListMap<TVertex, TEdge> outgoingEdges, System.Collections.Generic.IList<TVertex> nodes) { }
        public void Build(System.Collections.Generic.List<TVertex> componentTopologicalOrder, JetBrains.Util.OneToSetMap<TVertex, TVertex> components, System.Collections.Generic.IDictionary<TVertex, TVertex> reverseComponents, JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
        protected abstract TVertex End(TEdge edge);
        protected abstract TVertex Start(TEdge edge);
    }
}
namespace JetBrains.ReSharper.Refactorings.CopyType
{
    
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "CopyType"})]
    public class CopyTypeAction : JetBrains.ReSharper.Refactorings.Workflow.ExtensibleRefactoringAction<JetBrains.ReSharper.Refactorings.CopyType.ICopyTypeWorkflowProvider>
    {
        public const string ACTION_ID = "CopyType";
        protected override JetBrains.UI.RichText.RichText Caption { get; }
    }
    public class CopyTypeRefactoring
    {
        public CopyTypeRefactoring(JetBrains.ReSharper.Psi.ITypeElement typeElement, string newName) { }
        public JetBrains.ReSharper.Psi.ITreeNodePointer<JetBrains.ReSharper.Psi.Tree.ITypeDeclaration> CopyPointer { get; }
        public JetBrains.ReSharper.Psi.ITypeElement TypeElement { get; }
        public void Execute() { }
        public JetBrains.ReSharper.Refactorings.Conflicts.IConflictSearcher GetConflictSearcher() { }
        public static bool IsAvailable(JetBrains.ReSharper.Psi.Tree.ITypeDeclaration typeDeclaration) { }
        public bool PreExecute() { }
    }
    public interface ICopyType : JetBrains.ReSharper.Refactorings.ILanguageSpecificRefactoringService
    {
        JetBrains.ReSharper.Psi.Tree.ITypeDeclaration CreateCopy(JetBrains.ReSharper.Psi.Tree.ITypeDeclaration typeDeclaration, JetBrains.ReSharper.Psi.Tree.IFile file, string qualifiedName);
        string GenerateFileName(JetBrains.ReSharper.Psi.Tree.ITypeDeclaration typeDeclaration, string name);
        JetBrains.ReSharper.Refactorings.Conflicts.IConflictSearcher GetConflictSearcher(JetBrains.ReSharper.Psi.ITypeElement typeElement, string qualifiedName);
        JetBrains.CommonControls.Validation.IValidator[] GetValidators(System.Windows.Forms.Control control, JetBrains.ReSharper.Psi.ITypeElement typeElement);
        bool IsAvailable(JetBrains.ReSharper.Psi.Tree.ITypeDeclaration typeDeclaration);
    }
    public interface ICopyTypeWorkflowProvider : JetBrains.ReSharper.Feature.Services.ActionsMenu.IWorkflowProvider<JetBrains.ReSharper.Refactorings.Workflow.IRefactoringWorkflow, JetBrains.ReSharper.Refactorings.Workflow.RefactoringActionGroup>, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringWorkflowProvider { }
}
namespace JetBrains.ReSharper.Refactorings
{
    
    public sealed class DefaultRefactoringsHelper : JetBrains.ReSharper.Refactorings.RefactoringsHelper { }
    public interface ILanguageMapOfWorkflow { }
    public interface ILanguageSpecificRefactoringService { }
    public abstract class InternalRefactoringLanguageService : JetBrains.ReSharper.Refactorings.IRefactoringLanguageService
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        public virtual JetBrains.ReSharper.Refactorings.RefactoringsHelper Helper { get; }
        public virtual JetBrains.ReSharper.Refactorings.Convert.Common.IConvert CreateAbstract2Interface(JetBrains.ReSharper.Refactorings.Convert.Abstract2Interface.Abstract2InterfaceWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public virtual JetBrains.ReSharper.Refactorings.Move.AdjustNamespaces.AdjustNamespacesHelperBase CreateAdjustNamespaceHelper() { }
        public virtual JetBrains.ReSharper.Refactorings.Anotype2DeclaredType.Anonymous2Declared CreateAnonymous2Declared(JetBrains.ReSharper.Refactorings.Anotype2DeclaredType.Anonymous2DeclaredWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public virtual JetBrains.ReSharper.Refactorings.ClassFromParameters.ClassFromParametersBase CreateClassFromParameters(JetBrains.ReSharper.Refactorings.ClassFromParameters.ClassFromParametersWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public virtual JetBrains.ReSharper.Refactorings.Constructor2FactoryMethod.ConstructorToFactoryMethodBase CreateConstructor2FactoryMethod(JetBrains.ReSharper.Refactorings.Constructor2FactoryMethod.Constructor2FactoryMethodWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public virtual JetBrains.ReSharper.Refactorings.EncapsulateField.EncapsulateFieldBase CreateEncapsulateField(JetBrains.ReSharper.Refactorings.EncapsulateField.EncapsulateFieldWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public virtual JetBrains.ReSharper.Refactorings.ExtractClass.ExtractClassHelper CreateExtractClassHelper(JetBrains.ReSharper.Refactorings.ExtractClass.ExtractClassWorkflow workflow) { }
        public virtual JetBrains.ReSharper.Refactorings.InlineClass.InlineClassHelper CreateInlineClassHelper(JetBrains.ReSharper.Refactorings.InlineClass.InlineClassWorkflow inlineClassWorkflow) { }
        public virtual JetBrains.ReSharper.Refactorings.InlineField.InlineFieldBase CreateInlineField(JetBrains.ReSharper.Refactorings.InlineField.InlineFieldWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public virtual JetBrains.ReSharper.Refactorings.Inline.InlineMethod CreateInlineMethod(JetBrains.ReSharper.Refactorings.Inline.InlineMethodWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public virtual JetBrains.ReSharper.Refactorings.InlineParameter.InlineParameterBase CreateInlineParameter(JetBrains.ReSharper.Refactorings.InlineParameter.InlineParameterWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public virtual JetBrains.ReSharper.Refactorings.InlineParameter.InlineParameterHelper CreateInlineParameterHelper() { }
        public virtual JetBrains.ReSharper.Refactorings.InlineVar.InlineVarBase CreateInlineVar(JetBrains.ReSharper.Refactorings.InlineVar.InlineVarWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public virtual JetBrains.ReSharper.Refactorings.Convert.Common.IConvert CreateInterface2Abstract(JetBrains.ReSharper.Refactorings.Convert.Interface2Abstract.Interface2AbstractWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public virtual JetBrains.ReSharper.Refactorings.IntroduceField.IntroFieldBase CreateIntroduceField(JetBrains.ReSharper.Refactorings.IntroduceField.IntroFieldWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public virtual JetBrains.ReSharper.Refactorings.IntroduceVariable.IntroduceVariableBase CreateIntroduceVariable(JetBrains.ReSharper.Refactorings.IntroduceVariable.IntroduceLocalWorkflowBase workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public virtual JetBrains.ReSharper.Refactorings.IntroduceVariable.IntroduceVariableHelper CreateIntroduceVariableHelper() { }
        public virtual JetBrains.ReSharper.Refactorings.IntroduceParameter.IntroduceParameterBase CreateIntroRefactoring(JetBrains.ReSharper.Refactorings.IntroduceParameter.IntroduceParameterWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public virtual JetBrains.ReSharper.Refactorings.ChangeStaticness.ToStatic.MakeStatic CreateMakeStatic(JetBrains.ReSharper.Refactorings.ChangeStaticness.ToStatic.MakeStaticWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public virtual JetBrains.ReSharper.Refactorings.ChangeStaticness.ToStatic.IMakeStaticHelper CreateMakeStaticHelper() { }
        public virtual JetBrains.ReSharper.Refactorings.MoveInstanceMethod.MoveInstanceMethodHelper CreateMoveInstanceMethodHelper(JetBrains.ReSharper.Refactorings.MoveInstanceMethod.MoveInstanceMethodWorkflow moveInstanceMethodWorkflow) { }
        public virtual JetBrains.ReSharper.Refactorings.Move.MoveIntoMatchingFile.MoveIntoMatchingFilesHelperBase CreateMoveIntoMatchingFilesHelper() { }
        public virtual JetBrains.ReSharper.Refactorings.MoveStaticMembers.MoveStaticMembers CreateMoveStaticMembers(JetBrains.ReSharper.Refactorings.MoveStaticMembers.MoveStaticMembersWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public virtual JetBrains.ReSharper.Refactorings.MoveStaticMembers.MoveStaticMembersHelper CreateMoveStaticMembersHelper() { }
        public virtual JetBrains.ReSharper.Refactorings.Move.MoveTypeDeclarationToFile.MoveToFileHelperBase CreateMoveToFileHelper() { }
        public virtual JetBrains.ReSharper.Refactorings.Move.MoveToFolder.MoveToFolderHelperBase CreateMoveToFolderHelper() { }
        public virtual JetBrains.ReSharper.Refactorings.Move.MoveToNamespace.MoveToNamespaceHelperBase CreateMoveToNamespaceHelper() { }
        public virtual JetBrains.ReSharper.Refactorings.Property2Auto.Property2AutoBase CreateProperty2Auto(JetBrains.ReSharper.Refactorings.Property2Auto.Property2AutoWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public virtual JetBrains.ReSharper.Refactorings.Rename.RenameHelperBase CreateRenameHelper() { }
        public virtual JetBrains.ReSharper.Refactorings.SafeDeleteTheSecond.SafeDeleteBase CreateSafeDeleteBase(JetBrains.ReSharper.Refactorings.SafeDeleteTheSecond.SafeDeleteWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public virtual JetBrains.ReSharper.Refactorings.SafeDeleteFolder.SafeDeleteFolderHelperBase CreateSafeDeleteFolderHelper() { }
        public virtual JetBrains.ReSharper.Refactorings.SafeDeleteTheSecond.SafeDeleteHelperUnsupported CreateSafeDeleteHelper() { }
        public virtual JetBrains.ReSharper.Refactorings.Static2Extension.Static2ExtensionBase CreateStatic2Extension(JetBrains.ReSharper.Refactorings.Static2Extension.Static2ExtensionWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public virtual JetBrains.ReSharper.Refactorings.TransformOutParameters.TransformOutParametersHelper CreateTransformOutParametersHelper(JetBrains.ReSharper.Refactorings.TransformOutParameters.TransformOutParametersWorkflow workflow) { }
        public virtual JetBrains.ReSharper.Refactorings.UseBaseType.UseBaseTypeBase CreateUseBaseType(JetBrains.ReSharper.Refactorings.UseBaseType.UseBaseTypeWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public virtual JetBrains.ReSharper.Refactorings.ExtractClass.ExtractClassRefactoringExec ExtractClassExec(JetBrains.ReSharper.Refactorings.ExtractClass.ExtractClassWorkflow workflow) { }
        public virtual JetBrains.ReSharper.Refactorings.MoveMembers.ImplExtractInterface.IExtractInterface ExtractInterfaceRefactoring(JetBrains.ReSharper.Refactorings.MoveMembers.ImplExtractInterface.ExtractInterfaceWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public virtual JetBrains.ReSharper.Refactorings.MoveMembers.ImplExtractSuperclass.IExtractSuperclass ExtractSuperclassRefactoring(JetBrains.ReSharper.Refactorings.MoveMembers.ImplExtractSuperclass.ExtractSuperclassWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public virtual JetBrains.ReSharper.Refactorings.Common.Convert.IConvertRefactoring Function2Indexer(JetBrains.ReSharper.Refactorings.Function2Property.Function2PropertyWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public virtual JetBrains.ReSharper.Refactorings.Common.Convert.IConvertRefactoring Function2Property(JetBrains.ReSharper.Refactorings.Function2Property.Function2PropertyWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Refactorings.InternalRefactoringLanguageService Get(JetBrains.ReSharper.Psi.PsiLanguageType languageType) { }
        public virtual JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage GetFunction2PropertyUI(JetBrains.ReSharper.Refactorings.Function2Property.Function2PropertyWorkflow workflow) { }
        public virtual JetBrains.ReSharper.Refactorings.Common.Convert.IConvertRefactoring Indexer2Function(JetBrains.ReSharper.Refactorings.Property2Function.Property2FunctionWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public virtual JetBrains.ReSharper.Refactorings.InlineClass.IInlineClassRefactoringExec InlineClassExec(JetBrains.ReSharper.Refactorings.InlineClass.InlineClassWorkflow workflow) { }
        public virtual JetBrains.ReSharper.Refactorings.Iterator2Function.Iterator2FunctionBase Iterator2Function(JetBrains.ReSharper.Refactorings.Iterator2Function.Iterator2FunctionWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public virtual JetBrains.ReSharper.Refactorings.MoveInnerClass.IMoveTypeToOuterScope MoveTypeToOuterScope(JetBrains.ReSharper.Refactorings.MoveInnerClass.MoveTypeToOuterScopeRefactoring refactoring) { }
        public virtual JetBrains.ReSharper.Refactorings.Common.Convert.IConvertRefactoring Property2Function(JetBrains.ReSharper.Refactorings.Property2Function.Property2FunctionWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public virtual JetBrains.ReSharper.Refactorings.MoveMembers.ImplPullUp.IPullUp PullUpRefactoring(JetBrains.ReSharper.Refactorings.MoveMembers.ImplPullUp.PullUpWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public virtual JetBrains.ReSharper.Refactorings.MoveMembers.ImplPushDown.IPushDown PushDownRefactoring(JetBrains.ReSharper.Refactorings.MoveMembers.ImplPushDown.PushDownWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
    }
    public interface IRefactoringExec
    {
        JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver RefactoringDriver { set; }
    }
    public interface IRefactoringLanguageService { }
    public interface IWorkflowExec
    {
        bool IsLanguageSupported { get; }
    }
    public class LanguageMapOfRefactoring<T> : System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable
        where T :  class, JetBrains.ReSharper.Refactorings.IRefactoringExec
    {
        public LanguageMapOfRefactoring(JetBrains.ReSharper.Refactorings.LanguageMapOfRefactoring<T>.Creator creator, T defaultValue, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver refactoringDriver) { }
        public T this[JetBrains.ReSharper.Psi.PsiLanguageType language] { get; }
        public System.Collections.Generic.IEnumerator<T> GetEnumerator() { }
        public delegate T Creator<T>(JetBrains.ReSharper.Refactorings.IRefactoringLanguageService refactoringLanguageService);
    }
    public class LanguageMapOfWorkflow<T> : JetBrains.ReSharper.Refactorings.ILanguageMapOfWorkflow, System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable
        where T :  class, JetBrains.ReSharper.Refactorings.IWorkflowExec
    {
        public LanguageMapOfWorkflow(System.Func<JetBrains.ReSharper.Refactorings.IRefactoringLanguageService, T> creator, T defaultValue) { }
        public T this[JetBrains.ReSharper.Psi.PsiLanguageType language] { get; }
        public System.Collections.Generic.IEnumerator<T> GetEnumerator() { }
    }
    public class static LanguageUtil
    {
        public static System.Collections.Generic.List<JetBrains.ReSharper.Psi.Resolve.IReference> GetSortedReferences(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Resolve.IReference> references) { }
        public static JetBrains.Util.OneToSetMap<JetBrains.ReSharper.Psi.PsiLanguageType, T> Sort<T>(System.Collections.Generic.IEnumerable<T> e, JetBrains.ReSharper.Refactorings.LanguageUtil.GetLanguage<T> getLanguage) { }
        public static JetBrains.Util.OneToSetMap<JetBrains.ReSharper.Psi.PsiLanguageType, T> SortElements<T>(System.Collections.Generic.IEnumerable<T> e)
            where T : JetBrains.ReSharper.Psi.Tree.ITreeNode { }
        public static JetBrains.Util.OneToSetMap<JetBrains.ReSharper.Psi.PsiLanguageType, T> SortReferences<T>(System.Collections.Generic.IEnumerable<T> e)
            where T : JetBrains.ReSharper.Psi.Resolve.IReference { }
        public delegate JetBrains.ReSharper.Psi.PsiLanguageType GetLanguage<T>(T item);
    }
    [JetBrains.ReSharper.Refactorings.Workflow.RefactoringWorkflowProviderAttribute()]
    public class MoveToOuterScopeProvider : JetBrains.ReSharper.Refactorings.MoveWorkflowProvider
    {
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Refactorings.Workflow.IRefactoringWorkflow> CreateWorkflow(JetBrains.Application.DataContext.IDataContext dataContext) { }
    }
    public abstract class MoveWorkflowProvider : JetBrains.ReSharper.Feature.Services.ActionsMenu.IWorkflowProvider<JetBrains.ReSharper.Refactorings.Workflow.IRefactoringWorkflow, JetBrains.ReSharper.Refactorings.Workflow.RefactoringActionGroup>, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringWorkflowProvider
    {
        protected static string ActionId { get; }
        public abstract System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Refactorings.Workflow.IRefactoringWorkflow> CreateWorkflow(JetBrains.Application.DataContext.IDataContext dataContext);
    }
    public interface RefactoringService
    {
        JetBrains.ReSharper.Psi.ILocalScope[] FindScopesByDeclaredElement(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement);
    }
    public abstract class RefactoringsHelper
    {
        public virtual bool CanBeDefault(JetBrains.ReSharper.Psi.Tree.IExpression expression) { }
        public virtual bool CanContainExtensionMethods(JetBrains.ReSharper.Psi.IClass @class) { }
        public virtual bool CanExtractSuperclass(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration) { }
        public virtual bool CanUseExplicitly(JetBrains.ReSharper.Psi.IType type) { }
        public virtual bool CanUseInstanceFields(JetBrains.ReSharper.Psi.Tree.ITreeNode declaration) { }
        public virtual bool CheckAnonymous2Declared(JetBrains.Application.DataContext.IDataContext context, out JetBrains.ReSharper.Psi.Tree.ITreeNode objectCreationElement) { }
        public virtual bool CheckForIntroduceAccessible(JetBrains.ReSharper.Psi.Tree.ITreeNode expression) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public virtual JetBrains.ReSharper.Refactorings.InlineVar.RDAnalysis.InlineVarAnalyserBase CreateInlineVarAnalyser(JetBrains.ReSharper.Refactorings.InlineVar.InlineVarWorkflow workflow) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public virtual JetBrains.ReSharper.Refactorings.IntroduceField.IntroFieldAnalyser CreateIntroFieldAnalyser() { }
        public virtual JetBrains.ReSharper.Refactorings.Property2Auto.IProperty2AutoChecker CreateProperty2AutoChecker() { }
        public virtual bool DeclarationHasBody(JetBrains.ReSharper.Psi.IDeclaredElement element) { }
        public virtual bool ExtentionMethodsSupported(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public virtual bool FailOnReferencesToLocals(JetBrains.ReSharper.Psi.Tree.IExpression expression) { }
        public virtual bool Function2PropertyAvailable(JetBrains.ReSharper.Psi.IMethod method) { }
        public virtual JetBrains.ReSharper.Psi.Tree.IArgumentsOwner GetArgumentsOwner(ref JetBrains.ReSharper.Psi.Resolve.IReference reference, bool replaceMethodGroup) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public virtual JetBrains.ReSharper.Psi.Tree.ITreeNode GetContainingLambda(JetBrains.ReSharper.Psi.Tree.ITreeNode expression) { }
        public virtual string GetDeclareStaticText() { }
        public virtual System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IDeclaredElement> GetLocals(JetBrains.ReSharper.Psi.Tree.IExpression expression, JetBrains.ReSharper.Psi.IParametersOwner owner) { }
        public virtual T GetMainElement<T>(T method)
            where T : JetBrains.ReSharper.Psi.IDeclaredElement { }
        public virtual string GetMakeMethodNonStaticTitle() { }
        [JetBrains.Annotations.NotNullAttribute()]
        public virtual JetBrains.ReSharper.Psi.IDeclaredElement GetPrimaryQueryElement([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IDeclaredElement variable) { }
        public virtual JetBrains.ReSharper.Refactorings.Util.ReferenceComparatorDelegate GetReferenceComparator() { }
        public virtual bool GetShouldBeConstant(JetBrains.ReSharper.Psi.Tree.IExpression expression) { }
        public virtual JetBrains.DocumentModel.DocumentRange GetSignatureRange(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public virtual JetBrains.ReSharper.Psi.Tree.ITreeNode GetStatementVisibleForAll(System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Tree.IExpression> expressions) { }
        public virtual JetBrains.ReSharper.Psi.Tree.ITypeDeclaration GetTypeDeclarationForField(JetBrains.ReSharper.Psi.Tree.ITypeDeclaration typeDeclaration, out bool baseTypeChoosed) { }
        public virtual bool HasIndexerToFunction() { }
        public virtual bool HasIninializer(JetBrains.ReSharper.Psi.IField field) { }
        public virtual bool IndexerIsPresented() { }
        public virtual bool InitializerIsRecursive(JetBrains.ReSharper.Psi.IDeclaredElement element) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public virtual JetBrains.ReSharper.Psi.Tree.IExpression IntroParameterGetInitializer(JetBrains.ReSharper.Psi.ILocalVariable variable) { }
        public virtual bool IsAsyncMethod(JetBrains.ReSharper.Psi.ITypeMember method) { }
        public virtual bool IsCSharp3Supported(JetBrains.ReSharper.Psi.IDeclaredElement element) { }
        public virtual bool IsInvocationReference(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public virtual bool IsIterator(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration) { }
        public virtual bool IsLetVariable(JetBrains.ReSharper.Psi.IDeclaredElement element) { }
        public virtual bool IsNew(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration) { }
        public virtual bool IsPartialMethod(JetBrains.ReSharper.Psi.ITypeMember member) { }
        public virtual bool IsReferenceName(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public virtual JetBrains.ReSharper.Refactorings.Helpers.INamespaceRedundancyProblemFixer NamespaceRedundancyFileFixer(JetBrains.ReSharper.Psi.INamespace @namespace, JetBrains.ReSharper.Psi.Tree.IFile file) { }
        public virtual string PresentAccessRights(JetBrains.ReSharper.Psi.AccessRights rights, bool useMenemonics) { }
        public virtual bool ReferencesRangeVariables(JetBrains.ReSharper.Psi.Tree.IExpression expression) { }
        public virtual JetBrains.ReSharper.Psi.Resolve.IReference RemoveQualification(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public virtual void SetNew(JetBrains.ReSharper.Psi.Tree.ITypeMemberDeclaration typeMember, bool isNew) { }
    }
    [JetBrains.Application.Settings.SettingsKeyAttribute(typeof(JetBrains.Application.Settings.HousekeepingSettings), "ReSharper refactoring settings")]
    public class RefactoringsMruSettings { }
}
namespace JetBrains.ReSharper.Refactorings.EncapsulateField
{
    
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "EncapsulateField"})]
    public class EncapsulateFieldAction : JetBrains.ReSharper.Refactorings.Workflow.ExtensibleRefactoringAction<JetBrains.ReSharper.Refactorings.EncapsulateField.IEncapsulateFieldWorkflowProvider>
    {
        public const string ACTION_ID = "EncapsulateField";
        protected override JetBrains.UI.RichText.RichText Caption { get; }
    }
    public abstract class EncapsulateFieldBase : JetBrains.ReSharper.Refactorings.Common.RefactoringExecBase<JetBrains.ReSharper.Refactorings.EncapsulateField.EncapsulateFieldWorkflow, JetBrains.ReSharper.Refactorings.EncapsulateField.EncapsulateFieldRefactoring>
    {
        protected EncapsulateFieldBase(JetBrains.ReSharper.Refactorings.EncapsulateField.EncapsulateFieldWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public abstract void AddReadAccessor(JetBrains.ReSharper.Psi.IProperty property, JetBrains.ReSharper.Psi.IField field);
        public abstract void AddWriteAccessor(JetBrains.ReSharper.Psi.IProperty property, JetBrains.ReSharper.Psi.IField field);
        public abstract JetBrains.ReSharper.Psi.IProperty CreatePropertyDeclaration(JetBrains.ReSharper.Psi.IField field, string myFieldNewName);
        public abstract JetBrains.ReSharper.Psi.IField GetBackingFieldForGetter(JetBrains.ReSharper.Psi.IProperty property);
        public abstract JetBrains.ReSharper.Psi.IField GetBackingFieldForSetter(JetBrains.ReSharper.Psi.IProperty property);
        public virtual bool IsInternalReference(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public virtual void ProcessReference(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.ReferenceAccessType accessType, JetBrains.ReSharper.Psi.IProperty property) { }
    }
    public class EncapsulateFieldPage : JetBrains.UI.CommonControls.SafeUserControl, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage
    {
        public EncapsulateFieldPage(JetBrains.ReSharper.Refactorings.EncapsulateField.EncapsulateFieldWorkflow workflow, JetBrains.ReSharper.Psi.PsiLanguageType language) { }
        public JetBrains.ReSharper.Psi.AccessRights AccessRights { get; }
        public bool AutoProperty { get; }
        public JetBrains.DataFlow.IProperty<bool> ContinueEnabled { get; }
        public string Description { get; }
        public bool DoNotShow { get; }
        public bool EncapsualteReads { get; }
        public bool EncapsualteWrites { get; }
        public bool ExternalOnly { get; }
        public bool MakeFieldPrivate { get; }
        public string PropertyName { get; }
        public string Title { get; }
        public JetBrains.UI.CrossFramework.EitherControl View { get; }
        public JetBrains.ReSharper.Refactorings.EncapsulateField.EncapsulateFieldPage.IWorkflowDataProvider WorkflowDataProvider { get; set; }
        public JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage Commit(JetBrains.Application.Progress.IProgressIndicator pi) { }
        protected override void Dispose(bool disposing) { }
        public bool Initialize(JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
        public bool RefreshContents(JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
        public interface IWorkflowDataProvider
        {
            void ProvideData(JetBrains.ReSharper.Refactorings.EncapsulateField.EncapsulateFieldWorkflow workflow);
        }
    }
    [JetBrains.ReSharper.Refactorings.Workflow.RefactoringWorkflowProviderAttribute()]
    public class EncapsulateFieldProvider : JetBrains.ReSharper.Feature.Services.ActionsMenu.IWorkflowProvider<JetBrains.ReSharper.Refactorings.Workflow.IRefactoringWorkflow, JetBrains.ReSharper.Refactorings.Workflow.RefactoringActionGroup>, JetBrains.ReSharper.Refactorings.EncapsulateField.IEncapsulateFieldWorkflowProvider, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringWorkflowProvider
    {
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Refactorings.Workflow.IRefactoringWorkflow> CreateWorkflow(JetBrains.Application.DataContext.IDataContext dataContext) { }
    }
    public class EncapsulateFieldRefactoring : JetBrains.ReSharper.Refactorings.Common.DrivenRefactoring<JetBrains.ReSharper.Refactorings.EncapsulateField.EncapsulateFieldWorkflow, JetBrains.ReSharper.Refactorings.EncapsulateField.EncapsulateFieldBase>
    {
        public EncapsulateFieldRefactoring(JetBrains.ReSharper.Refactorings.EncapsulateField.EncapsulateFieldWorkflow workFlow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Resolve.IReference> References { get; }
        public void CollectReferences(JetBrains.ReSharper.Psi.IField field, JetBrains.Application.Progress.IProgressIndicator pi) { }
        protected override JetBrains.ReSharper.Refactorings.EncapsulateField.EncapsulateFieldBase CreateRefactoringInternal(JetBrains.ReSharper.Refactorings.InternalRefactoringLanguageService service) { }
        protected override JetBrains.ReSharper.Refactorings.EncapsulateField.EncapsulateFieldBase CreateUnsupportedRefactoring() { }
        public override bool Execute(JetBrains.Application.Progress.IProgressIndicator pi) { }
    }
    public class EncapsulateFieldWorkflow : JetBrains.ReSharper.Refactorings.Workflow.DrivenRefactoringWorkflow
    {
        public EncapsulateFieldWorkflow(JetBrains.ProjectModel.ISolution solution, string actionId) { }
        public override JetBrains.ReSharper.Refactorings.Workflow.RefactoringActionGroup ActionGroup { get; }
        public bool AutoProperty { get; set; }
        public bool CSharp3Supported { get; }
        public bool EncapsulateReads { get; set; }
        public bool EncapsulateWrites { get; set; }
        public bool ExternalOnly { get; set; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Psi.IField Field { get; }
        public override JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage FirstPendingRefactoringPage { get; }
        public bool HasInilializer { get; }
        public override string HelpKeyword { get; }
        public bool MakeFieldPrivate { get; set; }
        public override bool MightModifyManyDocuments { get; }
        public JetBrains.ReSharper.Psi.AccessRights PropertyAccessRights { get; set; }
        public string PropertyName { get; set; }
        public override string Title { get; }
        public override JetBrains.ReSharper.Refactorings.Workflow.IRefactoringExecuter CreateRefactoring(JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public override bool Initialize(JetBrains.Application.DataContext.IDataContext context) { }
        public override bool IsAvailable(JetBrains.Application.DataContext.IDataContext context) { }
        public override bool PreExecute(JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
        public override bool Validate() { }
    }
    public interface IEncapsulateFieldWorkflowProvider : JetBrains.ReSharper.Feature.Services.ActionsMenu.IWorkflowProvider<JetBrains.ReSharper.Refactorings.Workflow.IRefactoringWorkflow, JetBrains.ReSharper.Refactorings.Workflow.RefactoringActionGroup>, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringWorkflowProvider { }
}
namespace JetBrains.ReSharper.Refactorings.ExtensionsApi
{
    
    public interface IRefactoringDataConstantsService
    {
        bool IsNameNodeSelected(JetBrains.ReSharper.Psi.Tree.ITreeNode node, JetBrains.DocumentModel.DocumentRange documentRange);
    }
}
namespace JetBrains.ReSharper.Refactorings.ExtractClass.Analysis
{
    
    public class ExtractClassAnalyzer
    {
        public readonly JetBrains.Util.OneToSetMap<JetBrains.ReSharper.Psi.IDeclaredElement, JetBrains.ReSharper.Psi.Resolve.IReference> References;
        public ExtractClassAnalyzer() { }
        public System.Collections.Generic.List<JetBrains.ReSharper.Refactorings.ExtractClass.Info.MemberInfo> AllMembers { get; set; }
        public JetBrains.ReSharper.Psi.Resolve.ISubstitution BackSubstitution { get; set; }
        public System.Collections.Generic.List<JetBrains.ReSharper.Refactorings.ExtractClass.ConstructorInfo> Constructors { get; set; }
        public System.Collections.Generic.List<JetBrains.ReSharper.Refactorings.ExtractClass.Info.DataInfo> DataMembers { get; }
        public JetBrains.Util.FileSystemPath DirectoryPath { get; set; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Refactorings.ExtractClass.FieldInfo> FieldMembers { get; }
        public bool IsSibling { get; set; }
        public System.Collections.Generic.List<JetBrains.ReSharper.Refactorings.ExtractClass.Info.MemberInfo> Members { get; }
        public System.Collections.Generic.List<JetBrains.ReSharper.Refactorings.ExtractClass.Info.MemberInfo> MovableMembers { get; }
        public bool NotSibling { get; set; }
        public JetBrains.ReSharper.Psi.Resolve.ISubstitution Substitution { get; set; }
        public int ThisUsages { get; set; }
        public JetBrains.ReSharper.Refactorings.ExtractClass.ExtractClassWorkflow Workflow { get; set; }
        protected virtual void CreateConstructors() { }
        public void FillConflicts() { }
        public void GetReferencesToRebind(JetBrains.Application.Progress.IProgressIndicator pi) { }
        public virtual void InitializeMembers(System.Func<JetBrains.ReSharper.Psi.ITypeMember, bool> isMemberIncluded) { }
        public void UpdateUsingSource() { }
    }
}
namespace JetBrains.ReSharper.Refactorings.ExtractClass
{
    
    public class CommandInfo : System.ComponentModel.INotifyPropertyChanged
    {
        public CommandInfo(JetBrains.ReSharper.Refactorings.ExtractClass.ConflictInfo.ResolutionState state, string name, JetBrains.UI.Icons.IconId image, JetBrains.ReSharper.Refactorings.ExtractClass.ConflictInfo info) { }
        public CommandInfo(JetBrains.ReSharper.Refactorings.ExtractClass.Info.GhostStateEnum state, string name, JetBrains.ReSharper.Refactorings.ExtractClass.Info.MemberInfo info) { }
        public JetBrains.UI.Icons.IconId ActionIcon { get; set; }
        public System.Windows.Input.ICommand Command { get; set; }
        public JetBrains.ReSharper.Refactorings.ExtractClass.ConflictInfo ConflictInfo { get; set; }
        public JetBrains.ReSharper.Refactorings.ExtractClass.Info.MemberInfo Info { get; set; }
        public bool IsSelected { get; set; }
        public string Name { get; set; }
        public JetBrains.ReSharper.Refactorings.ExtractClass.ConflictInfo.ResolutionState State { get; set; }
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string name) { }
    }
    public class ConflictInfo : System.ComponentModel.INotifyPropertyChanged
    {
        public ConflictInfo() { }
        public bool ChangeAccess { get; set; }
        public System.Collections.Generic.List<JetBrains.ReSharper.Refactorings.ExtractClass.CommandInfo> Commands { get; set; }
        public bool DependOnThis { get; set; }
        public bool HasConflict { get; set; }
        public bool IsReadOnly { get; set; }
        public bool NeedAccessElement { get; set; }
        public JetBrains.ReSharper.Refactorings.ExtractClass.ConflictInfo.ResolutionState Resolution { get; set; }
        public JetBrains.ReSharper.Refactorings.ExtractClass.CommandInfo SelectedCommand { get; set; }
        public JetBrains.ReSharper.Refactorings.ExtractClass.ConflictInfo.ConflictState State { get; set; }
        public string Tooltip { get; set; }
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        public void Fill() { }
        protected void OnPropertyChanged(string name) { }
        public enum ConflictState
        {
            Resolved = 0,
            Conflict = 1,
            Obsolete = 2,
            NoConflict = 3,
        }
        public enum ResolutionState
        {
            DoNothing = 0,
            AddElement = 1,
            Publificate = 2,
        }
    }
    public class ConstructorCall
    {
        public ConstructorCall() { }
        public bool Before { get; set; }
        public bool IsBlock { get; set; }
        public System.Collections.Generic.List<JetBrains.ReSharper.Psi.Tree.IExpression> ParameterValues { get; set; }
        public JetBrains.ReSharper.Psi.Tree.ITreeNode PlaceBlock { get; set; }
        public JetBrains.ReSharper.Psi.Tree.IStatement PlaceStatement { get; set; }
        public System.Collections.Generic.Dictionary<JetBrains.ReSharper.Psi.Tree.IStatement, JetBrains.ReSharper.Psi.Tree.IStatement> StatementsToRemove { get; set; }
    }
    public class ConstructorInfo : JetBrains.ReSharper.Refactorings.ExtractClass.Info.MemberInfo
    {
        public ConstructorInfo(JetBrains.ReSharper.Psi.IDeclaredElement constructor, JetBrains.ReSharper.Refactorings.ExtractClass.Analysis.ExtractClassAnalyzer analyzer) { }
        public System.Collections.Generic.List<JetBrains.ReSharper.Psi.Tree.IStatement> Body { get; set; }
        public System.Collections.Generic.List<JetBrains.ReSharper.Refactorings.ExtractClass.ConstructorCall> ConstructorCalls { get; set; }
        public override bool Included { get; set; }
        public System.Collections.Generic.List<JetBrains.ReSharper.Refactorings.ExtractClass.Info.MemberInfo.RelativeInfo> Order { get; set; }
        public System.Collections.Generic.List<JetBrains.ReSharper.Psi.IDeclaredElement> Parameters { get; set; }
        public JetBrains.ReSharper.Psi.IConstructor SourceConstructor { get; set; }
    }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "ExtractClass"})]
    public class ExtractClassAction : JetBrains.ReSharper.Refactorings.Workflow.ExtensibleRefactoringAction<JetBrains.ReSharper.Refactorings.ExtractClass.IExtractClassWorkflowProvider>
    {
        public const string ACTION_ID = "ExtractClass";
        protected override JetBrains.UI.RichText.RichText Caption { get; }
    }
    public class ExtractClassData
    {
        public ExtractClassData(bool isSibling, string className, string fieldName, string[] selectedElements, bool useThis, string[] makeCopy, string[] makeDelegate) { }
        public string ClassName { get; }
        public string FieldName { get; }
        public bool IsSibling { get; }
        public string[] MakeCopy { get; }
        public string[] MakeDelegate { get; }
        public string[] SelectedElements { get; }
        public bool UseThis { get; }
    }
    public class ExtractClassHelper : JetBrains.ReSharper.Refactorings.IWorkflowExec, JetBrains.ReSharper.Refactorings.Util.NewTypeImages.IResolveImagesLanguageSupport
    {
        public virtual bool IsLanguageSupported { get; }
        public virtual JetBrains.ReSharper.Psi.Tree.ITypeDeclaration CreateTargetTypeElement(out System.Collections.Generic.Dictionary<, > typeParams, JetBrains.ReSharper.Refactorings.ExtractClass.ExtractClassWorkflow extractClassWorkflow) { }
        public virtual JetBrains.ReSharper.Refactorings.ExtractClass.Analysis.ExtractClassAnalyzer GetAnalyzer(JetBrains.ReSharper.Refactorings.ExtractClass.ExtractClassWorkflow extractClassWorkflow, JetBrains.ReSharper.Psi.ITypeElement owner, string name, JetBrains.Util.FileSystemPath fileSystemPath) { }
        public virtual JetBrains.ReSharper.Psi.Tree.ITypeDeclaration InsertSibling(JetBrains.ReSharper.Psi.Tree.ITypeDeclaration newClassDeclaration, JetBrains.ReSharper.Psi.Tree.ITypeDeclaration tagDeclaration) { }
        public virtual JetBrains.ReSharper.Psi.Tree.ITypeDeclaration InsertToNewFile(JetBrains.ReSharper.Psi.Tree.ITypeDeclaration newClassDeclaration, JetBrains.ReSharper.Psi.Tree.ITypeDeclaration tagDeclaration, string targetNamespace, JetBrains.ProjectModel.IProjectFile createdFile) { }
        public bool IsExternallyVisibleSymbol(JetBrains.ReSharper.Psi.IDeclaredElement element) { }
        public bool IsFromExtendsList(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public bool IsReferenceName(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public void RemoveUnusedUsing(JetBrains.ReSharper.Psi.Tree.IFile file, System.Collections.Generic.JetHashSet<JetBrains.ReSharper.Psi.Tree.ITreeNode> usings) { }
        public void SaveUnusedUsings(JetBrains.ReSharper.Psi.Tree.IFile file, JetBrains.ReSharper.Refactorings.Move.Common.UnusedUsingSaver saver) { }
        public virtual bool TryProcessMultyFieldForResolve(JetBrains.ReSharper.Psi.IRecursiveElementProcessor collector, JetBrains.ReSharper.Psi.Tree.IDeclaration declaration) { }
    }
    public class ExtractClassRefactoring : JetBrains.ReSharper.Refactorings.Common.DrivenRefactoring<JetBrains.ReSharper.Refactorings.ExtractClass.ExtractClassWorkflow, JetBrains.ReSharper.Refactorings.ExtractClass.ExtractClassRefactoringExec>
    {
        public ExtractClassRefactoring(JetBrains.ReSharper.Refactorings.ExtractClass.ExtractClassWorkflow workflow, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public JetBrains.ReSharper.Refactorings.Util.NewTypeImages.ResolveImagesRepository Repository { get; }
        public System.Collections.Generic.Dictionary<JetBrains.ReSharper.Psi.ITypeParameter, JetBrains.ReSharper.Psi.ITypeParameter> TypeParameters { get; set; }
        public override bool Execute(JetBrains.Application.Progress.IProgressIndicator pi) { }
        public JetBrains.ReSharper.Psi.Tree.ITypeDeclaration GetSourceDeclaration() { }
    }
    public abstract class ExtractClassRefactoringExec : JetBrains.ReSharper.Refactorings.Common.RefactoringExecBase<JetBrains.ReSharper.Refactorings.ExtractClass.ExtractClassWorkflow, JetBrains.ReSharper.Refactorings.ExtractClass.ExtractClassRefactoring>
    {
        protected ExtractClassRefactoringExec(JetBrains.ReSharper.Refactorings.ExtractClass.ExtractClassWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public abstract void AddField(JetBrains.ReSharper.Psi.ITypeElement sourceTypeElement, JetBrains.ReSharper.Psi.ITypeElement targetType);
        public abstract void AddProperties();
        public abstract void CreateConstructors();
        public abstract bool CutAndPaste(JetBrains.ReSharper.Refactorings.Util.NewTypeImages.ResolveImagesRepository repository, System.Collections.Generic.Dictionary<JetBrains.ReSharper.Psi.ITypeParameter, JetBrains.ReSharper.Psi.ITypeParameter> createdTypeParametersMap, JetBrains.Application.Progress.IProgressIndicator pi);
        public abstract void Rebind(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Refactorings.ExtractClass.Info.MemberInfo memberToRebind, JetBrains.ReSharper.Psi.IDeclaredElement propertyMember);
        public abstract void ResolveConflicts(JetBrains.Application.Progress.IProgressIndicator subPi);
    }
    public class ExtractClassWorkflow : JetBrains.ReSharper.Refactorings.WorkflowNew.DrivenRefactoringWorkflow2<JetBrains.ReSharper.Refactorings.ExtractClass.ExtractClassHelper>
    {
        public ExtractClassWorkflow(JetBrains.ProjectModel.ISolution solution, string actionId) { }
        public override JetBrains.ReSharper.Refactorings.Workflow.RefactoringActionGroup ActionGroup { get; }
        public JetBrains.ReSharper.Refactorings.ExtractClass.Analysis.ExtractClassAnalyzer Analyzer { get; set; }
        public bool AutoResolveConflicts { get; set; }
        public JetBrains.DataFlow.IProperty<bool> ContinueEnabled { get; }
        public JetBrains.ProjectModel.IProjectFile CreatedFile { get; }
        public JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver Driver { get; }
        public override JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage FirstPendingRefactoringPage { get; }
        public override string HelpKeyword { get; }
        public JetBrains.ReSharper.Psi.PsiLanguageType Language { get; }
        public override bool MightModifyManyDocuments { get; }
        public JetBrains.ReSharper.Refactorings.ExtractClass.Info.NewFieldInfo NewFieldInfo { get; set; }
        public bool SourceNotStatic { get; }
        public override string Title { get; }
        public bool UseAutoProperties { get; set; }
        protected override JetBrains.ReSharper.Refactorings.ExtractClass.ExtractClassHelper CreateHelper(JetBrains.ReSharper.Refactorings.IRefactoringLanguageService service) { }
        public override JetBrains.ReSharper.Refactorings.Workflow.IRefactoringExecuter CreateRefactoring(JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        protected override JetBrains.ReSharper.Refactorings.ExtractClass.ExtractClassHelper CreateUnsupportedHelper() { }
        public static System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Tree.IFile> GetPsiFilesFromDocument([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.ISolution solution, JetBrains.DocumentModel.DocumentRange range) { }
        public override bool Initialize(JetBrains.Application.DataContext.IDataContext context) { }
        public override bool IsAvailable(JetBrains.Application.DataContext.IDataContext context) { }
        protected bool IsAvailableEx(JetBrains.Application.DataContext.IDataContext context, out System.Collections.Generic.ICollection<> elements, out JetBrains.ReSharper.Psi.ITypeElement ownerType) { }
        public override bool PreExecute(JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
        public void SetData(JetBrains.ReSharper.Refactorings.ExtractClass.ExtractClassData extractClassData) { }
        public override void SuccessfulFinish(JetBrains.Application.Progress.IProgressIndicator pi) { }
        public void UpdateManualContinueEnabled() { }
        public override bool Validate() { }
    }
    public class FieldInfo : JetBrains.ReSharper.Refactorings.ExtractClass.Info.DataInfo
    {
        public FieldInfo(JetBrains.ReSharper.Psi.IDeclaredElement element, JetBrains.ReSharper.Refactorings.ExtractClass.Analysis.ExtractClassAnalyzer analyzer, JetBrains.ReSharper.Psi.IField field = null) { }
        public JetBrains.ReSharper.Psi.IField Field { get; set; }
        public override System.Collections.Generic.List<JetBrains.ReSharper.Refactorings.ExtractClass.CommandInfo> FillCommands() { }
        public override bool HasSameDeclaredElement(JetBrains.ReSharper.Psi.IDeclaredElement element) { }
    }
    public interface IExtractClassWorkflowProvider : JetBrains.ReSharper.Feature.Services.ActionsMenu.IWorkflowProvider<JetBrains.ReSharper.Refactorings.Workflow.IRefactoringWorkflow, JetBrains.ReSharper.Refactorings.Workflow.RefactoringActionGroup>, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringWorkflowProvider { }
}
namespace JetBrains.ReSharper.Refactorings.ExtractClass.Info
{
    
    public class DataInfo : JetBrains.ReSharper.Refactorings.ExtractClass.Info.MemberInfo
    {
        public DataInfo(JetBrains.ReSharper.Psi.IDeclaredElement element, JetBrains.ReSharper.Refactorings.ExtractClass.Analysis.ExtractClassAnalyzer csExtractClassAnalyzer) { }
        public JetBrains.ReSharper.Psi.IProperty Property { get; }
    }
    public class DataInfoImpl : JetBrains.ReSharper.Refactorings.ExtractClass.Info.DataInfo
    {
        public DataInfoImpl(JetBrains.ReSharper.Psi.IDeclaredElement element, JetBrains.ReSharper.Refactorings.ExtractClass.Analysis.ExtractClassAnalyzer csExtractClassAnalyzer) { }
    }
    public enum DependencyDirectionEnum
    {
        Parent = 0,
        Child = 1,
        None = 2,
    }
    public enum DependencyEnum
    {
        None = 0,
        Weak = 1,
        Strong = 2,
    }
    public enum GhostStateEnum
    {
        None = 0,
        Copy = 1,
        Delegate = 2,
    }
    public class MemberInfo : JetBrains.UI.Avalon.TreeListView.ObservableObject
    {
        protected JetBrains.ReSharper.Psi.Pointers.IDeclaredElementPointer<JetBrains.ReSharper.Psi.IDeclaredElement> BindToPointer;
        protected static readonly JetBrains.ReSharper.Psi.DeclaredElementPresenterStyle PRESENTER;
        public MemberInfo(JetBrains.ReSharper.Psi.IDeclaredElement element, JetBrains.ReSharper.Refactorings.ExtractClass.Analysis.ExtractClassAnalyzer csExtractClassAnalyzer) { }
        public JetBrains.ReSharper.Psi.AccessRights AccessRights { get; set; }
        public virtual JetBrains.ReSharper.Psi.IDeclaredElement BindTo { get; set; }
        public System.Collections.Generic.List<JetBrains.ReSharper.Refactorings.ExtractClass.Info.MemberInfo.RelativeInfo> Children { get; set; }
        public JetBrains.ReSharper.Refactorings.ExtractClass.ConflictInfo ConflictInfo { get; set; }
        public bool ContainsThis { get; set; }
        public virtual JetBrains.ReSharper.Psi.IDeclaredElement DeclaredElement { get; set; }
        public JetBrains.ReSharper.Refactorings.ExtractClass.Info.DependencyDirectionEnum DependencyDirection { get; set; }
        public JetBrains.ReSharper.Refactorings.ExtractClass.Info.DependencyEnum Dependent { get; }
        public JetBrains.UI.Extensions.Commands.SimpleCommand ExtractCommand { get; set; }
        public System.Collections.Generic.List<JetBrains.ReSharper.Refactorings.ExtractClass.CommandInfo> GhostCommands { get; set; }
        public JetBrains.ReSharper.Refactorings.ExtractClass.Info.GhostStateEnum GhostMember { get; set; }
        public JetBrains.UI.Icons.IconId Icon { get; set; }
        public virtual bool Included { get; set; }
        public JetBrains.UI.Icons.IconId IncludedIcon { get; set; }
        public string InfoTooltip { get; set; }
        public JetBrains.UI.Icons.IconId InheritanceIcon { get; set; }
        public bool InstanceUsage { get; set; }
        public bool IsNotAbstract { get; set; }
        public bool IsPublic { get; set; }
        public bool IsReadonly { get; set; }
        public bool IsStatic { get; set; }
        public System.Windows.Media.ImageSource NonIncludedIcon { get; set; }
        public System.Collections.Generic.List<JetBrains.ReSharper.Refactorings.ExtractClass.Info.MemberInfo.RelativeInfo> Parents { get; }
        public string Presentation { get; set; }
        public bool ShowDependencies { get; set; }
        public JetBrains.ReSharper.Refactorings.ExtractClass.Info.MemberInfo.StatusEnum Status { get; set; }
        public virtual System.Collections.Generic.List<JetBrains.ReSharper.Refactorings.ExtractClass.CommandInfo> FillCommands() { }
        protected void FillGhostCommands() { }
        public virtual bool HasSameDeclaredElement(JetBrains.ReSharper.Psi.IDeclaredElement element) { }
        protected void UpdateColors() { }
        public void UpdateDeclaredElement() { }
        public class RelativeInfo
        {
            public RelativeInfo(JetBrains.ReSharper.Refactorings.ExtractClass.Info.MemberInfo typeMember, JetBrains.ReSharper.Psi.Tree.ExpressionAccessType accessType) { }
            public JetBrains.ReSharper.Refactorings.ExtractClass.Info.MemberInfo Member { get; }
            public JetBrains.ReSharper.Psi.Tree.ExpressionAccessType Usage { get; set; }
            public void Escalate(JetBrains.ReSharper.Psi.Tree.ExpressionAccessType accessType) { }
        }
        public enum StatusEnum
        {
            Member = 0,
            Data = 1,
            Constructor = 2,
            Supertype = 3,
            Type = 4,
        }
    }
    public class MemberInfoImpl : JetBrains.ReSharper.Refactorings.ExtractClass.Info.MemberInfo
    {
        public MemberInfoImpl(JetBrains.ReSharper.Psi.IDeclaredElement element, JetBrains.ReSharper.Refactorings.ExtractClass.Analysis.ExtractClassAnalyzer csExtractClassAnalyzer) { }
    }
    public class NewFieldInfo : JetBrains.UI.Avalon.TreeListView.ObservableObject, System.ComponentModel.IDataErrorInfo
    {
        public NewFieldInfo(JetBrains.ReSharper.Psi.ITypeElement sourceTypeElement, JetBrains.ReSharper.Refactorings.ExtractClass.ExtractClassWorkflow workflow) { }
        public string Error { get; }
        public string this[string columnName] { get; }
        public JetBrains.ReSharper.Psi.IProperty Property { get; set; }
        public string SourceFieldName { get; set; }
        public string SourceParameterName { get; set; }
        public JetBrains.ReSharper.Psi.ITypeElement SourceTypeElement { get; set; }
        public string TargetClassName { get; set; }
        public string TargetFieldName { get; set; }
        public JetBrains.ReSharper.Psi.ITypeElement TargetTypeElement { get; set; }
        public JetBrains.ReSharper.Psi.IDeclaredElement TargetTypeMember { get; set; }
        public bool UseSourceInTarget { get; set; }
        public bool UseTargetInSource { get; set; }
        public void FillTarget(JetBrains.ReSharper.Psi.ITypeElement targetTypeElement) { }
        public JetBrains.ReSharper.Psi.Tree.ITypeDeclaration GetSourceTypeDeclaration() { }
        public JetBrains.ReSharper.Psi.Resolve.ISubstitution GetSubstitution() { }
        public JetBrains.ReSharper.Psi.Tree.ITypeDeclaration GetTargetTypeDeclaration() { }
    }
}
namespace JetBrains.ReSharper.Refactorings.ExtractClass.UI
{
    
    public class EmptyInputRule : System.Windows.Controls.ValidationRule
    {
        public override System.Windows.Controls.ValidationResult Validate(object value, System.Globalization.CultureInfo cultureInfo) { }
    }
    public class RefactoringWindow : System.Windows.Controls.UserControl, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage, System.Windows.Markup.IComponentConnector
    {
        public RefactoringWindow(JetBrains.ReSharper.Refactorings.ExtractClass.ExtractClassWorkflow workflow) { }
        public JetBrains.ReSharper.Refactorings.ExtractClass.Analysis.ExtractClassAnalyzer Analyzer { get; set; }
        public JetBrains.DataFlow.IProperty<bool> ContinueEnabled { get; }
        public string Description { get; }
        public bool DoNotShow { get; }
        public string Title { get; }
        public JetBrains.UI.CrossFramework.EitherControl View { get; }
        public JetBrains.ReSharper.Refactorings.ExtractClass.ExtractClassWorkflow Workflow { get; }
        public JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage Commit(JetBrains.Application.Progress.IProgressIndicator pi) { }
        public bool Initialize(JetBrains.Application.Progress.IProgressIndicator pi) { }
        public void InitializeComponent() { }
        public bool RefreshContents(JetBrains.Application.Progress.IProgressIndicator pi) { }
    }
}
namespace JetBrains.ReSharper.Refactorings.ExtractMethod
{
    
    public abstract class ControlFlowAnalyzer
    {
        protected ControlFlowAnalyzer(JetBrains.ReSharper.Psi.ControlFlow.IControlFlowGraf graf, JetBrains.ReSharper.Psi.ITreeRange range) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.ControlFlow.IControlFlowElement> Entries { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.ControlFlow.IControlFlowElement> EntryDoorways { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.ControlFlow.IControlFlowRib> EntryRibs { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.ControlFlow.IControlFlowRib> ExitRibs { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.ControlFlow.IControlFlowElement> InsideElements { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.ControlFlow.IControlFlowElement> OutsideElements { get; }
        public System.Collections.Generic.ICollection<JetBrains.ReSharper.Refactorings.ExtractMethod.LocalVariable> AnalyzeVariables() { }
        public static JetBrains.ReSharper.Psi.IType AnotypeUsed(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public JetBrains.ReSharper.Refactorings.ExtractMethod.ExtractMethodAvailabilityCheckResult CheckEntriesAndExits(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.ControlFlow.IControlFlowRib> returnRibsEnumerable) { }
        protected abstract void EvaluateReadAndWrittenVariables(JetBrains.ReSharper.Psi.ControlFlow.IControlFlowElement element, System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.ITypeOwner> readVariables, System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.ITypeOwner> writtenVariables);
        protected virtual JetBrains.ReSharper.Psi.IType GetAnotypeHardUsed(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        protected virtual JetBrains.ReSharper.Psi.IType GetAnotypeUsed(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        protected virtual JetBrains.ReSharper.Psi.IDeclaredElement GetImplicitlyDeclaredElement(JetBrains.ReSharper.Psi.Tree.ITreeNode treeNode) { }
        protected virtual JetBrains.ReSharper.Psi.IDeclaredElement GetPrimaryElement(JetBrains.ReSharper.Psi.IDeclaredElement variable) { }
        public static JetBrains.ReSharper.Psi.IType GetUsedAnotype(JetBrains.ReSharper.Psi.IType type) { }
        public bool HasAnotypes() { }
        protected virtual bool IsAnotyped(JetBrains.ReSharper.Psi.ITypeOwner v) { }
        protected bool IsInside([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.ControlFlow.IControlFlowElement element) { }
        public virtual bool IsThrow(JetBrains.ReSharper.Psi.ControlFlow.IControlFlowRib exitRib) { }
        protected virtual bool IsVariable([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IDeclaredElement typeOwner) { }
        protected virtual bool PreviewMightBeDeclaredForOutside(JetBrains.ReSharper.Psi.ITypeOwner variable, bool value) { }
        protected virtual bool PreviewPassedInside(JetBrains.ReSharper.Psi.ITypeOwner variable, bool value) { }
        protected virtual bool PreviewRequiredOutside(JetBrains.ReSharper.Psi.ITypeOwner variable, bool value, bool modifiedInside) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IType> UsedAnotypes() { }
    }
    public abstract class ExpressionExtractMethodBase : JetBrains.ReSharper.Refactorings.ExtractMethod.ExtractMethodBase
    {
        protected ExpressionExtractMethodBase(bool canBeStatic, bool canBeInstance, JetBrains.ReSharper.Psi.Tree.IExpression expression, System.Collections.Generic.ICollection<JetBrains.ReSharper.Refactorings.ExtractMethod.LocalVariable> localVariables) { }
        public JetBrains.ReSharper.Psi.Tree.IExpression Expression { get; }
        public override bool IsValid { get; }
        public override System.Collections.Generic.ICollection<JetBrains.ReSharper.Refactorings.ExtractMethod.LocalVariable> LocalVariables { get; }
        public override string ReturnValue { get; set; }
        public override System.Collections.Generic.IEnumerable<string> ReturnValueChoices { get; }
        protected abstract JetBrains.ReSharper.Refactorings.ExtractMethod.ExtractMethodParameter CreateParameter(JetBrains.ReSharper.Refactorings.ExtractMethod.LocalVariable variable);
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IType> UsedAnotypes() { }
    }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "ExtractMethod"})]
    public class ExtractMethodAction : JetBrains.ReSharper.Refactorings.Workflow.ExtensibleRefactoringAction<JetBrains.ReSharper.Refactorings.ExtractMethod.IExtractMethodWorkflowProvider>
    {
        public const string ACTION_ID = "ExtractMethod";
        protected override JetBrains.UI.RichText.RichText Caption { get; }
    }
    public class ExtractMethodAvailabilityCheckResult : JetBrains.Util.EnumPattern
    {
        public static readonly JetBrains.ReSharper.Refactorings.ExtractMethod.ExtractMethodAvailabilityCheckResult BlockHasExitsToVariousPoints;
        public static readonly JetBrains.ReSharper.Refactorings.ExtractMethod.ExtractMethodAvailabilityCheckResult BlockHasMultipleEntries;
        public static readonly JetBrains.ReSharper.Refactorings.ExtractMethod.ExtractMethodAvailabilityCheckResult Disabled;
        public static readonly JetBrains.ReSharper.Refactorings.ExtractMethod.ExtractMethodAvailabilityCheckResult ExpressionHasAnonymousType;
        public static readonly JetBrains.ReSharper.Refactorings.ExtractMethod.ExtractMethodAvailabilityCheckResult ExpressionHasUnknownType;
        public static readonly JetBrains.ReSharper.Refactorings.ExtractMethod.ExtractMethodAvailabilityCheckResult ExpressionHasVoidType;
        public static readonly JetBrains.ReSharper.Refactorings.ExtractMethod.ExtractMethodAvailabilityCheckResult Success;
        public static readonly JetBrains.ReSharper.Refactorings.ExtractMethod.ExtractMethodAvailabilityCheckResult UnsupportedLanguage;
        public ExtractMethodAvailabilityCheckResult(string name, string message) { }
        public ExtractMethodAvailabilityCheckResult(string name, string message, bool blocksRefactoring) { }
        public bool BlocksRefactoring { get; set; }
        public string Message { get; }
    }
    public abstract class ExtractMethodBase : JetBrains.ReSharper.Refactorings.ExtractMethod.IExtractMethod, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringExecuter
    {
        protected ExtractMethodBase(bool canBeStatic, bool canBeInstance, JetBrains.ReSharper.Psi.Modules.IPsiModule module) { }
        public JetBrains.ReSharper.Psi.AccessRights AccessRights { get; set; }
        protected bool AllowPrivate { get; set; }
        public bool CanBeInstance { get; }
        public bool CanBeStatic { get; }
        public JetBrains.ReSharper.Psi.Tree.ITypeMemberDeclaration ExtractedDeclaration { get; set; }
        public virtual bool IsValid { get; }
        public abstract JetBrains.ReSharper.Psi.PsiLanguageType Language { get; }
        public abstract JetBrains.ReSharper.Psi.PsiLanguageType LanguageType { get; }
        public abstract System.Collections.Generic.ICollection<JetBrains.ReSharper.Refactorings.ExtractMethod.LocalVariable> LocalVariables { get; }
        public bool MakeStatic { get; set; }
        public JetBrains.ReSharper.Psi.Modules.IPsiModule Module { get; }
        public virtual string Name { get; set; }
        public JetBrains.Util.PartialSorter<JetBrains.ReSharper.Refactorings.ExtractMethod.ExtractMethodParameter> Parameters { get; }
        public abstract string ReturnValue { get; set; }
        public abstract System.Collections.Generic.IEnumerable<string> ReturnValueChoices { get; }
        public JetBrains.ProjectModel.ISolution Solution { get; }
        public virtual JetBrains.ReSharper.Refactorings.ExtractMethod.ExtractMethodAvailabilityCheckResult Check() { }
        public abstract bool Execute(JetBrains.Application.Progress.IProgressIndicator pi);
        public JetBrains.ReSharper.Refactorings.ExtractMethod.ExtractMethodParameter FindParameter(JetBrains.ReSharper.Refactorings.ExtractMethod.LocalVariable localVariable) { }
        public virtual bool IsSupportedAccessRights(JetBrains.ReSharper.Psi.AccessRights accessRights) { }
        public bool IsValidName(string name) { }
        public virtual void PostExecute(JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
        public abstract string PreviewDeclaration();
        protected void SetSupportedAccessRights(JetBrains.ReSharper.Psi.ITreeRange treeRange) { }
        public virtual System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IType> UsedAnotypes() { }
    }
    public class ExtractMethodPage : JetBrains.UI.CommonControls.SafeUserControl, JetBrains.CommonControls.Validation.IValidatorProvider, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage
    {
        public ExtractMethodPage(JetBrains.ReSharper.Refactorings.ExtractMethod.IExtractMethod extractMethod, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Psi.PsiLanguageType languageType) { }
        public JetBrains.DataFlow.IProperty<bool> ContinueEnabled { get; }
        public string Description { get; }
        public bool DoNotShow { get; }
        public string Title { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.CommonControls.Validation.IValidator> Validators { get; }
        public JetBrains.UI.CrossFramework.EitherControl View { get; }
        public JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage Commit(JetBrains.Application.Progress.IProgressIndicator pi) { }
        protected override void Dispose(bool disposing) { }
        public bool Initialize(JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
        public bool RefreshContents(JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
    }
    public class ExtractMethodParameter
    {
        public ExtractMethodParameter([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Refactorings.ExtractMethod.LocalVariable variable) { }
        public JetBrains.ReSharper.Psi.ParameterKind Kind { get; set; }
        public string Name { get; set; }
        public bool Pass { get; set; }
        public string TypePresented { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ReSharper.Refactorings.ExtractMethod.LocalVariable Variable { get; }
    }
    public class ExtractMethodUtil
    {
        public static bool CanBeInstance(JetBrains.ReSharper.Psi.ITreeRange treeRange) { }
        public static bool CanBeStatic(JetBrains.ReSharper.Psi.ITreeRange treeRange) { }
        public static JetBrains.ReSharper.Refactorings.ExtractMethod.ExtractMethodAvailabilityCheckResult CheckExpression(JetBrains.ReSharper.Psi.Tree.IExpression expression) { }
        public static System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.ITypeParameter> GetTypeParameters(JetBrains.ReSharper.Refactorings.ExtractMethod.ExtractMethodBase extractMethodBase) { }
        public static System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.ITypeParameter> GetTypeParameters(JetBrains.ReSharper.Psi.ITreeRange treeRange) { }
        public static bool MightBeRequiredOutside(JetBrains.ReSharper.Refactorings.ExtractMethod.LocalVariable localVariable) { }
        public static string ReplaceNodesForPreview(JetBrains.ReSharper.Psi.ManuallyRemappedTreeNodePointer nodePointer, JetBrains.ReSharper.Psi.Tree.IDeclaration declaration) { }
        public static void ReplaceUninitializedParametersNodes(JetBrains.ReSharper.Psi.ManuallyRemappedTreeNodePointer unpassedParametersMarker) { }
        public class RenamedVariable
        {
            public RenamedVariable(JetBrains.ReSharper.Psi.IDeclaredElement originalElement, JetBrains.ReSharper.Psi.IDeclaredElement newElement, string newName) { }
            public JetBrains.ReSharper.Psi.IDeclaredElement NewElement { get; }
            public string NewName { get; }
            public JetBrains.ReSharper.Psi.IDeclaredElement OriginalElement { get; }
            public void RenameDeclarations() { }
            public void TryBindReference(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        }
    }
    public class ExtractMethodWorkflow : JetBrains.ReSharper.Refactorings.Workflow.DrivenRefactoringWorkflow
    {
        public ExtractMethodWorkflow(JetBrains.ProjectModel.ISolution solution, string actionId) { }
        public override JetBrains.ReSharper.Refactorings.Workflow.RefactoringActionGroup ActionGroup { get; }
        public override JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage FirstPendingRefactoringPage { get; }
        public override string HelpKeyword { get; }
        public JetBrains.ReSharper.Psi.PsiLanguageType LanguageType { get; }
        public override bool MightModifyManyDocuments { get; }
        public override string Title { get; }
        public override JetBrains.ReSharper.Refactorings.Workflow.IRefactoringExecuter CreateRefactoring(JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public override bool Initialize(JetBrains.Application.DataContext.IDataContext context) { }
        public override bool IsAvailable(JetBrains.Application.DataContext.IDataContext context) { }
        public override bool PostExecute(JetBrains.Application.Progress.IProgressIndicator pi) { }
        public override void SuccessfulFinish(JetBrains.Application.Progress.IProgressIndicator pi) { }
    }
    public interface IExtractMethod : JetBrains.ReSharper.Refactorings.Workflow.IRefactoringExecuter
    {
        JetBrains.ReSharper.Psi.AccessRights AccessRights { get; set; }
        bool CanBeInstance { get; }
        bool CanBeStatic { get; }
        JetBrains.ReSharper.Psi.Tree.ITypeMemberDeclaration ExtractedDeclaration { get; set; }
        bool IsValid { get; }
        JetBrains.ReSharper.Psi.PsiLanguageType LanguageType { get; }
        bool MakeStatic { get; set; }
        string Name { get; set; }
        JetBrains.Util.PartialSorter<JetBrains.ReSharper.Refactorings.ExtractMethod.ExtractMethodParameter> Parameters { get; }
        string ReturnValue { get; set; }
        System.Collections.Generic.IEnumerable<string> ReturnValueChoices { get; }
        JetBrains.ReSharper.Refactorings.ExtractMethod.ExtractMethodAvailabilityCheckResult Check();
        bool IsSupportedAccessRights(JetBrains.ReSharper.Psi.AccessRights accessRights);
        bool IsValidName(string name);
        void PostExecute(JetBrains.Application.Progress.IProgressIndicator pi);
        string PreviewDeclaration();
    }
    public interface IExtractMethodFactory : JetBrains.ReSharper.Refactorings.ILanguageSpecificRefactoringService
    {
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Refactorings.ExtractMethod.ExtractMethodAvailabilityCheckResult CheckAvailability([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.ISolution solution, [JetBrains.Annotations.NotNullAttribute()] JetBrains.TextControl.ITextControl textControl);
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Refactorings.ExtractMethod.IExtractMethod CreateExtractMethod([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.ISolution solution, [JetBrains.Annotations.NotNullAttribute()] JetBrains.TextControl.ITextControl textControl);
    }
    public interface IExtractMethodWorkflowProvider : JetBrains.ReSharper.Feature.Services.ActionsMenu.IWorkflowProvider<JetBrains.ReSharper.Refactorings.Workflow.IRefactoringWorkflow, JetBrains.ReSharper.Refactorings.Workflow.RefactoringActionGroup>, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringWorkflowProvider { }
    public class LocalVariable
    {
        public LocalVariable([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.ITypeOwner variable, bool declaredInside, bool valuePassedInside, bool valueRequiredOutside, bool referencedOutside, bool referencedInside, bool valueNotUsedInside, bool hardUsedAnotypeInside, bool hardUsedAnotypeOutside) { }
        public bool DeclaredInside { get; }
        public bool MyHardUsedAnotypeInside { get; }
        public bool MyHardUsedAnotypeOutside { get; }
        public string Name { get; set; }
        public bool Pass { get; set; }
        public bool ReferencedInside { get; }
        public bool ReferencedOutside { get; }
        public bool ValueNotUsedInside { get; }
        public bool ValuePassedInside { get; }
        public bool ValueRequiredOutside { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Psi.ITypeOwner Variable { get; }
    }
    public abstract class StatementExtractMethodBase : JetBrains.ReSharper.Refactorings.ExtractMethod.ExtractMethodBase
    {
        protected const string METHOD_RETURN_VALUE = "<Method return value>";
        protected readonly JetBrains.ReSharper.Psi.ManuallyRemappedTreeNodePointer myUnpassedParametersMarker;
        public const string NO_RETURN_VALUE = "<No return value>";
        protected StatementExtractMethodBase(JetBrains.ReSharper.Psi.IParametersOwner containingParametersOwner, bool canBeStatic, bool canBeInstance, JetBrains.ReSharper.Psi.Modules.IPsiModule project, JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
        protected JetBrains.ReSharper.Psi.IParametersOwner ContainingParametersOwner { get; }
        protected abstract System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.ControlFlow.IControlFlowRib> ExitRibs { get; }
        public override bool IsValid { get; }
        public override string Name { get; set; }
        protected JetBrains.ReSharper.Refactorings.ExtractMethod.LocalVariable ReturnedVariable { get; }
        protected JetBrains.ReSharper.Psi.IType ReturnType { get; }
        public override string ReturnValue { get; set; }
        [JetBrains.Annotations.NotNullAttribute()]
        public override System.Collections.Generic.IEnumerable<string> ReturnValueChoices { get; }
        protected abstract JetBrains.ReSharper.Refactorings.ExtractMethod.ExtractMethodParameter CreateParameter(JetBrains.ReSharper.Refactorings.ExtractMethod.LocalVariable localVariable, bool isReturned);
        protected System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.ControlFlow.IControlFlowRib> GetExitsOfType(JetBrains.ReSharper.Psi.ControlFlow.ControlFlowRibType ribType) { }
        protected void InitializeReturnValue() { }
        public override void PostExecute(JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
        protected abstract JetBrains.ReSharper.Refactorings.ExtractMethod.ExtractMethodParameter UpdateParameter(JetBrains.ReSharper.Refactorings.ExtractMethod.ExtractMethodParameter parameter, bool isReturned);
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IType> UsedAnotypes() { }
    }
}
namespace JetBrains.ReSharper.Refactorings.Function2Indexer
{
    
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "Function2Indexer"})]
    public class Function2IndexerAction : JetBrains.ReSharper.Refactorings.Workflow.ExtensibleRefactoringAction<JetBrains.ReSharper.Refactorings.Function2Indexer.IFunction2IndexerWorkflowProvider>
    {
        public const string ACTION_ID = "Function2Indexer";
        protected override JetBrains.UI.RichText.RichText Caption { get; }
    }
    public class Function2IndexerRefactoring : JetBrains.ReSharper.Refactorings.Function2Property.Function2PropertyRefactoring
    {
        public Function2IndexerRefactoring(JetBrains.ReSharper.Refactorings.Function2Property.Function2PropertyWorkflow workFlow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public override string Caption { get; }
        protected override JetBrains.ReSharper.Refactorings.Function2Property.Function2PropertyBase CreateRefactoringInternal(JetBrains.ReSharper.Refactorings.InternalRefactoringLanguageService service) { }
    }
    public class Function2IndexerWorkflow : JetBrains.ReSharper.Refactorings.Function2Property.Function2PropertyWorkflow
    {
        public Function2IndexerWorkflow(JetBrains.ProjectModel.ISolution solution, string actionId) { }
        public override JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage FirstPendingRefactoringPage { get; }
        public override bool MakeDefault { get; }
        public override string PropertyName { get; }
        public override string Title { get; }
        protected bool CheckLanguage(JetBrains.ReSharper.Psi.IMethod method) { }
        public override JetBrains.ReSharper.Refactorings.Workflow.IRefactoringExecuter CreateRefactoring(JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public override bool IsAvailable(JetBrains.Application.DataContext.IDataContext context) { }
    }
    public interface IFunction2IndexerWorkflowProvider : JetBrains.ReSharper.Feature.Services.ActionsMenu.IWorkflowProvider<JetBrains.ReSharper.Refactorings.Workflow.IRefactoringWorkflow, JetBrains.ReSharper.Refactorings.Workflow.RefactoringActionGroup>, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringWorkflowProvider { }
}
namespace JetBrains.ReSharper.Refactorings.Function2Property
{
    
    public class CsFunction2PropertyWindow : JetBrains.UI.CommonControls.SafeUserControl, JetBrains.ReSharper.Refactorings.Function2Property.IFunction2PropertyPage, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage
    {
        public CsFunction2PropertyWindow(JetBrains.ReSharper.Refactorings.Function2Property.Function2PropertyWorkflow workflow) { }
        public JetBrains.DataFlow.IProperty<bool> ContinueEnabled { get; }
        public string Description { get; }
        public bool DoNotShow { get; }
        public string Title { get; }
        public JetBrains.UI.CrossFramework.EitherControl View { get; }
        public JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage Commit(JetBrains.Application.Progress.IProgressIndicator pi) { }
        protected override void Dispose(bool disposing) { }
        public bool Initialize(JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
        public bool Initialize(JetBrains.ReSharper.Refactorings.Function2Property.CsFunction2PropertyWindow progressIndicator) { }
        public bool RefreshContents(JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
    }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "Fucntion2Property"})]
    public class Fucntion2PropertyAction : JetBrains.ReSharper.Refactorings.Workflow.ExtensibleRefactoringAction<JetBrains.ReSharper.Refactorings.Function2Property.IFucntion2PropertyWorkflowProvider>
    {
        public const string ACTION_ID = "Fucntion2Property";
        protected override JetBrains.UI.RichText.RichText Caption { get; }
    }
    public abstract class Function2PropertyBase : JetBrains.ReSharper.Refactorings.Common.Convert.ConvertBase<JetBrains.ReSharper.Refactorings.Function2Property.Function2PropertyWorkflow, JetBrains.ReSharper.Refactorings.Function2Property.Function2PropertyRefactoring>
    {
        [JetBrains.Annotations.NotNullAttribute()]
        protected JetBrains.ReSharper.Psi.IMethod myMethod;
        protected readonly JetBrains.ReSharper.Psi.IType myPropertyType;
        protected readonly JetBrains.ReSharper.Psi.IType myScalarType;
        protected Function2PropertyBase(JetBrains.ReSharper.Refactorings.Function2Property.Function2PropertyWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        protected abstract bool CheckExplicitImplementationList(JetBrains.ReSharper.Psi.IOverridableMember accessor, JetBrains.ReSharper.Psi.IMethod method);
        protected bool CompareProperties(JetBrains.ReSharper.Psi.IOverridableMember accessor, JetBrains.ReSharper.Psi.IMethod method) { }
        public override void ExecuteDeclarationRefactoring(JetBrains.ReSharper.Psi.IDeclaredElement element, JetBrains.Application.Progress.IProgressIndicator pi) { }
        public override string[] GetAllNames() { }
        protected virtual System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.ITypeMember> GetMembers(JetBrains.ReSharper.Psi.ITypeElement containingType, JetBrains.ReSharper.Psi.IMethod method) { }
        protected virtual void MultiplePropertiesFound(JetBrains.ReSharper.Psi.IProperty property) { }
        public abstract void PropcessMethod(JetBrains.ReSharper.Psi.IDeclaredElement element);
        protected virtual void RenameParameter(JetBrains.ReSharper.Psi.IMethod method, JetBrains.ReSharper.Psi.IProperty existingProperty) { }
        protected void RenameParameters(JetBrains.ReSharper.Psi.IMethod method, JetBrains.ReSharper.Psi.IProperty existingProperty) { }
        protected override JetBrains.ReSharper.Refactorings.Function2Property.PropertySearchResultBase TestPropertyParameters(JetBrains.ReSharper.Psi.IProperty property) { }
        public TPropertyDeclType TryFindPropertyToComplete<TPropertyDeclType>(JetBrains.ReSharper.Psi.IMethod method, JetBrains.ReSharper.Psi.ITypeElement containingType, out bool hasOverloads)
            where TPropertyDeclType :  class { }
    }
    public class Function2PropertyRefactoring : JetBrains.ReSharper.Refactorings.Common.Convert.ConvertRefactoring<JetBrains.ReSharper.Refactorings.Function2Property.Function2PropertyWorkflow, JetBrains.ReSharper.Refactorings.Function2Property.Function2PropertyBase>
    {
        public Function2PropertyRefactoring(JetBrains.ReSharper.Refactorings.Function2Property.Function2PropertyWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public override string Caption { get; }
        protected override JetBrains.ReSharper.Refactorings.Function2Property.Function2PropertyBase CreateRefactoringInternal(JetBrains.ReSharper.Refactorings.InternalRefactoringLanguageService service) { }
        protected override JetBrains.ReSharper.Refactorings.Function2Property.Function2PropertyBase CreateUnsupportedRefactoring() { }
    }
    public class Function2PropertyTestDataProvider : JetBrains.ReSharper.Refactorings.Function2Property.IFunction2PropertyDataProvider
    {
        public Function2PropertyTestDataProvider(string propertyName, bool makeDefault) { }
        public bool MakeDefault { get; set; }
        public string PropertyName { get; set; }
    }
    public class Function2PropertyWorkflow : JetBrains.ReSharper.Refactorings.Workflow.DrivenRefactoringWorkflow, JetBrains.ReSharper.Refactorings.Common.Convert.IConvertRefactoringWorkflow
    {
        protected readonly JetBrains.ReSharper.Psi.Transactions.IPsiTransactions myPsiTransactions;
        public Function2PropertyWorkflow(JetBrains.ProjectModel.ISolution solution, string actionId) { }
        public override JetBrains.ReSharper.Refactorings.Workflow.RefactoringActionGroup ActionGroup { get; }
        public bool CanBeDefault { get; set; }
        public bool DontFindOverrides { get; }
        public override JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage FirstPendingRefactoringPage { get; }
        public override string HelpKeyword { get; }
        public bool IsGetter { get; }
        public JetBrains.ReSharper.Psi.PsiLanguageType LanguageType { get; }
        public virtual bool MakeDefault { get; set; }
        public string MethodName { get; }
        public override bool MightModifyManyDocuments { get; }
        public JetBrains.ReSharper.Psi.Pointers.IDeclaredElementPointer<JetBrains.ReSharper.Psi.IOverridableMember> Pointer { get; set; }
        public virtual string PropertyName { get; set; }
        public override string Title { get; }
        public override JetBrains.ReSharper.Refactorings.Workflow.IRefactoringExecuter CreateRefactoring(JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public override bool Initialize(JetBrains.Application.DataContext.IDataContext context) { }
        public override bool IsAvailable(JetBrains.Application.DataContext.IDataContext context) { }
        public void SetDataProvider(JetBrains.ReSharper.Refactorings.Function2Property.IFunction2PropertyDataProvider value) { }
        public override bool Validate() { }
    }
    public class static FunctionIsNotUsedInInvokationConflict
    {
        public static JetBrains.ReSharper.Refactorings.Conflicts.IConflict Create(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
    }
    public interface IFucntion2PropertyWorkflowProvider : JetBrains.ReSharper.Feature.Services.ActionsMenu.IWorkflowProvider<JetBrains.ReSharper.Refactorings.Workflow.IRefactoringWorkflow, JetBrains.ReSharper.Refactorings.Workflow.RefactoringActionGroup>, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringWorkflowProvider { }
    public interface IFunction2PropertyDataProvider
    {
        bool MakeDefault { get; }
        string PropertyName { get; }
    }
    public interface IFunction2PropertyPage { }
    public class MethodReferencesBinder : JetBrains.ReSharper.Psi.IRecursiveElementProcessor
    {
        public MethodReferencesBinder() { }
        public bool ProcessingIsFinished { get; }
        public static System.Collections.Generic.List<JetBrains.ReSharper.Refactorings.Util.ReferenceBinding> GetBindingsOfMethod(JetBrains.ReSharper.Psi.IMethod method) { }
        public bool InteriorShouldBeProcessed(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public void ProcessAfterInterior(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public void ProcessBeforeInterior(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
    }
    public abstract class PropertySearchResultBase
    {
        public static JetBrains.ReSharper.Refactorings.Function2Property.PropertySearchResultBase Matched;
        public static JetBrains.ReSharper.Refactorings.Function2Property.PropertySearchResultBase MatchedWithParamsDiff;
        public static JetBrains.ReSharper.Refactorings.Function2Property.PropertySearchResultBase NotMatched;
        public static JetBrains.ReSharper.Refactorings.Function2Property.PropertySearchResultBase NotMatchedHasGetter;
        public static JetBrains.ReSharper.Refactorings.Function2Property.PropertySearchResultBase NotMatchedHasSetter;
        public static JetBrains.ReSharper.Refactorings.Function2Property.PropertySearchResultBase NotMatchedOfDefaultName;
        public static JetBrains.ReSharper.Refactorings.Function2Property.PropertySearchResultBase NotMatchedOtherType;
        public static JetBrains.ReSharper.Refactorings.Function2Property.PropertySearchResultBase NotMatchedOverload;
        public static JetBrains.ReSharper.Refactorings.Function2Property.PropertySearchResultBase NotMatchedWrongDefault;
        public virtual bool IsDiffParamsModifiers { get; }
        public abstract bool IsMatched { get; }
        public virtual JetBrains.ReSharper.Refactorings.Function2Property.PropertySearchResultBase.NotMatchedReasons NotMatchedReason { get; }
        public enum NotMatchedReasons
        {
            No = 0,
            WrongSignature = 1,
            WrongDefault = 2,
            OtherType = 3,
            HasSetter = 4,
            HasGetter = 5,
            NotMatchedDefault = 6,
            NotMatchedOverload = 7,
        }
    }
    public class SimpleRenameDataProvider : JetBrains.ReSharper.Refactorings.Rename.IRenameDataProvider
    {
        public SimpleRenameDataProvider(string val) { }
        public SimpleRenameDataProvider(string val, System.Collections.Generic.IList<JetBrains.ReSharper.Refactorings.RenameModel.AtomicRenameBase> atomicRenames) { }
        public bool ChangeText { get; }
        public bool DoRenameFile { get; }
        public string NewName { get; }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Refactorings.RenameModel.AtomicRenameBase> GetBaseNameChange() { }
    }
    public class VBFunction2PropertyPage : JetBrains.UI.CommonControls.SafeUserControl, JetBrains.ReSharper.Refactorings.Function2Property.IFunction2PropertyPage, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage
    {
        public VBFunction2PropertyPage() { }
        public VBFunction2PropertyPage(JetBrains.ReSharper.Refactorings.Function2Property.Function2PropertyWorkflow workflow) { }
        public JetBrains.DataFlow.IProperty<bool> ContinueEnabled { get; }
        public string Description { get; }
        public bool DoNotShow { get; }
        public string Title { get; }
        public JetBrains.UI.CrossFramework.EitherControl View { get; }
        public JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage Commit(JetBrains.Application.Progress.IProgressIndicator pi) { }
        protected override void Dispose(bool disposing) { }
        public bool Initialize(JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
        public bool RefreshContents(JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
    }
}
namespace JetBrains.ReSharper.Refactorings.Helpers
{
    
    public interface INamespaceRedundancyProblemFixer
    {
        bool IsEmpty { get; }
        JetBrains.ProjectModel.IProjectFile ProjectFile { get; }
        void FixUsages();
    }
    public class NamespaceRedundancyProblemsFixer
    {
        public NamespaceRedundancyProblemsFixer(JetBrains.ReSharper.Psi.INamespace @namespace, JetBrains.ReSharper.Psi.IClrDeclaredElement[] elementsThatWillDisappear) { }
        public void CollectProblems(JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
        public static System.Collections.Generic.IList<JetBrains.ReSharper.Refactorings.Helpers.NamespaceRedundancyProblemsFixer.ProjectsPerNamespace> EvaluateAffectedProjects(JetBrains.ReSharper.Psi.INamespace ns, System.Collections.Generic.JetHashSet<JetBrains.ReSharper.Psi.IClrDeclaredElement> elementsThatWillDisappear) { }
        public void FixProblems(JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Refactorings.Helpers.INamespaceRedundancyProblemFixer> GetFixers() { }
        public class ProjectsPerNamespace
        {
            public ProjectsPerNamespace(JetBrains.ReSharper.Psi.INamespace @namespace, System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Modules.IPsiModule> projects) { }
            public JetBrains.ReSharper.Psi.INamespace Namespace { get; }
            public System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Modules.IPsiModule> Projects { get; }
        }
    }
}
namespace JetBrains.ReSharper.Refactorings.Indexer2Function
{
    
    public interface IIndexer2FunctionWorkflowProvider : JetBrains.ReSharper.Feature.Services.ActionsMenu.IWorkflowProvider<JetBrains.ReSharper.Refactorings.Workflow.IRefactoringWorkflow, JetBrains.ReSharper.Refactorings.Workflow.RefactoringActionGroup>, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringWorkflowProvider { }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "Indexer2Function"})]
    public class Indexer2FunctionAction : JetBrains.ReSharper.Refactorings.Workflow.ExtensibleRefactoringAction<JetBrains.ReSharper.Refactorings.Indexer2Function.IIndexer2FunctionWorkflowProvider>
    {
        public const string ACTION_ID = "Indexer2Function";
        protected override JetBrains.UI.RichText.RichText Caption { get; }
    }
    public abstract class Indexer2FunctionBase : JetBrains.ReSharper.Refactorings.Property2Function.Property2FunctionBase
    {
        protected Indexer2FunctionBase(JetBrains.ReSharper.Refactorings.Property2Function.Property2FunctionWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public override void ProcessProperty(JetBrains.ReSharper.Psi.IDeclaredElement propertyOrMethod) { }
        public override bool TryTransformMethodCall(JetBrains.ReSharper.Psi.Tree.IExpression expression) { }
    }
    public sealed class Indexer2FunctionRefactoring : JetBrains.ReSharper.Refactorings.Property2Function.Property2FunctionRefactoring
    {
        public Indexer2FunctionRefactoring(JetBrains.ReSharper.Refactorings.Indexer2Function.Indexer2FunctionWorkflow workFlow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public override string Caption { get; }
        protected override JetBrains.ReSharper.Refactorings.Property2Function.Property2FunctionBase CreateRefactoringInternal(JetBrains.ReSharper.Refactorings.InternalRefactoringLanguageService service) { }
        public JetBrains.ReSharper.Psi.Resolve.IReference[] FindIndexers(System.Collections.Generic.List<JetBrains.ReSharper.Psi.IOverridableMember> overrides, JetBrains.Application.Progress.IProgressIndicator pi) { }
        public override void SearchReferences(JetBrains.Application.Progress.IProgressIndicator pi) { }
    }
    public class Indexer2FunctionWorkflow : JetBrains.ReSharper.Refactorings.Property2Function.Property2FunctionWorkflow
    {
        public const string REFACTORING_CAPTION = "C&onvert Indexer To Method(s)";
        public Indexer2FunctionWorkflow(JetBrains.ProjectModel.ISolution solution, string actionId) { }
        public override string HelpKeyword { get; }
        public override string PropertyName { get; }
        public override string Title { get; }
        protected virtual bool CheckLanguage(JetBrains.ReSharper.Psi.IDeclaredElement element) { }
        public override JetBrains.ReSharper.Refactorings.Workflow.IRefactoringExecuter CreateRefactoring(JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public override bool Initialize(JetBrains.Application.DataContext.IDataContext context) { }
        protected virtual void InitPropertyName(JetBrains.ReSharper.Psi.IProperty indexer) { }
        public override bool IsAvailable(JetBrains.Application.DataContext.IDataContext context) { }
    }
    public class IndexersSearchData
    {
        public IndexersSearchData(System.Collections.Generic.List<JetBrains.ReSharper.Psi.ITypeElement> newTypeElements) { }
        public System.Collections.Generic.JetHashSet<JetBrains.ReSharper.Psi.Search.ISearchDomain> AllDomains { get; }
        public System.Collections.Generic.JetHashSet<JetBrains.ReSharper.Psi.IType> AllTypes { get; }
        public bool HasNewTypes { get; }
        public System.Collections.Generic.List<JetBrains.ReSharper.Psi.IDeclaredElement> NewDeclarations { get; }
        public System.Collections.Generic.List<JetBrains.ReSharper.Psi.IDeclaredElement> NewIndexerDeclarations { get; }
        public System.Collections.Generic.List<JetBrains.ReSharper.Psi.ITypeElement> NewTypeElements { get; }
        public void AddDeclaration(JetBrains.ReSharper.Psi.Tree.ITypeMemberDeclaration decl) { }
        public void AddDomain(JetBrains.ReSharper.Psi.Search.ISearchDomain domain) { }
        public void AddType(JetBrains.ReSharper.Psi.ITypeElement element) { }
        public void ClearDeclaredElements() { }
        public void ClearTypeElements() { }
    }
}
namespace JetBrains.ReSharper.Refactorings.Inline
{
    
    public enum AccessorKinds
    {
        Getter = 0,
        Setter = 1,
        Both = 2,
    }
    public class CallSiteContext
    {
        public CallSiteContext(JetBrains.ReSharper.Refactorings.Inline.ICallSiteContextOwner refactoring, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution, JetBrains.ReSharper.Psi.Tree.ITreeNode containingElement) { }
        public JetBrains.ReSharper.Refactorings.Inline.ICallSiteContextOwner CallSiteContextOwner { get; }
        public JetBrains.ReSharper.Psi.Tree.ITreeNode CastSearchContext { get; }
        public JetBrains.ReSharper.Psi.Resolve.ISubstitution Substitution { get; }
        public void RemapAndBind(JetBrains.ReSharper.Psi.ExtensionsAPI.ReferenceIdentitySaver saver, JetBrains.ReSharper.Psi.PsiLanguageType language) { }
    }
    public class CheckTypeKey
    {
        public CheckTypeKey(JetBrains.ReSharper.Psi.IParameter parameter, JetBrains.ReSharper.Psi.IType type) { }
        public JetBrains.ReSharper.Psi.IParameter Parameter { get; set; }
        public JetBrains.ReSharper.Psi.IType Type { get; set; }
    }
    public class ForcedCast { }
    public interface ICallSiteContextOwner
    {
        JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver Driver { get; }
        System.Collections.Generic.Dictionary<JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.ReSharper.Refactorings.Inline.LocalContextResolveResultImage> ResolveImages { get; }
        void AddContext(JetBrains.ReSharper.Psi.Tree.ITreeNode context);
        JetBrains.ReSharper.Refactorings.Inline.InlineHelper GetInlineHelper(JetBrains.ReSharper.Psi.PsiLanguageType language);
    }
    public interface IInlineMethodDataProvider
    {
        bool ForceUseDelegate { get; set; }
        bool Remove { get; set; }
        bool ReplaceAllOccurences { get; }
    }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "InlineVariable"})]
    public class InlineAction : JetBrains.ReSharper.Refactorings.Workflow.ExtensibleRefactoringAction<JetBrains.ReSharper.Refactorings.Inline.InlineWorkflowProvider>
    {
        public const string ACTION_ID = "InlineVariable";
        protected override JetBrains.UI.RichText.RichText Caption { get; }
    }
    public sealed class InlinedArgumentInfo
    {
        public JetBrains.ReSharper.Psi.Tree.IArgument Arguemnt { get; }
        public System.Collections.Generic.List<JetBrains.ReSharper.Psi.Tree.IArgument> Arguments { get; }
        public JetBrains.ReSharper.Refactorings.Inline.InlinedParameterInfo InlinedParameterInfo { get; }
        public bool ShouldCreateLocals { get; }
        public string TempVariableName { get; set; }
        public static JetBrains.ReSharper.Refactorings.Inline.InlinedArgumentInfo CreateInfo(JetBrains.ReSharper.Psi.Tree.IArgument argument, JetBrains.ReSharper.Refactorings.Inline.InlineHelper helper, JetBrains.ReSharper.Refactorings.Inline.InlinedMethodInfo inlinedMethodInfo, System.Collections.Generic.Dictionary<JetBrains.ReSharper.Psi.IParameter, JetBrains.ReSharper.Refactorings.Inline.ArgUtil.ArgumentFromParameter> parameter2argument, JetBrains.ReSharper.Refactorings.Inline.InlinedParameterInfo parameterInfo) { }
        public static JetBrains.ReSharper.Refactorings.Inline.InlinedArgumentInfo CreateInfoOfOptional(JetBrains.ReSharper.Psi.Tree.IArgument argument, JetBrains.ReSharper.Refactorings.Inline.InlineHelper helper, JetBrains.ReSharper.Refactorings.Inline.InlinedMethodInfo inlinedMethodInfo, System.Collections.Generic.Dictionary<JetBrains.ReSharper.Psi.IParameter, JetBrains.ReSharper.Refactorings.Inline.ArgUtil.ArgumentFromParameter> parameter2argument, JetBrains.ReSharper.Refactorings.Inline.InlinedParameterInfo parameterInfo) { }
        public static JetBrains.ReSharper.Refactorings.Inline.InlinedArgumentInfo CreateInfoOfParams(System.Collections.Generic.List<JetBrains.ReSharper.Psi.Tree.IArgument> arguments, JetBrains.ReSharper.Refactorings.Inline.InlineHelper helper, JetBrains.ReSharper.Refactorings.Inline.InlinedMethodInfo inlinedMethodInfo, System.Collections.Generic.Dictionary<JetBrains.ReSharper.Psi.IParameter, JetBrains.ReSharper.Refactorings.Inline.ArgUtil.ArgumentFromParameter> parameter2argument, JetBrains.ReSharper.Refactorings.Inline.InlinedParameterInfo parameterInfo) { }
    }
    public class InlinedCallInfo
    {
        public readonly System.Collections.Generic.Dictionary<JetBrains.ReSharper.Psi.ITypeOwner, string> VarToLambdaParameterName;
        public InlinedCallInfo() { }
        public System.Collections.Generic.Dictionary<int, JetBrains.ReSharper.Refactorings.Inline.InlinedArgumentInfo> Argument2Infos { get; }
        public JetBrains.ReSharper.Psi.Tree.IExpression AssignedExpression { get; }
        public bool AssignedExpressionCanHaveSideEffects { get; }
        public string AssignedExpressionTemp { get; set; }
        public JetBrains.ReSharper.Psi.Tree.IExpression DestinationOfAssignment { get; }
        public bool FromStatement { get; }
        public JetBrains.ReSharper.Refactorings.Inline.InlinedMethodInfo InlinedMethodInfo { get; }
        public bool IsDestinationOfAssignment { get; }
        public bool IsLastStatement { get; }
        public bool IsPropertyInitializer { get; set; }
        public bool IsReturned { get; }
        public bool IsSourceOfAssignment { get; }
        public JetBrains.ReSharper.Refactorings.Inline.InlinedCallKinds Kind { get; }
        public JetBrains.ReSharper.Psi.Tree.ITreeNode LastStatement { get; }
        public System.Collections.Generic.Dictionary<JetBrains.ReSharper.Psi.IParameter, JetBrains.ReSharper.Refactorings.Inline.ArgUtil.ArgumentFromParameter> Parameter2Argument { get; }
        public JetBrains.ReSharper.Psi.Tree.IExpression Qualifier { get; }
        public bool QualifierCanHaveSideEffects { get; }
        public string QualifierTempVariableName { get; set; }
        public string RetrunValueTemp { get; set; }
        public bool ShouldCreateLocals { get; }
        public bool UsedAsDelegate { get; set; }
        public JetBrains.ReSharper.Refactorings.Inline.InlinedArgumentInfo ArgumentInfoOfArgument(JetBrains.ReSharper.Refactorings.Inline.ArgUtil.ArgumentFromParameter argumentFromParameter) { }
        public static JetBrains.ReSharper.Refactorings.Inline.InlinedCallInfo CreateInfo(JetBrains.ReSharper.Refactorings.Inline.InlineMethodRefactoring refactoring, JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Refactorings.Inline.InlinedMethodInfo inlinedMethodInfo) { }
        public static JetBrains.ReSharper.Refactorings.Inline.InlinedCallInfo CreateInfoForInlineField(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Refactorings.Inline.InlinedMethodInfo inlinedMethodInfo, JetBrains.ReSharper.Refactorings.InlineField.InlineFieldRefactoring executer) { }
        public static JetBrains.ReSharper.Refactorings.Inline.InlinedCallInfo CreateInfoForInlineParameter(JetBrains.ReSharper.Refactorings.Inline.InlinedMethodInfo inlinedMethodInfo, JetBrains.ReSharper.Refactorings.InlineParameter.InlineParameterRefactoring refactoring, JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.IParametersOwner owner) { }
        public static JetBrains.ReSharper.Refactorings.Inline.InlinedCallInfo CreateInfoForInlineVar(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Refactorings.Inline.InlinedMethodInfo info, JetBrains.ReSharper.Refactorings.InlineVar.InlineVarRefactoring refactoring) { }
        public static JetBrains.ReSharper.Refactorings.Inline.InlinedCallInfo CreateInfoForIntroduceParameter(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Refactorings.Inline.InlinedMethodInfo inlinedMethodInfo, JetBrains.ReSharper.Refactorings.IntroduceParameter.IIntroduceParameterDriver executer, JetBrains.ReSharper.Psi.IParametersOwner parameterOwner) { }
        public static JetBrains.ReSharper.Refactorings.Inline.InlinedCallInfo CreateInfoForMakeStatic(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Refactorings.Inline.InlinedMethodInfo inlinedMethodInfo, JetBrains.ReSharper.Refactorings.IntroduceParameter.IIntroduceParameterDriver executer, JetBrains.ReSharper.Psi.IParametersOwner parameterOwner, JetBrains.ReSharper.Refactorings.Inline.InlinedCallInfo hack) { }
        public bool GetShouldCreateTempForReturnedValue() { }
    }
    public enum InlinedCallKinds
    {
        Method = 0,
        Setter = 1,
        Getter = 2,
    }
    public abstract class InlinedCodeTransformerBase<TReferenceExpression, TReturnStatement> : JetBrains.ReSharper.Psi.IRecursiveElementProcessor
        where TReferenceExpression : JetBrains.ReSharper.Psi.Tree.IExpression
    
    {
        protected readonly System.Collections.Generic.List<System.Func<JetBrains.ReSharper.Psi.Tree.ITreeNode>> myActions;
        protected readonly JetBrains.ReSharper.Refactorings.Inline.CallSiteContext myContext;
        protected readonly JetBrains.ReSharper.Refactorings.Inline.InlinedCallInfo myInlinedCallInfo;
        protected InlinedCodeTransformerBase(JetBrains.ReSharper.Psi.Tree.ITreeNode expression, JetBrains.ReSharper.Refactorings.Inline.InlinedCallInfo inlinedCallInfo, JetBrains.ReSharper.Refactorings.Inline.CallSiteContext context) { }
        public bool ProcessingIsFinished { get; }
        public JetBrains.ReSharper.Psi.Tree.ITreeNode TargetContext { get; }
        protected abstract JetBrains.ReSharper.Psi.Tree.ITreeNode AddActionRemoveReturn(TReturnStatement returnStatement);
        protected abstract JetBrains.ReSharper.Psi.Tree.ITreeNode AddActionReplaceExpressionWithAssignedExpression(TReferenceExpression expression);
        protected abstract JetBrains.ReSharper.Psi.Tree.ITreeNode AddActionReplaceExpressionWithTemp(JetBrains.ReSharper.Psi.Tree.IExpression expression, string newTempName);
        protected abstract JetBrains.ReSharper.Psi.Tree.ITreeNode AddActionReplaceParameterWithArgumentExpression(TReferenceExpression expression, JetBrains.ReSharper.Psi.IParameter parameter, JetBrains.ReSharper.Refactorings.Inline.InlinedArgumentInfo info);
        protected abstract JetBrains.ReSharper.Psi.Tree.ITreeNode AddActionReplaceReturnWithAssignmentToTemp(TReturnStatement returnStatement);
        protected abstract JetBrains.ReSharper.Psi.Tree.ITreeNode AddActionReplaceWithDefaultParamValue(TReferenceExpression expression, JetBrains.ReSharper.Psi.IParameter parameter);
        protected abstract JetBrains.ReSharper.Psi.Tree.ITreeNode AddActionSetQualifier(TReferenceExpression expression);
        protected virtual JetBrains.ReSharper.Psi.Tree.ITreeNode ChangeName(JetBrains.ReSharper.Psi.Tree.ITreeNode element, string name) { }
        public bool InteriorShouldBeProcessed(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        protected virtual bool IsExtensionMethod(TReferenceExpression expression) { }
        protected abstract bool IsSetterParameter(JetBrains.ReSharper.Psi.IParameter parameter);
        public virtual void ProcessAfterInterior(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public void ProcessBeforeInterior(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        protected abstract JetBrains.ReSharper.Psi.Tree.ITreeNode ReplaceByQualifier(TReferenceExpression expression, JetBrains.ReSharper.Refactorings.Inline.InlinedCallInfo info);
        protected abstract JetBrains.ReSharper.Psi.Tree.ITreeNode ReplaceReturnWithAssignment(TReturnStatement returnStatement);
        public JetBrains.ReSharper.Psi.Tree.ITreeNode Transform(JetBrains.ReSharper.Psi.Tree.ITreeNode namingContext, JetBrains.ReSharper.Refactorings.Inline.Util.LocalDeclarationIdentity identity) { }
        protected abstract void TransformElement(JetBrains.ReSharper.Psi.Tree.ITreeNode element);
        protected void TransformNQReferenceExpression(TReferenceExpression expression, JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        protected void TransformReturnStatement(TReturnStatement returnStatement) { }
        protected abstract bool ValueIsNotNull(TReturnStatement statement);
    }
    public enum InlinedElementKinds
    {
        Method = 0,
        Setter = 1,
        Getter = 2,
    }
    public sealed class InlinedMethodInfo
    {
        public System.Collections.Generic.Dictionary<int, JetBrains.ReSharper.Refactorings.Inline.InlinedParameterInfo> InlinedMethodParameterInfos;
        public bool AllReturnsAreLast { get; }
        public JetBrains.ReSharper.Psi.Tree.ITreeNode BlockOfStatements { get; }
        public bool HasOneReferenceToValue { get; }
        public JetBrains.ReSharper.Refactorings.Inline.Util.LocalDeclarationIdentity Identity { get; }
        public JetBrains.ReSharper.Refactorings.Inline.InlinedElementKinds InlinedElementKind { get; }
        public bool IsSinleLineReturn { get; }
        public bool IsStatic { get; }
        public bool IsVoid { get; }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Resolve.IReference> References { get; }
        public JetBrains.ReSharper.Psi.Tree.IExpression ReturnedExpression { get; }
        public JetBrains.ReSharper.Psi.IType ReturnType { get; }
        public bool ThisIsUsedOnce { get; }
        public static JetBrains.ReSharper.Refactorings.Inline.InlinedMethodInfo CreateForInlineParameter([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IParametersOwner parametersOwner, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Refactorings.InlineParameter.InlineParameterRefactoring refactoring) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static System.Collections.Generic.List<JetBrains.ReSharper.Refactorings.Inline.InlinedMethodInfo> CreateInfo(JetBrains.ReSharper.Refactorings.Inline.InlineMethodRefactoring refactoring, JetBrains.ReSharper.Refactorings.Inline.AccessorKinds accessorKind, JetBrains.Application.Progress.SubProgressIndicator pi) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.ReSharper.Refactorings.Inline.InlinedMethodInfo CreateInfoForInlineField([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.IExpression expression, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IField field, JetBrains.ReSharper.Refactorings.InlineField.InlineFieldRefactoring executer) { }
        public static JetBrains.ReSharper.Refactorings.Inline.InlinedMethodInfo CreateInfoForInlineVar(JetBrains.ReSharper.Psi.Tree.IExpression expression, JetBrains.ReSharper.Refactorings.InlineVar.InlineVarRefactoring refactoring, JetBrains.ReSharper.Psi.IDeclaredElement variable) { }
        public static JetBrains.ReSharper.Refactorings.Inline.InlinedMethodInfo CreateInfoForIntroduceParameter(JetBrains.ReSharper.Psi.Tree.ITreeNode expression, JetBrains.ReSharper.Psi.IParametersOwner parameterOwner, JetBrains.ReSharper.Psi.IType expressionType, JetBrains.ReSharper.Refactorings.IntroduceParameter.IntroduceParameterRefactoring executer) { }
        public static JetBrains.ReSharper.Refactorings.Inline.InlinedMethodInfo CreateInfoForMakeStatic(JetBrains.ReSharper.Psi.Tree.IExpression expression, JetBrains.ReSharper.Psi.IParametersOwner parameterOwner, JetBrains.ReSharper.Psi.IType expressionType, JetBrains.ReSharper.Refactorings.IntroduceParameter.IIntroduceParameterDriver executer, bool thisIsUsedOnce) { }
    }
    public sealed class InlinedParameterInfo
    {
        public bool HasWriteUsages { get; }
        public bool IsUsedOnce { get; }
        public JetBrains.ReSharper.Psi.IParameter Parameter { get; }
        public static JetBrains.ReSharper.Refactorings.Inline.InlinedParameterInfo CreateInfo(JetBrains.ReSharper.Psi.IParameter parameter, JetBrains.ReSharper.Refactorings.Inline.InlineMethodRefactoring executer) { }
        public static JetBrains.ReSharper.Refactorings.Inline.InlinedParameterInfo CreateInfoForInlineParameter(JetBrains.ReSharper.Psi.IParameter parameter, JetBrains.ReSharper.Refactorings.InlineParameter.InlineParameterRefactoring executer) { }
        public static JetBrains.ReSharper.Refactorings.Inline.InlinedParameterInfo CreateInfoForIntroducePrameter(JetBrains.ReSharper.Psi.IParameter parameter, JetBrains.ReSharper.Refactorings.IntroduceParameter.IIntroduceParameterDriver executer) { }
    }
    public abstract class InlineHelper
    {
        protected InlineHelper(JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver Driver { get; }
        public abstract System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Resolve.IReference> AllNotQualifiableReferences(JetBrains.ReSharper.Psi.Resolve.IReference reference);
        public abstract bool CanHaveSideEffects([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.IExpression expression);
        public abstract bool CanHaveSideEffects(JetBrains.ReSharper.Psi.Resolve.IReference reference, out JetBrains.ReSharper.Psi.Tree.IExpression qualifier, bool isStatic);
        public abstract bool CanHaveSideEffects(JetBrains.ReSharper.Psi.Tree.IArgument argument);
        public abstract System.Collections.Generic.Dictionary<int, JetBrains.ReSharper.Refactorings.Inline.InlinedArgumentInfo> GetArgument2Infos(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Refactorings.Inline.InlinedMethodInfo inlinedMethodInfo, System.Collections.Generic.Dictionary<JetBrains.ReSharper.Psi.IParameter, JetBrains.ReSharper.Refactorings.Inline.ArgUtil.ArgumentFromParameter> parameter2argument);
        [JetBrains.Annotations.CanBeNullAttribute()]
        public abstract JetBrains.ReSharper.Psi.Tree.IArgumentsOwner GetArgumentOwner(ref JetBrains.ReSharper.Psi.Resolve.IReference reference, bool replaceMethodGroup);
        [JetBrains.Annotations.NotNullAttribute()]
        public abstract JetBrains.ReSharper.Psi.Tree.ITreeNode GetContainingStatement(JetBrains.ReSharper.Psi.Tree.ITreeNode element);
        public abstract System.Collections.Generic.Dictionary<JetBrains.ReSharper.Psi.IParameter, JetBrains.ReSharper.Refactorings.Inline.ArgUtil.ArgumentFromParameter> GetParameter2Argument(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.IParametersOwner param);
        public abstract void InsertReturnValueTempVariable(JetBrains.ReSharper.Refactorings.Inline.InlinedCallInfo inlinedCallInfo, JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Refactorings.Inline.CallSiteContext context);
        public abstract void InsertTempForArgument(JetBrains.ReSharper.Refactorings.Inline.InlinedParameterInfo parameterInfo, JetBrains.ReSharper.Refactorings.Inline.InlinedArgumentInfo argumentInfo, JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Refactorings.Inline.CallSiteContext context, JetBrains.ReSharper.Psi.ExtensionsAPI.ReferenceIdentitySaver saver);
        public abstract void InsertTempForQualifier(JetBrains.ReSharper.Refactorings.Inline.InlinedCallInfo inlinedCallInfo, JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Refactorings.Inline.CallSiteContext context, JetBrains.ReSharper.Psi.ExtensionsAPI.ReferenceIdentitySaver saver);
        public abstract void InsertTempVariableForAssignedValue(JetBrains.ReSharper.Refactorings.Inline.InlinedCallInfo inlinedCallInfo, JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Refactorings.Inline.CallSiteContext context);
        public abstract bool IsSourceOfAssignment(JetBrains.ReSharper.Psi.Resolve.IReference reference, out JetBrains.ReSharper.Psi.Tree.IExpression destination, JetBrains.ReSharper.Refactorings.Inline.InlinedCallKinds inlinedCallKinds);
        public abstract void RemoveCastFromElement(JetBrains.ReSharper.Psi.Tree.ITreeNode element);
        public abstract void ReplaceTypeParameter(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.ITypeParameter parameter, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution);
    }
    public abstract class InlineMethod : JetBrains.ReSharper.Refactorings.Common.RefactoringExecBase<JetBrains.ReSharper.Refactorings.Inline.InlineMethodWorkflow, JetBrains.ReSharper.Refactorings.Inline.InlineMethodRefactoring>
    {
        protected InlineMethod(JetBrains.ReSharper.Refactorings.Inline.InlineMethodWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public abstract JetBrains.ReSharper.Refactorings.Inline.InlineHelper InlineHelper { get; }
        public abstract bool AllReturnsAreLast(JetBrains.ReSharper.Psi.IDeclaredElement element);
        public virtual JetBrains.ReSharper.Psi.Tree.ITreeNode GetBody(JetBrains.ReSharper.Psi.Tree.IDeclaration decl) { }
        public virtual JetBrains.ReSharper.Psi.Tree.ITreeNode GetContainingStatement(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public virtual JetBrains.ReSharper.Psi.Tree.ITreeNode GetContextForNaming(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public abstract bool GetIsDestinationOfAssignment(JetBrains.ReSharper.Psi.Resolve.IReference reference, out JetBrains.ReSharper.Psi.Tree.IExpression expression);
        public virtual bool GetIsPropertyInitializer(JetBrains.ReSharper.Psi.Resolve.IReference reference, out JetBrains.ReSharper.Psi.Tree.IExpression expression) { }
        public abstract bool GetThisIsUsedOnce(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement);
        public abstract bool GetUsedAsDelegate(JetBrains.ReSharper.Refactorings.Inline.InlinedMethodInfo info, JetBrains.ReSharper.Psi.Resolve.IReference reference);
        public virtual bool HasOneReferenceToValue(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
        public virtual bool HasWriteUsages(JetBrains.ReSharper.Psi.IParameter parameter) { }
        public virtual bool Ignore(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public abstract bool IsFromStatement(JetBrains.ReSharper.Psi.Resolve.IReference reference);
        public abstract bool IsLastStatement(JetBrains.ReSharper.Psi.Resolve.IReference reference, out JetBrains.ReSharper.Psi.Tree.ITreeNode statement);
        public abstract bool IsReturned(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Refactorings.Inline.InlinedCallKinds inlinedCallKind);
        public abstract bool IsReturnStatementOnly(JetBrains.ReSharper.Psi.IDeclaredElement element, out JetBrains.ReSharper.Psi.Tree.IExpression returnedExpression, out JetBrains.ReSharper.Psi.Tree.ITreeNode blockOfStatements);
        public virtual bool IsSetterParameter(JetBrains.ReSharper.Psi.IParameter parameter) { }
        public bool IsUsedOnce(JetBrains.ReSharper.Psi.IParameter parameter) { }
        public abstract bool ReplaceCall(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.Tree.IExpression returnedExpression, JetBrains.ReSharper.Refactorings.Inline.InlinedCallInfo inlinedCallInfo, JetBrains.ReSharper.Refactorings.Inline.CallSiteContext context);
        public virtual void ReplaceMethodGroup(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Refactorings.Inline.CallSiteContext context, JetBrains.ReSharper.Refactorings.Inline.InlinedCallInfo inlinedCallInfo) { }
        public virtual bool ReplacePropertyInitializer(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.Tree.ITreeNode blockOfStatements, JetBrains.ReSharper.Refactorings.Inline.InlinedCallInfo inlinedCallInfo, JetBrains.ReSharper.Refactorings.Inline.CallSiteContext context, bool b) { }
        public abstract bool ReplaceStatement(ref JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.Tree.ITreeNode statements, JetBrains.ReSharper.Refactorings.Inline.InlinedCallInfo inlinedCallInfo, JetBrains.ReSharper.Refactorings.Inline.CallSiteContext context, bool replaceOriginal);
        public virtual System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Resolve.IReference> TransformReference(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
    }
    public class InlineMethodDataProvider : JetBrains.ReSharper.Refactorings.Inline.IInlineMethodDataProvider
    {
        public InlineMethodDataProvider(bool replaceAllOccurences, bool remove) { }
        public InlineMethodDataProvider(bool replaceAllOccurences, bool remove, bool forceUseDelegate) { }
        public bool ForceUseDelegate { get; set; }
        public bool Remove { get; set; }
        public bool ReplaceAllOccurences { get; }
    }
    public class InlineMethodRefactoring : JetBrains.ReSharper.Refactorings.Common.DrivenRefactoring<JetBrains.ReSharper.Refactorings.Inline.InlineMethodWorkflow, JetBrains.ReSharper.Refactorings.Inline.InlineMethod>, JetBrains.ReSharper.Refactorings.Inline.ICallSiteContextOwner
    {
        public InlineMethodRefactoring(JetBrains.ReSharper.Refactorings.Inline.InlineMethodWorkflow workFlow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public System.Collections.Generic.Dictionary<JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.ReSharper.Refactorings.Inline.LocalContextResolveResultImage> ResolveImages { get; }
        public void AddContext(JetBrains.ReSharper.Psi.Tree.ITreeNode context) { }
        protected override JetBrains.ReSharper.Refactorings.Inline.InlineMethod CreateRefactoringInternal(JetBrains.ReSharper.Refactorings.InternalRefactoringLanguageService service) { }
        protected override JetBrains.ReSharper.Refactorings.Inline.InlineMethod CreateUnsupportedRefactoring() { }
        public override bool Execute(JetBrains.Application.Progress.IProgressIndicator pi) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Resolve.IReference> GetAllReferences(JetBrains.ReSharper.Refactorings.Inline.InlinedElementKinds elementKind, JetBrains.Application.Progress.SubProgressIndicator pi) { }
        public System.Collections.Generic.Dictionary<int, JetBrains.ReSharper.Refactorings.Inline.InlinedParameterInfo> GetInlinedMethodParameterInfos(JetBrains.ReSharper.Psi.IDeclaredElement element) { }
        public JetBrains.ReSharper.Refactorings.Inline.InlineHelper GetInlineHelper(JetBrains.ReSharper.Psi.PsiLanguageType language) { }
        public bool IsVoid(JetBrains.ReSharper.Psi.IDeclaredElement element) { }
        public System.Collections.Generic.Dictionary<JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.ReSharper.Refactorings.Inline.LocalContextResolveResultImage> SaveContextReferences(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
    }
    [JetBrains.Application.Settings.SettingsKeyAttribute(typeof(JetBrains.ReSharper.Refactorings.RefactoringsMruSettings), "Inline Method refactoring settings")]
    public class InlineMethodSettings
    {
        [JetBrains.Application.Settings.SettingsEntryAttribute(true, "Whether to remove the method declaration after it\'s been inlined into all of its " +
            "usages")]
        public bool RemoveInitialDeclaration;
        [JetBrains.Application.Settings.SettingsEntryAttribute(true, "Whether to inline all usages, or just the current usage (if available)")]
        public bool ReplaceAllUsages;
    }
    public sealed class InlineMethodWindow : JetBrains.UI.CommonControls.SafeUserControl, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage
    {
        public InlineMethodWindow(JetBrains.ReSharper.Refactorings.Inline.InlineMethodWorkflow workflow) { }
        public JetBrains.DataFlow.IProperty<bool> ContinueEnabled { get; }
        public string Description { get; }
        public bool DoNotShow { get; }
        public string Title { get; }
        public JetBrains.UI.CrossFramework.EitherControl View { get; }
        public JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage Commit(JetBrains.Application.Progress.IProgressIndicator pi) { }
        public bool Initialize(JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
        public bool RefreshContents(JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
    }
    public class InlineMethodWorkflow : JetBrains.ReSharper.Refactorings.Workflow.DrivenRefactoringWorkflow
    {
        public InlineMethodWorkflow(JetBrains.ProjectModel.ISolution solution, string actionId) { }
        public JetBrains.ReSharper.Refactorings.Inline.AccessorKinds AccessorKind { get; }
        public override JetBrains.ReSharper.Refactorings.Workflow.RefactoringActionGroup ActionGroup { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Psi.IDeclaredElement Element { get; }
        public override JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage FirstPendingRefactoringPage { get; }
        public bool ForceUseDelegate { get; set; }
        public override string HelpKeyword { get; }
        public bool InvokedOnReference { get; }
        public JetBrains.ReSharper.Psi.PsiLanguageType LanguageType { get; }
        public override bool MightModifyManyDocuments { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Psi.Resolve.IReference Reference { get; }
        public bool RemoveInitialDeclaration { get; }
        public bool ReplaceAllUsages { get; }
        public override string Title { get; }
        public JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage Commit(bool allUsages, bool removeMethod) { }
        public override JetBrains.ReSharper.Refactorings.Workflow.IRefactoringExecuter CreateRefactoring(JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public override bool Initialize(JetBrains.Application.DataContext.IDataContext context) { }
        public override bool IsAvailable(JetBrains.Application.DataContext.IDataContext context) { }
        public override bool PreExecute(JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
        public void SetInlineMethodDataProvider(JetBrains.ReSharper.Refactorings.Inline.IInlineMethodDataProvider value) { }
        public override bool Validate() { }
    }
    public abstract class InlineWorkflowProvider : JetBrains.ReSharper.Feature.Services.ActionsMenu.IWorkflowProvider<JetBrains.ReSharper.Refactorings.Workflow.IRefactoringWorkflow, JetBrains.ReSharper.Refactorings.Workflow.RefactoringActionGroup>, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringWorkflowProvider
    {
        protected static string ActionId { get; }
        public abstract System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Refactorings.Workflow.IRefactoringWorkflow> CreateWorkflow(JetBrains.Application.DataContext.IDataContext dataContext);
    }
    public class LocalContextResolveResultImage
    {
        public JetBrains.ReSharper.Psi.IDeclaredElement DeclaredElement { get; }
        public JetBrains.ReSharper.Psi.Resolve.IReference InitialReference { get; }
        public bool IsValid { get; }
        public JetBrains.ReSharper.Psi.Resolve.ISubstitution Substitution { get; }
        public bool WithError { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Refactorings.Inline.LocalContextResolveResultImage CreateImage(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public static System.Collections.Generic.Dictionary<JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.ReSharper.Refactorings.Inline.LocalContextResolveResultImage> SaveContextReferences(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public static void TryBindContextReferences(System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.ReSharper.Refactorings.Inline.LocalContextResolveResultImage>> references) { }
    }
}
namespace JetBrains.ReSharper.Refactorings.Inline.ArgUtil
{
    
    public abstract class ArgumentFromParameter
    {
        public abstract int First { get; }
        public virtual bool IsArray { get; }
        public virtual bool IsEmpty { get; }
        public virtual bool IsQualifier { get; }
        public abstract int Last { get; }
    }
    public class ArgumentFromParameterArray : JetBrains.ReSharper.Refactorings.Inline.ArgUtil.ArgumentFromParameter
    {
        public ArgumentFromParameterArray(int first, int last) { }
        public override int First { get; }
        public override bool IsArray { get; }
        public override int Last { get; }
    }
    public class ArgumentFromParameterQualifier : JetBrains.ReSharper.Refactorings.Inline.ArgUtil.ArgumentFromParameter
    {
        public override int First { get; }
        public override bool IsQualifier { get; }
        public override int Last { get; }
    }
    public class ArgumentFromParameterSimple : JetBrains.ReSharper.Refactorings.Inline.ArgUtil.ArgumentFromParameter
    {
        public ArgumentFromParameterSimple(int index) { }
        public override int First { get; }
        public override int Last { get; }
    }
    public sealed class EmptyArgumentFromParameter : JetBrains.ReSharper.Refactorings.Inline.ArgUtil.ArgumentFromParameter
    {
        public override int First { get; }
        public override bool IsEmpty { get; }
        public override int Last { get; }
    }
}
namespace JetBrains.ReSharper.Refactorings.Inline.Util
{
    
    public class InlineRefactoringEngine : JetBrains.ReSharper.Refactorings.Inline.ICallSiteContextOwner
    {
        protected readonly System.Collections.Generic.JetHashSet<JetBrains.ReSharper.Psi.Tree.ITreeNode> myCastContexts;
        protected readonly JetBrains.ReSharper.Refactorings.InlineVar.IInlineRefactoring myInlineRefactoring;
        protected System.Collections.Generic.Dictionary<JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.ReSharper.Refactorings.Inline.LocalContextResolveResultImage> myResolveImages;
        public InlineRefactoringEngine(JetBrains.ReSharper.Refactorings.InlineVar.IInlineRefactoring inlineRefactoring) { }
        public JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver Driver { get; }
        public System.Collections.Generic.Dictionary<JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.ReSharper.Refactorings.Inline.LocalContextResolveResultImage> ResolveImages { get; }
        public void AddContext(JetBrains.ReSharper.Psi.Tree.ITreeNode context) { }
        public JetBrains.ReSharper.Refactorings.Inline.InlinedMethodInfo CreateInlinedMethodInfo(JetBrains.ReSharper.Psi.Tree.IExpression expression) { }
        public JetBrains.ReSharper.Refactorings.Inline.InlineHelper GetInlineHelper(JetBrains.ReSharper.Psi.PsiLanguageType language) { }
        public static System.Collections.Generic.Dictionary<JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.ReSharper.Refactorings.Inline.LocalContextResolveResultImage> InitialRemap(System.Collections.Generic.Dictionary<JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.ReSharper.Refactorings.Inline.LocalContextResolveResultImage> images, JetBrains.ReSharper.Psi.ExtensionsAPI.ReferenceIdentitySaver saver) { }
        public void InitReferences([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public void InlineUsages(JetBrains.ReSharper.Refactorings.Inline.InlinedMethodInfo inlinedMethodInfo, System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.Resolve.IReference> references, JetBrains.Application.Progress.IProgressIndicator pi) { }
        public void ProcessReferences(System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.Resolve.IReference> references, JetBrains.ReSharper.Refactorings.Inline.InlinedMethodInfo inlinedMethodInfo, JetBrains.Application.Progress.IProgressIndicator pi) { }
        protected void ProcessReferenceWithContext(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Refactorings.Inline.CallSiteContext context, JetBrains.ReSharper.Refactorings.Inline.InlinedCallInfo info) { }
    }
    public class LocalDeclarationIdentity : JetBrains.ReSharper.Psi.IRecursiveElementProcessor
    {
        public static JetBrains.Util.Key<JetBrains.ReSharper.Refactorings.Inline.Util.LocalDeclarationRename> DeclKey;
        public static JetBrains.Util.Key<JetBrains.ReSharper.Refactorings.Inline.Util.LocalDeclarationRename> RefKey;
        public bool ProcessingIsFinished { get; }
        public static JetBrains.ReSharper.Refactorings.Inline.Util.LocalDeclarationIdentity CreateLocalDeclarationsIdentity(JetBrains.ReSharper.Psi.Tree.ITreeNode rootElement) { }
        public JetBrains.ReSharper.Psi.Tree.ITreeNode Fix(JetBrains.ReSharper.Psi.Tree.ITreeNode element, System.Func<JetBrains.ReSharper.Psi.Tree.ITreeNode, string, JetBrains.ReSharper.Psi.Tree.ITreeNode> renameAction) { }
        public bool InteriorShouldBeProcessed(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public void PrepareNames(JetBrains.ReSharper.Psi.Tree.ITreeNode namingContext) { }
        public void ProcessAfterInterior(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public void ProcessBeforeInterior(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public class Fixer : JetBrains.ReSharper.Psi.IRecursiveElementProcessor
        {
            public Fixer(System.Func<JetBrains.ReSharper.Psi.Tree.ITreeNode, string, JetBrains.ReSharper.Psi.Tree.ITreeNode> renameAction) { }
            public bool ProcessingIsFinished { get; }
            public bool InteriorShouldBeProcessed(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
            public void ProcessAfterInterior(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
            public void ProcessBeforeInterior(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
            public JetBrains.ReSharper.Psi.Tree.ITreeNode Run(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        }
    }
    public class LocalDeclarationRename
    {
        public LocalDeclarationRename(string name, JetBrains.ReSharper.Psi.Naming.Impl.NameRoot nameRoot, JetBrains.ReSharper.Psi.Naming.Settings.NamingRule namingRule) { }
        public string Name { get; }
        public JetBrains.ReSharper.Psi.Naming.Impl.NameRoot NameRoot { get; set; }
        public JetBrains.ReSharper.Psi.Naming.Settings.NamingRule NamingRule { get; set; }
        public void Rename(string name) { }
        public void UndoChanges() { }
    }
    public class static RedundantCastUtil
    {
        public static readonly JetBrains.Util.Key<JetBrains.ReSharper.Refactorings.Inline.ForcedCast> CastKey;
        public static readonly JetBrains.Util.Key<JetBrains.ReSharper.Refactorings.Inline.CheckTypeKey> CheckTypeKey;
        public static void PostProcessMarkedElements(JetBrains.Application.Progress.IProgressIndicator pi, System.Collections.Generic.JetHashSet<JetBrains.ReSharper.Psi.Tree.ITreeNode> castContexts, JetBrains.ReSharper.Refactorings.Inline.ICallSiteContextOwner owner) { }
    }
    public class static TempVariableUtil
    {
        public static JetBrains.ReSharper.Psi.Resolve.IReference InsertTempVariables(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Refactorings.Inline.InlinedCallInfo inlinedCallInfo, JetBrains.ReSharper.Refactorings.Inline.CallSiteContext context, JetBrains.ReSharper.Refactorings.Inline.ICallSiteContextOwner contextOwner) { }
        public static JetBrains.ReSharper.Psi.Resolve.IReference InsertTempVariablesMulti(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Refactorings.Inline.InlinedCallInfo inlinedCallInfo, JetBrains.ReSharper.Refactorings.Inline.CallSiteContext context, JetBrains.ReSharper.Refactorings.Inline.ICallSiteContextOwner contextOwner) { }
    }
}
namespace JetBrains.ReSharper.Refactorings.InlineClass
{
    
    public interface IInlineClassRefactoringExec : JetBrains.ReSharper.Refactorings.IRefactoringExec
    {
        void CutAndPaste(JetBrains.Application.Progress.IProgressIndicator subPi);
        void Rebind(JetBrains.Application.Progress.IProgressIndicator subPi);
    }
    public class InlineClassAnalyzer
    {
        public JetBrains.ReSharper.Psi.PsiLanguageType Language;
        public readonly JetBrains.Util.OneToSetMap<JetBrains.ReSharper.Refactorings.InlineClass.MemberInfo, JetBrains.ReSharper.Psi.Resolve.IReference> SourceReferences;
        public readonly System.Collections.Generic.List<JetBrains.ReSharper.Psi.Resolve.IReference> TargetReferences;
        public InlineClassAnalyzer(JetBrains.ReSharper.Refactorings.InlineClass.InlineClassWorkflow inlineClassWorkflow, JetBrains.ReSharper.Psi.ITypeOwner element, JetBrains.ReSharper.Psi.ITypeElement owner) { }
        public System.Collections.Generic.List<JetBrains.ReSharper.Psi.Resolve.IReference> FieldReferences { get; set; }
        public System.Collections.Generic.List<JetBrains.ReSharper.Refactorings.InlineClass.MemberInfo> Members { get; set; }
        public JetBrains.ReSharper.Refactorings.InlineClass.TypesInfo TypesInfo { get; set; }
        protected JetBrains.ReSharper.Refactorings.InlineClass.InlineClassWorkflow Workflow { get; set; }
        protected virtual void AddMemberInfo(JetBrains.ReSharper.Psi.ITypeMember member) { }
        public virtual void Analyze() { }
        public bool CheckNameUniqueness() { }
        protected virtual void FillTargetTypeElements() { }
        public void GetReferencesToRebind(JetBrains.Application.Progress.IProgressIndicator pi) { }
        protected virtual void InitializeMembers(JetBrains.ReSharper.Psi.ITypeOwner element, JetBrains.ReSharper.Psi.ITypeElement owner) { }
    }
    public class InlineClassHelper : JetBrains.ReSharper.Refactorings.IWorkflowExec, JetBrains.ReSharper.Refactorings.Util.NewTypeImages.IResolveImagesLanguageSupport
    {
        public virtual bool IsLanguageSupported { get; }
        public virtual JetBrains.ReSharper.Refactorings.InlineClass.InlineClassAnalyzer GetAnalyzer(JetBrains.ReSharper.Refactorings.InlineClass.InlineClassWorkflow inlineClassWorkflow, JetBrains.ReSharper.Psi.ITypeOwner element, JetBrains.ReSharper.Psi.ITypeElement owner) { }
        public bool IsExternallyVisibleSymbol(JetBrains.ReSharper.Psi.IDeclaredElement element) { }
        public bool IsFromExtendsList(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public bool IsReferenceName(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public void RemoveUnusedUsing(JetBrains.ReSharper.Psi.Tree.IFile file, System.Collections.Generic.JetHashSet<JetBrains.ReSharper.Psi.Tree.ITreeNode> usings) { }
        public void SaveUnusedUsings(JetBrains.ReSharper.Psi.Tree.IFile file, JetBrains.ReSharper.Refactorings.Move.Common.UnusedUsingSaver saver) { }
    }
    public class InlineClassRefactoring : JetBrains.ReSharper.Refactorings.Workflow.IRefactoringExecuter
    {
        public InlineClassRefactoring(JetBrains.ReSharper.Refactorings.InlineClass.InlineClassWorkflow inlineClassWorkflow, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        protected JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver Driver { get; set; }
        public JetBrains.ReSharper.Refactorings.Util.NewTypeImages.ResolveImagesRepository Repository { get; }
        protected JetBrains.ReSharper.Refactorings.InlineClass.InlineClassWorkflow Workflow { get; set; }
        public bool Execute(JetBrains.Application.Progress.IProgressIndicator pi) { }
    }
    public class InlineClassWorkflow : JetBrains.ReSharper.Refactorings.WorkflowNew.DrivenRefactoringWorkflow2<JetBrains.ReSharper.Refactorings.InlineClass.InlineClassHelper>
    {
        public InlineClassWorkflow(JetBrains.ProjectModel.ISolution solution, string actionId) { }
        public override JetBrains.ReSharper.Refactorings.Workflow.RefactoringActionGroup ActionGroup { get; }
        public JetBrains.ReSharper.Refactorings.InlineClass.InlineClassAnalyzer Analyzer { get; set; }
        public JetBrains.DocumentModel.IDocument DocumentToSave { get; set; }
        public JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver Driver { get; }
        public override JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage FirstPendingRefactoringPage { get; }
        public override string HelpKeyword { get; }
        public override bool MightModifyManyDocuments { get; }
        public JetBrains.ReSharper.Psi.Transactions.IPsiTransactions PsiTransactions { get; }
        public JetBrains.ReSharper.Psi.IPsiSourceFile SourceFile { get; set; }
        public override string Title { get; }
        public System.Collections.Generic.Dictionary<JetBrains.ReSharper.Psi.ITypeParameter, JetBrains.ReSharper.Psi.ITypeParameter> TypeParameters { get; set; }
        protected override JetBrains.ReSharper.Refactorings.InlineClass.InlineClassHelper CreateHelper(JetBrains.ReSharper.Refactorings.IRefactoringLanguageService service) { }
        public override JetBrains.ReSharper.Refactorings.Workflow.IRefactoringExecuter CreateRefactoring(JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        protected override JetBrains.ReSharper.Refactorings.InlineClass.InlineClassHelper CreateUnsupportedHelper() { }
        public override bool Initialize(JetBrains.Application.DataContext.IDataContext context) { }
        public override bool IsAvailable(JetBrains.Application.DataContext.IDataContext context) { }
        protected bool IsAvailableEx(JetBrains.Application.DataContext.IDataContext context, out JetBrains.ReSharper.Psi.ITypeOwner typeOwner, out JetBrains.ReSharper.Psi.ITypeElement ownerType) { }
        public override bool PostExecute(JetBrains.Application.Progress.IProgressIndicator pi) { }
        public override bool PreExecute(JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
        public void RemoveFile() { }
        public void SetData() { }
    }
    public class MemberInfo
    {
        protected JetBrains.ReSharper.Psi.Pointers.IDeclaredElementPointer<JetBrains.ReSharper.Psi.IDeclaredElement> Pointer;
        protected JetBrains.ReSharper.Psi.Pointers.IDeclaredElementPointer<JetBrains.ReSharper.Psi.IDeclaredElement> RemovePointer;
        public MemberInfo(JetBrains.ReSharper.Psi.ITypeMember member) { }
        public JetBrains.ReSharper.Psi.IDeclaredElement DeclaredElement { get; set; }
        public bool HasDelegation { get; }
        public JetBrains.ReSharper.Psi.IDeclaredElement MemberToRemove { get; set; }
        public bool Remove { get; set; }
    }
    public class TypesInfo
    {
        public TypesInfo(JetBrains.ReSharper.Psi.ITypeOwner element, JetBrains.ReSharper.Psi.ITypeElement owner) { }
        public JetBrains.ReSharper.Psi.Resolve.ISubstitution BackSubstitution { get; set; }
        public JetBrains.ReSharper.Psi.IProperty SourceProperty { get; set; }
        public System.Collections.Generic.Dictionary<JetBrains.ReSharper.Psi.ITypeParameter, JetBrains.ReSharper.Psi.ITypeParameter> SourceToTargetTypes { get; set; }
        public JetBrains.ReSharper.Psi.ITypeElement SourceTypeElement { get; set; }
        public JetBrains.ReSharper.Psi.ITypeOwner SourceTypeMember { get; set; }
        public JetBrains.ReSharper.Psi.Resolve.ISubstitution Substitution { get; set; }
        public JetBrains.ReSharper.Psi.IProperty TargetProperty { get; set; }
        public JetBrains.ReSharper.Psi.ITypeElement TargetTypeElement { get; set; }
        public JetBrains.ReSharper.Psi.ITypeOwner TargetTypeMember { get; set; }
        protected static System.Collections.Generic.JetHashSet<JetBrains.ReSharper.Psi.ITypeParameter> CollectParameters(System.Collections.Generic.JetHashSet<JetBrains.ReSharper.Psi.ITypeParameter> typeParameters, JetBrains.ReSharper.Psi.ITypeElement typeElement) { }
        public JetBrains.ReSharper.Psi.Tree.ITypeDeclaration GetSourceTypeDeclaration() { }
        public void GetSubstitution(JetBrains.ReSharper.Psi.ITypeOwner member, JetBrains.ReSharper.Psi.ITypeElement typeElement, ref JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution) { }
        public JetBrains.ReSharper.Psi.Tree.ITypeDeclaration GetTargetTypeDeclaration() { }
        protected static System.Collections.Generic.List<JetBrains.ReSharper.Psi.ITypeParameter> GetUsedTypeParameters(JetBrains.ReSharper.Psi.ITypeElement typeElement) { }
    }
}
namespace JetBrains.ReSharper.Refactorings.InlineField
{
    
    public abstract class InlineFieldBase : JetBrains.ReSharper.Refactorings.Common.RefactoringExecBase<JetBrains.ReSharper.Refactorings.InlineField.InlineFieldWorkflow, JetBrains.ReSharper.Refactorings.InlineField.InlineFieldRefactoring>
    {
        protected InlineFieldBase(JetBrains.ReSharper.Refactorings.InlineField.InlineFieldWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public abstract JetBrains.ReSharper.Refactorings.Inline.InlineHelper InlineHelper { get; }
        public abstract bool CanInlineReference(JetBrains.ReSharper.Psi.Resolve.IReference reference);
        public abstract bool GetCanUseRefOut(JetBrains.ReSharper.Psi.Tree.IExpression expression);
        [JetBrains.Annotations.CanBeNullAttribute()]
        public virtual JetBrains.ReSharper.Psi.Tree.ITreeNode GetContainingDeclarationBlock(JetBrains.ReSharper.Psi.Tree.IExpression expression) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public abstract JetBrains.ReSharper.Psi.Tree.IExpression GetInitializerExpression(JetBrains.ReSharper.Psi.Resolve.IReference reference);
        [JetBrains.Annotations.CanBeNullAttribute()]
        public abstract JetBrains.ReSharper.Psi.Tree.IExpression GetInitializerExpression(JetBrains.ReSharper.Psi.IField field);
        protected static System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Resolve.IReference> GetReachableReferences(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Resolve.IReference> references, JetBrains.ReSharper.Psi.ControlFlow.IControlFlowGraf graf, JetBrains.ReSharper.Psi.ControlFlow.Impl.ControlFlowGrafInspector<JetBrains.ReSharper.Refactorings.InlineField.InlineFieldInspectionContext> inspector) { }
        public virtual bool HasSideEffects(JetBrains.ReSharper.Psi.Tree.IExpression expression) { }
        public virtual bool Ignore(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public virtual string InsertTempVariable(JetBrains.ReSharper.Psi.Tree.ITreeNode tag, string name, JetBrains.ReSharper.Psi.Tree.IExpression expression) { }
        public abstract void ProcessReferenceWithContext(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Refactorings.Inline.CallSiteContext context, JetBrains.ReSharper.Refactorings.Inline.InlinedCallInfo info);
        public abstract void RemoveAssgnment(JetBrains.ReSharper.Psi.Resolve.IReference reference);
        public abstract void RemoveField(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration);
        public virtual void ReplaceExpression(JetBrains.ReSharper.Psi.Resolve.IReference reference, string localName) { }
        protected bool ReportArgumentConflict(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        protected bool ReportWriteUsageConflict(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.Tree.ExpressionAccessType accessType) { }
        public abstract bool ThisIsUsed([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.IExpression expression);
    }
    public class InlineFieldInspectionContext : JetBrains.ReSharper.Refactorings.InlineVar.RDAnalysis.IRDInspectorOfVariableContext
    {
        public bool InlineThis { get; }
        public JetBrains.ReSharper.Refactorings.InlineField.InlineFieldInspectionContext Clone() { }
        public bool Equals(JetBrains.ReSharper.Refactorings.InlineField.InlineFieldInspectionContext obj) { }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
        public void MergeWith(JetBrains.ReSharper.Refactorings.InlineField.InlineFieldInspectionContext context) { }
        public void Read() { }
        public void TrueAssigned() { }
        public void Write() { }
    }
    public class InlineFieldRefactoring : JetBrains.ReSharper.Refactorings.Common.DrivenRefactoring<JetBrains.ReSharper.Refactorings.InlineField.InlineFieldWorkflow, JetBrains.ReSharper.Refactorings.InlineField.InlineFieldBase>, JetBrains.ReSharper.Refactorings.InlineVar.IInlineRefactoring
    {
        public InlineFieldRefactoring(JetBrains.ReSharper.Refactorings.InlineField.InlineFieldWorkflow workFlow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public bool CanHaveSideEffects { get; set; }
        public bool CanUseForRefOut { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ReSharper.Psi.Tree.IExpression Expression { get; }
        public JetBrains.ReSharper.Psi.IField Field { get; }
        public JetBrains.ReSharper.Psi.PsiLanguageType InvocationLanguage { get; }
        public JetBrains.ReSharper.Psi.Resolve.IReference Reference { get; }
        public JetBrains.ReSharper.Refactorings.Inline.InlinedCallInfo CreateInlineCallInfo(JetBrains.ReSharper.Refactorings.Inline.InlinedMethodInfo info, JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public JetBrains.ReSharper.Refactorings.Inline.InlinedMethodInfo CreateInlinedMethodInfo() { }
        protected override JetBrains.ReSharper.Refactorings.InlineField.InlineFieldBase CreateRefactoringInternal(JetBrains.ReSharper.Refactorings.InternalRefactoringLanguageService service) { }
        protected override JetBrains.ReSharper.Refactorings.InlineField.InlineFieldBase CreateUnsupportedRefactoring() { }
        public override bool Execute(JetBrains.Application.Progress.IProgressIndicator pi) { }
        public JetBrains.ReSharper.Refactorings.Inline.InlineHelper GetInlineHelper(JetBrains.ReSharper.Psi.PsiLanguageType language) { }
        public void ProcessReferenceWithContext(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Refactorings.Inline.CallSiteContext context, JetBrains.ReSharper.Refactorings.Inline.InlinedCallInfo info) { }
        public void ReportLanguageConflict(JetBrains.ReSharper.Psi.PsiLanguageType language, JetBrains.ReSharper.Psi.PsiLanguageType invocationLanguage, JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
    }
    public class InlineFieldWorkflow : JetBrains.ReSharper.Refactorings.Workflow.DrivenRefactoringWorkflow
    {
        public InlineFieldWorkflow(JetBrains.ProjectModel.ISolution solution, string actionId) { }
        public override JetBrains.ReSharper.Refactorings.Workflow.RefactoringActionGroup ActionGroup { get; }
        public JetBrains.ReSharper.Psi.Pointers.IDeclaredElementPointer<JetBrains.ReSharper.Psi.IField> FieldPointer { get; }
        public override JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage FirstPendingRefactoringPage { get; }
        public override string HelpKeyword { get; }
        public JetBrains.ReSharper.Psi.PsiLanguageType LanguageType { get; }
        public override bool MightModifyManyDocuments { get; }
        public JetBrains.ReSharper.Psi.IReferencePointer ReferencePointer { get; }
        public override string Title { get; }
        public override JetBrains.ReSharper.Refactorings.Workflow.IRefactoringExecuter CreateRefactoring(JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public override bool Initialize(JetBrains.Application.DataContext.IDataContext context) { }
        public override bool IsAvailable(JetBrains.Application.DataContext.IDataContext context) { }
        public override bool PreExecute(JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
    }
}
namespace JetBrains.ReSharper.Refactorings.InlineParameter.Data
{
    
    public class ArgumentExpressionSubstitution : JetBrains.ReSharper.Refactorings.InlineParameter.Data.ExpressionSubstitution
    {
        public ArgumentExpressionSubstitution(JetBrains.ReSharper.Psi.Tree.IExpression expression, JetBrains.ReSharper.Refactorings.InlineParameter.Data.InlinedExpressionInfo inlinedExpressionInfo) { }
        public ArgumentExpressionSubstitution(JetBrains.ReSharper.Psi.DefaultValue defaultValue, JetBrains.ReSharper.Refactorings.InlineParameter.Data.DefaultValueInfoOfInlineParameter inlinedExpressionInfo) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public override JetBrains.ReSharper.Psi.ITreeNodePointer<JetBrains.ReSharper.Psi.Tree.IExpression> ExpressionPointer { get; }
        public JetBrains.ReSharper.Refactorings.InlineParameter.Data.InlinedExpressionInfo InlinedExpressionInfo { get; }
        public override bool IsIncluded { get; }
    }
    public class ArgumentInfoOfInlineParameter : JetBrains.ReSharper.Refactorings.InlineParameter.Data.InlinedExpressionInfo
    {
        public ArgumentInfoOfInlineParameter(JetBrains.ReSharper.Psi.Tree.IArgument argument, JetBrains.ReSharper.Refactorings.InlineParameter.Data.ParametersOwnerUsage usage, JetBrains.ReSharper.Refactorings.InlineParameter.Data.ParameterInfoOfInlineParameter info) { }
        public override JetBrains.ProjectModel.ProjectFileType LanguageType { get; }
        public override bool Selected { get; set; }
        public JetBrains.ReSharper.Refactorings.InlineParameter.Data.ParametersOwnerUsage Usage { get; }
        public override string GetText() { }
    }
    public class DefaultValueInfoOfInlineParameter : JetBrains.ReSharper.Refactorings.InlineParameter.Data.InlinedExpressionInfo
    {
        public DefaultValueInfoOfInlineParameter(JetBrains.ReSharper.Psi.IParameter parameter, JetBrains.ReSharper.Refactorings.InlineParameter.Data.ParameterInfoOfInlineParameter parameterInfoOfInlineParameter) { }
        public override string AdditionalText { get; }
        public override JetBrains.ProjectModel.ProjectFileType LanguageType { get; }
        public override string GetText() { }
    }
    public abstract class ExpressionSubstitution
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        public abstract JetBrains.ReSharper.Psi.ITreeNodePointer<JetBrains.ReSharper.Psi.Tree.IExpression> ExpressionPointer { get; }
        public abstract bool IsIncluded { get; }
    }
    public class InlinedExpressionInfo
    {
        protected JetBrains.ReSharper.Psi.ITreeNodePointer<JetBrains.ReSharper.Psi.Tree.ITreeNode> myArgumentPointer;
        public InlinedExpressionInfo(JetBrains.ReSharper.Refactorings.InlineParameter.Data.ParameterInfoOfInlineParameter parameterInfo) { }
        public virtual string AdditionalText { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ReSharper.Psi.ITreeNodePointer<JetBrains.ReSharper.Psi.Tree.ITreeNode> ArgumentPointer { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Refactorings.InlineParameter.Data.ArgumentExpressionSubstitution ExpressionSubstitution { get; set; }
        public virtual JetBrains.ProjectModel.ProjectFileType LanguageType { get; }
        public JetBrains.ReSharper.Refactorings.InlineParameter.Data.ParameterInfoOfInlineParameter ParameterInfo { get; }
        public virtual bool Selected { get; set; }
        public System.Collections.Generic.List<JetBrains.ReSharper.Refactorings.InlineParameter.Data.SuggestedParameter> Suggestions { get; set; }
        public virtual string GetText() { }
    }
    public class InlineParameterDataModel
    {
        public InlineParameterDataModel() { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Refactorings.InlineParameter.Data.InlinedExpressionInfo InlinedExpressionInfoOfThisParameter { get; }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Refactorings.InlineParameter.Data.ParameterInfoOfInlineParameter> ParameterInfos { get; }
        public JetBrains.ReSharper.Psi.IParametersOwner ParametersOwner { get; }
        public System.Collections.Generic.List<JetBrains.ReSharper.Refactorings.InlineParameter.Data.SuggestedParameter> Suggestions { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Refactorings.InlineParameter.Data.SuggestedParameter ThisSuggestion { get; }
        public JetBrains.ReSharper.Refactorings.InlineParameter.InlineParameterWorkflow Workflow { get; }
        public static JetBrains.ReSharper.Refactorings.InlineParameter.Data.InlineParameterDataModel CreateDataModel(System.Collections.Generic.List<JetBrains.ReSharper.Refactorings.InlineParameter.Data.ParametersOwnerUsage> calls, JetBrains.ReSharper.Refactorings.InlineParameter.InlineParameterWorkflow workflow, JetBrains.ReSharper.Psi.IParameter initialParameter) { }
        public JetBrains.TreeModels.TreeModel CreateParametersModel() { }
        public JetBrains.TreeModels.TreeModel CreateSuggestionsModel() { }
        public bool InitSuggestions() { }
        public void LoadUsages(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Refactorings.InlineParameter.Data.ParametersOwnerUsage> calls) { }
        public void UpdateSuggestions() { }
    }
    public class InlineParameterOverride
    {
        public InlineParameterOverride(JetBrains.ReSharper.Psi.ITypeMember typeMember) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ReSharper.Psi.Pointers.IDeclaredElementPointer<JetBrains.ReSharper.Psi.ITypeMember> TypeMemberPointer { get; }
    }
    public class OverrideDataModel
    {
        public OverrideDataModel([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IParametersOwner parameterOwnerPointer, bool isDefault) { }
        public System.Collections.Generic.List<JetBrains.ReSharper.Refactorings.InlineParameter.Data.ExpressionSubstitution> ExpressionsForSubstitution { get; }
        public bool IsDefault { get; set; }
        public JetBrains.ReSharper.Psi.IParametersOwner ParameterOwner { get; }
    }
    public class ParameterInfoOfInlineParameter
    {
        public ParameterInfoOfInlineParameter(System.Collections.Generic.IList<JetBrains.ReSharper.Psi.IParameter> parameters, bool included, int index) { }
        public System.Collections.Generic.ICollection<JetBrains.ReSharper.Refactorings.InlineParameter.Data.ArgumentInfoOfInlineParameter> ArgumentInfos { get; }
        public bool CanBeInlined { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Refactorings.InlineParameter.Data.DefaultValueInfoOfInlineParameter> DefaultValueInfos { get; }
        public JetBrains.UI.RichText.RichText FormattedParameter { get; }
        public bool HasUsages { get; }
        public JetBrains.UI.Icons.IconId Icon { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Refactorings.InlineParameter.Data.ArgumentInfoOfInlineParameter InlinedExpressionInfo { get; }
        public bool IsIncluded { get; set; }
        public int ParameterIndex { get; }
        public string ParameterName { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IParameter> Parameters { get; }
        public string ParameterType { get; }
        public void FindUsages() { }
    }
    public class ParameterOwnerUsageUpdater
    {
        public ParameterOwnerUsageUpdater(JetBrains.ReSharper.Psi.Tree.IArgumentsOwner owner, JetBrains.ReSharper.Psi.Tree.IArgumentsOwner copy, JetBrains.ReSharper.Psi.Tree.IArgument foundArgument, JetBrains.ReSharper.Refactorings.InlineParameter.Data.ParametersOwnerUsage parametersOwnerUsage, JetBrains.ReSharper.Psi.Tree.IExpression value, JetBrains.ReSharper.Psi.Tree.IExpression qualifier, bool hasThisQualifier) { }
        public JetBrains.ReSharper.Psi.Tree.IArgumentsOwner Copy { get; }
        public JetBrains.ReSharper.Psi.Tree.IArgument FoundArgument { get; }
        public JetBrains.ReSharper.Psi.Tree.IArgumentsOwner Owner { get; }
        public JetBrains.ReSharper.Refactorings.InlineParameter.Data.ParametersOwnerUsage ParametersOwnerUsage { get; }
        public void GoParent() { }
        public void Match(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public void MatchExistingParameter(JetBrains.ReSharper.Refactorings.InlineParameter.Data.ParameterInfoOfInlineParameter parameterInfo) { }
        public void MatchQualifierSuggestion(JetBrains.ReSharper.Refactorings.InlineParameter.Data.QualifierExpressionSubstitution qualifierSubstitution) { }
        public void MatchSuggestion(JetBrains.ReSharper.Refactorings.InlineParameter.Data.SuggestedParameter suggestion) { }
        public void MatchThisSuggestion(JetBrains.ReSharper.Refactorings.InlineParameter.Data.SuggestedParameter suggestedParameter, System.Func<JetBrains.ReSharper.Psi.Tree.IExpression, System.Action<JetBrains.ReSharper.Psi.Tree.IExpression>, bool> matchQualifier) { }
        public void MoveToChild() { }
        public void MoveToNext() { }
    }
    public class ParametersOwnerUsage
    {
        public ParametersOwnerUsage([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.IArgumentsOwner argumentsOwner, bool isIncluded, JetBrains.ReSharper.Refactorings.InlineParameter.InlineParameterWorkflow workflow) { }
        public JetBrains.ReSharper.Psi.Tree.IArgumentsOwner ArgumentsOwner { get; }
        public JetBrains.ReSharper.Psi.Tree.IArgumentsOwner ArgumentsOwnerCopy { get; }
        public bool IsArgumentOwner { get; }
        public bool IsStillMatched { get; set; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Refactorings.InlineParameter.Data.OverrideDataModel Override { get; set; }
        public bool Selected { get; set; }
        public System.Collections.Generic.Dictionary<JetBrains.ReSharper.Refactorings.InlineParameter.Data.SuggestedParameter, JetBrains.ReSharper.Psi.Tree.IExpression> SuggestionToExpression { get; }
        public JetBrains.ReSharper.Psi.Tree.IArgument GetArgumentOfParameter(int index) { }
        public JetBrains.ReSharper.Psi.Tree.IArgument GetArgumentOfParameter(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IParameter> parameters) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Refactorings.InlineParameter.Data.ParameterOwnerUsageUpdater GetUpdater(JetBrains.ReSharper.Refactorings.InlineParameter.Data.ParameterInfoOfInlineParameter parameterInfo) { }
        public void Mismatch() { }
    }
    public class QualifierExpressionSubstitution : JetBrains.ReSharper.Refactorings.InlineParameter.Data.ExpressionSubstitution
    {
        public QualifierExpressionSubstitution([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.IExpression qualifier) { }
        public override JetBrains.ReSharper.Psi.ITreeNodePointer<JetBrains.ReSharper.Psi.Tree.IExpression> ExpressionPointer { get; }
        public override bool IsIncluded { get; }
    }
    public class SuggestedParameter
    {
        public JetBrains.UI.RichText.RichText FormattedParameter;
        public SuggestedParameter(JetBrains.ReSharper.Psi.Tree.IExpression suggestedExpression, bool isIncluded) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public string CreatedParameterName { get; set; }
        public bool IsIncluded { get; set; }
        public JetBrains.ReSharper.Psi.Tree.IExpression SuggestedExpression { get; }
    }
}
namespace JetBrains.ReSharper.Refactorings.InlineParameter.Impl
{
    
    public class InlineParameterEngine : JetBrains.ReSharper.Refactorings.Inline.Util.InlineRefactoringEngine
    {
        public InlineParameterEngine(JetBrains.ReSharper.Refactorings.InlineVar.IInlineRefactoring inlineRefactoring) { }
        public JetBrains.ReSharper.Refactorings.Inline.InlinedMethodInfo CreateInlinedMethodInfo([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode body, JetBrains.ReSharper.Psi.IParametersOwner owner, JetBrains.ReSharper.Refactorings.InlineParameter.InlineParameterRefactoring refactoring) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public void TransformBody(JetBrains.ReSharper.Refactorings.Inline.InlinedMethodInfo inlinedMethodInfo, JetBrains.Application.Progress.SubProgressIndicator pi, JetBrains.ReSharper.Psi.Tree.ITreeNode context, JetBrains.ReSharper.Refactorings.InlineParameter.InlineParameterRefactoring refactoring, JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.IParametersOwner owner, JetBrains.ReSharper.Psi.Tree.ITreeNode body) { }
    }
    public class InlineParameterHierarchyConflictTextProvider : JetBrains.ReSharper.Refactorings.Conflicts.HierarchyConflictTextProviderBase
    {
        public override string QuasiImplements() { }
        public override string WillAlsoImplement() { }
        public override string WillAlsoOverride() { }
    }
    public class ParameterPresenter : JetBrains.ReSharper.Features.Shared.TreePsiBrowser.TreeModelBrowserPresenter
    {
        protected override void PresentObject(object value, JetBrains.CommonControls.IPresentableItem item, JetBrains.TreeModels.TreeModelNode modelNode, JetBrains.UI.TreeView.PresentationState state) { }
    }
    public class SubExpressionSearcher
    {
        public readonly JetBrains.Util.Key<string> Key;
        public SubExpressionSearcher([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode context, JetBrains.ReSharper.Psi.Tree.IExpression expression, JetBrains.ReSharper.Refactorings.InlineParameter.Data.InlineParameterDataModel model, JetBrains.ReSharper.Psi.Tree.IExpression qualifier, bool hasThisQualifier) { }
        public bool HasUnresolvedThis { get; }
        public System.Collections.Generic.List<JetBrains.ReSharper.Psi.Tree.IExpression> UnresolvedExpressions { get; }
        public void Process() { }
    }
    public class SubExpressionsReplacer
    {
        public SubExpressionsReplacer(JetBrains.ReSharper.Refactorings.InlineParameter.Data.InlineParameterDataModel model, JetBrains.ReSharper.Refactorings.InlineParameter.InlineParameterRefactoring refactoring) { }
        public T ReplaceSubexpressions<T>(T element, JetBrains.ReSharper.Refactorings.InlineParameter.Data.OverrideDataModel overrideModel, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Refactorings.InlineParameter.Data.ParameterOwnerUsageUpdater> updaters)
            where T : JetBrains.ReSharper.Psi.Tree.ITreeNode { }
    }
    public class SuggestionPresenter : JetBrains.ReSharper.Features.Shared.TreePsiBrowser.TreeModelBrowserPresenter
    {
        protected override void PresentObject(object value, JetBrains.CommonControls.IPresentableItem item, JetBrains.TreeModels.TreeModelNode modelNode, JetBrains.UI.TreeView.PresentationState state) { }
    }
    public class UsagePresenter : JetBrains.ReSharper.Features.Shared.TreePsiBrowser.TreeModelBrowserPresenter
    {
        protected override void PresentObject(object value, JetBrains.CommonControls.IPresentableItem item, JetBrains.TreeModels.TreeModelNode modelNode, JetBrains.UI.TreeView.PresentationState state) { }
    }
}
namespace JetBrains.ReSharper.Refactorings.InlineParameter
{
    
    public abstract class InlineParameterBase : JetBrains.ReSharper.Refactorings.Common.RefactoringExecBase<JetBrains.ReSharper.Refactorings.InlineParameter.InlineParameterWorkflow, JetBrains.ReSharper.Refactorings.InlineParameter.InlineParameterRefactoring>
    {
        protected InlineParameterBase(JetBrains.ReSharper.Refactorings.InlineParameter.InlineParameterWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public abstract JetBrains.ReSharper.Refactorings.Inline.InlineHelper InlineHelper { get; }
        public virtual void AddArgument(JetBrains.ReSharper.Psi.Tree.IArgumentsOwner owner, JetBrains.ReSharper.Psi.Tree.IArgument copy) { }
        public virtual void AddArgumentFromExpression([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.IArgumentsOwner owner, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.IExpression expression) { }
        public virtual void AddArgumentFromParameter(JetBrains.ReSharper.Psi.Tree.IArgumentsOwner argumentsOwner, JetBrains.ReSharper.Psi.IParameter parameter, JetBrains.ReSharper.Psi.ParameterKind kind) { }
        public virtual JetBrains.ReSharper.Psi.Tree.IParametersOwnerDeclaration AddDeclarationToFile(JetBrains.ReSharper.Psi.Tree.IParametersOwnerDeclaration newParametersOwnerDeclaration, JetBrains.ReSharper.Psi.IParametersOwner parametersOwner) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public virtual JetBrains.ReSharper.Psi.IParameter AddParameter([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.IDeclaration newParametersOwnerDeclaration, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IParameter parameter) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public virtual JetBrains.ReSharper.Psi.Tree.IArgument CreateArgument(JetBrains.ReSharper.Psi.Tree.IExpression expression) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public virtual JetBrains.ReSharper.Psi.Tree.IArgumentsOwner CreateCallToConstructor(JetBrains.ReSharper.Psi.IConstructor constructor) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public virtual JetBrains.ReSharper.Psi.Tree.IArgumentsOwner CreateCallToMethod([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IMethod method) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public virtual JetBrains.ReSharper.Psi.Tree.IParametersOwnerDeclaration CreateNewDeclaration([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IParametersOwner owner) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public virtual JetBrains.ReSharper.Psi.Tree.IParameterDeclaration GetParameterForSuggestedExpression(JetBrains.ReSharper.Psi.Tree.IDeclaration newParametersOwnerDeclaration, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.IExpression expression) { }
        public virtual bool HasWriteUsages(JetBrains.ReSharper.Psi.IParameter parameter) { }
        public bool IsUsedOnce(JetBrains.ReSharper.Psi.IParameter parameter) { }
        public virtual void RemoveArguments(JetBrains.ReSharper.Psi.Tree.IArgumentsOwner argumentsOwner, System.Collections.Generic.List<JetBrains.ReSharper.Psi.Tree.IArgument> arguments) { }
        public virtual void ReplaceArguments(JetBrains.ReSharper.Psi.Tree.IArgumentsOwner owner, System.Collections.Generic.List<JetBrains.ReSharper.Psi.Tree.IArgument> arguments) { }
        public virtual void ReplaceBody(JetBrains.ReSharper.Refactorings.Inline.CallSiteContext context, JetBrains.ReSharper.Refactorings.Inline.InlinedCallInfo info, JetBrains.ReSharper.Psi.IParametersOwner owner, JetBrains.ReSharper.Psi.Tree.ITreeNode body, JetBrains.ReSharper.Refactorings.InlineParameter.Impl.InlineParameterEngine engine) { }
        public virtual void ReplaceDeclarations(JetBrains.ReSharper.Psi.IParametersOwner parametersOwner) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public virtual JetBrains.ReSharper.Psi.Tree.IExpression ReplaceExpression<T>(T expression, string name)
            where T : JetBrains.ReSharper.Psi.Tree.IExpression { }
        public virtual JetBrains.ReSharper.Psi.Tree.IExpression ReplaceWithThis(JetBrains.ReSharper.Psi.Tree.IExpression expression) { }
    }
    public abstract class InlineParameterDataProviderBase
    {
        public abstract void CheckParameters(JetBrains.ReSharper.Refactorings.InlineParameter.Data.InlineParameterDataModel model);
    }
    public abstract class InlineParameterHelper : JetBrains.ReSharper.Refactorings.IWorkflowExec
    {
        public abstract bool IsLanguageSupported { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public virtual JetBrains.ReSharper.Psi.Tree.IArgumentsOwner CopyArgumentsOwner(JetBrains.ReSharper.Psi.Tree.IArgumentsOwner owner) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public virtual JetBrains.ReSharper.Psi.Tree.IExpression CreateThisExpression(JetBrains.ReSharper.Psi.Modules.IPsiModule project) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public virtual JetBrains.ReSharper.Psi.Tree.IArgumentsOwner GetArgumentsOwner(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public virtual JetBrains.ReSharper.Psi.Tree.IExpression GetArgumentValue(JetBrains.ReSharper.Psi.Tree.IArgument argument) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public virtual JetBrains.ReSharper.Psi.ITypeMember GetCalledMember([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.IArgumentsOwner owner) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public virtual JetBrains.ReSharper.Psi.Tree.ITreeNode GetContextOfParameterOwner(JetBrains.ReSharper.Psi.IParametersOwner owner) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public virtual JetBrains.ReSharper.Psi.Tree.IExpression GetInvocation([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public virtual JetBrains.ReSharper.Psi.IParameter GetParameterFromArgument(JetBrains.ReSharper.Psi.Tree.IArgument argument) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public virtual JetBrains.ReSharper.Psi.Tree.IExpression GetQualifier(JetBrains.ReSharper.Psi.Tree.IArgumentsOwner owner, out bool hasThisQualifier) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public virtual JetBrains.ReSharper.Psi.Resolve.IReference GetReference(JetBrains.ReSharper.Psi.Tree.IArgumentsOwner argumentsOwner) { }
        public virtual bool IsThisExpression([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Tree.IArgument argument) { }
        public virtual bool IsThisExpression([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public virtual JetBrains.ReSharper.Psi.Tree.ITreeNode Qualify([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode element, [JetBrains.Annotations.NotNullAttribute()] string name, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Refactorings.InlineParameter.Data.ParameterOwnerUsageUpdater> updaters, JetBrains.ReSharper.Refactorings.InlineParameter.Data.SuggestedParameter thisSuggestion) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public virtual JetBrains.ReSharper.Psi.Tree.ITreeNode ReplaceThisReferences(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.IDeclaredType type, JetBrains.ReSharper.Psi.ExtensionsAPI.ReferenceIdentitySaver saver, JetBrains.Util.Key<string> key, out bool hasUnresolvedThis, bool hasThisQualifier) { }
    }
    public class InlineParameterPage : JetBrains.UI.CommonControls.SafeUserControl, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage
    {
        public InlineParameterPage(JetBrains.ReSharper.Refactorings.InlineParameter.InlineParameterWorkflow workflow) { }
        public JetBrains.DataFlow.IProperty<bool> ContinueEnabled { get; }
        public string Description { get; }
        public bool DoNotShow { get; }
        public string Title { get; }
        public JetBrains.UI.CrossFramework.EitherControl View { get; }
        public JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage Commit(JetBrains.Application.Progress.IProgressIndicator pi) { }
        protected override void Dispose(bool disposing) { }
        public void GeneratePreview() { }
        public bool Initialize(JetBrains.Application.Progress.IProgressIndicator pi) { }
        public bool RefreshContents(JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
    }
    public class InlineParameterRefactoring : JetBrains.ReSharper.Refactorings.Common.DrivenRefactoring<JetBrains.ReSharper.Refactorings.InlineParameter.InlineParameterWorkflow, JetBrains.ReSharper.Refactorings.InlineParameter.InlineParameterBase>, JetBrains.ReSharper.Refactorings.InlineVar.IInlineRefactoring
    {
        public InlineParameterRefactoring(JetBrains.ReSharper.Refactorings.InlineParameter.InlineParameterWorkflow workFlow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public JetBrains.ReSharper.Psi.PsiLanguageType InvocationLanguage { get; }
        public JetBrains.ReSharper.Psi.Tree.IDeclaration NewParametersOwnerDecl { get; }
        public JetBrains.ReSharper.Refactorings.Inline.InlinedCallInfo CreateInlineCallInfo(JetBrains.ReSharper.Refactorings.Inline.InlinedMethodInfo info, JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public JetBrains.ReSharper.Refactorings.Inline.InlinedMethodInfo CreateInlinedMethodInfo() { }
        protected override JetBrains.ReSharper.Refactorings.InlineParameter.InlineParameterBase CreateRefactoringInternal(JetBrains.ReSharper.Refactorings.InternalRefactoringLanguageService service) { }
        protected override JetBrains.ReSharper.Refactorings.InlineParameter.InlineParameterBase CreateUnsupportedRefactoring() { }
        public override bool Execute(JetBrains.Application.Progress.IProgressIndicator pi) { }
        public System.Collections.Generic.Dictionary<int, JetBrains.ReSharper.Refactorings.Inline.InlinedParameterInfo> GetInlinedMethodParameterInfos(JetBrains.ReSharper.Psi.IParametersOwner parametersOwner) { }
        public JetBrains.ReSharper.Refactorings.Inline.InlineHelper GetInlineHelper(JetBrains.ReSharper.Psi.PsiLanguageType language) { }
        public void ProcessReferenceWithContext(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Refactorings.Inline.CallSiteContext context, JetBrains.ReSharper.Refactorings.Inline.InlinedCallInfo info) { }
        public void ReportLanguageConflict(JetBrains.ReSharper.Psi.PsiLanguageType language, JetBrains.ReSharper.Psi.PsiLanguageType invocationLanguage, JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
    }
    public class InlineParameterWorkflow : JetBrains.ReSharper.Refactorings.WorkflowNew.DrivenRefactoringWorkflow2<JetBrains.ReSharper.Refactorings.InlineParameter.InlineParameterHelper>
    {
        public InlineParameterWorkflow(JetBrains.ProjectModel.ISolution solution, string actionId) { }
        public override JetBrains.ReSharper.Refactorings.Workflow.RefactoringActionGroup ActionGroup { get; }
        public JetBrains.ReSharper.Psi.ITreeNodePointer<JetBrains.ReSharper.Psi.Tree.IArgumentsOwner> ArgumentsOwnerPointer { get; }
        public JetBrains.ReSharper.Refactorings.InlineParameter.Data.InlinedExpressionInfo ExpressionInfo { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Psi.ITreeNodePointer<JetBrains.ReSharper.Psi.Tree.IExpression> ExpressionPointer { get; }
        public override JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage FirstPendingRefactoringPage { get; }
        public override string HelpKeyword { get; }
        public JetBrains.ProjectModel.ProjectFileType Language { get; }
        public JetBrains.ReSharper.Psi.PsiLanguageType LanguageType { get; }
        public override bool MightModifyManyDocuments { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ReSharper.Refactorings.InlineParameter.Data.InlineParameterDataModel Model { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Refactorings.InlineParameter.Data.OverrideDataModel> OverrideModels { get; }
        public JetBrains.ReSharper.Refactorings.InlineParameter.Data.ParametersOwnerUsage SelectedUsage { get; }
        public override string Title { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public System.Collections.Generic.List<JetBrains.ReSharper.Refactorings.InlineParameter.Data.ParametersOwnerUsage> Usages { get; }
        public JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage CommitParametersPage(JetBrains.Application.Progress.IProgressIndicator pi) { }
        public JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage CommitUsagesPage(JetBrains.ReSharper.Refactorings.InlineParameter.Data.InlinedExpressionInfo expressionInfo, JetBrains.Application.Progress.IProgressIndicator pi) { }
        protected override JetBrains.ReSharper.Refactorings.InlineParameter.InlineParameterHelper CreateHelper(JetBrains.ReSharper.Refactorings.IRefactoringLanguageService service) { }
        public override JetBrains.ReSharper.Refactorings.Workflow.IRefactoringExecuter CreateRefactoring(JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        protected override JetBrains.ReSharper.Refactorings.InlineParameter.InlineParameterHelper CreateUnsupportedHelper() { }
        public JetBrains.TreeModels.TreeModel CreateUsagesModel() { }
        public bool InitDataForSelectParametersPage(JetBrains.Application.Progress.IProgressIndicator pi) { }
        public bool InitDataForUsagesPage(JetBrains.Application.Progress.IProgressIndicator pi) { }
        public override bool Initialize(JetBrains.Application.DataContext.IDataContext context) { }
        public override bool IsAvailable(JetBrains.Application.DataContext.IDataContext context) { }
        public bool IsValid() { }
        public override bool PreExecute(JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
        public void SetDataProvider(JetBrains.ReSharper.Refactorings.InlineParameter.InlineParameterDataProviderBase dataProvider) { }
    }
    public class InvocationsPage : JetBrains.UI.CommonControls.SafeUserControl, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage
    {
        public InvocationsPage(JetBrains.ReSharper.Refactorings.InlineParameter.InlineParameterWorkflow workflow) { }
        public JetBrains.DataFlow.IProperty<bool> ContinueEnabled { get; }
        public string Description { get; }
        public bool DoNotShow { get; }
        public string Title { get; }
        public JetBrains.UI.CrossFramework.EitherControl View { get; }
        public JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage Commit(JetBrains.Application.Progress.IProgressIndicator pi) { }
        protected override void Dispose(bool disposing) { }
        public bool Initialize(JetBrains.Application.Progress.IProgressIndicator pi) { }
        public bool RefreshContents(JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
    }
}
namespace JetBrains.ReSharper.Refactorings.InlineVar
{
    
    public interface IInlineRefactoring
    {
        JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver Driver { get; }
        JetBrains.ReSharper.Psi.PsiLanguageType InvocationLanguage { get; }
        JetBrains.ReSharper.Refactorings.Inline.InlinedCallInfo CreateInlineCallInfo(JetBrains.ReSharper.Refactorings.Inline.InlinedMethodInfo info, JetBrains.ReSharper.Psi.Resolve.IReference reference);
        JetBrains.ReSharper.Refactorings.Inline.InlinedMethodInfo CreateInlinedMethodInfo();
        JetBrains.ReSharper.Refactorings.Inline.InlineHelper GetInlineHelper(JetBrains.ReSharper.Psi.PsiLanguageType language);
        void ProcessReferenceWithContext(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Refactorings.Inline.CallSiteContext context, JetBrains.ReSharper.Refactorings.Inline.InlinedCallInfo info);
        void ReportLanguageConflict(JetBrains.ReSharper.Psi.PsiLanguageType language, JetBrains.ReSharper.Psi.PsiLanguageType invocationLanguage, JetBrains.ReSharper.Psi.Resolve.IReference reference);
    }
    public abstract class InlineVarBase : JetBrains.ReSharper.Refactorings.Common.RefactoringExecBase<JetBrains.ReSharper.Refactorings.InlineVar.InlineVarWorkflow, JetBrains.ReSharper.Refactorings.InlineVar.InlineVarRefactoring>
    {
        protected InlineVarBase(JetBrains.ReSharper.Refactorings.InlineVar.InlineVarWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public abstract JetBrains.ReSharper.Refactorings.Inline.InlineHelper InlineHelper { get; }
        public virtual bool Ignore(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public abstract void ProcessReferenceWithContext(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Refactorings.Inline.CallSiteContext context, JetBrains.ReSharper.Refactorings.Inline.InlinedCallInfo info);
        public abstract void RemoveAssignment(JetBrains.ReSharper.Psi.Tree.ITreeNode expression);
        public abstract void RemoveVariableDeclaration(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration);
    }
    public class InlineVarRefactoring : JetBrains.ReSharper.Refactorings.Common.DrivenRefactoring<JetBrains.ReSharper.Refactorings.InlineVar.InlineVarWorkflow, JetBrains.ReSharper.Refactorings.InlineVar.InlineVarBase>, JetBrains.ReSharper.Refactorings.InlineVar.IInlineRefactoring
    {
        public InlineVarRefactoring(JetBrains.ReSharper.Refactorings.InlineVar.InlineVarWorkflow workFlow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public JetBrains.ReSharper.Psi.PsiLanguageType InvocationLanguage { get; }
        public JetBrains.ReSharper.Psi.IType Type { get; set; }
        public JetBrains.ReSharper.Refactorings.Inline.InlinedCallInfo CreateInlineCallInfo(JetBrains.ReSharper.Refactorings.Inline.InlinedMethodInfo info, JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public JetBrains.ReSharper.Refactorings.Inline.InlinedMethodInfo CreateInlinedMethodInfo() { }
        protected override JetBrains.ReSharper.Refactorings.InlineVar.InlineVarBase CreateRefactoringInternal(JetBrains.ReSharper.Refactorings.InternalRefactoringLanguageService service) { }
        protected override JetBrains.ReSharper.Refactorings.InlineVar.InlineVarBase CreateUnsupportedRefactoring() { }
        public override bool Execute(JetBrains.Application.Progress.IProgressIndicator pi) { }
        public JetBrains.ReSharper.Refactorings.Inline.InlineHelper GetInlineHelper(JetBrains.ReSharper.Psi.PsiLanguageType language) { }
        public void ProcessReferenceWithContext(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Refactorings.Inline.CallSiteContext context, JetBrains.ReSharper.Refactorings.Inline.InlinedCallInfo info) { }
        public void ReportLanguageConflict(JetBrains.ReSharper.Psi.PsiLanguageType language, JetBrains.ReSharper.Psi.PsiLanguageType invocationLanguage, JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
    }
    public class InlineVarWorkflow : JetBrains.ReSharper.Refactorings.Workflow.DrivenRefactoringWorkflow
    {
        public InlineVarWorkflow(JetBrains.ProjectModel.ISolution solution, string actionId) { }
        public override JetBrains.ReSharper.Refactorings.Workflow.RefactoringActionGroup ActionGroup { get; }
        public JetBrains.ReSharper.Psi.ITreeNodePointer<JetBrains.ReSharper.Psi.Tree.ITreeNode> AssignmentExpressionPointer { get; }
        public JetBrains.ReSharper.Psi.ITreeNodePointer<JetBrains.ReSharper.Psi.Tree.IExpression> ExpressionPointer { get; }
        public override JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage FirstPendingRefactoringPage { get; }
        public override string HelpKeyword { get; }
        public bool InlineAll { get; }
        public JetBrains.ReSharper.Psi.PsiLanguageType LanguageType { get; }
        public override bool MightModifyManyDocuments { get; }
        public System.Collections.Generic.List<JetBrains.ReSharper.Psi.IReferencePointer> ReferencePointers { get; }
        public override string Title { get; }
        public JetBrains.ReSharper.Psi.Pointers.IDeclaredElementPointer<JetBrains.ReSharper.Psi.IDeclaredElement> VariablePointer { get; }
        public override JetBrains.ReSharper.Refactorings.Workflow.IRefactoringExecuter CreateRefactoring(JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public override bool Initialize(JetBrains.Application.DataContext.IDataContext context) { }
        public override bool IsAvailable(JetBrains.Application.DataContext.IDataContext context) { }
        public override bool PreExecute(JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
    }
}
namespace JetBrains.ReSharper.Refactorings.InlineVar.RDAnalysis
{
    
    public abstract class InlineVarAnalyserBase
    {
        protected InlineVarAnalyserBase(JetBrains.ReSharper.Refactorings.InlineVar.InlineVarWorkflow workflow) { }
        public abstract JetBrains.ReSharper.Psi.Tree.ITreeNode AssignmentExpression { get; }
        public abstract JetBrains.ReSharper.Psi.Tree.IExpression Expression { get; }
        public abstract bool InlineAll { get; set; }
        public abstract System.Collections.Generic.List<JetBrains.ReSharper.Psi.Resolve.IReference> References { get; }
        public JetBrains.ReSharper.Refactorings.InlineVar.InlineVarWorkflow Workflow { get; }
        public abstract JetBrains.Util.Pair<bool, string> Run(JetBrains.ReSharper.Psi.IDeclaredElement variable, JetBrains.ReSharper.Psi.Tree.ITreeNode element, System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Resolve.IReference> references);
    }
    public class InlineVarContext : JetBrains.ReSharper.Refactorings.InlineVar.RDAnalysis.IRDInspectorOfVariableContext
    {
        public JetBrains.ReSharper.Refactorings.InlineVar.RDAnalysis.InlineVarContextStates State { get; }
        public JetBrains.ReSharper.Refactorings.InlineVar.RDAnalysis.InlineVarContext Clone() { }
        public bool Equals(JetBrains.ReSharper.Refactorings.InlineVar.RDAnalysis.InlineVarContext obj) { }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
        public void MergeWith(JetBrains.ReSharper.Refactorings.InlineVar.RDAnalysis.InlineVarContext context) { }
        public void Read() { }
        public void TrueAssigned() { }
        public void Write() { }
    }
    public enum InlineVarContextStates
    {
        NotAssigned = 0,
        InlinedValueAssigned = 1,
        OtherValueAssigned = 2,
    }
    public interface IRDInspectorOfVariableContext
    {
        void Read();
        void Write();
    }
}
namespace JetBrains.ReSharper.Refactorings.IntroduceField
{
    
    public interface IIntroduceFieldWorkflowProvider : JetBrains.ReSharper.Feature.Services.ActionsMenu.IWorkflowProvider<JetBrains.ReSharper.Refactorings.Workflow.IRefactoringWorkflow, JetBrains.ReSharper.Refactorings.Workflow.RefactoringActionGroup>, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringWorkflowProvider { }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "IntroduceField"})]
    public class IntroFieldAction : JetBrains.ReSharper.Refactorings.WorkflowNew.IntroduceWithOccurencesAction<JetBrains.ReSharper.Refactorings.IntroduceField.IIntroduceFieldWorkflowProvider>
    {
        public const string ACTION_ID = "IntroduceField";
        protected override JetBrains.UI.RichText.RichText Caption { get; }
    }
    public class IntroFieldAnalyser
    {
        public virtual bool CanBeConstant(JetBrains.ReSharper.Psi.ILocalVariable variable) { }
        public bool CanInitCurrentMember(JetBrains.ReSharper.Psi.ILocalVariable variable) { }
        public virtual JetBrains.ReSharper.Psi.Tree.ITreeNode GetBlock(JetBrains.ReSharper.Psi.Tree.IDeclaration decl) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public virtual JetBrains.ReSharper.Psi.Tree.ITreeNode GetInitializer(JetBrains.ReSharper.Psi.ILocalVariable variable) { }
        public virtual bool IsFromConstructor(JetBrains.ReSharper.Psi.ILocalVariable variable, bool isStatic) { }
        public virtual bool IsFromConstructor(JetBrains.ReSharper.Psi.Tree.ITreeNode element, bool isStatic) { }
    }
    public abstract class IntroFieldBase : JetBrains.ReSharper.Refactorings.Common.RefactoringExecBase<JetBrains.ReSharper.Refactorings.IntroduceField.IntroFieldWorkflow, JetBrains.ReSharper.Refactorings.IntroduceField.IntroFieldRefactoring>
    {
        protected IntroFieldBase(JetBrains.ReSharper.Refactorings.IntroduceField.IntroFieldWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public abstract void AddAssignment(JetBrains.ReSharper.Psi.IParameter variable, JetBrains.ReSharper.Psi.ITypeMember member, JetBrains.ReSharper.Psi.Tree.IExpression expression);
        public abstract JetBrains.ReSharper.Psi.ITypeMember AddField(JetBrains.ReSharper.Psi.Tree.ITypeDeclaration typeDeclaration, JetBrains.ReSharper.Psi.Tree.IExpression initExpression, System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Tree.ITreeNode> tags);
        public virtual JetBrains.ReSharper.Psi.Tree.IExpression GetInitializer(JetBrains.ReSharper.Psi.ILocalVariable variable) { }
        public abstract bool ReplaceUsages(System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Tree.ITreeNode> expressions, JetBrains.ReSharper.Psi.ITypeMember field, JetBrains.ReSharper.Psi.Tree.ITreeNode initializer);
        public abstract bool ReplaceVariableDeclaration(JetBrains.ReSharper.Psi.ILocalVariable variable, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.ITypeMember field, JetBrains.ReSharper.Psi.Tree.IExpression initializer);
    }
    public class IntroFieldData
    {
        public JetBrains.ReSharper.Psi.AccessRights AccessRights { get; set; }
        public bool InitConstant { get; set; }
        public bool InitConstructors { get; set; }
        public bool InitCurrent { get; set; }
        public bool InitField { get; set; }
        public string Name { get; set; }
        public bool Readonly { get; set; }
        public bool Static { get; set; }
    }
    public class IntroFieldOptions
    {
        public bool CanBeConstant { get; }
        public bool CanBeReadonly { get; }
        public bool CanBeStatic { get; }
        public bool CanInitConstructor { get; }
        public bool CanInitCurrentMember { get; }
        public bool CanInitCurrentMemberInMemberContext { get; }
        public bool CanInitFieldDeclaration { get; }
        public bool CanInitReadonlyInCurrentMember { get; }
        public bool CanInitStaticReadonlyInCurrentMember { get; }
        public bool CanIntroduce { get; }
        public bool MustBeConstant { get; }
        public bool MustBeConstantInClassContext { get; }
        public bool MustBeConstantInMemberContext { get; }
        public bool MustBeStatic { get; }
        public bool MustBeStaticInClassContext { get; }
        public static JetBrains.ReSharper.Refactorings.IntroduceField.IntroFieldOptions CreateFromExpression(JetBrains.ReSharper.Psi.Tree.IExpression expression, System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Tree.ITreeNode> classContextOccurences, System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Tree.ITreeNode> memberContextOccurences, bool canHaveConstructor) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Refactorings.IntroduceField.IntroFieldOptions CreateFromLocalVariable(JetBrains.ReSharper.Psi.ILocalVariable variable, bool canHaveConstructor) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Refactorings.IntroduceField.IntroFieldOptions CreateFromParameter(JetBrains.ReSharper.Psi.IParameter parameter) { }
    }
    public class IntroFieldRefactoring : JetBrains.ReSharper.Refactorings.Common.DrivenRefactoring<JetBrains.ReSharper.Refactorings.IntroduceField.IntroFieldWorkflow, JetBrains.ReSharper.Refactorings.IntroduceField.IntroFieldBase>
    {
        public IntroFieldRefactoring(JetBrains.ReSharper.Refactorings.IntroduceField.IntroFieldWorkflow workFlow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        protected override JetBrains.ReSharper.Refactorings.IntroduceField.IntroFieldBase CreateRefactoringInternal(JetBrains.ReSharper.Refactorings.InternalRefactoringLanguageService service) { }
        protected override JetBrains.ReSharper.Refactorings.IntroduceField.IntroFieldBase CreateUnsupportedRefactoring() { }
        public override bool Execute(JetBrains.Application.Progress.IProgressIndicator pi) { }
    }
    public class IntroFieldWindow : JetBrains.UI.CommonControls.SafeUserControl, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage
    {
        public AccessMember[] Members;
        public IntroFieldWindow(JetBrains.ReSharper.Refactorings.IntroduceField.IntroFieldWorkflow workflow, JetBrains.ReSharper.Psi.PsiLanguageType language) { }
        public JetBrains.DataFlow.IProperty<bool> ContinueEnabled { get; }
        public string Description { get; }
        public bool DoNotShow { get; }
        public string Title { get; }
        public JetBrains.UI.CrossFramework.EitherControl View { get; }
        public JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage Commit(JetBrains.Application.Progress.IProgressIndicator pi) { }
        protected override void Dispose(bool disposing) { }
        public bool Initialize(JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
        public bool RefreshContents(JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
        public class AccessMember
        {
            public AccessMember(JetBrains.ReSharper.Psi.AccessRights accessRights, JetBrains.ReSharper.Psi.PsiLanguageType language) { }
            public JetBrains.ReSharper.Psi.AccessRights AccessRights { get; }
            public string Presentation { get; }
            public override string ToString() { }
        }
    }
    public class IntroFieldWorkflow : JetBrains.ReSharper.Refactorings.Workflow.DrivenRefactoringWorkflow, JetBrains.ReSharper.Refactorings.WorkflowNew.IIntroduceWorkflowWithOccurences
    {
        public IntroFieldWorkflow(JetBrains.ProjectModel.ISolution solution, string actionId) { }
        public override JetBrains.ReSharper.Refactorings.Workflow.RefactoringActionGroup ActionGroup { get; }
        public string DefaultName { get; }
        public JetBrains.ReSharper.Psi.Tree.ITreeNode Expression { get; }
        public override JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage FirstPendingRefactoringPage { get; }
        public bool HasManyUsages { get; }
        public override string HelpKeyword { get; }
        public JetBrains.ReSharper.Feature.Services.Navigation.CustomHighlighting.CustomHighlightingRequest HighlightingRequest { get; set; }
        public JetBrains.ReSharper.Refactorings.IntroduceField.IntroFieldData IntroFieldData { get; }
        public JetBrains.ReSharper.Psi.PsiLanguageType LanguageType { get; }
        public override bool MightModifyManyDocuments { get; }
        public System.Collections.Generic.List<JetBrains.ReSharper.Psi.Tree.ITreeNode> MoreUsages { get; }
        public JetBrains.ReSharper.Refactorings.WorkflowNew.SelectedItem OccurencesCheck { get; }
        public JetBrains.ReSharper.Refactorings.IntroduceField.IntroFieldOptions Options { get; }
        public JetBrains.ReSharper.Psi.IParameter Parameter { get; }
        public JetBrains.ReSharper.Psi.IPsiSourceFile SourceFile { get; }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Naming.Impl.NameRoot> SuggestedRoots { get; }
        public JetBrains.TextControl.ITextControl TextControl { get; }
        public override string Title { get; }
        public JetBrains.ReSharper.Psi.IType Type { get; }
        public JetBrains.ReSharper.Psi.Tree.ITypeDeclaration TypeDeclaration { get; }
        public System.Collections.Generic.List<JetBrains.ReSharper.Psi.Tree.ITreeNode> Usages { get; }
        public JetBrains.ReSharper.Psi.ILocalVariable Variable { get; }
        public override JetBrains.ReSharper.Refactorings.Workflow.IRefactoringExecuter CreateRefactoring(JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public override bool Initialize(JetBrains.Application.DataContext.IDataContext context) { }
        public override bool IsAvailable(JetBrains.Application.DataContext.IDataContext context) { }
        public void SetData(JetBrains.ReSharper.Refactorings.IntroduceField.IntroFieldData data) { }
        public void SetIndex(JetBrains.ReSharper.Refactorings.WorkflowNew.SelectedItem value) { }
    }
}
namespace JetBrains.ReSharper.Refactorings.IntroduceParameter
{
    
    public interface IIntroduceParameterDataProvider
    {
        string NewName { get; set; }
        bool ReplaceAllOccurences { get; set; }
        void ProvideLambdas(System.Collections.Generic.IList<JetBrains.ReSharper.Refactorings.CommonUI.IMemberInfo> memberInfos);
    }
    public interface IIntroduceParameterDriver
    {
        System.Collections.Generic.JetHashSet<JetBrains.ReSharper.Psi.IParameter> UsedParameters { get; set; }
        System.Collections.Generic.Dictionary<int, JetBrains.ReSharper.Refactorings.Inline.InlinedParameterInfo> GetInlinedMethodParameterInfos(JetBrains.ReSharper.Psi.IParametersOwner owner);
        JetBrains.ReSharper.Refactorings.Inline.InlineHelper GetInlineHelper(JetBrains.ReSharper.Psi.PsiLanguageType language);
    }
    public interface IIntroduceParameterWorkflowProvider : JetBrains.ReSharper.Feature.Services.ActionsMenu.IWorkflowProvider<JetBrains.ReSharper.Refactorings.Workflow.IRefactoringWorkflow, JetBrains.ReSharper.Refactorings.Workflow.RefactoringActionGroup>, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringWorkflowProvider { }
    public abstract class IntroduceParameterBase : JetBrains.ReSharper.Refactorings.Common.RefactoringExecBase<JetBrains.ReSharper.Refactorings.IntroduceParameter.IntroduceParameterWorkflow, JetBrains.ReSharper.Refactorings.IntroduceParameter.IntroduceParameterRefactoring>
    {
        protected IntroduceParameterBase(JetBrains.ReSharper.Refactorings.IntroduceParameter.IntroduceParameterWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public abstract JetBrains.ReSharper.Refactorings.Inline.InlineHelper InlineHelper { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public abstract JetBrains.ReSharper.Psi.Resolve.IReference AddBaseClause(JetBrains.ReSharper.Psi.IDeclaredElement constructor);
        public abstract void AddParameter(JetBrains.ReSharper.Psi.IType type, string name, JetBrains.ReSharper.Psi.Tree.IDeclaration declaration, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution, JetBrains.ReSharper.Psi.Tree.ITreeNode defaultValue);
        public abstract void CallInline(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Refactorings.Inline.CallSiteContext context, JetBrains.ReSharper.Refactorings.Inline.InlinedCallInfo info, System.Collections.Generic.IList<string> lambdaParameterNames, int lastArgIndex);
        public abstract void FixOtherArguments(ref JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Refactorings.Inline.InlinedCallInfo info, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution);
        public abstract void RemoveLocalVariable(JetBrains.ReSharper.Psi.ILocalVariable variable);
        public abstract void ReplaceExpression(JetBrains.ReSharper.Psi.Tree.ITreeNode element);
        public virtual bool ThisIsUsed(JetBrains.ReSharper.Psi.Tree.ITreeNode expression) { }
    }
    public class IntroduceParameterHierarchyConflictTextProvider : JetBrains.ReSharper.Refactorings.Conflicts.HierarchyConflictTextProviderBase
    {
        public override string QuasiImplements() { }
        public override string WillAlsoImplement() { }
        public override string WillAlsoOverride() { }
    }
    public class IntroduceParameterRefactoring : JetBrains.ReSharper.Refactorings.Common.DrivenRefactoring<JetBrains.ReSharper.Refactorings.IntroduceParameter.IntroduceParameterWorkflow, JetBrains.ReSharper.Refactorings.IntroduceParameter.IntroduceParameterBase>, JetBrains.ReSharper.Refactorings.Inline.ICallSiteContextOwner, JetBrains.ReSharper.Refactorings.IntroduceParameter.IIntroduceParameterDriver
    {
        public IntroduceParameterRefactoring(JetBrains.ReSharper.Refactorings.IntroduceParameter.IntroduceParameterWorkflow workFlow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public int HasParamarray { get; set; }
        public int LastNotOptionalParameterIndex { get; }
        public System.Collections.Generic.JetHashSet<JetBrains.ReSharper.Psi.ITypeOwner> LocalsForLambda { get; }
        public System.Collections.Generic.Dictionary<JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.ReSharper.Refactorings.Inline.LocalContextResolveResultImage> ResolveImages { get; }
        public System.Collections.Generic.JetHashSet<JetBrains.ReSharper.Psi.IParameter> UsedParameters { get; set; }
        public void AddContext(JetBrains.ReSharper.Psi.Tree.ITreeNode context) { }
        protected override JetBrains.ReSharper.Refactorings.IntroduceParameter.IntroduceParameterBase CreateRefactoringInternal(JetBrains.ReSharper.Refactorings.InternalRefactoringLanguageService service) { }
        protected override JetBrains.ReSharper.Refactorings.IntroduceParameter.IntroduceParameterBase CreateUnsupportedRefactoring() { }
        public override bool Execute(JetBrains.Application.Progress.IProgressIndicator pi) { }
        public System.Collections.Generic.Dictionary<int, JetBrains.ReSharper.Refactorings.Inline.InlinedParameterInfo> GetInlinedMethodParameterInfos(JetBrains.ReSharper.Psi.IParametersOwner owner) { }
        public JetBrains.ReSharper.Refactorings.Inline.InlineHelper GetInlineHelper(JetBrains.ReSharper.Psi.PsiLanguageType language) { }
        public static System.Collections.Generic.JetHashSet<JetBrains.ReSharper.Psi.IParameter> GetUsedParameters(System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Tree.ITreeNode> expression, JetBrains.ReSharper.Psi.IParametersOwner parameterOwner) { }
        public bool ThisIsUsed(JetBrains.ReSharper.Psi.Tree.ITreeNode expression) { }
    }
    public class IntroduceParameterWindow : JetBrains.UI.CommonControls.SafeUserControl, JetBrains.CommonControls.Validation.IValidatorProvider, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage
    {
        public IntroduceParameterWindow(JetBrains.ReSharper.Refactorings.IntroduceParameter.IntroduceParameterWorkflow workflow) { }
        public JetBrains.DataFlow.IProperty<bool> ContinueEnabled { get; }
        public string Description { get; }
        public bool DoNotShow { get; }
        public string Title { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.CommonControls.Validation.IValidator> Validators { get; }
        public JetBrains.UI.CrossFramework.EitherControl View { get; }
        public JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage Commit(JetBrains.Application.Progress.IProgressIndicator pi) { }
        protected override void Dispose(bool disposing) { }
        public bool Initialize(JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
        public bool RefreshContents(JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
    }
    public class IntroduceParameterWorkflow : JetBrains.ReSharper.Refactorings.Workflow.DrivenRefactoringWorkflow, JetBrains.ReSharper.Refactorings.WorkflowNew.IIntroduceWorkflowWithOccurences
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public System.Collections.Generic.IList<string> Names;
        public IntroduceParameterWorkflow(JetBrains.ProjectModel.ISolution solution, string actionId) { }
        public override JetBrains.ReSharper.Refactorings.Workflow.RefactoringActionGroup ActionGroup { get; }
        public bool CanBeDefault { get; }
        public string DefaultName { get; }
        public JetBrains.ReSharper.Psi.Tree.ITreeNode Expression { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.ITreeNodePointer<JetBrains.ReSharper.Psi.Tree.ITreeNode>> ExpressionPointers { get; }
        public override JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage FirstPendingRefactoringPage { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public bool HasManyUsages { get; }
        public override string HelpKeyword { get; }
        public JetBrains.ReSharper.Feature.Services.Navigation.CustomHighlighting.CustomHighlightingRequest HighlightingRequest { get; set; }
        public JetBrains.ReSharper.Psi.PsiLanguageType LanguageType { get; }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Refactorings.CommonUI.IMemberInfo> LocalInfos { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Psi.Pointers.IDeclaredElementPointer<JetBrains.ReSharper.Psi.ILocalVariable> LocalVariablePointer { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ReSharper.Psi.ITreeNodePointer<JetBrains.ReSharper.Psi.Tree.ITreeNode> MainExpressionPointer { get; }
        public override bool MightModifyManyDocuments { get; }
        public System.Collections.Generic.List<JetBrains.ReSharper.Psi.Tree.ITreeNode> MoreUsages { get; }
        public string NewName { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ReSharper.Psi.Pointers.IDeclaredElementPointer<JetBrains.ReSharper.Psi.IParametersOwner> ParametersOwnerPointer { get; }
        public bool ReplaceAllOccurences { get; }
        public JetBrains.TextControl.ITextControl TextControl { get; }
        public override string Title { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ReSharper.Psi.IType Type { get; }
        public System.Collections.Generic.List<JetBrains.ReSharper.Psi.Tree.ITreeNode> Usages { get; }
        public JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage Commit(string parameterName, bool isDefault) { }
        public override JetBrains.ReSharper.Refactorings.Workflow.IRefactoringExecuter CreateRefactoring(JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public System.Collections.Generic.JetHashSet<JetBrains.ReSharper.Psi.ITypeOwner> GetLocalForLambda() { }
        public string GetTypePreviewText() { }
        public override bool Initialize(JetBrains.Application.DataContext.IDataContext context) { }
        public override bool IsAvailable(JetBrains.Application.DataContext.IDataContext context) { }
        public bool NameIsUnical(string name) { }
        public override bool PostExecute(JetBrains.Application.Progress.IProgressIndicator pi) { }
        public override bool PreExecute(JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
        public void SetDataProvider(JetBrains.ReSharper.Refactorings.IntroduceParameter.IIntroduceParameterDataProvider dataProvider) { }
        public void SetIndex(JetBrains.ReSharper.Refactorings.WorkflowNew.SelectedItem value) { }
        public override bool Validate() { }
    }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "IntroParameter"})]
    public class IntroParameterAction : JetBrains.ReSharper.Refactorings.WorkflowNew.IntroduceWithOccurencesAction<JetBrains.ReSharper.Refactorings.IntroduceParameter.IIntroduceParameterWorkflowProvider>
    {
        public const string ACTION_ID = "IntroParameter";
        protected override JetBrains.UI.RichText.RichText Caption { get; }
    }
    public class LocalsMemberInfo : JetBrains.ReSharper.Refactorings.CommonUI.BaseMemberInfo
    {
        public LocalsMemberInfo(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, JetBrains.ReSharper.Psi.PsiLanguageType language) { }
        public override bool CanChangeAbstract { get; }
        public override bool CanHaveAbstract { get; }
        public override bool Enabled { get; }
        public override bool HasError { get; }
        public override bool HasWarning { get; }
        public override bool Included { get; set; }
        public override bool MakeAbstract { get; set; }
        public override string ToolTip { get; }
    }
}
namespace JetBrains.ReSharper.Refactorings.IntroduceVariable.Impl
{
    
    public interface IIntroduceVariableWorkflowProvider : JetBrains.ReSharper.Feature.Services.ActionsMenu.IWorkflowProvider<JetBrains.ReSharper.Refactorings.Workflow.IRefactoringWorkflow, JetBrains.ReSharper.Refactorings.Workflow.RefactoringActionGroup>, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringWorkflowProvider { }
    [JetBrains.ReSharper.Refactorings.Workflow.RefactoringWorkflowProviderAttribute()]
    public class IntroduceVariableWorkflowProvider : JetBrains.ReSharper.Feature.Services.ActionsMenu.IWorkflowProvider<JetBrains.ReSharper.Refactorings.Workflow.IRefactoringWorkflow, JetBrains.ReSharper.Refactorings.Workflow.RefactoringActionGroup>, JetBrains.ReSharper.Refactorings.IntroduceVariable.Impl.IIntroduceVariableWorkflowProvider, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringWorkflowProvider
    {
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Refactorings.Workflow.IRefactoringWorkflow> CreateWorkflow(JetBrains.Application.DataContext.IDataContext dataContext) { }
    }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "IntroduceVariable"})]
    public class IntroVariableAction : JetBrains.ReSharper.Refactorings.WorkflowNew.IntroduceWithOccurencesAction<JetBrains.ReSharper.Refactorings.IntroduceVariable.Impl.IIntroduceVariableWorkflowProvider>
    {
        public const string ACTION_ID = "IntroduceVariable";
        protected override JetBrains.UI.RichText.RichText Caption { get; }
    }
}
namespace JetBrains.ReSharper.Refactorings.IntroduceVariable
{
    
    public abstract class IntroduceLocalRefactoring : JetBrains.ReSharper.Refactorings.Common.DrivenRefactoring<JetBrains.ReSharper.Refactorings.IntroduceVariable.IntroduceLocalWorkflowBase, JetBrains.ReSharper.Refactorings.IntroduceVariable.IntroduceVariableBase>
    {
        protected IntroduceLocalRefactoring(JetBrains.ReSharper.Refactorings.IntroduceVariable.IntroduceLocalWorkflowBase workFlow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        protected abstract string CanNotPreformActionText { get; }
        protected override JetBrains.ReSharper.Refactorings.IntroduceVariable.IntroduceVariableBase CreateRefactoringInternal(JetBrains.ReSharper.Refactorings.InternalRefactoringLanguageService service) { }
        protected abstract JetBrains.ReSharper.Feature.Services.Refactorings.ReplaceInfo CreateReplaceInfo();
        protected override JetBrains.ReSharper.Refactorings.IntroduceVariable.IntroduceVariableBase CreateUnsupportedRefactoring() { }
        public override bool Execute(JetBrains.Application.Progress.IProgressIndicator pi) { }
        protected abstract void ValueSelectedCallback(JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.Hotspot oldHotspot);
    }
    public abstract class IntroduceLocalWorkflowBase : JetBrains.ReSharper.Refactorings.WorkflowNew.DrivenRefactoringWorkflow2<JetBrains.ReSharper.Refactorings.IntroduceVariable.IntroduceVariableHelper>
    {
        protected IntroduceLocalWorkflowBase(JetBrains.ProjectModel.ISolution solution, string actionId) { }
        public override JetBrains.ReSharper.Refactorings.Workflow.RefactoringActionGroup ActionGroup { get; }
        public System.Collections.Generic.List<System.Action> Actions { get; }
        public JetBrains.ReSharper.Psi.ITreeNodePointer<JetBrains.ReSharper.Psi.Tree.ITreeNode> ContainingLambdaPointer { get; set; }
        public override JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage FirstPendingRefactoringPage { get; }
        public override bool HasUI { get; }
        public override string HelpKeyword { get; }
        public JetBrains.DocumentModel.IRangeMarker Marker { get; set; }
        public override bool MightModifyManyDocuments { get; }
        public JetBrains.ReSharper.Psi.ITreeNodePointer<JetBrains.ReSharper.Psi.Tree.ITreeNode> NodePointer { get; set; }
        public string[] SuggestedNames { get; set; }
        public JetBrains.TextControl.ITextControl TextControl { get; }
        protected override JetBrains.ReSharper.Refactorings.IntroduceVariable.IntroduceVariableHelper CreateHelper(JetBrains.ReSharper.Refactorings.IRefactoringLanguageService service) { }
        protected override JetBrains.ReSharper.Refactorings.IntroduceVariable.IntroduceVariableHelper CreateUnsupportedHelper() { }
        public override bool IsAvailable(JetBrains.Application.DataContext.IDataContext context) { }
        public override void SuccessfulFinish(JetBrains.Application.Progress.IProgressIndicator pi) { }
    }
    public abstract class IntroduceVariableBase : JetBrains.ReSharper.Refactorings.Common.RefactoringExecBase<JetBrains.ReSharper.Refactorings.IntroduceVariable.IntroduceLocalWorkflowBase, JetBrains.ReSharper.Refactorings.IntroduceVariable.IntroduceLocalRefactoring>
    {
        protected IntroduceVariableBase(JetBrains.ReSharper.Refactorings.IntroduceVariable.IntroduceLocalWorkflowBase workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public abstract JetBrains.ReSharper.Feature.Services.Refactorings.ReplaceInfo Process(System.Collections.Generic.List<JetBrains.ReSharper.Psi.Tree.ITreeNode> expressions, JetBrains.ReSharper.Psi.Tree.ITreeNode sourceExpression);
        public virtual void ValueSelectedCallback(JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.Hotspot value) { }
    }
    public class IntroduceVariableHelper : JetBrains.ReSharper.Refactorings.IWorkflowExec
    {
        public virtual bool IsLanguageSupported { get; }
        public virtual bool CheckAvailability(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public virtual bool CheckOccurrence(JetBrains.ReSharper.Psi.Tree.ITreeNode masterExpression, JetBrains.ReSharper.Psi.Tree.ITreeNode occurrence) { }
        public virtual JetBrains.ReSharper.Psi.Tree.ITreeNode GetScope(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
    }
    public class IntroduceVariableRefactoring : JetBrains.ReSharper.Refactorings.IntroduceVariable.IntroduceLocalRefactoring
    {
        public IntroduceVariableRefactoring(JetBrains.ReSharper.Refactorings.IntroduceVariable.IntroduceVariableWorkflow workFlow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver, bool all) { }
        public IntroduceVariableRefactoring(JetBrains.ReSharper.Refactorings.IntroduceVariable.IntroduceVariableWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver, JetBrains.ReSharper.Refactorings.IntroduceVariable.IntroduceVariableWorkflow.IntroduceVariableDataProvider dataProvider) { }
        protected override string CanNotPreformActionText { get; }
        protected override JetBrains.ReSharper.Feature.Services.Refactorings.ReplaceInfo CreateReplaceInfo() { }
        public override bool Execute(JetBrains.Application.Progress.IProgressIndicator pi) { }
        protected override void ValueSelectedCallback(JetBrains.ReSharper.Feature.Services.LiveTemplates.Hotspots.Hotspot oldHotspot) { }
    }
    public class IntroduceVariableWorkflow : JetBrains.ReSharper.Refactorings.IntroduceVariable.IntroduceLocalWorkflowBase, JetBrains.ReSharper.Refactorings.WorkflowNew.IIntroduceWorkflowWithOccurences
    {
        public IntroduceVariableWorkflow(JetBrains.ProjectModel.ISolution solution, string actionId) { }
        public IntroduceVariableWorkflow(JetBrains.ReSharper.Refactorings.IntroduceVariable.IntroduceVariableWorkflow.IntroduceVariableDataProvider dataProvider, JetBrains.ProjectModel.ISolution solution, string actionId) { }
        public override JetBrains.ReSharper.Refactorings.Workflow.RefactoringActionGroup ActionGroup { get; }
        public JetBrains.ReSharper.Psi.Tree.ITreeNode Expression { get; }
        public bool HasManyUsages { get; }
        public JetBrains.ReSharper.Feature.Services.Navigation.CustomHighlighting.CustomHighlightingRequest HighlightingRequest { get; set; }
        public JetBrains.ReSharper.Psi.PsiLanguageType LanguageType { get; }
        public System.Collections.Generic.List<JetBrains.ReSharper.Psi.Tree.ITreeNode> MoreUsages { get; }
        public override string Title { get; }
        public System.Collections.Generic.List<JetBrains.ReSharper.Psi.Tree.ITreeNode> Usages { get; }
        public override JetBrains.ReSharper.Refactorings.Workflow.IRefactoringExecuter CreateRefactoring(JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public override bool Initialize(JetBrains.Application.DataContext.IDataContext context) { }
        public override bool IsAvailable(JetBrains.Application.DataContext.IDataContext context) { }
        public void SetIndex(JetBrains.ReSharper.Refactorings.WorkflowNew.SelectedItem value) { }
        public class IntroduceVariableDataProvider
        {
            public IntroduceVariableDataProvider(bool all) { }
            public bool All { get; }
        }
    }
}
namespace JetBrains.ReSharper.Refactorings.Iterator2Function
{
    
    public interface IIterator2FunctionWorkflowProvider : JetBrains.ReSharper.Feature.Services.ActionsMenu.IWorkflowProvider<JetBrains.ReSharper.Refactorings.Workflow.IRefactoringWorkflow, JetBrains.ReSharper.Refactorings.Workflow.RefactoringActionGroup>, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringWorkflowProvider { }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "Iterator2Function"})]
    public class Iterator2FunctionAction : JetBrains.ReSharper.Refactorings.Workflow.ExtensibleRefactoringAction<JetBrains.ReSharper.Refactorings.Iterator2Function.IIterator2FunctionWorkflowProvider>
    {
        public const string ACTION_ID = "Iterator2Function";
        protected override JetBrains.UI.RichText.RichText Caption { get; }
    }
    public abstract class Iterator2FunctionBase : JetBrains.ReSharper.Refactorings.Common.RefactoringExecBase<JetBrains.ReSharper.Refactorings.Iterator2Function.Iterator2FunctionWorkflow, JetBrains.ReSharper.Refactorings.Iterator2Function.Iterator2FunctionRefactoring>
    {
        protected Iterator2FunctionBase(JetBrains.ReSharper.Refactorings.Iterator2Function.Iterator2FunctionWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        protected abstract void CollectListNameSuggestions(JetBrains.ReSharper.Psi.Tree.IDeclaration iterator, JetBrains.ReSharper.Psi.Naming.Extentions.EntryOptions options, JetBrains.ReSharper.Psi.Naming.Extentions.INamesCollection suggestion);
        public JetBrains.ReSharper.Feature.Services.Refactorings.ReplaceInfo ExecuteDeclarationRefactoring(JetBrains.ReSharper.Psi.IDeclaredElement iterator, JetBrains.Application.Progress.IProgressIndicator pi) { }
        protected virtual JetBrains.ReSharper.Psi.IDeclaredType GetDeclaredElementReturnType(JetBrains.ReSharper.Psi.IDeclaredElement iterator) { }
        protected JetBrains.ReSharper.Psi.IType GetIteratorElementType(JetBrains.ReSharper.Psi.IDeclaredElement iteratorElement, JetBrains.ReSharper.Psi.Modules.IPsiModule module, out bool returnsEnumerator) { }
        protected void NoReachableExitsConflict() { }
        public abstract JetBrains.ReSharper.Feature.Services.Refactorings.ReplaceInfo ProcessIterator(JetBrains.ReSharper.Psi.Tree.IDeclaration iterator, JetBrains.ReSharper.Psi.IType elementType, bool returnsEnumerator, JetBrains.Application.Progress.IProgressIndicator pi);
        protected System.Collections.Generic.IList<string> SuggestOutputListName(JetBrains.ReSharper.Psi.Tree.IDeclaration iterator, JetBrains.ReSharper.Psi.Tree.ITreeNode uniqueContext) { }
    }
    public class Iterator2FunctionRefactoring : JetBrains.ReSharper.Refactorings.Common.DrivenRefactoring<JetBrains.ReSharper.Refactorings.Iterator2Function.Iterator2FunctionWorkflow, JetBrains.ReSharper.Refactorings.Iterator2Function.Iterator2FunctionBase>
    {
        public Iterator2FunctionRefactoring(JetBrains.ReSharper.Refactorings.Iterator2Function.Iterator2FunctionWorkflow workFlow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        protected override JetBrains.ReSharper.Refactorings.Iterator2Function.Iterator2FunctionBase CreateRefactoringInternal(JetBrains.ReSharper.Refactorings.InternalRefactoringLanguageService service) { }
        public override bool Execute(JetBrains.Application.Progress.IProgressIndicator pi) { }
    }
    public class Iterator2FunctionWorkflow : JetBrains.ReSharper.Refactorings.Workflow.DrivenRefactoringWorkflow
    {
        public Iterator2FunctionWorkflow(JetBrains.ProjectModel.ISolution solution, string actionId) { }
        public override JetBrains.ReSharper.Refactorings.Workflow.RefactoringActionGroup ActionGroup { get; }
        public System.Collections.Generic.List<System.Action> Actions { get; }
        public override JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage FirstPendingRefactoringPage { get; }
        public override string HelpKeyword { get; }
        public override bool MightModifyManyDocuments { get; }
        public JetBrains.ReSharper.Psi.Pointers.IDeclaredElementPointer<JetBrains.ReSharper.Psi.IDeclaredElement> Pointer { get; }
        public JetBrains.TextControl.ITextControl TextControl { get; }
        public override string Title { get; }
        public override JetBrains.ReSharper.Refactorings.Workflow.IRefactoringExecuter CreateRefactoring(JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public override bool Initialize(JetBrains.Application.DataContext.IDataContext context) { }
        public override bool IsAvailable(JetBrains.Application.DataContext.IDataContext context) { }
        public override bool PreExecute(JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
        public override void SuccessfulFinish(JetBrains.Application.Progress.IProgressIndicator pi) { }
        public override bool Validate() { }
    }
}
namespace JetBrains.ReSharper.Refactorings.MakeMethodNonStatic
{
    
    public struct Conflicts
    {
        public readonly bool AccessError;
        public readonly JetBrains.ReSharper.Psi.IDelegate Delegate;
        public readonly bool NullArgument;
        public readonly bool UnqualifiedError;
        public Conflicts(JetBrains.ReSharper.Psi.IDelegate @delegate, bool nullArgument, bool accessError, bool unqualifiedError) { }
    }
    public interface IMakeMethodNonStatic : JetBrains.ReSharper.Refactorings.ILanguageSpecificRefactoringService
    {
        JetBrains.ReSharper.Psi.Tree.IDeclaration AddDeclaration(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration, JetBrains.ReSharper.Psi.Tree.IDeclaration methodOwnerDeclaration);
        void BindToThis(JetBrains.ReSharper.Psi.Resolve.IReference reference);
        JetBrains.ReSharper.Psi.IDeclaredElement PatchDeclaration(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration, int thisParameterIndex, bool createVar, JetBrains.ReSharper.Psi.ITypeElement newMethodOwner, System.Collections.Generic.IList<JetBrains.ReSharper.Psi.ITypeParameter> typeParams, JetBrains.ReSharper.Psi.IInterface @interface, JetBrains.ReSharper.Psi.AccessRights accessRights, System.Collections.Generic.Dictionary<JetBrains.ReSharper.Psi.ITypeParameter, JetBrains.ReSharper.Psi.ITypeParameter> newToOldTypeParameters);
        void PatchMethodReference(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution, int thisParameterIndex, string thisParameterName, System.Collections.Generic.Dictionary<JetBrains.ReSharper.Psi.ITypeParameter, JetBrains.ReSharper.Psi.ITypeParameter> newToOldTypeParametersMap, System.Collections.Generic.IList<JetBrains.ReSharper.Psi.ITypeParameter> methodTypeParams);
        void PatchRecursiveCall(JetBrains.ReSharper.Psi.Tree.ITreeNode referenceElement, int thisParameterIndex, string thisParameterName);
        JetBrains.ReSharper.Refactorings.MakeMethodNonStatic.Conflicts ReferenceConflicts(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.IFunction method, int thisParamIndex, JetBrains.ReSharper.Psi.AccessRights accessRights, JetBrains.ReSharper.Psi.ITypeElement targetType);
        void RemoveDeclaration(JetBrains.ReSharper.Psi.Tree.IDeclaration methodDeclaration);
        bool Suitable(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration);
    }
    public interface IMakeMethodNonStaticWorkflowProvider : JetBrains.ReSharper.Feature.Services.ActionsMenu.IWorkflowProvider<JetBrains.ReSharper.Refactorings.Workflow.IRefactoringWorkflow, JetBrains.ReSharper.Refactorings.Workflow.RefactoringActionGroup>, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringWorkflowProvider { }
    public class InitializedStage : JetBrains.ReSharper.Refactorings.Util.IRefactoringStage
    {
        public InitializedStage(JetBrains.ReSharper.Psi.IDeclaredElement method) { }
        public bool IsValid { get; }
        public JetBrains.ReSharper.Psi.PsiLanguageType Language { get; }
        public JetBrains.ReSharper.Psi.IFunction Method { get; }
        public JetBrains.ReSharper.Refactorings.Util.IRefactoringStage PreviousStage { get; }
        public JetBrains.ReSharper.Refactorings.Util.IRefactoringStage Clone(JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
        public static JetBrains.ReSharper.Psi.AccessRights GetAccessRights(int selectedVisibility) { }
        public int GetDefaultVisibility() { }
        public JetBrains.ReSharper.Refactorings.MakeMethodNonStatic.ParameterInfo[] GetParameters() { }
        public bool Initialize(JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
    }
    public class LanguageSpecificUtil
    {
        public static JetBrains.Util.Key<object> RECURSIVE_CALL;
        public static JetBrains.ReSharper.Refactorings.MakeMethodNonStatic.IMakeMethodNonStatic GetImplementation(JetBrains.ReSharper.Psi.PsiLanguageType language) { }
        public static JetBrains.ReSharper.Refactorings.MakeMethodNonStatic.IMakeMethodNonStatic GetImplementation(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public static JetBrains.ReSharper.Refactorings.MakeMethodNonStatic.IMakeMethodNonStatic GetImplementation(JetBrains.ReSharper.Psi.ITypeElement typeElement) { }
        public static bool IsDefault(JetBrains.ReSharper.Refactorings.MakeMethodNonStatic.IMakeMethodNonStatic implementation) { }
    }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "MakeMethodNonStatic"})]
    public class MakeMethodNonStaticAction : JetBrains.ReSharper.Refactorings.Workflow.ExtensibleRefactoringAction<JetBrains.ReSharper.Refactorings.MakeMethodNonStatic.IMakeMethodNonStaticWorkflowProvider>
    {
        public const string ACTION_ID = "MakeMethodNonStatic";
        protected override JetBrains.UI.RichText.RichText Caption { get; }
    }
    public class MakeMethodNonStaticPage : JetBrains.UI.CommonControls.SafeUserControl, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage
    {
        public MakeMethodNonStaticPage(JetBrains.ReSharper.Refactorings.MakeMethodNonStatic.MakeMethodNonStaticRefactoring refactoring) { }
        public JetBrains.DataFlow.IProperty<bool> ContinueEnabled { get; }
        public string Description { get; }
        public bool DoNotShow { get; }
        public JetBrains.ReSharper.Psi.PsiLanguageType Language { get; }
        public string Title { get; }
        public JetBrains.UI.CrossFramework.EitherControl View { get; }
        public JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage Commit(JetBrains.Application.Progress.IProgressIndicator pi) { }
        public bool Initialize(JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
        public bool RefreshContents(JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
        public void SetDecoratedControl(JetBrains.ReSharper.Refactorings.MakeMethodNonStatic.MakeMethodNonStaticPage.IMakeMethodNonStaticControl testControl) { }
        public interface IMakeMethodNonStaticControl
        {
            JetBrains.DataFlow.IProperty<bool> ContinueEnabled { get; }
            JetBrains.ReSharper.Refactorings.MakeMethodNonStatic.PreExecutionStage Commit(JetBrains.ReSharper.Refactorings.MakeMethodNonStatic.InitializedStage stage);
            void Initialize(JetBrains.ReSharper.Refactorings.MakeMethodNonStatic.InitializedStage stage);
        }
    }
    public class MakeMethodNonStaticRefactoring : JetBrains.ReSharper.Refactorings.Util.StagedRefactoringBase
    {
        public MakeMethodNonStaticRefactoring(JetBrains.ProjectModel.ISolution solution) { }
        public JetBrains.ReSharper.Psi.PsiLanguageType Language { get; set; }
    }
    public class MakeMethodNonStaticRefactoringWorkflow : JetBrains.ReSharper.Refactorings.Workflow.RefactoringWorkflowBase
    {
        public MakeMethodNonStaticRefactoringWorkflow(JetBrains.ProjectModel.ISolution solution) { }
        public override JetBrains.ReSharper.Refactorings.Workflow.RefactoringActionGroup ActionGroup { get; }
        public override string ActionId { get; }
        public override JetBrains.ReSharper.Refactorings.Conflicts.IConflictSearcher ConflictSearcher { get; }
        public override JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage FirstPendingRefactoringPage { get; }
        public override bool HasUI { get; }
        public override string HelpKeyword { get; }
        public override JetBrains.UI.Icons.IconId Icon { get; }
        public override bool MightModifyManyDocuments { get; }
        public override JetBrains.ProjectModel.ISolution Solution { get; }
        public override string Title { get; }
        public override bool Execute(JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
        public override bool Initialize(JetBrains.Application.DataContext.IDataContext context) { }
        public override bool IsAvailable(JetBrains.Application.DataContext.IDataContext context) { }
        public override bool PostExecute(JetBrains.Application.Progress.IProgressIndicator pi) { }
        public override bool PreExecute(JetBrains.Application.Progress.IProgressIndicator taskExecutorCreator) { }
    }
    public struct ParameterInfo
    {
        public readonly int Index;
        public readonly string Name;
        public readonly JetBrains.ReSharper.Psi.IType Type;
        public ParameterInfo(JetBrains.ReSharper.Psi.IType type, string name, int index) { }
        public bool VisibilityChangeAllowed { get; }
    }
    public class PreExecutionStage : JetBrains.ReSharper.Refactorings.Util.IRefactoringStage
    {
        public PreExecutionStage(JetBrains.ReSharper.Refactorings.Util.IRefactoringStage previousStage, int thisParameterIndex, JetBrains.ReSharper.Psi.AccessRights accessRights) { }
        public JetBrains.ReSharper.Psi.AccessRights AccessRights { get; }
        public JetBrains.ReSharper.Psi.ITypeElement[] ImmediateImplementations { get; }
        public bool IsValid { get; }
        public JetBrains.ReSharper.Psi.ITypeElement MethodOwner { get; }
        public System.Collections.Generic.Dictionary<JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.ReSharper.Psi.Resolve.ISubstitution> MethodUsages { get; }
        public JetBrains.ReSharper.Refactorings.MakeMethodNonStatic.InitializedStage PreviousStage { get; }
        public int ThisParameterIndex { get; }
        public JetBrains.ReSharper.Refactorings.Util.IRefactoringStage Clone(JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
        public bool Initialize(JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
    }
}
namespace JetBrains.ReSharper.Refactorings.Move.AdjustNamespaces
{
    
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "Refactorings.AdjustNamespaces"})]
    public class AdjustNamespacesAction : JetBrains.ReSharper.Refactorings.Workflow.ExtensibleRefactoringAction<JetBrains.ReSharper.Refactorings.Move.AdjustNamespaces.IAdjustNamespacesWorkflowProvider>
    {
        public const string ACTION_ID = "Refactorings.AdjustNamespaces";
        protected override JetBrains.UI.RichText.RichText Caption { get; }
    }
    public class AdjustNamespacesBase : JetBrains.ReSharper.Refactorings.Common.RefactoringExecBase<JetBrains.ReSharper.Refactorings.Move.AdjustNamespaces.AdjustNamespacesWorkflow, JetBrains.ReSharper.Refactorings.Move.AdjustNamespaces.AdjustNamespacesRefactoring>
    {
        public AdjustNamespacesBase(JetBrains.ReSharper.Refactorings.Move.AdjustNamespaces.AdjustNamespacesWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
    }
    public class AdjustNamespacesHelperBase : JetBrains.ReSharper.Refactorings.IWorkflowExec, JetBrains.ReSharper.Refactorings.Util.NewTypeImages.IResolveImagesLanguageSupport
    {
        public virtual bool IsLanguageSupported { get; }
        public virtual bool FileHasProblems(JetBrains.ReSharper.Psi.Tree.IFile file, string ns) { }
        public virtual void FixFile(JetBrains.ReSharper.Psi.Tree.IFile file, string name, JetBrains.ReSharper.Refactorings.Util.NewTypeImages.ResolveImagesRepository repository, System.Collections.Generic.List<JetBrains.ReSharper.Psi.IDeclaredElement> elements) { }
        public virtual JetBrains.ReSharper.Psi.IDeclaredElement GetImportedSymbolOfUsing(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public virtual System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Tree.ITypeDeclaration> GetTopLevelTypeDeclarations(JetBrains.ReSharper.Psi.Tree.IFile file) { }
        public virtual System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Tree.ITreeNode> GetUsingsFromFile(JetBrains.ReSharper.Psi.Tree.IFile file, System.Collections.Generic.IList<JetBrains.ReSharper.Psi.INamespace> namespaces) { }
        public virtual bool IsExternallyVisibleSymbol(JetBrains.ReSharper.Psi.IDeclaredElement element) { }
        public virtual bool IsFromExtendsList(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public virtual bool IsReferenceName(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public virtual void RemoveUnusedUsing(JetBrains.ReSharper.Psi.Tree.IFile file, System.Collections.Generic.JetHashSet<JetBrains.ReSharper.Psi.Tree.ITreeNode> usings) { }
        public virtual void RemoveUsing(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public virtual void SaveUnusedUsings(JetBrains.ReSharper.Psi.Tree.IFile file, JetBrains.ReSharper.Refactorings.Move.Common.UnusedUsingSaver saver) { }
    }
    public class AdjustNamespacesRefactoring : JetBrains.ReSharper.Refactorings.Common.DrivenRefactoring<JetBrains.ReSharper.Refactorings.Move.AdjustNamespaces.AdjustNamespacesWorkflow, JetBrains.ReSharper.Refactorings.Move.AdjustNamespaces.AdjustNamespacesBase>
    {
        public AdjustNamespacesRefactoring(JetBrains.ReSharper.Refactorings.Move.AdjustNamespaces.AdjustNamespacesWorkflow workFlow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        protected override JetBrains.ReSharper.Refactorings.Move.AdjustNamespaces.AdjustNamespacesBase CreateUnsupportedRefactoring() { }
        public override bool Execute(JetBrains.Application.Progress.IProgressIndicator pi) { }
    }
    public sealed class AdjustNamespacesWorkflow : JetBrains.ReSharper.Refactorings.WorkflowNew.DrivenRefactoringWorkflow2<JetBrains.ReSharper.Refactorings.Move.AdjustNamespaces.AdjustNamespacesHelperBase>
    {
        public AdjustNamespacesWorkflow(JetBrains.ProjectModel.ISolution solution, string actionId) { }
        public override JetBrains.ReSharper.Refactorings.Workflow.RefactoringActionGroup ActionGroup { get; }
        public System.Collections.Generic.JetHashSet<string> AffectedNamespaceNames { get; }
        public JetBrains.ReSharper.Refactorings.Move.AdjustNamespaces.Impl.ClassPartsCollector Collector { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Refactorings.Move.AdjustNamespaces.Impl.AdjustNamespacesDataProvider DataProvider { get; }
        public override JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage FirstPendingRefactoringPage { get; }
        public override string HelpKeyword { get; }
        public override bool MightModifyManyDocuments { get; }
        public System.Collections.Generic.Dictionary<JetBrains.ProjectModel.IProjectFile, System.Collections.Generic.List<JetBrains.ReSharper.Psi.IDeclaredElement>> NotAffectedImportedSymbols { get; }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Refactorings.Move.AdjustNamespaces.Impl.ProjectFileWrapper> ProjectFiles { get; set; }
        public override string Title { get; }
        public JetBrains.TreeModels.TreeSimpleModel CreateAndInitializeModel() { }
        protected override JetBrains.ReSharper.Refactorings.Move.AdjustNamespaces.AdjustNamespacesHelperBase CreateHelper(JetBrains.ReSharper.Refactorings.IRefactoringLanguageService service) { }
        public override JetBrains.ReSharper.Refactorings.Workflow.IRefactoringExecuter CreateRefactoring(JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        protected override JetBrains.ReSharper.Refactorings.Move.AdjustNamespaces.AdjustNamespacesHelperBase CreateUnsupportedHelper() { }
        public System.Collections.Generic.IList<JetBrains.ProjectModel.IProjectModelElement> EvaluateEnvolvedProjectItems(JetBrains.ReSharper.Psi.Tree.ITypeAndNamespaceHolderDeclaration declaration) { }
        public void FilterInconsistentFiles(JetBrains.Application.Progress.IProgressIndicator pi) { }
        public override bool Initialize(JetBrains.Application.DataContext.IDataContext context) { }
        public override bool IsAvailable(JetBrains.Application.DataContext.IDataContext context) { }
        public bool IsInMoveScope(JetBrains.ReSharper.Psi.Tree.ITreeNode declaration) { }
        public bool IsInMoveScope(JetBrains.ProjectModel.IProjectFile projectFile) { }
        public bool IsValid() { }
        public void MakeActionWithMultyPsi(JetBrains.ReSharper.Refactorings.Move.AdjustNamespaces.Impl.ProjectFileWrapper wrapper, System.Action<JetBrains.ReSharper.Psi.Tree.IFile, JetBrains.ReSharper.Psi.PsiLanguageType> action) { }
        public void MakeActionWithPsi(JetBrains.ReSharper.Refactorings.Move.AdjustNamespaces.Impl.ProjectFileWrapper wrapper, System.Action<JetBrains.ReSharper.Psi.Tree.IFile, JetBrains.ReSharper.Psi.PsiLanguageType> action) { }
        public override bool PreExecute(JetBrains.Application.Progress.IProgressIndicator pi) { }
        public JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage PrepareClassParts(JetBrains.Application.Progress.IProgressIndicator pi) { }
        public void SetDataProvider(JetBrains.ReSharper.Refactorings.Move.AdjustNamespaces.Impl.AdjustNamespacesDataProvider dataProvider) { }
    }
    [JetBrains.ReSharper.Refactorings.Workflow.RefactoringWorkflowProviderAttribute()]
    public class AdjustNamespacesWorkflowProvider : JetBrains.ReSharper.Feature.Services.ActionsMenu.IWorkflowProvider<JetBrains.ReSharper.Refactorings.Workflow.IRefactoringWorkflow, JetBrains.ReSharper.Refactorings.Workflow.RefactoringActionGroup>, JetBrains.ReSharper.Refactorings.Move.AdjustNamespaces.IAdjustNamespacesWorkflowProvider, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringWorkflowProvider
    {
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Refactorings.Workflow.IRefactoringWorkflow> CreateWorkflow(JetBrains.Application.DataContext.IDataContext dataContext) { }
    }
    public interface IAdjustNamespacesWorkflowProvider : JetBrains.ReSharper.Feature.Services.ActionsMenu.IWorkflowProvider<JetBrains.ReSharper.Refactorings.Workflow.IRefactoringWorkflow, JetBrains.ReSharper.Refactorings.Workflow.RefactoringActionGroup>, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringWorkflowProvider { }
}
namespace JetBrains.ReSharper.Refactorings.Move.AdjustNamespaces.Impl
{
    
    public class AdjustNamespaceRunner
    {
        public AdjustNamespaceRunner(JetBrains.ReSharper.Refactorings.Move.AdjustNamespaces.AdjustNamespacesWorkflow workflow) { }
        public bool Execute(JetBrains.Application.Progress.IProgressIndicator pi) { }
    }
    public class AdjustNamespacesDataProvider
    {
        public AdjustNamespacesDataProvider(System.Collections.Generic.List<string> conflicts) { }
        public System.Collections.Generic.List<string> Conflicts { get; }
        public void CommitConflicts(System.Collections.Generic.IList<JetBrains.ReSharper.Refactorings.Move.Conflicts.IRefactoringConflict> conflicts) { }
    }
    public class AdjustNamespacesPage : System.Windows.Forms.UserControl, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage
    {
        public AdjustNamespacesPage(JetBrains.ReSharper.Refactorings.Move.AdjustNamespaces.AdjustNamespacesWorkflow workflow) { }
        public JetBrains.DataFlow.IProperty<bool> ContinueEnabled { get; }
        public string Description { get; }
        public bool DoNotShow { get; }
        public string Title { get; }
        public JetBrains.UI.CrossFramework.EitherControl View { get; }
        public JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage Commit(JetBrains.Application.Progress.IProgressIndicator pi) { }
        protected override void Dispose(bool disposing) { }
        public bool Initialize(JetBrains.Application.Progress.IProgressIndicator pi) { }
        public bool RefreshContents(JetBrains.Application.Progress.IProgressIndicator pi) { }
    }
    public class AdjustNamespaceTreeView : JetBrains.UI.TreeView.TreeModelViewChecked
    {
        public AdjustNamespaceTreeView(JetBrains.TreeModels.TreeModel model, JetBrains.UI.TreeView.ITreeViewController controller) { }
    }
    public class AdjustNamespaceTreeViewController : JetBrains.UI.TreeView.TreeViewController
    {
        public AdjustNamespaceTreeViewController() { }
    }
    public class AdjustNamespaceTreeViewPresenter : JetBrains.ReSharper.Features.Shared.TreePsiBrowser.TreeModelBrowserPresenter
    {
        protected override void PresentObject(object value, JetBrains.CommonControls.IPresentableItem item, JetBrains.TreeModels.TreeModelNode modelNode, JetBrains.UI.TreeView.PresentationState state) { }
    }
    public class ClassPartsCollector
    {
        public ClassPartsCollector(JetBrains.ReSharper.Refactorings.Move.AdjustNamespaces.AdjustNamespacesWorkflow workflow) { }
        public System.Collections.Generic.JetHashSet<JetBrains.ReSharper.Psi.INamespace> EmptyNamespaceCandidates { get; }
        public System.Collections.Generic.Dictionary<JetBrains.ProjectModel.IProjectFile, System.Collections.Generic.List<JetBrains.ReSharper.Psi.IDeclaredElement>> ImportedSymbols { get; }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Psi.IDeclaredElement> TopmostElements { get; }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Refactorings.Move.Conflicts.IRefactoringConflict> BuildConflicts() { }
        public bool HasConflicts() { }
        public void Register(JetBrains.ReSharper.Psi.Tree.IFile file, string s) { }
    }
    public class FilesCollector : JetBrains.ProjectModel.RecursiveProjectVisitor
    {
        public FilesCollector(System.Collections.Generic.IList<JetBrains.ReSharper.Refactorings.Move.AdjustNamespaces.Impl.ProjectFileWrapper> workflow) { }
        public override void VisitProjectFile(JetBrains.ProjectModel.IProjectFile projectFile) { }
    }
    public class ProjectFileWrapper
    {
        public ProjectFileWrapper(JetBrains.ProjectModel.IProjectFile projectFile) { }
        public ProjectFileWrapper(JetBrains.ProjectModel.IProjectFile projectFile, string properNamespace) { }
        public bool HasProblems { get; set; }
        public bool Included { get; set; }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ProjectModel.IProjectFile ProjectFile { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public string ProperNamespaceName { get; }
    }
}
namespace JetBrains.ReSharper.Refactorings.Move.Common
{
    
    public class static MoveUtil
    {
        public static bool CanContainCodeFiles(JetBrains.ProjectModel.IProjectFolder projectFolder) { }
        public static void CopyFileContent(JetBrains.ReSharper.Psi.Tree.IFile sourceFile, JetBrains.ReSharper.Psi.Tree.IFile targetFile) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ProjectModel.IProjectFile CopyProjectFile(JetBrains.ProjectModel.IProjectFolder targetFolder, JetBrains.ProjectModel.IProjectFile prototypeFile, bool copyContent) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ProjectModel.IProjectFile CreateProjectFileCopy(JetBrains.ProjectModel.IProjectFolder folder, JetBrains.Util.FileSystemPath location, JetBrains.ProjectModel.IProjectFile prototypeFile, bool copyContent) { }
        public static JetBrains.ProjectModel.IProjectFolder CreateProjectFolder(JetBrains.ProjectModel.IProjectFolder folder, JetBrains.Util.FileSystemPath location) { }
        public static System.Collections.Generic.IList<JetBrains.Util.Pair<JetBrains.ReSharper.Psi.Modules.IPsiModule, System.Collections.Generic.List<JetBrains.ReSharper.Psi.INamespace>>> FindEmptyNamespaces(JetBrains.ProjectModel.ISolution solution, System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.INamespace> emptyNamespaceCandidates, JetBrains.Application.Progress.IProgressIndicator pi, System.Func<System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.IDeclaredElement>, bool> allMembersOfNamespaceAreIncluded, JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext context) { }
        public static bool FolderCanContainWebPages(JetBrains.ProjectModel.IProjectFolder projectFolder) { }
        public static void ForEachWithProgressMultyCore<T>(this System.Collections.Generic.ICollection<T> collection, JetBrains.Application.Progress.IProgressIndicator pi, string taskName, System.Action<T, JetBrains.Application.Progress.IProgressIndicator> action) { }
        public static System.Collections.Generic.IList<JetBrains.ReSharper.Psi.INamespace> GetAllOwnerEmptyNamespacesCandidates(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.INamespace> namespaces, string newNamespaceName) { }
        public static System.Collections.Generic.List<JetBrains.ProjectModel.IProjectModelElement> GetNonNestedProjectItems(JetBrains.ProjectModel.IProjectModelElement[] elements, bool filterDependsUpon) { }
        public static System.Collections.Generic.IList<JetBrains.ReSharper.Psi.INamespace> GetPossiblyEmptyNamespaces(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IDeclaredElement> elements) { }
        public static bool IsInternal(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
        public static bool IsPrimaryDeclaration(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration) { }
        public static System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Tree.ITreeNode> SaveUsingsOfEmptyNamespaces(System.Collections.Generic.IEnumerable<JetBrains.Util.Pair<JetBrains.ReSharper.Psi.Modules.IPsiModule, System.Collections.Generic.List<JetBrains.ReSharper.Psi.INamespace>>> emptyNamespaceCandidates, JetBrains.Application.Progress.IProgressIndicator pi, System.Func<JetBrains.ReSharper.Psi.Tree.IFile, System.Collections.Generic.IList<JetBrains.ReSharper.Psi.INamespace>, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Tree.ITreeNode>> getUsagesOfNamespaceFromFile) { }
    }
    public class UnusedUsingSaver
    {
        public UnusedUsingSaver() { }
        public void AddUnusedUsing(JetBrains.ReSharper.Psi.Tree.IFile file, System.Collections.Generic.JetHashSet<JetBrains.ReSharper.Psi.Tree.ITreeNode> usings) { }
        public bool Contains(JetBrains.ReSharper.Psi.Tree.IFile file) { }
        public void RemoveNewRedundantUsings(JetBrains.ReSharper.Refactorings.Move.Common.UnusedUsingSaver.RemoveSingleUsingDlegate remove, JetBrains.Application.Progress.IProgressIndicator pi) { }
        public delegate void RemoveSingleUsingDlegate(JetBrains.ReSharper.Psi.Tree.IFile file, System.Collections.Generic.JetHashSet<JetBrains.ReSharper.Psi.Tree.ITreeNode> oldUnusedUsings, JetBrains.Application.Progress.SubProgressIndicator pi);
    }
}
namespace JetBrains.ReSharper.Refactorings.Move.Conflicts
{
    
    public class ConflictsPage : System.Windows.Forms.UserControl, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage
    {
        public ConflictsPage(System.Collections.Generic.IList<JetBrains.ReSharper.Refactorings.Move.Conflicts.IRefactoringConflict> conflicts, bool canContinue, [JetBrains.Annotations.CanBeNullAttribute()] System.Func<JetBrains.Application.Progress.IProgressIndicator, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage> executeNext) { }
        public JetBrains.DataFlow.IProperty<bool> ContinueEnabled { get; }
        public string Description { get; }
        public bool DoNotShow { get; }
        public string Title { get; }
        public JetBrains.UI.CrossFramework.EitherControl View { get; }
        public JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage Commit(JetBrains.Application.Progress.IProgressIndicator pi) { }
        protected override void Dispose(bool disposing) { }
        public bool Initialize(JetBrains.Application.Progress.IProgressIndicator pi) { }
        public bool RefreshContents(JetBrains.Application.Progress.IProgressIndicator pi) { }
    }
    public class GrouppedConflictsTreePresenter : JetBrains.ReSharper.Features.Shared.TreePsiBrowser.TreeModelBrowserPresenter
    {
        protected override void PresentObject(object value, JetBrains.CommonControls.IPresentableItem item, JetBrains.TreeModels.TreeModelNode modelNode, JetBrains.UI.TreeView.PresentationState state) { }
    }
    public class GrouppedConflictsTreeView : JetBrains.UI.TreeView.TreeModelPresentableView
    {
        public GrouppedConflictsTreeView(JetBrains.TreeModels.TreeModel model, JetBrains.ReSharper.Refactorings.Move.Conflicts.GrouppedConflictsTreeViewController controller) { }
    }
    public class GrouppedConflictsTreeViewController : JetBrains.UI.TreeView.TreeViewController
    {
        public GrouppedConflictsTreeViewController() { }
        public void Navigate(object sender, JetBrains.UI.TreeView.TreeModelView.TreeModelViewNavigateEventArgs e) { }
    }
    public class GrouppedConflictsTreeViewModel : JetBrains.TreeModels.TreeSimpleModel
    {
        public GrouppedConflictsTreeViewModel(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Refactorings.Move.Conflicts.IRefactoringConflict> conflicts) { }
    }
    public interface IRefactoringConflict
    {
        bool IsValid { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Refactorings.Move.Conflicts.IRefactoringConflict ParentConflict { get; }
        JetBrains.ReSharper.Refactorings.Conflicts.ConflictSeverity Severity { get; }
        void Navigate();
        void PresentSelf(JetBrains.CommonControls.IPresentableItem item, JetBrains.UI.TreeView.PresentationState state);
    }
    public class RefactoringConflict : JetBrains.ReSharper.Refactorings.Move.Conflicts.IRefactoringConflict
    {
        public RefactoringConflict([JetBrains.Annotations.NotNullAttribute()] string formatText, JetBrains.ReSharper.Refactorings.Conflicts.ConflictSeverity severity, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Refactorings.Move.Conflicts.IRefactoringConflict parentConflict, object navigationObject, [JetBrains.Annotations.NotNullAttribute()] params object[] args) { }
        public bool IsValid { get; }
        public JetBrains.ReSharper.Refactorings.Move.Conflicts.IRefactoringConflict ParentConflict { get; }
        public JetBrains.ReSharper.Refactorings.Conflicts.ConflictSeverity Severity { get; }
        public void Navigate() { }
        public void PresentSelf(JetBrains.CommonControls.IPresentableItem item, JetBrains.UI.TreeView.PresentationState state) { }
    }
}
namespace JetBrains.ReSharper.Refactorings.Move.Impl
{
    
    public class MoveIntoMatchingFilesDataProvider : JetBrains.ReSharper.Refactorings.Move.MoveIntoMatchingFile.Impl.IMoveIntoMatchingFilesDataProvider
    {
        public MoveIntoMatchingFilesDataProvider(bool moveTypes, bool moveEnums, bool moveDelegates, bool renameFiles, System.Collections.Generic.List<string> conflicts) { }
        public System.Collections.Generic.IList<string> Conflicts { get; set; }
        public bool MoveDelegates { get; }
        public bool MoveEnums { get; }
        public bool MoveTypes { get; }
        public bool RenameFiles { get; }
        public void AddConflict(JetBrains.ReSharper.Refactorings.Move.Conflicts.IRefactoringConflict conflict) { }
    }
    public class MoveToFileDataProvider : JetBrains.ReSharper.Refactorings.Move.MoveTypeDeclarationToFile.IMoveToFileDataProvider
    {
        public MoveToFileDataProvider(string fileName, JetBrains.ReSharper.Psi.Tree.ITypeDeclaration declaration, bool removeOldFile) { }
        public string FileName { get; }
        public bool RemoveOldFile { get; }
        public JetBrains.ReSharper.Psi.Tree.ITypeDeclaration TypeDeclaration { get; }
    }
}
namespace JetBrains.ReSharper.Refactorings.Move.MoveIntoMatchingFile
{
    
    public interface IMoveIntoMatchingFilesWorkflowProvider : JetBrains.ReSharper.Feature.Services.ActionsMenu.IWorkflowProvider<JetBrains.ReSharper.Refactorings.Workflow.IRefactoringWorkflow, JetBrains.ReSharper.Refactorings.Workflow.RefactoringActionGroup>, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringWorkflowProvider { }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "MoveIntoMatchingFiles"})]
    public class MoveIntoMatchingFilesAction : JetBrains.ReSharper.Refactorings.Workflow.ExtensibleRefactoringAction<JetBrains.ReSharper.Refactorings.Move.MoveIntoMatchingFile.IMoveIntoMatchingFilesWorkflowProvider>
    {
        public const string ACTION_ID = "MoveIntoMatchingFiles";
        protected override JetBrains.UI.RichText.RichText Caption { get; }
    }
    public class MoveIntoMatchingFilesBase : JetBrains.ReSharper.Refactorings.Common.RefactoringExecBase<JetBrains.ReSharper.Refactorings.Move.MoveIntoMatchingFile.MoveIntoMatchingFilesWorkflow, JetBrains.ReSharper.Refactorings.Move.MoveIntoMatchingFile.MoveIntoMatchingFilesRefactoring>
    {
        public MoveIntoMatchingFilesBase(JetBrains.ReSharper.Refactorings.Move.MoveIntoMatchingFile.MoveIntoMatchingFilesWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
    }
    public class MoveIntoMatchingFilesHelperBase : JetBrains.ReSharper.Refactorings.IWorkflowExec, JetBrains.ReSharper.Refactorings.Util.NewTypeImages.IResolveImagesLanguageSupport
    {
        public virtual bool IsLanguageSupported { get; }
        public virtual JetBrains.ReSharper.Psi.Tree.INamespaceDeclaration GetOwnerNamespaceDeclaration(JetBrains.ReSharper.Psi.Tree.ITypeDeclaration declaration) { }
        public virtual System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Tree.ITypeDeclaration> GetTopLevelTypeDeclarations(JetBrains.ReSharper.Psi.Tree.IFile file) { }
        public virtual bool IsExternallyVisibleSymbol(JetBrains.ReSharper.Psi.IDeclaredElement element) { }
        public virtual bool IsFromExtendsList(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public virtual bool IsReferenceName(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public virtual void MoveDeclarationFromFile(JetBrains.ReSharper.Refactorings.Move.MoveIntoMatchingFile.Impl.MovedDeclaration declaration, JetBrains.ReSharper.Refactorings.Util.NewTypeImages.ResolveImagesRepository repository) { }
        public virtual void RemoveUnusedUsing(JetBrains.ReSharper.Psi.Tree.IFile file, System.Collections.Generic.JetHashSet<JetBrains.ReSharper.Psi.Tree.ITreeNode> usings) { }
        public virtual void SaveUnusedUsings(JetBrains.ReSharper.Psi.Tree.IFile file, JetBrains.ReSharper.Refactorings.Move.Common.UnusedUsingSaver saver) { }
    }
    public class MoveIntoMatchingFilesPage : System.Windows.Forms.UserControl, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage
    {
        public MoveIntoMatchingFilesPage(JetBrains.ReSharper.Refactorings.Move.MoveIntoMatchingFile.MoveIntoMatchingFilesWorkflow workflow) { }
        public JetBrains.DataFlow.IProperty<bool> ContinueEnabled { get; }
        public string Description { get; }
        public bool DoNotShow { get; }
        public string Title { get; }
        public JetBrains.UI.CrossFramework.EitherControl View { get; }
        public JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage Commit(JetBrains.Application.Progress.IProgressIndicator pi) { }
        protected override void Dispose(bool disposing) { }
        public bool Initialize(JetBrains.Application.Progress.IProgressIndicator pi) { }
        public bool RefreshContents(JetBrains.Application.Progress.IProgressIndicator pi) { }
    }
    public class MoveIntoMatchingFilesRefactoring : JetBrains.ReSharper.Refactorings.Common.DrivenRefactoring<JetBrains.ReSharper.Refactorings.Move.MoveIntoMatchingFile.MoveIntoMatchingFilesWorkflow, JetBrains.ReSharper.Refactorings.Move.MoveIntoMatchingFile.MoveIntoMatchingFilesBase>
    {
        public MoveIntoMatchingFilesRefactoring(JetBrains.ReSharper.Refactorings.Move.MoveIntoMatchingFile.MoveIntoMatchingFilesWorkflow workFlow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public override bool Execute(JetBrains.Application.Progress.IProgressIndicator pi) { }
        public bool IsFromExtendsList(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public bool IsReferenceName(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
    }
    public class MoveIntoMatchingFilesWorkflow : JetBrains.ReSharper.Refactorings.WorkflowNew.DrivenRefactoringWorkflow2<JetBrains.ReSharper.Refactorings.Move.MoveIntoMatchingFile.MoveIntoMatchingFilesHelperBase>
    {
        public MoveIntoMatchingFilesWorkflow(JetBrains.ProjectModel.ISolution solution, string actionId) { }
        public override JetBrains.ReSharper.Refactorings.Workflow.RefactoringActionGroup ActionGroup { get; }
        public JetBrains.ReSharper.Refactorings.Move.MoveIntoMatchingFile.Impl.MoveIntoMatchingFilesCollector Collector { get; }
        public override JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage FirstPendingRefactoringPage { get; }
        public override string HelpKeyword { get; }
        public override bool MightModifyManyDocuments { get; }
        public override string Title { get; }
        public JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage CommitOptions(bool moveTypes, bool moveDelegates, bool moveEnums, JetBrains.Application.Progress.IProgressIndicator pi) { }
        protected override JetBrains.ReSharper.Refactorings.Move.MoveIntoMatchingFile.MoveIntoMatchingFilesHelperBase CreateHelper(JetBrains.ReSharper.Refactorings.IRefactoringLanguageService service) { }
        public override JetBrains.ReSharper.Refactorings.Workflow.IRefactoringExecuter CreateRefactoring(JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        protected override JetBrains.ReSharper.Refactorings.Move.MoveIntoMatchingFile.MoveIntoMatchingFilesHelperBase CreateUnsupportedHelper() { }
        public override bool Initialize(JetBrains.Application.DataContext.IDataContext context) { }
        public override bool IsAvailable(JetBrains.Application.DataContext.IDataContext context) { }
        public bool IsValid() { }
        public void MakeActionWithPsi(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, System.Action<JetBrains.ReSharper.Psi.Tree.IFile, JetBrains.ReSharper.Psi.PsiLanguageType> action) { }
        public override bool PostExecute(JetBrains.Application.Progress.IProgressIndicator pi) { }
        public override bool PreExecute(JetBrains.Application.Progress.IProgressIndicator pi) { }
        public void SetDataProvider(JetBrains.ReSharper.Refactorings.Move.Impl.MoveIntoMatchingFilesDataProvider provider) { }
        public bool ShouldBeMoved(JetBrains.ReSharper.Psi.ITypeElement typeElement) { }
    }
    [JetBrains.ReSharper.Refactorings.Workflow.RefactoringWorkflowProviderAttribute()]
    public class MoveIntoMatchingFilesWorkflowProvider : JetBrains.ReSharper.Feature.Services.ActionsMenu.IWorkflowProvider<JetBrains.ReSharper.Refactorings.Workflow.IRefactoringWorkflow, JetBrains.ReSharper.Refactorings.Workflow.RefactoringActionGroup>, JetBrains.ReSharper.Refactorings.Move.MoveIntoMatchingFile.IMoveIntoMatchingFilesWorkflowProvider, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringWorkflowProvider
    {
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Refactorings.Workflow.IRefactoringWorkflow> CreateWorkflow(JetBrains.Application.DataContext.IDataContext dataContext) { }
    }
}
namespace JetBrains.ReSharper.Refactorings.Move.MoveIntoMatchingFile.Impl
{
    
    public class FilesCollector : JetBrains.ProjectModel.RecursiveProjectVisitor
    {
        public FilesCollector(System.Collections.Generic.IList<JetBrains.ProjectModel.IProjectModelElementPointer> workflow) { }
        public override void VisitProjectFile(JetBrains.ProjectModel.IProjectFile projectFile) { }
    }
    public class FolderFilesCollection
    {
        public FolderFilesCollection(JetBrains.ReSharper.Refactorings.Move.MoveIntoMatchingFile.MoveIntoMatchingFilesWorkflow workflow, JetBrains.ProjectModel.IProjectFolder projectFolder) { }
        public System.Collections.Generic.Dictionary<JetBrains.ProjectModel.IProjectFile, JetBrains.ReSharper.Refactorings.Move.MoveIntoMatchingFile.Impl.MovedDeclarationsCollection> MovedDeclaration { get; }
        public JetBrains.ProjectModel.IProjectFolder ProjectFolder { get; }
        public void CommitFile(JetBrains.ProjectModel.IProjectFile projectFile, JetBrains.ReSharper.Psi.Tree.IFile file, JetBrains.ReSharper.Psi.PsiLanguageType language, JetBrains.Application.Progress.IProgressIndicator pi) { }
        public JetBrains.ReSharper.Refactorings.Move.MoveIntoMatchingFile.Impl.MovedDeclarationsCollection GetCollectionOfProjectFile(JetBrains.ProjectModel.IProjectFile file) { }
        public void RegisterNewFile(JetBrains.ReSharper.Refactorings.Move.MoveIntoMatchingFile.Impl.MovedDeclaration declaration) { }
    }
    public interface IMoveIntoMatchingFilesDataProvider
    {
        bool MoveDelegates { get; }
        bool MoveEnums { get; }
        bool MoveTypes { get; }
        bool RenameFiles { get; }
        void AddConflict(JetBrains.ReSharper.Refactorings.Move.Conflicts.IRefactoringConflict conflicts);
    }
    public class MovedDeclaration
    {
        public MovedDeclaration([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITypeDeclaration typeDeclaration, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Tree.INamespaceDeclaration namespaceDeclaration, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.IProjectFolder ownerFolder, JetBrains.ProjectModel.IProjectFile projectFile, JetBrains.ReSharper.Refactorings.Move.MoveIntoMatchingFile.Impl.MovedDeclarationsCollection collection) { }
        public JetBrains.ReSharper.Refactorings.Move.MoveIntoMatchingFile.Impl.MovedDeclarationsCollection Collection { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ReSharper.Psi.PsiLanguageType Language { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Refactorings.Move.Conflicts.IRefactoringConflict MoveConflict { get; set; }
        public bool MustRename { get; set; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Psi.Tree.INamespaceDeclaration NamespaceDeclaration { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ProjectModel.IProjectFile ProjectFile { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ProjectModel.IProjectFolder ProjectFolder { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public string ProperName { get; set; }
        public bool ShouldBeMoved { get; set; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.Util.FileSystemPath TargetLocation { get; set; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ProjectModel.IProjectFile TargetProjectFile { get; set; }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ReSharper.Psi.Tree.ITypeDeclaration TypeDeclaration { get; }
    }
    public class MovedDeclarationsCollection
    {
        public MovedDeclarationsCollection(JetBrains.ReSharper.Refactorings.Move.MoveIntoMatchingFile.MoveIntoMatchingFilesWorkflow workflow, JetBrains.ReSharper.Refactorings.Move.MoveIntoMatchingFile.Impl.FolderFilesCollection collection, JetBrains.ProjectModel.IProjectFile projectFile, JetBrains.ReSharper.Psi.Tree.IFile file) { }
        public bool AllDeclarationsAreImproper { get; }
        public JetBrains.ReSharper.Refactorings.Move.MoveIntoMatchingFile.Impl.FolderFilesCollection FolderFilesCollection { get; }
        public bool HasImproperDeclarations { get; }
        public System.Collections.Generic.Dictionary<JetBrains.ReSharper.Psi.Tree.ITypeDeclaration, JetBrains.ReSharper.Refactorings.Move.MoveIntoMatchingFile.Impl.MovedDeclaration> MovedDeclarations { get; }
        public void CommitTypeDeclaration(JetBrains.ReSharper.Psi.Tree.ITypeDeclaration typeDeclaration, JetBrains.ReSharper.Psi.Tree.INamespaceDeclaration namespaceDeclaration, JetBrains.ProjectModel.IProjectFile projectFile) { }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Refactorings.Move.MoveIntoMatchingFile.Impl.MovedDeclaration> GetImproperDeclarations() { }
    }
    public class MoveIntoMatchingFilesCollector
    {
        public MoveIntoMatchingFilesCollector(JetBrains.ReSharper.Refactorings.Move.MoveIntoMatchingFile.MoveIntoMatchingFilesWorkflow workflow) { }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Refactorings.Move.MoveIntoMatchingFile.Impl.MovedDeclaration> AllDelclarations() { }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Refactorings.Move.MoveIntoMatchingFile.Impl.MovedDeclaration> AllImproperDelclarations() { }
        public void AssignProperLocations(JetBrains.Application.Progress.IProgressIndicator pi) { }
        public void Commit(System.Collections.Generic.IList<JetBrains.ProjectModel.IProjectModelElementPointer> elementPointers, JetBrains.Application.Progress.IProgressIndicator pi) { }
        public bool CreateRequiredFiles(JetBrains.Application.Progress.IProgressIndicator pi) { }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Refactorings.Move.Conflicts.IRefactoringConflict> GetConflicts() { }
    }
}
namespace JetBrains.ReSharper.Refactorings.Move.MoveToFolder.Impl
{
    
    public class AccessibilityConflictsSearcher
    {
        public readonly JetBrains.Util.OneToListMap<JetBrains.ReSharper.Psi.IDeclaredElement, JetBrains.ReSharper.Psi.Resolve.IReference> UsagesNotAccessible;
        public readonly JetBrains.Util.OneToListMap<JetBrains.ReSharper.Psi.IDeclaredElement, JetBrains.ReSharper.Psi.Resolve.IReference> UsagesNotReferenced;
        public AccessibilityConflictsSearcher(JetBrains.ReSharper.Refactorings.Move.MoveToFolder.MoveToFolderWorkflow workflow) { }
        public JetBrains.ReSharper.Refactorings.Move.MoveToFolder.MoveToFolderWorkflow Workflow { get; }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Refactorings.Move.Conflicts.IRefactoringConflict> GetConflicts(System.Collections.Generic.List<JetBrains.ReSharper.Psi.IDeclaredElement> choosenElementsToMakePublic) { }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Psi.IDeclaredElement> GetElementsToMakePublic() { }
        public void ProcessElement(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public void SearchConflicts(JetBrains.Application.Progress.IProgressIndicator pi) { }
    }
    public class AccessRightsFixer
    {
        public static System.Collections.Generic.IList<JetBrains.ReSharper.Psi.IDeclaredElement> GetElementsToPublic(System.Collections.Generic.IList<JetBrains.ReSharper.Psi.IDeclaredElement> elementsToMakePublic, JetBrains.Application.Progress.IProgressIndicator pi) { }
    }
    public interface IMoveToFolderDataProvider
    {
        bool FixNamespaces { get; set; }
        bool MoveFlat { get; set; }
        JetBrains.ProjectModel.IProjectFolder TargetFolder { get; }
        void AddConflicts(System.Collections.Generic.IList<JetBrains.ReSharper.Refactorings.Move.Conflicts.IRefactoringConflict> conflicts);
        bool IsItemIncluded(JetBrains.ReSharper.Refactorings.Move.MoveToFolder.Impl.MoveToFolderHierarchyItem item);
    }
    public class MoveToFolderDataProvider : JetBrains.ReSharper.Refactorings.Move.MoveToFolder.Impl.IMoveToFolderDataProvider
    {
        public MoveToFolderDataProvider(bool fixNamespaces, bool moveFlat, JetBrains.ProjectModel.IProjectFolder targetFolder, System.Collections.Generic.IList<string> excluded, System.Collections.Generic.List<string> conflicts) { }
        public bool FixNamespaces { get; set; }
        public bool MoveFlat { get; set; }
        public JetBrains.ProjectModel.IProjectFolder TargetFolder { get; }
        public void AddConflicts(System.Collections.Generic.IList<JetBrains.ReSharper.Refactorings.Move.Conflicts.IRefactoringConflict> conflicts) { }
        public bool IsItemIncluded(JetBrains.ReSharper.Refactorings.Move.MoveToFolder.Impl.MoveToFolderHierarchyItem item) { }
    }
    public abstract class MoveToFolderExecuterBase
    {
        protected MoveToFolderExecuterBase(JetBrains.ReSharper.Refactorings.Move.MoveToFolder.MoveToFolderWorkflow workflow) { }
        public bool CanContinue { get; set; }
        public System.Collections.Generic.List<JetBrains.ReSharper.Refactorings.Move.Conflicts.IRefactoringConflict> Conflicts { get; }
        public System.Collections.Generic.JetHashSet<JetBrains.ReSharper.Psi.Tree.ITypeDeclaration> TopLevelMovedTypeDeclarations { get; }
        public JetBrains.ReSharper.Refactorings.Move.MoveToFolder.MoveToFolderWorkflow Workflow { get; }
        public void AddConflict(JetBrains.ReSharper.Refactorings.Move.Conflicts.IRefactoringConflict conflict, bool canContinueRefactoring) { }
        protected abstract void CheckCanCreateFiles();
        public void CommitFirstPage(JetBrains.Application.Progress.IProgressIndicator pi) { }
        protected bool CopyFileAsText(JetBrains.ProjectModel.IProjectFile newFile, JetBrains.ProjectModel.IProjectFile oldFile) { }
        public abstract bool CreateAndAssignProjectFiles(JetBrains.ProjectModel.IProjectFolder folder, System.Collections.Generic.IList<JetBrains.ReSharper.Refactorings.Move.MoveToFolder.Impl.MoveToFolderHierarchyItem> items, JetBrains.Application.Progress.IProgressIndicator pi);
        protected string GetExpectedNamespaceName(JetBrains.ProjectModel.IProjectFile projectFile, JetBrains.ReSharper.Psi.Tree.IFile file) { }
        public abstract bool MoveDeclarations(JetBrains.ReSharper.Refactorings.Move.MoveToFolder.MoveToFolderRefactoring refactoring, JetBrains.Application.Progress.SubProgressIndicator pi);
    }
    public class MoveToFolderExecuterFlat : JetBrains.ReSharper.Refactorings.Move.MoveToFolder.Impl.MoveToFolderExecuterBase
    {
        public MoveToFolderExecuterFlat(JetBrains.ReSharper.Refactorings.Move.MoveToFolder.MoveToFolderWorkflow workflow) { }
        protected virtual void CheckCanCreateFiles() { }
        public override bool CreateAndAssignProjectFiles(JetBrains.ProjectModel.IProjectFolder folder, System.Collections.Generic.IList<JetBrains.ReSharper.Refactorings.Move.MoveToFolder.Impl.MoveToFolderHierarchyItem> items, JetBrains.Application.Progress.IProgressIndicator pi) { }
        public override bool MoveDeclarations(JetBrains.ReSharper.Refactorings.Move.MoveToFolder.MoveToFolderRefactoring refactoring, JetBrains.Application.Progress.SubProgressIndicator pi) { }
    }
    public class MoveToFolderExecuterHierarchical : JetBrains.ReSharper.Refactorings.Move.MoveToFolder.Impl.MoveToFolderExecuterBase
    {
        public MoveToFolderExecuterHierarchical(JetBrains.ReSharper.Refactorings.Move.MoveToFolder.MoveToFolderWorkflow workflow) { }
        protected override void CheckCanCreateFiles() { }
        public override bool CreateAndAssignProjectFiles(JetBrains.ProjectModel.IProjectFolder folder, System.Collections.Generic.IList<JetBrains.ReSharper.Refactorings.Move.MoveToFolder.Impl.MoveToFolderHierarchyItem> items, JetBrains.Application.Progress.IProgressIndicator pi) { }
        public override bool MoveDeclarations(JetBrains.ReSharper.Refactorings.Move.MoveToFolder.MoveToFolderRefactoring refactoring, JetBrains.Application.Progress.SubProgressIndicator pi) { }
    }
    public class MoveToFolderHierarchyDeclarationItem : JetBrains.ReSharper.Refactorings.Move.MoveToFolder.Impl.MoveToFolderHierarchyItem
    {
        public MoveToFolderHierarchyDeclarationItem(JetBrains.ReSharper.Psi.Tree.ITypeDeclaration typeDeclaration, bool canMoveAlone, bool initiallyIncluded, JetBrains.ReSharper.Refactorings.Move.MoveToFolder.Impl.MoveToFolderHierarchyProjectItem parent, JetBrains.ReSharper.Psi.ITypeElement declaredElement) { }
        public override bool IsValid { get; }
        public System.Collections.Generic.List<JetBrains.ReSharper.Psi.Tree.IDeclaration> NotIncludedDeclarations { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public string OwnerNamespaceName { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ReSharper.Psi.ITreeNodePointer<JetBrains.ReSharper.Psi.Tree.ITypeDeclaration> Pointer { get; }
        public override void AnalyseParts(JetBrains.ReSharper.Refactorings.Move.MoveToFolder.Impl.MoveToFolderExecuterBase executer) { }
        public override void CommitDeclarations(JetBrains.ReSharper.Refactorings.Move.MoveToFolder.MoveToFolderRefactoring refactoring) { }
        public override void CommitReferences(JetBrains.ReSharper.Refactorings.Move.MoveToFolder.MoveToFolderRefactoring refactoring) { }
        public override bool ContaintElement(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ProjectModel.IProjectFile file) { }
        public override string GetCanMoveToProjectFolderError(JetBrains.ProjectModel.IProjectFolder projectFolder, JetBrains.ReSharper.Refactorings.Move.MoveToFolder.MoveToFolderWorkflow workflow) { }
    }
    public abstract class MoveToFolderHierarchyItem
    {
        protected MoveToFolderHierarchyItem() { }
        public bool CanMoveAlone { get; set; }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Refactorings.Move.MoveToFolder.Impl.MoveToFolderHierarchyItem> Children { get; }
        public JetBrains.ProjectModel.IProjectFile CreatedProjectFile { get; }
        public bool HasIncludedItems { get; }
        public bool Included { get; set; }
        public abstract bool IsValid { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public string NewProjectFileName { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ProjectModel.IProjectFile PrototypeFile { get; }
        public abstract void AnalyseParts(JetBrains.ReSharper.Refactorings.Move.MoveToFolder.Impl.MoveToFolderExecuterBase hierarchical);
        public static JetBrains.ReSharper.Refactorings.Move.MoveToFolder.Impl.MoveToFolderHierarchyItem BuildFromProjectItem(JetBrains.ProjectModel.IProjectItem projectItem, JetBrains.ReSharper.Refactorings.Move.MoveToFolder.MoveToFolderWorkflow workflow, JetBrains.ReSharper.Refactorings.Move.MoveToFolder.Impl.MoveToFolderHierarchyProjectItem parent) { }
        public abstract void CommitDeclarations(JetBrains.ReSharper.Refactorings.Move.MoveToFolder.MoveToFolderRefactoring refactoring);
        public abstract void CommitReferences(JetBrains.ReSharper.Refactorings.Move.MoveToFolder.MoveToFolderRefactoring refactoring);
        public abstract bool ContaintElement(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ProjectModel.IProjectFile file);
        public virtual string GetCanMoveToProjectFolderError([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ProjectModel.IProjectFolder projectFolder, JetBrains.ReSharper.Refactorings.Move.MoveToFolder.MoveToFolderWorkflow workflow) { }
        public void SetProjectFile(JetBrains.ProjectModel.IProjectFile projectFile) { }
        public void SetProjectFileName(string newProjectFileName, JetBrains.ProjectModel.IProjectFile prototypeFile) { }
    }
    public class MoveToFolderHierarchyProjectItem : JetBrains.ReSharper.Refactorings.Move.MoveToFolder.Impl.MoveToFolderHierarchyItem
    {
        public MoveToFolderHierarchyProjectItem(JetBrains.ProjectModel.IProjectItem projectItem) { }
        public bool AllChildrenAreMoved { get; }
        public bool AllChildrenAreRemoved { get; }
        public System.Collections.Generic.Dictionary<JetBrains.ProjectModel.IProjectFile, JetBrains.ProjectModel.IProjectFile> CreatedDependentFiles { get; }
        public System.Collections.Generic.List<JetBrains.ProjectModel.IProjectFile> DependentFiles { get; set; }
        public bool HasConflictedNotIncludedItems { get; }
        public bool IsProjectFile { get; }
        public override bool IsValid { get; }
        public bool LanguageIsNotSupported { get; set; }
        public JetBrains.ProjectModel.IProjectItem ProjectItem { get; }
        public bool RemoveThisFile { get; set; }
        public override void AnalyseParts(JetBrains.ReSharper.Refactorings.Move.MoveToFolder.Impl.MoveToFolderExecuterBase executer) { }
        public override void CommitDeclarations(JetBrains.ReSharper.Refactorings.Move.MoveToFolder.MoveToFolderRefactoring refactoring) { }
        public override void CommitReferences(JetBrains.ReSharper.Refactorings.Move.MoveToFolder.MoveToFolderRefactoring refactoring) { }
        public override bool ContaintElement(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ProjectModel.IProjectFile file) { }
        public override string GetCanMoveToProjectFolderError(JetBrains.ProjectModel.IProjectFolder projectFolder, JetBrains.ReSharper.Refactorings.Move.MoveToFolder.MoveToFolderWorkflow workflow) { }
        public void SetDependentProjectFile(JetBrains.ProjectModel.IProjectFile oldFile, JetBrains.ProjectModel.IProjectFile newFile) { }
    }
}
namespace JetBrains.ReSharper.Refactorings.Move.MoveToFolder
{
    
    public class MoveToFolderBase : JetBrains.ReSharper.Refactorings.Common.RefactoringExecBase<JetBrains.ReSharper.Refactorings.Move.MoveToFolder.MoveToFolderWorkflow, JetBrains.ReSharper.Refactorings.Move.MoveToFolder.MoveToFolderRefactoring>
    {
        public MoveToFolderBase(JetBrains.ReSharper.Refactorings.Move.MoveToFolder.MoveToFolderWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
    }
    public class MoveToFolderHelperBase : JetBrains.ReSharper.Refactorings.IWorkflowExec, JetBrains.ReSharper.Refactorings.Util.NewTypeImages.IResolveImagesLanguageSupport
    {
        public virtual bool CanMoveSingleTypeDeclaration { get; }
        public virtual bool IsLanguageSupported { get; }
        public virtual bool DeclarationCanProvideName(JetBrains.ReSharper.Psi.Tree.ITypeDeclaration declaration) { }
        public virtual string GetCanMoveToProjectFolderError(JetBrains.ProjectModel.IProjectFolder projectFolder) { }
        public virtual System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Tree.ITypeDeclaration> GetTopLevelTypeDeclarations(JetBrains.ReSharper.Psi.Tree.IFile file) { }
        public virtual System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Tree.ITreeNode> GetUsingsFromFile(JetBrains.ReSharper.Psi.Tree.IFile file, System.Collections.Generic.IList<JetBrains.ReSharper.Psi.INamespace> namespaces) { }
        public virtual bool IsExternallyVisibleSymbol(JetBrains.ReSharper.Psi.IDeclaredElement element) { }
        public virtual bool IsFromExtendsList(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public virtual bool IsReferenceName(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public virtual void MakePublic(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration) { }
        public virtual bool MoveFewDeclarations(JetBrains.ReSharper.Psi.Tree.IFile sourceFile, JetBrains.ReSharper.Psi.Tree.IFile targetFile, bool fixNamespaces, string name, JetBrains.ReSharper.Refactorings.Util.NewTypeImages.ResolveImagesRepository repository, System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Tree.ITypeDeclaration> children) { }
        public virtual bool MoveSingleDeclaration(JetBrains.ReSharper.Psi.Tree.ITypeDeclaration typeDeclaration, JetBrains.ReSharper.Psi.Tree.IFile targetFile, string expectedNamespaceName, JetBrains.ReSharper.Refactorings.Util.NewTypeImages.ResolveImagesRepository repository) { }
        public virtual bool MoveWholeFile(JetBrains.ReSharper.Psi.Tree.IFile sourceFile, JetBrains.ReSharper.Psi.Tree.IFile targetFile, bool fixNamespaces, string name, JetBrains.ReSharper.Refactorings.Util.NewTypeImages.ResolveImagesRepository repository) { }
        public virtual void RemoveUnusedUsing(JetBrains.ReSharper.Psi.Tree.IFile file, System.Collections.Generic.JetHashSet<JetBrains.ReSharper.Psi.Tree.ITreeNode> usings) { }
        public virtual void RemoveUsing(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public virtual void SaveUnusedUsings(JetBrains.ReSharper.Psi.Tree.IFile file, JetBrains.ReSharper.Refactorings.Move.Common.UnusedUsingSaver saver) { }
    }
    public class MoveToFolderRefactoring : JetBrains.ReSharper.Refactorings.Common.DrivenRefactoring<JetBrains.ReSharper.Refactorings.Move.MoveToFolder.MoveToFolderWorkflow, JetBrains.ReSharper.Refactorings.Move.MoveToFolder.MoveToFolderBase>
    {
        public MoveToFolderRefactoring(JetBrains.ReSharper.Refactorings.Move.MoveToFolder.MoveToFolderWorkflow workFlow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public JetBrains.ReSharper.Refactorings.Util.NewTypeImages.ResolveImagesRepository Repository { get; }
        public override bool Execute(JetBrains.Application.Progress.IProgressIndicator pi) { }
        public bool IsFromExtendsList(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public bool IsReferenceName(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
    }
    public class MoveToFolderWorkflow : JetBrains.ReSharper.Refactorings.WorkflowNew.DrivenRefactoringWorkflow2<JetBrains.ReSharper.Refactorings.Move.MoveToFolder.MoveToFolderHelperBase>
    {
        public MoveToFolderWorkflow(JetBrains.ProjectModel.ISolution solution, string actionId) { }
        public override JetBrains.ReSharper.Refactorings.Workflow.RefactoringActionGroup ActionGroup { get; }
        public System.Collections.Generic.List<JetBrains.ReSharper.Psi.IDeclaredElement> ChoosenElementsToMakePublic { get; }
        public override JetBrains.ReSharper.Refactorings.Conflicts.IConflictSearcher ConflictSearcher { get; }
        public bool CopyHierarchy { get; set; }
        public JetBrains.ProjectModel.IProjectFolder DefaultSourceFolder { get; }
        public JetBrains.ReSharper.Refactorings.Move.MoveToFolder.Impl.MoveToFolderExecuterBase Executer { get; }
        public System.Collections.Generic.List<JetBrains.Util.Pair<JetBrains.ReSharper.Psi.IPathDeclaredElement, JetBrains.ReSharper.Psi.IPathDeclaredElement>> FileElementCorrespondence { get; }
        public override JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage FirstPendingRefactoringPage { get; }
        public bool FixNamespaces { get; }
        public JetBrains.ProjectModel.IProjectFolder FolderInUi { get; }
        public bool FromDeclaration { get; }
        public override string HelpKeyword { get; }
        public override bool MightModifyManyDocuments { get; }
        public bool MoveToSameProject { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Tree.IDeclaration> PreselectedDeclarations { get; }
        public JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext ResolveContext { get; }
        public System.Collections.Generic.List<JetBrains.ReSharper.Refactorings.Move.MoveToFolder.Impl.MoveToFolderHierarchyItem> RootHierarchyItems { get; }
        public JetBrains.ProjectModel.Properties.ProjectLanguage SourceLanguageType { get; }
        public JetBrains.ProjectModel.IProjectFolder TargetFolder { get; }
        public override string Title { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Refactorings.Move.MoveToFolder.Impl.MoveToFolderHierarchyItem> AllHierarchyItems() { }
        public bool CheckFolderExists(string folderName) { }
        public bool CheckFolderIsDisjoint(string folderName) { }
        public bool CheckHasNotConflictedSelection() { }
        public bool CheckSelectionEmpty() { }
        public bool CheckTargetProjectLanguage(string folderName) { }
        public JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage CommitCheckedPublicDeclartionsPage(JetBrains.Application.Progress.IProgressIndicator pi, System.Collections.Generic.List<JetBrains.ReSharper.Psi.IDeclaredElement> declaredElements) { }
        public JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage CommitFirstPage(bool fixNamespaces, JetBrains.Application.Progress.IProgressIndicator pi, bool copyHierarchy, string folderName, bool fixAccessibility) { }
        protected override JetBrains.ReSharper.Refactorings.Move.MoveToFolder.MoveToFolderHelperBase CreateHelper(JetBrains.ReSharper.Refactorings.IRefactoringLanguageService service) { }
        public override JetBrains.ReSharper.Refactorings.Workflow.IRefactoringExecuter CreateRefactoring(JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        protected override JetBrains.ReSharper.Refactorings.Move.MoveToFolder.MoveToFolderHelperBase CreateUnsupportedHelper() { }
        public void FolderHasChanged(JetBrains.ProjectModel.IProjectFolder folder) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Tree.ITypeDeclaration> GetAllMovedDeclarations() { }
        public bool GetSupportedProperty(JetBrains.ProjectModel.IProjectFile projectFile) { }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Tree.ITypeDeclaration> GetTopLevelTypeDeclarations(JetBrains.ProjectModel.IProjectFile projectFile) { }
        public bool HasSupportedPsi(JetBrains.ProjectModel.IProjectFile projectFile) { }
        public override bool Initialize(JetBrains.Application.DataContext.IDataContext context) { }
        public override bool IsAvailable(JetBrains.Application.DataContext.IDataContext context) { }
        public bool IsValid() { }
        public void MakeActionWithPsi([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, System.Action<JetBrains.ReSharper.Psi.Tree.IFile, JetBrains.ReSharper.Psi.PsiLanguageType> action) { }
        public override bool PostExecute(JetBrains.Application.Progress.IProgressIndicator pi) { }
        public override bool PreExecute(JetBrains.Application.Progress.IProgressIndicator pi) { }
        public string PresentDefaultFolder() { }
        public void SetAllItemsChecked() { }
        public void SetDataProvider(JetBrains.ReSharper.Refactorings.Move.MoveToFolder.Impl.IMoveToFolderDataProvider provider) { }
    }
    [JetBrains.ReSharper.Refactorings.Workflow.RefactoringWorkflowProviderAttribute()]
    public class MoveToFolderWorkflowProvider : JetBrains.ReSharper.Refactorings.MoveWorkflowProvider
    {
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Refactorings.Workflow.IRefactoringWorkflow> CreateWorkflow(JetBrains.Application.DataContext.IDataContext dataContext) { }
    }
}
namespace JetBrains.ReSharper.Refactorings.Move.MoveToFolder.Pages
{
    
    public class CheckDeclarationsToMakePublicPage : System.Windows.Forms.UserControl, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage
    {
        public CheckDeclarationsToMakePublicPage(JetBrains.ReSharper.Refactorings.Move.MoveToFolder.MoveToFolderWorkflow workflow, System.Collections.Generic.List<JetBrains.Util.Pair<JetBrains.ReSharper.Psi.IDeclaredElement, bool>> includedInternalElements) { }
        public JetBrains.DataFlow.IProperty<bool> ContinueEnabled { get; }
        public string Description { get; }
        public bool DoNotShow { get; }
        public string Title { get; }
        public JetBrains.UI.CrossFramework.EitherControl View { get; }
        public JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage Commit(JetBrains.Application.Progress.IProgressIndicator pi) { }
        protected override void Dispose(bool disposing) { }
        public bool Initialize(JetBrains.Application.Progress.IProgressIndicator pi) { }
        public bool RefreshContents(JetBrains.Application.Progress.IProgressIndicator pi) { }
    }
    public class MoveToFolderPage : System.Windows.Forms.UserControl, JetBrains.CommonControls.Validation.IValidatorProvider, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage
    {
        public MoveToFolderPage() { }
        public MoveToFolderPage(JetBrains.ReSharper.Refactorings.Move.MoveToFolder.MoveToFolderWorkflow workflow, JetBrains.ReSharper.Refactorings.Move.MoveToFolder.Pages.MoveToFolderTreeView treeView) { }
        public JetBrains.DataFlow.IProperty<bool> ContinueEnabled { get; }
        public string Description { get; }
        public bool DoNotShow { get; }
        public string Title { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.CommonControls.Validation.IValidator> Validators { get; }
        public JetBrains.UI.CrossFramework.EitherControl View { get; }
        public JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage Commit(JetBrains.Application.Progress.IProgressIndicator pi) { }
        protected override void Dispose(bool disposing) { }
        public bool Initialize(JetBrains.Application.Progress.IProgressIndicator pi) { }
        public bool RefreshContents(JetBrains.Application.Progress.IProgressIndicator pi) { }
    }
    public class MoveToFolderPresenter : JetBrains.ReSharper.Features.Shared.TreePsiBrowser.TreeModelBrowserPresenter
    {
        public MoveToFolderPresenter(JetBrains.ReSharper.Refactorings.Move.MoveToFolder.MoveToFolderWorkflow workflow, JetBrains.ReSharper.Refactorings.Move.MoveToFolder.Pages.MoveToFolderTreeController treeController) { }
        public JetBrains.ReSharper.Refactorings.Move.MoveToFolder.MoveToFolderWorkflow Workflow { get; }
        protected override void PresentObject(object value, JetBrains.CommonControls.IPresentableItem item, JetBrains.TreeModels.TreeModelNode modelNode, JetBrains.UI.TreeView.PresentationState state) { }
    }
    public class MoveToFolderTreeController : JetBrains.UI.TreeView.TreeViewController
    {
        public MoveToFolderTreeController(JetBrains.ReSharper.Refactorings.Move.MoveToFolder.MoveToFolderWorkflow workflow) { }
        public override bool ExpandNodeInitially(JetBrains.TreeModels.TreeModelNode modelNode) { }
        public void Navigate(object sender, JetBrains.UI.TreeView.TreeModelView.TreeModelViewNavigateEventArgs e) { }
        public override bool QuickSearchMatches(JetBrains.TreeModels.TreeModelNode modelNode, string quickSearchText) { }
    }
    public class MoveToFolderTreeView : JetBrains.UI.TreeView.TreeModelViewChecked
    {
        public MoveToFolderTreeView(JetBrains.TreeModels.TreeModel model, JetBrains.ReSharper.Refactorings.Move.MoveToFolder.Pages.MoveToFolderTreeController controller, JetBrains.ReSharper.Refactorings.Move.MoveToFolder.MoveToFolderWorkflow workflow) { }
    }
}
namespace JetBrains.ReSharper.Refactorings.Move.MoveToNamespace
{
    
    public interface IMoveToNamespaceDataProvider
    {
        string NewNamespace { get; }
    }
    public class MoveToNamespaceBase : JetBrains.ReSharper.Refactorings.Common.RefactoringExecBase<JetBrains.ReSharper.Refactorings.Move.MoveToNamespace.MoveToNamespaceWorkflow, JetBrains.ReSharper.Refactorings.Move.MoveToNamespace.MoveToNamespaceRefactoring>
    {
        public MoveToNamespaceBase(JetBrains.ReSharper.Refactorings.Move.MoveToNamespace.MoveToNamespaceWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
    }
    public class MoveToNamespaceDataProvider : JetBrains.ReSharper.Refactorings.Move.MoveToNamespace.IMoveToNamespaceDataProvider
    {
        public MoveToNamespaceDataProvider(string newNamespace) { }
        public string NewNamespace { get; }
    }
    public class MoveToNamespaceHelperBase : JetBrains.ReSharper.Refactorings.IWorkflowExec, JetBrains.ReSharper.Refactorings.Util.NewTypeImages.IResolveImagesLanguageSupport
    {
        public virtual bool IsLanguageSupported { get; }
        public virtual System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Tree.ITreeNode> GetUsingsFromFile(JetBrains.ReSharper.Psi.Tree.IFile file, System.Collections.Generic.IList<JetBrains.ReSharper.Psi.INamespace> namespaces) { }
        public virtual bool IsExternallyVisibleSymbol(JetBrains.ReSharper.Psi.IDeclaredElement element) { }
        public virtual bool IsFromExtendsList(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public virtual bool IsReferenceName(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public virtual void MovePrimaryDeclaration(JetBrains.ReSharper.Psi.Tree.ITypeDeclaration typeDeclaration, string newNamespaceName, JetBrains.ReSharper.Refactorings.Util.NewTypeImages.ResolveImagesRepository repository) { }
        public virtual void RegisterSecondaryDeclaration(JetBrains.ReSharper.Psi.Tree.ITypeDeclaration typeDeclaration, string targetNamespaceName, JetBrains.ReSharper.Refactorings.Util.NewTypeImages.ResolveImagesRepository repository) { }
        public virtual void RemoveUnusedUsing(JetBrains.ReSharper.Psi.Tree.IFile file, System.Collections.Generic.JetHashSet<JetBrains.ReSharper.Psi.Tree.ITreeNode> usings) { }
        public virtual void RemoveUsing(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public virtual void SaveUnusedUsings(JetBrains.ReSharper.Psi.Tree.IFile file, JetBrains.ReSharper.Refactorings.Move.Common.UnusedUsingSaver saver) { }
        public virtual string ValidateNamespaceName(string newNamespace, JetBrains.ReSharper.Psi.Tree.IDeclaration declaration) { }
    }
    public class MoveToNamespacePage : System.Windows.Forms.UserControl, JetBrains.CommonControls.Validation.IValidatorProvider, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage
    {
        public MoveToNamespacePage(JetBrains.ReSharper.Refactorings.Move.MoveToNamespace.MoveToNamespaceWorkflow workflow, JetBrains.ReSharper.Psi.PsiLanguageType language) { }
        public JetBrains.DataFlow.IProperty<bool> ContinueEnabled { get; }
        public string Description { get; }
        public bool DoNotShow { get; }
        public string Title { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.CommonControls.Validation.IValidator> Validators { get; }
        public JetBrains.UI.CrossFramework.EitherControl View { get; }
        public JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage Commit(JetBrains.Application.Progress.IProgressIndicator pi) { }
        protected override void Dispose(bool disposing) { }
        public bool Initialize(JetBrains.Application.Progress.IProgressIndicator pi) { }
        public bool RefreshContents(JetBrains.Application.Progress.IProgressIndicator pi) { }
    }
    [JetBrains.ReSharper.Refactorings.Workflow.RefactoringWorkflowProviderAttribute()]
    public class MoveToNamespaceProvider : JetBrains.ReSharper.Refactorings.MoveWorkflowProvider
    {
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Refactorings.Workflow.IRefactoringWorkflow> CreateWorkflow(JetBrains.Application.DataContext.IDataContext dataContext) { }
    }
    public class MoveToNamespaceRefactoring : JetBrains.ReSharper.Refactorings.Common.DrivenRefactoring<JetBrains.ReSharper.Refactorings.Move.MoveToNamespace.MoveToNamespaceWorkflow, JetBrains.ReSharper.Refactorings.Move.MoveToNamespace.MoveToNamespaceBase>
    {
        public MoveToNamespaceRefactoring(JetBrains.ReSharper.Refactorings.Move.MoveToNamespace.MoveToNamespaceWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public JetBrains.ReSharper.Refactorings.Util.NewTypeImages.ResolveImagesRepository Repository { get; }
        public JetBrains.ReSharper.Psi.ITypeElement TypeElement { get; }
        public override bool Execute(JetBrains.Application.Progress.IProgressIndicator pi) { }
    }
    public class MoveToNamespaceWorkflow : JetBrains.ReSharper.Refactorings.WorkflowNew.DrivenRefactoringWorkflow2<JetBrains.ReSharper.Refactorings.Move.MoveToNamespace.MoveToNamespaceHelperBase>
    {
        public MoveToNamespaceWorkflow(JetBrains.ProjectModel.ISolution solution, string actionId) { }
        public override JetBrains.ReSharper.Refactorings.Workflow.RefactoringActionGroup ActionGroup { get; }
        public override JetBrains.ReSharper.Refactorings.Conflicts.IConflictSearcher ConflictSearcher { get; }
        public override JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage FirstPendingRefactoringPage { get; }
        public override string HelpKeyword { get; }
        public string InitialNamespaceName { get; }
        public JetBrains.ReSharper.Psi.PsiLanguageType LanguageType { get; }
        public override bool MightModifyManyDocuments { get; }
        public string TargetNamespaceName { get; }
        public override string Title { get; }
        public JetBrains.ReSharper.Psi.Pointers.IDeclaredElementPointer<JetBrains.ReSharper.Psi.ITypeElement> TypeElementPointer { get; }
        public bool CheckNamespaceDiffersFromOriginal(string ns) { }
        public bool CheckTypeExist(string ns) { }
        public bool CheckValidName(string ns) { }
        public JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage CommitPage(string ns, JetBrains.Application.Progress.IProgressIndicator pi) { }
        protected override JetBrains.ReSharper.Refactorings.Move.MoveToNamespace.MoveToNamespaceHelperBase CreateHelper(JetBrains.ReSharper.Refactorings.IRefactoringLanguageService service) { }
        public override JetBrains.ReSharper.Refactorings.Workflow.IRefactoringExecuter CreateRefactoring(JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        protected override JetBrains.ReSharper.Refactorings.Move.MoveToNamespace.MoveToNamespaceHelperBase CreateUnsupportedHelper() { }
        public JetBrains.UI.RichText.RichText GetErrorMessageText(string newNamespace) { }
        public override bool Initialize(JetBrains.Application.DataContext.IDataContext context) { }
        public override bool IsAvailable(JetBrains.Application.DataContext.IDataContext context) { }
        public bool IsValid(JetBrains.Application.Progress.IProgressIndicator pi) { }
        public override bool PreExecute(JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
        public void SetDataProvider(JetBrains.ReSharper.Refactorings.Move.MoveToNamespace.IMoveToNamespaceDataProvider dataProvider) { }
    }
}
namespace JetBrains.ReSharper.Refactorings.Move.MoveTypeDeclarationToFile
{
    
    public interface IMoveToFileDataProvider
    {
        string FileName { get; }
        bool RemoveOldFile { get; }
        JetBrains.ReSharper.Psi.Tree.ITypeDeclaration TypeDeclaration { get; }
    }
    public interface IMoveToFileWorkflow : JetBrains.ReSharper.Feature.Services.ActionsMenu.IWorkflow<JetBrains.ReSharper.Refactorings.Workflow.RefactoringActionGroup>, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringWorkflow
    {
        JetBrains.Util.FileSystemPath FileLocation { get; }
        JetBrains.Util.FileSystemPath FolderLocation { get; }
        string NewFileExtension { get; }
        string NewFileName { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ProjectModel.IProjectModelElementPointer ProjectFolderPointer { get; }
        JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage CommitFirstPage(string newFileName, JetBrains.Application.Progress.IProgressIndicator pi);
        bool IsValid();
    }
    public class MoveFileRemoveEmptyFilePage : System.Windows.Forms.UserControl, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage
    {
        public MoveFileRemoveEmptyFilePage(JetBrains.ReSharper.Refactorings.Move.MoveTypeDeclarationToFile.MoveToFileWorkflow workflow) { }
        public JetBrains.DataFlow.IProperty<bool> ContinueEnabled { get; }
        public string Description { get; }
        public bool DoNotShow { get; }
        public string Title { get; }
        public JetBrains.UI.CrossFramework.EitherControl View { get; }
        public JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage Commit(JetBrains.Application.Progress.IProgressIndicator pi) { }
        protected override void Dispose(bool disposing) { }
        public bool Initialize(JetBrains.Application.Progress.IProgressIndicator pi) { }
        public bool RefreshContents(JetBrains.Application.Progress.IProgressIndicator pi) { }
    }
    public class MoveToFileBase : JetBrains.ReSharper.Refactorings.Common.RefactoringExecBase<JetBrains.ReSharper.Refactorings.Move.MoveTypeDeclarationToFile.MoveToFileWorkflow, JetBrains.ReSharper.Refactorings.Move.MoveTypeDeclarationToFile.MoveToFileRefactoring>
    {
        public MoveToFileBase(JetBrains.ReSharper.Refactorings.Move.MoveTypeDeclarationToFile.MoveToFileWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
    }
    public class MoveToFileHelperBase : JetBrains.ReSharper.Refactorings.IWorkflowExec, JetBrains.ReSharper.Refactorings.Util.NewTypeImages.IResolveImagesLanguageSupport
    {
        public virtual bool IsLanguageSupported { get; }
        public virtual bool FileHasOtherDeclarations(JetBrains.ReSharper.Psi.Tree.ITypeDeclaration declaration) { }
        public virtual bool IsExternallyVisibleSymbol(JetBrains.ReSharper.Psi.IDeclaredElement element) { }
        public virtual bool IsFromExtendsList(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public virtual bool IsReferenceName(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public virtual bool MoveDeclaration(JetBrains.ReSharper.Psi.Tree.ITypeDeclaration declaration, JetBrains.ReSharper.Refactorings.Util.NewTypeImages.ResolveImagesRepository repository, JetBrains.ReSharper.Psi.Tree.IFile file, JetBrains.ReSharper.Refactorings.Move.MoveTypeDeclarationToFile.MoveToFileWorkflow workflow) { }
        public virtual void RemoveUnusedUsing(JetBrains.ReSharper.Psi.Tree.IFile file, System.Collections.Generic.JetHashSet<JetBrains.ReSharper.Psi.Tree.ITreeNode> usings) { }
        public virtual void SaveUnusedUsings(JetBrains.ReSharper.Psi.Tree.IFile file, JetBrains.ReSharper.Refactorings.Move.Common.UnusedUsingSaver saver) { }
    }
    public class MoveToFilePage : System.Windows.Forms.UserControl, JetBrains.CommonControls.Validation.IValidatorProvider, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage
    {
        public MoveToFilePage(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.IShellLocks locks, JetBrains.Application.Interop.NativeHook.IWindowsHookManager windowsHookManager, JetBrains.ReSharper.Refactorings.Move.MoveTypeDeclarationToFile.IMoveToFileWorkflow workflow) { }
        public JetBrains.DataFlow.IProperty<bool> ContinueEnabled { get; }
        public string Description { get; }
        public bool DoNotShow { get; }
        public string Title { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.CommonControls.Validation.IValidator> Validators { get; }
        public JetBrains.UI.CrossFramework.EitherControl View { get; }
        public JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage Commit(JetBrains.Application.Progress.IProgressIndicator pi) { }
        protected override void Dispose(bool disposing) { }
        public bool Initialize(JetBrains.Application.Progress.IProgressIndicator pi) { }
        public bool RefreshContents(JetBrains.Application.Progress.IProgressIndicator pi) { }
    }
    public class MoveToFileRefactoring : JetBrains.ReSharper.Refactorings.Common.DrivenRefactoring<JetBrains.ReSharper.Refactorings.Move.MoveTypeDeclarationToFile.MoveToFileWorkflow, JetBrains.ReSharper.Refactorings.Move.MoveTypeDeclarationToFile.MoveToFileBase>
    {
        public MoveToFileRefactoring(JetBrains.ReSharper.Refactorings.Move.MoveTypeDeclarationToFile.MoveToFileWorkflow workFlow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public override bool Execute(JetBrains.Application.Progress.IProgressIndicator pi) { }
    }
    public class static MoveToFileUtils
    {
        public static bool CheckExtension(this JetBrains.ReSharper.Refactorings.Move.MoveTypeDeclarationToFile.IMoveToFileWorkflow moveToFileWorkflow, string name) { }
        public static bool CheckFileExistOnDisk(this JetBrains.ReSharper.Refactorings.Move.MoveTypeDeclarationToFile.IMoveToFileWorkflow moveToFileWorkflow, string name) { }
        public static bool CheckSameFile(this JetBrains.ReSharper.Refactorings.Move.MoveTypeDeclarationToFile.IMoveToFileWorkflow moveToFileWorkflow, string name) { }
        public static bool CheckValidName(string name) { }
    }
    public class MoveToFileWorkflow : JetBrains.ReSharper.Refactorings.WorkflowNew.DrivenRefactoringWorkflow2<JetBrains.ReSharper.Refactorings.Move.MoveTypeDeclarationToFile.MoveToFileHelperBase>, JetBrains.ReSharper.Feature.Services.ActionsMenu.IWorkflow<JetBrains.ReSharper.Refactorings.Workflow.RefactoringActionGroup>, JetBrains.ReSharper.Refactorings.Move.MoveTypeDeclarationToFile.IMoveToFileWorkflow, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringWorkflow
    {
        public MoveToFileWorkflow(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.IShellLocks locks, JetBrains.Application.Interop.NativeHook.IWindowsHookManager windowsHookManager, JetBrains.ProjectModel.ISolution solution, string actionId) { }
        public override JetBrains.ReSharper.Refactorings.Workflow.RefactoringActionGroup ActionGroup { get; }
        public bool CanRename { get; }
        public JetBrains.ReSharper.Psi.ITreeNodePointer<JetBrains.ReSharper.Psi.Tree.ITypeDeclaration> DeclarationPointer { get; }
        public JetBrains.Util.FileSystemPath FileLocation { get; }
        public override JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage FirstPendingRefactoringPage { get; }
        public JetBrains.Util.FileSystemPath FolderLocation { get; }
        public override string HelpKeyword { get; }
        public override bool MightModifyManyDocuments { get; }
        public JetBrains.ReSharper.Psi.Tree.IDeclaration NewDeclaration { get; set; }
        public string NewFileExtension { get; }
        public string NewFileName { get; }
        public JetBrains.ProjectModel.IProjectFile NewProjectFile { get; }
        public JetBrains.ProjectModel.IProjectModelElementPointer ProjectFolderPointer { get; }
        public override string Title { get; }
        public JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage CommitFirstPage(string newFileName, JetBrains.Application.Progress.IProgressIndicator pi) { }
        public JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage CommitRemoveEmptyPage(bool removeFile, JetBrains.Application.Progress.IProgressIndicator pi) { }
        protected override JetBrains.ReSharper.Refactorings.Move.MoveTypeDeclarationToFile.MoveToFileHelperBase CreateHelper(JetBrains.ReSharper.Refactorings.IRefactoringLanguageService service) { }
        public override JetBrains.ReSharper.Refactorings.Workflow.IRefactoringExecuter CreateRefactoring(JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        protected override JetBrains.ReSharper.Refactorings.Move.MoveTypeDeclarationToFile.MoveToFileHelperBase CreateUnsupportedHelper() { }
        public override bool Initialize(JetBrains.Application.DataContext.IDataContext context) { }
        public override bool IsAvailable(JetBrains.Application.DataContext.IDataContext context) { }
        public bool IsValid() { }
        public override bool PostExecute(JetBrains.Application.Progress.IProgressIndicator pi) { }
        public override bool PreExecute(JetBrains.Application.Progress.IProgressIndicator pi) { }
        public void SetDataProvider(JetBrains.ReSharper.Refactorings.Move.MoveTypeDeclarationToFile.IMoveToFileDataProvider provider) { }
        public override void SuccessfulFinish(JetBrains.Application.Progress.IProgressIndicator pi) { }
    }
    [JetBrains.ReSharper.Refactorings.Workflow.RefactoringWorkflowProviderAttribute()]
    public class MoveToFileWorkflowProvider : JetBrains.ReSharper.Refactorings.MoveWorkflowProvider
    {
        public MoveToFileWorkflowProvider(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.IShellLocks locks, JetBrains.Application.Interop.NativeHook.IWindowsHookManager windowsHookManager) { }
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Refactorings.Workflow.IRefactoringWorkflow> CreateWorkflow(JetBrains.Application.DataContext.IDataContext dataContext) { }
    }
}
namespace JetBrains.ReSharper.Refactorings.MoveInnerClass
{
    
    public interface IMoveTypeToOuterScope : JetBrains.ReSharper.Refactorings.IRefactoringExec
    {
        JetBrains.Util.Pair<JetBrains.ReSharper.Psi.Tree.IDeclaration, JetBrains.ReSharper.Psi.Tree.IDeclaration> CutDeclaration(JetBrains.ReSharper.Psi.Tree.IDeclaration typeDeclaration);
        bool IsContextUnsafe(JetBrains.ReSharper.Psi.Tree.ITreeNode element);
        bool NeedsTypeParameterOfOuterClass(JetBrains.ReSharper.Psi.ITypeParameter parameter, JetBrains.ReSharper.Psi.Tree.IDeclaration declaration);
        void PasteDeclarations(JetBrains.Util.Pair<JetBrains.ReSharper.Psi.Tree.IDeclaration, JetBrains.ReSharper.Psi.Tree.IDeclaration> pair);
        void RestoreLocalReferences(System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.Tree.IDeclaration> declarations);
        void SaveLocalReferences(System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.Tree.IDeclaration> declarations);
    }
    public abstract class MoveTypeToOuterScopeImplBase<TTypeDeclaration, TMemberOwnerDeclaration> : JetBrains.ReSharper.Refactorings.IRefactoringExec, JetBrains.ReSharper.Refactorings.MoveInnerClass.IMoveTypeToOuterScope
        where TTypeDeclaration :  class, JetBrains.ReSharper.Psi.Tree.ITypeDeclaration
        where TMemberOwnerDeclaration :  class, JetBrains.ReSharper.Psi.Tree.ITypeDeclaration
    {
        protected MoveTypeToOuterScopeImplBase(JetBrains.ReSharper.Refactorings.MoveInnerClass.MoveTypeToOuterScopeRefactoring refactoring) { }
        public JetBrains.ReSharper.Refactorings.MoveInnerClass.MoveTypeToOuterScopeRefactoring Executer { get; }
        public JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver RefactoringDriver { set; }
        public JetBrains.Util.Pair<JetBrains.ReSharper.Psi.Tree.IDeclaration, JetBrains.ReSharper.Psi.Tree.IDeclaration> CutDeclaration(JetBrains.ReSharper.Psi.Tree.IDeclaration typeDeclaration) { }
        protected abstract TTypeDeclaration CutDeclaration(TTypeDeclaration declaration);
        protected abstract JetBrains.ReSharper.Psi.AccessRights GetAccessRights(TTypeDeclaration typeDeclaration);
        protected abstract JetBrains.ReSharper.Psi.AccessRights GetAccessRights(TMemberOwnerDeclaration typeDeclaration);
        protected abstract TMemberOwnerDeclaration GetContainingTypeDeclaration(TTypeDeclaration declaration);
        public virtual bool IsContextUnsafe(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public bool NeedsTypeParameterOfOuterClass(JetBrains.ReSharper.Psi.ITypeParameter parameter, JetBrains.ReSharper.Psi.Tree.IDeclaration declaration) { }
        protected abstract TTypeDeclaration PasteDeclaration(TTypeDeclaration declaration, TMemberOwnerDeclaration oldContainingDeclaration);
        public virtual void PasteDeclarations(JetBrains.Util.Pair<JetBrains.ReSharper.Psi.Tree.IDeclaration, JetBrains.ReSharper.Psi.Tree.IDeclaration> declarationPair) { }
        protected virtual void RemoveNewKeyword(TTypeDeclaration declaration) { }
        public void RestoreLocalReferences(System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.Tree.IDeclaration> declarations) { }
        public void SaveLocalReferences(System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.Tree.IDeclaration> declarations) { }
        protected abstract void SetAccessRights(TTypeDeclaration typeDeclaration, JetBrains.ReSharper.Psi.AccessRights accessRights);
        public class ReferenceCollector<TTypeDeclaration, TMemberOwnerDeclaration> : JetBrains.ReSharper.Psi.IRecursiveElementProcessor
            where TTypeDeclaration :  class, JetBrains.ReSharper.Psi.Tree.ITypeDeclaration
            where TMemberOwnerDeclaration :  class, JetBrains.ReSharper.Psi.Tree.ITypeDeclaration
        {
            public ReferenceCollector(JetBrains.ReSharper.Refactorings.MoveInnerClass.MoveTypeToOuterScopeImplBase<TTypeDeclaration, TMemberOwnerDeclaration> owner) { }
            public bool ProcessingIsFinished { get; }
            public bool InteriorShouldBeProcessed(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
            public void ProcessAfterInterior(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
            public void ProcessBeforeInterior(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        }
    }
    public class MoveTypeToOuterScopePage : JetBrains.CommonControls.Validation.IValidatorProvider, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage
    {
        public MoveTypeToOuterScopePage(JetBrains.ReSharper.Refactorings.MoveInnerClass.MoveTypeToOuterScopeRefactoringWorkflow refactoring) { }
        public JetBrains.DataFlow.IProperty<bool> ContinueEnabled { get; }
        public string Description { get; }
        public bool DoNotShow { get; }
        public string Title { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.CommonControls.Validation.IValidator> Validators { get; }
        public JetBrains.UI.CrossFramework.EitherControl View { get; }
        public bool CheckTypeDoesNotExist(string newName) { }
        public JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage Commit(JetBrains.Application.Progress.IProgressIndicator pi) { }
        public bool Initialize(JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
        public bool RefreshContents(JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
        public void SetDecoratedControl(JetBrains.ReSharper.Refactorings.MoveInnerClass.MoveTypeToOuterScopePage.IMoveTypeToOuterScopeControl testControl) { }
        public interface IMoveTypeToOuterScopeControl
        {
            System.Windows.Forms.Control NameCombo { get; }
            void Commit(JetBrains.ReSharper.Refactorings.MoveInnerClass.MoveTypeToOuterScopeRefactoringWorkflow workflow);
            void Initialize(JetBrains.ReSharper.Refactorings.MoveInnerClass.MoveTypeToOuterScopeRefactoringWorkflow workflow);
        }
    }
    public class MoveTypeToOuterScopeRefactoring : JetBrains.ReSharper.Refactorings.Workflow.IRefactoringExecuter
    {
        public bool IsFromUnsafeContext;
        public MoveTypeToOuterScopeRefactoring(JetBrains.ReSharper.Psi.ITypeElement typeElement, string newName, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver refactoringDriver, JetBrains.ReSharper.Refactorings.MoveInnerClass.MoveTypeToOuterScopeRefactoringWorkflow workflow) { }
        public System.Collections.Generic.Dictionary<JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.ReSharper.Refactorings.Util.NewTypeImages.ResolveResultImage> LocalReferences { get; set; }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Psi.ITypeParameter> NeededTypeParametersOfOuterClass { get; }
        public JetBrains.ReSharper.Psi.IClrTypeName NewClrName { get; }
        public System.Collections.Generic.Dictionary<JetBrains.ReSharper.Psi.ITypeElement, JetBrains.ReSharper.Psi.ITypeElement> OldToNewTypeElement { get; }
        public bool TargetTopLevelScope { get; }
        public JetBrains.ReSharper.Refactorings.MoveInnerClass.MoveTypeToOuterScopeRefactoringWorkflow Workflow { get; }
        public bool Execute(JetBrains.Application.Progress.IProgressIndicator pi) { }
        public JetBrains.ReSharper.Psi.ITypeElement LeftTypeMap(JetBrains.ReSharper.Psi.ITypeElement element) { }
        public JetBrains.ReSharper.Psi.IDeclaredElement NewtypeMember(JetBrains.ReSharper.Psi.IDeclaredElement element) { }
        public static void RestoreReferenceFromImage(JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver, JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Refactorings.Util.NewTypeImages.ResolveResultImage resolveResultImage, string descr) { }
        public JetBrains.ReSharper.Psi.ITypeElement RightTypeMap(JetBrains.ReSharper.Psi.ITypeElement element) { }
    }
    public class MoveTypeToOuterScopeRefactoringWorkflow : JetBrains.ReSharper.Refactorings.Workflow.DrivenRefactoringWorkflow
    {
        public MoveTypeToOuterScopeRefactoringWorkflow(JetBrains.ProjectModel.ISolution solution, string actionId) { }
        public override JetBrains.ReSharper.Refactorings.Workflow.RefactoringActionGroup ActionGroup { get; }
        public bool ChangeInComments { get; set; }
        public override JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage FirstPendingRefactoringPage { get; }
        public override string HelpKeyword { get; }
        public override bool MightModifyManyDocuments { get; }
        public string NewName { get; set; }
        public System.Collections.Generic.Dictionary<JetBrains.ReSharper.Psi.Tree.IDeclaration, JetBrains.ReSharper.Feature.Services.Intentions.DataProviders.ICreateNewFileTarget> TargetContextsMap { get; }
        public override string Title { get; }
        public JetBrains.ReSharper.Psi.ITypeElement TypeElement { get; }
        public JetBrains.ReSharper.Psi.Pointers.IDeclaredElementPointer<JetBrains.ReSharper.Psi.ITypeElement> TypeElementToNavigate { get; set; }
        public override JetBrains.ReSharper.Refactorings.Workflow.IRefactoringExecuter CreateRefactoring(JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public override bool Initialize(JetBrains.Application.DataContext.IDataContext context) { }
        public override bool IsAvailable(JetBrains.Application.DataContext.IDataContext context) { }
        public override bool PreExecute(JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
        public override void SuccessfulFinish(JetBrains.Application.Progress.IProgressIndicator pi) { }
        public override bool Validate() { }
    }
}
namespace JetBrains.ReSharper.Refactorings.MoveInstanceMethod
{
    
    public interface IMoveInstanceMethodWorkflowProvider : JetBrains.ReSharper.Feature.Services.ActionsMenu.IWorkflowProvider<JetBrains.ReSharper.Refactorings.Workflow.IRefactoringWorkflow, JetBrains.ReSharper.Refactorings.Workflow.RefactoringActionGroup>, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringWorkflowProvider { }
    public class MoveInstanceMethodAnalyzer
    {
        protected JetBrains.ReSharper.Psi.Tree.IParametersOwnerDeclaration myDummy;
        public readonly System.Collections.Generic.List<JetBrains.ReSharper.Psi.Resolve.IReference> References;
        public MoveInstanceMethodAnalyzer(JetBrains.ReSharper.Psi.IMethod method) { }
        public JetBrains.ReSharper.Psi.AccessRights AccessRights { get; }
        public bool CopyOrDelegate { get; set; }
        public JetBrains.ReSharper.Psi.Tree.IParametersOwnerDeclaration InitialDeclaration { get; }
        public virtual System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Resolve.IReference> InnerReferences { get; }
        public JetBrains.ReSharper.Psi.Tree.IParametersOwnerDeclaration MethodDeclaration { get; }
        public virtual bool NeedPublicTarget { get; }
        public virtual bool NeedThis { get; }
        public JetBrains.ReSharper.Psi.ITypeElement SourceType { get; }
        public JetBrains.ReSharper.Refactorings.MoveInstanceMethod.TargetInfo Target { get; }
        public System.Collections.Generic.List<JetBrains.ReSharper.Refactorings.MoveInstanceMethod.TargetInfo> Targets { get; set; }
        public JetBrains.ReSharper.Psi.ITypeElement TargetType { get; }
        public virtual bool AnalyzeDeclaration() { }
        public void AnalyzeReferences() { }
        public virtual void Clear() { }
        public void FillReferences(JetBrains.Application.Progress.IProgressIndicator pi) { }
        public virtual JetBrains.ReSharper.Psi.IProperty GetProperty(JetBrains.ReSharper.Psi.IField field) { }
        public virtual void LoadTargets() { }
        public virtual void SetProperty(JetBrains.ReSharper.Psi.IField field, JetBrains.ReSharper.Psi.IProperty declaredElement) { }
        public void SetProspectiveAccessRights(JetBrains.ReSharper.Psi.AccessRights accessRights) { }
    }
    public class MoveInstanceMethodData
    {
        public MoveInstanceMethodData(int selectedItem) { }
        public int SelectedIndex { get; }
    }
    public class MoveInstanceMethodExec : JetBrains.ReSharper.Refactorings.Common.RefactoringExecBase<JetBrains.ReSharper.Refactorings.MoveInstanceMethod.MoveInstanceMethodWorkflow, JetBrains.ReSharper.Refactorings.MoveInstanceMethod.MoveInstanceMethodRefactoring>
    {
        public MoveInstanceMethodExec(JetBrains.ReSharper.Refactorings.MoveInstanceMethod.MoveInstanceMethodWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
    }
    public class MoveInstanceMethodHelper : JetBrains.ReSharper.Refactorings.IWorkflowExec, JetBrains.ReSharper.Refactorings.Util.NewTypeImages.IResolveImagesLanguageSupport
    {
        public virtual bool IsLanguageSupported { get; }
        public virtual void AddAdditionalElements() { }
        public virtual void AddSourceElementParameter() { }
        public virtual JetBrains.ReSharper.Refactorings.MoveInstanceMethod.MoveInstanceMethodAnalyzer GetAnalyzer(JetBrains.ReSharper.Refactorings.MoveInstanceMethod.MoveInstanceMethodWorkflow moveInstanceMethodWorkflow, JetBrains.ReSharper.Psi.IMethod method) { }
        public bool IsExternallyVisibleSymbol(JetBrains.ReSharper.Psi.IDeclaredElement element) { }
        public bool IsFromExtendsList(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public bool IsReferenceName(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public virtual void Rebind(JetBrains.Application.Progress.IProgressIndicator pi) { }
        public void RemoveUnusedUsing(JetBrains.ReSharper.Psi.Tree.IFile file, System.Collections.Generic.JetHashSet<JetBrains.ReSharper.Psi.Tree.ITreeNode> usings) { }
        public virtual void ReplaceTargetInDeclaration() { }
        public virtual void ReplaceWithDelegation(JetBrains.Application.Progress.IProgressIndicator pi) { }
        public void SaveUnusedUsings(JetBrains.ReSharper.Psi.Tree.IFile file, JetBrains.ReSharper.Refactorings.Move.Common.UnusedUsingSaver saver) { }
    }
    public class MoveInstanceMethodRefactoring : JetBrains.ReSharper.Refactorings.Common.DrivenRefactoring<JetBrains.ReSharper.Refactorings.MoveInstanceMethod.MoveInstanceMethodWorkflow, JetBrains.ReSharper.Refactorings.MoveInstanceMethod.MoveInstanceMethodExec>
    {
        public MoveInstanceMethodRefactoring(JetBrains.ReSharper.Refactorings.MoveInstanceMethod.MoveInstanceMethodWorkflow workflow, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public override bool Execute(JetBrains.Application.Progress.IProgressIndicator pi) { }
    }
    public class MoveInstanceMethodWorkflow : JetBrains.ReSharper.Refactorings.WorkflowNew.DrivenRefactoringWorkflow2<JetBrains.ReSharper.Refactorings.MoveInstanceMethod.MoveInstanceMethodHelper>
    {
        public MoveInstanceMethodWorkflow(JetBrains.ProjectModel.ISolution solution, string actionId) { }
        public override JetBrains.ReSharper.Refactorings.Workflow.RefactoringActionGroup ActionGroup { get; }
        public JetBrains.ReSharper.Refactorings.MoveInstanceMethod.MoveInstanceMethodAnalyzer Analyzer { get; set; }
        public JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver Driver { get; set; }
        public override JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage FirstPendingRefactoringPage { get; }
        public override string HelpKeyword { get; }
        public override bool MightModifyManyDocuments { get; }
        public override string Title { get; }
        protected override JetBrains.ReSharper.Refactorings.MoveInstanceMethod.MoveInstanceMethodHelper CreateHelper(JetBrains.ReSharper.Refactorings.IRefactoringLanguageService service) { }
        public override JetBrains.ReSharper.Refactorings.Workflow.IRefactoringExecuter CreateRefactoring(JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        protected override JetBrains.ReSharper.Refactorings.MoveInstanceMethod.MoveInstanceMethodHelper CreateUnsupportedHelper() { }
        public override bool Initialize(JetBrains.Application.DataContext.IDataContext context) { }
        public override bool IsAvailable(JetBrains.Application.DataContext.IDataContext context) { }
        protected bool IsAvailableEx(JetBrains.Application.DataContext.IDataContext context, out JetBrains.ReSharper.Psi.IMethod method) { }
        public void SetData(JetBrains.ReSharper.Refactorings.MoveInstanceMethod.MoveInstanceMethodData moveInstanceMethodData) { }
        public override void UnsuccessfulFinish(JetBrains.Application.Progress.IProgressIndicator pi) { }
        public override bool Validate() { }
    }
    [JetBrains.ReSharper.Refactorings.Workflow.RefactoringWorkflowProviderAttribute()]
    public class MoveInstanceMethodWorkflowProvider : JetBrains.ReSharper.Refactorings.MoveWorkflowProvider
    {
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Refactorings.Workflow.IRefactoringWorkflow> CreateWorkflow(JetBrains.Application.DataContext.IDataContext dataContext) { }
    }
    public class TargetElementSelectionPage : System.Windows.Controls.UserControl, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector
    {
        public TargetElementSelectionPage(JetBrains.ReSharper.Refactorings.MoveInstanceMethod.MoveInstanceMethodAnalyzer analyzer) { }
        public JetBrains.DataFlow.IProperty<bool> ContinueEnabled { get; }
        public string Description { get; }
        public bool DoNotShow { get; }
        public string MethodPresentation { get; }
        public System.Windows.Controls.RadioButton[] RadioButtons { get; }
        public System.Collections.Generic.List<JetBrains.ReSharper.Refactorings.MoveInstanceMethod.TargetInfo> Targets { get; set; }
        public string Title { get; }
        public JetBrains.UI.CrossFramework.EitherControl View { get; }
        public JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage Commit(JetBrains.Application.Progress.IProgressIndicator pi) { }
        public bool Initialize(JetBrains.Application.Progress.IProgressIndicator pi) { }
        public void InitializeComponent() { }
        public bool RefreshContents(JetBrains.Application.Progress.IProgressIndicator pi) { }
    }
    public class TargetInfo : JetBrains.UI.Avalon.TreeListView.ObservableObject
    {
        public TargetInfo(JetBrains.ReSharper.Psi.IDeclaredElement targetElement) { }
        public JetBrains.ReSharper.Psi.IDeclaredElement DeclaredElement { get; }
        public JetBrains.UI.Icons.IconId Icon { get; }
        public bool IsUsed { get; set; }
        public string Presentation { get; }
        public JetBrains.ReSharper.Psi.IDeclaredElement PublicElement { get; }
        public JetBrains.ReSharper.Psi.ITypeElement TypeElement { get; }
    }
}
namespace JetBrains.ReSharper.Refactorings.MoveMembers.Actions
{
    
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "ExtractInter"})]
    public class ExtractInterfaceAction : JetBrains.ReSharper.Refactorings.Workflow.ExtensibleRefactoringAction<JetBrains.ReSharper.Refactorings.MoveMembers.Actions.IExtractInterfaceWorkflowProvider>
    {
        public const string ACTION_ID = "ExtractInter";
        protected override JetBrains.UI.RichText.RichText Caption { get; }
    }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "ExtractSuper"})]
    public class ExtractSuperclassAction : JetBrains.ReSharper.Refactorings.Workflow.ExtensibleRefactoringAction<JetBrains.ReSharper.Refactorings.MoveMembers.Actions.IExtractSuperclassWorkflowProvider>
    {
        public const string ACTION_ID = "ExtractSuper";
        protected override JetBrains.UI.RichText.RichText Caption { get; }
    }
    public interface IExtractInterfaceWorkflowProvider : JetBrains.ReSharper.Feature.Services.ActionsMenu.IWorkflowProvider<JetBrains.ReSharper.Refactorings.Workflow.IRefactoringWorkflow, JetBrains.ReSharper.Refactorings.Workflow.RefactoringActionGroup>, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringWorkflowProvider { }
    public interface IExtractSuperclassWorkflowProvider : JetBrains.ReSharper.Feature.Services.ActionsMenu.IWorkflowProvider<JetBrains.ReSharper.Refactorings.Workflow.IRefactoringWorkflow, JetBrains.ReSharper.Refactorings.Workflow.RefactoringActionGroup>, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringWorkflowProvider { }
    public interface IPullUpWorkflowProvider : JetBrains.ReSharper.Feature.Services.ActionsMenu.IWorkflowProvider<JetBrains.ReSharper.Refactorings.Workflow.IRefactoringWorkflow, JetBrains.ReSharper.Refactorings.Workflow.RefactoringActionGroup>, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringWorkflowProvider { }
    public interface IPushDownWorkflowProvider : JetBrains.ReSharper.Feature.Services.ActionsMenu.IWorkflowProvider<JetBrains.ReSharper.Refactorings.Workflow.IRefactoringWorkflow, JetBrains.ReSharper.Refactorings.Workflow.RefactoringActionGroup>, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringWorkflowProvider { }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "PullUp"})]
    public class PullUpAction : JetBrains.ReSharper.Refactorings.Workflow.ExtensibleRefactoringAction<JetBrains.ReSharper.Refactorings.MoveMembers.Actions.IPullUpWorkflowProvider>
    {
        public const string ACTION_ID = "PullUp";
        protected override JetBrains.UI.RichText.RichText Caption { get; }
    }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "PushDown"})]
    public class PushDownAction : JetBrains.ReSharper.Refactorings.Workflow.ExtensibleRefactoringAction<JetBrains.ReSharper.Refactorings.MoveMembers.Actions.IPushDownWorkflowProvider>
    {
        public const string ACTION_ID = "PushDown";
        protected override JetBrains.UI.RichText.RichText Caption { get; }
    }
}
namespace JetBrains.ReSharper.Refactorings.MoveMembers.Analysis
{
    
    public interface IMoveAnalyser
    {
        System.Collections.Generic.Dictionary<JetBrains.ReSharper.Psi.ITypeElement, System.Collections.Generic.JetHashSet<JetBrains.ReSharper.Refactorings.CommonUI.IMemberInfo>> BaseClass2MemberInfosMap { get; }
    }
    public abstract class MoveAnalyser<STATIC_ANALYSER, MEMBER_INFO> : JetBrains.ReSharper.Refactorings.MoveMembers.Analysis.IMoveAnalyser
        where STATIC_ANALYSER : JetBrains.ReSharper.Refactorings.MoveMembers.Analysis.MoveStaticAnalyser<>
        where MEMBER_INFO :  class, JetBrains.ReSharper.Refactorings.CommonUI.IMemberInfo
    {
        protected System.Collections.Generic.Dictionary<JetBrains.ReSharper.Psi.ITypeElement, System.Collections.Generic.JetHashSet<JetBrains.ReSharper.Refactorings.CommonUI.IMemberInfo>> myBaseClass2MemberInfosMap;
        protected System.Collections.Generic.List<JetBrains.ReSharper.Psi.ITypeMember> myMembersToMakeOverride;
        protected System.Collections.Generic.Dictionary<JetBrains.ReSharper.Psi.ITypeMember, System.Collections.Generic.JetHashSet<JetBrains.ReSharper.Psi.ITypeMember>> myOverridesOf;
        protected readonly STATIC_ANALYSER myStaticAnalyser;
        protected System.Collections.Generic.JetHashSet<JetBrains.ReSharper.Psi.ITypeElement> myTypeElementsToMakeAbstract;
        protected System.Collections.Generic.List<JetBrains.ReSharper.Psi.ITypeMember> myTypeMembersToRemove;
        public MoveAnalyser(STATIC_ANALYSER staticAnalyser) { }
        public virtual System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.ITypeElement> AllTypeElementsToMakeAbstract { get; }
        public System.Collections.Generic.Dictionary<JetBrains.ReSharper.Psi.ITypeElement, System.Collections.Generic.JetHashSet<JetBrains.ReSharper.Refactorings.CommonUI.IMemberInfo>> BaseClass2MemberInfosMap { get; }
        public System.Collections.Generic.List<JetBrains.ReSharper.Psi.ITypeMember> MembersToMakeOverride { get; }
        public System.Collections.Generic.Dictionary<JetBrains.ReSharper.Psi.ITypeMember, System.Collections.Generic.JetHashSet<JetBrains.ReSharper.Psi.ITypeMember>> OverridesOf { get; set; }
        public STATIC_ANALYSER StaticAnalyser { get; }
        public System.Collections.Generic.JetHashSet<JetBrains.ReSharper.Psi.ITypeElement> TypeElementsToMakeAbstract { get; }
        public System.Collections.Generic.List<JetBrains.ReSharper.Psi.ITypeMember> TypeMembersToRemove { get; }
        public abstract System.Collections.Generic.List<JetBrains.ReSharper.Psi.IMethod> GetSuspectiousMethods();
        public abstract void PrepareData(JetBrains.ReSharper.Refactorings.MoveMembers.Common.IMoveMembersExecuter executer, JetBrains.Application.Progress.IProgressIndicator pi, JetBrains.ReSharper.Psi.ITypeElement targetType);
    }
    public abstract class MoveStaticAnalyser<TMemberInfo>
        where TMemberInfo :  class, JetBrains.ReSharper.Refactorings.CommonUI.IMemberInfo
    {
        protected System.Collections.Generic.Dictionary<TMemberInfo, System.Collections.Generic.JetHashSet<TMemberInfo>> MyDependenciesMap;
        protected JetBrains.ReSharper.Refactorings.MoveMembers.Common.TargetElementTypes myElementType;
        protected readonly JetBrains.ReSharper.Psi.Pointers.IDeclaredElementPointer<JetBrains.ReSharper.Psi.ITypeElement> myInitialTypeElement;
        protected System.Collections.Generic.List<TMemberInfo> myPrecountedMemberInfo;
        protected MoveStaticAnalyser([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.ITypeElement typeElement) { }
        public System.Collections.Generic.Dictionary<TMemberInfo, System.Collections.Generic.JetHashSet<TMemberInfo>> DependenciesMap { get; }
        public virtual System.Collections.Generic.IEnumerable<TMemberInfo> IncludedMembers { get; }
        public JetBrains.ReSharper.Psi.PsiLanguageType Language { get; }
        public System.Collections.Generic.List<TMemberInfo> Members { get; }
        public JetBrains.ReSharper.Psi.ITypeElement TypeElement { get; }
        protected abstract void AddBaseTypeInfo(JetBrains.ReSharper.Psi.IDeclaredType declaredType, bool b);
        protected abstract void AddMemberInfo(JetBrains.ReSharper.Psi.ITypeMember member, bool isIncluded);
        protected static JetBrains.ReSharper.Refactorings.MoveMembers.Common.TargetElementTypes ElementTypeOf(JetBrains.ReSharper.Psi.ITypeElement typeElement) { }
        protected virtual bool FilterMembers(JetBrains.ReSharper.Psi.ITypeMember member) { }
        public abstract JetBrains.ReSharper.Psi.Tree.ITypeDeclaration GetTargetDeclaration(JetBrains.ReSharper.Psi.ITypeElement typeElement);
        public void InitDependencies() { }
        public virtual void InitializeMembers(System.Func<JetBrains.ReSharper.Psi.ITypeMember, bool> isMemberIncluded) { }
        public abstract bool IsReferenced(TMemberInfo info);
        public bool IsValid() { }
        public void SelectAllPublic() { }
        public void SelectDependent() { }
        public virtual bool Validate() { }
    }
}
namespace JetBrains.ReSharper.Refactorings.MoveMembers.Common
{
    
    public abstract class BaseTypeInfoBase<MEMBER_INFO> : JetBrains.ReSharper.Refactorings.CommonUI.BaseMemberInfo, JetBrains.ReSharper.Refactorings.CommonUI.IMemberInfo, JetBrains.ReSharper.Refactorings.MoveMembers.Common.IBaseTypeInfoBase
        where MEMBER_INFO :  class, JetBrains.ReSharper.Refactorings.CommonUI.IMemberInfo
    {
        protected readonly JetBrains.ReSharper.Refactorings.MoveMembers.Analysis.MoveStaticAnalyser<MEMBER_INFO> myAnalyser;
        protected readonly JetBrains.ReSharper.Psi.IDeclaredType myDeclaredType;
        protected BaseTypeInfoBase(JetBrains.ReSharper.Psi.IDeclaredType declaredType, JetBrains.ReSharper.Refactorings.MoveMembers.Analysis.MoveStaticAnalyser<MEMBER_INFO> analyser, JetBrains.ReSharper.Psi.ITypeElement ownerTypeElement) { }
        public JetBrains.ReSharper.Refactorings.MoveMembers.Analysis.MoveStaticAnalyser<MEMBER_INFO> Analyser { get; }
        public override bool CanChangeAbstract { get; }
        public override bool CanHaveAbstract { get; }
        public JetBrains.ReSharper.Psi.IDeclaredType DeclaredType { get; }
        public override bool Enabled { get; }
        public override bool HasError { get; }
        public override bool HasWarning { get; }
        public override bool Included { get; set; }
        public override bool MakeAbstract { get; set; }
        public JetBrains.ReSharper.Psi.ITypeElement OwnerTypeElement { get; }
        public override string ToolTip { get; }
        public JetBrains.ReSharper.Psi.IDeclaredType GetNewDeclaredType(JetBrains.ReSharper.Refactorings.MoveMembers.Common.IImageCollector imageCollector, JetBrains.ReSharper.Psi.ITypeElement targetTypeElement) { }
        protected override void SafeUpdate() { }
        protected abstract MEMBER_INFO This();
    }
    public interface IBaseTypeInfoBase : JetBrains.ReSharper.Refactorings.CommonUI.IMemberInfo
    {
        JetBrains.ReSharper.Psi.IDeclaredType DeclaredType { get; }
        JetBrains.ReSharper.Psi.ITypeElement OwnerTypeElement { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.IDeclaredType GetNewDeclaredType(JetBrains.ReSharper.Refactorings.MoveMembers.Common.IImageCollector imageCollector, JetBrains.ReSharper.Psi.ITypeElement targetTypeElement);
    }
    public interface IImageCollector : JetBrains.ReSharper.Refactorings.MoveMembers.Common.IReferenceConsumer
    {
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IDeclaredElement> GetMemberImages(JetBrains.ReSharper.Psi.IDeclaredElement oldTypeMember, JetBrains.ReSharper.Psi.ITypeElement targetTypeMember);
        System.Collections.Generic.IDictionary<JetBrains.ReSharper.Psi.ITypeElement, JetBrains.ReSharper.Psi.ITypeElement> GetTypeMap(JetBrains.ReSharper.Psi.ITypeElement targetType);
        void SetMemberID(JetBrains.ReSharper.Psi.ITypeMember oldTypeMember, JetBrains.ReSharper.Psi.ITypeMember newTypeMember, JetBrains.ReSharper.Psi.ITypeElement targetTypeElement);
        void SetRefID(System.Func<JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.ReSharper.Psi.Resolve.IReference> mapDelegate, JetBrains.ReSharper.Psi.ITypeElement targetTypeElement);
        void SetRefID(System.Func<JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.ReSharper.Psi.Resolve.IReference> mapDelegate);
        void SetTypeID(JetBrains.ReSharper.Psi.ITypeElement oldTypeElement, JetBrains.ReSharper.Psi.ITypeElement newTypeElement);
        void SetTypeID(JetBrains.ReSharper.Psi.ITypeElement oldTypeElement, JetBrains.ReSharper.Psi.ITypeElement newTypeElement, JetBrains.ReSharper.Psi.ITypeElement targetTypeElement);
    }
    public interface IMemberInfoBase : JetBrains.ReSharper.Refactorings.CommonUI.IMemberInfo
    {
        bool Disable { get; }
        bool ForceCut { set; }
        bool ForceEventToMoveAsVirtual { get; set; }
        bool ForceOverride2Virtual { get; set; }
        bool ForceRemoveReadonly { get; }
        bool ForceVirtual2Override { get; set; }
        bool MakeSourceAbstract { get; }
        bool MakeTargetAbstract { get; }
        bool MakeTargetOverride { get; }
        JetBrains.ReSharper.Psi.IDeclaredElement RemovedDeclaredElement { get; }
        bool UnsafeContext { get; set; }
        bool IsPureInstanceMove();
        bool MakeOverride();
        bool MakeProtected();
        bool PerformCutDeclarations();
        void SetForceRemoveReadonly();
        void SetRmovedTypeMember(JetBrains.ReSharper.Psi.IDeclaredElement member);
    }
    public interface IMove<MEMBER_INFO> : JetBrains.ReSharper.Refactorings.IRefactoringExec
        where MEMBER_INFO : JetBrains.ReSharper.Refactorings.CommonUI.IMemberInfo
    {
        void AddImplementsSpecification(JetBrains.ReSharper.Psi.Tree.IDeclaration decl, JetBrains.ReSharper.Psi.ITypeElement element, bool name);
        bool CheckConflictsWithTargetClassName(JetBrains.ReSharper.Psi.ITypeElement element, string name);
        JetBrains.ReSharper.Refactorings.MoveMembers.Common.MoveMembersHelper<MEMBER_INFO> GetHelper();
        bool IsInstanceSpecificEventAccess(JetBrains.ReSharper.Psi.Resolve.IReference reference);
        void SetExecuter(JetBrains.ReSharper.Refactorings.Workflow.IRefactoringExecuter refactoring);
    }
    public interface IMoveMembersExecuter : JetBrains.ReSharper.Refactorings.MoveMembers.Common.IImageCollector, JetBrains.ReSharper.Refactorings.MoveMembers.Common.IReferenceConsumer, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringExecuter
    {
        JetBrains.ReSharper.Psi.Resolve.ISubstitution AllBaseTypeSubst { get; }
        JetBrains.ReSharper.Refactorings.MoveMembers.Analysis.IMoveAnalyser Analyser { get; }
        JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver Driver { get; }
        System.Collections.Generic.JetHashSet<JetBrains.ReSharper.Psi.IDeclaredElement> ElementsToMakeProtected { get; }
        JetBrains.ReSharper.Psi.IPsiServices PsiServices { get; }
        System.Collections.Generic.JetHashSet<JetBrains.ReSharper.Psi.Resolve.IReference> RemovedLocalReferences { get; set; }
        void AddImplementsSpecification(JetBrains.ReSharper.Psi.Tree.IDeclaration decl, JetBrains.ReSharper.Psi.ITypeElement typeElement, bool isItemName);
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Psi.Modules.IPsiModule GetSourceProject();
        void RemoveSuperType(JetBrains.ReSharper.Psi.ITypeElement typeElement, JetBrains.ReSharper.Psi.IDeclaredType declaredType);
    }
    public interface IReferenceConsumer
    {
        void InitRef(JetBrains.ReSharper.Psi.Resolve.IReference reference);
    }
    public interface ITargetTypeWithProjectFile : JetBrains.ReSharper.Refactorings.CommonUI.IMemberInfo
    {
        JetBrains.ReSharper.Psi.Tree.ITypeDeclaration TypeDeclaration { get; }
        JetBrains.ReSharper.Psi.ITypeElement TypeElement { get; }
    }
    public abstract class MemberInfo<MEMBER_INFO> : JetBrains.ReSharper.Refactorings.CommonUI.BaseMemberInfo, JetBrains.ReSharper.Refactorings.CommonUI.IMemberInfo, JetBrains.ReSharper.Refactorings.MoveMembers.Common.IMemberInfoBase
        where MEMBER_INFO :  class, JetBrains.ReSharper.Refactorings.CommonUI.IMemberInfo
    {
        protected JetBrains.ReSharper.Refactorings.MoveMembers.Analysis.MoveStaticAnalyser<MEMBER_INFO> myAnalyser;
        protected bool myCanChangeAbstract;
        protected bool myCanHaveAbstract;
        protected bool myDisable;
        protected bool myForceCut;
        protected bool myForceEventToMoveAsVirtual;
        protected bool myForceOverride2Virtual;
        protected bool myForceRemoveReadonly;
        protected bool myForceVirtual2Override;
        protected bool myIncluded;
        protected bool myMakeAbstract;
        protected MemberInfo(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, bool included, JetBrains.ReSharper.Refactorings.MoveMembers.Analysis.MoveStaticAnalyser<MEMBER_INFO> analyser) { }
        public override bool CanChangeAbstract { get; }
        public override bool CanHaveAbstract { get; }
        public bool Disable { get; }
        public override bool Enabled { get; }
        public bool ForceCut { set; }
        public virtual bool ForceEventToMoveAsVirtual { get; set; }
        public bool ForceOverride2Virtual { get; set; }
        public bool ForceRemoveReadonly { get; }
        public bool ForceVirtual2Override { get; set; }
        public override bool HasError { get; }
        public override bool HasWarning { get; }
        public override bool Included { get; set; }
        public override bool MakeAbstract { get; set; }
        public virtual bool MakeSourceAbstract { get; }
        public virtual bool MakeTargetAbstract { get; }
        public virtual bool MakeTargetOverride { get; }
        public JetBrains.ReSharper.Psi.IDeclaredElement RemovedDeclaredElement { get; }
        public override string ToolTip { get; }
        public bool UnsafeContext { get; set; }
        public abstract bool IsPureInstanceMove();
        public abstract bool MakeOverride();
        public abstract bool MakeProtected();
        public abstract bool PerformCutDeclarations();
        protected override void SafeUpdate() { }
        public void SetForceRemoveReadonly() { }
        public void SetRmovedTypeMember(JetBrains.ReSharper.Psi.IDeclaredElement member) { }
        public abstract MEMBER_INFO This();
    }
    public abstract class MoveMembersHelper<TMemberInfo>
    
    {
        protected MoveMembersHelper(JetBrains.ReSharper.Refactorings.MoveMembers.Common.IMoveMembersExecuter executer) { }
        protected JetBrains.ReSharper.Refactorings.MoveMembers.Common.IMoveMembersExecuter Executer { get; }
        public abstract void AddBaseInterface(JetBrains.ReSharper.Psi.ITypeElement element, JetBrains.ReSharper.Psi.IDeclaredType info);
        public virtual void AddImplementsSpecification(JetBrains.ReSharper.Psi.Tree.IDeclaration decl, JetBrains.ReSharper.Psi.ITypeElement element, bool nameIsItem, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public abstract void CheckConstructorReferenceConflict(JetBrains.ReSharper.Psi.Resolve.IReference reference);
        public abstract JetBrains.ReSharper.Psi.Tree.ITypeDeclaration CreateTargetTypeElement(string name, JetBrains.ReSharper.Psi.ITypeElement sourceClass, System.Collections.Generic.List<JetBrains.ReSharper.Psi.ITypeParameter> parameters, bool createClass, bool preserveAccessRigths);
        public abstract System.Collections.Generic.IList<JetBrains.Util.Pair<TMemberInfo, JetBrains.ReSharper.Psi.Tree.IDeclaration>> CutDeclarations(System.Collections.Generic.IEnumerable<TMemberInfo> memberInfos, JetBrains.Application.Progress.SubProgressIndicator pi);
        public abstract void GenerateConstructors(JetBrains.ReSharper.Psi.ITypeElement targetType, JetBrains.ReSharper.Psi.Tree.ITypeDeclaration typeDeclaration, JetBrains.ReSharper.Psi.Pointers.IDeclaredElementPointer<JetBrains.ReSharper.Psi.IConstructor> baseConstructor);
        public virtual JetBrains.ReSharper.Psi.IConstructor GetBaseConstructorDeclarationToInsert(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration) { }
        public abstract JetBrains.ReSharper.Psi.Tree.ITypeDeclaration InsertSibling(JetBrains.ReSharper.Psi.Tree.ITypeDeclaration decl, JetBrains.ReSharper.Psi.Tree.ITypeDeclaration sourceClass);
        public abstract JetBrains.ReSharper.Psi.Tree.ITypeDeclaration InsertToNewFile(JetBrains.ReSharper.Psi.Tree.ITypeDeclaration decl, JetBrains.ReSharper.Psi.Tree.ITypeDeclaration sourceClass, string ns, JetBrains.ProjectModel.IProjectFile fileNearby);
        public abstract bool IsQualifierValid(JetBrains.ReSharper.Psi.Resolve.IReference reference);
        public abstract void MakeOverride(JetBrains.ReSharper.Psi.ITypeMember member);
        public abstract void MakeProtected(JetBrains.ReSharper.Psi.IDeclaredElement element);
        public virtual void MakePublic(JetBrains.ReSharper.Psi.ITypeMember member) { }
        public abstract void MakeTypeElementAbstract(JetBrains.ReSharper.Psi.ITypeElement element);
        public abstract void PasteDeclarations(System.Collections.Generic.IList<JetBrains.Util.Pair<TMemberInfo, JetBrains.ReSharper.Psi.Tree.IDeclaration>> declarations, JetBrains.ReSharper.Psi.ITypeElement targetType, JetBrains.ProjectModel.IProjectFile projectFile, JetBrains.ReSharper.Psi.Tree.ITypeDeclaration targetTypeDeclaration, JetBrains.Application.Progress.SubProgressIndicator pi);
        public abstract void RemoveDeclaration(JetBrains.ReSharper.Psi.ITypeMember member);
        public abstract void RemoveSuperType(JetBrains.ReSharper.Psi.Tree.ITypeDeclaration typeDeclaration, JetBrains.ReSharper.Psi.IDeclaredType type);
        public abstract void SetSuperclass(JetBrains.ReSharper.Psi.Tree.ITypeDeclaration sourceClass, JetBrains.ReSharper.Psi.ITypeElement newSuper, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution);
        public abstract bool TryProcessMultyFieldForResolve(JetBrains.ReSharper.Psi.IRecursiveElementProcessor collector, JetBrains.ReSharper.Psi.Tree.IDeclaration declaration);
    }
    public abstract class MoveMembersRefactoring<TWorkflow, TAnalyser, TStaticAnalyser, TMemberInfo> : JetBrains.ReSharper.Refactorings.MoveMembers.Common.IImageCollector, JetBrains.ReSharper.Refactorings.MoveMembers.Common.IMoveMembersExecuter, JetBrains.ReSharper.Refactorings.MoveMembers.Common.IReferenceConsumer, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringExecuter
        where TWorkflow : JetBrains.ReSharper.Refactorings.MoveMembers.Common.MoveWorkflow<, >
        where TAnalyser : JetBrains.ReSharper.Refactorings.MoveMembers.Analysis.MoveAnalyser<, >
        where TStaticAnalyser : JetBrains.ReSharper.Refactorings.MoveMembers.Analysis.MoveStaticAnalyser<>
        where TMemberInfo :  class, JetBrains.ReSharper.Refactorings.CommonUI.IMemberInfo
    {
        protected TAnalyser myAnalyser;
        protected readonly System.Collections.Generic.JetHashSet<JetBrains.ReSharper.Psi.IDeclaredElement> myElementsToMakeProtected;
        protected readonly JetBrains.ReSharper.Refactorings.LanguageMapOfRefactoring<JetBrains.ReSharper.Refactorings.MoveMembers.Common.IMove<TMemberInfo>> myExec;
        protected System.Collections.Generic.Dictionary<JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.ReSharper.Refactorings.Util.TypeImages.BaseResolveResultImage> myLocalReferences;
        protected MoveMembersRefactoring(TWorkflow workFlow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public virtual JetBrains.ReSharper.Psi.Resolve.ISubstitution AllBaseTypeSubst { get; }
        protected TAnalyser Analyser { get; }
        public JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver Driver { get; }
        public System.Collections.Generic.JetHashSet<JetBrains.ReSharper.Psi.IDeclaredElement> ElementsToMakeProtected { get; }
        public JetBrains.ReSharper.Psi.IPsiServices PsiServices { get; }
        public System.Collections.Generic.JetHashSet<JetBrains.ReSharper.Psi.Resolve.IReference> RemovedLocalReferences { get; set; }
        protected JetBrains.ProjectModel.ISolution Solution { get; }
        protected TWorkflow Workflow { get; }
        public void AddImplementsSpecification(JetBrains.ReSharper.Psi.Tree.IDeclaration decl, JetBrains.ReSharper.Psi.ITypeElement typeElement, bool isItemName) { }
        protected abstract void CheckConflictsWithExistingsElements(JetBrains.Application.Progress.SubProgressIndicator pi);
        protected abstract void CheckConflictsWithTargetClassName(JetBrains.Application.Progress.SubProgressIndicator subPi);
        protected void CheckConflictWithMembersInType(JetBrains.ReSharper.Psi.ITypeElement element, JetBrains.Application.Progress.SubProgressIndicator pi) { }
        protected abstract void CollectMembersToMakeProtected();
        protected void CompareConstraints(JetBrains.ReSharper.Psi.ITypeParameter parameter, JetBrains.ReSharper.Psi.ITypeParameter targetParameter, JetBrains.ReSharper.Psi.ITypeElement targetTypeElement) { }
        protected abstract JetBrains.ReSharper.Refactorings.MoveMembers.Common.IMove<TMemberInfo> CreateRefactoring(JetBrains.ReSharper.Refactorings.InternalRefactoringLanguageService service, JetBrains.ReSharper.Refactorings.MoveMembers.Common.MoveMembersRefactoring<TWorkflow, TAnalyser, TStaticAnalyser, TMemberInfo> refactoring);
        public abstract void CreateTypeParametersMap();
        protected abstract JetBrains.ReSharper.Refactorings.MoveMembers.Common.IMove<TMemberInfo> CreateUnsupportedRefactoring();
        public virtual bool Execute(JetBrains.Application.Progress.IProgressIndicator pi) { }
        protected abstract System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.ITypeElement> GetAllTargetTypes();
        protected JetBrains.ReSharper.Refactorings.MoveMembers.Common.MoveMembersHelper<TMemberInfo> GetHelper(JetBrains.ReSharper.Psi.PsiLanguageType language) { }
        public virtual System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IDeclaredElement> GetMemberImages(JetBrains.ReSharper.Psi.IDeclaredElement oldTypeMember, JetBrains.ReSharper.Psi.ITypeElement targetTypeMember) { }
        public JetBrains.ReSharper.Psi.Modules.IPsiModule GetSourceProject() { }
        public virtual System.Collections.Generic.IDictionary<JetBrains.ReSharper.Psi.ITypeElement, JetBrains.ReSharper.Psi.ITypeElement> GetTypeMap(JetBrains.ReSharper.Psi.ITypeElement targetType) { }
        protected abstract bool IgnoreConflictedMember(JetBrains.ReSharper.Psi.ITypeMember info, JetBrains.ReSharper.Psi.ITypeElement element);
        protected JetBrains.ReSharper.Refactorings.Util.TypeImages.TypeImageProvider ImageProvider(JetBrains.ReSharper.Psi.ITypeElement targetTypeElement) { }
        protected virtual bool InitializeBaseType(JetBrains.Application.Progress.SubProgressIndicator subPi) { }
        public virtual void InitRef(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        protected virtual void MakeMembersProtected() { }
        protected virtual void MakeOverridesPublic() { }
        protected virtual bool NeedPasteIn(JetBrains.ReSharper.Psi.ITypeElement type, JetBrains.Util.Pair<TMemberInfo, JetBrains.ReSharper.Psi.Tree.IDeclaration> pair) { }
        protected virtual void PrepareData(JetBrains.Application.Progress.SubProgressIndicator pi) { }
        protected void ProcessAllMembersForResolve(JetBrains.ReSharper.Psi.IRecursiveElementProcessor collector, JetBrains.Application.Progress.SubProgressIndicator subPi) { }
        public void RemoveSuperType(JetBrains.ReSharper.Psi.ITypeElement typeElement, JetBrains.ReSharper.Psi.IDeclaredType declaredType) { }
        protected virtual void RestoreLocalReferences(JetBrains.Application.Progress.SubProgressIndicator pi) { }
        protected virtual void RestoreOtherReference(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Refactorings.Util.TypeImages.BaseResolveResultImage resolveResultImage) { }
        protected void RestoreReferencesForGivenTarget(System.Collections.Generic.Dictionary<JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.ReSharper.Refactorings.Util.TypeImages.BaseResolveResultImage> localReferences, JetBrains.ReSharper.Psi.ITypeElement targetType, JetBrains.Application.Progress.SubProgressIndicator pi) { }
        public virtual void SetMemberID(JetBrains.ReSharper.Psi.ITypeMember oldTypeMember, JetBrains.ReSharper.Psi.ITypeMember newTypeMember, JetBrains.ReSharper.Psi.ITypeElement targetTypeElement) { }
        public virtual void SetRefID(System.Func<JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.ReSharper.Psi.Resolve.IReference> mapDelegate, JetBrains.ReSharper.Psi.ITypeElement targetTypeElement) { }
        public void SetRefID(System.Func<JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.ReSharper.Psi.Resolve.IReference> mapDelegate) { }
        public void SetTypeID(JetBrains.ReSharper.Psi.ITypeElement oldTypeElement, JetBrains.ReSharper.Psi.ITypeElement newTypeElement) { }
        public virtual void SetTypeID(JetBrains.ReSharper.Psi.ITypeElement oldTypeElement, JetBrains.ReSharper.Psi.ITypeElement newTypeElement, JetBrains.ReSharper.Psi.ITypeElement targetTypeElement) { }
    }
    public abstract class MoveWorkflow<TStaticAnalyser, TMemberInfo> : JetBrains.ReSharper.Refactorings.Workflow.DrivenRefactoringWorkflow
        where TStaticAnalyser : JetBrains.ReSharper.Refactorings.MoveMembers.Analysis.MoveStaticAnalyser<>
        where TMemberInfo :  class, JetBrains.ReSharper.Refactorings.CommonUI.IMemberInfo
    {
        protected TStaticAnalyser myAnalyser;
        protected MoveWorkflow(JetBrains.ProjectModel.ISolution solution, string actionId) { }
        public TStaticAnalyser Analyser { get; }
        public override bool MightModifyManyDocuments { get; }
        protected new JetBrains.ProjectModel.ISolution Solution { get; }
        protected virtual bool CanRunOnSealed() { }
        protected virtual bool ElementCanBeMoved(JetBrains.ReSharper.Psi.IDeclaredElement element) { }
        protected bool IsAvailableEx(JetBrains.Application.DataContext.IDataContext context, out System.Collections.Generic.ICollection<> elements, out JetBrains.ReSharper.Psi.ITypeElement ownerType) { }
    }
    public class ReferenceConsumerOfDelegate : JetBrains.ReSharper.Refactorings.MoveMembers.Common.IReferenceConsumer
    {
        public ReferenceConsumerOfDelegate(JetBrains.ReSharper.Refactorings.MoveMembers.Common.ReferenceConsumerOfDelegate.Do action) { }
        public void InitRef(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public delegate void Do(JetBrains.ReSharper.Psi.Resolve.IReference reference);
    }
    public enum TargetElementTypes
    {
        Interface = 0,
        Class = 1,
        AbstractClass = 2,
    }
    public class TargetTypeWithProjectFile<TTargetTypeWrapper> : JetBrains.ReSharper.Refactorings.CommonUI.BaseMemberInfo, JetBrains.ReSharper.Refactorings.CommonUI.IMemberInfo, JetBrains.ReSharper.Refactorings.CommonUI.IMemberInfoWithDeclaration, JetBrains.ReSharper.Refactorings.MoveMembers.Common.ITargetTypeWithProjectFile
        where TTargetTypeWrapper : JetBrains.ReSharper.Refactorings.MoveMembers.Common.TargetTypeWrapper
    {
        public TargetTypeWithProjectFile(TTargetTypeWrapper targetTypeWrapper, JetBrains.ReSharper.Psi.Tree.ITypeDeclaration typeDeclaration) { }
        public override bool CanChangeAbstract { get; }
        public override bool CanHaveAbstract { get; }
        public override bool Enabled { get; }
        public override bool HasError { get; }
        public override bool HasWarning { get; }
        public override bool Included { get; set; }
        public override bool MakeAbstract { get; set; }
        public override JetBrains.UI.RichText.RichText RichText { get; }
        public TTargetTypeWrapper TargetTypeWrapper { get; }
        public override string ToolTip { get; }
        public JetBrains.ReSharper.Psi.Tree.ITypeDeclaration TypeDeclaration { get; }
        public JetBrains.ReSharper.Psi.ITypeElement TypeElement { get; }
        protected override void SafeUpdate() { }
    }
    public abstract class TargetTypeWrapper
    {
        protected JetBrains.ReSharper.Psi.Pointers.IDeclaredElementPointer<JetBrains.ReSharper.Psi.ITypeElement> myTypeElementPointer;
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ReSharper.Psi.ITypeElement TypeElement { get; }
        public JetBrains.ReSharper.Psi.Pointers.IDeclaredElementPointer<JetBrains.ReSharper.Psi.ITypeElement> TypeElementPointer { get; set; }
    }
}
namespace JetBrains.ReSharper.Refactorings.MoveMembers.ImplBaseUp
{
    
    public interface IPullUpBaseBaseTypeInfo : JetBrains.ReSharper.Refactorings.CommonUI.IMemberInfo, JetBrains.ReSharper.Refactorings.MoveMembers.Common.IBaseTypeInfoBase
    {
        JetBrains.ReSharper.Refactorings.MoveMembers.Common.TargetElementTypes ElementType { get; }
        JetBrains.ReSharper.Refactorings.MoveMembers.Common.TargetElementTypes TargetElementType { get; set; }
    }
    public interface IPullUpBaseItemInfo : JetBrains.ReSharper.Refactorings.CommonUI.IMemberInfo { }
    public interface IPullUpBaseMemberInfo : JetBrains.ReSharper.Refactorings.CommonUI.IMemberInfo, JetBrains.ReSharper.Refactorings.MoveMembers.Common.IMemberInfoBase
    {
        JetBrains.ReSharper.Refactorings.MoveMembers.Common.TargetElementTypes ElementType { get; }
        JetBrains.ReSharper.Refactorings.MoveMembers.ImplBaseUp.PullUpTypes PullUpType { get; }
        JetBrains.ReSharper.Refactorings.MoveMembers.Common.TargetElementTypes TargetElementType { get; set; }
        void DisableMember();
        JetBrains.ReSharper.Refactorings.MoveMembers.ImplBaseUp.PullUpTypes GetPullUpType();
    }
    public abstract class PullUpBase<MEMBER_INFO, STATIC_ANALYSER>
        where MEMBER_INFO :  class, JetBrains.ReSharper.Refactorings.MoveMembers.ImplBaseUp.IPullUpBaseItemInfo
        where STATIC_ANALYSER : JetBrains.ReSharper.Refactorings.MoveMembers.ImplBaseUp.PullUpBaseStaticAnalyser<>
    {
        public PullUpBase(JetBrains.ReSharper.Refactorings.MoveMembers.ImplBaseUp.PullUpBaseWorkflow<STATIC_ANALYSER, MEMBER_INFO> workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver Driver { get; }
        public JetBrains.ReSharper.Refactorings.MoveMembers.Common.IMoveMembersExecuter Executer { get; }
        public JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver RefactoringDriver { set; }
        public JetBrains.ProjectModel.ISolution Solution { get; }
        public JetBrains.ReSharper.Refactorings.MoveMembers.ImplBaseUp.PullUpBaseWorkflow<STATIC_ANALYSER, MEMBER_INFO> Workflow { get; }
        public virtual void AddImplementsSpecification(JetBrains.ReSharper.Psi.Tree.IDeclaration decl, JetBrains.ReSharper.Psi.ITypeElement element, bool name) { }
        public virtual bool CheckConflictsWithTargetClassName(JetBrains.ReSharper.Psi.ITypeElement element, string name) { }
        public abstract JetBrains.ReSharper.Refactorings.MoveMembers.Common.MoveMembersHelper<MEMBER_INFO> GetHelper();
        public abstract bool IsInstanceSpecificEventAccess(JetBrains.ReSharper.Psi.Resolve.IReference reference);
        public void SetExecuter(JetBrains.ReSharper.Refactorings.Workflow.IRefactoringExecuter refactoring) { }
    }
    public abstract class PullUpBaseAnalyzer<STATIC_ANALYSER, MEMBER_INFO> : JetBrains.ReSharper.Refactorings.MoveMembers.Analysis.MoveAnalyser<STATIC_ANALYSER, MEMBER_INFO>
        where STATIC_ANALYSER : JetBrains.ReSharper.Refactorings.MoveMembers.ImplBaseUp.PullUpBaseStaticAnalyser<>
        where MEMBER_INFO :  class, JetBrains.ReSharper.Refactorings.CommonUI.IMemberInfo
    {
        protected JetBrains.ReSharper.Refactorings.MoveMembers.Util.SubstitutionMap mySubstitutionMap;
        public PullUpBaseAnalyzer(STATIC_ANALYSER staticAnalyser) { }
        public JetBrains.ReSharper.Refactorings.MoveMembers.Util.SubstitutionMap SubstitutionMap { get; }
        protected virtual void FindOverridesOf(JetBrains.Application.Progress.IProgressIndicator pi, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IOverridableMember> allMembers, JetBrains.ReSharper.Psi.IPsiServices psiServices) { }
    }
    public abstract class PullUpBaseBaseTypeInfo<MEMBER_INFO> : JetBrains.ReSharper.Refactorings.MoveMembers.Common.BaseTypeInfoBase<MEMBER_INFO>, JetBrains.ReSharper.Refactorings.CommonUI.IMemberInfo, JetBrains.ReSharper.Refactorings.MoveMembers.Common.IBaseTypeInfoBase, JetBrains.ReSharper.Refactorings.MoveMembers.ImplBaseUp.IPullUpBaseBaseTypeInfo
        where MEMBER_INFO :  class, JetBrains.ReSharper.Refactorings.MoveMembers.ImplBaseUp.IPullUpBaseItemInfo
    {
        protected readonly JetBrains.ReSharper.Refactorings.MoveMembers.Common.TargetElementTypes myElementType;
        protected JetBrains.ReSharper.Refactorings.MoveMembers.Common.TargetElementTypes myTargetElementType;
        protected PullUpBaseBaseTypeInfo(JetBrains.ReSharper.Psi.IDeclaredType declaredType, JetBrains.ReSharper.Refactorings.MoveMembers.Common.TargetElementTypes elementType, JetBrains.ReSharper.Refactorings.MoveMembers.Common.TargetElementTypes targetElementType, JetBrains.ReSharper.Refactorings.MoveMembers.Analysis.MoveStaticAnalyser<MEMBER_INFO> analyser, JetBrains.ReSharper.Psi.ITypeElement ownerTypeElement) { }
        public JetBrains.ReSharper.Refactorings.MoveMembers.Common.TargetElementTypes ElementType { get; }
        public JetBrains.ReSharper.Refactorings.MoveMembers.Common.TargetElementTypes TargetElementType { get; set; }
    }
    public abstract class PullUpBaseChainItem : JetBrains.ReSharper.Refactorings.MoveMembers.Common.TargetTypeWrapper { }
    public abstract class PullUpBaseMemberInfo<MEMBER_INFO> : JetBrains.ReSharper.Refactorings.MoveMembers.Common.MemberInfo<MEMBER_INFO>, JetBrains.ReSharper.Refactorings.CommonUI.IMemberInfo, JetBrains.ReSharper.Refactorings.MoveMembers.Common.IMemberInfoBase, JetBrains.ReSharper.Refactorings.MoveMembers.ImplBaseUp.IPullUpBaseMemberInfo
        where MEMBER_INFO :  class, JetBrains.ReSharper.Refactorings.MoveMembers.ImplBaseUp.IPullUpBaseItemInfo
    {
        protected readonly JetBrains.ReSharper.Refactorings.MoveMembers.Common.TargetElementTypes myElementType;
        protected JetBrains.ReSharper.Refactorings.MoveMembers.ImplBaseUp.PullUpTypes myPullUpType;
        protected JetBrains.ReSharper.Refactorings.MoveMembers.Common.TargetElementTypes myTargetElementType;
        protected PullUpBaseMemberInfo(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, bool included, JetBrains.ReSharper.Refactorings.MoveMembers.Common.TargetElementTypes type, JetBrains.ReSharper.Refactorings.MoveMembers.Common.TargetElementTypes elementType, JetBrains.ReSharper.Refactorings.MoveMembers.Analysis.MoveStaticAnalyser<MEMBER_INFO> analyser) { }
        public JetBrains.ReSharper.Refactorings.MoveMembers.Common.TargetElementTypes ElementType { get; }
        public override bool Enabled { get; }
        public override bool ForceEventToMoveAsVirtual { get; set; }
        public override bool MakeAbstract { get; set; }
        public override bool MakeSourceAbstract { get; }
        public override bool MakeTargetAbstract { get; }
        public JetBrains.ReSharper.Refactorings.MoveMembers.ImplBaseUp.PullUpTypes PullUpType { get; }
        public JetBrains.ReSharper.Refactorings.MoveMembers.Common.TargetElementTypes TargetElementType { get; set; }
        public void DisableMember() { }
        public JetBrains.ReSharper.Refactorings.MoveMembers.ImplBaseUp.PullUpTypes GetPullUpType() { }
        public override bool IsPureInstanceMove() { }
        public override bool MakeOverride() { }
        public override bool MakeProtected() { }
        public override bool PerformCutDeclarations() { }
        protected override void SafeUpdate() { }
    }
    public abstract class PullUpBaseRefactoring<TWorkflow, TAnalyser, TStaticAnalyser, TMemberInfo> : JetBrains.ReSharper.Refactorings.MoveMembers.Common.MoveMembersRefactoring<TWorkflow, TAnalyser, TStaticAnalyser, TMemberInfo>
        where TWorkflow : JetBrains.ReSharper.Refactorings.MoveMembers.ImplBaseUp.PullUpBaseWorkflow<, >
        where TAnalyser : JetBrains.ReSharper.Refactorings.MoveMembers.ImplBaseUp.PullUpBaseAnalyzer<, >
        where TStaticAnalyser : JetBrains.ReSharper.Refactorings.MoveMembers.ImplBaseUp.PullUpBaseStaticAnalyser<>
        where TMemberInfo :  class, JetBrains.ReSharper.Refactorings.MoveMembers.ImplBaseUp.IPullUpBaseItemInfo
    {
        protected PullUpBaseRefactoring(TWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public abstract JetBrains.ReSharper.Psi.ITypeElement TargetType { get; }
        protected virtual void CollectForQuasiInterfaces(System.Collections.Generic.JetHashSet<JetBrains.ReSharper.Psi.ITypeParameter> parameters, System.Collections.Generic.JetHashSet<JetBrains.ReSharper.Psi.ITypeParameter> usedParameters) { }
        protected override void CollectMembersToMakeProtected() { }
        protected virtual void CollectParametersOfBaseClassSpecification(System.Collections.Generic.JetHashSet<JetBrains.ReSharper.Psi.ITypeParameter> sourceTypeTypeParameters, System.Collections.Generic.JetHashSet<JetBrains.ReSharper.Psi.ITypeParameter> usedParameters) { }
        public override void CreateTypeParametersMap() { }
        protected JetBrains.ReSharper.Psi.Resolve.ISubstitution GetMatchedSubstitution(JetBrains.ReSharper.Psi.ITypeElement baseClass, System.Collections.Generic.List<JetBrains.ReSharper.Psi.ITypeParameter> typeParameters) { }
        protected JetBrains.ReSharper.Psi.Resolve.ISubstitution GetMatchedSubstitutionBack(JetBrains.ReSharper.Psi.ITypeElement baseClass, System.Collections.Generic.List<JetBrains.ReSharper.Psi.ITypeParameter> typeParameters) { }
        protected System.Collections.Generic.List<JetBrains.ReSharper.Psi.ITypeParameter> GetUsedTypeParameters(JetBrains.ReSharper.Psi.Resolve.ISubstitution fakeSubst, JetBrains.Application.Progress.SubProgressIndicator pi) { }
        protected override bool IgnoreConflictedMember(JetBrains.ReSharper.Psi.ITypeMember info, JetBrains.ReSharper.Psi.ITypeElement element) { }
        protected override void MakeOverridesPublic() { }
        protected override void PrepareData(JetBrains.Application.Progress.SubProgressIndicator pi) { }
    }
    public abstract class PullUpBaseStaticAnalyser<MEMBER_INFO> : JetBrains.ReSharper.Refactorings.MoveMembers.Analysis.MoveStaticAnalyser<MEMBER_INFO>
        where MEMBER_INFO :  class, JetBrains.ReSharper.Refactorings.CommonUI.IMemberInfo
    {
        protected JetBrains.ReSharper.Refactorings.MoveMembers.Common.TargetElementTypes myTargetElementType;
        protected JetBrains.ReSharper.Refactorings.MoveMembers.Common.TargetTypeWithProjectFile<JetBrains.ReSharper.Refactorings.MoveMembers.ImplPullUp.PullUpChainItem> myTargetTypeWithProjectFile;
        public PullUpBaseStaticAnalyser([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.ITypeElement containingType) { }
        public bool AutoExpandSingleChild { get; }
        public JetBrains.ReSharper.Refactorings.MoveMembers.Common.TargetElementTypes ElementType { get; }
        public bool HasAbstractMembers { get; }
        public JetBrains.ReSharper.Refactorings.MoveMembers.Common.TargetElementTypes TargetElementType { get; }
        public JetBrains.ReSharper.Refactorings.MoveMembers.Common.TargetTypeWrapper TargetTargetTypeWrapper { get; }
        public JetBrains.ReSharper.Refactorings.MoveMembers.Common.TargetTypeWithProjectFile<JetBrains.ReSharper.Refactorings.MoveMembers.ImplPullUp.PullUpChainItem> TargetTypeWithProjectFile { get; }
        public override JetBrains.ReSharper.Psi.Tree.ITypeDeclaration GetTargetDeclaration(JetBrains.ReSharper.Psi.ITypeElement typeElement) { }
        public bool SetTargetElementInfo(JetBrains.ReSharper.Refactorings.MoveMembers.ImplPullUp.PullUpChainItem tergetElementInfo) { }
        public override bool Validate() { }
    }
    public abstract class PullUpBaseWorkflow<STATIC_ANALYSER, MEMBER_INFO> : JetBrains.ReSharper.Refactorings.MoveMembers.Common.MoveWorkflow<STATIC_ANALYSER, MEMBER_INFO>
        where STATIC_ANALYSER : JetBrains.ReSharper.Refactorings.MoveMembers.ImplBaseUp.PullUpBaseStaticAnalyser<>
        where MEMBER_INFO :  class, JetBrains.ReSharper.Refactorings.MoveMembers.ImplBaseUp.IPullUpBaseItemInfo
    {
        protected PullUpBaseWorkflow(JetBrains.ProjectModel.ISolution solution, string actionId) { }
        public override JetBrains.ReSharper.Refactorings.Workflow.RefactoringActionGroup ActionGroup { get; }
    }
    public enum PullUpTypes
    {
        Common = 0,
        Interface2Interface = 1,
        Abstract2Interface = 2,
        Instance2Interface = 3,
        Override2Interface = 4,
        Instance2Abstract = 5,
        Override2Abstract = 6,
        Abstract2Abstract = 7,
        Instance2Instance = 8,
        Override2Override = 9,
        Virtual2Interface = 10,
        Virtual2Abstract = 11,
        Virtual2Virtual = 12,
        MoveConstructor = 13,
        MoveConstructorBody = 14,
    }
    public abstract class VBExtractInterfaceBase : JetBrains.ReSharper.Refactorings.MoveMembers.ImplBaseUp.PullUpBase<JetBrains.ReSharper.Refactorings.MoveMembers.ImplExtractInterface.IExtractInterfaceItemInfo, JetBrains.ReSharper.Refactorings.MoveMembers.ImplExtractInterface.ExtractInterfaceStaticAnalyser>, JetBrains.ReSharper.Refactorings.IRefactoringExec, JetBrains.ReSharper.Refactorings.MoveMembers.Common.IMove<JetBrains.ReSharper.Refactorings.MoveMembers.ImplExtractInterface.IExtractInterfaceItemInfo>, JetBrains.ReSharper.Refactorings.MoveMembers.ImplExtractInterface.IExtractInterface
    {
        protected VBExtractInterfaceBase(JetBrains.ReSharper.Refactorings.MoveMembers.ImplBaseUp.PullUpBaseWorkflow<JetBrains.ReSharper.Refactorings.MoveMembers.ImplExtractInterface.ExtractInterfaceStaticAnalyser, JetBrains.ReSharper.Refactorings.MoveMembers.ImplExtractInterface.IExtractInterfaceItemInfo> workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public override void AddImplementsSpecification(JetBrains.ReSharper.Psi.Tree.IDeclaration decl, JetBrains.ReSharper.Psi.ITypeElement element, bool name) { }
        public void GetBaseConstructorDeclarationToInsert(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration) { }
    }
    public abstract class VBExtractSuperclassBase : JetBrains.ReSharper.Refactorings.MoveMembers.ImplBaseUp.PullUpBase<JetBrains.ReSharper.Refactorings.MoveMembers.ImplExtractSuperclass.IExtractSuperclassItemInfo, JetBrains.ReSharper.Refactorings.MoveMembers.ImplExtractSuperclass.ExtractSuperclassStaticAnalyser>, JetBrains.ReSharper.Refactorings.IRefactoringExec, JetBrains.ReSharper.Refactorings.MoveMembers.Common.IMove<JetBrains.ReSharper.Refactorings.MoveMembers.ImplExtractSuperclass.IExtractSuperclassItemInfo>, JetBrains.ReSharper.Refactorings.MoveMembers.ImplExtractSuperclass.IExtractSuperclass
    {
        protected VBExtractSuperclassBase(JetBrains.ReSharper.Refactorings.MoveMembers.ImplBaseUp.PullUpBaseWorkflow<JetBrains.ReSharper.Refactorings.MoveMembers.ImplExtractSuperclass.ExtractSuperclassStaticAnalyser, JetBrains.ReSharper.Refactorings.MoveMembers.ImplExtractSuperclass.IExtractSuperclassItemInfo> workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public override void AddImplementsSpecification(JetBrains.ReSharper.Psi.Tree.IDeclaration decl, JetBrains.ReSharper.Psi.ITypeElement element, bool name) { }
        public void GetBaseConstructorDeclarationToInsert(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration) { }
    }
    public abstract class VBPullUpBase : JetBrains.ReSharper.Refactorings.MoveMembers.ImplBaseUp.PullUpBase<JetBrains.ReSharper.Refactorings.MoveMembers.ImplPullUp.IPullUpItemInfo, JetBrains.ReSharper.Refactorings.MoveMembers.ImplPullUp.PullUpStaticAnalyser>, JetBrains.ReSharper.Refactorings.IRefactoringExec, JetBrains.ReSharper.Refactorings.MoveMembers.Common.IMove<JetBrains.ReSharper.Refactorings.MoveMembers.ImplPullUp.IPullUpItemInfo>, JetBrains.ReSharper.Refactorings.MoveMembers.ImplPullUp.IPullUp
    {
        protected VBPullUpBase(JetBrains.ReSharper.Refactorings.MoveMembers.ImplPullUp.PullUpWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public override void AddImplementsSpecification(JetBrains.ReSharper.Psi.Tree.IDeclaration decl, JetBrains.ReSharper.Psi.ITypeElement element, bool name) { }
        public void GetBaseConstructorDeclarationToInsert(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration) { }
    }
}
namespace JetBrains.ReSharper.Refactorings.MoveMembers.ImplExtractInterface
{
    
    public class ExtractInterfaceAnalyser : JetBrains.ReSharper.Refactorings.MoveMembers.ImplBaseUp.PullUpBaseAnalyzer<JetBrains.ReSharper.Refactorings.MoveMembers.ImplExtractInterface.ExtractInterfaceStaticAnalyser, JetBrains.ReSharper.Refactorings.MoveMembers.ImplExtractInterface.IExtractInterfaceItemInfo>
    {
        public ExtractInterfaceAnalyser(JetBrains.ReSharper.Refactorings.MoveMembers.ImplExtractInterface.ExtractInterfaceStaticAnalyser staticAnalyser) { }
        public override System.Collections.Generic.List<JetBrains.ReSharper.Psi.IMethod> GetSuspectiousMethods() { }
        public override void PrepareData(JetBrains.ReSharper.Refactorings.MoveMembers.Common.IMoveMembersExecuter executer, JetBrains.Application.Progress.IProgressIndicator pi, JetBrains.ReSharper.Psi.ITypeElement targetType) { }
        public void PrepareExtractData(JetBrains.ReSharper.Refactorings.MoveMembers.Common.IMoveMembersExecuter executer, JetBrains.Application.Progress.IProgressIndicator pi, JetBrains.ReSharper.Psi.ITypeElement targetType, JetBrains.ReSharper.Psi.Resolve.ISubstitution baseSubst) { }
    }
    public class ExtractInterfaceBaseTypeInfo : JetBrains.ReSharper.Refactorings.MoveMembers.ImplBaseUp.PullUpBaseBaseTypeInfo<JetBrains.ReSharper.Refactorings.MoveMembers.ImplExtractInterface.IExtractInterfaceItemInfo>, JetBrains.ReSharper.Refactorings.CommonUI.IMemberInfo, JetBrains.ReSharper.Refactorings.MoveMembers.Common.IBaseTypeInfoBase, JetBrains.ReSharper.Refactorings.MoveMembers.ImplBaseUp.IPullUpBaseBaseTypeInfo, JetBrains.ReSharper.Refactorings.MoveMembers.ImplBaseUp.IPullUpBaseItemInfo, JetBrains.ReSharper.Refactorings.MoveMembers.ImplExtractInterface.IExtractInterfaceBaseTypeInfo, JetBrains.ReSharper.Refactorings.MoveMembers.ImplExtractInterface.IExtractInterfaceItemInfo
    {
        public ExtractInterfaceBaseTypeInfo(JetBrains.ReSharper.Psi.IDeclaredType declaredType, JetBrains.ReSharper.Refactorings.MoveMembers.Common.TargetElementTypes elementType, JetBrains.ReSharper.Refactorings.MoveMembers.Common.TargetElementTypes targetElementType, JetBrains.ReSharper.Refactorings.MoveMembers.Analysis.MoveStaticAnalyser<JetBrains.ReSharper.Refactorings.MoveMembers.ImplExtractInterface.IExtractInterfaceItemInfo> analyser, JetBrains.ReSharper.Psi.ITypeElement ownerTypeElement) { }
        protected override JetBrains.ReSharper.Refactorings.MoveMembers.ImplExtractInterface.IExtractInterfaceItemInfo This() { }
    }
    public class ExtractInterfaceChainItem : JetBrains.ReSharper.Refactorings.MoveMembers.Common.TargetTypeWrapper { }
    public class ExtractInterfaceMemberInfo : JetBrains.ReSharper.Refactorings.MoveMembers.ImplBaseUp.PullUpBaseMemberInfo<JetBrains.ReSharper.Refactorings.MoveMembers.ImplExtractInterface.IExtractInterfaceItemInfo>, JetBrains.ReSharper.Refactorings.CommonUI.IMemberInfo, JetBrains.ReSharper.Refactorings.MoveMembers.Common.IMemberInfoBase, JetBrains.ReSharper.Refactorings.MoveMembers.ImplBaseUp.IPullUpBaseItemInfo, JetBrains.ReSharper.Refactorings.MoveMembers.ImplBaseUp.IPullUpBaseMemberInfo, JetBrains.ReSharper.Refactorings.MoveMembers.ImplExtractInterface.IExtractInterfaceItemInfo, JetBrains.ReSharper.Refactorings.MoveMembers.ImplExtractInterface.IExtractInterfaceMemberInfo
    {
        public ExtractInterfaceMemberInfo(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, bool included, JetBrains.ReSharper.Refactorings.MoveMembers.Common.TargetElementTypes type, JetBrains.ReSharper.Refactorings.MoveMembers.Common.TargetElementTypes elementType, JetBrains.ReSharper.Refactorings.MoveMembers.ImplExtractInterface.ExtractInterfaceStaticAnalyser analyser) { }
        public override bool Included { get; set; }
        public override JetBrains.ReSharper.Refactorings.MoveMembers.ImplExtractInterface.IExtractInterfaceItemInfo This() { }
    }
    public class ExtractInterfaceRefactoring : JetBrains.ReSharper.Refactorings.MoveMembers.ImplBaseUp.PullUpBaseRefactoring<JetBrains.ReSharper.Refactorings.MoveMembers.ImplExtractInterface.ExtractInterfaceWorkflow, JetBrains.ReSharper.Refactorings.MoveMembers.ImplExtractInterface.ExtractInterfaceAnalyser, JetBrains.ReSharper.Refactorings.MoveMembers.ImplExtractInterface.ExtractInterfaceStaticAnalyser, JetBrains.ReSharper.Refactorings.MoveMembers.ImplExtractInterface.IExtractInterfaceItemInfo>
    {
        public ExtractInterfaceRefactoring(JetBrains.ReSharper.Refactorings.MoveMembers.ImplExtractInterface.ExtractInterfaceWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public override JetBrains.ReSharper.Psi.Resolve.ISubstitution AllBaseTypeSubst { get; }
        public override JetBrains.ReSharper.Psi.ITypeElement TargetType { get; }
        protected override void CheckConflictsWithExistingsElements(JetBrains.Application.Progress.SubProgressIndicator pi) { }
        protected override void CheckConflictsWithTargetClassName(JetBrains.Application.Progress.SubProgressIndicator subPi) { }
        protected override void CollectForQuasiInterfaces(System.Collections.Generic.JetHashSet<JetBrains.ReSharper.Psi.ITypeParameter> parameters, System.Collections.Generic.JetHashSet<JetBrains.ReSharper.Psi.ITypeParameter> usedParameters) { }
        protected override void CollectParametersOfBaseClassSpecification(System.Collections.Generic.JetHashSet<JetBrains.ReSharper.Psi.ITypeParameter> sourceTypeTypeParameters, System.Collections.Generic.JetHashSet<JetBrains.ReSharper.Psi.ITypeParameter> usedParameters) { }
        protected override JetBrains.ReSharper.Refactorings.MoveMembers.Common.IMove<JetBrains.ReSharper.Refactorings.MoveMembers.ImplExtractInterface.IExtractInterfaceItemInfo> CreateRefactoring(JetBrains.ReSharper.Refactorings.InternalRefactoringLanguageService service, JetBrains.ReSharper.Refactorings.MoveMembers.Common.MoveMembersRefactoring<JetBrains.ReSharper.Refactorings.MoveMembers.ImplExtractInterface.ExtractInterfaceWorkflow, JetBrains.ReSharper.Refactorings.MoveMembers.ImplExtractInterface.ExtractInterfaceAnalyser, JetBrains.ReSharper.Refactorings.MoveMembers.ImplExtractInterface.ExtractInterfaceStaticAnalyser, JetBrains.ReSharper.Refactorings.MoveMembers.ImplExtractInterface.IExtractInterfaceItemInfo> refactoring) { }
        protected override JetBrains.ReSharper.Refactorings.MoveMembers.Common.IMove<JetBrains.ReSharper.Refactorings.MoveMembers.ImplExtractInterface.IExtractInterfaceItemInfo> CreateUnsupportedRefactoring() { }
        public override bool Execute(JetBrains.Application.Progress.IProgressIndicator pi) { }
        protected override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.ITypeElement> GetAllTargetTypes() { }
        protected override bool InitializeBaseType(JetBrains.Application.Progress.SubProgressIndicator subPi) { }
        protected override void PrepareData(JetBrains.Application.Progress.SubProgressIndicator pi) { }
    }
    public class ExtractInterfaceStaticAnalyser : JetBrains.ReSharper.Refactorings.MoveMembers.ImplBaseUp.PullUpBaseStaticAnalyser<JetBrains.ReSharper.Refactorings.MoveMembers.ImplExtractInterface.IExtractInterfaceItemInfo>
    {
        public ExtractInterfaceStaticAnalyser(JetBrains.ReSharper.Psi.ITypeElement containingType, string className, string newNamespace) { }
        public string ClassName { get; set; }
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Refactorings.MoveMembers.ImplExtractInterface.IExtractInterfaceItemInfo> IncludedMembers { get; }
        public System.Collections.Generic.Dictionary<JetBrains.ReSharper.Refactorings.MoveMembers.ImplExtractInterface.ExtractInterfaceMemberInfo, JetBrains.ReSharper.Psi.ITypeElement> MemberInfoToBaseType { get; }
        public bool MoveSibling { get; set; }
        public string NewNamespace { get; }
        protected override void AddBaseTypeInfo(JetBrains.ReSharper.Psi.IDeclaredType declaredType, bool b) { }
        protected override void AddMemberInfo(JetBrains.ReSharper.Psi.ITypeMember member, bool isIncluded) { }
        protected override bool FilterMembers(JetBrains.ReSharper.Psi.ITypeMember member) { }
        public override void InitializeMembers(System.Func<JetBrains.ReSharper.Psi.ITypeMember, bool> isMemberIncluded) { }
        public override bool IsReferenced(JetBrains.ReSharper.Refactorings.MoveMembers.ImplExtractInterface.IExtractInterfaceItemInfo info) { }
    }
    public class ExtractInterfaceWorkflow : JetBrains.ReSharper.Refactorings.MoveMembers.ImplBaseUp.PullUpBaseWorkflow<JetBrains.ReSharper.Refactorings.MoveMembers.ImplExtractInterface.ExtractInterfaceStaticAnalyser, JetBrains.ReSharper.Refactorings.MoveMembers.ImplExtractInterface.IExtractInterfaceItemInfo>
    {
        public JetBrains.DocumentModel.IDocument DocumentToSave;
        public ExtractInterfaceWorkflow(JetBrains.ProjectModel.ISolution solution, string actionId) { }
        public override JetBrains.ReSharper.Refactorings.Workflow.RefactoringActionGroup ActionGroup { get; }
        public JetBrains.ProjectModel.IProjectFile CreatedFile { get; set; }
        public override JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage FirstPendingRefactoringPage { get; }
        public override string HelpKeyword { get; }
        public override string Title { get; }
        public override JetBrains.ReSharper.Refactorings.Workflow.IRefactoringExecuter CreateRefactoring(JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        protected override bool ElementCanBeMoved(JetBrains.ReSharper.Psi.IDeclaredElement element) { }
        public override bool Initialize(JetBrains.Application.DataContext.IDataContext context) { }
        public override bool IsAvailable(JetBrains.Application.DataContext.IDataContext context) { }
        public override bool PreExecute(JetBrains.Application.Progress.IProgressIndicator taskExecutorCreator) { }
        public override void SuccessfulFinish(JetBrains.Application.Progress.IProgressIndicator pi) { }
        public override void UnsuccessfulFinish(JetBrains.Application.Progress.IProgressIndicator pi) { }
    }
    public interface IExtractInterface : JetBrains.ReSharper.Refactorings.IRefactoringExec, JetBrains.ReSharper.Refactorings.MoveMembers.Common.IMove<JetBrains.ReSharper.Refactorings.MoveMembers.ImplExtractInterface.IExtractInterfaceItemInfo> { }
    public interface IExtractInterfaceBaseTypeInfo : JetBrains.ReSharper.Refactorings.CommonUI.IMemberInfo, JetBrains.ReSharper.Refactorings.MoveMembers.Common.IBaseTypeInfoBase, JetBrains.ReSharper.Refactorings.MoveMembers.ImplBaseUp.IPullUpBaseBaseTypeInfo, JetBrains.ReSharper.Refactorings.MoveMembers.ImplBaseUp.IPullUpBaseItemInfo, JetBrains.ReSharper.Refactorings.MoveMembers.ImplExtractInterface.IExtractInterfaceItemInfo { }
    public interface IExtractInterfaceItemInfo : JetBrains.ReSharper.Refactorings.CommonUI.IMemberInfo, JetBrains.ReSharper.Refactorings.MoveMembers.ImplBaseUp.IPullUpBaseItemInfo { }
    public interface IExtractInterfaceMemberInfo : JetBrains.ReSharper.Refactorings.CommonUI.IMemberInfo, JetBrains.ReSharper.Refactorings.MoveMembers.Common.IMemberInfoBase, JetBrains.ReSharper.Refactorings.MoveMembers.ImplBaseUp.IPullUpBaseItemInfo, JetBrains.ReSharper.Refactorings.MoveMembers.ImplBaseUp.IPullUpBaseMemberInfo, JetBrains.ReSharper.Refactorings.MoveMembers.ImplExtractInterface.IExtractInterfaceItemInfo { }
}
namespace JetBrains.ReSharper.Refactorings.MoveMembers.ImplExtractSuperclass
{
    
    public class ExtractSuperclassAnalyser : JetBrains.ReSharper.Refactorings.MoveMembers.ImplBaseUp.PullUpBaseAnalyzer<JetBrains.ReSharper.Refactorings.MoveMembers.ImplExtractSuperclass.ExtractSuperclassStaticAnalyser, JetBrains.ReSharper.Refactorings.MoveMembers.ImplExtractSuperclass.IExtractSuperclassItemInfo>
    {
        public ExtractSuperclassAnalyser(JetBrains.ReSharper.Refactorings.MoveMembers.ImplExtractSuperclass.ExtractSuperclassStaticAnalyser staticAnalyser) { }
        public override System.Collections.Generic.List<JetBrains.ReSharper.Psi.IMethod> GetSuspectiousMethods() { }
        public override void PrepareData(JetBrains.ReSharper.Refactorings.MoveMembers.Common.IMoveMembersExecuter executer, JetBrains.Application.Progress.IProgressIndicator pi, JetBrains.ReSharper.Psi.ITypeElement targetType) { }
    }
    public class ExtractSuperclassBaseTypeInfo : JetBrains.ReSharper.Refactorings.MoveMembers.ImplBaseUp.PullUpBaseBaseTypeInfo<JetBrains.ReSharper.Refactorings.MoveMembers.ImplExtractSuperclass.IExtractSuperclassItemInfo>, JetBrains.ReSharper.Refactorings.CommonUI.IMemberInfo, JetBrains.ReSharper.Refactorings.MoveMembers.Common.IBaseTypeInfoBase, JetBrains.ReSharper.Refactorings.MoveMembers.ImplBaseUp.IPullUpBaseBaseTypeInfo, JetBrains.ReSharper.Refactorings.MoveMembers.ImplBaseUp.IPullUpBaseItemInfo, JetBrains.ReSharper.Refactorings.MoveMembers.ImplExtractSuperclass.IExtractSuperclassBaseTypeInfo, JetBrains.ReSharper.Refactorings.MoveMembers.ImplExtractSuperclass.IExtractSuperclassItemInfo
    {
        public ExtractSuperclassBaseTypeInfo(JetBrains.ReSharper.Psi.IDeclaredType declaredType, JetBrains.ReSharper.Refactorings.MoveMembers.Common.TargetElementTypes elementType, JetBrains.ReSharper.Refactorings.MoveMembers.Common.TargetElementTypes targetElementType, JetBrains.ReSharper.Refactorings.MoveMembers.Analysis.MoveStaticAnalyser<JetBrains.ReSharper.Refactorings.MoveMembers.ImplExtractSuperclass.IExtractSuperclassItemInfo> analyser, JetBrains.ReSharper.Psi.ITypeElement ownerTypeElement) { }
        public override bool Enabled { get; }
        protected override JetBrains.ReSharper.Refactorings.MoveMembers.ImplExtractSuperclass.IExtractSuperclassItemInfo This() { }
    }
    public class ExtractSuperclassChainItem : JetBrains.ReSharper.Refactorings.MoveMembers.Common.TargetTypeWrapper { }
    public class ExtractSuperclassMemberInfo : JetBrains.ReSharper.Refactorings.MoveMembers.ImplBaseUp.PullUpBaseMemberInfo<JetBrains.ReSharper.Refactorings.MoveMembers.ImplExtractSuperclass.IExtractSuperclassItemInfo>, JetBrains.ReSharper.Refactorings.CommonUI.IMemberInfo, JetBrains.ReSharper.Refactorings.MoveMembers.Common.IMemberInfoBase, JetBrains.ReSharper.Refactorings.MoveMembers.ImplBaseUp.IPullUpBaseItemInfo, JetBrains.ReSharper.Refactorings.MoveMembers.ImplBaseUp.IPullUpBaseMemberInfo, JetBrains.ReSharper.Refactorings.MoveMembers.ImplExtractSuperclass.IExtractSuperclassItemInfo, JetBrains.ReSharper.Refactorings.MoveMembers.ImplExtractSuperclass.IExtractSuperclassMemberInfo
    {
        public ExtractSuperclassMemberInfo(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, bool included, JetBrains.ReSharper.Refactorings.MoveMembers.Common.TargetElementTypes type, JetBrains.ReSharper.Refactorings.MoveMembers.Common.TargetElementTypes elementType, JetBrains.ReSharper.Refactorings.MoveMembers.ImplExtractSuperclass.ExtractSuperclassStaticAnalyser analyser) { }
        public override bool Included { get; set; }
        public override JetBrains.ReSharper.Refactorings.MoveMembers.ImplExtractSuperclass.IExtractSuperclassItemInfo This() { }
    }
    public class ExtractSuperclassRefactoring : JetBrains.ReSharper.Refactorings.MoveMembers.ImplBaseUp.PullUpBaseRefactoring<JetBrains.ReSharper.Refactorings.MoveMembers.ImplExtractSuperclass.ExtractSuperclassWorkflow, JetBrains.ReSharper.Refactorings.MoveMembers.ImplExtractSuperclass.ExtractSuperclassAnalyser, JetBrains.ReSharper.Refactorings.MoveMembers.ImplExtractSuperclass.ExtractSuperclassStaticAnalyser, JetBrains.ReSharper.Refactorings.MoveMembers.ImplExtractSuperclass.IExtractSuperclassItemInfo>
    {
        public ExtractSuperclassRefactoring(JetBrains.ReSharper.Refactorings.MoveMembers.ImplExtractSuperclass.ExtractSuperclassWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public override JetBrains.ReSharper.Psi.ITypeElement TargetType { get; }
        protected override void CheckConflictsWithExistingsElements(JetBrains.Application.Progress.SubProgressIndicator pi) { }
        protected override void CheckConflictsWithTargetClassName(JetBrains.Application.Progress.SubProgressIndicator subPi) { }
        protected override JetBrains.ReSharper.Refactorings.MoveMembers.Common.IMove<JetBrains.ReSharper.Refactorings.MoveMembers.ImplExtractSuperclass.IExtractSuperclassItemInfo> CreateRefactoring(JetBrains.ReSharper.Refactorings.InternalRefactoringLanguageService service, JetBrains.ReSharper.Refactorings.MoveMembers.Common.MoveMembersRefactoring<JetBrains.ReSharper.Refactorings.MoveMembers.ImplExtractSuperclass.ExtractSuperclassWorkflow, JetBrains.ReSharper.Refactorings.MoveMembers.ImplExtractSuperclass.ExtractSuperclassAnalyser, JetBrains.ReSharper.Refactorings.MoveMembers.ImplExtractSuperclass.ExtractSuperclassStaticAnalyser, JetBrains.ReSharper.Refactorings.MoveMembers.ImplExtractSuperclass.IExtractSuperclassItemInfo> refactoring) { }
        protected override JetBrains.ReSharper.Refactorings.MoveMembers.Common.IMove<JetBrains.ReSharper.Refactorings.MoveMembers.ImplExtractSuperclass.IExtractSuperclassItemInfo> CreateUnsupportedRefactoring() { }
        public override bool Execute(JetBrains.Application.Progress.IProgressIndicator pi) { }
        protected override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.ITypeElement> GetAllTargetTypes() { }
        protected override bool InitializeBaseType(JetBrains.Application.Progress.SubProgressIndicator subPi) { }
    }
    public class ExtractSuperclassStaticAnalyser : JetBrains.ReSharper.Refactorings.MoveMembers.ImplBaseUp.PullUpBaseStaticAnalyser<JetBrains.ReSharper.Refactorings.MoveMembers.ImplExtractSuperclass.IExtractSuperclassItemInfo>
    {
        public ExtractSuperclassStaticAnalyser(JetBrains.ReSharper.Psi.ITypeElement containingType, string className, string newNamespace, JetBrains.Util.FileSystemPath pathName) { }
        public bool CanPlaceBeside { get; set; }
        public string ClassName { get; set; }
        public JetBrains.Util.FileSystemPath DirectoryPath { get; }
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Refactorings.MoveMembers.ImplExtractSuperclass.IExtractSuperclassItemInfo> IncludedMembers { get; }
        public bool MoveSibling { get; set; }
        public string NewNamespace { get; }
        protected override void AddBaseTypeInfo(JetBrains.ReSharper.Psi.IDeclaredType declaredType, bool b) { }
        protected override void AddMemberInfo(JetBrains.ReSharper.Psi.ITypeMember member, bool isIncluded) { }
        protected override bool FilterMembers(JetBrains.ReSharper.Psi.ITypeMember member) { }
        public override void InitializeMembers(System.Func<JetBrains.ReSharper.Psi.ITypeMember, bool> isMemberIncluded) { }
        public override bool IsReferenced(JetBrains.ReSharper.Refactorings.MoveMembers.ImplExtractSuperclass.IExtractSuperclassItemInfo info) { }
    }
    public class ExtractSuperclassWorkflow : JetBrains.ReSharper.Refactorings.MoveMembers.ImplBaseUp.PullUpBaseWorkflow<JetBrains.ReSharper.Refactorings.MoveMembers.ImplExtractSuperclass.ExtractSuperclassStaticAnalyser, JetBrains.ReSharper.Refactorings.MoveMembers.ImplExtractSuperclass.IExtractSuperclassItemInfo>
    {
        public JetBrains.DocumentModel.IDocument DocumentToSave;
        public ExtractSuperclassWorkflow(JetBrains.ProjectModel.ISolution solution, string actionId) { }
        public override JetBrains.ReSharper.Refactorings.Workflow.RefactoringActionGroup ActionGroup { get; }
        public JetBrains.ProjectModel.IProjectFile CreatedFile { get; }
        public override JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage FirstPendingRefactoringPage { get; }
        public override string HelpKeyword { get; }
        public override string Title { get; }
        public override JetBrains.ReSharper.Refactorings.Workflow.IRefactoringExecuter CreateRefactoring(JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public override bool Initialize(JetBrains.Application.DataContext.IDataContext context) { }
        public override bool IsAvailable(JetBrains.Application.DataContext.IDataContext context) { }
        public override bool PreExecute(JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
        public override void SuccessfulFinish(JetBrains.Application.Progress.IProgressIndicator pi) { }
        public override void UnsuccessfulFinish(JetBrains.Application.Progress.IProgressIndicator pi) { }
    }
    public class Foo { }
    public interface IExtractSuperclass : JetBrains.ReSharper.Refactorings.IRefactoringExec, JetBrains.ReSharper.Refactorings.MoveMembers.Common.IMove<JetBrains.ReSharper.Refactorings.MoveMembers.ImplExtractSuperclass.IExtractSuperclassItemInfo> { }
    public interface IExtractSuperclassBaseTypeInfo : JetBrains.ReSharper.Refactorings.CommonUI.IMemberInfo, JetBrains.ReSharper.Refactorings.MoveMembers.Common.IBaseTypeInfoBase, JetBrains.ReSharper.Refactorings.MoveMembers.ImplBaseUp.IPullUpBaseBaseTypeInfo, JetBrains.ReSharper.Refactorings.MoveMembers.ImplBaseUp.IPullUpBaseItemInfo, JetBrains.ReSharper.Refactorings.MoveMembers.ImplExtractSuperclass.IExtractSuperclassItemInfo { }
    public interface IExtractSuperclassItemInfo : JetBrains.ReSharper.Refactorings.CommonUI.IMemberInfo, JetBrains.ReSharper.Refactorings.MoveMembers.ImplBaseUp.IPullUpBaseItemInfo { }
    public interface IExtractSuperclassMemberInfo : JetBrains.ReSharper.Refactorings.CommonUI.IMemberInfo, JetBrains.ReSharper.Refactorings.MoveMembers.Common.IMemberInfoBase, JetBrains.ReSharper.Refactorings.MoveMembers.ImplBaseUp.IPullUpBaseItemInfo, JetBrains.ReSharper.Refactorings.MoveMembers.ImplBaseUp.IPullUpBaseMemberInfo, JetBrains.ReSharper.Refactorings.MoveMembers.ImplExtractSuperclass.IExtractSuperclassItemInfo { }
}
namespace JetBrains.ReSharper.Refactorings.MoveMembers.ImplPullUp
{
    
    public interface IPullUp : JetBrains.ReSharper.Refactorings.IRefactoringExec, JetBrains.ReSharper.Refactorings.MoveMembers.Common.IMove<JetBrains.ReSharper.Refactorings.MoveMembers.ImplPullUp.IPullUpItemInfo> { }
    public interface IPullUpBaseTypeInfo : JetBrains.ReSharper.Refactorings.CommonUI.IMemberInfo, JetBrains.ReSharper.Refactorings.MoveMembers.Common.IBaseTypeInfoBase, JetBrains.ReSharper.Refactorings.MoveMembers.ImplBaseUp.IPullUpBaseItemInfo, JetBrains.ReSharper.Refactorings.MoveMembers.ImplPullUp.IPullUpItemInfo { }
    public interface IPullUpItemInfo : JetBrains.ReSharper.Refactorings.CommonUI.IMemberInfo, JetBrains.ReSharper.Refactorings.MoveMembers.ImplBaseUp.IPullUpBaseItemInfo { }
    public interface IPullUpMemberInfo : JetBrains.ReSharper.Refactorings.CommonUI.IMemberInfo, JetBrains.ReSharper.Refactorings.MoveMembers.Common.IMemberInfoBase, JetBrains.ReSharper.Refactorings.MoveMembers.ImplBaseUp.IPullUpBaseItemInfo, JetBrains.ReSharper.Refactorings.MoveMembers.ImplBaseUp.IPullUpBaseMemberInfo, JetBrains.ReSharper.Refactorings.MoveMembers.ImplPullUp.IPullUpItemInfo { }
    public class PullUpAnalyzer : JetBrains.ReSharper.Refactorings.MoveMembers.ImplBaseUp.PullUpBaseAnalyzer<JetBrains.ReSharper.Refactorings.MoveMembers.ImplPullUp.PullUpStaticAnalyser, JetBrains.ReSharper.Refactorings.MoveMembers.ImplPullUp.IPullUpItemInfo>
    {
        public PullUpAnalyzer(JetBrains.ReSharper.Refactorings.MoveMembers.ImplPullUp.PullUpStaticAnalyser staticAnalyser) { }
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.ITypeElement> AllTypeElementsToMakeAbstract { get; }
        public void CheckBaseClasses(JetBrains.ReSharper.Refactorings.MoveMembers.Common.IMoveMembersExecuter executer) { }
        protected void CreateTypeParametersMap() { }
        public System.Collections.Generic.List<JetBrains.ReSharper.Psi.ITypeElement> GetBaseClasses() { }
        public override System.Collections.Generic.List<JetBrains.ReSharper.Psi.IMethod> GetSuspectiousMethods() { }
        public override void PrepareData(JetBrains.ReSharper.Refactorings.MoveMembers.Common.IMoveMembersExecuter executer, JetBrains.Application.Progress.IProgressIndicator pi, JetBrains.ReSharper.Psi.ITypeElement targetType) { }
    }
    public class PullUpBaseTypeInfo : JetBrains.ReSharper.Refactorings.MoveMembers.ImplBaseUp.PullUpBaseBaseTypeInfo<JetBrains.ReSharper.Refactorings.MoveMembers.ImplPullUp.IPullUpItemInfo>, JetBrains.ReSharper.Refactorings.CommonUI.IMemberInfo, JetBrains.ReSharper.Refactorings.MoveMembers.Common.IBaseTypeInfoBase, JetBrains.ReSharper.Refactorings.MoveMembers.ImplBaseUp.IPullUpBaseItemInfo, JetBrains.ReSharper.Refactorings.MoveMembers.ImplPullUp.IPullUpBaseTypeInfo, JetBrains.ReSharper.Refactorings.MoveMembers.ImplPullUp.IPullUpItemInfo
    {
        public PullUpBaseTypeInfo(JetBrains.ReSharper.Psi.IDeclaredType declaredType, JetBrains.ReSharper.Refactorings.MoveMembers.Common.TargetElementTypes elementType, JetBrains.ReSharper.Refactorings.MoveMembers.Common.TargetElementTypes targetElementType, JetBrains.ReSharper.Refactorings.MoveMembers.ImplPullUp.PullUpStaticAnalyser analyser, JetBrains.ReSharper.Psi.ITypeElement ownerTypeElement) { }
        public override bool Enabled { get; }
        protected override void SafeUpdate() { }
        protected override JetBrains.ReSharper.Refactorings.MoveMembers.ImplPullUp.IPullUpItemInfo This() { }
    }
    public class PullUpChainItem : JetBrains.ReSharper.Refactorings.MoveMembers.ImplBaseUp.PullUpBaseChainItem
    {
        public PullUpChainItem(JetBrains.ReSharper.Psi.ITypeElement typeElement) { }
        public PullUpChainItem(JetBrains.ReSharper.Psi.ITypeElement typeElement, JetBrains.ReSharper.Refactorings.MoveMembers.ImplPullUp.PullUpChainItem parent) { }
        public System.Collections.Generic.List<JetBrains.ReSharper.Refactorings.MoveMembers.ImplPullUp.PullUpChainItem> BaseElements { get; }
    }
    public class PullUpMemberInfo : JetBrains.ReSharper.Refactorings.MoveMembers.ImplBaseUp.PullUpBaseMemberInfo<JetBrains.ReSharper.Refactorings.MoveMembers.ImplPullUp.IPullUpItemInfo>, JetBrains.ReSharper.Refactorings.CommonUI.IMemberInfo, JetBrains.ReSharper.Refactorings.MoveMembers.Common.IMemberInfoBase, JetBrains.ReSharper.Refactorings.MoveMembers.ImplBaseUp.IPullUpBaseItemInfo, JetBrains.ReSharper.Refactorings.MoveMembers.ImplBaseUp.IPullUpBaseMemberInfo, JetBrains.ReSharper.Refactorings.MoveMembers.ImplPullUp.IPullUpItemInfo, JetBrains.ReSharper.Refactorings.MoveMembers.ImplPullUp.IPullUpMemberInfo
    {
        public PullUpMemberInfo(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, bool included, JetBrains.ReSharper.Refactorings.MoveMembers.Common.TargetElementTypes type, JetBrains.ReSharper.Refactorings.MoveMembers.Common.TargetElementTypes elementType, JetBrains.ReSharper.Refactorings.MoveMembers.Analysis.MoveStaticAnalyser<JetBrains.ReSharper.Refactorings.MoveMembers.ImplPullUp.IPullUpItemInfo> analyser) { }
        public override JetBrains.ReSharper.Refactorings.MoveMembers.ImplPullUp.IPullUpItemInfo This() { }
    }
    public class PullUpRefactoring : JetBrains.ReSharper.Refactorings.MoveMembers.ImplBaseUp.PullUpBaseRefactoring<JetBrains.ReSharper.Refactorings.MoveMembers.ImplPullUp.PullUpWorkflow, JetBrains.ReSharper.Refactorings.MoveMembers.ImplPullUp.PullUpAnalyzer, JetBrains.ReSharper.Refactorings.MoveMembers.ImplPullUp.PullUpStaticAnalyser, JetBrains.ReSharper.Refactorings.MoveMembers.ImplPullUp.IPullUpItemInfo>
    {
        public PullUpRefactoring(JetBrains.ReSharper.Refactorings.MoveMembers.ImplPullUp.PullUpWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public override JetBrains.ReSharper.Psi.ITypeElement TargetType { get; }
        protected override void CheckConflictsWithExistingsElements(JetBrains.Application.Progress.SubProgressIndicator pi) { }
        protected override void CheckConflictsWithTargetClassName(JetBrains.Application.Progress.SubProgressIndicator subPi) { }
        protected override JetBrains.ReSharper.Refactorings.MoveMembers.Common.IMove<JetBrains.ReSharper.Refactorings.MoveMembers.ImplPullUp.IPullUpItemInfo> CreateRefactoring(JetBrains.ReSharper.Refactorings.InternalRefactoringLanguageService service, JetBrains.ReSharper.Refactorings.MoveMembers.Common.MoveMembersRefactoring<JetBrains.ReSharper.Refactorings.MoveMembers.ImplPullUp.PullUpWorkflow, JetBrains.ReSharper.Refactorings.MoveMembers.ImplPullUp.PullUpAnalyzer, JetBrains.ReSharper.Refactorings.MoveMembers.ImplPullUp.PullUpStaticAnalyser, JetBrains.ReSharper.Refactorings.MoveMembers.ImplPullUp.IPullUpItemInfo> refactoring) { }
        protected override JetBrains.ReSharper.Refactorings.MoveMembers.Common.IMove<JetBrains.ReSharper.Refactorings.MoveMembers.ImplPullUp.IPullUpItemInfo> CreateUnsupportedRefactoring() { }
        protected override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.ITypeElement> GetAllTargetTypes() { }
    }
    public class PullUpStaticAnalyser : JetBrains.ReSharper.Refactorings.MoveMembers.ImplBaseUp.PullUpBaseStaticAnalyser<JetBrains.ReSharper.Refactorings.MoveMembers.ImplPullUp.IPullUpItemInfo>, JetBrains.UI.AbstractTreeBuilder.IAbstractTreeStructure
    {
        public PullUpStaticAnalyser([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.ITypeElement ownerType) { }
        public object Root { get; }
        public JetBrains.ReSharper.Refactorings.MoveMembers.Common.TargetTypeWrapper RootTargetTypeWrapper { get; }
        public JetBrains.ReSharper.Psi.ITypeElement TargetType { get; }
        protected override void AddBaseTypeInfo(JetBrains.ReSharper.Psi.IDeclaredType declaredType, bool b) { }
        protected override void AddMemberInfo(JetBrains.ReSharper.Psi.ITypeMember member, bool isIncluded) { }
        public bool AreChildrenEquivalent(object child1, object child2) { }
        public bool CanHaveChildren(object item) { }
        public JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage CommitFirstPage() { }
        public int GetChildEquivalenceHashCode(object child) { }
        public System.Collections.IEnumerable GetChildren(object item) { }
        public override void InitializeMembers(System.Func<JetBrains.ReSharper.Psi.ITypeMember, bool> isMemberIncluded) { }
        public bool IsInitiallyExpanded(object item) { }
        public override bool IsReferenced(JetBrains.ReSharper.Refactorings.MoveMembers.ImplPullUp.IPullUpItemInfo info) { }
        public object RestoreItem(object o) { }
        public object SaveItem(object item) { }
        public void SetTargetTargetTypeWrapper(JetBrains.ReSharper.Refactorings.MoveMembers.Common.TargetTypeWithProjectFile<JetBrains.ReSharper.Refactorings.MoveMembers.ImplPullUp.PullUpChainItem> targetTypeWithProjectFile) { }
        public override bool Validate() { }
    }
    public class PullUpWorkflow : JetBrains.ReSharper.Refactorings.MoveMembers.ImplBaseUp.PullUpBaseWorkflow<JetBrains.ReSharper.Refactorings.MoveMembers.ImplPullUp.PullUpStaticAnalyser, JetBrains.ReSharper.Refactorings.MoveMembers.ImplPullUp.IPullUpItemInfo>
    {
        public PullUpWorkflow(JetBrains.ProjectModel.ISolution solution, string actionId) { }
        public override JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage FirstPendingRefactoringPage { get; }
        public override string HelpKeyword { get; }
        public override string Title { get; }
        public override JetBrains.ReSharper.Refactorings.Workflow.IRefactoringExecuter CreateRefactoring(JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public override bool Initialize(JetBrains.Application.DataContext.IDataContext context) { }
        public override bool IsAvailable(JetBrains.Application.DataContext.IDataContext context) { }
        public override bool PreExecute(JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
        public override bool Validate() { }
    }
}
namespace JetBrains.ReSharper.Refactorings.MoveMembers.ImplPushDown
{
    
    public interface IPushDown : JetBrains.ReSharper.Refactorings.IRefactoringExec, JetBrains.ReSharper.Refactorings.MoveMembers.Common.IMove<JetBrains.ReSharper.Refactorings.MoveMembers.ImplPushDown.IPushDownItemInfo> { }
    public interface IPushDownBaseTypeInfo : JetBrains.ReSharper.Refactorings.CommonUI.IMemberInfo, JetBrains.ReSharper.Refactorings.MoveMembers.ImplPushDown.IPushDownItemInfo { }
    public interface IPushDownItemInfo : JetBrains.ReSharper.Refactorings.CommonUI.IMemberInfo { }
    public interface IPushDownMemberInfo : JetBrains.ReSharper.Refactorings.CommonUI.IMemberInfo, JetBrains.ReSharper.Refactorings.MoveMembers.ImplPushDown.IPushDownItemInfo
    {
        JetBrains.ReSharper.Refactorings.MoveMembers.ImplPushDown.PushDownTypes PushDownType { get; }
    }
    public class PushDownAnalyser : JetBrains.ReSharper.Refactorings.MoveMembers.Analysis.MoveAnalyser<JetBrains.ReSharper.Refactorings.MoveMembers.ImplPushDown.PushDownStaticAnaliser, JetBrains.ReSharper.Refactorings.MoveMembers.ImplPushDown.IPushDownItemInfo>
    {
        protected System.Collections.Generic.Dictionary<JetBrains.ReSharper.Refactorings.MoveMembers.ImplPushDown.PushDownChainItem, JetBrains.ReSharper.Refactorings.MoveMembers.Util.SubstitutionMap> mySubstitutionMap;
        public PushDownAnalyser(JetBrains.ReSharper.Refactorings.MoveMembers.ImplPushDown.PushDownStaticAnaliser myStaticAnalyser) { }
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.ITypeElement> AllTypeElementsToMakeAbstract { get; }
        public System.Collections.Generic.Dictionary<JetBrains.ReSharper.Refactorings.MoveMembers.ImplPushDown.PushDownChainItem, JetBrains.ReSharper.Refactorings.MoveMembers.Util.SubstitutionMap> SubstitutionMap { get; }
        protected void CreateTypeParametersMap() { }
        public override System.Collections.Generic.List<JetBrains.ReSharper.Psi.IMethod> GetSuspectiousMethods() { }
        public override void PrepareData(JetBrains.ReSharper.Refactorings.MoveMembers.Common.IMoveMembersExecuter executer, JetBrains.Application.Progress.IProgressIndicator pi, JetBrains.ReSharper.Psi.ITypeElement targetType) { }
    }
    public abstract class PushDownBase : JetBrains.ReSharper.Refactorings.IRefactoringExec, JetBrains.ReSharper.Refactorings.MoveMembers.Common.IMove<JetBrains.ReSharper.Refactorings.MoveMembers.ImplPushDown.IPushDownItemInfo>, JetBrains.ReSharper.Refactorings.MoveMembers.ImplPushDown.IPushDown
    {
        protected PushDownBase(JetBrains.ReSharper.Refactorings.MoveMembers.ImplPushDown.PushDownWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver Driver { get; }
        public JetBrains.ReSharper.Refactorings.MoveMembers.Common.IMoveMembersExecuter Executer { get; }
        public JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver RefactoringDriver { set; }
        public JetBrains.ProjectModel.ISolution Solution { get; }
        public JetBrains.ReSharper.Refactorings.MoveMembers.ImplPushDown.PushDownWorkflow Workflow { get; }
        public void AddImplementsSpecification(JetBrains.ReSharper.Psi.Tree.IDeclaration decl, JetBrains.ReSharper.Psi.ITypeElement element, bool name) { }
        public abstract bool CheckConflictsWithTargetClassName(JetBrains.ReSharper.Psi.ITypeElement element, string name);
        public void GetBaseConstructorDeclarationToInsert(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration) { }
        public abstract JetBrains.ReSharper.Refactorings.MoveMembers.Common.MoveMembersHelper<JetBrains.ReSharper.Refactorings.MoveMembers.ImplPushDown.IPushDownItemInfo> GetHelper();
        public abstract bool IsInstanceSpecificEventAccess(JetBrains.ReSharper.Psi.Resolve.IReference reference);
        public void SetExecuter(JetBrains.ReSharper.Refactorings.Workflow.IRefactoringExecuter refactoring) { }
    }
    public class PushDownBaseTypeInfo : JetBrains.ReSharper.Refactorings.MoveMembers.Common.BaseTypeInfoBase<JetBrains.ReSharper.Refactorings.MoveMembers.ImplPushDown.IPushDownItemInfo>, JetBrains.ReSharper.Refactorings.CommonUI.IMemberInfo, JetBrains.ReSharper.Refactorings.MoveMembers.ImplPushDown.IPushDownBaseTypeInfo, JetBrains.ReSharper.Refactorings.MoveMembers.ImplPushDown.IPushDownItemInfo
    {
        public PushDownBaseTypeInfo(JetBrains.ReSharper.Psi.IDeclaredType declaredType, JetBrains.ReSharper.Refactorings.MoveMembers.Analysis.MoveStaticAnalyser<JetBrains.ReSharper.Refactorings.MoveMembers.ImplPushDown.IPushDownItemInfo> analyser, JetBrains.ReSharper.Psi.ITypeElement ownerTypeElement) { }
        protected override JetBrains.ReSharper.Refactorings.MoveMembers.ImplPushDown.IPushDownItemInfo This() { }
    }
    public class PushDownChainItem : JetBrains.ReSharper.Refactorings.MoveMembers.Common.TargetTypeWrapper, JetBrains.ReSharper.Refactorings.CommonUI.IMemberInfo
    {
        public PushDownChainItem(JetBrains.ReSharper.Psi.ITypeElement typeElement) { }
        public bool CanChangeAbstract { get; }
        public bool CanHaveAbstract { get; }
        public JetBrains.ReSharper.Psi.IDeclaredElement DeclaredElement { get; }
        public bool Enabled { get; }
        public bool HasError { get; }
        public bool HasWarning { get; }
        public bool Included { get; set; }
        public bool MakeAbstract { get; set; }
        public JetBrains.UI.RichText.RichText RichText { get; }
        public JetBrains.UI.RichText.RichText RichTextWhite { get; }
        public string ToolTip { get; }
        public string GetPresentation() { }
        public void Update() { }
    }
    public class PushDownMemberInfo : JetBrains.ReSharper.Refactorings.MoveMembers.Common.MemberInfo<JetBrains.ReSharper.Refactorings.MoveMembers.ImplPushDown.IPushDownItemInfo>, JetBrains.ReSharper.Refactorings.CommonUI.IMemberInfo, JetBrains.ReSharper.Refactorings.MoveMembers.ImplPushDown.IPushDownItemInfo, JetBrains.ReSharper.Refactorings.MoveMembers.ImplPushDown.IPushDownMemberInfo
    {
        public PushDownMemberInfo(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, bool included, JetBrains.ReSharper.Refactorings.MoveMembers.Analysis.MoveStaticAnalyser<JetBrains.ReSharper.Refactorings.MoveMembers.ImplPushDown.IPushDownItemInfo> analyser) { }
        public override bool MakeAbstract { get; set; }
        public override bool MakeSourceAbstract { get; }
        public override bool MakeTargetOverride { get; }
        public JetBrains.ReSharper.Refactorings.MoveMembers.ImplPushDown.PushDownTypes PushDownType { get; }
        public override bool IsPureInstanceMove() { }
        public override bool MakeOverride() { }
        public override bool MakeProtected() { }
        public override bool PerformCutDeclarations() { }
        public override JetBrains.ReSharper.Refactorings.MoveMembers.ImplPushDown.IPushDownItemInfo This() { }
    }
    public class PushDownRefactoring : JetBrains.ReSharper.Refactorings.MoveMembers.Common.MoveMembersRefactoring<JetBrains.ReSharper.Refactorings.MoveMembers.ImplPushDown.PushDownWorkflow, JetBrains.ReSharper.Refactorings.MoveMembers.ImplPushDown.PushDownAnalyser, JetBrains.ReSharper.Refactorings.MoveMembers.ImplPushDown.PushDownStaticAnaliser, JetBrains.ReSharper.Refactorings.MoveMembers.ImplPushDown.IPushDownItemInfo>
    {
        public PushDownRefactoring(JetBrains.ReSharper.Refactorings.MoveMembers.ImplPushDown.PushDownWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        protected override void CheckConflictsWithExistingsElements(JetBrains.Application.Progress.SubProgressIndicator pi) { }
        protected override void CheckConflictsWithTargetClassName(JetBrains.Application.Progress.SubProgressIndicator subPi) { }
        protected override void CollectMembersToMakeProtected() { }
        protected override JetBrains.ReSharper.Refactorings.MoveMembers.Common.IMove<JetBrains.ReSharper.Refactorings.MoveMembers.ImplPushDown.IPushDownItemInfo> CreateRefactoring(JetBrains.ReSharper.Refactorings.InternalRefactoringLanguageService service, JetBrains.ReSharper.Refactorings.MoveMembers.Common.MoveMembersRefactoring<JetBrains.ReSharper.Refactorings.MoveMembers.ImplPushDown.PushDownWorkflow, JetBrains.ReSharper.Refactorings.MoveMembers.ImplPushDown.PushDownAnalyser, JetBrains.ReSharper.Refactorings.MoveMembers.ImplPushDown.PushDownStaticAnaliser, JetBrains.ReSharper.Refactorings.MoveMembers.ImplPushDown.IPushDownItemInfo> refactoring) { }
        public override void CreateTypeParametersMap() { }
        protected override JetBrains.ReSharper.Refactorings.MoveMembers.Common.IMove<JetBrains.ReSharper.Refactorings.MoveMembers.ImplPushDown.IPushDownItemInfo> CreateUnsupportedRefactoring() { }
        protected override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.ITypeElement> GetAllTargetTypes() { }
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IDeclaredElement> GetMemberImages(JetBrains.ReSharper.Psi.IDeclaredElement oldTypeMember, JetBrains.ReSharper.Psi.ITypeElement targetTypeMember) { }
        public override System.Collections.Generic.IDictionary<JetBrains.ReSharper.Psi.ITypeElement, JetBrains.ReSharper.Psi.ITypeElement> GetTypeMap(JetBrains.ReSharper.Psi.ITypeElement targetType) { }
        protected override bool IgnoreConflictedMember(JetBrains.ReSharper.Psi.ITypeMember info, JetBrains.ReSharper.Psi.ITypeElement element) { }
        protected override void MakeMembersProtected() { }
        protected override bool NeedPasteIn(JetBrains.ReSharper.Psi.ITypeElement type, JetBrains.Util.Pair<JetBrains.ReSharper.Refactorings.MoveMembers.ImplPushDown.IPushDownItemInfo, JetBrains.ReSharper.Psi.Tree.IDeclaration> pair) { }
        protected override void RestoreLocalReferences(JetBrains.Application.Progress.SubProgressIndicator pi) { }
        protected override void RestoreOtherReference(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Refactorings.Util.TypeImages.BaseResolveResultImage resolveResultImage) { }
        public override void SetMemberID(JetBrains.ReSharper.Psi.ITypeMember oldTypeMember, JetBrains.ReSharper.Psi.ITypeMember newTypeMember, JetBrains.ReSharper.Psi.ITypeElement targetTypeElement) { }
        public override void SetRefID(System.Func<JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.ReSharper.Psi.Resolve.IReference> mapDelegate, JetBrains.ReSharper.Psi.ITypeElement targetTypeElement) { }
        public override void SetTypeID(JetBrains.ReSharper.Psi.ITypeElement oldTypeElement, JetBrains.ReSharper.Psi.ITypeElement newTypeElement, JetBrains.ReSharper.Psi.ITypeElement targetTypeElement) { }
    }
    public class PushDownStaticAnaliser : JetBrains.ReSharper.Refactorings.MoveMembers.Analysis.MoveStaticAnalyser<JetBrains.ReSharper.Refactorings.MoveMembers.ImplPushDown.IPushDownItemInfo>
    {
        public PushDownStaticAnaliser(JetBrains.ReSharper.Psi.ITypeElement initialTypeElement) { }
        public System.Collections.Generic.List<JetBrains.ReSharper.Refactorings.MoveMembers.Common.TargetTypeWithProjectFile<JetBrains.ReSharper.Refactorings.MoveMembers.ImplPushDown.PushDownChainItem>> InheritorsItems { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Refactorings.MoveMembers.Common.TargetTypeWithProjectFile<JetBrains.ReSharper.Refactorings.MoveMembers.ImplPushDown.PushDownChainItem>> SelectedInheritorsItems { get; }
        protected override void AddBaseTypeInfo(JetBrains.ReSharper.Psi.IDeclaredType declaredType, bool b) { }
        protected override void AddMemberInfo(JetBrains.ReSharper.Psi.ITypeMember member, bool isIncluded) { }
        public override JetBrains.ReSharper.Psi.Tree.ITypeDeclaration GetTargetDeclaration(JetBrains.ReSharper.Psi.ITypeElement typeElement) { }
        public override void InitializeMembers(System.Func<JetBrains.ReSharper.Psi.ITypeMember, bool> isMemberIncluded) { }
        public override bool IsReferenced(JetBrains.ReSharper.Refactorings.MoveMembers.ImplPushDown.IPushDownItemInfo info) { }
        public void ItemChecked(JetBrains.ReSharper.Refactorings.CommonUI.IMemberInfo memberInfo) { }
    }
    public enum PushDownTypes
    {
        Common = 0,
        Interface2Interface = 1,
        Abstract2Abstract = 2,
        Instance2Instance = 3,
        Virtual2Virtual = 4,
        Override2Override = 5,
        Instance2InstanceA = 6,
        Virtual2VirtualA = 7,
        Override2OverrideA = 8,
    }
    public class PushDownWorkflow : JetBrains.ReSharper.Refactorings.MoveMembers.Common.MoveWorkflow<JetBrains.ReSharper.Refactorings.MoveMembers.ImplPushDown.PushDownStaticAnaliser, JetBrains.ReSharper.Refactorings.MoveMembers.ImplPushDown.IPushDownItemInfo>
    {
        public PushDownWorkflow(JetBrains.ProjectModel.ISolution solution, string actionId) { }
        public override JetBrains.ReSharper.Refactorings.Workflow.RefactoringActionGroup ActionGroup { get; }
        public override JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage FirstPendingRefactoringPage { get; }
        public override string HelpKeyword { get; }
        public override string Title { get; }
        protected override bool CanRunOnSealed() { }
        public override JetBrains.ReSharper.Refactorings.Workflow.IRefactoringExecuter CreateRefactoring(JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public override bool Initialize(JetBrains.Application.DataContext.IDataContext context) { }
        public override bool IsAvailable(JetBrains.Application.DataContext.IDataContext context) { }
        public override bool PreExecute(JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
    }
}
namespace JetBrains.ReSharper.Refactorings.MoveMembers.UI
{
    
    public class DependentMembersControl : JetBrains.UI.CommonControls.SafeUserControl
    {
        public DependentMembersControl(System.Collections.Generic.List<JetBrains.ReSharper.Refactorings.CommonUI.IMemberInfo> memberInfos, JetBrains.ReSharper.Psi.PsiLanguageType language, JetBrains.ReSharper.Refactorings.MoveMembers.UI.Model.SelectionProvider selectionProvider, JetBrains.ReSharper.Psi.IPsiServices psiServices) { }
        public JetBrains.ReSharper.Refactorings.CommonUI.MemberListTreeControl MembersList { get; }
        public void SetMemberInfos(JetBrains.ReSharper.Psi.PsiLanguageType language, System.Collections.Generic.IList<JetBrains.ReSharper.Refactorings.CommonUI.IMemberInfo> outputs, JetBrains.Application.Progress.NullProgressIndicator instance) { }
    }
    public class ExtractInterfaceWindow : JetBrains.UI.CommonControls.SafeUserControl, JetBrains.CommonControls.Validation.IValidatorProvider, JetBrains.ReSharper.Refactorings.MoveMembers.UI.Model.IPullPushWindow, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage
    {
        protected System.Windows.Forms.Label label2;
        protected System.Windows.Forms.Label myTargetLabel;
        public ExtractInterfaceWindow(JetBrains.ReSharper.Psi.IPsiServices psiServices) { }
        public bool ContinueEnabled { get; }
        public string Description { get; }
        public bool DoNotShow { get; }
        public string Title { get; }
        public System.Windows.Forms.Control UI { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.CommonControls.Validation.IValidator> Validators { get; }
        public JetBrains.UI.CrossFramework.EitherControl View { get; }
        public JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage Commit(JetBrains.Application.Progress.IProgressIndicator pi) { }
        protected override void Dispose(bool disposing) { }
        public void FillMembers(JetBrains.ReSharper.Refactorings.MoveMembers.ImplExtractInterface.ExtractInterfaceStaticAnalyser analyzer) { }
        public bool Initialize(JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
        public void ProvideTestDataForUp(string target, string select, string ebstract, string className) { }
        public bool RefreshContents(JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
        public void SelectedTypeChanged() { }
        public void SetAnalyzer(JetBrains.ReSharper.Refactorings.MoveMembers.ImplExtractInterface.ExtractInterfaceStaticAnalyser analyser) { }
    }
    public class ExtractSuperclassWindow : JetBrains.UI.CommonControls.SafeUserControl, JetBrains.CommonControls.Validation.IValidatorProvider, JetBrains.ReSharper.Refactorings.MoveMembers.UI.Model.IPullPushWindow, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage
    {
        protected System.Windows.Forms.Label label2;
        protected System.Windows.Forms.Label myTargetLabel;
        public ExtractSuperclassWindow(JetBrains.ReSharper.Psi.IPsiServices psiServices) { }
        public string Description { get; }
        public bool DoNotShow { get; }
        public string Title { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.CommonControls.Validation.IValidator> Validators { get; }
        public JetBrains.UI.CrossFramework.EitherControl View { get; }
        public JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage Commit(JetBrains.Application.Progress.IProgressIndicator pi) { }
        protected override void Dispose(bool disposing) { }
        public bool Initialize(JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
        public void ProvideTestDataForUp(string target, string select, string ebstract, string className) { }
        public bool RefreshContents(JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
        public void SelectedTypeChanged() { }
        public void SetAnalyzer(JetBrains.ReSharper.Refactorings.MoveMembers.ImplExtractSuperclass.ExtractSuperclassStaticAnalyser analyser) { }
    }
    public interface ISelectTypePartData
    {
        System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Tree.ITypeDeclaration> Declarations { get; }
        JetBrains.ReSharper.Psi.IDeclaredElement DeclaredElement { get; }
        void SetDeclaration(JetBrains.ReSharper.Psi.Tree.ITypeDeclaration declaration);
    }
    public class PullUpWindow : JetBrains.UI.CommonControls.SafeUserControl, JetBrains.ReSharper.Refactorings.MoveMembers.UI.Model.IPullDataProvider, JetBrains.ReSharper.Refactorings.MoveMembers.UI.Model.IPullPushWindow, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage
    {
        public PullUpWindow(JetBrains.ReSharper.Psi.IPsiServices psiServices) { }
        public JetBrains.DataFlow.IProperty<bool> ContinueEnabled { get; }
        public string Description { get; }
        public bool DoNotShow { get; }
        public string Title { get; }
        public JetBrains.UI.CrossFramework.EitherControl View { get; }
        public JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage Commit(JetBrains.Application.Progress.IProgressIndicator pi) { }
        protected override void Dispose(bool disposing) { }
        public void FillMembers(JetBrains.ReSharper.Refactorings.MoveMembers.ImplPullUp.PullUpStaticAnalyser analyzer) { }
        public void FillTypes(JetBrains.UI.AbstractTreeBuilder.IAbstractTreeStructure structure) { }
        public JetBrains.ReSharper.Refactorings.MoveMembers.ImplPullUp.PullUpChainItem GetSelectedTypeElement() { }
        public bool Initialize(JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
        public void ProvideTestDataForUp(string target, string select, string ebstract, string className) { }
        public bool RefreshContents(JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
        public void SelectedTypeChanged() { }
        public void SetAnalyzer(JetBrains.ReSharper.Refactorings.MoveMembers.ImplPullUp.PullUpStaticAnalyser analyser) { }
    }
    public class PushDownWindow : JetBrains.UI.CommonControls.SafeUserControl, JetBrains.ReSharper.Refactorings.MoveMembers.UI.Model.IPullPushWindow, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage
    {
        public PushDownWindow(JetBrains.ReSharper.Psi.IPsiServices psiServices) { }
        public JetBrains.DataFlow.IProperty<bool> ContinueEnabled { get; }
        public string Description { get; }
        public bool DoNotShow { get; }
        public string Title { get; }
        public JetBrains.UI.CrossFramework.EitherControl View { get; }
        public JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage Commit(JetBrains.Application.Progress.IProgressIndicator pi) { }
        protected override void Dispose(bool disposing) { }
        public void FillMembers(JetBrains.ReSharper.Refactorings.MoveMembers.ImplPushDown.PushDownStaticAnaliser analyzer) { }
        public void FillTypes(JetBrains.ReSharper.Refactorings.MoveMembers.ImplPushDown.PushDownStaticAnaliser analyser) { }
        public bool Initialize(JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
        public void ProvideTestDataForUp(string target, string select, string ebstract, string className) { }
        public bool RefreshContents(JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
        public void SelectedTypeChanged() { }
        public void SetAnalyzer(JetBrains.ReSharper.Refactorings.MoveMembers.ImplPushDown.PushDownStaticAnaliser analyser) { }
    }
    public class SelectTypePartWindow : JetBrains.UI.CommonControls.SafeUserControl, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage
    {
        public SelectTypePartWindow(JetBrains.ReSharper.Psi.IPsiServices psiServices, JetBrains.ReSharper.Refactorings.MoveMembers.UI.ISelectTypePartData selectTypePartData) { }
        public JetBrains.DataFlow.IProperty<bool> ContinueEnabled { get; }
        public string Description { get; }
        public bool DoNotShow { get; }
        public string Title { get; }
        public JetBrains.UI.CrossFramework.EitherControl View { get; }
        public JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage Commit(JetBrains.Application.Progress.IProgressIndicator pi) { }
        protected override void Dispose(bool disposing) { }
        public bool Initialize(JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
        public bool RefreshContents(JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
    }
}
namespace JetBrains.ReSharper.Refactorings.MoveMembers.UI.Model
{
    
    public interface IPullDataProvider
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Refactorings.MoveMembers.ImplPullUp.PullUpChainItem GetSelectedTypeElement();
    }
    public interface IPullPushWindow
    {
        void ProvideTestDataForUp(string target, string select, string ebstract, string className);
        void SelectedTypeChanged();
    }
    public class PullUpBaseMembersPresenter : JetBrains.ReSharper.Features.Shared.TreePsiBrowser.TreeModelBrowserPresenter
    {
        protected override void PresentObject(object value, JetBrains.CommonControls.IPresentableItem item, JetBrains.TreeModels.TreeModelNode modelNode, JetBrains.UI.TreeView.PresentationState state) { }
    }
    public class PullUpTreeViewController : JetBrains.UI.TreeView.TreeViewController
    {
        public PullUpTreeViewController() { }
        public override bool QuickSearchSupported { get; }
        public override bool ExpandNodeInitially(JetBrains.TreeModels.TreeModelNode modelNode) { }
        public override bool QuickSearchMatches(JetBrains.TreeModels.TreeModelNode modelNode, string quickSearchText) { }
    }
    public class SelectionProvider
    {
        public SelectionProvider(System.Action selectAllPublic, System.Action selectDependent) { }
        public System.Action SelectAllPublic { get; set; }
        public System.Action SelectDependent { get; set; }
    }
}
namespace JetBrains.ReSharper.Refactorings.MoveMembers.Util
{
    
    public class DependenciesCollector<MEMBER_INFO> : JetBrains.ReSharper.Psi.IRecursiveElementProcessor
        where MEMBER_INFO : JetBrains.ReSharper.Refactorings.CommonUI.IMemberInfo
    {
        public DependenciesCollector(System.Collections.Generic.Dictionary<MEMBER_INFO, System.Collections.Generic.JetHashSet<MEMBER_INFO>> dependenciesMap, MEMBER_INFO info) { }
        public bool ProcessingIsFinished { get; }
        public bool InteriorShouldBeProcessed(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public void ProcessAfterInterior(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public void ProcessBeforeInterior(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
    }
    public class ExtractInterfaceSubstitutionMap : JetBrains.ReSharper.Refactorings.MoveMembers.Util.SubstitutionMap
    {
        public ExtractInterfaceSubstitutionMap(JetBrains.ReSharper.Psi.ITypeElement source, JetBrains.ReSharper.Psi.ITypeElement target, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution) { }
        public override System.Collections.Generic.List<JetBrains.ReSharper.Psi.ITypeParameter> GetAllParameters() { }
        public override JetBrains.ReSharper.Psi.ITypeElement GetParameterImage(JetBrains.ReSharper.Psi.ITypeParameter parameter) { }
    }
    public class InvalidElementPointerException : System.Exception { }
    public class MemberListDataProvider
    {
        public MemberListDataProvider(string selectedMembers, string @abstract) { }
        public void Fill(System.Collections.Generic.IList<JetBrains.ReSharper.Refactorings.CommonUI.IMemberInfo> members) { }
    }
    public class OverrideInfo
    {
        public OverrideInfo(bool declaredAbstract, JetBrains.ReSharper.Psi.ITypeMember overridenMember) { }
        public bool DeclaredAbstract { get; }
        public JetBrains.ReSharper.Psi.ITypeMember OverridenMember { get; }
    }
    public class PullUpSubstitutionMap : JetBrains.ReSharper.Refactorings.MoveMembers.Util.SubstitutionMap
    {
        public PullUpSubstitutionMap(JetBrains.ReSharper.Psi.ITypeElement from, JetBrains.ReSharper.Psi.ITypeElement to) { }
        public override System.Collections.Generic.List<JetBrains.ReSharper.Psi.ITypeParameter> GetAllParameters() { }
        public override JetBrains.ReSharper.Psi.ITypeElement GetParameterImage(JetBrains.ReSharper.Psi.ITypeParameter parameter) { }
    }
    public class PushDownSubstitutionMap : JetBrains.ReSharper.Refactorings.MoveMembers.Util.SubstitutionMap
    {
        public PushDownSubstitutionMap(JetBrains.ReSharper.Psi.ITypeElement from, JetBrains.ReSharper.Psi.ITypeElement to) { }
        public override System.Collections.Generic.List<JetBrains.ReSharper.Psi.ITypeParameter> GetAllParameters() { }
        public override JetBrains.ReSharper.Psi.ITypeElement GetParameterImage(JetBrains.ReSharper.Psi.ITypeParameter parameter) { }
    }
    public class ReferenceCollector : JetBrains.ReSharper.Psi.IRecursiveElementProcessor
    {
        public ReferenceCollector(JetBrains.ReSharper.Refactorings.MoveMembers.Common.IReferenceConsumer owner) { }
        public bool ProcessingIsFinished { get; }
        public bool InteriorShouldBeProcessed(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public void ProcessAfterInterior(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public void ProcessBeforeInterior(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
    }
    public abstract class SubstitutionMap
    {
        protected JetBrains.Util.DataStructures.HybridCollection<JetBrains.ReSharper.Psi.Resolve.ISubstitution> mySubstList;
        public abstract System.Collections.Generic.List<JetBrains.ReSharper.Psi.ITypeParameter> GetAllParameters();
        public abstract JetBrains.ReSharper.Psi.ITypeElement GetParameterImage(JetBrains.ReSharper.Psi.ITypeParameter parameter);
    }
    public class TypeHierarchyDataProvider
    {
        public TypeHierarchyDataProvider(JetBrains.ReSharper.Refactorings.MoveMembers.ImplPullUp.PullUpChainItem rootChainItem, string targetPath) { }
        public JetBrains.ReSharper.Refactorings.MoveMembers.ImplPullUp.PullUpChainItem FindChainItem() { }
    }
    public class TypeParametersCollector : JetBrains.ReSharper.Psi.IRecursiveElementProcessor
    {
        public TypeParametersCollector([JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.JetHashSet<JetBrains.ReSharper.Psi.ITypeParameter> allParameters, JetBrains.ReSharper.Psi.Resolve.ISubstitution fakeSubst) { }
        public bool ProcessingIsFinished { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public System.Collections.Generic.List<JetBrains.ReSharper.Psi.ITypeParameter> UsedParameters { get; }
        public bool InteriorShouldBeProcessed(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public void ProcessAfterInterior(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public void ProcessBeforeInterior(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
    }
}
namespace JetBrains.ReSharper.Refactorings.MoveStaticMembers.Impl
{
    
    public interface IMoveStaticMembersBatchDataProvider
    {
        JetBrains.ReSharper.Psi.AccessRights GetAccessRights();
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.ReSharper.Psi.ITypeElement GetTargetType(JetBrains.ReSharper.Psi.Modules.IPsiModule module, JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext context);
        void SelectMembers(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Refactorings.MoveStaticMembers.Impl.MemberInfo> memberInfos);
    }
    public class MemberInfo : JetBrains.ReSharper.Refactorings.CommonUI.BaseMemberInfo
    {
        public MemberInfo(JetBrains.ReSharper.Psi.IDeclaredElement typeMember) { }
        public override bool CanChangeAbstract { get; }
        public override bool CanHaveAbstract { get; }
        public override bool Enabled { get; }
        public override bool HasError { get; }
        public override bool HasWarning { get; }
        public override bool Included { get; set; }
        public override bool MakeAbstract { get; set; }
        public override string ToolTip { get; }
        public bool MoveIntoItself(JetBrains.ReSharper.Psi.ITypeElement element) { }
    }
    public class TestMoveStaticMemberBatchDataProvider : JetBrains.ReSharper.Refactorings.MoveStaticMembers.Impl.IMoveStaticMembersBatchDataProvider
    {
        public TestMoveStaticMemberBatchDataProvider(string selectedMembers, string accessRights, string type) { }
        public JetBrains.ReSharper.Psi.AccessRights GetAccessRights() { }
        public JetBrains.ReSharper.Psi.ITypeElement GetTargetType(JetBrains.ReSharper.Psi.Modules.IPsiModule module, JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext context) { }
        public void SelectMembers(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Refactorings.MoveStaticMembers.Impl.MemberInfo> memberInfos) { }
    }
    public class TypeMemberCopy
    {
        public TypeMemberCopy(JetBrains.ReSharper.Refactorings.MoveStaticMembers.Impl.MemberInfo member) { }
        public System.Collections.Generic.List<JetBrains.ReSharper.Psi.Tree.IDeclaration> Declarations { get; }
        public JetBrains.ReSharper.Refactorings.MoveStaticMembers.Impl.MemberInfo Member { get; }
        public JetBrains.ReSharper.Psi.ITypeMember OldMember { get; set; }
        public System.Collections.Generic.JetHashSet<JetBrains.ReSharper.Psi.ITypeParameter> OldTypeParameters { get; }
        public System.Collections.Generic.JetHashSet<JetBrains.ReSharper.Psi.ITypeParameter> UsedTypeParameters { get; }
        public void AddDeclaration(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration) { }
    }
    public class TypeParametersCollector : JetBrains.ReSharper.Psi.IRecursiveElementProcessor
    {
        public TypeParametersCollector(JetBrains.ReSharper.Refactorings.MoveStaticMembers.Impl.TypeMemberCopy typeMemberCopy) { }
        public bool ProcessingIsFinished { get; }
        public bool InteriorShouldBeProcessed(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public void ProcessAfterInterior(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public void ProcessBeforeInterior(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
    }
}
namespace JetBrains.ReSharper.Refactorings.MoveStaticMembers
{
    
    public abstract class MoveStaticMembers : JetBrains.ReSharper.Refactorings.Common.RefactoringExecBase<JetBrains.ReSharper.Refactorings.MoveStaticMembers.MoveStaticMembersWorkflow, JetBrains.ReSharper.Refactorings.MoveStaticMembers.MoveStaticMembersRefactoring>
    {
        protected MoveStaticMembers(JetBrains.ReSharper.Refactorings.MoveStaticMembers.MoveStaticMembersWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public virtual JetBrains.ReSharper.Psi.Tree.ITypeDeclaration CreateTypeDeclaration(JetBrains.ReSharper.Psi.Tree.IFile file) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public abstract System.Collections.Generic.Dictionary<JetBrains.ReSharper.Psi.ITypeParameter, JetBrains.ReSharper.Psi.ITypeParameter> PasteDeclaration(JetBrains.ReSharper.Refactorings.MoveStaticMembers.Impl.TypeMemberCopy copy, out JetBrains.ReSharper.Psi.ITypeMember newTypeMember);
        protected void PutOldTypeParameters(JetBrains.ReSharper.Refactorings.MoveStaticMembers.Impl.TypeMemberCopy memberInfo, System.Collections.Generic.Dictionary<JetBrains.ReSharper.Psi.ITypeParameter, JetBrains.ReSharper.Psi.ITypeParameter> ret, JetBrains.ReSharper.Psi.ITypeMember newTypeMember) { }
        public abstract void RemoveOldDeclaration(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration);
        public virtual void SetNotPartial(JetBrains.ReSharper.Psi.ITypeMember member) { }
    }
    public class MoveStaticMembersControl : JetBrains.UI.CommonControls.SafeTableLayoutPanel, JetBrains.CommonControls.Validation.IValidatorProvider, JetBrains.ReSharper.Refactorings.MoveMembers.UI.ISelectTypePartData, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage
    {
        public MoveStaticMembersControl([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Refactorings.MoveStaticMembers.MoveStaticMembersWorkflow workflow) { }
        public JetBrains.DataFlow.IProperty<bool> ContinueEnabled { get; }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Tree.ITypeDeclaration> Declarations { get; }
        public JetBrains.ReSharper.Psi.IDeclaredElement DeclaredElement { get; }
        public string Description { get; }
        public bool DoNotShow { get; }
        public string Title { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.CommonControls.Validation.IValidator> Validators { get; }
        public JetBrains.UI.CrossFramework.EitherControl View { get; }
        public JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage Commit(JetBrains.Application.Progress.IProgressIndicator pi) { }
        public bool Initialize(JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
        public bool RefreshContents(JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
        public void SetDeclaration(JetBrains.ReSharper.Psi.Tree.ITypeDeclaration declaration) { }
    }
    public class MoveStaticMembersHelper : JetBrains.ReSharper.Refactorings.IWorkflowExec
    {
        public virtual bool IsLanguageSupported { get; }
    }
    public class MoveStaticMembersRefactoring : JetBrains.ReSharper.Refactorings.Common.DrivenRefactoring<JetBrains.ReSharper.Refactorings.MoveStaticMembers.MoveStaticMembersWorkflow, JetBrains.ReSharper.Refactorings.MoveStaticMembers.MoveStaticMembers>, JetBrains.ReSharper.Refactorings.MoveMembers.Common.IImageCollector, JetBrains.ReSharper.Refactorings.MoveMembers.Common.IReferenceConsumer
    {
        public MoveStaticMembersRefactoring(JetBrains.ReSharper.Refactorings.MoveStaticMembers.MoveStaticMembersWorkflow workFlow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Psi.Tree.ITypeDeclaration KnownDeclaration { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.ITypeMember> NewMembers { get; }
        public JetBrains.ReSharper.Psi.ITypeElement TargetType { get; }
        protected override JetBrains.ReSharper.Refactorings.MoveStaticMembers.MoveStaticMembers CreateRefactoringInternal(JetBrains.ReSharper.Refactorings.InternalRefactoringLanguageService service) { }
        protected override JetBrains.ReSharper.Refactorings.MoveStaticMembers.MoveStaticMembers CreateUnsupportedRefactoring() { }
        public override bool Execute(JetBrains.Application.Progress.IProgressIndicator pi) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IDeclaredElement> GetMemberImages(JetBrains.ReSharper.Psi.IDeclaredElement oldTypeMember, JetBrains.ReSharper.Psi.ITypeElement targetTypeMember) { }
        public System.Collections.Generic.IDictionary<JetBrains.ReSharper.Psi.ITypeElement, JetBrains.ReSharper.Psi.ITypeElement> GetTypeMap(JetBrains.ReSharper.Psi.ITypeElement targetType) { }
        public void InitRef(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public void SetMemberID(JetBrains.ReSharper.Psi.ITypeMember oldTypeMember, JetBrains.ReSharper.Psi.ITypeMember newTypeMember, JetBrains.ReSharper.Psi.ITypeElement targetTypeElement) { }
        public void SetRefID(System.Func<JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.ReSharper.Psi.Resolve.IReference> mapDelegate, JetBrains.ReSharper.Psi.ITypeElement targetTypeElement) { }
        public void SetRefID(System.Func<JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.ReSharper.Psi.Resolve.IReference> mapDelegate) { }
        public void SetTypeID(JetBrains.ReSharper.Psi.ITypeElement oldTypeElement, JetBrains.ReSharper.Psi.ITypeElement newTypeElement) { }
        public void SetTypeID(JetBrains.ReSharper.Psi.ITypeElement oldTypeElement, JetBrains.ReSharper.Psi.ITypeElement newTypeElement, JetBrains.ReSharper.Psi.ITypeElement targetTypeElement) { }
    }
    public class MoveStaticMembersWorkflow : JetBrains.ReSharper.Refactorings.WorkflowNew.DrivenRefactoringWorkflow2<JetBrains.ReSharper.Refactorings.MoveStaticMembers.MoveStaticMembersHelper>
    {
        protected JetBrains.ReSharper.Refactorings.MoveStaticMembers.MoveStaticMembersRefactoring myRefactoring;
        public MoveStaticMembersWorkflow(JetBrains.ProjectModel.ISolution solution, string actuionId) { }
        public JetBrains.ReSharper.Psi.AccessRights AccessRights { get; }
        public override JetBrains.ReSharper.Refactorings.Workflow.RefactoringActionGroup ActionGroup { get; }
        public override JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage FirstPendingRefactoringPage { get; }
        public override string HelpKeyword { get; }
        public virtual System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Refactorings.MoveStaticMembers.Impl.MemberInfo> IncludedMembers { get; }
        public JetBrains.ReSharper.Psi.PsiLanguageType LanguageType { get; }
        public System.Collections.Generic.List<JetBrains.ReSharper.Refactorings.CommonUI.IMemberInfo> MemberInfos { get; }
        public override bool MightModifyManyDocuments { get; }
        public JetBrains.ProjectModel.IProjectFile NewFile { get; }
        protected virtual string NewFileExtension { get; }
        public JetBrains.ProjectModel.IProjectFolder NewFolder { get; set; }
        public string NewNamespaceName { get; set; }
        public string NewTypeName { get; set; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Psi.ITypeElement OwnerMember { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ProjectModel.IProjectFile OwnerProjectFile { get; }
        public JetBrains.ReSharper.Psi.Pointers.IDeclaredElementPointer<JetBrains.ReSharper.Psi.ITypeElement> TargetElementPointer { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Psi.ITreeNodePointer<JetBrains.ReSharper.Psi.Tree.ITypeDeclaration> TargetPointer { get; }
        public override string Title { get; }
        protected virtual bool CanMove(JetBrains.ReSharper.Psi.ITypeMember typeMember) { }
        public virtual JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage ChooseFolderForNewClass(string typeName) { }
        protected override JetBrains.ReSharper.Refactorings.MoveStaticMembers.MoveStaticMembersHelper CreateHelper(JetBrains.ReSharper.Refactorings.IRefactoringLanguageService service) { }
        public override JetBrains.ReSharper.Refactorings.Workflow.IRefactoringExecuter CreateRefactoring(JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        protected override JetBrains.ReSharper.Refactorings.MoveStaticMembers.MoveStaticMembersHelper CreateUnsupportedHelper() { }
        public override bool Initialize(JetBrains.Application.DataContext.IDataContext context) { }
        protected bool IsAvailable(JetBrains.Application.DataContext.IDataContext context, out System.Collections.Generic.IList<> typeMembers, out JetBrains.ReSharper.Psi.ITypeElement ownerType) { }
        public override bool IsAvailable(JetBrains.Application.DataContext.IDataContext context) { }
        public override bool PreExecute(JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
        public void SetProspectiveAccessRights(JetBrains.ReSharper.Psi.AccessRights rights) { }
        public void SetProvider(JetBrains.ReSharper.Refactorings.MoveStaticMembers.Impl.IMoveStaticMembersBatchDataProvider value) { }
        public void SetTargetDeclaration(JetBrains.ReSharper.Psi.Tree.ITypeDeclaration declaration) { }
        public bool TestMemberInfos_AnyIncluded() { }
        public JetBrains.Util.JetTuple<JetBrains.CommonControls.Validation.ValidatorSeverity, JetBrains.UI.RichText.RichText> TestMemberInfosNoMoveIntoItself(JetBrains.ReSharper.Psi.ITypeElement element) { }
        public JetBrains.Util.JetTuple<JetBrains.CommonControls.Validation.ValidatorSeverity, JetBrains.UI.RichText.RichText> TestTypeElement([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.ITypeElement typeElement) { }
    }
}
namespace JetBrains.ReSharper.Refactorings.OverridesSupport
{
    
    public class HierarchyMember
    {
        public HierarchyMember(JetBrains.ReSharper.Refactorings.OverridesSupport.HierarchyProblem hierarchyProblem, JetBrains.ReSharper.Psi.IOverridableMember member) { }
        public HierarchyMember(JetBrains.ReSharper.Psi.IOverridableMember member) { }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Refactorings.OverridesSupport.HierarchyProblem> HierarchyProblems { get; set; }
        public JetBrains.ReSharper.Psi.IOverridableMember Member { get; }
        public bool Equals(JetBrains.ReSharper.Refactorings.OverridesSupport.HierarchyMember hierarchyMember) { }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
    }
    public abstract class HierarchyProblem
    {
        public virtual JetBrains.ReSharper.Psi.IOverridableMember NonIncudedProblemSource { get; }
    }
    public class ImplementsMemberFromCompiledCode : JetBrains.ReSharper.Refactorings.OverridesSupport.HierarchyProblem
    {
        public ImplementsMemberFromCompiledCode() { }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Psi.OverridableMemberInstance> CompiledMembers { get; }
    }
    public class ImplementsMemberProblem : JetBrains.ReSharper.Refactorings.OverridesSupport.HierarchyProblem
    {
        public ImplementsMemberProblem(JetBrains.ReSharper.Psi.OverridableMemberInstance memberInstance, JetBrains.ReSharper.Psi.IClass @class) { }
        public JetBrains.ReSharper.Psi.IClass Class { get; }
        public JetBrains.ReSharper.Psi.OverridableMemberInstance MemberInstance { get; }
        public override JetBrains.ReSharper.Psi.IOverridableMember NonIncudedProblemSource { get; }
    }
    public class InterfaceIsQuasiImplementedProblem : JetBrains.ReSharper.Refactorings.OverridesSupport.HierarchyProblem
    {
        public InterfaceIsQuasiImplementedProblem(JetBrains.ReSharper.Psi.IClass jointClass, JetBrains.ReSharper.Psi.OverridableMemberInstance implementingMember) { }
        public JetBrains.ReSharper.Psi.OverridableMemberInstance ImplementingMember { get; }
        public JetBrains.ReSharper.Psi.IClass JointClass { get; }
        public override JetBrains.ReSharper.Psi.IOverridableMember NonIncudedProblemSource { get; }
    }
    public class IsImplementedInCompiledCode : JetBrains.ReSharper.Refactorings.OverridesSupport.HierarchyProblem
    {
        public IsImplementedInCompiledCode() { }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Psi.OverridableMemberInstance> CompiledMembers { get; }
    }
    public class OverridesFinder
    {
        public System.Collections.Generic.JetHashSet<JetBrains.ReSharper.Refactorings.OverridesSupport.HierarchyMember> Overrides { get; }
        public static JetBrains.ReSharper.Refactorings.OverridesSupport.OverridesFinder CreateInstance(JetBrains.ReSharper.Psi.IOverridableMember overridableMember) { }
        public void Find(JetBrains.Application.Progress.IProgressIndicator pi) { }
    }
}
namespace JetBrains.ReSharper.Refactorings.PostRename
{
    
    public class NameSuggestionTreeControl : JetBrains.UI.CommonControls.SafeTreeList
    {
        public NameSuggestionTreeControl(JetBrains.ProjectModel.ISolution solution) { }
        public JetBrains.ReSharper.Refactorings.PostRename.PostRenameModel.NameChanges NameChanges { get; set; }
        public bool RefreshContentsSync() { }
    }
    public class PostRenameExec : JetBrains.ReSharper.Refactorings.Common.IDrivenRefactoringExec, JetBrains.ReSharper.Refactorings.IRefactoringExec
    {
        public static JetBrains.ReSharper.Refactorings.PostRename.PostRenameExec Instance;
        public JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver RefactoringDriver { get; set; }
        public void SetExecuter(JetBrains.ReSharper.Refactorings.Workflow.IRefactoringExecuter executer) { }
    }
    public class PostRenameRefactoring : JetBrains.ReSharper.Refactorings.Common.DrivenRefactoring<JetBrains.ReSharper.Refactorings.PostRename.PostRenameWorkflow, JetBrains.ReSharper.Refactorings.PostRename.PostRenameExec>
    {
        public PostRenameRefactoring(JetBrains.ReSharper.Refactorings.PostRename.PostRenameWorkflow workFlow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        protected override JetBrains.ReSharper.Refactorings.PostRename.PostRenameExec CreateRefactoringInternal(JetBrains.ReSharper.Refactorings.InternalRefactoringLanguageService service) { }
        public override bool Execute(JetBrains.Application.Progress.IProgressIndicator pi) { }
    }
    public class PostRenameWorkflow : JetBrains.ReSharper.Refactorings.Workflow.DrivenRefactoringWorkflow
    {
        public PostRenameWorkflow(JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.PostRename.PostRenameModel.IPostRenameProvider provider, string actionId) { }
        public override JetBrains.ReSharper.Refactorings.Workflow.RefactoringActionGroup ActionGroup { get; }
        public override JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage FirstPendingRefactoringPage { get; }
        public override string HelpKeyword { get; }
        public override bool MightModifyManyDocuments { get; }
        public JetBrains.ReSharper.Refactorings.PostRename.PostRenameModel.IPostRenameProvider Provider { get; }
        public override string Title { get; }
        public override JetBrains.ReSharper.Refactorings.Workflow.IRefactoringExecuter CreateRefactoring(JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public override bool Initialize(JetBrains.Application.DataContext.IDataContext context) { }
        public override bool IsAvailable(JetBrains.Application.DataContext.IDataContext context) { }
    }
    public class RenameDerivedElementsPage : JetBrains.UI.CommonControls.SafeUserControl, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage
    {
        public RenameDerivedElementsPage(JetBrains.ReSharper.Refactorings.PostRename.PostRenameModel.IPostRenameProvider provider, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.PostRename.PostRenameModel.NameChanges nameChanges) { }
        public JetBrains.DataFlow.IProperty<bool> ContinueEnabled { get; }
        public string Description { get; }
        public bool DoNotShow { get; }
        public string Title { get; }
        public JetBrains.UI.CrossFramework.EitherControl View { get; }
        public JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage Commit(JetBrains.Application.Progress.IProgressIndicator pi) { }
        protected override void Dispose(bool disposing) { }
        public bool Initialize(JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
        public bool RefreshContents(JetBrains.Application.Progress.IProgressIndicator pi) { }
    }
}
namespace JetBrains.ReSharper.Refactorings.PostRename.PostRenameModel
{
    
    public interface IPostRenameProvider
    {
        string PostRenamePageTitle { get; }
        JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage CommitDerivedRenames(JetBrains.ReSharper.Refactorings.PostRename.PostRenameModel.NameChanges change, JetBrains.Application.Progress.IProgressIndicator pi);
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Refactorings.PostRename.PostRenameModel.NameChanges GetNameChanges();
    }
    public class NameChange : System.IComparable
    {
        public NameChange(string newName, string oldName) { }
        public string Description { get; }
        public JetBrains.ReSharper.Refactorings.RenameModel.ElementChange[] ElementChanges { get; }
        public bool IsValid { get; }
        public string NewName { get; set; }
        public JetBrains.ReSharper.Refactorings.PostRename.PostRenameModel.NameChangeState State { get; }
        public void AddDeclaredElement(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
        public void Clear() { }
        public int CompareTo(object obj) { }
        public void SetSelected(bool value) { }
    }
    public class NameChanges
    {
        public NameChanges() { }
        public JetBrains.ReSharper.Refactorings.PostRename.PostRenameModel.NameChange[] Changes { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ReSharper.Refactorings.RenameModel.AtomicRenameBase[] BuildAtomicRenames() { }
        public void Dispose() { }
        public void SetDeclaredElements(System.Collections.Generic.IList<JetBrains.ReSharper.Refactorings.Rename.DerivedDeclaredElement> derivedElements) { }
    }
    public enum NameChangeState
    {
        Enabled = 0,
        Disabled = 1,
        Undefined = 2,
    }
}
namespace JetBrains.ReSharper.Refactorings.Property2Auto
{
    
    public class static AccessCompareUtil
    {
        public static JetBrains.ReSharper.Psi.AccessRights Max(params JetBrains.ReSharper.Psi.AccessRights[] r1) { }
        public static JetBrains.ReSharper.Psi.AccessRights Max(JetBrains.ReSharper.Psi.AccessRights r1) { }
        public static JetBrains.ReSharper.Psi.AccessRights Max(JetBrains.ReSharper.Psi.AccessRights r1, JetBrains.ReSharper.Psi.AccessRights r2) { }
        public static JetBrains.ReSharper.Psi.AccessRights Min(JetBrains.ReSharper.Psi.AccessRights r1, JetBrains.ReSharper.Psi.AccessRights r2) { }
    }
    public interface IProperty2AutoChecker
    {
        bool IsPropertyWithBackingField(JetBrains.ReSharper.Psi.IProperty property, out JetBrains.ReSharper.Psi.IField field);
    }
    public interface IProperty2AutoWorkflowProvider : JetBrains.ReSharper.Feature.Services.ActionsMenu.IWorkflowProvider<JetBrains.ReSharper.Refactorings.Workflow.IRefactoringWorkflow, JetBrains.ReSharper.Refactorings.Workflow.RefactoringActionGroup>, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringWorkflowProvider { }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "Property2Auto"})]
    public class Property2AutoAction : JetBrains.ReSharper.Refactorings.Workflow.ExtensibleRefactoringAction<JetBrains.ReSharper.Refactorings.Property2Auto.IProperty2AutoWorkflowProvider>
    {
        public const string ACTION_ID = "Property2Auto";
        protected override JetBrains.UI.RichText.RichText Caption { get; }
    }
    public abstract class Property2AutoBase : JetBrains.ReSharper.Refactorings.Common.RefactoringExecBase<JetBrains.ReSharper.Refactorings.Property2Auto.Property2AutoWorkflow, JetBrains.ReSharper.Refactorings.Property2Auto.Property2AutoRefactoring>
    {
        protected Property2AutoBase(JetBrains.ReSharper.Refactorings.Property2Auto.Property2AutoWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public abstract void CheckInitializer();
        [JetBrains.Annotations.CanBeNullAttribute()]
        public abstract JetBrains.ReSharper.Psi.IProperty CreateDeclaration(JetBrains.ReSharper.Psi.AccessRights propertyRights, JetBrains.ReSharper.Psi.AccessRights setterRights, JetBrains.ReSharper.Psi.AccessRights getterRights);
        public abstract void RemoveOldDeclarations();
        public abstract void ScanForConflicts(JetBrains.ReSharper.Psi.Resolve.IReference reference);
        public abstract void ScanUsagesFromStructConstructor(JetBrains.ReSharper.Psi.Resolve.IReference reference);
    }
    public class Property2AutoBaseUnsupported : JetBrains.ReSharper.Refactorings.Property2Auto.Property2AutoBase
    {
        public Property2AutoBaseUnsupported(JetBrains.ReSharper.Refactorings.Property2Auto.Property2AutoWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public override void CheckInitializer() { }
        public override JetBrains.ReSharper.Psi.IProperty CreateDeclaration(JetBrains.ReSharper.Psi.AccessRights propertyRights, JetBrains.ReSharper.Psi.AccessRights setterRights, JetBrains.ReSharper.Psi.AccessRights getterRights) { }
        public override void RemoveOldDeclarations() { }
        public override void ScanForConflicts(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public override void ScanUsagesFromStructConstructor(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
    }
    public class Property2AutoRefactoring : JetBrains.ReSharper.Refactorings.Common.DrivenRefactoring<JetBrains.ReSharper.Refactorings.Property2Auto.Property2AutoWorkflow, JetBrains.ReSharper.Refactorings.Property2Auto.Property2AutoBase>
    {
        public Property2AutoRefactoring(JetBrains.ReSharper.Refactorings.Property2Auto.Property2AutoWorkflow workFlow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public JetBrains.ReSharper.Psi.ITypeElement ContainingType { get; }
        public JetBrains.ReSharper.Psi.IField Field { get; }
        public bool IsFromStruct { get; }
        public JetBrains.ReSharper.Psi.IProperty Property { get; }
        protected override JetBrains.ReSharper.Refactorings.Property2Auto.Property2AutoBase CreateRefactoringInternal(JetBrains.ReSharper.Refactorings.InternalRefactoringLanguageService service) { }
        protected override JetBrains.ReSharper.Refactorings.Property2Auto.Property2AutoBase CreateUnsupportedRefactoring() { }
        public override bool Execute(JetBrains.Application.Progress.IProgressIndicator pi) { }
    }
    public class Property2AutoWorkflow : JetBrains.ReSharper.Refactorings.Workflow.DrivenRefactoringWorkflow
    {
        public Property2AutoWorkflow(JetBrains.ProjectModel.ISolution solution, string actionId) { }
        public override JetBrains.ReSharper.Refactorings.Workflow.RefactoringActionGroup ActionGroup { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Psi.ITypeElement ContainingType { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Psi.IField Field { get; }
        public override JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage FirstPendingRefactoringPage { get; }
        public override string HelpKeyword { get; }
        public override bool MightModifyManyDocuments { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Psi.IProperty Property { get; }
        public override string Title { get; }
        public override JetBrains.ReSharper.Refactorings.Workflow.IRefactoringExecuter CreateRefactoring(JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public override bool Initialize(JetBrains.Application.DataContext.IDataContext context) { }
        public override bool IsAvailable(JetBrains.Application.DataContext.IDataContext context) { }
        public static bool IsAvailableForDeclaredElement(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
        public override bool PostExecute(JetBrains.Application.Progress.IProgressIndicator pi) { }
        public void SetNewDocumentRange(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration) { }
        public override void SuccessfulFinish(JetBrains.Application.Progress.IProgressIndicator pi) { }
    }
}
namespace JetBrains.ReSharper.Refactorings.Property2Function
{
    
    public interface IProperty2FucntionWorkflowProvider : JetBrains.ReSharper.Feature.Services.ActionsMenu.IWorkflowProvider<JetBrains.ReSharper.Refactorings.Workflow.IRefactoringWorkflow, JetBrains.ReSharper.Refactorings.Workflow.RefactoringActionGroup>, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringWorkflowProvider { }
    public interface IProperty2Function : JetBrains.ReSharper.Refactorings.IRefactoringExec
    {
        void ExecuteDeclarationRefactoring(JetBrains.ReSharper.Psi.IDeclaredElement propertyOrMethod, JetBrains.Application.Progress.IProgressIndicator pi, bool ifConflict);
        void ExecuteReferencesRefactoring(JetBrains.ReSharper.Psi.Resolve.IReference reference);
    }
    public interface IProperty2FunctionDataProvider
    {
        bool ConvertGetter { get; }
        bool ConvertSetter { get; }
        string GetterName { get; }
        string SetterName { get; }
    }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "Property2Function"})]
    public class Property2FucntionAction : JetBrains.ReSharper.Refactorings.Workflow.ExtensibleRefactoringAction<JetBrains.ReSharper.Refactorings.Property2Function.IProperty2FucntionWorkflowProvider>
    {
        public const string ACTION_ID = "Property2Function";
        protected override JetBrains.UI.RichText.RichText Caption { get; }
    }
    public abstract class Property2FunctionBase : JetBrains.ReSharper.Refactorings.Common.Convert.ConvertBase<JetBrains.ReSharper.Refactorings.Property2Function.Property2FunctionWorkflow, JetBrains.ReSharper.Refactorings.Property2Function.Property2FunctionRefactoring>
    {
        protected JetBrains.ReSharper.Refactorings.Common.Convert.Property2FunctionReferencesProcessor myReferencesProcessor;
        protected Property2FunctionBase(JetBrains.ReSharper.Refactorings.Property2Function.Property2FunctionWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public override void CheckConflictWithMethod(JetBrains.ReSharper.Psi.IMethod method, JetBrains.ReSharper.Psi.IDeclaredElement existingDeclaration, bool isBase, bool isInheritor) { }
        public override void ExecuteDeclarationRefactoring(JetBrains.ReSharper.Psi.IDeclaredElement propertyOrMethod, JetBrains.Application.Progress.IProgressIndicator pi) { }
        public override void ExecuteReferencesRefactoring(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public override string[] GetAllNames() { }
        public override bool InitialValidate() { }
        public abstract void ProcessProperty(JetBrains.ReSharper.Psi.IDeclaredElement propertyOrMethod);
        public virtual void ReplaceReadOccurence(JetBrains.ReSharper.Psi.Tree.IExpression expression) { }
        protected virtual bool SkipIndexerReference(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public virtual void TransformMethodCall(JetBrains.ReSharper.Psi.IMethod method) { }
        public virtual bool TryTransformMethodCall(JetBrains.ReSharper.Psi.Tree.IExpression expression) { }
        public virtual bool TryTransformReadWriteProperty(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.Tree.IExpression expression) { }
    }
    public class Property2FunctionRefactoring : JetBrains.ReSharper.Refactorings.Common.Convert.ConvertRefactoring<JetBrains.ReSharper.Refactorings.Property2Function.Property2FunctionWorkflow, JetBrains.ReSharper.Refactorings.Property2Function.Property2FunctionBase>
    {
        public Property2FunctionRefactoring(JetBrains.ReSharper.Refactorings.Property2Function.Property2FunctionWorkflow workFlow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public override string Caption { get; }
        public override void AddAdditionalElements(System.Collections.Generic.List<JetBrains.ReSharper.Psi.IDeclaredElement> declaredElementsToSearch, JetBrains.ReSharper.Psi.IProperty property) { }
        protected override JetBrains.ReSharper.Refactorings.Property2Function.Property2FunctionBase CreateRefactoringInternal(JetBrains.ReSharper.Refactorings.InternalRefactoringLanguageService service) { }
        protected override JetBrains.ReSharper.Refactorings.Property2Function.Property2FunctionBase CreateUnsupportedRefactoring() { }
    }
    public class Property2FunctionTestDataProvider : JetBrains.ReSharper.Refactorings.Property2Function.IProperty2FunctionDataProvider
    {
        public Property2FunctionTestDataProvider(string getterName, string setterName, bool convertGetter, bool convertSetter) { }
        public bool ConvertGetter { get; }
        public bool ConvertSetter { get; }
        public string GetterName { get; }
        public string SetterName { get; }
    }
    public class Property2FunctionWindow : JetBrains.UI.CommonControls.SafeUserControl, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage
    {
        public Property2FunctionWindow(JetBrains.ReSharper.Refactorings.Property2Function.Property2FunctionWorkflow workflow) { }
        public JetBrains.DataFlow.IProperty<bool> ContinueEnabled { get; }
        public string Description { get; }
        public bool DoNotShow { get; }
        public string Title { get; }
        public JetBrains.UI.CrossFramework.EitherControl View { get; }
        public JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage Commit(JetBrains.Application.Progress.IProgressIndicator pi) { }
        protected override void Dispose(bool disposing) { }
        public bool Initialize(JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
        public bool RefreshContents(JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
    }
    public class Property2FunctionWorkflow : JetBrains.ReSharper.Refactorings.Workflow.DrivenRefactoringWorkflow, JetBrains.ReSharper.Refactorings.Common.Convert.IConvertRefactoringWorkflow
    {
        protected bool myCanConvertGetter;
        protected bool myCanConvertSetter;
        protected JetBrains.ReSharper.Refactorings.Property2Function.IProperty2FunctionDataProvider myDataProvider;
        protected JetBrains.ReSharper.Psi.Pointers.IDeclaredElementPointer<JetBrains.ReSharper.Psi.IOverridableMember> myPointer;
        protected string myPropertyName;
        public Property2FunctionWorkflow(JetBrains.ProjectModel.ISolution solution, string actionId) { }
        public override JetBrains.ReSharper.Refactorings.Workflow.RefactoringActionGroup ActionGroup { get; }
        public bool CanConvertGetter { get; }
        public bool CanConvertSetter { get; }
        public bool ConvertGetter { get; set; }
        public bool ConvertSetter { get; set; }
        public override JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage FirstPendingRefactoringPage { get; }
        public string GetterName { get; set; }
        public override string HelpKeyword { get; }
        public override bool MightModifyManyDocuments { get; }
        public JetBrains.ReSharper.Psi.Pointers.IDeclaredElementPointer<JetBrains.ReSharper.Psi.IOverridableMember> Pointer { get; }
        public virtual string PropertyName { get; }
        public string SetterName { get; set; }
        public override string Title { get; }
        public override JetBrains.ReSharper.Refactorings.Workflow.IRefactoringExecuter CreateRefactoring(JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public override bool Initialize(JetBrains.Application.DataContext.IDataContext context) { }
        public override bool IsAvailable(JetBrains.Application.DataContext.IDataContext context) { }
        public override bool PreExecute(JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
        public void SetDataProvider(JetBrains.ReSharper.Refactorings.Property2Function.IProperty2FunctionDataProvider dataProvider) { }
        public override bool Validate() { }
    }
}
namespace JetBrains.ReSharper.Refactorings.PushPullTool
{
    
    public class CallNode
    {
        public CallNode(JetBrains.ReSharper.Psi.Resolve.IReference callReference, JetBrains.ReSharper.Psi.IParametersOwner owner, JetBrains.ReSharper.Refactorings.ChangeSignature.ChangeSignatureParameter parameter, JetBrains.ReSharper.Refactorings.PushPullTool.PullParameterSession pullParameterSession) { }
        public JetBrains.ReSharper.Psi.Tree.IArgumentsOwner ArgumentsOwner { get; }
        public JetBrains.DocumentModel.IRangeMarker ArgumentsOwnerRangeMarker { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Refactorings.PushPullTool.FixDocumentChange> Changes { get; set; }
        public JetBrains.ReSharper.Refactorings.ChangeSignature.ChangeSignatureParameter ChangeSignatureParameter { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Refactorings.PushPullTool.Fixes.FixNode> Fixes { get; }
        public JetBrains.ReSharper.Psi.IDeclaredElement ParametersOwner { get; }
        public JetBrains.ReSharper.Refactorings.PushPullTool.CallPresentation Presentation { get; }
        public JetBrains.ReSharper.Refactorings.PushPullTool.PullParameterSession PullParameterSession { get; }
        public JetBrains.ReSharper.Psi.IReferencePointer ReferencePointer { get; }
        public JetBrains.ReSharper.Psi.ITypeElement TypeElement { get; }
        public JetBrains.ReSharper.Psi.ITypeMember TypeMember { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Refactorings.PushPullValue.Nodes.FixableWorkItem> GetWorkItems() { }
        public void ReloadFixes() { }
        public JetBrains.ReSharper.Refactorings.PushPullValue.Nodes.FixableWorkItem TransformToWorkItem() { }
    }
    public class CallPresentation : System.ComponentModel.INotifyPropertyChanged
    {
        public CallPresentation(JetBrains.ReSharper.Refactorings.PushPullTool.CallNode owner) { }
        public string AdditionalText { get; set; }
        public string AfterParameter { get; set; }
        public string BeforeParameter { get; set; }
        public string Caller { get; set; }
        public JetBrains.ReSharper.Refactorings.PushPullTool.CallNode CallNode { get; }
        public System.Collections.ObjectModel.ObservableCollection<object> Children { get; set; }
        public bool Enabled { get; set; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Refactorings.PushPullTool.Fixes.FixPresentation> FixPresentations { get; }
        public JetBrains.ReSharper.Refactorings.PushPullTool.Fixes.FixPresentation FixPresenter { get; }
        public bool HasError { get; set; }
        public JetBrains.UI.Icons.IconId Icon { get; set; }
        public bool IsChecked { get; set; }
        public bool IsHiglighted { get; set; }
        public bool IsSelected { get; set; }
        public string Parameter { get; set; }
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        protected string GetBold(string shortName) { }
        public void OnFixChecked(object sender, System.ComponentModel.PropertyChangedEventArgs propertyChangedEventArgs) { }
        [JetBrains.Annotations.NotifyPropertyChangedInvocatorAttribute()]
        public void OnPropertyChanged(string propertyName) { }
        public void ReloadFixes() { }
        public void ResetPresentation() { }
        public void SetResolved() { }
    }
    public class FixDocumentChange
    {
        public FixDocumentChange(JetBrains.DocumentModel.DocumentChange change, int shift) { }
        public bool ApplyInversed() { }
    }
    public class static FixExecutor
    {
        public static bool Execute(JetBrains.ReSharper.Refactorings.PushPullTool.CallNode node) { }
        public static bool Rollback(JetBrains.ReSharper.Refactorings.PushPullTool.CallNode node) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class PullParameterManager
    {
        public PullParameterManager(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.PushPullTool.PullParameterWindowDescriptor descriptor, JetBrains.UI.ToolWindowManagement.ToolWindowManager toolWindowManager, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Refactorings.PushPullTool.Fixes.FixFactory> allFactories) { }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Refactorings.PushPullTool.PullParameterSession> CurrentSessions { get; set; }
        public bool IsVisible { get; }
        public void AddSession(JetBrains.ReSharper.Refactorings.PushPullTool.PullParameterSession session) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Refactorings.PushPullTool.Fixes.FixNode> GetAvailableFixes(JetBrains.ReSharper.Refactorings.PushPullTool.CallNode node) { }
        public static JetBrains.ReSharper.Refactorings.PushPullTool.PullParameterManager GetInstance(JetBrains.ProjectModel.ISolution solution) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Refactorings.PushPullTool.Fixes.FixNode> GetLocalFixes(JetBrains.ReSharper.Refactorings.PushPullTool.CallNode node) { }
        public void Show() { }
        public void TerminateSession() { }
    }
    public class PullParameterSession
    {
        public PullParameterSession(JetBrains.ReSharper.Psi.IDeclaredElement startingElement, JetBrains.ReSharper.Refactorings.ChangeSignature.ChangeSignatureParameter parameter) { }
        public string Name { get; set; }
        public bool RefactoringInProgress { get; set; }
        public System.Collections.Generic.List<JetBrains.ReSharper.Refactorings.PushPullTool.CallNode> RootItems { get; }
        public JetBrains.ReSharper.Psi.IDeclaredElement StartingElement { get; }
        public void AddItem(JetBrains.ReSharper.Refactorings.PushPullTool.CallNode pullParameterNode) { }
        public void AddRootItems(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Resolve.IReference> allReferences) { }
        public void ReloadFixes(JetBrains.ReSharper.Psi.ITypeMember typeMember) { }
    }
    [JetBrains.UI.ToolWindowManagement.ToolWindowDescriptorAttribute(Icon=typeof(JetBrains.ReSharper.Refactorings.Resources.RefactoringsThemedIcons.RefactorThis), InitialDocking=JetBrains.UI.ToolWindowManagement.ToolWindowInitialDocking.Bottom, MultiInstanceStayAfterClosingLastTab=false, ProductNeutralId="ContinuosChangeSignatureWindow", Text="Refactoring - Change signature", Type=JetBrains.UI.ToolWindowManagement.ToolWindowType.MultiInstance, VisibilityPersistenceScope=JetBrains.UI.ToolWindowManagement.ToolWindowVisibilityPersistenceScope.Solution)]
    public class PullParameterWindowDescriptor : JetBrains.UI.ToolWindowManagement.ToolWindowDescriptor
    {
        public PullParameterWindowDescriptor(JetBrains.Application.IApplicationDescriptor applicationDescriptor) { }
    }
}
namespace JetBrains.ReSharper.Refactorings.PushPullTool.Fixes
{
    
    public abstract class FixFactory
    {
        public abstract void DropData(JetBrains.ReSharper.Refactorings.PushPullTool.PullParameterSession session);
        public abstract System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Refactorings.PushPullTool.Fixes.FixNode> GetAvailableFixes(JetBrains.ReSharper.Refactorings.PushPullTool.CallNode node);
        public abstract System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Refactorings.PushPullTool.Fixes.FixNode> GetChangedFixes(JetBrains.ReSharper.Refactorings.PushPullTool.CallNode node);
    }
    [JetBrains.Annotations.BaseTypeRequiredAttribute(typeof(JetBrains.ReSharper.Refactorings.PushPullTool.Fixes.FixFactory))]
    [JetBrains.Annotations.MeansImplicitUseAttribute()]
    [System.AttributeUsageAttribute(System.AttributeTargets.Class | System.AttributeTargets.All)]
    public class FixFactoryAttribute : JetBrains.Application.ShellComponentAttribute { }
    public abstract class FixNode
    {
        protected readonly JetBrains.ReSharper.Refactorings.PushPullTool.CallNode myParentCallNode;
        protected JetBrains.ReSharper.Refactorings.PushPullTool.Fixes.FixPresentation myPresentation;
        protected FixNode() { }
        protected FixNode(JetBrains.ReSharper.Refactorings.PushPullTool.CallNode parentCallNode) { }
        public System.Collections.Generic.List<JetBrains.ReSharper.Refactorings.PushPullTool.CallNode> ParentNodes { get; }
        public virtual void CreateParentNodes(JetBrains.ReSharper.Psi.IParametersOwner parametersOwner, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Resolve.IReference> references) { }
        public abstract bool ExecuteFix(JetBrains.Application.Progress.IProgressIndicator pi);
        protected JetBrains.ReSharper.Psi.Tree.IArgumentsOwner FixCall(JetBrains.ReSharper.Refactorings.ChangeSignature.ChangeSignatureParameter parameter, JetBrains.ReSharper.Psi.IDeclaredElement parameterElement = null) { }
        protected JetBrains.ReSharper.Psi.Resolve.ISubstitution GetAllMemberSubstitutions(JetBrains.ReSharper.Psi.ITypeMember typeMember) { }
        public abstract JetBrains.ReSharper.Refactorings.PushPullTool.Fixes.FixPresentation GetPresentation(JetBrains.ReSharper.Refactorings.PushPullTool.CallPresentation callpresentation);
        public virtual void PostExecute() { }
        public virtual void ReloadPresentation() { }
    }
    public abstract class FixPresentation : System.ComponentModel.INotifyPropertyChanged
    {
        public FixPresentation(JetBrains.ReSharper.Refactorings.PushPullTool.Fixes.FixNode node, JetBrains.ReSharper.Refactorings.PushPullTool.CallPresentation callpresentation) { }
        public JetBrains.ReSharper.Refactorings.PushPullTool.CallPresentation CallPresentation { get; }
        public JetBrains.ReSharper.Refactorings.PushPullTool.Fixes.FixNode Fix { get; }
        public bool HasError { get; set; }
        public bool IsChecked { get; set; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Refactorings.PushPullTool.CallNode> Nodes { get; }
        public string ParameterName { get; set; }
        public string SelectedText { get; set; }
        public virtual string Text { get; set; }
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        protected string GetBold(string shortName) { }
        [JetBrains.Annotations.NotifyPropertyChangedInvocatorAttribute()]
        public void OnPropertyChanged(string propertyName) { }
        public abstract void Reload(string newName);
    }
    [JetBrains.ReSharper.Refactorings.PushPullTool.Fixes.FixFactoryAttribute()]
    public class LocalFixFactory : JetBrains.ReSharper.Refactorings.PushPullTool.Fixes.FixFactory
    {
        public override void DropData(JetBrains.ReSharper.Refactorings.PushPullTool.PullParameterSession session) { }
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Refactorings.PushPullTool.Fixes.FixNode> GetAvailableFixes(JetBrains.ReSharper.Refactorings.PushPullTool.CallNode node) { }
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Refactorings.PushPullTool.Fixes.FixNode> GetChangedFixes(JetBrains.ReSharper.Refactorings.PushPullTool.CallNode node) { }
    }
    public class LocalFixNode : JetBrains.ReSharper.Refactorings.PushPullTool.Fixes.FixNode
    {
        public JetBrains.ReSharper.Psi.IDeclaredElement DeclaredElement { get; }
        public override void CreateParentNodes(JetBrains.ReSharper.Psi.IParametersOwner parametersOwner, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Resolve.IReference> references) { }
        public override bool ExecuteFix(JetBrains.Application.Progress.IProgressIndicator pi) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Refactorings.PushPullTool.Fixes.FixNode> GetFixes(JetBrains.ReSharper.Refactorings.PushPullTool.CallNode node) { }
        public override JetBrains.ReSharper.Refactorings.PushPullTool.Fixes.FixPresentation GetPresentation(JetBrains.ReSharper.Refactorings.PushPullTool.CallPresentation callpresentation) { }
    }
    public class ParameterFixNode : JetBrains.ReSharper.Refactorings.PushPullTool.Fixes.FixNode
    {
        public ParameterFixNode(JetBrains.ReSharper.Refactorings.PushPullTool.CallNode node, JetBrains.ReSharper.Psi.IParametersOwner callOwner) { }
        public override void CreateParentNodes(JetBrains.ReSharper.Psi.IParametersOwner parametersOwner, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Resolve.IReference> references) { }
        public override bool ExecuteFix(JetBrains.Application.Progress.IProgressIndicator pi) { }
        public override JetBrains.ReSharper.Refactorings.PushPullTool.Fixes.FixPresentation GetPresentation(JetBrains.ReSharper.Refactorings.PushPullTool.CallPresentation callpresentation) { }
        public override void ReloadPresentation() { }
    }
    public class SmartCompletionFix : JetBrains.ReSharper.Refactorings.PushPullTool.Fixes.FixNode
    {
        public SmartCompletionFix(JetBrains.ReSharper.Refactorings.PushPullTool.CallNode parentCallNode) { }
        public override bool ExecuteFix(JetBrains.Application.Progress.IProgressIndicator pi) { }
        public override JetBrains.ReSharper.Refactorings.PushPullTool.Fixes.FixPresentation GetPresentation(JetBrains.ReSharper.Refactorings.PushPullTool.CallPresentation callpresentation) { }
        public override void PostExecute() { }
    }
}
namespace JetBrains.ReSharper.Refactorings.PushPullTool.UI
{
    
    public class static FormattedTextBehaviour
    {
        public static readonly System.Windows.DependencyProperty FormattedTextProperty;
        public static string GetFormattedText(System.Windows.DependencyObject obj) { }
        public static void SetFormattedText(System.Windows.DependencyObject obj, string value) { }
    }
    public class PullParameterTreeView : System.Windows.Controls.UserControl, System.ComponentModel.INotifyPropertyChanged, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector
    {
        public PullParameterTreeView(JetBrains.ReSharper.Refactorings.PushPullTool.PullParameterSession session) { }
        public System.Collections.Generic.List<JetBrains.ReSharper.Refactorings.PushPullTool.CallPresentation> Usages { get; set; }
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        public void InitializeComponent() { }
        [JetBrains.Annotations.NotifyPropertyChangedInvocatorAttribute()]
        public void OnPropertyChanged(string propertyName) { }
    }
    public class static VirtualToggleButton
    {
        public static readonly System.Windows.DependencyProperty IsCallProperty;
        public static readonly System.Windows.DependencyProperty IsCheckedProperty;
        public static readonly System.Windows.DependencyProperty IsVirtualToggleButtonProperty;
        public static bool GetIsCall(System.Windows.DependencyObject dependencyObject) { }
        public static bool GetIsChecked(System.Windows.DependencyObject dependencyObject) { }
        public static bool GetIsVirtualToggleButton(System.Windows.DependencyObject d) { }
        public static void SetIsCall(System.Windows.DependencyObject dependencyObject, bool value) { }
        public static void SetIsChecked(System.Windows.DependencyObject dependencyObject, bool value) { }
        public static void SetIsVirtualToggleButton(System.Windows.DependencyObject d, bool value) { }
    }
}
namespace JetBrains.ReSharper.Refactorings.PushPullValue.ContextActions
{
    
    public abstract class WorkItemContextActionBase : JetBrains.ReSharper.Feature.Services.ActionsMenu.ExtensibleAction<Test.WorkItems.PushPullValue.IWorkItemsWorkflowProvider, Test.WorkItems.PushPullValue.IWorkItemsWorkflow, Test.WorkItems.PushPullValue.WorkItemsActionGroup>
    {
        protected override void Execute(JetBrains.Application.DataContext.IDataContext context, Test.WorkItems.PushPullValue.IWorkItemsWorkflow workflow) { }
        public static void ExecuteRefactoring([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.DataContext.IDataContext context, [JetBrains.Annotations.NotNullAttribute()] Test.WorkItems.PushPullValue.IWorkItemsWorkflow workItemsWorkflow) { }
        protected override JetBrains.UI.Icons.IconId GetIcon(JetBrains.Application.DataContext.IDataContext dataContext) { }
        protected override System.Collections.Generic.ICollection<Test.WorkItems.PushPullValue.IWorkItemsWorkflowProvider> GetWorkflowProviders() { }
        protected override bool IsAvailable(JetBrains.Application.DataContext.IDataContext context, Test.WorkItems.PushPullValue.IWorkItemsWorkflow workflow) { }
        protected override bool IsEnabled(JetBrains.Application.DataContext.IDataContext context, Test.WorkItems.PushPullValue.IWorkItemsWorkflow workflow) { }
    }
}
namespace JetBrains.ReSharper.Refactorings.PushPullValue.Data
{
    
    public class WorkItemDataConstants
    {
        public static JetBrains.Application.DataContext.DataConstant<JetBrains.ReSharper.Refactorings.PushPullValue.Nodes.IWorkItemNode> WORK_ITEM;
        public static readonly JetBrains.Application.DataContext.DataConstant<System.Collections.Generic.ICollection<JetBrains.ReSharper.Refactorings.PushPullValue.Nodes.IWorkItemNode>> WORK_ITEMS;
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public sealed class WorkItemsDataRules
    {
        public WorkItemsDataRules(JetBrains.ProjectModel.ISolution solution, JetBrains.ActionManagement.IActionManager actionManager, JetBrains.DataFlow.Lifetime lifetime) { }
        public static System.Collections.Generic.ICollection<JetBrains.ReSharper.Refactorings.PushPullValue.Nodes.IWorkItemNode> TreeModelNodesToWorkItems(JetBrains.Application.DataContext.IDataContext context) { }
    }
}
namespace JetBrains.ReSharper.Refactorings.PushPullValue.Nodes
{
    
    public abstract class FixableWorkItem : JetBrains.ReSharper.Refactorings.PushPullValue.Nodes.TextRangeWorkItem
    {
        protected FixableWorkItem(JetBrains.ProjectModel.ISolution solution, JetBrains.DocumentModel.DocumentRange documentRange, JetBrains.ReSharper.Refactorings.PushPullValue.WorkItemsSession session) { }
        public abstract JetBrains.ReSharper.Psi.PsiLanguageType PresentationLanguage { get; }
        public JetBrains.ReSharper.Refactorings.PushPullValue.WorkItemsSession Session { get; }
        public abstract bool Contains(JetBrains.DocumentModel.IDocument document, int offset);
    }
    public interface IWorkItemFix
    {
        string Description { get; }
        void Fix(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Refactorings.PushPullValue.Nodes.IWorkItemNode> node, JetBrains.ProjectModel.ISolution solution);
        bool IsAvailable(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Refactorings.PushPullValue.Nodes.IWorkItemNode> workItems);
    }
    public interface IWorkItemNode
    {
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Refactorings.PushPullValue.Nodes.IWorkItemNode> Children { get; }
        JetBrains.ReSharper.Refactorings.src.PushPullValue.Nodes.WorkItemPresentation Presentation { get; }
        bool Navigate(bool transferFocus);
    }
    public class TextRangeWorkItem : JetBrains.ReSharper.Refactorings.PushPullValue.Nodes.IWorkItemNode
    {
        protected JetBrains.ReSharper.Refactorings.src.PushPullValue.Nodes.WorkItemPresentation myPresentation;
        public TextRangeWorkItem(JetBrains.ProjectModel.ISolution solution, JetBrains.DocumentModel.DocumentRange documentRange) { }
        public virtual System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Refactorings.PushPullValue.Nodes.IWorkItemNode> Children { get; }
        protected JetBrains.DocumentModel.DocumentRange DocumentRange { get; }
        public virtual JetBrains.ReSharper.Refactorings.src.PushPullValue.Nodes.WorkItemPresentation Presentation { get; }
        public virtual bool Navigate(bool transferFocus) { }
    }
    [JetBrains.Annotations.BaseTypeRequiredAttribute(typeof(JetBrains.ReSharper.Refactorings.PushPullValue.Nodes.WorkItemFixBase))]
    [JetBrains.Annotations.MeansImplicitUseAttribute()]
    [System.AttributeUsageAttribute(System.AttributeTargets.Class | System.AttributeTargets.All)]
    public class WorkItemFixAttribute : JetBrains.Application.ShellComponentAttribute { }
    public abstract class WorkItemFixBase : JetBrains.ReSharper.Refactorings.PushPullValue.Nodes.IWorkItemFix
    {
        public abstract string Description { get; }
        protected abstract bool Execute(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Refactorings.PushPullValue.Nodes.IWorkItemNode> workItems, JetBrains.ProjectModel.ISolution solution);
        protected bool ExecuteUnderTransaction(JetBrains.ProjectModel.ISolution solution, System.Func<bool> action) { }
        public void Fix(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Refactorings.PushPullValue.Nodes.IWorkItemNode> nodes, JetBrains.ProjectModel.ISolution solution) { }
        public abstract bool IsAvailable(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Refactorings.PushPullValue.Nodes.IWorkItemNode> workItems);
    }
}
namespace JetBrains.ReSharper.Refactorings.PushPullValue.Presenters
{
    
    public class WorkItemsPresenter : JetBrains.ReSharper.Features.Shared.TreePsiBrowser.TreeModelBrowserPresenter
    {
        public WorkItemsPresenter() { }
    }
}
namespace JetBrains.ReSharper.Refactorings.PushPullValue.Providers
{
    
    [JetBrains.ReSharper.Refactorings.PushPullValue.WorkItemsProviderAttribute()]
    public class DeclaredElementWorkItemProvider : JetBrains.ReSharper.Refactorings.src.PushPullValue.ContextActions.IWorkItemsProvider
    {
        public JetBrains.ReSharper.Refactorings.PushPullValue.Nodes.IWorkItemNode GetWorkItem(JetBrains.Application.DataContext.IDataContext context) { }
    }
    [JetBrains.ReSharper.Refactorings.PushPullValue.WorkItemsProviderAttribute()]
    public class TextRangeWorkItemProvider : JetBrains.ReSharper.Refactorings.src.PushPullValue.ContextActions.IWorkItemsProvider
    {
        public JetBrains.ReSharper.Refactorings.PushPullValue.Nodes.IWorkItemNode GetWorkItem(JetBrains.Application.DataContext.IDataContext context) { }
    }
    [JetBrains.ReSharper.Refactorings.PushPullValue.WorkItemsProviderAttribute()]
    public class ToDoWorkItemProvider : JetBrains.ReSharper.Refactorings.src.PushPullValue.ContextActions.IWorkItemsProvider
    {
        public JetBrains.ReSharper.Refactorings.PushPullValue.Nodes.IWorkItemNode GetWorkItem(JetBrains.Application.DataContext.IDataContext context) { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class WorkItemsProviderManager
    {
        public WorkItemsProviderManager(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Refactorings.src.PushPullValue.ContextActions.IWorkItemsProvider> providers) { }
        public static JetBrains.ReSharper.Refactorings.PushPullValue.Providers.WorkItemsProviderManager Instance { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Refactorings.src.PushPullValue.ContextActions.IWorkItemsProvider> GetWorkItemProviders() { }
    }
}
namespace JetBrains.ReSharper.Refactorings.PushPullValue.UI
{
    
    public class WorkItemBrowserDescriptor : JetBrains.ReSharper.Features.Common.TreePsiBrowser.TreeModelBrowserDescriptorPsi
    {
        public WorkItemBrowserDescriptor(JetBrains.ProjectModel.ISolution solution) { }
        public override string ActionBarID { get; }
        public override string ContextMenuID { get; }
        public override JetBrains.TreeModels.TreeModel Model { get; }
        public override JetBrains.UI.TreeView.StructuredPresenter<JetBrains.TreeModels.TreeModelNode, JetBrains.CommonControls.IPresentableItem> Presenter { get; }
        public void Refresh() { }
        public void Update(JetBrains.DataFlow.AddRemoveEventArgs<JetBrains.ReSharper.Refactorings.PushPullValue.Nodes.IWorkItemNode> addRemoveEventArgs) { }
        public void Update() { }
    }
}
namespace JetBrains.ReSharper.Refactorings.PushPullValue
{
    
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class WorkItemsManager
    {
        public WorkItemsManager(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.PushPullValue.WorkItemsWindowDescriptor descriptor, JetBrains.UI.ToolWindowManagement.ToolWindowManager toolWindowManager, JetBrains.ActionManagement.IActionManager actionManager, JetBrains.UI.Application.IUIApplication environment) { }
        public JetBrains.ReSharper.Refactorings.PushPullValue.WorkItemsSession CurrentSession { get; }
        public JetBrains.ReSharper.Refactorings.PushPullValue.WorkItemsSession NewSession { get; }
        public void CloseSession(JetBrains.ReSharper.Refactorings.PushPullValue.WorkItemsSession session) { }
        public static JetBrains.ReSharper.Refactorings.PushPullValue.WorkItemsManager GetInstance(JetBrains.ProjectModel.ISolution solution) { }
        public System.Collections.Generic.ICollection<JetBrains.ReSharper.Refactorings.PushPullValue.WorkItemsSession> GetSessions() { }
        public JetBrains.ReSharper.Refactorings.PushPullValue.Nodes.IWorkItemNode GetWorkItem(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Refactorings.PushPullValue.Nodes.IWorkItemNode> GetWorkItems(JetBrains.DocumentModel.IDocument document, int caretOffset) { }
        public void Show(JetBrains.ReSharper.Refactorings.PushPullValue.WorkItemsSession session) { }
    }
    [JetBrains.Annotations.BaseTypeRequiredAttribute(typeof(JetBrains.ReSharper.Refactorings.src.PushPullValue.ContextActions.IWorkItemsProvider))]
    [JetBrains.Annotations.MeansImplicitUseAttribute()]
    [System.AttributeUsageAttribute(System.AttributeTargets.Class | System.AttributeTargets.All)]
    public class WorkItemsProviderAttribute : JetBrains.Application.ShellComponentAttribute { }
    public class WorkItemsSession
    {
        public WorkItemsSession(JetBrains.ProjectModel.ISolution solution) { }
        public void AddItem(JetBrains.ReSharper.Refactorings.PushPullValue.Nodes.IWorkItemNode workItem) { }
        public JetBrains.ReSharper.Refactorings.PushPullValue.UI.WorkItemBrowserDescriptor GetDescriptor() { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Refactorings.PushPullValue.Nodes.IWorkItemNode> GetItems(JetBrains.DocumentModel.IDocument document, int caretOffset) { }
    }
    [JetBrains.UI.ToolWindowManagement.ToolWindowDescriptorAttribute(Icon=typeof(JetBrains.ReSharper.Refactorings.Resources.RefactoringsThemedIcons.RefactorThis), InitialDocking=JetBrains.UI.ToolWindowManagement.ToolWindowInitialDocking.Bottom, ProductNeutralId="WorkItemsWindow", Text="Work items", Type=JetBrains.UI.ToolWindowManagement.ToolWindowType.MultiInstance, VisibilityPersistenceScope=JetBrains.UI.ToolWindowManagement.ToolWindowVisibilityPersistenceScope.Solution)]
    public class WorkItemsWindowDescriptor : JetBrains.UI.ToolWindowManagement.ToolWindowDescriptor
    {
        public WorkItemsWindowDescriptor(JetBrains.Application.IApplicationDescriptor applicationDescriptor) { }
    }
}
namespace JetBrains.ReSharper.Refactorings.RefactorThis
{
    
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "RefactorThis"})]
    public class RefactorThisAction : JetBrains.ReSharper.Refactorings.WorkflowNew.IntroduceWithOccurencesAction<JetBrains.ReSharper.Refactorings.Workflow.IRefactoringWorkflowProvider>
    {
        protected override JetBrains.UI.RichText.RichText Caption { get; }
        protected override bool ShowMenuWithOneItem { get; }
    }
}
namespace JetBrains.ReSharper.Refactorings.Rename
{
    
    public class AtomicRenames
    {
        public AtomicRenames(JetBrains.ReSharper.Refactorings.RenameModel.AtomicRenameBase[] atomicRenameBases, bool readOnly) { }
        public System.Collections.Generic.ICollection<JetBrains.ReSharper.Refactorings.RenameModel.AtomicRenameBase> Renames { get; }
        public void AddRange(JetBrains.ReSharper.Refactorings.RenameModel.AtomicRenameBase[] atomicRenameBases) { }
        public JetBrains.ReSharper.Refactorings.RenameModel.AtomicRenameBase GetByDeclaredElement(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
    }
    [JetBrains.ReSharper.Psi.ShellFeaturePartAttribute()]
    public class AtomicRenamesFactory : JetBrains.ReSharper.Refactorings.Rename.IAtomicRenameFactory
    {
        public virtual JetBrains.ReSharper.Refactorings.RenameModel.RenameAvailabilityCheckResult CheckRenameAvailability([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
        public virtual System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Refactorings.RenameModel.AtomicRenameBase> CreateAtomicRenames(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, string newName, bool doNotAddBindingConflicts) { }
        public virtual bool IsApplicable(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
    }
    [JetBrains.ReSharper.Refactorings.Rename.RenamePartAttribute()]
    public sealed class ClrPrimaryElementsRenameFactory : JetBrains.ReSharper.Refactorings.Rename.IPrimaryDeclaredElementForRenameProvider
    {
        public JetBrains.ReSharper.Psi.IDeclaredElement GetPrimaryDeclaredElement(JetBrains.ReSharper.Psi.IDeclaredElement element, JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
    }
    [JetBrains.ReSharper.Psi.ShellFeaturePartAttribute()]
    public class ColorCanNotBeRenamed : JetBrains.ReSharper.Refactorings.Rename.AtomicRenamesFactory
    {
        public override JetBrains.ReSharper.Refactorings.RenameModel.RenameAvailabilityCheckResult CheckRenameAvailability(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
        public override bool IsApplicable(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
    }
    public class DerivedDeclaredElement
    {
        public readonly JetBrains.ReSharper.Psi.IDeclaredElement DeclaredElement;
        public readonly string NewSuggestedName;
        public DerivedDeclaredElement([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, string newName) { }
        public JetBrains.ReSharper.Refactorings.Rename.DerivedDeclaredElementPointer CreatePointer() { }
    }
    public class DerivedDeclaredElementPointer
    {
        public readonly JetBrains.ReSharper.Psi.Pointers.IDeclaredElementPointer<JetBrains.ReSharper.Psi.IDeclaredElement> DeclaredElement;
        public readonly string NewSuggestedName;
        public DerivedDeclaredElementPointer(JetBrains.ReSharper.Refactorings.Rename.DerivedDeclaredElement derivedDeclaredElement) { }
        public JetBrains.ReSharper.Refactorings.Rename.DerivedDeclaredElement ResolvePointer() { }
    }
    public class DerivedElementsCollection
    {
        public DerivedElementsCollection() { }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Refactorings.Rename.DerivedDeclaredElement> DerivedRenames { get; }
        public void AddRenames(JetBrains.ReSharper.Psi.IDeclaredElement derivedElement, string newName, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Progress.IProgressIndicator pi) { }
    }
    [JetBrains.Annotations.BaseTypeRequiredAttribute(typeof(JetBrains.ReSharper.Refactorings.Rename.IDerivedRenamesEvaluator))]
    [JetBrains.Annotations.MeansImplicitUseAttribute()]
    [System.AttributeUsageAttribute(System.AttributeTargets.Class | System.AttributeTargets.All, AllowMultiple=false)]
    public class DerivedRenamesEvaluatorAttribute : JetBrains.Application.ShellComponentAttribute { }
    [JetBrains.Application.ShellComponentAttribute()]
    public class DerivedRenamesEvaluators
    {
        public DerivedRenamesEvaluators(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Refactorings.Rename.IDerivedRenamesEvaluator> evaluators) { }
        public JetBrains.ReSharper.Refactorings.Rename.DerivedElementsCollection EvaluateDerivedRenames([JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.ICollection<JetBrains.ReSharper.Refactorings.RenameModel.AtomicRenameBase> atomicRenames, [JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Progress.IProgressIndicator pi, JetBrains.ReSharper.Refactorings.Rename.RenameWorkflow renameWorkflow) { }
        public JetBrains.ReSharper.Refactorings.Rename.DerivedElementsCollection EvaluateDerivedRenames(System.Collections.Generic.List<JetBrains.ReSharper.Psi.Resolve.IReference> references, JetBrains.ReSharper.Psi.ITypeElement typeElement, JetBrains.ReSharper.Psi.ITypeElement baseTypeElement, JetBrains.Application.Progress.IProgressIndicator pi) { }
    }
    public class FileRename
    {
        public FileRename(JetBrains.ReSharper.Psi.IPsiServices psiServices, JetBrains.ProjectModel.IProjectItem projectItem, string name) { }
        public string NewName { get; }
        public JetBrains.ProjectModel.IProjectItem ProjectItem { get; }
        public JetBrains.ReSharper.Psi.IPsiServices PsiServices { get; set; }
    }
    [JetBrains.Annotations.BaseTypeRequiredAttribute(typeof(JetBrains.ReSharper.Refactorings.Rename.IFileRenameProvider))]
    [JetBrains.Annotations.MeansImplicitUseAttribute()]
    [System.AttributeUsageAttribute(System.AttributeTargets.Class | System.AttributeTargets.All, AllowMultiple=false)]
    public class FileRenameProviderAttribute : JetBrains.Application.ShellComponentAttribute { }
    public abstract class HierarchyConflict
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        public abstract JetBrains.ReSharper.Refactorings.Conflicts.IConflict CreateConflict(JetBrains.ReSharper.Refactorings.Conflicts.HierarchyConflictTextProviderBase textProvider);
    }
    public interface IAtomicRenameFactory
    {
        JetBrains.ReSharper.Refactorings.RenameModel.RenameAvailabilityCheckResult CheckRenameAvailability(JetBrains.ReSharper.Psi.IDeclaredElement element);
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Refactorings.RenameModel.AtomicRenameBase> CreateAtomicRenames(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, string newName, bool doNotAddBindingConflicts);
        bool IsApplicable(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement);
    }
    public interface IDerivedRenamesEvaluator
    {
        bool SuggestedElementsHaveDerivedName { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IDeclaredElement> CreateFromElement(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement);
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IDeclaredElement> CreateFromReference(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.IDeclaredElement declaredElement);
    }
    public interface IFileRenameProvider
    {
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Refactorings.Rename.FileRename> GetFileRenames(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, string name);
    }
    public class ImplementsFromCompiledCode : JetBrains.ReSharper.Refactorings.Rename.HierarchyConflict
    {
        public ImplementsFromCompiledCode(JetBrains.ReSharper.Psi.IOverridableMember member, JetBrains.ReSharper.Psi.OverridableMemberInstance compiledElement) { }
        public override JetBrains.ReSharper.Refactorings.Conflicts.IConflict CreateConflict(JetBrains.ReSharper.Refactorings.Conflicts.HierarchyConflictTextProviderBase textProvider) { }
    }
    public interface IPrimaryDeclaredElementForRenameProvider
    {
        JetBrains.ReSharper.Psi.IDeclaredElement GetPrimaryDeclaredElement(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, JetBrains.ReSharper.Psi.Resolve.IReference reference);
    }
    public interface IRenameDataProvider
    {
        bool ChangeText { get; }
        bool DoRenameFile { get; }
        string NewName { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        System.Collections.Generic.IList<JetBrains.ReSharper.Refactorings.RenameModel.AtomicRenameBase> GetBaseNameChange();
    }
    public interface IRenameSuspiciousNamesService
    {
        string[] GetPossibleReferenceNames(JetBrains.ReSharper.Psi.IDeclaredElement element, string newName);
    }
    public class IsImplementedInCompiledCodeConflict : JetBrains.ReSharper.Refactorings.Rename.HierarchyConflict
    {
        public IsImplementedInCompiledCodeConflict(JetBrains.ReSharper.Psi.IOverridableMember member, JetBrains.ReSharper.Psi.OverridableMemberInstance compiledElement) { }
        public override JetBrains.ReSharper.Refactorings.Conflicts.IConflict CreateConflict(JetBrains.ReSharper.Refactorings.Conflicts.HierarchyConflictTextProviderBase textProvider) { }
    }
    public class LocalElementConflictSearcher : JetBrains.ReSharper.Refactorings.Conflicts.IConflictSearcher
    {
        public LocalElementConflictSearcher(System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.Tree.ITreeNode> scopeElements, string name, System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.IDeclaredElement> ignoredElements) { }
        public LocalElementConflictSearcher(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, string name) { }
        public JetBrains.ReSharper.Refactorings.Conflicts.ConflictSearchResult SearchConflicts(JetBrains.Application.Progress.IProgressIndicator pi, bool canPerformRefactoring) { }
    }
    public class NotIncludedRoots : JetBrains.ReSharper.Refactorings.Rename.HierarchyConflict
    {
        public NotIncludedRoots(JetBrains.ReSharper.Refactorings.OverridesSupport.HierarchyMember hierarchyMember, JetBrains.ReSharper.Refactorings.OverridesSupport.ImplementsMemberProblem implementsMemberProblem) { }
        public override JetBrains.ReSharper.Refactorings.Conflicts.IConflict CreateConflict(JetBrains.ReSharper.Refactorings.Conflicts.HierarchyConflictTextProviderBase textProvider) { }
    }
    [JetBrains.ReSharper.Refactorings.Rename.DerivedRenamesEvaluatorAttribute()]
    public class ParameterInOverloadRenameEvaluator : JetBrains.ReSharper.Refactorings.Rename.IDerivedRenamesEvaluator
    {
        public bool SuggestedElementsHaveDerivedName { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IDeclaredElement> CreateFromElement(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IDeclaredElement> CreateFromReference(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
    }
    public class QuasiImplements : JetBrains.ReSharper.Refactorings.Rename.HierarchyConflict
    {
        public QuasiImplements(JetBrains.ReSharper.Psi.IOverridableMember member, JetBrains.ReSharper.Psi.OverridableMemberInstance compiledElement) { }
        public override JetBrains.ReSharper.Refactorings.Conflicts.IConflict CreateConflict(JetBrains.ReSharper.Refactorings.Conflicts.HierarchyConflictTextProviderBase textProvider) { }
    }
    public class QuasiImplementsConflict : JetBrains.ReSharper.Refactorings.Conflicts.IConflict
    {
        public QuasiImplementsConflict(JetBrains.ReSharper.Psi.Pointers.IDeclaredElementPointer<JetBrains.ReSharper.Psi.IOverridableMember> memberPointer, JetBrains.ReSharper.Psi.Pointers.IDeclaredElementPointer<JetBrains.ReSharper.Psi.IOverridableMember> implementedMemberPointer, JetBrains.ReSharper.Refactorings.Conflicts.HierarchyConflictTextProviderBase textProvider) { }
        public string Description { get; }
        public JetBrains.ReSharper.Psi.IOverridableMember ImplementedMember { get; }
        public bool IsValid { get; }
        public JetBrains.ReSharper.Psi.IOverridableMember Member { get; }
        public JetBrains.ReSharper.Refactorings.Conflicts.ConflictSeverity Severity { get; }
    }
    public class ReferenceRebinder
    {
        public ReferenceRebinder(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.INamespace ns, string newName, bool caseSensitive) { }
        public void Restore() { }
    }
    [JetBrains.ReSharper.Refactorings.Rename.FileRenameProviderAttribute()]
    public class RelatedFileRenameProvider : JetBrains.ReSharper.Refactorings.Rename.IFileRenameProvider
    {
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Refactorings.Rename.FileRename> GetFileRenames(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, string name) { }
    }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "Rename"})]
    public class RenameAction : JetBrains.ReSharper.Refactorings.Workflow.ExtensibleRefactoringAction<JetBrains.ReSharper.Refactorings.Rename.RenameWorkflowProvider>
    {
        public const string ACTION_ID = "Rename";
        protected override JetBrains.UI.RichText.RichText Caption { get; }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.KnownLanguage))]
    public class RenameHelperBase
    {
        public virtual bool IsLanguageSupported { get; }
        public virtual void AddExtraNames(JetBrains.ReSharper.Psi.Naming.Extentions.INamesCollection suggestion, JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
        public virtual System.Collections.Generic.IList<JetBrains.ReSharper.Refactorings.Conflicts.IConflictSearcher> AdditionalConflictsSearchers(JetBrains.ReSharper.Psi.IDeclaredElement element, string newName) { }
        public virtual void AdditionalReferenceProcessing(JetBrains.ReSharper.Psi.IDeclaredElement newTarget, JetBrains.ReSharper.Psi.Resolve.IReference reference, System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.Resolve.IReference> newReferences) { }
        public virtual JetBrains.ReSharper.Psi.Resolve.IReference BindReferenceToNamespace(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.INamespace ns) { }
        public virtual bool DoNotProcess(JetBrains.ReSharper.Psi.IDeclaredElement element) { }
        public virtual bool DoNotProcessReference(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public virtual System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Resolve.IReference> GetCustomUsages(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
        public virtual JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage GetPageBeforeInitial(JetBrains.ReSharper.Refactorings.Rename.RenameWorkflow renameWorkflow) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IDeclaredElement> GetSecondaryElements(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
        public virtual JetBrains.ReSharper.Psi.DeclaredElementInstance GetSubst(JetBrains.ReSharper.Psi.IDeclaredElement element) { }
        public virtual JetBrains.Util.OneToSetMap<JetBrains.ReSharper.Psi.Pointers.IDeclaredElementPointer<JetBrains.ReSharper.Psi.IDeclaredElement>, JetBrains.ReSharper.Psi.IReferencePointer> GetSuspiciousReferences(JetBrains.ReSharper.Psi.IDeclaredElement element) { }
        public virtual bool IsAlias(JetBrains.ReSharper.Psi.IDeclaredElement element) { }
        public virtual bool IsLocalRename(JetBrains.ReSharper.Psi.IDeclaredElement primevalDeclaredElement) { }
        public virtual void JoinTransformAnonymous(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public virtual JetBrains.ReSharper.Psi.Resolve.IReference TransformProjectedInitializer(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
    }
    public class RenameHierarchyConflictTextProvider : JetBrains.ReSharper.Refactorings.Conflicts.HierarchyConflictTextProviderBase
    {
        public override string QuasiImplements() { }
        public override string WillAlsoImplement() { }
        public override string WillAlsoOverride() { }
    }
    public class RenameInitialControl : JetBrains.UI.CommonControls.SafeTableLayoutPanel, JetBrains.CommonControls.Validation.IValidatorProvider, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage
    {
        public RenameInitialControl(JetBrains.ReSharper.Refactorings.Rename.RenameWorkflow workflow, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Naming.Impl.NameRoot> roots, JetBrains.ReSharper.Psi.Naming.Settings.NamingPolicy namingPolicy) { }
        public JetBrains.DataFlow.IProperty<bool> ContinueEnabled { get; }
        public string Description { get; }
        public bool DoNotShow { get; }
        [JetBrains.Annotations.UsedImplicitlyAttribute()]
        public JetBrains.ReSharper.Psi.IDeclaredElement Element { get; }
        public string Title { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.CommonControls.Validation.IValidator> Validators { get; }
        public JetBrains.UI.CrossFramework.EitherControl View { get; }
        public event System.Action OnCommit;
        public JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage Commit(JetBrains.Application.Progress.IProgressIndicator pi) { }
        public bool Initialize(JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
        public bool RefreshContents(JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
    }
    public class RenameNamespaceRefactoringUtil
    {
        public static string GetNewDeclarationName(JetBrains.ReSharper.Psi.Tree.INamespaceDeclaration nd, JetBrains.ReSharper.Psi.INamespace originalNamespace, string newName, out bool haveUpperChanges, string topLevelNamespace) { }
    }
    public class RenameOverloadsPage : System.Windows.Forms.UserControl, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage
    {
        public RenameOverloadsPage(JetBrains.ReSharper.Refactorings.Rename.RenameWorkflow workflow) { }
        public JetBrains.DataFlow.IProperty<bool> ContinueEnabled { get; }
        public string Description { get; }
        public bool DoNotShow { get; }
        public string Title { get; }
        public JetBrains.UI.CrossFramework.EitherControl View { get; }
        public JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage Commit(JetBrains.Application.Progress.IProgressIndicator pi) { }
        public bool Initialize(JetBrains.Application.Progress.IProgressIndicator pi) { }
        public bool RefreshContents(JetBrains.Application.Progress.IProgressIndicator pi) { }
    }
    public class RenamePartAttribute : JetBrains.Application.ShellComponentAttribute { }
    public class RenamePostRenameProvider : JetBrains.ReSharper.Refactorings.PostRename.PostRenameModel.IPostRenameProvider
    {
        public RenamePostRenameProvider(JetBrains.ReSharper.Refactorings.Rename.Stages.InitialStageExecuter initialStageExecuter, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Refactorings.Rename.DerivedDeclaredElement> derivedDeclaredElements) { }
        public string PostRenamePageTitle { get; }
        public JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage CommitDerivedRenames(JetBrains.ReSharper.Refactorings.PostRename.PostRenameModel.NameChanges change, JetBrains.Application.Progress.IProgressIndicator pi) { }
        public JetBrains.ReSharper.Refactorings.PostRename.PostRenameModel.NameChanges GetNameChanges() { }
    }
    public class RenameRefactoring : JetBrains.ReSharper.Refactorings.Common.DrivenRefactoringBase<JetBrains.ReSharper.Refactorings.Rename.RenameWorkflow>
    {
        public RenameRefactoring(JetBrains.ReSharper.Refactorings.Rename.RenameWorkflow workFlow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public override bool Execute(JetBrains.Application.Progress.IProgressIndicator pi) { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class RenameRefactoringService
    {
        public RenameRefactoringService(JetBrains.Application.IShellLocks shellLocks, JetBrains.ReSharper.Psi.Search.SearchDomainFactory searchDomainFactory, JetBrains.Application.DataContext.DataContexts dataContexts, JetBrains.ReSharper.Refactorings.Rename.DerivedRenamesEvaluators derivedRenamesEvaluators, JetBrains.ReSharper.Psi.LanguageManager languageManager, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Refactorings.Rename.IFileRenameProvider> fileRenameProviders, JetBrains.ReSharper.Feature.Services.IFeaturePartsContainer featureParts, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Refactorings.Rename.IRenameSuspiciousNamesService> renameSuspiciousNamesServices, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Refactorings.Rename.IPrimaryDeclaredElementForRenameProvider> primaryDeclaredElementForRenameProviders) { }
        public JetBrains.ReSharper.Refactorings.Rename.DerivedRenamesEvaluators DerivedRenamesEvaluators { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Refactorings.Rename.IFileRenameProvider> FileRenameProviders { get; }
        public static JetBrains.ReSharper.Refactorings.Rename.RenameRefactoringService Instance { get; }
        public JetBrains.ReSharper.Refactorings.RenameModel.RenameAvailabilityCheckResult CheckRenameAvailability(JetBrains.ReSharper.Psi.IDeclaredElement element) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Refactorings.RenameModel.AtomicRenameBase> CreateAtomicRenames(JetBrains.ReSharper.Psi.IDeclaredElement element, string newName, bool doNotAddBindingConflicts) { }
        public JetBrains.ReSharper.Refactorings.Workflow.IRefactoringWorkflow CreateWorkflow(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, JetBrains.ProjectModel.ISolution solution, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public void ExcuteRename(JetBrains.Application.DataContext.IDataContext context) { }
        public System.Collections.Generic.ICollection<string> GetPossibleReferenceNames(JetBrains.ReSharper.Psi.IDeclaredElement element, string newName) { }
        public JetBrains.ReSharper.Psi.IDeclaredElement GetPrimevalDeclaredElement([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IDeclaredElement element, JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public JetBrains.ReSharper.Refactorings.Rename.RenameHelperBase GetRenameService(JetBrains.ReSharper.Psi.PsiLanguageType psiLanguageType) { }
        public JetBrains.ReSharper.Refactorings.Rename.RenameWorkflow InitFromNameChanges(JetBrains.ProjectModel.ISolution solution, System.Collections.Generic.IList<JetBrains.ReSharper.Refactorings.RenameModel.AtomicRenameBase> atomicRenames) { }
        public bool IsLocal([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IDeclaredElement primevalDeclaredElement) { }
        public void RenameFromDrivenContext(JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, string newName, JetBrains.Application.Progress.NullProgressIndicator pi) { }
    }
    [JetBrains.Application.Settings.SettingsKeyAttribute(typeof(JetBrains.ReSharper.Refactorings.RefactoringsMruSettings), "Rename refactoring settings")]
    public class RenameRefactoringSettings
    {
        [JetBrains.Application.Settings.SettingsEntryAttribute(true, "Whether to rename file name when a single class in the file is renamed")]
        public bool DoRenameFile;
        [JetBrains.Application.Settings.SettingsEntryAttribute(true, "Whether to search for text in strings")]
        public bool DoSearchForTextInStrings;
    }
    [JetBrains.Application.Configuration.Upgrade.GlobalSettingsUpgraderAttribute()]
    public class RenameRefactoringSettingsUpgrader : JetBrains.Application.Configuration.SettingTablesUpgrader
    {
        public RenameRefactoringSettingsUpgrader(JetBrains.Application.Env.RunsProducts.ProductConfigurations productConfigurations) { }
        protected override void DoUpgrade(JetBrains.Application.Configuration.IComponentSettingsProvider legacySettingsProvider, JetBrains.Application.Settings.IContextBoundSettingsStore boundSettingsStore, JetBrains.DataFlow.Lifetime upgradeLifetime, JetBrains.Application.Configuration.SettingsTableBase workspaceSettingsTable, JetBrains.Application.Configuration.SettingsTableBase globalSettingsTable) { }
    }
    public enum RenameScope
    {
        Method = 0,
        Class = 1,
        Project = 2,
        Solution = 3,
    }
    public class RenameTestDataProvider : JetBrains.ReSharper.Refactorings.Rename.IRenameDataProvider
    {
        public RenameTestDataProvider(string name, bool doRenameFile, bool doChangeText) { }
        public bool ChangeText { get; }
        public bool DoRenameFile { get; }
        public string NewName { get; }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Refactorings.RenameModel.AtomicRenameBase> GetBaseNameChange() { }
    }
    public class RenameWorkflow : JetBrains.ReSharper.Refactorings.Workflow.DrivenRefactoringWorkflow
    {
        public static readonly JetBrains.Application.DataContext.DataConstant<JetBrains.ReSharper.Refactorings.Rename.IRenameDataProvider> RenameDataProvider;
        public RenameWorkflow(JetBrains.Application.IShellLocks locks, JetBrains.ReSharper.Psi.Search.SearchDomainFactory searchDomainFactory, JetBrains.ReSharper.Refactorings.Rename.RenameRefactoringService renameRefactoringService, JetBrains.ProjectModel.ISolution solution, string actionId) { }
        public override JetBrains.ReSharper.Refactorings.Workflow.RefactoringActionGroup ActionGroup { get; }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Pointers.IDeclaredElementPointer<JetBrains.ReSharper.Psi.IDeclaredElement>> AllInitialElements { get; }
        public JetBrains.ReSharper.Refactorings.Rename.AtomicRenames AllRenames { get; }
        public bool CanHaveFileRenames { get; }
        public JetBrains.ReSharper.Refactorings.Rename.IRenameDataProvider DataProvider { get; }
        public bool DoNotRenameTextOccurences { set; }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Pointers.IDeclaredElementPointer<JetBrains.ReSharper.Psi.IDeclaredElement>> ExtraDeclaredElements { get; set; }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Refactorings.Rename.FileRename> FileRenames { get; }
        public override JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage FirstPendingRefactoringPage { get; }
        public override string HelpKeyword { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public System.Collections.Generic.List<JetBrains.ReSharper.Refactorings.Rename.HierarchyConflict> HierarchyConflicts { get; }
        public JetBrains.ReSharper.Psi.Pointers.IDeclaredElementPointer<JetBrains.ReSharper.Psi.IDeclaredElement> InitialDeclaredElement { get; set; }
        public string InitialName { get; set; }
        public JetBrains.ReSharper.Psi.Naming.Impl.NameRoot InitialRoot { get; }
        public JetBrains.ReSharper.Refactorings.Rename.Stages.InitialStageExecuter InitialStageExecuter { get; }
        public bool IsAnonymousTypeProperty { get; }
        public JetBrains.ReSharper.Refactorings.WorkflowNew.CachingLanguageSpecificImpl<JetBrains.ReSharper.Refactorings.Rename.RenameHelperBase> LanguageSpecific { get; }
        public JetBrains.ReSharper.Psi.PsiLanguageType LanguageType { get; }
        public override bool MightModifyManyDocuments { get; }
        public JetBrains.ReSharper.Psi.Naming.Interfaces.INamingPolicyProvider PrimaryNamingPolicyProvider { get; }
        public bool RenameFiles { get; set; }
        public JetBrains.ReSharper.Refactorings.Rename.RenameRefactoringService RenameService { get; }
        public override string Title { get; }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Refactorings.Workflow.TextOccurenceRenameMarker> CalculateActualTextOccurrences() { }
        public virtual JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage CommitInitialStage(string name, JetBrains.Application.Progress.IProgressIndicator pi, bool searchText) { }
        public JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage CommitRenameDerivedStage(JetBrains.ReSharper.Refactorings.PostRename.PostRenameModel.NameChanges change, JetBrains.Application.Progress.IProgressIndicator pi) { }
        public override JetBrains.ReSharper.Refactorings.Workflow.IRefactoringExecuter CreateRefactoring(JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Resolve.IReference> GetElementReferences(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
        public override bool Initialize(JetBrains.Application.DataContext.IDataContext context) { }
        public override bool IsAvailable(JetBrains.Application.DataContext.IDataContext context) { }
        public void IterateRenameFiles(System.Action<JetBrains.ReSharper.Refactorings.Rename.FileRename, string> action) { }
        public override bool PostExecute(JetBrains.Application.Progress.IProgressIndicator pi) { }
        public override bool PreExecute(JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
        public void SetHierarhyConflicts(System.Collections.Generic.List<JetBrains.ReSharper.Refactorings.Rename.HierarchyConflict> conflicts) { }
        public void SetRenameDataProvider(JetBrains.ReSharper.Refactorings.Rename.IRenameDataProvider value) { }
        public void SetScope(JetBrains.ReSharper.Refactorings.Rename.RenameScope scope) { }
        public JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage ShowFirstPage() { }
        public void TryAddFileRename(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, string name) { }
        public void UpdateReferences([JetBrains.Annotations.CanBeNullAttribute()] System.Collections.Generic.IList<JetBrains.ReSharper.Psi.IDeclaredElement> extraElements, JetBrains.Application.Progress.IProgressIndicator pi) { }
        public override bool Validate() { }
    }
    public abstract class RenameWorkflowProvider : JetBrains.ReSharper.Feature.Services.ActionsMenu.IWorkflowProvider<JetBrains.ReSharper.Refactorings.Workflow.IRefactoringWorkflow, JetBrains.ReSharper.Refactorings.Workflow.RefactoringActionGroup>, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringWorkflowProvider
    {
        protected static string ActionId { get; }
        public abstract System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Refactorings.Workflow.IRefactoringWorkflow> CreateWorkflow(JetBrains.Application.DataContext.IDataContext dataContext);
    }
    public class TypeRenameConflictSearcher : JetBrains.ReSharper.Refactorings.Conflicts.IConflictSearcher
    {
        public TypeRenameConflictSearcher(JetBrains.ReSharper.Refactorings.RenameModel.AtomicRenameBase renameBase) { }
        public JetBrains.ReSharper.Refactorings.Conflicts.ConflictSearchResult SearchConflicts(JetBrains.Application.Progress.IProgressIndicator pi, bool canPerformRefactoring) { }
    }
    [JetBrains.ReSharper.Psi.ShellFeaturePartAttribute()]
    public class VarArgParameterCanNotBeRenamed : JetBrains.ReSharper.Refactorings.Rename.AtomicRenamesFactory
    {
        public override JetBrains.ReSharper.Refactorings.RenameModel.RenameAvailabilityCheckResult CheckRenameAvailability(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
        public override bool IsApplicable(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
    }
}
namespace JetBrains.ReSharper.Refactorings.Rename.Impl
{
    
    public sealed class InlineRenameWorkflow : JetBrains.ReSharper.Refactorings.Workflow.RefactoringWorkflowBase
    {
        public InlineRenameWorkflow(string actionId) { }
        public override JetBrains.ReSharper.Refactorings.Workflow.RefactoringActionGroup ActionGroup { get; }
        public override string ActionId { get; }
        public override JetBrains.ReSharper.Refactorings.Conflicts.IConflictSearcher ConflictSearcher { get; }
        public override JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage FirstPendingRefactoringPage { get; }
        public override bool HasUI { get; }
        public override string HelpKeyword { get; }
        public override JetBrains.UI.Icons.IconId Icon { get; }
        public override bool MightModifyManyDocuments { get; }
        public override JetBrains.ProjectModel.ISolution Solution { get; }
        public override string Title { get; }
        public override bool Execute(JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
        public override bool Initialize(JetBrains.Application.DataContext.IDataContext context) { }
        public override bool IsAvailable(JetBrains.Application.DataContext.IDataContext context) { }
        public override bool PostExecute(JetBrains.Application.Progress.IProgressIndicator pi) { }
        public override bool PreExecute(JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
        public override void SuccessfulFinish(JetBrains.Application.Progress.IProgressIndicator pi) { }
    }
}
namespace JetBrains.ReSharper.Refactorings.Rename.Stages
{
    
    public class DerivedStageExecuter
    {
        public System.Collections.Generic.IList<JetBrains.ReSharper.Refactorings.RenameModel.AtomicRenameBase> DerivedRenameBases { get; }
        public void Init(JetBrains.ReSharper.Refactorings.Rename.RenameWorkflow @this, JetBrains.ReSharper.Refactorings.PostRename.PostRenameModel.NameChanges change) { }
        public JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage Run(JetBrains.Application.Progress.IProgressIndicator pi) { }
    }
    public class InitialStageExecuter
    {
        public InitialStageExecuter() { }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Refactorings.RenameModel.AtomicRenameBase> BaseRenames { get; }
        public string NewName { get; }
        public bool SearchText { get; }
        public JetBrains.ReSharper.Refactorings.Rename.RenameWorkflow Workflow { get; }
        public void Init(JetBrains.ReSharper.Refactorings.Rename.RenameWorkflow workflow, string newName, bool searchText) { }
        public JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage Run(JetBrains.Application.Progress.IProgressIndicator pi) { }
    }
}
namespace JetBrains.ReSharper.Refactorings.RenameModel
{
    
    public abstract class AnonymousTypePropertyAtomicRenameBase : JetBrains.ReSharper.Refactorings.RenameModel.AtomicRenameBase
    {
        protected AnonymousTypePropertyAtomicRenameBase(JetBrains.ReSharper.Psi.IDeclaredElement originalElement, string newName) { }
        public override JetBrains.ReSharper.Psi.IDeclaredElement NewDeclaredElement { get; }
        public override string NewName { get; }
        public override JetBrains.ReSharper.Psi.IDeclaredElement PrimaryDeclaredElement { get; }
        public override System.Collections.Generic.IList<JetBrains.ReSharper.Psi.IDeclaredElement> SecondaryDeclaredElements { get; }
        protected abstract int CompareReferencesOnMemberDeclarations(JetBrains.ReSharper.Psi.Resolve.IReference r1, JetBrains.ReSharper.Psi.Resolve.IReference r2);
        public override void Rename(JetBrains.ReSharper.Refactorings.Rename.RenameRefactoring executer, JetBrains.Application.Progress.IProgressIndicator pi, bool hasConflictsWithDeclarations, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        protected abstract JetBrains.ReSharper.Psi.IDeclaredElement SetName(JetBrains.ReSharper.Psi.IDeclaredElement element, string name);
    }
    public class AtomicRename : JetBrains.ReSharper.Refactorings.RenameModel.AtomicRenameBase
    {
        public AtomicRename([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, [JetBrains.Annotations.NotNullAttribute()] string newName, bool doNotShowBindingConflicts) { }
        public override JetBrains.ReSharper.Psi.IDeclaredElement NewDeclaredElement { get; }
        public override string NewName { get; }
        public override JetBrains.ReSharper.Psi.IDeclaredElement PrimaryDeclaredElement { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public override System.Collections.Generic.IList<JetBrains.ReSharper.Psi.IDeclaredElement> SecondaryDeclaredElements { get; }
        public override void Rename(JetBrains.ReSharper.Refactorings.Rename.RenameRefactoring executer, JetBrains.Application.Progress.IProgressIndicator pi, bool hasConflictsWithDeclarations, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
    }
    public abstract class AtomicRenameBase
    {
        public abstract JetBrains.ReSharper.Psi.IDeclaredElement NewDeclaredElement { get; }
        public abstract string NewName { get; }
        public abstract JetBrains.ReSharper.Psi.IDeclaredElement PrimaryDeclaredElement { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public abstract System.Collections.Generic.IList<JetBrains.ReSharper.Psi.IDeclaredElement> SecondaryDeclaredElements { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public virtual JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage CreateRenamesConfirmationPage(JetBrains.ReSharper.Refactorings.Rename.RenameWorkflow renameWorkflow, System.Func<JetBrains.Application.Progress.IProgressIndicator, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage> func) { }
        public abstract void Rename(JetBrains.ReSharper.Refactorings.Rename.RenameRefactoring executer, JetBrains.Application.Progress.IProgressIndicator pi, bool hasConflictsWithDeclarations, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver);
    }
    public class ElementChange
    {
        public ElementChange(bool enabled, JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
        public JetBrains.ReSharper.Psi.IDeclaredElement DeclaredElement { get; }
        public string ElementPresented { get; }
        public bool Enabled { get; set; }
        public bool IsValid { get; }
        public bool IsValidCached { get; }
        public string TextOfInvalidElement { get; }
        public void Dispose() { }
    }
    public class RenameAvailabilityCheckResult : JetBrains.Util.EnumPattern
    {
        public static readonly JetBrains.ReSharper.Refactorings.RenameModel.RenameAvailabilityCheckResult CanBeRenamed;
        public static readonly JetBrains.ReSharper.Refactorings.RenameModel.RenameAvailabilityCheckResult CanNotBeRenamed;
        public static readonly JetBrains.ReSharper.Refactorings.RenameModel.RenameAvailabilityCheckResult HasNonSourceMembers;
        public static readonly JetBrains.ReSharper.Refactorings.RenameModel.RenameAvailabilityCheckResult IsCompiledElement;
        public static readonly JetBrains.ReSharper.Refactorings.RenameModel.RenameAvailabilityCheckResult IsDelegate;
        public static readonly JetBrains.ReSharper.Refactorings.RenameModel.RenameAvailabilityCheckResult IsOperator;
        public static readonly JetBrains.ReSharper.Refactorings.RenameModel.RenameAvailabilityCheckResult IsVirtualElement;
        public static readonly JetBrains.ReSharper.Refactorings.RenameModel.RenameAvailabilityCheckResult UnsupportedLanguage;
        protected RenameAvailabilityCheckResult(string name, string presentation) { }
        public string Message { get; }
    }
    public abstract class RenameBase { }
}
namespace JetBrains.ReSharper.Refactorings.RenameNamespace
{
    
    public interface INamespaceDeclarationUpdater
    {
        void PreProcess();
        void RestoreReferences();
        void SetNewName();
    }
    public interface IRenameNamespace : JetBrains.ReSharper.Refactorings.ILanguageSpecificRefactoringService
    {
        [JetBrains.Annotations.NotNullAttribute()]
        System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Refactorings.RenameNamespace.INamespaceDeclarationUpdater> BuildNamespaceDeclarationUpdatersForFile(JetBrains.ReSharper.Psi.INamespace @namespace, JetBrains.ReSharper.Psi.Tree.IFile file, string newName);
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Refactorings.Conflicts.IConflictSearcher GetConflictSearcher(JetBrains.ReSharper.Psi.INamespace @namespace, System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.IReferencePointer> references, string name);
    }
    public class RenameNamespaceControl : JetBrains.UI.CommonControls.SafeUserControl, JetBrains.CommonControls.Validation.IValidatorProvider, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage
    {
        public RenameNamespaceControl(JetBrains.ReSharper.Psi.INamespace ns, JetBrains.ReSharper.Refactorings.RenameNamespace.RenameNamespaceRefactoringWorkflow workflow, JetBrains.ReSharper.Psi.PsiLanguageType languageType) { }
        public JetBrains.DataFlow.IProperty<bool> ContinueEnabled { get; }
        public string Description { get; }
        public bool DoNotShow { get; }
        public string Title { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.CommonControls.Validation.IValidator> Validators { get; }
        public JetBrains.UI.CrossFramework.EitherControl View { get; }
        public JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage Commit(JetBrains.Application.Progress.IProgressIndicator pi) { }
        public bool Initialize(JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
        public bool RefreshContents(JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
    }
    public class RenameNamespaceRefactoring
    {
        public RenameNamespaceRefactoring(JetBrains.ReSharper.Psi.INamespace @namespace, string newName, bool searchText) { }
        protected JetBrains.ReSharper.Refactorings.WorkflowNew.CachingLanguageSpecificImpl<JetBrains.ReSharper.Refactorings.Rename.RenameHelperBase> LanguageSpecific { get; }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Psi.IReferencePointer> References { get; }
        public void DoRefactoring(JetBrains.Application.Progress.IProgressIndicator pi) { }
        public JetBrains.ReSharper.Refactorings.Conflicts.IConflictSearcher GetConflictSearcher() { }
        public void RenameTextualOccurences() { }
        public void SearchReferences(JetBrains.Application.Progress.IProgressIndicator searchProgress) { }
    }
    public class RenameNamespaceRefactoringWorkflow : JetBrains.ReSharper.Refactorings.Workflow.RefactoringWorkflowBase
    {
        public RenameNamespaceRefactoringWorkflow(string actionId) { }
        public override JetBrains.ReSharper.Refactorings.Workflow.RefactoringActionGroup ActionGroup { get; }
        public override string ActionId { get; }
        public override JetBrains.ReSharper.Refactorings.Conflicts.IConflictSearcher ConflictSearcher { get; }
        public override JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage FirstPendingRefactoringPage { get; }
        public override bool HasUI { get; }
        public override string HelpKeyword { get; }
        public override JetBrains.UI.Icons.IconId Icon { get; }
        public JetBrains.ReSharper.Psi.PsiLanguageType Language { get; }
        public override bool MightModifyManyDocuments { get; }
        public override JetBrains.ProjectModel.ISolution Solution { get; }
        public override string Title { get; }
        public override bool Execute(JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
        public override bool Initialize(JetBrains.Application.DataContext.IDataContext context) { }
        public void InitializeRefactoring(string newName, JetBrains.Application.Progress.IProgressIndicator pi, bool searchText) { }
        public override bool IsAvailable(JetBrains.Application.DataContext.IDataContext context) { }
        public override bool PostExecute(JetBrains.Application.Progress.IProgressIndicator pi) { }
        public override bool PreExecute(JetBrains.Application.Progress.IProgressIndicator taskExecutorCreator) { }
    }
}
namespace JetBrains.ReSharper.Refactorings.Resources
{
    
    public sealed class RefactoringsThemedIcons
    {
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.NewRefactorings;component/resources/RefactoringsThemedIcons/T" +
            "hemedIcons.Refactorings.Generated.Xaml", 1, "RefactorThis")]
        public sealed class RefactorThis : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.NewRefactorings;component/resources/RefactoringsThemedIcons/T" +
            "hemedIcons.Refactorings.Generated.Xaml", 0, "Subexpression")]
        public sealed class Subexpression : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
    }
}
namespace JetBrains.ReSharper.Refactorings.SafeDeleteFolder.Impl
{
    
    public class SafeDeleteFolderPage : System.Windows.Forms.UserControl, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage
    {
        public SafeDeleteFolderPage(JetBrains.ReSharper.Refactorings.SafeDeleteFolder.SafeDeleteFolderWorkflow workflow) { }
        public JetBrains.DataFlow.IProperty<bool> ContinueEnabled { get; }
        public string Description { get; }
        public bool DoNotShow { get; }
        public string Title { get; }
        public JetBrains.UI.CrossFramework.EitherControl View { get; }
        public JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage Commit(JetBrains.Application.Progress.IProgressIndicator pi) { }
        protected override void Dispose(bool disposing) { }
        public bool Initialize(JetBrains.Application.Progress.IProgressIndicator pi) { }
        public bool RefreshContents(JetBrains.Application.Progress.IProgressIndicator pi) { }
    }
    public class SafeDeleteFolderTreeView : JetBrains.UI.TreeView.TreeModelPresentableView
    {
        public SafeDeleteFolderTreeView(JetBrains.TreeModels.TreeModel model, JetBrains.UI.TreeView.ITreeViewController controller) { }
    }
}
namespace JetBrains.ReSharper.Refactorings.SafeDeleteFolder
{
    
    public class SafeDeleteFolderBase : JetBrains.ReSharper.Refactorings.Common.RefactoringExecBase<JetBrains.ReSharper.Refactorings.SafeDeleteFolder.SafeDeleteFolderWorkflow, JetBrains.ReSharper.Refactorings.SafeDeleteFolder.SafeDeleteFolderRefactoring>
    {
        public SafeDeleteFolderBase(JetBrains.ReSharper.Refactorings.SafeDeleteFolder.SafeDeleteFolderWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
    }
    public class SafeDeleteFolderHelperBase : JetBrains.ReSharper.Refactorings.IWorkflowExec
    {
        public virtual bool IsLanguageSupported { get; }
        public virtual System.Collections.Generic.IList<JetBrains.ReSharper.Psi.IDeclaredElement> GetExternalDeclaredElements(JetBrains.ReSharper.Psi.Tree.IFile file) { }
        public virtual System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Tree.ITreeNode> GetUsingsFromFile(JetBrains.ReSharper.Psi.Tree.IFile file, System.Collections.Generic.IList<JetBrains.ReSharper.Psi.INamespace> namespaces) { }
        public virtual void RemoveUsing(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
    }
    public class SafeDeleteFolderRefactoring : JetBrains.ReSharper.Refactorings.Common.DrivenRefactoring<JetBrains.ReSharper.Refactorings.SafeDeleteFolder.SafeDeleteFolderWorkflow, JetBrains.ReSharper.Refactorings.SafeDeleteFolder.SafeDeleteFolderBase>
    {
        public SafeDeleteFolderRefactoring(JetBrains.ReSharper.Refactorings.SafeDeleteFolder.SafeDeleteFolderWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public override bool Execute(JetBrains.Application.Progress.IProgressIndicator pi) { }
    }
    public class SafeDeleteFolderWorkflow : JetBrains.ReSharper.Refactorings.WorkflowNew.DrivenRefactoringWorkflow2<JetBrains.ReSharper.Refactorings.SafeDeleteFolder.SafeDeleteFolderHelperBase>
    {
        public SafeDeleteFolderWorkflow(JetBrains.ProjectModel.ISolution solution, string actionId) { }
        public override JetBrains.ReSharper.Refactorings.Workflow.RefactoringActionGroup ActionGroup { get; }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Psi.IDeclaredElement> ElementsToSerch { get; }
        public override JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage FirstPendingRefactoringPage { get; }
        public override string HelpKeyword { get; }
        public override bool MightModifyManyDocuments { get; }
        public override string Title { get; }
        public JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage CommitFirstPage(JetBrains.Application.Progress.IProgressIndicator pi) { }
        protected override JetBrains.ReSharper.Refactorings.SafeDeleteFolder.SafeDeleteFolderHelperBase CreateHelper(JetBrains.ReSharper.Refactorings.IRefactoringLanguageService service) { }
        public override JetBrains.ReSharper.Refactorings.Workflow.IRefactoringExecuter CreateRefactoring(JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public JetBrains.UI.TreeView.TreeModelView CreateReviewTree(JetBrains.Application.Progress.IProgressIndicator pi) { }
        protected override JetBrains.ReSharper.Refactorings.SafeDeleteFolder.SafeDeleteFolderHelperBase CreateUnsupportedHelper() { }
        public override bool Initialize(JetBrains.Application.DataContext.IDataContext context) { }
        public override bool IsAvailable(JetBrains.Application.DataContext.IDataContext context) { }
        public bool IsIncluded(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public bool IsIncluded(JetBrains.ProjectModel.IProjectFile projectFile) { }
        public bool IsValid(JetBrains.Application.Progress.IProgressIndicator pi) { }
        public void MakeActionWithPsi(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, System.Action<JetBrains.ReSharper.Psi.Tree.IFile, JetBrains.ReSharper.Psi.PsiLanguageType> action) { }
        public override bool PostExecute(JetBrains.Application.Progress.IProgressIndicator pi) { }
        public override bool PreExecute(JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
    }
}
namespace JetBrains.ReSharper.Refactorings.SafeDeleteTheSecond.Data
{
    
    public class ComposedRemovedCodeScope : JetBrains.ReSharper.Refactorings.SafeDeleteTheSecond.Data.RemovedCodeScope
    {
        public ComposedRemovedCodeScope(System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Tree.ITreeNode> deletedElements) { }
        public override bool IsDeleted(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
    }
    public abstract class RemovedCodeScope
    {
        public abstract bool IsDeleted(JetBrains.ReSharper.Psi.Tree.ITreeNode element);
    }
    public class RemovedElementsInfo
    {
        public RemovedElementsInfo(System.Collections.Generic.IList<JetBrains.ReSharper.Refactorings.SafeDeleteTheSecond.Removers.ElementRemover> removers, JetBrains.ReSharper.Refactorings.SafeDeleteTheSecond.Data.RemovedCodeScope removedCodeScope, System.Collections.Generic.IList<System.Action<JetBrains.ReSharper.Refactorings.SafeDeleteTheSecond.SafeDeleteRefactoring>> actions1, System.Collections.Generic.IList<System.Action<JetBrains.ReSharper.Refactorings.SafeDeleteTheSecond.SafeDeleteRefactoring>> actions2) { }
        public JetBrains.ReSharper.Refactorings.SafeDeleteTheSecond.Data.RemovedCodeScope RemovedCodeScope { get; }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Refactorings.SafeDeleteTheSecond.Removers.ElementRemover> Removers { get; }
        public void BeforeRemovingDeclarations(JetBrains.ReSharper.Refactorings.SafeDeleteTheSecond.SafeDeleteRefactoring refactoring) { }
        public void BeforeUpdatingReferences(JetBrains.ReSharper.Refactorings.SafeDeleteTheSecond.SafeDeleteRefactoring refactoring) { }
    }
    public abstract class SafeDeleteData
    {
        public abstract bool IsValid { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Refactorings.SafeDeleteTheSecond.Data.SafeDeleteData CreateSafeDeleteData(JetBrains.ReSharper.Refactorings.SafeDeleteTheSecond.SafeDeleteWorkflow workflow) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public abstract JetBrains.ReSharper.Refactorings.SafeDeleteTheSecond.Data.RemovedElementsInfo Execute(JetBrains.Application.Progress.IProgressIndicator pi, JetBrains.ReSharper.Refactorings.SafeDeleteTheSecond.SafeDeleteRefactoring refactoring);
        public virtual JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage GetOptionsPage(JetBrains.Application.Progress.IProgressIndicator pi) { }
    }
}
namespace JetBrains.ReSharper.Refactorings.SafeDeleteTheSecond.Impl
{
    
    public class DeleteClassData : JetBrains.ReSharper.Refactorings.SafeDeleteTheSecond.Data.SafeDeleteData
    {
        public DeleteClassData([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.ITypeElement classOrInterface, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Refactorings.SafeDeleteTheSecond.SafeDeleteWorkflow workflow) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public string BaseTypeName { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ReSharper.Psi.Pointers.IDeclaredElementPointer<JetBrains.ReSharper.Psi.ITypeElement> ClassOrInterfacePointer { get; }
        public string ElementKind { get; }
        public bool HasInheritors { get; }
        public bool IsInterface { get; }
        public override bool IsValid { get; }
        public string PresentedTypeName { get; }
        public bool RemoveSingleClass { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Psi.Pointers.IDeclaredElementPointer<JetBrains.ReSharper.Psi.ITypeElement> SingleInheritor { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public string SingleInheritorName { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Psi.Pointers.IElementInstancePointer<JetBrains.ReSharper.Psi.ITypeElement> SuperTypePointer { get; }
        public JetBrains.ReSharper.Refactorings.SafeDeleteTheSecond.Impl.DeleteClassData.UsagesProcessingTypes UsagesProcessingType { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ReSharper.Refactorings.SafeDeleteTheSecond.SafeDeleteWorkflow Workflow { get; }
        public JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage CommitHierarchyPage(bool removeSignleClass, JetBrains.Application.Progress.IProgressIndicator pi) { }
        public JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage CommmiUsagesPage(JetBrains.ReSharper.Refactorings.SafeDeleteTheSecond.Impl.DeleteClassData.UsagesProcessingTypes processingTypes) { }
        public override JetBrains.ReSharper.Refactorings.SafeDeleteTheSecond.Data.RemovedElementsInfo Execute(JetBrains.Application.Progress.IProgressIndicator pi, JetBrains.ReSharper.Refactorings.SafeDeleteTheSecond.SafeDeleteRefactoring refactoring) { }
        public override JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage GetOptionsPage(JetBrains.Application.Progress.IProgressIndicator pi) { }
        public JetBrains.ReSharper.Psi.IPsiServices GetPsiServices() { }
        public enum UsagesProcessingTypes
        {
            None = 0,
            UseBase = 1,
            UseChild = 2,
        }
    }
    public class DeleteClassExecuter
    {
        public DeleteClassExecuter(JetBrains.ReSharper.Refactorings.SafeDeleteTheSecond.Impl.DeleteClassData data, JetBrains.ReSharper.Refactorings.SafeDeleteTheSecond.SafeDeleteRefactoring refactoring) { }
        public JetBrains.ReSharper.Refactorings.SafeDeleteTheSecond.Data.RemovedElementsInfo Execute(JetBrains.Application.Progress.IProgressIndicator pi) { }
    }
    public class DeleteElementData : JetBrains.ReSharper.Refactorings.SafeDeleteTheSecond.Data.SafeDeleteData
    {
        public DeleteElementData([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IDeclaredElement element, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Refactorings.SafeDeleteTheSecond.SafeDeleteWorkflow workflow) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ReSharper.Psi.Pointers.IDeclaredElementPointer<JetBrains.ReSharper.Psi.IDeclaredElement> ElementPointer { get; }
        public override bool IsValid { get; }
        public override JetBrains.ReSharper.Refactorings.SafeDeleteTheSecond.Data.RemovedElementsInfo Execute(JetBrains.Application.Progress.IProgressIndicator pi, JetBrains.ReSharper.Refactorings.SafeDeleteTheSecond.SafeDeleteRefactoring refactoring) { }
        public override JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage GetOptionsPage(JetBrains.Application.Progress.IProgressIndicator pi) { }
    }
    public class DeleteElementExecuter
    {
        public DeleteElementExecuter(JetBrains.ReSharper.Refactorings.SafeDeleteTheSecond.Impl.DeleteElementData data) { }
        public JetBrains.ReSharper.Refactorings.SafeDeleteTheSecond.Data.RemovedElementsInfo Execute(JetBrains.Application.Progress.IProgressIndicator pi, JetBrains.ReSharper.Refactorings.SafeDeleteTheSecond.SafeDeleteRefactoring refactoring) { }
    }
    public class DeleteHierarchyMemberData : JetBrains.ReSharper.Refactorings.SafeDeleteTheSecond.Data.SafeDeleteData
    {
        public DeleteHierarchyMemberData([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IOverridableMember overridableMember, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Refactorings.SafeDeleteTheSecond.SafeDeleteWorkflow workflow) { }
        public bool HasBase { get; }
        public bool HasOverrides { get; }
        public override bool IsValid { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ReSharper.Psi.Pointers.IDeclaredElementPointer<JetBrains.ReSharper.Psi.IOverridableMember> MemberPointer { get; }
        public string PresentedMemberName { get; }
        public JetBrains.ReSharper.Refactorings.SafeDeleteTheSecond.Impl.DeleteHierarchyMemberData.ProcessHierarchyMemberTypes ProcessHierarchyMemberType { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ReSharper.Refactorings.SafeDeleteTheSecond.SafeDeleteWorkflow Workflow { get; }
        public JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage CommitHierarchyPage(JetBrains.ReSharper.Refactorings.SafeDeleteTheSecond.Impl.DeleteHierarchyMemberData.ProcessHierarchyMemberTypes type, JetBrains.Application.Progress.IProgressIndicator pi) { }
        public override JetBrains.ReSharper.Refactorings.SafeDeleteTheSecond.Data.RemovedElementsInfo Execute(JetBrains.Application.Progress.IProgressIndicator pi, JetBrains.ReSharper.Refactorings.SafeDeleteTheSecond.SafeDeleteRefactoring refactoring) { }
        public override JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage GetOptionsPage(JetBrains.Application.Progress.IProgressIndicator pi) { }
        public enum ProcessHierarchyMemberTypes
        {
            All = 0,
            Inheritors = 1,
            Single = 2,
        }
    }
    public class DeleteHierarchyMemberExecuter : JetBrains.ReSharper.Refactorings.Conflicts.HierarchyConflictTextProviderBase
    {
        public DeleteHierarchyMemberExecuter(JetBrains.ReSharper.Refactorings.SafeDeleteTheSecond.Impl.DeleteHierarchyMemberData data, JetBrains.ReSharper.Refactorings.SafeDeleteTheSecond.SafeDeleteRefactoring refactoring) { }
        public JetBrains.ReSharper.Refactorings.SafeDeleteTheSecond.Data.RemovedElementsInfo Execute(JetBrains.Application.Progress.IProgressIndicator pi) { }
        public override string QuasiImplements() { }
        public override string WillAlsoImplement() { }
        public override string WillAlsoOverride() { }
    }
    public class DeleteParameterData : JetBrains.ReSharper.Refactorings.SafeDeleteTheSecond.Data.SafeDeleteData
    {
        public DeleteParameterData([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IParameter overridableMember, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Refactorings.SafeDeleteTheSecond.SafeDeleteWorkflow workflow) { }
        public override bool IsValid { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ReSharper.Psi.Pointers.IDeclaredElementPointer<JetBrains.ReSharper.Psi.IParameter> ParameterPointer { get; }
        public override JetBrains.ReSharper.Refactorings.SafeDeleteTheSecond.Data.RemovedElementsInfo Execute(JetBrains.Application.Progress.IProgressIndicator pi, JetBrains.ReSharper.Refactorings.SafeDeleteTheSecond.SafeDeleteRefactoring refactoring) { }
        public override JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage GetOptionsPage(JetBrains.Application.Progress.IProgressIndicator pi) { }
    }
    public class DeleteParameterExecuter : JetBrains.ReSharper.Refactorings.Conflicts.HierarchyConflictTextProviderBase
    {
        public DeleteParameterExecuter(JetBrains.ReSharper.Refactorings.SafeDeleteTheSecond.Impl.DeleteParameterData data, JetBrains.ReSharper.Refactorings.SafeDeleteTheSecond.SafeDeleteRefactoring refactoring) { }
        public JetBrains.ReSharper.Refactorings.SafeDeleteTheSecond.Data.RemovedElementsInfo Execute(JetBrains.Application.Progress.IProgressIndicator pi) { }
        public override string QuasiImplements() { }
        public override string WillAlsoImplement() { }
        public override string WillAlsoOverride() { }
    }
    public class DeleteTypeParameterData : JetBrains.ReSharper.Refactorings.SafeDeleteTheSecond.Data.SafeDeleteData
    {
        public DeleteTypeParameterData([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.ITypeParameter overridableMember, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Refactorings.SafeDeleteTheSecond.SafeDeleteWorkflow workflow) { }
        public override bool IsValid { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ReSharper.Psi.Pointers.IDeclaredElementPointer<JetBrains.ReSharper.Psi.ITypeParameter> TypeParameterPointer { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ReSharper.Refactorings.SafeDeleteTheSecond.SafeDeleteWorkflow Workflow { get; }
        public override JetBrains.ReSharper.Refactorings.SafeDeleteTheSecond.Data.RemovedElementsInfo Execute(JetBrains.Application.Progress.IProgressIndicator pi, JetBrains.ReSharper.Refactorings.SafeDeleteTheSecond.SafeDeleteRefactoring refactoring) { }
        public override JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage GetOptionsPage(JetBrains.Application.Progress.IProgressIndicator pi) { }
    }
    public class DeleteTypeParameterExecuter : JetBrains.ReSharper.Refactorings.Conflicts.HierarchyConflictTextProviderBase
    {
        public DeleteTypeParameterExecuter(JetBrains.ReSharper.Refactorings.SafeDeleteTheSecond.Impl.DeleteTypeParameterData data, JetBrains.ReSharper.Refactorings.SafeDeleteTheSecond.SafeDeleteRefactoring refactoring) { }
        public JetBrains.ReSharper.Refactorings.SafeDeleteTheSecond.Data.RemovedElementsInfo Execute(JetBrains.Application.Progress.IProgressIndicator pi) { }
        public override string QuasiImplements() { }
        public override string WillAlsoImplement() { }
        public override string WillAlsoOverride() { }
    }
}
namespace JetBrains.ReSharper.Refactorings.SafeDeleteTheSecond
{
    
    public interface ISafeDeleteDataProvider
    {
        bool AllHierarchy { get; }
        JetBrains.ReSharper.Refactorings.SafeDeleteTheSecond.Impl.DeleteHierarchyMemberData.ProcessHierarchyMemberTypes ProcessHierarchyMemberType { get; }
        JetBrains.ReSharper.Refactorings.SafeDeleteTheSecond.Impl.DeleteClassData.UsagesProcessingTypes UsagesProcessingTypes { get; }
    }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "SafeDelete"})]
    public class SafeDeleteAction : JetBrains.ReSharper.Refactorings.Workflow.ExtensibleRefactoringAction<JetBrains.ReSharper.Refactorings.SafeDeleteTheSecond.SafeDeleteWorkflowProvider>
    {
        public const string ACTION_ID = "SafeDelete";
        protected override JetBrains.UI.RichText.RichText Caption { get; }
    }
    public class SafeDeleteBase : JetBrains.ReSharper.Refactorings.Common.RefactoringExecBase<JetBrains.ReSharper.Refactorings.SafeDeleteTheSecond.SafeDeleteWorkflow, JetBrains.ReSharper.Refactorings.SafeDeleteTheSecond.SafeDeleteRefactoring>
    {
        public SafeDeleteBase(JetBrains.ReSharper.Refactorings.SafeDeleteTheSecond.SafeDeleteWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public virtual System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Tree.IArgument> GetArgumentsToRemove(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.IParametersOwner owner, JetBrains.ReSharper.Psi.IParameter parameter) { }
        public virtual System.Collections.Generic.IList<JetBrains.ReSharper.Refactorings.SafeDeleteTheSecond.Removers.ElementRemover> GetExtraElementsFromDeclaration(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration) { }
        public virtual bool IsExtensionCall(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public virtual bool IsMethodGroup(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public virtual bool IsPartial(JetBrains.ReSharper.Psi.IMethod method) { }
        public virtual bool IsReferenceOnConstructor(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public virtual bool IsSingleAndCallsToBase(JetBrains.ReSharper.Psi.IConstructor constructor) { }
        public virtual void MakeVirtual(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration) { }
        public virtual void RemoveArgument(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Refactorings.SafeDeleteTheSecond.Removers.ArgumentRemover remover, JetBrains.ReSharper.Refactorings.SafeDeleteTheSecond.Removers.ArgumentRemover.PerReferenceData data) { }
        public virtual bool RemoveCallToBaseMethod(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public virtual void RemoveDeclaration(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration) { }
        public virtual bool RemoveExpression(JetBrains.ReSharper.Psi.Tree.IExpression expression) { }
        public virtual void RemoveImplicitAccessor(JetBrains.ReSharper.Psi.IAccessor accessor) { }
        public virtual bool RemoveInterfaceMemberSpecification(JetBrains.ReSharper.Psi.Resolve.IReference expression, bool remove) { }
        public virtual bool RemoveInvocationStatement(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public virtual void RemoveNewRedundantUsings(JetBrains.ReSharper.Psi.Tree.IFile file, System.Collections.Generic.JetHashSet<JetBrains.ReSharper.Psi.Tree.ITreeNode> oldUsings, JetBrains.Application.Progress.SubProgressIndicator pi) { }
        public virtual bool RemoveReference(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public virtual bool RemoveSubscription(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public virtual void RemoveTypeParameterDeclaration(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration) { }
        public virtual bool ReplaceExplicitImplementation(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public virtual void ReplaceExplicitImplementation(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration) { }
        public virtual void SaveUnusedUsings(JetBrains.ReSharper.Psi.Tree.IFile file) { }
        public virtual void SetBaseTypes(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration, JetBrains.ReSharper.Psi.IDeclaredType baseClass, System.Collections.Generic.IList<JetBrains.ReSharper.Psi.IDeclaredType> param, JetBrains.ReSharper.Psi.ITypeElement baseElementToRemove) { }
        public virtual void TryRemoveNullChecking(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration) { }
    }
    public class SafeDeleteDataProvider : JetBrains.ReSharper.Refactorings.SafeDeleteTheSecond.ISafeDeleteDataProvider
    {
        public SafeDeleteDataProvider(JetBrains.ReSharper.Refactorings.SafeDeleteTheSecond.Impl.DeleteHierarchyMemberData.ProcessHierarchyMemberTypes processHierarchyMemberType, bool allHierarchy, JetBrains.ReSharper.Refactorings.SafeDeleteTheSecond.Impl.DeleteClassData.UsagesProcessingTypes usagesProcessingTypes) { }
        public SafeDeleteDataProvider(string classes, string replace, string overrides) { }
        public bool AllHierarchy { get; }
        public JetBrains.ReSharper.Refactorings.SafeDeleteTheSecond.Impl.DeleteHierarchyMemberData.ProcessHierarchyMemberTypes ProcessHierarchyMemberType { get; }
        public JetBrains.ReSharper.Refactorings.SafeDeleteTheSecond.Impl.DeleteClassData.UsagesProcessingTypes UsagesProcessingTypes { get; }
    }
    public class SafeDeleteHelperUnsupported : JetBrains.ReSharper.Refactorings.IWorkflowExec
    {
        public virtual bool IsLanguageSupported { get; }
        public virtual bool CanBeRemoved(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration) { }
        public virtual System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Tree.ITreeNode> GetUsingsFromFile(JetBrains.ReSharper.Psi.Tree.IFile file, System.Collections.Generic.IList<JetBrains.ReSharper.Psi.INamespace> namespaces) { }
        public virtual bool IsBaseClassSpecifier(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public virtual bool IsInterfaceImplementationSpecifier(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public virtual void RemoveUsing(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
    }
    public class SafeDeletePage2TypeElement : System.Windows.Forms.UserControl, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage
    {
        public SafeDeletePage2TypeElement(JetBrains.ReSharper.Refactorings.SafeDeleteTheSecond.Impl.DeleteClassData data) { }
        public JetBrains.DataFlow.IProperty<bool> ContinueEnabled { get; }
        public string Description { get; }
        public bool DoNotShow { get; }
        public string Title { get; }
        public JetBrains.UI.CrossFramework.EitherControl View { get; }
        public JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage Commit(JetBrains.Application.Progress.IProgressIndicator pi) { }
        protected override void Dispose(bool disposing) { }
        public bool Initialize(JetBrains.Application.Progress.IProgressIndicator pi) { }
        public bool RefreshContents(JetBrains.Application.Progress.IProgressIndicator pi) { }
    }
    public class SafeDeletePageOverridableMember : System.Windows.Forms.UserControl, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage
    {
        public SafeDeletePageOverridableMember(JetBrains.ReSharper.Refactorings.SafeDeleteTheSecond.Impl.DeleteHierarchyMemberData data) { }
        public JetBrains.DataFlow.IProperty<bool> ContinueEnabled { get; }
        public string Description { get; }
        public bool DoNotShow { get; }
        public string Title { get; }
        public JetBrains.UI.CrossFramework.EitherControl View { get; }
        public JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage Commit(JetBrains.Application.Progress.IProgressIndicator pi) { }
        protected override void Dispose(bool disposing) { }
        public bool Initialize(JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
        public bool RefreshContents(JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
    }
    public class SafeDeletePageReplaceTypeUsages : System.Windows.Forms.UserControl, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage
    {
        public SafeDeletePageReplaceTypeUsages(JetBrains.ReSharper.Refactorings.SafeDeleteTheSecond.Impl.DeleteClassData data) { }
        public JetBrains.DataFlow.IProperty<bool> ContinueEnabled { get; }
        public string Description { get; }
        public bool DoNotShow { get; }
        public string Title { get; }
        public JetBrains.UI.CrossFramework.EitherControl View { get; }
        public JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage Commit(JetBrains.Application.Progress.IProgressIndicator pi) { }
        protected override void Dispose(bool disposing) { }
        public bool Initialize(JetBrains.Application.Progress.IProgressIndicator pi) { }
        public bool RefreshContents(JetBrains.Application.Progress.IProgressIndicator pi) { }
    }
    public class SafeDeletePageStart : System.Windows.Forms.UserControl, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage
    {
        public SafeDeletePageStart(JetBrains.ReSharper.Refactorings.SafeDeleteTheSecond.SafeDeleteWorkflow workflow) { }
        public JetBrains.DataFlow.IProperty<bool> ContinueEnabled { get; }
        public string Description { get; }
        public bool DoNotShow { get; }
        public string Title { get; }
        public JetBrains.UI.CrossFramework.EitherControl View { get; }
        public JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage Commit(JetBrains.Application.Progress.IProgressIndicator pi) { }
        protected override void Dispose(bool disposing) { }
        public bool Initialize(JetBrains.Application.Progress.IProgressIndicator pi) { }
        public bool RefreshContents(JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
    }
    public class SafeDeleteRefactoring : JetBrains.ReSharper.Refactorings.Common.DrivenRefactoring<JetBrains.ReSharper.Refactorings.SafeDeleteTheSecond.SafeDeleteWorkflow, JetBrains.ReSharper.Refactorings.SafeDeleteTheSecond.SafeDeleteBase>
    {
        public SafeDeleteRefactoring(JetBrains.ReSharper.Refactorings.SafeDeleteTheSecond.SafeDeleteWorkflow workFlow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public JetBrains.ReSharper.Refactorings.Move.Common.UnusedUsingSaver UsingsSaver { get; }
        protected override JetBrains.ReSharper.Refactorings.SafeDeleteTheSecond.SafeDeleteBase CreateRefactoringInternal(JetBrains.ReSharper.Refactorings.InternalRefactoringLanguageService service) { }
        protected override JetBrains.ReSharper.Refactorings.SafeDeleteTheSecond.SafeDeleteBase CreateUnsupportedRefactoring() { }
        public override bool Execute(JetBrains.Application.Progress.IProgressIndicator pi) { }
    }
    public class SafeDeleteRemoveFilesConfirmation : System.Windows.Forms.UserControl, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage
    {
        public SafeDeleteRemoveFilesConfirmation(JetBrains.ReSharper.Refactorings.SafeDeleteTheSecond.SafeDeleteWorkflow workflow) { }
        public JetBrains.DataFlow.IProperty<bool> ContinueEnabled { get; }
        public string Description { get; }
        public bool DoNotShow { get; }
        public string Title { get; }
        public JetBrains.UI.CrossFramework.EitherControl View { get; }
        public JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage Commit(JetBrains.Application.Progress.IProgressIndicator pi) { }
        protected override void Dispose(bool disposing) { }
        public bool Initialize(JetBrains.Application.Progress.IProgressIndicator pi) { }
        public bool RefreshContents(JetBrains.Application.Progress.IProgressIndicator pi) { }
    }
    public class SafeDeleteWorkflow : JetBrains.ReSharper.Refactorings.WorkflowNew.DrivenRefactoringWorkflow2<JetBrains.ReSharper.Refactorings.SafeDeleteTheSecond.SafeDeleteHelperUnsupported>
    {
        public SafeDeleteWorkflow(JetBrains.ProjectModel.ISolution solution, string actionId) { }
        public override JetBrains.ReSharper.Refactorings.Workflow.RefactoringActionGroup ActionGroup { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Refactorings.SafeDeleteTheSecond.Data.SafeDeleteData Data { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Refactorings.SafeDeleteTheSecond.ISafeDeleteDataProvider DataProvider { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ReSharper.Psi.Pointers.IDeclaredElementPointer<JetBrains.ReSharper.Psi.IDeclaredElement> ElementPointer { get; }
        public override JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage FirstPendingRefactoringPage { get; }
        public override string HelpKeyword { get; }
        public bool IsValid { get; }
        public JetBrains.ReSharper.Psi.PsiLanguageType LanguageType { get; }
        public override bool MightModifyManyDocuments { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public string PresentedElementName { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Psi.IReferencePointer ReferencePointer { get; }
        public bool RemoveFiles { get; set; }
        public override string Title { get; }
        public void AddProjectFileToRemove(JetBrains.ProjectModel.IProjectFile file) { }
        protected override JetBrains.ReSharper.Refactorings.SafeDeleteTheSecond.SafeDeleteHelperUnsupported CreateHelper(JetBrains.ReSharper.Refactorings.IRefactoringLanguageService service) { }
        public override JetBrains.ReSharper.Refactorings.Workflow.IRefactoringExecuter CreateRefactoring(JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        protected override JetBrains.ReSharper.Refactorings.SafeDeleteTheSecond.SafeDeleteHelperUnsupported CreateUnsupportedHelper() { }
        public JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage GetFirstPageOrNull(JetBrains.Application.Progress.IProgressIndicator pi) { }
        public override bool Initialize(JetBrains.Application.DataContext.IDataContext context) { }
        public override bool IsAvailable(JetBrains.Application.DataContext.IDataContext context) { }
        public override bool PostExecute(JetBrains.Application.Progress.IProgressIndicator pi) { }
        public override bool PreExecute(JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
        public void SetDataProvider(JetBrains.ReSharper.Refactorings.SafeDeleteTheSecond.ISafeDeleteDataProvider provider) { }
    }
    public abstract class SafeDeleteWorkflowProvider : JetBrains.ReSharper.Feature.Services.ActionsMenu.IWorkflowProvider<JetBrains.ReSharper.Refactorings.Workflow.IRefactoringWorkflow, JetBrains.ReSharper.Refactorings.Workflow.RefactoringActionGroup>, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringWorkflowProvider
    {
        protected static string ActionId { get; }
        public abstract System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Refactorings.Workflow.IRefactoringWorkflow> CreateWorkflow(JetBrains.Application.DataContext.IDataContext dataContext);
    }
}
namespace JetBrains.ReSharper.Refactorings.SafeDeleteTheSecond.Removers
{
    
    public class AccessorUsagesRemover : JetBrains.ReSharper.Refactorings.SafeDeleteTheSecond.Removers.ElementRemover
    {
        public AccessorUsagesRemover(JetBrains.ReSharper.Psi.IAccessor element) { }
        public override JetBrains.ReSharper.Psi.IDeclaredElement ElementToRemove { get; }
        public override JetBrains.ReSharper.Psi.IDeclaredElement ElementToSearch { get; }
        public override bool RemoveReference(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Refactorings.SafeDeleteTheSecond.SafeDeleteRefactoring refactoring) { }
    }
    public class ArgumentRemover : JetBrains.ReSharper.Refactorings.SafeDeleteTheSecond.Removers.ElementRemover
    {
        public ArgumentRemover(int index, JetBrains.ReSharper.Psi.IParametersOwner parametersOwner) { }
        public override JetBrains.ReSharper.Psi.IDeclaredElement ElementToRemove { get; }
        public override JetBrains.ReSharper.Psi.IDeclaredElement ElementToSearch { get; }
        public bool IsExtensionFirstParameter { get; }
        public string ParameterName { get; }
        public override void InitReference(JetBrains.ReSharper.Refactorings.SafeDeleteTheSecond.SafeDeleteRefactoring refactoring, JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public override bool RemoveReference(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Refactorings.SafeDeleteTheSecond.SafeDeleteRefactoring refactoring) { }
        public class PerReferenceData
        {
            public PerReferenceData(JetBrains.ReSharper.Psi.Pointers.IElementInstancePointer<JetBrains.ReSharper.Psi.IParametersOwner> parametersOwnerPointer, System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Tree.IArgument> argumentsToRemove, bool isExtensionCall, bool isMethodGroup, System.Collections.Generic.List<string> names, System.Collections.Generic.List<JetBrains.ReSharper.Psi.IType> types, JetBrains.ReSharper.Psi.ParameterKind kind) { }
            public System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Tree.IArgument> ArgumentsToRemove { get; }
            public bool IsExtensionCall { get; }
            public bool IsMethodGroup { get; }
            public JetBrains.ReSharper.Psi.ParameterKind Kind { get; }
            public System.Collections.Generic.List<string> ParameterNames { get; }
            public JetBrains.ReSharper.Psi.DeclaredElementInstance<JetBrains.ReSharper.Psi.IParametersOwner> ParametersOwner { get; }
            public System.Collections.Generic.List<JetBrains.ReSharper.Psi.IType> ParameterTypes { get; }
        }
    }
    public abstract class ElementRemover
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        public abstract JetBrains.ReSharper.Psi.IDeclaredElement ElementToRemove { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public abstract JetBrains.ReSharper.Psi.IDeclaredElement ElementToSearch { get; }
        public virtual void InitReference(JetBrains.ReSharper.Refactorings.SafeDeleteTheSecond.SafeDeleteRefactoring refactoring, JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public abstract bool RemoveReference(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Refactorings.SafeDeleteTheSecond.SafeDeleteRefactoring refactoring);
    }
    public class ParameterRemover : JetBrains.ReSharper.Refactorings.SafeDeleteTheSecond.Removers.ElementRemover
    {
        public ParameterRemover(JetBrains.ReSharper.Psi.IParameter parameter) { }
        public override JetBrains.ReSharper.Psi.IDeclaredElement ElementToRemove { get; }
        public override JetBrains.ReSharper.Psi.IDeclaredElement ElementToSearch { get; }
        public override bool RemoveReference(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Refactorings.SafeDeleteTheSecond.SafeDeleteRefactoring refactoring) { }
    }
    public class SimpleRemoverUsagesOnly : JetBrains.ReSharper.Refactorings.SafeDeleteTheSecond.Removers.ElementRemover
    {
        public SimpleRemoverUsagesOnly(JetBrains.ReSharper.Psi.IDeclaredElement element, bool removeCallToBase) { }
        public override JetBrains.ReSharper.Psi.IDeclaredElement ElementToRemove { get; }
        public override JetBrains.ReSharper.Psi.IDeclaredElement ElementToSearch { get; }
        public override bool RemoveReference(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Refactorings.SafeDeleteTheSecond.SafeDeleteRefactoring refactoring) { }
    }
    public class TypeArgumentRemover : JetBrains.ReSharper.Refactorings.SafeDeleteTheSecond.Removers.ElementRemover
    {
        public TypeArgumentRemover(JetBrains.ReSharper.Psi.ITypeParametersOwner owner, JetBrains.ReSharper.Psi.ITypeParameter removedTypeParameter) { }
        public override JetBrains.ReSharper.Psi.IDeclaredElement ElementToRemove { get; }
        public override JetBrains.ReSharper.Psi.IDeclaredElement ElementToSearch { get; }
        public override void InitReference(JetBrains.ReSharper.Refactorings.SafeDeleteTheSecond.SafeDeleteRefactoring refactoring, JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public override bool RemoveReference(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Refactorings.SafeDeleteTheSecond.SafeDeleteRefactoring refactoring) { }
    }
    public class TypeParameterUsagesRemover : JetBrains.ReSharper.Refactorings.SafeDeleteTheSecond.Removers.ElementRemover
    {
        public TypeParameterUsagesRemover(JetBrains.ReSharper.Psi.ITypeParameter typeParameter) { }
        public override JetBrains.ReSharper.Psi.IDeclaredElement ElementToRemove { get; }
        public override JetBrains.ReSharper.Psi.IDeclaredElement ElementToSearch { get; }
        public override bool RemoveReference(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Refactorings.SafeDeleteTheSecond.SafeDeleteRefactoring refactoring) { }
    }
}
namespace JetBrains.ReSharper.Refactorings.src.ChangeSignature.ChangeSignatureWorkItems
{
    
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "AddParameterGlobal"})]
    public class AddGlobalParameterAction : JetBrains.ReSharper.Refactorings.PushPullValue.ContextActions.WorkItemContextActionBase
    {
        public const string ACTION_ID = "AddParameterGlobal";
        protected override JetBrains.UI.RichText.RichText Caption { get; }
    }
    public interface IAddParameterWorkflowProvider : JetBrains.ReSharper.Feature.Services.ActionsMenu.IWorkflowProvider<Test.WorkItems.PushPullValue.IWorkItemsWorkflow, Test.WorkItems.PushPullValue.WorkItemsActionGroup>, Test.WorkItems.PushPullValue.IWorkItemsWorkflowProvider { }
}
namespace JetBrains.ReSharper.Refactorings.src.ExtractClass.Info
{
    
    public class PropertyInfo : JetBrains.ReSharper.Refactorings.ExtractClass.Info.DataInfo
    {
        public PropertyInfo(JetBrains.ReSharper.Psi.IDeclaredElement element, JetBrains.ReSharper.Refactorings.ExtractClass.Analysis.ExtractClassAnalyzer analyzer, bool isAuto) { }
        public bool IsAuto { get; }
        public override System.Collections.Generic.List<JetBrains.ReSharper.Refactorings.ExtractClass.CommandInfo> FillCommands() { }
        public override bool HasSameDeclaredElement(JetBrains.ReSharper.Psi.IDeclaredElement element) { }
    }
}
namespace JetBrains.ReSharper.Refactorings.src.ExtractClass.UI.NextGenUI
{
    
    public class ExtractClassContainer : System.Windows.Controls.ListView
    {
        public ExtractClassContainer() { }
        protected override void OnRenderSizeChanged(System.Windows.SizeChangedInfo sizeInfo) { }
        protected override void OnSelectionChanged(System.Windows.Controls.SelectionChangedEventArgs e) { }
    }
    public class ResizeColumnsBehaviour : System.Windows.DependencyObject
    {
        public static readonly System.Windows.DependencyProperty IsStretchedProperty;
        public static readonly System.Windows.DependencyProperty StretchProperty;
        public static bool GetIsStretched(System.Windows.DependencyObject obj) { }
        public static bool GetStretch(System.Windows.DependencyObject obj) { }
        public static object OnCoerceStretch(System.Windows.DependencyObject source, object value) { }
        public static object OnCoerceStretched(System.Windows.DependencyObject source, object value) { }
        public static void SetIsStretched(System.Windows.DependencyObject obj, bool value) { }
        public static void SetStretch(System.Windows.DependencyObject obj, bool value) { }
    }
}
namespace JetBrains.ReSharper.Refactorings.src.PushPullTool.UI
{
    
    public class PullParameterTreeGridView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector
    {
        public PullParameterTreeGridView(JetBrains.ReSharper.Refactorings.PushPullTool.PullParameterSession session) { }
        public System.Collections.Generic.List<JetBrains.ReSharper.Refactorings.PushPullTool.CallPresentation> Usages { get; set; }
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        public void InitializeComponent() { }
        [JetBrains.Annotations.NotifyPropertyChangedInvocatorAttribute()]
        public void OnPropertyChanged(string propertyName) { }
    }
}
namespace JetBrains.ReSharper.Refactorings.src.PushPullValue.ContextActions
{
    
    public interface IWorkItemsProvider
    {
        JetBrains.ReSharper.Refactorings.PushPullValue.Nodes.IWorkItemNode GetWorkItem(JetBrains.Application.DataContext.IDataContext dataContext);
    }
}
namespace JetBrains.ReSharper.Refactorings.src.PushPullValue.Nodes
{
    
    public class WorkItemPresentation
    {
        public WorkItemPresentation(JetBrains.UI.RichText.RichText text, JetBrains.UI.Icons.IconId icon) { }
        public WorkItemPresentation() { }
        public JetBrains.UI.Icons.IconId Icon { get; set; }
        public JetBrains.DataFlow.IProperty<JetBrains.UI.RichText.RichText> Text { get; set; }
        public void SetResolved() { }
        public void SetText(JetBrains.UI.RichText.RichText text, bool resolved) { }
    }
}
namespace JetBrains.ReSharper.Refactorings.src.Unsupported
{
    
    public class ExtractClassHelperUnsupported : JetBrains.ReSharper.Refactorings.ExtractClass.ExtractClassHelper
    {
        public override bool IsLanguageSupported { get; }
    }
}
namespace JetBrains.ReSharper.Refactorings.Static2Extension
{
    
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "Extension2StaticAction"})]
    public class Extension2StaticAction : JetBrains.ReSharper.Refactorings.Workflow.ExtensibleRefactoringAction<JetBrains.ReSharper.Refactorings.Static2Extension.IExtension2StaticWorkflowProvider>
    {
        public const string ACTION_ID = "Extension2StaticAction";
        protected override JetBrains.UI.RichText.RichText Caption { get; }
    }
    public interface IExtension2StaticWorkflowProvider : JetBrains.ReSharper.Feature.Services.ActionsMenu.IWorkflowProvider<JetBrains.ReSharper.Refactorings.Workflow.IRefactoringWorkflow, JetBrains.ReSharper.Refactorings.Workflow.RefactoringActionGroup>, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringWorkflowProvider { }
    public interface IStatic2ExtensionWorkflowProvider : JetBrains.ReSharper.Feature.Services.ActionsMenu.IWorkflowProvider<JetBrains.ReSharper.Refactorings.Workflow.IRefactoringWorkflow, JetBrains.ReSharper.Refactorings.Workflow.RefactoringActionGroup>, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringWorkflowProvider { }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "Static2ExtensionAction"})]
    public class Static2ExtensionAction : JetBrains.ReSharper.Refactorings.Workflow.ExtensibleRefactoringAction<JetBrains.ReSharper.Refactorings.Static2Extension.IStatic2ExtensionWorkflowProvider>
    {
        public const string ACTION_ID = "Static2ExtensionAction";
        protected override JetBrains.UI.RichText.RichText Caption { get; }
    }
    public abstract class Static2ExtensionBase : JetBrains.ReSharper.Refactorings.Common.RefactoringExecBase<JetBrains.ReSharper.Refactorings.Static2Extension.Static2ExtensionWorkflow, JetBrains.ReSharper.Refactorings.Static2Extension.Static2ExtensionRefactoring>
    {
        protected Static2ExtensionBase(JetBrains.ReSharper.Refactorings.Static2Extension.Static2ExtensionWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public abstract void MakeCallExtension(JetBrains.ReSharper.Psi.Resolve.IReference reference);
        public abstract void MakeCallPlainStatic(JetBrains.ReSharper.Psi.Resolve.IReference reference);
    }
    public class Static2ExtensionRefactoring : JetBrains.ReSharper.Refactorings.Common.DrivenRefactoring<JetBrains.ReSharper.Refactorings.Static2Extension.Static2ExtensionWorkflow, JetBrains.ReSharper.Refactorings.Static2Extension.Static2ExtensionBase>
    {
        public Static2ExtensionRefactoring(JetBrains.ReSharper.Refactorings.Static2Extension.Static2ExtensionWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver, JetBrains.ReSharper.Refactorings.Static2Extension.Static2ExtensionWorkflow.Direction direction) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ReSharper.Psi.IMethod Method { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ReSharper.Psi.IClass OwnerClass { get; }
        protected override JetBrains.ReSharper.Refactorings.Static2Extension.Static2ExtensionBase CreateRefactoringInternal(JetBrains.ReSharper.Refactorings.InternalRefactoringLanguageService service) { }
        protected override JetBrains.ReSharper.Refactorings.Static2Extension.Static2ExtensionBase CreateUnsupportedRefactoring() { }
        public override bool Execute(JetBrains.Application.Progress.IProgressIndicator pi) { }
    }
    public class Static2ExtensionWorkflow : JetBrains.ReSharper.Refactorings.Workflow.DrivenRefactoringWorkflow
    {
        public Static2ExtensionWorkflow(JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Static2Extension.Static2ExtensionWorkflow.Direction direction, string actionId) { }
        public override JetBrains.ReSharper.Refactorings.Workflow.RefactoringActionGroup ActionGroup { get; }
        public override JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage FirstPendingRefactoringPage { get; }
        public override string HelpKeyword { get; }
        public JetBrains.ReSharper.Psi.IMethod Method { get; }
        public override bool MightModifyManyDocuments { get; }
        public JetBrains.ReSharper.Psi.IClass OwnerClass { get; }
        public override string Title { get; }
        public override JetBrains.ReSharper.Refactorings.Workflow.IRefactoringExecuter CreateRefactoring(JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public override bool Initialize(JetBrains.Application.DataContext.IDataContext context) { }
        public override bool IsAvailable(JetBrains.Application.DataContext.IDataContext context) { }
        public override bool PreExecute(JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
        public override bool Validate() { }
        public enum Direction
        {
            Static2Extension = 0,
            Extension2Static = 1,
        }
    }
}
namespace JetBrains.ReSharper.Refactorings.TransformOutParameters
{
    
    public struct FontAttributes
    {
        public System.Windows.Media.FontFamily FontFamily { get; }
        public double FontSize { get; }
        public System.Windows.FontStretch FontStretch { get; }
        public System.Windows.FontStyle FontStyle { get; }
    }
    public struct HighlightingParameters
    {
        public const string Punctuation = "[]{}?<>:.,()\'` ";
        public System.Windows.Media.Brush BackgroundColor { get; }
        public System.Windows.Media.Color CommentColor { get; }
        public System.Windows.Media.Color KeywordColor { get; }
        public System.Windows.Media.Color MethodNameColor { get; }
        public System.Windows.Media.Color ParameterNameColor { get; }
        public System.Windows.Media.Color PunctuationColor { get; }
        public System.Windows.Media.Color TypeColor { get; }
    }
    public interface ITransformOutParametersDriver { }
    public interface ITransformOutParametersWorkflowProvider : JetBrains.ReSharper.Feature.Services.ActionsMenu.IWorkflowProvider<JetBrains.ReSharper.Refactorings.Workflow.IRefactoringWorkflow, JetBrains.ReSharper.Refactorings.Workflow.RefactoringActionGroup>, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringWorkflowProvider { }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "TransformOutParameters"})]
    public class TransformOutParametersAction : JetBrains.ReSharper.Refactorings.Workflow.ExtensibleRefactoringAction<JetBrains.ReSharper.Refactorings.TransformOutParameters.ITransformOutParametersWorkflowProvider>
    {
        public const string ACTION_ID = "TransformOutParameters";
        protected override JetBrains.UI.RichText.RichText Caption { get; }
    }
    public abstract class TransformOutParametersBase : JetBrains.ReSharper.Refactorings.Common.RefactoringExecBase<JetBrains.ReSharper.Refactorings.TransformOutParameters.TransformOutParametersWorkflow, JetBrains.ReSharper.Refactorings.TransformOutParameters.TransformOutParametersRefactoring>
    {
        protected TransformOutParametersBase(JetBrains.ReSharper.Refactorings.TransformOutParameters.TransformOutParametersWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public virtual bool ThisIsUsed(JetBrains.ReSharper.Psi.Tree.ITreeNode expression) { }
    }
    public class TransformOutParametersHelper : JetBrains.ReSharper.Refactorings.IWorkflowExec
    {
        protected readonly JetBrains.ReSharper.Refactorings.TransformOutParameters.TransformOutParametersWorkflow workflow;
        public TransformOutParametersHelper(JetBrains.ReSharper.Refactorings.TransformOutParameters.TransformOutParametersWorkflow workflow) { }
        public virtual bool IsLanguageSupported { get; }
        protected System.Windows.Documents.Run CreateRun(string text, System.Windows.Media.Color color) { }
        protected System.Windows.Controls.TextBlock CreateTextBlock(System.Collections.Generic.IEnumerable<System.Windows.Documents.Run> inlines) { }
        protected virtual System.Windows.Documents.Run CreateTypeElementRun(string name, JetBrains.ReSharper.Refactorings.TransformOutParameters.HighlightingParameters highlighting) { }
        public System.Windows.Controls.TextBlock GetCommentViewModel(string commentText, JetBrains.ReSharper.Refactorings.TransformOutParameters.HighlightingParameters highlighting) { }
        public virtual JetBrains.ReSharper.Psi.IMethod GetIMethodForOutParamByNode(JetBrains.ReSharper.Psi.Tree.ITreeNode findNodeAt) { }
        protected virtual string GetLineCommentPrefix() { }
        public virtual string GetRefactoringName() { }
        public virtual System.Collections.Generic.List<object> GetViewModel(JetBrains.ReSharper.Psi.IMethod method, JetBrains.ReSharper.Refactorings.TransformOutParameters.HighlightingParameters highlighting, System.Func<JetBrains.ReSharper.Psi.IParameter, object, object> parameterViewModelTransformer, bool isModelForTransformedMethod) { }
        public virtual System.Windows.Controls.TextBlock GetViewModel(JetBrains.ReSharper.Psi.IParameter param, JetBrains.ReSharper.Refactorings.TransformOutParameters.HighlightingParameters highlighting, string punctuationSuffix = null) { }
        public virtual System.Windows.UIElement GetViewModelAfterParameters(JetBrains.ReSharper.Psi.IMethod method, JetBrains.ReSharper.Refactorings.TransformOutParameters.HighlightingParameters highlighting) { }
        public virtual System.Windows.UIElement GetViewModelBeforeParameters(JetBrains.ReSharper.Psi.IMethod method, JetBrains.ReSharper.Refactorings.TransformOutParameters.HighlightingParameters highlighting) { }
        protected virtual System.Collections.Generic.IList<System.Windows.Documents.Run> HighlightType(JetBrains.ReSharper.Psi.IType type, JetBrains.ReSharper.Refactorings.TransformOutParameters.HighlightingParameters highlighting, JetBrains.ReSharper.Psi.PsiLanguageType language) { }
        public virtual bool IsOutParameter(JetBrains.ReSharper.Psi.IParameter parameter) { }
        public virtual void JoinDeclarationsAndAssignments(JetBrains.ReSharper.Psi.Tree.IDeclaration parametersOwnerDeclaration, System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.Tree.IStatement> statementsToUse, JetBrains.ReSharper.Refactorings.TransformOutParameters.TransformOutParametersRefactoring transformOutParametersRefactoring) { }
        public virtual void RefactoringPostVerificationStage(JetBrains.ReSharper.Psi.IMethod method, JetBrains.ReSharper.Refactorings.TransformOutParameters.TransformOutParametersRefactoring transformOutParametersRefactoring) { }
        protected System.Windows.Documents.Run Space() { }
        protected System.Windows.Controls.TextBlock SpaceBlock() { }
        public virtual void TransformDeclaration(JetBrains.ReSharper.Psi.IMethod method, JetBrains.ReSharper.Psi.Tree.IDeclaration declaration, JetBrains.ReSharper.Refactorings.TransformOutParameters.TransformOutParametersRefactoring refactoring) { }
        public virtual void TransformReference(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.IType initialReturnType, JetBrains.ReSharper.Refactorings.TransformOutParameters.TransformOutParametersRefactoring refactoring) { }
    }
    public class TransformOutParametersPage : System.Windows.Controls.UserControl, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage, System.Windows.Markup.IComponentConnector
    {
        public System.Windows.Controls.CheckBox AppendToExistingTuple;
        public System.Windows.Controls.ItemsControl methodAfterModificationControl;
        public System.Windows.Controls.CheckBox UseLambda;
        public TransformOutParametersPage(JetBrains.ReSharper.Refactorings.TransformOutParameters.TransformOutParametersWorkflow workflow) { }
        public bool AppendToTupleCheckBoxVisible { get; set; }
        public System.Windows.Media.Typeface CodeFontAttributes { get; }
        public double CodeFontSize { get; }
        public JetBrains.DataFlow.IProperty<bool> ContinueEnabled { get; }
        public string Description { get; }
        public bool DoNotShow { get; }
        public JetBrains.ReSharper.Refactorings.TransformOutParameters.HighlightingParameters Highlighting { get; }
        public System.Collections.Generic.List<object> MethodBeforeModificationControl { get; set; }
        public string Title { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.UI.CrossFramework.EitherControl View { get; }
        public JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage Commit(JetBrains.Application.Progress.IProgressIndicator pi) { }
        public bool Initialize(JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
        public void InitializeComponent() { }
        public bool RefreshContents(JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
    }
    public class TransformOutParametersRefactoring : JetBrains.ReSharper.Refactorings.Common.DrivenRefactoring<JetBrains.ReSharper.Refactorings.TransformOutParameters.TransformOutParametersWorkflow, JetBrains.ReSharper.Refactorings.Common.RefactoringExecBase<JetBrains.ReSharper.Refactorings.TransformOutParameters.TransformOutParametersWorkflow, JetBrains.ReSharper.Refactorings.TransformOutParameters.TransformOutParametersRefactoring>>
    {
        public TransformOutParametersRefactoring(JetBrains.ReSharper.Refactorings.TransformOutParameters.TransformOutParametersWorkflow workFlow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public JetBrains.Util.OneToSetMap<JetBrains.ReSharper.Psi.Tree.IDeclaration, JetBrains.ReSharper.Psi.Tree.IStatement> CreatedDeclarations { get; }
        public override bool Execute(JetBrains.Application.Progress.IProgressIndicator pi) { }
    }
    public class TransformOutParametersWorkflow : JetBrains.ReSharper.Refactorings.WorkflowNew.DrivenRefactoringWorkflow2<JetBrains.ReSharper.Refactorings.TransformOutParameters.TransformOutParametersHelper>
    {
        public const int MaxSupportedTupleArity = 7;
        public TransformOutParametersWorkflow(JetBrains.ProjectModel.ISolution solution, string actionId) { }
        public override JetBrains.ReSharper.Refactorings.Workflow.RefactoringActionGroup ActionGroup { get; }
        public bool AppendOutParamsToExistingTuple { get; set; }
        public bool CanSelectAllOutParameters { get; set; }
        public override JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage FirstPendingRefactoringPage { get; }
        public override bool HasUI { get; }
        public override string HelpKeyword { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Psi.IType InitialReturnType { get; }
        public int InitialReturnTypeArity { get; }
        public JetBrains.ReSharper.Psi.PsiLanguageType LanguageType { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Psi.IMethod Method { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ReSharper.Psi.Pointers.IDeclaredElementPointer<JetBrains.ReSharper.Psi.IMethod> MethodPointer { get; }
        public override bool MightModifyManyDocuments { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Psi.IType NewReturnType { get; }
        public int NewReturnTypeArity { get; }
        public System.Collections.Generic.SortedList<int, System.Func<JetBrains.ReSharper.Psi.IParameter>> OutParametesToRefactorPositions { get; }
        public override string Title { get; }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ReSharper.Psi.ITypeElement[] TupleGenericType { get; }
        public bool UseLambdasForComplexTransform { get; set; }
        protected override JetBrains.ReSharper.Refactorings.TransformOutParameters.TransformOutParametersHelper CreateHelper(JetBrains.ReSharper.Refactorings.IRefactoringLanguageService service) { }
        public override JetBrains.ReSharper.Refactorings.Workflow.IRefactoringExecuter CreateRefactoring(JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        [JetBrains.Annotations.PureAttribute()]
        public JetBrains.ReSharper.Psi.IType CreateTransformedReturnType([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.IMethod method, [JetBrains.Annotations.CanBeNullAttribute()] out string errmsg) { }
        protected override JetBrains.ReSharper.Refactorings.TransformOutParameters.TransformOutParametersHelper CreateUnsupportedHelper() { }
        public override bool Initialize(JetBrains.Application.DataContext.IDataContext context) { }
        public override bool IsAvailable(JetBrains.Application.DataContext.IDataContext context) { }
        public override bool PreExecute(JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
        public void SetHasUi(bool hasUi) { }
        public void SetOutParamsToRefactorPositions(int[] positions) { }
        public string UpdateProperties() { }
        public override bool Validate() { }
    }
}
namespace JetBrains.ReSharper.Refactorings.Unsupported
{
    
    public class Anonymous2DeclaredUnsupported : JetBrains.ReSharper.Refactorings.Anotype2DeclaredType.Anonymous2Declared
    {
        public Anonymous2DeclaredUnsupported(JetBrains.ReSharper.Refactorings.Anotype2DeclaredType.Anonymous2DeclaredWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public override void ChangeReference(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.IClass clsss, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution) { }
        public override JetBrains.ReSharper.Psi.IClass CreateClassDeclaration(System.Collections.Generic.IList<JetBrains.ReSharper.Psi.ITypeParameter> usedTypeParameters, ref JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution) { }
        public override System.Collections.Generic.IList<JetBrains.ReSharper.Psi.ITypeParameter> GetUsagedTypeParameters() { }
        public override System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Tree.ITreeNode> SearchForAnonymousTypes(JetBrains.Application.Progress.SubProgressIndicator pi) { }
    }
    public class ClassFromParametersUnsupported : JetBrains.ReSharper.Refactorings.ClassFromParameters.ClassFromParametersBase
    {
        public ClassFromParametersUnsupported(JetBrains.ReSharper.Refactorings.ClassFromParameters.ClassFromParametersWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public override void FixUsage(JetBrains.ReSharper.Refactorings.ClassFromParameters.PreProcessedCall call, string name) { }
        public override bool IsPureRecursiveCall(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.IOverridableMember calledMethod, JetBrains.ReSharper.Psi.ITypeElement typeElement) { }
        public override JetBrains.ReSharper.Refactorings.ClassFromParameters.PreProcessedCall PreProcessCall(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public override void Transform(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.IProperty property, JetBrains.ReSharper.Psi.IParameter parameter) { }
    }
    public class ConstraintSearcherUtilUnsupported : JetBrains.ReSharper.Refactorings.UseBaseType.ConstraintSearch.ConstraintSearcherUtil
    {
        public override JetBrains.ReSharper.Psi.Tree.ITreeNode GetDirectlyUsedElement(JetBrains.ReSharper.Psi.Tree.ITreeNode someElement) { }
        public override bool IsUnsupported() { }
        public override void ProcessUp(JetBrains.ReSharper.Psi.Tree.ITreeNode directlyUsedElement, JetBrains.ReSharper.Refactorings.UseBaseType.TypeUsageSearch.TypeElementUsage node) { }
        public override bool TryFindArgumentConstraint(JetBrains.ReSharper.Psi.Tree.ITreeNode preparedElement, out JetBrains.ReSharper.Psi.IParameter parameter) { }
        public override bool TryFindAssignmentConstraint(JetBrains.ReSharper.Psi.Tree.ITreeNode preparedElement, out JetBrains.ReSharper.Psi.IDeclaredElement assignmentDest) { }
        public override bool TryFindInitializerConstraint(JetBrains.ReSharper.Psi.Tree.ITreeNode preparedElement, out JetBrains.ReSharper.Psi.IDeclaredElement initializedElement) { }
        public override bool TryFindSimpleReturnConstraint(JetBrains.ReSharper.Psi.Tree.ITreeNode preparedElement, out JetBrains.ReSharper.Psi.ITypeMember returnFromMember) { }
        public override bool TryFindTypeMemberConstraint(JetBrains.ReSharper.Psi.Tree.ITreeNode preparedElement, out JetBrains.ReSharper.Psi.ITypeMember memberCalled, out JetBrains.ReSharper.Psi.Tree.ExpressionAccessType memberAccessType) { }
    }
    public class ConstructorToFactoryMethodUnsupported : JetBrains.ReSharper.Refactorings.Constructor2FactoryMethod.ConstructorToFactoryMethodBase
    {
        public ConstructorToFactoryMethodUnsupported(JetBrains.ReSharper.Refactorings.Constructor2FactoryMethod.Constructor2FactoryMethodWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public override void ConvertUsage(JetBrains.ReSharper.Psi.ITypeMember method, JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public override JetBrains.ReSharper.Psi.ITypeMember CreateFactoryMethodDeclaration(JetBrains.ReSharper.Psi.ITypeElement targetTypeElement, JetBrains.ReSharper.Psi.IConstructor constructorToCall, string factorymethodName) { }
        public override string GetModifiersString(JetBrains.ReSharper.Psi.IParameter x) { }
    }
    public class ExtractInterfaceUnsupported : JetBrains.ReSharper.Refactorings.Unsupported.MoveMembersUnsupportedBase<JetBrains.ReSharper.Refactorings.MoveMembers.ImplExtractInterface.IExtractInterfaceItemInfo>, JetBrains.ReSharper.Refactorings.IRefactoringExec, JetBrains.ReSharper.Refactorings.MoveMembers.Common.IMove<JetBrains.ReSharper.Refactorings.MoveMembers.ImplExtractInterface.IExtractInterfaceItemInfo>, JetBrains.ReSharper.Refactorings.MoveMembers.ImplExtractInterface.IExtractInterface
    {
        public ExtractInterfaceUnsupported(JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
    }
    public class ExtractSuperclassUnsupported : JetBrains.ReSharper.Refactorings.Unsupported.MoveMembersUnsupportedBase<JetBrains.ReSharper.Refactorings.MoveMembers.ImplExtractSuperclass.IExtractSuperclassItemInfo>, JetBrains.ReSharper.Refactorings.IRefactoringExec, JetBrains.ReSharper.Refactorings.MoveMembers.Common.IMove<JetBrains.ReSharper.Refactorings.MoveMembers.ImplExtractSuperclass.IExtractSuperclassItemInfo>, JetBrains.ReSharper.Refactorings.MoveMembers.ImplExtractSuperclass.IExtractSuperclass
    {
        public ExtractSuperclassUnsupported(JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
    }
    public class InlineClassUnsupported : JetBrains.ReSharper.Refactorings.InlineClass.InlineClassHelper
    {
        public override bool IsLanguageSupported { get; }
    }
    public class InlineFieldUnsupported : JetBrains.ReSharper.Refactorings.InlineField.InlineFieldBase
    {
        public InlineFieldUnsupported(JetBrains.ReSharper.Refactorings.InlineField.InlineFieldWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public override JetBrains.ReSharper.Refactorings.Inline.InlineHelper InlineHelper { get; }
        public override bool CanInlineReference(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public override bool GetCanUseRefOut(JetBrains.ReSharper.Psi.Tree.IExpression expression) { }
        public override JetBrains.ReSharper.Psi.Tree.ITreeNode GetContainingDeclarationBlock(JetBrains.ReSharper.Psi.Tree.IExpression expression) { }
        public override JetBrains.ReSharper.Psi.Tree.IExpression GetInitializerExpression(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public override JetBrains.ReSharper.Psi.Tree.IExpression GetInitializerExpression(JetBrains.ReSharper.Psi.IField field) { }
        public override void ProcessReferenceWithContext(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Refactorings.Inline.CallSiteContext context, JetBrains.ReSharper.Refactorings.Inline.InlinedCallInfo info) { }
        public override void RemoveAssgnment(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public override void RemoveField(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration) { }
        public override bool ThisIsUsed(JetBrains.ReSharper.Psi.Tree.IExpression expression) { }
    }
    public class InlineHelperUnsupported : JetBrains.ReSharper.Refactorings.Inline.InlineHelper
    {
        public InlineHelperUnsupported(JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Resolve.IReference> AllNotQualifiableReferences(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public override bool CanHaveSideEffects(JetBrains.ReSharper.Psi.Tree.IExpression expression) { }
        public override bool CanHaveSideEffects(JetBrains.ReSharper.Psi.Resolve.IReference reference, out JetBrains.ReSharper.Psi.Tree.IExpression qualifier, bool isStatic) { }
        public override bool CanHaveSideEffects(JetBrains.ReSharper.Psi.Tree.IArgument argument) { }
        public override System.Collections.Generic.Dictionary<int, JetBrains.ReSharper.Refactorings.Inline.InlinedArgumentInfo> GetArgument2Infos(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Refactorings.Inline.InlinedMethodInfo inlinedMethodInfo, System.Collections.Generic.Dictionary<JetBrains.ReSharper.Psi.IParameter, JetBrains.ReSharper.Refactorings.Inline.ArgUtil.ArgumentFromParameter> parameter2argument) { }
        public override JetBrains.ReSharper.Psi.Tree.IArgumentsOwner GetArgumentOwner(ref JetBrains.ReSharper.Psi.Resolve.IReference reference, bool replaceMethodGroup) { }
        public override JetBrains.ReSharper.Psi.Tree.ITreeNode GetContainingStatement(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public override System.Collections.Generic.Dictionary<JetBrains.ReSharper.Psi.IParameter, JetBrains.ReSharper.Refactorings.Inline.ArgUtil.ArgumentFromParameter> GetParameter2Argument(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.IParametersOwner param) { }
        public override void InsertReturnValueTempVariable(JetBrains.ReSharper.Refactorings.Inline.InlinedCallInfo inlinedCallInfo, JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Refactorings.Inline.CallSiteContext context) { }
        public override void InsertTempForArgument(JetBrains.ReSharper.Refactorings.Inline.InlinedParameterInfo parameterInfo, JetBrains.ReSharper.Refactorings.Inline.InlinedArgumentInfo argumentInfo, JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Refactorings.Inline.CallSiteContext context, JetBrains.ReSharper.Psi.ExtensionsAPI.ReferenceIdentitySaver saver) { }
        public override void InsertTempForQualifier(JetBrains.ReSharper.Refactorings.Inline.InlinedCallInfo inlinedCallInfo, JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Refactorings.Inline.CallSiteContext context, JetBrains.ReSharper.Psi.ExtensionsAPI.ReferenceIdentitySaver saver) { }
        public override void InsertTempVariableForAssignedValue(JetBrains.ReSharper.Refactorings.Inline.InlinedCallInfo inlinedCallInfo, JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Refactorings.Inline.CallSiteContext context) { }
        public override bool IsSourceOfAssignment(JetBrains.ReSharper.Psi.Resolve.IReference reference, out JetBrains.ReSharper.Psi.Tree.IExpression destination, JetBrains.ReSharper.Refactorings.Inline.InlinedCallKinds inlinedCallKinds) { }
        public override void RemoveCastFromElement(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public override void ReplaceTypeParameter(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.ITypeParameter parameter, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution) { }
    }
    public class InlineMethodUnsupported : JetBrains.ReSharper.Refactorings.Inline.InlineMethod
    {
        public InlineMethodUnsupported(JetBrains.ReSharper.Refactorings.Inline.InlineMethodWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public override JetBrains.ReSharper.Refactorings.Inline.InlineHelper InlineHelper { get; }
        public override bool AllReturnsAreLast(JetBrains.ReSharper.Psi.IDeclaredElement element) { }
        public override bool GetIsDestinationOfAssignment(JetBrains.ReSharper.Psi.Resolve.IReference reference, out JetBrains.ReSharper.Psi.Tree.IExpression expression) { }
        public override bool GetThisIsUsedOnce(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
        public override bool GetUsedAsDelegate(JetBrains.ReSharper.Refactorings.Inline.InlinedMethodInfo info, JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public override bool HasOneReferenceToValue(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
        public override bool IsFromStatement(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public override bool IsLastStatement(JetBrains.ReSharper.Psi.Resolve.IReference reference, out JetBrains.ReSharper.Psi.Tree.ITreeNode statement) { }
        public override bool IsReturned(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Refactorings.Inline.InlinedCallKinds inlinedCallKind) { }
        public override bool IsReturnStatementOnly(JetBrains.ReSharper.Psi.IDeclaredElement element, out JetBrains.ReSharper.Psi.Tree.IExpression returnedExpression, out JetBrains.ReSharper.Psi.Tree.ITreeNode blockOfStatements) { }
        public override bool ReplaceCall(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.Tree.IExpression returnedExpression, JetBrains.ReSharper.Refactorings.Inline.InlinedCallInfo inlinedCallInfo, JetBrains.ReSharper.Refactorings.Inline.CallSiteContext context) { }
        public override bool ReplaceStatement(ref JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.Tree.ITreeNode statements, JetBrains.ReSharper.Refactorings.Inline.InlinedCallInfo inlinedCallInfo, JetBrains.ReSharper.Refactorings.Inline.CallSiteContext context, bool replaceOriginal) { }
    }
    public class InlineParameterHelperUnsupported : JetBrains.ReSharper.Refactorings.InlineParameter.InlineParameterHelper
    {
        public override bool IsLanguageSupported { get; }
    }
    public class InlineParameterUnsupported : JetBrains.ReSharper.Refactorings.InlineParameter.InlineParameterBase
    {
        public InlineParameterUnsupported(JetBrains.ReSharper.Refactorings.InlineParameter.InlineParameterWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public override JetBrains.ReSharper.Refactorings.Inline.InlineHelper InlineHelper { get; }
    }
    public class InlineVarUnsupported : JetBrains.ReSharper.Refactorings.InlineVar.InlineVarBase
    {
        public InlineVarUnsupported(JetBrains.ReSharper.Refactorings.InlineVar.InlineVarWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public override JetBrains.ReSharper.Refactorings.Inline.InlineHelper InlineHelper { get; }
        public override void ProcessReferenceWithContext(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Refactorings.Inline.CallSiteContext context, JetBrains.ReSharper.Refactorings.Inline.InlinedCallInfo info) { }
        public override void RemoveAssignment(JetBrains.ReSharper.Psi.Tree.ITreeNode expression) { }
        public override void RemoveVariableDeclaration(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration) { }
    }
    public class IntroFieldUnsupported : JetBrains.ReSharper.Refactorings.IntroduceField.IntroFieldBase
    {
        public IntroFieldUnsupported(JetBrains.ReSharper.Refactorings.IntroduceField.IntroFieldWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public override void AddAssignment(JetBrains.ReSharper.Psi.IParameter variable, JetBrains.ReSharper.Psi.ITypeMember member, JetBrains.ReSharper.Psi.Tree.IExpression expression) { }
        public override JetBrains.ReSharper.Psi.ITypeMember AddField(JetBrains.ReSharper.Psi.Tree.ITypeDeclaration typeDeclaration, JetBrains.ReSharper.Psi.Tree.IExpression initExpression, System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Tree.ITreeNode> tags) { }
        public override bool ReplaceUsages(System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Tree.ITreeNode> expressions, JetBrains.ReSharper.Psi.ITypeMember field, JetBrains.ReSharper.Psi.Tree.ITreeNode initializer) { }
        public override bool ReplaceVariableDeclaration(JetBrains.ReSharper.Psi.ILocalVariable variable, JetBrains.ReSharper.Psi.ITypeMember field, JetBrains.ReSharper.Psi.Tree.IExpression initializer) { }
    }
    public class IntroParameterUnsupported : JetBrains.ReSharper.Refactorings.IntroduceParameter.IntroduceParameterBase
    {
        public IntroParameterUnsupported(JetBrains.ReSharper.Refactorings.IntroduceParameter.IntroduceParameterWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public override JetBrains.ReSharper.Refactorings.Inline.InlineHelper InlineHelper { get; }
        public override JetBrains.ReSharper.Psi.Resolve.IReference AddBaseClause(JetBrains.ReSharper.Psi.IDeclaredElement constructor) { }
        public override void AddParameter(JetBrains.ReSharper.Psi.IType type, string name, JetBrains.ReSharper.Psi.Tree.IDeclaration declaration, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution, JetBrains.ReSharper.Psi.Tree.ITreeNode defaultValue) { }
        public override void CallInline(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Refactorings.Inline.CallSiteContext context, JetBrains.ReSharper.Refactorings.Inline.InlinedCallInfo info, System.Collections.Generic.IList<string> lambdaParameterNames, int index) { }
        public override void FixOtherArguments(ref JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Refactorings.Inline.InlinedCallInfo info, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution) { }
        public override void RemoveLocalVariable(JetBrains.ReSharper.Psi.ILocalVariable variable) { }
        public override void ReplaceExpression(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
    }
    public class MakeStaticHelperUnsupported : JetBrains.ReSharper.Refactorings.ChangeStaticness.ToStatic.IMakeStaticHelper, JetBrains.ReSharper.Refactorings.IWorkflowExec
    {
        public bool IsLanguageSupported { get; }
        public bool CheckElement(JetBrains.ReSharper.Psi.IOverridableMember overridableMember) { }
        public JetBrains.ReSharper.Psi.Tree.ITreeNode GetInvocation(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public string GetTitle() { }
        public bool IsThis(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public bool IsWriting(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
    }
    public class MoveMembersHelperUnsupported<TMemberInfo> : JetBrains.ReSharper.Refactorings.MoveMembers.Common.MoveMembersHelper<TMemberInfo>
        where TMemberInfo : JetBrains.ReSharper.Refactorings.CommonUI.IMemberInfo
    {
        public MoveMembersHelperUnsupported(JetBrains.ReSharper.Refactorings.MoveMembers.Common.IMoveMembersExecuter executer, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver Driver { get; }
        public override void AddBaseInterface(JetBrains.ReSharper.Psi.ITypeElement element, JetBrains.ReSharper.Psi.IDeclaredType info) { }
        public override void AddImplementsSpecification(JetBrains.ReSharper.Psi.Tree.IDeclaration decl, JetBrains.ReSharper.Psi.ITypeElement element, bool nameIsItem, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public override void CheckConstructorReferenceConflict(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public override JetBrains.ReSharper.Psi.Tree.ITypeDeclaration CreateTargetTypeElement(string name, JetBrains.ReSharper.Psi.ITypeElement sourceClass, System.Collections.Generic.List<JetBrains.ReSharper.Psi.ITypeParameter> parameters, bool createClass, bool preserveAccessRigths) { }
        public override System.Collections.Generic.IList<JetBrains.Util.Pair<TMemberInfo, JetBrains.ReSharper.Psi.Tree.IDeclaration>> CutDeclarations(System.Collections.Generic.IEnumerable<TMemberInfo> memberInfos, JetBrains.Application.Progress.SubProgressIndicator pi) { }
        public override void GenerateConstructors(JetBrains.ReSharper.Psi.ITypeElement targetType, JetBrains.ReSharper.Psi.Tree.ITypeDeclaration typeDeclaration, JetBrains.ReSharper.Psi.Pointers.IDeclaredElementPointer<JetBrains.ReSharper.Psi.IConstructor> baseConstructor) { }
        public override JetBrains.ReSharper.Psi.IConstructor GetBaseConstructorDeclarationToInsert(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration) { }
        public override JetBrains.ReSharper.Psi.Tree.ITypeDeclaration InsertSibling(JetBrains.ReSharper.Psi.Tree.ITypeDeclaration decl, JetBrains.ReSharper.Psi.Tree.ITypeDeclaration sourceClass) { }
        public override JetBrains.ReSharper.Psi.Tree.ITypeDeclaration InsertToNewFile(JetBrains.ReSharper.Psi.Tree.ITypeDeclaration decl, JetBrains.ReSharper.Psi.Tree.ITypeDeclaration sourceClass, string ns, JetBrains.ProjectModel.IProjectFile fileNearby) { }
        public override bool IsQualifierValid(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public override void MakeOverride(JetBrains.ReSharper.Psi.ITypeMember member) { }
        public override void MakeProtected(JetBrains.ReSharper.Psi.IDeclaredElement element) { }
        public override void MakePublic(JetBrains.ReSharper.Psi.ITypeMember member) { }
        public override void MakeTypeElementAbstract(JetBrains.ReSharper.Psi.ITypeElement element) { }
        public override void PasteDeclarations(System.Collections.Generic.IList<JetBrains.Util.Pair<TMemberInfo, JetBrains.ReSharper.Psi.Tree.IDeclaration>> declarations, JetBrains.ReSharper.Psi.ITypeElement targetType, JetBrains.ProjectModel.IProjectFile projectFile, JetBrains.ReSharper.Psi.Tree.ITypeDeclaration targetTypeDeclaration, JetBrains.Application.Progress.SubProgressIndicator pi) { }
        public override void RemoveDeclaration(JetBrains.ReSharper.Psi.ITypeMember member) { }
        public override void RemoveSuperType(JetBrains.ReSharper.Psi.Tree.ITypeDeclaration typeDeclaration, JetBrains.ReSharper.Psi.IDeclaredType type) { }
        public override void SetSuperclass(JetBrains.ReSharper.Psi.Tree.ITypeDeclaration sourceClass, JetBrains.ReSharper.Psi.ITypeElement newSuper, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution) { }
        public override bool TryProcessMultyFieldForResolve(JetBrains.ReSharper.Psi.IRecursiveElementProcessor collector, JetBrains.ReSharper.Psi.Tree.IDeclaration declaration) { }
    }
    public abstract class MoveMembersUnsupportedBase<TMemberInfo> : JetBrains.ReSharper.Refactorings.IRefactoringExec, JetBrains.ReSharper.Refactorings.MoveMembers.Common.IMove<TMemberInfo>
        where TMemberInfo : JetBrains.ReSharper.Refactorings.CommonUI.IMemberInfo
    {
        public MoveMembersUnsupportedBase(JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver Driver { get; }
        public JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver RefactoringDriver { set; }
        public void AddImplementsSpecification(JetBrains.ReSharper.Psi.Tree.IDeclaration decl, JetBrains.ReSharper.Psi.ITypeElement element, bool name) { }
        public bool CheckConflictsWithTargetClassName(JetBrains.ReSharper.Psi.ITypeElement element, string name) { }
        public void GetBaseConstructorDeclarationToInsert(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration) { }
        public JetBrains.ReSharper.Refactorings.MoveMembers.Common.MoveMembersHelper<TMemberInfo> GetHelper() { }
        public bool IsInstanceSpecificEventAccess(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public void SetExecuter(JetBrains.ReSharper.Refactorings.Workflow.IRefactoringExecuter refactoring) { }
    }
    public class MoveStaticMembersUnsupported : JetBrains.ReSharper.Refactorings.MoveStaticMembers.MoveStaticMembers
    {
        public MoveStaticMembersUnsupported(JetBrains.ReSharper.Refactorings.MoveStaticMembers.MoveStaticMembersWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public override System.Collections.Generic.Dictionary<JetBrains.ReSharper.Psi.ITypeParameter, JetBrains.ReSharper.Psi.ITypeParameter> PasteDeclaration(JetBrains.ReSharper.Refactorings.MoveStaticMembers.Impl.TypeMemberCopy copy, out JetBrains.ReSharper.Psi.ITypeMember newTypeMember) { }
        public override void RemoveOldDeclaration(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration) { }
    }
    public class PullUpUnsupported : JetBrains.ReSharper.Refactorings.Unsupported.MoveMembersUnsupportedBase<JetBrains.ReSharper.Refactorings.MoveMembers.ImplPullUp.IPullUpItemInfo>, JetBrains.ReSharper.Refactorings.IRefactoringExec, JetBrains.ReSharper.Refactorings.MoveMembers.Common.IMove<JetBrains.ReSharper.Refactorings.MoveMembers.ImplPullUp.IPullUpItemInfo>, JetBrains.ReSharper.Refactorings.MoveMembers.ImplPullUp.IPullUp
    {
        public PullUpUnsupported(JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
    }
    public class PushDownUnsupported : JetBrains.ReSharper.Refactorings.Unsupported.MoveMembersUnsupportedBase<JetBrains.ReSharper.Refactorings.MoveMembers.ImplPushDown.IPushDownItemInfo>, JetBrains.ReSharper.Refactorings.IRefactoringExec, JetBrains.ReSharper.Refactorings.MoveMembers.Common.IMove<JetBrains.ReSharper.Refactorings.MoveMembers.ImplPushDown.IPushDownItemInfo>, JetBrains.ReSharper.Refactorings.MoveMembers.ImplPushDown.IPushDown
    {
        public PushDownUnsupported(JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
    }
    public class RenameUnsupported : JetBrains.ReSharper.Refactorings.RenameModel.RenameBase { }
    public class SafeDeleteUnsupported : JetBrains.ReSharper.Refactorings.SafeDeleteTheSecond.SafeDeleteBase
    {
        public SafeDeleteUnsupported(JetBrains.ReSharper.Refactorings.SafeDeleteTheSecond.SafeDeleteWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
    }
    public class Static2ExtensionUnsupported : JetBrains.ReSharper.Refactorings.Static2Extension.Static2ExtensionBase
    {
        public Static2ExtensionUnsupported(JetBrains.ReSharper.Refactorings.Static2Extension.Static2ExtensionWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public override void MakeCallExtension(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public override void MakeCallPlainStatic(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
    }
    public class UnsupportedTypeUsageSearcherUtil : JetBrains.ReSharper.Refactorings.UseBaseType.TypeUsageSearch.TypeUsageSearcherUtil
    {
        public override int GetArrayRank(JetBrains.ReSharper.Psi.Tree.ITreeNode typUsageElement) { }
        public override bool TryFindChilidTypeElement(JetBrains.ReSharper.Psi.Resolve.IReference reference, out JetBrains.ReSharper.Psi.ITypeElement childTypeElement) { }
        public override bool TryFindConstrainedParameter(JetBrains.ReSharper.Psi.Resolve.IReference reference, out JetBrains.ReSharper.Psi.ITypeParameter parameter) { }
        public override bool TryFindDelegateDeclaration(JetBrains.ReSharper.Psi.Resolve.IReference reference, out JetBrains.ReSharper.Psi.ITypeElement delegateElement) { }
        public override bool TryFindTypeParameterOwner(JetBrains.ReSharper.Psi.Resolve.IReference reference, out JetBrains.ReSharper.Psi.Tree.ITreeNode typeUsageElement, out JetBrains.ReSharper.Psi.ITypeParameter parameter) { }
    }
    public class UseBaseTypeUnsupported : JetBrains.ReSharper.Refactorings.UseBaseType.UseBaseTypeBase
    {
        public UseBaseTypeUnsupported(JetBrains.ReSharper.Refactorings.UseBaseType.UseBaseTypeWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public override bool MethodGroupTypeMatch { get; }
        public override JetBrains.ReSharper.Psi.Resolve.IReference BindUsage(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public override bool CheckConstraintElement(JetBrains.ReSharper.Psi.IDeclaredElement element) { }
        public override bool GetCastExpressionExpression(JetBrains.ReSharper.Psi.Resolve.IReference reference, out JetBrains.ReSharper.Psi.Tree.IExpression expression) { }
        public override JetBrains.ReSharper.Refactorings.UseBaseType.ConstraintSearch.ConstraintSearcherUtil GetConstraintSearcherUtil() { }
        public override bool GetConstructedExpression(JetBrains.ReSharper.Psi.Resolve.IReference reference, out JetBrains.ReSharper.Psi.Tree.IExpression expression) { }
        public override JetBrains.ReSharper.Psi.IDeclaredElement[] GetDeclaredElements(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public override JetBrains.ReSharper.Psi.IDeclaredElement GetDelegateDeclaration(JetBrains.ReSharper.Psi.Tree.ITreeNode directlyUsedElement) { }
        public override bool GetIsExpression(JetBrains.ReSharper.Psi.Resolve.IReference reference, out JetBrains.ReSharper.Psi.Tree.IExpression expression) { }
        public override bool GetTypeOfExpression(JetBrains.ReSharper.Psi.Resolve.IReference reference, out JetBrains.ReSharper.Psi.Tree.IExpression expression) { }
        public override JetBrains.ReSharper.Refactorings.UseBaseType.TypeUsageSearch.TypeUsageSearcherUtil GetTypeUsageSearcherUtil() { }
    }
}
namespace JetBrains.ReSharper.Refactorings.UseBaseType.ConstraintSearch
{
    
    public abstract class ConstraintBase
    {
        public virtual System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IDeclaredElement> ConstraintElements { get; }
        public abstract bool IsBlocker { get; }
    }
    public class ConstraintSearcher : JetBrains.ReSharper.Refactorings.Util.LanguageSpecificHelper<JetBrains.ReSharper.Refactorings.UseBaseType.ConstraintSearch.ConstraintSearcherUtil>
    {
        public ConstraintSearcher(JetBrains.ReSharper.Refactorings.UseBaseType.UseBaseTypeRefactoring refactoring, JetBrains.ReSharper.Refactorings.Util.LanguageSpecificUtilProvider<JetBrains.ReSharper.Refactorings.UseBaseType.ConstraintSearch.ConstraintSearcherUtil> utilProvider) { }
        public void AddInferBindedParameter(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Refactorings.UseBaseType.TypeUsageSearch.TypeElementUsage usage, int index, JetBrains.ReSharper.Psi.IMethod method, JetBrains.ReSharper.Psi.ITypeParameter typeParameter) { }
        public void AddMultiplexerConstraints() { }
        public JetBrains.ReSharper.Refactorings.UseBaseType.ConstraintSearch.ConstraintBase GetConstraints(JetBrains.ReSharper.Psi.Tree.ITreeNode directlyUsedElement, bool searchInvocations) { }
        public JetBrains.ReSharper.Psi.Tree.ITreeNode GetDirectlyUsedElement(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public JetBrains.ReSharper.Psi.Tree.ITreeNode GetDirectlyUsedElement(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public void ProcessUp(JetBrains.ReSharper.Psi.Tree.ITreeNode directlyUsedElement, JetBrains.ReSharper.Refactorings.UseBaseType.Dependences.Node node) { }
        public class InferBindedCall
        {
            public InferBindedCall(JetBrains.ReSharper.Psi.IMethod method, JetBrains.ReSharper.Refactorings.UseBaseType.ConstraintSearch.ConstraintSearcher searcher) { }
            public void AddConstraints() { }
            public void AddUsage(int index, JetBrains.ReSharper.Refactorings.UseBaseType.TypeUsageSearch.TypeElementUsage usage) { }
            public enum UsageType
            {
                Simple = 0,
                Generic = 1,
                None = 2,
            }
        }
    }
    public abstract class ConstraintSearcherUtil
    {
        public static JetBrains.ReSharper.Refactorings.UseBaseType.TypeUsageSearch.TypeElementUsage DecorateTypeUsage(JetBrains.ReSharper.Psi.IType returnType, JetBrains.ReSharper.Psi.ITypeParameter parameter, JetBrains.ReSharper.Refactorings.UseBaseType.TypeUsageSearch.TypeElementUsage usage) { }
        public static JetBrains.ReSharper.Refactorings.UseBaseType.TypeUsageSearch.TypeElementUsage FoldTypeUsage(JetBrains.ReSharper.Psi.IType returnType, JetBrains.ReSharper.Psi.IType usageType, JetBrains.ReSharper.Refactorings.UseBaseType.TypeUsageSearch.TypeElementUsage usage) { }
        public abstract JetBrains.ReSharper.Psi.Tree.ITreeNode GetDirectlyUsedElement(JetBrains.ReSharper.Psi.Tree.ITreeNode someElement);
        public virtual bool IsUnsupported() { }
        public abstract void ProcessUp(JetBrains.ReSharper.Psi.Tree.ITreeNode directlyUsedElement, JetBrains.ReSharper.Refactorings.UseBaseType.TypeUsageSearch.TypeElementUsage node);
        public abstract bool TryFindArgumentConstraint(JetBrains.ReSharper.Psi.Tree.ITreeNode preparedElement, out JetBrains.ReSharper.Psi.IParameter parameter);
        public abstract bool TryFindAssignmentConstraint(JetBrains.ReSharper.Psi.Tree.ITreeNode preparedElement, out JetBrains.ReSharper.Psi.IDeclaredElement assignmentDest);
        public virtual bool TryFindExtensionMethodConstraint(JetBrains.ReSharper.Psi.Tree.ITreeNode treeNode, out JetBrains.ReSharper.Psi.IParameter extensionParameter) { }
        public abstract bool TryFindInitializerConstraint(JetBrains.ReSharper.Psi.Tree.ITreeNode preparedElement, out JetBrains.ReSharper.Psi.IDeclaredElement initializedElement);
        public abstract bool TryFindSimpleReturnConstraint(JetBrains.ReSharper.Psi.Tree.ITreeNode preparedElement, out JetBrains.ReSharper.Psi.ITypeMember returnFromMember);
        public abstract bool TryFindTypeMemberConstraint(JetBrains.ReSharper.Psi.Tree.ITreeNode preparedElement, out JetBrains.ReSharper.Psi.ITypeMember memberCalled, out JetBrains.ReSharper.Psi.Tree.ExpressionAccessType memberAccessType);
        public static JetBrains.ReSharper.Refactorings.UseBaseType.TypeUsageSearch.TypeElementUsage WrapTypeUsage(JetBrains.ReSharper.Refactorings.UseBaseType.TypeUsageSearch.TypeElementUsage usage, JetBrains.ReSharper.Psi.IType parameterType) { }
    }
}
namespace JetBrains.ReSharper.Refactorings.UseBaseType.Dependences
{
    
    public class Edge : JetBrains.ReSharper.Refactorings.UseBaseType.GraphBase.IEdge<JetBrains.ReSharper.Refactorings.UseBaseType.Dependences.Node>
    {
        public Edge(JetBrains.ReSharper.Refactorings.UseBaseType.Dependences.Node start, JetBrains.ReSharper.Refactorings.UseBaseType.Dependences.Node end) { }
        public JetBrains.ReSharper.Refactorings.UseBaseType.Dependences.Node End { get; }
        public JetBrains.ReSharper.Refactorings.UseBaseType.Dependences.Node Start { get; }
    }
    public class Graph : JetBrains.ReSharper.Refactorings.UseBaseType.GraphBase.IDiGraph<JetBrains.ReSharper.Refactorings.UseBaseType.Dependences.Node, JetBrains.ReSharper.Refactorings.UseBaseType.Dependences.Edge>, JetBrains.Util.Graph.IDirectedGraph<JetBrains.ReSharper.Refactorings.UseBaseType.Dependences.Node>
    {
        public Graph() { }
        public int DeclaredElementsCount { get; }
        public System.Collections.Generic.Dictionary<JetBrains.ReSharper.Psi.IDeclaredElement, JetBrains.ReSharper.Refactorings.UseBaseType.Dependences.Node> DeclaredElementToNode { get; }
        public System.Collections.Generic.List<JetBrains.ReSharper.Refactorings.UseBaseType.Dependences.Edge> Edges { get; }
        public JetBrains.Util.OneToListMap<JetBrains.ReSharper.Refactorings.UseBaseType.Dependences.Node, JetBrains.ReSharper.Refactorings.UseBaseType.Dependences.Edge> Incoming { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Refactorings.UseBaseType.Dependences.Node> Nodes { get; }
        public JetBrains.Util.OneToListMap<JetBrains.ReSharper.Refactorings.UseBaseType.Dependences.Node, JetBrains.ReSharper.Refactorings.UseBaseType.Dependences.Edge> Outgoing { get; }
        public System.Collections.Generic.Dictionary<JetBrains.ReSharper.Refactorings.UseBaseType.TypeUsageSearch.TypeElementUsage, JetBrains.ReSharper.Refactorings.UseBaseType.Dependences.Node> ReferenceToNode { get; }
        public void AddCastNode(JetBrains.ReSharper.Refactorings.UseBaseType.TypeUsageSearch.TypeElementUsage usage, JetBrains.ReSharper.Psi.Tree.IExpression expression) { }
        public void AddCreationNode(JetBrains.ReSharper.Refactorings.UseBaseType.TypeUsageSearch.TypeElementUsage usage, JetBrains.ReSharper.Psi.Tree.IExpression expression) { }
        public JetBrains.ReSharper.Refactorings.UseBaseType.Dependences.Node AddNode(JetBrains.ReSharper.Refactorings.UseBaseType.TypeUsageSearch.TypeElementUsage usage, JetBrains.ReSharper.Psi.IDeclaredElement[] elements) { }
        public void AddTypeOfExpression(JetBrains.ReSharper.Refactorings.UseBaseType.TypeUsageSearch.TypeElementUsage usage, JetBrains.ReSharper.Psi.Tree.IExpression expression, bool mark) { }
        public void CreateEdge(JetBrains.ReSharper.Refactorings.UseBaseType.Dependences.Node start, JetBrains.ReSharper.Refactorings.UseBaseType.Dependences.Node end) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Refactorings.UseBaseType.Dependences.Edge> In(JetBrains.ReSharper.Refactorings.UseBaseType.Dependences.Node node) { }
        public bool IsMarked(JetBrains.ReSharper.Refactorings.UseBaseType.Dependences.Node node) { }
        public bool IsMarked(System.Collections.Generic.JetHashSet<JetBrains.ReSharper.Refactorings.UseBaseType.Dependences.Node> nodes) { }
        public void IterateDeclNodes(System.Action<JetBrains.ReSharper.Refactorings.UseBaseType.Dependences.Node, JetBrains.ReSharper.Psi.IDeclaredElement, JetBrains.Application.Progress.IProgressIndicator> action, JetBrains.Application.Progress.IProgressIndicator pi) { }
        public void IterateExprNodes(System.Action<JetBrains.ReSharper.Refactorings.UseBaseType.Dependences.Node, JetBrains.ReSharper.Psi.Tree.IExpression, JetBrains.Application.Progress.IProgressIndicator> action, JetBrains.Application.Progress.IProgressIndicator pi) { }
        public void Mark(JetBrains.ReSharper.Refactorings.UseBaseType.Dependences.Node node) { }
        public void Mark(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Refactorings.UseBaseType.Dependences.Node> set) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Refactorings.UseBaseType.Dependences.Edge> Out(JetBrains.ReSharper.Refactorings.UseBaseType.Dependences.Node node) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Refactorings.UseBaseType.Dependences.Node> Pred(JetBrains.ReSharper.Refactorings.UseBaseType.Dependences.Node node) { }
        public void PropagateMarkers() { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Refactorings.UseBaseType.Dependences.Node> Succ(JetBrains.ReSharper.Refactorings.UseBaseType.Dependences.Node node) { }
    }
    public class GraphBuilder
    {
        public GraphBuilder(JetBrains.ReSharper.Refactorings.UseBaseType.UseBaseTypeRefactoring refactoring) { }
        public JetBrains.ReSharper.Refactorings.UseBaseType.Dependences.Graph Graph { get; }
        public void AddComplexDependency(JetBrains.ReSharper.Psi.Tree.ITreeNode upElement, JetBrains.ReSharper.Refactorings.UseBaseType.TypeUsageSearch.TypeElementUsage usage) { }
        public JetBrains.ReSharper.Refactorings.UseBaseType.Dependences.Graph BuildGraph(JetBrains.Application.Progress.IProgressIndicator pi) { }
    }
    public class Node : JetBrains.ReSharper.Refactorings.UseBaseType.GraphBase.INode
    {
        public Node(JetBrains.ReSharper.Refactorings.UseBaseType.TypeUsageSearch.TypeElementUsage reference, JetBrains.ReSharper.Psi.IDeclaredElement[] elements) { }
        public Node(JetBrains.ReSharper.Refactorings.UseBaseType.TypeUsageSearch.TypeElementUsage reference, JetBrains.ReSharper.Psi.Tree.IExpression expression) { }
        public JetBrains.ReSharper.Psi.IDeclaredElement[] Elements { get; }
        public JetBrains.ReSharper.Psi.Tree.IExpression Expression { get; }
        public JetBrains.ReSharper.Refactorings.UseBaseType.TypeUsageSearch.TypeElementUsage TypeUsage { get; }
        public override string ToString() { }
    }
}
namespace JetBrains.ReSharper.Refactorings.UseBaseType.GraphBase
{
    
    public interface IDiGraph<NODE, EDGE> : JetBrains.Util.Graph.IDirectedGraph<NODE>
        where NODE : JetBrains.ReSharper.Refactorings.UseBaseType.GraphBase.INode
        where EDGE : JetBrains.ReSharper.Refactorings.UseBaseType.GraphBase.IEdge<>
    {
        System.Collections.Generic.List<EDGE> Edges { get; }
        JetBrains.Util.OneToListMap<NODE, EDGE> Incoming { get; }
        JetBrains.Util.OneToListMap<NODE, EDGE> Outgoing { get; }
    }
    public interface IEdge<NODE>
    
    {
        NODE End { get; }
        NODE Start { get; }
    }
    public interface INode { }
    public interface IScc<NODE, EDGE>
        where NODE : JetBrains.ReSharper.Refactorings.UseBaseType.GraphBase.INode
        where EDGE : JetBrains.ReSharper.Refactorings.UseBaseType.GraphBase.IEdge<> { }
    public class SCCBuilder<NODE, EDGE>
        where NODE : JetBrains.ReSharper.Refactorings.UseBaseType.GraphBase.INode
        where EDGE : JetBrains.ReSharper.Refactorings.UseBaseType.GraphBase.IEdge<>
    {
        public SCCBuilder(JetBrains.ReSharper.Refactorings.UseBaseType.GraphBase.IDiGraph<NODE, EDGE> graph) { }
        public JetBrains.ReSharper.Refactorings.UseBaseType.GraphBase.IScc<NODE, EDGE> BuildSCC() { }
    }
}
namespace JetBrains.ReSharper.Refactorings.UseBaseType
{
    
    public interface IUseBaseTypeDataProvider { }
    public interface IUseBaseTypeExecuter : JetBrains.ReSharper.Refactorings.Workflow.IRefactoringExecuter { }
    public interface IUseBaseTypeWorkflowProvider : JetBrains.ReSharper.Feature.Services.ActionsMenu.IWorkflowProvider<JetBrains.ReSharper.Refactorings.Workflow.IRefactoringWorkflow, JetBrains.ReSharper.Refactorings.Workflow.RefactoringActionGroup>, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringWorkflowProvider { }
    [JetBrains.ActionManagement.ActionHandlerAttribute(new string[] {
            "UseBaseTypeAction"})]
    public class UseBaseTypeAction : JetBrains.ReSharper.Refactorings.Workflow.ExtensibleRefactoringAction<JetBrains.ReSharper.Refactorings.UseBaseType.IUseBaseTypeWorkflowProvider>
    {
        public const string ACTION_ID = "UseBaseTypeAction";
        protected override JetBrains.UI.RichText.RichText Caption { get; }
    }
    public abstract class UseBaseTypeBase : JetBrains.ReSharper.Refactorings.Common.RefactoringExecBase<JetBrains.ReSharper.Refactorings.UseBaseType.UseBaseTypeWorkflow, JetBrains.ReSharper.Refactorings.UseBaseType.UseBaseTypeRefactoring>
    {
        protected UseBaseTypeBase(JetBrains.ReSharper.Refactorings.UseBaseType.UseBaseTypeWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public abstract bool MethodGroupTypeMatch { get; }
        public abstract JetBrains.ReSharper.Psi.Resolve.IReference BindUsage(JetBrains.ReSharper.Psi.Resolve.IReference reference);
        public abstract bool CheckConstraintElement(JetBrains.ReSharper.Psi.IDeclaredElement element);
        protected bool CheckConstraintElementCommon(JetBrains.ReSharper.Psi.IDeclaredElement element, JetBrains.ReSharper.Psi.PsiLanguageType language) { }
        public virtual void CreateAnonymousDelegateDependency(JetBrains.ReSharper.Psi.IParametersOwner owner, JetBrains.ReSharper.Refactorings.UseBaseType.Dependences.Node node, int index, out JetBrains.ReSharper.Psi.IParameter delegateParameter) { }
        protected static JetBrains.ReSharper.Psi.ITypeElement FindSupertypeContainingMember(JetBrains.ReSharper.Psi.ITypeMember testMember, JetBrains.ReSharper.Psi.ITypeElement desiredResult, JetBrains.ReSharper.Psi.Tree.ExpressionAccessType accessType) { }
        public abstract bool GetCastExpressionExpression(JetBrains.ReSharper.Psi.Resolve.IReference reference, out JetBrains.ReSharper.Psi.Tree.IExpression expression);
        public abstract JetBrains.ReSharper.Refactorings.UseBaseType.ConstraintSearch.ConstraintSearcherUtil GetConstraintSearcherUtil();
        public abstract bool GetConstructedExpression(JetBrains.ReSharper.Psi.Resolve.IReference reference, out JetBrains.ReSharper.Psi.Tree.IExpression expression);
        public abstract JetBrains.ReSharper.Psi.IDeclaredElement[] GetDeclaredElements(JetBrains.ReSharper.Psi.Resolve.IReference reference);
        public abstract JetBrains.ReSharper.Psi.IDeclaredElement GetDelegateDeclaration(JetBrains.ReSharper.Psi.Tree.ITreeNode directlyUsedElement);
        public abstract bool GetIsExpression(JetBrains.ReSharper.Psi.Resolve.IReference reference, out JetBrains.ReSharper.Psi.Tree.IExpression expression);
        public abstract bool GetTypeOfExpression(JetBrains.ReSharper.Psi.Resolve.IReference reference, out JetBrains.ReSharper.Psi.Tree.IExpression expression);
        public abstract JetBrains.ReSharper.Refactorings.UseBaseType.TypeUsageSearch.TypeUsageSearcherUtil GetTypeUsageSearcherUtil();
    }
    public class UseBaseTypeRefactoring : JetBrains.ReSharper.Refactorings.Common.DrivenRefactoring<JetBrains.ReSharper.Refactorings.UseBaseType.UseBaseTypeWorkflow, JetBrains.ReSharper.Refactorings.UseBaseType.UseBaseTypeBase>, JetBrains.ReSharper.Refactorings.UseBaseType.IUseBaseTypeExecuter, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringExecuter
    {
        public UseBaseTypeRefactoring(JetBrains.ReSharper.Refactorings.UseBaseType.UseBaseTypeWorkflow workflow, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public JetBrains.ReSharper.Refactorings.UseBaseType.Dependences.GraphBuilder Builder { get; }
        public JetBrains.ReSharper.Refactorings.UseBaseType.ConstraintSearch.ConstraintSearcher ConstraintSearcher { get; }
        public JetBrains.ReSharper.Psi.Search.IFinder Finder { get; }
        public JetBrains.ReSharper.Refactorings.UseBaseType.TypeUsageSearch.TypeUsageSearchResult FindResult { get; }
        public JetBrains.ReSharper.Psi.Resolve.ISubstitution Substitution { get; }
        public JetBrains.ReSharper.Psi.ITypeElement TargetTypeElement { get; }
        public JetBrains.ReSharper.Psi.ITypeElement TypeElement { get; }
        public bool CheckConstraintElement(JetBrains.ReSharper.Psi.IDeclaredElement element) { }
        public void CreateAnonymousDelegateDependency(JetBrains.ReSharper.Psi.IParametersOwner owner, JetBrains.ReSharper.Refactorings.UseBaseType.Dependences.Node node, int index, out JetBrains.ReSharper.Psi.IParameter delegateParameter) { }
        protected override JetBrains.ReSharper.Refactorings.UseBaseType.UseBaseTypeBase CreateRefactoringInternal(JetBrains.ReSharper.Refactorings.InternalRefactoringLanguageService service) { }
        protected override JetBrains.ReSharper.Refactorings.UseBaseType.UseBaseTypeBase CreateUnsupportedRefactoring() { }
        public override bool Execute(JetBrains.Application.Progress.IProgressIndicator pi) { }
        public JetBrains.ReSharper.Refactorings.UseBaseType.ConstraintSearch.ConstraintBase FindSimpleConstraint(JetBrains.ReSharper.Psi.Tree.ITreeNode directlyUsedElement, bool searchInvocationConstraints) { }
        public bool GetCastExpressionExpression(JetBrains.ReSharper.Psi.Resolve.IReference reference, out JetBrains.ReSharper.Psi.Tree.IExpression expression) { }
        public bool GetConstructedExpression(JetBrains.ReSharper.Psi.Resolve.IReference reference, out JetBrains.ReSharper.Psi.Tree.IExpression expression) { }
        public JetBrains.ReSharper.Psi.IDeclaredElement[] GetDeclaredElements(JetBrains.ReSharper.Psi.Resolve.IReference typeReference) { }
        public JetBrains.ReSharper.Psi.IDeclaredElement GetDelegateDeclaration(JetBrains.ReSharper.Psi.Tree.ITreeNode directlyUsedElement) { }
        public bool GetIsExpression(JetBrains.ReSharper.Psi.Resolve.IReference reference, out JetBrains.ReSharper.Psi.Tree.IExpression expression) { }
        public bool GetTypeOfExpression(JetBrains.ReSharper.Psi.Resolve.IReference reference, out JetBrains.ReSharper.Psi.Tree.IExpression expression) { }
    }
    public class UseBaseTypeTestDataProvider : JetBrains.ReSharper.Refactorings.UseBaseType.IUseBaseTypeDataProvider
    {
        public UseBaseTypeTestDataProvider(string baseTypeElementName, bool changeIs, bool changeInTypeof) { }
        public bool ChangeInTypeof { get; }
        public bool ChangeIs { get; }
        public JetBrains.ReSharper.Psi.ITypeElement SelectBaseTypeElement(System.Collections.Generic.IList<JetBrains.ReSharper.Psi.IDeclaredElement> list) { }
    }
    public class UseBaseTypeWorkflow : JetBrains.ReSharper.Refactorings.Workflow.DrivenRefactoringWorkflow, JetBrains.ReSharper.Refactorings.PostRename.PostRenameModel.IPostRenameProvider
    {
        public UseBaseTypeWorkflow(JetBrains.ProjectModel.ISolution solution, string actionId) { }
        public override JetBrains.ReSharper.Refactorings.Workflow.RefactoringActionGroup ActionGroup { get; }
        public JetBrains.ReSharper.Psi.ITypeElement BaseTypeElement { get; }
        public bool ChangeIs { get; set; }
        public bool ChangeTypeOf { get; set; }
        public JetBrains.ReSharper.Psi.ITypeElement Class { get; }
        public override JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage FirstPendingRefactoringPage { get; }
        public override string HelpKeyword { get; }
        public override bool MightModifyManyDocuments { get; }
        public string PostRenamePageTitle { get; }
        public override string Title { get; }
        public System.Collections.Generic.List<JetBrains.ReSharper.Psi.Resolve.IReference> UsagesOfType { set; }
        public JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage CommitDerivedRenames(JetBrains.ReSharper.Refactorings.PostRename.PostRenameModel.NameChanges change, JetBrains.Application.Progress.IProgressIndicator pi) { }
        public override JetBrains.ReSharper.Refactorings.Workflow.IRefactoringExecuter CreateRefactoring(JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Psi.IDeclaredElement> GetBaseTypeElements() { }
        public JetBrains.ReSharper.Refactorings.PostRename.PostRenameModel.NameChanges GetNameChanges() { }
        public override bool Initialize(JetBrains.Application.DataContext.IDataContext context) { }
        public override bool IsAvailable(JetBrains.Application.DataContext.IDataContext context) { }
        public override bool PostExecute(JetBrains.Application.Progress.IProgressIndicator pi) { }
        public override bool PreExecute(JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
        public void SetBaseTypeElement(JetBrains.ReSharper.Psi.ITypeElement element) { }
        public void SetMyDataProvider(JetBrains.ReSharper.Refactorings.UseBaseType.UseBaseTypeTestDataProvider value) { }
        public override bool Validate() { }
    }
}
namespace JetBrains.ReSharper.Refactorings.UseBaseType.TypeUsageSearch
{
    
    public abstract class TypeElementUsage : System.IEquatable<JetBrains.ReSharper.Refactorings.UseBaseType.TypeUsageSearch.TypeElementUsage>
    {
        protected TypeElementUsage(JetBrains.ReSharper.Psi.IType type, JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Refactorings.UseBaseType.TypeUsageSearch.TypeElementUsageKinds kind, JetBrains.ReSharper.Refactorings.UseBaseType.TypeUsageSearch.TypeElementUsage parent) { }
        public bool CanHaveInvocationConstraint { get; }
        public bool HasSuperUsage { get; set; }
        public JetBrains.ReSharper.Refactorings.UseBaseType.TypeUsageSearch.TypeElementUsageKinds Kind { get; }
        public virtual JetBrains.ReSharper.Psi.ITypeParameter Parameter { get; }
        public JetBrains.ReSharper.Refactorings.UseBaseType.TypeUsageSearch.TypeElementUsage Parent { get; }
        public JetBrains.ReSharper.Psi.Resolve.IReference Reference { get; }
        public JetBrains.ReSharper.Psi.IType Type { get; }
        public void AddNode(JetBrains.ReSharper.Refactorings.UseBaseType.Dependences.Node node) { }
        public void AddNodes(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Refactorings.UseBaseType.Dependences.Node> nodes) { }
        public System.Collections.Generic.JetHashSet<JetBrains.ReSharper.Refactorings.UseBaseType.Dependences.Node> AllNodes() { }
        public static JetBrains.ReSharper.Refactorings.UseBaseType.TypeUsageSearch.TypeElementUsage CreateCodeBased(JetBrains.ReSharper.Psi.IType type, JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Refactorings.UseBaseType.TypeUsageSearch.TypeElementUsage baseUsage, JetBrains.ReSharper.Refactorings.UseBaseType.TypeUsageSearch.TypeElementUsageKinds kind) { }
        public static JetBrains.ReSharper.Refactorings.UseBaseType.TypeUsageSearch.TypeElementUsage CreateFake(JetBrains.ReSharper.Psi.IType type, JetBrains.ReSharper.Refactorings.UseBaseType.TypeUsageSearch.TypeElementUsage baseUsage, JetBrains.ReSharper.Refactorings.UseBaseType.TypeUsageSearch.TypeElementUsageKinds kind) { }
        public static JetBrains.ReSharper.Refactorings.UseBaseType.TypeUsageSearch.TypeElementUsage CreateGenericBasedUsage(JetBrains.ReSharper.Psi.IType type, JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Refactorings.UseBaseType.TypeUsageSearch.TypeElementUsage baseUsage, JetBrains.ReSharper.Psi.ITypeParameter prameter) { }
        public static JetBrains.ReSharper.Refactorings.UseBaseType.TypeUsageSearch.TypeElementUsage CreateOrigianl(JetBrains.ReSharper.Psi.IType element, JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public bool Equals(JetBrains.ReSharper.Refactorings.UseBaseType.TypeUsageSearch.TypeElementUsage typeElementUsage) { }
        public override bool Equals(object obj) { }
        public JetBrains.ReSharper.Refactorings.UseBaseType.TypeUsageSearch.TypeElementUsage GetBaseUsage() { }
        public override int GetHashCode() { }
    }
    public enum TypeElementUsageKinds
    {
        Original = 0,
        Delegate = 1,
        TypeParameter = 2,
        BaseType = 3,
        ConstrainedParameter = 4,
        Array = 5,
    }
    public class TypeUsageSearcher : JetBrains.ReSharper.Refactorings.Util.LanguageSpecificHelper<JetBrains.ReSharper.Refactorings.UseBaseType.TypeUsageSearch.TypeUsageSearcherUtil>
    {
        public TypeUsageSearcher(JetBrains.ReSharper.Psi.ITypeElement typeElement, JetBrains.ReSharper.Refactorings.Util.LanguageSpecificUtilProvider<JetBrains.ReSharper.Refactorings.UseBaseType.TypeUsageSearch.TypeUsageSearcherUtil> utilProvider) { }
        public JetBrains.ReSharper.Refactorings.UseBaseType.TypeUsageSearch.TypeUsageSearchResult Find(JetBrains.Application.Progress.IProgressIndicator pi) { }
    }
    public abstract class TypeUsageSearcherUtil
    {
        public abstract int GetArrayRank(JetBrains.ReSharper.Psi.Tree.ITreeNode typUsageElement);
        public abstract bool TryFindChilidTypeElement(JetBrains.ReSharper.Psi.Resolve.IReference reference, out JetBrains.ReSharper.Psi.ITypeElement childTypeElement);
        public abstract bool TryFindConstrainedParameter(JetBrains.ReSharper.Psi.Resolve.IReference reference, out JetBrains.ReSharper.Psi.ITypeParameter parameter);
        public abstract bool TryFindDelegateDeclaration(JetBrains.ReSharper.Psi.Resolve.IReference reference, out JetBrains.ReSharper.Psi.ITypeElement delegateElement);
        public abstract bool TryFindTypeParameterOwner(JetBrains.ReSharper.Psi.Resolve.IReference reference, out JetBrains.ReSharper.Psi.Tree.ITreeNode typeUsageElement, out JetBrains.ReSharper.Psi.ITypeParameter parameter);
    }
    public class TypeUsageSearchResult
    {
        public TypeUsageSearchResult() { }
        public System.Collections.Generic.JetHashSet<JetBrains.ReSharper.Psi.ITypeElement> ProcessedElementsUsage { get; }
        public System.Collections.Generic.List<JetBrains.ReSharper.Refactorings.UseBaseType.TypeUsageSearch.TypeElementUsage> TypeUsages { get; }
    }
}
namespace JetBrains.ReSharper.Refactorings.UseBaseType.UI
{
    
    public class BaseTypeTree : JetBrains.UI.AbstractTreeBuilder.IAbstractTreeStructure, JetBrains.UI.AbstractTreeBuilder.ITreeStructurePresenter
    {
        public BaseTypeTree(System.Collections.Generic.IList<JetBrains.ReSharper.Psi.IDeclaredElement> allTypes) { }
        public bool AutoExpandSingleChild { get; }
        public object Root { get; }
        public bool AreChildrenEquivalent(object child1, object child2) { }
        public bool CanHaveChildren(object item) { }
        public void DisposeNode(JetBrains.UI.AbstractTreeBuilder.IAbstractTreeNode node, object item) { }
        public int GetChildEquivalenceHashCode(object child) { }
        public System.Collections.IEnumerable GetChildren(object item) { }
        public bool IsInitiallyExpanded(object item) { }
        public object RestoreItem(object o) { }
        public object SaveItem(object item) { }
        public void UpdateNode(JetBrains.UI.AbstractTreeBuilder.IAbstractTreeNode node, object item) { }
    }
    public class UseBaseTypeMainWindow : JetBrains.UI.CommonControls.SafeUserControl, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage
    {
        public UseBaseTypeMainWindow(JetBrains.ReSharper.Refactorings.UseBaseType.UseBaseTypeWorkflow workflow) { }
        public JetBrains.DataFlow.IProperty<bool> ContinueEnabled { get; }
        public string Description { get; }
        public bool DoNotShow { get; }
        public string Title { get; }
        public JetBrains.UI.CrossFramework.EitherControl View { get; }
        public JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage Commit(JetBrains.Application.Progress.IProgressIndicator pi) { }
        protected override void Dispose(bool disposing) { }
        public bool Initialize(JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
        public bool RefreshContents(JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
    }
}
namespace JetBrains.ReSharper.Refactorings.Util
{
    
    public abstract class AccessRightsChecker
    {
        protected abstract JetBrains.ReSharper.Psi.Resolve.IAccessContext BuildAccessContext(out JetBrains.ReSharper.Psi.ITypeMember accessedElement, out JetBrains.ReSharper.Psi.AccessRights accessRights);
        public bool IsSymbolAccessible(JetBrains.ReSharper.Psi.IPsiServices psiServices) { }
    }
    public class ClassesHiddenByNewClassFixer
    {
        public ClassesHiddenByNewClassFixer(JetBrains.ReSharper.Psi.IPsiServices psiServices, JetBrains.ReSharper.Psi.ClrTypeName newClassName, JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext resolveContext) { }
        public void RebindAllReferences(JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
        public void SearchTypesAndReferences(JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
    }
    public class ConstructionUtil
    {
        public virtual JetBrains.ReSharper.Psi.ITypeElement AddClassBefore(string className, JetBrains.ReSharper.Psi.Tree.IDeclaration tag, bool topLevel, bool isClass) { }
        public virtual JetBrains.ReSharper.Psi.ITypeElement AddClassBeforeFromMember(string className, JetBrains.ReSharper.Psi.ITypeMember tag, bool topLevel, bool isClass) { }
        public virtual JetBrains.ReSharper.Psi.Tree.IDeclaration AddEmptyConstructor(JetBrains.ReSharper.Psi.ITypeElement @class, JetBrains.ReSharper.Psi.Tree.IDeclaration tag) { }
        public virtual JetBrains.ReSharper.Psi.Tree.IDeclaration AddField(JetBrains.ReSharper.Psi.ITypeElement @class, JetBrains.ReSharper.Psi.Naming.Impl.NameRoot name, JetBrains.ReSharper.Psi.IType type, JetBrains.ReSharper.Psi.Tree.IDeclaration tag, JetBrains.ReSharper.Psi.AccessRights accessRights, System.Collections.Generic.JetHashSet<string> namesSet) { }
        public virtual JetBrains.ReSharper.Psi.IParameter AddFirstParameter(JetBrains.ReSharper.Psi.IParametersOwner owner, string name, JetBrains.ReSharper.Psi.IDeclaredType type) { }
        public virtual JetBrains.ReSharper.Psi.IParameter AddLastParameter(JetBrains.ReSharper.Psi.IParametersOwner owner, string name, JetBrains.ReSharper.Psi.IDeclaredType type) { }
        public virtual JetBrains.ReSharper.Psi.Tree.IDeclaration AddProperty(JetBrains.ReSharper.Psi.ITypeElement @class, JetBrains.ReSharper.Psi.Tree.IDeclaration fieldDeclaration, JetBrains.ReSharper.Psi.Naming.Impl.NameRoot basicName, JetBrains.ReSharper.Psi.Tree.IDeclaration tag, bool isWritable, JetBrains.ReSharper.Psi.AccessRights accessRights, System.Collections.Generic.JetHashSet<string> namesSet) { }
        protected virtual void AddToCollection(System.Collections.Generic.JetHashSet<string> namesSet, string fieldName) { }
        public virtual JetBrains.ReSharper.Psi.ITypeMember AddTypeMemberDeclaration(JetBrains.ReSharper.Psi.ITypeElement element, JetBrains.ReSharper.Psi.Tree.IDeclaration declaration, JetBrains.ReSharper.Psi.Tree.IDeclaration tag, bool after) { }
        public virtual JetBrains.ReSharper.Psi.Tree.IDeclaration AddTypeParameter(JetBrains.ReSharper.Psi.ITypeElement @class, string name, JetBrains.ReSharper.Psi.ITypeParameter originalTypeParameter) { }
        public virtual JetBrains.ReSharper.Psi.ITypeParameter AddTypeParameter(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration, string shortname) { }
        public static JetBrains.ReSharper.Refactorings.Util.ConstructionUtil Get(JetBrains.ReSharper.Psi.PsiLanguageType languageType) { }
        public static JetBrains.ReSharper.Refactorings.Util.ConstructionUtil GetInstance(JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public string GetUniqueName(JetBrains.ReSharper.Psi.Naming.Impl.NameRoot root, JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Psi.PsiLanguageType language, System.Collections.Generic.JetHashSet<string> namesSet, JetBrains.ReSharper.Psi.Naming.Settings.NamedElementKinds kind, JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile) { }
        public virtual void InitFieldInConstructor(JetBrains.ReSharper.Psi.Tree.IDeclaration constructorDecl, JetBrains.ReSharper.Psi.Tree.IDeclaration field, JetBrains.ReSharper.Psi.IParameter name) { }
        protected virtual bool IsInCollection(System.Collections.Generic.JetHashSet<string> namesSet, string fieldName) { }
        public virtual void MakeFirstPrameterThis(JetBrains.ReSharper.Psi.IMethod method, bool addThis, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver Driver) { }
        public virtual void RemoveParameter(JetBrains.ReSharper.Psi.IParametersOwner owner, JetBrains.ReSharper.Psi.IParameter parameter) { }
        public virtual void RemoveTypeMember(JetBrains.ReSharper.Psi.Tree.ITypeMemberDeclaration member) { }
        public virtual void SetAccessRights(JetBrains.ReSharper.Psi.IDeclaredElement owner, JetBrains.ReSharper.Psi.AccessRights rights) { }
        public virtual bool TryProcessMultyFieldForResolve(JetBrains.ReSharper.Psi.IRecursiveElementProcessor processor, JetBrains.ReSharper.Psi.Tree.IDeclaration declaration) { }
    }
    public class CSharpLikeLanguagesUtil
    {
        public static JetBrains.ReSharper.Psi.Tree.INamespaceDeclaration GetNamespaceDeclaration(JetBrains.ReSharper.Psi.Tree.ITypeAndNamespaceHolderDeclaration typeAndNamespaceHolder, string searchedName) { }
    }
    public class static DependencyUtil
    {
        public static JetBrains.ReSharper.Refactorings.Util.DependencyUtil.DependencyResult AnalyzeDependencies(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public static JetBrains.ReSharper.Psi.ITypeMember[] GetDependentTypeMembers(JetBrains.ReSharper.Psi.ITypeMember typeMember) { }
        public class DependencyResult
        {
            public DependencyResult(bool usesLocalContext, bool usesStaticMembers, bool usesThis, bool usesBase) { }
            public bool UsesBaseObject { get; }
            public bool UsesLocalContext { get; }
            public bool UsesStaticMembers { get; }
            public bool UsesThisObject { get; }
        }
    }
    public sealed class DocumentCollectionUtil
    {
        public sealed class Documents
        {
            public Documents() { }
            public void AddDeclaredElement(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
            public void AddDeclaredElements(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IDeclaredElement> declaredElements) { }
            public void AddDocument(JetBrains.DocumentModel.IDocument document) { }
            public void AddElement(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
            public void AddElements(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Tree.ITreeNode> elements) { }
            public void AddReference(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
            public void AddReferences(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Resolve.IReference> references) { }
            public JetBrains.DocumentModel.IDocument[] GetDocuments() { }
        }
    }
    public interface ILanguageSpecificProjectFileHandler
    {
        void InitializeEmptyFile(JetBrains.ReSharper.Psi.Tree.IFile file);
    }
    public interface InstanceObjectUsageChecker
    {
        JetBrains.ReSharper.Refactorings.Util.InstanceObjectUsageResult GetCheckResult(JetBrains.ReSharper.Psi.Tree.ITreeNode element);
    }
    public interface InstanceObjectUsageResult
    {
        bool UsesBaseObject { get; }
        bool UsesThisObject { get; }
    }
    public class static IntroduceUtil
    {
        public static System.Collections.Generic.List<JetBrains.ReSharper.Psi.Tree.ITreeNode> FindOccurrences(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.Tree.ITreeNode scope, System.Func<JetBrains.ReSharper.Psi.Tree.ITreeNode, bool> filter) { }
        public static JetBrains.ReSharper.Psi.Tree.ITreeNode GetContainingLambda(JetBrains.ReSharper.Psi.Tree.ITreeNode expression) { }
    }
    public interface IRefactoringStage
    {
        bool IsValid { get; }
        JetBrains.ReSharper.Refactorings.Util.IRefactoringStage PreviousStage { get; }
        JetBrains.ReSharper.Refactorings.Util.IRefactoringStage Clone(JetBrains.Application.Progress.IProgressIndicator progressIndicator);
        bool Initialize(JetBrains.Application.Progress.IProgressIndicator progressIndicator);
    }
    public class LanguageSpecificHelper<LANGUAGE_HELPER>
    
    {
        public LanguageSpecificHelper(JetBrains.ReSharper.Refactorings.Util.LanguageSpecificUtilProvider<LANGUAGE_HELPER> utilProvider) { }
        protected LANGUAGE_HELPER this[JetBrains.ReSharper.Psi.PsiLanguageType language] { get; }
    }
    public delegate T LanguageSpecificUtilProvider<T>(JetBrains.ReSharper.Psi.PsiLanguageType language);
    public class MovedElementsCollector : JetBrains.ReSharper.Psi.IRecursiveElementProcessor
    {
        public MovedElementsCollector() { }
        public bool ProcessingIsFinished { get; }
        public bool Contains(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
        public bool InteriorShouldBeProcessed(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public void ProcessAfterInterior(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public void ProcessBeforeInterior(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public void ProcessDeclaredElement(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
    }
    public class MultyPsiDeclarations
    {
        public MultyPsiDeclarations(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Tree.IDeclaration> AllDeclarations { get; }
        public System.Collections.Generic.List<JetBrains.ReSharper.Psi.Tree.IDeclaration> PrimaryDeclarations { get; }
        public System.Collections.Generic.List<JetBrains.ReSharper.Psi.Tree.IDeclaration> SecondaryDeclarations { get; }
    }
    public class static MultyPsiUtil
    {
        public static System.Collections.Generic.List<JetBrains.Util.Pair<JetBrains.ReSharper.Psi.Tree.IDeclaration, System.Collections.Generic.List<JetBrains.ReSharper.Psi.Tree.IDeclaration>>> GetDeclarationGroups(JetBrains.ReSharper.Psi.IDeclaredElement element) { }
    }
    public class static PsiUtil
    {
        public static bool CanChange<T>(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement)
            where T :  class, JetBrains.ReSharper.Refactorings.ILanguageSpecificRefactoringService { }
        public static T ChooseDeclaration<T>(T defaultDeclaration)
            where T :  class, JetBrains.ReSharper.Psi.Tree.ITypeDeclaration { }
        public static bool Contains<T>(JetBrains.ReSharper.Psi.Tree.ITreeNode element)
            where T :  class, JetBrains.ReSharper.Psi.Tree.ITreeNode { }
        public static bool Contains<T>(JetBrains.ReSharper.Psi.ITreeRange range)
            where T :  class, JetBrains.ReSharper.Psi.Tree.ITreeNode { }
        public static System.Collections.Generic.ICollection<T> FindAll<T>(JetBrains.ReSharper.Psi.Tree.ITreeNode element)
            where T :  class, JetBrains.ReSharper.Psi.Tree.ITreeNode { }
        public static System.Collections.Generic.ICollection<T> FindAll<T>(JetBrains.ReSharper.Psi.ITreeRange range)
            where T :  class, JetBrains.ReSharper.Psi.Tree.ITreeNode { }
        public static System.Collections.Generic.IEnumerable<T> GetElements<T>(JetBrains.ReSharper.Psi.Tree.ITreeNode element)
            where T :  class, JetBrains.ReSharper.Psi.Tree.ITreeNode { }
        public static System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Tree.ITreeNode> GetElements(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public static System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Resolve.IReference> GetNonQualifiedReferences(JetBrains.ReSharper.Psi.ITreeRange treeRange) { }
        public static System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Resolve.IReference> GetNonQualifiedReferences(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public static System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Resolve.IReference> GetReferences(JetBrains.ReSharper.Psi.ITreeRange treeRange) { }
        public static System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Resolve.IReference> GetReferences(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public static bool IsUnderTypeDeclaration(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.ITypeElement containingType) { }
    }
    public struct QName
    {
        public QName([JetBrains.Annotations.NotNullAttribute()] string @string, System.StringComparison comparison) { }
        [JetBrains.Annotations.PureAttribute()]
        public JetBrains.ReSharper.Refactorings.Util.QName Append(JetBrains.ReSharper.Refactorings.Util.QName other) { }
        [JetBrains.Annotations.PureAttribute()]
        public JetBrains.ReSharper.Refactorings.Util.QName ChopPostfix(JetBrains.ReSharper.Refactorings.Util.QName other) { }
        [JetBrains.Annotations.PureAttribute()]
        public JetBrains.ReSharper.Refactorings.Util.QName ChopPrefix(JetBrains.ReSharper.Refactorings.Util.QName other) { }
        public override bool Equals(object obj) { }
        public bool Equals(JetBrains.ReSharper.Refactorings.Util.QName name) { }
        public override int GetHashCode() { }
        [JetBrains.Annotations.PureAttribute()]
        public bool HasPostfix(JetBrains.ReSharper.Refactorings.Util.QName other) { }
        [JetBrains.Annotations.PureAttribute()]
        public bool HasPrefix(JetBrains.ReSharper.Refactorings.Util.QName other) { }
        [JetBrains.Annotations.PureAttribute()]
        public override string ToString() { }
    }
    public class ReferenceBinding
    {
        public ReferenceBinding(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution) { }
        public ReferenceBinding(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Psi.IDeclaredElement DeclaredElement { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ReSharper.Psi.Resolve.IReference Reference { get; }
        public bool IsValid() { }
        public void Rebind() { }
        public bool ResolvesCorrectly() { }
    }
    public class static ReferenceCollectorUtil
    {
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Collections.Generic.IList<T> Process<T>([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode element)
            where T :  class, JetBrains.ReSharper.Psi.Resolve.IReference { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Resolve.IReference> Process([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
    }
    public delegate int ReferenceComparatorDelegate(JetBrains.ReSharper.Psi.Resolve.IReference ref1, JetBrains.ReSharper.Psi.Resolve.IReference ref2, JetBrains.Util.OneToListMap<JetBrains.ReSharper.Psi.Tree.ITreeNode, JetBrains.ReSharper.Psi.Resolve.IReference> references);
    public class ReferencedElementsCollector : JetBrains.ReSharper.Psi.IRecursiveElementProcessor
    {
        public ReferencedElementsCollector(bool onlyNonQualified) { }
        public bool ProcessingIsFinished { get; }
        public JetBrains.ReSharper.Psi.IDeclaredElement[] ReferencedElements { get; }
        public bool InteriorShouldBeProcessed(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public void ProcessAfterInterior(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public void ProcessBeforeInterior(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
    }
    public class static ReferenceOwnerSorter
    {
        public static System.Collections.Generic.List<T> Sort<T>(System.Collections.Generic.IEnumerable<T> references, System.Func<T, JetBrains.ReSharper.Psi.Resolve.IReference> getReference, JetBrains.ReSharper.Psi.PsiLanguageType language) { }
    }
    public class ReferenceOwnerSorterUtil<T>
    
    {
        public ReferenceOwnerSorterUtil(System.Collections.Generic.IEnumerable<T> references, System.Func<T, JetBrains.ReSharper.Psi.Resolve.IReference> getReference, JetBrains.ReSharper.Refactorings.Util.ReferenceComparatorDelegate comparator) { }
        public System.Collections.Generic.List<T> Sort() { }
    }
    public class ReferenceSorter
    {
        public ReferenceSorter(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Resolve.IReference> references, JetBrains.ReSharper.Refactorings.Util.ReferenceComparatorDelegate comparator) { }
        public System.Collections.Generic.List<JetBrains.ReSharper.Psi.Resolve.IReference> Sort() { }
    }
    public class static ReferenceUpdateUtil
    {
        public static void UpdateReferences(JetBrains.ReSharper.Psi.ExtensionsAPI.ReferenceIdentitySaver saver, JetBrains.ReSharper.Refactorings.MoveMembers.Common.IImageCollector executer, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.ITypeElement targetTypeElement, JetBrains.Application.Progress.IProgressIndicator pi) { }
    }
    public abstract class StagedRefactoringBase
    {
        protected StagedRefactoringBase(JetBrains.ProjectModel.ISolution solution) { }
        public T FindStage<T>()
            where T :  class, JetBrains.ReSharper.Refactorings.Util.IRefactoringStage { }
        public JetBrains.ReSharper.Refactorings.Util.IRefactoringStage GetCurrentStage() { }
        public bool SetCurrentStage(JetBrains.ReSharper.Refactorings.Util.IRefactoringStage stage, JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
    }
    public class static SuperTypesUtil
    {
        public static void ProcessClassAndSuperClasses(JetBrains.ReSharper.Psi.IClass @class, System.Action<JetBrains.ReSharper.Psi.IClass> handle) { }
        public static void ProcessTypeAndBaseClassesAndInterfaces(JetBrains.ReSharper.Psi.ITypeElement typeElement, JetBrains.ReSharper.Refactorings.Util.TypeElementHandler handle) { }
        public static void ProcessTypeAndSuperTypes(JetBrains.ReSharper.Psi.ITypeElement typeElement, JetBrains.ReSharper.Refactorings.Util.TypeElementHandler handle) { }
    }
    public delegate void TypeElementHandler(JetBrains.ReSharper.Psi.ITypeElement superClass);
    public class VisibilityUtil
    {
        public static bool TargetTypeAccessible(JetBrains.ReSharper.Psi.Tree.ITreeNode accessPoint, JetBrains.ReSharper.Psi.ITypeElement targetType) { }
    }
}
namespace JetBrains.ReSharper.Refactorings.Util.Binding
{
    
    public class static RefactoringsBindingUtil
    {
        public static JetBrains.ReSharper.Psi.Resolve.IReference BindWithCleanup(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.DeclaredElementInstance elementInstance, System.Func<JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.ReSharper.Psi.Resolve.IReference> tryRemoveQualification) { }
        public static bool CheckResolvedTo(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.IDeclaredElement target) { }
    }
}
namespace JetBrains.ReSharper.Refactorings.Util.NewTypeImages
{
    
    public interface IReferenceImage
    {
        JetBrains.ReSharper.Psi.Resolve.IReference Recover(JetBrains.ReSharper.Psi.Resolve.IReference reference);
    }
    public interface IResolveImagesLanguageSupport
    {
        bool IsExternallyVisibleSymbol(JetBrains.ReSharper.Psi.IDeclaredElement element);
        bool IsFromExtendsList(JetBrains.ReSharper.Psi.Tree.ITreeNode element);
        bool IsReferenceName(JetBrains.ReSharper.Psi.Tree.ITreeNode element);
        void RemoveUnusedUsing(JetBrains.ReSharper.Psi.Tree.IFile file, System.Collections.Generic.JetHashSet<JetBrains.ReSharper.Psi.Tree.ITreeNode> usings);
        void SaveUnusedUsings(JetBrains.ReSharper.Psi.Tree.IFile file, JetBrains.ReSharper.Refactorings.Move.Common.UnusedUsingSaver saver);
    }
    public class ResolveImagesRepository
    {
        public readonly System.Collections.Generic.List<JetBrains.ReSharper.Psi.Tree.ITreeNode> RegisteredCopies;
        public ResolveImagesRepository(System.Func<JetBrains.ReSharper.Psi.PsiLanguageType, JetBrains.ReSharper.Refactorings.Util.NewTypeImages.IResolveImagesLanguageSupport> languageSupport) { }
        public System.Collections.Generic.JetHashSet<JetBrains.ReSharper.Psi.IDeclaredElement> ExternalDeclaredElements { get; }
        public void AddRebindableReference(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Refactorings.Util.NewTypeImages.ResolveImagesRepository.ResolveResultImage image) { }
        public void BindReferences(JetBrains.Application.Progress.IProgressIndicator pi, JetBrains.ProjectModel.ISolution solution) { }
        public void CommitDeclaration(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public void CommitUsagesOfTopmostElements(System.Func<JetBrains.ReSharper.Psi.Tree.ITreeNode, bool> isInScope, JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator pi, JetBrains.Metadata.Reader.API.IModuleReferenceResolveContext resolveContext) { }
        public void ForceRegisterCopy(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public void MarkReferences(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public void ProvideManualElementsIdentity(JetBrains.ReSharper.Psi.IDeclaredElement oldElement, JetBrains.ReSharper.Psi.IDeclaredElement newElement) { }
        public void RegisterCopy(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public void RegisterCopyLazy(JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        public void RemoveNewUnusedUsings(JetBrains.Application.Progress.IProgressIndicator pi) { }
        public JetBrains.ReSharper.Psi.IType Substitute(JetBrains.ReSharper.Psi.IType type) { }
        public class ResolveResultImage
        {
            [JetBrains.Annotations.CanBeNullAttribute()]
            public static JetBrains.ReSharper.Refactorings.Util.NewTypeImages.ResolveImagesRepository.ResolveResultImage CreateImage(JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Refactorings.Util.NewTypeImages.ResolveImagesRepository repository) { }
            [JetBrains.Annotations.CanBeNullAttribute()]
            public JetBrains.ReSharper.Psi.IDeclaredElement GetDeclaredElement(JetBrains.ReSharper.Refactorings.Util.NewTypeImages.ResolveImagesRepository repository) { }
            [JetBrains.Annotations.CanBeNullAttribute()]
            public JetBrains.ReSharper.Psi.Resolve.ISubstitution GetSubstitution(JetBrains.ReSharper.Refactorings.Util.NewTypeImages.ResolveImagesRepository repository) { }
        }
    }
    public class ResolveResultImage
    {
        public ResolveResultImage(JetBrains.ReSharper.Psi.Resolve.IReference reference, System.Func<JetBrains.ReSharper.Psi.ITypeElement, JetBrains.ReSharper.Psi.ITypeElement> leftTypeMap, System.Func<JetBrains.ReSharper.Psi.ITypeElement, JetBrains.ReSharper.Psi.ITypeElement> rightTypeMap, System.Func<JetBrains.ReSharper.Psi.IDeclaredElement, JetBrains.ReSharper.Psi.IDeclaredElement> newTypeMemberDelegate) { }
        public System.Func<JetBrains.ReSharper.Psi.ITypeElement, JetBrains.ReSharper.Psi.ITypeElement> LeftTypeMap { get; }
        public System.Func<JetBrains.ReSharper.Psi.IDeclaredElement, JetBrains.ReSharper.Psi.IDeclaredElement> NewTypeMemberDelegate { get; }
        public JetBrains.ReSharper.Psi.Resolve.IReference OldReference { get; }
        public JetBrains.ReSharper.Psi.Modules.IPsiModule PsiModule { get; }
        public JetBrains.ReSharper.Psi.Resolve.ResolveErrorType ResolveErrorType { get; }
        public System.Func<JetBrains.ReSharper.Psi.ITypeElement, JetBrains.ReSharper.Psi.ITypeElement> RightTypeMap { get; }
        public JetBrains.ReSharper.Psi.Resolve.IReference Recover(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
    }
    public class SubstitutionImage : JetBrains.ReSharper.Refactorings.Util.NewTypeImages.IReferenceImage
    {
        public SubstitutionImage(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution, JetBrains.ReSharper.Refactorings.Util.NewTypeImages.ResolveResultImage resolveImage) { }
        public JetBrains.ReSharper.Psi.Resolve.IReference Recover(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
    }
    public class TypeReferenceImage : JetBrains.ReSharper.Refactorings.Util.TypeImages.Visitor<JetBrains.ReSharper.Psi.IType>, JetBrains.ReSharper.Refactorings.Util.NewTypeImages.IReferenceImage
    {
        public TypeReferenceImage(JetBrains.ReSharper.Refactorings.Util.TypeImages.TypeImage typeImage, JetBrains.ReSharper.Refactorings.Util.NewTypeImages.ResolveResultImage resolveImage) { }
        public JetBrains.ReSharper.Psi.Resolve.IReference Recover(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public override JetBrains.ReSharper.Psi.IType VisitArrayType(JetBrains.ReSharper.Refactorings.Util.TypeImages.ArrayTypeImage arrayTypeImage) { }
        public override JetBrains.ReSharper.Psi.IType VisitDeclaredType(JetBrains.ReSharper.Refactorings.Util.TypeImages.DeclaredTypeImage declaredTypeImage) { }
        public override JetBrains.ReSharper.Psi.IType VisitPointerType(JetBrains.ReSharper.Refactorings.Util.TypeImages.PointerTypeImage pointerTypeImage) { }
        public override JetBrains.ReSharper.Psi.IType VisitType(JetBrains.ReSharper.Refactorings.Util.TypeImages.TypeImage typeImage) { }
    }
}
namespace JetBrains.ReSharper.Refactorings.Util.TypeImages
{
    
    public class AnonymousTypeImage : JetBrains.ReSharper.Refactorings.Util.TypeImages.TypeImage
    {
        public AnonymousTypeImage(JetBrains.ReSharper.Psi.Modules.IPsiModule module) { }
        public override JetBrains.ReSharper.Psi.Modules.IPsiModule PsiModule { get; }
        public override T Accept<T>(JetBrains.ReSharper.Refactorings.Util.TypeImages.Visitor<T> t) { }
    }
    public class ArrayTypeImage : JetBrains.ReSharper.Refactorings.Util.TypeImages.TypeImage
    {
        public ArrayTypeImage(JetBrains.ReSharper.Psi.IArrayType type) { }
        public JetBrains.ReSharper.Refactorings.Util.TypeImages.TypeImage Inner { get; }
        public override JetBrains.ReSharper.Psi.Modules.IPsiModule PsiModule { get; }
        public int Rank { get; }
        public override T Accept<T>(JetBrains.ReSharper.Refactorings.Util.TypeImages.Visitor<T> t) { }
    }
    public abstract class BaseResolveResultImage
    {
        protected readonly JetBrains.ReSharper.Psi.IPsiServices myPsiServices;
        protected readonly JetBrains.ReSharper.Psi.Resolve.ResolveErrorType myType;
        protected bool myWasRebinded;
        protected BaseResolveResultImage(JetBrains.ReSharper.Psi.Resolve.ResolveErrorType type, JetBrains.ReSharper.Psi.IPsiServices psiServices) { }
        public virtual JetBrains.ReSharper.Psi.IDeclaredElement InitialTypeElement { get; }
        public JetBrains.ReSharper.Psi.Resolve.ResolveErrorType OldErrorType { get; }
        public bool WasRebinded { get; }
        public JetBrains.ReSharper.Psi.Resolve.IResolveResult Recover(JetBrains.ReSharper.Refactorings.Util.TypeImages.MemberImagesProvider memberImagesProvider, JetBrains.ReSharper.Refactorings.Util.TypeImages.ImageProviderOfTypeElement imageProvider, JetBrains.ReSharper.Psi.Resolve.IReference updatedReference, JetBrains.ReSharper.Psi.ITypeElement targetType, out JetBrains.ReSharper.Psi.Resolve.IReference rebindedReference, bool substType) { }
        protected abstract JetBrains.ReSharper.Psi.Resolve.IResolveResult RecoverInternal(JetBrains.ReSharper.Refactorings.Util.TypeImages.MemberImagesProvider memberImagesProvider, JetBrains.ReSharper.Refactorings.Util.TypeImages.ImageProviderOfTypeElement imageProvider, JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.ITypeElement targetType, out JetBrains.ReSharper.Psi.Resolve.IReference rebindedReference, bool substType);
    }
    public class DeclaredTypeImage : JetBrains.ReSharper.Refactorings.Util.TypeImages.TypeImage
    {
        public DeclaredTypeImage(JetBrains.ReSharper.Psi.IDeclaredType type) { }
        public override JetBrains.ReSharper.Psi.Modules.IPsiModule PsiModule { get; }
        public System.Collections.Generic.Dictionary<JetBrains.ReSharper.Psi.ITypeParameter, JetBrains.ReSharper.Refactorings.Util.TypeImages.TypeImage> SubstitutionImage { get; }
        public JetBrains.ReSharper.Psi.ITypeElement TypeElement { get; }
        public JetBrains.ReSharper.Psi.IDeclaredType UnresolvedType { get; }
        public override T Accept<T>(JetBrains.ReSharper.Refactorings.Util.TypeImages.Visitor<T> t) { }
    }
    public class IDResolveResultImage : JetBrains.ReSharper.Refactorings.Util.TypeImages.BaseResolveResultImage
    {
        public IDResolveResultImage(JetBrains.ReSharper.Psi.Resolve.ResolveErrorType type, JetBrains.ReSharper.Psi.Resolve.IResolveResult result, JetBrains.ReSharper.Psi.IPsiServices psiServices) { }
        protected override JetBrains.ReSharper.Psi.Resolve.IResolveResult RecoverInternal(JetBrains.ReSharper.Refactorings.Util.TypeImages.MemberImagesProvider memberImagesProvider, JetBrains.ReSharper.Refactorings.Util.TypeImages.ImageProviderOfTypeElement imageProvider, JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.ITypeElement targetType, out JetBrains.ReSharper.Psi.Resolve.IReference rebindedReference, bool substType) { }
    }
    public delegate JetBrains.ReSharper.Refactorings.Util.TypeImages.TypeImageProvider ImageProviderOfTypeElement(JetBrains.ReSharper.Psi.ITypeElement targetTypeElement);
    public delegate System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IDeclaredElement> MemberImagesProvider(JetBrains.ReSharper.Psi.IDeclaredElement oldMember, JetBrains.ReSharper.Psi.ITypeElement target);
    public class PointerTypeImage : JetBrains.ReSharper.Refactorings.Util.TypeImages.TypeImage
    {
        public PointerTypeImage(JetBrains.ReSharper.Psi.IPointerType pointerType) { }
        public JetBrains.ReSharper.Refactorings.Util.TypeImages.TypeImage ElementType { get; }
        public override JetBrains.ReSharper.Psi.Modules.IPsiModule PsiModule { get; }
        public override T Accept<T>(JetBrains.ReSharper.Refactorings.Util.TypeImages.Visitor<T> t) { }
    }
    public class static ResolveResultImages
    {
        public static JetBrains.ReSharper.Refactorings.Util.TypeImages.BaseResolveResultImage CreateImage(JetBrains.ReSharper.Psi.Resolve.IResolveResult resolveResult, JetBrains.ReSharper.Psi.Resolve.ResolveErrorType resolveErrorType, JetBrains.ReSharper.Psi.Resolve.IReference originalReference, JetBrains.ReSharper.Psi.IPsiServices psiServices, bool toMovedElement) { }
    }
    public class SubstitutionImage
    {
        public SubstitutionImage(JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution) { }
        public JetBrains.ReSharper.Psi.Resolve.ISubstitution Recover(JetBrains.ReSharper.Refactorings.Util.TypeImages.TypeImageProvider provider, JetBrains.ReSharper.Psi.IDeclaredElement typeMember) { }
    }
    public class TypeElementImage
    {
        public TypeElementImage(JetBrains.ReSharper.Psi.ITypeElement oldTypeElement) { }
        public JetBrains.ReSharper.Psi.ITypeElement[] NestedTypeElements { get; }
        public JetBrains.ReSharper.Psi.ITypeElement OldTypeElement { get; }
        public System.Collections.Generic.IDictionary<JetBrains.ReSharper.Psi.ITypeElement, JetBrains.ReSharper.Psi.ITypeElement> Recover(JetBrains.ReSharper.Psi.ITypeElement newTypeElement, JetBrains.ReSharper.Refactorings.Util.TypeImages.TypeElementImage.ExternalRecoverer externalRecoverer) { }
        public delegate void ExternalRecoverer(JetBrains.ReSharper.Psi.ITypeElement oldTypeElement, System.Collections.Generic.IList<JetBrains.ReSharper.Refactorings.Util.TypeImages.TypeElementImage> typeElementImages, System.Collections.Generic.Dictionary<JetBrains.ReSharper.Psi.ITypeElement, JetBrains.ReSharper.Psi.ITypeElement> result);
    }
    public class TypeElementResolveResultImage : JetBrains.ReSharper.Refactorings.Util.TypeImages.BaseResolveResultImage
    {
        public TypeElementResolveResultImage(JetBrains.ReSharper.Psi.Resolve.ResolveErrorType type, JetBrains.ReSharper.Refactorings.Util.TypeImages.DeclaredTypeImage image, JetBrains.ReSharper.Psi.IPsiServices psiServices) { }
        public override JetBrains.ReSharper.Psi.IDeclaredElement InitialTypeElement { get; }
        protected override JetBrains.ReSharper.Psi.Resolve.IResolveResult RecoverInternal(JetBrains.ReSharper.Refactorings.Util.TypeImages.MemberImagesProvider memberImagesProvider, JetBrains.ReSharper.Refactorings.Util.TypeImages.ImageProviderOfTypeElement imageProvider, JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.ITypeElement targetType, out JetBrains.ReSharper.Psi.Resolve.IReference rebindedReference, bool substType) { }
    }
    public abstract class TypeImage
    {
        public abstract JetBrains.ReSharper.Psi.Modules.IPsiModule PsiModule { get; }
        public abstract T Accept<T>(JetBrains.ReSharper.Refactorings.Util.TypeImages.Visitor<T> t);
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.ReSharper.Refactorings.Util.TypeImages.TypeImage Create(JetBrains.ReSharper.Psi.IType type) { }
    }
    [JetBrains.Annotations.CanBeNullAttribute()]
    public delegate JetBrains.ReSharper.Psi.ITypeElement TypeImageProvider(JetBrains.ReSharper.Psi.ITypeElement oldTypeElement);
    public class TypeMemberResolveResultImage : JetBrains.ReSharper.Refactorings.Util.TypeImages.BaseResolveResultImage
    {
        public TypeMemberResolveResultImage(JetBrains.ReSharper.Psi.Resolve.ResolveErrorType type, JetBrains.ReSharper.Psi.ITypeMember member, JetBrains.ReSharper.Psi.IPsiServices psiServices, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution) { }
        public override JetBrains.ReSharper.Psi.IDeclaredElement InitialTypeElement { get; }
        protected override JetBrains.ReSharper.Psi.Resolve.IResolveResult RecoverInternal(JetBrains.ReSharper.Refactorings.Util.TypeImages.MemberImagesProvider memberImagesProvider, JetBrains.ReSharper.Refactorings.Util.TypeImages.ImageProviderOfTypeElement imageProvider, JetBrains.ReSharper.Psi.Resolve.IReference reference, JetBrains.ReSharper.Psi.ITypeElement targetType, out JetBrains.ReSharper.Psi.Resolve.IReference rebindedReference, bool substType) { }
    }
    public class TypeRecoverer : JetBrains.ReSharper.Refactorings.Util.TypeImages.Visitor<JetBrains.ReSharper.Psi.IType>
    {
        public TypeRecoverer(JetBrains.ReSharper.Refactorings.Util.TypeImages.TypeImageProvider imageProvider, bool substRight) { }
        public JetBrains.ReSharper.Psi.Resolve.ISubstitution GetNewSubstitution(System.Collections.Generic.Dictionary<JetBrains.ReSharper.Psi.ITypeParameter, JetBrains.ReSharper.Refactorings.Util.TypeImages.TypeImage> substitutionImage, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.ITypeParameter> newTypeParameter, bool left) { }
        public override JetBrains.ReSharper.Psi.IType VisitArrayType(JetBrains.ReSharper.Refactorings.Util.TypeImages.ArrayTypeImage arrayTypeImage) { }
        public override JetBrains.ReSharper.Psi.IType VisitDeclaredType(JetBrains.ReSharper.Refactorings.Util.TypeImages.DeclaredTypeImage declaredTypeImage) { }
        public override JetBrains.ReSharper.Psi.IType VisitPointerType(JetBrains.ReSharper.Refactorings.Util.TypeImages.PointerTypeImage pointerTypeImage) { }
        public override JetBrains.ReSharper.Psi.IType VisitType(JetBrains.ReSharper.Refactorings.Util.TypeImages.TypeImage typeImage) { }
    }
    public abstract class Visitor<T>
    
    {
        public virtual T VisitArrayType(JetBrains.ReSharper.Refactorings.Util.TypeImages.ArrayTypeImage arrayTypeImage) { }
        public virtual T VisitDeclaredType(JetBrains.ReSharper.Refactorings.Util.TypeImages.DeclaredTypeImage declaredTypeImage) { }
        public virtual T VisitPointerType(JetBrains.ReSharper.Refactorings.Util.TypeImages.PointerTypeImage pointerTypeImage) { }
        public abstract T VisitType(JetBrains.ReSharper.Refactorings.Util.TypeImages.TypeImage typeImage);
    }
}
namespace JetBrains.ReSharper.Refactorings.Workflow
{
    
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class AnyChangeManager : System.IDisposable
    {
        public AnyChangeManager(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ProjectModel.ISolution solution, JetBrains.DocumentManagers.DocumentManager documentManager, JetBrains.DocumentManagers.impl.DocumentManagerOperations documentOperations, JetBrains.Application.ChangeManager changeManager) { }
        public event System.EventHandler AnythingChanged;
        public static JetBrains.ReSharper.Refactorings.Workflow.AnyChangeManager GetInstance(JetBrains.ProjectModel.ISolution solution) { }
    }
    public abstract class DrivenRefactoringWorkflow : JetBrains.ReSharper.Refactorings.Workflow.RefactoringWorkflowBase
    {
        protected DrivenRefactoringWorkflow(JetBrains.ProjectModel.ISolution solution, string actionId) { }
        public override string ActionId { get; }
        public override JetBrains.ReSharper.Refactorings.Conflicts.IConflictSearcher ConflictSearcher { get; }
        public override bool HasUI { get; }
        public override JetBrains.UI.Icons.IconId Icon { get; }
        public JetBrains.ReSharper.Psi.IPsiServices PsiServices { get; }
        public override JetBrains.ProjectModel.ISolution Solution { get; }
        public JetBrains.ReSharper.Refactorings.Workflow.RefactoringDriverStorage Storage { get; }
        public abstract JetBrains.ReSharper.Refactorings.Workflow.IRefactoringExecuter CreateRefactoring(JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver);
        public override bool Execute(JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.ReSharper.Refactorings.RefactoringsHelper GetHelper(JetBrains.ReSharper.Psi.PsiLanguageType language) { }
        public override bool PostExecute(JetBrains.Application.Progress.IProgressIndicator pi) { }
        public override bool PreExecute(JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
        public virtual bool Validate() { }
    }
    public abstract class ExtensibleRefactoringAction<TRefactoringWorkflowProvider> : JetBrains.ReSharper.Feature.Services.ActionsMenu.ExtensibleAction<TRefactoringWorkflowProvider, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringWorkflow, JetBrains.ReSharper.Refactorings.Workflow.RefactoringActionGroup>
        where TRefactoringWorkflowProvider :  class, JetBrains.ReSharper.Feature.Services.ActionsMenu.IWorkflowProvider<, >, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringWorkflowProvider
    {
        protected override bool AssertsMenuItemsMnemonics { get; }
        protected override bool ShowMenuWithOneItem { get; }
        protected override void Execute(JetBrains.Application.DataContext.IDataContext context, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringWorkflow refactoringWorkflow) { }
        protected override JetBrains.UI.Icons.IconId GetIcon(JetBrains.Application.DataContext.IDataContext dataContext) { }
        protected override System.Collections.Generic.ICollection<TRefactoringWorkflowProvider> GetWorkflowProviders() { }
        protected override bool IsAvailable(JetBrains.Application.DataContext.IDataContext context, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringWorkflow refactoringWorkflow) { }
        protected override bool IsEnabled(JetBrains.Application.DataContext.IDataContext context, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringWorkflow workflow) { }
    }
    public interface IRefactoringDriver
    {
        void AddConflict([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Refactorings.Conflicts.IConflict conflict);
        void AddConflict(string description, JetBrains.ReSharper.Refactorings.Conflicts.ConflictSeverity severity, params object[] args);
        void AddLateConflict(System.Func<JetBrains.ReSharper.Refactorings.Conflicts.IConflict> conflict, string id);
        System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Resolve.IReference> Get(JetBrains.Util.Key key, System.Func<System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Resolve.IReference>> generator);
        System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Resolve.IReference> Get(JetBrains.Util.Key key);
        void Set(JetBrains.Util.Key key, System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Resolve.IReference> references);
    }
    public interface IRefactoringExecuter
    {
        bool Execute(JetBrains.Application.Progress.IProgressIndicator pi);
    }
    public interface IRefactoringPage
    {
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.DataFlow.IProperty<bool> ContinueEnabled { get; }
        string Description { get; }
        bool DoNotShow { get; }
        string Title { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.UI.CrossFramework.EitherControl View { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage Commit([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Progress.IProgressIndicator pi);
        bool Initialize([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Progress.IProgressIndicator pi);
        bool RefreshContents([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Progress.IProgressIndicator pi);
    }
    public interface IRefactoringWorkflow : JetBrains.ReSharper.Feature.Services.ActionsMenu.IWorkflow<JetBrains.ReSharper.Refactorings.Workflow.RefactoringActionGroup>
    {
        JetBrains.ReSharper.Refactorings.Conflicts.IConflictSearcher ConflictSearcher { get; }
        JetBrains.UI.Application.IUIApplication Environment { get; }
        JetBrains.Util.EventBus.IEventBus EventBus { get; set; }
        JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage FirstPendingRefactoringPage { get; }
        bool HasUI { get; }
        string HelpKeyword { get; }
        bool MightModifyManyDocuments { get; }
        bool RequiresSolutionTransation { get; }
        JetBrains.ProjectModel.ISolution Solution { get; }
        bool Execute(JetBrains.Application.Progress.IProgressIndicator progressIndicator);
        T GetComponent<T>()
            where T :  class;
        bool Initialize(JetBrains.Application.DataContext.IDataContext context);
        bool IsAvailable(JetBrains.Application.DataContext.IDataContext context);
        bool PostExecute(JetBrains.Application.Progress.IProgressIndicator pi);
        bool PreExecute(JetBrains.Application.Progress.IProgressIndicator progressIndicator);
        bool RefreshData();
        void SuccessfulFinish(JetBrains.Application.Progress.IProgressIndicator pi);
        T TryGetComponent<T>()
            where T :  class;
        void UnsuccessfulFinish(JetBrains.Application.Progress.IProgressIndicator pi);
    }
    public interface IRefactoringWorkflowProvider : JetBrains.ReSharper.Feature.Services.ActionsMenu.IWorkflowProvider<JetBrains.ReSharper.Refactorings.Workflow.IRefactoringWorkflow, JetBrains.ReSharper.Refactorings.Workflow.RefactoringActionGroup> { }
    public interface IUsagesProvider
    {
        void CommitCheckedOccurrences(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Refactorings.Workflow.RefactoringReferenceOccurence> checkedOccurrences, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Refactorings.Workflow.RefactoringDeclarationOccurrence> getCheckedDeclarations);
        System.Collections.Generic.IList<JetBrains.ReSharper.Refactorings.Workflow.RefactoringDeclarationOccurrence> GetDeclarationOccurrences(JetBrains.ReSharper.Refactorings.Workflow.DrivenRefactoringWorkflow workflow);
        System.Collections.Generic.IList<JetBrains.ReSharper.Refactorings.Workflow.RefactoringReferenceOccurence> GetReferenceOccurrences(JetBrains.ReSharper.Refactorings.Workflow.DrivenRefactoringWorkflow workflow);
    }
    public abstract class RefactoringAction : JetBrains.ActionManagement.IActionHandler
    {
        protected RefactoringAction([JetBrains.Annotations.NotNullAttribute()] System.Func<JetBrains.ProjectModel.ISolution, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringWorkflow> createWorkflow) { }
        public void Execute(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.DelegateExecute nextExecute) { }
        public virtual void SetPresentation(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.ActionPresentation presentation) { }
        public bool Update(JetBrains.Application.DataContext.IDataContext context, JetBrains.ActionManagement.ActionPresentation presentation, JetBrains.ActionManagement.DelegateUpdate nextUpdate) { }
    }
    public sealed class RefactoringActionGroup : JetBrains.ReSharper.Feature.Services.ActionsMenu.ActionGroup
    {
        public static readonly JetBrains.ReSharper.Refactorings.Workflow.RefactoringActionGroup Blessed;
        public static readonly JetBrains.ReSharper.Refactorings.Workflow.RefactoringActionGroup Convert;
        public static readonly JetBrains.ReSharper.Refactorings.Workflow.RefactoringActionGroup EditHierarchy;
        public static readonly JetBrains.ReSharper.Refactorings.Workflow.RefactoringActionGroup IntroduceEntity;
        public static readonly JetBrains.ReSharper.Refactorings.Workflow.RefactoringActionGroup Unsorded;
    }
    public class static RefactoringActionUtil
    {
        public static void ExecuteRefactoring([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.DataContext.IDataContext context, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Refactorings.Workflow.IRefactoringWorkflow refactoringWorkflow) { }
    }
    public class RefactoringDeclarationOccurrence : JetBrains.ReSharper.Feature.Services.Navigation.Occurences.RangeOccurence
    {
        public RefactoringDeclarationOccurrence(JetBrains.ReSharper.Psi.Tree.IDeclaration declaration) { }
        public JetBrains.ReSharper.Psi.Tree.IDeclaration Declaration { get; }
    }
    public class RefactoringDriver : JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver
    {
        public RefactoringDriver(JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.RefactoringDriverStorage storage) { }
        public void AddConflict(JetBrains.ReSharper.Refactorings.Conflicts.IConflict conflict) { }
        public void AddConflict(string description, JetBrains.ReSharper.Refactorings.Conflicts.ConflictSeverity severity, params object[] args) { }
        public void AddLateConflict(System.Func<JetBrains.ReSharper.Refactorings.Conflicts.IConflict> conflict, string id) { }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Resolve.IReference> Get(JetBrains.Util.Key key, System.Func<System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Resolve.IReference>> generator) { }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Resolve.IReference> Get(JetBrains.Util.Key key) { }
        public void Set(JetBrains.Util.Key key, System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Resolve.IReference> references) { }
    }
    public class RefactoringDriverStorage
    {
        public RefactoringDriverStorage() { }
        public bool HasTextOccurences { get; }
        public void Get(JetBrains.Util.Key key, out System.Collections.Generic.IList<> references) { }
        public void Get(JetBrains.Util.Key key, out System.Collections.Generic.IList<> textOccurenceMarkers) { }
        public void Invalidate() { }
        public void Put(JetBrains.Util.Key key, System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Resolve.IReference> references) { }
        public void Put(JetBrains.Util.Key key, System.Collections.Generic.IList<JetBrains.ReSharper.Refactorings.Workflow.TextOccurenceRenameMarker> textOccurences) { }
    }
    public class RefactoringDriverWithConflicts : JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver
    {
        public RefactoringDriverWithConflicts(JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Refactorings.Workflow.RefactoringDriverStorage storage) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Refactorings.Conflicts.IConflict> Conflicts { get; }
        public bool HasConflicts { get; }
        public bool ShouldDisplay { get; }
        public JetBrains.ReSharper.Refactorings.Workflow.RefactoringDriverStorage Storage { get; }
        public void AddConflict(JetBrains.ReSharper.Refactorings.Conflicts.IConflict conflict) { }
        public void AddConflict(string description, JetBrains.ReSharper.Refactorings.Conflicts.ConflictSeverity severity, params object[] args) { }
        public void AddLateConflict(System.Func<JetBrains.ReSharper.Refactorings.Conflicts.IConflict> conflict, string id) { }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Resolve.IReference> Get(JetBrains.Util.Key key, System.Func<System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Resolve.IReference>> generator) { }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Resolve.IReference> Get(JetBrains.Util.Key key) { }
        public void Set(JetBrains.Util.Key key, System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Resolve.IReference> references) { }
    }
    public class static RefactoringInvocator
    {
        public static T TryExecute<T>(string actionID, System.Func<T> func, T defaultValue) { }
    }
    public class RefactoringReferenceOccurence : JetBrains.ReSharper.Feature.Services.Navigation.Occurences.RangeOccurence
    {
        public RefactoringReferenceOccurence(JetBrains.ReSharper.Psi.Resolve.IReference reference) { }
        public JetBrains.ReSharper.Psi.Resolve.IReference Reference { get; }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class RefactoringsManager
    {
        public RefactoringsManager(System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Refactorings.Workflow.IRefactoringWorkflowProvider> providers) { }
        public static JetBrains.ReSharper.Refactorings.Workflow.RefactoringsManager Instance { get; }
        public System.Collections.Generic.IEnumerable<TWorkflowProvider> GetWorkflowProviders<TWorkflowProvider>()
            where TWorkflowProvider : JetBrains.ReSharper.Refactorings.Workflow.IRefactoringWorkflowProvider { }
    }
    public class RefactoringsTaskExecutor : JetBrains.Application.Progress.ITaskExecutor, System.IDisposable
    {
        public readonly JetBrains.DataFlow.ObsoleteLifetimeAndDefinitionAtTheSameTime DisposablesGlobal;
        public readonly JetBrains.Application.Progress.ProgressIndicator ProgressIndicator;
        public readonly JetBrains.DataFlow.IProperty<JetBrains.ReSharper.Refactorings.Workflow.RefactoringsTaskExecutor.TaskHelperExecutionState> State;
        public RefactoringsTaskExecutor(JetBrains.UI.Application.Progress.TaskThreadAffinity threading, System.Func<JetBrains.DataFlow.Lifetime, JetBrains.Application.Progress.IProgressIndicatorModel, System.IntPtr> funcAttachUi) { }
        public void Dispose() { }
        public enum TaskHelperExecutionState
        {
            Unstarted = 0,
            Running = 1,
            Finished = 2,
        }
    }
    public abstract class RefactoringWorkflowBase : JetBrains.ReSharper.Feature.Services.ActionsMenu.IWorkflow<JetBrains.ReSharper.Refactorings.Workflow.RefactoringActionGroup>, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringWorkflow
    {
        protected RefactoringWorkflowBase() { }
        public abstract JetBrains.ReSharper.Refactorings.Workflow.RefactoringActionGroup ActionGroup { get; }
        public abstract string ActionId { get; }
        public abstract JetBrains.ReSharper.Refactorings.Conflicts.IConflictSearcher ConflictSearcher { get; }
        public JetBrains.UI.Application.IUIApplication Environment { get; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.Util.EventBus.IEventBus EventBus { get; set; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public abstract JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage FirstPendingRefactoringPage { get; }
        public abstract bool HasUI { get; }
        public abstract string HelpKeyword { get; }
        public abstract JetBrains.UI.Icons.IconId Icon { get; }
        public abstract bool MightModifyManyDocuments { get; }
        public virtual bool RequiresSolutionTransation { get; }
        public string ShortActionId { get; }
        public abstract JetBrains.ProjectModel.ISolution Solution { get; }
        public abstract string Title { get; }
        public abstract bool Execute(JetBrains.Application.Progress.IProgressIndicator progressIndicator);
        public T GetComponent<T>()
            where T :  class { }
        public abstract bool Initialize(JetBrains.Application.DataContext.IDataContext context);
        public abstract bool IsAvailable([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.DataContext.IDataContext context);
        public void NotifyRefactoringFinished() { }
        public abstract bool PostExecute(JetBrains.Application.Progress.IProgressIndicator pi);
        public abstract bool PreExecute([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Progress.IProgressIndicator progressIndicator);
        public virtual bool RefreshData() { }
        public virtual void SuccessfulFinish(JetBrains.Application.Progress.IProgressIndicator pi) { }
        public T TryGetComponent<T>()
            where T :  class { }
        public virtual void UnsuccessfulFinish(JetBrains.Application.Progress.IProgressIndicator pi) { }
    }
    [JetBrains.Annotations.BaseTypeRequiredAttribute(typeof(JetBrains.ReSharper.Refactorings.Workflow.IRefactoringWorkflowProvider))]
    [JetBrains.Annotations.MeansImplicitUseAttribute()]
    [System.AttributeUsageAttribute(System.AttributeTargets.Class | System.AttributeTargets.All)]
    public class RefactoringWorkflowProviderAttribute : JetBrains.Application.ShellComponentAttribute { }
    public class static RefactoringWorkflowUtil
    {
        public static bool CheckInheritance(ref JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, string caption) { }
        public static JetBrains.ReSharper.Feature.Services.Navigation.CustomHighlighting.CustomHighlightingRequest GetHighlightingRequest(JetBrains.TextControl.ITextControl textControl, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Tree.ITreeNode> elements, bool unhighlightOnDocumentChange, JetBrains.ProjectModel.ISolution solution) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Psi.Tree.ITypeDeclaration GetTypeDeclaration(JetBrains.Application.DataContext.IDataContext context, out bool invokedFromCode) { }
        public static void UnhighlightRequest(JetBrains.ReSharper.Feature.Services.Navigation.CustomHighlighting.CustomHighlightingRequest highlightingRequest, JetBrains.ProjectModel.ISolution solution) { }
        public class static Const
        {
            public static readonly JetBrains.DataFlow.PropertyId<bool> InvokedOnDeclarationNotReference;
            public static readonly JetBrains.DataFlow.PropertyId<JetBrains.ReSharper.Psi.Tree.ITypeDeclaration> TypeDeclaration;
        }
    }
    public class SequenceRefactoringPages : JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage
    {
        public SequenceRefactoringPages([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage firstPage, params System.Func<>[] nextPages) { }
        public JetBrains.DataFlow.IProperty<bool> ContinueEnabled { get; }
        public string Description { get; }
        public bool DoNotShow { get; }
        public string Title { get; }
        public JetBrains.UI.CrossFramework.EitherControl View { get; }
        public JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage Commit(JetBrains.Application.Progress.IProgressIndicator pi) { }
        public bool Initialize(JetBrains.Application.Progress.IProgressIndicator pi) { }
        public bool RefreshContents(JetBrains.Application.Progress.IProgressIndicator pi) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class SolutionWatcher : System.IDisposable
    {
        public event System.Action Closed;
        public static JetBrains.ReSharper.Refactorings.Workflow.SolutionWatcher GetInstance(JetBrains.ProjectModel.ISolution solution) { }
    }
    public class static SubRefactoringWorkflowProcessor
    {
        public static bool Execute(JetBrains.ReSharper.Refactorings.Workflow.DrivenRefactoringWorkflow workflow, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver, JetBrains.Application.DataContext.IDataContext context, JetBrains.Application.Progress.IProgressIndicator pi) { }
    }
    public class TextOccurenceRenameMarker
    {
        public TextOccurenceRenameMarker(JetBrains.ReSharper.Psi.Search.FindResultText occurence, string newName) { }
        public JetBrains.DocumentModel.IDocument Document { get; }
        public JetBrains.DocumentModel.DocumentRange DocumentRange { get; }
        public bool Included { get; set; }
        public bool IsValid { get; }
        public string MarkerName { get; }
        public string NewName { get; set; }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public JetBrains.ProjectModel.IProjectFile ProjectItem { get; }
        public JetBrains.ReSharper.Psi.IPsiSourceFile SourceFile { get; }
    }
    public class TextualRefactoringChange
    {
        public TextualRefactoringChange(JetBrains.ReSharper.Psi.Search.FindResultText occurence, JetBrains.DocumentManagers.DocumentManager documentManager) { }
        public bool Included { get; set; }
        public int OriginalLength { get; }
        public JetBrains.DocumentModel.IRangeMarker RangeMarker { get; set; }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
    }
}
namespace JetBrains.ReSharper.Refactorings.WorkflowNew
{
    
    public enum BuggyBehavior
    {
        NoBugs = 0,
        ThrowsException = 1,
        ReturnsFalse = 2,
        Cancelled = 3,
    }
    public class BuggyConflictsSearcher : JetBrains.ReSharper.Refactorings.Conflicts.IConflictSearcher
    {
        public BuggyConflictsSearcher(JetBrains.ReSharper.Refactorings.WorkflowNew.BuggyTestDriver driver) { }
        public JetBrains.ReSharper.Refactorings.Conflicts.ConflictSearchResult SearchConflicts(JetBrains.Application.Progress.IProgressIndicator progressIndicator, bool canPerformRefactoring) { }
    }
    public class BuggyPage : JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage
    {
        public BuggyPage(JetBrains.ReSharper.Refactorings.WorkflowNew.BuggyTestDriver driver) { }
        public JetBrains.DataFlow.IProperty<bool> ContinueEnabled { get; }
        public string Description { get; }
        public bool DoNotShow { get; }
        public string Title { get; }
        public JetBrains.UI.CrossFramework.EitherControl View { get; }
        public JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage Commit(JetBrains.Application.Progress.IProgressIndicator pi) { }
        public bool Initialize(JetBrains.Application.Progress.IProgressIndicator pi) { }
        public bool RefreshContents(JetBrains.Application.Progress.IProgressIndicator pi) { }
    }
    public class BuggyTestDriver : JetBrains.ReSharper.Refactorings.WorkflowNew.SimpleWorkflowHost
    {
        public BuggyTestDriver(bool hasConflicts, bool drivenConflictsSearch, JetBrains.ReSharper.Refactorings.WorkflowNew.BuggyBehavior executeBuggyBehavior, JetBrains.ReSharper.Refactorings.WorkflowNew.BuggyBehavior commitFirstPageBuggyBehavior, JetBrains.ReSharper.Refactorings.WorkflowNew.BuggyBehavior initializeFirstPageBuggyBehavior, JetBrains.ReSharper.Refactorings.WorkflowNew.BuggyBehavior preExecuteBuggyBehavior, JetBrains.ProjectModel.ISolution solution) { }
        public BuggyTestDriver() { }
        public bool DrivenConflictsSearch { get; }
        public System.Text.StringBuilder ExecutionTrace { get; }
        public bool HasConflicts { get; }
        public JetBrains.ProjectModel.ISolution Solution { get; }
        public JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage CommitFirstPage() { }
        public override JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage CreateConflictsPage(JetBrains.ReSharper.Refactorings.WorkflowNew.WorkflowExecuter executer, JetBrains.ReSharper.Refactorings.Conflicts.ConflictSearchResult conflicts) { }
        public bool Execute(JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage GetFirstPage() { }
        public bool InitializeFirstPage() { }
        public bool PostExecute() { }
        public bool PreExecute() { }
        public string PresentOptions() { }
        public void SuccessfulFinish() { }
        public void UnsuccessfulFinish() { }
        public class BuggyException : System.Exception { }
    }
    public class BuggyTestRefactoring : JetBrains.ReSharper.Refactorings.Workflow.IRefactoringExecuter
    {
        public BuggyTestRefactoring(JetBrains.ReSharper.Refactorings.WorkflowNew.BuggyTestDriver driver, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver refactoringDriver) { }
        public bool Execute(JetBrains.Application.Progress.IProgressIndicator pi) { }
    }
    public class BuggyTestWorkflow : JetBrains.ReSharper.Refactorings.Workflow.DrivenRefactoringWorkflow
    {
        public BuggyTestWorkflow(JetBrains.ReSharper.Refactorings.WorkflowNew.BuggyTestDriver driver, string actionId) { }
        public override JetBrains.ReSharper.Refactorings.Workflow.RefactoringActionGroup ActionGroup { get; }
        public override JetBrains.ReSharper.Refactorings.Conflicts.IConflictSearcher ConflictSearcher { get; }
        public override JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage FirstPendingRefactoringPage { get; }
        public override bool HasUI { get; }
        public override string HelpKeyword { get; }
        public override bool MightModifyManyDocuments { get; }
        public override string Title { get; }
        public override JetBrains.ReSharper.Refactorings.Workflow.IRefactoringExecuter CreateRefactoring(JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public override bool Initialize(JetBrains.Application.DataContext.IDataContext context) { }
        public override bool IsAvailable(JetBrains.Application.DataContext.IDataContext context) { }
        public override bool PostExecute(JetBrains.Application.Progress.IProgressIndicator pi) { }
        public override bool PreExecute(JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
        public override void SuccessfulFinish(JetBrains.Application.Progress.IProgressIndicator pi) { }
        public override void UnsuccessfulFinish(JetBrains.Application.Progress.IProgressIndicator pi) { }
    }
    public class CachingLanguageSpecificImpl<TLanguageSpecificInterface>
        where TLanguageSpecificInterface :  class
    {
        public CachingLanguageSpecificImpl(JetBrains.ReSharper.Psi.ILanguageManager languageManager) { }
        public TLanguageSpecificInterface this[JetBrains.ReSharper.Psi.PsiLanguageType language] { get; }
    }
    public class DataTuple : JetBrains.Util.JetTuple<string, object>
    {
        public DataTuple(string name, object value) { }
    }
    public abstract class DrivenRefactoringWorkflow2<TLanguageService> : JetBrains.ReSharper.Refactorings.Workflow.DrivenRefactoringWorkflow
        where TLanguageService :  class, JetBrains.ReSharper.Refactorings.IWorkflowExec
    {
        protected DrivenRefactoringWorkflow2([JetBrains.Annotations.NotNullAttribute()] JetBrains.ProjectModel.ISolution solution, string actionId) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public JetBrains.ReSharper.Refactorings.LanguageMapOfWorkflow<TLanguageService> Helper { get; }
        protected abstract TLanguageService CreateHelper(JetBrains.ReSharper.Refactorings.IRefactoringLanguageService service);
        protected abstract TLanguageService CreateUnsupportedHelper();
    }
    public class static EventBusExtensions
    {
        public static void RefactoringDetails([JetBrains.Annotations.CanBeNullAttribute()] this JetBrains.Util.EventBus.IEventBus bus, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringWorkflow workflow, params JetBrains.ReSharper.Refactorings.WorkflowNew.DataTuple[] properties) { }
    }
    public class ExecuteRefactoringUndoRedoHandler : JetBrains.Util.IUndoRedoHandler
    {
        public ExecuteRefactoringUndoRedoHandler(JetBrains.Util.EventBus.IEventBus eventBus, JetBrains.ReSharper.Refactorings.WorkflowNew.RefactoringId refactoringId) { }
        public void Do() { }
        public void Redo() { }
        public void Undo() { }
    }
    public sealed class FunctionWrapper<TReturn>
    
    {
        public FunctionWrapper(System.Func<JetBrains.Application.Progress.IProgressIndicator, TReturn> action, JetBrains.ReSharper.Refactorings.WorkflowNew.WorkflowExecuter executer) { }
        public bool FailedInternal { get; }
        public TReturn Result { get; }
        public void ExecuteAction([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.Progress.IProgressIndicator pi) { }
    }
    public interface IIntroduceWorkflowWithOccurences
    {
        JetBrains.ReSharper.Psi.Tree.ITreeNode Expression { get; }
        bool HasManyUsages { get; }
        JetBrains.ReSharper.Feature.Services.Navigation.CustomHighlighting.CustomHighlightingRequest HighlightingRequest { get; set; }
        System.Collections.Generic.List<JetBrains.ReSharper.Psi.Tree.ITreeNode> MoreUsages { get; }
        JetBrains.ProjectModel.ISolution Solution { get; }
        JetBrains.TextControl.ITextControl TextControl { get; }
        System.Collections.Generic.List<JetBrains.ReSharper.Psi.Tree.ITreeNode> Usages { get; }
        bool Initialize(JetBrains.Application.DataContext.IDataContext context);
        void SetIndex(JetBrains.ReSharper.Refactorings.WorkflowNew.SelectedItem value);
    }
    public class IntroduceActionFromMenu : JetBrains.ActionManagement.IActionBase, JetBrains.ActionManagement.IExecutableAction, JetBrains.ActionManagement.IUpdatableAction
    {
        public IntroduceActionFromMenu(JetBrains.ReSharper.Refactorings.WorkflowNew.IIntroduceWorkflowWithOccurences workflow, string presentation, string description, JetBrains.ReSharper.Refactorings.WorkflowNew.SelectedItem index) { }
        public string Id { get; }
        public string OverridenAction { get; }
        public JetBrains.ActionManagement.ActionPresentation Presentation { get; }
        public JetBrains.ReSharper.Refactorings.WorkflowNew.SelectedItem ReplaceAll { get; }
        public bool ShowConflict { get; set; }
        public void AddHandler(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ActionManagement.IActionHandler handler) { }
        public void Execute(JetBrains.Application.DataContext.IDataContext context) { }
        public void RemoveHandler(JetBrains.ActionManagement.IActionHandler handler) { }
        public override string ToString() { }
        public bool Update(JetBrains.Application.DataContext.IDataContext context) { }
    }
    public class static IntroduceWithOccurencesAction
    {
        public static void RemoveOldHighlighting(JetBrains.ReSharper.Refactorings.WorkflowNew.IIntroduceWorkflowWithOccurences workflow) { }
    }
    public abstract class IntroduceWithOccurencesAction<TRefactoringWorkflowProvider> : JetBrains.ReSharper.Refactorings.Workflow.ExtensibleRefactoringAction<TRefactoringWorkflowProvider>
        where TRefactoringWorkflowProvider :  class, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringWorkflowProvider
    {
        protected override void Execute(JetBrains.Application.DataContext.IDataContext context, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringWorkflow refactoringWorkflow) { }
    }
    public interface IRefactoringConfiguration
    {
        JetBrains.ReSharper.Refactorings.WorkflowNew.IRefactoringConfiguration GetNextConfiguration(JetBrains.ReSharper.Refactorings.Workflow.IRefactoringWorkflow refactoringWorkflow);
    }
    public interface IWorkflowHost : System.IDisposable
    {
        [JetBrains.Annotations.CanBeNullAttribute()]
        JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage CreateConflictsPage([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Refactorings.WorkflowNew.WorkflowExecuter executer, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Refactorings.Conflicts.ConflictSearchResult conflicts);
        JetBrains.Application.Progress.ITaskExecutor CreateFinalizeTastExecuter();
        [JetBrains.Annotations.NotNullAttribute()]
        JetBrains.Application.Progress.ITaskExecutor CreateTaskExecutor();
        void Initialize([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Refactorings.WorkflowNew.WorkflowExecuter executer);
        void ShowMessage(string text, string title);
        bool ShowPage([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage page, bool hasBack);
    }
    public class RefactoringDetailsArgs
    {
        public RefactoringDetailsArgs(JetBrains.ReSharper.Refactorings.WorkflowNew.RefactoringId refactoringId, params JetBrains.ReSharper.Refactorings.WorkflowNew.DataTuple[] properties) { }
        public System.Collections.Generic.Dictionary<string, object> Properties { get; }
        public JetBrains.ReSharper.Refactorings.WorkflowNew.RefactoringId RefactoringId { get; }
    }
    public class static RefactoringEvents
    {
        public static readonly JetBrains.Util.EventBus.EventId<JetBrains.ReSharper.Refactorings.WorkflowNew.RefactoringId> ReApplyRefactoringAfterConflict;
        public static readonly JetBrains.Util.EventBus.EventId<JetBrains.ReSharper.Refactorings.WorkflowNew.RefactoringDetailsArgs> RefactoringDetails;
        public static readonly JetBrains.Util.EventBus.EventId<JetBrains.ReSharper.Refactorings.WorkflowNew.RefactoringId> RefactoringEvent;
        public static readonly JetBrains.Util.EventBus.EventId<JetBrains.ReSharper.Refactorings.WorkflowNew.RefactoringId> RefactoringFinished;
        public static readonly JetBrains.Util.EventBus.EventId<JetBrains.ReSharper.Refactorings.WorkflowNew.RefactoringId> RefactoringFinishedWithConflict;
        public static readonly JetBrains.Util.EventBus.EventId<JetBrains.ReSharper.Refactorings.WorkflowNew.RefactoringId> RefactoringRedone;
        public static readonly JetBrains.Util.EventBus.EventId<JetBrains.ReSharper.Refactorings.WorkflowNew.RefactoringId> RefactoringStarted;
        public static readonly JetBrains.Util.EventBus.EventId<JetBrains.ReSharper.Refactorings.WorkflowNew.RefactoringId> RefactoringTransactionBegin;
        public static readonly JetBrains.Util.EventBus.EventId<JetBrains.ReSharper.Refactorings.WorkflowNew.RefactoringId> RefactoringTransactionCommit;
        public static readonly JetBrains.Util.EventBus.EventId<JetBrains.ReSharper.Refactorings.WorkflowNew.RefactoringId> RefactoringTransactionEvents;
        public static readonly JetBrains.Util.EventBus.EventId<JetBrains.ReSharper.Refactorings.WorkflowNew.RefactoringTransactionResult> RefactoringTransactionResult;
        public static readonly JetBrains.Util.EventBus.EventId<JetBrains.ReSharper.Refactorings.WorkflowNew.RefactoringId> RefactoringUndone;
    }
    public class RefactoringId
    {
        public RefactoringId(int id, string title) { }
        public int Id { get; }
        public string Title { get; }
        public bool Equals(JetBrains.ReSharper.Refactorings.WorkflowNew.RefactoringId other) { }
        public override bool Equals(object obj) { }
        public static JetBrains.ReSharper.Refactorings.WorkflowNew.RefactoringId FromWorkflow(JetBrains.ReSharper.Refactorings.Workflow.IRefactoringWorkflow workflow) { }
        public override int GetHashCode() { }
    }
    public class RefactoringTransactionResult : JetBrains.ReSharper.Refactorings.WorkflowNew.RefactoringId
    {
        public RefactoringTransactionResult(int id, string title, JetBrains.Util.TransactionCommitResult result) { }
        public JetBrains.Util.TransactionCommitResult Result { get; }
        public static JetBrains.ReSharper.Refactorings.WorkflowNew.RefactoringTransactionResult FromWorkflow(JetBrains.ReSharper.Refactorings.Workflow.IRefactoringWorkflow workflow, JetBrains.Util.TransactionCommitResult result) { }
    }
    public enum SelectedItem
    {
        More = 0,
        All = 1,
        One = 2,
    }
    public class SimpleWorkflowHost : JetBrains.ReSharper.Refactorings.WorkflowNew.IWorkflowHost, System.IDisposable
    {
        protected bool myIsDisposed;
        public virtual JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage CreateConflictsPage(JetBrains.ReSharper.Refactorings.WorkflowNew.WorkflowExecuter executer, JetBrains.ReSharper.Refactorings.Conflicts.ConflictSearchResult conflicts) { }
        public JetBrains.Application.Progress.ITaskExecutor CreateFinalizeTastExecuter() { }
        public virtual JetBrains.Application.Progress.ITaskExecutor CreateTaskExecutor() { }
        public void Dispose() { }
        public void Initialize(JetBrains.ReSharper.Refactorings.WorkflowNew.WorkflowExecuter executer) { }
        public void ShowMessage(string text, string title) { }
        public virtual bool ShowPage(JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage page, bool hasBack) { }
    }
    public sealed class WorkflowExecuter : System.IDisposable
    {
        public JetBrains.ReSharper.Refactorings.Workflow.IRefactoringWorkflow Workflow { get; }
        public void Dispose() { }
        public static void ExecuteBatch([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.DataContext.IDataContext context, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Refactorings.Workflow.IRefactoringWorkflow refactoringWorkflow) { }
        public static void ExecuteWithCustomHost([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.DataContext.IDataContext context, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Refactorings.Workflow.IRefactoringWorkflow refactoringWorkflow, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Refactorings.WorkflowNew.IWorkflowHost host) { }
        public static void ExecuteWithWizardForm([JetBrains.Annotations.NotNullAttribute()] JetBrains.Application.DataContext.IDataContext context, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Refactorings.Workflow.IRefactoringWorkflow refactoringWorkflow) { }
        public bool MoveToNextPage() { }
        public void MoveToPreviousPage() { }
        public JetBrains.ReSharper.Refactorings.Conflicts.ConflictSearchResult RefreshConflicts() { }
        public void UnlockTextControl() { }
        public void UpdateOnActivation() { }
    }
    public class WorkflowHostWithWizardForm : JetBrains.ReSharper.Refactorings.WorkflowNew.IWorkflowHost, System.IDisposable
    {
        public WorkflowHostWithWizardForm([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.UI.Application.IMainWindow mainwin) { }
        public JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage CreateConflictsPage(JetBrains.ReSharper.Refactorings.WorkflowNew.WorkflowExecuter executer, JetBrains.ReSharper.Refactorings.Conflicts.ConflictSearchResult conflicts) { }
        public JetBrains.Application.Progress.ITaskExecutor CreateFinalizeTastExecuter() { }
        public JetBrains.Application.Progress.ITaskExecutor CreateTaskExecutor() { }
        public void Dispose() { }
        public void Initialize(JetBrains.ReSharper.Refactorings.WorkflowNew.WorkflowExecuter executer) { }
        public void ShowMessage(string text, string title) { }
        public bool ShowPage(JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage page, bool hasBack) { }
    }
}
namespace JetBrains.ReSharper.Refactorings.WorkflowW.CheckUsages
{
    
    public class CheckUsagesPage : JetBrains.UI.CommonControls.SafeUserControl, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage
    {
        public CheckUsagesPage(JetBrains.ReSharper.Refactorings.Workflow.IUsagesProvider usagesProvider, JetBrains.ReSharper.Refactorings.Workflow.DrivenRefactoringWorkflow workflow, System.Func<JetBrains.Application.Progress.IProgressIndicator, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage> nextPageCreator) { }
        public JetBrains.DataFlow.IProperty<bool> ContinueEnabled { get; }
        public string Description { get; }
        public bool DoNotShow { get; }
        public string Title { get; }
        public JetBrains.UI.CrossFramework.EitherControl View { get; }
        public JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage Commit(JetBrains.Application.Progress.IProgressIndicator pi) { }
        protected override void Dispose(bool disposing) { }
        public bool Initialize(JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
        public bool RefreshContents(JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
    }
}
namespace JetBrains.ReSharper.Refactorings.WorkflowW
{
    
    public class ConflictsPage : JetBrains.UI.CommonControls.SafeUserControl, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage
    {
        public ConflictsPage([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Refactorings.WorkflowNew.WorkflowExecuter workflowProcessor, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Refactorings.Conflicts.IConflict> conflicts) { }
        public JetBrains.DataFlow.IProperty<bool> ContinueEnabled { get; }
        public string Description { get; }
        public bool DoNotShow { get; }
        public string Title { get; }
        public JetBrains.UI.CrossFramework.EitherControl View { get; }
        public JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage Commit(JetBrains.Application.Progress.IProgressIndicator pi) { }
        protected override void Dispose(bool disposing) { }
        public bool Initialize(JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
        public bool RefreshContents(JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
    }
    public class ConflictsTreeList : JetBrains.UI.CommonControls.SafeTreeList
    {
        public ConflictsTreeList() { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Refactorings.Conflicts.IConflict> Conflicts { set; }
        protected override DevExpress.XtraTreeList.Handler.TreeListHandler CreateHandler() { }
    }
    public class RefactoringWizardForm : System.Windows.Forms.Form
    {
        public readonly JetBrains.DataFlow.Property<JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage> Content;
        public readonly JetBrains.DataFlow.IProperty<JetBrains.ReSharper.Refactorings.Workflow.RefactoringsTaskExecutor> RunningTaskExecutor;
        public RefactoringWizardForm(JetBrains.ReSharper.Refactorings.WorkflowNew.WorkflowExecuter executer, JetBrains.UI.Theming.ITheming themeManager, JetBrains.CommonControls.Validation.FormValidators formValidators, JetBrains.UI.Application.HelpSystem helpSystem, JetBrains.DocumentModel.DocumentSettings documentSettings, JetBrains.UI.Application.IUIApplication environment) { }
        public bool HasBack { get; set; }
        public bool IsBusy { get; set; }
        public bool ShowKeepModifiedFilesOpen { get; set; }
        public event System.EventHandler BackClicked;
        public event System.EventHandler ContinueClicked;
        public JetBrains.Application.Progress.ITaskExecutor CreateTaskExecutor(JetBrains.UI.Application.Progress.TaskThreadAffinity threading) { }
        protected override void OnActivated(System.EventArgs e) { }
        protected override void OnClosed(System.EventArgs e) { }
        protected override void OnHelpButtonClicked(System.ComponentModel.CancelEventArgs e) { }
        protected override void OnShown(System.EventArgs e) { }
    }
    [JetBrains.Application.Settings.SettingsKeyAttribute(typeof(JetBrains.UI.Settings.DialogWindowsSettings), "Refactoring wizard dialog layout")]
    public class RefactoringWizardWindowSettings
    {
        [JetBrains.Application.Settings.SettingsEntryAttribute(null, "Relative position of the top-center point of the refactorings window")]
        public JetBrains.UI.Settings.PointRelativeToMainWindow Location;
    }
    public class TextualChangesPage : JetBrains.UI.CommonControls.SafeUserControl, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage
    {
        public TextualChangesPage(System.Collections.Generic.ICollection<JetBrains.ReSharper.Refactorings.Workflow.TextOccurenceRenameMarker> textOccurences, JetBrains.ProjectModel.ISolution solution, JetBrains.UI.Application.IUIApplication environment) { }
        public JetBrains.DataFlow.IProperty<bool> ContinueEnabled { get; }
        public string Description { get; }
        public bool DoNotShow { get; }
        public string Title { get; }
        public JetBrains.UI.CrossFramework.EitherControl View { get; }
        public JetBrains.ReSharper.Refactorings.Workflow.IRefactoringPage Commit(JetBrains.Application.Progress.IProgressIndicator pi) { }
        protected override void Dispose(bool disposing) { }
        public bool Initialize(JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
        public bool RefreshContents(JetBrains.Application.Progress.IProgressIndicator progressIndicator) { }
    }
}
namespace Test.WorkItems.PushPullValue
{
    
    public interface IWorkItemsWorkflow : JetBrains.ReSharper.Feature.Services.ActionsMenu.IWorkflow<Test.WorkItems.PushPullValue.WorkItemsActionGroup>
    {
        bool RequiresSolutionTransation { get; }
        bool Execute(JetBrains.Application.Progress.IProgressIndicator progressIndicator);
        bool Initialize(JetBrains.Application.DataContext.IDataContext context);
        bool IsAvailable(JetBrains.Application.DataContext.IDataContext context);
        bool PostExecute(JetBrains.Application.Progress.IProgressIndicator pi);
        bool PreExecute(JetBrains.Application.Progress.IProgressIndicator progressIndicator);
        void SuccessfulFinish(JetBrains.Application.Progress.IProgressIndicator pi);
        void UnsuccessfulFinish(JetBrains.Application.Progress.IProgressIndicator pi);
    }
    public interface IWorkItemsWorkflowProvider : JetBrains.ReSharper.Feature.Services.ActionsMenu.IWorkflowProvider<Test.WorkItems.PushPullValue.IWorkItemsWorkflow, Test.WorkItems.PushPullValue.WorkItemsActionGroup> { }
    public class WorkItemsActionGroup : JetBrains.ReSharper.Feature.Services.ActionsMenu.ActionGroup
    {
        public static readonly Test.WorkItems.PushPullValue.WorkItemsActionGroup Unsorted;
        protected WorkItemsActionGroup([JetBrains.Annotations.NotNullAttribute()] string name, float order) { }
    }
}
namespace Test.WorkItems.PushPullValue.Nodes
{
    
    public class DeclaredElementWorkItem : JetBrains.ReSharper.Refactorings.PushPullValue.Nodes.IWorkItemNode
    {
        public DeclaredElementWorkItem(JetBrains.ReSharper.Psi.IDeclaredElement element) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Refactorings.PushPullValue.Nodes.IWorkItemNode> Children { get; }
        public JetBrains.ReSharper.Psi.IDeclaredElement DeclaredElement { get; }
        public bool IsValid { get; }
        public JetBrains.ReSharper.Refactorings.src.PushPullValue.Nodes.WorkItemPresentation Presentation { get; }
        public bool Navigate(bool transferFocus) { }
    }
}