[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]

namespace JetBrains.ReSharper.I18n.Services.Asp.ContextActions
{
    
    [JetBrains.ReSharper.Feature.Services.Bulbs.ContextActionAttribute(Description="Moves selection html to resource", Group="ASP.NET", Name="Move html to resource")]
    public class MoveHtmlToResourceAction : JetBrains.ReSharper.Intentions.Extensibility.IBulbAction, JetBrains.ReSharper.Intentions.Extensibility.IContextAction
    {
        public MoveHtmlToResourceAction(JetBrains.ReSharper.Feature.Services.Html.Bulbs.IWebContextActionDataProvider<JetBrains.ReSharper.Psi.Asp.Tree.IAspFile> dataProvider) { }
        public JetBrains.ReSharper.Intentions.Extensibility.IBulbAction[] Items { get; }
        public string Text { get; }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Intentions.Extensibility.IntentionAction> CreateBulbItems() { }
        public void Execute(JetBrains.ProjectModel.ISolution solution, JetBrains.TextControl.ITextControl textControl) { }
        public bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
}
namespace JetBrains.ReSharper.I18n.Services.Asp.CustomReferences
{
    
    public abstract class AspFileReferenceBase<TOwner, TToken> : JetBrains.ReSharper.Psi.Resx.Impl.Tree.References.QualifiableReferenceWithTokenBase<TOwner, TToken>, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IQualifiableReferenceBase, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IQualifiableReferenceWithGlobalSymbolTable, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IReferenceWithGlobalSymbolTable, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IReferenceWithQualifier, JetBrains.ReSharper.Psi.Resolve.ICompleteableReference, JetBrains.ReSharper.Psi.Resolve.IFileReference, JetBrains.ReSharper.Psi.Resolve.IPathReference, JetBrains.ReSharper.Psi.Resolve.IQualifier, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.Util.IUserDataHolder
        where TOwner : JetBrains.ReSharper.Psi.Tree.ITreeNode
        where TToken :  class, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        protected AspFileReferenceBase(TOwner owner, TToken token, JetBrains.ReSharper.Psi.TreeTextRange withinRange) { }
        protected AspFileReferenceBase(TOwner owner, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Resolve.IQualifier quilifier, TToken token, JetBrains.ReSharper.Psi.TreeTextRange withinRange) { }
        public virtual System.Collections.Generic.ICollection<string> ExpectedExtensions { get; }
        public virtual JetBrains.ProjectModel.ProjectFileType ExpectedFileType { get; }
        public bool Resolved { get; }
        protected override JetBrains.ReSharper.Psi.Resolve.IReference BindToInternal(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution) { }
        public JetBrains.Util.FileSystemPath GetBasePath() { }
        protected override JetBrains.ReSharper.Psi.Resolve.ISymbolFilter[] GetCompletionFilters() { }
        public JetBrains.ReSharper.Psi.Resolve.QualifierKind GetKind() { }
        public JetBrains.ReSharper.Psi.Resolve.ISymbolFilter[] GetPathFilters() { }
        public override JetBrains.ReSharper.Psi.ITypeElement GetQualifierTypeElement() { }
        public override JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetReferenceSymbolTable(bool useReferenceName) { }
        protected override JetBrains.ReSharper.Psi.Resolve.ISymbolFilter[] GetSmartSymbolFilters() { }
        public override JetBrains.ReSharper.Psi.Resolve.Staticness GetStaticness() { }
        public override JetBrains.ReSharper.Psi.Resolve.ISymbolFilter[] GetSymbolFilters() { }
        public virtual JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetSymbolTable(JetBrains.ReSharper.Psi.Resolve.SymbolTableMode mode) { }
        public override JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.ResolveResultWithInfo Resolve(JetBrains.ReSharper.Psi.Resolve.ISymbolTable symbolTable, JetBrains.ReSharper.Psi.Resolve.IAccessContext context) { }
        protected abstract JetBrains.ReSharper.Psi.Resolve.IReference SetNewValue(string newName, string tokenText);
    }
    public abstract class AspFolderReferenceBase<TOwner, TToken> : JetBrains.ReSharper.Psi.Resx.Impl.Tree.References.QualifiableReferenceWithTokenBase<TOwner, TToken>, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IQualifiableReferenceBase, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IQualifiableReferenceWithGlobalSymbolTable, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IReferenceWithGlobalSymbolTable, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IReferenceWithQualifier, JetBrains.ReSharper.Psi.Resolve.ICompleteableReference, JetBrains.ReSharper.Psi.Resolve.IPathReference, JetBrains.ReSharper.Psi.Resolve.IQualifier, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.Util.IUserDataHolder
        where TOwner : JetBrains.ReSharper.Psi.Tree.ITreeNode
        where TToken :  class, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        protected AspFolderReferenceBase(TOwner owner, TToken token, JetBrains.ReSharper.Psi.TreeTextRange withinRange) { }
        protected AspFolderReferenceBase(TOwner owner, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Resolve.IQualifier quilifier, TToken token, JetBrains.ReSharper.Psi.TreeTextRange withinRange) { }
        public override bool CaseSensitive { get; }
        public bool Resolved { get; }
        protected override JetBrains.ReSharper.Psi.Resolve.IReference BindToInternal(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution) { }
        public JetBrains.Util.FileSystemPath GetBasePath() { }
        protected override JetBrains.ReSharper.Psi.Resolve.ISymbolFilter[] GetCompletionFilters() { }
        public JetBrains.ReSharper.Psi.Resolve.QualifierKind GetKind() { }
        public JetBrains.ReSharper.Psi.Resolve.ISymbolFilter[] GetPathFilters() { }
        public override JetBrains.ReSharper.Psi.ITypeElement GetQualifierTypeElement() { }
        public override JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetReferenceSymbolTable(bool useReferenceName) { }
        protected override JetBrains.ReSharper.Psi.Resolve.ISymbolFilter[] GetSmartSymbolFilters() { }
        public override JetBrains.ReSharper.Psi.Resolve.Staticness GetStaticness() { }
        public override JetBrains.ReSharper.Psi.Resolve.ISymbolFilter[] GetSymbolFilters() { }
        public JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetSymbolTable(JetBrains.ReSharper.Psi.Resolve.SymbolTableMode mode) { }
        public override JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.ResolveResultWithInfo Resolve(JetBrains.ReSharper.Psi.Resolve.ISymbolTable symbolTable, JetBrains.ReSharper.Psi.Resolve.IAccessContext context) { }
        protected abstract JetBrains.ReSharper.Psi.Resolve.IReference SetNewValue(string newName, string tokenText);
    }
    public abstract class GlobalResourceItemReference<TOwner, TToken> : JetBrains.ReSharper.Psi.Resx.Impl.Tree.References.QualifiableReferenceWithTokenBase<TOwner, TToken>, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.ICheckedReference, JetBrains.ReSharper.Psi.Resolve.ICompleteableReference, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.ReSharper.Psi.Resx.Tree.IResourceItemReference, JetBrains.ReSharper.Psi.Resx.Tree.IResourceReference, JetBrains.Util.IUserDataHolder
        where TOwner : JetBrains.ReSharper.Psi.Tree.ITreeNode
        where TToken :  class, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        protected GlobalResourceItemReference(TOwner owner, TToken token, JetBrains.ReSharper.Psi.TreeTextRange withinRange) { }
        protected GlobalResourceItemReference(TOwner owner, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Resolve.IQualifier quilifier, TToken token, JetBrains.ReSharper.Psi.TreeTextRange withinRange) { }
        public virtual bool CaseSensitive { get; }
        public System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.IPsiSourceFile> FindResourceFiles() { }
        public string GetDefaultName() { }
        public override JetBrains.ReSharper.Psi.ITypeElement GetQualifierTypeElement() { }
        public override JetBrains.ReSharper.Psi.Resolve.Staticness GetStaticness() { }
        public override JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.ResolveResultWithInfo Resolve(JetBrains.ReSharper.Psi.Resolve.ISymbolTable symbolTable, JetBrains.ReSharper.Psi.Resolve.IAccessContext context) { }
    }
    public abstract class GlobalResourceReference<TOwner, TToken> : JetBrains.ReSharper.Psi.Resx.Impl.Tree.References.ReferenceWithTokenBase<TOwner, TToken>, JetBrains.ReSharper.I18n.Services.Asp.CustomReferences.IGlobalResourceReference, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.ICheckedReference, JetBrains.ReSharper.Psi.Resolve.IQualifier, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.ReSharper.Psi.Resx.Tree.IResourceReference, JetBrains.Util.IUserDataHolder
        where TOwner : JetBrains.ReSharper.Psi.Tree.ITreeNode
        where TToken :  class, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        public static System.Func<JetBrains.ProjectModel.IProject, System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.IPathDeclaredElement>> GetResourceFilesFromGlobalResourcesFolder;
        protected GlobalResourceReference(TOwner owner, TToken token, JetBrains.ReSharper.Psi.TreeTextRange withinRange) { }
        public override bool CaseSensitive { get; }
        public bool Resolved { get; }
        protected override JetBrains.ReSharper.Psi.Resolve.IReference BindToInternal(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution) { }
        public System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.IPsiSourceFile> FindResourceFiles() { }
        public static JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetGlobalResourcesSysmbolTable([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Resolve.IReference reference, System.Func<JetBrains.ProjectModel.IProject, System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.IPathDeclaredElement>> getGlobalResourceFiles) { }
        public JetBrains.ReSharper.Psi.Resolve.QualifierKind GetKind() { }
        public override JetBrains.ReSharper.Psi.ITypeElement GetQualifierTypeElement() { }
        public override JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetReferenceSymbolTable(bool useReferenceName) { }
        public override JetBrains.ReSharper.Psi.Resolve.Staticness GetStaticness() { }
        public virtual JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetSymbolTable(JetBrains.ReSharper.Psi.Resolve.SymbolTableMode mode) { }
        public override JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.ResolveResultWithInfo ResolveWithoutCache() { }
    }
    public interface IGlobalResourceReference : JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.ICheckedReference, JetBrains.ReSharper.Psi.Resolve.IQualifier, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.ReSharper.Psi.Resx.Tree.IResourceReference, JetBrains.Util.IUserDataHolder { }
    public interface ILocalResourceItemReference : JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.ICheckedReference, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IQualifiableReferenceBase, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IQualifiableReferenceWithGlobalSymbolTable, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IReferenceWithGlobalSymbolTable, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IReferenceWithQualifier, JetBrains.ReSharper.Psi.Resolve.ICompleteableReference, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.ReSharper.Psi.Resx.Tree.IResourceItemReference, JetBrains.ReSharper.Psi.Resx.Tree.IResourceReference, JetBrains.Util.IUserDataHolder { }
    public abstract class LocalResourceReference<TOwner, TToken> : JetBrains.ReSharper.Psi.Resx.Impl.Tree.References.QualifiableReferenceWithTokenBase<TOwner, TToken>, JetBrains.ReSharper.I18n.Services.Asp.CustomReferences.ILocalResourceItemReference, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.ICheckedReference, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IQualifiableReferenceBase, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IQualifiableReferenceWithGlobalSymbolTable, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IReferenceWithGlobalSymbolTable, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.IReferenceWithQualifier, JetBrains.ReSharper.Psi.Resolve.ICompleteableReference, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.ReSharper.Psi.Resx.Tree.IResourceItemReference, JetBrains.ReSharper.Psi.Resx.Tree.IResourceReference, JetBrains.Util.IUserDataHolder
        where TOwner : JetBrains.ReSharper.Psi.Tree.ITreeNode
        where TToken :  class, JetBrains.ReSharper.Psi.Tree.ITreeNode
    {
        protected LocalResourceReference(TOwner owner, TToken token, JetBrains.ReSharper.Psi.TreeTextRange withinRange) { }
        protected LocalResourceReference(TOwner owner, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Resolve.IQualifier quilifier, TToken token, JetBrains.ReSharper.Psi.TreeTextRange withinRange) { }
        public virtual bool CaseSensitive { get; }
        public virtual System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.IPsiSourceFile> FindResourceFiles() { }
        protected virtual JetBrains.ProjectModel.IProjectFile GetAspFile() { }
        public string GetDefaultName() { }
        public override JetBrains.ReSharper.Psi.Resolve.IQualifier GetQualifier() { }
        public override JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetReferenceSymbolTable(bool useReferenceName) { }
        public override JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.ResolveResultWithInfo Resolve(JetBrains.ReSharper.Psi.Resolve.ISymbolTable symbolTable, JetBrains.ReSharper.Psi.Resolve.IAccessContext context) { }
    }
    public abstract class PropertyReference<TOwner, TToken> : JetBrains.ReSharper.Psi.Resx.Impl.Tree.References.ReferenceWithTokenBase<TOwner, TToken>
        where TOwner : JetBrains.ReSharper.Psi.Tree.ITreeNode
        where TToken :  class, JetBrains.ReSharper.Psi.Tree.IExpression
    {
        protected PropertyReference(TOwner owner, TToken token, JetBrains.ReSharper.Psi.TreeTextRange withinRange) { }
        public virtual bool CaseSensitive { get; }
        protected override JetBrains.ReSharper.Psi.Resolve.IReference BindToInternal(JetBrains.ReSharper.Psi.IDeclaredElement element, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution) { }
        protected abstract JetBrains.ReSharper.Psi.Tree.IArgument FindArgument(JetBrains.ReSharper.Psi.Tree.ITreeNode element, string name);
        protected virtual JetBrains.ReSharper.Psi.IType GetArgumentType(JetBrains.ReSharper.Psi.Tree.ITreeNode element, string name) { }
        protected override string GetElementText() { }
        public override JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetReferenceSymbolTable(bool useReferenceName) { }
        public override JetBrains.ReSharper.Psi.TreeTextRange GetTreeTextRange() { }
        public override JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.ResolveResultWithInfo ResolveWithoutCache() { }
    }
}
namespace JetBrains.ReSharper.I18n.Services.Asp.CustomReferences.Impl
{
    
