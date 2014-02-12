[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]

namespace JetBrains.ReSharper.Intentions.Asp.CSharp.QuickFixes
{
    
    [JetBrains.ReSharper.Feature.Services.Bulbs.QuickFixAttribute()]
    public class AspOptimizeImportsFix : JetBrains.ReSharper.Intentions.CSharp.QuickFixes.OptimizeImportsFix
    {
        public AspOptimizeImportsFix(JetBrains.ReSharper.Daemon.Asp.CSharp.Highlightings.AspUnusedUsingDirectiveWarning error) { }
    }
}
namespace JetBrains.ReSharper.Intentions.Asp.CSharp.QuickFixes.Mvc
{
    
    public abstract class CastInModelArgumentBase : JetBrains.ReSharper.Intentions.CSharp.QuickFixes.CastInArgumentBase
    {
        protected CastInModelArgumentBase(JetBrains.ReSharper.Daemon.Web.Highlightings.Mvc.MvcConfigurableInvalidModelType highlighting) { }
        protected virtual bool AsCast { get; }
        protected override bool IsValid { get; }
        protected override JetBrains.Util.Pair<, >[] PossibleTypes(JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpExpression expression) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.QuickFixAttribute()]
    public class CastInModelArgumentFix : JetBrains.ReSharper.Intentions.Asp.CSharp.QuickFixes.Mvc.CastInModelArgumentBase
    {
        public CastInModelArgumentFix(JetBrains.ReSharper.Daemon.Web.Highlightings.Mvc.MvcConfigurableInvalidModelType highlighting) { }
        protected override bool AsCast { get; }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.CSharp.CSharpLanguage))]
    public class CSharpMvcLanguageHelper : JetBrains.ReSharper.Intentions.Asp.QuickFixes.Mvc.GenericMvcLanguageHelper
    {
        public override JetBrains.ReSharper.Psi.IType GetAssigmentType(JetBrains.ReSharper.Psi.Tree.IExpression expression) { }
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Psi.Tree.IDeclaration> GetAttributeDeclarations(JetBrains.ReSharper.Psi.Tree.IArgumentsOwner node) { }
        public override bool IsAttribute(JetBrains.ReSharper.Psi.Tree.IArgumentsOwner node) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.CSharp.CSharpLanguage))]
    public class CSharpMvcQuickFixTemplateProvider : JetBrains.ReSharper.Intentions.Asp.QuickFixes.Mvc.MvcQuickFixTemplateProviderBase
    {
        public override System.Guid GetTemplateGuid(bool viewPage, bool withMasterpage) { }
    }
    [JetBrains.ReSharper.Feature.Services.Bulbs.QuickFixAttribute()]
    public class SafeCastInModelArgumentFix : JetBrains.ReSharper.Intentions.Asp.CSharp.QuickFixes.Mvc.CastInModelArgumentBase
    {
        public SafeCastInModelArgumentFix(JetBrains.ReSharper.Daemon.Web.Highlightings.Mvc.MvcConfigurableInvalidModelType highlighting) { }
        protected override bool AsCast { get; }
    }
}