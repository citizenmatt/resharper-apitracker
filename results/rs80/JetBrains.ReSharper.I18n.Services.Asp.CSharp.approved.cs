[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]

namespace JetBrains.ReSharper.I18n.Services.Asp.CSharp.CustomReferences
{
    
    public class AspCSharpFileReference : JetBrains.ReSharper.I18n.Services.Asp.CustomReferences.AspFileReferenceBase<JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpArgument, JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpLiteralExpression>, JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.SmartCompletion.ISmartCompleatebleReference
    {
        public AspCSharpFileReference(JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpArgument owner, JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpLiteralExpression token, JetBrains.ReSharper.Psi.TreeTextRange withinRange) { }
        public AspCSharpFileReference(JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpArgument owner, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Resolve.IQualifier quilifier, JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpLiteralExpression token, JetBrains.ReSharper.Psi.TreeTextRange withinRange) { }
        public override bool CaseSensitive { get; }
        protected override string GetElementText() { }
        public JetBrains.ReSharper.Psi.IPsiSourceFile GetResourceFile() { }
        public override JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetSymbolTable(JetBrains.ReSharper.Psi.Resolve.SymbolTableMode mode) { }
        public override JetBrains.ReSharper.Psi.TreeTextRange GetTreeTextRange() { }
        protected override JetBrains.ReSharper.Psi.Resolve.IReference SetNewValue(string newName, string tokenText) { }
    }
    public class AspCSharpFolderReference : JetBrains.ReSharper.I18n.Services.Asp.CustomReferences.AspFolderReferenceBase<JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpArgument, JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpLiteralExpression>, JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.SmartCompletion.ISmartCompleatebleReference
    {
        public AspCSharpFolderReference(JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpArgument owner, JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpLiteralExpression token, JetBrains.ReSharper.Psi.TreeTextRange withinRange) { }
        public AspCSharpFolderReference(JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpArgument owner, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Resolve.IQualifier quilifier, JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpLiteralExpression token, JetBrains.ReSharper.Psi.TreeTextRange withinRange) { }
        protected override string GetElementText() { }
        public override JetBrains.ReSharper.Psi.ITypeElement GetQualifierTypeElement() { }
        public override JetBrains.ReSharper.Psi.TreeTextRange GetTreeTextRange() { }
        protected override JetBrains.ReSharper.Psi.Resolve.IReference SetNewValue(string newName, string tokenText) { }
    }
    public class AspCSharpResourceReference : JetBrains.ReSharper.I18n.Services.CSharp.CustomReferences.CSharpResourceReference
    {
        public AspCSharpResourceReference(JetBrains.ReSharper.Psi.TreeTextRange withinRange, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpArgument owner, JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpExpression token) { }
        protected override JetBrains.ReSharper.Psi.Resolve.IReference BindToInternal(JetBrains.ReSharper.Psi.IDeclaredElement element, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution) { }
    }
    public class CSharpGlobalResourceItemReference : JetBrains.ReSharper.I18n.Services.Asp.CustomReferences.GlobalResourceItemReference<JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpArgument, JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpExpression>, JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.SmartCompletion.ISmartCompleatebleReference
    {
        public CSharpGlobalResourceItemReference(JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpArgument owner, JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpExpression token, JetBrains.ReSharper.Psi.TreeTextRange withinRange) { }
        protected override JetBrains.ReSharper.Psi.Resolve.IReference BindToInternal(JetBrains.ReSharper.Psi.IDeclaredElement element, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution) { }
        protected override string GetElementText() { }
        public override JetBrains.ReSharper.Psi.Resolve.IQualifier GetQualifier() { }
        public override JetBrains.ReSharper.Psi.TreeTextRange GetTreeTextRange() { }
    }
    public class CSharpGlobalResourceReference : JetBrains.ReSharper.I18n.Services.Asp.CustomReferences.GlobalResourceReference<JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpArgument, JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpExpression>, JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.SmartCompletion.ISmartCompleatebleReference
    {
        public CSharpGlobalResourceReference(JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpArgument owner, JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpExpression token, JetBrains.ReSharper.Psi.TreeTextRange withinRange) { }
        public override bool CaseSensitive { get; }
        protected override JetBrains.ReSharper.Psi.Resolve.IReference BindToInternal(JetBrains.ReSharper.Psi.IDeclaredElement element, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution) { }
        protected override string GetElementText() { }
        public override JetBrains.ReSharper.Psi.TreeTextRange GetTreeTextRange() { }
    }
    public class CSharpLocalResourceReference : JetBrains.ReSharper.I18n.Services.Asp.CustomReferences.LocalResourceReference<JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpArgument, JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpExpression>, JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.SmartCompletion.ISmartCompleatebleReference
    {
        public CSharpLocalResourceReference(JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpArgument owner, JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpExpression token, JetBrains.ReSharper.Psi.TreeTextRange withinRange) { }
        public CSharpLocalResourceReference(JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpArgument owner, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Resolve.IQualifier quilifier, JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpExpression token, JetBrains.ReSharper.Psi.TreeTextRange withinRange) { }
        protected override JetBrains.ReSharper.Psi.Resolve.IReference BindToInternal(JetBrains.ReSharper.Psi.IDeclaredElement element, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution) { }
        protected override string GetElementText() { }
        public override JetBrains.ReSharper.Psi.ITypeElement GetQualifierTypeElement() { }
        public override JetBrains.ReSharper.Psi.Resolve.Staticness GetStaticness() { }
        public override JetBrains.ReSharper.Psi.TreeTextRange GetTreeTextRange() { }
    }
    public class CSharpLocalResourceReference4HttpContext : JetBrains.ReSharper.I18n.Services.Asp.CSharp.CustomReferences.CSharpLocalResourceReference
    {
        public CSharpLocalResourceReference4HttpContext(JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpArgument owner, JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpExpression token, JetBrains.ReSharper.Psi.TreeTextRange withinRange) { }
        public CSharpLocalResourceReference4HttpContext(JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpArgument owner, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Resolve.IQualifier quilifier, JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpExpression token, JetBrains.ReSharper.Psi.TreeTextRange withinRange) { }
        protected override JetBrains.ProjectModel.IProjectFile GetAspFile() { }
        public override JetBrains.ReSharper.Psi.Resolve.IQualifier GetQualifier() { }
        public override JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.ResolveResultWithInfo Resolve(JetBrains.ReSharper.Psi.Resolve.ISymbolTable symbolTable, JetBrains.ReSharper.Psi.Resolve.IAccessContext context) { }
    }
    public class CSharpPropertyReference : JetBrains.ReSharper.I18n.Services.Asp.CustomReferences.PropertyReference<JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpArgument, JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpExpression>, JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.SmartCompletion.ISmartCompleatebleReference
    {
        public CSharpPropertyReference(JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpArgument owner, JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpExpression token, JetBrains.ReSharper.Psi.TreeTextRange withinRange, int argumentObjTypeIndex) { }
        protected override JetBrains.ReSharper.Psi.Tree.IArgument FindArgument(JetBrains.ReSharper.Psi.Tree.ITreeNode element, string name) { }
    }
}
namespace JetBrains.ReSharper.I18n.Services.Asp.CSharp.CustomReferences.Mvc
{
    
