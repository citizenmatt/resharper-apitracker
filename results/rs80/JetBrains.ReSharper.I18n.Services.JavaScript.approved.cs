[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]

namespace JetBrains.ReSharper.I18n.Services.JavaScript.CustomReferences
{
    
    public class JavaScriptResourceItemReferenceFactory : JetBrains.ReSharper.Psi.Resolve.IReferenceFactory
    {
        public JetBrains.ReSharper.Psi.Resolve.IReference[] GetReferences(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.Resolve.IReference[] oldReferences) { }
        public bool HasReference(JetBrains.ReSharper.Psi.Tree.ITreeNode element, System.Collections.Generic.ICollection<string> names) { }
        [JetBrains.ReSharper.Psi.Resolve.ReferenceProviderFactoryAttribute()]
        public class Factory : JetBrains.ReSharper.Psi.Resolve.IReferenceProviderFactory
        {
            public Factory(JetBrains.Application.IShellLocks shellLocks) { }
            public event System.Action OnChanged;
            public JetBrains.ReSharper.Psi.Resolve.IReferenceFactory CreateFactory(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, JetBrains.ReSharper.Psi.Tree.IFile file) { }
        }
    }
    public class JsonAttributesResourceItemReferenceFactory : JetBrains.ReSharper.Psi.Resolve.IReferenceFactory
    {
        public JetBrains.ReSharper.Psi.Resolve.IReference[] GetReferences(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.Resolve.IReference[] oldReferences) { }
        public bool HasReference(JetBrains.ReSharper.Psi.Tree.ITreeNode element, System.Collections.Generic.ICollection<string> names) { }
        [JetBrains.ReSharper.Psi.Resolve.ReferenceProviderFactoryAttribute()]
        public class Factory : JetBrains.ReSharper.Psi.Resolve.IReferenceProviderFactory
        {
            public Factory(JetBrains.Application.IShellLocks shellLocks) { }
            public event System.Action OnChanged;
            public JetBrains.ReSharper.Psi.Resolve.IReferenceFactory CreateFactory(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, JetBrains.ReSharper.Psi.Tree.IFile file) { }
        }
    }
    public class JsonResourceItemReference : JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.CheckedReferenceBase<JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptLiteralExpression>, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.ICheckedReference, JetBrains.ReSharper.Psi.Resolve.ICompleteableReference, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.ReSharper.Psi.Resx.Tree.IResourceItemReference, JetBrains.ReSharper.Psi.Resx.Tree.IResourceReference, JetBrains.Util.IUserDataHolder
    {
        public JsonResourceItemReference(JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptLiteralExpression expression) { }
        public override bool HasMultipleNames { get; }
        public override JetBrains.ReSharper.Psi.Resolve.IReference BindTo(JetBrains.ReSharper.Psi.IDeclaredElement element) { }
        public override JetBrains.ReSharper.Psi.Resolve.IReference BindTo(JetBrains.ReSharper.Psi.IDeclaredElement element, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution) { }
        public System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.IPsiSourceFile> FindResourceFiles() { }
        public override JetBrains.ReSharper.Psi.Resolve.IAccessContext GetAccessContext() { }
        public override System.Collections.Generic.IEnumerable<string> GetAllNames() { }
        public JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetCompletionSymbolTable() { }
        public string GetDefaultName() { }
        public override string GetName() { }
        public override JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetReferenceSymbolTable(bool useReferenceName) { }
        public override JetBrains.ReSharper.Psi.Resolve.ISymbolFilter[] GetSymbolFilters() { }
        public override JetBrains.ReSharper.Psi.TreeTextRange GetTreeTextRange() { }
        public override JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.ResolveResultWithInfo ResolveWithoutCache() { }
    }
    public class JsonResourceItemReferenceFactory : JetBrains.ReSharper.Psi.Resolve.IReferenceFactory
    {
        public JetBrains.ReSharper.Psi.Resolve.IReference[] GetReferences(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.Resolve.IReference[] oldReferences) { }
        public bool HasReference(JetBrains.ReSharper.Psi.Tree.ITreeNode element, System.Collections.Generic.ICollection<string> names) { }
        [JetBrains.ReSharper.Psi.Resolve.ReferenceProviderFactoryAttribute()]
        public class Factory : JetBrains.ReSharper.Psi.Resolve.IReferenceProviderFactory
        {
            public Factory(JetBrains.Application.IShellLocks shellLocks) { }
            public event System.Action OnChanged;
            public JetBrains.ReSharper.Psi.Resolve.IReferenceFactory CreateFactory(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, JetBrains.ReSharper.Psi.Tree.IFile file) { }
        }
    }
}
namespace JetBrains.ReSharper.I18n.Services.JavaScript
{
    
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class DataWinResJsonPsiProvider : JetBrains.ReSharper.Psi.Impl.Shared.InjectedPsi.IndependentInjectedPsiProvider
    {
        public override JetBrains.ReSharper.Psi.PsiLanguageType GeneratedLanguage { get; }
        protected override bool CanBeGeneratedNode(JetBrains.ReSharper.Psi.Tree.ITreeNode node) { }
        protected override bool CanBeOriginalNode(JetBrains.ReSharper.Psi.Tree.ITreeNode node) { }
        public override JetBrains.ReSharper.Psi.ExtensionsAPI.IInjectedNodeContext CreateInjectedNodeContext(JetBrains.ReSharper.Psi.ExtensionsAPI.IInjectedFileContext fileContext, JetBrains.ReSharper.Psi.Tree.ITreeNode originalNode) { }
        public override bool IsApplicable(JetBrains.ReSharper.Psi.PsiLanguageType originalLanguage) { }
        public override bool IsApplicableToNode(JetBrains.ReSharper.Psi.Tree.ITreeNode node, JetBrains.ReSharper.Psi.ExtensionsAPI.IInjectedFileContext fileContext) { }
        public override void Regenerate(JetBrains.ReSharper.Psi.Impl.Shared.InjectedPsi.IndependentInjectedNodeContext nodeContext) { }
    }
    public class static ResJsonReader
    {
        public static System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.JavaScript.Tree.IObjectPropertyInitializer> GetItemsByName(JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptFile file, string name, out JetBrains.ReSharper.Psi.JavaScript.Tree.IObjectLiteral objectLiteral) { }
        public static bool IsResourceItem(JetBrains.ReSharper.Psi.JavaScript.Tree.IObjectPropertyInitializer initializer) { }
        public static bool IsResourceItem(string name, string declaredName) { }
        public static bool IsResourceItemComment(string name, string declaredName) { }
        public static bool IsResourceItemOrComment([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.JavaScript.Tree.IObjectPropertyDeclaration declaration, string name) { }
    }
    [JetBrains.ProjectModel.ProjectFileTypeAttribute(typeof(JetBrains.ProjectModel.ResJsonProjectFileType))]
    public class ResJsonResourceModificationService : JetBrains.ReSharper.I18n.Services.Services.IResourceModificationService
    {
        public void AddResourceItem(JetBrains.ReSharper.Psi.IPsiSourceFile resourceFile, string name, string value, string comment, JetBrains.ReSharper.Psi.IType type) { }
        public void ChangeResourceItem(JetBrains.ReSharper.Psi.Resx.IResourceItem resourceItem, string newValue, string newComment) { }
        public void ChangeResourceItemName(JetBrains.ReSharper.Psi.IPsiSourceFile resourceFile, string oldName, string newName) { }
        public void CopyResourceItem(JetBrains.ReSharper.Psi.Resx.IResourceItem resourceItem, JetBrains.ReSharper.Psi.IPsiSourceFile targetResourceFile, string newName) { }
        public void DeleteResourceItem(JetBrains.ReSharper.Psi.Resx.IResourceItem resourceItem) { }
        public void DeleteResourceItem(JetBrains.ReSharper.Psi.IPsiSourceFile resourceFile, string name) { }
        public void MoveResourceItem(JetBrains.ReSharper.Psi.Resx.IResourceItem resourceItem, JetBrains.ReSharper.Psi.IPsiSourceFile targetResourceFile, string newName) { }
    }
    [JetBrains.ProjectModel.ProjectFileTypeAttribute(typeof(JetBrains.ProjectModel.ResJsonProjectFileType))]
    public class ResJsonResourceProvider : JetBrains.ReSharper.I18n.Services.Services.IResourceProvider
    {
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Resx.IResourceItem> EnumerateResourceItems(JetBrains.ReSharper.Psi.IPsiSourceFile resourceFile) { }
        public string GetResourceItemComment(JetBrains.ReSharper.Psi.IPsiSourceFile resourceFile, string name) { }
        public JetBrains.ReSharper.Psi.ConstantValue GetResourceItemValue(JetBrains.ReSharper.Psi.IPsiSourceFile resourceFile, string name) { }
        public JetBrains.Util.DataStructures.CompactOneToListMap<string, JetBrains.ReSharper.Psi.Resx.IResourceItem> LoadData(JetBrains.ReSharper.Psi.IPsiSourceFile resourceFile, System.IO.BinaryReader reader) { }
        public void WriteData(JetBrains.Util.DataStructures.CompactOneToListMap<string, JetBrains.ReSharper.Psi.Resx.IResourceItem> data, System.IO.BinaryWriter writer) { }
    }
    [JetBrains.ProjectModel.ProjectFileTypeAttribute(typeof(JetBrains.ProjectModel.ResJsonProjectFileType))]
    public class ResJsonResourceService : JetBrains.ReSharper.Psi.Resx.Services.WinRTResourceServiceBase { }
}
namespace JetBrains.ReSharper.I18n.Services.JavaScript.Refactoring
{
    
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class HtmlAttributeValueToResJsonExtractor : JetBrains.ReSharper.I18n.Services.Refactoring.IResourceExtractor
    {
        public byte Priority { get; }
        public bool CanExtractTo(JetBrains.ReSharper.I18n.Services.Refactoring.ISourceElement sourceElement, JetBrains.ReSharper.Psi.IPsiSourceFile resourceFile) { }
        public bool CanUseResource(JetBrains.ReSharper.Psi.IPsiSourceFile resourceFile, JetBrains.ReSharper.Psi.Resolve.IAccessContext context) { }
        public bool Extract(JetBrains.ReSharper.I18n.Services.Refactoring.ISourceElement sourceElement, JetBrains.ReSharper.Psi.Resx.IResourceItem resourceItem, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public string GetDefaultResourceName(JetBrains.ReSharper.I18n.Services.Refactoring.ISourceElement sourceElement) { }
        public JetBrains.ReSharper.I18n.Services.Refactoring.ISourceElement GetSourceElement(JetBrains.Application.DataContext.IDataContext context) { }
        public JetBrains.ReSharper.I18n.Services.Refactoring.ISourceElement GetSourceElement(JetBrains.ReSharper.Psi.Tree.ITreeNode node) { }
        public bool IsAvailable(JetBrains.Application.DataContext.IDataContext context) { }
    }
    [JetBrains.ProjectModel.SolutionComponentAttribute()]
    public class JavaScriptExpressionToResJsonExtractor : JetBrains.ReSharper.I18n.Services.Refactoring.IResourceExtractor
    {
        public byte Priority { get; }
        public bool CanExtractTo(JetBrains.ReSharper.I18n.Services.Refactoring.ISourceElement sourceElement, JetBrains.ReSharper.Psi.IPsiSourceFile resourceFile) { }
        public bool CanUseResource(JetBrains.ReSharper.Psi.IPsiSourceFile resourceFile, JetBrains.ReSharper.Psi.Resolve.IAccessContext context) { }
        public bool Extract(JetBrains.ReSharper.I18n.Services.Refactoring.ISourceElement sourceElement, JetBrains.ReSharper.Psi.Resx.IResourceItem resourceItem, JetBrains.ReSharper.Refactorings.Workflow.IRefactoringDriver driver) { }
        public string GetDefaultResourceName(JetBrains.ReSharper.I18n.Services.Refactoring.ISourceElement sourceElement) { }
        public JetBrains.ReSharper.I18n.Services.Refactoring.ISourceElement GetSourceElement(JetBrains.Application.DataContext.IDataContext context) { }
        public JetBrains.ReSharper.I18n.Services.Refactoring.ISourceElement GetSourceElement(JetBrains.ReSharper.Psi.Tree.ITreeNode node) { }
        public bool IsAvailable(JetBrains.Application.DataContext.IDataContext context) { }
        public class SourceElement : JetBrains.ReSharper.I18n.Services.Refactoring.ISourceElement
        {
            public SourceElement(JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptLiteralExpression expression) { }
            public JetBrains.DocumentModel.DocumentRange DocumentRange { get; }
            public JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptLiteralExpression Expression { get; }
            public JetBrains.ReSharper.Psi.PsiLanguageType PsiLanguageType { get; }
            public JetBrains.ReSharper.Psi.IPsiSourceFile SourceFile { get; }
            public JetBrains.ReSharper.Psi.IType Type { get; }
            public object Value { get; }
            public bool IsValid() { }
        }
    }
}