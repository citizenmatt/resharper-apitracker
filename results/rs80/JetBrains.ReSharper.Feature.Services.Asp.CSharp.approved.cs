[assembly: JetBrains.UI.Icons.CompiledIcons.CompiledIconsPackAttribute(IconNames=new string[] {
        "ScopeAspcs"}, IconPackResourceIdentification="JetBrains.ReSharper.Feature.Services.Asp.CSharp;component/resources/ServicesAspCS" +
    "harpThemedIcons/ThemedIcons.ServicesAspCSharp.Generated.Xaml")]
[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]
[assembly: System.Windows.Markup.XmlnsDefinitionAttribute("urn:shemas-jetbrains-com:ui-application-icons-services-asp-csharp", "JetBrains.ReSharper.Feature.Services.Asp.CSharp.Resources")]

namespace JetBrains.ReSharper.Feature.Services.Asp.CSharp.Caches
{
    
    [JetBrains.Application.ShellComponentAttribute()]
    public class MvcCSharpCacheProcessor : JetBrains.ReSharper.Psi.CSharp.Tree.TreeNodeVisitor<JetBrains.Util.JetTuple<JetBrains.Util.OneToListMap<JetBrains.ReSharper.Feature.Services.Asp.CustomReferences.MvcViewLocationType, System.Collections.Generic.ICollection<string>>, System.Collections.Generic.IList<string>, bool>>, JetBrains.ReSharper.Feature.Services.Asp.Caches.IMvcCacheProcessor, JetBrains.ReSharper.Psi.IRecursiveElementProcessor<JetBrains.Util.JetTuple<JetBrains.Util.OneToListMap<JetBrains.ReSharper.Feature.Services.Asp.CustomReferences.MvcViewLocationType, System.Collections.Generic.ICollection<string>>, System.Collections.Generic.IList<string>, bool>>
    {
        public MvcCSharpCacheProcessor(JetBrains.DataFlow.Lifetime lifetime, JetBrains.Application.DataContext.DataContexts dataContexts) { }
        public JetBrains.ReSharper.Psi.PsiLanguageType Language { get; }
        public bool InteriorShouldBeProcessed(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.Util.JetTuple<JetBrains.Util.OneToListMap<JetBrains.ReSharper.Feature.Services.Asp.CustomReferences.MvcViewLocationType, System.Collections.Generic.ICollection<string>>, System.Collections.Generic.IList<string>, bool> context) { }
        public void ProcessAfterInterior(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.Util.JetTuple<JetBrains.Util.OneToListMap<JetBrains.ReSharper.Feature.Services.Asp.CustomReferences.MvcViewLocationType, System.Collections.Generic.ICollection<string>>, System.Collections.Generic.IList<string>, bool> context) { }
        public void ProcessBeforeInterior(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.Util.JetTuple<JetBrains.Util.OneToListMap<JetBrains.ReSharper.Feature.Services.Asp.CustomReferences.MvcViewLocationType, System.Collections.Generic.ICollection<string>>, System.Collections.Generic.IList<string>, bool> context) { }
        public override void VisitAssignmentExpression(JetBrains.ReSharper.Psi.CSharp.Tree.IAssignmentExpression assignmentExpressionParam, JetBrains.Util.JetTuple<JetBrains.Util.OneToListMap<JetBrains.ReSharper.Feature.Services.Asp.CustomReferences.MvcViewLocationType, System.Collections.Generic.ICollection<string>>, System.Collections.Generic.IList<string>, bool> context) { }
        public override void VisitInvocationExpression(JetBrains.ReSharper.Psi.CSharp.Tree.IInvocationExpression invocationExpression, JetBrains.Util.JetTuple<JetBrains.Util.OneToListMap<JetBrains.ReSharper.Feature.Services.Asp.CustomReferences.MvcViewLocationType, System.Collections.Generic.ICollection<string>>, System.Collections.Generic.IList<string>, bool> context) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.Asp.CSharp.CodeCompletion.Rules
{
    
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.CSharp.CSharpLanguage))]
    public class MvcActionCSharpTransformationRule : JetBrains.ReSharper.Feature.Services.Asp.CodeCompletion.Rules.MvcActionTransformationRule<JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext>
    {
        protected override void DecorateItems(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem> items) { }
        protected override bool IsAvailable(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context) { }
        protected override void TransformItems(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.CSharp.CSharpLanguage))]
    public class MvcControllerCSharpTransformationRule : JetBrains.ReSharper.Feature.Services.Asp.CodeCompletion.Rules.MvcControllerTransformationRule<JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext>
    {
        protected override bool IsAvailable(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context) { }
        protected override void TransformItems(JetBrains.ReSharper.Feature.Services.CSharp.CodeCompletion.Infrastructure.CSharpCodeCompletionContext context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.Asp.CSharp.CodeStructure
{
    
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.CSharp.CSharpLanguage))]
    public class SkipNodesProvider : JetBrains.ReSharper.Feature.Services.Html.CodeStructure.ISkipNodesProvider
    {
        public System.Collections.Generic.JetHashSet<JetBrains.ReSharper.Psi.Parsing.TokenNodeType> Nodes { get; }
    }
}
namespace JetBrains.ReSharper.Feature.Services.Asp.CSharp.CustomReferences
{
    