    public class AspGlobalResourceKeyReference : JetBrains.ReSharper.I18n.Services.Asp.CustomReferences.GlobalResourceItemReference<JetBrains.ReSharper.Psi.Asp.Tree.IAspSubstitution, JetBrains.ReSharper.Psi.Html.Tree.IHtmlToken>, JetBrains.ReSharper.Psi.Html.References.IHtmlCompleteableReference, JetBrains.ReSharper.Psi.Html.References.IHtmlSmartCompleteableReference, JetBrains.ReSharper.Psi.Resolve.ICompleteableReference, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.Util.IUserDataHolder
    {
        public AspGlobalResourceKeyReference(JetBrains.ReSharper.Psi.Asp.Tree.IAspSubstitution owner, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Resolve.IQualifier quilifier, JetBrains.ReSharper.Psi.Html.Tree.IHtmlToken token, JetBrains.ReSharper.Psi.TreeTextRange withinRange) { }
        protected override JetBrains.ReSharper.Psi.Resolve.IReference BindToInternal(JetBrains.ReSharper.Psi.IDeclaredElement element, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution) { }
        protected override string GetElementText() { }
    }
    public class AspGlobalResourceReference : JetBrains.ReSharper.I18n.Services.Asp.CustomReferences.GlobalResourceReference<JetBrains.ReSharper.Psi.Asp.Tree.IAspSubstitution, JetBrains.ReSharper.Psi.Html.Tree.IHtmlToken>, JetBrains.ReSharper.Psi.Html.References.IHtmlCompleteableReference, JetBrains.ReSharper.Psi.Html.References.IHtmlSmartCompleteableReference, JetBrains.ReSharper.Psi.Resolve.ICompleteableReference, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.Util.IUserDataHolder
    {
        public AspGlobalResourceReference(JetBrains.ReSharper.Psi.Asp.Tree.IAspSubstitution owner, JetBrains.ReSharper.Psi.Html.Tree.IHtmlToken token, JetBrains.ReSharper.Psi.TreeTextRange withinRange) { }
        public override bool CaseSensitive { get; }
        protected override JetBrains.ReSharper.Psi.Resolve.IReference BindToInternal(JetBrains.ReSharper.Psi.IDeclaredElement element, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution) { }
        protected override string GetElementText() { }
    }
    public class AspLocalResourceReference : JetBrains.ReSharper.I18n.Services.Asp.CustomReferences.LocalResourceReference<JetBrains.ReSharper.Psi.Asp.Tree.IAspSubstitution, JetBrains.ReSharper.Psi.Html.Tree.IHtmlToken>, JetBrains.ReSharper.Psi.Html.References.IHtmlCompleteableReference, JetBrains.ReSharper.Psi.Html.References.IHtmlSmartCompleteableReference, JetBrains.ReSharper.Psi.Resolve.ICompleteableReference, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.Util.IUserDataHolder
    {
        public AspLocalResourceReference(JetBrains.ReSharper.Psi.Asp.Tree.IAspSubstitution owner, JetBrains.ReSharper.Psi.Html.Tree.IHtmlToken token, JetBrains.ReSharper.Psi.TreeTextRange withinRange) { }
        protected override JetBrains.ReSharper.Psi.Resolve.IReference BindToInternal(JetBrains.ReSharper.Psi.IDeclaredElement element, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution) { }
        public override JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetCompletionSymbolTable() { }
        protected override string GetElementText() { }
        public override JetBrains.ReSharper.Psi.ITypeElement GetQualifierTypeElement() { }
        public override JetBrains.ReSharper.Psi.Resolve.Staticness GetStaticness() { }
    }
    public class ImplicitResourceUsageReference : JetBrains.ReSharper.Psi.Resx.Impl.Tree.References.ReferenceWithTokenBase<JetBrains.ReSharper.Psi.Web.Tree.IWebAttribute, JetBrains.ReSharper.Psi.Html.Tree.IHtmlToken>, JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.ICheckedReference, JetBrains.ReSharper.Psi.Html.References.IHtmlCompleteableReference, JetBrains.ReSharper.Psi.Html.References.IHtmlSmartCompleteableReference, JetBrains.ReSharper.Psi.Resolve.ICompleteableReference, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.ReSharper.Psi.Resx.Tree.IResourceItemReference, JetBrains.ReSharper.Psi.Resx.Tree.IResourceReference, JetBrains.Util.IUserDataHolder
    {
        public ImplicitResourceUsageReference(JetBrains.ReSharper.Psi.Web.Tree.IWebAttribute owner, JetBrains.ReSharper.Psi.TreeTextRange withinRange, JetBrains.ReSharper.Psi.Html.Tree.IHtmlToken token) { }
        public override bool CaseSensitive { get; }
        protected override JetBrains.ReSharper.Psi.Resolve.IReference BindToInternal(JetBrains.ReSharper.Psi.IDeclaredElement element, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution) { }
        public System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.IPsiSourceFile> FindResourceFiles() { }
        public string GetDefaultName() { }
        protected override string GetElementText() { }
        public override JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetReferenceSymbolTable(bool useReferenceName) { }
        public override JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.ResolveResultWithInfo ResolveWithoutCache() { }
    }
    public class SharepointGlobalResourceReference : JetBrains.ReSharper.I18n.Services.Asp.CustomReferences.Impl.AspGlobalResourceReference
    {
        public SharepointGlobalResourceReference(JetBrains.ReSharper.Psi.Asp.Tree.IAspSubstitution owner, JetBrains.ReSharper.Psi.Html.Tree.IHtmlToken token, JetBrains.ReSharper.Psi.TreeTextRange withinRange) { }
        public override JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetReferenceSymbolTable(bool useReferenceName) { }
    }
}
namespace JetBrains.ReSharper.I18n.Services.Asp.Generation
{
    
