[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]

namespace JetBrains.ReSharper.I18n.Services.Asp.VB.CustomReferences
{
    
    public class AspVBFileReference : JetBrains.ReSharper.I18n.Services.Asp.CustomReferences.AspFileReferenceBase<JetBrains.ReSharper.Psi.VB.Tree.IVBArgument, JetBrains.ReSharper.Psi.VB.Tree.IVBLiteralExpression>, JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.ISmartCompleatebleReference, JetBrains.ReSharper.Psi.Resolve.ICompleteableReference, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.Util.IUserDataHolder
    {
        public AspVBFileReference(JetBrains.ReSharper.Psi.VB.Tree.IVBArgument owner, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Resolve.IQualifier quilifier, JetBrains.ReSharper.Psi.VB.Tree.IVBLiteralExpression token, JetBrains.ReSharper.Psi.TreeTextRange withinRange) { }
        public override bool CaseSensitive { get; }
        protected override string GetElementText() { }
        public JetBrains.ReSharper.Psi.IPsiSourceFile GetResourceFile() { }
        public override JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetSymbolTable(JetBrains.ReSharper.Psi.Resolve.SymbolTableMode mode) { }
        public override JetBrains.ReSharper.Psi.TreeTextRange GetTreeTextRange() { }
        protected override JetBrains.ReSharper.Psi.Resolve.IReference SetNewValue(string newName, string tokenText) { }
    }
    public class AspVBFolderReference : JetBrains.ReSharper.I18n.Services.Asp.CustomReferences.AspFolderReferenceBase<JetBrains.ReSharper.Psi.VB.Tree.IVBArgument, JetBrains.ReSharper.Psi.VB.Tree.IVBLiteralExpression>, JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.ISmartCompleatebleReference, JetBrains.ReSharper.Psi.Resolve.ICompleteableReference, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.Util.IUserDataHolder
    {
        public AspVBFolderReference(JetBrains.ReSharper.Psi.VB.Tree.IVBArgument owner, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Resolve.IQualifier quilifier, JetBrains.ReSharper.Psi.VB.Tree.IVBLiteralExpression token, JetBrains.ReSharper.Psi.TreeTextRange withinRange) { }
        protected override string GetElementText() { }
        public override JetBrains.ReSharper.Psi.TreeTextRange GetTreeTextRange() { }
        protected override JetBrains.ReSharper.Psi.Resolve.IReference SetNewValue(string newName, string tokenText) { }
    }
    public class AspVBResourceReference : JetBrains.ReSharper.I18n.Services.VB.CustomReferences.VBResourceReference
    {
        public AspVBResourceReference(JetBrains.ReSharper.Psi.TreeTextRange withinRange, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.VB.Tree.IExpressionArgument owner, JetBrains.ReSharper.Psi.VB.Tree.IVBExpression token) { }
        protected override JetBrains.ReSharper.Psi.Resolve.IReference BindToInternal(JetBrains.ReSharper.Psi.IDeclaredElement element, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution) { }
    }
    public class VBGlobalResourceItemReference : JetBrains.ReSharper.I18n.Services.Asp.CustomReferences.GlobalResourceItemReference<JetBrains.ReSharper.Psi.VB.Tree.IExpressionArgument, JetBrains.ReSharper.Psi.VB.Tree.IVBExpression>, JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.ISmartCompleatebleReference, JetBrains.ReSharper.Psi.Resolve.ICompleteableReference, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.Util.IUserDataHolder
    {
        public VBGlobalResourceItemReference([JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.VB.Tree.IExpressionArgument owner, JetBrains.ReSharper.Psi.VB.Tree.IVBExpression token, JetBrains.ReSharper.Psi.TreeTextRange range) { }
        protected override JetBrains.ReSharper.Psi.Resolve.IReference BindToInternal(JetBrains.ReSharper.Psi.IDeclaredElement element, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution) { }
        protected override string GetElementText() { }
        public override JetBrains.ReSharper.Psi.Resolve.IQualifier GetQualifier() { }
        public override JetBrains.ReSharper.Psi.TreeTextRange GetTreeTextRange() { }
    }
    public class VBGlobalResourceReference : JetBrains.ReSharper.I18n.Services.Asp.CustomReferences.GlobalResourceReference<JetBrains.ReSharper.Psi.VB.Tree.IExpressionArgument, JetBrains.ReSharper.Psi.VB.Tree.IVBExpression>, JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.ISmartCompleatebleReference, JetBrains.ReSharper.Psi.Resolve.ICompleteableReference, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.Util.IUserDataHolder
    {
        public VBGlobalResourceReference(JetBrains.ReSharper.Psi.VB.Tree.IExpressionArgument owner, JetBrains.ReSharper.Psi.VB.Tree.IVBExpression token, JetBrains.ReSharper.Psi.TreeTextRange withinRange) { }
        public override bool CaseSensitive { get; }
        protected override JetBrains.ReSharper.Psi.Resolve.IReference BindToInternal(JetBrains.ReSharper.Psi.IDeclaredElement element, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution) { }
        protected override string GetElementText() { }
        public override JetBrains.ReSharper.Psi.TreeTextRange GetTreeTextRange() { }
    }
    public class VBLocalResourceReference : JetBrains.ReSharper.I18n.Services.Asp.CustomReferences.LocalResourceReference<JetBrains.ReSharper.Psi.VB.Tree.IVBArgument, JetBrains.ReSharper.Psi.VB.Tree.IVBExpression>, JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.ISmartCompleatebleReference, JetBrains.ReSharper.Psi.Resolve.ICompleteableReference, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.Util.IUserDataHolder
    {
        public VBLocalResourceReference(JetBrains.ReSharper.Psi.VB.Tree.IVBArgument owner, JetBrains.ReSharper.Psi.VB.Tree.IVBExpression token, JetBrains.ReSharper.Psi.TreeTextRange withinRange) { }
        protected override JetBrains.ReSharper.Psi.Resolve.IReference BindToInternal(JetBrains.ReSharper.Psi.IDeclaredElement element, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution) { }
        protected override string GetElementText() { }
        public override JetBrains.ReSharper.Psi.ITypeElement GetQualifierTypeElement() { }
        public override JetBrains.ReSharper.Psi.Resolve.Staticness GetStaticness() { }
        public override JetBrains.ReSharper.Psi.TreeTextRange GetTreeTextRange() { }
    }
    public class VBLocalResourceReference4HttpContext : JetBrains.ReSharper.I18n.Services.Asp.VB.CustomReferences.VBLocalResourceReference
    {
        public VBLocalResourceReference4HttpContext(JetBrains.ReSharper.Psi.VB.Tree.IVBArgument owner, JetBrains.ReSharper.Psi.VB.Tree.IVBExpression token, JetBrains.ReSharper.Psi.TreeTextRange withinRange) { }
        protected override JetBrains.ProjectModel.IProjectFile GetAspFile() { }
        public override JetBrains.ReSharper.Psi.Resolve.IQualifier GetQualifier() { }
        public override JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.ResolveResultWithInfo Resolve(JetBrains.ReSharper.Psi.Resolve.ISymbolTable symbolTable, JetBrains.ReSharper.Psi.Resolve.IAccessContext context) { }
    }
    public class VBPropertyReference : JetBrains.ReSharper.I18n.Services.Asp.CustomReferences.PropertyReference<JetBrains.ReSharper.Psi.VB.Tree.IVBArgument, JetBrains.ReSharper.Psi.VB.Tree.IVBExpression>, JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.ISmartCompleatebleReference, JetBrains.ReSharper.Psi.Resolve.ICompleteableReference, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.Util.IUserDataHolder
    {
        public VBPropertyReference(JetBrains.ReSharper.Psi.VB.Tree.IVBArgument owner, JetBrains.ReSharper.Psi.VB.Tree.IVBExpression token, JetBrains.ReSharper.Psi.TreeTextRange withinRange, int argumentObjTypeIndex) { }
        protected override JetBrains.ReSharper.Psi.Tree.IArgument FindArgument(JetBrains.ReSharper.Psi.Tree.ITreeNode element, string name) { }
    }
}