    [JetBrains.ReSharper.Psi.Resolve.ReferenceProviderFactoryAttribute()]
    public class CSharpMvcReferenceProviderFactory : JetBrains.ReSharper.Psi.Resolve.IReferenceProviderFactory
    {
        public CSharpMvcReferenceProviderFactory(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Settings.ISettingsStore settingsStore, JetBrains.ReSharper.Feature.Services.Asp.CustomReferences.MvcReferenceProviderValidator providerValidator) { }
        public event System.Action OnChanged;
        public JetBrains.ReSharper.Psi.Resolve.IReferenceFactory CreateFactory(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, JetBrains.ReSharper.Psi.Tree.IFile file) { }
    }
    [JetBrains.ReSharper.Psi.Resolve.ReferenceProviderFactoryAttribute()]
    public class CSharpPathReferenceProviderFactory : JetBrains.ReSharper.Psi.Resolve.IReferenceProviderFactory
    {
        public CSharpPathReferenceProviderFactory(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ReSharper.Psi.CodeAnnotations.CodeAnnotationsCache codeAnnotationsCache) { }
        public event System.Action OnChanged;
        public JetBrains.ReSharper.Psi.Resolve.IReferenceFactory CreateFactory(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, JetBrains.ReSharper.Psi.Tree.IFile file) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.Asp.CSharp.ExpectedTypes
{
    
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.CSharp.CSharpLanguage))]
    public class MvcCSharpExpectedTypesProvider : JetBrains.ReSharper.Psi.CSharp.ExpectedTypes.CSharpExpectedTypesProvider
    {
        public override System.Collections.Generic.IList<JetBrains.ReSharper.Psi.ExpectedTypes.ExpectedType> GetExpectedTypes(JetBrains.ReSharper.Psi.CSharp.Tree.ICSharpExpression expression, JetBrains.ReSharper.Psi.Naming.Interfaces.INamingPolicyProvider namingPolicyProvider, JetBrains.ReSharper.Psi.ExpectedTypes.ExpectedTypeMode mode = 1) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.Asp.CSharp.LiveTemplates
{
    
    [JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ScopeCategoryUIProviderAttribute(Priority=-10D, ScopeFilter=JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ScopeFilter.Project)]
    public class AspCSharpProjectScopeCategoryUIProvider : JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ScopeCategoryUIProvider
    {
        public AspCSharpProjectScopeCategoryUIProvider() { }
        public override string CategoryCaption { get; }
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint> BuildAllPoints() { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class AspCSharpProjectScopeProvider : JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ScopeProvider
    {
        public AspCSharpProjectScopeProvider() { }
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint> ProvideScopePoints(JetBrains.ReSharper.Feature.Services.LiveTemplates.Context.TemplateAcceptanceContext context) { }
    }
    public class InAspCSharpProject : JetBrains.ReSharper.Feature.Services.Asp.LiveTemplates.Scope.InLanguageSpecificWebProject, JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.IMainScopePoint, JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint
    {
        public InAspCSharpProject() { }
        public override string PresentableShortName { get; }
        public string QuickListTitle { get; }
        public System.Guid QuickListUID { get; }
        public override System.Guid GetDefaultUID() { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.Asp.CSharp.LiveTemplates.Support
{
    
    [JetBrains.ReSharper.Feature.Services.LiveTemplates.Support.FileTemplatesAttribute()]
    public class AspCSharpFileTemplatesSupport : JetBrains.ReSharper.Feature.Services.Asp.LiveTemplates.AspFileTemplatesSupportBase
    {
        protected override JetBrains.ProjectModel.Properties.ProjectLanguage Language { get; }
        public override string Name { get; }
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint> ScopePoints { get; }
    }
}
namespace JetBrains.ReSharper.Feature.Services.Asp.CSharp.Resources
{
    
    public sealed class ServicesAspCSharpThemedIcons
    {
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Feature.Services.Asp.CSharp;component/resources/ServicesAspCS" +
            "harpThemedIcons/ThemedIcons.ServicesAspCSharp.Generated.Xaml", 0, "ScopeAspcs")]
        public sealed class ScopeAspcs : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
    }
}
namespace JetBrains.ReSharper.Feature.Services.Asp.CSharp.Search
{
    
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.CSharp.CSharpLanguage))]
    public class CSharpMvcSearchSupported : JetBrains.ReSharper.Feature.Services.Asp.Search.IMvcSearchSupported { }
}