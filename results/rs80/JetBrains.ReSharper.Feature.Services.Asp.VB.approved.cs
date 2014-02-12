[assembly: JetBrains.UI.Icons.CompiledIcons.CompiledIconsPackAttribute(IconNames=new string[] {
        "ScopeAspvb"}, IconPackResourceIdentification="JetBrains.ReSharper.Feature.Services.Asp.VB;component/resources/ServicesAspVBThem" +
    "edIcons/ThemedIcons.ServicesAspVB.Generated.Xaml")]
[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]
[assembly: System.Windows.Markup.XmlnsDefinitionAttribute("urn:shemas-jetbrains-com:ui-application-icons-services-asp-vb", "JetBrains.ReSharper.Feature.Services.Asp.VB.Resources")]

namespace JetBrains.ReSharper.Feature.Services.Asp.VB.Caches
{
    
    [JetBrains.Application.ShellComponentAttribute()]
    public class MvcVBCacheProcessor : JetBrains.ReSharper.Psi.VB.Tree.TreeNodeVisitor<JetBrains.Util.JetTuple<JetBrains.Util.OneToListMap<JetBrains.ReSharper.Feature.Services.Asp.CustomReferences.MvcViewLocationType, System.Collections.Generic.ICollection<string>>, System.Collections.Generic.IList<string>, bool>>, JetBrains.ReSharper.Feature.Services.Asp.Caches.IMvcCacheProcessor, JetBrains.ReSharper.Psi.IRecursiveElementProcessor<JetBrains.Util.JetTuple<JetBrains.Util.OneToListMap<JetBrains.ReSharper.Feature.Services.Asp.CustomReferences.MvcViewLocationType, System.Collections.Generic.ICollection<string>>, System.Collections.Generic.IList<string>, bool>>
    {
        public MvcVBCacheProcessor() { }
        public JetBrains.ReSharper.Psi.PsiLanguageType Language { get; }
        public bool InteriorShouldBeProcessed(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.Util.JetTuple<JetBrains.Util.OneToListMap<JetBrains.ReSharper.Feature.Services.Asp.CustomReferences.MvcViewLocationType, System.Collections.Generic.ICollection<string>>, System.Collections.Generic.IList<string>, bool> context) { }
        public bool IsProcessingFinished(JetBrains.Util.JetTuple<JetBrains.Util.OneToListMap<JetBrains.ReSharper.Feature.Services.Asp.CustomReferences.MvcViewLocationType, System.Collections.Generic.ICollection<string>>, System.Collections.Generic.IList<string>, bool> context) { }
        public void ProcessAfterInterior(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.Util.JetTuple<JetBrains.Util.OneToListMap<JetBrains.ReSharper.Feature.Services.Asp.CustomReferences.MvcViewLocationType, System.Collections.Generic.ICollection<string>>, System.Collections.Generic.IList<string>, bool> context) { }
        public void ProcessBeforeInterior(JetBrains.ReSharper.Psi.Tree.ITreeNode element, JetBrains.Util.JetTuple<JetBrains.Util.OneToListMap<JetBrains.ReSharper.Feature.Services.Asp.CustomReferences.MvcViewLocationType, System.Collections.Generic.ICollection<string>>, System.Collections.Generic.IList<string>, bool> context) { }
        public override void VisitAssignmentStatement(JetBrains.ReSharper.Psi.VB.Tree.IAssignmentStatement assignmentStatementParam, JetBrains.Util.JetTuple<JetBrains.Util.OneToListMap<JetBrains.ReSharper.Feature.Services.Asp.CustomReferences.MvcViewLocationType, System.Collections.Generic.ICollection<string>>, System.Collections.Generic.IList<string>, bool> context) { }
        public override void VisitInvocationStatement(JetBrains.ReSharper.Psi.VB.Tree.IInvocationStatement invocationStatement, JetBrains.Util.JetTuple<JetBrains.Util.OneToListMap<JetBrains.ReSharper.Feature.Services.Asp.CustomReferences.MvcViewLocationType, System.Collections.Generic.ICollection<string>>, System.Collections.Generic.IList<string>, bool> context) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.Asp.VB.CodeCompletion.Rules
{
    
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.VB.VBLanguage))]
    public class MvcActionVBTransformationRule : JetBrains.ReSharper.Feature.Services.Asp.CodeCompletion.Rules.MvcActionTransformationRule<JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextBase>
    {
        public MvcActionVBTransformationRule(JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.Rules.VBMergeMethodsRule vbMergeMethodsRule) { }
        protected override void DecorateItems(JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextBase context, System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.Lookup.ILookupItem> items) { }
        protected override bool IsAvailable(JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextBase context) { }
        protected override void TransformItems(JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextBase context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector) { }
    }
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.VB.VBLanguage))]
    public class MvcControllerVBTransformationRule : JetBrains.ReSharper.Feature.Services.Asp.CodeCompletion.Rules.MvcControllerTransformationRule<JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextBase>
    {
        protected override bool IsAvailable(JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextBase context) { }
        protected override void TransformItems(JetBrains.ReSharper.Feature.Services.VB.CodeCompletion.VBCodeCompletionContextBase context, JetBrains.ReSharper.Feature.Services.Lookup.GroupedItemsCollector collector) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.Asp.VB.CodeStructure
{
    
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.VB.VBLanguage))]
    public class SkipNodesProvider : JetBrains.ReSharper.Feature.Services.Html.CodeStructure.ISkipNodesProvider
    {
        public System.Collections.Generic.JetHashSet<JetBrains.ReSharper.Psi.Parsing.TokenNodeType> Nodes { get; }
    }
}
namespace JetBrains.ReSharper.Feature.Services.Asp.VB.CustomReferences
{
    
