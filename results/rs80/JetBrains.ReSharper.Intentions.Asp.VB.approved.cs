[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]

namespace JetBrains.ReSharper.Intentions.Asp.VB.QuickFixes
{
    
    [JetBrains.ReSharper.Feature.Services.Bulbs.QuickFixAttribute()]
    public class AspOptimizeImportsFix : JetBrains.ReSharper.Intentions.VB.QuickFixes.OptimizeImportsFix
    {
        public AspOptimizeImportsFix(JetBrains.ReSharper.Daemon.Asp.VB.Highlightings.AspUnusedImportClauseWarning warning) { }
    }
}
namespace JetBrains.ReSharper.Intentions.Asp.VB.QuickFixes.Mvc
{
    
    [JetBrains.ReSharper.Feature.Services.Bulbs.QuickFixAttribute()]
    public class CastInModelArgumentFix : JetBrains.ReSharper.Intentions.VB.QuickFixes.CastFix
    {
        public CastInModelArgumentFix(JetBrains.ReSharper.Daemon.Web.Highlightings.Mvc.MvcConfigurableInvalidModelType error) { }
        protected override System.Nullable<bool> IsValidTryCast(JetBrains.ReSharper.Psi.VB.Tree.IVBExpression vbExpression, JetBrains.ReSharper.Psi.IType targetType) { }
        protected override System.Collections.Generic.IEnumerable<JetBrains.Util.Pair<JetBrains.ReSharper.Psi.VB.Tree.IVBExpression, JetBrains.ReSharper.Psi.IType>> ToVB(System.Collections.Generic.IEnumerable<JetBrains.Util.Pair<JetBrains.ReSharper.Psi.Tree.IExpression, JetBrains.ReSharper.Psi.IType>> src) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.VB.VBLanguage))]
    public class VbMvcLanguageHelper : JetBrains.ReSharper.Intentions.Asp.QuickFixes.Mvc.GenericMvcLanguageHelper
    {
        public override JetBrains.ReSharper.Psi.IType GetAssigmentType(JetBrains.ReSharper.Psi.Tree.IExpression expression) { }
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Tree.IDeclaration> GetAttributeDeclarations(JetBrains.ReSharper.Psi.Tree.IArgumentsOwner node) { }
        public override bool IsAttribute(JetBrains.ReSharper.Psi.Tree.IArgumentsOwner node) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.VB.VBLanguage))]
    public class VbMvcQuickFixTemplateProvider : JetBrains.ReSharper.Intentions.Asp.QuickFixes.Mvc.MvcQuickFixTemplateProviderBase
    {
        public override System.Guid GetTemplateGuid(bool viewPage, bool withMasterpage) { }
    }
}