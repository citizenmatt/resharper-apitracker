[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]

namespace JetBrains.ReSharper.UnitTesting.Analysis.nUnit
{
    
    [JetBrains.Application.ShellComponentAttribute()]
    public class NUnitAnalysisPatterns : JetBrains.ReSharper.Features.StructuralSearch.IPredefinedCustomPatternsSource
    {
        public NUnitAnalysisPatterns(JetBrains.ReSharper.Psi.ILanguageManager languageManager) { }
        public System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Features.StructuralSearch.IPredefinedPattern> GetPatterns() { }
    }
}
namespace JetBrains.ReSharper.UnitTesting.Analysis.nUnit.TestCaseSource
{
    
    public class TestCaseSourceReference : JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.TreeReferenceBase<JetBrains.ReSharper.Psi.Tree.ILiteralExpression>, JetBrains.ReSharper.Daemon.UsageChecking.IStringLiteralReference, JetBrains.ReSharper.Psi.Resolve.ICompleteableReference, JetBrains.ReSharper.Psi.Resolve.IReference, JetBrains.Util.IUserDataHolder
    {
        public TestCaseSourceReference(JetBrains.ReSharper.Psi.ITypeElement typeElement, JetBrains.ReSharper.Psi.Tree.ILiteralExpression literal, JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpDeclaration ownerDeclaration) { }
        public override JetBrains.ReSharper.Psi.Resolve.IReference BindTo(JetBrains.ReSharper.Psi.IDeclaredElement element) { }
        public override JetBrains.ReSharper.Psi.Resolve.IReference BindTo(JetBrains.ReSharper.Psi.IDeclaredElement element, JetBrains.ReSharper.Psi.Resolve.ISubstitution substitution) { }
        public bool Equals(JetBrains.ReSharper.UnitTesting.Analysis.nUnit.TestCaseSource.TestCaseSourceReference other) { }
        public override bool Equals(object obj) { }
        public override JetBrains.ReSharper.Psi.Resolve.IAccessContext GetAccessContext() { }
        public JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetCompletionSymbolTable() { }
        public override int GetHashCode() { }
        public override string GetName() { }
        public override JetBrains.ReSharper.Psi.Resolve.ISymbolTable GetReferenceSymbolTable(bool useReferenceName) { }
        public override JetBrains.ReSharper.Psi.TreeTextRange GetTreeTextRange() { }
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
        public event System.Action OnChanged;
        public JetBrains.ReSharper.Psi.Resolve.IReferenceFactory CreateFactory(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, JetBrains.ReSharper.Psi.Tree.IFile file) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.CSharp.CSharpLanguage))]
    public class TestCaseSourceReferenceSuggestionRule : JetBrains.ReSharper.Feature.Services.CodeCompletion.Infrastructure.ItemsProviderOfSpecificContext<JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext>
    {
        protected override JetBrains.ReSharper.Feature.Services.CodeCompletion.AutocompletionBehaviour GetAutocompletionBehaviour(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext specificContext) { }
        protected override bool IsAvailable(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context) { }
        public override bool IsEvaluationModeSupported(JetBrains.ReSharper.Feature.Services.CodeCompletion.CodeCompletionParameters parameters) { }
        protected override void TransformItems(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector) { }
    }
}