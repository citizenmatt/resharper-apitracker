[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]

namespace JetBrains.ReSharper.UnitTesting.Analysis.VB.nUnit.TestCaseSource
{
    
    public class TestCaseSourceApplicableTypeMemberFilter : JetBrains.ReSharper.Psi.Resolve.ISymbolFilter
    {
        public TestCaseSourceApplicableTypeMemberFilter(JetBrains.ReSharper.Psi.VB.Tree.IVBDeclaration ownerDeclaration) { }
        public JetBrains.ReSharper.Psi.Resolve.ResolveErrorType ErrorType { get; }
        public JetBrains.ReSharper.Psi.Resolve.FilterRunType RunType { get; }
        public System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Resolve.ISymbolInfo> FilterArray(System.Collections.Generic.IList<JetBrains.ReSharper.Psi.Resolve.ISymbolInfo> data) { }
    }
    public class TestCaseSourceReference : JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.TreeReferenceBase<JetBrains.ReSharper.Psi.Tree.ILiteralExpression>, JetBrains.ReSharper.Daemon.UsageChecking.IStringLiteralReference, JetBrains.ReSharper.Psi.Resolve.ICompleteableReference
    {
        public TestCaseSourceReference(JetBrains.ReSharper.Psi.ITypeElement typeElement, JetBrains.ReSharper.Psi.Tree.ILiteralExpression literal, JetBrains.ReSharper.Psi.VB.Tree.IVBDeclaration ownerDeclaration) { }
        public override JetBrains.ReSharper.Psi.Resolve.IReference BindTo(JetBrains.ReSharper.Psi.IDeclaredElement element) { }
        public override JetBrains.ReSharper.Psi.Resolve.IReference BindTo(JetBrains.ReSharper.Psi.IDeclaredElement element, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution) { }
        public bool Equals(JetBrains.ReSharper.UnitTesting.Analysis.VB.nUnit.TestCaseSource.TestCaseSourceReference other) { }
        public override bool Equals(object obj) { }
        public override JetBrains.ReSharper.Psi.Resolve.IAccessContext GetAccessContext() { }
        public JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetCompletionSymbolTable() { }
        public override int GetHashCode() { }
        public override string GetName() { }
        public override JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetReferenceSymbolTable(bool useReferenceName) { }
        public override JetBrains.ReSharper.Psi.TreeTextRange GetTreeTextRange() { }
        public override bool IsValid() { }
        public override JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.ResolveResultWithInfo ResolveWithoutCache() { }
    }
    public class TestCaseSourceReferenceFactory : JetBrains.ReSharper.Psi.Resolve.IReferenceFactory
    {
        public TestCaseSourceReferenceFactory(JetBrains.ReSharper.UnitTestFramework.AttributeChecker.UnitTestAttributeCache attributeCache) { }
        public JetBrains.ReSharper.Psi.Resolve.IReference[] GetReferences(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.ReSharper.Psi.Resolve.IReference[] oldReferences) { }
        public bool HasReference(JetBrains.ReSharper.Psi.Tree.ITreeNode element, System.Collections.Generic.ICollection<string> names) { }
    }
    [JetBrains.ReSharper.Psi.Resolve.ReferenceProviderFactoryAttribute()]
    public class TestCaseSourceReferenceProviderFactory : JetBrains.ReSharper.Psi.Resolve.IReferenceProviderFactory
    {
        public TestCaseSourceReferenceProviderFactory(JetBrains.ReSharper.UnitTestFramework.AttributeChecker.UnitTestAttributeCache attributeCache) { }
        public event System.Action IReferenceProviderFactory_OnChanged;
        public JetBrains.ReSharper.Psi.Resolve.IReferenceFactory IReferenceProviderFactory_CreateFactory(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, JetBrains.ReSharper.Psi.Tree.IFile file) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.VB.VBLanguage))]
    public class TestCaseSourceReferenceSuggestionRule : JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ItemsProviderOfSpecificContext<JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextSimple>
    {
        protected override JetBrains.ReSharper.Feature.Services.CodeCompletion.AutocompletionBehaviour GetAutocompletionBehaviour(JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextSimple specificContext) { }
        protected override bool IsAvailable(JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextSimple context) { }
        protected override void TransformItems(JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextSimple context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector) { }
    }
}