    public abstract class ResxCodeWrapperGeneratedDocumentService : JetBrains.ReSharper.Psi.Web.Generation.GeneratedDocumentServiceBase
    {
        public abstract JetBrains.ReSharper.Psi.PsiLanguageType GeneratedLanguage { get; }
        public override JetBrains.ReSharper.Psi.ExtensionsAPI.ISecondaryLexingProcess CreateSecondaryLexingService(JetBrains.ProjectModel.ISolution solution, JetBrains.ReSharper.Psi.Parsing.MixedLexer mixedLexer, JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile = null) { }
        public override JetBrains.ReSharper.Psi.ExtensionsAPI.ISecondaryDocumentGenerationResult Generate(JetBrains.ReSharper.Psi.Files.PrimaryFileModificationInfo modificationInfo) { }
        protected virtual JetBrains.ReSharper.Psi.Web.Generation.GenerationResults GenerateFile([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Resx.Tree.IResxFile resxFile, JetBrains.ReSharper.Psi.IPsiSourceFile resourceFile) { }
        [JetBrains.Annotations.NotNullAttribute()]
        protected abstract System.CodeDom.Compiler.CodeDomProvider GetCodeDomProvider();
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.PsiLanguageType> GetSecondaryPsiLanguageTypes(JetBrains.ProjectModel.IProject project) { }
        public override bool IsSecondaryPsiLanguageType(JetBrains.ProjectModel.IProject project, JetBrains.ReSharper.Psi.PsiLanguageType language) { }
        public override JetBrains.ReSharper.Psi.Parsing.ILexerFactory LexerFactoryWithPreprocessor(JetBrains.ReSharper.Psi.PsiLanguageType primaryLanguage) { }
        public class ResxSecondaryLexingProcess : JetBrains.ReSharper.Psi.ExtensionsAPI.ISecondaryLexingProcess
        {
            public bool CanHandle(JetBrains.ProjectModel.ProjectFileType projectFileType) { }
            public JetBrains.ReSharper.Psi.Parsing.ILexer TryCreateCodeBehindLexer(JetBrains.ReSharper.Psi.Parsing.ILexer baseLexer) { }
        }
    }
}
namespace JetBrains.ReSharper.I18n.Services.Asp.QuickFixes
{
    