    public class CSharpMvcGlobalResourceItemReference : JetBrains.ReSharper.I18n.Services.Asp.CSharp.CustomReferences.CSharpGlobalResourceItemReference
    {
        public CSharpMvcGlobalResourceItemReference(JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpArgument owner, JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpExpression token, JetBrains.ReSharper.Psi.TreeTextRange withinRange) { }
        protected override JetBrains.ReSharper.Psi.Resolve.IReference BindToInternal(JetBrains.ReSharper.Psi.IDeclaredElement element, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution) { }
    }
    public class CSharpMvcLocalResourceReference4HttpContext : JetBrains.ReSharper.I18n.Services.Asp.CSharp.CustomReferences.CSharpLocalResourceReference4HttpContext
    {
        public CSharpMvcLocalResourceReference4HttpContext(JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpArgument owner, JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpExpression token, JetBrains.ReSharper.Psi.TreeTextRange withinRange) { }
        public CSharpMvcLocalResourceReference4HttpContext(JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpArgument owner, [JetBrains.Annotations.CanBeNullAttribute()] JetBrains.ReSharper.Psi.Resolve.IQualifier quilifier, JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpExpression token, JetBrains.ReSharper.Psi.TreeTextRange withinRange) { }
        protected override JetBrains.ReSharper.Psi.Resolve.IReference BindToInternal(JetBrains.ReSharper.Psi.IDeclaredElement element, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution) { }
    }
}
namespace JetBrains.ReSharper.I18n.Services.Asp.CSharp.Generation
{
    
    [JetBrains.ReSharper.Psi.ExtensionsAPI.GeneratedDocumentServiceAttribute(typeof(JetBrains.ProjectModel.ResxProjectFileType))]
    public class ResxCSharpCodeWrapperGeneratedDocumentService : JetBrains.ReSharper.I18n.Services.Asp.Generation.ResxCodeWrapperGeneratedDocumentService
    {
        public override JetBrains.ReSharper.Psi.PsiLanguageType GeneratedLanguage { get; }
        protected override System.CodeDom.Compiler.CodeDomProvider GetCodeDomProvider() { }
    }
}