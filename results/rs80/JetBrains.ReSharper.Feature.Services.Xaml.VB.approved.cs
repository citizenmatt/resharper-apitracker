[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]

namespace JetBrains.ReSharper.Feature.Services.Xaml.VB.Generate
{
    
    [JetBrains.ReSharper.Feature.Services.Generate.GeneratorBuilderAttribute("EventSubscriptions", typeof(JetBrains.ReSharper.Psi.Xaml.XamlLanguage))]
    public class XamlVBEventSubscriptionsBuilder : JetBrains.ReSharper.Feature.Services.Generate.CodeBehindGeneratorBuilderBase<JetBrains.ReSharper.Intentions.Xaml.Generate.XamlGeneratorContext, JetBrains.ReSharper.Feature.Services.VB.Generate.VBGeneratorContext>
    {
        public override double Priority { get; }
        protected override JetBrains.ReSharper.Feature.Services.Generate.IGeneratorBuilder CreateCodeBehindBuilder() { }
        protected override JetBrains.ReSharper.Feature.Services.VB.Generate.VBGeneratorContext CreateCodeBehindContext(JetBrains.ReSharper.Intentions.Xaml.Generate.XamlGeneratorContext context) { }
        public override void Process(JetBrains.ReSharper.Intentions.Xaml.Generate.XamlGeneratorContext context, JetBrains.ReSharper.Feature.Services.VB.Generate.VBGeneratorContext codeBehindContext) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.Xaml.VB.Intentions
{
    
    public class VBCreateDependencyPropertyIntentionBase
    {
        protected JetBrains.ReSharper.Psi.VB.Tree.IVariableDeclaration CreateDependencyPropertyField(JetBrains.ReSharper.Feature.Services.Xaml.Intentions.CreateDependencyPropertyDeclarationContext context, string methodName, JetBrains.ReSharper.Psi.IType propertyType, JetBrains.ReSharper.Feature.Services.Intentions.Impl.TemplateFieldHolders.FindersTemplateFieldHolder typeHolder) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.Xaml.VB.LiveTemplates
{
    
    public class InXamlVBProjectFile : JetBrains.ReSharper.Feature.Services.Xaml.LiveTemplates.Scope.InXamlSpecificProject, JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.IMainScopePoint
    {
        public InXamlVBProjectFile() { }
        public override string PresentableShortName { get; }
        public string QuickListTitle { get; }
        public System.Guid QuickListUID { get; }
        public override JetBrains.ReSharper.Psi.PsiLanguageType RelatedLanguage { get; }
        public override System.Guid GetDefaultUID() { }
    }
    [JetBrains.ReSharper.Feature.Services.LiveTemplates.Support.FileTemplatesAttribute()]
    public class XamlVBFileTemplatesSupport : JetBrains.ReSharper.Feature.Services.Xaml.LiveTemplates.XamlFileTemplatesSupportBase
    {
        protected override JetBrains.ProjectModel.Properties.ProjectLanguage Language { get; }
        public override string Name { get; }
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint> ScopePoints { get; }
    }
    [JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ScopeCategoryUIProviderAttribute(Priority=-130D, ScopeFilter=JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ScopeFilter.Project)]
    public class XamlVBProjectScopeCategoryUIProvider : JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ScopeCategoryUIProvider
    {
        public XamlVBProjectScopeCategoryUIProvider() { }
        public override string CategoryCaption { get; }
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint> BuildAllPoints() { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class XamlVBProjectScopeProvider : JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ScopeProvider
    {
        public XamlVBProjectScopeProvider() { }
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint> ProvideScopePoints(JetBrains.ReSharper.Feature.Services.LiveTemplates.Context.TemplateAcceptanceContext context) { }
    }
}