[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]

namespace JetBrains.ReSharper.Psi.Services.JavaScript.ExpressionSelection
{
    
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.JavaScript.LanguageImpl.JavaScriptLanguage))]
    public class JavaScriptExpressionSelectionProvider : JetBrains.ReSharper.Psi.Services.ExpressionSelection.ExpressionSelectionProviderBase<JetBrains.ReSharper.Psi.JavaScript.Tree.IJavaScriptExpression>
    {
        protected override bool IsTokenSkipped(JetBrains.ReSharper.Psi.Tree.ITokenNode token) { }
    }
}