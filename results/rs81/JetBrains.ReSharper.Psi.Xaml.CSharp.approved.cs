[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]

namespace JetBrains.ReSharper.Psi.Xaml.CSharp.Impl.Resolve
{
    
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.CSharp.CSharpLanguage))]
    public class XamlCSharpFunctionResolver : JetBrains.ReSharper.Psi.Xaml.Impl.Resolve.IXamlFunctionResolver
    {
        public JetBrains.ReSharper.Psi.ExtensionsAPI.Resolve.ResolveResultWithInfo ResolveMethod(JetBrains.ReSharper.Psi.Xaml.Tree.IXamlFunctionReference functionReference, bool filterByName, JetBrains.ReSharper.Psi.Resolve.ISymbolTable symbolTable, JetBrains.ReSharper.Psi.Resolve.IAccessContext context) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.CSharp.CSharpLanguage))]
    public class XamlCSharpMethodGroupConvertibleFilterFactory : JetBrains.ReSharper.Psi.Xaml.Impl.Resolve.IXamlMethodGroupConvertibleFilterFactory
    {
        public JetBrains.ReSharper.Psi.Resolve.SimpleSymbolFilter CreateMethodGroupConvertibleFilter(JetBrains.ReSharper.Psi.Tree.ITreeNode context, JetBrains.ReSharper.Psi.DeclaredElementInstance<JetBrains.ReSharper.Psi.IDelegate> eventTypeInstance) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.CSharp.CSharpLanguage))]
    public class XamlCSharpModifiersSupport : JetBrains.ReSharper.Psi.Xaml.Impl.Resolve.IXamlModifiersSupport
    {
        public string InternalString { get; }
        public string PrivateString { get; }
        public string ProtectedString { get; }
        public string PublicString { get; }
        public System.Collections.Generic.IEqualityComparer<string> GetModifierComparer(JetBrains.ReSharper.Psi.Tree.ITreeNode context) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.CSharp.CSharpLanguage))]
    public class XamlCSharpTypeConversionRuleProvider : JetBrains.ReSharper.Psi.Xaml.Impl.Util.IXamlCodeBehindTypeConversionRuleProvider
    {
        public JetBrains.ReSharper.Psi.ITypeConversionRule GetTypeConversionRule(JetBrains.ReSharper.Psi.Tree.ITreeNode xamlNode) { }
    }
}