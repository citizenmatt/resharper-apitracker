[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]

namespace JetBrains.ReSharper.Feature.Services.Xaml.CSharp.Intentions
{
    
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.CSharp.CSharpLanguage))]
    public class CSharpCreateAttachedPropertyIntention : JetBrains.ReSharper.Feature.Services.Xaml.CSharp.Intentions.CSharpCreateDependencyPropertyIntentionBase, JetBrains.ReSharper.Feature.Services.Xaml.Intentions.ICreateAttachedPropertyIntention, JetBrains.ReSharper.Feature.Services.Xaml.Intentions.ICreateDependencyPropertyIntentionBase
    {
        public JetBrains.ReSharper.Feature.Services.Intentions.IntentionResult ExecuteEx(JetBrains.ReSharper.Feature.Services.Xaml.Intentions.CreateDependencyPropertyDeclarationContext context) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.CSharp.CSharpLanguage))]
    public class CSharpCreateDependencyPropertyIntention : JetBrains.ReSharper.Feature.Services.Xaml.CSharp.Intentions.CSharpCreateDependencyPropertyIntentionBase, JetBrains.ReSharper.Feature.Services.Xaml.Intentions.ICreateDependencyPropertyIntention, JetBrains.ReSharper.Feature.Services.Xaml.Intentions.ICreateDependencyPropertyIntentionBase
    {
        public JetBrains.ReSharper.Feature.Services.Intentions.IntentionResult ExecuteEx(JetBrains.ReSharper.Feature.Services.Xaml.Intentions.CreateDependencyPropertyDeclarationContext context) { }
    }
    public class CSharpCreateDependencyPropertyIntentionBase
    {
        protected JetBrains.ReSharper.Psi.CSharp.Tree.IFieldDeclaration CreateDependencyPropertyField(JetBrains.ReSharper.Feature.Services.Xaml.Intentions.CreateDependencyPropertyDeclarationContext context, string methodName, JetBrains.ReSharper.Psi.IType propertyType, JetBrains.ReSharper.Feature.Services.Intentions.Impl.TemplateFieldHolders.FindersTemplateFieldHolder typeHolder) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.Xaml.CSharp.LiveTemplates
{
    
    public class InXamlCSharpProject : JetBrains.ReSharper.Feature.Services.Xaml.LiveTemplates.Scope.InXamlSpecificProject, JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.IMainScopePoint, JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint
    {
        public InXamlCSharpProject() { }
        public override string PresentableShortName { get; }
        public string QuickListTitle { get; }
        public System.Guid QuickListUID { get; }
        public override JetBrains.ReSharper.Psi.PsiLanguageType RelatedLanguage { get; }
        public override System.Guid GetDefaultUID() { }
    }
    [JetBrains.ReSharper.Feature.Services.LiveTemplates.Support.FileTemplatesAttribute()]
    public class XamlCSharpFileTemplatesSupport : JetBrains.ReSharper.Feature.Services.Xaml.LiveTemplates.XamlFileTemplatesSupportBase
    {
        protected override JetBrains.ProjectModel.Properties.ProjectLanguage Language { get; }
        public override string Name { get; }
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint> ScopePoints { get; }
    }
    [JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ScopeCategoryUIProviderAttribute(Priority=-130D, ScopeFilter=JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ScopeFilter.Project)]
    public class XamlCSharpProjectScopeCategoryUIProvider : JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ScopeCategoryUIProvider
    {
        public XamlCSharpProjectScopeCategoryUIProvider() { }
        public override string CategoryCaption { get; }
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint> BuildAllPoints() { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class XamlCSharpProjectScopeProvider : JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ScopeProvider
    {
        public XamlCSharpProjectScopeProvider() { }
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint> ProvideScopePoints(JetBrains.ReSharper.Feature.Services.LiveTemplates.Context.TemplateAcceptanceContext context) { }
    }
}