    [JetBrains.ReSharper.Feature.Services.Bulbs.QuickFixAttribute()]
    public class AspCreateLocalResourceFileFromUsageFix : JetBrains.ReSharper.Intentions.Extensibility.QuickFixBase
    {
        public AspCreateLocalResourceFileFromUsageFix(JetBrains.ReSharper.I18n.Services.Daemon.ResourceItemNotResolvedWarning error) { }
        protected AspCreateLocalResourceFileFromUsageFix([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.I18n.Services.Asp.CustomReferences.ILocalResourceItemReference reference) { }
        public override string Text { get; }
        protected override void ExecuteBeforePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.ProjectModel.IProjectModelTransactionCookie cookie, JetBrains.Application.Progress.IProgressIndicator progress) { }
        protected override System.Action<JetBrains.TextControl.ITextControl> ExecutePsiTransaction(JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Progress.IProgressIndicator progress) { }
        public override bool IsAvailable(JetBrains.Util.IUserDataHolder cache) { }
    }
}
namespace JetBrains.ReSharper.I18n.Services.Asp.Searching
{
    
    public class AspMetaResourceKeySearcher : JetBrains.ReSharper.Psi.ExtensionsAPI.IDomainSpecificSearcher
    {
        public AspMetaResourceKeySearcher([JetBrains.Annotations.NotNullAttribute()] System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IResourceItemDeclaredElement> elements) { }
        public bool ProcessElement<TResult>(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.Search.IFindResultConsumer<TResult> consumer) { }
        public bool ProcessProjectItem<TResult>(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, JetBrains.ReSharper.Psi.Search.IFindResultConsumer<TResult> consumer) { }
    }
    public abstract class WebSiteGlobalResourceAccessorFinder : JetBrains.ReSharper.I18n.Services.Searching.IResourceAccessorFinder
    {
        protected WebSiteGlobalResourceAccessorFinder(JetBrains.ReSharper.I18n.Services.Searching.GeneratedFileFinder generatedFileFinder) { }
        protected abstract JetBrains.ReSharper.I18n.Services.Asp.Searching.WebSiteGlobalResourceAccessorFinder.WebSiteGlobalResourceAccessor CreateGlobalResourceAccessor(JetBrains.ReSharper.Psi.IProperty property);
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.I18n.Services.Searching.IResourceAccessor> FindAccessors(JetBrains.ReSharper.Psi.IResourceItemDeclaredElement element, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.I18n.Services.Searching.IResourceAccessor> accessors) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.ITypeElement> FindTypeElements(JetBrains.ReSharper.Psi.IPsiSourceFile resourceFile) { }
        protected abstract class WebSiteGlobalResourceAccessor : JetBrains.ReSharper.I18n.Services.Searching.IResourceAccessor
        {
            protected WebSiteGlobalResourceAccessor([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IProperty property) { }
            public JetBrains.ReSharper.Psi.IDeclaredElement DeclaredElement { get; }
            public byte Priority { get; }
            public abstract JetBrains.ReSharper.Psi.Tree.ITreeNode Replace(JetBrains.ReSharper.Psi.Tree.ITreeNode element);
        }
    }
}
namespace JetBrains.ReSharper.I18n.Services.Asp.Services
{
    