    [JetBrains.ReSharper.Psi.Resolve.ReferenceProviderFactoryAttribute()]
    public class VBMvcReferenceProviderFactory : JetBrains.ReSharper.Psi.Resolve.IReferenceProviderFactory
    {
        public VBMvcReferenceProviderFactory(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ProjectModel.ISolution solution, JetBrains.Application.Settings.ISettingsStore settingsStore, JetBrains.ReSharper.Feature.Services.Asp.CustomReferences.MvcReferenceProviderValidator providerValidator) { }
        public event System.Action OnChanged;
        public JetBrains.ReSharper.Psi.Resolve.IReferenceFactory CreateFactory(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, JetBrains.ReSharper.Psi.Tree.IFile file) { }
    }
    [JetBrains.ReSharper.Psi.Resolve.ReferenceProviderFactoryAttribute()]
    public class VbPathReferenceProviderFactory : JetBrains.ReSharper.Psi.Resolve.IReferenceProviderFactory
    {
        public VbPathReferenceProviderFactory(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ReSharper.Psi.CodeAnnotations.CodeAnnotationsCache codeAnnotationsCache) { }
        public event System.Action OnChanged;
        public JetBrains.ReSharper.Psi.Resolve.IReferenceFactory CreateFactory(JetBrains.ReSharper.Psi.IPsiSourceFile sourceFile, JetBrains.ReSharper.Psi.Tree.IFile file) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.Asp.VB.ExpectedTypes
{
    
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.VB.VBLanguage))]
    public class MvcVBExpectedTypesProvider : JetBrains.ReSharper.Psi.VB.ExpectedTypes.VBExpectedTypesProvider
    {
        public override System.Collections.Generic.IList<JetBrains.ReSharper.Psi.ExpectedTypes.ExpectedType> GetExpectedTypes(JetBrains.ReSharper.Psi.VB.Tree.IVBExpression expression, JetBrains.ReSharper.Psi.ExpectedTypes.ExpectedTypeMode mode = 1) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.Asp.VB.Generate
{
    
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.VB.VBLanguage))]
    public class AspEventSubscriptionVBLanguageService : JetBrains.ReSharper.Feature.Services.Asp.Generate.AspEventSubscriptionKnownLanguageService
    {
        public override void FilterEventsLanguageCanHandle(JetBrains.ReSharper.Feature.Services.Asp.Generate.AspGeneratorContext context, bool autoEventWireup, System.Collections.Generic.List<JetBrains.ReSharper.Psi.DeclaredElementInstance<JetBrains.ReSharper.Psi.IEvent>> events) { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.Asp.VB.LiveTemplates
{
    
    [JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ScopeCategoryUIProviderAttribute(Priority=-20D, ScopeFilter=JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ScopeFilter.Project)]
    public class AspVBProjectScopeCategoryUIProvider : JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ScopeCategoryUIProvider
    {
        public AspVBProjectScopeCategoryUIProvider() { }
        public override string CategoryCaption { get; }
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint> BuildAllPoints() { }
    }
    [JetBrains.Application.ShellComponentAttribute()]
    public class AspVBProjectScopeProvider : JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ScopeProvider
    {
        public AspVBProjectScopeProvider() { }
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint> ProvideScopePoints(JetBrains.ReSharper.Feature.Services.LiveTemplates.Context.TemplateAcceptanceContext context) { }
    }
    public class InAspVBProject : JetBrains.ReSharper.Feature.Services.Asp.LiveTemplates.Scope.InLanguageSpecificWebProject, JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.IMainScopePoint, JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint
    {
        public InAspVBProject() { }
        public override string PresentableShortName { get; }
        public string QuickListTitle { get; }
        public System.Guid QuickListUID { get; }
        public override System.Guid GetDefaultUID() { }
    }
}
namespace JetBrains.ReSharper.Feature.Services.Asp.VB.LiveTemplates.Support
{
    
    [JetBrains.ReSharper.Feature.Services.LiveTemplates.Support.FileTemplatesAttribute()]
    public class AspVbFileTemplatesSupport : JetBrains.ReSharper.Feature.Services.Asp.LiveTemplates.AspFileTemplatesSupportBase
    {
        protected override JetBrains.ProjectModel.Properties.ProjectLanguage Language { get; }
        public override string Name { get; }
        public override System.Collections.Generic.IEnumerable<JetBrains.ReSharper.Feature.Services.LiveTemplates.Scope.ITemplateScopePoint> ScopePoints { get; }
    }
}
namespace JetBrains.ReSharper.Feature.Services.Asp.VB.Resources
{
    
    public sealed class ServicesAspVBThemedIcons
    {
        [JetBrains.UI.Icons.CompiledIcons.CompiledIconClassAttribute("JetBrains.ReSharper.Feature.Services.Asp.VB;component/resources/ServicesAspVBThem" +
            "edIcons/ThemedIcons.ServicesAspVB.Generated.Xaml", 0, "ScopeAspvb")]
        public sealed class ScopeAspvb : JetBrains.UI.Icons.CompiledIcons.CompiledIconClass
        {
            public static JetBrains.UI.Icons.IconId Id;
        }
    }
}
namespace JetBrains.ReSharper.Feature.Services.Asp.VB.Search
{
    
    [JetBrains.ReSharper.Psi.LanguageAttribute(typeof(JetBrains.ReSharper.Psi.VB.VBLanguage))]
    public class VBMvcSearchSupported : JetBrains.ReSharper.Feature.Services.Asp.Search.IMvcSearchSupported { }
}
namespace JetBrains.ReSharper.Feature.Services.Asp.VB.TypingAssist
{
    
    [JetBrains.ProjectModel.SolutionComponentAttribute(JetBrains.Application.Components.ProgramConfigurations.NONE | JetBrains.Application.Components.ProgramConfigurations.STANDALONE | JetBrains.Application.Components.ProgramConfigurations.TEST | JetBrains.Application.Components.ProgramConfigurations.VS_ADDIN | JetBrains.Application.Components.ProgramConfigurations.ALL)]
    public sealed class AspVBTypingAssist : JetBrains.ReSharper.Feature.Services.VB.TypingAssist.VBTypingAssistBase
    {
        public AspVBTypingAssist(JetBrains.DataFlow.Lifetime lifetime, JetBrains.ProjectModel.ISolution solution, JetBrains.DocumentManagers.DocumentManager documentManager, JetBrains.ReSharper.Psi.Services.CachingLexerService cachingLexerService, JetBrains.Application.Settings.ISettingsStore settingsStore, JetBrains.Application.CommandProcessing.ICommandProcessor commandProcessor, JetBrains.ReSharper.Feature.Services.TypingAssist.ITypingAssistManager typingAssistManager, JetBrains.ReSharper.Psi.IPsiServices psiServices) { }
        protected override int AdjustLineIndent(JetBrains.TextControl.ITextControl textControl, int originalOffset, int currentOffset) { }
        protected override bool IsSupported(JetBrains.TextControl.ITextControl textControl) { }
        public override bool QuickCheckAvailability(JetBrains.TextControl.ITextControl textControl, JetBrains.ReSharper.Psi.IPsiSourceFile projectFile) { }
        public override int TextControlToLexer(JetBrains.TextControl.ITextControl textControl, int offset) { }
    }
}