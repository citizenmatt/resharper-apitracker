[assembly: JetBrains.ReSharper.Daemon.RegisterConfigurableSeverityAttribute("Mvc.InvalidModelType", "MVC", "CodeSmell", "Mismatch Model Type", "Mismatch ASP.NET MVC Model Type", JetBrains.ReSharper.Daemon.Severity.ERROR, false)]
[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]

namespace JetBrains.ReSharper.Daemon.Web.Highlightings.Mvc
{
    
    [JetBrains.ReSharper.Daemon.ConfigurableSeverityHighlightingAttribute("Mvc.InvalidModelType", "ASPX", AttributeId="ReSharper Underlined Error Highlighting", OverlapResolve=JetBrains.ReSharper.Daemon.OverlapResolveKind.ERROR)]
    public class MvcConfigurableInvalidModelType : JetBrains.ReSharper.Daemon.Html.Highlightings.HtmlErrorHighlighting
    {
        public const string SEVERITY_ID = "Mvc.InvalidModelType";
        public MvcConfigurableInvalidModelType(JetBrains.ReSharper.Psi.Web.Tree.IWebFileWithCodeBehind viewFile, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.Tree.IExpression argumentExpression, JetBrains.ReSharper.Psi.IDeclaredType superType, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.IType modelType, [JetBrains.Annotations.NotNullAttribute()] JetBrains.ReSharper.Psi.PsiLanguageType presentationLanguage) { }
        public JetBrains.ReSharper.Psi.Tree.IExpression ArgumentExpression { get; }
        public JetBrains.ReSharper.Psi.IType ModelType { get; }
        public JetBrains.ReSharper.Psi.IDeclaredType SuperType { get; }
        public JetBrains.ReSharper.Psi.ITreeNodePointer<JetBrains.ReSharper.Psi.Web.Tree.IWebFileWithCodeBehind> ViewFilePointer { get; }
        public override bool IsValid() { }
    }
}