    [JetBrains.ProjectModel.ProjectFileTypeAttribute(typeof(JetBrains.ProjectModel.ResxProjectFileType))]
    public class ResxResourceService : JetBrains.ReSharper.Psi.Resx.Services.ResxResourceServiceBase
    {
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.IPsiSourceFile> GetResourcesWithAllCultures(JetBrains.ReSharper.Psi.IPsiSourceFile resourceFile) { }
        public override System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.IPsiSourceFile> GetResourcesWithCulture(JetBrains.ReSharper.Psi.IPsiSourceFile resourceFile, string cultureName) { }
        public override System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.IPsiSourceFile> GetResourcesWithSpecificCultures(JetBrains.ReSharper.Psi.IPsiSourceFile resourceFile) { }
    }
}
namespace JetBrains.ReSharper.I18n.Services.Asp
{
    
    public class static WebUtil
    {
        public const string AppGlobalResources = "App_GlobalResources";
        public const string AppLocalResources = "App_LocalResources";
        [JetBrains.Annotations.NotNullAttribute()]
        public static JetBrains.Util.FileSystemPath BuildPathToWebPageLocalResources([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IPsiSourceFile webPage) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Web.Tree.IWebAttribute> FindAspMetaResourceKeys([JetBrains.Annotations.CanBeNullAttribute()] this JetBrains.ReSharper.Psi.Tree.ITreeNode element, string name) { }
        [JetBrains.Annotations.NotNullAttribute()]
        public static System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Web.Tree.IWebAttribute> FindAspMetaResourceKeys([JetBrains.Annotations.CanBeNullAttribute()] this JetBrains.ReSharper.Psi.Tree.ITreeNode element, [JetBrains.Annotations.NotNullAttribute()] System.Predicate<JetBrains.ReSharper.Psi.Web.Tree.IWebAttribute> filter) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ProjectModel.IProjectFile FindLocalResourceByWebPage([JetBrains.Annotations.CanBeNullAttribute()] this JetBrains.ProjectModel.IProjectFile webPage) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ProjectModel.IProjectFile FindWebPageByLocalResource([JetBrains.Annotations.CanBeNullAttribute()] this JetBrains.ReSharper.Psi.IPsiSourceFile resourceFile) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ProjectModel.IProjectFolder GetAppGlobalResourcesFolder([JetBrains.Annotations.CanBeNullAttribute()] this JetBrains.ProjectModel.IProjectElement projectElement) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ProjectModel.IProjectFolder GetAppLocalResourcesFolder([JetBrains.Annotations.CanBeNullAttribute()] this JetBrains.ProjectModel.IProjectFile resourceFile) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Psi.IType GetAspElementType([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Tree.ITreeNode element) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static string GetUnquotedValue([JetBrains.Annotations.CanBeNullAttribute()] this JetBrains.ReSharper.Psi.Web.Tree.IWebAttribute element) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ReSharper.Psi.Html.Tree.IHtmlToken GetValueToken([JetBrains.Annotations.CanBeNullAttribute()] this JetBrains.ReSharper.Psi.Web.Tree.IWebAttribute element) { }
        [JetBrains.Annotations.CanBeNullAttribute()]
        public static JetBrains.ProjectModel.IProjectFile GetWebPage([JetBrains.Annotations.NotNullAttribute()] this JetBrains.ProjectModel.IProjectFile pageOrCodeFile) { }
        public static bool HaveStandartResourcesExpression([JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ProjectModel.IProject project) { }
        public static bool IsInAppGlobalResources([JetBrains.Annotations.CanBeNullAttribute()] this JetBrains.ProjectModel.IProjectFile resourceFile) { }
        public static bool IsInAppLocalResources([JetBrains.Annotations.CanBeNullAttribute()] this JetBrains.ProjectModel.IProjectFile resourceFile) { }
    }
}
namespace JetBrains.ReSharper.I18n.Services.Searching
{
    
    [JetBrains.ReSharper.Psi.PsiSharedComponentAttribute()]
    public class AspResxSearcherFactory : JetBrains.ReSharper.Psi.ExtensionsAPI.IDomainSpecificSearcherFactory
    {
        public AspResxSearcherFactory(JetBrains.ReSharper.Psi.Search.SearchDomainFactory searchDomainFactory, JetBrains.ReSharper.Psi.Resx.Services.IResourceSearchService resourceSearchService, JetBrains.ReSharper.I18n.Services.Searching.ResourceAccessorFinder resourceAccessorFinder, JetBrains.ReSharper.I18n.Services.Searching.GeneratedFileFinder generatedFileFinder) { }
        public JetBrains.ReSharper.Psi.ExtensionsAPI.IDomainSpecificSearcher CreateAnonymousTypeSearcher(System.Collections.Generic.IList<JetBrains.ReSharper.Psi.AnonymousTypeDescriptor> typeDescription, bool caseSensitive) { }
        public JetBrains.ReSharper.Psi.ExtensionsAPI.IDomainSpecificSearcher CreateConstantExpressionSearcher(JetBrains.ReSharper.Psi.ConstantValue constantValue, bool onlyLiteralExpression) { }
        public JetBrains.ReSharper.Psi.ExtensionsAPI.IDomainSpecificSearcher CreateConstructorSpecialReferenceSearcher(System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.IConstructor> constructors) { }
        public JetBrains.ReSharper.Psi.ExtensionsAPI.IDomainSpecificSearcher CreateLateBoundReferenceSearcher(System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.IDeclaredElement> elements) { }
        public JetBrains.ReSharper.Psi.ExtensionsAPI.IDomainSpecificSearcher CreateMethodsReferencedByDelegateSearcher(JetBrains.ReSharper.Psi.IDelegate @delegate) { }
        public JetBrains.ReSharper.Psi.ExtensionsAPI.IDomainSpecificSearcher CreateReferenceSearcher(System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.IDeclaredElement> elements, bool findCandidates) { }
        public JetBrains.ReSharper.Psi.ExtensionsAPI.IDomainSpecificSearcher CreateTextOccurenceSearcher(System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.IDeclaredElement> elements) { }
        public JetBrains.ReSharper.Psi.ExtensionsAPI.IDomainSpecificSearcher CreateTextOccurenceSearcher(string subject) { }
        public System.Collections.Generic.IEnumerable<string> GetAllPossibleWordsInFile(JetBrains.ReSharper.Psi.IDeclaredElement element) { }
        public JetBrains.ReSharper.Psi.Search.ISearchDomain GetDeclaredElementSearchDomain(JetBrains.ReSharper.Psi.IDeclaredElement declaredElement) { }
        public JetBrains.Util.JetTuple<System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.IDeclaredElement>, System.Predicate<JetBrains.ReSharper.Psi.Search.IFindResultReference>, bool> GetDerivedFindRequest(JetBrains.ReSharper.Psi.Search.IFindResultReference result) { }
        public JetBrains.Util.JetTuple<System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.IDeclaredElement>, bool> GetNavigateToTargets(JetBrains.ReSharper.Psi.IDeclaredElement element) { }
        public System.Collections.Generic.IEnumerable<JetBrains.Util.Pair<JetBrains.ReSharper.Psi.IDeclaredElement, System.Predicate<JetBrains.ReSharper.Psi.Search.FindResult>>> GetRelatedDeclaredElements(JetBrains.ReSharper.Psi.IDeclaredElement element) { }
        public bool IsCompatibleWithLanguage(JetBrains.ReSharper.Psi.PsiLanguageType languageType) { }
        public System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.Search.FindResult> TransformNavigationTargets(System.Collections.Generic.ICollection<JetBrains.ReSharper.Psi.Search.FindResult> targets) { }
    }
}